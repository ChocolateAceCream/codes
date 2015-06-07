Public Class Form1

    Private Sub btnStrings_Click(sender As Object,
                                 e As EventArgs) Handles btnStrings.Click
        'Declare variable
        Dim strResults As String

        'Set the string value
        strResults = "Hello World!"

        'Display the results
        MessageBox.Show(strResults, "Strings")
    End Sub

    Private Sub btnConcatenation_Click(sender As Object,
                                       e As EventArgs) Handles btnConcatenation.Click
        'Declare variables
        Dim strResults As String
        Dim strOne As String
        Dim strTwo As String

        'Set the string values
        strOne = "Hello"
        strTwo = " World!"

        'Concatenate the strings
        strResults = strOne & strTwo

        'Display the results
        MessageBox.Show(strResults, "Strings")
    End Sub

    Private Sub btnLength_Click(sender As Object,
                                e As EventArgs) Handles btnLength.Click
        'Declare variable
        Dim strResults As String
        'Get the text from the TextBox
        strResults = txtString.Text
        'Display the length of the string
        MessageBox.Show(strResults.Length.ToString & " characters(s)",
            "Strings")
    End Sub

    Private Sub btnSubStrings_Click(sender As Object,
                e As EventArgs) Handles btnSubStrings.Click
        'Declare variable
        Dim strResults As String

        'Get the text from the TextBox
        strResults = txtString.Text

        'Display the first three characters
        MessageBox.Show(strResults.Substring(0, 3), "Strings")

        'Display the middle three characters
        MessageBox.Show(strResults.Substring(3, 3), "Strings")

        'Display the last three characters
        MessageBox.Show(strResults.Substring(strResults.Length - 3), "Strings")
    End Sub

    Private Sub btnReplace_Click(sender As Object,
                e As EventArgs) Handles btnReplace.Click
        'Declare variables
        Dim strData As String
        Dim strResults As String

        'Get the text from the TextBox
        strData = txtString.Text

        'Replace the string occurence
        strResults = strData.Replace("Hello", "Goodbye")

        'Display the new string
        MessageBox.Show(strResults, "Strings")

    End Sub
End Class
