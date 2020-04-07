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
        Me.SuspendLayout()
        '
        'txtParams
        '
        Me.txtParams.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParams.Location = New System.Drawing.Point(12, 447)
        Me.txtParams.Name = "txtParams"
        Me.txtParams.Size = New System.Drawing.Size(402, 20)
        Me.txtParams.TabIndex = 1
        Me.txtParams.Text = "%FILENAME 0"
        '
        'txtCmd
        '
        Me.txtCmd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCmd.Location = New System.Drawing.Point(12, 421)
        Me.txtCmd.Name = "txtCmd"
        Me.txtCmd.Size = New System.Drawing.Size(402, 20)
        Me.txtCmd.TabIndex = 2
        Me.txtCmd.Text = "trunc.exe"
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.Location = New System.Drawing.Point(12, 473)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(402, 22)
        Me.btnExecute.TabIndex = 3
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
        Me.txtFileList.Size = New System.Drawing.Size(402, 375)
        Me.txtFileList.TabIndex = 4
        '
        'chkOverWriteOnDragDrop
        '
        Me.chkOverWriteOnDragDrop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkOverWriteOnDragDrop.AutoSize = True
        Me.chkOverWriteOnDragDrop.Location = New System.Drawing.Point(12, 397)
        Me.chkOverWriteOnDragDrop.Name = "chkOverWriteOnDragDrop"
        Me.chkOverWriteOnDragDrop.Size = New System.Drawing.Size(145, 17)
        Me.chkOverWriteOnDragDrop.TabIndex = 5
        Me.chkOverWriteOnDragDrop.Text = "Clear &List on Drag && Drop"
        Me.chkOverWriteOnDragDrop.UseVisualStyleBackColor = True
        '
        'btnClearList
        '
        Me.btnClearList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearList.Location = New System.Drawing.Point(313, 393)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(101, 22)
        Me.btnClearList.TabIndex = 6
        Me.btnClearList.Text = "&Clear List"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'chkClearAfterExecute
        '
        Me.chkClearAfterExecute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkClearAfterExecute.AutoSize = True
        Me.chkClearAfterExecute.Location = New System.Drawing.Point(176, 398)
        Me.chkClearAfterExecute.Name = "chkClearAfterExecute"
        Me.chkClearAfterExecute.Size = New System.Drawing.Size(117, 17)
        Me.chkClearAfterExecute.TabIndex = 7
        Me.chkClearAfterExecute.Text = "Clear &After Execute"
        Me.chkClearAfterExecute.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 507)
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
End Class
