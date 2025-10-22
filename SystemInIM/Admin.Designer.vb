<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        CheckBox1 = New CheckBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.OldLace
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(514, 559)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(275, 482)
        Button2.Name = "Button2"
        Button2.Size = New Size(165, 44)
        Button2.TabIndex = 9
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(65, 482)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 44)
        Button1.TabIndex = 8
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(167, 363)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(158, 28)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(422, 283)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(18, 17)
        CheckBox1.TabIndex = 6
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(306, 280)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 20)
        Label4.TabIndex = 5
        Label4.Text = "Show Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.DimGray
        TextBox2.Location = New Point(145, 240)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "(Type in your password)"
        TextBox2.Size = New Size(327, 30)
        TextBox2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(24, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 28)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.DimGray
        TextBox1.Location = New Point(145, 160)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "(Type in your username)"
        TextBox1.Size = New Size(327, 30)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 28)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(114, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 41)
        Label1.TabIndex = 0
        Label1.Text = "Admin/Staff Login"
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SlateGray
        ClientSize = New Size(538, 583)
        Controls.Add(Panel1)
        Name = "Admin"
        Text = "Admin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
