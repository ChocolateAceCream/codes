Public Class Form1
    Private objadd As New ArrayList
    Public Sub create(firstname As String, lastname As String, email As String)
        Dim obj As customer
        obj.firstname = firstname
        obj.lastname = lastname
        obj.email = email
        objadd.add(obj)
        lst1.Items.Add(obj)
    End Sub

    Public ReadOnly Property select11() As customer
        Get
            If lst1.SelectedIndex <> -1 Then
                Return objadd(lst1.SelectedIndex)
            End If
        End Get

    End Property



    Public Structure customer
        Public firstname As String
        Public lastname As String
        Public email As String
        Public ReadOnly Property name() As String
            Get
                Return firstname & " " & lastname
            End Get
        End Property
        Public Overrides Function ToString() As String
            Return name & " (" & email & ")"
        End Function

    End Structure

    Private Sub display(customer As customer)
        txt1.Text = customer.name
        txt2.Text = customer.firstname
        txt3.Text = customer.lastname
        txt4.Text = customer.email

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        objadd.Clear()
        lst1.Items.Clear()
        create("DD", "HH", "DD@HH.com")
        create("DDd", "HHh", "DDd@HHh.com")
        create("DDdd", "HHhh", "DDdd@HHhh.com")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If lst1.SelectedIndex = -1 Then
            MessageBox.Show("select one")
            Exit Sub
        End If

        If MessageBox.Show("want to delete" & select11.name & "?", "GG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim objdelet As customer = select11
            objadd.Remove(objdelet)
            lst1.Items.Remove(objdelet)
        End If

    End Sub

    Private Sub lst1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst1.SelectedIndexChanged
        display(select11)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

        Dim objFoundCustomer As customer = objadd(txt4.Text)


        If Not IsNothing(objFoundCustomer.email) Then
            MessageBox.Show("the customer name is " & objFoundCustomer.name)
        Else
            MessageBox.Show("NO found")
        End If

    End Sub
End Class
