Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ClearList()

        For i = 1 To 5
            lstData.Items.Add("im item" & i.ToString & "in the list")
        Next
    End Sub

    Private Sub ClearList()
        lstData.Items.Clear()
    End Sub

    Private Sub btnEach_Click(sender As Object, e As EventArgs) Handles btnEach.Click
        ClearList()
        For Each StrFolder As String In
            My.Computer.FileSystem.GetDirectories("C:\")
            lstData.Items.Add(StrFolder)
        Next
    End Sub

    Private Sub btnDo_Click(sender As Object, e As EventArgs) Handles btnDo.Click
        Dim ran As New Random
        Dim intRan As Integer = 0
        ClearList()
        Do Until intRan = 10
            intRan = ran.Next(25)
            lstData.Items.Add(intRan.ToString)
        Loop
    End Sub

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        Dim ran As New Random
        Dim intRan As Integer = 0
        ClearList()
        intRan = ran.Next(25)
        Do While intRan < 10
            lstData.Items.Add(intRan.ToString)
            intRan = ran.Next(25)

        Loop
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Dim i As Integer
        Dim k As Integer
        ClearList()
        For i = 1 To 10 Step 2
            For k = 1 To 12 Step 3
                lstData.Items.Add(i.ToString & "," & k.ToString)
            Next

        Next
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ClearList()
        For Each StrFolder As String In
            My.Computer.FileSystem.GetDirectories("C:\")
            lstData.Items.Add(StrFolder)
            If String.Compare(StrFolder, "C:\program files", True) = 0 Then
                MessageBox.Show("found,exit")
                Exit For
            End If
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnArray.Click
        Dim strfriends(3) As String
        strfriends(0) = "a"
        strfriends(1) = "aa"
        strfriends(2) = "aaa"
        strfriends(3) = "aaaa"
        ReDim Preserve strfriends(4)
        strfriends(4) = "bbbbb"
        addItem(strfriends)
    End Sub
    Private Sub addItem(arrayList() As String)
        For Each strname As String In arrayList
            lstData.Items.Add("[" & strname & "]")
        Next
    End Sub
End Class
