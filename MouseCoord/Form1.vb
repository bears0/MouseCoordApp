Public Class Form1
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Label1.Text = "X." & e.X & vbCrLf & "Y." & e.Y
    End Sub
End Class
