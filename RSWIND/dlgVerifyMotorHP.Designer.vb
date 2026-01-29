Namespace RSWINV3
	Friend Partial Class dlgVerifyMotorHP
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
			Me.txtMessageNumber = New Global.System.Windows.Forms.TextBox()
			Me.cmdChangeSPM = New Global.System.Windows.Forms.Button()
			Me.picQuestion = New Global.System.Windows.Forms.PictureBox()
			Me.cmdMinMotorHP = New Global.System.Windows.Forms.Button()
			Me.cmdContinue = New Global.System.Windows.Forms.Button()
			Me.Label = New Global.System.Windows.Forms.Label()
			CType(Me.picQuestion, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.txtMessageNumber.AcceptsReturn = True
			Me.txtMessageNumber.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMessageNumber.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtMessageNumber.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMessageNumber.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtMessageNumber.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtMessageNumber As Global.System.Windows.Forms.Control = Me.txtMessageNumber
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(352, 6)
			txtMessageNumber.Location = location
			Me.txtMessageNumber.MaxLength = 0
			Me.txtMessageNumber.Name = "txtMessageNumber"
			Me.txtMessageNumber.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtMessageNumber2 As Global.System.Windows.Forms.Control = Me.txtMessageNumber
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(81, 20)
			txtMessageNumber2.Size = size
			Me.txtMessageNumber.TabIndex = 5
			Me.txtMessageNumber.Text = "txtMessageNumber"
			Me.txtMessageNumber.Visible = False
			Me.cmdChangeSPM.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdChangeSPM.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdChangeSPM.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdChangeSPM.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdChangeSPM.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdChangeSPM As Global.System.Windows.Forms.Control = Me.cmdChangeSPM
			location = New Global.System.Drawing.Point(320, 145)
			cmdChangeSPM.Location = location
			Me.cmdChangeSPM.Name = "cmdChangeSPM"
			Me.cmdChangeSPM.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdChangeSPM2 As Global.System.Windows.Forms.Control = Me.cmdChangeSPM
			size = New Global.System.Drawing.Size(128, 22)
			cmdChangeSPM2.Size = size
			Me.cmdChangeSPM.TabIndex = 4
			Me.cmdChangeSPM.Text = "C&hange size"
			Me.cmdChangeSPM.UseVisualStyleBackColor = False
			Me.picQuestion.BackColor = Global.System.Drawing.SystemColors.Window
			Me.picQuestion.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.picQuestion.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.picQuestion.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.picQuestion.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim picQuestion As Global.System.Windows.Forms.Control = Me.picQuestion
			location = New Global.System.Drawing.Point(9, 18)
			picQuestion.Location = location
			Me.picQuestion.Name = "picQuestion"
			Me.picQuestion.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim picQuestion2 As Global.System.Windows.Forms.Control = Me.picQuestion
			size = New Global.System.Drawing.Size(32, 32)
			picQuestion2.Size = size
			Me.picQuestion.TabIndex = 3
			Me.picQuestion.TabStop = False
			Me.picQuestion.Visible = False
			Me.cmdMinMotorHP.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdMinMotorHP.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdMinMotorHP.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdMinMotorHP.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdMinMotorHP.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdMinMotorHP As Global.System.Windows.Forms.Control = Me.cmdMinMotorHP
			location = New Global.System.Drawing.Point(184, 145)
			cmdMinMotorHP.Location = location
			Me.cmdMinMotorHP.Name = "cmdMinMotorHP"
			Me.cmdMinMotorHP.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdMinMotorHP2 As Global.System.Windows.Forms.Control = Me.cmdMinMotorHP
			size = New Global.System.Drawing.Size(128, 22)
			cmdMinMotorHP2.Size = size
			Me.cmdMinMotorHP.TabIndex = 1
			Me.cmdMinMotorHP.Text = "&Use %{0} hp"
			Me.cmdMinMotorHP.UseVisualStyleBackColor = False
			Me.cmdContinue.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdContinue.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdContinue.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdContinue.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdContinue.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdContinue As Global.System.Windows.Forms.Control = Me.cmdContinue
			location = New Global.System.Drawing.Point(50, 145)
			cmdContinue.Location = location
			Me.cmdContinue.Name = "cmdContinue"
			Me.cmdContinue.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdContinue2 As Global.System.Windows.Forms.Control = Me.cmdContinue
			size = New Global.System.Drawing.Size(128, 22)
			cmdContinue2.Size = size
			Me.cmdContinue.TabIndex = 0
			Me.cmdContinue.Text = "&Continue"
			Me.cmdContinue.UseVisualStyleBackColor = False
			Me.Label.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.Label.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Label.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label
			location = New Global.System.Drawing.Point(53, 5)
			label.Location = location
			Me.Label.Name = "Label"
			Me.Label.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label
			size = New Global.System.Drawing.Size(395, 130)
			label2.Size = size
			Me.Label.TabIndex = 2
			Me.Label.Text = "cMSG_HIGH_SPM_ROTA"
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(506, 192)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.txtMessageNumber)
			Me.Controls.Add(Me.cmdChangeSPM)
			Me.Controls.Add(Me.picQuestion)
			Me.Controls.Add(Me.cmdMinMotorHP)
			Me.Controls.Add(Me.cmdContinue)
			Me.Controls.Add(Me.Label)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(929, 29)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgVerifyMotorHP"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Verify Motor Size"
			CType(Me.picQuestion, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
