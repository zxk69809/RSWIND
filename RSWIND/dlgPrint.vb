Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgPrint
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgPrint_Load
			If dlgPrint.m_vb6FormDefInstance Is Nothing Then
				If dlgPrint.m_InitializingDefInstance Then
					dlgPrint.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgPrint.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property cmdHelp As Button
			Get
				Return Me._cmdHelp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdHelp_Click
				If Me._cmdHelp IsNot Nothing Then
					RemoveHandler Me._cmdHelp.Click, value2
				End If
				Me._cmdHelp = value
				If Me._cmdHelp IsNot Nothing Then
					AddHandler Me._cmdHelp.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdCancel As Button
			Get
				Return Me._cmdCancel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
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

		Public Overridable Property cmdOK As Button
			Get
				Return Me._cmdOK
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdOK_Click
				If Me._cmdOK IsNot Nothing Then
					RemoveHandler Me._cmdOK.Click, value2
				End If
				Me._cmdOK = value
				If Me._cmdOK IsNot Nothing Then
					AddHandler Me._cmdOK.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property SSFrame As PanelArray
			Get
				Return Me._SSFrame
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PanelArray)
				Me._SSFrame = value
			End Set
		End Property

		Public Overridable Property chkReportOpt As PictureBoxArray
			Get
				Return Me._chkReportOpt
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBoxArray)
				Me._chkReportOpt = value
			End Set
		End Property

		Public Overridable Property imgIcons As PictureBoxArray
			Get
				Return Me._imgIcons
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBoxArray)
				Me._imgIcons = value
			End Set
		End Property

		Public Overridable Property imgPreview As PictureBoxArray
			Get
				Return Me._imgPreview
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBoxArray)
				Me._imgPreview = value
			End Set
		End Property

		Friend Overridable Property HelpProvider1 As HelpProvider
			Get
				Return Me._HelpProvider1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As HelpProvider)
				Me._HelpProvider1 = value
			End Set
		End Property

		Friend Overridable Property pnlOutputOptions As Panel
			Get
				Return Me._pnlOutputOptions
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlOutputOptions = value
			End Set
		End Property

		Friend Overridable Property grpOutputOptions As GroupBox
			Get
				Return Me._grpOutputOptions
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpOutputOptions = value
			End Set
		End Property

		Friend Overridable Property chkReportOpt_7 As CheckBox
			Get
				Return Me._chkReportOpt_7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_7_CheckedChanged
				Dim value3 As EventHandler = AddressOf Me.chkReportOpt_7_CheckedChanged
				If Me._chkReportOpt_7 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_7.CheckedChanged, value2
					RemoveHandler Me._chkReportOpt_7.Click, value3
				End If
				Me._chkReportOpt_7 = value
				If Me._chkReportOpt_7 IsNot Nothing Then
					AddHandler Me._chkReportOpt_7.CheckedChanged, value2
					AddHandler Me._chkReportOpt_7.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property GroupBox2 As GroupBox
			Get
				Return Me._GroupBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox2 = value
			End Set
		End Property

		Friend Overridable Property SSPanel As Panel
			Get
				Return Me._SSPanel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._SSPanel = value
			End Set
		End Property

		Friend Overridable Property imgPreview_4 As PictureBox
			Get
				Return Me._imgPreview_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_4 = value
			End Set
		End Property

		Friend Overridable Property imgPreview_2 As PictureBox
			Get
				Return Me._imgPreview_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_2 = value
			End Set
		End Property

		Friend Overridable Property imgPreview_0 As PictureBox
			Get
				Return Me._imgPreview_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_0 = value
			End Set
		End Property

		Friend Overridable Property imgPreview_1 As PictureBox
			Get
				Return Me._imgPreview_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_1 = value
			End Set
		End Property

		Friend Overridable Property grpOutputPages As GroupBox
			Get
				Return Me._grpOutputPages
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpOutputPages = value
			End Set
		End Property

		Friend Overridable Property chkReportOpt_3 As CheckBox
			Get
				Return Me._chkReportOpt_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_3_CheckedChanged
				Dim value3 As EventHandler = AddressOf Me.chkReportOpt_3_CheckedChanged
				If Me._chkReportOpt_3 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_3.CheckedChanged, value2
					RemoveHandler Me._chkReportOpt_3.Click, value3
				End If
				Me._chkReportOpt_3 = value
				If Me._chkReportOpt_3 IsNot Nothing Then
					AddHandler Me._chkReportOpt_3.CheckedChanged, value2
					AddHandler Me._chkReportOpt_3.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_2 As CheckBox
			Get
				Return Me._chkReportOpt_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_2_CheckedChanged
				Dim value3 As EventHandler = AddressOf Me.chkReportOpt_2_CheckedChanged
				If Me._chkReportOpt_2 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_2.CheckedChanged, value2
					RemoveHandler Me._chkReportOpt_2.Click, value3
				End If
				Me._chkReportOpt_2 = value
				If Me._chkReportOpt_2 IsNot Nothing Then
					AddHandler Me._chkReportOpt_2.CheckedChanged, value2
					AddHandler Me._chkReportOpt_2.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_0 As CheckBox
			Get
				Return Me._chkReportOpt_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_0_CheckedChanged
				If Me._chkReportOpt_0 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_0.Click, value2
				End If
				Me._chkReportOpt_0 = value
				If Me._chkReportOpt_0 IsNot Nothing Then
					AddHandler Me._chkReportOpt_0.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_1 As CheckBox
			Get
				Return Me._chkReportOpt_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_1_CheckedChanged
				Dim value3 As EventHandler = AddressOf Me.chkReportOpt_1_CheckedChanged
				If Me._chkReportOpt_1 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_1.CheckedChanged, value2
					RemoveHandler Me._chkReportOpt_1.Click, value3
				End If
				Me._chkReportOpt_1 = value
				If Me._chkReportOpt_1 IsNot Nothing Then
					AddHandler Me._chkReportOpt_1.CheckedChanged, value2
					AddHandler Me._chkReportOpt_1.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_6 As CheckBox
			Get
				Return Me._chkReportOpt_6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_6_CheckedChanged
				If Me._chkReportOpt_6 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_6.Click, value2
				End If
				Me._chkReportOpt_6 = value
				If Me._chkReportOpt_6 IsNot Nothing Then
					AddHandler Me._chkReportOpt_6.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_5 As CheckBox
			Get
				Return Me._chkReportOpt_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_5_CheckedChanged
				If Me._chkReportOpt_5 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_5.CheckedChanged, value2
				End If
				Me._chkReportOpt_5 = value
				If Me._chkReportOpt_5 IsNot Nothing Then
					AddHandler Me._chkReportOpt_5.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_4 As CheckBox
			Get
				Return Me._chkReportOpt_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_4_CheckedChanged
				If Me._chkReportOpt_4 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_4.CheckedChanged, value2
				End If
				Me._chkReportOpt_4 = value
				If Me._chkReportOpt_4 IsNot Nothing Then
					AddHandler Me._chkReportOpt_4.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property imgPreview_5 As PictureBox
			Get
				Return Me._imgPreview_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_5 = value
			End Set
		End Property

		Friend Overridable Property imgPreview_3 As PictureBox
			Get
				Return Me._imgPreview_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_3 = value
			End Set
		End Property

		Friend Overridable Property imgPreview_6 As PictureBox
			Get
				Return Me._imgPreview_6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_6 = value
			End Set
		End Property

		Friend Overridable Property chkReportOpt_8 As CheckBox
			Get
				Return Me._chkReportOpt_8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_8_CheckedChanged
				If Me._chkReportOpt_8 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_8.CheckedChanged, value2
				End If
				Me._chkReportOpt_8 = value
				If Me._chkReportOpt_8 IsNot Nothing Then
					AddHandler Me._chkReportOpt_8.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property imgPreview_ As PictureBox
			Get
				Return Me._imgPreview_
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_ = value
			End Set
		End Property

		Friend Overridable Property chkReportOpt_ As CheckBox
			Get
				Return Me._chkReportOpt_
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt__CheckedChanged
				If Me._chkReportOpt_ IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_.Click, value2
				End If
				Me._chkReportOpt_ = value
				If Me._chkReportOpt_ IsNot Nothing Then
					AddHandler Me._chkReportOpt_.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_9 As CheckBox
			Get
				Return Me._chkReportOpt_9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_9_CheckedChanged
				If Me._chkReportOpt_9 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_9.CheckedChanged, value2
				End If
				Me._chkReportOpt_9 = value
				If Me._chkReportOpt_9 IsNot Nothing Then
					AddHandler Me._chkReportOpt_9.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_10 As CheckBox
			Get
				Return Me._chkReportOpt_10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_10_Click
				If Me._chkReportOpt_10 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_10.Click, value2
				End If
				Me._chkReportOpt_10 = value
				If Me._chkReportOpt_10 IsNot Nothing Then
					AddHandler Me._chkReportOpt_10.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property imgPreview_10 As PictureBox
			Get
				Return Me._imgPreview_10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_10 = value
			End Set
		End Property

		Friend Overridable Property imgPreview_9 As PictureBox
			Get
				Return Me._imgPreview_9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_9 = value
			End Set
		End Property

		Public Shared Property DefInstance As dlgPrint
			Get
				If dlgPrint.m_vb6FormDefInstance Is Nothing OrElse dlgPrint.m_vb6FormDefInstance.IsDisposed Then
					dlgPrint.m_InitializingDefInstance = True
					dlgPrint.m_vb6FormDefInstance = New dlgPrint()
					dlgPrint.m_InitializingDefInstance = False
				End If
				Return dlgPrint.m_vb6FormDefInstance
			End Get
			Set(value As dlgPrint)
				dlgPrint.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub chkReportOpt_Click_1(Index As Integer, Value As Boolean, bClicked As Boolean)
			Me.SetChkReportOpt(Index, Value)
			If Me.GetChkReportOpt(3) Then
				Me.chkReportOpt_3.Enabled = True
			End If
			Me.ShowOutputPages()
		End Sub

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			Me.m_bPrint = False
			Me.Close()
		End Sub

		Public Property bPrint As Boolean
			Get
				Return Me.m_bPrint
			End Get
			Set(value As Boolean)
				Me.m_bPrint = value
			End Set
		End Property

		Private Sub cmdOK_Click(eventSender As Object, eventArgs As EventArgs)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.gbCoverPage = Me.chkReportOpt_.Checked
			rst.gbOrderPage = Me.chkReportOpt_10.Checked
			rst.gbReportData = Me.chkReportOpt_1.Checked
			rst.gbReportIPR = (Me.chkReportOpt_2.Enabled And Me.chkReportOpt_2.Checked)
			rst.gbReportDynoPred = Me.chkReportOpt_3.Checked
			rst.gbReportDynoActual = Me.chkReportOpt_3.Checked
			rst.gbReportSinglePageDynoTorque = Me.chkReportOpt_3.Checked
			rst.gbReportDevChart = Me.chkReportOpt_4.Checked
			rst.gbReportGuide = Me.chkReportOpt_5.Checked
			rst.gbReportDevSurvey = Me.chkReportOpt_8.Checked
			rst.gbScoringPage = Me.chkReportOpt_9.Checked
			If rst.gbOutputLoaded Then
				rst.gbReportDiagnosis = Me.chkReportOpt_0.Checked
				rst.gbReportTorque = Me.chkReportOpt_3.Checked
				rst.gbReportDevChart = Me.chkReportOpt_4.Checked
				rst.gbReportGuide = Me.chkReportOpt_5.Checked
				rst.gbReportDevSurvey = Me.chkReportOpt_8.Checked
			End If
			rst.gbReportCostAnalysis = If((-If((Me.GetChkReportOpt(1) > False), 1S, 0S)), 1S, 0S)
			rst.gbCoverPage = Me.GetChkReportOpt(-1)
			rst.gbOrderPage = Me.GetChkReportOpt(10)
			rst.gbReportData = Me.GetChkReportOpt(0)
			rst.gbReportIPR = Conversions.ToBoolean(Interaction.IIf(Me.GetChkReportOptEnabled(2), Me.GetChkReportOpt(2), False))
			rst.gbReportDynoActual = Conversions.ToBoolean(Interaction.IIf(Me.GetChkReportOptEnabled(6), Me.GetChkReportOpt(6), False))
			rst.gbReportDynoPred = Me.GetChkReportOpt(3)
			rst.gbReportSinglePageDynoTorque = rst.gbReportDynoPred
			rst.gbReportTorque = rst.gbReportDynoPred
			rst.gbReportDevChart = Me.GetChkReportOpt(4)
			rst.gbReportGuide = Me.GetChkReportOpt(5)
			rst.gbReportDevSurvey = Me.GetChkReportOpt(8)
			rst.gbScoringPage = Me.GetChkReportOpt(9)
			RSWIN_DESC.SETUP_CoverPage = If((-If((rst.gbCoverPage > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_OrderPage = If((-If((rst.gbOrderPage > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintData = If((-If((rst.gbReportData > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintCostAnalysis = rst.gbReportCostAnalysis
			RSWIN_DESC.SETUP_PrintIPR = If((-If((rst.gbReportIPR > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintDynoPred = If((-If((rst.gbReportDynoPred > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintDynoActual = If((-If((rst.gbReportDynoActual > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintTorque = If((-If((rst.gbReportTorque > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintSinglePageDynoTorque = If((-If((rst.gbReportSinglePageDynoTorque > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintDevChart = If((-If((rst.gbReportDevChart > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintGuide = If((-If((rst.gbReportGuide > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_ReportDevSurvey = If((-If((rst.gbReportDevSurvey > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_ScoringPage = If((-If((rst.gbScoringPage > False), 1S, 0S)), 1S, 0S)
			If(CInt((Not CInt(RSWIN_DESC.SETUP_PrintData))) And Not RSWIN_DESC.SETUP_PrintDiagnosis And CInt((Not CInt(RSWIN_DESC.SETUP_PrintIPR))) And CInt((Not CInt(RSWIN_DESC.SETUP_PrintDynoPred)))) <> 0 Then
				RSWIN_DESC.SETUP_PrintData = -1S
				RSWIN_DESC.SETUP_PrintDiagnosis = -1
				RSWIN_DESC.SETUP_PrintIPR = -1S
				RSWIN_DESC.SETUP_PrintSinglePageDynoTorque = 0S
				RSWIN_DESC.SETUP_PrintTorque = 0S
				RSWIN_DESC.SETUP_PrintDevChart = 0S
				RSWIN_DESC.SETUP_PrintGuide = 0S
				RSWIN_DESC.SETUP_ReportDevSurvey = 0S
				RSWIN_DESC.SETUP_CoverPage = 0S
				RSWIN_DESC.SETUP_OrderPage = 0S
				RSWIN_DESC.rst.gbCoverPage = (RSWIN_DESC.SETUP_CoverPage <> 0S)
				RSWIN_DESC.rst.gbOrderPage = (RSWIN_DESC.SETUP_OrderPage <> 0S)
				RSWIN_DESC.rst.gbReportData = (RSWIN_DESC.SETUP_PrintData <> 0S)
				RSWIN_DESC.rst.gbReportIPR = (RSWIN_DESC.SETUP_PrintIPR <> 0S)
				RSWIN_DESC.rst.gbReportSinglePageDynoTorque = (RSWIN_DESC.SETUP_PrintSinglePageDynoTorque <> 0S)
				RSWIN_DESC.rst.gbReportTorque = (RSWIN_DESC.SETUP_PrintTorque <> 0S)
				RSWIN_DESC.rst.gbReportDevChart = (RSWIN_DESC.SETUP_PrintDevChart <> 0S)
				RSWIN_DESC.rst.gbReportGuide = (RSWIN_DESC.SETUP_PrintGuide <> 0S)
				RSWIN_DESC.rst.gbReportDevSurvey = (RSWIN_DESC.SETUP_ReportDevSurvey <> 0S)
			End If
			Me.m_bPrint = True
			Me.Hide()
		End Sub

		Private Sub dlgPrint_Load(eventSender As Object, eventArgs As EventArgs)
			Dim form As Form = Me
			Util.CenterForm(form, RSWIN_DESC.frmMain, RSWIN_DESC.frmMain.pnlToolbar.Height, False)
			Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If RSWIN_DESC.bRodStarD Then
				Me.chkReportOpt_8.Visible = True
				Me.chkReportOpt_5.Visible = True
				Me.chkReportOpt_4.Visible = True
			Else
				Me.chkReportOpt_8.Visible = False
				Me.chkReportOpt_5.Visible = False
				Me.chkReportOpt_4.Visible = False
			End If
			Me.chkReportOpt_9.Visible = True
			If Not rst.gbUseIPR Then
				Me.chkReportOpt_2.Enabled = False
			Else
				Me.chkReportOpt_2.Enabled = True
			End If
			If Not rst.gbOutputLoaded Then
				Me.chkReportOpt_0.Enabled = False
				Me.chkReportOpt_3.Enabled = False
			End If
			Dim text As String = "CoverPage"
			Dim flag As Boolean = False
			RSWIN_DESC.SETUP_CoverPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1S, 0S)), 1S, 0S)
			text = "OrderPage"
			flag = False
			RSWIN_DESC.SETUP_OrderPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1S, 0S)), 1S, 0S)
			text = "PrintData"
			flag = True
			RSWIN_DESC.SETUP_PrintData = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1S, 0S)), 1S, 0S)
			text = "PrintCostAnalysis"
			flag = True
			RSWIN_DESC.SETUP_PrintCostAnalysis = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1S, 0S)), 1S, 0S)
			text = "PrintDiagnosis"
			flag = True
			RSWIN_DESC.SETUP_PrintDiagnosis = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1, 0)), 1, 0)
			text = "PrintDynoActual"
			flag = True
			RSWIN_DESC.SETUP_PrintDynoActual = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1S, 0S)), 1S, 0S)
			text = "PrintDynoPred"
			flag = True
			RSWIN_DESC.SETUP_PrintDynoPred = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1S, 0S)), 1S, 0S)
			If rst.gbUseIPR Then
				text = "PrintIPR"
				flag = True
				RSWIN_DESC.SETUP_PrintIPR = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1S, 0S)), 1S, 0S)
			Else
				RSWIN_DESC.SETUP_PrintIPR = 0S
			End If
			RSWIN_DESC.SETUP_PrintSinglePageDynoTorque = RSWIN_DESC.SETUP_PrintDynoPred
			RSWIN_DESC.SETUP_PrintTorque = RSWIN_DESC.SETUP_PrintDynoPred
			If RSWIN_DESC.bRodStarD Then
				text = "PrintDevChart"
				flag = False
				RSWIN_DESC.SETUP_PrintDevChart = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1S, 0S)), 1S, 0S)
				text = "PrintGuide"
				flag = False
				RSWIN_DESC.SETUP_PrintGuide = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1S, 0S)), 1S, 0S)
				text = "ReportDevSurvey"
				flag = False
				RSWIN_DESC.SETUP_ReportDevSurvey = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1S, 0S)), 1S, 0S)
			Else
				RSWIN_DESC.SETUP_PrintDevChart = 0S
				RSWIN_DESC.SETUP_PrintGuide = 0S
				RSWIN_DESC.SETUP_ReportDevSurvey = 0S
			End If
			Me.chkReportOpt_Click_1(-1, RSWIN_DESC.SETUP_CoverPage <> 0S, False)
			Me.chkReportOpt_Click_1(10, RSWIN_DESC.SETUP_OrderPage <> 0S, False)
			Me.chkReportOpt_Click_1(1, RSWIN_DESC.SETUP_PrintCostAnalysis <> 0S, True)
			Me.chkReportOpt_Click_1(2, RSWIN_DESC.SETUP_PrintIPR <> 0S, True)
			Me.chkReportOpt_Click_1(3, RSWIN_DESC.SETUP_PrintDynoPred <> 0S, True)
			Me.chkReportOpt_Click_1(4, RSWIN_DESC.SETUP_PrintTorque <> 0S, True)
			Me.chkReportOpt_Click_1(0, RSWIN_DESC.SETUP_PrintData <> 0S, True)
			Me.chkReportOpt_Click_1(6, RSWIN_DESC.SETUP_PrintDynoActual <> 0S, True)
			Me.chkReportOpt_Click_1(9, RSWIN_DESC.SETUP_ScoringPage <> 0S, True)
			If RSWIN_DESC.bRodStarD Then
				Me.chkReportOpt_Click_1(4, RSWIN_DESC.SETUP_PrintDevChart <> 0S, True)
				Me.chkReportOpt_Click_1(5, RSWIN_DESC.SETUP_PrintGuide <> 0S, True)
				Me.chkReportOpt_Click_1(8, RSWIN_DESC.SETUP_ReportDevSurvey <> 0S, True)
			End If
			If(CInt((Not CInt(RSWIN_DESC.SETUP_PrintData))) And Not RSWIN_DESC.SETUP_PrintDiagnosis And CInt((Not CInt(RSWIN_DESC.SETUP_PrintIPR))) And CInt((Not CInt(RSWIN_DESC.SETUP_PrintDynoPred)))) <> 0 Then
				RSWIN_DESC.SETUP_CoverPage = 0S
				RSWIN_DESC.SETUP_OrderPage = 0S
				RSWIN_DESC.SETUP_PrintData = -1S
				RSWIN_DESC.SETUP_PrintDiagnosis = -1
				RSWIN_DESC.SETUP_PrintIPR = -1S
				RSWIN_DESC.SETUP_PrintSinglePageDynoTorque = -1S
				RSWIN_DESC.SETUP_PrintTorque = -1S
				RSWIN_DESC.SETUP_PrintDynoPred = -1S
				RSWIN_DESC.SETUP_PrintDynoActual = -1S
				RSWIN_DESC.SETUP_PrintDevChart = -1S
				RSWIN_DESC.SETUP_PrintGuide = -1S
				RSWIN_DESC.SETUP_ReportDevSurvey = -1S
				RSWIN_DESC.rst.gbCoverPage = (RSWIN_DESC.SETUP_CoverPage <> 0S)
				RSWIN_DESC.rst.gbOrderPage = (RSWIN_DESC.SETUP_OrderPage <> 0S)
				RSWIN_DESC.rst.gbReportData = (RSWIN_DESC.SETUP_PrintData <> 0S)
				RSWIN_DESC.rst.gbReportIPR = (RSWIN_DESC.SETUP_PrintIPR <> 0S)
				RSWIN_DESC.rst.gbReportSinglePageDynoTorque = (RSWIN_DESC.SETUP_PrintSinglePageDynoTorque <> 0S)
				RSWIN_DESC.rst.gbReportTorque = (RSWIN_DESC.SETUP_PrintTorque <> 0S)
				RSWIN_DESC.rst.gbReportDynoPred = (RSWIN_DESC.SETUP_PrintDynoPred <> 0S)
				RSWIN_DESC.rst.gbReportDynoActual = (RSWIN_DESC.SETUP_PrintDynoActual <> 0S)
				RSWIN_DESC.rst.gbReportDevChart = (RSWIN_DESC.SETUP_PrintDevChart <> 0S)
				RSWIN_DESC.rst.gbReportGuide = (RSWIN_DESC.SETUP_PrintGuide <> 0S)
				RSWIN_DESC.rst.gbReportDevSurvey = (RSWIN_DESC.SETUP_ReportDevSurvey <> 0S)
				text = "CoverPage"
				Dim text2 As String = Convert.ToString(RSWIN_DESC.SETUP_CoverPage)
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				text2 = "OrderPage"
				text = Convert.ToString(RSWIN_DESC.SETUP_OrderPage)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintData"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintData)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintDiagnosis"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDiagnosis)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintDynoPred"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintDynoActual"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoActual)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintIPR"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintIPR)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintSinglePageDynoTorque"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintTorque"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintGuide"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintGuide)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintDevChart"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDevChart)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "ReportDevSurvey"
				text = Convert.ToString(RSWIN_DESC.SETUP_ReportDevSurvey)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
			End If
			Me.chkReportOpt_3.Enabled = True
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private Sub MoveImage(ByRef img As Control, x As Integer, y As Integer)
			img.Left = x
			img.Top = y
			img.Visible = True
		End Sub

		Private Sub ShowOutputPages()
			Try
				Dim num As Integer = If((-If((Me.GetChkReportOpt(6) > False), 1, 0)), 1, 0)
				Dim array As Integer() = New Integer(9) {}
				Dim array2 As Integer() = New Integer(9) {}
				array(0) = 0
				array2(0) = 0
				array(1) = 40
				array2(1) = 0
				array(2) = 0
				array2(2) = 40
				array(3) = 40
				array2(3) = 40
				array(4) = 0
				array2(4) = 80
				array(5) = 40
				array2(5) = 80
				array(6) = 0
				array2(6) = 120
				array(7) = 40
				array2(7) = 120
				array(8) = 0
				array2(8) = 160
				array(9) = 40
				array2(9) = 160
				Dim num2 As Integer = -1
				If Me.GetChkReportOpt(-1) Then
					num2 += 1
					Dim control As Control = Me.imgPreview_
					Me.MoveImage(control, array(num2), array2(num2))
					Me.imgPreview_ = CType(control, PictureBox)
				Else
					Me.imgPreview_.Visible = False
				End If
				If Me.GetChkReportOpt(0) Then
					num2 += 1
					Dim control As Control = Me.imgPreview_0
					Me.MoveImage(control, array(num2), array2(num2))
					Me.imgPreview_0 = CType(control, PictureBox)
				Else
					Me.imgPreview_0.Visible = False
				End If
				If Me.GetChkReportOpt(1) Then
					num2 += 1
					Dim control As Control = Me.imgPreview_1
					Me.MoveImage(control, array(num2), array2(num2))
					Me.imgPreview_1 = CType(control, PictureBox)
				Else
					Me.imgPreview_1.Visible = False
				End If
				If Me.GetChkReportOpt(2) Then
					num2 += 1
					Dim control As Control = Me.imgPreview_2
					Me.MoveImage(control, array(num2), array2(num2))
					Me.imgPreview_2 = CType(control, PictureBox)
				Else
					Me.imgPreview_2.Visible = False
				End If
				Me.imgPreview_3.Visible = False
				If Me.GetChkReportOpt(3) Then
					num2 += 1
					Dim control As Control = Me.imgPreview_3
					Me.MoveImage(control, array(num2), array2(num2))
					Me.imgPreview_3 = CType(control, PictureBox)
				Else
					Me.imgPreview_3.Visible = False
				End If
				If Me.GetChkReportOpt(4) And RSWIN_DESC.bRodStarD Then
					num2 += 1
					Dim control As Control = Me.imgPreview_4
					Me.MoveImage(control, array(num2), array2(num2))
					Me.imgPreview_4 = CType(control, PictureBox)
				Else
					Me.imgPreview_4.Visible = False
				End If
				If Me.GetChkReportOpt(5) And RSWIN_DESC.bRodStarD Then
					num2 += 1
					Dim control As Control = Me.imgPreview_5
					Me.MoveImage(control, array(num2) + 3, array2(num2))
					Me.imgPreview_5 = CType(control, PictureBox)
				Else
					Me.imgPreview_5.Visible = False
				End If
				If Me.GetChkReportOpt(8) And RSWIN_DESC.bRodStarD Then
					num2 += 1
					Dim control As Control = Me.imgPreview_6
					Me.MoveImage(control, array(num2) + 3, array2(num2))
					Me.imgPreview_6 = CType(control, PictureBox)
				Else
					Me.imgPreview_6.Visible = False
				End If
				If Me.GetChkReportOpt(9) Then
					num2 += 1
					Dim control As Control = Me.imgPreview_9
					Me.MoveImage(control, array(num2), array2(num2))
					Me.imgPreview_9 = CType(control, PictureBox)
				Else
					Me.imgPreview_9.Visible = False
				End If
				If Me.GetChkReportOpt(10) Then
					num2 += 1
					Dim control As Control = Me.imgPreview_10
					Me.MoveImage(control, array(num2), array2(num2))
					Me.imgPreview_10 = CType(control, PictureBox)
				Else
					Me.imgPreview_10.Visible = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkReportOpt__CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(-1, Me.chkReportOpt_.Checked, True)
		End Sub

		Private Sub chkReportOpt_0_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(0, Me.chkReportOpt_0.Checked, True)
		End Sub

		Private Sub chkReportOpt_1_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(1, Me.chkReportOpt_1.Checked, True)
		End Sub

		Private Sub chkReportOpt_2_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(2, Me.chkReportOpt_2.Checked, True)
		End Sub

		Private Sub chkReportOpt_3_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(3, Me.chkReportOpt_3.Checked, True)
		End Sub

		Private Sub chkReportOpt_6_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(6, Me.chkReportOpt_6.Checked, True)
		End Sub

		Private Sub chkReportOpt_7_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(7, Me.chkReportOpt_7.Checked, True)
		End Sub

		Private Sub cmdHelp_Click(sender As Object, e As EventArgs)
			Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.Index, "")
		End Sub

		Public Function SetChkReportOpt(Index As Integer, bVal As Boolean) As Boolean
			Try
				Select Case Index
					Case -1
						Me.chkReportOpt_.Checked = bVal
					Case 0
						Me.chkReportOpt_0.Checked = bVal
					Case 1
						Me.chkReportOpt_1.Checked = bVal
					Case 2
						Me.chkReportOpt_2.Checked = bVal
					Case 3
						Me.chkReportOpt_3.Checked = bVal
					Case 4
						Me.chkReportOpt_4.Checked = bVal
					Case 5
						Me.chkReportOpt_5.Checked = bVal
					Case 6
						Me.chkReportOpt_6.Checked = bVal
					Case 7
						Me.chkReportOpt_7.Checked = bVal
					Case 8
						Me.chkReportOpt_8.Checked = bVal
					Case 9
						Me.chkReportOpt_9.Checked = bVal
					Case 10
						Me.chkReportOpt_10.Checked = bVal
				End Select
			Catch ex As Exception
			End Try
			Dim result As Boolean
			Return result
		End Function

		Public Function GetChkReportOpt(Index As Integer) As Boolean
			Select Case Index
				Case -1
					Return Me.chkReportOpt_.Checked
				Case 0
					Return Me.chkReportOpt_0.Checked
				Case 1
					Return Me.chkReportOpt_1.Checked
				Case 2
					Return Me.chkReportOpt_2.Checked
				Case 3
					Return Me.chkReportOpt_3.Checked
				Case 4
					Return Me.chkReportOpt_4.Checked
				Case 5
					Return Me.chkReportOpt_5.Checked
				Case 6
					Return Me.chkReportOpt_6.Checked
				Case 7
					Return Me.chkReportOpt_7.Checked
				Case 8
					Return Me.chkReportOpt_8.Checked
				Case 9
					Return Me.chkReportOpt_9.Checked
				Case 10
					Return Me.chkReportOpt_10.Checked
				Case Else
					Dim result As Boolean
					Return result
			End Select
		End Function

		Public Sub SetChkReportOptEnabled(Index As Integer, Value As Boolean)
			Select Case Index
				Case -1
					Me.chkReportOpt_.Enabled = Value
				Case 0
					Me.chkReportOpt_0.Enabled = Value
				Case 1
					Me.chkReportOpt_1.Enabled = Value
				Case 2
					Me.chkReportOpt_2.Enabled = Value
				Case 3
					Me.chkReportOpt_3.Enabled = Value
				Case 4
					Me.chkReportOpt_4.Enabled = Value
				Case 5
					Me.chkReportOpt_5.Enabled = Value
				Case 6
					Me.chkReportOpt_6.Enabled = Value
				Case 7
					Me.chkReportOpt_7.Enabled = Value
				Case 8
					Me.chkReportOpt_8.Enabled = Value
				Case 9
					Me.chkReportOpt_9.Enabled = Value
				Case 10
					Me.chkReportOpt_10.Enabled = Value
			End Select
		End Sub

		Public Function GetChkReportOptEnabled(Index As Integer) As Boolean
			Select Case Index
				Case -1
					Return Me.chkReportOpt_.Enabled
				Case 0
					Return Me.chkReportOpt_0.Enabled
				Case 1
					Return Me.chkReportOpt_1.Enabled
				Case 2
					Return Me.chkReportOpt_2.Enabled
				Case 3
					Return Me.chkReportOpt_3.Enabled
				Case 4
					Return Me.chkReportOpt_4.Enabled
				Case 5
					Return Me.chkReportOpt_5.Enabled
				Case 6
					Return Me.chkReportOpt_6.Enabled
				Case 7
					Return Me.chkReportOpt_7.Enabled
				Case 8
					Return Me.chkReportOpt_8.Enabled
				Case 9
					Return Me.chkReportOpt_9.Enabled
				Case 10
					Return Me.chkReportOpt_10.Enabled
				Case Else
					Dim result As Boolean
					Return result
			End Select
		End Function

		Public Function GetChkReportOptVisible(Index As Integer) As Boolean
			Select Case Index
				Case -1
					Return Me.chkReportOpt_.Visible
				Case 0
					Return Me.chkReportOpt_0.Visible
				Case 1
					Return Me.chkReportOpt_1.Visible
				Case 2
					Return Me.chkReportOpt_2.Visible
				Case 3
					Return Me.chkReportOpt_3.Visible
				Case 4
					Return Me.chkReportOpt_4.Visible
				Case 5
					Return Me.chkReportOpt_5.Visible
				Case 6
					Return Me.chkReportOpt_6.Visible
				Case 7
					Return Me.chkReportOpt_7.Visible
				Case 8
					Return Me.chkReportOpt_8.Visible
				Case 9
					Return Me.chkReportOpt_9.Visible
				Case 10
					Return Me.chkReportOpt_10.Visible
				Case Else
					Dim result As Boolean
					Return result
			End Select
		End Function

		Private Sub chkReportOpt_4_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(4, Me.chkReportOpt_4.Checked, True)
		End Sub

		Private Sub chkReportOpt_5_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(5, Me.chkReportOpt_5.Checked, True)
		End Sub

		Private Sub chkReportOpt_8_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(8, Me.chkReportOpt_8.Checked, True)
		End Sub

		Private Sub chkReportOpt_9_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(9, Me.chkReportOpt_9.Checked, True)
		End Sub

		Private Sub RepositionReportOptions()
			Me.chkReportOpt_8.Top = Me.chkReportOpt_5.Top
			Me.chkReportOpt_5.Top = Me.chkReportOpt_4.Top
			Me.chkReportOpt_4.Top = Me.chkReportOpt_3.Top
			Me.chkReportOpt_3.Top = Me.chkReportOpt_2.Top
			Me.chkReportOpt_2.Top = Me.chkReportOpt_1.Top
			Me.chkReportOpt_1.Top = Me.chkReportOpt_0.Top
			Me.chkReportOpt_0.Top = Me.chkReportOpt_9.Top
		End Sub

		Private Sub chkReportOpt_10_Click(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(10, Me.chkReportOpt_10.Checked, True)
		End Sub

		<AccessedThroughProperty("cmdHelp")>
		Private _cmdHelp As Button

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("SSFrame")>
		Private _SSFrame As PanelArray

		<AccessedThroughProperty("chkReportOpt")>
		Private _chkReportOpt As PictureBoxArray

		<AccessedThroughProperty("imgIcons")>
		Private _imgIcons As PictureBoxArray

		<AccessedThroughProperty("imgPreview")>
		Private _imgPreview As PictureBoxArray

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		<AccessedThroughProperty("pnlOutputOptions")>
		Private _pnlOutputOptions As Panel

		<AccessedThroughProperty("grpOutputOptions")>
		Private _grpOutputOptions As GroupBox

		<AccessedThroughProperty("chkReportOpt_7")>
		Private _chkReportOpt_7 As CheckBox

		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As Panel

		<AccessedThroughProperty("imgPreview_4")>
		Private _imgPreview_4 As PictureBox

		<AccessedThroughProperty("imgPreview_2")>
		Private _imgPreview_2 As PictureBox

		<AccessedThroughProperty("imgPreview_0")>
		Private _imgPreview_0 As PictureBox

		<AccessedThroughProperty("imgPreview_1")>
		Private _imgPreview_1 As PictureBox

		<AccessedThroughProperty("grpOutputPages")>
		Private _grpOutputPages As GroupBox

		<AccessedThroughProperty("chkReportOpt_3")>
		Private _chkReportOpt_3 As CheckBox

		<AccessedThroughProperty("chkReportOpt_2")>
		Private _chkReportOpt_2 As CheckBox

		<AccessedThroughProperty("chkReportOpt_0")>
		Private _chkReportOpt_0 As CheckBox

		<AccessedThroughProperty("chkReportOpt_1")>
		Private _chkReportOpt_1 As CheckBox

		<AccessedThroughProperty("chkReportOpt_6")>
		Private _chkReportOpt_6 As CheckBox

		<AccessedThroughProperty("chkReportOpt_5")>
		Private _chkReportOpt_5 As CheckBox

		<AccessedThroughProperty("chkReportOpt_4")>
		Private _chkReportOpt_4 As CheckBox

		<AccessedThroughProperty("imgPreview_5")>
		Private _imgPreview_5 As PictureBox

		<AccessedThroughProperty("imgPreview_3")>
		Private _imgPreview_3 As PictureBox

		<AccessedThroughProperty("imgPreview_6")>
		Private _imgPreview_6 As PictureBox

		<AccessedThroughProperty("chkReportOpt_8")>
		Private _chkReportOpt_8 As CheckBox

		<AccessedThroughProperty("imgPreview_")>
		Private _imgPreview_ As PictureBox

		<AccessedThroughProperty("chkReportOpt_")>
		Private _chkReportOpt_ As CheckBox

		<AccessedThroughProperty("chkReportOpt_9")>
		Private _chkReportOpt_9 As CheckBox

		<AccessedThroughProperty("chkReportOpt_10")>
		Private _chkReportOpt_10 As CheckBox

		<AccessedThroughProperty("imgPreview_10")>
		Private _imgPreview_10 As PictureBox

		<AccessedThroughProperty("imgPreview_9")>
		Private _imgPreview_9 As PictureBox

		Private Shared m_vb6FormDefInstance As dlgPrint

		Private Shared m_InitializingDefInstance As Boolean

		Private Const cCoverPage As Integer = -1

		Private Const cCALCULATIONS As Integer = 0

		Private Const cCOSTANALYSIS As Integer = 1

		Private Const cIPRDATA As Integer = 2

		Private Const cDYNO_PRED As Integer = 3

		Private Const cDevChart As Integer = 4

		Private Const cGuideReport As Integer = 5

		Private Const cDYNO_ACTUAL As Integer = 6

		Private Const cSummary As Integer = 7

		Private Const cReportDevSurvey As Integer = 8

		Private Const cScoring As Integer = 9

		Private Const cOrderPage As Integer = 10

		Private m_bPrint As Boolean
	End Class
End Namespace
