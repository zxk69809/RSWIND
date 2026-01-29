Namespace RSWINV3
	Friend Partial Class Version
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
			Me.VerStamp = New Global.System.Windows.Forms.PictureBox()
			Me.SuspendLayout()
			Me.VerStamp.BackColor = Global.System.Drawing.SystemColors.Window
			Me.VerStamp.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.VerStamp.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.VerStamp.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.VerStamp.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.VerStamp.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim verStamp As Global.System.Windows.Forms.Control = Me.VerStamp
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(52, 8)
			verStamp.Location = location
			Me.VerStamp.Name = "VerStamp"
			Me.VerStamp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim verStamp2 As Global.System.Windows.Forms.Control = Me.VerStamp
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(80, 32)
			verStamp2.Size = size
			Me.VerStamp.TabIndex = 0
			Me.VerStamp.TabStop = False
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			Me.BackColor = Global.System.Drawing.Color.FromArgb(192, 192, 192)
			size = New Global.System.Drawing.Size(126, 38)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.VerStamp)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			location = New Global.System.Drawing.Point(532, 184)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Version"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Retail"
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
