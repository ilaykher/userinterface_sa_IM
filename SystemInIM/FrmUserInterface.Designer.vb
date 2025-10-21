<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserInterface
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvProductDisplay = New DataGridView()
        lblDeviceMarketSystem = New Label()
        BtnLogout = New Button()
        pnlSearchBar = New Panel()
        lblCategory = New Label()
        cmbCategorySearch = New ComboBox()
        txtSearchBar = New TextBox()
        lblSearch = New Label()
        BtnRefresh = New Button()
        BtnBuyNow = New Button()
        BtnAddToCart = New Button()
        Panel2 = New Panel()
        lblShowBalance = New Label()
        lblSetBalance = New Label()
        BtnBalance = New Button()
        txtUserBalance = New TextBox()
        lblWelcome = New Label()
        tbControlMain = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        BtnRemoveAll = New Button()
        BtnRefreshAll = New Button()
        BtnRemoveAddToCart = New Button()
        Panel3 = New Panel()
        Label1 = New Label()
        cmbCategoryViewCart = New ComboBox()
        txtBoxSearchBarViewCart = New TextBox()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        BtnPlaceAnOrder = New Button()
        CType(dgvProductDisplay, ComponentModel.ISupportInitialize).BeginInit()
        pnlSearchBar.SuspendLayout()
        Panel2.SuspendLayout()
        tbControlMain.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProductDisplay
        ' 
        dgvProductDisplay.AllowUserToAddRows = False
        dgvProductDisplay.AllowUserToDeleteRows = False
        dgvProductDisplay.AllowUserToOrderColumns = True
        dgvProductDisplay.AllowUserToResizeColumns = False
        dgvProductDisplay.AllowUserToResizeRows = False
        dgvProductDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductDisplay.BackgroundColor = SystemColors.AppWorkspace
        dgvProductDisplay.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle1.ForeColor = SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvProductDisplay.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvProductDisplay.ColumnHeadersHeight = 29
        dgvProductDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvProductDisplay.Location = New Point(316, 65)
        dgvProductDisplay.Margin = New Padding(2)
        dgvProductDisplay.MultiSelect = False
        dgvProductDisplay.Name = "dgvProductDisplay"
        dgvProductDisplay.ReadOnly = True
        dgvProductDisplay.RowHeadersVisible = False
        dgvProductDisplay.RowHeadersWidth = 62
        dgvProductDisplay.RowTemplate.Height = 150
        dgvProductDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductDisplay.Size = New Size(1164, 422)
        dgvProductDisplay.TabIndex = 2
        ' 
        ' lblDeviceMarketSystem
        ' 
        lblDeviceMarketSystem.BackColor = Color.FromArgb(CByte(102), CByte(126), CByte(234))
        lblDeviceMarketSystem.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeviceMarketSystem.ForeColor = Color.White
        lblDeviceMarketSystem.Location = New Point(307, 20)
        lblDeviceMarketSystem.Margin = New Padding(2, 0, 2, 0)
        lblDeviceMarketSystem.Name = "lblDeviceMarketSystem"
        lblDeviceMarketSystem.Padding = New Padding(18, 15, 18, 15)
        lblDeviceMarketSystem.Size = New Size(1050, 67)
        lblDeviceMarketSystem.TabIndex = 0
        lblDeviceMarketSystem.Text = "DEVICE MARKET SYSTEM"
        lblDeviceMarketSystem.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnLogout
        ' 
        BtnLogout.Font = New Font("Segoe UI", 12F)
        BtnLogout.Location = New Point(330, 66)
        BtnLogout.Margin = New Padding(2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(110, 28)
        BtnLogout.TabIndex = 3
        BtnLogout.Text = "Logout"
        BtnLogout.UseVisualStyleBackColor = True
        ' 
        ' pnlSearchBar
        ' 
        pnlSearchBar.Controls.Add(lblCategory)
        pnlSearchBar.Controls.Add(cmbCategorySearch)
        pnlSearchBar.Controls.Add(txtSearchBar)
        pnlSearchBar.Controls.Add(lblSearch)
        pnlSearchBar.Location = New Point(316, 14)
        pnlSearchBar.Margin = New Padding(2)
        pnlSearchBar.Name = "pnlSearchBar"
        pnlSearchBar.Size = New Size(863, 48)
        pnlSearchBar.TabIndex = 5
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Segoe UI", 12F)
        lblCategory.Location = New Point(484, 11)
        lblCategory.Margin = New Padding(2, 0, 2, 0)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(76, 21)
        lblCategory.TabIndex = 14
        lblCategory.Text = "Category:"
        ' 
        ' cmbCategorySearch
        ' 
        cmbCategorySearch.FormattingEnabled = True
        cmbCategorySearch.Items.AddRange(New Object() {"--Select--", "Cellphone", "Computer", "Laptop"})
        cmbCategorySearch.Location = New Point(578, 9)
        cmbCategorySearch.Margin = New Padding(2)
        cmbCategorySearch.Name = "cmbCategorySearch"
        cmbCategorySearch.Size = New Size(128, 29)
        cmbCategorySearch.TabIndex = 13
        ' 
        ' txtSearchBar
        ' 
        txtSearchBar.BorderStyle = BorderStyle.FixedSingle
        txtSearchBar.Location = New Point(90, 12)
        txtSearchBar.Margin = New Padding(2)
        txtSearchBar.Name = "txtSearchBar"
        txtSearchBar.Size = New Size(359, 29)
        txtSearchBar.TabIndex = 12
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 12F)
        lblSearch.Location = New Point(10, 11)
        lblSearch.Margin = New Padding(2, 0, 2, 0)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(64, 21)
        lblSearch.TabIndex = 11
        lblSearch.Text = "Search: "
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        BtnRefresh.Location = New Point(67, 285)
        BtnRefresh.Margin = New Padding(3, 2, 3, 2)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(166, 76)
        BtnRefresh.TabIndex = 20
        BtnRefresh.Text = "Refresh"
        BtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' BtnBuyNow
        ' 
        BtnBuyNow.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        BtnBuyNow.Location = New Point(67, 190)
        BtnBuyNow.Margin = New Padding(3, 2, 3, 2)
        BtnBuyNow.Name = "BtnBuyNow"
        BtnBuyNow.Size = New Size(166, 76)
        BtnBuyNow.TabIndex = 19
        BtnBuyNow.Text = "Buy Now"
        BtnBuyNow.UseVisualStyleBackColor = True
        ' 
        ' BtnAddToCart
        ' 
        BtnAddToCart.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        BtnAddToCart.Location = New Point(67, 99)
        BtnAddToCart.Margin = New Padding(3, 2, 3, 2)
        BtnAddToCart.Name = "BtnAddToCart"
        BtnAddToCart.Size = New Size(166, 76)
        BtnAddToCart.TabIndex = 17
        BtnAddToCart.Text = "Add to Cart"
        BtnAddToCart.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(lblShowBalance)
        Panel2.Controls.Add(lblSetBalance)
        Panel2.Controls.Add(BtnBalance)
        Panel2.Controls.Add(txtUserBalance)
        Panel2.Controls.Add(lblWelcome)
        Panel2.Controls.Add(BtnLogout)
        Panel2.Location = New Point(39, 89)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(458, 141)
        Panel2.TabIndex = 22
        ' 
        ' lblShowBalance
        ' 
        lblShowBalance.AutoSize = True
        lblShowBalance.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblShowBalance.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        lblShowBalance.Location = New Point(53, 70)
        lblShowBalance.Name = "lblShowBalance"
        lblShowBalance.Size = New Size(71, 20)
        lblShowBalance.TabIndex = 25
        lblShowBalance.Text = "Balance: "
        ' 
        ' lblSetBalance
        ' 
        lblSetBalance.AutoSize = True
        lblSetBalance.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblSetBalance.Location = New Point(17, 106)
        lblSetBalance.Name = "lblSetBalance"
        lblSetBalance.Size = New Size(113, 21)
        lblSetBalance.TabIndex = 24
        lblSetBalance.Text = "Add Balance: "
        ' 
        ' BtnBalance
        ' 
        BtnBalance.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        BtnBalance.Cursor = Cursors.Hand
        BtnBalance.FlatAppearance.BorderSize = 0
        BtnBalance.FlatStyle = FlatStyle.Flat
        BtnBalance.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnBalance.ForeColor = Color.White
        BtnBalance.Location = New Point(330, 103)
        BtnBalance.Margin = New Padding(2)
        BtnBalance.Name = "BtnBalance"
        BtnBalance.Size = New Size(110, 28)
        BtnBalance.TabIndex = 23
        BtnBalance.Text = "Set Balance"
        BtnBalance.UseVisualStyleBackColor = False
        ' 
        ' txtUserBalance
        ' 
        txtUserBalance.BorderStyle = BorderStyle.FixedSingle
        txtUserBalance.Font = New Font("Segoe UI", 12F)
        txtUserBalance.Location = New Point(144, 104)
        txtUserBalance.Margin = New Padding(2)
        txtUserBalance.Name = "txtUserBalance"
        txtUserBalance.Size = New Size(174, 29)
        txtUserBalance.TabIndex = 22
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        lblWelcome.Location = New Point(17, 14)
        lblWelcome.Margin = New Padding(2, 0, 2, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(103, 25)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Welcome, "
        ' 
        ' tbControlMain
        ' 
        tbControlMain.Controls.Add(TabPage1)
        tbControlMain.Controls.Add(TabPage2)
        tbControlMain.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbControlMain.Location = New Point(39, 235)
        tbControlMain.Margin = New Padding(3, 2, 3, 2)
        tbControlMain.Name = "tbControlMain"
        tbControlMain.SelectedIndex = 0
        tbControlMain.Size = New Size(1574, 531)
        tbControlMain.TabIndex = 6
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(BtnRefresh)
        TabPage1.Controls.Add(BtnBuyNow)
        TabPage1.Controls.Add(BtnAddToCart)
        TabPage1.Controls.Add(dgvProductDisplay)
        TabPage1.Controls.Add(pnlSearchBar)
        TabPage1.Font = New Font("Segoe UI", 12F)
        TabPage1.Location = New Point(4, 41)
        TabPage1.Margin = New Padding(3, 2, 3, 2)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 2, 3, 2)
        TabPage1.Size = New Size(1566, 486)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Shop"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(BtnRemoveAll)
        TabPage2.Controls.Add(BtnRefreshAll)
        TabPage2.Controls.Add(BtnRemoveAddToCart)
        TabPage2.Controls.Add(Panel3)
        TabPage2.Controls.Add(DataGridView1)
        TabPage2.Controls.Add(BtnPlaceAnOrder)
        TabPage2.Font = New Font("Segoe UI", 12F)
        TabPage2.Location = New Point(4, 41)
        TabPage2.Margin = New Padding(3, 2, 3, 2)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 2, 3, 2)
        TabPage2.Size = New Size(1566, 486)
        TabPage2.TabIndex = 1
        TabPage2.Text = "View Cart"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' BtnRemoveAll
        ' 
        BtnRemoveAll.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRemoveAll.Location = New Point(67, 379)
        BtnRemoveAll.Margin = New Padding(3, 2, 3, 2)
        BtnRemoveAll.Name = "BtnRemoveAll"
        BtnRemoveAll.Size = New Size(166, 76)
        BtnRemoveAll.TabIndex = 22
        BtnRemoveAll.Text = "Remove All"
        BtnRemoveAll.UseVisualStyleBackColor = True
        ' 
        ' BtnRefreshAll
        ' 
        BtnRefreshAll.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        BtnRefreshAll.Location = New Point(67, 190)
        BtnRefreshAll.Margin = New Padding(3, 2, 3, 2)
        BtnRefreshAll.Name = "BtnRefreshAll"
        BtnRefreshAll.Size = New Size(166, 76)
        BtnRefreshAll.TabIndex = 20
        BtnRefreshAll.Text = "Refresh"
        BtnRefreshAll.UseVisualStyleBackColor = True
        ' 
        ' BtnRemoveAddToCart
        ' 
        BtnRemoveAddToCart.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        BtnRemoveAddToCart.Location = New Point(67, 281)
        BtnRemoveAddToCart.Margin = New Padding(3, 2, 3, 2)
        BtnRemoveAddToCart.Name = "BtnRemoveAddToCart"
        BtnRemoveAddToCart.Size = New Size(166, 76)
        BtnRemoveAddToCart.TabIndex = 21
        BtnRemoveAddToCart.Text = "Remove "
        BtnRemoveAddToCart.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(cmbCategoryViewCart)
        Panel3.Controls.Add(txtBoxSearchBarViewCart)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(316, 14)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(863, 48)
        Panel3.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(484, 11)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 21)
        Label1.TabIndex = 14
        Label1.Text = "Category:"
        ' 
        ' cmbCategoryViewCart
        ' 
        cmbCategoryViewCart.FormattingEnabled = True
        cmbCategoryViewCart.Items.AddRange(New Object() {"--Select--", "Cellphone", "Computer", "Laptop"})
        cmbCategoryViewCart.Location = New Point(578, 9)
        cmbCategoryViewCart.Margin = New Padding(2)
        cmbCategoryViewCart.Name = "cmbCategoryViewCart"
        cmbCategoryViewCart.Size = New Size(128, 29)
        cmbCategoryViewCart.TabIndex = 13
        ' 
        ' txtBoxSearchBarViewCart
        ' 
        txtBoxSearchBarViewCart.Location = New Point(90, 12)
        txtBoxSearchBarViewCart.Margin = New Padding(2)
        txtBoxSearchBarViewCart.Name = "txtBoxSearchBarViewCart"
        txtBoxSearchBarViewCart.Size = New Size(359, 29)
        txtBoxSearchBarViewCart.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(10, 11)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 21)
        Label2.TabIndex = 11
        Label2.Text = "Search: "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.AppWorkspace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(316, 65)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 75
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1164, 422)
        DataGridView1.TabIndex = 3
        ' 
        ' BtnPlaceAnOrder
        ' 
        BtnPlaceAnOrder.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        BtnPlaceAnOrder.Location = New Point(67, 99)
        BtnPlaceAnOrder.Margin = New Padding(3, 2, 3, 2)
        BtnPlaceAnOrder.Name = "BtnPlaceAnOrder"
        BtnPlaceAnOrder.Size = New Size(166, 76)
        BtnPlaceAnOrder.TabIndex = 19
        BtnPlaceAnOrder.Text = "Place Order"
        BtnPlaceAnOrder.UseVisualStyleBackColor = True
        ' 
        ' FrmUserInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        ClientSize = New Size(1664, 775)
        Controls.Add(lblDeviceMarketSystem)
        Controls.Add(tbControlMain)
        Controls.Add(Panel2)
        Cursor = Cursors.Hand
        Margin = New Padding(3, 2, 3, 2)
        Name = "FrmUserInterface"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Device Market System"
        WindowState = FormWindowState.Maximized
        CType(dgvProductDisplay, ComponentModel.ISupportInitialize).EndInit()
        pnlSearchBar.ResumeLayout(False)
        pnlSearchBar.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        tbControlMain.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvProductDisplay As DataGridView
    Friend WithEvents BtnLogout As Button
    Friend WithEvents lblDeviceMarketSystem As Label
    Friend WithEvents pnlSearchBar As Panel
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategorySearch As ComboBox
    Friend WithEvents txtSearchBar As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents BtnBuyNow As Button
    Friend WithEvents BtnAddToCart As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblShowBalance As Label
    Friend WithEvents lblSetBalance As Label
    Friend WithEvents BtnBalance As Button
    Friend WithEvents txtUserBalance As TextBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents tbControlMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnRemoveAddToCart As Button
    Friend WithEvents BtnRefreshAll As Button
    Friend WithEvents BtnPlaceAnOrder As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCategoryViewCart As ComboBox
    Friend WithEvents txtBoxSearchBarViewCart As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnRemoveAll As Button
End Class
