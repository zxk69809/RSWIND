Namespace RSWINV3
	Friend Partial Class dlgSelectCBM
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgSelectCBM))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.SSPanel = New Global.System.Windows.Forms.Panel()
			Me._optCBData_1 = New Global.System.Windows.Forms.RadioButton()
			Me._optCBData_0 = New Global.System.Windows.Forms.RadioButton()
			Me.Label = New Global.System.Windows.Forms.Label()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.Image = New Global.System.Windows.Forms.PictureBox()
			Me.optCBData = New Global.Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
			Me.SSPanel.SuspendLayout()
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.optCBData, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.SSPanel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.SSPanel.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.SSPanel.Controls.Add(Me._optCBData_1)
			Me.SSPanel.Controls.Add(Me._optCBData_0)
			Me.SSPanel.Controls.Add(Me.Label)
			Me.SSPanel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.SSPanel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.SSPanel.ForeColor = Global.System.Drawing.Color.Black
			Dim sspanel As Global.System.Windows.Forms.Control = Me.SSPanel
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(64, 11)
			sspanel.Location = location
			Me.SSPanel.Name = "SSPanel"
			Me.SSPanel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim sspanel2 As Global.System.Windows.Forms.Control = Me.SSPanel
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(305, 137)
			sspanel2.Size = size
			Me.SSPanel.TabIndex = 2
			Me.SSPanel.TabStop = True
			Me._optCBData_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCBData_ As Global.System.Windows.Forms.Control = Me._optCBData_1
			location = New Global.System.Drawing.Point(47, 108)
			optCBData_.Location = location
			Me._optCBData_1.Name = "_optCBData_1"
			Dim optCBData_2 As Global.System.Windows.Forms.Control = Me._optCBData_1
			size = New Global.System.Drawing.Size(168, 20)
			optCBData_2.Size = size
			Me._optCBData_1.TabIndex = 6
			Me._optCBData_1.Text = "Minimum Energy"
			Me._optCBData_0.Checked = True
			Me._optCBData_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCBData_3 As Global.System.Windows.Forms.Control = Me._optCBData_0
			location = New Global.System.Drawing.Point(47, 79)
			optCBData_3.Location = location
			Me._optCBData_0.Name = "_optCBData_0"
			Dim optCBData_4 As Global.System.Windows.Forms.Control = Me._optCBData_0
			size = New Global.System.Drawing.Size(168, 19)
			optCBData_4.Size = size
			Me._optCBData_0.TabIndex = 5
			Me._optCBData_0.TabStop = True
			Me._optCBData_0.Text = "Minimum Torque"
			Me.Label.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.Label.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Label.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label
			location = New Global.System.Drawing.Point(8, 7)
			label.Location = location
			Me.Label.Name = "Label"
			Me.Label.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label
			size = New Global.System.Drawing.Size(293, 69)
			label2.Size = size
			Me.Label.TabIndex = 1
			Me.Label.Text = "RODSTAR has calculated a balanced CB moment for minimum torque and a balanced CB moment for minimum energy.  Which do you want to export to XBAL?"
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(379, 11)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(93, 31)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 0
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me.Image.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Image.Image = CType(componentResourceManager.GetObject("Image.Image"), Global.System.Drawing.Image)
			Me.Image.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim image As Global.System.Windows.Forms.Control = Me.Image
			location = New Global.System.Drawing.Point(14, 60)
			image.Location = location
			Me.Image.Name = "Image"
			Dim image2 As Global.System.Windows.Forms.Control = Me.Image
			size = New Global.System.Drawing.Size(37, 40)
			image2.Size = size
			Me.Image.TabIndex = 6
			Me.Image.TabStop = False
			Me.AcceptButton = Me.cmdOK
			size = New Global.System.Drawing.Size(7, 16)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(492, 165)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.SSPanel)
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me.Image)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(80, 330)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgSelectCBM"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "XBAL Information"
			Me.SSPanel.ResumeLayout(False)
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.optCBData, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
