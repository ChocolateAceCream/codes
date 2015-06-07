Public Class Form1
    Private Enum DayAction As Integer
        asleep = 0
        Work = 1
        Eat = 2
        run = 3
    End Enum

    Private current As DayAction

    Private Property Hour() As Integer
        Get
            Return dtp.Value.Hour

        End Get

        Set(value As Integer)
            dtp.Value = New Date(Now.Year, Now.Month, Now.Day, value, 0, 0)
            lbl.Text = "At" & value & "::00,Richard is "

        End Set
    End Property

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        Me.Hour = dtp.Value.Hour
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hour = Now.Hour
    End Sub
End Class
