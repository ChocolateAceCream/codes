Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblResults.Click

    End Sub

    Private Sub btn2Buttons_Click(sender As Object, e As EventArgs) Handles btn2Buttons.Click
        Dim gg As DialogResult
        gg = MessageBox.Show("your internet connection will bow be closed.", "network NOtification", _
                           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Select Case gg
            Case Windows.Forms.DialogResult.Yes
                lblResults.Text = "yes Clicked"
            Case Windows.Forms.DialogResult.No
                lblResults.Text = "no Clicked"
            Case Windows.Forms.DialogResult.Cancel
                lblResults.Text = "cancel Clicked"
        End Select


    End Sub
End Class
