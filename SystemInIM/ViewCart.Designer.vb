<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCart
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
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Panel2 = New Panel()
        Button3 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(185), CByte(197), CByte(210))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.AntiqueWhite
        DataGridView1.Location = New Point(38, 52)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(933, 505)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSlateGray
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1006, 50)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FloralWhite
        Label1.Location = New Point(829, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 23)
        Label1.TabIndex = 2
        Label1.Text = "MY CART"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.LightSlateGray
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.ForeColor = SystemColors.Window
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(83, 10)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(205, 29)
        ComboBox1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.LightSlateGray
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.Window
        TextBox1.Location = New Point(294, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(364, 29)
        TextBox1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightSlateGray
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(3, 556)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1006, 73)
        Panel2.TabIndex = 2
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FloralWhite
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(20, 21)
        Button3.Name = "Button3"
        Button3.Size = New Size(122, 29)
        Button3.TabIndex = 5
        Button3.Text = "Select All"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.MistyRose
        Label3.Location = New Point(551, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 25)
        Label3.TabIndex = 4
        Label3.Text = "P0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Linen
        Label2.Location = New Point(442, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 21)
        Label2.TabIndex = 3
        Label2.Text = "Total (0 Item):"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FloralWhite
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(148, 21)
        Button2.Name = "Button2"
        Button2.Size = New Size(122, 29)
        Button2.TabIndex = 2
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.OldLace
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(845, 16)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 39)
        Button1.TabIndex = 0
        Button1.Text = "Checkout"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ViewCart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FloralWhite
        ClientSize = New Size(1012, 630)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "ViewCart"
        Text = "ViewCart"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
End Class
