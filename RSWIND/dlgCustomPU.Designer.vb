Namespace RSWINV3
	Friend Partial Class dlgCustomPU
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgCustomPU))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.cmdHelp = New Global.System.Windows.Forms.Button()
			Me._SSFrame_UnitDimensions = New Global.System.Windows.Forms.GroupBox()
			Me._panDimensions_4 = New Global.System.Windows.Forms.Panel()
			Me.txtM = New Global.System.Windows.Forms.TextBox()
			Me.txtS = New Global.System.Windows.Forms.TextBox()
			Me.txtV0 = New Global.System.Windows.Forms.TextBox()
			Me._Label_25 = New Global.System.Windows.Forms.Label()
			Me._Label_26 = New Global.System.Windows.Forms.Label()
			Me._Label_27 = New Global.System.Windows.Forms.Label()
			Me._panLowProfileBelt2 = New Global.System.Windows.Forms.Panel()
			Me.txtTheta = New Global.System.Windows.Forms.TextBox()
			Me.lblTheta = New Global.System.Windows.Forms.Label()
			Me._panDimensions_3 = New Global.System.Windows.Forms.Panel()
			Me.lblCrankCBMoment = New Global.System.Windows.Forms.Label()
			Me.txtCrankCBMoment = New Global.System.Windows.Forms.TextBox()
			Me.txtUnbalance = New Global.System.Windows.Forms.TextBox()
			Me.txtCrankOffset = New Global.System.Windows.Forms.TextBox()
			Me._Label_23 = New Global.System.Windows.Forms.Label()
			Me._Label_24 = New Global.System.Windows.Forms.Label()
			Me._panDimensions_0 = New Global.System.Windows.Forms.Panel()
			Me.cboCrankHoles = New Global.System.Windows.Forms.ComboBox()
			Me._Label_8 = New Global.System.Windows.Forms.Label()
			Me._Label_13 = New Global.System.Windows.Forms.Label()
			Me._Label_12 = New Global.System.Windows.Forms.Label()
			Me._Label_11 = New Global.System.Windows.Forms.Label()
			Me._Label_10 = New Global.System.Windows.Forms.Label()
			Me._Label_9 = New Global.System.Windows.Forms.Label()
			Me._Label_29 = New Global.System.Windows.Forms.Label()
			Me._panCalcStroke_5 = New Global.System.Windows.Forms.Label()
			Me._panCalcStroke_4 = New Global.System.Windows.Forms.Label()
			Me._panCalcStroke_3 = New Global.System.Windows.Forms.Label()
			Me._panCalcStroke_2 = New Global.System.Windows.Forms.Label()
			Me._panCalcStroke_1 = New Global.System.Windows.Forms.Label()
			Me._txtR_4 = New Global.System.Windows.Forms.TextBox()
			Me._txtR_3 = New Global.System.Windows.Forms.TextBox()
			Me._txtR_2 = New Global.System.Windows.Forms.TextBox()
			Me._txtR_4_disabled = New Global.System.Windows.Forms.Label()
			Me._txtR_3_disabled = New Global.System.Windows.Forms.Label()
			Me._txtR_2_disabled = New Global.System.Windows.Forms.Label()
			Me._txtR_5 = New Global.System.Windows.Forms.TextBox()
			Me._txtR_5_disabled = New Global.System.Windows.Forms.Label()
			Me._txtR_1 = New Global.System.Windows.Forms.TextBox()
			Me._txtR_1_disabled = New Global.System.Windows.Forms.Label()
			Me._panDimensions_longstroke = New Global.System.Windows.Forms.Panel()
			Me.txtPitmanLength = New Global.System.Windows.Forms.TextBox()
			Me.txtDrumDiamRatio = New Global.System.Windows.Forms.TextBox()
			Me.txtSprocketDistance = New Global.System.Windows.Forms.TextBox()
			Me.txtSprocketDiameter = New Global.System.Windows.Forms.TextBox()
			Me._panCalcStroke_0 = New Global.System.Windows.Forms.Label()
			Me._Label_30 = New Global.System.Windows.Forms.Label()
			Me._Label_17 = New Global.System.Windows.Forms.Label()
			Me._Label_16 = New Global.System.Windows.Forms.Label()
			Me._Label_15 = New Global.System.Windows.Forms.Label()
			Me._Label_14 = New Global.System.Windows.Forms.Label()
			Me._panDimensions_2_MII = New Global.System.Windows.Forms.Panel()
			Me.txtP_MII = New Global.System.Windows.Forms.TextBox()
			Me.txtK_MII = New Global.System.Windows.Forms.TextBox()
			Me.txtI_MII = New Global.System.Windows.Forms.TextBox()
			Me.txtC_MII = New Global.System.Windows.Forms.TextBox()
			Me.txtA_MII = New Global.System.Windows.Forms.TextBox()
			Me.Label_A_MII = New Global.System.Windows.Forms.Label()
			Me.Label_C_MII = New Global.System.Windows.Forms.Label()
			Me.Label_I_MII = New Global.System.Windows.Forms.Label()
			Me.Label_K_MII = New Global.System.Windows.Forms.Label()
			Me.Label_P_MII = New Global.System.Windows.Forms.Label()
			Me._panLowProfileBelt1 = New Global.System.Windows.Forms.Panel()
			Me.lblD = New Global.System.Windows.Forms.Label()
			Me.lblI = New Global.System.Windows.Forms.Label()
			Me.txtI_lp = New Global.System.Windows.Forms.TextBox()
			Me.lblK = New Global.System.Windows.Forms.Label()
			Me.txtK_LP = New Global.System.Windows.Forms.TextBox()
			Me.lblB = New Global.System.Windows.Forms.Label()
			Me.txtD_lp = New Global.System.Windows.Forms.TextBox()
			Me.txtB_lp = New Global.System.Windows.Forms.TextBox()
			Me._panDimensions_2_ABAL = New Global.System.Windows.Forms.Panel()
			Me.txtP_ABAL = New Global.System.Windows.Forms.TextBox()
			Me.txtK_ABAL = New Global.System.Windows.Forms.TextBox()
			Me.txtI_ABAL = New Global.System.Windows.Forms.TextBox()
			Me.txtC_ABAL = New Global.System.Windows.Forms.TextBox()
			Me.txtA_ABAL = New Global.System.Windows.Forms.TextBox()
			Me.Label_A_ABAL = New Global.System.Windows.Forms.Label()
			Me.Label_C_ABAL = New Global.System.Windows.Forms.Label()
			Me.Label_I_ABAL = New Global.System.Windows.Forms.Label()
			Me.Label_K_ABAL = New Global.System.Windows.Forms.Label()
			Me.Label_P_ABAL = New Global.System.Windows.Forms.Label()
			Me._panDimensions_2 = New Global.System.Windows.Forms.Panel()
			Me.txtP = New Global.System.Windows.Forms.TextBox()
			Me.txtK = New Global.System.Windows.Forms.TextBox()
			Me.txtI = New Global.System.Windows.Forms.TextBox()
			Me.txtC = New Global.System.Windows.Forms.TextBox()
			Me.txtA = New Global.System.Windows.Forms.TextBox()
			Me._Label_18 = New Global.System.Windows.Forms.Label()
			Me._Label_19 = New Global.System.Windows.Forms.Label()
			Me._Label_20 = New Global.System.Windows.Forms.Label()
			Me._Label_21 = New Global.System.Windows.Forms.Label()
			Me._Label_22 = New Global.System.Windows.Forms.Label()
			Me._SSFrame_0 = New Global.System.Windows.Forms.GroupBox()
			Me.lblRequiredRotation = New Global.System.Windows.Forms.Label()
			Me.txtGearboxRating = New Global.System.Windows.Forms.TextBox()
			Me.txtStructRating = New Global.System.Windows.Forms.TextBox()
			Me.txtMaxStroke = New Global.System.Windows.Forms.TextBox()
			Me.cboUnitType = New Global.System.Windows.Forms.ComboBox()
			Me.txtManufacturer = New Global.System.Windows.Forms.TextBox()
			Me.txtOtherInfo = New Global.System.Windows.Forms.TextBox()
			Me.txtUnitName = New Global.System.Windows.Forms.TextBox()
			Me.lblAPIDesignation = New Global.System.Windows.Forms.Label()
			Me._Label_6 = New Global.System.Windows.Forms.Label()
			Me._Label_5 = New Global.System.Windows.Forms.Label()
			Me._Label_GearboxRating = New Global.System.Windows.Forms.Label()
			Me._Label_3 = New Global.System.Windows.Forms.Label()
			Me._Label_API_designation = New Global.System.Windows.Forms.Label()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me._Label_2 = New Global.System.Windows.Forms.Label()
			Me._Label_1 = New Global.System.Windows.Forms.Label()
			Me.lblArtInertia = New Global.System.Windows.Forms.Label()
			Me.txtArtInertia = New Global.System.Windows.Forms.TextBox()
			Me.lblArtInertia_Disabled = New Global.System.Windows.Forms.Label()
			Me.cboRequiredRotation = New Global.System.Windows.Forms.ComboBox()
			Me.cmdLoad = New Global.System.Windows.Forms.Button()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.Line = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSFrame = New Global.Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
			Me.panCalcStroke = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.panDimensions = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.txtR = New Global.Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me._SSFrame_UnitDimensions.SuspendLayout()
			Me._panDimensions_4.SuspendLayout()
			Me._panLowProfileBelt2.SuspendLayout()
			Me._panDimensions_3.SuspendLayout()
			Me._panDimensions_0.SuspendLayout()
			Me._panDimensions_longstroke.SuspendLayout()
			Me._panDimensions_2_MII.SuspendLayout()
			Me._panLowProfileBelt1.SuspendLayout()
			Me._panDimensions_2_ABAL.SuspendLayout()
			Me._panDimensions_2.SuspendLayout()
			Me._SSFrame_0.SuspendLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Line, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSFrame, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panCalcStroke, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panDimensions, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtR, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(696, 7)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdOK, False)
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(96, 23)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 38
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			location = New Global.System.Drawing.Point(696, 36)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdCancel, False)
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(96, 23)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 39
			Me.cmdCancel.Text = "Cancel"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.cmdHelp.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdHelp.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdHelp.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdHelp.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdHelp.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdHelp As Global.System.Windows.Forms.Control = Me.cmdHelp
			location = New Global.System.Drawing.Point(696, 80)
			cmdHelp.Location = location
			Me.cmdHelp.Name = "cmdHelp"
			Me.cmdHelp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdHelp, False)
			Dim cmdHelp2 As Global.System.Windows.Forms.Control = Me.cmdHelp
			size = New Global.System.Drawing.Size(96, 23)
			cmdHelp2.Size = size
			Me.cmdHelp.TabIndex = 40
			Me.cmdHelp.Text = "Help"
			Me.cmdHelp.UseVisualStyleBackColor = False
			Me.cmdHelp.Visible = False
			Me._SSFrame_UnitDimensions.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSFrame_UnitDimensions.Controls.Add(Me._panDimensions_longstroke)
			Me._SSFrame_UnitDimensions.Controls.Add(Me._panDimensions_0)
			Me._SSFrame_UnitDimensions.Controls.Add(Me._panDimensions_2_MII)
			Me._SSFrame_UnitDimensions.Controls.Add(Me._panLowProfileBelt1)
			Me._SSFrame_UnitDimensions.Controls.Add(Me._panDimensions_2_ABAL)
			Me._SSFrame_UnitDimensions.Controls.Add(Me._panDimensions_2)
			Me._SSFrame_UnitDimensions.Controls.Add(Me._panDimensions_3)
			Me._SSFrame_UnitDimensions.Controls.Add(Me._panDimensions_4)
			Me._SSFrame_UnitDimensions.Controls.Add(Me._panLowProfileBelt2)
			Me._SSFrame_UnitDimensions.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me._SSFrame_UnitDimensions.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.SSFrame.SetIndex(Me._SSFrame_UnitDimensions, 1S)
			Dim ssframe_UnitDimensions As Global.System.Windows.Forms.Control = Me._SSFrame_UnitDimensions
			location = New Global.System.Drawing.Point(8, 144)
			ssframe_UnitDimensions.Location = location
			Me._SSFrame_UnitDimensions.Name = "_SSFrame_UnitDimensions"
			Me._SSFrame_UnitDimensions.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._SSFrame_UnitDimensions, False)
			Dim ssframe_UnitDimensions2 As Global.System.Windows.Forms.Control = Me._SSFrame_UnitDimensions
			size = New Global.System.Drawing.Size(670, 216)
			ssframe_UnitDimensions2.Size = size
			Me._SSFrame_UnitDimensions.TabIndex = 76
			Me._SSFrame_UnitDimensions.TabStop = False
			Me._SSFrame_UnitDimensions.Text = "Unit Dimensions"
			Me._SSFrame_UnitDimensions.Visible = False
			Me._panDimensions_4.BackColor = Global.System.Drawing.SystemColors.Control
			Me._panDimensions_4.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panDimensions_4.Controls.Add(Me.txtM)
			Me._panDimensions_4.Controls.Add(Me.txtS)
			Me._panDimensions_4.Controls.Add(Me.txtV0)
			Me._panDimensions_4.Controls.Add(Me._Label_25)
			Me._panDimensions_4.Controls.Add(Me._Label_26)
			Me._panDimensions_4.Controls.Add(Me._Label_27)
			Me._panDimensions_4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panDimensions_4.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panDimensions_4.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.panDimensions.SetIndex(Me._panDimensions_4, 4S)
			Dim panDimensions_ As Global.System.Windows.Forms.Control = Me._panDimensions_4
			location = New Global.System.Drawing.Point(336, 120)
			panDimensions_.Location = location
			Me._panDimensions_4.Name = "_panDimensions_4"
			Me._panDimensions_4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panDimensions_4, False)
			Dim panDimensions_2 As Global.System.Windows.Forms.Control = Me._panDimensions_4
			size = New Global.System.Drawing.Size(320, 88)
			panDimensions_2.Size = size
			Me._panDimensions_4.TabIndex = 33
			Me._panDimensions_4.TabStop = True
			Me._panDimensions_4.Visible = False
			Me.txtM.AcceptsReturn = True
			Me.txtM.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtM.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtM.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtM.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtM, "M Dimension (Air-Balanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtM, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtM As Global.System.Windows.Forms.Control = Me.txtM
			location = New Global.System.Drawing.Point(88, 3)
			txtM.Location = location
			Me.txtM.MaxLength = 10
			Me.txtM.Name = "txtM"
			Me.txtM.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtM, True)
			Dim txtM2 As Global.System.Windows.Forms.Control = Me.txtM
			size = New Global.System.Drawing.Size(65, 20)
			txtM2.Size = size
			Me.txtM.TabIndex = 20
			Me.txtM.Tag = "iee"
			Me.txtS.AcceptsReturn = True
			Me.txtS.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtS.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtS.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtS.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtS, "S Dimension (Air-Balanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtS, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtS As Global.System.Windows.Forms.Control = Me.txtS
			location = New Global.System.Drawing.Point(88, 26)
			txtS.Location = location
			Me.txtS.MaxLength = 10
			Me.txtS.Name = "txtS"
			Me.txtS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtS, True)
			Dim txtS2 As Global.System.Windows.Forms.Control = Me.txtS
			size = New Global.System.Drawing.Size(65, 20)
			txtS2.Size = size
			Me.txtS.TabIndex = 21
			Me.txtS.Tag = "pee"
			Me.txtV0.AcceptsReturn = True
			Me.txtV0.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtV0.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtV0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtV0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtV0, "V0 Dimension (Air-Balanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtV0, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtV As Global.System.Windows.Forms.Control = Me.txtV0
			location = New Global.System.Drawing.Point(232, 3)
			txtV.Location = location
			Me.txtV0.MaxLength = 10
			Me.txtV0.Name = "txtV0"
			Me.txtV0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtV0, True)
			Dim txtV2 As Global.System.Windows.Forms.Control = Me.txtV0
			size = New Global.System.Drawing.Size(65, 20)
			txtV2.Size = size
			Me.txtV0.TabIndex = 22
			Me.txtV0.Tag = "Iee"
			Me._Label_25.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_25.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_25.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_25.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_25.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_25, 25S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_25
			location = New Global.System.Drawing.Point(9, 8)
			label_.Location = location
			Me._Label_25.Name = "_Label_25"
			Me._Label_25.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_25, False)
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_25
			size = New Global.System.Drawing.Size(71, 19)
			label_2.Size = size
			Me._Label_25.TabIndex = 37
			Me._Label_25.Tag = "M (^):"
			Me._Label_25.Text = "M (in²):"
			Me._Label_25.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_26.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_26.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_26.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_26.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_26.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_26, 26S)
			Dim label_3 As Global.System.Windows.Forms.Control = Me._Label_26
			location = New Global.System.Drawing.Point(9, 31)
			label_3.Location = location
			Me._Label_26.Name = "_Label_26"
			Me._Label_26.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_26, False)
			Dim label_4 As Global.System.Windows.Forms.Control = Me._Label_26
			size = New Global.System.Drawing.Size(71, 19)
			label_4.Size = size
			Me._Label_26.TabIndex = 41
			Me._Label_26.Tag = "S (^):"
			Me._Label_26.Text = "S (psig):"
			Me._Label_26.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_27.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_27.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_27.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_27.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_27.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_27, 27S)
			Dim label_5 As Global.System.Windows.Forms.Control = Me._Label_27
			location = New Global.System.Drawing.Point(168, 8)
			label_5.Location = location
			Me._Label_27.Name = "_Label_27"
			Me._Label_27.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_27, False)
			Dim label_6 As Global.System.Windows.Forms.Control = Me._Label_27
			size = New Global.System.Drawing.Size(55, 18)
			label_6.Size = size
			Me._Label_27.TabIndex = 42
			Me._Label_27.Tag = "V0 (^):"
			Me._Label_27.Text = "V0 (in³):"
			Me._Label_27.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._panLowProfileBelt2.BackColor = Global.System.Drawing.SystemColors.Control
			Me._panLowProfileBelt2.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panLowProfileBelt2.Controls.Add(Me.txtTheta)
			Me._panLowProfileBelt2.Controls.Add(Me.lblTheta)
			Me._panLowProfileBelt2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panLowProfileBelt2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panLowProfileBelt2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim panLowProfileBelt As Global.System.Windows.Forms.Control = Me._panLowProfileBelt2
			location = New Global.System.Drawing.Point(336, 120)
			panLowProfileBelt.Location = location
			Me._panLowProfileBelt2.Name = "_panLowProfileBelt2"
			Me._panLowProfileBelt2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim panLowProfileBelt2 As Global.System.Windows.Forms.Control = Me._panLowProfileBelt2
			size = New Global.System.Drawing.Size(320, 88)
			panLowProfileBelt2.Size = size
			Me._panLowProfileBelt2.TabIndex = 153
			Me._panLowProfileBelt2.TabStop = True
			Me._panLowProfileBelt2.Visible = False
			Me.txtTheta.AcceptsReturn = True
			Me.txtTheta.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtTheta.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtTheta.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTheta.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtTheta, "Crank offset angle")
			Me.HelpProvider1.SetHelpNavigator(Me.txtTheta, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtTheta As Global.System.Windows.Forms.Control = Me.txtTheta
			location = New Global.System.Drawing.Point(196, 16)
			txtTheta.Location = location
			Me.txtTheta.MaxLength = 10
			Me.txtTheta.Name = "txtTheta"
			Me.txtTheta.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtTheta, True)
			Dim txtTheta2 As Global.System.Windows.Forms.Control = Me.txtTheta
			size = New Global.System.Drawing.Size(65, 22)
			txtTheta2.Size = size
			Me.txtTheta.TabIndex = 28
			Me.lblTheta.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblTheta.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblTheta.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblTheta.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lblTheta.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblTheta As Global.System.Windows.Forms.Control = Me.lblTheta
			location = New Global.System.Drawing.Point(8, 16)
			lblTheta.Location = location
			Me.lblTheta.Name = "lblTheta"
			Me.lblTheta.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblTheta2 As Global.System.Windows.Forms.Control = Me.lblTheta
			size = New Global.System.Drawing.Size(179, 18)
			lblTheta2.Size = size
			Me.lblTheta.TabIndex = 32
			Me.lblTheta.Text = "Crank offset angle (degrees):"
			Me.lblTheta.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me._panDimensions_3.BackColor = Global.System.Drawing.SystemColors.Control
			Me._panDimensions_3.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panDimensions_3.Controls.Add(Me.lblCrankCBMoment)
			Me._panDimensions_3.Controls.Add(Me.txtCrankCBMoment)
			Me._panDimensions_3.Controls.Add(Me.txtUnbalance)
			Me._panDimensions_3.Controls.Add(Me.txtCrankOffset)
			Me._panDimensions_3.Controls.Add(Me._Label_23)
			Me._panDimensions_3.Controls.Add(Me._Label_24)
			Me._panDimensions_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panDimensions_3.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panDimensions_3.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.panDimensions.SetIndex(Me._panDimensions_3, 3S)
			Dim panDimensions_3 As Global.System.Windows.Forms.Control = Me._panDimensions_3
			location = New Global.System.Drawing.Point(336, 120)
			panDimensions_3.Location = location
			Me._panDimensions_3.Name = "_panDimensions_3"
			Me._panDimensions_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panDimensions_3, False)
			Dim panDimensions_4 As Global.System.Windows.Forms.Control = Me._panDimensions_3
			size = New Global.System.Drawing.Size(320, 88)
			panDimensions_4.Size = size
			Me._panDimensions_3.TabIndex = 28
			Me._panDimensions_3.TabStop = True
			Me._panDimensions_3.Visible = False
			Me.lblCrankCBMoment.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblCrankCBMoment As Global.System.Windows.Forms.Control = Me.lblCrankCBMoment
			location = New Global.System.Drawing.Point(0, 53)
			lblCrankCBMoment.Location = location
			Me.lblCrankCBMoment.Name = "lblCrankCBMoment"
			Dim lblCrankCBMoment2 As Global.System.Windows.Forms.Control = Me.lblCrankCBMoment
			size = New Global.System.Drawing.Size(224, 16)
			lblCrankCBMoment2.Size = size
			Me.lblCrankCBMoment.TabIndex = 36
			Me.lblCrankCBMoment.Text = "Crank CB moment (M in-lbs):"
			Me.lblCrankCBMoment.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.lblCrankCBMoment.Visible = False
			Me.HelpProvider1.SetHelpKeyword(Me.txtCrankCBMoment, "Crank CB Moment (Beam Balanced)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtCrankCBMoment, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtCrankCBMoment As Global.System.Windows.Forms.Control = Me.txtCrankCBMoment
			location = New Global.System.Drawing.Point(240, 50)
			txtCrankCBMoment.Location = location
			Me.txtCrankCBMoment.Name = "txtCrankCBMoment"
			Me.HelpProvider1.SetShowHelp(Me.txtCrankCBMoment, True)
			Dim txtCrankCBMoment2 As Global.System.Windows.Forms.Control = Me.txtCrankCBMoment
			size = New Global.System.Drawing.Size(65, 20)
			txtCrankCBMoment2.Size = size
			Me.txtCrankCBMoment.TabIndex = 22
			Me.txtCrankCBMoment.Tag = "Lee"
			Me.txtCrankCBMoment.Visible = False
			Me.txtUnbalance.AcceptsReturn = True
			Me.txtUnbalance.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtUnbalance.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtUnbalance.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtUnbalance.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtUnbalance, "Custom pumping unit structural unbalance")
			Me.HelpProvider1.SetHelpNavigator(Me.txtUnbalance, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtUnbalance As Global.System.Windows.Forms.Control = Me.txtUnbalance
			location = New Global.System.Drawing.Point(240, 3)
			txtUnbalance.Location = location
			Me.txtUnbalance.MaxLength = 10
			Me.txtUnbalance.Name = "txtUnbalance"
			Me.txtUnbalance.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtUnbalance, True)
			Dim txtUnbalance2 As Global.System.Windows.Forms.Control = Me.txtUnbalance
			size = New Global.System.Drawing.Size(65, 20)
			txtUnbalance2.Size = size
			Me.txtUnbalance.TabIndex = 20
			Me.txtUnbalance.Tag = "lee"
			Me.txtCrankOffset.AcceptsReturn = True
			Me.txtCrankOffset.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtCrankOffset.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtCrankOffset.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtCrankOffset.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtCrankOffset, "Crank offset angle")
			Me.HelpProvider1.SetHelpNavigator(Me.txtCrankOffset, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtCrankOffset As Global.System.Windows.Forms.Control = Me.txtCrankOffset
			location = New Global.System.Drawing.Point(240, 26)
			txtCrankOffset.Location = location
			Me.txtCrankOffset.MaxLength = 10
			Me.txtCrankOffset.Name = "txtCrankOffset"
			Me.txtCrankOffset.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtCrankOffset, True)
			Dim txtCrankOffset2 As Global.System.Windows.Forms.Control = Me.txtCrankOffset
			size = New Global.System.Drawing.Size(65, 20)
			txtCrankOffset2.Size = size
			Me.txtCrankOffset.TabIndex = 21
			Me._Label_23.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_23.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_23.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_23.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_23.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_23, 23S)
			Dim label_7 As Global.System.Windows.Forms.Control = Me._Label_23
			location = New Global.System.Drawing.Point(0, 9)
			label_7.Location = location
			Me._Label_23.Name = "_Label_23"
			Me._Label_23.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_23, False)
			Dim label_8 As Global.System.Windows.Forms.Control = Me._Label_23
			size = New Global.System.Drawing.Size(224, 18)
			label_8.Size = size
			Me._Label_23.TabIndex = 31
			Me._Label_23.Tag = "Structural unbalance (^):"
			Me._Label_23.Text = "Structural unbalance (lbs):"
			Me._Label_23.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_24.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_24.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_24.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_24.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_24.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_24, 24S)
			Dim label_9 As Global.System.Windows.Forms.Control = Me._Label_24
			location = New Global.System.Drawing.Point(0, 31)
			label_9.Location = location
			Me._Label_24.Name = "_Label_24"
			Me._Label_24.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_24, False)
			Dim label_10 As Global.System.Windows.Forms.Control = Me._Label_24
			size = New Global.System.Drawing.Size(224, 18)
			label_10.Size = size
			Me._Label_24.TabIndex = 32
			Me._Label_24.Text = "Crank offset angle (degrees):"
			Me._Label_24.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me._panDimensions_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._panDimensions_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panDimensions_0.Controls.Add(Me.cboCrankHoles)
			Me._panDimensions_0.Controls.Add(Me._Label_8)
			Me._panDimensions_0.Controls.Add(Me._Label_13)
			Me._panDimensions_0.Controls.Add(Me._Label_12)
			Me._panDimensions_0.Controls.Add(Me._Label_11)
			Me._panDimensions_0.Controls.Add(Me._Label_10)
			Me._panDimensions_0.Controls.Add(Me._Label_9)
			Me._panDimensions_0.Controls.Add(Me._Label_29)
			Me._panDimensions_0.Controls.Add(Me._panCalcStroke_5)
			Me._panDimensions_0.Controls.Add(Me._panCalcStroke_4)
			Me._panDimensions_0.Controls.Add(Me._panCalcStroke_3)
			Me._panDimensions_0.Controls.Add(Me._panCalcStroke_2)
			Me._panDimensions_0.Controls.Add(Me._panCalcStroke_1)
			Me._panDimensions_0.Controls.Add(Me._txtR_4)
			Me._panDimensions_0.Controls.Add(Me._txtR_3)
			Me._panDimensions_0.Controls.Add(Me._txtR_2)
			Me._panDimensions_0.Controls.Add(Me._txtR_4_disabled)
			Me._panDimensions_0.Controls.Add(Me._txtR_3_disabled)
			Me._panDimensions_0.Controls.Add(Me._txtR_2_disabled)
			Me._panDimensions_0.Controls.Add(Me._txtR_5)
			Me._panDimensions_0.Controls.Add(Me._txtR_5_disabled)
			Me._panDimensions_0.Controls.Add(Me._txtR_1)
			Me._panDimensions_0.Controls.Add(Me._txtR_1_disabled)
			Me._panDimensions_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panDimensions_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panDimensions_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.panDimensions.SetIndex(Me._panDimensions_0, 0S)
			Dim panDimensions_5 As Global.System.Windows.Forms.Control = Me._panDimensions_0
			location = New Global.System.Drawing.Point(2, 24)
			panDimensions_5.Location = location
			Me._panDimensions_0.Name = "_panDimensions_0"
			Me._panDimensions_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panDimensions_0, False)
			Dim panDimensions_6 As Global.System.Windows.Forms.Control = Me._panDimensions_0
			size = New Global.System.Drawing.Size(326, 184)
			panDimensions_6.Size = size
			Me._panDimensions_0.TabIndex = 49
			Me._panDimensions_0.TabStop = True
			Me._panDimensions_0.Tag = "k"
			Me._panDimensions_0.Visible = False
			Me.cboCrankHoles.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboCrankHoles.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboCrankHoles.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboCrankHoles.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboCrankHoles, "Number of Crank Holes")
			Me.HelpProvider1.SetHelpNavigator(Me.cboCrankHoles, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboCrankHoles.ItemHeight = 14
			Me.cboCrankHoles.Items.AddRange(New Object() { "1", "2", "3", "4", "5" })
			Dim cboCrankHoles As Global.System.Windows.Forms.Control = Me.cboCrankHoles
			location = New Global.System.Drawing.Point(128, 20)
			cboCrankHoles.Location = location
			Me.cboCrankHoles.Name = "cboCrankHoles"
			Me.cboCrankHoles.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboCrankHoles, True)
			Dim cboCrankHoles2 As Global.System.Windows.Forms.Control = Me.cboCrankHoles
			size = New Global.System.Drawing.Size(65, 22)
			cboCrankHoles2.Size = size
			Me.cboCrankHoles.TabIndex = 9
			Me._Label_8.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_8.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_8.Font = New Global.System.Drawing.Font("Arial", 9F)
			Me._Label_8.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_8.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_8, 8S)
			Dim label_11 As Global.System.Windows.Forms.Control = Me._Label_8
			location = New Global.System.Drawing.Point(8, 26)
			label_11.Location = location
			Me._Label_8.Name = "_Label_8"
			Me._Label_8.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_8, False)
			Dim label_12 As Global.System.Windows.Forms.Control = Me._Label_8
			size = New Global.System.Drawing.Size(112, 17)
			label_12.Size = size
			Me._Label_8.TabIndex = 45
			Me._Label_8.Text = "Crank holes:"
			Me._Label_8.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_13.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_13.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_13.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_13.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_13.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_13, 13S)
			Dim label_13 As Global.System.Windows.Forms.Control = Me._Label_13
			location = New Global.System.Drawing.Point(8, 144)
			label_13.Location = location
			Me._Label_13.Name = "_Label_13"
			Me._Label_13.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_13, False)
			Dim label_14 As Global.System.Windows.Forms.Control = Me._Label_13
			size = New Global.System.Drawing.Size(112, 19)
			label_14.Size = size
			Me._Label_13.TabIndex = 46
			Me._Label_13.Tag = "R #5 (^):"
			Me._Label_13.Text = "R #5 (in):"
			Me._Label_13.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_12.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_12.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_12.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_12.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_12.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_12, 12S)
			Dim label_15 As Global.System.Windows.Forms.Control = Me._Label_12
			location = New Global.System.Drawing.Point(8, 121)
			label_15.Location = location
			Me._Label_12.Name = "_Label_12"
			Me._Label_12.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_12, False)
			Dim label_16 As Global.System.Windows.Forms.Control = Me._Label_12
			size = New Global.System.Drawing.Size(112, 19)
			label_16.Size = size
			Me._Label_12.TabIndex = 60
			Me._Label_12.Tag = "R #4 (^):"
			Me._Label_12.Text = "R #4 (in):"
			Me._Label_12.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_11.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_11.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_11.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_11.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_11.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_11, 11S)
			Dim label_17 As Global.System.Windows.Forms.Control = Me._Label_11
			location = New Global.System.Drawing.Point(8, 98)
			label_17.Location = location
			Me._Label_11.Name = "_Label_11"
			Me._Label_11.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_11, False)
			Dim label_18 As Global.System.Windows.Forms.Control = Me._Label_11
			size = New Global.System.Drawing.Size(112, 19)
			label_18.Size = size
			Me._Label_11.TabIndex = 61
			Me._Label_11.Tag = "R #3 (^):"
			Me._Label_11.Text = "R #3 (in):"
			Me._Label_11.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_10.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_10.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_10.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_10.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_10.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_10, 10S)
			Dim label_19 As Global.System.Windows.Forms.Control = Me._Label_10
			location = New Global.System.Drawing.Point(8, 75)
			label_19.Location = location
			Me._Label_10.Name = "_Label_10"
			Me._Label_10.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_10, False)
			Dim label_20 As Global.System.Windows.Forms.Control = Me._Label_10
			size = New Global.System.Drawing.Size(112, 19)
			label_20.Size = size
			Me._Label_10.TabIndex = 63
			Me._Label_10.Tag = "R #2 (^):"
			Me._Label_10.Text = "R #2 (in):"
			Me._Label_10.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_9.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_9.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_9.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_9.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_9.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_9, 9S)
			Dim label_21 As Global.System.Windows.Forms.Control = Me._Label_9
			location = New Global.System.Drawing.Point(8, 52)
			label_21.Location = location
			Me._Label_9.Name = "_Label_9"
			Me._Label_9.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_9, False)
			Dim label_22 As Global.System.Windows.Forms.Control = Me._Label_9
			size = New Global.System.Drawing.Size(112, 19)
			label_22.Size = size
			Me._Label_9.TabIndex = 65
			Me._Label_9.Tag = "R #1 (^):"
			Me._Label_9.Text = "R #1 (in):"
			Me._Label_9.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_29.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_29.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_29.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_29.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_29.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_29, 29S)
			Dim label_23 As Global.System.Windows.Forms.Control = Me._Label_29
			location = New Global.System.Drawing.Point(208, 2)
			label_23.Location = location
			Me._Label_29.Name = "_Label_29"
			Me._Label_29.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_29, False)
			Dim label_24 As Global.System.Windows.Forms.Control = Me._Label_29
			size = New Global.System.Drawing.Size(104, 43)
			label_24.Size = size
			Me._Label_29.TabIndex = 66
			Me._Label_29.Tag = "Calculated stroke length (^):"
			Me._Label_29.Text = "Calculated stroke length (in):"
			Me._Label_29.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me._panCalcStroke_5.BackColor = Global.System.Drawing.Color.Transparent
			Me._panCalcStroke_5.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panCalcStroke_5.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panCalcStroke_5.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panCalcStroke_5.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._panCalcStroke_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.panCalcStroke.SetIndex(Me._panCalcStroke_5, 5S)
			Dim panCalcStroke_ As Global.System.Windows.Forms.Control = Me._panCalcStroke_5
			location = New Global.System.Drawing.Point(232, 138)
			panCalcStroke_.Location = location
			Me._panCalcStroke_5.Name = "_panCalcStroke_5"
			Me._panCalcStroke_5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panCalcStroke_5, False)
			Dim panCalcStroke_2 As Global.System.Windows.Forms.Control = Me._panCalcStroke_5
			size = New Global.System.Drawing.Size(65, 23)
			panCalcStroke_2.Size = size
			Me._panCalcStroke_5.TabIndex = 50
			Me._panCalcStroke_4.BackColor = Global.System.Drawing.Color.Transparent
			Me._panCalcStroke_4.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panCalcStroke_4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panCalcStroke_4.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panCalcStroke_4.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._panCalcStroke_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.panCalcStroke.SetIndex(Me._panCalcStroke_4, 4S)
			Dim panCalcStroke_3 As Global.System.Windows.Forms.Control = Me._panCalcStroke_4
			location = New Global.System.Drawing.Point(232, 115)
			panCalcStroke_3.Location = location
			Me._panCalcStroke_4.Name = "_panCalcStroke_4"
			Me._panCalcStroke_4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panCalcStroke_4, False)
			Dim panCalcStroke_4 As Global.System.Windows.Forms.Control = Me._panCalcStroke_4
			size = New Global.System.Drawing.Size(65, 23)
			panCalcStroke_4.Size = size
			Me._panCalcStroke_4.TabIndex = 51
			Me._panCalcStroke_3.BackColor = Global.System.Drawing.Color.Transparent
			Me._panCalcStroke_3.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panCalcStroke_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panCalcStroke_3.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panCalcStroke_3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._panCalcStroke_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.panCalcStroke.SetIndex(Me._panCalcStroke_3, 3S)
			Dim panCalcStroke_5 As Global.System.Windows.Forms.Control = Me._panCalcStroke_3
			location = New Global.System.Drawing.Point(232, 92)
			panCalcStroke_5.Location = location
			Me._panCalcStroke_3.Name = "_panCalcStroke_3"
			Me._panCalcStroke_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panCalcStroke_3, False)
			Dim panCalcStroke_6 As Global.System.Windows.Forms.Control = Me._panCalcStroke_3
			size = New Global.System.Drawing.Size(65, 23)
			panCalcStroke_6.Size = size
			Me._panCalcStroke_3.TabIndex = 52
			Me._panCalcStroke_2.BackColor = Global.System.Drawing.Color.Transparent
			Me._panCalcStroke_2.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panCalcStroke_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panCalcStroke_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panCalcStroke_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._panCalcStroke_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.panCalcStroke.SetIndex(Me._panCalcStroke_2, 2S)
			Dim panCalcStroke_7 As Global.System.Windows.Forms.Control = Me._panCalcStroke_2
			location = New Global.System.Drawing.Point(232, 69)
			panCalcStroke_7.Location = location
			Me._panCalcStroke_2.Name = "_panCalcStroke_2"
			Me._panCalcStroke_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panCalcStroke_2, False)
			Dim panCalcStroke_8 As Global.System.Windows.Forms.Control = Me._panCalcStroke_2
			size = New Global.System.Drawing.Size(65, 23)
			panCalcStroke_8.Size = size
			Me._panCalcStroke_2.TabIndex = 58
			Me._panCalcStroke_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._panCalcStroke_1.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panCalcStroke_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panCalcStroke_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panCalcStroke_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._panCalcStroke_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.panCalcStroke.SetIndex(Me._panCalcStroke_1, 1S)
			Dim panCalcStroke_9 As Global.System.Windows.Forms.Control = Me._panCalcStroke_1
			location = New Global.System.Drawing.Point(232, 46)
			panCalcStroke_9.Location = location
			Me._panCalcStroke_1.Name = "_panCalcStroke_1"
			Me._panCalcStroke_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panCalcStroke_1, False)
			Dim panCalcStroke_10 As Global.System.Windows.Forms.Control = Me._panCalcStroke_1
			size = New Global.System.Drawing.Size(65, 23)
			panCalcStroke_10.Size = size
			Me._panCalcStroke_1.TabIndex = 59
			Me._txtR_4.AcceptsReturn = True
			Me._txtR_4.BackColor = Global.System.Drawing.SystemColors.Window
			Me._txtR_4.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me._txtR_4.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._txtR_4.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me._txtR_4, "custom pumping unit: R pumping unit dimension")
			Me.HelpProvider1.SetHelpNavigator(Me._txtR_4, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.txtR.SetIndex(Me._txtR_4, 4S)
			Dim txtR_ As Global.System.Windows.Forms.Control = Me._txtR_4
			location = New Global.System.Drawing.Point(128, 116)
			txtR_.Location = location
			Me._txtR_4.MaxLength = 10
			Me._txtR_4.Name = "_txtR_4"
			Me._txtR_4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._txtR_4, True)
			Dim txtR_2 As Global.System.Windows.Forms.Control = Me._txtR_4
			size = New Global.System.Drawing.Size(65, 20)
			txtR_2.Size = size
			Me._txtR_4.TabIndex = 13
			Me._txtR_4.Tag = "cee"
			Me._txtR_3.AcceptsReturn = True
			Me._txtR_3.BackColor = Global.System.Drawing.SystemColors.Window
			Me._txtR_3.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me._txtR_3.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._txtR_3.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me._txtR_3, "custom pumping unit: R pumping unit dimension")
			Me.HelpProvider1.SetHelpNavigator(Me._txtR_3, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.txtR.SetIndex(Me._txtR_3, 3S)
			Dim txtR_3 As Global.System.Windows.Forms.Control = Me._txtR_3
			location = New Global.System.Drawing.Point(128, 93)
			txtR_3.Location = location
			Me._txtR_3.MaxLength = 10
			Me._txtR_3.Name = "_txtR_3"
			Me._txtR_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._txtR_3, True)
			Dim txtR_4 As Global.System.Windows.Forms.Control = Me._txtR_3
			size = New Global.System.Drawing.Size(65, 20)
			txtR_4.Size = size
			Me._txtR_3.TabIndex = 12
			Me._txtR_3.Tag = "cee"
			Me._txtR_2.AcceptsReturn = True
			Me._txtR_2.BackColor = Global.System.Drawing.SystemColors.Window
			Me._txtR_2.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me._txtR_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._txtR_2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me._txtR_2, "custom pumping unit: R pumping unit dimension")
			Me.HelpProvider1.SetHelpNavigator(Me._txtR_2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.txtR.SetIndex(Me._txtR_2, 2S)
			Dim txtR_5 As Global.System.Windows.Forms.Control = Me._txtR_2
			location = New Global.System.Drawing.Point(128, 70)
			txtR_5.Location = location
			Me._txtR_2.MaxLength = 10
			Me._txtR_2.Name = "_txtR_2"
			Me._txtR_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._txtR_2, True)
			Dim txtR_6 As Global.System.Windows.Forms.Control = Me._txtR_2
			size = New Global.System.Drawing.Size(65, 20)
			txtR_6.Size = size
			Me._txtR_2.TabIndex = 11
			Me._txtR_2.Tag = "cee"
			Me._txtR_4_disabled.BackColor = Global.System.Drawing.Color.Transparent
			Me._txtR_4_disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._txtR_4_disabled.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._txtR_4_disabled.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._txtR_4_disabled.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._txtR_4_disabled.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtR_4_disabled As Global.System.Windows.Forms.Control = Me._txtR_4_disabled
			location = New Global.System.Drawing.Point(128, 116)
			txtR_4_disabled.Location = location
			Me._txtR_4_disabled.Name = "_txtR_4_disabled"
			Me._txtR_4_disabled.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._txtR_4_disabled, False)
			Dim txtR_4_disabled2 As Global.System.Windows.Forms.Control = Me._txtR_4_disabled
			size = New Global.System.Drawing.Size(65, 21)
			txtR_4_disabled2.Size = size
			Me._txtR_4_disabled.TabIndex = 68
			Me._txtR_3_disabled.BackColor = Global.System.Drawing.Color.Transparent
			Me._txtR_3_disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._txtR_3_disabled.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._txtR_3_disabled.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._txtR_3_disabled.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._txtR_3_disabled.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtR_3_disabled As Global.System.Windows.Forms.Control = Me._txtR_3_disabled
			location = New Global.System.Drawing.Point(128, 93)
			txtR_3_disabled.Location = location
			Me._txtR_3_disabled.Name = "_txtR_3_disabled"
			Me._txtR_3_disabled.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._txtR_3_disabled, False)
			Dim txtR_3_disabled2 As Global.System.Windows.Forms.Control = Me._txtR_3_disabled
			size = New Global.System.Drawing.Size(65, 21)
			txtR_3_disabled2.Size = size
			Me._txtR_3_disabled.TabIndex = 69
			Me._txtR_2_disabled.BackColor = Global.System.Drawing.Color.Transparent
			Me._txtR_2_disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._txtR_2_disabled.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._txtR_2_disabled.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._txtR_2_disabled.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._txtR_2_disabled.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtR_2_disabled As Global.System.Windows.Forms.Control = Me._txtR_2_disabled
			location = New Global.System.Drawing.Point(128, 70)
			txtR_2_disabled.Location = location
			Me._txtR_2_disabled.Name = "_txtR_2_disabled"
			Me._txtR_2_disabled.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._txtR_2_disabled, False)
			Dim txtR_2_disabled2 As Global.System.Windows.Forms.Control = Me._txtR_2_disabled
			size = New Global.System.Drawing.Size(65, 21)
			txtR_2_disabled2.Size = size
			Me._txtR_2_disabled.TabIndex = 70
			Me._txtR_5.AcceptsReturn = True
			Me._txtR_5.BackColor = Global.System.Drawing.SystemColors.Window
			Me._txtR_5.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me._txtR_5.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._txtR_5.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me._txtR_5, "custom pumping unit: R pumping unit dimension")
			Me.HelpProvider1.SetHelpNavigator(Me._txtR_5, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.txtR.SetIndex(Me._txtR_5, 5S)
			Dim txtR_7 As Global.System.Windows.Forms.Control = Me._txtR_5
			location = New Global.System.Drawing.Point(128, 139)
			txtR_7.Location = location
			Me._txtR_5.MaxLength = 10
			Me._txtR_5.Name = "_txtR_5"
			Me._txtR_5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._txtR_5, True)
			Dim txtR_8 As Global.System.Windows.Forms.Control = Me._txtR_5
			size = New Global.System.Drawing.Size(65, 20)
			txtR_8.Size = size
			Me._txtR_5.TabIndex = 14
			Me._txtR_5.Tag = "cee"
			Me._txtR_5_disabled.BackColor = Global.System.Drawing.Color.Transparent
			Me._txtR_5_disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._txtR_5_disabled.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._txtR_5_disabled.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._txtR_5_disabled.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._txtR_5_disabled.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtR_5_disabled As Global.System.Windows.Forms.Control = Me._txtR_5_disabled
			location = New Global.System.Drawing.Point(128, 139)
			txtR_5_disabled.Location = location
			Me._txtR_5_disabled.Name = "_txtR_5_disabled"
			Me._txtR_5_disabled.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._txtR_5_disabled, False)
			Dim txtR_5_disabled2 As Global.System.Windows.Forms.Control = Me._txtR_5_disabled
			size = New Global.System.Drawing.Size(65, 21)
			txtR_5_disabled2.Size = size
			Me._txtR_5_disabled.TabIndex = 67
			Me._txtR_1.AcceptsReturn = True
			Me._txtR_1.BackColor = Global.System.Drawing.SystemColors.Window
			Me._txtR_1.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me._txtR_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._txtR_1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me._txtR_1, "custom pumping unit: R pumping unit dimension")
			Me.HelpProvider1.SetHelpNavigator(Me._txtR_1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.txtR.SetIndex(Me._txtR_1, 1S)
			Dim txtR_9 As Global.System.Windows.Forms.Control = Me._txtR_1
			location = New Global.System.Drawing.Point(128, 47)
			txtR_9.Location = location
			Me._txtR_1.MaxLength = 10
			Me._txtR_1.Name = "_txtR_1"
			Me._txtR_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._txtR_1, True)
			Dim txtR_10 As Global.System.Windows.Forms.Control = Me._txtR_1
			size = New Global.System.Drawing.Size(65, 20)
			txtR_10.Size = size
			Me._txtR_1.TabIndex = 10
			Me._txtR_1.Tag = "cee"
			Me._txtR_1_disabled.BackColor = Global.System.Drawing.Color.Transparent
			Me._txtR_1_disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._txtR_1_disabled.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._txtR_1_disabled.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._txtR_1_disabled.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._txtR_1_disabled.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtR_1_disabled As Global.System.Windows.Forms.Control = Me._txtR_1_disabled
			location = New Global.System.Drawing.Point(128, 48)
			txtR_1_disabled.Location = location
			Me._txtR_1_disabled.Name = "_txtR_1_disabled"
			Me._txtR_1_disabled.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._txtR_1_disabled, False)
			Dim txtR_1_disabled2 As Global.System.Windows.Forms.Control = Me._txtR_1_disabled
			size = New Global.System.Drawing.Size(65, 21)
			txtR_1_disabled2.Size = size
			Me._txtR_1_disabled.TabIndex = 71
			Me._panDimensions_longstroke.BackColor = Global.System.Drawing.SystemColors.Control
			Me._panDimensions_longstroke.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panDimensions_longstroke.Controls.Add(Me.txtPitmanLength)
			Me._panDimensions_longstroke.Controls.Add(Me.txtDrumDiamRatio)
			Me._panDimensions_longstroke.Controls.Add(Me.txtSprocketDistance)
			Me._panDimensions_longstroke.Controls.Add(Me.txtSprocketDiameter)
			Me._panDimensions_longstroke.Controls.Add(Me._panCalcStroke_0)
			Me._panDimensions_longstroke.Controls.Add(Me._Label_30)
			Me._panDimensions_longstroke.Controls.Add(Me._Label_17)
			Me._panDimensions_longstroke.Controls.Add(Me._Label_16)
			Me._panDimensions_longstroke.Controls.Add(Me._Label_15)
			Me._panDimensions_longstroke.Controls.Add(Me._Label_14)
			Me._panDimensions_longstroke.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panDimensions_longstroke.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panDimensions_longstroke.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.panDimensions.SetIndex(Me._panDimensions_longstroke, 1S)
			Dim panDimensions_longstroke As Global.System.Windows.Forms.Control = Me._panDimensions_longstroke
			location = New Global.System.Drawing.Point(2, 24)
			panDimensions_longstroke.Location = location
			Me._panDimensions_longstroke.Name = "_panDimensions_longstroke"
			Me._panDimensions_longstroke.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panDimensions_longstroke, False)
			Dim panDimensions_longstroke2 As Global.System.Windows.Forms.Control = Me._panDimensions_longstroke
			size = New Global.System.Drawing.Size(254, 176)
			panDimensions_longstroke2.Size = size
			Me._panDimensions_longstroke.TabIndex = 29
			Me._panDimensions_longstroke.TabStop = True
			Me._panDimensions_longstroke.Visible = False
			Me.txtPitmanLength.AcceptsReturn = True
			Me.txtPitmanLength.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPitmanLength.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPitmanLength.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtPitmanLength.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtPitmanLength, "Pitman Arm Length (Long Stroke Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtPitmanLength, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtPitmanLength As Global.System.Windows.Forms.Control = Me.txtPitmanLength
			location = New Global.System.Drawing.Point(177, 73)
			txtPitmanLength.Location = location
			Me.txtPitmanLength.MaxLength = 10
			Me.txtPitmanLength.Name = "txtPitmanLength"
			Me.txtPitmanLength.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtPitmanLength, True)
			Dim txtPitmanLength2 As Global.System.Windows.Forms.Control = Me.txtPitmanLength
			size = New Global.System.Drawing.Size(65, 20)
			txtPitmanLength2.Size = size
			Me.txtPitmanLength.TabIndex = 17
			Me.txtPitmanLength.Tag = "cee"
			Me.txtDrumDiamRatio.AcceptsReturn = True
			Me.txtDrumDiamRatio.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtDrumDiamRatio.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtDrumDiamRatio.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtDrumDiamRatio.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtDrumDiamRatio, "custom pumping unit: top drum diameter ratio")
			Me.HelpProvider1.SetHelpNavigator(Me.txtDrumDiamRatio, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtDrumDiamRatio As Global.System.Windows.Forms.Control = Me.txtDrumDiamRatio
			location = New Global.System.Drawing.Point(177, 50)
			txtDrumDiamRatio.Location = location
			Me.txtDrumDiamRatio.MaxLength = 10
			Me.txtDrumDiamRatio.Name = "txtDrumDiamRatio"
			Me.txtDrumDiamRatio.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtDrumDiamRatio, True)
			Dim txtDrumDiamRatio2 As Global.System.Windows.Forms.Control = Me.txtDrumDiamRatio
			size = New Global.System.Drawing.Size(65, 20)
			txtDrumDiamRatio2.Size = size
			Me.txtDrumDiamRatio.TabIndex = 16
			Me.txtSprocketDistance.AcceptsReturn = True
			Me.txtSprocketDistance.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtSprocketDistance.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtSprocketDistance.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtSprocketDistance.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtSprocketDistance, "custom pumping unit: sprocket distance")
			Me.HelpProvider1.SetHelpNavigator(Me.txtSprocketDistance, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtSprocketDistance As Global.System.Windows.Forms.Control = Me.txtSprocketDistance
			location = New Global.System.Drawing.Point(177, 27)
			txtSprocketDistance.Location = location
			Me.txtSprocketDistance.MaxLength = 10
			Me.txtSprocketDistance.Name = "txtSprocketDistance"
			Me.txtSprocketDistance.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtSprocketDistance, True)
			Dim txtSprocketDistance2 As Global.System.Windows.Forms.Control = Me.txtSprocketDistance
			size = New Global.System.Drawing.Size(65, 20)
			txtSprocketDistance2.Size = size
			Me.txtSprocketDistance.TabIndex = 15
			Me.txtSprocketDistance.Tag = "cee"
			Me.txtSprocketDiameter.AcceptsReturn = True
			Me.txtSprocketDiameter.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtSprocketDiameter.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtSprocketDiameter.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtSprocketDiameter.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtSprocketDiameter, "custom pumping unit: sprocket diameter")
			Me.HelpProvider1.SetHelpNavigator(Me.txtSprocketDiameter, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtSprocketDiameter As Global.System.Windows.Forms.Control = Me.txtSprocketDiameter
			location = New Global.System.Drawing.Point(177, 4)
			txtSprocketDiameter.Location = location
			Me.txtSprocketDiameter.MaxLength = 10
			Me.txtSprocketDiameter.Name = "txtSprocketDiameter"
			Me.txtSprocketDiameter.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtSprocketDiameter, True)
			Dim txtSprocketDiameter2 As Global.System.Windows.Forms.Control = Me.txtSprocketDiameter
			size = New Global.System.Drawing.Size(65, 20)
			txtSprocketDiameter2.Size = size
			Me.txtSprocketDiameter.TabIndex = 14
			Me.txtSprocketDiameter.Tag = "mee"
			Me._panCalcStroke_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._panCalcStroke_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panCalcStroke_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panCalcStroke_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panCalcStroke_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._panCalcStroke_0, "")
			Me.HelpProvider1.SetHelpNavigator(Me._panCalcStroke_0, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._panCalcStroke_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.panCalcStroke.SetIndex(Me._panCalcStroke_0, 0S)
			Dim panCalcStroke_11 As Global.System.Windows.Forms.Control = Me._panCalcStroke_0
			location = New Global.System.Drawing.Point(177, 102)
			panCalcStroke_11.Location = location
			Me._panCalcStroke_0.Name = "_panCalcStroke_0"
			Me._panCalcStroke_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panCalcStroke_0, True)
			Dim panCalcStroke_12 As Global.System.Windows.Forms.Control = Me._panCalcStroke_0
			size = New Global.System.Drawing.Size(65, 23)
			panCalcStroke_12.Size = size
			Me._panCalcStroke_0.TabIndex = 30
			Me._Label_30.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_30.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_30.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_30.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_30.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_30, 30S)
			Dim label_25 As Global.System.Windows.Forms.Control = Me._Label_30
			location = New Global.System.Drawing.Point(6, 106)
			label_25.Location = location
			Me._Label_30.Name = "_Label_30"
			Me._Label_30.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_30, False)
			Dim label_26 As Global.System.Windows.Forms.Control = Me._Label_30
			size = New Global.System.Drawing.Size(162, 19)
			label_26.Size = size
			Me._Label_30.TabIndex = 34
			Me._Label_30.Tag = "Calc. stroke length (^):"
			Me._Label_30.Text = "Calc. stroke length (in):"
			Me._Label_17.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_17.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_17.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_17.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_17.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_17, 17S)
			Dim label_27 As Global.System.Windows.Forms.Control = Me._Label_17
			location = New Global.System.Drawing.Point(6, 77)
			label_27.Location = location
			Me._Label_17.Name = "_Label_17"
			Me._Label_17.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_17, False)
			Dim label_28 As Global.System.Windows.Forms.Control = Me._Label_17
			size = New Global.System.Drawing.Size(162, 18)
			label_28.Size = size
			Me._Label_17.TabIndex = 35
			Me._Label_17.Tag = "Pitman arm length (^):"
			Me._Label_17.Text = "Pitman arm length (in):"
			Me._Label_16.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_16.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_16.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_16.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_16.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_16, 16S)
			Dim label_29 As Global.System.Windows.Forms.Control = Me._Label_16
			location = New Global.System.Drawing.Point(6, 54)
			label_29.Location = location
			Me._Label_16.Name = "_Label_16"
			Me._Label_16.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_16, False)
			Dim label_30 As Global.System.Windows.Forms.Control = Me._Label_16
			size = New Global.System.Drawing.Size(162, 19)
			label_30.Size = size
			Me._Label_16.TabIndex = 36
			Me._Label_16.Text = "Drum diameter ratio:"
			Me._Label_15.AutoSize = True
			Me._Label_15.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_15.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_15.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_15.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_15.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_15, 15S)
			Dim label_31 As Global.System.Windows.Forms.Control = Me._Label_15
			location = New Global.System.Drawing.Point(6, 32)
			label_31.Location = location
			Me._Label_15.Name = "_Label_15"
			Me._Label_15.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_15, False)
			Dim label_32 As Global.System.Windows.Forms.Control = Me._Label_15
			size = New Global.System.Drawing.Size(172, 16)
			label_32.Size = size
			Me._Label_15.TabIndex = 43
			Me._Label_15.Tag = "Sprocket c'line distance (^):"
			Me._Label_15.Text = "Sprocket c'line distance (in):"
			Me._Label_14.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_14.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_14.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_14.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_14.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_14, 14S)
			Dim label_33 As Global.System.Windows.Forms.Control = Me._Label_14
			location = New Global.System.Drawing.Point(6, 9)
			label_33.Location = location
			Me._Label_14.Name = "_Label_14"
			Me._Label_14.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_14, False)
			Dim label_34 As Global.System.Windows.Forms.Control = Me._Label_14
			size = New Global.System.Drawing.Size(154, 19)
			label_34.Size = size
			Me._Label_14.TabIndex = 48
			Me._Label_14.Tag = "Sprocket diameter (^):"
			Me._Label_14.Text = "Sprocket diameter (in):"
			Me._panDimensions_2_MII.BackColor = Global.System.Drawing.SystemColors.Control
			Me._panDimensions_2_MII.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panDimensions_2_MII.Controls.Add(Me.txtP_MII)
			Me._panDimensions_2_MII.Controls.Add(Me.txtK_MII)
			Me._panDimensions_2_MII.Controls.Add(Me.txtI_MII)
			Me._panDimensions_2_MII.Controls.Add(Me.txtC_MII)
			Me._panDimensions_2_MII.Controls.Add(Me.txtA_MII)
			Me._panDimensions_2_MII.Controls.Add(Me.Label_A_MII)
			Me._panDimensions_2_MII.Controls.Add(Me.Label_C_MII)
			Me._panDimensions_2_MII.Controls.Add(Me.Label_I_MII)
			Me._panDimensions_2_MII.Controls.Add(Me.Label_K_MII)
			Me._panDimensions_2_MII.Controls.Add(Me.Label_P_MII)
			Me._panDimensions_2_MII.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panDimensions_2_MII.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panDimensions_2_MII.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim panDimensions_2_MII As Global.System.Windows.Forms.Control = Me._panDimensions_2_MII
			location = New Global.System.Drawing.Point(336, 24)
			panDimensions_2_MII.Location = location
			Me._panDimensions_2_MII.Name = "_panDimensions_2_MII"
			Me._panDimensions_2_MII.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panDimensions_2_MII, False)
			Dim panDimensions_2_MII2 As Global.System.Windows.Forms.Control = Me._panDimensions_2_MII
			size = New Global.System.Drawing.Size(320, 88)
			panDimensions_2_MII2.Size = size
			Me._panDimensions_2_MII.TabIndex = 53
			Me._panDimensions_2_MII.TabStop = True
			Me._panDimensions_2_MII.Visible = False
			Me.txtP_MII.AcceptsReturn = True
			Me.txtP_MII.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtP_MII.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtP_MII.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtP_MII.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtP_MII, "P Dimension (Mark II Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtP_MII, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtP_MII As Global.System.Windows.Forms.Control = Me.txtP_MII
			location = New Global.System.Drawing.Point(232, 27)
			txtP_MII.Location = location
			Me.txtP_MII.MaxLength = 10
			Me.txtP_MII.Name = "txtP_MII"
			Me.txtP_MII.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtP_MII, True)
			Dim txtP_MII2 As Global.System.Windows.Forms.Control = Me.txtP_MII
			size = New Global.System.Drawing.Size(65, 20)
			txtP_MII2.Size = size
			Me.txtP_MII.TabIndex = 19
			Me.txtP_MII.Tag = "cee"
			Me.txtK_MII.AcceptsReturn = True
			Me.txtK_MII.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtK_MII.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtK_MII.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtK_MII.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtK_MII, "K Dimension (Mark II Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtK_MII, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtK_MII As Global.System.Windows.Forms.Control = Me.txtK_MII
			location = New Global.System.Drawing.Point(232, 4)
			txtK_MII.Location = location
			Me.txtK_MII.MaxLength = 10
			Me.txtK_MII.Name = "txtK_MII"
			Me.txtK_MII.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtK_MII, True)
			Dim txtK_MII2 As Global.System.Windows.Forms.Control = Me.txtK_MII
			size = New Global.System.Drawing.Size(65, 20)
			txtK_MII2.Size = size
			Me.txtK_MII.TabIndex = 18
			Me.txtK_MII.Tag = "cee"
			Me.txtI_MII.AcceptsReturn = True
			Me.txtI_MII.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtI_MII.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtI_MII.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtI_MII.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtI_MII, "I Dimension (Mark II Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtI_MII, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtI_MII As Global.System.Windows.Forms.Control = Me.txtI_MII
			location = New Global.System.Drawing.Point(88, 49)
			txtI_MII.Location = location
			Me.txtI_MII.MaxLength = 10
			Me.txtI_MII.Name = "txtI_MII"
			Me.txtI_MII.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtI_MII, True)
			Dim txtI_MII2 As Global.System.Windows.Forms.Control = Me.txtI_MII
			size = New Global.System.Drawing.Size(65, 20)
			txtI_MII2.Size = size
			Me.txtI_MII.TabIndex = 17
			Me.txtI_MII.Tag = "cee"
			Me.txtC_MII.AcceptsReturn = True
			Me.txtC_MII.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtC_MII.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtC_MII.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtC_MII.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtC_MII, "C Dimension (Mark II Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtC_MII, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtC_MII As Global.System.Windows.Forms.Control = Me.txtC_MII
			location = New Global.System.Drawing.Point(88, 26)
			txtC_MII.Location = location
			Me.txtC_MII.MaxLength = 10
			Me.txtC_MII.Name = "txtC_MII"
			Me.txtC_MII.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtC_MII, True)
			Dim txtC_MII2 As Global.System.Windows.Forms.Control = Me.txtC_MII
			size = New Global.System.Drawing.Size(65, 20)
			txtC_MII2.Size = size
			Me.txtC_MII.TabIndex = 16
			Me.txtC_MII.Tag = "cee"
			Me.txtA_MII.AcceptsReturn = True
			Me.txtA_MII.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtA_MII.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtA_MII.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtA_MII.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtA_MII, "A Dimension (Mark II Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtA_MII, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtA_MII As Global.System.Windows.Forms.Control = Me.txtA_MII
			location = New Global.System.Drawing.Point(88, 3)
			txtA_MII.Location = location
			Me.txtA_MII.MaxLength = 10
			Me.txtA_MII.Name = "txtA_MII"
			Me.txtA_MII.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtA_MII, True)
			Dim txtA_MII2 As Global.System.Windows.Forms.Control = Me.txtA_MII
			size = New Global.System.Drawing.Size(65, 20)
			txtA_MII2.Size = size
			Me.txtA_MII.TabIndex = 15
			Me.txtA_MII.Tag = "cee"
			Me.Label_A_MII.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label_A_MII.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label_A_MII.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.Label_A_MII.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label_A_MII.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_A_MII As Global.System.Windows.Forms.Control = Me.Label_A_MII
			location = New Global.System.Drawing.Point(9, 9)
			label_A_MII.Location = location
			Me.Label_A_MII.Name = "Label_A_MII"
			Me.Label_A_MII.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label_A_MII, False)
			Dim label_A_MII2 As Global.System.Windows.Forms.Control = Me.Label_A_MII
			size = New Global.System.Drawing.Size(63, 19)
			label_A_MII2.Size = size
			Me.Label_A_MII.TabIndex = 53
			Me.Label_A_MII.Tag = "A (^):"
			Me.Label_A_MII.Text = "A (in):"
			Me.Label_A_MII.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.Label_C_MII.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label_C_MII.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label_C_MII.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.Label_C_MII.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label_C_MII.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_C_MII As Global.System.Windows.Forms.Control = Me.Label_C_MII
			location = New Global.System.Drawing.Point(9, 32)
			label_C_MII.Location = location
			Me.Label_C_MII.Name = "Label_C_MII"
			Me.Label_C_MII.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label_C_MII, False)
			Dim label_C_MII2 As Global.System.Windows.Forms.Control = Me.Label_C_MII
			size = New Global.System.Drawing.Size(63, 19)
			label_C_MII2.Size = size
			Me.Label_C_MII.TabIndex = 54
			Me.Label_C_MII.Tag = "C (^):"
			Me.Label_C_MII.Text = "C (in):"
			Me.Label_C_MII.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.Label_I_MII.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label_I_MII.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label_I_MII.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.Label_I_MII.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label_I_MII.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_I_MII As Global.System.Windows.Forms.Control = Me.Label_I_MII
			location = New Global.System.Drawing.Point(9, 55)
			label_I_MII.Location = location
			Me.Label_I_MII.Name = "Label_I_MII"
			Me.Label_I_MII.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label_I_MII, False)
			Dim label_I_MII2 As Global.System.Windows.Forms.Control = Me.Label_I_MII
			size = New Global.System.Drawing.Size(63, 19)
			label_I_MII2.Size = size
			Me.Label_I_MII.TabIndex = 55
			Me.Label_I_MII.Tag = "I (^):"
			Me.Label_I_MII.Text = "I (in):"
			Me.Label_I_MII.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.Label_K_MII.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label_K_MII.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label_K_MII.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.Label_K_MII.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label_K_MII.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_K_MII As Global.System.Windows.Forms.Control = Me.Label_K_MII
			location = New Global.System.Drawing.Point(168, 9)
			label_K_MII.Location = location
			Me.Label_K_MII.Name = "Label_K_MII"
			Me.Label_K_MII.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label_K_MII, False)
			Dim label_K_MII2 As Global.System.Windows.Forms.Control = Me.Label_K_MII
			size = New Global.System.Drawing.Size(55, 18)
			label_K_MII2.Size = size
			Me.Label_K_MII.TabIndex = 56
			Me.Label_K_MII.Tag = "K (^):"
			Me.Label_K_MII.Text = "K (in):"
			Me.Label_K_MII.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.Label_P_MII.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label_P_MII.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label_P_MII.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.Label_P_MII.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label_P_MII.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_P_MII As Global.System.Windows.Forms.Control = Me.Label_P_MII
			location = New Global.System.Drawing.Point(168, 32)
			label_P_MII.Location = location
			Me.Label_P_MII.Name = "Label_P_MII"
			Me.Label_P_MII.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label_P_MII, False)
			Dim label_P_MII2 As Global.System.Windows.Forms.Control = Me.Label_P_MII
			size = New Global.System.Drawing.Size(55, 18)
			label_P_MII2.Size = size
			Me.Label_P_MII.TabIndex = 57
			Me.Label_P_MII.Tag = "P (^):"
			Me.Label_P_MII.Text = "P (in):"
			Me.Label_P_MII.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._panLowProfileBelt1.BackColor = Global.System.Drawing.SystemColors.Control
			Me._panLowProfileBelt1.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panLowProfileBelt1.Controls.Add(Me.lblD)
			Me._panLowProfileBelt1.Controls.Add(Me.lblI)
			Me._panLowProfileBelt1.Controls.Add(Me.txtI_lp)
			Me._panLowProfileBelt1.Controls.Add(Me.lblK)
			Me._panLowProfileBelt1.Controls.Add(Me.txtK_LP)
			Me._panLowProfileBelt1.Controls.Add(Me.lblB)
			Me._panLowProfileBelt1.Controls.Add(Me.txtD_lp)
			Me._panLowProfileBelt1.Controls.Add(Me.txtB_lp)
			Me._panLowProfileBelt1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panLowProfileBelt1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panLowProfileBelt1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim panLowProfileBelt3 As Global.System.Windows.Forms.Control = Me._panLowProfileBelt1
			location = New Global.System.Drawing.Point(336, 24)
			panLowProfileBelt3.Location = location
			Me._panLowProfileBelt1.Name = "_panLowProfileBelt1"
			Me._panLowProfileBelt1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim panLowProfileBelt4 As Global.System.Windows.Forms.Control = Me._panLowProfileBelt1
			size = New Global.System.Drawing.Size(320, 88)
			panLowProfileBelt4.Size = size
			Me._panLowProfileBelt1.TabIndex = 152
			Me._panLowProfileBelt1.TabStop = True
			Me._panLowProfileBelt1.Visible = False
			Me.lblD.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblD.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblD.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblD.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblD.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblD As Global.System.Windows.Forms.Control = Me.lblD
			location = New Global.System.Drawing.Point(16, 9)
			lblD.Location = location
			Me.lblD.Name = "lblD"
			Me.lblD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblD2 As Global.System.Windows.Forms.Control = Me.lblD
			size = New Global.System.Drawing.Size(56, 19)
			lblD2.Size = size
			Me.lblD.TabIndex = 54
			Me.lblD.Tag = "D (^):"
			Me.lblD.Text = "D (in):"
			Me.lblD.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblI.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblI.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblI.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblI.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblI.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblI As Global.System.Windows.Forms.Control = Me.lblI
			location = New Global.System.Drawing.Point(168, 9)
			lblI.Location = location
			Me.lblI.Name = "lblI"
			Me.lblI.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblI2 As Global.System.Windows.Forms.Control = Me.lblI
			size = New Global.System.Drawing.Size(56, 19)
			lblI2.Size = size
			Me.lblI.TabIndex = 55
			Me.lblI.Tag = "l  (^):"
			Me.lblI.Text = "l  (in):"
			Me.lblI.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.txtI_lp.AcceptsReturn = True
			Me.txtI_lp.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtI_lp.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtI_lp.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtI_lp.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtI_lp, "I Dimension (Conventional and Enhanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtI_lp, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtI_lp As Global.System.Windows.Forms.Control = Me.txtI_lp
			location = New Global.System.Drawing.Point(232, 4)
			txtI_lp.Location = location
			Me.txtI_lp.MaxLength = 10
			Me.txtI_lp.Name = "txtI_lp"
			Me.txtI_lp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtI_lp, True)
			Dim txtI_lp2 As Global.System.Windows.Forms.Control = Me.txtI_lp
			size = New Global.System.Drawing.Size(65, 22)
			txtI_lp2.Size = size
			Me.txtI_lp.TabIndex = 24
			Me.txtI_lp.Tag = "cee"
			Me.lblK.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblK.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblK As Global.System.Windows.Forms.Control = Me.lblK
			location = New Global.System.Drawing.Point(168, 32)
			lblK.Location = location
			Me.lblK.Name = "lblK"
			Me.lblK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblK2 As Global.System.Windows.Forms.Control = Me.lblK
			size = New Global.System.Drawing.Size(55, 18)
			lblK2.Size = size
			Me.lblK.TabIndex = 57
			Me.lblK.Tag = "K (^):"
			Me.lblK.Text = "K (in):"
			Me.lblK.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.txtK_LP.AcceptsReturn = True
			Me.txtK_LP.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtK_LP.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtK_LP.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtK_LP.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtK_LP, "K Dimension (Conventional and Enhanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtK_LP, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtK_LP As Global.System.Windows.Forms.Control = Me.txtK_LP
			location = New Global.System.Drawing.Point(232, 26)
			txtK_LP.Location = location
			Me.txtK_LP.MaxLength = 10
			Me.txtK_LP.Name = "txtK_LP"
			Me.txtK_LP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtK_LP, True)
			Dim txtK_LP2 As Global.System.Windows.Forms.Control = Me.txtK_LP
			size = New Global.System.Drawing.Size(65, 22)
			txtK_LP2.Size = size
			Me.txtK_LP.TabIndex = 26
			Me.txtK_LP.Tag = "cee"
			Me.lblB.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblB.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblB.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblB.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblB.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblB As Global.System.Windows.Forms.Control = Me.lblB
			location = New Global.System.Drawing.Point(16, 9)
			lblB.Location = location
			Me.lblB.Name = "lblB"
			Me.lblB.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblB2 As Global.System.Windows.Forms.Control = Me.lblB
			size = New Global.System.Drawing.Size(56, 19)
			lblB2.Size = size
			Me.lblB.TabIndex = 53
			Me.lblB.Tag = "B (^):"
			Me.lblB.Text = "B (in):"
			Me.lblB.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblB.Visible = False
			Me.txtD_lp.AcceptsReturn = True
			Me.txtD_lp.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtD_lp.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtD_lp.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtD_lp.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtD_lp, "D dimension")
			Me.HelpProvider1.SetHelpNavigator(Me.txtD_lp, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtD_lp As Global.System.Windows.Forms.Control = Me.txtD_lp
			location = New Global.System.Drawing.Point(88, 4)
			txtD_lp.Location = location
			Me.txtD_lp.MaxLength = 10
			Me.txtD_lp.Name = "txtD_lp"
			Me.txtD_lp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtD_lp, True)
			Dim txtD_lp2 As Global.System.Windows.Forms.Control = Me.txtD_lp
			size = New Global.System.Drawing.Size(65, 22)
			txtD_lp2.Size = size
			Me.txtD_lp.TabIndex = 23
			Me.txtD_lp.Tag = "cee"
			Me.txtB_lp.AcceptsReturn = True
			Me.txtB_lp.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtB_lp.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtB_lp.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtB_lp.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtB_lp As Global.System.Windows.Forms.Control = Me.txtB_lp
			location = New Global.System.Drawing.Point(88, 3)
			txtB_lp.Location = location
			Me.txtB_lp.MaxLength = 10
			Me.txtB_lp.Name = "txtB_lp"
			Me.txtB_lp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtB_lp2 As Global.System.Windows.Forms.Control = Me.txtB_lp
			size = New Global.System.Drawing.Size(65, 22)
			txtB_lp2.Size = size
			Me.txtB_lp.TabIndex = 22
			Me.txtB_lp.Tag = "cee"
			Me.txtB_lp.Visible = False
			Me._panDimensions_2_ABAL.BackColor = Global.System.Drawing.SystemColors.Control
			Me._panDimensions_2_ABAL.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panDimensions_2_ABAL.Controls.Add(Me.txtP_ABAL)
			Me._panDimensions_2_ABAL.Controls.Add(Me.txtK_ABAL)
			Me._panDimensions_2_ABAL.Controls.Add(Me.txtI_ABAL)
			Me._panDimensions_2_ABAL.Controls.Add(Me.txtC_ABAL)
			Me._panDimensions_2_ABAL.Controls.Add(Me.txtA_ABAL)
			Me._panDimensions_2_ABAL.Controls.Add(Me.Label_A_ABAL)
			Me._panDimensions_2_ABAL.Controls.Add(Me.Label_C_ABAL)
			Me._panDimensions_2_ABAL.Controls.Add(Me.Label_I_ABAL)
			Me._panDimensions_2_ABAL.Controls.Add(Me.Label_K_ABAL)
			Me._panDimensions_2_ABAL.Controls.Add(Me.Label_P_ABAL)
			Me._panDimensions_2_ABAL.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panDimensions_2_ABAL.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panDimensions_2_ABAL.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim panDimensions_2_ABAL As Global.System.Windows.Forms.Control = Me._panDimensions_2_ABAL
			location = New Global.System.Drawing.Point(336, 24)
			panDimensions_2_ABAL.Location = location
			Me._panDimensions_2_ABAL.Name = "_panDimensions_2_ABAL"
			Me._panDimensions_2_ABAL.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panDimensions_2_ABAL, False)
			Dim panDimensions_2_ABAL2 As Global.System.Windows.Forms.Control = Me._panDimensions_2_ABAL
			size = New Global.System.Drawing.Size(320, 88)
			panDimensions_2_ABAL2.Size = size
			Me._panDimensions_2_ABAL.TabIndex = 52
			Me._panDimensions_2_ABAL.TabStop = True
			Me._panDimensions_2_ABAL.Visible = False
			Me.txtP_ABAL.AcceptsReturn = True
			Me.txtP_ABAL.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtP_ABAL.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtP_ABAL.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtP_ABAL.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtP_ABAL, "P Dimension (Air-Balanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtP_ABAL, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtP_ABAL As Global.System.Windows.Forms.Control = Me.txtP_ABAL
			location = New Global.System.Drawing.Point(232, 27)
			txtP_ABAL.Location = location
			Me.txtP_ABAL.MaxLength = 10
			Me.txtP_ABAL.Name = "txtP_ABAL"
			Me.txtP_ABAL.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtP_ABAL, True)
			Dim txtP_ABAL2 As Global.System.Windows.Forms.Control = Me.txtP_ABAL
			size = New Global.System.Drawing.Size(65, 20)
			txtP_ABAL2.Size = size
			Me.txtP_ABAL.TabIndex = 19
			Me.txtP_ABAL.Tag = "cee"
			Me.txtK_ABAL.AcceptsReturn = True
			Me.txtK_ABAL.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtK_ABAL.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtK_ABAL.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtK_ABAL.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtK_ABAL, "K Dimension (Air-Balanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtK_ABAL, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtK_ABAL As Global.System.Windows.Forms.Control = Me.txtK_ABAL
			location = New Global.System.Drawing.Point(232, 4)
			txtK_ABAL.Location = location
			Me.txtK_ABAL.MaxLength = 10
			Me.txtK_ABAL.Name = "txtK_ABAL"
			Me.txtK_ABAL.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtK_ABAL, True)
			Dim txtK_ABAL2 As Global.System.Windows.Forms.Control = Me.txtK_ABAL
			size = New Global.System.Drawing.Size(65, 20)
			txtK_ABAL2.Size = size
			Me.txtK_ABAL.TabIndex = 18
			Me.txtK_ABAL.Tag = "cee"
			Me.txtI_ABAL.AcceptsReturn = True
			Me.txtI_ABAL.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtI_ABAL.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtI_ABAL.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtI_ABAL.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtI_ABAL, "I Dimension (Air-Balanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtI_ABAL, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtI_ABAL As Global.System.Windows.Forms.Control = Me.txtI_ABAL
			location = New Global.System.Drawing.Point(88, 49)
			txtI_ABAL.Location = location
			Me.txtI_ABAL.MaxLength = 10
			Me.txtI_ABAL.Name = "txtI_ABAL"
			Me.txtI_ABAL.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtI_ABAL, True)
			Dim txtI_ABAL2 As Global.System.Windows.Forms.Control = Me.txtI_ABAL
			size = New Global.System.Drawing.Size(65, 20)
			txtI_ABAL2.Size = size
			Me.txtI_ABAL.TabIndex = 17
			Me.txtI_ABAL.Tag = "cee"
			Me.txtC_ABAL.AcceptsReturn = True
			Me.txtC_ABAL.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtC_ABAL.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtC_ABAL.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtC_ABAL.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtC_ABAL, "C Dimension (Air-Balanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtC_ABAL, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtC_ABAL As Global.System.Windows.Forms.Control = Me.txtC_ABAL
			location = New Global.System.Drawing.Point(88, 26)
			txtC_ABAL.Location = location
			Me.txtC_ABAL.MaxLength = 10
			Me.txtC_ABAL.Name = "txtC_ABAL"
			Me.txtC_ABAL.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtC_ABAL, True)
			Dim txtC_ABAL2 As Global.System.Windows.Forms.Control = Me.txtC_ABAL
			size = New Global.System.Drawing.Size(65, 20)
			txtC_ABAL2.Size = size
			Me.txtC_ABAL.TabIndex = 16
			Me.txtC_ABAL.Tag = "cee"
			Me.txtA_ABAL.AcceptsReturn = True
			Me.txtA_ABAL.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtA_ABAL.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtA_ABAL.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtA_ABAL.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtA_ABAL, "A Dimension (Air-Balanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtA_ABAL, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtA_ABAL As Global.System.Windows.Forms.Control = Me.txtA_ABAL
			location = New Global.System.Drawing.Point(88, 3)
			txtA_ABAL.Location = location
			Me.txtA_ABAL.MaxLength = 10
			Me.txtA_ABAL.Name = "txtA_ABAL"
			Me.txtA_ABAL.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtA_ABAL, True)
			Dim txtA_ABAL2 As Global.System.Windows.Forms.Control = Me.txtA_ABAL
			size = New Global.System.Drawing.Size(65, 20)
			txtA_ABAL2.Size = size
			Me.txtA_ABAL.TabIndex = 15
			Me.txtA_ABAL.Tag = "cee"
			Me.Label_A_ABAL.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label_A_ABAL.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label_A_ABAL.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.Label_A_ABAL.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label_A_ABAL.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_A_ABAL As Global.System.Windows.Forms.Control = Me.Label_A_ABAL
			location = New Global.System.Drawing.Point(9, 9)
			label_A_ABAL.Location = location
			Me.Label_A_ABAL.Name = "Label_A_ABAL"
			Me.Label_A_ABAL.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label_A_ABAL, False)
			Dim label_A_ABAL2 As Global.System.Windows.Forms.Control = Me.Label_A_ABAL
			size = New Global.System.Drawing.Size(71, 19)
			label_A_ABAL2.Size = size
			Me.Label_A_ABAL.TabIndex = 53
			Me.Label_A_ABAL.Tag = "A (^):"
			Me.Label_A_ABAL.Text = "A (in):"
			Me.Label_A_ABAL.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.Label_C_ABAL.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label_C_ABAL.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label_C_ABAL.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.Label_C_ABAL.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label_C_ABAL.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_C_ABAL As Global.System.Windows.Forms.Control = Me.Label_C_ABAL
			location = New Global.System.Drawing.Point(9, 32)
			label_C_ABAL.Location = location
			Me.Label_C_ABAL.Name = "Label_C_ABAL"
			Me.Label_C_ABAL.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label_C_ABAL, False)
			Dim label_C_ABAL2 As Global.System.Windows.Forms.Control = Me.Label_C_ABAL
			size = New Global.System.Drawing.Size(71, 19)
			label_C_ABAL2.Size = size
			Me.Label_C_ABAL.TabIndex = 54
			Me.Label_C_ABAL.Tag = "C (^):"
			Me.Label_C_ABAL.Text = "C (in):"
			Me.Label_C_ABAL.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.Label_I_ABAL.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label_I_ABAL.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label_I_ABAL.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.Label_I_ABAL.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label_I_ABAL.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_I_ABAL As Global.System.Windows.Forms.Control = Me.Label_I_ABAL
			location = New Global.System.Drawing.Point(13, 55)
			label_I_ABAL.Location = location
			Me.Label_I_ABAL.Name = "Label_I_ABAL"
			Me.Label_I_ABAL.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label_I_ABAL, False)
			Dim label_I_ABAL2 As Global.System.Windows.Forms.Control = Me.Label_I_ABAL
			size = New Global.System.Drawing.Size(71, 19)
			label_I_ABAL2.Size = size
			Me.Label_I_ABAL.TabIndex = 55
			Me.Label_I_ABAL.Tag = "I (^):"
			Me.Label_I_ABAL.Text = "I (in):"
			Me.Label_I_ABAL.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.Label_K_ABAL.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label_K_ABAL.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label_K_ABAL.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.Label_K_ABAL.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label_K_ABAL.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_K_ABAL As Global.System.Windows.Forms.Control = Me.Label_K_ABAL
			location = New Global.System.Drawing.Point(168, 9)
			label_K_ABAL.Location = location
			Me.Label_K_ABAL.Name = "Label_K_ABAL"
			Me.Label_K_ABAL.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label_K_ABAL, False)
			Dim label_K_ABAL2 As Global.System.Windows.Forms.Control = Me.Label_K_ABAL
			size = New Global.System.Drawing.Size(55, 18)
			label_K_ABAL2.Size = size
			Me.Label_K_ABAL.TabIndex = 56
			Me.Label_K_ABAL.Tag = "K (^):"
			Me.Label_K_ABAL.Text = "K (in):"
			Me.Label_K_ABAL.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.Label_P_ABAL.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label_P_ABAL.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label_P_ABAL.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.Label_P_ABAL.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label_P_ABAL.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_P_ABAL As Global.System.Windows.Forms.Control = Me.Label_P_ABAL
			location = New Global.System.Drawing.Point(168, 32)
			label_P_ABAL.Location = location
			Me.Label_P_ABAL.Name = "Label_P_ABAL"
			Me.Label_P_ABAL.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label_P_ABAL, False)
			Dim label_P_ABAL2 As Global.System.Windows.Forms.Control = Me.Label_P_ABAL
			size = New Global.System.Drawing.Size(55, 18)
			label_P_ABAL2.Size = size
			Me.Label_P_ABAL.TabIndex = 57
			Me.Label_P_ABAL.Tag = "P (^):"
			Me.Label_P_ABAL.Text = "P (in):"
			Me.Label_P_ABAL.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._panDimensions_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me._panDimensions_2.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panDimensions_2.Controls.Add(Me.txtP)
			Me._panDimensions_2.Controls.Add(Me.txtK)
			Me._panDimensions_2.Controls.Add(Me.txtI)
			Me._panDimensions_2.Controls.Add(Me.txtC)
			Me._panDimensions_2.Controls.Add(Me.txtA)
			Me._panDimensions_2.Controls.Add(Me._Label_18)
			Me._panDimensions_2.Controls.Add(Me._Label_19)
			Me._panDimensions_2.Controls.Add(Me._Label_20)
			Me._panDimensions_2.Controls.Add(Me._Label_21)
			Me._panDimensions_2.Controls.Add(Me._Label_22)
			Me._panDimensions_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panDimensions_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panDimensions_2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.panDimensions.SetIndex(Me._panDimensions_2, 2S)
			Dim panDimensions_7 As Global.System.Windows.Forms.Control = Me._panDimensions_2
			location = New Global.System.Drawing.Point(336, 24)
			panDimensions_7.Location = location
			Me._panDimensions_2.Name = "_panDimensions_2"
			Me._panDimensions_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panDimensions_2, False)
			Dim panDimensions_8 As Global.System.Windows.Forms.Control = Me._panDimensions_2
			size = New Global.System.Drawing.Size(320, 88)
			panDimensions_8.Size = size
			Me._panDimensions_2.TabIndex = 47
			Me._panDimensions_2.TabStop = True
			Me._panDimensions_2.Visible = False
			Me.txtP.AcceptsReturn = True
			Me.txtP.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtP.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtP.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtP.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtP, "P Dimension (Conventional and Enhanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtP, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtP As Global.System.Windows.Forms.Control = Me.txtP
			location = New Global.System.Drawing.Point(232, 27)
			txtP.Location = location
			Me.txtP.MaxLength = 10
			Me.txtP.Name = "txtP"
			Me.txtP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtP, True)
			Dim txtP2 As Global.System.Windows.Forms.Control = Me.txtP
			size = New Global.System.Drawing.Size(65, 20)
			txtP2.Size = size
			Me.txtP.TabIndex = 19
			Me.txtP.Tag = "cee"
			Me.txtK.AcceptsReturn = True
			Me.txtK.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtK.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtK.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtK, "K Dimension (Conventional and Enhanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtK, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtK As Global.System.Windows.Forms.Control = Me.txtK
			location = New Global.System.Drawing.Point(232, 4)
			txtK.Location = location
			Me.txtK.MaxLength = 10
			Me.txtK.Name = "txtK"
			Me.txtK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtK, True)
			Dim txtK2 As Global.System.Windows.Forms.Control = Me.txtK
			size = New Global.System.Drawing.Size(65, 20)
			txtK2.Size = size
			Me.txtK.TabIndex = 18
			Me.txtK.Tag = "cee"
			Me.txtI.AcceptsReturn = True
			Me.txtI.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtI.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtI.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtI.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtI, "I Dimension (Conventional and Enhanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtI, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtI As Global.System.Windows.Forms.Control = Me.txtI
			location = New Global.System.Drawing.Point(88, 49)
			txtI.Location = location
			Me.txtI.MaxLength = 10
			Me.txtI.Name = "txtI"
			Me.txtI.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtI, True)
			Dim txtI2 As Global.System.Windows.Forms.Control = Me.txtI
			size = New Global.System.Drawing.Size(65, 20)
			txtI2.Size = size
			Me.txtI.TabIndex = 17
			Me.txtI.Tag = "cee"
			Me.txtC.AcceptsReturn = True
			Me.txtC.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtC.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtC.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtC.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtC, "C Dimension (Conventional and Enhanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtC, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtC As Global.System.Windows.Forms.Control = Me.txtC
			location = New Global.System.Drawing.Point(88, 26)
			txtC.Location = location
			Me.txtC.MaxLength = 10
			Me.txtC.Name = "txtC"
			Me.txtC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtC, True)
			Dim txtC2 As Global.System.Windows.Forms.Control = Me.txtC
			size = New Global.System.Drawing.Size(65, 20)
			txtC2.Size = size
			Me.txtC.TabIndex = 16
			Me.txtC.Tag = "cee"
			Me.txtA.AcceptsReturn = True
			Me.txtA.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtA.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtA.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtA.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtA, "A Dimension (Conventional and Enhanced Units)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtA, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtA As Global.System.Windows.Forms.Control = Me.txtA
			location = New Global.System.Drawing.Point(88, 3)
			txtA.Location = location
			Me.txtA.MaxLength = 10
			Me.txtA.Name = "txtA"
			Me.txtA.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtA, True)
			Dim txtA2 As Global.System.Windows.Forms.Control = Me.txtA
			size = New Global.System.Drawing.Size(65, 20)
			txtA2.Size = size
			Me.txtA.TabIndex = 15
			Me.txtA.Tag = "cee"
			Me._Label_18.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_18.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_18.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_18.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_18.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_18, 18S)
			Dim label_35 As Global.System.Windows.Forms.Control = Me._Label_18
			location = New Global.System.Drawing.Point(16, 9)
			label_35.Location = location
			Me._Label_18.Name = "_Label_18"
			Me._Label_18.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_18, False)
			Dim label_36 As Global.System.Windows.Forms.Control = Me._Label_18
			size = New Global.System.Drawing.Size(56, 19)
			label_36.Size = size
			Me._Label_18.TabIndex = 53
			Me._Label_18.Tag = "A (^):"
			Me._Label_18.Text = "A (in):"
			Me._Label_18.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_19.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_19.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_19.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_19.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_19.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_19, 19S)
			Dim label_37 As Global.System.Windows.Forms.Control = Me._Label_19
			location = New Global.System.Drawing.Point(16, 32)
			label_37.Location = location
			Me._Label_19.Name = "_Label_19"
			Me._Label_19.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_19, False)
			Dim label_38 As Global.System.Windows.Forms.Control = Me._Label_19
			size = New Global.System.Drawing.Size(56, 19)
			label_38.Size = size
			Me._Label_19.TabIndex = 54
			Me._Label_19.Tag = "C (^):"
			Me._Label_19.Text = "C (in):"
			Me._Label_19.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_20.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_20.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_20.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_20.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_20.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_20, 20S)
			Dim label_39 As Global.System.Windows.Forms.Control = Me._Label_20
			location = New Global.System.Drawing.Point(16, 55)
			label_39.Location = location
			Me._Label_20.Name = "_Label_20"
			Me._Label_20.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_20, False)
			Dim label_40 As Global.System.Windows.Forms.Control = Me._Label_20
			size = New Global.System.Drawing.Size(56, 19)
			label_40.Size = size
			Me._Label_20.TabIndex = 55
			Me._Label_20.Tag = "I (^):"
			Me._Label_20.Text = "I (in):"
			Me._Label_20.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_21.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_21.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_21.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_21.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_21.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_21, 21S)
			Dim label_41 As Global.System.Windows.Forms.Control = Me._Label_21
			location = New Global.System.Drawing.Point(176, 9)
			label_41.Location = location
			Me._Label_21.Name = "_Label_21"
			Me._Label_21.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_21, False)
			Dim label_42 As Global.System.Windows.Forms.Control = Me._Label_21
			size = New Global.System.Drawing.Size(55, 18)
			label_42.Size = size
			Me._Label_21.TabIndex = 56
			Me._Label_21.Tag = "K (^):"
			Me._Label_21.Text = "K (in):"
			Me._Label_21.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_22.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_22.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_22.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_22.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_22.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_22, 22S)
			Dim label_43 As Global.System.Windows.Forms.Control = Me._Label_22
			location = New Global.System.Drawing.Point(176, 32)
			label_43.Location = location
			Me._Label_22.Name = "_Label_22"
			Me._Label_22.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_22, False)
			Dim label_44 As Global.System.Windows.Forms.Control = Me._Label_22
			size = New Global.System.Drawing.Size(55, 18)
			label_44.Size = size
			Me._Label_22.TabIndex = 57
			Me._Label_22.Tag = "P (^):"
			Me._Label_22.Text = "P (in):"
			Me._Label_22.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._SSFrame_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSFrame_0.Controls.Add(Me.lblRequiredRotation)
			Me._SSFrame_0.Controls.Add(Me.txtGearboxRating)
			Me._SSFrame_0.Controls.Add(Me.txtStructRating)
			Me._SSFrame_0.Controls.Add(Me.txtMaxStroke)
			Me._SSFrame_0.Controls.Add(Me.cboUnitType)
			Me._SSFrame_0.Controls.Add(Me.txtManufacturer)
			Me._SSFrame_0.Controls.Add(Me.txtOtherInfo)
			Me._SSFrame_0.Controls.Add(Me.txtUnitName)
			Me._SSFrame_0.Controls.Add(Me.lblAPIDesignation)
			Me._SSFrame_0.Controls.Add(Me._Label_6)
			Me._SSFrame_0.Controls.Add(Me._Label_5)
			Me._SSFrame_0.Controls.Add(Me._Label_GearboxRating)
			Me._SSFrame_0.Controls.Add(Me._Label_3)
			Me._SSFrame_0.Controls.Add(Me._Label_API_designation)
			Me._SSFrame_0.Controls.Add(Me._Label_0)
			Me._SSFrame_0.Controls.Add(Me._Label_2)
			Me._SSFrame_0.Controls.Add(Me._Label_1)
			Me._SSFrame_0.Controls.Add(Me.lblArtInertia)
			Me._SSFrame_0.Controls.Add(Me.txtArtInertia)
			Me._SSFrame_0.Controls.Add(Me.lblArtInertia_Disabled)
			Me._SSFrame_0.Controls.Add(Me.cboRequiredRotation)
			Me._SSFrame_0.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me._SSFrame_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.SSFrame.SetIndex(Me._SSFrame_0, 0S)
			Dim ssframe_ As Global.System.Windows.Forms.Control = Me._SSFrame_0
			location = New Global.System.Drawing.Point(8, 1)
			ssframe_.Location = location
			Me._SSFrame_0.Name = "_SSFrame_0"
			Me._SSFrame_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._SSFrame_0, False)
			Dim ssframe_2 As Global.System.Windows.Forms.Control = Me._SSFrame_0
			size = New Global.System.Drawing.Size(669, 143)
			ssframe_2.Size = size
			Me._SSFrame_0.TabIndex = 64
			Me._SSFrame_0.TabStop = False
			Me._SSFrame_0.Text = "Unit Information"
			Me.lblRequiredRotation.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRequiredRotation.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRequiredRotation.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRequiredRotation.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRequiredRotation.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblRequiredRotation As Global.System.Windows.Forms.Control = Me.lblRequiredRotation
			location = New Global.System.Drawing.Point(8, 110)
			lblRequiredRotation.Location = location
			Me.lblRequiredRotation.Name = "lblRequiredRotation"
			Me.lblRequiredRotation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblRequiredRotation2 As Global.System.Windows.Forms.Control = Me.lblRequiredRotation
			size = New Global.System.Drawing.Size(152, 18)
			lblRequiredRotation2.Size = size
			Me.lblRequiredRotation.TabIndex = 88
			Me.lblRequiredRotation.Text = "Required crank rotation:"
			Me.txtGearboxRating.AcceptsReturn = True
			Me.txtGearboxRating.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtGearboxRating.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtGearboxRating.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtGearboxRating.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtGearboxRating, "custom pumping unit: gearbox rating")
			Me.HelpProvider1.SetHelpNavigator(Me.txtGearboxRating, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtGearboxRating As Global.System.Windows.Forms.Control = Me.txtGearboxRating
			location = New Global.System.Drawing.Point(544, 38)
			txtGearboxRating.Location = location
			Me.txtGearboxRating.MaxLength = 10
			Me.txtGearboxRating.Name = "txtGearboxRating"
			Me.txtGearboxRating.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtGearboxRating, True)
			Dim txtGearboxRating2 As Global.System.Windows.Forms.Control = Me.txtGearboxRating
			size = New Global.System.Drawing.Size(65, 20)
			txtGearboxRating2.Size = size
			Me.txtGearboxRating.TabIndex = 5
			Me.txtGearboxRating.Tag = "Lee"
			Me.txtStructRating.AcceptsReturn = True
			Me.txtStructRating.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtStructRating.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtStructRating.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtStructRating.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtStructRating, "custom pumping unit: structure rating")
			Me.HelpProvider1.SetHelpNavigator(Me.txtStructRating, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtStructRating As Global.System.Windows.Forms.Control = Me.txtStructRating
			location = New Global.System.Drawing.Point(544, 61)
			txtStructRating.Location = location
			Me.txtStructRating.MaxLength = 10
			Me.txtStructRating.Name = "txtStructRating"
			Me.txtStructRating.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtStructRating, True)
			Dim txtStructRating2 As Global.System.Windows.Forms.Control = Me.txtStructRating
			size = New Global.System.Drawing.Size(65, 20)
			txtStructRating2.Size = size
			Me.txtStructRating.TabIndex = 6
			Me.txtStructRating.Tag = "hee"
			Me.txtMaxStroke.AcceptsReturn = True
			Me.txtMaxStroke.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMaxStroke.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMaxStroke.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtMaxStroke.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMaxStroke, "custom pumping unit: maximum stroke length")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMaxStroke, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMaxStroke As Global.System.Windows.Forms.Control = Me.txtMaxStroke
			location = New Global.System.Drawing.Point(544, 84)
			txtMaxStroke.Location = location
			Me.txtMaxStroke.MaxLength = 10
			Me.txtMaxStroke.Name = "txtMaxStroke"
			Me.txtMaxStroke.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMaxStroke, True)
			Dim txtMaxStroke2 As Global.System.Windows.Forms.Control = Me.txtMaxStroke
			size = New Global.System.Drawing.Size(65, 20)
			txtMaxStroke2.Size = size
			Me.txtMaxStroke.TabIndex = 7
			Me.txtMaxStroke.Tag = "cee"
			Me.cboUnitType.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboUnitType.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboUnitType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboUnitType.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboUnitType.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboUnitType, "custom pumping unit type")
			Me.HelpProvider1.SetHelpNavigator(Me.cboUnitType, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboUnitType.ItemHeight = 14
			Me.cboUnitType.Items.AddRange(New Object() { "Conventional", "Enhanced", "Grooves", "Low Profile", "Mark II", "Air-balanced", "Long stroke", "Beam Balanced", "Belt Low Profile", "Hydraulic" })
			Dim cboUnitType As Global.System.Windows.Forms.Control = Me.cboUnitType
			location = New Global.System.Drawing.Point(168, 84)
			cboUnitType.Location = location
			Me.cboUnitType.MaxDropDownItems = 10
			Me.cboUnitType.Name = "cboUnitType"
			Me.cboUnitType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboUnitType, True)
			Dim cboUnitType2 As Global.System.Windows.Forms.Control = Me.cboUnitType
			size = New Global.System.Drawing.Size(153, 22)
			cboUnitType2.Size = size
			Me.cboUnitType.TabIndex = 3
			Me.txtManufacturer.AcceptsReturn = True
			Me.txtManufacturer.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtManufacturer.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtManufacturer.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtManufacturer.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtManufacturer, "custom pumping unit manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.txtManufacturer, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtManufacturer As Global.System.Windows.Forms.Control = Me.txtManufacturer
			location = New Global.System.Drawing.Point(168, 15)
			txtManufacturer.Location = location
			Me.txtManufacturer.Name = "txtManufacturer"
			Me.txtManufacturer.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtManufacturer, True)
			Dim txtManufacturer2 As Global.System.Windows.Forms.Control = Me.txtManufacturer
			size = New Global.System.Drawing.Size(153, 20)
			txtManufacturer2.Size = size
			Me.txtManufacturer.TabIndex = 0
			Me.txtOtherInfo.AcceptsReturn = True
			Me.txtOtherInfo.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtOtherInfo.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtOtherInfo.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtOtherInfo.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtOtherInfo, "custom pumping unit: other information")
			Me.HelpProvider1.SetHelpNavigator(Me.txtOtherInfo, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtOtherInfo As Global.System.Windows.Forms.Control = Me.txtOtherInfo
			location = New Global.System.Drawing.Point(168, 61)
			txtOtherInfo.Location = location
			Me.txtOtherInfo.MaxLength = 40
			Me.txtOtherInfo.Name = "txtOtherInfo"
			Me.txtOtherInfo.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtOtherInfo, True)
			Dim txtOtherInfo2 As Global.System.Windows.Forms.Control = Me.txtOtherInfo
			size = New Global.System.Drawing.Size(153, 20)
			txtOtherInfo2.Size = size
			Me.txtOtherInfo.TabIndex = 2
			Me.txtUnitName.AcceptsReturn = True
			Me.txtUnitName.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtUnitName.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtUnitName.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtUnitName.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtUnitName, "custom pumping unit name")
			Me.HelpProvider1.SetHelpNavigator(Me.txtUnitName, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtUnitName As Global.System.Windows.Forms.Control = Me.txtUnitName
			location = New Global.System.Drawing.Point(168, 38)
			txtUnitName.Location = location
			Me.txtUnitName.MaxLength = 40
			Me.txtUnitName.Name = "txtUnitName"
			Me.txtUnitName.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtUnitName, True)
			Dim txtUnitName2 As Global.System.Windows.Forms.Control = Me.txtUnitName
			size = New Global.System.Drawing.Size(153, 20)
			txtUnitName2.Size = size
			Me.txtUnitName.TabIndex = 1
			Me.lblAPIDesignation.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblAPIDesignation.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblAPIDesignation.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblAPIDesignation.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.lblAPIDesignation, "API designation")
			Me.HelpProvider1.SetHelpNavigator(Me.lblAPIDesignation, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.lblAPIDesignation.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblAPIDesignation As Global.System.Windows.Forms.Control = Me.lblAPIDesignation
			location = New Global.System.Drawing.Point(456, 15)
			lblAPIDesignation.Location = location
			Me.lblAPIDesignation.Name = "lblAPIDesignation"
			Me.lblAPIDesignation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblAPIDesignation, True)
			Dim lblAPIDesignation2 As Global.System.Windows.Forms.Control = Me.lblAPIDesignation
			size = New Global.System.Drawing.Size(200, 20)
			lblAPIDesignation2.Size = size
			Me.lblAPIDesignation.TabIndex = 62
			Me._Label_6.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_6.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_6.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_6.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_6, 6S)
			Dim label_45 As Global.System.Windows.Forms.Control = Me._Label_6
			location = New Global.System.Drawing.Point(336, 84)
			label_45.Location = location
			Me._Label_6.Name = "_Label_6"
			Me._Label_6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_6, False)
			Dim label_46 As Global.System.Windows.Forms.Control = Me._Label_6
			size = New Global.System.Drawing.Size(200, 18)
			label_46.Size = size
			Me._Label_6.TabIndex = 69
			Me._Label_6.Tag = "Maximum stroke length (^):"
			Me._Label_6.Text = "Maximum stroke length (in):"
			Me._Label_5.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_5.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_5.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_5.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_5, 5S)
			Dim label_47 As Global.System.Windows.Forms.Control = Me._Label_5
			location = New Global.System.Drawing.Point(336, 61)
			label_47.Location = location
			Me._Label_5.Name = "_Label_5"
			Me._Label_5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_5, False)
			Dim label_48 As Global.System.Windows.Forms.Control = Me._Label_5
			size = New Global.System.Drawing.Size(200, 18)
			label_48.Size = size
			Me._Label_5.TabIndex = 70
			Me._Label_5.Tag = "Structural rating (^):"
			Me._Label_5.Text = "Structural rating (x100 lbs):"
			Me._Label_GearboxRating.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_GearboxRating.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_GearboxRating.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_GearboxRating.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_GearboxRating.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_GearboxRating, 4S)
			Dim label_GearboxRating As Global.System.Windows.Forms.Control = Me._Label_GearboxRating
			location = New Global.System.Drawing.Point(336, 38)
			label_GearboxRating.Location = location
			Me._Label_GearboxRating.Name = "_Label_GearboxRating"
			Me._Label_GearboxRating.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_GearboxRating, False)
			Dim label_GearboxRating2 As Global.System.Windows.Forms.Control = Me._Label_GearboxRating
			size = New Global.System.Drawing.Size(200, 18)
			label_GearboxRating2.Size = size
			Me._Label_GearboxRating.TabIndex = 71
			Me._Label_GearboxRating.Tag = "Gearbox rating (^):"
			Me._Label_GearboxRating.Text = "Gearbox rating (M in-lbs):"
			Me._Label_3.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_3.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_3, 3S)
			Dim label_49 As Global.System.Windows.Forms.Control = Me._Label_3
			location = New Global.System.Drawing.Point(8, 88)
			label_49.Location = location
			Me._Label_3.Name = "_Label_3"
			Me._Label_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_3, False)
			Dim label_50 As Global.System.Windows.Forms.Control = Me._Label_3
			size = New Global.System.Drawing.Size(152, 18)
			label_50.Size = size
			Me._Label_3.TabIndex = 72
			Me._Label_3.Text = "Unit type:"
			Me._Label_API_designation.AutoSize = True
			Me._Label_API_designation.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_API_designation.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_API_designation.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_API_designation.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_API_designation.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_API_designation, 28S)
			Dim label_API_designation As Global.System.Windows.Forms.Control = Me._Label_API_designation
			location = New Global.System.Drawing.Point(336, 15)
			label_API_designation.Location = location
			Me._Label_API_designation.Name = "_Label_API_designation"
			Me._Label_API_designation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_API_designation, False)
			Dim label_API_designation2 As Global.System.Windows.Forms.Control = Me._Label_API_designation
			size = New Global.System.Drawing.Size(103, 16)
			label_API_designation2.Size = size
			Me._Label_API_designation.TabIndex = 73
			Me._Label_API_designation.Text = "API designation:"
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_0, 0S)
			Dim label_51 As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(8, 20)
			label_51.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_0, False)
			Dim label_52 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(152, 19)
			label_52.Size = size
			Me._Label_0.TabIndex = 67
			Me._Label_0.Text = "Manufacturer:"
			Me._Label_2.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_2.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_2, 2S)
			Dim label_53 As Global.System.Windows.Forms.Control = Me._Label_2
			location = New Global.System.Drawing.Point(8, 65)
			label_53.Location = location
			Me._Label_2.Name = "_Label_2"
			Me._Label_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_2, False)
			Dim label_54 As Global.System.Windows.Forms.Control = Me._Label_2
			size = New Global.System.Drawing.Size(152, 18)
			label_54.Size = size
			Me._Label_2.TabIndex = 75
			Me._Label_2.Text = "Other information:"
			Me._Label_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_1.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me._Label_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_1, 1S)
			Dim label_55 As Global.System.Windows.Forms.Control = Me._Label_1
			location = New Global.System.Drawing.Point(8, 43)
			label_55.Location = location
			Me._Label_1.Name = "_Label_1"
			Me._Label_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_1, False)
			Dim label_56 As Global.System.Windows.Forms.Control = Me._Label_1
			size = New Global.System.Drawing.Size(152, 18)
			label_56.Size = size
			Me._Label_1.TabIndex = 74
			Me._Label_1.Text = "Unit name:"
			Me.lblArtInertia.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblArtInertia.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblArtInertia.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblArtInertia.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblArtInertia.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me.lblArtInertia, 7S)
			Dim lblArtInertia As Global.System.Windows.Forms.Control = Me.lblArtInertia
			location = New Global.System.Drawing.Point(336, 107)
			lblArtInertia.Location = location
			Me.lblArtInertia.Name = "lblArtInertia"
			Me.lblArtInertia.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblArtInertia, False)
			Dim lblArtInertia2 As Global.System.Windows.Forms.Control = Me.lblArtInertia
			size = New Global.System.Drawing.Size(200, 19)
			lblArtInertia2.Size = size
			Me.lblArtInertia.TabIndex = 68
			Me.lblArtInertia.Tag = "Articulating inertia (^):"
			Me.lblArtInertia.Text = "Articulating inertia (lb-ft²):"
			Me.txtArtInertia.AcceptsReturn = True
			Me.txtArtInertia.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtArtInertia.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtArtInertia.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtArtInertia.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtArtInertia, "custom pumping unit: articulating moment of inertia")
			Me.HelpProvider1.SetHelpNavigator(Me.txtArtInertia, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtArtInertia As Global.System.Windows.Forms.Control = Me.txtArtInertia
			location = New Global.System.Drawing.Point(544, 107)
			txtArtInertia.Location = location
			Me.txtArtInertia.Name = "txtArtInertia"
			Me.txtArtInertia.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtArtInertia, True)
			Dim txtArtInertia2 As Global.System.Windows.Forms.Control = Me.txtArtInertia
			size = New Global.System.Drawing.Size(65, 20)
			txtArtInertia2.Size = size
			Me.txtArtInertia.TabIndex = 8
			Me.txtArtInertia.Tag = "Nee"
			Me.lblArtInertia_Disabled.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblArtInertia_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblArtInertia_Disabled.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblArtInertia_Disabled.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblArtInertia_Disabled.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblArtInertia_Disabled.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblArtInertia_Disabled As Global.System.Windows.Forms.Control = Me.lblArtInertia_Disabled
			location = New Global.System.Drawing.Point(544, 107)
			lblArtInertia_Disabled.Location = location
			Me.lblArtInertia_Disabled.Name = "lblArtInertia_Disabled"
			Me.lblArtInertia_Disabled.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblArtInertia_Disabled, False)
			Dim lblArtInertia_Disabled2 As Global.System.Windows.Forms.Control = Me.lblArtInertia_Disabled
			size = New Global.System.Drawing.Size(65, 19)
			lblArtInertia_Disabled2.Size = size
			Me.lblArtInertia_Disabled.TabIndex = 76
			Me.cboRequiredRotation.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboRequiredRotation.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboRequiredRotation.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboRequiredRotation.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cboRequiredRotation.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboRequiredRotation, "Required Crank Rotation")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRequiredRotation, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRequiredRotation.ItemHeight = 14
			Me.cboRequiredRotation.Items.AddRange(New Object() { "Clockwise", "Counterclockwise", "None" })
			Dim cboRequiredRotation As Global.System.Windows.Forms.Control = Me.cboRequiredRotation
			location = New Global.System.Drawing.Point(168, 110)
			cboRequiredRotation.Location = location
			Me.cboRequiredRotation.Name = "cboRequiredRotation"
			Me.cboRequiredRotation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboRequiredRotation, True)
			Dim cboRequiredRotation2 As Global.System.Windows.Forms.Control = Me.cboRequiredRotation
			size = New Global.System.Drawing.Size(153, 22)
			cboRequiredRotation2.Size = size
			Me.cboRequiredRotation.TabIndex = 4
			Me.cmdLoad.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdLoad.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdLoad.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdLoad.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdLoad.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdLoad As Global.System.Windows.Forms.Control = Me.cmdLoad
			location = New Global.System.Drawing.Point(696, 220)
			cmdLoad.Location = location
			Me.cmdLoad.Name = "cmdLoad"
			Me.cmdLoad.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdLoad, False)
			Dim cmdLoad2 As Global.System.Windows.Forms.Control = Me.cmdLoad
			size = New Global.System.Drawing.Size(96, 25)
			cmdLoad2.Size = size
			Me.cmdLoad.TabIndex = 44
			Me.cmdLoad.TabStop = False
			Me.cmdLoad.Text = "Load"
			Me.cmdLoad.UseVisualStyleBackColor = False
			Me.cmdLoad.Visible = False
			Me.AcceptButton = Me.cmdOK
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			Me.CancelButton = Me.cmdCancel
			size = New Global.System.Drawing.Size(805, 374)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.cmdHelp)
			Me.Controls.Add(Me._SSFrame_UnitDimensions)
			Me.Controls.Add(Me.cmdLoad)
			Me.Controls.Add(Me._SSFrame_0)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			location = New Global.System.Drawing.Point(219, 152)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgCustomPU"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Pumping Unit Dimensions"
			Me._SSFrame_UnitDimensions.ResumeLayout(False)
			Me._panDimensions_4.ResumeLayout(False)
			Me._panDimensions_4.PerformLayout()
			Me._panLowProfileBelt2.ResumeLayout(False)
			Me._panLowProfileBelt2.PerformLayout()
			Me._panDimensions_3.ResumeLayout(False)
			Me._panDimensions_3.PerformLayout()
			Me._panDimensions_0.ResumeLayout(False)
			Me._panDimensions_0.PerformLayout()
			Me._panDimensions_longstroke.ResumeLayout(False)
			Me._panDimensions_longstroke.PerformLayout()
			Me._panDimensions_2_MII.ResumeLayout(False)
			Me._panDimensions_2_MII.PerformLayout()
			Me._panLowProfileBelt1.ResumeLayout(False)
			Me._panLowProfileBelt1.PerformLayout()
			Me._panDimensions_2_ABAL.ResumeLayout(False)
			Me._panDimensions_2_ABAL.PerformLayout()
			Me._panDimensions_2.ResumeLayout(False)
			Me._panDimensions_2.PerformLayout()
			Me._SSFrame_0.ResumeLayout(False)
			Me._SSFrame_0.PerformLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Line, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSFrame, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panCalcStroke, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panDimensions, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtR, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
