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
        Me.CommandLink1 = New ButtonExtended.CommandLink()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CommandLink2 = New ButtonExtended.CommandLink()
        Me.CommandLink3 = New ButtonExtended.CommandLink()
        Me.SuspendLayout()
        '
        'CommandLink1
        '
        Me.CommandLink1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink1.Image = Nothing
        Me.CommandLink1.Location = New System.Drawing.Point(6, 56)
        Me.CommandLink1.Name = "CommandLink1"
        Me.CommandLink1.Size = New System.Drawing.Size(343, 45)
        Me.CommandLink1.TabIndex = 0
        Me.CommandLink1.Text = "Send a Report to Wrox"
        Me.CommandLink1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(2, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This program has discovered a problem with the installed device.dll file."
        '
        'CommandLink2
        '
        Me.CommandLink2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink2.Image = Nothing
        Me.CommandLink2.Location = New System.Drawing.Point(13, 123)
        Me.CommandLink2.Name = "CommandLink2"
        Me.CommandLink2.Size = New System.Drawing.Size(343, 65)
        Me.CommandLink2.SupplementalExplanation = "You can reinstall the program to fix a corrupt installation file."
        Me.CommandLink2.TabIndex = 2
        Me.CommandLink2.Text = "Reinstall the Program."
        Me.CommandLink2.UACShield = True
        Me.CommandLink2.UseVisualStyleBackColor = True
        '
        'CommandLink3
        '
        Me.CommandLink3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandLink3.Image = Global.Command_Link_Control_Demo.My.Resources.Resources.mynet
        Me.CommandLink3.Location = New System.Drawing.Point(13, 195)
        Me.CommandLink3.Name = "CommandLink3"
        Me.CommandLink3.Size = New System.Drawing.Size(343, 60)
        Me.CommandLink3.SupplementalExplanation = "Search the Internet for a solution to this problem."
        Me.CommandLink3.TabIndex = 3
        Me.CommandLink3.Text = "Search for a Solution Online."
        Me.CommandLink3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(379, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.CommandLink3)
        Me.Controls.Add(Me.CommandLink2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CommandLink1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Program Error"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CommandLink1 As ButtonExtended.CommandLink
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CommandLink2 As ButtonExtended.CommandLink
    Friend WithEvents CommandLink3 As ButtonExtended.CommandLink

End Class
