Namespace RSWINV3
	Public Partial Class frmImportDialog
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.rdbRSTX = New Global.System.Windows.Forms.RadioButton()
			Me.rdbExcel = New Global.System.Windows.Forms.RadioButton()
			Me.btnContinue = New Global.System.Windows.Forms.Button()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.rdbCSV = New Global.System.Windows.Forms.RadioButton()
			Me.SuspendLayout()
			Me.rdbRSTX.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rdbRSTX As Global.System.Windows.Forms.Control = Me.rdbRSTX
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(32, 64)
			rdbRSTX.Location = location
			Me.rdbRSTX.Name = "rdbRSTX"
			Dim rdbRSTX2 As Global.System.Windows.Forms.Control = Me.rdbRSTX
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(512, 24)
			rdbRSTX2.Size = size
			Me.rdbRSTX.TabIndex = 2
			Me.rdbRSTX.Text = "Import Deviation Survey from RODSTAR-D File (rsdx) or XDIAG-D (xddx) file"
			Me.rdbExcel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rdbExcel As Global.System.Windows.Forms.Control = Me.rdbExcel
			location = New Global.System.Drawing.Point(32, 16)
			rdbExcel.Location = location
			Me.rdbExcel.Name = "rdbExcel"
			Dim rdbExcel2 As Global.System.Windows.Forms.Control = Me.rdbExcel
			size = New Global.System.Drawing.Size(512, 24)
			rdbExcel2.Size = size
			Me.rdbExcel.TabIndex = 3
			Me.rdbExcel.Text = "Import Deviation Survey from Excel  File (xls,xlsx)"
			Me.btnContinue.DialogResult = Global.System.Windows.Forms.DialogResult.OK
			Me.btnContinue.Enabled = False
			Me.btnContinue.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnContinue As Global.System.Windows.Forms.Control = Me.btnContinue
			location = New Global.System.Drawing.Point(128, 112)
			btnContinue.Location = location
			Me.btnContinue.Name = "btnContinue"
			Dim btnContinue2 As Global.System.Windows.Forms.Control = Me.btnContinue
			size = New Global.System.Drawing.Size(88, 24)
			btnContinue2.Size = size
			Me.btnContinue.TabIndex = 4
			Me.btnContinue.Text = "&Continue"
			Me.btnCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
			location = New Global.System.Drawing.Point(266, 112)
			btnCancel.Location = location
			Me.btnCancel.Name = "btnCancel"
			Dim btnCancel2 As Global.System.Windows.Forms.Control = Me.btnCancel
			size = New Global.System.Drawing.Size(87, 24)
			btnCancel2.Size = size
			Me.btnCancel.TabIndex = 5
			Me.btnCancel.Text = "C&ancel"
			Me.rdbCSV.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rdbCSV As Global.System.Windows.Forms.Control = Me.rdbCSV
			location = New Global.System.Drawing.Point(32, 40)
			rdbCSV.Location = location
			Me.rdbCSV.Name = "rdbCSV"
			Dim rdbCSV2 As Global.System.Windows.Forms.Control = Me.rdbCSV
			size = New Global.System.Drawing.Size(512, 24)
			rdbCSV2.Size = size
			Me.rdbCSV.TabIndex = 6
			Me.rdbCSV.Text = "Import Deviation Survey from Comma Delimited File  (csv)"
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(558, 164)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.rdbCSV)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnContinue)
			Me.Controls.Add(Me.rdbExcel)
			Me.Controls.Add(Me.rdbRSTX)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "frmImportDialog"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Import Wizard Dialog"
			Me.TopMost = True
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
