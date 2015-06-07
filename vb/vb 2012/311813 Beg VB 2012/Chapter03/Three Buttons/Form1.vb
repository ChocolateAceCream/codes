Public Class Form1

    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        'Declare variable
        Dim dblArea As Double

        'Calculate the area of a circle with a radius of 100
        dblArea = CalculateAreaFromRadius(100)

        'Display the results
        MessageBox.Show(dblArea.ToString, "Area of 100")
    End Sub

    Private Sub Button2_Click(sender As Object,
            e As EventArgs) Handles Button2.Click
        'Call your method
        SayHello()
    End Sub

    Private Sub Button3_Click(sender As Object,
            e As EventArgs) Handles Button3.Click
        'Call your method
        SayHello()
    End Sub

    Private Sub SayHello()
        'Display a message box
        MessageBox.Show("Hello World!", "Three Buttons")
    End Sub

    'CalculateAreaFromRadius–find the area of a circle
    Private Function CalculateAreaFromRadius(ByVal radius As Double) As Double
        'Declare variables
        Dim dblRadiusSquared As Double
        Dim dblResult As Double

        'Square the radius
        dblRadiusSquared = radius * radius

        'Multiply it by pi
        dblResult = dblRadiusSquared * Math.PI

        'Return the result
        Return dblResult
    End Function

End Class
