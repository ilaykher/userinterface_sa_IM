Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FrmUserInterface

    ' 1. CLASS-LEVEL DECLARATIONS & SETUP

    ' USER INFO
    Public LoggedInUsername As String = ""
    Public LoggedInUserID As Integer = Globals.LoggedInUserId

    ' DATABASE CONNECTION (Centralized)
    Private ReadOnly ConnString As String = "server=localhost;user=root;password=;database=information_management"

    ' Helper to create a new connection instance
    Private Function GetNewConnection() As MySqlConnection
        Return New MySqlConnection(ConnString)
    End Function

    ' 2. FORM LIFECYCLE EVENTS

    ' FORM LOAD (Initial Setup)
    Private Sub FrmUserInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Display User Info
        lblWelcome.Text = "Welcome, " & LoggedInUsername

        ' 2. Load User Data
        LoadUserBalance()

        ' 3. Reset Filters to default state
        txtSearchBar.Clear()
        cmbCategorySearch.SelectedIndex = 0

        ' 4. Load Products and apply formatting
        LoadProducts()

        ' 5. Ensure nothing is selected on load
        dgvProductDisplay.ClearSelection()
    End Sub

    ' TAB CONTROL EVENT (For Cart Management)
    Private Sub tbControlMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbControlMain.SelectedIndexChanged
        ' When user switches to View Cart tab (assuming it's index 1)
        If tbControlMain.SelectedIndex = 1 Then
            LoadCart()
        End If
    End Sub

    ' LOGOUT
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Hide()
            Dim loginForm As New FrmLogin()
            loginForm.Show()
        End If
    End Sub

    ' 3. BALANCE FUNCTIONS & EVENTS

    Private Sub LoadUserBalance()
        Using conn As MySqlConnection = GetNewConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT balance FROM users WHERE user_id = @uid"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                    Dim result = cmd.ExecuteScalar()
                    Dim balance As Decimal = 0

                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        ' Ensure the balance variable is updated correctly
                        balance = Convert.ToDecimal(result)
                    End If

                    ' Display formatted balance
                    lblShowBalance.Text = "Balance: ₱" & balance.ToString("N2")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading balance: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BtnBalance_Click(sender As Object, e As EventArgs) Handles BtnBalance.Click
        Dim amount As Decimal

        If Decimal.TryParse(txtUserBalance.Text, amount) AndAlso amount > 0 Then
            Using conn As MySqlConnection = GetNewConnection()
                Try
                    conn.Open()
                    Dim query As String = "UPDATE users SET balance = balance + @amt WHERE user_id = @uid"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@amt", amount)
                        cmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Balance added: ₱" & amount.ToString("N2"))
                    txtUserBalance.Clear()
                    LoadUserBalance()

                Catch ex As Exception
                    MessageBox.Show("Error adding balance: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please enter a valid amount!")
        End If
    End Sub

    ' 4. PRODUCT DISPLAY & SEARCH FUNCTIONS

    ' LOAD/REFRESH PRODUCTS (Base Function)
    Private Sub LoadProducts()
        SearchProducts() ' Use the search function with no filters for a full load
    End Sub

    ' SEARCH LOGIC (Handles both initial load and filtering)
    Private Sub SearchProducts()
        Using conn As MySqlConnection = GetNewConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT product_id, image_path, product_name, category, price, stock, description FROM products WHERE 1=1"

                ' Add search by name
                If Not String.IsNullOrEmpty(txtSearchBar.Text.Trim()) Then
                    query &= " AND product_name LIKE @search"
                End If

                ' Add filter by category
                If cmbCategorySearch.SelectedIndex > 0 Then
                    query &= " AND category = @category"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrEmpty(txtSearchBar.Text.Trim()) Then
                        cmd.Parameters.AddWithValue("@search", "%" & txtSearchBar.Text.Trim() & "%")
                    End If
                    If cmbCategorySearch.SelectedIndex > 0 Then
                        cmd.Parameters.AddWithValue("@category", cmbCategorySearch.SelectedItem.ToString())
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Add images column and load images
                    dt.Columns.Add("Image", GetType(Image))
                    For Each row As DataRow In dt.Rows
                        ' Uses DataRow.Field(Of T) for safer type access
                        Dim imagePath As String = row.Field(Of String)("image_path")
                        If Not String.IsNullOrEmpty(imagePath) AndAlso System.IO.File.Exists(imagePath) Then
                            row("Image") = Image.FromFile(imagePath)
                        End If
                    Next

                    dgvProductDisplay.DataSource = dt
                    FormatDataGridView()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading products: " & ex.Message)
            End Try
        End Using
    End Sub

    ' PRODUCT DISPLAY FORMATTING
    Private Sub FormatDataGridView()
        If dgvProductDisplay.Columns.Count = 0 Then Return

        ' Horizontal & Vertical Layout Fixes
        dgvProductDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductDisplay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgvProductDisplay.AllowUserToAddRows = False

        ' Column Setup
        With dgvProductDisplay.Columns
            .Item("image_path").Visible = False

            .Item("product_id").DisplayIndex = 0 : .Item("product_id").HeaderText = "ID" : .Item("product_id").Width = 50
            .Item("Image").DisplayIndex = 1 : .Item("Image").HeaderText = "Image"
            .Item("product_name").DisplayIndex = 2 : .Item("product_name").HeaderText = "Product Name" : .Item("product_name").Width = 150
            .Item("category").DisplayIndex = 3 : .Item("category").HeaderText = "Category" : .Item("category").Width = 100
            .Item("price").DisplayIndex = 4 : .Item("price").HeaderText = "Price" : .Item("price").Width = 100
            .Item("stock").DisplayIndex = 5 : .Item("stock").HeaderText = "Stock" : .Item("stock").Width = 70
            .Item("description").DisplayIndex = 6 : .Item("description").HeaderText = "Description" : .Item("description").Width = 200

            ' Formatting
            .Item("price").DefaultCellStyle.Format = "₱#,##0.00"
            CType(.Item("Image"), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
            CType(.Item("Image"), DataGridViewImageColumn).Width = 80
        End With

        dgvProductDisplay.RowTemplate.Height = 70
        dgvProductDisplay.ClearSelection()
    End Sub

    ' PRODUCT SEARCH EVENTS
    Private Sub txtSearchBar_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBar.TextChanged
        SearchProducts()
    End Sub

    Private Sub cmbCategorySearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategorySearch.SelectedIndexChanged
        SearchProducts()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        txtSearchBar.Clear()
        cmbCategorySearch.SelectedIndex = 0
        LoadProducts()
        MessageBox.Show("Products refreshed!")
    End Sub

    ' 5. PRODUCT ACTIONS (Buy Now & Add To Cart)

    ' BUY NOW (Single Item Checkout)
    Private Sub BtnBuyNow_Click(sender As Object, e As EventArgs) Handles BtnBuyNow.Click
        If dgvProductDisplay.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product first!")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvProductDisplay.SelectedRows(0)
        ' Use DirectCast to safely access cell values and ensure they are correct types
        Dim productID As Integer = Convert.ToInt32(selectedRow.Cells("product_id").Value)
        Dim productName As String = selectedRow.Cells("product_name").Value.ToString()
        Dim price As Decimal = Convert.ToDecimal(selectedRow.Cells("price").Value)
        Dim stock As Integer = Convert.ToInt32(selectedRow.Cells("stock").Value)

        If stock <= 0 Then
            MessageBox.Show("Out of stock!")
            Return
        End If

        Using conn As MySqlConnection = GetNewConnection()
            Try
                conn.Open()

                ' Get user balance
                Dim balQuery As String = "SELECT balance FROM users WHERE user_id = @uid"
                Dim balance As Decimal = 0
                Using balCmd As New MySqlCommand(balQuery, conn)
                    balCmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                    Dim result = balCmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        balance = Convert.ToDecimal(result)
                    End If
                End Using

                ' Check balance
                If balance < price Then
                    MessageBox.Show("Insufficient balance!" & vbCrLf & "Need: ₱" & price.ToString("N2") & vbCrLf & "You have: ₱" & balance.ToString("N2"))
                    Return
                End If

                ' Confirm purchase
                If MessageBox.Show("Buy " & productName & " for ₱" & price.ToString("N2") & "?", "Confirm Purchase", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                    ' Calculate new balance BEFORE execution to use in success message
                    Dim newBalance As Decimal = balance - price

                    ' Deduct balance
                    Dim updateBal As String = "UPDATE users SET balance = balance - @price WHERE user_id = @uid"
                    Using balUpdateCmd As New MySqlCommand(updateBal, conn)
                        balUpdateCmd.Parameters.AddWithValue("@price", price)
                        balUpdateCmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                        balUpdateCmd.ExecuteNonQuery()
                    End Using

                    ' Reduce stock
                    Dim updateStock As String = "UPDATE products SET stock = stock - 1 WHERE product_id = @pid"
                    Using stockCmd As New MySqlCommand(updateStock, conn)
                        stockCmd.Parameters.AddWithValue("@pid", productID)
                        stockCmd.ExecuteNonQuery()
                    End Using

                    ' Save order
                    Dim orderQuery As String = "INSERT INTO orders (user_id, product_id, product_name, price, order_date) VALUES (@uid, @pid, @pname, @price, NOW())"
                    Using orderCmd As New MySqlCommand(orderQuery, conn)
                        orderCmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                        orderCmd.Parameters.AddWithValue("@pid", productID)
                        orderCmd.Parameters.AddWithValue("@pname", productName)
                        orderCmd.Parameters.AddWithValue("@price", price)
                        orderCmd.ExecuteNonQuery()
                    End Using

                    ' FIX: Use the calculated newBalance variable to avoid the math error in the string
                    MessageBox.Show("Purchase successful! Remaining balance: ₱" & newBalance.ToString("N2"))

                    ' Refresh UI
                    LoadUserBalance()
                    LoadProducts()
                End If

            Catch ex As Exception
                MessageBox.Show("Error processing purchase: " & ex.Message)
            End Try
        End Using
    End Sub

    ' ADD TO CART
    Private Sub BtnAddToCart_Click(sender As Object, e As EventArgs) Handles BtnAddToCart.Click
        If dgvProductDisplay.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product first!")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvProductDisplay.SelectedRows(0)
        Dim productID As Integer = Convert.ToInt32(selectedRow.Cells("product_id").Value)
        Dim productName As String = selectedRow.Cells("product_name").Value.ToString()
        Dim price As Decimal = Convert.ToDecimal(selectedRow.Cells("price").Value)
        Dim stock As Integer = Convert.ToInt32(selectedRow.Cells("stock").Value)
        Dim description As String = selectedRow.Cells("description").Value.ToString()

        Const QTY_TO_ADD As Integer = 1

        If stock <= 0 Then
            MessageBox.Show("Out of stock!")
            Return
        End If

        Using conn As MySqlConnection = GetNewConnection()
            Try
                conn.Open()

                ' 1. Check if item exists in cart and check stock limit
                Dim checkQuery As String = "SELECT quantity FROM cart WHERE user_id = @uid AND product_id = @pid"
                Dim currentQty As Integer = 0
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                    checkCmd.Parameters.AddWithValue("@pid", productID)
                    Dim result = checkCmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        currentQty = Convert.ToInt32(result)
                    End If
                End Using

                If currentQty + QTY_TO_ADD > stock Then
                    MessageBox.Show("Cannot add more! Only " & stock & " total available in stock.")
                    Return
                End If

                Dim newTotalQty As Integer = currentQty + QTY_TO_ADD

                If currentQty > 0 Then
                    ' 2. Item exists: Update quantity
                    Dim updateQuery As String = "UPDATE cart SET quantity = quantity + @qty WHERE user_id = @uid AND product_id = @pid"
                    Using updateCmd As New MySqlCommand(updateQuery, conn)
                        updateCmd.Parameters.AddWithValue("@qty", QTY_TO_ADD)
                        updateCmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                        updateCmd.Parameters.AddWithValue("@pid", productID)
                        updateCmd.ExecuteNonQuery()
                    End Using
                Else
                    ' 3. Item does not exist: Insert new row
                    Dim insertQuery As String = "INSERT INTO cart (user_id, product_id, product_name, price, description, quantity) VALUES (@uid, @pid, @pname, @price, @desc, @qty)"
                    Using insertCmd As New MySqlCommand(insertQuery, conn)
                        insertCmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                        insertCmd.Parameters.AddWithValue("@pid", productID)
                        insertCmd.Parameters.AddWithValue("@pname", productName)
                        insertCmd.Parameters.AddWithValue("@price", price)
                        insertCmd.Parameters.AddWithValue("@desc", description)
                        insertCmd.Parameters.AddWithValue("@qty", QTY_TO_ADD)
                        insertCmd.ExecuteNonQuery()
                    End Using
                End If

                MessageBox.Show(productName & " added to cart! Current Quantity: " & newTotalQty)

            Catch ex As Exception
                MessageBox.Show("Error adding to cart: " & ex.Message)
            End Try
        End Using
    End Sub

    ' 6. CART FUNCTIONS & EVENTS

    ' LOAD CART (View Cart Tab)
    Private Sub LoadCart()
        SearchCart()
    End Sub

    ' CART SEARCH & FILTERING
    Private Sub SearchCart()
        Using conn As MySqlConnection = GetNewConnection()
            Try
                conn.Open()

                Dim query As String = "SELECT c.cart_id, c.product_name, c.price, c.description, c.quantity, (c.price * c.quantity) AS subtotal, p.category " &
                                    "FROM cart c " &
                                    "JOIN products p ON c.product_id = p.product_id " &
                                    "WHERE c.user_id = @uid"

                ' Add search filter
                If Not String.IsNullOrEmpty(txtBoxSearchBarViewCart.Text.Trim()) Then
                    query &= " AND c.product_name LIKE @search"
                End If

                ' Add category filter
                If cmbCategoryViewCart.SelectedIndex > 0 Then
                    query &= " AND p.category = @category"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@uid", LoggedInUserID)

                    If Not String.IsNullOrEmpty(txtBoxSearchBarViewCart.Text.Trim()) Then
                        cmd.Parameters.AddWithValue("@search", "%" & txtBoxSearchBarViewCart.Text.Trim() & "%")
                    End If

                    If cmbCategoryViewCart.SelectedIndex > 0 Then
                        cmd.Parameters.AddWithValue("@category", cmbCategoryViewCart.SelectedItem.ToString())
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    DataGridView1.DataSource = dt
                    FormatCartDataGridView()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading cart: " & ex.Message)
            End Try
        End Using
    End Sub

    ' CART DISPLAY FORMATTING
    Private Sub FormatCartDataGridView()
        If DataGridView1.Columns.Count = 0 Then Return

        ' General Cleanup
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AllowUserToAddRows = False

        With DataGridView1.Columns
            .Item("cart_id").Visible = False
            If .Contains("category") Then .Item("category").Visible = False

            .Item("product_name").HeaderText = "Product" : .Item("product_name").Width = 200
            .Item("price").HeaderText = "Price" : .Item("price").Width = 120
            .Item("description").HeaderText = "Description" : .Item("description").Width = 250
            .Item("quantity").HeaderText = "Qty" : .Item("quantity").Width = 80
            .Item("subtotal").HeaderText = "Subtotal" : .Item("subtotal").Width = 120

            .Item("price").DefaultCellStyle.Format = "₱#,##0.00"
            .Item("subtotal").DefaultCellStyle.Format = "₱#,##0.00"
        End With

        DataGridView1.RowTemplate.Height = 50
        DataGridView1.ClearSelection()
    End Sub

    ' CART SEARCH EVENTS
    Private Sub txtBoxSearchBarViewCart_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSearchBarViewCart.TextChanged
        SearchCart()
    End Sub

    Private Sub cmbCategoryViewCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoryViewCart.SelectedIndexChanged
        SearchCart()
    End Sub

    Private Sub BtnRefreshAll_Click(sender As Object, e As EventArgs) Handles BtnRefreshAll.Click
        txtBoxSearchBarViewCart.Clear()
        cmbCategoryViewCart.SelectedIndex = 0
        LoadCart()
        MessageBox.Show("Cart refreshed!")
    End Sub

    ' REMOVE SINGLE ITEM FROM CART
    Private Sub BtnRemoveAddToCart_Click(sender As Object, e As EventArgs) Handles BtnRemoveAddToCart.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to remove!")
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim cartID As Integer = Convert.ToInt32(selectedRow.Cells("cart_id").Value)
        Dim productName As String = selectedRow.Cells("product_name").Value.ToString()

        If MessageBox.Show("Remove " & productName & " from cart?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As MySqlConnection = GetNewConnection()
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM cart WHERE cart_id = @cid"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@cid", cartID)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Item removed from cart!")
                    LoadCart()

                Catch ex As Exception
                    MessageBox.Show("Error removing item: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    ' REMOVE ALL ITEMS FROM CART
    Private Sub BtnRemoveAll_Click(sender As Object, e As EventArgs) Handles BtnRemoveAll.Click
        If MessageBox.Show("Remove all items from cart?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As MySqlConnection = GetNewConnection()
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM cart WHERE user_id = @uid"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("All items removed from cart!")
                    LoadCart()

                Catch ex As Exception
                    MessageBox.Show("Error removing all items: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    ' PLACE AN ORDER (Checkout)
    Private Sub BtnPlaceAnOrder_Click(sender As Object, e As EventArgs) Handles BtnPlaceAnOrder.Click
        Using conn As MySqlConnection = GetNewConnection()
            Try
                conn.Open()

                ' 1. Get balance and check
                Dim balQuery As String = "SELECT balance FROM users WHERE user_id = @uid"
                Dim currentBalance As Decimal = 0
                Using balCmd As New MySqlCommand(balQuery, conn)
                    balCmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                    Dim result = balCmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        currentBalance = Convert.ToDecimal(result)
                    End If
                End Using

                ' 2. Get cart items and calculate total
                Dim cartItems As New List(Of Object)
                Dim totalAmount As Decimal = 0

                Dim cartQuery As String = "SELECT product_id, product_name, price, quantity FROM cart WHERE user_id = @uid"
                Using cartCmd As New MySqlCommand(cartQuery, conn)
                    cartCmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                    Using reader As MySqlDataReader = cartCmd.ExecuteReader()
                        While reader.Read()
                            Dim item = New With {
                                .ProductID = Convert.ToInt32(reader("product_id")),
                                .ProductName = reader("product_name").ToString(),
                                .Price = Convert.ToDecimal(reader("price")),
                                .Quantity = Convert.ToInt32(reader("quantity")),
                                .Subtotal = Convert.ToDecimal(reader("price")) * Convert.ToInt32(reader("quantity"))
                            }
                            cartItems.Add(item)
                            totalAmount += item.Subtotal
                        End While
                    End Using
                End Using

                If cartItems.Count = 0 Then
                    MessageBox.Show("Your cart is empty!")
                    Return
                End If

                If currentBalance < totalAmount Then
                    MessageBox.Show("Insufficient balance! Total: ₱" & totalAmount.ToString("N2") & vbCrLf & "Your balance: ₱" & currentBalance.ToString("N2"))
                    Return
                End If

                ' 3. Confirm and Execute Purchase
                Dim confirmResult As DialogResult = MessageBox.Show("Checkout cart for ₱" & totalAmount.ToString("N2") & "?", "Confirm Checkout", MessageBoxButtons.YesNo)

                If confirmResult = DialogResult.Yes Then

                    ' Calculate new balance BEFORE execution
                    Dim newBalance As Decimal = currentBalance - totalAmount

                    ' Deduct balance
                    Dim updateBal As String = "UPDATE users SET balance = balance - @total WHERE user_id = @uid"
                    Using balUpdateCmd As New MySqlCommand(updateBal, conn)
                        balUpdateCmd.Parameters.AddWithValue("@total", totalAmount)
                        balUpdateCmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                        balUpdateCmd.ExecuteNonQuery()
                    End Using

                    ' Process each item (Reduce Stock & Create Order Record)
                    For Each item In cartItems
                        ' Reduce stock
                        Dim updateStock As String = "UPDATE products SET stock = stock - @qty WHERE product_id = @pid"
                        Using stockCmd As New MySqlCommand(updateStock, conn)
                            stockCmd.Parameters.AddWithValue("@qty", item.Quantity)
                            stockCmd.Parameters.AddWithValue("@pid", item.ProductID)
                            stockCmd.ExecuteNonQuery()
                        End Using

                        ' Create order record (Note: price used here is subtotal of the line item)
                        Dim orderQuery As String = "INSERT INTO orders (user_id, product_id, product_name, price, order_date) VALUES (@uid, @pid, @pname, @price, NOW())"
                        Using orderCmd As New MySqlCommand(orderQuery, conn)
                            orderCmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                            orderCmd.Parameters.AddWithValue("@pid", item.ProductID)
                            orderCmd.Parameters.AddWithValue("@pname", item.ProductName)
                            orderCmd.Parameters.AddWithValue("@price", item.Subtotal)
                            orderCmd.ExecuteNonQuery()
                        End Using
                    Next

                    ' Clear cart
                    Dim clearCart As String = "DELETE FROM cart WHERE user_id = @uid"
                    Using clearCmd As New MySqlCommand(clearCart, conn)
                        clearCmd.Parameters.AddWithValue("@uid", LoggedInUserID)
                        clearCmd.ExecuteNonQuery()
                    End Using

                    ' FIX: Use the calculated newBalance variable
                    MessageBox.Show("Checkout successful! Remaining balance: ₱" & newBalance.ToString("N2"))

                    ' Refresh all UI components
                    LoadUserBalance()
                    LoadProducts()
                    LoadCart()
                End If

            Catch ex As Exception
                MessageBox.Show("Error during checkout: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class