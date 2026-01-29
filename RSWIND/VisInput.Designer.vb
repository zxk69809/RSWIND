Namespace RSWINV3
	Public Partial Class VisInput
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.VisInput))
			Me.VIImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.VIPanel2 = New Global.System.Windows.Forms.Panel()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.VILabel = New Global.System.Windows.Forms.Label()
			Me.VIPanel1 = New Global.System.Windows.Forms.Panel()
			Me.imgVIPicture = New Global.System.Windows.Forms.PictureBox()
			Me.VIContextMenu1 = New Global.System.Windows.Forms.ContextMenu()
			Me.cmdVISelInput = New Global.System.Windows.Forms.Button()
			Me.VIToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.VIPanel2.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.VIPanel1.SuspendLayout()
			CType(Me.imgVIPicture, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.VIImageList1.ColorDepth = Global.System.Windows.Forms.ColorDepth.Depth8Bit
			Dim viimageList As Global.System.Windows.Forms.ImageList = Me.VIImageList1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(16, 16)
			viimageList.ImageSize = size
			Me.VIImageList1.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.VIPanel2.BackColor = Global.System.Drawing.SystemColors.Control
			Me.VIPanel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.VIPanel2.Controls.Add(Me.Panel1)
			Me.VIPanel2.Controls.Add(Me.VIPanel1)
			Me.VIPanel2.Controls.Add(Me.cmdVISelInput)
			Me.VIPanel2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.VIPanel2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.VIPanel2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.VIPanel2, "Visual Input")
			Me.HelpProvider1.SetHelpNavigator(Me.VIPanel2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim vipanel As Global.System.Windows.Forms.Control = Me.VIPanel2
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(4, 8)
			vipanel.Location = location
			Me.VIPanel2.Name = "VIPanel2"
			Me.VIPanel2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.VIPanel2, True)
			Dim vipanel2 As Global.System.Windows.Forms.Control = Me.VIPanel2
			size = New Global.System.Drawing.Size(248, 588)
			vipanel2.Size = size
			Me.VIPanel2.TabIndex = 1
			Me.VIPanel2.TabStop = True
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.Panel1.Controls.Add(Me.VILabel)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(10, 24)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Me.HelpProvider1.SetShowHelp(Me.Panel1, False)
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(224, 72)
			panel2.Size = size
			Me.Panel1.TabIndex = 17
			Me.VILabel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.VILabel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.VILabel.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.VILabel.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.VILabel.ForeColor = Global.System.Drawing.SystemColors.Highlight
			Me.VILabel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim vilabel As Global.System.Windows.Forms.Control = Me.VILabel
			location = New Global.System.Drawing.Point(24, 8)
			vilabel.Location = location
			Me.VILabel.Name = "VILabel"
			Me.VILabel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.VILabel, False)
			Dim vilabel2 As Global.System.Windows.Forms.Control = Me.VILabel
			size = New Global.System.Drawing.Size(168, 50)
			vilabel2.Size = size
			Me.VILabel.TabIndex = 16
			Me.VILabel.Text = "  Right-click in the area whose data you want to change:"
			Me.VILabel.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.VIPanel1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.VIPanel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.VIPanel1.Controls.Add(Me.imgVIPicture)
			Me.VIPanel1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.VIPanel1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.VIPanel1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim vipanel3 As Global.System.Windows.Forms.Control = Me.VIPanel1
			location = New Global.System.Drawing.Point(10, 104)
			vipanel3.Location = location
			Me.VIPanel1.Name = "VIPanel1"
			Me.VIPanel1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.VIPanel1, False)
			Dim vipanel4 As Global.System.Windows.Forms.Control = Me.VIPanel1
			size = New Global.System.Drawing.Size(224, 424)
			vipanel4.Size = size
			Me.VIPanel1.TabIndex = 1
			Me.VIPanel1.TabStop = True
			Me.imgVIPicture.ContextMenu = Me.VIContextMenu1
			Me.imgVIPicture.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.HelpProvider1.SetHelpKeyword(Me.imgVIPicture, "Visual Input")
			Me.HelpProvider1.SetHelpNavigator(Me.imgVIPicture, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.imgVIPicture.Image = CType(componentResourceManager.GetObject("imgVIPicture.Image"), Global.System.Drawing.Image)
			Me.imgVIPicture.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgVIPicture As Global.System.Windows.Forms.Control = Me.imgVIPicture
			location = New Global.System.Drawing.Point(10, 16)
			imgVIPicture.Location = location
			Me.imgVIPicture.Name = "imgVIPicture"
			Me.HelpProvider1.SetShowHelp(Me.imgVIPicture, True)
			Dim imgVIPicture2 As Global.System.Windows.Forms.Control = Me.imgVIPicture
			size = New Global.System.Drawing.Size(200, 390)
			imgVIPicture2.Size = size
			Me.imgVIPicture.TabIndex = 16
			Me.imgVIPicture.TabStop = False
			Me.cmdVISelInput.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdVISelInput.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdVISelInput.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.cmdVISelInput.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdVISelInput, "Visual Input")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdVISelInput, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdVISelInput.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdVISelInput As Global.System.Windows.Forms.Control = Me.cmdVISelInput
			location = New Global.System.Drawing.Point(64, 544)
			cmdVISelInput.Location = location
			Me.cmdVISelInput.Name = "cmdVISelInput"
			Me.cmdVISelInput.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdVISelInput, True)
			Dim cmdVISelInput2 As Global.System.Windows.Forms.Control = Me.cmdVISelInput
			size = New Global.System.Drawing.Size(120, 24)
			cmdVISelInput2.Size = size
			Me.cmdVISelInput.TabIndex = 11
			Me.cmdVISelInput.Text = "Alphabetical list.."
			Me.cmdVISelInput.UseVisualStyleBackColor = False
			Me.VIToolTip1.ShowAlways = True
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(266, 609)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.VIPanel2)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			location = New Global.System.Drawing.Point(592, 100)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "VisInput"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "VisInput"
			Me.VIPanel2.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			Me.VIPanel1.ResumeLayout(False)
			CType(Me.imgVIPicture, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
