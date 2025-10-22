<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblUsername = New Label()
        lblPassword = New Label()
        BtnLogin = New Button()
        BtnClear = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        Panel1 = New Panel()
        CheckBox1 = New CheckBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.OldLace
        lblUsername.Font = New Font("Segoe UI", 12F)
        lblUsername.Location = New Point(25, 167)
        lblUsername.Margin = New Padding(2, 0, 2, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(108, 28)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username: "
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.OldLace
        lblPassword.Font = New Font("Segoe UI", 12F)
        lblPassword.Location = New Point(31, 245)
        lblPassword.Margin = New Padding(2, 0, 2, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(102, 28)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password: "
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Font = New Font("Segoe UI", 12F)
        BtnLogin.Location = New Point(285, 592)
        BtnLogin.Margin = New Padding(2, 3, 2, 3)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(184, 39)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Font = New Font("Segoe UI", 12F)
        BtnClear.Location = New Point(69, 592)
        BtnClear.Margin = New Padding(2, 3, 2, 3)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(184, 39)
        BtnClear.TabIndex = 3
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10F)
        txtUsername.Location = New Point(138, 164)
        txtUsername.Margin = New Padding(2, 3, 2, 3)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "(Type in your username)"
        txtUsername.Size = New Size(329, 30)
        txtUsername.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10F)
        txtPassword.Location = New Point(138, 245)
        txtPassword.Margin = New Padding(2, 3, 2, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "(Type in your password)"
        txtPassword.Size = New Size(329, 30)
        txtPassword.TabIndex = 7
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.OldLace
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(102, 44)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(329, 41)
        Label1.TabIndex = 8
        Label1.Text = "Device Market System"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.OldLace
        LinkLabel1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(184, 389)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(189, 28)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Create New Account"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.BackColor = Color.OldLace
        LinkLabel2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel2.Location = New Point(197, 444)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(158, 28)
        LinkLabel2.TabIndex = 10
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Forgot Password"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.OldLace
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(513, 705)
        Panel1.TabIndex = 11
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(437, 282)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(18, 17)
        CheckBox1.TabIndex = 2
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(321, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 20)
        Label3.TabIndex = 1
        Label3.Text = "Show Password"
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSlateGray
        ClientSize = New Size(537, 729)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(BtnClear)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(BtnLogin)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2, 3, 2, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log In"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox

End Class
