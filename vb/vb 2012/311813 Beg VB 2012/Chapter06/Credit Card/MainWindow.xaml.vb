Imports System.Text

Class MainWindow
    'Private variables
    Private strStates() As String = {"AL", "AK", "AZ", "AR", "CA", "CO"}

    Private Sub MainWindow_Loaded(ByVal sender As Object, _
        ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded

        'Bind the combo boxes to the strStates array
        cboState.ItemsSource = strStates

    End Sub

    Private Sub btnApplyNow_Click(ByVal sender As Object,
        ByVal e As System.Windows.RoutedEventArgs) Handles btnApplyNow.Click

        'Declare and instantiate a StringBuilder object
        Dim objStringBuilder As New StringBuilder

        'Add the question
        objStringBuilder.AppendLine("Is your personal " &
            "information listed here correct?")
        objStringBuilder.AppendLine(String.Empty)

        'Add the personal information
        objStringBuilder.AppendLine(txtFirstName.Text & " " &
            txtLastName.Text)
        objStringBuilder.AppendLine(txtAddress.Text)
        objStringBuilder.AppendLine(txtCity.Text & ", " &
            cboState.SelectedItem.ToString() & " " & txtPostalCode.Text)

        'Display a message box to verify the information
        If MessageBox.Show(objStringBuilder.ToString,
            My.Application.Info.Title, MessageBoxButton.YesNo,
            MessageBoxImage.Question) = MessageBoxResult.Yes Then
            'Do some processing here
        Else
            'Return to the window and let the user correct
            'their information
        End If
    End Sub

End Class

