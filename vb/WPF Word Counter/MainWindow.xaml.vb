Class MainWindow 
    Private Function CountCharacters(text As String) As Integer
        Return text.Length

    End Function
    Private Sub txtWords_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtWords.TextChanged
        Dim intChars As Integer = CountCharacters(txtWords.Text)
        lblResults.Content = intChars & "characters"
    End Sub
End Class
