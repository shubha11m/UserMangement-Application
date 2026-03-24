Public Class User
    Public Property Username As String
    Public Property Email As String
    Public Property Phone As String
    Public Property Address As String
    Public Property JoinDate As DateTime

    Public Sub New()
    End Sub

    Public Sub New(username As String, email As String, phone As String, address As String, joinDate As DateTime)
        Me.Username = username
        Me.Email = email
        Me.Phone = phone
        Me.Address = address
        Me.JoinDate = joinDate
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("Username: {0}, Email: {1}, Phone: {2}", Username, Email, Phone)
    End Function
End Class

