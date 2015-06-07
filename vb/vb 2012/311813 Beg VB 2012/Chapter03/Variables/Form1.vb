Public Class Form1

    Private Sub btnAdd_Click(sender As Object,
                             e As EventArgs) Handles btnAdd.Click
        Dim intNumber As Integer
        intNumber = 27
        intNumber = intNumber + 1
        MessageBox.Show("Value of intNumber + 1 = " & intNumber.ToString,
           "Variables")
    End Sub
End Class
