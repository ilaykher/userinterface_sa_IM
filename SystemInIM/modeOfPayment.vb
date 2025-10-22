Imports MySql.Data.MySqlClient

Public Class modeOfPayment

    Public Property ProductID As Integer
    Public Property ProductName2 As String
    Public Property ProductPrice As Decimal
    Public Property ProductQuantity As Integer
    Public Property ProductDescription As String

    '============== Needs orders table from db ===================
    Private ReadOnly _selectedItems As List(Of (ProductName As String, Price As Decimal, Quantity As Integer))
    'these variables are for total price calculation
    Dim productPrice1 As Decimal
    Dim totalPrice1 As Decimal
    Dim filupIsOpen As Boolean = False
    Public Sub New()
        'this is from designer which builds the form first
        InitializeComponent()

    End Sub

    Public Sub New(items As List(Of (ProductName As String, Price As Decimal, Quantity As Integer)))
        ' Call the parameterless ctor so InitializeComponent runs
        Me.New() 'calls public sub new
        _selectedItems = items
    End Sub

    '============== At Load ===================
    Private Sub modeOfPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Items.Add("  Cash on Delivery   ")
        ComboBox1.Items.Add("  Online Payment   ")

        ComboBox1.SelectedIndex = 0

        ' ===== Show items in Label1 =====
        If _selectedItems IsNot Nothing AndAlso _selectedItems.Count > 0 Then
            Dim displayText As New Text.StringBuilder()
            displayText.AppendLine(New String("-"c, 30))

            For Each item In _selectedItems
                displayText.AppendLine($"Product: {item.ProductName}")
                displayText.AppendLine($"Price: ₱{item.Price:N2}")
                displayText.AppendLine($"Quantity: {item.Quantity}")
                displayText.AppendLine(New String("-"c, 30))

                productPrice1 = item.Price * item.Quantity
                totalPrice1 = productPrice1 + totalPrice1

            Next

            Label4.Text = $"Total Price: ₱{totalPrice1:N2}"

            Label3.Text = displayText.ToString()
        ElseIf Not String.IsNullOrEmpty(ProductName) Then
            ' Single product (if opened from ProductDetails)
            Label3.Text = $"Product: {ProductName}{Environment.NewLine}" &
                      $"Price: ₱{ProductPrice:N2}{Environment.NewLine}" &
                      $"Quantity: {ProductQuantity}"
            Label4.Text = $"Total Price: ₱{ProductPrice:N2}"
        Else
            Label3.Text = "No products selected."
        End If
    End Sub

    Private Sub modeOfpayment_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        paymentIsOpened = False

        'HARD RESET OF QUANTITY UPON CLOSE (THIS IS FOR BUTTON1 CLICK)'
        ProductQuantity = 0

        If _selectedItems IsNot Nothing AndAlso _selectedItems.Count > 0 Then
            For i As Integer = 0 To _selectedItems.Count - 1
                _selectedItems(i) = (_selectedItems(i).ProductName, _selectedItems(i).Price, 0)
            Next
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            'THIS for PAYMENT '
            ' ✅ Check if user is verified
            If Globals.userIsVerified = False Then
                If Globals.paymentIsOpened = False Then
                    Globals.paymentIsOpened = True
                    MessageBox.Show("Please verify your account before proceeding to payment.",
                                    "Account Verification Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Dim paymentVerificationForm As New backgroundCheck()
                    AddHandler paymentVerificationForm.FormClosed, Sub() Globals.paymentIsOpened = False
                    paymentVerificationForm.Show()
                End If
                Return
            End If

            ' ✅ If verified, continue checkout
            Using con As New MySqlConnection("server=localhost;user=root;password=;database=information_management")
                con.Open()

                '==================BUY NOW FLOW (SINGLE ITEM)=================='
                If ProductQuantity >= 1 Then


                    ' Step 1: Deduct stock
                    Using updateCmd2 As New MySqlCommand("
                UPDATE products 
                SET stock = stock - @qty 
                WHERE product_name = @pname 
                AND stock >= @qty", con)

                        updateCmd2.Parameters.AddWithValue("@qty", ProductQuantity)
                        updateCmd2.Parameters.AddWithValue("@pname", ProductName2)

                        Dim affected As Integer = updateCmd2.ExecuteNonQuery()
                        If affected = 0 Then
                            MessageBox.Show($"Not enough stock for {ProductName2}.", "Stock Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    End Using

                    ' Step 2: Add order record
                    Using insertCmd2 As New MySqlCommand("
                INSERT INTO orders (user_id, product_name, quantity, price, order_date)
                VALUES (@uid, @pname, @qty, @price, NOW())", con)

                        insertCmd2.Parameters.AddWithValue("@uid", Globals.LoggedInUserId)
                        insertCmd2.Parameters.AddWithValue("@pname", ProductName2)
                        insertCmd2.Parameters.AddWithValue("@qty", ProductQuantity)
                        insertCmd2.Parameters.AddWithValue("@price", ProductPrice)
                        insertCmd2.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Purchase Pending! Thank you for your purchase!",
                                    "Purchase Pending", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'this part closes the PRODUCT DETAILS form if its open after checkout
                    Dim productForm As ProductDetails = Application.OpenForms().OfType(Of ProductDetails)().FirstOrDefault()
                    If productForm IsNot Nothing Then
                        productForm.Close()
                    End If

                    Me.Close()

                Else
                    ' =================THIS IS FOR CART CHECKOUT (MULTIPLE ITEMS)================ '   
                    For Each item In _selectedItems
                        ' Skip invalid quantities
                        If item.Quantity <= 0 Then Continue For

                        ' Step 1: Deduct stock
                        Using updateCmd As New MySqlCommand("
                UPDATE products 
                SET stock = stock - @qty 
                WHERE product_name = @pname 
                AND stock >= @qty", con)

                            updateCmd.Parameters.AddWithValue("@qty", item.Quantity)
                            updateCmd.Parameters.AddWithValue("@pname", item.ProductName)

                            Dim affected As Integer = updateCmd.ExecuteNonQuery()
                            If affected = 0 Then
                                MessageBox.Show($"Not enough stock for {item.ProductName}.", "Stock Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Continue For
                            End If
                        End Using

                        ' Step 2: Add order record
                        Using insertCmd As New MySqlCommand("
                INSERT INTO orders (user_id, product_name, quantity, price, order_date)
                VALUES (@uid, @pname, @qty, @price, NOW())", con)

                            insertCmd.Parameters.AddWithValue("@uid", Globals.LoggedInUserId)
                            insertCmd.Parameters.AddWithValue("@pname", item.ProductName)
                            insertCmd.Parameters.AddWithValue("@qty", item.Quantity)
                            insertCmd.Parameters.AddWithValue("@price", item.Price)
                            insertCmd.ExecuteNonQuery()
                        End Using

                        ' Step 3: Remove from cart
                        Using deleteCmd As New MySqlCommand("
                DELETE FROM cart 
                WHERE user_id = @uid 
                AND product_name = @pname", con)

                            deleteCmd.Parameters.AddWithValue("@uid", Globals.LoggedInUserId)
                            deleteCmd.Parameters.AddWithValue("@pname", item.ProductName)
                            deleteCmd.ExecuteNonQuery()
                        End Using
                    Next


                    MessageBox.Show("Purchase Pending! Thank you for your purchase!",
                                "Purchase Pending", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Close()

                End If

            End Using


        Catch ex As Exception
            MessageBox.Show("An error occurred during checkout: " & ex.Message,
                            "Checkout Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class