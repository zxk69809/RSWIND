Namespace RSWINV3
	Friend Partial Class dlgBatchOpts
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
			Me.cmdHelp = New Global.System.Windows.Forms.Button()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.cmdProceed = New Global.System.Windows.Forms.Button()
			Me.pnlBatch = New Global.System.Windows.Forms.Panel()
			Me.chkViewWorksheet = New Global.System.Windows.Forms.CheckBox()
			Me.chkSkipProcessedFiles = New Global.System.Windows.Forms.CheckBox()
			Me.chkSaveWorksheet = New Global.System.Windows.Forms.CheckBox()
			Me.chkPrintResults = New Global.System.Windows.Forms.CheckBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.chkCreatePDFs = New Global.System.Windows.Forms.CheckBox()
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.chkAutoPrintBatch = New Global.System.Windows.Forms.CheckBox()
			Me.pnlAutomatic = New Global.System.Windows.Forms.Panel()
			Me.lblAutoPrintBatchNote = New Global.System.Windows.Forms.Label()
			Me.lblDemoMode = New Global.System.Windows.Forms.Label()
			Me.pnlBatch.SuspendLayout()
			Me.pnlAutomatic.SuspendLayout()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.cmdHelp.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdHelp.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdHelp.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdHelp.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdHelp.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdHelp As Global.System.Windows.Forms.Control = Me.cmdHelp
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(574, 68)
			cmdHelp.Location = location
			Me.cmdHelp.Name = "cmdHelp"
			Me.cmdHelp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdHelp, False)
			Dim cmdHelp2 As Global.System.Windows.Forms.Control = Me.cmdHelp
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(80, 23)
			cmdHelp2.Size = size
			Me.cmdHelp.TabIndex = 7
			Me.cmdHelp.Text = "Help"
			Me.cmdHelp.UseVisualStyleBackColor = False
			Me.cmdHelp.Visible = False
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			location = New Global.System.Drawing.Point(574, 35)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdCancel, False)
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(80, 23)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 4
			Me.cmdCancel.Text = "Cancel"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.cmdProceed.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdProceed.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdProceed.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdProceed.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdProceed.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdProceed As Global.System.Windows.Forms.Control = Me.cmdProceed
			location = New Global.System.Drawing.Point(560, 8)
			cmdProceed.Location = location
			Me.cmdProceed.Name = "cmdProceed"
			Me.cmdProceed.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdProceed, False)
			Dim cmdProceed2 As Global.System.Windows.Forms.Control = Me.cmdProceed
			size = New Global.System.Drawing.Size(104, 23)
			cmdProceed2.Size = size
			Me.cmdProceed.TabIndex = 3
			Me.cmdProceed.Text = "Proceed"
			Me.cmdProceed.UseVisualStyleBackColor = False
			Me.pnlBatch.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlBatch.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.pnlBatch.Controls.Add(Me.chkViewWorksheet)
			Me.pnlBatch.Controls.Add(Me.chkSkipProcessedFiles)
			Me.pnlBatch.Controls.Add(Me.chkSaveWorksheet)
			Me.pnlBatch.Controls.Add(Me.chkPrintResults)
			Me.pnlBatch.Controls.Add(Me.Label1)
			Me.pnlBatch.Controls.Add(Me.chkCreatePDFs)
			Me.pnlBatch.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlBatch.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlBatch.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim pnlBatch As Global.System.Windows.Forms.Control = Me.pnlBatch
			location = New Global.System.Drawing.Point(8, 9)
			pnlBatch.Location = location
			Me.pnlBatch.Name = "pnlBatch"
			Me.pnlBatch.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.pnlBatch, False)
			Dim pnlBatch2 As Global.System.Windows.Forms.Control = Me.pnlBatch
			size = New Global.System.Drawing.Size(528, 160)
			pnlBatch2.Size = size
			Me.pnlBatch.TabIndex = 5
			Me.pnlBatch.TabStop = True
			Me.chkViewWorksheet.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.chkViewWorksheet.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkViewWorksheet As Global.System.Windows.Forms.Control = Me.chkViewWorksheet
			location = New Global.System.Drawing.Point(56, 80)
			chkViewWorksheet.Location = location
			Me.chkViewWorksheet.Name = "chkViewWorksheet"
			Me.HelpProvider1.SetShowHelp(Me.chkViewWorksheet, False)
			Dim chkViewWorksheet2 As Global.System.Windows.Forms.Control = Me.chkViewWorksheet
			size = New Global.System.Drawing.Size(406, 21)
			chkViewWorksheet2.Size = size
			Me.chkViewWorksheet.TabIndex = 9
			Me.chkViewWorksheet.Text = "View spreadsheet in Excel"
			Me.chkSkipProcessedFiles.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.chkSkipProcessedFiles.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkSkipProcessedFiles As Global.System.Windows.Forms.Control = Me.chkSkipProcessedFiles
			location = New Global.System.Drawing.Point(56, 129)
			chkSkipProcessedFiles.Location = location
			Me.chkSkipProcessedFiles.Name = "chkSkipProcessedFiles"
			Me.HelpProvider1.SetShowHelp(Me.chkSkipProcessedFiles, False)
			Dim chkSkipProcessedFiles2 As Global.System.Windows.Forms.Control = Me.chkSkipProcessedFiles
			size = New Global.System.Drawing.Size(406, 21)
			chkSkipProcessedFiles2.Size = size
			Me.chkSkipProcessedFiles.TabIndex = 10
			Me.chkSkipProcessedFiles.Text = "Don't re-run cases with saved output"
			Me.chkSaveWorksheet.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.chkSaveWorksheet.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkSaveWorksheet As Global.System.Windows.Forms.Control = Me.chkSaveWorksheet
			location = New Global.System.Drawing.Point(56, 56)
			chkSaveWorksheet.Location = location
			Me.chkSaveWorksheet.Name = "chkSaveWorksheet"
			Me.HelpProvider1.SetShowHelp(Me.chkSaveWorksheet, False)
			Dim chkSaveWorksheet2 As Global.System.Windows.Forms.Control = Me.chkSaveWorksheet
			size = New Global.System.Drawing.Size(406, 21)
			chkSaveWorksheet2.Size = size
			Me.chkSaveWorksheet.TabIndex = 8
			Me.chkSaveWorksheet.Text = "Create spreadsheet"
			Me.chkPrintResults.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.chkPrintResults.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkPrintResults As Global.System.Windows.Forms.Control = Me.chkPrintResults
			location = New Global.System.Drawing.Point(56, 32)
			chkPrintResults.Location = location
			Me.chkPrintResults.Name = "chkPrintResults"
			Me.HelpProvider1.SetShowHelp(Me.chkPrintResults, False)
			Dim chkPrintResults2 As Global.System.Windows.Forms.Control = Me.chkPrintResults
			size = New Global.System.Drawing.Size(406, 21)
			chkPrintResults2.Size = size
			Me.chkPrintResults.TabIndex = 7
			Me.chkPrintResults.Text = "Make printouts"
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.Label1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(40, 10)
			label.Location = location
			Me.Label1.Name = "Label1"
			Me.Label1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label1, False)
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(406, 19)
			label2.Size = size
			Me.Label1.TabIndex = 6
			Me.Label1.Text = "Select from the following batch run options:"
			Me.chkCreatePDFs.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkCreatePDFs, "Setup Batch: Skip Processed")
			Me.HelpProvider1.SetHelpNavigator(Me.chkCreatePDFs, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim chkCreatePDFs As Global.System.Windows.Forms.Control = Me.chkCreatePDFs
			location = New Global.System.Drawing.Point(56, 104)
			chkCreatePDFs.Location = location
			Me.chkCreatePDFs.Name = "chkCreatePDFs"
			Me.HelpProvider1.SetShowHelp(Me.chkCreatePDFs, True)
			Dim chkCreatePDFs2 As Global.System.Windows.Forms.Control = Me.chkCreatePDFs
			size = New Global.System.Drawing.Size(256, 21)
			chkCreatePDFs2.Size = size
			Me.chkCreatePDFs.TabIndex = 12
			Me.chkCreatePDFs.Text = "Create PDF files"
			Me.chkAutoPrintBatch.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.chkAutoPrintBatch.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkAutoPrintBatch As Global.System.Windows.Forms.Control = Me.chkAutoPrintBatch
			location = New Global.System.Drawing.Point(56, 8)
			chkAutoPrintBatch.Location = location
			Me.chkAutoPrintBatch.Name = "chkAutoPrintBatch"
			Me.HelpProvider1.SetShowHelp(Me.chkAutoPrintBatch, False)
			Dim chkAutoPrintBatch2 As Global.System.Windows.Forms.Control = Me.chkAutoPrintBatch
			size = New Global.System.Drawing.Size(406, 24)
			chkAutoPrintBatch2.Size = size
			Me.chkAutoPrintBatch.TabIndex = 11
			Me.chkAutoPrintBatch.Text = "Print batch run log"
			Me.pnlAutomatic.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.pnlAutomatic.Controls.Add(Me.chkAutoPrintBatch)
			Me.pnlAutomatic.Controls.Add(Me.lblAutoPrintBatchNote)
			Dim pnlAutomatic As Global.System.Windows.Forms.Control = Me.pnlAutomatic
			location = New Global.System.Drawing.Point(8, 174)
			pnlAutomatic.Location = location
			Me.pnlAutomatic.Name = "pnlAutomatic"
			Dim pnlAutomatic2 As Global.System.Windows.Forms.Control = Me.pnlAutomatic
			size = New Global.System.Drawing.Size(528, 64)
			pnlAutomatic2.Size = size
			Me.pnlAutomatic.TabIndex = 8
			Me.pnlAutomatic.Visible = False
			Me.lblAutoPrintBatchNote.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Dim lblAutoPrintBatchNote As Global.System.Windows.Forms.Control = Me.lblAutoPrintBatchNote
			location = New Global.System.Drawing.Point(16, 35)
			lblAutoPrintBatchNote.Location = location
			Me.lblAutoPrintBatchNote.Name = "lblAutoPrintBatchNote"
			Dim lblAutoPrintBatchNote2 As Global.System.Windows.Forms.Control = Me.lblAutoPrintBatchNote
			size = New Global.System.Drawing.Size(512, 18)
			lblAutoPrintBatchNote2.Size = size
			Me.lblAutoPrintBatchNote.TabIndex = 12
			Me.lblAutoPrintBatchNote.Text = "(Note that if you do not have the log printed, it will be very difficult to tell which cases have been run.)"
			Me.lblDemoMode.BackColor = Global.System.Drawing.Color.Red
			Me.lblDemoMode.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblDemoMode.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblDemoMode.ForeColor = Global.System.Drawing.Color.White
			Dim lblDemoMode As Global.System.Windows.Forms.Control = Me.lblDemoMode
			location = New Global.System.Drawing.Point(544, 96)
			lblDemoMode.Location = location
			Me.lblDemoMode.Name = "lblDemoMode"
			Dim lblDemoMode2 As Global.System.Windows.Forms.Control = Me.lblDemoMode
			size = New Global.System.Drawing.Size(136, 48)
			lblDemoMode2.Size = size
			Me.lblDemoMode.TabIndex = 0
			Me.lblDemoMode.Text = "DEMO MODE:  The files selected will be replaced by the demo file."
			Me.lblDemoMode.Visible = False
			Me.AcceptButton = Me.cmdProceed
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			Me.CancelButton = Me.cmdCancel
			size = New Global.System.Drawing.Size(698, 173)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.pnlAutomatic)
			Me.Controls.Add(Me.cmdHelp)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.cmdProceed)
			Me.Controls.Add(Me.pnlBatch)
			Me.Controls.Add(Me.lblDemoMode)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(208, 150)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgBatchOpts"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Batch Run Options"
			Me.pnlBatch.ResumeLayout(False)
			Me.pnlAutomatic.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
