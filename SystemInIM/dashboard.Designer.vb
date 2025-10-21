<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        linkDashboard = New LinkLabel()
        circleLeft = New Panel()
        circleLeftBorder = New Panel()
        circleMiddle = New Panel()
        circleMiddleBorder = New Panel()
        circleRight = New Panel()
        circleRightBorder = New Panel()
        dashboardLabel1 = New LinkLabel()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(189))
        Panel1.Controls.Add(linkDashboard)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1107, 113)
        Panel1.TabIndex = 0
        ' 
        ' linkDashboard
        ' 
        linkDashboard.ActiveLinkColor = Color.White
        linkDashboard.AutoSize = True
        linkDashboard.Font = New Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        linkDashboard.LinkBehavior = LinkBehavior.NeverUnderline
        linkDashboard.LinkColor = Color.Black
        linkDashboard.Location = New Point(50, 25)
        linkDashboard.Name = "linkDashboard"
        linkDashboard.Size = New Size(242, 59)
        linkDashboard.TabIndex = 1
        linkDashboard.TabStop = True
        linkDashboard.Text = "Dashboard"
        ' 
        ' circleLeft
        ' 
        circleLeft.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(189))
        circleLeft.Location = New Point(69, 170)
        circleLeft.Name = "circleLeft"
        circleLeft.Size = New Size(220, 260)
        circleLeft.TabIndex = 1
        ' 
        ' circleLeftBorder
        ' 
        circleLeftBorder.BackColor = Color.FromArgb(CByte(255), CByte(201), CByte(67))
        circleLeftBorder.Location = New Point(57, 159)
        circleLeftBorder.Name = "circleLeftBorder"
        circleLeftBorder.Size = New Size(243, 283)
        circleLeftBorder.TabIndex = 2
        ' 
        ' circleMiddle
        ' 
        circleMiddle.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(189))
        circleMiddle.Location = New Point(441, 170)
        circleMiddle.Name = "circleMiddle"
        circleMiddle.Size = New Size(220, 260)
        circleMiddle.TabIndex = 3
        ' 
        ' circleMiddleBorder
        ' 
        circleMiddleBorder.BackColor = Color.FromArgb(CByte(255), CByte(201), CByte(67))
        circleMiddleBorder.Location = New Point(429, 159)
        circleMiddleBorder.Name = "circleMiddleBorder"
        circleMiddleBorder.Size = New Size(243, 283)
        circleMiddleBorder.TabIndex = 4
        ' 
        ' circleRight
        ' 
        circleRight.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(189))
        circleRight.Location = New Point(834, 170)
        circleRight.Name = "circleRight"
        circleRight.Size = New Size(220, 260)
        circleRight.TabIndex = 5
        ' 
        ' circleRightBorder
        ' 
        circleRightBorder.BackColor = Color.FromArgb(CByte(255), CByte(201), CByte(67))
        circleRightBorder.Location = New Point(822, 159)
        circleRightBorder.Name = "circleRightBorder"
        circleRightBorder.Size = New Size(243, 283)
        circleRightBorder.TabIndex = 6
        ' 
        ' dashboardLabel1
        ' 
        dashboardLabel1.ActiveLinkColor = Color.White
        dashboardLabel1.AutoSize = True
        dashboardLabel1.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dashboardLabel1.LinkBehavior = LinkBehavior.NeverUnderline
        dashboardLabel1.LinkColor = Color.Black
        dashboardLabel1.Location = New Point(58, 469)
        dashboardLabel1.Name = "dashboardLabel1"
        dashboardLabel1.Size = New Size(241, 39)
        dashboardLabel1.TabIndex = 2
        dashboardLabel1.TabStop = True
        dashboardLabel1.Text = "Total Sales Today"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.White
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(455, 469)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(179, 39)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Total Orders"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.White
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel2.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel2.LinkColor = Color.Black
        LinkLabel2.Location = New Point(858, 469)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(174, 39)
        LinkLabel2.TabIndex = 8
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Top Product"
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(227))
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(dashboardLabel1)
        Controls.Add(circleRight)
        Controls.Add(circleRightBorder)
        Controls.Add(circleMiddle)
        Controls.Add(circleMiddleBorder)
        Controls.Add(circleLeft)
        Controls.Add(Panel1)
        Controls.Add(circleLeftBorder)
        Name = "dashboard"
        Size = New Size(1107, 579)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents linkDashboard As LinkLabel
    Friend WithEvents circleLeft As Panel
    Friend WithEvents circleLeftBorder As Panel
    Friend WithEvents circleMiddle As Panel
    Friend WithEvents circleMiddleBorder As Panel
    Friend WithEvents circleRight As Panel
    Friend WithEvents circleRightBorder As Panel
    Friend WithEvents dashboardLabel1 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel

End Class
