Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles gga.TextChanged

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) Handles btnOK.Click
        MessageBox.Show("Hello, " & txtName.Text & _
                        "! Welcome to adfasdf.", _
                        "Hello User Messagae")


    End Sub
    Private Sub btnExit_Click(sender As Object,
                              e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
