Imports MySql.Data.MySqlClient
Public Class backgroundCheck
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'validation for empty fields
        For i As Integer = 1 To 10
            ' Skip validation for TextBox4
            If i = 4 Then Continue For

            Dim tb As TextBox = CType(Me.Controls("TextBox" & i), TextBox)

            If String.IsNullOrWhiteSpace(tb.Text) Then
                MessageBox.Show("Please fill out all required fields before continuing.",
                        "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Focus()
                Return
            End If
        Next


        'validation for email 
        Dim email As String = TextBox5.Text.Trim().ToLower()

        If Not (email.EndsWith("@gmail.com") OrElse email.EndsWith("@yahoo.com")) Then
            MessageBox.Show("Please enter a valid email address ending with @gmail.com or @yahoo.com.",
                    "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox5.Focus()
            Return
        End If

        'validation for contact number
        Dim contact As String = TextBox6.Text.Trim()

        If Not System.Text.RegularExpressions.Regex.IsMatch(contact, "^09\d{9}$") Then
            MessageBox.Show("Please enter a valid contact number (e.g., 09123456789).",
                    "Invalid Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox6.Focus()
            Return
        End If

        'validation for zip code
        Dim zipCode As String = TextBox9.Text.Trim()

        If Not System.Text.RegularExpressions.Regex.IsMatch(zipCode, "^\d{4}$") Then
            MessageBox.Show("Please enter a valid 4-digit ZIP code (e.g., 1001).",
                    "Invalid ZIP Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox9.Focus()
            Return
        End If

        ' If all validations pass, update the database
        Dim connstring As String = "server=localhost;user=root;password=;database=information_management"

        Using con As New MySqlConnection(connstring)
            con.Open()
            Dim cmd As New MySqlCommand("UPDATE users SET formFilledUp = @didHeFillUpTheForm WHERE user_id = @userId", con)
            cmd.Parameters.AddWithValue("@didHeFillUpTheForm", True)
            cmd.Parameters.AddWithValue("@userId", Globals.LoggedInUserId)
            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Form submitted! You can now make purchases!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Globals.userIsVerified = True
        Me.Close()
    End Sub

    Private Sub backgroundCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub backgroundCheck_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Globals.paymentIsOpened = False
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub
End Class