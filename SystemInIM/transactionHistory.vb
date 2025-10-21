Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Public Class transactionHistory

    Private Sub transactionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' initialize db upon load
        LoadTransactionHistory()
    End Sub

    Public Sub LoadTransactionHistory(Optional ByVal statusFilter As String = "")
        ' Populates DataGridView1 with the current user's orders.
        ' Shows Image, Product, Price, Qty, Date, Status (status optional).
        Try
            Dim constring As String = "server=localhost;user=root;password=;database=information_management"
            Using con As New MySqlConnection(constring)
                con.Open()

                ' determine if status column exists
                Dim hasStatus As Boolean = False
                Using statusCmd As New MySqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA=@schema AND TABLE_NAME='orders' AND COLUMN_NAME='status'", con)
                    statusCmd.Parameters.AddWithValue("@schema", "information_management")
                    hasStatus = Convert.ToInt32(statusCmd.ExecuteScalar()) > 0
                End Using

                ' join products to get image_path (left join in case product removed)
                Dim sql As String = "SELECT o.product_name AS `Product`, o.price AS `Price`, o.quantity AS `Qty`, o.order_date AS `Date`, " &
                                    "o.status AS `Status`, p.image_path AS `image_path` " &
                                    "FROM orders o LEFT JOIN products p ON o.product_name = p.product_name " &
                                    "WHERE o.user_id = @uid"
                If hasStatus AndAlso Not String.IsNullOrWhiteSpace(statusFilter) Then
                    sql &= " AND o.status = @status"
                End If
                sql &= " ORDER BY o.order_date DESC"

                Using da As New MySqlDataAdapter(sql, con)
                    da.SelectCommand.Parameters.AddWithValue("@uid", Globals.LoggedInUserId)
                    If hasStatus AndAlso Not String.IsNullOrWhiteSpace(statusFilter) Then
                        da.SelectCommand.Parameters.AddWithValue("@status", statusFilter)
                    End If

                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ' Add an Image column to hold loaded images
                    If Not dt.Columns.Contains("ImageData") Then
                        dt.Columns.Add("ImageData", GetType(Image))
                    End If

                    ' Load images from image_path into ImageData column (safe check)
                    For Each r As DataRow In dt.Rows
                        Try
                            Dim imgPath As String = If(r.IsNull("image_path"), String.Empty, Convert.ToString(r("image_path")))
                            If Not String.IsNullOrWhiteSpace(imgPath) AndAlso File.Exists(imgPath) Then
                                ' load and clone to avoid locking file
                                Using tmpImg As Image = Image.FromFile(imgPath)
                                    r("ImageData") = New Bitmap(tmpImg)
                                End Using
                            Else
                                r("ImageData") = Nothing
                            End If
                        Catch
                            r("ImageData") = Nothing
                        End Try
                    Next

                    ' Bind the table to grid
                    DataGridView1.DataSource = dt

                    ' Convert ImageData column to image column for proper display and move it to first position
                    If DataGridView1.Columns.Contains("ImageData") Then
                        Dim imgCol As DataGridViewImageColumn = CType(DataGridView1.Columns("ImageData"), DataGridViewImageColumn)
                        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                        imgCol.Width = 100
                        imgCol.HeaderText = "Image"
                        imgCol.DisplayIndex = 0
                    Else
                        ' create image column manually if not auto-created
                        Dim colImg As New DataGridViewImageColumn() With {
                            .Name = "ImageData",
                            .HeaderText = "Image",
                            .ImageLayout = DataGridViewImageCellLayout.Zoom,
                            .Width = 100,
                            .DisplayIndex = 0
                        }
                        DataGridView1.Columns.Insert(0, colImg)
                    End If

                    ' Hide raw image_path column if present
                    If DataGridView1.Columns.Contains("image_path") Then
                        DataGridView1.Columns("image_path").Visible = False
                    End If

                    ' Column formatting
                    If DataGridView1.Columns.Contains("Price") Then
                        DataGridView1.Columns("Price").DefaultCellStyle.Format = "C2"
                        DataGridView1.Columns("Price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    End If
                    If DataGridView1.Columns.Contains("Date") Then
                        DataGridView1.Columns("Date").DefaultCellStyle.Format = "g"
                        DataGridView1.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End If

                    DataGridView1.ReadOnly = True
                    DataGridView1.AllowUserToAddRows = False
                    DataGridView1.RowHeadersVisible = False
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load transaction history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' radio button handlers to filter by status (adjust status strings to match your DB values)
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then LoadTransactionHistory("Out for Delivery")
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then LoadTransactionHistory("Canceled")
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then LoadTransactionHistory("Delivered")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Apply button: reset filters and reload
        LoadTransactionHistory()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub
End Class