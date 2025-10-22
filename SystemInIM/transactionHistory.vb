

Public Class transactionHistory
    Private Sub transactionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'initialize db upon load
        transactionHistory()

    End Sub

    Public Shared Sub transactionHistory()
        'datagrid view put db here
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'When this button is clicked the datagrid view shows pernding orderrs instead
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class