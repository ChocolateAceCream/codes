
Partial Class _Default
    Inherits Page

    Protected Sub Page_Load(sender As Object,
        e As EventArgs) Handles Me.Load
        If Page.IsPostBack Then
            'If this is a postback and not the initial page load
            'Display the data to the user
            Me.lblWelcome.Text = "Hello" + Me.txtFirstName.Text + " " +
            Me.txtLastName.Text + "<BR>" + "Your email address is" +
            Me.txtEmail.Text
        End If
    End Sub

End Class