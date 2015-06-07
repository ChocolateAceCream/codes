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
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btn2Buttons = New System.Windows.Forms.Button()
        Me.btn3Buttons = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(49, 40)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(82, 13)
        Me.lblResults.TabIndex = 0
        Me.lblResults.Text = "Nothing Clicked"
        '
        'btn2Buttons
        '
        Me.btn2Buttons.Location = New System.Drawing.Point(52, 75)
        Me.btn2Buttons.Name = "btn2Buttons"
        Me.btn2Buttons.Size = New System.Drawing.Size(75, 23)
        Me.btn2Buttons.TabIndex = 1
        Me.btn2Buttons.Text = "2 Buttons"
        Me.btn2Buttons.UseVisualStyleBackColor = True
        '
        'btn3Buttons
        '
        Me.btn3Buttons.Location = New System.Drawing.Point(52, 126)
        Me.btn3Buttons.Name = "btn3Buttons"
        Me.btn3Buttons.Size = New System.Drawing.Size(75, 23)
        Me.btn3Buttons.TabIndex = 2
        Me.btn3Buttons.Text = "3 Buttons"
        Me.btn3Buttons.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn3Buttons)
        Me.Controls.Add(Me.btn2Buttons)
        Me.Controls.Add(Me.lblResults)
        Me.Name = "Form1"
        Me.Text = "MessageBox Buttons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents btn2Buttons As System.Windows.Forms.Button
    Friend WithEvents btn3Buttons As System.Windows.Forms.Button

End Class
