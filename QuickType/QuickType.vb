
'In the Name of Allah, the Most Gracious, Most Merciful.
'--------------------------------------------------------
' NazmusLabs QuickType GO! Text Editor
'   Version: 0.1.22.309 (Pre-Alpha)
'   Patch Version: 012.22.308a05E

' © 2022 NazmusLabs. Some Rights Reserved.

'                           ~~~


' 📢 What's New in QuickType GO! 0.x
'   ▶ Building the foundations of QuickType GO!
'   ▶ TBD (Insha'Allah)
'   ▶ 

' 📜 Patch Notes
' -----------------
' Patch 012.22.308a05E
'   ▶ This release continues building the foundations.
'   ▶ [ADDED] the ability to enable/disable word wrap
'   ▶ [ADDED] the ability to set editor font
'   ▶ [UPDATED] default font property of the text editor is changed to "Cascadia Code SemiLight, 12pt, style=Italic"
'   ▶ [UPDATED] documentation content with in-line comments throughout to explain what most of the code does, Alhamdullillah.
'   ▶ [REMOVED] Patch notes for all previous versions. They are now included in a seperate file.
'   ▶ v0.1.22.309 (Pre Alpha)

Public Class QuickType
    '🔄️ Startup rutines
    Private Sub QuickType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '⏳ Loading user settings...
        'EditorFontDialog = ?
        TextEditor.Font = EditorFontDialog.Font
        TextEditor.WordWrap = False
        EditorStatusBar.Visible = True

    End Sub

    '🔧 Set status bar visibility toggle
    Private Sub ShowStatusBarMenuToggle_Click(sender As Object, e As EventArgs) Handles ShowStatusBarMenuToggle.Click
        '⏳ Loading settings...
        If ShowStatusBarMenuToggle.Checked Then
            '⏳ Applying user configuration...
            EditorStatusBar.Hide()
            ShowStatusBarMenuToggle.Checked = False
        Else
            '⏳ Applying user configuration...
            EditorStatusBar.Show()
            ShowStatusBarMenuToggle.Checked = True
        End If
        '⏳ Saving user configurations...
    End Sub

    '🔧 Set Word Wrap toggle
    Private Sub WordWrapMenuToggle_Click(sender As Object, e As EventArgs) Handles WordWrapMenuToggle.Click
        '⏳ Setting user configuration...
        If WordWrapMenuToggle.Checked Then
            TextEditor.WordWrap = False
            WordWrapMenuToggle.Checked = False
        Else
            TextEditor.WordWrap = True
            WordWrapMenuToggle.Checked = True
        End If
    End Sub

    '🔧 Set Font
    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        '⏳ Opening Font dialogue...

        'EditorFontDialog.ShowDialog() <- ⚠️ Obsolete code

        If EditorFontDialog.ShowDialog = DialogResult.OK Then   '💡 Full string for accessing this property: Windows.Forms.DialogResult.OK

            '⏳ Applying user configurations...
            TextEditor.Font = EditorFontDialog.Font

            '⏳ Saving user configurations...

            '⚠️ Debug code (💡 Should remain disabled in production builds)
            'MsgBox("Font selected: " + EditorFontDialog.Font.ToString + " " + TextEditor.Font.ToString)

        End If
    End Sub

    '⚡ User Action
    Private Sub ExitMenuItem_Click(sender As Object, e As EventArgs) Handles ExitMenuItem.Click
        '⏳ Exiting...
        Application.Exit()
    End Sub

End Class
