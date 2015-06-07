Public Class Form1

    Private Sub lstData_SelectedIndexChanged(sender As Object,
                        e As EventArgs) Handles lstData.SelectedIndexChanged
        'Declare variables
        Dim strName As String
        Dim strFavoriteColor As String

        'Get the selected name
        strName = lstData.Items(lstData.SelectedIndex).ToString

        'Use a Select Case statement to get the favorite color
        'of the selected name
        Select Case strName.ToLower
            Case "bryan"
                strFavoriteColor = "Madras Yellow"

            Case "ashley"
                strFavoriteColor = "Sea Blue"

            Case "jennifer"
                strFavoriteColor = "Morning Mist"

            Case "eddie"
                strFavoriteColor = "Passionate Purple"

            Case "katelyn"
                strFavoriteColor = "Red"
        End Select


        'Display the favorite color of the selected name
        MessageBox.Show(strName & "'s favorite color is " &
            strFavoriteColor, "Select Demo")

        'Use a Select Case statement to display a person's gender
        Select Case strName.ToLower
            Case "bryan", "eddie", "ashley"
                MessageBox.Show("This person's gender is male.", "Select Demo")
            Case "jennifer", "katelyn"
                MessageBox.Show("This person's gender is female.", "Select Demo")
            Case Else
                MessageBox.Show("I don't know this person's gender.",
                    "Select Demo")
        End Select

    End Sub
End Class
