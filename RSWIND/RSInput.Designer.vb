Namespace RSWINV3
	Friend Partial Class RSInput
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.RSInput))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.XSR = New Global.System.Windows.Forms.TabPage()
			Me.XFD = New Global.System.Windows.Forms.TabPage()
			Me.USR = New Global.System.Windows.Forms.TabPage()
			Me.btnNumberOfRods = New Global.System.Windows.Forms.Button()
			Me.cmdAddSection = New Global.System.Windows.Forms.Button()
			Me.cmdDelSection = New Global.System.Windows.Forms.Button()
			Me.cmdMoveSectionUp = New Global.System.Windows.Forms.Button()
			Me.cmdMoveSectionDown = New Global.System.Windows.Forms.Button()
			Me.picRemoveFocus = New Global.System.Windows.Forms.Panel()
			Me._Line_0 = New Global.System.Windows.Forms.Label()
			Me.tbsRodDesignType = New Global.System.Windows.Forms.TabControl()
			Me.imlRodDesignType = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.cboLookupDiameter = New Global.System.Windows.Forms.ComboBox()
			Me.cboLookupDisplayName = New Global.System.Windows.Forms.ComboBox()
			Me.lstNumOfRods = New Global.System.Windows.Forms.ListBox()
			Me._Line_1 = New Global.System.Windows.Forms.Label()
			Me.ctrRodString = New Global.System.Windows.Forms.Panel()
			Me.lblStringLength = New Global.System.Windows.Forms.Label()
			Me.cboRodGuides = New Global.System.Windows.Forms.ComboBox()
			Me.txtLength = New Global.System.Windows.Forms.TextBox()
			Me.lblFricFootnote = New Global.System.Windows.Forms.Label()
			Me.cboRodType = New Global.System.Windows.Forms.ComboBox()
			Me.cboRodGrade = New Global.System.Windows.Forms.ComboBox()
			Me.cboRodSize = New Global.System.Windows.Forms.ComboBox()
			Me.ulgTapers = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me._Label_Length = New Global.System.Windows.Forms.Label()
			Me.ctrSinkerBars = New Global.System.Windows.Forms.Panel()
			Me.fraSinkerBars = New Global.System.Windows.Forms.GroupBox()
			Me.lblRSSRSize = New Global.System.Windows.Forms.Label()
			Me.optSinkerRods = New Global.System.Windows.Forms.RadioButton()
			Me.optSinkerBars = New Global.System.Windows.Forms.RadioButton()
			Me.chkRSIncludeSB = New Global.System.Windows.Forms.CheckBox()
			Me.lblRSSBDiameter = New Global.System.Windows.Forms.Label()
			Me.lblRSSBGrade = New Global.System.Windows.Forms.Label()
			Me.lblRSSBLength = New Global.System.Windows.Forms.Label()
			Me.cboRSSBGrade = New Global.System.Windows.Forms.ComboBox()
			Me.cboRSSBDiameter = New Global.System.Windows.Forms.ComboBox()
			Me.lblRSSBGrade_Disabled = New Global.System.Windows.Forms.Label()
			Me.lbl_RSSBDiameter_Disabled = New Global.System.Windows.Forms.Label()
			Me.chkDesignSinkerbars = New Global.System.Windows.Forms.CheckBox()
			Me.txtRSSBDiameter = New Global.System.Windows.Forms.TextBox()
			Me.lblRSSBDiameter_Disabled = New Global.System.Windows.Forms.Label()
			Me.cboRSSRSize = New Global.System.Windows.Forms.ComboBox()
			Me.lblRSSRSize_Disabled = New Global.System.Windows.Forms.Label()
			Me.txtRSSBLength = New Global.System.Windows.Forms.TextBox()
			Me.lblRSSBLength_Disabled = New Global.System.Windows.Forms.Label()
			Me.ctrOtherInfo = New Global.System.Windows.Forms.Panel()
			Me.fraOtherInfo = New Global.System.Windows.Forms.GroupBox()
			Me.txtRSExtraCostLabel = New Global.System.Windows.Forms.TextBox()
			Me.txtRSFricCoeff = New Global.System.Windows.Forms.TextBox()
			Me.lblRSFricCoeff = New Global.System.Windows.Forms.Label()
			Me.txtServiceFactor = New Global.System.Windows.Forms.TextBox()
			Me.txtRSExtraCost = New Global.System.Windows.Forms.TextBox()
			Me.lblServiceFactor = New Global.System.Windows.Forms.Label()
			Me.lblRSExtraCostLabel = New Global.System.Windows.Forms.Label()
			Me.lbRSExtraCost = New Global.System.Windows.Forms.Label()
			Me.lblRodGuides = New Global.System.Windows.Forms.Label()
			Me.cboRSRodGuides = New Global.System.Windows.Forms.ComboBox()
			Me.ctrFGDesign = New Global.System.Windows.Forms.Panel()
			Me.cboRSFGGrade = New Global.System.Windows.Forms.ComboBox()
			Me.lblRSFGGrade = New Global.System.Windows.Forms.Label()
			Me.ctrSteelDesign = New Global.System.Windows.Forms.Panel()
			Me.fraSteelDesign = New Global.System.Windows.Forms.GroupBox()
			Me.chkRSFGIncludeSteel = New Global.System.Windows.Forms.CheckBox()
			Me.lblRSMaxSize = New Global.System.Windows.Forms.Label()
			Me.lblRSMinSize = New Global.System.Windows.Forms.Label()
			Me.lblRSGrade = New Global.System.Windows.Forms.Label()
			Me.cboRSGrade = New Global.System.Windows.Forms.ComboBox()
			Me.cboRSMinSize = New Global.System.Windows.Forms.ComboBox()
			Me.lblRSGrade_Disabled = New Global.System.Windows.Forms.Label()
			Me.lblRSMinSize_Disabled = New Global.System.Windows.Forms.Label()
			Me.cboRSMaxSize = New Global.System.Windows.Forms.ComboBox()
			Me.lblRSMaxSize_Disabled = New Global.System.Windows.Forms.Label()
			Me.ContextMenu1 = New Global.System.Windows.Forms.ContextMenu()
			Me.txtTempLength = New Global.System.Windows.Forms.TextBox()
			Me.txtTempDiam = New Global.System.Windows.Forms.TextBox()
			Me.lblTemp = New Global.System.Windows.Forms.Label()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.Line = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.lblStatus = New Global.System.Windows.Forms.Label()
			Me.picRemoveFocus.SuspendLayout()
			Me.tbsRodDesignType.SuspendLayout()
			Me.ctrRodString.SuspendLayout()
			CType(Me.ulgTapers, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ctrSinkerBars.SuspendLayout()
			Me.fraSinkerBars.SuspendLayout()
			Me.ctrOtherInfo.SuspendLayout()
			Me.fraOtherInfo.SuspendLayout()
			Me.ctrFGDesign.SuspendLayout()
			Me.ctrSteelDesign.SuspendLayout()
			Me.fraSteelDesign.SuspendLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Line, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.AutomaticDelay = 50
			Me.ToolTip1.ShowAlways = True
			Me.HelpProvider1.SetHelpKeyword(Me.XSR, "rod string entry option")
			Me.HelpProvider1.SetHelpNavigator(Me.XSR, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.XSR.ImageIndex = 0
			Dim xsr As Global.System.Windows.Forms.TabPage = Me.XSR
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(4, 82)
			xsr.Location = location
			Me.XSR.Name = "XSR"
			Me.HelpProvider1.SetShowHelp(Me.XSR, True)
			Dim xsr2 As Global.System.Windows.Forms.Control = Me.XSR
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(22, 0)
			xsr2.Size = size
			Me.XSR.TabIndex = 0
			Me.XSR.Tag = "RODSTAR steel design"
			Me.ToolTip1.SetToolTip(Me.XSR, "RODSTAR steel design")
			Me.XSR.ToolTipText = "RODSTAR steel design"
			Me.HelpProvider1.SetHelpKeyword(Me.XFD, "rod string entry option")
			Me.HelpProvider1.SetHelpNavigator(Me.XFD, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.XFD.ImageIndex = 1
			Dim xfd As Global.System.Windows.Forms.TabPage = Me.XFD
			location = New Global.System.Drawing.Point(4, 82)
			xfd.Location = location
			Me.XFD.Name = "XFD"
			Me.HelpProvider1.SetShowHelp(Me.XFD, True)
			Dim xfd2 As Global.System.Windows.Forms.Control = Me.XFD
			size = New Global.System.Drawing.Size(22, 0)
			xfd2.Size = size
			Me.XFD.TabIndex = 1
			Me.XFD.Tag = "RODSTAR fiberglass/steel design"
			Me.ToolTip1.SetToolTip(Me.XFD, "RODSTAR fiberglass/steel design")
			Me.XFD.ToolTipText = "RODSTAR fiberglass/steel design"
			Me.HelpProvider1.SetHelpKeyword(Me.USR, "rod string entry option")
			Me.HelpProvider1.SetHelpNavigator(Me.USR, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.USR.ImageIndex = 3
			Dim usr As Global.System.Windows.Forms.TabPage = Me.USR
			location = New Global.System.Drawing.Point(4, 82)
			usr.Location = location
			Me.USR.Name = "USR"
			Me.HelpProvider1.SetShowHelp(Me.USR, True)
			Dim usr2 As Global.System.Windows.Forms.Control = Me.USR
			size = New Global.System.Drawing.Size(22, 0)
			usr2.Size = size
			Me.USR.TabIndex = 3
			Me.USR.Tag = "Manual rod string entry"
			Me.ToolTip1.SetToolTip(Me.USR, "Manual rod string entry")
			Me.USR.ToolTipText = "Manual rod string entry"
			Me.btnNumberOfRods.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnNumberOfRods.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnNumberOfRods.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnNumberOfRods.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnNumberOfRods.Image = CType(componentResourceManager.GetObject("btnNumberOfRods.Image"), Global.System.Drawing.Image)
			Me.btnNumberOfRods.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnNumberOfRods As Global.System.Windows.Forms.Control = Me.btnNumberOfRods
			location = New Global.System.Drawing.Point(8, 112)
			btnNumberOfRods.Location = location
			Me.btnNumberOfRods.Name = "btnNumberOfRods"
			Me.btnNumberOfRods.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.btnNumberOfRods, False)
			Dim btnNumberOfRods2 As Global.System.Windows.Forms.Control = Me.btnNumberOfRods
			size = New Global.System.Drawing.Size(24, 24)
			btnNumberOfRods2.Size = size
			Me.btnNumberOfRods.TabIndex = 2
			Me.btnNumberOfRods.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.btnNumberOfRods, "Specify number of rods")
			Me.btnNumberOfRods.UseVisualStyleBackColor = False
			Me.cmdAddSection.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdAddSection.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdAddSection.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdAddSection.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdAddSection.Image = CType(componentResourceManager.GetObject("cmdAddSection.Image"), Global.System.Drawing.Image)
			Me.cmdAddSection.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdAddSection As Global.System.Windows.Forms.Control = Me.cmdAddSection
			location = New Global.System.Drawing.Point(8, 184)
			cmdAddSection.Location = location
			Me.cmdAddSection.Name = "cmdAddSection"
			Me.cmdAddSection.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdAddSection, False)
			Dim cmdAddSection2 As Global.System.Windows.Forms.Control = Me.cmdAddSection
			size = New Global.System.Drawing.Size(24, 24)
			cmdAddSection2.Size = size
			Me.cmdAddSection.TabIndex = 5
			Me.cmdAddSection.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdAddSection, "Add a rod section")
			Me.cmdAddSection.UseVisualStyleBackColor = False
			Me.cmdDelSection.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdDelSection.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdDelSection.Enabled = False
			Me.cmdDelSection.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdDelSection.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdDelSection.Image = CType(componentResourceManager.GetObject("cmdDelSection.Image"), Global.System.Drawing.Image)
			Me.cmdDelSection.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdDelSection As Global.System.Windows.Forms.Control = Me.cmdDelSection
			location = New Global.System.Drawing.Point(8, 208)
			cmdDelSection.Location = location
			Me.cmdDelSection.Name = "cmdDelSection"
			Me.cmdDelSection.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdDelSection, False)
			Dim cmdDelSection2 As Global.System.Windows.Forms.Control = Me.cmdDelSection
			size = New Global.System.Drawing.Size(24, 24)
			cmdDelSection2.Size = size
			Me.cmdDelSection.TabIndex = 6
			Me.cmdDelSection.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdDelSection, "Remove a rod section")
			Me.cmdDelSection.UseVisualStyleBackColor = False
			Me.cmdMoveSectionUp.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdMoveSectionUp.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdMoveSectionUp.Enabled = False
			Me.cmdMoveSectionUp.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdMoveSectionUp.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdMoveSectionUp.Image = CType(componentResourceManager.GetObject("cmdMoveSectionUp.Image"), Global.System.Drawing.Image)
			Me.cmdMoveSectionUp.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdMoveSectionUp As Global.System.Windows.Forms.Control = Me.cmdMoveSectionUp
			location = New Global.System.Drawing.Point(8, 136)
			cmdMoveSectionUp.Location = location
			Me.cmdMoveSectionUp.Name = "cmdMoveSectionUp"
			Me.cmdMoveSectionUp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdMoveSectionUp, False)
			Dim cmdMoveSectionUp2 As Global.System.Windows.Forms.Control = Me.cmdMoveSectionUp
			size = New Global.System.Drawing.Size(24, 24)
			cmdMoveSectionUp2.Size = size
			Me.cmdMoveSectionUp.TabIndex = 3
			Me.cmdMoveSectionUp.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdMoveSectionUp, "Move a rod section upward")
			Me.cmdMoveSectionUp.UseVisualStyleBackColor = False
			Me.cmdMoveSectionDown.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdMoveSectionDown.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdMoveSectionDown.Enabled = False
			Me.cmdMoveSectionDown.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdMoveSectionDown.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdMoveSectionDown.Image = CType(componentResourceManager.GetObject("cmdMoveSectionDown.Image"), Global.System.Drawing.Image)
			Me.cmdMoveSectionDown.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdMoveSectionDown As Global.System.Windows.Forms.Control = Me.cmdMoveSectionDown
			location = New Global.System.Drawing.Point(8, 160)
			cmdMoveSectionDown.Location = location
			Me.cmdMoveSectionDown.Name = "cmdMoveSectionDown"
			Me.cmdMoveSectionDown.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdMoveSectionDown, False)
			Dim cmdMoveSectionDown2 As Global.System.Windows.Forms.Control = Me.cmdMoveSectionDown
			size = New Global.System.Drawing.Size(24, 24)
			cmdMoveSectionDown2.Size = size
			Me.cmdMoveSectionDown.TabIndex = 4
			Me.cmdMoveSectionDown.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdMoveSectionDown, "Move a rod section downward")
			Me.cmdMoveSectionDown.UseVisualStyleBackColor = False
			Me.picRemoveFocus.BackColor = Global.System.Drawing.SystemColors.Control
			Me.picRemoveFocus.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.picRemoveFocus.Controls.Add(Me._Line_0)
			Me.picRemoveFocus.Controls.Add(Me.tbsRodDesignType)
			Me.picRemoveFocus.Controls.Add(Me.cboLookupDiameter)
			Me.picRemoveFocus.Controls.Add(Me.cboLookupDisplayName)
			Me.picRemoveFocus.Controls.Add(Me.lstNumOfRods)
			Me.picRemoveFocus.Controls.Add(Me._Line_1)
			Me.picRemoveFocus.Controls.Add(Me.ctrRodString)
			Me.picRemoveFocus.Controls.Add(Me._Label_Length)
			Me.picRemoveFocus.Controls.Add(Me.ctrSinkerBars)
			Me.picRemoveFocus.Controls.Add(Me.ctrOtherInfo)
			Me.picRemoveFocus.Controls.Add(Me.ctrFGDesign)
			Me.picRemoveFocus.Controls.Add(Me.cmdAddSection)
			Me.picRemoveFocus.Controls.Add(Me.cmdDelSection)
			Me.picRemoveFocus.Controls.Add(Me.btnNumberOfRods)
			Me.picRemoveFocus.Controls.Add(Me.cmdMoveSectionUp)
			Me.picRemoveFocus.Controls.Add(Me.cmdMoveSectionDown)
			Me.picRemoveFocus.Controls.Add(Me.ctrSteelDesign)
			Me.picRemoveFocus.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.picRemoveFocus.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.picRemoveFocus.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim picRemoveFocus As Global.System.Windows.Forms.Control = Me.picRemoveFocus
			location = New Global.System.Drawing.Point(8, 8)
			picRemoveFocus.Location = location
			Me.picRemoveFocus.Name = "picRemoveFocus"
			Me.picRemoveFocus.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.picRemoveFocus, False)
			Dim picRemoveFocus2 As Global.System.Windows.Forms.Control = Me.picRemoveFocus
			size = New Global.System.Drawing.Size(780, 688)
			picRemoveFocus2.Size = size
			Me.picRemoveFocus.TabIndex = 0
			Me._Line_0.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._Line_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Line.SetIndex(Me._Line_0, 0S)
			Dim line_ As Global.System.Windows.Forms.Control = Me._Line_0
			location = New Global.System.Drawing.Point(8, 104)
			line_.Location = location
			Me._Line_0.Name = "_Line_0"
			Me.HelpProvider1.SetShowHelp(Me._Line_0, False)
			Dim line_2 As Global.System.Windows.Forms.Control = Me._Line_0
			size = New Global.System.Drawing.Size(29, 1)
			line_2.Size = size
			Me._Line_0.TabIndex = 44
			Me._Line_0.Visible = False
			Me.tbsRodDesignType.Appearance = Global.System.Windows.Forms.TabAppearance.Buttons
			Me.tbsRodDesignType.CausesValidation = False
			Me.tbsRodDesignType.Controls.Add(Me.XSR)
			Me.tbsRodDesignType.Controls.Add(Me.XFD)
			Me.tbsRodDesignType.Controls.Add(Me.USR)
			Me.HelpProvider1.SetHelpKeyword(Me.tbsRodDesignType, "rod string entry option")
			Me.HelpProvider1.SetHelpNavigator(Me.tbsRodDesignType, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.tbsRodDesignType.HotTrack = True
			Me.tbsRodDesignType.ImageList = Me.imlRodDesignType
			Dim tbsRodDesignType As Global.System.Windows.Forms.TabControl = Me.tbsRodDesignType
			size = New Global.System.Drawing.Size(48, 24)
			tbsRodDesignType.ItemSize = size
			Dim tbsRodDesignType2 As Global.System.Windows.Forms.Control = Me.tbsRodDesignType
			location = New Global.System.Drawing.Point(8, 16)
			tbsRodDesignType2.Location = location
			Me.tbsRodDesignType.Multiline = True
			Me.tbsRodDesignType.Name = "tbsRodDesignType"
			Me.tbsRodDesignType.SelectedIndex = 0
			Me.HelpProvider1.SetShowHelp(Me.tbsRodDesignType, True)
			Me.tbsRodDesignType.ShowToolTips = True
			Dim tbsRodDesignType3 As Global.System.Windows.Forms.Control = Me.tbsRodDesignType
			size = New Global.System.Drawing.Size(30, 80)
			tbsRodDesignType3.Size = size
			Me.tbsRodDesignType.TabIndex = 1
			Me.imlRodDesignType.ImageStream = CType(componentResourceManager.GetObject("imlRodDesignType.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.imlRodDesignType.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.imlRodDesignType.Images.SetKeyName(0, "")
			Me.imlRodDesignType.Images.SetKeyName(1, "")
			Me.imlRodDesignType.Images.SetKeyName(2, "")
			Me.imlRodDesignType.Images.SetKeyName(3, "")
			Me.cboLookupDiameter.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboLookupDiameter.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboLookupDiameter.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboLookupDiameter.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboLookupDiameter.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.cboLookupDiameter.ItemHeight = 14
			Dim cboLookupDiameter As Global.System.Windows.Forms.Control = Me.cboLookupDiameter
			location = New Global.System.Drawing.Point(1024, 32)
			cboLookupDiameter.Location = location
			Me.cboLookupDiameter.Name = "cboLookupDiameter"
			Me.cboLookupDiameter.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboLookupDiameter, False)
			Dim cboLookupDiameter2 As Global.System.Windows.Forms.Control = Me.cboLookupDiameter
			size = New Global.System.Drawing.Size(66, 22)
			cboLookupDiameter2.Size = size
			Me.cboLookupDiameter.TabIndex = 193
			Me.cboLookupDiameter.Visible = False
			Me.cboLookupDisplayName.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboLookupDisplayName.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboLookupDisplayName.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboLookupDisplayName.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboLookupDisplayName.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.cboLookupDisplayName.ItemHeight = 14
			Dim cboLookupDisplayName As Global.System.Windows.Forms.Control = Me.cboLookupDisplayName
			location = New Global.System.Drawing.Point(1024, 8)
			cboLookupDisplayName.Location = location
			Me.cboLookupDisplayName.Name = "cboLookupDisplayName"
			Me.cboLookupDisplayName.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboLookupDisplayName, False)
			Dim cboLookupDisplayName2 As Global.System.Windows.Forms.Control = Me.cboLookupDisplayName
			size = New Global.System.Drawing.Size(66, 22)
			cboLookupDisplayName2.Size = size
			Me.cboLookupDisplayName.TabIndex = 192
			Me.cboLookupDisplayName.Visible = False
			Me.lstNumOfRods.AllowDrop = True
			Me.lstNumOfRods.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lstNumOfRods.ItemHeight = 16
			Me.lstNumOfRods.Items.AddRange(New Object() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" })
			Dim lstNumOfRods As Global.System.Windows.Forms.Control = Me.lstNumOfRods
			location = New Global.System.Drawing.Point(1136, 128)
			lstNumOfRods.Location = location
			Me.lstNumOfRods.Name = "lstNumOfRods"
			Me.HelpProvider1.SetShowHelp(Me.lstNumOfRods, False)
			Dim lstNumOfRods2 As Global.System.Windows.Forms.Control = Me.lstNumOfRods
			size = New Global.System.Drawing.Size(18, 164)
			lstNumOfRods2.Size = size
			Me.lstNumOfRods.TabIndex = 190
			Me.lstNumOfRods.Visible = False
			Me._Line_1.BackColor = Global.System.Drawing.SystemColors.ControlLight
			Me._Line_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim line_3 As Global.System.Windows.Forms.Control = Me._Line_1
			location = New Global.System.Drawing.Point(16, 120)
			line_3.Location = location
			Me._Line_1.Name = "_Line_1"
			Me.HelpProvider1.SetShowHelp(Me._Line_1, False)
			Dim line_4 As Global.System.Windows.Forms.Control = Me._Line_1
			size = New Global.System.Drawing.Size(23, 1)
			line_4.Size = size
			Me._Line_1.TabIndex = 188
			Me._Line_1.Visible = False
			Me.ctrRodString.BackColor = Global.System.Drawing.SystemColors.Control
			Me.ctrRodString.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.ctrRodString.Controls.Add(Me.lblStringLength)
			Me.ctrRodString.Controls.Add(Me.cboRodGuides)
			Me.ctrRodString.Controls.Add(Me.txtLength)
			Me.ctrRodString.Controls.Add(Me.lblFricFootnote)
			Me.ctrRodString.Controls.Add(Me.cboRodType)
			Me.ctrRodString.Controls.Add(Me.cboRodGrade)
			Me.ctrRodString.Controls.Add(Me.cboRodSize)
			Me.ctrRodString.Controls.Add(Me.ulgTapers)
			Me.ctrRodString.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.ctrRodString.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.ctrRodString.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim ctrRodString As Global.System.Windows.Forms.Control = Me.ctrRodString
			location = New Global.System.Drawing.Point(48, 361)
			ctrRodString.Location = location
			Me.ctrRodString.Name = "ctrRodString"
			Me.ctrRodString.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.ctrRodString, False)
			Dim ctrRodString2 As Global.System.Windows.Forms.Control = Me.ctrRodString
			size = New Global.System.Drawing.Size(720, 319)
			ctrRodString2.Size = size
			Me.ctrRodString.TabIndex = 18
			Me.ctrRodString.TabStop = True
			Me.lblStringLength.AutoSize = True
			Me.lblStringLength.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblStringLength.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblStringLength As Global.System.Windows.Forms.Control = Me.lblStringLength
			location = New Global.System.Drawing.Point(6, 298)
			lblStringLength.Location = location
			Me.lblStringLength.Name = "lblStringLength"
			Dim lblStringLength2 As Global.System.Windows.Forms.Control = Me.lblStringLength
			size = New Global.System.Drawing.Size(2, 18)
			lblStringLength2.Size = size
			Me.lblStringLength.TabIndex = 194
			Me.cboRodGuides.AllowDrop = True
			Me.cboRodGuides.BackColor = Global.System.Drawing.Color.Cyan
			Me.cboRodGuides.DropDownWidth = 200
			Me.cboRodGuides.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.cboRodGuides, "rod section grade")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRodGuides, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRodGuides.ItemHeight = 16
			Dim cboRodGuides As Global.System.Windows.Forms.Control = Me.cboRodGuides
			location = New Global.System.Drawing.Point(704, 88)
			cboRodGuides.Location = location
			Me.cboRodGuides.MaxDropDownItems = 12
			Me.cboRodGuides.MaxLength = 100
			Me.cboRodGuides.Name = "cboRodGuides"
			Me.HelpProvider1.SetShowHelp(Me.cboRodGuides, True)
			Dim cboRodGuides2 As Global.System.Windows.Forms.Control = Me.cboRodGuides
			size = New Global.System.Drawing.Size(104, 24)
			cboRodGuides2.Size = size
			Me.cboRodGuides.TabIndex = 193
			Me.cboRodGuides.Visible = False
			Me.txtLength.AcceptsReturn = True
			Me.txtLength.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtLength.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtLength.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtLength.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtLength, "Rod section length")
			Me.HelpProvider1.SetHelpNavigator(Me.txtLength, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtLength As Global.System.Windows.Forms.Control = Me.txtLength
			location = New Global.System.Drawing.Point(347, 152)
			txtLength.Location = location
			Me.txtLength.MaxLength = 10
			Me.txtLength.Name = "txtLength"
			Me.txtLength.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtLength, True)
			Dim txtLength2 As Global.System.Windows.Forms.Control = Me.txtLength
			size = New Global.System.Drawing.Size(125, 22)
			txtLength2.Size = size
			Me.txtLength.TabIndex = 192
			Me.txtLength.Tag = "fem"
			Me.txtLength.Visible = False
			Dim lblFricFootnote As Global.System.Windows.Forms.Control = Me.lblFricFootnote
			location = New Global.System.Drawing.Point(383, 304)
			lblFricFootnote.Location = location
			Me.lblFricFootnote.Name = "lblFricFootnote"
			Dim lblFricFootnote2 As Global.System.Windows.Forms.Control = Me.lblFricFootnote
			size = New Global.System.Drawing.Size(400, 16)
			lblFricFootnote2.Size = size
			Me.lblFricFootnote.TabIndex = 190
			Me.lblFricFootnote.Text = " *  Drag Friction Coefficients only effect  cases with Deviation Survey"
			Me.cboRodType.AllowDrop = True
			Me.cboRodType.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.cboRodType, "rod section type")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRodType, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRodType.ItemHeight = 16
			Dim cboRodType As Global.System.Windows.Forms.Control = Me.cboRodType
			location = New Global.System.Drawing.Point(584, 24)
			cboRodType.Location = location
			Me.cboRodType.MaxDropDownItems = 100
			Me.cboRodType.MaxLength = 100
			Me.cboRodType.Name = "cboRodType"
			Me.HelpProvider1.SetShowHelp(Me.cboRodType, True)
			Dim cboRodType2 As Global.System.Windows.Forms.Control = Me.cboRodType
			size = New Global.System.Drawing.Size(104, 24)
			cboRodType2.Size = size
			Me.cboRodType.TabIndex = 187
			Me.cboRodType.Visible = False
			Me.cboRodGrade.AllowDrop = True
			Me.cboRodGrade.BackColor = Global.System.Drawing.Color.Cyan
			Me.cboRodGrade.DropDownWidth = 200
			Me.cboRodGrade.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.cboRodGrade, "Rod section grade")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRodGrade, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRodGrade.ItemHeight = 16
			Dim cboRodGrade As Global.System.Windows.Forms.Control = Me.cboRodGrade
			location = New Global.System.Drawing.Point(584, 88)
			cboRodGrade.Location = location
			Me.cboRodGrade.MaxDropDownItems = 30
			Me.cboRodGrade.MaxLength = 100
			Me.cboRodGrade.Name = "cboRodGrade"
			Me.HelpProvider1.SetShowHelp(Me.cboRodGrade, True)
			Dim cboRodGrade2 As Global.System.Windows.Forms.Control = Me.cboRodGrade
			size = New Global.System.Drawing.Size(104, 24)
			cboRodGrade2.Size = size
			Me.cboRodGrade.TabIndex = 186
			Me.cboRodGrade.Visible = False
			Me.cboRodSize.AllowDrop = True
			Me.cboRodSize.BackColor = Global.System.Drawing.Color.Cyan
			Me.cboRodSize.DropDownWidth = 200
			Me.cboRodSize.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.cboRodSize, "Rod section diameter")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRodSize, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRodSize.ItemHeight = 16
			Dim cboRodSize As Global.System.Windows.Forms.Control = Me.cboRodSize
			location = New Global.System.Drawing.Point(584, 56)
			cboRodSize.Location = location
			Me.cboRodSize.MaxDropDownItems = 20
			Me.cboRodSize.MaxLength = 100
			Me.cboRodSize.Name = "cboRodSize"
			Me.HelpProvider1.SetShowHelp(Me.cboRodSize, True)
			Dim cboRodSize2 As Global.System.Windows.Forms.Control = Me.cboRodSize
			size = New Global.System.Drawing.Size(104, 24)
			cboRodSize2.Size = size
			Me.cboRodSize.TabIndex = 48
			Me.cboRodSize.Visible = False
			Me.ulgTapers.AllowDrop = True
			Me.ulgTapers.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.ulgTapers, "Rod String Information Window Manual")
			Me.HelpProvider1.SetHelpNavigator(Me.ulgTapers, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim ulgTapers As Global.System.Windows.Forms.Control = Me.ulgTapers
			location = New Global.System.Drawing.Point(6, 3)
			ulgTapers.Location = location
			Me.ulgTapers.Name = "ulgTapers"
			Me.HelpProvider1.SetShowHelp(Me.ulgTapers, True)
			Dim ulgTapers2 As Global.System.Windows.Forms.Control = Me.ulgTapers
			size = New Global.System.Drawing.Size(705, 293)
			ulgTapers2.Size = size
			Me.ulgTapers.TabIndex = 7
			Me._Label_Length.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_Length.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_Length.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_Length.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_Length.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_Length As Global.System.Windows.Forms.Control = Me._Label_Length
			location = New Global.System.Drawing.Point(1008, 88)
			label_Length.Location = location
			Me._Label_Length.Name = "_Label_Length"
			Me._Label_Length.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_Length, False)
			Dim label_Length2 As Global.System.Windows.Forms.Control = Me._Label_Length
			size = New Global.System.Drawing.Size(88, 16)
			label_Length2.Size = size
			Me._Label_Length.TabIndex = 181
			Me._Label_Length.Tag = "Length  (^):"
			Me._Label_Length.Text = "Length  (ft):"
			Me._Label_Length.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_Length.Visible = False
			Me.ctrSinkerBars.BackColor = Global.System.Drawing.SystemColors.Control
			Me.ctrSinkerBars.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.ctrSinkerBars.Controls.Add(Me.fraSinkerBars)
			Me.ctrSinkerBars.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.ctrSinkerBars.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.ctrSinkerBars.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim ctrSinkerBars As Global.System.Windows.Forms.Control = Me.ctrSinkerBars
			location = New Global.System.Drawing.Point(48, 126)
			ctrSinkerBars.Location = location
			Me.ctrSinkerBars.Name = "ctrSinkerBars"
			Me.ctrSinkerBars.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.ctrSinkerBars, False)
			Dim ctrSinkerBars2 As Global.System.Windows.Forms.Control = Me.ctrSinkerBars
			size = New Global.System.Drawing.Size(702, 138)
			ctrSinkerBars2.Size = size
			Me.ctrSinkerBars.TabIndex = 6
			Me.ctrSinkerBars.TabStop = True
			Me.fraSinkerBars.BackColor = Global.System.Drawing.SystemColors.Control
			Me.fraSinkerBars.Controls.Add(Me.lblRSSRSize)
			Me.fraSinkerBars.Controls.Add(Me.optSinkerRods)
			Me.fraSinkerBars.Controls.Add(Me.optSinkerBars)
			Me.fraSinkerBars.Controls.Add(Me.chkRSIncludeSB)
			Me.fraSinkerBars.Controls.Add(Me.lblRSSBDiameter)
			Me.fraSinkerBars.Controls.Add(Me.lblRSSBGrade)
			Me.fraSinkerBars.Controls.Add(Me.lblRSSBLength)
			Me.fraSinkerBars.Controls.Add(Me.cboRSSBGrade)
			Me.fraSinkerBars.Controls.Add(Me.cboRSSBDiameter)
			Me.fraSinkerBars.Controls.Add(Me.lblRSSBGrade_Disabled)
			Me.fraSinkerBars.Controls.Add(Me.lbl_RSSBDiameter_Disabled)
			Me.fraSinkerBars.Controls.Add(Me.chkDesignSinkerbars)
			Me.fraSinkerBars.Controls.Add(Me.txtRSSBDiameter)
			Me.fraSinkerBars.Controls.Add(Me.lblRSSBDiameter_Disabled)
			Me.fraSinkerBars.Controls.Add(Me.cboRSSRSize)
			Me.fraSinkerBars.Controls.Add(Me.lblRSSRSize_Disabled)
			Me.fraSinkerBars.Controls.Add(Me.txtRSSBLength)
			Me.fraSinkerBars.Controls.Add(Me.lblRSSBLength_Disabled)
			Me.fraSinkerBars.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.fraSinkerBars.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim fraSinkerBars As Global.System.Windows.Forms.Control = Me.fraSinkerBars
			location = New Global.System.Drawing.Point(0, 4)
			fraSinkerBars.Location = location
			Me.fraSinkerBars.Name = "fraSinkerBars"
			Me.fraSinkerBars.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.fraSinkerBars, False)
			Dim fraSinkerBars2 As Global.System.Windows.Forms.Control = Me.fraSinkerBars
			size = New Global.System.Drawing.Size(688, 129)
			fraSinkerBars2.Size = size
			Me.fraSinkerBars.TabIndex = 7
			Me.fraSinkerBars.TabStop = False
			Me.lblRSSRSize.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRSSRSize.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRSSRSize.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblRSSRSize.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRSSRSize.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblRSSRSize As Global.System.Windows.Forms.Control = Me.lblRSSRSize
			location = New Global.System.Drawing.Point(8, 107)
			lblRSSRSize.Location = location
			Me.lblRSSRSize.Name = "lblRSSRSize"
			Me.lblRSSRSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRSSRSize, False)
			Dim lblRSSRSize2 As Global.System.Windows.Forms.Control = Me.lblRSSRSize
			size = New Global.System.Drawing.Size(296, 19)
			lblRSSRSize2.Size = size
			Me.lblRSSRSize.TabIndex = 192
			Me.lblRSSRSize.Text = "Sucker rod diameter below sinker bars:"
			Me.lblRSSRSize.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.optSinkerRods.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optSinkerRods.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optSinkerRods.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.optSinkerRods.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optSinkerRods, "Sinker Rods")
			Me.HelpProvider1.SetHelpNavigator(Me.optSinkerRods, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optSinkerRods.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optSinkerRods As Global.System.Windows.Forms.Control = Me.optSinkerRods
			location = New Global.System.Drawing.Point(464, 12)
			optSinkerRods.Location = location
			Me.optSinkerRods.Name = "optSinkerRods"
			Me.optSinkerRods.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optSinkerRods, True)
			Dim optSinkerRods2 As Global.System.Windows.Forms.Control = Me.optSinkerRods
			size = New Global.System.Drawing.Size(208, 19)
			optSinkerRods2.Size = size
			Me.optSinkerRods.TabIndex = 14
			Me.optSinkerRods.Text = "Sinker rods"
			Me.optSinkerRods.UseVisualStyleBackColor = False
			Me.optSinkerBars.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optSinkerBars.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optSinkerBars.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.optSinkerBars.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optSinkerBars, "Sinker Bars")
			Me.HelpProvider1.SetHelpNavigator(Me.optSinkerBars, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optSinkerBars.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optSinkerBars As Global.System.Windows.Forms.Control = Me.optSinkerBars
			location = New Global.System.Drawing.Point(312, 12)
			optSinkerBars.Location = location
			Me.optSinkerBars.Name = "optSinkerBars"
			Me.optSinkerBars.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optSinkerBars, True)
			Dim optSinkerBars2 As Global.System.Windows.Forms.Control = Me.optSinkerBars
			size = New Global.System.Drawing.Size(144, 19)
			optSinkerBars2.Size = size
			Me.optSinkerBars.TabIndex = 13
			Me.optSinkerBars.Text = "Sinker bars"
			Me.optSinkerBars.UseVisualStyleBackColor = False
			Me.chkRSIncludeSB.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkRSIncludeSB.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkRSIncludeSB.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.chkRSIncludeSB.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.chkRSIncludeSB, "Include sinker bars/sinker rods")
			Me.HelpProvider1.SetHelpNavigator(Me.chkRSIncludeSB, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkRSIncludeSB.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkRSIncludeSB As Global.System.Windows.Forms.Control = Me.chkRSIncludeSB
			location = New Global.System.Drawing.Point(9, 0)
			chkRSIncludeSB.Location = location
			Me.chkRSIncludeSB.Name = "chkRSIncludeSB"
			Me.chkRSIncludeSB.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkRSIncludeSB, True)
			Dim chkRSIncludeSB2 As Global.System.Windows.Forms.Control = Me.chkRSIncludeSB
			size = New Global.System.Drawing.Size(223, 19)
			chkRSIncludeSB2.Size = size
			Me.chkRSIncludeSB.TabIndex = 12
			Me.chkRSIncludeSB.TabStop = False
			Me.chkRSIncludeSB.Text = "Include sinker bars/sinker rods"
			Me.chkRSIncludeSB.UseVisualStyleBackColor = False
			Me.lblRSSBDiameter.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRSSBDiameter.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRSSBDiameter.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblRSSBDiameter.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRSSBDiameter.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me.lblRSSBDiameter, 9S)
			Dim lblRSSBDiameter As Global.System.Windows.Forms.Control = Me.lblRSSBDiameter
			location = New Global.System.Drawing.Point(8, 59)
			lblRSSBDiameter.Location = location
			Me.lblRSSBDiameter.Name = "lblRSSBDiameter"
			Me.lblRSSBDiameter.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRSSBDiameter, False)
			Dim lblRSSBDiameter2 As Global.System.Windows.Forms.Control = Me.lblRSSBDiameter
			size = New Global.System.Drawing.Size(296, 19)
			lblRSSBDiameter2.Size = size
			Me.lblRSSBDiameter.TabIndex = 16
			Me.lblRSSBDiameter.Text = "Sinker bar diameter:"
			Me.lblRSSBDiameter.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblRSSBGrade.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRSSBGrade.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRSSBGrade.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblRSSBGrade.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRSSBGrade.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me.lblRSSBGrade, 7S)
			Dim lblRSSBGrade As Global.System.Windows.Forms.Control = Me.lblRSSBGrade
			location = New Global.System.Drawing.Point(8, 35)
			lblRSSBGrade.Location = location
			Me.lblRSSBGrade.Name = "lblRSSBGrade"
			Me.lblRSSBGrade.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRSSBGrade, False)
			Dim lblRSSBGrade2 As Global.System.Windows.Forms.Control = Me.lblRSSBGrade
			size = New Global.System.Drawing.Size(296, 19)
			lblRSSBGrade2.Size = size
			Me.lblRSSBGrade.TabIndex = 15
			Me.lblRSSBGrade.Text = "Sinker bar grade/manufacturer:"
			Me.lblRSSBGrade.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblRSSBLength.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRSSBLength.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRSSBLength.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblRSSBLength.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRSSBLength.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me.lblRSSBLength, 11S)
			Dim lblRSSBLength As Global.System.Windows.Forms.Control = Me.lblRSSBLength
			location = New Global.System.Drawing.Point(8, 81)
			lblRSSBLength.Location = location
			Me.lblRSSBLength.Name = "lblRSSBLength"
			Me.lblRSSBLength.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRSSBLength, False)
			Dim lblRSSBLength2 As Global.System.Windows.Forms.Control = Me.lblRSSBLength
			size = New Global.System.Drawing.Size(296, 18)
			lblRSSBLength2.Size = size
			Me.lblRSSBLength.TabIndex = 17
			Me.lblRSSBLength.Tag = "Sinker bar length (^):"
			Me.lblRSSBLength.Text = "Sinker bar length (ft):"
			Me.lblRSSBLength.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.cboRSSBGrade.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboRSSBGrade.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboRSSBGrade.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboRSSBGrade.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboRSSBGrade.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboRSSBGrade, "Rod string information window: Sinker bar grade or manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRSSBGrade, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRSSBGrade.ItemHeight = 14
			Dim cboRSSBGrade As Global.System.Windows.Forms.Control = Me.cboRSSBGrade
			location = New Global.System.Drawing.Point(304, 31)
			cboRSSBGrade.Location = location
			Me.cboRSSBGrade.Name = "cboRSSBGrade"
			Me.cboRSSBGrade.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboRSSBGrade, True)
			Dim cboRSSBGrade2 As Global.System.Windows.Forms.Control = Me.cboRSSBGrade
			size = New Global.System.Drawing.Size(248, 22)
			cboRSSBGrade2.Size = size
			Me.cboRSSBGrade.TabIndex = 15
			Me.cboRSSBGrade.TabStop = False
			Me.cboRSSBDiameter.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboRSSBDiameter.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboRSSBDiameter.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboRSSBDiameter.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboRSSBDiameter.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboRSSBDiameter, "Rod string information window: Sinker bar diameter")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRSSBDiameter, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRSSBDiameter.ItemHeight = 14
			Dim cboRSSBDiameter As Global.System.Windows.Forms.Control = Me.cboRSSBDiameter
			location = New Global.System.Drawing.Point(304, 55)
			cboRSSBDiameter.Location = location
			Me.cboRSSBDiameter.MaxDropDownItems = 20
			Me.cboRSSBDiameter.Name = "cboRSSBDiameter"
			Me.cboRSSBDiameter.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboRSSBDiameter, True)
			Dim cboRSSBDiameter2 As Global.System.Windows.Forms.Control = Me.cboRSSBDiameter
			size = New Global.System.Drawing.Size(176, 22)
			cboRSSBDiameter2.Size = size
			Me.cboRSSBDiameter.TabIndex = 16
			Me.cboRSSBDiameter.TabStop = False
			Me.lblRSSBGrade_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblRSSBGrade_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblRSSBGrade_Disabled As Global.System.Windows.Forms.Control = Me.lblRSSBGrade_Disabled
			location = New Global.System.Drawing.Point(304, 31)
			lblRSSBGrade_Disabled.Location = location
			Me.lblRSSBGrade_Disabled.Name = "lblRSSBGrade_Disabled"
			Dim lblRSSBGrade_Disabled2 As Global.System.Windows.Forms.Control = Me.lblRSSBGrade_Disabled
			size = New Global.System.Drawing.Size(248, 22)
			lblRSSBGrade_Disabled2.Size = size
			Me.lblRSSBGrade_Disabled.TabIndex = 21
			Me.lbl_RSSBDiameter_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lbl_RSSBDiameter_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lbl_RSSBDiameter_Disabled As Global.System.Windows.Forms.Control = Me.lbl_RSSBDiameter_Disabled
			location = New Global.System.Drawing.Point(304, 55)
			lbl_RSSBDiameter_Disabled.Location = location
			Me.lbl_RSSBDiameter_Disabled.Name = "lbl_RSSBDiameter_Disabled"
			Dim lbl_RSSBDiameter_Disabled2 As Global.System.Windows.Forms.Control = Me.lbl_RSSBDiameter_Disabled
			size = New Global.System.Drawing.Size(176, 22)
			lbl_RSSBDiameter_Disabled2.Size = size
			Me.lbl_RSSBDiameter_Disabled.TabIndex = 22
			Me.chkDesignSinkerbars.Enabled = False
			Me.HelpProvider1.SetHelpKeyword(Me.chkDesignSinkerbars, "Design Sinker Bars")
			Me.HelpProvider1.SetHelpNavigator(Me.chkDesignSinkerbars, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim chkDesignSinkerbars As Global.System.Windows.Forms.Control = Me.chkDesignSinkerbars
			location = New Global.System.Drawing.Point(376, 79)
			chkDesignSinkerbars.Location = location
			Me.chkDesignSinkerbars.Name = "chkDesignSinkerbars"
			Me.HelpProvider1.SetShowHelp(Me.chkDesignSinkerbars, True)
			Dim chkDesignSinkerbars2 As Global.System.Windows.Forms.Control = Me.chkDesignSinkerbars
			size = New Global.System.Drawing.Size(264, 24)
			chkDesignSinkerbars2.Size = size
			Me.chkDesignSinkerbars.TabIndex = 24
			Me.chkDesignSinkerbars.Text = "Design Sinker bars"
			Me.chkDesignSinkerbars.Visible = False
			Me.txtRSSBDiameter.AcceptsReturn = True
			Me.txtRSSBDiameter.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtRSSBDiameter.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtRSSBDiameter.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtRSSBDiameter.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtRSSBDiameter, "Rod string information window: Sinker bar diameter")
			Me.HelpProvider1.SetHelpNavigator(Me.txtRSSBDiameter, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtRSSBDiameter As Global.System.Windows.Forms.Control = Me.txtRSSBDiameter
			location = New Global.System.Drawing.Point(488, 55)
			txtRSSBDiameter.Location = location
			Me.txtRSSBDiameter.MaxLength = 10
			Me.txtRSSBDiameter.Name = "txtRSSBDiameter"
			Me.txtRSSBDiameter.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtRSSBDiameter, True)
			Dim txtRSSBDiameter2 As Global.System.Windows.Forms.Control = Me.txtRSSBDiameter
			size = New Global.System.Drawing.Size(60, 20)
			txtRSSBDiameter2.Size = size
			Me.txtRSSBDiameter.TabIndex = 10
			Me.txtRSSBDiameter.TabStop = False
			Me.txtRSSBDiameter.Tag = "mem"
			Me.lblRSSBDiameter_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblRSSBDiameter_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblRSSBDiameter_Disabled As Global.System.Windows.Forms.Control = Me.lblRSSBDiameter_Disabled
			location = New Global.System.Drawing.Point(488, 55)
			lblRSSBDiameter_Disabled.Location = location
			Me.lblRSSBDiameter_Disabled.Name = "lblRSSBDiameter_Disabled"
			Dim lblRSSBDiameter_Disabled2 As Global.System.Windows.Forms.Control = Me.lblRSSBDiameter_Disabled
			size = New Global.System.Drawing.Size(60, 21)
			lblRSSBDiameter_Disabled2.Size = size
			Me.lblRSSBDiameter_Disabled.TabIndex = 17
			Me.cboRSSRSize.AllowDrop = True
			Me.cboRSSRSize.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboRSSRSize.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboRSSRSize.DropDownWidth = 200
			Me.cboRSSRSize.Enabled = False
			Me.cboRSSRSize.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.cboRSSRSize, "Sucker rod diameter")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRSSRSize, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRSSRSize.ItemHeight = 14
			Dim cboRSSRSize As Global.System.Windows.Forms.Control = Me.cboRSSRSize
			location = New Global.System.Drawing.Point(304, 103)
			cboRSSRSize.Location = location
			Me.cboRSSRSize.MaxDropDownItems = 20
			Me.cboRSSRSize.MaxLength = 100
			Me.cboRSSRSize.Name = "cboRSSRSize"
			Me.HelpProvider1.SetShowHelp(Me.cboRSSRSize, True)
			Dim cboRSSRSize2 As Global.System.Windows.Forms.Control = Me.cboRSSRSize
			size = New Global.System.Drawing.Size(176, 22)
			cboRSSRSize2.Size = size
			Me.cboRSSRSize.TabIndex = 193
			Me.lblRSSRSize_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblRSSRSize_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblRSSRSize_Disabled As Global.System.Windows.Forms.Control = Me.lblRSSRSize_Disabled
			location = New Global.System.Drawing.Point(304, 103)
			lblRSSRSize_Disabled.Location = location
			Me.lblRSSRSize_Disabled.Name = "lblRSSRSize_Disabled"
			Dim lblRSSRSize_Disabled2 As Global.System.Windows.Forms.Control = Me.lblRSSRSize_Disabled
			size = New Global.System.Drawing.Size(176, 22)
			lblRSSRSize_Disabled2.Size = size
			Me.lblRSSRSize_Disabled.TabIndex = 194
			Me.txtRSSBLength.AcceptsReturn = True
			Me.txtRSSBLength.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtRSSBLength.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtRSSBLength.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtRSSBLength.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtRSSBLength, "Rod string information window: Sinker bar length")
			Me.HelpProvider1.SetHelpNavigator(Me.txtRSSBLength, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtRSSBLength As Global.System.Windows.Forms.Control = Me.txtRSSBLength
			location = New Global.System.Drawing.Point(304, 79)
			txtRSSBLength.Location = location
			Me.txtRSSBLength.MaxLength = 10
			Me.txtRSSBLength.Name = "txtRSSBLength"
			Me.txtRSSBLength.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtRSSBLength, True)
			Dim txtRSSBLength2 As Global.System.Windows.Forms.Control = Me.txtRSSBLength
			size = New Global.System.Drawing.Size(61, 20)
			txtRSSBLength2.Size = size
			Me.txtRSSBLength.TabIndex = 18
			Me.txtRSSBLength.TabStop = False
			Me.txtRSSBLength.Tag = "fee"
			Me.lblRSSBLength_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblRSSBLength_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblRSSBLength_Disabled As Global.System.Windows.Forms.Control = Me.lblRSSBLength_Disabled
			location = New Global.System.Drawing.Point(304, 79)
			lblRSSBLength_Disabled.Location = location
			Me.lblRSSBLength_Disabled.Name = "lblRSSBLength_Disabled"
			Dim lblRSSBLength_Disabled2 As Global.System.Windows.Forms.Control = Me.lblRSSBLength_Disabled
			size = New Global.System.Drawing.Size(61, 21)
			lblRSSBLength_Disabled2.Size = size
			Me.lblRSSBLength_Disabled.TabIndex = 20
			Me.ctrOtherInfo.BackColor = Global.System.Drawing.SystemColors.Control
			Me.ctrOtherInfo.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.ctrOtherInfo.Controls.Add(Me.fraOtherInfo)
			Me.ctrOtherInfo.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.ctrOtherInfo.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.ctrOtherInfo.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim ctrOtherInfo As Global.System.Windows.Forms.Control = Me.ctrOtherInfo
			location = New Global.System.Drawing.Point(48, 263)
			ctrOtherInfo.Location = location
			Me.ctrOtherInfo.Name = "ctrOtherInfo"
			Me.ctrOtherInfo.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.ctrOtherInfo, False)
			Dim ctrOtherInfo2 As Global.System.Windows.Forms.Control = Me.ctrOtherInfo
			size = New Global.System.Drawing.Size(702, 96)
			ctrOtherInfo2.Size = size
			Me.ctrOtherInfo.TabIndex = 191
			Me.ctrOtherInfo.TabStop = True
			Me.fraOtherInfo.BackColor = Global.System.Drawing.SystemColors.Control
			Me.fraOtherInfo.Controls.Add(Me.txtRSExtraCostLabel)
			Me.fraOtherInfo.Controls.Add(Me.txtRSFricCoeff)
			Me.fraOtherInfo.Controls.Add(Me.lblRSFricCoeff)
			Me.fraOtherInfo.Controls.Add(Me.txtServiceFactor)
			Me.fraOtherInfo.Controls.Add(Me.txtRSExtraCost)
			Me.fraOtherInfo.Controls.Add(Me.lblServiceFactor)
			Me.fraOtherInfo.Controls.Add(Me.lblRSExtraCostLabel)
			Me.fraOtherInfo.Controls.Add(Me.lbRSExtraCost)
			Me.fraOtherInfo.Controls.Add(Me.lblRodGuides)
			Me.fraOtherInfo.Controls.Add(Me.cboRSRodGuides)
			Me.fraOtherInfo.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.fraOtherInfo.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim fraOtherInfo As Global.System.Windows.Forms.Control = Me.fraOtherInfo
			location = New Global.System.Drawing.Point(0, 4)
			fraOtherInfo.Location = location
			Me.fraOtherInfo.Name = "fraOtherInfo"
			Me.fraOtherInfo.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.fraOtherInfo, False)
			Dim fraOtherInfo2 As Global.System.Windows.Forms.Control = Me.fraOtherInfo
			size = New Global.System.Drawing.Size(688, 90)
			fraOtherInfo2.Size = size
			Me.fraOtherInfo.TabIndex = 32
			Me.fraOtherInfo.TabStop = False
			Me.fraOtherInfo.Text = "Other rod string information"
			Me.txtRSExtraCostLabel.AcceptsReturn = True
			Me.txtRSExtraCostLabel.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtRSExtraCostLabel.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtRSExtraCostLabel.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtRSExtraCostLabel.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtRSExtraCostLabel, "Cost Description")
			Me.HelpProvider1.SetHelpNavigator(Me.txtRSExtraCostLabel, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtRSExtraCostLabel As Global.System.Windows.Forms.Control = Me.txtRSExtraCostLabel
			location = New Global.System.Drawing.Point(275, 40)
			txtRSExtraCostLabel.Location = location
			Me.txtRSExtraCostLabel.MaxLength = 40
			Me.txtRSExtraCostLabel.Name = "txtRSExtraCostLabel"
			Me.txtRSExtraCostLabel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtRSExtraCostLabel, True)
			Dim txtRSExtraCostLabel2 As Global.System.Windows.Forms.Control = Me.txtRSExtraCostLabel
			size = New Global.System.Drawing.Size(395, 22)
			txtRSExtraCostLabel2.Size = size
			Me.txtRSExtraCostLabel.TabIndex = 21
			Me.txtRSExtraCostLabel.TabStop = False
			Me.txtRSFricCoeff.AcceptsReturn = True
			Me.txtRSFricCoeff.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtRSFricCoeff.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtRSFricCoeff.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtRSFricCoeff.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtRSFricCoeff, "Friction Coefficient")
			Me.HelpProvider1.SetHelpNavigator(Me.txtRSFricCoeff, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtRSFricCoeff As Global.System.Windows.Forms.Control = Me.txtRSFricCoeff
			location = New Global.System.Drawing.Point(609, 63)
			txtRSFricCoeff.Location = location
			Me.txtRSFricCoeff.MaxLength = 40
			Me.txtRSFricCoeff.Name = "txtRSFricCoeff"
			Me.txtRSFricCoeff.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtRSFricCoeff, True)
			Dim txtRSFricCoeff2 As Global.System.Windows.Forms.Control = Me.txtRSFricCoeff
			size = New Global.System.Drawing.Size(61, 22)
			txtRSFricCoeff2.Size = size
			Me.txtRSFricCoeff.TabIndex = 22
			Me.txtRSFricCoeff.TabStop = False
			Me.txtRSFricCoeff.Visible = False
			Me.lblRSFricCoeff.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRSFricCoeff.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRSFricCoeff.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblRSFricCoeff.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRSFricCoeff.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblRSFricCoeff As Global.System.Windows.Forms.Control = Me.lblRSFricCoeff
			location = New Global.System.Drawing.Point(443, 65)
			lblRSFricCoeff.Location = location
			Me.lblRSFricCoeff.Name = "lblRSFricCoeff"
			Me.lblRSFricCoeff.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRSFricCoeff, False)
			Dim lblRSFricCoeff2 As Global.System.Windows.Forms.Control = Me.lblRSFricCoeff
			size = New Global.System.Drawing.Size(166, 19)
			lblRSFricCoeff2.Size = size
			Me.lblRSFricCoeff.TabIndex = 37
			Me.lblRSFricCoeff.Text = "Drag Friction Coefficient:"
			Me.lblRSFricCoeff.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblRSFricCoeff.Visible = False
			Me.txtServiceFactor.AcceptsReturn = True
			Me.txtServiceFactor.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtServiceFactor.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtServiceFactor.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtServiceFactor.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtServiceFactor, "Rod string information window: Service factor")
			Me.HelpProvider1.SetHelpNavigator(Me.txtServiceFactor, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.txtServiceFactor.HideSelection = False
			Dim txtServiceFactor As Global.System.Windows.Forms.Control = Me.txtServiceFactor
			location = New Global.System.Drawing.Point(609, 19)
			txtServiceFactor.Location = location
			Me.txtServiceFactor.MaxLength = 40
			Me.txtServiceFactor.Name = "txtServiceFactor"
			Me.txtServiceFactor.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtServiceFactor, True)
			Dim txtServiceFactor2 As Global.System.Windows.Forms.Control = Me.txtServiceFactor
			size = New Global.System.Drawing.Size(61, 22)
			txtServiceFactor2.Size = size
			Me.txtServiceFactor.TabIndex = 20
			Me.txtServiceFactor.TabStop = False
			Me.txtRSExtraCost.AcceptsReturn = True
			Me.txtRSExtraCost.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtRSExtraCost.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtRSExtraCost.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtRSExtraCost.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtRSExtraCost, "Additional rod string costs")
			Me.HelpProvider1.SetHelpNavigator(Me.txtRSExtraCost, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtRSExtraCost As Global.System.Windows.Forms.Control = Me.txtRSExtraCost
			location = New Global.System.Drawing.Point(275, 19)
			txtRSExtraCost.Location = location
			Me.txtRSExtraCost.MaxLength = 40
			Me.txtRSExtraCost.Name = "txtRSExtraCost"
			Me.txtRSExtraCost.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtRSExtraCost, True)
			Dim txtRSExtraCost2 As Global.System.Windows.Forms.Control = Me.txtRSExtraCost
			size = New Global.System.Drawing.Size(61, 22)
			txtRSExtraCost2.Size = size
			Me.txtRSExtraCost.TabIndex = 19
			Me.txtRSExtraCost.TabStop = False
			Me.lblServiceFactor.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblServiceFactor.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblServiceFactor.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblServiceFactor.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblServiceFactor.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblServiceFactor As Global.System.Windows.Forms.Control = Me.lblServiceFactor
			location = New Global.System.Drawing.Point(413, 21)
			lblServiceFactor.Location = location
			Me.lblServiceFactor.Name = "lblServiceFactor"
			Me.lblServiceFactor.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblServiceFactor, False)
			Dim lblServiceFactor2 As Global.System.Windows.Forms.Control = Me.lblServiceFactor
			size = New Global.System.Drawing.Size(192, 19)
			lblServiceFactor2.Size = size
			Me.lblServiceFactor.TabIndex = 35
			Me.lblServiceFactor.Text = "Steel rod service factor:"
			Me.lblServiceFactor.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblRSExtraCostLabel.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRSExtraCostLabel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRSExtraCostLabel.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblRSExtraCostLabel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRSExtraCostLabel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblRSExtraCostLabel As Global.System.Windows.Forms.Control = Me.lblRSExtraCostLabel
			location = New Global.System.Drawing.Point(8, 40)
			lblRSExtraCostLabel.Location = location
			Me.lblRSExtraCostLabel.Name = "lblRSExtraCostLabel"
			Me.lblRSExtraCostLabel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRSExtraCostLabel, False)
			Dim lblRSExtraCostLabel2 As Global.System.Windows.Forms.Control = Me.lblRSExtraCostLabel
			size = New Global.System.Drawing.Size(265, 19)
			lblRSExtraCostLabel2.Size = size
			Me.lblRSExtraCostLabel.TabIndex = 34
			Me.lblRSExtraCostLabel.Text = "Cost description:"
			Me.lblRSExtraCostLabel.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lbRSExtraCost.BackColor = Global.System.Drawing.Color.Transparent
			Me.lbRSExtraCost.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lbRSExtraCost.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lbRSExtraCost.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lbRSExtraCost.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lbRSExtraCost As Global.System.Windows.Forms.Control = Me.lbRSExtraCost
			location = New Global.System.Drawing.Point(8, 21)
			lbRSExtraCost.Location = location
			Me.lbRSExtraCost.Name = "lbRSExtraCost"
			Me.lbRSExtraCost.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lbRSExtraCost, False)
			Dim lbRSExtraCost2 As Global.System.Windows.Forms.Control = Me.lbRSExtraCost
			size = New Global.System.Drawing.Size(265, 19)
			lbRSExtraCost2.Size = size
			Me.lbRSExtraCost.TabIndex = 33
			Me.lbRSExtraCost.Tag = "Pump depth (^):"
			Me.lbRSExtraCost.Text = "Additional rod costs ($):"
			Me.lbRSExtraCost.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblRodGuides.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRodGuides.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRodGuides.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblRodGuides.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRodGuides.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblRodGuides As Global.System.Windows.Forms.Control = Me.lblRodGuides
			location = New Global.System.Drawing.Point(8, 65)
			lblRodGuides.Location = location
			Me.lblRodGuides.Name = "lblRodGuides"
			Me.lblRodGuides.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRodGuides, False)
			Dim lblRodGuides2 As Global.System.Windows.Forms.Control = Me.lblRodGuides
			size = New Global.System.Drawing.Size(265, 19)
			lblRodGuides2.Size = size
			Me.lblRodGuides.TabIndex = 195
			Me.lblRodGuides.Text = "Rod Guide:"
			Me.lblRodGuides.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.cboRSRodGuides.AllowDrop = True
			Me.cboRSRodGuides.BackColor = Global.System.Drawing.Color.White
			Me.cboRSRodGuides.DropDownWidth = 200
			Me.cboRSRodGuides.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.cboRSRodGuides, "rod section grade")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRSRodGuides, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRSRodGuides.ItemHeight = 16
			Dim cboRSRodGuides As Global.System.Windows.Forms.Control = Me.cboRSRodGuides
			location = New Global.System.Drawing.Point(275, 64)
			cboRSRodGuides.Location = location
			Me.cboRSRodGuides.MaxDropDownItems = 12
			Me.cboRSRodGuides.MaxLength = 100
			Me.cboRSRodGuides.Name = "cboRSRodGuides"
			Me.HelpProvider1.SetShowHelp(Me.cboRSRodGuides, True)
			Dim cboRSRodGuides2 As Global.System.Windows.Forms.Control = Me.cboRSRodGuides
			size = New Global.System.Drawing.Size(170, 24)
			cboRSRodGuides2.Size = size
			Me.cboRSRodGuides.TabIndex = 194
			Me.ctrFGDesign.BackColor = Global.System.Drawing.SystemColors.Control
			Me.ctrFGDesign.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.ctrFGDesign.Controls.Add(Me.cboRSFGGrade)
			Me.ctrFGDesign.Controls.Add(Me.lblRSFGGrade)
			Me.ctrFGDesign.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.ctrFGDesign.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.ctrFGDesign.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim ctrFGDesign As Global.System.Windows.Forms.Control = Me.ctrFGDesign
			location = New Global.System.Drawing.Point(48, 0)
			ctrFGDesign.Location = location
			Me.ctrFGDesign.Name = "ctrFGDesign"
			Me.ctrFGDesign.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.ctrFGDesign, False)
			Dim ctrFGDesign2 As Global.System.Windows.Forms.Control = Me.ctrFGDesign
			size = New Global.System.Drawing.Size(702, 28)
			ctrFGDesign2.Size = size
			Me.ctrFGDesign.TabIndex = 27
			Me.ctrFGDesign.TabStop = True
			Me.cboRSFGGrade.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboRSFGGrade.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboRSFGGrade.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboRSFGGrade.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboRSFGGrade.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboRSFGGrade, "Fiberglass rod manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRSFGGrade, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRSFGGrade.ItemHeight = 14
			Dim cboRSFGGrade As Global.System.Windows.Forms.Control = Me.cboRSFGGrade
			location = New Global.System.Drawing.Point(304, 1)
			cboRSFGGrade.Location = location
			Me.cboRSFGGrade.Name = "cboRSFGGrade"
			Me.cboRSFGGrade.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboRSFGGrade, True)
			Dim cboRSFGGrade2 As Global.System.Windows.Forms.Control = Me.cboRSFGGrade
			size = New Global.System.Drawing.Size(189, 22)
			cboRSFGGrade2.Size = size
			Me.cboRSFGGrade.TabIndex = 8
			Me.cboRSFGGrade.TabStop = False
			Me.lblRSFGGrade.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRSFGGrade.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRSFGGrade.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblRSFGGrade.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRSFGGrade.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me.lblRSFGGrade, 0S)
			Dim lblRSFGGrade As Global.System.Windows.Forms.Control = Me.lblRSFGGrade
			location = New Global.System.Drawing.Point(8, 6)
			lblRSFGGrade.Location = location
			Me.lblRSFGGrade.Name = "lblRSFGGrade"
			Me.lblRSFGGrade.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRSFGGrade, False)
			Dim lblRSFGGrade2 As Global.System.Windows.Forms.Control = Me.lblRSFGGrade
			size = New Global.System.Drawing.Size(296, 19)
			lblRSFGGrade2.Size = size
			Me.lblRSFGGrade.TabIndex = 29
			Me.lblRSFGGrade.Text = "Fiberglass grade/manufacturer:"
			Me.lblRSFGGrade.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.ctrSteelDesign.BackColor = Global.System.Drawing.SystemColors.Control
			Me.ctrSteelDesign.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.ctrSteelDesign.Controls.Add(Me.fraSteelDesign)
			Me.ctrSteelDesign.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.ctrSteelDesign.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.ctrSteelDesign.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim ctrSteelDesign As Global.System.Windows.Forms.Control = Me.ctrSteelDesign
			location = New Global.System.Drawing.Point(48, 27)
			ctrSteelDesign.Location = location
			Me.ctrSteelDesign.Name = "ctrSteelDesign"
			Me.ctrSteelDesign.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.ctrSteelDesign, False)
			Dim ctrSteelDesign2 As Global.System.Windows.Forms.Control = Me.ctrSteelDesign
			size = New Global.System.Drawing.Size(702, 100)
			ctrSteelDesign2.Size = size
			Me.ctrSteelDesign.TabIndex = 30
			Me.ctrSteelDesign.TabStop = True
			Me.fraSteelDesign.BackColor = Global.System.Drawing.SystemColors.Control
			Me.fraSteelDesign.Controls.Add(Me.chkRSFGIncludeSteel)
			Me.fraSteelDesign.Controls.Add(Me.lblRSMaxSize)
			Me.fraSteelDesign.Controls.Add(Me.lblRSMinSize)
			Me.fraSteelDesign.Controls.Add(Me.lblRSGrade)
			Me.fraSteelDesign.Controls.Add(Me.cboRSGrade)
			Me.fraSteelDesign.Controls.Add(Me.cboRSMinSize)
			Me.fraSteelDesign.Controls.Add(Me.lblRSGrade_Disabled)
			Me.fraSteelDesign.Controls.Add(Me.lblRSMinSize_Disabled)
			Me.fraSteelDesign.Controls.Add(Me.cboRSMaxSize)
			Me.fraSteelDesign.Controls.Add(Me.lblRSMaxSize_Disabled)
			Me.fraSteelDesign.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.fraSteelDesign.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim fraSteelDesign As Global.System.Windows.Forms.Control = Me.fraSteelDesign
			location = New Global.System.Drawing.Point(0, 0)
			fraSteelDesign.Location = location
			Me.fraSteelDesign.Name = "fraSteelDesign"
			Me.fraSteelDesign.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.fraSteelDesign, False)
			Dim fraSteelDesign2 As Global.System.Windows.Forms.Control = Me.fraSteelDesign
			size = New Global.System.Drawing.Size(688, 97)
			fraSteelDesign2.Size = size
			Me.fraSteelDesign.TabIndex = 31
			Me.fraSteelDesign.TabStop = False
			Me.chkRSFGIncludeSteel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkRSFGIncludeSteel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkRSFGIncludeSteel.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.chkRSFGIncludeSteel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.chkRSFGIncludeSteel, "Include steel below fiberglass")
			Me.HelpProvider1.SetHelpNavigator(Me.chkRSFGIncludeSteel, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkRSFGIncludeSteel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkRSFGIncludeSteel As Global.System.Windows.Forms.Control = Me.chkRSFGIncludeSteel
			location = New Global.System.Drawing.Point(9, 0)
			chkRSFGIncludeSteel.Location = location
			Me.chkRSFGIncludeSteel.Name = "chkRSFGIncludeSteel"
			Me.chkRSFGIncludeSteel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkRSFGIncludeSteel, True)
			Dim chkRSFGIncludeSteel2 As Global.System.Windows.Forms.Control = Me.chkRSFGIncludeSteel
			size = New Global.System.Drawing.Size(271, 19)
			chkRSFGIncludeSteel2.Size = size
			Me.chkRSFGIncludeSteel.TabIndex = 32
			Me.chkRSFGIncludeSteel.TabStop = False
			Me.chkRSFGIncludeSteel.Text = "Include steel rods beneath fiberglass"
			Me.chkRSFGIncludeSteel.UseVisualStyleBackColor = False
			Me.lblRSMaxSize.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRSMaxSize.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRSMaxSize.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblRSMaxSize.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRSMaxSize.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me.lblRSMaxSize, 3S)
			Dim lblRSMaxSize As Global.System.Windows.Forms.Control = Me.lblRSMaxSize
			location = New Global.System.Drawing.Point(8, 47)
			lblRSMaxSize.Location = location
			Me.lblRSMaxSize.Name = "lblRSMaxSize"
			Me.lblRSMaxSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRSMaxSize, False)
			Dim lblRSMaxSize2 As Global.System.Windows.Forms.Control = Me.lblRSMaxSize
			size = New Global.System.Drawing.Size(296, 19)
			lblRSMaxSize2.Size = size
			Me.lblRSMaxSize.TabIndex = 38
			Me.lblRSMaxSize.Text = "Maximum rod diameter to use:"
			Me.lblRSMaxSize.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblRSMinSize.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRSMinSize.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRSMinSize.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblRSMinSize.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRSMinSize.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me.lblRSMinSize, 4S)
			Dim lblRSMinSize As Global.System.Windows.Forms.Control = Me.lblRSMinSize
			location = New Global.System.Drawing.Point(8, 71)
			lblRSMinSize.Location = location
			Me.lblRSMinSize.Name = "lblRSMinSize"
			Me.lblRSMinSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRSMinSize, False)
			Dim lblRSMinSize2 As Global.System.Windows.Forms.Control = Me.lblRSMinSize
			size = New Global.System.Drawing.Size(296, 19)
			lblRSMinSize2.Size = size
			Me.lblRSMinSize.TabIndex = 37
			Me.lblRSMinSize.Text = "Minimum rod diameter to use:"
			Me.lblRSMinSize.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblRSGrade.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRSGrade.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRSGrade.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblRSGrade.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRSGrade.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me.lblRSGrade, 2S)
			Dim lblRSGrade As Global.System.Windows.Forms.Control = Me.lblRSGrade
			location = New Global.System.Drawing.Point(8, 23)
			lblRSGrade.Location = location
			Me.lblRSGrade.Name = "lblRSGrade"
			Me.lblRSGrade.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRSGrade, False)
			Dim lblRSGrade2 As Global.System.Windows.Forms.Control = Me.lblRSGrade
			size = New Global.System.Drawing.Size(296, 19)
			lblRSGrade2.Size = size
			Me.lblRSGrade.TabIndex = 36
			Me.lblRSGrade.Text = "Steel grade or manufacturer:"
			Me.lblRSGrade.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.cboRSGrade.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboRSGrade.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboRSGrade.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboRSGrade.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboRSGrade.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboRSGrade, "Steel rod grade or manufacturer (steel rod design)")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRSGrade, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRSGrade.ItemHeight = 14
			Dim cboRSGrade As Global.System.Windows.Forms.Control = Me.cboRSGrade
			location = New Global.System.Drawing.Point(304, 19)
			cboRSGrade.Location = location
			Me.cboRSGrade.Name = "cboRSGrade"
			Me.cboRSGrade.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboRSGrade, True)
			Dim cboRSGrade2 As Global.System.Windows.Forms.Control = Me.cboRSGrade
			size = New Global.System.Drawing.Size(248, 22)
			cboRSGrade2.Size = size
			Me.cboRSGrade.TabIndex = 9
			Me.cboRSGrade.TabStop = False
			Me.cboRSMinSize.AllowDrop = True
			Me.cboRSMinSize.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboRSMinSize.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboRSMinSize.DropDownWidth = 200
			Me.cboRSMinSize.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.cboRSMinSize, "Minimum rod diameter")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRSMinSize, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRSMinSize.ItemHeight = 14
			Dim cboRSMinSize As Global.System.Windows.Forms.Control = Me.cboRSMinSize
			location = New Global.System.Drawing.Point(304, 67)
			cboRSMinSize.Location = location
			Me.cboRSMinSize.MaxDropDownItems = 20
			Me.cboRSMinSize.MaxLength = 100
			Me.cboRSMinSize.Name = "cboRSMinSize"
			Me.HelpProvider1.SetShowHelp(Me.cboRSMinSize, True)
			Dim cboRSMinSize2 As Global.System.Windows.Forms.Control = Me.cboRSMinSize
			size = New Global.System.Drawing.Size(176, 22)
			cboRSMinSize2.Size = size
			Me.cboRSMinSize.TabIndex = 188
			Me.lblRSGrade_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblRSGrade_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblRSGrade_Disabled As Global.System.Windows.Forms.Control = Me.lblRSGrade_Disabled
			location = New Global.System.Drawing.Point(304, 19)
			lblRSGrade_Disabled.Location = location
			Me.lblRSGrade_Disabled.Name = "lblRSGrade_Disabled"
			Dim lblRSGrade_Disabled2 As Global.System.Windows.Forms.Control = Me.lblRSGrade_Disabled
			size = New Global.System.Drawing.Size(248, 22)
			lblRSGrade_Disabled2.Size = size
			Me.lblRSGrade_Disabled.TabIndex = 189
			Me.lblRSMinSize_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblRSMinSize_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblRSMinSize_Disabled As Global.System.Windows.Forms.Control = Me.lblRSMinSize_Disabled
			location = New Global.System.Drawing.Point(304, 67)
			lblRSMinSize_Disabled.Location = location
			Me.lblRSMinSize_Disabled.Name = "lblRSMinSize_Disabled"
			Dim lblRSMinSize_Disabled2 As Global.System.Windows.Forms.Control = Me.lblRSMinSize_Disabled
			size = New Global.System.Drawing.Size(176, 22)
			lblRSMinSize_Disabled2.Size = size
			Me.lblRSMinSize_Disabled.TabIndex = 191
			Me.cboRSMaxSize.AllowDrop = True
			Me.cboRSMaxSize.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboRSMaxSize.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboRSMaxSize.DropDownWidth = 200
			Me.cboRSMaxSize.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.cboRSMaxSize, "Maximum rod diameter")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRSMaxSize, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRSMaxSize.ItemHeight = 14
			Dim cboRSMaxSize As Global.System.Windows.Forms.Control = Me.cboRSMaxSize
			location = New Global.System.Drawing.Point(304, 43)
			cboRSMaxSize.Location = location
			Me.cboRSMaxSize.MaxDropDownItems = 20
			Me.cboRSMaxSize.MaxLength = 100
			Me.cboRSMaxSize.Name = "cboRSMaxSize"
			Me.HelpProvider1.SetShowHelp(Me.cboRSMaxSize, True)
			Dim cboRSMaxSize2 As Global.System.Windows.Forms.Control = Me.cboRSMaxSize
			size = New Global.System.Drawing.Size(176, 22)
			cboRSMaxSize2.Size = size
			Me.cboRSMaxSize.TabIndex = 187
			Me.lblRSMaxSize_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblRSMaxSize_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblRSMaxSize_Disabled As Global.System.Windows.Forms.Control = Me.lblRSMaxSize_Disabled
			location = New Global.System.Drawing.Point(304, 43)
			lblRSMaxSize_Disabled.Location = location
			Me.lblRSMaxSize_Disabled.Name = "lblRSMaxSize_Disabled"
			Dim lblRSMaxSize_Disabled2 As Global.System.Windows.Forms.Control = Me.lblRSMaxSize_Disabled
			size = New Global.System.Drawing.Size(176, 22)
			lblRSMaxSize_Disabled2.Size = size
			Me.lblRSMaxSize_Disabled.TabIndex = 190
			Dim txtTempLength As Global.System.Windows.Forms.Control = Me.txtTempLength
			location = New Global.System.Drawing.Point(1024, 152)
			txtTempLength.Location = location
			Me.txtTempLength.Name = "txtTempLength"
			Me.HelpProvider1.SetShowHelp(Me.txtTempLength, False)
			Dim txtTempLength2 As Global.System.Windows.Forms.Control = Me.txtTempLength
			size = New Global.System.Drawing.Size(96, 20)
			txtTempLength2.Size = size
			Me.txtTempLength.TabIndex = 184
			Me.txtTempLength.Tag = "fem"
			Me.txtTempLength.Text = "txtTempLength"
			Me.txtTempLength.Visible = False
			Dim txtTempDiam As Global.System.Windows.Forms.Control = Me.txtTempDiam
			location = New Global.System.Drawing.Point(1024, 200)
			txtTempDiam.Location = location
			Me.txtTempDiam.Name = "txtTempDiam"
			Me.HelpProvider1.SetShowHelp(Me.txtTempDiam, False)
			Dim txtTempDiam2 As Global.System.Windows.Forms.Control = Me.txtTempDiam
			size = New Global.System.Drawing.Size(112, 20)
			txtTempDiam2.Size = size
			Me.txtTempDiam.TabIndex = 185
			Me.txtTempDiam.Tag = "mem"
			Me.txtTempDiam.Text = "txtTempDiam"
			Me.txtTempDiam.Visible = False
			Me.lblTemp.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblTemp As Global.System.Windows.Forms.Control = Me.lblTemp
			location = New Global.System.Drawing.Point(1024, 136)
			lblTemp.Location = location
			Me.lblTemp.Name = "lblTemp"
			Me.HelpProvider1.SetShowHelp(Me.lblTemp, False)
			Dim lblTemp2 As Global.System.Windows.Forms.Control = Me.lblTemp
			size = New Global.System.Drawing.Size(56, 16)
			lblTemp2.Size = size
			Me.lblTemp.TabIndex = 186
			Me.lblTemp.Text = "lblTemp"
			Me.lblTemp.Visible = False
			Me.lblStatus.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblStatus.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.lblStatus.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblStatus.ForeColor = Global.System.Drawing.Color.FromArgb(192, 0, 0)
			Dim lblStatus As Global.System.Windows.Forms.Control = Me.lblStatus
			location = New Global.System.Drawing.Point(0, 450)
			lblStatus.Location = location
			Me.lblStatus.Name = "lblStatus"
			Dim lblStatus2 As Global.System.Windows.Forms.Control = Me.lblStatus
			size = New Global.System.Drawing.Size(798, 20)
			lblStatus2.Size = size
			Me.lblStatus.TabIndex = 187
			Me.lblStatus.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(798, 470)
			Me.ClientSize = size
			Me.Controls.Add(Me.lblStatus)
			Me.Controls.Add(Me.lblTemp)
			Me.Controls.Add(Me.txtTempDiam)
			Me.Controls.Add(Me.txtTempLength)
			Me.Controls.Add(Me.picRemoveFocus)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			location = New Global.System.Drawing.Point(4, 23)
			Me.Location = location
			Me.Name = "RSInput"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Tag = "4"
			Me.Text = "Rod String Information"
			Me.picRemoveFocus.ResumeLayout(False)
			Me.tbsRodDesignType.ResumeLayout(False)
			Me.ctrRodString.ResumeLayout(False)
			Me.ctrRodString.PerformLayout()
			CType(Me.ulgTapers, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ctrSinkerBars.ResumeLayout(False)
			Me.fraSinkerBars.ResumeLayout(False)
			Me.fraSinkerBars.PerformLayout()
			Me.ctrOtherInfo.ResumeLayout(False)
			Me.fraOtherInfo.ResumeLayout(False)
			Me.fraOtherInfo.PerformLayout()
			Me.ctrFGDesign.ResumeLayout(False)
			Me.ctrSteelDesign.ResumeLayout(False)
			Me.fraSteelDesign.ResumeLayout(False)
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Line, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
