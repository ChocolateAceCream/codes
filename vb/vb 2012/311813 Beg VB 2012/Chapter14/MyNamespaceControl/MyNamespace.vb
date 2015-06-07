Public Class MyNamespace

    'Private members
    Private strApplicationName As String = String.Empty

    'Public Events
    Public Event ApplicationCopyrightChanged(ByVal text As String)
    Public Event ScreenBoundsChanged(ByVal bounds As Rectangle)
    Public Event ScreenWorkingAreaChanged(ByVal bounds As Rectangle)

    Public Property ApplicationName() As String
        Get
            Return strApplicationName
        End Get
        Set(ByVal value As String)
            strApplicationName = value
        End Set
    End Property

    Private Sub btnApplicationCopyright_Click(Sender As Object,
    E As EventArgs) Handles btnApplicationCopyright.Click

        RaiseEvent ApplicationCopyrightChanged(
            My.Application.Info.Copyright)
        MessageBox.Show(My.Application.Info.Copyright,
            strApplicationName)
    End Sub

    Private Sub btnScreenBounds_Click(Sender As Object,
        E As EventArgs) Handles btnScreenBounds.Click

        RaiseEvent ScreenBoundsChanged(My.Computer.Screen.Bounds)
        MessageBox.Show(My.Computer.Screen.Bounds.ToString,
            strApplicationName)
    End Sub

    Private Sub btnScreenWorkingArea_Click(Sender As Object,
        E As EventArgs) Handles btnScreenWorkingArea.Click

        RaiseEvent ScreenWorkingAreaChanged(My.Computer.Screen.WorkingArea)
        MessageBox.Show(My.Computer.Screen.WorkingArea.ToString,
            strApplicationName)
    End Sub


    Public Function TaskBarHeight() As Integer
        Return My.Computer.Screen.Bounds.Height -
        My.Computer.Screen.WorkingArea.Height()
    End Function

    Protected Overrides Sub InitLayout()
        MyBase.InitLayout()

        'Are we in design mode?
        If DesignMode Then
            lblTime.Text = "Design Mode"
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(Sender As Object,
        E As EventArgs) Handles Timer1.Tick

        'Display the time
        lblTime.Text = Now.ToLongTimeString
    End Sub
End Class
