Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Public Class orders

    Private Sub orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllOrders()
    End Sub

    ' Loads all orders and renders a card per order similar to your screenshot.
    Public Sub LoadAllOrders()
        FlowLayoutPanel1.Controls.Clear()

        Dim connString As String = "server=localhost;user=root;password=;database=information_management"
        Dim sql As String =
        "SELECT o.order_id, o.user_id, IFNULL(u.username, '') AS username, " &
        "o.product_name, o.quantity, o.price, o.order_date, IFNULL(o.status, 'Pending') AS status, " &
        "p.image_path, IFNULL(p.category,'') AS category " &
        "FROM orders o " &
        "LEFT JOIN users u ON o.user_id = u.user_id " &
        "LEFT JOIN products p ON o.product_name = p.product_name " &
        "ORDER BY o.order_date DESC"

        Try
            Using con As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(sql, con)
                    con.Open()
                    Using rdr As MySqlDataReader = cmd.ExecuteReader()
                        While rdr.Read()
                            ' Read data
                            Dim orderId As Integer = Convert.ToInt32(rdr("order_id"))
                            Dim username As String = rdr("username").ToString()
                            Dim productName As String = rdr("product_name").ToString()
                            Dim qty As Integer = Convert.ToInt32(rdr("quantity"))
                            Dim price As Decimal = Convert.ToDecimal(rdr("price"))
                            Dim status As String = rdr("status").ToString()
                            Dim category As String = rdr("category").ToString()
                            Dim imagePath As String = rdr("image_path").ToString()

                            ' ✅ Clone your template panel
                            Dim card As Panel = ClonePanel(Panel2)

                            ' Fill in the data
                            Dim pic As PictureBox = card.Controls("PictureBox2")
                            Dim txtItemName As TextBox = card.Controls("txtItemName2")
                            Dim txtOrderedBy As TextBox = card.Controls("txtOrderedBy2")
                            Dim txtQty As TextBox = card.Controls("txtQty2")
                            Dim txtCategory As TextBox = card.Controls("txtCategory2")
                            Dim txtPrice As TextBox = card.Controls("txtPrice2")
                            Dim btnOrderDetails As Button = card.Controls("btnOrderDetails2")

                            ' Populate fields
                            txtItemName.Text = productName
                            txtOrderedBy.Text = username
                            txtQty.Text = qty.ToString()
                            txtCategory.Text = category
                            txtPrice.Text = "₱" & price.ToString("N2")

                            If Not String.IsNullOrEmpty(imagePath) AndAlso File.Exists(imagePath) Then
                                pic.Image = Image.FromFile(imagePath)
                            End If

                            ' Handle button click
                            AddHandler btnOrderDetails.Click, Sub()
                                                                  ShowOrderDetails(orderId)
                                                              End Sub

                            ' Show the cloned card
                            card.Visible = True
                            FlowLayoutPanel1.Controls.Add(card)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load orders: " & ex.Message)
        End Try
    End Sub


    ' Show order details - adjust to open your detailed view form or dialog
    Private Sub ShowOrderDetails(orderId As Integer)
        ' You can implement a form that shows detailed order data. For now show a simple dialog.
        Try
            Dim connString As String = "server=localhost;user=root;password=;database=information_management"
            Using con As New MySqlConnection(connString)
                con.Open()
                Using cmd As New MySqlCommand("SELECT order_id, user_id, product_name, quantity, price, order_date, status FROM orders WHERE order_id = @id", con)
                    cmd.Parameters.AddWithValue("@id", orderId)
                    Using rdr = cmd.ExecuteReader()
                        If rdr.Read() Then
                            Dim sb As New System.Text.StringBuilder()
                            sb.AppendLine("Order ID: " & rdr("order_id").ToString())
                            sb.AppendLine("Product: " & rdr("product_name").ToString())
                            sb.AppendLine("Quantity: " & rdr("quantity").ToString())
                            sb.AppendLine("Price: ₱" & Convert.ToDecimal(rdr("price")).ToString("N2"))
                            sb.AppendLine("Date: " & Convert.ToDateTime(rdr("order_date")).ToString("g"))
                            sb.AppendLine("Status: " & If(rdr.IsDBNull(rdr.GetOrdinal("status")), "Pending", rdr("status").ToString()))
                            MessageBox.Show(sb.ToString(), "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Order not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load order details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Update order status and refresh list
    Private Sub UpdateOrderStatus(orderId As Integer, newStatus As String)
        Try
            Dim connString As String = "server=localhost;user=root;password=;database=information_management"
            Using con As New MySqlConnection(connString)
                Using cmd As New MySqlCommand("UPDATE orders SET status = @status WHERE order_id = @id", con)
                    cmd.Parameters.AddWithValue("@status", newStatus)
                    cmd.Parameters.AddWithValue("@id", orderId)
                    con.Open()
                    Dim affected = cmd.ExecuteNonQuery()
                    If affected > 0 Then LoadAllOrders() Else MessageBox.Show("Order not found or could not be updated.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to update order status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ClonePanel(original As Panel) As Panel
        Dim newPanel As New Panel With {
        .Size = original.Size,
        .BackColor = original.BackColor,
        .BorderStyle = original.BorderStyle,
        .Margin = original.Margin
    }

        For Each ctrl As Control In original.Controls
            Dim copy As Control = Nothing

            If TypeOf ctrl Is Label Then
                copy = New Label()
            ElseIf TypeOf ctrl Is TextBox Then
                copy = New TextBox()
            ElseIf TypeOf ctrl Is PictureBox Then
                copy = New PictureBox()
            ElseIf TypeOf ctrl Is Button Then
                copy = New Button()
            Else
                Continue For
            End If

            copy.Name = ctrl.Name
            copy.Size = ctrl.Size
            copy.Location = ctrl.Location
            copy.Font = ctrl.Font
            copy.Text = ctrl.Text
            copy.BackColor = ctrl.BackColor
            copy.ForeColor = ctrl.ForeColor

            If TypeOf copy Is PictureBox Then
                CType(copy, PictureBox).SizeMode = PictureBoxSizeMode.Zoom
            End If

            newPanel.Controls.Add(copy)
        Next

        Return newPanel
    End Function




    ' Refresh button (wire this button in designer to Button1)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOrderDetails2.Click
        LoadAllOrders()
    End Sub

    ' Designer no-op handlers retained
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblOrderedBy1.Click
    End Sub
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtOrderedBy2.TextChanged
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtQty2.TextChanged
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtItemName2.TextChanged
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtCategory2.TextChanged
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtPrice2.TextChanged
    End Sub
End Class
