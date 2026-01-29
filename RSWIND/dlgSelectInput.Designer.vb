Namespace RSWINV3
	Public Partial Class dlgSelectInput
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgSelectInput))
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.Label = New Global.System.Windows.Forms.Label()
			Me.lstFields = New Global.System.Windows.Forms.ListBox()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.Panel1.Controls.Add(Me.cmdCancel)
			Me.Panel1.Controls.Add(Me.cmdOK)
			Me.Panel1.Controls.Add(Me.Label)
			Me.Panel1.Controls.Add(Me.lstFields)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(7, 7)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(468, 700)
			panel2.Size = size
			Me.Panel1.TabIndex = 0
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			location = New Global.System.Drawing.Point(360, 74)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(95, 26)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 6
			Me.cmdCancel.Text = "Cancel"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(360, 37)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(95, 26)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 5
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me.Label.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me.Label.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Label.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label
			location = New Global.System.Drawing.Point(10, 0)
			label.Location = location
			Me.Label.Name = "Label"
			Me.Label.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label
			size = New Global.System.Drawing.Size(537, 22)
			label2.Size = size
			Me.Label.TabIndex = 7
			Me.Label.Text = "Select the input field you want to change:"
			Me.lstFields.ItemHeight = 16
			Dim lstFields As Global.System.Windows.Forms.Control = Me.lstFields
			location = New Global.System.Drawing.Point(10, 25)
			lstFields.Location = location
			Me.lstFields.Name = "lstFields"
			Dim lstFields2 As Global.System.Windows.Forms.Control = Me.lstFields
			size = New Global.System.Drawing.Size(345, 660)
			lstFields2.Size = size
			Me.lstFields.TabIndex = 8
			size = New Global.System.Drawing.Size(6, 15)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(483, 723)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.Panel1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgSelectInput"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "SelInput"
			Me.TopMost = True
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
