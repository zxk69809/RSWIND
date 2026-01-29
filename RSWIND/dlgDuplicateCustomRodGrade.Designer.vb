Namespace RSWINV3
	Friend Partial Class dlgDuplicateCustomRodGrade
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgDuplicateCustomRodGrade))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdUseSetup = New Global.System.Windows.Forms.Button()
			Me.cmdUseFile = New Global.System.Windows.Forms.Button()
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me.panRodGrade = New Global.System.Windows.Forms.Label()
			Me._SSPanel_1 = New Global.System.Windows.Forms.Panel()
			Me.panTSSetup = New Global.System.Windows.Forms.Label()
			Me.panTSFile = New Global.System.Windows.Forms.Label()
			Me.panStressFile = New Global.System.Windows.Forms.Label()
			Me.panStressSetup = New Global.System.Windows.Forms.Label()
			Me._Label_5 = New Global.System.Windows.Forms.Label()
			Me._Label_4 = New Global.System.Windows.Forms.Label()
			Me._Label_3 = New Global.System.Windows.Forms.Label()
			Me._Label_2 = New Global.System.Windows.Forms.Label()
			Me._Label_1 = New Global.System.Windows.Forms.Label()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me.Image = New Global.System.Windows.Forms.PictureBox()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me._SSPanel_0.SuspendLayout()
			Me._SSPanel_1.SuspendLayout()
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.cmdUseSetup.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdUseSetup.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdUseSetup.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdUseSetup.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdUseSetup.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdUseSetup As Global.System.Windows.Forms.Control = Me.cmdUseSetup
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(47, 205)
			cmdUseSetup.Location = location
			Me.cmdUseSetup.Name = "cmdUseSetup"
			Me.cmdUseSetup.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdUseSetup2 As Global.System.Windows.Forms.Control = Me.cmdUseSetup
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(248, 22)
			cmdUseSetup2.Size = size
			Me.cmdUseSetup.TabIndex = 0
			Me.cmdUseSetup.Text = "Use information from Setup"
			Me.cmdUseSetup.UseVisualStyleBackColor = False
			Me.cmdUseFile.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdUseFile.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdUseFile.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdUseFile.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdUseFile.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdUseFile As Global.System.Windows.Forms.Control = Me.cmdUseFile
			location = New Global.System.Drawing.Point(336, 205)
			cmdUseFile.Location = location
			Me.cmdUseFile.Name = "cmdUseFile"
			Me.cmdUseFile.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdUseFile2 As Global.System.Windows.Forms.Control = Me.cmdUseFile
			size = New Global.System.Drawing.Size(248, 22)
			cmdUseFile2.Size = size
			Me.cmdUseFile.TabIndex = 1
			Me.cmdUseFile.Text = "Use information from file"
			Me.cmdUseFile.UseVisualStyleBackColor = False
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._SSPanel_0.Controls.Add(Me.panRodGrade)
			Me._SSPanel_0.Controls.Add(Me._SSPanel_1)
			Me._SSPanel_0.Controls.Add(Me._Label_5)
			Me._SSPanel_0.Controls.Add(Me._Label_4)
			Me._SSPanel_0.Controls.Add(Me._Label_3)
			Me._SSPanel_0.Controls.Add(Me._Label_2)
			Me._SSPanel_0.Controls.Add(Me._Label_1)
			Me._SSPanel_0.Controls.Add(Me._Label_0)
			Me._SSPanel_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._SSPanel_0.ForeColor = Global.System.Drawing.Color.Black
			Me.SSPanel.SetIndex(Me._SSPanel_0, 0S)
			Dim sspanel_ As Global.System.Windows.Forms.Control = Me._SSPanel_0
			location = New Global.System.Drawing.Point(47, 4)
			sspanel_.Location = location
			Me._SSPanel_0.Name = "_SSPanel_0"
			Me._SSPanel_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim sspanel_2 As Global.System.Windows.Forms.Control = Me._SSPanel_0
			size = New Global.System.Drawing.Size(537, 195)
			sspanel_2.Size = size
			Me._SSPanel_0.TabIndex = 2
			Me._SSPanel_0.TabStop = True
			Me.panRodGrade.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim panRodGrade As Global.System.Windows.Forms.Control = Me.panRodGrade
			location = New Global.System.Drawing.Point(272, 88)
			panRodGrade.Location = location
			Me.panRodGrade.Name = "panRodGrade"
			Dim panRodGrade2 As Global.System.Windows.Forms.Control = Me.panRodGrade
			size = New Global.System.Drawing.Size(216, 16)
			panRodGrade2.Size = size
			Me.panRodGrade.TabIndex = 15
			Me.panRodGrade.Text = "Label1"
			Me._SSPanel_1.BackColor = Global.System.Drawing.SystemColors.Window
			Me._SSPanel_1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._SSPanel_1.Controls.Add(Me.panTSSetup)
			Me._SSPanel_1.Controls.Add(Me.panTSFile)
			Me._SSPanel_1.Controls.Add(Me.panStressFile)
			Me._SSPanel_1.Controls.Add(Me.panStressSetup)
			Me._SSPanel_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._SSPanel_1.ForeColor = Global.System.Drawing.Color.Blue
			Me.SSPanel.SetIndex(Me._SSPanel_1, 1S)
			Dim sspanel_3 As Global.System.Windows.Forms.Control = Me._SSPanel_1
			location = New Global.System.Drawing.Point(96, 146)
			sspanel_3.Location = location
			Me._SSPanel_1.Name = "_SSPanel_1"
			Me._SSPanel_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim sspanel_4 As Global.System.Windows.Forms.Control = Me._SSPanel_1
			size = New Global.System.Drawing.Size(392, 38)
			sspanel_4.Size = size
			Me._SSPanel_1.TabIndex = 9
			Me._SSPanel_1.TabStop = True
			Me.panTSSetup.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panTSSetup.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim panTSSetup As Global.System.Windows.Forms.Control = Me.panTSSetup
			location = New Global.System.Drawing.Point(0, 0)
			panTSSetup.Location = location
			Me.panTSSetup.Name = "panTSSetup"
			Dim panTSSetup2 As Global.System.Windows.Forms.Control = Me.panTSSetup
			size = New Global.System.Drawing.Size(112, 16)
			panTSSetup2.Size = size
			Me.panTSSetup.TabIndex = 17
			Me.panTSSetup.Text = "Label1"
			Me.panTSFile.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panTSFile.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim panTSFile As Global.System.Windows.Forms.Control = Me.panTSFile
			location = New Global.System.Drawing.Point(0, 16)
			panTSFile.Location = location
			Me.panTSFile.Name = "panTSFile"
			Dim panTSFile2 As Global.System.Windows.Forms.Control = Me.panTSFile
			size = New Global.System.Drawing.Size(112, 16)
			panTSFile2.Size = size
			Me.panTSFile.TabIndex = 16
			Me.panTSFile.Text = "Label1"
			Me.panStressFile.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panStressFile.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim panStressFile As Global.System.Windows.Forms.Control = Me.panStressFile
			location = New Global.System.Drawing.Point(120, 16)
			panStressFile.Location = location
			Me.panStressFile.Name = "panStressFile"
			Dim panStressFile2 As Global.System.Windows.Forms.Control = Me.panStressFile
			size = New Global.System.Drawing.Size(256, 16)
			panStressFile2.Size = size
			Me.panStressFile.TabIndex = 15
			Me.panStressFile.Text = "Label1"
			Me.panStressSetup.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panStressSetup.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim panStressSetup As Global.System.Windows.Forms.Control = Me.panStressSetup
			location = New Global.System.Drawing.Point(120, 0)
			panStressSetup.Location = location
			Me.panStressSetup.Name = "panStressSetup"
			Dim panStressSetup2 As Global.System.Windows.Forms.Control = Me.panStressSetup
			size = New Global.System.Drawing.Size(256, 16)
			panStressSetup2.Size = size
			Me.panStressSetup.TabIndex = 14
			Me.panStressSetup.Text = "Label1"
			Me._Label_5.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_5.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_5.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_5.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_5, 5S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_5
			location = New Global.System.Drawing.Point(8, 167)
			label_.Location = location
			Me._Label_5.Name = "_Label_5"
			Me._Label_5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_5
			size = New Global.System.Drawing.Size(80, 16)
			label_2.Size = size
			Me._Label_5.TabIndex = 8
			Me._Label_5.Text = "File:"
			Me._Label_5.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_4.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_4.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_4.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_4, 4S)
			Dim label_3 As Global.System.Windows.Forms.Control = Me._Label_4
			location = New Global.System.Drawing.Point(8, 149)
			label_3.Location = location
			Me._Label_4.Name = "_Label_4"
			Me._Label_4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_4 As Global.System.Windows.Forms.Control = Me._Label_4
			size = New Global.System.Drawing.Size(80, 16)
			label_4.Size = size
			Me._Label_4.TabIndex = 7
			Me._Label_4.Text = "Setup:"
			Me._Label_4.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_3.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_3.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_3.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_3, 3S)
			Dim label_5 As Global.System.Windows.Forms.Control = Me._Label_3
			location = New Global.System.Drawing.Point(224, 119)
			label_5.Location = location
			Me._Label_3.Name = "_Label_3"
			Me._Label_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_6 As Global.System.Windows.Forms.Control = Me._Label_3
			size = New Global.System.Drawing.Size(264, 16)
			label_6.Size = size
			Me._Label_3.TabIndex = 6
			Me._Label_3.Text = "Stress analysis method:"
			Me._Label_3.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me._Label_2.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_2, 2S)
			Dim label_7 As Global.System.Windows.Forms.Control = Me._Label_2
			location = New Global.System.Drawing.Point(96, 119)
			label_7.Location = location
			Me._Label_2.Name = "_Label_2"
			Me._Label_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_8 As Global.System.Windows.Forms.Control = Me._Label_2
			size = New Global.System.Drawing.Size(112, 26)
			label_8.Size = size
			Me._Label_2.TabIndex = 5
			Me._Label_2.Text = "Tensile strength:"
			Me._Label_2.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me._Label_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_1, 1S)
			Dim label_9 As Global.System.Windows.Forms.Control = Me._Label_1
			location = New Global.System.Drawing.Point(48, 86)
			label_9.Location = location
			Me._Label_1.Name = "_Label_1"
			Me._Label_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_10 As Global.System.Windows.Forms.Control = Me._Label_1
			size = New Global.System.Drawing.Size(171, 13)
			label_10.Size = size
			Me._Label_1.TabIndex = 4
			Me._Label_1.Text = "Custom rod grade name:"
			Me._Label_1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_0, 0S)
			Dim label_11 As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(6, 4)
			label_11.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_12 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(522, 65)
			label_12.Size = size
			Me._Label_0.TabIndex = 3
			Me._Label_0.Text = componentResourceManager.GetString("_Label_0.Text")
			Me.Image.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Image.Image = CType(componentResourceManager.GetObject("Image.Image"), Global.System.Drawing.Image)
			Me.Image.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim image As Global.System.Windows.Forms.Control = Me.Image
			location = New Global.System.Drawing.Point(6, 85)
			image.Location = location
			Me.Image.Name = "Image"
			Dim image2 As Global.System.Windows.Forms.Control = Me.Image
			size = New Global.System.Drawing.Size(32, 32)
			image2.Size = size
			Me.Image.TabIndex = 16
			Me.Image.TabStop = False
			Me.AcceptButton = Me.cmdUseSetup
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(621, 255)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.cmdUseSetup)
			Me.Controls.Add(Me.cmdUseFile)
			Me.Controls.Add(Me._SSPanel_0)
			Me.Controls.Add(Me.Image)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(64, 184)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgDuplicateCustomRodGrade"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Duplicate Custom Rod Grade"
			Me._SSPanel_0.ResumeLayout(False)
			Me._SSPanel_1.ResumeLayout(False)
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
