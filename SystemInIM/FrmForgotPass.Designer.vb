<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmForgotPass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblForgotUsername = New Label()
        TxtForgotUsername = New TextBox()
        BtnFindUsernameDB = New Button()
        lblSec = New Label()
        lblAccountFound = New Label()
        TxtSecurityAns = New TextBox()
        lblSecurityQuestion = New Label()
        lblNewPass = New Label()
        TxtNewPass = New TextBox()
        BtnConfirmation = New Button()
        BtnUpdatePass = New Button()
        BtnBack = New Button()
        Label1 = New Label()
        lblAnswerSec = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        CheckBox1 = New CheckBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' lblForgotUsername
        ' 
        lblForgotUsername.AutoSize = True
        lblForgotUsername.Font = New Font("Consolas", 14.25F)
        lblForgotUsername.Location = New Point(142, 215)
        lblForgotUsername.Margin = New Padding(2, 0, 2, 0)
        lblForgotUsername.Name = "lblForgotUsername"
        lblForgotUsername.Size = New Size(142, 28)
        lblForgotUsername.TabIndex = 0
        lblForgotUsername.Text = "Username: "
        ' 
        ' TxtForgotUsername
        ' 
        TxtForgotUsername.BackColor = Color.LightGray
        TxtForgotUsername.Font = New Font("Consolas", 14.25F)
        TxtForgotUsername.Location = New Point(272, 211)
        TxtForgotUsername.Margin = New Padding(2, 3, 2, 3)
        TxtForgotUsername.Name = "TxtForgotUsername"
        TxtForgotUsername.PlaceholderText = "(e.g. user)"
        TxtForgotUsername.Size = New Size(298, 35)
        TxtForgotUsername.TabIndex = 1
        ' 
        ' BtnFindUsernameDB
        ' 
        BtnFindUsernameDB.BackColor = Color.SlateGray
        BtnFindUsernameDB.FlatStyle = FlatStyle.Flat
        BtnFindUsernameDB.Font = New Font("Consolas", 14.25F)
        BtnFindUsernameDB.ForeColor = SystemColors.ControlLightLight
        BtnFindUsernameDB.Location = New Point(583, 209)
        BtnFindUsernameDB.Margin = New Padding(2, 3, 2, 3)
        BtnFindUsernameDB.Name = "BtnFindUsernameDB"
        BtnFindUsernameDB.Size = New Size(120, 40)
        BtnFindUsernameDB.TabIndex = 2
        BtnFindUsernameDB.Text = "Find Account"
        BtnFindUsernameDB.UseVisualStyleBackColor = False
        ' 
        ' lblSec
        ' 
        lblSec.AccessibleRole = AccessibleRole.None
        lblSec.AutoSize = True
        lblSec.Font = New Font("Consolas", 14.25F)
        lblSec.ForeColor = Color.DarkRed
        lblSec.Location = New Point(39, 276)
        lblSec.Margin = New Padding(2, 0, 2, 0)
        lblSec.Name = "lblSec"
        lblSec.Size = New Size(246, 28)
        lblSec.TabIndex = 3
        lblSec.Text = "Security Question:"
        lblSec.Visible = False
        ' 
        ' lblAccountFound
        ' 
        lblAccountFound.AutoSize = True
        lblAccountFound.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAccountFound.Location = New Point(151, 156)
        lblAccountFound.Margin = New Padding(2, 0, 2, 0)
        lblAccountFound.Name = "lblAccountFound"
        lblAccountFound.Size = New Size(20, 22)
        lblAccountFound.TabIndex = 4
        lblAccountFound.Text = "-"
        ' 
        ' TxtSecurityAns
        ' 
        TxtSecurityAns.Font = New Font("Consolas", 14.25F)
        TxtSecurityAns.Location = New Point(305, 350)
        TxtSecurityAns.Margin = New Padding(2, 3, 2, 3)
        TxtSecurityAns.Name = "TxtSecurityAns"
        TxtSecurityAns.PlaceholderText = "(Input your answer here)"
        TxtSecurityAns.Size = New Size(295, 35)
        TxtSecurityAns.TabIndex = 5
        TxtSecurityAns.Visible = False
        ' 
        ' lblSecurityQuestion
        ' 
        lblSecurityQuestion.AccessibleRole = AccessibleRole.None
        lblSecurityQuestion.AutoSize = True
        lblSecurityQuestion.Font = New Font("Consolas", 14.25F)
        lblSecurityQuestion.ForeColor = Color.DarkRed
        lblSecurityQuestion.Location = New Point(272, 276)
        lblSecurityQuestion.Margin = New Padding(2, 0, 2, 0)
        lblSecurityQuestion.Name = "lblSecurityQuestion"
        lblSecurityQuestion.Size = New Size(363, 28)
        lblSecurityQuestion.TabIndex = 6
        lblSecurityQuestion.Text = "Shows the Security Question"
        lblSecurityQuestion.Visible = False
        ' 
        ' lblNewPass
        ' 
        lblNewPass.AutoSize = True
        lblNewPass.Font = New Font("Consolas", 14.25F)
        lblNewPass.Location = New Point(127, 401)
        lblNewPass.Margin = New Padding(2, 0, 2, 0)
        lblNewPass.Name = "lblNewPass"
        lblNewPass.Size = New Size(181, 28)
        lblNewPass.TabIndex = 7
        lblNewPass.Text = "New Password:"
        lblNewPass.Visible = False
        ' 
        ' TxtNewPass
        ' 
        TxtNewPass.Font = New Font("Consolas", 14.25F)
        TxtNewPass.Location = New Point(305, 398)
        TxtNewPass.Margin = New Padding(2, 3, 2, 3)
        TxtNewPass.Name = "TxtNewPass"
        TxtNewPass.PlaceholderText = "(Type in your new password)"
        TxtNewPass.Size = New Size(298, 35)
        TxtNewPass.TabIndex = 8
        TxtNewPass.UseSystemPasswordChar = True
        TxtNewPass.Visible = False
        ' 
        ' BtnConfirmation
        ' 
        BtnConfirmation.BackColor = Color.SlateGray
        BtnConfirmation.FlatStyle = FlatStyle.Flat
        BtnConfirmation.Font = New Font("Consolas", 14.25F)
        BtnConfirmation.ForeColor = SystemColors.ControlLightLight
        BtnConfirmation.Location = New Point(622, 344)
        BtnConfirmation.Margin = New Padding(2, 3, 2, 3)
        BtnConfirmation.Name = "BtnConfirmation"
        BtnConfirmation.Size = New Size(120, 41)
        BtnConfirmation.TabIndex = 9
        BtnConfirmation.Text = "Confirm"
        BtnConfirmation.UseVisualStyleBackColor = False
        BtnConfirmation.Visible = False
        ' 
        ' BtnUpdatePass
        ' 
        BtnUpdatePass.BackColor = Color.SlateGray
        BtnUpdatePass.FlatStyle = FlatStyle.Flat
        BtnUpdatePass.Font = New Font("Consolas", 14.25F)
        BtnUpdatePass.ForeColor = SystemColors.ControlLightLight
        BtnUpdatePass.Location = New Point(622, 446)
        BtnUpdatePass.Margin = New Padding(2, 3, 2, 3)
        BtnUpdatePass.Name = "BtnUpdatePass"
        BtnUpdatePass.Size = New Size(120, 41)
        BtnUpdatePass.TabIndex = 10
        BtnUpdatePass.Text = "Update Password"
        BtnUpdatePass.UseVisualStyleBackColor = False
        BtnUpdatePass.Visible = False
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.SlateGray
        BtnBack.FlatStyle = FlatStyle.Flat
        BtnBack.Font = New Font("Consolas", 14.25F)
        BtnBack.ForeColor = SystemColors.ControlLightLight
        BtnBack.Location = New Point(622, 27)
        BtnBack.Margin = New Padding(2, 3, 2, 3)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(179, 40)
        BtnBack.TabIndex = 11
        BtnBack.Text = "Back to Login"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(350, 56)
        Label1.TabIndex = 12
        Label1.Text = "Fill-up the corresponding " & vbCrLf & "information"
        ' 
        ' lblAnswerSec
        ' 
        lblAnswerSec.AutoSize = True
        lblAnswerSec.Font = New Font("Consolas", 14.25F)
        lblAnswerSec.Location = New Point(205, 353)
        lblAnswerSec.Margin = New Padding(2, 0, 2, 0)
        lblAnswerSec.Name = "lblAnswerSec"
        lblAnswerSec.Size = New Size(103, 28)
        lblAnswerSec.TabIndex = 13
        lblAnswerSec.Text = "Answer:"
        lblAnswerSec.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Consolas", 14.25F)
        Label2.Location = New Point(23, 449)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(285, 28)
        Label2.TabIndex = 14
        Label2.Text = "Confirm New Password:"
        Label2.Visible = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Consolas", 14.25F)
        TextBox1.Location = New Point(302, 449)
        TextBox1.Margin = New Padding(2, 3, 2, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "(Confirm your new password)"
        TextBox1.Size = New Size(298, 35)
        TextBox1.TabIndex = 15
        TextBox1.UseSystemPasswordChar = True
        TextBox1.Visible = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(567, 493)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(18, 17)
        CheckBox1.TabIndex = 17
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(451, 490)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 20)
        Label3.TabIndex = 18
        Label3.Text = "Show Password"
        ' 
        ' FrmForgotPass
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(829, 544)
        Controls.Add(Label3)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(lblAnswerSec)
        Controls.Add(Label1)
        Controls.Add(BtnBack)
        Controls.Add(BtnUpdatePass)
        Controls.Add(BtnConfirmation)
        Controls.Add(TxtNewPass)
        Controls.Add(lblNewPass)
        Controls.Add(lblSecurityQuestion)
        Controls.Add(TxtSecurityAns)
        Controls.Add(lblAccountFound)
        Controls.Add(lblSec)
        Controls.Add(BtnFindUsernameDB)
        Controls.Add(TxtForgotUsername)
        Controls.Add(lblForgotUsername)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2, 3, 2, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmForgotPass"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Device Market System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblForgotUsername As Label
    Friend WithEvents TxtForgotUsername As TextBox
    Friend WithEvents BtnFindUsernameDB As Button
    Friend WithEvents lblSec As Label
    Friend WithEvents lblAccountFound As Label
    Friend WithEvents TxtSecurityAns As TextBox
    Friend WithEvents lblSecurityQuestion As Label
    Friend WithEvents lblNewPass As Label
    Friend WithEvents TxtNewPass As TextBox
    Friend WithEvents BtnConfirmation As Button
    Friend WithEvents BtnUpdatePass As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAnswerSec As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
End Class
