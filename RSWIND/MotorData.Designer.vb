Namespace RSWINV3
	Public Partial Class MotorData
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
			Dim border As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.MotorData))
			Me.pnlMotorData = New Global.System.Windows.Forms.Panel()
			Me.btnPlotMotorPairs = New Global.System.Windows.Forms.Button()
			Me.lblFootnote1 = New Global.System.Windows.Forms.Label()
			Me.lblAsterisk = New Global.System.Windows.Forms.Label()
			Me._Line_2 = New Global.System.Windows.Forms.Label()
			Me.chkIncludeMotorSPV = New Global.System.Windows.Forms.CheckBox()
			Me._Line_3 = New Global.System.Windows.Forms.Label()
			Me._Line_4 = New Global.System.Windows.Forms.Label()
			Me._Line_5 = New Global.System.Windows.Forms.Label()
			Me._Label_MotorSPV = New Global.System.Windows.Forms.Label()
			Me._Line_6 = New Global.System.Windows.Forms.Label()
			Me._Line_7 = New Global.System.Windows.Forms.Label()
			Me._Label_Irot = New Global.System.Windows.Forms.Label()
			Me._Label_Iart = New Global.System.Windows.Forms.Label()
			Me._Label_MotorType = New Global.System.Windows.Forms.Label()
			Me.txtElectricityCost = New Global.System.Windows.Forms.TextBox()
			Me.optPowerMeterType_2 = New Global.System.Windows.Forms.RadioButton()
			Me.optPowerMeterType_1 = New Global.System.Windows.Forms.RadioButton()
			Me._Label_MeterType = New Global.System.Windows.Forms.Label()
			Me._Label_ElectricityCost = New Global.System.Windows.Forms.Label()
			Me._Label_MotorSize = New Global.System.Windows.Forms.Label()
			Me._Label_MotorSetting = New Global.System.Windows.Forms.Label()
			Me._Line_0 = New Global.System.Windows.Forms.Label()
			Me._Line_1 = New Global.System.Windows.Forms.Label()
			Me.cboMotorType = New Global.System.Windows.Forms.ComboBox()
			Me.cboMotorSize = New Global.System.Windows.Forms.ComboBox()
			Me.cboMotorSetting = New Global.System.Windows.Forms.ComboBox()
			Me.txtIrot = New Global.System.Windows.Forms.TextBox()
			Me.txtIart = New Global.System.Windows.Forms.TextBox()
			Me.txtMotorSPV = New Global.System.Windows.Forms.TextBox()
			Me.chkCalculateIrot = New Global.System.Windows.Forms.CheckBox()
			Me.chkCalcMotorSPV = New Global.System.Windows.Forms.CheckBox()
			Me.lblIrot_Disabled = New Global.System.Windows.Forms.Label()
			Me.lblIart_Disabled = New Global.System.Windows.Forms.Label()
			Me.lblMotorSPV_Disabled = New Global.System.Windows.Forms.Label()
			Me.FontDialog1 = New Global.System.Windows.Forms.FontDialog()
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.pnlMotorPairs = New Global.System.Windows.Forms.Panel()
			Me.btnRefresh = New Global.System.Windows.Forms.Button()
			Me.lblWorking = New Global.System.Windows.Forms.Label()
			Me.btnUpdateDB = New Global.System.Windows.Forms.Button()
			Me.lblMotor = New Global.System.Windows.Forms.Label()
			Me.btnCloseMotorPairs = New Global.System.Windows.Forms.Button()
			Me.chtMotorPairs = New Global.ChartFX.WinForms.Chart()
			Me.pnlMotorData.SuspendLayout()
			Me.pnlMotorPairs.SuspendLayout()
			CType(Me.chtMotorPairs, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.pnlMotorData.Controls.Add(Me.btnPlotMotorPairs)
			Me.pnlMotorData.Controls.Add(Me.lblFootnote1)
			Me.pnlMotorData.Controls.Add(Me.lblAsterisk)
			Me.pnlMotorData.Controls.Add(Me._Line_2)
			Me.pnlMotorData.Controls.Add(Me.chkIncludeMotorSPV)
			Me.pnlMotorData.Controls.Add(Me._Line_3)
			Me.pnlMotorData.Controls.Add(Me._Line_4)
			Me.pnlMotorData.Controls.Add(Me._Line_5)
			Me.pnlMotorData.Controls.Add(Me._Label_MotorSPV)
			Me.pnlMotorData.Controls.Add(Me._Line_6)
			Me.pnlMotorData.Controls.Add(Me._Line_7)
			Me.pnlMotorData.Controls.Add(Me._Label_Irot)
			Me.pnlMotorData.Controls.Add(Me._Label_Iart)
			Me.pnlMotorData.Controls.Add(Me._Label_MotorType)
			Me.pnlMotorData.Controls.Add(Me.txtElectricityCost)
			Me.pnlMotorData.Controls.Add(Me.optPowerMeterType_2)
			Me.pnlMotorData.Controls.Add(Me.optPowerMeterType_1)
			Me.pnlMotorData.Controls.Add(Me._Label_MeterType)
			Me.pnlMotorData.Controls.Add(Me._Label_ElectricityCost)
			Me.pnlMotorData.Controls.Add(Me._Label_MotorSize)
			Me.pnlMotorData.Controls.Add(Me._Label_MotorSetting)
			Me.pnlMotorData.Controls.Add(Me._Line_0)
			Me.pnlMotorData.Controls.Add(Me._Line_1)
			Me.pnlMotorData.Controls.Add(Me.cboMotorType)
			Me.pnlMotorData.Controls.Add(Me.cboMotorSize)
			Me.pnlMotorData.Controls.Add(Me.cboMotorSetting)
			Me.pnlMotorData.Controls.Add(Me.txtIrot)
			Me.pnlMotorData.Controls.Add(Me.txtIart)
			Me.pnlMotorData.Controls.Add(Me.txtMotorSPV)
			Me.pnlMotorData.Controls.Add(Me.chkCalculateIrot)
			Me.pnlMotorData.Controls.Add(Me.chkCalcMotorSPV)
			Me.pnlMotorData.Controls.Add(Me.lblIrot_Disabled)
			Me.pnlMotorData.Controls.Add(Me.lblIart_Disabled)
			Me.pnlMotorData.Controls.Add(Me.lblMotorSPV_Disabled)
			Dim pnlMotorData As Global.System.Windows.Forms.Control = Me.pnlMotorData
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(8, 8)
			pnlMotorData.Location = location
			Me.pnlMotorData.Name = "pnlMotorData"
			Me.HelpProvider1.SetShowHelp(Me.pnlMotorData, False)
			Dim pnlMotorData2 As Global.System.Windows.Forms.Control = Me.pnlMotorData
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(792, 268)
			pnlMotorData2.Size = size
			Me.pnlMotorData.TabIndex = 0
			Dim btnPlotMotorPairs As Global.System.Windows.Forms.Control = Me.btnPlotMotorPairs
			location = New Global.System.Drawing.Point(-1333, 206)
			btnPlotMotorPairs.Location = location
			Me.btnPlotMotorPairs.Name = "btnPlotMotorPairs"
			Dim btnPlotMotorPairs2 As Global.System.Windows.Forms.Control = Me.btnPlotMotorPairs
			size = New Global.System.Drawing.Size(23, 22)
			btnPlotMotorPairs2.Size = size
			Me.btnPlotMotorPairs.TabIndex = 61
			Me.btnPlotMotorPairs.Text = "+"
			Me.btnPlotMotorPairs.UseVisualStyleBackColor = True
			Me.lblFootnote1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblFootnote As Global.System.Windows.Forms.Control = Me.lblFootnote1
			location = New Global.System.Drawing.Point(368, 216)
			lblFootnote.Location = location
			Me.lblFootnote1.Name = "lblFootnote1"
			Dim lblFootnote2 As Global.System.Windows.Forms.Control = Me.lblFootnote1
			size = New Global.System.Drawing.Size(344, 33)
			lblFootnote2.Size = size
			Me.lblFootnote1.TabIndex = 60
			Me.lblFootnote1.Text = "* Speed variation currently unavailable in RODSTAR-D.   Instead use RODSTAR-V."
			Me.lblFootnote1.Visible = False
			Me.lblAsterisk.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblAsterisk As Global.System.Windows.Forms.Control = Me.lblAsterisk
			location = New Global.System.Drawing.Point(360, 24)
			lblAsterisk.Location = location
			Me.lblAsterisk.Name = "lblAsterisk"
			Dim lblAsterisk2 As Global.System.Windows.Forms.Control = Me.lblAsterisk
			size = New Global.System.Drawing.Size(16, 16)
			lblAsterisk2.Size = size
			Me.lblAsterisk.TabIndex = 59
			Me.lblAsterisk.Text = "*"
			Me.lblAsterisk.Visible = False
			Me._Line_2.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._Line_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim line_ As Global.System.Windows.Forms.Control = Me._Line_2
			location = New Global.System.Drawing.Point(352, 12)
			line_.Location = location
			Me._Line_2.Name = "_Line_2"
			Me.HelpProvider1.SetShowHelp(Me._Line_2, False)
			Dim line_2 As Global.System.Windows.Forms.Control = Me._Line_2
			size = New Global.System.Drawing.Size(1, 250)
			line_2.Size = size
			Me._Line_2.TabIndex = 48
			Me.chkIncludeMotorSPV.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkIncludeMotorSPV.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkIncludeMotorSPV.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkIncludeMotorSPV.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.chkIncludeMotorSPV, "Include Motor Speed Variation")
			Me.HelpProvider1.SetHelpNavigator(Me.chkIncludeMotorSPV, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkIncludeMotorSPV.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkIncludeMotorSPV As Global.System.Windows.Forms.Control = Me.chkIncludeMotorSPV
			location = New Global.System.Drawing.Point(376, 16)
			chkIncludeMotorSPV.Location = location
			Me.chkIncludeMotorSPV.Name = "chkIncludeMotorSPV"
			Me.chkIncludeMotorSPV.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkIncludeMotorSPV, True)
			Dim chkIncludeMotorSPV2 As Global.System.Windows.Forms.Control = Me.chkIncludeMotorSPV
			size = New Global.System.Drawing.Size(376, 24)
			chkIncludeMotorSPV2.Size = size
			Me.chkIncludeMotorSPV.TabIndex = 41
			Me.chkIncludeMotorSPV.Text = "Include motor speed variation"
			Me.chkIncludeMotorSPV.UseVisualStyleBackColor = False
			Me._Line_3.BackColor = Global.System.Drawing.Color.White
			Me._Line_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim line_3 As Global.System.Windows.Forms.Control = Me._Line_3
			location = New Global.System.Drawing.Point(352, 8)
			line_3.Location = location
			Me._Line_3.Name = "_Line_3"
			Me.HelpProvider1.SetShowHelp(Me._Line_3, False)
			Dim line_4 As Global.System.Windows.Forms.Control = Me._Line_3
			size = New Global.System.Drawing.Size(1, 200)
			line_4.Size = size
			Me._Line_3.TabIndex = 50
			Me._Line_4.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._Line_4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9F)
			Me._Line_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim line_5 As Global.System.Windows.Forms.Control = Me._Line_4
			location = New Global.System.Drawing.Point(368, 56)
			line_5.Location = location
			Me._Line_4.Name = "_Line_4"
			Me.HelpProvider1.SetShowHelp(Me._Line_4, False)
			Dim line_6 As Global.System.Windows.Forms.Control = Me._Line_4
			size = New Global.System.Drawing.Size(400, 1)
			line_6.Size = size
			Me._Line_4.TabIndex = 52
			Me._Line_5.BackColor = Global.System.Drawing.Color.White
			Me._Line_5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9F)
			Me._Line_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim line_7 As Global.System.Windows.Forms.Control = Me._Line_5
			location = New Global.System.Drawing.Point(376, 56)
			line_7.Location = location
			Me._Line_5.Name = "_Line_5"
			Me.HelpProvider1.SetShowHelp(Me._Line_5, False)
			Dim line_8 As Global.System.Windows.Forms.Control = Me._Line_5
			size = New Global.System.Drawing.Size(240, 1)
			line_8.Size = size
			Me._Line_5.TabIndex = 53
			Me._Label_MotorSPV.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_MotorSPV.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_MotorSPV.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_MotorSPV.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_MotorSPV.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_MotorSPV As Global.System.Windows.Forms.Control = Me._Label_MotorSPV
			location = New Global.System.Drawing.Point(368, 88)
			label_MotorSPV.Location = location
			Me._Label_MotorSPV.Name = "_Label_MotorSPV"
			Me._Label_MotorSPV.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_MotorSPV, False)
			Dim label_MotorSPV2 As Global.System.Windows.Forms.Control = Me._Label_MotorSPV
			size = New Global.System.Drawing.Size(328, 24)
			label_MotorSPV2.Size = size
			Me._Label_MotorSPV.TabIndex = 47
			Me._Label_MotorSPV.Text = "Motor speed variation (%):"
			Me._Label_MotorSPV.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Line_6.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._Line_6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9F)
			Me._Line_6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim line_9 As Global.System.Windows.Forms.Control = Me._Line_6
			location = New Global.System.Drawing.Point(368, 120)
			line_9.Location = location
			Me._Line_6.Name = "_Line_6"
			Me.HelpProvider1.SetShowHelp(Me._Line_6, False)
			Dim line_10 As Global.System.Windows.Forms.Control = Me._Line_6
			size = New Global.System.Drawing.Size(400, 1)
			line_10.Size = size
			Me._Line_6.TabIndex = 54
			Me._Line_7.BackColor = Global.System.Drawing.Color.White
			Me._Line_7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9F)
			Me._Line_7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim line_11 As Global.System.Windows.Forms.Control = Me._Line_7
			location = New Global.System.Drawing.Point(376, 120)
			line_11.Location = location
			Me._Line_7.Name = "_Line_7"
			Me.HelpProvider1.SetShowHelp(Me._Line_7, False)
			Dim line_12 As Global.System.Windows.Forms.Control = Me._Line_7
			size = New Global.System.Drawing.Size(239, 1)
			line_12.Size = size
			Me._Line_7.TabIndex = 55
			Me._Label_Irot.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_Irot.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_Irot.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_Irot.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_Irot.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_Irot As Global.System.Windows.Forms.Control = Me._Label_Irot
			location = New Global.System.Drawing.Point(368, 152)
			label_Irot.Location = location
			Me._Label_Irot.Name = "_Label_Irot"
			Me._Label_Irot.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_Irot, False)
			Dim label_Irot2 As Global.System.Windows.Forms.Control = Me._Label_Irot
			size = New Global.System.Drawing.Size(328, 24)
			label_Irot2.Size = size
			Me._Label_Irot.TabIndex = 49
			Me._Label_Irot.Tag = "Rot. moment of inertia (^):"
			Me._Label_Irot.Text = "Rot. moment of inertia (lb-ft²):"
			Me._Label_Irot.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_Iart.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_Iart.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_Iart.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_Iart.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_Iart.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_Iart As Global.System.Windows.Forms.Control = Me._Label_Iart
			location = New Global.System.Drawing.Point(368, 176)
			label_Iart.Location = location
			Me._Label_Iart.Name = "_Label_Iart"
			Me._Label_Iart.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_Iart, False)
			Dim label_Iart2 As Global.System.Windows.Forms.Control = Me._Label_Iart
			size = New Global.System.Drawing.Size(328, 32)
			label_Iart2.Size = size
			Me._Label_Iart.TabIndex = 51
			Me._Label_Iart.Tag = "Art. moment of inertia (^):"
			Me._Label_Iart.Text = "Art. moment of inertia (lb-ft²):"
			Me._Label_Iart.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_MotorType.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_MotorType.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_MotorType.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_MotorType.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_MotorType.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_MotorType As Global.System.Windows.Forms.Control = Me._Label_MotorType
			location = New Global.System.Drawing.Point(8, 128)
			label_MotorType.Location = location
			Me._Label_MotorType.Name = "_Label_MotorType"
			Me._Label_MotorType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_MotorType, False)
			Dim label_MotorType2 As Global.System.Windows.Forms.Control = Me._Label_MotorType
			size = New Global.System.Drawing.Size(136, 19)
			label_MotorType2.Size = size
			Me._Label_MotorType.TabIndex = 33
			Me._Label_MotorType.Text = "Motor type:"
			Me.txtElectricityCost.AcceptsReturn = True
			Me.txtElectricityCost.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtElectricityCost.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtElectricityCost.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtElectricityCost.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtElectricityCost, "electricity cost (Motor information)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtElectricityCost, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtElectricityCost As Global.System.Windows.Forms.Control = Me.txtElectricityCost
			location = New Global.System.Drawing.Point(216, 16)
			txtElectricityCost.Location = location
			Me.txtElectricityCost.MaxLength = 10
			Me.txtElectricityCost.Name = "txtElectricityCost"
			Me.txtElectricityCost.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtElectricityCost, True)
			Dim txtElectricityCost2 As Global.System.Windows.Forms.Control = Me.txtElectricityCost
			size = New Global.System.Drawing.Size(72, 22)
			txtElectricityCost2.Size = size
			Me.txtElectricityCost.TabIndex = 29
			Me.optPowerMeterType_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optPowerMeterType_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optPowerMeterType_2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.optPowerMeterType_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optPowerMeterType_2, "power meter type")
			Me.HelpProvider1.SetHelpNavigator(Me.optPowerMeterType_2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optPowerMeterType_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPowerMeterType_ As Global.System.Windows.Forms.Control = Me.optPowerMeterType_2
			location = New Global.System.Drawing.Point(24, 88)
			optPowerMeterType_.Location = location
			Me.optPowerMeterType_2.Name = "optPowerMeterType_2"
			Me.optPowerMeterType_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optPowerMeterType_2, True)
			Dim optPowerMeterType_2 As Global.System.Windows.Forms.Control = Me.optPowerMeterType_2
			size = New Global.System.Drawing.Size(320, 24)
			optPowerMeterType_2.Size = size
			Me.optPowerMeterType_2.TabIndex = 32
			Me.optPowerMeterType_2.TabStop = True
			Me.optPowerMeterType_2.Text = "Non-detent (credit for generated power)"
			Me.optPowerMeterType_2.UseVisualStyleBackColor = False
			Me.optPowerMeterType_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optPowerMeterType_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optPowerMeterType_1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.optPowerMeterType_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optPowerMeterType_1, "power meter")
			Me.HelpProvider1.SetHelpNavigator(Me.optPowerMeterType_1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optPowerMeterType_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPowerMeterType_3 As Global.System.Windows.Forms.Control = Me.optPowerMeterType_1
			location = New Global.System.Drawing.Point(24, 64)
			optPowerMeterType_3.Location = location
			Me.optPowerMeterType_1.Name = "optPowerMeterType_1"
			Me.optPowerMeterType_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optPowerMeterType_1, True)
			Dim optPowerMeterType_4 As Global.System.Windows.Forms.Control = Me.optPowerMeterType_1
			size = New Global.System.Drawing.Size(320, 24)
			optPowerMeterType_4.Size = size
			Me.optPowerMeterType_1.TabIndex = 31
			Me.optPowerMeterType_1.TabStop = True
			Me.optPowerMeterType_1.Text = "Detent (no credit for generated power)"
			Me.optPowerMeterType_1.UseVisualStyleBackColor = False
			Me._Label_MeterType.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_MeterType.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_MeterType.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_MeterType.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_MeterType.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_MeterType As Global.System.Windows.Forms.Control = Me._Label_MeterType
			location = New Global.System.Drawing.Point(16, 48)
			label_MeterType.Location = location
			Me._Label_MeterType.Name = "_Label_MeterType"
			Me._Label_MeterType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_MeterType, False)
			Dim label_MeterType2 As Global.System.Windows.Forms.Control = Me._Label_MeterType
			size = New Global.System.Drawing.Size(328, 19)
			label_MeterType2.Size = size
			Me._Label_MeterType.TabIndex = 30
			Me._Label_MeterType.Text = "Power meter type:"
			Me._Label_ElectricityCost.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_ElectricityCost.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_ElectricityCost.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_ElectricityCost.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_ElectricityCost.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_ElectricityCost As Global.System.Windows.Forms.Control = Me._Label_ElectricityCost
			location = New Global.System.Drawing.Point(16, 16)
			label_ElectricityCost.Location = location
			Me._Label_ElectricityCost.Name = "_Label_ElectricityCost"
			Me._Label_ElectricityCost.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_ElectricityCost, False)
			Dim label_ElectricityCost2 As Global.System.Windows.Forms.Control = Me._Label_ElectricityCost
			size = New Global.System.Drawing.Size(192, 19)
			label_ElectricityCost2.Size = size
			Me._Label_ElectricityCost.TabIndex = 28
			Me._Label_ElectricityCost.Text = "Electricity cost ($/kwh):"
			Me._Label_ElectricityCost.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_MotorSize.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_MotorSize.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_MotorSize.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_MotorSize.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_MotorSize.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_MotorSize As Global.System.Windows.Forms.Control = Me._Label_MotorSize
			location = New Global.System.Drawing.Point(8, 152)
			label_MotorSize.Location = location
			Me._Label_MotorSize.Name = "_Label_MotorSize"
			Me._Label_MotorSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_MotorSize, False)
			Dim label_MotorSize2 As Global.System.Windows.Forms.Control = Me._Label_MotorSize
			size = New Global.System.Drawing.Size(136, 19)
			label_MotorSize2.Size = size
			Me._Label_MotorSize.TabIndex = 35
			Me._Label_MotorSize.Text = "Motor size:"
			Me._Label_MotorSetting.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_MotorSetting.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_MotorSetting.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_MotorSetting.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_MotorSetting.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_MotorSetting As Global.System.Windows.Forms.Control = Me._Label_MotorSetting
			location = New Global.System.Drawing.Point(8, 176)
			label_MotorSetting.Location = location
			Me._Label_MotorSetting.Name = "_Label_MotorSetting"
			Me._Label_MotorSetting.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_MotorSetting, False)
			Dim label_MotorSetting2 As Global.System.Windows.Forms.Control = Me._Label_MotorSetting
			size = New Global.System.Drawing.Size(136, 19)
			label_MotorSetting2.Size = size
			Me._Label_MotorSetting.TabIndex = 37
			Me._Label_MotorSetting.Text = "Motor setting:"
			Me._Label_MotorSetting.Visible = False
			Me._Line_0.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._Line_0.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Line_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim line_13 As Global.System.Windows.Forms.Control = Me._Line_0
			location = New Global.System.Drawing.Point(8, 120)
			line_13.Location = location
			Me._Line_0.Name = "_Line_0"
			Me.HelpProvider1.SetShowHelp(Me._Line_0, False)
			Dim line_14 As Global.System.Windows.Forms.Control = Me._Line_0
			size = New Global.System.Drawing.Size(335, 1)
			line_14.Size = size
			Me._Line_0.TabIndex = 39
			Me._Line_1.BackColor = Global.System.Drawing.Color.White
			Me._Line_1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Line_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim line_15 As Global.System.Windows.Forms.Control = Me._Line_1
			location = New Global.System.Drawing.Point(8, 120)
			line_15.Location = location
			Me._Line_1.Name = "_Line_1"
			Me.HelpProvider1.SetShowHelp(Me._Line_1, False)
			Dim line_16 As Global.System.Windows.Forms.Control = Me._Line_1
			size = New Global.System.Drawing.Size(290, 1)
			line_16.Size = size
			Me._Line_1.TabIndex = 40
			Me.cboMotorType.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboMotorType.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboMotorType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboMotorType.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboMotorType.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboMotorType, "Motor type")
			Me.HelpProvider1.SetHelpNavigator(Me.cboMotorType, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboMotorType.ItemHeight = 16
			Dim cboMotorType As Global.System.Windows.Forms.Control = Me.cboMotorType
			location = New Global.System.Drawing.Point(144, 128)
			cboMotorType.Location = location
			Me.cboMotorType.MaxDropDownItems = 14
			Me.cboMotorType.Name = "cboMotorType"
			Me.cboMotorType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboMotorType, True)
			Dim cboMotorType2 As Global.System.Windows.Forms.Control = Me.cboMotorType
			size = New Global.System.Drawing.Size(200, 24)
			cboMotorType2.Size = size
			Me.cboMotorType.Sorted = True
			Me.cboMotorType.TabIndex = 34
			Me.cboMotorSize.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboMotorSize.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboMotorSize.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboMotorSize.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboMotorSize.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboMotorSize, "Motor size")
			Me.HelpProvider1.SetHelpNavigator(Me.cboMotorSize, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboMotorSize.ItemHeight = 16
			Dim cboMotorSize As Global.System.Windows.Forms.Control = Me.cboMotorSize
			location = New Global.System.Drawing.Point(144, 152)
			cboMotorSize.Location = location
			Me.cboMotorSize.Name = "cboMotorSize"
			Me.cboMotorSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboMotorSize, True)
			Dim cboMotorSize2 As Global.System.Windows.Forms.Control = Me.cboMotorSize
			size = New Global.System.Drawing.Size(200, 24)
			cboMotorSize2.Size = size
			Me.cboMotorSize.TabIndex = 36
			Me.cboMotorSetting.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboMotorSetting.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboMotorSetting.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboMotorSetting.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboMotorSetting.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboMotorSetting, "Torque Mode")
			Me.HelpProvider1.SetHelpNavigator(Me.cboMotorSetting, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboMotorSetting.ItemHeight = 16
			Dim cboMotorSetting As Global.System.Windows.Forms.Control = Me.cboMotorSetting
			location = New Global.System.Drawing.Point(144, 176)
			cboMotorSetting.Location = location
			Me.cboMotorSetting.Name = "cboMotorSetting"
			Me.cboMotorSetting.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboMotorSetting, True)
			Dim cboMotorSetting2 As Global.System.Windows.Forms.Control = Me.cboMotorSetting
			size = New Global.System.Drawing.Size(200, 24)
			cboMotorSetting2.Size = size
			Me.cboMotorSetting.TabIndex = 38
			Me.txtIrot.AcceptsReturn = True
			Me.txtIrot.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtIrot.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtIrot.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtIrot.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtIrot, "Motor Data: Rotating moment of inertia")
			Me.HelpProvider1.SetHelpNavigator(Me.txtIrot, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtIrot As Global.System.Windows.Forms.Control = Me.txtIrot
			location = New Global.System.Drawing.Point(704, 152)
			txtIrot.Location = location
			Me.txtIrot.MaxLength = 10
			Me.txtIrot.Name = "txtIrot"
			Me.txtIrot.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtIrot, True)
			Dim txtIrot2 As Global.System.Windows.Forms.Control = Me.txtIrot
			size = New Global.System.Drawing.Size(72, 22)
			txtIrot2.Size = size
			Me.txtIrot.TabIndex = 45
			Me.txtIrot.Tag = "Nee"
			Me.txtIart.AcceptsReturn = True
			Me.txtIart.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtIart.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtIart.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtIart.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtIart, "Articulating Moment of Inertia")
			Me.HelpProvider1.SetHelpNavigator(Me.txtIart, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtIart As Global.System.Windows.Forms.Control = Me.txtIart
			location = New Global.System.Drawing.Point(704, 176)
			txtIart.Location = location
			Me.txtIart.MaxLength = 10
			Me.txtIart.Name = "txtIart"
			Me.txtIart.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtIart, True)
			Dim txtIart2 As Global.System.Windows.Forms.Control = Me.txtIart
			size = New Global.System.Drawing.Size(72, 22)
			txtIart2.Size = size
			Me.txtIart.TabIndex = 46
			Me.txtIart.Tag = "Nee"
			Me.txtMotorSPV.AcceptsReturn = True
			Me.txtMotorSPV.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMotorSPV.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMotorSPV.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtMotorSPV.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMotorSPV, "Motor Speed Variation")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMotorSPV, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMotorSPV As Global.System.Windows.Forms.Control = Me.txtMotorSPV
			location = New Global.System.Drawing.Point(704, 88)
			txtMotorSPV.Location = location
			Me.txtMotorSPV.MaxLength = 10
			Me.txtMotorSPV.Name = "txtMotorSPV"
			Me.txtMotorSPV.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMotorSPV, True)
			Dim txtMotorSPV2 As Global.System.Windows.Forms.Control = Me.txtMotorSPV
			size = New Global.System.Drawing.Size(72, 22)
			txtMotorSPV2.Size = size
			Me.txtMotorSPV.TabIndex = 43
			Me.chkCalculateIrot.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkCalculateIrot.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkCalculateIrot.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkCalculateIrot.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.chkCalculateIrot, "Calculate Rotating Moment of Inertia")
			Me.HelpProvider1.SetHelpNavigator(Me.chkCalculateIrot, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkCalculateIrot.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkCalculateIrot As Global.System.Windows.Forms.Control = Me.chkCalculateIrot
			location = New Global.System.Drawing.Point(376, 128)
			chkCalculateIrot.Location = location
			Me.chkCalculateIrot.Name = "chkCalculateIrot"
			Me.chkCalculateIrot.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkCalculateIrot, True)
			Dim chkCalculateIrot2 As Global.System.Windows.Forms.Control = Me.chkCalculateIrot
			size = New Global.System.Drawing.Size(376, 24)
			chkCalculateIrot2.Size = size
			Me.chkCalculateIrot.TabIndex = 44
			Me.chkCalculateIrot.Text = "Calculate rotating moment of inertia"
			Me.chkCalculateIrot.UseVisualStyleBackColor = False
			Me.chkCalcMotorSPV.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkCalcMotorSPV.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkCalcMotorSPV.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkCalcMotorSPV.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.chkCalcMotorSPV, "Calculate motor speed variation")
			Me.HelpProvider1.SetHelpNavigator(Me.chkCalcMotorSPV, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkCalcMotorSPV.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkCalcMotorSPV As Global.System.Windows.Forms.Control = Me.chkCalcMotorSPV
			location = New Global.System.Drawing.Point(376, 64)
			chkCalcMotorSPV.Location = location
			Me.chkCalcMotorSPV.Name = "chkCalcMotorSPV"
			Me.chkCalcMotorSPV.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkCalcMotorSPV, True)
			Dim chkCalcMotorSPV2 As Global.System.Windows.Forms.Control = Me.chkCalcMotorSPV
			size = New Global.System.Drawing.Size(376, 24)
			chkCalcMotorSPV2.Size = size
			Me.chkCalcMotorSPV.TabIndex = 42
			Me.chkCalcMotorSPV.Text = "Calculate motor speed variation"
			Me.chkCalcMotorSPV.UseVisualStyleBackColor = False
			Me.lblIrot_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblIrot_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblIrot_Disabled As Global.System.Windows.Forms.Control = Me.lblIrot_Disabled
			location = New Global.System.Drawing.Point(704, 152)
			lblIrot_Disabled.Location = location
			Me.lblIrot_Disabled.Name = "lblIrot_Disabled"
			Dim lblIrot_Disabled2 As Global.System.Windows.Forms.Control = Me.lblIrot_Disabled
			size = New Global.System.Drawing.Size(72, 20)
			lblIrot_Disabled2.Size = size
			Me.lblIrot_Disabled.TabIndex = 57
			Me.lblIart_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblIart_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblIart_Disabled As Global.System.Windows.Forms.Control = Me.lblIart_Disabled
			location = New Global.System.Drawing.Point(704, 176)
			lblIart_Disabled.Location = location
			Me.lblIart_Disabled.Name = "lblIart_Disabled"
			Dim lblIart_Disabled2 As Global.System.Windows.Forms.Control = Me.lblIart_Disabled
			size = New Global.System.Drawing.Size(72, 20)
			lblIart_Disabled2.Size = size
			Me.lblIart_Disabled.TabIndex = 58
			Me.lblMotorSPV_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblMotorSPV_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblMotorSPV_Disabled As Global.System.Windows.Forms.Control = Me.lblMotorSPV_Disabled
			location = New Global.System.Drawing.Point(704, 88)
			lblMotorSPV_Disabled.Location = location
			Me.lblMotorSPV_Disabled.Name = "lblMotorSPV_Disabled"
			Dim lblMotorSPV_Disabled2 As Global.System.Windows.Forms.Control = Me.lblMotorSPV_Disabled
			size = New Global.System.Drawing.Size(72, 20)
			lblMotorSPV_Disabled2.Size = size
			Me.lblMotorSPV_Disabled.TabIndex = 56
			Me.ToolTip1.ShowAlways = True
			Me.pnlMotorPairs.Controls.Add(Me.btnRefresh)
			Me.pnlMotorPairs.Controls.Add(Me.lblWorking)
			Me.pnlMotorPairs.Controls.Add(Me.btnUpdateDB)
			Me.pnlMotorPairs.Controls.Add(Me.lblMotor)
			Me.pnlMotorPairs.Controls.Add(Me.btnCloseMotorPairs)
			Me.pnlMotorPairs.Controls.Add(Me.chtMotorPairs)
			Dim pnlMotorPairs As Global.System.Windows.Forms.Control = Me.pnlMotorPairs
			location = New Global.System.Drawing.Point(-1333, 0)
			pnlMotorPairs.Location = location
			Me.pnlMotorPairs.Name = "pnlMotorPairs"
			Dim pnlMotorPairs2 As Global.System.Windows.Forms.Control = Me.pnlMotorPairs
			size = New Global.System.Drawing.Size(792, 487)
			pnlMotorPairs2.Size = size
			Me.pnlMotorPairs.TabIndex = 3
			Me.pnlMotorPairs.Visible = False
			Dim btnRefresh As Global.System.Windows.Forms.Control = Me.btnRefresh
			location = New Global.System.Drawing.Point(136, 453)
			btnRefresh.Location = location
			Me.btnRefresh.Name = "btnRefresh"
			Dim btnRefresh2 As Global.System.Windows.Forms.Control = Me.btnRefresh
			size = New Global.System.Drawing.Size(87, 25)
			btnRefresh2.Size = size
			Me.btnRefresh.TabIndex = 8
			Me.btnRefresh.Text = "Refresh"
			Me.btnRefresh.UseVisualStyleBackColor = True
			Me.lblWorking.AutoSize = True
			Me.lblWorking.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblWorking As Global.System.Windows.Forms.Control = Me.lblWorking
			location = New Global.System.Drawing.Point(352, 459)
			lblWorking.Location = location
			Me.lblWorking.Name = "lblWorking"
			Dim lblWorking2 As Global.System.Windows.Forms.Control = Me.lblWorking
			size = New Global.System.Drawing.Size(61, 16)
			lblWorking2.Size = size
			Me.lblWorking.TabIndex = 7
			Me.lblWorking.Text = "Working!"
			Dim btnUpdateDB As Global.System.Windows.Forms.Control = Me.btnUpdateDB
			location = New Global.System.Drawing.Point(24, 453)
			btnUpdateDB.Location = location
			Me.btnUpdateDB.Name = "btnUpdateDB"
			Dim btnUpdateDB2 As Global.System.Windows.Forms.Control = Me.btnUpdateDB
			size = New Global.System.Drawing.Size(87, 25)
			btnUpdateDB2.Size = size
			Me.btnUpdateDB.TabIndex = 6
			Me.btnUpdateDB.Text = "Update DB"
			Me.btnUpdateDB.UseVisualStyleBackColor = True
			Me.lblMotor.AutoSize = True
			Dim lblMotor As Global.System.Windows.Forms.Control = Me.lblMotor
			location = New Global.System.Drawing.Point(11, 8)
			lblMotor.Location = location
			Me.lblMotor.Name = "lblMotor"
			Dim lblMotor2 As Global.System.Windows.Forms.Control = Me.lblMotor
			size = New Global.System.Drawing.Size(34, 13)
			lblMotor2.Size = size
			Me.lblMotor.TabIndex = 5
			Me.lblMotor.Text = "Motor"
			Dim btnCloseMotorPairs As Global.System.Windows.Forms.Control = Me.btnCloseMotorPairs
			location = New Global.System.Drawing.Point(681, 453)
			btnCloseMotorPairs.Location = location
			Me.btnCloseMotorPairs.Name = "btnCloseMotorPairs"
			Dim btnCloseMotorPairs2 As Global.System.Windows.Forms.Control = Me.btnCloseMotorPairs
			size = New Global.System.Drawing.Size(87, 25)
			btnCloseMotorPairs2.Size = size
			Me.btnCloseMotorPairs.TabIndex = 4
			Me.btnCloseMotorPairs.Text = "Close"
			Me.btnCloseMotorPairs.UseVisualStyleBackColor = True
			Me.chtMotorPairs.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.chtMotorPairs.AllSeries.MarkerSize = 4S
			Me.chtMotorPairs.AxisX.ForceZero = False
			Me.chtMotorPairs.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtMotorPairs.AxisX.Grids.Major.Visible = False
			Me.chtMotorPairs.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.chtMotorPairs.AxisY.ForceZero = False
			Me.chtMotorPairs.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtMotorPairs.AxisY.Grids.Major.Visible = False
			Me.chtMotorPairs.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.chtMotorPairs.Border = border
			Me.chtMotorPairs.LegendBox.ContentLayout = Global.ChartFX.WinForms.ContentLayout.Spread
			Me.chtMotorPairs.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chtMotorPairs As Global.System.Windows.Forms.Control = Me.chtMotorPairs
			location = New Global.System.Drawing.Point(24, 24)
			chtMotorPairs.Location = location
			Me.chtMotorPairs.Name = "chtMotorPairs"
			Me.chtMotorPairs.RandomData.Series = 2
			Dim chtMotorPairs2 As Global.System.Windows.Forms.Control = Me.chtMotorPairs
			size = New Global.System.Drawing.Size(744, 423)
			chtMotorPairs2.Size = size
			Me.chtMotorPairs.TabIndex = 2
			titleDockable.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			titleDockable.Text = "RPM/Torque Pairs"
			Me.chtMotorPairs.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable })
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(805, 282)
			Me.ClientSize = size
			Me.Controls.Add(Me.pnlMotorPairs)
			Me.Controls.Add(Me.pnlMotorData)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "MotorData"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Motor Information"
			Me.pnlMotorData.ResumeLayout(False)
			Me.pnlMotorData.PerformLayout()
			Me.pnlMotorPairs.ResumeLayout(False)
			Me.pnlMotorPairs.PerformLayout()
			CType(Me.chtMotorPairs, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
