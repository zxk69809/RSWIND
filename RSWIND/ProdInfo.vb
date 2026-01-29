Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class ProdInfo
		Inherits Form

		Private Overridable Property IPRPlot As IPRPlot
			Get
				Return Me._IPRPlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As IPRPlot)
				Me._IPRPlot = value
			End Set
		End Property

		Public Property bAlreadyAskedTargetBFPDQuestion As Boolean
			Get
				Return Me.m_bAlreadyAskedTargetBFPDQuestion
			End Get
			Set(value As Boolean)
				Me.m_bAlreadyAskedTargetBFPDQuestion = value
			End Set
		End Property

		Public Property bClosing As Boolean
			Get
				Return Me.m_bClosing
			End Get
			Set(value As Boolean)
				Me.m_bClosing = value
			End Set
		End Property

		Friend Overridable Property pnlIPR As Panel
			Get
				Return Me._pnlIPR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlIPR = value
			End Set
		End Property

		Friend Overridable Property chkBelowBPP As CheckBox
			Get
				Return Me._chkBelowBPP
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkBelowBPP_CheckedChanged
				Dim value3 As EventHandler = AddressOf Me.chkBelowBPP_CheckChanged
				If Me._chkBelowBPP IsNot Nothing Then
					RemoveHandler Me._chkBelowBPP.CheckedChanged, value2
					RemoveHandler Me._chkBelowBPP.CheckedChanged, value3
				End If
				Me._chkBelowBPP = value
				If Me._chkBelowBPP IsNot Nothing Then
					AddHandler Me._chkBelowBPP.CheckedChanged, value2
					AddHandler Me._chkBelowBPP.CheckedChanged, value3
				End If
			End Set
		End Property

		Public Overridable Property ulgTestPoints As UltraGrid
			Get
				Return Me._ulgTestPoints
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As EventHandler = AddressOf Me.ulgTestPoints_Leave
				Dim value3 As InitializeLayoutEventHandler = AddressOf Me.ulgTestPoints_InitializeLayout
				Dim value4 As EventHandler = AddressOf Me.ulgTestPoints_Enter
				Dim value5 As CancelableCellEventHandler = AddressOf Me.ulgTestPoints_BeforeCellActivate
				Dim value6 As EventHandler = AddressOf Me.ulgTestPoints_AfterRowsDeleted
				Dim value7 As RowEventHandler = AddressOf Me.ulgTestPoints_AfterRowInsert
				Dim value8 As CellEventHandler = AddressOf Me.ulgTestPoints_AfterCellUpdate
				Dim value9 As BeforeRowsDeletedEventHandler = AddressOf Me.ulgTestPoints_BeforeRowsDeleted
				If Me._ulgTestPoints IsNot Nothing Then
					RemoveHandler Me._ulgTestPoints.Leave, value2
					RemoveHandler Me._ulgTestPoints.InitializeLayout, value3
					RemoveHandler Me._ulgTestPoints.Enter, value4
					RemoveHandler Me._ulgTestPoints.BeforeCellActivate, value5
					RemoveHandler Me._ulgTestPoints.AfterRowsDeleted, value6
					RemoveHandler Me._ulgTestPoints.AfterRowInsert, value7
					RemoveHandler Me._ulgTestPoints.AfterCellUpdate, value8
					RemoveHandler Me._ulgTestPoints.BeforeRowsDeleted, value9
				End If
				Me._ulgTestPoints = value
				If Me._ulgTestPoints IsNot Nothing Then
					AddHandler Me._ulgTestPoints.Leave, value2
					AddHandler Me._ulgTestPoints.InitializeLayout, value3
					AddHandler Me._ulgTestPoints.Enter, value4
					AddHandler Me._ulgTestPoints.BeforeCellActivate, value5
					AddHandler Me._ulgTestPoints.AfterRowsDeleted, value6
					AddHandler Me._ulgTestPoints.AfterRowInsert, value7
					AddHandler Me._ulgTestPoints.AfterCellUpdate, value8
					AddHandler Me._ulgTestPoints.BeforeRowsDeleted, value9
				End If
			End Set
		End Property

		Public Overridable Property cmdDelTestPoint As Button
			Get
				Return Me._cmdDelTestPoint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdDelTestPoint_Click
				If Me._cmdDelTestPoint IsNot Nothing Then
					RemoveHandler Me._cmdDelTestPoint.Click, value2
				End If
				Me._cmdDelTestPoint = value
				If Me._cmdDelTestPoint IsNot Nothing Then
					AddHandler Me._cmdDelTestPoint.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdAddTestPoint As Button
			Get
				Return Me._cmdAddTestPoint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdAddTestPoint_Click
				If Me._cmdAddTestPoint IsNot Nothing Then
					RemoveHandler Me._cmdAddTestPoint.Click, value2
				End If
				Me._cmdAddTestPoint = value
				If Me._cmdAddTestPoint IsNot Nothing Then
					AddHandler Me._cmdAddTestPoint.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cboTestPointType As ComboBox
			Get
				Return Me._cboTestPointType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboTestPointType_DropDown
				Dim value3 As EventHandler = AddressOf Me.cboTestPointType_SelectedValueChanged
				Dim value4 As EventHandler = AddressOf Me.cboTestPointType_SelectedIndexChanged
				Dim value5 As EventHandler = AddressOf Me.cboTestPointType_Leave
				Dim value6 As EventHandler = AddressOf Me.cboTestPointType_Enter
				If Me._cboTestPointType IsNot Nothing Then
					RemoveHandler Me._cboTestPointType.DropDown, value2
					RemoveHandler Me._cboTestPointType.SelectedValueChanged, value3
					RemoveHandler Me._cboTestPointType.SelectedIndexChanged, value4
					RemoveHandler Me._cboTestPointType.Leave, value5
					RemoveHandler Me._cboTestPointType.Enter, value6
				End If
				Me._cboTestPointType = value
				If Me._cboTestPointType IsNot Nothing Then
					AddHandler Me._cboTestPointType.DropDown, value2
					AddHandler Me._cboTestPointType.SelectedValueChanged, value3
					AddHandler Me._cboTestPointType.SelectedIndexChanged, value4
					AddHandler Me._cboTestPointType.Leave, value5
					AddHandler Me._cboTestPointType.Enter, value6
				End If
			End Set
		End Property

		Public Overridable Property cmdIPRPlot As Button
			Get
				Return Me._cmdIPRPlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
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

		Public Overridable Property cmdCheckIPR As Button
			Get
				Return Me._cmdCheckIPR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdCheckIPR_Click
				If Me._cmdCheckIPR IsNot Nothing Then
					RemoveHandler Me._cmdCheckIPR.Click, value2
				End If
				Me._cmdCheckIPR = value
				If Me._cmdCheckIPR IsNot Nothing Then
					AddHandler Me._cmdCheckIPR.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property chkCalculateN As CheckBox
			Get
				Return Me._chkCalculateN
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkCalculateN_Leave
				Dim value3 As EventHandler = AddressOf Me.chkCalculateN_Enter
				Dim value4 As EventHandler = AddressOf Me.chkCalculateN_CheckedChanged
				If Me._chkCalculateN IsNot Nothing Then
					RemoveHandler Me._chkCalculateN.Leave, value2
					RemoveHandler Me._chkCalculateN.Enter, value3
					RemoveHandler Me._chkCalculateN.CheckedChanged, value4
				End If
				Me._chkCalculateN = value
				If Me._chkCalculateN IsNot Nothing Then
					AddHandler Me._chkCalculateN.Leave, value2
					AddHandler Me._chkCalculateN.Enter, value3
					AddHandler Me._chkCalculateN.CheckedChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property frmMaxProduction As GroupBox
			Get
				Return Me._frmMaxProduction
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._frmMaxProduction = value
			End Set
		End Property

		Public Overridable Property _Label_Fluid As Label
			Get
				Return Me.__Label_Fluid
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_Fluid = value
			End Set
		End Property

		Public Overridable Property _Label_Water As Label
			Get
				Return Me.__Label_Water
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_Water = value
			End Set
		End Property

		Public Overridable Property _Label_Oil As Label
			Get
				Return Me.__Label_Oil
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_Oil = value
			End Set
		End Property

		Public Overridable Property _lblMaxProduction_2 As Label
			Get
				Return Me.__lblMaxProduction_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__lblMaxProduction_2 = value
			End Set
		End Property

		Public Overridable Property _lblMaxProduction_1 As Label
			Get
				Return Me.__lblMaxProduction_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__lblMaxProduction_1 = value
			End Set
		End Property

		Public Overridable Property _lblMaxProduction_0 As Label
			Get
				Return Me.__lblMaxProduction_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__lblMaxProduction_0 = value
			End Set
		End Property

		Public Overridable Property cmdUpdateProduction As Button
			Get
				Return Me._cmdUpdateProduction
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdUpdateProduction_Click
				If Me._cmdUpdateProduction IsNot Nothing Then
					RemoveHandler Me._cmdUpdateProduction.Click, value2
				End If
				Me._cmdUpdateProduction = value
				If Me._cmdUpdateProduction IsNot Nothing Then
					AddHandler Me._cmdUpdateProduction.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _Label_PressMeasuredAt As Label
			Get
				Return Me.__Label_PressMeasuredAt
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_PressMeasuredAt = value
			End Set
		End Property

		Public Overridable Property _Label_MidPerfDepth As Label
			Get
				Return Me.__Label_MidPerfDepth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_MidPerfDepth = value
			End Set
		End Property

		Public Overridable Property _Label_StaticBHPressure As Label
			Get
				Return Me.__Label_StaticBHPressure
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_StaticBHPressure = value
			End Set
		End Property

		Public Overridable Property _Label_BubblePoint As Label
			Get
				Return Me.__Label_BubblePoint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_BubblePoint = value
			End Set
		End Property

		Public Overridable Property _Label_ProdTestPoints As Label
			Get
				Return Me.__Label_ProdTestPoints
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_ProdTestPoints = value
			End Set
		End Property

		Public Overridable Property _Label_IPRCalcMethod As Label
			Get
				Return Me.__Label_IPRCalcMethod
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_IPRCalcMethod = value
			End Set
		End Property

		Public Overridable Property _Label_FetkovichN As Label
			Get
				Return Me.__Label_FetkovichN
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_FetkovichN = value
			End Set
		End Property

		Public Overridable Property cboIPRMethod As ComboBox
			Get
				Return Me._cboIPRMethod
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboIPRMethod_Leave
				Dim value3 As EventHandler = AddressOf Me.cboIPRMethod_Enter
				Dim value4 As EventHandler = AddressOf Me.cboIPRMethod_SelectedIndexChanged
				If Me._cboIPRMethod IsNot Nothing Then
					RemoveHandler Me._cboIPRMethod.Leave, value2
					RemoveHandler Me._cboIPRMethod.Enter, value3
					RemoveHandler Me._cboIPRMethod.SelectedIndexChanged, value4
				End If
				Me._cboIPRMethod = value
				If Me._cboIPRMethod IsNot Nothing Then
					AddHandler Me._cboIPRMethod.Leave, value2
					AddHandler Me._cboIPRMethod.Enter, value3
					AddHandler Me._cboIPRMethod.SelectedIndexChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property txtMidPerfDepth As TextBox
			Get
				Return Me._txtMidPerfDepth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMidPerfDepth_TextChanged
				Dim value3 As KeyEventHandler = AddressOf Me.txtMidPerfDepth_KeyDown
				Dim value4 As EventHandler = AddressOf Me.txtMidPerfDepth_Enter
				Dim value5 As EventHandler = AddressOf Me.txtMidPerfDepth_Leave
				If Me._txtMidPerfDepth IsNot Nothing Then
					RemoveHandler Me._txtMidPerfDepth.TextChanged, value2
					RemoveHandler Me._txtMidPerfDepth.KeyDown, value3
					RemoveHandler Me._txtMidPerfDepth.Enter, value4
					RemoveHandler Me._txtMidPerfDepth.Leave, value5
				End If
				Me._txtMidPerfDepth = value
				If Me._txtMidPerfDepth IsNot Nothing Then
					AddHandler Me._txtMidPerfDepth.TextChanged, value2
					AddHandler Me._txtMidPerfDepth.KeyDown, value3
					AddHandler Me._txtMidPerfDepth.Enter, value4
					AddHandler Me._txtMidPerfDepth.Leave, value5
				End If
			End Set
		End Property

		Public Overridable Property txtStaticBHPressure As TextBox
			Get
				Return Me._txtStaticBHPressure
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtStaticBHPressure_Enter
				Dim value3 As EventHandler = AddressOf Me.txtStaticBHPressure_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtStaticBHPressure_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtStaticBHPressure_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtStaticBHPressure_TextChanged
				If Me._txtStaticBHPressure IsNot Nothing Then
					RemoveHandler Me._txtStaticBHPressure.Enter, value2
					RemoveHandler Me._txtStaticBHPressure.Leave, value3
					RemoveHandler Me._txtStaticBHPressure.KeyPress, value4
					RemoveHandler Me._txtStaticBHPressure.KeyDown, value5
					RemoveHandler Me._txtStaticBHPressure.TextChanged, value6
				End If
				Me._txtStaticBHPressure = value
				If Me._txtStaticBHPressure IsNot Nothing Then
					AddHandler Me._txtStaticBHPressure.Enter, value2
					AddHandler Me._txtStaticBHPressure.Leave, value3
					AddHandler Me._txtStaticBHPressure.KeyPress, value4
					AddHandler Me._txtStaticBHPressure.KeyDown, value5
					AddHandler Me._txtStaticBHPressure.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtBubblePoint As TextBox
			Get
				Return Me._txtBubblePoint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtBubblePoint_Leave
				Dim value3 As KeyPressEventHandler = AddressOf Me.txtBubblePoint_KeyPress
				Dim value4 As KeyEventHandler = AddressOf Me.txtBubblePoint_KeyDown
				Dim value5 As EventHandler = AddressOf Me.txtBubblePoint_TextChanged
				Dim value6 As EventHandler = AddressOf Me.txtBubblePoint_EnabledChanged
				Dim value7 As EventHandler = AddressOf Me.txtBubblePointe_Enter
				If Me._txtBubblePoint IsNot Nothing Then
					RemoveHandler Me._txtBubblePoint.Leave, value2
					RemoveHandler Me._txtBubblePoint.KeyPress, value3
					RemoveHandler Me._txtBubblePoint.KeyDown, value4
					RemoveHandler Me._txtBubblePoint.TextChanged, value5
					RemoveHandler Me._txtBubblePoint.EnabledChanged, value6
					RemoveHandler Me._txtBubblePoint.Enter, value7
				End If
				Me._txtBubblePoint = value
				If Me._txtBubblePoint IsNot Nothing Then
					AddHandler Me._txtBubblePoint.Leave, value2
					AddHandler Me._txtBubblePoint.KeyPress, value3
					AddHandler Me._txtBubblePoint.KeyDown, value4
					AddHandler Me._txtBubblePoint.TextChanged, value5
					AddHandler Me._txtBubblePoint.EnabledChanged, value6
					AddHandler Me._txtBubblePoint.Enter, value7
				End If
			End Set
		End Property

		Friend Overridable Property lblBubblePoint_Disabled As Label
			Get
				Return Me._lblBubblePoint_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblBubblePoint_Disabled = value
			End Set
		End Property

		Public Overridable Property txtFetkovichN As TextBox
			Get
				Return Me._txtFetkovichN
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtFetkovichN_Enter
				Dim value3 As EventHandler = AddressOf Me.txtFetkovichN_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtFetkovichN_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtFetkovichN_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtFetkovichN_TextChanged
				Dim value7 As EventHandler = AddressOf Me.txtFetkovichN_EnabledChanged
				If Me._txtFetkovichN IsNot Nothing Then
					RemoveHandler Me._txtFetkovichN.Enter, value2
					RemoveHandler Me._txtFetkovichN.Leave, value3
					RemoveHandler Me._txtFetkovichN.KeyPress, value4
					RemoveHandler Me._txtFetkovichN.KeyDown, value5
					RemoveHandler Me._txtFetkovichN.TextChanged, value6
					RemoveHandler Me._txtFetkovichN.EnabledChanged, value7
				End If
				Me._txtFetkovichN = value
				If Me._txtFetkovichN IsNot Nothing Then
					AddHandler Me._txtFetkovichN.Enter, value2
					AddHandler Me._txtFetkovichN.Leave, value3
					AddHandler Me._txtFetkovichN.KeyPress, value4
					AddHandler Me._txtFetkovichN.KeyDown, value5
					AddHandler Me._txtFetkovichN.TextChanged, value6
					AddHandler Me._txtFetkovichN.EnabledChanged, value7
				End If
			End Set
		End Property

		Friend Overridable Property lblFetkovichN_Disabled As Label
			Get
				Return Me._lblFetkovichN_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFetkovichN_Disabled = value
			End Set
		End Property

		Public Overridable Property _linSeparator_2 As Label
			Get
				Return Me.__linSeparator_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linSeparator_2 = value
			End Set
		End Property

		Public Property bValidated As Boolean
			Get
				Return Me.m_bValidated
			End Get
			Set(value As Boolean)
				Me.m_bValidated = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Closed, AddressOf Me.ProdInfo_Closed
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.ProdInfo_MouseDoubleClick
			AddHandler MyBase.MouseDown, AddressOf Me.ProdInfo_MouseDown
			AddHandler MyBase.MouseEnter, AddressOf Me.ProdInfo_MouseEnter
			AddHandler MyBase.MouseMove, AddressOf Me.ProdInfo_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.ProdInfo_MouseUp
			AddHandler MyBase.MouseWheel, AddressOf Me.ProdInfo_MouseWheel
			AddHandler MyBase.Move, AddressOf Me.ProdInfo_Move
			AddHandler MyBase.Scroll, AddressOf Me.ProdInfo_Scroll
			AddHandler MyBase.KeyPress, AddressOf Me.ProdInfo_KeyPress
			AddHandler MyBase.KeyUp, AddressOf Me.ProdInfo_KeyUp
			AddHandler MyBase.DragDrop, AddressOf Me.ProdInfo_DragDrop
			AddHandler MyBase.DragEnter, AddressOf Me.ProdInfo_DragEnter
			AddHandler MyBase.FormClosed, AddressOf Me.ProdInfo_FormClosed
			AddHandler MyBase.FormClosing, AddressOf Me.ProdInfo_FormClosing
			AddHandler MyBase.LostFocus, AddressOf Me.ProdInfo_LostFocus
			AddHandler MyBase.GotFocus, AddressOf Me.ProdInfo_GotFocus
			AddHandler MyBase.Closing, AddressOf Me.Form_Closing
			AddHandler MyBase.Validating, AddressOf Me.ProdInfo_Validating
			AddHandler MyBase.Activated, AddressOf Me.ProdInfo_Activated
			AddHandler MyBase.Load, AddressOf Me.ProdInfo_Load
			AddHandler MyBase.Leave, AddressOf Me.ProdInfo_Leave
			Me.IPRPlot = New IPRPlot()
			Me.myKeyValueHT = New Hashtable()
			Me.bCancel = False
			Me.bFLMsgShown = False
			Me.sMidPerforation = Util.AssignValueToConstant("prodinfo", "smidperforation", "Mid. Perforation")
			Me.sPumpIntake = Util.AssignValueToConstant("prodinfo", "spumpintake", "Pump intake")
			Me.m_bAlreadyAskedTargetBFPDQuestion = False
			Me.m_bClosing = False
			Me.m_bValidated = False
			Me.bAIPreferencesSet = False
			Me.stargetprod = Util.AssignValueToConstant("ProdInfo", "stargetprod", "Target Production")
			Me.CAP_FLUIDLEVEL = Util.AssignValueToConstant("ProdInfo", "CAP_FLUIDLEVEL", "Fluid level (ft from surface):")
			Me.CAP_PUMPINTAKE = Util.AssignValueToConstant("ProdInfo", "CAP_PUMPINTAKE", "Pump intake pressure (psi):")
			Me.TAG_FLUIDLEVEL = Util.AssignValueToConstant("ProdInfo", "TAG_FLUIDLEVEL", "Fluid level (^ from surface):")
			Me.TAG_PUMPINTAKE = Util.AssignValueToConstant("ProdInfo", "TAG_PUMPINTAKE", "Pump intake pressure (^):")
			Me.CAP_BFPD = Util.AssignValueToConstant("ProdInfo", "CAP_BFPD", "Target production (BFPD):")
			Me.TAG_BFPD = Util.AssignValueToConstant("ProdInfo", "TAG_BFPD", "Target production (^):")
			Me.CAP_SPM = Util.AssignValueToConstant("ProdInfo", "CAP_SPM", "Pumping speed (spm):")
			Me.TAG_SPM = ""
			Me.sDeleteRow = Util.AssignValueToConstant("ProdInfo", "sDeleteRow", "Delete row(s)")
			Me.sDataInconsistent = Util.AssignValueToConstant("ProdInfo", "sDataInconsistent", "The production data you have entered is inconsistent.")
			Me.sDataDuplicate = Util.AssignValueToConstant("ProdInfo", "sDataDuplicate", "The production data you have entered has a duplicated test point. Please remove it before continuing.")
			Me.sFluidProduction = Util.AssignValueToConstant("ProdInfo", "sfluidproduction", "Fluid production")
			Me.sPressure = Util.AssignValueToConstant("ProdInfo", "spressure", "Pressure")
			Me.bLowerTargetMsgShown = False
			Me.bUpperTargetMsgShown = False
			Me.bLoadingForm = False
			Me.m_bFormLoaded = False
			Me.m_bReloadProdInfo = False
			Me.m_bIPRMessageShown = False
			Me.m_bFormActivated = False
			If ProdInfo.m_vb6FormDefInstance Is Nothing Then
				If ProdInfo.m_InitializingDefInstance Then
					ProdInfo.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							ProdInfo.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
			Me.Text = "Production Information"
		End Sub

		Public Overridable Property txtFLPIP As TextBox
			Get
				Return Me._txtFLPIP
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtFLPIP_Enter
				Dim value3 As EventHandler = AddressOf Me.txtFLPIP_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtFLPIP_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtFLPIP_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtFLPIP_TextChanged
				Dim value7 As EventHandler = AddressOf Me.txtFLPIP_EnabledChanged
				Dim value8 As EventHandler = AddressOf Me.txtFLPIP_GotFocus
				If Me._txtFLPIP IsNot Nothing Then
					RemoveHandler Me._txtFLPIP.Enter, value2
					RemoveHandler Me._txtFLPIP.Leave, value3
					RemoveHandler Me._txtFLPIP.KeyPress, value4
					RemoveHandler Me._txtFLPIP.KeyDown, value5
					RemoveHandler Me._txtFLPIP.TextChanged, value6
					RemoveHandler Me._txtFLPIP.EnabledChanged, value7
					RemoveHandler Me._txtFLPIP.GotFocus, value8
				End If
				Me._txtFLPIP = value
				If Me._txtFLPIP IsNot Nothing Then
					AddHandler Me._txtFLPIP.Enter, value2
					AddHandler Me._txtFLPIP.Leave, value3
					AddHandler Me._txtFLPIP.KeyPress, value4
					AddHandler Me._txtFLPIP.KeyDown, value5
					AddHandler Me._txtFLPIP.TextChanged, value6
					AddHandler Me._txtFLPIP.EnabledChanged, value7
					AddHandler Me._txtFLPIP.GotFocus, value8
				End If
			End Set
		End Property

		Public Overridable Property _SSPanel_0 As Panel
			Get
				Return Me.__SSPanel_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As PaintEventHandler = AddressOf Me._SSPanel_0_Paint
				If Me.__SSPanel_0 IsNot Nothing Then
					RemoveHandler Me.__SSPanel_0.Paint, value2
				End If
				Me.__SSPanel_0 = value
				If Me.__SSPanel_0 IsNot Nothing Then
					AddHandler Me.__SSPanel_0.Paint, value2
				End If
			End Set
		End Property

		Public Overridable Property _linSeparator_0 As Label
			Get
				Return Me.__linSeparator_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linSeparator_0 = value
			End Set
		End Property

		Public Overridable Property _linSeparator_1 As Label
			Get
				Return Me.__linSeparator_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linSeparator_1 = value
			End Set
		End Property

		Public Overridable Property _linSeparator_3 As Label
			Get
				Return Me.__linSeparator_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linSeparator_3 = value
			End Set
		End Property

		Public Overridable Property picRemoveFocus As Panel
			Get
				Return Me._picRemoveFocus
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As PaintEventHandler = AddressOf Me.picRemoveFocus_Paint
				Dim value3 As MouseEventHandler = AddressOf Me.picRemoveFocus_MouseDown
				If Me._picRemoveFocus IsNot Nothing Then
					RemoveHandler Me._picRemoveFocus.Paint, value2
					RemoveHandler Me._picRemoveFocus.MouseDown, value3
				End If
				Me._picRemoveFocus = value
				If Me._picRemoveFocus IsNot Nothing Then
					AddHandler Me._picRemoveFocus.Paint, value2
					AddHandler Me._picRemoveFocus.MouseDown, value3
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

		Public Overridable Property SSPanel As PanelArray
			Get
				Return Me._SSPanel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PanelArray)
				Me._SSPanel = value
			End Set
		End Property

		Public Overridable Property linSeparator As LabelArray
			Get
				Return Me._linSeparator
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._linSeparator = value
			End Set
		End Property

		Public Overridable Property optFLPIP As RadioButtonArray
			Get
				Return Me._optFLPIP
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButtonArray)
				Me._optFLPIP = value
			End Set
		End Property

		Public Overridable Property optSPMBFPD As RadioButtonArray
			Get
				Return Me._optSPMBFPD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButtonArray)
				Me._optSPMBFPD = value
			End Set
		End Property

		Public Overridable Property chkIPRData As CheckBox
			Get
				Return Me._chkIPRData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkIPRData_CheckedChanged
				If Me._chkIPRData IsNot Nothing Then
					RemoveHandler Me._chkIPRData.CheckedChanged, value2
				End If
				Me._chkIPRData = value
				If Me._chkIPRData IsNot Nothing Then
					AddHandler Me._chkIPRData.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optFLPIP_5 As RadioButton
			Get
				Return Me.__optFLPIP_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me.__optFLPIP_5 = value
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

		Public Overridable Property _optSPMBFPD_0 As RadioButton
			Get
				Return Me.__optSPMBFPD_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optSPMBFPD_0_CheckedChanged
				If Me.__optSPMBFPD_0 IsNot Nothing Then
					RemoveHandler Me.__optSPMBFPD_0.CheckedChanged, value2
				End If
				Me.__optSPMBFPD_0 = value
				If Me.__optSPMBFPD_0 IsNot Nothing Then
					AddHandler Me.__optSPMBFPD_0.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optSPMBFPD_1 As RadioButton
			Get
				Return Me.__optSPMBFPD_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optSPMBFPD_1_CheckedChanged
				If Me.__optSPMBFPD_1 IsNot Nothing Then
					RemoveHandler Me.__optSPMBFPD_1.CheckedChanged, value2
				End If
				Me.__optSPMBFPD_1 = value
				If Me.__optSPMBFPD_1 IsNot Nothing Then
					AddHandler Me.__optSPMBFPD_1.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optSPMBFPD_2 As RadioButton
			Get
				Return Me.__optSPMBFPD_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optSPMBFPD_2_CheckedChanged
				If Me.__optSPMBFPD_2 IsNot Nothing Then
					RemoveHandler Me.__optSPMBFPD_2.CheckedChanged, value2
				End If
				Me.__optSPMBFPD_2 = value
				If Me.__optSPMBFPD_2 IsNot Nothing Then
					AddHandler Me.__optSPMBFPD_2.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optFLPIP_0 As RadioButton
			Get
				Return Me.__optFLPIP_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optFLPIP_0_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me._optFLPIP_0_CheckedChanged
				If Me.__optFLPIP_0 IsNot Nothing Then
					RemoveHandler Me.__optFLPIP_0.EnabledChanged, value2
					RemoveHandler Me.__optFLPIP_0.CheckedChanged, value3
				End If
				Me.__optFLPIP_0 = value
				If Me.__optFLPIP_0 IsNot Nothing Then
					AddHandler Me.__optFLPIP_0.EnabledChanged, value2
					AddHandler Me.__optFLPIP_0.CheckedChanged, value3
				End If
			End Set
		End Property

		Public Overridable Property _optFLPIP_1 As RadioButton
			Get
				Return Me.__optFLPIP_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optFLPIP_1_CheckedChanged
				If Me.__optFLPIP_1 IsNot Nothing Then
					RemoveHandler Me.__optFLPIP_1.CheckedChanged, value2
				End If
				Me.__optFLPIP_1 = value
				If Me.__optFLPIP_1 IsNot Nothing Then
					AddHandler Me.__optFLPIP_1.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optFLPIP_4 As RadioButton
			Get
				Return Me.__optFLPIP_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optFLPIP_4_CheckedChanged
				If Me.__optFLPIP_4 IsNot Nothing Then
					RemoveHandler Me.__optFLPIP_4.CheckedChanged, value2
				End If
				Me.__optFLPIP_4 = value
				If Me.__optFLPIP_4 IsNot Nothing Then
					AddHandler Me.__optFLPIP_4.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optFLPIP_3 As RadioButton
			Get
				Return Me.__optFLPIP_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optFLPIP_3_CheckedChanged
				If Me.__optFLPIP_3 IsNot Nothing Then
					RemoveHandler Me.__optFLPIP_3.CheckedChanged, value2
				End If
				Me.__optFLPIP_3 = value
				If Me.__optFLPIP_3 IsNot Nothing Then
					AddHandler Me.__optFLPIP_3.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optFLPIP_2 As RadioButton
			Get
				Return Me.__optFLPIP_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optFLPIP_2_CheckedChanged
				If Me.__optFLPIP_2 IsNot Nothing Then
					RemoveHandler Me.__optFLPIP_2.CheckedChanged, value2
				End If
				Me.__optFLPIP_2 = value
				If Me.__optFLPIP_2 IsNot Nothing Then
					AddHandler Me.__optFLPIP_2.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtSPMBFPD As TextBox
			Get
				Return Me._txtSPMBFPD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtSPMBFPD_Enter
				Dim value3 As EventHandler = AddressOf Me.txtSPMBFPD_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtSPMBFPD_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtSPMBFPD_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtSPMBFPD_TextChanged
				Dim value7 As EventHandler = AddressOf Me.txtSPMBFPD_EnabledChanged
				If Me._txtSPMBFPD IsNot Nothing Then
					RemoveHandler Me._txtSPMBFPD.Enter, value2
					RemoveHandler Me._txtSPMBFPD.Leave, value3
					RemoveHandler Me._txtSPMBFPD.KeyPress, value4
					RemoveHandler Me._txtSPMBFPD.KeyDown, value5
					RemoveHandler Me._txtSPMBFPD.TextChanged, value6
					RemoveHandler Me._txtSPMBFPD.EnabledChanged, value7
				End If
				Me._txtSPMBFPD = value
				If Me._txtSPMBFPD IsNot Nothing Then
					AddHandler Me._txtSPMBFPD.Enter, value2
					AddHandler Me._txtSPMBFPD.Leave, value3
					AddHandler Me._txtSPMBFPD.KeyPress, value4
					AddHandler Me._txtSPMBFPD.KeyDown, value5
					AddHandler Me._txtSPMBFPD.TextChanged, value6
					AddHandler Me._txtSPMBFPD.EnabledChanged, value7
				End If
			End Set
		End Property

		Public Overridable Property _Label_3 As Label
			Get
				Return Me.__Label_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_3 = value
			End Set
		End Property

		Public Overridable Property txtTempProd As TextBox
			Get
				Return Me._txtTempProd
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTempProd = value
			End Set
		End Property

		Public Overridable Property txtTempPress As TextBox
			Get
				Return Me._txtTempPress
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTempPress = value
			End Set
		End Property

		Friend Overridable Property lblSPMBFPD_Disabled As Label
			Get
				Return Me._lblSPMBFPD_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSPMBFPD_Disabled = value
			End Set
		End Property

		Public Overridable Property _Label_SPMBFPD As Label
			Get
				Return Me.__Label_SPMBFPD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me._Label_SPMBFPD_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me._Label_SPMBFPD_TextChanged
				If Me.__Label_SPMBFPD IsNot Nothing Then
					RemoveHandler Me.__Label_SPMBFPD.EnabledChanged, value2
					RemoveHandler Me.__Label_SPMBFPD.TextChanged, value3
				End If
				Me.__Label_SPMBFPD = value
				If Me.__Label_SPMBFPD IsNot Nothing Then
					AddHandler Me.__Label_SPMBFPD.EnabledChanged, value2
					AddHandler Me.__Label_SPMBFPD.TextChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property lbl85 As Label
			Get
				Return Me._lbl85
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lbl85 = value
			End Set
		End Property

		Public Shared Property DefInstance As ProdInfo
			Get
				If ProdInfo.m_vb6FormDefInstance Is Nothing OrElse ProdInfo.m_vb6FormDefInstance.IsDisposed Then
					ProdInfo.m_InitializingDefInstance = True
					ProdInfo.m_vb6FormDefInstance = New ProdInfo()
					ProdInfo.m_InitializingDefInstance = False
				End If
				Return ProdInfo.m_vb6FormDefInstance
			End Get
			Set(value As ProdInfo)
				ProdInfo.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property bFormLoaded As Boolean
			Get
				Return Me.m_bFormLoaded
			End Get
			Set(value As Boolean)
				Me.m_bFormLoaded = value
			End Set
		End Property

		Public Property bReloadProdInfo As Boolean
			Get
				Return Me.m_bReloadProdInfo
			End Get
			Set(value As Boolean)
				Me.m_bReloadProdInfo = value
			End Set
		End Property

		Public Sub ActivateGrid(grd As UltraGrid, Col As Integer, Row As Integer)
			grd.Focus()
			grd.Rows(Row).Activate()
			grd.ActiveCell = grd.ActiveRow.Cells(Col)
		End Sub

		Private Sub Form_Closing(sender As Object, e As CancelEventArgs)
			Me.m_bClosing = True
			Dim flag As Boolean = Me.ValidateProdInfo(Me.bCancel, False)
			If Not Me.m_bClosing Or (Me.m_bClosing And Not flag And Not Me.bCancel) Then
				e.Cancel = True
				Return
			End If
			RSWIN_DESC.sCurrentFormName = ""
		End Sub

		Public Function CheckProdInfo() As Boolean
			Dim result As Boolean = False
			Dim text As String = "enter"
			Dim text2 As String = ""
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Me._optFLPIP_1.Checked And Strings.Len(Strings.Trim(Me.txtFLPIP.Text)) = 0 Then
				text2 = "fluid level"
				Me.txtFLPIP.Focus()
			ElseIf Me._optFLPIP_2.Checked And Strings.Len(Strings.Trim(Me.txtFLPIP.Text)) = 0 Then
				text2 = "pump intake pressure"
				Me.txtFLPIP.Focus()
			ElseIf Me.txtSPMBFPD.Visible And Strings.Len(Strings.Trim(Me.txtSPMBFPD.Text)) = 0 Then
				text2 = "pumping speed"
				Me.txtSPMBFPD.Focus()
			ElseIf rst.gbUseIPR And Me.txtMidPerfDepth.Visible And Strings.Len(Strings.Trim(Me.txtMidPerfDepth.Text)) = 0 Then
				text2 = "mid-perf. depth"
				Me.txtMidPerfDepth.Focus()
			ElseIf rst.gbUseIPR And Me.txtStaticBHPressure.Visible And Strings.Len(Strings.Trim(Me.txtStaticBHPressure.Text)) = 0 Then
				text2 = "static bottom hole pressure"
				Me.txtStaticBHPressure.Focus()
			ElseIf rst.gbUseIPR And Me.txtBubblePoint.Visible And Strings.Len(Strings.Trim(Me.txtBubblePoint.Text)) = 0 Then
				text2 = "bubble point pressure"
				Me.txtBubblePoint.Focus()
			End If
			If Strings.Len(text2) > 0 Then
				Dim sMsg As String = String.Concat(New String() { "Please ", text, " the ", text2, "." })
				Dim sMsgType As String = "Data Entry Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			ElseIf rst.gbUseIPR And rst.gnTestPoints = 0S Then
				Util.cErrmsg(107)
			Else
				Dim gbUseIPR As Boolean = rst.gbUseIPR
				If RSWIN_DESC.NewData(2) <> 0S Then
					RSWIN_DESC.NewData(2) = 0S
					ini.SaveDataValue("ProdInfo", True)
				End If
				result = True
			End If
			Return result
		End Function

		Private Sub ProdInfo_Validating(sender As Object, e As CancelEventArgs)
			Me.ValidateProdInfo(Me.bCancel, True)
		End Sub

		Public Function ValidateProdInfo(ByRef bCancel As Boolean, Optional bQuiet As Boolean = True) As Boolean
			Dim text As String = ""
			bCancel = False
			If Me.MyParentFrm Is Nothing Then
				Try
					Me.MyParentFrm = New RODSTAR()
					Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
				Catch ex As Exception
				End Try
			End If
			Dim result As Boolean
			If Me.MyParentFrm IsNot Nothing Then
				If Not Me.MyParentFrm.bClosing Then
					If Me.bTextChanged Then
						Try
							Dim rst As cRODSTAR = RSWIN_DESC.rst
							rst.gbProducingBelowBPP = Me.chkBelowBPP.Checked
							If Operators.CompareString(Me.txtFetkovichN.Text, "", False) <> 0 Then
								rst.FetkovichN = Convert.ToSingle(Me.txtFetkovichN.Text)
							Else
								rst.FetkovichN = 0F
							End If
							If Me._optFLPIP_0.Checked Then
								rst.giFluidLevelSource = 1S
							ElseIf Me._optFLPIP_1.Checked Then
								rst.giFluidLevelSource = 2S
							Else
								rst.giFluidLevelSource = 0S
							End If
							ini.SaveDataValue("FluidLevelSource", rst.giFluidLevelSource)
							Dim flag As Boolean = Me.CheckRequiredTextFields()
							Dim obj As Object
							If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Me._optSPMBFPD_1.Checked And RSWIN_DESC.rst.TargetBFPD < 10F Then
								Util.CheckLower(obj, 10F, 0, 147, 0, 0, True, text)
								If Not Me.bLowerTargetMsgShown Then
									MessageBox.Show(text)
									Me.bLowerTargetMsgShown = True
								End If
								Dim control As Control = Me.txtSPMBFPD
								Me.SetActiveControl(control)
								Me.txtSPMBFPD = CType(control, TextBox)
								flag = False
							End If
							If rst.giFluidLevelSource = 1S And (rst.FluidLevel < 0F Or Operators.CompareString(Me.txtFLPIP.Text, "", False) = 0) Then
								If bQuiet Then
									Me.DisplayProdInfoError("Please enter a value for Fluid Level", bCancel)
								End If
								If Not bCancel Then
									Dim control As Control = Me.txtFLPIP
									Me.SetActiveControl(control)
									Me.txtFLPIP = CType(control, TextBox)
									flag = False
								End If
							Else
								Dim obj2 As Object = rst.giFluidLevelSource = 1S
								Dim cRODSTAR As cRODSTAR = rst
								Dim obj3 As Object = cRODSTAR.FluidLevel
								Dim obj4 As Object = Util.CheckLower(obj3, 0F, -1, 105, 0, 0, True, text)
								cRODSTAR.FluidLevel = Conversions.ToSingle(obj3)
								If Conversions.ToBoolean(Operators.AndObject(obj2, Operators.NotObject(obj4))) Then
									If Not bCancel Then
										Dim control As Control = Me.txtFLPIP
										Me.SetActiveControl(control)
										Me.txtFLPIP = CType(control, TextBox)
										flag = False
									End If
								ElseIf Conversions.ToBoolean(Operators.AndObject(rst.giFluidLevelSource = 1S, Operators.NotObject(Util.CheckUpper(obj, RSWIN_DESC.rst.PumpDepth, -1, 103, 0, 0, True, text)))) AndAlso Not bCancel Then
									Dim control As Control = Me.txtFLPIP
									Me.SetActiveControl(control)
									Me.txtFLPIP = CType(control, TextBox)
									flag = False
								End If
							End If
							If Not flag And Not bQuiet Then
								If rst.giFluidLevelSource = 2S And (rst.PumpIntakePressure < 0F Or Operators.CompareString(Me.txtFLPIP.Text, "", False) = 0) Then
									Me.DisplayProdInfoError("Please enter a value for Fluid Level", bCancel)
									If Not bCancel Then
										Dim control As Control = Me.txtFLPIP
										Me.SetActiveControl(control)
										Me.txtFLPIP = CType(control, TextBox)
										flag = False
									End If
								ElseIf(If((-If(((rst.TargetBFPD = 0F Or Operators.CompareString(Me.txtSPMBFPD.Text, "", False) = 0) > False), 1S, 0S)), 1S, 0S) And Not rst.SPMEntered And If((-If((Not rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
									Me.DisplayProdInfoError("Please enter a value for Target Production", bCancel)
									If Not bCancel Then
										Dim control As Control = Me.txtSPMBFPD
										Me.SetActiveControl(control)
										Me.txtSPMBFPD = CType(control, TextBox)
										flag = False
									End If
								ElseIf(If((-If(((rst.SPM = 0F Or Operators.CompareString(Me.txtSPMBFPD.Text, "", False) = 0) > False), 1S, 0S)), 1S, 0S) And rst.SPMEntered And If((-If((Not rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
									Me.DisplayProdInfoError("Please enter a value for Pumping speed (spm)", bCancel)
									If Not bCancel Then
										Dim control As Control = Me.txtSPMBFPD
										Me.SetActiveControl(control)
										Me.txtSPMBFPD = CType(control, TextBox)
										flag = False
									End If
								ElseIf rst.gbUseIPR Then
									Me.GetTestPoints()
									If rst.FetkovichN = 0F And rst.giIPRMethod = 0S Then
										Me.DisplayProdInfoError("Please enter a value for 'n' (Fetkovich corr.). If you do not have IPR information, please click on the 'IPR Data' command button to continue without using IPR Data.", bCancel)
										If Not bCancel Then
											Dim control As Control = Me.txtFetkovichN
											Me.SetActiveControl(control)
											Me.txtFetkovichN = CType(control, TextBox)
											flag = False
										End If
									ElseIf rst.giIPRMethod = -1S Then
										Me.DisplayProdInfoError("Please select IPR calculation method. If you do not have IPR information, please click on the 'IPR Data' command button to continue without using IPR Data.", bCancel)
										If Not bCancel Then
											Dim control As Control = Me.txtFetkovichN
											Me.SetActiveControl(control)
											Me.txtFetkovichN = CType(control, TextBox)
											flag = False
										End If
									ElseIf rst.MidPerfDepth = 0F Then
										Me.DisplayProdInfoError("Please enter a value for Mid-perf. depth. If you do not have this information, please click on 'IPR Data' command button to continue without using IPR Data.", bCancel)
										If Not bCancel Then
											Dim control As Control = Me.txtMidPerfDepth
											Me.SetActiveControl(control)
											Me.txtMidPerfDepth = CType(control, TextBox)
											flag = False
										End If
									ElseIf rst.StaticBHPressure = 0F Then
										Me.DisplayProdInfoError("Please enter a value for Static b'hole pressure. If you do not have this information, please click on 'IPR Data' command button to continue without using IPR Data.", bCancel)
										If Not bCancel Then
											Dim control As Control = Me.txtStaticBHPressure
											Me.SetActiveControl(control)
											Me.txtStaticBHPressure = CType(control, TextBox)
											flag = False
										End If
									ElseIf rst.BubblePoint = 0F Then
										Me.DisplayProdInfoError("Please enter a value for Bubble point pressure. If you do not have this information, please click on 'IPR Data' command button to continue without using IPR Data.", bCancel)
										If Not bCancel Then
											Dim control As Control = Me.txtBubblePoint
											Me.SetActiveControl(control)
											Me.txtBubblePoint = CType(control, TextBox)
											flag = False
										End If
									ElseIf rst.gnTestPoints = 0S Then
										Me.DisplayProdInfoError("Please enter at least one pressure test point. If you do not have this information, please click on 'IPR Data' command button to continue without using IPR Data.", bCancel)
										If Not bCancel Then
											Dim control As Control = Me.ulgTestPoints
											Me.SetActiveControl(control)
											Me.ulgTestPoints = CType(control, UltraGrid)
											flag = False
										End If
									Else
										Dim obj5 As Object = rst.giIPRMethod = 0S
										Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
										Dim obj3 As Object = cRODSTAR.FetkovichN
										Dim lowerBound As Single = 0.5F
										Dim inclusive As Integer = -1
										Dim errnum As Integer = 22
										Dim useMetric As Integer = 0
										Dim canadianIsMetric As Integer = 0
										Dim bQuiet2 As Boolean = True
										Dim text2 As String = ""
										Dim obj6 As Object = Util.CheckLower(obj3, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet2, text2)
										cRODSTAR.FetkovichN = Conversions.ToSingle(obj3)
										If Conversions.ToBoolean(Operators.AndObject(obj5, Operators.NotObject(obj6))) Then
											If Not RSWIN_DESC.rst.gbCalcFetkovichN Then
												Me.DisplayProdInfoError("Value for 'n' (Fetkovich corr.) must be between 0.5 and 1.0", bCancel)
												If Not bCancel Then
													Dim control As Control = Me.txtFetkovichN
													Me.SetActiveControl(control)
													Me.txtFetkovichN = CType(control, TextBox)
													flag = False
												End If
											Else
												Me.DisplayProdInfoError("Calculated 'n' (Fetkovich corr.) is less than 0.5. Please check Mid-perf. depth, Static b'hole pressure, Bubble point pressure, and Production test point data.", bCancel)
												If Not bCancel Then
													Dim control As Control = Me.txtMidPerfDepth
													Me.SetActiveControl(control)
													Me.txtMidPerfDepth = CType(control, TextBox)
													flag = False
												End If
											End If
										Else
											Dim obj7 As Object = rst.giIPRMethod = 0S
											cRODSTAR = RSWIN_DESC.rst
											obj3 = cRODSTAR.FetkovichN
											Dim upperBound As Single = 1F
											Dim inclusive2 As Integer = -1
											Dim errnum2 As Integer = 22
											Dim useMetric2 As Integer = 0
											Dim canadianIsMetric2 As Integer = 0
											Dim bQuiet3 As Boolean = True
											text2 = ""
											Dim obj8 As Object = Util.CheckUpper(obj3, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet3, text2)
											cRODSTAR.FetkovichN = Conversions.ToSingle(obj3)
											If Conversions.ToBoolean(Operators.AndObject(obj7, Operators.NotObject(obj8))) Then
												If Not RSWIN_DESC.rst.gbCalcFetkovichN Then
													Me.DisplayProdInfoError("Value for 'n' (Fetkovich corr.) must be between 0.5 and 1.0", bCancel)
													If Not bCancel Then
														Dim control As Control = Me.txtFetkovichN
														Me.SetActiveControl(control)
														Me.txtFetkovichN = CType(control, TextBox)
														flag = False
													End If
												Else
													Me.DisplayProdInfoError("Calculated 'n' (Fetkovich corr.) is greater than 1.0. Please check Mid-perf. depth, Static b'hole pressure, Bubble point pressure, and Production test point data.", bCancel)
													If Not bCancel Then
														Dim control As Control = Me.txtMidPerfDepth
														Me.SetActiveControl(control)
														Me.txtMidPerfDepth = CType(control, TextBox)
														flag = False
													End If
												End If
											End If
										End If
									End If
								End If
							End If
							RSWIN_DESC.frmMain.ToolbarButtonSetState(16, flag)
							If flag AndAlso Not bQuiet Then
								Me.bValidated = True
							End If
							Return flag
						Catch ex2 As Exception
							Dim sMsg As String = "Error in ProdInfo Validation: " + ex2.Message
							Dim sMsgType As String = ""
							Dim bClosing As Boolean = False
							Dim dialogResult As DialogResult = DialogResult.OK
							Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
							Return result
						End Try
					End If
					Return True
				End If
				Return True
			End If
			Return result
		End Function

		Public Function CheckValid(ByRef Value As Object, sUnit As String, bShowMessage As Boolean) As Boolean
			Dim result As Boolean
			Try
				result = True
				If Not Util.ValidNumber(Conversions.ToString(Value), If((-If((bShowMessage > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					result = False
				ElseIf Strings.Len(Strings.Trim(Conversions.ToString(Value))) > 0 AndAlso RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					Dim obj As Object = RuntimeHelpers.GetObjectValue(Value)
					Dim num As Single = Conversions.ToSingle(obj)
					CtrlUI.ConvertValue(num, sUnit, True)
					obj = num
					Value = RuntimeHelpers.GetObjectValue(obj)
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in CheckValid: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
			Return result
		End Function

		Private Sub cboIPRMethod_Click_1(iListIndex As Short, Clicked As Boolean)
			If Me.cboIPRMethod.SelectedIndex <> CInt(iListIndex) Then
				Me.cboIPRMethod.SelectedIndex = CInt(iListIndex)
			End If
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.giIPRMethod = iListIndex
			If rst.giIPRMethod = 0S Then
				Me.chkCalculateN.Enabled = True
				Me.chkCalculateN_Click_1(rst.gbCalcFetkovichN, False)
			Else
				Me.chkCalculateN.Enabled = False
				Me.chkCalculateN_Click_1(False, False)
			End If
			If Clicked Then
				ini.SaveDataValue("IPRMethod", rst.giIPRMethod)
			End If
		End Sub

		Private Sub cboTestPoints_Click_1(ListIndex As Short, Clicked As Boolean)
		End Sub

		Private Sub cboTestPointType_Click_1(iIPRType As Short, Clicked As Boolean)
			Me.TestPointType = CInt(iIPRType)
			Dim cboTestPointType As ComboBox = Me.cboTestPointType
			Dim flag As Boolean = False
			If cboTestPointType.SelectedIndex < 0 Then
				flag = True
			ElseIf Me.cboTestPointType.SelectedIndex <> CInt(iIPRType) Then
				flag = True
			End If
			If flag Then
				CtrlUI.SetIndexByItemData(Me.cboTestPointType, CLng(iIPRType), True)
			End If
			Me.ResortGrid()
		End Sub

		Private Function CheckIPR(bTestPoint As Boolean, Optional bShowMsg As Boolean = False) As Boolean
			Dim result As Boolean
			Dim flag As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Me.bLoadingForm Then
					Return result
				End If
				If Not rst.gbUseIPR Then
					flag = False
				Else
					flag = (rst.MidPerfDepth >= 0F)
					flag = flag And (rst.StaticBHPressure > 0F)
					flag = flag And (rst.gbProducingBelowBPP Or rst.BubblePoint > 0F)
					flag = flag And (rst.gnTestPoints >= 1S)
					Dim num As Short = 1S
					Dim gnTestPoints As Short = rst.gnTestPoints
					For num2 As Short = num To gnTestPoints
						flag = flag And (rst.TestPoints(CInt(num2)).Pintake >= 0F Or rst.TestPoints(CInt(num2)).Pwf >= 0F)
						flag = flag And (rst.TestPoints(CInt(num2)).Production > 0F)
					Next
					If flag Then
						Dim num3 As Short = 1S
						Dim gnTestPoints2 As Short = rst.gnTestPoints
						For num2 As Short = num3 To gnTestPoints2
							If RSWIN_DESC.rst.TestPoints(CInt(num2)).bPIEntered <> 0S Then
								RSWIN_DESC.rst.TestPoints(CInt(num2)).Pwf = IPR.iprPwfFromPip(RSWIN_DESC.rst.TestPoints(CInt(num2)).Pintake)
							Else
								RSWIN_DESC.rst.TestPoints(CInt(num2)).Pintake = IPR.iprPipFromPwf(RSWIN_DESC.rst.TestPoints(CInt(num2)).Pwf)
							End If
							Dim num4 As Short = 0S
							If RSWIN_DESC.rst.TestPoints(CInt(num2)).Pwf >= rst.StaticBHPressure Then
								If bTestPoint Then
									If RSWIN_DESC.rst.TestPoints(CInt(num2)).bPIEntered <> 0S Then
										num4 = 107S
									Else
										num4 = 110S
									End If
								End If
								flag = False
							ElseIf CDbl(RSWIN_DESC.rst.TestPoints(CInt(num2)).Pintake) < CDbl(rst.CasingPressure) + 14.7 Then
								If bTestPoint Then
									If RSWIN_DESC.rst.TestPoints(CInt(num2)).bPIEntered <> 0S Then
										num4 = 106S
									Else
										num4 = 109S
									End If
								End If
								flag = False
							End If
							If num4 <> 0S Then
								Dim text As String
								Util.LoadMessage(CInt(num4), text)
								Util.ApplyNumber(CSng(num2), text)
								If Strings.InStr(text, "14.7 psi", CompareMethod.Binary) > 0 Then
									Dim num5 As Single = Conversions.ToSingle(Operators.MultiplyObject(CDbl(RSWIN_DESC.rst.CasingPressure) + 14.7, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, RSWIN_DESC.PSI__KPA, 1)))
									Dim text2 As String = "####.#"
									Dim newValue As String = Conversions.ToString(Operators.ConcatenateObject(Util.Format(num5, text2) + " ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, "kPa", "psi")))
									text = text.Replace("14.7 psi", newValue)
								End If
								Util.Errmsg(text)
							End If
						Next
					End If
					If flag Then
						Dim flag2 As Boolean = False
						Dim num6 As Short = 1S
						Dim num7 As Short = rst.gnTestPoints - 1S
						For num2 As Short = num6 To num7
							' The following expression was wrapped in a checked-expression
							Dim num8 As Single = rst.TestPoints(CInt(num2)).Pwf - rst.TestPoints(CInt((num2 + 1S))).Pwf
							If num8 < 0F Then
								If rst.TestPoints(CInt(num2)).Production <= rst.TestPoints(CInt((num2 + 1S))).Production Then
									flag = False
								End If
							ElseIf num8 > 0F Then
								If rst.TestPoints(CInt(num2)).Production >= rst.TestPoints(CInt((num2 + 1S))).Production Then
									flag = False
								End If
							Else
								flag = False
								If rst.TestPoints(CInt(num2)).Production = rst.TestPoints(CInt((num2 + 1S))).Production Then
									flag2 = True
								End If
							End If
							If Not flag Then
								Exit For
							End If
						Next
						If Not flag AndAlso bTestPoint Then
							Util.Errmsg(Me.sDataInconsistent)
						ElseIf Not flag AndAlso flag2 Then
							Util.Errmsg(Me.sDataDuplicate)
						End If
					End If
				End If
				If Not flag Then
					Me._lblMaxProduction_0.Text = ""
					Me._lblMaxProduction_1.Text = ""
					Me._lblMaxProduction_2.Text = ""
					Me.cmdIPRPlot.Enabled = False
					If rst.gbCalcFetkovichN Then
						rst.FetkovichN = -1F
					End If
				Else
					IPR.iprSetup()
					If(rst.giIPRMethod = 0S And rst.gbCalcFetkovichN) AndAlso bShowMsg Then
						Me.CheckCalculatedFetkovich(bShowMsg)
					End If
					Dim num9 As Single = IPR.iprPwfFromPip(rst.CasingPressure)
					Dim lblMaxProduction_ As Label = Me._lblMaxProduction_0
					Dim num10 As Single = CtrlUI.ConvertUnits(IPR.iprProductionFromPwf(num9), 0)
					Dim text2 As String = "###.##"
					lblMaxProduction_.Text = Util.Format(num10, text2)
					Dim lblMaxProduction_2 As Label = Me._lblMaxProduction_1
					num10 = CtrlUI.ConvertUnits(rst.WaterPI * (rst.StaticBHPressure - num9), 0)
					text2 = "###.##"
					lblMaxProduction_2.Text = Util.Format(num10, text2)
					Dim lblMaxProduction_3 As Label = Me._lblMaxProduction_2
					num10 = CtrlUI.ConvertUnits(IPR.iprProductionFromPwf(num9) + rst.WaterPI * (rst.StaticBHPressure - num9), 0)
					text2 = "###.##"
					lblMaxProduction_3.Text = Util.Format(num10, text2)
					Me.cmdIPRPlot.Enabled = True
					If Not rst.SPMEntered <> 0S Then
						If rst.gbCalcPumpIntakePressure Then
							rst.PumpIntakePressure = IPR.iprPipFromPwf(IPR.iprPwfFromFluidProduction(rst.TargetBFPD))
						ElseIf rst.gbCalcTargetBFPD Then
							If rst.FluidLevelEntered Then
								rst.PumpIntakePressure = CSng((0.433 * CDbl(rst.OilSPGR) * CDbl((rst.PumpDepth - rst.FluidLevel)) + CDbl(rst.CasingPressure) + 14.7))
							End If
							Dim num11 As Single = IPR.iprPwfFromPip(rst.PumpIntakePressure)
							If num11 <= rst.StaticBHPressure Then
								rst.TargetBFPD = IPR.iprProductionFromPwf(num11) + rst.WaterPI * (rst.StaticBHPressure - num11)
							End If
						End If
					End If
				End If
			Catch ex As Exception
			End Try
			result = flag
			Return result
		End Function

		Private Sub chkBelowBPP_Click_1(Checked As Boolean, Clicked As Boolean)
			If Me.$STATIC$chkBelowBPP_Click_1$202122$busy Then
				Return
			End If
			If Me.chkBelowBPP.Checked <> Checked Then
				Me.$STATIC$chkBelowBPP_Click_1$202122$busy = True
				Me.chkBelowBPP.Checked = Checked
				Me.$STATIC$chkBelowBPP_Click_1$202122$busy = False
			End If
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.gbProducingBelowBPP = Checked
			ini.SaveDataValue("ProducingBelowBPP", rst.gbProducingBelowBPP)
			Me.txtBubblePoint.Enabled = Not rst.gbProducingBelowBPP
			Me.txtBubblePointEnabledChanged()
			If Me.ActiveControl Is Me.chkBelowBPP AndAlso (Me.txtBubblePoint.Enabled And Operators.CompareString(Me.txtBubblePoint.Text, "", False) = 0) Then
				Me.txtBubblePoint.Focus()
			End If
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.chkBelowBPP)
		End Sub

		Private Sub chkCalculateN_Click_1(Checked As Boolean, Clicked As Boolean)
			If Me.chkCalculateN.Checked <> Checked Then
				Me.chkCalculateN.Checked = Checked
			End If
			Dim flag As Boolean = Not Checked
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Clicked Then
				rst.gbCalcFetkovichN = Checked
				ini.SaveDataValue("CalcFetkovichN", rst.gbCalcFetkovichN)
				If rst.giIPRMethod = 0S Then
					If Not Checked Then
						Dim text As String
						Util.LoadMessage(212, text)
						Dim msg As String = text
						Dim bDefaultYes As Boolean = False
						Dim flag2 As Boolean = False
						If Util.YesNo(msg, bDefaultYes, flag2) Then
							rst.gbCalcFetkovichN = True
							Me.GetTestPoints()
							Dim flag3 As Boolean = Me.CheckIPR(False, False)
							rst.gbCalcFetkovichN = False
							If flag3 Then
								Dim txtFetkovichN As TextBox = Me.txtFetkovichN
								Dim cRODSTAR As cRODSTAR = rst
								Dim fetkovichN As Single = cRODSTAR.FetkovichN
								Dim text2 As String = "0.000"
								Dim text3 As String = Util.Format(fetkovichN, text2)
								cRODSTAR.FetkovichN = fetkovichN
								txtFetkovichN.Text = text3
							Else
								Me.txtFetkovichN.Text = Convert.ToString(1)
							End If
						Else
							Me.chkCalculateN_Click_1(True, False)
							rst.gbCalcFetkovichN = True
							flag = False
						End If
					Else
						Dim flag3 As Boolean = Me.CheckIPR(False, False)
					End If
				End If
			End If
			Me.txtFetkovichN.Enabled = (flag And rst.giIPRMethod = 0S)
			Me.txtFetkovichNEnabledChanged()
		End Sub

		Private Sub chkIPRData_Click_1(ByRef Checked As Boolean, Clicked As Boolean)
			If Me.chkIPRData.Checked <> Checked Then
				Me.chkIPRData.Checked = Checked
			End If
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.gbUseIPR = Checked
			ini.SaveDataValue("UseIPR", rst.gbUseIPR)
			Me.ShowIPRData(rst.gbUseIPR)
		End Sub

		Public Function Grid_CountCols(ByRef grd As UltraGrid) As Short
			' The following expression was wrapped in a checked-expression
			Return CShort(grd.DisplayLayout.Bands(0).Columns.Count)
		End Function

		Public Function Grid_CountRows(ByRef grd As UltraGrid) As Short
			Dim num As Short = 0S
			Dim ultraGridRow As UltraGridRow = grd.GetRow(ChildRow.First)
			While ultraGridRow IsNot Nothing
				num += 1S
				If ultraGridRow.HasNextSibling() Then
					ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
				Else
					ultraGridRow = Nothing
				End If
			End While
			Return num
		End Function

		Private Sub GetTestPoints()
			If Me.bLoadingForm Then
				Return
			End If
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.gnTestPoints = CShort(Me.mdsTestPoints.Tables(0).Rows.Count)
			If rst.gnTestPoints = 0S Then
				rst.TestPoints = Nothing
				Return
			End If
			If rst.TestPoints Is Nothing Then
				Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(CInt((rst.gnTestPoints + 1S)) - 1) {}
				rst.TestPoints = testPoints
			ElseIf Information.UBound(rst.TestPoints, 1) <> CInt(rst.gnTestPoints) Then
				Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(CInt((rst.gnTestPoints + 1S)) - 1) {}
				rst.TestPoints = testPoints
			End If
			Dim cboTestPointType As ComboBox = Me.cboTestPointType
			If cboTestPointType.SelectedIndex = -1 Then
				cboTestPointType.SelectedIndex = 1
			End If
			Dim flag As Boolean = Support.GetItemData(Me.cboTestPointType, cboTestPointType.SelectedIndex) = 0
			Dim rst2 As cRODSTAR = RSWIN_DESC.rst
			Dim num As Integer = 1
			Dim gnTestPoints As Integer = CInt(rst2.gnTestPoints)
			For i As Integer = num To gnTestPoints
				Dim dataRow As DataRow = Me.mdsTestPoints.Tables(0).Rows(i - 1)
				Dim num2 As Single
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("IPRPressure"))) Then
					Me.txtTempPress.Text = "0"
					num2 = 0F
				Else
					Dim num3 As Single = Conversions.ToSingle(dataRow("IPRPressure"))
					Me.txtTempPress.Text = num3.ToString()
					If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
						Me.txtTempPress.Tag = "pmm"
						If Versioned.IsNumeric(Me.txtTempPress.Text) Then
							Dim textBox As TextBox = Me.txtTempPress
							Dim bValidIfEmpty As Short = 0S
							Dim bShowMessage As Short = 0S
							Dim obj As Object = num2
							Dim num4 As Integer = CInt(Me.CheckValid(textBox, bValidIfEmpty, bShowMessage, obj))
							num2 = Conversions.ToSingle(obj)
							Me.txtTempPress = textBox
							Dim flag2 As Boolean = num4 <> 0
						Else
							num2 = 0F
						End If
					Else
						num2 = num3
					End If
				End If
				Dim num6 As Single
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("IPRProduction"))) Then
					Dim num5 As Single = Conversions.ToSingle(dataRow("IPRProduction"))
					Me.txtTempProd.Text = num5.ToString()
					If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
						Me.txtTempProd.Tag = "bmm"
						If Versioned.IsNumeric(Me.txtTempProd.Text) Then
							Dim textBox As TextBox = Me.txtTempProd
							Dim bValidIfEmpty2 As Short = 0S
							Dim bShowMessage2 As Short = 0S
							Dim obj As Object = num6
							Dim num7 As Integer = CInt(Me.CheckValid(textBox, bValidIfEmpty2, bShowMessage2, obj))
							num6 = Conversions.ToSingle(obj)
							Me.txtTempProd = textBox
							Dim flag3 As Boolean = num7 <> 0
						Else
							num6 = 0F
						End If
					Else
						num6 = num5
					End If
				Else
					Me.txtTempProd.Text = "0"
					num6 = 0F
				End If
				If Not flag Then
					rst2.TestPoints(i).bPIEntered = 0S
					rst2.TestPoints(i).Pwf = num2
				Else
					rst2.TestPoints(i).bPIEntered = -1S
					rst2.TestPoints(i).Pintake = num2
				End If
				rst2.TestPoints(i).Production = num6
			Next
			Try
				RSWIN_DESC.frmMain.ToolbarButtonSetState(16, Me.CheckRequiredTextFields())
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTestPoints_Initialize()
		End Sub

		Private Sub InitTestPointGrid()
			If Me.ulgTestPoints.DataSource IsNot Nothing Then
				Return
			End If
			Me.CreateDataSet()
			Me.AddIPRRow(DBNull.Value, DBNull.Value)
			Dim ulgTestPoints As UltraGrid = Me.ulgTestPoints
			ulgTestPoints.DataSource = Me.mdsTestPoints
			ulgTestPoints.Rows.Refresh(RefreshRow.FireInitializeRow, True)
			Me.cboTestPointType.Items.Clear()
			Me.cboTestPointType.Items.Add(Me.sMidPerforation)
			Me.cboTestPointType.Items.Add(Me.sPumpIntake)
			Support.SetItemData(Me.cboTestPointType, 0, 1)
			Support.SetItemString(Me.cboTestPointType, 0, Me.sMidPerforation)
			Support.SetItemData(Me.cboTestPointType, 1, 0)
			Support.SetItemString(Me.cboTestPointType, 1, Me.sPumpIntake)
			Me.cboTestPointType.SelectedIndex = 1
		End Sub

		Private Sub LoadTestPointGrid()
			Try
				If Me.ulgTestPoints.DataSource Is Nothing Then
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Me.CreateDataSet()
					If Information.UBound(rst.TestPoints, 1) = 0 Then
						rst.gnTestPoints = 0S
					End If
					Dim num As Short = 1S
					Dim gnTestPoints As Short = rst.gnTestPoints
					For num2 As Short = num To gnTestPoints
						If rst.TestPoints(CInt(num2)).bPIEntered <> 0S Then
							Me.TestPointType = 1
						Else
							Me.TestPointType = 0
						End If
						If rst.TestPoints(CInt(num2)).bPIEntered <> 0S Then
							Me.AddIPRRow(rst.TestPoints(CInt(num2)).Pintake, rst.TestPoints(CInt(num2)).Production)
						Else
							Me.AddIPRRow(rst.TestPoints(CInt(num2)).Pwf, rst.TestPoints(CInt(num2)).Production)
						End If
					Next
					Me.cboTestPointType.Items.Clear()
					Me.cboTestPointType.Items.Add(Me.sMidPerforation)
					Me.cboTestPointType.Items.Add(Me.sPumpIntake)
					Support.SetItemData(Me.cboTestPointType, 0, 1)
					Support.SetItemString(Me.cboTestPointType, 0, Me.sMidPerforation)
					Support.SetItemData(Me.cboTestPointType, 1, 0)
					Support.SetItemString(Me.cboTestPointType, 1, Me.sPumpIntake)
					Me.cboTestPointType.SelectedIndex = Me.TestPointType
					Dim ulgTestPoints As UltraGrid = Me.ulgTestPoints
					ulgTestPoints.DataSource = Me.mdsTestPoints
					ulgTestPoints.Rows.Refresh(RefreshRow.FireInitializeRow, True)
					Me.chkIPRData.Checked = RSWIN_DESC.rst.gbUseIPR
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub EnableFluidInertia()
			If Not MImpred.FluidInertiaPossible() Then
				RSWIN_DESC.rst.IncludeFluidInertia = 0S
			End If
		End Sub

		Public Sub InitProdInfo()
			RSWIN_DESC.rst.gbCalcPumpIntakePressure = Conversions.ToBoolean(ini.GetDataValue("CalcPumpIntakePressure", 11, False, False))
			RSWIN_DESC.rst.FluidLevelEntered = Conversions.ToBoolean(ini.GetDataValue("FluidLevelEntered", 11, False, True))
			Dim obj As Object
			If RSWIN_DESC.rst.gbCalcPumpCondition Then
				Me.SetOptFLPIPTag(0, "")
				Me.SetOptFLPIPTag(1, "")
				Me.optFLPIP_Click_1(2, -1, False)
			ElseIf RSWIN_DESC.rst.gbCalcPumpIntakePressure Then
				Me.SetOptFLPIPTag(0, "")
				Me.SetOptFLPIPTag(1, "")
				Me.txtFLPIP.Text = ""
				Me.optFLPIP_Click_1(4, -1, False)
			ElseIf RSWIN_DESC.rst.FluidLevelEntered Then
				RSWIN_DESC.rst.FluidLevel = Conversions.ToSingle(ini.GetDataValue("FluidLevel", 4, False, RSWIN_DESC.rst.PumpDepth))
				If RSWIN_DESC.rst.FluidLevel > RSWIN_DESC.rst.PumpDepth Then
					RSWIN_DESC.rst.FluidLevel = RSWIN_DESC.rst.PumpDepth
				End If
				Me.SetOptFLPIPTag(0, RSWIN_DESC.rst.FluidLevel.ToString())
				Me.SetOptFLPIPTag(1, "")
				If RSWIN_DESC.rst.PumpCondition = 2S Then
					Me.optFLPIP_Click_1(3, -1, False)
				Else
					Me.optFLPIP_Click_1(0, -1, False)
				End If
			Else
				obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpIntakePressure", 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.rst.PumpIntakePressure = Conversions.ToSingle(obj)
				Else
					RSWIN_DESC.rst.PumpIntakePressure = 0F
				End If
				Me.SetOptFLPIPTag(1, RSWIN_DESC.rst.PumpIntakePressure.ToString())
				Me.optFLPIP_Click_1(1, -1, False)
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("FluidLevelSource", 3, False, 0))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				Me._optFLPIP_0.Checked = False
				Me._optFLPIP_1.Checked = False
				RSWIN_DESC.rst.giFluidLevelSource = 0S
			ElseIf Operators.ConditionalCompareObjectEqual(obj, 1, False) Then
				Me._optFLPIP_0.Checked = True
				RSWIN_DESC.rst.giFluidLevelSource = 1S
			ElseIf Operators.ConditionalCompareObjectEqual(obj, 2, False) Then
				Me._optFLPIP_1.Checked = True
				RSWIN_DESC.rst.giFluidLevelSource = 2S
			ElseIf Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
				RSWIN_DESC.rst.giFluidLevelSource = 0S
				Me._optFLPIP_0.Checked = False
				Me._optFLPIP_1.Checked = False
			End If
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				cRODSTAR.giFluidLevelSource = 0S
			Else
				cRODSTAR.giFluidLevelSource = Conversions.ToShort(obj)
				Select Case cRODSTAR.giFluidLevelSource
					Case 1S
						Me._optFLPIP_0.Checked = True
						obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("FluidLevel", 4, False, DBNull.Value))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							cRODSTAR.FluidLevel = Conversions.ToSingle(obj)
						End If
					Case 2S
						Me._optFLPIP_1.Checked = True
						obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpIntakePressure", 4, False, DBNull.Value))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							cRODSTAR.PumpIntakePressure = Conversions.ToSingle(obj)
						End If
				End Select
			End If
			cRODSTAR.SPMEntered = Conversions.ToShort(ini.GetDataValue("SPMEntered", 11, False, True))
			cRODSTAR.gbCalcTargetBFPD = Conversions.ToBoolean(ini.GetDataValue("CalcTargetBFPD", 11, False, False))
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpingSpeed", 4, True, DBNull.Value))
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				cRODSTAR.SPM = Conversions.ToSingle(obj)
				Me.txtSPMBFPD.Tag = ""
				Me.txtSPMBFPD.Text = cRODSTAR.SPM.ToString()
			Else
				cRODSTAR.SPM = 0F
				Me.txtSPMBFPD.Tag = ""
				Me.txtSPMBFPD.Text = cRODSTAR.SPM.ToString()
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TargetBFPD", 4, False, DBNull.Value))
			If(cRODSTAR.SPMEntered Or If((-If(((cRODSTAR.PumpCondition <> 1S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				Me.txtSPMBFPD.Tag = ""
				Me.txtSPMBFPD.Text = Conversions.ToString(Interaction.IIf((cRODSTAR.SPMEntered And If((-If((cRODSTAR.SPM > 0F > False), 1S, 0S)), 1S, 0S)) <> 0S, cRODSTAR.SPM.ToString(), ""))
				Me.optSPMBFPD_Click_1(0, -1, False)
			ElseIf Not cRODSTAR.gbCalcTargetBFPD Then
				Me._optSPMBFPD_0.Tag = RuntimeHelpers.GetObjectValue(Interaction.IIf(cRODSTAR.SPM > 0F, Convert.ToString(cRODSTAR.SPM), ""))
				If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
					cRODSTAR.TargetBFPD = Conversions.ToSingle(obj)
					Me.txtSPMBFPD.Tag = "bem"
					Me.txtSPMBFPD.Text = cRODSTAR.TargetBFPD.ToString()
				Else
					Me.txtSPMBFPD.Tag = ""
					Me.txtSPMBFPD.Text = ""
				End If
				Me.optSPMBFPD_Click_1(1, -1, False)
			Else
				Me.txtSPMBFPD.Text = Conversions.ToString(Interaction.IIf(cRODSTAR.SPM > 0F, Convert.ToString(cRODSTAR.SPM), ""))
				Me.optSPMBFPD_Click_1(2, -1, False)
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpingSpeed", 4, True, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) AndAlso cRODSTAR.SPM > 0F Then
				obj = cRODSTAR.SPM
			End If
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) And Me.GetOptSPMBFPD(0) Then
				If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
					Me.txtSPMBFPD.Text = ""
				Else
					cRODSTAR.SPM = Conversions.ToSingle(obj)
					Me.txtSPMBFPD.Tag = ""
					Me.txtSPMBFPD.Text = Conversions.ToString(cRODSTAR.SPM)
				End If
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TargetBFPD", 4, False, 0))
			cRODSTAR.gbUseIPR = Conversions.ToBoolean(ini.GetDataValue("UseIPR", 11, False, False))
			If cRODSTAR.gbUseIPR Then
				Me.ulgTestPoints.DataSource = Nothing
				Me.LoadTestPointGrid()
			Else
				Me.ulgTestPoints.DataSource = Nothing
				Me.InitTestPointGrid()
				Me.chkIPRData.Checked = False
				Me.chkIPRChanged(False, False)
			End If
			cRODSTAR.gbCalcFetkovichN = Conversions.ToBoolean(ini.GetDataValue("CalcFetkovichN", 11, False, True))
			cRODSTAR.FetkovichN = Conversions.ToSingle(ini.GetDataValue("FetkovichN", 4, False, -1))
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("IPRMethod", 3, False, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				obj = RuntimeHelpers.GetObjectValue(ini.GetListDefault("IPRMethod", 0, 1))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					obj = 1
				End If
			End If
			cRODSTAR.giIPRMethod = Conversions.ToShort(obj)
			Me.cboIPRMethod_Click_1(cRODSTAR.giIPRMethod, False)
			Me.txtMidPerfDepth_TextChanged(Me.txtMidPerfDepth, New EventArgs())
			Me.txtStaticBHPressure_TextChanged(Me.txtStaticBHPressure, New EventArgs())
			Me.txtBubblePoint_TextChanged(Me.txtBubblePoint, New EventArgs())
			cRODSTAR.MidPerfDepth = Conversions.ToSingle(ini.GetDataValue("MidPerfDepth", 4, False, 0))
			cRODSTAR.StaticBHPressure = Conversions.ToSingle(ini.GetDataValue("StaticBHPressure", 4, False, 0))
			cRODSTAR.BubblePoint = Conversions.ToSingle(ini.GetDataValue("BubblePoint", 4, False, 0))
			cRODSTAR.gbProducingBelowBPP = Conversions.ToBoolean(ini.GetDataValue("ProducingBelowBPP", 11, False, False))
			If cRODSTAR.MidPerfDepth > 0F Then
				Me.txtMidPerfDepth.Tag = "fem"
				Me.txtMidPerfDepth.Text = Conversions.ToString(cRODSTAR.MidPerfDepth)
			End If
			If cRODSTAR.StaticBHPressure > 0F Then
				Me.txtStaticBHPressure.Tag = "pem"
				Me.txtStaticBHPressure.Text = Conversions.ToString(cRODSTAR.StaticBHPressure)
			End If
			If cRODSTAR.gbProducingBelowBPP Then
				Me.chkBelowBPP.Checked = True
			ElseIf cRODSTAR.BubblePoint > 0F Then
				Me.txtBubblePoint.Tag = "pem"
				Me.txtBubblePoint.Text = Conversions.ToString(cRODSTAR.BubblePoint)
			End If
			If cRODSTAR.FetkovichN > 0F Then
				Me.txtFetkovichN.Text = Conversions.ToString(cRODSTAR.FetkovichN)
			End If
			Try
				Dim ultraGridBand As UltraGridBand = Me.ulgTestPoints.DisplayLayout.Bands(0)
				If ultraGridBand.Columns.Count = 2 Then
					Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns("IPRPressure")
					ultraGridColumn.Header.Caption = Me.sPressure
					ultraGridColumn.Header.Tag = Me.sPressure + " (^)" & vbLf & "pem"
					ultraGridColumn.Tag = "Pressure (^)" & vbLf & "pem"
					ultraGridColumn.Width = 145
					Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns("IPRProduction")
					ultraGridColumn2.Header.Caption = Me.sFluidProduction
					ultraGridColumn2.Header.Tag = Me.sFluidProduction + " (^)" & vbLf & "bem"
					ultraGridColumn2.Tag = "Fluid production (^)" & vbLf & "bem"
					ultraGridColumn2.Width = 170
				End If
			Catch ex As Exception
			End Try
			cRODSTAR.gnTestPoints = Conversions.ToShort(ini.GetDataValue("TestPoints", 3, False, 0))
			If cRODSTAR.gnTestPoints = 0S Then
				Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(0) {}
				cRODSTAR.TestPoints = testPoints
			Else
				Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(CInt((cRODSTAR.gnTestPoints + 1S)) - 1) {}
				cRODSTAR.TestPoints = testPoints
			End If
			Me.cboTestPoints_Click_1(cRODSTAR.gnTestPoints - 1S, False)
			Dim num As Integer = 1
			Dim gnTestPoints As Integer = CInt(cRODSTAR.gnTestPoints)
			For i As Integer = num To gnTestPoints
				Dim ulgTestPoints As UltraGrid = Me.ulgTestPoints
				CtrlUI.fpSetText(ulgTestPoints, 1, i, RuntimeHelpers.GetObjectValue(Interaction.IIf(cRODSTAR.TestPoints(i).bPIEntered <> 0S, "Pi", "Pwf")))
				Me.ulgTestPoints = ulgTestPoints
				cRODSTAR.TestPoints(i).Pintake = -1F
				cRODSTAR.TestPoints(i).Pwf = -1F
				obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TestPointPressure" + Conversions.ToString(i), 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					If cRODSTAR.TestPoints(i).bPIEntered <> 0S Then
						cRODSTAR.TestPoints(i).Pintake = Conversions.ToSingle(obj)
						ulgTestPoints = Me.ulgTestPoints
						CtrlUI.Grid_SetValue(ulgTestPoints, 1S, CShort(i), cRODSTAR.TestPoints(i).Pintake)
						Me.ulgTestPoints = ulgTestPoints
					Else
						cRODSTAR.TestPoints(i).Pwf = Conversions.ToSingle(obj)
						ulgTestPoints = Me.ulgTestPoints
						CtrlUI.Grid_SetValue(ulgTestPoints, 1S, CShort(i), cRODSTAR.TestPoints(i).Pwf)
						Me.ulgTestPoints = ulgTestPoints
					End If
				End If
				cRODSTAR.TestPoints(i).Production = -1F
				obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TestPointProduction" + Conversions.ToString(i), 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					cRODSTAR.TestPoints(i).Production = Conversions.ToSingle(obj)
					ulgTestPoints = Me.ulgTestPoints
					CtrlUI.Grid_SetValue(ulgTestPoints, 2S, CShort(i), cRODSTAR.TestPoints(i).Production)
					Me.ulgTestPoints = ulgTestPoints
				End If
			Next
			Me.chkIPRData.Checked = cRODSTAR.gbUseIPR
			Me.txtFetkovichNEnabledChanged()
			Me.txtFLPIP.Enabled = True
			If cRODSTAR.gbCalcPumpCondition Then
				Me._optFLPIP_2.Checked = True
			ElseIf cRODSTAR.PumpCondition = 2S Then
				Me._optFLPIP_3.Checked = True
				Me._optFLPIP_1.Enabled = False
				Me.txtFLPIP.Enabled = False
			ElseIf Me._optFLPIP_2.Checked Then
				Me._optFLPIP_1.Checked = True
			ElseIf Me._optFLPIP_3.Checked Then
				Me._optFLPIP_0.Checked = True
			End If
			If cRODSTAR.gbCalcPumpCondition Or cRODSTAR.PumpCondition <> 1S Then
				Me._optSPMBFPD_0.Checked = True
				Me._optSPMBFPD_0.Enabled = False
				Me._optSPMBFPD_1.Enabled = False
				Me._optSPMBFPD_2.Enabled = False
				Me._optFLPIP_4.Enabled = False
			Else
				Me._optSPMBFPD_0.Enabled = True
				Me._optSPMBFPD_1.Enabled = True
				Me._optSPMBFPD_2.Enabled = True
				Me._optFLPIP_4.Enabled = True
			End If
			cRODSTAR = Nothing
		End Sub

		Public Sub LoadProdInfo()
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Select Case rst.giFluidLevelSource
					Case 0S, 1S
						Me.txtFLPIP.Text = Convert.ToString(rst.FluidLevel)
						If Not rst.gbCalcPumpIntakePressure Then
							Me.optFLPIP_Click_1(0, -1, False)
						ElseIf rst.gbCalcPumpIntakePressure Then
							Me.optFLPIP_Click_1(4, -1, False)
						End If
					Case 2S
						Me.txtFLPIP.Text = Convert.ToString(rst.PumpIntakePressure)
						Me.optFLPIP_Click_1(1, -1, False)
					Case Else
						Me.optFLPIP_Click_1(CInt(rst.giFluidLevelSource), -1, False)
				End Select
				If rst.SPM = 0F Then
					Me.txtSPMBFPD.Text = ""
				Else
					Me.txtSPMBFPD.Tag = ""
					Me.txtSPMBFPD.Text = Conversions.ToString(rst.SPM)
				End If
				If rst.gbCalcPumpCondition Then
					Me.optFLPIP_Click_1(2, -1, False)
				ElseIf rst.gbCalcPumpIntakePressure Then
					Me.optFLPIP_Click_1(4, -1, False)
				ElseIf rst.FluidLevelEntered Then
					Me.txtFLPIP.Enabled = True
					If rst.PumpCondition = 2S Then
						Me.optFLPIP_Click_1(3, -1, False)
						Me.txtFLPIP.Enabled = False
					Else
						Me.optFLPIP_Click_1(0, -1, False)
					End If
				Else
					Me.txtFLPIP.Text = Convert.ToString(rst.PumpIntakePressure)
					Me.txtFLPIP.Enabled = True
					Me.optFLPIP_Click_1(1, -1, False)
				End If
				If(rst.SPMEntered Or If((-If(((rst.PumpCondition <> 1S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Me.optSPMBFPD_Click_1(0, -1, False)
					Me.txtSPMBFPD.Text = Conversions.ToString(Interaction.IIf((rst.SPMEntered And If((-If((rst.SPM > 0F > False), 1S, 0S)), 1S, 0S)) <> 0S, Convert.ToString(rst.SPM), ""))
				ElseIf Not rst.gbCalcTargetBFPD Then
					Me.optSPMBFPD_Click_1(1, -1, False)
					Me.txtSPMBFPD.Tag = "bem"
					Me.txtSPMBFPD.Text = Convert.ToString(rst.TargetBFPD)
				Else
					Me.optSPMBFPD_Click_1(2, -1, False)
				End If
				If rst.gbUseIPR Then
					Me.cmdIPRPlot.Enabled = rst.gbUseIPR
					Me.chkIPRData.Checked = rst.gbUseIPR
					Me.chkIPRChanged(Me.chkIPRData.Checked, False)
					Me.cboIPRMethod_Click_1(rst.giIPRMethod, True)
					If Versioned.IsNumeric(rst.MidPerfDepth) And rst.MidPerfDepth > 0F Then
						Me.txtMidPerfDepth.Tag = "fem"
						Me.txtMidPerfDepth.Text = Conversions.ToString(rst.MidPerfDepth)
					Else
						Me.txtMidPerfDepth.Text = ""
						Dim textBox As TextBox = Me.txtMidPerfDepth
						Dim label As Label = Me._Label_MidPerfDepth
						Me.ToggelControl(textBox, label, True)
						Me._Label_MidPerfDepth = label
						Me.txtMidPerfDepth = textBox
					End If
					If Versioned.IsNumeric(rst.StaticBHPressure) And rst.StaticBHPressure > 0F Then
						Me.txtStaticBHPressure.Tag = "pem"
						Me.txtStaticBHPressure.Text = Conversions.ToString(rst.StaticBHPressure)
					Else
						Me.txtStaticBHPressure.Text = ""
						Dim textBox As TextBox = Me.txtStaticBHPressure
						Dim label As Label = Me._Label_StaticBHPressure
						Me.ToggelControl(textBox, label, True)
						Me._Label_StaticBHPressure = label
						Me.txtStaticBHPressure = textBox
					End If
					If Versioned.IsNumeric(rst.BubblePoint) And rst.BubblePoint > 0F Then
						Me.txtBubblePoint.Tag = "pem"
						Me.txtBubblePoint.Text = Conversions.ToString(rst.BubblePoint)
					Else
						Me.txtBubblePoint.Text = ""
						Dim textBox As TextBox = Me.txtBubblePoint
						Dim label As Label = Me._Label_BubblePoint
						Me.ToggelControl(textBox, label, True)
						Me._Label_BubblePoint = label
						Me.txtBubblePoint = textBox
					End If
					If rst.gbProducingBelowBPP Then
						Me.chkBelowBPP.Checked = True
					End If
					Me.ulgTestPoints.DataSource = Nothing
					Me.LoadTestPointGrid()
					If rst.FetkovichN > 0F Then
						Me.txtFetkovichN.Text = Conversions.ToString(rst.FetkovichN)
					End If
				Else
					Me.InitTestPointGrid()
					Me.cboTestPointType_Click_1(1S, False)
				End If
				If rst.gbCalcPumpCondition Then
					Me._optFLPIP_2.Checked = True
				ElseIf rst.PumpCondition = 2S Then
					Me._optFLPIP_3.Checked = True
				ElseIf Me._optFLPIP_2.Checked Then
					Me._optFLPIP_1.Checked = True
				ElseIf Me._optFLPIP_3.Checked Then
					Me._optFLPIP_0.Checked = True
				End If
				If rst.gbCalcPumpCondition Or rst.PumpCondition <> 1S Then
					Me._optSPMBFPD_0.Checked = True
					Me._optSPMBFPD_0.Enabled = False
					Me._optSPMBFPD_1.Enabled = False
					Me._optSPMBFPD_2.Enabled = False
					Me._optFLPIP_4.Enabled = False
				Else
					Me._optSPMBFPD_0.Enabled = True
					Me._optSPMBFPD_1.Enabled = True
					Me._optSPMBFPD_2.Enabled = True
					Me._optFLPIP_4.Enabled = True
				End If
				Me.txtFetkovichNEnabledChanged()
			Catch ex As Exception
				Dim sMsg As String = "Error in Load ProdInfo: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub ResortGrid()
		End Sub

		Private Sub ShowIPRData(bShow As Boolean)
			If bShow Then
				Me.InitTestPointGrid()
			End If
			Me.picRemoveFocus.Visible = False
			Me.picRemoveFocus.Visible = True
			Me.cboIPRMethod.TabStop = bShow
			Me.chkBelowBPP.TabStop = bShow
			Me.txtBubblePoint.TabStop = bShow
			Me.txtMidPerfDepth.TabStop = bShow
			Me.txtStaticBHPressure.TabStop = bShow
			Me.ulgTestPoints.TabStop = bShow
		End Sub

		Private Sub UpdateUI()
			Me.cmdAddTestPoint.Enabled = (RSWIN_DESC.rst.gnTestPoints < 10S)
			Me.cmdDelTestPoint.Enabled = (Me.ulgTestPoints.ActiveRow IsNot Nothing)
		End Sub

		Private Sub cboIPRMethod_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			Dim cboIPRMethod As ComboBox = Me.cboIPRMethod
			Me.cboIPRMethod_Click_1(CShort(cboIPRMethod.SelectedIndex), True)
			Me.Control_SelectedIndexChanged(Me.cboIPRMethod Is Me.ActiveControl)
		End Sub

		Private Sub cboTestPointType_SelectedValueChanged(eventSender As Object, eventArgs As EventArgs)
			Dim cboTestPointType As ComboBox = Me.cboTestPointType
			Me.cboTestPointType_Click_1(CShort(Me.cboTestPointType.SelectedIndex), True)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.cboTestPointType)
		End Sub

		Private Sub cboTestPointType_DropDown(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub chkBelowBPP_CheckChanged(eventSender As Object, eventArgs As EventArgs)
			Dim chkBelowBPP As CheckBox = Me.chkBelowBPP
			Me.chkBelowBPP_Click_1(chkBelowBPP.Checked, True)
		End Sub

		Private Sub chkCalculateN_Enter(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub chkCalculateN_Leave(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub cmdAddTestPoint_Click(eventSender As Object, eventArgs As EventArgs)
			Try
				Dim row As DataRow = Me.mdsTestPoints.Tables(0).NewRow()
				Me.mdsTestPoints.Tables(0).Rows.Add(row)
				Me.mdsTestPoints.AcceptChanges()
				RSWIN_DESC.rst.gnTestPoints = CShort(Me.mdsTestPoints.Tables(0).Rows.Count)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cmdCheckIPR_Click(eventSender As Object, eventArgs As EventArgs)
			Dim expression As Boolean = True
			If RSWIN_DESC.rst.gbUseIPR Then
				Me.GetTestPoints()
				expression = Me.CheckIPR(True, False)
			End If
			Me.cmdCheckIPR.Tag = RuntimeHelpers.GetObjectValue(Interaction.IIf(expression, "OK", Nothing))
		End Sub

		Private Sub cmdDelTestPoint_Click(eventSender As Object, eventArgs As EventArgs)
			Try
				Dim ulgTestPoints As UltraGrid = Me.ulgTestPoints
				ulgTestPoints.Focus()
				Me.ulgTestPoints.ActiveRow.Selected = True
				If ulgTestPoints.ActiveCell IsNot Nothing Then
					ulgTestPoints.ActiveCell.Row.Delete()
				ElseIf ulgTestPoints.Selected.Rows.Count = 1 Then
					ulgTestPoints.DeleteSelectedRows()
				End If
				Me.cmdDelTestPoint.Enabled = True
				Me.cmdAddTestPoint.Enabled = True
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cmdIPRPlot_Click(eventSender As Object, eventArgs As EventArgs)
			Me.GetTestPoints()
			Dim flag As Boolean = Me.CheckIPR(False, False)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.IPRPlot.ShowDialog()
		End Sub

		Private Sub cmdUpdateProduction_Click(eventSender As Object, eventArgs As EventArgs)
			Me.GetTestPoints()
			Dim flag As Boolean = Me.CheckIPR(True, False)
		End Sub

		Private Sub ProdInfo_Activated(eventSender As Object, eventArgs As EventArgs)
			Me.m_bClosing = False
			If Me.m_bReloadProdInfo And Not Me.m_bFormLoaded Then
				Me.ProdInfoLoad()
				Me.SetRequiredTextFields()
				Me.m_bReloadProdInfo = False
				Me.m_bFormLoaded = True
			End If
			If(Me.m_bFormLoaded And Not Me.m_bFormActivated And RSWIN_DESC.rst.gbUseIPR) AndAlso Not Me.m_bIPRMessageShown Then
				Dim flag As Boolean = Me.CheckIPR(True, False)
				Me.m_bIPRMessageShown = True
			End If
			RSWIN_DESC.sCurrentFormName = "ProdInfo"
			Me.m_bFormActivated = True
		End Sub

		Private Sub Form_Initialize()
			Me.mbFirstResize = True
		End Sub

		Private Sub ProdInfo_Load(eventSender As Object, eventArgs As EventArgs)
			RSWIN.GetMeasurementUnit()
			Me.ResetClock()
			Me.bLoadingForm = True
			Me.m_bClosing = False
			RSWIN_DESC.sCurrentFormName = "ProdInfo"
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
			Me.ProdInfoLoad()
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				Me._optFLPIP_0.Checked = True
				Me._optFLPIP_0.Enabled = False
				Me._optFLPIP_1.Enabled = False
				Me._optFLPIP_2.Enabled = False
				Me._optFLPIP_3.Enabled = False
				Me._optFLPIP_4.Enabled = False
				Me._optSPMBFPD_0.Enabled = False
				Me.txtFLPIP.Tag = "fem"
				RSWIN_DESC.rst.FluidLevel = RSWIN_DESC.rst.PumpDepth
				Me.txtFLPIP.Text = RSWIN_DESC.rst.FluidLevel.ToString()
				Me.txtFLPIP.Enabled = False
				If RSWIN_DESC.rst.SPMEntered <> 0S Then
					RSWIN_DESC.rst.SPMEntered = 0S
					If Not Me._optSPMBFPD_2.Checked Then
						Me._optSPMBFPD_1.Checked = True
					End If
				End If
			End If
			Me.SetRequiredTextFields()
			RSWIN_DESC.frmMain.ToolbarButtonSetState(16, Me.CheckRequiredTextFields())
			Me.bLoadingForm = False
			Me.m_bReloadProdInfo = False
			Me.bFormLoaded = True
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
			End If
			Me.CenterForm()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
		End Sub

		Private Sub ProdInfoLoad()
			Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			Me.bFormLoaded = False
			Try
				SUPERPRO.NewCheckSentinel(True)
				Me.Height = Me._linSeparator_2.Top + 35
				Me._SSPanel_0.BorderStyle = BorderStyle.None
				Me.picRemoveFocus.BorderStyle = BorderStyle.None
				Me.SetMaxProductionFrameLabel()
				If RSWIN_DESC.rst.gbUseIPR Then
					Me.ulgTestPoints_Initialize()
					Me.pnlIPR.Visible = True
				Else
					Me.pnlIPR.Visible = False
				End If
				Me.bTextChanged = False
				If Not RSWIN_DESC.NewData(2) <> 0S Then
					Me.LoadProdInfo()
				Else
					Me.InitProdInfo()
				End If
				Dim ulgTestPoints As UltraGrid
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					ulgTestPoints = Me.ulgTestPoints
					CtrlUI.Grid_ToggleUnits(ulgTestPoints, -1S, -1S, "#####.#")
					Me.ulgTestPoints = ulgTestPoints
				End If
				ulgTestPoints = Me.ulgTestPoints
				CtrlUI.Grid_SetLabels(ulgTestPoints, True)
				Me.ulgTestPoints = ulgTestPoints
				If Not Me.CheckFields() Then
					Me.SetFieldColors()
				End If
				Me.bFormLoaded = True
				Me.bTextChanged = True
			Catch ex As Exception
				Dim sMsg As String = "Error in ProdInfo Load: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Function CheckFields() As Boolean
			Dim result As Boolean = True
			If Me.txtSPMBFPD.Visible And Strings.Len(Strings.Trim(Me.txtSPMBFPD.Text)) = 0 Then
				result = False
			End If
			Return result
		End Function

		Private Sub ProdInfo_Leave(sender As Object, e As EventArgs)
			Me.ValidateProdInfo(Me.bCancel, True)
		End Sub

		Private Sub picRemoveFocus_MouseDown(eventSender As Object, eventArgs As MouseEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort((eventArgs.Button / MouseButtons.Left))
			Dim num2 As Short = CShort((Control.ModifierKeys / Keys.Shift))
			Dim num3 As Single = CSng(Support.PixelsToTwipsX(CDbl(eventArgs.X)))
			Dim num4 As Single = CSng(Support.PixelsToTwipsY(CDbl(eventArgs.Y)))
			If num <> 1S Or num2 <> 0S Then
				Return
			End If
		End Sub

		Private Sub CheckTextControl(ByRef myControl As Control, ByRef nFieldValue As Single, sFieldName As String, Optional bQuiet As Boolean = False)
			If Not Me.bFormLoaded Then
				Return
			End If
			If Operators.CompareString(myControl.Text.Trim(), ".", False) = 0 Then
				Return
			End If
			If Not Versioned.IsNumeric(myControl.Text) Then
				If Not bQuiet Then
					Dim sMsg As String = "Please enter numeric value for " + sFieldName
					Dim sMsgType As String = "Data Entry Error"
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				End If
				Me.bTextChanged = False
				myControl.Text = ""
				myControl.Focus()
				Me.bTextChanged = True
			ElseIf myControl.Text.Length = 0 Then
				If Not bQuiet Then
					Dim sMsg2 As String = "Please enter value for " + sFieldName
					Dim sMsgType2 As String = "Data Entry Error"
					Dim bClosing2 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg2, sMsgType2, bClosing2, dialogResult)
				End If
				Me.SetFieldColors()
				myControl.Focus()
			Else
				Dim textBox As TextBox = CType(myControl, TextBox)
				Dim bValidIfEmpty As Short = If((-If((Not bQuiet > False), 1S, 0S)), 1S, 0S)
				Dim bShowMessage As Short = 0S
				Dim num As Single
				Dim obj As Object = num
				Dim num2 As Integer = CInt(Me.CheckValid(textBox, bValidIfEmpty, bShowMessage, obj))
				num = Conversions.ToSingle(obj)
				myControl = textBox
				If num2 <> 0 Then
					nFieldValue = num
				End If
			End If
		End Sub

		Private Sub txtBubblePoint_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtBubblePoint As TextBox = Me.txtBubblePoint
			Dim label_BubblePoint As Label = Me._Label_BubblePoint
			Me.TextBox_Change(txtBubblePoint, label_BubblePoint)
			Me._Label_BubblePoint = label_BubblePoint
			Me.txtBubblePoint = txtBubblePoint
			txtBubblePoint = Me.txtBubblePoint
			Util.SetFieldColor(txtBubblePoint)
			Me.txtBubblePoint = txtBubblePoint
			Dim txtBubblePoint2 As Control = Me.txtBubblePoint
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim bubblePoint As Single = rst.BubblePoint
			Me.CheckTextControl(txtBubblePoint2, bubblePoint, "Bubble point pressure", True)
			rst.BubblePoint = bubblePoint
			Me.txtBubblePoint = CType(txtBubblePoint2, TextBox)
		End Sub

		Private Sub txtBubblePoint_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			Dim txtBubblePoint As TextBox
			Dim label_BubblePoint As Label
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
			txtBubblePoint = Me.txtBubblePoint
			label_BubblePoint = Me._Label_BubblePoint
			CtrlUI.TextBox_KeyDown(txtBubblePoint, label_BubblePoint, CInt(eventArgs.KeyCode), If((-If((eventArgs.Shift > False), 1, 0)), 1, 0))
			Me._Label_BubblePoint = label_BubblePoint
			Me.txtBubblePoint = txtBubblePoint
		End Sub

		Private Sub txtBubblePoint_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtFetkovichN_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtFetkovichN As TextBox = Me.txtFetkovichN
			Dim label_FetkovichN As Label = Me._Label_FetkovichN
			Me.TextBox_Change(txtFetkovichN, label_FetkovichN)
			Me._Label_FetkovichN = label_FetkovichN
			Me.txtFetkovichN = txtFetkovichN
			txtFetkovichN = Me.txtFetkovichN
			Util.SetFieldColor(txtFetkovichN)
			Me.txtFetkovichN = txtFetkovichN
			Dim txtFetkovichN2 As Control = Me.txtFetkovichN
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim fetkovichN As Single = rst.FetkovichN
			Me.CheckTextControl(txtFetkovichN2, fetkovichN, "Value of 'n' (Fetkovich corr.)", True)
			rst.FetkovichN = fetkovichN
			Me.txtFetkovichN = CType(txtFetkovichN2, TextBox)
		End Sub

		Private Sub txtFetkovichN_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			Dim txtFetkovichN As TextBox
			Dim label_FetkovichN As Label
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
			txtFetkovichN = Me.txtFetkovichN
			label_FetkovichN = Me._Label_FetkovichN
			CtrlUI.TextBox_KeyDown(txtFetkovichN, label_FetkovichN, CInt(eventArgs.KeyCode), If((-If((eventArgs.Shift > False), 1, 0)), 1, 0))
			Me._Label_FetkovichN = label_FetkovichN
			Me.txtFetkovichN = txtFetkovichN
		End Sub

		Private Sub txtFetkovichN_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtFLPIP_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtFLPIP As TextBox = Me.txtFLPIP
			Dim label_ As Label = Me._Label_3
			Me.TextBox_Change(txtFLPIP, label_)
			Me._Label_3 = label_
			Me.txtFLPIP = txtFLPIP
			If Me.ActiveControl Is Me.txtFLPIP And Versioned.IsNumeric(Me.txtFLPIP.Text) Then
				If Not Me._optFLPIP_4.Checked Then
					If Me._optFLPIP_0.Checked Then
						Me.bFLMsgShown = False
						Dim flag As Boolean = False
						Dim flag2 As Boolean = flag
						txtFLPIP = Me.txtFLPIP
						Dim bValidIfEmpty As Short = -1S
						Dim bShowMessage As Short = 0S
						Dim num As Single
						Dim obj As Object = num
						Dim num2 As Integer = CInt(Me.CheckValid(txtFLPIP, bValidIfEmpty, bShowMessage, obj))
						num = Conversions.ToSingle(obj)
						Me.txtFLPIP = txtFLPIP
						If flag2 <> (num2 <> 0) Then
							Dim obj2 As Object = flag
							obj = num
							Dim pumpDepth As Single = RSWIN_DESC.rst.PumpDepth
							Dim inclusive As Integer = -1
							Dim errnum As Integer = 103
							Dim useMetric As Integer = 0
							Dim canadianIsMetric As Integer = 0
							Dim bQuiet As Boolean = False
							Dim text As String = ""
							Dim obj3 As Object = Util.CheckUpper(obj, pumpDepth, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text)
							num = Conversions.ToSingle(obj)
							If Operators.ConditionalCompareObjectEqual(obj2, obj3, False) Then
								RSWIN_DESC.rst.FluidLevel = RSWIN_DESC.rst.PumpDepth
								Me.txtFLPIP.Tag = "fem"
								Dim txtFLPIP2 As TextBox = Me.txtFLPIP
								Dim rst As cRODSTAR = RSWIN_DESC.rst
								Dim fluidLevel As Single = rst.FluidLevel
								text = "######.##"
								Dim text2 As String = Util.Format(fluidLevel, text)
								rst.FluidLevel = fluidLevel
								txtFLPIP2.Text = text2
								txtFLPIP = Me.txtFLPIP
								label_ = Me._Label_3
								Me.ToggelControl(txtFLPIP, label_, True)
								Me._Label_3 = label_
								Me.txtFLPIP = txtFLPIP
								Me.txtFLPIP.Focus()
							Else
								ini.SaveDataValue("FluidLevel", num)
								If Not Information.IsDBNull(num) Then
									RSWIN_DESC.rst.FluidLevel = num
									RSWIN_DESC.rst.PumpIntakePressure = CSng((CDbl(((RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.rst.FluidLevel) * RSWIN_DESC.rst.OilSPGR)) * 0.433 + CDbl(RSWIN_DESC.rst.CasingPressure) + 14.7))
									ini.SaveDataValue("FluidLevel", RSWIN_DESC.rst.FluidLevel)
									ini.SaveDataValue("FluidLevelEntered", RSWIN_DESC.rst.FluidLevelEntered)
									ini.SaveDataValue("PumpIntakePressure", RSWIN_DESC.rst.PumpIntakePressure)
								End If
							End If
						End If
					ElseIf Me._optFLPIP_1.Checked Then
						Dim flag3 As Boolean = False
						Dim flag4 As Boolean = flag3
						txtFLPIP = Me.txtFLPIP
						Dim bValidIfEmpty2 As Short = -1S
						Dim bShowMessage2 As Short = 0S
						Dim num As Single
						Dim obj As Object = num
						Dim num3 As Integer = CInt(Me.CheckValid(txtFLPIP, bValidIfEmpty2, bShowMessage2, obj))
						num = Conversions.ToSingle(obj)
						Me.txtFLPIP = txtFLPIP
						If flag4 <> (num3 <> 0) Then
							ini.SaveDataValue("PumpIntakePressure", num)
							If Not Information.IsDBNull(num) Then
								RSWIN_DESC.rst.PumpIntakePressure = num
								ini.SaveDataValue("PumpIntakePressure", RSWIN_DESC.rst.PumpIntakePressure)
							End If
						End If
					End If
				End If
				Return
			End If
		End Sub

		Private Sub txtFLPIP_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			Dim txtFLPIP As TextBox = Me.txtFLPIP
			Dim label_ As Label = Me._Label_3
			CtrlUI.TextBox_KeyDown(txtFLPIP, label_, CInt(eventArgs.KeyCode), If((-If((eventArgs.Shift > False), 1, 0)), 1, 0))
			Me._Label_3 = label_
			Me.txtFLPIP = txtFLPIP
		End Sub

		Private Sub txtFLPIP_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Public Sub SetMaxProductionFrameLabel()
			Dim str As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				str = "(" + RSWIN_DESC.bpd + ")"
			Else
				str = "(" + RSWIN_DESC.m3D + ")"
			End If
			If RSWIN_DESC.bRunningChineseVersion Then
				Return
			End If
			Me.frmMaxProduction.Text = "Calc. max. production " + str
		End Sub

		Private Sub txtSPMBFPD_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtSPMBFPD As TextBox = Me.txtSPMBFPD
			Dim label_SPMBFPD As Label = Me._Label_SPMBFPD
			Me.TextBox_Change(txtSPMBFPD, label_SPMBFPD)
			Me._Label_SPMBFPD = label_SPMBFPD
			Me.txtSPMBFPD = txtSPMBFPD
			txtSPMBFPD = Me.txtSPMBFPD
			Util.SetFieldColor(txtSPMBFPD)
			Me.txtSPMBFPD = txtSPMBFPD
			If Me.ActiveControl Is Me.txtSPMBFPD And Versioned.IsNumeric(Me.txtSPMBFPD.Text) Then
				If Me._optSPMBFPD_0.Checked Then
					Dim flag As Boolean = False
					Dim flag2 As Boolean = flag
					txtSPMBFPD = Me.txtSPMBFPD
					Dim obj As Object
					Dim num As Integer = CInt(Me.CheckValid(txtSPMBFPD, -1S, 0S, obj))
					Me.txtSPMBFPD = txtSPMBFPD
					If flag2 <> (num <> 0) Then
						ini.SaveDataValue("PumpingSpeed", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.SPM = Conversions.ToSingle(obj)
						End If
					End If
				ElseIf Me._optSPMBFPD_1.Checked Then
					Dim flag3 As Boolean = False
					Dim flag4 As Boolean = flag3
					txtSPMBFPD = Me.txtSPMBFPD
					Dim obj As Object
					Dim num2 As Integer = CInt(Me.CheckValid(txtSPMBFPD, -1S, 0S, obj))
					Me.txtSPMBFPD = txtSPMBFPD
					If flag4 = (num2 <> 0) Then
						Me.txtSPMBFPD.Focus()
					Else
						ini.SaveDataValue("TargetBFPD", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.TargetBFPD = Conversions.ToSingle(obj)
							Me.bLowerTargetMsgShown = False
							Me.bUpperTargetMsgShown = False
							Me.GetTestPoints()
							Me.CheckIPR(False, False)
						End If
					End If
				End If
				Return
			End If
		End Sub

		Private Sub txtSPMBFPD_KeyDown(eventSender As Object, e As KeyEventArgs)
			Dim txtSPMBFPD As TextBox = Me.txtSPMBFPD
			Dim label_SPMBFPD As Label = Me._Label_SPMBFPD
			CtrlUI.TextBox_KeyDown(txtSPMBFPD, label_SPMBFPD, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me._Label_SPMBFPD = label_SPMBFPD
			Me.txtSPMBFPD = txtSPMBFPD
		End Sub

		Private Sub txtSPMBFPD_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtStaticBHPressure_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtStaticBHPressure As TextBox = Me.txtStaticBHPressure
			Dim label_StaticBHPressure As Label = Me._Label_StaticBHPressure
			Me.TextBox_Change(txtStaticBHPressure, label_StaticBHPressure)
			Me._Label_StaticBHPressure = label_StaticBHPressure
			Me.txtStaticBHPressure = txtStaticBHPressure
			txtStaticBHPressure = Me.txtStaticBHPressure
			Util.SetFieldColor(txtStaticBHPressure)
			Me.txtStaticBHPressure = txtStaticBHPressure
			Dim txtStaticBHPressure2 As Control = Me.txtStaticBHPressure
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim staticBHPressure As Single = rst.StaticBHPressure
			Me.CheckTextControl(txtStaticBHPressure2, staticBHPressure, "Static b'hole pressure", True)
			rst.StaticBHPressure = staticBHPressure
			Me.txtStaticBHPressure = CType(txtStaticBHPressure2, TextBox)
		End Sub

		Private Sub txtStaticBHPressure_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			Dim txtStaticBHPressure As TextBox = Me.txtStaticBHPressure
			Dim label_StaticBHPressure As Label = Me._Label_StaticBHPressure
			CtrlUI.TextBox_KeyDown(txtStaticBHPressure, label_StaticBHPressure, CInt(eventArgs.KeyCode), If((-If((eventArgs.Shift > False), 1, 0)), 1, 0))
			Me._Label_StaticBHPressure = label_StaticBHPressure
			Me.txtStaticBHPressure = txtStaticBHPressure
		End Sub

		Private Sub txtStaticBHPressure_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub ulgTestPoints_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs)
			e.DisplayPromptMsg = False
			Dim obj As Object = MessageBox.Show(RSWIN_DESC.sARS, Me.sDeleteRow, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If Operators.ConditionalCompareObjectEqual(obj, DialogResult.No, False) Then
				e.Cancel = True
			End If
		End Sub

		Private Sub ulgTestPoints_AfterCellUpdate(eventSender As Object, eventArgs As CellEventArgs)
			Try
				Me.GetTestPoints()
			Catch ex As Exception
			End Try
			Try
				Dim flag As Boolean = Me.CheckIPR(True, False)
				If Operators.CompareString(eventArgs.Cell.Column.Key, "IPRPressure", False) = 0 Then
					Me.ResortGrid()
				End If
				Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.ulgTestPoints)
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub ulgTestPoints_AfterRowInsert(eventSender As Object, eventArgs As RowEventArgs)
			Try
				Me.UpdateUI()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTestPoints_AfterRowsDeleted(eventSender As Object, eventArgs As EventArgs)
			Me.UpdateUI()
			Me.GetTestPoints()
			Dim flag As Boolean = Me.CheckIPR(False, False)
		End Sub

		Private Sub ulgTestPoints_BeforeCellActivate(eventSender As Object, eventArgs As CancelableCellEventArgs)
			Dim ulgTestPoints As UltraGrid = Me.ulgTestPoints
			If ulgTestPoints.ActiveCell IsNot Nothing Then
				ulgTestPoints.ActiveCell.Column.Hidden = True
				ulgTestPoints.ActiveCell.Column.Hidden = False
			End If
		End Sub

		Private Sub ulgTestPoints_Enter(eventSender As Object, eventArgs As EventArgs)
			Me.UpdateUI()
		End Sub

		Private Sub ulgTestPoints_InitializeLayout(eventSender As Object, eventArgs As InitializeLayoutEventArgs)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim ultraGridLayout As UltraGridLayout = eventArgs.Layout
				IL_0A:
				num = 2
				Dim ultraGridBand As UltraGridBand = ultraGridLayout.Bands(0)
				IL_1A:
				num = 3
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns("IPRPressure")
				IL_2E:
				num = 4
				ultraGridColumn.Header.Caption = Me.sPressure
				IL_42:
				num = 5
				ultraGridColumn.Header.Tag = Me.sPressure + " (^)" & vbLf & "pem"
				IL_60:
				num = 6
				ultraGridColumn.Tag = Me.sPressure + " (^)" & vbLf & "pem"
				IL_79:
				num = 7
				ultraGridColumn.Width = 145
				IL_87:
				num = 8
				ultraGridColumn.Header.Fixed = True
				IL_96:
				ultraGridColumn = Nothing
				IL_98:
				num = 10
				Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns("IPRProduction")
				IL_AD:
				num = 11
				ultraGridColumn2.Header.Caption = Me.sFluidProduction
				IL_C2:
				num = 12
				ultraGridColumn2.Header.Tag = Me.sFluidProduction + " (^)" & vbLf & "bem"
				IL_E1:
				num = 13
				ultraGridColumn2.Tag = Me.sFluidProduction + " (^)" & vbLf & "bem"
				IL_FB:
				num = 14
				ultraGridColumn2.Width = 170
				IL_10A:
				num = 15
				ultraGridColumn2.Header.Fixed = True
				IL_11A:
				ultraGridColumn2 = Nothing
				IL_11C:
				ultraGridBand = Nothing
				IL_11E:
				ultraGridLayout = Nothing
				IL_120:
				num = 19
				Dim ultraGrid As UltraGrid = Me.ulgTestPoints
				IL_12C:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_134:
				num = 21
				ultraGrid.ActiveRow = ultraGrid.GetRow(ChildRow.First)
				IL_147:
				num = 22
				Dim ultraGridOverride As UltraGridOverride = ultraGrid.DisplayLayout.Override
				IL_159:
				num = 23
				ultraGridOverride.AllowColMoving = AllowColMoving.NotAllowed
				IL_165:
				num = 24
				ultraGridOverride.AllowColSizing = AllowColSizing.None
				IL_171:
				num = 25
				ultraGridOverride.AllowColSwapping = AllowColSwapping.NotAllowed
				IL_17D:
				num = 26
				ultraGridOverride.BorderStyleCell = UIElementBorderStyle.InsetSoft
				IL_189:
				num = 27
				ultraGridOverride.BorderStyleRow = UIElementBorderStyle.RaisedSoft
				IL_195:
				num = 28
				ultraGridOverride.RowSelectors = DefaultableBoolean.[False]
				IL_1A1:
				num = 29
				ultraGridOverride.RowSizing = RowSizing.Fixed
				IL_1AD:
				num = 30
				ultraGridOverride.SelectTypeCell = SelectType.[Single]
				IL_1B9:
				num = 31
				ultraGridOverride.SelectTypeCol = SelectType.None
				IL_1C5:
				num = 32
				ultraGridOverride.SelectTypeRow = SelectType.[Single]
				IL_1D1:
				ultraGridOverride = Nothing
				IL_1D4:
				ultraGrid = Nothing
				IL_1D7:
				GoTo IL_2BC
				IL_1DC:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_278:
				GoTo IL_2B1
				IL_27A:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_28D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_27A
			End Try
			IL_2B1:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2BC:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub CreateDataSet()
			Me.mdsTestPoints = New DataSet("TestPoints")
			Dim dataTable As DataTable = New DataTable("TestPoints")
			Dim dataColumn As DataColumn = New DataColumn("IPRPressure", GetType(Single))
			dataColumn.Unique = False
			dataColumn.AllowDBNull = True
			dataColumn.Caption = Me.sPressure + " (psia)"
			dataTable.Columns.Add(dataColumn)
			Dim dataColumn2 As DataColumn = New DataColumn("IPRProduction", GetType(Single))
			dataColumn2.AllowDBNull = True
			dataColumn2.Caption = Me.sFluidProduction + " (" + RSWIN_DESC.bfpd + ")"
			dataTable.Columns.Add(dataColumn2)
			Me.mdsTestPoints.Tables.Add(dataTable)
		End Sub

		Private Sub AddIPRRow(IPRPRESSURE As Object, IPRPRODUCTION As Object)
			Try
				Dim dataRow As DataRow = Me.mdsTestPoints.Tables(0).NewRow()
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(IPRPRESSURE)) Then
					dataRow("IPRPressure") = RuntimeHelpers.GetObjectValue(IPRPRESSURE)
				Else
					Dim dataRow2 As DataRow = dataRow
					Dim columnName As String = "IPRPressure"
					Dim obj As Object = Nothing
					Dim typeFromHandle As Type = GetType(Util)
					Dim text As String = "Format"
					Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(IPRPRESSURE), "#####.##" }
					Dim array2 As Object() = array
					Dim array3 As String() = Nothing
					Dim array4 As Type() = Nothing
					Dim array5 As Boolean() = New Boolean() { True, False }
					Dim obj2 As Object = NewLateBinding.LateGet(obj, typeFromHandle, text, array2, array3, array4, array5)
					If array5(0) Then
						IPRPRESSURE = RuntimeHelpers.GetObjectValue(array(0))
					End If
					dataRow2(columnName) = RuntimeHelpers.GetObjectValue(obj2)
				End If
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(IPRPRODUCTION)) Then
					dataRow("IPRProduction") = RuntimeHelpers.GetObjectValue(IPRPRODUCTION)
				Else
					Dim dataRow3 As DataRow = dataRow
					Dim columnName2 As String = "IPRProduction"
					Dim obj3 As Object = Nothing
					Dim typeFromHandle2 As Type = GetType(Util)
					Dim text2 As String = "Format"
					Dim array6 As Object() = New Object() { RuntimeHelpers.GetObjectValue(IPRPRODUCTION), "#####.##" }
					Dim array7 As Object() = array6
					Dim array8 As String() = Nothing
					Dim array9 As Type() = Nothing
					Dim array5 As Boolean() = New Boolean() { True, False }
					Dim obj4 As Object = NewLateBinding.LateGet(obj3, typeFromHandle2, text2, array7, array8, array9, array5)
					If array5(0) Then
						IPRPRODUCTION = RuntimeHelpers.GetObjectValue(array6(0))
					End If
					dataRow3(columnName2) = RuntimeHelpers.GetObjectValue(obj4)
				End If
				Me.mdsTestPoints.Tables(0).Rows.Add(dataRow)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTestPoints_Leave(eventSender As Object, eventArgs As EventArgs)
			Me.UpdateUI()
		End Sub

		Private Sub chkIPRData_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ActiveControl Is Me.chkIPRData
			If flag And RSWIN_DESC.rst.gbUseIPR Then
				If Me._optSPMBFPD_2.Checked And Not Me.chkIPRData.Checked Then
					Dim msg As String = "Calculate production from inflow performance data is checked. Are you sure you do not want to enter IPR data?"
					Dim bDefaultYes As Boolean = False
					Dim flag2 As Boolean = False
					If Not Util.YesNo(msg, bDefaultYes, flag2) Then
						Me.chkIPRData.Checked = True
						RSWIN_DESC.rst.gbUseIPR = Me.chkIPRData.Checked
						Me.chkIPRChanged(Me.chkIPRData.Checked, Me.chkIPRData Is Me.ActiveControl)
						Return
					End If
					Me._optSPMBFPD_2.Checked = False
					Me._optSPMBFPD_1.Checked = True
					Me.optSPMBFPD_Click_1(1, If((-If((Me._optSPMBFPD_1.Checked > False), 1, 0)), 1, 0), True)
					Me.txtSPMBFPD.Focus()
				ElseIf Me._optFLPIP_4.Checked And Not Me.chkIPRData.Checked Then
					Dim msg2 As String = "Calculate pump intake pressure from target production and IPR data is checked. Are you sure you do not want to enter IPR data?"
					Dim bDefaultYes2 As Boolean = False
					Dim flag2 As Boolean = False
					If Not Util.YesNo(msg2, bDefaultYes2, flag2) Then
						Me.chkIPRData.Checked = True
						RSWIN_DESC.rst.gbUseIPR = Me.chkIPRData.Checked
						Me.chkIPRChanged(Me.chkIPRData.Checked, Me.chkIPRData Is Me.ActiveControl)
						Return
					End If
					Me._optFLPIP_4.Checked = False
					Me._optFLPIP_0.Checked = True
					Me.optFLPIP_Click_1(0, If((-If((Me._optFLPIP_0.Checked > False), 1, 0)), 1, 0), True)
				End If
			End If
			RSWIN_DESC.rst.gbUseIPR = Me.chkIPRData.Checked
			Me.chkIPRChanged(Me.chkIPRData.Checked, Me.chkIPRData Is Me.ActiveControl)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.chkIPRData)
			If RSWIN_DESC.rst.gbUseIPR Then
				Dim ulgTestPoints As UltraGrid = Me.ulgTestPoints
				CtrlUI.Grid_SetLabels(ulgTestPoints, True)
				Me.ulgTestPoints = ulgTestPoints
			End If
			If Me.chkIPRData.Checked Then
				Dim textBox As TextBox = Me.txtMidPerfDepth
				Dim label As Label = Me._Label_MidPerfDepth
				Me.ToggelControl(textBox, label, True)
				Me._Label_MidPerfDepth = label
				Me.txtMidPerfDepth = textBox
				textBox = Me.txtStaticBHPressure
				label = Me._Label_StaticBHPressure
				Me.ToggelControl(textBox, label, True)
				Me._Label_StaticBHPressure = label
				Me.txtStaticBHPressure = textBox
				textBox = Me.txtBubblePoint
				label = Me._Label_BubblePoint
				Me.ToggelControl(textBox, label, True)
				Me._Label_BubblePoint = label
				Me.txtBubblePoint = textBox
				If Me.cboIPRMethod.SelectedIndex = -1 AndAlso (RSWIN_DESC.rst.giIPRMethod = 0S Or RSWIN_DESC.rst.giIPRMethod = 1S) Then
					Me.cboIPRMethod_Click_1(RSWIN_DESC.rst.giIPRMethod, False)
				End If
				Return
			End If
		End Sub

		Public Sub chkIPRChanged(chkValue As Boolean, bClicked As Boolean)
			Dim chkIPRData As CheckBox = Me.chkIPRData
			Me.Top = 0
			If chkValue Then
				Me.Height = Me._picRemoveFocus.Height + 50
				Me.pnlIPR.Visible = True
			Else
				Me.Height = Me._linSeparator_2.Top + 35
				Me.pnlIPR.Visible = False
			End If
			Dim chkIPRData2 As CheckBox = Me.chkIPRData
			Dim checked As Boolean = chkIPRData2.Checked
			Me.chkIPRData_Click_1(checked, True)
			chkIPRData2.Checked = checked
			If RSWIN_DESC.rst.gbUseIPR Then
				Me.GetTestPoints()
				Dim flag As Boolean = Me.CheckIPR(False, False)
			End If
		End Sub

		Private Sub picRemoveFocus_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Private Sub _SSPanel_0_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Private Sub chkBelowBPP_CheckedChanged(sender As Object, e As EventArgs)
			If Me.chkBelowBPP.Checked Then
				Me.txtBubblePoint.Enabled = False
			Else
				Me.txtBubblePoint.Enabled = True
			End If
			Me.txtBubblePointEnabledChanged()
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.chkBelowBPP)
		End Sub

		Private Sub SetFieldColors()
			Dim textBox As TextBox = Me.txtFLPIP
			Util.SetFieldColor(textBox)
			Me.txtFLPIP = textBox
			textBox = Me.txtSPMBFPD
			Util.SetFieldColor(textBox)
			Me.txtSPMBFPD = textBox
			textBox = Me.txtFetkovichN
			Util.SetFieldColor(textBox)
			Me.txtFetkovichN = textBox
			textBox = Me.txtMidPerfDepth
			Util.SetFieldColor(textBox)
			Me.txtMidPerfDepth = textBox
			textBox = Me.txtStaticBHPressure
			Util.SetFieldColor(textBox)
			Me.txtStaticBHPressure = textBox
			textBox = Me.txtBubblePoint
			Util.SetFieldColor(textBox)
			Me.txtBubblePoint = textBox
		End Sub

		Private Sub SetRequiredTextFields()
			If Operators.CompareString(Me.txtFLPIP.Text, "", False) = 0 Then
				Me.txtFLPIP.BackColor = RSWIN_DESC.rgbEditRequired
			End If
			If Operators.CompareString(Me.txtSPMBFPD.Text, "", False) = 0 Then
				Me.txtSPMBFPD.BackColor = RSWIN_DESC.rgbEditRequired
			End If
			If Operators.CompareString(Me.txtMidPerfDepth.Text, "", False) = 0 Then
				Me.txtMidPerfDepth.BackColor = RSWIN_DESC.rgbEditRequired
			End If
			If Operators.CompareString(Me.txtStaticBHPressure.Text, "", False) = 0 Then
				Me.txtStaticBHPressure.BackColor = RSWIN_DESC.rgbEditRequired
			End If
			If Operators.CompareString(Me.txtBubblePoint.Text, "", False) = 0 Then
				Me.txtBubblePoint.BackColor = RSWIN_DESC.rgbEditRequired
				Return
			End If
		End Sub

		Private Sub SetRequiredTextField(myControl As TextBox)
			Try
				Dim flag As Boolean = True
				Dim flag2 As Boolean = True
				If flag2 <> (myControl Is Me.txtFLPIP) Then
					If flag2 <> (myControl Is Me.txtSPMBFPD) Then
						If flag2 <> (myControl Is Me.txtMidPerfDepth) Then
							If flag2 <> (myControl Is Me.txtStaticBHPressure) Then
								If flag2 <> (myControl Is Me.txtBubblePoint) Then
									flag = False
								End If
							End If
						End If
					End If
				End If
				If flag AndAlso Operators.CompareString(myControl.Text, "", False) = 0 Then
					myControl.BackColor = RSWIN_DESC.rgbEditRequired
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtBubblePoint_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtBubblePoint As Control = Me.txtBubblePoint
			CtrlUI.Control_LostFocus(txtBubblePoint)
			Me.txtBubblePoint = CType(txtBubblePoint, TextBox)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = flag
			Dim txtBubblePoint2 As TextBox = Me.txtBubblePoint
			Dim obj As Object
			Dim num As Integer = CInt(Me.CheckValid(txtBubblePoint2, -1S, 0S, obj))
			Me.txtBubblePoint = txtBubblePoint2
			If flag2 = (num <> 0) Then
				Me.SetRequiredTextField(Me.txtBubblePoint)
				Return
			End If
			Dim obj2 As Object = flag
			Dim lowerBound As Single = 200F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 9
			Dim useMetric As Integer = -1
			Dim canadianIsMetric As Integer = -1
			Dim bQuiet As Boolean = False
			Dim text As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Me.txtBubblePoint.Focus()
				Return
			End If
			Dim obj3 As Object = flag
			Dim upperBound As Single = 5000F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = 9
			Dim useMetric2 As Integer = -1
			Dim canadianIsMetric2 As Integer = -1
			Dim bQuiet2 As Boolean = False
			text = ""
			If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
				Me.txtBubblePoint.Focus()
				Return
			End If
			txtBubblePoint2 = Me.txtBubblePoint
			Dim label_BubblePoint As Label = Me._Label_BubblePoint
			CtrlUI.TextBox_LostFocus(txtBubblePoint2, label_BubblePoint, True)
			Me._Label_BubblePoint = label_BubblePoint
			Me.txtBubblePoint = txtBubblePoint2
			ini.SaveDataValue("BubblePoint", RuntimeHelpers.GetObjectValue(obj))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.rst.BubblePoint = -1F
			Else
				RSWIN_DESC.rst.BubblePoint = Conversions.ToSingle(obj)
			End If
			Me.GetTestPoints()
			Me.CheckIPR(True, False)
		End Sub

		Private Sub txtFetkovichN_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtFetkovichN As Control = Me.txtFetkovichN
			CtrlUI.Control_LostFocus(txtFetkovichN)
			Me.txtFetkovichN = CType(txtFetkovichN, TextBox)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = flag
			Dim txtFetkovichN2 As TextBox = Me.txtFetkovichN
			Dim obj As Object
			Dim num As Integer = CInt(Me.CheckValid(txtFetkovichN2, -1S, 0S, obj))
			Me.txtFetkovichN = txtFetkovichN2
			If flag2 = (num <> 0) Then
				Me.SetRequiredTextField(Me.txtFetkovichN)
				Return
			End If
			Dim obj2 As Object = flag
			Dim lowerBound As Single = 0.5F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 22
			Dim useMetric As Integer = 0
			Dim canadianIsMetric As Integer = -1
			Dim bQuiet As Boolean = False
			Dim text As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Me.txtFetkovichN.Focus()
				Return
			End If
			Dim obj3 As Object = flag
			Dim upperBound As Single = 1F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = 22
			Dim useMetric2 As Integer = 0
			Dim canadianIsMetric2 As Integer = -1
			Dim bQuiet2 As Boolean = False
			text = ""
			If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
				Me.txtFetkovichN.Focus()
				Return
			End If
			txtFetkovichN2 = Me.txtFetkovichN
			Dim label_FetkovichN As Label = Me._Label_FetkovichN
			CtrlUI.TextBox_LostFocus(txtFetkovichN2, label_FetkovichN, True)
			Me._Label_FetkovichN = label_FetkovichN
			Me.txtFetkovichN = txtFetkovichN2
			ini.SaveDataValue("FetkovichN", RuntimeHelpers.GetObjectValue(obj))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.rst.FetkovichN = -1F
			Else
				RSWIN_DESC.rst.FetkovichN = Conversions.ToSingle(obj)
			End If
			Me.GetTestPoints()
			Me.CheckIPR(False, False)
		End Sub

		Private Sub txtFLPIP_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim text As String = ""
			Dim txtFLPIP As Control = Me.txtFLPIP
			CtrlUI.Control_LostFocus(txtFLPIP)
			Me.txtFLPIP = CType(txtFLPIP, TextBox)
			Select Case RSWIN_DESC.rst.giFluidLevelSource
				Case 1S
					Dim flag As Boolean = False
					Dim flag2 As Boolean = flag
					Dim txtFLPIP2 As TextBox = Me.txtFLPIP
					Dim obj As Object
					Dim num As Integer = CInt(Me.CheckValid(txtFLPIP2, -1S, 0S, obj))
					Me.txtFLPIP = txtFLPIP2
					If flag2 = (num <> 0) Then
						Me.SetRequiredTextField(Me.txtFLPIP)
						Return
					End If
					Dim obj2 As Object = flag
					Dim lowerBound As Single = 0F
					Dim inclusive As Integer = -1
					Dim errnum As Integer = 105
					Dim useMetric As Integer = 0
					Dim canadianIsMetric As Integer = 0
					Dim bQuiet As Boolean = False
					Dim text2 As String = ""
					If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text2), False) Then
						Me.txtFLPIP.Focus()
						Return
					End If
					If Operators.ConditionalCompareObjectEqual(flag, Util.CheckUpper(obj, RSWIN_DESC.rst.PumpDepth, -1, 103, 0, 0, True, text), False) Then
						If Not Me.bFLMsgShown Then
							MessageBox.Show(text)
							Me.bFLMsgShown = True
						End If
						Me.txtFLPIP.Focus()
						Return
					End If
					txtFLPIP2 = Me.txtFLPIP
					Dim label_ As Label = Me._Label_3
					CtrlUI.TextBox_LostFocus(txtFLPIP2, label_, True)
					Me._Label_3 = label_
					Me.txtFLPIP = txtFLPIP2
					ini.SaveDataValue("FluidLevel", RuntimeHelpers.GetObjectValue(obj))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						RSWIN_DESC.rst.FluidLevel = Conversions.ToSingle(obj)
						RSWIN_DESC.rst.PumpIntakePressure = CSng((CDbl(((RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.rst.FluidLevel) * RSWIN_DESC.rst.OilSPGR)) * 0.433 + CDbl(RSWIN_DESC.rst.CasingPressure) + 14.7))
						If CDbl(RSWIN_DESC.rst.PumpIntakePressure) > 0.433 * CDbl(RSWIN_DESC.rst.PumpDepth) Then
							MessageBox.Show(RSWIN_DESC.sIncorrectFluidLevel)
						End If
					End If
					Return
				Case 2S
					Dim flag3 As Boolean = False
					Dim flag4 As Boolean = flag3
					Dim txtFLPIP2 As TextBox = Me.txtFLPIP
					Dim obj As Object
					Dim num2 As Integer = CInt(Me.CheckValid(txtFLPIP2, -1S, 0S, obj))
					Me.txtFLPIP = txtFLPIP2
					If flag4 = (num2 <> 0) Then
						Me.SetRequiredTextField(Me.txtFLPIP)
					Else
						Dim obj3 As Object = flag3
						Dim casingPressure As Single = RSWIN_DESC.rst.CasingPressure
						Dim inclusive2 As Integer = -1
						Dim errnum2 As Integer = 125
						Dim useMetric2 As Integer = 0
						Dim canadianIsMetric2 As Integer = 0
						Dim bQuiet2 As Boolean = False
						Dim text2 As String = ""
						If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckLower(obj, casingPressure, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text2), False) Then
							Me.txtFLPIP.Focus()
						Else
							Dim obj4 As Object = flag3
							Dim upperBound As Single = CSng((0.433 * CDbl(RSWIN_DESC.rst.PumpDepth)))
							Dim inclusive3 As Integer = -1
							Dim errnum3 As Integer = 123
							Dim useMetric3 As Integer = 0
							Dim canadianIsMetric3 As Integer = 0
							Dim bQuiet3 As Boolean = False
							text2 = ""
							If Operators.ConditionalCompareObjectEqual(obj4, Util.CheckUpper(obj, upperBound, inclusive3, errnum3, useMetric3, canadianIsMetric3, bQuiet3, text2), False) Then
								Me.txtFLPIP.Focus()
							Else
								txtFLPIP2 = Me.txtFLPIP
								Dim label_ As Label = Me._Label_3
								CtrlUI.TextBox_LostFocus(txtFLPIP2, label_, True)
								Me._Label_3 = label_
								Me.txtFLPIP = txtFLPIP2
								ini.SaveDataValue("PumpIntakePressure", RuntimeHelpers.GetObjectValue(obj))
								If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
									RSWIN_DESC.rst.PumpIntakePressure = Conversions.ToSingle(obj)
								End If
							End If
						End If
					End If
					Return
				Case Else
					Return
			End Select
		End Sub

		Private Sub txtSPMBFPD_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim text As String = ""
			Dim txtSPMBFPD As Control = Me.txtSPMBFPD
			CtrlUI.Control_LostFocus(txtSPMBFPD)
			Me.txtSPMBFPD = CType(txtSPMBFPD, TextBox)
			If Me._optSPMBFPD_0.Checked Then
				Dim flag As Boolean = False
				Dim flag2 As Boolean = flag
				Dim txtSPMBFPD2 As TextBox = Me.txtSPMBFPD
				Dim obj As Object
				Dim num As Integer = CInt(Me.CheckValid(txtSPMBFPD2, -1S, 0S, obj))
				Me.txtSPMBFPD = txtSPMBFPD2
				If flag2 = (num <> 0) Then
					Me.SetRequiredTextField(Me.txtSPMBFPD)
					Return
				End If
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 0.7F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 68
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text2 As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text2), False) Then
					Me.txtSPMBFPD.Focus()
					Return
				End If
				Dim obj3 As Object = flag
				Dim upperBound As Single = 50F
				Dim inclusive2 As Integer = -1
				Dim errnum2 As Integer = 68
				Dim useMetric2 As Integer = 0
				Dim canadianIsMetric2 As Integer = 0
				Dim bQuiet2 As Boolean = False
				text2 = ""
				If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text2), False) Then
					Me.txtSPMBFPD.Focus()
					Return
				End If
				txtSPMBFPD2 = Me.txtSPMBFPD
				Dim label_SPMBFPD As Label = Me._Label_SPMBFPD
				CtrlUI.TextBox_LostFocus(txtSPMBFPD2, label_SPMBFPD, True)
				Me._Label_SPMBFPD = label_SPMBFPD
				Me.txtSPMBFPD = txtSPMBFPD2
				ini.SaveDataValue("PumpingSpeed", RuntimeHelpers.GetObjectValue(obj))
				RSWIN_DESC.rst.SPMEntered = -1S
				ini.SaveDataValue("SPMEntered", RSWIN_DESC.rst.SPMEntered)
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.rst.SPM = Conversions.ToSingle(obj)
				End If
				Return
			Else
				If Me._optSPMBFPD_1.Checked Then
					Dim errnum3 As Integer
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						errnum3 = 148
					Else
						errnum3 = 147
					End If
					Dim flag3 As Boolean = False
					Dim flag4 As Boolean = flag3
					Dim txtSPMBFPD2 As TextBox = Me.txtSPMBFPD
					Dim obj As Object
					Dim num2 As Integer = CInt(Me.CheckValid(txtSPMBFPD2, -1S, 0S, obj))
					Me.txtSPMBFPD = txtSPMBFPD2
					If flag4 = (num2 <> 0) Then
						Me.SetRequiredTextField(Me.txtSPMBFPD)
					ElseIf Operators.ConditionalCompareObjectEqual(flag3, Util.CheckLower(obj, 9.99F, 0, errnum3, 0, 0, True, text), False) Then
						If Not Me.bLowerTargetMsgShown Then
							MessageBox.Show(text)
						End If
						Me.bLowerTargetMsgShown = True
						Me.txtSPMBFPD.Focus()
					Else
						Dim obj4 As Object = flag3
						Dim upperBound2 As Single = 8000F
						Dim inclusive3 As Integer = -1
						Dim errnum4 As Integer = 144
						Dim useMetric3 As Integer = -1
						Dim canadianIsMetric3 As Integer = 0
						Dim bQuiet3 As Boolean = Me.bUpperTargetMsgShown
						Dim text2 As String = ""
						If Operators.ConditionalCompareObjectEqual(obj4, Util.CheckUpper(obj, upperBound2, inclusive3, errnum4, useMetric3, canadianIsMetric3, bQuiet3, text2), False) Then
							Me.bUpperTargetMsgShown = True
							Me.txtSPMBFPD.Focus()
						Else
							txtSPMBFPD2 = Me.txtSPMBFPD
							Dim label_SPMBFPD As Label = Me._Label_SPMBFPD
							CtrlUI.TextBox_LostFocus(txtSPMBFPD2, label_SPMBFPD, True)
							Me._Label_SPMBFPD = label_SPMBFPD
							Me.txtSPMBFPD = txtSPMBFPD2
							ini.SaveDataValue("TargetBFPD", RuntimeHelpers.GetObjectValue(obj))
							RSWIN_DESC.rst.SPMEntered = 0S
							ini.SaveDataValue("SPMEntered", RSWIN_DESC.rst.SPMEntered)
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
								RSWIN_DESC.rst.TargetBFPD = Conversions.ToSingle(obj)
								Me.EnableFluidInertia()
								Me.GetTestPoints()
								Me.CheckIPR(False, False)
							End If
							If(If((-If(((RSWIN_DESC.bExpert And Not RSWIN_DESC.bReadingFile) > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_DisplayTargetBFPDWarning And If((-If((RSWIN_DESC.rst.Runtime < 24F > False), 1S, 0S)), 1S, 0S) And If((-If((Not Me.bAlreadyAskedTargetBFPDQuestion > False), 1S, 0S)), 1S, 0S)) <> 0S Then
								Me.bAlreadyAskedTargetBFPDQuestion = True
								Util.Message("To change the runtime or target production click on 'No'.")
								Dim dialogResult As DialogResult = MessageBox.Show(" Do you want to achieve this target production with a runtime of " + Conversions.ToString(RSWIN_DESC.rst.Runtime) + " hours? ", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
								If dialogResult = DialogResult.No Then
									Me.txtSPMBFPD.Focus()
								End If
								Util.Message(" ")
							End If
						End If
					End If
					Return
				End If
				Return
			End If
		End Sub

		Private Sub txtStaticBHPressure_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtStaticBHPressure As Control = Me.txtStaticBHPressure
			CtrlUI.Control_LostFocus(txtStaticBHPressure)
			Me.txtStaticBHPressure = CType(txtStaticBHPressure, TextBox)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = flag
			Dim txtStaticBHPressure2 As TextBox = Me.txtStaticBHPressure
			Dim obj As Object
			Dim num As Integer = CInt(Me.CheckValid(txtStaticBHPressure2, -1S, 0S, obj))
			Me.txtStaticBHPressure = txtStaticBHPressure2
			If flag2 = (num <> 0) Then
				Me.SetRequiredTextField(Me.txtStaticBHPressure)
				Return
			End If
			Dim obj2 As Object = flag
			Dim lowerBound As Single = 10F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 71
			Dim useMetric As Integer = -1
			Dim canadianIsMetric As Integer = -1
			Dim bQuiet As Boolean = False
			Dim text As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Me.txtStaticBHPressure.Focus()
				Return
			End If
			Dim obj3 As Object = flag
			Dim upperBound As Single = 8000F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = 71
			Dim useMetric2 As Integer = -1
			Dim canadianIsMetric2 As Integer = -1
			Dim bQuiet2 As Boolean = False
			text = ""
			If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
				Me.txtStaticBHPressure.Focus()
				Return
			End If
			txtStaticBHPressure2 = Me.txtStaticBHPressure
			Dim label_StaticBHPressure As Label = Me._Label_StaticBHPressure
			CtrlUI.TextBox_LostFocus(txtStaticBHPressure2, label_StaticBHPressure, True)
			Me._Label_StaticBHPressure = label_StaticBHPressure
			Me.txtStaticBHPressure = txtStaticBHPressure2
			ini.SaveDataValue("StaticBHPressure", RuntimeHelpers.GetObjectValue(obj))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.rst.StaticBHPressure = -1F
			Else
				RSWIN_DESC.rst.StaticBHPressure = Conversions.ToSingle(obj)
			End If
			Me.GetTestPoints()
			Me.CheckIPR(False, False)
		End Sub

		Public Function CheckValid(ByRef txt As TextBox, bValidIfEmpty As Short, bShowMessage As Short, ByRef Value As Object) As Short
			Dim result As Short
			Try
				Value = DBNull.Value
				If Information.IsDBNull(txt.Text) Then
					result = 0S
				ElseIf Not Util.ValidNumber(txt.Text, bShowMessage) <> 0S Then
					result = 0S
				ElseIf Strings.Len(Strings.Trim(txt.Text)) = 0 Then
					result = bValidIfEmpty
				Else
					Value = Convert.ToSingle(txt.Text)
					If Strings.Len(RuntimeHelpers.GetObjectValue(txt.Tag)) > 0 AndAlso CtrlUI.TextBox_GetUnitSystem(txt) <> 1 Then
						Dim num As Single = Conversions.ToSingle(Value)
						Dim control As Control = txt
						Dim units As String = CtrlUI.TextBox_GetUnitType(control)
						txt = CType(control, TextBox)
						CtrlUI.ConvertValue(num, units, True)
						Value = num
					End If
					result = -1S
				End If
			Catch ex As Exception
				result = 0S
			End Try
			Return result
		End Function

		Public Sub DisplayProdInfoError(sMsg As String, ByRef bCancel As Boolean)
			Try
				bCancel = False
				If Not Me.bClosing Then
					Dim sMsgType As String = "Data Entry Error"
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				Else
					Dim dialogResult2 As DialogResult
					Util.SendMessage(sMsg, "Data Entry Error", Me.bClosing, dialogResult2)
					If dialogResult2 = DialogResult.Cancel Then
						bCancel = True
					ElseIf dialogResult2 = DialogResult.OK Then
						bCancel = False
					End If
				End If
			Catch ex As Exception
			End Try
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

		Private Sub txtFLPIP_Enter(sender As Object, e As EventArgs)
			Me.txtFLPIP.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtSPMBFPD_Enter(sender As Object, e As EventArgs)
			Me.txtSPMBFPD.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboIPRMethod_Enter(sender As Object, e As EventArgs)
			Me.cboIPRMethod.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboIPRMethod_Leave(sender As Object, e As EventArgs)
			Dim cboIPRMethod As Control = Me.cboIPRMethod
			CtrlUI.Control_LostFocus(cboIPRMethod)
			Me.cboIPRMethod = CType(cboIPRMethod, ComboBox)
		End Sub

		Private Sub txtFetkovichN_Enter(sender As Object, e As EventArgs)
			Me.txtFetkovichN.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtStaticBHPressure_Enter(sender As Object, e As EventArgs)
			Me.txtStaticBHPressure.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtBubblePointe_Enter(sender As Object, e As EventArgs)
			Me.txtBubblePoint.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub chkCalculateN_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim chkCalculateN As CheckBox = Me.chkCalculateN
				Me.chkCalculateN_Click_1(chkCalculateN.Checked, Me.chkCalculateN Is Me.ActiveControl)
				Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.chkCalculateN)
				If RSWIN_DESC.rst.giIPRMethod <> 0S Then
					Me.txtFetkovichN.Enabled = False
				ElseIf Me.chkCalculateN.Checked Then
					Me.txtFetkovichN.Enabled = False
				Else
					Me.txtFetkovichN.Enabled = True
				End If
				Me.txtFetkovichNEnabledChanged()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboTestPointType_Enter(sender As Object, e As EventArgs)
			Me.cboTestPointType.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboTestPointType_Leave(sender As Object, e As EventArgs)
			Dim cboTestPointType As Control = Me.cboTestPointType
			CtrlUI.Control_LostFocus(cboTestPointType)
			Me.cboTestPointType = CType(cboTestPointType, ComboBox)
		End Sub

		Private Sub TextBox_Change(ByRef txt As TextBox, ByRef lbl As Label)
			If Me.ActiveControl IsNot txt Then
				CtrlUI.TextBox_LostFocus(txt, lbl, True)
			Else
				Me.bValidated = False
				RSWIN_DESC.rst.gbInputDataChanged = True
				Me.TurnOffViewReportOption()
			End If
			RSWIN_DESC.frmMain.ToolbarButtonSetState(16, Me.CheckRequiredTextFields())
			If Me.ActiveControl Is txt Then
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Not Me.bAIPreferencesSet Then
					MRodstarXML.SetAIFilePreferencesFromSetup(True)
					Me.bAIPreferencesSet = True
				End If
				Return
			End If
		End Sub

		Private Sub optFLPIP_Click_1(Index As Integer, Value As Integer, Clicked As Boolean)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Not Me.$STATIC$optFLPIP_Click_1$2031882$busy Then
					If If((-If((Me.GetOptFLPIP(Index) > False), 1, 0)), 1, 0) <> Value Then
						Me.$STATIC$optFLPIP_Click_1$2031882$busy = True
						Me.SetOptFLPIP(Index, Value <> 0)
						Me.$STATIC$optFLPIP_Click_1$2031882$busy = False
					End If
					If((Value And If((-If(((Index = 0) > False), 1, 0)), 1, 0)) Or If((-If(((Index = 1) > False), 1, 0)), 1, 0)) <> 0 Then
						Me.txtFLPIP.Enabled = True
					ElseIf(Value And If((-If(((Index = 2) > False), 1, 0)), 1, 0)) <> 0 Then
						Me.txtFLPIP.Enabled = False
					End If
					If Me.txtFLPIP.Enabled Then
						Me.txtFLPIP.BackColor = Color.White
					Else
						Me.txtFLPIP.BackColor = Color.LightGray
					End If
					Me._optFLPIP_0.Enabled = (Index <> 2 And Index <> 3)
					Me._optFLPIP_1.Enabled = (Index <> 2 And Index <> 3)
					If rst.FluidLevelEntered And Index <> 0 Then
						If Strings.Len(Strings.Trim(Me.txtFLPIP.Text)) = 0 Then
							Me.txtFLPIP.Text = ""
						Else
							Me.txtFLPIP.Text = Convert.ToString(rst.FluidLevel)
						End If
					ElseIf Not rst.FluidLevelEntered And Index <> 1 Then
						If Strings.Len(Strings.Trim(Me.txtFLPIP.Text)) = 0 Then
							Me.txtFLPIP.Text = ""
						Else
							Me.txtFLPIP.Text = Convert.ToString(rst.PumpIntakePressure)
						End If
					End If
					Select Case Index
						Case 0
							If Value <> 0 Then
								Me._Label_3.Text = Me.CAP_FLUIDLEVEL
								Me._Label_3.Tag = Me.TAG_FLUIDLEVEL
								Me.txtFLPIP.Tag = "fem"
								Dim txtFLPIP As TextBox = Me.txtFLPIP
								Dim rst2 As cRODSTAR = RSWIN_DESC.rst
								Dim fluidLevel As Single = rst2.FluidLevel
								Dim text As String = "######.##"
								Dim text2 As String = Util.Format(fluidLevel, text)
								rst2.FluidLevel = fluidLevel
								txtFLPIP.Text = text2
								Dim txtFLPIP2 As TextBox = Me.txtFLPIP
								Dim label_ As Label = Me._Label_3
								Me.ToggelControl(txtFLPIP2, label_, True)
								Me._Label_3 = label_
								Me.txtFLPIP = txtFLPIP2
								Me.txtFLPIP.Enabled = True
								rst.FluidLevelEntered = True
								Me.mbFluidLevelEnteredWas = -1S
								rst.gbCalcPumpIntakePressure = False
								rst.giFluidLevelSource = 1S
								ini.SaveDataValue("FluidLevelSource", 1)
							End If
						Case 1
							If Value <> 0 Then
								Me._Label_3.Text = Me.CAP_PUMPINTAKE
								Me._Label_3.Tag = Me.TAG_PUMPINTAKE
								Me.txtFLPIP.Tag = "pem"
								Dim txtFLPIP3 As TextBox = Me.txtFLPIP
								Dim fluidLevel As Single = RSWIN_DESC.rst.PumpIntakePressure
								txtFLPIP3.Text = fluidLevel.ToString()
								Dim txtFLPIP2 As TextBox = Me.txtFLPIP
								Dim label_ As Label = Me._Label_3
								Me.ToggelControl(txtFLPIP2, label_, True)
								Me._Label_3 = label_
								Me.txtFLPIP = txtFLPIP2
								Me.txtFLPIP.Enabled = True
								rst.FluidLevelEntered = False
								Me.mbFluidLevelEnteredWas = 0S
								rst.gbCalcPumpIntakePressure = False
								rst.giFluidLevelSource = 2S
								ini.SaveDataValue("FluidLevelSource", 2)
							End If
						Case 2
							If Value <> 0 Then
								Me._Label_3.Text = Me.CAP_PUMPINTAKE
								Me._Label_3.Tag = Me.TAG_PUMPINTAKE
								If Me.GetOptSPMBFPD(2) Or Me.GetOptSPMBFPD(1) Then
									Me.optSPMBFPD_Click_1(0, -1, True)
								End If
								Me.txtFLPIP.Text = "calculated"
								Me.txtFLPIP.Tag = "pem"
								rst.gbCalcPumpCondition = True
								Dim txtFLPIP2 As TextBox = Me.txtFLPIP
								Dim label_ As Label = Me._Label_3
								Me.ToggelControl(txtFLPIP2, label_, True)
								Me._Label_3 = label_
								Me.txtFLPIP = txtFLPIP2
								If Not rst.gbUseIPR Then
									Dim flag As Boolean = True
									Me.chkIPRData_Click_1(flag, False)
								End If
								rst.gbCalcPumpIntakePressure = False
								ini.SaveDataValue("FluidLevelSource", 2)
							End If
						Case 3
							If Value <> 0 Then
								Me._Label_3.Tag = Me.TAG_FLUIDLEVEL
								Me.txtFLPIP.Tag = "fem"
								rst.FluidLevel = rst.PumpDepth
								Dim txtFLPIP4 As TextBox = Me.txtFLPIP
								Dim fluidLevel As Single = rst.FluidLevel
								txtFLPIP4.Text = fluidLevel.ToString()
								Dim txtFLPIP2 As TextBox = Me.txtFLPIP
								Dim label_ As Label = Me._Label_3
								Me.ToggelControl(txtFLPIP2, label_, True)
								Me._Label_3 = label_
								Me.txtFLPIP = txtFLPIP2
								rst.FluidLevelEntered = True
								rst.gbCalcPumpIntakePressure = False
								ini.SaveDataValue("FluidLevelSource", 1)
							End If
						Case 4
							If Value <> 0 Then
								Me._Label_3.Text = Me.CAP_PUMPINTAKE
								Me._Label_3.Tag = Me.TAG_PUMPINTAKE
								Me.txtFLPIP.Text = "calculated"
								Me.txtFLPIP.Tag = "pem"
								Me.txtFLPIP.Enabled = False
								RSWIN_DESC.rst.gbCalcPumpIntakePressure = True
								Dim txtFLPIP2 As TextBox = Me.txtFLPIP
								Dim label_ As Label = Me._Label_3
								Me.ToggelControl(txtFLPIP2, label_, True)
								Me._Label_3 = label_
								Me.txtFLPIP = txtFLPIP2
								If Me.GetOptSPMBFPD(0) Or Me.GetOptSPMBFPD(2) Then
									Me.optSPMBFPD_Click_1(1, -1, True)
								End If
								If Not rst.gbUseIPR Then
									Dim flag As Boolean = True
									Me.chkIPRData_Click_1(flag, False)
									Me.txtFLPIP.Text = ""
								End If
								rst.FluidLevelEntered = False
								rst.gbCalcPumpIntakePressure = True
								rst.giFluidLevelSource = 0S
								ini.SaveDataValue("FluidLevelSource", 4)
								Me.GetTestPoints()
								Me.CheckIPR(False, False)
							End If
					End Select
					If Me.txtFLPIP.Enabled Then
						Me.txtFLPIP.BackColor = Color.White
					Else
						Me.txtFLPIP.BackColor = Color.LightGray
					End If
					ini.SaveDataValue("CalcPumpIntakePressure", rst.gbCalcPumpIntakePressure)
					ini.SaveDataValue("FluidLevelEntered", rst.FluidLevelEntered)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub optSPMBFPD_Click_1(Index As Integer, Value As Integer, Clicked As Boolean)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Me.$STATIC$optSPMBFPD_Click_1$2031882$busy Then
				Return
			End If
			If If((-If((Me.GetOptSPMBFPD(Index) > False), 1, 0)), 1, 0) <> Value Then
				Me.$STATIC$optSPMBFPD_Click_1$2031882$busy = True
				Me.SetOptSPMBFPD(Index, Value <> 0)
				Me.$STATIC$optSPMBFPD_Click_1$2031882$busy = False
			End If
			If Not rst.gbCalcTargetBFPD Then
				If(rst.SPMEntered And If((-If(((Index <> 0) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					If Me.txtSPMBFPD.Text.Trim().Length <> 0 Then
					End If
				ElseIf(Not rst.SPMEntered And If((-If(((Index <> 1) > False), 1S, 0S)), 1S, 0S)) = 0S OrElse Strings.Len(Strings.Trim(Me.txtSPMBFPD.Text)) <> 0 Then
				End If
			End If
			Select Case Index
				Case 0
					If Value <> 0 Then
						Me._Label_SPMBFPD.Text = Me.CAP_SPM
						Me._Label_SPMBFPD.Tag = Me.TAG_SPM
						Me.txtSPMBFPD.Tag = ""
						Me.txtSPMBFPD.Tag = RuntimeHelpers.GetObjectValue(Me._optSPMBFPD_0.Tag)
						If rst.SPM = 0F Then
							Me.txtSPMBFPD.Text = ""
							Me.txtSPMBFPD.BackColor = RSWIN_DESC.rgbEditRequired
						Else
							Me.txtSPMBFPD.Text = rst.SPM.ToString()
							Me.txtSPMBFPD.BackColor = Color.White
						End If
						If Me._optSPMBFPD_0 Is Me.ActiveControl Then
							Dim txtSPMBFPD As Control = Me.txtSPMBFPD
							Me.SetActiveControl(txtSPMBFPD)
							Me.txtSPMBFPD = CType(txtSPMBFPD, TextBox)
						End If
						If Me.GetOptFLPIP(4) Then
							If Me.mbFluidLevelEnteredWas <> 0S Then
								Me.optFLPIP_Click_1(0, -1, True)
							Else
								Me.optFLPIP_Click_1(1, -1, True)
							End If
						End If
						rst.SPMEntered = -1S
						rst.gbCalcTargetBFPD = False
					End If
				Case 1
					If Value <> 0 Then
						Me._Label_SPMBFPD.Text = Me.CAP_BFPD
						Me._Label_SPMBFPD.Tag = Me.TAG_BFPD
						Me.txtSPMBFPD.Enabled = True
						Me.lblSPMBFPD_Disabled.SendToBack()
						If rst.TargetBFPD = 0F Then
							Me.txtSPMBFPD.Tag = "bem"
							Me.txtSPMBFPD.Text = "0"
							Me.txtSPMBFPD.Text = ""
							Me.txtSPMBFPD.BackColor = RSWIN_DESC.rgbEditRequired
						Else
							Me.txtSPMBFPD.Tag = "bem"
							Me.txtSPMBFPD.Text = RSWIN_DESC.rst.TargetBFPD.ToString()
							Me.txtSPMBFPD.BackColor = Color.White
						End If
						If Me._optSPMBFPD_1 Is Me.ActiveControl Then
							Dim txtSPMBFPD As Control = Me.txtSPMBFPD
							Me.SetActiveControl(txtSPMBFPD)
							Me.txtSPMBFPD = CType(txtSPMBFPD, TextBox)
						End If
						rst.SPMEntered = 0S
						rst.gbCalcTargetBFPD = False
					End If
				Case 2
					If Value <> 0 Then
						Me._Label_SPMBFPD.Text = Me.CAP_BFPD
						Me._Label_SPMBFPD.Tag = Me.TAG_BFPD
						Me.txtSPMBFPD.Tag = "bem"
						If Me.GetOptFLPIP(2) Then
							Me.optFLPIP_Click_1(1, -1, True)
						End If
						If Me.GetOptFLPIP(4) Then
							If Me.mbFluidLevelEnteredWas <> 0S Then
								Me.optFLPIP_Click_1(0, -1, True)
							Else
								Me.optFLPIP_Click_1(1, -1, True)
							End If
						End If
						If Not rst.gbUseIPR Then
							Dim flag As Boolean = True
							Me.chkIPRData_Click_1(flag, False)
						End If
						rst.SPMEntered = 0S
						rst.gbCalcTargetBFPD = True
						Me.GetTestPoints()
						Me.CheckIPR(False, False)
					End If
			End Select
			Me.txtSPMBFPD.Enabled = (Index <> 2)
			ini.SaveDataValue("SPMEntered", rst.SPMEntered)
			ini.SaveDataValue("gbCalcTargetBFPD", rst.gbCalcTargetBFPD)
			Me.EnableFluidInertia()
		End Sub

		Public Function SetOptSPMBFPD(Index As Integer, bVal As Boolean) As Boolean
			Select Case Index
				Case 0
					Me._optSPMBFPD_0.Checked = bVal
				Case 1
					Me._optSPMBFPD_1.Checked = bVal
				Case 2
					Me._optSPMBFPD_2.Checked = bVal
			End Select
			Dim result As Boolean
			Return result
		End Function

		Public Function GetOptSPMBFPD(Index As Integer) As Boolean
			Select Case Index
				Case 0
					Return Me._optSPMBFPD_0.Checked
				Case 1
					Return Me._optSPMBFPD_1.Checked
				Case 2
					Return Me._optSPMBFPD_2.Checked
				Case Else
					Dim result As Boolean
					Return result
			End Select
		End Function

		Public Function SetOptFLPIPTag(Index As Integer, sVal As String) As Boolean
			Select Case Index
				Case 0
					Me._optFLPIP_0.Tag = sVal
				Case 1
					Me._optFLPIP_1.Tag = sVal
				Case 2
					Me._optFLPIP_2.Tag = sVal
				Case 3
					Me._optFLPIP_3.Tag = sVal
				Case 4
					Me._optFLPIP_4.Tag = sVal
			End Select
			Dim result As Boolean
			Return result
		End Function

		Public Function SetOptFLPIP(Index As Integer, bVal As Boolean) As Boolean
			Select Case Index
				Case 0
					Me._optFLPIP_0.Checked = bVal
				Case 1
					Me._optFLPIP_1.Checked = bVal
				Case 2
					Me._optFLPIP_2.Checked = bVal
				Case 3
					Me._optFLPIP_3.Checked = bVal
				Case 4
					Me._optFLPIP_4.Checked = bVal
			End Select
			Dim result As Boolean
			Return result
		End Function

		Public Function GetOptFLPIP(Index As Integer) As Boolean
			Select Case Index
				Case 0
					Return Me._optFLPIP_0.Checked
				Case 1
					Return Me._optFLPIP_1.Checked
				Case 2
					Return Me._optFLPIP_2.Checked
				Case 3
					Return Me._optFLPIP_3.Checked
				Case 4
					Return Me._optFLPIP_4.Checked
				Case Else
					Dim result As Boolean
					Return result
			End Select
		End Function

		Private Sub _optFLPIP_0_CheckedChanged(sender As Object, e As EventArgs)
			Me.optFLPIP_Click_1(0, If((-If((Me._optFLPIP_0.Checked > False), 1, 0)), 1, 0), Me.ActiveControl Is Me._optFLPIP_0)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me._optFLPIP_0)
		End Sub

		Private Sub _optFLPIP_1_CheckedChanged(sender As Object, e As EventArgs)
			If Me._optFLPIP_1.Checked And Operators.CompareString(Me.txtFLPIP.Text, "calculated", False) = 0 Then
				Me.txtFLPIP.Text = Convert.ToString(RSWIN_DESC.rst.PumpIntakePressure)
			End If
			Me.optFLPIP_Click_1(1, If((-If((Me._optFLPIP_1.Checked > False), 1, 0)), 1, 0), Me.ActiveControl Is Me._optFLPIP_1)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me._optFLPIP_1)
		End Sub

		Private Sub _optFLPIP_2_CheckedChanged(sender As Object, e As EventArgs)
			Me.optFLPIP_Click_1(2, If((-If((Me._optFLPIP_2.Checked > False), 1, 0)), 1, 0), Me.ActiveControl Is Me._optFLPIP_2)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me._optFLPIP_2)
		End Sub

		Private Sub _optFLPIP_3_CheckedChanged(sender As Object, e As EventArgs)
			Me.optFLPIP_Click_1(3, If((-If((Me._optFLPIP_3.Checked > False), 1, 0)), 1, 0), Me.ActiveControl Is Me._optFLPIP_3)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me._optFLPIP_3)
		End Sub

		Private Sub _optFLPIP_4_CheckedChanged(sender As Object, e As EventArgs)
			Me.optFLPIP_Click_1(4, If((-If((Me._optFLPIP_4.Checked > False), 1, 0)), 1, 0), Me.ActiveControl Is Me._optFLPIP_4)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me._optFLPIP_4)
		End Sub

		Private Sub _optSPMBFPD_0_CheckedChanged(sender As Object, e As EventArgs)
			Me.optSPMBFPD_Click_1(0, If((-If((Me._optSPMBFPD_0.Checked > False), 1, 0)), 1, 0), True)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me._optSPMBFPD_0)
		End Sub

		Private Sub _optSPMBFPD_1_CheckedChanged(sender As Object, e As EventArgs)
			Me.optSPMBFPD_Click_1(1, If((-If((Me._optSPMBFPD_1.Checked > False), 1, 0)), 1, 0), True)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me._optSPMBFPD_1)
		End Sub

		Private Sub _optSPMBFPD_2_CheckedChanged(sender As Object, e As EventArgs)
			Me.optSPMBFPD_Click_1(2, If((-If((Me._optSPMBFPD_2.Checked > False), 1, 0)), 1, 0), True)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me._optSPMBFPD_2)
		End Sub

		Private Sub txtFLPIP_GotFocus(sender As Object, e As EventArgs)
			Me.txtFLPIP.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Function CheckRequiredTextFields() As Boolean
			Dim result As Boolean = False
			Try
				result = (Me.CheckIPRFields() And Me.CheckFLPIP() And Me.CheckSPMBFPD())
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function CheckIPRFields() As Boolean
			Dim result As Boolean = False
			If Not RSWIN_DESC.rst.gbUseIPR Then
				result = True
			ElseIf RSWIN_DESC.rst.gnTestPoints <> 0S And Operators.CompareString(Me.txtMidPerfDepth.Text, "", False) <> 0 And Operators.CompareString(Me.txtStaticBHPressure.Text, "", False) <> 0 And (RSWIN_DESC.rst.giIPRMethod = 1S Or (RSWIN_DESC.rst.giIPRMethod = 0S And (Operators.CompareString(Me.txtFetkovichN.Text, "", False) <> 0 Or Me.chkCalculateN.Checked))) And (Me.chkBelowBPP.Checked Or Operators.CompareString(Me.txtBubblePoint.Text, "", False) <> 0) Then
				result = True
			End If
			Return result
		End Function

		Public Function CheckFLPIP() As Boolean
			Dim result As Boolean = False
			If RSWIN_DESC.rst.giFluidLevelSource = 0S Then
				result = True
			ElseIf Operators.CompareString(Me.txtFLPIP.Text, "", False) <> 0 Then
				result = True
			End If
			Return result
		End Function

		Public Function CheckSPMBFPD() As Boolean
			Dim result As Boolean = False
			If RSWIN_DESC.rst.gbCalcTargetBFPD Then
				result = True
			ElseIf Operators.CompareString(Me.txtSPMBFPD.Text, "", False) <> 0 Then
				result = True
			End If
			Return result
		End Function

		Public Sub ToggelControl(ByRef txt As TextBox, Optional ByRef lbl As Label = Nothing, Optional bRequiredColor As Boolean = True)
			If Strings.Len(RuntimeHelpers.GetObjectValue(txt.Tag)) > 0 Then
				Dim obj3 As Object
				If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					Dim obj As Object = CtrlUI.TextBox_GetUnitSystem(txt)
					Dim control As Control = txt
					Dim obj2 As Object = CtrlUI.TextBox_GetCanadianUnitSystem(control)
					txt = CType(control, TextBox)
					obj3 = RuntimeHelpers.GetObjectValue(Operators.CompareObjectNotEqual(obj, obj2, False))
				Else
					Dim num As Integer = CtrlUI.TextBox_GetUnitSystem(txt)
					obj3 = (CtrlUI.TextBox_GetUnitSystem(txt) <> RSWIN_DESC.SETUP_MeasurementSystem)
				End If
				If Conversions.ToBoolean(Operators.AndObject(obj3, lbl IsNot Nothing)) Then
					Dim control As Control = txt
					CtrlUI.TextBox_ToggleUnits(control, lbl)
					txt = CType(control, TextBox)
				End If
				Return
			End If
		End Sub

		Private Sub txtMidPerfDepth_TextChanged(sender As Object, e As EventArgs)
			Dim txtMidPerfDepth As TextBox = Me.txtMidPerfDepth
			Dim label_MidPerfDepth As Label = Me._Label_MidPerfDepth
			Me.TextBox_Change(txtMidPerfDepth, label_MidPerfDepth)
			Me._Label_MidPerfDepth = label_MidPerfDepth
			Me.txtMidPerfDepth = txtMidPerfDepth
			txtMidPerfDepth = Me.txtMidPerfDepth
			Util.SetFieldColor(txtMidPerfDepth)
			Me.txtMidPerfDepth = txtMidPerfDepth
			If Not(Me.ActiveControl Is Me.txtMidPerfDepth And Versioned.IsNumeric(Me.txtMidPerfDepth.Text)) Then
				Return
			End If
			If Operators.CompareString(Me.txtMidPerfDepth.Text.Trim(), ".", False) = 0 Then
				Return
			End If
			If Me.txtMidPerfDepth.Text.Length > 0 Then
				If Not Versioned.IsNumeric(Me.txtMidPerfDepth.Text) Then
					Dim sMsg As String = "Please enter value for Pump Depth"
					Dim sMsgType As String = "Data Entry Error"
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
					Me.txtMidPerfDepth.Text = ""
				Else
					txtMidPerfDepth = Me.txtMidPerfDepth
					Dim bValidIfEmpty As Short = -1S
					Dim bShowMessage As Short = 0S
					Dim num As Single
					Dim obj As Object = num
					Dim num2 As Integer = CInt(Me.CheckValid(txtMidPerfDepth, bValidIfEmpty, bShowMessage, obj))
					num = Conversions.ToSingle(obj)
					Me.txtMidPerfDepth = txtMidPerfDepth
					If num2 <> 0 Then
						RSWIN_DESC.rst.MidPerfDepth = num
					End If
				End If
			Else
				RSWIN_DESC.rst.MidPerfDepth = 0F
			End If
		End Sub

		Private Sub txtMidPerfDepth_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtMidPerfDepth As Control = Me.txtMidPerfDepth
			CtrlUI.Control_LostFocus(txtMidPerfDepth)
			Me.txtMidPerfDepth = CType(txtMidPerfDepth, TextBox)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = flag
			Dim txtMidPerfDepth2 As TextBox = Me.txtMidPerfDepth
			Dim obj As Object
			Dim num As Integer = CInt(Me.CheckValid(txtMidPerfDepth2, -1S, 0S, obj))
			Me.txtMidPerfDepth = txtMidPerfDepth2
			If flag2 = (num <> 0) Then
				Me.SetRequiredTextField(Me.txtMidPerfDepth)
				Return
			End If
			Dim obj2 As Object = flag
			Dim lowerBound As Single = 100F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 30
			Dim useMetric As Integer = -1
			Dim canadianIsMetric As Integer = -1
			Dim bQuiet As Boolean = False
			Dim text As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Me.txtMidPerfDepth.Focus()
				Return
			End If
			Dim obj3 As Object = flag
			Dim upperBound As Single = 20000F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = 30
			Dim useMetric2 As Integer = -1
			Dim canadianIsMetric2 As Integer = -1
			Dim bQuiet2 As Boolean = False
			text = ""
			If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
				Me.txtMidPerfDepth.Focus()
				Return
			End If
			txtMidPerfDepth2 = Me.txtMidPerfDepth
			Dim label_MidPerfDepth As Label = Me._Label_MidPerfDepth
			CtrlUI.TextBox_LostFocus(txtMidPerfDepth2, label_MidPerfDepth, True)
			Me._Label_MidPerfDepth = label_MidPerfDepth
			Me.txtMidPerfDepth = txtMidPerfDepth2
			ini.SaveDataValue("MidPerfDepth", RuntimeHelpers.GetObjectValue(obj))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.rst.MidPerfDepth = -1F
			Else
				RSWIN_DESC.rst.MidPerfDepth = Conversions.ToSingle(obj)
			End If
			Me.GetTestPoints()
			Me.CheckIPR(False, False)
		End Sub

		Private Sub txtMidPerfDepth_Enter(sender As Object, e As EventArgs)
			Me.txtMidPerfDepth.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtMidPerfDepth_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtMidPerfDepth As TextBox = Me.txtMidPerfDepth
			Dim label_MidPerfDepth As Label = Me._Label_MidPerfDepth
			CtrlUI.TextBox_KeyDown(txtMidPerfDepth, label_MidPerfDepth, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me._Label_MidPerfDepth = label_MidPerfDepth
			Me.txtMidPerfDepth = txtMidPerfDepth
		End Sub

		Private Sub txtFetkovichN_EnabledChanged(sender As Object, e As EventArgs)
			Me.txtFetkovichNEnabledChanged()
		End Sub

		Private Sub txtFetkovichNEnabledChanged()
			Try
				If Me.txtFetkovichN.Enabled Then
					Me.txtFetkovichN.BackColor = Color.White
					Me.lblFetkovichN_Disabled.SendToBack()
				Else
					Me.txtFetkovichN.BackColor = Color.LightGray
					Me.lblFetkovichN_Disabled.BringToFront()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtBubblePoint_EnabledChanged(sender As Object, e As EventArgs)
			Me.txtBubblePointEnabledChanged()
		End Sub

		Private Sub txtBubblePointEnabledChanged()
			If Not Me.txtBubblePoint.Enabled Then
				Me.txtBubblePoint.BackColor = Color.LightGray
				Me.lblBubblePoint_Disabled.BringToFront()
				Return
			End If
			Me.txtBubblePoint.BackColor = Color.White
			Me.lblBubblePoint_Disabled.SendToBack()
		End Sub

		Private Sub txtSPMBFPD_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtSPMBFPD.Enabled Then
				Me.txtSPMBFPD.BackColor = Color.White
				Me.lblSPMBFPD_Disabled.SendToBack()
				Return
			End If
			Me.txtSPMBFPD.BackColor = Color.LightGray
			Me.lblSPMBFPD_Disabled.BringToFront()
		End Sub

		Private Sub SetActiveControl(ByRef myControl As Control)
			Try
				myControl.Focus()
				Me.ActiveControl = myControl
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ProdInfo_Closed(sender As Object, e As EventArgs)
			Me.m_bClosing = False
		End Sub

		Public Sub CenterForm()
			' The following expression was wrapped in a checked-statement
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = New RODSTAR()
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				Me.Left = CInt(Math.Round(CDbl((Me.MyParentFrm.Width - Me.Width)) / 2.0 - 8.0))
				Me.Top = Me.MyParentFrm.ParentToolbarHeight() + 15
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub CheckCalculatedFetkovich(Optional bShowMsg As Boolean = False)
			Try
				Dim textBox As TextBox = New TextBox()
				textBox.Text = RSWIN_DESC.rst.FetkovichN.ToString()
				Dim obj As Object
				Dim flag As Boolean = Me.CheckValid(textBox, -1S, 0S, obj) <> 0S
				If flag AndAlso bShowMsg Then
					Dim flag2 As Boolean = True
					Dim obj2 As Object = flag2
					Dim lowerBound As Single = 0.5F
					Dim inclusive As Integer = -1
					Dim errnum As Integer = 22
					Dim useMetric As Integer = 0
					Dim canadianIsMetric As Integer = 0
					Dim bQuiet As Boolean = False
					Dim text As String = ""
					If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
						MessageBox.Show("Calculated Fetkovich N is less than 0.5. Please check Mid-perf. depth, Static b'hole pressure, Bubble point pressure, and Production test point data.")
					Else
						Dim obj3 As Object = flag2
						Dim upperBound As Single = 1F
						Dim inclusive2 As Integer = -1
						Dim errnum2 As Integer = 22
						Dim useMetric2 As Integer = 0
						Dim canadianIsMetric2 As Integer = 0
						Dim bQuiet2 As Boolean = False
						text = ""
						If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
							MessageBox.Show("Calculated Fetkovich N is greater than 1.0. Plese check Mid-perf. depth, Static b'hole pressure, Bubble point pressure, and Production test point data.")
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub TurnOffViewReportOption()
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = New RODSTAR()
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex2 As Exception
					End Try
				End If
				If Me.MyParentFrm.CheckMdiForm("Results") Then
					Me.MyParentFrm.RemoveChildForm("Results", False)
				End If
				Me.MyParentFrm.ToolbarButtonSetState2(2, False)
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub Control_SelectedIndexChanged(bActiveControl As Boolean)
			If bActiveControl Then
				Me.bValidated = False
				RSWIN_DESC.rst.gbInputDataChanged = True
				Me.TurnOffViewReportOption()
				Me.ResetClock()
			End If
			RSWIN_DESC.frmMain.ToolbarButtonSetState(16, Me.CheckRequiredTextFields())
		End Sub

		Private Sub cboTestPointType_SelectedIndexChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub _optFLPIP_0_EnabledChanged(sender As Object, e As EventArgs)
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Me._optFLPIP_0.Enabled Then
				Me._optFLPIP_0.Enabled = False
				Return
			End If
		End Sub

		Private Sub txtFLPIP_EnabledChanged(sender As Object, e As EventArgs)
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Me.txtFLPIP.Enabled Then
				Me.txtFLPIP.Enabled = False
				Return
			End If
		End Sub

		Private Sub _Label_SPMBFPD_TextChanged(sender As Object, e As EventArgs)
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Operators.CompareString(Me._Label_SPMBFPD.Text, Me.CAP_BFPD, False) = 0 Then
				Me.lbl85.Visible = True
			Else
				Me.lbl85.Visible = False
			End If
		End Sub

		Private Sub _Label_SPMBFPD_EnabledChanged(sender As Object, e As EventArgs)
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Operators.CompareString(Me._Label_SPMBFPD.Text, Me.CAP_BFPD, False) = 0 Then
				Me.lbl85.Visible = True
			Else
				Me.lbl85.Visible = False
			End If
		End Sub

		Private Sub ProdInfo_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub ProdInfo_MouseDown(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub ProdInfo_MouseEnter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub ProdInfo_MouseMove(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub ProdInfo_MouseUp(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub ProdInfo_MouseWheel(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub ProdInfo_Move(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub ProdInfo_Scroll(sender As Object, e As ScrollEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub ProdInfo_KeyPress(sender As Object, e As KeyPressEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub ProdInfo_KeyUp(sender As Object, e As KeyEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub ProdInfo_DragDrop(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub ProdInfo_DragEnter(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub ProdInfo_FormClosed(sender As Object, e As FormClosedEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub ProdInfo_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub ProdInfo_LostFocus(sender As Object, e As EventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub ProdInfo_GotFocus(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Public Sub Control__LostFocus(ByRef cntrl As Control)
			CtrlUI.Control_LostFocus(cntrl)
			Me.ResetClock()
		End Sub

		Public Sub TextBox__LostFocus(ByRef txt As TextBox, Optional ByRef lbl As Label = Nothing, Optional bRequiredColor As Boolean = True)
			CtrlUI.TextBox_LostFocus(txt, lbl, bRequiredColor)
			Me.ResetClock()
		End Sub

		Public Sub TextBox__KeyDown(ByRef txt As TextBox, ByRef lbl As Label, KeyCode As Integer, Shift As Integer)
			CtrlUI.TextBox_KeyDown(txt, lbl, KeyCode, Shift)
			Me.ResetClock()
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
					Me.MyParentFrm.ResetClock()
				End If
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

		<AccessedThroughProperty("IPRPlot")>
		Private _IPRPlot As IPRPlot

		Private myKeyValueHT As Hashtable

		Private bCancel As Boolean

		Private MyParentFrm As RODSTAR

		Private bFLMsgShown As Boolean

		Private sMidPerforation As String

		Private sPumpIntake As String

		Private m_bAlreadyAskedTargetBFPDQuestion As Boolean

		Private m_bClosing As Boolean

		Private m_bValidated As Boolean

		<AccessedThroughProperty("pnlIPR")>
		Private _pnlIPR As Panel

		<AccessedThroughProperty("chkBelowBPP")>
		Private _chkBelowBPP As CheckBox

		<AccessedThroughProperty("ulgTestPoints")>
		Private _ulgTestPoints As UltraGrid

		<AccessedThroughProperty("cmdDelTestPoint")>
		Private _cmdDelTestPoint As Button

		<AccessedThroughProperty("cmdAddTestPoint")>
		Private _cmdAddTestPoint As Button

		<AccessedThroughProperty("cboTestPointType")>
		Private _cboTestPointType As ComboBox

		<AccessedThroughProperty("cmdIPRPlot")>
		Private _cmdIPRPlot As Button

		<AccessedThroughProperty("cmdCheckIPR")>
		Private _cmdCheckIPR As Button

		<AccessedThroughProperty("chkCalculateN")>
		Private _chkCalculateN As CheckBox

		<AccessedThroughProperty("frmMaxProduction")>
		Private _frmMaxProduction As GroupBox

		<AccessedThroughProperty("_Label_Fluid")>
		Private __Label_Fluid As Label

		<AccessedThroughProperty("_Label_Water")>
		Private __Label_Water As Label

		<AccessedThroughProperty("_Label_Oil")>
		Private __Label_Oil As Label

		<AccessedThroughProperty("_lblMaxProduction_2")>
		Private __lblMaxProduction_2 As Label

		<AccessedThroughProperty("_lblMaxProduction_1")>
		Private __lblMaxProduction_1 As Label

		<AccessedThroughProperty("_lblMaxProduction_0")>
		Private __lblMaxProduction_0 As Label

		<AccessedThroughProperty("cmdUpdateProduction")>
		Private _cmdUpdateProduction As Button

		<AccessedThroughProperty("_Label_PressMeasuredAt")>
		Private __Label_PressMeasuredAt As Label

		<AccessedThroughProperty("_Label_MidPerfDepth")>
		Private __Label_MidPerfDepth As Label

		<AccessedThroughProperty("_Label_StaticBHPressure")>
		Private __Label_StaticBHPressure As Label

		<AccessedThroughProperty("_Label_BubblePoint")>
		Private __Label_BubblePoint As Label

		<AccessedThroughProperty("_Label_ProdTestPoints")>
		Private __Label_ProdTestPoints As Label

		<AccessedThroughProperty("_Label_IPRCalcMethod")>
		Private __Label_IPRCalcMethod As Label

		<AccessedThroughProperty("_Label_FetkovichN")>
		Private __Label_FetkovichN As Label

		<AccessedThroughProperty("cboIPRMethod")>
		Private _cboIPRMethod As ComboBox

		<AccessedThroughProperty("txtMidPerfDepth")>
		Private _txtMidPerfDepth As TextBox

		<AccessedThroughProperty("txtStaticBHPressure")>
		Private _txtStaticBHPressure As TextBox

		<AccessedThroughProperty("txtBubblePoint")>
		Private _txtBubblePoint As TextBox

		<AccessedThroughProperty("lblBubblePoint_Disabled")>
		Private _lblBubblePoint_Disabled As Label

		<AccessedThroughProperty("txtFetkovichN")>
		Private _txtFetkovichN As TextBox

		<AccessedThroughProperty("lblFetkovichN_Disabled")>
		Private _lblFetkovichN_Disabled As Label

		<AccessedThroughProperty("_linSeparator_2")>
		Private __linSeparator_2 As Label

		Private bAIPreferencesSet As Boolean

		<AccessedThroughProperty("txtFLPIP")>
		Private _txtFLPIP As TextBox

		<AccessedThroughProperty("_SSPanel_0")>
		Private __SSPanel_0 As Panel

		<AccessedThroughProperty("_linSeparator_0")>
		Private __linSeparator_0 As Label

		<AccessedThroughProperty("_linSeparator_1")>
		Private __linSeparator_1 As Label

		<AccessedThroughProperty("_linSeparator_3")>
		Private __linSeparator_3 As Label

		<AccessedThroughProperty("picRemoveFocus")>
		Private _picRemoveFocus As Panel

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As PanelArray

		<AccessedThroughProperty("linSeparator")>
		Private _linSeparator As LabelArray

		<AccessedThroughProperty("optFLPIP")>
		Private _optFLPIP As RadioButtonArray

		<AccessedThroughProperty("optSPMBFPD")>
		Private _optSPMBFPD As RadioButtonArray

		<AccessedThroughProperty("chkIPRData")>
		Private _chkIPRData As CheckBox

		<AccessedThroughProperty("_optFLPIP_5")>
		Private __optFLPIP_5 As RadioButton

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		<AccessedThroughProperty("_optSPMBFPD_0")>
		Private __optSPMBFPD_0 As RadioButton

		<AccessedThroughProperty("_optSPMBFPD_1")>
		Private __optSPMBFPD_1 As RadioButton

		<AccessedThroughProperty("_optSPMBFPD_2")>
		Private __optSPMBFPD_2 As RadioButton

		<AccessedThroughProperty("_optFLPIP_0")>
		Private __optFLPIP_0 As RadioButton

		<AccessedThroughProperty("_optFLPIP_1")>
		Private __optFLPIP_1 As RadioButton

		<AccessedThroughProperty("_optFLPIP_4")>
		Private __optFLPIP_4 As RadioButton

		<AccessedThroughProperty("_optFLPIP_3")>
		Private __optFLPIP_3 As RadioButton

		<AccessedThroughProperty("_optFLPIP_2")>
		Private __optFLPIP_2 As RadioButton

		<AccessedThroughProperty("txtSPMBFPD")>
		Private _txtSPMBFPD As TextBox

		<AccessedThroughProperty("_Label_3")>
		Private __Label_3 As Label

		<AccessedThroughProperty("txtTempProd")>
		Private _txtTempProd As TextBox

		<AccessedThroughProperty("txtTempPress")>
		Private _txtTempPress As TextBox

		<AccessedThroughProperty("lblSPMBFPD_Disabled")>
		Private _lblSPMBFPD_Disabled As Label

		<AccessedThroughProperty("_Label_SPMBFPD")>
		Private __Label_SPMBFPD As Label

		<AccessedThroughProperty("lbl85")>
		Private _lbl85 As Label

		Private Shared m_vb6FormDefInstance As ProdInfo

		Private Shared m_InitializingDefInstance As Boolean

		Private Const LBLFLPIP As Short = 3S

		Private Const LBLSPMBFPD As Short = 7S

		Private stargetprod As String

		Private CAP_FLUIDLEVEL As String

		Private CAP_PUMPINTAKE As String

		Private TAG_FLUIDLEVEL As String

		Private TAG_PUMPINTAKE As String

		Private CAP_BFPD As String

		Private TAG_BFPD As String

		Private CAP_SPM As String

		Private TAG_SPM As String

		Private sDeleteRow As String

		Private sDataInconsistent As String

		Private sDataDuplicate As String

		Private sFluidProduction As String

		Private sPressure As String

		Private Const PM_POSITIONCTRL As Short = 1S

		Private Const PM_MOVEPREVCELL As Short = 2S

		Private Const PM_MOVENEXTCELL As Short = 3S

		Private Const PM_EXITEDITMODE As Short = 4S

		Private Const PM_PROCESSKEY As Short = 5S

		Private Const PM_SELECTFIRSTROW As Short = 6S

		Private Const S_IPRPRESSURE As String = "IPRPressure"

		Private Const S_IPRPRODUCTION As String = "IPRProduction"

		Private Const cMAXHEIGHT_IPR As Integer = 5460

		Private Const cMAXHEIGHT_NOIPR As Integer = 2325

		Private Const cMAXWIDTH As Integer = 7800

		Private Const cMAXIPRPOINTS As Integer = 10

		Private mbFirstResize As Boolean

		Private mbFluidLevelEnteredWas As Short

		Private mdsTestPoints As DataSet

		Private bTextChanged As Boolean

		Private bLowerTargetMsgShown As Boolean

		Private bUpperTargetMsgShown As Boolean

		Private TestPointType As Integer

		Private bLoadingForm As Boolean

		Private m_bFormLoaded As Boolean

		Private m_bReloadProdInfo As Boolean

		Private m_bIPRMessageShown As Boolean

		Private m_bFormActivated As Boolean

		Private $STATIC$chkBelowBPP_Click_1$202122$busy As Boolean

		Private $STATIC$optFLPIP_Click_1$2031882$busy As Boolean

		Private $STATIC$optSPMBFPD_Click_1$2031882$busy As Boolean

		Private Enum EIPRColumns
			eicIPRAllColumns
			eicIPRType
			eicIPRPressure
			eicIPRProduction
		End Enum
	End Class
End Namespace
