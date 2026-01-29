Namespace RSWINV3
	Friend Partial Class dlgCustomUnitComparison
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
			Dim ultraGridBand As Global.Infragistics.Win.UltraWinGrid.UltraGridBand = New Global.Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
			Dim ultraGridColumn As Global.Infragistics.Win.UltraWinGrid.UltraGridColumn = New Global.Infragistics.Win.UltraWinGrid.UltraGridColumn("", 0)
			Dim ultraGridColumn2 As Global.Infragistics.Win.UltraWinGrid.UltraGridColumn = New Global.Infragistics.Win.UltraWinGrid.UltraGridColumn("", 1)
			Dim ultraGridColumn3 As Global.Infragistics.Win.UltraWinGrid.UltraGridColumn = New Global.Infragistics.Win.UltraWinGrid.UltraGridColumn("", 2)
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgCustomUnitComparison))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me.ulgUnits = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me.Image = New Global.System.Windows.Forms.PictureBox()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.rbtUseBoth = New Global.System.Windows.Forms.RadioButton()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.rbtUseLocalUnit = New Global.System.Windows.Forms.RadioButton()
			Me.rbtUseServerUnit = New Global.System.Windows.Forms.RadioButton()
			Me._SSPanel_0.SuspendLayout()
			CType(Me.ulgUnits, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._SSPanel_0.Controls.Add(Me.ulgUnits)
			Me._SSPanel_0.Controls.Add(Me._Label_0)
			Me._SSPanel_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._SSPanel_0.ForeColor = Global.System.Drawing.Color.Black
			Me.SSPanel.SetIndex(Me._SSPanel_0, 0S)
			Dim sspanel_ As Global.System.Windows.Forms.Control = Me._SSPanel_0
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(38, 3)
			sspanel_.Location = location
			Me._SSPanel_0.Name = "_SSPanel_0"
			Me._SSPanel_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim sspanel_2 As Global.System.Windows.Forms.Control = Me._SSPanel_0
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(644, 517)
			sspanel_2.Size = size
			Me._SSPanel_0.TabIndex = 2
			Me._SSPanel_0.TabStop = True
			Me.ulgUnits.AllowDrop = True
			ultraGridColumn.Header.VisiblePosition = 0
			ultraGridColumn2.Header.VisiblePosition = 1
			ultraGridColumn3.Header.VisiblePosition = 2
			ultraGridBand.Columns.AddRange(New Object() { ultraGridColumn, ultraGridColumn2, ultraGridColumn3 })
			Me.ulgUnits.DisplayLayout.BandsSerializer.Add(ultraGridBand)
			Me.ulgUnits.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim ulgUnits As Global.System.Windows.Forms.Control = Me.ulgUnits
			location = New Global.System.Drawing.Point(10, 38)
			ulgUnits.Location = location
			Me.ulgUnits.Name = "ulgUnits"
			Dim ulgUnits2 As Global.System.Windows.Forms.Control = Me.ulgUnits
			size = New Global.System.Drawing.Size(626, 471)
			ulgUnits2.Size = size
			Me.ulgUnits.SyncWithCurrencyManager = False
			Me.ulgUnits.TabIndex = 8
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 10F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_0, 0S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(12, 4)
			label_.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(624, 31)
			label_2.Size = size
			Me._Label_0.TabIndex = 3
			Me._Label_0.Text = "Please select which measured pumping unit to use. "
			Me._Label_0.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Image.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Image.Image = CType(componentResourceManager.GetObject("Image.Image"), Global.System.Drawing.Image)
			Me.Image.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim image As Global.System.Windows.Forms.Control = Me.Image
			location = New Global.System.Drawing.Point(3, 85)
			image.Location = location
			Me.Image.Name = "Image"
			Dim image2 As Global.System.Windows.Forms.Control = Me.Image
			size = New Global.System.Drawing.Size(32, 32)
			image2.Size = size
			Me.Image.TabIndex = 16
			Me.Image.TabStop = False
			Me.Panel1.Controls.Add(Me.rbtUseBoth)
			Me.Panel1.Controls.Add(Me.cmdOK)
			Me.Panel1.Controls.Add(Me.rbtUseLocalUnit)
			Me.Panel1.Controls.Add(Me.rbtUseServerUnit)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(38, 523)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(644, 40)
			panel2.Size = size
			Me.Panel1.TabIndex = 40
			Me.rbtUseBoth.AutoSize = True
			Me.rbtUseBoth.Font = New Global.System.Drawing.Font("Arial", 9F)
			Dim rbtUseBoth As Global.System.Windows.Forms.Control = Me.rbtUseBoth
			location = New Global.System.Drawing.Point(361, 10)
			rbtUseBoth.Location = location
			Me.rbtUseBoth.Name = "rbtUseBoth"
			Dim rbtUseBoth2 As Global.System.Windows.Forms.Control = Me.rbtUseBoth
			size = New Global.System.Drawing.Size(75, 19)
			rbtUseBoth2.Size = size
			Me.rbtUseBoth.TabIndex = 46
			Me.rbtUseBoth.TabStop = True
			Me.rbtUseBoth.Text = "Use both"
			Me.rbtUseBoth.UseVisualStyleBackColor = True
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(530, 9)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(86, 23)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 43
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me.rbtUseLocalUnit.AutoSize = True
			Me.rbtUseLocalUnit.Font = New Global.System.Drawing.Font("Arial", 9F)
			Dim rbtUseLocalUnit As Global.System.Windows.Forms.Control = Me.rbtUseLocalUnit
			location = New Global.System.Drawing.Point(11, 10)
			rbtUseLocalUnit.Location = location
			Me.rbtUseLocalUnit.Name = "rbtUseLocalUnit"
			Dim rbtUseLocalUnit2 As Global.System.Windows.Forms.Control = Me.rbtUseLocalUnit
			size = New Global.System.Drawing.Size(100, 19)
			rbtUseLocalUnit2.Size = size
			Me.rbtUseLocalUnit.TabIndex = 44
			Me.rbtUseLocalUnit.TabStop = True
			Me.rbtUseLocalUnit.Text = "Use local unit"
			Me.rbtUseLocalUnit.UseVisualStyleBackColor = True
			Me.rbtUseServerUnit.AutoSize = True
			Me.rbtUseServerUnit.Font = New Global.System.Drawing.Font("Arial", 9F)
			Dim rbtUseServerUnit As Global.System.Windows.Forms.Control = Me.rbtUseServerUnit
			location = New Global.System.Drawing.Point(180, 10)
			rbtUseServerUnit.Location = location
			Me.rbtUseServerUnit.Name = "rbtUseServerUnit"
			Dim rbtUseServerUnit2 As Global.System.Windows.Forms.Control = Me.rbtUseServerUnit
			size = New Global.System.Drawing.Size(108, 19)
			rbtUseServerUnit2.Size = size
			Me.rbtUseServerUnit.TabIndex = 45
			Me.rbtUseServerUnit.TabStop = True
			Me.rbtUseServerUnit.Text = "Use server unit"
			Me.rbtUseServerUnit.UseVisualStyleBackColor = True
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.None
			size = New Global.System.Drawing.Size(707, 572)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me._SSPanel_0)
			Me.Controls.Add(Me.Image)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			location = New Global.System.Drawing.Point(64, 184)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgCustomUnitComparison"
			Me.ShowInTaskbar = False
			Me.SizeGripStyle = Global.System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Measure Pumping Unit Differences"
			Me._SSPanel_0.ResumeLayout(False)
			CType(Me.ulgUnits, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Image, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
