<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventory
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
        BtnEdit = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        comboCategory = New ComboBox()
        txtSearch = New TextBox()
        PictureBox1 = New PictureBox()
        cmbCategory = New Button()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(189))
        Panel1.Controls.Add(BtnEdit)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(comboCategory)
        Panel1.Controls.Add(txtSearch)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1107, 113)
        Panel1.TabIndex = 1
        ' 
        ' BtnEdit
        ' 
        BtnEdit.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEdit.Location = New Point(837, 44)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(210, 40)
        BtnEdit.TabIndex = 9
        BtnEdit.Text = "Edit Selected Product"
        BtnEdit.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 16F)
        Label3.Location = New Point(506, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(192, 27)
        Label3.TabIndex = 7
        Label3.Text = "Search by Category:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 16F)
        Label2.Location = New Point(293, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 27)
        Label2.TabIndex = 6
        Label2.Text = "Search Product"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(39, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 59)
        Label1.TabIndex = 2
        Label1.Text = "Inventory"
        ' 
        ' comboCategory
        ' 
        comboCategory.DropDownStyle = ComboBoxStyle.DropDownList
        comboCategory.FormattingEnabled = True
        comboCategory.Items.AddRange(New Object() {"Test 1 ", "Test 2", "Test 3", "Test 4", "Test 5"})
        comboCategory.Location = New Point(512, 61)
        comboCategory.Name = "comboCategory"
        comboCategory.Size = New Size(187, 23)
        comboCategory.TabIndex = 4
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(298, 61)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "type to search..."
        txtSearch.Size = New Size(186, 23)
        txtSearch.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ImageLocation = "C:\Users\JGZ\Pictures\cat.jpeg"
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(26, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(171, 138)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Location = New Point(108, 240)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(89, 26)
        cmbCategory.TabIndex = 16
        cmbCategory.Text = "View Details"
        cmbCategory.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Calibri", 10F, FontStyle.Bold)
        Label9.Location = New Point(26, 209)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 17)
        Label9.TabIndex = 15
        Label9.Text = "Product Price"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Calibri", 10F, FontStyle.Bold)
        Label8.Location = New Point(26, 192)
        Label8.Name = "Label8"
        Label8.Size = New Size(111, 17)
        Label8.TabIndex = 14
        Label8.Text = "Product Category"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 10F, FontStyle.Bold)
        Label7.Location = New Point(26, 175)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 17)
        Label7.TabIndex = 13
        Label7.Text = "Product Name"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(3, 119)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1101, 457)
        DataGridView1.TabIndex = 10
        ' 
        ' Inventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(227))
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "Inventory"
        Size = New Size(1107, 579)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents comboCategory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCategory As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents DataGridView1 As DataGridView

End Class
