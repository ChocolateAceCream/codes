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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.lst1 = New System.Windows.Forms.ListBox()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(63, 323)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(105, 19)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "list customer"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(61, 195)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(29, 12)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "name"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(61, 223)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(53, 12)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = "1st name"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(61, 256)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(59, 12)
        Me.lbl3.TabIndex = 3
        Me.lbl3.Text = "last name"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(61, 286)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(35, 12)
        Me.lbl4.TabIndex = 4
        Me.lbl4.Text = "email"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(138, 195)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(163, 21)
        Me.txt1.TabIndex = 5
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(138, 256)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(163, 21)
        Me.txt3.TabIndex = 6
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(138, 286)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(163, 21)
        Me.txt4.TabIndex = 7
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(138, 223)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(163, 21)
        Me.txt2.TabIndex = 8
        '
        'lst1
        '
        Me.lst1.FormattingEnabled = True
        Me.lst1.IntegralHeight = False
        Me.lst1.ItemHeight = 12
        Me.lst1.Location = New System.Drawing.Point(63, 13)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(238, 174)
        Me.lst1.TabIndex = 9
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(190, 323)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(107, 18)
        Me.btn2.TabIndex = 10
        Me.btn2.Text = "delete"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(63, 348)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 11
        Me.btn3.Text = "LookUp"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 427)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.lst1)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents lst1 As System.Windows.Forms.ListBox
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button

End Class
