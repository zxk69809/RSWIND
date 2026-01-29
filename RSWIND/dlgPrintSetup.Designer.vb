Namespace RSWINV3
	Friend Partial Class dlgPrintSetup
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgPrintSetup))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.lblDefault = New Global.System.Windows.Forms.Label()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me.lstPrinters = New Global.System.Windows.Forms.ListBox()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(262, 40)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(79, 23)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 2
			Me.cmdCancel.Text = "Cancel"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(262, 10)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(79, 23)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 1
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me.lblDefault.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblDefault.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblDefault.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblDefault.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lblDefault.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblDefault As Global.System.Windows.Forms.Control = Me.lblDefault
			location = New Global.System.Drawing.Point(16, 156)
			lblDefault.Location = location
			Me.lblDefault.Name = "lblDefault"
			Me.lblDefault.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblDefault2 As Global.System.Windows.Forms.Control = Me.lblDefault
			size = New Global.System.Drawing.Size(321, 15)
			lblDefault2.Size = size
			Me.lblDefault.TabIndex = 5
			Me.lblDefault.Text = "Default:"
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_0, 0S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(16, 8)
			label_.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(95, 15)
			label_2.Size = size
			Me._Label_0.TabIndex = 3
			Me._Label_0.Text = "Select a printer:"
			Me.lstPrinters.ItemHeight = 14
			Dim lstPrinters As Global.System.Windows.Forms.Control = Me.lstPrinters
			location = New Global.System.Drawing.Point(16, 32)
			lstPrinters.Location = location
			Me.lstPrinters.Name = "lstPrinters"
			Dim lstPrinters2 As Global.System.Windows.Forms.Control = Me.lstPrinters
			size = New Global.System.Drawing.Size(232, 88)
			lstPrinters2.Size = size
			Me.lstPrinters.TabIndex = 6
			Me.AcceptButton = Me.cmdOK
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			Me.CancelButton = Me.cmdCancel
			size = New Global.System.Drawing.Size(355, 176)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.lstPrinters)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me.lblDefault)
			Me.Controls.Add(Me._Label_0)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			location = New Global.System.Drawing.Point(332, 257)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgPrintSetup"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Printer Setup"
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
