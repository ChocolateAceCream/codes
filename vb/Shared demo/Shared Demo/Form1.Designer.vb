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
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudMinPasswordLength = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudMinPasswordLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstUsers
        '
        Me.lstUsers.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.ItemHeight = 12
        Me.lstUsers.Location = New System.Drawing.Point(0, 0)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(414, 355)
        Me.lstUsers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "pw length"
        '
        'nudMinPasswordLength
        '
        Me.nudMinPasswordLength.Location = New System.Drawing.Point(420, 132)
        Me.nudMinPasswordLength.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMinPasswordLength.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudMinPasswordLength.Name = "nudMinPasswordLength"
        Me.nudMinPasswordLength.Size = New System.Drawing.Size(110, 21)
        Me.nudMinPasswordLength.TabIndex = 2
        Me.nudMinPasswordLength.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 355)
        Me.Controls.Add(Me.nudMinPasswordLength)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstUsers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudMinPasswordLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudMinPasswordLength As System.Windows.Forms.NumericUpDown

End Class
