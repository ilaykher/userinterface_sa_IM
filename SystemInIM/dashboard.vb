Public Class dashboard
    Private Sub circleLeft_Paint(sender As Object, e As PaintEventArgs) Handles circleLeft.Paint

    End Sub

    Private Sub FrmInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakePanelCircle(circleLeft)
        MakePanelCircle(circleLeftBorder)
        MakePanelCircle(circleMiddle)
        MakePanelCircle(circleMiddleBorder)
        MakePanelCircle(circleRight)
        MakePanelCircle(circleRightBorder)
    End Sub

    Private Sub MakePanelCircle(p As Panel)
        Dim gp As New Drawing2D.GraphicsPath()
        gp.AddEllipse(0, 0, p.Width, p.Height)
        p.Region = New Region(gp)
    End Sub

    Private Sub circleLeftBorder_Paint(sender As Object, e As PaintEventArgs) Handles circleLeftBorder.Paint

    End Sub
End Class
