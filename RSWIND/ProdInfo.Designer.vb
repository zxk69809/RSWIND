Namespace RSWINV3
	Friend Partial Class ProdInfo
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.ProdInfo))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdDelTestPoint = New Global.System.Windows.Forms.Button()
			Me.cmdAddTestPoint = New Global.System.Windows.Forms.Button()
			Me.picRemoveFocus = New Global.System.Windows.Forms.Panel()
			Me._linSeparator_2 = New Global.System.Windows.Forms.Label()
			Me.pnlIPR = New Global.System.Windows.Forms.Panel()
			Me.chkBelowBPP = New Global.System.Windows.Forms.CheckBox()
			Me.ulgTestPoints = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me.cboTestPointType = New Global.System.Windows.Forms.ComboBox()
			Me.cmdIPRPlot = New Global.System.Windows.Forms.Button()
			Me.cmdCheckIPR = New Global.System.Windows.Forms.Button()
			Me.chkCalculateN = New Global.System.Windows.Forms.CheckBox()
			Me.frmMaxProduction = New Global.System.Windows.Forms.GroupBox()
			Me._Label_Fluid = New Global.System.Windows.Forms.Label()
			Me._Label_Water = New Global.System.Windows.Forms.Label()
			Me._Label_Oil = New Global.System.Windows.Forms.Label()
			Me._lblMaxProduction_2 = New Global.System.Windows.Forms.Label()
			Me._lblMaxProduction_1 = New Global.System.Windows.Forms.Label()
			Me._lblMaxProduction_0 = New Global.System.Windows.Forms.Label()
			Me.cmdUpdateProduction = New Global.System.Windows.Forms.Button()
			Me._Label_PressMeasuredAt = New Global.System.Windows.Forms.Label()
			Me._Label_MidPerfDepth = New Global.System.Windows.Forms.Label()
			Me._Label_StaticBHPressure = New Global.System.Windows.Forms.Label()
			Me._Label_BubblePoint = New Global.System.Windows.Forms.Label()
			Me._Label_ProdTestPoints = New Global.System.Windows.Forms.Label()
			Me._Label_IPRCalcMethod = New Global.System.Windows.Forms.Label()
			Me._Label_FetkovichN = New Global.System.Windows.Forms.Label()
			Me.cboIPRMethod = New Global.System.Windows.Forms.ComboBox()
			Me.txtMidPerfDepth = New Global.System.Windows.Forms.TextBox()
			Me.txtStaticBHPressure = New Global.System.Windows.Forms.TextBox()
			Me.txtBubblePoint = New Global.System.Windows.Forms.TextBox()
			Me.lblBubblePoint_Disabled = New Global.System.Windows.Forms.Label()
			Me.txtFetkovichN = New Global.System.Windows.Forms.TextBox()
			Me.lblFetkovichN_Disabled = New Global.System.Windows.Forms.Label()
			Me.lbl85 = New Global.System.Windows.Forms.Label()
			Me._optSPMBFPD_0 = New Global.System.Windows.Forms.RadioButton()
			Me._optSPMBFPD_1 = New Global.System.Windows.Forms.RadioButton()
			Me._optSPMBFPD_2 = New Global.System.Windows.Forms.RadioButton()
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me._optFLPIP_3 = New Global.System.Windows.Forms.RadioButton()
			Me._optFLPIP_1 = New Global.System.Windows.Forms.RadioButton()
			Me._optFLPIP_2 = New Global.System.Windows.Forms.RadioButton()
			Me._optFLPIP_4 = New Global.System.Windows.Forms.RadioButton()
			Me._Label_3 = New Global.System.Windows.Forms.Label()
			Me._optFLPIP_0 = New Global.System.Windows.Forms.RadioButton()
			Me.txtFLPIP = New Global.System.Windows.Forms.TextBox()
			Me.chkIPRData = New Global.System.Windows.Forms.CheckBox()
			Me._linSeparator_0 = New Global.System.Windows.Forms.Label()
			Me._linSeparator_1 = New Global.System.Windows.Forms.Label()
			Me._linSeparator_3 = New Global.System.Windows.Forms.Label()
			Me.txtSPMBFPD = New Global.System.Windows.Forms.TextBox()
			Me.lblSPMBFPD_Disabled = New Global.System.Windows.Forms.Label()
			Me._Label_SPMBFPD = New Global.System.Windows.Forms.Label()
			Me._optFLPIP_5 = New Global.System.Windows.Forms.RadioButton()
			Me.txtTempPress = New Global.System.Windows.Forms.TextBox()
			Me.txtTempProd = New Global.System.Windows.Forms.TextBox()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.linSeparator = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.optFLPIP = New Global.Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
			Me.optSPMBFPD = New Global.Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.picRemoveFocus.SuspendLayout()
			Me.pnlIPR.SuspendLayout()
			CType(Me.ulgTestPoints, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.frmMaxProduction.SuspendLayout()
			Me._SSPanel_0.SuspendLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linSeparator, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.optFLPIP, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.optSPMBFPD, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.cmdDelTestPoint.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdDelTestPoint.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdDelTestPoint.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cmdDelTestPoint.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdDelTestPoint.Image = CType(componentResourceManager.GetObject("cmdDelTestPoint.Image"), Global.System.Drawing.Image)
			Me.cmdDelTestPoint.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdDelTestPoint As Global.System.Windows.Forms.Control = Me.cmdDelTestPoint
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(739, 202)
			cmdDelTestPoint.Location = location
			Me.cmdDelTestPoint.Name = "cmdDelTestPoint"
			Me.cmdDelTestPoint.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdDelTestPoint, False)
			Dim cmdDelTestPoint2 As Global.System.Windows.Forms.Control = Me.cmdDelTestPoint
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(24, 22)
			cmdDelTestPoint2.Size = size
			Me.cmdDelTestPoint.TabIndex = 220
			Me.cmdDelTestPoint.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdDelTestPoint, "Remove the selected IPR test point")
			Me.cmdDelTestPoint.UseVisualStyleBackColor = False
			Me.cmdAddTestPoint.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdAddTestPoint.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdAddTestPoint.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cmdAddTestPoint.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdAddTestPoint.Image = CType(componentResourceManager.GetObject("cmdAddTestPoint.Image"), Global.System.Drawing.Image)
			Me.cmdAddTestPoint.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdAddTestPoint As Global.System.Windows.Forms.Control = Me.cmdAddTestPoint
			location = New Global.System.Drawing.Point(739, 154)
			cmdAddTestPoint.Location = location
			Me.cmdAddTestPoint.Name = "cmdAddTestPoint"
			Me.cmdAddTestPoint.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdAddTestPoint, False)
			Dim cmdAddTestPoint2 As Global.System.Windows.Forms.Control = Me.cmdAddTestPoint
			size = New Global.System.Drawing.Size(24, 22)
			cmdAddTestPoint2.Size = size
			Me.cmdAddTestPoint.TabIndex = 219
			Me.cmdAddTestPoint.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdAddTestPoint, "Add an IPR test point")
			Me.cmdAddTestPoint.UseVisualStyleBackColor = False
			Me.picRemoveFocus.BackColor = Global.System.Drawing.SystemColors.Control
			Me.picRemoveFocus.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.picRemoveFocus.Controls.Add(Me._linSeparator_2)
			Me.picRemoveFocus.Controls.Add(Me.pnlIPR)
			Me.picRemoveFocus.Controls.Add(Me.lbl85)
			Me.picRemoveFocus.Controls.Add(Me._optSPMBFPD_0)
			Me.picRemoveFocus.Controls.Add(Me._optSPMBFPD_1)
			Me.picRemoveFocus.Controls.Add(Me._optSPMBFPD_2)
			Me.picRemoveFocus.Controls.Add(Me._SSPanel_0)
			Me.picRemoveFocus.Controls.Add(Me.chkIPRData)
			Me.picRemoveFocus.Controls.Add(Me._linSeparator_0)
			Me.picRemoveFocus.Controls.Add(Me._linSeparator_1)
			Me.picRemoveFocus.Controls.Add(Me._linSeparator_3)
			Me.picRemoveFocus.Controls.Add(Me.txtSPMBFPD)
			Me.picRemoveFocus.Controls.Add(Me.lblSPMBFPD_Disabled)
			Me.picRemoveFocus.Controls.Add(Me._Label_SPMBFPD)
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
			size = New Global.System.Drawing.Size(805, 472)
			picRemoveFocus2.Size = size
			Me.picRemoveFocus.TabIndex = 22
			Me._linSeparator_2.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._linSeparator_2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim linSeparator_ As Global.System.Windows.Forms.Control = Me._linSeparator_2
			location = New Global.System.Drawing.Point(8, 145)
			linSeparator_.Location = location
			Me._linSeparator_2.Name = "_linSeparator_2"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_2, False)
			Dim linSeparator_2 As Global.System.Windows.Forms.Control = Me._linSeparator_2
			size = New Global.System.Drawing.Size(792, 1)
			linSeparator_2.Size = size
			Me._linSeparator_2.TabIndex = 235
			Me._linSeparator_2.Tag = "n"
			Me.pnlIPR.Controls.Add(Me.chkBelowBPP)
			Me.pnlIPR.Controls.Add(Me.ulgTestPoints)
			Me.pnlIPR.Controls.Add(Me.cmdDelTestPoint)
			Me.pnlIPR.Controls.Add(Me.cmdAddTestPoint)
			Me.pnlIPR.Controls.Add(Me.cboTestPointType)
			Me.pnlIPR.Controls.Add(Me.cmdIPRPlot)
			Me.pnlIPR.Controls.Add(Me.cmdCheckIPR)
			Me.pnlIPR.Controls.Add(Me.chkCalculateN)
			Me.pnlIPR.Controls.Add(Me.frmMaxProduction)
			Me.pnlIPR.Controls.Add(Me.cmdUpdateProduction)
			Me.pnlIPR.Controls.Add(Me._Label_PressMeasuredAt)
			Me.pnlIPR.Controls.Add(Me._Label_MidPerfDepth)
			Me.pnlIPR.Controls.Add(Me._Label_StaticBHPressure)
			Me.pnlIPR.Controls.Add(Me._Label_BubblePoint)
			Me.pnlIPR.Controls.Add(Me._Label_ProdTestPoints)
			Me.pnlIPR.Controls.Add(Me._Label_IPRCalcMethod)
			Me.pnlIPR.Controls.Add(Me._Label_FetkovichN)
			Me.pnlIPR.Controls.Add(Me.cboIPRMethod)
			Me.pnlIPR.Controls.Add(Me.txtMidPerfDepth)
			Me.pnlIPR.Controls.Add(Me.txtStaticBHPressure)
			Me.pnlIPR.Controls.Add(Me.txtBubblePoint)
			Me.pnlIPR.Controls.Add(Me.lblBubblePoint_Disabled)
			Me.pnlIPR.Controls.Add(Me.txtFetkovichN)
			Me.pnlIPR.Controls.Add(Me.lblFetkovichN_Disabled)
			Dim pnlIPR As Global.System.Windows.Forms.Control = Me.pnlIPR
			location = New Global.System.Drawing.Point(10, 147)
			pnlIPR.Location = location
			Me.pnlIPR.Name = "pnlIPR"
			Dim pnlIPR2 As Global.System.Windows.Forms.Control = Me.pnlIPR
			size = New Global.System.Drawing.Size(790, 320)
			pnlIPR2.Size = size
			Me.pnlIPR.TabIndex = 212
			Me.chkBelowBPP.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkBelowBPP.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkBelowBPP As Global.System.Windows.Forms.Control = Me.chkBelowBPP
			location = New Global.System.Drawing.Point(427, 114)
			chkBelowBPP.Location = location
			Me.chkBelowBPP.Name = "chkBelowBPP"
			Me.HelpProvider1.SetShowHelp(Me.chkBelowBPP, False)
			Dim chkBelowBPP2 As Global.System.Windows.Forms.Control = Me.chkBelowBPP
			size = New Global.System.Drawing.Size(304, 24)
			chkBelowBPP2.Size = size
			Me.chkBelowBPP.TabIndex = 216
			Me.chkBelowBPP.Tag = "Producing below bubble  point"
			Me.chkBelowBPP.Text = "Producing below bubble  point"
			Me.ulgTestPoints.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.ulgTestPoints, "pressure test points")
			Me.HelpProvider1.SetHelpNavigator(Me.ulgTestPoints, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim ulgTestPoints As Global.System.Windows.Forms.Control = Me.ulgTestPoints
			location = New Global.System.Drawing.Point(347, 154)
			ulgTestPoints.Location = location
			Me.ulgTestPoints.Name = "ulgTestPoints"
			Me.HelpProvider1.SetShowHelp(Me.ulgTestPoints, True)
			Dim ulgTestPoints2 As Global.System.Windows.Forms.Control = Me.ulgTestPoints
			size = New Global.System.Drawing.Size(384, 152)
			ulgTestPoints2.Size = size
			Me.ulgTestPoints.TabIndex = 218
			Me.cboTestPointType.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboTestPointType.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboTestPointType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboTestPointType.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboTestPointType.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboTestPointType, "Pressure measured at:")
			Me.HelpProvider1.SetHelpNavigator(Me.cboTestPointType, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboTestPointType.ItemHeight = 16
			Me.cboTestPointType.Items.AddRange(New Object() { "Flowing wellbore", "Pump intake" })
			Dim cboTestPointType As Global.System.Windows.Forms.Control = Me.cboTestPointType
			location = New Global.System.Drawing.Point(75, 226)
			cboTestPointType.Location = location
			Me.cboTestPointType.Name = "cboTestPointType"
			Me.cboTestPointType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboTestPointType, True)
			Dim cboTestPointType2 As Global.System.Windows.Forms.Control = Me.cboTestPointType
			size = New Global.System.Drawing.Size(248, 24)
			cboTestPointType2.Size = size
			Me.cboTestPointType.TabIndex = 217
			Me.cmdIPRPlot.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdIPRPlot.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdIPRPlot.Enabled = False
			Me.cmdIPRPlot.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cmdIPRPlot.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdIPRPlot.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdIPRPlot As Global.System.Windows.Forms.Control = Me.cmdIPRPlot
			location = New Global.System.Drawing.Point(611, 10)
			cmdIPRPlot.Location = location
			Me.cmdIPRPlot.Name = "cmdIPRPlot"
			Me.cmdIPRPlot.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdIPRPlot, False)
			Dim cmdIPRPlot2 As Global.System.Windows.Forms.Control = Me.cmdIPRPlot
			size = New Global.System.Drawing.Size(104, 21)
			cmdIPRPlot2.Size = size
			Me.cmdIPRPlot.TabIndex = 221
			Me.cmdIPRPlot.TabStop = False
			Me.cmdIPRPlot.Text = "IPR &Plot.."
			Me.cmdIPRPlot.UseVisualStyleBackColor = False
			Me.cmdCheckIPR.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCheckIPR.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCheckIPR.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cmdCheckIPR.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCheckIPR.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCheckIPR As Global.System.Windows.Forms.Control = Me.cmdCheckIPR
			location = New Global.System.Drawing.Point(67, 186)
			cmdCheckIPR.Location = location
			Me.cmdCheckIPR.Name = "cmdCheckIPR"
			Me.cmdCheckIPR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdCheckIPR, False)
			Dim cmdCheckIPR2 As Global.System.Windows.Forms.Control = Me.cmdCheckIPR
			size = New Global.System.Drawing.Size(256, 21)
			cmdCheckIPR2.Size = size
			Me.cmdCheckIPR.TabIndex = 223
			Me.cmdCheckIPR.TabStop = False
			Me.cmdCheckIPR.Text = "Check IPR (hidden)"
			Me.cmdCheckIPR.UseVisualStyleBackColor = False
			Me.cmdCheckIPR.Visible = False
			Me.chkCalculateN.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkCalculateN.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkCalculateN.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkCalculateN.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkCalculateN.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkCalculateN As Global.System.Windows.Forms.Control = Me.chkCalculateN
			location = New Global.System.Drawing.Point(427, 42)
			chkCalculateN.Location = location
			Me.chkCalculateN.Name = "chkCalculateN"
			Me.chkCalculateN.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkCalculateN, False)
			Dim chkCalculateN2 As Global.System.Windows.Forms.Control = Me.chkCalculateN
			size = New Global.System.Drawing.Size(136, 23)
			chkCalculateN2.Size = size
			Me.chkCalculateN.TabIndex = 212
			Me.chkCalculateN.TabStop = False
			Me.chkCalculateN.Text = "Calculate 'n'"
			Me.chkCalculateN.UseVisualStyleBackColor = False
			Me.frmMaxProduction.BackColor = Global.System.Drawing.SystemColors.Control
			Me.frmMaxProduction.Controls.Add(Me._Label_Fluid)
			Me.frmMaxProduction.Controls.Add(Me._Label_Water)
			Me.frmMaxProduction.Controls.Add(Me._Label_Oil)
			Me.frmMaxProduction.Controls.Add(Me._lblMaxProduction_2)
			Me.frmMaxProduction.Controls.Add(Me._lblMaxProduction_1)
			Me.frmMaxProduction.Controls.Add(Me._lblMaxProduction_0)
			Me.frmMaxProduction.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.frmMaxProduction.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim frmMaxProduction As Global.System.Windows.Forms.Control = Me.frmMaxProduction
			location = New Global.System.Drawing.Point(467, 66)
			frmMaxProduction.Location = location
			Me.frmMaxProduction.Name = "frmMaxProduction"
			Me.frmMaxProduction.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.frmMaxProduction, False)
			Dim frmMaxProduction2 As Global.System.Windows.Forms.Control = Me.frmMaxProduction
			size = New Global.System.Drawing.Size(264, 48)
			frmMaxProduction2.Size = size
			Me.frmMaxProduction.TabIndex = 230
			Me.frmMaxProduction.TabStop = False
			Me.frmMaxProduction.Tag = "Calc. max. production ^)"
			Me.frmMaxProduction.Text = "Calc. max. production (BPD)"
			Me._Label_Fluid.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_Fluid.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_Fluid.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_Fluid.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_Fluid.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_Fluid As Global.System.Windows.Forms.Control = Me._Label_Fluid
			location = New Global.System.Drawing.Point(192, 17)
			label_Fluid.Location = location
			Me._Label_Fluid.Name = "_Label_Fluid"
			Me._Label_Fluid.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_Fluid, False)
			Dim label_Fluid2 As Global.System.Windows.Forms.Control = Me._Label_Fluid
			size = New Global.System.Drawing.Size(64, 16)
			label_Fluid2.Size = size
			Me._Label_Fluid.TabIndex = 40
			Me._Label_Fluid.Text = "Fluid:"
			Me._Label_Fluid.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me._Label_Water.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_Water.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_Water.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_Water.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_Water.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_Water As Global.System.Windows.Forms.Control = Me._Label_Water
			location = New Global.System.Drawing.Point(112, 17)
			label_Water.Location = location
			Me._Label_Water.Name = "_Label_Water"
			Me._Label_Water.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_Water, False)
			Dim label_Water2 As Global.System.Windows.Forms.Control = Me._Label_Water
			size = New Global.System.Drawing.Size(64, 16)
			label_Water2.Size = size
			Me._Label_Water.TabIndex = 39
			Me._Label_Water.Text = "Water:"
			Me._Label_Water.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me._Label_Oil.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_Oil.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_Oil.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_Oil.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_Oil.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_Oil As Global.System.Windows.Forms.Control = Me._Label_Oil
			location = New Global.System.Drawing.Point(24, 17)
			label_Oil.Location = location
			Me._Label_Oil.Name = "_Label_Oil"
			Me._Label_Oil.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_Oil, False)
			Dim label_Oil2 As Global.System.Windows.Forms.Control = Me._Label_Oil
			size = New Global.System.Drawing.Size(64, 16)
			label_Oil2.Size = size
			Me._Label_Oil.TabIndex = 38
			Me._Label_Oil.Text = "Oil:"
			Me._Label_Oil.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me._lblMaxProduction_2.BackColor = Global.System.Drawing.Color.Transparent
			Me._lblMaxProduction_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._lblMaxProduction_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._lblMaxProduction_2.ForeColor = Global.System.Drawing.Color.Blue
			Me._lblMaxProduction_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblMaxProduction_ As Global.System.Windows.Forms.Control = Me._lblMaxProduction_2
			location = New Global.System.Drawing.Point(192, 32)
			lblMaxProduction_.Location = location
			Me._lblMaxProduction_2.Name = "_lblMaxProduction_2"
			Me._lblMaxProduction_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._lblMaxProduction_2, False)
			Dim lblMaxProduction_2 As Global.System.Windows.Forms.Control = Me._lblMaxProduction_2
			size = New Global.System.Drawing.Size(64, 13)
			lblMaxProduction_2.Size = size
			Me._lblMaxProduction_2.TabIndex = 37
			Me._lblMaxProduction_2.Text = "0"
			Me._lblMaxProduction_2.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me._lblMaxProduction_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._lblMaxProduction_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._lblMaxProduction_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._lblMaxProduction_1.ForeColor = Global.System.Drawing.Color.Blue
			Me._lblMaxProduction_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblMaxProduction_3 As Global.System.Windows.Forms.Control = Me._lblMaxProduction_1
			location = New Global.System.Drawing.Point(112, 32)
			lblMaxProduction_3.Location = location
			Me._lblMaxProduction_1.Name = "_lblMaxProduction_1"
			Me._lblMaxProduction_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._lblMaxProduction_1, False)
			Dim lblMaxProduction_4 As Global.System.Windows.Forms.Control = Me._lblMaxProduction_1
			size = New Global.System.Drawing.Size(64, 13)
			lblMaxProduction_4.Size = size
			Me._lblMaxProduction_1.TabIndex = 36
			Me._lblMaxProduction_1.Text = "0"
			Me._lblMaxProduction_1.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me._lblMaxProduction_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._lblMaxProduction_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._lblMaxProduction_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._lblMaxProduction_0.ForeColor = Global.System.Drawing.Color.Blue
			Me._lblMaxProduction_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblMaxProduction_5 As Global.System.Windows.Forms.Control = Me._lblMaxProduction_0
			location = New Global.System.Drawing.Point(24, 32)
			lblMaxProduction_5.Location = location
			Me._lblMaxProduction_0.Name = "_lblMaxProduction_0"
			Me._lblMaxProduction_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._lblMaxProduction_0, False)
			Dim lblMaxProduction_6 As Global.System.Windows.Forms.Control = Me._lblMaxProduction_0
			size = New Global.System.Drawing.Size(64, 13)
			lblMaxProduction_6.Size = size
			Me._lblMaxProduction_0.TabIndex = 35
			Me._lblMaxProduction_0.Text = "0"
			Me._lblMaxProduction_0.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.cmdUpdateProduction.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdUpdateProduction.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdUpdateProduction.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cmdUpdateProduction.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdUpdateProduction.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdUpdateProduction As Global.System.Windows.Forms.Control = Me.cmdUpdateProduction
			location = New Global.System.Drawing.Point(611, 34)
			cmdUpdateProduction.Location = location
			Me.cmdUpdateProduction.Name = "cmdUpdateProduction"
			Me.cmdUpdateProduction.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdUpdateProduction, False)
			Dim cmdUpdateProduction2 As Global.System.Windows.Forms.Control = Me.cmdUpdateProduction
			size = New Global.System.Drawing.Size(104, 23)
			cmdUpdateProduction2.Size = size
			Me.cmdUpdateProduction.TabIndex = 222
			Me.cmdUpdateProduction.TabStop = False
			Me.cmdUpdateProduction.Text = "Update prod."
			Me.cmdUpdateProduction.UseVisualStyleBackColor = False
			Me._Label_PressMeasuredAt.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_PressMeasuredAt.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_PressMeasuredAt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_PressMeasuredAt.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_PressMeasuredAt.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_PressMeasuredAt As Global.System.Windows.Forms.Control = Me._Label_PressMeasuredAt
			location = New Global.System.Drawing.Point(75, 210)
			label_PressMeasuredAt.Location = location
			Me._Label_PressMeasuredAt.Name = "_Label_PressMeasuredAt"
			Me._Label_PressMeasuredAt.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_PressMeasuredAt, False)
			Dim label_PressMeasuredAt2 As Global.System.Windows.Forms.Control = Me._Label_PressMeasuredAt
			size = New Global.System.Drawing.Size(248, 18)
			label_PressMeasuredAt2.Size = size
			Me._Label_PressMeasuredAt.TabIndex = 231
			Me._Label_PressMeasuredAt.Text = "Pressure measured at:"
			Me._Label_PressMeasuredAt.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me._Label_MidPerfDepth.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_MidPerfDepth.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_MidPerfDepth.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_MidPerfDepth.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_MidPerfDepth.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_MidPerfDepth As Global.System.Windows.Forms.Control = Me._Label_MidPerfDepth
			location = New Global.System.Drawing.Point(27, 66)
			label_MidPerfDepth.Location = location
			Me._Label_MidPerfDepth.Name = "_Label_MidPerfDepth"
			Me._Label_MidPerfDepth.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_MidPerfDepth, False)
			Dim label_MidPerfDepth2 As Global.System.Windows.Forms.Control = Me._Label_MidPerfDepth
			size = New Global.System.Drawing.Size(318, 19)
			label_MidPerfDepth2.Size = size
			Me._Label_MidPerfDepth.TabIndex = 226
			Me._Label_MidPerfDepth.Tag = "Mid-perf. depth (^):"
			Me._Label_MidPerfDepth.Text = "Mid-perf. depth (ft):"
			Me._Label_MidPerfDepth.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_StaticBHPressure.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_StaticBHPressure.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_StaticBHPressure.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_StaticBHPressure.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_StaticBHPressure.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_StaticBHPressure As Global.System.Windows.Forms.Control = Me._Label_StaticBHPressure
			location = New Global.System.Drawing.Point(27, 90)
			label_StaticBHPressure.Location = location
			Me._Label_StaticBHPressure.Name = "_Label_StaticBHPressure"
			Me._Label_StaticBHPressure.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_StaticBHPressure, False)
			Dim label_StaticBHPressure2 As Global.System.Windows.Forms.Control = Me._Label_StaticBHPressure
			size = New Global.System.Drawing.Size(318, 19)
			label_StaticBHPressure2.Size = size
			Me._Label_StaticBHPressure.TabIndex = 227
			Me._Label_StaticBHPressure.Tag = "Static b'hole pressure (^):"
			Me._Label_StaticBHPressure.Text = "Static b'hole pressure (psi):"
			Me._Label_StaticBHPressure.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me._Label_BubblePoint.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_BubblePoint.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_BubblePoint.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_BubblePoint.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_BubblePoint.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_BubblePoint As Global.System.Windows.Forms.Control = Me._Label_BubblePoint
			location = New Global.System.Drawing.Point(27, 114)
			label_BubblePoint.Location = location
			Me._Label_BubblePoint.Name = "_Label_BubblePoint"
			Me._Label_BubblePoint.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_BubblePoint, False)
			Dim label_BubblePoint2 As Global.System.Windows.Forms.Control = Me._Label_BubblePoint
			size = New Global.System.Drawing.Size(318, 19)
			label_BubblePoint2.Size = size
			Me._Label_BubblePoint.TabIndex = 228
			Me._Label_BubblePoint.Tag = "Bubble point pressure (^):"
			Me._Label_BubblePoint.Text = "Bubble point pressure (psi):"
			Me._Label_BubblePoint.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me._Label_ProdTestPoints.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_ProdTestPoints.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_ProdTestPoints.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_ProdTestPoints.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_ProdTestPoints.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_ProdTestPoints As Global.System.Windows.Forms.Control = Me._Label_ProdTestPoints
			location = New Global.System.Drawing.Point(75, 154)
			label_ProdTestPoints.Location = location
			Me._Label_ProdTestPoints.Name = "_Label_ProdTestPoints"
			Me._Label_ProdTestPoints.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_ProdTestPoints, False)
			Dim label_ProdTestPoints2 As Global.System.Windows.Forms.Control = Me._Label_ProdTestPoints
			size = New Global.System.Drawing.Size(248, 19)
			label_ProdTestPoints2.Size = size
			Me._Label_ProdTestPoints.TabIndex = 229
			Me._Label_ProdTestPoints.Text = "Production test points:"
			Me._Label_ProdTestPoints.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me._Label_IPRCalcMethod.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_IPRCalcMethod.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_IPRCalcMethod.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_IPRCalcMethod.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_IPRCalcMethod.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_IPRCalcMethod As Global.System.Windows.Forms.Control = Me._Label_IPRCalcMethod
			location = New Global.System.Drawing.Point(27, 18)
			label_IPRCalcMethod.Location = location
			Me._Label_IPRCalcMethod.Name = "_Label_IPRCalcMethod"
			Me._Label_IPRCalcMethod.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_IPRCalcMethod, False)
			Dim label_IPRCalcMethod2 As Global.System.Windows.Forms.Control = Me._Label_IPRCalcMethod
			size = New Global.System.Drawing.Size(318, 16)
			label_IPRCalcMethod2.Size = size
			Me._Label_IPRCalcMethod.TabIndex = 224
			Me._Label_IPRCalcMethod.Text = "IPR calculation method:"
			Me._Label_IPRCalcMethod.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_FetkovichN.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_FetkovichN.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_FetkovichN.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_FetkovichN.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_FetkovichN.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_FetkovichN As Global.System.Windows.Forms.Control = Me._Label_FetkovichN
			location = New Global.System.Drawing.Point(27, 42)
			label_FetkovichN.Location = location
			Me._Label_FetkovichN.Name = "_Label_FetkovichN"
			Me._Label_FetkovichN.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_FetkovichN, False)
			Dim label_FetkovichN2 As Global.System.Windows.Forms.Control = Me._Label_FetkovichN
			size = New Global.System.Drawing.Size(318, 19)
			label_FetkovichN2.Size = size
			Me._Label_FetkovichN.TabIndex = 225
			Me._Label_FetkovichN.Text = "Value of 'n' (Fetkovich corr.):"
			Me._Label_FetkovichN.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.cboIPRMethod.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboIPRMethod.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboIPRMethod.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboIPRMethod.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboIPRMethod.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboIPRMethod, "IPR calculation method")
			Me.HelpProvider1.SetHelpNavigator(Me.cboIPRMethod, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboIPRMethod.ItemHeight = 16
			Me.cboIPRMethod.Items.AddRange(New Object() { "Fetkovich", "Vogel" })
			Dim cboIPRMethod As Global.System.Windows.Forms.Control = Me.cboIPRMethod
			location = New Global.System.Drawing.Point(347, 15)
			cboIPRMethod.Location = location
			Me.cboIPRMethod.Name = "cboIPRMethod"
			Me.cboIPRMethod.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboIPRMethod, True)
			Dim cboIPRMethod2 As Global.System.Windows.Forms.Control = Me.cboIPRMethod
			size = New Global.System.Drawing.Size(85, 24)
			cboIPRMethod2.Size = size
			Me.cboIPRMethod.TabIndex = 210
			Me.cboIPRMethod.TabStop = False
			Me.txtMidPerfDepth.AcceptsReturn = True
			Me.txtMidPerfDepth.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMidPerfDepth.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMidPerfDepth.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtMidPerfDepth.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMidPerfDepth, "Mid-perf. depth")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMidPerfDepth, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMidPerfDepth As Global.System.Windows.Forms.Control = Me.txtMidPerfDepth
			location = New Global.System.Drawing.Point(347, 66)
			txtMidPerfDepth.Location = location
			Me.txtMidPerfDepth.MaxLength = 40
			Me.txtMidPerfDepth.Name = "txtMidPerfDepth"
			Me.txtMidPerfDepth.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMidPerfDepth, True)
			Dim txtMidPerfDepth2 As Global.System.Windows.Forms.Control = Me.txtMidPerfDepth
			size = New Global.System.Drawing.Size(72, 22)
			txtMidPerfDepth2.Size = size
			Me.txtMidPerfDepth.TabIndex = 213
			Me.txtMidPerfDepth.TabStop = False
			Me.txtMidPerfDepth.Tag = "fem"
			Me.txtStaticBHPressure.AcceptsReturn = True
			Me.txtStaticBHPressure.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtStaticBHPressure.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtStaticBHPressure.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtStaticBHPressure.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtStaticBHPressure, "Static bottom hole pressure")
			Me.HelpProvider1.SetHelpNavigator(Me.txtStaticBHPressure, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtStaticBHPressure As Global.System.Windows.Forms.Control = Me.txtStaticBHPressure
			location = New Global.System.Drawing.Point(347, 90)
			txtStaticBHPressure.Location = location
			Me.txtStaticBHPressure.MaxLength = 40
			Me.txtStaticBHPressure.Name = "txtStaticBHPressure"
			Me.txtStaticBHPressure.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtStaticBHPressure, True)
			Dim txtStaticBHPressure2 As Global.System.Windows.Forms.Control = Me.txtStaticBHPressure
			size = New Global.System.Drawing.Size(72, 22)
			txtStaticBHPressure2.Size = size
			Me.txtStaticBHPressure.TabIndex = 214
			Me.txtStaticBHPressure.TabStop = False
			Me.txtStaticBHPressure.Tag = "pem"
			Me.txtBubblePoint.AcceptsReturn = True
			Me.txtBubblePoint.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtBubblePoint.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtBubblePoint.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtBubblePoint.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtBubblePoint, "bubble point pressure")
			Me.HelpProvider1.SetHelpNavigator(Me.txtBubblePoint, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtBubblePoint As Global.System.Windows.Forms.Control = Me.txtBubblePoint
			location = New Global.System.Drawing.Point(347, 114)
			txtBubblePoint.Location = location
			Me.txtBubblePoint.MaxLength = 40
			Me.txtBubblePoint.Name = "txtBubblePoint"
			Me.txtBubblePoint.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtBubblePoint, True)
			Dim txtBubblePoint2 As Global.System.Windows.Forms.Control = Me.txtBubblePoint
			size = New Global.System.Drawing.Size(72, 22)
			txtBubblePoint2.Size = size
			Me.txtBubblePoint.TabIndex = 215
			Me.txtBubblePoint.TabStop = False
			Me.txtBubblePoint.Tag = "pem"
			Me.lblBubblePoint_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblBubblePoint_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblBubblePoint_Disabled As Global.System.Windows.Forms.Control = Me.lblBubblePoint_Disabled
			location = New Global.System.Drawing.Point(347, 114)
			lblBubblePoint_Disabled.Location = location
			Me.lblBubblePoint_Disabled.Name = "lblBubblePoint_Disabled"
			Dim lblBubblePoint_Disabled2 As Global.System.Windows.Forms.Control = Me.lblBubblePoint_Disabled
			size = New Global.System.Drawing.Size(72, 22)
			lblBubblePoint_Disabled2.Size = size
			Me.lblBubblePoint_Disabled.TabIndex = 233
			Me.txtFetkovichN.AcceptsReturn = True
			Me.txtFetkovichN.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtFetkovichN.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtFetkovichN.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtFetkovichN.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtFetkovichN, "Fetkovich 'n' value")
			Me.HelpProvider1.SetHelpNavigator(Me.txtFetkovichN, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtFetkovichN As Global.System.Windows.Forms.Control = Me.txtFetkovichN
			location = New Global.System.Drawing.Point(347, 42)
			txtFetkovichN.Location = location
			Me.txtFetkovichN.MaxLength = 40
			Me.txtFetkovichN.Name = "txtFetkovichN"
			Me.txtFetkovichN.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtFetkovichN, True)
			Dim txtFetkovichN2 As Global.System.Windows.Forms.Control = Me.txtFetkovichN
			size = New Global.System.Drawing.Size(72, 22)
			txtFetkovichN2.Size = size
			Me.txtFetkovichN.TabIndex = 211
			Me.txtFetkovichN.TabStop = False
			Me.lblFetkovichN_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblFetkovichN_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblFetkovichN_Disabled As Global.System.Windows.Forms.Control = Me.lblFetkovichN_Disabled
			location = New Global.System.Drawing.Point(347, 42)
			lblFetkovichN_Disabled.Location = location
			Me.lblFetkovichN_Disabled.Name = "lblFetkovichN_Disabled"
			Dim lblFetkovichN_Disabled2 As Global.System.Windows.Forms.Control = Me.lblFetkovichN_Disabled
			size = New Global.System.Drawing.Size(72, 22)
			lblFetkovichN_Disabled2.Size = size
			Me.lblFetkovichN_Disabled.TabIndex = 232
			Dim lbl As Global.System.Windows.Forms.Control = Me.lbl85
			location = New Global.System.Drawing.Point(688, 80)
			lbl.Location = location
			Me.lbl85.Name = "lbl85"
			Dim lbl2 As Global.System.Windows.Forms.Control = Me.lbl85
			size = New Global.System.Drawing.Size(104, 19)
			lbl2.Size = size
			Me.lbl85.TabIndex = 211
			Me.lbl85.Text = "(at 85% efficiency) "
			Me.lbl85.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lbl85.Visible = False
			Me._optSPMBFPD_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optSPMBFPD_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optSPMBFPD_0.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._optSPMBFPD_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._optSPMBFPD_0, "pumping speed")
			Me.HelpProvider1.SetHelpNavigator(Me._optSPMBFPD_0, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optSPMBFPD_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optSPMBFPD_ As Global.System.Windows.Forms.Control = Me._optSPMBFPD_0
			location = New Global.System.Drawing.Point(10, 80)
			optSPMBFPD_.Location = location
			Me._optSPMBFPD_0.Name = "_optSPMBFPD_0"
			Me._optSPMBFPD_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optSPMBFPD_0, True)
			Dim optSPMBFPD_2 As Global.System.Windows.Forms.Control = Me._optSPMBFPD_0
			size = New Global.System.Drawing.Size(318, 20)
			optSPMBFPD_2.Size = size
			Me._optSPMBFPD_0.TabIndex = 5
			Me._optSPMBFPD_0.TabStop = True
			Me._optSPMBFPD_0.Text = "Enter pumping speed"
			Me._optSPMBFPD_0.UseVisualStyleBackColor = False
			Me._optSPMBFPD_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optSPMBFPD_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optSPMBFPD_1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._optSPMBFPD_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._optSPMBFPD_1, "pumping speed")
			Me.HelpProvider1.SetHelpNavigator(Me._optSPMBFPD_1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optSPMBFPD_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optSPMBFPD_3 As Global.System.Windows.Forms.Control = Me._optSPMBFPD_1
			location = New Global.System.Drawing.Point(10, 100)
			optSPMBFPD_3.Location = location
			Me._optSPMBFPD_1.Name = "_optSPMBFPD_1"
			Me._optSPMBFPD_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optSPMBFPD_1, True)
			Dim optSPMBFPD_4 As Global.System.Windows.Forms.Control = Me._optSPMBFPD_1
			size = New Global.System.Drawing.Size(558, 20)
			optSPMBFPD_4.Size = size
			Me._optSPMBFPD_1.TabIndex = 6
			Me._optSPMBFPD_1.TabStop = True
			Me._optSPMBFPD_1.Text = "Enter target production"
			Me._optSPMBFPD_1.UseVisualStyleBackColor = False
			Me._optSPMBFPD_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optSPMBFPD_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optSPMBFPD_2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._optSPMBFPD_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._optSPMBFPD_2, "pumping speed")
			Me.HelpProvider1.SetHelpNavigator(Me._optSPMBFPD_2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optSPMBFPD_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optSPMBFPD_5 As Global.System.Windows.Forms.Control = Me._optSPMBFPD_2
			location = New Global.System.Drawing.Point(10, 120)
			optSPMBFPD_5.Location = location
			Me._optSPMBFPD_2.Name = "_optSPMBFPD_2"
			Me._optSPMBFPD_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optSPMBFPD_2, True)
			Dim optSPMBFPD_6 As Global.System.Windows.Forms.Control = Me._optSPMBFPD_2
			size = New Global.System.Drawing.Size(558, 20)
			optSPMBFPD_6.Size = size
			Me._optSPMBFPD_2.TabIndex = 7
			Me._optSPMBFPD_2.TabStop = True
			Me._optSPMBFPD_2.Text = "Calculate production from inflow performance data"
			Me._optSPMBFPD_2.UseVisualStyleBackColor = False
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._SSPanel_0.Controls.Add(Me._optFLPIP_3)
			Me._SSPanel_0.Controls.Add(Me._optFLPIP_1)
			Me._SSPanel_0.Controls.Add(Me._optFLPIP_2)
			Me._SSPanel_0.Controls.Add(Me._optFLPIP_4)
			Me._SSPanel_0.Controls.Add(Me._Label_3)
			Me._SSPanel_0.Controls.Add(Me._optFLPIP_0)
			Me._SSPanel_0.Controls.Add(Me.txtFLPIP)
			Me._SSPanel_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_0.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._SSPanel_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.SSPanel.SetIndex(Me._SSPanel_0, 0S)
			Dim sspanel_ As Global.System.Windows.Forms.Control = Me._SSPanel_0
			location = New Global.System.Drawing.Point(8, 0)
			sspanel_.Location = location
			Me._SSPanel_0.Name = "_SSPanel_0"
			Me._SSPanel_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._SSPanel_0, False)
			Dim sspanel_2 As Global.System.Windows.Forms.Control = Me._SSPanel_0
			size = New Global.System.Drawing.Size(792, 67)
			sspanel_2.Size = size
			Me._SSPanel_0.TabIndex = 41
			Me._optFLPIP_3.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optFLPIP_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optFLPIP_3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._optFLPIP_3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optFLPIP_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.optFLPIP.SetIndex(Me._optFLPIP_3, 3S)
			Dim optFLPIP_ As Global.System.Windows.Forms.Control = Me._optFLPIP_3
			location = New Global.System.Drawing.Point(584, 24)
			optFLPIP_.Location = location
			Me._optFLPIP_3.Name = "_optFLPIP_3"
			Me._optFLPIP_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optFLPIP_3, False)
			Dim optFLPIP_2 As Global.System.Windows.Forms.Control = Me._optFLPIP_3
			size = New Global.System.Drawing.Size(192, 14)
			optFLPIP_2.Size = size
			Me._optFLPIP_3.TabIndex = 25
			Me._optFLPIP_3.Text = "Fluid level fixed"
			Me._optFLPIP_3.UseVisualStyleBackColor = False
			Me._optFLPIP_3.Visible = False
			Me._optFLPIP_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optFLPIP_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optFLPIP_1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._optFLPIP_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._optFLPIP_1, "Fluid level, pump intake pressure")
			Me.HelpProvider1.SetHelpNavigator(Me._optFLPIP_1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optFLPIP_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.optFLPIP.SetIndex(Me._optFLPIP_1, 1S)
			Dim optFLPIP_3 As Global.System.Windows.Forms.Control = Me._optFLPIP_1
			location = New Global.System.Drawing.Point(0, 18)
			optFLPIP_3.Location = location
			Me._optFLPIP_1.Name = "_optFLPIP_1"
			Me._optFLPIP_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optFLPIP_1, True)
			Dim optFLPIP_4 As Global.System.Windows.Forms.Control = Me._optFLPIP_1
			size = New Global.System.Drawing.Size(568, 20)
			optFLPIP_4.Size = size
			Me._optFLPIP_1.TabIndex = 2
			Me._optFLPIP_1.Text = "Enter pump intake pressure"
			Me._optFLPIP_1.UseVisualStyleBackColor = False
			Me._optFLPIP_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optFLPIP_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optFLPIP_2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._optFLPIP_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optFLPIP_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.optFLPIP.SetIndex(Me._optFLPIP_2, 2S)
			Dim optFLPIP_5 As Global.System.Windows.Forms.Control = Me._optFLPIP_2
			location = New Global.System.Drawing.Point(584, 40)
			optFLPIP_5.Location = location
			Me._optFLPIP_2.Name = "_optFLPIP_2"
			Me._optFLPIP_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optFLPIP_2, False)
			Dim optFLPIP_6 As Global.System.Windows.Forms.Control = Me._optFLPIP_2
			size = New Global.System.Drawing.Size(192, 14)
			optFLPIP_6.Size = size
			Me._optFLPIP_2.TabIndex = 24
			Me._optFLPIP_2.Text = "Calc PIP from IPR"
			Me._optFLPIP_2.UseVisualStyleBackColor = False
			Me._optFLPIP_2.Visible = False
			Me._optFLPIP_4.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optFLPIP_4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optFLPIP_4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._optFLPIP_4.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._optFLPIP_4, "Fluid level, pump intake pressure")
			Me.HelpProvider1.SetHelpNavigator(Me._optFLPIP_4, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optFLPIP_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.optFLPIP.SetIndex(Me._optFLPIP_4, 4S)
			Dim optFLPIP_7 As Global.System.Windows.Forms.Control = Me._optFLPIP_4
			location = New Global.System.Drawing.Point(0, 37)
			optFLPIP_7.Location = location
			Me._optFLPIP_4.Name = "_optFLPIP_4"
			Me._optFLPIP_4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optFLPIP_4, True)
			Dim optFLPIP_8 As Global.System.Windows.Forms.Control = Me._optFLPIP_4
			size = New Global.System.Drawing.Size(560, 19)
			optFLPIP_8.Size = size
			Me._optFLPIP_4.TabIndex = 3
			Me._optFLPIP_4.Text = "Calculate pump intake pressure from target production and IPR data"
			Me._optFLPIP_4.UseVisualStyleBackColor = False
			Me._Label_3.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_3.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_3, 3S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_3
			location = New Global.System.Drawing.Point(352, 4)
			label_.Location = location
			Me._Label_3.Name = "_Label_3"
			Me._Label_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_3, False)
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_3
			size = New Global.System.Drawing.Size(248, 15)
			label_2.Size = size
			Me._Label_3.TabIndex = 26
			Me._Label_3.Tag = "Fluid level (^. from surface):"
			Me._Label_3.Text = "Fluid level (ft. from surface):"
			Me._Label_3.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._optFLPIP_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optFLPIP_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optFLPIP_0.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._optFLPIP_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._optFLPIP_0, "Fluid level, pump intake pressure")
			Me.HelpProvider1.SetHelpNavigator(Me._optFLPIP_0, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optFLPIP_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.optFLPIP.SetIndex(Me._optFLPIP_0, 0S)
			Dim optFLPIP_9 As Global.System.Windows.Forms.Control = Me._optFLPIP_0
			location = New Global.System.Drawing.Point(0, 0)
			optFLPIP_9.Location = location
			Me._optFLPIP_0.Name = "_optFLPIP_0"
			Me._optFLPIP_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optFLPIP_0, True)
			Dim optFLPIP_10 As Global.System.Windows.Forms.Control = Me._optFLPIP_0
			size = New Global.System.Drawing.Size(336, 20)
			optFLPIP_10.Size = size
			Me._optFLPIP_0.TabIndex = 1
			Me._optFLPIP_0.TabStop = True
			Me._optFLPIP_0.Text = "Enter fluid level"
			Me._optFLPIP_0.UseVisualStyleBackColor = False
			Me.txtFLPIP.AcceptsReturn = True
			Me.txtFLPIP.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtFLPIP.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtFLPIP.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtFLPIP.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtFLPIP, "Fluid level, pump intake pressure")
			Me.HelpProvider1.SetHelpNavigator(Me.txtFLPIP, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtFLPIP As Global.System.Windows.Forms.Control = Me.txtFLPIP
			location = New Global.System.Drawing.Point(603, 2)
			txtFLPIP.Location = location
			Me.txtFLPIP.MaxLength = 40
			Me.txtFLPIP.Name = "txtFLPIP"
			Me.txtFLPIP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtFLPIP, True)
			Dim txtFLPIP2 As Global.System.Windows.Forms.Control = Me.txtFLPIP
			size = New Global.System.Drawing.Size(72, 22)
			txtFLPIP2.Size = size
			Me.txtFLPIP.TabIndex = 4
			Me.txtFLPIP.Tag = "fem"
			Me.chkIPRData.Appearance = Global.System.Windows.Forms.Appearance.Button
			Me.chkIPRData.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkIPRData.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkIPRData.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkIPRData.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkIPRData.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkIPRData As Global.System.Windows.Forms.Control = Me.chkIPRData
			location = New Global.System.Drawing.Point(600, 120)
			chkIPRData.Location = location
			Me.chkIPRData.Name = "chkIPRData"
			Me.chkIPRData.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkIPRData, False)
			Dim chkIPRData2 As Global.System.Windows.Forms.Control = Me.chkIPRData
			size = New Global.System.Drawing.Size(104, 21)
			chkIPRData2.Size = size
			Me.chkIPRData.TabIndex = 9
			Me.chkIPRData.TabStop = False
			Me.chkIPRData.Text = "&IPR Data"
			Me.chkIPRData.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.chkIPRData.UseVisualStyleBackColor = False
			Me._linSeparator_0.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._linSeparator_0.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.linSeparator.SetIndex(Me._linSeparator_0, 0S)
			Dim linSeparator_3 As Global.System.Windows.Forms.Control = Me._linSeparator_0
			location = New Global.System.Drawing.Point(8, 72)
			linSeparator_3.Location = location
			Me._linSeparator_0.Name = "_linSeparator_0"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_0, False)
			Dim linSeparator_4 As Global.System.Windows.Forms.Control = Me._linSeparator_0
			size = New Global.System.Drawing.Size(792, 1)
			linSeparator_4.Size = size
			Me._linSeparator_0.TabIndex = 43
			Me._linSeparator_1.BackColor = Global.System.Drawing.Color.White
			Me._linSeparator_1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.linSeparator.SetIndex(Me._linSeparator_1, 1S)
			Dim linSeparator_5 As Global.System.Windows.Forms.Control = Me._linSeparator_1
			location = New Global.System.Drawing.Point(8, 72)
			linSeparator_5.Location = location
			Me._linSeparator_1.Name = "_linSeparator_1"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_1, False)
			Dim linSeparator_6 As Global.System.Windows.Forms.Control = Me._linSeparator_1
			size = New Global.System.Drawing.Size(475, 1)
			linSeparator_6.Size = size
			Me._linSeparator_1.TabIndex = 44
			Me._linSeparator_3.BackColor = Global.System.Drawing.Color.White
			Me._linSeparator_3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.linSeparator.SetIndex(Me._linSeparator_3, 3S)
			Dim linSeparator_7 As Global.System.Windows.Forms.Control = Me._linSeparator_3
			location = New Global.System.Drawing.Point(16, 152)
			linSeparator_7.Location = location
			Me._linSeparator_3.Name = "_linSeparator_3"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_3, False)
			Dim linSeparator_8 As Global.System.Windows.Forms.Control = Me._linSeparator_3
			size = New Global.System.Drawing.Size(475, 1)
			linSeparator_8.Size = size
			Me._linSeparator_3.TabIndex = 46
			Me._linSeparator_3.Tag = "n"
			Me.txtSPMBFPD.AcceptsReturn = True
			Me.txtSPMBFPD.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtSPMBFPD.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtSPMBFPD.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtSPMBFPD.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtSPMBFPD, "pumping speed")
			Me.HelpProvider1.SetHelpNavigator(Me.txtSPMBFPD, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtSPMBFPD As Global.System.Windows.Forms.Control = Me.txtSPMBFPD
			location = New Global.System.Drawing.Point(611, 80)
			txtSPMBFPD.Location = location
			Me.txtSPMBFPD.MaxLength = 40
			Me.txtSPMBFPD.Name = "txtSPMBFPD"
			Me.txtSPMBFPD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtSPMBFPD, True)
			Dim txtSPMBFPD2 As Global.System.Windows.Forms.Control = Me.txtSPMBFPD
			size = New Global.System.Drawing.Size(72, 22)
			txtSPMBFPD2.Size = size
			Me.txtSPMBFPD.TabIndex = 8
			Me.lblSPMBFPD_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblSPMBFPD_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblSPMBFPD_Disabled As Global.System.Windows.Forms.Control = Me.lblSPMBFPD_Disabled
			location = New Global.System.Drawing.Point(611, 80)
			lblSPMBFPD_Disabled.Location = location
			Me.lblSPMBFPD_Disabled.Name = "lblSPMBFPD_Disabled"
			Dim lblSPMBFPD_Disabled2 As Global.System.Windows.Forms.Control = Me.lblSPMBFPD_Disabled
			size = New Global.System.Drawing.Size(72, 20)
			lblSPMBFPD_Disabled2.Size = size
			Me.lblSPMBFPD_Disabled.TabIndex = 210
			Me._Label_SPMBFPD.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_SPMBFPD.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_SPMBFPD.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_SPMBFPD.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_SPMBFPD.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_SPMBFPD, 7S)
			Dim label_SPMBFPD As Global.System.Windows.Forms.Control = Me._Label_SPMBFPD
			location = New Global.System.Drawing.Point(344, 80)
			label_SPMBFPD.Location = location
			Me._Label_SPMBFPD.Name = "_Label_SPMBFPD"
			Me._Label_SPMBFPD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_SPMBFPD, False)
			Dim label_SPMBFPD2 As Global.System.Windows.Forms.Control = Me._Label_SPMBFPD
			size = New Global.System.Drawing.Size(264, 19)
			label_SPMBFPD2.Size = size
			Me._Label_SPMBFPD.TabIndex = 27
			Me._Label_SPMBFPD.Text = "Pumping speed (spm):"
			Me._Label_SPMBFPD.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._optFLPIP_5.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optFLPIP_5.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optFLPIP_5.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optFLPIP_5.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optFLPIP_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optFLPIP_11 As Global.System.Windows.Forms.Control = Me._optFLPIP_5
			location = New Global.System.Drawing.Point(944, 104)
			optFLPIP_11.Location = location
			Me._optFLPIP_5.Name = "_optFLPIP_5"
			Me._optFLPIP_5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optFLPIP_5, False)
			Dim optFLPIP_12 As Global.System.Windows.Forms.Control = Me._optFLPIP_5
			size = New Global.System.Drawing.Size(272, 20)
			optFLPIP_12.Size = size
			Me._optFLPIP_5.TabIndex = 49
			Me._optFLPIP_5.TabStop = True
			Me._optFLPIP_5.Text = "Calculate production from inflow performance data"
			Me._optFLPIP_5.UseVisualStyleBackColor = False
			Me._optFLPIP_5.Visible = False
			Me.txtTempPress.AcceptsReturn = True
			Me.txtTempPress.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtTempPress.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtTempPress.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtTempPress.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtTempPress, "Static bottom hole pressure")
			Me.HelpProvider1.SetHelpNavigator(Me.txtTempPress, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtTempPress As Global.System.Windows.Forms.Control = Me.txtTempPress
			location = New Global.System.Drawing.Point(24, 504)
			txtTempPress.Location = location
			Me.txtTempPress.MaxLength = 40
			Me.txtTempPress.Name = "txtTempPress"
			Me.txtTempPress.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtTempPress, True)
			Dim txtTempPress2 As Global.System.Windows.Forms.Control = Me.txtTempPress
			size = New Global.System.Drawing.Size(72, 22)
			txtTempPress2.Size = size
			Me.txtTempPress.TabIndex = 50
			Me.txtTempPress.TabStop = False
			Me.txtTempPress.Tag = "pem"
			Me.txtTempPress.Visible = False
			Me.txtTempProd.AcceptsReturn = True
			Me.txtTempProd.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtTempProd.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtTempProd.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtTempProd.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtTempProd, "pumping speed")
			Me.HelpProvider1.SetHelpNavigator(Me.txtTempProd, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtTempProd As Global.System.Windows.Forms.Control = Me.txtTempProd
			location = New Global.System.Drawing.Point(104, 504)
			txtTempProd.Location = location
			Me.txtTempProd.MaxLength = 40
			Me.txtTempProd.Name = "txtTempProd"
			Me.txtTempProd.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtTempProd, True)
			Dim txtTempProd2 As Global.System.Windows.Forms.Control = Me.txtTempProd
			size = New Global.System.Drawing.Size(80, 22)
			txtTempProd2.Size = size
			Me.txtTempProd.TabIndex = 51
			Me.txtTempProd.Tag = "bem"
			Me.txtTempProd.Visible = False
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(820, 477)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtTempProd)
			Me.Controls.Add(Me.txtTempPress)
			Me.Controls.Add(Me.picRemoveFocus)
			Me.Controls.Add(Me._optFLPIP_5)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.KeyPreview = True
			location = New Global.System.Drawing.Point(85, 157)
			Me.Location = location
			Me.Name = "ProdInfo"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Tag = "2"
			Me.Text = "Production Information"
			Me.picRemoveFocus.ResumeLayout(False)
			Me.picRemoveFocus.PerformLayout()
			Me.pnlIPR.ResumeLayout(False)
			Me.pnlIPR.PerformLayout()
			CType(Me.ulgTestPoints, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.frmMaxProduction.ResumeLayout(False)
			Me._SSPanel_0.ResumeLayout(False)
			Me._SSPanel_0.PerformLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linSeparator, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.optFLPIP, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.optSPMBFPD, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
