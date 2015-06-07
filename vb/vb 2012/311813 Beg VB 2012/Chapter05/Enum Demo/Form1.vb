Public Class Form1

    'DayAction Enumeration
    Private Enum DayAction As Integer
        Asleep = 0
        GettingReadyForWork = 1
        TravelingToWork = 2
        AtWork = 3
        AtLunch = 4
        TravelingFromWork = 5
        RelaxingWithFriends = 6
        GettingReadyForBed = 7
    End Enum

    'Declare variable
    Private CurrentState As DayAction

    'Hour property
    Private Property Hour() As Integer
        Get
            'Return the current hour displayed
            Return dtpHour.Value.Hour
        End Get
        Set(ByVal value As Integer)
            'Set the date using the hour passed to this property
            dtpHour.Value = _
                New Date(Now.Year, Now.Month, Now.Day, value, 0, 0)

            'Determine the state
            If value >= 6 And value < 7 Then
                CurrentState = DayAction.GettingReadyForWork
            ElseIf value >= 7 And value < 8 Then
                CurrentState = DayAction.TravelingToWork
            ElseIf value >= 8 And value < 13 Then
                CurrentState = DayAction.AtWork
            ElseIf value >= 13 And value < 14 Then
                CurrentState = DayAction.AtLunch
            ElseIf value >= 14 And value < 17 Then
                CurrentState = DayAction.AtWork
            ElseIf value >= 17 And value < 18 Then
                CurrentState = DayAction.TravelingFromWork
            ElseIf value >= 18 And value < 22 Then
                CurrentState = DayAction.RelaxingWithFriends
            ElseIf value >= 22 And value < 23 Then
                CurrentState = DayAction.GettingReadyForBed
            Else
                CurrentState = DayAction.Asleep
            End If

            'Set the display text
            lblState.Text = "At " & value & ":00, Richard is " &
        CurrentState.ToString()

        End Set

    End Property


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Set the Hour property to the current hour
        Me.Hour = Now.Hour

    End Sub


    Private Sub dtpHour_ValueChanged(sender As Object,
                e As EventArgs) Handles dtpHour.ValueChanged
        'Update the Hour property
        Me.Hour = dtpHour.Value.Hour
    End Sub
End Class
