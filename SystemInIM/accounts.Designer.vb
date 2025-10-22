<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accounts
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
        linkAccounts = New LinkLabel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(189))
        Panel1.Controls.Add(linkAccounts)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1113, 113)
        Panel1.TabIndex = 4
        ' 
        ' linkAccounts
        ' 
        linkAccounts.ActiveLinkColor = Color.White
        linkAccounts.AutoSize = True
        linkAccounts.Font = New Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        linkAccounts.LinkBehavior = LinkBehavior.NeverUnderline
        linkAccounts.LinkColor = Color.Black
        linkAccounts.Location = New Point(50, 25)
        linkAccounts.Name = "linkAccounts"
        linkAccounts.Size = New Size(411, 59)
        linkAccounts.TabIndex = 1
        linkAccounts.TabStop = True
        linkAccounts.Text = "Customer Accounts"
        ' 
        ' accounts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(227))
        Controls.Add(Panel1)
        Name = "accounts"
        Size = New Size(1107, 579)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents linkAccounts As LinkLabel

End Class
