<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        linkStaff = New LinkLabel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel2 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(189))
        Panel1.Controls.Add(linkStaff)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1113, 113)
        Panel1.TabIndex = 3
        ' 
        ' linkStaff
        ' 
        linkStaff.ActiveLinkColor = Color.White
        linkStaff.AutoSize = True
        linkStaff.Font = New Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        linkStaff.LinkBehavior = LinkBehavior.NeverUnderline
        linkStaff.LinkColor = Color.Black
        linkStaff.Location = New Point(50, 25)
        linkStaff.Name = "linkStaff"
        linkStaff.Size = New Size(291, 59)
        linkStaff.TabIndex = 1
        linkStaff.TabStop = True
        linkStaff.Text = "Manage Staff"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Add(Panel2)
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        FlowLayoutPanel1.Location = New Point(0, 117)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(20)
        FlowLayoutPanel1.Size = New Size(1107, 462)
        FlowLayoutPanel1.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(189))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(35, 23)
        Panel2.Margin = New Padding(15, 3, 3, 45)
        Panel2.Name = "Panel2"
        Panel2.RightToLeft = RightToLeft.No
        Panel2.Size = New Size(238, 237)
        Panel2.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Image = My.Resources.Resources._3_Tasten_Maus_Microsoft
        Button1.Location = New Point(14, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(206, 131)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(79, 180)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 2
        Label1.Text = "Staff ni Jael"
        ' 
        ' staff
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(227))
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel1)
        Name = "staff"
        Size = New Size(1107, 579)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents linkStaff As LinkLabel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label

End Class
