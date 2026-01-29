Namespace RSWINV3
	Public Partial Class PTInfo
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.PTInfo))
			Me.pnlPTInfo = New Global.System.Windows.Forms.Panel()
			Me.chkUseRODSTARPumpTypeRecommendation = New Global.System.Windows.Forms.CheckBox()
			Me.chkCalcPlungerSize = New Global.System.Windows.Forms.CheckBox()
			Me.chkCalcFriction = New Global.System.Windows.Forms.CheckBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.txtSlideFricCoeff = New Global.System.Windows.Forms.TextBox()
			Me._Label_SlideFricCoeff = New Global.System.Windows.Forms.Label()
			Me._linSeparator_2 = New Global.System.Windows.Forms.Label()
			Me._Label_UpstrokeFriction = New Global.System.Windows.Forms.Label()
			Me._Label_DownstrokeFriction = New Global.System.Windows.Forms.Label()
			Me._Label_PumpFriction = New Global.System.Windows.Forms.Label()
			Me.chkIncludeFluidInertia = New Global.System.Windows.Forms.CheckBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.chkIncludeBuoyancy = New Global.System.Windows.Forms.CheckBox()
			Me.optPumpType_1 = New Global.System.Windows.Forms.RadioButton()
			Me.optPumpType_2 = New Global.System.Windows.Forms.RadioButton()
			Me.optPumpType_3 = New Global.System.Windows.Forms.RadioButton()
			Me._Label_TubingID = New Global.System.Windows.Forms.Label()
			Me._Label_TubingOD = New Global.System.Windows.Forms.Label()
			Me._Label_TubingSize = New Global.System.Windows.Forms.Label()
			Me._Label_TubingAnchorDepth = New Global.System.Windows.Forms.Label()
			Me._linSeparator_0 = New Global.System.Windows.Forms.Label()
			Me._linSeparator_1 = New Global.System.Windows.Forms.Label()
			Me._linSeparator_3 = New Global.System.Windows.Forms.Label()
			Me._Label_PlungerSize = New Global.System.Windows.Forms.Label()
			Me._Label_Plunger_Size = New Global.System.Windows.Forms.Label()
			Me._Label_PumpType = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me._Label_CompressIndex = New Global.System.Windows.Forms.Label()
			Me.txtTubingID = New Global.System.Windows.Forms.TextBox()
			Me.txtTubingOD = New Global.System.Windows.Forms.TextBox()
			Me.cboTubingOD = New Global.System.Windows.Forms.ComboBox()
			Me.lblcboPlungerSize_Disabled = New Global.System.Windows.Forms.Label()
			Me.txtPlungerSize = New Global.System.Windows.Forms.TextBox()
			Me.cboPlungerSize = New Global.System.Windows.Forms.ComboBox()
			Me.txtDownstrokeFriction = New Global.System.Windows.Forms.TextBox()
			Me.txtUpstrokeFriction = New Global.System.Windows.Forms.TextBox()
			Me.lblUpstrokeFriction_Disabled = New Global.System.Windows.Forms.Label()
			Me.lblDownstrokeFriction_Disabled = New Global.System.Windows.Forms.Label()
			Me.txtPumpFriction = New Global.System.Windows.Forms.TextBox()
			Me.txtCompressibilityIndex = New Global.System.Windows.Forms.TextBox()
			Me.lblCompressibilityIndex_Disabled = New Global.System.Windows.Forms.Label()
			Me.chkUseExpertTubingSizePreferences = New Global.System.Windows.Forms.CheckBox()
			Me.txtTubingAnchorDepth = New Global.System.Windows.Forms.TextBox()
			Me.lblTubingAnchorDepth_Disabled = New Global.System.Windows.Forms.Label()
			Me.lblPlungerSize_Disabled = New Global.System.Windows.Forms.Label()
			Me.chkTubingAnchored = New Global.System.Windows.Forms.CheckBox()
			Me.chkUseExpertTubingAnchored = New Global.System.Windows.Forms.CheckBox()
			Me.chkInsertPump = New Global.System.Windows.Forms.CheckBox()
			Me.chkTubingPump = New Global.System.Windows.Forms.CheckBox()
			Me.chkLargeBorePump = New Global.System.Windows.Forms.CheckBox()
			Me.chkVSP = New Global.System.Windows.Forms.CheckBox()
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.pnlPTInfo.SuspendLayout()
			Me.SuspendLayout()
			Me.pnlPTInfo.Controls.Add(Me.chkUseRODSTARPumpTypeRecommendation)
			Me.pnlPTInfo.Controls.Add(Me.chkCalcPlungerSize)
			Me.pnlPTInfo.Controls.Add(Me.chkCalcFriction)
			Me.pnlPTInfo.Controls.Add(Me.Label4)
			Me.pnlPTInfo.Controls.Add(Me.txtSlideFricCoeff)
			Me.pnlPTInfo.Controls.Add(Me._Label_SlideFricCoeff)
			Me.pnlPTInfo.Controls.Add(Me._linSeparator_2)
			Me.pnlPTInfo.Controls.Add(Me._Label_UpstrokeFriction)
			Me.pnlPTInfo.Controls.Add(Me._Label_DownstrokeFriction)
			Me.pnlPTInfo.Controls.Add(Me._Label_PumpFriction)
			Me.pnlPTInfo.Controls.Add(Me.chkIncludeFluidInertia)
			Me.pnlPTInfo.Controls.Add(Me.Label3)
			Me.pnlPTInfo.Controls.Add(Me.Label1)
			Me.pnlPTInfo.Controls.Add(Me.chkIncludeBuoyancy)
			Me.pnlPTInfo.Controls.Add(Me.optPumpType_1)
			Me.pnlPTInfo.Controls.Add(Me.optPumpType_2)
			Me.pnlPTInfo.Controls.Add(Me.optPumpType_3)
			Me.pnlPTInfo.Controls.Add(Me._Label_TubingID)
			Me.pnlPTInfo.Controls.Add(Me._Label_TubingOD)
			Me.pnlPTInfo.Controls.Add(Me._Label_TubingSize)
			Me.pnlPTInfo.Controls.Add(Me._Label_TubingAnchorDepth)
			Me.pnlPTInfo.Controls.Add(Me._linSeparator_0)
			Me.pnlPTInfo.Controls.Add(Me._linSeparator_1)
			Me.pnlPTInfo.Controls.Add(Me._linSeparator_3)
			Me.pnlPTInfo.Controls.Add(Me._Label_PlungerSize)
			Me.pnlPTInfo.Controls.Add(Me._Label_Plunger_Size)
			Me.pnlPTInfo.Controls.Add(Me._Label_PumpType)
			Me.pnlPTInfo.Controls.Add(Me.Label2)
			Me.pnlPTInfo.Controls.Add(Me._Label_CompressIndex)
			Me.pnlPTInfo.Controls.Add(Me.txtTubingID)
			Me.pnlPTInfo.Controls.Add(Me.txtTubingOD)
			Me.pnlPTInfo.Controls.Add(Me.cboTubingOD)
			Me.pnlPTInfo.Controls.Add(Me.lblcboPlungerSize_Disabled)
			Me.pnlPTInfo.Controls.Add(Me.txtPlungerSize)
			Me.pnlPTInfo.Controls.Add(Me.cboPlungerSize)
			Me.pnlPTInfo.Controls.Add(Me.txtDownstrokeFriction)
			Me.pnlPTInfo.Controls.Add(Me.txtUpstrokeFriction)
			Me.pnlPTInfo.Controls.Add(Me.lblUpstrokeFriction_Disabled)
			Me.pnlPTInfo.Controls.Add(Me.lblDownstrokeFriction_Disabled)
			Me.pnlPTInfo.Controls.Add(Me.txtPumpFriction)
			Me.pnlPTInfo.Controls.Add(Me.txtCompressibilityIndex)
			Me.pnlPTInfo.Controls.Add(Me.lblCompressibilityIndex_Disabled)
			Me.pnlPTInfo.Controls.Add(Me.chkUseExpertTubingSizePreferences)
			Me.pnlPTInfo.Controls.Add(Me.txtTubingAnchorDepth)
			Me.pnlPTInfo.Controls.Add(Me.lblTubingAnchorDepth_Disabled)
			Me.pnlPTInfo.Controls.Add(Me.lblPlungerSize_Disabled)
			Me.pnlPTInfo.Controls.Add(Me.chkTubingAnchored)
			Me.pnlPTInfo.Controls.Add(Me.chkUseExpertTubingAnchored)
			Me.pnlPTInfo.Controls.Add(Me.chkInsertPump)
			Me.pnlPTInfo.Controls.Add(Me.chkTubingPump)
			Me.pnlPTInfo.Controls.Add(Me.chkLargeBorePump)
			Me.pnlPTInfo.Controls.Add(Me.chkVSP)
			Dim pnlPTInfo As Global.System.Windows.Forms.Control = Me.pnlPTInfo
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(4, 4)
			pnlPTInfo.Location = location
			Me.pnlPTInfo.Name = "pnlPTInfo"
			Me.HelpProvider1.SetShowHelp(Me.pnlPTInfo, False)
			Dim pnlPTInfo2 As Global.System.Windows.Forms.Control = Me.pnlPTInfo
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(824, 312)
			pnlPTInfo2.Size = size
			Me.pnlPTInfo.TabIndex = 0
			Me.chkUseRODSTARPumpTypeRecommendation.Enabled = False
			Me.chkUseRODSTARPumpTypeRecommendation.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim chkUseRODSTARPumpTypeRecommendation As Global.System.Windows.Forms.Control = Me.chkUseRODSTARPumpTypeRecommendation
			location = New Global.System.Drawing.Point(16, 80)
			chkUseRODSTARPumpTypeRecommendation.Location = location
			Me.chkUseRODSTARPumpTypeRecommendation.Name = "chkUseRODSTARPumpTypeRecommendation"
			Dim chkUseRODSTARPumpTypeRecommendation2 As Global.System.Windows.Forms.Control = Me.chkUseRODSTARPumpTypeRecommendation
			size = New Global.System.Drawing.Size(336, 21)
			chkUseRODSTARPumpTypeRecommendation2.Size = size
			Me.chkUseRODSTARPumpTypeRecommendation.TabIndex = 218
			Me.chkUseRODSTARPumpTypeRecommendation.Text = "Use RODSTAR-VX  Pump Type Recommendation"
			Me.chkUseRODSTARPumpTypeRecommendation.Visible = False
			Me.chkCalcPlungerSize.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkCalcPlungerSize.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkCalcPlungerSize.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkCalcPlungerSize.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.chkCalcPlungerSize, "plunger size")
			Me.HelpProvider1.SetHelpNavigator(Me.chkCalcPlungerSize, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkCalcPlungerSize.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkCalcPlungerSize As Global.System.Windows.Forms.Control = Me.chkCalcPlungerSize
			location = New Global.System.Drawing.Point(16, 184)
			chkCalcPlungerSize.Location = location
			Me.chkCalcPlungerSize.Name = "chkCalcPlungerSize"
			Me.chkCalcPlungerSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkCalcPlungerSize, True)
			Dim chkCalcPlungerSize2 As Global.System.Windows.Forms.Control = Me.chkCalcPlungerSize
			size = New Global.System.Drawing.Size(336, 24)
			chkCalcPlungerSize2.Size = size
			Me.chkCalcPlungerSize.TabIndex = 86
			Me.chkCalcPlungerSize.Text = "Calculate plunger size"
			Me.chkCalcPlungerSize.UseVisualStyleBackColor = False
			Me.chkCalcFriction.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.chkCalcFriction, "Rod-tubing friction")
			Me.HelpProvider1.SetHelpNavigator(Me.chkCalcFriction, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.HelpProvider1.SetHelpString(Me.chkCalcFriction, "")
			Me.chkCalcFriction.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkCalcFriction As Global.System.Windows.Forms.Control = Me.chkCalcFriction
			location = New Global.System.Drawing.Point(392, 80)
			chkCalcFriction.Location = location
			Me.chkCalcFriction.Name = "chkCalcFriction"
			Me.HelpProvider1.SetShowHelp(Me.chkCalcFriction, True)
			Dim chkCalcFriction2 As Global.System.Windows.Forms.Control = Me.chkCalcFriction
			size = New Global.System.Drawing.Size(376, 22)
			chkCalcFriction2.Size = size
			Me.chkCalcFriction.TabIndex = 100
			Me.chkCalcFriction.Text = "Calculate rod-tubing friction coefficients"
			Me.Label4.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me.Label4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.Label4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label4
			location = New Global.System.Drawing.Point(368, 80)
			label.Location = location
			Me.Label4.Name = "Label4"
			Me.HelpProvider1.SetShowHelp(Me.Label4, False)
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(1, 225)
			label2.Size = size
			Me.Label4.TabIndex = 96
			Me.txtSlideFricCoeff.AcceptsReturn = True
			Me.txtSlideFricCoeff.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtSlideFricCoeff.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtSlideFricCoeff.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtSlideFricCoeff.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtSlideFricCoeff As Global.System.Windows.Forms.Control = Me.txtSlideFricCoeff
			location = New Global.System.Drawing.Point(864, 168)
			txtSlideFricCoeff.Location = location
			Me.txtSlideFricCoeff.MaxLength = 10
			Me.txtSlideFricCoeff.Name = "txtSlideFricCoeff"
			Me.txtSlideFricCoeff.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtSlideFricCoeff, False)
			Dim txtSlideFricCoeff2 As Global.System.Windows.Forms.Control = Me.txtSlideFricCoeff
			size = New Global.System.Drawing.Size(61, 22)
			txtSlideFricCoeff2.Size = size
			Me.txtSlideFricCoeff.TabIndex = 58
			Me.txtSlideFricCoeff.Visible = False
			Me._Label_SlideFricCoeff.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_SlideFricCoeff.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_SlideFricCoeff.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_SlideFricCoeff.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_SlideFricCoeff.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_SlideFricCoeff As Global.System.Windows.Forms.Control = Me._Label_SlideFricCoeff
			location = New Global.System.Drawing.Point(832, 168)
			label_SlideFricCoeff.Location = location
			Me._Label_SlideFricCoeff.Name = "_Label_SlideFricCoeff"
			Me._Label_SlideFricCoeff.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_SlideFricCoeff, False)
			Dim label_SlideFricCoeff2 As Global.System.Windows.Forms.Control = Me._Label_SlideFricCoeff
			size = New Global.System.Drawing.Size(168, 16)
			label_SlideFricCoeff2.Size = size
			Me._Label_SlideFricCoeff.TabIndex = 99
			Me._Label_SlideFricCoeff.Text = "Sliding-Friction Coefficient:"
			Me._Label_SlideFricCoeff.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_SlideFricCoeff.Visible = False
			Me._linSeparator_2.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._linSeparator_2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim linSeparator_ As Global.System.Windows.Forms.Control = Me._linSeparator_2
			location = New Global.System.Drawing.Point(368, 10)
			linSeparator_.Location = location
			Me._linSeparator_2.Name = "_linSeparator_2"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_2, False)
			Dim linSeparator_2 As Global.System.Windows.Forms.Control = Me._linSeparator_2
			size = New Global.System.Drawing.Size(1, 50)
			linSeparator_2.Size = size
			Me._linSeparator_2.TabIndex = 71
			Me._Label_UpstrokeFriction.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_UpstrokeFriction.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_UpstrokeFriction.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_UpstrokeFriction.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_UpstrokeFriction.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_UpstrokeFriction As Global.System.Windows.Forms.Control = Me._Label_UpstrokeFriction
			location = New Global.System.Drawing.Point(384, 104)
			label_UpstrokeFriction.Location = location
			Me._Label_UpstrokeFriction.Name = "_Label_UpstrokeFriction"
			Me._Label_UpstrokeFriction.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_UpstrokeFriction, False)
			Dim label_UpstrokeFriction2 As Global.System.Windows.Forms.Control = Me._Label_UpstrokeFriction
			size = New Global.System.Drawing.Size(350, 22)
			label_UpstrokeFriction2.Size = size
			Me._Label_UpstrokeFriction.TabIndex = 93
			Me._Label_UpstrokeFriction.Text = "Upstroke rod-fluid damping coefficient :"
			Me._Label_UpstrokeFriction.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_DownstrokeFriction.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_DownstrokeFriction.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_DownstrokeFriction.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_DownstrokeFriction.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_DownstrokeFriction.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_DownstrokeFriction As Global.System.Windows.Forms.Control = Me._Label_DownstrokeFriction
			location = New Global.System.Drawing.Point(384, 128)
			label_DownstrokeFriction.Location = location
			Me._Label_DownstrokeFriction.Name = "_Label_DownstrokeFriction"
			Me._Label_DownstrokeFriction.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_DownstrokeFriction, False)
			Dim label_DownstrokeFriction2 As Global.System.Windows.Forms.Control = Me._Label_DownstrokeFriction
			size = New Global.System.Drawing.Size(350, 22)
			label_DownstrokeFriction2.Size = size
			Me._Label_DownstrokeFriction.TabIndex = 94
			Me._Label_DownstrokeFriction.Text = "Downstroke rod-fluid damping coefficient :"
			Me._Label_DownstrokeFriction.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_PumpFriction.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_PumpFriction.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_PumpFriction.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_PumpFriction.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_PumpFriction.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_PumpFriction As Global.System.Windows.Forms.Control = Me._Label_PumpFriction
			location = New Global.System.Drawing.Point(384, 160)
			label_PumpFriction.Location = location
			Me._Label_PumpFriction.Name = "_Label_PumpFriction"
			Me._Label_PumpFriction.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_PumpFriction, False)
			Dim label_PumpFriction2 As Global.System.Windows.Forms.Control = Me._Label_PumpFriction
			size = New Global.System.Drawing.Size(350, 19)
			label_PumpFriction2.Size = size
			Me._Label_PumpFriction.TabIndex = 95
			Me._Label_PumpFriction.Tag = "Pump friction (^):"
			Me._Label_PumpFriction.Text = "Pump friction (lbs):"
			Me._Label_PumpFriction.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkIncludeFluidInertia.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkIncludeFluidInertia.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkIncludeFluidInertia.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkIncludeFluidInertia.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.chkIncludeFluidInertia, "Fluid inertia effects popup")
			Me.HelpProvider1.SetHelpNavigator(Me.chkIncludeFluidInertia, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkIncludeFluidInertia.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkIncludeFluidInertia As Global.System.Windows.Forms.Control = Me.chkIncludeFluidInertia
			location = New Global.System.Drawing.Point(392, 240)
			chkIncludeFluidInertia.Location = location
			Me.chkIncludeFluidInertia.Name = "chkIncludeFluidInertia"
			Me.chkIncludeFluidInertia.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkIncludeFluidInertia, True)
			Dim chkIncludeFluidInertia2 As Global.System.Windows.Forms.Control = Me.chkIncludeFluidInertia
			size = New Global.System.Drawing.Size(376, 17)
			chkIncludeFluidInertia2.Size = size
			Me.chkIncludeFluidInertia.TabIndex = 61
			Me.chkIncludeFluidInertia.Text = "Include fluid inertia effects"
			Me.chkIncludeFluidInertia.UseVisualStyleBackColor = False
			Me.Label3.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me.Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(8, 168)
			label3.Location = location
			Me.Label3.Name = "Label3"
			Me.HelpProvider1.SetShowHelp(Me.Label3, False)
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(350, 1)
			label4.Size = size
			Me.Label3.TabIndex = 85
			Me.Label1.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(8, 72)
			label5.Location = location
			Me.Label1.Name = "Label1"
			Me.HelpProvider1.SetShowHelp(Me.Label1, False)
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(800, 1)
			label6.Size = size
			Me.Label1.TabIndex = 83
			Me.chkIncludeBuoyancy.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkIncludeBuoyancy.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkIncludeBuoyancy.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkIncludeBuoyancy.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.chkIncludeBuoyancy, "Include buoyancy effects")
			Me.HelpProvider1.SetHelpNavigator(Me.chkIncludeBuoyancy, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkIncludeBuoyancy.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkIncludeBuoyancy As Global.System.Windows.Forms.Control = Me.chkIncludeBuoyancy
			location = New Global.System.Drawing.Point(392, 192)
			chkIncludeBuoyancy.Location = location
			Me.chkIncludeBuoyancy.Name = "chkIncludeBuoyancy"
			Me.chkIncludeBuoyancy.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkIncludeBuoyancy, True)
			Dim chkIncludeBuoyancy2 As Global.System.Windows.Forms.Control = Me.chkIncludeBuoyancy
			size = New Global.System.Drawing.Size(416, 19)
			chkIncludeBuoyancy2.Size = size
			Me.chkIncludeBuoyancy.TabIndex = 60
			Me.chkIncludeBuoyancy.Text = "Include buoyancy effects"
			Me.chkIncludeBuoyancy.UseVisualStyleBackColor = False
			Me.optPumpType_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optPumpType_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optPumpType_1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.optPumpType_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optPumpType_1, "Pump type")
			Me.HelpProvider1.SetHelpNavigator(Me.optPumpType_1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optPumpType_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpType_ As Global.System.Windows.Forms.Control = Me.optPumpType_1
			location = New Global.System.Drawing.Point(156, 102)
			optPumpType_.Location = location
			Me.optPumpType_1.Name = "optPumpType_1"
			Me.optPumpType_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optPumpType_1, True)
			Dim optPumpType_2 As Global.System.Windows.Forms.Control = Me.optPumpType_1
			size = New Global.System.Drawing.Size(196, 21)
			optPumpType_2.Size = size
			Me.optPumpType_1.TabIndex = 45
			Me.optPumpType_1.TabStop = True
			Me.optPumpType_1.Text = "Insert pump"
			Me.optPumpType_1.UseVisualStyleBackColor = False
			Me.optPumpType_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optPumpType_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optPumpType_2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.optPumpType_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optPumpType_2, "Pump type")
			Me.HelpProvider1.SetHelpNavigator(Me.optPumpType_2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optPumpType_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpType_3 As Global.System.Windows.Forms.Control = Me.optPumpType_2
			location = New Global.System.Drawing.Point(156, 120)
			optPumpType_3.Location = location
			Me.optPumpType_2.Name = "optPumpType_2"
			Me.optPumpType_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optPumpType_2, True)
			Dim optPumpType_4 As Global.System.Windows.Forms.Control = Me.optPumpType_2
			size = New Global.System.Drawing.Size(196, 21)
			optPumpType_4.Size = size
			Me.optPumpType_2.TabIndex = 46
			Me.optPumpType_2.TabStop = True
			Me.optPumpType_2.Text = "Tubing pump"
			Me.optPumpType_2.UseVisualStyleBackColor = False
			Me.optPumpType_3.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optPumpType_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optPumpType_3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.optPumpType_3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optPumpType_3, "Pump type")
			Me.HelpProvider1.SetHelpNavigator(Me.optPumpType_3, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optPumpType_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpType_5 As Global.System.Windows.Forms.Control = Me.optPumpType_3
			location = New Global.System.Drawing.Point(156, 138)
			optPumpType_5.Location = location
			Me.optPumpType_3.Name = "optPumpType_3"
			Me.optPumpType_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optPumpType_3, True)
			Dim optPumpType_6 As Global.System.Windows.Forms.Control = Me.optPumpType_3
			size = New Global.System.Drawing.Size(196, 21)
			optPumpType_6.Size = size
			Me.optPumpType_3.TabIndex = 47
			Me.optPumpType_3.TabStop = True
			Me.optPumpType_3.Text = "Large bore pump"
			Me.optPumpType_3.UseVisualStyleBackColor = False
			Me._Label_TubingID.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_TubingID.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_TubingID.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_TubingID.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_TubingID.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_TubingID As Global.System.Windows.Forms.Control = Me._Label_TubingID
			location = New Global.System.Drawing.Point(198, 32)
			label_TubingID.Location = location
			Me._Label_TubingID.Name = "_Label_TubingID"
			Me._Label_TubingID.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_TubingID, False)
			Dim label_TubingID2 As Global.System.Windows.Forms.Control = Me._Label_TubingID
			size = New Global.System.Drawing.Size(96, 19)
			label_TubingID2.Size = size
			Me._Label_TubingID.TabIndex = 68
			Me._Label_TubingID.Tag = "I.D. (^):"
			Me._Label_TubingID.Text = "I.D. (in):"
			Me._Label_TubingID.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_TubingOD.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_TubingOD.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_TubingOD.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_TubingOD.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_TubingOD.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_TubingOD As Global.System.Windows.Forms.Control = Me._Label_TubingOD
			location = New Global.System.Drawing.Point(198, 8)
			label_TubingOD.Location = location
			Me._Label_TubingOD.Name = "_Label_TubingOD"
			Me._Label_TubingOD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_TubingOD, False)
			Dim label_TubingOD2 As Global.System.Windows.Forms.Control = Me._Label_TubingOD
			size = New Global.System.Drawing.Size(96, 19)
			label_TubingOD2.Size = size
			Me._Label_TubingOD.TabIndex = 67
			Me._Label_TubingOD.Tag = "O.D. (^):"
			Me._Label_TubingOD.Text = "O.D. (in):"
			Me._Label_TubingOD.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_TubingSize.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_TubingSize.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_TubingSize.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_TubingSize.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_TubingSize.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_TubingSize As Global.System.Windows.Forms.Control = Me._Label_TubingSize
			location = New Global.System.Drawing.Point(8, 8)
			label_TubingSize.Location = location
			Me._Label_TubingSize.Name = "_Label_TubingSize"
			Me._Label_TubingSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_TubingSize, False)
			Dim label_TubingSize2 As Global.System.Windows.Forms.Control = Me._Label_TubingSize
			size = New Global.System.Drawing.Size(176, 19)
			label_TubingSize2.Size = size
			Me._Label_TubingSize.TabIndex = 40
			Me._Label_TubingSize.Text = "Tubing size (in):"
			Me._Label_TubingSize.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me._Label_TubingAnchorDepth.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_TubingAnchorDepth.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_TubingAnchorDepth.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_TubingAnchorDepth.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_TubingAnchorDepth.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_TubingAnchorDepth As Global.System.Windows.Forms.Control = Me._Label_TubingAnchorDepth
			location = New Global.System.Drawing.Point(384, 32)
			label_TubingAnchorDepth.Location = location
			Me._Label_TubingAnchorDepth.Name = "_Label_TubingAnchorDepth"
			Me._Label_TubingAnchorDepth.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_TubingAnchorDepth, False)
			Dim label_TubingAnchorDepth2 As Global.System.Windows.Forms.Control = Me._Label_TubingAnchorDepth
			size = New Global.System.Drawing.Size(350, 19)
			label_TubingAnchorDepth2.Size = size
			Me._Label_TubingAnchorDepth.TabIndex = 54
			Me._Label_TubingAnchorDepth.Tag = "Tubing anchor depth (^):"
			Me._Label_TubingAnchorDepth.Text = "Tubing anchor depth (ft):"
			Me._Label_TubingAnchorDepth.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me._linSeparator_0.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._linSeparator_0.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim linSeparator_3 As Global.System.Windows.Forms.Control = Me._linSeparator_0
			location = New Global.System.Drawing.Point(392, 224)
			linSeparator_3.Location = location
			Me._linSeparator_0.Name = "_linSeparator_0"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_0, False)
			Dim linSeparator_4 As Global.System.Windows.Forms.Control = Me._linSeparator_0
			size = New Global.System.Drawing.Size(400, 1)
			linSeparator_4.Size = size
			Me._linSeparator_0.TabIndex = 69
			Me._linSeparator_1.BackColor = Global.System.Drawing.Color.White
			Me._linSeparator_1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim linSeparator_5 As Global.System.Windows.Forms.Control = Me._linSeparator_1
			location = New Global.System.Drawing.Point(8, 168)
			linSeparator_5.Location = location
			Me._linSeparator_1.Name = "_linSeparator_1"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_1, False)
			Dim linSeparator_6 As Global.System.Windows.Forms.Control = Me._linSeparator_1
			size = New Global.System.Drawing.Size(280, 1)
			linSeparator_6.Size = size
			Me._linSeparator_1.TabIndex = 70
			Me._linSeparator_3.BackColor = Global.System.Drawing.Color.White
			Me._linSeparator_3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim linSeparator_7 As Global.System.Windows.Forms.Control = Me._linSeparator_3
			location = New Global.System.Drawing.Point(368, 10)
			linSeparator_7.Location = location
			Me._linSeparator_3.Name = "_linSeparator_3"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_3, False)
			Dim linSeparator_8 As Global.System.Windows.Forms.Control = Me._linSeparator_3
			size = New Global.System.Drawing.Size(1, 50)
			linSeparator_8.Size = size
			Me._linSeparator_3.TabIndex = 72
			Me._Label_PlungerSize.AutoSize = True
			Me._Label_PlungerSize.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_PlungerSize.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_PlungerSize.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_PlungerSize.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_PlungerSize.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_PlungerSize As Global.System.Windows.Forms.Control = Me._Label_PlungerSize
			location = New Global.System.Drawing.Point(113, 209)
			label_PlungerSize.Location = location
			Me._Label_PlungerSize.Name = "_Label_PlungerSize"
			Me._Label_PlungerSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_PlungerSize, False)
			Dim label_PlungerSize2 As Global.System.Windows.Forms.Control = Me._Label_PlungerSize
			size = New Global.System.Drawing.Size(26, 16)
			label_PlungerSize2.Size = size
			Me._Label_PlungerSize.TabIndex = 52
			Me._Label_PlungerSize.Tag = "(^)"
			Me._Label_PlungerSize.Text = "(in)"
			Me._Label_Plunger_Size.AutoSize = True
			Me._Label_Plunger_Size.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_Plunger_Size.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_Plunger_Size.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_Plunger_Size.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_Plunger_Size.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_Plunger_Size As Global.System.Windows.Forms.Control = Me._Label_Plunger_Size
			location = New Global.System.Drawing.Point(32, 208)
			label_Plunger_Size.Location = location
			Me._Label_Plunger_Size.Name = "_Label_Plunger_Size"
			Me._Label_Plunger_Size.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_Plunger_Size, False)
			Dim label_Plunger_Size2 As Global.System.Windows.Forms.Control = Me._Label_Plunger_Size
			size = New Global.System.Drawing.Size(81, 16)
			label_Plunger_Size2.Size = size
			Me._Label_Plunger_Size.TabIndex = 49
			Me._Label_Plunger_Size.Text = "Plunger size"
			Me._Label_Plunger_Size.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me._Label_PumpType.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_PumpType.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_PumpType.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_PumpType.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_PumpType.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_PumpType As Global.System.Windows.Forms.Control = Me._Label_PumpType
			location = New Global.System.Drawing.Point(47, 104)
			label_PumpType.Location = location
			Me._Label_PumpType.Name = "_Label_PumpType"
			Me._Label_PumpType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_PumpType, False)
			Dim label_PumpType2 As Global.System.Windows.Forms.Control = Me._Label_PumpType
			size = New Global.System.Drawing.Size(105, 18)
			label_PumpType2.Size = size
			Me._Label_PumpType.TabIndex = 44
			Me._Label_PumpType.Text = "Pump type:"
			Me._Label_PumpType.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label2.BackColor = Global.System.Drawing.Color.White
			Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(392, 224)
			label7.Location = location
			Me.Label2.Name = "Label2"
			Me.HelpProvider1.SetShowHelp(Me.Label2, False)
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(256, 1)
			label8.Size = size
			Me.Label2.TabIndex = 84
			Me._Label_CompressIndex.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_CompressIndex.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_CompressIndex.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_CompressIndex.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_CompressIndex.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_CompressIndex As Global.System.Windows.Forms.Control = Me._Label_CompressIndex
			location = New Global.System.Drawing.Point(384, 264)
			label_CompressIndex.Location = location
			Me._Label_CompressIndex.Name = "_Label_CompressIndex"
			Me._Label_CompressIndex.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_CompressIndex, False)
			Dim label_CompressIndex2 As Global.System.Windows.Forms.Control = Me._Label_CompressIndex
			size = New Global.System.Drawing.Size(340, 19)
			label_CompressIndex2.Size = size
			Me._Label_CompressIndex.TabIndex = 89
			Me._Label_CompressIndex.Text = "Fluid compressibility index:"
			Me._Label_CompressIndex.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.txtTubingID.AcceptsReturn = True
			Me.txtTubingID.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtTubingID.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtTubingID.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtTubingID.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtTubingID, "Tubing size")
			Me.HelpProvider1.SetHelpNavigator(Me.txtTubingID, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtTubingID As Global.System.Windows.Forms.Control = Me.txtTubingID
			location = New Global.System.Drawing.Point(296, 32)
			txtTubingID.Location = location
			Me.txtTubingID.MaxLength = 10
			Me.txtTubingID.Name = "txtTubingID"
			Me.txtTubingID.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtTubingID, True)
			Dim txtTubingID2 As Global.System.Windows.Forms.Control = Me.txtTubingID
			size = New Global.System.Drawing.Size(61, 22)
			txtTubingID2.Size = size
			Me.txtTubingID.TabIndex = 43
			Me.txtTubingID.Tag = "mem"
			Me.txtTubingOD.AcceptsReturn = True
			Me.txtTubingOD.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtTubingOD.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtTubingOD.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtTubingOD.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtTubingOD, "Tubing size")
			Me.HelpProvider1.SetHelpNavigator(Me.txtTubingOD, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtTubingOD As Global.System.Windows.Forms.Control = Me.txtTubingOD
			location = New Global.System.Drawing.Point(296, 8)
			txtTubingOD.Location = location
			Me.txtTubingOD.MaxLength = 10
			Me.txtTubingOD.Name = "txtTubingOD"
			Me.txtTubingOD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtTubingOD, True)
			Dim txtTubingOD2 As Global.System.Windows.Forms.Control = Me.txtTubingOD
			size = New Global.System.Drawing.Size(61, 22)
			txtTubingOD2.Size = size
			Me.txtTubingOD.TabIndex = 42
			Me.txtTubingOD.Tag = "mem"
			Me.cboTubingOD.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboTubingOD.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboTubingOD.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboTubingOD.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboTubingOD.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboTubingOD, "tubing size")
			Me.HelpProvider1.SetHelpNavigator(Me.cboTubingOD, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboTubingOD.ItemHeight = 16
			Dim cboTubingOD As Global.System.Windows.Forms.Control = Me.cboTubingOD
			location = New Global.System.Drawing.Point(8, 32)
			cboTubingOD.Location = location
			Me.cboTubingOD.MaxDropDownItems = 100
			Me.cboTubingOD.Name = "cboTubingOD"
			Me.cboTubingOD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboTubingOD, True)
			Dim cboTubingOD2 As Global.System.Windows.Forms.Control = Me.cboTubingOD
			size = New Global.System.Drawing.Size(176, 24)
			cboTubingOD2.Size = size
			Me.cboTubingOD.TabIndex = 41
			Me.lblcboPlungerSize_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblcboPlungerSize_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblcboPlungerSize_Disabled As Global.System.Windows.Forms.Control = Me.lblcboPlungerSize_Disabled
			location = New Global.System.Drawing.Point(32, 232)
			lblcboPlungerSize_Disabled.Location = location
			Me.lblcboPlungerSize_Disabled.Name = "lblcboPlungerSize_Disabled"
			Dim lblcboPlungerSize_Disabled2 As Global.System.Windows.Forms.Control = Me.lblcboPlungerSize_Disabled
			size = New Global.System.Drawing.Size(184, 24)
			lblcboPlungerSize_Disabled2.Size = size
			Me.lblcboPlungerSize_Disabled.TabIndex = 216
			Me.txtPlungerSize.AcceptsReturn = True
			Me.txtPlungerSize.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPlungerSize.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPlungerSize.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtPlungerSize.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtPlungerSize, "Plunger size")
			Me.HelpProvider1.SetHelpNavigator(Me.txtPlungerSize, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtPlungerSize As Global.System.Windows.Forms.Control = Me.txtPlungerSize
			location = New Global.System.Drawing.Point(224, 232)
			txtPlungerSize.Location = location
			Me.txtPlungerSize.MaxLength = 10
			Me.txtPlungerSize.Name = "txtPlungerSize"
			Me.txtPlungerSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtPlungerSize, True)
			Dim txtPlungerSize2 As Global.System.Windows.Forms.Control = Me.txtPlungerSize
			size = New Global.System.Drawing.Size(72, 22)
			txtPlungerSize2.Size = size
			Me.txtPlungerSize.TabIndex = 51
			Me.txtPlungerSize.Tag = "mem"
			Me.cboPlungerSize.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboPlungerSize.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboPlungerSize.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboPlungerSize.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboPlungerSize.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboPlungerSize, "Plunger size")
			Me.HelpProvider1.SetHelpNavigator(Me.cboPlungerSize, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboPlungerSize.ItemHeight = 16
			Dim cboPlungerSize As Global.System.Windows.Forms.Control = Me.cboPlungerSize
			location = New Global.System.Drawing.Point(32, 232)
			cboPlungerSize.Location = location
			Me.cboPlungerSize.MaxDropDownItems = 100
			Me.cboPlungerSize.Name = "cboPlungerSize"
			Me.cboPlungerSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboPlungerSize, True)
			Dim cboPlungerSize2 As Global.System.Windows.Forms.Control = Me.cboPlungerSize
			size = New Global.System.Drawing.Size(184, 24)
			cboPlungerSize2.Size = size
			Me.cboPlungerSize.TabIndex = 50
			Me.txtDownstrokeFriction.AcceptsReturn = True
			Me.txtDownstrokeFriction.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtDownstrokeFriction.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtDownstrokeFriction.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtDownstrokeFriction.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtDownstrokeFriction, "Rod-tubing friction")
			Me.HelpProvider1.SetHelpNavigator(Me.txtDownstrokeFriction, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.HelpProvider1.SetHelpString(Me.txtDownstrokeFriction, "")
			Dim txtDownstrokeFriction As Global.System.Windows.Forms.Control = Me.txtDownstrokeFriction
			location = New Global.System.Drawing.Point(744, 128)
			txtDownstrokeFriction.Location = location
			Me.txtDownstrokeFriction.MaxLength = 10
			Me.txtDownstrokeFriction.Name = "txtDownstrokeFriction"
			Me.txtDownstrokeFriction.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtDownstrokeFriction, True)
			Dim txtDownstrokeFriction2 As Global.System.Windows.Forms.Control = Me.txtDownstrokeFriction
			size = New Global.System.Drawing.Size(61, 22)
			txtDownstrokeFriction2.Size = size
			Me.txtDownstrokeFriction.TabIndex = 57
			Me.txtUpstrokeFriction.AcceptsReturn = True
			Me.txtUpstrokeFriction.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtUpstrokeFriction.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtUpstrokeFriction.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtUpstrokeFriction.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtUpstrokeFriction, "Rod-tubing friction")
			Me.HelpProvider1.SetHelpNavigator(Me.txtUpstrokeFriction, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.HelpProvider1.SetHelpString(Me.txtUpstrokeFriction, "")
			Dim txtUpstrokeFriction As Global.System.Windows.Forms.Control = Me.txtUpstrokeFriction
			location = New Global.System.Drawing.Point(744, 104)
			txtUpstrokeFriction.Location = location
			Me.txtUpstrokeFriction.MaxLength = 10
			Me.txtUpstrokeFriction.Name = "txtUpstrokeFriction"
			Me.txtUpstrokeFriction.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtUpstrokeFriction, True)
			Dim txtUpstrokeFriction2 As Global.System.Windows.Forms.Control = Me.txtUpstrokeFriction
			size = New Global.System.Drawing.Size(61, 22)
			txtUpstrokeFriction2.Size = size
			Me.txtUpstrokeFriction.TabIndex = 56
			Me.lblUpstrokeFriction_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblUpstrokeFriction_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblUpstrokeFriction_Disabled As Global.System.Windows.Forms.Control = Me.lblUpstrokeFriction_Disabled
			location = New Global.System.Drawing.Point(744, 104)
			lblUpstrokeFriction_Disabled.Location = location
			Me.lblUpstrokeFriction_Disabled.Name = "lblUpstrokeFriction_Disabled"
			Dim lblUpstrokeFriction_Disabled2 As Global.System.Windows.Forms.Control = Me.lblUpstrokeFriction_Disabled
			size = New Global.System.Drawing.Size(61, 24)
			lblUpstrokeFriction_Disabled2.Size = size
			Me.lblUpstrokeFriction_Disabled.TabIndex = 212
			Me.lblDownstrokeFriction_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblDownstrokeFriction_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblDownstrokeFriction_Disabled As Global.System.Windows.Forms.Control = Me.lblDownstrokeFriction_Disabled
			location = New Global.System.Drawing.Point(744, 128)
			lblDownstrokeFriction_Disabled.Location = location
			Me.lblDownstrokeFriction_Disabled.Name = "lblDownstrokeFriction_Disabled"
			Dim lblDownstrokeFriction_Disabled2 As Global.System.Windows.Forms.Control = Me.lblDownstrokeFriction_Disabled
			size = New Global.System.Drawing.Size(61, 24)
			lblDownstrokeFriction_Disabled2.Size = size
			Me.lblDownstrokeFriction_Disabled.TabIndex = 213
			Me.txtPumpFriction.AcceptsReturn = True
			Me.txtPumpFriction.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPumpFriction.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPumpFriction.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtPumpFriction.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtPumpFriction, "pump friction")
			Me.HelpProvider1.SetHelpNavigator(Me.txtPumpFriction, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtPumpFriction As Global.System.Windows.Forms.Control = Me.txtPumpFriction
			location = New Global.System.Drawing.Point(744, 160)
			txtPumpFriction.Location = location
			Me.txtPumpFriction.MaxLength = 10
			Me.txtPumpFriction.Name = "txtPumpFriction"
			Me.txtPumpFriction.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtPumpFriction, True)
			Dim txtPumpFriction2 As Global.System.Windows.Forms.Control = Me.txtPumpFriction
			size = New Global.System.Drawing.Size(61, 22)
			txtPumpFriction2.Size = size
			Me.txtPumpFriction.TabIndex = 59
			Me.txtPumpFriction.Tag = "lee"
			Me.txtCompressibilityIndex.AcceptsReturn = True
			Me.txtCompressibilityIndex.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtCompressibilityIndex.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtCompressibilityIndex.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtCompressibilityIndex.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtCompressibilityIndex, "Fluid Compressibility Index")
			Me.HelpProvider1.SetHelpNavigator(Me.txtCompressibilityIndex, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtCompressibilityIndex As Global.System.Windows.Forms.Control = Me.txtCompressibilityIndex
			location = New Global.System.Drawing.Point(728, 264)
			txtCompressibilityIndex.Location = location
			Me.txtCompressibilityIndex.MaxLength = 10
			Me.txtCompressibilityIndex.Name = "txtCompressibilityIndex"
			Me.txtCompressibilityIndex.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtCompressibilityIndex, True)
			Dim txtCompressibilityIndex2 As Global.System.Windows.Forms.Control = Me.txtCompressibilityIndex
			size = New Global.System.Drawing.Size(61, 22)
			txtCompressibilityIndex2.Size = size
			Me.txtCompressibilityIndex.TabIndex = 62
			Me.lblCompressibilityIndex_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblCompressibilityIndex_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblCompressibilityIndex_Disabled As Global.System.Windows.Forms.Control = Me.lblCompressibilityIndex_Disabled
			location = New Global.System.Drawing.Point(728, 264)
			lblCompressibilityIndex_Disabled.Location = location
			Me.lblCompressibilityIndex_Disabled.Name = "lblCompressibilityIndex_Disabled"
			Dim lblCompressibilityIndex_Disabled2 As Global.System.Windows.Forms.Control = Me.lblCompressibilityIndex_Disabled
			size = New Global.System.Drawing.Size(61, 24)
			lblCompressibilityIndex_Disabled2.Size = size
			Me.lblCompressibilityIndex_Disabled.TabIndex = 214
			Me.chkUseExpertTubingSizePreferences.Enabled = False
			Me.chkUseExpertTubingSizePreferences.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim chkUseExpertTubingSizePreferences As Global.System.Windows.Forms.Control = Me.chkUseExpertTubingSizePreferences
			location = New Global.System.Drawing.Point(16, 24)
			chkUseExpertTubingSizePreferences.Location = location
			Me.chkUseExpertTubingSizePreferences.Name = "chkUseExpertTubingSizePreferences"
			Dim chkUseExpertTubingSizePreferences2 As Global.System.Windows.Forms.Control = Me.chkUseExpertTubingSizePreferences
			size = New Global.System.Drawing.Size(344, 24)
			chkUseExpertTubingSizePreferences2.Size = size
			Me.chkUseExpertTubingSizePreferences.TabIndex = 217
			Me.chkUseExpertTubingSizePreferences.Text = "Use AI Tubing Size Preferences"
			Me.chkUseExpertTubingSizePreferences.Visible = False
			Me.txtTubingAnchorDepth.AcceptsReturn = True
			Me.txtTubingAnchorDepth.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtTubingAnchorDepth.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtTubingAnchorDepth.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtTubingAnchorDepth.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtTubingAnchorDepth, "Tubing anchor depth")
			Me.HelpProvider1.SetHelpNavigator(Me.txtTubingAnchorDepth, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtTubingAnchorDepth As Global.System.Windows.Forms.Control = Me.txtTubingAnchorDepth
			location = New Global.System.Drawing.Point(744, 32)
			txtTubingAnchorDepth.Location = location
			Me.txtTubingAnchorDepth.MaxLength = 10
			Me.txtTubingAnchorDepth.Name = "txtTubingAnchorDepth"
			Me.txtTubingAnchorDepth.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtTubingAnchorDepth, True)
			Dim txtTubingAnchorDepth2 As Global.System.Windows.Forms.Control = Me.txtTubingAnchorDepth
			size = New Global.System.Drawing.Size(61, 22)
			txtTubingAnchorDepth2.Size = size
			Me.txtTubingAnchorDepth.TabIndex = 55
			Me.txtTubingAnchorDepth.Tag = "fem"
			Me.lblTubingAnchorDepth_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblTubingAnchorDepth_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblTubingAnchorDepth_Disabled As Global.System.Windows.Forms.Control = Me.lblTubingAnchorDepth_Disabled
			location = New Global.System.Drawing.Point(744, 32)
			lblTubingAnchorDepth_Disabled.Location = location
			Me.lblTubingAnchorDepth_Disabled.Name = "lblTubingAnchorDepth_Disabled"
			Dim lblTubingAnchorDepth_Disabled2 As Global.System.Windows.Forms.Control = Me.lblTubingAnchorDepth_Disabled
			size = New Global.System.Drawing.Size(61, 24)
			lblTubingAnchorDepth_Disabled2.Size = size
			Me.lblTubingAnchorDepth_Disabled.TabIndex = 211
			Me.lblPlungerSize_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblPlungerSize_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblPlungerSize_Disabled As Global.System.Windows.Forms.Control = Me.lblPlungerSize_Disabled
			location = New Global.System.Drawing.Point(224, 232)
			lblPlungerSize_Disabled.Location = location
			Me.lblPlungerSize_Disabled.Name = "lblPlungerSize_Disabled"
			Dim lblPlungerSize_Disabled2 As Global.System.Windows.Forms.Control = Me.lblPlungerSize_Disabled
			size = New Global.System.Drawing.Size(72, 24)
			lblPlungerSize_Disabled2.Size = size
			Me.lblPlungerSize_Disabled.TabIndex = 215
			Me.chkTubingAnchored.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkTubingAnchored.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkTubingAnchored.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkTubingAnchored.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.chkTubingAnchored, "Tubing anchor depth")
			Me.HelpProvider1.SetHelpNavigator(Me.chkTubingAnchored, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkTubingAnchored.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkTubingAnchored As Global.System.Windows.Forms.Control = Me.chkTubingAnchored
			location = New Global.System.Drawing.Point(392, 8)
			chkTubingAnchored.Location = location
			Me.chkTubingAnchored.Name = "chkTubingAnchored"
			Me.chkTubingAnchored.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkTubingAnchored, True)
			Dim chkTubingAnchored2 As Global.System.Windows.Forms.Control = Me.chkTubingAnchored
			size = New Global.System.Drawing.Size(376, 19)
			chkTubingAnchored2.Size = size
			Me.chkTubingAnchored.TabIndex = 53
			Me.chkTubingAnchored.Text = "Tubing anchored"
			Me.chkTubingAnchored.UseVisualStyleBackColor = False
			Me.chkUseExpertTubingAnchored.Enabled = False
			Me.chkUseExpertTubingAnchored.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim chkUseExpertTubingAnchored As Global.System.Windows.Forms.Control = Me.chkUseExpertTubingAnchored
			location = New Global.System.Drawing.Point(392, 24)
			chkUseExpertTubingAnchored.Location = location
			Me.chkUseExpertTubingAnchored.Name = "chkUseExpertTubingAnchored"
			Dim chkUseExpertTubingAnchored2 As Global.System.Windows.Forms.Control = Me.chkUseExpertTubingAnchored
			size = New Global.System.Drawing.Size(424, 24)
			chkUseExpertTubingAnchored2.Size = size
			Me.chkUseExpertTubingAnchored.TabIndex = 222
			Me.chkUseExpertTubingAnchored.Text = "Use RODSTAR-VX Tubing Anchored Recommendation"
			Me.chkUseExpertTubingAnchored.Visible = False
			Me.chkInsertPump.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim chkInsertPump As Global.System.Windows.Forms.Control = Me.chkInsertPump
			location = New Global.System.Drawing.Point(156, 105)
			chkInsertPump.Location = location
			Me.chkInsertPump.Name = "chkInsertPump"
			Dim chkInsertPump2 As Global.System.Windows.Forms.Control = Me.chkInsertPump
			size = New Global.System.Drawing.Size(117, 22)
			chkInsertPump2.Size = size
			Me.chkInsertPump.TabIndex = 224
			Me.chkInsertPump.Text = "Insert pump"
			Me.chkTubingPump.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim chkTubingPump As Global.System.Windows.Forms.Control = Me.chkTubingPump
			location = New Global.System.Drawing.Point(156, 123)
			chkTubingPump.Location = location
			Me.chkTubingPump.Name = "chkTubingPump"
			Dim chkTubingPump2 As Global.System.Windows.Forms.Control = Me.chkTubingPump
			size = New Global.System.Drawing.Size(117, 22)
			chkTubingPump2.Size = size
			Me.chkTubingPump.TabIndex = 225
			Me.chkTubingPump.Text = "Tubing pump"
			Me.chkLargeBorePump.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim chkLargeBorePump As Global.System.Windows.Forms.Control = Me.chkLargeBorePump
			location = New Global.System.Drawing.Point(156, 141)
			chkLargeBorePump.Location = location
			Me.chkLargeBorePump.Name = "chkLargeBorePump"
			Dim chkLargeBorePump2 As Global.System.Windows.Forms.Control = Me.chkLargeBorePump
			size = New Global.System.Drawing.Size(117, 22)
			chkLargeBorePump2.Size = size
			Me.chkLargeBorePump.TabIndex = 226
			Me.chkLargeBorePump.Text = "Large bore pump"
			Me.chkVSP.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkVSP.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkVSP As Global.System.Windows.Forms.Control = Me.chkVSP
			location = New Global.System.Drawing.Point(291, 105)
			chkVSP.Location = location
			Me.chkVSP.Name = "chkVSP"
			Me.HelpProvider1.SetShowHelp(Me.chkVSP, False)
			Dim chkVSP2 As Global.System.Windows.Forms.Control = Me.chkVSP
			size = New Global.System.Drawing.Size(61, 23)
			chkVSP2.Size = size
			Me.chkVSP.TabIndex = 223
			Me.chkVSP.Text = "VSP"
			Me.chkVSP.Visible = False
			Me.ToolTip1.ShowAlways = True
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(833, 320)
			Me.ClientSize = size
			Me.Controls.Add(Me.pnlPTInfo)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "PTInfo"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Pump And Tubing Information"
			Me.pnlPTInfo.ResumeLayout(False)
			Me.pnlPTInfo.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
