Public Class Form1

    Private Sub btnScope_Click(sender As Object,
            e As EventArgs) Handles btnScope.Click
        'Call a method
        DisplayBalthazarsName()
    End Sub

    Private Sub DisplaySebastiansName()
        'Declare variable and set value
        Dim strName As String
        strName = "Sebastian Blackwood"

        'Display results
        MessageBox.Show(strName, "Scope Demo")
    End Sub

    Private Sub DisplayBalthazarsName()
        'Declare variable and set value
        Dim strName As String
        strName = "Balthazar Keech"

        'Display results
        MessageBox.Show(strName, "Scope Demo")
    End Sub

End Class
