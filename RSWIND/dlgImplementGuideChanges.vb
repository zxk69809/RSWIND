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
Imports DataDynamics.ActiveReports.DataSources
Imports DataDynamics.ActiveReports.Document
Imports DataDynamics.ActiveReports.Viewer
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices
Imports ThetaStdInfo

Namespace RSWINV3
	Friend Partial Class dlgImplementGuideChanges
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Activated, AddressOf Me.dlgImplementGuideChanges_Activated
			AddHandler MyBase.FormClosing, AddressOf Me.dlgImplementGuideChanges_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.sRodStringLength = Util.AssignValueToConstant("RSInput", "sRodStringLength", "Rod String Length: ")
			Me.sPumpDepth = Util.AssignValueToConstant("RSInput", "sPumpDepth", "Pump Depth")
			Me.sARSRemoveSelected = Util.AssignValueToConstant("RSInput", "sARSRemoveSelected", "Are you sure you want to remove the selected rod section?")
			Me.sDeleteRow = Util.AssignValueToConstant("RSInput", "sDeleteRow", "Delete row(s)")
			Me.sARSRemoveLastSection = Util.AssignValueToConstant("RSInput", "sARSRemoveLastSection", "Are you sure you want to remove the last rod section?")
			Me.sARSRemoveLastSections = Util.AssignValueToConstant("RSInput", "sARSRemoveLastSections", "Are you sure you want to remove the last rod sections?")
			Me.sRecommendedFricCoef = Util.AssignValueToConstant("RSInput", "sRecommendedFricCoef", "Minimum recommended Sliding Friction Coefficient is 0.2")
			Me.sRecommendedFricCoefYesNo = Util.AssignValueToConstant("RSInput", "sRecommendedFricCoefYesNo", "Sliding Friction Coefficient value is greater than 0.2. Change value now?")
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
			Me.m_bAccept = False
			Me.m_bKeep = False
			Me.fDepths = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Me.bShowGuides = True
			Me.bUseStatus = True
			Me.bCheckRodsInTubingMsgShown = False
			Me.bInsideUpdateRS = False
			Me.bEnterEditmode = False
			Me.myRodTypeGradeAL = New ArrayList()
			Me.myRSGradeAL = New ArrayList()
			Me.myRodGuideAL = New ArrayList()
			Me.myRSMaxDiamAL = New ArrayList()
			Me.myRSMinDiamAL = New ArrayList()
			Me.myRSSBDiamAL = New ArrayList()
			Me.myRodTypeAL = New ArrayList()
			Me.myRodSizeAL = New ArrayList()
			Me.RSGrade_AL = New ArrayList()
			Me.RSSBGrade_AL = New ArrayList()
			Me.RSFGGrade_AL = New ArrayList()
			Me.bLengthError = False
			Me.bDisplayDeleteMessage = True
			Me.bLoadingCombo = False
			Me.bValidated = False
			Me.tmp_PumpDepth = 0F
			Me.sRecommendedFricCoefYesNo_LessThan = "Sliding Friction Coefficient value is less than 0.2. Change value now?"
			Me.sRecommendedFricCoefYesNo_GreaterThan = "Sliding Friction Coefficient value is greater than 0.2. Change value now?"
			Me.PreviousColumn = ""
			Me.bF2Hit = False
			Me.btxtLengthHasFocus = False
			Me.SETUP_RECOMMEND_GUIDES_SAVE = RSWIN_DESC.SETUP_RECOMMEND_GUIDES
			Me.bValueListsCreated = False
			Me.bImplementChosen = False
			Me.bFormLoaded = False
			Me.bActivated = False
			Me.m_bRodDesignTypeClicked = False
			Me.m_bRecommendedFricCoefShown = False
			Me.m_bRecommendedFricCoefYesNoShown = False
			Me.m_bLeaveLoaded = False
			If dlgImplementGuideChanges.m_vb6FormDefInstance Is Nothing Then
				If dlgImplementGuideChanges.m_InitializingDefInstance Then
					dlgImplementGuideChanges.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgImplementGuideChanges.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property _SSPanel_0 As Panel
			Get
				Return Me.__SSPanel_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__SSPanel_0 = value
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

		Public Overridable Property ulgTapers_before As UltraGrid
			Get
				Return Me._ulgTapers_before
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As InitializeRowEventHandler = AddressOf Me.ulgTapers_before_InitializeRow
				Dim value3 As InitializeLayoutEventHandler = AddressOf Me.ulgTapers_before_InitializeLayout
				If Me._ulgTapers_before IsNot Nothing Then
					RemoveHandler Me._ulgTapers_before.InitializeRow, value2
					RemoveHandler Me._ulgTapers_before.InitializeLayout, value3
				End If
				Me._ulgTapers_before = value
				If Me._ulgTapers_before IsNot Nothing Then
					AddHandler Me._ulgTapers_before.InitializeRow, value2
					AddHandler Me._ulgTapers_before.InitializeLayout, value3
				End If
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

		Friend Overridable Property lblTemp As Label
			Get
				Return Me._lblTemp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTemp = value
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

		Friend Overridable Property cboRodGrade As ComboBox
			Get
				Return Me._cboRodGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As CancelEventHandler = AddressOf Me.cboRodGrade_Validating
				Dim value3 As EventHandler = AddressOf Me.cboRodGrade_Enter
				Dim value4 As EventHandler = AddressOf Me.cboRodGrade_SelectionChangeCommitted
				If Me._cboRodGrade IsNot Nothing Then
					RemoveHandler Me._cboRodGrade.Validating, value2
					RemoveHandler Me._cboRodGrade.Enter, value3
					RemoveHandler Me._cboRodGrade.SelectionChangeCommitted, value4
				End If
				Me._cboRodGrade = value
				If Me._cboRodGrade IsNot Nothing Then
					AddHandler Me._cboRodGrade.Validating, value2
					AddHandler Me._cboRodGrade.Enter, value3
					AddHandler Me._cboRodGrade.SelectionChangeCommitted, value4
				End If
			End Set
		End Property

		Public Overridable Property btnImplement As Button
			Get
				Return Me._btnImplement
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnImplement_Click
				If Me._btnImplement IsNot Nothing Then
					RemoveHandler Me._btnImplement.Click, value2
				End If
				Me._btnImplement = value
				If Me._btnImplement IsNot Nothing Then
					AddHandler Me._btnImplement.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdCancel As Button
			Get
				Return Me._cmdCancel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdOK_Click
				If Me._cmdCancel IsNot Nothing Then
					RemoveHandler Me._cmdCancel.Click, value2
				End If
				Me._cmdCancel = value
				If Me._cmdCancel IsNot Nothing Then
					AddHandler Me._cmdCancel.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property ulgTapers As UltraGrid
			Get
				Return Me._ulgTapers
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As RowEventHandler = AddressOf Me.ulgTapers_AfterRowInsert
				Dim value3 As BeforeCellUpdateEventHandler = AddressOf Me.ulgTapers_BeforeCellUpdate
				Dim value4 As RowEventHandler = AddressOf Me.ulgTapers_AfterRowUpdate
				Dim value5 As EventHandler = AddressOf Me.ulgTapers_AfterRowActivate
				Dim value6 As CellEventHandler = AddressOf Me.ulgTapers_CellChange
				Dim value7 As CellEventHandler = AddressOf Me.ulgTapers_AfterCellUpdate
				Dim value8 As BeforeSortChangeEventHandler = AddressOf Me.ulgTapers_BeforeSortChange
				Dim value9 As EventHandler = AddressOf Me.ulgTapers_AfterExitEditMode
				Dim value10 As EventHandler = AddressOf Me.ulgTapers_Leave
				Dim value11 As EventHandler = AddressOf Me.ulgTapers_AfterEnterEditMode
				Dim value12 As CancelableCellEventHandler = AddressOf Me.ulgTapers_BeforeCellActivate
				Dim value13 As RowEventHandler = AddressOf Me.ulgTapers_AfterRowResize
				Dim value14 As RowScrollRegionEventHandler = AddressOf Me.ulgTapers_AfterRowRegionSize
				Dim value15 As RowScrollRegionEventHandler = AddressOf Me.ulgTapers_AfterRowRegionScroll
				Dim value16 As ColScrollRegionEventHandler = AddressOf Me.ulgTapers_AfterColRegionSize
				Dim value17 As ColScrollRegionEventHandler = AddressOf Me.ulgTapers_AfterColRegionScroll
				Dim value18 As AfterColPosChangedEventHandler = AddressOf Me.ulgTapers_AfterColPosChanged
				Dim value19 As MouseEventHandler = AddressOf Me.ulgTapers_MouseDownEvent
				Dim value20 As InitializeRowEventHandler = AddressOf Me.ulgTapers_InitializeRow
				Dim value21 As EventHandler = AddressOf Me.ulgTapers_AfterRowActivate_2
				Dim value22 As EventHandler = AddressOf Me.ulgTapers_AfterCellActivate
				Dim value23 As InitializeLayoutEventHandler = AddressOf Me.ulgTapers_InitializeLayout
				Dim value24 As KeyEventHandler = AddressOf Me.ulgTapers_KeyDown
				Dim value25 As CancelableCellEventHandler = AddressOf Me.ulgTapers_BeforeCellListDropDown
				Dim value26 As BeforeRowRegionScrollEventHandler = AddressOf Me.ulgTapers_BeforeRowRegionScroll
				Dim value27 As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventHandler = AddressOf Me.ulgTapers_BeforeExitEditMode
				Dim value28 As CancelEventHandler = AddressOf Me.ulgTapers_BeforeEnterEditMode
				Dim value29 As BeforeColRegionScrollEventHandler = AddressOf Me.ulgTapers_BeforeColRegionScroll
				Dim value30 As CancelEventHandler = AddressOf Me.ulgTapers_BeforeCellDeactivate
				Dim value31 As EventHandler = AddressOf Me.ulgTapers_AfterRowsDeleted
				Dim value32 As BeforeRowsDeletedEventHandler = AddressOf Me.ulgTapers_BeforeRowsDeleted
				If Me._ulgTapers IsNot Nothing Then
					RemoveHandler Me._ulgTapers.AfterRowInsert, value2
					RemoveHandler Me._ulgTapers.BeforeCellUpdate, value3
					RemoveHandler Me._ulgTapers.AfterRowUpdate, value4
					RemoveHandler Me._ulgTapers.AfterRowActivate, value5
					RemoveHandler Me._ulgTapers.CellChange, value6
					RemoveHandler Me._ulgTapers.AfterCellUpdate, value7
					RemoveHandler Me._ulgTapers.BeforeSortChange, value8
					RemoveHandler Me._ulgTapers.AfterExitEditMode, value9
					RemoveHandler Me._ulgTapers.Leave, value10
					RemoveHandler Me._ulgTapers.AfterEnterEditMode, value11
					RemoveHandler Me._ulgTapers.BeforeCellActivate, value12
					RemoveHandler Me._ulgTapers.AfterRowResize, value13
					RemoveHandler Me._ulgTapers.AfterRowRegionSize, value14
					RemoveHandler Me._ulgTapers.AfterRowRegionScroll, value15
					RemoveHandler Me._ulgTapers.AfterColRegionSize, value16
					RemoveHandler Me._ulgTapers.AfterColRegionScroll, value17
					RemoveHandler Me._ulgTapers.AfterColPosChanged, value18
					RemoveHandler Me._ulgTapers.MouseDown, value19
					RemoveHandler Me._ulgTapers.InitializeRow, value20
					RemoveHandler Me._ulgTapers.AfterRowActivate, value21
					RemoveHandler Me._ulgTapers.AfterCellActivate, value22
					RemoveHandler Me._ulgTapers.InitializeLayout, value23
					RemoveHandler Me._ulgTapers.KeyDown, value24
					RemoveHandler Me._ulgTapers.BeforeCellListDropDown, value25
					RemoveHandler Me._ulgTapers.BeforeRowRegionScroll, value26
					RemoveHandler Me._ulgTapers.BeforeExitEditMode, value27
					RemoveHandler Me._ulgTapers.BeforeEnterEditMode, value28
					RemoveHandler Me._ulgTapers.BeforeColRegionScroll, value29
					RemoveHandler Me._ulgTapers.BeforeCellDeactivate, value30
					RemoveHandler Me._ulgTapers.AfterRowsDeleted, value31
					RemoveHandler Me._ulgTapers.BeforeRowsDeleted, value32
				End If
				Me._ulgTapers = value
				If Me._ulgTapers IsNot Nothing Then
					AddHandler Me._ulgTapers.AfterRowInsert, value2
					AddHandler Me._ulgTapers.BeforeCellUpdate, value3
					AddHandler Me._ulgTapers.AfterRowUpdate, value4
					AddHandler Me._ulgTapers.AfterRowActivate, value5
					AddHandler Me._ulgTapers.CellChange, value6
					AddHandler Me._ulgTapers.AfterCellUpdate, value7
					AddHandler Me._ulgTapers.BeforeSortChange, value8
					AddHandler Me._ulgTapers.AfterExitEditMode, value9
					AddHandler Me._ulgTapers.Leave, value10
					AddHandler Me._ulgTapers.AfterEnterEditMode, value11
					AddHandler Me._ulgTapers.BeforeCellActivate, value12
					AddHandler Me._ulgTapers.AfterRowResize, value13
					AddHandler Me._ulgTapers.AfterRowRegionSize, value14
					AddHandler Me._ulgTapers.AfterRowRegionScroll, value15
					AddHandler Me._ulgTapers.AfterColRegionSize, value16
					AddHandler Me._ulgTapers.AfterColRegionScroll, value17
					AddHandler Me._ulgTapers.AfterColPosChanged, value18
					AddHandler Me._ulgTapers.MouseDown, value19
					AddHandler Me._ulgTapers.InitializeRow, value20
					AddHandler Me._ulgTapers.AfterRowActivate, value21
					AddHandler Me._ulgTapers.AfterCellActivate, value22
					AddHandler Me._ulgTapers.InitializeLayout, value23
					AddHandler Me._ulgTapers.KeyDown, value24
					AddHandler Me._ulgTapers.BeforeCellListDropDown, value25
					AddHandler Me._ulgTapers.BeforeRowRegionScroll, value26
					AddHandler Me._ulgTapers.BeforeExitEditMode, value27
					AddHandler Me._ulgTapers.BeforeEnterEditMode, value28
					AddHandler Me._ulgTapers.BeforeColRegionScroll, value29
					AddHandler Me._ulgTapers.BeforeCellDeactivate, value30
					AddHandler Me._ulgTapers.AfterRowsDeleted, value31
					AddHandler Me._ulgTapers.BeforeRowsDeleted, value32
				End If
			End Set
		End Property

		Friend Overridable Property lblStatus As Label
			Get
				Return Me._lblStatus
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblStatus = value
			End Set
		End Property

		Friend Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property TextBox1 As TextBox
			Get
				Return Me._TextBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		Friend Overridable Property TextBox2 As TextBox
			Get
				Return Me._TextBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox2 = value
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
				If Me._txtLength IsNot Nothing Then
					RemoveHandler Me._txtLength.Enter, value2
					RemoveHandler Me._txtLength.Leave, value3
					RemoveHandler Me._txtLength.KeyDown, value4
				End If
				Me._txtLength = value
				If Me._txtLength IsNot Nothing Then
					AddHandler Me._txtLength.Enter, value2
					AddHandler Me._txtLength.Leave, value3
					AddHandler Me._txtLength.KeyDown, value4
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

		Public Overridable Property _Label_Length As Label
			Get
				Return Me.__Label_Length
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_Length = value
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

		Public Overridable Property btnAccept As Button
			Get
				Return Me._btnAccept
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAccept_Click
				If Me._btnAccept IsNot Nothing Then
					RemoveHandler Me._btnAccept.Click, value2
				End If
				Me._btnAccept = value
				If Me._btnAccept IsNot Nothing Then
					AddHandler Me._btnAccept.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlViewReport As Panel
			Get
				Return Me._pnlViewReport
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlViewReport = value
			End Set
		End Property

		Friend Overridable Property Viewer1 As Viewer
			Get
				Return Me._Viewer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Viewer)
				Me._Viewer1 = value
			End Set
		End Property

		Friend Overridable Property chkShowReport As CheckBox
			Get
				Return Me._chkShowReport
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkShowReport_CheckedChanged
				If Me._chkShowReport IsNot Nothing Then
					RemoveHandler Me._chkShowReport.CheckedChanged, value2
				End If
				Me._chkShowReport = value
				If Me._chkShowReport IsNot Nothing Then
					AddHandler Me._chkShowReport.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property btnUndoImplement As Button
			Get
				Return Me._btnUndoImplement
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnUndoImplement_Click
				If Me._btnUndoImplement IsNot Nothing Then
					RemoveHandler Me._btnUndoImplement.Click, value2
				End If
				Me._btnUndoImplement = value
				If Me._btnUndoImplement IsNot Nothing Then
					AddHandler Me._btnUndoImplement.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblMinimum As Label
			Get
				Return Me._lblMinimum
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMinimum = value
			End Set
		End Property

		Friend Overridable Property lblMaximum As Label
			Get
				Return Me._lblMaximum
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMaximum = value
			End Set
		End Property

		Friend Overridable Property cboRodSize As ComboBox
			Get
				Return Me._cboRodSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As CancelEventHandler = AddressOf Me.cboRodSize_Validating
				Dim value3 As EventHandler = AddressOf Me.cboRodSize_Enter
				Dim value4 As EventHandler = AddressOf Me.cboRodSize_SelectionChangeCommitted
				If Me._cboRodSize IsNot Nothing Then
					RemoveHandler Me._cboRodSize.Validating, value2
					RemoveHandler Me._cboRodSize.Enter, value3
					RemoveHandler Me._cboRodSize.SelectionChangeCommitted, value4
				End If
				Me._cboRodSize = value
				If Me._cboRodSize IsNot Nothing Then
					AddHandler Me._cboRodSize.Validating, value2
					AddHandler Me._cboRodSize.Enter, value3
					AddHandler Me._cboRodSize.SelectionChangeCommitted, value4
				End If
			End Set
		End Property

		Public Shared Property DefInstance As dlgImplementGuideChanges
			Get
				If dlgImplementGuideChanges.m_vb6FormDefInstance Is Nothing OrElse dlgImplementGuideChanges.m_vb6FormDefInstance.IsDisposed Then
					dlgImplementGuideChanges.m_InitializingDefInstance = True
					dlgImplementGuideChanges.m_vb6FormDefInstance = New dlgImplementGuideChanges()
					dlgImplementGuideChanges.m_InitializingDefInstance = False
				End If
				Return dlgImplementGuideChanges.m_vb6FormDefInstance
			End Get
			Set(value As dlgImplementGuideChanges)
				dlgImplementGuideChanges.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property bAccept As Boolean
			Get
				Return Me.m_bAccept
			End Get
			Set(value As Boolean)
				Me.m_bAccept = value
			End Set
		End Property

		Public Property bKeep As Boolean
			Get
				Return Me.m_bKeep
			End Get
			Set(value As Boolean)
				Me.m_bKeep = value
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

		Private Sub dlgImplementGuideChanges_Activated(sender As Object, e As EventArgs)
			Try
				If Me.bFormLoaded And Not Me.bActivated Then
					Dim now As DateTime = DateAndTime.Now
					Try
						Util.BusyCursor()
						Application.DoEvents()
						For i As Integer = DateAndTime.Now.Subtract(now).Seconds To 2 - 1
							Application.DoEvents()
						Next
					Catch ex As Exception
						Util.UnbusyCursor()
					End Try
					Try
						Me.bActivated = True
						Me.DoExecuteImplementation()
					Catch ex2 As Exception
						Me.bActivated = True
					End Try
					Me.cmdCancel.Enabled = True
					Me.chkShowReport.Enabled = True
					Util.UnbusyCursor()
				End If
			Catch ex3 As Exception
				Me.cmdCancel.Enabled = True
				Me.chkShowReport.Enabled = True
				Me.bActivated = True
				Util.UnbusyCursor()
			End Try
		End Sub

		Private Sub dlgImplementGuideChanges_FormClosing(sender As Object, e As FormClosingEventArgs)
			If Not Me.m_bAccept Then
				RSWIN_DESC.rst.RodStringType = RSWIN_DESC.SaveRodStringType
			End If
			RSWIN_DESC.bImplementingRodGuides = False
			Try
				Dim num As Integer = 1
				Do
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Try
						RSWIN_DESC.saved_rst(num) = Nothing
					Catch ex As Exception
					End Try
					Try
						RSWIN_DESC.saved_Impred(num) = Nothing
					Catch ex2 As Exception
					End Try
					Try
						RSWIN_DESC.saved_rod_designs(num) = Nothing
					Catch ex3 As Exception
					End Try
					Try
						RSWIN_DESC.saved_num_rods(num) = 0
					Catch ex4 As Exception
					End Try
					num += 1
				Loop While num <= 2
			Catch ex5 As Exception
			End Try
			Try
				Me.rptRecommendedGuideReport = Nothing
			Catch ex6 As Exception
			End Try
			Try
				Me.RemoveAllChildForms(True)
			Catch ex7 As Exception
			End Try
			Try
				Dim num As Integer = 1
				Do
					Application.DoEvents()
					num += 1
				Loop While num <= 1000
			Catch ex8 As Exception
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

		Private Sub Me_Load(eventSender As Object, eventArgs As EventArgs)
			SUPERPRO.NewCheckSentinel(True)
			RSWIN.GetMeasurementUnit()
			RSWIN_DESC.bImplementingRodGuides = True
			Try
				Me.btnImplement.Enabled = False
				Me.btnUndoImplement.Enabled = False
				Me.btnAccept.Enabled = False
				Me.cmdCancel.Enabled = False
				Me.lblStatus.Text = ""
				RSWIN_DESC.SaveRodStringType = RSWIN_DESC.rst.RodStringType
				RSWIN_DESC.rst.RodStringType = 2S
				Me.bFormLoaded = False
				Me.bActivated = False
				Me.btnImplement.Enabled = False
				RSWIN_DESC.sCurrentFormName = "dlgImplementGuideChanges"
				Me.lblMaximum.Text = ""
				Me.lblMinimum.Text = ""
				Me.chkShowReport.Checked = True
				Me.txtTempLength.Visible = False
				Me.txtLength.Visible = False
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
				Try
					RSWIN_DESC.saved_rod_designs = New RSWIN_DESC.previous_rod_design_type(2) {}
					RSWIN_DESC.saved_num_rods = New Integer(2) {}
					RSWIN_DESC.saved_rst = New cRODSTAR(2) {}
					RSWIN_DESC.saved_Impred = New TEImpred(2) {}
				Catch ex As Exception
				End Try
				Try
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						RSWIN_DESC.SaveSections(i) = RSWIN_DESC.rst.Sections(i)
					Next
				Catch ex2 As Exception
				End Try
				Me.iOrigNumRods = CInt(RSWIN_DESC.rst.NumRods)
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
				If Not RSWIN_DESC.bUseLatestGradeChanges Then
					Me.iCorodOrder = 214
					Me.iProrodOrder = 306
					Me.iNorris97 = 4
				Else
					Me.iProrodOrder = 205
					Me.iCorodOrder = 311
					Me.iNorris97 = 7
				End If
				Dim num2 As Integer
				Dim text3 As String
				Try
					Dim text As String = "MeasurementSystem"
					num2 = 1
					RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_GENERAL, text, num2))
					If Not(RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Or RSWIN_DESC.SETUP_MeasurementSystem = 3) Then
						RSWIN_DESC.SETUP_MeasurementSystem = 1
						text = "MeasurementSystem"
						Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
						Dim text2 As String = Util.Format(obj)
						RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
						text3 = text2
						Dim num3 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
					End If
				Catch ex3 As Exception
					RSWIN_DESC.SETUP_MeasurementSystem = 1
					text3 = "MeasurementSystem"
					Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
					Dim text4 As String = Util.Format(obj)
					RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
					Dim text As String = text4
					Dim num3 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text3, text, RSWIN_DESC.sINIFile)
				End Try
				Dim flag As Boolean
				If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					text3 = "DisplaySBinFeet"
					flag = True
					RSWIN_DESC.SETUP_DisplaySBinFeet = If(-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_GENERAL, text3, flag) > False), 1S, 0S), 1S, 0S)
				End If
				text3 = "BareRodFricCoeff"
				Dim num4 As Single = 0.2F
				RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num4))
				text3 = "MoldedFricCoeff"
				RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fDefaultFricCoeff))
				text3 = "WheelFricCoeff"
				RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fDefaultFricCoeff))
				text3 = "OtherFricCoeff"
				RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fDefaultFricCoeff))
				text3 = "NorrisStandardGuideFricCoeff"
				RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "NorrisSidewinderGuideFricCoeff"
				RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "RGIJakeCouplingGuideFricCoeff"
				RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "RGISVTGuideFricCoeff"
				RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "RGITomahawkGuideFricCoeff"
				RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "RGITornadoGuideFricCoeff"
				RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "RGITwisterGuideFricCoeff"
				RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "RGIWVTGuideFricCoeff"
				RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "BareRodLoad"
				num4 = 50F
				RSWIN_DESC.SETUP_BAREROD_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num4))
				text3 = "MoldedLoad"
				num4 = 40F
				RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num4))
				text3 = "WheelLoad"
				num4 = 25F
				RSWIN_DESC.SETUP_WHEELGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num4))
				text3 = "OtherLoad"
				num4 = 32.5F
				RSWIN_DESC.SETUP_OTHERGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num4))
				text3 = "MaxSideLoadLimit"
				num4 = 30F
				RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num4))
				text3 = "RodGuideOverlap"
				num4 = 150F
				RSWIN_DESC.Setup_RodGuideOverlap = Conversions.ToInteger(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num4))
				text3 = "NumRodsPerBundle"
				num4 = 20F
				RSWIN_DESC.Setup_NumRodsPerBundle = Conversions.ToInteger(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num4))
				Dim sDefaultName As String = "SteelSuckerRodLength"
				Dim value As Object = DBNull.Value
				flag = False
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag))
				RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
				text3 = "MinNumGuidesPerRod"
				num2 = 3
				RSWIN_DESC.SETUP_MinNumGuidesPerRod = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text3, num2))
				text3 = "MaxNumGuidesPerRod"
				num2 = 6
				RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text3, num2))
				If Not Me.bFormLoaded Then
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					RSWIN_DESC.saved_rod_designs(0).Initialize()
					Dim num5 As Integer = 1
					Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For j As Integer = num5 To numRods2
						RSWIN_DESC.saved_rod_designs(0).Sections(j).Initialize()
					Next
					Try
						RSWIN_DESC.saved_rst(0) = New cRODSTAR()
						RSWIN_DESC.saved_rst(0) = RSWIN_DESC.rst
					Catch ex4 As Exception
					End Try
					Try
						RSWIN_DESC.saved_Impred(0) = New TEImpred()
						Dim teimpred As TEImpred = New TEImpred()
						teimpred = MImpred.ImpredObj
						RSWIN_DESC.saved_Impred(0) = New TEImpred()
						RSWIN_DESC.saved_Impred(0) = teimpred
					Catch ex5 As Exception
					End Try
				End If
				Try
					RSWIN_DESC.saved_num_rods(0) = CInt(RSWIN_DESC.rst.NumRods)
					Dim num6 As Integer = 1
					Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num6 To numRods3
						RSWIN_DESC.saved_rod_designs(0).Sections(i) = RSWIN_DESC.rst.Sections(i)
					Next
				Catch ex6 As Exception
				End Try
				Application.DoEvents()
				Me.FormLoad()
				Application.DoEvents()
				Application.DoEvents()
				Me.bFormLoaded = True
			Catch ex7 As Exception
			End Try
		End Sub

		Private Sub FormLoad()
			Try
				SUPERPRO.NewCheckSentinel(True)
				Me.mdsRodTapers = Nothing
				Me.CreateDataSet(False)
				Me.SetupForm()
				If RSWIN_DESC.rst IsNot Nothing Then
					Me.Load_Form(False)
					Dim ulgTapers_before As UltraGrid = Me.ulgTapers_before
					ulgTapers_before.DataSource = Me.mdsRodTapers
					ulgTapers_before.Rows.Refresh(RefreshRow.FireInitializeRow, True)
					Dim row As UltraGridRow = ulgTapers_before.GetRow(ChildRow.First)
					If row IsNot Nothing Then
						ulgTapers_before.ActiveRow = row
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in Load RSInput: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub SetupForm()
			If Not Me.bValueListsCreated Then
				Dim ulgTapers_before As UltraGrid = Me.ulgTapers_before
				Me.CreateValueLists(ulgTapers_before, False)
				Me.ulgTapers_before = ulgTapers_before
			End If
			Me.cmdAddSection.Enabled = False
			Me.cmdDelSection.Enabled = False
			Me.cmdMoveSectionUp.Enabled = False
			Me.cmdMoveSectionDown.Enabled = False
			Me.cmdAddSection.Visible = False
			Me.cmdDelSection.Visible = False
			Me.cmdMoveSectionUp.Visible = False
			Me.cmdMoveSectionDown.Visible = False
			Dim cboRodSize As ComboBox = Me.cboRodSize
			cboRodSize.DisplayMember = "DisplayName"
			cboRodSize.ValueMember = "RodSizeID"
			Dim cboRodGrade As ComboBox = Me.cboRodGrade
			cboRodGrade.DisplayMember = "DisplayName"
			cboRodGrade.ValueMember = "RodGradeID"
			Dim cboRodGuides As ComboBox = Me.cboRodGuides
			cboRodGuides.DisplayMember = "DisplayName"
			cboRodGuides.ValueMember = "RodGuideID"
		End Sub

		Private Sub ulgTapers_before_InitializeLayout(eventSender As Object, eventArgs As InitializeLayoutEventArgs)
			Try
				Dim layout As UltraGridLayout = eventArgs.Layout
				layout.TabNavigation = TabNavigation.NextCell
				Dim ultraGridBand As UltraGridBand = layout.Bands(0)
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns("RodNum")
				ultraGridColumn.Header.Caption = "#"
				ultraGridColumn.Width = 28
				ultraGridColumn.Tag = ""
				Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns("RodGrade")
				ultraGridColumn2.Header.Caption = "Rod Grade"
				ultraGridColumn2.ValueList = Me.ulgTapers_before.DisplayLayout.ValueLists("VLRodGrades")
				ultraGridColumn2.Width = 223
				ultraGridColumn2.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn2.Tag = ""
				ultraGridColumn2.Header.Fixed = True
				Dim ultraGridColumn3 As UltraGridColumn = ultraGridBand.Columns("RodSize")
				ultraGridColumn3.Header.Caption = Me.sRodSize + " (" + RSWIN_DESC.inch + ")"
				ultraGridColumn3.Width = 158
				ultraGridColumn3.ValueList = Me.ulgTapers_before.DisplayLayout.ValueLists("VLRodSizes")
				ultraGridColumn3.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn3.Tag = ""
				Dim ultraGridColumn4 As UltraGridColumn = ultraGridBand.Columns("RodDiam")
				ultraGridColumn4.Header.Caption = Me.sActualRodDiameter
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					ultraGridColumn4.Header.Caption = Me.sActualRodDiameter + " (" + RSWIN_DESC.inch + ")"
				ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					ultraGridColumn4.Header.Caption = Me.sActualRodDiameter + " (" + RSWIN_DESC.mm + ")"
				End If
				ultraGridColumn4.Width = 113
				ultraGridColumn4.Tag = ""
				Dim ultraGridColumn5 As UltraGridColumn = ultraGridBand.Columns("RodLength")
				ultraGridColumn5.Width = 88
				ultraGridColumn5.Header.Caption = Me.sRodLength
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					ultraGridColumn5.Header.Caption = Me.sRodLength + " (" + RSWIN_DESC.ft + ")"
				ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					ultraGridColumn5.Header.Caption = Me.sRodLength + " (" + RSWIN_DESC.m + ")"
				End If
				ultraGridColumn5.Tag = "Length (^)" & vbLf & "fem"
				Dim ultraGridColumn6 As UltraGridColumn = ultraGridBand.Columns("RodGuide")
				ultraGridColumn6.Header.Caption = "Guide"
				ultraGridColumn6.ValueList = Me.ulgTapers_before.DisplayLayout.ValueLists("VLSWGuides")
				ultraGridColumn6.Width = 158
				ultraGridColumn6.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn6.Tag = ""
				Dim ultraGridColumn7 As UltraGridColumn = ultraGridBand.Columns("RodFrictionCoef")
				ultraGridColumn7.Width = 88
				ultraGridColumn7.Header.Caption = "* Fric Coeff"
				ultraGridColumn7.Tag = "Fric Coeff"
				If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
					Dim ultraGridColumn8 As UltraGridColumn = ultraGridBand.Columns("NumGuides")
					ultraGridColumn8.Header.Caption = Me.sNumGuides
					ultraGridColumn8.Width = 98
					ultraGridColumn8.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
					ultraGridColumn8.Tag = ""
				End If
				Dim ultraGrid As UltraGrid = Me.ulgTapers_before
				Try
					ultraGrid.ActiveRow = ultraGrid.GetRow(ChildRow.First)
				Catch ex As Exception
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
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub ulgTapers_before_InitializeRow(eventSender As Object, eventArgs As InitializeRowEventArgs)
			Dim row As UltraGridRow = eventArgs.Row
			Dim ultraGridCell As UltraGridCell = row.Cells("RodNum")
			ultraGridCell.Activation = Activation.Disabled
			ultraGridCell.Appearance.BackColor = SystemColors.Control
			Dim ultraGridCell2 As UltraGridCell = row.Cells("RodGrade")
			ultraGridCell2.Activation = Activation.Disabled
			ultraGridCell2.Appearance.BackColor = SystemColors.Control
			Dim ultraGridCell3 As UltraGridCell = row.Cells("RodSize")
			ultraGridCell3.Activation = Activation.Disabled
			ultraGridCell3.Appearance.BackColor = SystemColors.Control
			Dim ultraGridCell4 As UltraGridCell = row.Cells("RodDiam")
			ultraGridCell4.Activation = Activation.Disabled
			ultraGridCell4.Appearance.BackColor = SystemColors.Control
			Dim ultraGridCell5 As UltraGridCell = row.Cells("RodLength")
			ultraGridCell5.Activation = Activation.Disabled
			ultraGridCell5.Appearance.BackColor = SystemColors.Control
			Dim ultraGridCell6 As UltraGridCell = row.Cells("RodGuide")
			ultraGridCell6.Activation = Activation.Disabled
			ultraGridCell6.Appearance.BackColor = SystemColors.Control
			Dim ultraGridCell7 As UltraGridCell = row.Cells("RodFrictionCoef")
			ultraGridCell7.Activation = Activation.Disabled
			ultraGridCell7.Appearance.BackColor = SystemColors.Control
			If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
				Dim ultraGridCell8 As UltraGridCell = row.Cells("NumGuides")
				ultraGridCell8.Activation = Activation.Disabled
				ultraGridCell8.Appearance.BackColor = SystemColors.Control
			End If
			Dim ultraGridCell9 As UltraGridCell = row.Cells("RodGrade")
			Dim num As Integer
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridCell9.Value)) Then
				num = Conversions.ToInteger(ultraGridCell9.Value)
			End If
			ultraGridCell9.Activation = Activation.Disabled
			ultraGridCell9.Appearance.BackColor = SystemColors.Control
			Dim ultraGridCell10 As UltraGridCell = row.Cells("RodSize")
			If num <> 0 Then
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridCell10.Value)) Then
					Dim num2 As Integer = Conversions.ToInteger(ultraGridCell10.Value)
				End If
			End If
			ultraGridCell10.Activation = Activation.Disabled
			ultraGridCell10.Appearance.BackColor = SystemColors.Control
			Dim ultraGridCell11 As UltraGridCell = row.Cells("RodDiam")
			ultraGridCell11.Activation = Activation.Disabled
			ultraGridCell11.Appearance.BackColor = SystemColors.Control
		End Sub

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
				Dim dataRow As DataRow
				If RodGrade >= CType(0, StdInfoConstants.RodGradeConstants) Then
					Dim num3 As Integer
					If RodGrade = CType(0, StdInfoConstants.RodGradeConstants) Then
						num = 0
						Dim rodGuideName As String = Me.GetRodGuideName(RodGuide)
						iNumGuides = 0S
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
						Dim rodGuideName As String = Me.GetRodGuideName(RodGuide)
					End If
					dataRow = Me.mdsRodTapers.Tables(0).NewRow()
					num3 = CInt(RodGrade)
					dataRow("RodNum") = RodNum
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
					dataRow("RodGuide") = RodGuide
					If RodFrictionCoef = -1F Then
						dataRow("RodFrictionCoef") = DBNull.Value
					ElseIf RodFrictionCoef = 0F Then
						dataRow("RodFrictionCoef") = 0.2
					Else
						dataRow("RodFrictionCoef") = RodFrictionCoef
					End If
					dataRow("NumGuides") = iNumGuides
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
					Dim ulgTapers_before As UltraGrid = Me.ulgTapers_before
					ulgTapers_before.DataSource = Nothing
					ulgTapers_before.DataSource = Me.mdsRodTapers
					ulgTapers_before.Rows.Refresh(RefreshRow.RefreshDisplay, True)
				Else
					Me.mdsRodTapers.Tables(0).Rows.Add(dataRow)
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub AddRodTaper_before(RodNum As Integer, RodGrade As StdInfoConstants.RodGradeConstants, RodSize As Single, RodLength As Single, Optional RodFrictionCoef As Single = 0.2F, Optional RodGuide As Short = 0S, Optional iNumGuides As Integer = 0, Optional bInsert As Boolean = False, Optional iInsertPoint As Integer = 0, Optional bConvert As Boolean = True)
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
				Dim dataRow As DataRow
				If RodGrade >= CType(0, StdInfoConstants.RodGradeConstants) Then
					Dim num3 As Integer
					If RodGrade = CType(0, StdInfoConstants.RodGradeConstants) Then
						num = 0
						Dim rodGuideName As String = Me.GetRodGuideName(RodGuide)
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
						Dim rodGuideName As String = Me.GetRodGuideName(RodGuide)
					End If
					dataRow = Me.mdsRodTapers.Tables(0).NewRow()
					num3 = CInt(RodGrade)
					dataRow("RodNum") = RodNum
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
					dataRow("RodGuide") = RodGuide
					If RSWIN_DESC.SETUP_ALLOWSLIDEFRIC <> 0S Then
						If RodFrictionCoef = -1F Then
							dataRow("RodFrictionCoef") = DBNull.Value
						ElseIf RodFrictionCoef = 0F Then
							dataRow("RodFrictionCoef") = 0.2
						Else
							dataRow("RodFrictionCoef") = RodFrictionCoef
						End If
					End If
					If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
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
					Dim ulgTapers_before As UltraGrid = Me.ulgTapers_before
					ulgTapers_before.DataSource = Nothing
					ulgTapers_before.DataSource = Me.mdsRodTapers
					ulgTapers_before.Rows.Refresh(RefreshRow.RefreshDisplay, True)
				Else
					Me.mdsRodTapers.Tables(0).Rows.Add(dataRow)
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub CreateDataSet(bAfter As Boolean)
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
			Dim dataColumn6 As DataColumn = New DataColumn("RodGuide", GetType(Short))
			dataColumn6.AllowDBNull = True
			dataTable.Columns.Add(dataColumn6)
			Dim dataColumn7 As DataColumn = New DataColumn("RodFrictionCoef", GetType(Single))
			dataColumn7.AllowDBNull = True
			dataTable.Columns.Add(dataColumn7)
			If bAfter Or Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
				Dim dataColumn8 As DataColumn = New DataColumn("NumGuides", GetType(Short))
				dataColumn8.AllowDBNull = True
				dataTable.Columns.Add(dataColumn8)
			End If
			Me.mdsRodTapers.Tables.Add(dataTable)
		End Sub

		Private Sub Load_Form(bAfter As Boolean)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num As Short = 1S
				Dim numRods As Short = rst.NumRods
				For num2 As Short = num To numRods
					Dim sections As RSWIN_DESC.RodSection() = rst.Sections
					Dim num3 As Integer = CInt(num2)
					If CUSTOMRG.IsOtherSteel(CInt(sections(num3).Grade)) Or CUSTOMRG.IsOtherFG(CInt(sections(num3).Grade)) Then
						If Operators.CompareString(sections(num3).RodType.Trim(), "", False) = 0 And sections(num3).Grade <> 0S Then
							sections(num3).RodType = Conversions.ToString(RODUTIL.GetCustomRodTypeName(sections(num3).Grade))
						End If
						If Operators.CompareString(sections(num3).RodType.Trim(), "", False) <> 0 Then
							Dim num4 As Integer = Me.FindCustomRodGrade(sections(num3).RodType)
							If num4 <> -1 Then
								' The following expression was wrapped in a checked-expression
								sections(num3).Grade = CShort(num4)
							End If
						End If
					End If
					If bAfter Then
						Me.AddRodTaper(CInt(num2), CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants), sections(num3).Diameter, sections(num3).length, sections(num3).friction_coef, sections(num3).Guide, sections(num3).NumGuides, False, 0, True)
					ElseIf Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
						Me.AddRodTaper_before(CInt(num2), CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants), sections(num3).Diameter, sections(num3).length, sections(num3).friction_coef, sections(num3).Guide, CInt(sections(num3).NumGuides), False, 0, True)
					Else
						Me.AddRodTaper_before(CInt(num2), CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants), sections(num3).Diameter, sections(num3).length, sections(num3).friction_coef, sections(num3).Guide, 0, False, 0, True)
					End If
				Next
				If bAfter Then
					Dim ultraGrid As UltraGrid
					If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
						ultraGrid = Me.ulgTapers
						CtrlUI.Grid_ToggleUnits(ultraGrid, -1S, -1S, "")
						Me.ulgTapers = ultraGrid
					End If
					ultraGrid = Me.ulgTapers
					CtrlUI.Grid_SetLabels(ultraGrid, True)
					Me.ulgTapers = ultraGrid
					Me.ulgTapers.BringToFront()
					Me.ulgTapers.Visible = True
				Else
					Dim ultraGrid As UltraGrid
					If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
						ultraGrid = Me.ulgTapers_before
						CtrlUI.Grid_ToggleUnits(ultraGrid, -1S, -1S, "")
						Me.ulgTapers_before = ultraGrid
					End If
					ultraGrid = Me.ulgTapers_before
					CtrlUI.Grid_SetLabels(ultraGrid, True)
					Me.ulgTapers_before = ultraGrid
					Me.ulgTapers_before.BringToFront()
					Me.ulgTapers_before.Visible = True
				End If
			Catch ex As Exception
				Dim message As String = ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(message, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub CreateValueLists(ByRef ulgTapers As UltraGrid, bAfter As Boolean)
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Dim array As Integer() = New Integer(6) {}
			Dim array2 As Integer() = New Integer(6) {}
			Try
				If bAfter Then
					Me.bValueListsCreated = True
				End If
				If Not ulgTapers.DisplayLayout.ValueLists.Exists("VLRodGrades") Then
					Dim valueLists As ValueListsCollection = ulgTapers.DisplayLayout.ValueLists
					Me.vlrg = valueLists.Add("VLRodGrades")
					Me.vlrs = valueLists.Add("VLRodSizes")
					Me.vlrt = valueLists.Add("VLRodTypes")
					Me.vlswg = valueLists.Add("VLSWGuides")
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
											Dim text As String = displayText2
											If Operators.CompareString(text, "Steel", False) = 0 Then
												num6 -= 1
											ElseIf Operators.CompareString(text, "Sinker bars", False) = 0 Then
												num6 += 3
											ElseIf Operators.CompareString(text, "Fiberglass", False) = 0 Then
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
											Dim text2 As String = New String(" "c, num6)
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
					Dim comparer As dlgImplementGuideChanges.rgaComparer = New dlgImplementGuideChanges.rgaComparer()
					Me.myRodTypeGradeAL.Sort(comparer)
					If Not bAfter Then
						Me.cboRodGrade.Items.Clear()
						Me.cboRodGrade.DataSource = Nothing
						Me.cboRodGrade.DataSource = Me.myRodTypeGradeAL
						Me.cboRodGrade.DisplayMember = "DisplayName"
						Me.cboRodGrade.ValueMember = "RodGradeID"
					End If
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
						If Not bAfter Then
							Me.cboRodGuides.Items.Clear()
							Me.cboRodGuides.DataSource = Nothing
							Me.cboRodGuides.DataSource = Me.myRodGuideAL
							Me.cboRodGuides.DisplayMember = "DisplayName"
							Me.cboRodGuides.ValueMember = "RodGuideID"
						End If
					Catch ex5 As Exception
					End Try
				End If
			Catch ex6 As Exception
				Dim sMsg As String = "Error in Create Value Lists: " + ex6.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub cmdOK_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			RSWIN_DESC.rst.RodStringType = RSWIN_DESC.SaveRodStringType
			Me.lblStatus.Text = ""
			Dim flag2 As Boolean = cImplementGuideChanges.CheckImplementationChanges(flag)
			Me.m_bKeep = False
			If Me.bImplementChosen AndAlso flag2 Then
				Dim obj As Object = MessageBox.Show("Keep implementation changes made to the rod string? (Note: Undoing the implementation may take up to a minute.)", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				If Operators.ConditionalCompareObjectEqual(obj, DialogResult.Yes, False) Then
					Me.m_bKeep = True
					If Not flag Then
						RSWIN_DESC.SETUP_RECOMMEND_GUIDES = False
						Try
							Dim text As String = "RecommendGuides"
							Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_RECOMMEND_GUIDES)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_RECOMMEND_GUIDES = Conversions.ToBoolean(text2)
						Catch ex As Exception
						End Try
						RSWIN_DESC.rst.RodStringType = 2S
					End If
				Else
					Me.btnUndoImplement.PerformClick()
					RSWIN_DESC.rst.bImplementedDesign = False
				End If
			End If
			Me.m_bAccept = False
			RSWIN_DESC.bSuppressWarningMessages_Override = False
			Me.Close()
		End Sub

		Private Sub btnImplement_Click(sender As Object, e As EventArgs)
			Try
				Me.btnImplement.Enabled = False
				Me.btnUndoImplement.Enabled = False
				Me.btnAccept.Enabled = False
				Me.cmdCancel.Enabled = False
				Me.DoExecuteImplementation()
				Me.btnAccept.Enabled = True
				Me.cmdCancel.Enabled = True
			Catch ex As Exception
			End Try
		End Sub

		Public Sub DoExecuteImplementation()
			' The following expression was wrapped in a checked-statement
			Try
				Try
					Me.rptRecommendedGuideReport = Nothing
				Catch ex As Exception
				End Try
				Util.BusyCursor()
				SUPERPRO.NewCheckSentinel(True)
				Me.bImplementChosen = True
				Me.lblStatus.Text = "  Implementing Rod Guide recommendations. Please wait!"
				Me.lblMaximum.Text = ""
				Me.lblMinimum.Text = ""
				RSWIN_DESC.bRestartImplementation = False
				Me.iOrigNumRods = CInt(RSWIN_DESC.rst.NumRods)
				cImplementGuideChanges.iOrigNumRods = Me.iOrigNumRods
				cImplementGuideChanges.ExecuteImplementation()
				If RSWIN_DESC.bRestartImplementation Then
					cImplementGuideChanges.UndoGuideImplementation()
					cImplementGuideChanges.ExecuteImplementation()
				End If
				Me.lblMaximum.Text = cImplementGuideChanges.sMaximum
				Me.lblMinimum.Text = cImplementGuideChanges.sMinimum
				Try
					Me.ulgTapers_before.DataSource = Nothing
					Me.mdsRodTapers = Nothing
					Me.CreateDataSet(True)
					If Not Me.bValueListsCreated Then
						Dim ulgTapers As UltraGrid = Me.ulgTapers
						Me.CreateValueLists(ulgTapers, True)
						Me.ulgTapers = ulgTapers
					End If
					Me.Load_Form(True)
					Dim ulgTapers2 As UltraGrid = Me.ulgTapers
					ulgTapers2.DataSource = Me.mdsRodTapers
					ulgTapers2.Rows.Refresh(RefreshRow.FireInitializeRow, True)
					Dim row As UltraGridRow = ulgTapers2.GetRow(ChildRow.First)
					If row IsNot Nothing Then
						ulgTapers2.ActiveRow = row
					End If
					Try
						Me.SetStringLengthFromGrid()
					Catch ex2 As Exception
					End Try
					RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
					Me.fDepths = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
					Try
						Me.fDepths(0) = 0F
						RSWIN_DESC.taper_lens(0) = 0F
						Dim num As Integer = 1
						Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num To numRods
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							Me.fDepths(i) = Me.fDepths(i - 1) + RSWIN_DESC.rst.Sections(i).length
							RSWIN_DESC.taper_lens(i) = Me.fDepths(i)
						Next
					Catch ex3 As Exception
					End Try
					Util.UnbusyCursor()
				Catch ex4 As Exception
					Util.UnbusyCursor()
				End Try
				Try
					Dim num2 As Integer
					Dim flag As Boolean
					Dim text As String
					Dim flag2 As Boolean
					Dim text2 As String
					Dim text3 As String
					MImpred.InitSummaryReportXML(num2, flag, text, flag2, text2, text3)
					Util.BusyCursor()
					Application.DoEvents()
					If RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
						Me.rptRecommendedGuideReport = New rptRecommendedGuideReport()
					Else
						Me.rptRecommendedGuideReport = New rptRecommendedGuideReport2()
					End If
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bPrint", New Object() { False }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bMaxFootnote", New Object() { flag2 }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sMaxFootnote", New Object() { text2 }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bMinFootnote", New Object() { flag }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sMinFootnote", New Object() { text }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sGuideMsg", New Object() { text3 }, Nothing, Nothing)
					Try
						Dim xmldataSource As XMLDataSource = New XMLDataSource()
						xmldataSource.LoadXML(RSWIN_DESC.sSummaryDataSetXML)
						NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object() { xmldataSource }, Nothing, Nothing)
						NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "DataSource", New Object() { xmldataSource }, Nothing, Nothing)
					Catch ex5 As Exception
					End Try
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "ValidateOnParse", New Object() { True }, Nothing, Nothing, False, True)
					CType(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), XMLDataSource).RecordsetPattern = "//Data/Entries/Row"
					Dim number_Of_Guide_report_Pages As Integer = RSWIN_DESC.rst.Number_Of_Guide_report_Pages
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "TotalPageNumber", New Object() { number_Of_Guide_report_Pages }, Nothing, Nothing)
					Dim num3 As Integer
					num3 += 1
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "ThisPageNumber", New Object() { num3 }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "NumberOfLines", New Object() { num2 }, Nothing, Nothing)
					NewLateBinding.LateCall(Me.rptRecommendedGuideReport, Nothing, "Run", New Object() { False }, Nothing, Nothing, Nothing, True)
					Me.Viewer1.Document = Nothing
					Me.Viewer1.Document = CType(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Document)
				Catch ex6 As Exception
				End Try
				Me.cmdAddSection.Enabled = True
				Me.cmdDelSection.Enabled = True
				Me.cmdMoveSectionUp.Enabled = True
				Me.cmdMoveSectionDown.Enabled = True
				Me.cmdAddSection.Visible = True
				Me.cmdDelSection.Visible = True
				Me.cmdMoveSectionUp.Visible = True
				Me.cmdMoveSectionDown.Visible = True
				Me.btnImplement.Enabled = False
				Me.btnUndoImplement.Enabled = True
				Me.btnAccept.Enabled = True
				Me.lblStatus.ForeColor = Color.Black
				Me.lblStatus.Text = "  Done!"
			Catch ex7 As Exception
			End Try
		End Sub

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
						ElseIf(RODUTIL.IsSteel(CInt(grade)) Or If((-If((CUSTOMRG.IsOtherSteel(CInt(grade)) > False), 1, 0)), 1, 0)) <> 0 Then
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
				Me.bInsideUpdateRS = False
			Catch ex As Exception
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

		Private Function ValidateRSInput(Optional bQuiet As Boolean = True, Optional bCallFromMain As Boolean = False) As Boolean
			Dim flag As Boolean = False
			Dim num As Single = 0F
			Dim result As Boolean
			Try
				Dim flag2 As Boolean = True
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				cRODSTAR.NumRods = CShort(Me.mdsRodTapers.Tables(0).Rows.Count)
				Try
					For Each obj As Object In Me.mdsRodTapers.Tables(0).Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						Dim num2 As Integer = Conversions.ToInteger(dataRow("RodNum"))
						Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
						Dim num3 As Integer = num2
						Try
							sections(num3).Grade = Conversions.ToShort(dataRow("RodGrade"))
							Try
								If Not CUSTOMRG.IsOtherSteel(CInt(sections(num3).Grade)) And Not CUSTOMRG.IsOtherFG(CInt(sections(num3).Grade)) And Not CUSTOMRG.IsOtherSinkerBar(CInt(sections(num3).Grade)) Then
									sections(num3).RodType = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants)).Name
									sections(num3).TensileStrength = Conversions.ToSingle(RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(sections(num3).Grade, StdInfoConstants.RodGradeConstants)).TensileStrength)
								Else
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
									Catch ex As Exception
									End Try
								End If
							Catch ex2 As Exception
							End Try
							Dim num8 As Single = Conversions.ToSingle(Convert.ToString(RuntimeHelpers.GetObjectValue(dataRow("RodDiam"))))
							If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								CtrlUI.ConvertValue(num8, "m", True)
							End If
							sections(num3).Diameter = num8
							sections(num3).Area = CSng((CDbl((sections(num3).Diameter * sections(num3).Diameter)) * Math.Atan(1.0)))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("RodLength"))) And Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(dataRow("RodLength"))) Then
								num8 = Conversions.ToSingle(dataRow("RodLength"))
								If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
									CtrlUI.ConvertValue(num8, "f", True)
								End If
								sections(num3).length = num8
								Dim text As String = Conversions.ToString(Operators.ConcatenateObject("RodLength", dataRow("RodNum")))
								ini.SaveDataValue(text.Trim(), num8)
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
							Catch ex3 As Exception
							End Try
						Catch ex4 As Exception
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
							GoTo IL_573
						End If
						If flag3 = (sections(num3).Grade = 16389S) Then
							GoTo IL_573
						End If
						If flag3 = (sections(num3).Grade = 16390S) Then
							GoTo IL_573
						End If
						If flag3 = RODUTIL.IsCorod(sections(num3).Grade) Then
							sections(num3).SuckerRodLength = 1F
						Else
							sections(num3).SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
						End If
						IL_5C7:
						RODUTIL.LookupElasticity(RSWIN_DESC.rst.Sections(num2))
						RODUTIL.LookupRodWeight(RSWIN_DESC.rst.Sections(num2))
						RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(num2))
						num += RSWIN_DESC.rst.Sections(num2).length
						Continue For
						IL_573:
						sections(num3).SuckerRodLength = 37.5F
						GoTo IL_5C7
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If((Not bQuiet And True And Not Me.bLoadingCombo) AndAlso flag2) And num < RSWIN_DESC.rst.PumpDepth - 50F Then
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
				ElseIf((Not bQuiet And True And Not Me.bLoadingCombo) AndAlso flag2) And num > RSWIN_DESC.rst.PumpDepth + 1F Then
					flag2 = False
					Dim sMsg As String = " " + Me.sTotalDepth
					Me.DisplayRSInputError(sMsg, flag)
					If flag Then
						flag2 = True
					Else
						Me.bLengthError = True
					End If
				End If
				cRODSTAR = Nothing
				Me.bValidated = True
				result = flag2
			Catch ex5 As Exception
			End Try
			Return result
		End Function

		Private Sub SetActiveControl(ByRef myControl As Control)
			Try
				myControl.Focus()
				If Me.ActiveControl IsNot myControl Then
					Me.ActiveControl = myControl
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub DisplayRSInputError(sMsg As String, ByRef bCancel As Boolean)
			Try
				bCancel = False
				Dim sMsgType As String = "Data Entry Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboRodSize_Validating(eventSender As Object, eventArgs As CancelEventArgs)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim cancel As Boolean = eventArgs.Cancel
				IL_0A:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_11:
				num = 3
				Dim comboBox As ComboBox = Me.cboRodSize
				IL_1B:
				num = 4
				If Strings.Len(comboBox.Text) <= 0 Then
					GoTo IL_5E
				End If
				IL_2C:
				num = 5
				Me.ulgTapers.ActiveCell.Row.Cells("RodSize").Value = RuntimeHelpers.GetObjectValue(comboBox.SelectedValue)
				IL_5E:
				comboBox = Nothing
				IL_60:
				GoTo IL_D0
				IL_62:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_90:
				GoTo IL_C5
				IL_92:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_A3:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_92
			End Try
			IL_C5:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_D0:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub chkShowReport_CheckedChanged(sender As Object, e As EventArgs)
			If Not Me.chkShowReport.Checked Then
				Me.pnlViewReport.Visible = False
			Else
				Me.pnlViewReport.Visible = True
			End If
			SUPERPRO.NewCheckSentinel(True)
		End Sub

		Private Sub btnAccept_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Try
				If Not cImplementGuideChanges.CheckImplementationChanges(flag) Then
					MessageBox.Show("No rod guide implementation changes made. ReRun not necessary.")
					Me.m_bKeep = False
					Me.bImplementChosen = False
					RSWIN_DESC.bSuppressWarningMessages_Override = False
					Me.Close()
				Else
					If Not flag Then
						RSWIN_DESC.SETUP_RECOMMEND_GUIDES = False
						Try
							Dim text As String = "RecommendGuides"
							Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_RECOMMEND_GUIDES)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_RECOMMEND_GUIDES = Conversions.ToBoolean(text2)
						Catch ex As Exception
						End Try
						RSWIN_DESC.rst.RodStringType = 2S
					End If
					Try
						Dim num As Integer = 1
						Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num To numRods
							If RSWIN_DESC.rst.Sections(i).friction_coef = 0F Then
								RSWIN_DESC.rst.Sections(i).friction_coef = RODUTIL.GetFricCoeff(CInt(RSWIN_DESC.rst.Sections(i).Guide), True)
							End If
						Next
					Catch ex2 As Exception
					End Try
					Me.m_bAccept = True
					Me.Close()
				End If
				RSWIN_DESC.bSuppressWarningMessages_Override = False
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub btnUndoImplement_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Try
					Me.rptRecommendedGuideReport = Nothing
				Catch ex As Exception
				End Try
				Me.bImplementChosen = False
				RSWIN_DESC.rst.bImplementedDesign = False
				Me.btnImplement.Enabled = False
				Me.btnUndoImplement.Enabled = False
				Me.btnAccept.Enabled = False
				Me.cmdCancel.Enabled = False
				SUPERPRO.NewCheckSentinel(True)
				Me.lblStatus.ForeColor = Color.Black
				Me.lblStatus.Text = "  Undoing Rod Guide implementations. Please wait!"
				Try
					RSWIN_DESC.rst = RSWIN_DESC.saved_rst(0)
				Catch ex2 As Exception
				End Try
				Try
					MImpred.ImpredObj = RSWIN_DESC.saved_Impred(0)
				Catch ex3 As Exception
				End Try
				Util.BusyCursor()
				RSWIN_DESC.rst.NumRods = CShort(Me.iOrigNumRods)
				Try
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						RSWIN_DESC.rst.Sections(i) = RSWIN_DESC.SaveSections(i)
					Next
				Catch ex4 As Exception
				End Try
				RSWIN_DESC.SETUP_RECOMMEND_GUIDES = Me.SETUP_RECOMMEND_GUIDES_SAVE
				RSWIN_DESC.rst.RodStringType = 2S

					Try
						Application.DoEvents()
						Util.BusyCursor()
						Application.DoEvents()
						Dim flag As Boolean
						Try
							flag = PREDICT.Predict(True, "DesignUser")
						Catch ex5 As Exception
						End Try
						Try
							Dim moment As Single = RSWIN_DESC.rst.get_M(RSWIN_DESC.rst.iUnknownM)
							Dim rst As cRODSTAR = RSWIN_DESC.rst
							Dim permLoad As Single() = rst.PermLoad
							Torquebal.CalculatePL(moment, permLoad, RSWIN_DESC.rst.iUnknownM, flag)
							rst.PermLoad = permLoad
						Catch ex6 As Exception
						End Try
						If flag Then
							Try
								flag = MWDown.StressAnalysis()
								If flag Then
									Dim pumpPos As Single() = RSWIN_DESC.rst.PumpPos
									Dim num2 As Single = 0F
									Dim num3 As Single = 0F
									Dim num4 As Single
									Dim num5 As Single
									Util.Maxmin(pumpPos, num4, num5, num2, num3)
									RSWIN_DESC.rst.GrossPumpStroke = num4 - num5
									If(If((-If(((RSWIN_DESC.rst.BPDsurface = 0F Or Not RSWIN_DESC.bRodStarD) > False), 1S, 0S)), 1S, 0S) Or (If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.SETUP_UseImpred)) <> 0S Then
										RSWIN_DESC.rst.BPDsurface = RUNCALC.BPDsurf(RSWIN_DESC.rst.GrossPumpStroke - RSWIN_DESC.rst.TubStretch, RSWIN_DESC.rst.SPM, RSWIN_DESC.rst.PlungerSize, RSWIN_DESC.rst.Pfill) * RSWIN_DESC.rst.Runtime / 24F
										If RSWIN_DESC.rst.PumpCondition = 2S Or RSWIN_DESC.rst.PumpCondition = 3S Then
											RSWIN_DESC.rst.BPDsurface = RSWIN_DESC.rst.BPDsurface * RSWIN_DESC.rst.PumpEfficiency / 100F
										End If
									End If
									RSWIN_DESC.rst.ProductionLoss = RUNCALC.BPDsurf(RSWIN_DESC.rst.TubStretch, RSWIN_DESC.rst.SPM, RSWIN_DESC.rst.PlungerSize, RSWIN_DESC.rst.Pfill) * RSWIN_DESC.rst.Runtime / 24F
								End If
							Catch ex7 As Exception
							End Try
						End If
					Catch ex8 As Exception
					End Try
					RSWIN_DESC.rst.RodStringType = RSWIN_DESC.SaveRodStringType
					Me.m_bAccept = False
					Me.btnUndoImplement.Enabled = False
					Me.btnImplement.Enabled = True
					Me.btnAccept.Enabled = False

				Try
					RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
					RSWIN_DESC.taper_lens(0) = 0F
					Dim num6 As Integer = 1
					Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num6 To numRods2
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						RSWIN_DESC.taper_lens(i) = RSWIN_DESC.taper_lens(i - 1) + RSWIN_DESC.rst.Sections(i).length
					Next
				Catch ex9 As Exception
				End Try
				Try
					Dim num7 As Integer
					Dim flag2 As Boolean
					Dim text As String
					Dim flag3 As Boolean
					Dim text2 As String
					Dim text3 As String
					MImpred.InitSummaryReportXML(num7, flag2, text, flag3, text2, text3)
					Util.BusyCursor()
					Application.DoEvents()
					If RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
						Me.rptRecommendedGuideReport = New rptRecommendedGuideReport()
					Else
						Me.rptRecommendedGuideReport = New rptRecommendedGuideReport2()
					End If
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bPrint", New Object() { False }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bMaxFootnote", New Object() { flag3 }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sMaxFootnote", New Object() { text2 }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "bMinFootnote", New Object() { flag2 }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sMinFootnote", New Object() { text }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "sGuideMsg", New Object() { text3 }, Nothing, Nothing)
					Try
						Dim xmldataSource As XMLDataSource = New XMLDataSource()
						xmldataSource.LoadXML(RSWIN_DESC.sSummaryDataSetXML)
						NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object() { xmldataSource }, Nothing, Nothing)
						NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "DataSource", New Object() { xmldataSource }, Nothing, Nothing)
					Catch ex10 As Exception
					End Try
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "ValidateOnParse", New Object() { True }, Nothing, Nothing, False, True)
					CType(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), XMLDataSource).RecordsetPattern = "//Data/Entries/Row"
					Dim number_Of_Guide_report_Pages As Integer = RSWIN_DESC.rst.Number_Of_Guide_report_Pages
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "TotalPageNumber", New Object() { number_Of_Guide_report_Pages }, Nothing, Nothing)
					Dim num8 As Integer
					num8 += 1
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "ThisPageNumber", New Object() { num8 }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.rptRecommendedGuideReport, Nothing, "NumberOfLines", New Object() { num7 }, Nothing, Nothing)
					NewLateBinding.LateCall(Me.rptRecommendedGuideReport, Nothing, "Run", New Object() { False }, Nothing, Nothing, Nothing, True)
					Me.Viewer1.Document = Nothing
					Me.Viewer1.Document = CType(NewLateBinding.LateGet(Me.rptRecommendedGuideReport, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Document)
				Catch ex11 As Exception
				End Try
				Me.FormLoad()
				Util.UnbusyCursor()
				Me.m_bAccept = False
				Me.lblStatus.ForeColor = Color.Black
				Me.lblStatus.Text = "  Done!"
				Me.cmdCancel.Enabled = True
			Catch ex12 As Exception
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
						Dim array As dlgImplementGuideChanges.RodSizeArray()
						Try
							For Each obj3 As Object In teRodSizeList
								Dim teRodSize As teRodSize = CType(If((obj3 IsNot Nothing), CType(obj3, DictionaryEntry), dictionaryEntry).Value, teRodSize)
								If Not(LikeOperator.LikeString(teRodSize.DisplayName, "(Custom *)", CompareMethod.Binary) Or LikeOperator.LikeString(teRodSize.DisplayName, "(Unknown *)", CompareMethod.Binary)) Then
									i += 1
									array = CType(Utils.CopyArray(CType(array, Array), New dlgImplementGuideChanges.RodSizeArray(i + 1 - 1) {}), dlgImplementGuideChanges.RodSizeArray())
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
							array = CType(Utils.CopyArray(CType(array, Array), New dlgImplementGuideChanges.RodSizeArray(i + 1 - 1) {}), dlgImplementGuideChanges.RodSizeArray())
							array(i).rsaRodSizeID = 0
							array(i).rsaDisplayName = "Other"
							array(i).rsaDiameter = 0F
						End If
						Dim comparer As dlgImplementGuideChanges.rsaComparer = New dlgImplementGuideChanges.rsaComparer()
						Array.Sort(array, comparer)
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
					Me.ulgTapers.ActiveCell.Row.Cells("RodGrade").Value = RuntimeHelpers.GetObjectValue(cboRodGrade.SelectedValue)
				End If
			Catch ex As Exception
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
			Try
				If Not Me.ulgTapers.DisplayLayout.ValueLists.Exists("VLRodGrades") Then
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
											Dim text As String = displayText2
											If Operators.CompareString(text, "Steel", False) = 0 Then
												num6 -= 1
											ElseIf Operators.CompareString(text, "Sinker bars", False) = 0 Then
												num6 += 3
											ElseIf Operators.CompareString(text, "Fiberglass", False) = 0 Then
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
											Dim text2 As String = New String(" "c, num6)
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
					Dim comparer As dlgImplementGuideChanges.rgaComparer = New dlgImplementGuideChanges.rgaComparer()
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

		Private Sub ResortGrid()
			Try
				Dim ultraGridBand As UltraGridBand = Me.ulgTapers.DisplayLayout.Bands(0)
				ultraGridBand.SortedColumns.Clear()
				ultraGridBand.SortedColumns.Add(ultraGridBand.Columns("RodNum"), False)
			Catch ex As Exception
			End Try
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
					Else
						If Operators.CompareString(key, "RodFrictionCoef", False) = 0 Then
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
									Dim num9 As Single
									If Util.IsPolyLined(RSWIN_DESC.rst.TubingID) And RSWIN_DESC.bReduceFricCoeff Then
										num9 = 0.1F
									Else
										num9 = 0.2F
									End If
									sections3(num8).friction_coef = num9
								End If
								ini.SaveDataValue("RODFrictionCoef" + eventArgs.Cell.Row.Cells("RodNum").Value.ToString(), sections3(num8).friction_coef)
								GoTo IL_ED5
							Catch ex5 As Exception
								GoTo IL_ED5
							End Try
						End If
						If Operators.CompareString(key, "RodGuide", False) = 0 Then
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
						ElseIf Operators.CompareString(key, "NumGuides", False) = 0 Then
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
					End If
					IL_ED5:
					If Me.ActiveControl Is Me.ulgTapers Then
						Me.ValidateRSInput(Me.bFormLoaded, True)
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
					Catch ex As Exception
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
								ini.SaveDataValue("RODFrictionCoef" + eventArgs.Cell.Row.Cells("RodNum").Value.ToString(), sections3(num7).friction_coef)
								If sections3(num7).Guide > 0S Then
									Dim fricCoeff As Single = RODUTIL.GetFricCoeff(CInt(sections3(num7).Guide), True)
									If fricCoeff <> sections3(num7).friction_coef And Me.bFormLoaded Then
										Interaction.Beep()
										Me.lblStatus.ForeColor = Color.FromArgb(192, 0, 0)
										Me.lblStatus.Text = String.Concat(New String() { "The drag friction coefficient you entered (", Conversions.ToString(sections3(num7).friction_coef), ") is different than the one you entered in Setup for this type of rod guide (", Conversions.ToString(fricCoeff), ")." })
									End If
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
							Catch ex2 As Exception
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
							Catch ex3 As Exception
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
								Me.ValidateRSInput(Me.bFormLoaded, True)
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
				ElseIf Operators.CompareString(key, "NumGuides", False) = 0 Then
					Dim ultraGridCell2 As UltraGridCell = eventArgs.Cell
					Dim num10 As Short = Conversions.ToShort(ultraGridCell2.Value)
					Try
						If CDbl(num10) <> Conversion.Val(ultraGridCell2.Text) Then
							num10 = CShort(Math.Round(Conversion.Val(ultraGridCell2.Text)))
						End If
					Catch ex4 As Exception
					End Try
					ultraGridCell2.Tag = Nothing
					Dim num2 As Long = Conversions.ToLong(ultraGridCell2.Row.Cells("RodNum").Value)
					ini.SaveDataValue("NumGuides" + num2.ToString(), RuntimeHelpers.GetObjectValue(ultraGridCell2.Value))
					Dim sections5 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
					Dim num11 As Integer = CInt(num2)
					sections5(num11).NumGuides = num10
					ultraGridCell2 = Nothing
				End If
			Catch ex5 As Exception
			End Try
		End Sub

		Private Sub ulgTapers_AfterRowActivate(eventSender As Object, eventArgs As EventArgs)
			Me.UpdateUI()
		End Sub

		Private Sub ulgTapers_AfterRowUpdate(sender As Object, e As RowEventArgs)
			Try
				Dim activeRow As UltraGridRow = Me.ulgTapers.ActiveRow
				Dim num As Integer = Conversions.ToInteger(activeRow.Cells("RodNum").Value)
				Me.ValidateRSInput(Me.bFormLoaded, True)
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
				Me.ValidateRSInput(Me.bFormLoaded, True)
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
				Me.ValidateRSInput(Me.bFormLoaded, True)
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
				RSWIN_DESC.iCurrentRodNum = Conversions.ToInteger(activeCell.Row.Cells("RodNum").Value)
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
								If Not Me.BeforeEditRodgrade() Then
									MessageBox.Show("Please select Rod Type before Rod Grade.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Else
									Me.cboRodGrade.SetBounds(x, y, width, height)
									Me.cboRodGrade.Visible = True
									Dim control As Control = Me.cboRodGrade
									Me.SetActiveControl(control)
									Me.cboRodGrade = CType(control, ComboBox)
								End If
							ElseIf Operators.CompareString(activeCell.Column.Key, "RodSize", False) = 0 Then
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
							ElseIf Operators.CompareString(activeCell.Column.Key, "RodLength", False) <> 0 Then
								If Operators.CompareString(activeCell.Column.Key, "RodFrictionCoef", False) = 0 Then
									Dim row As UltraGridRow = activeCell.Row
									Dim iRow As Integer = Conversions.ToInteger(row.Cells("RodNum").Value)
									Dim num As Integer = Conversions.ToInteger(row.Cells("RodGuide").Value)
									Dim num2 As Single = Conversions.ToSingle(row.Cells("RodFrictionCoef").Value)
									If num > 0 Then
										Dim fricCoeff As Single = RODUTIL.GetFricCoeff(num, True)
										If num2 <> fricCoeff And Me.bFormLoaded Then
											Interaction.Beep()
											Me.lblStatus.ForeColor = Color.FromArgb(192, 0, 0)
											Me.lblStatus.Text = String.Concat(New String() { "The drag friction coefficient you entered (", Conversions.ToString(num2), ") is different than the one you entered in Setup for this type of rod guide (", Conversions.ToString(fricCoeff), ")." })
										End If
									End If
								End If
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
			' The following expression was wrapped in a checked-statement
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
					If Strings.InStr(Conversions.ToString(caption), "Length", CompareMethod.Binary) <= 0 Then
						If Strings.InStr(Conversions.ToString(caption), "Rod Grade", CompareMethod.Binary) > 0 Then
							Application.DoEvents()
						ElseIf Strings.InStr(Conversions.ToString(caption), "Rod Size", CompareMethod.Binary) > 0 Then
							Application.DoEvents()
						ElseIf Strings.InStr(Conversions.ToString(caption), "Rod Type", CompareMethod.Binary) > 0 Then
							Application.DoEvents()
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_InitializeLayout(eventSender As Object, eventArgs As InitializeLayoutEventArgs)
			Try
				Dim layout As UltraGridLayout = eventArgs.Layout
				layout.TabNavigation = TabNavigation.NextCell
				Dim ultraGridBand As UltraGridBand = layout.Bands(0)
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns("RodNum")
				ultraGridColumn.Header.Caption = "#"
				ultraGridColumn.Width = 28
				ultraGridColumn.Tag = ""
				Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns("RodGrade")
				ultraGridColumn2.Header.Caption = Me.sRodGrade
				ultraGridColumn2.ValueList = Me.ulgTapers.DisplayLayout.ValueLists("VLRodGrades")
				ultraGridColumn2.Width = 233
				ultraGridColumn2.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn2.Tag = ""
				ultraGridColumn2.Header.Fixed = True
				Dim ultraGridColumn3 As UltraGridColumn = ultraGridBand.Columns("RodSize")
				ultraGridColumn3.Header.Caption = Me.sRodSize + " (" + RSWIN_DESC.inch + ")"
				ultraGridColumn3.Width = 158
				ultraGridColumn3.ValueList = Me.ulgTapers.DisplayLayout.ValueLists("VLRodSizes")
				ultraGridColumn3.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn3.Tag = ""
				Dim ultraGridColumn4 As UltraGridColumn = ultraGridBand.Columns("RodDiam")
				ultraGridColumn4.Header.Caption = Me.sActualRodDiameter
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					ultraGridColumn4.Header.Caption = Me.sActualRodDiameter + " (" + RSWIN_DESC.inch + ")"
				ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					ultraGridColumn4.Header.Caption = Me.sActualRodDiameter + " (" + RSWIN_DESC.mm + ")"
				End If
				ultraGridColumn4.Width = 113
				ultraGridColumn4.Tag = ""
				Dim ultraGridColumn5 As UltraGridColumn = ultraGridBand.Columns("RodLength")
				ultraGridColumn5.Width = 88
				ultraGridColumn5.Header.Caption = Me.sRodLength
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					ultraGridColumn5.Header.Caption = Me.sRodLength + " (" + RSWIN_DESC.ft + ")"
				ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					ultraGridColumn5.Header.Caption = Me.sRodLength + " (" + RSWIN_DESC.m + ")"
				End If
				ultraGridColumn5.Tag = "Length (^)" & vbLf & "fem"
				If RSWIN_DESC.bRodStarD Then
					If Me.bShowGuides Then
						Dim ultraGridColumn6 As UltraGridColumn = ultraGridBand.Columns("RodGuide")
						ultraGridColumn6.Header.Caption = "Guide"
						ultraGridColumn6.ValueList = Me.ulgTapers.DisplayLayout.ValueLists("VLSWGuides")
						ultraGridColumn6.Width = 158
						ultraGridColumn6.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
						ultraGridColumn6.Tag = ""
					End If
					If RSWIN_DESC.SETUP_ALLOWSLIDEFRIC <> 0S Then
						Dim ultraGridColumn7 As UltraGridColumn = ultraGridBand.Columns("RodFrictionCoef")
						ultraGridColumn7.Width = 88
						ultraGridColumn7.Header.Caption = "* Fric Coeff"
						ultraGridColumn7.Tag = "Fric Coeff"
					End If
					Dim ultraGridColumn8 As UltraGridColumn = ultraGridBand.Columns("NumGuides")
					ultraGridColumn8.Header.Caption = Me.sNumGuides
					ultraGridColumn8.Width = 98
					ultraGridColumn8.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
					ultraGridColumn8.Tag = ""
				End If
				Dim ultraGrid As UltraGrid = Me.ulgTapers
				Try
					ultraGrid.ActiveRow = ultraGrid.GetRow(ChildRow.First)
				Catch ex As Exception
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
			Catch ex2 As Exception
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
				Me.cmdAddSection.Enabled = True
				Me.cmdDelSection.Enabled = True
				Me.cmdMoveSectionUp.Enabled = True
				Me.cmdMoveSectionDown.Enabled = True
				Me.cmdAddSection.Visible = True
				Me.cmdDelSection.Visible = True
				Me.cmdMoveSectionUp.Visible = True
				Me.cmdMoveSectionDown.Visible = True
				Me.m_iCurrentRodSection = iCurrentRodSection
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
				Me.cmdAddSection.Enabled = True
				Me.cmdDelSection.Enabled = True
				Me.cmdMoveSectionUp.Enabled = True
				Me.cmdMoveSectionDown.Enabled = True
				Me.cmdAddSection.Visible = True
				Me.cmdDelSection.Visible = True
				Me.cmdMoveSectionUp.Visible = True
				Me.cmdMoveSectionDown.Visible = True
				Me.m_iCurrentRodSection = iCurrentRodSection
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTapers_InitializeRow(eventSender As Object, eventArgs As InitializeRowEventArgs)
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
				Catch ex As Exception
				End Try
			End If
		End Sub

		Private Sub ulgTapers_MouseDownEvent(eventSender As Object, e As MouseEventArgs)
			Try
				Me.mfMouseDownX = CSng(e.X)
				Me.mfMouseDownY = CSng(e.Y)
				If e.Button = MouseButtons.Left Then
					Me.mousePoint = New Point(e.X, e.Y)
				End If
				If e.Button = MouseButtons.Right Then
				End If
			Catch ex As Exception
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
						If ulgTapers.ActiveRow Is Nothing AndAlso (RSWIN_DESC.iCurrentRodNum > 0 And RSWIN_DESC.iCurrentRodNum <= CInt(RSWIN_DESC.rst.NumRods)) Then
							Me.MakeRowActive(RSWIN_DESC.iCurrentRodNum)
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
			If RSWIN_DESC.rst.NumRods > 1S Then
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

		Private Sub TextBox_Change(ByRef txt As TextBox, ByRef lbl As Label)
			If Me.ActiveControl IsNot txt Then
				CtrlUI.TextBox_LostFocus(txt, lbl, True)
				Return
			End If
			Me.bValidated = False
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

		Private Sub ulgTapers_Leave(sender As Object, e As EventArgs)
			Me.bEnterEditmode = False
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
				Dim comparer As dlgImplementGuideChanges.rgaComparer = New dlgImplementGuideChanges.rgaComparer()
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

		Public Function LoadDiameterList(ByRef myAL As ArrayList, ByRef myRSArray As dlgImplementGuideChanges.RodSizeArray(), iRodGrade As Short, ByRef sRodType As String, bMaxMin As Boolean) As Boolean
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
				myRSArray = New dlgImplementGuideChanges.RodSizeArray(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}
				Try
					For Each obj As Object In teRodSizeList
						Dim dictionaryEntry As DictionaryEntry
						Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
						RSWIN_DESC.nItems += 1S
						array = CType(Utils.CopyArray(CType(array, Array), New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}), String())
						array2 = CType(Utils.CopyArray(CType(array2, Array), New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}), String())
						myRSArray = CType(Utils.CopyArray(CType(myRSArray, Array), New dlgImplementGuideChanges.RodSizeArray(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}), dlgImplementGuideChanges.RodSizeArray())
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

		Private Sub ulgTapers_AfterExitEditMode(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.PreviousColumn, Me.CurrentColumn, False) <> 0 Or Not Me.bLengthError Then
				Me.lblStatus.Text = ""
				Return
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

		Public Sub Control__LostFocus(ByRef cntrl As Control)
			CtrlUI.Control_LostFocus(cntrl)
		End Sub

		Public Sub TextBox__LostFocus(ByRef txt As TextBox, Optional ByRef lbl As Label = Nothing, Optional bRequiredColor As Boolean = True)
			CtrlUI.TextBox_LostFocus(txt, lbl, bRequiredColor)
		End Sub

		Public Sub TextBox__KeyDown(ByRef txt As TextBox, ByRef lbl As Label, KeyCode As Integer, Shift As Integer)
			CtrlUI.TextBox_KeyDown(txt, lbl, KeyCode, Shift)
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

		Private Sub Control_SelectedIndexChanged(bActiveControl As Boolean)
			If bActiveControl Then
				Me.bValidated = False
				Return
			End If
		End Sub

		Private Sub UpdateUI()
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
				Me.cmdAddSection.Enabled = True
				Me.cmdDelSection.Enabled = True
				Me.cmdMoveSectionUp.Enabled = True
				Me.cmdMoveSectionDown.Enabled = True
				Me.cmdAddSection.Visible = True
				Me.cmdDelSection.Visible = True
				Me.cmdMoveSectionUp.Visible = True
				Me.cmdMoveSectionDown.Visible = True
				Me.m_iCurrentRodSection = iCurrentRodSection
			Catch ex As Exception
			End Try
		End Sub

		Public Function CurrentSolutionSameAsPrevious_Old(iIndx As Integer) As Boolean
			Dim result As Boolean = True
			If iIndx = 1 Then
				result = False
			ElseIf RSWIN_DESC.saved_num_rods(iIndx) <> RSWIN_DESC.saved_num_rods(iIndx - 1) Then
				result = False
			Else
				Try
					result = (RSWIN_DESC.saved_num_rods(iIndx) <> 0)
					Dim num As Integer = 1
					Dim num3 As Integer
					Dim num2 As Integer = num3
					For i As Integer = num To num2
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						If Math.Abs(RSWIN_DESC.saved_rod_designs(iIndx).Sections(i).NumGuides - RSWIN_DESC.saved_rod_designs(iIndx - 1).Sections(i).NumGuides) > 1S Then
							result = False
							Exit For
						End If
					Next
				Catch ex As Exception
					result = False
				End Try
			End If
			Return result
		End Function

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

		<AccessedThroughProperty("_SSPanel_0")>
		Private __SSPanel_0 As Panel

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As PanelArray

		<AccessedThroughProperty("ulgTapers_before")>
		Private _ulgTapers_before As UltraGrid

		<AccessedThroughProperty("txtTempDiam")>
		Private _txtTempDiam As TextBox

		<AccessedThroughProperty("lblTemp")>
		Private _lblTemp As Label

		<AccessedThroughProperty("txtTempLength")>
		Private _txtTempLength As TextBox

		<AccessedThroughProperty("cboRodGuides")>
		Private _cboRodGuides As ComboBox

		<AccessedThroughProperty("cboRodGrade")>
		Private _cboRodGrade As ComboBox

		<AccessedThroughProperty("btnImplement")>
		Private _btnImplement As Button

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("ulgTapers")>
		Private _ulgTapers As UltraGrid

		<AccessedThroughProperty("lblStatus")>
		Private _lblStatus As Label

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		<AccessedThroughProperty("txtLength")>
		Private _txtLength As TextBox

		<AccessedThroughProperty("cmdAddSection")>
		Private _cmdAddSection As Button

		<AccessedThroughProperty("cmdDelSection")>
		Private _cmdDelSection As Button

		<AccessedThroughProperty("cmdMoveSectionUp")>
		Private _cmdMoveSectionUp As Button

		<AccessedThroughProperty("cmdMoveSectionDown")>
		Private _cmdMoveSectionDown As Button

		<AccessedThroughProperty("_Label_Length")>
		Private __Label_Length As Label

		<AccessedThroughProperty("lblStringLength")>
		Private _lblStringLength As Label

		<AccessedThroughProperty("btnAccept")>
		Private _btnAccept As Button

		<AccessedThroughProperty("pnlViewReport")>
		Private _pnlViewReport As Panel

		<AccessedThroughProperty("Viewer1")>
		Private _Viewer1 As Viewer

		<AccessedThroughProperty("chkShowReport")>
		Private _chkShowReport As CheckBox

		<AccessedThroughProperty("btnUndoImplement")>
		Private _btnUndoImplement As Button

		<AccessedThroughProperty("lblMinimum")>
		Private _lblMinimum As Label

		<AccessedThroughProperty("lblMaximum")>
		Private _lblMaximum As Label

		<AccessedThroughProperty("cboRodSize")>
		Private _cboRodSize As ComboBox

		Private Shared m_vb6FormDefInstance As dlgImplementGuideChanges

		Private Shared m_InitializingDefInstance As Boolean

		Private sRodStringLength As String

		Private sPumpDepth As String

		Private sARSRemoveSelected As String

		Private sDeleteRow As String

		Private sARSRemoveLastSection As String

		Private sARSRemoveLastSections As String

		Public sRecommendedFricCoef As String

		Public sRecommendedFricCoefYesNo As String

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

		Private rptRecommendedGuideReport As Object

		Private m_bAccept As Boolean

		Private m_bKeep As Boolean

		Private fDepths As Single()

		Private bShowGuides As Boolean

		Private bUseStatus As Boolean

		Private bCheckRodsInTubingMsgShown As Boolean

		Private bInsideUpdateRS As Boolean

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

		Private bEnterEditmode As Boolean

		Private myRodTypeGradeAL As ArrayList

		Private myRSGradeAL As ArrayList

		Private myRodGuideAL As ArrayList

		Private myRSMaxDiamAL As ArrayList

		Private myRSMinDiamAL As ArrayList

		Private myRSSBDiamAL As ArrayList

		Private myRSMaxDiamRodSizeArray As dlgImplementGuideChanges.RodSizeArray()

		Private myRSMinDiamRodSizeArray As dlgImplementGuideChanges.RodSizeArray()

		Private myRSSBDiamRodSizeArray As dlgImplementGuideChanges.RodSizeArray()

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

		Private iNorris97 As Integer

		Private mdsRodTapers As DataSet

		Private bLengthError As Boolean

		Private bDisplayDeleteMessage As Boolean

		Private bLoadingCombo As Boolean

		Private bValidated As Boolean

		Private tmp_PumpDepth As Single

		Private miNewRodNum As Integer

		Private mfMouseDownX As Single

		Private mfMouseDownY As Single

		Private m_iCurrentRodSection As Integer

		Private mousePoint As Point

		Private sRecommendedFricCoefYesNo_LessThan As String

		Public sRecommendedFricCoefYesNo_GreaterThan As String

		Private CurrentColumn As String

		Private PreviousColumn As String

		Private bF2Hit As Boolean

		Private btxtLengthHasFocus As Boolean

		Private ThisF2Cell As UltraGridCell

		Private ThisF2Row As UltraGridRow

		Private iOrigNumRods As Integer

		Private SETUP_RECOMMEND_GUIDES_SAVE As Boolean

		Private bValueListsCreated As Boolean

		Private bImplementChosen As Boolean

		Private bFormLoaded As Boolean

		Private bActivated As Boolean

		Private m_bRodDesignTypeClicked As Boolean

		Private m_bRecommendedFricCoefShown As Boolean

		Private m_bRecommendedFricCoefYesNoShown As Boolean

		Private m_bLeaveLoaded As Boolean

		Private $STATIC$AddToArrayList$20712101281458E8EE$iCount As Integer

		Private $STATIC$AddToGuideArrayList$20712101281458E8EE$iCount As Integer

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
					Dim rodSizeArray As dlgImplementGuideChanges.RodSizeArray
					Dim obj As Object = If((y IsNot Nothing), CType(y, dlgImplementGuideChanges.RodSizeArray), rodSizeArray).rsaDiameter * 1000F - If((x IsNot Nothing), CType(x, dlgImplementGuideChanges.RodSizeArray), rodSizeArray).rsaDiameter * 1000F
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
	End Class
End Namespace
