Namespace RSWINV3
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmLoadGuruFNames
		Inherits Global.System.Windows.Forms.Form

		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.OleDbSelectCommand1 = New Global.System.Data.OleDb.OleDbCommand()
			Me.OleDbInsertCommand1 = New Global.System.Data.OleDb.OleDbCommand()
			Me.OleDbUpdateCommand1 = New Global.System.Data.OleDb.OleDbCommand()
			Me.OleDbDeleteCommand1 = New Global.System.Data.OleDb.OleDbCommand()
			Me.OleDbDataAdapter1 = New Global.System.Data.OleDb.OleDbDataAdapter()
			Me.OleDbConnection1 = New Global.System.Data.OleDb.OleDbConnection()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.lboFilenames = New Global.System.Windows.Forms.ListBox()
			Me.SuspendLayout()
			Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
			Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
			Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
			Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(344, 621)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(79, 22)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 4
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Dim lboFilenames As Global.System.Windows.Forms.Control = Me.lboFilenames
			location = New Global.System.Drawing.Point(8, 8)
			lboFilenames.Location = location
			Me.lboFilenames.Name = "lboFilenames"
			Dim lboFilenames2 As Global.System.Windows.Forms.Control = Me.lboFilenames
			size = New Global.System.Drawing.Size(416, 589)
			lboFilenames2.Size = size
			Me.lboFilenames.TabIndex = 5
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(466, 660)
			Me.ClientSize = size
			Me.Controls.Add(Me.lboFilenames)
			Me.Controls.Add(Me.cmdOK)
			Me.Name = "frmLoadGuruFNames"
			Me.Text = "Select File Name Key"
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
