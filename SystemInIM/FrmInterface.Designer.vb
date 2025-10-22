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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInterface))
        bgPanelTop = New Panel()
        adminPic1 = New PictureBox()
        lblAdmintxt = New Label()
        bgPanelLeft = New Panel()
        btnAcc = New Button()
        btnStaff = New Button()
        btnHist = New Button()
        btnOrder = New Button()
        btnInv = New Button()
        btnDB = New Button()
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
        adminPic1.Image = CType(resources.GetObject("adminPic1.Image"), Image)
        adminPic1.Location = New Point(1271, 13)
        adminPic1.Name = "adminPic1"
        adminPic1.Size = New Size(83, 77)
        adminPic1.SizeMode = PictureBoxSizeMode.StretchImage
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
        bgPanelLeft.Controls.Add(btnAcc)
        bgPanelLeft.Controls.Add(btnStaff)
        bgPanelLeft.Controls.Add(btnHist)
        bgPanelLeft.Controls.Add(btnOrder)
        bgPanelLeft.Controls.Add(btnInv)
        bgPanelLeft.Controls.Add(btnDB)
        bgPanelLeft.Location = New Point(-9, 109)
        bgPanelLeft.Name = "bgPanelLeft"
        bgPanelLeft.Size = New Size(301, 579)
        bgPanelLeft.TabIndex = 1
        ' 
        ' btnAcc
        ' 
        btnAcc.BackColor = SystemColors.ActiveCaption
        btnAcc.FlatStyle = FlatStyle.Flat
        btnAcc.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAcc.Location = New Point(7, 489)
        btnAcc.Name = "btnAcc"
        btnAcc.Size = New Size(293, 92)
        btnAcc.TabIndex = 9
        btnAcc.Text = "Customer Accounts"
        btnAcc.UseVisualStyleBackColor = False
        ' 
        ' btnStaff
        ' 
        btnStaff.BackColor = SystemColors.ActiveCaption
        btnStaff.FlatStyle = FlatStyle.Flat
        btnStaff.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStaff.Location = New Point(7, 391)
        btnStaff.Name = "btnStaff"
        btnStaff.Size = New Size(293, 92)
        btnStaff.TabIndex = 9
        btnStaff.Text = "Manage Staff"
        btnStaff.UseVisualStyleBackColor = False
        ' 
        ' btnHist
        ' 
        btnHist.BackColor = SystemColors.ActiveCaption
        btnHist.FlatStyle = FlatStyle.Flat
        btnHist.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHist.Location = New Point(7, 293)
        btnHist.Name = "btnHist"
        btnHist.Size = New Size(293, 92)
        btnHist.TabIndex = 10
        btnHist.Text = "Transaction History"
        btnHist.UseVisualStyleBackColor = False
        ' 
        ' btnOrder
        ' 
        btnOrder.BackColor = SystemColors.ActiveCaption
        btnOrder.FlatStyle = FlatStyle.Flat
        btnOrder.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOrder.Location = New Point(7, 195)
        btnOrder.Name = "btnOrder"
        btnOrder.Size = New Size(293, 92)
        btnOrder.TabIndex = 9
        btnOrder.Text = "Orders"
        btnOrder.UseVisualStyleBackColor = False
        ' 
        ' btnInv
        ' 
        btnInv.BackColor = SystemColors.ActiveCaption
        btnInv.FlatStyle = FlatStyle.Flat
        btnInv.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInv.Location = New Point(7, 97)
        btnInv.Name = "btnInv"
        btnInv.Size = New Size(293, 92)
        btnInv.TabIndex = 8
        btnInv.Text = "Inventory"
        btnInv.UseVisualStyleBackColor = False
        ' 
        ' btnDB
        ' 
        btnDB.BackColor = SystemColors.ActiveCaption
        btnDB.FlatStyle = FlatStyle.Flat
        btnDB.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDB.Location = New Point(7, -1)
        btnDB.Name = "btnDB"
        btnDB.Size = New Size(293, 92)
        btnDB.TabIndex = 7
        btnDB.Text = "Dashboard"
        btnDB.UseVisualStyleBackColor = False
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
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents bgPanelTop As Panel
    Friend WithEvents lblAdmintxt As Label
    Friend WithEvents adminPic1 As PictureBox
    Friend WithEvents bgPanelLeft As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents displayMsg As LinkLabel
    Friend WithEvents btnDB As Button
    Friend WithEvents btnInv As Button
    Friend WithEvents btnAcc As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnHist As Button
    Friend WithEvents btnOrder As Button
End Class
