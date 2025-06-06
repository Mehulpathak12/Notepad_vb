<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NEWToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        RedoToolStripMenuItem = New ToolStripMenuItem()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        FormatToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem1 = New ToolStripMenuItem()
        CToolStripMenuItem = New ToolStripMenuItem()
        BackColorToolStripMenuItem = New ToolStripMenuItem()
        ToolsToolStripMenuItem = New ToolStripMenuItem()
        WordWrapToolStripMenuItem1 = New ToolStripMenuItem()
        AISupportToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        RichTextBox1 = New RichTextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        FixGrammarErrorsToolStripMenuItem = New ToolStripMenuItem()
        SummarizeThisSelectedTextToolStripMenuItem = New ToolStripMenuItem()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        PrintDialog1 = New PrintDialog()
        FontDialog1 = New FontDialog()
        ColorDialog1 = New ColorDialog()
        StatusStrip1 = New StatusStrip()
        lblLineCount = New ToolStripStatusLabel()
        lblWordCount = New ToolStripStatusLabel()
        lblCursorPos = New ToolStripStatusLabel()
        MenuStrip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, FormatToolStripMenuItem, ToolsToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1199, 36)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NEWToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripMenuItem1, PrintToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(56, 32)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NEWToolStripMenuItem
        ' 
        NEWToolStripMenuItem.Name = "NEWToolStripMenuItem"
        NEWToolStripMenuItem.Size = New Size(165, 32)
        NEWToolStripMenuItem.Text = "New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(165, 32)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(165, 32)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(165, 32)
        SaveAsToolStripMenuItem.Text = "Save As"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(165, 32)
        ToolStripMenuItem1.Text = "Close"
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.Size = New Size(165, 32)
        PrintToolStripMenuItem.Text = "Print"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(165, 32)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FontToolStripMenuItem, RedoToolStripMenuItem, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, SelectAllToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(60, 32)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(178, 32)
        FontToolStripMenuItem.Text = "Undo"
        ' 
        ' RedoToolStripMenuItem
        ' 
        RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        RedoToolStripMenuItem.Size = New Size(178, 32)
        RedoToolStripMenuItem.Text = "Redo"
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.Size = New Size(178, 32)
        CutToolStripMenuItem.Text = "Cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.Size = New Size(178, 32)
        CopyToolStripMenuItem.Text = "Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(178, 32)
        PasteToolStripMenuItem.Text = "Paste"
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.Size = New Size(178, 32)
        SelectAllToolStripMenuItem.Text = "Select All"
        ' 
        ' FormatToolStripMenuItem
        ' 
        FormatToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FontToolStripMenuItem1, CToolStripMenuItem, BackColorToolStripMenuItem})
        FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        FormatToolStripMenuItem.Size = New Size(89, 32)
        FormatToolStripMenuItem.Text = "Format"
        ' 
        ' FontToolStripMenuItem1
        ' 
        FontToolStripMenuItem1.Name = "FontToolStripMenuItem1"
        FontToolStripMenuItem1.Size = New Size(191, 32)
        FontToolStripMenuItem1.Text = "Font"
        ' 
        ' CToolStripMenuItem
        ' 
        CToolStripMenuItem.Name = "CToolStripMenuItem"
        CToolStripMenuItem.Size = New Size(191, 32)
        CToolStripMenuItem.Text = "Color"
        ' 
        ' BackColorToolStripMenuItem
        ' 
        BackColorToolStripMenuItem.Name = "BackColorToolStripMenuItem"
        BackColorToolStripMenuItem.Size = New Size(191, 32)
        BackColorToolStripMenuItem.Text = "Back Color"
        ' 
        ' ToolsToolStripMenuItem
        ' 
        ToolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {WordWrapToolStripMenuItem1, AISupportToolStripMenuItem})
        ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        ToolsToolStripMenuItem.Size = New Size(71, 32)
        ToolsToolStripMenuItem.Text = "Tools"
        ' 
        ' WordWrapToolStripMenuItem1
        ' 
        WordWrapToolStripMenuItem1.Name = "WordWrapToolStripMenuItem1"
        WordWrapToolStripMenuItem1.Size = New Size(200, 32)
        WordWrapToolStripMenuItem1.Text = "Word Wrap"
        ' 
        ' AISupportToolStripMenuItem
        ' 
        AISupportToolStripMenuItem.Name = "AISupportToolStripMenuItem"
        AISupportToolStripMenuItem.Size = New Size(200, 32)
        AISupportToolStripMenuItem.Text = "AI Support"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(67, 32)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.ContextMenuStrip = ContextMenuStrip1
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Location = New Point(0, 36)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(1199, 733)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {FixGrammarErrorsToolStripMenuItem, SummarizeThisSelectedTextToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(272, 80)
        ' 
        ' FixGrammarErrorsToolStripMenuItem
        ' 
        FixGrammarErrorsToolStripMenuItem.Name = "FixGrammarErrorsToolStripMenuItem"
        FixGrammarErrorsToolStripMenuItem.Size = New Size(271, 24)
        FixGrammarErrorsToolStripMenuItem.Text = "Fix grammar errors"
        ' 
        ' SummarizeThisSelectedTextToolStripMenuItem
        ' 
        SummarizeThisSelectedTextToolStripMenuItem.Name = "SummarizeThisSelectedTextToolStripMenuItem"
        SummarizeThisSelectedTextToolStripMenuItem.Size = New Size(271, 24)
        SummarizeThisSelectedTextToolStripMenuItem.Text = "Summarize this Selected Text"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = """Text Files (*.txt)|*.txt|Word Document (*.doc)|*.doc|Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*"""
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblLineCount, lblWordCount, lblCursorPos})
        StatusStrip1.Location = New Point(0, 743)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1199, 26)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblLineCount
        ' 
        lblLineCount.Name = "lblLineCount"
        lblLineCount.Size = New Size(92, 20)
        lblLineCount.Text = "lblLineCount"
        ' 
        ' lblWordCount
        ' 
        lblWordCount.Margin = New Padding(10, 4, 0, 2)
        lblWordCount.Name = "lblWordCount"
        lblWordCount.Size = New Size(101, 20)
        lblWordCount.Text = "lblWordCount"
        ' 
        ' lblCursorPos
        ' 
        lblCursorPos.Margin = New Padding(100, 4, 0, 2)
        lblCursorPos.Name = "lblCursorPos"
        lblCursorPos.Size = New Size(41, 20)
        lblCursorPos.Text = "ln&col"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1199, 769)
        Controls.Add(StatusStrip1)
        Controls.Add(RichTextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblLineCount As ToolStripStatusLabel
    Friend WithEvents lblWordCount As ToolStripStatusLabel
    Friend WithEvents lblCursorPos As ToolStripStatusLabel
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordWrapToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AISupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FixGrammarErrorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummarizeThisSelectedTextToolStripMenuItem As ToolStripMenuItem

End Class
