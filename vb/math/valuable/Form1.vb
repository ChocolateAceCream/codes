Public Class Form1
    ''' <summary>
    ''' asfd
    ''' asdf
    ''' adf
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intNumber As Integer
        intNumber = 27
        intNumber = intNumber / 7
        MessageBox.Show("value of intNumber+1 = " & intNumber.ToString, _
                         "variables")

    End Sub
End Class
