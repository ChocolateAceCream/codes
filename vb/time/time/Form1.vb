Public Class Form1
    Private Enum dayaction As Integer
        sleep = 0
        eat = 1
        run = 2
        work = 3
        game = 4
    End Enum

    Private Property hour() As Integer

        Get
            Return dtp.Value.Hour

        End Get


        Set(value As Integer)
            dtp.Value = New Date(Now.Year, Now.Month, Now.Day, value, 0, 0)
            Dim i As String
            If value >= 6 And value < 7 Then
                i = dayaction.sleep
            ElseIf value >= 0 And value < 6 Then
                i = dayaction.eat
            ElseIf value >= 7 And value < 10 Then
                i = dayaction.work
            ElseIf value >= 10 And value < 17 Then
                i = dayaction.run
            Else
                i = dayaction.game
            End If


            lbl.Text = "At" & value & ":00,richard is " & i.ToString()
        End Set
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.hour = Now.Hour
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        Me.hour = dtp.Value.Hour
    End Sub
End Class
