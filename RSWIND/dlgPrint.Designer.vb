Namespace RSWINV3
	Friend Partial Class dlgPrint
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgPrint))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdHelp = New Global.System.Windows.Forms.Button()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.chkReportOpt_6 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_7 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_3 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_2 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_0 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_1 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_5 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_4 = New Global.System.Windows.Forms.CheckBox()
			Me.pnlOutputOptions = New Global.System.Windows.Forms.Panel()
			Me.grpOutputOptions = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.SSPanel = New Global.System.Windows.Forms.Panel()
			Me.imgPreview_10 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_9 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_ = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_6 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_3 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_4 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_5 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_2 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_0 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_1 = New Global.System.Windows.Forms.PictureBox()
			Me.grpOutputPages = New Global.System.Windows.Forms.GroupBox()
			Me.chkReportOpt_10 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_9 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_ = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_8 = New Global.System.Windows.Forms.CheckBox()
			Me.SSFrame = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.chkReportOpt = New Global.Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
			Me.imgIcons = New Global.Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
			Me.imgPreview = New Global.Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.pnlOutputOptions.SuspendLayout()
			Me.grpOutputOptions.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.SSPanel.SuspendLayout()
			CType(Me.imgPreview_10, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_9, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_6, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_3, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_5, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_0, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grpOutputPages.SuspendLayout()
			CType(Me.SSFrame, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkReportOpt, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgIcons, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.cmdHelp.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdHelp.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdHelp.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdHelp.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdHelp.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdHelp As Global.System.Windows.Forms.Control = Me.cmdHelp
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(635, 76)
			cmdHelp.Location = location
			Me.cmdHelp.Name = "cmdHelp"
			Me.cmdHelp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdHelp, False)
			Dim cmdHelp2 As Global.System.Windows.Forms.Control = Me.cmdHelp
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(75, 22)
			cmdHelp2.Size = size
			Me.cmdHelp.TabIndex = 13
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
			location = New Global.System.Drawing.Point(635, 35)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdCancel, False)
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(75, 22)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 1
			Me.cmdCancel.Text = "Cancel"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(635, 8)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdOK, False)
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(75, 22)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 0
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me.chkReportOpt_6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_6, "Overlay Measured Surface Card")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_6, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_ As Global.System.Windows.Forms.Control = Me.chkReportOpt_6
			location = New Global.System.Drawing.Point(8, 24)
			chkReportOpt_.Location = location
			Me.chkReportOpt_6.Name = "chkReportOpt_6"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_6, True)
			Dim chkReportOpt_2 As Global.System.Windows.Forms.Control = Me.chkReportOpt_6
			size = New Global.System.Drawing.Size(328, 16)
			chkReportOpt_2.Size = size
			Me.chkReportOpt_6.TabIndex = 7
			Me.chkReportOpt_6.Text = "Overlay actual (measured) surface card"
			Me.chkReportOpt_7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_7, "Omit Dynamometer Card and Torque Plot")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_7, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_3 As Global.System.Windows.Forms.Control = Me.chkReportOpt_7
			location = New Global.System.Drawing.Point(8, 40)
			chkReportOpt_3.Location = location
			Me.chkReportOpt_7.Name = "chkReportOpt_7"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_7, True)
			Dim chkReportOpt_4 As Global.System.Windows.Forms.Control = Me.chkReportOpt_7
			size = New Global.System.Drawing.Size(448, 16)
			chkReportOpt_4.Size = size
			Me.chkReportOpt_7.TabIndex = 6
			Me.chkReportOpt_7.Text = "Display viewed calculated results page without Dyno cards and Torque Plots"
			Me.chkReportOpt_7.Visible = False
			Me.chkReportOpt_3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_3, "Setup Output: Dynamometer Card and Torque Plot")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_3, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_5 As Global.System.Windows.Forms.Control = Me.chkReportOpt_3
			location = New Global.System.Drawing.Point(8, 112)
			chkReportOpt_5.Location = location
			Me.chkReportOpt_3.Name = "chkReportOpt_3"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_3, True)
			Dim chkReportOpt_6 As Global.System.Windows.Forms.Control = Me.chkReportOpt_3
			size = New Global.System.Drawing.Size(448, 16)
			chkReportOpt_6.Size = size
			Me.chkReportOpt_3.TabIndex = 3
			Me.chkReportOpt_3.Text = "Dynamometer cards and Torque Plots"
			Me.chkReportOpt_2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_2, "Setup Output: IPR")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_7 As Global.System.Windows.Forms.Control = Me.chkReportOpt_2
			location = New Global.System.Drawing.Point(8, 96)
			chkReportOpt_7.Location = location
			Me.chkReportOpt_2.Name = "chkReportOpt_2"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_2, True)
			Dim chkReportOpt_8 As Global.System.Windows.Forms.Control = Me.chkReportOpt_2
			size = New Global.System.Drawing.Size(448, 16)
			chkReportOpt_8.Size = size
			Me.chkReportOpt_2.TabIndex = 2
			Me.chkReportOpt_2.Text = "Inflow performances (IPR) chart"
			Me.chkReportOpt_0.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_0, "Setup Output: Input Data")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_0, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_9 As Global.System.Windows.Forms.Control = Me.chkReportOpt_0
			location = New Global.System.Drawing.Point(8, 48)
			chkReportOpt_9.Location = location
			Me.chkReportOpt_0.Name = "chkReportOpt_0"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_0, True)
			Dim chkReportOpt_10 As Global.System.Windows.Forms.Control = Me.chkReportOpt_0
			size = New Global.System.Drawing.Size(448, 16)
			chkReportOpt_10.Size = size
			Me.chkReportOpt_0.TabIndex = 1
			Me.chkReportOpt_0.Text = "Input data and calculated results"
			Me.chkReportOpt_1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_1, "Setup Output: Cost Analysis")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_11 As Global.System.Windows.Forms.Control = Me.chkReportOpt_1
			location = New Global.System.Drawing.Point(8, 64)
			chkReportOpt_11.Location = location
			Me.chkReportOpt_1.Name = "chkReportOpt_1"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_1, True)
			Dim chkReportOpt_12 As Global.System.Windows.Forms.Control = Me.chkReportOpt_1
			size = New Global.System.Drawing.Size(448, 16)
			chkReportOpt_12.Size = size
			Me.chkReportOpt_1.TabIndex = 0
			Me.chkReportOpt_1.Text = "Cost analysis"
			Me.chkReportOpt_5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_5, "Recommended Guide Report")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_5, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_13 As Global.System.Windows.Forms.Control = Me.chkReportOpt_5
			location = New Global.System.Drawing.Point(8, 144)
			chkReportOpt_13.Location = location
			Me.chkReportOpt_5.Name = "chkReportOpt_5"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_5, True)
			Dim chkReportOpt_14 As Global.System.Windows.Forms.Control = Me.chkReportOpt_5
			size = New Global.System.Drawing.Size(448, 16)
			chkReportOpt_14.Size = size
			Me.chkReportOpt_5.TabIndex = 7
			Me.chkReportOpt_5.Text = "Recommended Guide Report"
			Me.chkReportOpt_4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_4, "Deviation Charts")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_4, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_15 As Global.System.Windows.Forms.Control = Me.chkReportOpt_4
			location = New Global.System.Drawing.Point(8, 128)
			chkReportOpt_15.Location = location
			Me.chkReportOpt_4.Name = "chkReportOpt_4"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_4, True)
			Dim chkReportOpt_16 As Global.System.Windows.Forms.Control = Me.chkReportOpt_4
			size = New Global.System.Drawing.Size(448, 16)
			chkReportOpt_16.Size = size
			Me.chkReportOpt_4.TabIndex = 6
			Me.chkReportOpt_4.Text = "Deviation Charts"
			Me.pnlOutputOptions.Controls.Add(Me.grpOutputOptions)
			Me.pnlOutputOptions.Controls.Add(Me.GroupBox2)
			Me.pnlOutputOptions.Controls.Add(Me.grpOutputPages)
			Dim pnlOutputOptions As Global.System.Windows.Forms.Control = Me.pnlOutputOptions
			location = New Global.System.Drawing.Point(8, 8)
			pnlOutputOptions.Location = location
			Me.pnlOutputOptions.Name = "pnlOutputOptions"
			Me.HelpProvider1.SetShowHelp(Me.pnlOutputOptions, False)
			Dim pnlOutputOptions2 As Global.System.Windows.Forms.Control = Me.pnlOutputOptions
			size = New Global.System.Drawing.Size(608, 264)
			pnlOutputOptions2.Size = size
			Me.pnlOutputOptions.TabIndex = 14
			Me.grpOutputOptions.Controls.Add(Me.chkReportOpt_6)
			Me.grpOutputOptions.Controls.Add(Me.chkReportOpt_7)
			Me.grpOutputOptions.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim grpOutputOptions As Global.System.Windows.Forms.Control = Me.grpOutputOptions
			location = New Global.System.Drawing.Point(16, 189)
			grpOutputOptions.Location = location
			Me.grpOutputOptions.Name = "grpOutputOptions"
			Me.HelpProvider1.SetShowHelp(Me.grpOutputOptions, False)
			Dim grpOutputOptions2 As Global.System.Windows.Forms.Control = Me.grpOutputOptions
			size = New Global.System.Drawing.Size(472, 64)
			grpOutputOptions2.Size = size
			Me.grpOutputOptions.TabIndex = 2
			Me.grpOutputOptions.TabStop = False
			Me.grpOutputOptions.Text = "Output options"
			Me.GroupBox2.Controls.Add(Me.SSPanel)
			Me.GroupBox2.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(496, 8)
			groupBox.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Me.HelpProvider1.SetShowHelp(Me.GroupBox2, False)
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(96, 244)
			groupBox2.Size = size
			Me.GroupBox2.TabIndex = 1
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Output Sample"
			Me.SSPanel.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.SSPanel.Controls.Add(Me.imgPreview_10)
			Me.SSPanel.Controls.Add(Me.imgPreview_9)
			Me.SSPanel.Controls.Add(Me.imgPreview_)
			Me.SSPanel.Controls.Add(Me.imgPreview_6)
			Me.SSPanel.Controls.Add(Me.imgPreview_3)
			Me.SSPanel.Controls.Add(Me.imgPreview_4)
			Me.SSPanel.Controls.Add(Me.imgPreview_5)
			Me.SSPanel.Controls.Add(Me.imgPreview_2)
			Me.SSPanel.Controls.Add(Me.imgPreview_0)
			Me.SSPanel.Controls.Add(Me.imgPreview_1)
			Dim sspanel As Global.System.Windows.Forms.Control = Me.SSPanel
			location = New Global.System.Drawing.Point(8, 16)
			sspanel.Location = location
			Me.SSPanel.Name = "SSPanel"
			Me.HelpProvider1.SetShowHelp(Me.SSPanel, False)
			Dim sspanel2 As Global.System.Windows.Forms.Control = Me.SSPanel
			size = New Global.System.Drawing.Size(80, 220)
			sspanel2.Size = size
			Me.SSPanel.TabIndex = 0
			Me.imgPreview_10.Image = CType(componentResourceManager.GetObject("imgPreview_10.Image"), Global.System.Drawing.Image)
			Me.imgPreview_10.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_ As Global.System.Windows.Forms.Control = Me.imgPreview_10
			location = New Global.System.Drawing.Point(40, 160)
			imgPreview_.Location = location
			Me.imgPreview_10.Name = "imgPreview_10"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_10, False)
			Dim imgPreview_2 As Global.System.Windows.Forms.Control = Me.imgPreview_10
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_2.Size = size
			Me.imgPreview_10.TabIndex = 12
			Me.imgPreview_10.TabStop = False
			Me.imgPreview_10.Visible = False
			Me.imgPreview_9.Image = CType(componentResourceManager.GetObject("imgPreview_9.Image"), Global.System.Drawing.Image)
			Dim imgPreview_3 As Global.System.Windows.Forms.Control = Me.imgPreview_9
			location = New Global.System.Drawing.Point(4, 160)
			imgPreview_3.Location = location
			Me.imgPreview_9.Name = "imgPreview_9"
			Dim imgPreview_4 As Global.System.Windows.Forms.Control = Me.imgPreview_9
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_4.Size = size
			Me.imgPreview_9.TabIndex = 11
			Me.imgPreview_9.TabStop = False
			Me.imgPreview_9.Visible = False
			Me.imgPreview_.Image = CType(componentResourceManager.GetObject("imgPreview_.Image"), Global.System.Drawing.Image)
			Me.imgPreview_.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_5 As Global.System.Windows.Forms.Control = Me.imgPreview_
			location = New Global.System.Drawing.Point(40, 120)
			imgPreview_5.Location = location
			Me.imgPreview_.Name = "imgPreview_"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_, False)
			Dim imgPreview_6 As Global.System.Windows.Forms.Control = Me.imgPreview_
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_6.Size = size
			Me.imgPreview_.TabIndex = 8
			Me.imgPreview_.TabStop = False
			Me.imgPreview_.Visible = False
			Me.imgPreview_6.Image = CType(componentResourceManager.GetObject("imgPreview_6.Image"), Global.System.Drawing.Image)
			Me.imgPreview_6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_7 As Global.System.Windows.Forms.Control = Me.imgPreview_6
			location = New Global.System.Drawing.Point(4, 120)
			imgPreview_7.Location = location
			Me.imgPreview_6.Name = "imgPreview_6"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_6, False)
			Dim imgPreview_8 As Global.System.Windows.Forms.Control = Me.imgPreview_6
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_8.Size = size
			Me.imgPreview_6.TabIndex = 7
			Me.imgPreview_6.TabStop = False
			Me.imgPreview_6.Visible = False
			Me.imgPreview_3.Image = CType(componentResourceManager.GetObject("imgPreview_3.Image"), Global.System.Drawing.Image)
			Me.imgPreview_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_9 As Global.System.Windows.Forms.Control = Me.imgPreview_3
			location = New Global.System.Drawing.Point(40, 80)
			imgPreview_9.Location = location
			Me.imgPreview_3.Name = "imgPreview_3"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_3, False)
			Dim imgPreview_10 As Global.System.Windows.Forms.Control = Me.imgPreview_3
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_10.Size = size
			Me.imgPreview_3.TabIndex = 5
			Me.imgPreview_3.TabStop = False
			Me.imgPreview_3.Visible = False
			Me.imgPreview_4.Image = CType(componentResourceManager.GetObject("imgPreview_4.Image"), Global.System.Drawing.Image)
			Me.imgPreview_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_11 As Global.System.Windows.Forms.Control = Me.imgPreview_4
			location = New Global.System.Drawing.Point(0, 80)
			imgPreview_11.Location = location
			Me.imgPreview_4.Name = "imgPreview_4"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_4, False)
			Dim imgPreview_12 As Global.System.Windows.Forms.Control = Me.imgPreview_4
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_12.Size = size
			Me.imgPreview_4.TabIndex = 4
			Me.imgPreview_4.TabStop = False
			Me.imgPreview_4.Visible = False
			Me.imgPreview_5.Image = CType(componentResourceManager.GetObject("imgPreview_5.Image"), Global.System.Drawing.Image)
			Me.imgPreview_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_13 As Global.System.Windows.Forms.Control = Me.imgPreview_5
			location = New Global.System.Drawing.Point(40, 40)
			imgPreview_13.Location = location
			Me.imgPreview_5.Name = "imgPreview_5"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_5, False)
			Dim imgPreview_14 As Global.System.Windows.Forms.Control = Me.imgPreview_5
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_14.Size = size
			Me.imgPreview_5.TabIndex = 3
			Me.imgPreview_5.TabStop = False
			Me.imgPreview_5.Visible = False
			Me.imgPreview_2.Image = CType(componentResourceManager.GetObject("imgPreview_2.Image"), Global.System.Drawing.Image)
			Me.imgPreview_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_15 As Global.System.Windows.Forms.Control = Me.imgPreview_2
			location = New Global.System.Drawing.Point(0, 40)
			imgPreview_15.Location = location
			Me.imgPreview_2.Name = "imgPreview_2"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_2, False)
			Dim imgPreview_16 As Global.System.Windows.Forms.Control = Me.imgPreview_2
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_16.Size = size
			Me.imgPreview_2.TabIndex = 2
			Me.imgPreview_2.TabStop = False
			Me.imgPreview_2.Visible = False
			Me.imgPreview_0.Image = CType(componentResourceManager.GetObject("imgPreview_0.Image"), Global.System.Drawing.Image)
			Me.imgPreview_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_17 As Global.System.Windows.Forms.Control = Me.imgPreview_0
			location = New Global.System.Drawing.Point(0, 0)
			imgPreview_17.Location = location
			Me.imgPreview_0.Name = "imgPreview_0"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_0, False)
			Dim imgPreview_18 As Global.System.Windows.Forms.Control = Me.imgPreview_0
			size = New Global.System.Drawing.Size(32, 38)
			imgPreview_18.Size = size
			Me.imgPreview_0.TabIndex = 1
			Me.imgPreview_0.TabStop = False
			Me.imgPreview_0.Visible = False
			Me.imgPreview_1.Image = CType(componentResourceManager.GetObject("imgPreview_1.Image"), Global.System.Drawing.Image)
			Me.imgPreview_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_19 As Global.System.Windows.Forms.Control = Me.imgPreview_1
			location = New Global.System.Drawing.Point(40, 0)
			imgPreview_19.Location = location
			Me.imgPreview_1.Name = "imgPreview_1"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_1, False)
			Dim imgPreview_20 As Global.System.Windows.Forms.Control = Me.imgPreview_1
			size = New Global.System.Drawing.Size(32, 40)
			imgPreview_20.Size = size
			Me.imgPreview_1.TabIndex = 0
			Me.imgPreview_1.TabStop = False
			Me.imgPreview_1.Visible = False
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_10)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_9)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_8)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_5)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_4)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_3)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_2)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_0)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_1)
			Me.grpOutputPages.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim grpOutputPages As Global.System.Windows.Forms.Control = Me.grpOutputPages
			location = New Global.System.Drawing.Point(16, 8)
			grpOutputPages.Location = location
			Me.grpOutputPages.Name = "grpOutputPages"
			Me.HelpProvider1.SetShowHelp(Me.grpOutputPages, False)
			Dim grpOutputPages2 As Global.System.Windows.Forms.Control = Me.grpOutputPages
			size = New Global.System.Drawing.Size(472, 179)
			grpOutputPages2.Size = size
			Me.grpOutputPages.TabIndex = 0
			Me.grpOutputPages.TabStop = False
			Me.grpOutputPages.Text = "Select output pages:"
			Me.chkReportOpt_10.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_10, "Rod String Order Summary")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_10, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_10.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_17 As Global.System.Windows.Forms.Control = Me.chkReportOpt_10
			location = New Global.System.Drawing.Point(8, 80)
			chkReportOpt_17.Location = location
			Me.chkReportOpt_10.Name = "chkReportOpt_10"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_10, True)
			Dim chkReportOpt_18 As Global.System.Windows.Forms.Control = Me.chkReportOpt_10
			size = New Global.System.Drawing.Size(448, 17)
			chkReportOpt_18.Size = size
			Me.chkReportOpt_10.TabIndex = 11
			Me.chkReportOpt_10.Text = "Rod String Order Summary"
			Me.chkReportOpt_9.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_9, "Setup Output: Scoring")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_9, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim chkReportOpt_19 As Global.System.Windows.Forms.Control = Me.chkReportOpt_9
			location = New Global.System.Drawing.Point(8, 32)
			chkReportOpt_19.Location = location
			Me.chkReportOpt_9.Name = "chkReportOpt_9"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_9, True)
			Dim chkReportOpt_20 As Global.System.Windows.Forms.Control = Me.chkReportOpt_9
			size = New Global.System.Drawing.Size(400, 17)
			chkReportOpt_20.Size = size
			Me.chkReportOpt_9.TabIndex = 10
			Me.chkReportOpt_9.Text = "System Design Scoring page"
			Me.chkReportOpt_.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_, "Setup Output: Cover Page")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_21 As Global.System.Windows.Forms.Control = Me.chkReportOpt_
			location = New Global.System.Drawing.Point(8, 16)
			chkReportOpt_21.Location = location
			Me.chkReportOpt_.Name = "chkReportOpt_"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_, True)
			Dim chkReportOpt_22 As Global.System.Windows.Forms.Control = Me.chkReportOpt_
			size = New Global.System.Drawing.Size(448, 16)
			chkReportOpt_22.Size = size
			Me.chkReportOpt_.TabIndex = 9
			Me.chkReportOpt_.Text = "Cover Page"
			Me.chkReportOpt_8.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_8, "Measured Deviation Survey")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_8, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_8.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_23 As Global.System.Windows.Forms.Control = Me.chkReportOpt_8
			location = New Global.System.Drawing.Point(8, 161)
			chkReportOpt_23.Location = location
			Me.chkReportOpt_8.Name = "chkReportOpt_8"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_8, True)
			Dim chkReportOpt_24 As Global.System.Windows.Forms.Control = Me.chkReportOpt_8
			size = New Global.System.Drawing.Size(448, 17)
			chkReportOpt_24.Size = size
			Me.chkReportOpt_8.TabIndex = 8
			Me.chkReportOpt_8.Text = "Deviation Profile Survey"
			Me.AcceptButton = Me.cmdOK
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			Me.CancelButton = Me.cmdCancel
			size = New Global.System.Drawing.Size(725, 283)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.pnlOutputOptions)
			Me.Controls.Add(Me.cmdHelp)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.cmdOK)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(827, 388)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgPrint"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Print Report"
			Me.pnlOutputOptions.ResumeLayout(False)
			Me.grpOutputOptions.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me.SSPanel.ResumeLayout(False)
			CType(Me.imgPreview_10, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_9, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_6, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_3, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_5, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_0, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.grpOutputPages.ResumeLayout(False)
			CType(Me.SSFrame, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkReportOpt, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgIcons, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
