Public Class NotificationBase
    Dim StartPos As Integer = 12
    Private Sub NotificationBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Drawing.Point(My.Computer.Screen.Bounds.Width, StartPos)
    End Sub

End Class
