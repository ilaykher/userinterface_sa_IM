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

        LoadProducts()

    End Sub
    Private Sub UserInterfaceNew_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ActiveControl = Nothing   ' removes focus from everything
    End Sub

    ' =============== Load Every Products in database with design ===================

    Private Sub LoadProducts()
        Panel3.Controls.Clear()

        Dim connectionString As String = "server=localhost;user=root;password=;database=information_management"
        Dim query As String = "SELECT product_name, price, image_path, category FROM Products"

        Using con As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, con)
                con.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                Dim x As Integer = 10
                Dim y As Integer = 10
                Dim cardWidth As Integer = 310
                Dim cardHeight As Integer = 411
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
                        .SizeMode = PictureBoxSizeMode.Zoom
                    }
                    Dim imgPath As String = reader("image_path").ToString()
                    If File.Exists(imgPath) Then
                        pic.Image = Image.FromFile(imgPath)
                    End If
                    card.Controls.Add(pic)

                    ' === Product Name ===
                    Dim lblName As New Label With {
                        .Text = reader("product_name").ToString(),
                        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                        .Location = New Point(10, 220),
                        .AutoSize = True
                    }
                    card.Controls.Add(lblName)

                    ' === Price ===
                    Dim lblPrice As New Label With {
                        .Text = "₱" & Convert.ToDecimal(reader("price")).ToString("N2"),
                        .Font = New Font("Segoe UI", 9, FontStyle.Regular),
                        .ForeColor = Color.FromArgb(120, 90, 50),
                        .Location = New Point(10, 260),
                        .AutoSize = True
                    }
                    card.Controls.Add(lblPrice)

                    '== Category ======
                    Dim lblCategory As New Label With {
                        .Text = "Category: " & reader("category").ToString(),
                        .Font = New Font("Segoe UI", 8, FontStyle.Italic),
                        .ForeColor = Color.FromArgb(120, 100, 80),
                        .Location = New Point(10, 240),
                        .AutoSize = True
                    }
                    card.Controls.Add(lblCategory)

                    Dim productName As String = reader("product_name").ToString()

                    ' === Add to Cart Button ===
                    Dim btnAdd As New Button With {
                        .Text = "View Details",
                        .BackColor = Color.FromArgb(230, 200, 160),
                        .FlatStyle = FlatStyle.Popup,
                        .Location = New Point(150, 350),
                        .Size = New Size(130, 25),
                        .Tag = New With {
                        .Name = productName    'GET PRODUCT NAME OF WHICHEVER CARD WAS CLICKED'
                        }
                    }

                    '=========== EVENT HANDLER FOR VIEW BUTTON =================
                    AddHandler btnAdd.Click, Sub(sender As Object, e As EventArgs)

                                                 Dim btn As Button = DirectCast(sender, Button)
                                                 Dim info = btn.Tag

                                                 ' Example: open your ProductDetails form and pass data
                                                 Dim Details As New ProductDetails()
                                                 Details.ProductName = info.Name
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

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
End Class