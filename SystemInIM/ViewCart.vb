Imports MySql.Data.MySqlClient

Public Class ViewCart
    Dim priceOfselectedItem As Decimal = 0
    Dim totalPrice As Decimal = 0
    Dim totalQuantity As Integer = 0
    Dim productname As String
    Private allChecked As Boolean = False
    Private Sub ViewCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --------------------Populate combobox :D

        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Items.Add("  Search By Name:")
        ComboBox1.Items.Add("  Search By Category")

        ComboBox1.SelectedIndex = 0
        LoadCart(Globals.LoggedInUserId)

        'call checkbox event
        AddHandler DataGridView1.CurrentCellDirtyStateChanged, AddressOf DataGridView1_CurrentCellDirtyStateChanged

    End Sub

    Public Sub LoadCart(userid As Integer)

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

        Dim con As New MySqlConnection(connectionString)
        con.Open()

        Using cmd As New MySqlCommand("SELECT product_name, price, quantity FROM cart WHERE user_id = @userid", con)
            cmd.Parameters.AddWithValue("@userid", userid)

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


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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
End Class