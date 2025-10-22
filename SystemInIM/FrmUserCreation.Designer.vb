<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserCreation
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
        txtCreateUsername = New TextBox()
        txtCreatePass = New TextBox()
        txtSecurityAnswer = New TextBox()
        cmbSecurityQuestion = New ComboBox()
        lblUsername = New Label()
        lblPass = New Label()
        lblSecQues = New Label()
        lblAnswer = New Label()
        BtnClear = New Button()
        BtnRegister = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        LinkLabel1 = New LinkLabel()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        CheckBox1 = New CheckBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtCreateUsername
        ' 
        txtCreateUsername.BackColor = Color.LightGray
        txtCreateUsername.Font = New Font("Segoe UI", 10F)
        txtCreateUsername.Location = New Point(187, 79)
        txtCreateUsername.Margin = New Padding(2, 2, 2, 2)
        txtCreateUsername.Name = "txtCreateUsername"
        txtCreateUsername.PlaceholderText = "(e.g. user)"
        txtCreateUsername.Size = New Size(233, 25)
        txtCreateUsername.TabIndex = 0
        ' 
        ' txtCreatePass
        ' 
        txtCreatePass.BackColor = Color.LightGray
        txtCreatePass.Font = New Font("Segoe UI", 10F)
        txtCreatePass.Location = New Point(187, 146)
        txtCreatePass.Margin = New Padding(2, 2, 2, 2)
        txtCreatePass.Name = "txtCreatePass"
        txtCreatePass.PlaceholderText = "(Type in your password)"
        txtCreatePass.Size = New Size(233, 25)
        txtCreatePass.TabIndex = 1
        ' 
        ' txtSecurityAnswer
        ' 
        txtSecurityAnswer.BackColor = Color.LightGray
        txtSecurityAnswer.Font = New Font("Segoe UI", 10F)
        txtSecurityAnswer.Location = New Point(187, 266)
        txtSecurityAnswer.Margin = New Padding(2, 2, 2, 2)
        txtSecurityAnswer.Name = "txtSecurityAnswer"
        txtSecurityAnswer.PlaceholderText = "(Type in your answer)"
        txtSecurityAnswer.Size = New Size(204, 25)
        txtSecurityAnswer.TabIndex = 3
        ' 
        ' cmbSecurityQuestion
        ' 
        cmbSecurityQuestion.BackColor = Color.LightGray
        cmbSecurityQuestion.Font = New Font("Segoe UI", 10F)
        cmbSecurityQuestion.FormattingEnabled = True
        cmbSecurityQuestion.Items.AddRange(New Object() {"--Select--", "What is your favorite color?", "In what city you were born?", "What was the name of your first pet?", "What's your mother's maiden name?", "What is your birthdate?"})
        cmbSecurityQuestion.Location = New Point(187, 231)
        cmbSecurityQuestion.Margin = New Padding(2, 2, 2, 2)
        cmbSecurityQuestion.Name = "cmbSecurityQuestion"
        cmbSecurityQuestion.Size = New Size(233, 25)
        cmbSecurityQuestion.TabIndex = 4
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F)
        lblUsername.Location = New Point(92, 77)
        lblUsername.Margin = New Padding(2, 0, 2, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(84, 21)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Username:"
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Font = New Font("Segoe UI", 12F)
        lblPass.Location = New Point(97, 144)
        lblPass.Margin = New Padding(2, 0, 2, 0)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(79, 21)
        lblPass.TabIndex = 6
        lblPass.Text = "Password:"
        ' 
        ' lblSecQues
        ' 
        lblSecQues.AutoSize = True
        lblSecQues.Font = New Font("Segoe UI", 12F)
        lblSecQues.Location = New Point(22, 233)
        lblSecQues.Margin = New Padding(2, 0, 2, 0)
        lblSecQues.Name = "lblSecQues"
        lblSecQues.Size = New Size(147, 21)
        lblSecQues.TabIndex = 7
        lblSecQues.Text = "Security Questions: "
        ' 
        ' lblAnswer
        ' 
        lblAnswer.AutoSize = True
        lblAnswer.Font = New Font("Segoe UI", 12F)
        lblAnswer.Location = New Point(108, 265)
        lblAnswer.Margin = New Padding(2, 0, 2, 0)
        lblAnswer.Name = "lblAnswer"
        lblAnswer.Size = New Size(69, 21)
        lblAnswer.TabIndex = 8
        lblAnswer.Text = "Answer: "
        ' 
        ' BtnClear
        ' 
        BtnClear.Font = New Font("Segoe UI", 12F)
        BtnClear.Location = New Point(56, 370)
        BtnClear.Margin = New Padding(2, 2, 2, 2)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(141, 22)
        BtnClear.TabIndex = 10
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnRegister
        ' 
        BtnRegister.Font = New Font("Segoe UI", 12F)
        BtnRegister.Location = New Point(249, 370)
        BtnRegister.Margin = New Padding(2, 2, 2, 2)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(141, 22)
        BtnRegister.TabIndex = 11
        BtnRegister.Text = "Register"
        BtnRegister.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(65, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 45)
        Label1.TabIndex = 12
        Label1.Text = "Create Your Account"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(32, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 21)
        Label2.TabIndex = 13
        Label2.Text = "Confirm Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.LightGray
        TextBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(187, 177)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "(Confirm your password)"
        TextBox1.Size = New Size(233, 25)
        TextBox1.TabIndex = 14
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(187, 328)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(107, 21)
        LinkLabel1.TabIndex = 15
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Back to Log In"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(98, 112)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 21)
        Label4.TabIndex = 17
        Label4.Text = "Birthdate:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarMonthBackground = Color.LightGray
        DateTimePicker1.Location = New Point(187, 114)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(233, 23)
        DateTimePicker1.TabIndex = 18
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(395, 204)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(15, 14)
        CheckBox1.TabIndex = 19
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(293, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 15)
        Label3.TabIndex = 20
        Label3.Text = "Show Password"
        ' 
        ' FrmUserCreation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(470, 428)
        Controls.Add(Label3)
        Controls.Add(CheckBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(LinkLabel1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnRegister)
        Controls.Add(BtnClear)
        Controls.Add(lblAnswer)
        Controls.Add(lblSecQues)
        Controls.Add(lblPass)
        Controls.Add(lblUsername)
        Controls.Add(cmbSecurityQuestion)
        Controls.Add(txtSecurityAnswer)
        Controls.Add(txtCreatePass)
        Controls.Add(txtCreateUsername)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2, 2, 2, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmUserCreation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign Up"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCreateUsername As TextBox
    Friend WithEvents txtCreatePass As TextBox
    Friend WithEvents txtSecurityAnswer As TextBox
    Friend WithEvents cmbSecurityQuestion As ComboBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblSecQues As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
End Class
