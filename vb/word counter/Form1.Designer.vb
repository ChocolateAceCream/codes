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
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.radCountChars = New System.Windows.Forms.RadioButton()
        Me.radCountWords = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Location = New System.Drawing.Point(12, 9)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(173, 12)
        Me.Lable1.TabIndex = 0
        Me.Lable1.Text = "Enter some text for counting"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(14, 46)
        Me.txtWord.Multiline = True
        Me.txtWord.Name = "txtWord"
        Me.txtWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWord.Size = New System.Drawing.Size(390, 190)
        Me.txtWord.TabIndex = 1
        '
        'radCountChars
        '
        Me.radCountChars.AutoSize = True
        Me.radCountChars.Checked = True
        Me.radCountChars.Location = New System.Drawing.Point(14, 243)
        Me.radCountChars.Name = "radCountChars"
        Me.radCountChars.Size = New System.Drawing.Size(53, 16)
        Me.radCountChars.TabIndex = 2
        Me.radCountChars.TabStop = True
        Me.radCountChars.Text = "Chars"
        Me.radCountChars.UseVisualStyleBackColor = True
        '
        'radCountWords
        '
        Me.radCountWords.AutoSize = True
        Me.radCountWords.Location = New System.Drawing.Point(84, 243)
        Me.radCountWords.Name = "radCountWords"
        Me.radCountWords.Size = New System.Drawing.Size(53, 16)
        Me.radCountWords.TabIndex = 3
        Me.radCountWords.Text = "Words"
        Me.radCountWords.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "The results are:"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(296, 245)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(0, 12)
        Me.lblResults.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 262)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radCountWords)
        Me.Controls.Add(Me.radCountChars)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.Lable1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Word Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lable1 As System.Windows.Forms.Label
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents radCountChars As System.Windows.Forms.RadioButton
    Friend WithEvents radCountWords As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResults As System.Windows.Forms.Label

End Class
