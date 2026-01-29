Namespace RSWINV3
	Friend Partial Class dlgCBData
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgCBData))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.Panel3D1 = New Global.System.Windows.Forms.Panel()
			Me._optCBData_1 = New Global.System.Windows.Forms.RadioButton()
			Me._optCBData_0 = New Global.System.Windows.Forms.RadioButton()
			Me.Label = New Global.System.Windows.Forms.Label()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.txtCBM = New Global.System.Windows.Forms.TextBox()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.Image = New Global.System.Windows.Forms.PictureBox()
			Me.optCBData = New Global.Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
			Me.Panel3D1.SuspendLayout()
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.optCBData, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.Panel3D1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Panel3D1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel3D1.Controls.Add(Me._optCBData_1)
			Me.Panel3D1.Controls.Add(Me._optCBData_0)
			Me.Panel3D1.Controls.Add(Me.Label)
			Me.Panel3D1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Panel3D1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.Panel3D1.ForeColor = Global.System.Drawing.Color.Black
			Dim panel3D As Global.System.Windows.Forms.Control = Me.Panel3D1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(48, 10)
			panel3D.Location = location
			Me.Panel3D1.Name = "Panel3D1"
			Me.Panel3D1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim panel3D2 As Global.System.Windows.Forms.Control = Me.Panel3D1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(400, 137)
			panel3D2.Size = size
			Me.Panel3D1.TabIndex = 4
			Me.Panel3D1.TabStop = True
			Me._optCBData_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCBData_ As Global.System.Windows.Forms.Control = Me._optCBData_1
			location = New Global.System.Drawing.Point(16, 112)
			optCBData_.Location = location
			Me._optCBData_1.Name = "_optCBData_1"
			Dim optCBData_2 As Global.System.Windows.Forms.Control = Me._optCBData_1
			size = New Global.System.Drawing.Size(377, 16)
			optCBData_2.Size = size
			Me._optCBData_1.TabIndex = 7
			Me._optCBData_1.Text = "Read XBAL file"
			Me._optCBData_0.Checked = True
			Me._optCBData_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCBData_3 As Global.System.Windows.Forms.Control = Me._optCBData_0
			location = New Global.System.Drawing.Point(16, 88)
			optCBData_3.Location = location
			Me._optCBData_0.Name = "_optCBData_0"
			Dim optCBData_4 As Global.System.Windows.Forms.Control = Me._optCBData_0
			size = New Global.System.Drawing.Size(377, 16)
			optCBData_4.Size = size
			Me._optCBData_0.TabIndex = 6
			Me._optCBData_0.TabStop = True
			Me._optCBData_0.Text = "Use CB moment exported by XBAL"
			Me.Label.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.Label.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Label.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label
			location = New Global.System.Drawing.Point(7, 7)
			label.Location = location
			Me.Label.Name = "Label"
			Me.Label.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label
			size = New Global.System.Drawing.Size(385, 81)
			label2.Size = size
			Me.Label.TabIndex = 5
			Me.Label.Text = "XBAL has placed an existing maximum counterbalance moment of | on the Clipboard.  Do you want to use this value, or read an existing maximum counterbalance moment from a XBAL data file?"
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			location = New Global.System.Drawing.Point(464, 35)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(72, 22)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 3
			Me.cmdCancel.Text = "Cancel"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.txtCBM.AcceptsReturn = True
			Me.txtCBM.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtCBM.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtCBM.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtCBM.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtCBM.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtCBM As Global.System.Windows.Forms.Control = Me.txtCBM
			location = New Global.System.Drawing.Point(464, 70)
			txtCBM.Location = location
			Me.txtCBM.Name = "txtCBM"
			Me.txtCBM.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtCBM2 As Global.System.Windows.Forms.Control = Me.txtCBM
			size = New Global.System.Drawing.Size(56, 13)
			txtCBM2.Size = size
			Me.txtCBM.TabIndex = 2
			Me.txtCBM.Visible = False
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(464, 9)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(72, 22)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 0
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me.Image.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Image.Image = CType(componentResourceManager.GetObject("Image.Image"), Global.System.Drawing.Image)
			Me.Image.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim image As Global.System.Windows.Forms.Control = Me.Image
			location = New Global.System.Drawing.Point(9, 60)
			image.Location = location
			Me.Image.Name = "Image"
			Dim image2 As Global.System.Windows.Forms.Control = Me.Image
			size = New Global.System.Drawing.Size(32, 32)
			image2.Size = size
			Me.Image.TabIndex = 8
			Me.Image.TabStop = False
			Me.AcceptButton = Me.cmdOK
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			Me.CancelButton = Me.cmdCancel
			size = New Global.System.Drawing.Size(549, 173)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.Panel3D1)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.txtCBM)
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me.Image)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(185, 276)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgCBData"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "XBAL Information"
			Me.Panel3D1.ResumeLayout(False)
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.optCBData, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
