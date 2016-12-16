Imports System.Windows.Forms
Public Class NotificationBase
    Dim StartPos As Integer = 12
    Private Sub NotificationBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Drawing.Point(My.Computer.Screen.Bounds.Width, StartPos)
    End Sub

    Private Sub CloseNotification_Click(sender As Object, e As EventArgs) Handles CloseNotification.Click
        Me.Close()

    End Sub
End Class
