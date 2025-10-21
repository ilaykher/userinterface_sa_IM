<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductDetails
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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblSold = New Label()
        lblLocation = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._3_Tasten_Maus_Microsoft
        PictureBox1.Location = New Point(23, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(228, 227)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SlateGray
        Button1.FlatAppearance.BorderSize = 0
        Button1.ForeColor = SystemColors.Info
        Button1.Location = New Point(624, 536)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 35)
        Button1.TabIndex = 1
        Button1.Text = "BUY NOW"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SlateGray
        Button2.FlatAppearance.BorderSize = 0
        Button2.ForeColor = SystemColors.Info
        Button2.Location = New Point(783, 536)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 35)
        Button2.TabIndex = 2
        Button2.Text = "ADD TO CART"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(80), CByte(105), CByte(129))
        Label1.Location = New Point(338, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 32)
        Label1.TabIndex = 3
        Label1.Text = "Product Title"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.IndianRed
        Label2.Location = New Point(389, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 21)
        Label2.TabIndex = 4
        Label2.Text = "PHP 20000"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSlateGray
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(219, 224)
        Panel1.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 21)
        Label3.TabIndex = 6
        Label3.Text = "Lonbg Description"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(338, 175)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(600, 319)
        Panel2.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(23, 286)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 20)
        Label4.TabIndex = 8
        Label4.Text = "Category: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(23, 320)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 20)
        Label5.TabIndex = 9
        Label5.Text = "Stock:"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(23, 423)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 20)
        Label6.TabIndex = 10
        Label6.Text = "Date Listed For Sale:"
        ' 
        ' lblSold
        ' 
        lblSold.AutoSize = True
        lblSold.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSold.Location = New Point(23, 354)
        lblSold.Name = "lblSold"
        lblSold.Size = New Size(42, 20)
        lblSold.TabIndex = 11
        lblSold.Text = "Sold:"
        lblSold.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblLocation
        ' 
        lblLocation.AutoSize = True
        lblLocation.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLocation.Location = New Point(23, 387)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(69, 20)
        lblLocation.TabIndex = 12
        lblLocation.Text = "Location:"
        lblLocation.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ProductDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(969, 603)
        Controls.Add(lblLocation)
        Controls.Add(lblSold)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "ProductDetails"
        Text = "ProductDetails"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSold As Label
    Friend WithEvents lblLocation As Label
End Class
