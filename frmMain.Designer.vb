<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtParams = New System.Windows.Forms.TextBox()
        Me.txtCmd = New System.Windows.Forms.TextBox()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.txtFileList = New System.Windows.Forms.TextBox()
        Me.chkOverWriteOnDragDrop = New System.Windows.Forms.CheckBox()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.chkClearAfterExecute = New System.Windows.Forms.CheckBox()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkDisableX64FileRedirection = New System.Windows.Forms.CheckBox()
        Me.lblCMD = New System.Windows.Forms.Label()
        Me.lblArgument = New System.Windows.Forms.Label()
        Me.chkWaitForExit = New System.Windows.Forms.CheckBox()
        Me.chkRunMinimized = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtParams
        '
        Me.txtParams.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParams.Location = New System.Drawing.Point(72, 456)
        Me.txtParams.Name = "txtParams"
        Me.txtParams.Size = New System.Drawing.Size(349, 20)
        Me.txtParams.TabIndex = 20
        Me.txtParams.Text = "%FILENAME 0"
        '
        'txtCmd
        '
        Me.txtCmd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCmd.Location = New System.Drawing.Point(72, 430)
        Me.txtCmd.Name = "txtCmd"
        Me.txtCmd.Size = New System.Drawing.Size(349, 20)
        Me.txtCmd.TabIndex = 18
        Me.txtCmd.Text = "trunc.exe"
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.Location = New System.Drawing.Point(12, 482)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(409, 22)
        Me.btnExecute.TabIndex = 22
        Me.btnExecute.Text = "&Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'txtFileList
        '
        Me.txtFileList.AllowDrop = True
        Me.txtFileList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileList.Location = New System.Drawing.Point(12, 12)
        Me.txtFileList.Multiline = True
        Me.txtFileList.Name = "txtFileList"
        Me.txtFileList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFileList.Size = New System.Drawing.Size(409, 345)
        Me.txtFileList.TabIndex = 4
        '
        'chkOverWriteOnDragDrop
        '
        Me.chkOverWriteOnDragDrop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkOverWriteOnDragDrop.AutoSize = True
        Me.chkOverWriteOnDragDrop.Location = New System.Drawing.Point(12, 386)
        Me.chkOverWriteOnDragDrop.Name = "chkOverWriteOnDragDrop"
        Me.chkOverWriteOnDragDrop.Size = New System.Drawing.Size(145, 17)
        Me.chkOverWriteOnDragDrop.TabIndex = 8
        Me.chkOverWriteOnDragDrop.Text = "Clear &List on Drag && Drop"
        Me.chkOverWriteOnDragDrop.UseVisualStyleBackColor = True
        '
        'btnClearList
        '
        Me.btnClearList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearList.Location = New System.Drawing.Point(303, 386)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(118, 38)
        Me.btnClearList.TabIndex = 16
        Me.btnClearList.Text = "&Clear List"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'chkClearAfterExecute
        '
        Me.chkClearAfterExecute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkClearAfterExecute.AutoSize = True
        Me.chkClearAfterExecute.Location = New System.Drawing.Point(12, 409)
        Me.chkClearAfterExecute.Name = "chkClearAfterExecute"
        Me.chkClearAfterExecute.Size = New System.Drawing.Size(136, 17)
        Me.chkClearAfterExecute.TabIndex = 10
        Me.chkClearAfterExecute.Text = "Clear List &After Execute"
        Me.chkClearAfterExecute.UseVisualStyleBackColor = True
        '
        'chkDisableX64FileRedirection
        '
        Me.chkDisableX64FileRedirection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkDisableX64FileRedirection.AutoSize = True
        Me.chkDisableX64FileRedirection.Location = New System.Drawing.Point(12, 363)
        Me.chkDisableX64FileRedirection.Name = "chkDisableX64FileRedirection"
        Me.chkDisableX64FileRedirection.Size = New System.Drawing.Size(285, 17)
        Me.chkDisableX64FileRedirection.TabIndex = 6
        Me.chkDisableX64FileRedirection.Text = "Disable x&64 File redirection (System32 -> SYSWOW64)"
        Me.chkDisableX64FileRedirection.UseVisualStyleBackColor = True
        '
        'lblCMD
        '
        Me.lblCMD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCMD.AutoSize = True
        Me.lblCMD.Location = New System.Drawing.Point(12, 433)
        Me.lblCMD.Name = "lblCMD"
        Me.lblCMD.Size = New System.Drawing.Size(54, 13)
        Me.lblCMD.TabIndex = 9
        Me.lblCMD.Text = "Command"
        '
        'lblArgument
        '
        Me.lblArgument.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblArgument.AutoSize = True
        Me.lblArgument.Location = New System.Drawing.Point(12, 459)
        Me.lblArgument.Name = "lblArgument"
        Me.lblArgument.Size = New System.Drawing.Size(52, 13)
        Me.lblArgument.TabIndex = 10
        Me.lblArgument.Text = "Argument"
        '
        'chkWaitForExit
        '
        Me.chkWaitForExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkWaitForExit.AutoSize = True
        Me.chkWaitForExit.Location = New System.Drawing.Point(202, 386)
        Me.chkWaitForExit.Name = "chkWaitForExit"
        Me.chkWaitForExit.Size = New System.Drawing.Size(83, 17)
        Me.chkWaitForExit.TabIndex = 12
        Me.chkWaitForExit.Text = "Wait for Exit"
        Me.chkWaitForExit.UseVisualStyleBackColor = True
        '
        'chkRunMinimized
        '
        Me.chkRunMinimized.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkRunMinimized.AutoSize = True
        Me.chkRunMinimized.Location = New System.Drawing.Point(202, 409)
        Me.chkRunMinimized.Name = "chkRunMinimized"
        Me.chkRunMinimized.Size = New System.Drawing.Size(95, 17)
        Me.chkRunMinimized.TabIndex = 14
        Me.chkRunMinimized.Text = "Run &Minimized"
        Me.chkRunMinimized.ThreeState = True
        Me.chkRunMinimized.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 516)
        Me.Controls.Add(Me.chkRunMinimized)
        Me.Controls.Add(Me.chkWaitForExit)
        Me.Controls.Add(Me.lblArgument)
        Me.Controls.Add(Me.lblCMD)
        Me.Controls.Add(Me.chkDisableX64FileRedirection)
        Me.Controls.Add(Me.chkClearAfterExecute)
        Me.Controls.Add(Me.btnClearList)
        Me.Controls.Add(Me.chkOverWriteOnDragDrop)
        Me.Controls.Add(Me.txtFileList)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.txtCmd)
        Me.Controls.Add(Me.txtParams)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Execute Multiple Files"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtParams As TextBox
    Friend WithEvents txtCmd As TextBox
    Friend WithEvents btnExecute As Button
    Friend WithEvents txtFileList As TextBox
    Friend WithEvents chkOverWriteOnDragDrop As CheckBox
    Friend WithEvents btnClearList As Button
    Friend WithEvents chkClearAfterExecute As CheckBox
    Friend WithEvents ToolTipMain As ToolTip
    Friend WithEvents chkDisableX64FileRedirection As CheckBox
    Friend WithEvents lblCMD As Label
    Friend WithEvents lblArgument As Label
    Friend WithEvents chkWaitForExit As CheckBox
    Friend WithEvents chkRunMinimized As CheckBox
End Class
