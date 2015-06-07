<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextEditor))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tbrClear = New System.Windows.Forms.ToolStripButton()
        Me.tbrRed = New System.Windows.Forms.ToolStripButton()
        Me.tbrBlue = New System.Windows.Forms.ToolStripButton()
        Me.tbrUpperCase = New System.Windows.Forms.ToolStripButton()
        Me.tbrLowerCase = New System.Windows.Forms.ToolStripButton()
        Me.tbrHelpAbout = New System.Windows.Forms.ToolStripButton()
        Me.txtEdit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrClear, Me.tbrRed, Me.tbrBlue, Me.tbrUpperCase, Me.tbrLowerCase, Me.tbrHelpAbout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(584, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tbrClear
        '
        Me.tbrClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrClear.Image = CType(resources.GetObject("tbrClear.Image"), System.Drawing.Image)
        Me.tbrClear.ImageTransparentColor = System.Drawing.Color.Violet
        Me.tbrClear.Name = "tbrClear"
        Me.tbrClear.Size = New System.Drawing.Size(23, 22)
        Me.tbrClear.Text = "ToolStripButton1"
        '
        'tbrRed
        '
        Me.tbrRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrRed.Image = CType(resources.GetObject("tbrRed.Image"), System.Drawing.Image)
        Me.tbrRed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrRed.Name = "tbrRed"
        Me.tbrRed.Size = New System.Drawing.Size(23, 22)
        Me.tbrRed.Text = "ToolStripButton2"
        '
        'tbrBlue
        '
        Me.tbrBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrBlue.Image = CType(resources.GetObject("tbrBlue.Image"), System.Drawing.Image)
        Me.tbrBlue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrBlue.Name = "tbrBlue"
        Me.tbrBlue.Size = New System.Drawing.Size(23, 22)
        Me.tbrBlue.Text = "ToolStripButton1"
        '
        'tbrUpperCase
        '
        Me.tbrUpperCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrUpperCase.Image = CType(resources.GetObject("tbrUpperCase.Image"), System.Drawing.Image)
        Me.tbrUpperCase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrUpperCase.Name = "tbrUpperCase"
        Me.tbrUpperCase.Size = New System.Drawing.Size(23, 22)
        Me.tbrUpperCase.Text = "ToolStripButton1"
        '
        'tbrLowerCase
        '
        Me.tbrLowerCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrLowerCase.Image = CType(resources.GetObject("tbrLowerCase.Image"), System.Drawing.Image)
        Me.tbrLowerCase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrLowerCase.Name = "tbrLowerCase"
        Me.tbrLowerCase.Size = New System.Drawing.Size(23, 22)
        Me.tbrLowerCase.Text = "ToolStripButton1"
        '
        'tbrHelpAbout
        '
        Me.tbrHelpAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrHelpAbout.Image = CType(resources.GetObject("tbrHelpAbout.Image"), System.Drawing.Image)
        Me.tbrHelpAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrHelpAbout.Name = "tbrHelpAbout"
        Me.tbrHelpAbout.Size = New System.Drawing.Size(23, 22)
        Me.tbrHelpAbout.Text = "ToolStripButton1"
        '
        'txtEdit
        '
        Me.txtEdit.Location = New System.Drawing.Point(0, 25)
        Me.txtEdit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 20)
        Me.txtEdit.Multiline = True
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEdit.Size = New System.Drawing.Size(584, 304)
        Me.txtEdit.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-2, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 340)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sslStatus
        '
        Me.sslStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.sslStatus.Name = "sslStatus"
        Me.sslStatus.Size = New System.Drawing.Size(44, 17)
        Me.sslStatus.Text = "Ready"
        '
        'TextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEdit)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "TextEditor"
        Me.Text = "TextEditor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tbrClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrRed As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrBlue As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrUpperCase As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrLowerCase As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrHelpAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtEdit As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents sslStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
