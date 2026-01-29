Namespace RSWINV3
	Friend Partial Class FAboutSplash
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.FAboutSplash))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.Picture1 = New Global.System.Windows.Forms.Panel()
			Me.lblUserInfo = New Global.System.Windows.Forms.Label()
			Me.lblUserName = New Global.System.Windows.Forms.Label()
			Me.cmdSysInfo = New Global.System.Windows.Forms.Button()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.lblCompanyName = New Global.System.Windows.Forms.Label()
			Me.lblFileDescription = New Global.System.Windows.Forms.Label()
			Me._lblMisc_0 = New Global.System.Windows.Forms.Label()
			Me.lblPathEXE = New Global.System.Windows.Forms.Label()
			Me.lblTrademark = New Global.System.Windows.Forms.Label()
			Me.lblCopyright = New Global.System.Windows.Forms.Label()
			Me._linDivide_1 = New Global.System.Windows.Forms.Label()
			Me._linDivide_0 = New Global.System.Windows.Forms.Label()
			Me.lblWarning = New Global.System.Windows.Forms.Label()
			Me.lblVersion = New Global.System.Windows.Forms.Label()
			Me.lblTitle = New Global.System.Windows.Forms.Label()
			Me.imgIcon = New Global.System.Windows.Forms.PictureBox()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.lblMisc = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.linDivide = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.lblDemoMode = New Global.System.Windows.Forms.Label()
			Me.Picture1.SuspendLayout()
			CType(Me.imgIcon, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblMisc, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linDivide, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Picture1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Picture1.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.Picture1.Controls.Add(Me.lblUserInfo)
			Me.Picture1.Controls.Add(Me.lblUserName)
			Me.Picture1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Picture1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.Picture1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim picture As Global.System.Windows.Forms.Control = Me.Picture1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(8, 176)
			picture.Location = location
			Me.Picture1.Name = "Picture1"
			Me.Picture1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim picture2 As Global.System.Windows.Forms.Control = Me.Picture1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(728, 36)
			picture2.Size = size
			Me.Picture1.TabIndex = 7
			Me.Picture1.TabStop = True
			Me.lblUserInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblUserInfo.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblUserInfo.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblUserInfo.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblUserInfo.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblUserInfo As Global.System.Windows.Forms.Control = Me.lblUserInfo
			location = New Global.System.Drawing.Point(8, 16)
			lblUserInfo.Location = location
			Me.lblUserInfo.Name = "lblUserInfo"
			Me.lblUserInfo.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblUserInfo2 As Global.System.Windows.Forms.Control = Me.lblUserInfo
			size = New Global.System.Drawing.Size(704, 17)
			lblUserInfo2.Size = size
			Me.lblUserInfo.TabIndex = 9
			Me.lblUserName.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblUserName.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblUserName.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblUserName.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblUserName.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblUserName As Global.System.Windows.Forms.Control = Me.lblUserName
			location = New Global.System.Drawing.Point(8, 0)
			lblUserName.Location = location
			Me.lblUserName.Name = "lblUserName"
			Me.lblUserName.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblUserName2 As Global.System.Windows.Forms.Control = Me.lblUserName
			size = New Global.System.Drawing.Size(704, 17)
			lblUserName2.Size = size
			Me.lblUserName.TabIndex = 8
			Me.cmdSysInfo.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdSysInfo.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdSysInfo.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdSysInfo.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdSysInfo.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdSysInfo As Global.System.Windows.Forms.Control = Me.cmdSysInfo
			location = New Global.System.Drawing.Point(632, 296)
			cmdSysInfo.Location = location
			Me.cmdSysInfo.Name = "cmdSysInfo"
			Me.cmdSysInfo.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdSysInfo2 As Global.System.Windows.Forms.Control = Me.cmdSysInfo
			size = New Global.System.Drawing.Size(96, 32)
			cmdSysInfo2.Size = size
			Me.cmdSysInfo.TabIndex = 13
			Me.cmdSysInfo.Text = "&System Info.."
			Me.cmdSysInfo.UseVisualStyleBackColor = False
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(632, 264)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(96, 25)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 12
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me.lblCompanyName.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblCompanyName.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblCompanyName.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Me.lblCompanyName.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblCompanyName.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCompanyName As Global.System.Windows.Forms.Control = Me.lblCompanyName
			location = New Global.System.Drawing.Point(104, 48)
			lblCompanyName.Location = location
			Me.lblCompanyName.Name = "lblCompanyName"
			Me.lblCompanyName.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblCompanyName2 As Global.System.Windows.Forms.Control = Me.lblCompanyName
			size = New Global.System.Drawing.Size(632, 16)
			lblCompanyName2.Size = size
			Me.lblCompanyName.TabIndex = 1
			Me.lblFileDescription.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblFileDescription.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblFileDescription.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblFileDescription.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblFileDescription.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblFileDescription As Global.System.Windows.Forms.Control = Me.lblFileDescription
			location = New Global.System.Drawing.Point(8, 136)
			lblFileDescription.Location = location
			Me.lblFileDescription.Name = "lblFileDescription"
			Me.lblFileDescription.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblFileDescription2 As Global.System.Windows.Forms.Control = Me.lblFileDescription
			size = New Global.System.Drawing.Size(728, 17)
			lblFileDescription2.Size = size
			Me.lblFileDescription.TabIndex = 5
			Me._lblMisc_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._lblMisc_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._lblMisc_0.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me._lblMisc_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._lblMisc_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.lblMisc.SetIndex(Me._lblMisc_0, 0S)
			Dim lblMisc_ As Global.System.Windows.Forms.Control = Me._lblMisc_0
			location = New Global.System.Drawing.Point(8, 160)
			lblMisc_.Location = location
			Me._lblMisc_0.Name = "_lblMisc_0"
			Me._lblMisc_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblMisc_2 As Global.System.Windows.Forms.Control = Me._lblMisc_0
			size = New Global.System.Drawing.Size(728, 17)
			lblMisc_2.Size = size
			Me._lblMisc_0.TabIndex = 6
			Me._lblMisc_0.Text = "This product is licensed to:"
			Me.lblPathEXE.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblPathEXE.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblPathEXE.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblPathEXE.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblPathEXE.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblPathEXE As Global.System.Windows.Forms.Control = Me.lblPathEXE
			location = New Global.System.Drawing.Point(8, 216)
			lblPathEXE.Location = location
			Me.lblPathEXE.Name = "lblPathEXE"
			Me.lblPathEXE.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblPathEXE2 As Global.System.Windows.Forms.Control = Me.lblPathEXE
			size = New Global.System.Drawing.Size(728, 32)
			lblPathEXE2.Size = size
			Me.lblPathEXE.TabIndex = 10
			Me.lblTrademark.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblTrademark.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblTrademark.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblTrademark.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblTrademark.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblTrademark As Global.System.Windows.Forms.Control = Me.lblTrademark
			location = New Global.System.Drawing.Point(8, 120)
			lblTrademark.Location = location
			Me.lblTrademark.Name = "lblTrademark"
			Me.lblTrademark.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblTrademark2 As Global.System.Windows.Forms.Control = Me.lblTrademark
			size = New Global.System.Drawing.Size(728, 17)
			lblTrademark2.Size = size
			Me.lblTrademark.TabIndex = 4
			Me.lblCopyright.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblCopyright.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblCopyright.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblCopyright.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblCopyright.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCopyright As Global.System.Windows.Forms.Control = Me.lblCopyright
			location = New Global.System.Drawing.Point(8, 104)
			lblCopyright.Location = location
			Me.lblCopyright.Name = "lblCopyright"
			Me.lblCopyright.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblCopyright2 As Global.System.Windows.Forms.Control = Me.lblCopyright
			size = New Global.System.Drawing.Size(728, 17)
			lblCopyright2.Size = size
			Me.lblCopyright.TabIndex = 3
			Me._linDivide_1.BackColor = Global.System.Drawing.SystemColors.WindowText
			Me._linDivide_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.linDivide.SetIndex(Me._linDivide_1, 1S)
			Dim linDivide_ As Global.System.Windows.Forms.Control = Me._linDivide_1
			location = New Global.System.Drawing.Point(8, 248)
			linDivide_.Location = location
			Me._linDivide_1.Name = "_linDivide_1"
			Dim linDivide_2 As Global.System.Windows.Forms.Control = Me._linDivide_1
			size = New Global.System.Drawing.Size(728, 1)
			linDivide_2.Size = size
			Me._linDivide_1.TabIndex = 14
			Me._linDivide_0.BackColor = Global.System.Drawing.SystemColors.WindowText
			Me._linDivide_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.linDivide.SetIndex(Me._linDivide_0, 0S)
			Dim linDivide_3 As Global.System.Windows.Forms.Control = Me._linDivide_0
			location = New Global.System.Drawing.Point(8, 96)
			linDivide_3.Location = location
			Me._linDivide_0.Name = "_linDivide_0"
			Dim linDivide_4 As Global.System.Windows.Forms.Control = Me._linDivide_0
			size = New Global.System.Drawing.Size(728, 1)
			linDivide_4.Size = size
			Me._linDivide_0.TabIndex = 15
			Me.lblWarning.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblWarning.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblWarning.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblWarning.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblWarning.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblWarning As Global.System.Windows.Forms.Control = Me.lblWarning
			location = New Global.System.Drawing.Point(8, 256)
			lblWarning.Location = location
			Me.lblWarning.Name = "lblWarning"
			Me.lblWarning.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblWarning2 As Global.System.Windows.Forms.Control = Me.lblWarning
			size = New Global.System.Drawing.Size(616, 73)
			lblWarning2.Size = size
			Me.lblWarning.TabIndex = 11
			Me.lblVersion.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblVersion.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblVersion.Font = New Global.System.Drawing.Font("Arial", 14.25F)
			Me.lblVersion.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblVersion.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblVersion As Global.System.Windows.Forms.Control = Me.lblVersion
			location = New Global.System.Drawing.Point(104, 64)
			lblVersion.Location = location
			Me.lblVersion.Name = "lblVersion"
			Me.lblVersion.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblVersion2 As Global.System.Windows.Forms.Control = Me.lblVersion
			size = New Global.System.Drawing.Size(632, 25)
			lblVersion2.Size = size
			Me.lblVersion.TabIndex = 2
			Me.lblVersion.Text = "version information"
			Me.lblTitle.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblTitle.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblTitle.Font = New Global.System.Drawing.Font("Arial", 16F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic)
			Me.lblTitle.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblTitle.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblTitle As Global.System.Windows.Forms.Control = Me.lblTitle
			location = New Global.System.Drawing.Point(104, 9)
			lblTitle.Location = location
			Me.lblTitle.Name = "lblTitle"
			Me.lblTitle.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblTitle2 As Global.System.Windows.Forms.Control = Me.lblTitle
			size = New Global.System.Drawing.Size(632, 31)
			lblTitle2.Size = size
			Me.lblTitle.TabIndex = 0
			Me.lblTitle.Text = "application title"
			Me.imgIcon.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.imgIcon.Image = CType(componentResourceManager.GetObject("imgIcon.Image"), Global.System.Drawing.Image)
			Me.imgIcon.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgIcon As Global.System.Windows.Forms.Control = Me.imgIcon
			location = New Global.System.Drawing.Point(8, 8)
			imgIcon.Location = location
			Me.imgIcon.Name = "imgIcon"
			Dim imgIcon2 As Global.System.Windows.Forms.Control = Me.imgIcon
			size = New Global.System.Drawing.Size(80, 88)
			imgIcon2.Size = size
			Me.imgIcon.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.imgIcon.TabIndex = 16
			Me.imgIcon.TabStop = False
			Me.Timer1.Interval = 1
			Me.lblDemoMode.BackColor = Global.System.Drawing.Color.Red
			Me.lblDemoMode.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblDemoMode.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblDemoMode.ForeColor = Global.System.Drawing.Color.White
			Dim lblDemoMode As Global.System.Windows.Forms.Control = Me.lblDemoMode
			location = New Global.System.Drawing.Point(632, 336)
			lblDemoMode.Location = location
			Me.lblDemoMode.Name = "lblDemoMode"
			Dim lblDemoMode2 As Global.System.Windows.Forms.Control = Me.lblDemoMode
			size = New Global.System.Drawing.Size(104, 20)
			lblDemoMode2.Size = size
			Me.lblDemoMode.TabIndex = 17
			Me.lblDemoMode.Text = "- DEMO MODE -"
			Me.lblDemoMode.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblDemoMode.Visible = False
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(749, 413)
			Me.ClientSize = size
			Me.Controls.Add(Me.lblDemoMode)
			Me.Controls.Add(Me.Picture1)
			Me.Controls.Add(Me.cmdSysInfo)
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me.lblCompanyName)
			Me.Controls.Add(Me.lblFileDescription)
			Me.Controls.Add(Me._lblMisc_0)
			Me.Controls.Add(Me.lblPathEXE)
			Me.Controls.Add(Me.lblTrademark)
			Me.Controls.Add(Me.lblCopyright)
			Me.Controls.Add(Me._linDivide_1)
			Me.Controls.Add(Me._linDivide_0)
			Me.Controls.Add(Me.lblWarning)
			Me.Controls.Add(Me.lblVersion)
			Me.Controls.Add(Me.lblTitle)
			Me.Controls.Add(Me.imgIcon)
			Me.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(3, 22)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FAboutSplash"
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Picture1.ResumeLayout(False)
			CType(Me.imgIcon, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblMisc, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linDivide, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
