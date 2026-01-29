Namespace RSWINV3
	Friend Partial Class dlgPUManuf
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgPUManuf))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me._SSPanel_1 = New Global.System.Windows.Forms.Panel()
			Me.txtPUManuf = New Global.System.Windows.Forms.TextBox()
			Me.Label = New Global.System.Windows.Forms.Label()
			Me.Image = New Global.System.Windows.Forms.PictureBox()
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me._SSPanel_0.SuspendLayout()
			Me._SSPanel_1.SuspendLayout()
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(467, 9)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(96, 29)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 4
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._SSPanel_0.Controls.Add(Me._SSPanel_1)
			Me._SSPanel_0.Controls.Add(Me.Label)
			Me._SSPanel_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._SSPanel_0.ForeColor = Global.System.Drawing.Color.Black
			Me.SSPanel.SetIndex(Me._SSPanel_0, 0S)
			Dim sspanel_ As Global.System.Windows.Forms.Control = Me._SSPanel_0
			location = New Global.System.Drawing.Point(52, 9)
			sspanel_.Location = location
			Me._SSPanel_0.Name = "_SSPanel_0"
			Me._SSPanel_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim sspanel_2 As Global.System.Windows.Forms.Control = Me._SSPanel_0
			size = New Global.System.Drawing.Size(405, 104)
			sspanel_2.Size = size
			Me._SSPanel_0.TabIndex = 0
			Me._SSPanel_0.TabStop = True
			Me._SSPanel_1.BackColor = Global.System.Drawing.SystemColors.Window
			Me._SSPanel_1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._SSPanel_1.Controls.Add(Me.txtPUManuf)
			Me._SSPanel_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._SSPanel_1.ForeColor = Global.System.Drawing.Color.Black
			Me.SSPanel.SetIndex(Me._SSPanel_1, 1S)
			Dim sspanel_3 As Global.System.Windows.Forms.Control = Me._SSPanel_1
			location = New Global.System.Drawing.Point(31, 64)
			sspanel_3.Location = location
			Me._SSPanel_1.Name = "_SSPanel_1"
			Me._SSPanel_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim sspanel_4 As Global.System.Windows.Forms.Control = Me._SSPanel_1
			size = New Global.System.Drawing.Size(342, 28)
			sspanel_4.Size = size
			Me._SSPanel_1.TabIndex = 2
			Me._SSPanel_1.TabStop = True
			Me.txtPUManuf.AcceptsReturn = True
			Me.txtPUManuf.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPUManuf.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtPUManuf.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPUManuf.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtPUManuf.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtPUManuf As Global.System.Windows.Forms.Control = Me.txtPUManuf
			location = New Global.System.Drawing.Point(2, 2)
			txtPUManuf.Location = location
			Me.txtPUManuf.Name = "txtPUManuf"
			Me.txtPUManuf.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtPUManuf2 As Global.System.Windows.Forms.Control = Me.txtPUManuf
			size = New Global.System.Drawing.Size(334, 24)
			txtPUManuf2.Size = size
			Me.txtPUManuf.TabIndex = 3
			Me.txtPUManuf.Text = "(Unknown)"
			Me.Label.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.Label.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Label.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label
			location = New Global.System.Drawing.Point(8, 9)
			label.Location = location
			Me.Label.Name = "Label"
			Me.Label.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label
			size = New Global.System.Drawing.Size(384, 50)
			label2.Size = size
			Me.Label.TabIndex = 1
			Me.Label.Text = "No pumping unit manufacturer was entered for this pumping unit. Please enter the manufacturer name below."
			Me.Image.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Image.Image = CType(componentResourceManager.GetObject("Image.Image"), Global.System.Drawing.Image)
			Me.Image.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim image As Global.System.Windows.Forms.Control = Me.Image
			location = New Global.System.Drawing.Point(8, 41)
			image.Location = location
			Me.Image.Name = "Image"
			Dim image2 As Global.System.Windows.Forms.Control = Me.Image
			size = New Global.System.Drawing.Size(37, 39)
			image2.Size = size
			Me.Image.TabIndex = 6
			Me.Image.TabStop = False
			Me.AcceptButton = Me.cmdOK
			size = New Global.System.Drawing.Size(7, 16)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(578, 130)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me._SSPanel_0)
			Me.Controls.Add(Me.Image)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(259, 328)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgPUManuf"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Pumping Unit Manufacturer"
			Me._SSPanel_0.ResumeLayout(False)
			Me._SSPanel_1.ResumeLayout(False)
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
