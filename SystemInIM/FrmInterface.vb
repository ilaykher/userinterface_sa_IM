Imports MySql.Data.MySqlClient
Imports System.IO


Public Class FrmInterface


    ' --- Form Level Declarations ---
    Private connString As String = "server=localhost; user id=root; password=; database=information_management"
    Private conn As MySqlConnection ' Initialized later or in constructor
    Private dtProducts As New DataTable
    Private ImageList As New List(Of System.Drawing.Image)
    Private SelectedProductID As Integer = -1 ' To track the product being edited/deleted

    ' Constructor for safety (initializes conn)
    Public Sub New()
        InitializeComponent()
        conn = New MySqlConnection(connString)
    End Sub

    Private Sub LoadUserControl(ctrl As UserControl)
        panelMain.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        panelMain.Controls.Add(ctrl)
    End Sub

    Private Sub btnDB_Click(sender As Object, e As EventArgs) Handles btnDB.Click
        LoadUserControl(New dashboard())
    End Sub

    Private Sub btnInv_Click(sender As Object, e As EventArgs) Handles btnInv.Click
        LoadUserControl(New inventory())
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        LoadUserControl(New orders())
    End Sub

    Private Sub btnHist_Click(sender As Object, e As EventArgs) Handles btnHist.Click
        LoadUserControl(New history())
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        LoadUserControl(New staff())
    End Sub

    Private Sub btnAcc_Click(sender As Object, e As EventArgs) Handles btnAcc.Click
        LoadUserControl(New accounts())
    End Sub

    Private Sub bgPanelTop_Paint(sender As Object, e As PaintEventArgs) Handles bgPanelTop.Paint

    End Sub

    Private Sub FrmInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class