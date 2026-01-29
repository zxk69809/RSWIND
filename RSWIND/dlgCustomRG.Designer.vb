Namespace RSWINV3
	Friend Partial Class dlgCustomRG
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
			Me.cmdHelp = New Global.System.Windows.Forms.Button()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me._Label_1 = New Global.System.Windows.Forms.Label()
			Me.chkSinkerBar = New Global.System.Windows.Forms.CheckBox()
			Me._Label_3 = New Global.System.Windows.Forms.Label()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me._Label_2 = New Global.System.Windows.Forms.Label()
			Me.txtRodGrade = New Global.System.Windows.Forms.TextBox()
			Me.txtTensileStrength = New Global.System.Windows.Forms.TextBox()
			Me.cboStressMethod = New Global.System.Windows.Forms.ComboBox()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me._SSPanel_0.SuspendLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.cmdHelp.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdHelp.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdHelp.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdHelp.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdHelp.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdHelp As Global.System.Windows.Forms.Control = Me.cmdHelp
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(624, 68)
			cmdHelp.Location = location
			Me.cmdHelp.Name = "cmdHelp"
			Me.cmdHelp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdHelp, False)
			Dim cmdHelp2 As Global.System.Windows.Forms.Control = Me.cmdHelp
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(79, 23)
			cmdHelp2.Size = size
			Me.cmdHelp.TabIndex = 12
			Me.cmdHelp.Text = "Help"
			Me.cmdHelp.UseVisualStyleBackColor = False
			Me.cmdHelp.Visible = False
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			location = New Global.System.Drawing.Point(624, 33)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdCancel, False)
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(80, 23)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 3
			Me.cmdCancel.Text = "Cancel"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(624, 6)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdOK, False)
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(80, 23)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 2
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._SSPanel_0.Controls.Add(Me._Label_1)
			Me._SSPanel_0.Controls.Add(Me.chkSinkerBar)
			Me._SSPanel_0.Controls.Add(Me._Label_3)
			Me._SSPanel_0.Controls.Add(Me._Label_0)
			Me._SSPanel_0.Controls.Add(Me._Label_2)
			Me._SSPanel_0.Controls.Add(Me.txtRodGrade)
			Me._SSPanel_0.Controls.Add(Me.txtTensileStrength)
			Me._SSPanel_0.Controls.Add(Me.cboStressMethod)
			Me._SSPanel_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._SSPanel_0.ForeColor = Global.System.Drawing.Color.Black
			Me.SSPanel.SetIndex(Me._SSPanel_0, 0S)
			Dim sspanel_ As Global.System.Windows.Forms.Control = Me._SSPanel_0
			location = New Global.System.Drawing.Point(5, 8)
			sspanel_.Location = location
			Me._SSPanel_0.Name = "_SSPanel_0"
			Me._SSPanel_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._SSPanel_0, False)
			Dim sspanel_2 As Global.System.Windows.Forms.Control = Me._SSPanel_0
			size = New Global.System.Drawing.Size(603, 136)
			sspanel_2.Size = size
			Me._SSPanel_0.TabIndex = 4
			Me._SSPanel_0.TabStop = True
			Me._Label_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_1.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me._Label_1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_1, 1S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_1
			location = New Global.System.Drawing.Point(8, 64)
			label_.Location = location
			Me._Label_1.Name = "_Label_1"
			Me._Label_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_1, False)
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_1
			size = New Global.System.Drawing.Size(295, 20)
			label_2.Size = size
			Me._Label_1.TabIndex = 7
			Me._Label_1.Tag = "Min. Tensile strength (^):"
			Me._Label_1.Text = "Min. Tensile strength (psi):"
			Me._Label_1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkSinkerBar.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.chkSinkerBar.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkSinkerBar As Global.System.Windows.Forms.Control = Me.chkSinkerBar
			location = New Global.System.Drawing.Point(16, 112)
			chkSinkerBar.Location = location
			Me.chkSinkerBar.Name = "chkSinkerBar"
			Me.HelpProvider1.SetShowHelp(Me.chkSinkerBar, False)
			Dim chkSinkerBar2 As Global.System.Windows.Forms.Control = Me.chkSinkerBar
			size = New Global.System.Drawing.Size(504, 20)
			chkSinkerBar2.Size = size
			Me.chkSinkerBar.TabIndex = 15
			Me.chkSinkerBar.Text = "Sinker bar"
			Me._Label_3.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_3.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me._Label_3.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_3, 3S)
			Dim label_3 As Global.System.Windows.Forms.Control = Me._Label_3
			location = New Global.System.Drawing.Point(9, 91)
			label_3.Location = location
			Me._Label_3.Name = "_Label_3"
			Me._Label_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_3, False)
			Dim label_4 As Global.System.Windows.Forms.Control = Me._Label_3
			size = New Global.System.Drawing.Size(295, 20)
			label_4.Size = size
			Me._Label_3.TabIndex = 11
			Me._Label_3.Tag = "Tensile strength (^):"
			Me._Label_3.Text = "Stress analysis method:"
			Me._Label_3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_0, 0S)
			Dim label_5 As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(9, 40)
			label_5.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_0, False)
			Dim label_6 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(295, 23)
			label_6.Size = size
			Me._Label_0.TabIndex = 6
			Me._Label_0.Text = "Rod grade or manufacturer name:"
			Me._Label_0.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me._Label_2.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_2.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me._Label_2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_2, 2S)
			Dim label_7 As Global.System.Windows.Forms.Control = Me._Label_2
			location = New Global.System.Drawing.Point(8, 9)
			label_7.Location = location
			Me._Label_2.Name = "_Label_2"
			Me._Label_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_2, False)
			Dim label_8 As Global.System.Windows.Forms.Control = Me._Label_2
			size = New Global.System.Drawing.Size(576, 20)
			label_8.Size = size
			Me._Label_2.TabIndex = 5
			Me._Label_2.Text = "Enter the information for this custom rod grade:"
			Me.txtRodGrade.AcceptsReturn = True
			Me.txtRodGrade.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtRodGrade.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtRodGrade.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.txtRodGrade.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtRodGrade, "Custom Rod Grade: Rod Grade or Manufacturer Name")
			Me.HelpProvider1.SetHelpNavigator(Me.txtRodGrade, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtRodGrade As Global.System.Windows.Forms.Control = Me.txtRodGrade
			location = New Global.System.Drawing.Point(312, 40)
			txtRodGrade.Location = location
			Me.txtRodGrade.MaxLength = 40
			Me.txtRodGrade.Name = "txtRodGrade"
			Me.txtRodGrade.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtRodGrade, True)
			Dim txtRodGrade2 As Global.System.Windows.Forms.Control = Me.txtRodGrade
			size = New Global.System.Drawing.Size(104, 23)
			txtRodGrade2.Size = size
			Me.txtRodGrade.TabIndex = 0
			Me.txtTensileStrength.AcceptsReturn = True
			Me.txtTensileStrength.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtTensileStrength.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtTensileStrength.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.txtTensileStrength.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtTensileStrength, "Custom Rod Grade: Minimum Tensile Strength")
			Me.HelpProvider1.SetHelpNavigator(Me.txtTensileStrength, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtTensileStrength As Global.System.Windows.Forms.Control = Me.txtTensileStrength
			location = New Global.System.Drawing.Point(312, 64)
			txtTensileStrength.Location = location
			Me.txtTensileStrength.MaxLength = 40
			Me.txtTensileStrength.Name = "txtTensileStrength"
			Me.txtTensileStrength.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtTensileStrength, True)
			Dim txtTensileStrength2 As Global.System.Windows.Forms.Control = Me.txtTensileStrength
			size = New Global.System.Drawing.Size(104, 23)
			txtTensileStrength2.Size = size
			Me.txtTensileStrength.TabIndex = 1
			Me.txtTensileStrength.Tag = "pee"
			Me.cboStressMethod.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboStressMethod.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboStressMethod.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboStressMethod.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.cboStressMethod.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboStressMethod, "Custom Rod Grade: Stress Analysis Method")
			Me.HelpProvider1.SetHelpNavigator(Me.cboStressMethod, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboStressMethod.ItemHeight = 16
			Dim cboStressMethod As Global.System.Windows.Forms.Control = Me.cboStressMethod
			location = New Global.System.Drawing.Point(312, 88)
			cboStressMethod.Location = location
			Me.cboStressMethod.Name = "cboStressMethod"
			Me.cboStressMethod.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboStressMethod, True)
			Dim cboStressMethod2 As Global.System.Windows.Forms.Control = Me.cboStressMethod
			size = New Global.System.Drawing.Size(272, 24)
			cboStressMethod2.Size = size
			Me.cboStressMethod.TabIndex = 13
			Me.AcceptButton = Me.cmdOK
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			Me.CancelButton = Me.cmdCancel
			size = New Global.System.Drawing.Size(718, 155)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.cmdHelp)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me._SSPanel_0)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.KeyPreview = True
			location = New Global.System.Drawing.Point(64, 202)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgCustomRG"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Custom Rod Grade Information"
			Me._SSPanel_0.ResumeLayout(False)
			Me._SSPanel_0.PerformLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
