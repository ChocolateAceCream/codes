Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim qq As String
        Dim ww As Integer
        qq = TextBox1.Text
        ww = qq.Length
        MessageBox.Show(ww)
        MessageBox.Show(qq.Substring(0, ww / 2))
        MessageBox.Show(qq.Substring(ww / 2 + 1))

    End Sub
End Class
