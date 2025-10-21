Imports MySql.Data.MySqlClient
Imports System.IO
Public Class UserInetrfaceNew

    '=============At load
    Private Sub UserInetrfaceNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --------------------Populate combobox :D
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Items.Add("  Search By Name:")
        ComboBox1.Items.Add("  Search By Category")
        ComboBox1.SelectedIndex = 0

        '--------------- POPULATE TRACKBAR -----------------
        TrackBar1.Minimum = 0
        TrackBar1.Maximum = 100000
        TrackBar1.TickFrequency = 500
        TrackBar1.Value = 50000

        TrackBar2.Minimum = 0
        TrackBar2.Maximum = 100000
        TrackBar2.TickFrequency = 500
        TrackBar2.Value = 50000

        ' wire Enter key on TextBox1 to trigger search
        AddHandler TextBox1.KeyDown, AddressOf TextBox1_KeyDown

        LoadProducts() ' initial load without filters
    End Sub

    Private Sub UserInterfaceNew_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ActiveControl = Nothing   ' removes focus from everything
    End Sub

    ' =============== Load Every Products in database with design ===================
    ' This version accepts optional filters. Pass empty strings/defaults to load all.
    Private Sub LoadProducts(Optional ByVal searchTerm As String = "",
                             Optional ByVal searchBy As String = "name",
                             Optional ByVal minPrice As Decimal = 0D,
                             Optional ByVal maxPrice As Decimal = 100000D,
                             Optional ByVal stockFilter As Integer = -1)
        Panel3.Controls.Clear()

        Dim connectionString As String = "server=localhost;user=root;password=;database=information_management"
        Dim baseQuery As String = "SELECT product_name, price, image_path, category, stock, sold_count, location FROM products"
        Dim whereClauses As New List(Of String)
        Dim parameters As New Dictionary(Of String, Object)

        ' Search by name or category
        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            If searchBy = "category" Then
                whereClauses.Add("category LIKE @search")
            Else
                whereClauses.Add("product_name LIKE @search")
            End If
            parameters.Add("@search", "%" & searchTerm & "%")
        End If

        ' Price range
        whereClauses.Add("price BETWEEN @minPrice AND @maxPrice")
        parameters.Add("@minPrice", minPrice)
        parameters.Add("@maxPrice", maxPrice)

        ' Stock filter: -1 = any, 1 = in stock (>0), 0 = out of stock (=0)
        If stockFilter = 1 Then
            whereClauses.Add("stock > 0")
        ElseIf stockFilter = 0 Then
            whereClauses.Add("stock = 0")
        End If

        Dim finalQuery As String = baseQuery
        If whereClauses.Count > 0 Then
            finalQuery &= " WHERE " & String.Join(" AND ", whereClauses)
        End If

        Using con As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(finalQuery, con)
                For Each kvp In parameters
                    cmd.Parameters.AddWithValue(kvp.Key, kvp.Value)
                Next

                con.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    Dim x As Integer = 10
                    Dim y As Integer = 10
                    Dim cardWidth As Integer = 310
                    Dim cardHeight As Integer = 430
                    Dim margin As Integer = 15
                    Dim cardsPerRow As Integer = 3
                    Dim count As Integer = 0

                    While reader.Read()
                        ' === Create a Card Panel ===
                        Dim card As New Panel With {
                            .Size = New Size(cardWidth, cardHeight),
                            .BackColor = Color.FromArgb(255, 250, 240),
                            .BorderStyle = BorderStyle.FixedSingle
                        }

                        ' === Picture ===
                        Dim pic As New PictureBox With {
                            .Size = New Size(240, 209),
                            .Location = New Point(10, 10),
                            .SizeMode = PictureBoxSizeMode.Zoom,
                            .BackColor = Color.White
                        }
                        Dim imgPath As String = If(reader("image_path") Is DBNull.Value, String.Empty, reader("image_path").ToString())
                        If Not String.IsNullOrWhiteSpace(imgPath) AndAlso File.Exists(imgPath) Then
                            Try
                                pic.Image = Image.FromFile(imgPath)
                            Catch
                                pic.Image = Nothing
                            End Try
                        End If
                        card.Controls.Add(pic)

                        ' === Product Name ===
                        Dim lblName As New Label With {
                            .Text = reader("product_name").ToString(),
                            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                            .Location = New Point(10, 225),
                            .AutoSize = True
                        }
                        card.Controls.Add(lblName)

                        ' === Price ===
                        Dim lblPrice As New Label With {
                            .Text = "₱" & Convert.ToDecimal(reader("price")).ToString("N2"),
                            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                            .ForeColor = Color.FromArgb(190, 60, 50),
                            .Location = New Point(10, 250),
                            .AutoSize = True
                        }
                        card.Controls.Add(lblPrice)

                        ' read numeric fields safely
                        Dim stockVal As Integer = If(reader("stock") Is DBNull.Value, 0, Convert.ToInt32(reader("stock")))
                        Dim soldVal As Integer = If(reader("sold_count") Is DBNull.Value, 0, Convert.ToInt32(reader("sold_count")))
                        Dim locationText As String = If(reader("location") Is DBNull.Value, String.Empty, reader("location").ToString())

                        ' === Stock displayed as "#<n>" directly under price ===
                        Dim lblStock As New Label With {
                            .Text = stockVal.ToString() & "x",  ' shows #5, #10 etc.
                            .Font = New Font("Segoe UI", 9, FontStyle.Regular),
                            .ForeColor = Color.FromArgb(100, 80, 60),
                            .Location = New Point(10, 270),
                            .AutoSize = True
                        }
                        card.Controls.Add(lblStock)

                        ' === Sold displayed as "<n> sold" under stock ===
                        Dim soldDisplay As String = If(soldVal >= 1000, (soldVal / 1000).ToString("N0") & "k+ sold", soldVal.ToString() & " sold")
                        Dim lblSold As New Label With {
                            .Text = soldDisplay,
                            .Font = New Font("Segoe UI", 9, FontStyle.Regular),
                            .ForeColor = Color.FromArgb(120, 120, 120),
                            .Location = New Point(10, 290),
                            .AutoSize = True
                        }
                        card.Controls.Add(lblSold)

                        ' === Location (plain text, no prefix) under sold ===
                        Dim lblLocation As New Label With {
                            .Text = locationText,
                            .Font = New Font("Segoe UI", 9, FontStyle.Regular),
                            .ForeColor = Color.FromArgb(100, 80, 60),
                            .Location = New Point(10, 310),
                            .AutoSize = True
                        }
                        card.Controls.Add(lblLocation)

                        ' === Category (small, italic) ===
                        Dim lblCategory As New Label With {
                            .Text = reader("category").ToString(),
                            .Font = New Font("Segoe UI", 8, FontStyle.Italic),
                            .ForeColor = Color.FromArgb(120, 100, 80),
                            .Location = New Point(10, 330),
                            .AutoSize = True
                        }
                        card.Controls.Add(lblCategory)

                        ' === View Details Button ===
                        Dim btnAdd As New Button With {
                            .Text = "View Details",
                            .BackColor = Color.FromArgb(100, 110, 120),
                            .ForeColor = Color.White,
                            .FlatStyle = FlatStyle.Popup,
                            .Location = New Point(150, 370),
                            .Size = New Size(130, 28),
                            .Tag = reader("product_name").ToString()
                        }

                        AddHandler btnAdd.Click, Sub(sender As Object, e As EventArgs)
                                                     Dim btn As Button = DirectCast(sender, Button)
                                                     Dim Details As New ProductDetails()
                                                     Details.ProductName = btn.Tag.ToString()
                                                     Details.Show()
                                                 End Sub

                        card.Controls.Add(btnAdd)

                        ' === Positioning ===
                        card.Location = New Point(x, y)
                        Panel3.Controls.Add(card)

                        count += 1
                        If count Mod cardsPerRow = 0 Then
                            y += cardHeight + margin
                            x = 10
                        Else
                            x += cardWidth + margin
                        End If
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label9.Text = "Price: ₱" & TrackBar1.Value.ToString()
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Label10.Text = "Price: ₱" & TrackBar2.Value.ToString()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim cart As New ViewCart()
        cart.Show()
    End Sub

    ' Search button - gathers UI filters and calls LoadProducts
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PerformSearch()
    End Sub

    Private Sub PerformSearch()
        Dim searchTerm As String = TextBox1.Text.Trim()
        Dim searchBy As String = If(ComboBox1.SelectedIndex = 1, "category", "name")

        ' normalize min/max from both trackbars (in case user uses either one)
        Dim minPrice As Decimal = Math.Min(TrackBar1.Value, TrackBar2.Value)
        Dim maxPrice As Decimal = Math.Max(TrackBar1.Value, TrackBar2.Value)

        ' stockFilter: -1 any, 1 in stock, 0 out of stock
        Dim stockFilter As Integer = -1
        If RadioButton1 IsNot Nothing AndAlso RadioButton1.Checked Then
            stockFilter = 1
        ElseIf RadioButton2 IsNot Nothing AndAlso RadioButton2.Checked Then
            stockFilter = 0
        End If

        LoadProducts(searchTerm, searchBy, minPrice, maxPrice, stockFilter)
    End Sub

    ' allow Enter to trigger search
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            PerformSearch()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
    Private Sub UserInterfaceNew_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' upon closing
        Dim result = MessageBox.Show("Are you sure you want to close?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            e.Cancel = True ' Prevents the form from closing
        Else
            Dim login As New FrmLogin()
            login.Close()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim profile As New Profile()
        profile.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Optional: you can call PerformSearch here for live search, but it may fire on every keystroke.
        ' PerformSearch()
    End Sub

    Public Sub RefreshProducts()
        ' Expose a thread-safe way for other forms to refresh the product listing
        If Me.IsDisposed Then Return
        If Me.InvokeRequired Then
            Me.Invoke(Sub() LoadProducts())
        Else
            LoadProducts()
        End If
    End Sub
End Class