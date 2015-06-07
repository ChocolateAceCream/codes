Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim ray(15) As Integer
        For i As Integer = ray.GetUpperBound(0) To 0 Step -1
            ray(ray.GetUpperBound(0) - i) = i

        Next
        Array.Reverse(ray)
        Dim rr() As String = {"A", "B", "C"}
        MessageBox.Show(rr.GetUpperBound(0))
        zz(ray)
    End Sub

    Private Sub zz(ByVal kk() As Integer)
        Dim i As Integer
        For Each i In kk
            lstBox.Items.Add(i)

        Next

    End Sub
End Class
