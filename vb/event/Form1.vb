Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSayHello_Click(sender As Object, e As EventArgs) Handles btnSayHello.Click
        MessageBox.Show("hello world!", Me.Text)
    End Sub

    Private Sub btnSayHello_MouseEnter(sender As Object, e As EventArgs) Handles btnSayHello.MouseEnter
        btnSayHello.Text = " The mouse is here!"
    End Sub

    Private Sub btnSayHello_MouseLeave(sender As Object, e As EventArgs) Handles btnSayHello.MouseLeave
        btnSayHello.Text = " The mouse has gone!"
    End Sub
End Class
