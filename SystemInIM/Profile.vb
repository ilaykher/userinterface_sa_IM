Imports MySql.Data.MySqlClient
Imports System.IO

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

        'u can put database for datagrid view here for transaction history preview
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'cancel edit profile   this should also reset the textboxes to original values
        Panel1.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'save changes button from edit profile panel (panel1)

        '------------------ calendar birthday validation ------------------
        Dim selectedDate As Date = DateTimePicker1.Value
        Dim today As Date = Date.Today

        '  Future date check
        If selectedDate > today Then
            MessageBox.Show("Birthday cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker1.Focus()
            Exit Sub
        End If

        ' 2Age range check must be atleast 13 yo)
        Dim age As Integer = today.Year - selectedDate.Year
        If (selectedDate > today.AddYears(-age)) Then age -= 1

        If age < 13 Then
            MessageBox.Show("You must be at least 13 years old.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker1.Focus()
            Exit Sub
        End If

        ' 3️⃣ Optional upper limit not older than 90yo
        If age > 90 Then
            MessageBox.Show("Please enter a realistic birth date (age not older than 90 year old).", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimePicker1.Focus()
            Exit Sub
        End If

        ' Passed all checks
        Dim userBirthday As Date = selectedDate ' use these variable for birthday in database
        Dim userAge As Integer = age ' use these variable for age in database
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

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Do something here, or leave empty if unused
    End Sub

End Class