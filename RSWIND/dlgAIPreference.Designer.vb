Namespace RSWINV3
	Friend Partial Class dlgAIPreference
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgAIPreference))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me.ulgPreferences = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me.Image = New Global.System.Windows.Forms.PictureBox()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.chkUseFile = New Global.System.Windows.Forms.CheckBox()
			Me.chkUseSetup = New Global.System.Windows.Forms.CheckBox()
			Me.chkOverwriteSetupPreferences = New Global.System.Windows.Forms.CheckBox()
			Me._SSPanel_0.SuspendLayout()
			CType(Me.ulgPreferences, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._SSPanel_0.Controls.Add(Me.ulgPreferences)
			Me._SSPanel_0.Controls.Add(Me._Label_0)
			Me._SSPanel_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._SSPanel_0.ForeColor = Global.System.Drawing.Color.Black
			Me.SSPanel.SetIndex(Me._SSPanel_0, 0S)
			Dim sspanel_ As Global.System.Windows.Forms.Control = Me._SSPanel_0
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(47, 5)
			sspanel_.Location = location
			Me._SSPanel_0.Name = "_SSPanel_0"
			Me._SSPanel_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim sspanel_2 As Global.System.Windows.Forms.Control = Me._SSPanel_0
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(980, 640)
			sspanel_2.Size = size
			Me._SSPanel_0.TabIndex = 2
			Me._SSPanel_0.TabStop = True
			Me.ulgPreferences.AllowDrop = True
			Me.ulgPreferences.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim ulgPreferences As Global.System.Windows.Forms.Control = Me.ulgPreferences
			location = New Global.System.Drawing.Point(9, 59)
			ulgPreferences.Location = location
			Me.ulgPreferences.Name = "ulgPreferences"
			Dim ulgPreferences2 As Global.System.Windows.Forms.Control = Me.ulgPreferences
			size = New Global.System.Drawing.Size(952, 570)
			ulgPreferences2.Size = size
			Me.ulgPreferences.TabIndex = 9
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_0, 0S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(7, 5)
			label_.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(964, 54)
			label_2.Size = size
			Me._Label_0.TabIndex = 3
			Me._Label_0.Text = componentResourceManager.GetString("_Label_0.Text")
			Me._Label_0.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Image.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Image.Image = CType(componentResourceManager.GetObject("Image.Image"), Global.System.Drawing.Image)
			Me.Image.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim image As Global.System.Windows.Forms.Control = Me.Image
			location = New Global.System.Drawing.Point(7, 105)
			image.Location = location
			Me.Image.Name = "Image"
			Dim image2 As Global.System.Windows.Forms.Control = Me.Image
			size = New Global.System.Drawing.Size(37, 39)
			image2.Size = size
			Me.Image.TabIndex = 16
			Me.Image.TabStop = False
			Me.Panel1.Controls.Add(Me.cmdOK)
			Me.Panel1.Controls.Add(Me.chkUseFile)
			Me.Panel1.Controls.Add(Me.chkUseSetup)
			Me.Panel1.Controls.Add(Me.chkOverwriteSetupPreferences)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(47, 641)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(980, 64)
			panel2.Size = size
			Me.Panel1.TabIndex = 40
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(852, 10)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(112, 28)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 43
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me.chkUseFile.Font = New Global.System.Drawing.Font("Arial", 9F)
			Dim chkUseFile As Global.System.Windows.Forms.Control = Me.chkUseFile
			location = New Global.System.Drawing.Point(199, 12)
			chkUseFile.Location = location
			Me.chkUseFile.Name = "chkUseFile"
			Dim chkUseFile2 As Global.System.Windows.Forms.Control = Me.chkUseFile
			size = New Global.System.Drawing.Size(293, 22)
			chkUseFile2.Size = size
			Me.chkUseFile.TabIndex = 42
			Me.chkUseFile.Text = "Use AI Preferences from file"
			Me.chkUseSetup.Font = New Global.System.Drawing.Font("Arial", 9F)
			Dim chkUseSetup As Global.System.Windows.Forms.Control = Me.chkUseSetup
			location = New Global.System.Drawing.Point(501, 12)
			chkUseSetup.Location = location
			Me.chkUseSetup.Name = "chkUseSetup"
			Dim chkUseSetup2 As Global.System.Windows.Forms.Control = Me.chkUseSetup
			size = New Global.System.Drawing.Size(291, 22)
			chkUseSetup2.Size = size
			Me.chkUseSetup.TabIndex = 41
			Me.chkUseSetup.Text = "Use AI Preferences from Setup"
			Me.chkOverwriteSetupPreferences.Enabled = False
			Me.chkOverwriteSetupPreferences.Font = New Global.System.Drawing.Font("Arial", 9F)
			Dim chkOverwriteSetupPreferences As Global.System.Windows.Forms.Control = Me.chkOverwriteSetupPreferences
			location = New Global.System.Drawing.Point(199, 36)
			chkOverwriteSetupPreferences.Location = location
			Me.chkOverwriteSetupPreferences.Name = "chkOverwriteSetupPreferences"
			Dim chkOverwriteSetupPreferences2 As Global.System.Windows.Forms.Control = Me.chkOverwriteSetupPreferences
			size = New Global.System.Drawing.Size(290, 22)
			chkOverwriteSetupPreferences2.Size = size
			Me.chkOverwriteSetupPreferences.TabIndex = 40
			Me.chkOverwriteSetupPreferences.Text = "Overwrite Setup AI Preferences"
			Me.chkOverwriteSetupPreferences.Visible = False
			size = New Global.System.Drawing.Size(7, 16)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(1034, 705)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me._SSPanel_0)
			Me.Controls.Add(Me.Image)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(64, 184)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgAIPreference"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "AI Preference Differences"
			Me._SSPanel_0.ResumeLayout(False)
			CType(Me.ulgPreferences, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
