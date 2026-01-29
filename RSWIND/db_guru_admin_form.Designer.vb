Namespace RSWINV3
	Public Partial Class db_guru_admin_form
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.ulgTemplates = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me.lblDBFile = New Global.System.Windows.Forms.Label()
			Me.GroupBox1.SuspendLayout()
			CType(Me.ulgTemplates, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Dim btnClose As Global.System.Windows.Forms.Control = Me.btnClose
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(550, 768)
			btnClose.Location = location
			Me.btnClose.Name = "btnClose"
			Dim btnClose2 As Global.System.Windows.Forms.Control = Me.btnClose
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(72, 24)
			btnClose2.Size = size
			Me.btnClose.TabIndex = 2
			Me.btnClose.Text = "Close"
			Me.GroupBox1.Controls.Add(Me.ulgTemplates)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(8, 8)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(1176, 744)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 11
			Me.GroupBox1.TabStop = False
			Me.ulgTemplates.AllowDrop = True
			Me.ulgTemplates.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim ulgTemplates As Global.System.Windows.Forms.Control = Me.ulgTemplates
			location = New Global.System.Drawing.Point(8, 16)
			ulgTemplates.Location = location
			Me.ulgTemplates.Name = "ulgTemplates"
			Dim ulgTemplates2 As Global.System.Windows.Forms.Control = Me.ulgTemplates
			size = New Global.System.Drawing.Size(1152, 720)
			ulgTemplates2.Size = size
			Me.ulgTemplates.TabIndex = 10
			Me.lblDBFile.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim lblDBFile As Global.System.Windows.Forms.Control = Me.lblDBFile
			location = New Global.System.Drawing.Point(0, 798)
			lblDBFile.Location = location
			Me.lblDBFile.Name = "lblDBFile"
			Dim lblDBFile2 As Global.System.Windows.Forms.Control = Me.lblDBFile
			size = New Global.System.Drawing.Size(1207, 32)
			lblDBFile2.Size = size
			Me.lblDBFile.TabIndex = 12
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(1207, 830)
			Me.ClientSize = size
			Me.Controls.Add(Me.lblDBFile)
			Me.Controls.Add(Me.btnClose)
			Me.Controls.Add(Me.GroupBox1)
			Me.Name = "db_guru_admin_form"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "All Guru Templates in Database"
			Me.GroupBox1.ResumeLayout(False)
			CType(Me.ulgTemplates, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
