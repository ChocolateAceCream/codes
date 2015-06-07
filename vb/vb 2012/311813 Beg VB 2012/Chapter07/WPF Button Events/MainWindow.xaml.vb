Class MainWindow 

    Private Sub btnSayHello_Click(sender As Object,
                e As RoutedEventArgs) Handles btnSayHello.Click
        MessageBox.Show("Hello World!", Me.Title)
    End Sub

    Private Sub btnSayHello_MouseEnter(sender As Object,
                e As MouseEventArgs) Handles btnSayHello.MouseEnter
        'Change the Button text
        btnSayHello.Content = "The mouse is here!"

    End Sub

    Private Sub btnSayHello_MouseLeave(sender As Object,
                e As MouseEventArgs) Handles btnSayHello.MouseLeave
        'Change the Button text
        btnSayHello.Content = "The mouse has gone!"

    End Sub
End Class
