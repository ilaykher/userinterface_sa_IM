Imports MySql.Data.MySqlClient

Public Class FrmForgotPass
    Private dbAnswer As String = Nothing


    'DB
    Private connStr As String = "Server=localhost;Database=information_management;Uid=root;Pwd=;"

    ' Store the username being recovered
    Private currentUsername As String = ""

    ' Find Username
    Private Sub BtnFindUsernameDB_Click(sender As Object, e As EventArgs) Handles BtnFindUsernameDB.Click
        Dim inputUsername As String = TxtForgotUsername.Text.Trim()

        If String.IsNullOrWhiteSpace(inputUsername) Then
            lblAccountFound.ForeColor = Color.Red
            lblAccountFound.Text = "Username field cannot be left blank. Please enter your username."
            TxtForgotUsername.Focus()
            Return
        End If

        If inputUsername.Length < 3 Then
            lblAccountFound.ForeColor = Color.Red
            lblAccountFound.Text = "Username should be at least 3 characters."
            TxtForgotUsername.Focus()
            Return
        End If

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                Dim query As String = "SELECT security_question FROM users WHERE username = @username"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", TxtForgotUsername.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' Username found
                    currentUsername = TxtForgotUsername.Text
                    lblAccountFound.ForeColor = Color.Green
                    lblAccountFound.Text = "Account found: " & currentUsername
                    lblAccountFound.Visible = True

                    lblSecurityQuestion.Text = reader("security_question").ToString()
                    lblSecurityQuestion.Visible = True
                    lblSec.Visible = True
                    TxtSecurityAns.Visible = True
                    BtnConfirmation.Visible = True
                    lblAnswerSec.Visible = True
                Else
                    lblAccountFound.ForeColor = Color.Red
                    lblAccountFound.Text = "No account found. Double-check the username or create a new account.."
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


    'Confirm Security Answer
    Public Sub BtnConfirmation_Click(sender As Object, e As EventArgs) Handles BtnConfirmation.Click
        Dim inputAnswer = TxtSecurityAns.Text.Trim

        If String.IsNullOrWhiteSpace(inputAnswer) Then
            MessageBox.Show("Enter your security answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtSecurityAns.Focus()
            Return
        End If

        If currentUsername = "" Then
            MessageBox.Show("Find your account first.", "Process Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtForgotUsername.Focus()
            Return
        End If

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                Dim query = "SELECT security_answer FROM users WHERE username = @username"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", currentUsername)

                dbAnswer = cmd.ExecuteScalar()?.ToString()


                If dbAnswer IsNot Nothing AndAlso TxtSecurityAns.Text.Trim.ToLower = dbAnswer.Trim.ToLower Then
                    MessageBox.Show("Answer correct. Please set a new password.")

                    lblNewPass.Visible = True
                    TxtNewPass.Visible = True
                    BtnUpdatePass.Visible = True
                    Label2.Visible = True
                    TextBox1.Visible = True
                    Label3.Visible = True
                    CheckBox1.Visible = True

                Else
                    MessageBox.Show("Incorrect security answer. Try again.")
                    TxtSecurityAns.Clear()
                    TxtSecurityAns.Focus()
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Step 3: Update Password
    Private Sub BtnUpdatePass_Click(sender As Object, e As EventArgs) Handles BtnUpdatePass.Click
        Dim newPassword As String = TxtNewPass.Text
        Dim confirmPassword As String = TextBox1.Text

        ' Check for empty new password
        If String.IsNullOrEmpty(newPassword) Then
            MessageBox.Show("Enter a new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNewPass.Focus()
            Return
        End If

        ' Check password length
        If newPassword.Length < 6 Then
            MessageBox.Show("New password should be at least 6 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNewPass.Focus()
            Return
        End If

        ' ✅ Check if new password and confirm password match
        If newPassword <> confirmPassword Then
            MessageBox.Show("New password and confirm password do not match.", "Mismatch Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
            Return
        End If

        ' Get old password from DB
        Dim oldPassword As String = ""
        Using connCheck As New MySqlConnection(connStr)
            Try
                connCheck.Open()
                Dim checkQuery As String = "SELECT password FROM users WHERE username = @username"
                Using checkCmd As New MySqlCommand(checkQuery, connCheck)
                    checkCmd.Parameters.AddWithValue("@username", currentUsername)
                    oldPassword = checkCmd.ExecuteScalar()?.ToString()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking existing password: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End Using

        ' ✅ Check if new password is same as old
        If newPassword = oldPassword Then
            MessageBox.Show("The new password cannot be the same as your old password. Please choose a different one.", "Security Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            TxtNewPass.Clear()
            TextBox1.Clear()
            TxtNewPass.Focus()
            Return
        End If

        ' ✅ Everything is valid, proceed to update
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                Dim query As String = "UPDATE users SET password = @newpass WHERE username = @username"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@newpass", newPassword)
                cmd.Parameters.AddWithValue("@username", currentUsername)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Password updated successfully!")

                    If Globals.changePassFromUserEdit Then 'If true which is edited from profile edit then'
                        BtnBack.Visible = False
                        Me.Close()
                    Else ' but if false which is from forgot password form then'
                        Dim BackToLogin As New FrmLogin()
                        BackToLogin.Show()
                        Me.Hide()
                    End If

                Else
                    MessageBox.Show("Error: Password not updated.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


    ' Back button
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim BackToLogin As New FrmLogin()
        BackToLogin.Show()
        Me.Hide()
        If dbAnswer IsNot Nothing AndAlso TxtSecurityAns.Text.Trim.ToLower = dbAnswer.Trim.ToLower Then
            MessageBox.Show("Answer correct. Please set a new password.")

            ' Show New Password and Confirm Password fields
            lblNewPass.Visible = True
            TxtNewPass.Visible = True
            TextBox1.Visible = True ' Confirm Password textbox

            ' Show Show Password checkbox and label
            CheckBox1.Visible = True
            Label2.Visible = True

            ' Show Update button
            BtnUpdatePass.Visible = True
        Else
            MessageBox.Show("Incorrect security answer. Try again.")
            TxtSecurityAns.Clear()
            TxtSecurityAns.Focus()
        End If




    End Sub

    Private Sub FrmForgotPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Globals.changePassFromUserEdit Then 'If true which is edited from profile edit then'
            BtnBack.Visible = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        TxtNewPass.Visible = False
        TextBox1.Visible = False
        CheckBox1.Visible = False
        Label2.Visible = False
        BtnUpdatePass.Visible = False
        Label3.Visible = False

        TxtNewPass.UseSystemPasswordChar = True
        TextBox1.UseSystemPasswordChar = True
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim isChecked As Boolean = CheckBox1.Checked
        TxtNewPass.UseSystemPasswordChar = Not isChecked
        TextBox1.UseSystemPasswordChar = Not isChecked
    End Sub


End Class
