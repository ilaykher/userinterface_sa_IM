Imports MySql.Data.MySqlClient

Public Class Admin

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub

    ' --- Show / Hide Password ---
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    ' --- Clear Button ---
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub

    ' --- Forgot Password Link ---
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Please contact the system administrator to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' --- Login Button ---
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        ' Validate empty input
        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both Username and Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' --- HARDCODED LOGIN CREDENTIALS ---
        If username = "admin1" And password = "123456" Then
            MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open the main interface form
            Dim mainForm As New FrmInterface()
            mainForm.Show()

            ' Hide the login form
            Me.Hide()

        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
