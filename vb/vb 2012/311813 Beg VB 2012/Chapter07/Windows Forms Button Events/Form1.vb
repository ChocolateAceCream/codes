Public Class Form1

    Private Sub btnSayHello_Click(sender As Object,
                e As EventArgs) Handles btnSayHello.Click
        MessageBox.Show("Hello World!", Me.Text)
    End Sub

    Private Sub btnSayHello_MouseEnter(sender As Object,
                e As EventArgs) Handles btnSayHello.MouseEnter
        'Change the Button text
        btnSayHello.Text = "The mouse is here!"

    End Sub

    Private Sub btnSayHello_MouseLeave(sender As Object,
                e As EventArgs) Handles btnSayHello.MouseLeave
        'Change the Button text
        btnSayHello.Text = "The mouse has gone!"

    End Sub
End Class
