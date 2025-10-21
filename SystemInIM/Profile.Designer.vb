<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        Label7 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Button3 = New Button()
        PictureBox2 = New PictureBox()
        Label8 = New Label()
        Button7 = New Button()
        Label3 = New Label()
        Label14 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(22, 61)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(192, 163)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(234, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 32)
        Label1.TabIndex = 1
        Label1.Text = "User Profile"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei UI", 12F)
        Label2.Location = New Point(234, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 21)
        Label2.TabIndex = 2
        Label2.Text = "Age:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft YaHei UI", 12F)
        Label4.Location = New Point(234, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 21)
        Label4.TabIndex = 4
        Label4.Text = "Email Address:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft YaHei UI", 12F)
        Label6.Location = New Point(72, 236)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 21)
        Label6.TabIndex = 6
        Label6.Text = "Username"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = Color.Linen
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(22, 342)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(587, 182)
        DataGridView1.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(33, 313)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 19)
        Label7.TabIndex = 8
        Label7.Text = "History:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightSlateGray
        Button1.Font = New Font("Segoe UI", 10.2F)
        Button1.ForeColor = Color.Linen
        Button1.Location = New Point(220, 542)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(175, 29)
        Button1.TabIndex = 9
        Button1.Text = "Edit Profile"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSlateGray
        Button2.Font = New Font("Segoe UI", 10.2F)
        Button2.ForeColor = Color.Linen
        Button2.Location = New Point(434, 542)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(175, 29)
        Button2.TabIndex = 10
        Button2.Text = "Log Out"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label8)
        Panel1.Location = New Point(643, 20)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(598, 562)
        Panel1.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(338, 204)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(217, 23)
        TextBox3.TabIndex = 14
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(384, 158)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(170, 23)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(384, 108)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(170, 23)
        TextBox1.TabIndex = 12
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(307, 69)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(247, 23)
        DateTimePicker1.TabIndex = 11
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.LightSlateGray
        Button6.Font = New Font("Segoe UI", 10.2F)
        Button6.ForeColor = SystemColors.Info
        Button6.Location = New Point(195, 382)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(218, 29)
        Button6.TabIndex = 10
        Button6.Text = "Save Changes"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.LightSlateGray
        Button5.Font = New Font("Segoe UI", 10.2F)
        Button5.ForeColor = SystemColors.Info
        Button5.Location = New Point(195, 448)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(218, 28)
        Button5.TabIndex = 9
        Button5.Text = "Cancel Edit Mode"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LightSlateGray
        Button4.Font = New Font("Segoe UI", 10.2F)
        Button4.ForeColor = SystemColors.Info
        Button4.Location = New Point(195, 314)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(218, 30)
        Button4.TabIndex = 8
        Button4.Text = "Reset Password"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft YaHei UI", 10.8F)
        Label13.Location = New Point(89, 233)
        Label13.Name = "Label13"
        Label13.Size = New Size(82, 20)
        Label13.TabIndex = 7
        Label13.Text = "Username"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft YaHei UI", 10.8F)
        Label12.Location = New Point(259, 202)
        Label12.Name = "Label12"
        Label12.Size = New Size(73, 20)
        Label12.TabIndex = 6
        Label12.Text = "Address:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft YaHei UI", 10.8F)
        Label11.Location = New Point(259, 158)
        Label11.Name = "Label11"
        Label11.Size = New Size(115, 20)
        Label11.TabIndex = 5
        Label11.Text = "Email Address:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft YaHei UI", 10.8F)
        Label10.Location = New Point(259, 110)
        Label10.Name = "Label10"
        Label10.Size = New Size(93, 20)
        Label10.TabIndex = 4
        Label10.Text = "Contact no."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft YaHei UI", 10.8F)
        Label9.Location = New Point(259, 69)
        Label9.Name = "Label9"
        Label9.Size = New Size(43, 20)
        Label9.TabIndex = 3
        Label9.Text = "Age:"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(81, 134)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 22)
        Button3.TabIndex = 2
        Button3.Text = "Change Picture"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(42, 62)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(192, 163)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Leelawadee UI", 18F, FontStyle.Bold)
        Label8.Location = New Point(224, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(141, 32)
        Label8.TabIndex = 0
        Label8.Text = "Edit Profile"
        ' 
        ' Button7
        ' 
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(477, 310)
        Button7.Margin = New Padding(3, 2, 3, 2)
        Button7.Name = "Button7"
        Button7.Size = New Size(113, 24)
        Button7.TabIndex = 12
        Button7.Text = "expand history"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 12F)
        Label3.Location = New Point(234, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 21)
        Label3.TabIndex = 3
        Label3.Text = "Contact Number:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft YaHei UI", 12F)
        Label14.Location = New Point(241, 68)
        Label14.Name = "Label14"
        Label14.Size = New Size(299, 21)
        Label14.TabIndex = 13
        Label14.Text = "Full Name: -not provided by the user-"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft YaHei UI", 12F)
        Label5.Location = New Point(33, 271)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 21)
        Label5.TabIndex = 14
        Label5.Text = "Address:"
        ' 
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(640, 593)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(Label14)
        Controls.Add(Button7)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Profile"
        Text = " "
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button7 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
End Class
