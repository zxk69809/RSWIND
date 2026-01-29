Namespace RSWINV3
	Public Partial Class SystemOfUnits
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.grpSystemOfUnits = New Global.System.Windows.Forms.GroupBox()
			Me.rbtMetric = New Global.System.Windows.Forms.RadioButton()
			Me.rbtCanadian = New Global.System.Windows.Forms.RadioButton()
			Me.rbtEnglish = New Global.System.Windows.Forms.RadioButton()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.btnOK = New Global.System.Windows.Forms.Button()
			Me.grpSystemOfUnits.SuspendLayout()
			Me.SuspendLayout()
			Me.grpSystemOfUnits.Controls.Add(Me.rbtMetric)
			Me.grpSystemOfUnits.Controls.Add(Me.rbtCanadian)
			Me.grpSystemOfUnits.Controls.Add(Me.rbtEnglish)
			Dim grpSystemOfUnits As Global.System.Windows.Forms.Control = Me.grpSystemOfUnits
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(6, 0)
			grpSystemOfUnits.Location = location
			Me.grpSystemOfUnits.Name = "grpSystemOfUnits"
			Dim grpSystemOfUnits2 As Global.System.Windows.Forms.Control = Me.grpSystemOfUnits
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(583, 40)
			grpSystemOfUnits2.Size = size
			Me.grpSystemOfUnits.TabIndex = 1
			Me.grpSystemOfUnits.TabStop = False
			Me.rbtMetric.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtMetric As Global.System.Windows.Forms.Control = Me.rbtMetric
			location = New Global.System.Drawing.Point(376, 16)
			rbtMetric.Location = location
			Me.rbtMetric.Name = "rbtMetric"
			Dim rbtMetric2 As Global.System.Windows.Forms.Control = Me.rbtMetric
			size = New Global.System.Drawing.Size(200, 16)
			rbtMetric2.Size = size
			Me.rbtMetric.TabIndex = 2
			Me.rbtMetric.Text = "Metric/SI (meters, newtons, etc.)"
			Me.rbtCanadian.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtCanadian As Global.System.Windows.Forms.Control = Me.rbtCanadian
			location = New Global.System.Drawing.Point(184, 16)
			rbtCanadian.Location = location
			Me.rbtCanadian.Name = "rbtCanadian"
			Dim rbtCanadian2 As Global.System.Windows.Forms.Control = Me.rbtCanadian
			size = New Global.System.Drawing.Size(176, 16)
			rbtCanadian2.Size = size
			Me.rbtCanadian.TabIndex = 1
			Me.rbtCanadian.Text = "Canadian (meters, lbs, etc.)"
			Me.rbtEnglish.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtEnglish As Global.System.Windows.Forms.Control = Me.rbtEnglish
			location = New Global.System.Drawing.Point(16, 16)
			rbtEnglish.Location = location
			Me.rbtEnglish.Name = "rbtEnglish"
			Dim rbtEnglish2 As Global.System.Windows.Forms.Control = Me.rbtEnglish
			size = New Global.System.Drawing.Size(152, 16)
			rbtEnglish2.Size = size
			Me.rbtEnglish.TabIndex = 0
			Me.rbtEnglish.Text = "English (feet, lbs, etc.)"
			Me.btnCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
			location = New Global.System.Drawing.Point(680, 11)
			btnCancel.Location = location
			Me.btnCancel.Name = "btnCancel"
			Dim btnCancel2 As Global.System.Windows.Forms.Control = Me.btnCancel
			size = New Global.System.Drawing.Size(72, 24)
			btnCancel2.Size = size
			Me.btnCancel.TabIndex = 10
			Me.btnCancel.Text = "Cancel"
			Me.btnOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
			location = New Global.System.Drawing.Point(600, 11)
			btnOK.Location = location
			Me.btnOK.Name = "btnOK"
			Dim btnOK2 As Global.System.Windows.Forms.Control = Me.btnOK
			size = New Global.System.Drawing.Size(72, 24)
			btnOK2.Size = size
			Me.btnOK.TabIndex = 9
			Me.btnOK.Text = "OK"
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(765, 46)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnOK)
			Me.Controls.Add(Me.grpSystemOfUnits)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "SystemOfUnits"
			Me.ShowInTaskbar = False
			Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
			Me.Text = "System of units"
			Me.TopMost = True
			Me.grpSystemOfUnits.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
