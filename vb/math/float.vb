Public Class Form1

    Private Sub btnFloatMath_Click(sender As Object, e As EventArgs) Handles btnFloatMath.Click
        Dim dblNumber As Double
        dblNumber = 45.23
        dblNumber *= 4.333
        MessageBox.Show("test" & dblNumber.ToString, "FK")
        dblNumber = 12
        dblNumber /= 7
        MessageBox.Show("division test" & dblNumber.ToString)
    End Sub
End Class
