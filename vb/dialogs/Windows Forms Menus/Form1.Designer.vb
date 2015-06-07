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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新建NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.另存为AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.打印PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打印预览VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.撤消UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重复RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.剪切TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.全选AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.工具TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.自定义CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.选项OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolbarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormattingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.内容CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.索引IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.搜索SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspMain = New System.Windows.Forms.ToolStrip()
        Me.新建NToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.打开OToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.保存SToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.打印PToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.剪切UToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.复制CToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.粘贴PToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.帮助LToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tspFormatting = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextUndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextCutToolStropMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.tspMain.SuspendLayout()
        Me.tspFormatting.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem, Me.编辑EToolStripMenuItem, Me.工具TToolStripMenuItem, Me.ViewToolStripMenuItem, Me.帮助HToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(413, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip"
        '
        '文件FToolStripMenuItem
        '
        Me.文件FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新建NToolStripMenuItem, Me.打开OToolStripMenuItem, Me.toolStripSeparator, Me.保存SToolStripMenuItem, Me.另存为AToolStripMenuItem, Me.toolStripSeparator1, Me.打印PToolStripMenuItem, Me.打印预览VToolStripMenuItem, Me.toolStripSeparator2, Me.退出XToolStripMenuItem})
        Me.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem"
        Me.文件FToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.文件FToolStripMenuItem.Text = "文件(&F)"
        '
        '新建NToolStripMenuItem
        '
        Me.新建NToolStripMenuItem.Image = CType(resources.GetObject("新建NToolStripMenuItem.Image"), System.Drawing.Image)
        Me.新建NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem"
        Me.新建NToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.新建NToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.新建NToolStripMenuItem.Text = "新建(&N)"
        '
        '打开OToolStripMenuItem
        '
        Me.打开OToolStripMenuItem.Image = CType(resources.GetObject("打开OToolStripMenuItem.Image"), System.Drawing.Image)
        Me.打开OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem"
        Me.打开OToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.打开OToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.打开OToolStripMenuItem.Text = "打开(&O)"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(155, 6)
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.Image = CType(resources.GetObject("保存SToolStripMenuItem.Image"), System.Drawing.Image)
        Me.保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        '另存为AToolStripMenuItem
        '
        Me.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem"
        Me.另存为AToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.另存为AToolStripMenuItem.Text = "另存为(&A)"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        '打印PToolStripMenuItem
        '
        Me.打印PToolStripMenuItem.Image = CType(resources.GetObject("打印PToolStripMenuItem.Image"), System.Drawing.Image)
        Me.打印PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.打印PToolStripMenuItem.Name = "打印PToolStripMenuItem"
        Me.打印PToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.打印PToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.打印PToolStripMenuItem.Text = "打印(&P)"
        '
        '打印预览VToolStripMenuItem
        '
        Me.打印预览VToolStripMenuItem.Image = CType(resources.GetObject("打印预览VToolStripMenuItem.Image"), System.Drawing.Image)
        Me.打印预览VToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.打印预览VToolStripMenuItem.Name = "打印预览VToolStripMenuItem"
        Me.打印预览VToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.打印预览VToolStripMenuItem.Text = "打印预览(&V)"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(155, 6)
        '
        '退出XToolStripMenuItem
        '
        Me.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem"
        Me.退出XToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.退出XToolStripMenuItem.Text = "退出(&X)"
        '
        '编辑EToolStripMenuItem
        '
        Me.编辑EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.撤消UToolStripMenuItem, Me.重复RToolStripMenuItem, Me.toolStripSeparator3, Me.剪切TToolStripMenuItem, Me.复制CToolStripMenuItem, Me.粘贴PToolStripMenuItem, Me.toolStripSeparator4, Me.全选AToolStripMenuItem})
        Me.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem"
        Me.编辑EToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.编辑EToolStripMenuItem.Text = "编辑(&E)"
        '
        '撤消UToolStripMenuItem
        '
        Me.撤消UToolStripMenuItem.Name = "撤消UToolStripMenuItem"
        Me.撤消UToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.撤消UToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.撤消UToolStripMenuItem.Text = "撤消(&U)"
        '
        '重复RToolStripMenuItem
        '
        Me.重复RToolStripMenuItem.Name = "重复RToolStripMenuItem"
        Me.重复RToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.重复RToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.重复RToolStripMenuItem.Text = "重复(&R)"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(152, 6)
        '
        '剪切TToolStripMenuItem
        '
        Me.剪切TToolStripMenuItem.Image = CType(resources.GetObject("剪切TToolStripMenuItem.Image"), System.Drawing.Image)
        Me.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem"
        Me.剪切TToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.剪切TToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.剪切TToolStripMenuItem.Text = "剪切(&T)"
        '
        '复制CToolStripMenuItem
        '
        Me.复制CToolStripMenuItem.Image = CType(resources.GetObject("复制CToolStripMenuItem.Image"), System.Drawing.Image)
        Me.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem"
        Me.复制CToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.复制CToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.复制CToolStripMenuItem.Text = "复制(&C)"
        '
        '粘贴PToolStripMenuItem
        '
        Me.粘贴PToolStripMenuItem.Image = CType(resources.GetObject("粘贴PToolStripMenuItem.Image"), System.Drawing.Image)
        Me.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem"
        Me.粘贴PToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.粘贴PToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.粘贴PToolStripMenuItem.Text = "粘贴(&P)"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(152, 6)
        '
        '全选AToolStripMenuItem
        '
        Me.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem"
        Me.全选AToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.全选AToolStripMenuItem.Text = "全选(&A)"
        '
        '工具TToolStripMenuItem
        '
        Me.工具TToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.自定义CToolStripMenuItem, Me.选项OToolStripMenuItem})
        Me.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem"
        Me.工具TToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.工具TToolStripMenuItem.Text = "工具(&T)"
        '
        '自定义CToolStripMenuItem
        '
        Me.自定义CToolStripMenuItem.Name = "自定义CToolStripMenuItem"
        Me.自定义CToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.自定义CToolStripMenuItem.Text = "自定义(&C)"
        '
        '选项OToolStripMenuItem
        '
        Me.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem"
        Me.选项OToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.选项OToolStripMenuItem.Text = "选项(&O)"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolbarsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'ToolbarsToolStripMenuItem
        '
        Me.ToolbarsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.FormattingToolStripMenuItem})
        Me.ToolbarsToolStripMenuItem.Name = "ToolbarsToolStripMenuItem"
        Me.ToolbarsToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ToolbarsToolStripMenuItem.Text = "Toolbars"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.Checked = True
        Me.MainToolStripMenuItem.CheckOnClick = True
        Me.MainToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'FormattingToolStripMenuItem
        '
        Me.FormattingToolStripMenuItem.CheckOnClick = True
        Me.FormattingToolStripMenuItem.Name = "FormattingToolStripMenuItem"
        Me.FormattingToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.FormattingToolStripMenuItem.Text = "Formatting"
        '
        '帮助HToolStripMenuItem
        '
        Me.帮助HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.内容CToolStripMenuItem, Me.索引IToolStripMenuItem, Me.搜索SToolStripMenuItem, Me.toolStripSeparator5, Me.关于AToolStripMenuItem})
        Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
        Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
        '
        '内容CToolStripMenuItem
        '
        Me.内容CToolStripMenuItem.Name = "内容CToolStripMenuItem"
        Me.内容CToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.内容CToolStripMenuItem.Text = "内容(&C)"
        '
        '索引IToolStripMenuItem
        '
        Me.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem"
        Me.索引IToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.索引IToolStripMenuItem.Text = "索引(&I)"
        '
        '搜索SToolStripMenuItem
        '
        Me.搜索SToolStripMenuItem.Name = "搜索SToolStripMenuItem"
        Me.搜索SToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.搜索SToolStripMenuItem.Text = "搜索(&S)"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(120, 6)
        '
        '关于AToolStripMenuItem
        '
        Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
        Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.关于AToolStripMenuItem.Text = "关于(&A)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(127, 20)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'tspMain
        '
        Me.tspMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新建NToolStripButton, Me.打开OToolStripButton, Me.保存SToolStripButton, Me.打印PToolStripButton, Me.toolStripSeparator6, Me.剪切UToolStripButton, Me.复制CToolStripButton, Me.粘贴PToolStripButton, Me.toolStripSeparator7, Me.帮助LToolStripButton})
        Me.tspMain.Location = New System.Drawing.Point(0, 24)
        Me.tspMain.Name = "tspMain"
        Me.tspMain.Size = New System.Drawing.Size(413, 25)
        Me.tspMain.TabIndex = 1
        Me.tspMain.Text = "ToolStrip1"
        '
        '新建NToolStripButton
        '
        Me.新建NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.新建NToolStripButton.Image = CType(resources.GetObject("新建NToolStripButton.Image"), System.Drawing.Image)
        Me.新建NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.新建NToolStripButton.Name = "新建NToolStripButton"
        Me.新建NToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.新建NToolStripButton.Text = "新建(&N)"
        '
        '打开OToolStripButton
        '
        Me.打开OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.打开OToolStripButton.Image = CType(resources.GetObject("打开OToolStripButton.Image"), System.Drawing.Image)
        Me.打开OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.打开OToolStripButton.Name = "打开OToolStripButton"
        Me.打开OToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.打开OToolStripButton.Text = "打开(&O)"
        '
        '保存SToolStripButton
        '
        Me.保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.保存SToolStripButton.Image = CType(resources.GetObject("保存SToolStripButton.Image"), System.Drawing.Image)
        Me.保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.保存SToolStripButton.Name = "保存SToolStripButton"
        Me.保存SToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.保存SToolStripButton.Text = "保存(&S)"
        '
        '打印PToolStripButton
        '
        Me.打印PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.打印PToolStripButton.Image = CType(resources.GetObject("打印PToolStripButton.Image"), System.Drawing.Image)
        Me.打印PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.打印PToolStripButton.Name = "打印PToolStripButton"
        Me.打印PToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.打印PToolStripButton.Text = "打印(&P)"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        '剪切UToolStripButton
        '
        Me.剪切UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.剪切UToolStripButton.Image = CType(resources.GetObject("剪切UToolStripButton.Image"), System.Drawing.Image)
        Me.剪切UToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.剪切UToolStripButton.Name = "剪切UToolStripButton"
        Me.剪切UToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.剪切UToolStripButton.Text = "剪切(&U)"
        '
        '复制CToolStripButton
        '
        Me.复制CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.复制CToolStripButton.Image = CType(resources.GetObject("复制CToolStripButton.Image"), System.Drawing.Image)
        Me.复制CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.复制CToolStripButton.Name = "复制CToolStripButton"
        Me.复制CToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.复制CToolStripButton.Text = "复制(&C)"
        '
        '粘贴PToolStripButton
        '
        Me.粘贴PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.粘贴PToolStripButton.Image = CType(resources.GetObject("粘贴PToolStripButton.Image"), System.Drawing.Image)
        Me.粘贴PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.粘贴PToolStripButton.Name = "粘贴PToolStripButton"
        Me.粘贴PToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.粘贴PToolStripButton.Text = "粘贴(&P)"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        '帮助LToolStripButton
        '
        Me.帮助LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.帮助LToolStripButton.Image = CType(resources.GetObject("帮助LToolStripButton.Image"), System.Drawing.Image)
        Me.帮助LToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.帮助LToolStripButton.Name = "帮助LToolStripButton"
        Me.帮助LToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.帮助LToolStripButton.Text = "帮助(&L)"
        '
        'tspFormatting
        '
        Me.tspFormatting.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.tspFormatting.Location = New System.Drawing.Point(0, 49)
        Me.tspFormatting.Name = "tspFormatting"
        Me.tspFormatting.Size = New System.Drawing.Size(413, 25)
        Me.tspFormatting.TabIndex = 2
        Me.tspFormatting.Text = "ToolStrip2"
        Me.tspFormatting.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Windows_Forms_Menus.My.Resources.Resources._6f86dff2jw1dpeun8e6y0g
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(413, 181)
        Me.Panel1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox2.Location = New System.Drawing.Point(27, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(300, 21)
        Me.TextBox2.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextUndoToolStripMenuItem, Me.ToolStripSeparator8, Me.ContextCutToolStropMenuItem, Me.ToolStripSeparator9})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 60)
        '
        'ContextUndoToolStripMenuItem
        '
        Me.ContextUndoToolStripMenuItem.Image = Global.Windows_Forms_Menus.My.Resources.Resources._2b
        Me.ContextUndoToolStripMenuItem.Name = "ContextUndoToolStripMenuItem"
        Me.ContextUndoToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ContextUndoToolStripMenuItem.Text = "Undo"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(105, 6)
        '
        'ContextCutToolStropMenuItem
        '
        Me.ContextCutToolStropMenuItem.Image = CType(resources.GetObject("ContextCutToolStropMenuItem.Image"), System.Drawing.Image)
        Me.ContextCutToolStropMenuItem.Name = "ContextCutToolStropMenuItem"
        Me.ContextCutToolStropMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ContextCutToolStropMenuItem.Text = "Cut"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(105, 6)
        '
        'TextBox1
        '
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Location = New System.Drawing.Point(27, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(300, 21)
        Me.TextBox1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 230)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tspFormatting)
        Me.Controls.Add(Me.tspMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Demo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tspMain.ResumeLayout(False)
        Me.tspMain.PerformLayout()
        Me.tspFormatting.ResumeLayout(False)
        Me.tspFormatting.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 文件FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 新建NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 打开OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 保存SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 另存为AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 打印PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 打印预览VToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 退出XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 编辑EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 撤消UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重复RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 剪切TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 复制CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 粘贴PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 全选AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 工具TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 自定义CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 选项OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 内容CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 索引IToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 搜索SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 关于AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolbarsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormattingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspMain As System.Windows.Forms.ToolStrip
    Friend WithEvents 新建NToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 打开OToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 保存SToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 打印PToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 剪切UToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 复制CToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 粘贴PToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 帮助LToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspFormatting As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextUndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextCutToolStropMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
