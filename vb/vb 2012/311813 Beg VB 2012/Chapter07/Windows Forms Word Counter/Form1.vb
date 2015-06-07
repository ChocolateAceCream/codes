Public Class Form1

    ''' <summary>
    ''' Count the characters in a block of text
    ''' </summary>
    ''' <param name="text">The string containing the text to count
    ''' characters in</param>
    ''' <returns>The number of characters in the string</returns>
    ''' <remarks></remarks>  
    Private Function CountCharacters(ByVal text As String) As Integer
        Return text.Length
    End Function

    Private Sub txtWords_TextChanged(sender As Object,
                e As EventArgs) Handles txtWords.TextChanged

        'Something changed so display the results
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
        'Do we want to count words?
        If radCountWords.Checked Then
            'Update the results with words
            lblResults.Text = CountWords(txtWords.Text) & " words"
        Else
            'Update the results with characters
            lblResults.Text = CountCharacters(txtWords.Text) & " characters"
        End If
    End Sub

    Private Sub radCountWords_CheckedChanged(sender As Object,
                e As EventArgs) Handles radCountWords.CheckedChanged
        'Something changed so display the results
        UpdateDisplay()

    End Sub

    Private Sub radCountChars_CheckedChanged(sender As Object,
                e As EventArgs) Handles radCountChars.CheckedChanged
        'Something changed so display the results
        UpdateDisplay()
    End Sub
End Class
