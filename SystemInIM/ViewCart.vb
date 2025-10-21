Imports MySql.Data.MySqlClient

Public Class ViewCart
    Dim priceOfselectedItem As Decimal = 0
    Dim totalPrice As Decimal = 0
    Dim totalQuantity As Integer = 0
    Dim productname As String
    Private allChecked As Boolean = False

    ' NumericUpDown overlay used for polished quantity editing
    Private nudQuantity As NumericUpDown

    Private Sub ViewCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --------------------Populate combobox :D

        ComboBox1.SelectedIndex = 0

        ' wire Enter on search box to perform search
        AddHandler TextBox1.KeyDown, AddressOf TextBox1_KeyDown

        LoadCart(Globals.LoggedInUserId)

        'call checkbox event
        AddHandler DataGridView1.CurrentCellDirtyStateChanged, AddressOf DataGridView1_CurrentCellDirtyStateChanged

    End Sub

    ' LoadCart now supports optional search
    Public Sub LoadCart(userid As Integer, Optional searchTerm As String = "", Optional searchByCategory As Boolean = False)

        ' reset totals
        priceOfselectedItem = 0
        totalPrice = 0
        totalQuantity = 0
        productname = ""
        Label3.Text = "₱0.00"
        Label2.Text = "Total: (0 item)"
        Button3.Text = If(allChecked, "Uncheck All", "Check All")

        '===================CART DESIGN========================
        With DataGridView1
            ' checkbox column
            If Not DataGridView1.Columns.Contains("chkSelect") Then
                Dim chkColumn As New DataGridViewCheckBoxColumn()
                chkColumn.HeaderText = "Select"
                chkColumn.Name = "chkSelect"
                chkColumn.Width = 50
                DataGridView1.Columns.Insert(0, chkColumn)
            End If

            'picture column
            If Not DataGridView1.Columns.Contains("imgProduct") Then
                Dim imgColumn As New DataGridViewImageColumn()
                imgColumn.HeaderText = "Image"
                imgColumn.Name = "imgProduct"
                imgColumn.Width = 100
                DataGridView1.Columns.Insert(1, imgColumn)
            End If

            '===design===
            .EnableHeadersVisualStyles = False
            .GridColor = Color.OldLace
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AllowUserToAddRows = False

            ' === Fonts ===
            .DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            'row 
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .RowTemplate.Height = 80

        End With

        '=========================================

        Dim connectionString As String = "server=localhost;user=root;password=;database=information_management"

        Using con As New MySqlConnection(connectionString)
            con.Open()

            ' Build query depending on search inputs
            Dim sql As String
            Dim cmd As MySqlCommand

            searchTerm = If(searchTerm, "").Trim()

            If String.IsNullOrWhiteSpace(searchTerm) Then
                sql = "SELECT product_name, price, quantity FROM cart WHERE user_id = @userid"
                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@userid", userid)
            Else
                If searchByCategory Then
                    ' join with products to filter by category
                    sql = "SELECT c.product_name, c.price, c.quantity " &
                          "FROM cart c INNER JOIN products p ON c.product_name = p.product_name " &
                          "WHERE c.user_id = @userid AND p.category LIKE @search"
                    cmd = New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@userid", userid)
                    cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                Else
                    ' search by product name in cart
                    sql = "SELECT product_name, price, quantity FROM cart WHERE user_id = @userid AND product_name LIKE @search"
                    cmd = New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@userid", userid)
                    cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                End If
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DataGridView1.DataSource = dt
        End Using

        'make each row uneditable unless its chkselect row and also unsortable'
        For Each col As DataGridViewColumn In DataGridView1.Columns
            If col.Name = "chkSelect" Then
                col.ReadOnly = False
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Else
                col.ReadOnly = True
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            End If
        Next

        ' ensure +/- button columns exist (added after datasource so they don't disappear)
        If Not DataGridView1.Columns.Contains("btnAdd") Then
            Dim btnAdd As New DataGridViewButtonColumn()
            btnAdd.HeaderText = "+"
            btnAdd.Name = "btnAdd"
            btnAdd.Text = "+"
            btnAdd.UseColumnTextForButtonValue = True
            btnAdd.Width = 40
            DataGridView1.Columns.Add(btnAdd)
        End If

        If Not DataGridView1.Columns.Contains("btnSubtract") Then
            Dim btnSubtract As New DataGridViewButtonColumn()
            btnSubtract.HeaderText = "-"
            btnSubtract.Name = "btnSubtract"
            btnSubtract.Text = "-"
            btnSubtract.UseColumnTextForButtonValue = True
            btnSubtract.Width = 40
            DataGridView1.Columns.Add(btnSubtract)
        End If

    End Sub

    '=============MAKE CHECKBOX BIGGER================
    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.ColumnIndex = DataGridView1.Columns("chkSelect").Index AndAlso e.RowIndex >= 0 Then
            e.PaintBackground(e.ClipBounds, True)
            e.Handled = True

            Dim chkBoxSize As Integer = 30 ' make this bigger for a larger checkbox
            Dim chkState As Boolean = False
            If Not IsDBNull(e.FormattedValue) Then
                chkState = CBool(e.FormattedValue)
            End If

            Dim centerX As Integer = e.CellBounds.X + (e.CellBounds.Width - chkBoxSize) \ 2
            Dim centerY As Integer = e.CellBounds.Y + (e.CellBounds.Height - chkBoxSize) \ 2

            ControlPaint.DrawCheckBox(e.Graphics, New Rectangle(centerX, centerY, chkBoxSize, chkBoxSize),
                                  If(chkState, ButtonState.Checked, ButtonState.Normal))
        End If
    End Sub

    '================CHECKBOX EVENT===================a
    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        If TypeOf DataGridView1.CurrentCell Is DataGridViewCheckBoxCell AndAlso DataGridView1.IsCurrentCellDirty Then
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Public Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DataGridView1.Columns("chkSelect").Index Then
            productname = DataGridView1.Rows(e.RowIndex).Cells("product_name").Value.ToString()
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim quantity As Decimal = Convert.ToDecimal(row.Cells("quantity").Value)
            Dim priceOfSelectedItem As Decimal = Convert.ToDecimal(row.Cells("price").Value)
            Dim isChecked As Boolean = CBool(row.Cells("chkSelect").Value)

            If isChecked Then
                ' Checkbox checked
                priceOfSelectedItem = priceOfSelectedItem * quantity
                totalPrice += priceOfSelectedItem
                totalQuantity += quantity
            Else
                '  Checkbox uncheckedt
                priceOfSelectedItem = priceOfSelectedItem * quantity
                totalPrice -= priceOfSelectedItem
                totalQuantity -= quantity
                allChecked = False
            End If
            If totalPrice < 0 Then totalPrice = 0
            Label3.Text = "₱" & totalPrice.ToString("N2")
            Label2.Text = "Total: (" & totalQuantity & " item)"
            Button3.Text = If(allChecked, "Uncheck All", "Check All")

        End If
    End Sub



    'checkout button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If paymentIsOpened Then
            'do nothing
            Return

        Else



            ' Collect selected items
            Dim selectedItems As New List(Of (ProductName As String, Price As Decimal, Quantity As Integer))

            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("chkSelect").Value IsNot Nothing AndAlso CBool(row.Cells("chkSelect").Value) Then
                    Dim name As String = row.Cells("product_name").Value.ToString()
                    Dim price As Decimal = Convert.ToDecimal(row.Cells("price").Value)
                    Dim qty As Integer = Convert.ToInt32(row.Cells("quantity").Value)
                    selectedItems.Add((name, price, qty))
                End If
            Next

            If selectedItems.Count = 0 Then
                MessageBox.Show("Please select at least one item before proceeding to payment.",
                            "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            ' Pass to another form
            Dim paymentForm As New modeOfPayment(selectedItems)
            paymentForm.Show()
            Me.Close()
        End If
    End Sub


    ' track the state of checkbox for button3
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        allChecked = Not allChecked
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("chkSelect").Value = allChecked
        Next

        Button3.Text = If(allChecked, "Uncheck All", "Check All")
    End Sub

    'delete button'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New MySqlConnection("server=localhost;user=root;password=;database=information_management")
        con.Open()

        ' === DELETE ALL CHECKED ===
        If allChecked Then
            ' If all items are checked, delete all items for the user
            Using cmd As New MySqlCommand("DELETE FROM cart WHERE user_id = @userid", con)
                cmd.Parameters.AddWithValue("@userid", Globals.LoggedInUserId)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("All items removed from cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No items were found in the cart to remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

            ' Reset & refresh once
            LoadCart(Globals.LoggedInUserId)
            priceOfselectedItem = 0
            totalPrice = 0
            totalQuantity = 0
            productname = ""
            Label3.Text = "₱" & totalPrice.ToString("N2")
            Label2.Text = "Total: (" & totalQuantity & " item)"
            Return
        End If

        ' === DELETE ONLY SELECTED ITEMS ===
        Dim anySelected As Boolean = False

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("chkSelect").Value IsNot Nothing AndAlso CBool(row.Cells("chkSelect").Value) Then
                anySelected = True
                Dim currentProduct As String = row.Cells("product_name").Value.ToString()

                Using cmd2 As New MySqlCommand("DELETE FROM cart WHERE user_id = @userid AND product_name = @productName", con)
                    cmd2.Parameters.AddWithValue("@userid", Globals.LoggedInUserId)
                    cmd2.Parameters.AddWithValue("@productName", currentProduct)
                    cmd2.ExecuteNonQuery()
                End Using
            End If
        Next

        ' === FEEDBACK ===
        If anySelected Then
            MessageBox.Show("Selected items removed from cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCart(Globals.LoggedInUserId)
            priceOfselectedItem = 0
            totalPrice = 0
            totalQuantity = 0
            productname = ""
            Label3.Text = "₱" & totalPrice.ToString("N2")
            Label2.Text = "Total: (" & totalQuantity & " item)"
        Else
            MessageBox.Show("No items were selected to remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        con.Close()
    End Sub

    ' Handle button clicks for + and -
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim productName As String = row.Cells("product_name").Value.ToString()
        Dim currentQty As Integer = Convert.ToInt32(row.Cells("quantity").Value)

        If DataGridView1.Columns(e.ColumnIndex).Name = "btnAdd" Then
            ' Check stock from products table
            Dim stockQty As Integer = GetProductStock(productName)
            If currentQty < stockQty Then
                UpdateCartQuantity(productName, currentQty + 1)
                LoadCart(Globals.LoggedInUserId)
            Else
                MessageBox.Show("Cannot add more. Stock limit reached.", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "btnSubtract" Then
            If currentQty > 1 Then
                UpdateCartQuantity(productName, currentQty - 1)
                LoadCart(Globals.LoggedInUserId)
            Else
                MessageBox.Show("Quantity cannot be less than 1.", "Minimum Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    ' Helper to get product stock from products table
    Private Function GetProductStock(productName As String) As Integer
        Dim stockQty As Integer = 0
        Dim con As New MySqlConnection("server=localhost;user=root;password=;database=information_management")
        con.Open()
        Using cmd As New MySqlCommand("SELECT stock FROM products WHERE product_name = @productName", con)
            cmd.Parameters.AddWithValue("@productName", productName)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                stockQty = Convert.ToInt32(result)
            End If
        End Using
        con.Close()
        Return stockQty
    End Function

    ' Helper to update cart quantity
    Private Sub UpdateCartQuantity(productName As String, newQty As Integer)
        Dim con As New MySqlConnection("server=localhost;user=root;password=;database=information_management")
        con.Open()
        Using cmd As New MySqlCommand("UPDATE cart SET quantity = @qty WHERE user_id = @userid AND product_name = @productName", con)
            cmd.Parameters.AddWithValue("@qty", newQty)
            cmd.Parameters.AddWithValue("@userid", Globals.LoggedInUserId)
            cmd.Parameters.AddWithValue("@productName", productName)
            cmd.ExecuteNonQuery()
        End Using
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    ' trigger search on Enter
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            PerformSearch()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    ' Apply / search button - assumed to be Button4
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PerformSearch()
    End Sub

    Private Sub PerformSearch()
        Dim term As String = If(TextBox1.Text, "").Trim()
        Dim searchByCategory As Boolean = (ComboBox1.SelectedIndex = 1) ' index 1 == category
        LoadCart(Globals.LoggedInUserId, term, searchByCategory)
    End Sub
End Class