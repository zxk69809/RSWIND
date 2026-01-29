Namespace RSWINV3
	Friend Partial Class dlgSelectDir
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
			Me.txtPath = New Global.System.Windows.Forms.TextBox()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.Drive1 = New Global.Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
			Me.Dir1 = New Global.Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
			Me.lblCurrentPath = New Global.System.Windows.Forms.Label()
			Me.Label = New Global.System.Windows.Forms.Label()
			Me.lblCaption = New Global.System.Windows.Forms.Label()
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.txtPath.AcceptsReturn = True
			Me.txtPath.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPath.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtPath.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPath.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtPath.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtPath As Global.System.Windows.Forms.Control = Me.txtPath
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(256, 66)
			txtPath.Location = location
			Me.txtPath.Name = "txtPath"
			Me.txtPath.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtPath2 As Global.System.Windows.Forms.Control = Me.txtPath
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(79, 13)
			txtPath2.Size = size
			Me.txtPath.TabIndex = 4
			Me.txtPath.Visible = False
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(256, 9)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(79, 23)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 2
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			location = New Global.System.Drawing.Point(256, 39)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(79, 23)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 3
			Me.cmdCancel.Text = "Cancel"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.Drive1.BackColor = Global.System.Drawing.SystemColors.Window
			Me.Drive1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Drive1.Font = New Global.System.Drawing.Font("Arial", 9F)
			Me.Drive1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Drive1.FormattingEnabled = True
			Dim drive As Global.System.Windows.Forms.Control = Me.Drive1
			location = New Global.System.Drawing.Point(8, 192)
			drive.Location = location
			Me.Drive1.Name = "Drive1"
			Dim drive2 As Global.System.Windows.Forms.Control = Me.Drive1
			size = New Global.System.Drawing.Size(232, 22)
			drive2.Size = size
			Me.Drive1.TabIndex = 1
			Me.Dir1.BackColor = Global.System.Drawing.SystemColors.Window
			Me.Dir1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Dir1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Dir1.Font = New Global.System.Drawing.Font("Arial", 9F)
			Me.Dir1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Dir1.FormattingEnabled = True
			Me.Dir1.IntegralHeight = False
			Dim dir As Global.System.Windows.Forms.Control = Me.Dir1
			location = New Global.System.Drawing.Point(8, 40)
			dir.Location = location
			Me.Dir1.Name = "Dir1"
			Dim dir2 As Global.System.Windows.Forms.Control = Me.Dir1
			size = New Global.System.Drawing.Size(232, 144)
			dir2.Size = size
			Me.Dir1.TabIndex = 5
			Me.lblCurrentPath.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblCurrentPath.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblCurrentPath.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblCurrentPath.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lblCurrentPath.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCurrentPath As Global.System.Windows.Forms.Control = Me.lblCurrentPath
			location = New Global.System.Drawing.Point(97, 232)
			lblCurrentPath.Location = location
			Me.lblCurrentPath.Name = "lblCurrentPath"
			Me.lblCurrentPath.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblCurrentPath2 As Global.System.Windows.Forms.Control = Me.lblCurrentPath
			size = New Global.System.Drawing.Size(241, 13)
			lblCurrentPath2.Size = size
			Me.lblCurrentPath.TabIndex = 8
			Me.lblCurrentPath.Text = "lblCurrentPath"
			Me.Label.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.Label.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Label.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label
			location = New Global.System.Drawing.Point(4, 232)
			label.Location = location
			Me.Label.Name = "Label"
			Me.Label.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label
			size = New Global.System.Drawing.Size(93, 13)
			label2.Size = size
			Me.Label.TabIndex = 7
			Me.Label.Text = "Selected directory:"
			Me.lblCaption.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblCaption.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblCaption.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblCaption.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lblCaption.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCaption As Global.System.Windows.Forms.Control = Me.lblCaption
			location = New Global.System.Drawing.Point(6, 8)
			lblCaption.Location = location
			Me.lblCaption.Name = "lblCaption"
			Me.lblCaption.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblCaption2 As Global.System.Windows.Forms.Control = Me.lblCaption
			size = New Global.System.Drawing.Size(241, 27)
			lblCaption2.Size = size
			Me.lblCaption.TabIndex = 6
			Me.lblCaption.Text = "Select the folder which contains the RODSTAR files to process:"
			Me.AcceptButton = Me.cmdOK
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			Me.CancelButton = Me.cmdCancel
			size = New Global.System.Drawing.Size(347, 233)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.txtPath)
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.Dir1)
			Me.Controls.Add(Me.lblCurrentPath)
			Me.Controls.Add(Me.Label)
			Me.Controls.Add(Me.lblCaption)
			Me.Controls.Add(Me.Drive1)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(135, 179)
			Me.Location = location
			Me.Name = "dlgSelectDir"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Select Folder"
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
