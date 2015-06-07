Public Class User
    Public Shared Function CreateUser(userName As String, password As String) As User
        Dim objUser As New User()
        objUser.Username = userName
        objUser.Password = password
        Return objUser
    End Function


    Public Username As String
    Public Shared MinPasswordLength As Integer = 6
    Private strPassword As String
    Public Property Password() As String
        Get
            Return strPassword
        End Get
        Set(value As String)
            If value.Length >= MinPasswordLength Then
                strPassword = value
            End If
        End Set
    End Property
End Class
