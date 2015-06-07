Imports System.Drawing.Printing

Public Class Dialogs

    Private strFileName As String
    Private strPrintRecord As String
    Private WithEvents DialogsPrintDocument As PrintDocument

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        With OpenFileDialog1
            .Filter = "Text Documents(*.txt)|*.txt|ALL Files(*.*)|*.*"
            .FilterIndex = 2
            .Title = "Demo Open File Dialog"
        End With

        If OpenFileDialog1.ShowDialog =
            Windows.Forms.DialogResult.OK Then
            Try
                strFileName = OpenFileDialog1.FileName

                Dim fileContents As String
                fileContents = My.Computer.FileSystem.ReadAllText(strFileName)
                txtFile.Text = fileContents
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With SaveFileDialog1
            .DefaultExt = "txt"
            .FileName = strFileName
            .Filter = "Text Documents (*.txt)| *.txt|All Files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Demo save file dialog"


        End With

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                strFileName = SaveFileDialog1.FileName
                My.Computer.FileSystem.WriteAllText(strFileName, txtFile.Text, False)
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        FontDialog1.ShowColor = True
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFile.Font = FontDialog1.Font
            txtFile.ForeColor = FontDialog1.Color
        End If

    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.ForeColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub DialogsPrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles DialogsPrintDocument.PrintPage
        Dim intCharactersToPrint As Integer
        Dim intLinesPerPage As Integer
        Dim strPrintData As String
        Dim objStringFormat As New StringFormat
        Dim objPrintFont As New Font("Arial", 10)
        Dim objPageBoundaries As RectangleF
        Dim objPrintArea As SizeF
        objPageBoundaries = New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
        objPrintArea = New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - objPrintFont.GetHeight(e.Graphics))
        objStringFormat.Trimming = StringTrimming.Word
        e.Graphics.MeasureString(strPrintRecord, objPrintFont, objPrintArea, objStringFormat, intCharactersToPrint, intLinesPerPage)
        strPrintData = strPrintRecord.Substring(0, intCharactersToPrint)
        e.Graphics.DrawString(strPrintData, objPrintFont, Brushes.Black, objPageBoundaries, objStringFormat)
        If intCharactersToPrint < strPrintRecord.Length Then
            strPrintRecord = strPrintRecord.Remove(0, intCharactersToPrint)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

   
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        DialogsPrintDocument = New PrintDocument
        With PrintDialog1
            .AllowCurrentPage = False
            .AllowPrintToFile = True
            .AllowSelection = False
            .AllowSomePages = False
            .Document = DialogsPrintDocument
            .PrinterSettings.DefaultPageSettings.Margins.Top = 25
            .PrinterSettings.DefaultPageSettings.Margins.Bottom = 25
            .PrinterSettings.DefaultPageSettings.Margins.Left = 25
            .PrinterSettings.DefaultPageSettings.Margins.Right = 25

        End With
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            DialogsPrintDocument.PrinterSettings = PrintDialog1.PrinterSettings

            strPrintRecord = txtFile.Text
            DialogsPrintDocument.Print()

        End If

    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        With FolderBrowserDialog1
            .Description = " Select a backup folder"
            .RootFolder = Environment.SpecialFolder.MyComputer
            .ShowNewFolderButton = True

        End With

        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFile.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub
End Class
