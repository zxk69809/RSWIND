Namespace RSWINV3
	Friend Partial Class Clock
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
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me.txtCode = New Global.System.Windows.Forms.TextBox()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me.tmrBatch = New Global.System.Windows.Forms.Timer(Me.components)
			Me.tmrCode = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.lblCancel = New Global.System.Windows.Forms.Label()
			Me._SSPanel_0.SuspendLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(138, 48)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(81, 24)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 3
			Me.cmdCancel.Text = "No"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(55, 48)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(81, 24)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 2
			Me.cmdOK.Text = "Yes"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._SSPanel_0.Controls.Add(Me.txtCode)
			Me._SSPanel_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._SSPanel_0.ForeColor = Global.System.Drawing.Color.Black
			Me.SSPanel.SetIndex(Me._SSPanel_0, 0S)
			Dim sspanel_ As Global.System.Windows.Forms.Control = Me._SSPanel_0
			location = New Global.System.Drawing.Point(116, 8)
			sspanel_.Location = location
			Me._SSPanel_0.Name = "_SSPanel_0"
			Me._SSPanel_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim sspanel_2 As Global.System.Windows.Forms.Control = Me._SSPanel_0
			size = New Global.System.Drawing.Size(104, 23)
			sspanel_2.Size = size
			Me._SSPanel_0.TabIndex = 4
			Me._SSPanel_0.TabStop = True
			Me._SSPanel_0.Visible = False
			Me.txtCode.AcceptsReturn = True
			Me.txtCode.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtCode.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtCode.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtCode.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtCode.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.txtCode.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtCode As Global.System.Windows.Forms.Control = Me.txtCode
			location = New Global.System.Drawing.Point(2, 2)
			txtCode.Location = location
			Me.txtCode.MaxLength = 40
			Me.txtCode.Name = "txtCode"
			Me.txtCode.PasswordChar = "*"c
			Me.txtCode.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtCode2 As Global.System.Windows.Forms.Control = Me.txtCode
			size = New Global.System.Drawing.Size(100, 20)
			txtCode2.Size = size
			Me.txtCode.TabIndex = 1
			Me._Label_0.AutoSize = True
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_0, 0S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(9, 13)
			label_.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(111, 14)
			label_2.Size = size
			Me._Label_0.TabIndex = 0
			Me._Label_0.Text = "Enter activation code:"
			Me._Label_0.Visible = False
			Me.tmrBatch.Interval = 60000
			Me.tmrCode.Interval = 1000
			Dim lblCancel As Global.System.Windows.Forms.Control = Me.lblCancel
			location = New Global.System.Drawing.Point(8, 8)
			lblCancel.Location = location
			Me.lblCancel.Name = "lblCancel"
			Dim lblCancel2 As Global.System.Windows.Forms.Control = Me.lblCancel
			size = New Global.System.Drawing.Size(240, 24)
			lblCancel2.Size = size
			Me.lblCancel.TabIndex = 5
			Me.lblCancel.Text = "Cancel Automatic Batch?"
			Me.lblCancel.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.AcceptButton = Me.cmdOK
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			Me.CancelButton = Me.cmdCancel
			size = New Global.System.Drawing.Size(277, 93)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.lblCancel)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me._SSPanel_0)
			Me.Controls.Add(Me._Label_0)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(658, 100)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Clock"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "RODSTAR-D (Automatic Batch Mode)"
			Me._SSPanel_0.ResumeLayout(False)
			Me._SSPanel_0.PerformLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
