Imports MySql.Data.MySqlClient

Public Class Inventory

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventoryData()
    End Sub

    Private Sub LoadInventoryData()
        Try
            Dim connStr As String = "server=localhost;user=root;password=;database=information_management"
            Using con As New MySqlConnection(connStr)
                con.Open()

                Dim query As String = "
                    SELECT 
                        p.product_name AS 'Product Name',
                        p.price AS 'Price (PHP)',
                        p.stock AS 'Stock',
                        IFNULL(o.user_id, '---') AS 'Bought By (User ID)',
                        IF(o.status IS NULL, 'Available', o.status) AS 'Status',
                        IFNULL(o.order_date, '---') AS 'Date Ordered',
                        p.description AS 'Description'
                    FROM products p
                    LEFT JOIN orders o ON o.product_name = p.product_name
                    ORDER BY p.product_name ASC;"

                Using cmd As New MySqlCommand(query, con)
                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using

                ' 🟡 Optional: Format columns for readability
                With DataGridView1
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    .RowTemplate.Height = 40
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                End With

            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading inventory: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 🔍 Search by product name
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dv As DataView = CType(DataGridView1.DataSource, DataTable).DefaultView
        dv.RowFilter = String.Format("[Product Name] LIKE '%{0}%'", txtSearch.Text)
    End Sub


    Private Sub comboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCategory.SelectedIndexChanged
        Dim dv As DataView = CType(DataGridView1.DataSource, DataTable).DefaultView
        dv.RowFilter = $"[Description] LIKE '%{ DirectCast(comboCategory.SelectedItem.ToString(), Object) }%'"
    End Sub
End Class
