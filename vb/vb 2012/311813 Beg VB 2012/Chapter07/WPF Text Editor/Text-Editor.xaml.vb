Class MainWindow 
    'Get or set the text on the status bar
    Public Property StatusText() As String
        Get
            Return sbiStatus.Content.ToString
        End Get
        Set(ByVal value As String)
            sbiStatus.Content = value
        End Set
    End Property

    'Gets or sets the text that you're editing
    Public Property EditText() As String
        Get
            Return txtEdit.Text
        End Get
        Set(ByVal value As String)
            txtEdit.Text = value
        End Set
    End Property

    'Clears the txtEdit control
    Public Sub ClearEditBox()
        'Set the EditText property
        EditText = String.Empty

        'Reset the font color
        txtEdit.Foreground = Brushes.Black

        'Set the status bar text
        StatusText = "Text box cleared"
    End Sub


    Private Sub txtEdit_TextChanged(sender As Object,
                e As TextChangedEventArgs) Handles txtEdit.TextChanged
        'Reset the status bar text
        StatusText = "Ready"

    End Sub

    Private Sub tbrClear_Click(sender As Object,
                e As RoutedEventArgs) Handles tbrClear.Click
        'Clear the edit box
        ClearEditBox()

    End Sub

    Private Sub tbrRed_Click(sender As Object,
                e As RoutedEventArgs) Handles tbrRed.Click
        'Make the text red
        RedText()

    End Sub
    Public Sub RedText()
        'Make the text red
        txtEdit.Foreground = Brushes.Red

        'Update the status bar text
        StatusText = "The text is red"
    End Sub


    Public Sub BlueText()
        'Make the text blue
        txtEdit.Foreground = Brushes.Blue
        'Update the status bar text
        StatusText = "The text is blue"
    End Sub

    Private Sub tbrBlue_Click(ByVal sender As Object,
        ByVal e As System.Windows.RoutedEventArgs) _
        Handles tbrBlue.Click

        'Make the text blue
        BlueText()
    End Sub

    Public Sub UpperCaseText()
        'Make the text uppercase
        EditText = EditText.ToUpper

        'Update the status bar text
        StatusText = "The text is all uppercase"
    End Sub

    Private Sub tbrUpperCase_ClickByVal(sender As Object,
                e As RoutedEventArgs) Handles tbrUpperCase.Click

        'Make the text uppercase
        UpperCaseText()
    End Sub

    Public Sub LowerCaseText()
        'Make the text lowercase
        EditText = EditText.ToLower

        'Update the status bar text
        StatusText = "The text is all lowercase"
    End Sub

    Private Sub tbrLowerCase_Click(sender As Object,
            e As RoutedEventArgs) Handles tbrLowerCase.Click

        'Make the text lowercase
        LowerCaseText()
    End Sub

End Class
