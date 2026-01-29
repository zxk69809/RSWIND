Namespace RSWINV3
	Friend Partial Class Results
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.Results))
			Dim gradientBackground As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground2 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border2 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable2 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground3 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim titleDockable3 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground4 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim imageBorder As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.RoundedShadow)
			Dim titleDockable4 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground5 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border3 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable5 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground6 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border4 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable6 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground7 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim titleDockable7 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground8 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim titleDockable8 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground9 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border5 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable9 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground10 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border6 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable10 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground11 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border7 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable11 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground12 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border8 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable12 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground13 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border9 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable13 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground14 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border10 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable14 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground15 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border11 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable15 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground16 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border12 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable16 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground17 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border13 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable17 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground18 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border14 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable18 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground19 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border15 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable19 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground20 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border16 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable20 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground21 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border17 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable21 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Dim gradientBackground22 As Global.ChartFX.WinForms.Adornments.GradientBackground = New Global.ChartFX.WinForms.Adornments.GradientBackground()
			Dim border18 As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim titleDockable22 As Global.ChartFX.WinForms.TitleDockable = New Global.ChartFX.WinForms.TitleDockable()
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdClose = New Global.System.Windows.Forms.Button()
			Me.tbbRun = New Global.System.Windows.Forms.Button()
			Me.tbbStep = New Global.System.Windows.Forms.Button()
			Me.tbbStop = New Global.System.Windows.Forms.Button()
			Me.tbbRunPause = New Global.System.Windows.Forms.Button()
			Me.btnResetPlot = New Global.System.Windows.Forms.Button()
			Me.picScrollBarTip = New Global.System.Windows.Forms.PictureBox()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.pnlActiveReport = New Global.System.Windows.Forms.Panel()
			Me.pnlScrollBar = New Global.System.Windows.Forms.Panel()
			Me.VScroll = New Global.System.Windows.Forms.VScrollBar()
			Me.Viewer1 = New Global.DataDynamics.ActiveReports.Viewer.Viewer()
			Me.pnlTabs = New Global.System.Windows.Forms.Panel()
			Me.btnImplement = New Global.System.Windows.Forms.RadioButton()
			Me.lblPoint = New Global.System.Windows.Forms.Label()
			Me.btnCoverPageComments = New Global.System.Windows.Forms.Button()
			Me.btnDevCharts = New Global.System.Windows.Forms.Button()
			Me.cmdIPRPlot = New Global.System.Windows.Forms.Button()
			Me._optReport_3 = New Global.System.Windows.Forms.RadioButton()
			Me._optReport_2 = New Global.System.Windows.Forms.RadioButton()
			Me._optReport_1 = New Global.System.Windows.Forms.RadioButton()
			Me._optReport_0 = New Global.System.Windows.Forms.RadioButton()
			Me.lblAnimateDyno = New Global.System.Windows.Forms.Label()
			Me.TrackBar1 = New Global.System.Windows.Forms.TrackBar()
			Me.optNextDevChart = New Global.System.Windows.Forms.Button()
			Me.optPrevDevChart = New Global.System.Windows.Forms.Button()
			Me.pnlDyno = New Global.System.Windows.Forms.Panel()
			Me.ChartFX_Dyno = New Global.ChartFX.WinForms.Chart()
			Me.pnlTorquePlot = New Global.System.Windows.Forms.Panel()
			Me.ChartFX_TorquePlot = New Global.ChartFX.WinForms.Chart()
			Me.pnlTempChart = New Global.System.Windows.Forms.Panel()
			Me.ChartFX_Temp_TorquePlot = New Global.ChartFX.WinForms.Chart()
			Me.ChartFX_Temp_Dyno = New Global.ChartFX.WinForms.Chart()
			Me.pnlTempChart2 = New Global.System.Windows.Forms.Panel()
			Me.ChartFX_Temp_Torque_L = New Global.ChartFX.WinForms.Chart()
			Me.ChartFX_Temp_Dyno_L = New Global.ChartFX.WinForms.Chart()
			Me.ChartFX_Temp_Dyno_XL = New Global.ChartFX.WinForms.Chart()
			Me.ChartFX_Temp_Torque_XL = New Global.ChartFX.WinForms.Chart()
			Me.pnlDeviation = New Global.System.Windows.Forms.Panel()
			Me.chtDoglegs = New Global.ChartFX.WinForms.Chart()
			Me.chtSurveyPlan = New Global.ChartFX.WinForms.Chart()
			Me.chtSurveyNS = New Global.ChartFX.WinForms.Chart()
			Me.chtSurveyEW = New Global.ChartFX.WinForms.Chart()
			Me.chtSideForces = New Global.ChartFX.WinForms.Chart()
			Me.chtBucklingTendency = New Global.ChartFX.WinForms.Chart()
			Me.chtAxialLoads = New Global.ChartFX.WinForms.Chart()
			Me.pnlDevCharts = New Global.System.Windows.Forms.Panel()
			Me.pnlGrpDevPlot = New Global.System.Windows.Forms.Panel()
			Me.pnlLegend = New Global.System.Windows.Forms.Panel()
			Me.pnlLegend2 = New Global.System.Windows.Forms.Panel()
			Me.lblNumGuidesPerRod2 = New Global.System.Windows.Forms.Label()
			Me.lblDiameters2 = New Global.System.Windows.Forms.Label()
			Me.G20 = New Global.System.Windows.Forms.Label()
			Me.G19 = New Global.System.Windows.Forms.Label()
			Me.G18 = New Global.System.Windows.Forms.Label()
			Me.G17 = New Global.System.Windows.Forms.Label()
			Me.G16 = New Global.System.Windows.Forms.Label()
			Me.G15 = New Global.System.Windows.Forms.Label()
			Me.G14 = New Global.System.Windows.Forms.Label()
			Me.G13 = New Global.System.Windows.Forms.Label()
			Me.G12 = New Global.System.Windows.Forms.Label()
			Me.G11 = New Global.System.Windows.Forms.Label()
			Me.lblNumGuidesPerRod = New Global.System.Windows.Forms.Label()
			Me.G10 = New Global.System.Windows.Forms.Label()
			Me.G9 = New Global.System.Windows.Forms.Label()
			Me.G8 = New Global.System.Windows.Forms.Label()
			Me.G7 = New Global.System.Windows.Forms.Label()
			Me.G6 = New Global.System.Windows.Forms.Label()
			Me.G5 = New Global.System.Windows.Forms.Label()
			Me.G4 = New Global.System.Windows.Forms.Label()
			Me.G3 = New Global.System.Windows.Forms.Label()
			Me.G2 = New Global.System.Windows.Forms.Label()
			Me.G1 = New Global.System.Windows.Forms.Label()
			Me.lblDiameters = New Global.System.Windows.Forms.Label()
			Me.T20 = New Global.System.Windows.Forms.Label()
			Me.T19 = New Global.System.Windows.Forms.Label()
			Me.T18 = New Global.System.Windows.Forms.Label()
			Me.T17 = New Global.System.Windows.Forms.Label()
			Me.T16 = New Global.System.Windows.Forms.Label()
			Me.T15 = New Global.System.Windows.Forms.Label()
			Me.T14 = New Global.System.Windows.Forms.Label()
			Me.T13 = New Global.System.Windows.Forms.Label()
			Me.T12 = New Global.System.Windows.Forms.Label()
			Me.T11 = New Global.System.Windows.Forms.Label()
			Me.T10 = New Global.System.Windows.Forms.Label()
			Me.T9 = New Global.System.Windows.Forms.Label()
			Me.T8 = New Global.System.Windows.Forms.Label()
			Me.T7 = New Global.System.Windows.Forms.Label()
			Me.T6 = New Global.System.Windows.Forms.Label()
			Me.T5 = New Global.System.Windows.Forms.Label()
			Me.T4 = New Global.System.Windows.Forms.Label()
			Me.T3 = New Global.System.Windows.Forms.Label()
			Me.T2 = New Global.System.Windows.Forms.Label()
			Me.T1 = New Global.System.Windows.Forms.Label()
			Me.VScrollBar1 = New Global.System.Windows.Forms.VScrollBar()
			Me.pnlCommander = New Global.System.Windows.Forms.Panel()
			Me.commander1 = New Global.Steema.TeeChart.Commander()
			Me.TChart1 = New Global.Steema.TeeChart.TChart()
			Me.point3DSeries1 = New Global.Steema.TeeChart.Styles.Points3D()
			Me.point3DSeries2 = New Global.Steema.TeeChart.Styles.Points3D()
			Me.MarksTip1 = New Global.Steema.TeeChart.Tools.MarksTip()
			Me.pnlDevPlot = New Global.System.Windows.Forms.Panel()
			Me.lblNoData = New Global.System.Windows.Forms.Label()
			Me.ChartFX_LookingNorth = New Global.ChartFX.WinForms.Chart()
			Me.ChartFX_SideLoading = New Global.ChartFX.WinForms.Chart()
			Me.ChartFX_BucklingTendency = New Global.ChartFX.WinForms.Chart()
			Me.ChartFX_AxialLoads = New Global.ChartFX.WinForms.Chart()
			Me.ChartFX_DoglegSeverity = New Global.ChartFX.WinForms.Chart()
			Me.ChartFX_LookingDown = New Global.ChartFX.WinForms.Chart()
			Me.ChartFX_LookingEast = New Global.ChartFX.WinForms.Chart()
			Me.btnPrevDevChart = New Global.System.Windows.Forms.Button()
			Me.btnNextDevChart = New Global.System.Windows.Forms.Button()
			Me.point3DSeries1_report = New Global.Steema.TeeChart.Styles.Points3D()
			Me.point3DSeries2_report = New Global.Steema.TeeChart.Styles.Points3D()
			Me.timAnimate = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.optReport = New Global.Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
			Me.picOutput = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.ContextMenu1 = New Global.System.Windows.Forms.ContextMenu()
			Me.ctxMenu_DynoPlot = New Global.System.Windows.Forms.ContextMenu()
			Me.PdfExport1 = New Global.DataDynamics.ActiveReports.Export.Pdf.PdfExport()
			Me.pnl3DReport = New Global.System.Windows.Forms.Panel()
			Me.TChart1_Report = New Global.Steema.TeeChart.TChart()
			CType(Me.picScrollBarTip, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlActiveReport.SuspendLayout()
			Me.pnlScrollBar.SuspendLayout()
			Me.pnlTabs.SuspendLayout()
			CType(Me.TrackBar1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlDyno.SuspendLayout()
			CType(Me.ChartFX_Dyno, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlTorquePlot.SuspendLayout()
			CType(Me.ChartFX_TorquePlot, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlTempChart.SuspendLayout()
			CType(Me.ChartFX_Temp_TorquePlot, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ChartFX_Temp_Dyno, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlTempChart2.SuspendLayout()
			CType(Me.ChartFX_Temp_Torque_L, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ChartFX_Temp_Dyno_L, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ChartFX_Temp_Dyno_XL, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ChartFX_Temp_Torque_XL, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlDeviation.SuspendLayout()
			CType(Me.chtDoglegs, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chtSurveyPlan, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chtSurveyNS, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chtSurveyEW, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chtSideForces, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chtBucklingTendency, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chtAxialLoads, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlDevCharts.SuspendLayout()
			Me.pnlGrpDevPlot.SuspendLayout()
			Me.pnlLegend.SuspendLayout()
			Me.pnlLegend2.SuspendLayout()
			Me.pnlCommander.SuspendLayout()
			Me.pnlDevPlot.SuspendLayout()
			CType(Me.ChartFX_LookingNorth, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ChartFX_SideLoading, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ChartFX_BucklingTendency, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ChartFX_AxialLoads, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ChartFX_DoglegSeverity, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ChartFX_LookingDown, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ChartFX_LookingEast, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.optReport, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.picOutput, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnl3DReport.SuspendLayout()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.cmdClose.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdClose.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdClose.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdClose.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdClose.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdClose As Global.System.Windows.Forms.Control = Me.cmdClose
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(753, 13)
			cmdClose.Location = location
			Me.cmdClose.Name = "cmdClose"
			Me.cmdClose.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdClose2 As Global.System.Windows.Forms.Control = Me.cmdClose
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(64, 22)
			cmdClose2.Size = size
			Me.cmdClose.TabIndex = 12
			Me.cmdClose.Text = "&Close"
			Me.ToolTip1.SetToolTip(Me.cmdClose, "Close report window")
			Me.cmdClose.UseVisualStyleBackColor = False
			Me.tbbRun.BackColor = Global.System.Drawing.SystemColors.Control
			Me.tbbRun.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.tbbRun.Enabled = False
			Me.tbbRun.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.tbbRun.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.tbbRun.Image = CType(componentResourceManager.GetObject("tbbRun.Image"), Global.System.Drawing.Image)
			Me.tbbRun.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim tbbRun As Global.System.Windows.Forms.Control = Me.tbbRun
			location = New Global.System.Drawing.Point(585, 15)
			tbbRun.Location = location
			Me.tbbRun.Name = "tbbRun"
			Me.tbbRun.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim tbbRun2 As Global.System.Windows.Forms.Control = Me.tbbRun
			size = New Global.System.Drawing.Size(24, 22)
			tbbRun2.Size = size
			Me.tbbRun.TabIndex = 14
			Me.tbbRun.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.tbbRun, "Start dyno. card animation")
			Me.tbbRun.UseVisualStyleBackColor = False
			Me.tbbStep.BackColor = Global.System.Drawing.SystemColors.Control
			Me.tbbStep.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.tbbStep.Enabled = False
			Me.tbbStep.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.tbbStep.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.tbbStep.Image = CType(componentResourceManager.GetObject("tbbStep.Image"), Global.System.Drawing.Image)
			Me.tbbStep.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim tbbStep As Global.System.Windows.Forms.Control = Me.tbbStep
			location = New Global.System.Drawing.Point(633, 15)
			tbbStep.Location = location
			Me.tbbStep.Name = "tbbStep"
			Me.tbbStep.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim tbbStep2 As Global.System.Windows.Forms.Control = Me.tbbStep
			size = New Global.System.Drawing.Size(24, 22)
			tbbStep2.Size = size
			Me.tbbStep.TabIndex = 15
			Me.tbbStep.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.tbbStep, "Single-step dyno. card animation")
			Me.tbbStep.UseVisualStyleBackColor = False
			Me.tbbStop.BackColor = Global.System.Drawing.SystemColors.Control
			Me.tbbStop.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.tbbStop.Enabled = False
			Me.tbbStop.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.tbbStop.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.tbbStop.Image = CType(componentResourceManager.GetObject("tbbStop.Image"), Global.System.Drawing.Image)
			Me.tbbStop.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim tbbStop As Global.System.Windows.Forms.Control = Me.tbbStop
			location = New Global.System.Drawing.Point(609, 15)
			tbbStop.Location = location
			Me.tbbStop.Name = "tbbStop"
			Me.tbbStop.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim tbbStop2 As Global.System.Windows.Forms.Control = Me.tbbStop
			size = New Global.System.Drawing.Size(24, 22)
			tbbStop2.Size = size
			Me.tbbStop.TabIndex = 16
			Me.tbbStop.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.tbbStop, "Stop dyno. card animation")
			Me.tbbStop.UseVisualStyleBackColor = False
			Me.tbbRunPause.BackColor = Global.System.Drawing.SystemColors.Control
			Me.tbbRunPause.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.tbbRunPause.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.tbbRunPause.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.tbbRunPause.Image = CType(componentResourceManager.GetObject("tbbRunPause.Image"), Global.System.Drawing.Image)
			Me.tbbRunPause.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim tbbRunPause As Global.System.Windows.Forms.Control = Me.tbbRunPause
			location = New Global.System.Drawing.Point(585, 15)
			tbbRunPause.Location = location
			Me.tbbRunPause.Name = "tbbRunPause"
			Me.tbbRunPause.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim tbbRunPause2 As Global.System.Windows.Forms.Control = Me.tbbRunPause
			size = New Global.System.Drawing.Size(24, 22)
			tbbRunPause2.Size = size
			Me.tbbRunPause.TabIndex = 24
			Me.tbbRunPause.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.ToolTip1.SetToolTip(Me.tbbRunPause, "Pause dyno. card animation")
			Me.tbbRunPause.UseVisualStyleBackColor = False
			Me.btnResetPlot.Image = CType(componentResourceManager.GetObject("btnResetPlot.Image"), Global.System.Drawing.Image)
			Me.btnResetPlot.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnResetPlot As Global.System.Windows.Forms.Control = Me.btnResetPlot
			location = New Global.System.Drawing.Point(563, 4)
			btnResetPlot.Location = location
			Me.btnResetPlot.Name = "btnResetPlot"
			Dim btnResetPlot2 As Global.System.Windows.Forms.Control = Me.btnResetPlot
			size = New Global.System.Drawing.Size(24, 24)
			btnResetPlot2.Size = size
			Me.btnResetPlot.TabIndex = 12
			Me.ToolTip1.SetToolTip(Me.btnResetPlot, "Reset Deviation Survey Plot")
			Me.picScrollBarTip.BackColor = Global.System.Drawing.SystemColors.Info
			Me.picScrollBarTip.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.picScrollBarTip.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.picScrollBarTip.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.picScrollBarTip.ForeColor = Global.System.Drawing.SystemColors.InfoText
			Me.picScrollBarTip.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim picScrollBarTip As Global.System.Windows.Forms.Control = Me.picScrollBarTip
			location = New Global.System.Drawing.Point(523, 188)
			picScrollBarTip.Location = location
			Me.picScrollBarTip.Name = "picScrollBarTip"
			Me.picScrollBarTip.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim picScrollBarTip2 As Global.System.Windows.Forms.Control = Me.picScrollBarTip
			size = New Global.System.Drawing.Size(94, 20)
			picScrollBarTip2.Size = size
			Me.picScrollBarTip.TabIndex = 3
			Me.picScrollBarTip.TabStop = False
			Me.picScrollBarTip.Visible = False
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			location = New Global.System.Drawing.Point(492, 209)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(125, 20)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 2
			Me.cmdCancel.Text = "Stop animation (hidden)"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.cmdCancel.Visible = False
			Me.pnlActiveReport.AutoScroll = True
			Me.pnlActiveReport.Controls.Add(Me.pnlScrollBar)
			Me.pnlActiveReport.Controls.Add(Me.Viewer1)
			Me.pnlActiveReport.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim pnlActiveReport As Global.System.Windows.Forms.Control = Me.pnlActiveReport
			location = New Global.System.Drawing.Point(0, 0)
			pnlActiveReport.Location = location
			Me.pnlActiveReport.Name = "pnlActiveReport"
			Dim pnlActiveReport2 As Global.System.Windows.Forms.Control = Me.pnlActiveReport
			size = New Global.System.Drawing.Size(1107, 518)
			pnlActiveReport2.Size = size
			Me.pnlActiveReport.TabIndex = 13
			Me.pnlActiveReport.Visible = False
			Me.pnlScrollBar.Controls.Add(Me.VScroll)
			Dim pnlScrollBar As Global.System.Windows.Forms.Control = Me.pnlScrollBar
			location = New Global.System.Drawing.Point(-1333, 0)
			pnlScrollBar.Location = location
			Me.pnlScrollBar.Name = "pnlScrollBar"
			Dim pnlScrollBar2 As Global.System.Windows.Forms.Control = Me.pnlScrollBar
			size = New Global.System.Drawing.Size(138, 510)
			pnlScrollBar2.Size = size
			Me.pnlScrollBar.TabIndex = 16
			Me.pnlScrollBar.Visible = False
			Me.VScroll.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.VScroll.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.VScroll.LargeChange = 1
			Dim vscroll As Global.System.Windows.Forms.Control = Me.VScroll
			location = New Global.System.Drawing.Point(0, 0)
			vscroll.Location = location
			Me.VScroll.Maximum = 7
			Me.VScroll.Name = "VScroll"
			Dim vscroll2 As Global.System.Windows.Forms.Control = Me.VScroll
			size = New Global.System.Drawing.Size(19, 319)
			vscroll2.Size = size
			Me.VScroll.TabIndex = 13
			Me.Viewer1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Viewer1.Document = New Global.DataDynamics.ActiveReports.Document.Document("ARNet Document")
			Dim viewer As Global.System.Windows.Forms.Control = Me.Viewer1
			location = New Global.System.Drawing.Point(16, 19)
			viewer.Location = location
			Me.Viewer1.Name = "Viewer1"
			Me.Viewer1.ReportViewer.CurrentPage = 0
			Me.Viewer1.ReportViewer.MultiplePageCols = 3
			Me.Viewer1.ReportViewer.MultiplePageRows = 2
			Me.Viewer1.ReportViewer.RepositionPage = True
			Me.Viewer1.ReportViewer.ViewType = Global.DataDynamics.ActiveReports.Viewer.ViewType.Normal
			Dim viewer2 As Global.System.Windows.Forms.Control = Me.Viewer1
			size = New Global.System.Drawing.Size(743, 445)
			viewer2.Size = size
			Me.Viewer1.TabIndex = 15
			Me.Viewer1.TableOfContents.Text = "Contents"
			Me.Viewer1.TableOfContents.Width = 200
			Me.Viewer1.TabTitleLength = 35
			Me.Viewer1.Toolbar.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.pnlTabs.Controls.Add(Me.btnImplement)
			Me.pnlTabs.Controls.Add(Me.lblPoint)
			Me.pnlTabs.Controls.Add(Me.btnCoverPageComments)
			Me.pnlTabs.Controls.Add(Me.btnDevCharts)
			Me.pnlTabs.Controls.Add(Me.cmdIPRPlot)
			Me.pnlTabs.Controls.Add(Me._optReport_3)
			Me.pnlTabs.Controls.Add(Me._optReport_2)
			Me.pnlTabs.Controls.Add(Me._optReport_1)
			Me.pnlTabs.Controls.Add(Me._optReport_0)
			Me.pnlTabs.Controls.Add(Me.lblAnimateDyno)
			Me.pnlTabs.Controls.Add(Me.tbbStop)
			Me.pnlTabs.Controls.Add(Me.tbbStep)
			Me.pnlTabs.Controls.Add(Me.tbbRun)
			Me.pnlTabs.Controls.Add(Me.tbbRunPause)
			Me.pnlTabs.Controls.Add(Me.TrackBar1)
			Me.pnlTabs.Controls.Add(Me.optNextDevChart)
			Me.pnlTabs.Controls.Add(Me.optPrevDevChart)
			Me.pnlTabs.Controls.Add(Me.cmdClose)
			Me.pnlTabs.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim pnlTabs As Global.System.Windows.Forms.Control = Me.pnlTabs
			location = New Global.System.Drawing.Point(0, 479)
			pnlTabs.Location = location
			Me.pnlTabs.Name = "pnlTabs"
			Dim pnlTabs2 As Global.System.Windows.Forms.Control = Me.pnlTabs
			size = New Global.System.Drawing.Size(1107, 39)
			pnlTabs2.Size = size
			Me.pnlTabs.TabIndex = 14
			Me.btnImplement.Appearance = Global.System.Windows.Forms.Appearance.Button
			Me.btnImplement.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnImplement.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnImplement.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnImplement.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnImplement.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnImplement As Global.System.Windows.Forms.Control = Me.btnImplement
			location = New Global.System.Drawing.Point(387, 13)
			btnImplement.Location = location
			Me.btnImplement.Name = "btnImplement"
			Me.btnImplement.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim btnImplement2 As Global.System.Windows.Forms.Control = Me.btnImplement
			size = New Global.System.Drawing.Size(74, 23)
			btnImplement2.Size = size
			Me.btnImplement.TabIndex = 224
			Me.btnImplement.TabStop = True
			Me.btnImplement.Text = "&Implement"
			Me.btnImplement.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnImplement.UseVisualStyleBackColor = False
			Me.btnImplement.Visible = False
			Me.lblPoint.AutoSize = True
			Dim lblPoint As Global.System.Windows.Forms.Control = Me.lblPoint
			location = New Global.System.Drawing.Point(924, 15)
			lblPoint.Location = location
			Me.lblPoint.Name = "lblPoint"
			Dim lblPoint2 As Global.System.Windows.Forms.Control = Me.lblPoint
			size = New Global.System.Drawing.Size(0, 14)
			lblPoint2.Size = size
			Me.lblPoint.TabIndex = 223
			Me.btnCoverPageComments.Image = CType(componentResourceManager.GetObject("btnCoverPageComments.Image"), Global.System.Drawing.Image)
			Dim btnCoverPageComments As Global.System.Windows.Forms.Control = Me.btnCoverPageComments
			location = New Global.System.Drawing.Point(314, 11)
			btnCoverPageComments.Location = location
			Me.btnCoverPageComments.Name = "btnCoverPageComments"
			Dim btnCoverPageComments2 As Global.System.Windows.Forms.Control = Me.btnCoverPageComments
			size = New Global.System.Drawing.Size(20, 25)
			btnCoverPageComments2.Size = size
			Me.btnCoverPageComments.TabIndex = 220
			Me.btnDevCharts.Enabled = False
			Me.btnDevCharts.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnDevCharts.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnDevCharts As Global.System.Windows.Forms.Control = Me.btnDevCharts
			location = New Global.System.Drawing.Point(314, 13)
			btnDevCharts.Location = location
			Me.btnDevCharts.Name = "btnDevCharts"
			Dim btnDevCharts2 As Global.System.Windows.Forms.Control = Me.btnDevCharts
			size = New Global.System.Drawing.Size(72, 23)
			btnDevCharts2.Size = size
			Me.btnDevCharts.TabIndex = 28
			Me.btnDevCharts.Text = "D&ev. Plots"
			Me.btnDevCharts.Visible = False
			Me.cmdIPRPlot.Enabled = False
			Me.cmdIPRPlot.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdIPRPlot.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdIPRPlot As Global.System.Windows.Forms.Control = Me.cmdIPRPlot
			location = New Global.System.Drawing.Point(176, 13)
			cmdIPRPlot.Location = location
			Me.cmdIPRPlot.Name = "cmdIPRPlot"
			Dim cmdIPRPlot2 As Global.System.Windows.Forms.Control = Me.cmdIPRPlot
			size = New Global.System.Drawing.Size(64, 23)
			cmdIPRPlot2.Size = size
			Me.cmdIPRPlot.TabIndex = 22
			Me.cmdIPRPlot.Text = "&IPR Plot"
			Me._optReport_3.Appearance = Global.System.Windows.Forms.Appearance.Button
			Me._optReport_3.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optReport_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optReport_3.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optReport_3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optReport_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optReport_ As Global.System.Windows.Forms.Control = Me._optReport_3
			location = New Global.System.Drawing.Point(-1300, 24)
			optReport_.Location = location
			Me._optReport_3.Name = "_optReport_3"
			Me._optReport_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optReport_2 As Global.System.Windows.Forms.Control = Me._optReport_3
			size = New Global.System.Drawing.Size(133, 23)
			optReport_2.Size = size
			Me._optReport_3.TabIndex = 20
			Me._optReport_3.TabStop = True
			Me._optReport_3.Text = "Report"
			Me._optReport_3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me._optReport_3.UseVisualStyleBackColor = False
			Me._optReport_3.Visible = False
			Me._optReport_2.Appearance = Global.System.Windows.Forms.Appearance.Button
			Me._optReport_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optReport_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optReport_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optReport_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optReport_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optReport_3 As Global.System.Windows.Forms.Control = Me._optReport_2
			location = New Global.System.Drawing.Point(241, 13)
			optReport_3.Location = location
			Me._optReport_2.Name = "_optReport_2"
			Me._optReport_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optReport_4 As Global.System.Windows.Forms.Control = Me._optReport_2
			size = New Global.System.Drawing.Size(72, 23)
			optReport_4.Size = size
			Me._optReport_2.TabIndex = 19
			Me._optReport_2.TabStop = True
			Me._optReport_2.Text = "&Report"
			Me._optReport_2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me._optReport_2.UseVisualStyleBackColor = False
			Me._optReport_1.Appearance = Global.System.Windows.Forms.Appearance.Button
			Me._optReport_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optReport_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optReport_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optReport_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optReport_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optReport_5 As Global.System.Windows.Forms.Control = Me._optReport_1
			location = New Global.System.Drawing.Point(96, 13)
			optReport_5.Location = location
			Me._optReport_1.Name = "_optReport_1"
			Me._optReport_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optReport_6 As Global.System.Windows.Forms.Control = Me._optReport_1
			size = New Global.System.Drawing.Size(80, 23)
			optReport_6.Size = size
			Me._optReport_1.TabIndex = 18
			Me._optReport_1.TabStop = True
			Me._optReport_1.Text = "&Torque Plot"
			Me._optReport_1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me._optReport_1.UseVisualStyleBackColor = False
			Me._optReport_0.Appearance = Global.System.Windows.Forms.Appearance.Button
			Me._optReport_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optReport_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optReport_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optReport_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optReport_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optReport_7 As Global.System.Windows.Forms.Control = Me._optReport_0
			location = New Global.System.Drawing.Point(8, 13)
			optReport_7.Location = location
			Me._optReport_0.Name = "_optReport_0"
			Me._optReport_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optReport_8 As Global.System.Windows.Forms.Control = Me._optReport_0
			size = New Global.System.Drawing.Size(88, 23)
			optReport_8.Size = size
			Me._optReport_0.TabIndex = 17
			Me._optReport_0.TabStop = True
			Me._optReport_0.Text = "&Dynamometer"
			Me._optReport_0.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me._optReport_0.UseVisualStyleBackColor = False
			Me.lblAnimateDyno.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblAnimateDyno.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblAnimateDyno.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lblAnimateDyno.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lblAnimateDyno.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblAnimateDyno As Global.System.Windows.Forms.Control = Me.lblAnimateDyno
			location = New Global.System.Drawing.Point(465, 20)
			lblAnimateDyno.Location = location
			Me.lblAnimateDyno.Name = "lblAnimateDyno"
			Me.lblAnimateDyno.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblAnimateDyno2 As Global.System.Windows.Forms.Control = Me.lblAnimateDyno
			size = New Global.System.Drawing.Size(96, 13)
			lblAnimateDyno2.Size = size
			Me.lblAnimateDyno.TabIndex = 13
			Me.lblAnimateDyno.Text = "Animate Dyno:"
			Me.lblAnimateDyno.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.lblAnimateDyno.Visible = False
			Me.TrackBar1.AutoSize = False
			Me.TrackBar1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim trackBar As Global.System.Windows.Forms.Control = Me.TrackBar1
			location = New Global.System.Drawing.Point(561, 1)
			trackBar.Location = location
			Me.TrackBar1.Maximum = 100
			Me.TrackBar1.Name = "TrackBar1"
			Dim trackBar2 As Global.System.Windows.Forms.Control = Me.TrackBar1
			size = New Global.System.Drawing.Size(120, 42)
			trackBar2.Size = size
			Me.TrackBar1.TabIndex = 27
			Me.TrackBar1.Visible = False
			Me.optNextDevChart.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optNextDevChart As Global.System.Windows.Forms.Control = Me.optNextDevChart
			location = New Global.System.Drawing.Point(586, 13)
			optNextDevChart.Location = location
			Me.optNextDevChart.Name = "optNextDevChart"
			Dim optNextDevChart2 As Global.System.Windows.Forms.Control = Me.optNextDevChart
			size = New Global.System.Drawing.Size(80, 23)
			optNextDevChart2.Size = size
			Me.optNextDevChart.TabIndex = 222
			Me.optNextDevChart.Text = "Next>>"
			Me.optNextDevChart.Visible = False
			Me.optPrevDevChart.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPrevDevChart As Global.System.Windows.Forms.Control = Me.optPrevDevChart
			location = New Global.System.Drawing.Point(506, 13)
			optPrevDevChart.Location = location
			Me.optPrevDevChart.Name = "optPrevDevChart"
			Dim optPrevDevChart2 As Global.System.Windows.Forms.Control = Me.optPrevDevChart
			size = New Global.System.Drawing.Size(80, 23)
			optPrevDevChart2.Size = size
			Me.optPrevDevChart.TabIndex = 221
			Me.optPrevDevChart.Text = "<< Previous"
			Me.optPrevDevChart.Visible = False
			Me.pnlDyno.AutoScroll = True
			Me.pnlDyno.Controls.Add(Me.ChartFX_Dyno)
			Me.pnlDyno.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim pnlDyno As Global.System.Windows.Forms.Control = Me.pnlDyno
			location = New Global.System.Drawing.Point(0, 0)
			pnlDyno.Location = location
			Me.pnlDyno.Name = "pnlDyno"
			Dim pnlDyno2 As Global.System.Windows.Forms.Control = Me.pnlDyno
			size = New Global.System.Drawing.Size(1107, 518)
			pnlDyno2.Size = size
			Me.pnlDyno.TabIndex = 15
			Me.pnlDyno.Visible = False
			Me.ChartFX_Dyno.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_Dyno.AllSeries.MarkerSize = 4S
			Me.ChartFX_Dyno.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Dyno.AxisX.Grids.Major.Visible = False
			Me.ChartFX_Dyno.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_Dyno.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Dyno.AxisY.Grids.Major.Visible = False
			Me.ChartFX_Dyno.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_Dyno.Background = gradientBackground
			Me.ChartFX_Dyno.Border = border
			Me.ChartFX_Dyno.ContextMenus = False
			Me.ChartFX_Dyno.LegendBox.Border = Global.ChartFX.WinForms.DockBorder.External
			Me.ChartFX_Dyno.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_Dyno As Global.System.Windows.Forms.Control = Me.ChartFX_Dyno
			location = New Global.System.Drawing.Point(76, 19)
			chartFX_Dyno.Location = location
			Me.ChartFX_Dyno.Name = "ChartFX_Dyno"
			Dim chartFX_Dyno2 As Global.System.Windows.Forms.Control = Me.ChartFX_Dyno
			size = New Global.System.Drawing.Size(640, 347)
			chartFX_Dyno2.Size = size
			Me.ChartFX_Dyno.TabIndex = 1
			titleDockable.Alignment = Global.System.Drawing.StringAlignment.Near
			titleDockable.Text = "Dynamometer Cards"
			Me.ChartFX_Dyno.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable })
			Me.pnlTorquePlot.AutoScroll = True
			Me.pnlTorquePlot.Controls.Add(Me.ChartFX_TorquePlot)
			Me.pnlTorquePlot.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim pnlTorquePlot As Global.System.Windows.Forms.Control = Me.pnlTorquePlot
			location = New Global.System.Drawing.Point(0, 0)
			pnlTorquePlot.Location = location
			Me.pnlTorquePlot.Name = "pnlTorquePlot"
			Dim pnlTorquePlot2 As Global.System.Windows.Forms.Control = Me.pnlTorquePlot
			size = New Global.System.Drawing.Size(1107, 518)
			pnlTorquePlot2.Size = size
			Me.pnlTorquePlot.TabIndex = 16
			Me.pnlTorquePlot.Visible = False
			Me.ChartFX_TorquePlot.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_TorquePlot.AllSeries.MarkerSize = 4S
			Me.ChartFX_TorquePlot.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_TorquePlot.AxisX.Grids.Major.Visible = False
			Me.ChartFX_TorquePlot.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_TorquePlot.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_TorquePlot.AxisY.Grids.Major.Visible = False
			Me.ChartFX_TorquePlot.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground2.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_TorquePlot.Background = gradientBackground2
			Me.ChartFX_TorquePlot.Border = border2
			Me.ChartFX_TorquePlot.LegendBox.Border = Global.ChartFX.WinForms.DockBorder.External
			Me.ChartFX_TorquePlot.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_TorquePlot As Global.System.Windows.Forms.Control = Me.ChartFX_TorquePlot
			location = New Global.System.Drawing.Point(71, 19)
			chartFX_TorquePlot.Location = location
			Me.ChartFX_TorquePlot.Name = "ChartFX_TorquePlot"
			Dim chartFX_TorquePlot2 As Global.System.Windows.Forms.Control = Me.ChartFX_TorquePlot
			size = New Global.System.Drawing.Size(645, 340)
			chartFX_TorquePlot2.Size = size
			Me.ChartFX_TorquePlot.TabIndex = 0
			titleDockable2.Alignment = Global.System.Drawing.StringAlignment.Near
			titleDockable2.Text = "Torque Plots"
			Me.ChartFX_TorquePlot.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable2 })
			Me.pnlTempChart.Controls.Add(Me.ChartFX_Temp_TorquePlot)
			Me.pnlTempChart.Controls.Add(Me.ChartFX_Temp_Dyno)
			Dim pnlTempChart As Global.System.Windows.Forms.Control = Me.pnlTempChart
			location = New Global.System.Drawing.Point(-952, 0)
			pnlTempChart.Location = location
			Me.pnlTempChart.Name = "pnlTempChart"
			Dim pnlTempChart2 As Global.System.Windows.Forms.Control = Me.pnlTempChart
			size = New Global.System.Drawing.Size(776, 312)
			pnlTempChart2.Size = size
			Me.pnlTempChart.TabIndex = 17
			Me.ChartFX_Temp_TorquePlot.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_Temp_TorquePlot.AllSeries.MarkerSize = 4S
			Me.ChartFX_Temp_TorquePlot.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Temp_TorquePlot.AxisX.Grids.Major.Visible = False
			Me.ChartFX_Temp_TorquePlot.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_Temp_TorquePlot.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Temp_TorquePlot.AxisY.Grids.Major.Visible = False
			Me.ChartFX_Temp_TorquePlot.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_Temp_TorquePlot.BackColor = Global.System.Drawing.SystemColors.ControlLightLight
			gradientBackground3.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_Temp_TorquePlot.Background = gradientBackground3
			Me.ChartFX_Temp_TorquePlot.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_Temp_TorquePlot As Global.System.Windows.Forms.Control = Me.ChartFX_Temp_TorquePlot
			location = New Global.System.Drawing.Point(192, 40)
			chartFX_Temp_TorquePlot.Location = location
			Me.ChartFX_Temp_TorquePlot.Name = "ChartFX_Temp_TorquePlot"
			Me.ChartFX_Temp_TorquePlot.PlotAreaMargin.Bottom = 1
			Me.ChartFX_Temp_TorquePlot.PlotAreaMargin.Left = 1
			Me.ChartFX_Temp_TorquePlot.PlotAreaMargin.Right = 1
			Me.ChartFX_Temp_TorquePlot.PlotAreaMargin.Top = 1
			Dim chartFX_Temp_TorquePlot2 As Global.System.Windows.Forms.Control = Me.ChartFX_Temp_TorquePlot
			size = New Global.System.Drawing.Size(384, 256)
			chartFX_Temp_TorquePlot2.Size = size
			Me.ChartFX_Temp_TorquePlot.TabIndex = 2
			titleDockable3.Alignment = Global.System.Drawing.StringAlignment.Near
			titleDockable3.Font = New Global.System.Drawing.Font("Arial", 6F)
			titleDockable3.Text = "Torque Plots"
			Me.ChartFX_Temp_TorquePlot.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable3 })
			Me.ChartFX_Temp_Dyno.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_Temp_Dyno.AllSeries.MarkerSize = 4S
			Me.ChartFX_Temp_Dyno.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Temp_Dyno.AxisX.Grids.Major.Visible = False
			Me.ChartFX_Temp_Dyno.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_Temp_Dyno.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Temp_Dyno.AxisY.Grids.Major.Visible = False
			Me.ChartFX_Temp_Dyno.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_Temp_Dyno.BackColor = Global.System.Drawing.SystemColors.ControlLightLight
			gradientBackground4.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_Temp_Dyno.Background = gradientBackground4
			imageBorder.Color = Global.System.Drawing.Color.LightGray
			Me.ChartFX_Temp_Dyno.Border = imageBorder
			Me.ChartFX_Temp_Dyno.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_Temp_Dyno As Global.System.Windows.Forms.Control = Me.ChartFX_Temp_Dyno
			location = New Global.System.Drawing.Point(8, 16)
			chartFX_Temp_Dyno.Location = location
			Me.ChartFX_Temp_Dyno.Name = "ChartFX_Temp_Dyno"
			Me.ChartFX_Temp_Dyno.PlotAreaMargin.Bottom = 1
			Me.ChartFX_Temp_Dyno.PlotAreaMargin.Left = 1
			Me.ChartFX_Temp_Dyno.PlotAreaMargin.Right = 1
			Me.ChartFX_Temp_Dyno.PlotAreaMargin.Top = 1
			Dim chartFX_Temp_Dyno2 As Global.System.Windows.Forms.Control = Me.ChartFX_Temp_Dyno
			size = New Global.System.Drawing.Size(384, 256)
			chartFX_Temp_Dyno2.Size = size
			Me.ChartFX_Temp_Dyno.TabIndex = 1
			titleDockable4.Alignment = Global.System.Drawing.StringAlignment.Near
			titleDockable4.Font = New Global.System.Drawing.Font("Arial", 6F)
			titleDockable4.Text = "Dynamometer Cards"
			Me.ChartFX_Temp_Dyno.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable4 })
			Me.pnlTempChart2.Controls.Add(Me.ChartFX_Temp_Torque_L)
			Me.pnlTempChart2.Controls.Add(Me.ChartFX_Temp_Dyno_L)
			Me.pnlTempChart2.Controls.Add(Me.ChartFX_Temp_Dyno_XL)
			Me.pnlTempChart2.Controls.Add(Me.ChartFX_Temp_Torque_XL)
			Dim pnlTempChart3 As Global.System.Windows.Forms.Control = Me.pnlTempChart2
			location = New Global.System.Drawing.Point(-952, 0)
			pnlTempChart3.Location = location
			Me.pnlTempChart2.Name = "pnlTempChart2"
			Dim pnlTempChart4 As Global.System.Windows.Forms.Control = Me.pnlTempChart2
			size = New Global.System.Drawing.Size(776, 496)
			pnlTempChart4.Size = size
			Me.pnlTempChart2.TabIndex = 18
			Me.ChartFX_Temp_Torque_L.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_Temp_Torque_L.AllSeries.MarkerSize = 4S
			Me.ChartFX_Temp_Torque_L.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Temp_Torque_L.AxisX.Grids.Major.Visible = False
			Me.ChartFX_Temp_Torque_L.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_Temp_Torque_L.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Temp_Torque_L.AxisY.Grids.Major.Visible = False
			Me.ChartFX_Temp_Torque_L.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground5.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_Temp_Torque_L.Background = gradientBackground5
			Me.ChartFX_Temp_Torque_L.Border = border3
			Me.ChartFX_Temp_Torque_L.LegendBox.BackColor = Global.System.Drawing.Color.Transparent
			Me.ChartFX_Temp_Torque_L.LegendBox.Border = Global.ChartFX.WinForms.DockBorder.External
			Me.ChartFX_Temp_Torque_L.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_Temp_Torque_L As Global.System.Windows.Forms.Control = Me.ChartFX_Temp_Torque_L
			location = New Global.System.Drawing.Point(7, 12)
			chartFX_Temp_Torque_L.Location = location
			Me.ChartFX_Temp_Torque_L.Name = "ChartFX_Temp_Torque_L"
			Dim chartFX_Temp_Torque_L2 As Global.System.Windows.Forms.Control = Me.ChartFX_Temp_Torque_L
			size = New Global.System.Drawing.Size(700, 388)
			chartFX_Temp_Torque_L2.Size = size
			Me.ChartFX_Temp_Torque_L.TabIndex = 3
			titleDockable5.Alignment = Global.System.Drawing.StringAlignment.Near
			titleDockable5.Text = "Torque Plots"
			Me.ChartFX_Temp_Torque_L.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable5 })
			Me.ChartFX_Temp_Dyno_L.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_Temp_Dyno_L.AllSeries.MarkerSize = 4S
			Me.ChartFX_Temp_Dyno_L.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Temp_Dyno_L.AxisX.Grids.Major.Visible = False
			Me.ChartFX_Temp_Dyno_L.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_Temp_Dyno_L.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Temp_Dyno_L.AxisY.Grids.Major.Visible = False
			Me.ChartFX_Temp_Dyno_L.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground6.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_Temp_Dyno_L.Background = gradientBackground6
			Me.ChartFX_Temp_Dyno_L.Border = border4
			Me.ChartFX_Temp_Dyno_L.ContextMenus = False
			Me.ChartFX_Temp_Dyno_L.LegendBox.Border = Global.ChartFX.WinForms.DockBorder.External
			Me.ChartFX_Temp_Dyno_L.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_Temp_Dyno_L As Global.System.Windows.Forms.Control = Me.ChartFX_Temp_Dyno_L
			location = New Global.System.Drawing.Point(34, 8)
			chartFX_Temp_Dyno_L.Location = location
			Me.ChartFX_Temp_Dyno_L.Name = "ChartFX_Temp_Dyno_L"
			Dim chartFX_Temp_Dyno_L2 As Global.System.Windows.Forms.Control = Me.ChartFX_Temp_Dyno_L
			size = New Global.System.Drawing.Size(700, 400)
			chartFX_Temp_Dyno_L2.Size = size
			Me.ChartFX_Temp_Dyno_L.TabIndex = 2
			titleDockable6.Alignment = Global.System.Drawing.StringAlignment.Near
			titleDockable6.Text = "Dynamometer Cards"
			Me.ChartFX_Temp_Dyno_L.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable6 })
			Me.ChartFX_Temp_Dyno_XL.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_Temp_Dyno_XL.AllSeries.MarkerSize = 4S
			Me.ChartFX_Temp_Dyno_XL.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Temp_Dyno_XL.AxisX.Grids.Major.Visible = False
			Me.ChartFX_Temp_Dyno_XL.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_Temp_Dyno_XL.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Temp_Dyno_XL.AxisY.Grids.Major.Visible = False
			Me.ChartFX_Temp_Dyno_XL.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground7.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_Temp_Dyno_XL.Background = gradientBackground7
			Me.ChartFX_Temp_Dyno_XL.ContextMenus = False
			Me.ChartFX_Temp_Dyno_XL.LegendBox.Border = Global.ChartFX.WinForms.DockBorder.External
			Me.ChartFX_Temp_Dyno_XL.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_Temp_Dyno_XL As Global.System.Windows.Forms.Control = Me.ChartFX_Temp_Dyno_XL
			location = New Global.System.Drawing.Point(9, 10)
			chartFX_Temp_Dyno_XL.Location = location
			Me.ChartFX_Temp_Dyno_XL.Name = "ChartFX_Temp_Dyno_XL"
			Dim chartFX_Temp_Dyno_XL2 As Global.System.Windows.Forms.Control = Me.ChartFX_Temp_Dyno_XL
			size = New Global.System.Drawing.Size(696, 377)
			chartFX_Temp_Dyno_XL2.Size = size
			Me.ChartFX_Temp_Dyno_XL.TabIndex = 4
			titleDockable7.Alignment = Global.System.Drawing.StringAlignment.Near
			titleDockable7.Text = "Dynamometer Cards"
			Me.ChartFX_Temp_Dyno_XL.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable7 })
			Me.ChartFX_Temp_Torque_XL.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_Temp_Torque_XL.AllSeries.MarkerSize = 4S
			Me.ChartFX_Temp_Torque_XL.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Temp_Torque_XL.AxisX.Grids.Major.Visible = False
			Me.ChartFX_Temp_Torque_XL.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_Temp_Torque_XL.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_Temp_Torque_XL.AxisY.Grids.Major.Visible = False
			Me.ChartFX_Temp_Torque_XL.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground8.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_Temp_Torque_XL.Background = gradientBackground8
			Me.ChartFX_Temp_Torque_XL.LegendBox.Border = Global.ChartFX.WinForms.DockBorder.External
			Me.ChartFX_Temp_Torque_XL.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_Temp_Torque_XL As Global.System.Windows.Forms.Control = Me.ChartFX_Temp_Torque_XL
			location = New Global.System.Drawing.Point(8, 8)
			chartFX_Temp_Torque_XL.Location = location
			Me.ChartFX_Temp_Torque_XL.Name = "ChartFX_Temp_Torque_XL"
			Dim chartFX_Temp_Torque_XL2 As Global.System.Windows.Forms.Control = Me.ChartFX_Temp_Torque_XL
			size = New Global.System.Drawing.Size(696, 400)
			chartFX_Temp_Torque_XL2.Size = size
			Me.ChartFX_Temp_Torque_XL.TabIndex = 5
			titleDockable8.Alignment = Global.System.Drawing.StringAlignment.Near
			titleDockable8.Text = "Torque Plots"
			Me.ChartFX_Temp_Torque_XL.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable8 })
			Me.pnlDeviation.Controls.Add(Me.chtDoglegs)
			Me.pnlDeviation.Controls.Add(Me.chtSurveyPlan)
			Me.pnlDeviation.Controls.Add(Me.chtSurveyNS)
			Me.pnlDeviation.Controls.Add(Me.chtSurveyEW)
			Me.pnlDeviation.Controls.Add(Me.chtSideForces)
			Me.pnlDeviation.Controls.Add(Me.chtBucklingTendency)
			Me.pnlDeviation.Controls.Add(Me.chtAxialLoads)
			Dim pnlDeviation As Global.System.Windows.Forms.Control = Me.pnlDeviation
			location = New Global.System.Drawing.Point(-1333, 16)
			pnlDeviation.Location = location
			Me.pnlDeviation.Name = "pnlDeviation"
			Dim pnlDeviation2 As Global.System.Windows.Forms.Control = Me.pnlDeviation
			size = New Global.System.Drawing.Size(833, 440)
			pnlDeviation2.Size = size
			Me.pnlDeviation.TabIndex = 19
			Me.pnlDeviation.Visible = False
			Me.chtDoglegs.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.chtDoglegs.AllSeries.MarkerSize = 4S
			Me.chtDoglegs.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.chtDoglegs.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtDoglegs.AxisX.Grids.Major.Visible = False
			Me.chtDoglegs.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.chtDoglegs.AxisX.Title.Text = "Dogleg Severity"
			Me.chtDoglegs.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtDoglegs.AxisY.Grids.Major.Visible = False
			Me.chtDoglegs.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.chtDoglegs.AxisY.Title.Text = "Measured Depth"
			gradientBackground9.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.chtDoglegs.Background = gradientBackground9
			Me.chtDoglegs.Border = border5
			Me.chtDoglegs.ContextMenus = False
			Me.chtDoglegs.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chtDoglegs As Global.System.Windows.Forms.Control = Me.chtDoglegs
			location = New Global.System.Drawing.Point(234, 43)
			chtDoglegs.Location = location
			Me.chtDoglegs.Name = "chtDoglegs"
			Dim chtDoglegs2 As Global.System.Windows.Forms.Control = Me.chtDoglegs
			size = New Global.System.Drawing.Size(302, 354)
			chtDoglegs2.Size = size
			Me.chtDoglegs.TabIndex = 8
			titleDockable9.Text = "Dogleg Severity"
			Me.chtDoglegs.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable9 })
			Me.chtDoglegs.Visible = False
			Me.chtSurveyPlan.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.chtSurveyPlan.AllSeries.MarkerSize = 4S
			Me.chtSurveyPlan.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.chtSurveyPlan.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtSurveyPlan.AxisX.Grids.Major.Visible = False
			Me.chtSurveyPlan.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.chtSurveyPlan.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtSurveyPlan.AxisY.Grids.Major.Visible = False
			Me.chtSurveyPlan.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground10.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.chtSurveyPlan.Background = gradientBackground10
			Me.chtSurveyPlan.Border = border6
			Me.chtSurveyPlan.ContextMenus = False
			Me.chtSurveyPlan.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chtSurveyPlan As Global.System.Windows.Forms.Control = Me.chtSurveyPlan
			location = New Global.System.Drawing.Point(456, 72)
			chtSurveyPlan.Location = location
			Me.chtSurveyPlan.Name = "chtSurveyPlan"
			Dim chtSurveyPlan2 As Global.System.Windows.Forms.Control = Me.chtSurveyPlan
			size = New Global.System.Drawing.Size(302, 354)
			chtSurveyPlan2.Size = size
			Me.chtSurveyPlan.TabIndex = 7
			titleDockable10.Text = "Looking Down - Trajectory"
			Me.chtSurveyPlan.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable10 })
			Me.chtSurveyPlan.Visible = False
			Me.chtSurveyNS.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.chtSurveyNS.AllSeries.MarkerSize = 4S
			Me.chtSurveyNS.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.chtSurveyNS.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtSurveyNS.AxisX.Grids.Major.Visible = False
			Me.chtSurveyNS.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.chtSurveyNS.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtSurveyNS.AxisY.Grids.Major.Visible = False
			Me.chtSurveyNS.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground11.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.chtSurveyNS.Background = gradientBackground11
			Me.chtSurveyNS.Border = border7
			Me.chtSurveyNS.ContextMenus = False
			Me.chtSurveyNS.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chtSurveyNS As Global.System.Windows.Forms.Control = Me.chtSurveyNS
			location = New Global.System.Drawing.Point(352, 88)
			chtSurveyNS.Location = location
			Me.chtSurveyNS.Name = "chtSurveyNS"
			Dim chtSurveyNS2 As Global.System.Windows.Forms.Control = Me.chtSurveyNS
			size = New Global.System.Drawing.Size(302, 354)
			chtSurveyNS2.Size = size
			Me.chtSurveyNS.TabIndex = 6
			titleDockable11.Text = "Looking West"
			Me.chtSurveyNS.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable11 })
			Me.chtSurveyNS.Visible = False
			Me.chtSurveyEW.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.chtSurveyEW.AllSeries.MarkerSize = 4S
			Me.chtSurveyEW.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.chtSurveyEW.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtSurveyEW.AxisX.Grids.Major.Visible = False
			Me.chtSurveyEW.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.chtSurveyEW.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtSurveyEW.AxisY.Grids.Major.Visible = False
			Me.chtSurveyEW.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground12.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.chtSurveyEW.Background = gradientBackground12
			Me.chtSurveyEW.Border = border8
			Me.chtSurveyEW.ContextMenus = False
			Me.chtSurveyEW.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chtSurveyEW As Global.System.Windows.Forms.Control = Me.chtSurveyEW
			location = New Global.System.Drawing.Point(264, 80)
			chtSurveyEW.Location = location
			Me.chtSurveyEW.Name = "chtSurveyEW"
			Dim chtSurveyEW2 As Global.System.Windows.Forms.Control = Me.chtSurveyEW
			size = New Global.System.Drawing.Size(302, 354)
			chtSurveyEW2.Size = size
			Me.chtSurveyEW.TabIndex = 5
			titleDockable12.Text = "Looking North "
			Me.chtSurveyEW.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable12 })
			Me.chtSurveyEW.Visible = False
			Me.chtSideForces.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.chtSideForces.AllSeries.MarkerSize = 4S
			Me.chtSideForces.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.chtSideForces.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtSideForces.AxisX.Grids.Major.Visible = False
			Me.chtSideForces.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.chtSideForces.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtSideForces.AxisY.Grids.Major.Visible = False
			Me.chtSideForces.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground13.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.chtSideForces.Background = gradientBackground13
			Me.chtSideForces.Border = border9
			Me.chtSideForces.ContextMenus = False
			Me.chtSideForces.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chtSideForces As Global.System.Windows.Forms.Control = Me.chtSideForces
			location = New Global.System.Drawing.Point(152, 48)
			chtSideForces.Location = location
			Me.chtSideForces.Name = "chtSideForces"
			Dim chtSideForces2 As Global.System.Windows.Forms.Control = Me.chtSideForces
			size = New Global.System.Drawing.Size(302, 354)
			chtSideForces2.Size = size
			Me.chtSideForces.TabIndex = 4
			titleDockable13.Text = "Side Loading"
			Me.chtSideForces.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable13 })
			Me.chtSideForces.Visible = False
			Me.chtBucklingTendency.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.chtBucklingTendency.AllSeries.MarkerSize = 4S
			Me.chtBucklingTendency.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.chtBucklingTendency.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtBucklingTendency.AxisX.Grids.Major.Visible = False
			Me.chtBucklingTendency.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.chtBucklingTendency.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtBucklingTendency.AxisY.Grids.Major.Visible = False
			Me.chtBucklingTendency.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground14.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.chtBucklingTendency.Background = gradientBackground14
			Me.chtBucklingTendency.Border = border10
			Me.chtBucklingTendency.ContextMenus = False
			Me.chtBucklingTendency.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chtBucklingTendency As Global.System.Windows.Forms.Control = Me.chtBucklingTendency
			location = New Global.System.Drawing.Point(72, 40)
			chtBucklingTendency.Location = location
			Me.chtBucklingTendency.Name = "chtBucklingTendency"
			Dim chtBucklingTendency2 As Global.System.Windows.Forms.Control = Me.chtBucklingTendency
			size = New Global.System.Drawing.Size(302, 354)
			chtBucklingTendency2.Size = size
			Me.chtBucklingTendency.TabIndex = 3
			titleDockable14.Text = "Buckling tendency"
			Me.chtBucklingTendency.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable14 })
			Me.chtBucklingTendency.Visible = False
			Me.chtAxialLoads.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.chtAxialLoads.AllSeries.MarkerSize = 4S
			Me.chtAxialLoads.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.chtAxialLoads.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtAxialLoads.AxisX.Grids.Major.Visible = False
			Me.chtAxialLoads.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.chtAxialLoads.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.chtAxialLoads.AxisY.Grids.Major.Visible = False
			Me.chtAxialLoads.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground15.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.chtAxialLoads.Background = gradientBackground15
			Me.chtAxialLoads.Border = border11
			Me.chtAxialLoads.ContextMenus = False
			Me.chtAxialLoads.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chtAxialLoads As Global.System.Windows.Forms.Control = Me.chtAxialLoads
			location = New Global.System.Drawing.Point(8, 8)
			chtAxialLoads.Location = location
			Me.chtAxialLoads.Name = "chtAxialLoads"
			Dim chtAxialLoads2 As Global.System.Windows.Forms.Control = Me.chtAxialLoads
			size = New Global.System.Drawing.Size(302, 354)
			chtAxialLoads2.Size = size
			Me.chtAxialLoads.TabIndex = 2
			titleDockable15.Text = "Max/Min Axial Loading"
			Me.chtAxialLoads.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable15 })
			Me.chtAxialLoads.Visible = False
			Me.pnlDevCharts.AutoScroll = True
			Me.pnlDevCharts.Controls.Add(Me.pnlGrpDevPlot)
			Me.pnlDevCharts.Controls.Add(Me.ChartFX_LookingNorth)
			Me.pnlDevCharts.Controls.Add(Me.ChartFX_SideLoading)
			Me.pnlDevCharts.Controls.Add(Me.ChartFX_BucklingTendency)
			Me.pnlDevCharts.Controls.Add(Me.ChartFX_AxialLoads)
			Me.pnlDevCharts.Controls.Add(Me.ChartFX_DoglegSeverity)
			Me.pnlDevCharts.Controls.Add(Me.ChartFX_LookingDown)
			Me.pnlDevCharts.Controls.Add(Me.ChartFX_LookingEast)
			Me.pnlDevCharts.Controls.Add(Me.btnPrevDevChart)
			Me.pnlDevCharts.Controls.Add(Me.btnNextDevChart)
			Me.pnlDevCharts.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim pnlDevCharts As Global.System.Windows.Forms.Control = Me.pnlDevCharts
			location = New Global.System.Drawing.Point(0, 0)
			pnlDevCharts.Location = location
			Me.pnlDevCharts.Name = "pnlDevCharts"
			Dim pnlDevCharts2 As Global.System.Windows.Forms.Control = Me.pnlDevCharts
			size = New Global.System.Drawing.Size(1107, 518)
			pnlDevCharts2.Size = size
			Me.pnlDevCharts.TabIndex = 20
			Me.pnlDevCharts.Visible = False
			Me.pnlGrpDevPlot.Controls.Add(Me.pnlLegend)
			Me.pnlGrpDevPlot.Controls.Add(Me.pnlCommander)
			Me.pnlGrpDevPlot.Controls.Add(Me.pnlDevPlot)
			Dim pnlGrpDevPlot As Global.System.Windows.Forms.Control = Me.pnlGrpDevPlot
			location = New Global.System.Drawing.Point(8, 0)
			pnlGrpDevPlot.Location = location
			Me.pnlGrpDevPlot.Name = "pnlGrpDevPlot"
			Dim pnlGrpDevPlot2 As Global.System.Windows.Forms.Control = Me.pnlGrpDevPlot
			size = New Global.System.Drawing.Size(800, 476)
			pnlGrpDevPlot2.Size = size
			Me.pnlGrpDevPlot.TabIndex = 27
			Me.pnlGrpDevPlot.Visible = False
			Me.pnlLegend.Controls.Add(Me.pnlLegend2)
			Me.pnlLegend.Controls.Add(Me.VScrollBar1)
			Me.pnlLegend.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim pnlLegend As Global.System.Windows.Forms.Control = Me.pnlLegend
			location = New Global.System.Drawing.Point(0, 419)
			pnlLegend.Location = location
			Me.pnlLegend.Name = "pnlLegend"
			Dim pnlLegend2 As Global.System.Windows.Forms.Control = Me.pnlLegend
			size = New Global.System.Drawing.Size(800, 57)
			pnlLegend2.Size = size
			Me.pnlLegend.TabIndex = 30
			Me.pnlLegend2.AutoSize = True
			Me.pnlLegend2.Controls.Add(Me.lblNumGuidesPerRod2)
			Me.pnlLegend2.Controls.Add(Me.lblDiameters2)
			Me.pnlLegend2.Controls.Add(Me.G20)
			Me.pnlLegend2.Controls.Add(Me.G19)
			Me.pnlLegend2.Controls.Add(Me.G18)
			Me.pnlLegend2.Controls.Add(Me.G17)
			Me.pnlLegend2.Controls.Add(Me.G16)
			Me.pnlLegend2.Controls.Add(Me.G15)
			Me.pnlLegend2.Controls.Add(Me.G14)
			Me.pnlLegend2.Controls.Add(Me.G13)
			Me.pnlLegend2.Controls.Add(Me.G12)
			Me.pnlLegend2.Controls.Add(Me.G11)
			Me.pnlLegend2.Controls.Add(Me.lblNumGuidesPerRod)
			Me.pnlLegend2.Controls.Add(Me.G10)
			Me.pnlLegend2.Controls.Add(Me.G9)
			Me.pnlLegend2.Controls.Add(Me.G8)
			Me.pnlLegend2.Controls.Add(Me.G7)
			Me.pnlLegend2.Controls.Add(Me.G6)
			Me.pnlLegend2.Controls.Add(Me.G5)
			Me.pnlLegend2.Controls.Add(Me.G4)
			Me.pnlLegend2.Controls.Add(Me.G3)
			Me.pnlLegend2.Controls.Add(Me.G2)
			Me.pnlLegend2.Controls.Add(Me.G1)
			Me.pnlLegend2.Controls.Add(Me.lblDiameters)
			Me.pnlLegend2.Controls.Add(Me.T20)
			Me.pnlLegend2.Controls.Add(Me.T19)
			Me.pnlLegend2.Controls.Add(Me.T18)
			Me.pnlLegend2.Controls.Add(Me.T17)
			Me.pnlLegend2.Controls.Add(Me.T16)
			Me.pnlLegend2.Controls.Add(Me.T15)
			Me.pnlLegend2.Controls.Add(Me.T14)
			Me.pnlLegend2.Controls.Add(Me.T13)
			Me.pnlLegend2.Controls.Add(Me.T12)
			Me.pnlLegend2.Controls.Add(Me.T11)
			Me.pnlLegend2.Controls.Add(Me.T10)
			Me.pnlLegend2.Controls.Add(Me.T9)
			Me.pnlLegend2.Controls.Add(Me.T8)
			Me.pnlLegend2.Controls.Add(Me.T7)
			Me.pnlLegend2.Controls.Add(Me.T6)
			Me.pnlLegend2.Controls.Add(Me.T5)
			Me.pnlLegend2.Controls.Add(Me.T4)
			Me.pnlLegend2.Controls.Add(Me.T3)
			Me.pnlLegend2.Controls.Add(Me.T2)
			Me.pnlLegend2.Controls.Add(Me.T1)
			Dim pnlLegend3 As Global.System.Windows.Forms.Control = Me.pnlLegend2
			location = New Global.System.Drawing.Point(0, 0)
			pnlLegend3.Location = location
			Me.pnlLegend2.Name = "pnlLegend2"
			Dim pnlLegend4 As Global.System.Windows.Forms.Control = Me.pnlLegend2
			size = New Global.System.Drawing.Size(640, 51)
			pnlLegend4.Size = size
			Me.pnlLegend2.TabIndex = 51
			Me.lblNumGuidesPerRod2.AutoSize = True
			Me.lblNumGuidesPerRod2.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim lblNumGuidesPerRod As Global.System.Windows.Forms.Control = Me.lblNumGuidesPerRod2
			location = New Global.System.Drawing.Point(2, 38)
			lblNumGuidesPerRod.Location = location
			Me.lblNumGuidesPerRod2.Name = "lblNumGuidesPerRod2"
			Dim lblNumGuidesPerRod2 As Global.System.Windows.Forms.Control = Me.lblNumGuidesPerRod2
			size = New Global.System.Drawing.Size(65, 12)
			lblNumGuidesPerRod2.Size = size
			Me.lblNumGuidesPerRod2.TabIndex = 150
			Me.lblNumGuidesPerRod2.Text = "# Guides/Rod:"
			Me.lblNumGuidesPerRod2.Visible = False
			Me.lblDiameters2.AutoSize = True
			Me.lblDiameters2.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim lblDiameters As Global.System.Windows.Forms.Control = Me.lblDiameters2
			location = New Global.System.Drawing.Point(2, 25)
			lblDiameters.Location = location
			Me.lblDiameters2.Name = "lblDiameters2"
			Dim lblDiameters2 As Global.System.Windows.Forms.Control = Me.lblDiameters2
			size = New Global.System.Drawing.Size(74, 12)
			lblDiameters2.Size = size
			Me.lblDiameters2.TabIndex = 149
			Me.lblDiameters2.Text = "Rod Diameters: "
			Me.G20.AutoSize = True
			Me.G20.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g As Global.System.Windows.Forms.Control = Me.G20
			location = New Global.System.Drawing.Point(566, 39)
			g.Location = location
			Me.G20.Name = "G20"
			Dim g2 As Global.System.Windows.Forms.Control = Me.G20
			size = New Global.System.Drawing.Size(22, 12)
			g2.Size = size
			Me.G20.TabIndex = 148
			Me.G20.Text = "G20"
			Me.G20.Visible = False
			Me.G19.AutoSize = True
			Me.G19.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g3 As Global.System.Windows.Forms.Control = Me.G19
			location = New Global.System.Drawing.Point(512, 39)
			g3.Location = location
			Me.G19.Name = "G19"
			Dim g4 As Global.System.Windows.Forms.Control = Me.G19
			size = New Global.System.Drawing.Size(22, 12)
			g4.Size = size
			Me.G19.TabIndex = 147
			Me.G19.Text = "G19"
			Me.G19.Visible = False
			Me.G18.AutoSize = True
			Me.G18.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g5 As Global.System.Windows.Forms.Control = Me.G18
			location = New Global.System.Drawing.Point(459, 39)
			g5.Location = location
			Me.G18.Name = "G18"
			Dim g6 As Global.System.Windows.Forms.Control = Me.G18
			size = New Global.System.Drawing.Size(22, 12)
			g6.Size = size
			Me.G18.TabIndex = 146
			Me.G18.Text = "G18"
			Me.G18.Visible = False
			Me.G17.AutoSize = True
			Me.G17.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g7 As Global.System.Windows.Forms.Control = Me.G17
			location = New Global.System.Drawing.Point(405, 39)
			g7.Location = location
			Me.G17.Name = "G17"
			Dim g8 As Global.System.Windows.Forms.Control = Me.G17
			size = New Global.System.Drawing.Size(22, 12)
			g8.Size = size
			Me.G17.TabIndex = 145
			Me.G17.Text = "G17"
			Me.G17.Visible = False
			Me.G16.AutoSize = True
			Me.G16.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g9 As Global.System.Windows.Forms.Control = Me.G16
			location = New Global.System.Drawing.Point(351, 39)
			g9.Location = location
			Me.G16.Name = "G16"
			Dim g10 As Global.System.Windows.Forms.Control = Me.G16
			size = New Global.System.Drawing.Size(22, 12)
			g10.Size = size
			Me.G16.TabIndex = 144
			Me.G16.Text = "G16"
			Me.G16.Visible = False
			Me.G15.AutoSize = True
			Me.G15.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g11 As Global.System.Windows.Forms.Control = Me.G15
			location = New Global.System.Drawing.Point(297, 39)
			g11.Location = location
			Me.G15.Name = "G15"
			Dim g12 As Global.System.Windows.Forms.Control = Me.G15
			size = New Global.System.Drawing.Size(22, 12)
			g12.Size = size
			Me.G15.TabIndex = 143
			Me.G15.Text = "G15"
			Me.G15.Visible = False
			Me.G14.AutoSize = True
			Me.G14.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g13 As Global.System.Windows.Forms.Control = Me.G14
			location = New Global.System.Drawing.Point(246, 39)
			g13.Location = location
			Me.G14.Name = "G14"
			Dim g14 As Global.System.Windows.Forms.Control = Me.G14
			size = New Global.System.Drawing.Size(22, 12)
			g14.Size = size
			Me.G14.TabIndex = 142
			Me.G14.Text = "G14"
			Me.G14.Visible = False
			Me.G13.AutoSize = True
			Me.G13.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g15 As Global.System.Windows.Forms.Control = Me.G13
			location = New Global.System.Drawing.Point(194, 39)
			g15.Location = location
			Me.G13.Name = "G13"
			Dim g16 As Global.System.Windows.Forms.Control = Me.G13
			size = New Global.System.Drawing.Size(22, 12)
			g16.Size = size
			Me.G13.TabIndex = 141
			Me.G13.Text = "G13"
			Me.G13.Visible = False
			Me.G12.AutoSize = True
			Me.G12.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g17 As Global.System.Windows.Forms.Control = Me.G12
			location = New Global.System.Drawing.Point(142, 39)
			g17.Location = location
			Me.G12.Name = "G12"
			Dim g18 As Global.System.Windows.Forms.Control = Me.G12
			size = New Global.System.Drawing.Size(22, 12)
			g18.Size = size
			Me.G12.TabIndex = 140
			Me.G12.Text = "G12"
			Me.G12.Visible = False
			Me.G11.AutoSize = True
			Me.G11.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g19 As Global.System.Windows.Forms.Control = Me.G11
			location = New Global.System.Drawing.Point(91, 39)
			g19.Location = location
			Me.G11.Name = "G11"
			Dim g20 As Global.System.Windows.Forms.Control = Me.G11
			size = New Global.System.Drawing.Size(21, 12)
			g20.Size = size
			Me.G11.TabIndex = 139
			Me.G11.Text = "G11"
			Me.G11.Visible = False
			Me.lblNumGuidesPerRod.AutoSize = True
			Me.lblNumGuidesPerRod.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim lblNumGuidesPerRod3 As Global.System.Windows.Forms.Control = Me.lblNumGuidesPerRod
			location = New Global.System.Drawing.Point(2, 11)
			lblNumGuidesPerRod3.Location = location
			Me.lblNumGuidesPerRod.Name = "lblNumGuidesPerRod"
			Dim lblNumGuidesPerRod4 As Global.System.Windows.Forms.Control = Me.lblNumGuidesPerRod
			size = New Global.System.Drawing.Size(65, 12)
			lblNumGuidesPerRod4.Size = size
			Me.lblNumGuidesPerRod.TabIndex = 138
			Me.lblNumGuidesPerRod.Text = "# Guides/Rod:"
			Me.lblNumGuidesPerRod.Visible = False
			Me.G10.AutoSize = True
			Me.G10.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g21 As Global.System.Windows.Forms.Control = Me.G10
			location = New Global.System.Drawing.Point(566, 11)
			g21.Location = location
			Me.G10.Name = "G10"
			Dim g22 As Global.System.Windows.Forms.Control = Me.G10
			size = New Global.System.Drawing.Size(22, 12)
			g22.Size = size
			Me.G10.TabIndex = 137
			Me.G10.Text = "G10"
			Me.G10.Visible = False
			Me.G9.AutoSize = True
			Me.G9.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g23 As Global.System.Windows.Forms.Control = Me.G9
			location = New Global.System.Drawing.Point(512, 11)
			g23.Location = location
			Me.G9.Name = "G9"
			Dim g24 As Global.System.Windows.Forms.Control = Me.G9
			size = New Global.System.Drawing.Size(17, 12)
			g24.Size = size
			Me.G9.TabIndex = 135
			Me.G9.Text = "G9"
			Me.G9.Visible = False
			Me.G8.AutoSize = True
			Me.G8.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g25 As Global.System.Windows.Forms.Control = Me.G8
			location = New Global.System.Drawing.Point(459, 11)
			g25.Location = location
			Me.G8.Name = "G8"
			Dim g26 As Global.System.Windows.Forms.Control = Me.G8
			size = New Global.System.Drawing.Size(17, 12)
			g26.Size = size
			Me.G8.TabIndex = 133
			Me.G8.Text = "G8"
			Me.G8.Visible = False
			Me.G7.AutoSize = True
			Me.G7.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g27 As Global.System.Windows.Forms.Control = Me.G7
			location = New Global.System.Drawing.Point(405, 11)
			g27.Location = location
			Me.G7.Name = "G7"
			Dim g28 As Global.System.Windows.Forms.Control = Me.G7
			size = New Global.System.Drawing.Size(17, 12)
			g28.Size = size
			Me.G7.TabIndex = 132
			Me.G7.Text = "G7"
			Me.G7.Visible = False
			Me.G6.AutoSize = True
			Me.G6.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g29 As Global.System.Windows.Forms.Control = Me.G6
			location = New Global.System.Drawing.Point(351, 11)
			g29.Location = location
			Me.G6.Name = "G6"
			Dim g30 As Global.System.Windows.Forms.Control = Me.G6
			size = New Global.System.Drawing.Size(17, 12)
			g30.Size = size
			Me.G6.TabIndex = 130
			Me.G6.Text = "G6"
			Me.G6.Visible = False
			Me.G5.AutoSize = True
			Me.G5.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g31 As Global.System.Windows.Forms.Control = Me.G5
			location = New Global.System.Drawing.Point(297, 11)
			g31.Location = location
			Me.G5.Name = "G5"
			Dim g32 As Global.System.Windows.Forms.Control = Me.G5
			size = New Global.System.Drawing.Size(17, 12)
			g32.Size = size
			Me.G5.TabIndex = 128
			Me.G5.Text = "G5"
			Me.G5.Visible = False
			Me.G4.AutoSize = True
			Me.G4.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g33 As Global.System.Windows.Forms.Control = Me.G4
			location = New Global.System.Drawing.Point(246, 11)
			g33.Location = location
			Me.G4.Name = "G4"
			Dim g34 As Global.System.Windows.Forms.Control = Me.G4
			size = New Global.System.Drawing.Size(17, 12)
			g34.Size = size
			Me.G4.TabIndex = 126
			Me.G4.Text = "G4"
			Me.G4.Visible = False
			Me.G3.AutoSize = True
			Me.G3.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g35 As Global.System.Windows.Forms.Control = Me.G3
			location = New Global.System.Drawing.Point(194, 11)
			g35.Location = location
			Me.G3.Name = "G3"
			Dim g36 As Global.System.Windows.Forms.Control = Me.G3
			size = New Global.System.Drawing.Size(17, 12)
			g36.Size = size
			Me.G3.TabIndex = 124
			Me.G3.Text = "G3"
			Me.G3.Visible = False
			Me.G2.AutoSize = True
			Me.G2.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g37 As Global.System.Windows.Forms.Control = Me.G2
			location = New Global.System.Drawing.Point(142, 11)
			g37.Location = location
			Me.G2.Name = "G2"
			Dim g38 As Global.System.Windows.Forms.Control = Me.G2
			size = New Global.System.Drawing.Size(17, 12)
			g38.Size = size
			Me.G2.TabIndex = 121
			Me.G2.Text = "G2"
			Me.G2.Visible = False
			Me.G1.AutoSize = True
			Me.G1.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim g39 As Global.System.Windows.Forms.Control = Me.G1
			location = New Global.System.Drawing.Point(91, 11)
			g39.Location = location
			Me.G1.Name = "G1"
			Dim g40 As Global.System.Windows.Forms.Control = Me.G1
			size = New Global.System.Drawing.Size(17, 12)
			g40.Size = size
			Me.G1.TabIndex = 119
			Me.G1.Text = "G1"
			Me.G1.Visible = False
			Me.lblDiameters.AutoSize = True
			Me.lblDiameters.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim lblDiameters3 As Global.System.Windows.Forms.Control = Me.lblDiameters
			location = New Global.System.Drawing.Point(2, -2)
			lblDiameters3.Location = location
			Me.lblDiameters.Name = "lblDiameters"
			Dim lblDiameters4 As Global.System.Windows.Forms.Control = Me.lblDiameters
			size = New Global.System.Drawing.Size(74, 12)
			lblDiameters4.Size = size
			Me.lblDiameters.TabIndex = 117
			Me.lblDiameters.Text = "Rod Diameters: "
			Me.T20.AutoSize = True
			Me.T20.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t As Global.System.Windows.Forms.Control = Me.T20
			location = New Global.System.Drawing.Point(566, 24)
			t.Location = location
			Me.T20.Name = "T20"
			Dim t2 As Global.System.Windows.Forms.Control = Me.T20
			size = New Global.System.Drawing.Size(26, 13)
			t2.Size = size
			Me.T20.TabIndex = 136
			Me.T20.Text = "T20"
			Me.T20.Visible = False
			Me.T19.AutoSize = True
			Me.T19.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t3 As Global.System.Windows.Forms.Control = Me.T19
			location = New Global.System.Drawing.Point(512, 24)
			t3.Location = location
			Me.T19.Name = "T19"
			Dim t4 As Global.System.Windows.Forms.Control = Me.T19
			size = New Global.System.Drawing.Size(26, 13)
			t4.Size = size
			Me.T19.TabIndex = 134
			Me.T19.Text = "T19"
			Me.T19.Visible = False
			Me.T18.AutoSize = True
			Me.T18.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t5 As Global.System.Windows.Forms.Control = Me.T18
			location = New Global.System.Drawing.Point(459, 24)
			t5.Location = location
			Me.T18.Name = "T18"
			Dim t6 As Global.System.Windows.Forms.Control = Me.T18
			size = New Global.System.Drawing.Size(26, 13)
			t6.Size = size
			Me.T18.TabIndex = 131
			Me.T18.Text = "T18"
			Me.T18.Visible = False
			Me.T17.AutoSize = True
			Me.T17.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t7 As Global.System.Windows.Forms.Control = Me.T17
			location = New Global.System.Drawing.Point(405, 24)
			t7.Location = location
			Me.T17.Name = "T17"
			Dim t8 As Global.System.Windows.Forms.Control = Me.T17
			size = New Global.System.Drawing.Size(26, 13)
			t8.Size = size
			Me.T17.TabIndex = 129
			Me.T17.Text = "T17"
			Me.T17.Visible = False
			Me.T16.AutoSize = True
			Me.T16.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t9 As Global.System.Windows.Forms.Control = Me.T16
			location = New Global.System.Drawing.Point(351, 24)
			t9.Location = location
			Me.T16.Name = "T16"
			Dim t10 As Global.System.Windows.Forms.Control = Me.T16
			size = New Global.System.Drawing.Size(26, 13)
			t10.Size = size
			Me.T16.TabIndex = 127
			Me.T16.Text = "T16"
			Me.T16.Visible = False
			Me.T15.AutoSize = True
			Me.T15.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t11 As Global.System.Windows.Forms.Control = Me.T15
			location = New Global.System.Drawing.Point(297, 24)
			t11.Location = location
			Me.T15.Name = "T15"
			Dim t12 As Global.System.Windows.Forms.Control = Me.T15
			size = New Global.System.Drawing.Size(26, 13)
			t12.Size = size
			Me.T15.TabIndex = 125
			Me.T15.Text = "T15"
			Me.T15.Visible = False
			Me.T14.AutoSize = True
			Me.T14.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t13 As Global.System.Windows.Forms.Control = Me.T14
			location = New Global.System.Drawing.Point(246, 24)
			t13.Location = location
			Me.T14.Name = "T14"
			Dim t14 As Global.System.Windows.Forms.Control = Me.T14
			size = New Global.System.Drawing.Size(26, 13)
			t14.Size = size
			Me.T14.TabIndex = 123
			Me.T14.Text = "T14"
			Me.T14.Visible = False
			Me.T13.AutoSize = True
			Me.T13.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t15 As Global.System.Windows.Forms.Control = Me.T13
			location = New Global.System.Drawing.Point(194, 24)
			t15.Location = location
			Me.T13.Name = "T13"
			Dim t16 As Global.System.Windows.Forms.Control = Me.T13
			size = New Global.System.Drawing.Size(26, 13)
			t16.Size = size
			Me.T13.TabIndex = 122
			Me.T13.Text = "T13"
			Me.T13.Visible = False
			Me.T12.AutoSize = True
			Me.T12.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t17 As Global.System.Windows.Forms.Control = Me.T12
			location = New Global.System.Drawing.Point(142, 24)
			t17.Location = location
			Me.T12.Name = "T12"
			Dim t18 As Global.System.Windows.Forms.Control = Me.T12
			size = New Global.System.Drawing.Size(26, 13)
			t18.Size = size
			Me.T12.TabIndex = 120
			Me.T12.Text = "T12"
			Me.T12.Visible = False
			Me.T11.AutoSize = True
			Me.T11.Font = New Global.System.Drawing.Font("Arial", 7F)
			Dim t19 As Global.System.Windows.Forms.Control = Me.T11
			location = New Global.System.Drawing.Point(91, 24)
			t19.Location = location
			Me.T11.Name = "T11"
			Dim t20 As Global.System.Windows.Forms.Control = Me.T11
			size = New Global.System.Drawing.Size(25, 13)
			t20.Size = size
			Me.T11.TabIndex = 118
			Me.T11.Text = "T11"
			Me.T11.Visible = False
			Me.T10.AutoSize = True
			Me.T10.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim t21 As Global.System.Windows.Forms.Control = Me.T10
			location = New Global.System.Drawing.Point(566, -2)
			t21.Location = location
			Me.T10.Name = "T10"
			Dim t22 As Global.System.Windows.Forms.Control = Me.T10
			size = New Global.System.Drawing.Size(20, 12)
			t22.Size = size
			Me.T10.TabIndex = 116
			Me.T10.Text = "T10"
			Me.T10.Visible = False
			Me.T9.AutoSize = True
			Me.T9.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim t23 As Global.System.Windows.Forms.Control = Me.T9
			location = New Global.System.Drawing.Point(512, -2)
			t23.Location = location
			Me.T9.Name = "T9"
			Dim t24 As Global.System.Windows.Forms.Control = Me.T9
			size = New Global.System.Drawing.Size(15, 12)
			t24.Size = size
			Me.T9.TabIndex = 115
			Me.T9.Text = "T9"
			Me.T9.Visible = False
			Me.T8.AutoSize = True
			Me.T8.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim t25 As Global.System.Windows.Forms.Control = Me.T8
			location = New Global.System.Drawing.Point(459, -2)
			t25.Location = location
			Me.T8.Name = "T8"
			Dim t26 As Global.System.Windows.Forms.Control = Me.T8
			size = New Global.System.Drawing.Size(15, 12)
			t26.Size = size
			Me.T8.TabIndex = 114
			Me.T8.Text = "T8"
			Me.T8.Visible = False
			Me.T7.AutoSize = True
			Me.T7.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim t27 As Global.System.Windows.Forms.Control = Me.T7
			location = New Global.System.Drawing.Point(405, -2)
			t27.Location = location
			Me.T7.Name = "T7"
			Dim t28 As Global.System.Windows.Forms.Control = Me.T7
			size = New Global.System.Drawing.Size(15, 12)
			t28.Size = size
			Me.T7.TabIndex = 113
			Me.T7.Text = "T7"
			Me.T7.Visible = False
			Me.T6.AutoSize = True
			Me.T6.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim t29 As Global.System.Windows.Forms.Control = Me.T6
			location = New Global.System.Drawing.Point(351, -2)
			t29.Location = location
			Me.T6.Name = "T6"
			Dim t30 As Global.System.Windows.Forms.Control = Me.T6
			size = New Global.System.Drawing.Size(15, 12)
			t30.Size = size
			Me.T6.TabIndex = 112
			Me.T6.Text = "T6"
			Me.T6.Visible = False
			Me.T5.AutoSize = True
			Me.T5.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim t31 As Global.System.Windows.Forms.Control = Me.T5
			location = New Global.System.Drawing.Point(297, -2)
			t31.Location = location
			Me.T5.Name = "T5"
			Dim t32 As Global.System.Windows.Forms.Control = Me.T5
			size = New Global.System.Drawing.Size(15, 12)
			t32.Size = size
			Me.T5.TabIndex = 111
			Me.T5.Text = "T5"
			Me.T5.Visible = False
			Me.T4.AutoSize = True
			Me.T4.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim t33 As Global.System.Windows.Forms.Control = Me.T4
			location = New Global.System.Drawing.Point(246, -2)
			t33.Location = location
			Me.T4.Name = "T4"
			Dim t34 As Global.System.Windows.Forms.Control = Me.T4
			size = New Global.System.Drawing.Size(15, 12)
			t34.Size = size
			Me.T4.TabIndex = 110
			Me.T4.Text = "T4"
			Me.T4.Visible = False
			Me.T3.AutoSize = True
			Me.T3.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim t35 As Global.System.Windows.Forms.Control = Me.T3
			location = New Global.System.Drawing.Point(194, -2)
			t35.Location = location
			Me.T3.Name = "T3"
			Dim t36 As Global.System.Windows.Forms.Control = Me.T3
			size = New Global.System.Drawing.Size(15, 12)
			t36.Size = size
			Me.T3.TabIndex = 109
			Me.T3.Text = "T3"
			Me.T3.Visible = False
			Me.T2.AutoSize = True
			Me.T2.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim t37 As Global.System.Windows.Forms.Control = Me.T2
			location = New Global.System.Drawing.Point(142, -2)
			t37.Location = location
			Me.T2.Name = "T2"
			Dim t38 As Global.System.Windows.Forms.Control = Me.T2
			size = New Global.System.Drawing.Size(15, 12)
			t38.Size = size
			Me.T2.TabIndex = 108
			Me.T2.Text = "T2"
			Me.T2.Visible = False
			Me.T1.AutoSize = True
			Me.T1.Font = New Global.System.Drawing.Font("Arial", 6.75F)
			Dim t39 As Global.System.Windows.Forms.Control = Me.T1
			location = New Global.System.Drawing.Point(91, -2)
			t39.Location = location
			Me.T1.Name = "T1"
			Dim t40 As Global.System.Windows.Forms.Control = Me.T1
			size = New Global.System.Drawing.Size(15, 12)
			t40.Size = size
			Me.T1.TabIndex = 107
			Me.T1.Text = "T1"
			Me.T1.Visible = False
			Me.VScrollBar1.Dock = Global.System.Windows.Forms.DockStyle.Right
			Dim vscrollBar As Global.System.Windows.Forms.Control = Me.VScrollBar1
			location = New Global.System.Drawing.Point(783, 0)
			vscrollBar.Location = location
			Me.VScrollBar1.Name = "VScrollBar1"
			Dim vscrollBar2 As Global.System.Windows.Forms.Control = Me.VScrollBar1
			size = New Global.System.Drawing.Size(17, 57)
			vscrollBar2.Size = size
			Me.VScrollBar1.TabIndex = 50
			Me.VScrollBar1.Visible = False
			Me.pnlCommander.Controls.Add(Me.btnResetPlot)
			Me.pnlCommander.Controls.Add(Me.commander1)
			Me.pnlCommander.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim pnlCommander As Global.System.Windows.Forms.Control = Me.pnlCommander
			location = New Global.System.Drawing.Point(0, 0)
			pnlCommander.Location = location
			Me.pnlCommander.Name = "pnlCommander"
			Dim pnlCommander2 As Global.System.Windows.Forms.Control = Me.pnlCommander
			size = New Global.System.Drawing.Size(800, 29)
			pnlCommander2.Size = size
			Me.pnlCommander.TabIndex = 12
			Me.commander1.Appearance = Global.System.Windows.Forms.ToolBarAppearance.Flat
			Me.commander1.Chart = Me.TChart1
			Me.commander1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.commander1.DropDownArrows = True
			Me.commander1.LabelValues = True
			Dim commander As Global.System.Windows.Forms.Control = Me.commander1
			location = New Global.System.Drawing.Point(0, 0)
			commander.Location = location
			Me.commander1.Name = "commander1"
			Me.commander1.ShowToolTips = True
			Dim commander2 As Global.System.Windows.Forms.Control = Me.commander1
			size = New Global.System.Drawing.Size(800, 37)
			commander2.Size = size
			Me.commander1.TabIndex = 15
			Me.TChart1.Aspect.Chart3DPercent = 100
			Me.TChart1.Aspect.ZOffset = 0.0
			Me.TChart1.Axes.Bottom.Automatic = False
			Me.TChart1.Axes.Bottom.AutomaticMaximum = False
			Me.TChart1.Axes.Bottom.AutomaticMinimum = False
			Me.TChart1.Axes.Bottom.Maximum = 99.87439988175146
			Me.TChart1.Axes.Bottom.MaximumOffset = 5
			Me.TChart1.Axes.Bottom.Minimum = 2.729538689707191
			Me.TChart1.Axes.Bottom.MinimumOffset = 5
			Me.TChart1.Axes.Bottom.Title.Caption = "East - West"
			Me.TChart1.Axes.Bottom.Title.Lines = New String() { "East - West" }
			Me.TChart1.Axes.Depth.Automatic = False
			Me.TChart1.Axes.Depth.AutomaticMaximum = False
			Me.TChart1.Axes.Depth.AutomaticMinimum = False
			Me.TChart1.Axes.Depth.Maximum = 103.13788388489647
			Me.TChart1.Axes.Depth.Minimum = 0.861385232238744
			Me.TChart1.Axes.Depth.Title.Caption = "North - South"
			Me.TChart1.Axes.Depth.Title.Lines = New String() { "North - South" }
			Me.TChart1.Axes.Depth.Visible = True
			Me.TChart1.Axes.DepthTop.Automatic = False
			Me.TChart1.Axes.DepthTop.AutomaticMaximum = False
			Me.TChart1.Axes.DepthTop.AutomaticMinimum = False
			Me.TChart1.Axes.DepthTop.Maximum = 103.13788388489647
			Me.TChart1.Axes.DepthTop.Minimum = 0.861385232238744
			Me.TChart1.Axes.Left.Automatic = False
			Me.TChart1.Axes.Left.AutomaticMaximum = False
			Me.TChart1.Axes.Left.AutomaticMinimum = False
			Me.TChart1.Axes.Left.Inverted = True
			Me.TChart1.Axes.Left.Maximum = 99.62384542432793
			Me.TChart1.Axes.Left.MaximumOffset = 5
			Me.TChart1.Axes.Left.Minimum = 0.34958305784947385
			Me.TChart1.Axes.Left.MinimumOffset = 5
			Me.TChart1.Axes.Left.Title.Caption = "True Vertical Depth"
			Me.TChart1.Axes.Left.Title.Font.Size = 9
			Me.TChart1.Axes.Left.Title.Font.SizeFloat = 9F
			Me.TChart1.Axes.Left.Title.Lines = New String() { "True Vertical Depth" }
			Me.TChart1.Axes.Right.Automatic = False
			Me.TChart1.Axes.Right.AutomaticMaximum = False
			Me.TChart1.Axes.Right.AutomaticMinimum = False
			Me.TChart1.Axes.Right.Maximum = 0.0
			Me.TChart1.Axes.Right.Minimum = 0.0
			Me.TChart1.Axes.Top.Automatic = False
			Me.TChart1.Axes.Top.AutomaticMaximum = False
			Me.TChart1.Axes.Top.AutomaticMinimum = False
			Me.TChart1.Axes.Top.Maximum = 0.0
			Me.TChart1.Axes.Top.Minimum = 0.0
			Me.TChart1.BackColor = Global.System.Drawing.Color.Transparent
			Me.TChart1.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me.TChart1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.TChart1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.TChart1.Header.Brush.Gradient.MiddleColor = Global.System.Drawing.Color.FromArgb(255, 255, 255)
			Me.TChart1.Header.Brush.Gradient.StartColor = Global.System.Drawing.Color.FromArgb(0, 0, 255)
			Me.TChart1.Header.Brush.Gradient.UseMiddle = True
			Me.TChart1.Header.Brush.Gradient.Visible = True
			Me.TChart1.Header.Font.Brush.Color = Global.System.Drawing.Color.Black
			Me.TChart1.Header.Font.Shadow.Visible = True
			Me.TChart1.Header.Font.Size = 9
			Me.TChart1.Header.Font.SizeFloat = 9F
			Me.TChart1.Header.Lines = New String() { "" }
			Me.TChart1.Header.Shadow.Visible = True
			Me.TChart1.Legend.Alignment = Global.Steema.TeeChart.LegendAlignments.Bottom
			Me.TChart1.Legend.Font.Size = 7
			Me.TChart1.Legend.Font.SizeFloat = 7F
			Me.TChart1.Legend.LegendStyle = Global.Steema.TeeChart.LegendStyles.Series
			Me.TChart1.Legend.MaxNumRows = 1
			Me.TChart1.Legend.Shadow.Visible = False
			Dim tchart As Global.System.Windows.Forms.Control = Me.TChart1
			location = New Global.System.Drawing.Point(0, 0)
			tchart.Location = location
			Me.TChart1.Name = "TChart1"
			Me.TChart1.Panel.Bevel.Outer = Global.Steema.TeeChart.Drawing.BevelStyles.None
			Me.TChart1.Panel.Brush.Color = Global.System.Drawing.Color.FromArgb(0, 255, 255, 255)
			Me.TChart1.Panel.Brush.Gradient.MiddleColor = Global.System.Drawing.Color.FromArgb(255, 255, 255)
			Me.TChart1.Panel.Brush.Gradient.StartColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.TChart1.Panel.Shadow.Brush.Color = Global.System.Drawing.Color.FromArgb(255, 255, 255)
			Me.TChart1.Panel.Shadow.Visible = True
			Me.TChart1.Series.Add(Me.point3DSeries1)
			Me.TChart1.Series.Add(Me.point3DSeries2)
			Dim tchart2 As Global.System.Windows.Forms.Control = Me.TChart1
			size = New Global.System.Drawing.Size(800, 476)
			tchart2.Size = size
			Me.TChart1.TabIndex = 11
			Me.TChart1.Tools.Add(Me.MarksTip1)
			Me.point3DSeries1.Color = Global.System.Drawing.Color.FromArgb(68, 102, 163)
			Me.point3DSeries1.ColorEach = False
			Me.point3DSeries1.DepthSize = 7.0
			Me.point3DSeries1.LinePen.Color = Global.System.Drawing.Color.FromArgb(254, 0, 0, 255)
			Me.point3DSeries1.LinePen.EndCap = Global.System.Drawing.Drawing2D.LineCap.Round
			Me.point3DSeries1.LinePen.Width = 2
			Me.point3DSeries1.Marks.Callout.ArrowHead = Global.Steema.TeeChart.Styles.ArrowHeadStyles.None
			Me.point3DSeries1.Marks.Callout.ArrowHeadSize = 8
			Me.point3DSeries1.Marks.Callout.Brush.Color = Global.System.Drawing.Color.Black
			Me.point3DSeries1.Marks.Callout.Distance = 0
			Me.point3DSeries1.Marks.Callout.Draw3D = False
			Me.point3DSeries1.Marks.Callout.Length = 10
			Me.point3DSeries1.Marks.Callout.Series = Me.point3DSeries1
			Me.point3DSeries1.Marks.Callout.Style = Global.Steema.TeeChart.Styles.PointerStyles.Rectangle
			Me.point3DSeries1.Marks.Callout.Visible = False
			Me.point3DSeries1.Marks.Series = Me.point3DSeries1
			Me.point3DSeries1.Marks.Shadow.Visible = False
			Me.point3DSeries1.Marks.ShapeStyle = Global.Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle
			Me.point3DSeries1.Marks.Style = Global.Steema.TeeChart.Styles.MarksStyles.Value
			Me.point3DSeries1.Pointer.Brush.Gradient.StartColor = Global.System.Drawing.Color.FromArgb(68, 102, 163)
			Me.point3DSeries1.Pointer.Dark3D = False
			Me.point3DSeries1.Pointer.Draw3D = False
			Me.point3DSeries1.Pointer.HorizSize = 1
			Me.point3DSeries1.Pointer.InflateMargins = False
			Me.point3DSeries1.Pointer.Pen.Color = Global.System.Drawing.Color.FromArgb(41, 61, 98)
			Me.point3DSeries1.Pointer.Series = Me.point3DSeries1
			Me.point3DSeries1.Pointer.Style = Global.Steema.TeeChart.Styles.PointerStyles.[Nothing]
			Me.point3DSeries1.Pointer.VertSize = 1
			Me.point3DSeries1.ShowInLegend = False
			Me.point3DSeries1.Title = "point3D1"
			Me.point3DSeries1.XValues.DataMember = "X"
			Me.point3DSeries1.YValues.DataMember = "Y"
			Me.point3DSeries1.ZValues.DataMember = "Z"
			Me.point3DSeries2.Color = Global.System.Drawing.Color.Blue
			Me.point3DSeries2.ColorEach = False
			Me.point3DSeries2.LinePen.Color = Global.System.Drawing.Color.White
			Me.point3DSeries2.LinePen.EndCap = Global.System.Drawing.Drawing2D.LineCap.Round
			Me.point3DSeries2.LinePen.Style = Global.System.Drawing.Drawing2D.DashStyle.Dot
			Me.point3DSeries2.Marks.Callout.ArrowHead = Global.Steema.TeeChart.Styles.ArrowHeadStyles.None
			Me.point3DSeries2.Marks.Callout.ArrowHeadSize = 8
			Me.point3DSeries2.Marks.Callout.Brush.Color = Global.System.Drawing.Color.Black
			Me.point3DSeries2.Marks.Callout.Distance = 0
			Me.point3DSeries2.Marks.Callout.Draw3D = False
			Me.point3DSeries2.Marks.Callout.Length = 10
			Me.point3DSeries2.Marks.Callout.Series = Me.point3DSeries2
			Me.point3DSeries2.Marks.Callout.Style = Global.Steema.TeeChart.Styles.PointerStyles.Rectangle
			Me.point3DSeries2.Marks.Callout.Visible = False
			Me.point3DSeries2.Marks.Series = Me.point3DSeries2
			Me.point3DSeries2.Pointer.Brush.Gradient.StartColor = Global.System.Drawing.Color.FromArgb(243, 156, 53)
			Me.point3DSeries2.Pointer.Pen.Color = Global.System.Drawing.Color.FromArgb(146, 94, 32)
			Me.point3DSeries2.Pointer.Series = Me.point3DSeries2
			Me.point3DSeries2.Pointer.Style = Global.Steema.TeeChart.Styles.PointerStyles.Circle
			Me.point3DSeries2.Title = "Rod Guides"
			Me.point3DSeries2.XValues.DataMember = "X"
			Me.point3DSeries2.YValues.DataMember = "Y"
			Me.point3DSeries2.ZValues.DataMember = "Z"
			Me.MarksTip1.Style = Global.Steema.TeeChart.Styles.MarksStyles.XY
			Me.pnlDevPlot.Controls.Add(Me.TChart1)
			Me.pnlDevPlot.Controls.Add(Me.lblNoData)
			Me.pnlDevPlot.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim pnlDevPlot As Global.System.Windows.Forms.Control = Me.pnlDevPlot
			location = New Global.System.Drawing.Point(0, 0)
			pnlDevPlot.Location = location
			Me.pnlDevPlot.Name = "pnlDevPlot"
			Dim pnlDevPlot2 As Global.System.Windows.Forms.Control = Me.pnlDevPlot
			size = New Global.System.Drawing.Size(800, 476)
			pnlDevPlot2.Size = size
			Me.pnlDevPlot.TabIndex = 13
			Me.lblNoData.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblNoData.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblNoData As Global.System.Windows.Forms.Control = Me.lblNoData
			location = New Global.System.Drawing.Point(0, 104)
			lblNoData.Location = location
			Me.lblNoData.Name = "lblNoData"
			Dim lblNoData2 As Global.System.Windows.Forms.Control = Me.lblNoData
			size = New Global.System.Drawing.Size(576, 24)
			lblNoData2.Size = size
			Me.lblNoData.TabIndex = 12
			Me.lblNoData.Text = "Valid survey data not available for plotting!"
			Me.lblNoData.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblNoData.Visible = False
			Me.ChartFX_LookingNorth.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_LookingNorth.AllSeries.MarkerSize = 4S
			Me.ChartFX_LookingNorth.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.ChartFX_LookingNorth.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_LookingNorth.AxisX.Grids.Major.Visible = False
			Me.ChartFX_LookingNorth.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_LookingNorth.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_LookingNorth.AxisY.Grids.Major.Visible = False
			Me.ChartFX_LookingNorth.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground16.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_LookingNorth.Background = gradientBackground16
			Me.ChartFX_LookingNorth.Border = border12
			Me.ChartFX_LookingNorth.ContextMenus = False
			Me.ChartFX_LookingNorth.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_LookingNorth As Global.System.Windows.Forms.Control = Me.ChartFX_LookingNorth
			location = New Global.System.Drawing.Point(31, 16)
			chartFX_LookingNorth.Location = location
			Me.ChartFX_LookingNorth.Name = "ChartFX_LookingNorth"
			Dim chartFX_LookingNorth2 As Global.System.Windows.Forms.Control = Me.ChartFX_LookingNorth
			size = New Global.System.Drawing.Size(685, 381)
			chartFX_LookingNorth2.Size = size
			Me.ChartFX_LookingNorth.TabIndex = 12
			titleDockable16.Text = "Looking West"
			Me.ChartFX_LookingNorth.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable16 })
			Me.ChartFX_LookingNorth.Visible = False
			Me.ChartFX_SideLoading.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_SideLoading.AllSeries.MarkerSize = 4S
			Me.ChartFX_SideLoading.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.ChartFX_SideLoading.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_SideLoading.AxisX.Grids.Major.Visible = False
			Me.ChartFX_SideLoading.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_SideLoading.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_SideLoading.AxisY.Grids.Major.Visible = False
			Me.ChartFX_SideLoading.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground17.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_SideLoading.Background = gradientBackground17
			Me.ChartFX_SideLoading.Border = border13
			Me.ChartFX_SideLoading.ContextMenus = False
			Me.ChartFX_SideLoading.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_SideLoading As Global.System.Windows.Forms.Control = Me.ChartFX_SideLoading
			location = New Global.System.Drawing.Point(24, 16)
			chartFX_SideLoading.Location = location
			Me.ChartFX_SideLoading.Name = "ChartFX_SideLoading"
			Dim chartFX_SideLoading2 As Global.System.Windows.Forms.Control = Me.ChartFX_SideLoading
			size = New Global.System.Drawing.Size(692, 384)
			chartFX_SideLoading2.Size = size
			Me.ChartFX_SideLoading.TabIndex = 11
			titleDockable17.Text = "Side Loading"
			Me.ChartFX_SideLoading.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable17 })
			Me.ChartFX_SideLoading.Visible = False
			Me.ChartFX_BucklingTendency.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_BucklingTendency.AllSeries.MarkerSize = 4S
			Me.ChartFX_BucklingTendency.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.ChartFX_BucklingTendency.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_BucklingTendency.AxisX.Grids.Major.Visible = False
			Me.ChartFX_BucklingTendency.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_BucklingTendency.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_BucklingTendency.AxisY.Grids.Major.Visible = False
			Me.ChartFX_BucklingTendency.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground18.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_BucklingTendency.Background = gradientBackground18
			Me.ChartFX_BucklingTendency.Border = border14
			Me.ChartFX_BucklingTendency.ContextMenus = False
			Me.ChartFX_BucklingTendency.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_BucklingTendency As Global.System.Windows.Forms.Control = Me.ChartFX_BucklingTendency
			location = New Global.System.Drawing.Point(31, 16)
			chartFX_BucklingTendency.Location = location
			Me.ChartFX_BucklingTendency.Name = "ChartFX_BucklingTendency"
			Dim chartFX_BucklingTendency2 As Global.System.Windows.Forms.Control = Me.ChartFX_BucklingTendency
			size = New Global.System.Drawing.Size(685, 384)
			chartFX_BucklingTendency2.Size = size
			Me.ChartFX_BucklingTendency.TabIndex = 10
			titleDockable18.Text = "Buckling tendency"
			Me.ChartFX_BucklingTendency.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable18 })
			Me.ChartFX_BucklingTendency.Visible = False
			Me.ChartFX_AxialLoads.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_AxialLoads.AllSeries.MarkerSize = 4S
			Me.ChartFX_AxialLoads.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.ChartFX_AxialLoads.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_AxialLoads.AxisX.Grids.Major.Visible = False
			Me.ChartFX_AxialLoads.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_AxialLoads.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_AxialLoads.AxisY.Grids.Major.Visible = False
			Me.ChartFX_AxialLoads.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground19.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_AxialLoads.Background = gradientBackground19
			Me.ChartFX_AxialLoads.Border = border15
			Me.ChartFX_AxialLoads.ContextMenus = False
			Me.ChartFX_AxialLoads.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_AxialLoads As Global.System.Windows.Forms.Control = Me.ChartFX_AxialLoads
			location = New Global.System.Drawing.Point(31, 16)
			chartFX_AxialLoads.Location = location
			Me.ChartFX_AxialLoads.Name = "ChartFX_AxialLoads"
			Dim chartFX_AxialLoads2 As Global.System.Windows.Forms.Control = Me.ChartFX_AxialLoads
			size = New Global.System.Drawing.Size(685, 384)
			chartFX_AxialLoads2.Size = size
			Me.ChartFX_AxialLoads.TabIndex = 9
			titleDockable19.Text = "Max/Min Axial Loading"
			Me.ChartFX_AxialLoads.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable19 })
			Me.ChartFX_AxialLoads.Visible = False
			Me.ChartFX_DoglegSeverity.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_DoglegSeverity.AllSeries.MarkerSize = 4S
			Me.ChartFX_DoglegSeverity.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.ChartFX_DoglegSeverity.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_DoglegSeverity.AxisX.Grids.Major.Visible = False
			Me.ChartFX_DoglegSeverity.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_DoglegSeverity.AxisX.Title.Text = "Dogleg Severity"
			Me.ChartFX_DoglegSeverity.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_DoglegSeverity.AxisY.Grids.Major.Visible = False
			Me.ChartFX_DoglegSeverity.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_DoglegSeverity.AxisY.Title.Text = "Measured Depth"
			gradientBackground20.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_DoglegSeverity.Background = gradientBackground20
			Me.ChartFX_DoglegSeverity.Border = border16
			Me.ChartFX_DoglegSeverity.ContextMenus = False
			Me.ChartFX_DoglegSeverity.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_DoglegSeverity As Global.System.Windows.Forms.Control = Me.ChartFX_DoglegSeverity
			location = New Global.System.Drawing.Point(31, 16)
			chartFX_DoglegSeverity.Location = location
			Me.ChartFX_DoglegSeverity.Name = "ChartFX_DoglegSeverity"
			Dim chartFX_DoglegSeverity2 As Global.System.Windows.Forms.Control = Me.ChartFX_DoglegSeverity
			size = New Global.System.Drawing.Size(685, 384)
			chartFX_DoglegSeverity2.Size = size
			Me.ChartFX_DoglegSeverity.TabIndex = 15
			titleDockable20.Text = "Dogleg Severity"
			Me.ChartFX_DoglegSeverity.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable20 })
			Me.ChartFX_DoglegSeverity.Visible = False
			Me.ChartFX_LookingDown.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_LookingDown.AllSeries.MarkerSize = 4S
			Me.ChartFX_LookingDown.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.ChartFX_LookingDown.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_LookingDown.AxisX.Grids.Major.Visible = False
			Me.ChartFX_LookingDown.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_LookingDown.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_LookingDown.AxisY.Grids.Major.Visible = False
			Me.ChartFX_LookingDown.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground21.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_LookingDown.Background = gradientBackground21
			Me.ChartFX_LookingDown.Border = border17
			Me.ChartFX_LookingDown.ContextMenus = False
			Me.ChartFX_LookingDown.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_LookingDown As Global.System.Windows.Forms.Control = Me.ChartFX_LookingDown
			location = New Global.System.Drawing.Point(16, 16)
			chartFX_LookingDown.Location = location
			Me.ChartFX_LookingDown.Name = "ChartFX_LookingDown"
			Dim chartFX_LookingDown2 As Global.System.Windows.Forms.Control = Me.ChartFX_LookingDown
			size = New Global.System.Drawing.Size(700, 384)
			chartFX_LookingDown2.Size = size
			Me.ChartFX_LookingDown.TabIndex = 14
			titleDockable21.Text = "Looking Down - Trajectory"
			Me.ChartFX_LookingDown.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable21 })
			Me.ChartFX_LookingDown.Visible = False
			Me.ChartFX_LookingEast.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_LookingEast.AllSeries.MarkerSize = 4S
			Me.ChartFX_LookingEast.AxesStyle = Global.ChartFX.WinForms.AxesStyle.None
			Me.ChartFX_LookingEast.AxisX.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_LookingEast.AxisX.Grids.Major.Visible = False
			Me.ChartFX_LookingEast.AxisX.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			Me.ChartFX_LookingEast.AxisY.Grids.Major.TickMark = Global.ChartFX.WinForms.TickMark.Cross
			Me.ChartFX_LookingEast.AxisY.Grids.Major.Visible = False
			Me.ChartFX_LookingEast.AxisY.Grids.Minor.TickMark = Global.ChartFX.WinForms.TickMark.None
			gradientBackground22.ColorFrom = Global.System.Drawing.Color.FromArgb(215, 225, 243)
			Me.ChartFX_LookingEast.Background = gradientBackground22
			Me.ChartFX_LookingEast.Border = border18
			Me.ChartFX_LookingEast.ContextMenus = False
			Me.ChartFX_LookingEast.LegendBox.Dock = Global.ChartFX.WinForms.DockArea.Bottom
			Dim chartFX_LookingEast As Global.System.Windows.Forms.Control = Me.ChartFX_LookingEast
			location = New Global.System.Drawing.Point(21, 18)
			chartFX_LookingEast.Location = location
			Me.ChartFX_LookingEast.Name = "ChartFX_LookingEast"
			Me.ChartFX_LookingEast.PlotAreaColor = Global.System.Drawing.Color.Transparent
			Dim chartFX_LookingEast2 As Global.System.Windows.Forms.Control = Me.ChartFX_LookingEast
			size = New Global.System.Drawing.Size(706, 381)
			chartFX_LookingEast2.Size = size
			Me.ChartFX_LookingEast.TabIndex = 28
			titleDockable22.Text = "Looking North"
			Me.ChartFX_LookingEast.Titles.AddRange(New Global.ChartFX.WinForms.TitleDockable() { titleDockable22 })
			Me.ChartFX_LookingEast.Visible = False
			Me.btnPrevDevChart.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPrevDevChart As Global.System.Windows.Forms.Control = Me.btnPrevDevChart
			location = New Global.System.Drawing.Point(312, 439)
			btnPrevDevChart.Location = location
			Me.btnPrevDevChart.Name = "btnPrevDevChart"
			Dim btnPrevDevChart2 As Global.System.Windows.Forms.Control = Me.btnPrevDevChart
			size = New Global.System.Drawing.Size(80, 23)
			btnPrevDevChart2.Size = size
			Me.btnPrevDevChart.TabIndex = 16
			Me.btnPrevDevChart.Text = "<< Previous"
			Me.btnPrevDevChart.Visible = False
			Me.btnNextDevChart.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnNextDevChart As Global.System.Windows.Forms.Control = Me.btnNextDevChart
			location = New Global.System.Drawing.Point(392, 439)
			btnNextDevChart.Location = location
			Me.btnNextDevChart.Name = "btnNextDevChart"
			Dim btnNextDevChart2 As Global.System.Windows.Forms.Control = Me.btnNextDevChart
			size = New Global.System.Drawing.Size(80, 23)
			btnNextDevChart2.Size = size
			Me.btnNextDevChart.TabIndex = 17
			Me.btnNextDevChart.Text = "Next>>"
			Me.btnNextDevChart.Visible = False
			Me.point3DSeries1_report.Color = Global.System.Drawing.Color.FromArgb(68, 102, 163)
			Me.point3DSeries1_report.ColorEach = False
			Me.point3DSeries1_report.DepthSize = 7.0
			Me.point3DSeries1_report.LinePen.Color = Global.System.Drawing.Color.FromArgb(254, 0, 0, 255)
			Me.point3DSeries1_report.LinePen.EndCap = Global.System.Drawing.Drawing2D.LineCap.Round
			Me.point3DSeries1_report.LinePen.Width = 3
			Me.point3DSeries1_report.Marks.Callout.ArrowHead = Global.Steema.TeeChart.Styles.ArrowHeadStyles.None
			Me.point3DSeries1_report.Marks.Callout.ArrowHeadSize = 8
			Me.point3DSeries1_report.Marks.Callout.Brush.Color = Global.System.Drawing.Color.Black
			Me.point3DSeries1_report.Marks.Callout.Distance = 0
			Me.point3DSeries1_report.Marks.Callout.Draw3D = False
			Me.point3DSeries1_report.Marks.Callout.Length = 10
			Me.point3DSeries1_report.Marks.Callout.Series = Me.point3DSeries1_report
			Me.point3DSeries1_report.Marks.Callout.Style = Global.Steema.TeeChart.Styles.PointerStyles.Rectangle
			Me.point3DSeries1_report.Marks.Callout.Visible = False
			Me.point3DSeries1_report.Marks.Series = Me.point3DSeries1_report
			Me.point3DSeries1_report.Marks.Shadow.Visible = False
			Me.point3DSeries1_report.Marks.ShapeStyle = Global.Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle
			Me.point3DSeries1_report.Marks.Style = Global.Steema.TeeChart.Styles.MarksStyles.Value
			Me.point3DSeries1_report.Pointer.Brush.Gradient.StartColor = Global.System.Drawing.Color.FromArgb(68, 102, 163)
			Me.point3DSeries1_report.Pointer.Dark3D = False
			Me.point3DSeries1_report.Pointer.Draw3D = False
			Me.point3DSeries1_report.Pointer.HorizSize = 1
			Me.point3DSeries1_report.Pointer.InflateMargins = False
			Me.point3DSeries1_report.Pointer.Pen.Color = Global.System.Drawing.Color.FromArgb(41, 61, 98)
			Me.point3DSeries1_report.Pointer.Series = Me.point3DSeries1_report
			Me.point3DSeries1_report.Pointer.Style = Global.Steema.TeeChart.Styles.PointerStyles.[Nothing]
			Me.point3DSeries1_report.Pointer.VertSize = 1
			Me.point3DSeries1_report.ShowInLegend = False
			Me.point3DSeries1_report.Title = "point3D1"
			Me.point3DSeries1_report.XValues.DataMember = "X"
			Me.point3DSeries1_report.YValues.DataMember = "Y"
			Me.point3DSeries1_report.ZValues.DataMember = "Z"
			Me.point3DSeries2_report.Color = Global.System.Drawing.Color.FromArgb(0, 0, 192)
			Me.point3DSeries2_report.ColorEach = False
			Me.point3DSeries2_report.LinePen.Color = Global.System.Drawing.Color.White
			Me.point3DSeries2_report.LinePen.EndCap = Global.System.Drawing.Drawing2D.LineCap.Round
			Me.point3DSeries2_report.LinePen.Style = Global.System.Drawing.Drawing2D.DashStyle.Dot
			Me.point3DSeries2_report.Marks.Callout.ArrowHead = Global.Steema.TeeChart.Styles.ArrowHeadStyles.None
			Me.point3DSeries2_report.Marks.Callout.ArrowHeadSize = 8
			Me.point3DSeries2_report.Marks.Callout.Brush.Color = Global.System.Drawing.Color.Black
			Me.point3DSeries2_report.Marks.Callout.Distance = 0
			Me.point3DSeries2_report.Marks.Callout.Draw3D = False
			Me.point3DSeries2_report.Marks.Callout.Length = 10
			Me.point3DSeries2_report.Marks.Callout.Series = Me.point3DSeries2_report
			Me.point3DSeries2_report.Marks.Callout.Style = Global.Steema.TeeChart.Styles.PointerStyles.Rectangle
			Me.point3DSeries2_report.Marks.Callout.Visible = False
			Me.point3DSeries2_report.Marks.Series = Me.point3DSeries2_report
			Me.point3DSeries2_report.Pointer.Brush.Gradient.StartColor = Global.System.Drawing.Color.FromArgb(243, 156, 53)
			Me.point3DSeries2_report.Pointer.Pen.Color = Global.System.Drawing.Color.FromArgb(146, 94, 32)
			Me.point3DSeries2_report.Pointer.Series = Me.point3DSeries2_report
			Me.point3DSeries2_report.Pointer.Style = Global.Steema.TeeChart.Styles.PointerStyles.Circle
			Me.point3DSeries2_report.Title = "Rod Guides"
			Me.point3DSeries2_report.XValues.DataMember = "X"
			Me.point3DSeries2_report.YValues.DataMember = "Y"
			Me.point3DSeries2_report.ZValues.DataMember = "Z"
			Me.timAnimate.Interval = 500
			Me.pnl3DReport.Controls.Add(Me.TChart1_Report)
			Dim pnl3DReport As Global.System.Windows.Forms.Control = Me.pnl3DReport
			location = New Global.System.Drawing.Point(-3333, 0)
			pnl3DReport.Location = location
			Me.pnl3DReport.Name = "pnl3DReport"
			Dim pnl3DReport2 As Global.System.Windows.Forms.Control = Me.pnl3DReport
			size = New Global.System.Drawing.Size(800, 800)
			pnl3DReport2.Size = size
			Me.pnl3DReport.TabIndex = 190
			Me.TChart1_Report.Aspect.Chart3DPercent = 100
			Me.TChart1_Report.Aspect.ZOffset = 0.0
			Me.TChart1_Report.Axes.Bottom.MaximumOffset = 5
			Me.TChart1_Report.Axes.Bottom.MinimumOffset = 5
			Me.TChart1_Report.Axes.Bottom.Title.Caption = "West - East"
			Me.TChart1_Report.Axes.Bottom.Title.Lines = New String() { "West - East" }
			Me.TChart1_Report.Axes.Depth.Title.Caption = "South - North"
			Me.TChart1_Report.Axes.Depth.Title.Lines = New String() { "South - North" }
			Me.TChart1_Report.Axes.Depth.Visible = True
			Me.TChart1_Report.Axes.Left.Inverted = True
			Me.TChart1_Report.Axes.Left.MaximumOffset = 5
			Me.TChart1_Report.Axes.Left.MinimumOffset = 5
			Me.TChart1_Report.Axes.Left.Title.Caption = "True Vertical Depth"
			Me.TChart1_Report.Axes.Left.Title.Font.Size = 9
			Me.TChart1_Report.Axes.Left.Title.Font.SizeFloat = 9F
			Me.TChart1_Report.Axes.Left.Title.Lines = New String() { "True Vertical Depth" }
			Me.TChart1_Report.BackColor = Global.System.Drawing.Color.Transparent
			Me.TChart1_Report.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.TChart1_Report.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.TChart1_Report.Header.Font.Brush.Color = Global.System.Drawing.Color.Black
			Me.TChart1_Report.Header.Font.Size = 9
			Me.TChart1_Report.Header.Font.SizeFloat = 9F
			Me.TChart1_Report.Header.Lines = New String() { "Deviation Survey Plot", "" }
			Me.TChart1_Report.Legend.Alignment = Global.Steema.TeeChart.LegendAlignments.Bottom
			Me.TChart1_Report.Legend.Font.Size = 7
			Me.TChart1_Report.Legend.Font.SizeFloat = 7F
			Dim tchart1_Report As Global.System.Windows.Forms.Control = Me.TChart1_Report
			location = New Global.System.Drawing.Point(0, 0)
			tchart1_Report.Location = location
			Dim tchart1_Report2 As Global.System.Windows.Forms.Control = Me.TChart1_Report
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(1)
			tchart1_Report2.Margin = padding
			Me.TChart1_Report.Name = "TChart1_Report"
			Dim tchart1_Report3 As Global.System.Windows.Forms.Control = Me.TChart1_Report
			padding = New Global.System.Windows.Forms.Padding(1)
			tchart1_Report3.Padding = padding
			Me.TChart1_Report.Page.AutoScale = True
			Me.TChart1_Report.Panel.Brush.Color = Global.System.Drawing.Color.FromArgb(0, 212, 208, 200)
			Me.TChart1_Report.Panel.Brush.Gradient.MiddleColor = Global.System.Drawing.Color.FromArgb(255, 255, 255)
			Me.TChart1_Report.Panel.Brush.Gradient.StartColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.TChart1_Report.Panel.MarginBottom = 1.0
			Me.TChart1_Report.Panel.MarginLeft = 1.0
			Me.TChart1_Report.Panel.MarginRight = 1.0
			Me.TChart1_Report.Panel.MarginTop = 1.0
			Me.TChart1_Report.Series.Add(Me.point3DSeries1_report)
			Me.TChart1_Report.Series.Add(Me.point3DSeries2_report)
			Dim tchart1_Report4 As Global.System.Windows.Forms.Control = Me.TChart1_Report
			size = New Global.System.Drawing.Size(800, 800)
			tchart1_Report4.Size = size
			Me.TChart1_Report.SubHeader.AdjustFrame = False
			Me.TChart1_Report.SubHeader.AutoSize = False
			Me.TChart1_Report.TabIndex = 11
			Me.TChart1_Report.Visible = False
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(1107, 518)
			Me.ClientSize = size
			Me.Controls.Add(Me.pnl3DReport)
			Me.Controls.Add(Me.pnlDeviation)
			Me.Controls.Add(Me.pnlTempChart)
			Me.Controls.Add(Me.pnlTabs)
			Me.Controls.Add(Me.picScrollBarTip)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.pnlTempChart2)
			Me.Controls.Add(Me.pnlDevCharts)
			Me.Controls.Add(Me.pnlActiveReport)
			Me.Controls.Add(Me.pnlDyno)
			Me.Controls.Add(Me.pnlTorquePlot)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.KeyPreview = True
			location = New Global.System.Drawing.Point(191, 256)
			Me.Location = location
			Me.MinimizeBox = False
			Me.Name = "Results"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Tag = "-1"
			Me.Text = "Output Results"
			CType(Me.picScrollBarTip, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlActiveReport.ResumeLayout(False)
			Me.pnlScrollBar.ResumeLayout(False)
			Me.pnlTabs.ResumeLayout(False)
			Me.pnlTabs.PerformLayout()
			CType(Me.TrackBar1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlDyno.ResumeLayout(False)
			Me.pnlDyno.PerformLayout()
			CType(Me.ChartFX_Dyno, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlTorquePlot.ResumeLayout(False)
			Me.pnlTorquePlot.PerformLayout()
			CType(Me.ChartFX_TorquePlot, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlTempChart.ResumeLayout(False)
			Me.pnlTempChart.PerformLayout()
			CType(Me.ChartFX_Temp_TorquePlot, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ChartFX_Temp_Dyno, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlTempChart2.ResumeLayout(False)
			Me.pnlTempChart2.PerformLayout()
			CType(Me.ChartFX_Temp_Torque_L, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ChartFX_Temp_Dyno_L, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ChartFX_Temp_Dyno_XL, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ChartFX_Temp_Torque_XL, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlDeviation.ResumeLayout(False)
			Me.pnlDeviation.PerformLayout()
			CType(Me.chtDoglegs, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chtSurveyPlan, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chtSurveyNS, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chtSurveyEW, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chtSideForces, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chtBucklingTendency, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chtAxialLoads, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlDevCharts.ResumeLayout(False)
			Me.pnlDevCharts.PerformLayout()
			Me.pnlGrpDevPlot.ResumeLayout(False)
			Me.pnlLegend.ResumeLayout(False)
			Me.pnlLegend.PerformLayout()
			Me.pnlLegend2.ResumeLayout(False)
			Me.pnlLegend2.PerformLayout()
			Me.pnlCommander.ResumeLayout(False)
			Me.pnlCommander.PerformLayout()
			Me.pnlDevPlot.ResumeLayout(False)
			CType(Me.ChartFX_LookingNorth, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ChartFX_SideLoading, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ChartFX_BucklingTendency, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ChartFX_AxialLoads, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ChartFX_DoglegSeverity, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ChartFX_LookingDown, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ChartFX_LookingEast, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.optReport, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.picOutput, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnl3DReport.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip

		Friend PdfExport1 As Global.DataDynamics.ActiveReports.Export.Pdf.PdfExport
	End Class
End Namespace
