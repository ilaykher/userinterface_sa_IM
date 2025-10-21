Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Public Class Profile

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'upon form load
        databaseInitialize()
        Panel1.Hide() ' so edit mode doesnt show up first

        'datetime picker settings
        ' Prevent selecting future dates
        DateTimePicker1.MaxDate = Date.Today

        ' Optionally prevent selecting very old dates
        DateTimePicker1.MinDate = Date.Today.AddYears(-90)

        Panel1.Location = New Point(12, 13)
    End Sub

    Public Sub databaseInitialize()
        Dim constring As String = "server=localhost;user=root;password=;database=information_management"
        Using con As New MySqlConnection(constring)
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM users WHERE user_id = @userId", con)
            cmd.Parameters.AddWithValue("@userId", Globals.LoggedInUserId)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Label6.Text = reader("username").ToString() ' this is in profile user
                    'add stuff here depends on column name in database'
                    Label13.Text = "Usetrname: " & reader("username").ToString() 'this is in edit profile panel
                Else
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using

        ' Load a small preview of the user's most recent orders
        LoadUserHistoryPreview()

        ' Load user's address into Label5
        LoadUserAddress()
    End Sub

    Private Sub LoadUserAddress()
        Try
            Dim constring As String = "server=localhost;user=root;password=;database=information_management"
            Using con As New MySqlConnection(constring)
                con.Open()

                ' Get latest address for this user (adjust ORDER/BY if you have a default flag)
                Dim sql As String = "SELECT province, barangay, zipCode, addressLine FROM address WHERE user_id = @uid ORDER BY address_id DESC LIMIT 1"
                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@uid", Globals.LoggedInUserId)
                    Using rdr As MySqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            Dim province As String = If(rdr.IsDBNull(rdr.GetOrdinal("province")), String.Empty, rdr("province").ToString().Trim())
                            Dim barangay As String = If(rdr.IsDBNull(rdr.GetOrdinal("barangay")), String.Empty, rdr("barangay").ToString().Trim())
                            Dim zipCode As String = If(rdr.IsDBNull(rdr.GetOrdinal("zipCode")), String.Empty, rdr("zipCode").ToString().Trim())
                            Dim addressLine As String = If(rdr.IsDBNull(rdr.GetOrdinal("addressLine")), String.Empty, rdr("addressLine").ToString().Trim())

                            ' Compose readable address, skip empty parts
                            Dim parts As New List(Of String)
                            If Not String.IsNullOrWhiteSpace(addressLine) Then parts.Add(addressLine)
                            If Not String.IsNullOrWhiteSpace(barangay) Then parts.Add(barangay)
                            If Not String.IsNullOrWhiteSpace(province) Then parts.Add(province)
                            Dim composed As String = String.Join(", ", parts)
                            If Not String.IsNullOrWhiteSpace(zipCode) Then composed &= " " & zipCode

                            If String.IsNullOrWhiteSpace(composed) Then
                                Label5.Text = "Address: No address provided."
                            Else
                                Label5.Text = "Address: " & composed
                            End If
                        Else
                            Label5.Text = "No address provided."
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' don't throw UI errors — show a friendly fallback and log if needed
            Label5.Text = "Unable to load address."
            ' Optionally log ex.Message somewhere for debugging
        End Try
    End Sub

    Private Sub LoadUserHistoryPreview()
        ' Populates DataGridView1 with last 5 orders for the logged in user
        Try
            Dim constring As String = "server=localhost;user=root;password=;database=information_management"
            Using con As New MySqlConnection(constring)
                con.Open()

                ' determine if status column exists in orders table
                Dim hasStatus As Boolean = False
                Using statusCmd As New MySqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA=@schema AND TABLE_NAME='orders' AND COLUMN_NAME='status'", con)
                    statusCmd.Parameters.AddWithValue("@schema", "information_management")
                    hasStatus = Convert.ToInt32(statusCmd.ExecuteScalar()) > 0
                End Using

                Dim sql As String
                If hasStatus Then
                    sql = "SELECT product_name AS `Product`, price AS `Price`, quantity AS `Qty`, order_date AS `Date`, status AS `Status` " &
                          "FROM orders WHERE user_id = @uid ORDER BY order_date DESC LIMIT 5"
                Else
                    sql = "SELECT product_name AS `Product`, price AS `Price`, quantity AS `Qty`, order_date AS `Date`, '' AS `Status` " &
                          "FROM orders WHERE user_id = @uid ORDER BY order_date DESC LIMIT 5"
                End If

                Using da As New MySqlDataAdapter(sql, con)
                    da.SelectCommand.Parameters.AddWithValue("@uid", Globals.LoggedInUserId)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ' bind and format
                    DataGridView1.DataSource = dt
                    If DataGridView1.Columns.Contains("Price") Then
                        DataGridView1.Columns("Price").DefaultCellStyle.Format = "C2"
                        DataGridView1.Columns("Price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    End If
                    If DataGridView1.Columns.Contains("Date") Then
                        DataGridView1.Columns("Date").DefaultCellStyle.Format = "g"
                        DataGridView1.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End If

                    DataGridView1.ReadOnly = True
                    DataGridView1.AllowUserToAddRows = False
                    DataGridView1.RowHeadersVisible = False
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                    ' show friendly message if empty
                    If dt.Rows.Count = 0 Then
                        DataGridView1.Columns.Clear()
                        DataGridView1.Columns.Add("Info", "History")
                        DataGridView1.Rows.Add("No previous purchases found.")
                        DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        DataGridView1.ReadOnly = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load order history preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'edit profile button
        Panel1.Show()
        Panel1.Location = New Point(12, 13)
        Button7.Hide() 'hide expand history button
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            'reset :}
            Globals.LoggedInUserId = 0
            Globals.paymentIsOpened = False

            'close all forms
            For Each f As Form In Application.OpenForms.OfType(Of Form)().ToList()
                If f.Name <> "FrmLogin" Then
                    f.Close()
                End If
            Next

            ' Show login form again
            Dim loginForm As New FrmLogin()
            loginForm.Show()

            ' Close the current form
            Me.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'cancel edit profile   this should also reset the textboxes to original values
        Panel1.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'save changes button from edit profile panel (panel1)
        ' (validation code omitted for brevity — unchanged)
        Dim selectedDate As Date = DateTimePicker1.Value
        Dim today As Date = Date.Today

        If selectedDate > today Then
            MessageBox.Show("Birthday cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker1.Focus()
            Exit Sub
        End If

        Dim age As Integer = today.Year - selectedDate.Year
        If (selectedDate > today.AddYears(-age)) Then age -= 1

        If age < 13 Then
            MessageBox.Show("You must be at least 13 years old.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker1.Focus()
            Exit Sub
        End If

        If age > 90 Then
            MessageBox.Show("Please enter a realistic birth date (age not older than 90 year old).", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker1.Focus()
            Exit Sub
        End If

        MessageBox.Show("Birthday accepted!", "Valid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'edit profile reset password button
        Globals.changePassFromUserEdit = True
        Dim reset As New FrmForgotPass()
        FrmForgotPass.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim history As New transactionHistory()
        history.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class