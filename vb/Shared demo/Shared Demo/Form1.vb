Public Class Form1
    Private arrUserList As New ArrayList()
    Private Sub UpdateDisplay()
        lstUsers.Items.Clear()
        For Each objUser As User In arrUserList
            lstUsers.Items.Add(objUser.Username & ", " & objUser.Password & "(" & User.MinPasswordLength & ")")
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intIndex As Integer = 1 To 100
            Dim objUser As New User
            objUser = User.CreateUser("setadf" & intIndex, "PWasdf14")

            arrUserList.Add(objUser)

        Next
        UpdateDisplay()

    End Sub

    Private Sub nudMinPasswordLength_ValueChanged(sender As Object, e As EventArgs) Handles nudMinPasswordLength.ValueChanged
        User.MinPasswordLength = nudMinPasswordLength.Value
        UpdateDisplay()

    End Sub
End Class
