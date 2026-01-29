Namespace RSWINV3
	Public Partial Class frmDemoMode
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.lblDemoText = New Global.System.Windows.Forms.Label()
			Me.btnOK = New Global.System.Windows.Forms.Button()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.cboDemoFile = New Global.System.Windows.Forms.ComboBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.lblSentinelText = New Global.System.Windows.Forms.Label()
			Me.btnRetry = New Global.System.Windows.Forms.Button()
			Me.SuspendLayout()
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(10, 148)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(268, 27)
			label2.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Demo Mode Option"
			Dim lblDemoText As Global.System.Windows.Forms.Control = Me.lblDemoText
			location = New Global.System.Drawing.Point(48, 175)
			lblDemoText.Location = location
			Me.lblDemoText.Name = "lblDemoText"
			Dim lblDemoText2 As Global.System.Windows.Forms.Control = Me.lblDemoText
			size = New Global.System.Drawing.Size(374, 65)
			lblDemoText2.Size = size
			Me.lblDemoText.TabIndex = 1
			Me.lblDemoText.Text = "Demo Mode text goes here..."
			Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
			location = New Global.System.Drawing.Point(250, 286)
			btnOK.Location = location
			Me.btnOK.Name = "btnOK"
			Dim btnOK2 As Global.System.Windows.Forms.Control = Me.btnOK
			size = New Global.System.Drawing.Size(76, 28)
			btnOK2.Size = size
			Me.btnOK.TabIndex = 1
			Me.btnOK.Text = "OK"
			Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
			location = New Global.System.Drawing.Point(346, 286)
			btnCancel.Location = location
			Me.btnCancel.Name = "btnCancel"
			Dim btnCancel2 As Global.System.Windows.Forms.Control = Me.btnCancel
			size = New Global.System.Drawing.Size(76, 28)
			btnCancel2.Size = size
			Me.btnCancel.TabIndex = 2
			Me.btnCancel.Text = "Cancel"
			Dim cboDemoFile As Global.System.Windows.Forms.Control = Me.cboDemoFile
			location = New Global.System.Drawing.Point(58, 249)
			cboDemoFile.Location = location
			Me.cboDemoFile.Name = "cboDemoFile"
			Dim cboDemoFile2 As Global.System.Windows.Forms.Control = Me.cboDemoFile
			size = New Global.System.Drawing.Size(307, 24)
			cboDemoFile2.Size = size
			Me.cboDemoFile.TabIndex = 3
			Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(10, 9)
			label3.Location = location
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(268, 28)
			label4.Size = size
			Me.Label2.TabIndex = 4
			Me.Label2.Text = "Sentinel Not Found"
			Dim lblSentinelText As Global.System.Windows.Forms.Control = Me.lblSentinelText
			location = New Global.System.Drawing.Point(48, 37)
			lblSentinelText.Location = location
			Me.lblSentinelText.Name = "lblSentinelText"
			Dim lblSentinelText2 As Global.System.Windows.Forms.Control = Me.lblSentinelText
			size = New Global.System.Drawing.Size(374, 101)
			lblSentinelText2.Size = size
			Me.lblSentinelText.TabIndex = 5
			Me.lblSentinelText.Text = "Sentinel not found message..."
			Dim btnRetry As Global.System.Windows.Forms.Control = Me.btnRetry
			location = New Global.System.Drawing.Point(29, 286)
			btnRetry.Location = location
			Me.btnRetry.Name = "btnRetry"
			Dim btnRetry2 As Global.System.Windows.Forms.Control = Me.btnRetry
			size = New Global.System.Drawing.Size(77, 28)
			btnRetry2.Size = size
			Me.btnRetry.TabIndex = 6
			Me.btnRetry.Text = "&Retry"
			Me.btnRetry.Visible = False
			size = New Global.System.Drawing.Size(6, 15)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(439, 334)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.btnRetry)
			Me.Controls.Add(Me.lblSentinelText)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.cboDemoFile)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnOK)
			Me.Controls.Add(Me.lblDemoText)
			Me.Controls.Add(Me.Label1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "frmDemoMode"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
