Namespace RSWINV3
	Public Partial Class PUData
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.PUData))
			Me.pnlPUData = New Global.System.Windows.Forms.Panel()
			Me.cboCrankRotation = New Global.System.Windows.Forms.ComboBox()
			Me.cmdUnitSizeRecommendation = New Global.System.Windows.Forms.Button()
			Me.lblCalcStroke = New Global.System.Windows.Forms.Label()
			Me.lvwUnitList = New Global.System.Windows.Forms.ListView()
			Me.lblStructuralUnbalance = New Global.System.Windows.Forms.Label()
			Me.grpCounterBalance = New Global.System.Windows.Forms.GroupBox()
			Me.lblCounterbalance_Disabled = New Global.System.Windows.Forms.Label()
			Me.cmdCBApplet = New Global.System.Windows.Forms.Button()
			Me.optCBDataType_6 = New Global.System.Windows.Forms.RadioButton()
			Me.cmdReadCBLFile = New Global.System.Windows.Forms.Button()
			Me.lblCBDataFile = New Global.System.Windows.Forms.Label()
			Me.optCBDataType_3 = New Global.System.Windows.Forms.RadioButton()
			Me.lblMInLbs = New Global.System.Windows.Forms.Label()
			Me.optCBDataType_1 = New Global.System.Windows.Forms.RadioButton()
			Me.optCBDataType_5 = New Global.System.Windows.Forms.RadioButton()
			Me.txtCounterbalance = New Global.System.Windows.Forms.TextBox()
			Me.lblManufacturer = New Global.System.Windows.Forms.Label()
			Me.lblCrankRotation = New Global.System.Windows.Forms.Label()
			Me.lblStrokeLength = New Global.System.Windows.Forms.Label()
			Me.cboManufMenu = New Global.System.Windows.Forms.ComboBox()
			Me.lblCrankHole = New Global.System.Windows.Forms.Label()
			Me.chkCustomPUDB = New Global.System.Windows.Forms.CheckBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtUnitID = New Global.System.Windows.Forms.TextBox()
			Me.lblUnitID = New Global.System.Windows.Forms.Label()
			Me.lblAPI = New Global.System.Windows.Forms.Label()
			Me.txtUnbalance = New Global.System.Windows.Forms.TextBox()
			Me.cboCrankHole = New Global.System.Windows.Forms.ComboBox()
			Me.pnlHydraulic = New Global.System.Windows.Forms.Panel()
			Me.lblAdjustedStrokeLength = New Global.System.Windows.Forms.Label()
			Me.txtAdjustedStrokeLength = New Global.System.Windows.Forms.TextBox()
			Me.lblPercentDownstrokeSPM = New Global.System.Windows.Forms.Label()
			Me.txtPercentDownstrokeSPM = New Global.System.Windows.Forms.TextBox()
			Me.lblPercentUpstrokeSPM = New Global.System.Windows.Forms.Label()
			Me.txtPercentUpstrokeSPM = New Global.System.Windows.Forms.TextBox()
			Me.pnlCombinationBeamCrank = New Global.System.Windows.Forms.Panel()
			Me.optUseCrankBalancedCalcs = New Global.System.Windows.Forms.RadioButton()
			Me.optUseBeamBalancedCalcs = New Global.System.Windows.Forms.RadioButton()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.pnlPUData.SuspendLayout()
			Me.grpCounterBalance.SuspendLayout()
			Me.pnlHydraulic.SuspendLayout()
			Me.pnlCombinationBeamCrank.SuspendLayout()
			Me.SuspendLayout()
			Me.pnlPUData.Controls.Add(Me.cboCrankRotation)
			Me.pnlPUData.Controls.Add(Me.cmdUnitSizeRecommendation)
			Me.pnlPUData.Controls.Add(Me.lblCalcStroke)
			Me.pnlPUData.Controls.Add(Me.lvwUnitList)
			Me.pnlPUData.Controls.Add(Me.lblStructuralUnbalance)
			Me.pnlPUData.Controls.Add(Me.grpCounterBalance)
			Me.pnlPUData.Controls.Add(Me.lblManufacturer)
			Me.pnlPUData.Controls.Add(Me.lblCrankRotation)
			Me.pnlPUData.Controls.Add(Me.lblStrokeLength)
			Me.pnlPUData.Controls.Add(Me.cboManufMenu)
			Me.pnlPUData.Controls.Add(Me.lblCrankHole)
			Me.pnlPUData.Controls.Add(Me.chkCustomPUDB)
			Me.pnlPUData.Controls.Add(Me.Label5)
			Me.pnlPUData.Controls.Add(Me.txtUnitID)
			Me.pnlPUData.Controls.Add(Me.lblUnitID)
			Me.pnlPUData.Controls.Add(Me.lblAPI)
			Me.pnlPUData.Controls.Add(Me.txtUnbalance)
			Me.pnlPUData.Controls.Add(Me.cboCrankHole)
			Me.pnlPUData.Controls.Add(Me.pnlHydraulic)
			Me.pnlPUData.Controls.Add(Me.pnlCombinationBeamCrank)
			Me.pnlPUData.Controls.Add(Me.Panel1)
			Dim pnlPUData As Global.System.Windows.Forms.Control = Me.pnlPUData
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(8, 8)
			pnlPUData.Location = location
			Me.pnlPUData.Name = "pnlPUData"
			Me.HelpProvider1.SetShowHelp(Me.pnlPUData, False)
			Dim pnlPUData2 As Global.System.Windows.Forms.Control = Me.pnlPUData
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(896, 493)
			pnlPUData2.Size = size
			Me.pnlPUData.TabIndex = 0
			Me.cboCrankRotation.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboCrankRotation.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboCrankRotation.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboCrankRotation.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboCrankRotation.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboCrankRotation, "crank rotation")
			Me.HelpProvider1.SetHelpNavigator(Me.cboCrankRotation, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboCrankRotation.ItemHeight = 16
			Me.cboCrankRotation.Items.AddRange(New Object() { "Clockwise", "Counterclockwise" })
			Dim cboCrankRotation As Global.System.Windows.Forms.Control = Me.cboCrankRotation
			location = New Global.System.Drawing.Point(752, 136)
			cboCrankRotation.Location = location
			Me.cboCrankRotation.Name = "cboCrankRotation"
			Me.cboCrankRotation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboCrankRotation, True)
			Dim cboCrankRotation2 As Global.System.Windows.Forms.Control = Me.cboCrankRotation
			size = New Global.System.Drawing.Size(128, 24)
			cboCrankRotation2.Size = size
			Me.cboCrankRotation.TabIndex = 5
			Me.cmdUnitSizeRecommendation.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.cmdUnitSizeRecommendation.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdUnitSizeRecommendation As Global.System.Windows.Forms.Control = Me.cmdUnitSizeRecommendation
			location = New Global.System.Drawing.Point(544, 96)
			cmdUnitSizeRecommendation.Location = location
			Me.cmdUnitSizeRecommendation.Name = "cmdUnitSizeRecommendation"
			Me.HelpProvider1.SetShowHelp(Me.cmdUnitSizeRecommendation, False)
			Dim cmdUnitSizeRecommendation2 As Global.System.Windows.Forms.Control = Me.cmdUnitSizeRecommendation
			size = New Global.System.Drawing.Size(344, 24)
			cmdUnitSizeRecommendation2.Size = size
			Me.cmdUnitSizeRecommendation.TabIndex = 58
			Me.cmdUnitSizeRecommendation.Text = "Recommended Unit Size"
			Me.lblCalcStroke.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblCalcStroke.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblCalcStroke.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.lblCalcStroke.ForeColor = Global.System.Drawing.Color.Blue
			Me.lblCalcStroke.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCalcStroke As Global.System.Windows.Forms.Control = Me.lblCalcStroke
			location = New Global.System.Drawing.Point(752, 188)
			lblCalcStroke.Location = location
			Me.lblCalcStroke.Name = "lblCalcStroke"
			Me.lblCalcStroke.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblCalcStroke, False)
			Dim lblCalcStroke2 As Global.System.Windows.Forms.Control = Me.lblCalcStroke
			size = New Global.System.Drawing.Size(112, 15)
			lblCalcStroke2.Size = size
			Me.lblCalcStroke.TabIndex = 50
			Me.lblCalcStroke.Text = "api"
			Me.lvwUnitList.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.lvwUnitList.FullRowSelect = True
			Me.lvwUnitList.GridLines = True
			Me.HelpProvider1.SetHelpKeyword(Me.lvwUnitList, "pumping unit type")
			Me.HelpProvider1.SetHelpNavigator(Me.lvwUnitList, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim lvwUnitList As Global.System.Windows.Forms.Control = Me.lvwUnitList
			location = New Global.System.Drawing.Point(8, 40)
			lvwUnitList.Location = location
			Me.lvwUnitList.MultiSelect = False
			Me.lvwUnitList.Name = "lvwUnitList"
			Me.HelpProvider1.SetShowHelp(Me.lvwUnitList, True)
			Dim lvwUnitList2 As Global.System.Windows.Forms.Control = Me.lvwUnitList
			size = New Global.System.Drawing.Size(520, 296)
			lvwUnitList2.Size = size
			Me.lvwUnitList.TabIndex = 3
			Me.lvwUnitList.UseCompatibleStateImageBehavior = False
			Me.lblStructuralUnbalance.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblStructuralUnbalance.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblStructuralUnbalance.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblStructuralUnbalance.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblStructuralUnbalance.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblStructuralUnbalance As Global.System.Windows.Forms.Control = Me.lblStructuralUnbalance
			location = New Global.System.Drawing.Point(544, 214)
			lblStructuralUnbalance.Location = location
			Me.lblStructuralUnbalance.Name = "lblStructuralUnbalance"
			Me.lblStructuralUnbalance.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblStructuralUnbalance, False)
			Dim lblStructuralUnbalance2 As Global.System.Windows.Forms.Control = Me.lblStructuralUnbalance
			size = New Global.System.Drawing.Size(200, 19)
			lblStructuralUnbalance2.Size = size
			Me.lblStructuralUnbalance.TabIndex = 54
			Me.lblStructuralUnbalance.Tag = "Structural Unbalance (^):"
			Me.lblStructuralUnbalance.Text = "Structural Unbalance (lbs):"
			Me.grpCounterBalance.Controls.Add(Me.lblCounterbalance_Disabled)
			Me.grpCounterBalance.Controls.Add(Me.cmdCBApplet)
			Me.grpCounterBalance.Controls.Add(Me.optCBDataType_6)
			Me.grpCounterBalance.Controls.Add(Me.cmdReadCBLFile)
			Me.grpCounterBalance.Controls.Add(Me.lblCBDataFile)
			Me.grpCounterBalance.Controls.Add(Me.optCBDataType_3)
			Me.grpCounterBalance.Controls.Add(Me.lblMInLbs)
			Me.grpCounterBalance.Controls.Add(Me.optCBDataType_1)
			Me.grpCounterBalance.Controls.Add(Me.optCBDataType_5)
			Me.grpCounterBalance.Controls.Add(Me.txtCounterbalance)
			Me.grpCounterBalance.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Dim grpCounterBalance As Global.System.Windows.Forms.Control = Me.grpCounterBalance
			location = New Global.System.Drawing.Point(8, 360)
			grpCounterBalance.Location = location
			Me.grpCounterBalance.Name = "grpCounterBalance"
			Me.HelpProvider1.SetShowHelp(Me.grpCounterBalance, False)
			Dim grpCounterBalance2 As Global.System.Windows.Forms.Control = Me.grpCounterBalance
			size = New Global.System.Drawing.Size(880, 128)
			grpCounterBalance2.Size = size
			Me.grpCounterBalance.TabIndex = 51
			Me.grpCounterBalance.TabStop = False
			Me.grpCounterBalance.Text = "Select a counterbalance option"
			Me.lblCounterbalance_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblCounterbalance_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblCounterbalance_Disabled As Global.System.Windows.Forms.Control = Me.lblCounterbalance_Disabled
			location = New Global.System.Drawing.Point(371, 44)
			lblCounterbalance_Disabled.Location = location
			Me.lblCounterbalance_Disabled.Name = "lblCounterbalance_Disabled"
			Dim lblCounterbalance_Disabled2 As Global.System.Windows.Forms.Control = Me.lblCounterbalance_Disabled
			size = New Global.System.Drawing.Size(63, 22)
			lblCounterbalance_Disabled2.Size = size
			Me.lblCounterbalance_Disabled.TabIndex = 213
			Me.cmdCBApplet.Enabled = False
			Me.cmdCBApplet.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.cmdCBApplet.Image = CType(componentResourceManager.GetObject("cmdCBApplet.Image"), Global.System.Drawing.Image)
			Me.cmdCBApplet.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCBApplet As Global.System.Windows.Forms.Control = Me.cmdCBApplet
			location = New Global.System.Drawing.Point(296, 68)
			cmdCBApplet.Location = location
			Me.cmdCBApplet.Name = "cmdCBApplet"
			Me.HelpProvider1.SetShowHelp(Me.cmdCBApplet, False)
			Dim cmdCBApplet2 As Global.System.Windows.Forms.Control = Me.cmdCBApplet
			size = New Global.System.Drawing.Size(24, 24)
			cmdCBApplet2.Size = size
			Me.cmdCBApplet.TabIndex = 16
			Me.optCBDataType_6.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optCBDataType_6.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optCBDataType_6.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.optCBDataType_6.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optCBDataType_6, "Get XBAL Information")
			Me.HelpProvider1.SetHelpNavigator(Me.optCBDataType_6, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optCBDataType_6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCBDataType_ As Global.System.Windows.Forms.Control = Me.optCBDataType_6
			location = New Global.System.Drawing.Point(16, 96)
			optCBDataType_.Location = location
			Me.optCBDataType_6.Name = "optCBDataType_6"
			Me.optCBDataType_6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optCBDataType_6, True)
			Dim optCBDataType_2 As Global.System.Windows.Forms.Control = Me.optCBDataType_6
			size = New Global.System.Drawing.Size(272, 19)
			optCBDataType_2.Size = size
			Me.optCBDataType_6.TabIndex = 17
			Me.optCBDataType_6.TabStop = True
			Me.optCBDataType_6.Text = "Import XBAL file"
			Me.optCBDataType_6.UseVisualStyleBackColor = False
			Me.optCBDataType_6.Visible = False
			Me.cmdReadCBLFile.Enabled = False
			Me.cmdReadCBLFile.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.cmdReadCBLFile, "Get XBAL Information")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdReadCBLFile, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdReadCBLFile.Image = CType(componentResourceManager.GetObject("cmdReadCBLFile.Image"), Global.System.Drawing.Image)
			Me.cmdReadCBLFile.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdReadCBLFile As Global.System.Windows.Forms.Control = Me.cmdReadCBLFile
			location = New Global.System.Drawing.Point(296, 96)
			cmdReadCBLFile.Location = location
			Me.cmdReadCBLFile.Name = "cmdReadCBLFile"
			Me.HelpProvider1.SetShowHelp(Me.cmdReadCBLFile, True)
			Dim cmdReadCBLFile2 As Global.System.Windows.Forms.Control = Me.cmdReadCBLFile
			size = New Global.System.Drawing.Size(24, 24)
			cmdReadCBLFile2.Size = size
			Me.cmdReadCBLFile.TabIndex = 18
			Me.cmdReadCBLFile.Visible = False
			Me.lblCBDataFile.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblCBDataFile.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCBDataFile As Global.System.Windows.Forms.Control = Me.lblCBDataFile
			location = New Global.System.Drawing.Point(336, 70)
			lblCBDataFile.Location = location
			Me.lblCBDataFile.Name = "lblCBDataFile"
			Me.HelpProvider1.SetShowHelp(Me.lblCBDataFile, False)
			Dim lblCBDataFile2 As Global.System.Windows.Forms.Control = Me.lblCBDataFile
			size = New Global.System.Drawing.Size(472, 19)
			lblCBDataFile2.Size = size
			Me.lblCBDataFile.TabIndex = 47
			Me.lblCBDataFile.Text = "File:  (none selected)"
			Me.optCBDataType_3.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optCBDataType_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optCBDataType_3.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.optCBDataType_3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optCBDataType_3, "Unknown MCM or Structural Unbalance")
			Me.HelpProvider1.SetHelpNavigator(Me.optCBDataType_3, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optCBDataType_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCBDataType_3 As Global.System.Windows.Forms.Control = Me.optCBDataType_3
			location = New Global.System.Drawing.Point(16, 20)
			optCBDataType_3.Location = location
			Me.optCBDataType_3.Name = "optCBDataType_3"
			Me.optCBDataType_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optCBDataType_3, True)
			Dim optCBDataType_4 As Global.System.Windows.Forms.Control = Me.optCBDataType_3
			size = New Global.System.Drawing.Size(594, 19)
			optCBDataType_4.Size = size
			Me.optCBDataType_3.TabIndex = 8
			Me.optCBDataType_3.TabStop = True
			Me.optCBDataType_3.Text = "Unknown MCM"
			Me.optCBDataType_3.UseVisualStyleBackColor = False
			Me.lblMInLbs.AutoSize = True
			Me.lblMInLbs.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblMInLbs.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblMInLbs.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblMInLbs.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblMInLbs.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblMInLbs As Global.System.Windows.Forms.Control = Me.lblMInLbs
			location = New Global.System.Drawing.Point(302, 46)
			lblMInLbs.Location = location
			Me.lblMInLbs.Name = "lblMInLbs"
			Me.lblMInLbs.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblMInLbs, False)
			Dim lblMInLbs2 As Global.System.Windows.Forms.Control = Me.lblMInLbs
			size = New Global.System.Drawing.Size(62, 16)
			lblMInLbs2.Size = size
			Me.lblMInLbs.TabIndex = 38
			Me.lblMInLbs.Tag = "(^)"
			Me.lblMInLbs.Text = "(M in-lbs)"
			Me.lblMInLbs.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.optCBDataType_1.AutoSize = True
			Me.optCBDataType_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optCBDataType_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optCBDataType_1.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.optCBDataType_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optCBDataType_1, "Existing Maximum Counterbalance or Structural Unbalance")
			Me.HelpProvider1.SetHelpNavigator(Me.optCBDataType_1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optCBDataType_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCBDataType_5 As Global.System.Windows.Forms.Control = Me.optCBDataType_1
			location = New Global.System.Drawing.Point(16, 44)
			optCBDataType_5.Location = location
			Me.optCBDataType_1.Name = "optCBDataType_1"
			Me.optCBDataType_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optCBDataType_1, True)
			Dim optCBDataType_6 As Global.System.Windows.Forms.Control = Me.optCBDataType_1
			size = New Global.System.Drawing.Size(277, 20)
			optCBDataType_6.Size = size
			Me.optCBDataType_1.TabIndex = 9
			Me.optCBDataType_1.TabStop = True
			Me.optCBDataType_1.Text = "Existing maximum counterbalance moment"
			Me.optCBDataType_1.UseVisualStyleBackColor = False
			Me.optCBDataType_5.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optCBDataType_5.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optCBDataType_5.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.optCBDataType_5.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optCBDataType_5, "Get XBAL Information")
			Me.HelpProvider1.SetHelpNavigator(Me.optCBDataType_5, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optCBDataType_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCBDataType_7 As Global.System.Windows.Forms.Control = Me.optCBDataType_5
			location = New Global.System.Drawing.Point(16, 70)
			optCBDataType_7.Location = location
			Me.optCBDataType_5.Name = "optCBDataType_5"
			Me.optCBDataType_5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optCBDataType_5, True)
			Dim optCBDataType_8 As Global.System.Windows.Forms.Control = Me.optCBDataType_5
			size = New Global.System.Drawing.Size(272, 19)
			optCBDataType_8.Size = size
			Me.optCBDataType_5.TabIndex = 15
			Me.optCBDataType_5.TabStop = True
			Me.optCBDataType_5.Text = "Use XBAL information"
			Me.optCBDataType_5.UseVisualStyleBackColor = False
			Me.txtCounterbalance.BackColor = Global.System.Drawing.Color.LightGray
			Me.txtCounterbalance.Enabled = False
			Me.txtCounterbalance.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.txtCounterbalance, "Existing Maximum Counterbalance or Structural Unbalance")
			Me.HelpProvider1.SetHelpNavigator(Me.txtCounterbalance, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtCounterbalance As Global.System.Windows.Forms.Control = Me.txtCounterbalance
			location = New Global.System.Drawing.Point(371, 44)
			txtCounterbalance.Location = location
			Me.txtCounterbalance.Name = "txtCounterbalance"
			Me.HelpProvider1.SetShowHelp(Me.txtCounterbalance, True)
			Dim txtCounterbalance2 As Global.System.Windows.Forms.Control = Me.txtCounterbalance
			size = New Global.System.Drawing.Size(63, 22)
			txtCounterbalance2.Size = size
			Me.txtCounterbalance.TabIndex = 10
			Me.txtCounterbalance.Tag = "lee"
			Me.lblManufacturer.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblManufacturer.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblManufacturer.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblManufacturer.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblManufacturer.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblManufacturer As Global.System.Windows.Forms.Control = Me.lblManufacturer
			location = New Global.System.Drawing.Point(8, 12)
			lblManufacturer.Location = location
			Me.lblManufacturer.Name = "lblManufacturer"
			Me.lblManufacturer.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblManufacturer, False)
			Dim lblManufacturer2 As Global.System.Windows.Forms.Control = Me.lblManufacturer
			size = New Global.System.Drawing.Size(136, 19)
			lblManufacturer2.Size = size
			Me.lblManufacturer.TabIndex = 40
			Me.lblManufacturer.Text = "Manufacturer:"
			Me.lblManufacturer.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.lblCrankRotation.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblCrankRotation.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblCrankRotation.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblCrankRotation.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblCrankRotation.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCrankRotation As Global.System.Windows.Forms.Control = Me.lblCrankRotation
			location = New Global.System.Drawing.Point(544, 136)
			lblCrankRotation.Location = location
			Me.lblCrankRotation.Name = "lblCrankRotation"
			Me.lblCrankRotation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblCrankRotation, False)
			Dim lblCrankRotation2 As Global.System.Windows.Forms.Control = Me.lblCrankRotation
			size = New Global.System.Drawing.Size(200, 19)
			lblCrankRotation2.Size = size
			Me.lblCrankRotation.TabIndex = 41
			Me.lblCrankRotation.Text = "Crank rotation:"
			Me.lblStrokeLength.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblStrokeLength.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblStrokeLength.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblStrokeLength.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblStrokeLength.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblStrokeLength As Global.System.Windows.Forms.Control = Me.lblStrokeLength
			location = New Global.System.Drawing.Point(544, 184)
			lblStrokeLength.Location = location
			Me.lblStrokeLength.Name = "lblStrokeLength"
			Me.lblStrokeLength.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblStrokeLength, False)
			Dim lblStrokeLength2 As Global.System.Windows.Forms.Control = Me.lblStrokeLength
			size = New Global.System.Drawing.Size(200, 19)
			lblStrokeLength2.Size = size
			Me.lblStrokeLength.TabIndex = 43
			Me.lblStrokeLength.Text = "Calculated Stroke Length:"
			Me.cboManufMenu.BackColor = Global.System.Drawing.Color.White
			Me.cboManufMenu.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboManufMenu.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboManufMenu.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboManufMenu.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboManufMenu, "pumping unit manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboManufMenu, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboManufMenu.ItemHeight = 16
			Dim cboManufMenu As Global.System.Windows.Forms.Control = Me.cboManufMenu
			location = New Global.System.Drawing.Point(144, 8)
			cboManufMenu.Location = location
			Me.cboManufMenu.Name = "cboManufMenu"
			Me.cboManufMenu.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboManufMenu, True)
			Dim cboManufMenu2 As Global.System.Windows.Forms.Control = Me.cboManufMenu
			size = New Global.System.Drawing.Size(384, 24)
			cboManufMenu2.Size = size
			Me.cboManufMenu.TabIndex = 1
			Me.lblCrankHole.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblCrankHole.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblCrankHole.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblCrankHole.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblCrankHole.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCrankHole As Global.System.Windows.Forms.Control = Me.lblCrankHole
			location = New Global.System.Drawing.Point(544, 160)
			lblCrankHole.Location = location
			Me.lblCrankHole.Name = "lblCrankHole"
			Me.lblCrankHole.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblCrankHole, False)
			Dim lblCrankHole2 As Global.System.Windows.Forms.Control = Me.lblCrankHole
			size = New Global.System.Drawing.Size(200, 19)
			lblCrankHole2.Size = size
			Me.lblCrankHole.TabIndex = 42
			Me.lblCrankHole.Text = "Crank hole:"
			Me.chkCustomPUDB.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkCustomPUDB.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkCustomPUDB.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.chkCustomPUDB.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkCustomPUDB.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkCustomPUDB As Global.System.Windows.Forms.Control = Me.chkCustomPUDB
			location = New Global.System.Drawing.Point(544, 64)
			chkCustomPUDB.Location = location
			Me.chkCustomPUDB.Name = "chkCustomPUDB"
			Me.chkCustomPUDB.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkCustomPUDB, False)
			Dim chkCustomPUDB2 As Global.System.Windows.Forms.Control = Me.chkCustomPUDB
			size = New Global.System.Drawing.Size(344, 27)
			chkCustomPUDB2.Size = size
			Me.chkCustomPUDB.TabIndex = 4
			Me.chkCustomPUDB.Text = "Use custom pumping unit list"
			Me.chkCustomPUDB.UseVisualStyleBackColor = False
			Me.Label5.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me.Label5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.Label5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label5
			location = New Global.System.Drawing.Point(544, 128)
			label.Location = location
			Me.Label5.Name = "Label5"
			Me.HelpProvider1.SetShowHelp(Me.Label5, False)
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(344, 1)
			label2.Size = size
			Me.Label5.TabIndex = 48
			Me.txtUnitID.AcceptsReturn = True
			Me.txtUnitID.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtUnitID.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtUnitID.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtUnitID.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtUnitID, "Pumping unit ID")
			Me.HelpProvider1.SetHelpNavigator(Me.txtUnitID, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtUnitID As Global.System.Windows.Forms.Control = Me.txtUnitID
			location = New Global.System.Drawing.Point(752, 8)
			txtUnitID.Location = location
			Me.txtUnitID.MaxLength = 10
			Me.txtUnitID.Name = "txtUnitID"
			Me.txtUnitID.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtUnitID, True)
			Dim txtUnitID2 As Global.System.Windows.Forms.Control = Me.txtUnitID
			size = New Global.System.Drawing.Size(104, 22)
			txtUnitID2.Size = size
			Me.txtUnitID.TabIndex = 2
			Me.lblUnitID.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblUnitID.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblUnitID As Global.System.Windows.Forms.Control = Me.lblUnitID
			location = New Global.System.Drawing.Point(544, 8)
			lblUnitID.Location = location
			Me.lblUnitID.Name = "lblUnitID"
			Me.HelpProvider1.SetShowHelp(Me.lblUnitID, False)
			Dim lblUnitID2 As Global.System.Windows.Forms.Control = Me.lblUnitID
			size = New Global.System.Drawing.Size(200, 16)
			lblUnitID2.Size = size
			Me.lblUnitID.TabIndex = 52
			Me.lblUnitID.Text = "Unit ID:"
			Me.lblAPI.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblAPI.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblAPI As Global.System.Windows.Forms.Control = Me.lblAPI
			location = New Global.System.Drawing.Point(544, 35)
			lblAPI.Location = location
			Me.lblAPI.Name = "lblAPI"
			Me.HelpProvider1.SetShowHelp(Me.lblAPI, False)
			Dim lblAPI2 As Global.System.Windows.Forms.Control = Me.lblAPI
			size = New Global.System.Drawing.Size(344, 19)
			lblAPI2.Size = size
			Me.lblAPI.TabIndex = 55
			Me.txtUnbalance.AcceptsReturn = True
			Me.txtUnbalance.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtUnbalance.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtUnbalance.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtUnbalance.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtUnbalance, "structural unbalance")
			Me.HelpProvider1.SetHelpNavigator(Me.txtUnbalance, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtUnbalance As Global.System.Windows.Forms.Control = Me.txtUnbalance
			location = New Global.System.Drawing.Point(752, 214)
			txtUnbalance.Location = location
			Me.txtUnbalance.MaxLength = 10
			Me.txtUnbalance.Name = "txtUnbalance"
			Me.txtUnbalance.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtUnbalance, True)
			Dim txtUnbalance2 As Global.System.Windows.Forms.Control = Me.txtUnbalance
			size = New Global.System.Drawing.Size(64, 22)
			txtUnbalance2.Size = size
			Me.txtUnbalance.TabIndex = 7
			Me.txtUnbalance.Tag = "lee"
			Me.cboCrankHole.BackColor = Global.System.Drawing.Color.White
			Me.cboCrankHole.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboCrankHole.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboCrankHole.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboCrankHole.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboCrankHole, "crank hole number")
			Me.HelpProvider1.SetHelpNavigator(Me.cboCrankHole, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboCrankHole.ItemHeight = 16
			Dim cboCrankHole As Global.System.Windows.Forms.Control = Me.cboCrankHole
			location = New Global.System.Drawing.Point(752, 160)
			cboCrankHole.Location = location
			Me.cboCrankHole.Name = "cboCrankHole"
			Me.cboCrankHole.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboCrankHole, True)
			Dim cboCrankHole2 As Global.System.Windows.Forms.Control = Me.cboCrankHole
			size = New Global.System.Drawing.Size(128, 24)
			cboCrankHole2.Size = size
			Me.cboCrankHole.TabIndex = 6
			Me.pnlHydraulic.Controls.Add(Me.lblAdjustedStrokeLength)
			Me.pnlHydraulic.Controls.Add(Me.txtAdjustedStrokeLength)
			Me.pnlHydraulic.Controls.Add(Me.lblPercentDownstrokeSPM)
			Me.pnlHydraulic.Controls.Add(Me.txtPercentDownstrokeSPM)
			Me.pnlHydraulic.Controls.Add(Me.lblPercentUpstrokeSPM)
			Me.pnlHydraulic.Controls.Add(Me.txtPercentUpstrokeSPM)
			Dim pnlHydraulic As Global.System.Windows.Forms.Control = Me.pnlHydraulic
			location = New Global.System.Drawing.Point(536, 240)
			pnlHydraulic.Location = location
			Me.pnlHydraulic.Name = "pnlHydraulic"
			Me.HelpProvider1.SetShowHelp(Me.pnlHydraulic, False)
			Dim pnlHydraulic2 As Global.System.Windows.Forms.Control = Me.pnlHydraulic
			size = New Global.System.Drawing.Size(352, 112)
			pnlHydraulic2.Size = size
			Me.pnlHydraulic.TabIndex = 63
			Me.pnlHydraulic.Visible = False
			Me.lblAdjustedStrokeLength.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblAdjustedStrokeLength.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblAdjustedStrokeLength.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblAdjustedStrokeLength.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblAdjustedStrokeLength.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblAdjustedStrokeLength As Global.System.Windows.Forms.Control = Me.lblAdjustedStrokeLength
			location = New Global.System.Drawing.Point(8, 8)
			lblAdjustedStrokeLength.Location = location
			Me.lblAdjustedStrokeLength.Name = "lblAdjustedStrokeLength"
			Me.lblAdjustedStrokeLength.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblAdjustedStrokeLength, False)
			Dim lblAdjustedStrokeLength2 As Global.System.Windows.Forms.Control = Me.lblAdjustedStrokeLength
			size = New Global.System.Drawing.Size(184, 19)
			lblAdjustedStrokeLength2.Size = size
			Me.lblAdjustedStrokeLength.TabIndex = 62
			Me.lblAdjustedStrokeLength.Tag = "Adjusted Stroke Length (^):"
			Me.lblAdjustedStrokeLength.Text = "Adjusted Stroke Length (in):"
			Me.txtAdjustedStrokeLength.AcceptsReturn = True
			Me.txtAdjustedStrokeLength.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtAdjustedStrokeLength.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtAdjustedStrokeLength.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtAdjustedStrokeLength.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtAdjustedStrokeLength, "Adjusted Stroke Length")
			Me.HelpProvider1.SetHelpNavigator(Me.txtAdjustedStrokeLength, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtAdjustedStrokeLength As Global.System.Windows.Forms.Control = Me.txtAdjustedStrokeLength
			location = New Global.System.Drawing.Point(216, 8)
			txtAdjustedStrokeLength.Location = location
			Me.txtAdjustedStrokeLength.MaxLength = 10
			Me.txtAdjustedStrokeLength.Name = "txtAdjustedStrokeLength"
			Me.txtAdjustedStrokeLength.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtAdjustedStrokeLength, True)
			Dim txtAdjustedStrokeLength2 As Global.System.Windows.Forms.Control = Me.txtAdjustedStrokeLength
			size = New Global.System.Drawing.Size(64, 22)
			txtAdjustedStrokeLength2.Size = size
			Me.txtAdjustedStrokeLength.TabIndex = 61
			Me.txtAdjustedStrokeLength.Tag = "cee"
			Me.lblPercentDownstrokeSPM.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblPercentDownstrokeSPM.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblPercentDownstrokeSPM.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblPercentDownstrokeSPM.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblPercentDownstrokeSPM.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblPercentDownstrokeSPM As Global.System.Windows.Forms.Control = Me.lblPercentDownstrokeSPM
			location = New Global.System.Drawing.Point(8, 56)
			lblPercentDownstrokeSPM.Location = location
			Me.lblPercentDownstrokeSPM.Name = "lblPercentDownstrokeSPM"
			Me.lblPercentDownstrokeSPM.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblPercentDownstrokeSPM, False)
			Dim lblPercentDownstrokeSPM2 As Global.System.Windows.Forms.Control = Me.lblPercentDownstrokeSPM
			size = New Global.System.Drawing.Size(200, 19)
			lblPercentDownstrokeSPM2.Size = size
			Me.lblPercentDownstrokeSPM.TabIndex = 58
			Me.lblPercentDownstrokeSPM.Text = "Percent Downstroke SPM (%):"
			Me.lblPercentDownstrokeSPM.Visible = False
			Me.txtPercentDownstrokeSPM.AcceptsReturn = True
			Me.txtPercentDownstrokeSPM.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPercentDownstrokeSPM.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPercentDownstrokeSPM.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtPercentDownstrokeSPM.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtPercentDownstrokeSPM, "structural unbalance")
			Me.HelpProvider1.SetHelpNavigator(Me.txtPercentDownstrokeSPM, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtPercentDownstrokeSPM As Global.System.Windows.Forms.Control = Me.txtPercentDownstrokeSPM
			location = New Global.System.Drawing.Point(216, 56)
			txtPercentDownstrokeSPM.Location = location
			Me.txtPercentDownstrokeSPM.MaxLength = 10
			Me.txtPercentDownstrokeSPM.Name = "txtPercentDownstrokeSPM"
			Me.txtPercentDownstrokeSPM.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtPercentDownstrokeSPM, True)
			Dim txtPercentDownstrokeSPM2 As Global.System.Windows.Forms.Control = Me.txtPercentDownstrokeSPM
			size = New Global.System.Drawing.Size(64, 22)
			txtPercentDownstrokeSPM2.Size = size
			Me.txtPercentDownstrokeSPM.TabIndex = 57
			Me.txtPercentDownstrokeSPM.Tag = "lee"
			Me.txtPercentDownstrokeSPM.Visible = False
			Me.lblPercentUpstrokeSPM.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblPercentUpstrokeSPM.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblPercentUpstrokeSPM.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblPercentUpstrokeSPM.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblPercentUpstrokeSPM.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblPercentUpstrokeSPM As Global.System.Windows.Forms.Control = Me.lblPercentUpstrokeSPM
			location = New Global.System.Drawing.Point(8, 32)
			lblPercentUpstrokeSPM.Location = location
			Me.lblPercentUpstrokeSPM.Name = "lblPercentUpstrokeSPM"
			Me.lblPercentUpstrokeSPM.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblPercentUpstrokeSPM, False)
			Dim lblPercentUpstrokeSPM2 As Global.System.Windows.Forms.Control = Me.lblPercentUpstrokeSPM
			size = New Global.System.Drawing.Size(184, 19)
			lblPercentUpstrokeSPM2.Size = size
			Me.lblPercentUpstrokeSPM.TabIndex = 56
			Me.lblPercentUpstrokeSPM.Text = "Percent Upstroke SPM (%):"
			Me.lblPercentUpstrokeSPM.Visible = False
			Me.txtPercentUpstrokeSPM.AcceptsReturn = True
			Me.txtPercentUpstrokeSPM.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPercentUpstrokeSPM.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPercentUpstrokeSPM.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtPercentUpstrokeSPM.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtPercentUpstrokeSPM, "structural unbalance")
			Me.HelpProvider1.SetHelpNavigator(Me.txtPercentUpstrokeSPM, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtPercentUpstrokeSPM As Global.System.Windows.Forms.Control = Me.txtPercentUpstrokeSPM
			location = New Global.System.Drawing.Point(216, 32)
			txtPercentUpstrokeSPM.Location = location
			Me.txtPercentUpstrokeSPM.MaxLength = 10
			Me.txtPercentUpstrokeSPM.Name = "txtPercentUpstrokeSPM"
			Me.txtPercentUpstrokeSPM.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtPercentUpstrokeSPM, True)
			Dim txtPercentUpstrokeSPM2 As Global.System.Windows.Forms.Control = Me.txtPercentUpstrokeSPM
			size = New Global.System.Drawing.Size(64, 22)
			txtPercentUpstrokeSPM2.Size = size
			Me.txtPercentUpstrokeSPM.TabIndex = 55
			Me.txtPercentUpstrokeSPM.Tag = "lee"
			Me.txtPercentUpstrokeSPM.Visible = False
			Me.pnlCombinationBeamCrank.Controls.Add(Me.optUseCrankBalancedCalcs)
			Me.pnlCombinationBeamCrank.Controls.Add(Me.optUseBeamBalancedCalcs)
			Dim pnlCombinationBeamCrank As Global.System.Windows.Forms.Control = Me.pnlCombinationBeamCrank
			location = New Global.System.Drawing.Point(536, 248)
			pnlCombinationBeamCrank.Location = location
			Me.pnlCombinationBeamCrank.Name = "pnlCombinationBeamCrank"
			Me.HelpProvider1.SetShowHelp(Me.pnlCombinationBeamCrank, False)
			Dim pnlCombinationBeamCrank2 As Global.System.Windows.Forms.Control = Me.pnlCombinationBeamCrank
			size = New Global.System.Drawing.Size(344, 60)
			pnlCombinationBeamCrank2.Size = size
			Me.pnlCombinationBeamCrank.TabIndex = 64
			Me.pnlCombinationBeamCrank.Visible = False
			Me.optUseCrankBalancedCalcs.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optUseCrankBalancedCalcs.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optUseCrankBalancedCalcs.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.optUseCrankBalancedCalcs.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.optUseCrankBalancedCalcs.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optUseCrankBalancedCalcs As Global.System.Windows.Forms.Control = Me.optUseCrankBalancedCalcs
			location = New Global.System.Drawing.Point(14, 34)
			optUseCrankBalancedCalcs.Location = location
			Me.optUseCrankBalancedCalcs.Name = "optUseCrankBalancedCalcs"
			Me.optUseCrankBalancedCalcs.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optUseCrankBalancedCalcs, False)
			Dim optUseCrankBalancedCalcs2 As Global.System.Windows.Forms.Control = Me.optUseCrankBalancedCalcs
			size = New Global.System.Drawing.Size(320, 19)
			optUseCrankBalancedCalcs2.Size = size
			Me.optUseCrankBalancedCalcs.TabIndex = 19
			Me.optUseCrankBalancedCalcs.TabStop = True
			Me.optUseCrankBalancedCalcs.Text = "Use Crank Balanced Calculations"
			Me.optUseCrankBalancedCalcs.UseVisualStyleBackColor = False
			Me.optUseCrankBalancedCalcs.Visible = False
			Me.optUseBeamBalancedCalcs.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optUseBeamBalancedCalcs.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optUseBeamBalancedCalcs.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.optUseBeamBalancedCalcs.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.optUseBeamBalancedCalcs.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optUseBeamBalancedCalcs As Global.System.Windows.Forms.Control = Me.optUseBeamBalancedCalcs
			location = New Global.System.Drawing.Point(14, 8)
			optUseBeamBalancedCalcs.Location = location
			Me.optUseBeamBalancedCalcs.Name = "optUseBeamBalancedCalcs"
			Me.optUseBeamBalancedCalcs.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optUseBeamBalancedCalcs, False)
			Dim optUseBeamBalancedCalcs2 As Global.System.Windows.Forms.Control = Me.optUseBeamBalancedCalcs
			size = New Global.System.Drawing.Size(320, 19)
			optUseBeamBalancedCalcs2.Size = size
			Me.optUseBeamBalancedCalcs.TabIndex = 18
			Me.optUseBeamBalancedCalcs.TabStop = True
			Me.optUseBeamBalancedCalcs.Text = "Use Beam Balanced Calculations"
			Me.optUseBeamBalancedCalcs.UseVisualStyleBackColor = False
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(544, 248)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Me.HelpProvider1.SetShowHelp(Me.Panel1, False)
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(344, 104)
			panel2.Size = size
			Me.Panel1.TabIndex = 56
			Me.Panel1.Visible = False
			Me.ToolTip1.ShowAlways = True
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			Me.AutoScroll = True
			size = New Global.System.Drawing.Size(918, 511)
			Me.ClientSize = size
			Me.Controls.Add(Me.pnlPUData)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "PUData"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Pumping Unit Information"
			Me.pnlPUData.ResumeLayout(False)
			Me.pnlPUData.PerformLayout()
			Me.grpCounterBalance.ResumeLayout(False)
			Me.grpCounterBalance.PerformLayout()
			Me.pnlHydraulic.ResumeLayout(False)
			Me.pnlHydraulic.PerformLayout()
			Me.pnlCombinationBeamCrank.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
