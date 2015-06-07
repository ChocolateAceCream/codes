<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btn2Buttons = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(28, 158)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(95, 12)
        Me.lblResults.TabIndex = 0
        Me.lblResults.Text = "Nothing Clicked"
        '
        'btn2Buttons
        '
        Me.btn2Buttons.Location = New System.Drawing.Point(67, 67)
        Me.btn2Buttons.Name = "btn2Buttons"
        Me.btn2Buttons.Size = New System.Drawing.Size(75, 23)
        Me.btn2Buttons.TabIndex = 1
        Me.btn2Buttons.Text = "2 buttons"
        Me.btn2Buttons.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn2Buttons)
        Me.Controls.Add(Me.lblResults)
        Me.Name = "Form1"
        Me.Text = "MEssageBox Buttons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents btn2Buttons As System.Windows.Forms.Button

End Class
