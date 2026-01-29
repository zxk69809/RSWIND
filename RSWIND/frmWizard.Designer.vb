Namespace RSWINV3
	Friend Partial Class frmWizard
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.frmWizard))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.pnlScreen_3 = New Global.System.Windows.Forms.Panel()
			Me.lblWorkbook = New Global.System.Windows.Forms.Label()
			Me.lblSpreadSheet = New Global.System.Windows.Forms.Label()
			Me.lblSurveyType = New Global.System.Windows.Forms.Label()
			Me.txtAZRange = New Global.System.Windows.Forms.TextBox()
			Me.txtINRange = New Global.System.Windows.Forms.TextBox()
			Me.lblPosition = New Global.System.Windows.Forms.Label()
			Me.txtAZPos = New Global.System.Windows.Forms.TextBox()
			Me.txtINPos = New Global.System.Windows.Forms.TextBox()
			Me.txtMDPos = New Global.System.Windows.Forms.TextBox()
			Me.lblName = New Global.System.Windows.Forms.Label()
			Me.lblColumn = New Global.System.Windows.Forms.Label()
			Me.rbtMetric = New Global.System.Windows.Forms.RadioButton()
			Me.rbtEnglish = New Global.System.Windows.Forms.RadioButton()
			Me.lblUnits = New Global.System.Windows.Forms.Label()
			Me.txtNumPoints = New Global.System.Windows.Forms.TextBox()
			Me.txtMDRange = New Global.System.Windows.Forms.TextBox()
			Me.txtAZCol = New Global.System.Windows.Forms.TextBox()
			Me.txtINCol = New Global.System.Windows.Forms.TextBox()
			Me.txtMDCol = New Global.System.Windows.Forms.TextBox()
			Me.lblNumPoints = New Global.System.Windows.Forms.Label()
			Me.lblRange = New Global.System.Windows.Forms.Label()
			Me.lblAZCol = New Global.System.Windows.Forms.Label()
			Me.lblINCol = New Global.System.Windows.Forms.Label()
			Me.lblMDCol = New Global.System.Windows.Forms.Label()
			Me.grpScreen_3 = New Global.System.Windows.Forms.GroupBox()
			Me.rtbScreen_3 = New Global.System.Windows.Forms.RichTextBox()
			Me.lblScreen_3 = New Global.System.Windows.Forms.Label()
			Me.txtCode = New Global.System.Windows.Forms.TextBox()
			Me.lblCode = New Global.System.Windows.Forms.Label()
			Me.pnlScreen_1 = New Global.System.Windows.Forms.Panel()
			Me.grpScreen_1 = New Global.System.Windows.Forms.GroupBox()
			Me.rtbScreen_1 = New Global.System.Windows.Forms.RichTextBox()
			Me.txtExcel = New Global.System.Windows.Forms.TextBox()
			Me.cmdBrowse_0 = New Global.System.Windows.Forms.Button()
			Me.lblExcel = New Global.System.Windows.Forms.Label()
			Me.lblScreen_1 = New Global.System.Windows.Forms.Label()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.cmdNext = New Global.System.Windows.Forms.Button()
			Me.cmdBack = New Global.System.Windows.Forms.Button()
			Me.Line1 = New Global.System.Windows.Forms.Label()
			Me.lblCaption = New Global.System.Windows.Forms.Label()
			Me.pnlScreen_2 = New Global.System.Windows.Forms.Panel()
			Me.cboWB = New Global.System.Windows.Forms.ComboBox()
			Me.lblWB_Step2 = New Global.System.Windows.Forms.Label()
			Me.cboSpreadSheets = New Global.System.Windows.Forms.ComboBox()
			Me.lblSS_Step2 = New Global.System.Windows.Forms.Label()
			Me.grpScreen_2 = New Global.System.Windows.Forms.GroupBox()
			Me.rtbScreen_2 = New Global.System.Windows.Forms.RichTextBox()
			Me.lblScreen_2 = New Global.System.Windows.Forms.Label()
			Me.pnlScreen_4 = New Global.System.Windows.Forms.Panel()
			Me.grpScreen_4 = New Global.System.Windows.Forms.GroupBox()
			Me.rtbScreen_4 = New Global.System.Windows.Forms.RichTextBox()
			Me.lblScreen_4 = New Global.System.Windows.Forms.Label()
			Me.pnlScreen_5 = New Global.System.Windows.Forms.Panel()
			Me.grpScreen_5 = New Global.System.Windows.Forms.GroupBox()
			Me.rtbScreen_5 = New Global.System.Windows.Forms.RichTextBox()
			Me.lblScreen_5 = New Global.System.Windows.Forms.Label()
			Me.pnlScreen_6 = New Global.System.Windows.Forms.Panel()
			Me.lblScreen_6 = New Global.System.Windows.Forms.Label()
			Me.pnlScreen_0 = New Global.System.Windows.Forms.Panel()
			Me.grpScreen_0 = New Global.System.Windows.Forms.GroupBox()
			Me.rtbScreen_0 = New Global.System.Windows.Forms.RichTextBox()
			Me.lblScreen_0 = New Global.System.Windows.Forms.Label()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.lblWait = New Global.System.Windows.Forms.Label()
			Me.Picture1 = New Global.System.Windows.Forms.PictureBox()
			Me.tmrClock = New Global.System.Windows.Forms.Timer(Me.components)
			Me.pnlScreen_3.SuspendLayout()
			Me.grpScreen_3.SuspendLayout()
			Me.pnlScreen_1.SuspendLayout()
			Me.grpScreen_1.SuspendLayout()
			Me.pnlScreen_2.SuspendLayout()
			Me.grpScreen_2.SuspendLayout()
			Me.pnlScreen_4.SuspendLayout()
			Me.grpScreen_4.SuspendLayout()
			Me.pnlScreen_5.SuspendLayout()
			Me.grpScreen_5.SuspendLayout()
			Me.pnlScreen_6.SuspendLayout()
			Me.pnlScreen_0.SuspendLayout()
			Me.grpScreen_0.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			CType(Me.Picture1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.pnlScreen_3.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlScreen_3.Controls.Add(Me.lblWorkbook)
			Me.pnlScreen_3.Controls.Add(Me.lblSpreadSheet)
			Me.pnlScreen_3.Controls.Add(Me.lblSurveyType)
			Me.pnlScreen_3.Controls.Add(Me.txtAZRange)
			Me.pnlScreen_3.Controls.Add(Me.txtINRange)
			Me.pnlScreen_3.Controls.Add(Me.lblPosition)
			Me.pnlScreen_3.Controls.Add(Me.txtAZPos)
			Me.pnlScreen_3.Controls.Add(Me.txtINPos)
			Me.pnlScreen_3.Controls.Add(Me.txtMDPos)
			Me.pnlScreen_3.Controls.Add(Me.lblName)
			Me.pnlScreen_3.Controls.Add(Me.lblColumn)
			Me.pnlScreen_3.Controls.Add(Me.rbtMetric)
			Me.pnlScreen_3.Controls.Add(Me.rbtEnglish)
			Me.pnlScreen_3.Controls.Add(Me.lblUnits)
			Me.pnlScreen_3.Controls.Add(Me.txtNumPoints)
			Me.pnlScreen_3.Controls.Add(Me.txtMDRange)
			Me.pnlScreen_3.Controls.Add(Me.txtAZCol)
			Me.pnlScreen_3.Controls.Add(Me.txtINCol)
			Me.pnlScreen_3.Controls.Add(Me.txtMDCol)
			Me.pnlScreen_3.Controls.Add(Me.lblNumPoints)
			Me.pnlScreen_3.Controls.Add(Me.lblRange)
			Me.pnlScreen_3.Controls.Add(Me.lblAZCol)
			Me.pnlScreen_3.Controls.Add(Me.lblINCol)
			Me.pnlScreen_3.Controls.Add(Me.lblMDCol)
			Me.pnlScreen_3.Controls.Add(Me.grpScreen_3)
			Me.pnlScreen_3.Controls.Add(Me.lblScreen_3)
			Me.pnlScreen_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlScreen_3.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlScreen_3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim pnlScreen_ As Global.System.Windows.Forms.Control = Me.pnlScreen_3
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(-1111, 48)
			pnlScreen_.Location = location
			Me.pnlScreen_3.Name = "pnlScreen_3"
			Me.pnlScreen_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim pnlScreen_2 As Global.System.Windows.Forms.Control = Me.pnlScreen_3
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(590, 280)
			pnlScreen_2.Size = size
			Me.pnlScreen_3.TabIndex = 36
			Me.pnlScreen_3.TabStop = True
			Me.pnlScreen_3.Visible = False
			Me.lblWorkbook.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblWorkbook As Global.System.Windows.Forms.Control = Me.lblWorkbook
			location = New Global.System.Drawing.Point(336, 80)
			lblWorkbook.Location = location
			Me.lblWorkbook.Name = "lblWorkbook"
			Dim lblWorkbook2 As Global.System.Windows.Forms.Control = Me.lblWorkbook
			size = New Global.System.Drawing.Size(224, 16)
			lblWorkbook2.Size = size
			Me.lblWorkbook.TabIndex = 2876
			Me.lblWorkbook.Text = "Workbook: "
			Me.lblSpreadSheet.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblSpreadSheet As Global.System.Windows.Forms.Control = Me.lblSpreadSheet
			location = New Global.System.Drawing.Point(336, 104)
			lblSpreadSheet.Location = location
			Me.lblSpreadSheet.Name = "lblSpreadSheet"
			Dim lblSpreadSheet2 As Global.System.Windows.Forms.Control = Me.lblSpreadSheet
			size = New Global.System.Drawing.Size(224, 16)
			lblSpreadSheet2.Size = size
			Me.lblSpreadSheet.TabIndex = 2875
			Me.lblSpreadSheet.Text = "Spreadsheet: "
			Me.lblSurveyType.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblSurveyType As Global.System.Windows.Forms.Control = Me.lblSurveyType
			location = New Global.System.Drawing.Point(336, 56)
			lblSurveyType.Location = location
			Me.lblSurveyType.Name = "lblSurveyType"
			Dim lblSurveyType2 As Global.System.Windows.Forms.Control = Me.lblSurveyType
			size = New Global.System.Drawing.Size(216, 16)
			lblSurveyType2.Size = size
			Me.lblSurveyType.TabIndex = 2874
			Me.lblSurveyType.Text = "Survey Type"
			Dim txtAZRange As Global.System.Windows.Forms.Control = Me.txtAZRange
			location = New Global.System.Drawing.Point(256, 136)
			txtAZRange.Location = location
			Me.txtAZRange.Name = "txtAZRange"
			Dim txtAZRange2 As Global.System.Windows.Forms.Control = Me.txtAZRange
			size = New Global.System.Drawing.Size(64, 20)
			txtAZRange2.Size = size
			Me.txtAZRange.TabIndex = 2873
			Dim txtINRange As Global.System.Windows.Forms.Control = Me.txtINRange
			location = New Global.System.Drawing.Point(256, 112)
			txtINRange.Location = location
			Me.txtINRange.Name = "txtINRange"
			Dim txtINRange2 As Global.System.Windows.Forms.Control = Me.txtINRange
			size = New Global.System.Drawing.Size(64, 20)
			txtINRange2.Size = size
			Me.txtINRange.TabIndex = 2872
			Me.lblPosition.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblPosition As Global.System.Windows.Forms.Control = Me.lblPosition
			location = New Global.System.Drawing.Point(208, 64)
			lblPosition.Location = location
			Me.lblPosition.Name = "lblPosition"
			Dim lblPosition2 As Global.System.Windows.Forms.Control = Me.lblPosition
			size = New Global.System.Drawing.Size(48, 16)
			lblPosition2.Size = size
			Me.lblPosition.TabIndex = 2871
			Me.lblPosition.Text = "Number"
			Dim txtAZPos As Global.System.Windows.Forms.Control = Me.txtAZPos
			location = New Global.System.Drawing.Point(208, 136)
			txtAZPos.Location = location
			Me.txtAZPos.Name = "txtAZPos"
			Dim txtAZPos2 As Global.System.Windows.Forms.Control = Me.txtAZPos
			size = New Global.System.Drawing.Size(48, 20)
			txtAZPos2.Size = size
			Me.txtAZPos.TabIndex = 2870
			Dim txtINPos As Global.System.Windows.Forms.Control = Me.txtINPos
			location = New Global.System.Drawing.Point(208, 112)
			txtINPos.Location = location
			Me.txtINPos.Name = "txtINPos"
			Dim txtINPos2 As Global.System.Windows.Forms.Control = Me.txtINPos
			size = New Global.System.Drawing.Size(48, 20)
			txtINPos2.Size = size
			Me.txtINPos.TabIndex = 2869
			Dim txtMDPos As Global.System.Windows.Forms.Control = Me.txtMDPos
			location = New Global.System.Drawing.Point(208, 88)
			txtMDPos.Location = location
			Me.txtMDPos.Name = "txtMDPos"
			Dim txtMDPos2 As Global.System.Windows.Forms.Control = Me.txtMDPos
			size = New Global.System.Drawing.Size(48, 20)
			txtMDPos2.Size = size
			Me.txtMDPos.TabIndex = 2868
			Me.lblName.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblName As Global.System.Windows.Forms.Control = Me.lblName
			location = New Global.System.Drawing.Point(96, 64)
			lblName.Location = location
			Me.lblName.Name = "lblName"
			Dim lblName2 As Global.System.Windows.Forms.Control = Me.lblName
			size = New Global.System.Drawing.Size(104, 16)
			lblName2.Size = size
			Me.lblName.TabIndex = 2867
			Me.lblName.Text = "Name"
			Me.lblColumn.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblColumn As Global.System.Windows.Forms.Control = Me.lblColumn
			location = New Global.System.Drawing.Point(8, 64)
			lblColumn.Location = location
			Me.lblColumn.Name = "lblColumn"
			Dim lblColumn2 As Global.System.Windows.Forms.Control = Me.lblColumn
			size = New Global.System.Drawing.Size(88, 16)
			lblColumn2.Size = size
			Me.lblColumn.TabIndex = 2866
			Me.lblColumn.Text = "Column"
			Me.rbtMetric.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtMetric As Global.System.Windows.Forms.Control = Me.rbtMetric
			location = New Global.System.Drawing.Point(448, 168)
			rbtMetric.Location = location
			Me.rbtMetric.Name = "rbtMetric"
			Dim rbtMetric2 As Global.System.Windows.Forms.Control = Me.rbtMetric
			size = New Global.System.Drawing.Size(56, 16)
			rbtMetric2.Size = size
			Me.rbtMetric.TabIndex = 2865
			Me.rbtMetric.Text = "Metric"
			Me.rbtEnglish.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtEnglish As Global.System.Windows.Forms.Control = Me.rbtEnglish
			location = New Global.System.Drawing.Point(392, 168)
			rbtEnglish.Location = location
			Me.rbtEnglish.Name = "rbtEnglish"
			Dim rbtEnglish2 As Global.System.Windows.Forms.Control = Me.rbtEnglish
			size = New Global.System.Drawing.Size(64, 16)
			rbtEnglish2.Size = size
			Me.rbtEnglish.TabIndex = 2864
			Me.rbtEnglish.Text = "English"
			Me.lblUnits.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblUnits As Global.System.Windows.Forms.Control = Me.lblUnits
			location = New Global.System.Drawing.Point(336, 152)
			lblUnits.Location = location
			Me.lblUnits.Name = "lblUnits"
			Dim lblUnits2 As Global.System.Windows.Forms.Control = Me.lblUnits
			size = New Global.System.Drawing.Size(104, 16)
			lblUnits2.Size = size
			Me.lblUnits.TabIndex = 2863
			Me.lblUnits.Text = "Measurement Units: "
			Dim txtNumPoints As Global.System.Windows.Forms.Control = Me.txtNumPoints
			location = New Global.System.Drawing.Point(432, 128)
			txtNumPoints.Location = location
			Me.txtNumPoints.Name = "txtNumPoints"
			Dim txtNumPoints2 As Global.System.Windows.Forms.Control = Me.txtNumPoints
			size = New Global.System.Drawing.Size(48, 20)
			txtNumPoints2.Size = size
			Me.txtNumPoints.TabIndex = 2862
			Dim txtMDRange As Global.System.Windows.Forms.Control = Me.txtMDRange
			location = New Global.System.Drawing.Point(256, 88)
			txtMDRange.Location = location
			Me.txtMDRange.Name = "txtMDRange"
			Dim txtMDRange2 As Global.System.Windows.Forms.Control = Me.txtMDRange
			size = New Global.System.Drawing.Size(64, 20)
			txtMDRange2.Size = size
			Me.txtMDRange.TabIndex = 2861
			Dim txtAZCol As Global.System.Windows.Forms.Control = Me.txtAZCol
			location = New Global.System.Drawing.Point(96, 136)
			txtAZCol.Location = location
			Me.txtAZCol.Name = "txtAZCol"
			Dim txtAZCol2 As Global.System.Windows.Forms.Control = Me.txtAZCol
			size = New Global.System.Drawing.Size(112, 20)
			txtAZCol2.Size = size
			Me.txtAZCol.TabIndex = 2860
			Dim txtINCol As Global.System.Windows.Forms.Control = Me.txtINCol
			location = New Global.System.Drawing.Point(96, 112)
			txtINCol.Location = location
			Me.txtINCol.Name = "txtINCol"
			Dim txtINCol2 As Global.System.Windows.Forms.Control = Me.txtINCol
			size = New Global.System.Drawing.Size(112, 20)
			txtINCol2.Size = size
			Me.txtINCol.TabIndex = 2859
			Dim txtMDCol As Global.System.Windows.Forms.Control = Me.txtMDCol
			location = New Global.System.Drawing.Point(96, 88)
			txtMDCol.Location = location
			Me.txtMDCol.Name = "txtMDCol"
			Dim txtMDCol2 As Global.System.Windows.Forms.Control = Me.txtMDCol
			size = New Global.System.Drawing.Size(112, 20)
			txtMDCol2.Size = size
			Me.txtMDCol.TabIndex = 2858
			Me.lblNumPoints.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblNumPoints As Global.System.Windows.Forms.Control = Me.lblNumPoints
			location = New Global.System.Drawing.Point(336, 128)
			lblNumPoints.Location = location
			Me.lblNumPoints.Name = "lblNumPoints"
			Dim lblNumPoints2 As Global.System.Windows.Forms.Control = Me.lblNumPoints
			size = New Global.System.Drawing.Size(96, 16)
			lblNumPoints2.Size = size
			Me.lblNumPoints.TabIndex = 2857
			Me.lblNumPoints.Text = "Number of Points:"
			Me.lblRange.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblRange As Global.System.Windows.Forms.Control = Me.lblRange
			location = New Global.System.Drawing.Point(256, 64)
			lblRange.Location = location
			Me.lblRange.Name = "lblRange"
			Dim lblRange2 As Global.System.Windows.Forms.Control = Me.lblRange
			size = New Global.System.Drawing.Size(64, 16)
			lblRange2.Size = size
			Me.lblRange.TabIndex = 2856
			Me.lblRange.Text = "Data Range"
			Me.lblAZCol.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblAZCol As Global.System.Windows.Forms.Control = Me.lblAZCol
			location = New Global.System.Drawing.Point(8, 136)
			lblAZCol.Location = location
			Me.lblAZCol.Name = "lblAZCol"
			Dim lblAZCol2 As Global.System.Windows.Forms.Control = Me.lblAZCol
			size = New Global.System.Drawing.Size(88, 16)
			lblAZCol2.Size = size
			Me.lblAZCol.TabIndex = 2851
			Me.lblAZCol.Text = "Azimuth:"
			Me.lblINCol.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblINCol As Global.System.Windows.Forms.Control = Me.lblINCol
			location = New Global.System.Drawing.Point(8, 112)
			lblINCol.Location = location
			Me.lblINCol.Name = "lblINCol"
			Dim lblINCol2 As Global.System.Windows.Forms.Control = Me.lblINCol
			size = New Global.System.Drawing.Size(88, 16)
			lblINCol2.Size = size
			Me.lblINCol.TabIndex = 2850
			Me.lblINCol.Text = "Inclination:"
			Me.lblMDCol.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblMDCol As Global.System.Windows.Forms.Control = Me.lblMDCol
			location = New Global.System.Drawing.Point(8, 88)
			lblMDCol.Location = location
			Me.lblMDCol.Name = "lblMDCol"
			Dim lblMDCol2 As Global.System.Windows.Forms.Control = Me.lblMDCol
			size = New Global.System.Drawing.Size(88, 16)
			lblMDCol2.Size = size
			Me.lblMDCol.TabIndex = 2849
			Me.lblMDCol.Text = "Measured Depth: "
			Me.grpScreen_3.Controls.Add(Me.rtbScreen_3)
			Dim grpScreen_ As Global.System.Windows.Forms.Control = Me.grpScreen_3
			location = New Global.System.Drawing.Point(8, 184)
			grpScreen_.Location = location
			Me.grpScreen_3.Name = "grpScreen_3"
			Dim grpScreen_2 As Global.System.Windows.Forms.Control = Me.grpScreen_3
			size = New Global.System.Drawing.Size(512, 88)
			grpScreen_2.Size = size
			Me.grpScreen_3.TabIndex = 2848
			Me.grpScreen_3.TabStop = False
			Me.rtbScreen_3.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim rtbScreen_ As Global.System.Windows.Forms.Control = Me.rtbScreen_3
			location = New Global.System.Drawing.Point(3, 16)
			rtbScreen_.Location = location
			Me.rtbScreen_3.Name = "rtbScreen_3"
			Dim rtbScreen_2 As Global.System.Windows.Forms.Control = Me.rtbScreen_3
			size = New Global.System.Drawing.Size(506, 69)
			rtbScreen_2.Size = size
			Me.rtbScreen_3.TabIndex = 2848
			Me.rtbScreen_3.Text = ""
			Me.lblScreen_3.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblScreen_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblScreen_3.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblScreen_3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblScreen_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblScreen_ As Global.System.Windows.Forms.Control = Me.lblScreen_3
			location = New Global.System.Drawing.Point(10, 8)
			lblScreen_.Location = location
			Me.lblScreen_3.Name = "lblScreen_3"
			Me.lblScreen_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblScreen_2 As Global.System.Windows.Forms.Control = Me.lblScreen_3
			size = New Global.System.Drawing.Size(510, 40)
			lblScreen_2.Size = size
			Me.lblScreen_3.TabIndex = 2846
			Me.lblScreen_3.Text = "lblScreen"
			Me.txtCode.AcceptsReturn = True
			Me.txtCode.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtCode.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtCode.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtCode.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtCode As Global.System.Windows.Forms.Control = Me.txtCode
			location = New Global.System.Drawing.Point(40, 224)
			txtCode.Location = location
			Me.txtCode.MaxLength = 0
			Me.txtCode.Name = "txtCode"
			Me.txtCode.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtCode2 As Global.System.Windows.Forms.Control = Me.txtCode
			size = New Global.System.Drawing.Size(161, 20)
			txtCode2.Size = size
			Me.txtCode.TabIndex = 34
			Me.lblCode.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblCode.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblCode.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblCode.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblCode.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCode As Global.System.Windows.Forms.Control = Me.lblCode
			location = New Global.System.Drawing.Point(32, 208)
			lblCode.Location = location
			Me.lblCode.Name = "lblCode"
			Me.lblCode.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblCode2 As Global.System.Windows.Forms.Control = Me.lblCode
			size = New Global.System.Drawing.Size(97, 17)
			lblCode2.Size = size
			Me.lblCode.TabIndex = 35
			Me.lblCode.Text = "Registration Code:"
			Me.lblCode.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.pnlScreen_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlScreen_1.Controls.Add(Me.grpScreen_1)
			Me.pnlScreen_1.Controls.Add(Me.txtExcel)
			Me.pnlScreen_1.Controls.Add(Me.cmdBrowse_0)
			Me.pnlScreen_1.Controls.Add(Me.lblExcel)
			Me.pnlScreen_1.Controls.Add(Me.lblScreen_1)
			Me.pnlScreen_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlScreen_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlScreen_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim pnlScreen_3 As Global.System.Windows.Forms.Control = Me.pnlScreen_1
			location = New Global.System.Drawing.Point(100, 48)
			pnlScreen_3.Location = location
			Me.pnlScreen_1.Name = "pnlScreen_1"
			Me.pnlScreen_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim pnlScreen_4 As Global.System.Windows.Forms.Control = Me.pnlScreen_1
			size = New Global.System.Drawing.Size(532, 270)
			pnlScreen_4.Size = size
			Me.pnlScreen_1.TabIndex = 13
			Me.pnlScreen_1.TabStop = True
			Me.pnlScreen_1.Visible = False
			Me.grpScreen_1.Controls.Add(Me.rtbScreen_1)
			Dim grpScreen_3 As Global.System.Windows.Forms.Control = Me.grpScreen_1
			location = New Global.System.Drawing.Point(8, 144)
			grpScreen_3.Location = location
			Me.grpScreen_1.Name = "grpScreen_1"
			Dim grpScreen_4 As Global.System.Windows.Forms.Control = Me.grpScreen_1
			size = New Global.System.Drawing.Size(504, 120)
			grpScreen_4.Size = size
			Me.grpScreen_1.TabIndex = 2862
			Me.grpScreen_1.TabStop = False
			Me.rtbScreen_1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim rtbScreen_3 As Global.System.Windows.Forms.Control = Me.rtbScreen_1
			location = New Global.System.Drawing.Point(3, 16)
			rtbScreen_3.Location = location
			Me.rtbScreen_1.Name = "rtbScreen_1"
			Dim rtbScreen_4 As Global.System.Windows.Forms.Control = Me.rtbScreen_1
			size = New Global.System.Drawing.Size(498, 101)
			rtbScreen_4.Size = size
			Me.rtbScreen_1.TabIndex = 2848
			Me.rtbScreen_1.Text = ""
			Dim txtExcel As Global.System.Windows.Forms.Control = Me.txtExcel
			location = New Global.System.Drawing.Point(108, 96)
			txtExcel.Location = location
			Me.txtExcel.Name = "txtExcel"
			Dim txtExcel2 As Global.System.Windows.Forms.Control = Me.txtExcel
			size = New Global.System.Drawing.Size(256, 20)
			txtExcel2.Size = size
			Me.txtExcel.TabIndex = 2861
			Me.cmdBrowse_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdBrowse_ As Global.System.Windows.Forms.Control = Me.cmdBrowse_0
			location = New Global.System.Drawing.Point(380, 96)
			cmdBrowse_.Location = location
			Me.cmdBrowse_0.Name = "cmdBrowse_0"
			Dim cmdBrowse_2 As Global.System.Windows.Forms.Control = Me.cmdBrowse_0
			size = New Global.System.Drawing.Size(80, 22)
			cmdBrowse_2.Size = size
			Me.cmdBrowse_0.TabIndex = 2860
			Me.cmdBrowse_0.Text = "Browse..."
			Me.lblExcel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblExcel As Global.System.Windows.Forms.Control = Me.lblExcel
			location = New Global.System.Drawing.Point(8, 96)
			lblExcel.Location = location
			Me.lblExcel.Name = "lblExcel"
			Dim lblExcel2 As Global.System.Windows.Forms.Control = Me.lblExcel
			size = New Global.System.Drawing.Size(104, 20)
			lblExcel2.Size = size
			Me.lblExcel.TabIndex = 2859
			Me.lblExcel.Text = "Excel file (xls,xlsx):"
			Me.lblScreen_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblScreen_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblScreen_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblScreen_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblScreen_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblScreen_3 As Global.System.Windows.Forms.Control = Me.lblScreen_1
			location = New Global.System.Drawing.Point(10, 8)
			lblScreen_3.Location = location
			Me.lblScreen_1.Name = "lblScreen_1"
			Me.lblScreen_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblScreen_4 As Global.System.Windows.Forms.Control = Me.lblScreen_1
			size = New Global.System.Drawing.Size(470, 40)
			lblScreen_4.Size = size
			Me.lblScreen_1.TabIndex = 14
			Me.lblScreen_1.Text = "lblScreen"
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			location = New Global.System.Drawing.Point(480, 344)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(65, 25)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 9
			Me.cmdCancel.Text = "&Cancel"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.cmdNext.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdNext.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdNext.Enabled = False
			Me.cmdNext.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdNext.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdNext.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdNext As Global.System.Windows.Forms.Control = Me.cmdNext
			location = New Global.System.Drawing.Point(408, 344)
			cmdNext.Location = location
			Me.cmdNext.Name = "cmdNext"
			Me.cmdNext.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdNext2 As Global.System.Windows.Forms.Control = Me.cmdNext
			size = New Global.System.Drawing.Size(65, 25)
			cmdNext2.Size = size
			Me.cmdNext.TabIndex = 8
			Me.cmdNext.Text = "&Next   >"
			Me.cmdNext.UseVisualStyleBackColor = False
			Me.cmdBack.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdBack.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdBack.Enabled = False
			Me.cmdBack.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdBack.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdBack.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdBack As Global.System.Windows.Forms.Control = Me.cmdBack
			location = New Global.System.Drawing.Point(336, 344)
			cmdBack.Location = location
			Me.cmdBack.Name = "cmdBack"
			Me.cmdBack.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdBack2 As Global.System.Windows.Forms.Control = Me.cmdBack
			size = New Global.System.Drawing.Size(65, 25)
			cmdBack2.Size = size
			Me.cmdBack.TabIndex = 7
			Me.cmdBack.Text = "<   &Back"
			Me.cmdBack.UseVisualStyleBackColor = False
			Me.cmdBack.Visible = False
			Me.Line1.BackColor = Global.System.Drawing.SystemColors.WindowText
			Me.Line1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim line As Global.System.Windows.Forms.Control = Me.Line1
			location = New Global.System.Drawing.Point(8, 50)
			line.Location = location
			Me.Line1.Name = "Line1"
			Dim line2 As Global.System.Windows.Forms.Control = Me.Line1
			size = New Global.System.Drawing.Size(432, 1)
			line2.Size = size
			Me.Line1.TabIndex = 37
			Me.lblCaption.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblCaption.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblCaption.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCaption.ForeColor = Global.System.Drawing.Color.FromArgb(0, 0, 128)
			Me.lblCaption.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCaption As Global.System.Windows.Forms.Control = Me.lblCaption
			location = New Global.System.Drawing.Point(8, 8)
			lblCaption.Location = location
			Me.lblCaption.Name = "lblCaption"
			Me.lblCaption.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblCaption2 As Global.System.Windows.Forms.Control = Me.lblCaption
			size = New Global.System.Drawing.Size(512, 32)
			lblCaption2.Size = size
			Me.lblCaption.TabIndex = 38
			Me.lblCaption.Text = "lblCaption"
			Me.pnlScreen_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlScreen_2.Controls.Add(Me.cboWB)
			Me.pnlScreen_2.Controls.Add(Me.lblWB_Step2)
			Me.pnlScreen_2.Controls.Add(Me.cboSpreadSheets)
			Me.pnlScreen_2.Controls.Add(Me.lblSS_Step2)
			Me.pnlScreen_2.Controls.Add(Me.grpScreen_2)
			Me.pnlScreen_2.Controls.Add(Me.lblScreen_2)
			Me.pnlScreen_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlScreen_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlScreen_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim pnlScreen_5 As Global.System.Windows.Forms.Control = Me.pnlScreen_2
			location = New Global.System.Drawing.Point(-1111, 64)
			pnlScreen_5.Location = location
			Me.pnlScreen_2.Name = "pnlScreen_2"
			Me.pnlScreen_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim pnlScreen_6 As Global.System.Windows.Forms.Control = Me.pnlScreen_2
			size = New Global.System.Drawing.Size(545, 265)
			pnlScreen_6.Size = size
			Me.pnlScreen_2.TabIndex = 40
			Me.pnlScreen_2.TabStop = True
			Me.pnlScreen_2.Visible = False
			Me.cboWB.ItemHeight = 14
			Dim cboWB As Global.System.Windows.Forms.Control = Me.cboWB
			location = New Global.System.Drawing.Point(232, 62)
			cboWB.Location = location
			Me.cboWB.Name = "cboWB"
			Dim cboWB2 As Global.System.Windows.Forms.Control = Me.cboWB
			size = New Global.System.Drawing.Size(192, 22)
			cboWB2.Size = size
			Me.cboWB.TabIndex = 2851
			Me.lblWB_Step2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblWB_Step As Global.System.Windows.Forms.Control = Me.lblWB_Step2
			location = New Global.System.Drawing.Point(24, 62)
			lblWB_Step.Location = location
			Me.lblWB_Step2.Name = "lblWB_Step2"
			Dim lblWB_Step2 As Global.System.Windows.Forms.Control = Me.lblWB_Step2
			size = New Global.System.Drawing.Size(208, 16)
			lblWB_Step2.Size = size
			Me.lblWB_Step2.TabIndex = 2850
			Me.lblWB_Step2.Text = "Workbooks in File::"
			Me.cboSpreadSheets.ItemHeight = 14
			Dim cboSpreadSheets As Global.System.Windows.Forms.Control = Me.cboSpreadSheets
			location = New Global.System.Drawing.Point(232, 88)
			cboSpreadSheets.Location = location
			Me.cboSpreadSheets.Name = "cboSpreadSheets"
			Dim cboSpreadSheets2 As Global.System.Windows.Forms.Control = Me.cboSpreadSheets
			size = New Global.System.Drawing.Size(192, 22)
			cboSpreadSheets2.Size = size
			Me.cboSpreadSheets.TabIndex = 2849
			Me.lblSS_Step2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblSS_Step As Global.System.Windows.Forms.Control = Me.lblSS_Step2
			location = New Global.System.Drawing.Point(24, 88)
			lblSS_Step.Location = location
			Me.lblSS_Step2.Name = "lblSS_Step2"
			Dim lblSS_Step2 As Global.System.Windows.Forms.Control = Me.lblSS_Step2
			size = New Global.System.Drawing.Size(208, 16)
			lblSS_Step2.Size = size
			Me.lblSS_Step2.TabIndex = 2848
			Me.lblSS_Step2.Text = "Speadsheets in Workbook:"
			Me.grpScreen_2.Controls.Add(Me.rtbScreen_2)
			Dim grpScreen_5 As Global.System.Windows.Forms.Control = Me.grpScreen_2
			location = New Global.System.Drawing.Point(8, 152)
			grpScreen_5.Location = location
			Me.grpScreen_2.Name = "grpScreen_2"
			Dim grpScreen_6 As Global.System.Windows.Forms.Control = Me.grpScreen_2
			size = New Global.System.Drawing.Size(512, 72)
			grpScreen_6.Size = size
			Me.grpScreen_2.TabIndex = 2847
			Me.grpScreen_2.TabStop = False
			Me.rtbScreen_2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim rtbScreen_5 As Global.System.Windows.Forms.Control = Me.rtbScreen_2
			location = New Global.System.Drawing.Point(3, 16)
			rtbScreen_5.Location = location
			Me.rtbScreen_2.Name = "rtbScreen_2"
			Dim rtbScreen_6 As Global.System.Windows.Forms.Control = Me.rtbScreen_2
			size = New Global.System.Drawing.Size(506, 53)
			rtbScreen_6.Size = size
			Me.rtbScreen_2.TabIndex = 2848
			Me.rtbScreen_2.Text = ""
			Me.lblScreen_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblScreen_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblScreen_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblScreen_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblScreen_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblScreen_5 As Global.System.Windows.Forms.Control = Me.lblScreen_2
			location = New Global.System.Drawing.Point(10, 8)
			lblScreen_5.Location = location
			Me.lblScreen_2.Name = "lblScreen_2"
			Me.lblScreen_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblScreen_6 As Global.System.Windows.Forms.Control = Me.lblScreen_2
			size = New Global.System.Drawing.Size(494, 40)
			lblScreen_6.Size = size
			Me.lblScreen_2.TabIndex = 2846
			Me.lblScreen_2.Text = "lblScreen"
			Me.pnlScreen_4.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlScreen_4.Controls.Add(Me.grpScreen_4)
			Me.pnlScreen_4.Controls.Add(Me.lblScreen_4)
			Me.pnlScreen_4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlScreen_4.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlScreen_4.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim pnlScreen_7 As Global.System.Windows.Forms.Control = Me.pnlScreen_4
			location = New Global.System.Drawing.Point(-1111, 77)
			pnlScreen_7.Location = location
			Me.pnlScreen_4.Name = "pnlScreen_4"
			Me.pnlScreen_4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim pnlScreen_8 As Global.System.Windows.Forms.Control = Me.pnlScreen_4
			size = New Global.System.Drawing.Size(554, 250)
			pnlScreen_8.Size = size
			Me.pnlScreen_4.TabIndex = 41
			Me.pnlScreen_4.TabStop = True
			Me.pnlScreen_4.Visible = False
			Me.grpScreen_4.Controls.Add(Me.rtbScreen_4)
			Dim grpScreen_7 As Global.System.Windows.Forms.Control = Me.grpScreen_4
			location = New Global.System.Drawing.Point(8, 37)
			grpScreen_7.Location = location
			Me.grpScreen_4.Name = "grpScreen_4"
			Dim grpScreen_8 As Global.System.Windows.Forms.Control = Me.grpScreen_4
			size = New Global.System.Drawing.Size(456, 199)
			grpScreen_8.Size = size
			Me.grpScreen_4.TabIndex = 2849
			Me.grpScreen_4.TabStop = False
			Me.rtbScreen_4.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim rtbScreen_7 As Global.System.Windows.Forms.Control = Me.rtbScreen_4
			location = New Global.System.Drawing.Point(3, 16)
			rtbScreen_7.Location = location
			Me.rtbScreen_4.Name = "rtbScreen_4"
			Dim rtbScreen_8 As Global.System.Windows.Forms.Control = Me.rtbScreen_4
			size = New Global.System.Drawing.Size(450, 180)
			rtbScreen_8.Size = size
			Me.rtbScreen_4.TabIndex = 2848
			Me.rtbScreen_4.Text = ""
			Me.lblScreen_4.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblScreen_4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblScreen_4.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblScreen_4.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblScreen_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblScreen_7 As Global.System.Windows.Forms.Control = Me.lblScreen_4
			location = New Global.System.Drawing.Point(10, 8)
			lblScreen_7.Location = location
			Me.lblScreen_4.Name = "lblScreen_4"
			Me.lblScreen_4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblScreen_8 As Global.System.Windows.Forms.Control = Me.lblScreen_4
			size = New Global.System.Drawing.Size(414, 32)
			lblScreen_8.Size = size
			Me.lblScreen_4.TabIndex = 2846
			Me.lblScreen_4.Text = "lblScreen"
			Me.pnlScreen_5.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlScreen_5.Controls.Add(Me.grpScreen_5)
			Me.pnlScreen_5.Controls.Add(Me.lblScreen_5)
			Me.pnlScreen_5.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlScreen_5.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlScreen_5.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim pnlScreen_9 As Global.System.Windows.Forms.Control = Me.pnlScreen_5
			location = New Global.System.Drawing.Point(-1111, 82)
			pnlScreen_9.Location = location
			Me.pnlScreen_5.Name = "pnlScreen_5"
			Me.pnlScreen_5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim pnlScreen_10 As Global.System.Windows.Forms.Control = Me.pnlScreen_5
			size = New Global.System.Drawing.Size(554, 250)
			pnlScreen_10.Size = size
			Me.pnlScreen_5.TabIndex = 42
			Me.pnlScreen_5.TabStop = True
			Me.pnlScreen_5.Visible = False
			Me.grpScreen_5.Controls.Add(Me.rtbScreen_5)
			Dim grpScreen_9 As Global.System.Windows.Forms.Control = Me.grpScreen_5
			location = New Global.System.Drawing.Point(8, 41)
			grpScreen_9.Location = location
			Me.grpScreen_5.Name = "grpScreen_5"
			Dim grpScreen_10 As Global.System.Windows.Forms.Control = Me.grpScreen_5
			size = New Global.System.Drawing.Size(456, 199)
			grpScreen_10.Size = size
			Me.grpScreen_5.TabIndex = 2850
			Me.grpScreen_5.TabStop = False
			Me.rtbScreen_5.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim rtbScreen_9 As Global.System.Windows.Forms.Control = Me.rtbScreen_5
			location = New Global.System.Drawing.Point(3, 16)
			rtbScreen_9.Location = location
			Me.rtbScreen_5.Name = "rtbScreen_5"
			Dim rtbScreen_10 As Global.System.Windows.Forms.Control = Me.rtbScreen_5
			size = New Global.System.Drawing.Size(450, 180)
			rtbScreen_10.Size = size
			Me.rtbScreen_5.TabIndex = 2848
			Me.rtbScreen_5.Text = ""
			Me.lblScreen_5.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblScreen_5.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblScreen_5.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblScreen_5.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblScreen_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblScreen_9 As Global.System.Windows.Forms.Control = Me.lblScreen_5
			location = New Global.System.Drawing.Point(10, 8)
			lblScreen_9.Location = location
			Me.lblScreen_5.Name = "lblScreen_5"
			Me.lblScreen_5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblScreen_10 As Global.System.Windows.Forms.Control = Me.lblScreen_5
			size = New Global.System.Drawing.Size(414, 40)
			lblScreen_10.Size = size
			Me.lblScreen_5.TabIndex = 2846
			Me.lblScreen_5.Text = "lblScreen"
			Me.pnlScreen_6.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlScreen_6.Controls.Add(Me.lblScreen_6)
			Me.pnlScreen_6.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlScreen_6.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlScreen_6.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim pnlScreen_11 As Global.System.Windows.Forms.Control = Me.pnlScreen_6
			location = New Global.System.Drawing.Point(-1111, 82)
			pnlScreen_11.Location = location
			Me.pnlScreen_6.Name = "pnlScreen_6"
			Me.pnlScreen_6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim pnlScreen_12 As Global.System.Windows.Forms.Control = Me.pnlScreen_6
			size = New Global.System.Drawing.Size(549, 250)
			pnlScreen_12.Size = size
			Me.pnlScreen_6.TabIndex = 43
			Me.pnlScreen_6.TabStop = True
			Me.pnlScreen_6.Visible = False
			Me.lblScreen_6.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblScreen_6.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblScreen_6.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblScreen_6.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblScreen_6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblScreen_11 As Global.System.Windows.Forms.Control = Me.lblScreen_6
			location = New Global.System.Drawing.Point(10, 8)
			lblScreen_11.Location = location
			Me.lblScreen_6.Name = "lblScreen_6"
			Me.lblScreen_6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblScreen_12 As Global.System.Windows.Forms.Control = Me.lblScreen_6
			size = New Global.System.Drawing.Size(414, 48)
			lblScreen_12.Size = size
			Me.lblScreen_6.TabIndex = 2846
			Me.lblScreen_6.Text = "lblScreen"
			Me.pnlScreen_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlScreen_0.Controls.Add(Me.grpScreen_0)
			Me.pnlScreen_0.Controls.Add(Me.lblScreen_0)
			Me.pnlScreen_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlScreen_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlScreen_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim pnlScreen_13 As Global.System.Windows.Forms.Control = Me.pnlScreen_0
			location = New Global.System.Drawing.Point(-1111, 48)
			pnlScreen_13.Location = location
			Me.pnlScreen_0.Name = "pnlScreen_0"
			Me.pnlScreen_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim pnlScreen_14 As Global.System.Windows.Forms.Control = Me.pnlScreen_0
			size = New Global.System.Drawing.Size(545, 264)
			pnlScreen_14.Size = size
			Me.pnlScreen_0.TabIndex = 46
			Me.pnlScreen_0.TabStop = True
			Me.pnlScreen_0.Visible = False
			Me.grpScreen_0.Controls.Add(Me.rtbScreen_0)
			Dim grpScreen_11 As Global.System.Windows.Forms.Control = Me.grpScreen_0
			location = New Global.System.Drawing.Point(8, 144)
			grpScreen_11.Location = location
			Me.grpScreen_0.Name = "grpScreen_0"
			Dim grpScreen_12 As Global.System.Windows.Forms.Control = Me.grpScreen_0
			size = New Global.System.Drawing.Size(504, 104)
			grpScreen_12.Size = size
			Me.grpScreen_0.TabIndex = 2855
			Me.grpScreen_0.TabStop = False
			Me.rtbScreen_0.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim rtbScreen_11 As Global.System.Windows.Forms.Control = Me.rtbScreen_0
			location = New Global.System.Drawing.Point(3, 16)
			rtbScreen_11.Location = location
			Me.rtbScreen_0.Name = "rtbScreen_0"
			Dim rtbScreen_12 As Global.System.Windows.Forms.Control = Me.rtbScreen_0
			size = New Global.System.Drawing.Size(498, 85)
			rtbScreen_12.Size = size
			Me.rtbScreen_0.TabIndex = 2848
			Me.rtbScreen_0.Text = ""
			Me.lblScreen_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblScreen_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblScreen_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblScreen_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblScreen_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblScreen_13 As Global.System.Windows.Forms.Control = Me.lblScreen_0
			location = New Global.System.Drawing.Point(10, 8)
			lblScreen_13.Location = location
			Me.lblScreen_0.Name = "lblScreen_0"
			Me.lblScreen_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblScreen_14 As Global.System.Windows.Forms.Control = Me.lblScreen_0
			size = New Global.System.Drawing.Size(470, 32)
			lblScreen_14.Size = size
			Me.lblScreen_0.TabIndex = 14
			Me.lblScreen_0.Text = "lblScreen"
			Me.GroupBox1.Controls.Add(Me.lblWait)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(26, 40)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(448, 128)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 2850
			Me.GroupBox1.TabStop = False
			Me.lblWait.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblWait.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblWait.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.lblWait.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblWait.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblWait As Global.System.Windows.Forms.Control = Me.lblWait
			location = New Global.System.Drawing.Point(40, 48)
			lblWait.Location = location
			Me.lblWait.Name = "lblWait"
			Me.lblWait.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblWait2 As Global.System.Windows.Forms.Control = Me.lblWait
			size = New Global.System.Drawing.Size(382, 32)
			lblWait2.Size = size
			Me.lblWait.TabIndex = 2848
			Me.lblWait.Text = "Please wait!  "
			Me.lblWait.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Picture1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Picture1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Picture1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.Picture1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Picture1.Image = CType(componentResourceManager.GetObject("Picture1.Image"), Global.System.Drawing.Image)
			Me.Picture1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim picture As Global.System.Windows.Forms.Control = Me.Picture1
			location = New Global.System.Drawing.Point(16, 56)
			picture.Location = location
			Me.Picture1.Name = "Picture1"
			Me.Picture1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim picture2 As Global.System.Windows.Forms.Control = Me.Picture1
			size = New Global.System.Drawing.Size(32, 32)
			picture2.Size = size
			Me.Picture1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.Picture1.TabIndex = 51
			Me.Picture1.TabStop = False
			Me.tmrClock.Interval = 30000
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(777, 466)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.Picture1)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.cmdNext)
			Me.Controls.Add(Me.cmdBack)
			Me.Controls.Add(Me.Line1)
			Me.Controls.Add(Me.lblCaption)
			Me.Controls.Add(Me.pnlScreen_6)
			Me.Controls.Add(Me.pnlScreen_5)
			Me.Controls.Add(Me.pnlScreen_4)
			Me.Controls.Add(Me.pnlScreen_1)
			Me.Controls.Add(Me.pnlScreen_3)
			Me.Controls.Add(Me.pnlScreen_0)
			Me.Controls.Add(Me.pnlScreen_2)
			Me.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(2, 18)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "frmWizard"
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Data Transfer Wizard"
			Me.TopMost = True
			Me.pnlScreen_3.ResumeLayout(False)
			Me.pnlScreen_3.PerformLayout()
			Me.grpScreen_3.ResumeLayout(False)
			Me.pnlScreen_1.ResumeLayout(False)
			Me.pnlScreen_1.PerformLayout()
			Me.grpScreen_1.ResumeLayout(False)
			Me.pnlScreen_2.ResumeLayout(False)
			Me.grpScreen_2.ResumeLayout(False)
			Me.pnlScreen_4.ResumeLayout(False)
			Me.grpScreen_4.ResumeLayout(False)
			Me.pnlScreen_5.ResumeLayout(False)
			Me.grpScreen_5.ResumeLayout(False)
			Me.pnlScreen_6.ResumeLayout(False)
			Me.pnlScreen_0.ResumeLayout(False)
			Me.grpScreen_0.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			CType(Me.Picture1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
