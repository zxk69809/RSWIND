Namespace RSWINV3
	Friend Partial Class dlgDeviationEntries
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
			Me.txtInteval = New Global.System.Windows.Forms.TextBox()
			Me.txtEntries = New Global.System.Windows.Forms.TextBox()
			Me.CancelButton_Renamed = New Global.System.Windows.Forms.Button()
			Me.OKButton = New Global.System.Windows.Forms.Button()
			Me.lblInterval = New Global.System.Windows.Forms.Label()
			Me.lblNumberOfEntries = New Global.System.Windows.Forms.Label()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.txtInteval.AcceptsReturn = True
			Me.txtInteval.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtInteval.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtInteval.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtInteval.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtInteval As Global.System.Windows.Forms.Control = Me.txtInteval
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(230, 295)
			txtInteval.Location = location
			Me.txtInteval.MaxLength = 0
			Me.txtInteval.Name = "txtInteval"
			Me.txtInteval.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtInteval2 As Global.System.Windows.Forms.Control = Me.txtInteval
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(88, 24)
			txtInteval2.Size = size
			Me.txtInteval.TabIndex = 5
			Me.txtInteval.Visible = False
			Me.txtEntries.AcceptsReturn = True
			Me.txtEntries.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtEntries.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtEntries.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtEntries.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtEntries As Global.System.Windows.Forms.Control = Me.txtEntries
			location = New Global.System.Drawing.Point(240, 30)
			txtEntries.Location = location
			Me.txtEntries.MaxLength = 0
			Me.txtEntries.Name = "txtEntries"
			Me.txtEntries.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtEntries2 As Global.System.Windows.Forms.Control = Me.txtEntries
			size = New Global.System.Drawing.Size(88, 23)
			txtEntries2.Size = size
			Me.txtEntries.TabIndex = 1
			Me.CancelButton_Renamed.BackColor = Global.System.Drawing.SystemColors.Control
			Me.CancelButton_Renamed.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.CancelButton_Renamed.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.CancelButton_Renamed.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.CancelButton_Renamed.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cancelButton_Renamed As Global.System.Windows.Forms.Control = Me.CancelButton_Renamed
			location = New Global.System.Drawing.Point(365, 49)
			cancelButton_Renamed.Location = location
			Me.CancelButton_Renamed.Name = "CancelButton_Renamed"
			Me.CancelButton_Renamed.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cancelButton_Renamed2 As Global.System.Windows.Forms.Control = Me.CancelButton_Renamed
			size = New Global.System.Drawing.Size(97, 31)
			cancelButton_Renamed2.Size = size
			Me.CancelButton_Renamed.TabIndex = 3
			Me.CancelButton_Renamed.Text = "Cancel"
			Me.CancelButton_Renamed.UseVisualStyleBackColor = False
			Me.OKButton.BackColor = Global.System.Drawing.SystemColors.Control
			Me.OKButton.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.OKButton.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.OKButton.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.OKButton.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim okbutton As Global.System.Windows.Forms.Control = Me.OKButton
			location = New Global.System.Drawing.Point(365, 10)
			okbutton.Location = location
			Me.OKButton.Name = "OKButton"
			Me.OKButton.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim okbutton2 As Global.System.Windows.Forms.Control = Me.OKButton
			size = New Global.System.Drawing.Size(97, 31)
			okbutton2.Size = size
			Me.OKButton.TabIndex = 2
			Me.OKButton.Text = "OK"
			Me.OKButton.UseVisualStyleBackColor = False
			Me.lblInterval.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblInterval.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblInterval.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblInterval.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblInterval.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblInterval As Global.System.Windows.Forms.Control = Me.lblInterval
			location = New Global.System.Drawing.Point(10, 295)
			lblInterval.Location = location
			Me.lblInterval.Name = "lblInterval"
			Me.lblInterval.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblInterval2 As Global.System.Windows.Forms.Control = Me.lblInterval
			size = New Global.System.Drawing.Size(202, 21)
			lblInterval2.Size = size
			Me.lblInterval.TabIndex = 4
			Me.lblInterval.Tag = "Default Interval (^) :"
			Me.lblInterval.Text = "Length of Intervals (ft)  :"
			Me.lblInterval.Visible = False
			Me.lblNumberOfEntries.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblNumberOfEntries.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblNumberOfEntries.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblNumberOfEntries.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblNumberOfEntries.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblNumberOfEntries As Global.System.Windows.Forms.Control = Me.lblNumberOfEntries
			location = New Global.System.Drawing.Point(10, 30)
			lblNumberOfEntries.Location = location
			Me.lblNumberOfEntries.Name = "lblNumberOfEntries"
			Me.lblNumberOfEntries.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblNumberOfEntries2 As Global.System.Windows.Forms.Control = Me.lblNumberOfEntries
			size = New Global.System.Drawing.Size(220, 20)
			lblNumberOfEntries2.Size = size
			Me.lblNumberOfEntries.TabIndex = 4
			Me.lblNumberOfEntries.Text = "Number of Entries : "
			Me.lblNumberOfEntries.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			size = New Global.System.Drawing.Size(6, 16)
			Me.AutoScaleBaseSize = size
			Me.BackColor = Global.System.Drawing.SystemColors.Control
			size = New Global.System.Drawing.Size(507, 106)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtInteval)
			Me.Controls.Add(Me.txtEntries)
			Me.Controls.Add(Me.CancelButton_Renamed)
			Me.Controls.Add(Me.OKButton)
			Me.Controls.Add(Me.lblInterval)
			Me.Controls.Add(Me.lblNumberOfEntries)
			Me.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(184, 250)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgDeviationEntries"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Please enter number of entries."
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
