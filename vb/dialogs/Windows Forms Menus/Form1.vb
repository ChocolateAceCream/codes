Public Class Form1

    Private Sub 索引IToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 索引IToolStripMenuItem.Click

    End Sub

    Private Sub FormattingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormattingToolStripMenuItem.Click
        If FormattingToolStripMenuItem.Checked Then
            tspFormatting.Visible = True
        Else
            tspFormatting.Visible = False

        End If
    End Sub

    Private Sub 自定义CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 自定义CToolStripMenuItem.Click

    End Sub

    Private Sub 选项OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 选项OToolStripMenuItem.Click

    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox1.Focus()

    End Sub

    Private Sub 新建NToolStripButton_Click(sender As Object, e As EventArgs) Handles 新建NToolStripButton.Click
        ToolStripMenuItem1_Click(sender, e)

    End Sub

    Private Sub 退出XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出XToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 撤消UToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 撤消UToolStripMenuItem.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Undo()
        End If
    End Sub

    Private Sub 剪切TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 剪切TToolStripMenuItem.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Cut()
        End If
    End Sub

    Private Sub 剪切UToolStripButton_Click(sender As Object, e As EventArgs) Handles 剪切UToolStripButton.Click
        剪切TToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub 复制CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制CToolStripMenuItem.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Copy()
        End If
    End Sub

    Private Sub 复制CToolStripButton_Click(sender As Object, e As EventArgs) Handles 复制CToolStripButton.Click
        复制CToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub 粘贴PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 粘贴PToolStripMenuItem.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Paste()
        End If
    End Sub

    Private Sub 粘贴PToolStripButton_Click(sender As Object, e As EventArgs) Handles 粘贴PToolStripButton.Click
        粘贴PToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub 全选AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 全选AToolStripMenuItem.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).SelectAll()
        End If
    End Sub

    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        If MainToolStripMenuItem.Checked Then
            tspMain.Visible = True
        Else
            tspMain.Visible = False

        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub 帮助LToolStripButton_Click(sender As Object, e As EventArgs) Handles 帮助LToolStripButton.Click

    End Sub

    Private Sub toolStripSeparator7_Click(sender As Object, e As EventArgs) Handles toolStripSeparator7.Click

    End Sub

    Private Sub toolStripSeparator6_Click(sender As Object, e As EventArgs) Handles toolStripSeparator6.Click

    End Sub

    Private Sub 打印PToolStripButton_Click(sender As Object, e As EventArgs) Handles 打印PToolStripButton.Click

    End Sub

    Private Sub 保存SToolStripButton_Click(sender As Object, e As EventArgs) Handles 保存SToolStripButton.Click

    End Sub

    Private Sub 打开OToolStripButton_Click(sender As Object, e As EventArgs) Handles 打开OToolStripButton.Click

    End Sub

    Private Sub tspMain_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspMain.ItemClicked

    End Sub

    Private Sub ToolbarsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolbarsToolStripMenuItem.Click

    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click

    End Sub

    Private Sub 关于AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于AToolStripMenuItem.Click

    End Sub

    Private Sub toolStripSeparator5_Click(sender As Object, e As EventArgs) Handles toolStripSeparator5.Click

    End Sub

    Private Sub 搜索SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 搜索SToolStripMenuItem.Click

    End Sub

    Private Sub 内容CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 内容CToolStripMenuItem.Click

    End Sub

    Private Sub 帮助HToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 帮助HToolStripMenuItem.Click

    End Sub

    Private Sub 工具TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 工具TToolStripMenuItem.Click

    End Sub

    Private Sub toolStripSeparator4_Click(sender As Object, e As EventArgs) Handles toolStripSeparator4.Click

    End Sub

    Private Sub toolStripSeparator3_Click(sender As Object, e As EventArgs) Handles toolStripSeparator3.Click

    End Sub

    Private Sub 重复RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重复RToolStripMenuItem.Click

    End Sub

    Private Sub 编辑EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 编辑EToolStripMenuItem.Click

    End Sub

    Private Sub toolStripSeparator2_Click(sender As Object, e As EventArgs) Handles toolStripSeparator2.Click

    End Sub

    Private Sub 打印预览VToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打印预览VToolStripMenuItem.Click

    End Sub

    Private Sub 打印PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打印PToolStripMenuItem.Click

    End Sub

    Private Sub toolStripSeparator1_Click(sender As Object, e As EventArgs) Handles toolStripSeparator1.Click

    End Sub

    Private Sub 另存为AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 另存为AToolStripMenuItem.Click

    End Sub

    Private Sub 保存SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存SToolStripMenuItem.Click

    End Sub

    Private Sub toolStripSeparator_Click(sender As Object, e As EventArgs) Handles toolStripSeparator.Click

    End Sub

    Private Sub 打开OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开OToolStripMenuItem.Click

    End Sub

    Private Sub 新建NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新建NToolStripMenuItem.Click

    End Sub

    Private Sub 文件FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 文件FToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub tspFormatting_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspFormatting.ItemClicked

    End Sub

    Private Sub ContextUndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContextUndoToolStripMenuItem.Click
        撤消UToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToggleMenus()
        Dim objTextBox As TextBox = CType(Me.ActiveControl, TextBox)
        Dim blnEnabled As Boolean = CType(objTextBox.SelectionLength, Boolean)
        ContextUndoToolStripMenuItem.Enabled = objTextBox.CanUndo
        ContextCutToolStropMenuItem.Enabled = blnEnabled
       
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToggleMenus()

    End Sub
End Class
