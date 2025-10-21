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

    Private Sub panelMain_Paint(sender As Object, e As PaintEventArgs) Handles panelMain.Paint

    End Sub

    Private Sub LoadUserControl(ctrl As UserControl)
        panelMain.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        panelMain.Controls.Add(ctrl)
    End Sub

    Private Sub linkDashboard_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkDashboard.LinkClicked
        LoadUserControl(New dashboard)
    End Sub

    Private Sub linkInventory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkInventory.LinkClicked
        LoadUserControl(New inventory)
    End Sub

    Private Sub linkOrders_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkOrders.LinkClicked
        LoadUserControl(New orders)
    End Sub

    Private Sub linkHistory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkHistory.LinkClicked
        LoadUserControl(New history)
    End Sub

    Private Sub linkStaff_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkStaff.LinkClicked

    End Sub

    Private Sub linkCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkCustomer.LinkClicked

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles displayMsg.LinkClicked

    End Sub
End Class