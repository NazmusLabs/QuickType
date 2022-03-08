<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickType
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordWrapMenuToggle = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowStatusBarMenuToggle = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorStatusBar = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextEditor = New System.Windows.Forms.TextBox()
        Me.EditorFontDialog = New System.Windows.Forms.FontDialog()
        Me.MenuStrip.SuspendLayout()
        Me.EditorStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 36)
        Me.MenuStrip.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 32)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.Name = "ExitMenuItem"
        Me.ExitMenuItem.Size = New System.Drawing.Size(141, 34)
        Me.ExitMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 32)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.WordWrapMenuToggle})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(85, 32)
        Me.FormatToolStripMenuItem.Text = "F&ormat"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.FontToolStripMenuItem.Text = "&Font"
        '
        'WordWrapMenuToggle
        '
        Me.WordWrapMenuToggle.Name = "WordWrapMenuToggle"
        Me.WordWrapMenuToggle.Size = New System.Drawing.Size(270, 34)
        Me.WordWrapMenuToggle.Text = "&Word Wrap"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowStatusBarMenuToggle})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(65, 32)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'ShowStatusBarMenuToggle
        '
        Me.ShowStatusBarMenuToggle.Checked = True
        Me.ShowStatusBarMenuToggle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowStatusBarMenuToggle.Name = "ShowStatusBarMenuToggle"
        Me.ShowStatusBarMenuToggle.Size = New System.Drawing.Size(270, 34)
        Me.ShowStatusBarMenuToggle.Text = "&Status Bar"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 32)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'EditorStatusBar
        '
        Me.EditorStatusBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.EditorStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.EditorStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.EditorStatusBar.Name = "EditorStatusBar"
        Me.EditorStatusBar.Size = New System.Drawing.Size(800, 32)
        Me.EditorStatusBar.TabIndex = 1
        Me.EditorStatusBar.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(785, 25)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextEditor
        '
        Me.TextEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextEditor.Location = New System.Drawing.Point(0, 36)
        Me.TextEditor.Multiline = True
        Me.TextEditor.Name = "TextEditor"
        Me.TextEditor.Size = New System.Drawing.Size(800, 382)
        Me.TextEditor.TabIndex = 2
        Me.TextEditor.WordWrap = False
        '
        'EditorFontDialog
        '
        Me.EditorFontDialog.Font = New System.Drawing.Font("Cascadia Code SemiLight", 12.0!, System.Drawing.FontStyle.Italic)
        '
        'QuickType
        '
        Me.AccessibleName = "QuickType"
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextEditor)
        Me.Controls.Add(Me.EditorStatusBar)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "QuickType"
        Me.Text = "QuickType GO!"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.EditorStatusBar.ResumeLayout(False)
        Me.EditorStatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitMenuItem As ToolStripMenuItem
    Friend WithEvents ShowStatusBarMenuToggle As ToolStripMenuItem
    Friend WithEvents EditorStatusBar As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TextEditor As TextBox
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordWrapMenuToggle As ToolStripMenuItem
    Friend WithEvents EditorFontDialog As FontDialog
End Class
