Imports MySql.Data.MySqlClient

Public Class FrmUserCreation
    Private connStr As String = "Server=localhost;Database=information_management;Uid=root;Pwd=;"

    Private Sub FrmUserCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' datetime picker settings
        DateTimePicker1.MaxDate = Date.Today
        DateTimePicker1.MinDate = Date.Today.AddYears(-120)

        If cmbSecurityQuestion.Items.Count > 0 Then
            cmbSecurityQuestion.SelectedIndex = 0
        End If

        ' Hide passwords by default
        txtCreatePass.UseSystemPasswordChar = True
        TextBox1.UseSystemPasswordChar = True

        txtCreateUsername.Focus()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtCreateUsername.Clear()
        txtCreatePass.Clear()
        TextBox1.Clear()
        txtSecurityAnswer.Clear()
        cmbSecurityQuestion.SelectedIndex = 0
        txtCreateUsername.Focus()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        ' Confirm password match
        Dim confirmPassword As String = TextBox1.Text
        Dim password As String = txtCreatePass.Text

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match. Please re-enter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCreatePass.Clear()
            TextBox1.Clear()
            txtCreatePass.Focus()
            Return
        End If

        ' Security question validation
        If cmbSecurityQuestion.SelectedIndex <= 0 Then
            MessageBox.Show("Please select a valid security question.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSecurityQuestion.Focus()
            Return
        End If

        ' Birthday validation
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
            MessageBox.Show("Please enter a realistic birth date (age not older than 90).", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker1.Focus()
            Exit Sub
        End If

        ' Field validations
        If String.IsNullOrWhiteSpace(txtCreateUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtCreatePass.Text) OrElse
           String.IsNullOrWhiteSpace(txtSecurityAnswer.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtCreateUsername.Text.Trim().Length < 3 Then
            MessageBox.Show("Username should be at least 3 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCreateUsername.Focus()
            Return
        End If

        If txtCreatePass.Text.Length < 6 Then
            MessageBox.Show("Password should be at least 6 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCreatePass.Focus()
            Return
        End If

        If txtSecurityAnswer.Text.Trim().Length < 2 Then
            MessageBox.Show("Security answer should be at least 2 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSecurityAnswer.Focus()
            Return
        End If

        If txtCreateUsername.Text.Trim().Equals("admin", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("The username 'admin' cannot be used for registration.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCreateUsername.Focus()
            Return
        End If

        If UsernameExists(txtCreateUsername.Text.Trim()) Then
            MessageBox.Show("Username already exists. Please choose another.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCreateUsername.Focus()
            Return
        End If

        ' Insert new user
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim insertQuery As String = "INSERT INTO users (username, password, security_question, security_answer, balance) " &
                                            "VALUES (@username, @password, @question, @answer, @balance)"

                Using insertCmd As New MySqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@username", txtCreateUsername.Text.Trim())
                    insertCmd.Parameters.AddWithValue("@password", txtCreatePass.Text)
                    insertCmd.Parameters.AddWithValue("@question", cmbSecurityQuestion.SelectedItem.ToString())
                    insertCmd.Parameters.AddWithValue("@answer", txtSecurityAnswer.Text.Trim())
                    insertCmd.Parameters.AddWithValue("@balance", 0.0D)
                    insertCmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Dim loginForm As New FrmLogin()
                loginForm.Show()

            Catch ex As Exception
                MessageBox.Show("Error creating account: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Check if username already exists
    Private Function UsernameExists(username As String) As Boolean
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @user"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user", username)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using

            Catch ex As Exception
                MessageBox.Show("Error checking username: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End Try
        End Using
    End Function

    ' Show/Hide Password Checkbox
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim showPassword As Boolean = CheckBox1.Checked
        txtCreatePass.UseSystemPasswordChar = Not showPassword
        TextBox1.UseSystemPasswordChar = Not showPassword
    End Sub

    ' Other Events
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim BackToLogin As New FrmLogin()
        BackToLogin.Show()
        Me.Hide()
    End Sub
End Class
