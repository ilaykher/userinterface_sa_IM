Imports MySql.Data.MySqlClient

Public Class backgroundCheck
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'validation for empty fields
        For i = 1 To 10
            ' Skip validation for TextBox4 (as before)
            If i = 4 Then Continue For

            Dim tb = TryCast(Controls("TextBox" & i), TextBox)
            If tb Is Nothing Then Continue For

            If String.IsNullOrWhiteSpace(tb.Text) Then
                MessageBox.Show("Please fill out all required fields before continuing.",
                        "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Focus()
                Return
            End If
        Next

        'validation for email 
        Dim email = TextBox5.Text.Trim().ToLower()

        If Not (email.EndsWith("@gmail.com") OrElse email.EndsWith("@yahoo.com")) Then
            MessageBox.Show("Please enter a valid email address ending with @gmail.com or @yahoo.com.",
                    "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox5.Focus()
            Return
        End If

        'validation for contact number
        Dim contact = TextBox6.Text.Trim()

        If Not System.Text.RegularExpressions.Regex.IsMatch(contact, "^09\d{9}$") Then
            MessageBox.Show("Please enter a valid contact number (e.g., 09123456789).",
                    "Invalid Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox6.Focus()
            Return
        End If

        'validation for zip code (TextBox9)
        Dim zipCode = TextBox9.Text.Trim()

        If Not System.Text.RegularExpressions.Regex.IsMatch(zipCode, "^\d{4}$") Then
            MessageBox.Show("Please enter a valid 4-digit ZIP code (e.g., 1001).",
                    "Invalid ZIP Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox9.Focus()
            Return
        End If

        ' Basic address validation: ensure province, barangay, addressLine have values
        ' (assume TextBox7 = province, TextBox8 = barangay, TextBox10 = addressLine)
        Dim province = If(TextBox7?.Text, "").Trim()
        Dim barangay = If(TextBox8?.Text, "").Trim()
        Dim addressLine = If(TextBox10?.Text, "").Trim()

        If String.IsNullOrWhiteSpace(province) Then
            MessageBox.Show("Please enter your province.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox7.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(barangay) Then
            MessageBox.Show("Please enter your barangay.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox8.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(addressLine) Then
            MessageBox.Show("Please enter your address line (street / block / lot).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox10.Focus()
            Return
        End If

        ' Ask user to confirm saving the address
        Dim confirm = MessageBox.Show("Save address and submit verification form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then
            Return
        End If

        ' If all validations pass, insert address and update the users table
        Dim connstring = "server=localhost;user=root;password=;database=information_management"

        Try
            Using con As New MySqlConnection(connstring)
                con.Open()

                ' Insert address tied to current user
                Using insertAddr As New MySqlCommand("
                    INSERT INTO address (user_id, province, barangay, zipCode, addressLine)
                    VALUES (@uid, @province, @barangay, @zipCode, @addressLine)", con)

                    insertAddr.Parameters.AddWithValue("@uid", Globals.LoggedInUserId)
                    insertAddr.Parameters.AddWithValue("@province", province)
                    insertAddr.Parameters.AddWithValue("@barangay", barangay)
                    insertAddr.Parameters.AddWithValue("@zipCode", zipCode)
                    insertAddr.Parameters.AddWithValue("@addressLine", addressLine)
                    insertAddr.ExecuteNonQuery()
                End Using

                ' Mark the user as having filled out the form
                Using cmd As New MySqlCommand("UPDATE users SET formFilledUp = @didHeFillUpTheForm WHERE user_id = @userId", con)
                    cmd.Parameters.AddWithValue("@didHeFillUpTheForm", True)
                    cmd.Parameters.AddWithValue("@userId", Globals.LoggedInUserId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Form submitted and address saved! You can now make purchases.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Globals.userIsVerified = True
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    ' Clear button: reset inputs and focus top textbox (TextBox1)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 1 To 10
            Dim tb = TryCast(Controls("TextBox" & i), TextBox)
            If tb IsNot Nothing Then tb.Clear()
        Next

        ' reset any other controls if necessary (example: ComboBoxes)
        If Controls.ContainsKey("ComboBox1") Then
            Dim cb = TryCast(Controls("ComboBox1"), ComboBox)
            If cb IsNot Nothing Then cb.SelectedIndex = 0
        End If

        ' Focus back to the first input
        Dim first = TryCast(Controls("TextBox1"), TextBox)
        If first IsNot Nothing Then first.Focus()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class