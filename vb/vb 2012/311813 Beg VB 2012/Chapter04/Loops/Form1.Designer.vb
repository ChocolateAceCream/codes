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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnForNextLoop = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBackwardsForNextLoop = New System.Windows.Forms.Button()
        Me.btnForEachLoop = New System.Windows.Forms.Button()
        Me.btnDoUntilLoop = New System.Windows.Forms.Button()
        Me.btnDoWhileLoop = New System.Windows.Forms.Button()
        Me.btnNestedLoops = New System.Windows.Forms.Button()
        Me.btnQuittingAForLoop = New System.Windows.Forms.Button()
        Me.btnQuittingADoLoop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(2, 12)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(144, 277)
        Me.lstData.TabIndex = 0
        '
        'btnForNextLoop
        '
        Me.btnForNextLoop.Location = New System.Drawing.Point(152, 12)
        Me.btnForNextLoop.Name = "btnForNextLoop"
        Me.btnForNextLoop.Size = New System.Drawing.Size(146, 23)
        Me.btnForNextLoop.TabIndex = 1
        Me.btnForNextLoop.Text = "For Next Loop"
        Me.btnForNextLoop.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "For Next Loop w/ Step"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBackwardsForNextLoop
        '
        Me.btnBackwardsForNextLoop.Location = New System.Drawing.Point(153, 72)
        Me.btnBackwardsForNextLoop.Name = "btnBackwardsForNextLoop"
        Me.btnBackwardsForNextLoop.Size = New System.Drawing.Size(145, 23)
        Me.btnBackwardsForNextLoop.TabIndex = 3
        Me.btnBackwardsForNextLoop.Text = "Backwards For Next Loop"
        Me.btnBackwardsForNextLoop.UseVisualStyleBackColor = True
        '
        'btnForEachLoop
        '
        Me.btnForEachLoop.Location = New System.Drawing.Point(152, 102)
        Me.btnForEachLoop.Name = "btnForEachLoop"
        Me.btnForEachLoop.Size = New System.Drawing.Size(146, 23)
        Me.btnForEachLoop.TabIndex = 4
        Me.btnForEachLoop.Text = "For Each Loop"
        Me.btnForEachLoop.UseVisualStyleBackColor = True
        '
        'btnDoUntilLoop
        '
        Me.btnDoUntilLoop.Location = New System.Drawing.Point(152, 132)
        Me.btnDoUntilLoop.Name = "btnDoUntilLoop"
        Me.btnDoUntilLoop.Size = New System.Drawing.Size(145, 23)
        Me.btnDoUntilLoop.TabIndex = 5
        Me.btnDoUntilLoop.Text = "Do Until Loop"
        Me.btnDoUntilLoop.UseVisualStyleBackColor = True
        '
        'btnDoWhileLoop
        '
        Me.btnDoWhileLoop.Location = New System.Drawing.Point(153, 162)
        Me.btnDoWhileLoop.Name = "btnDoWhileLoop"
        Me.btnDoWhileLoop.Size = New System.Drawing.Size(144, 23)
        Me.btnDoWhileLoop.TabIndex = 6
        Me.btnDoWhileLoop.Text = "Do While Loop"
        Me.btnDoWhileLoop.UseVisualStyleBackColor = True
        '
        'btnNestedLoops
        '
        Me.btnNestedLoops.Location = New System.Drawing.Point(152, 192)
        Me.btnNestedLoops.Name = "btnNestedLoops"
        Me.btnNestedLoops.Size = New System.Drawing.Size(145, 23)
        Me.btnNestedLoops.TabIndex = 7
        Me.btnNestedLoops.Text = "Nested Loops"
        Me.btnNestedLoops.UseVisualStyleBackColor = True
        '
        'btnQuittingAForLoop
        '
        Me.btnQuittingAForLoop.Location = New System.Drawing.Point(152, 222)
        Me.btnQuittingAForLoop.Name = "btnQuittingAForLoop"
        Me.btnQuittingAForLoop.Size = New System.Drawing.Size(145, 23)
        Me.btnQuittingAForLoop.TabIndex = 8
        Me.btnQuittingAForLoop.Text = "Quitting A For Loop"
        Me.btnQuittingAForLoop.UseVisualStyleBackColor = True
        '
        'btnQuittingADoLoop
        '
        Me.btnQuittingADoLoop.Location = New System.Drawing.Point(152, 252)
        Me.btnQuittingADoLoop.Name = "btnQuittingADoLoop"
        Me.btnQuittingADoLoop.Size = New System.Drawing.Size(145, 23)
        Me.btnQuittingADoLoop.TabIndex = 9
        Me.btnQuittingADoLoop.Text = "Quitting A Do Loop"
        Me.btnQuittingADoLoop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 297)
        Me.Controls.Add(Me.btnQuittingADoLoop)
        Me.Controls.Add(Me.btnQuittingAForLoop)
        Me.Controls.Add(Me.btnNestedLoops)
        Me.Controls.Add(Me.btnDoWhileLoop)
        Me.Controls.Add(Me.btnDoUntilLoop)
        Me.Controls.Add(Me.btnForEachLoop)
        Me.Controls.Add(Me.btnBackwardsForNextLoop)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnForNextLoop)
        Me.Controls.Add(Me.lstData)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents btnForNextLoop As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBackwardsForNextLoop As System.Windows.Forms.Button
    Friend WithEvents btnForEachLoop As System.Windows.Forms.Button
    Friend WithEvents btnDoUntilLoop As System.Windows.Forms.Button
    Friend WithEvents btnDoWhileLoop As System.Windows.Forms.Button
    Friend WithEvents btnNestedLoops As System.Windows.Forms.Button
    Friend WithEvents btnQuittingAForLoop As System.Windows.Forms.Button
    Friend WithEvents btnQuittingADoLoop As System.Windows.Forms.Button

End Class
