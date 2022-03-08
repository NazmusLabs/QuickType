
'In the Name of Allah, the Most Gracious, Most Merciful.
'--------------------------------------------------------
' NazmusLabs QuickType GO! Text Editor
'   Version: 0.1.22.308 Pre-Alpha
'   Patch Version: 011.22.308a04D

' © 2022 NazmusLabs. Some Rights Reserved.

'                           ~~~


' 📢 What's New in QuickType GO! 0.x
'   ▶ Building the foundations of QuickType GO!
'   ▶ TBD (Insha'Allah)
'   ▶ 

' 📜 Patch Notes
' -----------------
' Patch 011.22.308a04D
'   ▶ Building the foundations of QuickType
'   ▶ Application now compiles in x64 by default. Application development will, Insha'Allah, primarily focus on targetting 64-Bit platforms, with consideration for builds of 32-bit binaries as second priority.
'   ▶ TBD (Insha'Allah)
'   ▶ [ADDED] documentation content, including version information and this patch notes.
'   ▶ v0.1.22.308 (Pre Alpha)

' Patch 010.22.308a03C
'   ▶ Building the foundations of QuickType
'   ▶ [REMOVED] dark mode introduced in previous patch. Although it's implimentation worked & looked well (Alhamdullillah), work on this is set aside for the time being, and the feature may return at a future build, Insha'Allah.
'   ▶ v0.1.22.307 (Pre Alpha)

' Patch 010.22.306a02B
'   ▶ Building the foundations of QuickType
'   ▶ [ADDED] experimental dark mode to the menu bar, menus, text field, and status bar. The title bar did not receive this change.
'   ▶ v0.1.22.306 (Pre Alpha)

' Patch N/A
'   ▶ This is the working version of "NazmusLabs QuickType GO!"
'   ▶ Building the foundations of QuickType
'   ▶
'   ▶ v0.1.22.305 (First Build)

Public Class QuickType
    Private Sub QuickType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '⏳ Starting up...

    End Sub

    '🔧 Status bar visibility toggle
    Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        '⏳ Setting user configuration...
        If StatusBarToolStripMenuItem.Checked Then
            StatusStrip.Hide()
            StatusBarToolStripMenuItem.Checked = False
        Else
            StatusStrip.Show()
            StatusBarToolStripMenuItem.Checked = True
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        '⏳ Exiting...
        Application.Exit()
    End Sub

End Class
