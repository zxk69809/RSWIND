Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports ChartFX.WinForms
Imports ChartFX.WinForms.Adornments
Imports ChartFX.WinForms.Annotation
Imports DataDynamics.ActiveReports.DataSources
Imports DataDynamics.ActiveReports.Document
Imports DataDynamics.ActiveReports.Export.Pdf
Imports DataDynamics.ActiveReports.Toolbar
Imports DataDynamics.ActiveReports.Viewer
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices
Imports Steema.TeeChart
Imports Steema.TeeChart.Drawing
Imports Steema.TeeChart.Styles
Imports Steema.TeeChart.Tools
Imports ThetaStdInfo

Namespace RSWINV3
	Friend Partial Class Results
		Inherits Form

		Public Property iCurrentRptOpt As Integer
			Get
				Return Me.m_iCurrentRptOpt
			End Get
			Set(value As Integer)
				Me.m_iCurrentRptOpt = value
			End Set
		End Property

		Public Property bAfterPump1 As Boolean
			Get
				Return Me.m_bAfterPump1
			End Get
			Set(value As Boolean)
				Me.m_bAfterPump1 = value
			End Set
		End Property

		Public Property bAfterPump2 As Boolean
			Get
				Return Me.m_bAfterPump2
			End Get
			Set(value As Boolean)
				Me.m_bAfterPump2 = value
			End Set
		End Property

		Public Property bAfterPump1_report As Boolean
			Get
				Return Me.m_bAfterPump1_report
			End Get
			Set(value As Boolean)
				Me.m_bAfterPump1_report = value
			End Set
		End Property

		Public Property bAfterPump2_report As Boolean
			Get
				Return Me.m_bAfterPump2_report
			End Get
			Set(value As Boolean)
				Me.m_bAfterPump2_report = value
			End Set
		End Property

		Public Property iStep As Integer
			Get
				Return Me.m_iStep
			End Get
			Set(value As Integer)
				Me.m_iStep = value
			End Set
		End Property

		Private Overridable Property IPRPlot As IPRPlot
			Get
				Return Me._IPRPlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As IPRPlot)
				Me._IPRPlot = value
			End Set
		End Property

		Private Overridable Property dlgImplementGuideChanges As dlgImplementGuideChanges
			Get
				Return Me._dlgImplementGuideChanges
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dlgImplementGuideChanges)
				Me._dlgImplementGuideChanges = value
			End Set
		End Property

		Public Property Animate_Ntsteps As Short
			Get
				Return Me.m_Animate_Ntsteps
			End Get
			Set(value As Short)
				Me.m_Animate_Ntsteps = value
			End Set
		End Property

		Private Overridable Property commander1 As Commander
			Get
				Return Me._commander1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Commander)
				Dim value2 As ToolBarButtonClickEventHandler = AddressOf Me.commander1_ButtonClick
				If Me._commander1 IsNot Nothing Then
					RemoveHandler Me._commander1.ButtonClick, value2
				End If
				Me._commander1 = value
				If Me._commander1 IsNot Nothing Then
					AddHandler Me._commander1.ButtonClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property ChartFX_LookingEast As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_LookingEast
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_LookingEast = value
			End Set
		End Property

		Friend Overridable Property pnlLegend As System.Windows.Forms.Panel
			Get
				Return Me._pnlLegend
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlLegend = value
			End Set
		End Property

		Friend Overridable Property point3DSeries2 As Points3D
			Get
				Return Me._point3DSeries2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Points3D)
				Dim value2 As Points3D.GetPointerStyleEventHandler = AddressOf Me.point3DSeries2_GetPointerStyle
				If Me._point3DSeries2 IsNot Nothing Then
					RemoveHandler Me._point3DSeries2.GetPointerStyle, value2
				End If
				Me._point3DSeries2 = value
				If Me._point3DSeries2 IsNot Nothing Then
					AddHandler Me._point3DSeries2.GetPointerStyle, value2
				End If
			End Set
		End Property

		Friend Overridable Property point3DSeries2_report As Points3D
			Get
				Return Me._point3DSeries2_report
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Points3D)
				Dim value2 As Points3D.GetPointerStyleEventHandler = AddressOf Me.point3DSeries2_report_GetPointerStyle
				If Me._point3DSeries2_report IsNot Nothing Then
					RemoveHandler Me._point3DSeries2_report.GetPointerStyle, value2
				End If
				Me._point3DSeries2_report = value
				If Me._point3DSeries2_report IsNot Nothing Then
					AddHandler Me._point3DSeries2_report.GetPointerStyle, value2
				End If
			End Set
		End Property

		Friend Overridable Property optPrevDevChart As System.Windows.Forms.Button
			Get
				Return Me._optPrevDevChart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.optPrevDevChart_Click
				If Me._optPrevDevChart IsNot Nothing Then
					RemoveHandler Me._optPrevDevChart.Click, value2
				End If
				Me._optPrevDevChart = value
				If Me._optPrevDevChart IsNot Nothing Then
					AddHandler Me._optPrevDevChart.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property optNextDevChart As System.Windows.Forms.Button
			Get
				Return Me._optNextDevChart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.optNextDevChart_Click
				If Me._optNextDevChart IsNot Nothing Then
					RemoveHandler Me._optNextDevChart.Click, value2
				End If
				Me._optNextDevChart = value
				If Me._optNextDevChart IsNot Nothing Then
					AddHandler Me._optNextDevChart.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblPoint As Label
			Get
				Return Me._lblPoint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPoint = value
			End Set
		End Property

		Friend Overridable Property pnl3DReport As System.Windows.Forms.Panel
			Get
				Return Me._pnl3DReport
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnl3DReport = value
			End Set
		End Property

		Friend Overridable Property TChart1_Report As TChart
			Get
				Return Me._TChart1_Report
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TChart)
				Me._TChart1_Report = value
			End Set
		End Property

		Friend Overridable Property VScrollBar1 As VScrollBar
			Get
				Return Me._VScrollBar1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As VScrollBar)
				Me._VScrollBar1 = value
			End Set
		End Property

		Public Overridable Property btnImplement As RadioButton
			Get
				Return Me._btnImplement
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.btnImplement_VisibleChanged
				Dim value3 As EventHandler = AddressOf Me.btnImplement_CheckedChanged
				If Me._btnImplement IsNot Nothing Then
					RemoveHandler Me._btnImplement.VisibleChanged, value2
					RemoveHandler Me._btnImplement.CheckedChanged, value3
				End If
				Me._btnImplement = value
				If Me._btnImplement IsNot Nothing Then
					AddHandler Me._btnImplement.VisibleChanged, value2
					AddHandler Me._btnImplement.CheckedChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property pnlLegend2 As System.Windows.Forms.Panel
			Get
				Return Me._pnlLegend2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlLegend2 = value
			End Set
		End Property

		Friend Overridable Property lblNumGuidesPerRod2 As Label
			Get
				Return Me._lblNumGuidesPerRod2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuidesPerRod2 = value
			End Set
		End Property

		Friend Overridable Property lblDiameters2 As Label
			Get
				Return Me._lblDiameters2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDiameters2 = value
			End Set
		End Property

		Friend Overridable Property G20 As Label
			Get
				Return Me._G20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G20 = value
			End Set
		End Property

		Friend Overridable Property G19 As Label
			Get
				Return Me._G19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G19 = value
			End Set
		End Property

		Friend Overridable Property G18 As Label
			Get
				Return Me._G18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G18 = value
			End Set
		End Property

		Friend Overridable Property G17 As Label
			Get
				Return Me._G17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G17 = value
			End Set
		End Property

		Friend Overridable Property G16 As Label
			Get
				Return Me._G16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G16 = value
			End Set
		End Property

		Friend Overridable Property G15 As Label
			Get
				Return Me._G15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G15 = value
			End Set
		End Property

		Friend Overridable Property G14 As Label
			Get
				Return Me._G14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G14 = value
			End Set
		End Property

		Friend Overridable Property G13 As Label
			Get
				Return Me._G13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G13 = value
			End Set
		End Property

		Friend Overridable Property G12 As Label
			Get
				Return Me._G12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G12 = value
			End Set
		End Property

		Friend Overridable Property G11 As Label
			Get
				Return Me._G11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G11 = value
			End Set
		End Property

		Friend Overridable Property lblNumGuidesPerRod As Label
			Get
				Return Me._lblNumGuidesPerRod
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuidesPerRod = value
			End Set
		End Property

		Friend Overridable Property G10 As Label
			Get
				Return Me._G10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G10 = value
			End Set
		End Property

		Friend Overridable Property G9 As Label
			Get
				Return Me._G9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G9 = value
			End Set
		End Property

		Friend Overridable Property G8 As Label
			Get
				Return Me._G8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G8 = value
			End Set
		End Property

		Friend Overridable Property G7 As Label
			Get
				Return Me._G7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G7 = value
			End Set
		End Property

		Friend Overridable Property G6 As Label
			Get
				Return Me._G6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G6 = value
			End Set
		End Property

		Friend Overridable Property G5 As Label
			Get
				Return Me._G5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G5 = value
			End Set
		End Property

		Friend Overridable Property G4 As Label
			Get
				Return Me._G4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G4 = value
			End Set
		End Property

		Friend Overridable Property G3 As Label
			Get
				Return Me._G3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G3 = value
			End Set
		End Property

		Friend Overridable Property G2 As Label
			Get
				Return Me._G2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G2 = value
			End Set
		End Property

		Friend Overridable Property G1 As Label
			Get
				Return Me._G1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G1 = value
			End Set
		End Property

		Friend Overridable Property lblDiameters As Label
			Get
				Return Me._lblDiameters
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDiameters = value
			End Set
		End Property

		Friend Overridable Property T20 As Label
			Get
				Return Me._T20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T20 = value
			End Set
		End Property

		Friend Overridable Property T19 As Label
			Get
				Return Me._T19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T19 = value
			End Set
		End Property

		Friend Overridable Property T18 As Label
			Get
				Return Me._T18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T18 = value
			End Set
		End Property

		Friend Overridable Property T17 As Label
			Get
				Return Me._T17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T17 = value
			End Set
		End Property

		Friend Overridable Property T16 As Label
			Get
				Return Me._T16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T16 = value
			End Set
		End Property

		Friend Overridable Property T15 As Label
			Get
				Return Me._T15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T15 = value
			End Set
		End Property

		Friend Overridable Property T14 As Label
			Get
				Return Me._T14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T14 = value
			End Set
		End Property

		Friend Overridable Property T13 As Label
			Get
				Return Me._T13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T13 = value
			End Set
		End Property

		Friend Overridable Property T12 As Label
			Get
				Return Me._T12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T12 = value
			End Set
		End Property

		Friend Overridable Property T11 As Label
			Get
				Return Me._T11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T11 = value
			End Set
		End Property

		Friend Overridable Property T10 As Label
			Get
				Return Me._T10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T10 = value
			End Set
		End Property

		Friend Overridable Property T9 As Label
			Get
				Return Me._T9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T9 = value
			End Set
		End Property

		Friend Overridable Property T8 As Label
			Get
				Return Me._T8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T8 = value
			End Set
		End Property

		Friend Overridable Property T7 As Label
			Get
				Return Me._T7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T7 = value
			End Set
		End Property

		Friend Overridable Property T6 As Label
			Get
				Return Me._T6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T6 = value
			End Set
		End Property

		Friend Overridable Property T5 As Label
			Get
				Return Me._T5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T5 = value
			End Set
		End Property

		Friend Overridable Property T4 As Label
			Get
				Return Me._T4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T4 = value
			End Set
		End Property

		Friend Overridable Property T3 As Label
			Get
				Return Me._T3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T3 = value
			End Set
		End Property

		Friend Overridable Property T2 As Label
			Get
				Return Me._T2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T2 = value
			End Set
		End Property

		Friend Overridable Property T1 As Label
			Get
				Return Me._T1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T1 = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Resize, AddressOf Me.Results_Resize
			AddHandler MyBase.Closing, AddressOf Me.Results_Closing
			AddHandler MyBase.Closed, AddressOf Me.Results_Closed
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.Me_MouseDoubleClick
			AddHandler MyBase.MouseDown, AddressOf Me.Me_MouseDown
			AddHandler MyBase.MouseEnter, AddressOf Me.Me_MouseEnter
			AddHandler MyBase.MouseMove, AddressOf Me.Me_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.Me_MouseUp
			AddHandler MyBase.MouseWheel, AddressOf Me.Me_MouseWheel
			AddHandler MyBase.Move, AddressOf Me.Me_Move
			AddHandler MyBase.Scroll, AddressOf Me.Me_Scroll
			AddHandler MyBase.KeyPress, AddressOf Me.Me_KeyPress
			AddHandler MyBase.KeyUp, AddressOf Me.Me_KeyUp
			AddHandler MyBase.DragDrop, AddressOf Me.Me_DragDrop
			AddHandler MyBase.DragEnter, AddressOf Me.Me_DragEnter
			AddHandler MyBase.FormClosed, AddressOf Me.Me_FormClosed
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.LostFocus, AddressOf Me.Me_LostFocus
			AddHandler MyBase.GotFocus, AddressOf Me.Me_GotFocus
			AddHandler MyBase.SizeChanged, AddressOf Me.Results_SizeChanged
			AddHandler MyBase.Paint, AddressOf Me.Results_Paint
			AddHandler MyBase.Activated, AddressOf Me.Results_Activated
			AddHandler MyBase.Load, AddressOf Me.Results_Load
			AddHandler MyBase.KeyDown, AddressOf Me.Results_KeyDown
			Me.RandomClass = New Random()
			Me.bUseSeries2 = True
			Me.bViewing3DPlot = False
			Me.m_iCurrentRptOpt = 2
			Me.bCommanderClicked = False
			Me.m_bAfterPump1 = False
			Me.m_bAfterPump2 = False
			Me.m_bAfterPump1_report = False
			Me.m_bAfterPump2_report = False
			Me.m_bReplot = False
			Me.m_iStep = 0
			Me.SetLinesX = New Single(4, 2) {}
			Me.SetLinesY = New Single(4, 2) {}
			Me.mnuDPlot = New Object(6) {}
			Me.IPRPlot = New IPRPlot()
			Me.dlgImplementGuideChanges = New dlgImplementGuideChanges()
			Me.bDogLegsCalculated = False
			Me.bForward = True
			Me.bPlay = False
			Me.bTogglePlay = False
			Me.bFormLoaded = False
			Me.nStep = 1
			Me.nSkip = 1
			Me.nInitialSkip = 1
			Me.IntervalConst = 180000
			Me.myKeyValueHT = New Hashtable()
			Me.bImplementOn = False
			Me.sOutputSetup = Util.AssignValueToConstant("Results", "sOutputSetup", "Please check the output setup. No pages have been selected")
			Me.sFileSaveError = Util.AssignValueToConstant("Results", "sFileSaveError", "File Save Error")
			Me.sMeasuredCard = Util.AssignValueToConstant("Results", "sMeasuredCard", "Measured Card")
			Me.sPermissibleLoadDiagram = Util.AssignValueToConstant("Results", "sPermissibleLoadDiagram", "Permissible load diagram")
			Me.sDownholeCard = Util.AssignValueToConstant("Results", "sDownholeCard", "Downhole card")
			Me.sSurfaceCard = Util.AssignValueToConstant("Results", "sSurfaceCard", "Surface card")
			Me.sDynamometerCards = Util.AssignValueToConstant("Results", "chartfx_sDynamometerCards", "Dynamometer cards")
			Me.sGearboxTorquePlots = Util.AssignValueToConstant("Results", "chartfx_sGearboxTorquePlots", "Gearbox Torque Plots")
			Me.sExisting = Util.AssignValueToConstant("Results", "sExisting", "Existing")
			Me.sOverlapsMinEnergy = Util.AssignValueToConstant("Results", "sOverlapsMinEnergy", "overlaps min. energy")
			Me.sUpstroke = Util.AssignValueToConstant("Results", "sUpstroke", "Upstroke")
			Me.sDownstroke = Util.AssignValueToConstant("Results", "sDownstroke", "Downstroke")
			Me.sBalanced = Util.AssignValueToConstant("Results", "sBalanced", "Balanced")
			Me.sBalMinEnergy = Util.AssignValueToConstant("Results", "sbalminenergy", "balanced (min ener)")
			Me.sBalMinTorque = Util.AssignValueToConstant("Results", "sbalmintorque", "balanced (min torq)")
			Me.sCrankHoleDegrees = Util.AssignValueToConstant("Results", "sCrankHoleDegrees", "Crank Hole Degrees")
			Me.sPosition = Util.AssignValueToConstant("Results", "sPosition", "Position")
			Me.sLoad = Util.AssignValueToConstant("Results", "sLoad", "Load")
			Me.sGearboxRating = Util.AssignValueToConstant("Results", "sGearboxRating", "Gearbox rating")
			Me.iAnimationCycle = 0
			Me.plotted_rod_num_guides = New Integer(0) {}
			Me.iGetPointStyle2 = 0
			Me.iGetPointStyle2_report = 0
			Me.iGetPointStyle1 = 0
			Me.iGetPointStyle1_report = 0
			Me.bPlotSurveyPointLevel = False
			Me.bReDisplayPanel = New Boolean(2) {}
			Me.TaperDepths = New Single(0) {}
			If Results.m_vb6FormDefInstance Is Nothing Then
				If Results.m_InitializingDefInstance Then
					Results.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							Results.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
			Me.Text = ""
		End Sub

		Public Overridable Property picScrollBarTip As PictureBox
			Get
				Return Me._picScrollBarTip
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._picScrollBarTip = value
			End Set
		End Property

		Public Overridable Property cmdCancel As System.Windows.Forms.Button
			Get
				Return Me._cmdCancel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.cmdCancel_Click
				If Me._cmdCancel IsNot Nothing Then
					RemoveHandler Me._cmdCancel.Click, value2
				End If
				Me._cmdCancel = value
				If Me._cmdCancel IsNot Nothing Then
					AddHandler Me._cmdCancel.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property timAnimate As System.Windows.Forms.Timer
			Get
				Return Me._timAnimate
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.timAnimate_Tick
				If Me._timAnimate IsNot Nothing Then
					RemoveHandler Me._timAnimate.Tick, value2
				End If
				Me._timAnimate = value
				If Me._timAnimate IsNot Nothing Then
					AddHandler Me._timAnimate.Tick, value2
				End If
			End Set
		End Property

		Public Overridable Property Label As LabelArray
			Get
				Return Me._Label
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._Label = value
			End Set
		End Property

		Public Overridable Property optReport As RadioButtonArray
			Get
				Return Me._optReport
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButtonArray)
				Dim obj As EventHandler = AddressOf Me.optReport_CheckedChanged
				If Me._optReport IsNot Nothing Then
					RemoveHandler Me._optReport.CheckedChanged, obj
				End If
				Me._optReport = value
				If Me._optReport IsNot Nothing Then
					AddHandler Me._optReport.CheckedChanged, obj
				End If
			End Set
		End Property

		Public Overridable Property picOutput As PanelArray
			Get
				Return Me._picOutput
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PanelArray)
				Dim obj As PaintEventHandler = AddressOf Me.picOutput_Paint
				If Me._picOutput IsNot Nothing Then
					RemoveHandler Me._picOutput.Paint, obj
				End If
				Me._picOutput = value
				If Me._picOutput IsNot Nothing Then
					AddHandler Me._picOutput.Paint, obj
				End If
			End Set
		End Property

		Friend Overridable Property cmdIPRPlot As System.Windows.Forms.Button
			Get
				Return Me._cmdIPRPlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.cmdIPRPlot_Click
				If Me._cmdIPRPlot IsNot Nothing Then
					RemoveHandler Me._cmdIPRPlot.Click, value2
				End If
				Me._cmdIPRPlot = value
				If Me._cmdIPRPlot IsNot Nothing Then
					AddHandler Me._cmdIPRPlot.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlTempChart As System.Windows.Forms.Panel
			Get
				Return Me._pnlTempChart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlTempChart = value
			End Set
		End Property

		Friend Overridable Property ChartFX_Temp_Dyno As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_Temp_Dyno
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_Temp_Dyno = value
			End Set
		End Property

		Friend Overridable Property ChartFX_Temp_TorquePlot As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_Temp_TorquePlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_Temp_TorquePlot = value
			End Set
		End Property

		Friend Overridable Property ChartFX_Dyno As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_Dyno
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_Dyno = value
			End Set
		End Property

		Friend Overridable Property ctxMenu_DynoPlot As ContextMenu
			Get
				Return Me._ctxMenu_DynoPlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._ctxMenu_DynoPlot = value
			End Set
		End Property

		Public Overridable Property lblAnimateDyno As Label
			Get
				Return Me._lblAnimateDyno
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblAnimateDyno = value
			End Set
		End Property

		Friend Overridable Property pnlTempChart2 As System.Windows.Forms.Panel
			Get
				Return Me._pnlTempChart2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlTempChart2 = value
			End Set
		End Property

		Friend Overridable Property ChartFX_Temp_Torque_L As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_Temp_Torque_L
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_Temp_Torque_L = value
			End Set
		End Property

		Friend Overridable Property ChartFX_Temp_Dyno_L As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_Temp_Dyno_L
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_Temp_Dyno_L = value
			End Set
		End Property

		Friend Overridable Property ChartFX_Temp_Dyno_XL As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_Temp_Dyno_XL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_Temp_Dyno_XL = value
			End Set
		End Property

		Friend Overridable Property ChartFX_Temp_Torque_XL As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_Temp_Torque_XL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_Temp_Torque_XL = value
			End Set
		End Property

		Friend Overridable Property TrackBar1 As TrackBar
			Get
				Return Me._TrackBar1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TrackBar)
				Dim value2 As EventHandler = AddressOf Me.TrackBar1_Scroll
				If Me._TrackBar1 IsNot Nothing Then
					RemoveHandler Me._TrackBar1.Scroll, value2
				End If
				Me._TrackBar1 = value
				If Me._TrackBar1 IsNot Nothing Then
					AddHandler Me._TrackBar1.Scroll, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlDeviation As System.Windows.Forms.Panel
			Get
				Return Me._pnlDeviation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlDeviation = value
			End Set
		End Property

		Friend Overridable Property chtAxialLoads As ChartFX.WinForms.Chart
			Get
				Return Me._chtAxialLoads
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._chtAxialLoads = value
			End Set
		End Property

		Friend Overridable Property chtBucklingTendency As ChartFX.WinForms.Chart
			Get
				Return Me._chtBucklingTendency
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._chtBucklingTendency = value
			End Set
		End Property

		Friend Overridable Property chtSideForces As ChartFX.WinForms.Chart
			Get
				Return Me._chtSideForces
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._chtSideForces = value
			End Set
		End Property

		Friend Overridable Property chtSurveyPlan As ChartFX.WinForms.Chart
			Get
				Return Me._chtSurveyPlan
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._chtSurveyPlan = value
			End Set
		End Property

		Friend Overridable Property chtSurveyNS As ChartFX.WinForms.Chart
			Get
				Return Me._chtSurveyNS
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._chtSurveyNS = value
			End Set
		End Property

		Friend Overridable Property chtSurveyEW As ChartFX.WinForms.Chart
			Get
				Return Me._chtSurveyEW
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._chtSurveyEW = value
			End Set
		End Property

		Friend Overridable Property chtDoglegs As ChartFX.WinForms.Chart
			Get
				Return Me._chtDoglegs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._chtDoglegs = value
			End Set
		End Property

		Friend Overridable Property btnDevCharts As System.Windows.Forms.Button
			Get
				Return Me._btnDevCharts
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.btnDevCharts_Click
				If Me._btnDevCharts IsNot Nothing Then
					RemoveHandler Me._btnDevCharts.Click, value2
				End If
				Me._btnDevCharts = value
				If Me._btnDevCharts IsNot Nothing Then
					AddHandler Me._btnDevCharts.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlDevCharts As System.Windows.Forms.Panel
			Get
				Return Me._pnlDevCharts
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlDevCharts = value
			End Set
		End Property

		Friend Overridable Property ChartFX_DoglegSeverity As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_DoglegSeverity
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_DoglegSeverity = value
			End Set
		End Property

		Friend Overridable Property ChartFX_LookingDown As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_LookingDown
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_LookingDown = value
			End Set
		End Property

		Friend Overridable Property ChartFX_LookingNorth As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_LookingNorth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_LookingNorth = value
			End Set
		End Property

		Friend Overridable Property ChartFX_SideLoading As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_SideLoading
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_SideLoading = value
			End Set
		End Property

		Friend Overridable Property ChartFX_BucklingTendency As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_BucklingTendency
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_BucklingTendency = value
			End Set
		End Property

		Friend Overridable Property ChartFX_AxialLoads As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_AxialLoads
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_AxialLoads = value
			End Set
		End Property

		Friend Overridable Property btnPrevDevChart As System.Windows.Forms.Button
			Get
				Return Me._btnPrevDevChart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.btnPrevDevChart_Click
				If Me._btnPrevDevChart IsNot Nothing Then
					RemoveHandler Me._btnPrevDevChart.Click, value2
				End If
				Me._btnPrevDevChart = value
				If Me._btnPrevDevChart IsNot Nothing Then
					AddHandler Me._btnPrevDevChart.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnNextDevChart As System.Windows.Forms.Button
			Get
				Return Me._btnNextDevChart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.btnNextDevChart_Click
				If Me._btnNextDevChart IsNot Nothing Then
					RemoveHandler Me._btnNextDevChart.Click, value2
				End If
				Me._btnNextDevChart = value
				If Me._btnNextDevChart IsNot Nothing Then
					AddHandler Me._btnNextDevChart.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property tbbRunPause As System.Windows.Forms.Button
			Get
				Return Me._tbbRunPause
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.tbbRunPause_Click
				If Me._tbbRunPause IsNot Nothing Then
					RemoveHandler Me._tbbRunPause.Click, value2
				End If
				Me._tbbRunPause = value
				If Me._tbbRunPause IsNot Nothing Then
					AddHandler Me._tbbRunPause.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MarksTip1 As MarksTip
			Get
				Return Me._MarksTip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MarksTip)
				Me._MarksTip1 = value
			End Set
		End Property

		Friend Overridable Property pnlCommander As System.Windows.Forms.Panel
			Get
				Return Me._pnlCommander
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlCommander = value
			End Set
		End Property

		Friend Overridable Property btnResetPlot As System.Windows.Forms.Button
			Get
				Return Me._btnResetPlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.btnResetPlot_Click
				If Me._btnResetPlot IsNot Nothing Then
					RemoveHandler Me._btnResetPlot.Click, value2
				End If
				Me._btnResetPlot = value
				If Me._btnResetPlot IsNot Nothing Then
					AddHandler Me._btnResetPlot.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlDevPlot As System.Windows.Forms.Panel
			Get
				Return Me._pnlDevPlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlDevPlot = value
			End Set
		End Property

		Friend Overridable Property lblNoData As Label
			Get
				Return Me._lblNoData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNoData = value
			End Set
		End Property

		Friend Overridable Property TChart1 As TChart
			Get
				Return Me._TChart1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TChart)
				Dim value2 As EventHandler = AddressOf Me.TChart1_Move
				Dim value3 As MouseEventHandler = AddressOf Me.TChart1_MouseDown
				Dim value4 As EventHandler = AddressOf Me.TChart1_SizeChanged
				If Me._TChart1 IsNot Nothing Then
					RemoveHandler Me._TChart1.Move, value2
					RemoveHandler Me._TChart1.MouseDown, value3
					RemoveHandler Me._TChart1.SizeChanged, value4
				End If
				Me._TChart1 = value
				If Me._TChart1 IsNot Nothing Then
					AddHandler Me._TChart1.Move, value2
					AddHandler Me._TChart1.MouseDown, value3
					AddHandler Me._TChart1.SizeChanged, value4
				End If
			End Set
		End Property

		Friend Overridable Property point3DSeries1 As Points3D
			Get
				Return Me._point3DSeries1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Points3D)
				Dim value2 As Points3D.GetPointerStyleEventHandler = AddressOf Me.point3DSeries1_GetPointerStyle
				If Me._point3DSeries1 IsNot Nothing Then
					RemoveHandler Me._point3DSeries1.GetPointerStyle, value2
				End If
				Me._point3DSeries1 = value
				If Me._point3DSeries1 IsNot Nothing Then
					AddHandler Me._point3DSeries1.GetPointerStyle, value2
				End If
			End Set
		End Property

		Friend Overridable Property point3DSeries1_report As Points3D
			Get
				Return Me._point3DSeries1_report
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Points3D)
				Dim value2 As Points3D.GetPointerStyleEventHandler = AddressOf Me.point3DSeries1_report_GetPointerStyle
				If Me._point3DSeries1_report IsNot Nothing Then
					RemoveHandler Me._point3DSeries1_report.GetPointerStyle, value2
				End If
				Me._point3DSeries1_report = value
				If Me._point3DSeries1_report IsNot Nothing Then
					AddHandler Me._point3DSeries1_report.GetPointerStyle, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlGrpDevPlot As System.Windows.Forms.Panel
			Get
				Return Me._pnlGrpDevPlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlGrpDevPlot = value
			End Set
		End Property

		Friend Overridable Property btnCoverPageComments As System.Windows.Forms.Button
			Get
				Return Me._btnCoverPageComments
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.btnCoverPageComments_Click
				If Me._btnCoverPageComments IsNot Nothing Then
					RemoveHandler Me._btnCoverPageComments.Click, value2
				End If
				Me._btnCoverPageComments = value
				If Me._btnCoverPageComments IsNot Nothing Then
					AddHandler Me._btnCoverPageComments.Click, value2
				End If
			End Set
		End Property

		Public Shared Property DefInstance As Results
			Get
				If Results.m_vb6FormDefInstance Is Nothing OrElse Results.m_vb6FormDefInstance.IsDisposed Then
					Results.m_InitializingDefInstance = True
					Results.m_vb6FormDefInstance = New Results()
					Results.m_InitializingDefInstance = False
				End If
				Return Results.m_vb6FormDefInstance
			End Get
			Set(value As Results)
				Results.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property iAnimCurPoint As Integer
			Get
				Return CInt(Me.m_iAnimCurPoint)
			End Get
			Set(value As Integer)
				' The following expression was wrapped in a checked-expression
				Me.m_iAnimCurPoint = CShort(value)
			End Set
		End Property

		Private Sub SetupReportPages()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Me.aiReportPages = New Short(9) {}
			Dim num As Short = 0S
			Me.aiReportPages(CInt(num)) = 0S
			num += 1S
			Me.aiReportPages(CInt(num)) = 1S
			If rst.gbUseIPR Then
				num += 1S
				Me.aiReportPages(CInt(num)) = 2S
			End If
			num += 1S
			Me.aiReportPages(CInt(num)) = 3S
			num += 1S
			Me.aiReportPages(CInt(num)) = 4S
			num += 1S
			Me.aiReportPages(CInt(num)) = 5S
			num += 1S
			Me.aiReportPages(CInt(num)) = 6S
			num += 1S
			Me.aiReportPages(CInt(num)) = 7S
			If rst.gbReportCostAnalysis <> 0S Then
				num += 1S
				Me.aiReportPages(CInt(num)) = 8S
			End If
			If rst.gbUseIPR Then
				num += 1S
				Me.aiReportPages(CInt(num)) = 9S
			End If
			Me.aiReportPages = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(Me.aiReportPages, Array), New Short(CInt((num + 1S)) - 1) {}), Short())
		End Sub

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			Me.tbbStop_Click(Me.tbbStop, New EventArgs())
		End Sub

		Private Sub cmdClose_Click(eventSender As Object, eventArgs As EventArgs)
			Results.DefInstance.Close()
		End Sub

		Private Sub cmdExport_Click()
			Util.ExportMCM()
		End Sub

		Private Sub Results_Activated(sender As Object, e As EventArgs)
			RSWIN.GetMeasurementUnit()
			Me.CenterForm()
			If RSWIN_DESC.bBackFromSetLines Then
				Me._optReport_0.PerformClick()
				RSWIN_DESC.bBackFromSetLines = False
			End If
			Application.DoEvents()
			If RSWIN_DESC.bRodStarD Then
				If Me.btnImplement.Checked Then
					Me.btnImplement.Checked = False
				End If
				If RSWIN_DESC.bRodStarD Then
					If Not RSWIN_DESC.rst.bImplementedDesign And Operators.CompareString(Me.Text, "Output results - Rod guide recommendations have been implemented", False) = 0 Then
						Me.Text = "Output Results"
					ElseIf RSWIN_DESC.rst.bImplementedDesign And Operators.CompareString(Me.Text, "Output results - Rod guide recommendations have been implemented", False) <> 0 Then
						Me.Text = "Output results - Rod guide recommendations have been implemented"
					End If
				ElseIf Operators.CompareString(Me.Text, "Output results - Rod guide recommendations have been implemented", False) = 0 Then
					Me.Text = "Output Results"
				End If
			End If
			RSWIN_DESC.sCurrentFormName = "Results"
		End Sub

		Private Sub Results_Load(sender As Object, e As EventArgs)
			SUPERPRO.NewCheckSentinel(True)
			Application.DoEvents()
			Me.AutoScroll = False
			Me.Tag = ""
			Me.CenterForm()
			Me.Width = Me.ParentForm.Width - 30
			Me.Height = Me.ParentForm.Height - 125
			Me.Top = 0
			Me.Left = 0
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				Dim num As Integer = 1
				Do
					RSWIN_DESC.NewData(num) = 0S
					num += 1
				Loop While num <= 7
			End If
			If RSWIN_DESC.rst.PU.UnitType = 10S Then
				Me._optReport_1.Enabled = False
			Else
				Me._optReport_1.Enabled = True
			End If
			RSWIN.GetMeasurementUnit()
			Me.ResetClock()
			RSWIN_DESC.sCurrentFormName = "Results"
			Me.lblPoint.Text = ""
			Me.lblPoint.Visible = False
			If RSWIN_DESC.bRodStarD Then
				Me.Icon = RSWIN_DESC.RodstarD_Icon
			ElseIf Not RSWIN_DESC.bExpert Then
				Me.Icon = RSWIN_DESC.RodstarV_Icon
			Else
				Me.Icon = Me.ParentForm.Icon
			End If
			Me.SetAnimateButtonsVisible(False)
			If RSWIN_DESC.bIntVersion Then
				If RSWIN_DESC.bChangeCultures Then
					Dim setup_Language As String = RSWIN_DESC.SETUP_Language
					If Operators.CompareString(setup_Language, RSWIN_DESC.sEnglish, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sSpanish, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
					ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sChinese, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
					Else
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					End If
					Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
				End If
				If RSWIN_DESC.bReadResXFile Then
					Util.AssignValuesToControls(Me)
				End If
			End If
			If RSWIN_DESC.bRodStarD And RSWIN_DESC.rst.bImplementedDesign Then
				Me.Text = "Output results - Rod guide recommendations have been implemented"
			Else
				Me.Text = "Output Results"
			End If
			Me.tbbRun.BringToFront()
			RSWIN_DESC.sDevPlotFileName = ""
			Me.ResultsLoad(True)
			Application.DoEvents()
			Application.DoEvents()
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.WriteContextMenuToRexResource(Me.ContextMenu1)
				Util.WriteContextMenuToRexResource(Me.ctxMenu_DynoPlot)
				Util.WriteChartStrings(Me.ChartFX_Dyno)
				Util.WriteChartStrings(Me.ChartFX_TorquePlot)
				Util.WriteChartStrings(Me.chtAxialLoads)
				Util.WriteChartStrings(Me.chtBucklingTendency)
				Util.WriteChartStrings(Me.chtDoglegs)
				Util.WriteChartStrings(Me.chtSideForces)
				Util.WriteChartStrings(Me.chtSurveyEW)
				Util.WriteChartStrings(Me.chtSurveyNS)
				Util.WriteChartStrings(Me.chtSurveyPlan)
				Util.CloseResourceWriter()
			End If
			Me.ResetClock()
			Me.CenterForm()
			Me.BringToFront()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
		End Sub

		Private Sub Results_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
			If Me.timAnimate.Enabled And num = 27S And num2 = 0S Then
				Me.tbbStop_Click(Me.tbbStop, New EventArgs())
			End If
		End Sub

		Public Sub ResultsLoad(Optional bShowForm As Boolean = True)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = True
			Dim flag3 As Boolean = False
			Dim sTapersOverMax As String = ""
			Dim rptAll As rptAll = New rptAll()
			Dim index As Integer = 16
			Dim iGBScore As Integer = 0
			Dim iRLScore As Integer = 0
			Dim iSLScore As Integer = 0
			Dim iSEffScore As Integer = 0
			Dim iBotMinStressScore As Integer = 0
			Dim iMPRLScore As Integer = 0
			Dim num As Single = 0F
			Dim bForceDisplay As Boolean = False
			Dim flag4 As Boolean = False
			Try
				Try
					Try
						rptAll = New rptAll()
						rptAll.Restart()
						Me.Viewer1.Document = Nothing
						Me.Viewer1.ReportViewer.Refresh()
					Catch ex As Exception
					End Try
					RSWIN_DESC.taper_lens(1) = RSWIN_DESC.rst.Sections(1).length
					Dim num2 As Short = 2S
					Dim numRods As Short = RSWIN_DESC.rst.NumRods
					For num3 As Short = num2 To numRods
						' The following expression was wrapped in a checked-expression
						RSWIN_DESC.taper_lens(CInt(num3)) = RSWIN_DESC.taper_lens(CInt((num3 - 1S))) + RSWIN_DESC.rst.Sections(CInt(num3)).length
					Next
					If RSWIN_DESC.bRodStarD Then
						RSWIN_DESC.bAllZeroNumGuides = RSWIN.AllZeroNumGuides()
						If RSWIN_DESC.bCheckRodGuideFrequency Then
							Me.InitializeGuideFrequencyArrays()
						End If
					End If
				Catch ex2 As Exception
				End Try
				RSWIN_DESC.bHasGuides = False
				Dim text As String = "ScoringPage"
				Dim flag5 As Boolean = True
				RSWIN_DESC.SETUP_ScoringPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag5) > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.rst.gbScoringPage = (RSWIN_DESC.SETUP_ScoringPage <> 0S)
				text = "CoverPage"
				flag5 = False
				RSWIN_DESC.SETUP_CoverPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag5) > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.rst.gbCoverPage = (RSWIN_DESC.SETUP_CoverPage <> 0S)
				text = "OrderPage"
				flag5 = False
				RSWIN_DESC.SETUP_OrderPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag5) > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.rst.gbOrderPage = (RSWIN_DESC.SETUP_OrderPage <> 0S)
				Me.EnableToolbarButton(index, False)
				If RSWIN_DESC.rst.gbCoverPage Then
					Me.ToolTip1.SetToolTip(Me.btnCoverPageComments, "Edit Cover Page Comments")
					Me.btnCoverPageComments.Left = Me._optReport_2.Left + Me._optReport_2.Width + 1
					Me.btnCoverPageComments.Visible = True
					Me.btnCoverPageComments.Enabled = False
				Else
					Me.btnCoverPageComments.Visible = False
					Me.btnCoverPageComments.Enabled = False
				End If
				Me.btnImplement.Visible = False
				Me.CheckPageSettings()
				If Not Me.CalcTaperDepths() Then
					Try
						Dim sMsg As String = "Output cannot be displayed."
						Dim sMsgType As String = ""
						Dim bClosing As Boolean = False
						Dim dialogResult As DialogResult = DialogResult.OK
						Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
						Me.MakeSureAnimationIsntRunning()
						Me.Tag = "Close"
						Me.Hide()
						Me.Dispose()
						Return
					Catch ex3 As Exception
						Return
					End Try
				End If
				Me.btnDevCharts.Visible = False
				If RSWIN_DESC.rst.PU.UnitType = 8S And RSWIN_DESC.rst.UnknownM <> RSWIN_DESC.rst.bUnknownUnbalance Then
					RSWIN_DESC.rst.UnknownM = RSWIN_DESC.rst.bUnknownUnbalance
				End If
				If Not RSWIN_DESC.rst.gbBatch Then
					RSWIN_DESC.rst.gbOutputLoaded = True
					Me.Width = Me.ParentForm.Width - 30
					Me.Height = Me.ParentForm.Height - 125
					Me.Top = 0
					Me.Left = 0
					Util.BusyCursor()
					If bShowForm Then
						Me.Show()
					Else
						Me.optReport_Click_1(2S, True, True)
					End If
					Application.DoEvents()
					Try
						Me.Viewer1.Document = Nothing
						Me.pnlActiveReport.Visible = True
						Util.Message("Loading Output Results")
						Me.lblAnimateDyno.Visible = False
						Me.PopulateDynoPlotContextMenu()
						Me.ChartFX_Dyno.ContextMenu = Me.ctxMenu_DynoPlot
						Application.DoEvents()
						Dim num4 As Integer = 0
						If RSWIN_DESC.rst.gbCoverPage Then
							num4 += 1
						End If
						Dim num5 As Integer
						Dim flag6 As Boolean = RSWIN.HasFG(num5)
						Me.rptExpertSummary = New rptExpertSummary()
						Me.rptExpertSummary.bForceDisplay = False
						If RSWIN_DESC.bRodStarD Then
							Me.rptExpertSummary.sTapersOverMax = sTapersOverMax
						End If
						Me.rptExpertSummary.Run()
						Dim bCheckToAdd As Boolean = False
						flag5 = False
						Dim text2 As String = RSWIN.TotalExpertScore(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore, num, bCheckToAdd, flag, flag5, False, True)
						If CDbl(num) >= 0.99 And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.95 And CDbl(RSWIN_DESC.rst.StructL) <= 0.95 Then
							If Not Me.AllScoresOkay(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore) Then
								RSWIN_DESC.bShowScoringPage = True
								bForceDisplay = True
							Else
								RSWIN_DESC.bShowScoringPage = False
							End If
						ElseIf CDbl(num) >= 0.99 And Not Me.AllScoresOkay(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore) Then
							RSWIN_DESC.bShowScoringPage = True
							bForceDisplay = True
						Else
							RSWIN_DESC.bShowScoringPage = True
						End If
						If RSWIN_DESC.rst.gbScoringPage AndAlso RSWIN_DESC.bShowScoringPage Then
							num4 += 1
						End If
						If RSWIN_DESC.rst.gbReportData Then
							If Operators.CompareString(RSWIN_DESC.SETUP_Language, RSWIN_DESC.sEnglish, False) = 0 Then
								num4 += 1
							Else
								num4 += 2
							End If
						End If
						If RSWIN_DESC.rst.gbReportCostAnalysis <> 0S Then
							num4 += 1
						End If
						If RSWIN_DESC.rst.gbOrderPage Then
							num4 += 1
						End If
						If RSWIN_DESC.rst.gbReportIPR And RSWIN_DESC.rst.gbUseIPR Then
							num4 += 1
						End If
						If RSWIN_DESC.rst.gbOutputLoaded AndAlso (RSWIN_DESC.rst.gbReportDynoPred Or RSWIN_DESC.rst.NumRods > 10S) Then
							num4 += 1
						End If
						Dim flag7 As Boolean
						Dim text3 As String
						Dim flag8 As Boolean
						Dim text4 As String
						Dim text5 As String
						If(RSWIN_DESC.SETUP_UseImpred And If(-If((RSWIN_DESC.bRodStarD > False), 1S, 0S), 1S, 0S)) <> 0S AndAlso RSWIN_DESC.mdsDeviationProfile IsNot Nothing AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 2 Then
							Try
								flag3 = MImpred.CheckSurveyForDeviation()
							Catch ex4 As Exception
							End Try
							Try
								MImpred.InitSummaryReportXML(Me.nGuideLines, flag7, text3, flag8, text4, text5)
								flag4 = True
							Catch ex5 As Exception
							End Try
							If RSWIN_DESC.rst.gbReportGuide Or RSWIN_DESC.rst.gbReportDevChart Then
								Dim impredObj As TEImpred = MImpred.ImpredObj
								Try
									RSWIN_DESC.num_rod_elements = impredObj.num_rod_elements
								Catch ex6 As Exception
								End Try
							End If
							flag5 = False
							text = ""
							Dim flag9 As Boolean = False
							Dim text6 As String = ""
							Dim text7 As String = ""
							MImpred.GetReportXMLnPages(Me.nGuideLines, flag5, text, flag9, text6, text7, sTapersOverMax)
							If RSWIN_DESC.rst.gbReportGuide AndAlso flag3 Then
								num4 += RSWIN_DESC.rst.Number_Of_Guide_report_Pages
							End If
							If RSWIN_DESC.rst.gbReportDevChart Then
								num4 += 2
							End If
							If RSWIN_DESC.rst.gbReportDevSurvey Or RSWIN_DESC.rst.gbReportDevChart Then
								Try
									Me.mdsDeviationProfile_Output = Nothing
									MImpred.InitSurveyDataset(Me.mdsDeviationProfile_Output, Nothing)
									MImpred.CopyDatasets(RSWIN_DESC.mdsDeviationProfile, Me.mdsDeviationProfile_Output, RSWIN_DESC.SETUP_MeasurementSystem <> 1, False)
								Catch ex7 As Exception
								End Try
								If Not Me.bDogLegsCalculated Then
									Me.m_bAfterPump1 = False
									Me.m_bAfterPump2 = False
									Me.m_bAfterPump1_report = False
									Me.m_bAfterPump2_report = False
									Me.ShowDeviation_Dogleg(Me.mdsDeviationProfile_Output, False, True)
									Dim num6 As Short
									Me.ShowDeviation_TVD(Me.mdsDeviationProfile_Output, True, num6)
									Me.bDogLegsCalculated = True
								End If
								Me.BuildDeviationProfileXML_from_DS(Me.mdsDeviationProfile_Output, Me.nDevSurveyLines)
								If RSWIN_DESC.rst.gbReportDevSurvey Then
									num4 += RSWIN_DESC.rst.NumDevSurveyPages
								End If
							End If
							If RSWIN_DESC.bRodStarD Then
								Dim left As Integer = Me._optReport_2.Left
								Me._optReport_2.Left = Me.btnDevCharts.Left
								Me.btnDevCharts.Left = left
								Me.btnDevCharts.Visible = True
								Me.btnDevCharts.Enabled = True
								If RSWIN_DESC.rst.gbCoverPage Then
									Me.btnCoverPageComments.Left = Me._optReport_2.Left + Me._optReport_2.Width + 1
								End If
							End If
						End If
						Dim num7 As Integer = 0
						If RSWIN_DESC.rst.gbCoverPage Then
							Me.rptCoverPage = New rptCoverPage()
							num7 += 1
							Util.BusyCursor()
							Application.DoEvents()
							Me.rptCoverPage.TotalPageNumber = num4
							Me.rptCoverPage.ThisPageNumber = num7
							Me.rptCoverPage.bPrint = False
							Try
								Me.rptCoverPage.Run()
							Catch ex8 As Exception
							End Try
							Try
								For Each obj As Object In Me.rptCoverPage.Document.Pages
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
							If flag2 Then
								Me.Viewer1.Document = rptAll.Document
								Application.DoEvents()
								Application.DoEvents()
								Me.Refresh()
								Application.DoEvents()
								Application.DoEvents()
								Me.EnableToolbarButton(index, False)
							End If
						End If
						If RSWIN_DESC.rst.gbScoringPage Then
							If RSWIN_DESC.bShowScoringPage Then
								Me.rptExpertSummary = New rptExpertSummary()
								num7 += 1
								Util.BusyCursor()
								Application.DoEvents()
								Me.rptExpertSummary.TotalPageNumber = num4
								Me.rptExpertSummary.ThisPageNumber = num7
								Me.rptExpertSummary.bPrint = False
								Me.rptExpertSummary.bForceDisplay = bForceDisplay
								If RSWIN_DESC.bRodStarD Then
									Me.rptExpertSummary.sTapersOverMax = sTapersOverMax
								End If
								Me.rptExpertSummary.Run()
								Try
									For Each obj2 As Object In Me.rptExpertSummary.Document.Pages
										Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj2, DataDynamics.ActiveReports.Document.Page)
										rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
									Next
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
								If flag2 Then
									Me.Viewer1.Document = rptAll.Document
									Application.DoEvents()
									Application.DoEvents()
									Me.Refresh()
									Application.DoEvents()
									Application.DoEvents()
									Me.EnableToolbarButton(index, False)
								End If
							Else
								Util.Message("System Design Score grade is an A+. No recommendations are necessary.")
							End If
						End If
						If RSWIN_DESC.rst.gbReportData Then
							If Operators.CompareString(RSWIN_DESC.SETUP_Language, RSWIN_DESC.sEnglish, False) = 0 Then
								Util.BusyCursor()
								Application.DoEvents()
								Dim num8 As Integer
								If RSWIN_DESC.rst.gbSummaryPage Or RSWIN_DESC.rst.NumRods > 10S Or (RSWIN_DESC.rst.NumRods > 8S And RSWIN.bHasRelocatedSB(num8)) Then
									Me.rptCalcResults_Summary = New rptCalcResults_Summary()
									Me.rptCalcResults_Summary.TotalPageNumber = num4
									num7 += 1
									Me.rptCalcResults_Summary.ThisPageNumber = num7
									Me.rptCalcResults_Summary.bPrint = False
									Me.rptCalcResults_Summary.Run()
									Try
										For Each obj3 As Object In Me.rptCalcResults_Summary.Document.Pages
											Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj3, DataDynamics.ActiveReports.Document.Page)
											rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
										Next
										GoTo IL_BFB
									Finally
										Dim enumerator3 As IEnumerator
										If TypeOf enumerator3 Is IDisposable Then
											TryCast(enumerator3, IDisposable).Dispose()
										End If
									End Try
								End If
								Me.rptCalcResults = New rptCalcResults()
								Me.rptCalcResults.TotalPageNumber = num4
								num7 += 1
								Me.rptCalcResults.ThisPageNumber = num7
								Me.rptCalcResults.bPrint = False
								Me.ExportDynoAndTorqueCharts(True, True, True)
								Me.rptCalcResults.Run()
								Try
									For Each obj4 As Object In Me.rptCalcResults.Document.Pages
										Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj4, DataDynamics.ActiveReports.Document.Page)
										rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
									Next
								Finally
									Dim enumerator4 As IEnumerator
									If TypeOf enumerator4 Is IDisposable Then
										TryCast(enumerator4, IDisposable).Dispose()
									End If
								End Try
								IL_BFB:
								If flag2 Then
									Me.Viewer1.Document = rptAll.Document
									Application.DoEvents()
									Application.DoEvents()
									Me.Refresh()
									Application.DoEvents()
									Application.DoEvents()
									Me.EnableToolbarButton(index, False)
								End If
							Else
								Util.BusyCursor()
								Application.DoEvents()
								Me.rptResultsInputs = New rptResultsInputs()
								Me.rptResultsInputs.TotalPageNumber = num4
								num7 += 1
								Me.rptResultsInputs.ThisPageNumber = num7
								Me.rptResultsInputs.bPrint = False
								Me.rptResultsInputs.Run()
								Try
									For Each obj5 As Object In Me.rptResultsInputs.Document.Pages
										Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj5, DataDynamics.ActiveReports.Document.Page)
										rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
									Next
								Finally
									Dim enumerator5 As IEnumerator
									If TypeOf enumerator5 Is IDisposable Then
										TryCast(enumerator5, IDisposable).Dispose()
									End If
								End Try
								If flag2 Then
									Me.Viewer1.Document = rptAll.Document
									Application.DoEvents()
									Application.DoEvents()
									Me.Refresh()
									Application.DoEvents()
									Application.DoEvents()
									Me.EnableToolbarButton(index, False)
								End If
								Me.rptResultsOutputs = New rptResultsOutputs()
								Me.rptResultsOutputs.TotalPageNumber = num4
								num7 += 1
								Me.rptResultsOutputs.ThisPageNumber = num7
								Me.rptResultsOutputs.bPrint = False
								Me.ExportDynoAndTorqueCharts(True, True, False)
								Me.rptResultsOutputs.Run()
								Dim num9 As Integer = 0
								Try
									For Each obj6 As Object In Me.rptResultsOutputs.Document.Pages
										Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj6, DataDynamics.ActiveReports.Document.Page)
										num9 += 1
										If num9 = 1 Then
											rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
										End If
									Next
								Finally
									Dim enumerator6 As IEnumerator
									If TypeOf enumerator6 Is IDisposable Then
										TryCast(enumerator6, IDisposable).Dispose()
									End If
								End Try
								If flag2 Then
									Me.Viewer1.Document = rptAll.Document
									Application.DoEvents()
									Application.DoEvents()
									Me.Refresh()
									Application.DoEvents()
									Application.DoEvents()
									Me.EnableToolbarButton(index, False)
								End If
							End If
						End If
						Application.DoEvents()
						If RSWIN_DESC.rst.gbReportDynoPred Or RSWIN_DESC.rst.NumRods > 10S Then
							Util.BusyCursor()
							Application.DoEvents()
							If RSWIN_DESC.bUseLandscape Then
								Me.rptDynoAndTorqueChart_Landscape = New rptDynoAndTorqueChart_Landscape()
								Me.rptDynoAndTorqueChart_Landscape.TotalPageNumber = num4
								num7 += 1
								Me.rptDynoAndTorqueChart_Landscape.ThisPageNumber = num7
								Me.ExportDynoAndTorqueCharts2(True, True, True)
								Me.rptDynoAndTorqueChart_Landscape.bPrint = False
								Me.rptDynoAndTorqueChart_Landscape.Run(False)
								Try
									For Each obj7 As Object In Me.rptDynoAndTorqueChart_Landscape.Document.Pages
										Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj7, DataDynamics.ActiveReports.Document.Page)
										rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
									Next
									GoTo IL_FD7
								Finally
									Dim enumerator7 As IEnumerator
									If TypeOf enumerator7 Is IDisposable Then
										TryCast(enumerator7, IDisposable).Dispose()
									End If
								End Try
							End If
							Me.rptDynoAndTorqueChart = New rptDynoAndTorqueChart()
							Me.rptDynoAndTorqueChart.TotalPageNumber = num4
							num7 += 1
							Me.rptDynoAndTorqueChart.ThisPageNumber = num7
							Me.ExportDynoAndTorqueCharts2(True, True, False)
							Me.rptDynoAndTorqueChart.bPrint = False
							Me.rptDynoAndTorqueChart.Run(False)
							Try
								For Each obj8 As Object In Me.rptDynoAndTorqueChart.Document.Pages
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj8, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								Next
							Finally
								Dim enumerator8 As IEnumerator
								If TypeOf enumerator8 Is IDisposable Then
									TryCast(enumerator8, IDisposable).Dispose()
								End If
							End Try
							IL_FD7:
							If flag2 Then
								Me.Viewer1.Document = rptAll.Document
								Application.DoEvents()
								Application.DoEvents()
								Me.Refresh()
								Application.DoEvents()
								Application.DoEvents()
								Me.EnableToolbarButton(index, False)
							End If
						End If
						Application.DoEvents()
						If RSWIN_DESC.rst.gbReportCostAnalysis <> 0S Then
							Util.BusyCursor()
							Application.DoEvents()
							If RSWIN_DESC.bRodStarD And Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
								Me.m_rptCostAnalysis_D = New rptCostAnalysis_D()
								Me.m_rptCostAnalysis_D.bPrint = False
								Me.m_rptCostAnalysis_D.TotalPageNumber = num4
								num7 += 1
								Me.m_rptCostAnalysis_D.ThisPageNumber = num7
								Me.m_rptCostAnalysis_D.Run(False)
								Try
									For Each obj9 As Object In Me.m_rptCostAnalysis_D.Document.Pages
										Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj9, DataDynamics.ActiveReports.Document.Page)
										rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
									Next
									GoTo IL_11B2
								Finally
									Dim enumerator9 As IEnumerator
									If TypeOf enumerator9 Is IDisposable Then
										TryCast(enumerator9, IDisposable).Dispose()
									End If
								End Try
							End If
							Me.m_rptCostAnalysis = New rptCostAnalysis()
							Me.m_rptCostAnalysis.bPrint = False
							Me.m_rptCostAnalysis.TotalPageNumber = num4
							num7 += 1
							Me.m_rptCostAnalysis.ThisPageNumber = num7
							Me.m_rptCostAnalysis.Run(False)
							Try
								For Each obj10 As Object In Me.m_rptCostAnalysis.Document.Pages
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj10, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								Next
							Finally
								Dim enumerator10 As IEnumerator
								If TypeOf enumerator10 Is IDisposable Then
									TryCast(enumerator10, IDisposable).Dispose()
								End If
							End Try
							IL_11B2:
							If flag2 Then
								Me.Viewer1.Document = rptAll.Document
								Application.DoEvents()
								Application.DoEvents()
								Me.Refresh()
								Application.DoEvents()
								Application.DoEvents()
								Me.EnableToolbarButton(index, False)
							End If
						End If
						If RSWIN_DESC.rst.gbOrderPage Then
							Me.rptOrderPage = New rptOrderForm()
							num7 += 1
							Util.BusyCursor()
							Application.DoEvents()
							Me.rptOrderPage.TotalPageNumber = num4
							Me.rptOrderPage.ThisPageNumber = num7
							Me.rptOrderPage.bPrint = False
							Try
								Me.rptOrderPage.Run()
							Catch ex9 As Exception
							End Try
							Try
								For Each obj11 As Object In Me.rptOrderPage.Document.Pages
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj11, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								Next
							Finally
								Dim enumerator11 As IEnumerator
								If TypeOf enumerator11 Is IDisposable Then
									TryCast(enumerator11, IDisposable).Dispose()
								End If
							End Try
							If flag2 Then
								Me.Viewer1.Document = rptAll.Document
								Application.DoEvents()
								Application.DoEvents()
								Me.Refresh()
								Application.DoEvents()
								Application.DoEvents()
								Me.EnableToolbarButton(index, False)
							End If
						End If
						If RSWIN_DESC.rst.gbReportIPR And RSWIN_DESC.rst.gbUseIPR Then
							Util.BusyCursor()
							Application.DoEvents()
							num7 += 1
							Me.IPRPlot.LoadIPRPlot()
							Dim iprreport As IPRReport
							Me.IPRPlot.DisplayIPRPlot(iprreport, num7, num4, False)
							Try
								For Each obj12 As Object In iprreport.Document.Pages
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj12, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								Next
							Finally
								Dim enumerator12 As IEnumerator
								If TypeOf enumerator12 Is IDisposable Then
									TryCast(enumerator12, IDisposable).Dispose()
								End If
							End Try
							If flag2 Then
								Me.Viewer1.Document = rptAll.Document
								Application.DoEvents()
								Application.DoEvents()
								Me.Refresh()
								Application.DoEvents()
								Application.DoEvents()
								Me.EnableToolbarButton(index, False)
							End If
						End If
						Application.DoEvents()
						If(RSWIN_DESC.SETUP_UseImpred And If(-If((RSWIN_DESC.bRodStarD > False), 1S, 0S), 1S, 0S)) <> 0S AndAlso RSWIN_DESC.mdsDeviationProfile IsNot Nothing AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 2 Then
							Try
								Me.PlotSurvey()
							Catch ex10 As Exception
							End Try
							If RSWIN_DESC.rst.gbReportDevChart Then
								Util.BusyCursor()
								Application.DoEvents()
								Me.SizeDevCharts()
								Me.rptDeviationSurvey = New rptDeviationSurvey()
								Me.rptDeviationSurvey.bPrint = False
								Me.ExportSideForcesChart(True, True)
								Me.ExportAxialLoadsChart(True, True)
								Me.ExportBucklingTendencyChart(True, True)
								Me.ExportDoglegsChart(True, True)
								Me.fMaxForCharts = Me.FindMaxForCharts()
								Me.ExportSurveyEWChart(True, True)
								Me.ExportSurveyNSChart(True, True)
								Me.ExportSurveyPlanPlotChart(True, True)
								Me.rptDeviationSurvey.TotalPageNumber = num4
								num7 += 1
								Me.rptDeviationSurvey.ThisPageNumber = num7
								Me.rptDeviationSurvey.Run(False)
								Try
									Dim enumerator13 As IEnumerator = Me.rptDeviationSurvey.Document.Pages.GetEnumerator()
									If enumerator13.MoveNext() Then
										Dim value As DataDynamics.ActiveReports.Document.Page = CType(enumerator13.Current, DataDynamics.ActiveReports.Document.Page)
										rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
									End If
								Finally
									Dim enumerator13 As IEnumerator
									If TypeOf enumerator13 Is IDisposable Then
										TryCast(enumerator13, IDisposable).Dispose()
									End If
								End Try
								If flag2 Then
									Me.Viewer1.Document = rptAll.Document
									Application.DoEvents()
									Application.DoEvents()
									Me.Refresh()
									Application.DoEvents()
									Application.DoEvents()
									Me.EnableToolbarButton(index, False)
								End If
								If Not flag4 Then
									MImpred.InitSummaryReportXML(Me.nGuideLines, flag7, text3, flag8, text4, text5)
								End If
								Dim tchart1_Report As TChart = Me.TChart1_Report
								Me.ExportDevPlot(tchart1_Report)
								Me.TChart1_Report = tchart1_Report
								Me.rptDevSurvey3DPlot = New rptDevSurvey3DPlot()
								Me.rptDevSurvey3DPlot.TotalPageNumber = num4
								num7 += 1
								Me.rptDevSurvey3DPlot.ThisPageNumber = num7
								Me.rptDevSurvey3DPlot.Run(False)
								Try
									Dim enumerator14 As IEnumerator = Me.rptDevSurvey3DPlot.Document.Pages.GetEnumerator()
									If enumerator14.MoveNext() Then
										Dim value As DataDynamics.ActiveReports.Document.Page = CType(enumerator14.Current, DataDynamics.ActiveReports.Document.Page)
										rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
									End If
								Finally
									Dim enumerator14 As IEnumerator
									If TypeOf enumerator14 Is IDisposable Then
										TryCast(enumerator14, IDisposable).Dispose()
									End If
								End Try
								If flag2 Then
									Me.Viewer1.Document = rptAll.Document
									Application.DoEvents()
									Application.DoEvents()
									Me.Refresh()
									Application.DoEvents()
									Application.DoEvents()
									Me.EnableToolbarButton(index, False)
								End If
							End If
							If Not RSWIN_DESC.rst.gbReportDevChart And RSWIN_DESC.bRodStarD And Not flag4 Then
								MImpred.InitSummaryReportXML(Me.nGuideLines, flag7, text3, flag8, text4, text5)
							End If
							Util.BusyCursor()
							If RSWIN_DESC.rst.gbReportGuide AndAlso flag3 Then
								Util.BusyCursor()
								Application.DoEvents()
								If RSWIN_DESC.SETUP_RECOMMEND_GUIDES Or (Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bAllZeroNumGuides) Then
									Me.rptRecommendedGuideReport = New rptRecommendedGuideReport()
								Else
									Me.rptRecommendedGuideReport = New rptRecommendedGuideReport2()
								End If
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bPrint", New Object() { False }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bMaxFootnote", New Object() { flag8 }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sMaxFootnote", New Object() { text4 }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bMinFootnote", New Object() { flag7 }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sMinFootnote", New Object() { text3 }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sGuideMsg", New Object() { text5 }, Nothing, Nothing)
								Try
									Dim xmldataSource As XMLDataSource = New XMLDataSource()
									xmldataSource.LoadXML(RSWIN_DESC.sSummaryDataSetXML)
									NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object() { xmldataSource }, Nothing, Nothing)
									NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "DataSource", New Object() { xmldataSource }, Nothing, Nothing)
								Catch ex11 As Exception
								End Try
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "ValidateOnParse", New Object() { True }, Nothing, Nothing, False, True)
								CType(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), XMLDataSource).RecordsetPattern = "//Data/Entries/Row"
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "TotalPageNumber", New Object() { num4 }, Nothing, Nothing)
								num7 += 1
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "ThisPageNumber", New Object() { num7 }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "NumberOfLines", New Object() { Me.nGuideLines }, Nothing, Nothing)
								NewLateBinding.LateCall(Me.rptRecommendedGuideReport, Nothing, "Run", New Object() { False }, Nothing, Nothing, Nothing, True)
								If Me.nGuideLines > 0 Then
									Me.ToolTip1.SetToolTip(Me.btnImplement, "Implement RODSTAR-D Rod Guide Recommendations")
									Me.btnImplement.Visible = True
									If Not RSWIN_DESC.rst.bImplementedDesign Then
										Me.btnImplement.Enabled = True
										Me.bImplementOn = True
									Else
										Me.btnImplement.Enabled = False
										Me.bImplementOn = False
									End If
								End If
								Dim num10 As Integer = 1
								Try
									For Each obj13 As Object In CType(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Pages", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable)
										Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj13, DataDynamics.ActiveReports.Document.Page)
										rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
										If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Pages", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Count", New Object(-1) {}, Nothing, Nothing, Nothing), RSWIN_DESC.rst.Number_Of_Guide_report_Pages, False))) Then
											num10 += 1
											If num10 > RSWIN_DESC.rst.Number_Of_Guide_report_Pages Then
												Exit For
											End If
										End If
									Next
								Finally
									Dim enumerator15 As IEnumerator
									If TypeOf enumerator15 Is IDisposable Then
										TryCast(enumerator15, IDisposable).Dispose()
									End If
								End Try
								If flag2 Then
									Me.Viewer1.Document = rptAll.Document
									Application.DoEvents()
									Application.DoEvents()
									Me.Refresh()
									Application.DoEvents()
									Application.DoEvents()
									Me.EnableToolbarButton(index, False)
								End If
							End If
							If RSWIN_DESC.rst.gbReportDevSurvey Then
								Util.BusyCursor()
								Application.DoEvents()
								Me.rptDeviationProfile = New rptDeviationProfile()
								Me.rptDeviationProfile.bPrint = False
								Try
									Dim xmldataSource2 As XMLDataSource = New XMLDataSource()
									xmldataSource2.LoadXML(RSWIN_DESC.sDeviationProfileXML)
									Me.rptDeviationProfile.ds = xmldataSource2
									Me.rptDeviationProfile.DataSource = xmldataSource2
								Catch ex12 As Exception
								End Try
								Me.rptDeviationProfile.ds.ValidateOnParse = True
								Me.rptDeviationProfile.ds.RecordsetPattern = "//Data/Entries/Row"
								Me.rptDeviationProfile.TotalPageNumber = num4
								If RSWIN_DESC.rst.gbReportGuide AndAlso flag3 Then
									num7 += RSWIN_DESC.rst.Number_Of_Guide_report_Pages
								Else
									num7 += 1
								End If
								Me.rptDeviationProfile.ThisPageNumber = num7
								Me.rptDeviationProfile.NumberOfLines = Me.nDevSurveyLines
								Me.rptDeviationProfile.Run(False)
								Try
									For Each obj14 As Object In Me.rptDeviationProfile.Document.Pages
										Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj14, DataDynamics.ActiveReports.Document.Page)
										rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
									Next
								Finally
									Dim enumerator16 As IEnumerator
									If TypeOf enumerator16 Is IDisposable Then
										TryCast(enumerator16, IDisposable).Dispose()
									End If
								End Try
								num7 = num7 + CInt(Math.Round(CDbl(Me.nDevSurveyLines) / 35.0)) - 1
								If flag2 Then
									Util.BusyCursor()
									Me.Viewer1.Document = rptAll.Document
									Application.DoEvents()
									Application.DoEvents()
									Me.Refresh()
									Application.DoEvents()
									Application.DoEvents()
									Me.EnableToolbarButton(index, False)
								End If
							End If
						End If
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						Me.Viewer1.Document = rptAll.Document
						Me.Refresh()
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						Me.EnableToolbarButton(index, False)
						Me.pnlActiveReport.Visible = True
						Me.pnlDyno.Visible = False
						Me.pnlTorquePlot.Visible = False
						Me.Refresh()
						Application.DoEvents()
						Me.timAnimate.Enabled = False
						Me.tbbStop.Enabled = False
						Me.tbbStep.Enabled = True
						Me.tbbRun.Enabled = True
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						Me.iInterval = Me.IntervalConst
						Me.nSkip = 1
						Me.Animate_Ntsteps = rst.Ntsteps
						Me.iAnimCurPoint = CInt(rst.Ntsteps)
						If Not RSWIN_DESC.bRodStarD Then
							Me.fAnimInterval = Conversion.Int(CSng(Me.iInterval) / rst.SPM / CSng(rst.Ntsteps))
						Else
							Me.fAnimInterval = 1F
						End If
						Me.timAnimate.Interval = CInt(Math.Round(CDbl(Me.fAnimInterval)))
						Me.nInitialSkip = Me.nSkip
						Me.cmdIPRPlot.Enabled = rst.gbUseIPR
						Me.InitTrackbar()
						Util.UnbusyCursor()
						Me.bFormLoaded = True
					Catch ex13 As Exception
						Util.UnbusyCursor()
					End Try
				End If
				Me.EnableToolbarButton(index, True)
				If RSWIN_DESC.rst.gbCoverPage Then
					Me.btnCoverPageComments.Enabled = True
				End If
			Catch ex14 As Exception
			End Try
		End Sub

		Private Sub SetToolbarButtonVisible(Index As Integer, bVal As Boolean)
			Try
				Me.Viewer1.Toolbar.Tools(Index).Visible = bVal
			Catch ex As Exception
			End Try
		End Sub

		Private Sub EnableToolbarButton(Index As Integer, bVal As Boolean)
			Try
				Me.Viewer1.Toolbar.Tools(Index).Enabled = bVal
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SizeDevCharts()
			Dim chtSideForces As ChartFX.WinForms.Chart = Me.chtSideForces
			chtSideForces.Width = 262
			chtSideForces.Height = 425
			Dim chtAxialLoads As ChartFX.WinForms.Chart = Me.chtAxialLoads
			chtAxialLoads.Width = 262
			chtAxialLoads.Height = 425
			Dim chtBucklingTendency As ChartFX.WinForms.Chart = Me.chtBucklingTendency
			chtBucklingTendency.Width = 262
			chtBucklingTendency.Height = 425
			Dim chtSurveyEW As ChartFX.WinForms.Chart = Me.chtSurveyEW
			chtSurveyEW.Width = 438
			chtSurveyEW.Height = 281
			Dim chtSurveyNS As ChartFX.WinForms.Chart = Me.chtSurveyNS
			chtSurveyNS.Width = 438
			chtSurveyNS.Height = 282
			Dim chtSurveyPlan As ChartFX.WinForms.Chart = Me.chtSurveyPlan
			chtSurveyPlan.Width = 338
			chtSurveyPlan.Height = 350
		End Sub

		Public Sub LoadGraphs()
			Dim rptAll As rptAll = New rptAll()
			Try
				Me.ChartFX_Dyno.ContextMenu = Nothing
				If Operators.CompareString(RSWIN_DESC.SETUP_Language, RSWIN_DESC.sEnglish, False) = 0 Then
					Me.rptCalcResults = New rptCalcResults()
					Me.rptCalcResults.TotalPageNumber = 2
					Me.rptCalcResults.ThisPageNumber = 2
					Me.rptCalcResults.bPrint = False
					Me.ExportDynoAndTorqueCharts(True, True, True)
					Me.rptCalcResults.Run()
					Me.Viewer1.Document = Me.rptCalcResults.Document
				Else
					Me.rptResultsInputs = New rptResultsInputs()
					Me.rptResultsInputs.TotalPageNumber = 2
					Me.rptResultsInputs.ThisPageNumber = 1
					Me.rptResultsInputs.bPrint = False
					Me.rptResultsInputs.Run()
					Try
						For Each obj As Object In Me.rptResultsInputs.Document.Pages
							Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj, DataDynamics.ActiveReports.Document.Page)
							rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					Me.rptResultsOutputs = New rptResultsOutputs()
					Me.rptResultsOutputs.TotalPageNumber = 2
					Me.rptResultsOutputs.ThisPageNumber = 2
					Me.rptResultsOutputs.bPrint = False
					Me.ExportDynoAndTorqueCharts(True, True, False)
					Me.rptResultsOutputs.Run()
					Dim num As Integer = 0
					Try
						For Each obj2 As Object In Me.rptResultsOutputs.Document.Pages
							Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj2, DataDynamics.ActiveReports.Document.Page)
							num += 1
							If num = 1 Then
								rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					Me.Viewer1.Document = rptAll.Document
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in LoadGraphs: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub Results_Resize(eventSender As Object, eventArgs As EventArgs)
			Me.ResultsResize()
		End Sub

		Private Sub ResultsResize()
			' The following expression was wrapped in a checked-statement
			Try
				Me.pnlActiveReport.Width = Me.Width - 10
				Me.pnlActiveReport.Height = Me.Height - 50
				Me.Viewer1.Width = Me.pnlActiveReport.Width - 50
				Me.Viewer1.Height = Me.pnlActiveReport.Height - 55
				Me.pnlDyno.Width = Me.Width - 30
				Me.pnlDyno.Height = Me.Height - 60
				Me.ChartFX_Dyno.Height = Me.pnlDyno.Height - 50
				If Me.ChartFX_Dyno.LegendBox.Height > 0 Then
					' The following expression was wrapped in a unchecked-expression
					RSWIN_DESC.fDynoLegendFactor = CSng((1.4252 * CDbl(Me.ChartFX_Dyno.LegendBox.Height) / CDbl(Me.ChartFX_Dyno.Height)))
				Else
					RSWIN_DESC.fDynoLegendFactor = 0F
				End If
				Me.ChartFX_Dyno.Width = CInt(Math.Round(CDbl(Me.ChartFX_Dyno.Height) * (1.4252 - CDbl(RSWIN_DESC.fDynoLegendFactor))))
				Dim pnlDyno As System.Windows.Forms.Panel = Me.pnlDyno
				Dim chart As ChartFX.WinForms.Chart = Me.ChartFX_Dyno
				Me.CenterChartInPanel(pnlDyno, chart)
				Me.ChartFX_Dyno = chart
				Me.pnlTorquePlot.Width = Me.Width - 30
				Me.pnlTorquePlot.Height = Me.Height - 60
				If Me.ChartFX_TorquePlot.LegendBox.Height > 0 Then
					' The following expression was wrapped in a unchecked-expression
					RSWIN_DESC.fTorqueLegendFactor = CSng((1.4252 * CDbl(Me.ChartFX_TorquePlot.LegendBox.Height) / CDbl(Me.ChartFX_TorquePlot.Height)))
				Else
					RSWIN_DESC.fTorqueLegendFactor = 0F
				End If
				Me.ChartFX_TorquePlot.Height = Me.pnlTorquePlot.Height - 50
				Me.ChartFX_TorquePlot.Width = CInt(Math.Round(CDbl(Me.ChartFX_TorquePlot.Height) * (1.4252 - CDbl(RSWIN_DESC.fTorqueLegendFactor))))
				Dim pnlTorquePlot As System.Windows.Forms.Panel = Me.pnlTorquePlot
				chart = Me.ChartFX_TorquePlot
				Me.CenterChartInPanel(pnlTorquePlot, chart)
				Me.ChartFX_TorquePlot = chart
				If Me.cmdClose.Left <> Me.Width - Me.cmdClose.Width - 50 Then
					Me.cmdClose.Left = Me.Width - Me.cmdClose.Width - 50
				End If
				If RSWIN_DESC.bRodStarD And Me.pnlDevCharts.Visible Then
					Me.pnlDevCharts.Width = Me.Width - 10
					Me.ChartFX_AxialLoads.Left = Me.ChartFX_Dyno.Left + 130
					Me.ChartFX_AxialLoads.Width = Me.ChartFX_Dyno.Width - 225
					Me.ChartFX_AxialLoads.Height = Me.ChartFX_Dyno.Height - 20
					Me.ChartFX_AxialLoads.Top = Me.ChartFX_Dyno.Top
					Me.ChartFX_BucklingTendency.Left = Me.ChartFX_Dyno.Left + 130
					Me.ChartFX_BucklingTendency.Width = Me.ChartFX_Dyno.Width - 225
					Me.ChartFX_BucklingTendency.Height = Me.ChartFX_Dyno.Height - 20
					Me.ChartFX_BucklingTendency.Top = Me.ChartFX_Dyno.Top
					Me.ChartFX_SideLoading.Left = Me.ChartFX_Dyno.Left + 130
					Me.ChartFX_SideLoading.Width = Me.ChartFX_Dyno.Width - 225
					Me.ChartFX_SideLoading.Height = Me.ChartFX_Dyno.Height - 20
					Me.ChartFX_SideLoading.Top = Me.ChartFX_Dyno.Top
					Me.ChartFX_LookingNorth.Left = Me.ChartFX_Dyno.Left + 130
					Me.ChartFX_LookingNorth.Width = Me.ChartFX_Dyno.Width - 225
					Me.ChartFX_LookingNorth.Height = Me.ChartFX_Dyno.Height - 20
					Me.ChartFX_LookingNorth.Top = Me.ChartFX_Dyno.Top
					Me.ChartFX_LookingEast.Left = Me.ChartFX_Dyno.Left + 130
					Me.ChartFX_LookingEast.Width = Me.ChartFX_Dyno.Width - 225
					Me.ChartFX_LookingEast.Height = Me.ChartFX_Dyno.Height - 20
					Me.ChartFX_LookingEast.Top = Me.ChartFX_Dyno.Top
					Me.ChartFX_LookingDown.Left = Me.ChartFX_Dyno.Left + 130
					Me.ChartFX_LookingDown.Width = Me.ChartFX_Dyno.Width - 225
					Me.ChartFX_LookingDown.Height = Me.ChartFX_Dyno.Height - 20
					Me.ChartFX_LookingDown.Top = Me.ChartFX_Dyno.Top
					Me.ChartFX_DoglegSeverity.Left = Me.ChartFX_Dyno.Left + 130
					Me.ChartFX_DoglegSeverity.Width = Me.ChartFX_Dyno.Width - 225
					Me.ChartFX_DoglegSeverity.Height = Me.ChartFX_Dyno.Height - 20
					Me.ChartFX_DoglegSeverity.Top = Me.ChartFX_Dyno.Top
					Me.btnPrevDevChart.Top = Me.pnlTabs.Top - Me.btnPrevDevChart.Height + 1
					Me.btnNextDevChart.Top = Me.btnPrevDevChart.Top
					Me.btnPrevDevChart.Left = CInt(Math.Round(CDbl(Me.pnlDevCharts.Left) + CDbl(Me.pnlDevCharts.Width) / 2.0 - CDbl(Me.btnPrevDevChart.Width)))
					Me.btnNextDevChart.Left = Me.btnPrevDevChart.Left + Me.btnNextDevChart.Width + 5
					If Me.cmdClose.Left < Me.btnNextDevChart.Left + Me.btnNextDevChart.Width Then
						Me.btnNextDevChart.Left = Me.cmdClose.Left - (Me.btnNextDevChart.Width + 25)
						Me.btnPrevDevChart.Left = Me.btnNextDevChart.Left - (Me.btnPrevDevChart.Width + 5)
					End If
					If Me._optReport_2.Left + Me._optReport_2.Width > Me.btnPrevDevChart.Left Then
						Me.btnPrevDevChart.Left = Me._optReport_2.Left + (Me._optReport_2.Width + 25)
						Me.btnNextDevChart.Left = Me.btnPrevDevChart.Left + (Me.btnNextDevChart.Width + 5)
					End If
					Me.pnlGrpDevPlot.Left = 30
					Me.pnlGrpDevPlot.Top = 10
					Me.pnlGrpDevPlot.Width = Me.pnlDevCharts.Width - 60
					Me.pnlGrpDevPlot.Height = Me.btnPrevDevChart.Top - 20
					Me.pnlGrpDevPlot.BringToFront()
					Me.TChart1.Left = 0
					Me.TChart1.Top = Me.pnlCommander.Top + Me.pnlCommander.Height + 5
					Me.TChart1.Height = Me.pnlLegend.Top - Me.TChart1.Top - 5
					Me.TChart1.Width = Me.pnlGrpDevPlot.Width
					Me.TChart1.Refresh()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub optReport_CheckedChanged(eventSender As Object, eventArgs As EventArgs)
			If Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, Nothing, "Checked", New Object(-1) {}, Nothing, Nothing, Nothing)) Then
				Dim index As Short = Me.optReport.GetIndex(CType(eventSender, RadioButton))
				Me.optReport_Click_1(index, True, True)
			End If
		End Sub

		Private Sub optReport_Click_1(Index As Short, Value As Boolean, Clicked As Boolean)
			Dim rptAll As rptAll = New rptAll()
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.MakeSureAnimationIsntRunning()
			Me.pnlDyno.Visible = False
			Me.pnlActiveReport.Visible = False
			Me.pnlTorquePlot.Visible = False
			Me.pnlDevCharts.Visible = False
			Me.optPrevDevChart.Visible = False
			Me.optNextDevChart.Visible = False
			Me.btnPrevDevChart.Visible = False
			Me.btnNextDevChart.Visible = False
			Me.iCurrentRptOpt = CInt(Index)
			Me.bViewing3DPlot = False
			Select Case Index
				Case 0S
					If Me.cmdClose.Left < Me.TrackBar1.Left + Me.TrackBar1.Width + 10 Then
						Me.cmdClose.Left = Me.TrackBar1.Left + Me.TrackBar1.Width + 10
					End If
					Dim chart As ChartFX.WinForms.Chart
					If(If(-If((RSWIN_DESC.bRodStarD > False), 1S, 0S), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
						chart = Me.ChartFX_Dyno
						Me.DisplayDyno_Animate(chart, True, True, False)
						Me.ChartFX_Dyno = chart
					Else
						chart = Me.ChartFX_Dyno
						Me.DisplayDyno(chart, True, True)
						Me.ChartFX_Dyno = chart
					End If
					Dim pnlDyno As System.Windows.Forms.Panel = Me.pnlDyno
					chart = Me.ChartFX_Dyno
					Me.CenterChartInPanel(pnlDyno, chart)
					Me.ChartFX_Dyno = chart
					Me.pnlDyno.Visible = True
					Me.pnlDyno.BringToFront()
					Me.LastPanel = Me.pnlDyno
					Me.sPanelType = "Dyno"
					Me.SetAnimateButtonsVisible(True)
					Return
				Case 1S
					Dim chart As ChartFX.WinForms.Chart = Me.ChartFX_TorquePlot
					Me.PlotTorqueData(chart, True)
					Me.ChartFX_TorquePlot = chart
					Dim pnlTorquePlot As System.Windows.Forms.Panel = Me.pnlTorquePlot
					chart = Me.ChartFX_TorquePlot
					Me.CenterChartInPanel(pnlTorquePlot, chart)
					Me.ChartFX_TorquePlot = chart
					Me.pnlTorquePlot.Visible = True
					Me.pnlTorquePlot.BringToFront()
					Me.LastPanel = Me.pnlTorquePlot
					Me.sPanelType = "Torque"
					Me.SetAnimateButtonsVisible(False)
					Return
				Case 2S
					Me.pnlActiveReport.Visible = True
					Me.pnlActiveReport.BringToFront()
					Me.LastPanel = Me.pnlActiveReport
					Me.sPanelType = "Report"
					Me.SetAnimateButtonsVisible(False)
					If Not Me.bImplementOn Then
						Me.btnImplement.Visible = False
						Return
					End If
					Me.ToolTip1.SetToolTip(Me.btnImplement, "Implement expert rod guide placement")
					Me.btnImplement.Visible = True
					If Not RSWIN_DESC.rst.bImplementedDesign Then
						Me.btnImplement.Enabled = True
						Me.bImplementOn = True
						Return
					End If
					Me.btnImplement.Enabled = False
					Me.bImplementOn = False
					Return
				Case 3S
					Me.SetAnimateButtonsVisible(False)
					Try
						If Me.bImplementOn Then
							Me.ToolTip1.SetToolTip(Me.btnImplement, "Implement expert rod guide placement")
							Me.btnImplement.Visible = True
						Else
							Me.btnImplement.Visible = False
						End If
						If Operators.CompareString(RSWIN_DESC.SETUP_Language, RSWIN_DESC.sEnglish, False) = 0 Then
							Dim num As Integer
							If RSWIN_DESC.rst.gbSummaryPage Or RSWIN_DESC.rst.NumRods > 10S Or (RSWIN_DESC.rst.NumRods > 8S And RSWIN.bHasRelocatedSB(num)) Then
								Me.rptCalcResults_Summary = New rptCalcResults_Summary()
								Me.rptCalcResults_Summary.TotalPageNumber = 1
								Me.rptCalcResults_Summary.ThisPageNumber = 1
								Me.rptCalcResults_Summary.bPrint = False
								Me.rptCalcResults_Summary.Run()
								Me.Viewer1.Document = Me.rptCalcResults_Summary.Document
							Else
								Me.rptCalcResults = New rptCalcResults()
								Me.rptCalcResults.TotalPageNumber = 1
								Me.rptCalcResults.ThisPageNumber = 1
								Me.rptCalcResults.bPrint = False
								Me.ExportDynoAndTorqueCharts(True, True, True)
								Me.rptCalcResults.Run()
								Me.Viewer1.Document = Me.rptCalcResults_Summary.Document
							End If
						Else
							Me.rptResultsInputs = New rptResultsInputs()
							Me.rptResultsInputs.TotalPageNumber = 2
							Me.rptResultsInputs.ThisPageNumber = 1
							Me.rptResultsInputs.bPrint = False
							Me.rptResultsInputs.Run()
							Try
								For Each obj As Object In Me.rptResultsInputs.Document.Pages
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
							Me.rptResultsOutputs = New rptResultsOutputs()
							Me.rptResultsOutputs.TotalPageNumber = 2
							Me.rptResultsOutputs.ThisPageNumber = 2
							Me.rptResultsOutputs.bPrint = False
							Me.ExportDynoAndTorqueCharts(True, True, False)
							Me.rptResultsOutputs.Run()
							Dim num2 As Integer = 0
							Try
								For Each obj2 As Object In Me.rptResultsOutputs.Document.Pages
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj2, DataDynamics.ActiveReports.Document.Page)
									num2 += 1
									If num2 = 1 Then
										rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
							Me.Viewer1.Document = rptAll.Document
						End If
						Me.pnlActiveReport.Visible = True
						Me.pnlActiveReport.BringToFront()
						Me.LastPanel = Me.pnlActiveReport
						Me.sPanelType = "Report"
						Return
					Catch ex2 As Exception
						Dim sMsg As String = "Error in optReport: " + ex2.Message
						Dim sMsgType As String = "Error"
						Dim bClosing As Boolean = False
						Dim dialogResult As DialogResult = DialogResult.OK
						Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
						Return
					End Try
				Case 4S
				Case 5S
					Return
				Case 6S
					If RSWIN_DESC.bRodStarD Then
						Me.SetAnimateButtonsVisible(False)
						Util.BusyCursor()
						Dim chart As ChartFX.WinForms.Chart = Me.ChartFX_SideLoading
						Me.ShowSideForces(chart, True)
						Me.ChartFX_SideLoading = chart
						chart = Me.ChartFX_AxialLoads
						Me.ShowAxialLoads(chart, True)
						Me.ChartFX_AxialLoads = chart
						chart = Me.ChartFX_BucklingTendency
						Me.ShowBucklingTendency(chart, True)
						Me.ChartFX_BucklingTendency = chart
						chart = Me.ChartFX_LookingNorth
						Me.ShowSurveyNS(chart, True)
						Me.ChartFX_LookingNorth = chart
						chart = Me.ChartFX_LookingEast
						Me.ShowSurveyEW(chart, True)
						Me.ChartFX_LookingEast = chart
						chart = Me.ChartFX_LookingDown
						Me.ShowSurveyPlan(chart, True)
						Me.ChartFX_LookingDown = chart
						chart = Me.ChartFX_DoglegSeverity
						Me.ShowDoglegs(chart, True)
						Me.ChartFX_DoglegSeverity = chart
						Me.ChartFX_AxialLoads.Left = Me.ChartFX_Dyno.Left + 130
						Me.ChartFX_AxialLoads.Width = Me.ChartFX_Dyno.Width - 225
						Me.ChartFX_AxialLoads.Height = Me.ChartFX_Dyno.Height - 20
						Me.ChartFX_AxialLoads.Top = Me.ChartFX_Dyno.Top
						Me.ChartFX_BucklingTendency.Left = Me.ChartFX_Dyno.Left + 130
						Me.ChartFX_BucklingTendency.Width = Me.ChartFX_Dyno.Width - 225
						Me.ChartFX_BucklingTendency.Height = Me.ChartFX_Dyno.Height - 20
						Me.ChartFX_BucklingTendency.Top = Me.ChartFX_Dyno.Top
						Me.ChartFX_SideLoading.Left = Me.ChartFX_Dyno.Left + 130
						Me.ChartFX_SideLoading.Width = Me.ChartFX_Dyno.Width - 225
						Me.ChartFX_SideLoading.Height = Me.ChartFX_Dyno.Height - 20
						Me.ChartFX_SideLoading.Top = Me.ChartFX_Dyno.Top
						Me.ChartFX_LookingNorth.Left = Me.ChartFX_Dyno.Left + 130
						Me.ChartFX_LookingNorth.Width = Me.ChartFX_Dyno.Width - 225
						Me.ChartFX_LookingNorth.Height = Me.ChartFX_Dyno.Height - 20
						Me.ChartFX_LookingNorth.Top = Me.ChartFX_Dyno.Top
						Me.ChartFX_LookingEast.Left = Me.ChartFX_Dyno.Left + 130
						Me.ChartFX_LookingEast.Width = Me.ChartFX_Dyno.Width - 225
						Me.ChartFX_LookingEast.Height = Me.ChartFX_Dyno.Height - 20
						Me.ChartFX_LookingEast.Top = Me.ChartFX_Dyno.Top
						Me.ChartFX_LookingDown.Left = Me.ChartFX_Dyno.Left + 130
						Me.ChartFX_LookingDown.Width = Me.ChartFX_Dyno.Width - 225
						Me.ChartFX_LookingDown.Height = Me.ChartFX_Dyno.Height - 20
						Me.ChartFX_LookingDown.Top = Me.ChartFX_Dyno.Top
						Me.ChartFX_DoglegSeverity.Left = Me.ChartFX_Dyno.Left + 130
						Me.ChartFX_DoglegSeverity.Width = Me.ChartFX_Dyno.Width - 225
						Me.ChartFX_DoglegSeverity.Height = Me.ChartFX_Dyno.Height - 20
						Me.ChartFX_DoglegSeverity.Top = Me.ChartFX_Dyno.Top
						Me.m_iDevChart = 1
						Me.btnPrevDevChart.Enabled = False
						Me.ShowDevPlot(Me.m_iDevChart)
						Me.pnlDevCharts.Visible = True
						Application.DoEvents()
						Application.DoEvents()
						Me.btnPrevDevChart.Left = CInt(Math.Round(CDbl(Me.pnlDevCharts.Left) + CDbl(Me.pnlDevCharts.Width) / 2.0 - CDbl(Me.btnPrevDevChart.Width)))
						Me.btnNextDevChart.Left = Me.btnPrevDevChart.Left + Me.btnNextDevChart.Width + 5
						If Me.cmdClose.Left < Me.btnNextDevChart.Left + Me.btnNextDevChart.Width Then
							Me.btnNextDevChart.Left = Me.cmdClose.Left - (Me.btnNextDevChart.Width + 25)
							Me.btnPrevDevChart.Left = Me.btnNextDevChart.Left - (Me.btnPrevDevChart.Width + 5)
						End If
						If Me._optReport_2.Left + Me._optReport_2.Width > Me.btnPrevDevChart.Left Then
							Me.btnPrevDevChart.Left = Me._optReport_2.Left + (Me._optReport_2.Width + 25)
							Me.btnNextDevChart.Left = Me.btnPrevDevChart.Left + (Me.btnNextDevChart.Width + 5)
						End If
						Me.btnPrevDevChart.Top = Me.pnlTabs.Top - Me.btnPrevDevChart.Height + 1
						Me.btnNextDevChart.Top = Me.btnPrevDevChart.Top
						Me.btnPrevDevChart.Visible = True
						Me.btnNextDevChart.Visible = True
						Try
							Me.commander1.Buttons(8).Enabled = False
							Me.commander1.Buttons(8).Visible = False
							Me.commander1.Buttons(11).Enabled = False
							Me.commander1.Buttons(11).Visible = False
						Catch ex3 As Exception
						End Try
						Me.pnlDevCharts.Visible = True
						Util.UnbusyCursor()
						Return
					End If
					Return
				Case Else
					Return
			End Select
			Me.SetAnimateButtonsVisible(False)
		End Sub

		Private Sub picOutput_Paint(eventSender As Object, eventArgs As PaintEventArgs)
		End Sub

		Public Sub InitAnimation()
			' The following expression was wrapped in a checked-statement
			Try
				Me.timAnimate.Enabled = False
				Me.tbbStop.Enabled = False
				Me.tbbStep.Enabled = True
				Me.tbbRun.Enabled = True
				Me.DynoCardAnnotx = New Annotations()
				Me.DynoCardAnnotx.List.Clear()
				Me.ChartFX_Dyno.Extensions.Clear()
				Me.ChartFX_Dyno.Extensions.Add(Me.DynoCardAnnotx)
				Me.SurfCircle = New AnnotationCircle()
				Me.PumpCircle = New AnnotationCircle()
				Me.DynoCardAnnotx.List.Add(Me.SurfCircle)
				Me.SurfCircle.Color = Color.Red
				Me.SurfCircle.Border.Color = Color.Transparent
				Me.SurfCircle.Height = 7
				Me.SurfCircle.Width = 7
				Me.DynoCardAnnotx.List.Add(Me.PumpCircle)
				Me.PumpCircle.Color = Color.Green
				Me.PumpCircle.Border.Color = Color.Transparent
				Me.PumpCircle.Height = 7
				Me.PumpCircle.Width = 7
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Application.DoEvents()
				Me.iAnimationCycle = 0
				Me.SurfCircle.Attach(CDbl(Me.m_Animate_SurfPos(CInt((Me.Animate_Ntsteps - 1S)))), CDbl(Me.m_Animate_SurfLoad(CInt((Me.Animate_Ntsteps - 1S)))))
				Me.PumpCircle.Attach(CDbl(Me.m_Animate_PumpPos(CInt((Me.Animate_Ntsteps - 1S)))), CDbl(Me.m_Animate_PumpLoad(CInt((Me.Animate_Ntsteps - 1S)))))
				Application.DoEvents()
				Me.ChartFX_Dyno.Refresh()
				Me.iAnimCurPoint = CInt(Me.Animate_Ntsteps)
				If Not RSWIN_DESC.bRodStarD Then
					Me.fAnimInterval = Conversion.Int(CSng(Me.iInterval) / rst.SPM / CSng(Me.Animate_Ntsteps))
				Else
					Me.fAnimInterval = 1F
				End If
				Me.timAnimate.Interval = CInt(Math.Round(CDbl(Me.fAnimInterval)))
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
			Catch ex As Exception
				Dim sMsg As String = "Error in subroutine: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub tbbRun_Click(eventSender As Object, eventArgs As EventArgs)
			Me.bForward = True
			Me.RunAutomation()
		End Sub

		Friend Sub RunAutomation()
			Try
				Me.ResetClock()
				If Not Me.bPlay Then
					Me.bPlay = True
					Me.iInterval = CInt(Math.Round(CDbl(Me.IntervalConst) - CDbl((Me.nStep * Me.IntervalConst)) * 0.05))
					If Me.iInterval < 5000 Then
						Me.iInterval = 5000
					End If
					If Not RSWIN_DESC.bRodStarD Then
						Me.fAnimInterval = Conversion.Int(CSng(Me.iInterval) / RSWIN_DESC.rst.SPM / CSng(RSWIN_DESC.rst.Ntsteps))
						Me.timAnimate.Interval = CInt(Math.Round(CDbl(Me.fAnimInterval)))
					Else
						Me.fAnimInterval = 1F
						Me.timAnimate.Interval = 1
					End If
					Application.DoEvents()
					RSWIN_DESC.bAnimating = True
					Me._optReport_0.Enabled = False
					Me._optReport_1.Enabled = False
					Me._optReport_2.Enabled = False
					Me.cmdIPRPlot.Enabled = False
					Me.btnDevCharts.Enabled = False
					Me.cmdIPRPlot.Enabled = False
					Me.TrackBar1.Height = 20
					Me.TrackBar1.Visible = True
					If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred And If((-If((Not Me.bTogglePlay > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						Me.pnlDyno.Visible = False
					End If
					Me.TrackBar1.Height = 20
					If Not Me.pnlDyno.Visible Then
						Me.pnlDyno.Visible = True
						Dim chartFX_Dyno As ChartFX.WinForms.Chart
						If Not Me.bTogglePlay Then
							If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
								chartFX_Dyno = Me.ChartFX_Dyno
								Me.DisplayDyno_Animate(chartFX_Dyno, True, True, True)
								Me.ChartFX_Dyno = chartFX_Dyno
							Else
								chartFX_Dyno = Me.ChartFX_Dyno
								Me.DisplayDyno(chartFX_Dyno, True, True)
								Me.ChartFX_Dyno = chartFX_Dyno
							End If
						End If
						Me.pnlActiveReport.Visible = False
						Me.pnlTorquePlot.Visible = False
						Dim pnlDyno As System.Windows.Forms.Panel = Me.pnlDyno
						chartFX_Dyno = Me.ChartFX_Dyno
						Me.CenterChartInPanel(pnlDyno, chartFX_Dyno)
						Me.ChartFX_Dyno = chartFX_Dyno
					End If
					If Not Me.bTogglePlay Then
						Me.InitAnimation()
					End If
					If Not RSWIN_DESC.bRodStarD Then
						' The following expression was wrapped in a checked-expression
						Me.timAnimate.Interval = CInt(Math.Round(CDbl(Me.fAnimInterval)))
					Else
						Me.timAnimate.Interval = 1
					End If
					Me.timAnimate.Enabled = True
					Me.timAnimate.Start()
					Me.tbbRun.Enabled = True
					Me.tbbStop.Enabled = True
					Me.tbbRunPause.BringToFront()
					Application.DoEvents()
				Else
					Me.tbbRun.BringToFront()
					Me.bPlay = False
					Me.bTogglePlay = True
					RSWIN_DESC.bAnimating = False
					Me._optReport_0.Enabled = True
					Me._optReport_1.Enabled = True
					Me._optReport_2.Enabled = True
					Me.cmdIPRPlot.Enabled = True
					Me.btnDevCharts.Enabled = True
					Me.cmdIPRPlot.Enabled = RSWIN_DESC.rst.gbUseIPR
					Me.timAnimate.[Stop]()
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in subroutine: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub tbbStep_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			Me.bForward = True
			Me.bPlay = False
			Me.bTogglePlay = False
			Me.tbbRun.BringToFront()
			Me.StepAutomation()
		End Sub

		Private Sub StepAutomation()
			Try
				Me.TrackBar1.Visible = False
				Me._optReport_0.Enabled = True
				Me._optReport_1.Enabled = True
				Me._optReport_2.Enabled = True
				Me.cmdIPRPlot.Enabled = True
				Me.btnDevCharts.Enabled = True
				Me.cmdIPRPlot.Enabled = RSWIN_DESC.rst.gbUseIPR
				If Not Me.pnlDyno.Visible Then
					Me.pnlDyno.Visible = True
					If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
						Dim chartFX_Dyno As ChartFX.WinForms.Chart = Me.ChartFX_Dyno
						Me.DisplayDyno_Animate(chartFX_Dyno, True, True, True)
						Me.ChartFX_Dyno = chartFX_Dyno
					Else
						Dim chartFX_Dyno As ChartFX.WinForms.Chart = Me.ChartFX_Dyno
						Me.DisplayDyno(chartFX_Dyno, True, True)
						Me.ChartFX_Dyno = chartFX_Dyno
					End If
				End If
				If Me.SurfCircle Is Nothing Then
					Me.InitAnimation()
				End If
				Me.timAnimate.Enabled = False
				Me.timAnimate_Tick(Me.timAnimate, New EventArgs())
				Me.tbbRun.Enabled = True
				Me.tbbStop.Enabled = False
			Catch ex As Exception
				Dim sMsg As String = "Error in subroutine: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub tbbStep_MouseDown(eventSender As Object, eventArgs As MouseEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort((eventArgs.Button / MouseButtons.Left))
			Dim num2 As Short = CShort((Control.ModifierKeys / Keys.Shift))
			Dim num3 As Single = CSng(eventArgs.X)
			Dim num4 As Single = CSng(eventArgs.Y)
			If num <> 1S Or num2 <> 0S Then
				Return
			End If
			If Not RSWIN_DESC.bRodStarD Then
				Me.timAnimate.Interval = 200
			Else
				Me.timAnimate.Interval = 1
			End If
			Me.timAnimate.Enabled = True
		End Sub

		Public Sub SuspendAutomation()
			Try
				Me.timAnimate.Enabled = False
				Me.timAnimate_Tick(Me.timAnimate, New EventArgs())
			Catch ex As Exception
				Dim sMsg As String = "Error in SuspendAnimation: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub tbbStop_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			RSWIN_DESC.bAnimating = False
			Me._optReport_0.Enabled = True
			Me._optReport_1.Enabled = True
			Me._optReport_2.Enabled = True
			Me.cmdIPRPlot.Enabled = True
			Me.btnDevCharts.Enabled = True
			Me.cmdIPRPlot.Enabled = RSWIN_DESC.rst.gbUseIPR
			Me.TrackBar1.Visible = False
			Me.bPlay = False
			Me.bTogglePlay = False
			Me.lblPoint.Text = ""
			Me.tbbRun.BringToFront()
			Try
				If Not Me.pnlDyno.Visible Then
					Me.pnlDyno.Visible = True
					If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
						Dim chartFX_Dyno As ChartFX.WinForms.Chart = Me.ChartFX_Dyno
						Me.DisplayDyno_Animate(chartFX_Dyno, True, True, True)
						Me.ChartFX_Dyno = chartFX_Dyno
					Else
						Dim chartFX_Dyno As ChartFX.WinForms.Chart = Me.ChartFX_Dyno
						Me.DisplayDyno(chartFX_Dyno, True, True)
						Me.ChartFX_Dyno = chartFX_Dyno
					End If
				End If
				If Me.SurfCircle Is Nothing Then
					Me.InitAnimation()
				End If
				Me.timAnimate.[Stop]()
				Me.timAnimate.Enabled = False
				Me.timAnimate_Tick(Me.timAnimate, New EventArgs())
				Me.tbbRun.Enabled = True
				Me.tbbStep.Enabled = True
				Me.TrackBar1.Value = 0
				Me.nSkip = Me.nInitialSkip
			Catch ex As Exception
				Dim sMsg As String = "Error in subroutine: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub timAnimate_Tick(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Application.DoEvents()
				If Me.bForward Then
					If Me.iAnimCurPoint + Me.nSkip > CInt((Me.Animate_Ntsteps - 1S)) Then
						Me.iAnimationCycle += 1
					End If
					Me.iAnimCurPoint = (Me.iAnimCurPoint + Me.nSkip) Mod CInt(Me.Animate_Ntsteps)
					If Me.iAnimCurPoint > CInt((Me.Animate_Ntsteps - 1S)) Then
						Me.iAnimCurPoint = 0
					End If
				Else
					Application.DoEvents()
					If Me.iAnimCurPoint - Me.nSkip < 0 Then
						Me.iAnimationCycle += 1
					End If
					Me.iAnimCurPoint = (Me.iAnimCurPoint - Me.nSkip) Mod CInt(rst.Ntsteps)
					If Me.iAnimCurPoint < 0 Then
						Me.iAnimCurPoint = CInt((rst.Ntsteps - 1S))
					End If
				End If
				If RSWIN_DESC.bRodStarD And Me.iAnimationCycle = 2 Then
					Me.iAnimationCycle = 0
					Me.tbbStop.PerformClick()
				Else
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Me.SurfCircle.Detach()
					Me.PumpCircle.Detach()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Dim num As Single = CtrlUI.ConvertUnits(Me.m_Animate_SurfPos(Me.iAnimCurPoint), 8)
					Dim num2 As Single = CtrlUI.ConvertUnits(Me.m_Animate_SurfLoad(Me.iAnimCurPoint), 12)
					Dim num3 As Single = CtrlUI.ConvertUnits(Me.m_Animate_PumpPos(Me.iAnimCurPoint), 8)
					Dim num4 As Single = CtrlUI.ConvertUnits(Me.m_Animate_PumpLoad(Me.iAnimCurPoint), 12)
					Me.SurfCircle.Attach(CDbl(num), CDbl(num2))
					Me.PumpCircle.Attach(CDbl(num3), CDbl(num4))
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Me.ChartFX_Dyno.Refresh()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Me.ResetClock()
				End If
			Catch ex As Exception
				Application.DoEvents()
			End Try
		End Sub

		Private Sub VScroll_Change(newScrollValue As Integer)
			If Me.$STATIC$VScroll_Change$20118$busy Then
				Return
			End If
			Me.$STATIC$VScroll_Change$20118$busy = True
			Me.picScrollBarTip.Visible = False
			Me.picScrollBarTip.Visible = False
			Me.$STATIC$VScroll_Change$20118$busy = False
		End Sub

		Private Sub VScroll_Scroll(newScrollValue As Integer)
		End Sub

		Private Sub VScroll_Scroll(eventSender As Object, eventArgs As ScrollEventArgs)
			Select Case eventArgs.Type
				Case ScrollEventType.ThumbTrack
					Me.VScroll_Scroll(eventArgs.NewValue)
				Case ScrollEventType.EndScroll
					Me.VScroll_Change(eventArgs.NewValue)
			End Select
		End Sub

		Private Sub _optReport_0_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.optReport_Click_1(0S, True, True)
				Me.iCurrentRptOpt = 0
			Catch ex As Exception
			End Try
		End Sub

		Friend Overridable Property ContextMenu1 As ContextMenu
			Get
				Return Me._ContextMenu1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._ContextMenu1 = value
			End Set
		End Property

		Private Sub _optReport_1_CheckedChanged(sender As Object, e As EventArgs)
			Me.optReport_Click_1(1S, True, True)
			Me.iCurrentRptOpt = 1
		End Sub

		Private Sub _optReport_2_CheckedChanged(sender As Object, e As EventArgs)
			Me.optReport_Click_1(2S, True, True)
			Me.iCurrentRptOpt = 2
		End Sub

		Private Sub _optReport_3_CheckedChanged(sender As Object, e As EventArgs)
			Me.optReport_Click_1(3S, True, True)
			Me.iCurrentRptOpt = 3
		End Sub

		Friend Sub PlotTorqueData(ByRef TorqueChart As ChartFX.WinForms.Chart, bLargeChart As Boolean)
			Dim array As Single(,) = New Single(2, 1) {}
			Dim array2 As Single(,) = New Single(2, 1) {}
			Dim array3 As Single(,)
			Dim array4 As Single(,)
			Dim array5 As Single(,)
			Dim array6 As Single(,)
			Dim axisX As ChartFX.WinForms.Axis
			Dim axisY As ChartFX.WinForms.Axis
			Dim flag As Boolean
			Dim bUpstroke As Boolean
			Dim num As Integer
			Dim ntsteps As Integer
			Dim num2 As Short
			Dim num3 As Single
			Dim num4 As Integer
			Dim num5 As Integer
			Dim num6 As Integer
			Dim flag2 As Boolean
			Dim cRODSTAR As cRODSTAR
			Dim num7 As Single
			Dim num8 As Single
			Dim num9 As Short
			Dim num10 As Short
			Dim num11 As Short
			array3 = New Single(3, CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
			array4 = New Single(3, CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
			array5 = New Single(1, 1) {}
			array6 = New Single(1, 1) {}
			axisX = TorqueChart.AxisX
			axisY = TorqueChart.AxisY
			flag = True
			bUpstroke = True
			If CDbl(RSWIN_DESC.rst.GearboxLoading(0)) >= 0.99 Or RSWIN_DESC.bBalancedEVarsOverwritten Then
				flag = False
			End If
			TorqueChart.Culture = RSWIN_DESC.myCurrentCulture
			num = 8
			ntsteps = CInt(RSWIN_DESC.rst.Ntsteps)
			num2 = CShort(ntsteps)
			num3 = 0F
			num4 = 0
			num5 = 0
			num6 = 0
			flag2 = False
			cRODSTAR = RSWIN_DESC.rst
			If flag Then
				num7 = cRODSTAR.Tnet(0, 1)
				num8 = cRODSTAR.Tnet(0, 1)
			Else
				num7 = cRODSTAR.Tnet(1, 1)
				num8 = cRODSTAR.Tnet(1, 1)
			End If
			num9 = 1S
			num10 = 0S
			num11 = cRODSTAR.Ntsteps - 1S
			For num12 As Short = num10 To num11
				If RSWIN_DESC.rst.PU.UnitType <> 8S Then
					If cRODSTAR.get_M(0) <> cRODSTAR.get_M(1) AndAlso flag Then
						If cRODSTAR.Tnet(0, CInt(num12)) > num7 Then
							num7 = cRODSTAR.Tnet(0, CInt(num12))
						End If
						If cRODSTAR.Tnet(0, CInt(num12)) < num8 Then
							num8 = cRODSTAR.Tnet(0, CInt(num12))
						End If
					End If
				ElseIf cRODSTAR.get_RequiredUnbalance(0) <> cRODSTAR.get_RequiredUnbalance(1) AndAlso flag Then
					If cRODSTAR.Tnet(0, CInt(num12)) > num7 Then
						num7 = cRODSTAR.Tnet(0, CInt(num12))
					End If
					If cRODSTAR.Tnet(0, CInt(num12)) < num8 Then
						num8 = cRODSTAR.Tnet(0, CInt(num12))
					End If
				End If
				If cRODSTAR.Tnet(1, CInt(num12)) > num7 Then
					num7 = cRODSTAR.Tnet(1, CInt(num12))
				End If
				If cRODSTAR.Tnet(1, CInt(num12)) < num8 Then
					num8 = cRODSTAR.Tnet(1, CInt(num12))
				End If
				If Not RSWIN_DESC.rst.UnknownM Then
					If cRODSTAR.Tnet(2, CInt(num12)) > num7 Then
						num7 = cRODSTAR.Tnet(2, CInt(num12))
					End If
					If cRODSTAR.Tnet(2, CInt(num12)) < num8 Then
						num8 = cRODSTAR.Tnet(2, CInt(num12))
					End If
				End If
				If cRODSTAR.Thetac(CInt(num12)) < cRODSTAR.Thetac(CInt(num9)) Then
					num9 = num12
				End If
			Next
			If CDbl(num7) < 1100.0 * CDbl(cRODSTAR.PU.GearboxRating) Then
				num7 = CSng((1100.0 * CDbl(cRODSTAR.PU.GearboxRating)))
			End If
			If CDbl(num8) > -1100.0 * CDbl(cRODSTAR.PU.GearboxRating) Then
				num8 = CSng((-1100.0 * CDbl(cRODSTAR.PU.GearboxRating)))
			End If
			Dim num13 As Single = CtrlUI.ConvertUnits(num8, 10)
			Dim num14 As Single = CtrlUI.ConvertUnits(num7, 10)
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				num13 /= 100F
				num14 /= 100F
			End If
			If num13 > 0F Then
				num13 = 0F
			End If
			If Math.Abs(num14) > Math.Abs(num13) Then
				num13 = -num14
			Else
				num14 = -num13
			End If
			array(0, 0) = 0F
			array(0, 1) = cRODSTAR.TotalTheta
			array2(0, 0) = 1000F * cRODSTAR.PU.GearboxRating
			array2(0, 1) = 1000F * cRODSTAR.PU.GearboxRating
			Dim value As Single = array2(0, 0)
			array(1, 0) = 0F
			array(1, 1) = cRODSTAR.TotalTheta
			array2(1, 0) = 1000F * -cRODSTAR.PU.GearboxRating
			array2(1, 1) = 1000F * -cRODSTAR.PU.GearboxRating
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num15 As Short = 0S
			Dim num16 As Short = 0S
			Dim num17 As Single = rst.TotalTheta / CSng(rst.Ntsteps)
			Dim num18 As Single
			Dim beltLowProfile As Single
			If RSWIN_DESC.rst.PU.UnitType = 9S Then
				num18 = 0F
				beltLowProfile = RSWIN_DESC.BeltLowProfile180
			Else
				kinemat.ThetaFromPrp_Old(0F, True, num18, False)
				kinemat.ThetaFromPrp_Old(rst.PU.KinematicStroke, False, beltLowProfile, False)
			End If
			Dim num19 As Short = 0S
			Dim num20 As Short = rst.Ntsteps - 1S
			Dim num23 As Single
			Dim num24 As Single
			Dim num25 As Single
			Dim num26 As Single
			For num12 As Short = num19 To num20
				Dim num21 As Single = CSng(num12) * num17
				Dim num22 As Single = CSng((num12 + 1S)) * num17
				If num21 < num18 And num18 <= num22 Then
					num16 = (num12 + 1S) Mod rst.Ntsteps
					num23 = num21
					num24 = num22
				ElseIf num21 < beltLowProfile And beltLowProfile <= num22 Then
					num15 = (num12 + 1S) Mod rst.Ntsteps
					num25 = num21
					num26 = num22
				End If
			Next
			Dim text As String
			Dim num27 As Single
			Dim num28 As Single
			If num16 = 0S Then
				bUpstroke = True
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" ", Me.sUpstroke), " "))
				num27 = rst.Thetac(CInt(num9))
				num28 = num25
			ElseIf num15 = 0S Then
				bUpstroke = False
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" ", Me.sDownstroke), " "))
				num27 = rst.Thetac(CInt(num9))
				num28 = num23
			ElseIf num16 < num15 Then
				bUpstroke = True
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" ", Me.sUpstroke), " "))
				num27 = num24
				num28 = num25
			Else
				bUpstroke = False
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" ", Me.sDownstroke), " "))
				num27 = num26
				num28 = num23
			End If
			array5(0, 0) = num27
			array5(0, 1) = num27 + num28
			If Math.Abs(array2(1, 1) - num13 * 1F / 2F) / 1000F < 100F Then
				array6(0, 0) = num13 * 3F / 4F
				array6(0, 1) = array6(0, 0)
			Else
				array6(0, 0) = num13 * 1F / 2F
				array6(0, 1) = array6(0, 0)
			End If
			If Operators.CompareString(text, " Upstroke ", False) = 0 Then
				array5(1, 0) = num27 + num28
				array5(1, 1) = num27 + num28
			Else
				array5(1, 0) = num27
				array5(1, 1) = num27
			End If
			array6(1, 0) = CSng((CDbl((num13 * 2F)) / 2.75))
			array6(1, 1) = num14 / 3F
			Try
				array3(0, num4) = cRODSTAR.Thetac(CInt(num9))
				If cRODSTAR.Thetac(CInt(num9)) > num3 Then
					num3 = cRODSTAR.Thetac(CInt(num9))
				End If
				array4(0, num4) = cRODSTAR.Tnet(2, CInt(num9))
				Dim num29 As Short
				Dim num30 As Short
				num29 = num9 + 1S
				num30 = cRODSTAR.Ntsteps - 1S
				For num12 As Short = num29 To num30
					' The following expression was wrapped in a checked-statement
					num4 += 1
					array3(0, num4) = cRODSTAR.Thetac(CInt(num12))
					If cRODSTAR.Thetac(CInt(num12)) > num3 Then
						num3 = cRODSTAR.Thetac(CInt(num12))
					End If
					array4(0, num4) = cRODSTAR.Tnet(2, CInt(num12))
				Next
				Dim num31 As Short = 0S
				Dim num32 As Short = num9
				For num12 As Short = num31 To num32
					' The following expression was wrapped in a checked-statement
					num4 += 1
					array3(0, num4) = cRODSTAR.Thetac(CInt(num12))
					If cRODSTAR.Thetac(CInt(num12)) > num3 Then
						num3 = cRODSTAR.Thetac(CInt(num12))
					End If
					array4(0, num4) = cRODSTAR.Tnet(2, CInt(num12))
				Next
			Catch ex As Exception
			End Try
			array3(1, num5) = cRODSTAR.Thetac(CInt(num9))
			If cRODSTAR.Thetac(CInt(num9)) > num3 Then
				num3 = cRODSTAR.Thetac(CInt(num9))
			End If
			array4(1, num5) = cRODSTAR.Tnet(1, CInt(num9))
			Dim num33 As Short
			Dim num34 As Short
			num33 = num9 + 1S
			num34 = cRODSTAR.Ntsteps - 1S
			For num12 As Short = num33 To num34
				' The following expression was wrapped in a checked-statement
				num5 += 1
				array3(1, num5) = cRODSTAR.Thetac(CInt(num12))
				If cRODSTAR.Thetac(CInt(num12)) > num3 Then
					num3 = cRODSTAR.Thetac(CInt(num12))
				End If
				array4(1, num5) = cRODSTAR.Tnet(1, CInt(num12))
			Next
			Dim num35 As Short = 0S
			Dim num36 As Short = num9
			For num12 As Short = num35 To num36
				' The following expression was wrapped in a checked-statement
				num5 += 1
				array3(1, num5) = cRODSTAR.Thetac(CInt(num12))
				array4(1, num5) = cRODSTAR.Tnet(1, CInt(num12))
			Next
			If((RSWIN_DESC.rst.PU.UnitType <> 8S And cRODSTAR.get_M(0) <> cRODSTAR.get_M(1) And cRODSTAR.get_M(0) <> cRODSTAR.get_M(2)) AndAlso flag) Or ((RSWIN_DESC.rst.PU.UnitType = 8S And cRODSTAR.get_RequiredUnbalance(0) <> cRODSTAR.get_RequiredUnbalance(1) And cRODSTAR.get_RequiredUnbalance(0) <> cRODSTAR.get_RequiredUnbalance(2)) AndAlso flag) Then
				flag2 = True
				array3(2, num6) = cRODSTAR.Thetac(CInt(num9))
				array4(2, num6) = cRODSTAR.Tnet(0, CInt(num9))
				Dim num37 As Short
				Dim num38 As Short
				num37 = num9 + 1S
				num38 = cRODSTAR.Ntsteps - 1S
				For num12 As Short = num37 To num38
					' The following expression was wrapped in a checked-statement
					num6 += 1
					array3(2, num6) = cRODSTAR.Thetac(CInt(num12))
					array4(2, num6) = cRODSTAR.Tnet(0, CInt(num12))
				Next
				Dim num39 As Short = 0S
				Dim num40 As Short = num9
				For num12 As Short = num39 To num40
					' The following expression was wrapped in a checked-statement
					num6 += 1
					array3(2, num6) = cRODSTAR.Thetac(CInt(num12))
					array4(2, num6) = cRODSTAR.Tnet(0, CInt(num12))
				Next
			End If
			cRODSTAR = Nothing
			Dim chart As ChartFX.WinForms.Chart = TorqueChart
			chart.Data.Clear()
			chart.LegendBox.Visible = True
			Dim legendItemAttributes As LegendItemAttributes = New LegendItemAttributes()
			legendItemAttributes.Visible = False
			chart.LegendBox.ItemAttributes(chart.Series) = legendItemAttributes
			chart.LegendBox.CustomItems.Clear()
			Dim titleDockable As TitleDockable = chart.Titles(0)
			titleDockable.Alignment = StringAlignment.Center
			If bLargeChart Then
				titleDockable.Font = New Font("Arial", 12F, FontStyle.Bold)
			Else
				titleDockable.Font = New Font("Aria1", 10F, FontStyle.Bold)
			End If
			titleDockable.Text = Conversions.ToString(Me.sGearboxTorquePlots)
			titleDockable.TextColor = Color.Black
			Dim num41 As Integer = -1
			chart.LegendBox.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0)
			If(Not RSWIN_DESC.rst.UnknownM And RSWIN_DESC.rst.PU.UnitType <> 8S) Or (Not RSWIN_DESC.rst.bUnknownUnbalance And RSWIN_DESC.rst.PU.UnitType = 8S) Then
				Dim text2 As String
				If bLargeChart Then
					text2 = Conversions.ToString(Me.sExisting)
				Else
					text2 = Conversions.ToString(Me.sExisting)
				End If
				If((RSWIN_DESC.rst.PU.UnitType <> 8S And RSWIN_DESC.rst.get_M(0) = RSWIN_DESC.rst.get_M(2)) Or (RSWIN_DESC.rst.PU.UnitType = 8S And RSWIN_DESC.rst.get_RequiredUnbalance(0) = RSWIN_DESC.rst.get_RequiredUnbalance(2))) AndAlso bLargeChart Then
					text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text2 + " (", Me.sOverlapsMinEnergy), ")"))
				End If
				num41 += 1
				Dim customLegendItem As CustomLegendItem = New CustomLegendItem()
				customLegendItem.Text = text2
				customLegendItem.Color = Color.Blue
				customLegendItem.MarkerShape = MarkerShape.HorizontalLine
				customLegendItem.Border.Effect = BorderEffect.None
				chart.LegendBox.CustomItems.Add(customLegendItem)
			End If
			If(RSWIN_DESC.rst.PU.UnitType <> 8S And RSWIN_DESC.rst.get_M(1) = RSWIN_DESC.rst.get_M(0)) Or (RSWIN_DESC.rst.PU.UnitType = 8S And RSWIN_DESC.rst.get_RequiredUnbalance(1) = RSWIN_DESC.rst.get_RequiredUnbalance(0)) Or Not flag Then
				num41 += 1
				Dim customLegendItem2 As CustomLegendItem = New CustomLegendItem()
				customLegendItem2.Text = Conversions.ToString(Me.sBalanced)
				customLegendItem2.Color = Color.Red
				customLegendItem2.MarkerShape = MarkerShape.HorizontalLine
				customLegendItem2.Border.Effect = BorderEffect.None
				chart.LegendBox.CustomItems.Add(customLegendItem2)
			Else
				num41 += 1
				Dim customLegendItem3 As CustomLegendItem = New CustomLegendItem()
				If bLargeChart Then
					customLegendItem3.Text = Conversions.ToString(Me.sBalMinTorque)
				Else
					customLegendItem3.Text = "Bal.Torque"
				End If
				customLegendItem3.Color = Color.Red
				customLegendItem3.MarkerShape = MarkerShape.HorizontalLine
				customLegendItem3.Border.Effect = BorderEffect.None
				chart.LegendBox.CustomItems.Add(customLegendItem3)
				num41 += 1
				Dim customLegendItem4 As CustomLegendItem = New CustomLegendItem()
				If bLargeChart Then
					customLegendItem4.Text = Conversions.ToString(Me.sBalMinEnergy)
				Else
					customLegendItem4.Text = "Bal.Energy"
				End If
				customLegendItem4.Color = Color.Green
				customLegendItem4.MarkerShape = MarkerShape.HorizontalLine
				customLegendItem4.Border.Effect = BorderEffect.None
				chart.LegendBox.CustomItems.Add(customLegendItem4)
			End If
			If bLargeChart Then
				chart.LegendBox.Border = DockBorder.External
				chart.LegendBox.Dock = DockArea.Bottom
				chart.LegendBox.Style = LegendBoxStyles.Wordbreak
				chart.LegendBox.ResetBackColor()
				chart.LegendBox.BackColor = Color.Transparent
				chart.LegendBox.Visible = True
			Else
				chart.LegendBox.Visible = False
			End If
			chart.Refresh()
			axisX.Title.Text = ""
			axisX.Title.Text = Conversions.ToString(Me.sCrankHoleDegrees)
			axisX.Title.Alignment = StringAlignment.Center
			axisX.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			axisY.Title.Text = Conversions.ToString(Operators.AddObject("Net Torque ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, "(N-m)", "(M in-lbs)")))
			axisY.Title.Alignment = StringAlignment.Center
			axisY.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			axisX.Max = 375.0
			axisX.Min = 0.0
			If RSWIN_DESC.SETUP_MeasurementSystem <> 3 Then
				axisY.Min = CDbl(((num13 - 10000F) / 1000F))
				axisY.Max = CDbl(((num14 + 10000F) / 1000F))
			Else
				axisY.Min = CDbl(num13) * 0.125
				axisY.Max = CDbl(num14) * 0.125
			End If
			Dim num42 As Single = 360F / num3
			chart.Refresh()
			Dim num43 As Short
			Dim num44 As Short
			If(RSWIN_DESC.rst.UnknownM And RSWIN_DESC.rst.PU.UnitType <> 8S) Or (RSWIN_DESC.rst.bUnknownUnbalance And RSWIN_DESC.rst.PU.UnitType = 8S) Then
				num -= 1
			End If
			chart.Data.Series = num
			chart.Data.Points = ntsteps
			chart.Series(0).Color = Color.Blue
			chart.Series(1).Color = Color.Red
			chart.Series(2).Color = Color.Green
			chart.Series(3).Color = Color.Green
			chart.Series(4).Color = Color.Green
			chart.Series(5).Color = Color.Gray
			chart.Series(6).Color = Color.Gray
			chart.Series(0).Line.Style = DashStyle.Solid
			chart.Series(1).Line.Style = DashStyle.Solid
			chart.Series(2).Line.Style = DashStyle.Solid
			chart.Series(3).Line.Style = DashStyle.DashDot
			chart.Series(4).Line.Style = DashStyle.DashDot
			chart.Series(5).Line.Style = DashStyle.DashDot
			chart.Series(6).Line.Style = DashStyle.DashDot
			num43 = 0S
			num44 = CShort((num - 1))
			For num12 As Short = num43 To num44
				Dim num45 As Short = 0S
				Dim num46 As Short = CShort((ntsteps - 1))
				Dim num47 As Short
				num47 = num45
				While num47 <= num46
					Dim flag3 As Boolean
					Dim num48 As Single
					Dim num49 As Single
					Select Case num12
						Case 0S
							If(Not RSWIN_DESC.rst.UnknownM And RSWIN_DESC.rst.PU.UnitType <> 8S) Or (Not RSWIN_DESC.rst.bUnknownUnbalance And RSWIN_DESC.rst.PU.UnitType = 8S) Then
								flag3 = True
								num48 = CtrlUI.ConvertUnits(array4(CInt(num12), CInt(num47)), 10) / 1000F
								num49 = num42 * array3(CInt(num12), CInt(num47))
							Else
								flag3 = False
							End If
						Case 1S
							flag3 = True
							num48 = CtrlUI.ConvertUnits(array4(CInt(num12), CInt(num47)), 10) / 1000F
							num49 = num42 * array3(CInt(num12), CInt(num47))
						Case 2S
							If flag2 Then
								flag3 = True
								num48 = CtrlUI.ConvertUnits(array4(CInt(num12), CInt(num47)), 10) / 1000F
								num49 = num42 * array3(CInt(num12), CInt(num47))
							Else
								flag3 = False
								chart.Data.Y(CInt(num12), CInt(num47)) = 1E+108
							End If
						Case 3S, 4S
							If num47 < 2S Then
								flag3 = True
								num48 = CtrlUI.ConvertUnits(array2(CInt((num12 - 3S)), CInt(num47)), 10) / 1000F
								num49 = num42 * array(CInt((num12 - 3S)), CInt(num47))
							Else
								flag3 = False
								chart.Data.Y(CInt(num12), CInt(num47)) = 1E+108
							End If
						Case 5S, 6S
							If num47 < 2S Then
								flag3 = True
								num48 = CtrlUI.ConvertUnits(array6(CInt((num12 - 5S)), CInt(num47)), 10) / 1000F
								num49 = num42 * array5(CInt((num12 - 5S)), CInt(num47))
							Else
								flag3 = False
								chart.Data.Y(CInt(num12), CInt(num47)) = 1E+108
							End If
					End Select
					If flag3 Then
						chart.Data.X(CInt(num12), CInt(num47)) = CDbl(num49)
						chart.Data.Y(CInt(num12), CInt(num47)) = CDbl(num48)
					End If
					num47 += 1S
				End While
				Dim num50 As Short
				Dim num51 As Short
				num50 = num47 + 1S
				num51 = num2 - 1S
				For num52 As Short = num50 To num51
					chart.Data.Y(CInt(num12), CInt(num47)) = 1E+108
				Next
			Next
			If(RSWIN_DESC.rst.UnknownM And RSWIN_DESC.rst.PU.UnitType <> 8S) Or (RSWIN_DESC.rst.bUnknownUnbalance And RSWIN_DESC.rst.PU.UnitType = 8S) Then
				chart.Series(0).Visible = False
			End If
			If Not flag Then
				chart.Series(2).Visible = False
			End If
			Me.DisplayTorqueAnnotations(TorqueChart, text, num42 * (num27 + num28) / 2F, array6(0, 0), CtrlUI.ConvertUnits(value, 10), num42 * num28, bLargeChart, bUpstroke)
			If TorqueChart.LegendBox.Height > 0 Then
				RSWIN_DESC.fTorqueLegendFactor = CSng((1.4252 * CDbl(TorqueChart.LegendBox.Height) / CDbl(TorqueChart.Height)))
			Else
				RSWIN_DESC.fTorqueLegendFactor = 0F
			End If
			TorqueChart.Width = CInt(Math.Round(CDbl(TorqueChart.Height) * (1.4252 - CDbl(RSWIN_DESC.fTorqueLegendFactor))))
			Me.Refresh()
		End Sub

		Public Sub DisplayDyno(ByRef DynoChart As ChartFX.WinForms.Chart, bLargeChart As Boolean, Optional bMainChart As Boolean = False)
			' The following expression was wrapped in a checked-statement
			Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
			Dim array2 As Single() = New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
			Dim array3 As Single() = New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
			Dim array4 As Single() = New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
			Dim axisX As ChartFX.WinForms.Axis = DynoChart.AxisX
			Dim axisY As ChartFX.WinForms.Axis = DynoChart.AxisY
			Try
				Me.Animate_Ntsteps = RSWIN_DESC.rst.Ntsteps
				Me.m_Animate_SurfPos = New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
				Me.m_Animate_SurfLoad = New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
				Me.m_Animate_PumpPos = New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
				Me.m_Animate_PumpLoad = New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
				Dim num As Short = 0S
				Dim num2 As Short = RSWIN_DESC.rst.Ntsteps - 1S
				Dim num4 As Integer
				Dim num5 As Integer
				Dim flag As Boolean
				Dim num6 As Short
				Dim num13 As Single
				Dim num15 As Single
				Dim num18 As Single
				Dim rst2 As cRODSTAR

					For num3 As Short = num To num2
						Me.m_Animate_SurfPos(CInt(num3)) = RSWIN_DESC.rst.SurfPos(CInt(num3))
						Me.m_Animate_SurfLoad(CInt(num3)) = RSWIN_DESC.rst.SurfLoad(CInt(num3))
						Me.m_Animate_PumpPos(CInt(num3)) = RSWIN_DESC.rst.PumpPos(CInt(num3))
						Me.m_Animate_PumpLoad(CInt(num3)) = RSWIN_DESC.rst.PumpLoad(CInt(num3))
					Next
					DynoChart.Culture = RSWIN_DESC.myCurrentCulture
					num4 = CInt(RSWIN_DESC.rst.Ntsteps)
					Me.Animate_Ntsteps = RSWIN_DESC.rst.Ntsteps
					Dim num7 As Single
					Dim num8 As Single
					Dim num9 As Single
					Dim num10 As Single
					Dim num11 As Single
					Dim num12 As Single
					If(RSWIN_DESC.SETUP_PrintDynoActual And If((-If((RSWIN_DESC.rst.RDNtsteps > 0S > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						num5 = 5
						flag = True
						If num4 > CInt(RSWIN_DESC.rst.RDNtsteps) Then
							' The following expression was wrapped in a checked-expression
							num6 = CShort(num4)
						Else
							num6 = RSWIN_DESC.rst.RDNtsteps
							num4 = CInt(num6)
						End If
						Dim rdsurfPos As Single() = RSWIN_DESC.rst.RDSurfPos
						num7 = 0F
						num8 = 0F
						Util.Maxmin(rdsurfPos, num9, num10, num7, num8)
						Dim rdsurfLoad As Single() = RSWIN_DESC.rst.RDSurfLoad
						num8 = 0F
						num7 = 0F
						Util.Maxmin(rdsurfLoad, num11, num12, num8, num7)
						num11 = CtrlUI.ConvertUnits(num11, 12)
						num12 = CtrlUI.ConvertUnits(num12, 12)
						num9 = CtrlUI.ConvertUnits(num9, 8)
						num10 = CtrlUI.ConvertUnits(num10, 8)
					Else
						num5 = 4
						flag = False
						num6 = CShort(num4)
					End If
					Dim surfPos As Single() = RSWIN_DESC.rst.SurfPos
					num8 = 0F
					num7 = 0F
					Dim num14 As Single
					Util.Maxmin(surfPos, num13, num14, num8, num7)
					If num14 < 0F Then
						num14 = 0F
					End If
					num13 = CtrlUI.ConvertUnits(num13, 8)
					num14 = CtrlUI.ConvertUnits(num14, 8)
					Dim surfLoad As Single() = RSWIN_DESC.rst.SurfLoad
					num8 = 0F
					num7 = 0F
					Dim num16 As Single
					Util.Maxmin(surfLoad, num15, num16, num8, num7)
					num15 = CtrlUI.ConvertUnits(num15, 12)
					num16 = CtrlUI.ConvertUnits(num16, 12)
					Dim pumpLoad As Single() = RSWIN_DESC.rst.PumpLoad
					num8 = 0F
					num7 = 0F
					Dim num17 As Single
					Util.Maxmin(pumpLoad, num17, num18, num8, num7)
					num17 = CtrlUI.ConvertUnits(num17, 12)
					num18 = CtrlUI.ConvertUnits(num18, 12)
					Dim pumpPos As Single() = RSWIN_DESC.rst.PumpPos
					num8 = 0F
					num7 = 0F
					Dim num19 As Single
					Dim num20 As Single
					Util.Maxmin(pumpPos, num19, num20, num8, num7)
					num19 = CtrlUI.ConvertUnits(num19, 8)
					num20 = CtrlUI.ConvertUnits(num20, 8)
					If flag Then
						If num15 < num11 Then
							num15 = num11
						End If
						If num16 > num12 Then
							num16 = num12
						End If
						If num13 < num9 Then
							num13 = num9
						End If
						If num14 > num10 Then
							num14 = num10
						End If
					End If
					If num19 > num13 Then
						num13 = num19
					End If
					If num20 < num14 Then
						num14 = num20
					End If
					Dim num21 As Single = CSng((CDbl(num20) - 0.1 * CDbl((num19 - num20))))
					If num21 < num14 Then
						num21 = num14
					End If
					Dim num22 As Single = CSng((CDbl(num19) + 0.1 * CDbl((num19 - num20))))
					If num22 > num13 Then
						num22 = num13
					End If
					num21 = CtrlUI.ConvertUnits(num21, 8)
					num22 = CtrlUI.ConvertUnits(num22, 8)
					If num17 > num15 Then
						num15 = num17
					End If
					If num18 < num16 Then
						num16 = num18
					End If
					num15 = CSng((CDbl(num15) * 1.2))
					Dim num23 As Single = CSng((CDbl(num18) - 0.1 * CDbl((num17 - num18))))
					If num23 < num16 Then
						num23 = num16
					End If
					Dim num24 As Single = CSng((CDbl(num17) + 0.1 * CDbl((num17 - num18))))
					If num24 > num15 Then
						num24 = num15
					End If
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Me.SetLinesX(3, 0) = num21
					Me.SetLinesX(3, 1) = num22
					Me.SetLinesY(3, 0) = CtrlUI.ConvertUnits(rst.LineSettings(3).Value, 12)
					Me.SetLinesY(3, 1) = CtrlUI.ConvertUnits(rst.LineSettings(3).Value, 12)
					Me.SetLinesX(4, 0) = num21
					Me.SetLinesX(4, 1) = num22
					Me.SetLinesY(4, 0) = CtrlUI.ConvertUnits(rst.LineSettings(4).Value, 12)
					Me.SetLinesY(4, 1) = CtrlUI.ConvertUnits(rst.LineSettings(4).Value, 12)
					Me.SetLinesX(1, 0) = CtrlUI.ConvertUnits(rst.LineSettings(1).Value, 8)
					Me.SetLinesX(1, 1) = CtrlUI.ConvertUnits(rst.LineSettings(1).Value, 8)
					Me.SetLinesY(1, 0) = num23
					Me.SetLinesY(1, 1) = num24
					Me.SetLinesX(2, 0) = CtrlUI.ConvertUnits(rst.LineSettings(2).Value, 8)
					Me.SetLinesX(2, 1) = CtrlUI.ConvertUnits(rst.LineSettings(2).Value, 8)
					Me.SetLinesY(2, 0) = num23
					Me.SetLinesY(2, 1) = num24
					rst2 = RSWIN_DESC.rst
					Dim num25 As Short = 0S
					Dim num26 As Short = rst2.NtstepsUpstroke - 1S
					For num3 As Short = num25 To num26
						array(CInt(num3)) = CtrlUI.ConvertUnits(rst2.PermLoad(CInt(num3)), 12)
						array3(CInt(num3)) = CtrlUI.ConvertUnits(rst2.SurfPos(CInt(num3)), 8)
					Next

				Dim num27 As Integer = CInt((rst2.NtstepsUpstroke - 1S))
				Dim ntstepsUpstroke As Short = rst2.NtstepsUpstroke
				Dim num28 As Short = rst2.Ntsteps - 1S
				Dim num29 As Integer
				Dim chart As ChartFX.WinForms.Chart

					For num3 As Short = ntstepsUpstroke To num28
						array2(CInt(num3)) = CtrlUI.ConvertUnits(rst2.PermLoad(CInt(num3)), 12)
						array4(CInt(num3)) = CtrlUI.ConvertUnits(rst2.SurfPos(CInt(num3)), 8)
					Next
					num29 = CInt((rst2.Ntsteps - rst2.NtstepsUpstroke))
					chart = DynoChart
					chart.Data.Clear()
					chart.LegendBox.Visible = True
					Dim legendItemAttributes As LegendItemAttributes = New LegendItemAttributes()
					legendItemAttributes.Visible = False
					chart.LegendBox.ItemAttributes(chart.Series) = legendItemAttributes
					chart.LegendBox.CustomItems.Clear()
					Dim titleDockable As TitleDockable = chart.Titles(0)
					titleDockable.Alignment = StringAlignment.Center
					If bLargeChart Then
						titleDockable.Font = New Font("Arial", 12F, FontStyle.Bold)
					Else
						titleDockable.Font = New Font("Arial", 10F, FontStyle.Bold)
					End If
					titleDockable.Text = Conversions.ToString(Me.sDynamometerCards)
					titleDockable.TextColor = Color.Black

				If bLargeChart Then
					Dim num30 As Integer = -1
					num30 += 1
					Dim customLegendItem As CustomLegendItem = New CustomLegendItem()
					customLegendItem.Text = Conversions.ToString(Me.sSurfaceCard)
					customLegendItem.Color = Color.Blue
					customLegendItem.MarkerShape = MarkerShape.HorizontalLine
					customLegendItem.Border.Effect = BorderEffect.None
					chart.LegendBox.CustomItems.Add(customLegendItem)
					num30 += 1
					Dim customLegendItem2 As CustomLegendItem = New CustomLegendItem()
					customLegendItem2.Text = Conversions.ToString(Me.sDownholeCard)
					customLegendItem2.Color = Color.DarkGreen
					customLegendItem2.MarkerShape = MarkerShape.HorizontalLine
					customLegendItem2.Border.Effect = BorderEffect.None
					chart.LegendBox.CustomItems.Add(customLegendItem2)
					num30 += 1
					Dim customLegendItem3 As CustomLegendItem = New CustomLegendItem()
					customLegendItem3.Text = Conversions.ToString(Me.sPermissibleLoadDiagram)
					customLegendItem3.Color = Color.Red
					customLegendItem3.MarkerShape = MarkerShape.HorizontalLine
					customLegendItem3.Border.Effect = BorderEffect.None
					chart.LegendBox.CustomItems.Add(customLegendItem3)
					If flag Then
						num30 += 1
						Dim customLegendItem4 As CustomLegendItem = New CustomLegendItem()
						customLegendItem4.Text = Conversions.ToString(Me.sMeasuredCard)
						customLegendItem4.Color = Color.Gray
						customLegendItem4.MarkerShape = MarkerShape.HorizontalLine
						customLegendItem4.Border.Effect = BorderEffect.None
						chart.LegendBox.CustomItems.Add(customLegendItem4)
					End If
					chart.LegendBox.Border = DockBorder.External
					chart.LegendBox.Dock = DockArea.Bottom
					chart.LegendBox.Style = LegendBoxStyles.Wordbreak
					chart.LegendBox.ResetBackColor()
					chart.LegendBox.BackColor = Color.Transparent
					chart.LegendBox.Visible = True
					chart.Refresh()
				Else
					chart.LegendBox.Visible = False
				End If
				axisX.Title.Text = Conversions.ToString(Operators.ConcatenateObject(Me.sPosition, Operators.AddObject(Operators.AddObject(" (", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, RSWIN_DESC.cm, RSWIN_DESC.inches)), ")")))
				axisX.Title.Alignment = StringAlignment.Center
				axisX.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
				axisY.Title.Text = Conversions.ToString(Operators.ConcatenateObject(Me.sLoad, Operators.AddObject(" ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, "(" + Conversions.ToString(CInt(num6)) + ")", "(" + RSWIN_DESC.lbs + ")"))))
				axisY.Title.Alignment = StringAlignment.Center
				axisY.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
				axisY.Max = CDbl(num15)

					axisY.Min = CDbl((num18 - 250F))
					axisX.Max = CDbl(num13) + CDbl(num13) * 0.15
					axisX.Min = 0.0
					chart.Refresh()
					chart.Data.Series = num5
					chart.Data.Points = num4
					chart.Series(0).Color = Color.Blue
					chart.Series(1).Color = Color.DarkGreen
					chart.Series(2).Color = Color.Red
					chart.Series(3).Color = Color.Red
					If flag Then
						chart.Series(4).Color = Color.Gray
					End If
					chart.Series(0).Line.Width = 2S
					chart.Series(1).Line.Width = 2S
					chart.Series(2).Line.Width = 1S
					chart.Series(3).Line.Width = 1S
					If flag And num5 >= 5 Then
						chart.Series(4).Line.Width = 1S
					End If
					Try
						Dim num31 As Short = 0S
						Dim num32 As Short = CShort((num5 - 1))
						For num3 As Short = num31 To num32
							Dim num33 As Short = 0S
							Dim num34 As Short = CShort((num4 - 1))
							Dim num35 As Short
							num35 = num33
							While num35 <= num34
								' The following expression was wrapped in a checked-statement
								Dim num36 As Single
								Dim num37 As Single
								Select Case num3
									Case 0S
										If num35 <= RSWIN_DESC.rst.Ntsteps - 1S Then
											num36 = CtrlUI.ConvertUnits(RSWIN_DESC.rst.SurfLoad(CInt(num35)), 12)
											num37 = CtrlUI.ConvertUnits(RSWIN_DESC.rst.SurfPos(CInt(num35)), 8)
											Debug.WriteLine(String.Concat(New String() { num35.ToString(), " , ", num37.ToString(), " , ", num36.ToString() }))
										End If
									Case 1S
										If num35 <= RSWIN_DESC.rst.Ntsteps - 1S Then
											num36 = CtrlUI.ConvertUnits(RSWIN_DESC.rst.PumpLoad(CInt(num35)), 12)
											num37 = CtrlUI.ConvertUnits(RSWIN_DESC.rst.PumpPos(CInt(num35)), 8)
										End If
									Case 2S
										If num35 <= RSWIN_DESC.rst.Ntsteps - 1S Then
											num36 = array(CInt(num35))
											num37 = array3(CInt(num35))
										End If
									Case 3S
										If num35 <= RSWIN_DESC.rst.Ntsteps - 1S Then
											num36 = array2(CInt(num35))
											num37 = array4(CInt(num35))
										End If
									Case 4S
										If num35 <= RSWIN_DESC.rst.RDNtsteps - 1S Then
											num36 = CtrlUI.ConvertUnits(RSWIN_DESC.rst.RDSurfLoad(CInt(num35)), 12)
											num37 = CtrlUI.ConvertUnits(RSWIN_DESC.rst.RDSurfPos(CInt(num35)), 8)
										End If
								End Select
								If num3 = 0S Or num3 = 1S Then
									If num35 <= RSWIN_DESC.rst.Ntsteps - 1S Then
										chart.Data.X(CInt(num3), CInt(num35)) = CDbl(num37)
										chart.Data.Y(CInt(num3), CInt(num35)) = CDbl(num36)
									Else
										chart.Data.Y(CInt(num3), CInt(num35)) = 1E+108
									End If
								ElseIf num3 = 2S Then
									If num35 <= RSWIN_DESC.rst.Ntsteps - 1S And CDbl(num36) <= axisY.Max And num36 > 0F And num37 <> 0F Then
										chart.Data.X(CInt(num3), CInt(num35)) = CDbl(num37)
										chart.Data.Y(CInt(num3), CInt(num35)) = CDbl(num36)
									Else
										chart.Data.Y(CInt(num3), CInt(num35)) = 1E+108
									End If
								ElseIf num3 = 3S Then
									If num35 <= RSWIN_DESC.rst.Ntsteps - 1S And num36 > num18 Then
										If CDbl(num37) < 0.1 And num36 = 0F Then
											chart.Data.Y(CInt(num3), CInt(num35)) = 1E+108
										Else
											chart.Data.X(CInt(num3), CInt(num35)) = CDbl(num37)
											chart.Data.Y(CInt(num3), CInt(num35)) = CDbl(num36)
										End If
									Else
										chart.Data.Y(CInt(num3), CInt(num35)) = 1E+108
									End If
								ElseIf num3 = 4S Then
									If num35 <= RSWIN_DESC.rst.RDNtsteps - 1S Then
										chart.Data.X(CInt(num3), CInt(num35)) = CDbl(num37)
										chart.Data.Y(CInt(num3), CInt(num35)) = CDbl(num36)
									Else
										chart.Data.Y(CInt(num3), CInt(num35)) = 1E+108
									End If
								Else
									chart.Data.Y(CInt(num3), CInt(num35)) = 1E+108
								End If
								num35 += 1S
							End While
							If num3 = 0S Then
								chart.Data.Y(CInt(num3), CInt((RSWIN_DESC.rst.Ntsteps - 1S))) = CDbl(CtrlUI.ConvertUnits(RSWIN_DESC.rst.SurfLoad(0), 12))
								chart.Data.X(CInt(num3), CInt((RSWIN_DESC.rst.Ntsteps - 1S))) = CDbl(CtrlUI.ConvertUnits(RSWIN_DESC.rst.SurfPos(0), 8))
							ElseIf num3 = 1S Then
								chart.Data.Y(CInt(num3), CInt((RSWIN_DESC.rst.Ntsteps - 1S))) = CDbl(CtrlUI.ConvertUnits(RSWIN_DESC.rst.PumpLoad(0), 12))
								chart.Data.X(CInt(num3), CInt((RSWIN_DESC.rst.Ntsteps - 1S))) = CDbl(CtrlUI.ConvertUnits(RSWIN_DESC.rst.PumpPos(0), 8))
							End If
							Select Case num3
								Case 0S, 1S
									Dim ntsteps As Short = RSWIN_DESC.rst.Ntsteps
									Dim num38 As Short = num6
									For num39 As Short = ntsteps To num38
										chart.Data.Y(CInt(num3), CInt(num35)) = 1E+108
									Next
								Case 2S
									' The following expression was wrapped in a checked-expression
									Dim num40 As Short = CShort((num27 + 1))
									Dim num41 As Short = num6
									For num39 As Short = num40 To num41
										chart.Data.Y(CInt(num3), CInt(num35)) = 1E+108
									Next
								Case 3S
									' The following expression was wrapped in a checked-expression
									Dim num42 As Short = CShort((num29 + 1))
									Dim num43 As Short = num6
									For num39 As Short = num42 To num43
										chart.Data.Y(CInt(num3), CInt(num35)) = 1E+108
									Next
								Case 4S
									Dim rdntsteps As Short = RSWIN_DESC.rst.RDNtsteps
									Dim num44 As Short = num6
									For num39 As Short = rdntsteps To num44
										chart.Data.Y(CInt(num3), CInt(num35)) = 1E+108
									Next
							End Select
						Next
					Catch ex As Exception
					End Try

				If Not bLargeChart Then
					' The following expression was wrapped in a unchecked-expression
					DynoChart.Width = CInt(Math.Round(CDbl(DynoChart.Height) * 1.4252))
				Else
					' The following expression was wrapped in a unchecked-expression
					RSWIN_DESC.fDynoLegendFactor = CSng((1.4252 * CDbl(DynoChart.LegendBox.Height) / CDbl(DynoChart.Height)))
					If Not bMainChart Then
						' The following expression was wrapped in a unchecked-expression
						DynoChart.Width = CInt(Math.Round(CDbl(DynoChart.Height) * (1.4252 - CDbl(RSWIN_DESC.fDynoLegendFactor))))
					ElseIf bMainChart Then
						' The following expression was wrapped in a unchecked-expression
						DynoChart.Width = CInt(Math.Round(CDbl(DynoChart.Height) * (1.4252 - CDbl(RSWIN_DESC.fDynoLegendFactor))))
						Me.CenterChartInPanel(Me.pnlDyno, DynoChart)
					End If
				End If
				Me.Refresh()
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub DisplayDyno_Animate(ByRef DynoChart As ChartFX.WinForms.Chart, bLargeChart As Boolean, Optional bMainChart As Boolean = False, Optional bAnimate As Boolean = False)
			Dim axisX As ChartFX.WinForms.Axis = DynoChart.AxisX
			Dim axisY As ChartFX.WinForms.Axis = DynoChart.AxisY
			Me.m_iStep = 0
			Try
				DynoChart.Culture = RSWIN_DESC.myCurrentCulture
				If bAnimate And RSWIN_DESC.rst.Ntsteps > 500S Then
					Me.iStep = CInt(Math.Round(Conversion.Int(CDbl(RSWIN_DESC.rst.Ntsteps) / 500.0)))
				ElseIf Not bAnimate And RSWIN_DESC.rst.Ntsteps > 350S Then
					Me.iStep = CInt(Math.Round(Conversion.Int(CDbl(RSWIN_DESC.rst.Ntsteps) / 350.0)))
				Else
					Me.iStep = 1
				End If
				Me.Animate_Ntsteps = 0S
				Me.m_Animate_SurfPos = New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
				Me.m_Animate_SurfLoad = New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
				Me.m_Animate_PumpPos = New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
				Me.m_Animate_PumpLoad = New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
				Me.m_Animate_SurfPos(0) = RSWIN_DESC.rst.SurfPos(0)
				Me.m_Animate_SurfLoad(0) = RSWIN_DESC.rst.SurfLoad(0)
				Me.m_Animate_PumpPos(0) = RSWIN_DESC.rst.PumpPos(0)
				Me.m_Animate_PumpLoad(0) = RSWIN_DESC.rst.PumpLoad(0)
				Dim num As Integer = Me.iStep - 1
				Dim num2 As Integer = -1
				Dim num3 As Short = 0S
				Dim num4 As Short = RSWIN_DESC.rst.Ntsteps - 1S
				Dim num5 As Short = CShort(Me.iStep)
				Dim num6 As Short = num4
				Dim num7 As Short = num3
				While (num5 >> 15 Xor CInt(num7)) <= (num5 >> 15 Xor CInt(num6))
					num2 += 1
					Me.m_Animate_SurfPos(num2) = RSWIN_DESC.rst.SurfPos(CInt(num7))
					Me.m_Animate_SurfLoad(num2) = RSWIN_DESC.rst.SurfLoad(CInt(num7))
					Me.m_Animate_PumpPos(num2) = RSWIN_DESC.rst.PumpPos(CInt(num7))
					Me.m_Animate_PumpLoad(num2) = RSWIN_DESC.rst.PumpLoad(CInt(num7))

						num7 += num5

				End While
				Me.Animate_Ntsteps = CShort((num2 + 1))
				Me.m_Animate_SurfPos = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(Me.m_Animate_SurfPos, Array), New Single(CInt((Me.m_Animate_Ntsteps + 1S)) - 1) {}), Single())
				Me.m_Animate_SurfLoad = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(Me.m_Animate_SurfLoad, Array), New Single(CInt((Me.m_Animate_Ntsteps + 1S)) - 1) {}), Single())
				Me.m_Animate_PumpPos = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(Me.m_Animate_PumpPos, Array), New Single(CInt((Me.m_Animate_Ntsteps + 1S)) - 1) {}), Single())
				Me.m_Animate_PumpLoad = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(Me.m_Animate_PumpLoad, Array), New Single(CInt((Me.m_Animate_Ntsteps + 1S)) - 1) {}), Single())
				Dim num8 As Integer = CInt(Me.m_Animate_Ntsteps)
				Me.iAnimCurPoint = CInt(Me.m_Animate_Ntsteps)
				Me.fAnimInterval = 1F
				Me.timAnimate.Interval = CInt(Math.Round(CDbl(Me.fAnimInterval)))
				Dim array As Single() = New Single(CInt((Me.m_Animate_Ntsteps + 1S)) - 1) {}
				Dim array2 As Single() = New Single(CInt((Me.m_Animate_Ntsteps + 1S)) - 1) {}
				Dim array3 As Single() = New Single(CInt((Me.m_Animate_Ntsteps + 1S)) - 1) {}
				Dim array4 As Single() = New Single(CInt((Me.m_Animate_Ntsteps + 1S)) - 1) {}
				Dim num9 As Integer
				Dim flag As Boolean
				Dim num10 As Short
				Dim num11 As Single
				Dim num12 As Single
				Dim num13 As Single
				Dim num14 As Single
				Dim num15 As Single
				Dim num16 As Single
				If(RSWIN_DESC.SETUP_PrintDynoActual And If(-If((RSWIN_DESC.rst.RDNtsteps > 0S > False), 1S, 0S), 1S, 0S)) <> 0S Then
					num9 = 5
					flag = True
					If num8 > CInt(RSWIN_DESC.rst.RDNtsteps) Then
						num10 = CShort(num8)
					Else
						num10 = RSWIN_DESC.rst.RDNtsteps
						num8 = CInt(num10)
					End If
					Dim rdsurfPos As Single() = RSWIN_DESC.rst.RDSurfPos
					num11 = 0F
					num12 = 0F
					Util.Maxmin(rdsurfPos, num13, num14, num11, num12)
					Dim rdsurfLoad As Single() = RSWIN_DESC.rst.RDSurfLoad
					num12 = 0F
					num11 = 0F
					Util.Maxmin(rdsurfLoad, num15, num16, num12, num11)
					num15 = CtrlUI.ConvertUnits(num15, 12)
					num16 = CtrlUI.ConvertUnits(num16, 12)
					num13 = CtrlUI.ConvertUnits(num13, 8)
					num14 = CtrlUI.ConvertUnits(num14, 8)
				Else
					num9 = 4
					flag = False
					num10 = CShort(num8)
				End If
				Dim surfPos As Single() = RSWIN_DESC.rst.SurfPos
				num12 = 0F
				num11 = 0F
				Dim num17 As Single
				Dim num18 As Single
				Util.Maxmin(surfPos, num17, num18, num12, num11)
				Dim num19 As Single = num18
				If num18 < 0F Then
					num18 = 0F
				End If
				num17 = CtrlUI.ConvertUnits(num17, 8)
				num18 = CtrlUI.ConvertUnits(num18, 8)
				Dim surfLoad As Single() = RSWIN_DESC.rst.SurfLoad
				num12 = 0F
				num11 = 0F
				Dim num20 As Single
				Dim num21 As Single
				Util.Maxmin(surfLoad, num20, num21, num12, num11)
				num20 = CtrlUI.ConvertUnits(num20, 12)
				num21 = CtrlUI.ConvertUnits(num21, 12)
				Dim pumpLoad As Single() = RSWIN_DESC.rst.PumpLoad
				num12 = 0F
				num11 = 0F
				Dim num22 As Single
				Dim num23 As Single
				Util.Maxmin(pumpLoad, num22, num23, num12, num11)
				num22 = CtrlUI.ConvertUnits(num22, 12)
				num23 = CtrlUI.ConvertUnits(num23, 12)
				Dim pumpPos As Single() = RSWIN_DESC.rst.PumpPos
				num12 = 0F
				num11 = 0F
				Dim num24 As Single
				Dim num25 As Single
				Util.Maxmin(pumpPos, num24, num25, num12, num11)
				num24 = CtrlUI.ConvertUnits(num24, 8)
				num25 = CtrlUI.ConvertUnits(num25, 8)
				If flag Then
					If num20 < num15 Then
						num20 = num15
					End If
					If num21 > num16 Then
						num21 = num16
					End If
					If num17 < num13 Then
						num17 = num13
					End If
					If num18 > num14 Then
						num18 = num14
					End If
				End If
				If num24 > num17 Then
					num17 = num24
				End If
				If num25 < num18 Then
					num18 = num25
				End If
				Dim rst2 As cRODSTAR
				Dim num30 As Short
				Dim num31 As Short

					Dim num26 As Single = CSng((CDbl(num25) - 0.1 * CDbl((num24 - num25))))
					If num26 < num18 Then
						num26 = num18
					End If
					Dim num27 As Single = CSng((CDbl(num24) + 0.1 * CDbl((num24 - num25))))
					If num27 > num17 Then
						num27 = num17
					End If
					num26 = CtrlUI.ConvertUnits(num26, 8)
					num27 = CtrlUI.ConvertUnits(num27, 8)
					If num22 > num20 Then
						num20 = num22
					End If
					If num23 < num21 Then
						num21 = num23
					End If
					num20 = CSng((CDbl(num20) * 1.2))
					Dim num28 As Single = CSng((CDbl(num23) - 0.1 * CDbl((num22 - num23))))
					If num28 < num21 Then
						num28 = num21
					End If
					Dim num29 As Single = CSng((CDbl(num22) + 0.1 * CDbl((num22 - num23))))
					If num29 > num20 Then
						num29 = num20
					End If
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Me.SetLinesX(3, 0) = num26
					Me.SetLinesX(3, 1) = num27
					Me.SetLinesY(3, 0) = CtrlUI.ConvertUnits(rst.LineSettings(3).Value, 12)
					Me.SetLinesY(3, 1) = CtrlUI.ConvertUnits(rst.LineSettings(3).Value, 12)
					Me.SetLinesX(4, 0) = num26
					Me.SetLinesX(4, 1) = num27
					Me.SetLinesY(4, 0) = CtrlUI.ConvertUnits(rst.LineSettings(4).Value, 12)
					Me.SetLinesY(4, 1) = CtrlUI.ConvertUnits(rst.LineSettings(4).Value, 12)
					Me.SetLinesX(1, 0) = CtrlUI.ConvertUnits(rst.LineSettings(1).Value, 8)
					Me.SetLinesX(1, 1) = CtrlUI.ConvertUnits(rst.LineSettings(1).Value, 8)
					Me.SetLinesY(1, 0) = num28
					Me.SetLinesY(1, 1) = num29
					Me.SetLinesX(2, 0) = CtrlUI.ConvertUnits(rst.LineSettings(2).Value, 8)
					Me.SetLinesX(2, 1) = CtrlUI.ConvertUnits(rst.LineSettings(2).Value, 8)
					Me.SetLinesY(2, 0) = num28
					Me.SetLinesY(2, 1) = num29
					rst2 = RSWIN_DESC.rst
					num30 = -1S
					num31 = 0S

				Dim num32 As Short = rst2.NtstepsUpstroke - 1S
				Dim num33 As Short = CShort(Me.iStep)
				Dim num34 As Short = num32
				num7 = num31
				While (num33 >> 15 Xor CInt(num7)) <= (num33 >> 15 Xor CInt(num34))
					num30 += 1S
					array(CInt(num30)) = CtrlUI.ConvertUnits(rst2.PermLoad(CInt(num7)), 12)
					array3(CInt(num30)) = CtrlUI.ConvertUnits(rst2.SurfPos(CInt(num7)), 8)

						num7 += num33

				End While
				Dim num35 As Integer = CInt((num30 + 1S))
				num30 = -1S
				Dim ntstepsUpstroke As Short = rst2.NtstepsUpstroke
				Dim num36 As Short = rst2.Ntsteps - 1S
				Dim num37 As Short = CShort(Me.iStep)
				Dim num38 As Short = num36
				num7 = ntstepsUpstroke
				While (num37 >> 15 Xor CInt(num7)) <= (num37 >> 15 Xor CInt(num38))
					num30 += 1S
					array2(CInt(num30)) = CtrlUI.ConvertUnits(rst2.PermLoad(CInt(num7)), 12)
					array4(CInt(num30)) = CtrlUI.ConvertUnits(rst2.SurfPos(CInt(num7)), 8)

						num7 += num37

				End While
				Dim num39 As Integer = CInt((num30 + 1S))
				Dim chart As ChartFX.WinForms.Chart = DynoChart
				chart.Data.Clear()
				chart.LegendBox.Visible = True
				Dim legendItemAttributes As LegendItemAttributes = New LegendItemAttributes()
				legendItemAttributes.Visible = False
				chart.LegendBox.ItemAttributes(chart.Series) = legendItemAttributes
				chart.LegendBox.CustomItems.Clear()
				Dim titleDockable As TitleDockable = chart.Titles(0)
				titleDockable.Alignment = StringAlignment.Center
				If bLargeChart Then
					titleDockable.Font = New Font("Arial", 12F, FontStyle.Bold)
				Else
					titleDockable.Font = New Font("Arial", 10F, FontStyle.Bold)
				End If
				titleDockable.Text = Conversions.ToString(Me.sDynamometerCards)
				titleDockable.TextColor = Color.Black
				If bLargeChart Then
					Dim num40 As Integer = -1
					num40 += 1
					Dim customLegendItem As CustomLegendItem = New CustomLegendItem()
					customLegendItem.Text = Conversions.ToString(Me.sSurfaceCard)
					customLegendItem.Color = Color.Blue
					customLegendItem.MarkerShape = MarkerShape.HorizontalLine
					customLegendItem.Border.Effect = BorderEffect.None
					chart.LegendBox.CustomItems.Add(customLegendItem)
					num40 += 1
					Dim customLegendItem2 As CustomLegendItem = New CustomLegendItem()
					customLegendItem2.Text = Conversions.ToString(Me.sDownholeCard)
					customLegendItem2.Color = Color.DarkGreen
					customLegendItem2.MarkerShape = MarkerShape.HorizontalLine
					customLegendItem2.Border.Effect = BorderEffect.None
					chart.LegendBox.CustomItems.Add(customLegendItem2)
					num40 += 1
					Dim customLegendItem3 As CustomLegendItem = New CustomLegendItem()
					customLegendItem3.Text = Conversions.ToString(Me.sPermissibleLoadDiagram)
					customLegendItem3.Color = Color.Red
					customLegendItem3.MarkerShape = MarkerShape.HorizontalLine
					customLegendItem3.Border.Effect = BorderEffect.None
					chart.LegendBox.CustomItems.Add(customLegendItem3)
					If flag Then
						num40 += 1
						Dim customLegendItem4 As CustomLegendItem = New CustomLegendItem()
						customLegendItem4.Text = Conversions.ToString(Me.sMeasuredCard)
						customLegendItem4.Color = Color.Gray
						customLegendItem4.MarkerShape = MarkerShape.HorizontalLine
						customLegendItem4.Border.Effect = BorderEffect.None
						chart.LegendBox.CustomItems.Add(customLegendItem4)
					End If
					chart.LegendBox.Border = DockBorder.External
					chart.LegendBox.Dock = DockArea.Bottom
					chart.LegendBox.Style = LegendBoxStyles.Wordbreak
					chart.LegendBox.ResetBackColor()
					chart.LegendBox.BackColor = Color.Transparent
					chart.LegendBox.Visible = True
					chart.Refresh()
				Else
					chart.LegendBox.Visible = False
				End If
				axisX.Title.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject("Position (", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, "cm", "inches")), ")"))
				axisX.Title.Alignment = StringAlignment.Center
				axisX.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
				axisY.Title.Text = Conversions.ToString(Operators.AddObject("Load ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, "(N)", "(lbs)")))
				axisY.Title.Alignment = StringAlignment.Center
				axisY.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
				axisY.Max = CDbl(num20)

					axisY.Min = CDbl((num23 - 250F))
					axisX.Max = CDbl(num17) + CDbl(num17) * 0.15
					If num19 < 0F And num19 > -1F Then
						axisX.Min = -1.0
					Else
						axisX.Min = 0.0
					End If
					chart.Refresh()
					chart.Data.Series = num9
					chart.Data.Points = num8
					chart.Series(0).Color = Color.Blue
					chart.Series(1).Color = Color.DarkGreen
					chart.Series(2).Color = Color.Red
					chart.Series(3).Color = Color.Red
					If flag Then
						chart.Series(4).Color = Color.Gray
					End If
					chart.Series(0).Line.Width = 2S
					chart.Series(1).Line.Width = 2S
					chart.Series(2).Line.Width = 1S
					chart.Series(3).Line.Width = 1S
					If flag Then
						chart.Series(4).Line.Width = 1S
					End If
					Try
						Dim num41 As Short = 0S
						Dim num42 As Short = CShort((num9 - 1))
						num7 = num41
						While num7 <= num42
							Dim num43 As Short = 0S
							Dim num44 As Short = CShort((num8 - 1))
							num30 = num43
							While num30 <= num44
								' The following expression was wrapped in a checked-statement
								Dim num45 As Single
								Dim num46 As Single
								Select Case num7
									Case 0S
										If num30 <= Me.m_Animate_Ntsteps - 1S Then
											num45 = CtrlUI.ConvertUnits(Me.m_Animate_SurfLoad(CInt(num30)), 12)
											num46 = CtrlUI.ConvertUnits(Me.m_Animate_SurfPos(CInt(num30)), 8)
										End If
									Case 1S
										If num30 <= Me.m_Animate_Ntsteps - 1S Then
											num45 = CtrlUI.ConvertUnits(Me.m_Animate_PumpLoad(CInt(num30)), 12)
											num46 = CtrlUI.ConvertUnits(Me.m_Animate_PumpPos(CInt(num30)), 8)
										End If
									Case 2S
										If num30 <= Me.m_Animate_Ntsteps - 1S Then
											num45 = array(CInt(num30))
											num46 = array3(CInt(num30))
										End If
									Case 3S
										If num30 <= Me.m_Animate_Ntsteps - 1S Then
											num45 = array2(CInt(num30))
											num46 = array4(CInt(num30))
										End If
									Case 4S
										If num30 <= RSWIN_DESC.rst.RDNtsteps - 1S Then
											num45 = CtrlUI.ConvertUnits(RSWIN_DESC.rst.RDSurfLoad(CInt(num30)), 12)
											num46 = CtrlUI.ConvertUnits(RSWIN_DESC.rst.RDSurfPos(CInt(num30)), 8)
										End If
								End Select
								If num7 = 0S Or num7 = 1S Then
									If num30 <= Me.m_Animate_Ntsteps - 1S Then
										chart.Data.X(CInt(num7), CInt(num30)) = CDbl(num46)
										chart.Data.Y(CInt(num7), CInt(num30)) = CDbl(num45)
									Else
										chart.Data.Y(CInt(num7), CInt(num30)) = 1E+108
										If num7 = 0S Then
											Debug.WriteLine(num30.ToString())
										End If
									End If
								ElseIf num7 = 2S Then
									If num30 <= Me.m_Animate_Ntsteps - 1S And CDbl(num45) <= axisY.Max And num45 > 0F And CDbl(num46) > 0.1 Then
										chart.Data.X(CInt(num7), CInt(num30)) = CDbl(num46)
										chart.Data.Y(CInt(num7), CInt(num30)) = CDbl(num45)
									Else
										chart.Data.Y(CInt(num7), CInt(num30)) = 1E+108
									End If
								ElseIf num7 = 3S Then
									If num30 <= Me.m_Animate_Ntsteps - 1S And num45 > num23 Then
										If CDbl(num46) < 0.1 And num45 = 0F Then
											chart.Data.Y(CInt(num7), CInt(num30)) = 1E+108
										Else
											chart.Data.X(CInt(num7), CInt(num30)) = CDbl(num46)
											chart.Data.Y(CInt(num7), CInt(num30)) = CDbl(num45)
										End If
									Else
										chart.Data.Y(CInt(num7), CInt(num30)) = 1E+108
									End If
								ElseIf num7 = 4S Then
									If num30 <= RSWIN_DESC.rst.RDNtsteps - 1S Then
										chart.Data.X(CInt(num7), CInt(num30)) = CDbl(num46)
										chart.Data.Y(CInt(num7), CInt(num30)) = CDbl(num45)
									Else
										chart.Data.Y(CInt(num7), CInt(num30)) = 1E+108
									End If
								Else
									chart.Data.Y(CInt(num7), CInt(num30)) = 1E+108
								End If
								num30 += 1S
							End While
							If num7 = 0S Then
								chart.Data.Y(CInt(num7), CInt((Me.m_Animate_Ntsteps - 1S))) = CDbl(CtrlUI.ConvertUnits(RSWIN_DESC.rst.SurfLoad(0), 12))
								chart.Data.X(CInt(num7), CInt((Me.m_Animate_Ntsteps - 1S))) = CDbl(CtrlUI.ConvertUnits(RSWIN_DESC.rst.SurfPos(0), 8))
							ElseIf num7 = 1S Then
								chart.Data.Y(CInt(num7), CInt((Me.m_Animate_Ntsteps - 1S))) = CDbl(CtrlUI.ConvertUnits(RSWIN_DESC.rst.PumpLoad(0), 12))
								chart.Data.X(CInt(num7), CInt((Me.m_Animate_Ntsteps - 1S))) = CDbl(CtrlUI.ConvertUnits(RSWIN_DESC.rst.PumpPos(0), 8))
							End If
							Select Case num7
								Case 0S, 1S
									Dim animate_Ntsteps As Short = Me.m_Animate_Ntsteps
									Dim num47 As Short = num10
									For num48 As Short = animate_Ntsteps To num47
										chart.Data.Y(CInt(num7), CInt(num30)) = 1E+108
									Next
								Case 2S
									' The following expression was wrapped in a checked-expression
									Dim num49 As Short = CShort((num35 + 1))
									Dim num50 As Short = num10
									For num48 As Short = num49 To num50
										chart.Data.Y(CInt(num7), CInt(num30)) = 1E+108
									Next
								Case 3S
									' The following expression was wrapped in a checked-expression
									Dim num51 As Short = CShort((num39 + 1))
									Dim num52 As Short = num10
									For num48 As Short = num51 To num52
										chart.Data.Y(CInt(num7), CInt(num30)) = 1E+108
									Next
								Case 4S
									Dim rdntsteps As Short = RSWIN_DESC.rst.RDNtsteps
									Dim num53 As Short = num10
									For num48 As Short = rdntsteps To num53
										chart.Data.Y(CInt(num7), CInt(num30)) = 1E+108
									Next
							End Select
							num7 += 1S
						End While
					Catch ex As Exception
					End Try

				If Not bLargeChart Then
					' The following expression was wrapped in a unchecked-expression
					DynoChart.Width = CInt(Math.Round(CDbl(DynoChart.Height) * 1.4252))
				Else
					' The following expression was wrapped in a unchecked-expression
					RSWIN_DESC.fDynoLegendFactor = CSng((1.4252 * CDbl(DynoChart.LegendBox.Height) / CDbl(DynoChart.Height)))
					If Not bMainChart Then
						' The following expression was wrapped in a unchecked-expression
						DynoChart.Width = CInt(Math.Round(CDbl(DynoChart.Height) * (1.4252 - CDbl(RSWIN_DESC.fDynoLegendFactor))))
					ElseIf bMainChart Then
						' The following expression was wrapped in a unchecked-expression
						DynoChart.Width = CInt(Math.Round(CDbl(DynoChart.Height) * (1.4252 - CDbl(RSWIN_DESC.fDynoLegendFactor))))
						Me.CenterChartInPanel(Me.pnlDyno, DynoChart)
					End If
				End If
				Me.Refresh()
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub DisplayTorqueAnnotations(ByRef TorqueChart As ChartFX.WinForms.Chart, sLabel As String, tl As Single, tb As Single, GBRating As Single, tr As Single, bLargeChart As Boolean, bUpstroke As Boolean)
			Dim annotations As Annotations = New Annotations()
			TorqueChart.Extensions.Add(annotations)
			Dim annotationText As AnnotationText = New AnnotationText()
			Dim annotationText2 As AnnotationText = New AnnotationText()
			Dim annotationText3 As AnnotationText = New AnnotationText()
			Dim num As Integer = 5
			annotations.List.Add(annotationText)
			annotations.List.Add(annotationText2)
			annotations.List.Add(annotationText3)
			annotationText.TextColor = Color.Black
			annotationText.Color = Color.Transparent
			annotationText.Border.Color = Color.Transparent
			annotationText.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0)
			annotationText.Text = sLabel
			annotationText.Height = 50
			Dim num2 As Integer
			annotationText.Width = CInt(Math.Round(CDbl((tl + tr))))
			If bLargeChart Then
				num2 = CInt(Math.Round(CDbl(Math.Abs(tb / 1000F / 6F))))
			Else
				num2 = CInt(Math.Round(CDbl(Math.Abs(tb / 1000F / 5F))))
			End If
			annotationText.Attach(CDbl(tl), CDbl((tb / 1000F - CSng(num2))))
			annotationText.Align = StringAlignment.Center
			annotationText.Refresh()
			annotationText2.TextColor = Color.Black
			annotationText2.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0)
			annotationText2.Color = Color.Transparent
			annotationText2.Border.Color = Color.Transparent
			annotationText2.Text = Conversions.ToString(Me.sGearboxRating)
			annotationText2.Height = 30
			annotationText2.Width = 100
			annotationText2.Attach(320.0, CDbl((GBRating / 1000F - CSng(num))))
			annotationText2.Refresh()
			annotationText3.TextColor = Color.Black
			annotationText3.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0)
			annotationText3.Color = Color.Transparent
			annotationText3.Border.Color = Color.Transparent
			annotationText3.Text = Conversions.ToString(Me.sGearboxRating)
			annotationText3.Height = 30
			annotationText3.Width = 100
			annotationText3.Attach(320.0, CDbl((-CDbl(GBRating) / 1000F - CSng(num))))
			annotationText3.Refresh()
		End Sub

		Public Overridable Property VScroll As VScrollBar
			Get
				Return Me._VScroll
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As VScrollBar)
				Me._VScroll = value
			End Set
		End Property

		Friend Overridable Property pnlScrollBar As System.Windows.Forms.Panel
			Get
				Return Me._pnlScrollBar
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlScrollBar = value
			End Set
		End Property

		Public Overridable Property tbbStop As System.Windows.Forms.Button
			Get
				Return Me._tbbStop
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.tbbStop_Click
				If Me._tbbStop IsNot Nothing Then
					RemoveHandler Me._tbbStop.Click, value2
				End If
				Me._tbbStop = value
				If Me._tbbStop IsNot Nothing Then
					AddHandler Me._tbbStop.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property tbbStep As System.Windows.Forms.Button
			Get
				Return Me._tbbStep
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As MouseEventHandler = AddressOf Me.tbbStep_MouseDown
				Dim value3 As EventHandler = AddressOf Me.tbbStep_Click
				If Me._tbbStep IsNot Nothing Then
					RemoveHandler Me._tbbStep.MouseDown, value2
					RemoveHandler Me._tbbStep.Click, value3
				End If
				Me._tbbStep = value
				If Me._tbbStep IsNot Nothing Then
					AddHandler Me._tbbStep.MouseDown, value2
					AddHandler Me._tbbStep.Click, value3
				End If
			End Set
		End Property

		Public Overridable Property tbbRun As System.Windows.Forms.Button
			Get
				Return Me._tbbRun
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.tbbRun_Click
				If Me._tbbRun IsNot Nothing Then
					RemoveHandler Me._tbbRun.Click, value2
				End If
				Me._tbbRun = value
				If Me._tbbRun IsNot Nothing Then
					AddHandler Me._tbbRun.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdClose As System.Windows.Forms.Button
			Get
				Return Me._cmdClose
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Button)
				Dim value2 As EventHandler = AddressOf Me.cmdClose_Click_1
				If Me._cmdClose IsNot Nothing Then
					RemoveHandler Me._cmdClose.Click, value2
				End If
				Me._cmdClose = value
				If Me._cmdClose IsNot Nothing Then
					AddHandler Me._cmdClose.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _optReport_0 As RadioButton
			Get
				Return Me.__optReport_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optReport_0_CheckedChanged
				If Me.__optReport_0 IsNot Nothing Then
					RemoveHandler Me.__optReport_0.Click, value2
				End If
				Me.__optReport_0 = value
				If Me.__optReport_0 IsNot Nothing Then
					AddHandler Me.__optReport_0.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _optReport_1 As RadioButton
			Get
				Return Me.__optReport_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optReport_1_CheckedChanged
				If Me.__optReport_1 IsNot Nothing Then
					RemoveHandler Me.__optReport_1.Click, value2
				End If
				Me.__optReport_1 = value
				If Me.__optReport_1 IsNot Nothing Then
					AddHandler Me.__optReport_1.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _optReport_2 As RadioButton
			Get
				Return Me.__optReport_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optReport_2_CheckedChanged
				If Me.__optReport_2 IsNot Nothing Then
					RemoveHandler Me.__optReport_2.Click, value2
				End If
				Me.__optReport_2 = value
				If Me.__optReport_2 IsNot Nothing Then
					AddHandler Me.__optReport_2.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _optReport_3 As RadioButton
			Get
				Return Me.__optReport_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optReport_3_CheckedChanged
				If Me.__optReport_3 IsNot Nothing Then
					RemoveHandler Me.__optReport_3.Click, value2
				End If
				Me.__optReport_3 = value
				If Me.__optReport_3 IsNot Nothing Then
					AddHandler Me.__optReport_3.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlTabs As System.Windows.Forms.Panel
			Get
				Return Me._pnlTabs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlTabs = value
			End Set
		End Property

		Friend Overridable Property Viewer1 As Viewer
			Get
				Return Me._Viewer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Viewer)
				Dim value2 As ZoomChangedEventHandler = AddressOf Me.Viewer1_ZoomChanged
				Dim value3 As ToolClickEventHandler = AddressOf Me.Viewer1_ToolClick
				Dim value4 As ScrollEventHandler = AddressOf Me.Viewer1_Scroll
				Dim value5 As MouseEventHandler = AddressOf Me.Viewer1_MouseWheel
				Dim value6 As MouseEventHandler = AddressOf Me.Viewer1_MouseDown
				Dim value7 As MouseEventHandler = AddressOf Me.Viewer1_MouseDoubleClick
				Dim value8 As MouseEventHandler = AddressOf Me.Viewer1_MouseClick
				Dim value9 As EventHandler = AddressOf Me.Viewer1_Load
				Dim value10 As EventHandler = AddressOf Me.Viewer1_Leave
				Dim value11 As KeyPressEventHandler = AddressOf Me.Viewer1_KeyPress
				Dim value12 As KeyEventHandler = AddressOf Me.Viewer1_KeyDown
				Dim value13 As EventHandler = AddressOf Me.Viewer1_Enter
				Dim value14 As EventHandler = AddressOf Me.Viewer1_DoubleClick
				Dim value15 As EventHandler = AddressOf Me.Viewer1_Click
				If Me._Viewer1 IsNot Nothing Then
					RemoveHandler Me._Viewer1.ZoomChanged, value2
					RemoveHandler Me._Viewer1.ToolClick, value3
					RemoveHandler Me._Viewer1.Scroll, value4
					RemoveHandler Me._Viewer1.MouseWheel, value5
					RemoveHandler Me._Viewer1.MouseDown, value6
					RemoveHandler Me._Viewer1.MouseDoubleClick, value7
					RemoveHandler Me._Viewer1.MouseClick, value8
					RemoveHandler Me._Viewer1.Load, value9
					RemoveHandler Me._Viewer1.Leave, value10
					RemoveHandler Me._Viewer1.KeyPress, value11
					RemoveHandler Me._Viewer1.KeyDown, value12
					RemoveHandler Me._Viewer1.Enter, value13
					RemoveHandler Me._Viewer1.DoubleClick, value14
					RemoveHandler Me._Viewer1.Click, value15
				End If
				Me._Viewer1 = value
				If Me._Viewer1 IsNot Nothing Then
					AddHandler Me._Viewer1.ZoomChanged, value2
					AddHandler Me._Viewer1.ToolClick, value3
					AddHandler Me._Viewer1.Scroll, value4
					AddHandler Me._Viewer1.MouseWheel, value5
					AddHandler Me._Viewer1.MouseDown, value6
					AddHandler Me._Viewer1.MouseDoubleClick, value7
					AddHandler Me._Viewer1.MouseClick, value8
					AddHandler Me._Viewer1.Load, value9
					AddHandler Me._Viewer1.Leave, value10
					AddHandler Me._Viewer1.KeyPress, value11
					AddHandler Me._Viewer1.KeyDown, value12
					AddHandler Me._Viewer1.Enter, value13
					AddHandler Me._Viewer1.DoubleClick, value14
					AddHandler Me._Viewer1.Click, value15
				End If
			End Set
		End Property

		Friend Overridable Property pnlActiveReport As System.Windows.Forms.Panel
			Get
				Return Me._pnlActiveReport
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlActiveReport = value
			End Set
		End Property

		Private Sub cmdClose_Click_1(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				Me.MakeSureAnimationIsntRunning()
				Me.Tag = "Close"
				Me.Hide()
			Catch ex2 As Exception
			End Try
		End Sub

		Friend Overridable Property ChartFX_TorquePlot As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_TorquePlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_TorquePlot = value
			End Set
		End Property

		Friend Overridable Property pnlTorquePlot As System.Windows.Forms.Panel
			Get
				Return Me._pnlTorquePlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._pnlTorquePlot = value
			End Set
		End Property

		Friend Overridable Property pnlDyno As System.Windows.Forms.Panel
			Get
				Return Me._pnlDyno
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Dim value2 As PaintEventHandler = AddressOf Me.pnlDyno_Paint
				If Me._pnlDyno IsNot Nothing Then
					RemoveHandler Me._pnlDyno.Paint, value2
				End If
				Me._pnlDyno = value
				If Me._pnlDyno IsNot Nothing Then
					AddHandler Me._pnlDyno.Paint, value2
				End If
			End Set
		End Property

		Protected Overrides Sub Finalize()
			MyBase.Finalize()
		End Sub

		Public Sub PrintResults()
			Dim iGBScore As Integer = 0
			Dim iRLScore As Integer = 0
			Dim iSLScore As Integer = 0
			Dim iSEffScore As Integer = 0
			Dim iBotMinStressScore As Integer = 0
			Dim iMPRLScore As Integer = 0
			Dim num As Single = 0F
			Dim flag As Boolean = False
			Dim bForceDisplay As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim sTapersOverMax As String = ""
			Try
				Dim text As String = "Printing"
				If RSWIN_DESC.rst.gbReportData Then
					text += " results"
				End If
				If RSWIN_DESC.rst.gbBatch Then
					text = text + " for " + RSWIN_DESC.rst.Inputfile + ".  Please wait."
				Else
					text += ".  Please wait."
				End If
				Util.Message(text)
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Dim num2 As Integer = 0
				If RSWIN_DESC.rst.gbCoverPage Then
					num2 = 1
				End If
				num2 += 2
				Dim bCheckToAdd As Boolean = False
				Dim flag4 As Boolean = False
				Dim text2 As String = RSWIN.TotalExpertScore(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore, num, bCheckToAdd, flag, flag4, False, False)
				Me.rptExpertSummary = New rptExpertSummary()
				If CDbl(num) >= 0.99 And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.95 And CDbl(RSWIN_DESC.rst.StructL) <= 0.95 Then
					If Not Me.AllScoresOkay(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore) Then
						RSWIN_DESC.bShowScoringPage = True
						bForceDisplay = True
					Else
						RSWIN_DESC.bShowScoringPage = False
					End If
				ElseIf CDbl(num) >= 0.99 And Not Me.AllScoresOkay(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore) Then
					RSWIN_DESC.bShowScoringPage = True
					bForceDisplay = True
				Else
					RSWIN_DESC.bShowScoringPage = True
				End If
				If RSWIN_DESC.rst.gbScoringPage AndAlso RSWIN_DESC.bShowScoringPage Then
					num2 += 1
				End If
				If cRODSTAR.gbReportData Then
					If Operators.CompareString(RSWIN_DESC.SETUP_Language, RSWIN_DESC.sEnglish, False) = 0 Then
						num2 += 1
					Else
						num2 += 2
					End If
				End If
				If cRODSTAR.gbReportCostAnalysis <> 0S Then
					num2 += 1
				End If
				If RSWIN_DESC.rst.gbOrderPage Then
					num2 += 1
				End If
				If cRODSTAR.gbReportIPR And cRODSTAR.gbUseIPR Then
					num2 += 1
				End If
				If cRODSTAR.gbOutputLoaded AndAlso (cRODSTAR.gbReportDynoPred Or RSWIN_DESC.rst.NumRods > 10S) Then
					num2 += 1
				End If
				Dim flag5 As Boolean
				Dim text3 As String
				Dim flag6 As Boolean
				Dim text4 As String
				Dim text5 As String
				If(RSWIN_DESC.SETUP_UseImpred And If(-If((RSWIN_DESC.bRodStarD > False), 1S, 0S), 1S, 0S)) <> 0S AndAlso RSWIN_DESC.mdsDeviationProfile IsNot Nothing AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 2 Then
					Try
						MImpred.InitSummaryReportXML(Me.nGuideLines, flag5, text3, flag6, text4, text5)
						flag2 = True
					Catch ex As Exception
					End Try
					Try
						flag3 = MImpred.CheckSurveyForDeviation()
					Catch ex2 As Exception
					End Try
					If RSWIN_DESC.rst.gbReportGuide Or RSWIN_DESC.rst.gbReportDevChart Then
						Dim impredObj As TEImpred = MImpred.ImpredObj
						Try
							RSWIN_DESC.num_rod_elements = impredObj.num_rod_elements
						Catch ex3 As Exception
						End Try
					End If
					If cRODSTAR.gbReportGuide AndAlso flag3 Then
						flag4 = False
						Dim text6 As String = ""
						Dim flag7 As Boolean = False
						Dim text7 As String = ""
						Dim text8 As String = ""
						MImpred.GetReportXMLnPages(Me.nGuideLines, flag4, text6, flag7, text7, text8, sTapersOverMax)
						num2 += RSWIN_DESC.rst.Number_Of_Guide_report_Pages
					End If
					If cRODSTAR.gbReportDevChart Then
						num2 += 2
					End If
					If cRODSTAR.gbReportDevSurvey Or cRODSTAR.gbReportDevChart Then
						Try
							Me.mdsDeviationProfile_Output = Nothing
							MImpred.InitSurveyDataset(Me.mdsDeviationProfile_Output, Nothing)
							MImpred.CopyDatasets(RSWIN_DESC.mdsDeviationProfile, Me.mdsDeviationProfile_Output, RSWIN_DESC.SETUP_MeasurementSystem <> 1, False)
						Catch ex4 As Exception
						End Try
						If Not Me.bDogLegsCalculated Then
							Me.m_bAfterPump1 = False
							Me.m_bAfterPump2 = False
							Me.m_bAfterPump1_report = False
							Me.m_bAfterPump2_report = False
							Me.ShowDeviation_Dogleg(Me.mdsDeviationProfile_Output, False, True)
							Dim num3 As Short
							Me.ShowDeviation_TVD(Me.mdsDeviationProfile_Output, True, num3)
							Me.bDogLegsCalculated = True
						End If
						Me.BuildDeviationProfileXML_from_DS(Me.mdsDeviationProfile_Output, Me.nDevSurveyLines)
						If cRODSTAR.gbReportDevSurvey Then
							num2 += RSWIN_DESC.rst.NumDevSurveyPages
						End If
					End If
				End If
				Dim num4 As Integer = 0
				If RSWIN_DESC.rst.gbCoverPage Then
					Me.rptCoverPage = New rptCoverPage()
					num4 += 1
					Util.BusyCursor()
					Application.DoEvents()
					Me.rptCoverPage.TotalPageNumber = num2
					Me.rptCoverPage.ThisPageNumber = num4
					Me.rptCoverPage.bPrint = True
					Try
						Me.rptCoverPage.Run(False)
					Catch ex5 As Exception
					End Try
					Me.rptCoverPage.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
					Me.rptCoverPage.Document.Print(False, False)
				End If
				If RSWIN_DESC.rst.gbScoringPage AndAlso RSWIN_DESC.bShowScoringPage Then
					Me.rptExpertSummary = New rptExpertSummary()
					num4 += 1
					Util.BusyCursor()
					Application.DoEvents()
					Me.rptExpertSummary.TotalPageNumber = num2
					Me.rptExpertSummary.ThisPageNumber = num4
					Me.rptExpertSummary.bPrint = False
					Me.rptExpertSummary.bForceDisplay = bForceDisplay
					If RSWIN_DESC.bRodStarD Then
						Me.rptExpertSummary.sTapersOverMax = sTapersOverMax
					End If
					Me.rptExpertSummary.Run(False)
					Me.rptExpertSummary.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
					Me.rptExpertSummary.Document.Print(False, False)
				End If
				If cRODSTAR.gbReportData Then
					If Operators.CompareString(RSWIN_DESC.SETUP_Language, RSWIN_DESC.sEnglish, False) = 0 Then
						Dim num5 As Integer
						If RSWIN_DESC.rst.NumRods > 10S Or (RSWIN_DESC.rst.NumRods > 8S And RSWIN.bHasRelocatedSB(num5)) Then
							Me.rptCalcResults_Summary = New rptCalcResults_Summary()
							num4 += 1
							Me.rptCalcResults_Summary.TotalPageNumber = num2
							Me.rptCalcResults_Summary.ThisPageNumber = num4
							Me.rptCalcResults_Summary.bPrint = True
							Me.ExportDynoAndTorqueCharts(True, True, True)
							Me.rptCalcResults_Summary.Run(False)
							Me.rptCalcResults_Summary.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
							Me.rptCalcResults_Summary.Document.Print(False, False)
						Else
							Me.rptCalcResults = New rptCalcResults()
							num4 += 1
							Me.rptCalcResults.TotalPageNumber = num2
							Me.rptCalcResults.ThisPageNumber = num4
							Me.rptCalcResults.bPrint = True
							Me.ExportDynoAndTorqueCharts(True, True, True)
							Me.rptCalcResults.Run(False)
							Me.rptCalcResults.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
							Me.rptCalcResults.Document.Print(False, False)
						End If
					Else
						Me.rptResultsInputs = New rptResultsInputs()
						num4 += 1
						Me.rptResultsInputs.TotalPageNumber = num2
						Me.rptResultsInputs.ThisPageNumber = num4
						Me.rptResultsInputs.bPrint = True
						Me.rptResultsInputs.Run(False)
						Me.rptResultsInputs.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
						Me.rptResultsInputs.Document.Print(False, False)
						Me.rptResultsOutputs = New rptResultsOutputs()
						num4 += 1
						Me.rptResultsOutputs.TotalPageNumber = num2
						Me.rptResultsOutputs.ThisPageNumber = num4
						Me.rptResultsOutputs.bPrint = True
						Me.ExportDynoAndTorqueCharts(True, True, False)
						Me.rptResultsOutputs.Run(False)
						Me.rptResultsOutputs.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
						Me.rptResultsOutputs.Document.Print(False, False)
					End If
				End If
				If cRODSTAR.gbOutputLoaded Then
					If(cRODSTAR.gbReportDynoPred Or RSWIN_DESC.rst.NumRods > 10S) And cRODSTAR.gbReportTorque And cRODSTAR.gbReportSinglePageDynoTorque Then
						num4 += 1
						Me.rptDynoAndTorqueChart = New rptDynoAndTorqueChart()
						Me.rptDynoAndTorqueChart.TotalPageNumber = num2
						Me.rptDynoAndTorqueChart.ThisPageNumber = num4
						Me.rptDynoAndTorqueChart.bPrint = True
						Me.ExportDynoAndTorqueCharts2(True, True, False)
						Me.rptDynoAndTorqueChart.Run(False)
						Me.rptDynoAndTorqueChart.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
						Me.rptDynoAndTorqueChart.Document.Print(False, False)
					End If
					Util.BusyCursor()
					If cRODSTAR.gbReportCostAnalysis <> 0S Then
						If RSWIN_DESC.bRodStarD And Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
							Me.m_rptCostAnalysis_D = New rptCostAnalysis_D()
							Me.m_rptCostAnalysis_D.bPrint = True
							num4 += 1
							Me.m_rptCostAnalysis_D.TotalPageNumber = num2
							Me.m_rptCostAnalysis_D.ThisPageNumber = num4
							Me.m_rptCostAnalysis_D.Run(False)
							Me.m_rptCostAnalysis_D.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
							Me.m_rptCostAnalysis_D.Document.Print(False, False)
						Else
							Me.m_rptCostAnalysis = New rptCostAnalysis()
							Me.m_rptCostAnalysis.bPrint = True
							num4 += 1
							Me.m_rptCostAnalysis.TotalPageNumber = num2
							Me.m_rptCostAnalysis.ThisPageNumber = num4
							Me.m_rptCostAnalysis.Run(False)
							Me.m_rptCostAnalysis.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
							Me.m_rptCostAnalysis.Document.Print(False, False)
						End If
					End If
					If RSWIN_DESC.rst.gbOrderPage Then
						Me.rptOrderPage = New rptOrderForm()
						num4 += 1
						Util.BusyCursor()
						Application.DoEvents()
						Me.rptOrderPage.TotalPageNumber = num2
						Me.rptOrderPage.ThisPageNumber = num4
						Me.rptOrderPage.bPrint = True
						Try
							Me.rptOrderPage.Run(False)
						Catch ex6 As Exception
						End Try
						Me.rptOrderPage.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
						Me.rptOrderPage.Document.Print(False, False)
					End If
					If cRODSTAR.gbReportIPR And cRODSTAR.gbUseIPR Then
						num4 += 1
						Me.IPRPlot.LoadIPRPlot()
						Dim iprreport As IPRReport
						Me.IPRPlot.DisplayIPRPlot(iprreport, num4, num2, True)
					End If
					If(RSWIN_DESC.SETUP_UseImpred And If(-If((RSWIN_DESC.bRodStarD > False), 1S, 0S), 1S, 0S)) <> 0S AndAlso RSWIN_DESC.mdsDeviationProfile IsNot Nothing AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 2 Then
						Try
							Me.PlotSurvey()
						Catch ex7 As Exception
						End Try
						If cRODSTAR.gbReportDevChart And RSWIN_DESC.bRodStarD Then
							Dim rptAll As rptAll = New rptAll()
							rptAll.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
							Me.SizeDevCharts()
							Me.rptDeviationSurvey = New rptDeviationSurvey()
							Me.rptDeviationSurvey.bPrint = True
							Me.ExportSideForcesChart(True, True)
							Me.ExportAxialLoadsChart(True, True)
							Me.ExportBucklingTendencyChart(True, True)
							Me.ExportDoglegsChart(True, True)
							Me.fMaxForCharts = Me.FindMaxForCharts()
							Me.ExportSurveyEWChart(True, True)
							Me.ExportSurveyNSChart(True, True)
							Me.ExportSurveyPlanPlotChart(True, True)
							num4 += 1
							Me.rptDeviationSurvey.TotalPageNumber = num2
							Me.rptDeviationSurvey.ThisPageNumber = num4
							Me.rptDeviationSurvey.Run(False)
							Try
								Dim enumerator As IEnumerator = Me.rptDeviationSurvey.Document.Pages.GetEnumerator()
								If enumerator.MoveNext() Then
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(enumerator.Current, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								End If
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
							rptAll.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
							rptAll.Document.Print(False, False)
							If Not flag2 Then
								MImpred.InitSummaryReportXML(Me.nGuideLines, flag5, text3, flag6, text4, text5)
							End If
							Dim tchart1_Report As TChart = Me.TChart1_Report
							Me.ExportDevPlot(tchart1_Report)
							Me.TChart1_Report = tchart1_Report
							Me.rptDevSurvey3DPlot = New rptDevSurvey3DPlot()
							Me.rptDevSurvey3DPlot.TotalPageNumber = num2
							num4 += 1
							Me.rptDevSurvey3DPlot.ThisPageNumber = num4
							Me.rptDevSurvey3DPlot.Run(False)
							Me.rptDevSurvey3DPlot.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
							Me.rptDevSurvey3DPlot.Document.Print(False, False)
						End If
						If Not RSWIN_DESC.rst.gbReportDevChart And RSWIN_DESC.bRodStarD And Not flag2 Then
							MImpred.InitSummaryReportXML(Me.nGuideLines, flag5, text3, flag6, text4, text5)
						End If
						If cRODSTAR.gbReportGuide AndAlso flag3 Then
							If RSWIN_DESC.SETUP_RECOMMEND_GUIDES Or (Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bAllZeroNumGuides) Then
								Me.rptRecommendedGuideReport = New rptRecommendedGuideReport()
							Else
								Me.rptRecommendedGuideReport = New rptRecommendedGuideReport2()
							End If
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bPrint", New Object() { True }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bMaxFootnote", New Object() { flag6 }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sMaxFootnote", New Object() { text4 }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bMinFootnote", New Object() { flag5 }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sMinFootnote", New Object() { text3 }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sGuideMsg", New Object() { text5 }, Nothing, Nothing)
							Try
								Dim xmldataSource As XMLDataSource = New XMLDataSource()
								xmldataSource.LoadXML(RSWIN_DESC.sSummaryDataSetXML)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object() { xmldataSource }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "DataSource", New Object() { xmldataSource }, Nothing, Nothing)
							Catch ex8 As Exception
							End Try
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "ValidateOnParse", New Object() { True }, Nothing, Nothing, False, True)
							CType(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), XMLDataSource).RecordsetPattern = "//Data/Entries/Row"
							num4 += 1
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "TotalPageNumber", New Object() { num2 }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "ThisPageNumber", New Object() { num4 }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "NumberOfLines", New Object() { Me.nGuideLines }, Nothing, Nothing)
							NewLateBinding.LateCall(Me.rptRecommendedGuideReport, Nothing, "Run", New Object() { False }, Nothing, Nothing, Nothing, True)
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Printer", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "PrinterSettings", New Object() { RSWIN_DESC.pd.PrinterSettings }, Nothing, Nothing, False, True)
							NewLateBinding.LateCall(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Print", New Object() { False, False }, Nothing, Nothing, Nothing, True)
						End If
						If RSWIN_DESC.rst.gbReportDevSurvey Then
							Util.BusyCursor()
							Application.DoEvents()
							Me.rptDeviationProfile = New rptDeviationProfile()
							Me.rptDeviationProfile.bPrint = False
							Try
								Dim xmldataSource2 As XMLDataSource = New XMLDataSource()
								xmldataSource2.LoadXML(RSWIN_DESC.sDeviationProfileXML)
								Me.rptDeviationProfile.ds = xmldataSource2
								Me.rptDeviationProfile.DataSource = xmldataSource2
							Catch ex9 As Exception
							End Try
							Me.rptDeviationProfile.ds.ValidateOnParse = True
							Me.rptDeviationProfile.ds.RecordsetPattern = "//Data/Entries/Row"
							Me.rptDeviationProfile.TotalPageNumber = num2
							If RSWIN_DESC.rst.gbReportGuide AndAlso flag3 Then
								num4 += RSWIN_DESC.rst.Number_Of_Guide_report_Pages
							Else
								num4 += 1
							End If
							Me.rptDeviationProfile.ThisPageNumber = num4
							Me.rptDeviationProfile.NumberOfLines = Me.nDevSurveyLines
							Me.rptDeviationProfile.Run(False)
							Me.rptDeviationProfile.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
							Me.rptDeviationProfile.Document.Print(False, False)
							num4 = num4 + CInt(Math.Round(CDbl(Me.nDevSurveyLines) / 35.0)) - 1
						End If
					End If
				End If
				cRODSTAR = Nothing
			Catch ex10 As Exception
			End Try
		End Sub

		Public Sub PrintResults_Old()
			Dim iGBScore As Integer = 0
			Dim iRLScore As Integer = 0
			Dim iSLScore As Integer = 0
			Dim iSEffScore As Integer = 0
			Dim iBotMinStressScore As Integer = 0
			Dim iMPRLScore As Integer = 0
			Dim num As Single = 0F
			Dim flag As Boolean = False
			Dim bForceDisplay As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim sTapersOverMax As String = ""
			Try
				Dim text As String = "Printing"
				If RSWIN_DESC.rst.gbReportData Then
					text += " results"
				End If
				If RSWIN_DESC.rst.gbBatch Then
					text = text + " for " + RSWIN_DESC.rst.Inputfile + ".  Please wait."
				Else
					text += ".  Please wait."
				End If
				Util.Message(text)
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Dim num2 As Integer = 0
				If RSWIN_DESC.rst.gbCoverPage Then
					num2 = 1
				End If
				num2 += 2
				Dim bCheckToAdd As Boolean = False
				Dim flag4 As Boolean = False
				Dim text2 As String = RSWIN.TotalExpertScore(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore, num, bCheckToAdd, flag, flag4, False, False)
				Me.rptExpertSummary = New rptExpertSummary()
				If CDbl(num) >= 0.99 And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.95 And CDbl(RSWIN_DESC.rst.StructL) <= 0.95 Then
					If Not Me.AllScoresOkay(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore) Then
						RSWIN_DESC.bShowScoringPage = True
						bForceDisplay = True
					Else
						RSWIN_DESC.bShowScoringPage = False
					End If
				ElseIf CDbl(num) >= 0.99 And Not Me.AllScoresOkay(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore) Then
					RSWIN_DESC.bShowScoringPage = True
					bForceDisplay = True
				Else
					RSWIN_DESC.bShowScoringPage = True
				End If
				If RSWIN_DESC.rst.gbScoringPage AndAlso RSWIN_DESC.bShowScoringPage Then
					num2 += 1
				End If
				If cRODSTAR.gbReportData Then
					If Operators.CompareString(RSWIN_DESC.SETUP_Language, RSWIN_DESC.sEnglish, False) = 0 Then
						num2 += 1
					Else
						num2 += 2
					End If
				End If
				If cRODSTAR.gbReportCostAnalysis <> 0S Then
					num2 += 1
				End If
				If cRODSTAR.gbReportIPR And cRODSTAR.gbUseIPR Then
					num2 += 1
				End If
				If cRODSTAR.gbOutputLoaded AndAlso (cRODSTAR.gbReportDynoPred Or RSWIN_DESC.rst.NumRods > 10S) Then
					num2 += 1
				End If
				Dim flag5 As Boolean
				Dim text3 As String
				Dim flag6 As Boolean
				Dim text4 As String
				Dim text5 As String
				If(RSWIN_DESC.SETUP_UseImpred And If(-If((RSWIN_DESC.bRodStarD > False), 1S, 0S), 1S, 0S)) <> 0S AndAlso RSWIN_DESC.mdsDeviationProfile IsNot Nothing AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 2 Then
					Try
						MImpred.InitSummaryReportXML(Me.nGuideLines, flag5, text3, flag6, text4, text5)
						flag2 = True
					Catch ex As Exception
					End Try
					Try
						flag3 = MImpred.CheckSurveyForDeviation()
					Catch ex2 As Exception
					End Try
					If RSWIN_DESC.rst.gbReportGuide Or RSWIN_DESC.rst.gbReportDevChart Then
						Dim impredObj As TEImpred = MImpred.ImpredObj
						Try
							RSWIN_DESC.num_rod_elements = impredObj.num_rod_elements
						Catch ex3 As Exception
						End Try
					End If
					If cRODSTAR.gbReportGuide AndAlso flag3 Then
						flag4 = False
						Dim text6 As String = ""
						Dim flag7 As Boolean = False
						Dim text7 As String = ""
						Dim text8 As String = ""
						MImpred.GetReportXMLnPages(Me.nGuideLines, flag4, text6, flag7, text7, text8, sTapersOverMax)
						num2 += RSWIN_DESC.rst.Number_Of_Guide_report_Pages
					End If
					If cRODSTAR.gbReportDevChart Then
						num2 += 2
					End If
					If cRODSTAR.gbReportDevSurvey Or cRODSTAR.gbReportDevChart Then
						Try
							Me.mdsDeviationProfile_Output = Nothing
							MImpred.InitSurveyDataset(Me.mdsDeviationProfile_Output, Nothing)
							MImpred.CopyDatasets(RSWIN_DESC.mdsDeviationProfile, Me.mdsDeviationProfile_Output, RSWIN_DESC.SETUP_MeasurementSystem <> 1, False)
						Catch ex4 As Exception
						End Try
						If Not Me.bDogLegsCalculated Then
							Me.m_bAfterPump1 = False
							Me.m_bAfterPump2 = False
							Me.m_bAfterPump1_report = False
							Me.m_bAfterPump2_report = False
							Me.ShowDeviation_Dogleg(Me.mdsDeviationProfile_Output, False, True)
							Dim num3 As Short
							Me.ShowDeviation_TVD(Me.mdsDeviationProfile_Output, True, num3)
							Me.bDogLegsCalculated = True
						End If
						Me.BuildDeviationProfileXML_from_DS(Me.mdsDeviationProfile_Output, Me.nDevSurveyLines)
						If cRODSTAR.gbReportDevSurvey Then
							num2 += RSWIN_DESC.rst.NumDevSurveyPages
						End If
					End If
				End If
				If RSWIN_DESC.rst.gbOrderPage Then
					num2 += 1
				End If
				Dim num4 As Integer = 0
				If RSWIN_DESC.rst.gbCoverPage Then
					Me.rptCoverPage = New rptCoverPage()
					num4 += 1
					Util.BusyCursor()
					Application.DoEvents()
					Me.rptCoverPage.TotalPageNumber = num2
					Me.rptCoverPage.ThisPageNumber = num4
					Me.rptCoverPage.bPrint = True
					Try
						Me.rptCoverPage.Run(False)
					Catch ex5 As Exception
					End Try
					Me.rptCoverPage.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
					Me.rptCoverPage.Document.Print(False, False)
				End If
				If RSWIN_DESC.rst.gbScoringPage AndAlso RSWIN_DESC.bShowScoringPage Then
					Me.rptExpertSummary = New rptExpertSummary()
					num4 += 1
					Util.BusyCursor()
					Application.DoEvents()
					Me.rptExpertSummary.TotalPageNumber = num2
					Me.rptExpertSummary.ThisPageNumber = num4
					Me.rptExpertSummary.bPrint = False
					Me.rptExpertSummary.bForceDisplay = bForceDisplay
					If RSWIN_DESC.bRodStarD Then
						Me.rptExpertSummary.sTapersOverMax = sTapersOverMax
					End If
					Me.rptExpertSummary.Run(False)
					Me.rptExpertSummary.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
					Me.rptExpertSummary.Document.Print(False, False)
				End If
				If cRODSTAR.gbReportData Then
					If Operators.CompareString(RSWIN_DESC.SETUP_Language, RSWIN_DESC.sEnglish, False) = 0 Then
						If RSWIN_DESC.rst.NumRods > 10S Then
							Me.rptCalcResults_Summary = New rptCalcResults_Summary()
							num4 += 1
							Me.rptCalcResults_Summary.TotalPageNumber = num2
							Me.rptCalcResults_Summary.ThisPageNumber = num4
							Me.rptCalcResults_Summary.bPrint = True
							Me.ExportDynoAndTorqueCharts(True, True, True)
							Me.rptCalcResults_Summary.Run(False)
							Me.rptCalcResults_Summary.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
							Me.rptCalcResults_Summary.Document.Print(False, False)
						Else
							Me.rptCalcResults = New rptCalcResults()
							num4 += 1
							Me.rptCalcResults.TotalPageNumber = num2
							Me.rptCalcResults.ThisPageNumber = num4
							Me.rptCalcResults.bPrint = True
							Me.ExportDynoAndTorqueCharts(True, True, True)
							Me.rptCalcResults.Run(False)
							Me.rptCalcResults.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
							Me.rptCalcResults.Document.Print(False, False)
						End If
					Else
						Me.rptResultsInputs = New rptResultsInputs()
						num4 += 1
						Me.rptResultsInputs.TotalPageNumber = num2
						Me.rptResultsInputs.ThisPageNumber = num4
						Me.rptResultsInputs.bPrint = True
						Me.rptResultsInputs.Run(False)
						Me.rptResultsInputs.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
						Me.rptResultsInputs.Document.Print(False, False)
						Me.rptResultsOutputs = New rptResultsOutputs()
						num4 += 1
						Me.rptResultsOutputs.TotalPageNumber = num2
						Me.rptResultsOutputs.ThisPageNumber = num4
						Me.rptResultsOutputs.bPrint = True
						Me.ExportDynoAndTorqueCharts(True, True, False)
						Me.rptResultsOutputs.Run(False)
						Me.rptResultsOutputs.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
						Me.rptResultsOutputs.Document.Print(False, False)
					End If
				End If
				If cRODSTAR.gbReportCostAnalysis <> 0S Then
					If RSWIN_DESC.bRodStarD And Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
						Me.m_rptCostAnalysis_D = New rptCostAnalysis_D()
						Me.m_rptCostAnalysis_D.bPrint = True
						num4 += 1
						Me.m_rptCostAnalysis_D.TotalPageNumber = num2
						Me.m_rptCostAnalysis_D.ThisPageNumber = num4
						Me.m_rptCostAnalysis_D.Run(False)
						Me.m_rptCostAnalysis_D.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
						Me.m_rptCostAnalysis_D.Document.Print(False, False)
					Else
						Me.m_rptCostAnalysis = New rptCostAnalysis()
						Me.m_rptCostAnalysis.bPrint = True
						num4 += 1
						Me.m_rptCostAnalysis.TotalPageNumber = num2
						Me.m_rptCostAnalysis.ThisPageNumber = num4
						Me.m_rptCostAnalysis.Run(False)
						Me.m_rptCostAnalysis.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
						Me.m_rptCostAnalysis.Document.Print(False, False)
					End If
				End If
				If cRODSTAR.gbReportIPR And cRODSTAR.gbUseIPR Then
					num4 += 1
					Me.IPRPlot.LoadIPRPlot()
					Dim iprreport As IPRReport
					Me.IPRPlot.DisplayIPRPlot(iprreport, num4, num2, True)
				End If
				If cRODSTAR.gbOutputLoaded Then
					If(cRODSTAR.gbReportDynoPred Or RSWIN_DESC.rst.NumRods > 10S) And cRODSTAR.gbReportTorque And cRODSTAR.gbReportSinglePageDynoTorque Then
						num4 += 1
						Me.rptDynoAndTorqueChart = New rptDynoAndTorqueChart()
						Me.rptDynoAndTorqueChart.TotalPageNumber = num2
						Me.rptDynoAndTorqueChart.ThisPageNumber = num4
						Me.rptDynoAndTorqueChart.bPrint = True
						Me.ExportDynoAndTorqueCharts2(True, True, False)
						Me.rptDynoAndTorqueChart.Run(False)
						Me.rptDynoAndTorqueChart.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
						Me.rptDynoAndTorqueChart.Document.Print(False, False)
					End If
					Util.BusyCursor()
					If(RSWIN_DESC.SETUP_UseImpred And If(-If((RSWIN_DESC.bRodStarD > False), 1S, 0S), 1S, 0S)) <> 0S AndAlso RSWIN_DESC.mdsDeviationProfile IsNot Nothing AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 2 Then
						Try
							Me.PlotSurvey()
						Catch ex6 As Exception
						End Try
						If cRODSTAR.gbReportDevChart And RSWIN_DESC.bRodStarD Then
							Dim rptAll As rptAll = New rptAll()
							rptAll.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
							Me.SizeDevCharts()
							Me.rptDeviationSurvey = New rptDeviationSurvey()
							Me.rptDeviationSurvey.bPrint = True
							Me.ExportSideForcesChart(True, True)
							Me.ExportAxialLoadsChart(True, True)
							Me.ExportBucklingTendencyChart(True, True)
							Me.ExportDoglegsChart(True, True)
							Me.fMaxForCharts = Me.FindMaxForCharts()
							Me.ExportSurveyEWChart(True, True)
							Me.ExportSurveyNSChart(True, True)
							Me.ExportSurveyPlanPlotChart(True, True)
							num4 += 1
							Me.rptDeviationSurvey.TotalPageNumber = num2
							Me.rptDeviationSurvey.ThisPageNumber = num4
							Me.rptDeviationSurvey.Run(False)
							Try
								Dim enumerator As IEnumerator = Me.rptDeviationSurvey.Document.Pages.GetEnumerator()
								If enumerator.MoveNext() Then
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(enumerator.Current, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								End If
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
							rptAll.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
							rptAll.Document.Print(False, False)
							If Not flag2 Then
								MImpred.InitSummaryReportXML(Me.nGuideLines, flag5, text3, flag6, text4, text5)
							End If
							Dim tchart1_Report As TChart = Me.TChart1_Report
							Me.ExportDevPlot(tchart1_Report)
							Me.TChart1_Report = tchart1_Report
							Me.rptDevSurvey3DPlot = New rptDevSurvey3DPlot()
							Me.rptDevSurvey3DPlot.TotalPageNumber = num2
							num4 += 1
							Me.rptDevSurvey3DPlot.ThisPageNumber = num4
							Me.rptDevSurvey3DPlot.Run(False)
							Me.rptDevSurvey3DPlot.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
							Me.rptDevSurvey3DPlot.Document.Print(False, False)
						End If
						If Not RSWIN_DESC.rst.gbReportDevChart And RSWIN_DESC.bRodStarD And Not flag2 Then
							MImpred.InitSummaryReportXML(Me.nGuideLines, flag5, text3, flag6, text4, text5)
						End If
						If cRODSTAR.gbReportGuide AndAlso flag3 Then
							If RSWIN_DESC.SETUP_RECOMMEND_GUIDES Or (Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bAllZeroNumGuides) Then
								Me.rptRecommendedGuideReport = New rptRecommendedGuideReport()
							Else
								Me.rptRecommendedGuideReport = New rptRecommendedGuideReport2()
							End If
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bPrint", New Object() { True }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bMaxFootnote", New Object() { flag6 }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sMaxFootnote", New Object() { text4 }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bMinFootnote", New Object() { flag5 }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sMinFootnote", New Object() { text3 }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sGuideMsg", New Object() { text5 }, Nothing, Nothing)
							Try
								Dim xmldataSource As XMLDataSource = New XMLDataSource()
								xmldataSource.LoadXML(RSWIN_DESC.sSummaryDataSetXML)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object() { xmldataSource }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "DataSource", New Object() { xmldataSource }, Nothing, Nothing)
							Catch ex7 As Exception
							End Try
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "ValidateOnParse", New Object() { True }, Nothing, Nothing, False, True)
							CType(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), XMLDataSource).RecordsetPattern = "//Data/Entries/Row"
							num4 += 1
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "TotalPageNumber", New Object() { num2 }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "ThisPageNumber", New Object() { num4 }, Nothing, Nothing)
							NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "NumberOfLines", New Object() { Me.nGuideLines }, Nothing, Nothing)
							NewLateBinding.LateCall(Me.rptRecommendedGuideReport, Nothing, "Run", New Object() { False }, Nothing, Nothing, Nothing, True)
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Printer", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "PrinterSettings", New Object() { RSWIN_DESC.pd.PrinterSettings }, Nothing, Nothing, False, True)
							NewLateBinding.LateCall(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Print", New Object() { False, False }, Nothing, Nothing, Nothing, True)
						End If
						If RSWIN_DESC.rst.gbReportDevSurvey Then
							Util.BusyCursor()
							Application.DoEvents()
							Me.rptDeviationProfile = New rptDeviationProfile()
							Me.rptDeviationProfile.bPrint = False
							Try
								Dim xmldataSource2 As XMLDataSource = New XMLDataSource()
								xmldataSource2.LoadXML(RSWIN_DESC.sDeviationProfileXML)
								Me.rptDeviationProfile.ds = xmldataSource2
								Me.rptDeviationProfile.DataSource = xmldataSource2
							Catch ex8 As Exception
							End Try
							Me.rptDeviationProfile.ds.ValidateOnParse = True
							Me.rptDeviationProfile.ds.RecordsetPattern = "//Data/Entries/Row"
							Me.rptDeviationProfile.TotalPageNumber = num2
							If RSWIN_DESC.rst.gbReportGuide AndAlso flag3 Then
								num4 += RSWIN_DESC.rst.Number_Of_Guide_report_Pages
							Else
								num4 += 1
							End If
							Me.rptDeviationProfile.ThisPageNumber = num4
							Me.rptDeviationProfile.NumberOfLines = Me.nDevSurveyLines
							Me.rptDeviationProfile.Run(False)
							Me.rptDeviationProfile.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
							Me.rptDeviationProfile.Document.Print(False, False)
							num4 = num4 + CInt(Math.Round(CDbl(Me.nDevSurveyLines) / 35.0)) - 1
						End If
					End If
					If RSWIN_DESC.rst.gbOrderPage Then
						Me.rptOrderPage = New rptOrderForm()
						num4 += 1
						Util.BusyCursor()
						Application.DoEvents()
						Me.rptOrderPage.TotalPageNumber = num2
						Me.rptOrderPage.ThisPageNumber = num4
						Me.rptOrderPage.bPrint = True
						Try
							Me.rptOrderPage.Run(False)
						Catch ex9 As Exception
						End Try
						Me.rptOrderPage.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
						Me.rptOrderPage.Document.Print(False, False)
					End If
				End If
				cRODSTAR = Nothing
			Catch ex10 As Exception
			End Try
		End Sub

		Public Sub ExportDynoAndTorqueCharts2(bImport As Boolean, bExport As Boolean, Optional bUseLandscape As Boolean = False)
			Dim chart As ChartFX.WinForms.Chart
			If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
				chart = Me.ChartFX_Temp_Dyno_L
				Me.DisplayDyno_Animate(chart, True, False, False)
				Me.ChartFX_Temp_Dyno_L = chart
			Else
				chart = Me.ChartFX_Temp_Dyno_L
				Me.DisplayDyno(chart, True, False)
				Me.ChartFX_Temp_Dyno_L = chart
			End If
			Me.ChartFX_Temp_Dyno_L.Refresh()
			If bExport Then
				Dim text As String = Me.RandomClass.NextDouble().ToString()
				text = text.Replace(".", "")
				Try
					If Not Directory.Exists(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName()) Then
						Directory.CreateDirectory(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName())
					End If
				Catch ex As Exception
				End Try
				RSWIN_DESC.sTempDynoPlotLFileName = String.Concat(New String() { RSWIN_DESC.sPathThetaData, "\", VERSION1.ProgramName(), "\", text.Trim(), "_TempDynoPlotL.bmp" })
				Dim text2 As String = RSWIN_DESC.sTempDynoPlotLFileName
				Dim flag As Boolean = FILEUTIL.FileExists(text2)
				RSWIN_DESC.sTempDynoPlotLFileName = text2
				If flag Then
					Try
						FileSystem.Kill(RSWIN_DESC.sTempDynoPlotLFileName)
					Catch ex2 As Exception
					End Try
				End If
				Try
					Me.ChartFX_Temp_Dyno_L.Export(FileFormat.Bitmap, RSWIN_DESC.sTempDynoPlotLFileName)
				Catch ex3 As Exception
					Me.DoSeveralDoEvents()
					Me.ChartFX_Temp_Dyno_L.Export(FileFormat.Bitmap, RSWIN_DESC.sTempDynoPlotLFileName)
				End Try
			End If
			If bImport Then
				Try
					If bUseLandscape Then
						Me.rptDynoAndTorqueChart_Landscape.ImportDynoChart()
					Else
						Me.rptDynoAndTorqueChart.ImportDynoChart()
					End If
				Catch ex4 As Exception
					Me.DoSeveralDoEvents()
					If bUseLandscape Then
						Me.rptDynoAndTorqueChart_Landscape.ImportDynoChart()
					Else
						Me.rptDynoAndTorqueChart.ImportDynoChart()
					End If
				End Try
			End If
			chart = Me.ChartFX_Temp_Torque_L
			Me.PlotTorqueData(chart, True)
			Me.ChartFX_Temp_Torque_L = chart
			Me.ChartFX_Temp_Torque_L.Refresh()
			If bExport Then
				Dim text As String = Me.RandomClass.NextDouble().ToString()
				text = text.Replace(".", "")
				Try
					If Not Directory.Exists(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName()) Then
						Directory.CreateDirectory(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName())
					End If
				Catch ex5 As Exception
				End Try
				RSWIN_DESC.sTempTorquePlotLFileName = String.Concat(New String() { RSWIN_DESC.sPathThetaData, "\", VERSION1.ProgramName(), "\", text.Trim(), "_TempTorquePlotL.bmp" })
				Dim text2 As String = RSWIN_DESC.sTempTorquePlotLFileName
				Dim flag2 As Boolean = FILEUTIL.FileExists(text2)
				RSWIN_DESC.sTempTorquePlotLFileName = text2
				If flag2 Then
					Try
						FileSystem.Kill(RSWIN_DESC.sTempTorquePlotLFileName)
					Catch ex6 As Exception
					End Try
				End If
				Try
					Me.ChartFX_Temp_Torque_L.Export(FileFormat.Bitmap, RSWIN_DESC.sTempTorquePlotLFileName)
				Catch ex7 As Exception
					Me.DoSeveralDoEvents()
					Me.ChartFX_Temp_Torque_L.Export(FileFormat.Bitmap, RSWIN_DESC.sTempTorquePlotLFileName)
				End Try
			End If
			If bImport Then
				Try
					If bUseLandscape Then
						Me.rptDynoAndTorqueChart_Landscape.ImportTorquePlotChart()
					Else
						Me.rptDynoAndTorqueChart.ImportTorquePlotChart()
					End If
				Catch ex8 As Exception
					Me.DoSeveralDoEvents()
					If bUseLandscape Then
						Me.rptDynoAndTorqueChart_Landscape.ImportTorquePlotChart()
					Else
						Me.rptDynoAndTorqueChart.ImportTorquePlotChart()
					End If
				End Try
			End If
		End Sub

		Public Sub ExportDynoAndTorqueCharts(bImport As Boolean, bExport As Boolean, Optional bOnePage As Boolean = True)
			Try
				Dim chart As ChartFX.WinForms.Chart
				If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
					chart = Me.ChartFX_Temp_Dyno
					Me.DisplayDyno_Animate(chart, False, False, False)
					Me.ChartFX_Temp_Dyno = chart
				Else
					chart = Me.ChartFX_Temp_Dyno
					Me.DisplayDyno(chart, False, False)
					Me.ChartFX_Temp_Dyno = chart
				End If
				Me.ChartFX_Temp_Dyno.Refresh()
				Application.DoEvents()
				Me.Refresh()
				Application.DoEvents()
				If bExport Then
					Dim text As String = Me.RandomClass.NextDouble().ToString()
					text = text.Replace(".", "")
					Try
						If Not Directory.Exists(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName()) Then
							Directory.CreateDirectory(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName())
						End If
					Catch ex As Exception
					End Try
					RSWIN_DESC.sTempDynoPlotFileName = String.Concat(New String() { RSWIN_DESC.sPathThetaData, "\", VERSION1.ProgramName(), "\", text.Trim(), "_TempDynoPlot.bmp" })
					Dim text2 As String = RSWIN_DESC.sTempDynoPlotFileName
					Dim flag As Boolean = FILEUTIL.FileExists(text2)
					RSWIN_DESC.sTempDynoPlotFileName = text2
					If flag Then
						Try
							FileSystem.Kill(RSWIN_DESC.sTempDynoPlotFileName)
						Catch ex2 As Exception
						End Try
					End If
					Try
						Me.ChartFX_Temp_Dyno.Export(FileFormat.Bitmap, RSWIN_DESC.sTempDynoPlotFileName)
					Catch ex3 As Exception
						Me.DoSeveralDoEvents()
						Me.ChartFX_Temp_Dyno.Export(FileFormat.Bitmap, RSWIN_DESC.sTempDynoPlotFileName)
					End Try
				End If
				If bImport Then
					Try
						If bOnePage Then
							Me.rptCalcResults.ImportDynoChart()
						Else
							Me.rptResultsOutputs.ImportDynoChart()
						End If
					Catch ex4 As Exception
						Me.DoSeveralDoEvents()
						If bOnePage Then
							Me.rptCalcResults.ImportDynoChart()
						Else
							Me.rptResultsOutputs.ImportDynoChart()
						End If
					End Try
				End If
				chart = Me.ChartFX_Temp_TorquePlot
				Me.PlotTorqueData(chart, False)
				Me.ChartFX_Temp_TorquePlot = chart
				Me.ChartFX_Temp_TorquePlot.Refresh()
				Application.DoEvents()
				Me.Refresh()
				Application.DoEvents()
				If bExport Then
					Dim text As String = Me.RandomClass.NextDouble().ToString()
					text = text.Replace(".", "")
					Try
						If Not Directory.Exists(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName()) Then
							Directory.CreateDirectory(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName())
						End If
					Catch ex5 As Exception
					End Try
					RSWIN_DESC.sTempTorquePlotFileName = String.Concat(New String() { RSWIN_DESC.sPathThetaData, "\", VERSION1.ProgramName(), "\", text.Trim(), "_TempTorquePlot.bmp" })
					Dim text2 As String = RSWIN_DESC.sTempTorquePlotFileName
					Dim flag2 As Boolean = FILEUTIL.FileExists(text2)
					RSWIN_DESC.sTempTorquePlotFileName = text2
					If flag2 Then
						Try
							FileSystem.Kill(RSWIN_DESC.sTempTorquePlotFileName)
						Catch ex6 As Exception
						End Try
					End If
					Try
						Me.ChartFX_Temp_TorquePlot.Export(FileFormat.Bitmap, RSWIN_DESC.sTempTorquePlotFileName)
					Catch ex7 As Exception
						Me.DoSeveralDoEvents()
						Me.ChartFX_Temp_TorquePlot.Export(FileFormat.Bitmap, RSWIN_DESC.sTempTorquePlotFileName)
					End Try
				End If
				If bImport Then
					Try
						If bOnePage Then
							Me.rptCalcResults.ImportTorquePlotChart()
						Else
							Me.rptResultsOutputs.ImportTorquePlotChart()
						End If
					Catch ex8 As Exception
						Me.DoSeveralDoEvents()
						If bOnePage Then
							Me.rptCalcResults.ImportTorquePlotChart()
						Else
							Me.rptResultsOutputs.ImportTorquePlotChart()
						End If
					End Try
				End If
			Catch ex9 As Exception
			End Try
		End Sub

		Public Sub PrintTorquePlots(bOnePage As Boolean)
			Me.pnlTorquePlot.Visible = False
			Dim chartFX_TorquePlot As ChartFX.WinForms.Chart = Me.ChartFX_TorquePlot
			Me.PlotTorqueData(chartFX_TorquePlot, True)
			Me.ChartFX_TorquePlot = chartFX_TorquePlot
			Me.ChartFX_TorquePlot.Printer.Orientation = ChartFX.WinForms.PageOrientation.Landscape
			Me.ChartFX_TorquePlot.Printer.ForceColors = True
			Me.ChartFX_TorquePlot.Printer.Margins.Right = 200
			Me.ChartFX_TorquePlot.Printer.Margins.Left = 200
			Me.ChartFX_TorquePlot.Printer.Margins.Top = 200
			Me.ChartFX_TorquePlot.Printer.Margins.Bottom = 200
			Me.ChartFX_TorquePlot.Printer.Print()
		End Sub

		Public Sub PrintDyno(bOnePage As Boolean)
			Me.pnlDyno.Visible = False
			If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
				Dim chartFX_Dyno As ChartFX.WinForms.Chart = Me.ChartFX_Dyno
				Me.DisplayDyno_Animate(chartFX_Dyno, True, True, False)
				Me.ChartFX_Dyno = chartFX_Dyno
			Else
				Dim chartFX_Dyno As ChartFX.WinForms.Chart = Me.ChartFX_Dyno
				Me.DisplayDyno(chartFX_Dyno, True, True)
				Me.ChartFX_Dyno = chartFX_Dyno
			End If
			Me.ChartFX_Dyno.Printer.Orientation = ChartFX.WinForms.PageOrientation.Landscape
			Me.ChartFX_Dyno.Printer.ForceColors = True
			Me.ChartFX_Dyno.Printer.Margins.Right = 200
			Me.ChartFX_Dyno.Printer.Margins.Left = 200
			Me.ChartFX_Dyno.Printer.Margins.Top = 200
			Me.ChartFX_Dyno.Printer.Margins.Bottom = 200
			Me.ChartFX_Dyno.Printer.Print()
		End Sub

		Private Sub cmdIPRPlot_Click(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.IPRPlot.ShowDialog()
		End Sub

		Private Sub ctxMenu_DynoPlot_Clicked(sender As Object, e As EventArgs)
			Dim menuItem As MenuItem = CType(sender, MenuItem)
			RSWIN_DESC.DEBUG_DynoPlotStyle = 0S
			If Not menuItem.Checked Then
				menuItem.Checked = True
			Else
				menuItem.Checked = False
			End If
			Dim num As Integer
			Dim obj As Object
			If menuItem Is Me.menuItem1 Then
				num = 0
				obj = 1
			ElseIf menuItem Is Me.menuItem2 Then
				num = 1
				obj = 2
			ElseIf menuItem Is Me.menuItem3 Then
				num = 2
				obj = 4
			ElseIf menuItem Is Me.menuItem4 Then
				num = 3
				obj = 8
			ElseIf menuItem Is Me.menuItem5 Then
				num = 4
				obj = 16
			ElseIf menuItem Is Me.menuItem6 Then
				num = 5
				obj = 32
			ElseIf menuItem Is Me.menuItem7 Then
				num = 6
				obj = 64
			End If
			If menuItem.Checked Then
				Me.mnuDPlot(num) = RuntimeHelpers.GetObjectValue(obj)
			Else
				Me.mnuDPlot(num) = 0
			End If
			RSWIN_DESC.DEBUG_DynoPlotStyle = 0S
			Dim num2 As Integer = 0
			Do
				RSWIN_DESC.DEBUG_DynoPlotStyle = Conversions.ToShort(Operators.OrObject(RSWIN_DESC.DEBUG_DynoPlotStyle, Me.mnuDPlot(num2)))
				num2 += 1
			Loop While num2 <= 6
			Dim chartFX_Dyno As ChartFX.WinForms.Chart
			If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
				chartFX_Dyno = Me.ChartFX_Dyno
				Me.DisplayDyno_Animate(chartFX_Dyno, True, True, False)
				Me.ChartFX_Dyno = chartFX_Dyno
				Return
			End If
			chartFX_Dyno = Me.ChartFX_Dyno
			Me.DisplayDyno(chartFX_Dyno, True, True)
			Me.ChartFX_Dyno = chartFX_Dyno
		End Sub

		Private Sub PopulateDynoPlotContextMenu()
			Dim num As Integer = 0
			Do
				Me.mnuDPlot(num) = 0
				num += 1
			Loop While num <= 6
			Me.ctxMenu_DynoPlot.MenuItems.Clear()
			Me.menuItem1 = New MenuItem("Surface Card (actual)", AddressOf Me.ctxMenu_DynoPlot_Clicked)
			Me.menuItem1.Checked = True
			Me.ctxMenu_DynoPlot.MenuItems.Add(Me.menuItem1)
			RSWIN_DESC.DEBUG_DynoPlotStyle = RSWIN_DESC.DEBUG_DynoPlotStyle Or 1S
			Me.mnuDPlot(0) = 1
			If RSWIN_DESC.rst.pNtsteps <> 0S Then
				Me.menuItem2 = New MenuItem("Surface Card (predicted)", AddressOf Me.ctxMenu_DynoPlot_Clicked)
				Me.menuItem2.Checked = True
				Me.ctxMenu_DynoPlot.MenuItems.Add(Me.menuItem2)
				RSWIN_DESC.DEBUG_DynoPlotStyle = RSWIN_DESC.DEBUG_DynoPlotStyle Or 2S
				Me.mnuDPlot(1) = 2
			End If
			Me.menuItem3 = New MenuItem("Downhole Card (actual)", AddressOf Me.ctxMenu_DynoPlot_Clicked)
			Me.menuItem3.Checked = True
			Me.ctxMenu_DynoPlot.MenuItems.Add(Me.menuItem3)
			RSWIN_DESC.DEBUG_DynoPlotStyle = RSWIN_DESC.DEBUG_DynoPlotStyle Or 4S
			Me.mnuDPlot(2) = 4
			If RSWIN_DESC.rst.zNtsteps <> 0S Then
				Me.menuItem4 = New MenuItem("Downhole Card (no FI effects)", AddressOf Me.ctxMenu_DynoPlot_Clicked)
				Me.menuItem4.Checked = True
				Me.ctxMenu_DynoPlot.MenuItems.Add(Me.menuItem4)
				RSWIN_DESC.DEBUG_DynoPlotStyle = RSWIN_DESC.DEBUG_DynoPlotStyle Or 8S
				Me.mnuDPlot(3) = 8
			End If
			Me.menuItem5 = New MenuItem("Permissible Load Diagram", AddressOf Me.ctxMenu_DynoPlot_Clicked)
			Me.menuItem5.Checked = True
			Me.ctxMenu_DynoPlot.MenuItems.Add(Me.menuItem5)
			RSWIN_DESC.DEBUG_DynoPlotStyle = RSWIN_DESC.DEBUG_DynoPlotStyle Or 16S
			Me.mnuDPlot(4) = 16
			If(Not(RSWIN_DESC.rst.LineSettings(1).LSet And RSWIN_DESC.rst.LineSettings(2).LSet) And Not(RSWIN_DESC.rst.LineSettings(3).LSet And RSWIN_DESC.rst.LineSettings(4).LSet)) = 0S Then
				Me.menuItem6 = New MenuItem("Line Settings", AddressOf Me.ctxMenu_DynoPlot_Clicked)
				Me.menuItem6.Checked = True
				Me.ctxMenu_DynoPlot.MenuItems.Add(Me.menuItem6)
				RSWIN_DESC.DEBUG_DynoPlotStyle = RSWIN_DESC.DEBUG_DynoPlotStyle Or 32S
				Me.mnuDPlot(5) = 32
			End If
			If RSWIN_DESC.rst.g_NtstepsNoTubing <> 0S Then
				Me.menuItem7 = New MenuItem("Downhole Card (no tub. mov. effects)", AddressOf Me.ctxMenu_DynoPlot_Clicked)
				Me.menuItem7.Checked = True
				Me.ctxMenu_DynoPlot.MenuItems.Add(Me.menuItem7)
				RSWIN_DESC.DEBUG_DynoPlotStyle = RSWIN_DESC.DEBUG_DynoPlotStyle Or 64S
				Me.mnuDPlot(6) = 64
			End If
		End Sub

		Private Sub btnDebug_Click(sender As Object, e As EventArgs)
			Me.optReport_Click_1(4S, True, True)
		End Sub

		Public Sub UnloadAllFormsExceptMe()
			Try
				For Each form As Form In Me.ParentForm.MdiChildren
					Try
						If form IsNot Nothing AndAlso (Operators.CompareString(form.Name, Me.Name, False) <> 0 And Operators.CompareString(form.Name, "VisInput", False) <> 0) Then
							form.Hide()
						End If
					Catch ex As Exception
					End Try
				Next
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub InitTrackbar()
			Try
				Me.TrackBar1.TickFrequency = 1
				Me.TrackBar1.SmallChange = 1
				Me.TrackBar1.LargeChange = 2
				If RSWIN_DESC.bRodStarD Then
					Me.TrackBar1.Minimum = 0
					Me.TrackBar1.Maximum = 5
				Else
					Me.TrackBar1.Minimum = 0
					Me.TrackBar1.Maximum = 10
				End If
				Me.TrackBar1.TickStyle = TickStyle.None
				Me.TrackBar1.AutoSize = False
				Me.TrackBar1.Height = 16
				Me.TrackBar1.Visible = False
			Catch ex As Exception
			End Try
		End Sub

		Private Sub pnlDyno_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)
			Try
				If Me.TrackBar1.Value > 0 Then
					' The following expression was wrapped in a checked-expression
					Me.nSkip = Me.nInitialSkip + Me.TrackBar1.Value
				End If
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
			Catch ex As Exception
			End Try
		End Sub

		Public Sub StorePDFFile(sPDFFilename As String)
			Dim rptAll As rptAll = New rptAll()
			Dim flag As Boolean = False
			Dim bForceDisplay As Boolean = False
			Dim iGBScore As Integer = 0
			Dim iRLScore As Integer = 0
			Dim iSLScore As Integer = 0
			Dim iSEffScore As Integer = 0
			Dim iBotMinStressScore As Integer = 0
			Dim iMPRLScore As Integer = 0
			Dim num As Single = 0F
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = Me.Visible
			Dim flag4 As Boolean = False
			Dim sTapersOverMax As String = ""
			Try
				If RSWIN_DESC.rst.gbBatch Then
					flag3 = False
				End If
				rptAll.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
				Util.BusyCursor()
				Dim text As String = "Saving"
				If RSWIN_DESC.rst.gbReportData Then
					text += " results"
				End If
				Util.Message(text)
				rptAll.Run()
				rptAll.Document.Pages.Clear()
				Dim num2 As Integer = 0
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				num2 = 0
				If RSWIN_DESC.rst.gbCoverPage Then
					num2 = 1
				End If
				If Not flag3 Then
					Me.rptExpertSummary = New rptExpertSummary()
					Me.rptExpertSummary.bForceDisplay = False
					If RSWIN_DESC.bRodStarD Then
						Me.rptExpertSummary.sTapersOverMax = sTapersOverMax
					End If
					Me.rptExpertSummary.Run()
				End If
				Dim bCheckToAdd As Boolean = False
				Dim flag5 As Boolean = False
				Dim text2 As String = RSWIN.TotalExpertScore(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore, num, bCheckToAdd, flag, flag5, False, False)
				If CDbl(num) >= 0.99 And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.95 And CDbl(RSWIN_DESC.rst.StructL) <= 0.95 Then
					If Not Me.AllScoresOkay(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore) Then
						RSWIN_DESC.bShowScoringPage = True
						bForceDisplay = True
					Else
						RSWIN_DESC.bShowScoringPage = False
					End If
				ElseIf CDbl(num) >= 0.99 And Not Me.AllScoresOkay(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore) Then
					RSWIN_DESC.bShowScoringPage = True
					bForceDisplay = True
				Else
					RSWIN_DESC.bShowScoringPage = True
				End If
				If RSWIN_DESC.rst.gbScoringPage AndAlso RSWIN_DESC.bShowScoringPage Then
					num2 += 1
				End If
				If cRODSTAR.gbReportData Then
					If Operators.CompareString(RSWIN_DESC.SETUP_Language, RSWIN_DESC.sEnglish, False) = 0 Then
						num2 += 1
					Else
						num2 += 2
					End If
				End If
				If cRODSTAR.gbReportCostAnalysis <> 0S Then
					num2 += 1
				End If
				If RSWIN_DESC.rst.gbOrderPage Then
					num2 += 1
				End If
				If cRODSTAR.gbReportIPR And cRODSTAR.gbUseIPR Then
					num2 += 1
				End If
				If cRODSTAR.gbOutputLoaded AndAlso (cRODSTAR.gbReportDynoPred Or RSWIN_DESC.rst.NumRods > 10S) Then
					num2 += 1
				End If
				Dim flag6 As Boolean
				Dim text3 As String
				Dim flag7 As Boolean
				Dim text4 As String
				Dim text5 As String
				If(RSWIN_DESC.SETUP_UseImpred And If(-If((RSWIN_DESC.bRodStarD > False), 1S, 0S), 1S, 0S)) <> 0S AndAlso RSWIN_DESC.mdsDeviationProfile IsNot Nothing AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 2 Then
					Try
						MImpred.InitSummaryReportXML(Me.nGuideLines, flag6, text3, flag7, text4, text5)
						flag2 = True
					Catch ex As Exception
					End Try
					Try
						flag4 = MImpred.CheckSurveyForDeviation()
					Catch ex2 As Exception
					End Try
					If RSWIN_DESC.rst.gbReportGuide Or RSWIN_DESC.rst.gbReportDevChart Then
						Dim impredObj As TEImpred = MImpred.ImpredObj
						Try
							RSWIN_DESC.num_rod_elements = impredObj.num_rod_elements
						Catch ex3 As Exception
						End Try
					End If
					If(cRODSTAR.gbReportGuide And RSWIN_DESC.bRodStarD) AndAlso flag4 Then
						flag5 = False
						Dim text6 As String = ""
						Dim flag8 As Boolean = False
						Dim text7 As String = ""
						Dim text8 As String = ""
						MImpred.GetReportXMLnPages(Me.nGuideLines, flag5, text6, flag8, text7, text8, sTapersOverMax)
						num2 += RSWIN_DESC.rst.Number_Of_Guide_report_Pages
					End If
					If cRODSTAR.gbReportDevChart And RSWIN_DESC.bRodStarD Then
						num2 += 2
					End If
					If cRODSTAR.gbReportDevSurvey Or cRODSTAR.gbReportDevChart Then
						If Not flag3 Then
							Try
								Me.mdsDeviationProfile_Output = Nothing
								MImpred.InitSurveyDataset(Me.mdsDeviationProfile_Output, Nothing)
								MImpred.CopyDatasets(RSWIN_DESC.mdsDeviationProfile, Me.mdsDeviationProfile_Output, RSWIN_DESC.SETUP_MeasurementSystem <> 1, False)
							Catch ex4 As Exception
							End Try
							If Not Me.bDogLegsCalculated Then
								Me.m_bAfterPump1 = False
								Me.m_bAfterPump2 = False
								Me.m_bAfterPump1_report = False
								Me.m_bAfterPump2_report = False
								Me.ShowDeviation_Dogleg(Me.mdsDeviationProfile_Output, False, True)
								Dim num3 As Short
								Me.ShowDeviation_TVD(Me.mdsDeviationProfile_Output, True, num3)
								Me.bDogLegsCalculated = True
							End If
							Me.BuildDeviationProfileXML_from_DS(Me.mdsDeviationProfile_Output, Me.nDevSurveyLines)
						End If
						If cRODSTAR.gbReportDevSurvey Then
							num2 += RSWIN_DESC.rst.NumDevSurveyPages
						End If
					End If
				End If
				Dim num4 As Integer = 0
				If RSWIN_DESC.rst.gbCoverPage Then
					num4 += 1
					If Not flag3 Then
						Me.rptCoverPage = New rptCoverPage()
						Util.BusyCursor()
						Application.DoEvents()
						Me.rptCoverPage.TotalPageNumber = num2
						Me.rptCoverPage.ThisPageNumber = num4
						Me.rptCoverPage.bPrint = False
						Try
							Me.rptCoverPage.Run(False)
						Catch ex5 As Exception
						End Try
					End If
					Try
						For Each obj As Object In Me.rptCoverPage.Document.Pages
							Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj, DataDynamics.ActiveReports.Document.Page)
							rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				If RSWIN_DESC.rst.gbScoringPage AndAlso RSWIN_DESC.bShowScoringPage Then
					num4 += 1
					If Not flag3 Then
						Me.rptExpertSummary = New rptExpertSummary()
						Util.BusyCursor()
						Application.DoEvents()
						Me.rptExpertSummary.TotalPageNumber = num2
						Me.rptExpertSummary.ThisPageNumber = num4
						Me.rptExpertSummary.bPrint = False
						Me.rptExpertSummary.bForceDisplay = bForceDisplay
						If RSWIN_DESC.bRodStarD Then
							Me.rptExpertSummary.sTapersOverMax = sTapersOverMax
						End If
						Me.rptExpertSummary.Run(False)
						Util.BusyCursor()
					End If
					Try
						For Each obj2 As Object In Me.rptExpertSummary.Document.Pages
							Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj2, DataDynamics.ActiveReports.Document.Page)
							rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
				End If
				If cRODSTAR.gbReportData Then
					If Operators.CompareString(RSWIN_DESC.SETUP_Language, RSWIN_DESC.sEnglish, False) = 0 Then
						num4 += 1
						Dim num5 As Integer
						If RSWIN_DESC.rst.gbSummaryPage Or RSWIN_DESC.rst.NumRods > 10S Or (RSWIN_DESC.rst.NumRods > 8S And RSWIN.bHasRelocatedSB(num5)) Then
							Me.rptCalcResults_Summary = New rptCalcResults_Summary()
							Me.rptCalcResults_Summary.TotalPageNumber = num2
							Me.rptCalcResults_Summary.ThisPageNumber = num4
							Me.rptCalcResults_Summary.bPrint = False
							Me.ExportDynoAndTorqueCharts(True, True, True)
							Me.rptCalcResults_Summary.Run(False)
							Util.BusyCursor()
							Try
								For Each obj3 As Object In Me.rptCalcResults_Summary.Document.Pages
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj3, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								Next
								GoTo IL_98C
							Finally
								Dim enumerator3 As IEnumerator
								If TypeOf enumerator3 Is IDisposable Then
									TryCast(enumerator3, IDisposable).Dispose()
								End If
							End Try
						End If
						Me.rptCalcResults = New rptCalcResults()
						Me.rptCalcResults.TotalPageNumber = num2
						Me.rptCalcResults.ThisPageNumber = num4
						Me.rptCalcResults.bPrint = False
						Me.ExportDynoAndTorqueCharts(True, True, True)
						Me.rptCalcResults.Run(False)
						Util.BusyCursor()
						Try
							For Each obj4 As Object In Me.rptCalcResults.Document.Pages
								Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj4, DataDynamics.ActiveReports.Document.Page)
								rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
							Next
						Finally
							Dim enumerator4 As IEnumerator
							If TypeOf enumerator4 Is IDisposable Then
								TryCast(enumerator4, IDisposable).Dispose()
							End If
						End Try
					Else
						Me.rptResultsInputs = New rptResultsInputs()
						Me.rptResultsInputs.TotalPageNumber = num2
						num4 += 1
						Me.rptResultsInputs.ThisPageNumber = num4
						Me.rptResultsInputs.bPrint = False
						Me.rptResultsInputs.Run(False)
						Util.BusyCursor()
						Try
							For Each obj5 As Object In Me.rptResultsInputs.Document.Pages
								Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj5, DataDynamics.ActiveReports.Document.Page)
								rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
							Next
						Finally
							Dim enumerator5 As IEnumerator
							If TypeOf enumerator5 Is IDisposable Then
								TryCast(enumerator5, IDisposable).Dispose()
							End If
						End Try
						Me.rptResultsOutputs = New rptResultsOutputs()
						Me.rptResultsOutputs.TotalPageNumber = num2
						num4 += 1
						Me.rptResultsOutputs.ThisPageNumber = num4
						Me.rptResultsOutputs.bPrint = False
						Me.ExportDynoAndTorqueCharts(True, True, False)
						Me.rptResultsOutputs.Run(False)
						Util.BusyCursor()
						Dim num6 As Integer = 0
						Try
							For Each obj6 As Object In Me.rptResultsOutputs.Document.Pages
								Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj6, DataDynamics.ActiveReports.Document.Page)
								num6 += 1
								If num6 = 1 Then
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								End If
							Next
						Finally
							Dim enumerator6 As IEnumerator
							If TypeOf enumerator6 Is IDisposable Then
								TryCast(enumerator6, IDisposable).Dispose()
							End If
						End Try
					End If
				End If
				IL_98C:
				Util.BusyCursor()
				If cRODSTAR.gbOutputLoaded Then
					If cRODSTAR.gbReportDynoPred Or RSWIN_DESC.rst.NumRods > 10S Then
						Me.rptDynoAndTorqueChart = New rptDynoAndTorqueChart()
						Me.rptDynoAndTorqueChart.TotalPageNumber = num2
						num4 += 1
						Me.rptDynoAndTorqueChart.ThisPageNumber = num4
						Me.rptDynoAndTorqueChart.bPrint = True
						Me.ExportDynoAndTorqueCharts2(True, True, False)
						Me.rptDynoAndTorqueChart.Run(False)
						Try
							For Each obj7 As Object In Me.rptDynoAndTorqueChart.Document.Pages
								Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj7, DataDynamics.ActiveReports.Document.Page)
								rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
							Next
						Finally
							Dim enumerator7 As IEnumerator
							If TypeOf enumerator7 Is IDisposable Then
								TryCast(enumerator7, IDisposable).Dispose()
							End If
						End Try
					End If
					If RSWIN_DESC.rst.gbReportCostAnalysis <> 0S Then
						If RSWIN_DESC.bRodStarD And Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
							num4 += 1
							If Not flag3 Then
								Me.m_rptCostAnalysis_D = New rptCostAnalysis_D()
								Me.m_rptCostAnalysis_D.bPrint = False
								Me.m_rptCostAnalysis_D.TotalPageNumber = num2
								Me.m_rptCostAnalysis_D.ThisPageNumber = num4
								Me.m_rptCostAnalysis_D.Run(False)
							End If
							Try
								For Each obj8 As Object In Me.m_rptCostAnalysis_D.Document.Pages
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj8, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								Next
								GoTo IL_C0C
							Finally
								Dim enumerator8 As IEnumerator
								If TypeOf enumerator8 Is IDisposable Then
									TryCast(enumerator8, IDisposable).Dispose()
								End If
							End Try
						End If
						num4 += 1
						If Not flag3 Then
							Me.m_rptCostAnalysis = New rptCostAnalysis()
							Me.m_rptCostAnalysis.bPrint = False
							Me.m_rptCostAnalysis.TotalPageNumber = num2
							Me.m_rptCostAnalysis.ThisPageNumber = num4
							Me.m_rptCostAnalysis.Run(False)
						End If
						Try
							For Each obj9 As Object In Me.m_rptCostAnalysis.Document.Pages
								Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj9, DataDynamics.ActiveReports.Document.Page)
								rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
							Next
						Finally
							Dim enumerator9 As IEnumerator
							If TypeOf enumerator9 Is IDisposable Then
								TryCast(enumerator9, IDisposable).Dispose()
							End If
						End Try
					End If
					IL_C0C:
					If RSWIN_DESC.rst.gbOrderPage Then
						num4 += 1
						If Not flag3 Then
							Me.rptOrderPage = New rptOrderForm()
							Util.BusyCursor()
							Application.DoEvents()
							Me.rptOrderPage.TotalPageNumber = num2
							Me.rptOrderPage.ThisPageNumber = num4
							Me.rptOrderPage.bPrint = False
							Try
								Me.rptOrderPage.Run(False)
							Catch ex6 As Exception
							End Try
						End If
						Try
							For Each obj10 As Object In Me.rptOrderPage.Document.Pages
								Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj10, DataDynamics.ActiveReports.Document.Page)
								rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
							Next
						Finally
							Dim enumerator10 As IEnumerator
							If TypeOf enumerator10 Is IDisposable Then
								TryCast(enumerator10, IDisposable).Dispose()
							End If
						End Try
					End If
					If cRODSTAR.gbReportIPR And cRODSTAR.gbUseIPR Then
						num4 += 1
						Me.IPRPlot.LoadIPRPlot()
						Dim iprreport As IPRReport
						Me.IPRPlot.DisplayIPRPlot(iprreport, num4, num2, False)
						Try
							For Each obj11 As Object In iprreport.Document.Pages
								Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj11, DataDynamics.ActiveReports.Document.Page)
								rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
							Next
						Finally
							Dim enumerator11 As IEnumerator
							If TypeOf enumerator11 Is IDisposable Then
								TryCast(enumerator11, IDisposable).Dispose()
							End If
						End Try
					End If
					If(RSWIN_DESC.SETUP_UseImpred And If(-If((RSWIN_DESC.bRodStarD > False), 1S, 0S), 1S, 0S)) <> 0S AndAlso RSWIN_DESC.mdsDeviationProfile IsNot Nothing AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 2 Then
						Try
							Me.PlotSurvey()
						Catch ex7 As Exception
						End Try
						If RSWIN_DESC.rst.gbReportDevChart Then
							num4 += 1
							If Not flag3 Then
								Me.SizeDevCharts()
								Me.rptDeviationSurvey = New rptDeviationSurvey()
								Me.rptDeviationSurvey.bPrint = False
								Me.ExportSideForcesChart(True, True)
								Me.ExportAxialLoadsChart(True, True)
								Me.ExportBucklingTendencyChart(True, True)
								Me.ExportDoglegsChart(True, True)
								Me.fMaxForCharts = Me.FindMaxForCharts()
								Me.ExportSurveyEWChart(True, True)
								Me.ExportSurveyNSChart(True, True)
								Me.ExportSurveyPlanPlotChart(True, True)
								Me.rptDeviationSurvey.TotalPageNumber = num2
								Me.rptDeviationSurvey.ThisPageNumber = num4
								Me.rptDeviationSurvey.Run(False)
							End If
							Try
								Dim enumerator12 As IEnumerator = Me.rptDeviationSurvey.Document.Pages.GetEnumerator()
								If enumerator12.MoveNext() Then
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(enumerator12.Current, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								End If
							Finally
								Dim enumerator12 As IEnumerator
								If TypeOf enumerator12 Is IDisposable Then
									TryCast(enumerator12, IDisposable).Dispose()
								End If
							End Try
							If Not flag2 Then
								MImpred.InitSummaryReportXML(Me.nGuideLines, flag6, text3, flag7, text4, text5)
							End If
							Dim tchart1_Report As TChart = Me.TChart1_Report
							Me.ExportDevPlot(tchart1_Report)
							Me.TChart1_Report = tchart1_Report
							Me.rptDevSurvey3DPlot = New rptDevSurvey3DPlot()
							Me.rptDevSurvey3DPlot.TotalPageNumber = num2
							num4 += 1
							Me.rptDevSurvey3DPlot.ThisPageNumber = num4
							Me.rptDevSurvey3DPlot.Run(False)
							Try
								Dim enumerator13 As IEnumerator = Me.rptDevSurvey3DPlot.Document.Pages.GetEnumerator()
								If enumerator13.MoveNext() Then
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(enumerator13.Current, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								End If
							Finally
								Dim enumerator13 As IEnumerator
								If TypeOf enumerator13 Is IDisposable Then
									TryCast(enumerator13, IDisposable).Dispose()
								End If
							End Try
						End If
						If Not flag3 AndAlso (Not RSWIN_DESC.rst.gbReportDevChart And RSWIN_DESC.bRodStarD And Not flag2) Then
							MImpred.InitSummaryReportXML(Me.nGuideLines, flag6, text3, flag7, text4, text5)
						End If
						If RSWIN_DESC.rst.gbReportGuide AndAlso flag4 Then
							num4 += 1
							If Not flag3 Then
								If RSWIN_DESC.SETUP_RECOMMEND_GUIDES Or (Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bAllZeroNumGuides) Then
									Me.rptRecommendedGuideReport = New rptRecommendedGuideReport()
								Else
									Me.rptRecommendedGuideReport = New rptRecommendedGuideReport2()
								End If
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bPrint", New Object() { False }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bMaxFootnote", New Object() { flag7 }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sMaxFootnote", New Object() { text4 }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bMinFootnote", New Object() { flag6 }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sMinFootnote", New Object() { text3 }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sGuideMsg", New Object() { text5 }, Nothing, Nothing)
								Try
									Dim xmldataSource As XMLDataSource = New XMLDataSource()
									xmldataSource.LoadXML(RSWIN_DESC.sSummaryDataSetXML)
									NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object() { xmldataSource }, Nothing, Nothing)
									NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "DataSource", New Object() { xmldataSource }, Nothing, Nothing)
								Catch ex8 As Exception
								End Try
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "ValidateOnParse", New Object() { True }, Nothing, Nothing, False, True)
								CType(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), XMLDataSource).RecordsetPattern = "//Data/Entries/Row"
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "TotalPageNumber", New Object() { num2 }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "ThisPageNumber", New Object() { num4 }, Nothing, Nothing)
								NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "NumberOfLines", New Object() { Me.nGuideLines }, Nothing, Nothing)
								NewLateBinding.LateCall(Me.rptRecommendedGuideReport, Nothing, "Run", New Object() { False }, Nothing, Nothing, Nothing, True)
							End If
							Dim num7 As Integer = 1
							Try
								For Each obj12 As Object In CType(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Pages", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable)
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj12, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
									If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Pages", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Count", New Object(-1) {}, Nothing, Nothing, Nothing), RSWIN_DESC.rst.Number_Of_Guide_report_Pages, False))) Then
										num7 += 1
										If num7 > RSWIN_DESC.rst.Number_Of_Guide_report_Pages Then
											Exit For
										End If
									End If
								Next
							Finally
								Dim enumerator14 As IEnumerator
								If TypeOf enumerator14 Is IDisposable Then
									TryCast(enumerator14, IDisposable).Dispose()
								End If
							End Try
						End If
						If RSWIN_DESC.rst.gbReportDevSurvey Then
							Util.BusyCursor()
							Application.DoEvents()
							If flag3 Then
								If RSWIN_DESC.rst.gbReportGuide AndAlso flag4 Then
									num4 += RSWIN_DESC.rst.Number_Of_Guide_report_Pages
								Else
									num4 += 1
								End If
								num4 = num4 + CInt(Math.Round(CDbl(Me.nDevSurveyLines) / 35.0)) - 1
							Else
								Me.rptDeviationProfile = New rptDeviationProfile()
								Me.rptDeviationProfile.bPrint = False
								Try
									Dim xmldataSource2 As XMLDataSource = New XMLDataSource()
									xmldataSource2.LoadXML(RSWIN_DESC.sDeviationProfileXML)
									Me.rptDeviationProfile.ds = xmldataSource2
									Me.rptDeviationProfile.DataSource = xmldataSource2
								Catch ex9 As Exception
								End Try
								Me.rptDeviationProfile.ds.ValidateOnParse = True
								Me.rptDeviationProfile.ds.RecordsetPattern = "//Data/Entries/Row"
								Me.rptDeviationProfile.TotalPageNumber = num2
								If RSWIN_DESC.rst.gbReportGuide AndAlso flag4 Then
									num4 += RSWIN_DESC.rst.Number_Of_Guide_report_Pages
								Else
									num4 += 1
								End If
								Me.rptDeviationProfile.ThisPageNumber = num4
								Me.rptDeviationProfile.NumberOfLines = Me.nDevSurveyLines
								Me.rptDeviationProfile.Run(False)
								num4 = num4 + CInt(Math.Round(CDbl(Me.nDevSurveyLines) / 35.0)) - 1
							End If
							Try
								For Each obj13 As Object In Me.rptDeviationProfile.Document.Pages
									Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj13, DataDynamics.ActiveReports.Document.Page)
									rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
								Next
							Finally
								Dim enumerator15 As IEnumerator
								If TypeOf enumerator15 Is IDisposable Then
									TryCast(enumerator15, IDisposable).Dispose()
								End If
							End Try
						End If
					End If
				End If
				cRODSTAR = Nothing
				Util.BusyCursor()
				Try
					If num2 > 0 Then
						Me.PdfExport1.Export(rptAll.Document, sPDFFilename)
					Else
						Dim obj14 As Object = Nothing
						Dim typeFromHandle As Type = GetType(MessageBox)
						Dim text9 As String = "Show"
						Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sOutputSetup), RuntimeHelpers.GetObjectValue(Me.sFileSaveError) }
						Dim array2 As Object() = array
						Dim array3 As String() = Nothing
						Dim array4 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { True, True }
						NewLateBinding.LateCall(obj14, typeFromHandle, text9, array2, array3, array4, array5, True)
						If array5(0) Then
							Me.sOutputSetup = RuntimeHelpers.GetObjectValue(array(0))
						End If
						If array5(1) Then
							Me.sFileSaveError = RuntimeHelpers.GetObjectValue(array(1))
						End If
					End If
				Catch ex10 As Exception
				End Try
				rptAll = Nothing
				Util.UnbusyCursor()
				RSWIN_DESC.bPDFFileSaved = True
			Catch ex11 As Exception
				Util.UnbusyCursor()
				RSWIN_DESC.bPDFFileSaved = True
			End Try
		End Sub

		Private Sub Results_Closing(sender As Object, e As CancelEventArgs)
			Try
				Me.DisableTimeClock()
				Try
					If RSWIN_DESC.bRodStarD Then
						Dim sDevPlotFileName As String = RSWIN_DESC.sDevPlotFileName
						Dim flag As Boolean = FILEUTIL.FileExists(sDevPlotFileName)
						RSWIN_DESC.sDevPlotFileName = sDevPlotFileName
						If flag Then
							Try
								FileSystem.Kill(RSWIN_DESC.sDevPlotFileName)
							Catch ex As Exception
							End Try
						End If
					End If
				Catch ex2 As Exception
				End Try
				Application.DoEvents()
				If Not RSWIN_DESC.rst.gbOutputLoaded And Not RSWIN_DESC.rst.gbBatch Then
					Retail.RestoreUserData()
				End If
				Me.ChartFX_Dyno.Data.Clear()
				Me.ChartFX_Temp_Dyno.Data.Clear()
				Me.ChartFX_Temp_Dyno_L.Data.Clear()
				Me.ChartFX_Temp_Dyno_XL.Data.Clear()
				Me.ChartFX_TorquePlot.Data.Clear()
				Me.ChartFX_Temp_Torque_L.Data.Clear()
				Me.ChartFX_Temp_Torque_XL.Data.Clear()
				Me.RemoveAllChildForms(True)
				Me.Hide()
				Application.DoEvents()
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub RemoveAllChildForms(Optional bRemoveVisInput As Boolean = True)
			For Each form As Form In Me.MdiChildren
				If form IsNot Nothing Then
					Try
						form.Hide()
						form.Close()
						form.Dispose()
					Catch ex As Exception
					End Try
				End If
			Next
		End Sub

		Private Sub Results_Closed(sender As Object, e As EventArgs)
			Me.Tag = "Close"
		End Sub

		Public Sub ExportDoglegsChart(bImport As Boolean, bExport As Boolean)
			Dim chtDoglegs As ChartFX.WinForms.Chart = Me.chtDoglegs
			Me.ShowDoglegs(chtDoglegs, False)
			Me.chtDoglegs = chtDoglegs
			If bExport Then
				Dim text As String = Me.RandomClass.NextDouble().ToString()
				text = text.Replace(".", "")
				Try
					If Not Directory.Exists(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName()) Then
						Directory.CreateDirectory(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName())
					End If
				Catch ex As Exception
				End Try
				RSWIN_DESC.sDoglegsFileName = String.Concat(New String() { RSWIN_DESC.sPathThetaData, "\", VERSION1.ProgramName(), "\", text.Trim(), "_Doglegs.bmp" })
				Dim sDoglegsFileName As String = RSWIN_DESC.sDoglegsFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sDoglegsFileName)
				RSWIN_DESC.sDoglegsFileName = sDoglegsFileName
				If flag Then
					Try
						FileSystem.Kill(RSWIN_DESC.sDoglegsFileName)
					Catch ex2 As Exception
					End Try
				End If
				Try
					Me.chtDoglegs.Export(FileFormat.Bitmap, RSWIN_DESC.sDoglegsFileName)
				Catch ex3 As Exception
					Me.DoSeveralDoEvents()
					Me.chtDoglegs.Export(FileFormat.Bitmap, RSWIN_DESC.sDoglegsFileName)
				End Try
			End If
			If bImport Then
				Try
					Me.rptDeviationSurvey.ImportDogLegChart()
				Catch ex4 As Exception
					Me.DoSeveralDoEvents()
					Me.rptDeviationSurvey.ImportDogLegChart()
				End Try
				Return
			End If
		End Sub

		Public Sub ExportSideForcesChart(bImport As Boolean, bExport As Boolean)
			Dim chtSideForces As ChartFX.WinForms.Chart = Me.chtSideForces
			Me.ShowSideForces(chtSideForces, False)
			Me.chtSideForces = chtSideForces
			If bExport Then
				Dim text As String = Me.RandomClass.NextDouble().ToString()
				text = text.Replace(".", "")
				Try
					If Not Directory.Exists(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName()) Then
						Directory.CreateDirectory(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName())
					End If
				Catch ex As Exception
				End Try
				RSWIN_DESC.sSideForcesFileName = String.Concat(New String() { RSWIN_DESC.sPathThetaData, "\", VERSION1.ProgramName(), "\", text.Trim(), "_SideForces.bmp" })
				Dim sSideForcesFileName As String = RSWIN_DESC.sSideForcesFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sSideForcesFileName)
				RSWIN_DESC.sSideForcesFileName = sSideForcesFileName
				If flag Then
					Try
						FileSystem.Kill(RSWIN_DESC.sSideForcesFileName)
					Catch ex2 As Exception
					End Try
				End If
				Try
					Me.chtSideForces.Export(FileFormat.Bitmap, RSWIN_DESC.sSideForcesFileName)
				Catch ex3 As Exception
					Me.DoSeveralDoEvents()
					Me.chtSideForces.Export(FileFormat.Bitmap, RSWIN_DESC.sSideForcesFileName)
				End Try
			End If
			If bImport Then
				Try
					Me.rptDeviationSurvey.ImportSideForcesChart()
				Catch ex4 As Exception
					Me.DoSeveralDoEvents()
					Me.rptDeviationSurvey.ImportSideForcesChart()
				End Try
				Return
			End If
		End Sub

		Public Sub ExportAxialLoadsChart(bImport As Boolean, bExport As Boolean)
			Dim chtAxialLoads As ChartFX.WinForms.Chart = Me.chtAxialLoads
			Me.ShowAxialLoads(chtAxialLoads, False)
			Me.chtAxialLoads = chtAxialLoads
			If bExport Then
				Dim text As String = Me.RandomClass.NextDouble().ToString()
				text = text.Replace(".", "")
				Try
					If Not Directory.Exists(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName()) Then
						Directory.CreateDirectory(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName())
					End If
				Catch ex As Exception
				End Try
				RSWIN_DESC.sAxialPlotFileName = String.Concat(New String() { RSWIN_DESC.sPathThetaData, "\", VERSION1.ProgramName(), "\", text.Trim(), "_Axial.bmp" })
				Dim sAxialPlotFileName As String = RSWIN_DESC.sAxialPlotFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sAxialPlotFileName)
				RSWIN_DESC.sAxialPlotFileName = sAxialPlotFileName
				If flag Then
					Try
						FileSystem.Kill(RSWIN_DESC.sAxialPlotFileName)
					Catch ex2 As Exception
					End Try
				End If
				Try
					Me.chtAxialLoads.Export(FileFormat.Bitmap, RSWIN_DESC.sAxialPlotFileName)
				Catch ex3 As Exception
					Me.DoSeveralDoEvents()
					Me.chtAxialLoads.Export(FileFormat.Bitmap, RSWIN_DESC.sAxialPlotFileName)
				End Try
			End If
			If bImport Then
				Try
					Me.rptDeviationSurvey.ImportAxialLoadsChart()
				Catch ex4 As Exception
					Me.DoSeveralDoEvents()
					Me.rptDeviationSurvey.ImportAxialLoadsChart()
				End Try
				Return
			End If
		End Sub

		Public Sub ExportBucklingTendencyChart(bImport As Boolean, bExport As Boolean)
			Dim chtBucklingTendency As ChartFX.WinForms.Chart = Me.chtBucklingTendency
			Me.ShowBucklingTendency(chtBucklingTendency, False)
			Me.chtBucklingTendency = chtBucklingTendency
			If bExport Then
				Dim text As String = Me.RandomClass.NextDouble().ToString()
				text = text.Replace(".", "")
				Try
					If Not Directory.Exists(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName()) Then
						Directory.CreateDirectory(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName())
					End If
				Catch ex As Exception
				End Try
				RSWIN_DESC.sBucklingTendencyFileName = String.Concat(New String() { RSWIN_DESC.sPathThetaData, "\", VERSION1.ProgramName(), "\", text.Trim(), "_BucklingTendency.bmp" })
				Dim sBucklingTendencyFileName As String = RSWIN_DESC.sBucklingTendencyFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sBucklingTendencyFileName)
				RSWIN_DESC.sBucklingTendencyFileName = sBucklingTendencyFileName
				If flag Then
					Try
						FileSystem.Kill(RSWIN_DESC.sBucklingTendencyFileName)
					Catch ex2 As Exception
					End Try
				End If
				Try
					Me.chtBucklingTendency.Export(FileFormat.Bitmap, RSWIN_DESC.sBucklingTendencyFileName)
				Catch ex3 As Exception
					Me.DoSeveralDoEvents()
					Me.chtBucklingTendency.Export(FileFormat.Bitmap, RSWIN_DESC.sBucklingTendencyFileName)
				End Try
			End If
			If bImport Then
				Try
					Me.rptDeviationSurvey.ImportBucklingTendencyChart()
				Catch ex4 As Exception
					Me.DoSeveralDoEvents()
					Me.rptDeviationSurvey.ImportBucklingTendencyChart()
				End Try
				Return
			End If
		End Sub

		Public Sub ExportSurveyEWChart(bImport As Boolean, bExport As Boolean)
			Dim chtSurveyEW As ChartFX.WinForms.Chart = Me.chtSurveyEW
			Me.ShowSurveyEW(chtSurveyEW, False)
			Me.chtSurveyEW = chtSurveyEW
			If bExport Then
				Dim text As String = Me.RandomClass.NextDouble().ToString()
				text = text.Replace(".", "")
				Try
					If Not Directory.Exists(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName()) Then
						Directory.CreateDirectory(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName())
					End If
				Catch ex As Exception
				End Try
				RSWIN_DESC.sSurveyEWFileName = String.Concat(New String() { RSWIN_DESC.sPathThetaData, "\", VERSION1.ProgramName(), "\", text.Trim(), "_SurveyEW.bmp" })
				Dim sSurveyEWFileName As String = RSWIN_DESC.sSurveyEWFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sSurveyEWFileName)
				RSWIN_DESC.sSurveyEWFileName = sSurveyEWFileName
				If flag Then
					Try
						FileSystem.Kill(RSWIN_DESC.sSurveyEWFileName)
					Catch ex2 As Exception
					End Try
				End If
				Try
					Me.chtSurveyEW.Export(FileFormat.Bitmap, RSWIN_DESC.sSurveyEWFileName)
				Catch ex3 As Exception
					Me.DoSeveralDoEvents()
					Me.chtSurveyEW.Export(FileFormat.Bitmap, RSWIN_DESC.sSurveyEWFileName)
				End Try
			End If
			If bImport Then
				Try
					Me.rptDeviationSurvey.ImportSurveyEWChart()
				Catch ex4 As Exception
					Me.DoSeveralDoEvents()
					Me.rptDeviationSurvey.ImportSurveyEWChart()
				End Try
				Return
			End If
		End Sub

		Public Sub ExportSurveyNSChart(bImport As Boolean, bExport As Boolean)
			Dim chtSurveyNS As ChartFX.WinForms.Chart = Me.chtSurveyNS
			Me.ShowSurveyNS(chtSurveyNS, False)
			Me.chtSurveyNS = chtSurveyNS
			If bExport Then
				Dim text As String = Me.RandomClass.NextDouble().ToString()
				text = text.Replace(".", "")
				Try
					If Not Directory.Exists(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName()) Then
						Directory.CreateDirectory(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName())
					End If
				Catch ex As Exception
				End Try
				RSWIN_DESC.sSurveyNSFileName = String.Concat(New String() { RSWIN_DESC.sPathThetaData, "\", VERSION1.ProgramName(), "\", text.Trim(), "_SurveyNS.bmp" })
				Dim sSurveyNSFileName As String = RSWIN_DESC.sSurveyNSFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sSurveyNSFileName)
				RSWIN_DESC.sSurveyNSFileName = sSurveyNSFileName
				If flag Then
					Try
						FileSystem.Kill(RSWIN_DESC.sSurveyNSFileName)
					Catch ex2 As Exception
					End Try
				End If
				Try
					Me.chtSurveyNS.Export(FileFormat.Bitmap, RSWIN_DESC.sSurveyNSFileName)
				Catch ex3 As Exception
					Me.DoSeveralDoEvents()
					Me.chtSurveyNS.Export(FileFormat.Bitmap, RSWIN_DESC.sSurveyNSFileName)
				End Try
			End If
			If bImport Then
				Try
					Me.rptDeviationSurvey.ImportSurveyNSChart()
				Catch ex4 As Exception
					Me.DoSeveralDoEvents()
					Me.rptDeviationSurvey.ImportSurveyNSChart()
				End Try
				Return
			End If
		End Sub

		Public Sub ExportSurveyPlanPlotChart(bImport As Boolean, bExport As Boolean)
			Dim chtSurveyPlan As ChartFX.WinForms.Chart = Me.chtSurveyPlan
			Me.ShowSurveyPlan(chtSurveyPlan, False)
			Me.chtSurveyPlan = chtSurveyPlan
			If bExport Then
				Dim text As String = Me.RandomClass.NextDouble().ToString()
				text = text.Replace(".", "")
				Try
					If Not Directory.Exists(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName()) Then
						Directory.CreateDirectory(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName())
					End If
				Catch ex As Exception
				End Try
				RSWIN_DESC.sSurveyPlanFileName = String.Concat(New String() { RSWIN_DESC.sPathThetaData, "\", VERSION1.ProgramName(), "\", text.Trim(), "_SurveyPlan.bmp" })
				Dim sSurveyPlanFileName As String = RSWIN_DESC.sSurveyPlanFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sSurveyPlanFileName)
				RSWIN_DESC.sSurveyPlanFileName = sSurveyPlanFileName
				If flag Then
					Try
						FileSystem.Kill(RSWIN_DESC.sSurveyPlanFileName)
					Catch ex2 As Exception
					End Try
				End If
				Try
					Me.chtSurveyPlan.Export(FileFormat.Bitmap, RSWIN_DESC.sSurveyPlanFileName)
				Catch ex3 As Exception
					Me.DoSeveralDoEvents()
					Me.chtSurveyPlan.Export(FileFormat.Bitmap, RSWIN_DESC.sSurveyPlanFileName)
				End Try
			End If
			If bImport Then
				Try
					Me.rptDeviationSurvey.ImportSurveyPlanPlotChart()
				Catch ex4 As Exception
					Me.DoSeveralDoEvents()
					Me.rptDeviationSurvey.ImportSurveyPlanPlotChart()
				End Try
				Return
			End If
		End Sub

		Private Sub ShowAxialLoads(ByRef Chart As ChartFX.WinForms.Chart, bLarge As Boolean)
			Dim num As Single = 0F
			Dim num2 As Single = 0F
			Dim axisX As ChartFX.WinForms.Axis = Chart.AxisX
			Dim axisY As ChartFX.WinForms.Axis = Chart.AxisY
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Dim flag As Boolean = False
			Dim num3 As Single = 100000F
			Dim num4 As Double = 0.0
			Dim num5 As Double = 1000000.0
			Dim chart As ChartFX.WinForms.Chart = Chart
			chart.Data.Series = 2
			chart.Data.Points = impredObj.num_rod_elements
			chart.LegendBox.Visible = True
			Dim legendItemAttributes As LegendItemAttributes = New LegendItemAttributes()
			legendItemAttributes.Visible = False
			chart.LegendBox.ItemAttributes(chart.Series) = legendItemAttributes
			chart.LegendBox.CustomItems.Clear()
			Dim axis As ChartFX.WinForms.Axis
			If flag Then
				Dim text As String = "c:\Theta\AxialLoads.csv"
				If FILEUTIL.FileExists(text) Then
					FileSystem.Kill("c:\Theta\AxialLoads.csv")
				End If
				Dim num6 As Short = CShort(FileSystem.FreeFile())
				FileSystem.FileOpen(CInt(num6), "c:\Theta\AxialLoads.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(CInt(num6), New Object() { "Measured Depth (ft), Min Axial Load (lbs), Max Axial Load (lbs)" })
				Dim num7 As Long = 0L
				Dim num8 As Long = CLng((impredObj.num_rod_elements - 1))
				For num9 As Long = num7 To num8
					If RSWIN_DESC.rst.gbIncludeBuoyancy Then
						num2 = CSng(impredObj.get_r_e(CInt((num9 + 1L))).min_force)
					Else
						num2 = CSng(impredObj.get_r_e(CInt((num9 + 1L))).min_force_unbuoyed)
					End If
					If RSWIN_DESC.rst.gbIncludeBuoyancy Then
						num = CSng(impredObj.get_r_e(CInt((num9 + 1L))).max_force)
					Else
						num = CSng(impredObj.get_r_e(CInt((num9 + 1L))).max_force_unbuoyed)
					End If
					FileSystem.PrintLine(CInt(num6), New Object() { String.Concat(New String() { Conversions.ToString(impredObj.get_r_e(CInt((num9 + 1L))).m_d), " , ", Conversions.ToString(num2), " , ", Conversions.ToString(num) }) })
				Next
				FileSystem.FileClose(New Integer() { CInt(num6) })
			End If
			Dim num10 As Long = 0L
			Dim num11 As Long = CLng((impredObj.num_rod_elements - 1))
			For num9 As Long = num10 To num11
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				Dim num12 As Single = CSng(-CSng(impredObj.get_r_e(CInt((num9 + 1L))).m_d))
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					CtrlUI.ConvertValue(num12, "f", False)
				End If
				chart.Data.Y(0, CInt(num9)) = CDbl(num12)
				chart.Data.Y(1, CInt(num9)) = CDbl(num12)
				If num12 < num3 Then
					num3 = num12
				End If
				If RSWIN_DESC.rst.gbIncludeBuoyancy Then
					num = CSng(impredObj.get_r_e(CInt((num9 + 1L))).max_force)
				Else
					num = CSng(impredObj.get_r_e(CInt((num9 + 1L))).max_force_unbuoyed)
				End If
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(num, "l", False)
				End If
				If RSWIN_DESC.rst.gbIncludeBuoyancy Then
					num2 = CSng(impredObj.get_r_e(CInt((num9 + 1L))).min_force)
				Else
					num2 = CSng(impredObj.get_r_e(CInt((num9 + 1L))).min_force_unbuoyed)
				End If
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(num2, "l", False)
				End If
				If num2 <= num Then
					chart.Data.X(0, CInt(num9)) = CDbl(num2)
					chart.Data.X(1, CInt(num9)) = CDbl(num)
				Else
					chart.Data.X(0, CInt(num9)) = 1E+108
					chart.Data.X(1, CInt(num9)) = 1E+108
				End If
				chart.Points(0, CInt(num9)).Color = Me.GetLineColor(CSng(impredObj.get_r_e(CInt((num9 + 1L))).m_d))
				chart.Points(1, CInt(num9)).Color = chart.Points(0, CInt(num9)).Color
				If CDbl(num) > num4 Then
					num4 = CDbl(num)
				End If
				If CDbl(num2) < num5 Then
					num5 = CDbl(num2)
				End If
			Next
			chart.LegendBox.Border = DockBorder.None
			axis = axisX
			Dim title As ChartFX.WinForms.Title = axis.Title
			title.Alignment = StringAlignment.Center
			title.Font = New Font("Arial", 7F, FontStyle.Bold)
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				title.Text = "Min and Max Axial loads (lbf)"
			Else
				title.Text = "Min and Max Axial loads (Nf)"
			End If
			title.TextColor = Color.Black
			axis.Font = New Font("Arial", 7F, FontStyle.Bold)
			axis.Max = num4 * 1.5
			axis.Min = num5 * 1.5
			If bLarge Then
				axis.Title.Alignment = StringAlignment.Center
				axis.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			End If
			Dim axis2 As ChartFX.WinForms.Axis = axisY
			Dim title2 As ChartFX.WinForms.Title = axis2.Title
			title2.Font = New Font("Arial", 7F, FontStyle.Bold)
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				title2.Text = "Measured depth (m)"
			Else
				title2.Text = "Measured depth (ft)"
			End If
			title2.TextColor = Color.Black
			axis2.Max = 0.0
			axis2.Min = CDbl(Me.fSideLoadYMin)
			axis2.Notify = True
			If bLarge Then
				axis2.Title.Alignment = StringAlignment.Center
				axis2.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			End If
			chart.LegendBox.Visible = False
			chart.ToolBar.Visible = False
			If bLarge Then
				chart.Titles(0).Font = New Font("Arial", 10F, FontStyle.Bold)
				chart.AllSeries.Line.Width = 2S
			Else
				chart.Titles(0).Font = New Font("Arial", 7F, FontStyle.Bold)
				chart.AllSeries.Line.Width = 1S
			End If
			chart.Refresh()
		End Sub

		Public Function SetLineSolid(fDepth As Object) As Boolean
			Dim num As Integer = 1
			Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
			Dim result As Boolean
			For i As Integer = num To numRods
				If Operators.ConditionalCompareObjectLess(fDepth, RSWIN_DESC.rst.Sections(i).length, False) Then
					result = (i = 1 Or i = 3 Or i = 5 Or i = 7)
				End If
			Next
			Return result
		End Function

		Public Function CalcTaperDepths() As Boolean
			If RSWIN_DESC.rst.NumRods = 0S Then
				Return False
			End If
			Me.TaperDepths = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Me.TaperDepths(1) = RSWIN_DESC.rst.Sections(1).length
			Dim num As Integer = 2
			Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
			For i As Integer = num To numRods
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				Me.TaperDepths(i) = Me.TaperDepths(i - 1) + RSWIN_DESC.rst.Sections(i).length
			Next
			Return True
		End Function

		Public Function GetLineColor(fDepth As Single) As Color
			Dim result As Color
			Try
				fDepth = Math.Abs(fDepth)
				Dim flag As Boolean = True
				If flag = fDepth <= RSWIN_DESC.rst.Sections(1).length Then
					result = Color.Red
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 1S And fDepth <= Me.TaperDepths(2)) Then
					result = Color.Green
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 2S And fDepth <= Me.TaperDepths(3)) Then
					result = Color.Blue
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 3S And fDepth <= Me.TaperDepths(4)) Then
					result = Color.Magenta
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 4S And fDepth <= Me.TaperDepths(5)) Then
					result = Color.MediumTurquoise
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 5S And fDepth <= Me.TaperDepths(6)) Then
					result = Color.Orange
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 6S And fDepth <= Me.TaperDepths(7)) Then
					result = Color.Purple
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 7S And fDepth <= Me.TaperDepths(8)) Then
					result = Color.Tan
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 8S And fDepth <= Me.TaperDepths(9)) Then
					result = Color.DarkRed
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 9S And fDepth <= Me.TaperDepths(10)) Then
					result = Color.Gray
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 10S And fDepth <= Me.TaperDepths(11)) Then
					result = Color.Red
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 11S And fDepth <= Me.TaperDepths(12)) Then
					result = Color.Green
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 12S And fDepth <= Me.TaperDepths(13)) Then
					result = Color.Blue
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 13S And fDepth <= Me.TaperDepths(14)) Then
					result = Color.Magenta
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 14S And fDepth <= Me.TaperDepths(15)) Then
					result = Color.MediumTurquoise
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 15S And fDepth <= Me.TaperDepths(16)) Then
					result = Color.Orange
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 16S And fDepth <= Me.TaperDepths(17)) Then
					result = Color.Purple
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 17S And fDepth <= Me.TaperDepths(18)) Then
					result = Color.Tan
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 18S And fDepth <= Me.TaperDepths(19)) Then
					result = Color.DarkRed
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 19S And fDepth <= Me.TaperDepths(20)) Then
					result = Color.Gray
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 20S And fDepth <= Me.TaperDepths(21)) Then
					result = Color.Red
				End If
			Catch ex As Exception
				result = Color.Black
			End Try
			Return result
		End Function

		Public Function GetLineColor_Old(fDepth As Single, Optional ByRef sColor As String = "") As Color
			Dim result As Color
			Try
				fDepth = Math.Abs(fDepth)
				Dim flag As Boolean = True
				If flag = (fDepth < RSWIN_DESC.rst.Sections(1).length Or RSWIN_DESC.rst.NumRods = 1S) Then
					result = Color.Red
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 1S And fDepth < Me.TaperDepths(2)) Then
					result = Color.Green
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 2S And fDepth < Me.TaperDepths(3)) Then
					result = Color.Blue
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 3S And fDepth < Me.TaperDepths(4)) Then
					result = Color.Magenta
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 4S And fDepth < Me.TaperDepths(5)) Then
					result = Color.MediumTurquoise
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 5S And fDepth < Me.TaperDepths(6)) Then
					result = Color.Orange
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 6S And fDepth < Me.TaperDepths(7)) Then
					result = Color.Purple
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 7S And fDepth < Me.TaperDepths(8)) Then
					result = Color.Tan
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 8S And fDepth < Me.TaperDepths(9)) Then
					result = Color.DarkRed
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 9S And fDepth < Me.TaperDepths(10)) Then
					result = Color.Gray
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 11S And fDepth < Me.TaperDepths(12)) Then
					result = Color.Red
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 12S And fDepth < Me.TaperDepths(13)) Then
					result = Color.Green
				End If
			Catch ex As Exception
				result = Color.Black
			End Try
			Return result
		End Function

		Private Sub ShowBucklingTendency(ByRef Chart As ChartFX.WinForms.Chart, bLarge As Boolean)
			Dim num As Single = 100000F
			Dim axisX As ChartFX.WinForms.Axis = Chart.AxisX
			Dim axisY As ChartFX.WinForms.Axis = Chart.AxisY
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Dim flag As Boolean = True
			Try
				flag = MImpred.CheckSurveyForDeviation()
			Catch ex As Exception
			End Try
			Dim chart As ChartFX.WinForms.Chart = Chart
			chart.Data.Series = 1
			chart.Data.Points = impredObj.num_rod_elements
			chart.LegendBox.Visible = True
			Dim legendItemAttributes As LegendItemAttributes = New LegendItemAttributes()
			legendItemAttributes.Visible = False
			chart.LegendBox.ItemAttributes(chart.Series) = legendItemAttributes
			chart.LegendBox.CustomItems.Clear()
			Dim num2 As Long = 0L
			Dim num3 As Long = CLng((impredObj.num_rod_elements - 1))
			Dim num7 As Double
			Dim axis As ChartFX.WinForms.Axis
			For num4 As Long = num2 To num3
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				Dim num5 As Single = CSng(-CSng(impredObj.get_r_e(CInt((num4 + 1L))).m_d))
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					CtrlUI.ConvertValue(num5, "f", False)
				End If
				chart.Data.Y(0, CInt(num4)) = CDbl(num5)
				If num5 < num Then
					num = num5
				End If
				If flag Then
					Dim num6 As Single
					If impredObj.get_r_e(CInt((num4 + 1L))).buckle_tendency > 0.0 Then
						chart.Data.X(0, CInt(num4)) = 0.0
					Else
						num6 = CSng(Math.Abs(impredObj.get_r_e(CInt((num4 + 1L))).buckle_tendency))
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							CtrlUI.ConvertValue(num6, "l", False)
						End If
						chart.Data.X(0, CInt(num4)) = CDbl(num6)
					End If
					chart.Points(0, CInt(num4)).Color = Me.GetLineColor(CSng(impredObj.get_r_e(CInt((num4 + 1L))).m_d))
					If CDbl(num6) > num7 Then
						num7 = CDbl(num6)
					End If
				Else
					chart.Data.X(0, CInt(num4)) = 0.0
					chart.Points(0, CInt(num4)).Color = Me.GetLineColor(CSng(impredObj.get_r_e(CInt((num4 + 1L))).m_d))
				End If
			Next
			chart.LegendBox.Border = DockBorder.None
			axis = axisX
			Dim title As ChartFX.WinForms.Title = axis.Title
			title.Alignment = StringAlignment.Center
			title.Font = New Font("Arial", 7F, FontStyle.Bold)
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				title.Text = "Buckling tendency (lbf)"
			Else
				title.Text = "Buckling tendency (Nf)"
			End If
			title.TextColor = Color.Black
			axis.Font = New Font("Arial", 7F, FontStyle.Bold)
			axis.ForceZero = True
			axis.Max = num7 * 2.0
			If bLarge Then
				axis.Title.Alignment = StringAlignment.Center
				axis.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			End If
			Dim axis2 As ChartFX.WinForms.Axis = axisY
			Dim title2 As ChartFX.WinForms.Title = axis2.Title
			title2.Font = New Font("Arial", 7F, FontStyle.Bold)
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				title2.Text = "Measured depth (m)"
			Else
				title2.Text = "Measured depth (ft)"
			End If
			title2.TextColor = Color.Black
			axis2.Max = 0.0
			axis2.Min = CDbl(Me.fSideLoadYMin)
			axis2.Notify = True
			If bLarge Then
				axis2.Title.Alignment = StringAlignment.Center
				axis2.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			End If
			chart.LegendBox.Visible = False
			chart.ToolBar.Visible = False
			If bLarge Then
				chart.Titles(0).Font = New Font("Arial", 10F, FontStyle.Bold)
				chart.AllSeries.Line.Width = 2S
			Else
				chart.Titles(0).Font = New Font("Arial", 7F, FontStyle.Bold)
				chart.AllSeries.Line.Width = 1S
			End If
			chart.Refresh()
		End Sub

		Private Sub ShowSideForces(ByRef Chart As ChartFX.WinForms.Chart, Optional bLarge As Boolean = False)
			Dim axisX As ChartFX.WinForms.Axis = Chart.AxisX
			Dim axisY As ChartFX.WinForms.Axis = Chart.AxisY
			Dim num As Single = 100000F
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Dim num2 As Double = 0.0
			Dim num3 As Double = 0.0
			Dim flag As Boolean = True
			Try
				flag = MImpred.CheckSurveyForDeviation()
			Catch ex As Exception
			End Try
			Dim chart As ChartFX.WinForms.Chart = Chart
			Dim axis As ChartFX.WinForms.Axis
			Dim array As Single() = New Single(impredObj.num_rod_elements + 1 - 1) {}
			array(0) = 0F
			Dim num4 As Single
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				num4 = 7.62F
			Else
				num4 = 25F
			End If
			chart.Data.Series = 1
			chart.Data.Points = impredObj.num_rod_elements
			chart.LegendBox.Visible = True
			Dim legendItemAttributes As LegendItemAttributes = New LegendItemAttributes()
			legendItemAttributes.Visible = False
			chart.LegendBox.ItemAttributes(chart.Series) = legendItemAttributes
			chart.LegendBox.CustomItems.Clear()
			array = New Single(impredObj.num_rod_elements - 1 + 1 - 1) {}
			Dim num5 As Single = 0F
			Dim num6 As Long = 0L
			Dim num7 As Long = CLng((impredObj.num_rod_elements - 1))
			For num8 As Long = num6 To num7
				Dim num9 As Single = CSng(impredObj.get_r_e(CInt((num8 + 1L))).m_d)
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(num9, "f", False)
				End If
				Dim num10 As Single = num9 - num5
				array(CInt(num8)) = num10
				num5 = num9
			Next
			Dim num11 As Long = 0L
			Dim num12 As Long = CLng((impredObj.num_rod_elements - 1))
			For num8 As Long = num11 To num12
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				Dim num9 As Single = CSng(-CSng(impredObj.get_r_e(CInt((num8 + 1L))).m_d))
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					CtrlUI.ConvertValue(num9, "f", False)
				End If
				chart.Data.Y(0, CInt(num8)) = CDbl(num9)
				If num9 < num Then
					num = num9
				End If
				If flag Then
					Dim num13 As Double = impredObj.get_r_e(CInt((num8 + 1L))).max_sf_total
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						Dim num14 As Single = CSng(num13)
						CtrlUI.ConvertValue(num14, "l", False)
						num13 = CDbl(num14)
					End If
					chart.Data.X(0, CInt(num8)) = Math.Abs(Math.Round(num13 / CDbl(array(CInt(num8))) * CDbl(num4), 2))

						' The following expression was wrapped in a checked-expression
						If Math.Abs(num13 / CDbl(array(CInt(num8))) * CDbl(num4)) > num2 Then
							' The following expression was wrapped in a checked-expression
							num2 = Math.Abs(num13 / CDbl(array(CInt(num8))) * CDbl(num4))
						End If

					chart.Points(0, CInt(num8)).Color = Me.GetLineColor(CSng(impredObj.get_r_e(CInt((num8 + 1L))).m_d))
					If num13 > num3 Then
						num3 = num13
					End If
				Else
					chart.Data.X(0, CInt(num8)) = 0.0
					chart.Points(0, CInt(num8)).Color = Me.GetLineColor(CSng(impredObj.get_r_e(CInt((num8 + 1L))).m_d))
				End If
			Next
			chart.LegendBox.Border = DockBorder.None
			axis = axisX
			Dim title As ChartFX.WinForms.Title = axis.Title
			title.Alignment = StringAlignment.Center
			title.Font = New Font("Arial", 7F, FontStyle.Bold)
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				title.Text = "Max. side force (lbf)"
			Else
				title.Text = "Max. side force (Nf)"
			End If
			title.TextColor = Color.Black
			axis.ForceZero = True
			axis.Font = New Font("Arial", 7F, FontStyle.Bold)
			axis.Max = num2 * 1.5
			axis.Min = 0.0
			If bLarge Then
				axis.Title.Alignment = StringAlignment.Center
				axis.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			End If
			Dim axis2 As ChartFX.WinForms.Axis = axisY
			Dim title2 As ChartFX.WinForms.Title = axis2.Title
			title2.Font = New Font("Arial", 7F, FontStyle.Bold)
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				title2.Text = "Measured depth (m)"
			Else
				title2.Text = "Measured depth (ft)"
			End If
			title2.TextColor = Color.Black
			axis2.Max = 0.0
			num = Me.RoundYMin(num)
			axis2.Min = CDbl(num)
			Me.fSideLoadYMin = num
			If bLarge Then
				axis2.Title.Alignment = StringAlignment.Center
				axis2.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			End If
			If bLarge Then
				chart.Titles(0).Font = New Font("Arial", 10F, FontStyle.Bold)
				chart.AllSeries.Line.Width = 2S
			Else
				chart.Titles(0).Font = New Font("Arial", 7F, FontStyle.Bold)
				chart.AllSeries.Line.Width = 1S
			End If
			chart.Refresh()
		End Sub

		Private Sub ShowDoglegs(ByRef Chart As ChartFX.WinForms.Chart, Optional bLarge As Boolean = False)
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Dim num As Single = -10000F
			Try
				Dim chart As ChartFX.WinForms.Chart = Chart
				chart.Data.Series = 1
				chart.Data.Points = impredObj.num_rod_elements
				chart.LegendBox.Visible = True
				Dim legendItemAttributes As LegendItemAttributes = New LegendItemAttributes()
				legendItemAttributes.Visible = False
				chart.LegendBox.ItemAttributes(chart.Series) = legendItemAttributes
				chart.LegendBox.CustomItems.Clear()
				Dim array As Single() = New Single(impredObj.num_rod_elements - 1 + 1 - 1) {}
				Dim num2 As Single = 0F
				Dim num3 As Long = 0L
				Dim num4 As Long = CLng((impredObj.num_rod_elements - 1))
				For num5 As Long = num3 To num4
					Dim num6 As Single = CSng(impredObj.get_r_e(CInt((num5 + 1L))).m_d)
					If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
						CtrlUI.ConvertValue(num6, "f", False)
					End If
					Dim num7 As Single = num6 - num2
					array(CInt(num5)) = num7
					num2 = num6
				Next
				Dim num8 As Long = 0L
				Dim num9 As Long = CLng((impredObj.num_rod_elements - 1))
				For num5 As Long = num8 To num9
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					Dim num10 As Single = CSng(-CSng(impredObj.get_r_e(CInt((num5 + 1L))).m_d))
					If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
						CtrlUI.ConvertValue(num10, "f", False)
					End If
					chart.Data.Y(0, CInt(num5)) = CDbl(num10)
					Dim num11 As Single = CSng(impredObj.get_r_e(CInt((num5 + 1L))).dog)
					If num11 > num Then
						num = num11
					End If
					If array(CInt(num5)) <> 0F Then
						Dim num12 As Single

							If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
								' The following expression was wrapped in a checked-expression
								num12 = CSng(Math.Round(CDbl(num11) / 1.5707963267948966 * 90.0 / CDbl(array(CInt(num5))) * 100.0, 2))
							Else
								' The following expression was wrapped in a checked-expression
								num12 = CSng(Math.Round(CDbl(num11) / 1.5707963267948966 * 90.0 / CDbl(array(CInt(num5))) * 30.0, 2))
							End If

						chart.Data.X(0, CInt(num5)) = CDbl(num12)
					Else
						chart.Data.X(0, CInt(num5)) = 0.0
					End If
					chart.Points(0, CInt(num5)).Color = Me.GetLineColor(CSng(impredObj.get_r_e(CInt((num5 + 1L))).m_d))
					If CDbl(num) < chart.Data.X(0, CInt(num5)) Then
						num = CSng(chart.Data.X(0, CInt(num5)))
					End If
				Next
				chart.LegendBox.Border = DockBorder.None
				Dim axisX As AxisX = chart.AxisX
				Dim title As ChartFX.WinForms.Title = axisX.Title
				title.Alignment = StringAlignment.Center
				title.Font = New Font("Arial", 7F, FontStyle.Bold)
				title.Text = Conversions.ToString(Me.SetDoglegColumnHeader())
				title.TextColor = Color.Black
				axisX.ForceZero = True
				axisX.Font = New Font("Arial", 7F, FontStyle.Bold)
				axisX.Max = CDbl(Me.getmaxdog(num))
				axisX.Min = 0.0
				If bLarge Then
					axisX.Title.Alignment = StringAlignment.Center
					axisX.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
				Else
					axisX.Title.Font = New Font("Arial", 7F, FontStyle.Bold)
				End If
				Dim axisY As AxisY = chart.AxisY
				Dim title2 As ChartFX.WinForms.Title = axisY.Title
				title2.Font = New Font("Arial", 7F, FontStyle.Bold)
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					title2.Text = "Measured depth (m)"
				Else
					title2.Text = "Measured depth (ft)"
				End If
				title2.TextColor = Color.Black
				If bLarge Then
					axisY.Title.Alignment = StringAlignment.Center
					axisY.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
				Else
					axisY.Title.Font = New Font("Arial", 7F, FontStyle.Bold)
				End If
				axisY.Min = CDbl(Me.fSideLoadYMin)
				If bLarge Then
					chart.Titles(0).Font = New Font("Arial", 10F, FontStyle.Bold)
					chart.AllSeries.Line.Width = 2S
				Else
					chart.Titles(0).Font = New Font("Arial", 7F, FontStyle.Bold)
					chart.AllSeries.Line.Width = 1S
				End If
				chart.Refresh()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowSurveyEW(ByRef Chart As ChartFX.WinForms.Chart, Optional bLarge As Boolean = False)
			Dim num As Single = 100000F
			Dim axisX As ChartFX.WinForms.Axis = Chart.AxisX
			Dim axisY As ChartFX.WinForms.Axis = Chart.AxisY
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Try
				Dim num2 As Double = 0.0
				Dim num3 As Double = 0.0
				Dim chart As ChartFX.WinForms.Chart = Chart
				chart.Data.Series = 1
				chart.Data.Points = impredObj.num_rod_elements
				chart.LegendBox.Visible = True
				Dim legendItemAttributes As LegendItemAttributes = New LegendItemAttributes()
				legendItemAttributes.Visible = False
				chart.LegendBox.ItemAttributes(chart.Series) = legendItemAttributes
				chart.LegendBox.CustomItems.Clear()
				Dim num4 As Long = 0L
				Dim num5 As Long = CLng((impredObj.num_rod_elements - 1))
				Dim axis As ChartFX.WinForms.Axis
				For num6 As Long = num4 To num5
					Dim rod_element_data_type As TEImpred.rod_element_data_type = impredObj.get_r_e(CInt((num6 + 1L)))
					Dim num7 As Single = CSng(-CSng(rod_element_data_type.pos.z))
					If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
						CtrlUI.ConvertValue(num7, "f", False)
					End If
					chart.Data.Y(0, CInt(num6)) = CDbl(num7)
					If num7 < num Then
						num = num7
					End If
					If CDbl(Math.Abs(num7)) > num3 Then
						num3 = CDbl(Math.Abs(num7))
					End If
					rod_element_data_type = impredObj.get_r_e(CInt((num6 + 1L)))
					num7 = CSng(rod_element_data_type.pos.x)
					If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
						CtrlUI.ConvertValue(num7, "f", False)
					End If
					chart.Data.X(0, CInt(num6)) = CDbl(num7)
					If num7 < num Then
						num = num7
					End If
					If CDbl(Math.Abs(num7)) > num2 Then
						num2 = CDbl(Math.Abs(num7))
					End If
					chart.Points(0, 1).Line.Style = DashStyle.Dot
					Dim pointAttributes As PointAttributes = chart.Points(0, CInt(num6))
					rod_element_data_type = impredObj.get_r_e(CInt((num6 + 1L)))
					pointAttributes.Color = Me.GetLineColor(CSng(rod_element_data_type.m_d))
				Next
				chart.LegendBox.Border = DockBorder.None
				axis = axisX
				Dim title As ChartFX.WinForms.Title = axis.Title
				title.Alignment = StringAlignment.Center
				title.Font = New Font("Arial", 7F, FontStyle.Bold)
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					title.Text = "West                 distance (m)                 East"
				Else
					title.Text = "West                 distance (ft)                 East"
				End If
				title.TextColor = Color.Black
				axis.Font = New Font("Arial", 7F, FontStyle.Bold)
				If num2 > CDbl(Me.fMaxForCharts) Then
					axis.Max = CDbl(Me.GetAxisMinMax(CSng(num2), CSng((num2 * -1.0))))
					axis.Min = axis.Max * -1.0
				Else
					axis.Max = CDbl(Me.GetAxisMinMax(Me.fMaxForCharts, Me.fMaxForCharts * -1F))
					axis.Min = axis.Max * -1.0
				End If
				If bLarge Then
					axis.Title.Alignment = StringAlignment.Center
					axis.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
				Else
					axis.Title.Font = New Font("Arial", 7F, FontStyle.Bold)
				End If
				Dim axis2 As ChartFX.WinForms.Axis = axisY
				Dim title2 As ChartFX.WinForms.Title = axis2.Title
				title2.Font = New Font("Arial", 7F, FontStyle.Bold)
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					title2.Text = "True vertical depth (m)"
				Else
					title2.Text = "True vertical depth (ft)"
				End If
				title2.TextColor = Color.Black
				axis2.Max = 0.0
				axis2.Min = CDbl(Me.fSideLoadYMin)
				axis2.Notify = True
				If bLarge Then
					axis2.Title.Alignment = StringAlignment.Center
					axis2.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
				Else
					axis2.Title.Font = New Font("Arial", 7F, FontStyle.Bold)
				End If
				chart.LegendBox.Visible = False
				chart.ToolBar.Visible = False
				If bLarge Then
					chart.Titles(0).Font = New Font("Arial", 10F, FontStyle.Bold)
					chart.AllSeries.Line.Width = 2S
				Else
					chart.Titles(0).Font = New Font("Arial", 7F, FontStyle.Bold)
					chart.AllSeries.Line.Width = 1S
				End If
				chart.Refresh()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowSurveyNS(ByRef Chart As ChartFX.WinForms.Chart, Optional bLarge As Boolean = False)
			Dim num As Single = 100000F
			Dim axisX As ChartFX.WinForms.Axis = Chart.AxisX
			Dim axisY As ChartFX.WinForms.Axis = Chart.AxisY
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Dim num2 As Double = 0.0
			Dim num3 As Double = 0.0
			Dim chart As ChartFX.WinForms.Chart = Chart
			chart.Data.Series = 1
			chart.Data.Points = impredObj.num_rod_elements
			chart.LegendBox.Visible = True
			Dim legendItemAttributes As LegendItemAttributes = New LegendItemAttributes()
			legendItemAttributes.Visible = False
			chart.LegendBox.ItemAttributes(chart.Series) = legendItemAttributes
			chart.LegendBox.CustomItems.Clear()
			Dim num4 As Long = 0L
			Dim num5 As Long = CLng((impredObj.num_rod_elements - 1))
			Dim axis As ChartFX.WinForms.Axis
			For num6 As Long = num4 To num5
				Dim rod_element_data_type As TEImpred.rod_element_data_type = impredObj.get_r_e(CInt((num6 + 1L)))
				Dim num7 As Single = CSng(-CSng(rod_element_data_type.pos.z))
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					CtrlUI.ConvertValue(num7, "f", False)
				End If
				chart.Data.Y(0, CInt(num6)) = CDbl(num7)
				If CDbl(Math.Abs(num7)) > num3 Then
					num3 = CDbl(Math.Abs(num7))
				End If
				rod_element_data_type = impredObj.get_r_e(CInt((num6 + 1L)))
				num7 = CSng(rod_element_data_type.pos.y)
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					CtrlUI.ConvertValue(num7, "f", False)
				End If
				chart.Data.X(0, CInt(num6)) = CDbl(num7)
				If num7 < num Then
					num = num7
				End If
				If CDbl(Math.Abs(num7)) > num2 Then
					num2 = CDbl(Math.Abs(num7))
				End If
				chart.Points(0, 1).Line.Style = DashStyle.Dot
				Dim pointAttributes As PointAttributes = chart.Points(0, CInt(num6))
				rod_element_data_type = impredObj.get_r_e(CInt((num6 + 1L)))
				pointAttributes.Color = Me.GetLineColor(CSng(rod_element_data_type.m_d))
			Next
			chart.LegendBox.Border = DockBorder.None
			axis = axisX
			Dim title As ChartFX.WinForms.Title = axis.Title
			title.Alignment = StringAlignment.Center
			title.Font = New Font("Arial", 7F, FontStyle.Bold)
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				title.Text = "South                 distance (m)                 North"
			Else
				title.Text = "South                 distance (ft)                 North"
			End If
			title.TextColor = Color.Black
			If num2 > CDbl(Me.fMaxForCharts) Then
				axis.Max = CDbl(Me.GetAxisMinMax(CSng(num2), CSng((num2 * -1.0))))
				axis.Min = axis.Max * -1.0
			Else
				axis.Max = CDbl(Me.GetAxisMinMax(Me.fMaxForCharts, Me.fMaxForCharts * -1F))
				axis.Min = axis.Max * -1.0
			End If
			If bLarge Then
				axis.Title.Alignment = StringAlignment.Center
				axis.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			Else
				axis.Title.Font = New Font("Arial", 7F, FontStyle.Bold)
			End If
			Dim axis2 As ChartFX.WinForms.Axis = axisY
			Dim title2 As ChartFX.WinForms.Title = axis2.Title
			title2.Font = New Font("Arial", 7F, FontStyle.Bold)
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				title2.Text = "True vertical depth (m)"
			Else
				title2.Text = "True vertical depth (ft)"
			End If
			title2.TextColor = Color.Black
			axis2.Max = 0.0
			axis2.Min = CDbl(Me.fSideLoadYMin)
			axis2.Notify = True
			If bLarge Then
				axis2.Title.Alignment = StringAlignment.Center
				axis2.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			Else
				axis2.Title.Font = New Font("Arial", 7F, FontStyle.Bold)
			End If
			chart.LegendBox.Visible = False
			chart.ToolBar.Visible = False
			If bLarge Then
				chart.Titles(0).Font = New Font("Arial", 10F, FontStyle.Bold)
				chart.AllSeries.Line.Width = 2S
			Else
				chart.Titles(0).Font = New Font("Arial", 7F, FontStyle.Bold)
				chart.AllSeries.Line.Width = 1S
			End If
			chart.Refresh()
		End Sub

		Private Sub ShowSurveyPlan(ByRef Chart As ChartFX.WinForms.Chart, Optional bLarge As Boolean = False)
			Dim axisX As AxisX = Chart.AxisX
			Dim axisY As AxisY = Chart.AxisY
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Dim num As Double = 0.0
			Dim num2 As Double = 0.0
			Dim chart As ChartFX.WinForms.Chart = Chart
			chart.Data.Series = 1
			chart.Data.Points = impredObj.num_rod_elements
			chart.LegendBox.Visible = True
			Dim legendItemAttributes As LegendItemAttributes = New LegendItemAttributes()
			legendItemAttributes.Visible = False
			chart.LegendBox.ItemAttributes(chart.Series) = legendItemAttributes
			chart.LegendBox.CustomItems.Clear()
			Dim num3 As Long = 0L
			Dim num4 As Long = CLng((impredObj.num_rod_elements - 1))
			Dim axisX2 As AxisX
			Dim num7 As Double
			For num5 As Long = num3 To num4
				Dim rod_element_data_type As TEImpred.rod_element_data_type = impredObj.get_r_e(CInt((num5 + 1L)))
				Dim num6 As Single = CSng(rod_element_data_type.pos.y)
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					CtrlUI.ConvertValue(num6, "f", False)
				End If
				chart.Data.Y(0, CInt(num5)) = CDbl(num6)
				If CDbl(Math.Abs(num6)) > num2 Then
					num2 = CDbl(Math.Abs(num6))
				End If
				rod_element_data_type = impredObj.get_r_e(CInt((num5 + 1L)))
				num6 = CSng(rod_element_data_type.pos.x)
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					CtrlUI.ConvertValue(num6, "f", False)
				End If
				chart.Data.X(0, CInt(num5)) = CDbl(num6)
				If CDbl(Math.Abs(num6)) > num Then
					num = CDbl(Math.Abs(num6))
				End If
				chart.Points(0, 1).Line.Style = DashStyle.Dot
				Dim pointAttributes As PointAttributes = chart.Points(0, CInt(num5))
				rod_element_data_type = impredObj.get_r_e(CInt((num5 + 1L)))
				pointAttributes.Color = Me.GetLineColor(CSng(rod_element_data_type.m_d))
			Next
			chart.LegendBox.Border = DockBorder.None
			axisX2 = axisX
			Dim title As ChartFX.WinForms.Title = axisX2.Title
			title.Alignment = StringAlignment.Center
			title.Font = New Font("Arial", 7F, FontStyle.Bold)
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				title.Text = "West                 distance (m)                 East"
			Else
				title.Text = "West                 distance (ft)                 East"
			End If
			title.TextColor = Color.Black
			If num > num2 Then
				num7 = num
			Else
				num7 = num2
			End If
			If num7 > CDbl(Me.fMaxForCharts) Then
				axisX2.Max = CDbl(Me.GetAxisMinMax(CSng(num7), CSng((num7 * -1.0))))
				axisX2.Min = axisX2.Max * -1.0
			Else
				axisX2.Max = CDbl(Me.GetAxisMinMax(Me.fMaxForCharts, Me.fMaxForCharts * -1F))
				axisX2.Min = axisX2.Max * -1.0
			End If
			If bLarge Then
				axisX2.Title.Alignment = StringAlignment.Center
				axisX2.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			Else
				axisX2.Title.Font = New Font("Arial", 7F, FontStyle.Bold)
			End If
			Dim axisY2 As AxisY = axisY
			Dim title2 As ChartFX.WinForms.Title = axisY2.Title
			title2.Font = New Font("Arial", 7F, FontStyle.Bold)
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				title2.Text = "South         distance (m)         North"
			Else
				title2.Text = "South         distance (ft)         North"
			End If
			title2.TextColor = Color.Black
			If num7 > CDbl(Me.fMaxForCharts) Then
				axisY2.Max = CDbl(Me.GetAxisMinMax(CSng(num7), CSng((num7 * -1.0))))
				axisY2.Min = axisY2.Max * -1.0
			Else
				axisY2.Max = CDbl(Me.GetAxisMinMax(Me.fMaxForCharts, Me.fMaxForCharts * -1F))
				axisY2.Min = axisY2.Max * -1.0
			End If
			If bLarge Then
				axisY2.Title.Alignment = StringAlignment.Center
				axisY2.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			Else
				axisY2.Title.Font = New Font("Arial", 7F, FontStyle.Bold)
			End If
			If bLarge Then
				chart.Titles(0).Font = New Font("Arial", 10F, FontStyle.Bold)
				chart.AllSeries.Line.Width = 2S
			Else
				chart.Titles(0).Font = New Font("Arial", 7F, FontStyle.Bold)
				chart.AllSeries.Line.Width = 1S
			End If
			chart.Refresh()
		End Sub

		Private Function GetAxisMinMax(Max As Single, Min As Single) As Single
			Dim num As Single
			If Math.Abs(Max) > Math.Abs(Min) Then
				num = Math.Abs(Max)
			Else
				num = Math.Abs(Min)
			End If
			Dim num2 As Integer = 1
			Dim num3 As Single
			While Not(num >= CSng((num2 * 100)) And num < CSng(((num2 + 1) * 100)))
				num2 += 1
				If num2 > 400 Then
					IL_4E:
					If num3 = 0F Then
						num3 = 100F
					End If
					Return num3
				End If
			End While
			num3 = CSng(((num2 + 1) * 100))
			GoTo IL_4E
		End Function

		Public Function FindMaxForCharts() As Single
			Dim num As Single = -10000000F
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Dim num2 As Integer = 0
			Dim num3 As Integer = impredObj.num_rod_elements - 1
			For i As Integer = num2 To num3
				Dim rod_element_data_type As TEImpred.rod_element_data_type = impredObj.get_r_e(i + 1)
				Dim value As Single = CSng(-CSng(rod_element_data_type.pos.x))
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					CtrlUI.ConvertValue(value, "f", False)
				End If
				Dim num4 As Single
				If Math.Abs(value) > num4 Then
					num4 = Math.Abs(value)
				End If
				If num4 >= num Then
					num = num4
				End If
				rod_element_data_type = impredObj.get_r_e(i + 1)
				Dim value2 As Single = CSng(-CSng(rod_element_data_type.pos.y))
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					CtrlUI.ConvertValue(value2, "f", False)
				End If
				Dim num5 As Single
				If Math.Abs(value2) > num5 Then
					num5 = Math.Abs(value2)
				End If
				If num5 >= num Then
					num = num5
				End If
			Next
			Return num
		End Function

		Public Sub DoSeveralDoEvents()
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 1
				Do
					Application.DoEvents()
					num += 1
				Loop While num <= 1000
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnDevCharts_Click(sender As Object, e As EventArgs)
			Try
				Me.bCommanderClicked = False
				Me.optReport_Click_1(6S, True, True)
			Catch ex As Exception
				Util.UnbusyCursor()
			End Try
		End Sub

		Public Sub ShowDevPlot(I As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Me.ChartFX_AxialLoads.Visible = False
				Me.ChartFX_BucklingTendency.Visible = False
				Me.ChartFX_SideLoading.Visible = False
				Me.ChartFX_LookingNorth.Visible = False
				Me.ChartFX_LookingEast.Visible = False
				Me.ChartFX_LookingDown.Visible = False
				Me.ChartFX_DoglegSeverity.Visible = False
				Me.pnlGrpDevPlot.Visible = False
				Me.ResetClock()
				Me.bViewing3DPlot = False
				If I = 1 Then
					Me.btnPrevDevChart.Enabled = False
				Else
					Me.btnPrevDevChart.Enabled = True
				End If
				If I = 8 Then
					Me.btnNextDevChart.Enabled = False
				Else
					Me.btnNextDevChart.Enabled = True
				End If
				Select Case I
					Case 1
						Me.ChartFX_SideLoading.BringToFront()
						Me.ChartFX_SideLoading.Visible = True
					Case 2
						Me.ChartFX_AxialLoads.BringToFront()
						Me.ChartFX_AxialLoads.Visible = True
					Case 3
						Me.ChartFX_BucklingTendency.BringToFront()
						Me.ChartFX_BucklingTendency.Visible = True
					Case 4
						Me.ChartFX_DoglegSeverity.BringToFront()
						Me.ChartFX_DoglegSeverity.Visible = True
					Case 5
						Me.ChartFX_LookingEast.BringToFront()
						Me.ChartFX_LookingEast.Visible = True
					Case 6
						Me.ChartFX_LookingNorth.BringToFront()
						Me.ChartFX_LookingNorth.Visible = True
					Case 7
						Me.ChartFX_LookingDown.BringToFront()
						Me.ChartFX_LookingDown.Visible = True
					Case 8
						Me.PlotSurvey()
						Me.pnlGrpDevPlot.Left = 30
						Me.pnlGrpDevPlot.Top = 10
						Me.pnlGrpDevPlot.Height = Me.btnPrevDevChart.Top - 20
						Me.pnlGrpDevPlot.Width = Me.pnlDevCharts.Width - 60
						Me.pnlGrpDevPlot.BringToFront()
						Me.TChart1.Left = 0
						Me.TChart1.Top = Me.pnlCommander.Top + Me.pnlCommander.Height + 5
						Me.TChart1.Height = Me.pnlLegend.Top - Me.TChart1.Top - 5
						Me.TChart1.Width = Me.pnlGrpDevPlot.Width
						Me.TChart1.Refresh()
						Me.pnlGrpDevPlot.BringToFront()
						Me.pnlGrpDevPlot.Visible = True
						Me.pnlLegend.SendToBack()
						Me.bViewing3DPlot = True
				End Select
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnNextDevChart_Click(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.bCommanderClicked = False
			Me.m_iDevChart += 1
			If Me.m_iDevChart > 8 Then
				Me.m_iDevChart = 8
			End If
			Me.ShowDevPlot(Me.m_iDevChart)
		End Sub

		Private Sub btnPrevDevChart_Click(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.m_iDevChart -= 1
			If Me.m_iDevChart < 1 Then
				Me.m_iDevChart = 1
			End If
			Me.ShowDevPlot(Me.m_iDevChart)
		End Sub

		Private Sub CenterChartInPanel(pnl As System.Windows.Forms.Panel, ByRef Chart As ChartFX.WinForms.Chart)
			' The following expression was wrapped in a checked-statement
			Try
				Chart.Left = CInt(Math.Round(CDbl((pnl.Width - Chart.Width)) / 2.0))
				Chart.Top = CInt(Math.Round(CDbl((pnl.Height - Chart.Height)) / 2.0))
				If Chart.Top > 5 Then
					Chart.Top = 5
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub tbbRunPause_Click(sender As Object, e As EventArgs)
			Me.iAnimationCycle = 0
			Me.RunAutomation()
		End Sub

		Private Sub MakeSureAnimationIsntRunning()
			Try
				Me.tbbRun.BringToFront()
				RSWIN_DESC.bAnimating = False
				Me._optReport_0.Enabled = True
				Me._optReport_1.Enabled = True
				Me._optReport_2.Enabled = True
				Me.cmdIPRPlot.Enabled = True
				Me.btnDevCharts.Enabled = True
				Me.cmdIPRPlot.Enabled = RSWIN_DESC.rst.gbUseIPR
				Me.bPlay = False
				Me.bTogglePlay = False
				Me.timAnimate.[Stop]()
				Me.timAnimate.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		Public Sub SetAnimateButtonsVisible(bVisible As Boolean)
			Try
				Me.TrackBar1.Visible = bVisible
				Me.tbbRun.Visible = bVisible
				Me.tbbStop.Visible = bVisible
				Me.tbbStep.Visible = bVisible
				Me.tbbRunPause.Visible = bVisible
				Me.lblAnimateDyno.Visible = bVisible
				If Not bVisible Then
					Try
						Me.tbbStop.PerformClick()
					Catch ex As Exception
					End Try
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub CenterForm()
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				Me.Left = 0
				Me.Top = 0
			Catch ex2 As Exception
			End Try
		End Sub

		Private Function SetDoglegColumnHeader() As Object
			Dim result As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				result = "Dogleg Severity °/100ft"
			Else
				result = "Dogleg Severity °/30m"
			End If
			Return result
		End Function

		Private Sub PlotSurvey()
			Try
				If RSWIN_DESC.bRodStarD And RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 2 Then
					Me.TChart1.Visible = False
					Me.iGetPointStyle1 = 0
					Me.iGetPointStyle1_report = 0
					Me.iGetPointStyle2 = 0
					Me.iGetPointStyle2_report = 0
					Me.m_bAfterPump1 = False
					Me.m_bAfterPump2 = False
					Me.m_bAfterPump1_report = False
					Me.m_bAfterPump2_report = False
					If Not Me.bDogLegsCalculated Then
						Me.ShowDeviation_Dogleg(RSWIN_DESC.mdsDeviationProfile, True, False)
						Dim num As Short
						Me.ShowDeviation_TVD(RSWIN_DESC.mdsDeviationProfile, True, num)
						Me.bDogLegsCalculated = True
					ElseIf Not Me.bPlotSurveyPointLevel Then
						Dim xval As Double() = New Double(0) {}
						Dim yval As Double() = New Double(0) {}
						Dim zval As Double() = New Double(0) {}
						Dim array As Double() = New Double(0) {}
						Dim tchart As TChart = Me.TChart1
						Dim points3D As Points3D = Me.point3DSeries1
						Dim points3D2 As Points3D = Me.point3DSeries2
						Me.ReplotTeeChart_re_level(tchart, points3D, points3D2, xval, yval, zval, array, True, True, True)
						Me.point3DSeries2 = points3D2
						Me.point3DSeries1 = points3D
						Me.TChart1 = tchart
						tchart = Me.TChart1_Report
						points3D2 = Me.point3DSeries1_report
						points3D = Me.point3DSeries2_report
						Me.ReplotTeeChart_re_level(tchart, points3D2, points3D, xval, yval, zval, array, True, False, True)
						Me.point3DSeries2_report = points3D
						Me.point3DSeries1_report = points3D2
						Me.TChart1_Report = tchart
					End If
					Me.TChart1.Visible = True
					Me.commander1.Visible = True
					Me.btnResetPlot.Visible = True
					Me.lblNoData.Visible = False
					Application.DoEvents()
				Else
					Me.TChart1.Visible = False
					Me.commander1.Visible = False
					Me.btnResetPlot.Visible = False
					Me.lblNoData.Visible = True
					Application.DoEvents()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowDeviation_Dogleg(ByRef dsDeviationProfile As DataSet, bPlotData As Boolean, Optional bChangeAll As Boolean = False)
			Try
				Dim dataView As DataView = New DataView(dsDeviationProfile.Tables(0))
				Dim flag As Boolean = False
				Try
					Dim text As String = "MeasurementSystem"
					Dim num As Integer = 1
					RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_GENERAL, text, num))
					If Not(RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Or RSWIN_DESC.SETUP_MeasurementSystem = 3) Then
						RSWIN_DESC.SETUP_MeasurementSystem = 1
						text = "MeasurementSystem"
						Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
						Dim text2 As String = Util.Format(obj)
						RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
						Dim text3 As String = text2
						Dim num2 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
					End If
				Catch ex As Exception
					RSWIN_DESC.SETUP_MeasurementSystem = 1
					Dim text3 As String = "MeasurementSystem"
					Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
					Dim text4 As String = Util.Format(obj)
					RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
					Dim text As String = text4
					Dim num2 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text3, text, RSWIN_DESC.sINIFile)
				End Try
				Dim num3 As Double = 2.0 * Math.Atan(1.0)
				Dim num4 As Integer = dsDeviationProfile.Tables(0).Rows.Count
				Dim num5 As Short = CShort(dsDeviationProfile.Tables(0).Rows.Count)
				Dim array As Double() = New Double(num4 + 1 - 1) {}
				Dim array2 As Double() = New Double(num4 + 1 - 1) {}
				Dim array3 As Double() = New Double(num4 + 1 - 1) {}
				Dim array4 As Double() = New Double(num4 + 1 - 1) {}
				Dim array5 As Double() = New Double(num4 + 1 - 1) {}
				Dim array6 As Double() = New Double(num4 + 1 - 1) {}
				Dim array7 As Double() = New Double(num4 + 1 - 1) {}
				If Me.m_MeasDepth Is Nothing Then
					Me.m_MeasDepth = New Double(num4 + 1 - 1) {}
				End If
				Dim array8 As Double() = New Double(num4 + 1 - 1) {}
				Dim array9 As Double() = New Double(num4 + 1 - 1) {}
				Dim array10 As Double() = New Double(num4 + 1 - 1) {}
				Dim array11 As Single() = New Single(num4 + 1 - 1) {}
				Dim array12 As Results.survey_point_type() = New Results.survey_point_type(num4 + 1 - 1) {}
				Dim num6 As Single = 1E-06F
				num4 = 0
				Dim num7 As Double = 0.0
				Try
					Try
						For Each obj2 As Object In dataView
							Dim dataRowView As DataRowView = CType(obj2, DataRowView)
							Dim row As DataRow = dataRowView.Row
							Dim num8 As Double = Conversions.ToDouble(row(1))
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Dim num9 As Single = CSng(num8)
								CtrlUI.ConvertValue(num9, "f", True)
								num8 = CDbl(num9)
							End If
							Dim text5 As String = Conversions.ToString(row(2))
							Dim text6 As String = Conversions.ToString(row(3))
							If Not Versioned.IsNumeric(text6) Then
								text6 = MImpred.AzimuthCheck(text6)
							End If
							If Not Versioned.IsNumeric(text5) Then
								text5 = MImpred.InclinationCheck(text5)
							End If
							If Versioned.IsNumeric(text6) And Versioned.IsNumeric(text5) Then

									Dim num10 As Double = Convert.ToDouble(text5) / 180.0 * 3.141592653589793
									Dim num11 As Double = Convert.ToDouble(text6)
									If num11 < 0.0 Then
										num11 = 360.0 + num11
									End If
									Dim num12 As Double = num11 / 180.0 * 3.141592653589793
									Dim num13 As Double = num8 - num7
									array11(num4) = CSng(num13)
									num7 = num8
									array12(num4).m_d = num8
									array12(num4).inc = num10
									array12(num4).azi = num12
									array7(num4) = num8
									Me.m_MeasDepth(num4) = array7(num4)
									array8(num4) = num13 * Math.Sin(num10) * Math.Sin(num12)
									array9(num4) = num13 * Math.Sin(num10) * Math.Cos(num12)
									array10(num4) = num13 * Math.Cos(num10)
									array(num4) = Math.Sin(num10) * Math.Sin(num12)
									array2(num4) = Math.Sin(num10) * Math.Cos(num12)
									array3(num4) = Math.Cos(num10)
									array12(num4).tan.X = array(num4)
									array12(num4).tan.Y = array2(num4)
									array12(num4).tan.z = array3(num4)

								num4 += 1
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				Catch ex2 As Exception
				End Try
				If num4 > 1 Then
					array = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array, Array), New Double(num4 - 1 + 1 - 1) {}), Double())
					array2 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array2, Array), New Double(num4 - 1 + 1 - 1) {}), Double())
					array3 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array3, Array), New Double(num4 - 1 + 1 - 1) {}), Double())
					array12 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array12, Array), New Results.survey_point_type(num4 - 1 + 1 - 1) {}), Results.survey_point_type())
					array4 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array4, Array), New Double(num4 - 1 + 1 - 1) {}), Double())
					array5 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array5, Array), New Double(num4 - 1 + 1 - 1) {}), Double())
					array6 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array6, Array), New Double(num4 - 1 + 1 - 1) {}), Double())
					Dim num14 As Integer = 0
					array5(0) = 0.0
					Try
						Try
							For Each obj3 As Object In dataView
								Dim dataRowView As DataRowView = CType(obj3, DataRowView)
								Dim row As DataRow = dataRowView.Row

									If num14 > 0 AndAlso num14 < num4 Then
										' The following expression was wrapped in a checked-expression
										array(num14) += array(num14 - 1)
										array2(num14) += array2(num14 - 1)
										array3(num14) += array3(num14 - 1)
										array8(num14) += array8(num14 - 1)
										array9(num14) += array9(num14 - 1)
										array10(num14) += array10(num14 - 1)
										If bChangeAll Then
											If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
												Dim num15 As Single = CSng(array10(num14))
												row(5) = Math.Round(CDbl((num15 * RSWIN_DESC.FT__M)), 2)
												row.AcceptChanges()
											Else
												row(5) = Math.Round(array10(num14), 2)
												row.AcceptChanges()
											End If
										End If
										Try
											array5(num14) = Math.Round(array10(num14), 2)
										Catch ex3 As Exception
										End Try
									End If

								num14 += 1
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
						Try
							dsDeviationProfile.AcceptChanges()
						Catch ex4 As Exception
						End Try
					Catch ex5 As Exception
					End Try
				End If
				If num4 > 2 Then
					Dim num16 As Double = 0.0
					Dim num17 As Double = 0.0
					Dim num18 As Double = 1.0
					flag = False
					Dim num14 As Integer = 0
					Try
						Try
							For Each obj4 As Object In dataView
								Dim dataRowView As DataRowView = CType(obj4, DataRowView)
								Dim row As DataRow = dataRowView.Row
								If num14 = 0 Then
									Try
										If Operators.ConditionalCompareObjectEqual(row(1), 0, False) Then
											flag = True
										End If
									Catch ex6 As Exception
									End Try
								End If
								Dim num19 As Double
								Dim num20 As Double
								Dim num21 As Double

									If num14 > 0 AndAlso num14 < num4 Then
										' The following expression was wrapped in a checked-expression
										num19 = array(num14) - array(num14 - 1)
										num20 = array2(num14) - array2(num14 - 1)
										num21 = array3(num14) - array3(num14 - 1)
										Dim num22 As Double = num16 * num19 + num17 * num20 + num18 * num21
										Dim num23 As Double
										If num22 <> 0.0 Then
											num23 = kinemat.ArcCosine(CSng(num22))
										Else
											num23 = 0.0
										End If
										If num23 < 0.0 Then
											num23 += 2.0 * num3
										End If
										If Not bPlotData Then
											If array11(num14) <> 0F Then
												row(4) = Math.Round(num23 / num3 * 90.0 / CDbl(array11(num14)) * 100.0, 2)
												row.AcceptChanges()
											Else
												row(4) = 0
												row.AcceptChanges()
											End If
										End If
									End If

								num14 += 1
								num16 = num19
								num17 = num20
								If num14 = 1 AndAlso flag Then
									num18 = 1.0
								Else
									num18 = num21
								End If
							Next
						Finally
							Dim enumerator3 As IEnumerator
							If TypeOf enumerator3 Is IDisposable Then
								TryCast(enumerator3, IDisposable).Dispose()
							End If
						End Try
						Try
							dsDeviationProfile.AcceptChanges()
						Catch ex7 As Exception
						End Try
					Catch ex8 As Exception
					End Try
					num5 = CShort(Information.UBound(array12, 1))
					Dim num24 As Short = 0S
					Dim num25 As Short = CShort((Information.UBound(array12, 1) - 1))
					Dim num26 As Short

						num26 = num24
						While num26 <= num25
							' The following expression was wrapped in a checked-expression
							Dim num27 As Double = Me.dot_prod(array12(CInt(num26)).tan, array12(CInt((num26 + 1S))).tan)
							If num27 > 1.0 AndAlso num27 <= CDbl((1F + num6)) Then
								num27 = 1.0
							End If
							If num27 < 0.0 AndAlso num27 >= CDbl((-CDbl(num6))) Then
								num27 = 0.0
							End If
							array12(CInt(num26)).dog = kinemat.ArcCosine(CSng(num27))
							If array12(CInt(num26)).dog > CDbl(num6) Then
								' The following expression was wrapped in a checked-expression
								array12(CInt(num26)).rad = (array12(CInt((num26 + 1S))).m_d - array12(CInt(num26)).m_d) / array12(CInt(num26)).dog
							Else
								array12(CInt(num26)).rad = -9999.0
							End If
							num26 += 1S
						End While

					num5 = CShort(Information.UBound(array12, 1))
					num26 = num5 - 1S
					array12(CInt(num26)).dog = -9999.0
					array12(CInt(num26)).rad = -9999.0
					Dim num28 As Short = 0S
					Dim num29 As Short = num5 - 2S

						num26 = num28
						While num26 <= num29
							If array12(CInt(num26)).dog > CDbl(num6) Then
								' The following expression was wrapped in a checked-expression
								Me.calc_nor(array12(CInt(num26)).nor, array12(CInt(num26)).tan, array12(CInt((num26 + 1S))).tan)
							Else
								array12(CInt(num26)).nor.X = -9999.0
								array12(CInt(num26)).nor.Y = -9999.0
								array12(CInt(num26)).nor.z = -9999.0
							End If
							num26 += 1S
						End While

					num26 = num5 - 1S
					num26 = 0S
					array12(CInt(num26)).pos.X = 0.0
					array12(CInt(num26)).pos.Y = 0.0
					array12(CInt(num26)).pos.z = 0.0
					Dim num30 As Short = 1S
					Dim num31 As Short = num5 - 1S
					num26 = num30
					While num26 <= num31
						If array12(CInt((num26 - 1S))).dog > CDbl(num6) Then
							Me.calc_pos(array12(CInt(num26)).pos, array12(CInt((num26 - 1S))).pos, array12(CInt((num26 - 1S))).tan, array12(CInt((num26 - 1S))).nor, array12(CInt((num26 - 1S))).dog, array12(CInt((num26 - 1S))).rad)
						Else
							Me.calc_str(array12(CInt(num26)).pos, array12(CInt((num26 - 1S))).pos, array12(CInt((num26 - 1S))).tan, array12(CInt(num26)).m_d, array12(CInt((num26 - 1S))).m_d)
						End If
						num26 = num26 + 1S
					End While
					num14 = 0
					array4(num14) = 0.0
					array6(num14) = 0.0
					Try
						For Each obj5 As Object In dataView
							Dim dataRowView As DataRowView = CType(obj5, DataRowView)
							Dim row As DataRow = dataRowView.Row

								If bChangeAll Then
									Try
										If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
											Dim num15 As Single = CSng(Math.Round(array12(num14).pos.Y, 2))
											row(6) = Math.Round(CDbl((num15 * RSWIN_DESC.FT__M)), 2)
											num15 = CSng(Math.Round(array12(num14).pos.X, 2))
											row(7) = Math.Round(CDbl((num15 * RSWIN_DESC.FT__M)), 2)
											row.AcceptChanges()
										Else
											row(6) = Math.Round(array12(num14).pos.Y, 2)
											row(7) = Math.Round(array12(num14).pos.X, 2)
											row.AcceptChanges()
										End If
									Catch ex9 As Exception
									End Try
								End If

							Try
								If num14 < CInt((num5 + 1S)) Then
									array4(num14) = array12(num14).pos.X
									array6(num14) = array12(num14).pos.Y
								End If
							Catch ex10 As Exception
							End Try
							num14 += 1
						Next
					Finally
						Dim enumerator4 As IEnumerator
						If TypeOf enumerator4 Is IDisposable Then
							TryCast(enumerator4, IDisposable).Dispose()
						End If
					End Try
				End If
				Try
					dsDeviationProfile.AcceptChanges()
				Catch ex11 As Exception
				End Try
			Catch ex12 As Exception
			End Try
		End Sub

		Private Sub ShowDeviation_TVD(ByRef dsDeviationProfile As DataSet, bPlotData As Boolean, ByRef iostat As Short)
			Try
				Dim dataView As DataView = New DataView(dsDeviationProfile.Tables(0))
				Dim num As Double = 2.0 * Math.Atan(1.0)
				num = 2.0 * Math.Atan(1.0)
				Dim num2 As Integer = dsDeviationProfile.Tables(0).Rows.Count
				Dim num3 As Short = CShort(dsDeviationProfile.Tables(0).Rows.Count)
				Dim array As Double() = New Double(num2 + 1 - 1) {}
				Me.m_MeasDepth = New Double(num2 + 1 - 1) {}
				Dim array2 As Single() = New Single(num2 + 1 - 1) {}
				Dim array3 As Results.survey_point_type() = New Results.survey_point_type(num2 + 1 - 1) {}
				Dim array4 As Double() = New Double(num2 + 1 - 1) {}
				Me.m_TVDepth = New Double(num2 + 1 - 1) {}
				Dim array5 As Double() = New Double(num2 + 1 - 1) {}
				Dim array6 As Double() = New Double(num2 + 1 - 1) {}
				Dim array7 As Double() = New Double(num2 + 1 - 1) {}
				Try
					Dim text As String = "MeasurementSystem"
					Dim num4 As Integer = 1
					RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_GENERAL, text, num4))
					If Not(RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Or RSWIN_DESC.SETUP_MeasurementSystem = 3) Then
						RSWIN_DESC.SETUP_MeasurementSystem = 1
						text = "MeasurementSystem"
						Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
						Dim text2 As String = Util.Format(obj)
						RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
						Dim text3 As String = text2
						Dim num5 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
					End If
				Catch ex As Exception
					RSWIN_DESC.SETUP_MeasurementSystem = 1
					Dim text3 As String = "MeasurementSystem"
					Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
					Dim text4 As String = Util.Format(obj)
					RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
					Dim text As String = text4
					Dim num5 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text3, text, RSWIN_DESC.sINIFile)
				End Try
				Dim parameter_structure_type As Results.parameter_structure_type
				parameter_structure_type.epsilon = 1E-06
				num2 = 0
				Dim num6 As Double = 0.0
				array2(0) = 0F
				Try
					Try
						For Each obj2 As Object In dataView
							Dim dataRowView As DataRowView = CType(obj2, DataRowView)
							Dim row As DataRow = dataRowView.Row
							Dim num7 As Double = Conversions.ToDouble(row(1))
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Dim num8 As Single = CSng(num7)
								CtrlUI.ConvertValue(num8, "f", True)
								num7 = CDbl(num8)
							End If
							Dim text5 As String = Conversions.ToString(row(2))
							Dim text6 As String = Conversions.ToString(row(3))
							If Not Versioned.IsNumeric(text6) Then
								text6 = MImpred.AzimuthCheck(text6)
							End If
							If Not Versioned.IsNumeric(text5) Then
								text5 = MImpred.InclinationCheck(text5)
							End If
							If Versioned.IsNumeric(text6) And Versioned.IsNumeric(text5) Then
								num2 += 1
								Dim num9 As Double = Convert.ToDouble(text6)
								Dim num10 As Double = Convert.ToDouble(text5)

									array3(num2).azi = num9 / 180.0 * 3.141592653589793
									array3(num2).inc = num10 / 180.0 * 3.141592653589793
									Dim num11 As Double = num7 - num6
									array2(num2) = CSng(num11)
									num6 = num7
									array3(num2).m_d = num7
									array(num2) = num7
									Me.m_MeasDepth(num2) = array(num2)

							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					Try
						dsDeviationProfile.AcceptChanges()
					Catch ex2 As Exception
					End Try
				Catch ex3 As Exception
				End Try
				Try
					iostat = 0S
					parameter_structure_type.num_survey_points = dsDeviationProfile.Tables(0).Rows.Count
					Dim num12 As Short = 1S
					Dim num13 As Short = CShort(parameter_structure_type.num_survey_points)

						For num14 As Short = num12 To num13
							array3(CInt(num14)).tan.X = Math.Sin(array3(CInt(num14)).inc) * Math.Sin(array3(CInt(num14)).azi)
							array3(CInt(num14)).tan.Y = Math.Sin(array3(CInt(num14)).inc) * Math.Cos(array3(CInt(num14)).azi)
							array3(CInt(num14)).tan.z = Math.Cos(array3(CInt(num14)).inc)
						Next

				Catch ex4 As Exception
				End Try
				Try
					Dim num15 As Short = 1S
					Dim num16 As Short = CShort((parameter_structure_type.num_survey_points - 1))

						For num14 As Short = num15 To num16
							' The following expression was wrapped in a checked-expression
							Dim num17 As Double = Me.dot_prod(array3(CInt(num14)).tan, array3(CInt((num14 + 1S))).tan)
							If num17 > 1.0 Then
								If num17 <= 1.0 + parameter_structure_type.epsilon Then
									num17 = 1.0
								Else
									iostat = -9941S
								End If
							End If
							If num17 < 0.0 Then
								If num17 >= -parameter_structure_type.epsilon Then
									num17 = 0.0
								Else
									iostat = -9942S
								End If
							End If
							array3(CInt(num14)).dog = kinemat.ArcCosine(CSng(num17))
							If array3(CInt(num14)).dog > parameter_structure_type.epsilon Then
								' The following expression was wrapped in a checked-expression
								array3(CInt(num14)).rad = (array3(CInt((num14 + 1S))).m_d - array3(CInt(num14)).m_d) / array3(CInt(num14)).dog
							Else
								array3(CInt(num14)).rad = -9999.0
							End If
						Next

				Catch ex5 As Exception
				End Try
				Try
					Dim num14 As Short = CShort(parameter_structure_type.num_survey_points)
					array3(CInt(num14)).dog = -9999.0
					array3(CInt(num14)).rad = -9999.0
					Dim num18 As Short = 1S
					Dim num19 As Short = CShort((parameter_structure_type.num_survey_points - 1))

						num14 = num18
						While num14 <= num19
							If array3(CInt(num14)).dog > parameter_structure_type.epsilon Then
								' The following expression was wrapped in a checked-expression
								Me.calc_nor(array3(CInt(num14)).nor, array3(CInt(num14)).tan, array3(CInt((num14 + 1S))).tan)
							Else
								array3(CInt(num14)).nor.X = -9999.0
								array3(CInt(num14)).nor.Y = -9999.0
								array3(CInt(num14)).nor.z = -9999.0
							End If
							num14 += 1S
						End While

				Catch ex6 As Exception
				End Try
				Try
					Dim num14 As Short = CShort(parameter_structure_type.num_survey_points)
					array3(CInt(num14)).nor.X = -9999.0
					array3(CInt(num14)).nor.Y = -9999.0
					array3(CInt(num14)).nor.z = -9999.0
					num14 = 1S
					array3(CInt(num14)).pos.X = 0.0
					array3(CInt(num14)).pos.Y = 0.0
					array3(CInt(num14)).pos.z = 0.0
					Dim num20 As Short = 2S
					Dim num21 As Short = CShort(parameter_structure_type.num_survey_points)
					num14 = num20
					While num14 <= num21
						If array3(CInt((num14 - 1S))).dog > parameter_structure_type.epsilon Then
							Me.calc_pos(array3(CInt(num14)).pos, array3(CInt((num14 - 1S))).pos, array3(CInt((num14 - 1S))).tan, array3(CInt((num14 - 1S))).nor, array3(CInt((num14 - 1S))).dog, array3(CInt((num14 - 1S))).rad)
						Else
							Me.calc_str(array3(CInt(num14)).pos, array3(CInt((num14 - 1S))).pos, array3(CInt((num14 - 1S))).tan, array3(CInt(num14)).m_d, array3(CInt((num14 - 1S))).m_d)
						End If
						num14 = num14 + 1S
					End While
				Catch ex7 As Exception
				End Try
				Try
					Dim num22 As Integer = 1
					Try
						For Each obj3 As Object In dataView
							Dim dataRowView As DataRowView = CType(obj3, DataRowView)
							Dim row As DataRow = dataRowView.Row
							Try
								If num22 > 1 AndAlso num22 < num2 + 1 Then

										If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
											Dim num23 As Single = CSng(array3(num22).pos.z)
											array4(num22) = Math.Round(CDbl((num23 * RSWIN_DESC.FT__M)), 2)
											Me.m_TVDepth(num22) = array4(num22)
											num23 = CSng(array3(num22).pos.Y)
											array6(num22) = Math.Round(CDbl((num23 * RSWIN_DESC.FT__M)), 2)
											num23 = CSng(array3(num22).pos.X)
											array7(num22) = Math.Round(CDbl((num23 * RSWIN_DESC.FT__M)), 2)
										Else
											array4(num22) = Math.Round(array3(num22).pos.z, 2)
											Me.m_TVDepth(num22) = array4(num22)
											array6(num22) = Math.Round(array3(num22).pos.Y, 2)
											array7(num22) = Math.Round(array3(num22).pos.X, 2)
										End If
										If Not bPlotData Or num22 < 4 Then
											If array2(num22) <> 0F Then
												Dim dog As Double = array3(num22).dog
												If dog = -9999.0 Then
													' The following expression was wrapped in a checked-expression
													dog = array3(parameter_structure_type.num_survey_points - 1).dog
												End If
												If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
													array5(num22) = Math.Round(dog / num * 90.0 / CDbl(array2(num22)) * 100.0, 2)
												Else
													array5(num22) = Math.Round(dog / num * 90.0 / CDbl(array2(num22)) * 30.0, 2)
												End If
											Else
												array5(num22) = 0.0
											End If
										End If
										If Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectGreater(row(4), array5(num22), False), array5(num22) <> 0.0), num22 < 4)) AndAlso array(2) - array(1) < 400.0 Then
											row(4) = array5(num22)
										End If
										row(5) = array4(num22)
										row(6) = array6(num22)
										row(7) = array7(num22)
										row.AcceptChanges()

								End If
							Catch ex8 As Exception
							End Try
							num22 += 1
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					Try
						dsDeviationProfile.AcceptChanges()
					Catch ex9 As Exception
					End Try
				Catch ex10 As Exception
				End Try
				If bPlotData Then
					Me.m_bAfterPump1 = False
					Me.m_bAfterPump2 = False
					Me.m_bAfterPump1_report = False
					Me.m_bAfterPump2_report = False
					Me.ShowDeviation_Before_Plot(parameter_structure_type.num_survey_points, array3)
				End If
			Catch ex11 As Exception
			End Try
		End Sub

		Private Sub ShowDeviation_Before_Plot(num_survey_points As Integer, ByRef s_p As Results.survey_point_type())
			Try
				Dim num As Double = 2.0 * Math.Atan(1.0)
				Dim num2 As Integer
				Dim array As Results.survey_point_type()
				Dim array2 As Double()
				Dim array4 As Double()
				Dim array6 As Double()
				Dim array7 As Double()
				Dim array8 As Boolean()
				Dim array9 As Single()
				Dim num3 As Single
				Dim num7 As Integer
				Dim survey_point_type As Results.survey_point_type
				Dim num8 As Short
				Dim num9 As Short
				num2 = num_survey_points + 20
				array = New Results.survey_point_type(num2 + 1 - 1) {}
				num = 2.0 * Math.Atan(1.0)
				array2 = New Double(num2 + 1 - 1) {}
				Me.m_MeasDepth = New Double(num2 + 1 - 1) {}
				Dim array3 As Single() = New Single(num2 + 1 - 1) {}
				array4 = New Double(num2 + 1 - 1) {}
				Me.m_TVDepth = New Double(num2 + 1 - 1) {}
				Dim array5 As Double() = New Double(num2 + 1 - 1) {}
				array6 = New Double(num2 + 1 - 1) {}
				array7 = New Double(num2 + 1 - 1) {}
				array8 = New Boolean(44) {}
				array9 = New Single(44) {}
				num3 = 1E-06F
				num2 = 0
				Try
					Dim text As String = "MeasurementSystem"
					Dim num4 As Integer = 1
					RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_GENERAL, text, num4))
					If Not(RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Or RSWIN_DESC.SETUP_MeasurementSystem = 3) Then
						RSWIN_DESC.SETUP_MeasurementSystem = 1
						text = "MeasurementSystem"
						Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
						Dim text2 As String = Util.Format(obj)
						RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
						Dim text3 As String = text2
						Dim num5 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
					End If
				Catch ex As Exception
					RSWIN_DESC.SETUP_MeasurementSystem = 1
					Dim text3 As String = "MeasurementSystem"
					Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
					Dim text4 As String = Util.Format(obj)
					RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
					Dim text As String = text4
					Dim num5 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text3, text, RSWIN_DESC.sINIFile)
				End Try
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					Me.fMult = 1F
				Else
					Me.fMult = RSWIN_DESC.FT__M
				End If
				Dim i As Integer = 1
				Do
					array8(i) = False
					i += 1
				Loop While i <= 22
				i = 1
				array9(i) = 1F
				array8(i) = True
				Dim num6 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For j As Integer = num6 To numRods
					i += 1
					array9(i) = RSWIN_DESC.taper_lens(j) - 1F
					array8(i) = True
					If j < CInt(RSWIN_DESC.rst.NumRods) Then
						i += 1
						array9(i) = RSWIN_DESC.taper_lens(j) + 1F
						array8(i) = True
					Else
						i += 1
						array9(i) = RSWIN_DESC.taper_lens(j)
						array8(i) = True
					End If
					RSWIN_DESC.taper_lens(j) = RSWIN_DESC.taper_lens(j) * Me.fMult
				Next
				array9(i + 1) = array9(i) + 1F
				array8(i + 1) = True
				i += 1
				num7 = i
				survey_point_type = s_p(1)
				num8 = 1S
				num9 = CShort(num_survey_points)
				For num10 As Short = num8 To num9
					Dim num11 As Integer = 1
					Dim num12 As Integer = num7
					For i As Integer = num11 To num12
						If array8(i) And CDbl(array9(i)) < s_p(CInt(num10)).m_d Then
							num2 += 1
							Try
								array(num2) = survey_point_type
								array(num2).m_d = CDbl(array9(i))
								array2(num2) = array(num2).m_d
								Me.m_MeasDepth(num2) = array2(num2)
								array8(i) = False
							Catch ex2 As Exception
							End Try
						End If
					Next
					num2 += 1
					Try
						array(num2) = s_p(CInt(num10))
						array2(num2) = array(num2).m_d
						Me.m_MeasDepth(num2) = array2(num2)
					Catch ex3 As Exception
					End Try
					survey_point_type = s_p(CInt(num10))
				Next
				Try
					Dim num13 As Short = 1S
					Dim num14 As Short = CShort(num2)
					For num10 As Short = num13 To num14
						array(CInt(num10)).tan.X = Math.Sin(array(CInt(num10)).inc) * Math.Sin(array(CInt(num10)).azi)
						array(CInt(num10)).tan.Y = Math.Sin(array(CInt(num10)).inc) * Math.Cos(array(CInt(num10)).azi)
						array(CInt(num10)).tan.z = Math.Cos(array(CInt(num10)).inc)
					Next
				Catch ex4 As Exception
				End Try
				Try
					Dim num15 As Short = 1S
					Dim num16 As Short = CShort((num2 - 1))
					For num10 As Short = num15 To num16
						' The following expression was wrapped in a checked-expression
						Dim num17 As Double = Me.dot_prod(array(CInt(num10)).tan, array(CInt((num10 + 1S))).tan)
						If num17 > 1.0 AndAlso num17 <= CDbl((1F + num3)) Then
							num17 = 1.0
						End If
						If num17 < 0.0 AndAlso num17 >= CDbl((-CDbl(num3))) Then
							num17 = 0.0
						End If
						array(CInt(num10)).dog = kinemat.ArcCosine(CSng(num17))
						If array(CInt(num10)).dog > CDbl(num3) Then
							' The following expression was wrapped in a checked-expression
							array(CInt(num10)).rad = (array(CInt((num10 + 1S))).m_d - array(CInt(num10)).m_d) / array(CInt(num10)).dog
						Else
							array(CInt(num10)).rad = -9999.0
						End If
					Next
				Catch ex5 As Exception
				End Try
				Try
					Dim num18 As Short
					Dim num19 As Short
					Dim num10 As Short = CShort(num2)
					array(CInt(num10)).dog = -9999.0
					array(CInt(num10)).rad = -9999.0
					num18 = 1S
					num19 = CShort((num2 - 1))
					For num10 As Short = num18 To num19
						If array(CInt(num10)).dog > CDbl(num3) Then
							' The following expression was wrapped in a checked-expression
							Me.calc_nor(array(CInt(num10)).nor, array(CInt(num10)).tan, array(CInt((num10 + 1S))).tan)
						Else
							array(CInt(num10)).nor.X = -9999.0
							array(CInt(num10)).nor.Y = -9999.0
							array(CInt(num10)).nor.z = -9999.0
						End If
					Next
				Catch ex6 As Exception
				End Try
				Try
					Dim num10 As Short = CShort(num2)
					array(CInt(num10)).nor.X = -9999.0
					array(CInt(num10)).nor.Y = -9999.0
					array(CInt(num10)).nor.z = -9999.0
					num10 = 1S
					array(CInt(num10)).pos.X = 0.0
					array(CInt(num10)).pos.Y = 0.0
					array(CInt(num10)).pos.z = 0.0
					Dim num20 As Short = 2S
					Dim num21 As Short = CShort(num2)
					num10 = num20
					While num10 <= num21
						If array(CInt((num10 - 1S))).dog > CDbl(num3) Then
							Me.calc_pos(array(CInt(num10)).pos, array(CInt((num10 - 1S))).pos, array(CInt((num10 - 1S))).tan, array(CInt((num10 - 1S))).nor, array(CInt((num10 - 1S))).dog, array(CInt((num10 - 1S))).rad)
						Else
							Me.calc_str(array(CInt(num10)).pos, array(CInt((num10 - 1S))).pos, array(CInt((num10 - 1S))).tan, array(CInt(num10)).m_d, array(CInt((num10 - 1S))).m_d)
						End If
						num10 = num10 + 1S
					End While
				Catch ex7 As Exception
				End Try
				Try
					Dim j As Integer = 2
					Dim flag As Boolean = True
					While flag

							Try
								If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
									Dim num22 As Double = array(j).pos.z
									array4(j) = Math.Round(num22 * CDbl(RSWIN_DESC.FT__M), 2)
									Me.m_TVDepth(j) = array4(j)
									num22 = array(j).pos.Y
									array6(j) = Math.Round(num22 * CDbl(RSWIN_DESC.FT__M), 2)
									num22 = array(j).pos.X
									array7(j) = Math.Round(num22 * CDbl(RSWIN_DESC.FT__M), 2)
								Else
									array4(j) = Math.Round(array(j).pos.z, 2)
									Me.m_TVDepth(j) = array4(j)
									array6(j) = Math.Round(array(j).pos.Y, 2)
									array7(j) = Math.Round(array(j).pos.X, 2)
								End If
							Catch ex8 As Exception
							End Try

						j += 1
						If j = num2 + 1 Then
							flag = False
						End If
					End While
				Catch ex9 As Exception
				End Try
				Dim num23 As Integer = Information.UBound(Me.m_TVDepth, 1)
				Me.m_bAfterPump1 = False
				Me.m_bAfterPump2 = False
				Me.m_bAfterPump1_report = False
				Me.m_bAfterPump2_report = False
				Dim a As Double() = array4
				Dim num25 As Single
				Dim num24 As Double = CDbl(num25)
				Dim num27 As Single
				Dim num26 As Double = CDbl(num27)
				Dim num28 As Double = 0.0
				Dim num29 As Double = 0.0
				Util.Maxmin(a, num24, num26, num28, num29)
				num27 = CSng(num26)
				num25 = CSng(num24)
				Dim num30 As Integer = Information.LBound(Me.m_MeasDepth, 1)
				Dim num31 As Integer = Information.UBound(Me.m_MeasDepth, 1)
				For j As Integer = num30 To num31

						Me.m_MeasDepth(j) = Me.m_MeasDepth(j) * CDbl(Me.fMult)
						array2(j) *= CDbl(Me.fMult)

				Next
				Dim a2 As Double() = array2
				num29 = CDbl(num25)
				num28 = CDbl(num27)
				num26 = 0.0
				num24 = 0.0
				Util.Maxmin(a2, num29, num28, num26, num24)
				num27 = CSng(num28)
				num25 = CSng(num29)
				Try
					RSWIN_DESC.taper_lens(0) = 0F
					RSWIN_DESC.taper_lens(1) = RSWIN_DESC.rst.Sections(1).length
					Dim num32 As Integer = 2
					Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For j As Integer = num32 To numRods2
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						RSWIN_DESC.taper_lens(j) = RSWIN_DESC.taper_lens(j - 1) + RSWIN_DESC.rst.Sections(j).length
					Next
					If Me.bPlotSurveyPointLevel Then
						Dim tchart As TChart = Me.TChart1
						Dim points3D As Points3D = Me.point3DSeries1
						Dim points3D2 As Points3D = Me.point3DSeries2
						Me.ReplotTeeChart_sp_level(tchart, points3D, points3D2, array7, array4, array6, array2, True, True)
						Me.point3DSeries2 = points3D2
						Me.point3DSeries1 = points3D
						Me.TChart1 = tchart
						tchart = Me.TChart1_Report
						points3D2 = Me.point3DSeries1_report
						points3D = Me.point3DSeries2_report
						Me.ReplotTeeChart_sp_level(tchart, points3D2, points3D, array7, array4, array6, array2, True, False)
						Me.point3DSeries2_report = points3D
						Me.point3DSeries1_report = points3D2
						Me.TChart1_Report = tchart
					Else
						Dim tchart As TChart = Me.TChart1
						Dim points3D2 As Points3D = Me.point3DSeries1
						Dim points3D As Points3D = Me.point3DSeries2
						Me.ReplotTeeChart_re_level(tchart, points3D2, points3D, array7, array4, array6, array2, True, True, False)
						Me.point3DSeries2 = points3D
						Me.point3DSeries1 = points3D2
						Me.TChart1 = tchart
						tchart = Me.TChart1_Report
						points3D2 = Me.point3DSeries1_report
						points3D = Me.point3DSeries2_report
						Me.ReplotTeeChart_re_level(tchart, points3D2, points3D, array7, array4, array6, array2, True, False, False)
						Me.point3DSeries2_report = points3D
						Me.point3DSeries1_report = points3D2
						Me.TChart1_Report = tchart
					End If
				Catch ex10 As Exception
				End Try
			Catch ex11 As Exception
			End Try
		End Sub

		Private Sub calc_nor(ByRef n As Results.cart_coord_type, ByRef t1 As Results.cart_coord_type, ByRef t2 As Results.cart_coord_type)
			Dim cart_coord_type As Results.cart_coord_type
			Me.cross_prod(cart_coord_type, t2, t1)
			Dim cart_coord_type2 As Results.cart_coord_type
			Me.cross_prod(cart_coord_type2, t1, cart_coord_type)
			Dim num As Double = Math.Sqrt(cart_coord_type2.X * cart_coord_type2.X + cart_coord_type2.Y * cart_coord_type2.Y + cart_coord_type2.z * cart_coord_type2.z)
			If num > 0.0 Then
				n.X = cart_coord_type2.X / num
				n.Y = cart_coord_type2.Y / num
				n.z = cart_coord_type2.z / num
				Return
			End If
			n.X = 0.0
			n.Y = 0.0
			n.z = 0.0
		End Sub

		Private Sub cross_prod(ByRef result As Results.cart_coord_type, ByRef V1 As Results.cart_coord_type, ByRef v2 As Results.cart_coord_type)
			result.X = V1.Y * v2.z - V1.z * v2.Y
			result.Y = V1.z * v2.X - V1.X * v2.z
			result.z = V1.X * v2.Y - V1.Y * v2.X
		End Sub

		Private Sub calc_pos_lower(ByRef pos2 As Results.cart_coord_type, ByRef pos1 As Results.cart_coord_type, ByRef tan2 As Results.cart_coord_type, ByRef nor2 As Results.cart_coord_type, ByRef dog2 As Double, ByRef rad2 As Double)
			Dim num As Double = rad2 * Math.Sin(dog2)
			Dim num2 As Double = -rad2 * (1.0 - Math.Cos(dog2))
			pos2.X = pos1.X + num * tan2.X + num2 * nor2.X
			pos2.Y = pos1.Y + num * tan2.Y + num2 * nor2.Y
			pos2.z = pos1.z + num * tan2.z + num2 * nor2.z
		End Sub

		Private Sub calc_str_lower(ByRef pos2 As Results.cart_coord_type, ByRef pos1 As Results.cart_coord_type, ByRef tan2 As Results.cart_coord_type, ByRef m_d2 As Double, ByRef m_d1 As Double)
			Dim num As Double = m_d2 - m_d1
			pos2.X = pos1.X + num * tan2.X
			pos2.Y = pos1.Y + num * tan2.Y
			pos2.z = pos1.z + num * tan2.z
		End Sub

		Private Sub calc_pos(ByRef pos2 As Results.cart_coord_type, ByRef pos1 As Results.cart_coord_type, ByRef tan1 As Results.cart_coord_type, ByRef nor1 As Results.cart_coord_type, dog1 As Double, rad1 As Double)
			Dim num As Double = rad1 * Math.Sin(dog1)
			Dim num2 As Double = rad1 * (1.0 - Math.Cos(dog1))
			pos2.X = pos1.X + num * tan1.X + num2 * nor1.X
			pos2.Y = pos1.Y + num * tan1.Y + num2 * nor1.Y
			pos2.z = pos1.z + num * tan1.z + num2 * nor1.z
		End Sub

		Private Sub calc_str(ByRef pos2 As Results.cart_coord_type, ByRef pos1 As Results.cart_coord_type, ByRef tan1 As Results.cart_coord_type, ByRef m_d2 As Double, ByRef m_d1 As Double)
			Dim num As Double = m_d2 - m_d1
			pos2.X = pos1.X + num * tan1.X
			pos2.Y = pos1.Y + num * tan1.Y
			pos2.z = pos1.z + num * tan1.z
		End Sub

		Private Function dot_prod(ByRef V1 As Results.cart_coord_type, ByRef v2 As Results.cart_coord_type) As Double
			Return V1.X * v2.X + V1.Y * v2.Y + V1.z * v2.z
		End Function

		Public Sub ReplotTeeChart_re_level(ByRef TChart1 As TChart, ByRef point3DSeries1 As Points3D, ByRef point3DSeries2 As Points3D, xval As Double(), yval As Double(), zval As Double(), ByRef fMeasDepth As Double(), Optional bConvert As Boolean = True, Optional bView As Boolean = True, Optional bCalcMaxs As Boolean = False)
			Dim flag As Boolean = False
			Try
				Dim impredObj As TEImpred = MImpred.ImpredObj
				Me.m_rImpred = impredObj
				RSWIN_DESC.bAllZeroNumGuides = RSWIN.AllZeroNumGuides()
				Dim num As Single
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					num = RSWIN_DESC.rst.PumpDepth
					Me.fMult = 1F
				Else
					num = RSWIN_DESC.rst.PumpDepth * RSWIN_DESC.FT__M
					Me.fMult = RSWIN_DESC.FT__M
				End If
				point3DSeries1.Clear()
				point3DSeries2.Clear()
				Try
					Me.commander1.Buttons(8).Enabled = False
					Me.commander1.Buttons(8).Visible = False
					Me.commander1.Buttons(11).Enabled = False
					Me.commander1.Buttons(11).Visible = False
				Catch ex As Exception
				End Try
				Me.m_bReplot = False
				Dim num6 As Single
				Dim num7 As Single
				Dim num8 As Single
				Dim num9 As Single
				Dim bottom2 As Steema.TeeChart.Axis
				Dim axisMinMax_ As Single
				Dim num4 As Single
				Dim num5 As Single
				Try
					Dim num2 As Single = -100000F
					Dim num3 As Single = 100000F
					num4 = -100000F
					num5 = 100000F
					num6 = -100000F
					num7 = 100000F
					num8 = -100000F
					num9 = 100000F
					Dim num10 As Integer = 0
					Dim num11 As Integer = impredObj.num_rod_elements - 1
					For i As Integer = num10 To num11
						Dim rod_element_data_type As TEImpred.rod_element_data_type = impredObj.get_r_e(i + 1)
						Dim num12 As Double = rod_element_data_type.pos.z * CDbl(Me.fMult)
						rod_element_data_type = impredObj.get_r_e(i + 1)
						Dim num13 As Double = rod_element_data_type.pos.y * CDbl(Me.fMult)
						rod_element_data_type = impredObj.get_r_e(i + 1)
						Dim num14 As Double = rod_element_data_type.pos.x * CDbl(Me.fMult)
						rod_element_data_type = impredObj.get_r_e(i + 1)

							Dim num15 As Double = rod_element_data_type.m_d * CDbl(Me.fMult)
							If num15 > CDbl(num2) Then
								num2 = CSng(num15)
							End If
							If num14 > CDbl(num4) Then
								num4 = CSng(num14)
							End If
							If num13 > CDbl(num8) Then
								num8 = CSng(num13)
							End If
							If num12 > CDbl(num6) Then
								num6 = CSng(num12)
							End If
							If num15 < CDbl(num3) Then
								num3 = CSng(num15)
							End If
							If num14 < CDbl(num5) Then
								num5 = CSng(num14)
							End If
							If num12 < CDbl(num7) Then
								num7 = CSng(num12)
							End If
							If num13 < CDbl(num9) Then
								num9 = CSng(num13)
							End If
							If num15 < CDbl((num + 1F)) And Not(num14 = 0.0 And num13 = 0.0 And num12 = 0.0) Then
								point3DSeries1.Add(num14, num12, num13)
							End If

					Next
				Catch ex2 As Exception
				End Try
				TChart1.Series.Add(point3DSeries1)
				If Not bCalcMaxs Then
					Dim num16 As Double = CDbl(num8)
					Dim num17 As Double = CDbl(num9)
					Dim num18 As Double = 0.0
					Dim num19 As Double = 0.0
					Util.Maxmin(zval, num16, num17, num18, num19)
					num9 = CSng(num17)
					num8 = CSng(num16)
					num19 = CDbl(num4)
					num18 = CDbl(num5)
					num17 = 0.0
					num16 = 0.0
					Util.Maxmin(xval, num19, num18, num17, num16)
					num5 = CSng(num18)
					num4 = CSng(num19)
					num19 = CDbl(num6)
					num18 = CDbl(num7)
					num17 = 0.0
					num16 = 0.0
					Util.Maxmin(yval, num19, num18, num17, num16)
					num7 = CSng(num18)
					num6 = CSng(num19)
				End If
				Dim bottom As Steema.TeeChart.Axis = TChart1.Axes.Bottom
				Dim depth As Steema.TeeChart.Axis = TChart1.Axes.Depth
				Dim tchart As TChart = TChart1
				tchart.Header.Font.Name = "Verdana"
				tchart.Header.Font.Bold = True
				tchart.Header.Font.Size = 8
				bottom2 = TChart1.Axes.Bottom
				bottom2.Labels.ValueFormat = "0"
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					bottom2.Increment = 100.0
				Else
					bottom2.Increment = 30.0
				End If
				bottom2.Automatic = False
				axisMinMax_ = Me.GetAxisMinMax_2(CSng(bottom2.Increment), num4, num5)
				bottom2.Minimum = CDbl((axisMinMax_ * -1F))
				bottom2.Maximum = CDbl(axisMinMax_)
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					bottom2.Title.Text = "West  (m)  East"
				Else
					bottom2.Title.Text = "West  (ft)  East"
				End If
				bottom2.Title.Font.Name = "Verdana"
				bottom2.Title.Font.Size = 8
				Dim left As Steema.TeeChart.Axis = TChart1.Axes.Left
				left.Labels.ValueFormat = "0"
				left.Increment = 100.0
				left.Automatic = False
				axisMinMax_ = Me.GetAxisMinMax_2(CSng(left.Increment), num6, num7)
				left.Minimum = 0.0
				left.Maximum = CDbl(axisMinMax_)
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					left.Title.Text = "True Vertical Depth (m)"
				Else
					left.Title.Text = "True Vertical Depth (ft)"
				End If
				left.Title.Font.Name = "Verdana"
				left.Title.Font.Size = 8
				Dim depth2 As Steema.TeeChart.Axis = TChart1.Axes.Depth
				depth2.Labels.ValueFormat = "0"
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					depth2.Increment = 100.0
				Else
					depth2.Increment = 30.0
				End If
				depth2.Automatic = False
				axisMinMax_ = Me.GetAxisMinMax_2(CSng(depth2.Increment), num8, num9)
				depth2.Minimum = CDbl((axisMinMax_ * -1F))
				depth2.Maximum = CDbl(axisMinMax_)
				If axisMinMax_ > 1000F And axisMinMax_ < 2000F Then
					depth2.Increment = 200.0
				ElseIf axisMinMax_ > 2000F Then
					depth2.Increment = 500.0
				End If
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					depth2.Title.Text = "South  (m)  North"
				Else
					depth2.Title.Text = "South  (ft)  North"
				End If
				depth2.Title.Font.Name = "Verdana"
				depth2.Title.Font.Size = 8
				depth2.Inverted = True
				If RSWIN_DESC.bHasGuides And Me.bUseSeries2 Then
					Dim num20 As Integer = 1
					Dim rod_numrods As Integer = RSWIN_DESC.rod_numrods
					For i As Integer = num20 To rod_numrods

							If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
								Try
									Dim rod_element_data_type As TEImpred.rod_element_data_type = impredObj.get_r_e(i)
									Dim num12 As Double = rod_element_data_type.pos.z * CDbl(Me.fMult)
									rod_element_data_type = impredObj.get_r_e(i)
									Dim num13 As Double = rod_element_data_type.pos.y * CDbl(Me.fMult)
									rod_element_data_type = impredObj.get_r_e(i)
									Dim num14 As Double = rod_element_data_type.pos.x * CDbl(Me.fMult)
									Dim num15 As Double = CDbl((Me.GetMDVal(CSng(num12), True) * Me.fMult))
									If num15 < CDbl((num + 1F)) And Not(num14 = 0.0 And num13 = 0.0 And num12 = 0.0) Then
										point3DSeries2.TreatNulls = TreatNullsStyle.DoNotPaint
										point3DSeries2.Add(num14, num12, num13)
										point3DSeries2.TreatNulls = TreatNullsStyle.DoNotPaint
									End If
								Catch ex3 As Exception
								End Try
							End If

					Next
					point3DSeries2.Title = "Rod Guides"
					RSWIN_DESC.bAllZeroNumGuides = RSWIN.AllZeroNumGuides()
					If RSWIN_DESC.bAllZeroNumGuides Then
						point3DSeries2.Pointer.Visible = False
						point3DSeries2.Visible = False
					Else
						Try
							point3DSeries2.Pointer.Visible = True
							point3DSeries2.Visible = True
							point3DSeries2.BeginUpdate()
							TChart1.Series.Add(point3DSeries2)
						Catch ex4 As Exception
						End Try
					End If
				Else
					point3DSeries2.Visible = False
				End If
				If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
					Me.lblNumGuidesPerRod.Visible = True
				Else
					Me.lblNumGuidesPerRod.Visible = False
				End If
				Me.T1.Visible = False
				Me.T2.Visible = False
				Me.T3.Visible = False
				Me.T4.Visible = False
				Me.T5.Visible = False
				Me.T6.Visible = False
				Me.T7.Visible = False
				Me.T8.Visible = False
				Me.T9.Visible = False
				Me.T10.Visible = False
				Me.T11.Visible = False
				Me.T12.Visible = False
				Me.T13.Visible = False
				Me.T14.Visible = False
				Me.T15.Visible = False
				Me.T16.Visible = False
				Me.T17.Visible = False
				Me.T18.Visible = False
				Me.T19.Visible = False
				Me.T20.Visible = False
				Me.G1.Visible = False
				Me.G2.Visible = False
				Me.G3.Visible = False
				Me.G4.Visible = False
				Me.G5.Visible = False
				Me.G6.Visible = False
				Me.G7.Visible = False
				Me.G8.Visible = False
				Me.G9.Visible = False
				Me.G10.Visible = False
				Me.G11.Visible = False
				Me.G12.Visible = False
				Me.G13.Visible = False
				Me.G14.Visible = False
				Me.G15.Visible = False
				Me.G16.Visible = False
				Me.G17.Visible = False
				Me.G18.Visible = False
				Me.G19.Visible = False
				Me.G20.Visible = False
				Dim num21 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For j As Integer = num21 To numRods
					Dim teRodSizeList As teRodSizeList
					Try
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(RSWIN_DESC.rst.Sections(j).Grade, StdInfoConstants.RodGradeConstants)).RodSizeList
					Catch ex5 As Exception
						teRodSizeList = Nothing
					End Try
					Dim text As String
					If teRodSizeList IsNot Nothing Then
						Try
							For Each obj As Object In teRodSizeList
								Dim dictionaryEntry As DictionaryEntry
								Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
								Try
									If teRodSize.Diameter = RSWIN_DESC.rst.Sections(j).Diameter Then
										If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
											text = teRodSize.MetricDisplayName
										Else
											text = teRodSize.DisplayName
										End If
										flag = True
									End If
								Catch ex6 As Exception
								End Try
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If

						If Not flag Then
							If RODUTIL.IsCorodH(RSWIN_DESC.rst.Sections(j).Grade) Then
								text = "N/A"
							ElseIf RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(j).Grade) Then
								If RSWIN_DESC.rst.Sections(j).Diameter > 1F Then
									Dim num22 As Single = RSWIN_DESC.rst.Sections(j).Diameter * 16F
									Dim text2 As String = "0.0"
									text = Util.Format(num22, text2) + "/16"
								Else
									Dim num22 As Single = RSWIN_DESC.rst.Sections(j).Diameter * 16F
									Dim text2 As String = "0"
									text = Util.Format(num22, text2) + "/16"
								End If
								Dim flag2 As Boolean
								If Not flag2 And RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									text += """"
								End If
							ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Dim num22 As Single = RSWIN_DESC.rst.Sections(j).Diameter * RSWIN_DESC.IN__MM
								Dim text2 As String = "0.0"
								text = Util.Format(num22, text2)
							Else
								Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
								Dim num23 As Integer = j
								Dim text2 As String = "0.0###"
								text = Util.Format(sections(num23).Diameter, text2)
							End If
						End If
						text = text.Replace("  ", " ")

					Select Case j
						Case 1
							Me.T1.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T1.ForeColor = Color.Red
							Me.T1.Visible = True
						Case 2
							Me.T2.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T2.ForeColor = Color.Green
							Me.T2.Left = Conversions.ToInteger(Operators.AddObject(Me.T1.Left + Me.T1.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
							Me.T2.Visible = True
						Case 3
							Me.T3.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T3.ForeColor = Color.Blue
							Me.T3.Visible = True
							Me.T3.Left = Conversions.ToInteger(Operators.AddObject(Me.T2.Left + Me.T2.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
						Case 4
							Me.T4.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T4.ForeColor = Color.Magenta
							Me.T4.Visible = True
							Me.T4.Left = Conversions.ToInteger(Operators.AddObject(Me.T3.Left + Me.T3.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
						Case 5
							Me.T5.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T5.ForeColor = Color.MediumTurquoise
							Me.T5.Visible = True
							Me.T5.Left = Conversions.ToInteger(Operators.AddObject(Me.T4.Left + Me.T4.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
						Case 6
							Me.T6.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T6.ForeColor = Color.Orange
							Me.T6.Visible = True
							Me.T6.Left = Conversions.ToInteger(Operators.AddObject(Me.T5.Left + Me.T5.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
						Case 7
							Me.T7.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T7.ForeColor = Color.Purple
							Me.T7.Visible = True
							Me.T7.Left = Conversions.ToInteger(Operators.AddObject(Me.T6.Left + Me.T6.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
						Case 8
							Me.T8.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T8.ForeColor = Color.Tan
							Me.T8.Visible = True
							Me.T8.Left = Conversions.ToInteger(Operators.AddObject(Me.T7.Left + Me.T7.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
						Case 9
							Me.T9.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T9.ForeColor = Color.DarkRed
							Me.T9.Visible = True
							Me.T9.Left = Conversions.ToInteger(Operators.AddObject(Me.T8.Left + Me.T8.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
						Case 10
							Me.T10.Text = text
							Me.T10.ForeColor = Color.Gray
							Me.T10.Visible = True
							Me.T10.Left = Conversions.ToInteger(Operators.AddObject(Me.T9.Left + Me.T9.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
						Case 11
							Me.T11.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T11.ForeColor = Color.Red
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T11.Left = Me.T1.Left
							Else
								Me.T11.Left = Conversions.ToInteger(Operators.AddObject(Me.T10.Left + Me.T10.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
							End If
							Me.T11.Visible = True
						Case 12
							Me.T12.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T12.ForeColor = Color.Green
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T12.Left = Me.T2.Left
							Else
								Me.T12.Left = Conversions.ToInteger(Operators.AddObject(Me.T11.Left + Me.T11.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
							End If
							Me.T12.Visible = True
						Case 13
							Me.T13.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T13.ForeColor = Color.Blue
							Me.T13.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T13.Left = Me.T3.Left
							Else
								Me.T13.Left = Conversions.ToInteger(Operators.AddObject(Me.T12.Left + Me.T12.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
							End If
						Case 14
							Me.T14.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T14.ForeColor = Color.Magenta
							Me.T14.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T14.Left = Me.T4.Left
							Else
								Me.T14.Left = Conversions.ToInteger(Operators.AddObject(Me.T13.Left + Me.T13.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
							End If
						Case 15
							Me.T15.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T15.ForeColor = Color.MediumTurquoise
							Me.T15.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T15.Left = Me.T5.Left
							Else
								Me.T15.Left = Conversions.ToInteger(Operators.AddObject(Me.T14.Left + Me.T14.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
							End If
						Case 16
							Me.T16.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T16.ForeColor = Color.Orange
							Me.T16.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T16.Left = Me.T6.Left
							Else
								Me.T16.Left = Conversions.ToInteger(Operators.AddObject(Me.T15.Left + Me.T15.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
							End If
						Case 17
							Me.T17.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T17.ForeColor = Color.Purple
							Me.T17.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T17.Left = Me.T7.Left
							Else
								Me.T17.Left = Conversions.ToInteger(Operators.AddObject(Me.T16.Left + Me.T16.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
							End If
						Case 18
							Me.T18.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T18.ForeColor = Color.Tan
							Me.T18.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T18.Left = Me.T8.Left
							Else
								Me.T18.Left = Conversions.ToInteger(Operators.AddObject(Me.T17.Left + Me.T17.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
							End If
						Case 19
							Me.T19.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T19.ForeColor = Color.DarkRed
							Me.T19.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T19.Left = Me.T9.Left
							Else
								Me.T19.Left = Conversions.ToInteger(Operators.AddObject(Me.T18.Left + Me.T18.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
							End If
						Case 20
							Me.T20.Text = text
							Me.T20.ForeColor = Color.Gray
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T20.Left = Me.T10.Left
							Else
								Me.T20.Left = Conversions.ToInteger(Operators.AddObject(Me.T19.Left + Me.T19.Width, Interaction.IIf(Me.pnlDevPlot.Width < 1000, 2, 3)))
							End If
							Me.T20.Visible = True
					End Select
					If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
						text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(j).NumGuides))
						Select Case j
							Case 1
								Me.G1.Text = text
								Me.G1.ForeColor = Color.Red
								Me.G1.Visible = True
								Me.G1.Left = Me.T1.Left
							Case 2
								Me.G2.Text = text
								Me.G2.ForeColor = Color.Green
								Me.G2.Visible = True
								Me.G2.Left = Me.T2.Left
							Case 3
								Me.G3.Text = text
								Me.G3.ForeColor = Color.Blue
								Me.G3.Visible = True
								Me.G3.Left = Me.T3.Left
							Case 4
								Me.G4.Text = text
								Me.G4.ForeColor = Color.Magenta
								Me.G4.Visible = True
								Me.G4.Left = Me.T4.Left
							Case 5
								Me.G5.Text = text
								Me.G5.ForeColor = Color.MediumTurquoise
								Me.G5.Visible = True
								Me.G5.Left = Me.T5.Left
							Case 6
								Me.G6.Text = text
								Me.G6.ForeColor = Color.Orange
								Me.G6.Visible = True
								Me.G6.Left = Me.T6.Left
							Case 7
								Me.G7.Text = text
								Me.G7.ForeColor = Color.Purple
								Me.G7.Visible = True
								Me.G7.Left = Me.T7.Left
							Case 8
								Me.G8.Text = text
								Me.G8.ForeColor = Color.Tan
								Me.G8.Visible = True
								Me.G8.Left = Me.T8.Left
							Case 9
								Me.G9.Text = text
								Me.G9.ForeColor = Color.DarkRed
								Me.G9.Visible = True
								Me.G9.Left = Me.T9.Left
							Case 10
								Me.G10.Text = text
								Me.G10.ForeColor = Color.Gray
								Me.G10.Visible = True
								Me.G10.Left = Me.T10.Left
							Case 11
								Me.G11.Text = text
								Me.G11.ForeColor = Color.Red
								Me.G11.Visible = True
								Me.G11.Left = Me.T11.Left
							Case 12
								Me.G12.Text = text
								Me.G12.ForeColor = Color.Green
								Me.G12.Visible = True
								Me.G12.Left = Me.T12.Left
							Case 13
								Me.G13.Text = text
								Me.G13.ForeColor = Color.Blue
								Me.G13.Visible = True
								Me.G13.Left = Me.T13.Left
							Case 14
								Me.G14.Text = text
								Me.G14.ForeColor = Color.Magenta
								Me.G14.Visible = True
								Me.G14.Left = Me.T14.Left
							Case 15
								Me.G15.Text = text
								Me.G15.ForeColor = Color.MediumTurquoise
								Me.G15.Visible = True
								Me.G15.Left = Me.T15.Left
							Case 16
								Me.G16.Text = text
								Me.G16.ForeColor = Color.Orange
								Me.G16.Visible = True
								Me.G16.Left = Me.T16.Left
							Case 17
								Me.G17.Text = text
								Me.G17.ForeColor = Color.Purple
								Me.G17.Visible = True
								Me.G17.Left = Me.T17.Left
							Case 18
								Me.G18.Text = text
								Me.G18.ForeColor = Color.Tan
								Me.G18.Visible = True
								Me.G18.Left = Me.T18.Left
							Case 19
								Me.G19.Text = text
								Me.G19.ForeColor = Color.DarkRed
								Me.G19.Visible = True
								Me.G19.Left = Me.T19.Left
							Case 20
								Me.G20.Text = text
								Me.G20.ForeColor = Color.Gray
								Me.G20.Visible = True
								Me.G20.Left = Me.T20.Left
						End Select
					End If
				Next
				If RSWIN_DESC.rst.NumRods > 10S And RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					Me.pnlLegend.Height = 57
					Me.pnlLegend2.Height = Me.pnlLegend.Height
					Me.lblDiameters2.Visible = True
					Me.lblNumGuidesPerRod2.Visible = True
					Me.G11.Top = Me.lblNumGuidesPerRod2.Top
					Me.G12.Top = Me.lblNumGuidesPerRod2.Top
					Me.G13.Top = Me.lblNumGuidesPerRod2.Top
					Me.G14.Top = Me.lblNumGuidesPerRod2.Top
					Me.G15.Top = Me.lblNumGuidesPerRod2.Top
					Me.G16.Top = Me.lblNumGuidesPerRod2.Top
					Me.G17.Top = Me.lblNumGuidesPerRod2.Top
					Me.G18.Top = Me.lblNumGuidesPerRod2.Top
					Me.G19.Top = Me.lblNumGuidesPerRod2.Top
					Me.G20.Top = Me.lblNumGuidesPerRod2.Top
					Me.T11.Top = Me.lblDiameters2.Top
					Me.T12.Top = Me.lblDiameters2.Top
					Me.T13.Top = Me.lblDiameters2.Top
					Me.T14.Top = Me.lblDiameters2.Top
					Me.T15.Top = Me.lblDiameters2.Top
					Me.T16.Top = Me.lblDiameters2.Top
					Me.T17.Top = Me.lblDiameters2.Top
					Me.T18.Top = Me.lblDiameters2.Top
					Me.T19.Top = Me.lblDiameters2.Top
					Me.T20.Top = Me.lblDiameters2.Top
				Else
					Me.pnlLegend.Height = 35
					Me.pnlLegend2.Height = Me.pnlLegend.Height
					Me.lblDiameters2.Visible = False
					Me.lblNumGuidesPerRod2.Visible = False
					Me.G11.Top = Me.lblNumGuidesPerRod.Top
					Me.G12.Top = Me.lblNumGuidesPerRod.Top
					Me.G13.Top = Me.lblNumGuidesPerRod.Top
					Me.G14.Top = Me.lblNumGuidesPerRod.Top
					Me.G15.Top = Me.lblNumGuidesPerRod.Top
					Me.G16.Top = Me.lblNumGuidesPerRod.Top
					Me.G17.Top = Me.lblNumGuidesPerRod.Top
					Me.G18.Top = Me.lblNumGuidesPerRod.Top
					Me.G19.Top = Me.lblNumGuidesPerRod.Top
					Me.G20.Top = Me.lblNumGuidesPerRod.Top
					Me.T11.Top = Me.lblDiameters.Top
					Me.T12.Top = Me.lblDiameters.Top
					Me.T13.Top = Me.lblDiameters.Top
					Me.T14.Top = Me.lblDiameters.Top
					Me.T15.Top = Me.lblDiameters.Top
					Me.T16.Top = Me.lblDiameters.Top
					Me.T17.Top = Me.lblDiameters.Top
					Me.T18.Top = Me.lblDiameters.Top
					Me.T19.Top = Me.lblDiameters.Top
					Me.T20.Top = Me.lblDiameters.Top
				End If
				If Me.pnlLegend.Width > Me.pnlLegend2.Width Then
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					Me.pnlLegend2.Left = CInt(Math.Round(CDbl(Me.pnlLegend.Left) + CDbl((Me.pnlLegend.Width - Me.pnlLegend2.Width)) / 2.0))
				End If
				TChart1.Aspect.Chart3DPercent = 100
				TChart1.Aspect.Orthogonal = False
				TChart1.Aspect.Perspective = 50
				TChart1.Aspect.Rotation = 340
				If bView Then
					TChart1.Aspect.Elevation = 355
					TChart1.Aspect.Zoom = 70
				Else
					TChart1.Aspect.Elevation = 353
					TChart1.Aspect.Zoom = 75
				End If
				TChart1.Aspect.View3D = True
				TChart1.Aspect.HorizOffset = 0
				TChart1.Aspect.VertOffset = 0
				TChart1.Aspect.ZOffset = 0.0
				TChart1.Legend.Shadow.Visible = False
				Me.iGetPointStyle1 = 0
				Me.iGetPointStyle1_report = 0
				Me.iGetPointStyle2 = 0
				Me.iGetPointStyle2_report = 0
			Catch ex7 As Exception
			End Try
		End Sub

		Public Sub ReplotTeeChart_sp_level(ByRef TChart1 As TChart, ByRef point3DSeries1 As Points3D, ByRef point3DSeries2 As Points3D, xval As Double(), yval As Double(), zval As Double(), fMeasDepth As Double(), Optional bConvert As Boolean = True, Optional bView As Boolean = True)
			Dim flag As Boolean = False
			Try
				Dim impredObj As TEImpred = MImpred.ImpredObj
				Me.m_rImpred = impredObj
				Dim num As Single
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					num = RSWIN_DESC.rst.PumpDepth
				Else
					num = RSWIN_DESC.rst.PumpDepth * RSWIN_DESC.FT__M
				End If
				point3DSeries1.Clear()
				point3DSeries2.Clear()
				Try
					Me.commander1.Buttons(8).Enabled = False
					Me.commander1.Buttons(8).Visible = False
					Me.commander1.Buttons(11).Enabled = False
					Me.commander1.Buttons(11).Visible = False
				Catch ex As Exception
				End Try
				Me.m_bReplot = False
				Dim num2 As Integer = Information.LBound(fMeasDepth, 1)
				Dim num3 As Integer = Information.UBound(fMeasDepth, 1)
				Dim num5 As Single
				Dim num7 As Single
				Dim num12 As Single
				Dim num13 As Single
				Dim bottom2 As Steema.TeeChart.Axis
				Dim axisMinMax_ As Single
				For i As Integer = num2 To num3
					Try
						If(i > 0 And fMeasDepth(i) <> 0.0) Or i = 0 Then
							point3DSeries1.Add(xval(i), yval(i), zval(i))
						End If
					Catch ex2 As Exception
					End Try
				Next
				TChart1.Series.Add(point3DSeries1)
				Dim num4 As Double = CDbl(num5)
				Dim num6 As Double = CDbl(num7)
				Dim num8 As Double = 0.0
				Dim num9 As Double = 0.0
				Util.Maxmin(zval, num4, num6, num8, num9)
				num7 = CSng(num6)
				num5 = CSng(num4)
				Dim num10 As Single
				num9 = CDbl(num10)
				Dim num11 As Single
				num8 = CDbl(num11)
				num6 = 0.0
				num4 = 0.0
				Util.Maxmin(xval, num9, num8, num6, num4)
				num11 = CSng(num8)
				num10 = CSng(num9)
				num9 = CDbl(num12)
				num8 = CDbl(num13)
				num6 = 0.0
				num4 = 0.0
				Util.Maxmin(yval, num9, num8, num6, num4)
				num13 = CSng(num8)
				num12 = CSng(num9)
				Dim bottom As Steema.TeeChart.Axis = TChart1.Axes.Bottom
				Dim depth As Steema.TeeChart.Axis = TChart1.Axes.Depth
				Dim tchart As TChart = TChart1
				tchart.Header.Font.Name = "Verdana"
				tchart.Header.Font.Bold = True
				tchart.Header.Font.Size = 8
				bottom2 = TChart1.Axes.Bottom
				bottom2.Labels.ValueFormat = "0"
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					bottom2.Increment = 100.0
				Else
					bottom2.Increment = 30.0
				End If
				bottom2.Automatic = False
				axisMinMax_ = Me.GetAxisMinMax_2(CSng(bottom2.Increment), num10, num11)
				bottom2.Minimum = CDbl((axisMinMax_ * -1F))
				bottom2.Maximum = CDbl(axisMinMax_)
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					bottom2.Title.Text = "West  (m)  East"
				Else
					bottom2.Title.Text = "West  (ft)  East"
				End If
				bottom2.Title.Font.Name = "Verdana"
				bottom2.Title.Font.Size = 8
				Dim left As Steema.TeeChart.Axis = TChart1.Axes.Left
				left.Labels.ValueFormat = "0"
				left.Increment = 100.0
				left.Automatic = False
				axisMinMax_ = Me.GetAxisMinMax_2(CSng(left.Increment), num12, num13)
				left.Minimum = 0.0
				left.Maximum = CDbl(axisMinMax_)
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					left.Title.Text = "True Vertical Depth (m)"
				Else
					left.Title.Text = "True Vertical Depth (ft)"
				End If
				left.Title.Font.Name = "Verdana"
				left.Title.Font.Size = 8
				Dim depth2 As Steema.TeeChart.Axis = TChart1.Axes.Depth
				depth2.Labels.ValueFormat = "0"
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					depth2.Increment = 100.0
				Else
					depth2.Increment = 30.0
				End If
				depth2.Automatic = False
				axisMinMax_ = Me.GetAxisMinMax_2(CSng(depth2.Increment), num5, num7)
				depth2.Minimum = CDbl((axisMinMax_ * -1F))
				depth2.Maximum = CDbl(axisMinMax_)
				If axisMinMax_ > 1000F And axisMinMax_ < 2000F Then
					depth2.Increment = 200.0
				ElseIf axisMinMax_ > 2000F Then
					depth2.Increment = 500.0
				End If
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					depth2.Title.Text = "South  (m)  North"
				Else
					depth2.Title.Text = "South  (ft)  North"
				End If
				depth2.Title.Font.Name = "Verdana"
				depth2.Title.Font.Size = 8
				depth2.Inverted = True
				If RSWIN_DESC.bHasGuides And Me.bUseSeries2 Then
					Dim num14 As Integer = 1
					Dim rod_numrods As Integer = RSWIN_DESC.rod_numrods
					For i As Integer = num14 To rod_numrods

							If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
								Try
									Dim rod_element_data_type As TEImpred.rod_element_data_type = impredObj.get_r_e(i)
									Dim num15 As Double = rod_element_data_type.pos.z * CDbl(Me.fMult)
									rod_element_data_type = impredObj.get_r_e(i)
									Dim num16 As Double = rod_element_data_type.pos.y * CDbl(Me.fMult)
									rod_element_data_type = impredObj.get_r_e(i)
									Dim num17 As Double = rod_element_data_type.pos.x * CDbl(Me.fMult)
									Dim num18 As Double = CDbl(Me.GetMDVal(CSng(num15), True))
									If num18 < CDbl((num + 1F)) And Not(num17 = 0.0 And num16 = 0.0 And num15 = 0.0) Then
										point3DSeries2.TreatNulls = TreatNullsStyle.DoNotPaint
										point3DSeries2.Add(num17, num15, num16)
										point3DSeries2.TreatNulls = TreatNullsStyle.DoNotPaint
									End If
								Catch ex3 As Exception
								End Try
							End If

					Next
					point3DSeries2.Title = "Rod Guides"
					If RSWIN.AllNoGuides() Then
						point3DSeries2.Pointer.Visible = False
						point3DSeries2.Visible = False
					Else
						Try
							point3DSeries2.Pointer.Visible = True
							point3DSeries2.Visible = True
							point3DSeries2.BeginUpdate()
							TChart1.Series.Add(point3DSeries2)
						Catch ex4 As Exception
						End Try
					End If
				Else
					point3DSeries2.Visible = False
				End If
				If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
					Me.lblNumGuidesPerRod.Visible = True
				Else
					Me.lblNumGuidesPerRod.Visible = False
				End If
				Dim num19 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For j As Integer = num19 To numRods
					Dim teRodSizeList As teRodSizeList
					Try
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(RSWIN_DESC.rst.Sections(j).Grade, StdInfoConstants.RodGradeConstants)).RodSizeList
					Catch ex5 As Exception
						teRodSizeList = Nothing
					End Try
					Dim text As String
					If teRodSizeList IsNot Nothing Then
						Try
							For Each obj As Object In teRodSizeList
								Dim dictionaryEntry As DictionaryEntry
								Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
								Try
									If teRodSize.Diameter = RSWIN_DESC.rst.Sections(j).Diameter Then
										If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
											text = teRodSize.MetricDisplayName
										Else
											text = teRodSize.DisplayName
										End If
										flag = True
									End If
								Catch ex6 As Exception
								End Try
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If

						If Not flag Then
							If RODUTIL.IsCorodH(RSWIN_DESC.rst.Sections(j).Grade) Then
								text = "N/A"
							ElseIf RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(j).Grade) Then
								If RSWIN_DESC.rst.Sections(j).Diameter > 1F Then
									Dim num20 As Single = RSWIN_DESC.rst.Sections(j).Diameter * 16F
									Dim text2 As String = "0.0"
									text = Util.Format(num20, text2) + "/16"
								Else
									Dim num20 As Single = RSWIN_DESC.rst.Sections(j).Diameter * 16F
									Dim text2 As String = "0"
									text = Util.Format(num20, text2) + "/16"
								End If
								Dim flag2 As Boolean
								If Not flag2 And RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									text += """"
								End If
							ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Dim num20 As Single = RSWIN_DESC.rst.Sections(j).Diameter * RSWIN_DESC.IN__MM
								Dim text2 As String = "0.0"
								text = Util.Format(num20, text2)
							Else
								Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
								Dim num21 As Integer = j
								Dim text2 As String = "0.0###"
								text = Util.Format(sections(num21).Diameter, text2)
							End If
						End If
						text = text.Replace("  ", " ")

					Select Case j
						Case 1
							Me.T1.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T1.ForeColor = Color.Red
							Me.T1.Visible = True
						Case 2
							Me.T2.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T2.ForeColor = Color.Green
							Me.T2.Left = Me.T1.Left + Me.T1.Width + 2
							Me.T2.Visible = True
						Case 3
							Me.T3.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T3.ForeColor = Color.Blue
							Me.T3.Visible = True
							Me.T3.Left = Me.T2.Left + Me.T2.Width + 2
						Case 4
							Me.T4.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T4.ForeColor = Color.Magenta
							Me.T4.Visible = True
							Me.T4.Left = Me.T3.Left + Me.T3.Width + 2
						Case 5
							Me.T5.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T5.ForeColor = Color.MediumTurquoise
							Me.T5.Visible = True
							Me.T5.Left = Me.T4.Left + Me.T4.Width + 2
						Case 6
							Me.T6.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T6.ForeColor = Color.Orange
							Me.T6.Visible = True
							Me.T6.Left = Me.T5.Left + Me.T5.Width + 2
						Case 7
							Me.T7.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T7.ForeColor = Color.Purple
							Me.T7.Visible = True
							Me.T7.Left = Me.T6.Left + Me.T6.Width + 2
						Case 8
							Me.T8.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T8.ForeColor = Color.Tan
							Me.T8.Visible = True
							Me.T8.Left = Me.T7.Left + Me.T7.Width + 2
						Case 9
							Me.T9.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T9.ForeColor = Color.DarkRed
							Me.T9.Visible = True
							Me.T9.Left = Me.T8.Left + Me.T8.Width + 2
						Case 10
							Me.T10.Text = text
							Me.T10.ForeColor = Color.Gray
							Me.T10.Visible = True
							Me.T10.Left = Me.T9.Left + Me.T9.Width + 2
					End Select
					If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
						Me.pnlLegend.Height = 38
						text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(j).NumGuides))
						Select Case j
							Case 1
								Me.G1.Text = text
								Me.G1.ForeColor = Color.Red
								Me.G1.Visible = True
							Case 2
								Me.G2.Text = text
								Me.G2.ForeColor = Color.Green
								Me.G2.Visible = True
							Case 3
								Me.G3.Text = text
								Me.G3.ForeColor = Color.Blue
								Me.G3.Visible = True
							Case 4
								Me.G4.Text = text
								Me.G4.ForeColor = Color.Magenta
								Me.G4.Visible = True
							Case 5
								Me.G5.Text = text
								Me.G5.ForeColor = Color.MediumTurquoise
								Me.G5.Visible = True
							Case 6
								Me.G6.Text = text
								Me.G6.ForeColor = Color.Orange
								Me.G6.Visible = True
							Case 7
								Me.G7.Text = text
								Me.G7.ForeColor = Color.Purple
								Me.G7.Visible = True
							Case 8
								Me.G8.Text = text
								Me.G8.ForeColor = Color.Tan
								Me.G8.Visible = True
							Case 9
								Me.G9.Text = text
								Me.G9.ForeColor = Color.DarkRed
								Me.G9.Visible = True
							Case 10
								Me.G10.Text = text
								Me.G10.ForeColor = Color.Gray
								Me.G10.Visible = True
						End Select
					Else
						Me.pnlLegend.Height = 20
					End If
				Next
				TChart1.Aspect.Chart3DPercent = 100
				TChart1.Aspect.Orthogonal = False
				TChart1.Aspect.Perspective = 50
				TChart1.Aspect.Rotation = 340
				If bView Then
					TChart1.Aspect.Elevation = 355
					TChart1.Aspect.Zoom = 70
				Else
					TChart1.Aspect.Elevation = 353
					TChart1.Aspect.Zoom = 75
				End If
				TChart1.Aspect.View3D = True
				TChart1.Aspect.HorizOffset = 0
				TChart1.Aspect.VertOffset = 0
				TChart1.Aspect.ZOffset = 0.0
				TChart1.Legend.Shadow.Visible = False
				Me.iGetPointStyle1 = 0
				Me.iGetPointStyle1_report = 0
				Me.iGetPointStyle2 = 0
				Me.iGetPointStyle2_report = 0
			Catch ex7 As Exception
			End Try
		End Sub

		Private Function GetAxisMinMax_2(fInc As Single, Max As Single, Min As Single) As Single
			Dim num As Single
			If Math.Abs(Max) > Math.Abs(Min) Then
				num = Math.Abs(Max)
			Else
				num = Math.Abs(Min)
			End If
			Dim num2 As Integer = 1
			Dim num3 As Single
			While Not(num >= CSng(num2) * fInc And num < CSng((num2 + 1)) * fInc)
				' The following expression was wrapped in a checked-statement
				num2 += 1
				If num2 > 500 Then
					IL_4B:
					If num3 = 0F Then
						num3 = fInc
					End If
					Return num3
				End If
			End While
			num3 = CSng((num2 + 1)) * fInc
			GoTo IL_4B
		End Function

		Private Function GetMDVal(TVDVal As Single, Optional bUseDefault As Boolean = False) As Single
			' The following expression was wrapped in a checked-statement
			Dim num4 As Single
			Try
				Dim num As Integer = Information.UBound(Me.m_TVDepth, 1)
				Dim num2 As Integer = 0
				Dim num3 As Integer = num - 1
				For i As Integer = num2 To num3
					' The following expression was wrapped in a unchecked-expression
					If(CDbl(TVDVal) >= Me.m_TVDepth(i) And CDbl(TVDVal) <= Me.m_TVDepth(i + 1)) Or Math.Abs(CDbl(TVDVal) - Me.m_TVDepth(i)) <= 1.0 Then
						num4 = CSng(Me.m_MeasDepth(i))
						Exit For
					End If
				Next
				If num4 = 0F AndAlso bUseDefault Then
					num4 = TVDVal
				End If
			Catch ex As Exception
			End Try
			Return num4
		End Function

		Private Function GetMDVal_re(iPoint As Integer, TVDVal As Single, ByRef iIndex As Integer) As Single
			Dim result As Single
			Try
				Dim num As Integer = 0
				Dim rod_numrods As Integer = RSWIN_DESC.rod_numrods
				For i As Integer = num To rod_numrods
					If(Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides) Or iPoint = 1 Then
						Dim rod_element_data_type As TEImpred.rod_element_data_type = Me.m_rImpred.get_r_e(i)
						Dim num2 As Single = CSng((rod_element_data_type.pos.z * CDbl(Me.fMult)))
						If CDbl(Math.Abs(TVDVal - num2)) <= 0.1 Then
							rod_element_data_type = Me.m_rImpred.get_r_e(i)
							result = CSng(rod_element_data_type.m_d)
							iIndex = i
							Exit For
						End If
					End If
				Next
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub point3DSeries1_GetPointerStyle(series As Points3D, e As GetPointerStyleEventArgs)
			Dim num As Single = RSWIN_DESC.rst.PumpDepth
			Try
				Dim num3 As Double
				Me.iGetPointStyle1 += 1
				Dim num2 As Double = Me.point3DSeries1.YValues(e.ValueIndex)
				If Me.bPlotSurveyPointLevel Then
					num3 = CDbl(Me.GetMDVal(CSng(num2), False))
				Else
					num3 = Me.m_rImpred.get_r_e(Me.iGetPointStyle1).m_d
					If Me.bCommanderClicked Then
						num3 = CDbl(Me.GetMDVal_re(1, CSng(num2), Me.iGetPointStyle1))
					End If
				End If
				If num3 = 0.0 Then
					Me.m_bAfterPump1 = False
				End If
				If Me.bPlotSurveyPointLevel And RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					num = RSWIN_DESC.rst.PumpDepth * RSWIN_DESC.FT__M
				End If
				If num3 < CDbl((num + 1F)) And Not Me.m_bAfterPump1 Then
					Me.m_bAfterPump1 = False
				ElseIf Not Me.m_bAfterPump1 Then
					Me.m_bAfterPump1 = True
				End If
				If Me.m_bAfterPump1 Then
					Me.point3DSeries1.LinePen.Color = Color.Black
					Debug.WriteLine("BLACK")
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(1)) Or RSWIN_DESC.rst.NumRods = 1S Then
					Me.point3DSeries1.LinePen.Color = Color.Red
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(2)) Or RSWIN_DESC.rst.NumRods = 2S Then
					Me.point3DSeries1.LinePen.Color = Color.Green
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(3)) Or RSWIN_DESC.rst.NumRods = 3S Then
					Me.point3DSeries1.LinePen.Color = Color.Blue
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(4)) Or RSWIN_DESC.rst.NumRods = 4S Then
					Me.point3DSeries1.LinePen.Color = Color.Magenta
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(5)) Or RSWIN_DESC.rst.NumRods = 5S Then
					Me.point3DSeries1.LinePen.Color = Color.MediumTurquoise
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(6)) Or RSWIN_DESC.rst.NumRods = 6S Then
					Me.point3DSeries1.LinePen.Color = Color.Orange
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(7)) Or RSWIN_DESC.rst.NumRods = 7S Then
					Me.point3DSeries1.LinePen.Color = Color.Purple
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(8)) Or RSWIN_DESC.rst.NumRods = 8S Then
					Me.point3DSeries1.LinePen.Color = Color.Tan
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(9)) Or RSWIN_DESC.rst.NumRods = 9S Then
					Me.point3DSeries1.LinePen.Color = Color.DarkRed
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(10)) Or RSWIN_DESC.rst.NumRods = 10S Then
					Me.point3DSeries1.LinePen.Color = Color.Gray
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(11)) Or RSWIN_DESC.rst.NumRods = 11S Then
					Me.point3DSeries1.LinePen.Color = Color.Red
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(12)) Or RSWIN_DESC.rst.NumRods = 12S Then
					Me.point3DSeries1.LinePen.Color = Color.Green
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(13)) Or RSWIN_DESC.rst.NumRods = 13S Then
					Me.point3DSeries1.LinePen.Color = Color.Blue
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(14)) Or RSWIN_DESC.rst.NumRods = 14S Then
					Me.point3DSeries1.LinePen.Color = Color.Magenta
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(15)) Or RSWIN_DESC.rst.NumRods = 15S Then
					Me.point3DSeries1.LinePen.Color = Color.MediumTurquoise
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(16)) Or RSWIN_DESC.rst.NumRods = 16S Then
					Me.point3DSeries1.LinePen.Color = Color.Orange
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(17)) Or RSWIN_DESC.rst.NumRods = 17S Then
					Me.point3DSeries1.LinePen.Color = Color.Purple
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(18)) Or RSWIN_DESC.rst.NumRods = 18S Then
					Me.point3DSeries1.LinePen.Color = Color.Tan
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(19)) Or RSWIN_DESC.rst.NumRods = 19S Then
					Me.point3DSeries1.LinePen.Color = Color.DarkRed
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(20)) Or RSWIN_DESC.rst.NumRods = 20S Then
					Me.point3DSeries1.LinePen.Color = Color.Gray
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub point3DSeries1_report_GetPointerStyle(series As Points3D, e As GetPointerStyleEventArgs)
			Dim num As Single = RSWIN_DESC.rst.PumpDepth
			Try
				Dim num3 As Double
				Me.iGetPointStyle1_report += 1
				Dim num2 As Double = Me.point3DSeries1_report.YValues(e.ValueIndex)
				If Me.bPlotSurveyPointLevel Then
					num3 = CDbl(Me.GetMDVal(CSng(num2), False))
				Else
					num3 = Me.m_rImpred.get_r_e(Me.iGetPointStyle1_report).m_d
				End If
				If num3 = 0.0 Then
					Me.m_bAfterPump1_report = False
				End If
				If Me.bPlotSurveyPointLevel And RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					num = RSWIN_DESC.rst.PumpDepth * RSWIN_DESC.FT__M
				End If
				If num3 < CDbl((num + 1F)) And Not Me.m_bAfterPump1_report Then
					Me.m_bAfterPump1_report = False
				ElseIf Not Me.m_bAfterPump1_report Then
					Me.m_bAfterPump1_report = True
				End If
				If Me.m_bAfterPump1_report Then
					Me.point3DSeries1_report.LinePen.Color = Color.Black
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(1)) Or RSWIN_DESC.rst.NumRods = 1S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Red
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(2)) Or RSWIN_DESC.rst.NumRods = 2S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Green
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(3)) Or RSWIN_DESC.rst.NumRods = 3S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Blue
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(4)) Or RSWIN_DESC.rst.NumRods = 4S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Magenta
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(5)) Or RSWIN_DESC.rst.NumRods = 5S Then
					Me.point3DSeries1_report.LinePen.Color = Color.MediumTurquoise
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(6)) Or RSWIN_DESC.rst.NumRods = 6S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Orange
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(7)) Or RSWIN_DESC.rst.NumRods = 7S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Purple
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(8)) Or RSWIN_DESC.rst.NumRods = 8S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Tan
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(9)) Or RSWIN_DESC.rst.NumRods = 9S Then
					Me.point3DSeries1_report.LinePen.Color = Color.DarkRed
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(10)) Or RSWIN_DESC.rst.NumRods = 10S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Gray
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(11)) Or RSWIN_DESC.rst.NumRods = 11S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Red
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(12)) Or RSWIN_DESC.rst.NumRods = 12S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Green
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(13)) Or RSWIN_DESC.rst.NumRods = 13S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Blue
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(14)) Or RSWIN_DESC.rst.NumRods = 14S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Magenta
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(15)) Or RSWIN_DESC.rst.NumRods = 15S Then
					Me.point3DSeries1_report.LinePen.Color = Color.MediumTurquoise
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(16)) Or RSWIN_DESC.rst.NumRods = 16S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Orange
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(17)) Or RSWIN_DESC.rst.NumRods = 17S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Purple
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(18)) Or RSWIN_DESC.rst.NumRods = 18S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Tan
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(19)) Or RSWIN_DESC.rst.NumRods = 19S Then
					Me.point3DSeries1_report.LinePen.Color = Color.DarkRed
				ElseIf num3 <= CDbl(RSWIN_DESC.taper_lens(20)) Or RSWIN_DESC.rst.NumRods = 20S Then
					Me.point3DSeries1_report.LinePen.Color = Color.Gray
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub BuildDeviationProfileXML_from_DS(ByRef dsDeviationProfile As DataSet, ByRef iNumOfLines As Integer)
			Dim dataView As DataView = New DataView(dsDeviationProfile.Tables(0))
			RSWIN_DESC.sDeviationProfileXML = ""
			RSWIN_DESC.sDeviationProfileXML += "<Data><Entries>"
			Try
				iNumOfLines = 0
				Try
					For Each obj As Object In dataView
						Dim dataRowView As DataRowView = CType(obj, DataRowView)
						Dim row As DataRow = dataRowView.Row
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(row(1))) And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(row(2))) And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(row(3))) Then
							RSWIN_DESC.sDeviationProfileXML += "<Row>"
							RSWIN_DESC.sDeviationProfileXML += "<Depth>"
							Dim num As Single = Conversions.ToSingle(row(1))
							If num = 0F Then
								RSWIN_DESC.sDeviationProfileXML += "0"
							Else
								Dim sDeviationProfileXML As String = RSWIN_DESC.sDeviationProfileXML
								Dim text As String = "#####.###"
								RSWIN_DESC.sDeviationProfileXML = sDeviationProfileXML + Util.Format(num, text)
							End If
							RSWIN_DESC.sDeviationProfileXML += "</Depth>"
							RSWIN_DESC.sDeviationProfileXML += "<Inclination>"
							Dim str As String = Conversions.ToString(row(2))
							RSWIN_DESC.sDeviationProfileXML += str
							RSWIN_DESC.sDeviationProfileXML += "</Inclination>"
							RSWIN_DESC.sDeviationProfileXML += "<Azimuth>"
							str = Conversions.ToString(row(3))
							RSWIN_DESC.sDeviationProfileXML += str
							RSWIN_DESC.sDeviationProfileXML += "</Azimuth>"
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(row(4))) Then
								RSWIN_DESC.sDeviationProfileXML += "<Dogleg>"
								num = Conversions.ToSingle(row(4))
								If num = 0F Then
									RSWIN_DESC.sDeviationProfileXML += "0"
								Else
									Dim sDeviationProfileXML2 As String = RSWIN_DESC.sDeviationProfileXML
									Dim text As String = "#####.###"
									RSWIN_DESC.sDeviationProfileXML = sDeviationProfileXML2 + Util.Format(num, text)
								End If
								RSWIN_DESC.sDeviationProfileXML += "</Dogleg>"
								RSWIN_DESC.sDeviationProfileXML += "<TVDepth>"
								num = Conversions.ToSingle(row(5))
								If num = 0F Then
									RSWIN_DESC.sDeviationProfileXML += "0"
								Else
									Dim sDeviationProfileXML3 As String = RSWIN_DESC.sDeviationProfileXML
									Dim text As String = "#####.###"
									RSWIN_DESC.sDeviationProfileXML = sDeviationProfileXML3 + Util.Format(num, text)
								End If
								RSWIN_DESC.sDeviationProfileXML += "</TVDepth>"
								RSWIN_DESC.sDeviationProfileXML += "<NorthSouth>"
								num = Conversions.ToSingle(row(6))
								If num = 0F Then
									RSWIN_DESC.sDeviationProfileXML += "0"
								Else
									Dim sDeviationProfileXML4 As String = RSWIN_DESC.sDeviationProfileXML
									Dim text As String = "#####.###"
									RSWIN_DESC.sDeviationProfileXML = sDeviationProfileXML4 + Util.Format(num, text)
								End If
								RSWIN_DESC.sDeviationProfileXML += "</NorthSouth>"
								RSWIN_DESC.sDeviationProfileXML += "<EastWest>"
								num = Conversions.ToSingle(row(7))
								If num = 0F Then
									RSWIN_DESC.sDeviationProfileXML += "0"
								Else
									Dim sDeviationProfileXML5 As String = RSWIN_DESC.sDeviationProfileXML
									Dim text As String = "#####.###"
									RSWIN_DESC.sDeviationProfileXML = sDeviationProfileXML5 + Util.Format(num, text)
								End If
								RSWIN_DESC.sDeviationProfileXML += "</EastWest>"
								iNumOfLines += 1
							ElseIf iNumOfLines = 0 Then
								RSWIN_DESC.sDeviationProfileXML += "<Dogleg>0</Dogleg>"
								RSWIN_DESC.sDeviationProfileXML += "<TVDepth>0</TVDepth>"
								RSWIN_DESC.sDeviationProfileXML += "<NorthSouth>0</NorthSouth>"
								RSWIN_DESC.sDeviationProfileXML += "<EastWest>0</EastWest>"
								iNumOfLines += 1
							Else
								RSWIN_DESC.sDeviationProfileXML += "<Dogleg></Dogleg>"
								RSWIN_DESC.sDeviationProfileXML += "<TVDepth></TVDepth>"
								RSWIN_DESC.sDeviationProfileXML += "<NorthSouth></NorthSouth>"
								RSWIN_DESC.sDeviationProfileXML += "<EastWest></EastWest>"
								iNumOfLines += 1
							End If
							RSWIN_DESC.sDeviationProfileXML += "</Row>"
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				RSWIN_DESC.sDeviationProfileXML += "</Entries></Data>"
				If CDbl(iNumOfLines) / 35.0 > Conversion.Int(CDbl(iNumOfLines) / 35.0) Then
					' The following expression was wrapped in a unchecked-expression
					RSWIN_DESC.rst.NumDevSurveyPages = CInt(Math.Round(Conversion.Int(CDbl(iNumOfLines) / 35.0) + 1.0))
				Else
					RSWIN_DESC.rst.NumDevSurveyPages = CInt(Math.Round(Conversion.Int(CDbl(iNumOfLines) / 35.0)))
				End If
				If RSWIN_DESC.rst.NumDevSurveyPages = 0 Then
					RSWIN_DESC.rst.NumDevSurveyPages = 1
				End If
			Catch ex As Exception
				RSWIN_DESC.sDeviationProfileXML = ""
			End Try
		End Sub

		Private Sub CheckPageSettings()
			Try
				RSWIN_DESC.rst.gbCoverPage = (RSWIN_DESC.SETUP_CoverPage <> 0S)
				RSWIN_DESC.rst.gbReportData = (RSWIN_DESC.SETUP_PrintData <> 0S)
				RSWIN_DESC.rst.gbReportCostAnalysis = RSWIN_DESC.SETUP_PrintCostAnalysis
				RSWIN_DESC.rst.gbReportDynoActual = (RSWIN_DESC.SETUP_PrintDynoActual <> 0S)
				RSWIN_DESC.rst.gbReportDynoPred = (RSWIN_DESC.SETUP_PrintDynoPred <> 0S)
				RSWIN_DESC.rst.gbReportIPR = (RSWIN_DESC.SETUP_PrintIPR <> 0S)
				RSWIN_DESC.rst.gbReportTorque = (RSWIN_DESC.SETUP_PrintTorque <> 0S)
				RSWIN_DESC.rst.gbReportSinglePageDynoTorque = (RSWIN_DESC.SETUP_PrintSinglePageDynoTorque <> 0S)
				RSWIN_DESC.rst.gbReportDevChart = (RSWIN_DESC.SETUP_PrintDevChart <> 0S)
				RSWIN_DESC.rst.gbReportGuide = (RSWIN_DESC.SETUP_PrintGuide <> 0S)
				RSWIN_DESC.rst.gbReportDevSurvey = (RSWIN_DESC.SETUP_ReportDevSurvey <> 0S)
				RSWIN_DESC.rst.gbSummaryPage = (RSWIN_DESC.SETUP_SummaryPage <> 0S)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub DebugSurfPumpLoads()
			Try
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnCoverPageComments_Click(sender As Object, e As EventArgs)
			Dim dlgCoverPageComments As dlgCoverPageComments = New dlgCoverPageComments()
			Try
				Try
					Me.ResetClock()
				Catch ex As Exception
				End Try
				dlgCoverPageComments.ShowDialog()
				Application.DoEvents()
				If RSWIN_DESC.bRodStarD Then
					Dim left As Integer = Me._optReport_2.Left
					Me._optReport_2.Left = Me.btnDevCharts.Left
					Me.btnDevCharts.Left = left
					Me.btnDevCharts.Visible = True
					Me.btnDevCharts.Enabled = True
				End If
				Me.btnCoverPageComments.Left = Me._optReport_2.Left + Me._optReport_2.Width + 1
				Me.bFormLoaded = False
				Me.Viewer1.Document = Nothing
				Me.ResultsLoad(True)
				Me.bFormLoaded = True
				Application.DoEvents()
			Catch ex2 As Exception
			End Try
		End Sub

		Public Function getmaxdog(fMaxDog As Object) As Single
			' The following expression was wrapped in a checked-statement
			Dim result2 As Single
			Try
				Dim num As Integer = 1
				Dim result As Single
				While Not Operators.ConditionalCompareObjectLess(Operators.MultiplyObject(fMaxDog, 1.5), num, False)
					num += 1
					If num > 500 Then
						IL_35:
						Return result
					End If
				End While
				result = CSng(num)
				GoTo IL_35
			Catch ex As Exception
				result2 = Conversions.ToSingle(Operators.MultiplyObject(fMaxDog, 1.5))
			End Try
			Return result2
		End Function

		Private Sub btnResetPlot_Click(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				Me.TChart1.Visible = False
				Me.bCommanderClicked = False
				Me.iGetPointStyle1 = 0
				Me.iGetPointStyle1_report = 0
				Me.iGetPointStyle2 = 0
				Me.iGetPointStyle2_report = 0
				Me.m_bAfterPump1 = False
				Me.m_bAfterPump2 = False
				Me.m_bAfterPump1_report = False
				Me.m_bAfterPump2_report = False
				If Not Me.bDogLegsCalculated Then
					Me.ShowDeviation_Dogleg(RSWIN_DESC.mdsDeviationProfile, True, False)
					Dim bPlotData As Boolean = True
					Dim num2 As Integer
					Dim num As Short = CShort(num2)
					Me.ShowDeviation_TVD(RSWIN_DESC.mdsDeviationProfile, bPlotData, num)
					num2 = CInt(num)
					Me.bDogLegsCalculated = True
				ElseIf Not Me.bPlotSurveyPointLevel Then
					Dim xval As Double() = New Double(0) {}
					Dim yval As Double() = New Double(0) {}
					Dim zval As Double() = New Double(0) {}
					Dim array As Double() = New Double(0) {}
					Dim tchart As TChart = Me.TChart1
					Dim points3D As Points3D = Me.point3DSeries1
					Dim points3D2 As Points3D = Me.point3DSeries2
					Me.ReplotTeeChart_re_level(tchart, points3D, points3D2, xval, yval, zval, array, True, True, True)
					Me.point3DSeries2 = points3D2
					Me.point3DSeries1 = points3D
					Me.TChart1 = tchart
					tchart = Me.TChart1_Report
					points3D2 = Me.point3DSeries1_report
					points3D = Me.point3DSeries2_report
					Me.ReplotTeeChart_re_level(tchart, points3D2, points3D, xval, yval, zval, array, True, False, True)
					Me.point3DSeries2_report = points3D
					Me.point3DSeries1_report = points3D2
					Me.TChart1_Report = tchart
					Dim num3 As Integer = 0
					Dim num4 As Integer = Me.commander1.Buttons.Length - 1
					For i As Integer = num3 To num4
						Try
							Me.commander1.Buttons(i).Pushed = False
						Catch ex2 As Exception
						End Try
					Next
				End If
				Me.TChart1.Visible = True
				Application.DoEvents()
			Catch ex3 As Exception
			End Try
		End Sub

		Public Function AllScoresOkay(iGBScore As Integer, iRLScore As Integer, iSLScore As Integer, iSEffScore As Integer, iBotMinStressScore As Integer, iMPRLScore As Integer) As Boolean
			Dim result As Boolean
			Try
				result = ((If((-If(((iGBScore <> 0 And iRLScore <> 0 And iSLScore <> 0 And iSEffScore <> 0 And iBotMinStressScore <> 0) > False), 1, 0)), 1, 0) And Not iMPRLScore) <> 0)
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub point3DSeries2_GetPointerStyle(series As Points3D, e As GetPointerStyleEventArgs)
			Dim pumpDepth As Single = RSWIN_DESC.rst.PumpDepth
			Try
				Me.point3DSeries1_report.LinePen.Color = Color.Transparent
				Me.iGetPointStyle2 += 1
				If Me.iGetPointStyle2 > RSWIN_DESC.num_rod_elements Then
					Me.iGetPointStyle2 = 0
					Me.m_bAfterPump2 = False
				End If
				If Me.iGetPointStyle2 <= 1 Or e.ValueIndex = -1 Then
					Me.m_bAfterPump2 = False
				End If
				If e.ValueIndex <> -1 Then
					If RSWIN_DESC.bHasGuides And Me.bUseSeries2 Then
						Dim num As Double = Me.point3DSeries2.YValues(e.ValueIndex)
						Dim num2 As Double = CDbl(Me.GetMDVal(CSng(num), True))
						If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
							num2 *= CDbl((1F / RSWIN_DESC.FT__M))
						End If
						If Me.bCommanderClicked Then
							num2 = CDbl(Me.GetMDVal_re(2, CSng(num), Me.iGetPointStyle2))
						End If
						Dim num3 As Integer = Me.iGetPointStyle2
						If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
							Dim num4 As Integer
							If Me.m_bAfterPump2 Then
								num4 = 0
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(1)) Or RSWIN_DESC.rst.NumRods = 1S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(1).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(2)) Or RSWIN_DESC.rst.NumRods = 2S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(2).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(3)) Or RSWIN_DESC.rst.NumRods = 3S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(3).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(4)) Or RSWIN_DESC.rst.NumRods = 4S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(4).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(5)) Or RSWIN_DESC.rst.NumRods = 5S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(5).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(6)) Or RSWIN_DESC.rst.NumRods = 6S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(6).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(7)) Or RSWIN_DESC.rst.NumRods = 7S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(7).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(8)) Or RSWIN_DESC.rst.NumRods = 8S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(8).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(9)) Or RSWIN_DESC.rst.NumRods = 9S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(9).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(10)) Or RSWIN_DESC.rst.NumRods = 10S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(10).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(11)) Or RSWIN_DESC.rst.NumRods = 11S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(11).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(12)) Or RSWIN_DESC.rst.NumRods = 12S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(12).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(13)) Or RSWIN_DESC.rst.NumRods = 13S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(13).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(14)) Or RSWIN_DESC.rst.NumRods = 14S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(14).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(15)) Or RSWIN_DESC.rst.NumRods = 15S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(15).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(16)) Or RSWIN_DESC.rst.NumRods = 16S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(16).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(17)) Or RSWIN_DESC.rst.NumRods = 17S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(17).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(18)) Or RSWIN_DESC.rst.NumRods = 18S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(18).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(19)) Or RSWIN_DESC.rst.NumRods = 19S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(19).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(20)) Or RSWIN_DESC.rst.NumRods = 20S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(20).NumGuides)
							End If
							e.Style = PointerStyles.Circle
							If num4 = 0 Or Me.iGetPointStyle2 Mod 2 = 0 Then
								e.Style = PointerStyles.[Nothing]
								e.Color = Color.Transparent
							ElseIf num4 <= 2 Then
								e.Color = Color.LightBlue
							ElseIf num4 <= 4 Then
								e.Color = Color.MediumBlue
							ElseIf num4 <= 6 Then
								e.Color = Color.Blue
							ElseIf num4 <= 99 Then
								e.Color = Color.DarkBlue
							Else
								e.Style = PointerStyles.[Nothing]
								e.Color = Color.Transparent
							End If
						End If
					End If
					If Me.iGetPointStyle2 = Me.point3DSeries2.Count Then
						Me.iGetPointStyle2 = 0
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub point3DSeries2_report_GetPointerStyle(series As Points3D, e As GetPointerStyleEventArgs)
			Dim pumpDepth As Single = RSWIN_DESC.rst.PumpDepth
			Try
				Me.point3DSeries1_report.LinePen.Color = Color.Transparent
				Me.iGetPointStyle2_report += 1
				If Me.iGetPointStyle2_report <= 1 Or e.ValueIndex = -1 Then
					Me.m_bAfterPump2_report = False
				End If
				If e.ValueIndex <> -1 Then
					If RSWIN_DESC.bHasGuides And Me.bUseSeries2 Then
						Dim num As Double = Me.point3DSeries2_report.YValues(e.ValueIndex)
						Dim num2 As Double = CDbl(Me.GetMDVal(CSng(num), True))
						If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
							num2 *= CDbl((1F / RSWIN_DESC.FT__M))
						End If
						Dim num3 As Integer = Me.iGetPointStyle2_report
						If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
							Dim num4 As Integer
							If Me.m_bAfterPump2_report Then
								num4 = 0
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(1)) Or RSWIN_DESC.rst.NumRods = 1S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(1).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(2)) Or RSWIN_DESC.rst.NumRods = 2S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(2).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(3)) Or RSWIN_DESC.rst.NumRods = 3S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(3).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(4)) Or RSWIN_DESC.rst.NumRods = 4S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(4).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(5)) Or RSWIN_DESC.rst.NumRods = 5S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(5).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(6)) Or RSWIN_DESC.rst.NumRods = 6S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(6).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(7)) Or RSWIN_DESC.rst.NumRods = 7S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(7).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(8)) Or RSWIN_DESC.rst.NumRods = 8S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(8).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(9)) Or RSWIN_DESC.rst.NumRods = 9S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(9).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(10)) Or RSWIN_DESC.rst.NumRods = 10S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(10).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(11)) Or RSWIN_DESC.rst.NumRods = 11S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(11).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(12)) Or RSWIN_DESC.rst.NumRods = 12S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(12).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(13)) Or RSWIN_DESC.rst.NumRods = 13S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(13).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(14)) Or RSWIN_DESC.rst.NumRods = 14S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(14).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(15)) Or RSWIN_DESC.rst.NumRods = 15S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(15).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(16)) Or RSWIN_DESC.rst.NumRods = 16S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(16).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(17)) Or RSWIN_DESC.rst.NumRods = 17S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(17).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(18)) Or RSWIN_DESC.rst.NumRods = 18S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(18).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(19)) Or RSWIN_DESC.rst.NumRods = 19S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(19).NumGuides)
							ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(20)) Or RSWIN_DESC.rst.NumRods = 20S Then
								num4 = CInt(RSWIN_DESC.rst.Sections(20).NumGuides)
							End If
							e.Style = PointerStyles.Circle
							If num4 = 0 Or Me.iGetPointStyle2_report Mod 2 = 0 Then
								e.Style = PointerStyles.[Nothing]
								e.Color = Color.Transparent
							ElseIf num4 <= 2 Then
								e.Color = Color.LightBlue
							ElseIf num4 <= 4 Then
								e.Color = Color.MediumBlue
							ElseIf num4 <= 6 Then
								e.Color = Color.Blue
							ElseIf num4 <= 99 Then
								e.Color = Color.DarkBlue
							Else
								e.Style = PointerStyles.[Nothing]
								e.Color = Color.Transparent
							End If
						End If
					End If
					If Me.iGetPointStyle2_report = Me.point3DSeries2_report.Count Then
						Me.iGetPointStyle2_report = 0
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub point3DSeries2_GetPointerStyle_XYZs(series As Points3D, e As GetPointerStyleEventArgs)
			Try
				Dim num As Double = Me.point3DSeries2.YValues(e.ValueIndex)
				Dim num2 As Double = CDbl(Me.GetMDVal(CSng(num), False))
				If num2 = 0.0 Then
					Me.m_bAfterPump2 = False
				End If
				Dim num3 As Single
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					num3 = RSWIN_DESC.rst.PumpDepth
				Else
					num3 = RSWIN_DESC.rst.PumpDepth * RSWIN_DESC.FT__M
					num2 *= CDbl(RSWIN_DESC.FT__M)
				End If
				If num2 < CDbl((num3 + 1F)) And Not Me.m_bAfterPump2 Then
					Me.m_bAfterPump2 = False
				ElseIf Not Me.m_bAfterPump2 Then
					Me.m_bAfterPump2 = True
				End If
				If Me.m_bAfterPump2 Then
					Me.point3DSeries2.LinePen.Color = Color.Black
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(1)) Or RSWIN_DESC.rst.NumRods = 1S Then
					Me.point3DSeries2.LinePen.Color = Color.Red
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(2)) Or RSWIN_DESC.rst.NumRods = 2S Then
					Me.point3DSeries2.LinePen.Color = Color.Green
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(3)) Or RSWIN_DESC.rst.NumRods = 3S Then
					Me.point3DSeries2.LinePen.Color = Color.Blue
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(4)) Or RSWIN_DESC.rst.NumRods = 4S Then
					Me.point3DSeries2.LinePen.Color = Color.Magenta
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(5)) Or RSWIN_DESC.rst.NumRods = 5S Then
					Me.point3DSeries2.LinePen.Color = Color.MediumTurquoise
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(6)) Or RSWIN_DESC.rst.NumRods = 6S Then
					Me.point3DSeries2.LinePen.Color = Color.Orange
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(7)) Or RSWIN_DESC.rst.NumRods = 7S Then
					Me.point3DSeries2.LinePen.Color = Color.Purple
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(8)) Or RSWIN_DESC.rst.NumRods = 8S Then
					Me.point3DSeries2.LinePen.Color = Color.Tan
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(9)) Or RSWIN_DESC.rst.NumRods = 9S Then
					Me.point3DSeries2.LinePen.Color = Color.DarkRed
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(10)) Or RSWIN_DESC.rst.NumRods = 10S Then
					Me.point3DSeries2.LinePen.Color = Color.Gray
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(11)) Or RSWIN_DESC.rst.NumRods = 11S Then
					Me.point3DSeries2.LinePen.Color = Color.Red
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(12)) Or RSWIN_DESC.rst.NumRods = 12S Then
					Me.point3DSeries2.LinePen.Color = Color.Green
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(13)) Or RSWIN_DESC.rst.NumRods = 13S Then
					Me.point3DSeries2.LinePen.Color = Color.Blue
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(14)) Or RSWIN_DESC.rst.NumRods = 14S Then
					Me.point3DSeries2.LinePen.Color = Color.Magenta
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(15)) Or RSWIN_DESC.rst.NumRods = 15S Then
					Me.point3DSeries2.LinePen.Color = Color.MediumTurquoise
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(16)) Or RSWIN_DESC.rst.NumRods = 16S Then
					Me.point3DSeries2.LinePen.Color = Color.Orange
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(17)) Or RSWIN_DESC.rst.NumRods = 17S Then
					Me.point3DSeries2.LinePen.Color = Color.Purple
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(18)) Or RSWIN_DESC.rst.NumRods = 18S Then
					Me.point3DSeries2.LinePen.Color = Color.Tan
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(19)) Or RSWIN_DESC.rst.NumRods = 19S Then
					Me.point3DSeries2.LinePen.Color = Color.DarkRed
				ElseIf num2 <= CDbl(RSWIN_DESC.taper_lens(20)) Or RSWIN_DESC.rst.NumRods = 20S Then
					Me.point3DSeries2.LinePen.Color = Color.Gray
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ResetClock()
			Try
				If RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
					If Me.MyParentFrm Is Nothing Then
						Try
							Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
						Catch ex As Exception
						End Try
					End If
					Me.MyParentFrm.bEnd = False
					Me.MyParentFrm.tmrClock.Enabled = False
					Me.MyParentFrm.NowTime = DateAndTime.Now
					Me.MyParentFrm.tmrClock.Enabled = True
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub TurnOffClock()
			Try
				If RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
					If Me.MyParentFrm Is Nothing Then
						Try
							Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
						Catch ex As Exception
						End Try
					End If
					Me.MyParentFrm.TurnOffClock()
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub TurnOnClock()
			Try
				If RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
					If Me.MyParentFrm Is Nothing Then
						Try
							Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
						Catch ex As Exception
						End Try
					End If
					Me.MyParentFrm.TurnOnClock()
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub ReRunCase()
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				RSWIN_DESC.rst.RodStringType = 2S
				Me.Hide()
				Me.MyParentFrm.mnuRunPrediction_Click(True)
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub DisableTimeClock()
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				Me.MyParentFrm.tmrClock.Enabled = False
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub Me_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_MouseDown(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_MouseEnter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_MouseMove(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_MouseUp(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_MouseWheel(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_Move(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_Scroll(sender As Object, e As ScrollEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_KeyUp(sender As Object, e As KeyEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_DragDrop(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_DragEnter(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs)
		End Sub

		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
		End Sub

		Private Sub Me_LostFocus(sender As Object, e As EventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub Me_GotFocus(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub commander1_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs)
			Me.ResetClock()
			Me.iGetPointStyle1 = 0
			Me.iGetPointStyle1_report = 0
			Me.iGetPointStyle2 = 0
			Me.iGetPointStyle2_report = 0
			Me.m_bAfterPump1 = False
			Me.m_bAfterPump2 = False
			Me.m_bAfterPump1_report = False
			Me.m_bAfterPump2_report = False
			Me.bCommanderClicked = True
		End Sub

		Private Sub Viewer1_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_DoubleClick(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_Enter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_KeyDown(sender As Object, e As KeyEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_KeyPress(sender As Object, e As KeyPressEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_Leave(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_Load(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_MouseClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_MouseWheel(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_Scroll(sender As Object, e As ScrollEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_ToolClick(sender As Object, e As ToolClickEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Viewer1_ZoomChanged(sender As Object, e As ZoomChangedEventArgs)
			Me.ResetClock()
		End Sub

		Public Sub ExportDevPlot(ByRef TChart1 As TChart)
			Try
				If Operators.CompareString(RSWIN_DESC.sDevPlotFileName, "", False) = 0 Then
					Dim text As String = Me.RandomClass.NextDouble().ToString()
					text = text.Replace(".", "")
					Try
						If Not Directory.Exists(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName()) Then
							Directory.CreateDirectory(RSWIN_DESC.sPathThetaData + "\" + VERSION1.ProgramName())
						End If
					Catch ex As Exception
					End Try
					RSWIN_DESC.sDevPlotFileName = String.Concat(New String() { RSWIN_DESC.sPathThetaData, "\", VERSION1.ProgramName(), "\", text.Trim(), "_DevPlot.bmp" })
				End If
				TChart1.Header.Lines = New String() { "", "" }
				Dim sDevPlotFileName As String = RSWIN_DESC.sDevPlotFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sDevPlotFileName)
				RSWIN_DESC.sDevPlotFileName = sDevPlotFileName
				If flag Then
					Try
						FileSystem.Kill(RSWIN_DESC.sDevPlotFileName)
					Catch ex2 As Exception
					End Try
				End If
				Try
					TChart1.Bitmap.Save(RSWIN_DESC.sDevPlotFileName)
				Catch ex3 As Exception
				End Try
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub optPrevDevChart_Click(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.m_iDevChart -= 1
			If Me.m_iDevChart < 1 Then
				Me.m_iDevChart = 1
			End If
			Me.ShowDevPlot(Me.m_iDevChart)
		End Sub

		Private Sub optNextDevChart_Click(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.m_iDevChart += 1
			If Me.m_iDevChart > 8 Then
				Me.m_iDevChart = 8
			End If
			Me.ShowDevPlot(Me.m_iDevChart)
		End Sub

		Private Sub btnImplement_CheckedChanged(sender As Object, e As EventArgs)
			Dim rptAll As rptAll = New rptAll()
			Dim str As String = ""
			Dim flag As Boolean = True
			Try
				If Me.btnImplement Is Me.ActiveControl And Me.btnImplement.Checked Then
					If RSWIN_DESC.rst.bImplementedDesign Then
						Dim text As String = "This case has previously had Rod Guides implemented. Continue with implementation?"
						Dim msg As String = text
						Dim bDefaultYes As Boolean = True
						Dim flag2 As Boolean = False
						flag = Util.YesNo(msg, bDefaultYes, flag2)
					End If
					If flag Then
						If RSWIN_DESC.SETUP_GuideToUse <> 0 Then
							str = " RODSTAR will use the default rod guides in setup (" + MImpred.GetRodGuideName(CShort(RSWIN_DESC.SETUP_GuideToUse)) + ") to implement the calculated rod guide placement."
						End If
						Dim text As String = "Rod Guide Implementation is an iterative process and may take several minutes to complete." + str + " Do you wish to continue?"
						Dim msg2 As String = text
						Dim bDefaultYes2 As Boolean = True
						Dim flag2 As Boolean = False
						If Util.YesNo(msg2, bDefaultYes2, flag2) Then
							SUPERPRO.NewCheckSentinel(True)
							If RSWIN_DESC.rst.gbReportGuide Then
								Util.BusyCursor()
								Application.DoEvents()
								Application.DoEvents()
								Dim obj As Object
								Try
									obj = New rptRecommendedGuideReport2()
								Catch ex As Exception
								End Try
								NewLateBinding.LateSet(obj, Nothing, "bPrint", New Object() { False }, Nothing, Nothing)
								Dim flag3 As Boolean
								NewLateBinding.LateSet(obj, Nothing, "bMaxFootnote", New Object() { flag3 }, Nothing, Nothing)
								Dim text2 As String
								NewLateBinding.LateSet(obj, Nothing, "sMaxFootnote", New Object() { text2 }, Nothing, Nothing)
								Dim flag4 As Boolean
								NewLateBinding.LateSet(obj, Nothing, "bMinFootnote", New Object() { flag4 }, Nothing, Nothing)
								Dim text3 As String
								NewLateBinding.LateSet(obj, Nothing, "sMinFootnote", New Object() { text3 }, Nothing, Nothing)
								Dim text4 As String
								NewLateBinding.LateSet(obj, Nothing, "sGuideMsg", New Object() { text4 }, Nothing, Nothing)
								Try
									Dim xmldataSource As XMLDataSource = New XMLDataSource()
									xmldataSource.LoadXML(RSWIN_DESC.sSummaryDataSetXML)
									NewLateBinding.LateSet(obj, Nothing, "ds", New Object() { xmldataSource }, Nothing, Nothing)
									NewLateBinding.LateSet(obj, Nothing, "DataSource", New Object() { xmldataSource }, Nothing, Nothing)
								Catch ex2 As Exception
								End Try
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "ValidateOnParse", New Object() { True }, Nothing, Nothing, False, True)
								CType(NewLateBinding.LateGet(obj, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), XMLDataSource).RecordsetPattern = "//Data/Entries/Row"
								NewLateBinding.LateSet(obj, Nothing, "TotalPageNumber", New Object() { RSWIN_DESC.rst.Number_Of_Guide_report_Pages }, Nothing, Nothing)
								Dim num As Integer = 1
								NewLateBinding.LateSet(obj, Nothing, "ThisPageNumber", New Object() { num }, Nothing, Nothing)
								NewLateBinding.LateSet(obj, Nothing, "NumberOfLines", New Object() { Me.nGuideLines }, Nothing, Nothing)
								Try
									NewLateBinding.LateCall(obj, Nothing, "Run", New Object() { True }, Nothing, Nothing, Nothing, True)
									Debug.WriteLine(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Pages", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "COunt", New Object(-1) {}, Nothing, Nothing, Nothing)))
								Catch ex3 As Exception
								End Try
								Dim num2 As Integer = 1
								Try
									For Each obj2 As Object In CType(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Pages", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable)
										Dim value As DataDynamics.ActiveReports.Document.Page = CType(obj2, DataDynamics.ActiveReports.Document.Page)
										rptAll.Document.Pages.Insert(rptAll.Document.Pages.Count, value)
										If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Pages", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Count", New Object(-1) {}, Nothing, Nothing, Nothing), RSWIN_DESC.rst.Number_Of_Guide_report_Pages, False))) Then
											num2 += 1
											If num2 > RSWIN_DESC.rst.Number_Of_Guide_report_Pages Then
												Exit For
											End If
										End If
									Next
								Finally
									Dim enumerator As IEnumerator
									If TypeOf enumerator Is IDisposable Then
										TryCast(enumerator, IDisposable).Dispose()
									End If
								End Try
								If Me.dlgImplementGuideChanges Is Nothing Then
									Me.dlgImplementGuideChanges = New dlgImplementGuideChanges()
								End If
								Me.dlgImplementGuideChanges.Viewer1.Document = rptAll.Document
								Application.DoEvents()
								Application.DoEvents()
								Me.dlgImplementGuideChanges.Refresh()
								Application.DoEvents()
								Application.DoEvents()
								Me.TurnOffClock()
								Dim flag5 As Boolean = Me.VerifySideLoads()
								If flag5 Then
									Me.dlgImplementGuideChanges.ShowDialog()
									Me.TurnOnClock()
									Me.btnImplement.Checked = False
									Me.btnImplement.Enabled = False
									If Me.dlgImplementGuideChanges.bAccept Then
										Me.ReRunCase()
										Me.dlgImplementGuideChanges = Nothing
										Return
									End If
									If Me.dlgImplementGuideChanges.bKeep Then
										Try
											RSWIN_DESC.SETUP_RECOMMEND_GUIDES = False
											Dim text5 As String = "RecommendGuides"
											Dim text6 As String = Conversions.ToString(RSWIN_DESC.SETUP_RECOMMEND_GUIDES)
											RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text5, text6, RSWIN_DESC.sINIFile)
											RSWIN_DESC.SETUP_RECOMMEND_GUIDES = Conversions.ToBoolean(text6)
											If Me.MyParentFrm Is Nothing Then
												Try
													Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
												Catch ex4 As Exception
												End Try
											End If
											Me.MyParentFrm.AddRSInput(True, True)
										Catch ex5 As Exception
										End Try
										Me.Hide()
									Else
										Me.optReport_Click_1(CShort(Me.iCurrentRptOpt), True, True)
									End If
									Me.dlgImplementGuideChanges = Nothing
								Else
									MessageBox.Show("The side load data has been lost or corrupted. Rod Guide Implementation cannot continue. Please rerun case. If problem continues please contact technical support.")
								End If
							End If
						Else
							Me.btnImplement.Checked = False
						End If
					Else
						Me.btnImplement.Checked = False
					End If
				End If
				Util.UnbusyCursor()
			Catch ex6 As Exception
			End Try
		End Sub

		Public Sub InitializeGuideFrequencyArrays()
			' The following expression was wrapped in a checked-statement
			Try
				Try
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						RSWIN_DESC.GuideFrequencyArray(i).SectionLength = RSWIN_DESC.rst.Sections(i).length
						RSWIN_DESC.GuideFrequencyArray(i).NumberOfSubSections = 0
						RSWIN_DESC.GuideFrequencyArray(i).SubSections = New RSWIN_DESC.SubSectionType(0) {}
						RSWIN_DESC.GuideFrequencyArray(i).SubSections(0).Length = 0F
						RSWIN_DESC.GuideFrequencyArray(i).SubSections(0).Added = False
						If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Then
							RSWIN_DESC.GuideFrequencyArray(i).SuckerRodLength = 37.5F
						Else
							RSWIN_DESC.GuideFrequencyArray(i).SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
						End If
					Next
				Catch ex As Exception
				End Try
				If RSWIN_DESC.rst.NumRods > 1S Then
					Dim num2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					Dim flag As Boolean = True
					Dim num3 As Integer = 1
					While flag
						num3 = num2
						flag = False
						num2 -= 1
						If num2 = 0 Then
							flag = False
						End If
					End While
					If num3 > 1 Then
						Dim i As Integer = num3
						If RSWIN_DESC.GuideFrequencyArray(i).SectionLength >= 600F Then
							RSWIN_DESC.GuideFrequencyArray(i).NumberOfSubSections = 2
							RSWIN_DESC.GuideFrequencyArray(i).SubSections = New RSWIN_DESC.SubSectionType(2) {}
							Dim j As Integer = 1
							Do
								RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).Length = RSWIN_DESC.GuideFrequencyArray(i).SectionLength / 2F
								RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).Added = False
								j += 1
							Loop While j <= 2
						Else
							RSWIN_DESC.GuideFrequencyArray(i).NumberOfSubSections = 1
							RSWIN_DESC.GuideFrequencyArray(i).SubSections = New RSWIN_DESC.SubSectionType(1) {}
							RSWIN_DESC.GuideFrequencyArray(i).SubSections(1).Length = RSWIN_DESC.GuideFrequencyArray(i).SectionLength
							RSWIN_DESC.GuideFrequencyArray(i).SubSections(1).Added = False
						End If
						i = num3 - 1
						While i >= 1
							If RSWIN_DESC.GuideFrequencyArray(i).SectionLength >= 600F Then
								RSWIN_DESC.GuideFrequencyArray(i).NumberOfSubSections = 2
								RSWIN_DESC.GuideFrequencyArray(i).SubSections = New RSWIN_DESC.SubSectionType(2) {}
								Dim j As Integer = 1
								Do
									RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).Length = RSWIN_DESC.GuideFrequencyArray(i).SectionLength / 2F
									RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).Added = False
									j += 1
								Loop While j <= 2
							Else
								RSWIN_DESC.GuideFrequencyArray(i).NumberOfSubSections = 1
								RSWIN_DESC.GuideFrequencyArray(i).SubSections = New RSWIN_DESC.SubSectionType(1) {}
								RSWIN_DESC.GuideFrequencyArray(i).SubSections(1).Length = RSWIN_DESC.GuideFrequencyArray(i).SectionLength
								RSWIN_DESC.GuideFrequencyArray(i).SubSections(1).Added = False
							End If
							i += -1
						End While
					End If
				End If
				RSWIN_DESC.GuideFrequencyArray(1).SectionDepth = RSWIN_DESC.GuideFrequencyArray(1).SectionLength
				Dim num4 As Integer = 2
				Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num4 To numRods2
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					RSWIN_DESC.GuideFrequencyArray(i).SectionDepth = RSWIN_DESC.GuideFrequencyArray(i - 1).SectionDepth + RSWIN_DESC.GuideFrequencyArray(i).SectionLength
				Next
				RSWIN_DESC.GuideFrequencyArray(0).SectionDepth = 0F
				Dim num5 As Integer = 1
				Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num5 To numRods3
					Dim num6 As Integer = i
					RSWIN_DESC.GuideFrequencyArray(num6).SubSections(0).Depth = RSWIN_DESC.GuideFrequencyArray(i - 1).SectionDepth
					Dim num7 As Integer = 1
					Dim numberOfSubSections As Integer = RSWIN_DESC.GuideFrequencyArray(num6).NumberOfSubSections
					For j As Integer = num7 To numberOfSubSections
						Try
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Grade = RSWIN_DESC.rst.Sections(i).Grade
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).RodType = RSWIN_DESC.rst.Sections(i).RodType
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Diameter = RSWIN_DESC.rst.Sections(i).Diameter
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Area = RSWIN_DESC.rst.Sections(i).Area
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodLength = RSWIN_DESC.rst.Sections(i).SuckerRodLength
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).RodDensity = RSWIN_DESC.rst.Sections(i).RodDensity
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).RodWeight = RSWIN_DESC.rst.Sections(i).RodWeight
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Elasticity = RSWIN_DESC.rst.Sections(i).Elasticity
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).TensileStrength = RSWIN_DESC.rst.Sections(i).TensileStrength
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).StressMethod = RSWIN_DESC.rst.Sections(i).StressMethod
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Guide = RSWIN_DESC.rst.Sections(i).Guide
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).friction_coef = RSWIN_DESC.rst.Sections(i).friction_coef
						Catch ex2 As Exception
						End Try
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).NumberOfSuckerRodsInSection = CInt(Math.Round(CDbl((RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Length / RSWIN_DESC.GuideFrequencyArray(i).SuckerRodLength)) + 0.5))
						Dim num8 As Integer = RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).NumberOfSuckerRodsInSection
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodDepths = New Single(num8 + 1 - 1) {}
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodNumGuides = New Single(num8 + 1 - 1) {}
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Start = RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j - 1).Depth
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Depth = RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j - 1).Depth + RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Length
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodDepths(0) = RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Start
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodNumGuides(0) = 0F
						Dim num9 As Integer = 1
						Dim num10 As Integer = num8
						For k As Integer = num9 To num10
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodDepths(k) = RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodDepths(k - 1) + RSWIN_DESC.GuideFrequencyArray(i).SuckerRodLength
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodNumGuides(k) = 0F
						Next
					Next
				Next
				Dim num11 As Single = 0F
				Dim num12 As Single = 0F
				Dim num13 As Integer = 1
				Dim numRods4 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num13 To numRods4
					Debug.WriteLine(String.Concat(New String() { Conversions.ToString(i), " , ", Conversions.ToString(RSWIN_DESC.GuideFrequencyArray(i).SectionLength), " , ", Conversions.ToString(RSWIN_DESC.GuideFrequencyArray(i).SectionDepth) }))

						num11 += RSWIN_DESC.rst.Sections(i).length
						num12 += RSWIN_DESC.GuideFrequencyArray(i).SectionLength

				Next
				Debug.Write(Conversions.ToString(num11) + " , " + Conversions.ToString(num12))
				Debug.Write(" ")
				Debug.Write(" Depths =============================================== ")
				Dim num14 As Integer = 1
				Dim numRods5 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num14 To numRods5
					Debug.WriteLine("I " + Conversions.ToString(i) + " , " + Conversions.ToString(RSWIN_DESC.GuideFrequencyArray(i).SectionDepth))
					Dim num8 As Integer = RSWIN_DESC.GuideFrequencyArray(i).NumberOfSubSections
					Dim num15 As Integer = 1
					Dim num16 As Integer = num8
					For j As Integer = num15 To num16
						Debug.WriteLine("   J " + Conversions.ToString(j) + " , " + Conversions.ToString(RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).Depth))
						Dim numberOfSuckerRodsInSection As Integer = RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).NumberOfSuckerRodsInSection
						Dim num17 As Integer = 1
						Dim num18 As Integer = numberOfSuckerRodsInSection
						For k As Integer = num17 To num18
							Debug.WriteLine("       K " + Conversions.ToString(k) + " , " + Conversions.ToString(RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).SuckerRodDepths(k)))
						Next
					Next
				Next
			Catch ex3 As Exception
			End Try
		End Sub

		Public Function VerifySideLoads() As Boolean
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Dim result As Boolean = True
			Dim flag As Boolean = True
			Try
				flag = MImpred.CheckSurveyForDeviation()
			Catch ex As Exception
			End Try
			Try
				Dim array As Single() = New Single(impredObj.num_rod_elements + 1 - 1) {}
				array(0) = 0F
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				End If
				Dim num As Single = 0F
				If impredObj.num_rod_elements > 0 Then
					Dim num2 As Long = 0L
					Dim num3 As Long = CLng((impredObj.num_rod_elements - 1))
					For num4 As Long = num2 To num3
						Dim num5 As Single = CSng(impredObj.get_r_e(CInt((num4 + 1L))).m_d)
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							CtrlUI.ConvertValue(num5, "f", False)
						End If
						Dim num6 As Single = num5 - num
						array(CInt(num4)) = num6
						num = num5
					Next
					Dim num7 As Long = 0L
					Dim num8 As Long = CLng((impredObj.num_rod_elements - 1))
					For num4 As Long = num7 To num8
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						Dim num5 As Single = CSng(-CSng(impredObj.get_r_e(CInt((num4 + 1L))).m_d))
						If flag Then
							Dim max_sf_total As Double = impredObj.get_r_e(CInt((num4 + 1L))).max_sf_total
							If max_sf_total < 0.0 Then
								result = False
							End If
						End If
					Next
				Else
					result = False
				End If
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function VerifySideLoads_2() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			If num = 0 Then
				' The following expression was wrapped in a unchecked-expression
				Dim num2 As Integer = CInt(Math.Round(Conversion.Int(CDbl((RSWIN_DESC.rst.PumpDepth / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
				num = 0
				Dim num3 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num3 To numRods
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Then
						' The following expression was wrapped in a unchecked-expression
						num = CInt(Math.Round(CDbl(num) + Conversion.Int(CDbl(RSWIN_DESC.rst.Sections(i).length) / 37.5 + 0.5)))
					Else
						' The following expression was wrapped in a unchecked-expression
						num = CInt(Math.Round(CDbl(num) + Conversion.Int(CDbl((RSWIN_DESC.rst.Sections(i).length / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
					End If
				Next
			End If
			Dim result As Boolean
			Try
				RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				RSWIN_DESC.taper_lens(0) = 0F
				Dim num4 As Integer = 1
				Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num4 To numRods2
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					RSWIN_DESC.taper_lens(i) = RSWIN_DESC.taper_lens(i - 1) + RSWIN_DESC.rst.Sections(i).length
				Next
				Dim array As Single()
				Dim array2 As Single()
				Try
					If array Is Nothing Then
						array = New Single(num + 1 - 1) {}
						array2 = New Single(num + 1 - 1) {}
					ElseIf num > Information.UBound(array, 1) Then
						array = New Single(num + 1 - 1) {}
						array2 = New Single(num + 1 - 1) {}
					End If
				Catch ex As Exception
				End Try
				Dim num5 As Integer = Information.LBound(array, 1)
				Dim num6 As Integer = Information.UBound(array, 1)
				Try
					Dim num7 As Integer = num5
					Dim num8 As Integer = num6
					For i As Integer = num7 To num8
						array(i) = 0F
						array2(i) = RSWIN_DESC.SETUP_SteelSuckerRodLength
					Next
				Catch ex2 As Exception
				End Try
				Dim impredObj As TEImpred
				Try
					impredObj = MImpred.ImpredObj
				Catch ex3 As Exception
				End Try
				Dim num9 As Single
				If impredObj.p_s.rod_element_length <> 0.0 Then
					num9 = CSng(impredObj.p_s.rod_element_length)
					RSWIN_DESC.num_rod_elements = impredObj.num_rod_elements
				End If
				If num9 = 0F Then
					' The following expression was wrapped in a unchecked-expression
					num9 = CSng(Conversion.Int(impredObj.get_r_e(2).m_d - impredObj.get_r_e(1).m_d + 0.5))
					If num9 = 0F And impredObj.p_s.rod_element_length = 0.0 Then
						num9 = CSng((CDbl(RSWIN_DESC.taper_lens(CInt(RSWIN_DESC.rst.NumRods))) / Convert.ToDouble(impredObj.p_s.num_rod_elements)))
					End If
				End If
				Dim lastDepth As Single = Util.GetLastDepth(RSWIN_DESC.mdsDeviationProfile, False, 1)
				Dim num10 As Single
				If RODUTIL.IsFG(CShort(impredObj.get_r_e(1).Grade)) Or CUSTOMRG.IsOtherFG(impredObj.get_r_e(1).Grade) Then
					num10 = 37.5F
				Else
					num10 = RSWIN_DESC.SETUP_SteelSuckerRodLength
				End If
				array2(0) = num10
				array2(1) = num10
				Dim num11 As Single = 0F
				Dim num_rod_elements As Integer = impredObj.num_rod_elements
				Dim num12 As Integer = 0
				Dim num13 As Integer = -1
				Dim num14 As Integer = 0
				Dim num15 As Integer = 1
				Dim num16 As Single = 0F

					While num11 <= lastDepth
						Try
							num11 += 1F
							If num11 <= lastDepth Then
								' The following expression was wrapped in a checked-statement
								num12 += 1
								If CSng(num12) > num9 Then
									Try
										num12 = 1
										num14 += 1
										num16 = CSng(impredObj.get_r_e(num14).max_sf_total)
										If RODUTIL.IsFG(CShort(impredObj.get_r_e(num14).Grade)) Or CUSTOMRG.IsOtherFG(impredObj.get_r_e(num14).Grade) Then
											num10 = 37.5F
										Else
											num10 = RSWIN_DESC.SETUP_SteelSuckerRodLength
										End If
									Catch ex4 As Exception
									End Try
								End If
								num13 += 1
								If CSng(num13) > num10 Then
									num13 = 1
									num15 += 1
								End If
								If num16 > 0F AndAlso num15 <= num6 Then
									Try
										array(num15) += num16 * (1F / num9)
									Catch ex5 As Exception
									End Try
									If num10 <> 0F Then
										array2(num15) = num10
									Else
										array2(num15) = RSWIN_DESC.SETUP_SteelSuckerRodLength
									End If
								End If
							End If
						Catch ex6 As Exception
						End Try
					End While
					If num15 < 2 Then
						result = False
					Else
						result = True
					End If

			Catch ex7 As Exception
				result = False
			End Try
			Return result
		End Function

		Public Sub ReInitializeVars()
			' The following expression was wrapped in a checked-statement
			Try
				Me.m_Animate_SurfPos = New Single(0) {}
				Me.m_Animate_SurfLoad = New Single(0) {}
				Me.m_Animate_PumpPos = New Single(0) {}
				Me.m_Animate_PumpLoad = New Single(0) {}
				Me.m_TVDepth = New Double(0) {}
				Me.m_MeasDepth = New Double(0) {}
				Me.plotted_rod_num_guides = New Integer(0) {}
				RSWIN_DESC.Guide_XYZ_indexes = New Integer(0) {}
				Me.m_bAfterPump1 = False
				Me.m_bAfterPump2 = False
				Me.m_bAfterPump1_report = False
				Me.m_bAfterPump2_report = False
				Me.m_bReplot = False
				Me.m_iStep = 0
				RSWIN_DESC.sSummaryDataSetXML = ""
				RSWIN_DESC.sDeviationProfileXML = ""
				Me.bForward = True
				Me.bPlay = False
				Me.bTogglePlay = False
				Me.bFormLoaded = False
				Me.sPanelType = ""
				Me.iInterval = 0
				Me.nStep = 1
				Me.nSkip = 1
				Me.nInitialSkip = 1
				Me.IntervalConst = 180000
				Me.nGuideLines = 0
				Me.nDevSurveyLines = 0
				Me.myKeyValueHT = New Hashtable()
				Me.fMaxForCharts = 0F
				Me.m_iDevChart = 0
				Me.bImplementOn = False
				Me.iAnimationCycle = 0
				Me.bDogLegsCalculated = False
				Me.ChartFX_Dyno.Data.Clear()
				Me.ChartFX_Temp_Dyno.Data.Clear()
				Me.ChartFX_TorquePlot.Data.Clear()
				Me.ChartFX_Temp_TorquePlot.Data.Clear()
				Me.ChartFX_Temp_Torque_L.Data.Clear()
				Me.ChartFX_Temp_Dyno_L.Data.Clear()
				Me.ChartFX_Temp_Dyno_XL.Data.Clear()
				Me.ChartFX_Temp_Torque_XL.Data.Clear()
				Me.ChartFX_LookingEast.Data.Clear()
				Me.chtAxialLoads.Data.Clear()
				Me.chtBucklingTendency.Data.Clear()
				Me.chtSideForces.Data.Clear()
				Me.chtSurveyPlan.Data.Clear()
				Me.chtSurveyNS.Data.Clear()
				Me.chtSurveyEW.Data.Clear()
				Me.chtDoglegs.Data.Clear()
				Me.ChartFX_Dyno.Extensions.Clear()
				Me.ChartFX_Temp_Dyno.Extensions.Clear()
				Me.ChartFX_TorquePlot.Extensions.Clear()
				Me.ChartFX_Temp_TorquePlot.Extensions.Clear()
				Me.ChartFX_Temp_Torque_L.Extensions.Clear()
				Me.ChartFX_Temp_Dyno_L.Extensions.Clear()
				Me.ChartFX_Temp_Dyno_XL.Extensions.Clear()
				Me.ChartFX_Temp_Torque_XL.Extensions.Clear()
				Me.ChartFX_LookingEast.Extensions.Clear()
				Me.chtAxialLoads.Extensions.Clear()
				Me.chtBucklingTendency.Extensions.Clear()
				Me.chtSideForces.Extensions.Clear()
				Me.chtSurveyPlan.Extensions.Clear()
				Me.chtSurveyNS.Extensions.Clear()
				Me.chtSurveyEW.Extensions.Clear()
				Me.chtDoglegs.Extensions.Clear()
				Me.ChartFX_Temp_Dyno.LegendBox.CustomItems.Clear()
				Me.ChartFX_Temp_TorquePlot.LegendBox.CustomItems.Clear()
				Me.ChartFX_TorquePlot.LegendBox.CustomItems.Clear()
				Me.ChartFX_Dyno.LegendBox.CustomItems.Clear()
				Me.ChartFX_Temp_Torque_L.LegendBox.CustomItems.Clear()
				Me.ChartFX_Temp_Dyno_L.LegendBox.CustomItems.Clear()
				Me.ChartFX_Temp_Dyno_XL.LegendBox.CustomItems.Clear()
				Me.ChartFX_Temp_Torque_XL.LegendBox.CustomItems.Clear()
				Me.ChartFX_LookingEast.LegendBox.CustomItems.Clear()
				Me.chtAxialLoads.LegendBox.CustomItems.Clear()
				Me.chtBucklingTendency.LegendBox.CustomItems.Clear()
				Me.chtSideForces.LegendBox.CustomItems.Clear()
				Me.chtSurveyPlan.LegendBox.CustomItems.Clear()
				Me.chtSurveyNS.LegendBox.CustomItems.Clear()
				Me.chtSurveyEW.LegendBox.CustomItems.Clear()
				Me.chtDoglegs.LegendBox.CustomItems.Clear()
				Me.ChartFX_DoglegSeverity.Data.Clear()
				Me.ChartFX_LookingEast.Data.Clear()
				Me.ChartFX_LookingDown.Data.Clear()
				Me.ChartFX_LookingNorth.Data.Clear()
				Me.ChartFX_SideLoading.Data.Clear()
				Me.ChartFX_BucklingTendency.Data.Clear()
				Me.ChartFX_AxialLoads.Data.Clear()
				Me.ChartFX_DoglegSeverity.LegendBox.CustomItems.Clear()
				Me.ChartFX_LookingEast.LegendBox.CustomItems.Clear()
				Me.ChartFX_LookingDown.LegendBox.CustomItems.Clear()
				Me.ChartFX_LookingNorth.LegendBox.CustomItems.Clear()
				Me.ChartFX_SideLoading.LegendBox.CustomItems.Clear()
				Me.ChartFX_BucklingTendency.LegendBox.CustomItems.Clear()
				Me.ChartFX_AxialLoads.LegendBox.CustomItems.Clear()
				If Me.point3DSeries1 IsNot Nothing Then
					Me.point3DSeries1.Clear()
				End If
				If Me.point3DSeries1_report IsNot Nothing Then
					Me.point3DSeries1_report.Clear()
				End If
				If Me.point3DSeries2 IsNot Nothing Then
					Me.point3DSeries2.Clear()
				End If
				If Me.point3DSeries2_report IsNot Nothing Then
					Me.point3DSeries2_report.Clear()
				End If
				If Me.TChart1_Report IsNot Nothing Then
					Me.TChart1_Report.Series.Clear()
				End If
				If Me.TChart1 IsNot Nothing Then
					Me.TChart1.Series.Clear()
				End If
				Me.Viewer1.Document = Nothing
				Me.Viewer1.ReportViewer.PageOffset = 0
				Me.Viewer1.ReportViewer.CurrentPage = 0
				Me.Viewer1.ReportViewer.RepositionPage = True
				RSWIN_DESC.taper_lens(1) = RSWIN_DESC.rst.Sections(1).length
				Dim num As Integer = 2
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					RSWIN_DESC.taper_lens(i) = RSWIN_DESC.taper_lens(i - 1) + RSWIN_DESC.rst.Sections(i).length
				Next
				If RSWIN_DESC.bRodStarD And RSWIN_DESC.bCheckRodGuideFrequency Then
					Me.InitializeGuideFrequencyArrays()
				End If
				If RSWIN_DESC.bRodStarD Then
					If RSWIN_DESC.rst.gbReportDevSurvey Or RSWIN_DESC.rst.gbReportDevChart Then
						Me.m_bAfterPump1 = False
						Me.m_bAfterPump2 = False
						Me.m_bAfterPump1_report = False
						Me.m_bAfterPump2_report = False
						Dim num2 As Short
						Try
							Me.ShowDeviation_Dogleg(RSWIN_DESC.mdsDeviationProfile, False, True)
							Me.ShowDeviation_TVD(RSWIN_DESC.mdsDeviationProfile, False, num2)
						Catch ex As Exception
						End Try
						Try
							Me.mdsDeviationProfile_Output = Nothing
							MImpred.InitSurveyDataset(Me.mdsDeviationProfile_Output, Nothing)
							MImpred.CopyDatasets(RSWIN_DESC.mdsDeviationProfile, Me.mdsDeviationProfile_Output, RSWIN_DESC.SETUP_MeasurementSystem <> 1, False)
							Try
								Me.m_bAfterPump1 = False
								Me.m_bAfterPump2 = False
								Me.m_bAfterPump1_report = False
								Me.m_bAfterPump2_report = False
								Me.ShowDeviation_Dogleg(Me.mdsDeviationProfile_Output, False, True)
								Me.ShowDeviation_TVD(Me.mdsDeviationProfile_Output, True, num2)
							Catch ex2 As Exception
							End Try
							Me.BuildDeviationProfileXML_from_DS(Me.mdsDeviationProfile_Output, Me.nDevSurveyLines)
						Catch ex3 As Exception
						End Try
						Me.btnImplement.Enabled = False
						Me.btnImplement.Checked = False
						Me.btnImplement.Enabled = True
					End If
					Dim num3 As Integer = 0
					Dim num4 As Integer = Me.commander1.Buttons.Length - 1
					For i As Integer = num3 To num4
						Try
							Me.commander1.Buttons(i).Pushed = False
						Catch ex4 As Exception
						End Try
					Next
					Try
						Me.btnImplement.Checked = False
					Catch ex5 As Exception
					End Try
					Try
						Me._optReport_0.Checked = False
						Me._optReport_1.Checked = False
						Me._optReport_2.Checked = False
					Catch ex6 As Exception
					End Try
				End If
			Catch ex7 As Exception
			End Try
		End Sub

		Private Sub ReInitializeComponents()
			Try
				Me.ChartFX_Dyno.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_Dyno.AllSeries.MarkerSize = 4S
				Me.ChartFX_Dyno.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Dyno.AxisX.Grids.Major.Visible = False
				Me.ChartFX_Dyno.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Dyno.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Dyno.AxisY.Grids.Major.Visible = False
				Me.ChartFX_Dyno.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Dyno.ContextMenus = False
				Me.ChartFX_Dyno.LegendBox.Border = DockBorder.External
				Me.ChartFX_Dyno.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_Dyno As Control = Me.ChartFX_Dyno
				Dim location As Point = New Point(76, 19)
				chartFX_Dyno.Location = location
				Me.ChartFX_Dyno.Name = "ChartFX_Dyno"
				Dim chartFX_Dyno2 As Control = Me.ChartFX_Dyno
				Dim size As Size = New Size(640, 347)
				chartFX_Dyno2.Size = size
				Me.ChartFX_Dyno.TabIndex = 1
				Me.ChartFX_TorquePlot.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_TorquePlot.AllSeries.MarkerSize = 4S
				Me.ChartFX_TorquePlot.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_TorquePlot.AxisX.Grids.Major.Visible = False
				Me.ChartFX_TorquePlot.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_TorquePlot.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_TorquePlot.AxisY.Grids.Major.Visible = False
				Me.ChartFX_TorquePlot.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_TorquePlot.LegendBox.Border = DockBorder.External
				Me.ChartFX_TorquePlot.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_TorquePlot As Control = Me.ChartFX_TorquePlot
				location = New Point(71, 19)
				chartFX_TorquePlot.Location = location
				Me.ChartFX_TorquePlot.Name = "ChartFX_TorquePlot"
				Dim chartFX_TorquePlot2 As Control = Me.ChartFX_TorquePlot
				size = New Size(645, 340)
				chartFX_TorquePlot2.Size = size
				Me.ChartFX_TorquePlot.TabIndex = 0
				Me.ChartFX_Temp_TorquePlot.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_Temp_TorquePlot.AllSeries.MarkerSize = 4S
				Me.ChartFX_Temp_TorquePlot.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Temp_TorquePlot.AxisX.Grids.Major.Visible = False
				Me.ChartFX_Temp_TorquePlot.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Temp_TorquePlot.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Temp_TorquePlot.AxisY.Grids.Major.Visible = False
				Me.ChartFX_Temp_TorquePlot.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Temp_TorquePlot.BackColor = SystemColors.ControlLightLight
				Me.ChartFX_Temp_TorquePlot.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_Temp_TorquePlot As Control = Me.ChartFX_Temp_TorquePlot
				location = New Point(192, 40)
				chartFX_Temp_TorquePlot.Location = location
				Me.ChartFX_Temp_TorquePlot.Name = "ChartFX_Temp_TorquePlot"
				Me.ChartFX_Temp_TorquePlot.PlotAreaMargin.Bottom = 1
				Me.ChartFX_Temp_TorquePlot.PlotAreaMargin.Left = 1
				Me.ChartFX_Temp_TorquePlot.PlotAreaMargin.Right = 1
				Me.ChartFX_Temp_TorquePlot.PlotAreaMargin.Top = 1
				Dim chartFX_Temp_TorquePlot2 As Control = Me.ChartFX_Temp_TorquePlot
				size = New Size(384, 256)
				chartFX_Temp_TorquePlot2.Size = size
				Me.ChartFX_Temp_TorquePlot.TabIndex = 2
				Me.ChartFX_Temp_Dyno.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_Temp_Dyno.AllSeries.MarkerSize = 4S
				Me.ChartFX_Temp_Dyno.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Temp_Dyno.AxisX.Grids.Major.Visible = False
				Me.ChartFX_Temp_Dyno.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Temp_Dyno.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Temp_Dyno.AxisY.Grids.Major.Visible = False
				Me.ChartFX_Temp_Dyno.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Temp_Dyno.BackColor = SystemColors.ControlLightLight
				Me.ChartFX_Temp_Dyno.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_Temp_Dyno As Control = Me.ChartFX_Temp_Dyno
				location = New Point(8, 16)
				chartFX_Temp_Dyno.Location = location
				Me.ChartFX_Temp_Dyno.Name = "ChartFX_Temp_Dyno"
				Me.ChartFX_Temp_Dyno.PlotAreaMargin.Bottom = 1
				Me.ChartFX_Temp_Dyno.PlotAreaMargin.Left = 1
				Me.ChartFX_Temp_Dyno.PlotAreaMargin.Right = 1
				Me.ChartFX_Temp_Dyno.PlotAreaMargin.Top = 1
				Dim chartFX_Temp_Dyno2 As Control = Me.ChartFX_Temp_Dyno
				size = New Size(384, 256)
				chartFX_Temp_Dyno2.Size = size
				Me.ChartFX_Temp_Dyno.TabIndex = 1
				Me.ChartFX_Temp_Torque_L.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_Temp_Torque_L.AllSeries.MarkerSize = 4S
				Me.ChartFX_Temp_Torque_L.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Temp_Torque_L.AxisX.Grids.Major.Visible = False
				Me.ChartFX_Temp_Torque_L.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Temp_Torque_L.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Temp_Torque_L.AxisY.Grids.Major.Visible = False
				Me.ChartFX_Temp_Torque_L.LegendBox.BackColor = Color.Transparent
				Me.ChartFX_Temp_Torque_L.LegendBox.Border = DockBorder.External
				Me.ChartFX_Temp_Torque_L.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_Temp_Torque_L As Control = Me.ChartFX_Temp_Torque_L
				location = New Point(7, 12)
				chartFX_Temp_Torque_L.Location = location
				Me.ChartFX_Temp_Torque_L.Name = "ChartFX_Temp_Torque_L"
				Dim chartFX_Temp_Torque_L2 As Control = Me.ChartFX_Temp_Torque_L
				size = New Size(700, 388)
				chartFX_Temp_Torque_L2.Size = size
				Me.ChartFX_Temp_Torque_L.TabIndex = 3
				Me.ChartFX_Temp_Dyno_L.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_Temp_Dyno_L.AllSeries.MarkerSize = 4S
				Me.ChartFX_Temp_Dyno_L.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Temp_Dyno_L.AxisX.Grids.Major.Visible = False
				Me.ChartFX_Temp_Dyno_L.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Temp_Dyno_L.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Temp_Dyno_L.AxisY.Grids.Major.Visible = False
				Me.ChartFX_Temp_Dyno_L.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Temp_Dyno_L.ContextMenus = False
				Me.ChartFX_Temp_Dyno_L.LegendBox.Border = DockBorder.External
				Me.ChartFX_Temp_Dyno_L.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_Temp_Dyno_L As Control = Me.ChartFX_Temp_Dyno_L
				location = New Point(34, 8)
				chartFX_Temp_Dyno_L.Location = location
				Me.ChartFX_Temp_Dyno_L.Name = "ChartFX_Temp_Dyno_L"
				Dim chartFX_Temp_Dyno_L2 As Control = Me.ChartFX_Temp_Dyno_L
				size = New Size(700, 400)
				chartFX_Temp_Dyno_L2.Size = size
				Me.ChartFX_Temp_Dyno_L.TabIndex = 2
				Me.ChartFX_Temp_Dyno_XL.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_Temp_Dyno_XL.AllSeries.MarkerSize = 4S
				Me.ChartFX_Temp_Dyno_XL.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Temp_Dyno_XL.AxisX.Grids.Major.Visible = False
				Me.ChartFX_Temp_Dyno_XL.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Temp_Dyno_XL.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Temp_Dyno_XL.AxisY.Grids.Major.Visible = False
				Me.ChartFX_Temp_Dyno_XL.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Temp_Dyno_XL.ContextMenus = False
				Me.ChartFX_Temp_Dyno_XL.LegendBox.Border = DockBorder.External
				Me.ChartFX_Temp_Dyno_XL.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_Temp_Dyno_XL As Control = Me.ChartFX_Temp_Dyno_XL
				location = New Point(9, 10)
				chartFX_Temp_Dyno_XL.Location = location
				Me.ChartFX_Temp_Dyno_XL.Name = "ChartFX_Temp_Dyno_XL"
				Dim chartFX_Temp_Dyno_XL2 As Control = Me.ChartFX_Temp_Dyno_XL
				size = New Size(696, 377)
				chartFX_Temp_Dyno_XL2.Size = size
				Me.ChartFX_Temp_Dyno_XL.TabIndex = 4
				Me.ChartFX_Temp_Torque_XL.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_Temp_Torque_XL.AllSeries.MarkerSize = 4S
				Me.ChartFX_Temp_Torque_XL.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Temp_Torque_XL.AxisX.Grids.Major.Visible = False
				Me.ChartFX_Temp_Torque_XL.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Temp_Torque_XL.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_Temp_Torque_XL.AxisY.Grids.Major.Visible = False
				Me.ChartFX_Temp_Torque_XL.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_Temp_Torque_XL.LegendBox.Border = DockBorder.External
				Me.ChartFX_Temp_Torque_XL.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_Temp_Torque_XL As Control = Me.ChartFX_Temp_Torque_XL
				location = New Point(8, 8)
				chartFX_Temp_Torque_XL.Location = location
				Me.ChartFX_Temp_Torque_XL.Name = "ChartFX_Temp_Torque_XL"
				Dim chartFX_Temp_Torque_XL2 As Control = Me.ChartFX_Temp_Torque_XL
				size = New Size(696, 400)
				chartFX_Temp_Torque_XL2.Size = size
				Me.ChartFX_Temp_Torque_XL.TabIndex = 5
				Me.chtDoglegs.AllSeries.MarkerShape = MarkerShape.None
				Me.chtDoglegs.AllSeries.MarkerSize = 4S
				Me.chtDoglegs.AxesStyle = AxesStyle.None
				Me.chtDoglegs.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.chtDoglegs.AxisX.Grids.Major.Visible = False
				Me.chtDoglegs.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.chtDoglegs.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.chtDoglegs.AxisY.Grids.Major.Visible = False
				Me.chtDoglegs.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.chtDoglegs.ContextMenus = False
				Me.chtDoglegs.LegendBox.Dock = DockArea.Bottom
				Dim chtDoglegs As Control = Me.chtDoglegs
				location = New Point(234, 43)
				chtDoglegs.Location = location
				Me.chtDoglegs.Name = "chtDoglegs"
				Dim chtDoglegs2 As Control = Me.chtDoglegs
				size = New Size(302, 354)
				chtDoglegs2.Size = size
				Me.chtDoglegs.TabIndex = 8
				Me.chtDoglegs.Visible = False
				Me.chtSurveyPlan.AllSeries.MarkerShape = MarkerShape.None
				Me.chtSurveyPlan.AllSeries.MarkerSize = 4S
				Me.chtSurveyPlan.AxesStyle = AxesStyle.None
				Me.chtSurveyPlan.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.chtSurveyPlan.AxisX.Grids.Major.Visible = False
				Me.chtSurveyPlan.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.chtSurveyPlan.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.chtSurveyPlan.AxisY.Grids.Major.Visible = False
				Me.chtSurveyPlan.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.chtSurveyPlan.ContextMenus = False
				Me.chtSurveyPlan.LegendBox.Dock = DockArea.Bottom
				Dim chtSurveyPlan As Control = Me.chtSurveyPlan
				location = New Point(456, 72)
				chtSurveyPlan.Location = location
				Me.chtSurveyPlan.Name = "chtSurveyPlan"
				Dim chtSurveyPlan2 As Control = Me.chtSurveyPlan
				size = New Size(302, 354)
				chtSurveyPlan2.Size = size
				Me.chtSurveyPlan.TabIndex = 7
				Me.chtSurveyPlan.Visible = False
				Me.chtSurveyNS.AllSeries.MarkerShape = MarkerShape.None
				Me.chtSurveyNS.AllSeries.MarkerSize = 4S
				Me.chtSurveyNS.AxesStyle = AxesStyle.None
				Me.chtSurveyNS.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.chtSurveyNS.AxisX.Grids.Major.Visible = False
				Me.chtSurveyNS.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.chtSurveyNS.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.chtSurveyNS.AxisY.Grids.Major.Visible = False
				Me.chtSurveyNS.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.chtSurveyNS.ContextMenus = False
				Me.chtSurveyNS.LegendBox.Dock = DockArea.Bottom
				Dim chtSurveyNS As Control = Me.chtSurveyNS
				location = New Point(352, 88)
				chtSurveyNS.Location = location
				Me.chtSurveyNS.Name = "chtSurveyNS"
				Dim chtSurveyNS2 As Control = Me.chtSurveyNS
				size = New Size(302, 354)
				chtSurveyNS2.Size = size
				Me.chtSurveyNS.TabIndex = 6
				Me.chtSurveyNS.Visible = False
				Me.chtSurveyEW.AllSeries.MarkerShape = MarkerShape.None
				Me.chtSurveyEW.AllSeries.MarkerSize = 4S
				Me.chtSurveyEW.AxesStyle = AxesStyle.None
				Me.chtSurveyEW.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.chtSurveyEW.AxisX.Grids.Major.Visible = False
				Me.chtSurveyEW.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.chtSurveyEW.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.chtSurveyEW.AxisY.Grids.Major.Visible = False
				Me.chtSurveyEW.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.chtSurveyEW.ContextMenus = False
				Me.chtSurveyEW.LegendBox.Dock = DockArea.Bottom
				Dim chtSurveyEW As Control = Me.chtSurveyEW
				location = New Point(264, 80)
				chtSurveyEW.Location = location
				Me.chtSurveyEW.Name = "chtSurveyEW"
				Dim chtSurveyEW2 As Control = Me.chtSurveyEW
				size = New Size(302, 354)
				chtSurveyEW2.Size = size
				Me.chtSurveyEW.TabIndex = 5
				Me.chtSurveyEW.Visible = False
				Me.chtSideForces.AllSeries.MarkerShape = MarkerShape.None
				Me.chtSideForces.AllSeries.MarkerSize = 4S
				Me.chtSideForces.AxesStyle = AxesStyle.None
				Me.chtSideForces.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.chtSideForces.AxisX.Grids.Major.Visible = False
				Me.chtSideForces.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.chtSideForces.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.chtSideForces.AxisY.Grids.Major.Visible = False
				Me.chtSideForces.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.chtSideForces.ContextMenus = False
				Me.chtSideForces.LegendBox.Dock = DockArea.Bottom
				Dim chtSideForces As Control = Me.chtSideForces
				location = New Point(152, 48)
				chtSideForces.Location = location
				Me.chtSideForces.Name = "chtSideForces"
				Dim chtSideForces2 As Control = Me.chtSideForces
				size = New Size(302, 354)
				chtSideForces2.Size = size
				Me.chtSideForces.TabIndex = 4
				Me.chtSideForces.Visible = False
				Me.chtBucklingTendency.AllSeries.MarkerShape = MarkerShape.None
				Me.chtBucklingTendency.AllSeries.MarkerSize = 4S
				Me.chtBucklingTendency.AxesStyle = AxesStyle.None
				Me.chtBucklingTendency.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.chtBucklingTendency.AxisX.Grids.Major.Visible = False
				Me.chtBucklingTendency.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.chtBucklingTendency.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.chtBucklingTendency.AxisY.Grids.Major.Visible = False
				Me.chtBucklingTendency.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.chtBucklingTendency.ContextMenus = False
				Me.chtBucklingTendency.LegendBox.Dock = DockArea.Bottom
				Dim chtBucklingTendency As Control = Me.chtBucklingTendency
				location = New Point(72, 40)
				chtBucklingTendency.Location = location
				Me.chtBucklingTendency.Name = "chtBucklingTendency"
				Dim chtBucklingTendency2 As Control = Me.chtBucklingTendency
				size = New Size(302, 354)
				chtBucklingTendency2.Size = size
				Me.chtBucklingTendency.TabIndex = 3
				Me.chtBucklingTendency.Visible = False
				Me.chtAxialLoads.AllSeries.MarkerShape = MarkerShape.None
				Me.chtAxialLoads.AllSeries.MarkerSize = 4S
				Me.chtAxialLoads.AxesStyle = AxesStyle.None
				Me.chtAxialLoads.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.chtAxialLoads.AxisX.Grids.Major.Visible = False
				Me.chtAxialLoads.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.chtAxialLoads.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.chtAxialLoads.AxisY.Grids.Major.Visible = False
				Me.chtAxialLoads.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.chtAxialLoads.ContextMenus = False
				Me.chtAxialLoads.LegendBox.Dock = DockArea.Bottom
				Dim chtAxialLoads As Control = Me.chtAxialLoads
				location = New Point(8, 8)
				chtAxialLoads.Location = location
				Me.chtAxialLoads.Name = "chtAxialLoads"
				Dim chtAxialLoads2 As Control = Me.chtAxialLoads
				size = New Size(302, 354)
				chtAxialLoads2.Size = size
				Me.chtAxialLoads.TabIndex = 2
				Me.chtAxialLoads.Visible = False
				Me.G10.AutoSize = True
				Me.G10.Font = New Font("Arial", 6.75F)
				Dim g As Control = Me.G10
				location = New Point(566, 16)
				g.Location = location
				Me.G10.Name = "G10"
				Dim g2 As Control = Me.G10
				size = New Size(22, 12)
				g2.Size = size
				Me.G10.TabIndex = 48
				Me.G10.Text = "G10"
				Me.G10.Visible = False
				Me.G9.AutoSize = True
				Me.G9.Font = New Font("Arial", 6.75F)
				Dim g3 As Control = Me.G9
				location = New Point(512, 16)
				g3.Location = location
				Me.G9.Name = "G9"
				Dim g4 As Control = Me.G9
				size = New Size(17, 12)
				g4.Size = size
				Me.G9.TabIndex = 47
				Me.G9.Text = "G9"
				Me.G9.Visible = False
				Me.G8.AutoSize = True
				Me.G8.Font = New Font("Arial", 6.75F)
				Dim g5 As Control = Me.G8
				location = New Point(459, 16)
				g5.Location = location
				Me.G8.Name = "G8"
				Dim g6 As Control = Me.G8
				size = New Size(17, 12)
				g6.Size = size
				Me.G8.TabIndex = 46
				Me.G8.Text = "G8"
				Me.G8.Visible = False
				Me.G7.AutoSize = True
				Me.G7.Font = New Font("Arial", 6.75F)
				Dim g7 As Control = Me.G7
				location = New Point(405, 16)
				g7.Location = location
				Me.G7.Name = "G7"
				Dim g8 As Control = Me.G7
				size = New Size(17, 12)
				g8.Size = size
				Me.G7.TabIndex = 45
				Me.G7.Text = "G7"
				Me.G7.Visible = False
				Me.G6.AutoSize = True
				Me.G6.Font = New Font("Arial", 6.75F)
				Dim g9 As Control = Me.G6
				location = New Point(351, 16)
				g9.Location = location
				Me.G6.Name = "G6"
				Dim g10 As Control = Me.G6
				size = New Size(17, 12)
				g10.Size = size
				Me.G6.TabIndex = 44
				Me.G6.Text = "G6"
				Me.G6.Visible = False
				Me.G5.AutoSize = True
				Me.G5.Font = New Font("Arial", 6.75F)
				Dim g11 As Control = Me.G5
				location = New Point(297, 16)
				g11.Location = location
				Me.G5.Name = "G5"
				Dim g12 As Control = Me.G5
				size = New Size(17, 12)
				g12.Size = size
				Me.G5.TabIndex = 43
				Me.G5.Text = "G5"
				Me.G5.Visible = False
				Me.G4.AutoSize = True
				Me.G4.Font = New Font("Arial", 6.75F)
				Dim g13 As Control = Me.G4
				location = New Point(246, 16)
				g13.Location = location
				Me.G4.Name = "G4"
				Dim g14 As Control = Me.G4
				size = New Size(17, 12)
				g14.Size = size
				Me.G4.TabIndex = 42
				Me.G4.Text = "G4"
				Me.G4.Visible = False
				Me.G3.AutoSize = True
				Me.G3.Font = New Font("Arial", 6.75F)
				Dim g15 As Control = Me.G3
				location = New Point(194, 16)
				g15.Location = location
				Me.G3.Name = "G3"
				Dim g16 As Control = Me.G3
				size = New Size(17, 12)
				g16.Size = size
				Me.G3.TabIndex = 41
				Me.G3.Text = "G3"
				Me.G3.Visible = False
				Me.G2.AutoSize = True
				Me.G2.Font = New Font("Arial", 6.75F)
				Dim g17 As Control = Me.G2
				location = New Point(142, 16)
				g17.Location = location
				Me.G2.Name = "G2"
				Dim g18 As Control = Me.G2
				size = New Size(17, 12)
				g18.Size = size
				Me.G2.TabIndex = 40
				Me.G2.Text = "G2"
				Me.G2.Visible = False
				Me.G1.AutoSize = True
				Me.G1.Font = New Font("Arial", 6.75F)
				Dim g19 As Control = Me.G1
				location = New Point(91, 16)
				g19.Location = location
				Me.G1.Name = "G1"
				Dim g20 As Control = Me.G1
				size = New Size(17, 12)
				g20.Size = size
				Me.G1.TabIndex = 39
				Me.G1.Text = "G1"
				Me.G1.Visible = False
				Me.T10.AutoSize = True
				Me.T10.Font = New Font("Arial", 6.75F)
				Dim t As Control = Me.T10
				location = New Point(566, 3)
				t.Location = location
				Me.T10.Name = "T10"
				Dim t2 As Control = Me.T10
				size = New Size(20, 12)
				t2.Size = size
				Me.T10.TabIndex = 36
				Me.T10.Text = "T10"
				Me.T10.Visible = False
				Me.T9.AutoSize = True
				Me.T9.Font = New Font("Arial", 6.75F)
				Dim t3 As Control = Me.T9
				location = New Point(512, 3)
				t3.Location = location
				Me.T9.Name = "T9"
				Dim t4 As Control = Me.T9
				size = New Size(15, 12)
				t4.Size = size
				Me.T9.TabIndex = 35
				Me.T9.Text = "T9"
				Me.T9.Visible = False
				Me.T8.AutoSize = True
				Me.T8.Font = New Font("Arial", 6.75F)
				Dim t5 As Control = Me.T8
				location = New Point(459, 3)
				t5.Location = location
				Me.T8.Name = "T8"
				Dim t6 As Control = Me.T8
				size = New Size(15, 12)
				t6.Size = size
				Me.T8.TabIndex = 34
				Me.T8.Text = "T8"
				Me.T8.Visible = False
				Me.T7.AutoSize = True
				Me.T7.Font = New Font("Arial", 6.75F)
				Dim t7 As Control = Me.T7
				location = New Point(405, 3)
				t7.Location = location
				Me.T7.Name = "T7"
				Dim t8 As Control = Me.T7
				size = New Size(15, 12)
				t8.Size = size
				Me.T7.TabIndex = 33
				Me.T7.Text = "T7"
				Me.T7.Visible = False
				Me.T6.AutoSize = True
				Me.T6.Font = New Font("Arial", 6.75F)
				Dim t9 As Control = Me.T6
				location = New Point(351, 3)
				t9.Location = location
				Me.T6.Name = "T6"
				Dim t10 As Control = Me.T6
				size = New Size(15, 12)
				t10.Size = size
				Me.T6.TabIndex = 32
				Me.T6.Text = "T6"
				Me.T6.Visible = False
				Me.T5.AutoSize = True
				Me.T5.Font = New Font("Arial", 6.75F)
				Dim t11 As Control = Me.T5
				location = New Point(297, 3)
				t11.Location = location
				Me.T5.Name = "T5"
				Dim t12 As Control = Me.T5
				size = New Size(15, 12)
				t12.Size = size
				Me.T5.TabIndex = 31
				Me.T5.Text = "T5"
				Me.T5.Visible = False
				Me.T4.AutoSize = True
				Me.T4.Font = New Font("Arial", 6.75F)
				Dim t13 As Control = Me.T4
				location = New Point(246, 3)
				t13.Location = location
				Me.T4.Name = "T4"
				Dim t14 As Control = Me.T4
				size = New Size(15, 12)
				t14.Size = size
				Me.T4.TabIndex = 30
				Me.T4.Text = "T4"
				Me.T4.Visible = False
				Me.T3.AutoSize = True
				Me.T3.Font = New Font("Arial", 6.75F)
				Dim t15 As Control = Me.T3
				location = New Point(194, 3)
				t15.Location = location
				Me.T3.Name = "T3"
				Dim t16 As Control = Me.T3
				size = New Size(15, 12)
				t16.Size = size
				Me.T3.TabIndex = 29
				Me.T3.Text = "T3"
				Me.T3.Visible = False
				Me.T2.AutoSize = True
				Me.T2.Font = New Font("Arial", 6.75F)
				Dim t17 As Control = Me.T2
				location = New Point(142, 3)
				t17.Location = location
				Me.T2.Name = "T2"
				Dim t18 As Control = Me.T2
				size = New Size(15, 12)
				t18.Size = size
				Me.T2.TabIndex = 28
				Me.T2.Text = "T2"
				Me.T2.Visible = False
				Me.T1.AutoSize = True
				Me.T1.Font = New Font("Arial", 6.75F)
				Dim t19 As Control = Me.T1
				location = New Point(91, 3)
				t19.Location = location
				Me.T1.Name = "T1"
				Dim t20 As Control = Me.T1
				size = New Size(15, 12)
				t20.Size = size
				Me.T1.TabIndex = 27
				Me.T1.Text = "T1"
				Me.T1.Visible = False
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
				Me.TChart1.BackColor = Color.Transparent
				Me.TChart1.BackgroundImageLayout = ImageLayout.None
				Me.TChart1.Cursor = Cursors.[Default]
				Me.TChart1.Dock = DockStyle.Fill
				Me.TChart1.Header.Brush.Gradient.MiddleColor = Color.FromArgb(255, 255, 255)
				Me.TChart1.Header.Brush.Gradient.StartColor = Color.FromArgb(0, 0, 255)
				Me.TChart1.Header.Brush.Gradient.UseMiddle = True
				Me.TChart1.Header.Brush.Gradient.Visible = True
				Me.TChart1.Header.Font.Brush.Color = Color.Black
				Me.TChart1.Header.Font.Shadow.Visible = True
				Me.TChart1.Header.Font.Size = 9
				Me.TChart1.Header.Font.SizeFloat = 9F
				Me.TChart1.Header.Lines = New String() { "" }
				Me.TChart1.Header.Shadow.Visible = True
				Me.TChart1.Legend.Alignment = LegendAlignments.Bottom
				Me.TChart1.Legend.Font.Size = 7
				Me.TChart1.Legend.Font.SizeFloat = 7F
				Me.TChart1.Legend.LegendStyle = LegendStyles.Series
				Me.TChart1.Legend.MaxNumRows = 1
				Me.TChart1.Legend.Shadow.Visible = False
				Dim tchart As Control = Me.TChart1
				location = New Point(0, 0)
				tchart.Location = location
				Me.TChart1.Name = "TChart1"
				Me.TChart1.Panel.Bevel.Outer = BevelStyles.None
				Me.TChart1.Panel.Brush.Color = Color.FromArgb(0, 255, 255, 255)
				Me.TChart1.Panel.Brush.Gradient.MiddleColor = Color.FromArgb(255, 255, 255)
				Me.TChart1.Panel.Brush.Gradient.StartColor = Color.FromArgb(224, 224, 224)
				Me.TChart1.Panel.Shadow.Brush.Color = Color.FromArgb(255, 255, 255)
				Me.TChart1.Panel.Shadow.Visible = True
				Dim tchart2 As Control = Me.TChart1
				size = New Size(800, 476)
				tchart2.Size = size
				Me.TChart1.TabIndex = 11
				Me.point3DSeries1.Color = Color.FromArgb(68, 102, 163)
				Me.point3DSeries1.ColorEach = False
				Me.point3DSeries1.DepthSize = 7.0
				Me.point3DSeries1.LinePen.Color = Color.FromArgb(254, 0, 0, 255)
				Me.point3DSeries1.LinePen.EndCap = LineCap.Round
				Me.point3DSeries1.LinePen.Width = 2
				Me.point3DSeries1.Marks.Callout.ArrowHead = ArrowHeadStyles.None
				Me.point3DSeries1.Marks.Callout.ArrowHeadSize = 8
				Me.point3DSeries1.Marks.Callout.Brush.Color = Color.Black
				Me.point3DSeries1.Marks.Callout.Distance = 0
				Me.point3DSeries1.Marks.Callout.Draw3D = False
				Me.point3DSeries1.Marks.Callout.Length = 10
				Me.point3DSeries1.Marks.Callout.Series = Me.point3DSeries1
				Me.point3DSeries1.Marks.Callout.Style = PointerStyles.Rectangle
				Me.point3DSeries1.Marks.Callout.Visible = False
				Me.point3DSeries1.Marks.Series = Me.point3DSeries1
				Me.point3DSeries1.Marks.Shadow.Visible = False
				Me.point3DSeries1.Marks.ShapeStyle = TextShapeStyle.RoundRectangle
				Me.point3DSeries1.Marks.Style = MarksStyles.Value
				Me.point3DSeries1.Pointer.Brush.Gradient.StartColor = Color.FromArgb(68, 102, 163)
				Me.point3DSeries1.Pointer.Dark3D = False
				Me.point3DSeries1.Pointer.Draw3D = False
				Me.point3DSeries1.Pointer.HorizSize = 1
				Me.point3DSeries1.Pointer.InflateMargins = False
				Me.point3DSeries1.Pointer.Pen.Color = Color.FromArgb(41, 61, 98)
				Me.point3DSeries1.Pointer.Series = Me.point3DSeries1
				Me.point3DSeries1.Pointer.Style = PointerStyles.[Nothing]
				Me.point3DSeries1.Pointer.VertSize = 1
				Me.point3DSeries1.ShowInLegend = False
				Me.point3DSeries1.Title = "point3D1"
				Me.point3DSeries1.XValues.DataMember = "X"
				Me.point3DSeries1.YValues.DataMember = "Y"
				Me.point3DSeries1.ZValues.DataMember = "Z"
				Me.point3DSeries2.Color = Color.Blue
				Me.point3DSeries2.ColorEach = False
				Me.point3DSeries2.LinePen.Color = Color.White
				Me.point3DSeries2.LinePen.EndCap = LineCap.Round
				Me.point3DSeries2.LinePen.Style = DashStyle.Dot
				Me.point3DSeries2.Marks.Callout.ArrowHead = ArrowHeadStyles.None
				Me.point3DSeries2.Marks.Callout.ArrowHeadSize = 8
				Me.point3DSeries2.Marks.Callout.Brush.Color = Color.Black
				Me.point3DSeries2.Marks.Callout.Distance = 0
				Me.point3DSeries2.Marks.Callout.Draw3D = False
				Me.point3DSeries2.Marks.Callout.Length = 10
				Me.point3DSeries2.Marks.Callout.Series = Me.point3DSeries2
				Me.point3DSeries2.Marks.Callout.Style = PointerStyles.Rectangle
				Me.point3DSeries2.Marks.Callout.Visible = False
				Me.point3DSeries2.Marks.Series = Me.point3DSeries2
				Me.point3DSeries2.Pointer.Brush.Gradient.StartColor = Color.FromArgb(243, 156, 53)
				Me.point3DSeries2.Pointer.Pen.Color = Color.FromArgb(146, 94, 32)
				Me.point3DSeries2.Pointer.Series = Me.point3DSeries2
				Me.point3DSeries2.Pointer.Style = PointerStyles.Circle
				Me.point3DSeries2.Title = "Rod Guides"
				Me.point3DSeries2.XValues.DataMember = "X"
				Me.point3DSeries2.YValues.DataMember = "Y"
				Me.point3DSeries2.ZValues.DataMember = "Z"
				Me.MarksTip1.Style = MarksStyles.XY
				Me.ChartFX_LookingNorth.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_LookingNorth.AllSeries.MarkerSize = 4S
				Me.ChartFX_LookingNorth.AxesStyle = AxesStyle.None
				Me.ChartFX_LookingNorth.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_LookingNorth.AxisX.Grids.Major.Visible = False
				Me.ChartFX_LookingNorth.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_LookingNorth.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_LookingNorth.AxisY.Grids.Major.Visible = False
				Me.ChartFX_LookingNorth.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_LookingNorth.ContextMenus = False
				Me.ChartFX_LookingNorth.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_LookingNorth As Control = Me.ChartFX_LookingNorth
				location = New Point(31, 16)
				chartFX_LookingNorth.Location = location
				Me.ChartFX_LookingNorth.Name = "ChartFX_LookingNorth"
				Dim chartFX_LookingNorth2 As Control = Me.ChartFX_LookingNorth
				size = New Size(685, 381)
				chartFX_LookingNorth2.Size = size
				Me.ChartFX_LookingNorth.TabIndex = 12
				Me.ChartFX_LookingNorth.Visible = False
				Me.ChartFX_SideLoading.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_SideLoading.AllSeries.MarkerSize = 4S
				Me.ChartFX_SideLoading.AxesStyle = AxesStyle.None
				Me.ChartFX_SideLoading.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_SideLoading.AxisX.Grids.Major.Visible = False
				Me.ChartFX_SideLoading.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_SideLoading.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_SideLoading.AxisY.Grids.Major.Visible = False
				Me.ChartFX_SideLoading.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_SideLoading.ContextMenus = False
				Me.ChartFX_SideLoading.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_SideLoading As Control = Me.ChartFX_SideLoading
				location = New Point(24, 16)
				chartFX_SideLoading.Location = location
				Me.ChartFX_SideLoading.Name = "ChartFX_SideLoading"
				Dim chartFX_SideLoading2 As Control = Me.ChartFX_SideLoading
				size = New Size(692, 384)
				chartFX_SideLoading2.Size = size
				Me.ChartFX_SideLoading.TabIndex = 11
				Me.ChartFX_SideLoading.Visible = False
				Me.ChartFX_BucklingTendency.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_BucklingTendency.AllSeries.MarkerSize = 4S
				Me.ChartFX_BucklingTendency.AxesStyle = AxesStyle.None
				Me.ChartFX_BucklingTendency.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_BucklingTendency.AxisX.Grids.Major.Visible = False
				Me.ChartFX_BucklingTendency.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_BucklingTendency.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_BucklingTendency.AxisY.Grids.Major.Visible = False
				Me.ChartFX_BucklingTendency.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_BucklingTendency.ContextMenus = False
				Me.ChartFX_BucklingTendency.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_BucklingTendency As Control = Me.ChartFX_BucklingTendency
				location = New Point(31, 16)
				chartFX_BucklingTendency.Location = location
				Me.ChartFX_BucklingTendency.Name = "ChartFX_BucklingTendency"
				Dim chartFX_BucklingTendency2 As Control = Me.ChartFX_BucklingTendency
				size = New Size(685, 384)
				chartFX_BucklingTendency2.Size = size
				Me.ChartFX_BucklingTendency.TabIndex = 10
				Me.ChartFX_BucklingTendency.Visible = False
				Me.ChartFX_AxialLoads.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_AxialLoads.AllSeries.MarkerSize = 4S
				Me.ChartFX_AxialLoads.AxesStyle = AxesStyle.None
				Me.ChartFX_AxialLoads.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_AxialLoads.AxisX.Grids.Major.Visible = False
				Me.ChartFX_AxialLoads.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_AxialLoads.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_AxialLoads.AxisY.Grids.Major.Visible = False
				Me.ChartFX_AxialLoads.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_AxialLoads.ContextMenus = False
				Me.ChartFX_AxialLoads.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_AxialLoads As Control = Me.ChartFX_AxialLoads
				location = New Point(31, 16)
				chartFX_AxialLoads.Location = location
				Me.ChartFX_AxialLoads.Name = "ChartFX_AxialLoads"
				Dim chartFX_AxialLoads2 As Control = Me.ChartFX_AxialLoads
				size = New Size(685, 384)
				chartFX_AxialLoads2.Size = size
				Me.ChartFX_AxialLoads.TabIndex = 9
				Me.ChartFX_AxialLoads.Visible = False
				Me.ChartFX_DoglegSeverity.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_DoglegSeverity.AllSeries.MarkerSize = 4S
				Me.ChartFX_DoglegSeverity.AxesStyle = AxesStyle.None
				Me.ChartFX_DoglegSeverity.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_DoglegSeverity.AxisX.Grids.Major.Visible = False
				Me.ChartFX_DoglegSeverity.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_DoglegSeverity.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_DoglegSeverity.AxisY.Grids.Major.Visible = False
				Me.ChartFX_DoglegSeverity.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_DoglegSeverity.ContextMenus = False
				Me.ChartFX_DoglegSeverity.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_DoglegSeverity As Control = Me.ChartFX_DoglegSeverity
				location = New Point(31, 16)
				chartFX_DoglegSeverity.Location = location
				Me.ChartFX_DoglegSeverity.Name = "ChartFX_DoglegSeverity"
				Dim chartFX_DoglegSeverity2 As Control = Me.ChartFX_DoglegSeverity
				size = New Size(685, 384)
				chartFX_DoglegSeverity2.Size = size
				Me.ChartFX_DoglegSeverity.TabIndex = 15
				Me.ChartFX_DoglegSeverity.Visible = False
				Me.ChartFX_LookingDown.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_LookingDown.AllSeries.MarkerSize = 4S
				Me.ChartFX_LookingDown.AxesStyle = AxesStyle.None
				Me.ChartFX_LookingDown.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_LookingDown.AxisX.Grids.Major.Visible = False
				Me.ChartFX_LookingDown.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_LookingDown.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_LookingDown.AxisY.Grids.Major.Visible = False
				Me.ChartFX_LookingDown.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_LookingDown.ContextMenus = False
				Me.ChartFX_LookingDown.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_LookingDown As Control = Me.ChartFX_LookingDown
				location = New Point(16, 16)
				chartFX_LookingDown.Location = location
				Me.ChartFX_LookingDown.Name = "ChartFX_LookingDown"
				Dim chartFX_LookingDown2 As Control = Me.ChartFX_LookingDown
				size = New Size(700, 384)
				chartFX_LookingDown2.Size = size
				Me.ChartFX_LookingDown.TabIndex = 14
				Me.ChartFX_LookingDown.Visible = False
				Me.ChartFX_LookingEast.AllSeries.MarkerShape = MarkerShape.None
				Me.ChartFX_LookingEast.AllSeries.MarkerSize = 4S
				Me.ChartFX_LookingEast.AxesStyle = AxesStyle.None
				Me.ChartFX_LookingEast.AxisX.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_LookingEast.AxisX.Grids.Major.Visible = False
				Me.ChartFX_LookingEast.AxisX.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_LookingEast.AxisY.Grids.Major.TickMark = TickMark.Cross
				Me.ChartFX_LookingEast.AxisY.Grids.Major.Visible = False
				Me.ChartFX_LookingEast.AxisY.Grids.Minor.TickMark = TickMark.None
				Me.ChartFX_LookingEast.ContextMenus = False
				Me.ChartFX_LookingEast.LegendBox.Dock = DockArea.Bottom
				Dim chartFX_LookingEast As Control = Me.ChartFX_LookingEast
				location = New Point(21, 18)
				chartFX_LookingEast.Location = location
				Me.ChartFX_LookingEast.Name = "ChartFX_LookingEast"
				Me.ChartFX_LookingEast.PlotAreaColor = Color.Transparent
				Dim chartFX_LookingEast2 As Control = Me.ChartFX_LookingEast
				size = New Size(706, 381)
				chartFX_LookingEast2.Size = size
				Me.ChartFX_LookingEast.TabIndex = 28
				Me.ChartFX_LookingEast.Visible = False
				Me.point3DSeries1_report.Color = Color.FromArgb(68, 102, 163)
				Me.point3DSeries1_report.ColorEach = False
				Me.point3DSeries1_report.DepthSize = 7.0
				Me.point3DSeries1_report.LinePen.Color = Color.FromArgb(254, 0, 0, 255)
				Me.point3DSeries1_report.LinePen.EndCap = LineCap.Round
				Me.point3DSeries1_report.LinePen.Width = 3
				Me.point3DSeries1_report.Marks.Callout.ArrowHead = ArrowHeadStyles.None
				Me.point3DSeries1_report.Marks.Callout.ArrowHeadSize = 8
				Me.point3DSeries1_report.Marks.Callout.Brush.Color = Color.Black
				Me.point3DSeries1_report.Marks.Callout.Distance = 0
				Me.point3DSeries1_report.Marks.Callout.Draw3D = False
				Me.point3DSeries1_report.Marks.Callout.Length = 10
				Me.point3DSeries1_report.Marks.Callout.Series = Me.point3DSeries1_report
				Me.point3DSeries1_report.Marks.Callout.Style = PointerStyles.Rectangle
				Me.point3DSeries1_report.Marks.Callout.Visible = False
				Me.point3DSeries1_report.Marks.Series = Me.point3DSeries1_report
				Me.point3DSeries1_report.Marks.Shadow.Visible = False
				Me.point3DSeries1_report.Marks.ShapeStyle = TextShapeStyle.RoundRectangle
				Me.point3DSeries1_report.Marks.Style = MarksStyles.Value
				Me.point3DSeries1_report.Pointer.Brush.Gradient.StartColor = Color.FromArgb(68, 102, 163)
				Me.point3DSeries1_report.Pointer.Dark3D = False
				Me.point3DSeries1_report.Pointer.Draw3D = False
				Me.point3DSeries1_report.Pointer.HorizSize = 1
				Me.point3DSeries1_report.Pointer.InflateMargins = False
				Me.point3DSeries1_report.Pointer.Pen.Color = Color.FromArgb(41, 61, 98)
				Me.point3DSeries1_report.Pointer.Series = Me.point3DSeries1_report
				Me.point3DSeries1_report.Pointer.Style = PointerStyles.[Nothing]
				Me.point3DSeries1_report.Pointer.VertSize = 1
				Me.point3DSeries1_report.ShowInLegend = False
				Me.point3DSeries1_report.Title = "point3D1"
				Me.point3DSeries1_report.XValues.DataMember = "X"
				Me.point3DSeries1_report.YValues.DataMember = "Y"
				Me.point3DSeries1_report.ZValues.DataMember = "Z"
				Me.point3DSeries2_report.Color = Color.FromArgb(0, 0, 192)
				Me.point3DSeries2_report.ColorEach = False
				Me.point3DSeries2_report.LinePen.Color = Color.White
				Me.point3DSeries2_report.LinePen.EndCap = LineCap.Round
				Me.point3DSeries2_report.LinePen.Style = DashStyle.Dot
				Me.point3DSeries2_report.Marks.Callout.ArrowHead = ArrowHeadStyles.None
				Me.point3DSeries2_report.Marks.Callout.ArrowHeadSize = 8
				Me.point3DSeries2_report.Marks.Callout.Brush.Color = Color.Black
				Me.point3DSeries2_report.Marks.Callout.Distance = 0
				Me.point3DSeries2_report.Marks.Callout.Draw3D = False
				Me.point3DSeries2_report.Marks.Callout.Length = 10
				Me.point3DSeries2_report.Marks.Callout.Series = Me.point3DSeries2_report
				Me.point3DSeries2_report.Marks.Callout.Style = PointerStyles.Rectangle
				Me.point3DSeries2_report.Marks.Callout.Visible = False
				Me.point3DSeries2_report.Marks.Series = Me.point3DSeries2_report
				Me.point3DSeries2_report.Pointer.Brush.Gradient.StartColor = Color.FromArgb(243, 156, 53)
				Me.point3DSeries2_report.Pointer.Pen.Color = Color.FromArgb(146, 94, 32)
				Me.point3DSeries2_report.Pointer.Series = Me.point3DSeries2_report
				Me.point3DSeries2_report.Pointer.Style = PointerStyles.Circle
				Me.point3DSeries2_report.Title = "Rod Guides"
				Me.point3DSeries2_report.XValues.DataMember = "X"
				Me.point3DSeries2_report.YValues.DataMember = "Y"
				Me.point3DSeries2_report.ZValues.DataMember = "Z"
				Me.timAnimate.Interval = 500
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
				Me.TChart1_Report.BackColor = Color.Transparent
				Me.TChart1_Report.Cursor = Cursors.[Default]
				Me.TChart1_Report.Dock = DockStyle.Fill
				Me.TChart1_Report.Header.Font.Brush.Color = Color.Black
				Me.TChart1_Report.Header.Font.Size = 9
				Me.TChart1_Report.Header.Font.SizeFloat = 9F
				Me.TChart1_Report.Header.Lines = New String() { "Deviation Survey Plot", "" }
				Me.TChart1_Report.Legend.Alignment = LegendAlignments.Bottom
				Me.TChart1_Report.Legend.Font.Size = 7
				Me.TChart1_Report.Legend.Font.SizeFloat = 7F
				Dim tchart1_Report As Control = Me.TChart1_Report
				location = New Point(0, 0)
				tchart1_Report.Location = location
				Dim tchart1_Report2 As Control = Me.TChart1_Report
				Dim padding As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(1)
				tchart1_Report2.Margin = padding
				Me.TChart1_Report.Name = "TChart1_Report"
				Dim tchart1_Report3 As Control = Me.TChart1_Report
				padding = New System.Windows.Forms.Padding(1)
				tchart1_Report3.Padding = padding
				Me.TChart1_Report.Page.AutoScale = True
				Me.TChart1_Report.Panel.Brush.Color = Color.FromArgb(0, 212, 208, 200)
				Me.TChart1_Report.Panel.Brush.Gradient.MiddleColor = Color.FromArgb(255, 255, 255)
				Me.TChart1_Report.Panel.Brush.Gradient.StartColor = Color.FromArgb(224, 224, 224)
				Me.TChart1_Report.Panel.MarginBottom = 1.0
				Me.TChart1_Report.Panel.MarginLeft = 1.0
				Me.TChart1_Report.Panel.MarginRight = 1.0
				Me.TChart1_Report.Panel.MarginTop = 1.0
				Dim tchart1_Report4 As Control = Me.TChart1_Report
				size = New Size(800, 800)
				tchart1_Report4.Size = size
				Me.TChart1_Report.SubHeader.AdjustFrame = False
				Me.TChart1_Report.SubHeader.AutoSize = False
				Me.TChart1_Report.TabIndex = 11
				Me.TChart1_Report.Visible = False
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnImplement_VisibleChanged(sender As Object, e As EventArgs)
			If Not RSWIN_DESC.rst.bImplementedDesign Then
				Me.btnImplement.Enabled = Me.btnImplement.Visible
				Return
			End If
			Me.btnImplement.Enabled = False
		End Sub

		Private Sub TChart1_MouseDown(sender As Object, e As MouseEventArgs)
			Try
				Application.DoEvents()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub TChart1_Move(sender As Object, e As EventArgs)
			Try
				Application.DoEvents()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub Results_SizeChanged(sender As Object, e As EventArgs)
			Try
				If(Me.WindowState = FormWindowState.Minimized Or Me.WindowState = FormWindowState.Maximized Or Me.WindowState = FormWindowState.Normal) And Me.bViewing3DPlot Then
					Me.TChart1.Visible = False
					Me.iGetPointStyle1 = 0
					Me.iGetPointStyle1_report = 0
					Me.iGetPointStyle2 = 0
					Me.iGetPointStyle2_report = 0
					Me.m_bAfterPump1 = False
					Me.m_bAfterPump2 = False
					Me.m_bAfterPump1_report = False
					Me.m_bAfterPump2_report = False
					Me.ShowDevPlot(8)
					Me.TChart1.Visible = True
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub Results_Paint(sender As Object, e As PaintEventArgs)
			Try
				If(Me.WindowState = FormWindowState.Minimized Or Me.WindowState = FormWindowState.Maximized Or Me.WindowState = FormWindowState.Normal) And Me.bViewing3DPlot Then
					Me.TChart1.Visible = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub TChart1_SizeChanged(sender As Object, e As EventArgs)
			Try
				If(Me.WindowState = FormWindowState.Minimized Or Me.WindowState = FormWindowState.Maximized Or Me.WindowState = FormWindowState.Normal) And Me.bViewing3DPlot Then
					Me.TChart1.Visible = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function RoundYMin(fOldLength As Single) As Single
			' The following expression was wrapped in a checked-statement
			Dim result As Single
			Try
				Dim num As Integer = Conversions.ToInteger(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 200, 60))
				Dim num2 As Integer = CInt(Math.Round(CDbl((Math.Abs(fOldLength) / CSng(num))) + 0.5))
				Dim num3 As Single = CSng((num2 * num * -1))
				result = num3
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private RandomClass As Random

		Private mdsDeviationProfile_Output As DataSet

		Private fMult As Single

		Private fSideLoadYMin As Single

		Private bUseSeries2 As Boolean

		Private bViewing3DPlot As Boolean

		Private m_iCurrentRptOpt As Integer

		Private bCommanderClicked As Boolean

		Private m_bAfterPump1 As Boolean

		Private m_bAfterPump2 As Boolean

		Private m_bAfterPump1_report As Boolean

		Private m_bAfterPump2_report As Boolean

		Private m_bReplot As Boolean

		Private m_iStep As Integer

		Private Const RPT_DYNOPLOT As Integer = 0

		Private Const RPT_TORQUEPLOT As Integer = 1

		Private Const RPT_IPRPLOT As Integer = 2

		Private Const RPT_EXPERTANALYSIS As Integer = 2

		Private Const RPT_SUMMARY As Integer = 3

		Private Const RPT_TUBING As Integer = 4

		Private Const RPT_RODSTRING As Integer = 5

		Private Const RPT_PUTORQUE As Integer = 6

		Private Const RPT_ENERGY As Integer = 7

		Private Const RPT_COST As Integer = 8

		Private Const RPT_IPRDATA As Integer = 9

		Private Const RPT_MAXPAGES As Integer = 9

		Private MyParentFrm As RODSTAR

		Private DynoCardAnnotx As Annotations

		Private SurfCircle As AnnotationCircle

		Private PumpCircle As AnnotationCircle

		Private SetLinesX As Single(,)

		Private SetLinesY As Single(,)

		Private SeriesToMove As Integer

		Private mnuDPlot As Object()

		<AccessedThroughProperty("IPRPlot")>
		Private _IPRPlot As IPRPlot

		<AccessedThroughProperty("dlgImplementGuideChanges")>
		Private _dlgImplementGuideChanges As dlgImplementGuideChanges

		Private rptDynoAndTorqueChart As rptDynoAndTorqueChart

		Private rptCalcResults As rptCalcResults

		Private rptResultsInputs As rptResultsInputs

		Private rptResultsOutputs As rptResultsOutputs

		Public rptRecommendedGuideReport As Object

		Private rptDeviationSurvey As rptDeviationSurvey

		Private m_rptCostAnalysis As rptCostAnalysis

		Private m_rptCostAnalysis_D As rptCostAnalysis_D

		Private rptDeviationProfile As rptDeviationProfile

		Private rptDevSurvey3DPlot As rptDevSurvey3DPlot

		Private rptExpertSummary As rptExpertSummary

		Private rptCoverPage As rptCoverPage

		Private rptOrderPage As rptOrderForm

		Private bDogLegsCalculated As Boolean

		Private rptCalcResults_Summary As rptCalcResults_Summary

		Private rptDynoAndTorqueChart_Landscape As rptDynoAndTorqueChart_Landscape

		Private bForward As Boolean

		Private bPlay As Boolean

		Private bTogglePlay As Boolean

		Private bFormLoaded As Boolean

		Private LastPanel As System.Windows.Forms.Panel

		Private sPanelType As String

		Private iInterval As Integer

		Private nStep As Integer

		Private nSkip As Integer

		Private nInitialSkip As Integer

		Private IntervalConst As Integer

		Private nGuideLines As Integer

		Private nDevSurveyLines As Integer

		Private myKeyValueHT As Hashtable

		Private fMaxForCharts As Single

		Private m_iDevChart As Integer

		Private bImplementOn As Boolean

		Private m_Animate_Ntsteps As Short

		Private m_Animate_SurfPos As Single()

		Private m_Animate_SurfLoad As Single()

		Private m_Animate_PumpPos As Single()

		Private m_Animate_PumpLoad As Single()

		Private sOutputSetup As Object

		Private sFileSaveError As Object

		Private sMeasuredCard As Object

		Private sPermissibleLoadDiagram As Object

		Private sDownholeCard As Object

		Private sSurfaceCard As Object

		Private sDynamometerCards As Object

		Private sGearboxTorquePlots As Object

		Private sExisting As Object

		Private sOverlapsMinEnergy As Object

		Private sUpstroke As Object

		Private sDownstroke As Object

		Private sBalanced As Object

		Private sBalMinEnergy As Object

		Private sBalMinTorque As Object

		Private sCrankHoleDegrees As Object

		Private sPosition As Object

		Private sLoad As Object

		Private sGearboxRating As Object

		Private iAnimationCycle As Integer

		Private Const csKEY_ENTRYNUMBER As String = "EntryNumber"

		Private Const csKEY_AZIMUTH As String = "Azimuth"

		Private Const csKEY_DEPTH As String = "Depth"

		Private Const csKEY_DOGLEG As String = "Dogleg"

		Private Const csKEY_INCLINATION As String = "Inclination"

		Private Const csKEY_TVDEPTH As String = "TVDepth"

		Private Const csKEY_NORTHSOUTH As String = "NorthSouth"

		Private Const csKEY_EASTWEST As String = "EastWest"

		<AccessedThroughProperty("commander1")>
		Private _commander1 As Commander

		<AccessedThroughProperty("ChartFX_LookingEast")>
		Private _ChartFX_LookingEast As ChartFX.WinForms.Chart

		<AccessedThroughProperty("pnlLegend")>
		Private _pnlLegend As System.Windows.Forms.Panel

		<AccessedThroughProperty("point3DSeries2")>
		Private _point3DSeries2 As Points3D

		<AccessedThroughProperty("point3DSeries2_report")>
		Private _point3DSeries2_report As Points3D

		<AccessedThroughProperty("optPrevDevChart")>
		Private _optPrevDevChart As System.Windows.Forms.Button

		<AccessedThroughProperty("optNextDevChart")>
		Private _optNextDevChart As System.Windows.Forms.Button

		<AccessedThroughProperty("lblPoint")>
		Private _lblPoint As Label

		<AccessedThroughProperty("pnl3DReport")>
		Private _pnl3DReport As System.Windows.Forms.Panel

		<AccessedThroughProperty("TChart1_Report")>
		Private _TChart1_Report As TChart

		<AccessedThroughProperty("VScrollBar1")>
		Private _VScrollBar1 As VScrollBar

		Private m_TVDepth As Double()

		<AccessedThroughProperty("btnImplement")>
		Private _btnImplement As RadioButton

		Private m_MeasDepth As Double()

		<AccessedThroughProperty("pnlLegend2")>
		Private _pnlLegend2 As System.Windows.Forms.Panel

		<AccessedThroughProperty("lblNumGuidesPerRod2")>
		Private _lblNumGuidesPerRod2 As Label

		<AccessedThroughProperty("lblDiameters2")>
		Private _lblDiameters2 As Label

		<AccessedThroughProperty("G20")>
		Private _G20 As Label

		<AccessedThroughProperty("G19")>
		Private _G19 As Label

		<AccessedThroughProperty("G18")>
		Private _G18 As Label

		<AccessedThroughProperty("G17")>
		Private _G17 As Label

		<AccessedThroughProperty("G16")>
		Private _G16 As Label

		<AccessedThroughProperty("G15")>
		Private _G15 As Label

		<AccessedThroughProperty("G14")>
		Private _G14 As Label

		<AccessedThroughProperty("G13")>
		Private _G13 As Label

		<AccessedThroughProperty("G12")>
		Private _G12 As Label

		<AccessedThroughProperty("G11")>
		Private _G11 As Label

		<AccessedThroughProperty("lblNumGuidesPerRod")>
		Private _lblNumGuidesPerRod As Label

		<AccessedThroughProperty("G10")>
		Private _G10 As Label

		<AccessedThroughProperty("G9")>
		Private _G9 As Label

		<AccessedThroughProperty("G8")>
		Private _G8 As Label

		<AccessedThroughProperty("G7")>
		Private _G7 As Label

		<AccessedThroughProperty("G6")>
		Private _G6 As Label

		<AccessedThroughProperty("G5")>
		Private _G5 As Label

		<AccessedThroughProperty("G4")>
		Private _G4 As Label

		<AccessedThroughProperty("G3")>
		Private _G3 As Label

		<AccessedThroughProperty("G2")>
		Private _G2 As Label

		<AccessedThroughProperty("G1")>
		Private _G1 As Label

		<AccessedThroughProperty("lblDiameters")>
		Private _lblDiameters As Label

		<AccessedThroughProperty("T20")>
		Private _T20 As Label

		<AccessedThroughProperty("T19")>
		Private _T19 As Label

		<AccessedThroughProperty("T18")>
		Private _T18 As Label

		<AccessedThroughProperty("T17")>
		Private _T17 As Label

		<AccessedThroughProperty("T16")>
		Private _T16 As Label

		<AccessedThroughProperty("T15")>
		Private _T15 As Label

		<AccessedThroughProperty("T14")>
		Private _T14 As Label

		<AccessedThroughProperty("T13")>
		Private _T13 As Label

		<AccessedThroughProperty("T12")>
		Private _T12 As Label

		<AccessedThroughProperty("T11")>
		Private _T11 As Label

		<AccessedThroughProperty("T10")>
		Private _T10 As Label

		<AccessedThroughProperty("T9")>
		Private _T9 As Label

		<AccessedThroughProperty("T8")>
		Private _T8 As Label

		<AccessedThroughProperty("T7")>
		Private _T7 As Label

		<AccessedThroughProperty("T6")>
		Private _T6 As Label

		<AccessedThroughProperty("T5")>
		Private _T5 As Label

		<AccessedThroughProperty("T4")>
		Private _T4 As Label

		<AccessedThroughProperty("T3")>
		Private _T3 As Label

		<AccessedThroughProperty("T2")>
		Private _T2 As Label

		<AccessedThroughProperty("T1")>
		Private _T1 As Label

		Private plotted_rod_num_guides As Integer()

		<AccessedThroughProperty("picScrollBarTip")>
		Private _picScrollBarTip As PictureBox

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As System.Windows.Forms.Button

		<AccessedThroughProperty("timAnimate")>
		Private _timAnimate As System.Windows.Forms.Timer

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("optReport")>
		Private _optReport As RadioButtonArray

		<AccessedThroughProperty("picOutput")>
		Private _picOutput As PanelArray

		<AccessedThroughProperty("cmdIPRPlot")>
		Private _cmdIPRPlot As System.Windows.Forms.Button

		<AccessedThroughProperty("pnlTempChart")>
		Private _pnlTempChart As System.Windows.Forms.Panel

		<AccessedThroughProperty("ChartFX_Temp_Dyno")>
		Private _ChartFX_Temp_Dyno As ChartFX.WinForms.Chart

		<AccessedThroughProperty("ChartFX_Temp_TorquePlot")>
		Private _ChartFX_Temp_TorquePlot As ChartFX.WinForms.Chart

		<AccessedThroughProperty("ChartFX_Dyno")>
		Private _ChartFX_Dyno As ChartFX.WinForms.Chart

		<AccessedThroughProperty("ctxMenu_DynoPlot")>
		Private _ctxMenu_DynoPlot As ContextMenu

		<AccessedThroughProperty("lblAnimateDyno")>
		Private _lblAnimateDyno As Label

		<AccessedThroughProperty("pnlTempChart2")>
		Private _pnlTempChart2 As System.Windows.Forms.Panel

		<AccessedThroughProperty("ChartFX_Temp_Torque_L")>
		Private _ChartFX_Temp_Torque_L As ChartFX.WinForms.Chart

		<AccessedThroughProperty("ChartFX_Temp_Dyno_L")>
		Private _ChartFX_Temp_Dyno_L As ChartFX.WinForms.Chart

		<AccessedThroughProperty("ChartFX_Temp_Dyno_XL")>
		Private _ChartFX_Temp_Dyno_XL As ChartFX.WinForms.Chart

		<AccessedThroughProperty("ChartFX_Temp_Torque_XL")>
		Private _ChartFX_Temp_Torque_XL As ChartFX.WinForms.Chart

		<AccessedThroughProperty("TrackBar1")>
		Private _TrackBar1 As TrackBar

		<AccessedThroughProperty("pnlDeviation")>
		Private _pnlDeviation As System.Windows.Forms.Panel

		<AccessedThroughProperty("chtAxialLoads")>
		Private _chtAxialLoads As ChartFX.WinForms.Chart

		<AccessedThroughProperty("chtBucklingTendency")>
		Private _chtBucklingTendency As ChartFX.WinForms.Chart

		<AccessedThroughProperty("chtSideForces")>
		Private _chtSideForces As ChartFX.WinForms.Chart

		<AccessedThroughProperty("chtSurveyPlan")>
		Private _chtSurveyPlan As ChartFX.WinForms.Chart

		<AccessedThroughProperty("chtSurveyNS")>
		Private _chtSurveyNS As ChartFX.WinForms.Chart

		<AccessedThroughProperty("chtSurveyEW")>
		Private _chtSurveyEW As ChartFX.WinForms.Chart

		<AccessedThroughProperty("chtDoglegs")>
		Private _chtDoglegs As ChartFX.WinForms.Chart

		<AccessedThroughProperty("btnDevCharts")>
		Private _btnDevCharts As System.Windows.Forms.Button

		<AccessedThroughProperty("pnlDevCharts")>
		Private _pnlDevCharts As System.Windows.Forms.Panel

		<AccessedThroughProperty("ChartFX_DoglegSeverity")>
		Private _ChartFX_DoglegSeverity As ChartFX.WinForms.Chart

		<AccessedThroughProperty("ChartFX_LookingDown")>
		Private _ChartFX_LookingDown As ChartFX.WinForms.Chart

		<AccessedThroughProperty("ChartFX_LookingNorth")>
		Private _ChartFX_LookingNorth As ChartFX.WinForms.Chart

		<AccessedThroughProperty("ChartFX_SideLoading")>
		Private _ChartFX_SideLoading As ChartFX.WinForms.Chart

		<AccessedThroughProperty("ChartFX_BucklingTendency")>
		Private _ChartFX_BucklingTendency As ChartFX.WinForms.Chart

		<AccessedThroughProperty("ChartFX_AxialLoads")>
		Private _ChartFX_AxialLoads As ChartFX.WinForms.Chart

		<AccessedThroughProperty("btnPrevDevChart")>
		Private _btnPrevDevChart As System.Windows.Forms.Button

		<AccessedThroughProperty("btnNextDevChart")>
		Private _btnNextDevChart As System.Windows.Forms.Button

		<AccessedThroughProperty("tbbRunPause")>
		Private _tbbRunPause As System.Windows.Forms.Button

		<AccessedThroughProperty("MarksTip1")>
		Private _MarksTip1 As MarksTip

		<AccessedThroughProperty("pnlCommander")>
		Private _pnlCommander As System.Windows.Forms.Panel

		<AccessedThroughProperty("btnResetPlot")>
		Private _btnResetPlot As System.Windows.Forms.Button

		<AccessedThroughProperty("pnlDevPlot")>
		Private _pnlDevPlot As System.Windows.Forms.Panel

		<AccessedThroughProperty("lblNoData")>
		Private _lblNoData As Label

		<AccessedThroughProperty("TChart1")>
		Private _TChart1 As TChart

		<AccessedThroughProperty("point3DSeries1")>
		Private _point3DSeries1 As Points3D

		<AccessedThroughProperty("point3DSeries1_report")>
		Private _point3DSeries1_report As Points3D

		<AccessedThroughProperty("pnlGrpDevPlot")>
		Private _pnlGrpDevPlot As System.Windows.Forms.Panel

		<AccessedThroughProperty("btnCoverPageComments")>
		Private _btnCoverPageComments As System.Windows.Forms.Button

		Private Shared m_vb6FormDefInstance As Results

		Private Shared m_InitializingDefInstance As Boolean

		Private Const PIC_DYNO As Short = 0S

		Private Const PIC_TORQUE As Short = 1S

		Private Const PIC_IPR As Short = 2S

		Private Const PIC_EXPERTANAL As Short = 2S

		Private Const PIC_REPORT As Short = 3S

		Private Const RPT_MATCHINFO As Short = 4S

		Private Const PIC_DEVPLOTS As Integer = 6

		Private FormWidth As Short

		Private FormHeight As Short

		Private firstResize As Boolean

		Private aiReportPages As Short()

		Private afxSurf As Single()

		Private afySurf As Single()

		Private afxPump As Single()

		Private afyPump As Single()

		Private fAnimInterval As Single

		Private menuItem1 As MenuItem

		Private menuItem2 As MenuItem

		Private menuItem3 As MenuItem

		Private menuItem4 As MenuItem

		Private menuItem5 As MenuItem

		Private menuItem6 As MenuItem

		Private menuItem7 As MenuItem

		Private m_iAnimCurPoint As Short

		Private iGetPointStyle2 As Integer

		Private iGetPointStyle2_report As Integer

		Private iGetPointStyle1 As Integer

		Private iGetPointStyle1_report As Integer

		Private bPlotSurveyPointLevel As Boolean

		Private m_rImpred As TEImpred

		<AccessedThroughProperty("ContextMenu1")>
		Private _ContextMenu1 As ContextMenu

		<AccessedThroughProperty("VScroll")>
		Private _VScroll As VScrollBar

		<AccessedThroughProperty("pnlScrollBar")>
		Private _pnlScrollBar As System.Windows.Forms.Panel

		<AccessedThroughProperty("tbbStop")>
		Private _tbbStop As System.Windows.Forms.Button

		<AccessedThroughProperty("tbbStep")>
		Private _tbbStep As System.Windows.Forms.Button

		<AccessedThroughProperty("tbbRun")>
		Private _tbbRun As System.Windows.Forms.Button

		<AccessedThroughProperty("cmdClose")>
		Private _cmdClose As System.Windows.Forms.Button

		<AccessedThroughProperty("_optReport_0")>
		Private __optReport_0 As RadioButton

		<AccessedThroughProperty("_optReport_1")>
		Private __optReport_1 As RadioButton

		<AccessedThroughProperty("_optReport_2")>
		Private __optReport_2 As RadioButton

		<AccessedThroughProperty("_optReport_3")>
		Private __optReport_3 As RadioButton

		<AccessedThroughProperty("pnlTabs")>
		Private _pnlTabs As System.Windows.Forms.Panel

		<AccessedThroughProperty("Viewer1")>
		Private _Viewer1 As Viewer

		<AccessedThroughProperty("pnlActiveReport")>
		Private _pnlActiveReport As System.Windows.Forms.Panel

		<AccessedThroughProperty("ChartFX_TorquePlot")>
		Private _ChartFX_TorquePlot As ChartFX.WinForms.Chart

		<AccessedThroughProperty("pnlTorquePlot")>
		Private _pnlTorquePlot As System.Windows.Forms.Panel

		<AccessedThroughProperty("pnlDyno")>
		Private _pnlDyno As System.Windows.Forms.Panel

		Private bReDisplayPanel As Boolean()

		Private TaperDepths As Single()

		Private $STATIC$optReport_Click_1$2031622$busy As Boolean

		Private $STATIC$VScroll_Change$20118$busy As Boolean

		Public Structure parameter_structure_type
			Public num_survey_points As Integer

			Public iostat As Integer

			Public epsilon As Double
		End Structure

		Private Structure cart_coord_type
			Public X As Double

			Public Y As Double

			Public z As Double
		End Structure

		Private Structure survey_point_type
			Public m_d As Double

			Public inc As Double

			Public azi As Double

			Public dog As Double

			Public rad As Double

			Public pos As Results.cart_coord_type

			Public tan As Results.cart_coord_type

			Public nor As Results.cart_coord_type
		End Structure
	End Class
End Namespace
