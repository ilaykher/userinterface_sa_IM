Imports MySql.Data.MySqlClient

Public Class ProductDetails

    Public Property ProductName As String

    Private Sub ProductDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ProductName

        DisplayDetailsOf(ProductName) ' this functions unlocks the details of the product from db
    End Sub

    'Variable dcleration for selected item'
    Dim selectedProductID As Integer
    Dim selectedProductName As String
    Dim selectedPrice As Decimal
    Dim selectedDescription As String
    Dim selectedStock As Integer

    '============== Show Product Detail Function ===================

    Public Sub DisplayDetailsOf(productName As String)
        Dim connectionString As String = "server=localhost;user=root;password=;database=information_management"

        Using con As New MySqlConnection(connectionString)
            con.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM Products WHERE product_name = @productName", con)
            cmd.Parameters.AddWithValue("@productName", productName)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then

                    ' === Basic Details ===
                    Label1.Text = reader("product_name").ToString()
                    Label2.Text = "₱" & Convert.ToDecimal(reader("price")).ToString("N2")
                    Label3.Text = reader("description").ToString()
                    Label4.Text = "Category: " & reader("category").ToString()
                    Label5.Text = "Stock: " & reader("stock").ToString()
                    Label6.Text = "Created Date: " & reader("created_date").ToString()

                    ' === Sold & Location (fixed) ===
                    Dim soldCount As Integer = 0
                    If Not IsDBNull(reader("sold_count")) Then
                        soldCount = Convert.ToInt32(reader("sold_count"))
                    End If
                    lblSold.Text = "Items Sold: " & soldCount.ToString()

                    Dim locationText As String = "N/A"
                    If Not IsDBNull(reader("location")) Then
                        locationText = reader("location").ToString()
                    End If
                    lblLocation.Text = "Location: " & locationText

                    ' === Assign Variables ===
                    selectedProductID = Convert.ToInt32(reader("product_id"))
                    selectedProductName = reader("product_name").ToString()
                    selectedPrice = Convert.ToDecimal(reader("price"))
                    selectedDescription = reader("description").ToString()
                    selectedStock = Convert.ToInt32(reader("stock"))

                    ' === Image ===
                    Dim imagePath As String = reader("image_path").ToString()
                    If Not String.IsNullOrEmpty(imagePath) AndAlso IO.File.Exists(imagePath) Then
                        PictureBox1.Image = Image.FromFile(imagePath)
                        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                    Else
                        PictureBox1.Image = Nothing
                    End If

                Else
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        End Using
    End Sub



    '=================Add to cart button========================
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addTocart(LoggedInUserId, selectedProductID, selectedProductName, selectedPrice, selectedStock, selectedDescription)
    End Sub

    '=====================Add to cart function======================= 
    Public Sub addTocart(userID As Integer, productID As String, productName As String, price As Integer, stock As Integer, description As String)

        Const QTY_TO_ADD As Integer = 1

        If stock <= 0 Then
            MessageBox.Show("Out of stock!")
            Return
        End If

        Using conn As New MySqlConnection("server=localhost;user=root;password=;database=information_management")
            Try
                conn.Open()

                ' 1. Check if item exists in cart and check stock limit
                Dim checkQuery As String = "SELECT quantity FROM cart WHERE user_id = @uid AND product_id = @pid"
                Dim currentQty As Integer = 0
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@uid", LoggedInUserId)
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
                        updateCmd.Parameters.AddWithValue("@uid", LoggedInUserId)
                        updateCmd.Parameters.AddWithValue("@pid", productID)
                        updateCmd.ExecuteNonQuery()
                    End Using
                Else
                    ' 3. Item does not exist: Insert new row
                    Dim insertQuery As String = "INSERT INTO cart (user_id, product_id, product_name, price, description, quantity) VALUES (@uid, @pid, @pname, @price, @desc, @qty)"
                    Using insertCmd As New MySqlCommand(insertQuery, conn)
                        insertCmd.Parameters.AddWithValue("@uid", LoggedInUserId)
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    '-------------this is buy now button----------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If selectedStock <= 0 Then
            MessageBox.Show("Out of stock!")
            Return
        End If

        If Globals.userIsVerified = False Then
            MessageBox.Show("Your profile is not verified yet. Please complete your profile to proceed with payment.", "Profile Not Verified", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Dim verificationForm As New backgroundCheck()
            verificationForm.Show()


            Return
        End If

        If paymentIsOpened Then
            ' Bring existing payment form to front if already open
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is modeOfPayment Then
                    frm.BringToFront()
                    MessageBox.Show("Payment window is already open.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit For
                End If
            Next
            Return
        End If

        ' Create and pass product info
        Dim payment As New modeOfPayment()
        payment.ProductID = selectedProductID
        payment.ProductName2 = selectedProductName
        payment.ProductPrice = selectedPrice
        payment.ProductQuantity = 1 ' Default or let user choose later
        payment.ProductDescription = selectedDescription

        payment.Show()
        paymentIsOpened = True
    End Sub

End Class