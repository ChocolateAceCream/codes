Public Class Form1

    

    Private Sub Button1_Click(sender As Object, e As EventArgs)
 

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged
        Dim strName As String
        Dim strBest As String
        strName = lstData.Items(lstData.SelectedIndex).ToString
        Select Case strName
            Case "aaaa"
                strBest = "aaaa"
            Case "bbbb"
                strBest = "bbbb"
            Case "aaaa"
                strBest = "cccc"
        End Select
        MessageBox.Show(strBest)

    End Sub
End Class
