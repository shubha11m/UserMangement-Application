Public Class UserDatabase
    Private Shared users As New Dictionary(Of String, User)

    Public Shared Sub Initialize()
        ' Seed sample data
        users.Add("admin", New User("admin", "admin@example.com", "+1-800-111-1111", "100 Admin Street" & vbCrLf & "New York, NY 10001", DateTime.Now.AddYears(-2)))
        users.Add("john", New User("john", "john.doe@example.com", "+1-800-222-2222", "200 John Avenue" & vbCrLf & "Los Angeles, CA 90001", DateTime.Now.AddMonths(-12)))
        users.Add("jane", New User("jane", "jane.smith@example.com", "+1-800-333-3333", "300 Jane Road" & vbCrLf & "Chicago, IL 60601", DateTime.Now.AddMonths(-6)))
    End Sub

    Public Shared Function AuthenticateUser(username As String, password As String) As Boolean
        ' For demo purposes, check if username exists
        ' In a real application, verify password hash
        Return users.ContainsKey(username) AndAlso password.Length >= 3
    End Function

    Public Shared Function GetUser(username As String) As User
        If users.ContainsKey(username) Then
            Return users(username)
        End If
        Return Nothing
    End Function

    Public Shared Sub UpdateUser(user As User)
        If users.ContainsKey(user.Username) Then
            users(user.Username) = user
        End If
    End Sub
End Class

