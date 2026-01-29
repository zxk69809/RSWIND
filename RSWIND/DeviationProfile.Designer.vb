Namespace RSWINV3
	Friend Partial Class DeviationProfile
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.DeviationProfile))
			Dim border As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdAddSection = New Global.System.Windows.Forms.Button()
			Me.cmdDelSection = New Global.System.Windows.Forms.Button()
			Me.cmdMoveSectionUp = New Global.System.Windows.Forms.Button()
			Me.cmdMoveSectionDown = New Global.System.Windows.Forms.Button()
			Me.cmdNumberOfEntries = New Global.System.Windows.Forms.Button()
			Me.cmdPrint = New Global.System.Windows.Forms.Button()
			Me.btnReadTest = New Global.System.Windows.Forms.Button()
			Me.ImageList3 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.btnResetPlot = New Global.System.Windows.Forms.Button()
			Me.cmdDeleteALLSections = New Global.System.Windows.Forms.Button()
			Me.btnImport = New Global.System.Windows.Forms.Button()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.btnExport = New Global.System.Windows.Forms.Button()
			Me.btnPaste = New Global.System.Windows.Forms.Button()
			Me.picRemoveFocus = New Global.System.Windows.Forms.Panel()
			Me.tabInput = New Global.System.Windows.Forms.TabControl()
			Me._tabInput_TabPage0 = New Global.System.Windows.Forms.TabPage()
			Me.lblTemp = New Global.System.Windows.Forms.Label()
			Me.txtInclination = New Global.System.Windows.Forms.TextBox()
			Me.txtAzimuth = New Global.System.Windows.Forms.TextBox()
			Me.tabDirection = New Global.System.Windows.Forms.TabControl()
			Me.NE = New Global.System.Windows.Forms.TabPage()
			Me.NW = New Global.System.Windows.Forms.TabPage()
			Me.SE = New Global.System.Windows.Forms.TabPage()
			Me.SW = New Global.System.Windows.Forms.TabPage()
			Me.ulgDeviationProfile = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me._tabInput_TabPage2 = New Global.System.Windows.Forms.TabPage()
			Me.grpDevPlot = New Global.System.Windows.Forms.GroupBox()
			Me.pnlLegend = New Global.System.Windows.Forms.Panel()
			Me.lblDiameters2 = New Global.System.Windows.Forms.Label()
			Me.lblDiameters = New Global.System.Windows.Forms.Label()
			Me.T20 = New Global.System.Windows.Forms.Label()
			Me.T19 = New Global.System.Windows.Forms.Label()
			Me.T18 = New Global.System.Windows.Forms.Label()
			Me.T17 = New Global.System.Windows.Forms.Label()
			Me.T16 = New Global.System.Windows.Forms.Label()
			Me.T15 = New Global.System.Windows.Forms.Label()
			Me.T14 = New Global.System.Windows.Forms.Label()
			Me.T13 = New Global.System.Windows.Forms.Label()
			Me.T12 = New Global.System.Windows.Forms.Label()
			Me.T11 = New Global.System.Windows.Forms.Label()
			Me.T10 = New Global.System.Windows.Forms.Label()
			Me.T9 = New Global.System.Windows.Forms.Label()
			Me.T8 = New Global.System.Windows.Forms.Label()
			Me.T7 = New Global.System.Windows.Forms.Label()
			Me.T6 = New Global.System.Windows.Forms.Label()
			Me.T5 = New Global.System.Windows.Forms.Label()
			Me.T4 = New Global.System.Windows.Forms.Label()
			Me.T3 = New Global.System.Windows.Forms.Label()
			Me.T2 = New Global.System.Windows.Forms.Label()
			Me.T1 = New Global.System.Windows.Forms.Label()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.lblNoData = New Global.System.Windows.Forms.Label()
			Me.TChart1 = New Global.Steema.TeeChart.TChart()
			Me.point3DSeries1 = New Global.Steema.TeeChart.Styles.Points3D()
			Me.MarksTip1 = New Global.Steema.TeeChart.Tools.MarksTip()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.commander1 = New Global.Steema.TeeChart.Commander()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.fraPumpDrag = New Global.Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
			Me.optPolishedRodDrag = New Global.Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
			Me.optPumpDragDown = New Global.Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
			Me.optPumpDragUp = New Global.Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.txtTempLength = New Global.System.Windows.Forms.TextBox()
			Me.lblNoDataAvailable = New Global.System.Windows.Forms.Label()
			Me.Panel_Dogleg = New Global.System.Windows.Forms.Panel()
			Me.ChartFX_DoglegSeverity = New Global.ChartFX.WinForms.Chart()
			Me.lblStatus = New Global.System.Windows.Forms.Label()
			Me.picRemoveFocus.SuspendLayout()
			Me.tabInput.SuspendLayout()
			Me._tabInput_TabPage0.SuspendLayout()
			Me.tabDirection.SuspendLayout()
			CType(Me.ulgDeviationProfile, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me._tabInput_TabPage2.SuspendLayout()
			Me.grpDevPlot.SuspendLayout()
			Me.pnlLegend.SuspendLayout()
			Me.Panel2.SuspendLayout()
			Me.Panel1.SuspendLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fraPumpDrag, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.optPolishedRodDrag, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.optPumpDragDown, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.optPumpDragUp, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel_Dogleg.SuspendLayout()
			CType(Me.ChartFX_DoglegSeverity, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.cmdAddSection.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdAddSection.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdAddSection.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.cmdAddSection.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdAddSection.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdAddSection, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdAddSection, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdAddSection.Image = CType(componentResourceManager.GetObject("cmdAddSection.Image"), Global.System.Drawing.Image)
			Me.cmdAddSection.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdAddSection As Global.System.Windows.Forms.Control = Me.cmdAddSection
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(3, 96)
			cmdAddSection.Location = location
			Me.cmdAddSection.Name = "cmdAddSection"
			Me.cmdAddSection.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdAddSection, True)
			Dim cmdAddSection2 As Global.System.Windows.Forms.Control = Me.cmdAddSection
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(24, 22)
			cmdAddSection2.Size = size
			Me.cmdAddSection.TabIndex = 2
			Me.cmdAddSection.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdAddSection, "Add an entry to the deviation survey")
			Me.cmdAddSection.UseVisualStyleBackColor = False
			Me.cmdDelSection.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdDelSection.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdDelSection.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.cmdDelSection.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdDelSection.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdDelSection, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdDelSection, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdDelSection.Image = CType(componentResourceManager.GetObject("cmdDelSection.Image"), Global.System.Drawing.Image)
			Me.cmdDelSection.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdDelSection As Global.System.Windows.Forms.Control = Me.cmdDelSection
			location = New Global.System.Drawing.Point(3, 120)
			cmdDelSection.Location = location
			Me.cmdDelSection.Name = "cmdDelSection"
			Me.cmdDelSection.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdDelSection, True)
			Dim cmdDelSection2 As Global.System.Windows.Forms.Control = Me.cmdDelSection
			size = New Global.System.Drawing.Size(24, 22)
			cmdDelSection2.Size = size
			Me.cmdDelSection.TabIndex = 3
			Me.cmdDelSection.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdDelSection, "Remove entry, or entries,  from the deviation survey")
			Me.cmdDelSection.UseVisualStyleBackColor = False
			Me.cmdMoveSectionUp.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdMoveSectionUp.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdMoveSectionUp.Enabled = False
			Me.cmdMoveSectionUp.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.cmdMoveSectionUp.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdMoveSectionUp.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdMoveSectionUp, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdMoveSectionUp, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdMoveSectionUp.Image = CType(componentResourceManager.GetObject("cmdMoveSectionUp.Image"), Global.System.Drawing.Image)
			Me.cmdMoveSectionUp.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdMoveSectionUp As Global.System.Windows.Forms.Control = Me.cmdMoveSectionUp
			location = New Global.System.Drawing.Point(3, 248)
			cmdMoveSectionUp.Location = location
			Me.cmdMoveSectionUp.Name = "cmdMoveSectionUp"
			Me.cmdMoveSectionUp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdMoveSectionUp, True)
			Dim cmdMoveSectionUp2 As Global.System.Windows.Forms.Control = Me.cmdMoveSectionUp
			size = New Global.System.Drawing.Size(24, 24)
			cmdMoveSectionUp2.Size = size
			Me.cmdMoveSectionUp.TabIndex = 6
			Me.cmdMoveSectionUp.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdMoveSectionUp, "Move an entry upward")
			Me.cmdMoveSectionUp.UseVisualStyleBackColor = False
			Me.cmdMoveSectionUp.Visible = False
			Me.cmdMoveSectionDown.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdMoveSectionDown.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdMoveSectionDown.Enabled = False
			Me.cmdMoveSectionDown.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.cmdMoveSectionDown.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdMoveSectionDown.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdMoveSectionDown, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdMoveSectionDown, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdMoveSectionDown.Image = CType(componentResourceManager.GetObject("cmdMoveSectionDown.Image"), Global.System.Drawing.Image)
			Me.cmdMoveSectionDown.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdMoveSectionDown As Global.System.Windows.Forms.Control = Me.cmdMoveSectionDown
			location = New Global.System.Drawing.Point(3, 224)
			cmdMoveSectionDown.Location = location
			Me.cmdMoveSectionDown.Name = "cmdMoveSectionDown"
			Me.cmdMoveSectionDown.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdMoveSectionDown, True)
			Dim cmdMoveSectionDown2 As Global.System.Windows.Forms.Control = Me.cmdMoveSectionDown
			size = New Global.System.Drawing.Size(24, 24)
			cmdMoveSectionDown2.Size = size
			Me.cmdMoveSectionDown.TabIndex = 5
			Me.cmdMoveSectionDown.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdMoveSectionDown, "Move an entry down")
			Me.cmdMoveSectionDown.UseVisualStyleBackColor = False
			Me.cmdMoveSectionDown.Visible = False
			Me.cmdNumberOfEntries.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdNumberOfEntries.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdNumberOfEntries.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.cmdNumberOfEntries.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdNumberOfEntries.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdNumberOfEntries, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdNumberOfEntries, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdNumberOfEntries.Image = CType(componentResourceManager.GetObject("cmdNumberOfEntries.Image"), Global.System.Drawing.Image)
			Me.cmdNumberOfEntries.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdNumberOfEntries As Global.System.Windows.Forms.Control = Me.cmdNumberOfEntries
			location = New Global.System.Drawing.Point(3, 72)
			cmdNumberOfEntries.Location = location
			Me.cmdNumberOfEntries.Name = "cmdNumberOfEntries"
			Me.cmdNumberOfEntries.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdNumberOfEntries, True)
			Dim cmdNumberOfEntries2 As Global.System.Windows.Forms.Control = Me.cmdNumberOfEntries
			size = New Global.System.Drawing.Size(24, 24)
			cmdNumberOfEntries2.Size = size
			Me.cmdNumberOfEntries.TabIndex = 1
			Me.cmdNumberOfEntries.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdNumberOfEntries, "Specify number of entries to be added to Survey")
			Me.cmdNumberOfEntries.UseVisualStyleBackColor = False
			Me.cmdPrint.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdPrint.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdPrint.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.cmdPrint.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdPrint.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdPrint, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdPrint, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdPrint.Image = CType(componentResourceManager.GetObject("cmdPrint.Image"), Global.System.Drawing.Image)
			Me.cmdPrint.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdPrint As Global.System.Windows.Forms.Control = Me.cmdPrint
			location = New Global.System.Drawing.Point(3, 184)
			cmdPrint.Location = location
			Me.cmdPrint.Name = "cmdPrint"
			Me.cmdPrint.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdPrint, True)
			Dim cmdPrint2 As Global.System.Windows.Forms.Control = Me.cmdPrint
			size = New Global.System.Drawing.Size(24, 24)
			cmdPrint2.Size = size
			Me.cmdPrint.TabIndex = 4
			Me.cmdPrint.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdPrint, "Print Survey")
			Me.cmdPrint.UseVisualStyleBackColor = False
			Me.btnReadTest.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.HelpProvider1.SetHelpKeyword(Me.btnReadTest, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.btnReadTest, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.btnReadTest.ImageIndex = 4
			Me.btnReadTest.ImageList = Me.ImageList3
			Me.btnReadTest.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnReadTest As Global.System.Windows.Forms.Control = Me.btnReadTest
			location = New Global.System.Drawing.Point(3, 312)
			btnReadTest.Location = location
			Me.btnReadTest.Name = "btnReadTest"
			Me.HelpProvider1.SetShowHelp(Me.btnReadTest, True)
			Dim btnReadTest2 As Global.System.Windows.Forms.Control = Me.btnReadTest
			size = New Global.System.Drawing.Size(24, 24)
			btnReadTest2.Size = size
			Me.btnReadTest.TabIndex = 7
			Me.ToolTip1.SetToolTip(Me.btnReadTest, "Import Wizard")
			Me.ImageList3.ImageStream = CType(componentResourceManager.GetObject("ImageList3.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList3.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList3.Images.SetKeyName(0, "")
			Me.ImageList3.Images.SetKeyName(1, "")
			Me.ImageList3.Images.SetKeyName(2, "")
			Me.ImageList3.Images.SetKeyName(3, "")
			Me.ImageList3.Images.SetKeyName(4, "")
			Me.btnResetPlot.Image = CType(componentResourceManager.GetObject("btnResetPlot.Image"), Global.System.Drawing.Image)
			Me.btnResetPlot.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnResetPlot As Global.System.Windows.Forms.Control = Me.btnResetPlot
			location = New Global.System.Drawing.Point(648, 3)
			btnResetPlot.Location = location
			Me.btnResetPlot.Name = "btnResetPlot"
			Me.HelpProvider1.SetShowHelp(Me.btnResetPlot, False)
			Dim btnResetPlot2 As Global.System.Windows.Forms.Control = Me.btnResetPlot
			size = New Global.System.Drawing.Size(24, 25)
			btnResetPlot2.Size = size
			Me.btnResetPlot.TabIndex = 12
			Me.ToolTip1.SetToolTip(Me.btnResetPlot, "Reset Deviation Survey Plot")
			Me.btnResetPlot.Visible = False
			Me.cmdDeleteALLSections.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdDeleteALLSections.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdDeleteALLSections.Enabled = False
			Me.cmdDeleteALLSections.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.cmdDeleteALLSections.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdDeleteALLSections.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdDeleteALLSections, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdDeleteALLSections, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdDeleteALLSections.Image = CType(componentResourceManager.GetObject("cmdDeleteALLSections.Image"), Global.System.Drawing.Image)
			Me.cmdDeleteALLSections.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdDeleteALLSections As Global.System.Windows.Forms.Control = Me.cmdDeleteALLSections
			location = New Global.System.Drawing.Point(3, 144)
			cmdDeleteALLSections.Location = location
			Me.cmdDeleteALLSections.Name = "cmdDeleteALLSections"
			Me.cmdDeleteALLSections.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdDeleteALLSections, True)
			Dim cmdDeleteALLSections2 As Global.System.Windows.Forms.Control = Me.cmdDeleteALLSections
			size = New Global.System.Drawing.Size(24, 22)
			cmdDeleteALLSections2.Size = size
			Me.cmdDeleteALLSections.TabIndex = 189
			Me.cmdDeleteALLSections.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdDeleteALLSections, "Remove ALL entries from the deviation survey")
			Me.cmdDeleteALLSections.UseVisualStyleBackColor = False
			Me.btnImport.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.HelpProvider1.SetHelpKeyword(Me.btnImport, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.btnImport, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.btnImport.Image = CType(componentResourceManager.GetObject("btnImport.Image"), Global.System.Drawing.Image)
			Me.btnImport.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnImport As Global.System.Windows.Forms.Control = Me.btnImport
			location = New Global.System.Drawing.Point(3, 288)
			btnImport.Location = location
			Me.btnImport.Name = "btnImport"
			Me.HelpProvider1.SetShowHelp(Me.btnImport, True)
			Dim btnImport2 As Global.System.Windows.Forms.Control = Me.btnImport
			size = New Global.System.Drawing.Size(24, 24)
			btnImport2.Size = size
			Me.btnImport.TabIndex = 193
			Me.ToolTip1.SetToolTip(Me.btnImport, "Import Survey")
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.HelpProvider1.SetHelpKeyword(Me.Button1, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.Button1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.Button1.ImageIndex = 4
			Me.Button1.ImageList = Me.ImageList3
			Me.Button1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(3, 288)
			button.Location = location
			Me.Button1.Name = "Button1"
			Me.HelpProvider1.SetShowHelp(Me.Button1, True)
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(24, 24)
			button2.Size = size
			Me.Button1.TabIndex = 192
			Me.ToolTip1.SetToolTip(Me.Button1, "Import Wizard")
			Me.btnExport.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.HelpProvider1.SetHelpKeyword(Me.btnExport, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.btnExport, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.btnExport.Image = CType(componentResourceManager.GetObject("btnExport.Image"), Global.System.Drawing.Image)
			Me.btnExport.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnExport As Global.System.Windows.Forms.Control = Me.btnExport
			location = New Global.System.Drawing.Point(3, 312)
			btnExport.Location = location
			Me.btnExport.Name = "btnExport"
			Me.HelpProvider1.SetShowHelp(Me.btnExport, True)
			Dim btnExport2 As Global.System.Windows.Forms.Control = Me.btnExport
			size = New Global.System.Drawing.Size(24, 24)
			btnExport2.Size = size
			Me.btnExport.TabIndex = 194
			Me.ToolTip1.SetToolTip(Me.btnExport, "Export Survey")
			Dim btnPaste As Global.System.Windows.Forms.Control = Me.btnPaste
			location = New Global.System.Drawing.Point(4, 349)
			btnPaste.Location = location
			Me.btnPaste.Name = "btnPaste"
			Dim btnPaste2 As Global.System.Windows.Forms.Control = Me.btnPaste
			size = New Global.System.Drawing.Size(23, 20)
			btnPaste2.Size = size
			Me.btnPaste.TabIndex = 196
			Me.btnPaste.Text = "P"
			Me.ToolTip1.SetToolTip(Me.btnPaste, "Paste deviation survey profile data from clipboard")
			Me.btnPaste.UseVisualStyleBackColor = True
			Me.picRemoveFocus.BackColor = Global.System.Drawing.SystemColors.Control
			Me.picRemoveFocus.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.picRemoveFocus.Controls.Add(Me.tabInput)
			Me.picRemoveFocus.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.picRemoveFocus.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.picRemoveFocus.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim picRemoveFocus As Global.System.Windows.Forms.Control = Me.picRemoveFocus
			location = New Global.System.Drawing.Point(8, 0)
			picRemoveFocus.Location = location
			Me.picRemoveFocus.Name = "picRemoveFocus"
			Me.picRemoveFocus.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.picRemoveFocus, False)
			Dim picRemoveFocus2 As Global.System.Windows.Forms.Control = Me.picRemoveFocus
			size = New Global.System.Drawing.Size(988, 572)
			picRemoveFocus2.Size = size
			Me.picRemoveFocus.TabIndex = 13
			Me.picRemoveFocus.TabStop = True
			Me.tabInput.Alignment = Global.System.Windows.Forms.TabAlignment.Right
			Me.tabInput.Controls.Add(Me._tabInput_TabPage0)
			Me.tabInput.Controls.Add(Me._tabInput_TabPage2)
			Me.tabInput.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.HelpProvider1.SetHelpKeyword(Me.tabInput, "Deviation Plot")
			Me.HelpProvider1.SetHelpNavigator(Me.tabInput, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim tabInput As Global.System.Windows.Forms.TabControl = Me.tabInput
			size = New Global.System.Drawing.Size(42, 18)
			tabInput.ItemSize = size
			Dim tabInput2 As Global.System.Windows.Forms.Control = Me.tabInput
			location = New Global.System.Drawing.Point(1, 0)
			tabInput2.Location = location
			Me.tabInput.Multiline = True
			Me.tabInput.Name = "tabInput"
			Me.tabInput.SelectedIndex = 0
			Me.HelpProvider1.SetShowHelp(Me.tabInput, True)
			Dim tabInput3 As Global.System.Windows.Forms.Control = Me.tabInput
			size = New Global.System.Drawing.Size(973, 556)
			tabInput3.Size = size
			Me.tabInput.TabIndex = 14
			Me.tabInput.TabStop = False
			Me._tabInput_TabPage0.Controls.Add(Me.btnPaste)
			Me._tabInput_TabPage0.Controls.Add(Me.btnImport)
			Me._tabInput_TabPage0.Controls.Add(Me.Button1)
			Me._tabInput_TabPage0.Controls.Add(Me.btnExport)
			Me._tabInput_TabPage0.Controls.Add(Me.cmdDeleteALLSections)
			Me._tabInput_TabPage0.Controls.Add(Me.lblTemp)
			Me._tabInput_TabPage0.Controls.Add(Me.btnReadTest)
			Me._tabInput_TabPage0.Controls.Add(Me.txtInclination)
			Me._tabInput_TabPage0.Controls.Add(Me.txtAzimuth)
			Me._tabInput_TabPage0.Controls.Add(Me.tabDirection)
			Me._tabInput_TabPage0.Controls.Add(Me.cmdAddSection)
			Me._tabInput_TabPage0.Controls.Add(Me.cmdDelSection)
			Me._tabInput_TabPage0.Controls.Add(Me.cmdMoveSectionUp)
			Me._tabInput_TabPage0.Controls.Add(Me.cmdMoveSectionDown)
			Me._tabInput_TabPage0.Controls.Add(Me.cmdNumberOfEntries)
			Me._tabInput_TabPage0.Controls.Add(Me.cmdPrint)
			Me._tabInput_TabPage0.Controls.Add(Me.ulgDeviationProfile)
			Me.HelpProvider1.SetHelpKeyword(Me._tabInput_TabPage0, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me._tabInput_TabPage0, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim tabInput_TabPage As Global.System.Windows.Forms.TabPage = Me._tabInput_TabPage0
			location = New Global.System.Drawing.Point(4, 4)
			tabInput_TabPage.Location = location
			Me._tabInput_TabPage0.Name = "_tabInput_TabPage0"
			Me.HelpProvider1.SetShowHelp(Me._tabInput_TabPage0, True)
			Dim tabInput_TabPage2 As Global.System.Windows.Forms.Control = Me._tabInput_TabPage0
			size = New Global.System.Drawing.Size(947, 548)
			tabInput_TabPage2.Size = size
			Me._tabInput_TabPage0.TabIndex = 0
			Me._tabInput_TabPage0.Text = "  Deviation Survey  "
			Me.lblTemp.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblTemp As Global.System.Windows.Forms.Control = Me.lblTemp
			location = New Global.System.Drawing.Point(342, 252)
			lblTemp.Location = location
			Me.lblTemp.Name = "lblTemp"
			Me.HelpProvider1.SetShowHelp(Me.lblTemp, False)
			Dim lblTemp2 As Global.System.Windows.Forms.Control = Me.lblTemp
			size = New Global.System.Drawing.Size(56, 16)
			lblTemp2.Size = size
			Me.lblTemp.TabIndex = 188
			Me.lblTemp.Text = "lblTemp"
			Me.lblTemp.Visible = False
			Me.txtInclination.AcceptsReturn = True
			Me.txtInclination.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtInclination.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtInclination.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.txtInclination.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtInclination, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.txtInclination, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtInclination As Global.System.Windows.Forms.Control = Me.txtInclination
			location = New Global.System.Drawing.Point(231, 192)
			txtInclination.Location = location
			Me.txtInclination.MaxLength = 0
			Me.txtInclination.Name = "txtInclination"
			Me.txtInclination.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtInclination, True)
			Dim txtInclination2 As Global.System.Windows.Forms.Control = Me.txtInclination
			size = New Global.System.Drawing.Size(102, 22)
			txtInclination2.Size = size
			Me.txtInclination.TabIndex = 48
			Me.txtInclination.Visible = False
			Me.txtAzimuth.AcceptsReturn = True
			Me.txtAzimuth.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtAzimuth.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtAzimuth.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.txtAzimuth.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtAzimuth, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.txtAzimuth, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtAzimuth As Global.System.Windows.Forms.Control = Me.txtAzimuth
			location = New Global.System.Drawing.Point(335, 192)
			txtAzimuth.Location = location
			Me.txtAzimuth.MaxLength = 0
			Me.txtAzimuth.Name = "txtAzimuth"
			Me.txtAzimuth.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtAzimuth, True)
			Dim txtAzimuth2 As Global.System.Windows.Forms.Control = Me.txtAzimuth
			size = New Global.System.Drawing.Size(102, 22)
			txtAzimuth2.Size = size
			Me.txtAzimuth.TabIndex = 54
			Me.txtAzimuth.Visible = False
			Me.tabDirection.Appearance = Global.System.Windows.Forms.TabAppearance.Buttons
			Me.tabDirection.Controls.Add(Me.NE)
			Me.tabDirection.Controls.Add(Me.NW)
			Me.tabDirection.Controls.Add(Me.SE)
			Me.tabDirection.Controls.Add(Me.SW)
			Me.tabDirection.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.HelpProvider1.SetHelpKeyword(Me.tabDirection, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.tabDirection, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.tabDirection.ImageList = Me.ImageList3
			Dim tabDirection As Global.System.Windows.Forms.TabControl = Me.tabDirection
			size = New Global.System.Drawing.Size(51, 22)
			tabDirection.ItemSize = size
			Dim tabDirection2 As Global.System.Windows.Forms.Control = Me.tabDirection
			location = New Global.System.Drawing.Point(0, 524)
			tabDirection2.Location = location
			Me.tabDirection.Name = "tabDirection"
			Me.tabDirection.SelectedIndex = 0
			Me.HelpProvider1.SetShowHelp(Me.tabDirection, True)
			Dim tabDirection3 As Global.System.Windows.Forms.Control = Me.tabDirection
			size = New Global.System.Drawing.Size(947, 24)
			tabDirection3.Size = size
			Me.tabDirection.TabIndex = 9
			Me.NE.ImageIndex = 0
			Dim ne As Global.System.Windows.Forms.TabPage = Me.NE
			location = New Global.System.Drawing.Point(4, 26)
			ne.Location = location
			Me.NE.Name = "NE"
			Me.HelpProvider1.SetShowHelp(Me.NE, False)
			Dim ne2 As Global.System.Windows.Forms.Control = Me.NE
			size = New Global.System.Drawing.Size(939, 0)
			ne2.Size = size
			Me.NE.TabIndex = 0
			Me.NE.Text = "N-E"
			Me.NW.ImageIndex = 1
			Dim nw As Global.System.Windows.Forms.TabPage = Me.NW
			location = New Global.System.Drawing.Point(4, 26)
			nw.Location = location
			Me.NW.Name = "NW"
			Me.HelpProvider1.SetShowHelp(Me.NW, False)
			Dim nw2 As Global.System.Windows.Forms.Control = Me.NW
			size = New Global.System.Drawing.Size(939, 0)
			nw2.Size = size
			Me.NW.TabIndex = 1
			Me.NW.Text = "N-W"
			Me.NW.Visible = False
			Me.SE.ImageIndex = 2
			Dim se As Global.System.Windows.Forms.TabPage = Me.SE
			location = New Global.System.Drawing.Point(4, 26)
			se.Location = location
			Me.SE.Name = "SE"
			Me.HelpProvider1.SetShowHelp(Me.SE, False)
			Dim se2 As Global.System.Windows.Forms.Control = Me.SE
			size = New Global.System.Drawing.Size(939, 0)
			se2.Size = size
			Me.SE.TabIndex = 2
			Me.SE.Text = "S-E"
			Me.SE.Visible = False
			Me.SW.ImageIndex = 3
			Dim sw As Global.System.Windows.Forms.TabPage = Me.SW
			location = New Global.System.Drawing.Point(4, 26)
			sw.Location = location
			Me.SW.Name = "SW"
			Me.HelpProvider1.SetShowHelp(Me.SW, False)
			Dim sw2 As Global.System.Windows.Forms.Control = Me.SW
			size = New Global.System.Drawing.Size(939, 0)
			sw2.Size = size
			Me.SW.TabIndex = 3
			Me.SW.Text = "S-W"
			Me.SW.Visible = False
			Me.ulgDeviationProfile.AllowDrop = True
			Me.ulgDeviationProfile.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.ulgDeviationProfile, "Deviation Profile Information")
			Me.HelpProvider1.SetHelpNavigator(Me.ulgDeviationProfile, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim ulgDeviationProfile As Global.System.Windows.Forms.Control = Me.ulgDeviationProfile
			location = New Global.System.Drawing.Point(33, 11)
			ulgDeviationProfile.Location = location
			Me.ulgDeviationProfile.Name = "ulgDeviationProfile"
			Me.HelpProvider1.SetShowHelp(Me.ulgDeviationProfile, True)
			Dim ulgDeviationProfile2 As Global.System.Windows.Forms.Control = Me.ulgDeviationProfile
			size = New Global.System.Drawing.Size(899, 492)
			ulgDeviationProfile2.Size = size
			Me.ulgDeviationProfile.TabIndex = 8
			Me._tabInput_TabPage2.Controls.Add(Me.grpDevPlot)
			Me.HelpProvider1.SetHelpKeyword(Me._tabInput_TabPage2, "Deviation Plot")
			Me.HelpProvider1.SetHelpNavigator(Me._tabInput_TabPage2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim tabInput_TabPage3 As Global.System.Windows.Forms.TabPage = Me._tabInput_TabPage2
			location = New Global.System.Drawing.Point(4, 4)
			tabInput_TabPage3.Location = location
			Me._tabInput_TabPage2.Name = "_tabInput_TabPage2"
			Me.HelpProvider1.SetShowHelp(Me._tabInput_TabPage2, True)
			Dim tabInput_TabPage4 As Global.System.Windows.Forms.Control = Me._tabInput_TabPage2
			size = New Global.System.Drawing.Size(947, 548)
			tabInput_TabPage4.Size = size
			Me._tabInput_TabPage2.TabIndex = 2
			Me._tabInput_TabPage2.Text = "  Plot Survey  "
			Me.grpDevPlot.BackColor = Global.System.Drawing.SystemColors.Control
			Me.grpDevPlot.Controls.Add(Me.pnlLegend)
			Me.grpDevPlot.Controls.Add(Me.Panel2)
			Me.grpDevPlot.Controls.Add(Me.Panel1)
			Me.grpDevPlot.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.grpDevPlot.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.grpDevPlot, "Deviation Plot")
			Me.HelpProvider1.SetHelpNavigator(Me.grpDevPlot, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim grpDevPlot As Global.System.Windows.Forms.Control = Me.grpDevPlot
			location = New Global.System.Drawing.Point(8, 16)
			grpDevPlot.Location = location
			Me.grpDevPlot.Name = "grpDevPlot"
			Me.grpDevPlot.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.grpDevPlot, True)
			Dim grpDevPlot2 As Global.System.Windows.Forms.Control = Me.grpDevPlot
			size = New Global.System.Drawing.Size(776, 524)
			grpDevPlot2.Size = size
			Me.grpDevPlot.TabIndex = 25
			Me.grpDevPlot.TabStop = False
			Me.pnlLegend.Controls.Add(Me.lblDiameters2)
			Me.pnlLegend.Controls.Add(Me.lblDiameters)
			Me.pnlLegend.Controls.Add(Me.T20)
			Me.pnlLegend.Controls.Add(Me.T19)
			Me.pnlLegend.Controls.Add(Me.T18)
			Me.pnlLegend.Controls.Add(Me.T17)
			Me.pnlLegend.Controls.Add(Me.T16)
			Me.pnlLegend.Controls.Add(Me.T15)
			Me.pnlLegend.Controls.Add(Me.T14)
			Me.pnlLegend.Controls.Add(Me.T13)
			Me.pnlLegend.Controls.Add(Me.T12)
			Me.pnlLegend.Controls.Add(Me.T11)
			Me.pnlLegend.Controls.Add(Me.T10)
			Me.pnlLegend.Controls.Add(Me.T9)
			Me.pnlLegend.Controls.Add(Me.T8)
			Me.pnlLegend.Controls.Add(Me.T7)
			Me.pnlLegend.Controls.Add(Me.T6)
			Me.pnlLegend.Controls.Add(Me.T5)
			Me.pnlLegend.Controls.Add(Me.T4)
			Me.pnlLegend.Controls.Add(Me.T3)
			Me.pnlLegend.Controls.Add(Me.T2)
			Me.pnlLegend.Controls.Add(Me.T1)
			Dim pnlLegend As Global.System.Windows.Forms.Control = Me.pnlLegend
			location = New Global.System.Drawing.Point(3, 485)
			pnlLegend.Location = location
			Me.pnlLegend.Name = "pnlLegend"
			Dim pnlLegend2 As Global.System.Windows.Forms.Control = Me.pnlLegend
			size = New Global.System.Drawing.Size(751, 39)
			pnlLegend2.Size = size
			Me.pnlLegend.TabIndex = 28
			Me.pnlLegend.Visible = False
			Me.lblDiameters2.AutoSize = True
			Me.lblDiameters2.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim lblDiameters As Global.System.Windows.Forms.Control = Me.lblDiameters2
			location = New Global.System.Drawing.Point(2, 18)
			lblDiameters.Location = location
			Me.lblDiameters2.Name = "lblDiameters2"
			Dim lblDiameters2 As Global.System.Windows.Forms.Control = Me.lblDiameters2
			size = New Global.System.Drawing.Size(79, 13)
			lblDiameters2.Size = size
			Me.lblDiameters2.TabIndex = 49
			Me.lblDiameters2.Text = "Rod Diameters:"
			Me.lblDiameters2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblDiameters2.Visible = False
			Me.lblDiameters.AutoSize = True
			Me.lblDiameters.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim lblDiameters3 As Global.System.Windows.Forms.Control = Me.lblDiameters
			location = New Global.System.Drawing.Point(2, 5)
			lblDiameters3.Location = location
			Me.lblDiameters.Name = "lblDiameters"
			Dim lblDiameters4 As Global.System.Windows.Forms.Control = Me.lblDiameters
			size = New Global.System.Drawing.Size(79, 13)
			lblDiameters4.Size = size
			Me.lblDiameters.TabIndex = 37
			Me.lblDiameters.Text = "Rod Diameters:"
			Me.lblDiameters.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T20.AutoSize = True
			Me.T20.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t As Global.System.Windows.Forms.Control = Me.T20
			location = New Global.System.Drawing.Point(582, 18)
			t.Location = location
			Me.T20.Name = "T20"
			Dim t2 As Global.System.Windows.Forms.Control = Me.T20
			size = New Global.System.Drawing.Size(26, 13)
			t2.Size = size
			Me.T20.TabIndex = 47
			Me.T20.Text = "T20"
			Me.T20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T20.Visible = False
			Me.T19.AutoSize = True
			Me.T19.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t3 As Global.System.Windows.Forms.Control = Me.T19
			location = New Global.System.Drawing.Point(527, 18)
			t3.Location = location
			Me.T19.Name = "T19"
			Dim t4 As Global.System.Windows.Forms.Control = Me.T19
			size = New Global.System.Drawing.Size(26, 13)
			t4.Size = size
			Me.T19.TabIndex = 46
			Me.T19.Text = "T19"
			Me.T19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T19.Visible = False
			Me.T18.AutoSize = True
			Me.T18.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t5 As Global.System.Windows.Forms.Control = Me.T18
			location = New Global.System.Drawing.Point(468, 18)
			t5.Location = location
			Me.T18.Name = "T18"
			Dim t6 As Global.System.Windows.Forms.Control = Me.T18
			size = New Global.System.Drawing.Size(26, 13)
			t6.Size = size
			Me.T18.TabIndex = 45
			Me.T18.Text = "T18"
			Me.T18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T18.Visible = False
			Me.T17.AutoSize = True
			Me.T17.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t7 As Global.System.Windows.Forms.Control = Me.T17
			location = New Global.System.Drawing.Point(407, 18)
			t7.Location = location
			Me.T17.Name = "T17"
			Dim t8 As Global.System.Windows.Forms.Control = Me.T17
			size = New Global.System.Drawing.Size(26, 13)
			t8.Size = size
			Me.T17.TabIndex = 44
			Me.T17.Text = "T17"
			Me.T17.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T17.Visible = False
			Me.T16.AutoSize = True
			Me.T16.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t9 As Global.System.Windows.Forms.Control = Me.T16
			location = New Global.System.Drawing.Point(348, 18)
			t9.Location = location
			Me.T16.Name = "T16"
			Dim t10 As Global.System.Windows.Forms.Control = Me.T16
			size = New Global.System.Drawing.Size(26, 13)
			t10.Size = size
			Me.T16.TabIndex = 43
			Me.T16.Text = "T16"
			Me.T16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T16.Visible = False
			Me.T15.AutoSize = True
			Me.T15.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t11 As Global.System.Windows.Forms.Control = Me.T15
			location = New Global.System.Drawing.Point(292, 18)
			t11.Location = location
			Me.T15.Name = "T15"
			Dim t12 As Global.System.Windows.Forms.Control = Me.T15
			size = New Global.System.Drawing.Size(26, 13)
			t12.Size = size
			Me.T15.TabIndex = 42
			Me.T15.Text = "T15"
			Me.T15.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T15.Visible = False
			Me.T14.AutoSize = True
			Me.T14.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t13 As Global.System.Windows.Forms.Control = Me.T14
			location = New Global.System.Drawing.Point(238, 18)
			t13.Location = location
			Me.T14.Name = "T14"
			Dim t14 As Global.System.Windows.Forms.Control = Me.T14
			size = New Global.System.Drawing.Size(26, 13)
			t14.Size = size
			Me.T14.TabIndex = 41
			Me.T14.Text = "T14"
			Me.T14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T14.Visible = False
			Me.T13.AutoSize = True
			Me.T13.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t15 As Global.System.Windows.Forms.Control = Me.T13
			location = New Global.System.Drawing.Point(183, 18)
			t15.Location = location
			Me.T13.Name = "T13"
			Dim t16 As Global.System.Windows.Forms.Control = Me.T13
			size = New Global.System.Drawing.Size(26, 13)
			t16.Size = size
			Me.T13.TabIndex = 40
			Me.T13.Text = "T13"
			Me.T13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T13.Visible = False
			Me.T12.AutoSize = True
			Me.T12.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t17 As Global.System.Windows.Forms.Control = Me.T12
			location = New Global.System.Drawing.Point(126, 18)
			t17.Location = location
			Me.T12.Name = "T12"
			Dim t18 As Global.System.Windows.Forms.Control = Me.T12
			size = New Global.System.Drawing.Size(26, 13)
			t18.Size = size
			Me.T12.TabIndex = 39
			Me.T12.Text = "T12"
			Me.T12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T12.Visible = False
			Me.T11.AutoSize = True
			Me.T11.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t19 As Global.System.Windows.Forms.Control = Me.T11
			location = New Global.System.Drawing.Point(80, 18)
			t19.Location = location
			Me.T11.Name = "T11"
			Dim t20 As Global.System.Windows.Forms.Control = Me.T11
			size = New Global.System.Drawing.Size(25, 13)
			t20.Size = size
			Me.T11.TabIndex = 38
			Me.T11.Text = "T11"
			Me.T11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T11.Visible = False
			Me.T10.AutoSize = True
			Me.T10.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t21 As Global.System.Windows.Forms.Control = Me.T10
			location = New Global.System.Drawing.Point(582, 5)
			t21.Location = location
			Me.T10.Name = "T10"
			Dim t22 As Global.System.Windows.Forms.Control = Me.T10
			size = New Global.System.Drawing.Size(26, 13)
			t22.Size = size
			Me.T10.TabIndex = 36
			Me.T10.Text = "T10"
			Me.T10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T10.Visible = False
			Me.T9.AutoSize = True
			Me.T9.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t23 As Global.System.Windows.Forms.Control = Me.T9
			location = New Global.System.Drawing.Point(527, 5)
			t23.Location = location
			Me.T9.Name = "T9"
			Dim t24 As Global.System.Windows.Forms.Control = Me.T9
			size = New Global.System.Drawing.Size(20, 13)
			t24.Size = size
			Me.T9.TabIndex = 35
			Me.T9.Text = "T9"
			Me.T9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T9.Visible = False
			Me.T8.AutoSize = True
			Me.T8.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t25 As Global.System.Windows.Forms.Control = Me.T8
			location = New Global.System.Drawing.Point(468, 5)
			t25.Location = location
			Me.T8.Name = "T8"
			Dim t26 As Global.System.Windows.Forms.Control = Me.T8
			size = New Global.System.Drawing.Size(20, 13)
			t26.Size = size
			Me.T8.TabIndex = 34
			Me.T8.Text = "T8"
			Me.T8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T8.Visible = False
			Me.T7.AutoSize = True
			Me.T7.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t27 As Global.System.Windows.Forms.Control = Me.T7
			location = New Global.System.Drawing.Point(407, 5)
			t27.Location = location
			Me.T7.Name = "T7"
			Dim t28 As Global.System.Windows.Forms.Control = Me.T7
			size = New Global.System.Drawing.Size(20, 13)
			t28.Size = size
			Me.T7.TabIndex = 33
			Me.T7.Text = "T7"
			Me.T7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T7.Visible = False
			Me.T6.AutoSize = True
			Me.T6.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t29 As Global.System.Windows.Forms.Control = Me.T6
			location = New Global.System.Drawing.Point(348, 5)
			t29.Location = location
			Me.T6.Name = "T6"
			Dim t30 As Global.System.Windows.Forms.Control = Me.T6
			size = New Global.System.Drawing.Size(20, 13)
			t30.Size = size
			Me.T6.TabIndex = 32
			Me.T6.Text = "T6"
			Me.T6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T6.Visible = False
			Me.T5.AutoSize = True
			Me.T5.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t31 As Global.System.Windows.Forms.Control = Me.T5
			location = New Global.System.Drawing.Point(292, 5)
			t31.Location = location
			Me.T5.Name = "T5"
			Dim t32 As Global.System.Windows.Forms.Control = Me.T5
			size = New Global.System.Drawing.Size(20, 13)
			t32.Size = size
			Me.T5.TabIndex = 31
			Me.T5.Text = "T5"
			Me.T5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T5.Visible = False
			Me.T4.AutoSize = True
			Me.T4.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t33 As Global.System.Windows.Forms.Control = Me.T4
			location = New Global.System.Drawing.Point(238, 5)
			t33.Location = location
			Me.T4.Name = "T4"
			Dim t34 As Global.System.Windows.Forms.Control = Me.T4
			size = New Global.System.Drawing.Size(20, 13)
			t34.Size = size
			Me.T4.TabIndex = 30
			Me.T4.Text = "T4"
			Me.T4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T4.Visible = False
			Me.T3.AutoSize = True
			Me.T3.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t35 As Global.System.Windows.Forms.Control = Me.T3
			location = New Global.System.Drawing.Point(183, 5)
			t35.Location = location
			Me.T3.Name = "T3"
			Dim t36 As Global.System.Windows.Forms.Control = Me.T3
			size = New Global.System.Drawing.Size(20, 13)
			t36.Size = size
			Me.T3.TabIndex = 29
			Me.T3.Text = "T3"
			Me.T3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T3.Visible = False
			Me.T2.AutoSize = True
			Me.T2.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t37 As Global.System.Windows.Forms.Control = Me.T2
			location = New Global.System.Drawing.Point(126, 5)
			t37.Location = location
			Me.T2.Name = "T2"
			Dim t38 As Global.System.Windows.Forms.Control = Me.T2
			size = New Global.System.Drawing.Size(20, 13)
			t38.Size = size
			Me.T2.TabIndex = 28
			Me.T2.Text = "T2"
			Me.T2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T2.Visible = False
			Me.T1.AutoSize = True
			Me.T1.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t39 As Global.System.Windows.Forms.Control = Me.T1
			location = New Global.System.Drawing.Point(80, 5)
			t39.Location = location
			Me.T1.Name = "T1"
			Dim t40 As Global.System.Windows.Forms.Control = Me.T1
			size = New Global.System.Drawing.Size(20, 13)
			t40.Size = size
			Me.T1.TabIndex = 27
			Me.T1.Text = "T1"
			Me.T1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.T1.Visible = False
			Me.Panel2.Controls.Add(Me.lblNoData)
			Me.Panel2.Controls.Add(Me.TChart1)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel2
			location = New Global.System.Drawing.Point(16, 53)
			panel.Location = location
			Me.Panel2.Name = "Panel2"
			Me.HelpProvider1.SetShowHelp(Me.Panel2, False)
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(657, 426)
			panel2.Size = size
			Me.Panel2.TabIndex = 11
			Me.lblNoData.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblNoData.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblNoData As Global.System.Windows.Forms.Control = Me.lblNoData
			location = New Global.System.Drawing.Point(16, 104)
			lblNoData.Location = location
			Me.lblNoData.Name = "lblNoData"
			Me.HelpProvider1.SetShowHelp(Me.lblNoData, False)
			Dim lblNoData2 As Global.System.Windows.Forms.Control = Me.lblNoData
			size = New Global.System.Drawing.Size(688, 24)
			lblNoData2.Size = size
			Me.lblNoData.TabIndex = 12
			Me.lblNoData.Text = "Valid survey data not available for plotting!"
			Me.lblNoData.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblNoData.Visible = False
			Me.TChart1.Aspect.Chart3DPercent = 100
			Me.TChart1.Aspect.ZOffset = 0.0
			Me.TChart1.Axes.Bottom.Title.Caption = "West - East"
			Me.TChart1.Axes.Bottom.Title.Lines = New String() { "West - East" }
			Me.TChart1.Axes.Depth.Title.Caption = "South - North"
			Me.TChart1.Axes.Depth.Title.Lines = New String() { "South - North" }
			Me.TChart1.Axes.Depth.Visible = True
			Me.TChart1.Axes.Left.Inverted = True
			Me.TChart1.Axes.Left.Title.Caption = "True Vertical Depth"
			Me.TChart1.Axes.Left.Title.Font.Size = 9
			Me.TChart1.Axes.Left.Title.Font.SizeFloat = 9F
			Me.TChart1.Axes.Left.Title.Lines = New String() { "True Vertical Depth" }
			Me.TChart1.BackColor = Global.System.Drawing.Color.Transparent
			Me.TChart1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.TChart1.Header.Font.Brush.Color = Global.System.Drawing.Color.Black
			Me.TChart1.Header.Font.Size = 9
			Me.TChart1.Header.Font.SizeFloat = 9F
			Me.TChart1.Header.Lines = New String() { "Deviation Survey Plot", "" }
			Me.HelpProvider1.SetHelpKeyword(Me.TChart1, "Deviation Plot")
			Me.HelpProvider1.SetHelpNavigator(Me.TChart1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.TChart1.Legend.Visible = False
			Dim tchart As Global.System.Windows.Forms.Control = Me.TChart1
			location = New Global.System.Drawing.Point(10, 8)
			tchart.Location = location
			Me.TChart1.Name = "TChart1"
			Me.TChart1.Panel.Brush.Color = Global.System.Drawing.Color.FromArgb(0, 212, 208, 200)
			Me.TChart1.Panel.Brush.Gradient.MiddleColor = Global.System.Drawing.Color.FromArgb(255, 255, 255)
			Me.TChart1.Panel.Brush.Gradient.StartColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.TChart1.Panel.Shadow.Visible = True
			Me.TChart1.Series.Add(Me.point3DSeries1)
			Me.HelpProvider1.SetShowHelp(Me.TChart1, True)
			Dim tchart2 As Global.System.Windows.Forms.Control = Me.TChart1
			size = New Global.System.Drawing.Size(639, 404)
			tchart2.Size = size
			Me.TChart1.TabIndex = 11
			Me.TChart1.Tools.Add(Me.MarksTip1)
			Me.TChart1.Visible = False
			Me.point3DSeries1.Color = Global.System.Drawing.Color.FromArgb(68, 102, 163)
			Me.point3DSeries1.ColorEach = False
			Me.point3DSeries1.DepthSize = 7.0
			Me.point3DSeries1.LinePen.Color = Global.System.Drawing.Color.FromArgb(254, 0, 0, 255)
			Me.point3DSeries1.LinePen.EndCap = Global.System.Drawing.Drawing2D.LineCap.Round
			Me.point3DSeries1.LinePen.Width = 3
			Me.point3DSeries1.Marks.Callout.ArrowHead = Global.Steema.TeeChart.Styles.ArrowHeadStyles.None
			Me.point3DSeries1.Marks.Callout.ArrowHeadSize = 8
			Me.point3DSeries1.Marks.Callout.Brush.Color = Global.System.Drawing.Color.Black
			Me.point3DSeries1.Marks.Callout.Distance = 0
			Me.point3DSeries1.Marks.Callout.Draw3D = False
			Me.point3DSeries1.Marks.Callout.Length = 10
			Me.point3DSeries1.Marks.Callout.Series = Me.point3DSeries1
			Me.point3DSeries1.Marks.Callout.Style = Global.Steema.TeeChart.Styles.PointerStyles.Rectangle
			Me.point3DSeries1.Marks.Callout.Visible = False
			Me.point3DSeries1.Marks.Series = Me.point3DSeries1
			Me.point3DSeries1.Marks.Shadow.Visible = False
			Me.point3DSeries1.Marks.ShapeStyle = Global.Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle
			Me.point3DSeries1.Marks.Style = Global.Steema.TeeChart.Styles.MarksStyles.Value
			Me.point3DSeries1.Pointer.Brush.Gradient.StartColor = Global.System.Drawing.Color.FromArgb(68, 102, 163)
			Me.point3DSeries1.Pointer.Dark3D = False
			Me.point3DSeries1.Pointer.Draw3D = False
			Me.point3DSeries1.Pointer.HorizSize = 1
			Me.point3DSeries1.Pointer.InflateMargins = False
			Me.point3DSeries1.Pointer.Pen.Color = Global.System.Drawing.Color.FromArgb(41, 61, 98)
			Me.point3DSeries1.Pointer.Series = Me.point3DSeries1
			Me.point3DSeries1.Pointer.Style = Global.Steema.TeeChart.Styles.PointerStyles.[Nothing]
			Me.point3DSeries1.Pointer.VertSize = 1
			Me.point3DSeries1.Title = "Points3D1"
			Me.point3DSeries1.XValues.DataMember = "X"
			Me.point3DSeries1.YValues.DataMember = "Y"
			Me.point3DSeries1.ZValues.DataMember = "Z"
			Me.MarksTip1.Series = Me.point3DSeries1
			Me.MarksTip1.Style = Global.Steema.TeeChart.Styles.MarksStyles.XY
			Me.Panel1.Controls.Add(Me.btnResetPlot)
			Me.Panel1.Controls.Add(Me.commander1)
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(16, 16)
			panel3.Location = location
			Me.Panel1.Name = "Panel1"
			Me.HelpProvider1.SetShowHelp(Me.Panel1, False)
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(752, 32)
			panel4.Size = size
			Me.Panel1.TabIndex = 10
			Me.commander1.Appearance = Global.System.Windows.Forms.ToolBarAppearance.Flat
			Me.commander1.Chart = Me.TChart1
			Me.commander1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.commander1.DropDownArrows = True
			Me.commander1.LabelValues = True
			Dim commander As Global.System.Windows.Forms.Control = Me.commander1
			location = New Global.System.Drawing.Point(0, 0)
			commander.Location = location
			Me.commander1.Name = "commander1"
			Me.commander1.ShowToolTips = True
			Dim commander2 As Global.System.Windows.Forms.Control = Me.commander1
			size = New Global.System.Drawing.Size(752, 37)
			commander2.Size = size
			Me.commander1.TabIndex = 14
			Me.commander1.Visible = False
			Dim txtTempLength As Global.System.Windows.Forms.Control = Me.txtTempLength
			location = New Global.System.Drawing.Point(1048, 273)
			txtTempLength.Location = location
			Me.txtTempLength.Name = "txtTempLength"
			Me.HelpProvider1.SetShowHelp(Me.txtTempLength, False)
			Dim txtTempLength2 As Global.System.Windows.Forms.Control = Me.txtTempLength
			size = New Global.System.Drawing.Size(96, 20)
			txtTempLength2.Size = size
			Me.txtTempLength.TabIndex = 186
			Me.txtTempLength.Tag = "fem"
			Me.txtTempLength.Text = "txtTempLength"
			Me.txtTempLength.Visible = False
			Me.lblNoDataAvailable.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblNoDataAvailable.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblNoDataAvailable As Global.System.Windows.Forms.Control = Me.lblNoDataAvailable
			location = New Global.System.Drawing.Point(64, 264)
			lblNoDataAvailable.Location = location
			Me.lblNoDataAvailable.Name = "lblNoDataAvailable"
			Me.HelpProvider1.SetShowHelp(Me.lblNoDataAvailable, False)
			Dim lblNoDataAvailable2 As Global.System.Windows.Forms.Control = Me.lblNoDataAvailable
			size = New Global.System.Drawing.Size(688, 24)
			lblNoDataAvailable2.Size = size
			Me.lblNoDataAvailable.TabIndex = 20
			Me.lblNoDataAvailable.Text = "Dogleg severity data not available for plotting!"
			Me.lblNoDataAvailable.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblNoDataAvailable.Visible = False
			Me.Panel_Dogleg.Controls.Add(Me.lblNoDataAvailable)
			Me.Panel_Dogleg.Controls.Add(Me.ChartFX_DoglegSeverity)
			Dim panel_Dogleg As Global.System.Windows.Forms.Control = Me.Panel_Dogleg
			location = New Global.System.Drawing.Point(0, 0)
			panel_Dogleg.Location = location
			Me.Panel_Dogleg.Name = "Panel_Dogleg"
			Dim panel_Dogleg2 As Global.System.Windows.Forms.Control = Me.Panel_Dogleg
			size = New Global.System.Drawing.Size(789, 540)
			panel_Dogleg2.Size = size
			Me.Panel_Dogleg.TabIndex = 187
			Me.Panel_Dogleg.Visible = False
			Me.ChartFX_DoglegSeverity.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_DoglegSeverity.AllSeries.MarkerSize = 4S
			Me.ChartFX_DoglegSeverity.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.ChartFX_DoglegSeverity.AxisX.Title.Text = "Dogleg Severity"
			Me.ChartFX_DoglegSeverity.AxisY.Title.Text = "Measured Depth"
			Me.ChartFX_DoglegSeverity.Border = border
			Me.ChartFX_DoglegSeverity.ContextMenus = False
			Me.ChartFX_DoglegSeverity.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_DoglegSeverity As Global.System.Windows.Forms.Control = Me.ChartFX_DoglegSeverity
			location = New Global.System.Drawing.Point(40, 36)
			chartFX_DoglegSeverity.Location = location
			Me.ChartFX_DoglegSeverity.Name = "ChartFX_DoglegSeverity"
			Dim chartFX_DoglegSeverity2 As Global.System.Windows.Forms.Control = Me.ChartFX_DoglegSeverity
			size = New Global.System.Drawing.Size(736, 472)
			chartFX_DoglegSeverity2.Size = size
			Me.ChartFX_DoglegSeverity.TabIndex = 19
			titleDockable.Text = "Dogleg Severity"
			Me.ChartFX_DoglegSeverity.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable })
			Me.ChartFX_DoglegSeverity.Visible = False
			Me.lblStatus.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblStatus.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.lblStatus.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblStatus.ForeColor = Global.System.Drawing.Color.Black
			Dim lblStatus As Global.System.Windows.Forms.Control = Me.lblStatus
			location = New Global.System.Drawing.Point(0, 589)
			lblStatus.Location = location
			Me.lblStatus.Name = "lblStatus"
			Dim lblStatus2 As Global.System.Windows.Forms.Control = Me.lblStatus
			size = New Global.System.Drawing.Size(1006, 18)
			lblStatus2.Size = size
			Me.lblStatus.TabIndex = 188
			Me.lblStatus.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			Me.BackColor = Global.System.Drawing.SystemColors.Control
			size = New Global.System.Drawing.Size(1006, 607)
			Me.ClientSize = size
			Me.Controls.Add(Me.lblStatus)
			Me.Controls.Add(Me.txtTempLength)
			Me.Controls.Add(Me.picRemoveFocus)
			Me.Controls.Add(Me.Panel_Dogleg)
			Me.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.KeyPreview = True
			location = New Global.System.Drawing.Point(4, 23)
			Me.Location = location
			Me.Name = "DeviationProfile"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Tag = "5"
			Me.Text = "Deviation Profile"
			Me.picRemoveFocus.ResumeLayout(False)
			Me.tabInput.ResumeLayout(False)
			Me._tabInput_TabPage0.ResumeLayout(False)
			Me._tabInput_TabPage0.PerformLayout()
			Me.tabDirection.ResumeLayout(False)
			CType(Me.ulgDeviationProfile, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me._tabInput_TabPage2.ResumeLayout(False)
			Me.grpDevPlot.ResumeLayout(False)
			Me.pnlLegend.ResumeLayout(False)
			Me.pnlLegend.PerformLayout()
			Me.Panel2.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fraPumpDrag, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.optPolishedRodDrag, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.optPumpDragDown, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.optPumpDragUp, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel_Dogleg.ResumeLayout(False)
			Me.Panel_Dogleg.PerformLayout()
			CType(Me.ChartFX_DoglegSeverity, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
