Namespace RSWINV3
	Friend Partial Class dlgGuides
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgGuides))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me.ulgRodGuides = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me.Image = New Global.System.Windows.Forms.PictureBox()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.lblQuestionMark = New Global.System.Windows.Forms.Label()
			Me.btnNo = New Global.System.Windows.Forms.Button()
			Me.btnYes = New Global.System.Windows.Forms.Button()
			Me.cboGuides = New Global.System.Windows.Forms.ComboBox()
			Me.lblOverwrite = New Global.System.Windows.Forms.Label()
			Me.btnOverwriteNo = New Global.System.Windows.Forms.Button()
			Me.btnOverwriteYes = New Global.System.Windows.Forms.Button()
			Me._SSPanel_0.SuspendLayout()
			CType(Me.ulgRodGuides, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._SSPanel_0.Controls.Add(Me.ulgRodGuides)
			Me._SSPanel_0.Controls.Add(Me._Label_0)
			Me._SSPanel_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._SSPanel_0.ForeColor = Global.System.Drawing.Color.Black
			Me.SSPanel.SetIndex(Me._SSPanel_0, 0S)
			Dim sspanel_ As Global.System.Windows.Forms.Control = Me._SSPanel_0
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(38, 3)
			sspanel_.Location = location
			Me._SSPanel_0.Name = "_SSPanel_0"
			Me._SSPanel_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim sspanel_2 As Global.System.Windows.Forms.Control = Me._SSPanel_0
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(542, 494)
			sspanel_2.Size = size
			Me._SSPanel_0.TabIndex = 2
			Me._SSPanel_0.TabStop = True
			Me.ulgRodGuides.AllowDrop = True
			Me.ulgRodGuides.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim ulgRodGuides As Global.System.Windows.Forms.Control = Me.ulgRodGuides
			location = New Global.System.Drawing.Point(8, 54)
			ulgRodGuides.Location = location
			Me.ulgRodGuides.Name = "ulgRodGuides"
			Dim ulgRodGuides2 As Global.System.Windows.Forms.Control = Me.ulgRodGuides
			size = New Global.System.Drawing.Size(521, 435)
			ulgRodGuides2.Size = size
			Me.ulgRodGuides.TabIndex = 9
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_0, 0S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(23, 4)
			label_.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(489, 44)
			label_2.Size = size
			Me._Label_0.TabIndex = 3
			Me._Label_0.Text = "The Rod Guides found in file are different from the default found in Setup. Would you like to use the default rod guide in Setup? "
			Me._Label_0.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Image.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Image.Image = CType(componentResourceManager.GetObject("Image.Image"), Global.System.Drawing.Image)
			Me.Image.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim image As Global.System.Windows.Forms.Control = Me.Image
			location = New Global.System.Drawing.Point(3, 85)
			image.Location = location
			Me.Image.Name = "Image"
			Dim image2 As Global.System.Windows.Forms.Control = Me.Image
			size = New Global.System.Drawing.Size(32, 32)
			image2.Size = size
			Me.Image.TabIndex = 16
			Me.Image.TabStop = False
			Me.Panel1.Controls.Add(Me.lblQuestionMark)
			Me.Panel1.Controls.Add(Me.btnNo)
			Me.Panel1.Controls.Add(Me.btnYes)
			Me.Panel1.Controls.Add(Me.cboGuides)
			Me.Panel1.Controls.Add(Me.lblOverwrite)
			Me.Panel1.Controls.Add(Me.btnOverwriteNo)
			Me.Panel1.Controls.Add(Me.btnOverwriteYes)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(38, 503)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(542, 59)
			panel2.Size = size
			Me.Panel1.TabIndex = 40
			Me.lblQuestionMark.AutoSize = True
			Me.lblQuestionMark.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblQuestionMark As Global.System.Windows.Forms.Control = Me.lblQuestionMark
			location = New Global.System.Drawing.Point(472, 4)
			lblQuestionMark.Location = location
			Me.lblQuestionMark.Name = "lblQuestionMark"
			Dim lblQuestionMark2 As Global.System.Windows.Forms.Control = Me.lblQuestionMark
			size = New Global.System.Drawing.Size(17, 18)
			lblQuestionMark2.Size = size
			Me.lblQuestionMark.TabIndex = 49
			Me.lblQuestionMark.Text = "?"
			Me.lblQuestionMark.Visible = False
			Me.btnNo.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnNo.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnNo.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnNo.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnNo.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnNo As Global.System.Windows.Forms.Control = Me.btnNo
			location = New Global.System.Drawing.Point(274, 20)
			btnNo.Location = location
			Me.btnNo.Name = "btnNo"
			Me.btnNo.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim btnNo2 As Global.System.Windows.Forms.Control = Me.btnNo
			size = New Global.System.Drawing.Size(86, 23)
			btnNo2.Size = size
			Me.btnNo.TabIndex = 47
			Me.btnNo.Text = "No"
			Me.btnNo.UseVisualStyleBackColor = False
			Me.btnYes.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnYes.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnYes.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnYes.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnYes.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnYes As Global.System.Windows.Forms.Control = Me.btnYes
			location = New Global.System.Drawing.Point(182, 20)
			btnYes.Location = location
			Me.btnYes.Name = "btnYes"
			Me.btnYes.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim btnYes2 As Global.System.Windows.Forms.Control = Me.btnYes
			size = New Global.System.Drawing.Size(86, 23)
			btnYes2.Size = size
			Me.btnYes.TabIndex = 46
			Me.btnYes.Text = "Yes"
			Me.btnYes.UseVisualStyleBackColor = False
			Me.cboGuides.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cboGuides.FormattingEnabled = True
			Dim cboGuides As Global.System.Windows.Forms.Control = Me.cboGuides
			location = New Global.System.Drawing.Point(260, 3)
			cboGuides.Location = location
			Me.cboGuides.Name = "cboGuides"
			Dim cboGuides2 As Global.System.Windows.Forms.Control = Me.cboGuides
			size = New Global.System.Drawing.Size(212, 24)
			cboGuides2.Size = size
			Me.cboGuides.TabIndex = 45
			Me.cboGuides.Visible = False
			Me.lblOverwrite.AutoSize = True
			Me.lblOverwrite.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblOverwrite As Global.System.Windows.Forms.Control = Me.lblOverwrite
			location = New Global.System.Drawing.Point(5, 5)
			lblOverwrite.Location = location
			Me.lblOverwrite.Name = "lblOverwrite"
			Dim lblOverwrite2 As Global.System.Windows.Forms.Control = Me.lblOverwrite
			size = New Global.System.Drawing.Size(251, 16)
			lblOverwrite2.Size = size
			Me.lblOverwrite.TabIndex = 48
			Me.lblOverwrite.Text = "Overwrite Rod Guide default in Setup with "
			Me.lblOverwrite.Visible = False
			Me.btnOverwriteNo.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnOverwriteNo.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnOverwriteNo.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnOverwriteNo.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnOverwriteNo.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnOverwriteNo As Global.System.Windows.Forms.Control = Me.btnOverwriteNo
			location = New Global.System.Drawing.Point(274, 33)
			btnOverwriteNo.Location = location
			Me.btnOverwriteNo.Name = "btnOverwriteNo"
			Me.btnOverwriteNo.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim btnOverwriteNo2 As Global.System.Windows.Forms.Control = Me.btnOverwriteNo
			size = New Global.System.Drawing.Size(86, 23)
			btnOverwriteNo2.Size = size
			Me.btnOverwriteNo.TabIndex = 51
			Me.btnOverwriteNo.Text = "No"
			Me.btnOverwriteNo.UseVisualStyleBackColor = False
			Me.btnOverwriteNo.Visible = False
			Me.btnOverwriteYes.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnOverwriteYes.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnOverwriteYes.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnOverwriteYes.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnOverwriteYes.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnOverwriteYes As Global.System.Windows.Forms.Control = Me.btnOverwriteYes
			location = New Global.System.Drawing.Point(182, 33)
			btnOverwriteYes.Location = location
			Me.btnOverwriteYes.Name = "btnOverwriteYes"
			Me.btnOverwriteYes.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim btnOverwriteYes2 As Global.System.Windows.Forms.Control = Me.btnOverwriteYes
			size = New Global.System.Drawing.Size(86, 23)
			btnOverwriteYes2.Size = size
			Me.btnOverwriteYes.TabIndex = 50
			Me.btnOverwriteYes.Text = "Yes"
			Me.btnOverwriteYes.UseVisualStyleBackColor = False
			Me.btnOverwriteYes.Visible = False
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			Me.AutoScroll = True
			size = New Global.System.Drawing.Size(582, 572)
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
			Me.Name = "dlgGuides"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Rod Guide Differences"
			Me._SSPanel_0.ResumeLayout(False)
			CType(Me.ulgRodGuides, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
