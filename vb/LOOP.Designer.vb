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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnEach = New System.Windows.Forms.Button()
        Me.btnDo = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnArray = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.IntegralHeight = False
        Me.lstData.ItemHeight = 12
        Me.lstData.Location = New System.Drawing.Point(13, 47)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(120, 148)
        Me.lstData.TabIndex = 0
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(158, 47)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(114, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnEach
        '
        Me.btnEach.Location = New System.Drawing.Point(158, 105)
        Me.btnEach.Name = "btnEach"
        Me.btnEach.Size = New System.Drawing.Size(114, 23)
        Me.btnEach.TabIndex = 2
        Me.btnEach.Text = "each"
        Me.btnEach.UseVisualStyleBackColor = True
        '
        'btnDo
        '
        Me.btnDo.Location = New System.Drawing.Point(158, 76)
        Me.btnDo.Name = "btnDo"
        Me.btnDo.Size = New System.Drawing.Size(75, 23)
        Me.btnDo.TabIndex = 3
        Me.btnDo.Text = "do until"
        Me.btnDo.UseVisualStyleBackColor = True
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(158, 134)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(75, 23)
        Me.btnDoWhile.TabIndex = 4
        Me.btnDoWhile.Text = "do while"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(158, 163)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 23)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "inner looop"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(158, 193)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnArray
        '
        Me.btnArray.Location = New System.Drawing.Point(158, 227)
        Me.btnArray.Name = "btnArray"
        Me.btnArray.Size = New System.Drawing.Size(75, 23)
        Me.btnArray.TabIndex = 7
        Me.btnArray.Text = "array"
        Me.btnArray.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnArray)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btnDoWhile)
        Me.Controls.Add(Me.btnDo)
        Me.Controls.Add(Me.btnEach)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lstData)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnEach As System.Windows.Forms.Button
    Friend WithEvents btnDo As System.Windows.Forms.Button
    Friend WithEvents btnDoWhile As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnArray As System.Windows.Forms.Button

End Class
