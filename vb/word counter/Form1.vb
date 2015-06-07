Public Class Form1

    Private Function CountCharacters(ByVal text As String) As Integer
        Return Text.Length
    End Function

    Private Function CountWords(text As String) As Integer
        If text.Trim.Length = 0 Then Return 0
        Dim strWords() As String = text.Split(" "c)
        Return strWords.Length

    End Function

    Private Sub UpdateDisplay()
        If radCountWords.Checked Then
            lblResults.Text = CountWords(txtWord.Text) & " Words"
        Else
            lblResults.Text = CountCharacters(txtWord.Text) & "characters"
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lable1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtWord_TextChanged(sender As Object, e As EventArgs) Handles txtWord.TextChanged
        UpdateDisplay()


    End Sub

    Private Sub radCountWords_CheckedChanged(sender As Object, e As EventArgs) Handles radCountWords.CheckedChanged
        UpdateDisplay()
    End Sub

    Private Sub radCountChars_CheckedChanged(sender As Object, e As EventArgs) Handles radCountChars.CheckedChanged
        UpdateDisplay()
    End Sub
End Class
