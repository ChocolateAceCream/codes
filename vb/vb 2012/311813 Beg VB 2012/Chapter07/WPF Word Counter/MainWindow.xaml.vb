Class MainWindow 
    ''' <summary>
    ''' Count the characters in a block of text
    ''' </summary>
    ''' <param name="text">The string containing the text to count</param>
    ''' <returns>The number of characters in the string</returns>
    ''' <remarks></remarks>
    Private Function CountCharacters(ByVal text As String) As Integer
        Return text.Length
    End Function


    Private Sub txtWords_TextChanged(sender As Object,
            e As TextChangedEventArgs) Handles txtWords.TextChanged
        'Something changed to display the results
        UpdateDisplay()

    End Sub

    ''' <summary>
    ''' Count the number of words in a block of text
    ''' </summary>
    ''' <param name="text">The string containing the text to count</param>
    ''' <returns>The number of words in the string</returns>
    ''' <remarks></remarks>
    Private Function CountWords(ByVal text As String) As Integer
        'Is the text empty?
        If text.Trim.Length = 0 Then Return 0

        'Split the words
        Dim strWords() As String = text.Split(" "c)

        'Return the number of words
        Return strWords.Length
    End Function

    Private Sub UpdateDisplay()
        'If the window has not completed initialization then exit
        'this procedure as the radCountWords radio button has not
        'been created yet
        If Not Me.IsInitialized Then Exit Sub

        'Do we want to count words?
        If radCountWords.IsChecked Then
            'Update the results with words
            lblResults.Content = CountWords(txtWords.Text) & " words"
        Else
            'Update the results with characters
            lblResults.Content = CountCharacters(txtWords.Text) & " characters"
        End If
    End Sub


    Private Sub radCountWords_Checked(sender As Object,
            e As RoutedEventArgs) Handles radCountWords.Checked
        'Update the display
        UpdateDisplay()

    End Sub

    Private Sub radCountChars_Checked(sender As Object,
            e As RoutedEventArgs) Handles radCountChars.Checked
        'Update the display
        UpdateDisplay()

    End Sub
End Class
