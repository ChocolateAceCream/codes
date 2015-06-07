Public Class Form1
    Private Sub CommandLink1_Click(Sender As Object,
    E As EventArgs) Handles CommandLink1.Click

        MessageBox.Show("Sending a report to Wrox.",
           My.Application.Info.Title, MessageBoxButtons.OK)
    End Sub
    Private Sub CommandLink2_Click(Sender As Object,
        E As EventArgs) Handles CommandLink2.Click

        MessageBox.Show("Reinstalling the program.",
            My.Application.Info.Title, MessageBoxButtons.OK)
    End Sub
    Private Sub CommandLink3_Click(Sender As Object,
            E As EventArgs) Handles CommandLink3.Click

        MessageBox.Show("Searching the Internet.",
            My.Application.Info.Title, MessageBoxButtons.OK)
        Me.Close()
    End Sub

End Class
