Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Public Class history
    ' Simple transaction history: one row per order (recent purchases).
    ' Expected controls:
    '  - DataGridView1
    '  - TextBox1 (search)
    '  - DateTimePicker1 (date filter)
    '  - Button1 (Apply / Refresh)

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrders()
    End Sub

    ' Simplified: show product, category, unit price, quantity, date, time, status.
    Public Sub LoadOrders(Optional ByVal searchTerm As String = "", Optional ByVal onDate As Date? = Nothing)
        Try
            Dim connString = "server=localhost;user=root;password=;database=information_management"
            Dim sql As New System.Text.StringBuilder()
            sql.AppendLine("SELECT")
            sql.AppendLine("  o.product_name AS `Name`,")
            sql.AppendLine("  COALESCE(p.category, '') AS `Category`,")
            sql.AppendLine("  o.price AS `UnitPrice`,")
            sql.AppendLine("  o.quantity AS `Quantity`,")
            sql.AppendLine("  DATE(o.order_date) AS `Date`,")
            sql.AppendLine("  TIME(o.order_date) AS `Time`,")
            sql.AppendLine("  COALESCE(o.status, 'Pending') AS `Status`")
            sql.AppendLine("FROM orders o")
            sql.AppendLine("LEFT JOIN products p ON o.product_name = p.product_name")
            sql.AppendLine("WHERE 1=1")

            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                sql.AppendLine("  AND (o.product_name LIKE @search OR p.category LIKE @search)")
            End If

            If onDate.HasValue Then
                sql.AppendLine("  AND DATE(o.order_date) = @orderDate")
            End If

            ' Show newest first (change to ASC if you want oldest-first)
            sql.AppendLine("ORDER BY o.order_date DESC")
            sql.AppendLine("LIMIT 500") ' safety limit

            Using con As New MySqlConnection(connString)
                Using cmd As New MySqlCommand(sql.ToString(), con)
                    If Not String.IsNullOrWhiteSpace(searchTerm) Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchTerm.Trim() & "%")
                    End If
                    If onDate.HasValue Then
                        cmd.Parameters.AddWithValue("@orderDate", onDate.Value.Date)
                    End If

                    Dim da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ' --- Prevent duplicate/empty columns in the grid ---
                    DataGridView1.SuspendLayout()
                    DataGridView1.Columns.Clear()            ' remove designer columns if any
                    DataGridView1.AutoGenerateColumns = True ' allow columns from DataTable
                    DataGridView1.DataSource = dt
                    DataGridView1.ResumeLayout()
                    ' -------------------------------------------------

                    ' Format columns
                    If DataGridView1.Columns.Contains("Amount") Then
                        DataGridView1.Columns("Amount").DefaultCellStyle.Format = "C2"
                        DataGridView1.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    End If
                    If DataGridView1.Columns.Contains("Date") Then
                        DataGridView1.Columns("Date").DefaultCellStyle.Format = "d"
                        DataGridView1.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End If
                    If DataGridView1.Columns.Contains("Time") Then
                        DataGridView1.Columns("Time").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End If

                    DataGridView1.ReadOnly = True
                    DataGridView1.AllowUserToAddRows = False
                    DataGridView1.RowHeadersVisible = False
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                    ' friendly fallback
                    If dt.Rows.Count = 0 Then
                        DataGridView1.Columns.Clear()
                        DataGridView1.Columns.Add("Info", "Transactions")
                        DataGridView1.Rows.Add("No recent orders found.")
                        DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load orders: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Apply / Refresh button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim term As String = ""
        If Controls.ContainsKey("TextBox1") Then
            Dim tb = TryCast(Controls("TextBox1"), TextBox)
            If tb IsNot Nothing Then term = tb.Text.Trim()
        End If

        Dim onDate As Date? = Nothing
        If Controls.ContainsKey("DateTimePicker1") Then
            Dim dtp = TryCast(Controls("DateTimePicker1"), DateTimePicker)
            If dtp IsNot Nothing Then onDate = dtp.Value.Date
        End If

        LoadOrders(term, onDate)
    End Sub
End Class
