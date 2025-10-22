<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orders
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
        linkOrders = New LinkLabel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel2 = New Panel()
        btnOrderDetails2 = New Button()
        txtPrice2 = New TextBox()
        txtCategory2 = New TextBox()
        txtItemName2 = New TextBox()
        txtQty2 = New TextBox()
        txtOrderedBy2 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        lblOrderedBy1 = New Label()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(189))
        Panel1.Controls.Add(linkOrders)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1107, 113)
        Panel1.TabIndex = 2
        ' 
        ' linkOrders
        ' 
        linkOrders.ActiveLinkColor = Color.White
        linkOrders.AutoSize = True
        linkOrders.Font = New Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        linkOrders.LinkBehavior = LinkBehavior.NeverUnderline
        linkOrders.LinkColor = Color.Black
        linkOrders.Location = New Point(50, 25)
        linkOrders.Name = "linkOrders"
        linkOrders.Size = New Size(158, 59)
        linkOrders.TabIndex = 1
        linkOrders.TabStop = True
        linkOrders.Text = "Orders"
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
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(189))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnOrderDetails2)
        Panel2.Controls.Add(txtPrice2)
        Panel2.Controls.Add(txtCategory2)
        Panel2.Controls.Add(txtItemName2)
        Panel2.Controls.Add(txtQty2)
        Panel2.Controls.Add(txtOrderedBy2)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(lblOrderedBy1)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(35, 23)
        Panel2.Margin = New Padding(15, 3, 3, 45)
        Panel2.Name = "Panel2"
        Panel2.RightToLeft = RightToLeft.No
        Panel2.Size = New Size(238, 419)
        Panel2.TabIndex = 0
        ' 
        ' btnOrderDetails2
        ' 
        btnOrderDetails2.Location = New Point(130, 381)
        btnOrderDetails2.Name = "btnOrderDetails2"
        btnOrderDetails2.Size = New Size(90, 23)
        btnOrderDetails2.TabIndex = 12
        btnOrderDetails2.Text = "Order Details"
        btnOrderDetails2.UseVisualStyleBackColor = True
        ' 
        ' txtPrice2
        ' 
        txtPrice2.Location = New Point(4, 350)
        txtPrice2.Name = "txtPrice2"
        txtPrice2.Size = New Size(119, 23)
        txtPrice2.TabIndex = 11
        ' 
        ' txtCategory2
        ' 
        txtCategory2.Location = New Point(4, 302)
        txtCategory2.Name = "txtCategory2"
        txtCategory2.Size = New Size(119, 23)
        txtCategory2.TabIndex = 10
        ' 
        ' txtItemName2
        ' 
        txtItemName2.Location = New Point(3, 254)
        txtItemName2.Name = "txtItemName2"
        txtItemName2.Size = New Size(119, 23)
        txtItemName2.TabIndex = 9
        ' 
        ' txtQty2
        ' 
        txtQty2.Location = New Point(101, 206)
        txtQty2.Name = "txtQty2"
        txtQty2.Size = New Size(119, 23)
        txtQty2.TabIndex = 8
        ' 
        ' txtOrderedBy2
        ' 
        txtOrderedBy2.Location = New Point(101, 177)
        txtOrderedBy2.Name = "txtOrderedBy2"
        txtOrderedBy2.Size = New Size(119, 23)
        txtOrderedBy2.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(4, 328)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 19)
        Label6.TabIndex = 6
        Label6.Text = "Product Price:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(3, 280)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 19)
        Label5.TabIndex = 5
        Label5.Text = "Product Category:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(4, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 19)
        Label4.TabIndex = 4
        Label4.Text = "Product Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(4, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 19)
        Label3.TabIndex = 3
        Label3.Text = "Qty:"
        ' 
        ' lblOrderedBy1
        ' 
        lblOrderedBy1.AutoSize = True
        lblOrderedBy1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrderedBy1.Location = New Point(4, 181)
        lblOrderedBy1.Name = "lblOrderedBy1"
        lblOrderedBy1.Size = New Size(91, 19)
        lblOrderedBy1.TabIndex = 1
        lblOrderedBy1.Text = "Ordered By:"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(14, 29)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(206, 137)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' orders
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(227))
        Controls.Add(Panel1)
        Controls.Add(FlowLayoutPanel1)
        Name = "orders"
        Size = New Size(1107, 579)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents linkOrders As LinkLabel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblOrderedBy1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtPrice2 As TextBox
    Friend WithEvents txtCategory2 As TextBox
    Friend WithEvents txtItemName2 As TextBox
    Friend WithEvents txtQty2 As TextBox
    Friend WithEvents txtOrderedBy2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOrderDetails2 As Button
    Friend WithEvents Button1 As Button

End Class
