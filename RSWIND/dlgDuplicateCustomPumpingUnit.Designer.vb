Namespace RSWINV3
	Friend Partial Class dlgDuplicateCustomPumpingUnit
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgDuplicateCustomPumpingUnit))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdUseSetup = New Global.System.Windows.Forms.Button()
			Me.cmdUseFile = New Global.System.Windows.Forms.Button()
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			Me.lblUnitName = New Global.System.Windows.Forms.Label()
			Me._Label_1 = New Global.System.Windows.Forms.Label()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me.Image = New Global.System.Windows.Forms.PictureBox()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me._SSPanel_0.SuspendLayout()
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
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(88, 320)
			cmdUseSetup.Location = location
			Me.cmdUseSetup.Name = "cmdUseSetup"
			Me.cmdUseSetup.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdUseSetup2 As Global.System.Windows.Forms.Control = Me.cmdUseSetup
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(209, 22)
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
			location = New Global.System.Drawing.Point(368, 320)
			cmdUseFile.Location = location
			Me.cmdUseFile.Name = "cmdUseFile"
			Me.cmdUseFile.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdUseFile2 As Global.System.Windows.Forms.Control = Me.cmdUseFile
			size = New Global.System.Drawing.Size(209, 22)
			cmdUseFile2.Size = size
			Me.cmdUseFile.TabIndex = 1
			Me.cmdUseFile.Text = "Use information from file"
			Me.cmdUseFile.UseVisualStyleBackColor = False
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._SSPanel_0.Controls.Add(Me.RichTextBox1)
			Me._SSPanel_0.Controls.Add(Me.lblUnitName)
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
			size = New Global.System.Drawing.Size(569, 308)
			sspanel_2.Size = size
			Me._SSPanel_0.TabIndex = 2
			Me._SSPanel_0.TabStop = True
			Dim richTextBox As Global.System.Windows.Forms.Control = Me.RichTextBox1
			location = New Global.System.Drawing.Point(8, 88)
			richTextBox.Location = location
			Me.RichTextBox1.Name = "RichTextBox1"
			Dim richTextBox2 As Global.System.Windows.Forms.Control = Me.RichTextBox1
			size = New Global.System.Drawing.Size(552, 208)
			richTextBox2.Size = size
			Me.RichTextBox1.TabIndex = 16
			Me.RichTextBox1.Text = ""
			Me.lblUnitName.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblUnitName As Global.System.Windows.Forms.Control = Me.lblUnitName
			location = New Global.System.Drawing.Point(160, 64)
			lblUnitName.Location = location
			Me.lblUnitName.Name = "lblUnitName"
			Dim lblUnitName2 As Global.System.Windows.Forms.Control = Me.lblUnitName
			size = New Global.System.Drawing.Size(392, 16)
			lblUnitName2.Size = size
			Me.lblUnitName.TabIndex = 15
			Me._Label_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_1, 1S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_1
			location = New Global.System.Drawing.Point(8, 64)
			label_.Location = location
			Me._Label_1.Name = "_Label_1"
			Me._Label_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_1
			size = New Global.System.Drawing.Size(144, 13)
			label_2.Size = size
			Me._Label_1.TabIndex = 4
			Me._Label_1.Text = "Custom pumping unit name:"
			Me._Label_1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_0, 0S)
			Dim label_3 As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(6, 4)
			label_3.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_4 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(554, 52)
			label_4.Size = size
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
			size = New Global.System.Drawing.Size(663, 372)
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
			Me.Name = "dlgDuplicateCustomPumpingUnit"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Duplicate Custom Pumping Unit"
			Me._SSPanel_0.ResumeLayout(False)
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
