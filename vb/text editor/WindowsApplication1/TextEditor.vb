Public Class TextEditor

    Public Property StatusText() As String
        Get
            Return sslStatus.Text
        End Get
        Set(value As String)
            sslStatus.Text = value
        End Set
    End Property

    Public Property EditText() As String
        Get
            Return txtEdit.Text
        End Get
        Set(value As String)
            txtEdit.Text = value
        End Set
    End Property

    Public Sub ClearEditBox()
        EditText = String.Empty
        txtEdit.ForeColor = Color.Black
        StatusText = "Text box cleared"
    End Sub

    Public Sub RedText()
        txtEdit.ForeColor = Color.Red
        StatusText = "red text"
    End Sub

    Public Sub UpperCaseText()
        EditText = EditText.ToUpper
        StatusText = "upper"
    End Sub

    Public Sub ShowAboutBox()
        Using objAbout As New AboutBox1
            objAbout.ShowDialog(Me)
        End Using
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tbrBlue.Click

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles tbrRed.Click
        RedText()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub TextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtEdit_TextChanged(sender As Object, e As EventArgs) Handles txtEdit.TextChanged
        StatusText = "ready"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles sslStatus.Click

    End Sub

    Private Sub tbrClear_Click(sender As Object, e As EventArgs) Handles tbrClear.Click
        ClearEditBox()
    End Sub

    Private Sub tbrUpperCase_Click(sender As Object, e As EventArgs) Handles tbrUpperCase.Click
        UpperCaseText()
    End Sub

    Private Sub tbrHelpAbout_Click(sender As Object, e As EventArgs) Handles tbrHelpAbout.Click
        ShowAboutBox()

    End Sub
End Class
