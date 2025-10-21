<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modeOfPayment
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
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(25, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(262, 33)
        Label2.TabIndex = 1
        Label2.Text = "Choose Payment Method:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.LightSlateGray
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.ForeColor = SystemColors.Info
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(310, 26)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(180, 29)
        ComboBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightSlateGray
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(624, 364)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 34)
        Button1.TabIndex = 3
        Button1.Text = "Place an Order"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(14, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 21)
        Label3.TabIndex = 4
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(334, 368)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 21)
        Label4.TabIndex = 5
        Label4.Text = "Total Payment: P0"
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(43, 109)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(673, 238)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(57, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 28)
        Label1.TabIndex = 7
        Label1.Text = ChrW(55357) & ChrW(57042) & "  Products to Order:"
        ' 
        ' modeOfPayment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(750, 410)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Name = "modeOfPayment"
        Text = "modeOfPayment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
