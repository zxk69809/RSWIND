Namespace RSWINV3
	Public Partial Class WellInfo
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.WellInfo))
			Me.pnlWellInfo = New Global.System.Windows.Forms.Panel()
			Me._linSeparator_5 = New Global.System.Windows.Forms.Label()
			Me._linSeparator_4 = New Global.System.Windows.Forms.Label()
			Me._Label_ParaffinDepth = New Global.System.Windows.Forms.Label()
			Me.chkParaffin = New Global.System.Windows.Forms.CheckBox()
			Me.cboPRDiameter = New Global.System.Windows.Forms.ComboBox()
			Me.lblPRDiam = New Global.System.Windows.Forms.Label()
			Me.btnCoverPageComments = New Global.System.Windows.Forms.Button()
			Me.btnUpdateDate = New Global.System.Windows.Forms.Button()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me._linSeparator_2 = New Global.System.Windows.Forms.Label()
			Me._optPumpCondition_0 = New Global.System.Windows.Forms.RadioButton()
			Me._optPumpCondition_3 = New Global.System.Windows.Forms.RadioButton()
			Me._optPumpCondition_2 = New Global.System.Windows.Forms.RadioButton()
			Me._optPumpCondition_1 = New Global.System.Windows.Forms.RadioButton()
			Me._Label_PumpFillage = New Global.System.Windows.Forms.Label()
			Me._Label_PumpEfficiency = New Global.System.Windows.Forms.Label()
			Me._Label_PumpCondition = New Global.System.Windows.Forms.Label()
			Me.txtPumpLoadAdj = New Global.System.Windows.Forms.TextBox()
			Me.txtStuffingBoxFriction = New Global.System.Windows.Forms.TextBox()
			Me.lblPumpLoadAdj = New Global.System.Windows.Forms.Label()
			Me.lblStuffingBoxFriction = New Global.System.Windows.Forms.Label()
			Me.chkCalcFluidSPGR = New Global.System.Windows.Forms.CheckBox()
			Me.txtComment = New Global.System.Windows.Forms.RichTextBox()
			Me.txtOilAPI = New Global.System.Windows.Forms.TextBox()
			Me.txtWaterSPGR = New Global.System.Windows.Forms.TextBox()
			Me.txtWaterCut = New Global.System.Windows.Forms.TextBox()
			Me.txtCasingPressure = New Global.System.Windows.Forms.TextBox()
			Me.txtTubingPressure = New Global.System.Windows.Forms.TextBox()
			Me.txtRuntime = New Global.System.Windows.Forms.TextBox()
			Me.txtPumpDepth = New Global.System.Windows.Forms.TextBox()
			Me.txtUserDate = New Global.System.Windows.Forms.TextBox()
			Me.txtUserName = New Global.System.Windows.Forms.TextBox()
			Me.txtWellName = New Global.System.Windows.Forms.TextBox()
			Me.txtCompanyName = New Global.System.Windows.Forms.TextBox()
			Me._Label_FluidSPGR = New Global.System.Windows.Forms.Label()
			Me._Label_OilAPI = New Global.System.Windows.Forms.Label()
			Me._Label_WaterSPGR = New Global.System.Windows.Forms.Label()
			Me._Label_WaterCut = New Global.System.Windows.Forms.Label()
			Me._Label_CasingPressure = New Global.System.Windows.Forms.Label()
			Me._Label_TubingPressure = New Global.System.Windows.Forms.Label()
			Me._Label_RunTime = New Global.System.Windows.Forms.Label()
			Me._Label_PumpDepth = New Global.System.Windows.Forms.Label()
			Me._linSeparator_3 = New Global.System.Windows.Forms.Label()
			Me._linSeparator_1 = New Global.System.Windows.Forms.Label()
			Me._linSeparator_0 = New Global.System.Windows.Forms.Label()
			Me._Label_UserName = New Global.System.Windows.Forms.Label()
			Me._Label_UserDate = New Global.System.Windows.Forms.Label()
			Me._Label_Comment = New Global.System.Windows.Forms.Label()
			Me._Label_WellName = New Global.System.Windows.Forms.Label()
			Me._Label_CompanyName = New Global.System.Windows.Forms.Label()
			Me.txtPRDiameter = New Global.System.Windows.Forms.TextBox()
			Me.txtPumpEfficiency = New Global.System.Windows.Forms.TextBox()
			Me.lblPumpEfficiency_Disabled = New Global.System.Windows.Forms.Label()
			Me.txtPumpFillage = New Global.System.Windows.Forms.TextBox()
			Me.lblPumpFillage_Disabled = New Global.System.Windows.Forms.Label()
			Me.txtFluidSPGR = New Global.System.Windows.Forms.TextBox()
			Me.lblFluidSPGR_Disabled = New Global.System.Windows.Forms.Label()
			Me.lblPRDiameter_Disabled = New Global.System.Windows.Forms.Label()
			Me.lblParaffinDepth_Disabled = New Global.System.Windows.Forms.Label()
			Me.txtParaffinDepth = New Global.System.Windows.Forms.TextBox()
			Me.ContextMenu1 = New Global.System.Windows.Forms.ContextMenu()
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.pnlWellInfo.SuspendLayout()
			Me.SuspendLayout()
			Me.pnlWellInfo.Controls.Add(Me._linSeparator_5)
			Me.pnlWellInfo.Controls.Add(Me._linSeparator_4)
			Me.pnlWellInfo.Controls.Add(Me._Label_ParaffinDepth)
			Me.pnlWellInfo.Controls.Add(Me.chkParaffin)
			Me.pnlWellInfo.Controls.Add(Me.cboPRDiameter)
			Me.pnlWellInfo.Controls.Add(Me.lblPRDiam)
			Me.pnlWellInfo.Controls.Add(Me.btnCoverPageComments)
			Me.pnlWellInfo.Controls.Add(Me.btnUpdateDate)
			Me.pnlWellInfo.Controls.Add(Me.Label2)
			Me.pnlWellInfo.Controls.Add(Me._linSeparator_2)
			Me.pnlWellInfo.Controls.Add(Me._optPumpCondition_0)
			Me.pnlWellInfo.Controls.Add(Me._optPumpCondition_3)
			Me.pnlWellInfo.Controls.Add(Me._optPumpCondition_2)
			Me.pnlWellInfo.Controls.Add(Me._optPumpCondition_1)
			Me.pnlWellInfo.Controls.Add(Me._Label_PumpFillage)
			Me.pnlWellInfo.Controls.Add(Me._Label_PumpEfficiency)
			Me.pnlWellInfo.Controls.Add(Me._Label_PumpCondition)
			Me.pnlWellInfo.Controls.Add(Me.txtPumpLoadAdj)
			Me.pnlWellInfo.Controls.Add(Me.txtStuffingBoxFriction)
			Me.pnlWellInfo.Controls.Add(Me.lblPumpLoadAdj)
			Me.pnlWellInfo.Controls.Add(Me.lblStuffingBoxFriction)
			Me.pnlWellInfo.Controls.Add(Me.chkCalcFluidSPGR)
			Me.pnlWellInfo.Controls.Add(Me.txtComment)
			Me.pnlWellInfo.Controls.Add(Me.txtOilAPI)
			Me.pnlWellInfo.Controls.Add(Me.txtWaterSPGR)
			Me.pnlWellInfo.Controls.Add(Me.txtWaterCut)
			Me.pnlWellInfo.Controls.Add(Me.txtCasingPressure)
			Me.pnlWellInfo.Controls.Add(Me.txtTubingPressure)
			Me.pnlWellInfo.Controls.Add(Me.txtRuntime)
			Me.pnlWellInfo.Controls.Add(Me.txtPumpDepth)
			Me.pnlWellInfo.Controls.Add(Me.txtUserDate)
			Me.pnlWellInfo.Controls.Add(Me.txtUserName)
			Me.pnlWellInfo.Controls.Add(Me.txtWellName)
			Me.pnlWellInfo.Controls.Add(Me.txtCompanyName)
			Me.pnlWellInfo.Controls.Add(Me._Label_FluidSPGR)
			Me.pnlWellInfo.Controls.Add(Me._Label_OilAPI)
			Me.pnlWellInfo.Controls.Add(Me._Label_WaterSPGR)
			Me.pnlWellInfo.Controls.Add(Me._Label_WaterCut)
			Me.pnlWellInfo.Controls.Add(Me._Label_CasingPressure)
			Me.pnlWellInfo.Controls.Add(Me._Label_TubingPressure)
			Me.pnlWellInfo.Controls.Add(Me._Label_RunTime)
			Me.pnlWellInfo.Controls.Add(Me._Label_PumpDepth)
			Me.pnlWellInfo.Controls.Add(Me._linSeparator_3)
			Me.pnlWellInfo.Controls.Add(Me._linSeparator_1)
			Me.pnlWellInfo.Controls.Add(Me._linSeparator_0)
			Me.pnlWellInfo.Controls.Add(Me._Label_UserName)
			Me.pnlWellInfo.Controls.Add(Me._Label_UserDate)
			Me.pnlWellInfo.Controls.Add(Me._Label_Comment)
			Me.pnlWellInfo.Controls.Add(Me._Label_WellName)
			Me.pnlWellInfo.Controls.Add(Me._Label_CompanyName)
			Me.pnlWellInfo.Controls.Add(Me.txtPRDiameter)
			Me.pnlWellInfo.Controls.Add(Me.txtPumpEfficiency)
			Me.pnlWellInfo.Controls.Add(Me.lblPumpEfficiency_Disabled)
			Me.pnlWellInfo.Controls.Add(Me.txtPumpFillage)
			Me.pnlWellInfo.Controls.Add(Me.lblPumpFillage_Disabled)
			Me.pnlWellInfo.Controls.Add(Me.txtFluidSPGR)
			Me.pnlWellInfo.Controls.Add(Me.lblFluidSPGR_Disabled)
			Me.pnlWellInfo.Controls.Add(Me.lblPRDiameter_Disabled)
			Me.pnlWellInfo.Controls.Add(Me.lblParaffinDepth_Disabled)
			Me.pnlWellInfo.Controls.Add(Me.txtParaffinDepth)
			Dim pnlWellInfo As Global.System.Windows.Forms.Control = Me.pnlWellInfo
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(8, 5)
			pnlWellInfo.Location = location
			Me.pnlWellInfo.Name = "pnlWellInfo"
			Me.HelpProvider1.SetShowHelp(Me.pnlWellInfo, False)
			Dim pnlWellInfo2 As Global.System.Windows.Forms.Control = Me.pnlWellInfo
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(928, 349)
			pnlWellInfo2.Size = size
			Me.pnlWellInfo.TabIndex = 100
			Me._linSeparator_5.BackColor = Global.System.Drawing.Color.White
			Me._linSeparator_5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim linSeparator_ As Global.System.Windows.Forms.Control = Me._linSeparator_5
			location = New Global.System.Drawing.Point(423, 296)
			linSeparator_.Location = location
			Me._linSeparator_5.Name = "_linSeparator_5"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_5, False)
			Dim linSeparator_2 As Global.System.Windows.Forms.Control = Me._linSeparator_5
			size = New Global.System.Drawing.Size(490, 1)
			linSeparator_2.Size = size
			Me._linSeparator_5.TabIndex = 230
			Me._linSeparator_4.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._linSeparator_4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim linSeparator_3 As Global.System.Windows.Forms.Control = Me._linSeparator_4
			location = New Global.System.Drawing.Point(423, 294)
			linSeparator_3.Location = location
			Me._linSeparator_4.Name = "_linSeparator_4"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_4, False)
			Dim linSeparator_4 As Global.System.Windows.Forms.Control = Me._linSeparator_4
			size = New Global.System.Drawing.Size(490, 1)
			linSeparator_4.Size = size
			Me._linSeparator_4.TabIndex = 231
			Me._Label_ParaffinDepth.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_ParaffinDepth.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_ParaffinDepth.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_ParaffinDepth.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_ParaffinDepth.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_ParaffinDepth As Global.System.Windows.Forms.Control = Me._Label_ParaffinDepth
			location = New Global.System.Drawing.Point(495, 321)
			label_ParaffinDepth.Location = location
			Me._Label_ParaffinDepth.Name = "_Label_ParaffinDepth"
			Me._Label_ParaffinDepth.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_ParaffinDepth, False)
			Dim label_ParaffinDepth2 As Global.System.Windows.Forms.Control = Me._Label_ParaffinDepth
			size = New Global.System.Drawing.Size(327, 22)
			label_ParaffinDepth2.Size = size
			Me._Label_ParaffinDepth.TabIndex = 228
			Me._Label_ParaffinDepth.Tag = "Depth from surface to first paraffin accumulation (^) : "
			Me._Label_ParaffinDepth.Text = "Depth from surface to first paraffin accumulation (ft) : "
			Me._Label_ParaffinDepth.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkParaffin.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkParaffin.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkParaffin As Global.System.Windows.Forms.Control = Me.chkParaffin
			location = New Global.System.Drawing.Point(425, 300)
			chkParaffin.Location = location
			Me.chkParaffin.Name = "chkParaffin"
			Me.chkParaffin.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.HelpProvider1.SetShowHelp(Me.chkParaffin, False)
			Dim chkParaffin2 As Global.System.Windows.Forms.Control = Me.chkParaffin
			size = New Global.System.Drawing.Size(215, 23)
			chkParaffin2.Size = size
			Me.chkParaffin.TabIndex = 226
			Me.chkParaffin.Text = "Paraffin accumulation expected"
			Me.cboPRDiameter.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboPRDiameter.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboPRDiameter.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboPRDiameter.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cboPRDiameter.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboPRDiameter, "Polished Rod Diameter")
			Me.HelpProvider1.SetHelpNavigator(Me.cboPRDiameter, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboPRDiameter.ItemHeight = 16
			Dim cboPRDiameter As Global.System.Windows.Forms.Control = Me.cboPRDiameter
			location = New Global.System.Drawing.Point(672, 110)
			cboPRDiameter.Location = location
			Me.cboPRDiameter.MaxDropDownItems = 20
			Me.cboPRDiameter.Name = "cboPRDiameter"
			Me.cboPRDiameter.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboPRDiameter, True)
			Dim cboPRDiameter2 As Global.System.Windows.Forms.Control = Me.cboPRDiameter
			size = New Global.System.Drawing.Size(136, 24)
			cboPRDiameter2.Size = size
			Me.cboPRDiameter.TabIndex = 173
			Me.cboPRDiameter.TabStop = False
			Me.lblPRDiam.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblPRDiam.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblPRDiam.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblPRDiam.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblPRDiam.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblPRDiam As Global.System.Windows.Forms.Control = Me.lblPRDiam
			location = New Global.System.Drawing.Point(424, 110)
			lblPRDiam.Location = location
			Me.lblPRDiam.Name = "lblPRDiam"
			Me.lblPRDiam.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblPRDiam, False)
			Dim lblPRDiam2 As Global.System.Windows.Forms.Control = Me.lblPRDiam
			size = New Global.System.Drawing.Size(238, 20)
			lblPRDiam2.Size = size
			Me.lblPRDiam.TabIndex = 221
			Me.lblPRDiam.Tag = "Polished rod diameter (^):"
			Me.lblPRDiam.Text = "Polished rod diameter (in) :"
			Me.lblPRDiam.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.btnCoverPageComments.Image = CType(componentResourceManager.GetObject("btnCoverPageComments.Image"), Global.System.Drawing.Image)
			Dim btnCoverPageComments As Global.System.Windows.Forms.Control = Me.btnCoverPageComments
			location = New Global.System.Drawing.Point(392, 120)
			btnCoverPageComments.Location = location
			Me.btnCoverPageComments.Name = "btnCoverPageComments"
			Dim btnCoverPageComments2 As Global.System.Windows.Forms.Control = Me.btnCoverPageComments
			size = New Global.System.Drawing.Size(20, 20)
			btnCoverPageComments2.Size = size
			Me.btnCoverPageComments.TabIndex = 219
			Me.btnUpdateDate.Image = CType(componentResourceManager.GetObject("btnUpdateDate.Image"), Global.System.Drawing.Image)
			Dim btnUpdateDate As Global.System.Windows.Forms.Control = Me.btnUpdateDate
			location = New Global.System.Drawing.Point(887, 10)
			btnUpdateDate.Location = location
			Me.btnUpdateDate.Name = "btnUpdateDate"
			Dim btnUpdateDate2 As Global.System.Windows.Forms.Control = Me.btnUpdateDate
			size = New Global.System.Drawing.Size(24, 20)
			btnUpdateDate2.Size = size
			Me.btnUpdateDate.TabIndex = 218
			Me.Label2.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(416, 8)
			label.Location = location
			Me.Label2.Name = "Label2"
			Me.HelpProvider1.SetShowHelp(Me.Label2, False)
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(1, 135)
			label2.Size = size
			Me.Label2.TabIndex = 197
			Me._linSeparator_2.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._linSeparator_2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim linSeparator_5 As Global.System.Windows.Forms.Control = Me._linSeparator_2
			location = New Global.System.Drawing.Point(416, 157)
			linSeparator_5.Location = location
			Me._linSeparator_2.Name = "_linSeparator_2"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_2, False)
			Dim linSeparator_6 As Global.System.Windows.Forms.Control = Me._linSeparator_2
			size = New Global.System.Drawing.Size(1, 185)
			linSeparator_6.Size = size
			Me._linSeparator_2.TabIndex = 195
			Me._optPumpCondition_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPumpCondition_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPumpCondition_0.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._optPumpCondition_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._optPumpCondition_0, "pump condition")
			Me.HelpProvider1.SetHelpNavigator(Me._optPumpCondition_0, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optPumpCondition_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpCondition_ As Global.System.Windows.Forms.Control = Me._optPumpCondition_0
			location = New Global.System.Drawing.Point(16, 240)
			optPumpCondition_.Location = location
			Me._optPumpCondition_0.Name = "_optPumpCondition_0"
			Me._optPumpCondition_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optPumpCondition_0, True)
			Dim optPumpCondition_2 As Global.System.Windows.Forms.Control = Me._optPumpCondition_0
			size = New Global.System.Drawing.Size(368, 20)
			optPumpCondition_2.Size = size
			Me._optPumpCondition_0.TabIndex = 165
			Me._optPumpCondition_0.TabStop = True
			Me._optPumpCondition_0.Text = "Calculate pump condition and fillage"
			Me._optPumpCondition_0.UseVisualStyleBackColor = False
			Me._optPumpCondition_3.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPumpCondition_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPumpCondition_3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._optPumpCondition_3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._optPumpCondition_3, "pump condition")
			Me.HelpProvider1.SetHelpNavigator(Me._optPumpCondition_3, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optPumpCondition_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpCondition_3 As Global.System.Windows.Forms.Control = Me._optPumpCondition_3
			location = New Global.System.Drawing.Point(16, 220)
			optPumpCondition_3.Location = location
			Me._optPumpCondition_3.Name = "_optPumpCondition_3"
			Me._optPumpCondition_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optPumpCondition_3, True)
			Dim optPumpCondition_4 As Global.System.Windows.Forms.Control = Me._optPumpCondition_3
			size = New Global.System.Drawing.Size(368, 20)
			optPumpCondition_4.Size = size
			Me._optPumpCondition_3.TabIndex = 164
			Me._optPumpCondition_3.TabStop = True
			Me._optPumpCondition_3.Text = "Gas interference"
			Me._optPumpCondition_3.UseVisualStyleBackColor = False
			Me._optPumpCondition_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPumpCondition_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPumpCondition_2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._optPumpCondition_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._optPumpCondition_2, "pump condition")
			Me.HelpProvider1.SetHelpNavigator(Me._optPumpCondition_2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optPumpCondition_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpCondition_5 As Global.System.Windows.Forms.Control = Me._optPumpCondition_2
			location = New Global.System.Drawing.Point(16, 200)
			optPumpCondition_5.Location = location
			Me._optPumpCondition_2.Name = "_optPumpCondition_2"
			Me._optPumpCondition_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optPumpCondition_2, True)
			Dim optPumpCondition_6 As Global.System.Windows.Forms.Control = Me._optPumpCondition_2
			size = New Global.System.Drawing.Size(368, 20)
			optPumpCondition_6.Size = size
			Me._optPumpCondition_2.TabIndex = 163
			Me._optPumpCondition_2.TabStop = True
			Me._optPumpCondition_2.Text = "Fluid pound"
			Me._optPumpCondition_2.UseVisualStyleBackColor = False
			Me._optPumpCondition_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPumpCondition_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPumpCondition_1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._optPumpCondition_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._optPumpCondition_1, "pump condition")
			Me.HelpProvider1.SetHelpNavigator(Me._optPumpCondition_1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optPumpCondition_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpCondition_7 As Global.System.Windows.Forms.Control = Me._optPumpCondition_1
			location = New Global.System.Drawing.Point(16, 180)
			optPumpCondition_7.Location = location
			Me._optPumpCondition_1.Name = "_optPumpCondition_1"
			Me._optPumpCondition_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optPumpCondition_1, True)
			Dim optPumpCondition_8 As Global.System.Windows.Forms.Control = Me._optPumpCondition_1
			size = New Global.System.Drawing.Size(368, 20)
			optPumpCondition_8.Size = size
			Me._optPumpCondition_1.TabIndex = 162
			Me._optPumpCondition_1.TabStop = True
			Me._optPumpCondition_1.Text = "Full pump"
			Me._optPumpCondition_1.UseVisualStyleBackColor = False
			Me._Label_PumpFillage.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_PumpFillage.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_PumpFillage.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_PumpFillage.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_PumpFillage.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_PumpFillage As Global.System.Windows.Forms.Control = Me._Label_PumpFillage
			location = New Global.System.Drawing.Point(8, 292)
			label_PumpFillage.Location = location
			Me._Label_PumpFillage.Name = "_Label_PumpFillage"
			Me._Label_PumpFillage.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_PumpFillage, False)
			Dim label_PumpFillage2 As Global.System.Windows.Forms.Control = Me._Label_PumpFillage
			size = New Global.System.Drawing.Size(288, 20)
			label_PumpFillage2.Size = size
			Me._Label_PumpFillage.TabIndex = 206
			Me._Label_PumpFillage.Text = "Pump fillage (%):"
			Me._Label_PumpFillage.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_PumpEfficiency.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_PumpEfficiency.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_PumpEfficiency.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_PumpEfficiency.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_PumpEfficiency.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_PumpEfficiency As Global.System.Windows.Forms.Control = Me._Label_PumpEfficiency
			location = New Global.System.Drawing.Point(8, 270)
			label_PumpEfficiency.Location = location
			Me._Label_PumpEfficiency.Name = "_Label_PumpEfficiency"
			Me._Label_PumpEfficiency.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_PumpEfficiency, False)
			Dim label_PumpEfficiency2 As Global.System.Windows.Forms.Control = Me._Label_PumpEfficiency
			size = New Global.System.Drawing.Size(288, 20)
			label_PumpEfficiency2.Size = size
			Me._Label_PumpEfficiency.TabIndex = 205
			Me._Label_PumpEfficiency.Text = "Pump efficiency (%):"
			Me._Label_PumpEfficiency.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_PumpCondition.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_PumpCondition.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_PumpCondition.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_PumpCondition.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_PumpCondition.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_PumpCondition As Global.System.Windows.Forms.Control = Me._Label_PumpCondition
			location = New Global.System.Drawing.Point(8, 160)
			label_PumpCondition.Location = location
			Me._Label_PumpCondition.Name = "_Label_PumpCondition"
			Me._Label_PumpCondition.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_PumpCondition, False)
			Dim label_PumpCondition2 As Global.System.Windows.Forms.Control = Me._Label_PumpCondition
			size = New Global.System.Drawing.Size(376, 20)
			label_PumpCondition2.Size = size
			Me._Label_PumpCondition.TabIndex = 204
			Me._Label_PumpCondition.Text = "Pump condition:"
			Me.txtPumpLoadAdj.AcceptsReturn = True
			Me.txtPumpLoadAdj.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPumpLoadAdj.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPumpLoadAdj.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.txtPumpLoadAdj.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtPumpLoadAdj, "pump load adjustment")
			Me.HelpProvider1.SetHelpNavigator(Me.txtPumpLoadAdj, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtPumpLoadAdj As Global.System.Windows.Forms.Control = Me.txtPumpLoadAdj
			location = New Global.System.Drawing.Point(672, 90)
			txtPumpLoadAdj.Location = location
			Me.txtPumpLoadAdj.MaxLength = 10
			Me.txtPumpLoadAdj.Name = "txtPumpLoadAdj"
			Me.txtPumpLoadAdj.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtPumpLoadAdj, True)
			Dim txtPumpLoadAdj2 As Global.System.Windows.Forms.Control = Me.txtPumpLoadAdj
			size = New Global.System.Drawing.Size(80, 22)
			txtPumpLoadAdj2.Size = size
			Me.txtPumpLoadAdj.TabIndex = 172
			Me.txtPumpLoadAdj.Tag = "lee"
			Me.txtStuffingBoxFriction.AcceptsReturn = True
			Me.txtStuffingBoxFriction.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtStuffingBoxFriction.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtStuffingBoxFriction.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.txtStuffingBoxFriction.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtStuffingBoxFriction, "Stuffing box friction")
			Me.HelpProvider1.SetHelpNavigator(Me.txtStuffingBoxFriction, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtStuffingBoxFriction As Global.System.Windows.Forms.Control = Me.txtStuffingBoxFriction
			location = New Global.System.Drawing.Point(672, 70)
			txtStuffingBoxFriction.Location = location
			Me.txtStuffingBoxFriction.MaxLength = 10
			Me.txtStuffingBoxFriction.Name = "txtStuffingBoxFriction"
			Me.txtStuffingBoxFriction.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtStuffingBoxFriction, True)
			Dim txtStuffingBoxFriction2 As Global.System.Windows.Forms.Control = Me.txtStuffingBoxFriction
			size = New Global.System.Drawing.Size(80, 22)
			txtStuffingBoxFriction2.Size = size
			Me.txtStuffingBoxFriction.TabIndex = 171
			Me.txtStuffingBoxFriction.Tag = "lee"
			Me.lblPumpLoadAdj.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblPumpLoadAdj.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblPumpLoadAdj.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblPumpLoadAdj.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblPumpLoadAdj.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblPumpLoadAdj As Global.System.Windows.Forms.Control = Me.lblPumpLoadAdj
			location = New Global.System.Drawing.Point(424, 90)
			lblPumpLoadAdj.Location = location
			Me.lblPumpLoadAdj.Name = "lblPumpLoadAdj"
			Me.lblPumpLoadAdj.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblPumpLoadAdj, False)
			Dim lblPumpLoadAdj2 As Global.System.Windows.Forms.Control = Me.lblPumpLoadAdj
			size = New Global.System.Drawing.Size(238, 20)
			lblPumpLoadAdj2.Size = size
			Me.lblPumpLoadAdj.TabIndex = 195
			Me.lblPumpLoadAdj.Tag = "Pump load adjustment (^):"
			Me.lblPumpLoadAdj.Text = "Pump load adjustment (lbs):"
			Me.lblPumpLoadAdj.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblStuffingBoxFriction.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblStuffingBoxFriction.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblStuffingBoxFriction.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblStuffingBoxFriction.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblStuffingBoxFriction.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblStuffingBoxFriction As Global.System.Windows.Forms.Control = Me.lblStuffingBoxFriction
			location = New Global.System.Drawing.Point(424, 70)
			lblStuffingBoxFriction.Location = location
			Me.lblStuffingBoxFriction.Name = "lblStuffingBoxFriction"
			Me.lblStuffingBoxFriction.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblStuffingBoxFriction, False)
			Dim lblStuffingBoxFriction2 As Global.System.Windows.Forms.Control = Me.lblStuffingBoxFriction
			size = New Global.System.Drawing.Size(238, 20)
			lblStuffingBoxFriction2.Size = size
			Me.lblStuffingBoxFriction.TabIndex = 194
			Me.lblStuffingBoxFriction.Tag = "Stuffing box friction (^):"
			Me.lblStuffingBoxFriction.Text = "Stuffing box friction (lbs):"
			Me.lblStuffingBoxFriction.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.chkCalcFluidSPGR.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkCalcFluidSPGR.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkCalcFluidSPGR As Global.System.Windows.Forms.Control = Me.chkCalcFluidSPGR
			location = New Global.System.Drawing.Point(760, 263)
			chkCalcFluidSPGR.Location = location
			Me.chkCalcFluidSPGR.Name = "chkCalcFluidSPGR"
			Me.HelpProvider1.SetShowHelp(Me.chkCalcFluidSPGR, False)
			Dim chkCalcFluidSPGR2 As Global.System.Windows.Forms.Control = Me.chkCalcFluidSPGR
			size = New Global.System.Drawing.Size(104, 23)
			chkCalcFluidSPGR2.Size = size
			Me.chkCalcFluidSPGR.TabIndex = 181
			Me.chkCalcFluidSPGR.Text = "Calculate"
			Me.txtComment.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.HelpProvider1.SetHelpKeyword(Me.txtComment, "comment")
			Me.HelpProvider1.SetHelpNavigator(Me.txtComment, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtComment As Global.System.Windows.Forms.Control = Me.txtComment
			location = New Global.System.Drawing.Point(184, 70)
			txtComment.Location = location
			Me.txtComment.Name = "txtComment"
			Me.HelpProvider1.SetShowHelp(Me.txtComment, True)
			Dim txtComment2 As Global.System.Windows.Forms.Control = Me.txtComment
			size = New Global.System.Drawing.Size(208, 70)
			txtComment2.Size = size
			Me.txtComment.TabIndex = 161
			Me.txtComment.Text = ""
			Me.txtOilAPI.AcceptsReturn = True
			Me.txtOilAPI.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtOilAPI.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtOilAPI.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtOilAPI.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtOilAPI, "Oil API gravity")
			Me.HelpProvider1.SetHelpNavigator(Me.txtOilAPI, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtOilAPI As Global.System.Windows.Forms.Control = Me.txtOilAPI
			location = New Global.System.Drawing.Point(672, 240)
			txtOilAPI.Location = location
			Me.txtOilAPI.MaxLength = 10
			Me.txtOilAPI.Name = "txtOilAPI"
			Me.txtOilAPI.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtOilAPI, True)
			Dim txtOilAPI2 As Global.System.Windows.Forms.Control = Me.txtOilAPI
			size = New Global.System.Drawing.Size(80, 23)
			txtOilAPI2.Size = size
			Me.txtOilAPI.TabIndex = 179
			Me.txtOilAPI.Tag = "aee"
			Me.txtWaterSPGR.AcceptsReturn = True
			Me.txtWaterSPGR.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtWaterSPGR.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtWaterSPGR.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtWaterSPGR.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtWaterSPGR, "water specific gravity")
			Me.HelpProvider1.SetHelpNavigator(Me.txtWaterSPGR, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtWaterSPGR As Global.System.Windows.Forms.Control = Me.txtWaterSPGR
			location = New Global.System.Drawing.Point(672, 220)
			txtWaterSPGR.Location = location
			Me.txtWaterSPGR.MaxLength = 10
			Me.txtWaterSPGR.Name = "txtWaterSPGR"
			Me.txtWaterSPGR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtWaterSPGR, True)
			Dim txtWaterSPGR2 As Global.System.Windows.Forms.Control = Me.txtWaterSPGR
			size = New Global.System.Drawing.Size(80, 23)
			txtWaterSPGR2.Size = size
			Me.txtWaterSPGR.TabIndex = 178
			Me.txtWaterCut.AcceptsReturn = True
			Me.txtWaterCut.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtWaterCut.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtWaterCut.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtWaterCut.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtWaterCut, "water cut")
			Me.HelpProvider1.SetHelpNavigator(Me.txtWaterCut, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtWaterCut As Global.System.Windows.Forms.Control = Me.txtWaterCut
			location = New Global.System.Drawing.Point(672, 200)
			txtWaterCut.Location = location
			Me.txtWaterCut.MaxLength = 10
			Me.txtWaterCut.Name = "txtWaterCut"
			Me.txtWaterCut.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtWaterCut, True)
			Dim txtWaterCut2 As Global.System.Windows.Forms.Control = Me.txtWaterCut
			size = New Global.System.Drawing.Size(80, 23)
			txtWaterCut2.Size = size
			Me.txtWaterCut.TabIndex = 177
			Me.txtCasingPressure.AcceptsReturn = True
			Me.txtCasingPressure.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtCasingPressure.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtCasingPressure.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtCasingPressure.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtCasingPressure, "casing pressure")
			Me.HelpProvider1.SetHelpNavigator(Me.txtCasingPressure, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtCasingPressure As Global.System.Windows.Forms.Control = Me.txtCasingPressure
			location = New Global.System.Drawing.Point(672, 180)
			txtCasingPressure.Location = location
			Me.txtCasingPressure.MaxLength = 10
			Me.txtCasingPressure.Name = "txtCasingPressure"
			Me.txtCasingPressure.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtCasingPressure, True)
			Dim txtCasingPressure2 As Global.System.Windows.Forms.Control = Me.txtCasingPressure
			size = New Global.System.Drawing.Size(80, 23)
			txtCasingPressure2.Size = size
			Me.txtCasingPressure.TabIndex = 176
			Me.txtCasingPressure.Tag = "pem"
			Me.txtTubingPressure.AcceptsReturn = True
			Me.txtTubingPressure.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtTubingPressure.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtTubingPressure.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtTubingPressure.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtTubingPressure, "tubing pressure")
			Me.HelpProvider1.SetHelpNavigator(Me.txtTubingPressure, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtTubingPressure As Global.System.Windows.Forms.Control = Me.txtTubingPressure
			location = New Global.System.Drawing.Point(672, 160)
			txtTubingPressure.Location = location
			Me.txtTubingPressure.MaxLength = 10
			Me.txtTubingPressure.Name = "txtTubingPressure"
			Me.txtTubingPressure.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtTubingPressure, True)
			Dim txtTubingPressure2 As Global.System.Windows.Forms.Control = Me.txtTubingPressure
			size = New Global.System.Drawing.Size(80, 23)
			txtTubingPressure2.Size = size
			Me.txtTubingPressure.TabIndex = 175
			Me.txtTubingPressure.Tag = "pem"
			Me.txtRuntime.AcceptsReturn = True
			Me.txtRuntime.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtRuntime.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtRuntime.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtRuntime.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtRuntime, "Run time")
			Me.HelpProvider1.SetHelpNavigator(Me.txtRuntime, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtRuntime As Global.System.Windows.Forms.Control = Me.txtRuntime
			location = New Global.System.Drawing.Point(672, 50)
			txtRuntime.Location = location
			Me.txtRuntime.MaxLength = 10
			Me.txtRuntime.Name = "txtRuntime"
			Me.txtRuntime.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtRuntime, True)
			Dim txtRuntime2 As Global.System.Windows.Forms.Control = Me.txtRuntime
			size = New Global.System.Drawing.Size(80, 23)
			txtRuntime2.Size = size
			Me.txtRuntime.TabIndex = 170
			Me.txtRuntime.Tag = ""
			Me.txtPumpDepth.AcceptsReturn = True
			Me.txtPumpDepth.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPumpDepth.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPumpDepth.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtPumpDepth.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtPumpDepth, "pump depth")
			Me.HelpProvider1.SetHelpNavigator(Me.txtPumpDepth, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtPumpDepth As Global.System.Windows.Forms.Control = Me.txtPumpDepth
			location = New Global.System.Drawing.Point(672, 30)
			txtPumpDepth.Location = location
			Me.txtPumpDepth.MaxLength = 10
			Me.txtPumpDepth.Name = "txtPumpDepth"
			Me.txtPumpDepth.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtPumpDepth, True)
			Dim txtPumpDepth2 As Global.System.Windows.Forms.Control = Me.txtPumpDepth
			size = New Global.System.Drawing.Size(80, 23)
			txtPumpDepth2.Size = size
			Me.txtPumpDepth.TabIndex = 169
			Me.txtPumpDepth.Tag = "fem"
			Me.txtUserDate.AcceptsReturn = True
			Me.txtUserDate.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtUserDate.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtUserDate.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtUserDate.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtUserDate, "date")
			Me.HelpProvider1.SetHelpNavigator(Me.txtUserDate, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtUserDate As Global.System.Windows.Forms.Control = Me.txtUserDate
			location = New Global.System.Drawing.Point(672, 8)
			txtUserDate.Location = location
			Me.txtUserDate.MaxLength = 40
			Me.txtUserDate.Name = "txtUserDate"
			Me.txtUserDate.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtUserDate, True)
			Dim txtUserDate2 As Global.System.Windows.Forms.Control = Me.txtUserDate
			size = New Global.System.Drawing.Size(215, 23)
			txtUserDate2.Size = size
			Me.txtUserDate.TabIndex = 168
			Me.txtUserName.AcceptsReturn = True
			Me.txtUserName.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtUserName.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtUserName.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtUserName.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtUserName, "user name")
			Me.HelpProvider1.SetHelpNavigator(Me.txtUserName, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtUserName As Global.System.Windows.Forms.Control = Me.txtUserName
			location = New Global.System.Drawing.Point(184, 50)
			txtUserName.Location = location
			Me.txtUserName.MaxLength = 40
			Me.txtUserName.Name = "txtUserName"
			Me.txtUserName.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtUserName, True)
			Dim txtUserName2 As Global.System.Windows.Forms.Control = Me.txtUserName
			size = New Global.System.Drawing.Size(208, 23)
			txtUserName2.Size = size
			Me.txtUserName.TabIndex = 160
			Me.txtWellName.AcceptsReturn = True
			Me.txtWellName.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtWellName.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtWellName.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtWellName.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtWellName, "well name")
			Me.HelpProvider1.SetHelpNavigator(Me.txtWellName, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtWellName As Global.System.Windows.Forms.Control = Me.txtWellName
			location = New Global.System.Drawing.Point(184, 30)
			txtWellName.Location = location
			Me.txtWellName.MaxLength = 40
			Me.txtWellName.Name = "txtWellName"
			Me.txtWellName.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtWellName, True)
			Dim txtWellName2 As Global.System.Windows.Forms.Control = Me.txtWellName
			size = New Global.System.Drawing.Size(208, 23)
			txtWellName2.Size = size
			Me.txtWellName.TabIndex = 159
			Me.txtWellName.Tag = ""
			Me.txtCompanyName.AcceptsReturn = True
			Me.txtCompanyName.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtCompanyName.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtCompanyName.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtCompanyName.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtCompanyName, "company name")
			Me.HelpProvider1.SetHelpNavigator(Me.txtCompanyName, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtCompanyName As Global.System.Windows.Forms.Control = Me.txtCompanyName
			location = New Global.System.Drawing.Point(184, 10)
			txtCompanyName.Location = location
			Me.txtCompanyName.MaxLength = 0
			Me.txtCompanyName.Name = "txtCompanyName"
			Me.txtCompanyName.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtCompanyName, True)
			Dim txtCompanyName2 As Global.System.Windows.Forms.Control = Me.txtCompanyName
			size = New Global.System.Drawing.Size(208, 23)
			txtCompanyName2.Size = size
			Me.txtCompanyName.TabIndex = 158
			Me.txtCompanyName.Tag = ""
			Me._Label_FluidSPGR.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_FluidSPGR.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_FluidSPGR.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_FluidSPGR.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_FluidSPGR.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_FluidSPGR As Global.System.Windows.Forms.Control = Me._Label_FluidSPGR
			location = New Global.System.Drawing.Point(424, 263)
			label_FluidSPGR.Location = location
			Me._Label_FluidSPGR.Name = "_Label_FluidSPGR"
			Me._Label_FluidSPGR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_FluidSPGR, False)
			Dim label_FluidSPGR2 As Global.System.Windows.Forms.Control = Me._Label_FluidSPGR
			size = New Global.System.Drawing.Size(238, 20)
			label_FluidSPGR2.Size = size
			Me._Label_FluidSPGR.TabIndex = 187
			Me._Label_FluidSPGR.Tag = "Fluid specific gravity:"
			Me._Label_FluidSPGR.Text = "Fluid specific gravity:"
			Me._Label_FluidSPGR.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_OilAPI.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_OilAPI.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_OilAPI.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_OilAPI.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_OilAPI.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_OilAPI As Global.System.Windows.Forms.Control = Me._Label_OilAPI
			location = New Global.System.Drawing.Point(424, 240)
			label_OilAPI.Location = location
			Me._Label_OilAPI.Name = "_Label_OilAPI"
			Me._Label_OilAPI.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_OilAPI, False)
			Dim label_OilAPI2 As Global.System.Windows.Forms.Control = Me._Label_OilAPI
			size = New Global.System.Drawing.Size(238, 20)
			label_OilAPI2.Size = size
			Me._Label_OilAPI.TabIndex = 186
			Me._Label_OilAPI.Tag = "Oil gravity (^):"
			Me._Label_OilAPI.Text = "Oil gravity (API °):"
			Me._Label_OilAPI.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_WaterSPGR.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_WaterSPGR.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_WaterSPGR.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_WaterSPGR.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_WaterSPGR.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_WaterSPGR As Global.System.Windows.Forms.Control = Me._Label_WaterSPGR
			location = New Global.System.Drawing.Point(424, 220)
			label_WaterSPGR.Location = location
			Me._Label_WaterSPGR.Name = "_Label_WaterSPGR"
			Me._Label_WaterSPGR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_WaterSPGR, False)
			Dim label_WaterSPGR2 As Global.System.Windows.Forms.Control = Me._Label_WaterSPGR
			size = New Global.System.Drawing.Size(238, 20)
			label_WaterSPGR2.Size = size
			Me._Label_WaterSPGR.TabIndex = 185
			Me._Label_WaterSPGR.Tag = "Water specific gravity:"
			Me._Label_WaterSPGR.Text = "Water specific gravity:"
			Me._Label_WaterSPGR.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_WaterCut.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_WaterCut.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_WaterCut.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_WaterCut.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_WaterCut.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_WaterCut As Global.System.Windows.Forms.Control = Me._Label_WaterCut
			location = New Global.System.Drawing.Point(424, 200)
			label_WaterCut.Location = location
			Me._Label_WaterCut.Name = "_Label_WaterCut"
			Me._Label_WaterCut.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_WaterCut, False)
			Dim label_WaterCut2 As Global.System.Windows.Forms.Control = Me._Label_WaterCut
			size = New Global.System.Drawing.Size(238, 20)
			label_WaterCut2.Size = size
			Me._Label_WaterCut.TabIndex = 184
			Me._Label_WaterCut.Tag = "Water cut (%):"
			Me._Label_WaterCut.Text = "Water cut (%):"
			Me._Label_WaterCut.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_CasingPressure.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_CasingPressure.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_CasingPressure.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_CasingPressure.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_CasingPressure.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_CasingPressure As Global.System.Windows.Forms.Control = Me._Label_CasingPressure
			location = New Global.System.Drawing.Point(424, 180)
			label_CasingPressure.Location = location
			Me._Label_CasingPressure.Name = "_Label_CasingPressure"
			Me._Label_CasingPressure.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_CasingPressure, False)
			Dim label_CasingPressure2 As Global.System.Windows.Forms.Control = Me._Label_CasingPressure
			size = New Global.System.Drawing.Size(238, 20)
			label_CasingPressure2.Size = size
			Me._Label_CasingPressure.TabIndex = 183
			Me._Label_CasingPressure.Tag = "Casing pressure (^):"
			Me._Label_CasingPressure.Text = "Casing pressure (psi):"
			Me._Label_CasingPressure.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_TubingPressure.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_TubingPressure.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_TubingPressure.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_TubingPressure.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_TubingPressure.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_TubingPressure As Global.System.Windows.Forms.Control = Me._Label_TubingPressure
			location = New Global.System.Drawing.Point(424, 160)
			label_TubingPressure.Location = location
			Me._Label_TubingPressure.Name = "_Label_TubingPressure"
			Me._Label_TubingPressure.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_TubingPressure, False)
			Dim label_TubingPressure2 As Global.System.Windows.Forms.Control = Me._Label_TubingPressure
			size = New Global.System.Drawing.Size(238, 20)
			label_TubingPressure2.Size = size
			Me._Label_TubingPressure.TabIndex = 182
			Me._Label_TubingPressure.Tag = "Tubing pressure (^):"
			Me._Label_TubingPressure.Text = "Tubing pressure (psi):"
			Me._Label_TubingPressure.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_RunTime.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_RunTime.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_RunTime.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_RunTime.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_RunTime.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_RunTime As Global.System.Windows.Forms.Control = Me._Label_RunTime
			location = New Global.System.Drawing.Point(424, 50)
			label_RunTime.Location = location
			Me._Label_RunTime.Name = "_Label_RunTime"
			Me._Label_RunTime.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_RunTime, False)
			Dim label_RunTime2 As Global.System.Windows.Forms.Control = Me._Label_RunTime
			size = New Global.System.Drawing.Size(238, 20)
			label_RunTime2.Size = size
			Me._Label_RunTime.TabIndex = 181
			Me._Label_RunTime.Text = "Run time (hrs/day):"
			Me._Label_RunTime.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_PumpDepth.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_PumpDepth.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_PumpDepth.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_PumpDepth.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_PumpDepth.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_PumpDepth As Global.System.Windows.Forms.Control = Me._Label_PumpDepth
			location = New Global.System.Drawing.Point(424, 30)
			label_PumpDepth.Location = location
			Me._Label_PumpDepth.Name = "_Label_PumpDepth"
			Me._Label_PumpDepth.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_PumpDepth, False)
			Dim label_PumpDepth2 As Global.System.Windows.Forms.Control = Me._Label_PumpDepth
			size = New Global.System.Drawing.Size(238, 20)
			label_PumpDepth2.Size = size
			Me._Label_PumpDepth.TabIndex = 180
			Me._Label_PumpDepth.Tag = "Pump depth (^):"
			Me._Label_PumpDepth.Text = "Pump depth (ft):"
			Me._Label_PumpDepth.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._linSeparator_3.BackColor = Global.System.Drawing.Color.White
			Me._linSeparator_3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim linSeparator_7 As Global.System.Windows.Forms.Control = Me._linSeparator_3
			location = New Global.System.Drawing.Point(416, 157)
			linSeparator_7.Location = location
			Me._linSeparator_3.Name = "_linSeparator_3"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_3, False)
			Dim linSeparator_8 As Global.System.Windows.Forms.Control = Me._linSeparator_3
			size = New Global.System.Drawing.Size(1, 185)
			linSeparator_8.Size = size
			Me._linSeparator_3.TabIndex = 188
			Me._linSeparator_1.BackColor = Global.System.Drawing.Color.White
			Me._linSeparator_1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim linSeparator_9 As Global.System.Windows.Forms.Control = Me._linSeparator_1
			location = New Global.System.Drawing.Point(32, 152)
			linSeparator_9.Location = location
			Me._linSeparator_1.Name = "_linSeparator_1"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_1, False)
			Dim linSeparator_10 As Global.System.Windows.Forms.Control = Me._linSeparator_1
			size = New Global.System.Drawing.Size(855, 1)
			linSeparator_10.Size = size
			Me._linSeparator_1.TabIndex = 190
			Me._linSeparator_0.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._linSeparator_0.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._linSeparator_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim linSeparator_11 As Global.System.Windows.Forms.Control = Me._linSeparator_0
			location = New Global.System.Drawing.Point(32, 150)
			linSeparator_11.Location = location
			Me._linSeparator_0.Name = "_linSeparator_0"
			Me.HelpProvider1.SetShowHelp(Me._linSeparator_0, False)
			Dim linSeparator_12 As Global.System.Windows.Forms.Control = Me._linSeparator_0
			size = New Global.System.Drawing.Size(855, 1)
			linSeparator_12.Size = size
			Me._linSeparator_0.TabIndex = 191
			Me._Label_UserName.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_UserName.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_UserName.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_UserName.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_UserName.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_UserName As Global.System.Windows.Forms.Control = Me._Label_UserName
			location = New Global.System.Drawing.Point(8, 50)
			label_UserName.Location = location
			Me._Label_UserName.Name = "_Label_UserName"
			Me._Label_UserName.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_UserName, False)
			Dim label_UserName2 As Global.System.Windows.Forms.Control = Me._Label_UserName
			size = New Global.System.Drawing.Size(170, 20)
			label_UserName2.Size = size
			Me._Label_UserName.TabIndex = 178
			Me._Label_UserName.Text = "User name:"
			Me._Label_UserName.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_UserDate.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_UserDate.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_UserDate.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_UserDate.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_UserDate.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_UserDate As Global.System.Windows.Forms.Control = Me._Label_UserDate
			location = New Global.System.Drawing.Point(424, 10)
			label_UserDate.Location = location
			Me._Label_UserDate.Name = "_Label_UserDate"
			Me._Label_UserDate.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_UserDate, False)
			Dim label_UserDate2 As Global.System.Windows.Forms.Control = Me._Label_UserDate
			size = New Global.System.Drawing.Size(238, 20)
			label_UserDate2.Size = size
			Me._Label_UserDate.TabIndex = 179
			Me._Label_UserDate.Text = "Date:"
			Me._Label_UserDate.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_Comment.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_Comment.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_Comment.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_Comment.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_Comment.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_Comment As Global.System.Windows.Forms.Control = Me._Label_Comment
			location = New Global.System.Drawing.Point(8, 72)
			label_Comment.Location = location
			Me._Label_Comment.Name = "_Label_Comment"
			Me._Label_Comment.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_Comment, False)
			Dim label_Comment2 As Global.System.Windows.Forms.Control = Me._Label_Comment
			size = New Global.System.Drawing.Size(170, 20)
			label_Comment2.Size = size
			Me._Label_Comment.TabIndex = 175
			Me._Label_Comment.Text = "Comment:"
			Me._Label_Comment.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_WellName.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_WellName.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_WellName.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_WellName.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_WellName.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_WellName As Global.System.Windows.Forms.Control = Me._Label_WellName
			location = New Global.System.Drawing.Point(8, 30)
			label_WellName.Location = location
			Me._Label_WellName.Name = "_Label_WellName"
			Me._Label_WellName.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_WellName, False)
			Dim label_WellName2 As Global.System.Windows.Forms.Control = Me._Label_WellName
			size = New Global.System.Drawing.Size(170, 20)
			label_WellName2.Size = size
			Me._Label_WellName.TabIndex = 177
			Me._Label_WellName.Text = "Well name:"
			Me._Label_WellName.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_CompanyName.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_CompanyName.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_CompanyName.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_CompanyName.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_CompanyName.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_CompanyName As Global.System.Windows.Forms.Control = Me._Label_CompanyName
			location = New Global.System.Drawing.Point(8, 10)
			label_CompanyName.Location = location
			Me._Label_CompanyName.Name = "_Label_CompanyName"
			Me._Label_CompanyName.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_CompanyName, False)
			Dim label_CompanyName2 As Global.System.Windows.Forms.Control = Me._Label_CompanyName
			size = New Global.System.Drawing.Size(170, 20)
			label_CompanyName2.Size = size
			Me._Label_CompanyName.TabIndex = 176
			Me._Label_CompanyName.Text = "Company name:"
			Me._Label_CompanyName.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.txtPRDiameter.AcceptsReturn = True
			Me.txtPRDiameter.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPRDiameter.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPRDiameter.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPRDiameter.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtPRDiameter As Global.System.Windows.Forms.Control = Me.txtPRDiameter
			location = New Global.System.Drawing.Point(813, 110)
			txtPRDiameter.Location = location
			Me.txtPRDiameter.MaxLength = 10
			Me.txtPRDiameter.Name = "txtPRDiameter"
			Me.txtPRDiameter.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtPRDiameter, False)
			Dim txtPRDiameter2 As Global.System.Windows.Forms.Control = Me.txtPRDiameter
			size = New Global.System.Drawing.Size(60, 22)
			txtPRDiameter2.Size = size
			Me.txtPRDiameter.TabIndex = 174
			Me.txtPRDiameter.TabStop = False
			Me.txtPRDiameter.Tag = "mem"
			Me.txtPumpEfficiency.AcceptsReturn = True
			Me.txtPumpEfficiency.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPumpEfficiency.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPumpEfficiency.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtPumpEfficiency.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtPumpEfficiency, "pump condition")
			Me.HelpProvider1.SetHelpNavigator(Me.txtPumpEfficiency, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtPumpEfficiency As Global.System.Windows.Forms.Control = Me.txtPumpEfficiency
			location = New Global.System.Drawing.Point(312, 270)
			txtPumpEfficiency.Location = location
			Me.txtPumpEfficiency.MaxLength = 10
			Me.txtPumpEfficiency.Name = "txtPumpEfficiency"
			Me.txtPumpEfficiency.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtPumpEfficiency, True)
			Dim txtPumpEfficiency2 As Global.System.Windows.Forms.Control = Me.txtPumpEfficiency
			size = New Global.System.Drawing.Size(80, 22)
			txtPumpEfficiency2.Size = size
			Me.txtPumpEfficiency.TabIndex = 166
			Me.lblPumpEfficiency_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblPumpEfficiency_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblPumpEfficiency_Disabled As Global.System.Windows.Forms.Control = Me.lblPumpEfficiency_Disabled
			location = New Global.System.Drawing.Point(312, 270)
			lblPumpEfficiency_Disabled.Location = location
			Me.lblPumpEfficiency_Disabled.Name = "lblPumpEfficiency_Disabled"
			Dim lblPumpEfficiency_Disabled2 As Global.System.Windows.Forms.Control = Me.lblPumpEfficiency_Disabled
			size = New Global.System.Drawing.Size(80, 22)
			lblPumpEfficiency_Disabled2.Size = size
			Me.lblPumpEfficiency_Disabled.TabIndex = 207
			Me.txtPumpFillage.AcceptsReturn = True
			Me.txtPumpFillage.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPumpFillage.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPumpFillage.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtPumpFillage.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtPumpFillage, "pump condition")
			Me.HelpProvider1.SetHelpNavigator(Me.txtPumpFillage, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtPumpFillage As Global.System.Windows.Forms.Control = Me.txtPumpFillage
			location = New Global.System.Drawing.Point(312, 292)
			txtPumpFillage.Location = location
			Me.txtPumpFillage.MaxLength = 10
			Me.txtPumpFillage.Name = "txtPumpFillage"
			Me.txtPumpFillage.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtPumpFillage, True)
			Dim txtPumpFillage2 As Global.System.Windows.Forms.Control = Me.txtPumpFillage
			size = New Global.System.Drawing.Size(80, 22)
			txtPumpFillage2.Size = size
			Me.txtPumpFillage.TabIndex = 167
			Me.lblPumpFillage_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblPumpFillage_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblPumpFillage_Disabled As Global.System.Windows.Forms.Control = Me.lblPumpFillage_Disabled
			location = New Global.System.Drawing.Point(312, 292)
			lblPumpFillage_Disabled.Location = location
			Me.lblPumpFillage_Disabled.Name = "lblPumpFillage_Disabled"
			Dim lblPumpFillage_Disabled2 As Global.System.Windows.Forms.Control = Me.lblPumpFillage_Disabled
			size = New Global.System.Drawing.Size(80, 22)
			lblPumpFillage_Disabled2.Size = size
			Me.lblPumpFillage_Disabled.TabIndex = 208
			Me.txtFluidSPGR.AcceptsReturn = True
			Me.txtFluidSPGR.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtFluidSPGR.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtFluidSPGR.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtFluidSPGR.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtFluidSPGR, "Fluid specific gravity")
			Me.HelpProvider1.SetHelpNavigator(Me.txtFluidSPGR, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtFluidSPGR As Global.System.Windows.Forms.Control = Me.txtFluidSPGR
			location = New Global.System.Drawing.Point(672, 263)
			txtFluidSPGR.Location = location
			Me.txtFluidSPGR.MaxLength = 10
			Me.txtFluidSPGR.Name = "txtFluidSPGR"
			Me.txtFluidSPGR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtFluidSPGR, True)
			Dim txtFluidSPGR2 As Global.System.Windows.Forms.Control = Me.txtFluidSPGR
			size = New Global.System.Drawing.Size(80, 23)
			txtFluidSPGR2.Size = size
			Me.txtFluidSPGR.TabIndex = 180
			Me.lblFluidSPGR_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblFluidSPGR_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblFluidSPGR_Disabled As Global.System.Windows.Forms.Control = Me.lblFluidSPGR_Disabled
			location = New Global.System.Drawing.Point(672, 263)
			lblFluidSPGR_Disabled.Location = location
			Me.lblFluidSPGR_Disabled.Name = "lblFluidSPGR_Disabled"
			Dim lblFluidSPGR_Disabled2 As Global.System.Windows.Forms.Control = Me.lblFluidSPGR_Disabled
			size = New Global.System.Drawing.Size(80, 23)
			lblFluidSPGR_Disabled2.Size = size
			Me.lblFluidSPGR_Disabled.TabIndex = 216
			Me.lblPRDiameter_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblPRDiameter_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblPRDiameter_Disabled As Global.System.Windows.Forms.Control = Me.lblPRDiameter_Disabled
			location = New Global.System.Drawing.Point(813, 110)
			lblPRDiameter_Disabled.Location = location
			Me.lblPRDiameter_Disabled.Name = "lblPRDiameter_Disabled"
			Dim lblPRDiameter_Disabled2 As Global.System.Windows.Forms.Control = Me.lblPRDiameter_Disabled
			size = New Global.System.Drawing.Size(60, 24)
			lblPRDiameter_Disabled2.Size = size
			Me.lblPRDiameter_Disabled.TabIndex = 224
			Me.lblParaffinDepth_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblParaffinDepth_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblParaffinDepth_Disabled As Global.System.Windows.Forms.Control = Me.lblParaffinDepth_Disabled
			location = New Global.System.Drawing.Point(828, 321)
			lblParaffinDepth_Disabled.Location = location
			Me.lblParaffinDepth_Disabled.Name = "lblParaffinDepth_Disabled"
			Dim lblParaffinDepth_Disabled2 As Global.System.Windows.Forms.Control = Me.lblParaffinDepth_Disabled
			size = New Global.System.Drawing.Size(80, 22)
			lblParaffinDepth_Disabled2.Size = size
			Me.lblParaffinDepth_Disabled.TabIndex = 229
			Me.txtParaffinDepth.AcceptsReturn = True
			Me.txtParaffinDepth.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtParaffinDepth.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtParaffinDepth.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtParaffinDepth.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtParaffinDepth, "Fluid Compressibility Index")
			Me.HelpProvider1.SetHelpNavigator(Me.txtParaffinDepth, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtParaffinDepth As Global.System.Windows.Forms.Control = Me.txtParaffinDepth
			location = New Global.System.Drawing.Point(828, 321)
			txtParaffinDepth.Location = location
			Me.txtParaffinDepth.MaxLength = 10
			Me.txtParaffinDepth.Name = "txtParaffinDepth"
			Me.txtParaffinDepth.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtParaffinDepth, True)
			Dim txtParaffinDepth2 As Global.System.Windows.Forms.Control = Me.txtParaffinDepth
			size = New Global.System.Drawing.Size(80, 22)
			txtParaffinDepth2.Size = size
			Me.txtParaffinDepth.TabIndex = 227
			Me.txtParaffinDepth.Tag = "fem"
			Me.ToolTip1.ShowAlways = True
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			Me.AutoScroll = True
			size = New Global.System.Drawing.Size(943, 357)
			Me.ClientSize = size
			Me.Controls.Add(Me.pnlWellInfo)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "WellInfo"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.pnlWellInfo.ResumeLayout(False)
			Me.pnlWellInfo.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
