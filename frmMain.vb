Imports System.ComponentModel

Public Class frmMain
    Public Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean

    Private Sub txtFileList_DragDrop(sender As Object, e As DragEventArgs) Handles txtFileList.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        If chkOverWriteOnDragDrop.Checked Then txtFileList.Clear()
        For Each path In files
            txtFileList.Text += path + vbNewLine
        Next
    End Sub

    Private Sub txtFileList_DragEnter(sender As Object, e As DragEventArgs) Handles txtFileList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        If chkDisableX64FileRedirection.Checked Then    'Needed on x64 systems, since wsl.exe is 32 bit only.
            Wow64DisableWow64FsRedirection(0)
        End If

        For Each s As String In txtFileList.Lines
            If System.IO.File.Exists(s) Then    'Check file exists (or has been created, if reading from GW)
                If txtCmd.Text.Trim <> "" Then    'Check script exists
                    System.Diagnostics.Process.Start(txtCmd.Text.Trim, txtParams.Text.Replace("%FILENAME", ControlChars.Quote + s + ControlChars.Quote))
                End If
            End If
        Next
        If chkClearAfterExecute.Checked Then txtFileList.Clear()
    End Sub

    Private Sub BtnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        txtFileList.Clear()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.CleafAfterExec = chkClearAfterExecute.Checked
        My.Settings.ClearAfterDrag = chkOverWriteOnDragDrop.Checked
        My.Settings.Exec = txtCmd.Text
        My.Settings.Param = txtParams.Text
        My.Settings.List = txtFileList.Text
        My.Settings.DisableX64FileRedirection = chkDisableX64FileRedirection.Checked
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        chkClearAfterExecute.Checked = My.Settings.CleafAfterExec
        chkOverWriteOnDragDrop.Checked = My.Settings.ClearAfterDrag
        txtCmd.Text = My.Settings.Exec
        txtParams.Text = My.Settings.Param
        txtFileList.Text = My.Settings.List
        chkDisableX64FileRedirection.Checked = My.Settings.DisableX64FileRedirection

        ToolTipMain.SetToolTip(txtParams, "Place command line arguments here. %FILENAME is the variable for the files in the list above.")
        ToolTipMain.SetToolTip(txtCmd, "Command to execute. Command line may include spaces etc.")
        ToolTipMain.SetToolTip(btnClearList, "Clear the list now.")
        ToolTipMain.SetToolTip(btnExecute, "Execute the command in the command box.")
        ToolTipMain.SetToolTip(chkClearAfterExecute, "Clear the list after execution.")
        ToolTipMain.SetToolTip(chkOverWriteOnDragDrop, "Clear the list as you drag and drop in new files. Only useful to batches. Usually leave unticked.")
        ToolTipMain.SetToolTip(txtFileList, "Drag and drop files here to process. Can also paste in a list of files eg from a text editor etc.")
        ToolTipMain.SetToolTip(chkDisableX64FileRedirection, "Disable Windows System32 to SysWOW64 redirection. (On x64 Windows)")
    End Sub
End Class
