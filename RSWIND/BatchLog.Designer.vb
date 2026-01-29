Namespace RSWINV3
	Friend Partial Class BatchLog
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(Disposing As Boolean)
			If Disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(Disposing)
		End Sub

		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.prgPercentComplete = New Global.System.Windows.Forms.ProgressBar()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.lblFilesComplete = New Global.System.Windows.Forms.Label()
			Me.c = New Global.System.Windows.Forms.Label()
			Me._Label_1 = New Global.System.Windows.Forms.Label()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me.lblCompleted = New Global.System.Windows.Forms.Label()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.btnSort = New Global.System.Windows.Forms.Button()
			Me.btnAcceptGuruRun = New Global.System.Windows.Forms.Button()
			Me.btnAcceptAllGuruRun = New Global.System.Windows.Forms.Button()
			Me.pnlBatchLog = New Global.System.Windows.Forms.Panel()
			Me.ulgBatchLog = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me.lblStatus = New Global.System.Windows.Forms.Label()
			Me.Panel1.SuspendLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlBatchLog.SuspendLayout()
			CType(Me.ulgBatchLog, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(745, 8)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(80, 24)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 2
			Me.cmdCancel.Text = "Cancel"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.prgPercentComplete.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim prgPercentComplete As Global.System.Windows.Forms.Control = Me.prgPercentComplete
			location = New Global.System.Drawing.Point(224, 16)
			prgPercentComplete.Location = location
			Me.prgPercentComplete.Name = "prgPercentComplete"
			Dim prgPercentComplete2 As Global.System.Windows.Forms.Control = Me.prgPercentComplete
			size = New Global.System.Drawing.Size(504, 16)
			prgPercentComplete2.Size = size
			Me.prgPercentComplete.[Step] = 1
			Me.prgPercentComplete.TabIndex = 5
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.Panel1.Controls.Add(Me.lblFilesComplete)
			Me.Panel1.Controls.Add(Me.c)
			Me.Panel1.Controls.Add(Me._Label_1)
			Me.Panel1.Controls.Add(Me._Label_0)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(8, 8)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(208, 40)
			panel2.Size = size
			Me.Panel1.TabIndex = 6
			Me.lblFilesComplete.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblFilesComplete.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblFilesComplete.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.lblFilesComplete.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lblFilesComplete.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblFilesComplete As Global.System.Windows.Forms.Control = Me.lblFilesComplete
			location = New Global.System.Drawing.Point(160, 16)
			lblFilesComplete.Location = location
			Me.lblFilesComplete.Name = "lblFilesComplete"
			Me.lblFilesComplete.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblFilesComplete2 As Global.System.Windows.Forms.Control = Me.lblFilesComplete
			size = New Global.System.Drawing.Size(31, 13)
			lblFilesComplete2.Size = size
			Me.lblFilesComplete.TabIndex = 10
			Me.lblFilesComplete.Text = "0"
			Me.lblFilesComplete.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.c.BackColor = Global.System.Drawing.Color.Transparent
			Me.c.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.c.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.c.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.c.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim c As Global.System.Windows.Forms.Control = Me.c
			location = New Global.System.Drawing.Point(160, 0)
			c.Location = location
			Me.c.Name = "c"
			Me.c.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim c2 As Global.System.Windows.Forms.Control = Me.c
			size = New Global.System.Drawing.Size(31, 13)
			c2.Size = size
			Me.c.TabIndex = 11
			Me.c.Text = "0"
			Me.c.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_1.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me._Label_1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_1
			location = New Global.System.Drawing.Point(8, 16)
			label_.Location = location
			Me._Label_1.Name = "_Label_1"
			Me._Label_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_1
			size = New Global.System.Drawing.Size(136, 16)
			label_2.Size = size
			Me._Label_1.TabIndex = 12
			Me._Label_1.Text = "Files complete: "
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_3 As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(8, 0)
			label_3.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_4 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(136, 13)
			label_4.Size = size
			Me._Label_0.TabIndex = 13
			Me._Label_0.Text = "Files selected: "
			Me.lblCompleted.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCompleted.ForeColor = Global.System.Drawing.Color.Blue
			Me.lblCompleted.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCompleted As Global.System.Windows.Forms.Control = Me.lblCompleted
			location = New Global.System.Drawing.Point(224, 32)
			lblCompleted.Location = location
			Me.lblCompleted.Name = "lblCompleted"
			Dim lblCompleted2 As Global.System.Windows.Forms.Control = Me.lblCompleted
			size = New Global.System.Drawing.Size(504, 24)
			lblCompleted2.Size = size
			Me.lblCompleted.TabIndex = 8
			Me.lblCompleted.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnSort.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnSort.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnSort.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.btnSort.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnSort.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnSort.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnSort As Global.System.Windows.Forms.Control = Me.btnSort
			location = New Global.System.Drawing.Point(745, 36)
			btnSort.Location = location
			Me.btnSort.Name = "btnSort"
			Me.btnSort.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim btnSort2 As Global.System.Windows.Forms.Control = Me.btnSort
			size = New Global.System.Drawing.Size(80, 23)
			btnSort2.Size = size
			Me.btnSort.TabIndex = 9
			Me.btnSort.Text = "Sort"
			Me.btnSort.UseVisualStyleBackColor = False
			Me.btnSort.Visible = False
			Me.btnAcceptGuruRun.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnAcceptGuruRun.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnAcceptGuruRun.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.btnAcceptGuruRun.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnAcceptGuruRun.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnAcceptGuruRun.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnAcceptGuruRun As Global.System.Windows.Forms.Control = Me.btnAcceptGuruRun
			location = New Global.System.Drawing.Point(829, 8)
			btnAcceptGuruRun.Location = location
			Me.btnAcceptGuruRun.Name = "btnAcceptGuruRun"
			Me.btnAcceptGuruRun.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim btnAcceptGuruRun2 As Global.System.Windows.Forms.Control = Me.btnAcceptGuruRun
			size = New Global.System.Drawing.Size(88, 24)
			btnAcceptGuruRun2.Size = size
			Me.btnAcceptGuruRun.TabIndex = 10
			Me.btnAcceptGuruRun.Text = "Save Case"
			Me.btnAcceptGuruRun.UseVisualStyleBackColor = False
			Me.btnAcceptGuruRun.Visible = False
			Me.btnAcceptAllGuruRun.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnAcceptAllGuruRun.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnAcceptAllGuruRun.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.btnAcceptAllGuruRun.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnAcceptAllGuruRun.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnAcceptAllGuruRun.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnAcceptAllGuruRun As Global.System.Windows.Forms.Control = Me.btnAcceptAllGuruRun
			location = New Global.System.Drawing.Point(830, 36)
			btnAcceptAllGuruRun.Location = location
			Me.btnAcceptAllGuruRun.Name = "btnAcceptAllGuruRun"
			Me.btnAcceptAllGuruRun.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim btnAcceptAllGuruRun2 As Global.System.Windows.Forms.Control = Me.btnAcceptAllGuruRun
			size = New Global.System.Drawing.Size(88, 23)
			btnAcceptAllGuruRun2.Size = size
			Me.btnAcceptAllGuruRun.TabIndex = 11
			Me.btnAcceptAllGuruRun.Text = "Save All"
			Me.btnAcceptAllGuruRun.UseVisualStyleBackColor = False
			Me.btnAcceptAllGuruRun.Visible = False
			Me.pnlBatchLog.Controls.Add(Me.ulgBatchLog)
			Dim pnlBatchLog As Global.System.Windows.Forms.Control = Me.pnlBatchLog
			location = New Global.System.Drawing.Point(8, 65)
			pnlBatchLog.Location = location
			Me.pnlBatchLog.Name = "pnlBatchLog"
			Dim pnlBatchLog2 As Global.System.Windows.Forms.Control = Me.pnlBatchLog
			size = New Global.System.Drawing.Size(912, 480)
			pnlBatchLog2.Size = size
			Me.pnlBatchLog.TabIndex = 15
			Me.ulgBatchLog.AllowDrop = True
			Me.ulgBatchLog.DisplayLayout.ScrollBounds = Global.Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
			Me.ulgBatchLog.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim ulgBatchLog As Global.System.Windows.Forms.Control = Me.ulgBatchLog
			location = New Global.System.Drawing.Point(0, 0)
			ulgBatchLog.Location = location
			Me.ulgBatchLog.Name = "ulgBatchLog"
			Dim ulgBatchLog2 As Global.System.Windows.Forms.Control = Me.ulgBatchLog
			size = New Global.System.Drawing.Size(912, 399)
			ulgBatchLog2.Size = size
			Me.ulgBatchLog.SyncWithCurrencyManager = False
			Me.ulgBatchLog.TabIndex = 13
			Me.lblStatus.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.lblStatus.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblStatus.ForeColor = Global.System.Drawing.Color.Green
			Dim lblStatus As Global.System.Windows.Forms.Control = Me.lblStatus
			location = New Global.System.Drawing.Point(0, 549)
			lblStatus.Location = location
			Me.lblStatus.Name = "lblStatus"
			Dim lblStatus2 As Global.System.Windows.Forms.Control = Me.lblStatus
			size = New Global.System.Drawing.Size(937, 16)
			lblStatus2.Size = size
			Me.lblStatus.TabIndex = 16
			Me.lblStatus.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			Me.CancelButton = Me.cmdCancel
			size = New Global.System.Drawing.Size(937, 565)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.lblStatus)
			Me.Controls.Add(Me.pnlBatchLog)
			Me.Controls.Add(Me.btnSort)
			Me.Controls.Add(Me.prgPercentComplete)
			Me.Controls.Add(Me.lblCompleted)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.btnAcceptAllGuruRun)
			Me.Controls.Add(Me.btnAcceptGuruRun)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			location = New Global.System.Drawing.Point(191, 256)
			Me.Location = location
			Me.Name = "BatchLog"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Batch Run Log"
			Me.Panel1.ResumeLayout(False)
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlBatchLog.ResumeLayout(False)
			CType(Me.ulgBatchLog, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
