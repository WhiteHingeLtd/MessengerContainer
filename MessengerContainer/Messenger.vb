Imports WHLClasses
Public Class Messenger

    Private Sub NotificationCheck_Tick(sender As Object, e As EventArgs) Handles NotificationCheck.Tick
        If EmployeeID > 0 Then
            GetNotifications(EmployeeID)
        End If
    End Sub
    Public Sub GetNotifications(EmployeeID)
        'Here we check for the Notification Status. For each thread that is new we send a new notification. 0 is not notified, 1 is NotificationSent, 2 is NotificationRead
        'We send a notification on initial start up if the notification is sent but not read.
        Dim Notifications As New ArrayList
        Notifications = WHLClasses.MySQL.SelectData("SELECT * FROM whldata.messenger_threads WHERE (participantid = '" + EmployeeID.ToString + "') ORDER BY idmessenger_threads DESC ;")
        For Each Thread As ArrayList In Notifications
            If Convert.ToInt32(Thread(3)) = 0 Then
                SendNotification(Thread(1), Convert.ToInt32(EmployeeID))
                Dim Response = WHLClasses.MySQL.insertUpdate("UPDATE whldata.messenger_threads set Notified='1' WHERE threadid ='" + Thread(1).ToString + "';")
                MsgBox(Response)
            End If
        Next


    End Sub
    Private Sub Awesomium_Windows_Forms_WebControl2_DocumentReady(sender As Object, e As Awesomium.Core.UrlEventArgs) Handles WebControl2.DocumentReady

        EmployeeID = WebControl2.ExecuteJavascriptWithResult("employee;").ToString
        ActiveThread = WebControl2.ExecuteJavascriptWithResult("threadid;").ToString
        Timer1.Enabled = True
        NotificationCheck.Enabled = True
    End Sub
    Public Sub SendNotification(ThreadID, EmployeeID)
        Dim ThreadUsers As New ArrayList
        Dim EmpColl As New EmployeeCollection
        Dim ThreadString As String
        Dim Message As String = "You have a new Message"
        ThreadString = "Users in this thread:"
        ThreadUsers = WHLClasses.MySQL.SelectData("SELECT participantid FROM whldata.messenger_threads WHERE (ThreadID=" + ThreadID.ToString + ") ORDER BY idmessenger_threads DESC ;")
        For Each ThreadUser As ArrayList In ThreadUsers
            ThreadString = ThreadString + EmpColl.FindEmployeeByID(Convert.ToInt32(ThreadUser(0))).FullName
        Next
        Dim Notification As New NotificationBase
        Notification.ThreadUsers.Text = ThreadString
        Notification.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        EmployeeID = WebControl2.ExecuteJavascriptWithResult("employee;").ToString
        ActiveThread = WebControl2.ExecuteJavascriptWithResult("threadid;").ToString

    End Sub
End Class
