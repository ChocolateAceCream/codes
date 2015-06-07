Public Class Form1

    Private Sub btnOrCheck_Click(sender As Object,
            e As EventArgs) Handles btnOrCheck.Click
        'Declare variables
        Dim strName1 As String, strName2 As String

        'Get the names
        strName1 = txtName1.Text
        strName2 = txtName2.Text

        'Is one of the names Wendy?
        If strName1 = "Wendy" Or strName2 = "Wendy" Then
            MessageBox.Show("One of the names is Wendy.",
                "And Or Demo")
        Else
            MessageBox.Show("Neither of the names is Wendy.",
                "And Or Demo")
        End If
    End Sub

    Private Sub btnAndCheck_Click(sender As Object,
                e As EventArgs) Handles btnAndCheck.Click
        'Declare variables
        Dim strName1 As String, strName2 As String

        'Get the names
        strName1 = txtName1.Text
        strName2 = txtName2.Text

        'Are both names Wendy?
        If strName1 = "Wendy" And strName2 = "Wendy" Then
            MessageBox.Show("Both names are Wendy.",
                "And Or Demo")
        Else
            MessageBox.Show("One of the names is not Wendy.",
                "And Or Demo")
        End If

    End Sub

    Private Sub btnStringCompare_Click(sender As Object,
                        e As EventArgs) Handles btnStringCompare.Click
        'Declare variable
        Dim strName As String

        'Get the name
        strName = txtName3.Text

        'Compare the name
        If String.Compare(strName, "BRYAN", True) = 0 Then
            MessageBox.Show("Hello, Bryan!", "And Or Demo")
        End If

    End Sub
End Class
