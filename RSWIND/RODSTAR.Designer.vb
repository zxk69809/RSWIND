Namespace RSWINV3
	Public Partial Class RODSTAR
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.RODSTAR))
			Me.panStatus = New Global.System.Windows.Forms.StatusBar()
			Me.tbrToolBar2 = New Global.System.Windows.Forms.ToolBar()
			Me.tbrRun = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrRunSpeed = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrReport = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrEmail = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrPrint = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrCBM = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrSep5 = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrSep6 = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrBatch = New Global.System.Windows.Forms.ToolBarButton()
			Me.ImageList2 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.tbrToolbar = New Global.System.Windows.Forms.ToolBar()
			Me.tbrNew = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrOpen = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrSave = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrSep1 = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrSep2 = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrOptions = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrSep3 = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrSep4 = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrWellInfo = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrProdInfo = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrPumpTubingInfo = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrRSInput = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrDeviated = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrPUData = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrMotorData = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrPrevious = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrNext = New Global.System.Windows.Forms.ToolBarButton()
			Me.pnlToolbar = New Global.System.Windows.Forms.Panel()
			Me.tbrExpertAdmin = New Global.System.Windows.Forms.ToolBar()
			Me.btnToolsUploadRSVXFile = New Global.System.Windows.Forms.ToolBarButton()
			Me.btnToolsUploadRSVXFiles = New Global.System.Windows.Forms.ToolBarButton()
			Me.btnToolsBatchExportFromOneFolder = New Global.System.Windows.Forms.ToolBarButton()
			Me.btnToolsBatchExportALL = New Global.System.Windows.Forms.ToolBarButton()
			Me.btnToolsDownloadToRSVX = New Global.System.Windows.Forms.ToolBarButton()
			Me.btnToolsDeleteTemplate = New Global.System.Windows.Forms.ToolBarButton()
			Me.btnToolsEncryptTemplateDatabase = New Global.System.Windows.Forms.ToolBarButton()
			Me.btnViewAllTemplates = New Global.System.Windows.Forms.ToolBarButton()
			Me.btnViewAddedTemplates = New Global.System.Windows.Forms.ToolBarButton()
			Me.btnRunAllTemplates = New Global.System.Windows.Forms.ToolBarButton()
			Me.ImageList_admin = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.lblMode = New Global.System.Windows.Forms.Label()
			Me.btnVertical = New Global.System.Windows.Forms.Button()
			Me.ImageList_Guru = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.btnAlpha = New Global.System.Windows.Forms.Button()
			Me.tbrToolBar3 = New Global.System.Windows.Forms.ToolBar()
			Me.tbrHelp = New Global.System.Windows.Forms.ToolBarButton()
			Me.btnVisualInput = New Global.System.Windows.Forms.Button()
			Me.AniRun = New Global.Infragistics.Win.Misc.CommonControls.AnimationControl()
			Me.tbrAbort = New Global.System.Windows.Forms.ToolBar()
			Me.ToolBarButton2 = New Global.System.Windows.Forms.ToolBarButton()
			Me.tbrGuru = New Global.System.Windows.Forms.ToolBar()
			Me.ToolBarButton1 = New Global.System.Windows.Forms.ToolBarButton()
			Me.OpenFileDialog1 = New Global.System.Windows.Forms.OpenFileDialog()
			Me.SaveFileDialog1 = New Global.System.Windows.Forms.SaveFileDialog()
			Me.MainMenu1 = New Global.System.Windows.Forms.MainMenu(Me.components)
			Me.ContextMenu1 = New Global.System.Windows.Forms.ContextMenu()
			Me.PrintDialog1 = New Global.System.Windows.Forms.PrintDialog()
			Me.ctxMenu4ToolBar = New Global.System.Windows.Forms.ContextMenu()
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.lblGURU = New Global.System.Windows.Forms.Label()
			Me.ImageList_Guru_large = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.btnGuru = New Global.System.Windows.Forms.Button()
			Me.pnlAIavi = New Global.System.Windows.Forms.Panel()
			Me.AIavi = New Global.Infragistics.Win.Misc.CommonControls.AnimationControl()
			Me.btnMeasUnit = New Global.System.Windows.Forms.Button()
			Me.tmrClock = New Global.System.Windows.Forms.Timer(Me.components)
			Me.pnlBatchLog = New Global.System.Windows.Forms.Panel()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.Viewer1 = New Global.DataDynamics.ActiveReports.Viewer.Viewer()
			Me.pnlToolbar.SuspendLayout()
			Me.pnlAIavi.SuspendLayout()
			Me.pnlBatchLog.SuspendLayout()
			Me.SuspendLayout()
			Me.panStatus.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim panStatus As Global.System.Windows.Forms.Control = Me.panStatus
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 695)
			panStatus.Location = location
			Me.panStatus.Name = "panStatus"
			Me.HelpProvider1.SetShowHelp(Me.panStatus, False)
			Dim panStatus2 As Global.System.Windows.Forms.Control = Me.panStatus
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(1192, 20)
			panStatus2.Size = size
			Me.panStatus.TabIndex = 1
			Me.panStatus.Text = "RODSTAR"
			Me.tbrToolBar2.AutoSize = False
			Me.tbrToolBar2.Buttons.AddRange(New Global.System.Windows.Forms.ToolBarButton() { Me.tbrRun, Me.tbrRunSpeed, Me.tbrReport, Me.tbrEmail, Me.tbrPrint, Me.tbrCBM, Me.tbrSep5, Me.tbrSep6, Me.tbrBatch })
			Dim tbrToolBar As Global.System.Windows.Forms.ToolBar = Me.tbrToolBar2
			size = New Global.System.Drawing.Size(23, 22)
			tbrToolBar.ButtonSize = size
			Me.tbrToolBar2.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.tbrToolBar2.DropDownArrows = True
			Me.tbrToolBar2.ImageList = Me.ImageList2
			Me.tbrToolBar2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim tbrToolBar2 As Global.System.Windows.Forms.Control = Me.tbrToolBar2
			location = New Global.System.Drawing.Point(408, 3)
			tbrToolBar2.Location = location
			Me.tbrToolBar2.Name = "tbrToolBar2"
			Me.HelpProvider1.SetShowHelp(Me.tbrToolBar2, False)
			Me.tbrToolBar2.ShowToolTips = True
			Dim tbrToolBar3 As Global.System.Windows.Forms.Control = Me.tbrToolBar2
			size = New Global.System.Drawing.Size(184, 29)
			tbrToolBar3.Size = size
			Me.tbrToolBar2.TabIndex = 3
			Me.tbrRun.Enabled = False
			Me.tbrRun.ImageIndex = 11
			Me.tbrRun.Name = "tbrRun"
			Me.tbrRun.ToolTipText = "Run"
			Me.tbrRunSpeed.Enabled = False
			Me.tbrRunSpeed.ImageIndex = 26
			Me.tbrRunSpeed.Name = "tbrRunSpeed"
			Me.tbrRunSpeed.ToolTipText = "Run for Speed"
			Me.tbrRunSpeed.Visible = False
			Me.tbrReport.Enabled = False
			Me.tbrReport.ImageIndex = 12
			Me.tbrReport.Name = "tbrReport"
			Me.tbrReport.ToolTipText = "Report"
			Me.tbrEmail.Enabled = False
			Me.tbrEmail.ImageIndex = 24
			Me.tbrEmail.Name = "tbrEmail"
			Me.tbrEmail.ToolTipText = "EMAIL"
			Me.tbrPrint.Enabled = False
			Me.tbrPrint.ImageIndex = 23
			Me.tbrPrint.Name = "tbrPrint"
			Me.tbrPrint.ToolTipText = "Print"
			Me.tbrCBM.Enabled = False
			Me.tbrCBM.ImageIndex = 28
			Me.tbrCBM.Name = "tbrCBM"
			Me.tbrCBM.ToolTipText = "Export Counterbalance Moment"
			Me.tbrSep5.Name = "tbrSep5"
			Me.tbrSep5.Style = Global.System.Windows.Forms.ToolBarButtonStyle.Separator
			Me.tbrSep6.Name = "tbrSep6"
			Me.tbrSep6.Style = Global.System.Windows.Forms.ToolBarButtonStyle.Separator
			Me.tbrBatch.ImageIndex = 18
			Me.tbrBatch.Name = "tbrBatch"
			Me.tbrBatch.ToolTipText = "Automatic Batch"
			Me.ImageList2.ImageStream = CType(componentResourceManager.GetObject("ImageList2.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList2.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList2.Images.SetKeyName(0, "")
			Me.ImageList2.Images.SetKeyName(1, "")
			Me.ImageList2.Images.SetKeyName(2, "")
			Me.ImageList2.Images.SetKeyName(3, "")
			Me.ImageList2.Images.SetKeyName(4, "")
			Me.ImageList2.Images.SetKeyName(5, "")
			Me.ImageList2.Images.SetKeyName(6, "")
			Me.ImageList2.Images.SetKeyName(7, "")
			Me.ImageList2.Images.SetKeyName(8, "")
			Me.ImageList2.Images.SetKeyName(9, "")
			Me.ImageList2.Images.SetKeyName(10, "")
			Me.ImageList2.Images.SetKeyName(11, "")
			Me.ImageList2.Images.SetKeyName(12, "")
			Me.ImageList2.Images.SetKeyName(13, "")
			Me.ImageList2.Images.SetKeyName(14, "")
			Me.ImageList2.Images.SetKeyName(15, "")
			Me.ImageList2.Images.SetKeyName(16, "")
			Me.ImageList2.Images.SetKeyName(17, "")
			Me.ImageList2.Images.SetKeyName(18, "")
			Me.ImageList2.Images.SetKeyName(19, "")
			Me.ImageList2.Images.SetKeyName(20, "")
			Me.ImageList2.Images.SetKeyName(21, "")
			Me.ImageList2.Images.SetKeyName(22, "")
			Me.ImageList2.Images.SetKeyName(23, "")
			Me.ImageList2.Images.SetKeyName(24, "")
			Me.ImageList2.Images.SetKeyName(25, "")
			Me.ImageList2.Images.SetKeyName(26, "")
			Me.ImageList2.Images.SetKeyName(27, "")
			Me.ImageList2.Images.SetKeyName(28, "")
			Me.ImageList2.Images.SetKeyName(29, "Agt Stop icon_16.png")
			Me.tbrToolbar.AutoSize = False
			Me.tbrToolbar.Buttons.AddRange(New Global.System.Windows.Forms.ToolBarButton() { Me.tbrNew, Me.tbrOpen, Me.tbrSave, Me.tbrSep1, Me.tbrSep2, Me.tbrOptions, Me.tbrSep3, Me.tbrSep4, Me.tbrWellInfo, Me.tbrProdInfo, Me.tbrPumpTubingInfo, Me.tbrRSInput, Me.tbrDeviated, Me.tbrPUData, Me.tbrMotorData, Me.tbrPrevious, Me.tbrNext })
			Dim tbrToolbar As Global.System.Windows.Forms.ToolBar = Me.tbrToolbar
			size = New Global.System.Drawing.Size(23, 22)
			tbrToolbar.ButtonSize = size
			Me.tbrToolbar.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.tbrToolbar.DropDownArrows = True
			Me.tbrToolbar.ImageList = Me.ImageList2
			Me.tbrToolbar.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim tbrToolbar2 As Global.System.Windows.Forms.Control = Me.tbrToolbar
			location = New Global.System.Drawing.Point(8, 3)
			tbrToolbar2.Location = location
			Me.tbrToolbar.Name = "tbrToolbar"
			Me.HelpProvider1.SetShowHelp(Me.tbrToolbar, False)
			Me.tbrToolbar.ShowToolTips = True
			Dim tbrToolbar3 As Global.System.Windows.Forms.Control = Me.tbrToolbar
			size = New Global.System.Drawing.Size(352, 26)
			tbrToolbar3.Size = size
			Me.tbrToolbar.TabIndex = 6
			Me.tbrNew.ImageIndex = 0
			Me.tbrNew.Name = "tbrNew"
			Me.tbrNew.ToolTipText = "New File"
			Me.tbrOpen.ImageIndex = 1
			Me.tbrOpen.Name = "tbrOpen"
			Me.tbrOpen.Style = Global.System.Windows.Forms.ToolBarButtonStyle.DropDownButton
			Me.tbrOpen.ToolTipText = "Open File"
			Me.tbrSave.Enabled = False
			Me.tbrSave.ImageIndex = 2
			Me.tbrSave.Name = "tbrSave"
			Me.tbrSave.ToolTipText = "Save File"
			Me.tbrSep1.Name = "tbrSep1"
			Me.tbrSep1.Style = Global.System.Windows.Forms.ToolBarButtonStyle.Separator
			Me.tbrSep2.Name = "tbrSep2"
			Me.tbrSep2.Style = Global.System.Windows.Forms.ToolBarButtonStyle.Separator
			Me.tbrOptions.ImageIndex = 3
			Me.tbrOptions.Name = "tbrOptions"
			Me.tbrOptions.ToolTipText = "Setup"
			Me.tbrSep3.Name = "tbrSep3"
			Me.tbrSep3.Style = Global.System.Windows.Forms.ToolBarButtonStyle.Separator
			Me.tbrSep4.Name = "tbrSep4"
			Me.tbrSep4.Style = Global.System.Windows.Forms.ToolBarButtonStyle.Separator
			Me.tbrWellInfo.Enabled = False
			Me.tbrWellInfo.ImageIndex = 4
			Me.tbrWellInfo.Name = "tbrWellInfo"
			Me.tbrWellInfo.ToolTipText = "Well Information"
			Me.tbrProdInfo.Enabled = False
			Me.tbrProdInfo.ImageIndex = 22
			Me.tbrProdInfo.Name = "tbrProdInfo"
			Me.tbrProdInfo.ToolTipText = "Production Information"
			Me.tbrPumpTubingInfo.Enabled = False
			Me.tbrPumpTubingInfo.ImageIndex = 6
			Me.tbrPumpTubingInfo.Name = "tbrPumpTubingInfo"
			Me.tbrPumpTubingInfo.ToolTipText = "Pump/Tubing Information"
			Me.tbrRSInput.Enabled = False
			Me.tbrRSInput.ImageIndex = 7
			Me.tbrRSInput.Name = "tbrRSInput"
			Me.tbrRSInput.ToolTipText = "Rod String Information"
			Me.tbrDeviated.Enabled = False
			Me.tbrDeviated.ImageIndex = 25
			Me.tbrDeviated.Name = "tbrDeviated"
			Me.tbrPUData.Enabled = False
			Me.tbrPUData.ImageIndex = 8
			Me.tbrPUData.Name = "tbrPUData"
			Me.tbrPUData.ToolTipText = "Pumping Unit Information"
			Me.tbrMotorData.Enabled = False
			Me.tbrMotorData.ImageIndex = 9
			Me.tbrMotorData.Name = "tbrMotorData"
			Me.tbrMotorData.ToolTipText = "Motor Information"
			Me.tbrPrevious.Enabled = False
			Me.tbrPrevious.ImageIndex = 19
			Me.tbrPrevious.Name = "tbrPrevious"
			Me.tbrPrevious.ToolTipText = "Previous Window"
			Me.tbrNext.Enabled = False
			Me.tbrNext.ImageIndex = 10
			Me.tbrNext.Name = "tbrNext"
			Me.tbrNext.ToolTipText = "Next Window"
			Me.pnlToolbar.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlToolbar.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.pnlToolbar.Controls.Add(Me.tbrExpertAdmin)
			Me.pnlToolbar.Controls.Add(Me.lblMode)
			Me.pnlToolbar.Controls.Add(Me.btnVertical)
			Me.pnlToolbar.Controls.Add(Me.btnAlpha)
			Me.pnlToolbar.Controls.Add(Me.tbrToolBar3)
			Me.pnlToolbar.Controls.Add(Me.btnVisualInput)
			Me.pnlToolbar.Controls.Add(Me.tbrToolbar)
			Me.pnlToolbar.Controls.Add(Me.AniRun)
			Me.pnlToolbar.Controls.Add(Me.tbrToolBar2)
			Me.pnlToolbar.Controls.Add(Me.tbrAbort)
			Me.pnlToolbar.Controls.Add(Me.tbrGuru)
			Me.pnlToolbar.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim pnlToolbar As Global.System.Windows.Forms.Control = Me.pnlToolbar
			location = New Global.System.Drawing.Point(0, 0)
			pnlToolbar.Location = location
			Me.pnlToolbar.Name = "pnlToolbar"
			Me.HelpProvider1.SetShowHelp(Me.pnlToolbar, False)
			Dim pnlToolbar2 As Global.System.Windows.Forms.Control = Me.pnlToolbar
			size = New Global.System.Drawing.Size(1192, 31)
			pnlToolbar2.Size = size
			Me.pnlToolbar.TabIndex = 7
			Me.tbrExpertAdmin.AutoSize = False
			Me.tbrExpertAdmin.Buttons.AddRange(New Global.System.Windows.Forms.ToolBarButton() { Me.btnToolsUploadRSVXFile, Me.btnToolsUploadRSVXFiles, Me.btnToolsBatchExportFromOneFolder, Me.btnToolsBatchExportALL, Me.btnToolsDownloadToRSVX, Me.btnToolsDeleteTemplate, Me.btnToolsEncryptTemplateDatabase, Me.btnViewAllTemplates, Me.btnViewAddedTemplates, Me.btnRunAllTemplates })
			Me.tbrExpertAdmin.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.tbrExpertAdmin.DropDownArrows = True
			Me.tbrExpertAdmin.ImageList = Me.ImageList_admin
			Dim tbrExpertAdmin As Global.System.Windows.Forms.Control = Me.tbrExpertAdmin
			location = New Global.System.Drawing.Point(936, 3)
			tbrExpertAdmin.Location = location
			Me.tbrExpertAdmin.Name = "tbrExpertAdmin"
			Me.tbrExpertAdmin.ShowToolTips = True
			Dim tbrExpertAdmin2 As Global.System.Windows.Forms.Control = Me.tbrExpertAdmin
			size = New Global.System.Drawing.Size(249, 25)
			tbrExpertAdmin2.Size = size
			Me.tbrExpertAdmin.TabIndex = 16
			Me.tbrExpertAdmin.Visible = False
			Me.btnToolsUploadRSVXFile.Enabled = False
			Me.btnToolsUploadRSVXFile.ImageIndex = 0
			Me.btnToolsUploadRSVXFile.Name = "btnToolsUploadRSVXFile"
			Me.btnToolsUploadRSVXFile.ToolTipText = "Upload current RSVX File to template database"
			Me.btnToolsUploadRSVXFiles.ImageIndex = 1
			Me.btnToolsUploadRSVXFiles.Name = "btnToolsUploadRSVXFiles"
			Me.btnToolsUploadRSVXFiles.Text = "U*"
			Me.btnToolsUploadRSVXFiles.ToolTipText = "Upload multiple RSVX Files to template database"
			Me.btnToolsBatchExportFromOneFolder.ImageIndex = 2
			Me.btnToolsBatchExportFromOneFolder.Name = "btnToolsBatchExportFromOneFolder"
			Me.btnToolsBatchExportFromOneFolder.ToolTipText = "Update all files in folder to template database"
			Me.btnToolsBatchExportALL.ImageIndex = 5
			Me.btnToolsBatchExportALL.Name = "btnToolsBatchExportALL"
			Me.btnToolsBatchExportALL.ToolTipText = "Update all files from master folder to template database Batch Export All"
			Me.btnToolsDownloadToRSVX.ImageIndex = 3
			Me.btnToolsDownloadToRSVX.Name = "btnToolsDownloadToRSVX"
			Me.btnToolsDownloadToRSVX.ToolTipText = "Download template to RSVX file"
			Me.btnToolsDeleteTemplate.ImageIndex = 4
			Me.btnToolsDeleteTemplate.Name = "btnToolsDeleteTemplate"
			Me.btnToolsDeleteTemplate.ToolTipText = "Delete Template"
			Me.btnToolsEncryptTemplateDatabase.ImageIndex = 6
			Me.btnToolsEncryptTemplateDatabase.Name = "btnToolsEncryptTemplateDatabase"
			Me.btnToolsEncryptTemplateDatabase.ToolTipText = "Encrypt Template Database"
			Me.btnViewAllTemplates.ImageIndex = 7
			Me.btnViewAllTemplates.Name = "btnViewAllTemplates"
			Me.btnViewAllTemplates.ToolTipText = "View All Templates"
			Me.btnViewAddedTemplates.ImageIndex = 8
			Me.btnViewAddedTemplates.Name = "btnViewAddedTemplates"
			Me.btnViewAddedTemplates.ToolTipText = "View Only Added Templates"
			Me.btnRunAllTemplates.ImageIndex = 9
			Me.btnRunAllTemplates.Name = "btnRunAllTemplates"
			Me.btnRunAllTemplates.ToolTipText = "Run All Templates"
			Me.ImageList_admin.ImageStream = CType(componentResourceManager.GetObject("ImageList_admin.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList_admin.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList_admin.Images.SetKeyName(0, "")
			Me.ImageList_admin.Images.SetKeyName(1, "")
			Me.ImageList_admin.Images.SetKeyName(2, "")
			Me.ImageList_admin.Images.SetKeyName(3, "")
			Me.ImageList_admin.Images.SetKeyName(4, "")
			Me.ImageList_admin.Images.SetKeyName(5, "")
			Me.ImageList_admin.Images.SetKeyName(6, "")
			Me.ImageList_admin.Images.SetKeyName(7, "")
			Me.ImageList_admin.Images.SetKeyName(8, "")
			Me.ImageList_admin.Images.SetKeyName(9, "")
			Me.lblMode.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblMode.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblMode As Global.System.Windows.Forms.Control = Me.lblMode
			location = New Global.System.Drawing.Point(816, 3)
			lblMode.Location = location
			Me.lblMode.Name = "lblMode"
			Dim lblMode2 As Global.System.Windows.Forms.Control = Me.lblMode
			size = New Global.System.Drawing.Size(112, 21)
			lblMode2.Size = size
			Me.lblMode.TabIndex = 15
			Me.lblMode.Text = "Deviated mode"
			Me.lblMode.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblMode.Visible = False
			Me.btnVertical.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnVertical.ImageIndex = 1
			Me.btnVertical.ImageList = Me.ImageList_Guru
			Me.btnVertical.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnVertical As Global.System.Windows.Forms.Control = Me.btnVertical
			location = New Global.System.Drawing.Point(792, 3)
			btnVertical.Location = location
			Me.btnVertical.Name = "btnVertical"
			Me.HelpProvider1.SetShowHelp(Me.btnVertical, False)
			Dim btnVertical2 As Global.System.Windows.Forms.Control = Me.btnVertical
			size = New Global.System.Drawing.Size(22, 25)
			btnVertical2.Size = size
			Me.btnVertical.TabIndex = 11
			Me.ImageList_Guru.ImageStream = CType(componentResourceManager.GetObject("ImageList_Guru.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList_Guru.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList_Guru.Images.SetKeyName(0, "")
			Me.ImageList_Guru.Images.SetKeyName(1, "")
			Me.ImageList_Guru.Images.SetKeyName(2, "")
			Me.ImageList_Guru.Images.SetKeyName(3, "")
			Me.btnAlpha.Enabled = False
			Me.btnAlpha.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnAlpha.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnAlpha As Global.System.Windows.Forms.Control = Me.btnAlpha
			location = New Global.System.Drawing.Point(744, 3)
			btnAlpha.Location = location
			Me.btnAlpha.Name = "btnAlpha"
			Me.HelpProvider1.SetShowHelp(Me.btnAlpha, False)
			Dim btnAlpha2 As Global.System.Windows.Forms.Control = Me.btnAlpha
			size = New Global.System.Drawing.Size(22, 25)
			btnAlpha2.Size = size
			Me.btnAlpha.TabIndex = 9
			Me.btnAlpha.Text = "A"
			Me.tbrToolBar3.AutoSize = False
			Me.tbrToolBar3.Buttons.AddRange(New Global.System.Windows.Forms.ToolBarButton() { Me.tbrHelp })
			Dim tbrToolBar4 As Global.System.Windows.Forms.ToolBar = Me.tbrToolBar3
			size = New Global.System.Drawing.Size(23, 22)
			tbrToolBar4.ButtonSize = size
			Me.tbrToolBar3.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.tbrToolBar3.DropDownArrows = True
			Me.tbrToolBar3.ImageList = Me.ImageList2
			Me.tbrToolBar3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim tbrToolBar5 As Global.System.Windows.Forms.Control = Me.tbrToolBar3
			location = New Global.System.Drawing.Point(600, 3)
			tbrToolBar5.Location = location
			Me.tbrToolBar3.Name = "tbrToolBar3"
			Me.HelpProvider1.SetShowHelp(Me.tbrToolBar3, False)
			Me.tbrToolBar3.ShowToolTips = True
			Dim tbrToolBar6 As Global.System.Windows.Forms.Control = Me.tbrToolBar3
			size = New Global.System.Drawing.Size(22, 32)
			tbrToolBar6.Size = size
			Me.tbrToolBar3.TabIndex = 8
			Me.tbrHelp.ImageIndex = 15
			Me.tbrHelp.Name = "tbrHelp"
			Me.tbrHelp.ToolTipText = "Help"
			Me.btnVisualInput.Enabled = False
			Me.btnVisualInput.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnVisualInput As Global.System.Windows.Forms.Control = Me.btnVisualInput
			location = New Global.System.Drawing.Point(632, 3)
			btnVisualInput.Location = location
			Me.btnVisualInput.Name = "btnVisualInput"
			Me.HelpProvider1.SetShowHelp(Me.btnVisualInput, False)
			Dim btnVisualInput2 As Global.System.Windows.Forms.Control = Me.btnVisualInput
			size = New Global.System.Drawing.Size(112, 25)
			btnVisualInput2.Size = size
			Me.btnVisualInput.TabIndex = 7
			Me.btnVisualInput.Text = "Visual Input>>"
			Me.AniRun.AutoCenter = True
			Dim aniRun As Global.System.Windows.Forms.Control = Me.AniRun
			location = New Global.System.Drawing.Point(408, 6)
			aniRun.Location = location
			Me.AniRun.Name = "AniRun"
			Dim aniRun2 As Global.System.Windows.Forms.Control = Me.AniRun
			size = New Global.System.Drawing.Size(24, 23)
			aniRun2.Size = size
			Me.AniRun.TabIndex = 13
			Me.AniRun.Visible = False
			Me.tbrAbort.AutoSize = False
			Me.tbrAbort.Buttons.AddRange(New Global.System.Windows.Forms.ToolBarButton() { Me.ToolBarButton2 })
			Dim tbrAbort As Global.System.Windows.Forms.ToolBar = Me.tbrAbort
			size = New Global.System.Drawing.Size(23, 22)
			tbrAbort.ButtonSize = size
			Me.tbrAbort.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.tbrAbort.DropDownArrows = True
			Me.tbrAbort.ImageList = Me.ImageList2
			Me.tbrAbort.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim tbrAbort2 As Global.System.Windows.Forms.Control = Me.tbrAbort
			location = New Global.System.Drawing.Point(384, 3)
			tbrAbort2.Location = location
			Me.tbrAbort.Name = "tbrAbort"
			Me.HelpProvider1.SetShowHelp(Me.tbrAbort, False)
			Me.tbrAbort.ShowToolTips = True
			Dim tbrAbort3 As Global.System.Windows.Forms.Control = Me.tbrAbort
			size = New Global.System.Drawing.Size(22, 26)
			tbrAbort3.Size = size
			Me.tbrAbort.TabIndex = 14
			Me.tbrAbort.Visible = False
			Me.ToolBarButton2.ImageIndex = 29
			Me.ToolBarButton2.Name = "ToolBarButton2"
			Me.ToolBarButton2.Text = "X"
			Me.ToolBarButton2.ToolTipText = "Abort"
			Me.tbrGuru.AutoSize = False
			Me.tbrGuru.Buttons.AddRange(New Global.System.Windows.Forms.ToolBarButton() { Me.ToolBarButton1 })
			Dim tbrGuru As Global.System.Windows.Forms.ToolBar = Me.tbrGuru
			size = New Global.System.Drawing.Size(23, 22)
			tbrGuru.ButtonSize = size
			Me.tbrGuru.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.tbrGuru.DropDownArrows = True
			Me.tbrGuru.ImageList = Me.ImageList_Guru
			Me.tbrGuru.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim tbrGuru2 As Global.System.Windows.Forms.Control = Me.tbrGuru
			location = New Global.System.Drawing.Point(376, 0)
			tbrGuru2.Location = location
			Me.tbrGuru.Name = "tbrGuru"
			Me.HelpProvider1.SetShowHelp(Me.tbrGuru, False)
			Me.tbrGuru.ShowToolTips = True
			Dim tbrGuru3 As Global.System.Windows.Forms.Control = Me.tbrGuru
			size = New Global.System.Drawing.Size(32, 32)
			tbrGuru3.Size = size
			Me.tbrGuru.TabIndex = 10
			Me.tbrGuru.Visible = False
			Me.ToolBarButton1.ImageIndex = 3
			Me.ToolBarButton1.Name = "ToolBarButton1"
			Me.ToolBarButton1.ToolTipText = "Artificial Intelligence Mode"
			Me.SaveFileDialog1.FileName = "doc1"
			Me.ToolTip1.AutomaticDelay = 300
			Me.ToolTip1.ShowAlways = True
			Me.lblGURU.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblGURU As Global.System.Windows.Forms.Control = Me.lblGURU
			location = New Global.System.Drawing.Point(1055, 691)
			lblGURU.Location = location
			Me.lblGURU.Name = "lblGURU"
			Dim lblGURU2 As Global.System.Windows.Forms.Control = Me.lblGURU
			size = New Global.System.Drawing.Size(91, 20)
			lblGURU2.Size = size
			Me.lblGURU.TabIndex = 8
			Me.lblGURU.Text = "AI MODE"
			Me.lblGURU.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblGURU.Visible = False
			Me.ImageList_Guru_large.ImageStream = CType(componentResourceManager.GetObject("ImageList_Guru_large.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList_Guru_large.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList_Guru_large.Images.SetKeyName(0, "")
			Me.ImageList_Guru_large.Images.SetKeyName(1, "")
			Dim btnGuru As Global.System.Windows.Forms.Control = Me.btnGuru
			location = New Global.System.Drawing.Point(1055, 590)
			btnGuru.Location = location
			Me.btnGuru.Name = "btnGuru"
			Dim btnGuru2 As Global.System.Windows.Forms.Control = Me.btnGuru
			size = New Global.System.Drawing.Size(109, 101)
			btnGuru2.Size = size
			Me.btnGuru.TabIndex = 9
			Me.btnGuru.Visible = False
			Me.pnlAIavi.Controls.Add(Me.AIavi)
			Dim pnlAIavi As Global.System.Windows.Forms.Control = Me.pnlAIavi
			location = New Global.System.Drawing.Point(-1333, 72)
			pnlAIavi.Location = location
			Me.pnlAIavi.Name = "pnlAIavi"
			Dim pnlAIavi2 As Global.System.Windows.Forms.Control = Me.pnlAIavi
			size = New Global.System.Drawing.Size(259, 257)
			pnlAIavi2.Size = size
			Me.pnlAIavi.TabIndex = 10
			Me.AIavi.AutoCenter = True
			Dim aiavi As Global.System.Windows.Forms.Control = Me.AIavi
			location = New Global.System.Drawing.Point(3, 3)
			aiavi.Location = location
			Me.AIavi.Name = "AIavi"
			Dim aiavi2 As Global.System.Windows.Forms.Control = Me.AIavi
			size = New Global.System.Drawing.Size(253, 249)
			aiavi2.Size = size
			Me.AIavi.TabIndex = 14
			Me.btnMeasUnit.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim btnMeasUnit As Global.System.Windows.Forms.Control = Me.btnMeasUnit
			location = New Global.System.Drawing.Point(1033, 691)
			btnMeasUnit.Location = location
			Me.btnMeasUnit.Name = "btnMeasUnit"
			Dim btnMeasUnit2 As Global.System.Windows.Forms.Control = Me.btnMeasUnit
			size = New Global.System.Drawing.Size(20, 21)
			btnMeasUnit2.Size = size
			Me.btnMeasUnit.TabIndex = 12
			Me.btnMeasUnit.Text = "E"
			Me.btnMeasUnit.Visible = False
			Me.tmrClock.Interval = 30000
			Me.pnlBatchLog.Controls.Add(Me.btnClose)
			Me.pnlBatchLog.Controls.Add(Me.Viewer1)
			Dim pnlBatchLog As Global.System.Windows.Forms.Control = Me.pnlBatchLog
			location = New Global.System.Drawing.Point(-1444, 31)
			pnlBatchLog.Location = location
			Me.pnlBatchLog.Name = "pnlBatchLog"
			Dim pnlBatchLog2 As Global.System.Windows.Forms.Control = Me.pnlBatchLog
			size = New Global.System.Drawing.Size(1192, 664)
			pnlBatchLog2.Size = size
			Me.pnlBatchLog.TabIndex = 13
			Me.pnlBatchLog.Visible = False
			Dim btnClose As Global.System.Windows.Forms.Control = Me.btnClose
			location = New Global.System.Drawing.Point(1069, 611)
			btnClose.Location = location
			Me.btnClose.Name = "btnClose"
			Dim btnClose2 As Global.System.Windows.Forms.Control = Me.btnClose
			size = New Global.System.Drawing.Size(95, 27)
			btnClose2.Size = size
			Me.btnClose.TabIndex = 17
			Me.btnClose.Text = "Close"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.Viewer1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Viewer1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Viewer1.Document = New Global.DataDynamics.ActiveReports.Document.Document("ARNet Document")
			Dim viewer As Global.System.Windows.Forms.Control = Me.Viewer1
			location = New Global.System.Drawing.Point(0, 0)
			viewer.Location = location
			Me.Viewer1.Name = "Viewer1"
			Me.Viewer1.ReportViewer.CurrentPage = 0
			Me.Viewer1.ReportViewer.MultiplePageCols = 3
			Me.Viewer1.ReportViewer.MultiplePageRows = 2
			Me.Viewer1.ReportViewer.ViewType = Global.DataDynamics.ActiveReports.Viewer.ViewType.Normal
			Dim viewer2 As Global.System.Windows.Forms.Control = Me.Viewer1
			size = New Global.System.Drawing.Size(1192, 664)
			viewer2.Size = size
			Me.Viewer1.TabIndex = 16
			Me.Viewer1.TableOfContents.Text = "Contents"
			Me.Viewer1.TableOfContents.Width = 200
			Me.Viewer1.TabTitleLength = 35
			Me.Viewer1.Toolbar.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(1192, 715)
			Me.ClientSize = size
			Me.Controls.Add(Me.pnlBatchLog)
			Me.Controls.Add(Me.btnMeasUnit)
			Me.Controls.Add(Me.pnlAIavi)
			Me.Controls.Add(Me.btnGuru)
			Me.Controls.Add(Me.lblGURU)
			Me.Controls.Add(Me.pnlToolbar)
			Me.Controls.Add(Me.panStatus)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "RODSTAR"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.pnlToolbar.ResumeLayout(False)
			Me.pnlAIavi.ResumeLayout(False)
			Me.pnlBatchLog.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
