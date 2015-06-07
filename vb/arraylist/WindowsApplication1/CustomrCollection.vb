Public Class CustomrCollection
    Inherits CollectionBase 
    Private objEmailHashtable As New Hashtable
    Public ReadOnly Property EmailHashtable() As Hashtable
        Get
            Return objEmailHashtable
        End Get
    End Property

    Public Sub add(neww As Form1.customer)
        Me.List.Add(neww)
        EmailHashtable.Add(neww.email, neww)
    End Sub

    Public Sub remove(old As Form1.customer)
        Me.List.Remove(old)
    End Sub



    Default Public ReadOnly Property Item(email As String) As Form1.customer
        Get
            Return CType(EmailHashtable.Item(email), Form1.customer)
        End Get
    End Property


End Class