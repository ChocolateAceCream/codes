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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.nudMinPasswordLength = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudMinPasswordLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Length"
        '
        'lstUsers
        '
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Location = New System.Drawing.Point(12, 12)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(184, 238)
        Me.lstUsers.TabIndex = 1
        '
        'nudMinPasswordLength
        '
        Me.nudMinPasswordLength.Location = New System.Drawing.Point(202, 30)
        Me.nudMinPasswordLength.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMinPasswordLength.Name = "nudMinPasswordLength"
        Me.nudMinPasswordLength.Size = New System.Drawing.Size(86, 20)
        Me.nudMinPasswordLength.TabIndex = 2
        Me.nudMinPasswordLength.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 261)
        Me.Controls.Add(Me.nudMinPasswordLength)
        Me.Controls.Add(Me.lstUsers)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudMinPasswordLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents nudMinPasswordLength As System.Windows.Forms.NumericUpDown

End Class
