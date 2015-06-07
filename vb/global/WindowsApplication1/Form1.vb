Public Class Form1

    Private Const aa As String = "C:\Users\Di\Desktop\t.txt"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        MessageBox.Show("1:" & aa, "demo")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        MessageBox.Show("2:" & aa, "demo")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        MessageBox.Show("3:" & aa, "demo")
    End Sub
End Class
