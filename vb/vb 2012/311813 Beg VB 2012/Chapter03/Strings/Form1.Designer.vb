<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnStrings = New System.Windows.Forms.Button()
        Me.btnConcatenation = New System.Windows.Forms.Button()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.btnLength = New System.Windows.Forms.Button()
        Me.btnSubStrings = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStrings
        '
        Me.btnStrings.Location = New System.Drawing.Point(12, 12)
        Me.btnStrings.Name = "btnStrings"
        Me.btnStrings.Size = New System.Drawing.Size(196, 23)
        Me.btnStrings.TabIndex = 0
        Me.btnStrings.Text = "Using Strings"
        Me.btnStrings.UseVisualStyleBackColor = True
        '
        'btnConcatenation
        '
        Me.btnConcatenation.Location = New System.Drawing.Point(12, 41)
        Me.btnConcatenation.Name = "btnConcatenation"
        Me.btnConcatenation.Size = New System.Drawing.Size(196, 23)
        Me.btnConcatenation.TabIndex = 1
        Me.btnConcatenation.Text = "Concatenation"
        Me.btnConcatenation.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(12, 72)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(100, 20)
        Me.txtString.TabIndex = 2
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(133, 70)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(75, 23)
        Me.btnLength.TabIndex = 3
        Me.btnLength.Text = "Length"
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'btnSubStrings
        '
        Me.btnSubStrings.Location = New System.Drawing.Point(13, 99)
        Me.btnSubStrings.Name = "btnSubStrings"
        Me.btnSubStrings.Size = New System.Drawing.Size(75, 23)
        Me.btnSubStrings.TabIndex = 4
        Me.btnSubStrings.Text = "SubStrings"
        Me.btnSubStrings.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(133, 100)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 5
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 169)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnSubStrings)
        Me.Controls.Add(Me.btnLength)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.btnConcatenation)
        Me.Controls.Add(Me.btnStrings)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStrings As System.Windows.Forms.Button
    Friend WithEvents btnConcatenation As System.Windows.Forms.Button
    Friend WithEvents txtString As System.Windows.Forms.TextBox
    Friend WithEvents btnLength As System.Windows.Forms.Button
    Friend WithEvents btnSubStrings As System.Windows.Forms.Button
    Friend WithEvents btnReplace As System.Windows.Forms.Button

End Class
