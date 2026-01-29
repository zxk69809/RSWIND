Namespace RSWINV3
	Friend Partial Class dlgImplementGuideChanges
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgImplementGuideChanges))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdAddSection = New Global.System.Windows.Forms.Button()
			Me.cmdDelSection = New Global.System.Windows.Forms.Button()
			Me.cmdMoveSectionUp = New Global.System.Windows.Forms.Button()
			Me.cmdMoveSectionDown = New Global.System.Windows.Forms.Button()
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me.lblMaximum = New Global.System.Windows.Forms.Label()
			Me.lblMinimum = New Global.System.Windows.Forms.Label()
			Me.lblStringLength = New Global.System.Windows.Forms.Label()
			Me.ulgTapers_before = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me.ulgTapers = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.txtTempDiam = New Global.System.Windows.Forms.TextBox()
			Me.lblTemp = New Global.System.Windows.Forms.Label()
			Me.txtTempLength = New Global.System.Windows.Forms.TextBox()
			Me.cboRodGuides = New Global.System.Windows.Forms.ComboBox()
			Me.cboRodGrade = New Global.System.Windows.Forms.ComboBox()
			Me.cboRodSize = New Global.System.Windows.Forms.ComboBox()
			Me.btnImplement = New Global.System.Windows.Forms.Button()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.lblStatus = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox2 = New Global.System.Windows.Forms.TextBox()
			Me.txtLength = New Global.System.Windows.Forms.TextBox()
			Me._Label_Length = New Global.System.Windows.Forms.Label()
			Me.btnAccept = New Global.System.Windows.Forms.Button()
			Me.pnlViewReport = New Global.System.Windows.Forms.Panel()
			Me.Viewer1 = New Global.DataDynamics.ActiveReports.Viewer.Viewer()
			Me.chkShowReport = New Global.System.Windows.Forms.CheckBox()
			Me.btnUndoImplement = New Global.System.Windows.Forms.Button()
			Me._SSPanel_0.SuspendLayout()
			CType(Me.ulgTapers_before, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ulgTapers, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlViewReport.SuspendLayout()
			Me.SuspendLayout()
			Me.cmdAddSection.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdAddSection.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdAddSection.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdAddSection.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdAddSection.Image = CType(componentResourceManager.GetObject("cmdAddSection.Image"), Global.System.Drawing.Image)
			Me.cmdAddSection.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdAddSection As Global.System.Windows.Forms.Control = Me.cmdAddSection
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(9, 73)
			cmdAddSection.Location = location
			Me.cmdAddSection.Name = "cmdAddSection"
			Me.cmdAddSection.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdAddSection2 As Global.System.Windows.Forms.Control = Me.cmdAddSection
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(24, 24)
			cmdAddSection2.Size = size
			Me.cmdAddSection.TabIndex = 207
			Me.cmdAddSection.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdAddSection, "Add a rod section")
			Me.cmdAddSection.UseVisualStyleBackColor = False
			Me.cmdAddSection.Visible = False
			Me.cmdDelSection.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdDelSection.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdDelSection.Enabled = False
			Me.cmdDelSection.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdDelSection.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdDelSection.Image = CType(componentResourceManager.GetObject("cmdDelSection.Image"), Global.System.Drawing.Image)
			Me.cmdDelSection.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdDelSection As Global.System.Windows.Forms.Control = Me.cmdDelSection
			location = New Global.System.Drawing.Point(9, 97)
			cmdDelSection.Location = location
			Me.cmdDelSection.Name = "cmdDelSection"
			Me.cmdDelSection.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdDelSection2 As Global.System.Windows.Forms.Control = Me.cmdDelSection
			size = New Global.System.Drawing.Size(24, 24)
			cmdDelSection2.Size = size
			Me.cmdDelSection.TabIndex = 208
			Me.cmdDelSection.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdDelSection, "Remove a rod section")
			Me.cmdDelSection.UseVisualStyleBackColor = False
			Me.cmdDelSection.Visible = False
			Me.cmdMoveSectionUp.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdMoveSectionUp.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdMoveSectionUp.Enabled = False
			Me.cmdMoveSectionUp.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdMoveSectionUp.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdMoveSectionUp.Image = CType(componentResourceManager.GetObject("cmdMoveSectionUp.Image"), Global.System.Drawing.Image)
			Me.cmdMoveSectionUp.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdMoveSectionUp As Global.System.Windows.Forms.Control = Me.cmdMoveSectionUp
			location = New Global.System.Drawing.Point(9, 25)
			cmdMoveSectionUp.Location = location
			Me.cmdMoveSectionUp.Name = "cmdMoveSectionUp"
			Me.cmdMoveSectionUp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdMoveSectionUp2 As Global.System.Windows.Forms.Control = Me.cmdMoveSectionUp
			size = New Global.System.Drawing.Size(24, 24)
			cmdMoveSectionUp2.Size = size
			Me.cmdMoveSectionUp.TabIndex = 205
			Me.cmdMoveSectionUp.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdMoveSectionUp, "Move a rod section upward")
			Me.cmdMoveSectionUp.UseVisualStyleBackColor = False
			Me.cmdMoveSectionUp.Visible = False
			Me.cmdMoveSectionDown.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdMoveSectionDown.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdMoveSectionDown.Enabled = False
			Me.cmdMoveSectionDown.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdMoveSectionDown.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdMoveSectionDown.Image = CType(componentResourceManager.GetObject("cmdMoveSectionDown.Image"), Global.System.Drawing.Image)
			Me.cmdMoveSectionDown.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdMoveSectionDown As Global.System.Windows.Forms.Control = Me.cmdMoveSectionDown
			location = New Global.System.Drawing.Point(9, 49)
			cmdMoveSectionDown.Location = location
			Me.cmdMoveSectionDown.Name = "cmdMoveSectionDown"
			Me.cmdMoveSectionDown.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdMoveSectionDown2 As Global.System.Windows.Forms.Control = Me.cmdMoveSectionDown
			size = New Global.System.Drawing.Size(24, 24)
			cmdMoveSectionDown2.Size = size
			Me.cmdMoveSectionDown.TabIndex = 206
			Me.cmdMoveSectionDown.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.cmdMoveSectionDown, "Move a rod section downward")
			Me.cmdMoveSectionDown.UseVisualStyleBackColor = False
			Me.cmdMoveSectionDown.Visible = False
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._SSPanel_0.Controls.Add(Me.lblMaximum)
			Me._SSPanel_0.Controls.Add(Me.lblMinimum)
			Me._SSPanel_0.Controls.Add(Me.lblStringLength)
			Me._SSPanel_0.Controls.Add(Me.ulgTapers_before)
			Me._SSPanel_0.Controls.Add(Me.ulgTapers)
			Me._SSPanel_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._SSPanel_0.ForeColor = Global.System.Drawing.Color.Black
			Me.SSPanel.SetIndex(Me._SSPanel_0, 0S)
			Dim sspanel_ As Global.System.Windows.Forms.Control = Me._SSPanel_0
			location = New Global.System.Drawing.Point(4, 1)
			sspanel_.Location = location
			Me._SSPanel_0.Name = "_SSPanel_0"
			Me._SSPanel_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim sspanel_2 As Global.System.Windows.Forms.Control = Me._SSPanel_0
			size = New Global.System.Drawing.Size(1002, 312)
			sspanel_2.Size = size
			Me._SSPanel_0.TabIndex = 2
			Me._SSPanel_0.TabStop = True
			Dim lblMaximum As Global.System.Windows.Forms.Control = Me.lblMaximum
			location = New Global.System.Drawing.Point(547, 290)
			lblMaximum.Location = location
			Me.lblMaximum.Name = "lblMaximum"
			Dim lblMaximum2 As Global.System.Windows.Forms.Control = Me.lblMaximum
			size = New Global.System.Drawing.Size(423, 16)
			lblMaximum2.Size = size
			Me.lblMaximum.TabIndex = 197
			Me.lblMaximum.Text = "Maximum"
			Dim lblMinimum As Global.System.Windows.Forms.Control = Me.lblMinimum
			location = New Global.System.Drawing.Point(29, 290)
			lblMinimum.Location = location
			Me.lblMinimum.Name = "lblMinimum"
			Dim lblMinimum2 As Global.System.Windows.Forms.Control = Me.lblMinimum
			size = New Global.System.Drawing.Size(423, 16)
			lblMinimum2.Size = size
			Me.lblMinimum.TabIndex = 196
			Me.lblMinimum.Text = "Minimum"
			Me.lblStringLength.AutoSize = True
			Me.lblStringLength.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblStringLength.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblStringLength As Global.System.Windows.Forms.Control = Me.lblStringLength
			location = New Global.System.Drawing.Point(30, 266)
			lblStringLength.Location = location
			Me.lblStringLength.Name = "lblStringLength"
			Dim lblStringLength2 As Global.System.Windows.Forms.Control = Me.lblStringLength
			size = New Global.System.Drawing.Size(2, 18)
			lblStringLength2.Size = size
			Me.lblStringLength.TabIndex = 195
			Me.ulgTapers_before.AllowDrop = True
			Me.ulgTapers_before.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim ulgTapers_before As Global.System.Windows.Forms.Control = Me.ulgTapers_before
			location = New Global.System.Drawing.Point(31, 8)
			ulgTapers_before.Location = location
			Me.ulgTapers_before.Name = "ulgTapers_before"
			Dim ulgTapers_before2 As Global.System.Windows.Forms.Control = Me.ulgTapers_before
			size = New Global.System.Drawing.Size(962, 256)
			ulgTapers_before2.Size = size
			Me.ulgTapers_before.TabIndex = 9
			Me.ulgTapers.AllowDrop = True
			Me.ulgTapers.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim ulgTapers As Global.System.Windows.Forms.Control = Me.ulgTapers
			location = New Global.System.Drawing.Point(32, 8)
			ulgTapers.Location = location
			Me.ulgTapers.Name = "ulgTapers"
			Dim ulgTapers2 As Global.System.Windows.Forms.Control = Me.ulgTapers
			size = New Global.System.Drawing.Size(962, 256)
			ulgTapers2.Size = size
			Me.ulgTapers.TabIndex = 10
			Dim txtTempDiam As Global.System.Windows.Forms.Control = Me.txtTempDiam
			location = New Global.System.Drawing.Point(461, 342)
			txtTempDiam.Location = location
			Me.txtTempDiam.Name = "txtTempDiam"
			Dim txtTempDiam2 As Global.System.Windows.Forms.Control = Me.txtTempDiam
			size = New Global.System.Drawing.Size(112, 20)
			txtTempDiam2.Size = size
			Me.txtTempDiam.TabIndex = 186
			Me.txtTempDiam.Tag = "mem"
			Me.txtTempDiam.Text = "txtTempDiam"
			Me.txtTempDiam.Visible = False
			Me.lblTemp.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblTemp As Global.System.Windows.Forms.Control = Me.lblTemp
			location = New Global.System.Drawing.Point(489, 344)
			lblTemp.Location = location
			Me.lblTemp.Name = "lblTemp"
			Dim lblTemp2 As Global.System.Windows.Forms.Control = Me.lblTemp
			size = New Global.System.Drawing.Size(56, 16)
			lblTemp2.Size = size
			Me.lblTemp.TabIndex = 187
			Me.lblTemp.Text = "lblTemp"
			Me.lblTemp.Visible = False
			Dim txtTempLength As Global.System.Windows.Forms.Control = Me.txtTempLength
			location = New Global.System.Drawing.Point(469, 342)
			txtTempLength.Location = location
			Me.txtTempLength.Name = "txtTempLength"
			Dim txtTempLength2 As Global.System.Windows.Forms.Control = Me.txtTempLength
			size = New Global.System.Drawing.Size(96, 20)
			txtTempLength2.Size = size
			Me.txtTempLength.TabIndex = 188
			Me.txtTempLength.Tag = "fem"
			Me.txtTempLength.Text = "txtTempLength"
			Me.txtTempLength.Visible = False
			Me.cboRodGuides.AllowDrop = True
			Me.cboRodGuides.BackColor = Global.System.Drawing.Color.Cyan
			Me.cboRodGuides.DropDownWidth = 200
			Me.cboRodGuides.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.cboRodGuides.ItemHeight = 16
			Dim cboRodGuides As Global.System.Windows.Forms.Control = Me.cboRodGuides
			location = New Global.System.Drawing.Point(465, 340)
			cboRodGuides.Location = location
			Me.cboRodGuides.MaxDropDownItems = 12
			Me.cboRodGuides.MaxLength = 100
			Me.cboRodGuides.Name = "cboRodGuides"
			Dim cboRodGuides2 As Global.System.Windows.Forms.Control = Me.cboRodGuides
			size = New Global.System.Drawing.Size(104, 24)
			cboRodGuides2.Size = size
			Me.cboRodGuides.TabIndex = 194
			Me.cboRodGuides.Visible = False
			Me.cboRodGrade.AllowDrop = True
			Me.cboRodGrade.BackColor = Global.System.Drawing.Color.Cyan
			Me.cboRodGrade.DropDownWidth = 200
			Me.cboRodGrade.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.cboRodGrade.ItemHeight = 16
			Dim cboRodGrade As Global.System.Windows.Forms.Control = Me.cboRodGrade
			location = New Global.System.Drawing.Point(473, 348)
			cboRodGrade.Location = location
			Me.cboRodGrade.MaxDropDownItems = 30
			Me.cboRodGrade.MaxLength = 100
			Me.cboRodGrade.Name = "cboRodGrade"
			Dim cboRodGrade2 As Global.System.Windows.Forms.Control = Me.cboRodGrade
			size = New Global.System.Drawing.Size(104, 24)
			cboRodGrade2.Size = size
			Me.cboRodGrade.TabIndex = 195
			Me.cboRodGrade.Visible = False
			Me.cboRodSize.AllowDrop = True
			Me.cboRodSize.BackColor = Global.System.Drawing.Color.Cyan
			Me.cboRodSize.DropDownWidth = 200
			Me.cboRodSize.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.cboRodSize.ItemHeight = 16
			Dim cboRodSize As Global.System.Windows.Forms.Control = Me.cboRodSize
			location = New Global.System.Drawing.Point(481, 356)
			cboRodSize.Location = location
			Me.cboRodSize.MaxDropDownItems = 20
			Me.cboRodSize.MaxLength = 100
			Me.cboRodSize.Name = "cboRodSize"
			Dim cboRodSize2 As Global.System.Windows.Forms.Control = Me.cboRodSize
			size = New Global.System.Drawing.Size(104, 24)
			cboRodSize2.Size = size
			Me.cboRodSize.TabIndex = 196
			Me.cboRodSize.Visible = False
			Me.btnImplement.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnImplement.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnImplement.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnImplement.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnImplement.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnImplement As Global.System.Windows.Forms.Control = Me.btnImplement
			location = New Global.System.Drawing.Point(373, 661)
			btnImplement.Location = location
			Me.btnImplement.Name = "btnImplement"
			Me.btnImplement.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim btnImplement2 As Global.System.Windows.Forms.Control = Me.btnImplement
			size = New Global.System.Drawing.Size(96, 23)
			btnImplement2.Size = size
			Me.btnImplement.TabIndex = 198
			Me.btnImplement.Text = "&Implement"
			Me.btnImplement.UseVisualStyleBackColor = False
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.Enabled = False
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			location = New Global.System.Drawing.Point(908, 661)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(96, 23)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 197
			Me.cmdCancel.Text = "Close"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.lblStatus.AutoSize = True
			Me.lblStatus.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim lblStatus As Global.System.Windows.Forms.Control = Me.lblStatus
			location = New Global.System.Drawing.Point(0, 690)
			lblStatus.Location = location
			Me.lblStatus.Name = "lblStatus"
			Dim lblStatus2 As Global.System.Windows.Forms.Control = Me.lblStatus
			size = New Global.System.Drawing.Size(0, 14)
			lblStatus2.Size = size
			Me.lblStatus.TabIndex = 199
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(468, 167)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(56, 16)
			label2.Size = size
			Me.Label1.TabIndex = 202
			Me.Label1.Text = "Label1"
			Me.Label1.Visible = False
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(468, 231)
			textBox.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(112, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 201
			Me.TextBox1.Tag = "mem"
			Me.TextBox1.Text = "TextBox1"
			Me.TextBox1.Visible = False
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox2
			location = New Global.System.Drawing.Point(468, 183)
			textBox3.Location = location
			Me.TextBox2.Name = "TextBox2"
			Dim textBox4 As Global.System.Windows.Forms.Control = Me.TextBox2
			size = New Global.System.Drawing.Size(96, 20)
			textBox4.Size = size
			Me.TextBox2.TabIndex = 200
			Me.TextBox2.Tag = "fem"
			Me.TextBox2.Text = "TextBox2"
			Me.TextBox2.Visible = False
			Me.txtLength.AcceptsReturn = True
			Me.txtLength.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtLength.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtLength.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtLength.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtLength As Global.System.Windows.Forms.Control = Me.txtLength
			location = New Global.System.Drawing.Point(462, 198)
			txtLength.Location = location
			Me.txtLength.MaxLength = 10
			Me.txtLength.Name = "txtLength"
			Me.txtLength.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtLength2 As Global.System.Windows.Forms.Control = Me.txtLength
			size = New Global.System.Drawing.Size(125, 22)
			txtLength2.Size = size
			Me.txtLength.TabIndex = 203
			Me.txtLength.Tag = "fem"
			Me.txtLength.Visible = False
			Me._Label_Length.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_Length.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_Length.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_Length.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_Length.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_Length As Global.System.Windows.Forms.Control = Me._Label_Length
			location = New Global.System.Drawing.Point(503, 192)
			label_Length.Location = location
			Me._Label_Length.Name = "_Label_Length"
			Me._Label_Length.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_Length2 As Global.System.Windows.Forms.Control = Me._Label_Length
			size = New Global.System.Drawing.Size(88, 16)
			label_Length2.Size = size
			Me._Label_Length.TabIndex = 209
			Me._Label_Length.Tag = "Length  (^):"
			Me._Label_Length.Text = "Length  (ft):"
			Me._Label_Length.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_Length.Visible = False
			Me.btnAccept.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnAccept.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnAccept.Enabled = False
			Me.btnAccept.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnAccept.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnAccept.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnAccept As Global.System.Windows.Forms.Control = Me.btnAccept
			location = New Global.System.Drawing.Point(801, 661)
			btnAccept.Location = location
			Me.btnAccept.Name = "btnAccept"
			Me.btnAccept.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim btnAccept2 As Global.System.Windows.Forms.Control = Me.btnAccept
			size = New Global.System.Drawing.Size(96, 23)
			btnAccept2.Size = size
			Me.btnAccept.TabIndex = 210
			Me.btnAccept.Text = "&Accept and Run"
			Me.btnAccept.UseVisualStyleBackColor = False
			Me.pnlViewReport.Controls.Add(Me.Viewer1)
			Dim pnlViewReport As Global.System.Windows.Forms.Control = Me.pnlViewReport
			location = New Global.System.Drawing.Point(5, 314)
			pnlViewReport.Location = location
			Me.pnlViewReport.Name = "pnlViewReport"
			Dim pnlViewReport2 As Global.System.Windows.Forms.Control = Me.pnlViewReport
			size = New Global.System.Drawing.Size(1001, 344)
			pnlViewReport2.Size = size
			Me.pnlViewReport.TabIndex = 212
			Me.pnlViewReport.Visible = False
			Me.Viewer1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Viewer1.Document = New Global.DataDynamics.ActiveReports.Document.Document("ARNet Document")
			Dim viewer As Global.System.Windows.Forms.Control = Me.Viewer1
			location = New Global.System.Drawing.Point(0, 8)
			viewer.Location = location
			Me.Viewer1.Name = "Viewer1"
			Me.Viewer1.ReportViewer.CurrentPage = 0
			Me.Viewer1.ReportViewer.MultiplePageCols = 3
			Me.Viewer1.ReportViewer.MultiplePageRows = 2
			Me.Viewer1.ReportViewer.ViewType = Global.DataDynamics.ActiveReports.Viewer.ViewType.Normal
			Dim viewer2 As Global.System.Windows.Forms.Control = Me.Viewer1
			size = New Global.System.Drawing.Size(993, 333)
			viewer2.Size = size
			Me.Viewer1.TabIndex = 16
			Me.Viewer1.TableOfContents.Text = "Contents"
			Me.Viewer1.TableOfContents.Width = 200
			Me.Viewer1.TabTitleLength = 35
			Me.Viewer1.Toolbar.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.chkShowReport.AutoSize = True
			Me.chkShowReport.Enabled = False
			Dim chkShowReport As Global.System.Windows.Forms.Control = Me.chkShowReport
			location = New Global.System.Drawing.Point(8, 661)
			chkShowReport.Location = location
			Me.chkShowReport.Name = "chkShowReport"
			Dim chkShowReport2 As Global.System.Windows.Forms.Control = Me.chkShowReport
			size = New Global.System.Drawing.Size(219, 18)
			chkShowReport2.Size = size
			Me.chkShowReport.TabIndex = 213
			Me.chkShowReport.Text = "Show Recommended Guide Report"
			Me.chkShowReport.UseVisualStyleBackColor = True
			Me.btnUndoImplement.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnUndoImplement.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnUndoImplement.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnUndoImplement.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnUndoImplement.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnUndoImplement As Global.System.Windows.Forms.Control = Me.btnUndoImplement
			location = New Global.System.Drawing.Point(479, 661)
			btnUndoImplement.Location = location
			Me.btnUndoImplement.Name = "btnUndoImplement"
			Me.btnUndoImplement.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim btnUndoImplement2 As Global.System.Windows.Forms.Control = Me.btnUndoImplement
			size = New Global.System.Drawing.Size(96, 23)
			btnUndoImplement2.Size = size
			Me.btnUndoImplement.TabIndex = 214
			Me.btnUndoImplement.Text = "&Undo-Implement"
			Me.btnUndoImplement.UseVisualStyleBackColor = False
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			Me.AutoScroll = True
			size = New Global.System.Drawing.Size(1009, 704)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.btnUndoImplement)
			Me.Controls.Add(Me.pnlViewReport)
			Me.Controls.Add(Me.btnAccept)
			Me.Controls.Add(Me.cmdAddSection)
			Me.Controls.Add(Me.cmdDelSection)
			Me.Controls.Add(Me.cmdMoveSectionUp)
			Me.Controls.Add(Me.cmdMoveSectionDown)
			Me.Controls.Add(Me.lblStatus)
			Me.Controls.Add(Me.btnImplement)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me._SSPanel_0)
			Me.Controls.Add(Me.cboRodSize)
			Me.Controls.Add(Me.cboRodGrade)
			Me.Controls.Add(Me.cboRodGuides)
			Me.Controls.Add(Me.txtTempLength)
			Me.Controls.Add(Me.lblTemp)
			Me.Controls.Add(Me.txtTempDiam)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.TextBox2)
			Me.Controls.Add(Me.txtLength)
			Me.Controls.Add(Me._Label_Length)
			Me.Controls.Add(Me.chkShowReport)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(64, 184)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgImplementGuideChanges"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Implement RODSTAR-D Rod Guide Recommendations"
			Me._SSPanel_0.ResumeLayout(False)
			Me._SSPanel_0.PerformLayout()
			CType(Me.ulgTapers_before, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ulgTapers, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlViewReport.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
