<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class history
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
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        boxSearch = New TextBox()
        Label2 = New Label()
        linkHistory = New LinkLabel()
        DataGridView1 = New DataGridView()
        nm = New DataGridViewTextBoxColumn()
        ct = New DataGridViewTextBoxColumn()
        amnt = New DataGridViewTextBoxColumn()
        dt = New DataGridViewTextBoxColumn()
        tm = New DataGridViewTextBoxColumn()
        st = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button2 = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(189))
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(boxSearch)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(linkHistory)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1107, 113)
        Panel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 16F)
        Label1.Location = New Point(841, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 27)
        Label1.TabIndex = 9
        Label1.Text = "Search by Date"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(874, 55)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(82, 22)
        DateTimePicker1.TabIndex = 0
        ' 
        ' boxSearch
        ' 
        boxSearch.Location = New Point(499, 55)
        boxSearch.Name = "boxSearch"
        boxSearch.PlaceholderText = "type to search..."
        boxSearch.Size = New Size(186, 23)
        boxSearch.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 16F)
        Label2.Location = New Point(493, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 27)
        Label2.TabIndex = 7
        Label2.Text = "Search User"
        ' 
        ' linkHistory
        ' 
        linkHistory.ActiveLinkColor = Color.White
        linkHistory.AutoSize = True
        linkHistory.Font = New Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        linkHistory.LinkBehavior = LinkBehavior.NeverUnderline
        linkHistory.LinkColor = Color.Black
        linkHistory.Location = New Point(50, 25)
        linkHistory.Name = "linkHistory"
        linkHistory.Size = New Size(410, 59)
        linkHistory.TabIndex = 1
        linkHistory.TabStop = True
        linkHistory.Text = "Transaction History"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(255), CByte(241), CByte(227))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {nm, ct, amnt, dt, tm, st})
        DataGridView1.Location = New Point(30, 115)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1077, 469)
        DataGridView1.TabIndex = 3
        ' 
        ' nm
        ' 
        nm.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        nm.HeaderText = "Name"
        nm.Name = "nm"
        ' 
        ' ct
        ' 
        ct.HeaderText = "Category"
        ct.Name = "ct"
        ' 
        ' amnt
        ' 
        amnt.HeaderText = "Amount"
        amnt.Name = "amnt"
        ' 
        ' dt
        ' 
        dt.HeaderText = "Date"
        dt.Name = "dt"
        ' 
        ' tm
        ' 
        tm.HeaderText = "Time"
        tm.Name = "tm"
        ' 
        ' st
        ' 
        st.HeaderText = "Status"
        st.Name = "st"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(716, 55)
        Button1.Name = "Button1"
        Button1.Size = New Size(73, 24)
        Button1.TabIndex = 10
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(795, 55)
        Button2.Name = "Button2"
        Button2.Size = New Size(73, 24)
        Button2.TabIndex = 11
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' history
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(227))
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "history"
        Size = New Size(1107, 579)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents linkHistory As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nm As DataGridViewTextBoxColumn
    Friend WithEvents ct As DataGridViewTextBoxColumn
    Friend WithEvents amnt As DataGridViewTextBoxColumn
    Friend WithEvents dt As DataGridViewTextBoxColumn
    Friend WithEvents tm As DataGridViewTextBoxColumn
    Friend WithEvents st As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents boxSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button

End Class
