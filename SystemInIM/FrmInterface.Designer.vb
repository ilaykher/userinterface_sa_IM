<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInterface
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
        bgPanelTop = New Panel()
        adminPic1 = New PictureBox()
        lblAdmintxt = New Label()
        bgPanelLeft = New Panel()
        linkDashboard = New LinkLabel()
        linkCustomer = New LinkLabel()
        linkStaff = New LinkLabel()
        linkHistory = New LinkLabel()
        linkOrders = New LinkLabel()
        linkInventory = New LinkLabel()
        panelMain = New Panel()
        displayMsg = New LinkLabel()
        bgPanelTop.SuspendLayout()
        CType(adminPic1, ComponentModel.ISupportInitialize).BeginInit()
        bgPanelLeft.SuspendLayout()
        panelMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' bgPanelTop
        ' 
        bgPanelTop.BackColor = SystemColors.ActiveCaption
        bgPanelTop.Controls.Add(adminPic1)
        bgPanelTop.Controls.Add(lblAdmintxt)
        bgPanelTop.Location = New Point(-1, -1)
        bgPanelTop.Name = "bgPanelTop"
        bgPanelTop.Size = New Size(1370, 110)
        bgPanelTop.TabIndex = 0
        ' 
        ' adminPic1
        ' 
        adminPic1.Location = New Point(1271, 13)
        adminPic1.Name = "adminPic1"
        adminPic1.Size = New Size(83, 77)
        adminPic1.TabIndex = 1
        adminPic1.TabStop = False
        ' 
        ' lblAdmintxt
        ' 
        lblAdmintxt.AutoSize = True
        lblAdmintxt.Font = New Font("Cascadia Mono", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAdmintxt.Location = New Point(1086, 28)
        lblAdmintxt.Name = "lblAdmintxt"
        lblAdmintxt.Size = New Size(167, 46)
        lblAdmintxt.TabIndex = 0
        lblAdmintxt.Text = "Admin 1"
        ' 
        ' bgPanelLeft
        ' 
        bgPanelLeft.BackColor = SystemColors.ActiveCaption
        bgPanelLeft.BorderStyle = BorderStyle.FixedSingle
        bgPanelLeft.Controls.Add(linkDashboard)
        bgPanelLeft.Controls.Add(linkCustomer)
        bgPanelLeft.Controls.Add(linkStaff)
        bgPanelLeft.Controls.Add(linkHistory)
        bgPanelLeft.Controls.Add(linkOrders)
        bgPanelLeft.Controls.Add(linkInventory)
        bgPanelLeft.Location = New Point(-9, 109)
        bgPanelLeft.Name = "bgPanelLeft"
        bgPanelLeft.Size = New Size(301, 579)
        bgPanelLeft.TabIndex = 1
        ' 
        ' linkDashboard
        ' 
        linkDashboard.ActiveLinkColor = Color.White
        linkDashboard.AutoSize = True
        linkDashboard.Font = New Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        linkDashboard.LinkBehavior = LinkBehavior.NeverUnderline
        linkDashboard.LinkColor = Color.Black
        linkDashboard.Location = New Point(21, 41)
        linkDashboard.Name = "linkDashboard"
        linkDashboard.Size = New Size(159, 39)
        linkDashboard.TabIndex = 0
        linkDashboard.TabStop = True
        linkDashboard.Text = "Dashboard"
        ' 
        ' linkCustomer
        ' 
        linkCustomer.ActiveLinkColor = Color.White
        linkCustomer.AutoSize = True
        linkCustomer.Font = New Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        linkCustomer.LinkBehavior = LinkBehavior.NeverUnderline
        linkCustomer.LinkColor = Color.Black
        linkCustomer.Location = New Point(21, 362)
        linkCustomer.Name = "linkCustomer"
        linkCustomer.Size = New Size(274, 39)
        linkCustomer.TabIndex = 5
        linkCustomer.TabStop = True
        linkCustomer.Text = "Customer Accounts"
        ' 
        ' linkStaff
        ' 
        linkStaff.ActiveLinkColor = Color.White
        linkStaff.AutoSize = True
        linkStaff.Font = New Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        linkStaff.LinkBehavior = LinkBehavior.NeverUnderline
        linkStaff.LinkColor = Color.Black
        linkStaff.Location = New Point(21, 299)
        linkStaff.Name = "linkStaff"
        linkStaff.Size = New Size(189, 39)
        linkStaff.TabIndex = 4
        linkStaff.TabStop = True
        linkStaff.Text = "Manage Staff"
        ' 
        ' linkHistory
        ' 
        linkHistory.ActiveLinkColor = Color.White
        linkHistory.AutoSize = True
        linkHistory.Font = New Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        linkHistory.LinkBehavior = LinkBehavior.NeverUnderline
        linkHistory.LinkColor = Color.Black
        linkHistory.Location = New Point(21, 232)
        linkHistory.Name = "linkHistory"
        linkHistory.Size = New Size(267, 39)
        linkHistory.TabIndex = 3
        linkHistory.TabStop = True
        linkHistory.Text = "Transaction History"
        ' 
        ' linkOrders
        ' 
        linkOrders.ActiveLinkColor = Color.White
        linkOrders.AutoSize = True
        linkOrders.Font = New Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        linkOrders.LinkBehavior = LinkBehavior.NeverUnderline
        linkOrders.LinkColor = Color.Black
        linkOrders.Location = New Point(21, 169)
        linkOrders.Name = "linkOrders"
        linkOrders.Size = New Size(105, 39)
        linkOrders.TabIndex = 2
        linkOrders.TabStop = True
        linkOrders.Text = "Orders"
        ' 
        ' linkInventory
        ' 
        linkInventory.ActiveLinkColor = Color.White
        linkInventory.AutoSize = True
        linkInventory.Font = New Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        linkInventory.LinkBehavior = LinkBehavior.NeverUnderline
        linkInventory.LinkColor = Color.Black
        linkInventory.Location = New Point(21, 103)
        linkInventory.Name = "linkInventory"
        linkInventory.Size = New Size(141, 39)
        linkInventory.TabIndex = 1
        linkInventory.TabStop = True
        linkInventory.Text = "Inventory"
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(227))
        panelMain.BorderStyle = BorderStyle.FixedSingle
        panelMain.Controls.Add(displayMsg)
        panelMain.Location = New Point(262, 109)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(1107, 579)
        panelMain.TabIndex = 0
        ' 
        ' displayMsg
        ' 
        displayMsg.ActiveLinkColor = Color.White
        displayMsg.AutoSize = True
        displayMsg.Font = New Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        displayMsg.LinkBehavior = LinkBehavior.NeverUnderline
        displayMsg.LinkColor = Color.Black
        displayMsg.Location = New Point(53, 16)
        displayMsg.Name = "displayMsg"
        displayMsg.Size = New Size(269, 45)
        displayMsg.TabIndex = 6
        displayMsg.TabStop = True
        displayMsg.Text = "Select Category:"
        ' 
        ' FrmInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(246), CByte(235))
        ClientSize = New Size(1365, 686)
        Controls.Add(bgPanelLeft)
        Controls.Add(bgPanelTop)
        Controls.Add(panelMain)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        Name = "FrmInterface"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Device Market System"
        WindowState = FormWindowState.Maximized
        bgPanelTop.ResumeLayout(False)
        bgPanelTop.PerformLayout()
        CType(adminPic1, ComponentModel.ISupportInitialize).EndInit()
        bgPanelLeft.ResumeLayout(False)
        bgPanelLeft.PerformLayout()
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents bgPanelTop As Panel
    Friend WithEvents lblAdmintxt As Label
    Friend WithEvents adminPic1 As PictureBox
    Friend WithEvents bgPanelLeft As Panel
    Friend WithEvents linkDashboard As LinkLabel
    Friend WithEvents linkHistory As LinkLabel
    Friend WithEvents linkOrders As LinkLabel
    Friend WithEvents linkInventory As LinkLabel
    Friend WithEvents linkStaff As LinkLabel
    Friend WithEvents linkCustomer As LinkLabel
    Friend WithEvents panelMain As Panel
    Friend WithEvents displayMsg As LinkLabel
End Class
