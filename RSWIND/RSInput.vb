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
Imports ThetaStdInfo

Namespace RSWINV3
	Friend Partial Class RSInput
		Inherits Form

		Public Property bLengthError As Boolean
			Get
				Return Me.m_bLengthError
			End Get
			Set(value As Boolean)
				Me.m_bLengthError = value
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

		Public Property bValidated As Boolean
			Get
				Return Me.m_bValidated
			End Get
			Set(value As Boolean)
				Me.m_bValidated = value
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

		Public Property bLoadingCombo As Boolean
			Get
				Return Me.m_bLoadingCombo
			End Get
			Set(value As Boolean)
				Me.m_bLoadingCombo = value
			End Set
		End Property

		Public Property bRunSet As Boolean
			Get
				Return Me.m_bRunSet
			End Get
			Set(value As Boolean)
				Me.m_bRunSet = value
			End Set
		End Property

		Public Property bRodDesignTypeClicked As Boolean
			Get
				Return Me.m_bRodDesignTypeClicked
			End Get
			Set(value As Boolean)
				Me.m_bRodDesignTypeClicked = value
			End Set
		End Property

		Public Property bRecommendedFricCoefShown As Boolean
			Get
				Return Me.m_bRecommendedFricCoefShown
			End Get
			Set(value As Boolean)
				Me.m_bRecommendedFricCoefShown = value
			End Set
		End Property

		Public Property bRecommendedFricCoefYesNoShown As Boolean
			Get
				Return Me.m_bRecommendedFricCoefYesNoShown
			End Get
			Set(value As Boolean)
				Me.m_bRecommendedFricCoefYesNoShown = value
			End Set
		End Property

		Public Property bLeaveLoaded As Boolean
			Get
				Return Me.m_bLeaveLoaded
			End Get
			Set(value As Boolean)
				Me.m_bLeaveLoaded = value
			End Set
		End Property

		Public Overridable Property lblRodGuides As Label
			Get
				Return Me._lblRodGuides
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGuides = value
			End Set
		End Property

		Friend Overridable Property cboRSRodGuides As ComboBox
			Get
				Return Me._cboRSRodGuides
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRSRodGuides_Leave
				Dim value3 As EventHandler = AddressOf Me.cboRSRodGuides_SelectedIndexChanged
				Dim value4 As EventHandler = AddressOf Me.cboRSRodGuides_SelectionChangeCommitted
				Dim value5 As CancelEventHandler = AddressOf Me.cboRSRodGuides_Validating
				Dim value6 As EventHandler = AddressOf Me.cboRSRodGuides_Enter
				If Me._cboRSRodGuides IsNot Nothing Then
					RemoveHandler Me._cboRSRodGuides.Leave, value2
					RemoveHandler Me._cboRSRodGuides.SelectedIndexChanged, value3
					RemoveHandler Me._cboRSRodGuides.SelectionChangeCommitted, value4
					RemoveHandler Me._cboRSRodGuides.Validating, value5
					RemoveHandler Me._cboRSRodGuides.Enter, value6
				End If
				Me._cboRSRodGuides = value
				If Me._cboRSRodGuides IsNot Nothing Then
					AddHandler Me._cboRSRodGuides.Leave, value2
					AddHandler Me._cboRSRodGuides.SelectedIndexChanged, value3
					AddHandler Me._cboRSRodGuides.SelectionChangeCommitted, value4
					AddHandler Me._cboRSRodGuides.Validating, value5
					AddHandler Me._cboRSRodGuides.Enter, value6
				End If
			End Set
		End Property

		Public Overridable Property lblRSSRSize As Label
			Get
				Return Me._lblRSSRSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSSRSize = value
			End Set
		End Property

		Friend Overridable Property cboRSSRSize As ComboBox
			Get
				Return Me._cboRSSRSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRSSRSize_Leave
				Dim value3 As EventHandler = AddressOf Me.cboRSSRSize_EnabledChanged
				Dim value4 As EventHandler = AddressOf Me.cboRSSRSize_SelectedIndexChanged
				If Me._cboRSSRSize IsNot Nothing Then
					RemoveHandler Me._cboRSSRSize.Leave, value2
					RemoveHandler Me._cboRSSRSize.EnabledChanged, value3
					RemoveHandler Me._cboRSSRSize.SelectedIndexChanged, value4
				End If
				Me._cboRSSRSize = value
				If Me._cboRSSRSize IsNot Nothing Then
					AddHandler Me._cboRSSRSize.Leave, value2
					AddHandler Me._cboRSSRSize.EnabledChanged, value3
					AddHandler Me._cboRSSRSize.SelectedIndexChanged, value4
				End If
			End Set
		End Property

		Friend Overridable Property lblRSSRSize_Disabled As Label
			Get
				Return Me._lblRSSRSize_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSSRSize_Disabled = value
			End Set
		End Property

		Public Property bCheckRodsInTubingMsgShown As Boolean
			Get
				Return Me.m_bCheckRodsInTubingMsgShown
			End Get
			Set(value As Boolean)
				Me.m_bCheckRodsInTubingMsgShown = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Resize, AddressOf Me.RSInput_Resize
			AddHandler MyBase.Validating, AddressOf Me.RSInput_Validating
			AddHandler MyBase.Enter, AddressOf Me.RSInput_Enter
			AddHandler MyBase.Leave, AddressOf Me.RSInput_Leave
			AddHandler MyBase.Load, AddressOf Me.RSInput_Load
			AddHandler MyBase.Activated, AddressOf Me.RSInput_Activated
			AddHandler MyBase.Closing, AddressOf Me.RSInput_Closing
			AddHandler MyBase.Closed, AddressOf Me.RSInput_Closed
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.RSInput_MouseDoubleClick
			AddHandler MyBase.MouseDown, AddressOf Me.RSInput_MouseDown
			AddHandler MyBase.MouseEnter, AddressOf Me.RSInput_MouseEnter
			AddHandler MyBase.MouseMove, AddressOf Me.RSInput_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.RSInput_MouseUp
			AddHandler MyBase.MouseWheel, AddressOf Me.RSInput_MouseWheel
			AddHandler MyBase.Move, AddressOf Me.RSInput_Move
			AddHandler MyBase.Scroll, AddressOf Me.RSInput_Scroll
			AddHandler MyBase.KeyPress, AddressOf Me.RSInput_KeyPress
			AddHandler MyBase.KeyUp, AddressOf Me.RSInput_KeyUp
			AddHandler MyBase.DragDrop, AddressOf Me.RSInput_DragDrop
			AddHandler MyBase.DragEnter, AddressOf Me.RSInput_DragEnter
			AddHandler MyBase.FormClosed, AddressOf Me.RSInput_FormClosed
			AddHandler MyBase.FormClosing, AddressOf Me.RSInput_FormClosing
			AddHandler MyBase.LostFocus, AddressOf Me.RSInput_LostFocus
			AddHandler MyBase.GotFocus, AddressOf Me.RSInput_GotFocus
			Me.sNull = ""
			Me.iFlexBarC = 10
			Me.sRodStringLength = Util.AssignValueToConstant("RSInput", "sRodStringLength", "Rod String Length: ")
			Me.sPumpDepth = Util.AssignValueToConstant("RSInput", "sPumpDepth", "Pump Depth")
			Me.sARSRemoveSelected = Util.AssignValueToConstant("RSInput", "sARSRemoveSelected", "Are you sure you want to remove the selected rod section?")
			Me.sDeleteRow = Util.AssignValueToConstant("RSInput", "sDeleteRow", "Delete row(s)")
			Me.sARSRemoveLastSection = Util.AssignValueToConstant("RSInput", "sARSRemoveLastSection", "Are you sure you want to remove the last rod section?")
			Me.sARSRemoveLastSections = Util.AssignValueToConstant("RSInput", "sARSRemoveLastSections", "Are you sure you want to remove the last rod sections?")
			Me.sRecommendedFricCoef = Util.AssignValueToConstant("RSInput", "sRecommendedFricCoef", "Minimum recommended drag Friction Coefficient is 0.2")
			Me.sRecommendedFricCoefYesNo = Util.AssignValueToConstant("RSInput", "sRecommendedFricCoefYesNo", "Drag Friction Coefficient value is greater than 0.2. Change value now?")
			Me.sSinkerRodDiameterWarningMsg = Util.AssignValueToConstant("RSInput", "sSinkerRodDiameterWarningMsg", "Sinker bar/rod diameter should normally be greater than the maximum rod diameter selected for rods above.")
			Me.sTotalDepth = Util.AssignValueToConstant("RSInput", "sTotalDepth", "Total of rod taper lengths cannot be greater than current pump depth. Please enter valid value(s).")
			Me.sTotalDepth_ft = "Rod string length must be within 50 feet of pump depth. "
			Me.sTotalDepth_m = "Rod string length must be within 15.24 meters of pump depth. "
			Me.sPleaseCheckInput = "Please check input. "
			Me.sDataEntryError = Util.AssignValueToConstant("RSInput", "sDataEntryError", "Data entry error")
			Me.SEnterTaperLength = Util.AssignValueToConstant("RSInput", "SEnterTaperLength", "Please enter value for rod taper length")
			Me.SEnterSBLength = Util.AssignValueToConstant("RSInput", "SEnterSBLength", "Please enter Sinker bar/Sinker Rod length. ")
			Me.sSmallLengthV = Util.AssignValueToConstant("RSInput", "sSmallLengthV", "Smaller rod taper lengths may cause inaccuracies in calcuations.")
			Me.sSmallLengthD = Util.AssignValueToConstant("RSInput", "sSmallLengthD", "Smaller rod taper lengths may cause inaccuracies in calcuations and may increase runtime.")
			Me.sCannotMoveDown = Util.AssignValueToConstant("RSInput", "sCannotMoveDown", "Cannot move the last taper downward!")
			Me.sCannotMoveUp = Util.AssignValueToConstant("RSInput", "sCannotMoveUp", "Cannot move the first taper upward!")
			Me.sGradeBeforeSize = Util.AssignValueToConstant("RSInput", "sGradeBeforeSize", "Please select Rod Grade before Rod Size.")
			Me.sSelectTaperToRemove = Util.AssignValueToConstant("RSInput", "sSelectTaperToRemove", "Please select taper to remove!")
			Me.sRodLength = Util.AssignValueToConstant("RSInput", "sRodLength", "Length")
			Me.sRodGrade = Util.AssignValueToConstant("RSInput", "sRodGrade", "Rod Grade")
			Me.sRodSize = Util.AssignValueToConstant("RSInput", "sRodSize", "Rod Size")
			Me.sRodType = Util.AssignValueToConstant("RSInput", "sRodType", "Rod Type")
			Me.sFrictionCoefficient = Util.AssignValueToConstant("RSInput", "sFrictionCoefficient", "Fric. Coef.")
			Me.sActualRodDiameter = Util.AssignValueToConstant("RSInput", "sActualRodDiameter", "Actual diam.")
			Me.sRodGuide = Util.AssignValueToConstant("RSInput", "sRodGuide", "Rod Guide")
			Me.sNumGuides = Util.AssignValueToConstant("RSInput", "sNumGuides", "# Guides/Rod")
			Me.sStressCalc = Util.AssignValueToConstant("RSInput", "sStressCalc", "   Stress Calc.")
			Me.sMethod = Util.AssignValueToConstant("RSInput", "sMethod", "Method")
			Me.sMinLessThanMan = Util.AssignValueToConstant("RSInput", "sMinLessThanMan", "Minimum rod diameter should be less than maximum rod diameter.")
			Me.iSteelOrder = 45
			Me.iSinkberbarOrder = 127
			Me.iProrodOrder = 215
			Me.iCorodOrder = 321
			Me.iFiberglassOrder = 415
			Me.iRibbonrodOrder = 510
			Me.bUseStatus = True
			Me.m_bLengthError = False
			Me.m_bClosing = False
			Me.m_bValidated = False
			Me.m_bFormLoaded = False
			Me.m_bLoadingCombo = False
			Me.bInsideUpdateRS = False
			Me.m_bRunSet = False
			Me.bEnterEditmode = False
			Me.sRecommendedFricCoefYesNo_LessThan = "Drag Friction Coefficient value is less than 0.2. Change value now?"
			Me.sRecommendedFricCoefYesNo_GreaterThan = "Drag Friction Coefficient value is greater than 0.2. Change value now?"
			Me.PreviousColumn = ""
			Me.bF2Hit = False
			Me.btxtLengthHasFocus = False
			Me.myRodTypeAL = New ArrayList()
			Me.myRodSizeAL = New ArrayList()
			Me.RSGrade_AL = New ArrayList()
			Me.RSSBGrade_AL = New ArrayList()
			Me.RSFGGrade_AL = New ArrayList()
			Me.iNumDiams = 0
			Me.tmp_PumpDepth = 0F
			Me.m_bRodDesignTypeClicked = False
			Me.m_bRecommendedFricCoefShown = False
			Me.m_bRecommendedFricCoefYesNoShown = False
			Me.m_bLeaveLoaded = False
			Me.myKeyValueHT = New Hashtable()
			Me.m_bCheckRodsInTubingMsgShown = False
			Me.myRodTypeGradeAL = New ArrayList()
			Me.myRSGradeAL = New ArrayList()
			Me.myRodGuideAL = New ArrayList()
			Me.myRSMaxDiamAL = New ArrayList()
			Me.myRSMinDiamAL = New ArrayList()
			Me.myRSSBDiamAL = New ArrayList()
			Me.myRSSRDiamAL = New ArrayList()
			Me.Chr9 = "    "
			Me.m_mbMaxMinNotYetSet = False
			Me.bDisplayDeleteMessage = True
			If RSInput.m_vb6FormDefInstance Is Nothing Then
				If RSInput.m_InitializingDefInstance Then
					RSInput.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							RSInput.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
			Me.Text = "Rod String Information"
		End Sub

		Public Overridable Property cboRSGrade As ComboBox
			Get
				Return Me._cboRSGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRSGrade_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.cboRSGrade_Click
				Dim value4 As EventHandler = AddressOf Me.cboRSGrade_SelectedIndexChanged
				If Me._cboRSGrade IsNot Nothing Then
					RemoveHandler Me._cboRSGrade.EnabledChanged, value2
					RemoveHandler Me._cboRSGrade.Click, value3
					RemoveHandler Me._cboRSGrade.SelectedIndexChanged, value4
				End If
				Me._cboRSGrade = value
				If Me._cboRSGrade IsNot Nothing Then
					AddHandler Me._cboRSGrade.EnabledChanged, value2
					AddHandler Me._cboRSGrade.Click, value3
					AddHandler Me._cboRSGrade.SelectedIndexChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property chkRSFGIncludeSteel As CheckBox
			Get
				Return Me._chkRSFGIncludeSteel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkRSFGIncludeSteel_CheckedChanged
				If Me._chkRSFGIncludeSteel IsNot Nothing Then
					RemoveHandler Me._chkRSFGIncludeSteel.CheckedChanged, value2
				End If
				Me._chkRSFGIncludeSteel = value
				If Me._chkRSFGIncludeSteel IsNot Nothing Then
					AddHandler Me._chkRSFGIncludeSteel.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property fraSteelDesign As GroupBox
			Get
				Return Me._fraSteelDesign
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._fraSteelDesign = value
			End Set
		End Property

		Public Overridable Property ctrSteelDesign As Panel
			Get
				Return Me._ctrSteelDesign
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._ctrSteelDesign = value
			End Set
		End Property

		Public Overridable Property cboRSFGGrade As ComboBox
			Get
				Return Me._cboRSFGGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRSFGGrade_Click
				Dim value3 As EventHandler = AddressOf Me.cboRSFGGrade_SelectedIndexChanged
				If Me._cboRSFGGrade IsNot Nothing Then
					RemoveHandler Me._cboRSFGGrade.Click, value2
					RemoveHandler Me._cboRSFGGrade.SelectedIndexChanged, value3
				End If
				Me._cboRSFGGrade = value
				If Me._cboRSFGGrade IsNot Nothing Then
					AddHandler Me._cboRSFGGrade.Click, value2
					AddHandler Me._cboRSFGGrade.SelectedIndexChanged, value3
				End If
			End Set
		End Property

		Public Overridable Property ctrFGDesign As Panel
			Get
				Return Me._ctrFGDesign
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._ctrFGDesign = value
			End Set
		End Property

		Public Overridable Property ulgTapers As UltraGrid
			Get
				Return Me._ulgTapers
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As BeforeSortChangeEventHandler = AddressOf Me.ulgTapers_BeforeSortChange
				Dim value3 As EventHandler = AddressOf Me.ulgTapers_AfterExitEditMode
				Dim value4 As EventHandler = AddressOf Me.ulgTapers_Leave
				Dim value5 As EventHandler = AddressOf Me.ulgTapers_AfterEnterEditMode
				Dim value6 As CancelableCellEventHandler = AddressOf Me.ulgTapers_BeforeCellActivate
				Dim value7 As RowEventHandler = AddressOf Me.ulgTapers_AfterRowResize
				Dim value8 As RowScrollRegionEventHandler = AddressOf Me.ulgTapers_AfterRowRegionSize
				Dim value9 As RowScrollRegionEventHandler = AddressOf Me.ulgTapers_AfterRowRegionScroll
				Dim value10 As ColScrollRegionEventHandler = AddressOf Me.ulgTapers_AfterColRegionSize
				Dim value11 As ColScrollRegionEventHandler = AddressOf Me.ulgTapers_AfterColRegionScroll
				Dim value12 As AfterColPosChangedEventHandler = AddressOf Me.ulgTapers_AfterColPosChanged
				Dim value13 As MouseEventHandler = AddressOf Me.ulgTapers_MouseDownEvent
				Dim value14 As InitializeRowEventHandler = AddressOf Me.ulgTapers_InitializeRow
				Dim value15 As EventHandler = AddressOf Me.ulgTapers_AfterRowActivate_2
				Dim value16 As EventHandler = AddressOf Me.ulgTapers_AfterCellActivate
				Dim value17 As InitializeLayoutEventHandler = AddressOf Me.ulgTapers_InitializeLayout
				Dim value18 As KeyEventHandler = AddressOf Me.ulgTapers_KeyDown
				Dim value19 As CancelableCellEventHandler = AddressOf Me.ulgTapers_BeforeCellListDropDown
				Dim value20 As BeforeRowRegionScrollEventHandler = AddressOf Me.ulgTapers_BeforeRowRegionScroll
				Dim value21 As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventHandler = AddressOf Me.ulgTapers_BeforeExitEditMode
				Dim value22 As CancelEventHandler = AddressOf Me.ulgTapers_BeforeEnterEditMode
				Dim value23 As BeforeColRegionScrollEventHandler = AddressOf Me.ulgTapers_BeforeColRegionScroll
				Dim value24 As CancelEventHandler = AddressOf Me.ulgTapers_BeforeCellDeactivate
				Dim value25 As EventHandler = AddressOf Me.ulgTapers_AfterRowsDeleted
				Dim value26 As BeforeRowsDeletedEventHandler = AddressOf Me.ulgTapers_BeforeRowsDeleted
				Dim value27 As RowEventHandler = AddressOf Me.ulgTapers_AfterRowInsert
				Dim value28 As BeforeCellUpdateEventHandler = AddressOf Me.ulgTapers_BeforeCellUpdate
				Dim value29 As RowEventHandler = AddressOf Me.ulgTapers_AfterRowUpdate
				Dim value30 As EventHandler = AddressOf Me.ulgTapers_AfterRowActivate
				Dim value31 As CellEventHandler = AddressOf Me.ulgTapers_CellChange
				Dim value32 As CellEventHandler = AddressOf Me.ulgTapers_AfterCellUpdate
				Dim value33 As EventHandler = AddressOf Me.ulgTapers_MouseHover
				If Me._ulgTapers IsNot Nothing Then
					RemoveHandler Me._ulgTapers.BeforeSortChange, value2
					RemoveHandler Me._ulgTapers.AfterExitEditMode, value3
					RemoveHandler Me._ulgTapers.Leave, value4
					RemoveHandler Me._ulgTapers.AfterEnterEditMode, value5
					RemoveHandler Me._ulgTapers.BeforeCellActivate, value6
					RemoveHandler Me._ulgTapers.AfterRowResize, value7
					RemoveHandler Me._ulgTapers.AfterRowRegionSize, value8
					RemoveHandler Me._ulgTapers.AfterRowRegionScroll, value9
					RemoveHandler Me._ulgTapers.AfterColRegionSize, value10
					RemoveHandler Me._ulgTapers.AfterColRegionScroll, value11
					RemoveHandler Me._ulgTapers.AfterColPosChanged, value12
					RemoveHandler Me._ulgTapers.MouseDown, value13
					RemoveHandler Me._ulgTapers.InitializeRow, value14
					RemoveHandler Me._ulgTapers.AfterRowActivate, value15
					RemoveHandler Me._ulgTapers.AfterCellActivate, value16
					RemoveHandler Me._ulgTapers.InitializeLayout, value17
					RemoveHandler Me._ulgTapers.KeyDown, value18
					RemoveHandler Me._ulgTapers.BeforeCellListDropDown, value19
					RemoveHandler Me._ulgTapers.BeforeRowRegionScroll, value20
					RemoveHandler Me._ulgTapers.BeforeExitEditMode, value21
					RemoveHandler Me._ulgTapers.BeforeEnterEditMode, value22
					RemoveHandler Me._ulgTapers.BeforeColRegionScroll, value23
					RemoveHandler Me._ulgTapers.BeforeCellDeactivate, value24
					RemoveHandler Me._ulgTapers.AfterRowsDeleted, value25
					RemoveHandler Me._ulgTapers.BeforeRowsDeleted, value26
					RemoveHandler Me._ulgTapers.AfterRowInsert, value27
					RemoveHandler Me._ulgTapers.BeforeCellUpdate, value28
					RemoveHandler Me._ulgTapers.AfterRowUpdate, value29
					RemoveHandler Me._ulgTapers.AfterRowActivate, value30
					RemoveHandler Me._ulgTapers.CellChange, value31
					RemoveHandler Me._ulgTapers.AfterCellUpdate, value32
					RemoveHandler Me._ulgTapers.MouseHover, value33
				End If
				Me._ulgTapers = value
				If Me._ulgTapers IsNot Nothing Then
					AddHandler Me._ulgTapers.BeforeSortChange, value2
					AddHandler Me._ulgTapers.AfterExitEditMode, value3
					AddHandler Me._ulgTapers.Leave, value4
					AddHandler Me._ulgTapers.AfterEnterEditMode, value5
					AddHandler Me._ulgTapers.BeforeCellActivate, value6
					AddHandler Me._ulgTapers.AfterRowResize, value7
					AddHandler Me._ulgTapers.AfterRowRegionSize, value8
					AddHandler Me._ulgTapers.AfterRowRegionScroll, value9
					AddHandler Me._ulgTapers.AfterColRegionSize, value10
					AddHandler Me._ulgTapers.AfterColRegionScroll, value11
					AddHandler Me._ulgTapers.AfterColPosChanged, value12
					AddHandler Me._ulgTapers.MouseDown, value13
					AddHandler Me._ulgTapers.InitializeRow, value14
					AddHandler Me._ulgTapers.AfterRowActivate, value15
					AddHandler Me._ulgTapers.AfterCellActivate, value16
					AddHandler Me._ulgTapers.InitializeLayout, value17
					AddHandler Me._ulgTapers.KeyDown, value18
					AddHandler Me._ulgTapers.BeforeCellListDropDown, value19
					AddHandler Me._ulgTapers.BeforeRowRegionScroll, value20
					AddHandler Me._ulgTapers.BeforeExitEditMode, value21
					AddHandler Me._ulgTapers.BeforeEnterEditMode, value22
					AddHandler Me._ulgTapers.BeforeColRegionScroll, value23
					AddHandler Me._ulgTapers.BeforeCellDeactivate, value24
					AddHandler Me._ulgTapers.AfterRowsDeleted, value25
					AddHandler Me._ulgTapers.BeforeRowsDeleted, value26
					AddHandler Me._ulgTapers.AfterRowInsert, value27
					AddHandler Me._ulgTapers.BeforeCellUpdate, value28
					AddHandler Me._ulgTapers.AfterRowUpdate, value29
					AddHandler Me._ulgTapers.AfterRowActivate, value30
					AddHandler Me._ulgTapers.CellChange, value31
					AddHandler Me._ulgTapers.AfterCellUpdate, value32
					AddHandler Me._ulgTapers.MouseHover, value33
				End If
			End Set
		End Property

		Public Overridable Property ctrRodString As Panel
			Get
				Return Me._ctrRodString
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._ctrRodString = value
			End Set
		End Property

		Public Overridable Property optSinkerRods As RadioButton
			Get
				Return Me._optSinkerRods
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optSinkerRods_CheckedChanged
				If Me._optSinkerRods IsNot Nothing Then
					RemoveHandler Me._optSinkerRods.CheckedChanged, value2
				End If
				Me._optSinkerRods = value
				If Me._optSinkerRods IsNot Nothing Then
					AddHandler Me._optSinkerRods.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property optSinkerBars As RadioButton
			Get
				Return Me._optSinkerBars
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optSinkerBars_CheckedChanged
				If Me._optSinkerBars IsNot Nothing Then
					RemoveHandler Me._optSinkerBars.CheckedChanged, value2
				End If
				Me._optSinkerBars = value
				If Me._optSinkerBars IsNot Nothing Then
					AddHandler Me._optSinkerBars.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtRSSBLength As TextBox
			Get
				Return Me._txtRSSBLength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtRSSBLength_Enter
				Dim value3 As EventHandler = AddressOf Me.txtRSSBLength_EnabledChanged
				Dim value4 As KeyEventHandler = AddressOf Me.txtRSSBLength_KeyDown
				Dim value5 As EventHandler = AddressOf Me.txtRSSBLength_Leave
				Dim value6 As EventHandler = AddressOf Me.txtRSSBLength_TextChanged
				If Me._txtRSSBLength IsNot Nothing Then
					RemoveHandler Me._txtRSSBLength.Enter, value2
					RemoveHandler Me._txtRSSBLength.EnabledChanged, value3
					RemoveHandler Me._txtRSSBLength.KeyDown, value4
					RemoveHandler Me._txtRSSBLength.Leave, value5
					RemoveHandler Me._txtRSSBLength.TextChanged, value6
				End If
				Me._txtRSSBLength = value
				If Me._txtRSSBLength IsNot Nothing Then
					AddHandler Me._txtRSSBLength.Enter, value2
					AddHandler Me._txtRSSBLength.EnabledChanged, value3
					AddHandler Me._txtRSSBLength.KeyDown, value4
					AddHandler Me._txtRSSBLength.Leave, value5
					AddHandler Me._txtRSSBLength.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtRSSBDiameter As TextBox
			Get
				Return Me._txtRSSBDiameter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtRSSBDiameter_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.txtRSSBDiameter_Leave
				Dim value4 As EventHandler = AddressOf Me.txtRSSBDiameter_TextChanged
				If Me._txtRSSBDiameter IsNot Nothing Then
					RemoveHandler Me._txtRSSBDiameter.EnabledChanged, value2
					RemoveHandler Me._txtRSSBDiameter.Leave, value3
					RemoveHandler Me._txtRSSBDiameter.TextChanged, value4
				End If
				Me._txtRSSBDiameter = value
				If Me._txtRSSBDiameter IsNot Nothing Then
					AddHandler Me._txtRSSBDiameter.EnabledChanged, value2
					AddHandler Me._txtRSSBDiameter.Leave, value3
					AddHandler Me._txtRSSBDiameter.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property cboRSSBGrade As ComboBox
			Get
				Return Me._cboRSSBGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRSSBGrade_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.cboRSSBGrade_Click
				Dim value4 As EventHandler = AddressOf Me.cboRSSBGrade_SelectedIndexChanged
				If Me._cboRSSBGrade IsNot Nothing Then
					RemoveHandler Me._cboRSSBGrade.EnabledChanged, value2
					RemoveHandler Me._cboRSSBGrade.Click, value3
					RemoveHandler Me._cboRSSBGrade.SelectedIndexChanged, value4
				End If
				Me._cboRSSBGrade = value
				If Me._cboRSSBGrade IsNot Nothing Then
					AddHandler Me._cboRSSBGrade.EnabledChanged, value2
					AddHandler Me._cboRSSBGrade.Click, value3
					AddHandler Me._cboRSSBGrade.SelectedIndexChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property chkRSIncludeSB As CheckBox
			Get
				Return Me._chkRSIncludeSB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkRSIncludeSB_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.chkRSIncludeSB_CheckedChanged
				If Me._chkRSIncludeSB IsNot Nothing Then
					RemoveHandler Me._chkRSIncludeSB.EnabledChanged, value2
					RemoveHandler Me._chkRSIncludeSB.CheckedChanged, value3
				End If
				Me._chkRSIncludeSB = value
				If Me._chkRSIncludeSB IsNot Nothing Then
					AddHandler Me._chkRSIncludeSB.EnabledChanged, value2
					AddHandler Me._chkRSIncludeSB.CheckedChanged, value3
				End If
			End Set
		End Property

		Public Overridable Property fraSinkerBars As GroupBox
			Get
				Return Me._fraSinkerBars
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._fraSinkerBars = value
			End Set
		End Property

		Public Overridable Property ctrSinkerBars As Panel
			Get
				Return Me._ctrSinkerBars
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._ctrSinkerBars = value
			End Set
		End Property

		Public Overridable Property tbsRodDesignType As TabControl
			Get
				Return Me._tbsRodDesignType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				Dim value2 As EventHandler = AddressOf Me.tbsRodDesignType_Leave
				Dim value3 As EventHandler = AddressOf Me.tbsRodDesignType_SelectedIndexChanged
				Dim value4 As EventHandler = AddressOf Me.tbsRodDesignType_Click
				If Me._tbsRodDesignType IsNot Nothing Then
					RemoveHandler Me._tbsRodDesignType.Leave, value2
					RemoveHandler Me._tbsRodDesignType.SelectedIndexChanged, value3
					RemoveHandler Me._tbsRodDesignType.Click, value4
				End If
				Me._tbsRodDesignType = value
				If Me._tbsRodDesignType IsNot Nothing Then
					AddHandler Me._tbsRodDesignType.Leave, value2
					AddHandler Me._tbsRodDesignType.SelectedIndexChanged, value3
					AddHandler Me._tbsRodDesignType.Click, value4
				End If
			End Set
		End Property

		Public Overridable Property _Line_0 As Label
			Get
				Return Me.__Line_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Line_0 = value
			End Set
		End Property

		Public Overridable Property picRemoveFocus As Panel
			Get
				Return Me._picRemoveFocus
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As PaintEventHandler = AddressOf Me.picRemoveFocus_Paint
				If Me._picRemoveFocus IsNot Nothing Then
					RemoveHandler Me._picRemoveFocus.Paint, value2
				End If
				Me._picRemoveFocus = value
				If Me._picRemoveFocus IsNot Nothing Then
					AddHandler Me._picRemoveFocus.Paint, value2
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

		Public Overridable Property Line As LabelArray
			Get
				Return Me._Line
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._Line = value
			End Set
		End Property

		Friend Overridable Property imlRodDesignType As ImageList
			Get
				Return Me._imlRodDesignType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._imlRodDesignType = value
			End Set
		End Property

		Friend Overridable Property XSR As TabPage
			Get
				Return Me._XSR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._XSR = value
			End Set
		End Property

		Friend Overridable Property XFD As TabPage
			Get
				Return Me._XFD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._XFD = value
			End Set
		End Property

		Friend Overridable Property USR As TabPage
			Get
				Return Me._USR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._USR = value
			End Set
		End Property

		Public Overridable Property _Label_Length As Label
			Get
				Return Me.__Label_Length
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_Length = value
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

		Friend Overridable Property txtTempLength As TextBox
			Get
				Return Me._txtTempLength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTempLength = value
			End Set
		End Property

		Friend Overridable Property txtTempDiam As TextBox
			Get
				Return Me._txtTempDiam
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTempDiam = value
			End Set
		End Property

		Friend Overridable Property cboRodType As ComboBox
			Get
				Return Me._cboRodType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._cboRodType = value
			End Set
		End Property

		Public Overridable Property btnNumberOfRods As Button
			Get
				Return Me._btnNumberOfRods
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnNumberOfRods_Click
				If Me._btnNumberOfRods IsNot Nothing Then
					RemoveHandler Me._btnNumberOfRods.Click, value2
				End If
				Me._btnNumberOfRods = value
				If Me._btnNumberOfRods IsNot Nothing Then
					AddHandler Me._btnNumberOfRods.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdAddSection As Button
			Get
				Return Me._cmdAddSection
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdAddSection_Click
				If Me._cmdAddSection IsNot Nothing Then
					RemoveHandler Me._cmdAddSection.Click, value2
				End If
				Me._cmdAddSection = value
				If Me._cmdAddSection IsNot Nothing Then
					AddHandler Me._cmdAddSection.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdDelSection As Button
			Get
				Return Me._cmdDelSection
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdDelSection_Click
				If Me._cmdDelSection IsNot Nothing Then
					RemoveHandler Me._cmdDelSection.Click, value2
				End If
				Me._cmdDelSection = value
				If Me._cmdDelSection IsNot Nothing Then
					AddHandler Me._cmdDelSection.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdMoveSectionUp As Button
			Get
				Return Me._cmdMoveSectionUp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdMoveSectionUp_Click
				If Me._cmdMoveSectionUp IsNot Nothing Then
					RemoveHandler Me._cmdMoveSectionUp.Click, value2
				End If
				Me._cmdMoveSectionUp = value
				If Me._cmdMoveSectionUp IsNot Nothing Then
					AddHandler Me._cmdMoveSectionUp.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdMoveSectionDown As Button
			Get
				Return Me._cmdMoveSectionDown
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdMoveSectionDown_Click
				If Me._cmdMoveSectionDown IsNot Nothing Then
					RemoveHandler Me._cmdMoveSectionDown.Click, value2
				End If
				Me._cmdMoveSectionDown = value
				If Me._cmdMoveSectionDown IsNot Nothing Then
					AddHandler Me._cmdMoveSectionDown.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _Line_1 As Label
			Get
				Return Me.__Line_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Line_1 = value
			End Set
		End Property

		Friend Overridable Property lstNumOfRods As ListBox
			Get
				Return Me._lstNumOfRods
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lstNumOfRods_SelectedIndexChanged
				If Me._lstNumOfRods IsNot Nothing Then
					RemoveHandler Me._lstNumOfRods.SelectedIndexChanged, value2
				End If
				Me._lstNumOfRods = value
				If Me._lstNumOfRods IsNot Nothing Then
					AddHandler Me._lstNumOfRods.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblTemp As Label
			Get
				Return Me._lblTemp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTemp = value
			End Set
		End Property

		Friend Overridable Property cboRodGrade As ComboBox
			Get
				Return Me._cboRodGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRodGrade_Enter
				Dim value3 As EventHandler = AddressOf Me.cboRodGrade_SelectionChangeCommitted
				Dim value4 As CancelEventHandler = AddressOf Me.cboRodGrade_Validating
				Dim value5 As EventHandler = AddressOf Me.cboRodGrade_SelectedIndexChanged
				Dim value6 As EventHandler = AddressOf Me.cboRodGrade_MouseHover
				If Me._cboRodGrade IsNot Nothing Then
					RemoveHandler Me._cboRodGrade.Enter, value2
					RemoveHandler Me._cboRodGrade.SelectionChangeCommitted, value3
					RemoveHandler Me._cboRodGrade.Validating, value4
					RemoveHandler Me._cboRodGrade.SelectedIndexChanged, value5
					RemoveHandler Me._cboRodGrade.MouseHover, value6
				End If
				Me._cboRodGrade = value
				If Me._cboRodGrade IsNot Nothing Then
					AddHandler Me._cboRodGrade.Enter, value2
					AddHandler Me._cboRodGrade.SelectionChangeCommitted, value3
					AddHandler Me._cboRodGrade.Validating, value4
					AddHandler Me._cboRodGrade.SelectedIndexChanged, value5
					AddHandler Me._cboRodGrade.MouseHover, value6
				End If
			End Set
		End Property

		Public Overridable Property ctrOtherInfo As Panel
			Get
				Return Me._ctrOtherInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._ctrOtherInfo = value
			End Set
		End Property

		Public Overridable Property fraOtherInfo As GroupBox
			Get
				Return Me._fraOtherInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._fraOtherInfo = value
			End Set
		End Property

		Public Overridable Property txtServiceFactor As TextBox
			Get
				Return Me._txtServiceFactor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtServiceFactor_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtServiceFactor_Leave1
				Dim value4 As EventHandler = AddressOf Me.txtServiceFactor_Enter1
				Dim value5 As EventHandler = AddressOf Me.txtServiceFactor_Leave
				Dim value6 As EventHandler = AddressOf Me.txtServiceFactor_Enter
				If Me._txtServiceFactor IsNot Nothing Then
					RemoveHandler Me._txtServiceFactor.TextChanged, value2
					RemoveHandler Me._txtServiceFactor.Leave, value3
					RemoveHandler Me._txtServiceFactor.Enter, value4
					RemoveHandler Me._txtServiceFactor.Leave, value5
					RemoveHandler Me._txtServiceFactor.Enter, value6
				End If
				Me._txtServiceFactor = value
				If Me._txtServiceFactor IsNot Nothing Then
					AddHandler Me._txtServiceFactor.TextChanged, value2
					AddHandler Me._txtServiceFactor.Leave, value3
					AddHandler Me._txtServiceFactor.Enter, value4
					AddHandler Me._txtServiceFactor.Leave, value5
					AddHandler Me._txtServiceFactor.Enter, value6
				End If
			End Set
		End Property

		Public Overridable Property txtRSExtraCostLabel As TextBox
			Get
				Return Me._txtRSExtraCostLabel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtRSExtraCostLabel_Leave
				Dim value3 As EventHandler = AddressOf Me.txtRSExtraCostLabel_Enter
				Dim value4 As EventHandler = AddressOf Me.txtRSExtraCostLabel_TextChanged
				If Me._txtRSExtraCostLabel IsNot Nothing Then
					RemoveHandler Me._txtRSExtraCostLabel.Leave, value2
					RemoveHandler Me._txtRSExtraCostLabel.Enter, value3
					RemoveHandler Me._txtRSExtraCostLabel.TextChanged, value4
				End If
				Me._txtRSExtraCostLabel = value
				If Me._txtRSExtraCostLabel IsNot Nothing Then
					AddHandler Me._txtRSExtraCostLabel.Leave, value2
					AddHandler Me._txtRSExtraCostLabel.Enter, value3
					AddHandler Me._txtRSExtraCostLabel.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property txtRSExtraCost As TextBox
			Get
				Return Me._txtRSExtraCost
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtRSExtraCost_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtRSExtraCost_Leave
				Dim value4 As EventHandler = AddressOf Me.txtRSExtraCost_Enter
				If Me._txtRSExtraCost IsNot Nothing Then
					RemoveHandler Me._txtRSExtraCost.TextChanged, value2
					RemoveHandler Me._txtRSExtraCost.Leave, value3
					RemoveHandler Me._txtRSExtraCost.Enter, value4
				End If
				Me._txtRSExtraCost = value
				If Me._txtRSExtraCost IsNot Nothing Then
					AddHandler Me._txtRSExtraCost.TextChanged, value2
					AddHandler Me._txtRSExtraCost.Leave, value3
					AddHandler Me._txtRSExtraCost.Enter, value4
				End If
			End Set
		End Property

		Public Overridable Property cboLookupDiameter As ComboBox
			Get
				Return Me._cboLookupDiameter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._cboLookupDiameter = value
			End Set
		End Property

		Public Overridable Property cboLookupDisplayName As ComboBox
			Get
				Return Me._cboLookupDisplayName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._cboLookupDisplayName = value
			End Set
		End Property

		Public Overridable Property txtRSFricCoeff As TextBox
			Get
				Return Me._txtRSFricCoeff
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtRSFricCoeff_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtRSFricCoeff_Enter
				If Me._txtRSFricCoeff IsNot Nothing Then
					RemoveHandler Me._txtRSFricCoeff.TextChanged, value2
					RemoveHandler Me._txtRSFricCoeff.Enter, value3
				End If
				Me._txtRSFricCoeff = value
				If Me._txtRSFricCoeff IsNot Nothing Then
					AddHandler Me._txtRSFricCoeff.TextChanged, value2
					AddHandler Me._txtRSFricCoeff.Enter, value3
				End If
			End Set
		End Property

		Public Overridable Property lblRSFricCoeff As Label
			Get
				Return Me._lblRSFricCoeff
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSFricCoeff = value
			End Set
		End Property

		Public Overridable Property lblServiceFactor As Label
			Get
				Return Me._lblServiceFactor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblServiceFactor = value
			End Set
		End Property

		Public Overridable Property lblRSSBLength As Label
			Get
				Return Me._lblRSSBLength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSSBLength = value
			End Set
		End Property

		Public Overridable Property lblRSExtraCostLabel As Label
			Get
				Return Me._lblRSExtraCostLabel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSExtraCostLabel = value
			End Set
		End Property

		Public Overridable Property lbRSExtraCost As Label
			Get
				Return Me._lbRSExtraCost
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lbRSExtraCost = value
			End Set
		End Property

		Public Overridable Property lblRSSBDiameter As Label
			Get
				Return Me._lblRSSBDiameter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSSBDiameter = value
			End Set
		End Property

		Public Overridable Property lblRSSBGrade As Label
			Get
				Return Me._lblRSSBGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSSBGrade = value
			End Set
		End Property

		Public Overridable Property lblRSMaxSize As Label
			Get
				Return Me._lblRSMaxSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSMaxSize = value
			End Set
		End Property

		Public Overridable Property lblRSMinSize As Label
			Get
				Return Me._lblRSMinSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSMinSize = value
			End Set
		End Property

		Public Overridable Property lblRSGrade As Label
			Get
				Return Me._lblRSGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSGrade = value
			End Set
		End Property

		Public Overridable Property lblRSFGGrade As Label
			Get
				Return Me._lblRSFGGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSFGGrade = value
			End Set
		End Property

		Friend Overridable Property lblRSSBDiameter_Disabled As Label
			Get
				Return Me._lblRSSBDiameter_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSSBDiameter_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblFricFootnote As Label
			Get
				Return Me._lblFricFootnote
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFricFootnote = value
			End Set
		End Property

		Friend Overridable Property txtLength As TextBox
			Get
				Return Me._txtLength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtLength_Enter
				Dim value3 As EventHandler = AddressOf Me.txtLength_Leave
				Dim value4 As KeyEventHandler = AddressOf Me.txtLength_KeyDown
				Dim value5 As KeyPressEventHandler = AddressOf Me.txtLength_KeyPress
				If Me._txtLength IsNot Nothing Then
					RemoveHandler Me._txtLength.Enter, value2
					RemoveHandler Me._txtLength.Leave, value3
					RemoveHandler Me._txtLength.KeyDown, value4
					RemoveHandler Me._txtLength.KeyPress, value5
				End If
				Me._txtLength = value
				If Me._txtLength IsNot Nothing Then
					AddHandler Me._txtLength.Enter, value2
					AddHandler Me._txtLength.Leave, value3
					AddHandler Me._txtLength.KeyDown, value4
					AddHandler Me._txtLength.KeyPress, value5
				End If
			End Set
		End Property

		Friend Overridable Property cboRSMaxSize As ComboBox
			Get
				Return Me._cboRSMaxSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRSMaxSize_Leave
				Dim value3 As EventHandler = AddressOf Me.cboRSMaxSize_EnabledChanged
				Dim value4 As EventHandler = AddressOf Me.cboRSMaxSize_SelectedIndexChanged
				If Me._cboRSMaxSize IsNot Nothing Then
					RemoveHandler Me._cboRSMaxSize.Leave, value2
					RemoveHandler Me._cboRSMaxSize.EnabledChanged, value3
					RemoveHandler Me._cboRSMaxSize.SelectedIndexChanged, value4
				End If
				Me._cboRSMaxSize = value
				If Me._cboRSMaxSize IsNot Nothing Then
					AddHandler Me._cboRSMaxSize.Leave, value2
					AddHandler Me._cboRSMaxSize.EnabledChanged, value3
					AddHandler Me._cboRSMaxSize.SelectedIndexChanged, value4
				End If
			End Set
		End Property

		Friend Overridable Property cboRSMinSize As ComboBox
			Get
				Return Me._cboRSMinSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRSMinSize_Leave
				Dim value3 As EventHandler = AddressOf Me.cboRSMinSize_EnabledChanged
				Dim value4 As EventHandler = AddressOf Me.cboRSMinSize_SelectedIndexChanged
				If Me._cboRSMinSize IsNot Nothing Then
					RemoveHandler Me._cboRSMinSize.Leave, value2
					RemoveHandler Me._cboRSMinSize.EnabledChanged, value3
					RemoveHandler Me._cboRSMinSize.SelectedIndexChanged, value4
				End If
				Me._cboRSMinSize = value
				If Me._cboRSMinSize IsNot Nothing Then
					AddHandler Me._cboRSMinSize.Leave, value2
					AddHandler Me._cboRSMinSize.EnabledChanged, value3
					AddHandler Me._cboRSMinSize.SelectedIndexChanged, value4
				End If
			End Set
		End Property

		Friend Overridable Property lblRSSBLength_Disabled As Label
			Get
				Return Me._lblRSSBLength_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSSBLength_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblRSGrade_Disabled As Label
			Get
				Return Me._lblRSGrade_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSGrade_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblRSMaxSize_Disabled As Label
			Get
				Return Me._lblRSMaxSize_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSMaxSize_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblRSMinSize_Disabled As Label
			Get
				Return Me._lblRSMinSize_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSMinSize_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblRSSBGrade_Disabled As Label
			Get
				Return Me._lblRSSBGrade_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSSBGrade_Disabled = value
			End Set
		End Property

		Friend Overridable Property lbl_RSSBDiameter_Disabled As Label
			Get
				Return Me._lbl_RSSBDiameter_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lbl_RSSBDiameter_Disabled = value
			End Set
		End Property

		Public Overridable Property cboRSSBDiameter As ComboBox
			Get
				Return Me._cboRSSBDiameter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRSSBDiameter_BindingContextChanged
				Dim value3 As EventHandler = AddressOf Me.cboRSSBDiameter_DataSourceChanged
				Dim value4 As EventHandler = AddressOf Me.cboRSSBDiameter_SelectionChangeCommitted
				Dim value5 As EventHandler = AddressOf Me.cboRSSBDiameter_EnabledChanged
				Dim value6 As EventHandler = AddressOf Me.cboRSSBDiameter_SelectedIndexChanged
				If Me._cboRSSBDiameter IsNot Nothing Then
					RemoveHandler Me._cboRSSBDiameter.BindingContextChanged, value2
					RemoveHandler Me._cboRSSBDiameter.DataSourceChanged, value3
					RemoveHandler Me._cboRSSBDiameter.SelectionChangeCommitted, value4
					RemoveHandler Me._cboRSSBDiameter.EnabledChanged, value5
					RemoveHandler Me._cboRSSBDiameter.SelectedIndexChanged, value6
				End If
				Me._cboRSSBDiameter = value
				If Me._cboRSSBDiameter IsNot Nothing Then
					AddHandler Me._cboRSSBDiameter.BindingContextChanged, value2
					AddHandler Me._cboRSSBDiameter.DataSourceChanged, value3
					AddHandler Me._cboRSSBDiameter.SelectionChangeCommitted, value4
					AddHandler Me._cboRSSBDiameter.EnabledChanged, value5
					AddHandler Me._cboRSSBDiameter.SelectedIndexChanged, value6
				End If
			End Set
		End Property

		Friend Overridable Property lblStatus As Label
			Get
				Return Me._lblStatus
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.lblStatus_TextChanged
				If Me._lblStatus IsNot Nothing Then
					RemoveHandler Me._lblStatus.TextChanged, value2
				End If
				Me._lblStatus = value
				If Me._lblStatus IsNot Nothing Then
					AddHandler Me._lblStatus.TextChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property ContextMenu1 As ContextMenu
			Get
				Return Me._ContextMenu1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._ContextMenu1 = value
			End Set
		End Property

		Friend Overridable Property cboRodGuides As ComboBox
			Get
				Return Me._cboRodGuides
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRodGuides_SelectedIndexChanged
				Dim value3 As EventHandler = AddressOf Me.cboRodGuides_Enter
				Dim value4 As CancelEventHandler = AddressOf Me.cboRodGuides_Validating
				Dim value5 As EventHandler = AddressOf Me.cboRodGuides_SelectionChangeCommitted
				If Me._cboRodGuides IsNot Nothing Then
					RemoveHandler Me._cboRodGuides.SelectedIndexChanged, value2
					RemoveHandler Me._cboRodGuides.Enter, value3
					RemoveHandler Me._cboRodGuides.Validating, value4
					RemoveHandler Me._cboRodGuides.SelectionChangeCommitted, value5
				End If
				Me._cboRodGuides = value
				If Me._cboRodGuides IsNot Nothing Then
					AddHandler Me._cboRodGuides.SelectedIndexChanged, value2
					AddHandler Me._cboRodGuides.Enter, value3
					AddHandler Me._cboRodGuides.Validating, value4
					AddHandler Me._cboRodGuides.SelectionChangeCommitted, value5
				End If
			End Set
		End Property

		Friend Overridable Property chkDesignSinkerbars As CheckBox
			Get
				Return Me._chkDesignSinkerbars
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkDesignSinkerbars_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.chkDesignSinkerbars_CheckedChanged
				If Me._chkDesignSinkerbars IsNot Nothing Then
					RemoveHandler Me._chkDesignSinkerbars.EnabledChanged, value2
					RemoveHandler Me._chkDesignSinkerbars.CheckedChanged, value3
				End If
				Me._chkDesignSinkerbars = value
				If Me._chkDesignSinkerbars IsNot Nothing Then
					AddHandler Me._chkDesignSinkerbars.EnabledChanged, value2
					AddHandler Me._chkDesignSinkerbars.CheckedChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property lblStringLength As Label
			Get
				Return Me._lblStringLength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblStringLength = value
			End Set
		End Property

		Public Shared Property DefInstance As RSInput
			Get
				If RSInput.m_vb6FormDefInstance Is Nothing OrElse RSInput.m_vb6FormDefInstance.IsDisposed Then
					RSInput.m_InitializingDefInstance = True
					RSInput.m_vb6FormDefInstance = New RSInput()
					RSInput.m_InitializingDefInstance = False
				End If
				Return RSInput.m_vb6FormDefInstance
			End Get
			Set(value As RSInput)
				RSInput.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property mbMaxMinNotYetSet As Boolean
			Get
				Return Me.m_mbMaxMinNotYetSet
			End Get
			Set(value As Boolean)
				Me.m_mbMaxMinNotYetSet = value
			End Set
		End Property

		Public Property miDesignStyle As Integer
			Get
				Return CInt(Me.m_miDesignStyle)
			End Get
			Set(value As Integer)
				Me.m_miDesignStyle = CType(value, RSInput.EDesignStyle)
				RSWIN_DESC.rst.giRodDesignStyle = CShort(Me.m_miDesignStyle)
			End Set
		End Property

		Private Sub AddRodTaper(RodNum As Integer, RodGrade As StdInfoConstants.RodGradeConstants, RodSize As Single, RodLength As Single, Optional RodFrictionCoef As Single = 0.2F, Optional RodGuide As Short = 0S, Optional iNumGuides As Short = 0S, Optional bInsert As Boolean = False, Optional iInsertPoint As Integer = 0, Optional bConvert As Boolean = True)
			Dim array As StdInfoConstants.RodMatlConstants() = New StdInfoConstants.RodMatlConstants(6) {}
			Try
				array(0) = StdInfoConstants.RodMatlConstants.teRodMatlAPISteel
				If RSWIN_DESC.bUseLatestGradeChanges Then
					array(1) = StdInfoConstants.RodMatlConstants.teRodMatlProrod
					array(2) = StdInfoConstants.RodMatlConstants.teRodMatlCorod
				Else
					array(1) = StdInfoConstants.RodMatlConstants.teRodMatlCorod
					array(2) = StdInfoConstants.RodMatlConstants.teRodMatlProrod
				End If
				array(3) = StdInfoConstants.RodMatlConstants.teRodMatlFG
				array(4) = StdInfoConstants.RodMatlConstants.teRodMatlRR
				array(5) = StdInfoConstants.RodMatlConstants.teRodMatlSinkerBar
				array(6) = StdInfoConstants.RodMatlConstants.teRodMatlSteel
				Dim num As Integer = 0
				Dim text As String = ""
				If RodGrade >= CType(0, StdInfoConstants.RodGradeConstants) Then
					Dim num3 As Integer
					If RodGrade = CType(0, StdInfoConstants.RodGradeConstants) Then
						num = 0
						If Me.bShowGuides And RSWIN_DESC.bRodStarD Then
							Dim rodGuideName As String = Me.GetRodGuideName(RodGuide)
						End If
						If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bRodStarD Then
							iNumGuides = 0S
						End If
					Else
						Dim teRodSizeList As teRodSizeList
						If CUSTOMRG.IsOtherSteel(CInt(RodGrade)) Or CUSTOMRG.IsOtherFG(CInt(RodGrade)) Or CUSTOMRG.IsOtherSinkerBar(CInt(RodGrade)) Then
							If CUSTOMRG.IsOtherFG(CInt(RodGrade)) Then
								Dim num2 As Single = 0F
								text = RODUTIL.GetOtherFG(CInt(RodGrade), num2)
							ElseIf CUSTOMRG.IsOtherSinkerBar(CInt(RodGrade)) Then
								Dim num2 As Single = 0F
								text = RODUTIL.GetOtherSinkerbar(CInt(RodGrade), num2)
							ElseIf CUSTOMRG.IsOtherSteel(CInt(RodGrade)) Then
								Dim num2 As Single = 0F
								text = RODUTIL.GetOtherSteel(CInt(RodGrade), num2)
							End If
							If CUSTOMRG.IsOtherSinkerBar(CInt(RodGrade)) Then
								teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(13)
							ElseIf Not RODUTIL.IsAPI(CInt(RodGrade), text) Then
								teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(14)
							Else
								teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(1)
							End If
						Else
							Dim rodGradeID As Integer = CInt(RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(RodGrade).RodGradeID)
							Try
								Dim name As String = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(RodGrade).Name
								teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(rodGradeID, StdInfoConstants.RodGradeConstants)).RodSizeList
							Catch ex As Exception
							End Try
						End If
						Dim dictionaryEntry As DictionaryEntry
						Try
							For Each obj As Object In teRodSizeList
								Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
								If teRodSize.Diameter = RodSize Then
									num = teRodSize.RodSizeID
									Dim displayName As String = teRodSize.DisplayName
									Exit For
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						Try
							Dim flag As Boolean = False
							num3 = 0
							While Not flag And num3 <= 5
								Dim teRodGradeList As teRodGradeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().RodGradeLists().Item(array(num3))
								Try
									For Each obj2 As Object In teRodGradeList
										Dim teRodGrade As teRodGrade = CType(If((obj2 IsNot Nothing), CType(obj2, DictionaryEntry), dictionaryEntry).Value, teRodGrade)
										If teRodGrade.RodGradeID = RodGrade Then
											text = teRodGrade.Name
											flag = True
											Exit For
										End If
									Next
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
								num3 += 1
							End While
						Catch ex2 As Exception
						End Try
						If Me.bShowGuides And RSWIN_DESC.bRodStarD Then
							Dim rodGuideName As String = Me.GetRodGuideName(RodGuide)
						End If
					End If
					Dim dataRow As DataRow = Me.mdsRodTapers.Tables(0).NewRow()
					dataRow("RodNum") = RodNum
					num3 = CInt(RodGrade)
					dataRow("RodGrade") = num3
					If RodSize <> -1F Then
						dataRow("RodSize") = num
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							Dim num4 As Single = RodSize
							Me.txtTempDiam.Tag = "mem"
							Me.txtTempDiam.Text = num4.ToString()
							Dim textBox As TextBox = Me.txtTempDiam
							Dim lblTemp As Label = Me.lblTemp
							Me.TextBox_Change(textBox, lblTemp)
							Me.lblTemp = lblTemp
							Me.txtTempDiam = textBox
							dataRow("RodDiam") = Convert.ToSingle(Me.txtTempDiam.Text)
						Else
							dataRow("RodDiam") = RodSize.ToString()
						End If
					Else
						dataRow("RodSize") = DBNull.Value
						dataRow("RodDiam") = DBNull.Value
					End If
					If RodLength = -1F Then
						dataRow("RodLength") = DBNull.Value
					ElseIf RSWIN_DESC.SETUP_MeasurementSystem <> 1 AndAlso bConvert Then
						Dim num5 As Single = RodLength
						Me.txtTempLength.Tag = "fem"
						Me.txtTempLength.Text = num5.ToString()
						Dim textBox As TextBox = Me.txtTempLength
						Dim lblTemp As Label = Me.lblTemp
						Me.TextBox_Change(textBox, lblTemp)
						Me.lblTemp = lblTemp
						Me.txtTempLength = textBox
						dataRow("RodLength") = Convert.ToSingle(Me.txtTempLength.Text)
					Else
						dataRow("RodLength") = RodLength
					End If
					If RSWIN_DESC.bRodStarD Then
						If Me.bShowGuides Then
							dataRow("RodGuide") = RodGuide
						End If
						If RSWIN_DESC.SETUP_ALLOWSLIDEFRIC <> 0S Then
							If RodFrictionCoef = -1F Then
								dataRow("RodFrictionCoef") = DBNull.Value
							ElseIf RodFrictionCoef = 0F Then
								dataRow("RodFrictionCoef") = 0.2
							Else
								dataRow("RodFrictionCoef") = RodFrictionCoef
							End If
						End If
						If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bRodStarD Then
							dataRow("NumGuides") = iNumGuides
						End If
					End If
					If bInsert Then
						Me.mdsRodTapers.Tables(0).Rows.InsertAt(dataRow, iInsertPoint - 1)
						Dim flag2 As Boolean = False
						Try
							For Each obj3 As Object In Me.mdsRodTapers.Tables(0).Rows
								Dim dataRow2 As DataRow = CType(obj3, DataRow)
								Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dataRow2("RodNum"))
								If Operators.ConditionalCompareObjectGreaterEqual(objectValue, RodNum, False) Then
									If flag2 Then
										dataRow2("RodNum") = Operators.AddObject(objectValue, 1)
									Else
										flag2 = True
									End If
								End If
							Next
						Finally
							Dim enumerator3 As IEnumerator
							If TypeOf enumerator3 Is IDisposable Then
								TryCast(enumerator3, IDisposable).Dispose()
							End If
						End Try
						Dim ulgTapers As UltraGrid = Me.ulgTapers
						ulgTapers.DataSource = Nothing
						ulgTapers.DataSource = Me.mdsRodTapers
						Me.ulgTapers.Rows.Refresh(RefreshRow.RefreshDisplay, True)
						Me.MakeRowActive(RodNum)
					Else
						Me.mdsRodTapers.Tables(0).Rows.Add(dataRow)
					End If
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Private Function BeforeEditRodgrade() As Boolean
			Dim arrayList As ArrayList = New ArrayList()
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
				Dim num As Integer = Conversions.ToInteger(activeCell.Row.Cells("RodGrade").Value)
				If(num = 0 Or num = -1) AndAlso activeCell.Row.HasPrevSibling() Then
					Dim sibling As UltraGridRow = activeCell.Row.GetSibling(SiblingRow.Previous)
					Dim ultraGridCell As UltraGridCell = sibling.Cells("RodGrade")
					num = Conversions.ToInteger(ultraGridCell.Value)
				End If
				Try
					Me.cboRodGrade.BackColor = Color.Cyan
					Me.cboRodGrade.ForeColor = Color.Black
					If num > 1000 Then
						Me.cboRodGrade.SelectedValue = num
					Else
						Me.cboRodGrade.SelectedIndex = -1
					End If
				Catch ex As Exception
					Me.cboRodGrade.SelectedValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboRodGrade.Items(0), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
				End Try
				result = flag
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Private Function CheckRodSize(iRodGrade As Integer, iRodSize As Integer, sRodSizeName As String, ByRef iNewRodSize As Integer, Optional sRodGradeName As String = "") As Boolean
			iNewRodSize = iRodSize
			Dim result As Boolean
			Try
				Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
				Dim flag As Boolean = False
				If iRodGrade <> 0 And iRodGrade <> -1 Then
					Dim rodSizeList As teRodSizeList
					Try
						rodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iRodGrade, StdInfoConstants.RodGradeConstants)).RodSizeList
					Catch ex As Exception
					End Try
					If iRodSize <> 0 Then
						Dim dictionaryEntry As DictionaryEntry
						Try
							For Each obj As Object In rodSizeList
								Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
								If iRodSize = teRodSize.RodSizeID Then
									flag = True
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						If Not flag Then
							Try
								For Each obj2 As Object In rodSizeList
									Dim teRodSize As teRodSize = CType(If((obj2 IsNot Nothing), CType(obj2, DictionaryEntry), dictionaryEntry).Value, teRodSize)
									If Operators.CompareString(sRodSizeName.Trim(), teRodSize.DisplayName.Trim(), False) = 0 Then
										flag = True
										iNewRodSize = teRodSize.RodSizeID
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
						End If
					End If
				End If
				result = flag
			Catch ex2 As Exception
				Dim dialogResult As DialogResult
				If sRodGradeName.Length > 0 Then
					Try
						Me.bLoadingCombo = True
						Dim cboRodSize As ComboBox = Me.cboRodSize
						RODUTIL.LoadCustomRodDiameterList(cboRodSize, CShort(iRodGrade), sRodGradeName, False)
						Me.cboRodSize = cboRodSize
						Me.bLoadingCombo = False
						GoTo IL_1CD
					Catch ex3 As Exception
						Dim sMsg As String = "Error in CheckRodSize: " + ex3.Message
						Dim sMsgType As String = ""
						Dim bClosing As Boolean = False
						dialogResult = DialogResult.OK
						Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
						GoTo IL_1CD
					End Try
				End If
				Dim sMsg2 As String = "Error in CheckRodSize: " + ex2.Message
				Dim sMsgType2 As String = ""
				Dim bClosing2 As Boolean = False
				dialogResult = DialogResult.OK
				Util.SendMessage(sMsg2, sMsgType2, bClosing2, dialogResult)
				IL_1CD:
			End Try
			Return result
		End Function

		Private Function BeforeEditRodGuide() As Boolean
			Dim arrayList As ArrayList = New ArrayList()
			Dim result As Boolean
			Try
				If RSWIN_DESC.bRodStarD Then
					Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
					Dim num As Integer = Conversions.ToInteger(activeCell.Row.Cells("RodGuide").Value)
					If num = -1 AndAlso activeCell.Row.HasPrevSibling() Then
						Dim sibling As UltraGridRow = activeCell.Row.GetSibling(SiblingRow.Previous)
						Dim ultraGridCell As UltraGridCell = sibling.Cells("RodGuide")
						num = Conversions.ToInteger(ultraGridCell.Value)
					End If
					Try
						Me.cboRodGuides.BackColor = Color.Cyan
						Me.cboRodGuides.ForeColor = Color.Black
						Me.cboRodGuides.SelectedValue = num
					Catch ex As Exception
						Me.cboRodGuides.SelectedValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboRodGuides.Items(0), Nothing, "RodGuideID", New Object(-1) {}, Nothing, Nothing, Nothing))
					End Try
				End If
				result = True
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Private Function BeforeEditRodSize(iRow As Integer, sDiamValue As String) As Boolean
			Dim arrayList As ArrayList = New ArrayList()
			Dim num As Integer = 0
			Dim text As String = ""
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
				Dim num2 As Integer = Conversions.ToInteger(activeCell.Row.Cells("RodGrade").Value)
				If num2 = 0 Or num2 = -1 Then
					If activeCell.Row.HasPrevSibling() Then
						Dim sibling As UltraGridRow = activeCell.Row.GetSibling(SiblingRow.Previous)
						Dim ultraGridCell As UltraGridCell = sibling.Cells("RodGrade")
						num2 = Conversions.ToInteger(ultraGridCell.Value)
					Else
						flag = False
					End If
				End If
				If flag Then
					Dim text2 As String = Conversions.ToString(activeCell.Row.Cells("RodGrade").Value)
					Try
						text = activeCell.Row.Cells("RodGrade").Text
					Catch ex As Exception
						text = ""
					End Try
					Dim teRodSizeList As teRodSizeList
					If CUSTOMRG.IsOtherSteel(num2) Or CUSTOMRG.IsOtherFG(num2) Or CUSTOMRG.IsOtherSinkerBar(num2) Then
						teRodSizeList = Nothing
						If CUSTOMRG.IsOtherSinkerBar(num2) Then
							teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(13)
						ElseIf Not RODUTIL.IsAPI(num2, text) Then
							teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(14)
						Else
							teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(1)
						End If
					ElseIf num2 <> 0 And num2 <> -1 Then
						Try
							teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(num2, StdInfoConstants.RodGradeConstants)).RodSizeList
						Catch ex2 As Exception
						End Try
					End If
					If num2 <> 0 And num2 <> -1 Then
						Dim num3 As Integer = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(activeCell.Value)), 0, RuntimeHelpers.GetObjectValue(activeCell.Value)))
						Dim dictionaryEntry As DictionaryEntry
						If num3 = 0 AndAlso activeCell.Row.HasPrevSibling() Then
							Dim sibling2 As UltraGridRow = activeCell.Row.GetSibling(SiblingRow.Previous)
							Dim ultraGridCell2 As UltraGridCell = sibling2.Cells("RodGrade")
							Dim num4 As Integer = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridCell2.Value)), 0, RuntimeHelpers.GetObjectValue(ultraGridCell2.Value)))
							Dim ultraGridCell3 As UltraGridCell = sibling2.Cells("RodSize")
							Dim num5 As Integer = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridCell3.Value)), 0, RuntimeHelpers.GetObjectValue(ultraGridCell3.Value)))
							If num4 <> 0 And num5 <> 0 Then
								Dim diameter As Single
								Try
									diameter = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(num4, StdInfoConstants.RodGradeConstants)).RodSizeList.Item(num5).Diameter
								Catch ex3 As Exception
								End Try
								num3 = 0
								Try
									For Each obj As Object In teRodSizeList
										Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
										If teRodSize.Diameter < diameter Then
											If num3 = 0 Then
												num3 = teRodSize.RodSizeID
											ElseIf teRodSize.Diameter > teRodSizeList.Item(num3).Diameter Then
												num3 = teRodSize.RodSizeID
											End If
										End If
									Next
								Finally
									Dim enumerator As IEnumerator
									If TypeOf enumerator Is IDisposable Then
										TryCast(enumerator, IDisposable).Dispose()
									End If
								End Try
								If num3 = 0 Then
									Try
										For Each obj2 As Object In teRodSizeList
											Dim teRodSize As teRodSize = CType(If((obj2 IsNot Nothing), CType(obj2, DictionaryEntry), dictionaryEntry).Value, teRodSize)
											If num3 = 0 Then
												num3 = teRodSize.RodSizeID
											ElseIf teRodSize.Diameter < teRodSizeList.Item(num3).Diameter Then
												num3 = teRodSize.RodSizeID
											End If
										Next
									Finally
										Dim enumerator2 As IEnumerator
										If TypeOf enumerator2 Is IDisposable Then
											TryCast(enumerator2, IDisposable).Dispose()
										End If
									End Try
								End If
							End If
						End If
						Dim i As Integer = -1
						Dim array As RSInput.RodSizeArray()
						Try
							For Each obj3 As Object In teRodSizeList
								Dim teRodSize As teRodSize = CType(If((obj3 IsNot Nothing), CType(obj3, DictionaryEntry), dictionaryEntry).Value, teRodSize)
								If Not(LikeOperator.LikeString(teRodSize.DisplayName, "(Custom *)", CompareMethod.Binary) Or LikeOperator.LikeString(teRodSize.DisplayName, "(Unknown *)", CompareMethod.Binary)) Then
									i += 1
									array = CType(Utils.CopyArray(CType(array, Array), New RSInput.RodSizeArray(i + 1 - 1) {}), RSInput.RodSizeArray())
									If teRodSize.Diameter = 1F Then
										num = i
									End If
									If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
										array(i).rsaRodSizeID = teRodSize.RodSizeID
										array(i).rsaDisplayName = teRodSize.DisplayName
										array(i).rsaDiameter = teRodSize.Diameter
									Else
										Try
											array(i).rsaRodSizeID = teRodSize.RodSizeID
											array(i).rsaDisplayName = teRodSize.MetricDisplayName
											array(i).rsaDiameter = teRodSize.Diameter
										Catch ex4 As Exception
										End Try
									End If
								End If
							Next
						Finally
							Dim enumerator3 As IEnumerator
							If TypeOf enumerator3 Is IDisposable Then
								TryCast(enumerator3, IDisposable).Dispose()
							End If
						End Try
						If Not RODUTIL.IsFG(CShort(num2)) Then
							i += 1
							array = CType(Utils.CopyArray(CType(array, Array), New RSInput.RodSizeArray(i + 1 - 1) {}), RSInput.RodSizeArray())
							array(i).rsaRodSizeID = 0
							array(i).rsaDisplayName = "Other"
							array(i).rsaDiameter = 0F
						End If
						Dim comparer As RSInput.rsaComparer = New RSInput.rsaComparer()
						Array.Sort(array, comparer)
						If arrayList Is Nothing Then
							arrayList = New ArrayList()
						End If
						arrayList.Clear()
						Dim num6 As Integer = 0
						Dim num7 As Integer = array.Length - 1
						i = num6
						While i <= num7
							Debug.WriteLine(Conversions.ToString(array(i).rsaRodSizeID) + " , " + array(i).rsaDisplayName)
							arrayList.Add(New cRodSize(array(i).rsaRodSizeID, array(i).rsaDisplayName))
							i += 1
						End While
						Me.cboRodSize.DataSource = arrayList
						Me.cboRodSize.DisplayMember = "DisplayName"
						Me.cboRodSize.ValueMember = "RodSizeID"
						Try
							If num3 = 0 And iRow = 1 And Operators.CompareString(sDiamValue, "", False) = 0 And num <> 0 Then
								Me.cboRodSize.SelectedIndex = num
							Else
								Me.cboRodSize.SelectedValue = num3
							End If
						Catch ex5 As Exception
							Me.cboRodSize.SelectedIndex = Conversions.ToInteger(NewLateBinding.LateGet(Me.cboRodSize.Items(0), Nothing, "RodSizeID", New Object(-1) {}, Nothing, Nothing, Nothing))
						End Try
					End If
					Me.myRodSizeAL = arrayList
				End If
				result = flag
			Catch ex6 As Exception
				Dim flag As Boolean
				If flag Then
					result = True
				Else
					result = False
				End If
			End Try
			Return result
		End Function

		Private Sub RSInput_Resize(sender As Object, e As EventArgs)
		End Sub

		Private Sub RSInput_Validating(sender As Object, e As CancelEventArgs)
			If Not Me.m_bLeaveLoaded Then
				Me.ValidateRSInput(Me.bFormLoaded, True, False)
			End If
		End Sub

		Public Function ValidateRSInput(bFormLoaded As Boolean, Optional bQuiet As Boolean = True, Optional bCallFromMain As Boolean = False) As Boolean
			Dim flag As Boolean = False
			Dim num As Single = 0F
			Dim result As Boolean
			Try
				If Me.MyParentFrm Is Nothing Then
					Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
				End If
				If Me.MyParentFrm IsNot Nothing AndAlso bFormLoaded Then
					If Not Me.MyParentFrm.bClosing Then
						Dim flag2 As Boolean = True
						If RSWIN_DESC.rst.ServiceFactor = 0F Then
							If Not bQuiet Then
								Me.DisplayRSInputError("Please enter a value for service factor", flag)
								If Not flag Then
									Dim txtServiceFactor As Control = Me.txtServiceFactor
									Me.SetActiveControl(txtServiceFactor)
									Me.txtServiceFactor = CType(txtServiceFactor, TextBox)
									flag2 = False
								End If
							Else
								flag2 = False
							End If
						Else
							Dim rst As cRODSTAR = RSWIN_DESC.rst
							Dim obj As Object = rst.ServiceFactor
							Dim lowerBound As Single = 0.5F
							Dim inclusive As Integer = -1
							Dim errnum As Integer = 61
							Dim useMetric As Integer = 0
							Dim canadianIsMetric As Integer = 0
							Dim text As String = ""
							Dim obj2 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text)
							rst.ServiceFactor = Conversions.ToSingle(obj)
							If Conversions.ToBoolean(Operators.NotObject(obj2)) Then
								If Not bQuiet Then
									Dim txtServiceFactor As Control = Me.txtServiceFactor
									Me.SetActiveControl(txtServiceFactor)
									Me.txtServiceFactor = CType(txtServiceFactor, TextBox)
								End If
								flag2 = False
							Else
								rst = RSWIN_DESC.rst
								obj = rst.ServiceFactor
								Dim upperBound As Single = 1F
								Dim inclusive2 As Integer = -1
								Dim errnum2 As Integer = 61
								Dim useMetric2 As Integer = 0
								Dim canadianIsMetric2 As Integer = 0
								text = ""
								Dim obj3 As Object = Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet, text)
								rst.ServiceFactor = Conversions.ToSingle(obj)
								If Conversions.ToBoolean(Operators.NotObject(obj3)) Then
									If Not bQuiet Then
										Dim txtServiceFactor As Control = Me.txtServiceFactor
										Me.SetActiveControl(txtServiceFactor)
										Me.txtServiceFactor = CType(txtServiceFactor, TextBox)
									End If
									flag2 = False
								End If
							End If
						End If
						Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
						If Me.miDesignStyle = 3 Then
							' The following expression was wrapped in a checked-expression
							cRODSTAR.NumRods = CShort(Me.mdsRodTapers.Tables(0).Rows.Count)
							Try
								For Each obj4 As Object In Me.mdsRodTapers.Tables(0).Rows
									Dim dataRow As DataRow = CType(obj4, DataRow)
									Dim num2 As Integer = Conversions.ToInteger(dataRow("RodNum"))
									Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
									Dim num3 As Integer = num2
									Try
										sections(num3).Grade = Conversions.ToShort(dataRow("RodGrade"))
										Try
											If Not CUSTOMRG.IsOtherSteel(CInt(sections(num3).Grade)) And Not CUSTOMRG.IsOtherFG(CInt(sections(num3).Grade)) And Not CUSTOMRG.IsOtherSinkerBar(CInt(sections(num3).Grade)) Then
												Try
													sections(num3).RodType = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants)).Name
												Catch ex As Exception
												End Try
												Try
													sections(num3).TensileStrength = Conversions.ToSingle(RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants)).TensileStrength)
													GoTo IL_429
												Catch ex2 As Exception
													GoTo IL_429
												End Try
											End If
											Try
												If Strings.InStr(sections(num3).RodType, "Custom", CompareMethod.Binary) > 0 Then
													sections(num3).RodType = Conversions.ToString(RODUTIL.GetCustomRodTypeName(sections(num3).Grade))
												ElseIf CUSTOMRG.IsOtherFG(CInt(sections(num3).Grade)) Then
													Dim array As RSWIN_DESC.RodSection() = sections
													Dim num4 As Integer = num3
													Dim grade As Integer = CInt(sections(num3).Grade)
													Dim num5 As Single = 0F
													array(num4).RodType = RODUTIL.GetOtherFG(grade, num5)
												ElseIf CUSTOMRG.IsOtherSinkerBar(CInt(sections(num3).Grade)) Then
													Dim array2 As RSWIN_DESC.RodSection() = sections
													Dim num6 As Integer = num3
													Dim grade2 As Integer = CInt(sections(num3).Grade)
													Dim num5 As Single = 0F
													array2(num6).RodType = RODUTIL.GetOtherSinkerbar(grade2, num5)
												ElseIf CUSTOMRG.IsOtherSteel(CInt(sections(num3).Grade)) Then
													Dim array3 As RSWIN_DESC.RodSection() = sections
													Dim num7 As Integer = num3
													Dim grade3 As Integer = CInt(sections(num3).Grade)
													Dim num5 As Single = 0F
													array3(num7).RodType = RODUTIL.GetOtherSteel(grade3, num5)
												End If
											Catch ex3 As Exception
											End Try
										Catch ex4 As Exception
										End Try
										Dim num8 As Single
										Try
											IL_429:
											num8 = Conversions.ToSingle(Convert.ToString(RuntimeHelpers.GetObjectValue(dataRow("RodDiam"))))
											If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
												CtrlUI.ConvertValue(num8, "m", True)
											End If
											sections(num3).Diameter = num8
											sections(num3).Area = CSng((CDbl((sections(num3).Diameter * sections(num3).Diameter)) * Math.Atan(1.0)))
										Catch ex5 As Exception
										End Try
										If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("RodLength"))) And Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(dataRow("RodLength"))) Then
											Try
												num8 = Conversions.ToSingle(dataRow("RodLength"))
												If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
													CtrlUI.ConvertValue(num8, "f", True)
												End If
												sections(num3).length = num8
											Catch ex6 As Exception
											End Try
											Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("RodLength", dataRow("RodNum")))
											ini.SaveDataValue(text2.Trim(), num8)
											If bCallFromMain And num8 = 0F Then
												flag2 = False
												Me.lblStatus.Text = " " + Me.SEnterTaperLength
												Me.bLengthError = True
											End If
											If Not Me.bLoadingCombo And Not Me.bInsideUpdateRS And num2 = CInt(RSWIN_DESC.rst.NumRods) Then
												Me.UpdateRS()
											End If
										ElseIf Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("RodLength"))) Then
											sections(num3).length = 0F
											flag2 = False
											If bCallFromMain Then
												Me.lblStatus.Text = " " + Me.SEnterTaperLength
											End If
											Me.bLengthError = True
										End If
										Try
											sections(num3).friction_coef = Conversions.ToSingle(dataRow("RodFrictionCoef"))
										Catch ex7 As Exception
										End Try
										If RSWIN_DESC.bRodStarD Then
											If Me.bShowGuides Then
												Try
													sections(num3).Guide = Conversions.ToShort(dataRow("RodGuide"))
												Catch ex8 As Exception
												End Try
											End If
											If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
												Try
													sections(num3).NumGuides = Conversions.ToShort(dataRow("NumGuides"))
												Catch ex9 As Exception
												End Try
											End If
										End If
									Catch ex10 As Exception
									End Try
									If sections(num3).Grade = 16393S Then
										sections(num3).RodDensity = 125F
									ElseIf RODUTIL.IsFG(sections(num3).Grade) Then
										sections(num3).RodDensity = 130F
									ElseIf sections(num3).Grade = 20481S Then
										sections(num3).RodDensity = 100F
									Else
										sections(num3).RodDensity = 491F
									End If
									Dim flag3 As Boolean = True
									If flag3 = (sections(num3).Grade = 16385S) Then
										GoTo IL_7A1
									End If
									If flag3 = (sections(num3).Grade = 16389S) Then
										GoTo IL_7A1
									End If
									If flag3 = (sections(num3).Grade = 16390S) Then
										GoTo IL_7A1
									End If
									If flag3 = RODUTIL.IsCorod(sections(num3).Grade) Then
										sections(num3).SuckerRodLength = 1F
									Else
										sections(num3).SuckerRodLength = 25F
									End If
									IL_7F5:
									RODUTIL.LookupElasticity(RSWIN_DESC.rst.Sections(num2))
									RODUTIL.LookupRodWeight(RSWIN_DESC.rst.Sections(num2))
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(num2))
									num += RSWIN_DESC.rst.Sections(num2).length
									Continue For
									IL_7A1:
									sections(num3).SuckerRodLength = 37.5F
									GoTo IL_7F5
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
							If(((Not bQuiet AndAlso bFormLoaded) And Not Me.bLoadingCombo) AndAlso flag2) And num < RSWIN_DESC.rst.PumpDepth - 50F Then
								flag2 = False
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Me.DisplayRSInputError(Me.sTotalDepth_ft, flag)
								Else
									Me.DisplayRSInputError(Me.sTotalDepth_m, flag)
								End If
								If flag Then
									flag2 = True
								Else
									Me.bLengthError = True
								End If
							ElseIf(((Not bQuiet AndAlso bFormLoaded) And Not Me.bLoadingCombo) AndAlso flag2) And num > RSWIN_DESC.rst.PumpDepth + 1F Then
								flag2 = False
								Dim sMsg As String = " " + Me.sTotalDepth
								Me.DisplayRSInputError(sMsg, flag)
								If flag Then
									flag2 = True
								Else
									Me.bLengthError = True
								End If
							End If
						ElseIf cRODSTAR.RodStringType = 3S Then
							If cRODSTAR.giRodDesignStyle = 1S Then
								If Me.chkRSFGIncludeSteel.Checked And (Me.cboRSGrade.SelectedIndex = -1 Or Me.cboRSMaxSize.SelectedIndex = -1 Or Me.cboRSMinSize.SelectedIndex = -1) Then
									flag2 = False
								End If
								If Not RSWIN_DESC.bExpert Then
									If Me.chkRSIncludeSB.Checked And (Me.cboRSSBGrade.SelectedIndex = -1 Or (Operators.CompareString(Me.txtRSSBLength.Text, "", False) = 0 And Me.txtRSSBLength.Enabled)) Then
										flag2 = False
										If(Not bQuiet AndAlso bFormLoaded) And Not Me.bLoadingCombo And (Me.cboRSSBGrade.SelectedIndex <> -1 And Operators.CompareString(Me.txtRSSBLength.Text, "", False) = 0 And Me.txtRSSBLength.Enabled) Then
											Me.DisplayRSInputError(Me.SEnterSBLength, flag)
										End If
									End If
								ElseIf(Not RSWIN_DESC.rst.gbDesignSinkerbar And Not Me.chkDesignSinkerbars.Checked) AndAlso (Me.chkRSIncludeSB.Checked And (Me.cboRSSBGrade.SelectedIndex = -1 Or (Operators.CompareString(Me.txtRSSBLength.Text, "", False) = 0 And Me.txtRSSBLength.Enabled))) Then
									flag2 = False
									If(Not bQuiet AndAlso bFormLoaded) And Not Me.bLoadingCombo And (Me.cboRSSBGrade.SelectedIndex <> -1 And Operators.CompareString(Me.txtRSSBLength.Text, "", False) = 0 And Me.txtRSSBLength.Enabled) Then
										Me.DisplayRSInputError(Me.SEnterSBLength, flag)
									End If
								End If
								cRODSTAR.RSIncludeSB = If((-If((Me.chkRSIncludeSB.Checked > False), 1S, 0S)), 1S, 0S)
								cRODSTAR.RSFGIncludeSteel = If((-If((Me.chkRSFGIncludeSteel.Checked > False), 1S, 0S)), 1S, 0S)
								Me.cboRSGrade.Enabled = (cRODSTAR.RSFGIncludeSteel <> 0S)
								Me.cboRSMaxSize.Enabled = ((cRODSTAR.RSFGIncludeSteel And If((-If((Me.cboRSGrade.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.RSGrade <> 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S)
								Me.cboRSMinSize.Enabled = ((cRODSTAR.RSFGIncludeSteel And If((-If((Me.cboRSGrade.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.RSGrade <> 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S)
								cRODSTAR.gbSteelRodString = False
								Me.chkRSIncludeSB.Enabled = (Me.cboRSFGGrade.SelectedIndex >= 0)
								Me.cboRSSBGrade.Enabled = (Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked))
								Me.cboRSSBDiameter.Enabled = (Me.cboRSSBGrade.Enabled And Me.cboRSSBGrade.SelectedIndex >= 0)
								Me.txtRSSBLength.Enabled = ((cRODSTAR.RSFGIncludeSteel And cRODSTAR.RSIncludeSB And If((-If((Me.cboRSSBDiameter.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S)) <> 0S)
								Me.txtRSSBLengthEnabledChanged()
								Me.cboRSMinSizeEnabledChanged()
								Me.cboRSMaxSizeEnabledChanged()
								Me.chkDesignSinkerbarsCheckedChanged(False)
								If Me.cboRSFGGrade.SelectedIndex > -1 Then
									Dim rst2 As cRODSTAR = RSWIN_DESC.rst
									Dim cboRSFGGrade As ComboBox = Me.cboRSFGGrade
									Dim num9 As Short = CShort(RODUTIL.ConvertListIndexToRodGrade(cboRSFGGrade, Me.cboRSFGGrade.SelectedIndex))
									Me.cboRSFGGrade = cboRSFGGrade
									rst2.RSFGGrade = num9
								End If
							ElseIf cRODSTAR.giRodDesignStyle = 0S Then
								If Me.cboRSGrade.SelectedIndex = -1 Or Me.cboRSMaxSize.SelectedIndex = -1 Or Me.cboRSMinSize.SelectedIndex = -1 Then
									flag2 = False
								End If
								If Not RSWIN_DESC.bExpert Then
									If Me.chkRSIncludeSB.Checked And (Me.cboRSSBGrade.SelectedIndex = -1 Or (Operators.CompareString(Me.txtRSSBLength.Text, "", False) = 0 And Me.txtRSSBLength.Enabled)) Then
										flag2 = False
										If(Not bQuiet AndAlso bFormLoaded) And Not Me.bLoadingCombo And (Operators.CompareString(Me.txtRSSBLength.Text, "", False) = 0 And Me.txtRSSBLength.Enabled) Then
											Me.DisplayRSInputError("Please enter Sinker bar/Sinker Rod length. ", flag)
										End If
									End If
								ElseIf(Not RSWIN_DESC.rst.gbDesignSinkerbar And Not Me.chkDesignSinkerbars.Checked) AndAlso (Me.chkRSIncludeSB.Checked And (Me.cboRSSBGrade.SelectedIndex = -1 Or (Operators.CompareString(Me.txtRSSBLength.Text, "", False) = 0 And Me.txtRSSBLength.Enabled))) Then
									flag2 = False
									If(Not bQuiet AndAlso bFormLoaded) And Not Me.bLoadingCombo And (Operators.CompareString(Me.txtRSSBLength.Text, "", False) = 0 And Me.txtRSSBLength.Enabled) Then
										Me.DisplayRSInputError("Please enter Sinker bar/Sinker Rod length. ", flag)
									End If
								End If
								Me.cboRSMaxSize.Enabled = (Me.cboRSGrade.SelectedIndex >= 0 And RSWIN_DESC.rst.RSGrade <> 0S)
								Me.cboRSMinSize.Enabled = (Me.cboRSGrade.SelectedIndex >= 0 And RSWIN_DESC.rst.RSGrade <> 0S)
								cRODSTAR.gbSteelRodString = True
								Me.chkRSIncludeSB.Enabled = (Me.cboRSGrade.SelectedIndex >= 0)
								Me.cboRSSBGrade.Enabled = (Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked))
								Me.cboRSSBDiameter.Enabled = (Me.cboRSSBGrade.Enabled And Me.cboRSSBGrade.SelectedIndex >= 0)
								Me.txtRSSBLength.Enabled = ((cRODSTAR.RSIncludeSB And If((-If((Me.cboRSSBDiameter.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S)) <> 0S)
								Me.txtRSSBLengthEnabledChanged()
							End If
							If Not flag2 Then
								CtrlUI.ToolbarButtonSetState(16, 0)
								If Me.bRunSet Then
									Me.MyParentFrm.ToolbarButtonSetState2(0, False)
								End If
							End If
						End If
						cRODSTAR = Nothing
						Me.m_bValidated = True
						If(RSWIN_DESC.NewData(4) And If((-If((flag2 > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							RSWIN_DESC.NewData(4) = 0S
							ini.SaveDataValue("RSInput", True)
						End If
						If flag2 Then
							CtrlUI.ToolbarButtonSetState(16, -1)
							If Me.bRunSet Then
								Me.MyParentFrm.ToolbarButtonSetState2(0, True)
							End If
						End If
						result = flag2
					Else
						result = True
					End If
				Else
					result = True
				End If
			Catch ex11 As Exception
			End Try
			Return result
		End Function

		Public Function ValidateRSInput_Old(Optional bQuiet As Boolean = True) As Boolean
			Dim flag As Boolean = False
			Dim result As Boolean
			Try
				If Me.MyParentFrm Is Nothing Then
					Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
				End If
				If Me.MyParentFrm IsNot Nothing Then
					If Not Me.MyParentFrm.bClosing Then
						Dim flag2 As Boolean = True
						If RSWIN_DESC.rst.ServiceFactor = 0F Then
							If Not bQuiet Then
								Me.DisplayRSInputError("Please enter a value for service factor", flag)
								If Not flag Then
									Dim txtServiceFactor As Control = Me.txtServiceFactor
									Me.SetActiveControl(txtServiceFactor)
									Me.txtServiceFactor = CType(txtServiceFactor, TextBox)
									flag2 = False
								End If
							Else
								flag2 = False
							End If
						Else
							Dim rst As cRODSTAR = RSWIN_DESC.rst
							Dim obj As Object = rst.ServiceFactor
							Dim lowerBound As Single = 0.5F
							Dim inclusive As Integer = -1
							Dim errnum As Integer = 61
							Dim useMetric As Integer = 0
							Dim canadianIsMetric As Integer = 0
							Dim text As String = ""
							Dim obj2 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text)
							rst.ServiceFactor = Conversions.ToSingle(obj)
							If Conversions.ToBoolean(Operators.NotObject(obj2)) Then
								If Not bQuiet Then
									Dim txtServiceFactor As Control = Me.txtServiceFactor
									Me.SetActiveControl(txtServiceFactor)
									Me.txtServiceFactor = CType(txtServiceFactor, TextBox)
								End If
								flag2 = False
							Else
								rst = RSWIN_DESC.rst
								obj = rst.ServiceFactor
								Dim upperBound As Single = 1F
								Dim inclusive2 As Integer = -1
								Dim errnum2 As Integer = 61
								Dim useMetric2 As Integer = 0
								Dim canadianIsMetric2 As Integer = 0
								text = ""
								Dim obj3 As Object = Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet, text)
								rst.ServiceFactor = Conversions.ToSingle(obj)
								If Conversions.ToBoolean(Operators.NotObject(obj3)) Then
									If Not bQuiet Then
										Dim txtServiceFactor As Control = Me.txtServiceFactor
										Me.SetActiveControl(txtServiceFactor)
										Me.txtServiceFactor = CType(txtServiceFactor, TextBox)
									End If
									flag2 = False
								End If
							End If
						End If
						If Me.miDesignStyle = 3 Then
							Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
							cRODSTAR.NumRods = CShort(Me.mdsRodTapers.Tables(0).Rows.Count)
							Try
								For Each obj4 As Object In Me.mdsRodTapers.Tables(0).Rows
									Dim dataRow As DataRow = CType(obj4, DataRow)
									Dim num As Integer = Conversions.ToInteger(dataRow("RodNum"))
									Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
									Dim num2 As Integer = num
									Try
										sections(num2).Grade = Conversions.ToShort(dataRow("RodGrade"))
										Try
											sections(num2).RodType = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(sections(num2).Grade, StdInfoConstants.RodGradeConstants)).Name
											sections(num2).TensileStrength = Conversions.ToSingle(RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(sections(num2).Grade, StdInfoConstants.RodGradeConstants)).TensileStrength)
										Catch ex As Exception
										End Try
										Dim num3 As Single = Conversions.ToSingle(Convert.ToString(RuntimeHelpers.GetObjectValue(dataRow("RodDiam"))))
										If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
											CtrlUI.ConvertValue(num3, "m", True)
										End If
										sections(num2).Diameter = num3
										sections(num2).Area = CSng((CDbl((sections(num2).Diameter * sections(num2).Diameter)) * Math.Atan(1.0)))
										If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("RodLength"))) And Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(dataRow("RodLength"))) Then
											num3 = Conversions.ToSingle(dataRow("RodLength"))
											If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
												CtrlUI.ConvertValue(num3, "f", True)
											End If
											sections(num2).length = num3
											Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("RodLength", dataRow("RodNum")))
											ini.SaveDataValue(text2.Trim(), num3)
										End If
										Try
											sections(num2).friction_coef = Conversions.ToSingle(dataRow("RodFrictionCoef"))
										Catch ex2 As Exception
										End Try
										If RSWIN_DESC.bRodStarD Then
											If Me.bShowGuides Then
												Try
													sections(num2).Guide = Conversions.ToShort(dataRow("RodGuide"))
												Catch ex3 As Exception
												End Try
											End If
											If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
												Try
													sections(num2).NumGuides = Conversions.ToShort(dataRow("NumGuides"))
												Catch ex4 As Exception
												End Try
											End If
										End If
									Catch ex5 As Exception
									End Try
									If sections(num2).Grade = 16393S Then
										sections(num2).RodDensity = 125F
									ElseIf RODUTIL.IsFG(sections(num2).Grade) Then
										sections(num2).RodDensity = 130F
									ElseIf sections(num2).Grade = 20481S Then
										sections(num2).RodDensity = 100F
									Else
										sections(num2).RodDensity = 491F
									End If
									Dim flag3 As Boolean = True
									If flag3 = (sections(num2).Grade = 16385S) Then
										GoTo IL_52A
									End If
									If flag3 = (sections(num2).Grade = 16389S) Then
										GoTo IL_52A
									End If
									If flag3 = (sections(num2).Grade = 16390S) Then
										GoTo IL_52A
									End If
									If flag3 = RODUTIL.IsCorod(sections(num2).Grade) Then
										sections(num2).SuckerRodLength = 1F
									Else
										sections(num2).SuckerRodLength = 25F
									End If
									IL_57E:
									RODUTIL.LookupElasticity(RSWIN_DESC.rst.Sections(num))
									RODUTIL.LookupRodWeight(RSWIN_DESC.rst.Sections(num))
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(num))
									Continue For
									IL_52A:
									sections(num2).SuckerRodLength = 37.5F
									GoTo IL_57E
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
							cRODSTAR = Nothing
						End If
						Me.m_bValidated = True
						If(RSWIN_DESC.NewData(4) And If((-If((flag2 > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							RSWIN_DESC.NewData(4) = 0S
							ini.SaveDataValue("RSInput", True)
						End If
						result = flag2
					Else
						result = True
					End If
				Else
					result = True
				End If
			Catch ex6 As Exception
			End Try
			Return result
		End Function

		Private Sub cboRodSize_Validating(eventSender As Object, eventArgs As CancelEventArgs)
			Dim cancel As Boolean = eventArgs.Cancel
			Dim cboRodSize As ComboBox = Me.cboRodSize
			If Strings.Len(cboRodSize.Text) > 0 Then
				Try
					If cboRodSize.SelectedValue Is Nothing And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(cboRodSize.SelectedValue)) And cboRodSize.SelectedValue IsNot DBNull.Value Then
						MessageBox.Show("Please select rod diameter from drop down instead of entering value.")
					Else
						Me.ulgTapers.ActiveCell.Row.Cells("RodSize").Value = RuntimeHelpers.GetObjectValue(cboRodSize.SelectedValue)
					End If
				Catch ex As Exception
				End Try
			End If
		End Sub

		Private Sub cboRodGrade_MouseHover(sender As Object, e As EventArgs)
		End Sub

		Private Sub cboRodGrade_Validating(eventSender As Object, eventArgs As CancelEventArgs)
			Try
				Dim cancel As Boolean = eventArgs.Cancel
				Dim cboRodGrade As ComboBox = Me.cboRodGrade
				Dim flag As Boolean = True
				Dim text As String = cboRodGrade.Text
				If Operators.CompareString(text, RSWIN_DESC.s_Steel, False) <> 0 Then
					If Operators.CompareString(text, RSWIN_DESC.s_SinkerBars, False) <> 0 Then
						If Operators.CompareString(text, RSWIN_DESC.s_Corod, False) <> 0 Then
							If Operators.CompareString(text, RSWIN_DESC.s_Fiberglass, False) <> 0 Then
								If Operators.CompareString(text, RSWIN_DESC.s_RibbonRod, False) <> 0 Then
									If Operators.CompareString(text, RSWIN_DESC.s_Prorod, False) <> 0 Then
										GoTo IL_89
									End If
								End If
							End If
						End If
					End If
				End If
				flag = False
				cboRodGrade.SelectedIndex = -1
				IL_89:
				If Strings.Len(cboRodGrade.Text) > 0 AndAlso flag Then
					If cboRodGrade.SelectedValue Is Nothing And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(cboRodGrade.SelectedValue)) And cboRodGrade.SelectedValue IsNot DBNull.Value Then
						MessageBox.Show("Please select rod grade from drop down instead of entering value.")
					Else
						Me.ulgTapers.ActiveCell.Row.Cells("RodGrade").Value = RuntimeHelpers.GetObjectValue(cboRodGrade.SelectedValue)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboRSGrade_Click_1(iListIndex As Short, Clicked As Boolean)
			Dim obj As Object = 0
			Dim num As Integer = -1
			Dim num2 As Integer = -1
			Dim num3 As Integer = -1
			Try
				Try
					Me.ResetClock()
					If RSWIN_DESC.rst.RSMaxSize > 0F Then
						Dim rsmaxSize As Single = RSWIN_DESC.rst.RSMaxSize
						If Me.cboRSMaxSize.Items.Count > 0 Then
							num = Me.cboRSMaxSize.SelectedIndex
						ElseIf RSWIN_DESC.rst.RSGrade > 0S Then
							Me.LoadRSMaxSize()
						End If
					Else
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMaxSize", 4, False, DBNull.Value))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							RSWIN_DESC.rst.RSMaxSize = Conversions.ToSingle(objectValue)
							Dim rsmaxSize As Single = RSWIN_DESC.rst.RSMaxSize
							Me.mbMaxMinNotYetSet = False
						End If
					End If
					If RSWIN_DESC.rst.RSMinSize > 0F Then
						Dim num4 As Single = RSWIN_DESC.rst.RSMinSize
						If Me.cboRSMinSize.Items.Count > 0 Then
							num2 = Me.cboRSMinSize.SelectedIndex
						ElseIf RSWIN_DESC.rst.RSGrade > 0S Then
							Me.LoadRSMinSize()
						End If
					Else
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMinSize", 4, False, 0.75))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							RSWIN_DESC.rst.RSMinSize = Conversions.ToSingle(objectValue)
							Dim num4 As Single = Conversions.ToSingle(objectValue)
						End If
					End If
					If RSWIN_DESC.bRodStarD Then
						If RSWIN_DESC.rst.RSSRSize > 0F Then
							obj = RSWIN_DESC.rst.RSSRSize
							If Me.cboRSSRSize.Items.Count > 0 Then
								num3 = Me.cboRSSRSize.SelectedIndex
							End If
						Else
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSRSize", 4, False, RSWIN_DESC.rst.RSMinSize))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
								RSWIN_DESC.rst.RSSRSize = Conversions.ToSingle(objectValue)
							End If
						End If
					End If
				Catch ex As Exception
				End Try
				If Me.cboRSGrade.SelectedIndex <> CInt(iListIndex) Then
					' The following expression was wrapped in a checked-expression
					If CInt(iListIndex) > Me.cboRSGrade.Items.Count - 1 Then
						Return
					End If
					Me.cboRSGrade.SelectedIndex = CInt(iListIndex)
				End If
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				If iListIndex >= 0S Then
					If Clicked Then
						If Me.cboRSGrade.SelectedIndex <> CInt(iListIndex) Then
							Me.cboRSGrade.SelectedIndex = CInt(iListIndex)
						End If
						cRODSTAR.RSGrade = Conversions.ToShort(NewLateBinding.LateGet(Me.cboRSGrade.Items(CInt(iListIndex)), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
						cRODSTAR.RSRodType = Convert.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboRSGrade.Items(CInt(iListIndex)), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
						ini.SaveDataValue("RSGrade", cRODSTAR.RSGrade)
						ini.SaveDataValue("RSRodType", cRODSTAR.RSRodType)
					End If
					If cRODSTAR.RSGrade > 0S Then
						Dim rsgrade As Short = cRODSTAR.RSGrade
						Dim cRODSTAR2 As cRODSTAR = cRODSTAR
						Dim rsrodType As String = cRODSTAR2.RSRodType
						Me.LoadDiameterList(Me.myRSMaxDiamAL, Me.myRSMaxDiamRodSizeArray, rsgrade, rsrodType, True)
						cRODSTAR2.RSRodType = rsrodType
						Dim rsgrade2 As Short = cRODSTAR.RSGrade
						cRODSTAR2 = cRODSTAR
						rsrodType = cRODSTAR2.RSRodType
						Me.LoadDiameterList(Me.myRSMinDiamAL, Me.myRSMinDiamRodSizeArray, rsgrade2, rsrodType, True)
						cRODSTAR2.RSRodType = rsrodType
						If RSWIN_DESC.bRodStarD Then
							Dim rsgrade3 As Short = cRODSTAR.RSGrade
							cRODSTAR2 = cRODSTAR
							rsrodType = cRODSTAR2.RSRodType
							Me.LoadDiameterList(Me.myRSSRDiamAL, Me.myRSSRDiamRodSizeArray, rsgrade3, rsrodType, True)
							cRODSTAR2.RSRodType = rsrodType
						End If
						Me.bLoadingCombo = True
						Dim arrayList As ArrayList
						Try
							Dim comparer As RSInput.rsaComparer = New RSInput.rsaComparer()
							Array.Sort(Me.myRSMaxDiamRodSizeArray, comparer)
							arrayList = New ArrayList()
							arrayList.Clear()
							Dim num5 As Short = 0S
							Dim num6 As Short = CShort((Me.myRSMaxDiamRodSizeArray.Length - 1))
							For num7 As Short = num5 To num6
								If Me.myRSMaxDiamRodSizeArray(CInt(num7)).rsaRodSizeID <> 0 And Me.myRSMaxDiamRodSizeArray(CInt(num7)).rsaDisplayName <> Nothing Then
									arrayList.Add(New cRodSize(Me.myRSMaxDiamRodSizeArray(CInt(num7)).rsaRodSizeID, Me.myRSMaxDiamRodSizeArray(CInt(num7)).rsaDisplayName))
								End If
							Next
						Catch ex2 As Exception
						End Try
						Dim arrayList2 As ArrayList
						Try
							Dim comparer2 As RSInput.rsaComparer = New RSInput.rsaComparer()
							Array.Sort(Me.myRSMinDiamRodSizeArray, comparer2)
							arrayList2 = New ArrayList()
							arrayList2.Clear()
							Dim num8 As Short = 0S
							Dim num9 As Short = CShort((Me.myRSMinDiamRodSizeArray.Length - 1))
							For num7 As Short = num8 To num9
								If Me.myRSMinDiamRodSizeArray(CInt(num7)).rsaRodSizeID <> 0 And Me.myRSMinDiamRodSizeArray(CInt(num7)).rsaDisplayName <> Nothing Then
									arrayList2.Add(New cRodSize(Me.myRSMinDiamRodSizeArray(CInt(num7)).rsaRodSizeID, Me.myRSMinDiamRodSizeArray(CInt(num7)).rsaDisplayName))
								End If
							Next
						Catch ex3 As Exception
						End Try
						Dim arrayList3 As ArrayList
						If RSWIN_DESC.bRodStarD Then
							Try
								Dim comparer3 As RSInput.rsaComparer = New RSInput.rsaComparer()
								Array.Sort(Me.myRSSRDiamRodSizeArray, comparer3)
								arrayList3 = New ArrayList()
								arrayList3.Clear()
								Dim num10 As Short = 0S
								Dim num11 As Short = CShort((Me.myRSSRDiamRodSizeArray.Length - 1))
								For num7 As Short = num10 To num11
									If Me.myRSSRDiamRodSizeArray(CInt(num7)).rsaRodSizeID <> 0 And Me.myRSSRDiamRodSizeArray(CInt(num7)).rsaDisplayName <> Nothing Then
										arrayList3.Add(New cRodSize(Me.myRSSRDiamRodSizeArray(CInt(num7)).rsaRodSizeID, Me.myRSSRDiamRodSizeArray(CInt(num7)).rsaDisplayName))
									End If
								Next
							Catch ex4 As Exception
							End Try
						End If
						Me.myRSMaxDiamAL = arrayList
						Me.cboRSMaxSize.DataSource = Nothing
						Me.cboRSMaxSize.DataSource = Me.myRSMaxDiamAL
						Me.cboRSMaxSize.DisplayMember = "DisplayName"
						Me.cboRSMaxSize.ValueMember = "RodSizeID"
						Me.myRSMinDiamAL = arrayList2
						Me.cboRSMinSize.DataSource = Nothing
						Me.cboRSMinSize.DataSource = Me.myRSMinDiamAL
						Me.cboRSMinSize.DisplayMember = "DisplayName"
						Me.cboRSMinSize.ValueMember = "RodSizeID"
						If RSWIN_DESC.bRodStarD Then
							Me.myRSSRDiamAL = arrayList3
							Me.cboRSSRSize.DataSource = Nothing
							Me.cboRSSRSize.DataSource = Me.myRSSRDiamAL
							Me.cboRSSRSize.DisplayMember = "DisplayName"
							Me.cboRSSRSize.ValueMember = "RodSizeID"
						End If
						Me.bLoadingCombo = False
						If Me.$STATIC$cboRSGrade_Click_1$202162$iOldRodGrade > 0S And cRODSTAR.RSGrade <> Me.$STATIC$cboRSGrade_Click_1$202162$iOldRodGrade Then
							If num = -1 Then
								Me.cboRSMaxSize.SelectedIndex = -1
							End If
							If num2 = -1 Then
								Me.cboRSMinSize.SelectedIndex = -1
							End If
							If RSWIN_DESC.bRodStarD AndAlso num3 = -1 Then
								Me.cboRSSRSize.SelectedIndex = -1
							End If
						End If
						Try
							Me.cboRSMaxSize.Visible = True
							Me.cboRSMaxSize.Enabled = True
						Catch ex5 As Exception
						End Try
						If Clicked Then
							If Me.mbMaxMinNotYetSet Then
								cRODSTAR.RSMaxSize = 1F
								Dim quiet As Object = True
								Dim grade As Object = cRODSTAR.RSGrade
								Dim diameter As Object = cRODSTAR.RSMaxSize
								Dim flag As Boolean
								Dim obj2 As Object = flag
								Dim obj3 As Object = False
								Dim obj4 As Object = Nothing
								Dim flag2 As Boolean
								Dim obj5 As Object = flag2
								RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj2, obj3, obj4, obj5, 0)
								flag2 = Conversions.ToBoolean(obj5)
								flag = Conversions.ToBoolean(obj2)
								If Not flag Then
									cRODSTAR.RSMaxSize = 0.875F
									Dim quiet2 As Object = True
									Dim grade2 As Object = cRODSTAR.RSGrade
									Dim diameter2 As Object = cRODSTAR.RSMaxSize
									obj5 = flag
									obj4 = False
									obj3 = Nothing
									obj2 = flag2
									RODUTIL.CheckRodsInTubing(quiet2, grade2, diameter2, obj5, obj4, obj3, obj2, 0)
									flag2 = Conversions.ToBoolean(obj2)
									flag = Conversions.ToBoolean(obj5)
									If Not flag Then
										cRODSTAR.RSMaxSize = 0.75F
									End If
								End If
								cRODSTAR.RSMinSize = 0.75F
								Me.mbMaxMinNotYetSet = False
							End If
							If cRODSTAR.RSMaxSize > 0F Then
								Me.LoadMax()
								ini.SaveDataValue("RSMaxSize", cRODSTAR.RSMaxSize)
							End If
							If cRODSTAR.RSMinSize > 0F Then
								Me.LoadMin()
								ini.SaveDataValue("RSMinSize", cRODSTAR.RSMinSize)
							End If
							If RSWIN_DESC.bRodStarD AndAlso (Me.chkRSIncludeSB.Checked And Me.optSinkerBars.Checked And Me.cboRSSRSize.SelectedIndex <> -1) AndAlso cRODSTAR.RSSRSize > 0F Then
								ini.SaveDataValue("RSSRSize", cRODSTAR.RSSRSize)
							End If
						End If
						Me.$STATIC$cboRSGrade_Click_1$202162$iOldRodGrade = cRODSTAR.RSGrade
					End If
				End If
				cRODSTAR = Nothing
			Catch ex6 As Exception
				MessageBox.Show("Error in cboRSGrade_Click: " + ex6.Message)
			End Try
		End Sub

		Private Sub cboRSMaxSize_Click_1(iListIndex As Short, Clicked As Boolean)
			Try
				If iListIndex < -1S Then
					iListIndex = -1S
				End If
				If Me.cboRSMaxSize.SelectedIndex <> CInt(iListIndex) Then
					' The following expression was wrapped in a checked-expression
					If CInt(iListIndex) > Me.cboRSMaxSize.Items.Count - 1 Then
						Return
					End If
					Me.cboRSMaxSize.SelectedIndex = CInt(iListIndex)
				End If
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				If iListIndex >= 0S Then
					If Clicked Then
						Me.cboRSMaxSize.SelectedIndex = CInt(iListIndex)
						cRODSTAR.RSMaxSize = RODUTIL.CvtStrDiamToSngl(Conversions.ToString(NewLateBinding.LateGet(Me.cboRSMaxSize.Items(CInt(iListIndex)), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
						ini.SaveDataValue("RSMaxSize", cRODSTAR.RSMaxSize)
					End If
					Try
						Me.cboRSMinSize.Visible = True
						Me.cboRSMinSize.Enabled = True
					Catch ex As Exception
					End Try
					If Clicked AndAlso cRODSTAR.RSMinSize > 0F Then
						Me.LoadMin()
						If Me.ActiveControl Is Me.cboRSMaxSize Then
							RODUTIL.CheckRodAvailability(False, cRODSTAR.RSGrade, False, cRODSTAR.RSMaxSize)
							Dim quiet As Object = False
							Dim grade As Object = cRODSTAR.RSGrade
							Dim diameter As Object = cRODSTAR.RSMaxSize
							Dim flag As Boolean
							Dim obj As Object = flag
							Dim flag2 As Boolean
							Dim obj2 As Object = flag2
							Dim obj3 As Object = Nothing
							Dim flag3 As Boolean
							Dim obj4 As Object = flag3
							RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj, obj2, obj3, obj4, 0)
							flag3 = Conversions.ToBoolean(obj4)
							flag2 = Conversions.ToBoolean(obj2)
							flag = Conversions.ToBoolean(obj)
							If flag2 AndAlso flag3 Then
								Me.bCheckRodsInTubingMsgShown = True
							End If
						Else
							RODUTIL.CheckRodAvailability(True, cRODSTAR.RSGrade, False, cRODSTAR.RSMaxSize)
							Dim quiet2 As Object = True
							Dim grade2 As Object = cRODSTAR.RSGrade
							Dim diameter2 As Object = cRODSTAR.RSMaxSize
							Dim flag As Boolean
							Dim obj4 As Object = flag
							Dim flag2 As Boolean
							Dim obj3 As Object = flag2
							Dim obj2 As Object = Nothing
							Dim flag3 As Boolean
							Dim obj As Object = flag3
							RODUTIL.CheckRodsInTubing(quiet2, grade2, diameter2, obj4, obj3, obj2, obj, 0)
							flag3 = Conversions.ToBoolean(obj)
							flag2 = Conversions.ToBoolean(obj3)
							flag = Conversions.ToBoolean(obj4)
						End If
					End If
				End If
				cRODSTAR = Nothing
			Catch ex2 As Exception
				MessageBox.Show("Error in cboRSMaxSize_Click: " + ex2.Message)
			End Try
		End Sub

		Private Sub cboRSSRSize_Click_1(iListIndex As Short, Clicked As Boolean)
			Try
				If iListIndex < -1S Then
					iListIndex = -1S
				End If
				If Me.cboRSSRSize.SelectedIndex <> CInt(iListIndex) Then
					' The following expression was wrapped in a checked-expression
					If CInt(iListIndex) > Me.cboRSSRSize.Items.Count - 1 Then
						Return
					End If
					Me.cboRSSRSize.SelectedIndex = CInt(iListIndex)
				End If
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				If iListIndex >= 0S Then
					If Clicked Then
						Me.cboRSSRSize.SelectedIndex = CInt(iListIndex)
						cRODSTAR.RSSRSize = RODUTIL.CvtStrDiamToSngl(Conversions.ToString(NewLateBinding.LateGet(Me.cboRSSRSize.Items(CInt(iListIndex)), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
						ini.SaveDataValue("RSSRSize", cRODSTAR.RSSRSize)
					End If
					Try
						Me.cboRSMinSize.Visible = True
						Me.cboRSMinSize.Enabled = True
					Catch ex As Exception
					End Try
					If Clicked AndAlso cRODSTAR.RSMinSize > 0F Then
						Me.LoadMin()
						If Me.ActiveControl Is Me.cboRSSRSize Then
							RODUTIL.CheckRodAvailability(False, cRODSTAR.RSGrade, False, cRODSTAR.RSSRSize)
							Dim quiet As Object = False
							Dim grade As Object = cRODSTAR.RSGrade
							Dim diameter As Object = cRODSTAR.RSSRSize
							Dim flag As Boolean
							Dim obj As Object = flag
							Dim flag2 As Boolean
							Dim obj2 As Object = flag2
							Dim obj3 As Object = Nothing
							Dim flag3 As Boolean
							Dim obj4 As Object = flag3
							RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj, obj2, obj3, obj4, 0)
							flag3 = Conversions.ToBoolean(obj4)
							flag2 = Conversions.ToBoolean(obj2)
							flag = Conversions.ToBoolean(obj)
							If flag2 AndAlso flag3 Then
								Me.bCheckRodsInTubingMsgShown = True
							End If
						Else
							RODUTIL.CheckRodAvailability(True, cRODSTAR.RSGrade, False, cRODSTAR.RSSRSize)
							Dim quiet2 As Object = True
							Dim grade2 As Object = cRODSTAR.RSGrade
							Dim diameter2 As Object = cRODSTAR.RSSRSize
							Dim flag As Boolean
							Dim obj4 As Object = flag
							Dim flag2 As Boolean
							Dim obj3 As Object = flag2
							Dim obj2 As Object = Nothing
							Dim flag3 As Boolean
							Dim obj As Object = flag3
							RODUTIL.CheckRodsInTubing(quiet2, grade2, diameter2, obj4, obj3, obj2, obj, 0)
							flag3 = Conversions.ToBoolean(obj)
							flag2 = Conversions.ToBoolean(obj3)
							flag = Conversions.ToBoolean(obj4)
						End If
					End If
				End If
				cRODSTAR = Nothing
			Catch ex2 As Exception
				MessageBox.Show("Error in cboRSSRSize_Click: " + ex2.Message)
			End Try
		End Sub

		Private Function cboRSMinSize_Click_1(iListIndex As Short, Clicked As Boolean) As Boolean
			Dim result As Boolean
			Try
				If Me.cboRSMinSize.SelectedIndex <> CInt(iListIndex) And Not Clicked Then
					' The following expression was wrapped in a checked-expression
					If CInt(iListIndex) > Me.cboRSMinSize.Items.Count - 1 Then
						Return False
					End If
					Try
						Me.cboRSMinSize.SelectedIndex = CInt(iListIndex)
					Catch ex As Exception
						Return False
					End Try
				End If
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If iListIndex >= 0S AndAlso Clicked Then
					If Me.cboRSMinSize.SelectedIndex <> CInt(iListIndex) Then
						Me.cboRSMinSize.SelectedIndex = CInt(iListIndex)
					End If
					rst.RSMinSize = RODUTIL.CvtStrDiamToSngl(Conversions.ToString(NewLateBinding.LateGet(Me.cboRSMinSize.Items(CInt(iListIndex)), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
					If Me.ActiveControl Is Me.cboRSMinSize Then
						RODUTIL.CheckRodAvailability(False, rst.RSGrade, False, rst.RSMinSize)
					Else
						RODUTIL.CheckRodAvailability(True, rst.RSGrade, False, rst.RSMinSize)
					End If
					ini.SaveDataValue("RSMinSize", rst.RSMinSize)
				End If
				result = True
			Catch ex2 As Exception
				MessageBox.Show("Error in cboRSMinSize_Click: " + ex2.Message)
				result = False
			End Try
			Return result
		End Function

		Private Sub cboRSSBDiameter_Click_1(iListIndex As Short, Clicked As Boolean, Optional bNew As Boolean = False)
			Try
				If Me.cboRSSBDiameter.SelectedIndex <> CInt(iListIndex) Then
					' The following expression was wrapped in a checked-expression
					If CInt(iListIndex) > Me.cboRSSBDiameter.Items.Count - 1 Then
						Return
					End If
					Try
						Me.cboRSSBDiameter.SelectedIndex = CInt(iListIndex)
					Catch ex As Exception
					End Try
					If Not Me.bLoadingCombo And Me.bFormLoaded And Me.cboRSSBDiameter IsNot Me.ActiveControl And (Me.optSinkerRods.Checked Or Me.optSinkerBars.Checked) And (Me.cboRSSBDiameter.SelectedIndex = 0 And RSWIN_DESC.rst.RSSBDiameter = 0F) Then
						iListIndex = 0S
					End If
				End If
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				If iListIndex < 0S Then
					Me.txtRSSBDiameter.Enabled = False
					Me.lblRSSBDiameter_Disabled.BringToFront()
				Else
					Try
						If Me.cboRSSBDiameter.SelectedIndex <> CInt(iListIndex) Then
							Me.cboRSSBDiameter.SelectedIndex = CInt(iListIndex)
						End If
					Catch ex2 As Exception
					End Try
					Dim num As Single = RODUTIL.CvtStrDiamToSngl(Conversions.ToString(NewLateBinding.LateGet(Me.cboRSSBDiameter.Items(CInt(iListIndex)), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
					If num = 0F Then
						Me.txtRSSBDiameter.Tag = "mem"
						Me.txtRSSBDiameter.Text = Convert.ToString(cRODSTAR.SinkerBar.Diameter)
						Me.txtRSSBDiameter.Enabled = True
						Me.lblRSSBDiameter_Disabled.SendToBack()
					Else
						Dim sinkerBar As RSWIN_DESC.RodSection = cRODSTAR.SinkerBar
						If Clicked Then
							sinkerBar.Diameter = num
							ini.SaveDataValue("RSSBDiameter", sinkerBar.Diameter)
							RODUTIL.CheckRodAvailability(False, sinkerBar.Grade, True, sinkerBar.Diameter)
							Dim quiet As Object = False
							Dim grade As Object = sinkerBar.Grade
							Dim diameter As Object = sinkerBar.Diameter
							Dim flag As Boolean
							Dim obj As Object = flag
							Dim flag2 As Boolean
							Dim obj2 As Object = flag2
							Dim obj3 As Object = Nothing
							Dim flag3 As Boolean
							Dim obj4 As Object = flag3
							RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj, obj2, obj3, obj4, 0)
							flag3 = Conversions.ToBoolean(obj4)
							flag2 = Conversions.ToBoolean(obj2)
							flag = Conversions.ToBoolean(obj)
							If flag2 AndAlso flag3 Then
								Me.bCheckRodsInTubingMsgShown = True
							End If
						End If
						Me.txtRSSBDiameter.Enabled = False
						Me.lblRSSBDiameter_Disabled.BringToFront()
						sinkerBar.Area = CSng((Math.Pow(CDbl(sinkerBar.Diameter), 2.0) * 3.141592653589793 / 4.0))
						cRODSTAR.SinkerBar = sinkerBar
						If cRODSTAR.RodStringType = 3S Then
							Me.SetEnabledControls(cRODSTAR.giRodDesignStyle = 1S, bNew)
							If Me.txtRSSBLength.Enabled AndAlso (Operators.CompareString(Me.txtRSSBLength.Text.Trim(), "", False) = 0 And RSWIN_DESC.SETUP_MeasurementSystem = 2) Then
								If RSWIN_DESC.SETUP_DisplaySBinFeet <> 0S Then
									Me.txtRSSBLength.Tag = "fee"
								Else
									Me.txtRSSBLength.Tag = "fem"
								End If
								If(If((-If((cRODSTAR.SinkerBar.length > 0F > False), 1S, 0S)), 1S, 0S) And cRODSTAR.RSIncludeSB) <> 0S Then
									Me.txtRSSBLength.Text = Conversions.ToString(cRODSTAR.SinkerBar.length)
								Else
									Dim txtRSSBLength As TextBox = Me.txtRSSBLength
									Dim lblRSSBLength As Label = Me.lblRSSBLength
									Me.TextBox_Change(txtRSSBLength, lblRSSBLength)
									Me.lblRSSBLength = lblRSSBLength
									Me.txtRSSBLength = txtRSSBLength
								End If
							End If
						End If
					End If
				End If
				cRODSTAR = Nothing
				Try
					If Operators.CompareString(Me.cboRSSBDiameter.Text, "Other", False) = 0 Then
						Me.txtRSSBDiameter.Enabled = True
						Me.lblRSSBDiameter_Disabled.SendToBack()
						Me.txtRSSBDiameter.BringToFront()
					End If
				Catch ex3 As Exception
				End Try
			Catch ex4 As Exception
				MessageBox.Show("Error in cboRSSBDiameter_Click: " + ex4.Message)
			End Try
		End Sub

		Private Sub cboRSSBGrade_Click_1(iListIndex As Short, Clicked As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				If Me.cboRSSBGrade.SelectedIndex <> CInt(iListIndex) Then
					If CInt(iListIndex) > Me.cboRSSBGrade.Items.Count - 1 Then
						Return
					End If
					Me.cboRSSBGrade.SelectedIndex = CInt(iListIndex)
				End If
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				If Me.cboRSSBGrade.SelectedIndex >= 0 Then
					Dim sinkerBar As RSWIN_DESC.RodSection = cRODSTAR.SinkerBar
					If Clicked Then
						Dim cboRSSBGrade As ComboBox = Me.cboRSSBGrade
						Dim num As Short = CShort(RODUTIL.ConvertListIndexToRodGrade(cboRSSBGrade, Me.cboRSSBGrade.SelectedIndex))
						Me.cboRSSBGrade = cboRSSBGrade
						sinkerBar.Grade = num
						sinkerBar.RodType = Convert.ToString(RuntimeHelpers.GetObjectValue(Me.cboRSSBGrade.Items(Me.cboRSSBGrade.SelectedIndex))).Trim()
						ini.SaveDataValue("RSSBGrade", sinkerBar.Grade)
						ini.SaveDataValue("RSSBRodType", sinkerBar.RodType)
					End If
					If sinkerBar.Diameter = 0F AndAlso Me.optSinkerRods.Checked Then
						sinkerBar.Diameter = 1F
					End If
					cRODSTAR.SinkerBar = sinkerBar
					If Not Clicked Then
						Dim cboRSSBGrade As ComboBox = Me.cboRSSBGrade
						Dim num2 As Short = CShort(RODUTIL.ConvertListIndexToRodGrade(cboRSSBGrade, Me.cboRSSBGrade.SelectedIndex))
						Me.cboRSSBGrade = cboRSSBGrade
						sinkerBar.Grade = num2
						sinkerBar.RodType = Convert.ToString(RuntimeHelpers.GetObjectValue(Me.cboRSSBGrade.Items(Me.cboRSSBGrade.SelectedIndex))).Trim()
					End If
					Dim rssbdiameter As Single = cRODSTAR.RSSBDiameter
					Dim arrayList As ArrayList
					If sinkerBar.Grade > 0S Then
						Me.LoadDiameterList(Me.myRSSBDiamAL, Me.myRSSBDiamRodSizeArray, sinkerBar.Grade, sinkerBar.RodType, False)
						Try
							Try
								Dim comparer As RSInput.rsaComparer = New RSInput.rsaComparer()
								Array.Sort(Me.myRSSBDiamRodSizeArray, comparer)
								arrayList = New ArrayList()
								arrayList.Clear()
								Dim num3 As Integer = 0
								Dim num4 As Integer = Me.myRSSBDiamRodSizeArray.Length - 1
								For i As Integer = num3 To num4
									If Me.myRSSBDiamRodSizeArray(i).rsaRodSizeID <> 0 And Me.myRSSBDiamRodSizeArray(i).rsaDisplayName <> Nothing Then
										Debug.WriteLine(Conversions.ToString(Me.myRSSBDiamRodSizeArray(i).rsaRodSizeID) + " , " + Me.myRSSBDiamRodSizeArray(i).rsaDisplayName)
										arrayList.Add(New cRodSize(Me.myRSSBDiamRodSizeArray(i).rsaRodSizeID, Me.myRSSBDiamRodSizeArray(i).rsaDisplayName))
									End If
								Next
								arrayList.Add(New cRodSize(0, "Other"))
								GoTo IL_2B2
							Catch ex As Exception
								GoTo IL_2B2
							End Try
						Catch ex2 As Exception
							GoTo IL_2B2
						End Try
					End If
					arrayList = New ArrayList()
					arrayList.Clear()
					IL_2B2:
					Me.myRSSBDiamAL = arrayList
					If Me.myRSSBDiamAL IsNot Nothing AndAlso Me.myRSSBDiamAL.Count > 0 Then
						Me.bLoadingCombo = True
						Try
							Me.cboRSSBDiameter.SelectedItem = Nothing
						Catch ex3 As Exception
						End Try
						Try
							Me.cboRSSBDiameter.Items.Clear()
						Catch ex4 As Exception
						End Try
						Try
							Me.cboRSSBDiameter.DataSource = Nothing
						Catch ex5 As Exception
						End Try
						Me.cboRSSBDiameter.DataSource = Me.myRSSBDiamAL
						Me.cboRSSBDiameter.DisplayMember = "DisplayName"
						Me.cboRSSBDiameter.ValueMember = "RodSizeID"
						Me.LoadSBDiameter(cRODSTAR.SinkerBar.Grade)
						Me.bLoadingCombo = False
					End If
					Try
						Me.cboRSSBDiameter.Visible = True
					Catch ex6 As Exception
					End Try
				End If
				cRODSTAR = Nothing
			Catch ex7 As Exception
				MessageBox.Show("Error in cboRSSBGrade_Click: " + ex7.Message)
			End Try
		End Sub

		Private Sub CheckDisabledItems(X As Integer, Y As Integer)
		End Sub

		Private Sub chkRSFGIncludeSteel_Click_1(Checked As Boolean, Clicked As Boolean, Optional bExtraCheck As Boolean = False)
			Try
				If Me.chkRSFGIncludeSteel.Checked <> Checked Then
					Me.chkRSFGIncludeSteel.Checked = Checked
				End If
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				cRODSTAR.RSFGIncludeSteel = If((-If((Checked > False), 1S, 0S)), 1S, 0S)
				If Clicked Then
					ini.SaveDataValue("RSFGIncludeSteel", Checked)
					If Not Checked Then
						Me.chkRSIncludeSB_Click_1(True, False)
					End If
				End If
				Me.cboRSGrade.Enabled = (cRODSTAR.RSFGIncludeSteel <> 0S)
				Me.cboRSMaxSize.Enabled = ((cRODSTAR.RSFGIncludeSteel And If((-If((Me.cboRSGrade.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.RSGrade <> 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S)
				Me.cboRSMinSize.Enabled = ((cRODSTAR.RSFGIncludeSteel And If((-If((Me.cboRSGrade.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.RSGrade <> 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S)
				Me.chkRSIncludeSB.Enabled = (Me.cboRSFGGrade.SelectedIndex >= 0)
				Me.cboRSSBGrade.Enabled = (Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked))
				Me.cboRSSBDiameter.Enabled = (Me.cboRSSBGrade.Enabled And Me.cboRSSBGrade.SelectedIndex >= 0)
				Me.txtRSSBLength.Enabled = ((cRODSTAR.RSFGIncludeSteel And cRODSTAR.RSIncludeSB And If((-If((Me.cboRSSBDiameter.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S)) <> 0S)
				Me.cboRSSBGradeEnabledChanged()
				Me.cboRSMinSizeEnabledChanged()
				Me.cboRSMaxSizeEnabledChanged()
				If bExtraCheck Then
					Try
						If Me.cboRSMaxSize.Enabled AndAlso (Me.cboRSMaxSize.SelectedIndex = -1 And RSWIN_DESC.rst.RSGrade > 0S And RSWIN_DESC.rst.RSMaxSize > 0F) Then
							Me.LoadMax()
						End If
					Catch ex As Exception
					End Try
					Try
						If Me.cboRSMinSize.Enabled AndAlso (Me.cboRSMinSize.SelectedIndex = -1 And RSWIN_DESC.rst.RSGrade > 0S And RSWIN_DESC.rst.RSMinSize > 0F) Then
							Me.LoadMin()
						End If
					Catch ex2 As Exception
					End Try
				End If
				If cRODSTAR.RodStringType = 3S And cRODSTAR.giRodDesignStyle = 1S Then
					Me.chkRSIncludeSB.Enabled = (Me.cboRSFGGrade.SelectedIndex >= 0)
				End If
				cRODSTAR = Nothing
			Catch ex3 As Exception
				MessageBox.Show("Error in chkRSIncludeSteel_Click: " + ex3.Message)
			End Try
		End Sub

		Private Sub chkRSIncludeSB_Click_1(Checked As Boolean, Clicked As Boolean)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Me.chkRSIncludeSB.Checked <> Checked Then
					Me.chkRSIncludeSB.Checked = Checked
				End If
				rst.RSIncludeSB = If((-If((Checked > False), 1S, 0S)), 1S, 0S)
				If Clicked Then
					ini.SaveDataValue("RSIncludeSB", rst.RSIncludeSB)
					If Not Checked Then
						Me.chkRSFGIncludeSteel_Click_1(True, False, False)
					End If
				End If
				Me.optSinkerBars.Enabled = Me.chkRSIncludeSB.Checked
				Me.optSinkerRods.Enabled = Me.chkRSIncludeSB.Checked
				Me.cboRSSBGrade.Enabled = (rst.RSIncludeSB <> 0S)
				Me.cboRSSBDiameter.Enabled = ((rst.RSIncludeSB And If((-If((Me.cboRSSBGrade.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S)) <> 0S)
				Me.txtRSSBLength.Enabled = ((rst.RSIncludeSB And (rst.RSFGIncludeSteel Or If((-If(((Me.miDesignStyle = 0) > False), 1S, 0S)), 1S, 0S))) <> 0S)
				Me.txtRSSBLengthEnabledChanged()
			Catch ex As Exception
				MessageBox.Show("Error in chkRSIncludeDB_Click: " + ex.Message)
			End Try
		End Sub

		Public Sub CreateDataSet()
			Me.mdsRodTapers = New DataSet("RodStrings")
			Dim dataTable As DataTable = New DataTable("RodDesign")
			Dim dataColumn As DataColumn = New DataColumn("RodNum", GetType(Integer))
			dataColumn.Unique = False
			dataColumn.AllowDBNull = True
			dataTable.Columns.Add(dataColumn)
			Dim dataColumn2 As DataColumn = New DataColumn("RodGrade", GetType(Integer))
			dataColumn2.AllowDBNull = True
			dataTable.Columns.Add(dataColumn2)
			Dim dataColumn3 As DataColumn = New DataColumn("RodSize", GetType(Integer))
			dataColumn3.AllowDBNull = True
			dataTable.Columns.Add(dataColumn3)
			Dim dataColumn4 As DataColumn = New DataColumn("RodDiam", GetType(String))
			dataColumn4.AllowDBNull = True
			dataTable.Columns.Add(dataColumn4)
			Dim dataColumn5 As DataColumn = New DataColumn("RodLength", GetType(Single))
			dataColumn5.AllowDBNull = True
			dataTable.Columns.Add(dataColumn5)
			If RSWIN_DESC.bRodStarD Then
				If Me.bShowGuides Then
					Dim dataColumn6 As DataColumn = New DataColumn("RodGuide", GetType(Short))
					dataColumn6.AllowDBNull = True
					dataTable.Columns.Add(dataColumn6)
				End If
				If RSWIN_DESC.SETUP_ALLOWSLIDEFRIC <> 0S Then
					Dim dataColumn7 As DataColumn = New DataColumn("RodFrictionCoef", GetType(Single))
					dataColumn7.AllowDBNull = True
					dataTable.Columns.Add(dataColumn7)
				End If
				If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
					Dim dataColumn8 As DataColumn = New DataColumn("NumGuides", GetType(Short))
					dataColumn8.AllowDBNull = True
					dataTable.Columns.Add(dataColumn8)
				End If
			End If
			Me.mdsRodTapers.Tables.Add(dataTable)
		End Sub

		Public Function FindCustomRodGrade(sRodType As String) As Integer
			Dim flag As Boolean = False
			Dim result As Integer
			For Each valueListItem As ValueListItem In Me.vlrg.ValueListItems
				Me.vli = valueListItem
				If Operators.CompareString(Me.vli.DisplayText.Trim(), sRodType.Trim(), False) = 0 Then
					flag = True
					result = Conversions.ToInteger(Me.vli.DataValue)
					Exit For
				End If
			Next
			If flag Then
				Return result
			End If
			Return -1
		End Function

		Private Sub CreateValueLists()
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Dim array As Integer() = New Integer(6) {}
			Dim array2 As Integer() = New Integer(6) {}
			Dim text As String = New String(" "c, 8192)
			Try
				If Not Me.ulgTapers.DisplayLayout.ValueLists.Exists("VLRodGrades") Then
					If RSWIN_DESC.bRodStarD Then
						Dim text2 As String = "OtherGuide"
						Dim text3 As String = "Other"
						Dim length As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, text, True))
						RSWIN_DESC.sOtherGuided = text.Substring(0, CInt(length))
					End If
					Dim valueLists As ValueListsCollection = Me.ulgTapers.DisplayLayout.ValueLists
					Me.vlrg = valueLists.Add("VLRodGrades")
					Me.vlrs = valueLists.Add("VLRodSizes")
					Me.vlrt = valueLists.Add("VLRodTypes")
					If Me.bShowGuides Then
						Me.vlswg = valueLists.Add("VLSWGuides")
					End If
					Dim valueListItems As ValueListItemsCollection = Me.vlrt.ValueListItems
					array(0) = 1
					array(1) = 2
					If RSWIN_DESC.bUseLatestGradeChanges Then
						array(2) = 6
						array(3) = 3
					Else
						array(2) = 3
						array(3) = 6
					End If
					array(4) = 4
					array(5) = 5
					array(6) = 0
					array2(0) = 0
					array2(1) = 99
					array2(2) = 199
					array2(3) = 299
					array2(4) = 399
					array2(5) = 499
					array2(6) = 0
					valueListItems.Add(array(0), RSWIN_DESC.s_Steel)
					valueListItems.Add(array(1), RSWIN_DESC.s_SinkerBars)
					If RSWIN_DESC.bUseLatestGradeChanges Then
						valueListItems.Add(array(2), RSWIN_DESC.s_Prorod)
						valueListItems.Add(array(3), RSWIN_DESC.s_Corod)
					Else
						valueListItems.Add(array(2), RSWIN_DESC.s_Corod)
						valueListItems.Add(array(3), RSWIN_DESC.s_Prorod)
					End If
					valueListItems.Add(array(4), RSWIN_DESC.s_Fiberglass)
					Me.myRodTypeAL.Clear()
					Me.myRodTypeAL.Add(New cRodType(array(0), RSWIN_DESC.s_Steel))
					Me.myRodTypeAL.Add(New cRodType(array(1), RSWIN_DESC.s_SinkerBars))
					If RSWIN_DESC.bUseLatestGradeChanges Then
						Me.myRodTypeAL.Add(New cRodType(array(2), RSWIN_DESC.s_Prorod))
						Me.myRodTypeAL.Add(New cRodType(array(3), RSWIN_DESC.s_Corod))
					Else
						Me.myRodTypeAL.Add(New cRodType(array(2), RSWIN_DESC.s_Corod))
						Me.myRodTypeAL.Add(New cRodType(array(3), RSWIN_DESC.s_Prorod))
					End If
					Me.myRodTypeAL.Add(New cRodType(array(4), RSWIN_DESC.s_Fiberglass))
					Dim num4 As Integer = -1
					Me.myRodTypeGradeAL.Clear()
					Dim valueListItemsCollection As ValueListItemsCollection = Me.vlrg.ValueListItems
					Dim dictionaryEntry As DictionaryEntry
					For Each valueListItem As ValueListItem In Me.vlrt.ValueListItems
						Me.vli = valueListItem
						Dim flag As Boolean = True
						Dim num5 As Integer = Conversions.ToInteger(Me.vli.DataValue)
						Dim displayText As String = Me.vli.DisplayText
						valueListItemsCollection.Add(num5, displayText)
						If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.vli.DataValue, 0, False))) Then
							num4 += 1
							Me.AddToArrayList(True, Me.myRodTypeGradeAL, num5, displayText, array2(num4), "", "")
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.RodTypeConstant(Conversions.ToInteger(Me.vli.DataValue)))
							Dim teRodGradeList As teRodGradeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().RodGradeLists().Item(RuntimeHelpers.GetObjectValue(Me.RodTypeConstant(Conversions.ToInteger(Me.vli.DataValue))))
							Try
								For Each obj As Object In teRodGradeList
									Dim teRodGrade As teRodGrade = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodGrade)
									If Not(LikeOperator.LikeString(teRodGrade.Name, "(Custom *)", CompareMethod.Binary) Or LikeOperator.LikeString(teRodGrade.Name, "(Unknown *)", CompareMethod.Binary)) Then
										Dim i As Integer = CInt(teRodGrade.RodGradeID)
										If flag Then
											Dim displayText2 As String = Me.vli.DisplayText
											Dim num6 As Integer = displayText2.Length
											Dim text4 As String = displayText2
											If Operators.CompareString(text4, "Steel", False) = 0 Then
												num6 -= 1
											ElseIf Operators.CompareString(text4, "Sinker bars", False) = 0 Then
												num6 += 3
											ElseIf Operators.CompareString(text4, "Fiberglass", False) = 0 Then
												num6 += 2
											End If
											If Operators.CompareString(displayText2, teRodGrade.Name, False) = 0 Then
												valueListItemsCollection.Add(i, teRodGrade.Name)
												Me.AddToArrayList(False, Me.myRodTypeGradeAL, i, teRodGrade.Name, Conversions.ToInteger(teRodGrade.DisplayOrder), teRodGrade.AbbrName, teRodGrade.XMLstring)
											Else
												valueListItemsCollection.Add(i, teRodGrade.Name)
												Me.AddToArrayList(False, Me.myRodTypeGradeAL, i, teRodGrade.Name, Conversions.ToInteger(teRodGrade.DisplayOrder), teRodGrade.AbbrName, teRodGrade.XMLstring)
											End If
											flag = False
										Else
											Dim num6 As Integer
											Dim text5 As String = New String(" "c, num6)
											valueListItemsCollection.Add(i, teRodGrade.Name)
											Me.AddToArrayList(False, Me.myRodTypeGradeAL, i, teRodGrade.Name, Conversions.ToInteger(teRodGrade.DisplayOrder), teRodGrade.AbbrName, teRodGrade.XMLstring)
										End If
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
						End If
						Try
							Dim num7 As Integer = 1
							Dim num8 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
							For i As Integer = num7 To num8
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a unchecked-expression
								If(If(-If(((num5 = 4) > False), 1S, 0S), 1S, 0S) And Not RSWIN_DESC.CustomRodGradeList(i).Steel) <> 0S Then
									num += 1
									valueListItemsCollection.Add(16397 + num, RSWIN_DESC.CustomRodGradeList(i).RodType)
									Me.AddToArrayList(True, Me.myRodTypeGradeAL, 16397 + num, RSWIN_DESC.CustomRodGradeList(i).RodType, Me.iFiberglassOrder + num, "", "")
								ElseIf(If(-If(((Operators.CompareString(displayText, RSWIN_DESC.s_Steel, False) = 0 And (num5 = 0 Or num5 = 1)) > False), 1S, 0S), 1S, 0S) And RSWIN_DESC.CustomRodGradeList(i).Steel And Not RSWIN_DESC.CustomRodGradeList(i).SinkerBar) <> 0S Then
									num2 += 1
									valueListItemsCollection.Add(4143 + num2, RSWIN_DESC.CustomRodGradeList(i).RodType)
									Me.AddToArrayList(True, Me.myRodTypeGradeAL, 4143 + num2, RSWIN_DESC.CustomRodGradeList(i).RodType, Me.iSteelOrder + num2, "", "")
								ElseIf(RSWIN_DESC.CustomRodGradeList(i).Steel And If(-If(((num5 = 1 Or num5 = 0 Or num5 = 2) > False), 1S, 0S), 1S, 0S)) <> 0S Then
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a unchecked-expression
									If If((-If(((Operators.CompareString(displayText, RSWIN_DESC.s_SinkerBars, False) <> 0) > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.CustomRodGradeList(i).SinkerBar And If((-If(((num5 = 1 Or num5 = 0) > False), 1S, 0S)), 1S, 0S) <> 0S Then
										num2 += 1
										valueListItemsCollection.Add(4143 + num2, RSWIN_DESC.CustomRodGradeList(i).RodType)
										Me.AddToArrayList(True, Me.myRodTypeGradeAL, 4143 + num2, RSWIN_DESC.CustomRodGradeList(i).RodType, Me.iSteelOrder + num2, "", "")
									ElseIf If((-If(((Operators.CompareString(displayText, RSWIN_DESC.s_SinkerBars, False) = 0) > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.CustomRodGradeList(i).SinkerBar And If((-If(((num5 = 2) > False), 1S, 0S)), 1S, 0S) <> 0S Then
										num3 += 1
										valueListItemsCollection.Add(8311 + num3, RSWIN_DESC.CustomRodGradeList(i).RodType)
										Me.AddToArrayList(True, Me.myRodTypeGradeAL, 8311 + num3, RSWIN_DESC.CustomRodGradeList(i).RodType, Me.iSinkberbarOrder + num3, "", "")
									End If
								End If
							Next
						Catch ex As Exception
						End Try
					Next
					valueListItemsCollection.Add(-1, " ")
					valueListItemsCollection.Add(0, " ")
					Dim comparer As RSInput.rgaComparer = New RSInput.rgaComparer()
					Me.myRodTypeGradeAL.Sort(comparer)
					Util.DebugRodGradeArrayList(Me.myRodTypeGradeAL)
					Me.bLoadingCombo = True
					Me.cboRodGrade.Items.Clear()
					Me.cboRodGrade.DataSource = Nothing
					Me.cboRodGrade.DataSource = Me.myRodTypeGradeAL
					Me.cboRodGrade.DisplayMember = "DisplayName"
					Me.cboRodGrade.ValueMember = "RodGradeID"
					Me.bLoadingCombo = False
					valueListItemsCollection = Nothing
					Dim flag2 As Boolean = False
					Dim flag3 As Boolean = False
					Dim valueListItemsCollection2 As ValueListItemsCollection = Me.vlrs.ValueListItems
					For Each valueListItem2 As ValueListItem In Me.vlrg.ValueListItems
						Me.vli = valueListItem2
						Dim flag4 As Boolean = True
						If Conversions.ToBoolean(Operators.AndObject(Operators.NotObject(Operators.CompareObjectEqual(Me.vli.DataValue, 0, False)), Operators.NotObject(Operators.CompareObjectEqual(Me.vli.DataValue, -1, False)))) Then
							Dim num9 As Integer = Conversions.ToInteger(Me.vli.DataValue)
							If CUSTOMRG.IsOtherSteel(num9) Or CUSTOMRG.IsOtherSinkerBar(num9) Then
								If Not flag2 Then
									num9 = 4096
									flag2 = True
								Else
									flag4 = False
								End If
							End If
							If CUSTOMRG.IsOtherFG(num9) Then
								If Not flag3 Then
									num9 = 16384
									flag3 = True
								Else
									flag4 = False
								End If
							End If
							If flag4 Then
								Try
									Dim teRodSizeList As teRodSizeList
									Try
										teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(num9, StdInfoConstants.RodGradeConstants)).RodSizeList
									Catch ex2 As Exception
										teRodSizeList = Nothing
									End Try
									If teRodSizeList IsNot Nothing Then
										Try
											For Each obj2 As Object In teRodSizeList
												Dim teRodSize As teRodSize = CType(If((obj2 IsNot Nothing), CType(obj2, DictionaryEntry), dictionaryEntry).Value, teRodSize)
												If Me.vlrs.ValueListItems.Contains(teRodSize.RodSizeID) Then
													Exit For
												End If
												If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
													valueListItemsCollection2.Add(teRodSize.RodSizeID, teRodSize.DisplayName)
												Else
													Try
														valueListItemsCollection2.Add(teRodSize.RodSizeID, teRodSize.MetricDisplayName)
													Catch ex3 As Exception
													End Try
												End If
											Next
										Finally
											Dim enumerator4 As IEnumerator
											If TypeOf enumerator4 Is IDisposable Then
												TryCast(enumerator4, IDisposable).Dispose()
											End If
										End Try
									End If
								Catch ex4 As Exception
								End Try
							End If
						End If
					Next
					valueListItemsCollection2.Add(0, "Other")
					valueListItemsCollection2.Add(-1, "")
					valueListItemsCollection2 = Nothing
					If Me.bShowGuides Then
						Try
							Me.myRodGuideAL.Clear()
							Me.AddToGuideArrayList(True, Me.myRodGuideAL, 0, "Bare Rod (no rod guides)", 1, "", "")
							Me.AddToGuideArrayList(True, Me.myRodGuideAL, CInt(RSWIN_DESC.MOLDED), "Molded", 2, "", "")
							Me.AddToGuideArrayList(True, Me.myRodGuideAL, 2, "Wheeled", 3, "", "")
							Me.AddToGuideArrayList(True, Me.myRodGuideAL, 3, RSWIN_DESC.sOtherGuided, 4, "", "")
							Me.AddToGuideArrayList(True, Me.myRodGuideAL, 4, "Norris Standard", 5, "", "")
							Me.AddToGuideArrayList(True, Me.myRodGuideAL, CInt(RSWIN_DESC.NorrisSidewinderGuide), "Norris Sidewinder", 6, "", "")
							Me.AddToGuideArrayList(True, Me.myRodGuideAL, 6, "RGI Jake Coupling", 7, "", "")
							Me.AddToGuideArrayList(True, Me.myRodGuideAL, 7, "RGI SVT", 8, "", "")
							Me.AddToGuideArrayList(True, Me.myRodGuideAL, 8, "RGI Tomahawk", 9, "", "")
							Me.AddToGuideArrayList(True, Me.myRodGuideAL, 9, "RGI Tornado", 10, "", "")
							Me.AddToGuideArrayList(True, Me.myRodGuideAL, 10, "RGI Twister", 11, "", "")
							Me.AddToGuideArrayList(True, Me.myRodGuideAL, 11, "RGI WVT", 12, "", "")
							Dim valueListItems2 As ValueListItemsCollection = Me.vlswg.ValueListItems
							valueListItems2.Add(0, "Bare Rod (no rod guides)")
							valueListItems2.Add(RSWIN_DESC.MOLDED, "Molded")
							valueListItems2.Add(2, "Wheeled")
							valueListItems2.Add(3, RSWIN_DESC.sOtherGuided)
							valueListItems2.Add(4S, "Norris Standard")
							valueListItems2.Add(RSWIN_DESC.NorrisSidewinderGuide, "Norris Sidewinder")
							valueListItems2.Add(6S, "RGI Jake Coupling")
							valueListItems2.Add(7S, "RGI SVT")
							valueListItems2.Add(8S, "RGI Tomahawk")
							valueListItems2.Add(9S, "RGI Tornado")
							valueListItems2.Add(10S, "RGI Twister")
							valueListItems2.Add(11S, "RGI WVT")
							Me.cboRodGuides.Items.Clear()
							Me.cboRodGuides.DataSource = Nothing
							Me.cboRodGuides.DataSource = Me.myRodGuideAL
							Me.cboRodGuides.DisplayMember = "DisplayName"
							Me.cboRodGuides.ValueMember = "RodGuideID"
							Me.cboRSRodGuides.Items.Clear()
							Me.cboRSRodGuides.DataSource = Nothing
							Me.cboRSRodGuides.DataSource = Me.myRodGuideAL
							Me.cboRSRodGuides.DisplayMember = "DisplayName"
							Me.cboRSRodGuides.ValueMember = "RodGuideID"
						Catch ex5 As Exception
						End Try
					End If
				End If
			Catch ex6 As Exception
				Dim sMsg As String = "Error in Create Value Lists: " + ex6.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Function RodTypeConstant(iRodType As Integer) As Object
			If iRodType = 1 Then
				Return StdInfoConstants.RodMatlConstants.teRodMatlAPISteel
			End If
			If iRodType = 3 Then
				Return StdInfoConstants.RodMatlConstants.teRodMatlCorod
			End If
			If iRodType = 6 Then
				Return StdInfoConstants.RodMatlConstants.teRodMatlProrod
			End If
			If iRodType = 4 Then
				Return StdInfoConstants.RodMatlConstants.teRodMatlFG
			End If
			If iRodType = 5 Then
				Return StdInfoConstants.RodMatlConstants.teRodMatlRR
			End If
			If iRodType = 2 Then
				Return StdInfoConstants.RodMatlConstants.teRodMatlSinkerBar
			End If
			Return 0
		End Function

		Private Sub DoArrange(ParamArray Ctrs As Control())
			' The following expression was wrapped in a checked-statement
			Dim left As Integer = 3 * Me.tbsRodDesignType.Left + Me.tbsRodDesignType.Width
			Dim num As Integer = 0
			For Each control As Control In Ctrs
				control.Left = left
				control.Top = num
				num += control.Height
			Next
		End Sub

		Private Sub FinishRodString(bAdjustLast As Boolean)
			Dim num As Short = 0S
			Dim num2 As Short = 0S
			Dim num3 As Single = 0F
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num4 As Short = 1S
			Dim numRods As Short = rst.NumRods
			For num5 As Short = num4 To numRods
				If rst.Sections(CInt(num5)).length = 0F Then
					' The following expression was wrapped in a checked-statement
					num2 += 1S
					If num <> 0S Then
						num = 0S
						Exit For
					End If
					num = num5
				Else
					num3 += rst.Sections(CInt(num5)).length
				End If
			Next
			If num2 = 1S Then
				Dim num6 As Single = rst.PumpDepth - num3
				If num6 > 0F Then
					rst.Sections(CInt(num)).length = num6
					ini.SaveDataValue("RodLength" + num.ToString(), rst.Sections(CInt(num)).length)
				End If
			ElseIf(num2 = 0S AndAlso bAdjustLast) And rst.NumRods > 0S Then
				num3 -= rst.Sections(CInt(rst.NumRods)).length
				If 0F <= num3 And num3 < rst.PumpDepth Then
					rst.Sections(CInt(rst.NumRods)).length = rst.PumpDepth - num3
					ini.SaveDataValue("RodLength" + rst.NumRods.ToString(), rst.Sections(CInt(rst.NumRods)).length)
				End If
			End If
		End Sub

		Public Function ConvertRodMatlToValue(iRodGrade As Integer, sRodType As String) As Integer
			If RODUTIL.IsSinkerBar1(iRodGrade, sRodType) <> 0 Then
				Return 2
			End If
			If RODUTIL.IsProRod(iRodGrade) <> 0 Then
				Return 6
			End If
			If RODUTIL.IsCorod(iRodGrade) <> 0 Then
				Return 3
			End If
			If RODUTIL.IsFG(CShort(iRodGrade)) Then
				Return 4
			End If
			Return 1
		End Function

		Private Sub HideControl(ByRef Ctrl As Control)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Ctrl Is Nothing Then
					GoTo IL_17
				End If
				IL_0D:
				num2 = 3
				Ctrl.Visible = False
				IL_17:
				num2 = 5
				If Ctrl IsNot Me.txtLength Then
					GoTo IL_31
				End If
				IL_23:
				num2 = 6
				Ctrl.Text = ""
				IL_31:
				IL_33:
				GoTo IL_A6
				IL_35:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_67:
				GoTo IL_9B
				IL_69:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_79:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_69
			End Try
			IL_9B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_A6:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub InitRSInput()
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			If RSWIN_DESC.bRodStarD Then
				Try
					If Util.IsPolyLined(RSWIN_DESC.rst.TubingID) Then
						RSWIN_DESC.bReduceFricCoeff = Conversions.ToBoolean(ini.GetDataValue("ReduceFricCoeff", 11, False, False))
					End If
				Catch ex As Exception
				End Try
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodStringType", 2, False, DBNull.Value))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.RodStringType = 2S
				Else
					cRODSTAR.RodStringType = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
				End If
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodDesignStyle", 2, False, DBNull.Value))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.giRodDesignStyle = 0S
				Else
					cRODSTAR.giRodDesignStyle = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
				End If
			Else
				cRODSTAR.RodStringType = Conversions.ToShort(ini.GetDataValue("RodStringType", 2, False, 3))
				If cRODSTAR.RodStringType = 3S Then
					cRODSTAR.giRodDesignStyle = Conversions.ToShort(ini.GetDataValue("RodDesignStyle", 2, False, 0))
				End If
			End If
			If cRODSTAR.TubingOD <= 0F Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TubingOD", 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.TubingOD = Conversions.ToSingle(objectValue)
				End If
			End If
			Select Case cRODSTAR.RodStringType
				Case 1S
					Me.miDesignStyle = 4
				Case 2S
					Me.miDesignStyle = 3
				Case 3S
					Select Case cRODSTAR.giRodDesignStyle
						Case 0S
							Me.miDesignStyle = 0
						Case 1S
							Me.miDesignStyle = 1
					End Select
			End Select
			If Me.miDesignStyle = 3 Then
				Me.tbsRodDesignType.SelectedIndex = Me.miDesignStyle - 1
			Else
				Me.tbsRodDesignType.SelectedIndex = Me.miDesignStyle
			End If
			Me.tbsRodDesignType_Click_1(CShort(Me.miDesignStyle), False, True)
			If Me.miDesignStyle = 0 Then
				Me.InitRSInpRST()
			ElseIf Me.miDesignStyle = 1 Then
				Me.InitRSInpRFG()
			Else
				cRODSTAR.NumRods = Conversions.ToShort(ini.GetDataValue("NumRods", 2, False, 0))
				If cRODSTAR.NumRods = 0S Then
					Me.cmdAddSection.Enabled = True
				End If
				Dim num As Short = 1S
				Do
					cRODSTAR.Sections(CInt(num)).Initialize()
					cRODSTAR.Sections(CInt(num)).Grade = 0S
					cRODSTAR.Sections(CInt(num)).RodType = ""
					cRODSTAR.Sections(CInt(num)).Diameter = 0F
					cRODSTAR.Sections(CInt(num)).length = 0F
					num += 1S
				Loop While num <= 40S
				Dim num2 As Short = 1S
				Dim numRods As Short = cRODSTAR.NumRods
				Dim objectValue As Object
				num = num2
				While num <= numRods
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodGrade" + num.ToString(), 2, False, 4099))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						cRODSTAR.Sections(CInt(num)).Grade = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
						Dim grade As Integer = CInt(cRODSTAR.Sections(CInt(num)).Grade)
						Dim name As String
						Try
							name = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(cRODSTAR.Sections(CInt(num)).Grade, StdInfoConstants.RodGradeConstants)).Name
						Catch ex2 As Exception
						End Try
						cRODSTAR.Sections(CInt(num)).RodType = Conversions.ToString(ini.GetDataValue("RodType" + Conversions.ToString(CInt(num)), 8, False, name))
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodDiam" + num.ToString(), 4, False, 0.75))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							cRODSTAR.Sections(CInt(num)).Diameter = Conversions.ToSingle(objectValue)
						End If
						If cRODSTAR.NumRods = 1S Then
							objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodLength" + num.ToString(), 4, False, RSWIN_DESC.rst.PumpDepth))
						Else
							objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodLength" + num.ToString(), 4, False, 0))
						End If
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							cRODSTAR.Sections(CInt(num)).length = Conversions.ToSingle(objectValue)
						End If
						If Me.bShowGuides Then
							objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodGuide" + num.ToString(), 2, False, 4S))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
								Dim guide As Short = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
								cRODSTAR.Sections(CInt(num)).Guide = guide
							Else
								Dim text As String = "GuideToUse"
								Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
								Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
								RSWIN_DESC.MOLDED = CShort(molded)
								RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
								Dim guide As Short = CShort(RSWIN_DESC.SETUP_GuideToUse)
								cRODSTAR.Sections(CInt(num)).Guide = guide
							End If
						End If
						If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bRodStarD Then
							objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("NumGuides" + num.ToString(), 2, False, 0))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
								Dim numGuides As Short = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
								cRODSTAR.Sections(CInt(num)).NumGuides = numGuides
							Else
								Dim numGuides As Short = 0S
								cRODSTAR.Sections(CInt(num)).NumGuides = numGuides
							End If
						End If
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodFrictionCoef" + num.ToString(), 4, False, RSWIN_DESC.fDefaultFricCoeff))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							cRODSTAR.Sections(CInt(num)).friction_coef = Conversions.ToSingle(objectValue)
						Else
							cRODSTAR.Sections(CInt(num)).friction_coef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
						End If
						Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
						Dim num3 As Integer = CInt(num)
						If sections(num3).friction_coef = 0F Then
							If RSWIN_DESC.bRodStarD Then
								sections(num3).friction_coef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
							Else
								sections(num3).friction_coef = 0.2F
							End If
						End If
						If Me.bShowGuides Then
							If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bRodStarD Then
								Me.AddRodTaper(CInt(num), CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants), sections(num3).Diameter, sections(num3).length, sections(num3).friction_coef, sections(num3).Guide, sections(num3).NumGuides, False, 0, True)
							Else
								Me.AddRodTaper(CInt(num), CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants), sections(num3).Diameter, sections(num3).length, sections(num3).friction_coef, sections(num3).Guide, 0S, False, 0, True)
							End If
						ElseIf Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bRodStarD Then
							Me.AddRodTaper(CInt(num), CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants), sections(num3).Diameter, sections(num3).length, RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True), CShort(RSWIN_DESC.SETUP_GuideToUse), sections(num3).NumGuides, False, 0, True)
						Else
							Me.AddRodTaper(CInt(num), CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants), sections(num3).Diameter, sections(num3).length, sections(num3).friction_coef, 0S, 0S, False, 0, True)
						End If
					Else
						Dim sections2 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
						If Me.bShowGuides Then
							Dim text As String = "GuideToUse"
							Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
							Dim regProfileStringByInt2 As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
							RSWIN_DESC.MOLDED = CShort(molded)
							RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt2)
							Me.AddRodTaper(CInt(num), CType(0, StdInfoConstants.RodGradeConstants), -1F, -1F, RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True), CShort(RSWIN_DESC.SETUP_GuideToUse), 0S, False, 0, True)
						Else
							Me.AddRodTaper(CInt(num), CType(0, StdInfoConstants.RodGradeConstants), -1F, -1F, 0.2F, 0S, 0S, False, 0, True)
						End If
					End If
					num += 1S
				End While
				Dim ulgTapers As UltraGrid
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					ulgTapers = Me.ulgTapers
					CtrlUI.Grid_ToggleUnits(ulgTapers, -1S, -1S, "")
					Me.ulgTapers = ulgTapers
				End If
				ulgTapers = Me.ulgTapers
				CtrlUI.Grid_SetLabels(ulgTapers, True)
				Me.ulgTapers = ulgTapers
				cRODSTAR.ServiceFactor = Conversions.ToSingle(ini.GetDataValue("ServiceFactor", 4, True, 0.9))
				If cRODSTAR.ServiceFactor = 0F Then
					cRODSTAR.ServiceFactor = 0.9F
				End If
				Me.txtServiceFactor.Text = Convert.ToString(cRODSTAR.ServiceFactor)
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSExtraCost", 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.RSExtraCost = Conversions.ToSingle(objectValue)
					Me.txtRSExtraCost.Text = Convert.ToString(cRODSTAR.RSExtraCost)
				End If
				cRODSTAR.RSExtraCostLabel = Conversions.ToString(ini.GetDataValue("RSExtraCostLabel", 8, False, ""))
				Me.txtRSExtraCostLabel.Text = cRODSTAR.RSExtraCostLabel
			End If
			If RSWIN_DESC.rst.RodStringType = 3S Then
				Me.btnNumberOfRods.Enabled = False
				Me.cmdAddSection.Enabled = False
				Me.cmdDelSection.Enabled = False
				Me.cmdMoveSectionUp.Enabled = False
				Me.cmdMoveSectionDown.Enabled = False
				Me.btnNumberOfRods.Visible = False
				Me.cmdAddSection.Visible = False
				Me.cmdDelSection.Visible = False
				Me.cmdMoveSectionUp.Visible = False
				Me.cmdMoveSectionDown.Visible = False
				Me._Line_0.Visible = False
			ElseIf RSWIN_DESC.rst.RodStringType = 2S Then
				Me.btnNumberOfRods.Enabled = True
				Me.cmdAddSection.Enabled = True
				Me.cmdDelSection.Enabled = True
				Me.cmdMoveSectionUp.Enabled = True
				Me.cmdMoveSectionDown.Enabled = True
				Me.btnNumberOfRods.Visible = True
				Me.cmdAddSection.Visible = True
				Me.cmdDelSection.Visible = True
				Me.cmdMoveSectionUp.Visible = True
				Me.cmdMoveSectionDown.Visible = True
				Me._Line_0.Visible = True
			End If
			If cRODSTAR.RodStringType = 3S AndAlso (RSWIN_DESC.bExpert And Me.chkDesignSinkerbars.Visible) Then
				RSWIN_DESC.rst.gbDesignSinkerbar = Conversions.ToBoolean(ini.GetDataValue("gbDesignSinkerbar", 11, False, False))
				Me.chkDesignSinkerbars.Checked = RSWIN_DESC.rst.gbDesignSinkerbar
				Me.chkDesignSinkerbarsCheckedChanged(True)
			End If
			cRODSTAR = Nothing
		End Sub

		Public Sub InitRSInpRST()
			Dim flag As Boolean = False
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Dim sinkerBar As RSWIN_DESC.RodSection
				sinkerBar.Initialize()
				cRODSTAR.RSIncludeSB = Conversions.ToShort(ini.GetDataValue("RSIncludeSB", 11, False, False))
				Me.chkRSIncludeSB_Click_1(cRODSTAR.RSIncludeSB <> 0S, False)
				If Conversions.ToBoolean(ini.GetDataValue("SinkerRods", 11, False, False)) Then
					Me.optSinkerRods.Checked = True
					Me.optSinkerRods_Click_1(Me.optSinkerRods.Checked, False)
				Else
					Me.optSinkerBars.Checked = True
					Me.optSinkerBars_Click_1(Me.optSinkerBars.Checked, False)
				End If
				Me.mbMaxMinNotYetSet = Information.IsDBNull(RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 3, False, DBNull.Value)))
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 3, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.RSGrade = Conversions.ToShort(objectValue)
					cRODSTAR.RSRodType = Conversions.ToString(ini.GetDataValue("RSRodType", 8, False, ""))
					Dim comboBox As ComboBox = Me.cboRSGrade
					Dim iListIndex As Short = RODUTIL.FindRodGrade(comboBox, cRODSTAR.RSGrade, cRODSTAR.RSRodType)
					Me.cboRSGrade = comboBox
					Me.cboRSGrade_Click_1(iListIndex, False)
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMaxSize", 4, False, 1))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						cRODSTAR.RSMaxSize = Conversions.ToSingle(objectValue)
						Me.LoadMax()
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMinSize", 4, False, 0.75))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							cRODSTAR.RSMinSize = Conversions.ToSingle(objectValue)
							Me.LoadMin()
						End If
						If RSWIN_DESC.bRodStarD Then
							objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSRSize", 4, False, 0.75))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
								cRODSTAR.RSSRSize = Conversions.ToSingle(objectValue)
							End If
						End If
					End If
				Else
					Try
						Me.SetDefaultRSGRADE()
					Catch ex As Exception
					End Try
				End If
				cRODSTAR.RSIncludeSB = Conversions.ToShort(ini.GetDataValue("RSIncludeSB", 11, False, False))
				Me.chkRSIncludeSB_Click_1(cRODSTAR.RSIncludeSB <> 0S, False)
				If Not cRODSTAR.RSIncludeSB <> 0S Then
					Me.optSinkerBars.Checked = False
					Me.optSinkerRods.Checked = False
					Me.cboRSSBDiameter_Click_1(-1S, True, True)
					Dim textBox As TextBox = Me.txtRSSBDiameter
					Me.TextBox_Enable(textBox, False, False)
					Me.txtRSSBDiameter = textBox
					textBox = Me.txtRSSBLength
					Dim lblRSSBLength As Label = Me.lblRSSBLength
					Me.TextBox_Change(textBox, lblRSSBLength)
					Me.lblRSSBLength = lblRSSBLength
					Me.txtRSSBLength = textBox
					Me.txtRSSBLength.Text = ""
				Else
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBGrade", 3, False, DBNull.Value))
					If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						If Conversions.ToBoolean(ini.GetDataValue("SinkerRods", 11, False, False)) Then
							Me.optSinkerRods.Checked = True
						Else
							Me.optSinkerBars.Checked = True
						End If
					Else
						flag = True
						sinkerBar.Grade = Conversions.ToShort(objectValue)
						sinkerBar.RodType = Conversions.ToString(ini.GetDataValue("RSSBRodType", 8, False, ""))
						If RODUTIL.IsSinkerBar1(CInt(sinkerBar.Grade), sinkerBar.RodType) <> 0 Then
							Me.optSinkerBars.Checked = True
						Else
							Me.optSinkerRods.Checked = True
						End If
						Dim comboBox As ComboBox = Me.cboRSSBGrade
						Dim iListIndex2 As Short = RODUTIL.FindRodGrade(comboBox, sinkerBar.Grade, sinkerBar.RodType)
						Me.cboRSSBGrade = comboBox
						Me.cboRSSBGrade_Click_1(iListIndex2, True)
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBDiameter", 4, False, 1.5))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							sinkerBar.Diameter = Conversions.ToSingle(objectValue)
							If sinkerBar.Grade > 0S Then
								Me.bLoadingCombo = True
								Me.LoadSBDiameter(sinkerBar.Grade)
								Me.bLoadingCombo = False
							End If
						End If
					End If
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBLength", 4, False, DBNull.Value))
					If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						Dim textBox As TextBox = Me.txtRSSBLength
						Dim lblRSSBLength As Label = Me.lblRSSBLength
						Me.TextBox_Change(textBox, lblRSSBLength)
						Me.lblRSSBLength = lblRSSBLength
						Me.txtRSSBLength = textBox
					Else
						flag = True
						sinkerBar.length = Conversions.ToSingle(objectValue)
						If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
							If RSWIN_DESC.SETUP_DisplaySBinFeet <> 0S Then
								Me.txtRSSBLength.Tag = "fee"
							Else
								Me.txtRSSBLength.Tag = "fem"
							End If
						ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							Me.txtRSSBLength.Tag = "fee"
						Else
							Me.txtRSSBLength.Tag = "fem"
						End If
						Me.txtRSSBLength.Text = Conversions.ToString(sinkerBar.length)
					End If
				End If
				If flag Then
					cRODSTAR.SinkerBar = sinkerBar
				End If
				cRODSTAR.ServiceFactor = Conversions.ToSingle(ini.GetDataValue("ServiceFactor", 4, True, 0.9))
				If cRODSTAR.ServiceFactor = 0F Then
					cRODSTAR.ServiceFactor = 0.9F
				End If
				cRODSTAR.RSFricCoef = Conversions.ToSingle(ini.GetDataValue("RSFricCoef", 4, True, 0))
				Try
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSRodGuide", 2, False, 4S))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						Dim num As Short = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
						Me.cboRodGuides.SelectedValue = num
						If cRODSTAR.RSFricCoef = 0F Then
							cRODSTAR.RSFricCoef = RODUTIL.GetFricCoeff(CInt(num), True)
						End If
					Else
						Dim text As String = "GuideToUse"
						Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
						Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
						RSWIN_DESC.MOLDED = CShort(molded)
						RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
						Me.cboRodGuides.SelectedValue = RSWIN_DESC.SETUP_GuideToUse
						If cRODSTAR.RSFricCoef = 0F Then
							cRODSTAR.RSFricCoef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
						End If
					End If
					If cRODSTAR.RSFricCoef = 0F Then
						cRODSTAR.RSFricCoef = 0.2F
					End If
				Catch ex2 As Exception
				End Try
				Me.txtServiceFactor.Text = Conversions.ToString(cRODSTAR.ServiceFactor)
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSExtraCost", 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.RSExtraCost = Conversions.ToSingle(objectValue)
					Me.txtRSExtraCost.Text = Conversions.ToString(cRODSTAR.RSExtraCost)
				End If
				cRODSTAR.RSExtraCostLabel = Conversions.ToString(ini.GetDataValue("RSExtraCostLabel", 8, False, ""))
				Me.txtRSExtraCostLabel.Text = cRODSTAR.RSExtraCostLabel
				Me.mbMaxMinNotYetSet = Information.IsDBNull(RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 2, False, DBNull.Value)))
				If Not Me.chkRSIncludeSB.Checked Then
					Me.txtRSSBLength.BackColor = Color.White
				End If
				If cRODSTAR.RodStringType = 3S And cRODSTAR.giRodDesignStyle = 0S Then
					If Me.cboRSGrade.SelectedIndex = -1 Or Me.cboRSMaxSize.SelectedIndex = -1 Or Me.cboRSMinSize.SelectedIndex = -1 Then
						CtrlUI.ToolbarButtonSetState(16, 0)
					End If
					If Not RSWIN_DESC.bExpert Then
						If Me.chkRSIncludeSB.Checked And (Me.cboRSSBGrade.SelectedIndex = -1 Or Operators.CompareString(Me.txtRSSBLength.Text, "", False) = 0) Then
							CtrlUI.ToolbarButtonSetState(16, 0)
						End If
					ElseIf(Not RSWIN_DESC.rst.gbDesignSinkerbar And Not Me.chkDesignSinkerbars.Checked) AndAlso (Me.chkRSIncludeSB.Checked And (Me.cboRSSBGrade.SelectedIndex = -1 Or Operators.CompareString(Me.txtRSSBLength.Text, "", False) = 0)) Then
						CtrlUI.ToolbarButtonSetState(16, 0)
					End If
					Me.cboRSMaxSize.Enabled = ((cRODSTAR.RSFGIncludeSteel And If((-If((Me.cboRSGrade.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.RSGrade <> 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S)
					Me.cboRSMinSize.Enabled = ((cRODSTAR.RSFGIncludeSteel And If((-If((Me.cboRSGrade.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.RSGrade <> 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S)
					Me.cboRSSBGrade.Enabled = (Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked))
					Me.cboRSSBDiameter.Enabled = (Me.cboRSSBGrade.Enabled And Me.cboRSSBGrade.SelectedIndex >= 0)
					Me.txtRSSBLength.Enabled = ((cRODSTAR.RSFGIncludeSteel And cRODSTAR.RSIncludeSB And If((-If((Me.cboRSSBDiameter.Enabled > False), 1S, 0S)), 1S, 0S) And If((-If((Me.cboRSSBDiameter.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S)) <> 0S)
					Me.txtRSSBLengthEnabledChanged()
				End If
				cRODSTAR = Nothing
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub InitRSInpRFG()
			Dim flag As Boolean = False
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			Dim sinkerBar As RSWIN_DESC.RodSection
			sinkerBar.Initialize()
			Me.mbMaxMinNotYetSet = Information.IsDBNull(RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 3, False, DBNull.Value)))
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSFGGrade", 3, False, DBNull.Value))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				cRODSTAR.RSFGGrade = Conversions.ToShort(objectValue)
				Dim cboRSFGGrade As ComboBox = Me.cboRSFGGrade
				Dim comboBox As ComboBox = Me.cboRSFGGrade
				Dim selectedIndex As Integer = CInt(RODUTIL.FindRodGrade(comboBox, cRODSTAR.RSFGGrade, Nothing))
				Me.cboRSFGGrade = comboBox
				cboRSFGGrade.SelectedIndex = selectedIndex
			End If
			cRODSTAR.RSFGIncludeSteel = Conversions.ToShort(ini.GetDataValue("RSFGIncludeSteel", 11, False, True))
			Me.chkRSFGIncludeSteel_Click_1(cRODSTAR.RSFGIncludeSteel <> 0S, False, False)
			If cRODSTAR.RSFGIncludeSteel <> 0S Then
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 3, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.RSGrade = Conversions.ToShort(objectValue)
					cRODSTAR.RSRodType = Conversions.ToString(ini.GetDataValue("RSRodType", 8, False, ""))
					Dim comboBox As ComboBox = Me.cboRSGrade
					Dim iListIndex As Short = RODUTIL.FindRodGrade(comboBox, cRODSTAR.RSGrade, cRODSTAR.RSRodType)
					Me.cboRSGrade = comboBox
					Me.cboRSGrade_Click_1(iListIndex, False)
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMaxSize", 4, False, 1))
					If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						If cRODSTAR.RSMaxSize <> 0F Then
							ini.SaveDataValue("RSMaxSize", cRODSTAR.RSMaxSize)
						End If
					Else
						cRODSTAR.RSMaxSize = Conversions.ToSingle(objectValue)
						Me.LoadMax()
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMinSize", 4, False, 0.75))
						If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							If cRODSTAR.RSMinSize <> 0F Then
								ini.SaveDataValue("RSMinSize", cRODSTAR.RSMinSize)
							End If
						Else
							cRODSTAR.RSMinSize = Conversions.ToSingle(objectValue)
							Me.LoadMin()
						End If
						If RSWIN_DESC.bRodStarD Then
							objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSRSize", 4, False, cRODSTAR.RSMinSize))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
								cRODSTAR.RSSRSize = Conversions.ToSingle(objectValue)
							ElseIf cRODSTAR.RSSRSize <> 0F Then
								ini.SaveDataValue("RSSRSize", cRODSTAR.RSSRSize)
							End If
						End If
					End If
				End If
			End If
			objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSIncludeSB", 11, False, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				cRODSTAR.RSIncludeSB = Not cRODSTAR.RSFGIncludeSteel
			Else
				cRODSTAR.RSIncludeSB = Conversions.ToShort(objectValue)
				If(Not cRODSTAR.RSIncludeSB And Not cRODSTAR.RSFGIncludeSteel) <> 0S Then
					cRODSTAR.RSIncludeSB = -1S
				End If
			End If
			Me.chkRSIncludeSB_Click_1(cRODSTAR.RSIncludeSB <> 0S, False)
			Dim textBox As TextBox = Me.txtRSSBLength
			Dim lblRSSBLength As Label = Me.lblRSSBLength
			Me.TextBox_Change(textBox, lblRSSBLength)
			Me.lblRSSBLength = lblRSSBLength
			Me.txtRSSBLength = textBox
			Me.txtRSSBLength.Text = ""
			If Not cRODSTAR.RSIncludeSB <> 0S Then
				Me.optSinkerBars.Checked = True
				Me.cboRSSBDiameter_Click_1(-1S, True, True)
				textBox = Me.txtRSSBDiameter
				Me.TextBox_Enable(textBox, False, False)
				Me.txtRSSBDiameter = textBox
			Else
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBGrade", 3, False, DBNull.Value))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					If Conversions.ToBoolean(ini.GetDataValue("SinkerRods", 11, False, False)) Then
						Me.optSinkerRods.Checked = True
					Else
						Me.optSinkerBars.Checked = True
					End If
				Else
					flag = True
					sinkerBar.Grade = Conversions.ToShort(objectValue)
					sinkerBar.RodType = Conversions.ToString(ini.GetDataValue("RSSBRodType", 8, False, ""))
					If RODUTIL.IsSinkerBar1(CInt(sinkerBar.Grade), sinkerBar.RodType) <> 0 Then
						Me.optSinkerBars.Checked = True
					Else
						Me.optSinkerRods.Checked = True
					End If
					Dim comboBox As ComboBox = Me.cboRSSBGrade
					Dim iListIndex2 As Short = RODUTIL.FindRodGrade(comboBox, sinkerBar.Grade, sinkerBar.RodType)
					Me.cboRSSBGrade = comboBox
					Me.cboRSSBGrade_Click_1(iListIndex2, True)
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBDiameter", 4, False, 1.5))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						sinkerBar.Diameter = Conversions.ToSingle(objectValue)
						Me.bLoadingCombo = True
						Me.LoadSBDiameter(sinkerBar.Grade)
						Me.bLoadingCombo = False
					End If
				End If
				If cRODSTAR.RSFGIncludeSteel <> 0S Then
					Me.txtRSSBLength.Visible = True
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBLength", 4, False, DBNull.Value))
					If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						textBox = Me.txtRSSBLength
						lblRSSBLength = Me.lblRSSBLength
						Me.TextBox_Change(textBox, lblRSSBLength)
						Me.lblRSSBLength = lblRSSBLength
						Me.txtRSSBLength = textBox
					Else
						sinkerBar.length = Conversions.ToSingle(objectValue)
						If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
							If RSWIN_DESC.SETUP_DisplaySBinFeet <> 0S Then
								Me.txtRSSBLength.Tag = "fee"
							Else
								Me.txtRSSBLength.Tag = "fem"
							End If
						ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							Me.txtRSSBLength.Tag = "fee"
						Else
							Me.txtRSSBLength.Tag = "fem"
						End If
						Me.txtRSSBLength.Text = Conversions.ToString(sinkerBar.length)
					End If
				End If
			End If
			If flag Then
				cRODSTAR.SinkerBar = sinkerBar
			End If
			cRODSTAR.ServiceFactor = Conversions.ToSingle(ini.GetDataValue("ServiceFactor", 4, True, 0.9))
			If cRODSTAR.ServiceFactor = 0F Then
				cRODSTAR.ServiceFactor = 0.9F
			End If
			cRODSTAR.RSFricCoef = Conversions.ToSingle(ini.GetDataValue("RSFricCoef", 4, True, 0))
			Try
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSRodGuide", 2, False, 4S))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					Dim num As Short = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
					Me.cboRodGuides.SelectedValue = num
					If cRODSTAR.RSFricCoef = 0F Then
						cRODSTAR.RSFricCoef = RODUTIL.GetFricCoeff(CInt(num), True)
					End If
				Else
					Dim text As String = "GuideToUse"
					Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
					Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
					RSWIN_DESC.MOLDED = CShort(molded)
					RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
					Me.cboRodGuides.SelectedValue = RSWIN_DESC.SETUP_GuideToUse
					If cRODSTAR.RSFricCoef = 0F Then
						cRODSTAR.RSFricCoef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
					End If
				End If
				If cRODSTAR.RSFricCoef = 0F Then
					cRODSTAR.RSFricCoef = 0.2F
				End If
			Catch ex As Exception
			End Try
			Me.txtServiceFactor.Text = Conversions.ToString(cRODSTAR.ServiceFactor)
			objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSExtraCost", 4, False, DBNull.Value))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				cRODSTAR.RSExtraCost = Conversions.ToSingle(objectValue)
				Me.txtRSExtraCost.Text = Conversions.ToString(cRODSTAR.RSExtraCost)
			End If
			cRODSTAR.RSExtraCostLabel = Conversions.ToString(ini.GetDataValue("RSExtraCostLabel", 8, False, ""))
			Me.txtRSExtraCostLabel.Text = cRODSTAR.RSExtraCostLabel
			Me.mbMaxMinNotYetSet = Information.IsDBNull(RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 2, False, DBNull.Value)))
			If Not Me.chkRSIncludeSB.Checked Then
				Me.txtRSSBLength.BackColor = Color.White
			End If
			If cRODSTAR.RodStringType = 3S And cRODSTAR.giRodDesignStyle = 1S Then
				If Me.chkRSFGIncludeSteel.Checked And (Me.cboRSGrade.SelectedIndex = -1 Or Me.cboRSMaxSize.SelectedIndex = -1 Or Me.cboRSMinSize.SelectedIndex = -1) Then
					CtrlUI.ToolbarButtonSetState(16, 0)
				End If
				If Not RSWIN_DESC.bExpert Then
					If Me.chkRSIncludeSB.Checked And (Me.cboRSSBGrade.SelectedIndex = -1 Or Operators.CompareString(Me.txtRSSBLength.Text, "", False) = 0) Then
						CtrlUI.ToolbarButtonSetState(16, 0)
					End If
				ElseIf(Not RSWIN_DESC.rst.gbDesignSinkerbar And Not Me.chkDesignSinkerbars.Checked) AndAlso (Me.chkRSIncludeSB.Checked And (Me.cboRSSBGrade.SelectedIndex = -1 Or Operators.CompareString(Me.txtRSSBLength.Text, "", False) = 0)) Then
					CtrlUI.ToolbarButtonSetState(16, 0)
				End If
				Me.cboRSGrade.Enabled = (cRODSTAR.RSFGIncludeSteel <> 0S)
				Me.cboRSMaxSize.Enabled = ((cRODSTAR.RSFGIncludeSteel And If((-If((Me.cboRSGrade.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.RSGrade <> 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S)
				Me.cboRSMinSize.Enabled = ((cRODSTAR.RSFGIncludeSteel And If((-If((Me.cboRSGrade.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.RSGrade <> 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S)
				Me.cboRSSBGrade.Enabled = (Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked))
				Me.cboRSSBDiameter.Enabled = (Me.cboRSSBGrade.Enabled Or Me.cboRSSBGrade.SelectedIndex >= 0)
				Me.txtRSSBLength.Enabled = ((cRODSTAR.RSFGIncludeSteel And cRODSTAR.RSIncludeSB And If((-If((Me.cboRSSBDiameter.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S)) <> 0S)
				Me.txtRSSBLengthEnabledChanged()
			End If
			cRODSTAR = Nothing
		End Sub

		Private Sub LoadMax()
			Dim flag As Boolean = False
			Try
				If Me.cboRSMaxSize.Items.Count = 0 AndAlso RSWIN_DESC.rst.RSGrade > 0S Then
					Me.LoadRSMaxSize()
				End If
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Dim num As Single
				Dim num2 As Integer
				Dim text As String = Me.GetMaxSize(Me.cboRSMaxSize, num, num2)
				If Strings.InStr(text, "Other", CompareMethod.Binary) > 0 Then
					text = Conversions.ToString(NewLateBinding.LateGet(Me.cboRSMaxSize.Items(Me.cboRSMaxSize.Items.Count - 2), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing))
				End If
				If Strings.InStr(text, "(", CompareMethod.Binary) > 0 Then
					text = text.Substring(0, Strings.InStr(text, "(", CompareMethod.Binary) - 1)
				End If
				If cRODSTAR.RSMaxSize > num Then
					If Me.cboRSMaxSize.SelectedIndex > 0 Then
						flag = True
						Me.cboRSMaxSize_Click_1(CShort((Me.cboRSMaxSize.SelectedIndex - 1)), Me.ActiveControl Is Me.cboRSMaxSize)
					End If
				ElseIf cRODSTAR.RSMaxSize > 0F Then
					Dim num3 As Short = 0S
					Dim num4 As Short = CShort((Me.cboRSMaxSize.Items.Count - 1))

						For num5 As Short = num3 To num4
							text = Conversions.ToString(NewLateBinding.LateGet(Me.cboRSMaxSize.Items(CInt(num5)), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing))
							If Strings.InStr(text, "(", CompareMethod.Binary) > 0 Then
								' The following expression was wrapped in a checked-expression
								text = text.Substring(0, Strings.InStr(text, "(", CompareMethod.Binary) - 1)
							End If
							Dim num6 As Single
							Try
								num6 = RODUTIL.CvtStrDiamToSngl(text)
							Catch ex As Exception
							End Try
							If num6 = cRODSTAR.RSMaxSize Then
								Me.cboRSMaxSize_Click_1(num5, False)
								flag = True
								Exit For
							End If
						Next

				End If
				If Not flag Then
					Me.cboRSMaxSize.SelectedIndex = -1
				End If
				cRODSTAR = Nothing
			Catch ex2 As Exception
				Dim sMsg As String = "Error in LoadMax: " + ex2.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub LoadMin()
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				If Me.cboRSMinSize.Items.Count = 0 AndAlso RSWIN_DESC.rst.RSGrade > 0S Then
					Me.LoadRSMinSize()
				End If
				Dim num4 As Single
				If cRODSTAR.RSMinSize > 0F Then
					Dim num As Short = 0S
					Dim num2 As Short = CShort((Me.cboRSMinSize.Items.Count - 1))
					For num3 As Short = num To num2
						Dim text As String = Conversions.ToString(NewLateBinding.LateGet(Me.cboRSMinSize.Items(CInt(num3)), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing))
						If Strings.InStr(text, "(", CompareMethod.Binary) > 0 Then
							' The following expression was wrapped in a checked-expression
							text = text.Substring(0, Strings.InStr(text, "(", CompareMethod.Binary) - 1)
						End If
						Try
							num4 = RODUTIL.CvtStrDiamToSngl(text)
						Catch ex As Exception
						End Try
						If num4 = cRODSTAR.RSMinSize Then
							flag2 = Me.cboRSMinSize_Click_1(num3, False)
							If flag2 Then
								flag = True
								If RSWIN_DESC.bRodStarD Then
									If RSWIN_DESC.rst.RSSRSize = 0F Or RSWIN_DESC.rst.RSSRSize = RSWIN_DESC.rst.RSMinSize Then
										Me.cboRSSRSize.SelectedIndex = CInt(num3)
										If RSWIN_DESC.rst.RSSRSize = 0F Then
											RSWIN_DESC.rst.RSSRSize = RSWIN_DESC.rst.RSMinSize
										End If
									End If
									Exit For
								End If
								Exit For
							End If
						End If
					Next
				End If
				If RSWIN_DESC.bRodStarD Then
					Try
						If cRODSTAR.RSSRSize > 0F Then
							Dim num5 As Short = 0S
							Dim num6 As Short = CShort((Me.cboRSSRSize.Items.Count - 1))
							For num3 As Short = num5 To num6
								Dim text As String = Conversions.ToString(NewLateBinding.LateGet(Me.cboRSSRSize.Items(CInt(num3)), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing))
								If Strings.InStr(text, "(", CompareMethod.Binary) > 0 Then
									' The following expression was wrapped in a checked-expression
									text = text.Substring(0, Strings.InStr(text, "(", CompareMethod.Binary) - 1)
								End If
								Try
									num4 = RODUTIL.CvtStrDiamToSngl(text)
								Catch ex2 As Exception
								End Try
								If num4 = cRODSTAR.RSSRSize And Me.cboRSSRSize.SelectedIndex <> CInt(num3) Then
									Me.cboRSSRSize_Click_1(num3, False)
									flag = True
									Exit For
								End If
							Next
						End If
					Catch ex3 As Exception
					End Try
				End If
				cRODSTAR = Nothing
				If Not flag AndAlso flag2 Then
					Me.cboRSMinSize.SelectedIndex = -1
				End If
			Catch ex4 As Exception
				Dim sMsg As String = "Error in LoadMin: " + ex4.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub LoadRSInput()
			Try
				Me.mbMaxMinNotYetSet = False
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Select Case cRODSTAR.RodStringType
					Case 1S
						Me.miDesignStyle = 4
					Case 2S, 4S
						Me.miDesignStyle = 3
					Case 3S
						Select Case cRODSTAR.giRodDesignStyle
							Case 0S
								Me.miDesignStyle = 0
							Case 1S
								Me.miDesignStyle = 1
						End Select
				End Select
				Dim num As Short
				Dim numRods As Short
				Try
					If Me.miDesignStyle = 3 Then
						Me.tbsRodDesignType.SelectedIndex = Me.miDesignStyle - 1
					Else
						Me.tbsRodDesignType.SelectedIndex = Me.miDesignStyle
					End If
				Catch ex As Exception
				End Try
				Me.tbsRodDesignType_Click_1(CShort(Me.miDesignStyle), False, False)
				Me.txtServiceFactor.Text = Convert.ToString(cRODSTAR.ServiceFactor)
				Me.txtRSExtraCost.Text = Convert.ToString(cRODSTAR.RSExtraCost)
				Me.txtRSExtraCostLabel.Text = cRODSTAR.RSExtraCostLabel
				num = 1S
				numRods = cRODSTAR.NumRods
				For num2 As Short = num To numRods
					Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
					Dim num3 As Integer = CInt(num2)
					If CUSTOMRG.IsOtherSteel(CInt(sections(num3).Grade)) Or CUSTOMRG.IsOtherFG(CInt(sections(num3).Grade)) Then
						If sections(num3).RodType Is Nothing Then
							sections(num3).RodType = ""
						End If
						If Operators.CompareString(sections(num3).RodType.Trim(), "", False) = 0 And sections(num3).Grade <> 0S Then
							sections(num3).RodType = Conversions.ToString(RODUTIL.GetCustomRodTypeName(sections(num3).Grade))
						End If
						If Operators.CompareString(sections(num3).RodType.Trim(), "", False) = 0 Or Operators.CompareString(sections(num3).RodType.Trim(), "0", False) = 0 Then
							sections(num3).RodType = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num2)))
						End If
						If Operators.CompareString(sections(num3).RodType.Trim(), "", False) <> 0 Then
							Debug.WriteLine(Conversions.ToString(CInt(sections(num3).Grade)) + " , " + sections(num3).RodType)
							Dim num4 As Integer = Me.FindCustomRodGrade(sections(num3).RodType)
							If num4 <> -1 Then
								sections(num3).Grade = CShort(num4)
							End If
						End If
					End If
					If Me.bShowGuides Then
						If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
							Me.AddRodTaper(CInt(num2), CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants), sections(num3).Diameter, sections(num3).length, sections(num3).friction_coef, sections(num3).Guide, sections(num3).NumGuides, False, 0, True)
						Else
							Me.AddRodTaper(CInt(num2), CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants), sections(num3).Diameter, sections(num3).length, sections(num3).friction_coef, sections(num3).Guide, 0S, False, 0, True)
						End If
					ElseIf Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
						Me.AddRodTaper(CInt(num2), CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants), sections(num3).Diameter, sections(num3).length, sections(num3).friction_coef, CShort(RSWIN_DESC.SETUP_GuideToUse), sections(num3).NumGuides, False, 0, True)
					Else
						Me.AddRodTaper(CInt(num2), CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants), sections(num3).Diameter, sections(num3).length, sections(num3).friction_coef, 0S, 0S, False, 0, True)
					End If
				Next
				Dim ulgTapers As UltraGrid
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					ulgTapers = Me.ulgTapers
					CtrlUI.Grid_ToggleUnits(ulgTapers, -1S, -1S, "")
					Me.ulgTapers = ulgTapers
				End If
				ulgTapers = Me.ulgTapers
				CtrlUI.Grid_SetLabels(ulgTapers, True)
				Me.ulgTapers = ulgTapers
				If Me.miDesignStyle <> 3 Then
					Dim flag As Boolean = Me.miDesignStyle = 1
					Dim flag2 As Boolean = Me.miDesignStyle = 0
					If flag Then
						Dim cboRSFGGrade As ComboBox = Me.cboRSFGGrade
						Dim comboBox As ComboBox = Me.cboRSFGGrade
						Dim selectedIndex As Integer = CInt(RODUTIL.FindRodGrade(comboBox, cRODSTAR.RSFGGrade, Nothing))
						Me.cboRSFGGrade = comboBox
						cboRSFGGrade.SelectedIndex = selectedIndex
					End If
					If flag2 Then
						Me.chkRSFGIncludeSteel_Click_1(True, False, False)
					Else
						Me.chkRSFGIncludeSteel_Click_1(cRODSTAR.RSFGIncludeSteel <> 0S, False, False)
					End If
					If RSWIN_DESC.bRodStarD Then
						Me.txtRSFricCoeff.Text = Conversions.ToString(RSWIN_DESC.rst.RSFricCoef)
						Try
							If Me.cboRSRodGuides.Items.Count > 0 Then
								Me.cboRodGuides.SelectedValue = RSWIN_DESC.rst.RSRodGuide
							End If
						Catch ex2 As Exception
						End Try
					End If
					If Util.CheckBoxChecked(Me.chkRSFGIncludeSteel.Checked) AndAlso cRODSTAR.RSGrade > 0S Then
						Dim comboBox As ComboBox = Me.cboRSGrade
						Dim iListIndex As Short = RODUTIL.FindRodGrade(comboBox, cRODSTAR.RSGrade, cRODSTAR.RSRodType)
						Me.cboRSGrade = comboBox
						Me.cboRSGrade_Click_1(iListIndex, False)
						Me.LoadMax()
						Me.LoadMin()
					End If
					Me.txtRSSBLength.Text = Nothing
					If Not cRODSTAR.RSIncludeSB <> 0S Then
						Me.optSinkerBars_Click_1(True, False)
						Me.cboRSSBDiameter.SelectedIndex = -1
						Me.txtRSSBDiameter.Enabled = False
						Me.txtRSSBLength.Text = Nothing
						Me.chkRSIncludeSB_Click_1(False, False)
					Else
						If RODUTIL.IsSinkerBar1(CInt(cRODSTAR.SinkerBar.Grade), cRODSTAR.SinkerBar.RodType) <> 0 Then
							Me.optSinkerBars_Click_1(True, False)
						Else
							Me.optSinkerRods_Click_1(True, False)
						End If
						Dim cboRSSBGrade As ComboBox = Me.cboRSSBGrade
						Dim comboBox As ComboBox = Me.cboRSSBGrade
						Dim selectedIndex2 As Integer = CInt(RODUTIL.FindRodGrade(comboBox, cRODSTAR.SinkerBar.Grade, cRODSTAR.SinkerBar.RodType))
						Me.cboRSSBGrade = comboBox
						cboRSSBGrade.SelectedIndex = selectedIndex2
						Me.bLoadingCombo = True
						Me.LoadSBDiameter(cRODSTAR.SinkerBar.Grade)
						Me.bLoadingCombo = False
						If cRODSTAR.SinkerBar.length = 0F Then
							Me.txtRSSBLength.Text = Nothing
						Else
							Me.txtRSSBLength.Enabled = True
							If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
								If RSWIN_DESC.SETUP_DisplaySBinFeet <> 0S Then
									Me.txtRSSBLength.Tag = "fee"
								Else
									Me.txtRSSBLength.Tag = "fem"
								End If
							ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
								Me.txtRSSBLength.Tag = "fee"
							Else
								Me.txtRSSBLength.Tag = "fem"
							End If
							Me.txtRSSBLength.Text = Conversions.ToString(cRODSTAR.SinkerBar.length)
						End If
						Me.chkRSIncludeSB_Click_1(True, False)
						If(RSWIN_DESC.rst.RSSBDiameter <> 0F And RSWIN_DESC.rst.RSMaxSize <> 0F) AndAlso RSWIN_DESC.rst.RSSBDiameter <= RSWIN_DESC.rst.RSMaxSize Then
							Me.lblStatus.Text = " " + Me.sSinkerRodDiameterWarningMsg
						End If
					End If
					Me.SetEnabledControls(flag, False)
					If RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru And Me.chkDesignSinkerbars.Visible Then
						Me.chkDesignSinkerbars.Checked = RSWIN_DESC.rst.gbDesignSinkerbar
					End If
				ElseIf Me.miDesignStyle = 3 AndAlso Not Me.bInsideUpdateRS Then
					Me.UpdateRS()
				End If
				cRODSTAR = Nothing
			Catch ex3 As Exception
				Dim message As String = ex3.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(message, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub LoadSBDiameter(iGrade As Short)
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				If cRODSTAR.SinkerBar.Diameter = 0F Then
					Dim sinkerBar As RSWIN_DESC.RodSection
					sinkerBar.Initialize()
					sinkerBar.Diameter = 1.5F
					cRODSTAR.SinkerBar = sinkerBar
					If iGrade > 0S Then
						Dim rodType As String = cRODSTAR.SinkerBar.RodType
						Me.LoadDiameterList(Me.myRSSBDiamAL, Me.myRSSBDiamRodSizeArray, iGrade, rodType, False)
						Dim arrayList As ArrayList
						Try
							Dim comparer As RSInput.rsaComparer = New RSInput.rsaComparer()
							Array.Sort(Me.myRSSBDiamRodSizeArray, comparer)
							arrayList = New ArrayList()
							arrayList.Clear()
							Dim num As Short = 0S
							Dim num2 As Short = CShort((Me.myRSSBDiamRodSizeArray.Length - 1))
							For num3 As Short = num To num2
								If Me.myRSSBDiamRodSizeArray(CInt(num3)).rsaRodSizeID <> 0 And Me.myRSSBDiamRodSizeArray(CInt(num3)).rsaDisplayName <> Nothing Then
									Debug.WriteLine(Conversions.ToString(Me.myRSSBDiamRodSizeArray(CInt(num3)).rsaRodSizeID) + " , " + Me.myRSSBDiamRodSizeArray(CInt(num3)).rsaDisplayName)
									arrayList.Add(New cRodSize(Me.myRSSBDiamRodSizeArray(CInt(num3)).rsaRodSizeID, Me.myRSSBDiamRodSizeArray(CInt(num3)).rsaDisplayName))
								End If
							Next
							arrayList.Add(New cRodSize(0, "Other"))
						Catch ex As Exception
						End Try
						Me.myRSSBDiamAL = arrayList
						If Me.myRSSBDiamAL IsNot Nothing AndAlso Me.myRSSBDiamAL.Count > 0 Then
							Me.bLoadingCombo = True
							Try
								Me.cboRSSBDiameter.Items.Clear()
							Catch ex2 As Exception
							End Try
							Me.cboRSSBDiameter.DataSource = Nothing
							Me.cboRSSBDiameter.DataSource = Me.myRSSBDiamAL
							Me.cboRSSBDiameter.DisplayMember = "DisplayName"
							Me.cboRSSBDiameter.ValueMember = "RodSizeID"
							Me.bLoadingCombo = False
						End If
					End If
					Me.cboRSSBDiameter_Click_1(-1S, False, False)
				Else
					If Me.cboRSSBDiameter.Items.Count = 0 Then
						Dim arrayList As ArrayList
						If iGrade > 0S Then
							Dim rodType As String = cRODSTAR.SinkerBar.RodType
							Me.LoadDiameterList(Me.myRSSBDiamAL, Me.myRSSBDiamRodSizeArray, iGrade, rodType, False)
							Try
								Dim comparer2 As RSInput.rsaComparer = New RSInput.rsaComparer()
								Array.Sort(Me.myRSSBDiamRodSizeArray, comparer2)
								arrayList = New ArrayList()
								arrayList.Clear()
								Dim num4 As Short = 0S
								Dim num5 As Short = CShort((Me.myRSSBDiamRodSizeArray.Length - 1))
								For num3 As Short = num4 To num5
									If Me.myRSSBDiamRodSizeArray(CInt(num3)).rsaRodSizeID <> 0 And Me.myRSSBDiamRodSizeArray(CInt(num3)).rsaDisplayName <> Nothing Then
										Debug.WriteLine(Conversions.ToString(Me.myRSSBDiamRodSizeArray(CInt(num3)).rsaRodSizeID) + " , " + Me.myRSSBDiamRodSizeArray(CInt(num3)).rsaDisplayName)
										arrayList.Add(New cRodSize(Me.myRSSBDiamRodSizeArray(CInt(num3)).rsaRodSizeID, Me.myRSSBDiamRodSizeArray(CInt(num3)).rsaDisplayName))
									End If
								Next
								arrayList.Add(New cRodSize(0, "Other"))
								GoTo IL_352
							Catch ex3 As Exception
								GoTo IL_352
							End Try
						End If
						arrayList = New ArrayList()
						arrayList.Clear()
						IL_352:
						Me.myRSSBDiamAL = arrayList
						If Me.myRSSBDiamAL IsNot Nothing AndAlso Me.myRSSBDiamAL.Count > 0 Then
							Me.bLoadingCombo = True
							Try
								Me.cboRSSBDiameter.Items.Clear()
							Catch ex4 As Exception
							End Try
							Me.cboRSSBDiameter.DataSource = Nothing
							Me.cboRSSBDiameter.DataSource = Me.myRSSBDiamAL
							Me.cboRSSBDiameter.DisplayMember = "DisplayName"
							Me.cboRSSBDiameter.ValueMember = "RodSizeID"
							Me.bLoadingCombo = False
						End If
						Try
							Me.cboRSSBDiameter.Visible = True
							Me.cboRSSBDiameter.Enabled = True
						Catch ex5 As Exception
						End Try
					End If
					Dim iListIndex As Short = -1S
					Dim num6 As Short = -1S
					Dim num7 As Short = 0S
					Dim num8 As Short = CShort((Me.cboRSSBDiameter.Items.Count - 1))
					For num3 As Short = num7 To num8
						If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Me.cboRSSBDiameter.Items(CInt(num3)), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing), "Other", False) Then
							iListIndex = num3
						End If
						Dim text As String = Conversions.ToString(NewLateBinding.LateGet(Me.cboRSSBDiameter.Items(CInt(num3)), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing))
						If Strings.InStr(text, "(", CompareMethod.Binary) > 0 Then
							' The following expression was wrapped in a checked-expression
							text = text.Substring(0, Strings.InStr(text, "(", CompareMethod.Binary) - 1)
						End If
						If RODUTIL.CvtStrDiamToSngl(text) = cRODSTAR.SinkerBar.Diameter Then
							num6 = num3
							Exit For
						End If
					Next
					If num6 = -1S Then
						Me.cboRSSBDiameter_Click_1(iListIndex, False, False)
					Else
						Me.cboRSSBDiameter_Click_1(num6, False, False)
					End If
				End If
				cRODSTAR = Nothing
			Catch ex6 As Exception
				MessageBox.Show(ex6.Message)
			End Try
		End Sub

		Private Sub PositionOverCell(CtlToMove As Control, Grid As UltraGrid)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				If Grid Is Nothing Then
					GoTo IL_112
				End If
				If CtlToMove Is Nothing Then
					GoTo IL_112
				End If
				If Grid.ActiveCell Is Nothing Then
					GoTo IL_112
				End If
				Dim activeCell As UltraGridCell = Grid.ActiveCell
				Grid.ActiveColScrollRegion.ScrollCellIntoView(activeCell, Grid.ActiveRowScrollRegion)
				Dim cellUIElement As CellUIElement = CType(activeCell.GetUIElement(Grid.ActiveRowScrollRegion, Grid.ActiveColScrollRegion), CellUIElement)
				If cellUIElement Is Nothing Then
					GoTo IL_112
				End If
				Dim rect As Rectangle = cellUIElement.Rect
				If rect.Left < 0 Or rect.Top < 0 Or rect.Width <= 0 Or rect.Height <= 0 Then
					GoTo IL_112
				End If
				CtlToMove.Left += Grid.Left
				CtlToMove.Top += Grid.Top
				CtlToMove.Visible = True
				IL_CB:
				GoTo IL_112
				IL_CD:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_E3:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_CD
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_112:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub optSinkerBars_Click_1(Checked As Boolean, Clicked As Boolean)
			If Me.optSinkerBars.Checked <> Checked Then
				Me.optSinkerBars.Checked = Checked
			End If
			Me.bLoadingCombo = True
			Dim cboRSSBGrade As ComboBox = Me.cboRSSBGrade
			RODUTIL.LoadRodGradeList(cboRSSBGrade, 2, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
			Me.cboRSSBGrade = cboRSSBGrade
			cboRSSBGrade = Me.cboRSSBGrade
			Me.LoadCustomToRodGradeList(cboRSSBGrade, 2, Me.RSSBGrade_AL, False, True)
			Me.cboRSSBGrade = cboRSSBGrade
			Me.bLoadingCombo = False
			Me.cboRSSBDiameter.Enabled = False
			Me.txtRSSBDiameter.Enabled = False
			If Clicked Then
				If Me.optSinkerBars.Checked Then
					ini.SaveDataValue("SinkerRods", False)
				Else
					ini.SaveDataValue("SinkerRods", True)
				End If
				Return
			End If
		End Sub

		Private Sub optSinkerRods_Click_1(Checked As Boolean, Clicked As Boolean)
			If Me.optSinkerRods.Checked <> Checked Then
				Me.optSinkerRods.Checked = Checked
			End If
			Me.bLoadingCombo = True
			Dim cboRSSBGrade As ComboBox = Me.cboRSSBGrade
			RODUTIL.LoadRodGradeList(cboRSSBGrade, 1, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
			Me.cboRSSBGrade = cboRSSBGrade
			cboRSSBGrade = Me.cboRSSBGrade
			RODUTIL.LoadRodGradeList(cboRSSBGrade, 3, Me.RSSBGrade_AL, False, False, False, False, False, False, False)
			Me.cboRSSBGrade = cboRSSBGrade
			cboRSSBGrade = Me.cboRSSBGrade
			RODUTIL.LoadRodGradeList(cboRSSBGrade, 6, Me.RSSBGrade_AL, False, False, False, False, False, False, False)
			Me.cboRSSBGrade = cboRSSBGrade
			cboRSSBGrade = Me.cboRSSBGrade
			Me.LoadCustomToRodGradeList(cboRSSBGrade, 1, Me.RSSBGrade_AL, False, True)
			Me.cboRSSBGrade = cboRSSBGrade
			Me.bLoadingCombo = False
			Me.cboRSSBDiameter.Enabled = False
			Me.txtRSSBDiameter.Enabled = False
			If Clicked Then
				If Me.optSinkerRods.Checked Then
					ini.SaveDataValue("SinkerRods", True)
				ElseIf Me.optSinkerBars.Checked Then
					ini.SaveDataValue("SinkerRods", False)
				End If
				Return
			End If
		End Sub

		Private Sub ResortGrid()
			Try
				Dim ultraGridBand As UltraGridBand = Me.ulgTapers.DisplayLayout.Bands(0)
				ultraGridBand.SortedColumns.Clear()
				ultraGridBand.SortedColumns.Add(ultraGridBand.Columns("RodNum"), False)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SetupForm()
			Me.ctrSteelDesign.Height = Me.fraSteelDesign.Height
			Me.ctrSteelDesign.Tag = Convert.ToString(Me.fraSteelDesign.Height)
			Me.mcxSteelDesignInfoOffset = 0
			Me.mcySteelDesignInfoOffset = Me.cboRSGrade.Top
			Me.CreateValueLists()
			Dim cboRodSize As ComboBox = Me.cboRodSize
			cboRodSize.DisplayMember = "DisplayName"
			cboRodSize.ValueMember = "RodSizeID"
			Dim cboRodGrade As ComboBox = Me.cboRodGrade
			cboRodGrade.DisplayMember = "DisplayName"
			cboRodGrade.ValueMember = "RodGradeID"
			Dim cboRSFGGrade As ComboBox = Me.cboRSFGGrade
			cboRSFGGrade.DisplayMember = "DisplayName"
			cboRSFGGrade.ValueMember = "RodGradeID"
			Dim cboRSGrade As ComboBox = Me.cboRSGrade
			cboRSGrade.DisplayMember = "DisplayName"
			cboRSGrade.ValueMember = "RodGradeID"
			Dim cboRSSBGrade As ComboBox = Me.cboRSSBGrade
			cboRSSBGrade.DisplayMember = "DisplayName"
			cboRSSBGrade.ValueMember = "RodGradeID"
			If Me.bShowGuides And RSWIN_DESC.bRodStarD Then
				Dim cboRodGuides As ComboBox = Me.cboRodGuides
				cboRodGuides.DisplayMember = "DisplayName"
				cboRodGuides.ValueMember = "RodGuideID"
			End If
			If RSWIN_DESC.bRodStarD Then
				Dim cboRSRodGuides As ComboBox = Me.cboRSRodGuides
				cboRSRodGuides.DisplayMember = "DisplayName"
				cboRSRodGuides.ValueMember = "RodGuideID"
			End If
			Me.bLoadingCombo = True
			Dim comboBox As ComboBox = Me.cboRSFGGrade
			RODUTIL.LoadRodGradeList(comboBox, 4, Me.RSFGGrade_AL, True, True, False, False, False, False, False)
			Me.cboRSFGGrade = comboBox
			comboBox = Me.cboRSGrade
			RODUTIL.LoadRodGradeList(comboBox, 0, Me.RSGrade_AL, True, False, False, False, False, False, False)
			Me.cboRSGrade = comboBox
			comboBox = Me.cboRSGrade
			RODUTIL.LoadRodGradeList(comboBox, 3, Me.RSGrade_AL, False, False, False, False, False, False, False)
			Me.cboRSGrade = comboBox
			comboBox = Me.cboRSGrade
			RODUTIL.LoadRodGradeList(comboBox, 6, Me.RSGrade_AL, False, False, False, False, False, False, False)
			Me.cboRSGrade = comboBox
			comboBox = Me.cboRSGrade
			Me.LoadCustomToRodGradeList(comboBox, 0, Me.RSGrade_AL, False, True)
			Me.cboRSGrade = comboBox
			Try
				If(RODUTIL.IsSinkerBar1(CInt(RSWIN_DESC.rst.SinkerBar.Grade), RSWIN_DESC.rst.SinkerBar.RodType) Or If((-If(((RSWIN_DESC.rst.SinkerBar.Grade = 0S) > False), 1, 0)), 1, 0)) <> 0 Then
					comboBox = Me.cboRSSBGrade
					RODUTIL.LoadRodGradeList(comboBox, 2, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
					Me.cboRSSBGrade = comboBox
					comboBox = Me.cboRSSBGrade
					Me.LoadCustomToRodGradeList(comboBox, 2, Me.RSSBGrade_AL, False, True)
					Me.cboRSSBGrade = comboBox
				Else
					comboBox = Me.cboRSSBGrade
					RODUTIL.LoadRodGradeList(comboBox, 0, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
					Me.cboRSSBGrade = comboBox
					comboBox = Me.cboRSSBGrade
					RODUTIL.LoadRodGradeList(comboBox, 3, Me.RSSBGrade_AL, False, False, False, False, False, False, False)
					Me.cboRSSBGrade = comboBox
					comboBox = Me.cboRSSBGrade
					RODUTIL.LoadRodGradeList(comboBox, 6, Me.RSSBGrade_AL, False, False, False, False, False, False, False)
					Me.cboRSSBGrade = comboBox
					comboBox = Me.cboRSSBGrade
					Me.LoadCustomToRodGradeList(comboBox, 0, Me.RSSBGrade_AL, False, True)
					Me.cboRSSBGrade = comboBox
				End If
			Catch ex As Exception
				comboBox = Me.cboRSSBGrade
				RODUTIL.LoadRodGradeList(comboBox, 2, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
				Me.cboRSSBGrade = comboBox
				comboBox = Me.cboRSSBGrade
				Me.LoadCustomToRodGradeList(comboBox, 2, Me.RSSBGrade_AL, False, True)
				Me.cboRSSBGrade = comboBox
			End Try
			Me.bLoadingCombo = False
		End Sub

		Private Sub RSInput_Enter(eventSender As Object, eventArgs As EventArgs)
			Me.m_bLeaveLoaded = False
		End Sub

		Private Sub RSInput_Leave(eventSender As Object, eventArgs As EventArgs)
			Me.m_bLeaveLoaded = True
			Dim flag As Boolean = Me.ValidateRSInput(Me.bFormLoaded, True, False)
			Me.bFormLoaded = False
		End Sub

		Private Sub RSInput_Load(eventSender As Object, eventArgs As EventArgs)
			Dim flag As Boolean = False
			SUPERPRO.NewCheckSentinel(True)
			RSWIN.GetMeasurementUnit()
			Me.ResetClock()
			Me.bShowGuides = False
			Me.m_bClosing = False
			RSWIN_DESC.sCurrentFormName = "RSInput"
			Me.bLengthError = False
			If Me.bUseStatus Then
				Me.lblStatus.Text = ""
				Me.lblStatus.Visible = True
			Else
				Me.lblStatus.Visible = False
			End If
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
			Me.bShowGuides = False
			If RSWIN_DESC.bRodStarD Then
				Me.Width = 860
				Me.picRemoveFocus.Width = 845
				Me.ctrRodString.Width = 765
				Me.ulgTapers.Width = 750
				Me.bShowGuides = True
				Me.Width += 150
				Me.picRemoveFocus.Width = Me.picRemoveFocus.Width + 150
				Me.ctrRodString.Width = Me.ctrRodString.Width + 150
				Me.ulgTapers.Width = Me.ulgTapers.Width + 150
				If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
					Me.Width += 100
					Me.picRemoveFocus.Width = Me.picRemoveFocus.Width + 100
					Me.ctrRodString.Width = Me.ctrRodString.Width + 100
					Me.ulgTapers.Width = Me.ulgTapers.Width + 100
				End If
				If Screen.PrimaryScreen.Bounds.Width < Me.Width Or Screen.PrimaryScreen.Bounds.Height < Me.Height Then
					Me.AutoScroll = True
				Else
					Me.AutoScroll = False
				End If
				Me.lblRSSRSize.Visible = True
				Me.cboRSSRSize.Visible = True
			Else
				Me.lblFricFootnote.Visible = False
				Me.lblRSSRSize.Visible = False
				Me.cboRSSRSize.Visible = False
			End If
			If Not RSWIN_DESC.bUseLatestGradeChanges Then
				Me.iCorodOrder = 214
				Me.iProrodOrder = 306
				Me.iNorris97 = 4
			Else
				Me.iProrodOrder = 205
				Me.iCorodOrder = 311
				Me.iNorris97 = 7
			End If
			Me.iFlexBarC = 10
			Dim text As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				text = "DisplaySBinFeet"
				Dim flag2 As Boolean = True
				RSWIN_DESC.SETUP_DisplaySBinFeet = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_GENERAL, text, flag2) > False), 1S, 0S)), 1S, 0S)
			End If
			text = "BareRodFricCoeff"
			Dim num As Single = 0.2F
			RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, num))
			text = "MoldedFricCoeff"
			RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fDefaultFricCoeff))
			text = "WheelFricCoeff"
			RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fDefaultFricCoeff))
			text = "OtherFricCoeff"
			RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fDefaultFricCoeff))
			text = "NorrisStandardGuideFricCoeff"
			RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text = "NorrisSidewinderGuideFricCoeff"
			RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text = "RGIJakeCouplingGuideFricCoeff"
			RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text = "RGISVTGuideFricCoeff"
			RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text = "RGITomahawkGuideFricCoeff"
			RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text = "RGITornadoGuideFricCoeff"
			RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text = "RGITwisterGuideFricCoeff"
			RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text = "RGIWVTGuideFricCoeff"
			RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
			Me.bFormLoaded = False
			Try
				If RSWIN_DESC.bRodStarD AndAlso (Util.IsPolyLined(RSWIN_DESC.rst.TubingID) And RSWIN_DESC.bReduceFricCoeff) Then
					flag = Util.CheckFrictionCoeffs()
				End If
			Catch ex As Exception
			End Try
			Me.RsInputLoad()
			If RSWIN_DESC.bRodStarD AndAlso flag Then
				Me.lblStatus.Text = RSWIN_DESC.sReduceMsg2
			End If
			Me.SetStringLengthFromGrid()
			Me.bFormLoaded = True
			Me.ValidateRSInput(Me.bFormLoaded, True, False)
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
			End If
			Me.ResetClock()
			Me.CenterForm()
		End Sub

		Private Sub RsInputLoad()
			Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			Try
				SUPERPRO.NewCheckSentinel(True)
				Me.picRemoveFocus.BorderStyle = BorderStyle.None
				Dim control As Control = Me.txtTempLength
				Me.HideControl(control)
				Me.txtTempLength = CType(control, TextBox)
				control = Me.txtLength
				Me.HideControl(control)
				Me.txtLength = CType(control, TextBox)
				Try
					If RSWIN_DESC.bRodStarD AndAlso (RSWIN_DESC.rst.RodStringType = 2S Or RSWIN_DESC.rst.RodStringType = 4S) Then
						Dim num As Integer = 1
						Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num To numRods
							If RSWIN_DESC.rst.Sections(i).Guide = 0S And RSWIN_DESC.rst.Sections(i).NumGuides <> 0S Then
								RSWIN_DESC.rst.Sections(i).NumGuides = 0S
								ini.SaveDataValue("NumGuides" + i.ToString(), 0)
							End If
						Next
					End If
				Catch ex As Exception
				End Try
				If Me.tmp_PumpDepth = 0F Then
					Me.txtTempLength.Tag = "fem"
					Me.txtTempLength.Text = Conversions.ToString(RSWIN_DESC.rst.PumpDepth)
					Dim txtTempLength As TextBox = Me.txtTempLength
					Dim lblTemp As Label = Me.lblTemp
					Me.TextBox_Change(txtTempLength, lblTemp)
					Me.lblTemp = lblTemp
					Me.txtTempLength = txtTempLength
					Me.tmp_PumpDepth = Convert.ToSingle(Me.txtTempLength.Text)
				End If
				If Me.mdsRodTapers Is Nothing Then
					Me.mbFirstResize = True
					Me.mbMaxMinNotYetSet = True
					Me.CreateDataSet()
				End If
				Me.SetupForm()
				If RSWIN_DESC.rst IsNot Nothing Then
					Me.btnNumberOfRods.Enabled = False
					Me.cmdAddSection.Enabled = False
					Me.cmdDelSection.Enabled = False
					Me.cmdMoveSectionDown.Enabled = False
					Me.cmdMoveSectionUp.Enabled = False
					If Not RSWIN_DESC.NewData(4) <> 0S Then
						Me.LoadRSInput()
					Else
						Me.InitRSInput()
					End If
					Dim ulgTapers As UltraGrid = Me.ulgTapers
					ulgTapers.DataSource = Me.mdsRodTapers
					Me.ulgTapers.Rows.Refresh(RefreshRow.FireInitializeRow, True)
					Dim row As UltraGridRow = Me.ulgTapers.GetRow(ChildRow.First)
					If row IsNot Nothing Then
						Me.ulgTapers.ActiveRow = row
					End If
				End If
				Me.CreateMyToolTip()
			Catch ex2 As Exception
				Dim sMsg As String = "Error in Load RSInput: " + ex2.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub tbsRodDesignType_Click(eventSender As Object, eventArgs As EventArgs)
			Try
				If Me.ActiveControl Is Me.tbsRodDesignType Then
					Me.lblStatus.Text = ""
					Me.bLengthError = False
					Me.bRodDesignTypeClicked = True
					Me.bFormLoaded = False
					Me.TurnOffViewReportOption()
					Dim tbsRodDesignType As TabControl = Me.tbsRodDesignType
					Select Case tbsRodDesignType.SelectedTab.TabIndex
						Case 0
							RSWIN_DESC.rst.RodStringType = 3S
							RSWIN_DESC.rst.giRodDesignStyle = 0S
							Me.miDesignStyle = 0
							ini.SaveDataValue("RodStringType", RSWIN_DESC.rst.RodStringType)
							ini.SaveDataValue("RodDesignStyle", RSWIN_DESC.rst.giRodDesignStyle)
							If Me.lstNumOfRods.Visible Then
								Me.lstNumOfRods.Visible = False
							End If
							Me.bLoadingCombo = True
							Dim comboBox As ComboBox = Me.cboRSGrade
							RODUTIL.LoadRodGradeList(comboBox, 0, Me.RSGrade_AL, True, False, False, False, False, False, False)
							Me.cboRSGrade = comboBox
							comboBox = Me.cboRSGrade
							RODUTIL.LoadRodGradeList(comboBox, 3, Me.RSGrade_AL, False, False, False, False, False, False, False)
							Me.cboRSGrade = comboBox
							comboBox = Me.cboRSGrade
							RODUTIL.LoadRodGradeList(comboBox, 6, Me.RSGrade_AL, False, False, False, False, False, False, False)
							Me.cboRSGrade = comboBox
							comboBox = Me.cboRSGrade
							Me.LoadCustomToRodGradeList(comboBox, 0, Me.RSGrade_AL, False, True)
							Me.cboRSGrade = comboBox
							If Me.optSinkerBars.Checked Then
								comboBox = Me.cboRSSBGrade
								RODUTIL.LoadRodGradeList(comboBox, 2, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
								Me.cboRSSBGrade = comboBox
								comboBox = Me.cboRSSBGrade
								Me.LoadCustomToRodGradeList(comboBox, 2, Me.RSSBGrade_AL, False, True)
								Me.cboRSSBGrade = comboBox
							ElseIf Me.optSinkerRods.Checked Then
								comboBox = Me.cboRSSBGrade
								RODUTIL.LoadRodGradeList(comboBox, 1, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
								Me.cboRSSBGrade = comboBox
								comboBox = Me.cboRSSBGrade
								RODUTIL.LoadRodGradeList(comboBox, 3, Me.RSSBGrade_AL, False, False, False, False, False, False, False)
								Me.cboRSSBGrade = comboBox
								comboBox = Me.cboRSSBGrade
								RODUTIL.LoadRodGradeList(comboBox, 6, Me.RSSBGrade_AL, False, False, False, False, False, False, False)
								Me.cboRSSBGrade = comboBox
								comboBox = Me.cboRSSBGrade
								Me.LoadCustomToRodGradeList(comboBox, 1, Me.RSSBGrade_AL, False, True)
								Me.cboRSSBGrade = comboBox
							Else
								comboBox = Me.cboRSSBGrade
								RODUTIL.LoadRodGradeList(comboBox, 2, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
								Me.cboRSSBGrade = comboBox
								comboBox = Me.cboRSSBGrade
								Me.LoadCustomToRodGradeList(comboBox, 2, Me.RSSBGrade_AL, False, True)
								Me.cboRSSBGrade = comboBox
							End If
							Me.bLoadingCombo = False
							Me.SetDefaultRSGRADE()
							If RSWIN_DESC.bExpert And Me.chkDesignSinkerbars.Visible Then
								Me.chkDesignSinkerbars.Enabled = True
							End If
							RSWIN_DESC.rst.bImplementedDesign = False
						Case 1
							RSWIN_DESC.rst.RodStringType = 3S
							RSWIN_DESC.rst.giRodDesignStyle = 1S
							Me.miDesignStyle = 1
							ini.SaveDataValue("RodStringType", RSWIN_DESC.rst.RodStringType)
							ini.SaveDataValue("RodDesignStyle", RSWIN_DESC.rst.giRodDesignStyle)
							If Me.lstNumOfRods.Visible Then
								Me.lstNumOfRods.Visible = False
							End If
							Me.bLoadingCombo = True
							Dim comboBox As ComboBox = Me.cboRSFGGrade
							RODUTIL.LoadRodGradeList(comboBox, 4, Me.RSFGGrade_AL, True, True, False, False, False, False, False)
							Me.cboRSFGGrade = comboBox
							comboBox = Me.cboRSGrade
							RODUTIL.LoadRodGradeList(comboBox, 0, Me.RSGrade_AL, True, False, False, False, False, False, False)
							Me.cboRSGrade = comboBox
							comboBox = Me.cboRSGrade
							RODUTIL.LoadRodGradeList(comboBox, 3, Me.RSGrade_AL, False, False, False, False, False, False, False)
							Me.cboRSGrade = comboBox
							comboBox = Me.cboRSGrade
							RODUTIL.LoadRodGradeList(comboBox, 6, Me.RSGrade_AL, False, False, False, False, False, False, False)
							Me.cboRSGrade = comboBox
							comboBox = Me.cboRSGrade
							Me.LoadCustomToRodGradeList(comboBox, 0, Me.RSGrade_AL, False, True)
							Me.cboRSGrade = comboBox
							If Me.optSinkerBars.Checked Then
								comboBox = Me.cboRSSBGrade
								RODUTIL.LoadRodGradeList(comboBox, 2, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
								Me.cboRSSBGrade = comboBox
								comboBox = Me.cboRSSBGrade
								Me.LoadCustomToRodGradeList(comboBox, 2, Me.RSSBGrade_AL, False, True)
								Me.cboRSSBGrade = comboBox
							ElseIf Me.optSinkerRods.Checked Then
								comboBox = Me.cboRSSBGrade
								RODUTIL.LoadRodGradeList(comboBox, 1, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
								Me.cboRSSBGrade = comboBox
								comboBox = Me.cboRSSBGrade
								RODUTIL.LoadRodGradeList(comboBox, 3, Me.RSSBGrade_AL, False, False, False, False, False, False, False)
								Me.cboRSSBGrade = comboBox
								comboBox = Me.cboRSSBGrade
								RODUTIL.LoadRodGradeList(comboBox, 6, Me.RSSBGrade_AL, False, False, False, False, False, False, False)
								Me.cboRSSBGrade = comboBox
								comboBox = Me.cboRSSBGrade
								Me.LoadCustomToRodGradeList(comboBox, 1, Me.RSSBGrade_AL, False, True)
								Me.cboRSSBGrade = comboBox
							Else
								comboBox = Me.cboRSSBGrade
								RODUTIL.LoadRodGradeList(comboBox, 2, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
								Me.cboRSSBGrade = comboBox
								comboBox = Me.cboRSSBGrade
								Me.LoadCustomToRodGradeList(comboBox, 2, Me.RSSBGrade_AL, False, True)
								Me.cboRSSBGrade = comboBox
							End If
							Me.bLoadingCombo = False
							Me.chkRSFGIncludeSteel.Checked = (RSWIN_DESC.rst.RSFGIncludeSteel <> 0S)
							If RSWIN_DESC.rst.RSFGIncludeSteel <> 0S Then
								Me.SetDefaultRSGRADE()
							End If
							If RSWIN_DESC.bExpert And Me.chkRSIncludeSB.Enabled And Me.chkDesignSinkerbars.Visible Then
								Me.chkDesignSinkerbars.Enabled = True
							End If
							Me.SetEnabledControls(True, False)
							RSWIN_DESC.rst.bImplementedDesign = False
						Case 3
							RSWIN_DESC.rst.RodStringType = 2S
							ini.SaveDataValue("RodStringType", RSWIN_DESC.rst.RodStringType)
							ini.SaveDataValue("RodDesignStyle", DBNull.Value)
							RSWIN_DESC.rst.bImplementedDesign = False
					End Select
					Me.Text = Conversions.ToString(tbsRodDesignType.SelectedTab.Tag)
					Me.bFormLoaded = True
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub tbsRodDesignType_Click_1(Index As Short, bClicked As Boolean, Optional bNew As Boolean = False)
			' The following expression was wrapped in a checked-statement
			If bClicked Then
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Me.miDesignStyle = CInt(Index)
				Select Case Index
					Case 0S
						If cRODSTAR.RodStringType = 2S AndAlso cRODSTAR.RSFricCoef = 0F Then
							Try
								Dim text As String = "GuideToUse"
								Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
								Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
								RSWIN_DESC.MOLDED = CShort(molded)
								RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
								Me.cboRodGuides.SelectedValue = RSWIN_DESC.SETUP_GuideToUse
								cRODSTAR.RSFricCoef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
							Catch ex As Exception
							End Try
						End If
						cRODSTAR.RodStringType = 3S
						cRODSTAR.gbSteelRodString = True
						cRODSTAR.giRodDesignStyle = 0S
						Me.chkRSFGIncludeSteel_Click_1(True, True, False)
					Case 1S
						cRODSTAR.RodStringType = 3S
						cRODSTAR.gbSteelRodString = False
						cRODSTAR.giRodDesignStyle = 1S
						If cRODSTAR.RSFricCoef = 0F Then
							Try
								Dim text As String = "GuideToUse"
								Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
								Dim regProfileStringByInt2 As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
								RSWIN_DESC.MOLDED = CShort(molded)
								RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt2)
								Me.cboRodGuides.SelectedValue = RSWIN_DESC.SETUP_GuideToUse
								cRODSTAR.RSFricCoef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
							Catch ex2 As Exception
							End Try
						End If
					Case 2S, 3S
						cRODSTAR.RodStringType = 2S
						Me.SetStringLengthFromGrid()
					Case 4S
						cRODSTAR.RodStringType = 1S
				End Select
				ini.SaveDataValue("RodStringType", cRODSTAR.RodStringType)
				ini.SaveDataValue("RodDesignStyle", cRODSTAR.giRodDesignStyle)
				If Me.miDesignStyle = 0 Or Me.miDesignStyle = 1 Then
					Try
						Me.txtRSSBLength_TextChanged(Me.txtRSSBLength, New EventArgs())
						Me.txtRSSBLengthEnabledChanged()
					Catch ex3 As Exception
					End Try
				End If
				cRODSTAR = Nothing
			End If
			If RSWIN_DESC.rst.RodStringType = 3S Then
				Me.btnNumberOfRods.Enabled = False
				Me.cmdAddSection.Enabled = False
				Me.cmdDelSection.Enabled = False
				Me.cmdMoveSectionUp.Enabled = False
				Me.cmdMoveSectionDown.Enabled = False
				Me.btnNumberOfRods.Visible = False
				Me.cmdAddSection.Visible = False
				Me.cmdDelSection.Visible = False
				Me.cmdMoveSectionUp.Visible = False
				Me.cmdMoveSectionDown.Visible = False
				Me._Line_0.Visible = False
				If RSWIN_DESC.bRodStarD Then
					Me.txtRSFricCoeff.Visible = True
					If RSWIN_DESC.rst.RSFricCoef = 0F Then
						Dim text As String = "GuideToUse"
						Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
						Dim regProfileStringByInt3 As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
						RSWIN_DESC.MOLDED = CShort(molded)
						RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt3)
						Me.cboRodGuides.SelectedValue = RSWIN_DESC.SETUP_GuideToUse
						If RSWIN_DESC.rst.RSFricCoef = 0F Then
							RSWIN_DESC.rst.RSFricCoef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
						End If
					End If
					Me.txtRSFricCoeff.Text = Convert.ToString(RSWIN_DESC.rst.RSFricCoef)
					Me.lblRSFricCoeff.Visible = True
					Try
						Me.cboRodGuides.SelectedValue = RSWIN_DESC.rst.RSRodGuide
					Catch ex4 As Exception
					End Try
					Me.lblRodGuides.Visible = True
					Me.cboRSRodGuides.Visible = True
				End If
				Me.SetEnabledControls(RSWIN_DESC.rst.giRodDesignStyle = 1S, bNew)
			ElseIf RSWIN_DESC.rst.RodStringType = 2S Then
				Me.btnNumberOfRods.Enabled = True
				Me.cmdAddSection.Enabled = True
				Me.cmdDelSection.Enabled = True
				Me.cmdMoveSectionUp.Enabled = True
				Me.cmdMoveSectionDown.Enabled = True
				Me.btnNumberOfRods.Visible = True
				Me.cmdAddSection.Visible = True
				Me.cmdDelSection.Visible = True
				Me.cmdMoveSectionUp.Visible = True
				Me.cmdMoveSectionDown.Visible = True
				Me._Line_0.Visible = True
				Me.txtRSFricCoeff.Visible = False
				Me.lblRSFricCoeff.Visible = False
				Me.lblRodGuides.Visible = False
				Me.cboRSRodGuides.Visible = False
			End If
			Me.UpdateUI()
			Select Case Index
				Case 0S
					Me.ctrFGDesign.Visible = False
					Me.ctrRodString.Visible = False
					Me.ctrSinkerBars.Visible = True
					Me.ctrSteelDesign.Visible = True
					Me.DoArrange(New Control() { Me.ctrSteelDesign, Me.ctrSinkerBars, Me.ctrOtherInfo })
					Return
				Case 1S
					Me.ctrFGDesign.Visible = True
					Me.ctrRodString.Visible = False
					Me.ctrSinkerBars.Visible = True
					Me.ctrSteelDesign.Visible = True
					Me.DoArrange(New Control() { Me.ctrFGDesign, Me.ctrSteelDesign, Me.ctrSinkerBars, Me.ctrOtherInfo })
					Return
				Case 2S, 4S
					Return
				Case 3S
					Me.ctrFGDesign.Visible = False
					Me.ctrRodString.Visible = True
					Me.ctrSinkerBars.Visible = False
					Me.ctrSteelDesign.Visible = False
					Me.DoArrange(New Control() { Me.ctrRodString, Me.ctrOtherInfo })
					Return
				Case Else
					Return
			End Select
		End Sub

		Private Sub ulgTapers_AfterCellUpdate(eventSender As Object, eventArgs As CellEventArgs)
			Dim text As String = ""
			If Me.bF2Hit Then
				If Operators.CompareString(eventArgs.Cell.Column.Key, "RodLength", False) = 0 And Me.btxtLengthHasFocus Then
					Me.ulgTapers_CellChange(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
					Return
				End If
			Else
				Try
					If RSWIN_DESC.bRodStarD Then
						RSWIN_DESC.rst.bImplementedDesign = False
					End If
					Dim key As String = eventArgs.Cell.Column.Key
					If Operators.CompareString(key, "RodGrade", False) = 0 Then
						Dim cell As UltraGridCell = eventArgs.Cell
						Dim num As Integer = Conversions.ToInteger(cell.Value)
						Dim num2 As Long = Conversions.ToLong(cell.Row.Cells("RodNum").Value)
						If num <> -1 Then
							RSWIN_DESC.rst.Sections(CInt(num2)).Grade = CShort(num)
						End If
						cell.Tag = Nothing
						cell.Row.Cells("RodSize").Tag = Nothing
						num2 = Conversions.ToLong(cell.Row.Cells("RodNum").Value)
						Dim index As Integer = num
						If CUSTOMRG.IsOtherSteel(num) Or CUSTOMRG.IsOtherSinkerBar(num) Then
							index = 4096
						ElseIf CUSTOMRG.IsOtherFG(num) Then
							index = 16384
						End If
						ini.SaveDataValue("RodGrade" + num2.ToString(), num)
						Dim name As Object
						ini.SaveDataValue("RodType" + num2.ToString(), RuntimeHelpers.GetObjectValue(name))
						Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
						Dim num3 As Integer = CInt(num2)
						sections(num3).Grade = CShort(num)
						If num <> -1 Then
							Try
								name = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(index, StdInfoConstants.RodGradeConstants)).Name
							Catch ex As Exception
							End Try
							sections(num3).RodType = Conversions.ToString(name)
						End If
					ElseIf Operators.CompareString(key, "RodSize", False) = 0 Then
						Dim cell2 As UltraGridCell = eventArgs.Cell
						Dim num4 As Integer = CInt(Conversions.ToLong(cell2.Value))
						Dim ultraGridRow As UltraGridRow = cell2.Row
						Dim num As Integer = Conversions.ToInteger(ultraGridRow.Cells("RodGrade").Value)
						Try
							Dim diameter As Single
							Try
								diameter = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(num, StdInfoConstants.RodGradeConstants)).RodSizeList.Item(num4).Diameter
							Catch ex2 As Exception
							End Try
							Try
								If diameter = 0F Then
									If CUSTOMRG.IsOtherFG(num) Then
										diameter = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(StdInfoConstants.RodGradeConstants.teRodGradeCustomFG).RodSizeList.Item(num4).Diameter
									ElseIf CUSTOMRG.IsOtherSteel(num) Then
										diameter = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(4096, StdInfoConstants.RodGradeConstants)).RodSizeList.Item(num4).Diameter
									ElseIf CUSTOMRG.IsOtherSinkerBar(num) Then
										diameter = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(StdInfoConstants.RodGradeConstants.teRodGradeAPISB_C).RodSizeList.Item(num4).Diameter
									End If
								End If
							Catch ex3 As Exception
							End Try
							If Me.ActiveControl Is Me.ulgTapers Or Me.ActiveControl Is Me.cboRodSize Then
								text = ""
								Dim flag2 As Boolean
								Dim flag3 As Boolean
								If Me.bUseStatus Then
									Dim quiet As Object = True
									Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("RodGrade").Value)
									Dim diameter2 As Object = diameter
									Dim flag As Boolean
									Dim obj As Object = flag
									Dim obj2 As Object = flag2
									Dim obj3 As Object = text
									Dim obj4 As Object = flag3
									RODUTIL.CheckRodsInTubing(quiet, objectValue, diameter2, obj, obj2, obj3, obj4, RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("RodNum").Value))
									flag3 = Conversions.ToBoolean(obj4)
									text = Conversions.ToString(obj3)
									flag2 = Conversions.ToBoolean(obj2)
									flag = Conversions.ToBoolean(obj)
									If Operators.CompareString(text, "", False) <> 0 Then
										Me.lblStatus.Text = " " + text.Trim()
									Else
										Me.lblStatus.Text = ""
									End If
								Else
									Dim quiet2 As Object = False
									Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("RodGrade").Value)
									Dim diameter3 As Object = diameter
									Dim flag As Boolean
									Dim obj4 As Object = flag
									Dim obj3 As Object = flag2
									Dim obj2 As Object = text
									Dim obj As Object = flag3
									RODUTIL.CheckRodsInTubing(quiet2, objectValue2, diameter3, obj4, obj3, obj2, obj, RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("RodNum").Value))
									flag3 = Conversions.ToBoolean(obj)
									text = Conversions.ToString(obj2)
									flag2 = Conversions.ToBoolean(obj3)
									flag = Conversions.ToBoolean(obj4)
								End If
								If flag2 AndAlso flag3 Then
									Me.bCheckRodsInTubingMsgShown = True
								End If
							End If
							If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								CtrlUI.ConvertValue(diameter, "m", False)
							End If
							If diameter = 0F Then
								ultraGridRow.Cells("RodDiam").Value = ""
							Else
								ultraGridRow.Cells("RodDiam").Value = diameter.ToString()
							End If
							If diameter <> 0F Then
								ini.SaveDataValue(Conversions.ToString(Operators.ConcatenateObject("RodDiam", ultraGridRow.Cells("RodNum").Value)), diameter)
							End If
						Catch ex4 As Exception
						End Try
						ultraGridRow = Nothing
					ElseIf Operators.CompareString(key, "RodDiam", False) = 0 Then
						If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(eventArgs.Cell.Value, "", False))) Then
							Dim sections2 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
							Dim num5 As Integer = Conversions.ToInteger(eventArgs.Cell.Row.Cells("RodNum").Value)
							Dim num6 As Single = Conversions.ToSingle(Convert.ToString(Convert.ToSingle(RuntimeHelpers.GetObjectValue(eventArgs.Cell.Value))))
							If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Me.txtTempDiam.Tag = "mmm"
								Me.txtTempDiam.Text = Conversions.ToString(num6)
								Dim textBox As TextBox = Me.txtTempDiam
								Dim lblTemp As Label = Me.lblTemp
								Me.TextBox_Change(textBox, lblTemp)
								Me.lblTemp = lblTemp
								Me.txtTempDiam = textBox
								num6 = Convert.ToSingle(Me.txtTempDiam.Text)
							End If
							sections2(num5).Diameter = num6
							sections2(num5).Area = CSng((CDbl((sections2(num5).Diameter * sections2(num5).Diameter)) * Math.Atan(1.0)))
							If Me.bUseStatus Then
								Dim quiet3 As Object = True
								Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(eventArgs.Cell.Row.Cells("RodGrade").Value)
								Dim diameter4 As Object = num6
								Dim flag As Boolean
								Dim obj4 As Object = flag
								Dim flag2 As Boolean
								Dim obj3 As Object = flag2
								Dim obj2 As Object = text
								Dim flag3 As Boolean
								Dim obj As Object = flag3
								RODUTIL.CheckRodsInTubing(quiet3, objectValue3, diameter4, obj4, obj3, obj2, obj, RuntimeHelpers.GetObjectValue(eventArgs.Cell.Row.Cells("RodNum").Value))
								flag3 = Conversions.ToBoolean(obj)
								text = Conversions.ToString(obj2)
								flag2 = Conversions.ToBoolean(obj3)
								flag = Conversions.ToBoolean(obj4)
								If Operators.CompareString(text, "", False) <> 0 Then
									Me.lblStatus.Text = " " + text.Trim()
								Else
									Me.lblStatus.Text = ""
								End If
							Else
								Dim quiet4 As Object = False
								Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(eventArgs.Cell.Row.Cells("RodGrade").Value)
								Dim diameter As Single
								Dim diameter5 As Object = diameter
								Dim flag As Boolean
								Dim obj4 As Object = flag
								Dim flag2 As Boolean
								Dim obj3 As Object = flag2
								Dim obj2 As Object = text
								Dim flag3 As Boolean
								Dim obj As Object = flag3
								RODUTIL.CheckRodsInTubing(quiet4, objectValue4, diameter5, obj4, obj3, obj2, obj, RuntimeHelpers.GetObjectValue(eventArgs.Cell.Row.Cells("RodNum").Value))
								flag3 = Conversions.ToBoolean(obj)
								text = Conversions.ToString(obj2)
								flag2 = Conversions.ToBoolean(obj3)
								flag = Conversions.ToBoolean(obj4)
							End If
						End If
					ElseIf Operators.CompareString(key, "RodLength", False) = 0 Then
						If eventArgs.Cell.Text Is Nothing Then
							ini.SaveDataValue("RodLength" + eventArgs.Cell.Row.Cells("RodNum").Value.ToString(), DBNull.Value)
							Me.lblStatus.Text = " " + Me.SEnterTaperLength
							Me.bLengthError = True
						ElseIf Not Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(eventArgs.Cell.Value)) Or Strings.InStr(eventArgs.Cell.Text, "-", CompareMethod.Binary) > 0 Then
							Dim text2 As String = Me.FindNonNumeric(eventArgs.Cell.Text)
							If Operators.CompareString(text2, "", False) <> 0 Then
								eventArgs.Cell.Value = eventArgs.Cell.Text.Replace(text2, "")
							End If
							Me.bLengthError = True
						ElseIf Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(eventArgs.Cell.Value)) Then
							Dim num7 As Single = Conversions.ToSingle(eventArgs.Cell.Value)
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.txtTempLength.Tag = "fmm"
								Me.txtTempLength.Text = num7.ToString()
								Dim textBox As TextBox = Me.txtTempLength
								Dim lblTemp As Label = Me.lblTemp
								Me.TextBox_Change(textBox, lblTemp)
								Me.lblTemp = lblTemp
								Me.txtTempLength = textBox
								num7 = Convert.ToSingle(Me.txtTempLength.Text)
							End If
							ini.SaveDataValue("RodLength" + eventArgs.Cell.Row.Cells("RodNum").Value.ToString(), num7)
							If num7 = 0F Then
								ini.SaveDataValue("RodLength" + eventArgs.Cell.Row.Cells("RodNum").Value.ToString(), DBNull.Value)
								Me.lblStatus.Text = " " + Me.SEnterTaperLength
								Me.bLengthError = True
							End If
							If Not Me.bLengthError Then
								Me.lblStatus.Text = ""
							End If
						End If
					ElseIf Operators.CompareString(key, "RodFrictionCoef", False) = 0 Then
						If RSWIN_DESC.bRodStarD Then
							Try
								Dim sections3 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
								Dim num8 As Integer = Conversions.ToInteger(eventArgs.Cell.Row.Cells("RodNum").Value)
								If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(eventArgs.Cell.Value)) Then
									sections3(num8).friction_coef = Conversions.ToSingle(eventArgs.Cell.Value)
									Dim num9 As Single
									If Util.IsPolyLined(RSWIN_DESC.rst.TubingID) And RSWIN_DESC.bReduceFricCoeff Then
										num9 = 0.1F
										Me.sRecommendedFricCoef = Me.sRecommendedFricCoef.Replace("0.2", num9.ToString())
									Else
										num9 = 0.2F
									End If
									If sections3(num8).friction_coef < num9 And Not Me.m_bRecommendedFricCoefShown Then
										If Me.bUseStatus Then
											Me.lblStatus.Text = " " + Me.sRecommendedFricCoef.Trim()
										Else
											MessageBox.Show(Me.sRecommendedFricCoef)
										End If
										Me.m_bRecommendedFricCoefShown = True
									End If
								Else
									sections3(num8).friction_coef = 0.2F
								End If
								ini.SaveDataValue("RODFrictionCoef" + eventArgs.Cell.Row.Cells("RodNum").Value.ToString(), sections3(num8).friction_coef)
								If sections3(num8).Guide > 0S Then
									Dim fricCoeff As Single = RODUTIL.GetFricCoeff(CInt(sections3(num8).Guide), True)
									If fricCoeff <> sections3(num8).friction_coef Then
										Me.lblStatus.Text = String.Concat(New String() { "The drag friction coefficient you entered (", Conversions.ToString(sections3(num8).friction_coef), ") is different than the one you entered in Setup for this type of rod guide (", Conversions.ToString(fricCoeff), ")." })
									End If
								End If
							Catch ex5 As Exception
							End Try
						End If
					ElseIf Operators.CompareString(key, "RodGuide", False) = 0 Then
						If Me.bShowGuides And RSWIN_DESC.bRodStarD Then
							Dim cell3 As UltraGridCell = eventArgs.Cell
							Dim num10 As Integer = Conversions.ToInteger(cell3.Value)
							Dim num2 As Long = Conversions.ToLong(cell3.Row.Cells("RodNum").Value)
							If num10 <> -1 Then
								RSWIN_DESC.rst.Sections(CInt(num2)).Guide = CShort(num10)
							End If
							cell3.Tag = Nothing
							ini.SaveDataValue("RodGuide" + num2.ToString(), num10)
							Try
								If num10 = 0 Then
									cell3.Row.Cells("NumGuides").Activation = Activation.Disabled
									cell3.Row.Cells("NumGuides").Appearance.BackColor = SystemColors.Control
									If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(cell3.Row.Cells("NumGuides").Value, 0, False))) Then
										cell3.Row.Cells("NumGuides").Value = 0
										RSWIN_DESC.rst.Sections(CInt(num2)).NumGuides = 0S
										ini.SaveDataValue("NumGuides" + num2.ToString(), 0)
									End If
								Else
									cell3.Row.Cells("NumGuides").Activation = Activation.AllowEdit
									cell3.Row.Cells("NumGuides").Appearance.BackColor = SystemColors.Window
								End If
							Catch ex6 As Exception
							End Try
						End If
					ElseIf Operators.CompareString(key, "NumGuides", False) = 0 AndAlso Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
						Dim ultraGridCell As UltraGridCell = eventArgs.Cell
						Dim num11 As Integer = Conversions.ToInteger(ultraGridCell.Value)
						Try
							If CDbl(num11) <> Conversion.Val(ultraGridCell.Text) Then
								num11 = CInt(Math.Round(Conversion.Val(ultraGridCell.Text)))
							End If
						Catch ex7 As Exception
						End Try
						Dim num2 As Long = Conversions.ToLong(ultraGridCell.Row.Cells("RodNum").Value)
						If num11 <> -1 Then
							RSWIN_DESC.rst.Sections(CInt(num2)).NumGuides = CShort(num11)
						End If
						ultraGridCell.Tag = Nothing
						ini.SaveDataValue("NumGuides" + num2.ToString(), num11)
						ultraGridCell = Nothing
					End If
					If Me.ActiveControl Is Me.ulgTapers Then
						Me.ValidateRSInput(Me.bFormLoaded, True, False)
					End If
					Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.ulgTapers)
					If Not Me.bInsideUpdateRS Then
						Me.UpdateRS()
					End If
				Catch ex8 As Exception
				End Try
			End If
		End Sub

		Private Function CheckRodgrade(iRodType As Integer) As Boolean
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
				If iRodType <> 0 And iRodType <> -1 Then
					Dim teRodGradeList As teRodGradeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().RodGradeLists().Item(RuntimeHelpers.GetObjectValue(Me.RodTypeConstant(iRodType)))
					Dim num As Integer = Conversions.ToInteger(activeCell.Row.Cells("RodGrade").Value)
					Try
						For Each obj As Object In teRodGradeList
							Dim dictionaryEntry As DictionaryEntry
							Dim teRodGrade As teRodGrade = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodGrade)
							If num = CInt(teRodGrade.RodGradeID) Then
								flag = True
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				result = flag
			Catch ex As Exception
				Dim sMsg As String = "Error in Before Edit CheckRodgrade(ByVal :" + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
			Return result
		End Function

		Private Sub ulgTapers_CellChange(eventSender As Object, eventArgs As CellEventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.lblStatus.Text = ""
			Me.bLengthError = False
			If Me.bF2Hit Then
				If Not(Operators.CompareString(eventArgs.Cell.Column.Key, "RodLength", False) = 0 And Me.btxtLengthHasFocus) Then
					Return
				End If
			End If
			Try
				Dim key As String = eventArgs.Cell.Column.Key
				If Operators.CompareString(key, "RodGrade", False) = 0 Then
					Dim cell As UltraGridCell = eventArgs.Cell
					Dim num As Integer = Conversions.ToInteger(cell.Value)
					cell.Tag = Nothing
					cell.Row.Cells("RodSize").Tag = Nothing
					Dim num2 As Long = Conversions.ToLong(cell.Row.Cells("RodNum").Value)
					ini.SaveDataValue("RodGrade" + num2.ToString(), RuntimeHelpers.GetObjectValue(cell.Value))
					Dim name As Object = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(Conversions.ToInteger(cell.Value), StdInfoConstants.RodGradeConstants)).Name
					ini.SaveDataValue("RodType" + num2.ToString(), RuntimeHelpers.GetObjectValue(name))
					Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
					Dim num3 As Integer = CInt(num2)
					sections(num3).Grade = CShort(num)
					sections(num3).RodType = Conversions.ToString(name)
				ElseIf Operators.CompareString(key, "RodSize", False) = 0 Then
					Dim cell2 As UltraGridCell = eventArgs.Cell
					Dim num4 As Integer = CInt(Conversions.ToLong(cell2.Value))
					Dim row As UltraGridRow = cell2.Row
					Dim num As Integer = Conversions.ToInteger(row.Cells("RodGrade").Value)
					Try
						Dim diameter As Single = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(num, StdInfoConstants.RodGradeConstants)).RodSizeList.Item(num4).Diameter
						If diameter = 0F Then
							row.Cells("RodDiam").Value = ""
						Else
							row.Cells("RodDiam").Value = diameter.ToString()
						End If
						ini.SaveDataValue(Conversions.ToString(Operators.ConcatenateObject("RodDiam", row.Cells("RodNum").Value)), diameter)
					Catch ex2 As Exception
					End Try
				ElseIf Operators.CompareString(key, "RodDiam", False) = 0 Then
					If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(eventArgs.Cell.Value, "", False))) Then
						Dim sections2 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
						Dim num5 As Integer = Conversions.ToInteger(eventArgs.Cell.Row.Cells("RodNum").Value)
						Dim num6 As Single = Conversions.ToSingle(Convert.ToString(Convert.ToSingle(RuntimeHelpers.GetObjectValue(eventArgs.Cell.Value))))
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							Me.txtTempDiam.Tag = "mmm"
							Me.txtTempDiam.Text = Conversions.ToString(num6)
							Dim txtTempDiam As TextBox = Me.txtTempDiam
							Dim lblTemp As Label = Me.lblTemp
							Me.TextBox_Change(txtTempDiam, lblTemp)
							Me.lblTemp = lblTemp
							Me.txtTempDiam = txtTempDiam
							num6 = Convert.ToSingle(Me.txtTempDiam.Text)
						End If
						sections2(num5).Diameter = num6
						sections2(num5).Area = CSng((CDbl((sections2(num5).Diameter * sections2(num5).Diameter)) * Math.Atan(1.0)))
					End If
				ElseIf Operators.CompareString(key, "RodFrictionCoef", False) = 0 Then
					If RSWIN_DESC.bRodStarD Then
						If eventArgs.Cell.Text IsNot Nothing Then
							Dim sections3 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
							Dim num7 As Integer = Conversions.ToInteger(eventArgs.Cell.Row.Cells("RodNum").Value)
							If Versioned.IsNumeric(eventArgs.Cell.Text) Then
								sections3(num7).friction_coef = Conversions.ToSingle(eventArgs.Cell.Text)
							End If
							ini.SaveDataValue("RODFrictionCoef" + eventArgs.Cell.Row.Cells("RodNum").Value.ToString(), sections3(num7).friction_coef)
							If sections3(num7).Guide > 0S Then
								Dim fricCoeff As Single = RODUTIL.GetFricCoeff(CInt(sections3(num7).Guide), True)
								If fricCoeff <> sections3(num7).friction_coef And Me.bFormLoaded Then
									Interaction.Beep()
									Me.lblStatus.Text = String.Concat(New String() { "The drag friction coefficient you entered (", Conversions.ToString(sections3(num7).friction_coef), ") is different than the one you entered in Setup for this type of rod guide (", Conversions.ToString(fricCoeff), ")." })
								End If
							End If
						End If
					End If
				ElseIf Operators.CompareString(key, "RodLength", False) = 0 Then
					Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
					Dim row2 As UltraGridRow = eventArgs.Cell.Row
					If eventArgs.Cell.Text IsNot Nothing Then
						Dim text As String = eventArgs.Cell.Text
						Dim cell3 As UltraGridCell = eventArgs.Cell
						Dim text2 As String = Me.CheckIfPositiveNumeric(text, cell3)
						If Operators.CompareString(text2.Trim(), eventArgs.Cell.Text.Trim(), False) <> 0 Then
							eventArgs.Cell.Value = Convert.ToSingle(text2)
						End If
					End If

						If eventArgs.Cell.Text Is Nothing Then
							eventArgs.Cell.Value = DBNull.Value
							Me.bValidated = False
							If Me.bUseStatus Then
								Me.lblStatus.Text = " " + Me.SEnterTaperLength.Trim()
							Else
								MessageBox.Show(Me.SEnterTaperLength)
							End If
							Me.bLengthError = True
						ElseIf Operators.CompareString(eventArgs.Cell.Text.Trim(), "", False) = 0 Then
							eventArgs.Cell.Value = DBNull.Value
							Me.bValidated = False
							If Me.bUseStatus Then
								Me.lblStatus.Text = " " + Me.SEnterTaperLength.Trim()
							Else
								MessageBox.Show(Me.SEnterTaperLength)
							End If
							Me.bLengthError = True
						ElseIf Not Versioned.IsNumeric(activeCell.Text) Then
							activeCell.Value = DBNull.Value
							Me.bLengthError = True
						ElseIf Strings.InStr(activeCell.Text, "-", CompareMethod.Binary) <> 0 Then
							activeCell.Value = DBNull.Value
							Me.bLengthError = True
						ElseIf Versioned.IsNumeric(activeCell.Text) Then
							Try
								If Information.IsDBNull(RuntimeHelpers.GetObjectValue(activeCell.Value)) Then
									activeCell.Value = Convert.ToSingle(activeCell.Text)
								ElseIf Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(activeCell.Value, Convert.ToSingle(activeCell.Text), False))) Then
									activeCell.Value = Convert.ToSingle(activeCell.Text)
								End If
							Catch ex3 As Exception
							End Try
							Try
								row2 = eventArgs.Cell.Row
								Dim ultraGridRow As UltraGridRow = Me.ulgTapers.GetRow(ChildRow.Last)
								If ultraGridRow.HasPrevSibling() Then
									Dim sibling As UltraGridRow = ultraGridRow.GetSibling(SiblingRow.Previous)
									If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLess(row2.Cells("RodNum").Value, RSWIN_DESC.rst.NumRods, False), Me.PreviousSectionsHaveLengths())) Then
										Dim num8 As Single = Me.tmp_PumpDepth
										ultraGridRow = Me.ulgTapers.GetRow(ChildRow.Last)
										While ultraGridRow.HasPrevSibling()
											ultraGridRow = ultraGridRow.GetSibling(SiblingRow.Previous)
											Dim ultraGridCell As UltraGridCell = ultraGridRow.Cells("RodLength")
											If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridCell.Value)) Then
												num8 = 0F
												Exit While
											End If
											If Operators.ConditionalCompareObjectLessEqual(ultraGridCell.Value, 0, False) Then
												num8 = 0F
												Exit While
											End If
											num8 = Conversions.ToSingle(Operators.SubtractObject(num8, ultraGridCell.Value))
										End While
										If num8 < 0F Then
											num8 = 0F
										End If
										If num8 >= 0F Then
											Dim ulgTapers As UltraGrid = Me.ulgTapers
											ulgTapers.EventManager.SetEnabled(GridEventIds.AfterCellUpdate, False)
											If ultraGridRow.HasNextSibling() Then
												Dim sibling2 As UltraGridRow = ultraGridRow.GetSibling(SiblingRow.Last)
												sibling2.Cells("RodLength").Value = num8
											End If
											ulgTapers.EventManager.SetEnabled(GridEventIds.AfterCellUpdate, True)
										End If
									End If
								End If
							Catch ex4 As Exception
							End Try
							Dim defaultRodLengthFromGrid As Single = Me.GetDefaultRodLengthFromGrid(True)
							Dim flag As Boolean = False
							If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
								If defaultRodLengthFromGrid > RSWIN_DESC.rst.PumpDepth + 1F Then
									flag = True
								End If
							ElseIf defaultRodLengthFromGrid > Me.tmp_PumpDepth + 1F Then
								flag = True
							End If
							If flag Then
								If Me.bUseStatus Then
									Me.lblStatus.Text = " " + Me.sTotalDepth
								Else
									MessageBox.Show(Me.sTotalDepth, Me.sDataEntryError)
								End If
								Me.bLengthError = True
								Me.SetStringLengthFromGrid()
							Else
								Me.bLengthError = False
								Me.ValidateRSInput(Me.bFormLoaded, True, False)
								Me.SetStringLengthFromGrid()
							End If
						End If

				ElseIf Operators.CompareString(key, "RodGuide", False) = 0 Then
					If RSWIN_DESC.bRodStarD Then
						Dim cell4 As UltraGridCell = eventArgs.Cell
						Dim guide As Short = Conversions.ToShort(cell4.Value)
						cell4.Tag = Nothing
						Dim num2 As Long = Conversions.ToLong(cell4.Row.Cells("RodNum").Value)
						ini.SaveDataValue("RodGuide" + num2.ToString(), RuntimeHelpers.GetObjectValue(cell4.Value))
						Dim sections4 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
						Dim num9 As Integer = CInt(num2)
						sections4(num9).Guide = guide
					End If
				ElseIf Operators.CompareString(key, "NumGuides", False) = 0 AndAlso RSWIN_DESC.bRodStarD Then
					Dim ultraGridCell2 As UltraGridCell = eventArgs.Cell
					Dim num10 As Short = Conversions.ToShort(ultraGridCell2.Value)
					Try
						If CDbl(num10) <> Conversion.Val(ultraGridCell2.Text) Then
							num10 = CShort(Math.Round(Conversion.Val(ultraGridCell2.Text)))
						End If
					Catch ex5 As Exception
					End Try
					ultraGridCell2.Tag = Nothing
					Dim num2 As Long = Conversions.ToLong(ultraGridCell2.Row.Cells("RodNum").Value)
					ini.SaveDataValue("NumGuides" + num2.ToString(), RuntimeHelpers.GetObjectValue(ultraGridCell2.Value))
					Dim sections5 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
					Dim num11 As Integer = CInt(num2)
					sections5(num11).NumGuides = num10
					If RSWIN_DESC.rst.Sections(CInt(num2)).Guide >= 6S Or RSWIN_DESC.rst.Sections(CInt(num2)).Guide < 4S Then
						RSWIN_DESC.iMinGuide = 3
					ElseIf RSWIN_DESC.rst.Sections(CInt(num2)).Guide >= 4S Then
						RSWIN_DESC.iMinGuide = 4
					Else
						RSWIN_DESC.iMinGuide = 3
					End If
					If CInt(num10) > RSWIN_DESC.iMaxGuide Then
						Dim text3 As String
						If RSWIN_DESC.rst.Sections(CInt(num2)).Guide < 4S Then
							text3 = String.Format(RSWIN_DESC.sGenericGuideMaxWarning, RSWIN_DESC.iMaxGuide)
						Else
							text3 = String.Format(RSWIN_DESC.sManufacturerGuideMaxWarning, RSWIN_DESC.iMaxGuide)
						End If
						Me.lblStatus.Text = text3
					ElseIf CInt(num10) < RSWIN_DESC.iMinGuide And RSWIN_DESC.rst.Sections(CInt(num2)).Guide > 0S Then
						Dim text3 As String
						If RSWIN_DESC.rst.Sections(CInt(num2)).Guide < 4S Then
							text3 = String.Format(RSWIN_DESC.sGenericGuideMinWarning, 3)
						Else
							text3 = String.Format(RSWIN_DESC.sManufacturerGuideMinWarning, RSWIN_DESC.iMinGuide)
						End If
						Me.lblStatus.Text = text3
					End If
					ultraGridCell2 = Nothing
				End If
			Catch ex6 As Exception
			End Try
		End Sub

		Private Sub ulgTapers_AfterRowActivate(eventSender As Object, eventArgs As EventArgs)
			Me.UpdateUI()
		End Sub

		Private Sub ulgTapers_AfterRowUpdate(sender As Object, e As RowEventArgs)
			Try
				Dim activeRow As UltraGridRow = Me.ulgTapers.ActiveRow
				Dim num As Integer = Conversions.ToInteger(activeRow.Cells("RodNum").Value)
				Me.ValidateRSInput(Me.bFormLoaded, True, False)
				Me.ulgTapers.Rows.Refresh(RefreshRow.RefreshDisplay, True)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.ulgTapers)
		End Sub

		Private Sub ulgTapers_AfterRowInsert(eventSender As Object, eventArgs As RowEventArgs)
			Try
				Dim ultraGridRow As UltraGridRow = eventArgs.Row
				Dim ultraGridRow2 As UltraGridRow = Me.ulgTapers.GetRow(ChildRow.First)
				While ultraGridRow2 IsNot Nothing
					Dim ultraGridCell As UltraGridCell = ultraGridRow2.Cells("RodNum")
					Try
						If Operators.ConditionalCompareObjectGreaterEqual(ultraGridCell.Value, Me.miNewRodNum, False) Then
							ultraGridCell.Value = Operators.AddObject(ultraGridCell.Value, 1)
						End If
					Catch ex As Exception
						ultraGridRow2.Cells("RodNum").Value = Me.miNewRodNum
					End Try
					If ultraGridRow2.HasNextSibling() Then
						ultraGridRow2 = ultraGridRow2.GetSibling(SiblingRow.[Next])
					Else
						ultraGridRow2 = Nothing
					End If
				End While
				ultraGridRow.Cells("RodNum").Value = Me.miNewRodNum
				Me.miNewRodNum = 0
				RSWIN_DESC.rst.NumRods = RSWIN_DESC.rst.NumRods + 1S
				ini.SaveDataValue("NumRods", RSWIN_DESC.rst.NumRods)
				Me.ResortGrid()
				Me.SelectRow(eventArgs.Row, False)
				eventArgs.Row.Activate()
				Me.UpdateUI()
				Me.ValidateRSInput(Me.bFormLoaded, True, False)
				Try
					Dim row As UltraGridRow = eventArgs.Row
					row.Selected = True
					Me.ulgTapers.ActiveRow = row
				Catch ex2 As Exception
				End Try
				ultraGridRow = Nothing
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub cmdMoveSectionDown_Click(eventSender As Object, eventArgs As EventArgs)
			Dim flag As Boolean = Me.m_iCurrentRodSection >= 1 And Me.m_iCurrentRodSection < CInt(RSWIN_DESC.rst.NumRods)
			If flag Then
				Debug.Assert(Me.ulgTapers.ActiveRow IsNot Nothing, "")
				Debug.Assert(Me.ulgTapers.ActiveRow.HasNextSibling(), "")
				Dim activeRow As UltraGridRow = Me.ulgTapers.ActiveRow
				Dim sibling As UltraGridRow = activeRow.GetSibling(SiblingRow.[Next])
				Dim num As Short = Conversions.ToShort(activeRow.Cells("RodNum").Value)
				Dim num2 As Short = num + 1S
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				Try
					For Each obj As Object In Me.mdsRodTapers.Tables(0).Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow("RodNum"), num2, False), Not flag2)) Then
							dataRow("RodNum") = num
							flag2 = True
						ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow("RodNum"), num, False), Not flag3)) Then
							dataRow("RodNum") = num2
							flag3 = True
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Dim ulgTapers As UltraGrid = Me.ulgTapers
				ulgTapers.DataSource = Nothing
				ulgTapers.DataSource = Me.mdsRodTapers
				Me.ResortGrid()
				Me.MakeRowActive(CInt(num2))
				Return
			End If
			MessageBox.Show(Me.sCannotMoveDown, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		Private Sub SelectRow(Row As UltraGridRow, Optional ActivateRow As Boolean = False)
			Try
				If ActivateRow Then
					Row.Selected = True
					Row.Activated = True
				Else
					Row.Activated = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub MakeRowActive(miNewEntryNum As Integer)
			Try
				' The following expression was wrapped in a checked-expression
				Dim ultraGridRow As UltraGridRow = Me.ulgTapers.Rows(miNewEntryNum - 1)
				If ultraGridRow IsNot Nothing Then
					Me.SelectRow(ultraGridRow, True)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs)
			Try
				e.DisplayPromptMsg = False
				If Me.bDisplayDeleteMessage Then
					Dim obj As Object = MessageBox.Show(Me.sARSRemoveSelected, Me.sDeleteRow, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					If Operators.ConditionalCompareObjectEqual(obj, DialogResult.No, False) Then
						e.Cancel = True
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_AfterRowsDeleted(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim ultraGridRow As UltraGridRow
				Try
					ultraGridRow = Me.ulgTapers.GetRow(ChildRow.First)
				Catch ex As Exception
				End Try
				If ultraGridRow IsNot Nothing Then
					While ultraGridRow IsNot Nothing
						num += 1
						ultraGridRow.Cells("RodNum").Value = num
						If ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							ultraGridRow = Nothing
						End If
					End While
				End If
				RSWIN_DESC.rst.NumRods = CShort(num)
				ini.SaveDataValue("NumRods", RSWIN_DESC.rst.NumRods)
				Me.UpdateUI()
				Me.ValidateRSInput(Me.bFormLoaded, True, False)
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub ulgTapers_BeforeCellDeactivate(eventSender As Object, eventArgs As CancelEventArgs)
			Try
				Dim control As Control = Me.cboRodGrade
				Me.HideControl(control)
				Me.cboRodGrade = CType(control, ComboBox)
				control = Me.cboRodSize
				Me.HideControl(control)
				Me.cboRodSize = CType(control, ComboBox)
				If Me.bShowGuides Then
					control = Me.cboRodGuides
					Me.HideControl(control)
					Me.cboRodGuides = CType(control, ComboBox)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_BeforeColRegionScroll(eventSender As Object, eventArgs As BeforeColRegionScrollEventArgs)
			Try
				Dim control As Control = Me.cboRodGrade
				Me.HideControl(control)
				Me.cboRodGrade = CType(control, ComboBox)
				control = Me.cboRodSize
				Me.HideControl(control)
				Me.cboRodSize = CType(control, ComboBox)
				control = Me.txtLength
				Me.HideControl(control)
				Me.txtLength = CType(control, TextBox)
				If Me.bShowGuides Then
					control = Me.cboRodGuides
					Me.HideControl(control)
					Me.cboRodGuides = CType(control, ComboBox)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_BeforeEnterEditMode(sender As Object, e As CancelEventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Me.bEnterEditmode = True
				Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
				Me.iCurrentRodNum = Conversions.ToInteger(activeCell.Row.Cells("RodNum").Value)
				Me.MyParentFrm.ToolbarButtonSetState2(2, False)
				If activeCell IsNot Nothing Then
					Dim uielement As UIElement = activeCell.GetUIElement(Me.ulgTapers.ActiveRowScrollRegion, Me.ulgTapers.ActiveColScrollRegion)
					If uielement IsNot Nothing Then
						Dim cellUIElement As CellUIElement = CType(uielement, CellUIElement)
						If cellUIElement IsNot Nothing Then
							Dim x As Integer = cellUIElement.RectInsideBorders.Location.X + Me.ulgTapers.Location.X
							Dim y As Integer = cellUIElement.RectInsideBorders.Location.Y + Me.ulgTapers.Location.Y
							Dim width As Integer = cellUIElement.RectInsideBorders.Width
							Dim height As Integer = cellUIElement.RectInsideBorders.Height
							Me.CurrentColumn = activeCell.Column.Key
							If Operators.CompareString(activeCell.Column.Key, "RodGuide", False) = 0 And Me.bShowGuides Then
								If Not Me.BeforeEditRodGuide() Then
									MessageBox.Show("Please select Rod Guide.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Else
									Me.cboRodGuides.SetBounds(x, y, width, height)
									Me.cboRodGuides.Visible = True
									Dim control As Control = Me.cboRodGuides
									Me.SetActiveControl(control)
									Me.cboRodGuides = CType(control, ComboBox)
								End If
							ElseIf Operators.CompareString(activeCell.Column.Key, "RodGrade", False) = 0 Then
								Me.ContextMenu1.MenuItems.Clear()
								If Not Me.BeforeEditRodgrade() Then
									MessageBox.Show("Please select Rod Type before Rod Grade.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Else
									Me.cboRodGrade.SetBounds(x, y, width, height)
									Me.cboRodGrade.Visible = True
									Dim control As Control = Me.cboRodGrade
									Me.SetActiveControl(control)
									Me.cboRodGrade = CType(control, ComboBox)
								End If
							ElseIf Operators.CompareString(activeCell.Column.Key, "RodFrictionCoef", False) = 0 Then
								Dim row As UltraGridRow = activeCell.Row
								Dim iRow As Integer = Conversions.ToInteger(row.Cells("RodNum").Value)
								Dim num As Integer = Conversions.ToInteger(row.Cells("RodGuide").Value)
								Dim num2 As Single = Conversions.ToSingle(row.Cells("RodFrictionCoef").Value)
								If num > 0 Then
									Dim fricCoeff As Single = RODUTIL.GetFricCoeff(num, True)
									If num2 <> fricCoeff And Me.bFormLoaded Then
										Interaction.Beep()
										Me.lblStatus.Text = String.Concat(New String() { "The drag friction coefficient you entered (", Conversions.ToString(num2), ") is different than the one you entered in Setup for this type of rod guide (", Conversions.ToString(fricCoeff), ")." })
									End If
								End If
							ElseIf Operators.CompareString(activeCell.Column.Key, "RodSize", False) = 0 Then
								Me.ContextMenu1.MenuItems.Clear()
								Dim row As UltraGridRow = activeCell.Row
								Dim iRow As Integer = Conversions.ToInteger(row.Cells("RodNum").Value)
								Dim objectValue As Object = RuntimeHelpers.GetObjectValue(row.Cells("RodDiam").Value)
								Dim sDiamValue As String
								If objectValue Is Nothing Or Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
									sDiamValue = ""
								Else
									sDiamValue = Convert.ToString(RuntimeHelpers.GetObjectValue(objectValue))
								End If
								If Not Me.BeforeEditRodSize(iRow, sDiamValue) Then
									If Me.bUseStatus Then
										Me.lblStatus.Text = " " + Me.sGradeBeforeSize.Trim()
									Else
										MessageBox.Show(Me.sGradeBeforeSize, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									End If
								Else
									Me.cboRodSize.SetBounds(x, y, width, height)
									Me.cboRodSize.Visible = True
									Dim control As Control = Me.cboRodSize
									Me.SetActiveControl(control)
									Me.cboRodSize = CType(control, ComboBox)
								End If
							ElseIf Operators.CompareString(activeCell.Column.Key, "RodLength", False) = 0 Then
								Me.ContextMenu1.MenuItems.Clear()
								Me.ContextMenu1.MenuItems.Add(New MenuItem("Adjust length to match pump depth.", AddressOf Me.ContextMenu1_Clicked))
							End If
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_BeforeExitEditMode(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs)
			Dim str As String = ""
			Dim flag As Boolean = False
			Me.PreviousColumn = Me.CurrentColumn
			If Me.bF2Hit Then
				Return
			End If
			Try
				Me.bEnterEditmode = False
				Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
				Dim obj As Object
				If activeCell IsNot Nothing Then
					If Versioned.IsNumeric(activeCell.Text) Then
						Me.txtTempLength.Tag = "fem"
						Me.txtTempLength.Text = activeCell.Text
						flag = CtrlUI.CheckValid(Me.txtTempLength, False, False, obj)
						Me.txtTempLength.Text = ""
					ElseIf Operators.CompareString(activeCell.Text, "", False) = 0 And Operators.CompareString(activeCell.Column.Key, "RodLength", False) = 0 Then
						If Me.bUseStatus Then
							Me.lblStatus.Text = " " + Me.SEnterTaperLength
							Me.bLengthError = True
						End If
					End If
				ElseIf Me.bUseStatus And Operators.CompareString(activeCell.Column.Key, "RodLength", False) = 0 Then
					Me.lblStatus.Text = " " + Me.SEnterTaperLength
					Me.bLengthError = True
				End If
				Dim flag2 As Boolean = True
				If flag2 <> (activeCell Is Nothing) Then
					If flag2 <> (Operators.CompareString(activeCell.Column.Key, "RodLength", False) <> 0) Then
						If flag2 <> Not Versioned.IsNumeric(activeCell.Text) Then
							If Operators.ConditionalCompareObjectEqual(flag2, Operators.AndObject(Operators.AndObject(flag, Operators.NotObject(Util.CheckLower(obj, 25F, -1, 49, -1, -1, True, str))), Operators.CompareObjectGreater(obj, 0, False)), False) Then
								If Me.bUseStatus Then
									Me.lblStatus.Text = " " + str
								Else
									Util.CheckLower(obj, 25F, -1, 49, -1, -1, False, str)
								End If
								Me.bLengthError = True
							ElseIf Operators.ConditionalCompareObjectEqual(flag2, Operators.AndObject(flag, Operators.CompareObjectLess(obj, 100, False)), False) Then
								Me.lblStatus.Text = Conversions.ToString(Operators.ConcatenateObject(" ", Interaction.IIf(RSWIN_DESC.bRodStarD, Me.sSmallLengthD, Me.sSmallLengthV)))
								Me.bLengthError = True
							ElseIf Not Me.bLengthError Then
								Me.lblStatus.Text = ""
							End If
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_BeforeRowRegionScroll(eventSender As Object, eventArgs As BeforeRowRegionScrollEventArgs)
			Try
				Dim control As Control = Me.cboRodGrade
				Me.HideControl(control)
				Me.cboRodGrade = CType(control, ComboBox)
				control = Me.cboRodSize
				Me.HideControl(control)
				Me.cboRodSize = CType(control, ComboBox)
				control = Me.txtLength
				Me.HideControl(control)
				Me.txtLength = CType(control, TextBox)
				If Me.bShowGuides Then
					control = Me.cboRodGuides
					Me.HideControl(control)
					Me.cboRodGuides = CType(control, ComboBox)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_BeforeCellListDropDown(sender As Object, e As CancelableCellEventArgs)
			Try
				If Operators.CompareString(Me.CurrentColumn, "RodGrade", False) = 0 Then
					e.Cancel = True
					Me.cboRodGrade.DroppedDown = True
				ElseIf Operators.CompareString(Me.CurrentColumn, "RodSize", False) = 0 Then
					e.Cancel = True
					Me.cboRodSize.DroppedDown = True
				ElseIf Operators.CompareString(Me.CurrentColumn, "RodGuide", False) = 0 And RSWIN_DESC.bRodStarD Then
					e.Cancel = True
					Me.cboRodGuides.DroppedDown = True
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_KeyDown(sender As Object, e As KeyEventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
				Dim row As UltraGridRow = activeCell.Row
				Dim uielement As UIElement = activeCell.GetUIElement(Me.ulgTapers.ActiveRowScrollRegion, Me.ulgTapers.ActiveColScrollRegion)
				Dim cellUIElement As CellUIElement = CType(uielement, CellUIElement)
				Dim x As Integer = cellUIElement.RectInsideBorders.Location.X + Me.ulgTapers.Location.X
				Dim y As Integer = cellUIElement.RectInsideBorders.Location.Y + Me.ulgTapers.Location.Y
				Dim width As Integer = cellUIElement.RectInsideBorders.Width
				Dim height As Integer = cellUIElement.RectInsideBorders.Height
				If e.KeyCode = Keys.F2 Then
					Dim ultraGridCell As UltraGridCell = activeCell
					Me.bF2Hit = True
					Me.btxtLengthHasFocus = False
					Me.ThisF2Cell = activeCell
					Me.ThisF2Row = row
					Dim caption As Object = ultraGridCell.Column.Header.Caption
					If Strings.InStr(Conversions.ToString(caption), "Length", CompareMethod.Binary) > 0 Then
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							Me.txtLength.Tag = "fem"
							If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(ultraGridCell.Value)) Then
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Me.txtLength.Text = Conversions.ToString(ultraGridCell.Value)
								Else
									Me.txtLength.Text = Conversions.ToString(Operators.MultiplyObject(ultraGridCell.Value, 1F / RSWIN_DESC.FT__M))
								End If
							End If
						Else
							Me.txtLength.Tag = "fmm"
							If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(ultraGridCell.Value)) Then
								If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
									Me.txtLength.Text = Conversions.ToString(ultraGridCell.Value)
								Else
									Me.txtLength.Text = Conversions.ToString(Operators.MultiplyObject(ultraGridCell.Value, RSWIN_DESC.FT__M))
								End If
							End If
						End If
						Dim txtLength As TextBox = Me.txtLength
						Dim label_Length As Label = Me._Label_Length
						CtrlUI.TextBox_KeyDown(txtLength, label_Length, 113, 0)
						Me._Label_Length = label_Length
						Me.txtLength = txtLength
						Me.txtLength.SetBounds(x, y, width, height)
						Me.txtLength.Visible = True
						Dim txtLength2 As Control = Me.txtLength
						Me.SetActiveControl(txtLength2)
						Me.txtLength = CType(txtLength2, TextBox)
					End If
				ElseIf e.KeyCode = Keys.F1 Then
					Dim ultraGridCell2 As UltraGridCell = activeCell
					Dim caption As Object = ultraGridCell2.Column.Header.Caption
					Dim text As String
					If Strings.InStr(Conversions.ToString(caption), "Length", CompareMethod.Binary) > 0 Then
						text = "rod section length"
						Application.DoEvents()
					ElseIf Strings.InStr(Conversions.ToString(caption), "Rod Grade", CompareMethod.Binary) > 0 Then
						text = "rod section grade"
						Application.DoEvents()
					ElseIf Strings.InStr(Conversions.ToString(caption), "Rod Size", CompareMethod.Binary) > 0 Then
						text = "rod section diameter"
						Application.DoEvents()
					ElseIf Strings.InStr(Conversions.ToString(caption), "Rod Type", CompareMethod.Binary) > 0 Then
						text = "rod section type"
						Application.DoEvents()
					Else
						text = ""
						Application.DoEvents()
					End If
					If Operators.CompareString(text, "", False) <> 0 Then
						Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.KeywordIndex, text)
						Application.DoEvents()
						If Me.ActiveControl Is Me.ulgTapers Then
							Me.txtLength.Focus()
							Application.DoEvents()
							Me.ulgTapers.Focus()
							Application.DoEvents()
						End If
					End If
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub ulgTapers_InitializeLayout(eventSender As Object, eventArgs As InitializeLayoutEventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				Dim layout As UltraGridLayout = eventArgs.Layout
				layout.TabNavigation = TabNavigation.NextCell
				Dim ultraGridBand As UltraGridBand = layout.Bands(0)
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns("RodNum")
				ultraGridColumn.Header.Caption = "#"
				ultraGridColumn.Width = 27
				ultraGridColumn.Tag = ""
				ultraGridColumn.CellActivation = Activation.ActivateOnly
				Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns("RodGrade")
				ultraGridColumn2.Header.Caption = Me.sRodGrade
				ultraGridColumn2.ValueList = Me.ulgTapers.DisplayLayout.ValueLists("VLRodGrades")
				ultraGridColumn2.Width = 235
				ultraGridColumn2.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn2.Tag = ""
				ultraGridColumn2.Header.Fixed = True
				ultraGridColumn2.CellActivation = Activation.ActivateOnly
				Dim ultraGridColumn3 As UltraGridColumn = ultraGridBand.Columns("RodSize")
				ultraGridColumn3.Header.Caption = Me.sRodSize + " (" + RSWIN_DESC.inch + ")"
				ultraGridColumn3.Width = 157
				ultraGridColumn3.ValueList = Me.ulgTapers.DisplayLayout.ValueLists("VLRodSizes")
				ultraGridColumn3.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn3.Tag = ""
				ultraGridColumn3.CellActivation = Activation.ActivateOnly
				Dim ultraGridColumn4 As UltraGridColumn = ultraGridBand.Columns("RodDiam")
				ultraGridColumn4.Header.Caption = Me.sActualRodDiameter
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					ultraGridColumn4.Header.Caption = Me.sActualRodDiameter + " (" + RSWIN_DESC.inch + ")"
				ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					ultraGridColumn4.Header.Caption = Me.sActualRodDiameter + " (" + RSWIN_DESC.mm + ")"
				End If
				ultraGridColumn4.Width = 112
				ultraGridColumn4.Tag = ""
				Dim ultraGridColumn5 As UltraGridColumn = ultraGridBand.Columns("RodLength")
				ultraGridColumn5.Width = 90
				ultraGridColumn5.Header.Caption = Me.sRodLength
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					ultraGridColumn5.Header.Caption = Me.sRodLength + " (" + RSWIN_DESC.ft + ")"
				ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					ultraGridColumn5.Header.Caption = Me.sRodLength + " (" + RSWIN_DESC.m + ")"
				End If
				ultraGridColumn5.Tag = "Length (^)" & vbLf & "fem"
				If RSWIN_DESC.bRodStarD AndAlso Me.bShowGuides Then
					Dim ultraGridColumn6 As UltraGridColumn = ultraGridBand.Columns("RodGuide")
					ultraGridColumn6.Header.Caption = "Guide"
					ultraGridColumn6.ValueList = Me.ulgTapers.DisplayLayout.ValueLists("VLSWGuides")
					ultraGridColumn6.Width = 158
					ultraGridColumn6.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
					ultraGridColumn6.Tag = ""
					ultraGridColumn6.CellActivation = Activation.ActivateOnly
				End If
				If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_ALLOWSLIDEFRIC) <> 0S Then
					Dim ultraGridColumn7 As UltraGridColumn = ultraGridBand.Columns("RodFrictionCoef")
					ultraGridColumn7.Width = 110
					ultraGridColumn7.Header.Caption = "* Drag Fric Coeff"
					ultraGridColumn7.Tag = "Drag Fric Coeff"
					Me.lblFricFootnote.Visible = True
				Else
					Me.lblFricFootnote.Visible = False
				End If
				If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bRodStarD Then
					Dim ultraGridColumn8 As UltraGridColumn = ultraGridBand.Columns("NumGuides")
					ultraGridColumn8.Header.Caption = Me.sNumGuides
					ultraGridColumn8.Width = 100
					ultraGridColumn8.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
					ultraGridColumn8.Tag = ""
				End If
				Dim ultraGrid As UltraGrid = Me.ulgTapers
				Try
					ultraGrid.ActiveRow = ultraGrid.GetRow(ChildRow.First)
				Catch ex2 As Exception
				End Try
				Dim ultraGridBand2 As UltraGridBand = ultraGrid.DisplayLayout.Bands(0)
				ultraGridBand2.SortedColumns.Add(ultraGridBand2.Columns("RodNum"), False)
				ultraGrid.DisplayLayout.TabNavigation = TabNavigation.NextCell
				Dim override As UltraGridOverride = ultraGrid.DisplayLayout.Override
				override.AllowColMoving = AllowColMoving.NotAllowed
				override.AllowColSizing = AllowColSizing.None
				override.AllowColSwapping = AllowColSwapping.NotAllowed
				override.BorderStyleCell = UIElementBorderStyle.InsetSoft
				override.BorderStyleRow = UIElementBorderStyle.RaisedSoft
				override.RowSelectors = DefaultableBoolean.[False]
				override.RowSizing = RowSizing.Fixed
				override.SelectTypeCell = SelectType.[Single]
				override.SelectTypeCol = SelectType.None
				override.SelectTypeRow = SelectType.[Single]
				override.ActiveRowAppearance.BorderColor = SystemColors.Highlight
				override.ActiveRowAppearance.BorderColor3DBase = SystemColors.Highlight
				override.ActiveCellAppearance.BackColor = Color.Cyan
				override.ActiveCellAppearance.ForeColor = Color.Black
				ultraGrid = Nothing
				Me.bEnterEditmode = False
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub ulgTapers_AfterCellActivate(sender As Object, e As EventArgs)
			Try
				Dim ulgTapers As UltraGrid = Me.ulgTapers
				Dim iCurrentRodSection As Integer
				If ulgTapers.ActiveRow Is Nothing Then
					iCurrentRodSection = 0
				ElseIf Information.IsDBNull(RuntimeHelpers.GetObjectValue(ulgTapers.ActiveRow.Cells("RodNum").Value)) Then
					iCurrentRodSection = 0
				Else
					iCurrentRodSection = Conversions.ToInteger(ulgTapers.ActiveRow.Cells("RodNum").Value)
				End If
				If RSWIN_DESC.rst.RodStringType <> 3S Then
					Me.btnNumberOfRods.Enabled = True
					Me.cmdAddSection.Enabled = True
					Me.cmdDelSection.Enabled = True
					Me.cmdMoveSectionUp.Enabled = True
					Me.cmdMoveSectionDown.Enabled = True
					Me.btnNumberOfRods.Visible = True
					Me.cmdAddSection.Visible = True
					Me.cmdDelSection.Visible = True
					Me.cmdMoveSectionUp.Visible = True
					Me.cmdMoveSectionDown.Visible = True
					Me._Line_0.Visible = True
					Me.m_iCurrentRodSection = iCurrentRodSection
				Else
					Me.btnNumberOfRods.Enabled = False
					Me.cmdAddSection.Enabled = False
					Me.cmdDelSection.Enabled = False
					Me.cmdMoveSectionUp.Enabled = False
					Me.cmdMoveSectionDown.Enabled = False
					Me.btnNumberOfRods.Visible = False
					Me.cmdAddSection.Visible = False
					Me.cmdDelSection.Visible = False
					Me.cmdMoveSectionUp.Visible = False
					Me.cmdMoveSectionDown.Visible = False
					Me._Line_0.Visible = False
				End If
				Try
					Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
					Me.ulgTapers.ActiveRow = activeCell.Row
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub ulgTapers_AfterRowActivate_2(sender As Object, e As EventArgs)
			Try
				Dim ulgTapers As UltraGrid = Me.ulgTapers
				Dim iCurrentRodSection As Integer
				If ulgTapers.ActiveRow Is Nothing Then
					iCurrentRodSection = 0
				ElseIf Information.IsDBNull(RuntimeHelpers.GetObjectValue(ulgTapers.ActiveRow.Cells("RodNum").Value)) Then
					iCurrentRodSection = 0
				Else
					iCurrentRodSection = Conversions.ToInteger(ulgTapers.ActiveRow.Cells("RodNum").Value)
				End If
				If RSWIN_DESC.rst.RodStringType <> 3S Then
					Me.btnNumberOfRods.Enabled = True
					Me.cmdAddSection.Enabled = True
					Me.cmdDelSection.Enabled = True
					Me.cmdMoveSectionUp.Enabled = True
					Me.cmdMoveSectionDown.Enabled = True
					Me.btnNumberOfRods.Visible = True
					Me.cmdAddSection.Visible = True
					Me.cmdDelSection.Visible = True
					Me.cmdMoveSectionUp.Visible = True
					Me.cmdMoveSectionDown.Visible = True
					Me._Line_0.Visible = True
					Me.m_iCurrentRodSection = iCurrentRodSection
				Else
					Me.btnNumberOfRods.Enabled = False
					Me.cmdAddSection.Enabled = False
					Me.cmdDelSection.Enabled = False
					Me.cmdMoveSectionUp.Enabled = False
					Me.cmdMoveSectionDown.Enabled = False
					Me.btnNumberOfRods.Visible = False
					Me.cmdAddSection.Visible = False
					Me.cmdDelSection.Visible = False
					Me.cmdMoveSectionUp.Visible = False
					Me.cmdMoveSectionDown.Visible = False
					Me._Line_0.Visible = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_InitializeRow(eventSender As Object, eventArgs As InitializeRowEventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Dim row As UltraGridRow = eventArgs.Row
			Dim ultraGridCell As UltraGridCell = row.Cells("RodGrade")
			Dim num As Integer
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridCell.Value)) Then
				num = Conversions.ToInteger(ultraGridCell.Value)
			End If
			Dim ultraGridCell2 As UltraGridCell = row.Cells("RodSize")
			Dim num2 As Integer
			If num = 0 Then
				num2 = 0
			ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridCell2.Value)) Then
				num2 = Conversions.ToInteger(ultraGridCell2.Value)
			Else
				num2 = 0
			End If
			Dim ultraGridCell3 As UltraGridCell = row.Cells("RodDiam")
			If Not(num <> 0 And num2 = 0) Then
				ultraGridCell3.Activation = Activation.Disabled
				ultraGridCell3.Appearance.BackColor = SystemColors.Control
			ElseIf num2 = 0 Then
				ultraGridCell3.Activation = Activation.AllowEdit
				ultraGridCell3.Appearance.BackColor = SystemColors.Window
			End If
			If RSWIN_DESC.bRodStarD Then
				Dim ultraGridCell4 As UltraGridCell = row.Cells("RodGuide")
				Dim num3 As Integer = Conversions.ToInteger(ultraGridCell4.Value)
				Try
					If num3 = 0 Then
						ultraGridCell4.Row.Cells("NumGuides").Activation = Activation.Disabled
						ultraGridCell4.Row.Cells("NumGuides").Appearance.BackColor = SystemColors.Control
					Else
						ultraGridCell4.Row.Cells("NumGuides").Activation = Activation.AllowEdit
						ultraGridCell4.Row.Cells("NumGuides").Appearance.BackColor = SystemColors.Window
					End If
				Catch ex2 As Exception
				End Try
			End If
		End Sub

		Private Sub ulgTapers_MouseDownEvent(eventSender As Object, e As MouseEventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				Me.mfMouseDownX = CSng(e.X)
				Me.mfMouseDownY = CSng(e.Y)
				If e.Button = MouseButtons.Left Then
					Me.mousePoint = New Point(e.X, e.Y)
				End If
				If e.Button = MouseButtons.Right AndAlso Me.ContextMenu1.MenuItems.Count > 0 Then
					Me.ContextMenu1.Show(Me.ulgTapers, Me.mousePoint)
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub HideEditControls()
			Try
				Me.cboRodGrade.Visible = False
				Me.cboRodSize.Visible = False
				Me.txtLength.Visible = False
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_AfterColPosChanged(sender As Object, e As AfterColPosChangedEventArgs)
			Me.HideEditControls()
		End Sub

		Private Sub ulgTapers_AfterColRegionScroll(sender As Object, e As ColScrollRegionEventArgs)
			Me.HideEditControls()
		End Sub

		Private Sub ulgTapers_AfterColRegionSize(sender As Object, e As ColScrollRegionEventArgs)
			Me.HideEditControls()
		End Sub

		Private Sub ulgTapers_AfterRowRegionScroll(sender As Object, e As RowScrollRegionEventArgs)
			Me.HideEditControls()
		End Sub

		Private Sub ulgTapers_AfterRowRegionSize(sender As Object, e As RowScrollRegionEventArgs)
			Me.HideEditControls()
		End Sub

		Private Sub ulgTapers_AfterRowResize(sender As Object, e As RowEventArgs)
			Me.HideEditControls()
		End Sub

		Private Function GetHashValue(myList As Hashtable, HashKey As Integer) As Object
			Dim enumerator As IDictionaryEnumerator = myList.GetEnumerator()
			While enumerator.MoveNext()
				If Operators.ConditionalCompareObjectEqual(enumerator.Key, HashKey, False) Then
					Return enumerator.Value
				End If
			End While
			Dim result As Object
			Return result
		End Function

		Private Sub UpdateUI()
			Dim selectedIndex As Integer = Me.tbsRodDesignType.SelectedIndex
			Select Case selectedIndex
				Case 0
				Case 1
					If Me.chkRSFGIncludeSteel.Top < 0 Then
						Me.chkRSFGIncludeSteel.Top = Me.chkRSFGIncludeSteel.Top + Me.mcySteelDesignInfoOffset
						Me.ctrSteelDesign.Height = Conversions.ToInteger(Me.ctrSteelDesign.Tag)
						Me.fraSteelDesign.SetBounds(0, 0, Me.ctrSteelDesign.Width, 0, BoundsSpecified.X Or BoundsSpecified.Y Or BoundsSpecified.Width)
					End If
					Try
						Me.chkRSIncludeSB.Enabled = (Me.cboRSFGGrade.SelectedIndex >= 0)
						GoTo IL_127
					Catch ex As Exception
						GoTo IL_127
					End Try
				Case Else
					GoTo IL_127
			End Select
			If Me.chkRSFGIncludeSteel.Top >= 0 Then
				Me.chkRSFGIncludeSteel.Top = Me.chkRSFGIncludeSteel.Top - Me.mcySteelDesignInfoOffset
				Me.ctrSteelDesign.Height = Me.fraSteelDesign.Top + Me.fraSteelDesign.Height
			End If
			Try
				Me.chkRSIncludeSB.Enabled = (Me.cboRSGrade.SelectedIndex >= 0)
			Catch ex2 As Exception
			End Try
			IL_127:
			If selectedIndex <> 3 Then
				Return
			End If
			Dim ulgTapers As UltraGrid = Me.ulgTapers
			Dim iCurrentRodSection As Integer
			If ulgTapers.ActiveRow Is Nothing Then
				iCurrentRodSection = 0
			ElseIf Information.IsDBNull(RuntimeHelpers.GetObjectValue(ulgTapers.ActiveRow.Cells("RodNum").Value)) Then
				iCurrentRodSection = 0
			Else
				iCurrentRodSection = Conversions.ToInteger(ulgTapers.ActiveRow.Cells("RodNum").Value)
			End If
			If RSWIN_DESC.rst.RodStringType <> 3S Then
				Me.btnNumberOfRods.Enabled = True
				Me.cmdAddSection.Enabled = True
				Me.cmdDelSection.Enabled = True
				Me.cmdMoveSectionUp.Enabled = True
				Me.cmdMoveSectionDown.Enabled = True
				Me.btnNumberOfRods.Visible = True
				Me.cmdAddSection.Visible = True
				Me.cmdDelSection.Visible = True
				Me.cmdMoveSectionUp.Visible = True
				Me.cmdMoveSectionDown.Visible = True
				Me._Line_0.Visible = True
				Me.m_iCurrentRodSection = iCurrentRodSection
			Else
				Me.btnNumberOfRods.Enabled = False
				Me.cmdAddSection.Enabled = False
				Me.cmdDelSection.Enabled = False
				Me.cmdMoveSectionUp.Enabled = False
				Me.cmdMoveSectionDown.Enabled = False
				Me.btnNumberOfRods.Visible = False
				Me.cmdAddSection.Visible = False
				Me.cmdDelSection.Visible = False
				Me.cmdMoveSectionUp.Visible = False
				Me.cmdMoveSectionDown.Visible = False
				Me._Line_0.Visible = False
			End If
		End Sub

		Private Sub cmdDelSection_Click(eventSender As Object, eventArgs As EventArgs)
			Try
				If RSWIN_DESC.rst.NumRods <> 0S Then
					Dim flag As Boolean = 1 <= Me.m_iCurrentRodSection And Me.m_iCurrentRodSection <= CInt(RSWIN_DESC.rst.NumRods)
					If flag Then
						Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
						Dim flag2 As Boolean = False
						Dim ulgTapers As UltraGrid = Me.ulgTapers
						If ulgTapers.ActiveCell IsNot Nothing Then
							ulgTapers.ActiveRow = ulgTapers.ActiveCell.Row
						End If
						If ulgTapers.ActiveRow Is Nothing AndAlso (Me.iCurrentRodNum > 0 And Me.iCurrentRodNum <= CInt(RSWIN_DESC.rst.NumRods)) Then
							Me.MakeRowActive(Me.iCurrentRodNum)
						End If
						Me.bDisplayDeleteMessage = True
						ulgTapers.ActiveRow.Selected = True
						If ulgTapers.ActiveCell IsNot Nothing Then
							ulgTapers.ActiveCell.Row.Delete()
							flag2 = True
						ElseIf ulgTapers.Selected.Rows.Count = 1 Then
							ulgTapers.DeleteSelectedRows()
							flag2 = True
						End If
						Application.DoEvents()
						If CInt(RSWIN_DESC.rst.NumRods) <> numRods - 1 Then
							RSWIN_DESC.rst.NumRods = CShort((numRods - 1))
						End If
						If RSWIN_DESC.rst.NumRods >= 1S Then
							Dim num As Single
							If RSWIN_DESC.rst.NumRods = 1S Then
								num = Me.tmp_PumpDepth
							Else
								num = Me.tmp_PumpDepth - Me.GetDefaultRodLengthFromGrid(True)
							End If
							If num < 0F Then
								num = 0F
							End If
							Try
								Dim row As UltraGridRow = Me.ulgTapers.GetRow(ChildRow.Last)
								If row IsNot Nothing Then
									Me.ulgTapers.ActiveRow = row
									If RSWIN_DESC.rst.NumRods = 1S Then
										row.Cells("RodLength").Value = num
									Else
										row.Cells("RodLength").Value = Operators.AddObject(row.Cells("RodLength").Value, num)
									End If
								End If
							Catch ex As Exception
							End Try
						End If
						If flag2 Then
							Me.cboRodGrade.Visible = False
							Me.cboRodSize.Visible = False
						End If
						ini.SaveDataValue("NumRods", RSWIN_DESC.rst.NumRods)
					Else
						MessageBox.Show(Me.sSelectTaperToRemove, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub cmdMoveSectionUp_Click(eventSender As Object, eventArgs As EventArgs)
			Dim flag As Boolean = Me.m_iCurrentRodSection > 1 And Me.m_iCurrentRodSection <= CInt(RSWIN_DESC.rst.NumRods)
			If flag Then
				Debug.Assert(Me.ulgTapers.ActiveRow IsNot Nothing, "")
				Debug.Assert(Me.ulgTapers.ActiveRow.HasPrevSibling(), "")
				Dim activeRow As UltraGridRow = Me.ulgTapers.ActiveRow
				Dim sibling As UltraGridRow = activeRow.GetSibling(SiblingRow.Previous)
				Dim num As Short = Conversions.ToShort(activeRow.Cells("RodNum").Value)
				Dim num2 As Short = num - 1S
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				Try
					For Each obj As Object In Me.mdsRodTapers.Tables(0).Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow("RodNum"), num2, False), Not flag2)) Then
							dataRow("RodNum") = num
							flag2 = True
						ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataRow("RodNum"), num, False), Not flag3)) Then
							dataRow("RodNum") = num2
							flag3 = True
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Dim ulgTapers As UltraGrid = Me.ulgTapers
				ulgTapers.DataSource = Nothing
				ulgTapers.DataSource = Me.mdsRodTapers
				Me.ResortGrid()
				Me.MakeRowActive(CInt(num2))
				Return
			End If
			MessageBox.Show(Me.sCannotMoveUp, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		Private Sub cmdAddSection_Click(eventSender As Object, eventArgs As EventArgs)
			Dim flag As Boolean = (Me.m_iCurrentRodSection = 0 Or 1 <= Me.m_iCurrentRodSection) And RSWIN_DESC.rst.NumRods < 20S
			If Not flag Then
				Return
			End If
			If RSWIN_DESC.rst.NumRods = 20S Then
				Return
			End If
			Dim ulgTapers As UltraGrid = Me.ulgTapers
			If ulgTapers.ActiveCell IsNot Nothing Then
				ulgTapers.ActiveRow = ulgTapers.ActiveCell.Row
			End If
			If RSWIN_DESC.rst.NumRods = 0S Then
				Me.miNewRodNum = 1
			Else
				If ulgTapers.ActiveCell IsNot Nothing Then
					Me.miNewRodNum = Conversions.ToInteger(ulgTapers.ActiveCell.Row.Cells("RodNum").Value)
				ElseIf ulgTapers.ActiveRow IsNot Nothing Then
					Me.miNewRodNum = Conversions.ToInteger(ulgTapers.ActiveRow.Cells("RodNum").Value)
				ElseIf ulgTapers.Selected.Rows.Count = 1 Then
					Me.miNewRodNum = Conversions.ToInteger(ulgTapers.Selected.Rows(0).Cells("RodNum").Value)
				Else
					Me.miNewRodNum = Conversions.ToInteger(Operators.AddObject(ulgTapers.GetRow(ChildRow.Last).Cells("RodNum").Value, 1))
				End If
				Me.miNewRodNum += 1
			End If
			Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
			Dim defaultRodLengthFromGrid As Single = Me.GetDefaultRodLengthFromGrid(True)
			Dim num As Single = Me.tmp_PumpDepth - defaultRodLengthFromGrid
			If num < 0F Then
				num = 0F
			End If
			If Me.miNewRodNum = 0 Then
				Me.miNewRodNum = 1
			End If
			If Me.miNewRodNum = 1 Then
				If Me.bShowGuides Then
					Dim text As String = "GuideToUse"
					Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
					Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
					RSWIN_DESC.MOLDED = CShort(molded)
					RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
					Me.AddRodTaper(Me.miNewRodNum, CType(0, StdInfoConstants.RodGradeConstants), -1F, num, RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True), CShort(RSWIN_DESC.SETUP_GuideToUse), 0S, True, Me.miNewRodNum, False)
				Else
					Me.AddRodTaper(Me.miNewRodNum, CType(0, StdInfoConstants.RodGradeConstants), -1F, num, 0.2F, 0S, 0S, True, Me.miNewRodNum, False)
				End If
			ElseIf defaultRodLengthFromGrid > 0F And num = 0F Then
				If Me.bShowGuides Then
					Dim text As String = "GuideToUse"
					Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
					Dim regProfileStringByInt2 As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
					RSWIN_DESC.MOLDED = CShort(molded)
					RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt2)
					Me.AddRodTaper(Me.miNewRodNum, CType(0, StdInfoConstants.RodGradeConstants), -1F, 0F, RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True), CShort(RSWIN_DESC.SETUP_GuideToUse), 0S, True, Me.miNewRodNum, False)
				Else
					Me.AddRodTaper(Me.miNewRodNum, CType(0, StdInfoConstants.RodGradeConstants), -1F, 0F, 0.2F, 0S, 0S, True, Me.miNewRodNum, False)
				End If
				Me.SetToZeroFromDataSet(Me.miNewRodNum)
			ElseIf num <> Me.tmp_PumpDepth Then
				If Me.bShowGuides Then
					Dim text As String = "GuideToUse"
					Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
					Dim regProfileStringByInt3 As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
					RSWIN_DESC.MOLDED = CShort(molded)
					RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt3)
					Me.AddRodTaper(Me.miNewRodNum, CType(0, StdInfoConstants.RodGradeConstants), -1F, num, RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True), CShort(RSWIN_DESC.SETUP_GuideToUse), 0S, True, Me.miNewRodNum, False)
				Else
					Me.AddRodTaper(Me.miNewRodNum, CType(0, StdInfoConstants.RodGradeConstants), -1F, num, 0.2F, 0S, 0S, True, Me.miNewRodNum, False)
				End If
			ElseIf Me.bShowGuides Then
				Dim text As String = "GuideToUse"
				Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
				Dim regProfileStringByInt4 As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
				RSWIN_DESC.MOLDED = CShort(molded)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt4)
				Me.AddRodTaper(Me.miNewRodNum, CType(0, StdInfoConstants.RodGradeConstants), -1F, 0F, RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True), CShort(RSWIN_DESC.SETUP_GuideToUse), 0S, True, Me.miNewRodNum, False)
			Else
				Me.AddRodTaper(Me.miNewRodNum, CType(0, StdInfoConstants.RodGradeConstants), -1F, 0F, 0.2F, 0S, 0S, True, Me.miNewRodNum, False)
			End If
			Application.DoEvents()
			If CInt(RSWIN_DESC.rst.NumRods) <> numRods + 1 Then
				RSWIN_DESC.rst.NumRods = CShort((numRods + 1))
			End If
			Application.DoEvents()
			ini.SaveDataValue("NumRods", RSWIN_DESC.rst.NumRods)
		End Sub

		Private Function GetDefaultRodLengthFromDataSet() As Single
			Dim num As Single = 0F
			Try
				Try
					For Each obj As Object In Me.mdsRodTapers.Tables(0).Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						Dim num2 As Single = Conversions.ToSingle(dataRow("RodLength"))
						If Information.IsDBNull(num2) Or num2 <= 0F Then
							num2 = 0F
						End If
						num += num2
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex As Exception
			End Try
			Return num
		End Function

		Private Function CheckRodLengthsFromGrid(Index As Integer, fChkLength As Single) As Boolean
			Dim num As Single = 0F
			Dim result As Boolean
			Try
				For Each ultraGridRow As UltraGridRow In Me.ulgTapers.Rows
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("RodLength").Value)) Then
						Dim num2 As Integer = Conversions.ToInteger(ultraGridRow.Cells("RodNum").Value)
						If num2 <> Index Then
							Dim num3 As Single = Conversions.ToSingle(ultraGridRow.Cells("RodLength").Value)
							num += num3
						End If
					End If
				Next
				Dim flag As Boolean = num + fChkLength < Me.tmp_PumpDepth
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Function GetDefaultRodLengthFromGrid(Optional bWithLast As Boolean = True) As Single
			Dim num As Single = 0F
			Dim result As Single
			Try
				For Each ultraGridRow As UltraGridRow In Me.ulgTapers.Rows
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("RodLength").Value)) Then
						Dim num2 As Integer = Conversions.ToInteger(ultraGridRow.Cells("RodNum").Value)
						Dim num3 As Single = Conversions.ToSingle(ultraGridRow.Cells("RodLength").Value)
						If num2 = CInt(RSWIN_DESC.rst.NumRods) And Not bWithLast Then
							num3 = 0F
						End If
						num += num3
					End If
				Next
				result = num
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Function CheckRSInpAPI() As Boolean
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				IL_09:
				GoTo IL_4C
				IL_0B:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_0B
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_4C:
			Dim flag As Boolean
			Dim result As Boolean = flag
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Function CheckRSInpRFG() As Boolean
			Dim num As Integer
			Dim flag As Boolean
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				flag = False
				Dim text As String = Nothing
				Dim text2 As String = Nothing
				If Strings.Len(text) > 0 Or Strings.Len(text2) > 0 Then
					Util.Errmsg(String.Concat(New String() { "Please ", text, " the ", text2, "." }))
				Else
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					If rst.RSIncludeSB <> 0S Then
						Dim sinkerBar As RSWIN_DESC.RodSection = rst.SinkerBar
						sinkerBar.RodDensity = 491F
						RODUTIL.LookupElasticity(sinkerBar)
						RODUTIL.LookupRodWeight(sinkerBar)
						RODUTIL.LookupTensileStrength(sinkerBar)
						If(If((-If((RODUTIL.IsCorod(sinkerBar.Grade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(sinkerBar.Grade))) <> 0 Then
							sinkerBar.SuckerRodLength = 1F
						ElseIf RODUTIL.IsSteel(CInt(rst.SinkerBar.Grade)) <> 0 Then
							sinkerBar.SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
						End If
						rst.SinkerBar = sinkerBar
					End If
					flag = True
				End If
				IL_105:
				GoTo IL_14C
				IL_107:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_11D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_107
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_14C:
			Dim result As Boolean = flag
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Function CheckRSInpRRR() As Boolean
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				IL_09:
				GoTo IL_4C
				IL_0B:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_0B
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_4C:
			Dim flag As Boolean
			Dim result As Boolean = flag
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Function CheckRSInpRST() As Boolean
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				IL_09:
				GoTo IL_4C
				IL_0B:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_0B
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_4C:
			Dim flag As Boolean
			Dim result As Boolean = flag
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Function CheckRSInpUsr(bShowMsg As Boolean) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim flag3 As Boolean
			Dim num9 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim text As String = "enter"
				Dim text2 As String = Nothing
				If Strings.Len(Strings.Trim(Me.txtServiceFactor.Text)) = 0 Then
					text2 = "service factor"
					Dim txtServiceFactor As Control = Me.txtServiceFactor
					Me.SetActiveControl(txtServiceFactor)
					Me.txtServiceFactor = CType(txtServiceFactor, TextBox)
				ElseIf rst.NumRods > 0S Then
					Dim ultraGridRow As UltraGridRow = Me.ulgTapers.GetRow(ChildRow.First)
					Dim num2 As Integer = 1
					Dim numRods As Integer = CInt(rst.NumRods)
					For i As Integer = num2 To numRods
						Dim str As String
						If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells(1).Value)) Then
							text = "select"
							text2 = "rod grade or manufacturer" + str
							Exit For
						End If
						If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells(2).Value)) Then
							text = "select"
							text2 = "sucker rod diameter" + str
							Exit For
						End If
						If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells(3).Value)) Then
							text2 = "sucker rod diameter" + str
							Exit For
						End If
						If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells(4).Value)) Then
							text2 = "sucker rod length" + str
							Exit For
						End If
						If i < CInt(rst.NumRods) Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						End If
					Next
				End If
				If Strings.Len(text2) > 0 Then
					If bShowMsg Then
						Util.Errmsg(String.Concat(New String() { "Please ", text, " the ", text2, "." }))
					End If
				Else
					Dim num3 As Integer = 1
					Dim numRods2 As Integer = CInt(rst.NumRods)
					Dim i As Integer = num3
					While i <= numRods2
						If rst.Sections(i).Grade = 20481S Then
							rst.Sections(i).RodDensity = 100F
						ElseIf rst.Sections(i).Grade = 16393S Then
							rst.Sections(i).RodDensity = 125F
						ElseIf RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Then
							rst.Sections(i).RodDensity = 130F
						Else
							rst.Sections(i).RodDensity = 491F
						End If
						Dim flag As Boolean = True
						If flag = (rst.Sections(i).Grade = 16385S) Then
							GoTo IL_2EB
						End If
						If flag = (rst.Sections(i).Grade = 16389S) Then
							GoTo IL_2EB
						End If
						If flag = (rst.Sections(i).Grade = 16390S) Then
							GoTo IL_2EB
						End If
						If flag = (RODUTIL.IsSteel(CInt(rst.Sections(i).Grade)) <> 0) Then
							Dim sections As RSWIN_DESC.RodSection() = rst.Sections
							Dim num4 As Integer = i
							Dim sDefaultName As String = "SteelSuckerRodLength"
							Dim vNotPresentDefault As Object = 25
							Dim flag2 As Boolean = False
							sections(num4).SuckerRodLength = Conversions.ToSingle(ini.GetDefault(sDefaultName, vNotPresentDefault, flag2))
						ElseIf flag = RODUTIL.IsCorod(rst.Sections(i).Grade) OrElse flag = (RODUTIL.IsProRod(CInt(rst.Sections(i).Grade)) <> 0) Then
							rst.Sections(i).SuckerRodLength = 1F
						Else
							rst.Sections(i).SuckerRodLength = 25F
						End If
						IL_3C4:
						RODUTIL.LookupElasticity(rst.Sections(i))
						RODUTIL.LookupRodWeight(rst.Sections(i))
						RODUTIL.LookupTensileStrength(rst.Sections(i))
						i += 1
						Continue While
						IL_2EB:
						rst.Sections(i).SuckerRodLength = 37.5F
						GoTo IL_3C4
					End While
					Dim num5 As Integer = 1
					Dim numRods3 As Integer = CInt(rst.NumRods)
					i = num5
					While i <= numRods3
						If CDbl(rst.Sections(i).Diameter) >= 1.25 AndAlso Not RODUTIL.CheckRodAvailability(Not bShowMsg, rst.Sections(i).Grade, RODUTIL.IsSinkerBar(i) <> 0, rst.Sections(i).Diameter) Then
							Exit While
						End If
						i += 1
					End While
					Dim num6 As Single = 0F
					Dim num7 As Integer = 1
					Dim numRods4 As Integer = CInt(rst.NumRods)
					i = num7
					While i <= numRods4

							num6 += rst.Sections(i).length

						i += 1
					End While
					If num6 < rst.PumpDepth - 50F Then
						If bShowMsg Then
							If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
								Util.Errmsg("Rod string length must be within 50 feet of pump depth.")
							Else
								Util.Errmsg("Rod string length must be within 15.24 meters of pump depth.")
							End If
						End If
					ElseIf num6 > rst.PumpDepth + 1F Then
						If bShowMsg Then
							Util.Errmsg("Rod string length must not be greater than pump depth.")
						End If
					ElseIf RODUTIL.IsFG(rst.Sections(CInt(rst.NumRods)).Grade) Then
						If bShowMsg Then
							Util.Errmsg("You must always use steel rods at the bottom of fiberglass rods.  Please change your rod string design.")
						End If
					Else
						Dim num8 As Integer = 2
						Dim numRods5 As Integer = CInt(rst.NumRods)
						i = num8
						While i <= numRods5
							If(RODUTIL.IsSinkerBar(i) And RODUTIL.IsSteel(CInt(rst.Sections(i).Grade))) <> 0 Then
								Dim grade As Short = rst.Sections(i).Grade
								If grade <> 8193S AndAlso grade <> 8197S AndAlso grade <> 4098S AndAlso grade <> 8194S AndAlso grade <> 4097S AndAlso grade <> 8198S AndAlso grade <> 8195S AndAlso grade <> 8199S AndAlso grade <> 8196S AndAlso grade <> 8200S AndAlso grade <> 8301S AndAlso grade <> 8302S AndAlso grade <> 8303S AndAlso grade <> 8304S AndAlso grade <> 8305S AndAlso grade <> 8306S AndAlso grade <> 8307S AndAlso grade <> 8308S AndAlso grade <> 8309S AndAlso grade <> 8310S Then
									If bShowMsg Then
										Util.cErrmsg(62)
										Exit While
									End If
									Exit While
								End If
							End If
							i += 1
						End While
						flag3 = True
					End If
				End If
				IL_681:
				GoTo IL_6C8
				IL_683:
				num9 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_699:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num9 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_683
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6C8:
			Dim result As Boolean = flag3
			If num9 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Function CheckRSInput(bShowMsg As Boolean) As Boolean
			Dim result As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If rst.RodStringType = 2S Then
					result = Me.CheckRSInpUsr(bShowMsg)
				ElseIf rst.giRodDesignStyle = 0S Then
					result = Me.CheckRSInpRST()
				Else
					result = (rst.giRodDesignStyle = 1S AndAlso Me.CheckRSInpRFG())
				End If
				result = True
			Catch ex As Exception
				Dim message As String = ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(message, sMsgType, bClosing, dialogResult)
			End Try
			Return result
		End Function

		Private Sub cboRodSize_Leave(sender As Object, e As EventArgs)
		End Sub

		Private Sub cboRodSize_Click(sender As Object, e As EventArgs)
		End Sub

		Private Function GetRodSizeStringFromValue(myList As IEnumerable, myValue As Integer) As String
			Dim enumerator As IEnumerator = myList.GetEnumerator()
			Dim text As String = ""
			Dim result As String
			Try
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim cRodSize As cRodSize = CType(obj, cRodSize)
					If cRodSize.RodSizeID = myValue Then
						text = cRodSize.DisplayName
					End If
				End While
				result = text
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub cboRodSize_SelectionChangeCommitted(sender As Object, e As EventArgs)
			Try
				Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.cboRodSize)
				Dim comboBox As ComboBox = Me.cboRodSize
				If comboBox.Items.Count > 0 AndAlso Strings.Len(comboBox.Text) > 0 Then
					Me.ulgTapers.ActiveCell.Row.Cells("RodSize").Value = RuntimeHelpers.GetObjectValue(comboBox.SelectedValue)
					Try
						If Conversions.ToBoolean(Operators.AndObject(Me.ActiveControl Is Me.cboRodSize, Operators.CompareObjectEqual(Me.ulgTapers.ActiveCell.Row.Cells("RodGrade").Value, 0, False))) Then
							MessageBox.Show("Please choose Rod Grade before Rod Size!")
						End If
					Catch ex As Exception
					End Try
					Dim text As String
					Try
						text = comboBox.SelectedText
					Catch ex2 As Exception
						text = ""
					End Try
					If Operators.CompareString(text, "", False) = 0 Then
						text = Me.GetRodSizeStringFromValue(Me.myRodSizeAL, Conversions.ToInteger(comboBox.SelectedValue))
					End If
					If Strings.InStr(text, "Ot", CompareMethod.Binary) = 0 Then
						Me.ulgTapers.ActiveCell.Row.Cells("RodDiam").Activation = Activation.Disabled
						Me.ulgTapers.ActiveCell.Row.Cells("RodDiam").Appearance.BackColor = SystemColors.Control
					Else
						Me.ulgTapers.ActiveCell.Row.Cells("RodDiam").Activation = Activation.AllowEdit
						Me.ulgTapers.ActiveCell.Row.Cells("RodDiam").Appearance.BackColor = SystemColors.Window
					End If
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.ulgTapers.ActiveCell.Row.Cells("RodLength").Value)) Then
						Try
							Dim num As Single = Conversions.ToSingle(Me.ulgTapers.ActiveCell.Row.Cells("RodLength").Value)
						Catch ex3 As Exception
						End Try
					End If
				End If
				comboBox = Nothing
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub cboRodGrade_SelectionChangeCommitted(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.cboRodGrade)
			Dim flag2 As Boolean = True
			Try
				Dim cboRodGrade As ComboBox = Me.cboRodGrade
				Dim text As String = cboRodGrade.Text
				If Operators.CompareString(text, RSWIN_DESC.s_Steel, False) <> 0 Then
					If Operators.CompareString(text, RSWIN_DESC.s_SinkerBars, False) <> 0 Then
						If Operators.CompareString(text, RSWIN_DESC.s_Corod, False) <> 0 Then
							If Operators.CompareString(text, RSWIN_DESC.s_Prorod, False) <> 0 Then
								If Operators.CompareString(text, RSWIN_DESC.s_RibbonRod, False) <> 0 Then
									If Operators.CompareString(text, RSWIN_DESC.s_Fiberglass, False) <> 0 Then
										GoTo IL_9B
									End If
								End If
							End If
						End If
					End If
				End If
				flag2 = False
				cboRodGrade.SelectedIndex = -1
				IL_9B:
				If flag2 AndAlso cboRodGrade.Items.Count > 0 Then
					Dim num As Integer
					Dim num2 As Integer
					Dim num3 As Integer
					If Strings.Len(cboRodGrade.Text) > 0 Then
						Me.ulgTapers.ActiveCell.Row.Cells("RodGrade").Value = RuntimeHelpers.GetObjectValue(cboRodGrade.SelectedValue)
						Dim text2 As String = Me.ulgTapers.ActiveCell.Row.Cells("RodGrade").Text
						num = Conversions.ToInteger(cboRodGrade.SelectedValue)
						ini.SaveDataValue("RodGrade" + Me.ulgTapers.ActiveCell.Row.Cells("RodNum").Value.ToString(), num)
						If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.ulgTapers.ActiveCell.Row.Cells("RodSize").Value)) Then
							num2 = 0
						Else
							num2 = Conversions.ToInteger(Me.ulgTapers.ActiveCell.Row.Cells("RodSize").Value)
							Dim text3 As String = Me.ulgTapers.ActiveCell.Row.Cells("RodSize").Text
							If Not Me.CheckRodSize(num, num2, text3, num3, text2) Then
								Try
									Me.ulgTapers.ActiveCell.Row.Cells("RodSize").Value = DBNull.Value
								Catch ex As Exception
								End Try
								Me.ulgTapers.ActiveCell.Row.Cells("RodDiam").Value = ""
							ElseIf num2 <> num3 Then
								Me.ulgTapers.ActiveCell.Row.Cells("RodSize").Value = num3
							End If
						End If
					End If
					Dim row As UltraGridRow = Me.ulgTapers.ActiveCell.Row
					If num2 = 0 Then
						Try
							If Me.GetDefaultRodSize(row, num, num2) AndAlso Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.ulgTapers.ActiveCell.Row.Cells("RodSize").Value)), Operators.CompareObjectEqual(Me.ulgTapers.ActiveCell.Row.Cells("RodSize").Value, -1, False)), Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.ulgTapers.ActiveCell.Row.Cells("RodSize").Value)))) Then
								Me.ulgTapers.ActiveCell.Row.Cells("RodSize").Value = num3
							End If
						Catch ex2 As Exception
						End Try
					End If
					If Me.ActiveControl Is Me.cboRodGrade Then
						Dim ultraGridRow As UltraGridRow = Me.ulgTapers.ActiveRow
						Dim num4 As Integer = Conversions.ToInteger(ultraGridRow.Cells("RodNum").Value)
						If RSWIN_DESC.rst.NumRods > 1S And num4 = 1 Then
							If ultraGridRow.Cells("RodLength").Value Is Nothing Then
								flag = True
							ElseIf Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("RodLength").Value)) Then
								flag = True
							ElseIf Operators.ConditionalCompareObjectEqual(ultraGridRow.Cells("RodLength").Value, 0, False) Then
								flag = True
							End If
							If flag Then
								Dim num5 As Single = Me.tmp_PumpDepth
								Dim ultraGridRow2 As UltraGridRow = ultraGridRow
								While ultraGridRow.HasNextSibling()
									ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
									num4 = Conversions.ToInteger(ultraGridRow.Cells("RodNum").Value)
									Dim ultraGridCell As UltraGridCell = ultraGridRow.Cells("RodLength")
									If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridCell.Value)) Then
										num5 = 0F
										Exit While
									End If
									If Operators.ConditionalCompareObjectLessEqual(ultraGridCell.Value, 0, False) Then
										num5 = 0F
										Exit While
									End If
									num5 = Conversions.ToSingle(Operators.SubtractObject(num5, ultraGridCell.Value))
								End While
								If num5 > 0F Then
									Dim ulgTapers As UltraGrid = Me.ulgTapers
									ulgTapers.EventManager.SetEnabled(GridEventIds.AfterCellUpdate, False)
									ultraGridRow2.Cells("RodLength").Value = num5
									ulgTapers.EventManager.SetEnabled(GridEventIds.AfterCellUpdate, True)
								End If
							End If
						End If
					End If
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub cboRodGuides_SelectionChangeCommitted(sender As Object, e As EventArgs)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.cboRodGuides)
			Try
				If RSWIN_DESC.bRodStarD Then
					Dim cboRodGuides As ComboBox = Me.cboRodGuides
					If cboRodGuides.Items.Count > 0 AndAlso Strings.Len(cboRodGuides.Text) > 0 Then
						Dim num As Integer = Conversions.ToInteger(cboRodGuides.SelectedValue)
						Dim rodGuideName As String = Me.GetRodGuideName(CShort(num))
						Me.ulgTapers.ActiveCell.Row.Cells("RodGuide").Value = num
						ini.SaveDataValue("RodGuide" + Me.ulgTapers.ActiveCell.Row.Cells("RodNum").Value.ToString(), num)
						Me.ulgTapers.ActiveCell.Row.Cells("RodFrictionCoef").Value = RODUTIL.GetFricCoeff(num, True)
						ini.SaveDataValue("RodFrictionCoef" + Me.ulgTapers.ActiveCell.Row.Cells("RodNum").Value.ToString(), RODUTIL.GetFricCoeff(num, True))
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboRodGuides_Validating(eventSender As Object, eventArgs As CancelEventArgs)
			Try
				Dim cancel As Boolean = eventArgs.Cancel
				If RSWIN_DESC.bRodStarD Then
					Dim cboRodGuides As ComboBox = Me.cboRodGuides
					If Strings.Len(cboRodGuides.SelectedText) > 0 Then
						Me.ulgTapers.ActiveCell.Row.Cells("RodGuide").Value = RuntimeHelpers.GetObjectValue(cboRodGuides.SelectedValue)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboRSRodGuides_Enter(sender As Object, e As EventArgs)
			Me.cboRSRodGuides.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboRSRodGuides_Validating(eventSender As Object, eventArgs As CancelEventArgs)
			Try
				Dim cancel As Boolean = eventArgs.Cancel
				If RSWIN_DESC.bRodStarD Then
					Dim cboRSRodGuides As ComboBox = Me.cboRSRodGuides
					If Strings.Len(cboRSRodGuides.SelectedText) > 0 Then
						RSWIN_DESC.rst.RSRodGuide = Conversions.ToInteger(cboRSRodGuides.SelectedValue)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboRSRodGuides_SelectionChangeCommitted(sender As Object, e As EventArgs)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.cboRSRodGuides)
			Try
				If RSWIN_DESC.bRodStarD Then
					Dim cboRSRodGuides As ComboBox = Me.cboRSRodGuides
					If cboRSRodGuides.Items.Count > 0 AndAlso Strings.Len(cboRSRodGuides.Text) > 0 Then
						Dim num As Integer = Conversions.ToInteger(cboRSRodGuides.SelectedValue)
						Dim rodGuideName As String = Me.GetRodGuideName(CShort(num))
						ini.SaveDataValue("RSRodGuide", num)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub DisplayRSInputError(sMsg As String, ByRef bCancel As Boolean)
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

		Friend Overridable Property cboRodSize As ComboBox
			Get
				Return Me._cboRodSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRodSize_Enter
				Dim value3 As EventHandler = AddressOf Me.cboRodSize_SelectionChangeCommitted
				Dim value4 As CancelEventHandler = AddressOf Me.cboRodSize_Validating
				If Me._cboRodSize IsNot Nothing Then
					RemoveHandler Me._cboRodSize.Enter, value2
					RemoveHandler Me._cboRodSize.SelectionChangeCommitted, value3
					RemoveHandler Me._cboRodSize.Validating, value4
				End If
				Me._cboRodSize = value
				If Me._cboRodSize IsNot Nothing Then
					AddHandler Me._cboRodSize.Enter, value2
					AddHandler Me._cboRodSize.SelectionChangeCommitted, value3
					AddHandler Me._cboRodSize.Validating, value4
				End If
			End Set
		End Property

		Private Sub txtService_Enter(sender As Object, e As EventArgs)
			Me.btnNumberOfRods.Enabled = False
			Me.cmdAddSection.Enabled = False
			Me.cmdDelSection.Enabled = False
			Me.cmdMoveSectionDown.Enabled = False
			Me.cmdMoveSectionUp.Enabled = False
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

		Private Sub CreateMyToolTip()
			Me.ToolTip1.AutoPopDelay = 2500
			Me.ToolTip1.InitialDelay = 500
			Me.ToolTip1.ReshowDelay = 250
			Me.ToolTip1.ShowAlways = True
			Me.ToolTip1.SetToolTip(Me.cmdAddSection, "Insert/Add Rod Section")
			Me.ToolTip1.SetToolTip(Me.cmdDelSection, "Delete Rod Section")
			Me.ToolTip1.SetToolTip(Me.cmdMoveSectionDown, "Move Rod Section Down")
			Me.ToolTip1.SetToolTip(Me.cmdMoveSectionUp, "Move Rod Section Up")
			Me.ToolTip1.SetToolTip(Me.btnNumberOfRods, "Number of Rod String Sections")
		End Sub

		Private Sub btnNumberOfRods_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Not Me.lstNumOfRods.Visible Then
				Me.lstNumOfRods.Width = Me.btnNumberOfRods.Width + 18
				Me.lstNumOfRods.Left = Me.btnNumberOfRods.Left
				Me.lstNumOfRods.Top = Me.btnNumberOfRods.Top + Me.btnNumberOfRods.Height
				Me.lstNumOfRods.Visible = True
			Else
				Me.lstNumOfRods.Visible = False
			End If
		End Sub

		Private Sub lstNumOfRods_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Try
				Me.Control_SelectedIndexChanged(Me.lstNumOfRods Is Me.ActiveControl)
				If Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstNumOfRods.SelectedItem)) < CInt(RSWIN_DESC.rst.NumRods) And RSWIN_DESC.rst.NumRods > 1S Then
					Me.bDisplayDeleteMessage = False
					Dim obj As Object = CInt(RSWIN_DESC.rst.NumRods) - Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstNumOfRods.SelectedItem))
					Dim obj2 As Object
					If Operators.ConditionalCompareObjectEqual(obj, 1, False) Then
						obj2 = MessageBox.Show(Me.sARSRemoveLastSection, Me.sDeleteRow, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					Else
						obj2 = MessageBox.Show(Me.sARSRemoveLastSections + " (" + obj.ToString() + ") ?", Me.sDeleteRow, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					End If
					If Operators.ConditionalCompareObjectEqual(obj2, DialogResult.Yes, False) Then
						Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						Dim num3 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstNumOfRods.SelectedItem)) + 1
						For i As Integer = numRods2 To num3 Step -1
							Try
								Dim ulgTapers As UltraGrid = Me.ulgTapers
								ulgTapers.Rows(i - 1).Selected = True
								If ulgTapers.Selected.Rows.Count > 0 Then
									ulgTapers.DeleteSelectedRows()
									Application.DoEvents()
									If num2 > 0 And CInt(RSWIN_DESC.rst.NumRods) <> numRods - num2 Then
										RSWIN_DESC.rst.NumRods = CShort((numRods - num2))
									Else
										RSWIN_DESC.rst.NumRods = Conversions.ToShort(Operators.SubtractObject(numRods, obj))
									End If
								End If
							Catch ex As Exception
								Dim sMsg As String = "Error in lstNumOfRods_SelectedIndexChanged:" + ex.Message
								Dim sMsgType As String = ""
								Dim bClosing As Boolean = False
								Dim dialogResult As DialogResult = DialogResult.OK
								Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
							End Try
						Next
						If Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstNumOfRods.SelectedItem)) >= 1 Then
							Dim num4 As Single
							If Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstNumOfRods.SelectedItem)) = 1 Then
								num4 = Me.tmp_PumpDepth
							Else
								' The following expression was wrapped in a unchecked-expression
								num4 = Me.tmp_PumpDepth - Me.GetDefaultRodLengthFromGrid(True)
							End If
							If num4 < 0F Then
								num4 = 0F
							End If
							Try
								Dim row As UltraGridRow = Me.ulgTapers.GetRow(ChildRow.Last)
								If row IsNot Nothing Then
									Me.ulgTapers.ActiveRow = row
									If Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstNumOfRods.SelectedItem)) = 1 Then
										row.Cells("RodLength").Value = num4
									Else
										row.Cells("RodLength").Value = Operators.AddObject(row.Cells("RodLength").Value, num4)
									End If
								End If
							Catch ex2 As Exception
							End Try
						End If
					End If
				ElseIf Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstNumOfRods.SelectedItem)) = 1 Then
					Dim num5 As Integer = CInt((RSWIN_DESC.rst.NumRods + 1S))
					Dim num6 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstNumOfRods.SelectedItem))
					For i As Integer = num5 To num6
						Me.miNewRodNum = i
						Dim num7 As Single = Me.tmp_PumpDepth
						If num7 < 0F Then
						End If
						If Me.bShowGuides Then
							Dim text As String = "GuideToUse"
							Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
							Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
							RSWIN_DESC.MOLDED = CShort(molded)
							RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
							Me.AddRodTaper(Me.miNewRodNum, CType(0, StdInfoConstants.RodGradeConstants), -1F, Me.tmp_PumpDepth, RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True), CShort(RSWIN_DESC.SETUP_GuideToUse), 0S, True, Me.miNewRodNum, False)
						Else
							Me.AddRodTaper(Me.miNewRodNum, CType(0, StdInfoConstants.RodGradeConstants), -1F, Me.tmp_PumpDepth, 0.2F, 0S, 0S, True, Me.miNewRodNum, False)
						End If
						num += 1
						Application.DoEvents()
						If CInt(RSWIN_DESC.rst.NumRods) <> numRods + num Then
							RSWIN_DESC.rst.NumRods = CShort((numRods + num))
						End If
					Next
					Me.MakeRowActive(1)
				ElseIf Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstNumOfRods.SelectedItem)) > CInt(RSWIN_DESC.rst.NumRods) Then
					Dim num8 As Integer = CInt((RSWIN_DESC.rst.NumRods + 1S))
					Dim num9 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstNumOfRods.SelectedItem))
					For i As Integer = num8 To num9
						Me.miNewRodNum = i
						If Me.bShowGuides Then
							Dim text As String = "GuideToUse"
							Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
							Dim regProfileStringByInt2 As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
							RSWIN_DESC.MOLDED = CShort(molded)
							RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt2)
							Me.AddRodTaper(Me.miNewRodNum, CType(0, StdInfoConstants.RodGradeConstants), -1F, -1F, RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True), CShort(RSWIN_DESC.SETUP_GuideToUse), 0S, True, Me.miNewRodNum, False)
						Else
							Me.AddRodTaper(Me.miNewRodNum, CType(0, StdInfoConstants.RodGradeConstants), -1F, -1F, 0.2F, 0S, 0S, True, Me.miNewRodNum, False)
						End If
						num += 1
						Application.DoEvents()
						If CInt(RSWIN_DESC.rst.NumRods) <> numRods + num Then
							RSWIN_DESC.rst.NumRods = CShort((numRods + num))
						End If
					Next
					Me.MakeRowActive(1)
				End If
			Catch ex3 As Exception
			End Try
			ini.SaveDataValue("NumRods", RSWIN_DESC.rst.NumRods)
			Me.lstNumOfRods.Visible = False
		End Sub

		Private Sub TextBox_Change(ByRef txt As TextBox, ByRef lbl As Label)
			If Me.ActiveControl IsNot txt Then
				CtrlUI.TextBox_LostFocus(txt, lbl, True)
				Return
			End If
			Me.bValidated = False
			RSWIN_DESC.rst.gbInputDataChanged = True
			Me.TurnOffViewReportOption()
		End Sub

		Private Sub txtServiceFactor_Enter(sender As Object, e As EventArgs)
			Me.txtServiceFactor.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtServiceFactor_Leave(sender As Object, e As EventArgs)
			Dim txtServiceFactor As Control = Me.txtServiceFactor
			CtrlUI.Control_LostFocus(txtServiceFactor)
			Me.txtServiceFactor = CType(txtServiceFactor, TextBox)
			Dim obj As Object
			Dim txtServiceFactor2 As TextBox
			Dim lblServiceFactor As Label
			If Me.bUseStatus Then
				Dim flag As Boolean = False
				If flag <> CtrlUI.CheckValid(Me.txtServiceFactor, True, False, obj) Then
					txtServiceFactor2 = Me.txtServiceFactor
					lblServiceFactor = Me.lblServiceFactor
					Me.TextBox_Change(txtServiceFactor2, lblServiceFactor)
					Me.lblServiceFactor = lblServiceFactor
					Me.txtServiceFactor = txtServiceFactor2
					ini.SaveDataValue("ServiceFactor", RuntimeHelpers.GetObjectValue(obj))
					Util.Message("")
					If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
						RSWIN_DESC.rst.ServiceFactor = Conversions.ToSingle(obj)
					End If
				End If
				Return
			End If
			Dim flag2 As Boolean = False
			If flag2 = CtrlUI.CheckValid(Me.txtServiceFactor, True, False, obj) Then
				Return
			End If
			Dim obj2 As Object = flag2
			Dim lowerBound As Single = 0.5F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 61
			Dim useMetric As Integer = 0
			Dim canadianIsMetric As Integer = 0
			Dim bQuiet As Boolean = Me.bUseStatus
			Dim text As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Me.txtServiceFactor.Focus()
				Return
			End If
			Dim obj3 As Object = flag2
			Dim upperBound As Single = 1F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = 61
			Dim useMetric2 As Integer = 0
			Dim canadianIsMetric2 As Integer = 0
			Dim bQuiet2 As Boolean = Me.bUseStatus
			text = ""
			If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
				Me.txtServiceFactor.Focus()
				Return
			End If
			txtServiceFactor2 = Me.txtServiceFactor
			lblServiceFactor = Me.lblServiceFactor
			Me.TextBox_Change(txtServiceFactor2, lblServiceFactor)
			Me.lblServiceFactor = lblServiceFactor
			Me.txtServiceFactor = txtServiceFactor2
			ini.SaveDataValue("ServiceFactor", RuntimeHelpers.GetObjectValue(obj))
			Util.Message("")
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.rst.ServiceFactor = Conversions.ToSingle(obj)
			End If
		End Sub

		Private Sub txtRSSBLength_TextChanged(sender As Object, e As EventArgs)
			Dim str As String = ""
			Try
				Dim txtRSSBLength As TextBox = Me.txtRSSBLength
				Dim lblRSSBLength As Label = Me.lblRSSBLength
				Me.TextBox_Change(txtRSSBLength, lblRSSBLength)
				Me.lblRSSBLength = lblRSSBLength
				Me.txtRSSBLength = txtRSSBLength
				txtRSSBLength = Me.txtRSSBLength
				Util.SetFieldColor(txtRSSBLength)
				Me.txtRSSBLength = txtRSSBLength
				If Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked) Then
					txtRSSBLength = Me.txtRSSBLength
					Util.SetFieldColor(txtRSSBLength)
					Me.txtRSSBLength = txtRSSBLength
					If Me.ActiveControl Is Me.txtRSSBLength Then
						Dim flag As Boolean = Me.ValidateRSInput(Me.bFormLoaded, Me.ActiveControl Is Me.txtRSSBLength, False)
						If Me.txtRSSBLength.Enabled Then
							If Me.bUseStatus And Operators.CompareString(Me.txtRSSBLength.Text.Trim(), "", False) = 0 Then
								If Not RSWIN_DESC.bExpert And Not Me.chkDesignSinkerbars.Checked Then
									Me.lblStatus.Text = " " + Me.SEnterSBLength
								Else
									Me.lblStatus.Text = ""
								End If
							Else
								Dim flag2 As Boolean = False
								Dim obj As Object
								If flag2 <> CtrlUI.CheckValid(Me.txtRSSBLength, True, False, obj) Then
									If Operators.ConditionalCompareObjectEqual(flag2, Util.CheckLower(obj, 25F, -1, 59, -1, -1, True, str), False) Then
										Me.lblStatus.Text = " " + str
									ElseIf Operators.ConditionalCompareObjectEqual(flag2, Util.CheckUpper(obj, RSWIN_DESC.rst.PumpDepth / 2F, 0, 137, -1, -1, True, str), False) Then
										Me.lblStatus.Text = " " + str
									ElseIf Operators.ConditionalCompareObjectEqual(flag2, Util.CheckUpper(obj, 2000F, -1, 135, -1, -1, True, str), False) Then
										Me.lblStatus.Text = " " + str
									Else
										Me.lblStatus.Text = ""
									End If
								End If
							End If
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Function GetDefaultRodSize(ByRef r As UltraGridRow, iRodGrade As Integer, ByRef iRodSize As Integer) As Boolean
			Dim result As Boolean
			Try
				iRodSize = 0
				If r.HasPrevSibling() Then
					Dim rodSizeList As teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iRodGrade, StdInfoConstants.RodGradeConstants)).RodSizeList
					Dim sibling As UltraGridRow = r.GetSibling(SiblingRow.Previous)
					Dim ultraGridCell As UltraGridCell = sibling.Cells("RodGrade")
					Dim num As Integer = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridCell.Value)), 0, RuntimeHelpers.GetObjectValue(ultraGridCell.Value)))
					Dim ultraGridCell2 As UltraGridCell = sibling.Cells("RodSize")
					Dim num2 As Integer = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridCell2.Value)), 0, RuntimeHelpers.GetObjectValue(ultraGridCell2.Value)))
					If num <> 0 And num2 <> 0 Then
						Dim diameter As Single = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(num, StdInfoConstants.RodGradeConstants)).RodSizeList.Item(num2).Diameter
						iRodSize = 0
						Dim dictionaryEntry As DictionaryEntry
						Try
							For Each obj As Object In rodSizeList
								Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
								If teRodSize.Diameter < diameter Then
									If iRodSize = 0 Then
										iRodSize = teRodSize.RodSizeID
									ElseIf teRodSize.Diameter > rodSizeList.Item(iRodSize).Diameter Then
										iRodSize = teRodSize.RodSizeID
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						If iRodSize = 0 Then
							Try
								For Each obj2 As Object In rodSizeList
									Dim teRodSize As teRodSize = CType(If((obj2 IsNot Nothing), CType(obj2, DictionaryEntry), dictionaryEntry).Value, teRodSize)
									If iRodSize = 0 Then
										iRodSize = teRodSize.RodSizeID
									ElseIf teRodSize.Diameter < rodSizeList.Item(iRodSize).Diameter Then
										iRodSize = teRodSize.RodSizeID
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
						End If
					End If
				End If
				If iRodSize <> 0 Then
					result = True
				Else
					result = False
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Function GetDefaultRodGrade(iRodType As Integer, iRodGrade As Integer, ByRef iRodGradeAbove As Integer) As Boolean
			Dim result As Boolean
			Try
				Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
				If activeCell.Row.HasPrevSibling() Then
					Dim sibling As UltraGridRow = activeCell.Row.GetSibling(SiblingRow.Previous)
					iRodGradeAbove = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(sibling.Cells("RodGrade").Value)), 0, RuntimeHelpers.GetObjectValue(sibling.Cells("RodGrade").Value)))
					If iRodGrade = iRodGradeAbove And (iRodGrade = 0 Or iRodGrade = -1) Then
						result = True
					Else
						result = False
					End If
				Else
					result = False
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub RSInput_Activated(sender As Object, e As EventArgs)
			Try
				Me.bShowGuides = False
				RSWIN_DESC.sCurrentFormName = "RSInput"
				Me.m_bClosing = False
				Me.m_bFormLoaded = True
				Me.bCheckRodsInTubingMsgShown = False
				Dim control As Control = Me.txtLength
				Me.HideControl(control)
				Me.txtLength = CType(control, TextBox)
				control = Me.txtTempLength
				Me.HideControl(control)
				Me.txtTempLength = CType(control, TextBox)
				If Me.tmp_PumpDepth = 0F Then
					Me.txtTempLength.Tag = "fem"
					Me.txtTempLength.Text = Conversions.ToString(RSWIN_DESC.rst.PumpDepth)
					Dim textBox As TextBox = Me.txtTempLength
					Dim label As Label = Me.lblTemp
					Me.TextBox_Change(textBox, label)
					Me.lblTemp = label
					Me.txtTempLength = textBox
					Me.tmp_PumpDepth = Convert.ToSingle(Me.txtTempLength.Text)
					Me.txtTempLength.Text = ""
				End If
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If rst.RodStringType = 3S Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
						Dim text As String = "DisplaySBinFeet"
						Dim flag As Boolean = True
						RSWIN_DESC.SETUP_DisplaySBinFeet = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_GENERAL, text, flag) > False), 1S, 0S)), 1S, 0S)
						If RSWIN_DESC.SETUP_DisplaySBinFeet <> 0S Then
							Me.txtRSSBLength.Tag = "fee"
						Else
							Me.txtRSSBLength.Tag = "fem"
						End If
					ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
						Me.txtRSSBLength.Tag = "fee"
					Else
						Me.txtRSSBLength.Tag = "fem"
					End If
					If(If((-If((rst.SinkerBar.length > 0F > False), 1S, 0S)), 1S, 0S) And rst.RSIncludeSB) <> 0S Then
						Me.txtRSSBLength.Text = Conversions.ToString(rst.SinkerBar.length)
					Else
						Dim textBox As TextBox = Me.txtRSSBLength
						Dim label As Label = Me.lblRSSBLength
						Me.TextBox_Change(textBox, label)
						Me.lblRSSBLength = label
						Me.txtRSSBLength = textBox
					End If
				End If
				Me.bShowGuides = False
				If RSWIN_DESC.bRodStarD Then
					Me.bShowGuides = True
				End If
				If Not RSWIN_DESC.bRodStarD Then
					Me.lblRSFricCoeff.Visible = False
					Me.txtRSFricCoeff.Visible = False
					Me.lblRodGuides.Visible = False
					Me.cboRSRodGuides.Visible = False
				Else
					Me.m_bRecommendedFricCoefShown = False
				End If
				If Not RSWIN_DESC.bUseLatestGradeChanges Then
					Me.iCorodOrder = 214
					Me.iProrodOrder = 306
					Me.iNorris97 = 4
				Else
					Me.iProrodOrder = 205
					Me.iCorodOrder = 311
					Me.iNorris97 = 7
				End If
				Try
					Me.SetupForm()
				Catch ex As Exception
				End Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				If Not Me.bFormLoaded Then
					Dim flag2 As Boolean = True
					Select Case cRODSTAR.RodStringType
						Case 1S
							Me.miDesignStyle = 4
						Case 2S, 4S
							Me.miDesignStyle = 3
						Case 3S
							Select Case cRODSTAR.giRodDesignStyle
								Case 0S
									Me.miDesignStyle = 0
								Case 1S
									Me.miDesignStyle = 1
							End Select
						Case Else
							flag2 = False
					End Select
					If flag2 Then
						Try
							If Me.miDesignStyle = 3 Then
								Me.tbsRodDesignType.SelectedIndex = Me.miDesignStyle - 1
							Else
								Me.tbsRodDesignType.SelectedIndex = Me.miDesignStyle
							End If
						Catch ex2 As Exception
						End Try
						Me.tbsRodDesignType_Click_1(CShort(Me.miDesignStyle), False, False)
					End If
					If cRODSTAR.RodStringType = 3S Then
						Me.cboRSSBGrade.Enabled = (Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked))
						Me.cboRSSBDiameter.Enabled = (Me.cboRSSBGrade.Enabled And Me.cboRSSBGrade.SelectedIndex >= 0)
						Me.txtRSSBLength.Enabled = ((RSWIN_DESC.rst.RSFGIncludeSteel And RSWIN_DESC.rst.RSIncludeSB And If((-If((Me.cboRSSBDiameter.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S)) <> 0S)
						Me.txtRSSBLengthEnabledChanged()
					End If
				End If
				cRODSTAR = Nothing
				Me.bShowGuides = False
				If RSWIN_DESC.bRodStarD Then
					Me.bShowGuides = True
				End If
				Try
					If Me.MyParentFrm Is Nothing Then
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					End If
					If Me.MyParentFrm IsNot Nothing AndAlso Not Me.MyParentFrm.bClosing Then
						Me.bRunSet = Me.MyParentFrm.GetToolbar2State(0)
					End If
				Catch ex3 As Exception
				End Try
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub ulgTapers_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs)
			Try
				If Operators.CompareString(e.Cell.Column.Key, "RodNum", False) = 0 Then
					e.Cancel = True
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddToArrayList(bAdd As Boolean, ByRef myAL As ArrayList, iValue As Integer, sDisplayValue As String, iOrder As Integer, sAbbrName As String, sXMLstring As String)
			If Operators.CompareString(sAbbrName, "", False) = 0 Then
				sAbbrName = sDisplayValue
			End If
			If Operators.CompareString(sXMLstring, "", False) = 0 Then
				sXMLstring = sDisplayValue
			End If
			If bAdd Then
				myAL.Add(New cRodGrade(iValue, sDisplayValue, iOrder, sAbbrName, sXMLstring))
				Me.$STATIC$AddToArrayList$20712101281458E8EE$iCount = myAL.Count
			Else
				myAL.Insert(Me.$STATIC$AddToArrayList$20712101281458E8EE$iCount, New cRodGrade(iValue, sDisplayValue, iOrder, sAbbrName, sXMLstring))
			End If
		End Sub

		Private Sub AddToGuideArrayList(bAdd As Boolean, ByRef myAL As ArrayList, iValue As Integer, sDisplayValue As String, iOrder As Integer, sAbbrName As String, sXMLstring As String)
			If Operators.CompareString(sAbbrName, "", False) = 0 Then
				sAbbrName = sDisplayValue
			End If
			If Operators.CompareString(sXMLstring, "", False) = 0 Then
				sXMLstring = sDisplayValue
			End If
			If bAdd Then
				myAL.Add(New cRodGuide(iValue, sDisplayValue, iOrder, sAbbrName, sXMLstring))
				Me.$STATIC$AddToGuideArrayList$20712101281458E8EE$iCount = myAL.Count
			Else
				myAL.Insert(Me.$STATIC$AddToGuideArrayList$20712101281458E8EE$iCount, New cRodGuide(iValue, sDisplayValue, iOrder, sAbbrName, sXMLstring))
			End If
		End Sub

		Private Sub txtRSExtraCost_Enter(sender As Object, e As EventArgs)
			Me.txtRSExtraCost.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtServiceFactor_Enter1(sender As Object, e As EventArgs)
			Dim str As String = ""
			Me.txtServiceFactor.BackColor = RSWIN_DESC.rgbEditFocus
			If Versioned.IsNumeric(Me.txtServiceFactor.Text) Then
				Dim obj As Object
				Dim flag As Boolean = CtrlUI.CheckValid(Me.txtServiceFactor, True, False, obj)
				If Me.bUseStatus And Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
					Dim flag2 As Boolean = False
					If Operators.ConditionalCompareObjectEqual(flag2, Util.CheckLower(obj, 0.5F, -1, 61, 0, 0, True, str), False) Then
						Me.lblStatus.Text = " " + str
					ElseIf Operators.ConditionalCompareObjectEqual(flag2, Util.CheckUpper(obj, 1F, -1, 61, 0, 0, True, str), False) Then
						Me.lblStatus.Text = " " + str
					Else
						Me.lblStatus.Text = ""
					End If
					Return
				End If
			Else
				Me.lblStatus.Text = ""
			End If
		End Sub

		Private Sub txtRSExtraCostLabel_TextChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.rst.RSExtraCostLabel = Me.txtRSExtraCostLabel.Text
			Dim txtRSExtraCostLabel As TextBox = Me.txtRSExtraCostLabel
			Dim lblRSExtraCostLabel As Label = Me.lblRSExtraCostLabel
			Me.TextBox_Change(txtRSExtraCostLabel, lblRSExtraCostLabel)
			Me.lblRSExtraCostLabel = lblRSExtraCostLabel
			Me.txtRSExtraCostLabel = txtRSExtraCostLabel
		End Sub

		Private Sub txtRSExtraCostLabel_Enter(sender As Object, e As EventArgs)
			Me.txtRSExtraCostLabel.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtRSExtraCostLabel_Leave(sender As Object, e As EventArgs)
			Me.txtRSExtraCostLabel.BackColor = Color.White
		End Sub

		Private Sub txtServiceFactor_Leave1(sender As Object, e As EventArgs)
			Me.txtServiceFactor.BackColor = Color.White
		End Sub

		Private Sub txtRSExtraCost_Leave(sender As Object, e As EventArgs)
			Me.txtRSExtraCost.BackColor = Color.White
		End Sub

		Private Sub cboRSGrade_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Not Me.bLoadingCombo And Not Me.bLoadingCombo Then
				If RSWIN_DESC.rst.RSMaxSize = 0F Then
					Me.mbMaxMinNotYetSet = True
				End If
				If Me.cboRSGrade.SelectedIndex <> -1 Then
					' The following expression was wrapped in a checked-expression
					Me.cboRSGrade_Click_1(CShort(Me.cboRSGrade.SelectedIndex), Me.cboRSGrade Is Me.ActiveControl)
					If Me.ActiveControl Is Me.cboRSGrade Then
						Dim flag As Boolean = Me.ValidateRSInput(Me.bFormLoaded, True, False)
						Me.Control_SelectedIndexChanged(True)
						Try
							If RSWIN_DESC.rst.RSGrade <> 0S And RSWIN_DESC.rst.RSMinSize <> 0F Then
								Debug.WriteLine("RSGrade=" + Conversions.ToString(CInt(RSWIN_DESC.rst.RSGrade)) + " , RSMinSize =" + Conversions.ToString(RSWIN_DESC.rst.RSMinSize))
								Dim num As Single
								flag = (Me.CheckRSMinSize(RSWIN_DESC.rst.RSGrade, RSWIN_DESC.rst.RSMinSize, num) <> 0F)
								If Not flag And num > 0F Then
									RSWIN_DESC.rst.RSMinSize = num
									Me.LoadMin()
									ini.SaveDataValue("RSMinSize", RSWIN_DESC.rst.RSMinSize)
								End If
							End If
						Catch ex As Exception
						End Try
					End If
				End If
				Return
			End If
		End Sub

		Private Sub cboRSMaxSize_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Not Me.bLoadingCombo Then
				' The following expression was wrapped in a checked-expression
				Me.cboRSMaxSize_Click_1(CShort(Me.cboRSMaxSize.SelectedIndex), Me.ActiveControl Is Me.cboRSMaxSize)
				If Me.ActiveControl Is Me.cboRSMaxSize Then
					Dim flag As Boolean = Me.ValidateRSInput(Me.bFormLoaded, True, False)
					Me.Control_SelectedIndexChanged(True)
					If Me.bUseStatus AndAlso (Me.cboRSMinSize.SelectedIndex <> 1 And Me.cboRSMaxSize.SelectedIndex <> -1) Then
						If RSWIN_DESC.rst.RSMinSize >= RSWIN_DESC.rst.RSMaxSize Then
							Me.lblStatus.Text = " " + Me.sMinLessThanMan
						Else
							Me.lblStatus.Text = ""
						End If
					End If
				End If
				Return
			End If
		End Sub

		Private Sub cboRSSRSize_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Not Me.bLoadingCombo Then
				' The following expression was wrapped in a checked-expression
				Me.cboRSSRSize_Click_1(CShort(Me.cboRSSRSize.SelectedIndex), Me.ActiveControl Is Me.cboRSSRSize)
				If Me.ActiveControl Is Me.cboRSSRSize Then
					Me.Control_SelectedIndexChanged(True)
				End If
				Return
			End If
		End Sub

		Private Sub cboRSMinSize_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Not Me.bLoadingCombo Then
				' The following expression was wrapped in a checked-expression
				Me.cboRSMinSize_Click_1(CShort(Me.cboRSMinSize.SelectedIndex), Me.cboRSMinSize Is Me.ActiveControl)
				If Me.ActiveControl Is Me.cboRSMinSize Then
					Dim flag As Boolean = Me.ValidateRSInput(Me.bFormLoaded, True, False)
					Me.Control_SelectedIndexChanged(True)
					If Me.bUseStatus AndAlso (Me.cboRSMinSize.SelectedIndex <> 1 And Me.cboRSMaxSize.SelectedIndex <> -1) Then
						If RSWIN_DESC.rst.RSMinSize >= RSWIN_DESC.rst.RSMaxSize Then
							Me.lblStatus.Text = " " + Me.sMinLessThanMan
						Else
							Me.lblStatus.Text = ""
						End If
					End If
				End If
				Return
			End If
		End Sub

		Private Sub cboRSSBGrade_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try
				Try
					If Not Me.bLoadingCombo And (Me.miDesignStyle = 0 Or Me.miDesignStyle = 1) Then
						If Me.cboRSSBGrade.SelectedIndex <> -1 Then
							' The following expression was wrapped in a checked-expression
							Me.cboRSSBGrade_Click_1(CShort(Me.cboRSSBGrade.SelectedIndex), Me.ActiveControl Is Me.cboRSSBGrade)
							Me.Control_SelectedIndexChanged(Me.cboRSSBGrade Is Me.ActiveControl)
							Dim flag As Boolean = Me.ValidateRSInput(Me.bFormLoaded, True, False)
						End If
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub cboRSSBDiameter_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try
				Try
					If Not Me.bLoadingCombo AndAlso Me.ActiveControl Is Me.cboRSSBDiameter Then
						If Me.cboRSSBDiameter.SelectedIndex <> -1 Then
							' The following expression was wrapped in a checked-expression
							Me.cboRSSBDiameter_Click_1(CShort(Me.cboRSSBDiameter.SelectedIndex), True, False)
							Me.Control_SelectedIndexChanged(True)
							If RSWIN_DESC.rst.RSSBDiameter <> 0F And RSWIN_DESC.rst.RSMaxSize <> 0F Then
								If RSWIN_DESC.rst.RSSBDiameter <= RSWIN_DESC.rst.RSMaxSize Then
									Me.lblStatus.Text = " " + Me.sSinkerRodDiameterWarningMsg
								End If
							End If
							Dim flag As Boolean = Me.ValidateRSInput(Me.bFormLoaded, True, False)
						End If
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub chkRSIncludeSB_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Try
				Me.chkRSIncludeSB_Click_1(Me.chkRSIncludeSB.Checked, True)
				Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.chkRSIncludeSB)
				If Me.ActiveControl Is Me.chkRSIncludeSB Then
					Dim flag2 As Boolean = Me.ValidateRSInput(Me.bFormLoaded, True, False)
					Me.Control_SelectedIndexChanged(True)
					flag = True
					Me.lblStatus.Text = " "
				End If
				If flag And Not Me.bLoadingCombo Then
					Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
					If Me.optSinkerRods.Checked Then
						If cRODSTAR.RSSBGrade <> 0S AndAlso Me.bIsSB(CInt(cRODSTAR.RSSBGrade)) Then
							cRODSTAR.RSSBGrade = 0S
						End If
						If Me.cboRSSBGrade.SelectedIndex = 0 And cRODSTAR.RSSBGrade = 0S And Me.cboRSSBGrade IsNot Me.ActiveControl Then
							Try
								If Me.optSinkerBars.Checked Then
									cRODSTAR.RSSBGrade = Conversions.ToShort(NewLateBinding.LateGet(Me.cboRSSBGrade.Items(Me.iFlexBarC), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
									ini.SaveDataValue("RSSBGrade", cRODSTAR.RSSBGrade)
									Me.cboRSSBGrade.SelectedIndex = Me.iFlexBarC
								Else
									cRODSTAR.RSSBGrade = Conversions.ToShort(NewLateBinding.LateGet(Me.cboRSSBGrade.Items(Me.iNorris97), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
									ini.SaveDataValue("RSSBGrade", cRODSTAR.RSSBGrade)
									Me.cboRSSBGrade.SelectedIndex = Me.iNorris97
								End If
							Catch ex As Exception
							End Try
							Me.cboRSSBGrade_Click_1(CShort(Me.cboRSSBGrade.SelectedIndex), True)
						End If
					ElseIf Me.optSinkerBars.Checked Then
						If cRODSTAR.RSSBGrade <> 0S Then
							If Not Me.bIsSB(CInt(cRODSTAR.RSSBGrade)) Then
								cRODSTAR.RSSBGrade = 0S
							Else
								Try
									If Me.cboRSSBDiameter.Items.Count = 0 Then
										Me.bLoadingCombo = True
										Me.LoadSBDiameter(cRODSTAR.RSSBGrade)
										Me.bLoadingCombo = False
									End If
								Catch ex2 As Exception
								End Try
							End If
						End If
						If Me.cboRSSBGrade.SelectedIndex = 0 And cRODSTAR.RSSBGrade = 0S And Me.cboRSSBGrade IsNot Me.ActiveControl Then
							Try
								If Me.optSinkerBars.Checked Then
									cRODSTAR.RSSBGrade = Conversions.ToShort(NewLateBinding.LateGet(Me.cboRSSBGrade.Items(Me.iFlexBarC), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
									ini.SaveDataValue("RSSBGrade", cRODSTAR.RSSBGrade)
									Me.cboRSSBGrade.SelectedIndex = Me.iFlexBarC
									cRODSTAR.RSSRSize = cRODSTAR.RSMinSize
								Else
									cRODSTAR.RSSBGrade = Conversions.ToShort(NewLateBinding.LateGet(Me.cboRSSBGrade.Items(Me.iNorris97), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
									ini.SaveDataValue("RSSBGrade", cRODSTAR.RSSBGrade)
									Me.cboRSSBGrade.SelectedIndex = Me.iNorris97
								End If
							Catch ex3 As Exception
							End Try
							Me.cboRSSBGrade_Click_1(CShort(Me.cboRSSBGrade.SelectedIndex), True)
							Try
								If Me.cboRSSBDiameter.Items.Count < 2 Then
									Me.bLoadingCombo = True
									Me.LoadSBDiameter(cRODSTAR.RSSBGrade)
									Me.bLoadingCombo = False
								End If
							Catch ex4 As Exception
							End Try
						End If
					End If
					cRODSTAR = Nothing
				End If
				Me.optSinkerBars.Enabled = Me.chkRSIncludeSB.Checked
				Me.optSinkerRods.Enabled = Me.chkRSIncludeSB.Checked
				Me.txtRSSBLength.Enabled = (Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked))
				If Me.chkRSIncludeSB.Checked And Me.optSinkerBars.Checked Then
					Me.cboRSSRSize.Enabled = True
				Else
					Me.cboRSSRSize.Enabled = False
				End If
			Catch ex5 As Exception
			End Try
		End Sub

		Private Sub optSinkerBars_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = False
				Dim flag2 As Boolean
				If Me.ActiveControl Is Me.optSinkerBars Then
					flag2 = True
					Me.Control_SelectedIndexChanged(True)
				Else
					flag2 = False
				End If
				If Me.optSinkerBars.Checked AndAlso flag2 Then
					Me.optSinkerBars_Click_1(Me.optSinkerBars.Checked, True)
					If Not Me.chkRSIncludeSB.Checked Then
						Me.chkRSIncludeSB.Checked = True
					End If
				End If
				Me.bLoadingCombo = True
				Dim cboRSSBGrade As ComboBox = Me.cboRSSBGrade
				RODUTIL.LoadRodGradeList(cboRSSBGrade, 2, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
				Me.cboRSSBGrade = cboRSSBGrade
				cboRSSBGrade = Me.cboRSSBGrade
				Me.LoadCustomToRodGradeList(cboRSSBGrade, 2, Me.RSSBGrade_AL, False, True)
				Me.cboRSSBGrade = cboRSSBGrade
				Me.bLoadingCombo = False
				Me.cboRSSBDiameter.Enabled = False
				Me.txtRSSBDiameter.Enabled = False
				If Me.optSinkerRods.Checked Then
					ini.SaveDataValue("SinkerRods", True)
				ElseIf Me.optSinkerBars.Checked Then
					ini.SaveDataValue("SinkerRods", False)
				End If
				If Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked) Then
					Dim txtRSSBLength As TextBox = Me.txtRSSBLength
					Util.SetFieldColor(txtRSSBLength)
					Me.txtRSSBLength = txtRSSBLength
				End If
				If flag2 Then
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					If Not Me.bLoadingCombo And Me.optSinkerBars.Checked Then
						If rst.RSSBGrade <> 0S AndAlso Not Me.bIsSB(CInt(rst.RSSBGrade)) Then
							rst.RSSBGrade = 0S
							flag = True
						End If
						If(Me.cboRSSBGrade.SelectedIndex = 0 OrElse flag) And rst.RSSBGrade = 0S And Me.cboRSSBGrade IsNot Me.ActiveControl Then
							Try
								Try
									If Me.optSinkerBars.Checked Then
										Dim sinkerBar As RSWIN_DESC.RodSection
										sinkerBar.Initialize()
										sinkerBar = rst.SinkerBar
										rst.RSSBGrade = Conversions.ToShort(NewLateBinding.LateGet(Me.cboRSSBGrade.Items(Me.iFlexBarC), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
										sinkerBar.Grade = rst.RSSBGrade
										ini.SaveDataValue("RSSBGrade", rst.RSSBGrade)
										rst.RSSBDiameter = 1.5F
										sinkerBar.Diameter = 1.5F
										Me.cboRSSBGrade.SelectedIndex = Me.iFlexBarC
										rst.SinkerBar = sinkerBar
									Else
										Dim sinkerBar As RSWIN_DESC.RodSection
										sinkerBar.Initialize()
										sinkerBar = rst.SinkerBar
										rst.RSSBGrade = Conversions.ToShort(NewLateBinding.LateGet(Me.cboRSSBGrade.Items(Me.iNorris97), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
										sinkerBar.Grade = rst.RSSBGrade
										ini.SaveDataValue("RSSBGrade", rst.RSSBGrade)
										rst.RSSBDiameter = 1F
										sinkerBar.Diameter = 1F
										Me.cboRSSBGrade.SelectedIndex = Me.iNorris97
										rst.SinkerBar = sinkerBar
									End If
								Catch ex As Exception
								End Try
								Me.cboRSSBGrade_Click_1(CShort(Me.cboRSSBGrade.SelectedIndex), True)
							Catch ex2 As Exception
							End Try
						End If
					End If
				End If
				If flag2 Then
					Me.chkRSIncludeSB.Enabled = True
					Me.optSinkerBars.Enabled = True
					Me.cboRSSBGrade.Enabled = (Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked))
					Me.cboRSSBDiameter.Enabled = (Me.cboRSSBGrade.Enabled And Me.cboRSSBGrade.SelectedIndex >= 0)
					Me.txtRSSBLength.Enabled = ((RSWIN_DESC.rst.RSFGIncludeSteel And RSWIN_DESC.rst.RSIncludeSB And If((-If((Me.cboRSSBDiameter.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S)) <> 0S)
					Me.txtRSSBLengthEnabledChanged()
				End If
				If Me.chkRSIncludeSB.Checked And Me.optSinkerBars.Checked Then
					Me.cboRSSRSize.Enabled = True
				Else
					Me.cboRSSRSize.Enabled = False
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub optSinkerRods_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim flag2 As Boolean
			If Me.ActiveControl Is Me.optSinkerRods Then
				flag2 = True
				Me.Control_SelectedIndexChanged(True)
			Else
				flag2 = False
			End If
			If Me.optSinkerRods.Checked AndAlso flag2 Then
				Me.optSinkerRods_Click_1(Me.optSinkerRods.Checked, True)
				If Not Me.chkRSIncludeSB.Checked Then
					Me.chkRSIncludeSB.Checked = True
				End If
			End If
			Me.bLoadingCombo = True
			Dim cboRSSBGrade As ComboBox = Me.cboRSSBGrade
			RODUTIL.LoadRodGradeList(cboRSSBGrade, 0, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
			Me.cboRSSBGrade = cboRSSBGrade
			cboRSSBGrade = Me.cboRSSBGrade
			RODUTIL.LoadRodGradeList(cboRSSBGrade, 3, Me.RSSBGrade_AL, False, False, False, False, False, False, False)
			Me.cboRSSBGrade = cboRSSBGrade
			cboRSSBGrade = Me.cboRSSBGrade
			RODUTIL.LoadRodGradeList(cboRSSBGrade, 6, Me.RSSBGrade_AL, False, False, False, False, False, False, False)
			Me.cboRSSBGrade = cboRSSBGrade
			cboRSSBGrade = Me.cboRSSBGrade
			Me.LoadCustomToRodGradeList(cboRSSBGrade, 0, Me.RSSBGrade_AL, False, True)
			Me.cboRSSBGrade = cboRSSBGrade
			Me.bLoadingCombo = False
			Me.cboRSSBDiameter.Enabled = False
			Me.txtRSSBDiameter.Enabled = False
			If Me.optSinkerRods.Checked Then
				ini.SaveDataValue("SinkerRods", True)
			ElseIf Me.optSinkerBars.Checked Then
				ini.SaveDataValue("SinkerRods", False)
			End If
			If flag2 Then
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Not Me.bLoadingCombo And Me.optSinkerRods.Checked Then
					If(rst.RSSBGrade <> 0S Or rst.SinkerBar.Grade <> 0S) AndAlso (Me.bIsSB(CInt(rst.RSSBGrade)) Or Me.bIsSB(CInt(rst.SinkerBar.Grade))) Then
						rst.RSSBGrade = 0S
						flag = True
					End If
					If(Me.cboRSSBGrade.SelectedIndex = 0 OrElse flag) And rst.RSSBGrade = 0S And Me.cboRSSBGrade IsNot Me.ActiveControl Then
						Try
							If Me.optSinkerBars.Checked Then
								Dim sinkerBar As RSWIN_DESC.RodSection
								sinkerBar.Initialize()
								sinkerBar = rst.SinkerBar
								rst.RSSBGrade = Conversions.ToShort(NewLateBinding.LateGet(Me.cboRSSBGrade.Items(Me.iFlexBarC), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
								sinkerBar.Grade = rst.RSSBGrade
								ini.SaveDataValue("RSSBGrade", rst.RSSBGrade)
								rst.RSSBDiameter = 1.5F
								sinkerBar.Diameter = 1.5F
								Me.cboRSSBGrade.SelectedIndex = Me.iFlexBarC
								rst.SinkerBar = sinkerBar
							Else
								Dim sinkerBar As RSWIN_DESC.RodSection
								sinkerBar.Initialize()
								sinkerBar = rst.SinkerBar
								rst.RSSBGrade = Conversions.ToShort(NewLateBinding.LateGet(Me.cboRSSBGrade.Items(Me.iNorris97), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
								sinkerBar.Grade = rst.RSSBGrade
								ini.SaveDataValue("RSSBGrade", rst.RSSBGrade)
								rst.RSSBDiameter = 1F
								sinkerBar.Diameter = 1F
								Me.cboRSSBGrade.SelectedIndex = Me.iNorris97
								rst.SinkerBar = sinkerBar
							End If
							Me.cboRSSBGrade_Click_1(CShort(Me.cboRSSBGrade.SelectedIndex), True)
						Catch ex As Exception
						End Try
					End If
				End If
			End If
			If flag2 Then
				Me.chkRSIncludeSB.Enabled = True
				Me.chkRSIncludeSB.Checked = True
				Me.optSinkerRods.Enabled = True
				Me.cboRSSBGrade.Enabled = (Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked))
				Me.cboRSSBDiameter.Enabled = (Me.cboRSSBGrade.Enabled And Me.cboRSSBGrade.SelectedIndex >= 0)
				Me.txtRSSBLength.Enabled = ((RSWIN_DESC.rst.RSFGIncludeSteel And RSWIN_DESC.rst.RSIncludeSB And If((-If((Me.cboRSSBDiameter.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S)) <> 0S)
				Me.txtRSSBLengthEnabledChanged()
				Return
			End If
		End Sub

		Private Sub cboRSFGGrade_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try
				If Me.cboRSFGGrade Is Me.ActiveControl Then
					Me.Control_SelectedIndexChanged(True)
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim cboRSFGGrade As ComboBox = Me.cboRSFGGrade
					Dim num As Short = CShort(RODUTIL.ConvertListIndexToRodGrade(cboRSFGGrade, Me.cboRSFGGrade.SelectedIndex))
					Me.cboRSFGGrade = cboRSFGGrade
					rst.RSFGGrade = num
					Select Case RSWIN_DESC.rst.RSFGGrade
						Case 16385S, 16389S, 16390S
							RSWIN_DESC.rst.RSSuckerRodLength = 37.5F
					End Select
					If RSWIN_DESC.rst.RodStringType = 3S And RSWIN_DESC.rst.giRodDesignStyle = 1S Then
						Me.chkRSIncludeSB.Enabled = (Me.cboRSFGGrade.SelectedIndex >= 0)
					End If
					ini.SaveDataValue("RSFGGrade", RSWIN_DESC.rst.RSFGGrade)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboRSMinSize_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub cboRSMaxSize_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub cboRSGrade_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-expression
			Me.cboRSGrade_Click_1(CShort(Me.cboRSGrade.SelectedIndex), Me.ActiveControl Is Me.cboRSGrade)
		End Sub

		Private Sub cboRSSBGrade_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub tbsRodDesignType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try
				If Me.ActiveControl Is Me.tbsRodDesignType Then
					Dim tbsRodDesignType As TabControl = Me.tbsRodDesignType
					Me.Control_SelectedIndexChanged(Me.bRodDesignTypeClicked)
					Me.tbsRodDesignType_Click_1(CShort(tbsRodDesignType.SelectedTab.TabIndex), True, False)
					Me.Text = Conversions.ToString(tbsRodDesignType.SelectedTab.Tag)
					Me.bRodDesignTypeClicked = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboRSFGGrade_Click(sender As Object, e As EventArgs)
		End Sub

		Private Function PreviousSectionsHaveLengths() As Boolean
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				Try
					If RSWIN_DESC.rst.NumRods > 1S Then
						If Me.mdsRodTapers IsNot Nothing Then
							Try
								For Each obj As Object In Me.mdsRodTapers.Tables(0).Rows
									Dim dataRow As DataRow = CType(obj, DataRow)
									Dim num As Integer = Conversions.ToInteger(dataRow("RodNum"))
									If Operators.ConditionalCompareObjectLess(dataRow("RodNum"), RSWIN_DESC.rst.NumRods, False) Then
										If Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("RodLength"))) Then
											flag = False
											Exit For
										End If
										If Operators.ConditionalCompareObjectEqual(dataRow("RodLength"), 0, False) Then
											flag = False
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
						End If
						result = flag
					Else
						result = flag
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub txtRSSBLength_Leave(sender As Object, e As EventArgs)
			Dim str As String = ""
			If Me.chkRSIncludeSB.Checked Then
				If Me.txtRSSBLength.Enabled Then
					If Not Me.bUseStatus Then
						Dim flag As Boolean = False
						Dim obj As Object
						If flag <> CtrlUI.CheckValid(Me.txtRSSBLength, True, False, obj) Then
							Dim obj2 As Object = flag
							Dim lowerBound As Single = 25F
							Dim inclusive As Integer = -1
							Dim errnum As Integer = 59
							Dim useMetric As Integer = -1
							Dim canadianIsMetric As Integer = -1
							Dim bQuiet As Boolean = False
							Dim text As String = ""
							If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
								Me.txtRSSBLength.Focus()
							Else
								Dim obj3 As Object = flag
								Dim upperBound As Single = RSWIN_DESC.rst.PumpDepth / 2F
								Dim inclusive2 As Integer = 0
								Dim errnum2 As Integer = 137
								Dim useMetric2 As Integer = -1
								Dim canadianIsMetric2 As Integer = -1
								Dim bQuiet2 As Boolean = False
								text = ""
								If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
									Me.txtRSSBLength.Focus()
								Else
									Dim obj4 As Object = flag
									Dim upperBound2 As Single = 2000F
									Dim inclusive3 As Integer = -1
									Dim errnum3 As Integer = 135
									Dim useMetric3 As Integer = -1
									Dim canadianIsMetric3 As Integer = -1
									Dim bQuiet3 As Boolean = False
									text = ""
									If Operators.ConditionalCompareObjectEqual(obj4, Util.CheckUpper(obj, upperBound2, inclusive3, errnum3, useMetric3, canadianIsMetric3, bQuiet3, text), False) Then
										Me.txtRSSBLength.Focus()
									Else
										Dim txtRSSBLength As TextBox = Me.txtRSSBLength
										Dim lblRSSBLength As Label = Me.lblRSSBLength
										CtrlUI.TextBox_LostFocus(txtRSSBLength, lblRSSBLength, True)
										Me.lblRSSBLength = lblRSSBLength
										Me.txtRSSBLength = txtRSSBLength
										ini.SaveDataValue("RSSBLength", RuntimeHelpers.GetObjectValue(obj))
										If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
											Dim sinkerBar As RSWIN_DESC.RodSection = RSWIN_DESC.rst.SinkerBar
											sinkerBar.length = Conversions.ToSingle(obj)
											RSWIN_DESC.rst.SinkerBar = sinkerBar
											If Operators.ConditionalCompareObjectLess(obj, 100, False) Then
												Me.lblStatus.Text = Conversions.ToString(Operators.ConcatenateObject(" ", Interaction.IIf(RSWIN_DESC.bRodStarD, Me.sSmallLengthD, Me.sSmallLengthV)))
												Me.bLengthError = True
											End If
										End If
									End If
								End If
							End If
						End If
					Else
						Dim flag2 As Boolean = False
						Dim obj As Object
						If flag2 <> CtrlUI.CheckValid(Me.txtRSSBLength, True, False, obj) Then
							If Operators.ConditionalCompareObjectEqual(flag2, Util.CheckLower(obj, 25F, -1, 59, -1, -1, True, str), False) Then
								Me.lblStatus.Text = " " + str
							ElseIf Operators.ConditionalCompareObjectEqual(flag2, Util.CheckUpper(obj, RSWIN_DESC.rst.PumpDepth / 2F, 0, 137, -1, -1, True, str), False) Then
								Me.lblStatus.Text = " " + str
							ElseIf Operators.ConditionalCompareObjectEqual(flag2, Util.CheckUpper(obj, 2000F, -1, 135, -1, -1, True, str), False) Then
								Me.lblStatus.Text = " " + str
							Else
								Me.lblStatus.Text = ""
							End If
						End If
						If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
							Dim txtRSSBLength As TextBox = Me.txtRSSBLength
							Dim lblRSSBLength As Label = Me.lblRSSBLength
							CtrlUI.TextBox_LostFocus(txtRSSBLength, lblRSSBLength, True)
							Me.lblRSSBLength = lblRSSBLength
							Me.txtRSSBLength = txtRSSBLength
							ini.SaveDataValue("RSSBLength", RuntimeHelpers.GetObjectValue(obj))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
								Dim sinkerBar As RSWIN_DESC.RodSection = RSWIN_DESC.rst.SinkerBar
								sinkerBar.length = Conversions.ToSingle(obj)
								RSWIN_DESC.rst.SinkerBar = sinkerBar
								If Operators.ConditionalCompareObjectLess(obj, 100, False) Then
									Me.lblStatus.Text = Conversions.ToString(Operators.ConcatenateObject(" ", Interaction.IIf(RSWIN_DESC.bRodStarD, Me.sSmallLengthD, Me.sSmallLengthV)))
									Me.bLengthError = True
								End If
							End If
						End If
					End If
				End If
				Return
			End If
		End Sub

		Private Sub txtRSSBDiameter_TextChanged(sender As Object, e As EventArgs)
			Try
				Dim txtRSSBDiameter As TextBox = Me.txtRSSBDiameter
				Dim lblRSSBDiameter As Label = Me.lblRSSBDiameter
				Me.TextBox_Change(txtRSSBDiameter, lblRSSBDiameter)
				Me.lblRSSBDiameter = lblRSSBDiameter
				Me.txtRSSBDiameter = txtRSSBDiameter
				If Versioned.IsNumeric(Me.txtRSSBDiameter.Text) Then
					If Convert.ToSingle(Me.txtRSSBDiameter.Text) <> 0F Then
						Dim flag As Boolean = False
						Dim obj As Object
						If flag <> CtrlUI.CheckValid(Me.txtRSSBDiameter, True, False, obj) Then
							ini.SaveDataValue("RSSBDiameter", RuntimeHelpers.GetObjectValue(obj))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
								Dim sinkerBar As RSWIN_DESC.RodSection = RSWIN_DESC.rst.SinkerBar
								RSWIN_DESC.rst.SinkerBar = sinkerBar
							End If
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtRSSBDiameter_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtRSSBDiameter, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 0.75F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 57
				Dim useMetric As Integer = -1
				Dim canadianIsMetric As Integer = -1
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtRSSBDiameter.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 2F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 57
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = -1
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtRSSBDiameter.Focus()
					Else
						Dim txtRSSBDiameter As TextBox = Me.txtRSSBDiameter
						Dim label As Label = Nothing
						CtrlUI.TextBox_LostFocus(txtRSSBDiameter, label, True)
						Me.txtRSSBDiameter = txtRSSBDiameter
						ini.SaveDataValue("RSSBDiameter", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							Dim sinkerBar As RSWIN_DESC.RodSection = RSWIN_DESC.rst.SinkerBar
							sinkerBar.Diameter = Conversions.ToSingle(obj)
							sinkerBar.Area = CSng((Math.Pow(CDbl(sinkerBar.Diameter), 2.0) * 3.141592653589793 / 4.0))
							RSWIN_DESC.rst.SinkerBar = sinkerBar
						End If
					End If
				End If
			End If
		End Sub

		Private Sub chkRSFGIncludeSteel_CheckedChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.rst.RSFGIncludeSteel = If((-If((Me.chkRSFGIncludeSteel.Checked > False), 1S, 0S)), 1S, 0S)
			Me.chkRSFGIncludeSteel_Click_1(RSWIN_DESC.rst.RSFGIncludeSteel <> 0S, True, True)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.chkRSFGIncludeSteel)
			If Me.ActiveControl Is Me.chkRSFGIncludeSteel Then
				Me.lblStatus.Text = " "
				Return
			End If
		End Sub

		Private Sub picRemoveFocus_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Private Sub txtRSFricCoeff_Enter(sender As Object, e As EventArgs)
			If RSWIN_DESC.rst.RSRodGuide > 0 Then
				Dim fricCoeff As Single = RODUTIL.GetFricCoeff(RSWIN_DESC.rst.RSRodGuide, True)
				If fricCoeff <> RSWIN_DESC.rst.RSFricCoef And Me.bFormLoaded Then
					Interaction.Beep()
					Me.lblStatus.Text = String.Concat(New String() { "The drag friction coefficient you entered (", Conversions.ToString(RSWIN_DESC.rst.RSFricCoef), ") is different than the one you entered in Setup for this type of rod guide (", Conversions.ToString(fricCoeff), ")." })
				End If
			End If
		End Sub

		Private Sub txtRSFricCoeff_TextChanged(sender As Object, e As EventArgs)
			Dim txtRSFricCoeff As TextBox = Me.txtRSFricCoeff
			Dim lblRSFricCoeff As Label = Me.lblRSFricCoeff
			Me.TextBox_Change(txtRSFricCoeff, lblRSFricCoeff)
			Me.lblRSFricCoeff = lblRSFricCoeff
			Me.txtRSFricCoeff = txtRSFricCoeff
			If Versioned.IsNumeric(Me.txtRSFricCoeff.Text) Then
				RSWIN_DESC.rst.RSFricCoef = Convert.ToSingle(Me.txtRSFricCoeff.Text)
				ini.SaveDataValue("RSFricCoef", RSWIN_DESC.rst.RSFricCoef)
				If RSWIN_DESC.rst.RSRodGuide > 0 Then
					Dim fricCoeff As Single = RODUTIL.GetFricCoeff(RSWIN_DESC.rst.RSRodGuide, True)
					If fricCoeff <> RSWIN_DESC.rst.RSFricCoef And Me.bFormLoaded Then
						Interaction.Beep()
						Me.lblStatus.Text = String.Concat(New String() { "The drag friction coefficient you entered (", Conversions.ToString(RSWIN_DESC.rst.RSFricCoef), ") is different than the one you entered in Setup for this type of rod guide (", Conversions.ToString(fricCoeff), ")." })
					End If
				End If
				Return
			End If
		End Sub

		Private Sub txtRSExtraCost_TextChanged(sender As Object, e As EventArgs)
			Dim txtRSExtraCost As TextBox = Me.txtRSExtraCost
			Dim lbRSExtraCost As Label = Me.lbRSExtraCost
			Me.TextBox_Change(txtRSExtraCost, lbRSExtraCost)
			Me.lbRSExtraCost = lbRSExtraCost
			Me.txtRSExtraCost = txtRSExtraCost
			If Versioned.IsNumeric(Me.txtRSExtraCost.Text) Then
				RSWIN_DESC.rst.RSExtraCost = Convert.ToSingle(Me.txtRSExtraCost.Text)
				Return
			End If
		End Sub

		Private Sub txtRSSBDiameter_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtRSSBDiameter.Enabled Then
				Me.lblRSSBDiameter_Disabled.SendToBack()
			Else
				Me.lblRSSBDiameter_Disabled.BringToFront()
			End If
		End Sub

		Public Sub ChangeSectionFricCoef(fFricCoeff As Single)
			Try
				Try
					For Each obj As Object In Me.mdsRodTapers.Tables(0).Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						If Operators.ConditionalCompareObjectLess(dataRow("RodFrictionCoef"), 0.2, False) Then
							dataRow("RodFrictionCoef") = 0.2
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Dim ulgTapers As UltraGrid = Me.ulgTapers
				ulgTapers.DataSource = Nothing
				ulgTapers.DataSource = Me.mdsRodTapers
				Me.ulgTapers.Rows.Refresh(RefreshRow.RefreshDisplay, True)
				Me.ulgTapers.Refresh()
				Application.DoEvents()
				Application.DoEvents()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SetToZeroFromDataSet(RodNum As Integer)
			Dim flag As Boolean = False
			Try
				If Me.mdsRodTapers IsNot Nothing Then
					Try
						For Each obj As Object In Me.mdsRodTapers.Tables(0).Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							Dim num As Integer = Conversions.ToInteger(dataRow("RodNum"))
							If num = RodNum Then
								dataRow("RodLength") = 0
								flag = True
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					If flag Then
						Dim ulgTapers As UltraGrid = Me.ulgTapers
						ulgTapers.DataSource = Nothing
						ulgTapers.DataSource = Me.mdsRodTapers
						Me.ulgTapers.Rows.Refresh(RefreshRow.RefreshDisplay, True)
						Me.MakeRowActive(RodNum)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtLength_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.F2 Then
				Dim txtLength As TextBox = Me.txtLength
				Dim label_Length As Label = Me._Label_Length
				CtrlUI.TextBox_KeyDown(txtLength, label_Length, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
				Me._Label_Length = label_Length
				Me.txtLength = txtLength
				Me.txtLength.Focus()
				Return
			End If
		End Sub

		Private Sub SetActiveControl(ByRef myControl As Control)
			Try
				myControl.Focus()
				If Me.ActiveControl IsNot myControl Then
					Me.ActiveControl = myControl
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetTextValue(myText As TextBox) As String
			Dim result As String
			Try
				If Versioned.IsNumeric(myText.Text) Then
					Dim num As Single = Convert.ToSingle(myText.Text)
					If Conversions.ToBoolean(Operators.AndObject(RSWIN_DESC.SETUP_MeasurementSystem = 1, Operators.CompareObjectEqual(myText.Tag, "fmm", False))) Then
						num = num * 1F / RSWIN_DESC.FT__M
					ElseIf Conversions.ToBoolean(Operators.AndObject(RSWIN_DESC.SETUP_MeasurementSystem <> 1, Operators.CompareObjectEqual(myText.Tag, "fem", False))) Then
						num *= RSWIN_DESC.FT__M
					End If
					result = Conversions.ToString(num)
				Else
					result = ""
				End If
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function

		Private Sub ulgTapers_AfterEnterEditMode(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.PreviousColumn, Me.CurrentColumn, False) <> 0 And Operators.CompareString(Me.CurrentColumn, "RodFrictionCoef", False) <> 0 Then
				Me.lblStatus.Text = ""
				Return
			End If
		End Sub

		Private Sub txtLength_Leave(sender As Object, e As EventArgs)
			If Me.bF2Hit Then
				If Not Me.btxtLengthHasFocus Then
					Me.txtLength.Focus()
					Me.btxtLengthHasFocus = True
				Else
					If Me.ulgTapers.ActiveCell Is Nothing Then
						Me.ulgTapers.ActiveCell = Me.ThisF2Cell
						If Me.ulgTapers.ActiveRow Is Nothing Then
							Me.ulgTapers.ActiveRow = Me.ThisF2Row
						End If
					End If
					Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
					If Operators.CompareString(activeCell.Column.Key, "RodLength", False) = 0 Then
						Dim text As String = Me.txtLength.Text
						Dim flag As Boolean = Versioned.IsNumeric(text)
						If flag Then
							Dim ulgTapers As UltraGrid = Me.ulgTapers
							Dim flag2 As Boolean
							If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ulgTapers.ActiveCell.Value)) Then
								Dim textValue As String = Me.GetTextValue(Me.txtLength)
								If Operators.CompareString(textValue, "", False) <> 0 Then
									ulgTapers.ActiveCell.Value = Me.GetTextValue(Me.txtLength)
								End If
								flag2 = True
							Else
								Dim textValue As String = Me.GetTextValue(Me.txtLength)
								If Operators.CompareString(textValue, "", False) <> 0 Then
									ulgTapers.ActiveCell.Value = Me.GetTextValue(Me.txtLength)
								End If
								flag2 = True
							End If
							If flag2 Then
								Me.txtLength.Text = ""
							End If
						End If
					End If
					Me.bF2Hit = False
					Me.btxtLengthHasFocus = False
					Dim txtLength As Control = Me.txtLength
					CtrlUI.Control_LostFocus(txtLength)
					Me.txtLength = CType(txtLength, TextBox)
					txtLength = Me.txtLength
					Me.HideControl(txtLength)
					Me.txtLength = CType(txtLength, TextBox)
				End If
			End If
		End Sub

		Private Sub RSInput_Closing(sender As Object, e As CancelEventArgs)
			Me.m_bClosing = True
			Dim flag As Boolean = Me.ValidateRSInput(Me.bFormLoaded, False, False)
			If Not Me.m_bClosing Or (Me.m_bClosing And Not flag) Then
				e.Cancel = True
				Return
			End If
			RSWIN_DESC.sCurrentFormName = ""
		End Sub

		Private Sub RSInput_Closed(sender As Object, e As EventArgs)
			Me.m_bClosing = False
			Me.bFormLoaded = False
		End Sub

		Private Sub ulgTapers_Leave(sender As Object, e As EventArgs)
			Me.bEnterEditmode = False
		End Sub

		Private Sub TextBox_Enable(ByRef myText As TextBox, bEnable As Boolean, bVisible As Boolean)
			myText.Enabled = bEnable
			myText.Visible = bVisible
		End Sub

		Public Sub CenterForm()
			' The following expression was wrapped in a checked-statement
			Try
				If Me.MyParentFrm Is Nothing Then
					Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
				End If
				Me.Left = CInt(Math.Round(CDbl((Me.MyParentFrm.Width - Me.Width)) / 2.0 - 8.0))
				Me.Top = CInt(Math.Round(CDbl((Me.MyParentFrm.Height - Me.Height)) / 2.0 - CDbl(Me.MyParentFrm.ParentToolbarHeight())))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtServiceFactor_TextChanged(sender As Object, e As EventArgs)
			Dim str As String = ""
			Dim txtServiceFactor As TextBox = Me.txtServiceFactor
			Dim lblServiceFactor As Label = Me.lblServiceFactor
			Me.TextBox_Change(txtServiceFactor, lblServiceFactor)
			Me.lblServiceFactor = lblServiceFactor
			Me.txtServiceFactor = txtServiceFactor
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtServiceFactor, True, False, obj) Then
				txtServiceFactor = Me.txtServiceFactor
				lblServiceFactor = Me.lblServiceFactor
				Me.TextBox_Change(txtServiceFactor, lblServiceFactor)
				Me.lblServiceFactor = lblServiceFactor
				Me.txtServiceFactor = txtServiceFactor
				ini.SaveDataValue("ServiceFactor", RuntimeHelpers.GetObjectValue(obj))
				Util.Message("")
				If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.rst.ServiceFactor = Conversions.ToSingle(obj)
				End If
			End If
			If Me.bUseStatus And Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				Dim flag2 As Boolean = False
				If Operators.ConditionalCompareObjectEqual(flag2, Util.CheckLower(obj, 0.5F, -1, 61, 0, 0, True, str), False) Then
					Me.lblStatus.Text = " " + str
				ElseIf Operators.ConditionalCompareObjectEqual(flag2, Util.CheckUpper(obj, 1F, -1, 61, 0, 0, True, str), False) Then
					Me.lblStatus.Text = " " + str
				Else
					Me.lblStatus.Text = ""
				End If
			End If
		End Sub

		Public Sub LoadRSMaxSize()
			' The following expression was wrapped in a checked-statement
			Try
				Me.myRSMaxDiamAL.Clear()
				If RSWIN_DESC.rst.RSGrade > 0S Then
					Dim rsgrade As Short = RSWIN_DESC.rst.RSGrade
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim rsrodType As String = rst.RSRodType
					Me.LoadDiameterList(Me.myRSMaxDiamAL, Me.myRSMaxDiamRodSizeArray, rsgrade, rsrodType, True)
					rst.RSRodType = rsrodType
					Dim arrayList As ArrayList
					Try
						Dim comparer As RSInput.rsaComparer = New RSInput.rsaComparer()
						Array.Sort(Me.myRSMaxDiamRodSizeArray, comparer)
						arrayList = New ArrayList()
						arrayList.Clear()
						Dim num As Integer = 0
						Dim num2 As Integer = Me.myRSMaxDiamRodSizeArray.Length - 1
						For i As Integer = num To num2
							If Me.myRSMaxDiamRodSizeArray(i).rsaRodSizeID <> 0 And Me.myRSMaxDiamRodSizeArray(i).rsaDisplayName <> Nothing Then
								arrayList.Add(New cRodSize(Me.myRSMaxDiamRodSizeArray(i).rsaRodSizeID, Me.myRSMaxDiamRodSizeArray(i).rsaDisplayName))
							End If
						Next
					Catch ex As Exception
					End Try
					Me.myRSMaxDiamAL = arrayList
					Try
						Me.cboRSMaxSize.SelectedItem = Nothing
					Catch ex2 As Exception
					End Try
					Try
						Me.cboRSMaxSize.Items.Clear()
					Catch ex3 As Exception
					End Try
					Try
						Me.cboRSMaxSize.DataSource = Nothing
					Catch ex4 As Exception
					End Try
					Me.cboRSMaxSize.DataSource = Me.myRSMaxDiamAL
					Me.cboRSMaxSize.DisplayMember = "DisplayName"
					Me.cboRSMaxSize.ValueMember = "RodSizeID"
					If RSWIN_DESC.bRodStarD Then
						Dim rsgrade2 As Short = RSWIN_DESC.rst.RSGrade
						rst = RSWIN_DESC.rst
						rsrodType = rst.RSRodType
						Me.LoadDiameterList(Me.myRSSRDiamAL, Me.myRSSRDiamRodSizeArray, rsgrade2, rsrodType, True)
						rst.RSRodType = rsrodType
						Dim arrayList2 As ArrayList
						Try
							Dim comparer2 As RSInput.rsaComparer = New RSInput.rsaComparer()
							Array.Sort(Me.myRSSRDiamRodSizeArray, comparer2)
							arrayList2 = New ArrayList()
							arrayList2.Clear()
							Dim num3 As Integer = 0
							Dim num4 As Integer = Me.myRSSRDiamRodSizeArray.Length - 1
							For i As Integer = num3 To num4
								If Me.myRSSRDiamRodSizeArray(i).rsaRodSizeID <> 0 And Me.myRSSRDiamRodSizeArray(i).rsaDisplayName <> Nothing Then
									arrayList2.Add(New cRodSize(Me.myRSSRDiamRodSizeArray(i).rsaRodSizeID, Me.myRSSRDiamRodSizeArray(i).rsaDisplayName))
								End If
							Next
						Catch ex5 As Exception
						End Try
						Me.myRSSRDiamAL = arrayList2
						Try
							Me.cboRSSRSize.SelectedItem = Nothing
						Catch ex6 As Exception
						End Try
						Try
							Me.cboRSSRSize.Items.Clear()
						Catch ex7 As Exception
						End Try
						Try
							Me.cboRSSRSize.DataSource = Nothing
						Catch ex8 As Exception
						End Try
						Me.cboRSSRSize.DataSource = Me.myRSSRDiamAL
						Me.cboRSSRSize.DisplayMember = "DisplayName"
						Me.cboRSSRSize.ValueMember = "RodSizeID"
					End If
				End If
			Catch ex9 As Exception
			End Try
		End Sub

		Public Sub LoadRSMinSize()
			' The following expression was wrapped in a checked-statement
			Try
				Me.myRSMinDiamAL.Clear()
				If RSWIN_DESC.rst.RSGrade > 0S Then
					Dim rsgrade As Short = RSWIN_DESC.rst.RSGrade
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim rsrodType As String = rst.RSRodType
					Me.LoadDiameterList(Me.myRSMinDiamAL, Me.myRSMinDiamRodSizeArray, rsgrade, rsrodType, True)
					rst.RSRodType = rsrodType
					Dim arrayList As ArrayList
					Try
						Dim comparer As RSInput.rsaComparer = New RSInput.rsaComparer()
						Array.Sort(Me.myRSMinDiamRodSizeArray, comparer)
						arrayList = New ArrayList()
						arrayList.Clear()
						Dim num As Integer = 0
						Dim num2 As Integer = Me.myRSMinDiamRodSizeArray.Length - 1
						For i As Integer = num To num2
							If Me.myRSMinDiamRodSizeArray(i).rsaRodSizeID <> 0 And Me.myRSMinDiamRodSizeArray(i).rsaDisplayName <> Nothing Then
								arrayList.Add(New cRodSize(Me.myRSMinDiamRodSizeArray(i).rsaRodSizeID, Me.myRSMinDiamRodSizeArray(i).rsaDisplayName))
							End If
						Next
					Catch ex As Exception
					End Try
					Me.myRSMinDiamAL = arrayList
					Try
						Me.cboRSMinSize.Items.Clear()
					Catch ex2 As Exception
					End Try
					Try
						Me.cboRSMinSize.DataSource = Nothing
					Catch ex3 As Exception
					End Try
					Me.cboRSMinSize.DataSource = Me.myRSMinDiamAL
					Me.cboRSMinSize.DisplayMember = "DisplayName"
					Me.cboRSMinSize.ValueMember = "RodSizeID"
				End If
			Catch ex4 As Exception
			End Try
		End Sub

		Public Sub DebugArrayListAndCombobox(ByRef myList As ArrayList, ByRef cbo As ComboBox)
			Dim enumerator As IEnumerator = myList.GetEnumerator()
			Try
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim cRodSize As cRodSize = CType(obj, cRodSize)
					Debug.WriteLine(Conversions.ToString(cRodSize.RodSizeID) + " , " + cRodSize.DisplayName)
				End While
			Catch ex As Exception
			End Try
			Dim num As Integer = 0
			Dim num2 As Integer = cbo.Items.Count - 1
			For i As Integer = num To num2
				Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(cbo.Items(i), Nothing, "RodSizeID", New Object(-1) {}, Nothing, Nothing, Nothing), " , "), NewLateBinding.LateGet(cbo.Items(i), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
			Next
		End Sub

		Private Sub txtRSSBLength_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtRSSBLength As TextBox = Me.txtRSSBLength
			Dim lblRSSBLength As Label = Me.lblRSSBLength
			CtrlUI.TextBox_KeyDown(txtRSSBLength, lblRSSBLength, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me.lblRSSBLength = lblRSSBLength
			Me.txtRSSBLength = txtRSSBLength
		End Sub

		Private Sub txtRSSBLength_EnabledChanged(sender As Object, e As EventArgs)
			Me.txtRSSBLengthEnabledChanged()
		End Sub

		Private Sub txtRSSBLengthEnabledChanged()
			Try
				If Me.txtRSSBLength.Enabled Then
					Dim txtRSSBLength As TextBox = Me.txtRSSBLength
					Util.SetFieldColor(txtRSSBLength)
					Me.txtRSSBLength = txtRSSBLength
				Else
					Me.txtRSSBLength.BackColor = Color.White
				End If
				Dim flag As Boolean
				If Me.txtRSSBLength.Enabled Then
					Me.lblRSSBLength_Disabled.SendToBack()
					flag = True
				Else
					Me.lblRSSBLength_Disabled.BringToFront()
					flag = False
				End If
				If RSWIN_DESC.bExpert And Me.chkDesignSinkerbars.Checked Then
					Me.lblRSSBLength_Disabled.BringToFront()
				End If
				If RSWIN_DESC.bExpert AndAlso flag Then
					Me.chkDesignSinkerbars.Visible = True
					Me.chkDesignSinkerbars.Enabled = True
				Else
					Me.chkDesignSinkerbars.Enabled = False
					Me.chkDesignSinkerbars.Visible = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkRSIncludeSB_EnabledChanged(sender As Object, e As EventArgs)
			Me.optSinkerBars.Enabled = Me.chkRSIncludeSB.Enabled
			Me.optSinkerRods.Enabled = Me.chkRSIncludeSB.Enabled
			Me.txtRSSBLength.Enabled = Me.chkRSIncludeSB.Checked
			If RSWIN_DESC.bExpert And Me.chkRSIncludeSB.Enabled And Me.chkDesignSinkerbars.Visible Then
				Me.chkDesignSinkerbars.Enabled = True
				Return
			End If
		End Sub

		Public Sub LoadCustomToRodGradeList(ByRef cboRGList As ComboBox, iRodMatl As Integer, ByRef myAL As ArrayList, Optional bClearList As Boolean = True, Optional bAssignList As Boolean = True)
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Try
				If iRodMatl = 2 Then
				End If
				If bClearList Then
					myAL.Clear()
				End If
				Try
					Dim num4 As Integer = 1
					Dim num5 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
					For i As Integer = num4 To num5
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a unchecked-expression
						If(If(-If(((iRodMatl = 4) > False), 1S, 0S), 1S, 0S) And Not RSWIN_DESC.CustomRodGradeList(i).Steel) <> 0S Then
							num += 1
							Me.AddToArrayList(True, myAL, 16397 + num, RSWIN_DESC.CustomRodGradeList(i).RodType, Me.iFiberglassOrder + num, "", "")
						ElseIf(If(-If(((iRodMatl = 0 Or iRodMatl = 1) > False), 1S, 0S), 1S, 0S) And RSWIN_DESC.CustomRodGradeList(i).Steel And Not RSWIN_DESC.CustomRodGradeList(i).SinkerBar) <> 0S Then
							num2 += 1
							Me.AddToArrayList(True, myAL, 4143 + num2, RSWIN_DESC.CustomRodGradeList(i).RodType, Me.iSteelOrder + num2, "", "")
						ElseIf(RSWIN_DESC.CustomRodGradeList(i).Steel And If(-If(((iRodMatl = 1 Or iRodMatl = 0 Or iRodMatl = 2) > False), 1S, 0S), 1S, 0S)) <> 0S Then
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a unchecked-expression
							If(Not RSWIN_DESC.CustomRodGradeList(i).SinkerBar And If(-If(((iRodMatl = 1 Or iRodMatl = 0) > False), 1S, 0S), 1S, 0S)) <> 0S Then
								num2 += 1
								Me.AddToArrayList(True, myAL, 4143 + num2, RSWIN_DESC.CustomRodGradeList(i).RodType, Me.iSteelOrder + num2, "", "")
							ElseIf(RSWIN_DESC.CustomRodGradeList(i).SinkerBar And If(-If(((iRodMatl = 2) > False), 1S, 0S), 1S, 0S)) <> 0S Then
								num3 += 1
								Me.AddToArrayList(True, myAL, 8311 + num3, RSWIN_DESC.CustomRodGradeList(i).RodType, Me.iSinkberbarOrder + num3, "", "")
							End If
						End If
					Next
				Catch ex As Exception
				End Try
				Dim comparer As RSInput.rgaComparer = New RSInput.rgaComparer()
				myAL.Sort(comparer)
				If bAssignList Then
					Util.DebugRodGradeArrayList(myAL)
					Try
						cboRGList.Items.Clear()
					Catch ex2 As Exception
					End Try
					Try
						cboRGList.DataSource = Nothing
					Catch ex3 As Exception
					End Try
					cboRGList.DataSource = myAL
					cboRGList.DisplayMember = "DisplayName"
					cboRGList.ValueMember = "RodGradeID"
				End If
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub cboRSSBDiameter_EnabledChanged(sender As Object, e As EventArgs)
			If Me.cboRSSBDiameter.Enabled Then
				Me.cboRSSBDiameter.BringToFront()
				Me.lbl_RSSBDiameter_Disabled.SendToBack()
				Return
			End If
			Me.cboRSSBDiameter.SendToBack()
			Me.lbl_RSSBDiameter_Disabled.BringToFront()
		End Sub

		Public Function GetMaxSize(cbo As ComboBox, ByRef savetmp As Single, ByRef iIndex As Integer) As String
			Dim result As String = ""
			savetmp = 0F
			Dim num As Integer = 0
			Dim num2 As Integer = cbo.Items.Count - 1
			For i As Integer = num To num2
				Try
					Dim text As String = Conversions.ToString(NewLateBinding.LateGet(cbo.Items(i), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing))
					If Strings.InStr(text, "Other", CompareMethod.Binary) <= 0 Then
						Dim num3 As Single = RODUTIL.CvtStrDiamToSngl(text)
						If num3 > savetmp Then
							savetmp = num3
							iIndex = i
							result = text
						End If
					End If
				Catch ex As Exception
				End Try
			Next
			Return result
		End Function

		Public Function GetMinSize(cbo As ComboBox, ByRef savetmp As Single, ByRef iIndex As Integer) As String
			Dim result As String = ""
			savetmp = 1000F
			Dim num As Integer = 0
			Dim num2 As Integer = cbo.Items.Count - 1
			For i As Integer = num To num2
				Try
					Dim text As String = Conversions.ToString(NewLateBinding.LateGet(cbo.Items(i), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing))
					If Strings.InStr(text, "Other", CompareMethod.Binary) <= 0 Then
						Dim num3 As Single = RODUTIL.CvtStrDiamToSngl(text)
						If num3 < savetmp Then
							savetmp = num3
							iIndex = i
							result = text
						End If
					End If
				Catch ex As Exception
				End Try
			Next
			Return result
		End Function

		Public Function LoadDiameterList(ByRef myAL As ArrayList, ByRef myRSArray As RSInput.RodSizeArray(), iRodGrade As Short, ByRef sRodType As String, bMaxMin As Boolean) As Boolean
			Dim result As Boolean = True
			Try
				myAL.Clear()
				Dim teRodSizeList As teRodSizeList
				If CUSTOMRG.IsOtherSteel(CInt(iRodGrade)) Or CUSTOMRG.IsOtherFG(CInt(iRodGrade)) Or CUSTOMRG.IsOtherSinkerBar(CInt(iRodGrade)) Then
					If Not RODUTIL.IsAPI(CInt(iRodGrade), sRodType) Then
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(14)
					ElseIf RODUTIL.IsSinkerBar1(CInt(iRodGrade), sRodType) <> 0 Then
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(13)
					ElseIf bMaxMin Then
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(32)
					Else
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(1)
					End If
				Else
					teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iRodGrade, StdInfoConstants.RodGradeConstants)).RodSizeList
				End If
				RSWIN_DESC.nItems = 0S
				Dim array As String() = New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}
				Dim array2 As String() = New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}
				myRSArray = New RSInput.RodSizeArray(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}
				Try
					For Each obj As Object In teRodSizeList
						Dim dictionaryEntry As DictionaryEntry
						Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
						RSWIN_DESC.nItems += 1S
						array = CType(Utils.CopyArray(CType(array, Array), New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}), String())
						array2 = CType(Utils.CopyArray(CType(array2, Array), New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}), String())
						myRSArray = CType(Utils.CopyArray(CType(myRSArray, Array), New RSInput.RodSizeArray(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}), RSInput.RodSizeArray())
						array(CInt(RSWIN_DESC.nItems)) = Conversions.ToString(teRodSize.Diameter)
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							array2(CInt(RSWIN_DESC.nItems)) = teRodSize.DisplayName
						Else
							array2(CInt(RSWIN_DESC.nItems)) = teRodSize.MetricDisplayName
						End If
						RODUTIL.AddToDiameterArrayList(True, myAL, CInt(RSWIN_DESC.nItems), array2(CInt(RSWIN_DESC.nItems)))
						Try
							myRSArray(CInt(RSWIN_DESC.nItems)).rsaRodSizeID = teRodSize.RodSizeID
							myRSArray(CInt(RSWIN_DESC.nItems)).rsaDisplayName = array2(CInt(RSWIN_DESC.nItems))
							myRSArray(CInt(RSWIN_DESC.nItems)).rsaDiameter = teRodSize.Diameter
							Debug.WriteLine(String.Concat(New String() { Conversions.ToString(teRodSize.RodSizeID), " , ", array2(CInt(RSWIN_DESC.nItems)), " , ", Conversions.ToString(teRodSize.Diameter) }))
						Catch ex As Exception
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub cboRSGrade_EnabledChanged(sender As Object, e As EventArgs)
			If Me.cboRSGrade.Enabled Then
				Me.cboRSGrade.BringToFront()
				Me.lblRSGrade_Disabled.SendToBack()
				Return
			End If
			Me.cboRSGrade.SendToBack()
			Me.lblRSGrade_Disabled.BringToFront()
		End Sub

		Private Sub cboRSMaxSize_EnabledChanged(sender As Object, e As EventArgs)
			Me.cboRSMaxSizeEnabledChanged()
		End Sub

		Private Sub cboRSMaxSizeEnabledChanged()
			If Me.cboRSMaxSize.Enabled Then
				Me.cboRSMaxSize.BringToFront()
				Me.lblRSMaxSize_Disabled.SendToBack()
				Return
			End If
			Me.cboRSMaxSize.SendToBack()
			Me.lblRSMaxSize_Disabled.BringToFront()
		End Sub

		Private Sub cboRSSRSize_EnabledChanged(sender As Object, e As EventArgs)
			Me.cboRSSRSizeEnabledChanged()
		End Sub

		Private Sub cboRSSRSizeEnabledChanged()
			If Me.cboRSSRSize.Enabled Then
				Me.cboRSSRSize.BringToFront()
				Me.lblRSSRSize_Disabled.SendToBack()
				Return
			End If
			Me.cboRSSRSize.SendToBack()
			Me.lblRSSRSize_Disabled.BringToFront()
		End Sub

		Private Sub cboRSMinSize_EnabledChanged(sender As Object, e As EventArgs)
			Me.cboRSMinSizeEnabledChanged()
		End Sub

		Private Sub cboRSMinSizeEnabledChanged()
			If Me.cboRSMinSize.Enabled Then
				Me.cboRSMinSize.BringToFront()
				Me.lblRSMinSize_Disabled.SendToBack()
				Return
			End If
			Me.cboRSMinSize.SendToBack()
			Me.lblRSMinSize_Disabled.BringToFront()
		End Sub

		Private Sub cboRSSBGrade_EnabledChanged(sender As Object, e As EventArgs)
			Me.cboRSSBGradeEnabledChanged()
		End Sub

		Private Sub cboRSSBGradeEnabledChanged()
			If Me.cboRSSBGrade.Enabled Then
				Me.cboRSSBGrade.BringToFront()
				Me.lblRSSBGrade_Disabled.SendToBack()
				Return
			End If
			Me.cboRSSBGrade.SendToBack()
			Me.lblRSSBGrade_Disabled.BringToFront()
		End Sub

		Private Sub SetEnabledControls(bFG As Boolean, Optional bNew As Boolean = False)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If rst.RSGrade = 0S AndAlso (Me.cboRSGrade.SelectedIndex = 0 Or Me.cboRSGrade.SelectedIndex = Me.iNorris97) Then
				If bNew Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 3, False, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						rst.RSGrade = Conversions.ToShort(objectValue)
						rst.RSRodType = Conversions.ToString(ini.GetDataValue("RSRodType", 8, False, ""))
					Else
						rst.RSGrade = Conversions.ToShort(NewLateBinding.LateGet(Me.cboRSGrade.Items(Me.iNorris97), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
						rst.RSRodType = Convert.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboRSGrade.Items(Me.iNorris97), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
					End If
				Else
					rst.RSGrade = Conversions.ToShort(NewLateBinding.LateGet(Me.cboRSGrade.Items(Me.iNorris97), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
					rst.RSRodType = Convert.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboRSGrade.Items(Me.iNorris97), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
				End If
				ini.SaveDataValue("RSGrade", rst.RSGrade)
				ini.SaveDataValue("RSRodType", rst.RSRodType)
				If rst.RSMaxSize = 0F Or rst.RSMinSize = 0F Then
					Me.m_mbMaxMinNotYetSet = True
				End If
				If Me.cboRSGrade.SelectedIndex = 0 Then
					Me.cboRSGrade.SelectedIndex = Me.iNorris97
				End If
			End If
			If rst.RSMaxSize = 0F And Me.m_mbMaxMinNotYetSet Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMaxSize", 4, False, 1))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					rst.RSMaxSize = Conversions.ToSingle(objectValue)
					If RSWIN_DESC.bRodStarD Then
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSRSize", 4, False, rst.RSMinSize))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							rst.RSSRSize = Conversions.ToSingle(objectValue)
						End If
					End If
					Me.LoadMax()
					If rst.RSMinSize <> 0F Then
						Me.m_mbMaxMinNotYetSet = False
					End If
				End If
				If rst.RSMaxSize <> 0F Then
					ini.SaveDataValue("RSMaxSize", rst.RSMaxSize)
					If RSWIN_DESC.bRodStarD AndAlso rst.RSSRSize <> 0F Then
						ini.SaveDataValue("RSSRSize", rst.RSSRSize)
					End If
				End If
			End If
			If Me.cboRSMaxSize.SelectedIndex <> -1 Then
				Dim num As Single = RODUTIL.CvtStrDiamToSngl(Conversions.ToString(NewLateBinding.LateGet(Me.cboRSMaxSize.Items(Me.cboRSMaxSize.SelectedIndex), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
				If rst.RSMaxSize <> num And rst.RSMaxSize <> 0F Then
					Me.LoadMax()
				End If
			End If
			If rst.RSMinSize = 0F And Me.m_mbMaxMinNotYetSet Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMinSize", 4, False, 0.75))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					rst.RSMinSize = Conversions.ToSingle(objectValue)
					Me.LoadMin()
					Me.m_mbMaxMinNotYetSet = False
				End If
				If rst.RSMinSize <> 0F Then
					ini.SaveDataValue("RSMinSize", rst.RSMinSize)
				End If
			End If
			If Me.cboRSMinSize.SelectedIndex <> -1 Then
				Dim num2 As Single = RODUTIL.CvtStrDiamToSngl(Conversions.ToString(NewLateBinding.LateGet(Me.cboRSMinSize.Items(Me.cboRSMinSize.SelectedIndex), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
				If rst.RSMinSize <> num2 And rst.RSMinSize <> 0F Then
					Me.LoadMin()
				End If
			End If
			If bFG Then
				Me.cboRSGrade.Enabled = (rst.RSFGIncludeSteel <> 0S)
				Me.cboRSMaxSize.Enabled = ((rst.RSFGIncludeSteel And If((-If((Me.cboRSGrade.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.RSGrade <> 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S)
				Me.cboRSMinSize.Enabled = ((rst.RSFGIncludeSteel And If((-If((Me.cboRSGrade.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.RSGrade <> 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S)
				Me.chkRSIncludeSB.Enabled = (Me.cboRSFGGrade.SelectedIndex >= 0)
				Me.cboRSSBGrade.Enabled = (Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked))
				Me.cboRSSBDiameter.Enabled = (Me.cboRSSBGrade.Enabled And Me.cboRSSBGrade.SelectedIndex >= 0)
				Me.txtRSSBLength.Enabled = ((rst.RSFGIncludeSteel And If((-If((Me.chkRSIncludeSB.Enabled > False), 1S, 0S)), 1S, 0S) And If((-If((Me.cboRSSBDiameter.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S)) <> 0S)
				Me.txtRSSBLengthEnabledChanged()
				Me.cboRSSBGradeEnabledChanged()
				Me.cboRSMinSizeEnabledChanged()
				Me.cboRSMaxSizeEnabledChanged()
			Else
				Me.cboRSMaxSize.Enabled = (Me.cboRSGrade.SelectedIndex >= 0 And RSWIN_DESC.rst.RSGrade <> 0S)
				Me.cboRSMinSize.Enabled = (Me.cboRSGrade.SelectedIndex >= 0 And RSWIN_DESC.rst.RSGrade <> 0S)
				Me.chkRSIncludeSB.Enabled = (Me.cboRSGrade.SelectedIndex >= 0)
				Me.cboRSSBGrade.Enabled = (Me.chkRSIncludeSB.Checked And (Me.optSinkerBars.Checked Or Me.optSinkerRods.Checked))
				Me.cboRSSBDiameter.Enabled = (Me.cboRSSBGrade.Enabled And Me.cboRSSBGrade.SelectedIndex >= 0)
				Me.txtRSSBLength.Enabled = (Me.chkRSIncludeSB.Enabled And Me.cboRSSBDiameter.SelectedIndex >= 0)
				Me.txtRSSBLengthEnabledChanged()
				Me.cboRSSBGradeEnabledChanged()
				Me.cboRSMinSizeEnabledChanged()
				Me.cboRSMaxSizeEnabledChanged()
			End If
			If RSWIN_DESC.bExpert Then
				Me.chkDesignSinkerbars.Visible = Me.txtRSSBLength.Enabled
				If Me.chkDesignSinkerbars.Visible Then
					Me.chkDesignSinkerbars.Enabled = True
				Else
					Me.chkDesignSinkerbars.Enabled = False
				End If
			Else
				Me.chkDesignSinkerbars.Enabled = False
				Me.chkDesignSinkerbars.Visible = False
			End If
		End Sub

		Private Sub TurnOffViewReportOption()
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
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
				Return
			End If
		End Sub

		Private Function bIsSB(iGrade As Integer) As Boolean
			Dim result As Boolean = False
			If RODUTIL.IsSinkerBarGrade(iGrade) Then
				result = True
			ElseIf RODUTIL.IsSinkerBar(iGrade) <> 0 Then
				result = True
			ElseIf CUSTOMRG.IsOtherSinkerBar(iGrade) Then
				result = True
			End If
			Return result
		End Function

		Private Sub cboRSSBDiameter_SelectionChangeCommitted(sender As Object, e As EventArgs)
			Try
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboRSSBDiameter_DataSourceChanged(sender As Object, e As EventArgs)
			Try
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboRSSBDiameter_BindingContextChanged(sender As Object, e As EventArgs)
			Try
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SetDefaultRSGRADE()
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Me.cboRSGrade.Items.Count > 0 Then
					If rst.RSGrade = 0S Then
						Me.cboRSGrade.SelectedIndex = Me.iNorris97
						rst.RSGrade = Conversions.ToShort(NewLateBinding.LateGet(Me.cboRSGrade.Items(Me.iNorris97), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
						rst.RSRodType = Convert.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboRSGrade.Items(Me.iNorris97), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
						ini.SaveDataValue("RSGrade", rst.RSGrade)
						ini.SaveDataValue("RSRodType", rst.RSRodType)
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMaxSize", 4, False, 1))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							rst.RSMaxSize = Conversions.ToSingle(objectValue)
							Me.LoadMax()
							objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMinSize", 4, False, 0.75))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
								rst.RSMinSize = Conversions.ToSingle(objectValue)
								Me.LoadMin()
							End If
							If RSWIN_DESC.bRodStarD Then
								objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSRSize", 4, False, rst.RSMinSize))
								If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
									rst.RSSRSize = Conversions.ToSingle(objectValue)
								End If
							End If
							If rst.RSMaxSize <> 0F Then
								ini.SaveDataValue("RSMaxSize", rst.RSMaxSize)
							End If
							If RSWIN_DESC.bRodStarD AndAlso rst.RSSRSize <> 0F Then
								ini.SaveDataValue("RSSRSize", rst.RSSRSize)
							End If
							If rst.RSMinSize <> 0F Then
								ini.SaveDataValue("RSMinSize", rst.RSMinSize)
							End If
						End If
					End If
					Me.cboRSMaxSize.Enabled = True
					Me.cboRSMinSize.Enabled = True
					Me.cboRSGrade.Enabled = True
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub tbsRodDesignType_Leave(sender As Object, e As EventArgs)
			Me.bRodDesignTypeClicked = False
		End Sub

		Public Sub Set_Row_Diameter_Cell(iEntry As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = False
				Dim num As Integer = 1
				Dim ultraGridRow As UltraGridRow = Me.ulgTapers.GetRow(ChildRow.First)
				If iEntry = num Then
					If ultraGridRow IsNot Nothing Then
						Me.ulgTapers.ActiveRow = ultraGridRow
						flag = True
					End If
				Else
					While ultraGridRow.HasNextSibling()
						num += 1
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						If iEntry = num Then
							If ultraGridRow IsNot Nothing Then
								Me.ulgTapers.ActiveRow = ultraGridRow
								flag = True
								Exit While
							End If
							Exit While
						End If
					End While
				End If
				If flag Then
					Me.ulgTapers.ActiveCell = Me.ulgTapers.ActiveRow.Cells("RodSize")
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function CheckRSMinSize(RSGrade As Short, RSMinSize As Single, ByRef fNewDiameter As Single) As Single
			Dim flag As Boolean = False
			Dim result As Single
			Try
				fNewDiameter = -1F
				Dim text As String = ""
				Dim teRodSizeList As teRodSizeList
				If CUSTOMRG.IsOtherSteel(CInt(RSGrade)) Or CUSTOMRG.IsOtherFG(CInt(RSGrade)) Or CUSTOMRG.IsOtherSinkerBar(CInt(RSGrade)) Then
					If CUSTOMRG.IsOtherFG(CInt(RSGrade)) Then
						Dim num As Single = 0F
						text = RODUTIL.GetOtherFG(CInt(RSGrade), num)
					ElseIf CUSTOMRG.IsOtherSinkerBar(CInt(RSGrade)) Then
						Dim num As Single = 0F
						text = RODUTIL.GetOtherSinkerbar(CInt(RSGrade), num)
					ElseIf CUSTOMRG.IsOtherSteel(CInt(RSGrade)) Then
						Dim num As Single = 0F
						text = RODUTIL.GetOtherSteel(CInt(RSGrade), num)
					End If
					If CUSTOMRG.IsOtherSinkerBar(CInt(RSGrade)) Then
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(13)
					ElseIf Not RODUTIL.IsAPI(CInt(RSGrade), text) Then
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(14)
					Else
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(1)
					End If
				Else
					Dim rodGradeID As Integer = CInt(RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(RSGrade, StdInfoConstants.RodGradeConstants)).RodGradeID)
					Try
						Dim name As String = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(RSGrade, StdInfoConstants.RodGradeConstants)).Name
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(rodGradeID, StdInfoConstants.RodGradeConstants)).RodSizeList
					Catch ex As Exception
					End Try
				End If
				Try
					For Each obj As Object In teRodSizeList
						Dim dictionaryEntry As DictionaryEntry
						Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
						If teRodSize.Diameter = RSMinSize Then
							fNewDiameter = teRodSize.Diameter
							flag = True
							Exit For
						End If
						If fNewDiameter = -1F Or teRodSize.Diameter < fNewDiameter Then
							fNewDiameter = teRodSize.Diameter
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				result = -(flag > False)
			Catch ex2 As Exception
				fNewDiameter = -1F
				result = 0F
			End Try
			Return result
		End Function

		Private Sub ulgTapers_AfterExitEditMode(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.PreviousColumn, Me.CurrentColumn, False) <> 0 Or Not Me.bLengthError Then
				Me.lblStatus.Text = ""
				Return
			End If
		End Sub

		Private Sub cboRSMinSize_Leave(sender As Object, e As EventArgs)
			Me.lblStatus.Text = ""
		End Sub

		Private Sub cboRSMaxSize_Leave(sender As Object, e As EventArgs)
			Me.lblStatus.Text = ""
		End Sub

		Private Sub cboRSSRSize_Leave(sender As Object, e As EventArgs)
			Me.lblStatus.Text = ""
		End Sub

		Private Sub txtRSSBLength_Enter(sender As Object, e As EventArgs)
			If Me.txtRSSBLength.Enabled Then
				If Me.bUseStatus And Operators.CompareString(Me.txtRSSBLength.Text.Trim(), "", False) = 0 And (Not RSWIN_DESC.bExpert And Not Me.chkDesignSinkerbars.Checked) Then
					Me.lblStatus.Text = " " + Me.SEnterSBLength
				Else
					Me.lblStatus.Text = ""
				End If
			End If
		End Sub

		Private Sub ContextMenu1_Clicked(sender As Object, e As EventArgs)
			Me.SetLengthToPumpDepth()
		End Sub

		Private Sub SetLengthToPumpDepth()
			Dim num As Single = 0F
			Me.lblStatus.Text = ""
			Me.bLengthError = False
			Try
				Dim activeCell As UltraGridCell = Me.ulgTapers.ActiveCell
				Debug.WriteLine(Operators.ConcatenateObject(activeCell.Text + " , ", activeCell.Value))
				Dim ultraGridCell As UltraGridCell = activeCell
				If Operators.CompareString(ultraGridCell.Column.Key, "RodLength", False) = 0 Then
					Dim row As UltraGridRow = ultraGridCell.Row
					Dim num2 As Integer = Conversions.ToInteger(row.Cells("RodNum").Value)
					Dim ultraGridRow As UltraGridRow = Me.ulgTapers.GetRow(ChildRow.First)
					Dim num3 As Integer = Conversions.ToInteger(ultraGridRow.Cells("RodNum").Value)
					If num3 <> num2 Then
						num = Conversions.ToSingle(ultraGridRow.Cells("RodLength").Value)
					ElseIf ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						num3 = Conversions.ToInteger(ultraGridRow.Cells("RodNum").Value)
						num = Conversions.ToSingle(ultraGridRow.Cells("RodLength").Value)
					End If
					While ultraGridRow.HasNextSibling()
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						num3 = Conversions.ToInteger(ultraGridRow.Cells("RodNum").Value)
						If num3 <> num2 Then
							Dim ultraGridCell2 As UltraGridCell = ultraGridRow.Cells("RodLength")
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridCell2.Value)) AndAlso Operators.ConditionalCompareObjectGreaterEqual(ultraGridCell2.Value, 0, False) Then
								num = Conversions.ToSingle(Operators.AddObject(num, ultraGridCell2.Value))
							End If
						End If
					End While
					If num >= 0F Then
						Dim ulgTapers As UltraGrid = Me.ulgTapers
						ulgTapers.EventManager.SetEnabled(GridEventIds.AfterCellUpdate, False)
						row.Cells("RodLength").Value = Me.tmp_PumpDepth - num
						ulgTapers.EventManager.SetEnabled(GridEventIds.AfterCellUpdate, True)
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in SetLengthToPumpDepth:" + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Function GetRodGuideName(RodGuide As Short) As String
			Dim text As String = New String(" "c, 8192)
			Dim result As String
			Try
				If RodGuide = 0S Then
					result = "Bare Rod (no rod guides)"
				ElseIf RodGuide = RSWIN_DESC.MOLDED Then
					result = "Molded"
				ElseIf RodGuide = 2S Then
					result = "Wheeled"
				ElseIf RodGuide = 3S Then
					Dim text2 As String = "OtherGuide"
					Dim text3 As String = "Other"
					Dim length As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, text, True))
					RSWIN_DESC.sOtherGuided = text.Substring(0, CInt(length))
					result = RSWIN_DESC.sOtherGuided
				ElseIf RodGuide = 4S Then
					result = "Norris Standard"
				ElseIf RodGuide = RSWIN_DESC.NorrisSidewinderGuide Then
					result = "Norris Sidewinder"
				ElseIf RodGuide = 6S Then
					result = "RGI Jake Coupling"
				ElseIf RodGuide = 7S Then
					result = "RGI SVT"
				ElseIf RodGuide = 8S Then
					result = "RGI Tomahawk"
				ElseIf RodGuide = 9S Then
					result = "RGI Tornado"
				ElseIf RodGuide = 10S Then
					result = "RGI Twister"
				ElseIf RodGuide = 11S Then
					result = "RGI WVT"
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function AllGuidesAreSidewinder(bCheckNumRods As Boolean) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				Dim flag2 As Boolean = False
				If RSWIN_DESC.SETUP_GuideToUse >= 4 Then
					Try
						If RSWIN_DESC.rst.RodStringType = 3S And (RSWIN_DESC.rst.giRodDesignStyle = 1S Or RSWIN_DESC.rst.giRodDesignStyle = 0S) Then
							flag2 = True
						End If
						If bCheckNumRods And RSWIN_DESC.rst.NumRods = 0S Then
							flag = False
						Else
							Dim num As Integer = 1
							Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num To numRods
								If RSWIN_DESC.rst.Sections(i).Guide < 4S Then
									If Not flag2 Then
										flag = False
										Exit For
									End If
									RSWIN_DESC.rst.Sections(i).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
								End If
							Next
						End If
					Catch ex As Exception
						Return False
					End Try
					result = flag
				End If
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub chkDesignSinkerbars_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.chkDesignSinkerbars Is Me.ActiveControl Then
				Me.ValidateRSInput(Me.bFormLoaded, True, False)
			End If
			Me.chkDesignSinkerbarsCheckedChanged(Me.chkDesignSinkerbars Is Me.ActiveControl)
		End Sub

		Private Sub chkDesignSinkerbarsCheckedChanged(bClicked As Boolean)
			If bClicked Then
				RSWIN_DESC.rst.gbDesignSinkerbar = Me.chkDesignSinkerbars.Checked
				ini.SaveDataValue("gbDesignSinkerbar", RSWIN_DESC.rst.gbDesignSinkerbar)
				If RSWIN_DESC.rst.gbDesignSinkerbar Then
					Me.lblRSSBLength_Disabled.BringToFront()
					Return
				End If
				Me.lblRSSBLength_Disabled.SendToBack()
				Return
			Else
				If Me.chkDesignSinkerbars.Visible Then
					If Me.chkDesignSinkerbars.Checked Then
						Me.lblRSSBLength_Disabled.BringToFront()
					Else
						Me.lblRSSBLength_Disabled.SendToBack()
					End If
					Return
				End If
				Return
			End If
		End Sub

		Private Sub chkDesignSinkerbars_EnabledChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtLength_KeyPress(sender As Object, e As KeyPressEventArgs)
		End Sub

		Private Function FindNonNumeric(sText As String) As String
			' The following expression was wrapped in a checked-statement
			Dim result As String
			Try
				Dim text As String = ""
				Dim num As Integer = 0
				Dim num2 As Integer = sText.Length - 1
				For i As Integer = num To num2
					Dim text2 As String = sText.Substring(i, 1)
					If Not Versioned.IsNumeric(text2) Then
						text = text2
						Exit For
					End If
				Next
				result = text
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function

		Private Sub UpdateRS()
			Dim rodType As String = New String(" "c, 20)
			Dim num As Short = 0S
			Dim num2 As Short = 0S
			Dim num3 As Short = 0S
			Dim num4 As Single = 0F
			Dim num5 As Single = 0F
			Dim num6 As Single = 0F
			Dim num7 As Single = 1000F
			Try
				Me.bInsideUpdateRS = True
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num8 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num8 To numRods
					Dim grade As Short = RSWIN_DESC.rst.Sections(i).Grade
					If grade <> 0S Then
						If(If((-If(((i = CInt(RSWIN_DESC.rst.NumRods) And RSWIN_DESC.rst.NumRods <> 1S) > False), 1, 0)), 1, 0) And (If((-If((Me.bIsSB(CInt(grade)) > False), 1, 0)), 1, 0) Or ((RODUTIL.IsSteel(CInt(grade)) Or If((-If((CUSTOMRG.IsOtherSteel(CInt(grade)) > False), 1, 0)), 1, 0)) And If((-If((RSWIN_DESC.rst.Sections(i).Diameter > num6 > False), 1, 0)), 1, 0)))) <> 0 Then
							num = grade
							If RSWIN_DESC.rst.Sections(i).length <> 0F Then
								num4 = RSWIN_DESC.rst.Sections(i).length
							End If
							If RSWIN_DESC.rst.Sections(i).Diameter <> 0F Then
								num5 = RSWIN_DESC.rst.Sections(i).Diameter
							End If
						ElseIf((RODUTIL.IsSteel(CInt(grade)) Or If((-If((CUSTOMRG.IsOtherSteel(CInt(grade)) > False), 1, 0)), 1, 0)) And If((-If((Not RODUTIL.IsSinkerBarGrade(grade) > False), 1, 0)), 1, 0)) <> 0 Then
							num3 = grade
							If RSWIN_DESC.rst.Sections(i).Diameter >= num6 And RSWIN_DESC.rst.Sections(i).Diameter <> 0F Then
								num6 = RSWIN_DESC.rst.Sections(i).Diameter
							End If
							If RSWIN_DESC.rst.Sections(i).Diameter <= num7 And RSWIN_DESC.rst.Sections(i).Diameter <> 0F Then
								num7 = RSWIN_DESC.rst.Sections(i).Diameter
							End If
						ElseIf RODUTIL.IsFG(grade) Or CUSTOMRG.IsOtherFG(CInt(grade)) Then
							num2 = grade
							If RSWIN_DESC.rst.Sections(i).Diameter <> 0F Then
								Dim diameter As Single = RSWIN_DESC.rst.Sections(i).Diameter
							End If
						End If
					End If
				Next
				If num3 <> 0S Then
					rst.RSGrade = num3
					rst.RSRodType = RODUTIL.RodGrade(num3)
					If num6 <> 0F Then
						rst.RSMaxSize = RODUTIL.SetGuruRodDiameter(CInt(num3), num6)
					End If
					If num7 <> 1000F Then
						rst.RSMinSize = RODUTIL.SetGuruRodDiameter(CInt(num3), num7)
						rst.RSFGIncludeSteel = -1S
					End If
				End If
				If num2 <> 0S Then
					rst.RSFGGrade = num2
				End If
				If num = 0S Then
					rst.RSIncludeSB = 0S
				Else
					rst.RSSBGrade = num
					rst.RSIncludeSB = -1S
					Dim sinkerBar As RSWIN_DESC.RodSection
					sinkerBar.Initialize()
					sinkerBar.Grade = num
					sinkerBar.RodType = rodType
					sinkerBar.RodType = RODUTIL.RodGrade(num)
					If num5 <> 0F Then
						sinkerBar.Diameter = RODUTIL.SetGuruRodDiameter(CInt(num), num5)
						rst.RSSBDiameter = sinkerBar.Diameter
					End If
					If num4 <> 0F Then
						sinkerBar.length = num4
					End If
					rst.SinkerBar = sinkerBar
				End If
				If Me.miDesignStyle = 3 Then
					Me.bLoadingCombo = True
					If rst.RSFGGrade <> 0S Then
						Dim cboRSFGGrade As ComboBox = Me.cboRSFGGrade
						Dim comboBox As ComboBox = Me.cboRSFGGrade
						Dim selectedIndex As Integer = CInt(RODUTIL.FindRodGrade(comboBox, rst.RSFGGrade, Nothing))
						Me.cboRSFGGrade = comboBox
						cboRSFGGrade.SelectedIndex = selectedIndex
					End If
					If rst.RSGrade <> 0S Then
						Dim comboBox As ComboBox = Me.cboRSGrade
						Dim iListIndex As Short = RODUTIL.FindRodGrade(comboBox, rst.RSGrade, rst.RSRodType)
						Me.cboRSGrade = comboBox
						Me.cboRSGrade_Click_1(iListIndex, False)
						If rst.RSMaxSize <> 0F Then
							Me.LoadMax()
						End If
						If rst.RSMinSize <> 0F Then
							Me.LoadMin()
						End If
					End If
					If rst.RSSBGrade <> 0S Then
						Dim comboBox As ComboBox
						If Me.bIsSB(CInt(rst.RSSBGrade)) Then
							comboBox = Me.cboRSSBGrade
							RODUTIL.LoadRodGradeList(comboBox, 2, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
							Me.cboRSSBGrade = comboBox
							comboBox = Me.cboRSSBGrade
							Me.LoadCustomToRodGradeList(comboBox, 2, Me.RSSBGrade_AL, False, True)
							Me.cboRSSBGrade = comboBox
						Else
							comboBox = Me.cboRSSBGrade
							RODUTIL.LoadRodGradeList(comboBox, 1, Me.RSSBGrade_AL, True, False, False, False, False, False, False)
							Me.cboRSSBGrade = comboBox
							comboBox = Me.cboRSSBGrade
							RODUTIL.LoadRodGradeList(comboBox, 3, Me.RSSBGrade_AL, False, False, False, False, False, False, False)
							Me.cboRSSBGrade = comboBox
							comboBox = Me.cboRSSBGrade
							RODUTIL.LoadRodGradeList(comboBox, 6, Me.RSSBGrade_AL, False, False, False, False, False, False, False)
							Me.cboRSSBGrade = comboBox
							comboBox = Me.cboRSSBGrade
							Me.LoadCustomToRodGradeList(comboBox, 1, Me.RSSBGrade_AL, False, True)
							Me.cboRSSBGrade = comboBox
						End If
						Dim cboRSSBGrade As ComboBox = Me.cboRSSBGrade
						comboBox = Me.cboRSSBGrade
						Dim selectedIndex2 As Integer = CInt(RODUTIL.FindRodGrade(comboBox, rst.SinkerBar.Grade, rst.SinkerBar.RodType))
						Me.cboRSSBGrade = comboBox
						cboRSSBGrade.SelectedIndex = selectedIndex2
						Me.LoadSBDiameter(rst.SinkerBar.Grade)
						If rst.SinkerBar.length <> 0F Then
							Me.txtRSSBLength.Text = Conversions.ToString(rst.SinkerBar.length)
						End If
						Me.chkRSIncludeSB.Checked = (rst.RSIncludeSB <> 0S)
						If Me.bIsSB(CInt(rst.SinkerBar.Grade)) Then
							Me.optSinkerBars.Checked = True
						Else
							Me.optSinkerRods.Checked = True
						End If
					End If
					Me.bLoadingCombo = False
				End If
				Me.bInsideUpdateRS = False
			Catch ex As Exception
				Me.bLoadingCombo = False
				Me.bInsideUpdateRS = False
			End Try
		End Sub

		Private Function CheckIfPositiveNumeric(sVal As String, ByRef objCell As UltraGridCell) As String
			' The following expression was wrapped in a checked-statement
			Dim result As String
			Try
				Dim text As String = sVal
				Dim currencySymbol As String = RSWIN_DESC.NumFormatInfo.CurrencySymbol
				If(Not Versioned.IsNumeric(text) Or Strings.InStr(text, "+", CompareMethod.Binary) > 0 Or Strings.InStr(text, "-", CompareMethod.Binary) > 0 Or Strings.InStr(text, currencySymbol, CompareMethod.Binary) > 0) AndAlso text.Trim().Length <> 0 Then
					Dim num As Integer = 0
					Dim num2 As Integer = text.Length - 1
					For i As Integer = num To num2
						Dim text2 As String = text.Substring(i, 1)
						If(Not Versioned.IsNumeric(text2) And Operators.CompareString(text2, RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator, False) <> 0) Or (Operators.CompareString(text2, "+", False) = 0 Or Operators.CompareString(text2, "-", False) = 0 Or Operators.CompareString(text2, currencySymbol, False) = 0) Then
							text = text.Replace(text2, "")
							If Versioned.IsNumeric(text) Then
								objCell.Value = Convert.ToSingle(text)
							End If
						End If
					Next
				End If
				result = text
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub SetStringLengthFromGrid()
			Dim num As Single = 0F
			Try
				For Each ultraGridRow As UltraGridRow In Me.ulgTapers.Rows
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("RodLength").Value)) AndAlso Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("RodNum").Value)) Then
						Dim num2 As Integer = Conversions.ToInteger(ultraGridRow.Cells("RodNum").Value)
						Dim num3 As Single = Conversions.ToSingle(ultraGridRow.Cells("RodLength").Value)
						num += num3
					End If
				Next
				If num <> 0F Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
						Me.lblStringLength.Text = String.Concat(New String() { Me.sRodStringLength, " (", RSWIN_DESC.ft, "): ", Conversions.ToString(num), "     ", Me.sPumpDepth, " (", RSWIN_DESC.ft, "): ", Conversions.ToString(RSWIN_DESC.rst.PumpDepth) })
						If num > RSWIN_DESC.rst.PumpDepth + 1F Or num < RSWIN_DESC.rst.PumpDepth - 50F Then
							Me.lblStringLength.ForeColor = Me.lblStatus.ForeColor
						Else
							Me.lblStringLength.ForeColor = Color.Black
						End If
					Else
						Me.lblStringLength.Text = String.Concat(New String() { Me.sRodStringLength, " (", RSWIN_DESC.m, "): ", Conversions.ToString(num), "     ", Me.sPumpDepth, " (", RSWIN_DESC.m, "): ", Conversions.ToString(Me.tmp_PumpDepth) })
						If num > Me.tmp_PumpDepth + 1F Or num < Me.tmp_PumpDepth - 50F Then
							Me.lblStringLength.ForeColor = Me.lblStatus.ForeColor
						Else
							Me.lblStringLength.ForeColor = Color.Black
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboRodSize_Enter(sender As Object, e As EventArgs)
		End Sub

		Private Sub cboRodGuides_Enter(sender As Object, e As EventArgs)
		End Sub

		Private Sub cboRodGrade_Enter(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtLength_Enter(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-expression
			Me.txtLength.TabIndex = Me.ulgTapers.TabIndex - 1
		End Sub

		Private Sub ulgTapers_BeforeSortChange(sender As Object, e As BeforeSortChangeEventArgs)
			If Me.ActiveControl Is Me.ulgTapers And Me.bFormLoaded Then
				e.Cancel = True
			End If
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

		Private Sub RSInput_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub RSInput_MouseDown(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub RSInput_MouseEnter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub RSInput_MouseMove(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub RSInput_MouseUp(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub RSInput_MouseWheel(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub RSInput_Move(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub RSInput_Scroll(sender As Object, e As ScrollEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub RSInput_KeyPress(sender As Object, e As KeyPressEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub RSInput_KeyUp(sender As Object, e As KeyEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub RSInput_DragDrop(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub RSInput_DragEnter(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub RSInput_FormClosed(sender As Object, e As FormClosedEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub RSInput_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub RSInput_LostFocus(sender As Object, e As EventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub RSInput_GotFocus(sender As Object, e As EventArgs)
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

		Private Sub ulgTapers_MouseHover(sender As Object, e As EventArgs)
		End Sub

		Private Sub cboRodGrade_SelectedIndexChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub cboRodGuides_SelectedIndexChanged(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.ActiveControl Is Me.cboRodGuides AndAlso RSWIN_DESC.rst.NumRods > 1S Then
				Dim guide As Integer = CInt(RSWIN_DESC.rst.Sections(1).Guide)
				Dim num As Integer = 2
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If CInt(RSWIN_DESC.rst.Sections(i).Guide) <> guide Then
						Me.lblStatus.Text = "Mixed Rod Guide types selected."
						Exit For
					End If
				Next
			End If
		End Sub

		Private Sub cboRSRodGuides_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.cboRSRodGuides AndAlso Me.cboRSRodGuides.Items.Count > 0 AndAlso Strings.Len(Me.cboRSRodGuides.Text) > 0 Then
				Dim num As Integer = Conversions.ToInteger(Me.cboRSRodGuides.SelectedValue)
				RSWIN_DESC.rst.RSRodGuide = num
				RSWIN_DESC.rst.RSFricCoef = RODUTIL.GetFricCoeff(num, True)
				Me.txtRSFricCoeff.Text = Conversions.ToString(RSWIN_DESC.rst.RSFricCoef)
			End If
		End Sub

		Private Sub cboRSRodGuides_Leave(sender As Object, e As EventArgs)
			Me.cboRSRodGuides.BackColor = Color.White
		End Sub

		Private Sub lblStatus_TextChanged(sender As Object, e As EventArgs)
		End Sub

		Public Function GetGuideName(iGuide As Integer) As String
			Dim result As String
			Try
				Dim text As String = ""
				If iGuide = 0 Then
					text = "No Guide"
				ElseIf iGuide = CInt(RSWIN_DESC.MOLDED) Then
					text = "MOLDED"
				ElseIf iGuide = 2 Then
					text = "WHEELED"
				ElseIf iGuide = 3 Then
					text = "Other"
				ElseIf iGuide = 4 Then
					text = "Norris Standard"
				ElseIf iGuide = CInt(RSWIN_DESC.NorrisSidewinderGuide) Then
					text = "Sidewinder"
				ElseIf iGuide = 6 Then
					text = "RGI Jake Coupling"
				ElseIf iGuide = 7 Then
					text = "RGI SVT"
				ElseIf iGuide = 8 Then
					text = "RGI Tomahawk"
				ElseIf iGuide = 9 Then
					text = "RGI Tornado"
				ElseIf iGuide = 10 Then
					text = "RGI Twister"
				ElseIf iGuide = 11 Then
					text = "RGI WVT"
				End If
				result = text
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private MyParentFrm As RODSTAR

		Private sNull As String

		Private mousePoint As Point

		Private iNorris97 As Integer

		Private iFlexBarC As Integer

		Private bShowGuides As Boolean

		Private sRodStringLength As String

		Private sPumpDepth As String

		Private sARSRemoveSelected As String

		Private sDeleteRow As String

		Private sARSRemoveLastSection As String

		Private sARSRemoveLastSections As String

		Public sRecommendedFricCoef As String

		Public sRecommendedFricCoefYesNo As String

		Public sSinkerRodDiameterWarningMsg As String

		Public sTotalDepth As String

		Public sTotalDepth_ft As String

		Public sTotalDepth_m As String

		Public sPleaseCheckInput As String

		Public sDataEntryError As String

		Public SEnterTaperLength As String

		Public SEnterSBLength As String

		Public sSmallLengthV As String

		Public sSmallLengthD As String

		Public sCannotMoveDown As String

		Public sCannotMoveUp As String

		Public sGradeBeforeSize As String

		Public sSelectTaperToRemove As String

		Public sRodLength As String

		Public sRodGrade As String

		Public sRodSize As String

		Public sRodType As String

		Public sFrictionCoefficient As String

		Public sActualRodDiameter As String

		Public sRodGuide As String

		Public sNumGuides As String

		Public sStressCalc As String

		Public sMethod As String

		Public sMinLessThanMan As String

		Private iSteelOrder As Integer

		Private iSinkberbarOrder As Integer

		Private iProrodOrder As Integer

		Private iCorodOrder As Integer

		Private iFiberglassOrder As Integer

		Private iRibbonrodOrder As Integer

		Private iCurrentRodNum As Integer

		Private bUseStatus As Boolean

		Private m_bLengthError As Boolean

		Private m_bClosing As Boolean

		Private m_bValidated As Boolean

		Private m_bFormLoaded As Boolean

		Private m_bLoadingCombo As Boolean

		Private bInsideUpdateRS As Boolean

		Private m_bRunSet As Boolean

		Private bEnterEditmode As Boolean

		Private Const N_RODNUM As Integer = 0

		Private Const N_RODTYPE As Integer = 1

		Private Const N_RODGRADE As Integer = 2

		Private Const N_RODSIZE As Integer = 3

		Private Const N_RODDIAM As Integer = 4

		Private Const N_RODLENGTH As Integer = 5

		Private Const N_RodFrictionCoef As Integer = 8

		Private Const N_RodGuide As Integer = 9

		Private Const N_NumGuides As Integer = 10

		Public sRecommendedFricCoefYesNo_LessThan As String

		Public sRecommendedFricCoefYesNo_GreaterThan As String

		Private CurrentColumn As String

		Private PreviousColumn As String

		Private bF2Hit As Boolean

		Private btxtLengthHasFocus As Boolean

		Private ThisF2Cell As UltraGridCell

		Private ThisF2Row As UltraGridRow

		Private vli As ValueListItem

		Private vlrs As ValueList

		Private vlrt As ValueList

		Private vlrg As ValueList

		Private vlswg As ValueList

		Private myRodTypeAL As ArrayList

		Private myRodSizeAL As ArrayList

		Private RSGrade_AL As ArrayList

		Private RSSBGrade_AL As ArrayList

		Private RSFGGrade_AL As ArrayList

		Private iNumDiams As Integer

		Public tmp_PumpDepth As Single

		Private m_bRodDesignTypeClicked As Boolean

		Private m_bRecommendedFricCoefShown As Boolean

		Private m_bRecommendedFricCoefYesNoShown As Boolean

		Private m_bLeaveLoaded As Boolean

		Private myKeyValueHT As Hashtable

		<AccessedThroughProperty("lblRodGuides")>
		Private _lblRodGuides As Label

		<AccessedThroughProperty("cboRSRodGuides")>
		Private _cboRSRodGuides As ComboBox

		<AccessedThroughProperty("lblRSSRSize")>
		Private _lblRSSRSize As Label

		<AccessedThroughProperty("cboRSSRSize")>
		Private _cboRSSRSize As ComboBox

		<AccessedThroughProperty("lblRSSRSize_Disabled")>
		Private _lblRSSRSize_Disabled As Label

		Private m_bCheckRodsInTubingMsgShown As Boolean

		<AccessedThroughProperty("cboRSGrade")>
		Private _cboRSGrade As ComboBox

		<AccessedThroughProperty("chkRSFGIncludeSteel")>
		Private _chkRSFGIncludeSteel As CheckBox

		<AccessedThroughProperty("fraSteelDesign")>
		Private _fraSteelDesign As GroupBox

		<AccessedThroughProperty("ctrSteelDesign")>
		Private _ctrSteelDesign As Panel

		<AccessedThroughProperty("cboRSFGGrade")>
		Private _cboRSFGGrade As ComboBox

		<AccessedThroughProperty("ctrFGDesign")>
		Private _ctrFGDesign As Panel

		<AccessedThroughProperty("ulgTapers")>
		Private _ulgTapers As UltraGrid

		<AccessedThroughProperty("ctrRodString")>
		Private _ctrRodString As Panel

		<AccessedThroughProperty("optSinkerRods")>
		Private _optSinkerRods As RadioButton

		<AccessedThroughProperty("optSinkerBars")>
		Private _optSinkerBars As RadioButton

		<AccessedThroughProperty("txtRSSBLength")>
		Private _txtRSSBLength As TextBox

		<AccessedThroughProperty("txtRSSBDiameter")>
		Private _txtRSSBDiameter As TextBox

		<AccessedThroughProperty("cboRSSBGrade")>
		Private _cboRSSBGrade As ComboBox

		<AccessedThroughProperty("chkRSIncludeSB")>
		Private _chkRSIncludeSB As CheckBox

		<AccessedThroughProperty("fraSinkerBars")>
		Private _fraSinkerBars As GroupBox

		<AccessedThroughProperty("ctrSinkerBars")>
		Private _ctrSinkerBars As Panel

		<AccessedThroughProperty("tbsRodDesignType")>
		Private _tbsRodDesignType As TabControl

		<AccessedThroughProperty("_Line_0")>
		Private __Line_0 As Label

		<AccessedThroughProperty("picRemoveFocus")>
		Private _picRemoveFocus As Panel

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("Line")>
		Private _Line As LabelArray

		<AccessedThroughProperty("imlRodDesignType")>
		Private _imlRodDesignType As ImageList

		<AccessedThroughProperty("XSR")>
		Private _XSR As TabPage

		<AccessedThroughProperty("XFD")>
		Private _XFD As TabPage

		<AccessedThroughProperty("USR")>
		Private _USR As TabPage

		<AccessedThroughProperty("_Label_Length")>
		Private __Label_Length As Label

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		<AccessedThroughProperty("txtTempLength")>
		Private _txtTempLength As TextBox

		<AccessedThroughProperty("txtTempDiam")>
		Private _txtTempDiam As TextBox

		<AccessedThroughProperty("cboRodType")>
		Private _cboRodType As ComboBox

		<AccessedThroughProperty("btnNumberOfRods")>
		Private _btnNumberOfRods As Button

		<AccessedThroughProperty("cmdAddSection")>
		Private _cmdAddSection As Button

		<AccessedThroughProperty("cmdDelSection")>
		Private _cmdDelSection As Button

		<AccessedThroughProperty("cmdMoveSectionUp")>
		Private _cmdMoveSectionUp As Button

		<AccessedThroughProperty("cmdMoveSectionDown")>
		Private _cmdMoveSectionDown As Button

		<AccessedThroughProperty("_Line_1")>
		Private __Line_1 As Label

		<AccessedThroughProperty("lstNumOfRods")>
		Private _lstNumOfRods As ListBox

		<AccessedThroughProperty("lblTemp")>
		Private _lblTemp As Label

		<AccessedThroughProperty("cboRodGrade")>
		Private _cboRodGrade As ComboBox

		<AccessedThroughProperty("ctrOtherInfo")>
		Private _ctrOtherInfo As Panel

		<AccessedThroughProperty("fraOtherInfo")>
		Private _fraOtherInfo As GroupBox

		<AccessedThroughProperty("txtServiceFactor")>
		Private _txtServiceFactor As TextBox

		<AccessedThroughProperty("txtRSExtraCostLabel")>
		Private _txtRSExtraCostLabel As TextBox

		<AccessedThroughProperty("txtRSExtraCost")>
		Private _txtRSExtraCost As TextBox

		<AccessedThroughProperty("cboLookupDiameter")>
		Private _cboLookupDiameter As ComboBox

		<AccessedThroughProperty("cboLookupDisplayName")>
		Private _cboLookupDisplayName As ComboBox

		<AccessedThroughProperty("txtRSFricCoeff")>
		Private _txtRSFricCoeff As TextBox

		<AccessedThroughProperty("lblRSFricCoeff")>
		Private _lblRSFricCoeff As Label

		<AccessedThroughProperty("lblServiceFactor")>
		Private _lblServiceFactor As Label

		<AccessedThroughProperty("lblRSSBLength")>
		Private _lblRSSBLength As Label

		<AccessedThroughProperty("lblRSExtraCostLabel")>
		Private _lblRSExtraCostLabel As Label

		<AccessedThroughProperty("lbRSExtraCost")>
		Private _lbRSExtraCost As Label

		<AccessedThroughProperty("lblRSSBDiameter")>
		Private _lblRSSBDiameter As Label

		<AccessedThroughProperty("lblRSSBGrade")>
		Private _lblRSSBGrade As Label

		<AccessedThroughProperty("lblRSMaxSize")>
		Private _lblRSMaxSize As Label

		<AccessedThroughProperty("lblRSMinSize")>
		Private _lblRSMinSize As Label

		<AccessedThroughProperty("lblRSGrade")>
		Private _lblRSGrade As Label

		<AccessedThroughProperty("lblRSFGGrade")>
		Private _lblRSFGGrade As Label

		<AccessedThroughProperty("lblRSSBDiameter_Disabled")>
		Private _lblRSSBDiameter_Disabled As Label

		<AccessedThroughProperty("lblFricFootnote")>
		Private _lblFricFootnote As Label

		<AccessedThroughProperty("txtLength")>
		Private _txtLength As TextBox

		<AccessedThroughProperty("cboRSMaxSize")>
		Private _cboRSMaxSize As ComboBox

		<AccessedThroughProperty("cboRSMinSize")>
		Private _cboRSMinSize As ComboBox

		<AccessedThroughProperty("lblRSSBLength_Disabled")>
		Private _lblRSSBLength_Disabled As Label

		<AccessedThroughProperty("lblRSGrade_Disabled")>
		Private _lblRSGrade_Disabled As Label

		<AccessedThroughProperty("lblRSMaxSize_Disabled")>
		Private _lblRSMaxSize_Disabled As Label

		<AccessedThroughProperty("lblRSMinSize_Disabled")>
		Private _lblRSMinSize_Disabled As Label

		<AccessedThroughProperty("lblRSSBGrade_Disabled")>
		Private _lblRSSBGrade_Disabled As Label

		<AccessedThroughProperty("lbl_RSSBDiameter_Disabled")>
		Private _lbl_RSSBDiameter_Disabled As Label

		<AccessedThroughProperty("cboRSSBDiameter")>
		Private _cboRSSBDiameter As ComboBox

		<AccessedThroughProperty("lblStatus")>
		Private _lblStatus As Label

		<AccessedThroughProperty("ContextMenu1")>
		Private _ContextMenu1 As ContextMenu

		<AccessedThroughProperty("cboRodGuides")>
		Private _cboRodGuides As ComboBox

		<AccessedThroughProperty("chkDesignSinkerbars")>
		Private _chkDesignSinkerbars As CheckBox

		<AccessedThroughProperty("lblStringLength")>
		Private _lblStringLength As Label

		Private Shared m_vb6FormDefInstance As RSInput

		Private Shared m_InitializingDefInstance As Boolean

		Private Const PM_POSITIONCTRL As Short = 1S

		Private Const PM_MOVEPREVCELL As Short = 2S

		Private Const PM_MOVENEXTCELL As Short = 3S

		Private Const PM_EXITEDITMODE As Short = 4S

		Private Const PM_PROCESSKEY As Short = 5S

		Private Const PM_SELECTFIRSTROW As Short = 6S

		Private Const S_NAME As String = "Name"

		Private Const S_DISPLAYNAME As String = "DisplayName"

		Private Const S_RODDIAM As String = "RodDiam"

		Private Const S_RODGRADE As String = "RodGrade"

		Private Const S_RODGRADEID As String = "RodGradeID"

		Private Const S_RODTYPE As String = "RodType"

		Private Const S_RODTYPEID As String = "RodTypeID"

		Private Const S_RODTYPEGRADE As String = "RodTypeGrade"

		Private Const S_RODTYPEGRADEID As String = "RodTypeGradeID"

		Private Const S_RODLENGTH As String = "RodLength"

		Private Const S_RODNUM As String = "RodNum"

		Private Const S_RODSIZE As String = "RodSize"

		Private Const S_RODSIZEID As String = "RodSizeID"

		Private Const S_RODGUIDE As String = "RodGuide"

		Private Const S_RODGUIDEID As String = "RodGuideID"

		Private Const S_NUMGUIDES As String = "NumGuides"

		Private Const S_RODFrictionCoef As String = "RodFrictionCoef"

		Private Const S_VLRODGRADES As String = "VLRodGrades"

		Private Const S_VLRODSIZES As String = "VLRodSizes"

		Private Const S_VLRODTYPES As String = "VLRodTypes"

		Private Const S_VLSWGUIDES As String = "VLSWGuides"

		Private Const cMAXHEIGHT As Integer = 5340

		Private Const cMAXWIDTH As Integer = 8055

		Private myRodTypeGradeAL As ArrayList

		Private myRSGradeAL As ArrayList

		Private myRodGuideAL As ArrayList

		Private myRSMaxDiamAL As ArrayList

		Private myRSMinDiamAL As ArrayList

		Private myRSSBDiamAL As ArrayList

		Private myRSSRDiamAL As ArrayList

		Private myRSMaxDiamRodSizeArray As RSInput.RodSizeArray()

		Private myRSMinDiamRodSizeArray As RSInput.RodSizeArray()

		Private myRSSBDiamRodSizeArray As RSInput.RodSizeArray()

		Private myRSSRDiamRodSizeArray As RSInput.RodSizeArray()

		Public Chr9 As String

		Private mbFirstResize As Boolean

		Private m_mbMaxMinNotYetSet As Boolean

		Private sbMaxMinNotYetSet As Boolean

		Private mcxSteelDesignInfoOffset As Integer

		Private mcySteelDesignInfoOffset As Integer

		Private mfMouseDownX As Single

		Private mfMouseDownY As Single

		Private m_iCurrentRodSection As Integer

		Private m_miDesignStyle As RSInput.EDesignStyle

		Private miNewRodNum As Integer

		Private mdsRodTapers As DataSet

		Private msSavedFormCaption As String

		Private bDisplayDeleteMessage As Boolean

		<AccessedThroughProperty("cboRodSize")>
		Private _cboRodSize As ComboBox

		Private $STATIC$AddToArrayList$20712101281458E8EE$iCount As Integer

		Private $STATIC$AddToGuideArrayList$20712101281458E8EE$iCount As Integer

		Private $STATIC$cboRSGrade_Click_1$202162$iOldRodGrade As Short

		Public Structure RodSizeArray
			Public rsaRodSizeID As Integer

			Public rsaDisplayName As String

			Public rsaDiameter As Single
		End Structure

		Public Class rsaComparer
			Implements IComparer

			Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
				Dim result As Integer
				Try
					Dim rodSizeArray As RSInput.RodSizeArray
					Dim obj As Object = If((y IsNot Nothing), CType(y, RSInput.RodSizeArray), rodSizeArray).rsaDiameter * 1000F - If((x IsNot Nothing), CType(x, RSInput.RodSizeArray), rodSizeArray).rsaDiameter * 1000F
					result = Conversions.ToInteger(obj)
				Catch ex As Exception
				End Try
				Return result
			End Function
		End Class

		Public Structure RodGradeArray
			Public RodGradeID As Integer

			Public DisplayName As String

			Public DisplayOrder As Integer
		End Structure

		Public Class rgaComparer
			Implements IComparer

			Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
				Dim result As Integer
				Try
					Dim num As Integer = New CaseInsensitiveComparer().Compare(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(x, Nothing, "DisplayOrder", New Object(-1) {}, Nothing, Nothing, Nothing)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(y, Nothing, "DisplayOrder", New Object(-1) {}, Nothing, Nothing, Nothing)))
					result = num
				Catch ex As Exception
				End Try
				Return result
			End Function
		End Class

		Private Enum EDesignStyle
			ersSteel
			ersFiberglass
			ersRibbonRod
			ersManual
			ersAPI
		End Enum
	End Class
End Namespace
