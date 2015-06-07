Public Class Form1

    Private Sub btnTaskbarHeight_Click(Sender As Object,
        E As EventArgs) Handles btnTaskbarHeight.Click

        MessageBox.Show("Taskbar Height = " &
            MyNamespace1.TaskBarHeight & " pixels", "Form1")
    End Sub



    Private Sub MyNamespace1_ApplicationCopyrightChanged(text As String)


        txtApplicationCopyright.Text = text
    End Sub

    Private Sub MyNamespace1_ScreenBoundsChanged(bounds As  _
        System.Drawing.Rectangle)

        txtScreenBounds.Text = bounds.ToString
    End Sub

    Private Sub MyNamespace1_ScreenWorkingAreaChanged(bounds As  _
        System.Drawing.Rectangle)

        txtScreenWorkingArea.Text = bounds.ToString
    End Sub




End Class
