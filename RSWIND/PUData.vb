Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Partial Class PUData
		Inherits Form

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

		Public Sub New()
			AddHandler MyBase.Enter, AddressOf Me.PUData_Enter
			AddHandler MyBase.Leave, AddressOf Me.PUData_Leave
			AddHandler MyBase.Load, AddressOf Me.PUData_Load
			AddHandler MyBase.Validating, AddressOf Me.PUData_Validating
			AddHandler MyBase.Activated, AddressOf Me.PUData_Activated
			AddHandler MyBase.Closed, AddressOf Me.PUData_Closed
			AddHandler MyBase.Closing, AddressOf Me.PUData_Closing
			AddHandler MyBase.Deactivate, AddressOf Me.PUData_Deactivate
			AddHandler MyBase.Disposed, AddressOf Me.PUData_Disposed
			AddHandler MyBase.MenuStart, AddressOf Me.PUData_MenuStart
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.PUData_MouseDoubleClick
			AddHandler MyBase.MouseDown, AddressOf Me.PUData_MouseDown
			AddHandler MyBase.MouseEnter, AddressOf Me.PUData_MouseEnter
			AddHandler MyBase.MouseMove, AddressOf Me.PUData_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.PUData_MouseUp
			AddHandler MyBase.MouseWheel, AddressOf Me.PUData_MouseWheel
			AddHandler MyBase.Move, AddressOf Me.PUData_Move
			AddHandler MyBase.Scroll, AddressOf Me.PUData_Scroll
			AddHandler MyBase.KeyPress, AddressOf Me.PUData_KeyPress
			AddHandler MyBase.KeyUp, AddressOf Me.PUData_KeyUp
			AddHandler MyBase.DragDrop, AddressOf Me.PUData_DragDrop
			AddHandler MyBase.DragEnter, AddressOf Me.PUData_DragEnter
			AddHandler MyBase.FormClosed, AddressOf Me.PUData_FormClosed
			AddHandler MyBase.FormClosing, AddressOf Me.PUData_FormClosing
			AddHandler MyBase.LostFocus, AddressOf Me.PUData_LostFocus
			AddHandler MyBase.GotFocus, AddressOf Me.PUData_GotFocus
			Me.bMarkII = False
			Me.bRMark = False
			Me.bRotaflex = False
			Me.bAB = False
			Me.bHydraulic = False
			Me.m_bClosing = False
			Me.m_bValidated = False
			Me.bInit = False
			Me.bRecPULoaded = False
			Me.bCustomUnit = False
			Me.sUnknownCounterbalanceWeight = Util.AssignValueToConstant("PUData", "sUnknownCounterbalanceWeight", "Unknown counterbalance weight")
			Me.sExistingCounterbalanceWeight = Util.AssignValueToConstant("PUData", "sExistingCounterbalanceWeight", "Existing counterbalance weight")
			Me.sUseXBALInformation = Util.AssignValueToConstant("PUData", "sUseXBALInformation", "Use XBAL Information")
			Me.sUnknownAirTankPressure = Util.AssignValueToConstant("PUData", "sUnknownAirTankPressure", "Unknown air tank pressure")
			Me.sExistingAirTankPressure = Util.AssignValueToConstant("PUData", "sExistingAirTankPressure", "Existing air tank pressure at bottom-of-stroke")
			Me.sUnknownCounterbalanceData = Util.AssignValueToConstant("PUData", "sUnknownCounterbalanceData", "Unknown counterbalance data")
			Me.sExistingStructuralUnbalance = Util.AssignValueToConstant("PUData", "sExistingStructuralUnbalance", "Existing Structural Unbalance")
			Me.sUnknownMCM = Util.AssignValueToConstant("PUData", "sUnknownMCM", "Unknown MCM")
			Me.sExistingMaximumCounterbalanceMoment = Util.AssignValueToConstant("PUData", "sExistingMaximumCounterbalanceMoment", "Existing maximum counterbalance moment")
			Me.sExistingMaximumCounterbalanceWeight = Util.AssignValueToConstant("PUData", "sExistingMaximumCounterbalanceWeight", "Existing maximum counterbalance weight")
			Me.sFileNoneSelected = Util.AssignValueToConstant("PUData", "sFileNoneSelected", "File:  (none selected)")
			Me.sFile = Util.AssignValueToConstant("PUData", "sFile", "File:  (")
			Me.sUnitID = Util.AssignValueToConstant("PUData", "sUnitID", "Unit ID:")
			Me.sUnitSizeRecommendation = Util.AssignValueToConstant("PUData", "sUnitSizeRecommendation", "Recommended unit size: no recommendation")
			Me.sSelectUnitSizeRecommendation = Util.AssignValueToConstant("PUData", "sSelectUnitSizeRecommendation", "Select Recommended Unit Size")
			Me.csHDR_APIDES = Util.AssignValueToConstant("PUData", "csHDR_APIDES", "API designation")
			Me.csHDR_UNITDES = Util.AssignValueToConstant("PUData", "csHDR_UNITDES", "Unit designation")
			Me.csHDR_MANUF = Util.AssignValueToConstant("PUData", "csHDR_MANUF", "Manufacturer")
			Me.csHDR_OTHER = Util.AssignValueToConstant("PUData", "csHDR_OTHER", "Other info")
			Me.csHDR_UNAME = Util.AssignValueToConstant("PUData", "csHDR_UNAME", "Unit name")
			Me.csKEY_APIDES = Util.AssignValueToConstant("PUData", "csKEY_APIDES", "APIDesignation")
			Me.csKEY_MANUF = Util.AssignValueToConstant("PUData", "csKEY_MANUF", "Manufacturer")
			Me.csKEY_OTHER = Util.AssignValueToConstant("PUData", "csKEY_OTHER", "OtherInfo")
			Me.csKEY_UNAME = Util.AssignValueToConstant("PUData", "csKEY_UNAME", "UnitName")
			Me.sPUNotEntered = Util.AssignValueToConstant("PUData", "sPUNotEntered", "You have not entered data for any measured pumping units. You can enter pumping unit dimensions in Setup.")
			Me.sPUNoInfo = Util.AssignValueToConstant("PUData", "sPUNoInfo", "There is no information available for this pumping unit manufacturer.")
			Me.sProdNotValid = Util.AssignValueToConstant("PUData", "sProdNotValid", "The pumping unit ID you entered is not valid.")
			Me.sRecommendedUnitSize = Util.AssignValueToConstant("PUData", "sRecommendedUnitSize", "Recommended Unit Size: ")
			Me.sNoRecommendation = Util.AssignValueToConstant("PUData", "sNoRecommendation", "No recommendation")
			Me.sSelect = Util.AssignValueToConstant("PUData", "sSelect", "  Select ")
			Me.sUpdateUnbalance = Util.AssignValueToConstant("PUData", "sUpdateUnbalance", "Replace entered Unbalance with value from pumping unit database?")
			Me.bUnbalancedAsked = False
			Me.sExportCBMoment = Util.AssignValueToConstant("RODSTAR", "sExportCBMoment", "Export counterbalance moment")
			Me.sExportRequiredUnbalance = Util.AssignValueToConstant("RODSTAR", "sExportRequiredUnbalance", "Export required structural unbalance")
			Me.sXBALFileMessage1 = "Data in XBAL file pertains to beam balanced unit while the current pumping unit is of a different type. Continue reading file?"
			Me.sXBALFileMessage2 = "Data in XBAL file does not pertain to beam balanced unit while the current pumping unit type is beam balanced. Continue reading file?"
			Me.table_1000_fg = New ArrayList()
			Me.table_1500_fg = New ArrayList()
			Me.table_2000_fg = New ArrayList()
			Me.table_2500_fg = New ArrayList()
			Me.table_3000_fg = New ArrayList()
			Me.table_3500_fg = New ArrayList()
			Me.table_4000_fg = New ArrayList()
			Me.table_4500_fg = New ArrayList()
			Me.table_5000_fg = New ArrayList()
			Me.table_5500_fg = New ArrayList()
			Me.table_6000_fg = New ArrayList()
			Me.table_6500_fg = New ArrayList()
			Me.table_7500_fg = New ArrayList()
			Me.table_7000_fg = New ArrayList()
			Me.table_8000_fg = New ArrayList()
			Me.table_8500_fg = New ArrayList()
			Me.table_9000_fg = New ArrayList()
			Me.table_9500_fg = New ArrayList()
			Me.table_10000_fg = New ArrayList()
			Me.table_10500_fg = New ArrayList()
			Me.table_11000_fg = New ArrayList()
			Me.table_11500_fg = New ArrayList()
			Me.table_12000_fg = New ArrayList()
			Me.table_12500_fg = New ArrayList()
			Me.table_13000_fg = New ArrayList()
			Me.table_13500_fg = New ArrayList()
			Me.table_14000_fg = New ArrayList()
			Me.table_14500_fg = New ArrayList()
			Me.table_15000_fg = New ArrayList()
			Me.table_15500_fg = New ArrayList()
			Me.table_16000_fg = New ArrayList()
			Me.table_16500_fg = New ArrayList()
			Me.table_17000_fg = New ArrayList()
			Me.table_17500_fg = New ArrayList()
			Me.table_18000_fg = New ArrayList()
			Me.table_18500_fg = New ArrayList()
			Me.table_19000_fg = New ArrayList()
			Me.table_20000_fg = New ArrayList()
			Me.table_1000_st = New ArrayList()
			Me.table_1500_st = New ArrayList()
			Me.table_2000_st = New ArrayList()
			Me.table_2500_st = New ArrayList()
			Me.table_3000_st = New ArrayList()
			Me.table_3500_st = New ArrayList()
			Me.table_4000_st = New ArrayList()
			Me.table_4500_st = New ArrayList()
			Me.table_5000_st = New ArrayList()
			Me.table_5500_st = New ArrayList()
			Me.table_6000_st = New ArrayList()
			Me.table_6500_st = New ArrayList()
			Me.table_7000_st = New ArrayList()
			Me.table_7500_st = New ArrayList()
			Me.table_8000_st = New ArrayList()
			Me.table_8500_st = New ArrayList()
			Me.table_9000_st = New ArrayList()
			Me.table_9500_st = New ArrayList()
			Me.table_10000_st = New ArrayList()
			Me.table_10500_st = New ArrayList()
			Me.table_11000_st = New ArrayList()
			Me.table_11500_st = New ArrayList()
			Me.table_12000_st = New ArrayList()
			Me.table_12500_st = New ArrayList()
			Me.table_13000_st = New ArrayList()
			Me.table_13500_st = New ArrayList()
			Me.table_14000_st = New ArrayList()
			Me.table_14500_st = New ArrayList()
			Me.table_15000_st = New ArrayList()
			Me.table_15500_st = New ArrayList()
			Me.table_16000_st = New ArrayList()
			Me.table_16500_st = New ArrayList()
			Me.table_17000_st = New ArrayList()
			Me.table_17500_st = New ArrayList()
			Me.table_18000_st = New ArrayList()
			Me.table_18500_st = New ArrayList()
			Me.table_19000_st = New ArrayList()
			Me.table_19500_st = New ArrayList()
			Me.table_20000_st = New ArrayList()
			Me.dlgCBData = New dlgCBData()
			Me.myKeyValueHT = New Hashtable()
			Me.sDYWCustomPU = Util.AssignValueToConstant("DoYouWant", "sDYWCustomPU", "Do you want to add this pumping unit to the custom pumping unit database?")
			If PUData.m_vb6FormDefInstance Is Nothing Then
				If PUData.m_InitializingDefInstance Then
					PUData.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							PUData.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
			Me.Text = "Pumping Unit Information"
		End Sub

		Public Overridable Property pnlPUData As Panel
			Get
				Return Me._pnlPUData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlPUData = value
			End Set
		End Property

		Public Overridable Property Label5 As Label
			Get
				Return Me._Label5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		Public Overridable Property lblCalcStroke As Label
			Get
				Return Me._lblCalcStroke
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.lblCalcStroke_Click
				If Me._lblCalcStroke IsNot Nothing Then
					RemoveHandler Me._lblCalcStroke.Click, value2
				End If
				Me._lblCalcStroke = value
				If Me._lblCalcStroke IsNot Nothing Then
					AddHandler Me._lblCalcStroke.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property grpCounterBalance As GroupBox
			Get
				Return Me._grpCounterBalance
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpCounterBalance = value
			End Set
		End Property

		Public Overridable Property lblMInLbs As Label
			Get
				Return Me._lblMInLbs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.lblMInLbs_TextChanged
				If Me._lblMInLbs IsNot Nothing Then
					RemoveHandler Me._lblMInLbs.TextChanged, value2
				End If
				Me._lblMInLbs = value
				If Me._lblMInLbs IsNot Nothing Then
					AddHandler Me._lblMInLbs.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lblUnitID As Label
			Get
				Return Me._lblUnitID
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblUnitID = value
			End Set
		End Property

		Public Overridable Property lblStructuralUnbalance As Label
			Get
				Return Me._lblStructuralUnbalance
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblStructuralUnbalance = value
			End Set
		End Property

		Public Overridable Property lblStrokeLength As Label
			Get
				Return Me._lblStrokeLength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblStrokeLength = value
			End Set
		End Property

		Public Overridable Property txtUnbalance As TextBox
			Get
				Return Me._txtUnbalance
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtUnbalance_Leave
				Dim value3 As KeyEventHandler = AddressOf Me.txtUnbalance_KeyDown
				Dim value4 As EventHandler = AddressOf Me.txtUnbalance_Enter
				Dim value5 As EventHandler = AddressOf Me.txtUnbalance_TextChanged
				If Me._txtUnbalance IsNot Nothing Then
					RemoveHandler Me._txtUnbalance.Leave, value2
					RemoveHandler Me._txtUnbalance.KeyDown, value3
					RemoveHandler Me._txtUnbalance.Enter, value4
					RemoveHandler Me._txtUnbalance.TextChanged, value5
				End If
				Me._txtUnbalance = value
				If Me._txtUnbalance IsNot Nothing Then
					AddHandler Me._txtUnbalance.Leave, value2
					AddHandler Me._txtUnbalance.KeyDown, value3
					AddHandler Me._txtUnbalance.Enter, value4
					AddHandler Me._txtUnbalance.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property cmdReadCBLFile As Button
			Get
				Return Me._cmdReadCBLFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdReadCBLFile_Click
				If Me._cmdReadCBLFile IsNot Nothing Then
					RemoveHandler Me._cmdReadCBLFile.Click, value2
				End If
				Me._cmdReadCBLFile = value
				If Me._cmdReadCBLFile IsNot Nothing Then
					AddHandler Me._cmdReadCBLFile.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property optCBDataType_1 As RadioButton
			Get
				Return Me._optCBDataType_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optCBDataType_1_CheckedChanged
				If Me._optCBDataType_1 IsNot Nothing Then
					RemoveHandler Me._optCBDataType_1.CheckedChanged, value2
				End If
				Me._optCBDataType_1 = value
				If Me._optCBDataType_1 IsNot Nothing Then
					AddHandler Me._optCBDataType_1.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lvwUnitList As ListView
			Get
				Return Me._lvwUnitList
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Dim value2 As EventHandler = AddressOf Me.lvwUnitList_ItemClick
				Dim value3 As MouseEventHandler = AddressOf Me.lvwUnitList_MouseDown
				Dim value4 As KeyEventHandler = AddressOf Me.lvwUnitList_KeyUp
				Dim value5 As KeyEventHandler = AddressOf Me.lvwUnitList_KeyDown
				Dim value6 As EventHandler = AddressOf Me.lvwUnitList_ItemActivate
				Dim value7 As EventHandler = AddressOf Me.lvwUnitList_DoubleClick
				Dim value8 As EventHandler = AddressOf Me.lvwUnitList_Leave
				Dim value9 As EventHandler = AddressOf Me.lvwUnitList_Enter
				Dim value10 As EventHandler = AddressOf Me.lvwUnitList_Click
				Dim value11 As EventHandler = AddressOf Me.lvwUnitList_SelectedIndexChanged
				If Me._lvwUnitList IsNot Nothing Then
					RemoveHandler Me._lvwUnitList.Click, value2
					RemoveHandler Me._lvwUnitList.MouseDown, value3
					RemoveHandler Me._lvwUnitList.KeyUp, value4
					RemoveHandler Me._lvwUnitList.KeyDown, value5
					RemoveHandler Me._lvwUnitList.ItemActivate, value6
					RemoveHandler Me._lvwUnitList.DoubleClick, value7
					RemoveHandler Me._lvwUnitList.Leave, value8
					RemoveHandler Me._lvwUnitList.Enter, value9
					RemoveHandler Me._lvwUnitList.Click, value10
					RemoveHandler Me._lvwUnitList.SelectedIndexChanged, value11
				End If
				Me._lvwUnitList = value
				If Me._lvwUnitList IsNot Nothing Then
					AddHandler Me._lvwUnitList.Click, value2
					AddHandler Me._lvwUnitList.MouseDown, value3
					AddHandler Me._lvwUnitList.KeyUp, value4
					AddHandler Me._lvwUnitList.KeyDown, value5
					AddHandler Me._lvwUnitList.ItemActivate, value6
					AddHandler Me._lvwUnitList.DoubleClick, value7
					AddHandler Me._lvwUnitList.Leave, value8
					AddHandler Me._lvwUnitList.Enter, value9
					AddHandler Me._lvwUnitList.Click, value10
					AddHandler Me._lvwUnitList.SelectedIndexChanged, value11
				End If
			End Set
		End Property

		Public Overridable Property txtUnitID As TextBox
			Get
				Return Me._txtUnitID
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtUnitID_Leave
				Dim value3 As EventHandler = AddressOf Me.txtUnitID_Enter
				Dim value4 As EventHandler = AddressOf Me.txtUnitID_TextChanged
				If Me._txtUnitID IsNot Nothing Then
					RemoveHandler Me._txtUnitID.Leave, value2
					RemoveHandler Me._txtUnitID.Enter, value3
					RemoveHandler Me._txtUnitID.TextChanged, value4
				End If
				Me._txtUnitID = value
				If Me._txtUnitID IsNot Nothing Then
					AddHandler Me._txtUnitID.Leave, value2
					AddHandler Me._txtUnitID.Enter, value3
					AddHandler Me._txtUnitID.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property cboManufMenu As ComboBox
			Get
				Return Me._cboManufMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboManufMenu_SelectedIndexChanged
				Dim value3 As EventHandler = AddressOf Me.cboManufMenu_Click
				Dim value4 As EventHandler = AddressOf Me.cboManufMenu_Leave
				Dim value5 As EventHandler = AddressOf Me.cboManufMenu_Enter
				If Me._cboManufMenu IsNot Nothing Then
					RemoveHandler Me._cboManufMenu.SelectedIndexChanged, value2
					RemoveHandler Me._cboManufMenu.Click, value3
					RemoveHandler Me._cboManufMenu.Leave, value4
					RemoveHandler Me._cboManufMenu.Enter, value5
				End If
				Me._cboManufMenu = value
				If Me._cboManufMenu IsNot Nothing Then
					AddHandler Me._cboManufMenu.SelectedIndexChanged, value2
					AddHandler Me._cboManufMenu.Click, value3
					AddHandler Me._cboManufMenu.Leave, value4
					AddHandler Me._cboManufMenu.Enter, value5
				End If
			End Set
		End Property

		Public Overridable Property cboCrankHole As ComboBox
			Get
				Return Me._cboCrankHole
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboCrankHole_Leave
				Dim value3 As EventHandler = AddressOf Me.cboCrankHole_Enter
				Dim value4 As EventHandler = AddressOf Me.cboCrankHole_SelectedIndexChanged
				Dim value5 As EventHandler = AddressOf Me.cboCrankHole_Changed
				Dim value6 As EventHandler = AddressOf Me.cboCrankHole_Click
				If Me._cboCrankHole IsNot Nothing Then
					RemoveHandler Me._cboCrankHole.Leave, value2
					RemoveHandler Me._cboCrankHole.Enter, value3
					RemoveHandler Me._cboCrankHole.SelectedIndexChanged, value4
					RemoveHandler Me._cboCrankHole.SelectedValueChanged, value5
					RemoveHandler Me._cboCrankHole.Click, value6
				End If
				Me._cboCrankHole = value
				If Me._cboCrankHole IsNot Nothing Then
					AddHandler Me._cboCrankHole.Leave, value2
					AddHandler Me._cboCrankHole.Enter, value3
					AddHandler Me._cboCrankHole.SelectedIndexChanged, value4
					AddHandler Me._cboCrankHole.SelectedValueChanged, value5
					AddHandler Me._cboCrankHole.Click, value6
				End If
			End Set
		End Property

		Public Overridable Property cboCrankRotation As ComboBox
			Get
				Return Me._cboCrankRotation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboCrankRotation_Click
				Dim value3 As EventHandler = AddressOf Me.cboCrankRotation_Leave
				Dim value4 As EventHandler = AddressOf Me.cboCrankRotation_Enter
				Dim value5 As EventHandler = AddressOf Me.cboCrankRotation_SelectedIndexChanged
				If Me._cboCrankRotation IsNot Nothing Then
					RemoveHandler Me._cboCrankRotation.Click, value2
					RemoveHandler Me._cboCrankRotation.Leave, value3
					RemoveHandler Me._cboCrankRotation.Enter, value4
					RemoveHandler Me._cboCrankRotation.SelectedIndexChanged, value5
				End If
				Me._cboCrankRotation = value
				If Me._cboCrankRotation IsNot Nothing Then
					AddHandler Me._cboCrankRotation.Click, value2
					AddHandler Me._cboCrankRotation.Leave, value3
					AddHandler Me._cboCrankRotation.Enter, value4
					AddHandler Me._cboCrankRotation.SelectedIndexChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property chkCustomPUDB As CheckBox
			Get
				Return Me._chkCustomPUDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkCustomPUDB_CheckedChanged
				Dim value3 As EventHandler = AddressOf Me.chkCustomPUDB_Click
				If Me._chkCustomPUDB IsNot Nothing Then
					RemoveHandler Me._chkCustomPUDB.CheckedChanged, value2
					RemoveHandler Me._chkCustomPUDB.Click, value3
				End If
				Me._chkCustomPUDB = value
				If Me._chkCustomPUDB IsNot Nothing Then
					AddHandler Me._chkCustomPUDB.CheckedChanged, value2
					AddHandler Me._chkCustomPUDB.Click, value3
				End If
			End Set
		End Property

		Public Overridable Property lblCBDataFile As Label
			Get
				Return Me._lblCBDataFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCBDataFile = value
			End Set
		End Property

		Friend Overridable Property lblAPI As Label
			Get
				Return Me._lblAPI
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblAPI = value
			End Set
		End Property

		Friend Overridable Property txtCounterbalance As TextBox
			Get
				Return Me._txtCounterbalance
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.txtCounterbalance_KeyDown
				Dim value3 As EventHandler = AddressOf Me.txtCounterbalance_EnabledChanged
				Dim value4 As EventHandler = AddressOf Me.txtCounterbalance_TextChanged
				Dim value5 As EventHandler = AddressOf Me.txtCounterbalance_Enter
				Dim value6 As EventHandler = AddressOf Me.txtCounterbalance_Leave
				If Me._txtCounterbalance IsNot Nothing Then
					RemoveHandler Me._txtCounterbalance.KeyDown, value2
					RemoveHandler Me._txtCounterbalance.EnabledChanged, value3
					RemoveHandler Me._txtCounterbalance.TextChanged, value4
					RemoveHandler Me._txtCounterbalance.Enter, value5
					RemoveHandler Me._txtCounterbalance.Leave, value6
				End If
				Me._txtCounterbalance = value
				If Me._txtCounterbalance IsNot Nothing Then
					AddHandler Me._txtCounterbalance.KeyDown, value2
					AddHandler Me._txtCounterbalance.EnabledChanged, value3
					AddHandler Me._txtCounterbalance.TextChanged, value4
					AddHandler Me._txtCounterbalance.Enter, value5
					AddHandler Me._txtCounterbalance.Leave, value6
				End If
			End Set
		End Property

		Friend Overridable Property Panel1 As Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
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

		Public Overridable Property optCBDataType_3 As RadioButton
			Get
				Return Me._optCBDataType_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optCBDataType_3_CheckedChanged
				If Me._optCBDataType_3 IsNot Nothing Then
					RemoveHandler Me._optCBDataType_3.CheckedChanged, value2
				End If
				Me._optCBDataType_3 = value
				If Me._optCBDataType_3 IsNot Nothing Then
					AddHandler Me._optCBDataType_3.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property optCBDataType_5 As RadioButton
			Get
				Return Me._optCBDataType_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optCBDataType_5_TextChanged
				Dim value3 As EventHandler = AddressOf Me.optCBDataType_5_EnabledChanged
				Dim value4 As EventHandler = AddressOf Me.optCBDataType_5_CheckedChanged
				If Me._optCBDataType_5 IsNot Nothing Then
					RemoveHandler Me._optCBDataType_5.TextChanged, value2
					RemoveHandler Me._optCBDataType_5.EnabledChanged, value3
					RemoveHandler Me._optCBDataType_5.CheckedChanged, value4
				End If
				Me._optCBDataType_5 = value
				If Me._optCBDataType_5 IsNot Nothing Then
					AddHandler Me._optCBDataType_5.TextChanged, value2
					AddHandler Me._optCBDataType_5.EnabledChanged, value3
					AddHandler Me._optCBDataType_5.CheckedChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property optCBDataType_6 As RadioButton
			Get
				Return Me._optCBDataType_6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optCBDataType_6_CheckedChanged
				If Me._optCBDataType_6 IsNot Nothing Then
					RemoveHandler Me._optCBDataType_6.CheckedChanged, value2
				End If
				Me._optCBDataType_6 = value
				If Me._optCBDataType_6 IsNot Nothing Then
					AddHandler Me._optCBDataType_6.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdCBApplet As Button
			Get
				Return Me._cmdCBApplet
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdCBApplet_Click
				If Me._cmdCBApplet IsNot Nothing Then
					RemoveHandler Me._cmdCBApplet.Click, value2
				End If
				Me._cmdCBApplet = value
				If Me._cmdCBApplet IsNot Nothing Then
					AddHandler Me._cmdCBApplet.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property cmdUnitSizeRecommendation As Button
			Get
				Return Me._cmdUnitSizeRecommendation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdUnitSizeRecommendation_Click
				If Me._cmdUnitSizeRecommendation IsNot Nothing Then
					RemoveHandler Me._cmdUnitSizeRecommendation.Click, value2
				End If
				Me._cmdUnitSizeRecommendation = value
				If Me._cmdUnitSizeRecommendation IsNot Nothing Then
					AddHandler Me._cmdUnitSizeRecommendation.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolTip1 As ToolTip
			Get
				Return Me._ToolTip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolTip)
				Me._ToolTip1 = value
			End Set
		End Property

		Public Overridable Property lblManufacturer As Label
			Get
				Return Me._lblManufacturer
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblManufacturer = value
			End Set
		End Property

		Public Overridable Property lblCrankRotation As Label
			Get
				Return Me._lblCrankRotation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCrankRotation = value
			End Set
		End Property

		Public Overridable Property lblCrankHole As Label
			Get
				Return Me._lblCrankHole
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCrankHole = value
			End Set
		End Property

		Friend Overridable Property lblCounterbalance_Disabled As Label
			Get
				Return Me._lblCounterbalance_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCounterbalance_Disabled = value
			End Set
		End Property

		Friend Overridable Property pnlHydraulic As Panel
			Get
				Return Me._pnlHydraulic
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As EventHandler = AddressOf Me.pnlHydraulic_VisibleChanged
				If Me._pnlHydraulic IsNot Nothing Then
					RemoveHandler Me._pnlHydraulic.VisibleChanged, value2
				End If
				Me._pnlHydraulic = value
				If Me._pnlHydraulic IsNot Nothing Then
					AddHandler Me._pnlHydraulic.VisibleChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtPercentDownstrokeSPM As TextBox
			Get
				Return Me._txtPercentDownstrokeSPM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtPercentDownstrokeSPM_Leave
				Dim value3 As EventHandler = AddressOf Me.txtPercentDownstrokeSPM_TextChanged
				If Me._txtPercentDownstrokeSPM IsNot Nothing Then
					RemoveHandler Me._txtPercentDownstrokeSPM.Leave, value2
					RemoveHandler Me._txtPercentDownstrokeSPM.TextChanged, value3
				End If
				Me._txtPercentDownstrokeSPM = value
				If Me._txtPercentDownstrokeSPM IsNot Nothing Then
					AddHandler Me._txtPercentDownstrokeSPM.Leave, value2
					AddHandler Me._txtPercentDownstrokeSPM.TextChanged, value3
				End If
			End Set
		End Property

		Public Overridable Property txtPercentUpstrokeSPM As TextBox
			Get
				Return Me._txtPercentUpstrokeSPM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtPercentUpstrokeSPM_Leave
				Dim value3 As EventHandler = AddressOf Me.txtPercentUpstrokeSPM_TextChanged
				If Me._txtPercentUpstrokeSPM IsNot Nothing Then
					RemoveHandler Me._txtPercentUpstrokeSPM.Leave, value2
					RemoveHandler Me._txtPercentUpstrokeSPM.TextChanged, value3
				End If
				Me._txtPercentUpstrokeSPM = value
				If Me._txtPercentUpstrokeSPM IsNot Nothing Then
					AddHandler Me._txtPercentUpstrokeSPM.Leave, value2
					AddHandler Me._txtPercentUpstrokeSPM.TextChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property pnlCombinationBeamCrank As Panel
			Get
				Return Me._pnlCombinationBeamCrank
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlCombinationBeamCrank = value
			End Set
		End Property

		Public Overridable Property optUseCrankBalancedCalcs As RadioButton
			Get
				Return Me._optUseCrankBalancedCalcs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optUseCrankBalancedCalcs_CheckedChanged
				If Me._optUseCrankBalancedCalcs IsNot Nothing Then
					RemoveHandler Me._optUseCrankBalancedCalcs.CheckedChanged, value2
				End If
				Me._optUseCrankBalancedCalcs = value
				If Me._optUseCrankBalancedCalcs IsNot Nothing Then
					AddHandler Me._optUseCrankBalancedCalcs.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property optUseBeamBalancedCalcs As RadioButton
			Get
				Return Me._optUseBeamBalancedCalcs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optUseBeamBalancedCalcs_CheckedChanged
				If Me._optUseBeamBalancedCalcs IsNot Nothing Then
					RemoveHandler Me._optUseBeamBalancedCalcs.CheckedChanged, value2
				End If
				Me._optUseBeamBalancedCalcs = value
				If Me._optUseBeamBalancedCalcs IsNot Nothing Then
					AddHandler Me._optUseBeamBalancedCalcs.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lblPercentDownstrokeSPM As Label
			Get
				Return Me._lblPercentDownstrokeSPM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPercentDownstrokeSPM = value
			End Set
		End Property

		Public Overridable Property lblPercentUpstrokeSPM As Label
			Get
				Return Me._lblPercentUpstrokeSPM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPercentUpstrokeSPM = value
			End Set
		End Property

		Public Overridable Property lblAdjustedStrokeLength As Label
			Get
				Return Me._lblAdjustedStrokeLength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblAdjustedStrokeLength = value
			End Set
		End Property

		Public Overridable Property txtAdjustedStrokeLength As TextBox
			Get
				Return Me._txtAdjustedStrokeLength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtAdjustedStrokeLength_TextChanged
				Dim value3 As KeyEventHandler = AddressOf Me.txtAdjustedStrokeLength_KeyDown
				Dim value4 As EventHandler = AddressOf Me.txtAdjustedStrokeLength_Enter
				If Me._txtAdjustedStrokeLength IsNot Nothing Then
					RemoveHandler Me._txtAdjustedStrokeLength.TextChanged, value2
					RemoveHandler Me._txtAdjustedStrokeLength.KeyDown, value3
					RemoveHandler Me._txtAdjustedStrokeLength.Enter, value4
				End If
				Me._txtAdjustedStrokeLength = value
				If Me._txtAdjustedStrokeLength IsNot Nothing Then
					AddHandler Me._txtAdjustedStrokeLength.TextChanged, value2
					AddHandler Me._txtAdjustedStrokeLength.KeyDown, value3
					AddHandler Me._txtAdjustedStrokeLength.Enter, value4
				End If
			End Set
		End Property

		Public Shared Property DefInstance As PUData
			Get
				If PUData.m_vb6FormDefInstance Is Nothing OrElse PUData.m_vb6FormDefInstance.IsDisposed Then
					PUData.m_InitializingDefInstance = True
					PUData.m_vb6FormDefInstance = New PUData()
					PUData.m_InitializingDefInstance = False
				End If
				Return PUData.m_vb6FormDefInstance
			End Get
			Set(value As PUData)
				PUData.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Overridable Property dlgCBData As dlgCBData
			Get
				Return Me._dlgCBData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dlgCBData)
				Me._dlgCBData = value
			End Set
		End Property

		Private Sub LoadManufMenu(ByRef cboManufMenu As ComboBox, UseCustomPUDB As Boolean)
			Dim text As String = New String(" "c, 2)
			Dim fileName As String
			FILEUTIL.LocateFile("UNITINFO32.PUD", fileName, 2S, False, False, False, False)
			Dim comboBox As ComboBox
			Dim num9 As Short
			Dim num10 As Short
			Dim num As Short = CShort(FileSystem.FreeFile())
			FileSystem.FileOpen(CInt(num), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
			Dim unitTypeInfo As RSWIN_DESC.UnitTypeInfo
			Dim num2 As Short = CShort((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(unitTypeInfo))))
			Me.UnitTypeInfoList = New RSWIN_DESC.UnitTypeInfo(CInt((num2 + 1S)) - 1) {}
			Me.nUnitTypes = 0S
			Dim num3 As Short = 1S
			Dim num4 As Short = num2
			For num5 As Short = num3 To num4
				Dim fileNumber As Integer = CInt(num)
				Dim valueType As ValueType = unitTypeInfo
				FileSystem.FileGet(fileNumber, valueType, -1L)
				Dim valueType2 As ValueType = valueType
				Dim unitTypeInfo2 As RSWIN_DESC.UnitTypeInfo
				unitTypeInfo = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.UnitTypeInfo), unitTypeInfo2)
				Dim text2 As String = Strings.Trim(unitTypeInfo.Abbrev)
				If UseCustomPUDB Then
					Dim num6 As Integer = Custom.CustomPumpingUnitLists_SelectRow(text2.Trim(), text, False, "")
					Dim num7 As Short = CShort(text.Length)
					If num7 = 0S Or num6 = 0 Then
						text2 = ""
					End If
				End If
				If Strings.Len(text2) > 0 Then
					Me.nUnitTypes += 1S
					Me.UnitTypeInfoList(CInt(Me.nUnitTypes)) = unitTypeInfo
				End If
			Next
			FileSystem.FileClose(New Integer() { CInt(num) })
			Dim num8 As Integer = 0
			Me.UnitTypeInfoList(num8).Manuf = "(Measured pumping units)"
			Me.UnitTypeInfoList(num8).Abbrev = "CUSTOM"
			Me.UnitTypeInfoList(num8).ShowNames = -1S
			Me.UnitTypeInfoList(num8).SortByNames = -1S
			Me.UnitTypeInfoList(num8).UnitType = -1S
			Me.UnitTypeInfoList = CType(Utils.CopyArray(CType(Me.UnitTypeInfoList, Array), New RSWIN_DESC.UnitTypeInfo(CInt((Me.nUnitTypes + 1S)) - 1) {}), RSWIN_DESC.UnitTypeInfo())
			comboBox = cboManufMenu
			comboBox.Items.Clear()
			num9 = 0S
			num10 = Me.nUnitTypes
			For num5 As Short = num9 To num10
				comboBox.Items.Add(Me.UnitTypeInfoList(CInt(num5)).Manuf)
			Next
		End Sub

		Private Sub cboManufMenu_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			Dim flag As Boolean = Me.ActiveControl Is Me.cboManufMenu
			Me.Control_SelectedIndexChanged(flag)
			Dim cboManufMenu As ComboBox = Me.cboManufMenu
			Me.cboManufMenu_Click_1(cboManufMenu.SelectedIndex, flag)
			Me.bManufMenuClicked = False
			Dim num As Integer
			Dim num2 As Integer
			Dim num3 As Integer
			If Operators.CompareString(RSWIN_DESC.rst.UnitID.Trim(), "", False) = 0 AndAlso flag AndAlso Me.cboManufMenu.SelectedIndex > 0 AndAlso Me.bRecPULoaded AndAlso Me.RecommendPUData(num, num2, num3) Then
				Me.SetRecommendedUnit(False)
			End If
			If Me.cboManufMenu.SelectedIndex = 0 Then
				Me.txtUnitID.Visible = False
			Else
				Me.txtUnitID.Visible = True
			End If
			Me.lblUnitID.Visible = Me.txtUnitID.Visible
		End Sub

		Private Sub GetUnitList(ByRef iFirstUnit As Short, ByRef nUnits As Short)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(Me.cboManufMenu.SelectedIndex)
			If num >= 0S Then
				Dim str As String = Strings.Trim(Me.UnitTypeInfoList(CInt(num)).Abbrev)
				Dim text As String
				FILEUTIL.LocateFile(str + "32.PUD", text, 0S, False, False, False, False)
				If Strings.Len(text) = 0 Then
					If Me.Visible Then
						If num = 0S Then
							Util.Errmsg(Me.sPUNotEntered)
						Else
							Util.Errmsg(Me.sPUNoInfo)
						End If
					End If
					Me.UnitData = New RSWIN_DESC.PUDataRec(0) {}
					Me.ClearUnitInfo(True)
				Else
					Dim num2 As Short = CShort(FileSystem.FreeFile())
					Dim pudataRec As RSWIN_DESC.PUDataRec
					FileSystem.FileOpen(CInt(num2), text, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(pudataRec))
					nUnits = CShort((FileSystem.LOF(CInt(num2)) / CLng(Strings.Len(pudataRec))))
					If Me.UnitTypeInfoList(CInt(num)).UnitType = -1S Then
						iFirstUnit = 2S
					Else
						iFirstUnit = 1S
					End If
					If nUnits < iFirstUnit Then
						Me.UnitData = Nothing
					Else
						Me.UnitData = New RSWIN_DESC.PUDataRec(CInt((nUnits + 1S)) - 1) {}
						Dim num3 As Short = 0S
						Dim num4 As Short = CShort(Information.UBound(Me.UnitData, 1))

							For num5 As Short = num3 To num4
								Me.UnitData(CInt(num5)).Initialize()
							Next
							Dim num6 As Short = 1S
							Dim num7 As Short = nUnits
							For num5 As Short = num6 To num7
								Dim fileNumber As Integer = CInt(num2)
								Dim unitData As RSWIN_DESC.PUDataRec() = Me.UnitData
								Dim num8 As Integer = CInt(num5)
								Dim valueType As ValueType = unitData(num8)
								FileSystem.FileGet(fileNumber, valueType, -1L)
								Dim unitData2 As RSWIN_DESC.PUDataRec() = Me.UnitData
								Dim num9 As Integer = num8
								Dim valueType2 As ValueType = valueType
								Dim pudataRec2 As RSWIN_DESC.PUDataRec
								unitData2(num9) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec2)
							Next

					End If
					FileSystem.FileClose(New Integer() { CInt(num2) })
				End If
			End If
		End Sub

		Private Sub FilterUnitList(iUnitType As Short, iFirst As Integer, iLast As Integer)
			Dim strB As String = ""
			If iUnitType = 0S Then
				Dim num As Short = CShort(iFirst)
				Dim num2 As Short = CShort(iLast)

					For num3 As Short = num To num2
						Dim text As String
						If Me.UnitData(CInt(num3)).Manuf <> Nothing And Not Information.IsDBNull(Me.UnitData(CInt(num3)).Manuf) Then
							text = Me.UnitData(CInt(num3)).Manuf.Trim()
						Else
							text = ""
						End If
						If text.Length = 0 Or text.CompareTo(strB) = 0 Then
							Me.UnitData(CInt(num3)).FileRecord = 0S
						Else
							Me.UnitData(CInt(num3)).FileRecord = 1S
						End If
					Next

			ElseIf Not Me.chkCustomPUDB.Checked Then
				Dim num4 As Short = CShort(iFirst)
				Dim num5 As Short = CShort(iLast)

					For num3 As Short = num4 To num5
						Me.UnitData(CInt(num3)).FileRecord = 1S
					Next

			Else
				Dim num6 As Short = CShort(iFirst)
				Dim num7 As Short = CShort(iLast)
				Dim text3 As String
				Dim num8 As Integer

					For num3 As Short = num6 To num7
						Me.UnitData(CInt(num3)).FileRecord = 0S
					Next
					Dim text2 As String = Strings.Trim(Me.UnitTypeInfoList(CInt(iUnitType)).Abbrev)
					text3 = Strings.Space(8192)
					num8 = Custom.CustomPumpingUnitLists_SelectRow(text2.Trim(), text3, False, "")

				Dim num9 As Short = CShort(text3.Length)
				If num9 > 0S And num8 <> 0 Then
					text3 = text3.Trim()
					Dim num3 As Short = 1S
					Dim num11 As Short
					Do
						Dim num10 As Short = -1S
						num11 = CShort(Strings.InStr(CInt(num3), text3, ",", CompareMethod.Binary))

							If num11 = 0S Then
								If Versioned.IsNumeric(Strings.Mid(text3, CInt(num3))) Then
									num10 = Conversions.ToShort(Strings.Mid(text3, CInt(num3)))
								End If
							ElseIf Versioned.IsNumeric(Strings.Mid(text3, CInt(num3), CInt((num11 - num3)))) Then
								num10 = Conversions.ToShort(Strings.Mid(text3, CInt(num3), CInt((num11 - num3))))
							End If
							If num10 > 0S And CInt(num10) <= Information.UBound(Me.UnitData, 1) Then
								Me.UnitData(CInt(num10)).FileRecord = 1S
							End If

						num3 = CShort((CInt(num11) + Strings.Len(",")))
					Loop While num11 <> 0S
				End If
			End If
		End Sub

		Private Sub lvwUnitList_ItemClick(eventSender As Object, e As EventArgs)
			Try
				Me.bUnitListClicked = True
				Dim unbalance As Single
				Try
					unbalance = RSWIN_DESC.rst.Unbalance
				Catch ex As Exception
				End Try
				Dim lvwUnitList As ListView = Me.lvwUnitList
				If lvwUnitList.SelectedItems.Count > 0 Then
					Dim listViewItem As ListViewItem = lvwUnitList.SelectedItems(0)
					If listViewItem IsNot Nothing Then
						Me.bUnitListClicked = (Me.ActiveControl Is Me.lvwUnitList)
						Me.lvwUnitList_ItemClick_1(listViewItem, Me.bUnitListClicked)
						Me.bUnitListClicked = False
					End If
					If Me.lvwUnitList Is Me.ActiveControl AndAlso (CDbl(Math.Abs(unbalance - RSWIN_DESC.rst.PU.Unbalance)) > 0.1 And unbalance <> 0F And (RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs))) Then
						Me.bUnbalancedAsked = False
						Dim dialogResult As DialogResult = MessageBox.Show(Me.sUpdateUnbalance, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
						Me.bUnbalancedAsked = True
						If dialogResult = DialogResult.Yes Then
							RSWIN_DESC.rst.Unbalance = RSWIN_DESC.rst.PU.Unbalance
							Me.txtUnbalance.Tag = "lee"
							Me.txtUnbalance.Text = Conversions.ToString(RSWIN_DESC.rst.Unbalance)
						Else
							RSWIN_DESC.rst.Unbalance = unbalance
							Me.txtUnbalance.Tag = "lee"
							Me.txtUnbalance.Text = Conversions.ToString(unbalance)
						End If
					End If
					Dim flag As Boolean = Me.ValidatePUData(True)
				End If
				If Me.lblMInLbs.Visible And Me.optCBDataType_1.Visible Then
					' The following expression was wrapped in a checked-expression
					Me.lblMInLbs.Left = Me.optCBDataType_1.Left + Me.optCBDataType_1.Width + 10
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub LoadUnitMenu(bClicked As Boolean)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(Me.cboManufMenu.SelectedIndex)
			If If((-If(((num = 0S) > False), 1S, 0S)), 1S, 0S) And (RSWIN_DESC.rst.IDEntered Or If((-If(((Operators.CompareString(RSWIN_DESC.rst.UnitID.Trim(), "", False) <> 0) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				Me.InitListView()
				Dim lvwUnitList As ListView = Me.lvwUnitList
				lvwUnitList.MultiSelect = False
				lvwUnitList.FullRowSelect = True
				lvwUnitList.Activation = ItemActivation.Standard
				Dim columns As ListView.ColumnHeaderCollection = lvwUnitList.Columns
				columns.Clear()
				columns.Add(Me.csHDR_MANUF, 105, HorizontalAlignment.Left)
				If Me.UnitTypeInfoList(CInt(num)).UnitType <> 10S Then
					Me.bHydraulic = False
					columns.Add(Me.csHDR_APIDES, 140, HorizontalAlignment.Left)
				Else
					Me.bHydraulic = True
					columns.Add(Me.csHDR_UNITDES, 140, HorizontalAlignment.Left)
				End If
				columns.Add(Me.csHDR_UNAME, 150, HorizontalAlignment.Left)
				columns.Add(Me.csHDR_OTHER, 130, HorizontalAlignment.Left)
				Me.iKEY_MANUF = 0
				Me.iKEY_APIDES = 1
				Me.iKEY_UNAME = 2
				Me.iKEY_OTHER = 3
				Dim expression As Boolean = Me.UnitTypeInfoList(CInt(num)).ShowNames <> 0S
				Dim expression2 As Boolean = Me.UnitTypeInfoList(CInt(num)).SortByNames <> 0S
				Dim num3 As Integer
				Dim num2 As Short = CShort(num3)
				Dim num5 As Integer
				Dim num4 As Short = CShort(num5)
				Me.GetUnitList(num2, num4)
				num5 = CInt(num4)
				num3 = CInt(num2)
				Dim num6 As Short = CShort((num5 - num3 + 1))
				If num6 > 0S Then
					Dim obj As Object = 3
					PUDATA1.SortPUnits(Me.UnitData, Me.uIdx, obj, num3, num5)
					Me.FilterUnitList(num, num3, num5)
					Dim num7 As Short = CShort(num3)
					Dim num8 As Short = CShort(num5)

						For num9 As Short = num7 To num8
							If Me.UnitData(Me.uIdx(CInt(num9))).FileRecord <> 0S Then
								Dim text As String = Strings.Trim(Me.UnitData(Me.uIdx(CInt(num9))).APIDesignation)
								Dim str As String = Strings.Trim(Me.UnitData(Me.uIdx(CInt(num9))).Manuf)
								Dim text2 As String = Strings.Trim(Me.UnitData(Me.uIdx(CInt(num9))).OtherInfo)
								Dim text3 As String = Strings.Trim(Me.UnitData(Me.uIdx(CInt(num9))).UnitName)
								Dim listViewItem As ListViewItem = Me.lvwUnitList.Items.Add(Strings.Trim(str))
								Dim subItems As ListViewItem.ListViewSubItemCollection = listViewItem.SubItems
								subItems.Add(Me.csKEY_APIDES).Text = text
								subItems.Add(Me.csKEY_UNAME).Text = text3
								subItems.Add(Me.csKEY_OTHER).Text = text2
							End If
						Next
						Return

				End If
			Else
				If num <= 0S Then
					Return
				End If
				Dim expression As Boolean = Me.UnitTypeInfoList(CInt(num)).ShowNames <> 0S
				Dim expression2 As Boolean = Me.UnitTypeInfoList(CInt(num)).SortByNames <> 0S
				Me.InitListView()
				Dim lvwUnitList2 As ListView = Me.lvwUnitList
				Dim columns2 As ListView.ColumnHeaderCollection = lvwUnitList2.Columns
				columns2.Clear()
				columns2.Add("", 0, HorizontalAlignment.Left)
				If Me.UnitTypeInfoList(CInt(num)).UnitType <> 10S Then
					Me.bHydraulic = False
					columns2.Add(Me.csHDR_APIDES, 140, HorizontalAlignment.Left)
				Else
					Me.bHydraulic = True
					columns2.Add(Me.csHDR_UNITDES, 140, HorizontalAlignment.Left)
				End If
				columns2.Add(Me.csHDR_UNAME, 200, HorizontalAlignment.Left)
				columns2.Add(Me.csHDR_OTHER, 158, HorizontalAlignment.Left)
				Me.iKEY_MANUF = 0
				Me.iKEY_APIDES = 1
				Me.iKEY_UNAME = 2
				Me.iKEY_OTHER = 3
				Dim num10 As Integer
				Dim num4 As Short = CShort(num10)
				Dim num11 As Integer
				Dim num2 As Short = CShort(num11)
				Me.GetUnitList(num4, num2)
				num11 = CInt(num2)
				num10 = CInt(num4)
				If Information.UBound(Me.UnitData, 1) > 0 Then
					Dim obj As Object = RuntimeHelpers.GetObjectValue(Interaction.IIf(expression2, 0, 1))
					PUDATA1.SortPUnits(Me.UnitData, Me.uIdx, obj, num10, num11)
					Me.FilterUnitList(num, num10, num11)
					Dim str2 As String = Strings.Trim(Me.UnitTypeInfoList(CInt(num)).Abbrev)
					Dim num12 As Short = CShort(num10)
					Dim num13 As Short = CShort(num11)

						For num9 As Short = num12 To num13
							If Me.UnitData(Me.uIdx(CInt(num9))).FileRecord <> 0S Then
								Dim text As String = Strings.Trim(Me.UnitData(Me.uIdx(CInt(num9))).APIDesignation)
								Dim text2 As String = Strings.Trim(Me.UnitData(Me.uIdx(CInt(num9))).OtherInfo)
								Dim text3 As String = Strings.Trim(Me.UnitData(Me.uIdx(CInt(num9))).UnitName)
								Dim tag As String = Conversions.ToString(Interaction.IIf(expression, text3, text))
								Dim listViewItem2 As ListViewItem = Me.lvwUnitList.Items.Add(str2 + Me.uIdx(CInt(num9)).ToString())
								listViewItem2.Tag = tag
								Dim subItems2 As ListViewItem.ListViewSubItemCollection = listViewItem2.SubItems
								subItems2.Add(Me.csKEY_APIDES).Text = text
								subItems2.Add(Me.csKEY_UNAME).Text = text3
								subItems2.Add(Me.csKEY_OTHER).Text = text2
							End If
						Next

				End If
			End If
		End Sub

		Private Sub LoadUnitMenu_Save(bClicked As Boolean)
			Dim num6 As Integer
			Dim num13 As Integer
			Dim obj6 As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim num2 As Short = CShort(Me.cboManufMenu.SelectedIndex)
				IL_11:
				num = 2
				If num2 <> 0S Then
					GoTo IL_324
				End If
				IL_1C:
				num = 3
				Me.InitListView()
				IL_25:
				num = 4
				Dim listView As ListView = Me.lvwUnitList
				IL_30:
				num = 5
				listView.MultiSelect = False
				IL_3B:
				num = 6
				listView.FullRowSelect = True
				IL_46:
				num = 7
				listView.Activation = ItemActivation.Standard
				IL_51:
				num = 8
				Dim columnHeaderCollection As ListView.ColumnHeaderCollection = listView.Columns
				IL_5D:
				num = 9
				columnHeaderCollection.Clear()
				IL_68:
				num = 10
				columnHeaderCollection.Add(Me.csHDR_MANUF, 50, HorizontalAlignment.Left)
				IL_7D:
				num = 11
				columnHeaderCollection.Add(Me.csHDR_APIDES, 50, HorizontalAlignment.Left)
				IL_92:
				num = 12
				columnHeaderCollection.Add(Me.csHDR_UNAME, 100, HorizontalAlignment.Left)
				IL_A7:
				num = 13
				columnHeaderCollection.Add(Me.csHDR_OTHER, 150, HorizontalAlignment.Left)
				IL_BF:
				num = 14
				Me.iKEY_MANUF = 0
				IL_CA:
				num = 15
				Me.iKEY_APIDES = 1
				IL_D5:
				num = 16
				Me.iKEY_UNAME = 2
				IL_E0:
				num = 17
				Me.iKEY_OTHER = 3
				IL_EB:
				columnHeaderCollection = Nothing
				IL_EE:
				listView = Nothing
				IL_F1:
				num = 20
				Dim flag As Boolean = Me.UnitTypeInfoList(CInt(num2)).ShowNames <> 0S
				IL_10B:
				num = 21
				Dim expression As Boolean = Me.UnitTypeInfoList(CInt(num2)).SortByNames <> 0S
				IL_125:
				num = 22
				Dim obj As Object
				Dim num3 As Short = Conversions.ToShort(obj)
				Dim obj2 As Object
				Dim num4 As Short = Conversions.ToShort(obj2)
				Me.GetUnitList(num3, num4)
				obj2 = num4
				obj = num3
				IL_157:
				num = 23
				Dim num5 As Short = 0S
				IL_15D:
				ProjectData.ClearProjectError()
				num6 = 1
				IL_165:
				num = 25
				num5 = Conversions.ToShort(Operators.AddObject(Operators.SubtractObject(obj2, obj), 1))
				IL_183:
				ProjectData.ClearProjectError()
				num6 = 0
				IL_18B:
				num = 27
				If num5 <= 0S Then
					GoTo IL_6F2
				End If
				IL_196:
				num = 28
				Dim obj3 As Object = 3
				Dim array As Integer()
				PUDATA1.SortPUnits(Me.UnitData, array, obj3, Conversions.ToInteger(obj), Conversions.ToInteger(obj2))
				IL_1BF:
				num = 29
				Me.FilterUnitList(num2, Conversions.ToInteger(obj), Conversions.ToInteger(obj2))
				IL_1D9:
				num = 30
				Dim num7 As Short = Conversions.ToShort(obj)
				Dim num8 As Short = Conversions.ToShort(obj2)
				For num9 As Short = num7 To num8
					IL_1F4:
					num = 31
					If Me.UnitData(array(CInt(num9))).FileRecord <> 0S Then
						IL_213:
						num = 32
						Dim text As String = Strings.Trim(Me.UnitData(array(CInt(num9))).APIDesignation)
						IL_233:
						num = 33
						Dim str As String = Strings.Trim(Me.UnitData(array(CInt(num9))).Manuf)
						IL_253:
						num = 34
						Dim text2 As String = Strings.Trim(Me.UnitData(array(CInt(num9))).OtherInfo)
						IL_273:
						num = 35
						Dim text3 As String = Strings.Trim(Me.UnitData(array(CInt(num9))).UnitName)
						IL_293:
						num = 36
						Dim listViewItem As ListViewItem = Me.lvwUnitList.Items.Add(Strings.Trim(str))
						IL_2B0:
						num = 37
						Dim listViewSubItemCollection As ListViewItem.ListViewSubItemCollection = listViewItem.SubItems
						IL_2BD:
						num = 38
						listViewSubItemCollection.Add(Me.csKEY_APIDES).Text = text
						IL_2D5:
						num = 39
						listViewSubItemCollection.Add(Me.csKEY_UNAME).Text = text3
						IL_2ED:
						num = 40
						listViewSubItemCollection.Add(Me.csKEY_OTHER).Text = text2
						IL_305:
						listViewSubItemCollection = Nothing
						IL_308:
						listViewItem = Nothing
					End If
					IL_30B:
					num = 44
				Next
				IL_31F:
				GoTo IL_8E0
				IL_324:
				num = 47
				If num2 <= 0S Then
					GoTo IL_6F2
				End If
				IL_330:
				num = 48
				flag = (Me.UnitTypeInfoList(CInt(num2)).ShowNames <> 0S)
				IL_34A:
				num = 49
				expression = (Me.UnitTypeInfoList(CInt(num2)).SortByNames <> 0S)
				IL_364:
				num = 50
				Me.InitListView()
				IL_36E:
				num = 51
				Dim listView2 As ListView = Me.lvwUnitList
				IL_37A:
				num = 52
				Dim columnHeaderCollection2 As ListView.ColumnHeaderCollection = listView2.Columns
				IL_387:
				num = 53
				columnHeaderCollection2.Clear()
				IL_392:
				num = 54
				columnHeaderCollection2.Add("", 0, HorizontalAlignment.Left)
				IL_3A5:
				num = 55
				columnHeaderCollection2.Add(Me.csHDR_APIDES, 75, HorizontalAlignment.Left)
				IL_3BA:
				num = 56
				columnHeaderCollection2.Add(Me.csHDR_UNAME, 200, HorizontalAlignment.Left)
				IL_3D2:
				num = 57
				columnHeaderCollection2.Add(Me.csHDR_OTHER, 150, HorizontalAlignment.Left)
				IL_3EA:
				num = 58
				Me.iKEY_MANUF = 0
				IL_3F5:
				num = 59
				Me.iKEY_APIDES = 1
				IL_400:
				num = 60
				Me.iKEY_UNAME = 2
				IL_40B:
				num = 61
				Me.iKEY_OTHER = 3
				IL_416:
				columnHeaderCollection2 = Nothing
				IL_419:
				listView2 = Nothing
				IL_41C:
				num = 64
				Dim obj4 As Object
				num4 = Conversions.ToShort(obj4)
				Dim obj5 As Object
				num3 = Conversions.ToShort(obj5)
				Me.GetUnitList(num4, num3)
				obj5 = num3
				obj4 = num4
				IL_44E:
				num = 65
				If Information.UBound(Me.UnitData, 1) <= 0 Then
					GoTo IL_6F2
				End If
				IL_464:
				num = 66
				obj3 = RuntimeHelpers.GetObjectValue(Interaction.IIf(expression, 0, 1))
				PUDATA1.SortPUnits(Me.UnitData, array, obj3, Conversions.ToInteger(obj4), Conversions.ToInteger(obj5))
				IL_49E:
				num = 67
				Me.FilterUnitList(num2, Conversions.ToInteger(obj4), Conversions.ToInteger(obj5))
				IL_4B8:
				num = 68
				Dim str2 As String = Strings.Trim(Me.UnitTypeInfoList(CInt(num2)).Abbrev)
				IL_4D5:
				num = 69
				Dim num10 As Short = Conversions.ToShort(obj4)
				Dim num11 As Short = Conversions.ToShort(obj5)
				For num9 As Short = num10 To num11
					IL_4F0:
					num = 70
					If Me.UnitData(array(CInt(num9))).FileRecord <> 0S Then
						IL_50F:
						num = 71
						Dim text As String = Strings.Trim(Me.UnitData(array(CInt(num9))).APIDesignation)
						IL_52F:
						num = 72
						Dim text2 As String = Strings.Trim(Me.UnitData(array(CInt(num9))).OtherInfo)
						IL_54F:
						num = 73
						Dim text3 As String = Strings.Trim(Me.UnitData(array(CInt(num9))).UnitName)
						IL_56F:
						num = 74
						Dim text4 As String = Conversions.ToString(Interaction.IIf(flag, text3, text))
						IL_584:
						num = 75
						Dim listViewItem2 As ListViewItem = Me.lvwUnitList.Items.Add(str2 + array(CInt(num9)).ToString())
						IL_5AF:
						num = 76
						listViewItem2.Tag = Strings.Trim(str2 + array(CInt(num9)).ToString())
						IL_5D4:
						num = 77
						Dim listViewSubItemCollection2 As ListViewItem.ListViewSubItemCollection = listViewItem2.SubItems
						IL_5E1:
						num = 78
						listViewSubItemCollection2.Add(Me.csKEY_APIDES).Text = text
						IL_5F9:
						num = 79
						listViewSubItemCollection2.Add(Me.csKEY_UNAME).Text = text3
						IL_611:
						num = 80
						listViewSubItemCollection2.Add(Me.csKEY_OTHER).Text = text2
						IL_629:
						listViewSubItemCollection2 = Nothing
						IL_62C:
						listViewItem2 = Nothing
					End If
					IL_62F:
					num = 84
				Next
				IL_643:
				num = 85
				Dim columnHeaderCollection3 As ListView.ColumnHeaderCollection = Me.lvwUnitList.Columns
				IL_654:
				num = 86
				If Not flag Then
					GoTo IL_6A4
				End If
				IL_65B:
				num = 87
				columnHeaderCollection3(1).Text = Me.csHDR_UNAME
				IL_672:
				num = 88
				columnHeaderCollection3(1).Width = columnHeaderCollection3(3).Width
				IL_690:
				num = 89
				columnHeaderCollection3(3).Width = 0
				IL_6A2:
				GoTo IL_6EF
				IL_6A4:
				num = 91
				IL_6A8:
				num = 92
				columnHeaderCollection3(1).Text = Me.csHDR_APIDES
				IL_6BF:
				num = 93
				columnHeaderCollection3(1).Width = columnHeaderCollection3(2).Width
				IL_6DD:
				num = 94
				columnHeaderCollection3(2).Width = 0
				IL_6EF:
				columnHeaderCollection3 = Nothing
				IL_6F2:
				IL_6F7:
				GoTo IL_8E0
				IL_6FC:
				Dim num12 As Integer = num13 + 1
				num13 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num12)
				IL_89C:
				GoTo IL_8D5
				IL_89E:
				num13 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_8B1:
			Catch obj7 When endfilter(TypeOf obj6 Is Exception And num6 <> 0 And num13 = 0)
				Dim ex As Exception = CType(obj7, Exception)
				GoTo IL_89E
			End Try
			IL_8D5:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_8E0:
			If num13 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub cboCrankRotation_Click_1(iListIndex As Short, Clicked As Boolean)
			Dim pu As RSWIN_DESC.PUDataRec
			pu.Initialize()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			pu = rst.PU
			If iListIndex < 0S Then
				pu.CrankRotation = 1S
				If Clicked Then
					ini.SaveDataValue("CrankRotation", DBNull.Value)
				End If
			Else
				Dim cboCrankRotation As ComboBox = Me.cboCrankRotation
				If iListIndex = 0S Then
					pu.CrankRotation = 1S
				Else
					pu.CrankRotation = -1S
				End If
				If Clicked Then
					ini.SaveDataValue("CrankRotation", pu.CrankRotation)
				End If
			End If
			rst.Rotation = pu.CrankRotation
			rst.PU = pu
		End Sub

		Private Sub ClearUnitInfo(ClearAll As Boolean)
			Me.cboCrankHole.Enabled = False
			Me.cboCrankHole.Items.Clear()
			Me.lblCalcStroke.Text = ""
			If ClearAll Then
				Me.lvwUnitList.Enabled = False
				Me.txtUnbalance.Enabled = False
				Me.bCrankRotationClicked = False
				Me.cboCrankRotation.SelectedIndex = -1
				Return
			End If
		End Sub

		Private Sub optCBSource_Click_1(Index As PUData.CBSource, Value As Boolean, Clicked As Boolean)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.cmdCBApplet.Enabled = False
			Me.cmdReadCBLFile.Enabled = False
			Select Case Index
				Case PUData.CBSource.cbsUnknown, PUData.CBSource.cbsCBDataFile
					Me.optCBDataType_3.Checked = Value
					RSWIN_DESC.rst.UnknownM = Value
					If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Or (RSWIN_DESC.rst.PU.UnitType = 11S And RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
						RSWIN_DESC.rst.bUnknownUnbalance = Value
					End If
					RSWIN_DESC.rst.CBDataType = 0S
					If Value Then
						Me.SetCounterbalanceTag()
						Me.txtCounterbalance.Text = ""
						Dim txtCounterbalance As TextBox = Me.txtCounterbalance
						Dim lblMInLbs As Label = Me.lblMInLbs
						Me.TextBox_Change(txtCounterbalance, lblMInLbs)
						Me.lblMInLbs = lblMInLbs
						Me.txtCounterbalance = txtCounterbalance
						Me.txtCounterbalance.Enabled = False
					End If
					ini.SaveDataValue("UnknownM", RSWIN_DESC.rst.UnknownM)
					If Value Then
						RSWIN_DESC.rst.UnknownM = True
						Me.txtCounterbalance.Enabled = False
						RSWIN_DESC.rst.CBDataFile = ""
						If Strings.Len(Strings.Trim(RSWIN_DESC.rst.CBDataFile)) > 0 Then
							Me.lblCBDataFile.Text = "File:  (" + Util.FileName(RSWIN_DESC.rst.CBDataFile) + ")"
							Me.lblCBDataFile.Visible = True
						Else
							Me.lblCBDataFile.Text = Me.sFileNoneSelected
							Me.lblCBDataFile.Visible = True
						End If
					End If
				Case PUData.CBSource.cbsEntered
					Me.optCBDataType_1.Checked = Value
					If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Or (RSWIN_DESC.rst.PU.UnitType = 11S And RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
						RSWIN_DESC.rst.bUnknownUnbalance = False
					End If
					If Me.optCBDataType_1.Checked Then
						RSWIN_DESC.rst.CBDataType = 1S
						Me.txtCounterbalance.Enabled = True
					Else
						Me.txtCounterbalance.Enabled = False
					End If
				Case CType(5, PUData.CBSource)
					Me.optCBDataType_5.Checked = Value
					Me.cmdCBApplet.Enabled = True
					If Me.optCBDataType_5.Checked Then
						RSWIN_DESC.rst.CBDataType = 1S
					End If
			End Select
			ini.SaveDataValue("CBDataType", RSWIN_DESC.rst.CBDataType)
			Me.miCBSource = Index
			Me.txtCounterbalance.Enabled = Conversions.ToBoolean(Interaction.IIf(Me.miCBSource = PUData.CBSource.cbsEntered, True, False))
			If Clicked Then
				Select Case Me.miCBSource
					Case PUData.CBSource.cbsUnknown
						Me.SetCounterbalanceTag()
						Me.txtCounterbalance.Text = ""
						Dim txtCounterbalance As TextBox = Me.txtCounterbalance
						Dim lblMInLbs As Label = Me.lblMInLbs
						Me.TextBox_Change(txtCounterbalance, lblMInLbs)
						Me.lblMInLbs = lblMInLbs
						Me.txtCounterbalance = txtCounterbalance
						RSWIN_DESC.rst.UnknownM = True
					Case PUData.CBSource.cbsEntered
						RSWIN_DESC.rst.UnknownM = False
				End Select
				ini.SaveDataValue("UnknownM", RSWIN_DESC.rst.UnknownM)
			End If
			Me.optCBDataType_Click_1(CInt(Index), If((-If((Value > False), 1, 0)), 1, 0), If((-If((Clicked > False), 1, 0)), 1, 0))
		End Sub

		Public Sub cboManufMenu_Click_1(iListIndex As Integer, bClicked As Boolean)
			Dim flag As Boolean = Me.ActiveControl Is Me.cboManufMenu
			If iListIndex = -1 Then
				Me.ClearUnitInfo(True)
			Else
				If Operators.ConditionalCompareObjectEqual(Me.cboManufMenu.SelectedItem, "(Measured pumping units)", False) Then
					Me.lblUnitID.Text = Me.sUnitID
					Me.txtUnitID.Enabled = True
					Me.lblUnitID.Enabled = True
					Me.lblAPI.Enabled = False
				Else
					Me.lblUnitID.Text = Me.sUnitID
					Me.txtUnitID.Enabled = True
					Me.lblUnitID.Enabled = True
					Me.lblAPI.Enabled = True
					Me.txtUnitID.Visible = True
				End If
				Me.ClearUnitInfo(False)
				Me.LoadUnitMenu(bClicked)
				If bClicked Then
					RSWIN_DESC.rst.IDEntered = If((-If((iListIndex >= 0 > False), 1S, 0S)), 1S, 0S)
				ElseIf iListIndex >= 0 AndAlso bClicked Then
					RSWIN_DESC.rst.IDEntered = If((-If((iListIndex >= 0 > False), 1S, 0S)), 1S, 0S)
				End If
				Me.LoadPURecommendation()
				If Me.lvwUnitList.Items.Count > 0 Then
					Me.lvwUnitList.Enabled = True
				End If
				ini.SaveDataValue("ManufName", Me.cboManufMenu.Items(iListIndex).ToString())
				If bClicked Then
					Me.optCBSource_Click_1(PUData.CBSource.cbsUnknown, True, False)
					Me.txtUnitID.Text = ""
				End If
				If Operators.CompareString(RSWIN_DESC.rst.UnitID.Trim(), "", False) = 0 AndAlso (If((-If((Me.cboManufMenu.SelectedIndex > 0 > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.NewData(6) And If((-If((Me.bRecPULoaded > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Me.SetRecommendedUnit(False)
				End If
			End If
			Dim flag2 As Boolean = Me.ValidatePUData(True)
			If bClicked Then
				If iListIndex >= 0 Then
					Dim text As String = Me.UnitTypeInfoList(iListIndex).Abbrev.Trim()
					If Operators.CompareString(text, "CUSTOM", False) <> 0 And Operators.CompareString(text, "", False) <> 0 Then
						Dim pudataRec As RSWIN_DESC.PUDataRec
						pudataRec.Initialize()
						Dim flag3 As Boolean = PUDATA1.ReadPUData(text + "1", pudataRec, False, False)
						If flag3 Then
							If flag Then
								RSWIN_DESC.rst.Unbalance = RSWIN_DESC.rst.PU.Unbalance
							End If
							Me.cboCrankRotation.Enabled = (Not pudataRec.RequiredRotation <> 0S)
							If Not Me.cboCrankRotation.Enabled Or Operators.CompareString(Me.txtUnitID.Text, "", False) = 0 Or Operators.CompareString(RSWIN_DESC.rst.UnitID, "", False) = 0 Then
								Me.SetCrankRotationCombo(pudataRec.CrankRotation)
							End If
							Me.pnlHydraulic.Visible = False
							Me.grpCounterBalance.Visible = True
							Select Case pudataRec.UnitType
								Case 6S
									Me.optCBDataType_3.Text = Me.sUnknownAirTankPressure
									Me.optCBDataType_1.Text = Me.sExistingAirTankPressure
									Me.txtCounterbalance.Tag = "gee"
									Me.optCBDataType_5.Enabled = False
									Me.optCBDataType_5.Text = Me.sUseXBALInformation
									Me.txtCounterbalance.Visible = True
									Me.lblMInLbs.Visible = True
									Me.lblMInLbs.Left = Me.optCBDataType_1.Left + Me.optCBDataType_1.Width + 10
									Me.lblCounterbalance_Disabled.Visible = True
									Me.pnlCombinationBeamCrank.Visible = False
									GoTo IL_5A9
								Case 7S, 10S
									Me.optCBDataType_3.Text = Me.sUnknownCounterbalanceWeight
									Me.optCBDataType_1.Text = Me.sExistingCounterbalanceWeight
									Me.txtCounterbalance.Tag = "lee"
									Me.optCBDataType_5.Enabled = False
									Me.optCBDataType_5.Text = Me.sUseXBALInformation
									Me.txtCounterbalance.Visible = True
									Me.lblMInLbs.Visible = True
									Me.lblMInLbs.Left = Me.optCBDataType_1.Left + Me.optCBDataType_1.Width + 10
									Me.lblCounterbalance_Disabled.Visible = True
									Me.pnlCombinationBeamCrank.Visible = False
									If pudataRec.UnitType = 10S Then
										Me.pnlHydraulic.Visible = True
										Me.grpCounterBalance.Visible = False
										GoTo IL_5A9
									End If
									GoTo IL_5A9
								Case 8S
									Me.optCBDataType_3.Text = Me.sUnknownCounterbalanceData
									Me.optCBDataType_1.Text = Me.sExistingStructuralUnbalance
									Me.txtCounterbalance.Tag = "lee"
									Me.optCBDataType_5.Enabled = True
									Me.optCBDataType_5.Text = Me.sUseXBALInformation
									Me.txtCounterbalance.Visible = False
									Me.lblMInLbs.Visible = False
									Me.lblCounterbalance_Disabled.Visible = False
									Me.pnlCombinationBeamCrank.Visible = False
									GoTo IL_5A9
							End Select
							Me.optCBDataType_3.Text = Me.sUnknownMCM
							Me.optCBDataType_1.Text = Me.sExistingMaximumCounterbalanceMoment
							Me.txtCounterbalance.Tag = "Lee"
							Me.optCBDataType_5.Enabled = True
							Me.optCBDataType_5.Text = Me.sUseXBALInformation
							Me.txtCounterbalance.Visible = True
							Me.lblMInLbs.Visible = True
							Me.lblMInLbs.Left = Me.optCBDataType_1.Left + Me.optCBDataType_1.Width + 10
							Me.lblCounterbalance_Disabled.Visible = True
							If pudataRec.UnitType = 9S Then
								Me.SetUnbalanceVisible(False)
							Else
								Me.SetUnbalanceVisible(True)
							End If
							Me.pnlCombinationBeamCrank.Visible = False
							IL_5A9:
							Me.SetCBMTooltipText()
							Me.lblMInLbs.Text = ""
						Else
							Me.cboCrankRotation.Enabled = True
							Me.optCBDataType_5.Enabled = True
						End If
						If Operators.CompareString(RSWIN_DESC.rst.UnitID.Trim(), "", False) <> 0 Then
							Dim unitID As String = RSWIN_DESC.rst.UnitID
							Dim num As Integer = 0
							Dim text2 As String
							PUDATA1.ParseUnitID(unitID, text2, num)
							If Operators.CompareString(text, text2, False) <> 0 Then
								RSWIN_DESC.rst.UnitID = ""
							End If
						End If
					End If
				Else
					Me.cboCrankRotation.Enabled = True
					Me.optCBDataType_5.Enabled = True
				End If
				Return
			End If
		End Sub

		Public Sub LoadPURecommendation()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim obj As Object
			If rst.SPMEntered <> 0S Then
				obj = False
			Else
				obj = True
				If Not rst.gbCalcTargetBFPD AndAlso (rst.SPM = 0F And rst.TargetBFPD = 0F) Then
					obj = False
				End If
			End If
			If Me.cboManufMenu.SelectedIndex <= 0 Then
				obj = False
			End If
			Dim text As String = ""
			If Conversions.ToBoolean(obj) Then
				Me.PopulateRecPUAL()
				Dim obj2 As Object
				Dim num As Integer = Conversions.ToInteger(obj2)
				Dim obj3 As Object
				Dim num2 As Integer = Conversions.ToInteger(obj3)
				Dim obj4 As Object
				Dim num3 As Integer = Conversions.ToInteger(obj4)
				Dim flag As Boolean = Me.RecommendPUData(num, num2, num3)
				obj4 = num3
				obj3 = num2
				obj2 = num
				If flag Then
					Dim str As String = Util.Format(obj2)
					Dim obj5 As Object = Operators.NegateObject(obj3)
					Dim str2 As String = Util.Format(obj5)
					Dim obj6 As Object = Operators.NegateObject(obj4)
					text = str + str2 + Util.Format(obj6)
				End If
			End If
			If Strings.Len(text) = 0 Then
				Me.cmdUnitSizeRecommendation.Text = Me.sUnitSizeRecommendation
				Me.cmdUnitSizeRecommendation.Enabled = False
			Else
				Me.cmdUnitSizeRecommendation.Text = Me.sSelectUnitSizeRecommendation + ": " + text
				Me.cmdUnitSizeRecommendation.Enabled = True
			End If
			Me.bRecPULoaded = True
		End Sub

		Private Sub SetRecommendedUnit(Optional bRecommendationClicked As Boolean = False)
			Dim num As Integer = -1
			Dim flag As Boolean = True
			Try
				Dim num2 As Integer
				Dim num3 As Integer
				Dim num4 As Integer
				If Me.RecommendPUData(num2, num3, num4) Then
					Dim obj As Object = 2
					Dim array As Integer()
					PUDATA1.SortPUnits(Me.UnitData, array, obj, Information.LBound(Me.UnitData, 1), Information.UBound(Me.UnitData, 1))
					Dim unit As RSWIN_DESC.PUDataRec
					unit.GearboxRating = CSng(num2)
					unit.StructRating = CSng(num3)
					unit.MaxStroke = CSng(num4)
					Dim num5 As Integer = Information.LBound(Me.UnitData, 1)
					Dim num6 As Integer = Information.UBound(Me.UnitData, 1)
					Dim num7 As Integer = num5
					Dim num8 As Integer = num6
					Dim i As Integer = num7
					While i <= num8
						Dim obj2 As Object = PUDATA1.ComparePU(unit, Me.UnitData(array(i)), 2)
						If Operators.ConditionalCompareObjectEqual(obj2, 0S, False) Then
							Exit While
						End If
						If Operators.ConditionalCompareObjectEqual(obj2, -1S, False) Then
							If i > num5 Then
								i -= 1
								Exit While
							End If
							Exit While
						Else
							i += 1
						End If
					End While
					Dim num9 As Integer = i
					Dim flag2 As Boolean
					Dim num11 As Single
					If unit.GearboxRating = Me.UnitData(array(i)).GearboxRating And unit.StructRating = Me.UnitData(array(i)).StructRating Then
						flag2 = False
					ElseIf unit.MaxStroke = Me.UnitData(array(i)).MaxStroke Then
						flag2 = False
					Else
						Dim unitData As RSWIN_DESC.PUDataRec() = Me.UnitData
						Dim num10 As Integer = array(i)
						Dim flag3 As Boolean = False
						flag2 = Not Me.CheckCrankHoles(unit, unitData(num10), num, num11, flag3)
					End If
					If flag2 Then
						Dim num12 As Integer = num5
						Dim num13 As Integer = num6
						i = num12
						While i <= num13
							Dim obj3 As Object = PUDATA1.ComparePU(unit, Me.UnitData(array(i)), 4)
							If Operators.ConditionalCompareObjectEqual(obj3, 0S, False) Then
								Exit While
							End If
							If Operators.ConditionalCompareObjectEqual(obj3, -1S, False) Then
								If i > num5 Then
									i -= 1
									Exit While
								End If
								Exit While
							Else
								i += 1
							End If
						End While
						If(Me.UnitData(array(i)).MaxStroke > unit.MaxStroke And Me.UnitData(array(num9)).MaxStroke > unit.MaxStroke And Me.UnitData(array(i)).MaxStroke > Me.UnitData(array(num9)).MaxStroke) Or Me.UnitData(array(i)).MaxStroke = Me.UnitData(array(num9)).MaxStroke Then
							i = num9
							flag2 = False
						End If
					End If
					If(unit.MaxStroke > Me.UnitData(array(i)).MaxStroke And Not flag2) AndAlso i - 1 >= num5 Then
						Dim flag4 As Boolean = True
						Dim num14 As Integer = i
						While flag4
							Dim flag5 As Boolean = Me.UnitData(array(num14)).GearboxRating = Me.UnitData(array(num14 - 1)).GearboxRating
							Dim flag6 As Boolean = Me.UnitData(array(num14)).StructRating = Me.UnitData(array(num14 - 1)).StructRating
							If(flag5 AndAlso flag6) And unit.MaxStroke > Me.UnitData(array(num14)).MaxStroke And Me.UnitData(array(num14 - 1)).MaxStroke > Me.UnitData(array(num14)).MaxStroke Then
								i = num14 - 1
							Else
								flag4 = False
							End If
							If flag4 And num14 - 1 >= num5 Then
								num14 -= 1
							Else
								flag4 = False
							End If
						End While
					End If
					If i > num6 Then
						i = num6
					End If
					Me.SetUnit(array(i), True)
					If bRecommendationClicked Or Me.cboManufMenu Is Me.ActiveControl Then
						Try
							Me.txtUnbalance.Text = Conversions.ToString(Me.UnitData(array(i)).Unbalance)
						Catch ex As Exception
						End Try
					End If
					If unit.MaxStroke <> Me.UnitData(array(i)).MaxStroke Then
						Dim unitData2 As RSWIN_DESC.PUDataRec() = Me.UnitData
						Dim num15 As Integer = array(i)
						Dim flag3 As Boolean = True
						Dim flag7 As Boolean = Me.CheckCrankHoles(unit, unitData2(num15), num, num11, flag3)
						If flag7 And num <> -1 Then
							Me.cboCrankHole.SelectedIndex = num
						End If
					End If
					If flag Then
						Try
							If unit.StructRating > Me.UnitData(array(i)).StructRating Then
								Dim num16 As Integer = 0
								Dim structRating As Single = Me.UnitData(array(i)).StructRating
								Dim maxStroke As Single = Me.UnitData(array(i)).MaxStroke
								Dim gearboxRating As Single = Me.UnitData(array(i)).GearboxRating
								Dim num17 As Single = structRating
								obj = 5
								PUDATA1.SortPUnits(Me.UnitData, array, obj, Information.LBound(Me.UnitData, 1), Information.UBound(Me.UnitData, 1))
								num5 = Information.LBound(Me.UnitData, 1)
								num6 = Information.UBound(Me.UnitData, 1)
								Dim flag8 As Boolean = True
								Dim num18 As Integer = -1
								While flag8
									num16 += 1
									Dim num19 As Integer = -1
									Dim num20 As Integer = num6
									Dim num21 As Integer = num5
									i = num20
									While i >= num21
										If Me.UnitData(array(i)).StructRating > num17 And Me.UnitData(array(i)).StructRating >= unit.StructRating Then
											num17 = Me.UnitData(array(i)).StructRating
											num19 = i
											Exit While
										End If
										i += -1
									End While
									If num19 = -1 Then
										flag8 = False
									Else
										flag8 = True
										Dim num22 As Integer = num5
										Dim num23 As Integer = num6
										i = num22
										While i <= num23
											If Me.UnitData(array(i)).StructRating = num17 Then
												If(Me.UnitData(array(i)).GearboxRating = unit.GearboxRating And Me.UnitData(array(i)).MaxStroke = unit.MaxStroke) Or (Me.UnitData(array(i)).GearboxRating = gearboxRating And Me.UnitData(array(i)).MaxStroke = maxStroke) Then
													num18 = i
													flag8 = False
													Exit While
												End If
												If(Me.UnitData(array(i)).GearboxRating >= unit.GearboxRating And Me.UnitData(array(i)).MaxStroke >= unit.MaxStroke) Or (Me.UnitData(array(i)).GearboxRating >= gearboxRating And Me.UnitData(array(i)).MaxStroke >= maxStroke) Then
													num18 = i
													flag8 = False
												End If
											End If
											i += 1
										End While
									End If
									If num16 > 10 Then
										flag8 = False
									End If
								End While
								If num18 <> -1 AndAlso Me.UnitData(array(num18)).GearboxRating = gearboxRating Then
									Me.SetUnit(array(num18), True)
									Try
										If bRecommendationClicked Or Me.cboManufMenu Is Me.ActiveControl Then
											Me.txtUnbalance.Text = Conversions.ToString(Me.UnitData(array(i)).Unbalance)
										End If
										If unit.MaxStroke <> Me.UnitData(array(num18)).MaxStroke Then
											Dim unitData3 As RSWIN_DESC.PUDataRec() = Me.UnitData
											Dim num24 As Integer = array(num18)
											Dim flag3 As Boolean = True
											Dim flag7 As Boolean = Me.CheckCrankHoles(unit, unitData3(num24), num, num11, flag3)
											If flag7 And num <> -1 Then
												Me.cboCrankHole.SelectedIndex = num
											End If
										End If
									Catch ex2 As Exception
									End Try
								End If
							End If
						Catch ex3 As Exception
						End Try
					End If
					RSWIN_DESC.frmMain.ToolbarButtonSetState(16, True)
				End If
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub ShowManuf()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If(rst.IDEntered And If((-If((rst.UnitID.Length > 0 > False), 1S, 0S)), 1S, 0S) And If((-If((Strings.InStr(rst.UnitID, ":nil", CompareMethod.Binary) <= 0 > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				Dim unitID As String = rst.UnitID
				Dim num As Integer = 0
				Dim text As String
				PUDATA1.ParseUnitID(unitID, text, num)
				If Strings.InStr(rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 Then
					Me.bManufMenuClicked = False
					Me.cboManufMenu.SelectedIndex = 0
				Else
					Dim num2 As Short = 0S
					Dim num3 As Short = Me.nUnitTypes
					For num4 As Short = num2 To num3
						Try
							If Operators.CompareString(Strings.Trim(Me.UnitTypeInfoList(CInt(num4)).Abbrev), text, False) = 0 Then
								Me.bManufMenuClicked = False
								Me.cboManufMenu.SelectedIndex = CInt(num4)
								Exit Try
							End If
						Catch ex As Exception
						End Try
					Next
				End If
			Else
				Me.bManufMenuClicked = False
				Dim num5 As Integer
				Try
					num5 = Me.cboManufMenu.Items.IndexOf("Lufkin Conventional - New               ")
					If num5 = -1 Then
						num5 = 0
					End If
				Catch ex2 As Exception
					num5 = 0
				End Try
				Dim sDefaultName As String = "MostCommonPumpingUnitType"
				Dim vNotPresentDefault As Object = num5
				Dim flag As Boolean = False
				Dim num6 As Integer = Conversions.ToInteger(ini.GetDefault(sDefaultName, vNotPresentDefault, flag))
				If num6 > 0 Then
					' The following expression was wrapped in a checked-expression
					Me.cboManufMenu.SelectedIndex = num6 + 1
				Else
					Me.cboManufMenu.SelectedIndex = num5
				End If
			End If
		End Sub

		Private Sub CheckUnitType()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.Iart = rst.PU.ArtInertia
			If rst.PU.UnitType = 6S Or rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Then
				rst.Irot = Conversions.ToSingle(Nothing)
				rst.Iart = Conversions.ToSingle(Nothing)
			ElseIf rst.Iart = 0F Then
				rst.Iart = Conversions.ToSingle(Nothing)
			End If
		End Sub

		Private Sub lvwUnitList_ItemClick_1(item As ListViewItem, bClicked As Boolean)
			Dim flag As Boolean = Me.ActiveControl Is Me.lvwUnitList
			Dim num As Integer = 0
			Dim num2 As Integer = Me.lvwUnitList.Items.Count - 1
			For i As Integer = num To num2
				Me.lvwUnitList.Items(i).BackColor = Color.White
				Me.lvwUnitList.Items(i).ForeColor = Color.Black
			Next
			If Me.lvwUnitList.SelectedItems.Count = 0 Then
				Me.lvwUnitList.Items(Me.GetIndexFromText(item.Text)).Selected = True
			ElseIf Me.lvwUnitList.SelectedItems(0) IsNot item Then
				Me.lvwUnitList.SelectedItems.Clear()
				Me.lvwUnitList.Items(item.Text).Selected = True
			End If
			Me.lvwUnitList.SelectedItems(0).EnsureVisible()
			Me.lvwUnitList.SelectedItems(0).Focused = True
			Me.lvwUnitList.SelectedItems(0).BackColor = Color.Gray
			Me.lvwUnitList.SelectedItems(0).ForeColor = Color.White
			Try
				Me.lblAPI.Text = Me.csHDR_APIDES + Strings.Trim(item.SubItems(Me.iKEY_APIDES).Text)
			Catch ex As Exception
				Me.lblAPI.Text = ""
			End Try
			If item Is Nothing Then
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.UnitID = ""
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				pu = rst.PU
				pu.APIDesignation = ""
				pu.UnitName = ""
				pu.OtherInfo = ""
				pu.CrankHole = 0S
				rst.PU = pu
				If bClicked Then
					ini.SaveDataValue("UnitName", DBNull.Value)
					ini.SaveDataValue("UnitID", DBNull.Value)
					ini.SaveDataValue("IDEntered", DBNull.Value)
					ini.SaveDataValue("CrankHole", DBNull.Value)
				End If
			Else
				Dim flag2 As Boolean = True
				Dim text As String = ""
				Dim text2 As String = ""
				Dim flag3 As Boolean = False
				Dim rst2 As cRODSTAR = RSWIN_DESC.rst
				text = Strings.Trim(rst2.UnitID)
				Dim text3 As String = Strings.Trim(rst2.PU.APIDesignation)
				Dim text4 As String = Strings.Trim(rst2.PU.OtherInfo)
				Dim text5 As String = rst2.PU.Manuf.Trim()
				If Strings.InStr(text, "CUSTOM", CompareMethod.Binary) <> 0 Then
					flag3 = True
				End If
				If Strings.InStr(rst2.PU.OtherInfo, vbLf, CompareMethod.Binary) <> 0 Then
					text4 = Strings.Trim(Strings.Replace(text4, vbLf, " ", 1, -1, CompareMethod.Binary))
				ElseIf Strings.InStr(rst2.PU.OtherInfo, vbBack, CompareMethod.Binary) <> 0 Then
					text4 = Strings.Trim(Strings.Replace(text4, vbBack, " ", 1, -1, CompareMethod.Binary))
				End If
				Dim text6 As String = Strings.Trim(rst2.PU.UnitName)
				If Not flag3 Then
					Dim flag4 As Boolean = True
					If flag4 <> bClicked Then
						If flag4 <> (Operators.CompareString(text, item.Text, False) <> 0) Then
							If flag4 <> (Operators.CompareString(text3, Strings.Trim(item.SubItems(Me.iKEY_APIDES).Text), False) <> 0) Then
								If flag4 <> (Operators.CompareString(text4, Strings.Trim(item.SubItems(Me.iKEY_OTHER).Text), False) <> 0) Then
									If flag4 <> (Operators.CompareString(text6, Strings.Trim(item.SubItems(Me.iKEY_UNAME).Text), False) <> 0) Then
										flag2 = False
									End If
								End If
							End If
						End If
					End If
				Else
					Dim flag5 As Boolean = True
					If flag5 <> bClicked Then
						If flag5 <> (Operators.CompareString(text5, Strings.Trim(item.SubItems(Me.iKEY_MANUF).Text), False) <> 0) Then
							If flag5 <> (Operators.CompareString(text3, Strings.Trim(item.SubItems(Me.iKEY_APIDES).Text), False) <> 0) Then
								If flag5 <> (Operators.CompareString(text6, Strings.Trim(item.SubItems(Me.iKEY_UNAME).Text), False) <> 0) Then
									flag2 = False
								End If
							End If
						End If
					End If
				End If
				If flag2 Then
					Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
					Dim pudataRec As RSWIN_DESC.PUDataRec
					pudataRec.Initialize()
					pudataRec = cRODSTAR.PU
					text2 = Conversions.ToString(CInt(cRODSTAR.PU.CrankHole))
					Dim customPUNum As Integer
					Dim text7 As String
					If Operators.ConditionalCompareObjectEqual(Me.cboManufMenu.SelectedItem, "(Measured pumping units)", False) Then
						Me.txtUnitID.Text = ""
						Dim str As String = "CUSTOM"
						If Not bClicked And Operators.CompareString(RSWIN_DESC.rst.UnitID, "", False) <> 0 Then
							Try
								customPUNum = Me.GetCustomPUNum(Me.lvwUnitList.SelectedItems(0))
							Catch ex2 As Exception
							End Try
							If customPUNum <> -1 Then
								text7 = str + Conversions.ToString(customPUNum)
							Else
								text7 = ""
							End If
						Else
							customPUNum = Me.GetCustomPUNum(Me.lvwUnitList.SelectedItems(0))
							If customPUNum <> -1 Then
								text7 = str + Conversions.ToString(customPUNum)
							Else
								text7 = ""
							End If
						End If
						RSWIN_DESC.rst.IDEntered = -1S
						Me.bCustomUnit = True
					Else
						text7 = item.Text
						Me.bCustomUnit = False
					End If
					If Me.bCustomUnit Then
						Dim flag6 As Boolean = PUDATA1.ReadPUData(text7, pudataRec, False, True)
						If flag6 Then
							RSWIN_DESC.rst.PU = pudataRec
							RSWIN_DESC.rst.UnitID = text7
							RSWIN_DESC.rst.IDEntered = -1S
							If RSWIN_DESC.rst.PU.UnitType = 9S Then
								RSWIN_DESC.rst.Unbalance = 0F
								pudataRec.Unbalance = 0F
								RSWIN_DESC.rst.PU = pudataRec
							End If
							If flag Then
								RSWIN_DESC.rst.Unbalance = RSWIN_DESC.rst.PU.Unbalance
							End If
							RSWIN_DESC.frmMain.ToolbarButtonSetState(16, True)
						End If
						If Not flag6 Then
							Dim pudataRec2 As RSWIN_DESC.PUDataRec
							pudataRec2.Initialize()
							pudataRec2 = pudataRec
							Dim customPU As Integer = Me.GetCustomPU(Me.lvwUnitList.SelectedItems(0), pudataRec2)
							If customPU <> -1 Then
								pudataRec = pudataRec2
							End If
						End If
						If customPUNum <> -1 OrElse flag6 Then
							' The following expression was wrapped in a unchecked-expression
							If Conversions.ToDouble(text2) - 1.0 >= 0.0 Then
								pudataRec.CrankHole = Conversions.ToShort(text2)
								pudataRec.R = pudataRec.CrankRadii(CInt(Math.Round(Conversions.ToDouble(text2) - 1.0)))
							Else
								pudataRec.CrankHole = 1S
								pudataRec.R = pudataRec.CrankRadii(0)
							End If
							RSWIN_DESC.rst.PU = pudataRec
							RSWIN_DESC.frmMain.ToolbarButtonSetState(16, True)
						End If
						If RSWIN_DESC.rst.PU.RequiredRotation = 1S Or RSWIN_DESC.rst.PU.RequiredRotation = -1S Then
							Me.cboCrankRotation.Enabled = False
							pudataRec = RSWIN_DESC.rst.PU
							pudataRec.CrankRotation = RSWIN_DESC.rst.PU.RequiredRotation
							RSWIN_DESC.rst.PU = pudataRec
							If RSWIN_DESC.rst.PU.RequiredRotation = 1S Then
								Me.cboCrankRotation.SelectedIndex = 0
							ElseIf RSWIN_DESC.rst.PU.RequiredRotation = -1S Then
								Me.cboCrankRotation.SelectedIndex = 1
							End If
						Else
							Me.cboCrankRotation.Enabled = True
						End If
					ElseIf PUDATA1.ReadPUData(text7, pudataRec, False, True) Then
						If flag Then
							RSWIN_DESC.rst.Unbalance = RSWIN_DESC.rst.PU.Unbalance
						End If
						If Operators.CompareString(text, item.Text, False) <> 0 Then
							pudataRec.CrankHole = 1S
							pudataRec.R = pudataRec.CrankRadii(0)
						ElseIf Conversions.ToDouble(text2) - 1.0 >= 0.0 Then
							pudataRec.CrankHole = Conversions.ToShort(text2)
							pudataRec.R = pudataRec.CrankRadii(CInt(Math.Round(Conversions.ToDouble(text2) - 1.0)))
						Else
							pudataRec.CrankHole = 1S
							pudataRec.R = pudataRec.CrankRadii(0)
						End If
						cRODSTAR.Iart = pudataRec.ArtInertia
						ini.SaveDataValue("UnitName", item.Text)
						ini.SaveDataValue("UnitID", cRODSTAR.UnitID)
						ini.SaveDataValue("IDEntered", cRODSTAR.IDEntered)
						cRODSTAR.PU = pudataRec
					End If
					cRODSTAR = Nothing
				End If
				If RSWIN_DESC.rst.PU.UnitType = 10S AndAlso (RSWIN_DESC.rst.AdjustedStrokeLength = -1F And RSWIN_DESC.rst.PU.MaxStroke <> 0F) Then
					RSWIN_DESC.rst.AdjustedStrokeLength = RSWIN_DESC.rst.PU.MaxStroke
					Me.txtAdjustedStrokeLength.Tag = "cee"
					Me.txtAdjustedStrokeLength.Text = RSWIN_DESC.rst.AdjustedStrokeLength.ToString()
				End If
			End If
			If RSWIN_DESC.rst.PU.CrankRotation = 1S Then
				Me.cboCrankRotation.SelectedIndex = 0
			ElseIf RSWIN_DESC.rst.PU.CrankRotation = -1S Or RSWIN_DESC.rst.PU.CrankRotation = 0S Then
				Me.cboCrankRotation.SelectedIndex = 1
			ElseIf RSWIN_DESC.rst.Rotation = 1S Then
				Me.cboCrankRotation.SelectedIndex = 0
			ElseIf RSWIN_DESC.rst.Rotation = -1S Then
				Me.cboCrankRotation.SelectedIndex = 1
			Else
				Me.cboCrankRotation.SelectedIndex = 0
			End If
			Me.cboCrankRotation_Click_1(CShort(Me.cboCrankRotation.SelectedIndex), False)
			Me.ShowUnitInfo(item IsNot Nothing)
			If RSWIN_DESC.rst.PU.UnitType = 10S Then
				Me.lblAPI.Text = Me.lblAPI.Text.Replace("API Designation", "Unit Designation")
				If Strings.InStr(Me.lvwUnitList.Columns(1).Text, "API designation", CompareMethod.Binary) > 0 Then
					Me.lvwUnitList.Columns(1).Text = "Unit designation"
					Return
				End If
			Else
				Me.lblAPI.Text = Me.lblAPI.Text.Replace("Unit Designation", "API Designation")
				If Strings.InStr(Me.lvwUnitList.Columns(1).Text, "Unit designation", CompareMethod.Binary) > 0 Then
					Me.lvwUnitList.Columns(1).Text = "API designation"
				End If
			End If
		End Sub

		Private Function GetCustomPUNum(lvw As ListViewItem) As Integer
			Dim result As Integer = -1
			Dim num As Integer = 0
			Dim num2 As Integer = Information.UBound(Me.UnitData, 1)
			For i As Integer = num To num2
				Debug.WriteLine(lvw.Text.Trim() + "  ,  " + Me.UnitData(i).Manuf.Trim())
				If Operators.CompareString(lvw.Text.Trim(), Me.UnitData(i).Manuf.Trim(), False) = 0 AndAlso (Operators.CompareString(lvw.SubItems(0).Text.Trim(), Me.UnitData(i).APIDesignation.Trim(), False) = 0 Or Operators.CompareString(lvw.SubItems(1).Text.Trim(), Me.UnitData(i).APIDesignation.Trim(), False) = 0 Or Operators.CompareString(lvw.SubItems(2).Text.Trim(), Me.UnitData(i).APIDesignation.Trim(), False) = 0) AndAlso (Operators.CompareString(lvw.SubItems(0).Text.Trim(), Me.UnitData(i).UnitName.Trim(), False) = 0 Or Operators.CompareString(lvw.SubItems(1).Text.Trim(), Me.UnitData(i).UnitName.Trim(), False) = 0 Or Operators.CompareString(lvw.SubItems(2).Text.Trim(), Me.UnitData(i).UnitName.Trim(), False) = 0) Then
					result = i
					Exit For
				End If
			Next
			Return result
		End Function

		Private Function GetPUNumCustom(sManuf As String, sAPIDesignation As String, sUnitName As String) As Integer
			Dim result As Integer = -1
			Dim num As Integer = 0
			Dim num2 As Integer = Information.UBound(Me.UnitData, 1)
			For i As Integer = num To num2
				If Operators.CompareString(sManuf.Trim(), Me.UnitData(i).Manuf.Trim(), False) = 0 AndAlso (Operators.CompareString(sAPIDesignation.Trim(), Me.UnitData(i).APIDesignation.Trim(), False) = 0 And Operators.CompareString(sUnitName.Trim(), Me.UnitData(i).UnitName.Trim(), False) = 0) Then
					result = i
					Exit For
				End If
			Next
			Return result
		End Function

		Private Sub cboCrankHole_Click_1(iListIndex As Short, Clicked As Boolean)
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			If Me.cboCrankHole.SelectedIndex >= 0 Then
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				pu = cRODSTAR.PU
				pu.CrankHole = iListIndex + 1S
				ini.SaveDataValue("CrankHole", pu.CrankHole)
				If Clicked And Not PUDATA1.CheckFourthLCCrankHole(Clicked, CInt(pu.CrankHole)) Then
					Try
						Try
							If pu.CrankHole <> 0S AndAlso pu.R <> pu.CrankRadii(CInt((pu.CrankHole - 1S))) Then
								pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
								kinemat.Kinconst(pu)
								kinemat.Unitstroke(pu)
								Me.ShowStrokeLength(pu)
							End If
						Catch ex As Exception
						End Try
						Me.cboCrankHole.Focus()
						GoTo IL_116
					Catch ex2 As Exception
						GoTo IL_116
					End Try
				End If
				pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
				If pu.UnitType = 4S Then
					Me.FixLowProfilePhaseAngle(pu)
				End If
				kinemat.Kinconst(pu)
				kinemat.Unitstroke(pu)
				Me.ShowStrokeLength(pu)
				IL_116:
				cRODSTAR.PU = pu
			End If
			cRODSTAR = Nothing
			Dim flag As Boolean = Me.ValidatePUData(True)
		End Sub

		Private Sub ShowStrokeLength(PU As RSWIN_DESC.PUDataRec)
			If Me.cboCrankHole.SelectedIndex < 0 Then
				Me.lblCalcStroke.Text = ""
			Else
				Dim num As Single = CtrlUI.ConvertUnits(PU.KinematicStroke, 8)
				If num = PU.KinematicStroke Then
					Me.lblCalcStroke.Text = Util.FormatMessage("{0!0.0}""", New Object() { PU.KinematicStroke })
				Else
					Me.lblCalcStroke.Text = Util.FormatMessage("{0!0.0} cm ({1!0.0}"")", New Object() { num, PU.KinematicStroke })
				End If
			End If
		End Sub

		Private Sub FixLowProfilePhaseAngle(ByRef PU As RSWIN_DESC.PUDataRec)
			Dim text As String = Strings.Trim(RSWIN_DESC.rst.UnitID)
			Dim num As Integer = 0
			Dim text2 As String = text
			If Operators.CompareString(text2, "LL1", False) = 0 Then
				num = Conversions.ToInteger(Interaction.Choose(CDbl(PU.CrankHole), New Object() { 80, 90, 78 }))
			ElseIf Operators.CompareString(text2, "LL2", False) = 0 Then
				num = Conversions.ToInteger(Interaction.Choose(CDbl(PU.CrankHole), New Object() { 64, 75, 62 }))
			ElseIf Operators.CompareString(text2, "LL3", False) = 0 Then
				num = Conversions.ToInteger(Interaction.Choose(CDbl(PU.CrankHole), New Object() { 64, 75, 62 }))
			ElseIf Operators.CompareString(text2, "LL4", False) = 0 Then
				num = Conversions.ToInteger(Interaction.Choose(CDbl(PU.CrankHole), New Object() { 68, 79, 61 }))
			ElseIf Operators.CompareString(text2, "LL5", False) = 0 Then
				num = Conversions.ToInteger(Interaction.Choose(CDbl(PU.CrankHole), New Object() { 80, 90, 78 }))
			End If
			If num <> 0 Then
				PU.CrankOffset = CSng((CDbl((Convert.ToSingle(num) / 180F)) * 3.141592653589793))
			End If
		End Sub

		Private Sub ShowUnitInfo(UnitValid As Boolean)
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				If Operators.CompareString(Me.txtUnitID.Text.Trim(), Strings.Trim(cRODSTAR.UnitID), False) <> 0 Or Operators.CompareString(Me.txtUnitID.Text, "", False) = 0 Then
					Me.txtUnitID.Text = Strings.Trim(cRODSTAR.UnitID)
					If Me.ActiveControl Is Me.txtUnitID Then
						Me.txtUnitID.SelectionStart = Me.txtUnitID.Text.Length
					End If
				End If
				Me.cboCrankHole.Enabled = False
				Me.cboCrankHole.Items.Clear()
				Dim num As Short = 1S
				Dim crankHoles As Short = cRODSTAR.PU.CrankHoles
				For num2 As Short = num To crankHoles
					' The following expression was wrapped in a checked-expression
					Me.cboCrankHole.Items.Add(Util.FormatMessage("{0} ({1}"" stroke)", New Object() { num2, cRODSTAR.PU.Strokes(CInt((num2 - 1S))) }))
				Next
				Me.bCrankHoleClicked = False
				Try
					' The following expression was wrapped in a checked-expression
					Me.cboCrankHole.SelectedIndex = CInt((cRODSTAR.PU.CrankHole - 1S))
				Catch ex As Exception
				End Try
				Me.cboCrankHole.Enabled = True
				If UnitValid Then
					Try
						If cRODSTAR.PU.CrankRotation = 1S Then
							Me.bCrankRotationClicked = True
							Me.cboCrankRotation.SelectedIndex = 0
							cRODSTAR.Rotation = cRODSTAR.PU.CrankRotation
						Else
							If cRODSTAR.PU.CrankRotation = -1S Then
								cRODSTAR.Rotation = cRODSTAR.PU.CrankRotation
							End If
							Me.bCrankRotationClicked = True
							Me.cboCrankRotation.SelectedIndex = 1
						End If
					Catch ex2 As Exception
					End Try
					If Not Me.bCustomUnit Then
						Me.cboCrankRotation.Enabled = (Not cRODSTAR.PU.RequiredRotation <> 0S)
					ElseIf cRODSTAR.PU.RequiredRotation = 1S Or cRODSTAR.PU.RequiredRotation = -1S Then
						Me.cboCrankRotation.Enabled = False
					Else
						Me.cboCrankRotation.Enabled = True
					End If
					If Not(cRODSTAR.PU.UnitType = 7S Or cRODSTAR.PU.UnitType = 10S) And cRODSTAR.PU.UnitType <> 6S Then
						Me.txtUnbalance.Enabled = True
						Me.optCBDataType_5.Enabled = True
					Else
						Me.txtUnbalance.Enabled = False
						Me.optCBDataType_5.Enabled = False
					End If
					If Information.IsDBNull(cRODSTAR.Unbalance) Then
						RSWIN_DESC.rst.Unbalance = RSWIN_DESC.rst.PU.Unbalance
					ElseIf RSWIN_DESC.rst.Unbalance = 0F Then
						RSWIN_DESC.rst.Unbalance = RSWIN_DESC.rst.PU.Unbalance
					End If
					If RSWIN_DESC.rst.PU.UnitType = 9S Then
						RSWIN_DESC.rst.Unbalance = 0F
					End If
					Me.txtUnbalance.Tag = "lee"
					Me.txtUnbalance.Text = Conversions.ToString(cRODSTAR.Unbalance)
				End If
				cRODSTAR = Nothing
				Me.ShowCounterbalance()
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub ShowCounterbalance()
			Dim num As Single = 1F
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Me.pnlHydraulic.Visible = False
				Me.grpCounterBalance.Visible = True
				Me.lblMInLbs.Tag = "(^)"
				Dim num2 As Single
				Select Case rst.PU.UnitType
					Case 6S
						Me.cmdReadCBLFile.Enabled = False
						Me.lblCBDataFile.Visible = False
						Me.optCBDataType_3.Text = Me.sUnknownAirTankPressure
						Me.optCBDataType_1.Text = Me.sExistingAirTankPressure
						Me.lblMInLbs.Text = "(psig)"
						Me.txtCounterbalance.Tag = "gee"
						If rst.CBDataType <> 1S Or rst.UnknownM Then
							Me.SetCounterbalanceTag()
							Me.txtCounterbalance.Text = ""
							Dim txtCounterbalance As TextBox = Me.txtCounterbalance
							Dim lblMInLbs As Label = Me.lblMInLbs
							Me.TextBox_Change(txtCounterbalance, lblMInLbs)
							Me.lblMInLbs = lblMInLbs
							Me.txtCounterbalance = txtCounterbalance
						End If
						num2 = 1F
						Me.txtCounterbalance.Visible = True
						Me.lblMInLbs.Visible = True
						Me.lblMInLbs.Left = Me.optCBDataType_1.Left + Me.optCBDataType_1.Width + 10
						Me.lblCounterbalance_Disabled.Visible = True
						Me.SetUnbalanceVisible(False)
						GoTo IL_456
					Case 7S, 10S
						Me.cmdReadCBLFile.Enabled = False
						Me.lblCBDataFile.Visible = False
						Me.optCBDataType_3.Text = Me.sUnknownCounterbalanceWeight
						Me.optCBDataType_1.Text = Me.sExistingCounterbalanceWeight
						Me.lblMInLbs.Text = "(M lbs)"
						Me.txtCounterbalance.Tag = "lee"
						If rst.CBDataType <> 1S Or rst.UnknownM Then
							Me.SetCounterbalanceTag()
							Me.txtCounterbalance.Text = ""
							Dim txtCounterbalance As TextBox = Me.txtCounterbalance
							Dim lblMInLbs As Label = Me.lblMInLbs
							Me.TextBox_Change(txtCounterbalance, lblMInLbs)
							Me.lblMInLbs = lblMInLbs
							Me.txtCounterbalance = txtCounterbalance
						End If
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							num2 = 1F
							num = 1000F
						Else
							num2 = 1000F
						End If
						Me.txtCounterbalance.Visible = True
						Me.lblMInLbs.Visible = True
						Me.lblMInLbs.Left = Me.optCBDataType_1.Left + Me.optCBDataType_1.Width + 10
						Me.lblCounterbalance_Disabled.Visible = True
						Me.SetUnbalanceVisible(False)
						If RSWIN_DESC.rst.PU.UnitType = 10S Then
							Me.pnlHydraulic.Visible = True
							Me.grpCounterBalance.Visible = False
							GoTo IL_456
						End If
						GoTo IL_456
					Case 8S
						Me.optCBDataType_3.Text = Me.sUnknownCounterbalanceData
						Me.optCBDataType_1.Text = Me.sExistingStructuralUnbalance
						Me.txtCounterbalance.Tag = "lee"
						Me.optCBDataType_5.Enabled = True
						Me.optCBDataType_5.Text = Me.sUseXBALInformation
						Me.txtCounterbalance.Visible = False
						Me.lblMInLbs.Visible = False
						Me.lblCounterbalance_Disabled.Visible = False
						num2 = 1F
						Me.SetUnbalanceVisible(True)
						GoTo IL_456
				End Select
				Me.optCBDataType_3.Text = Me.sUnknownMCM
				Me.optCBDataType_1.Text = Me.sExistingMaximumCounterbalanceMoment
				Me.lblMInLbs.Text = "(M in-lbs)"
				Me.txtCounterbalance.Tag = "Lee"
				Me.txtCounterbalance.Visible = True
				Me.lblMInLbs.Visible = True
				Me.lblMInLbs.Left = Me.optCBDataType_1.Left + Me.optCBDataType_1.Width + 10
				Me.lblCounterbalance_Disabled.Visible = True
				If rst.CBDataType <> 1S Or rst.UnknownM Then
					Me.SetCounterbalanceTag()
					Me.txtCounterbalance.Text = ""
					Dim txtCounterbalance As TextBox = Me.txtCounterbalance
					Dim lblMInLbs As Label = Me.lblMInLbs
					Me.TextBox_Change(txtCounterbalance, lblMInLbs)
					Me.lblMInLbs = lblMInLbs
					Me.txtCounterbalance = txtCounterbalance
				End If
				num2 = 1000F
				If rst.PU.UnitType = 9S Then
					Me.SetUnbalanceVisible(False)
				Else
					Me.SetUnbalanceVisible(True)
				End If
				IL_456:
				Me.SetCBMTooltipText()
				If Strings.Len(Strings.Trim(rst.CBDataFile)) > 0 Then
					Me.lblCBDataFile.Text = "File:  (" + Util.FileName(rst.CBDataFile) + ")"
					Me.lblCBDataFile.Visible = True
				Else
					Me.lblCBDataFile.Text = Me.sFileNoneSelected
					Me.lblCBDataFile.Visible = True
				End If
				Me.optCBDataType_Click_1(CInt(rst.CBDataType), -1, 0)
				If rst.CBDataType <> 0S Then
					Select Case rst.CBDataType
						Case 3S
							If RSWIN_DESC.rst.bCBEDigitized <> 0S Then
								Me.optCBDataType_Click_1(CInt(rst.CBDataType), -1, 0)
							Else
								Me.optCBDataType_Click_1(0, -1, 0)
							End If
						Case 4S
							If RSWIN_DESC.rst.bCBEFromDisk <> 0S Then
								Me.optCBDataType_Click_1(CInt(rst.CBDataType), -1, 0)
							Else
								Me.optCBDataType_Click_1(0, -1, 0)
							End If
						Case Else
							If rst.CBDataType = 1S And Not RSWIN_DESC.rst.UnknownM Then
								If Not RSWIN_DESC.rst.UnknownM Then
									Me.optCBDataType_Click_1(CInt(rst.CBDataType), -1, 0)
								Else
									Me.optCBDataType_Click_1(CInt(rst.CBDataType), 0, 0)
								End If
							Else
								Me.optCBDataType_Click_1(CInt(rst.CBDataType), -1, 0)
							End If
					End Select
				End If
				If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) AndAlso rst.CBDataType = 1S Then
					If rst.CBDataType = 1S And Not RSWIN_DESC.rst.UnknownM Then
						If Not RSWIN_DESC.rst.UnknownM Then
							Me.optCBDataType_Click_1(1, -1, 0)
						Else
							Me.optCBDataType_Click_1(1, 0, 0)
						End If
					Else
						Me.optCBDataType_Click_1(0, If((-If((RSWIN_DESC.rst.UnknownM > False), 1, 0)), 1, 0), 0)
					End If
					If Not RSWIN_DESC.rst.UnknownM Then
						If rst.get_M(2) / num2 <> 0F Then
							If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) Then
								Me.SetCounterbalanceTag()
								Me.txtCounterbalance.Text = Conversions.ToString(rst.get_M(2) / num2)
								Dim txtCounterbalance2 As TextBox = Me.txtCounterbalance
								Dim bValidIfEmpty As Boolean = True
								Dim bShowMessage As Boolean = False
								Dim num3 As Single
								Dim obj As Object = num3
								Dim flag As Boolean = CtrlUI.CheckValid(txtCounterbalance2, bValidIfEmpty, bShowMessage, obj)
								num3 = Conversions.ToSingle(obj)
								If flag Then
									RSWIN_DESC.rst.Counterbalance = num3 / num
								End If
							End If
						ElseIf rst.CBDataType = 1S And Not RSWIN_DESC.rst.UnknownM Then
							Me.optCBDataType_Click_1(CInt(rst.CBDataType), If((-If((RSWIN_DESC.rst.UnknownM > False), 1, 0)), 1, 0), -1)
						Else
							Me.optCBDataType_Click_1(0, -1, -1)
							RSWIN_DESC.rst.UnknownM = True
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub optCBDataType_Click_1(Index As Integer, Value As Integer, bClicked As Integer)
			Select Case Index
				Case 0, 3
					Me.optCBDataType_3.Checked = (Value <> 0)
					If Value <> 0 Then
						RSWIN_DESC.rst.UnknownM = True
						Me.txtCounterbalance.Enabled = False
					End If
				Case 1
					If If((-If((Me.optCBDataType_1.Checked > False), 1, 0)), 1, 0) <> Value Then
						Me.optCBDataType_1.Checked = (Value <> 0)
					End If
			End Select
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Value <> 0 AndAlso bClicked <> 0 Then
				Dim cbdataType As Integer = CInt(rst.CBDataType)
				If Index = 0 Then
					ini.SaveDataValue("CBDataType", 0)
				Else
					' The following expression was wrapped in a checked-expression
					rst.CBDataType = CShort(Index)
					ini.SaveDataValue("CBDataType", rst.CBDataType)
				End If
			End If
		End Sub

		Public Sub ShowCounterbalanceOptions(bSetDefault As Integer)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Me.optCBDataType_3.Checked = RSWIN_DESC.rst.UnknownM
		End Sub

		Private Sub SetManuf(PUType As String)
			Dim num As Short = 1S
			Dim num2 As Short = Me.nUnitTypes
			For num3 As Short = num To num2
				If Operators.CompareString(Strings.RTrim(Me.UnitTypeInfoList(CInt(num3)).Abbrev), PUType, False) = 0 Then
					Me.cboManufMenu.SelectedIndex = CInt(num3)
					Exit For
				End If
			Next
		End Sub

		Private Function GetItemIndexFromUnitID(sUnitID As String) As Integer
			Dim listViewItem As ListViewItem = New ListViewItem()
			Dim index As Integer
			Try
				For Each obj As Object In Me.lvwUnitList.Items
					listViewItem = CType(obj, ListViewItem)
					If Operators.CompareString(Strings.Trim(listViewItem.Text), Strings.Trim(sUnitID), False) = 0 Then
						index = listViewItem.Index
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return index
		End Function

		Private Function GetIndexFromText(itemtext As String) As Integer
			Dim listViewItem As ListViewItem = New ListViewItem()
			Dim result As Integer = -1
			Try
				For Each obj As Object In Me.lvwUnitList.Items
					listViewItem = CType(obj, ListViewItem)
					If Operators.CompareString(listViewItem.Text, itemtext, False) = 0 Then
						result = listViewItem.Index
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return result
		End Function

		Private Sub ShowUnit(Optional bSelectUnit As Boolean = True)
			Dim num2 As Integer
			Dim num6 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim listViewItem As ListViewItem = New ListViewItem()
				IL_09:
				num = 2
				Dim text As String = ""
				IL_13:
				num = 3
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				IL_1D:
				num = 4
				If cRODSTAR.IDEntered = 0S Then
					GoTo IL_44C
				End If
				IL_2F:
				num = 5
				listViewItem = Nothing
				IL_34:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_3C:
				num = 7
				If Strings.InStr(cRODSTAR.UnitID, "CUSTOM", CompareMethod.Binary) <> 0 Then
					GoTo IL_75
				End If
				IL_54:
				num = 8
				Dim obj As Object = Me.GetIndexFromText(Strings.Trim(cRODSTAR.UnitID))
				IL_70:
				GoTo IL_2BC
				IL_75:
				num = 10
				IL_79:
				num = 11
				Dim text2 As String = cRODSTAR.UnitID.Substring(6)
				IL_8C:
				num = 12
				Dim num3 As Integer = Convert.ToInt32(text2.Trim())
				IL_9E:
				num = 13
				Dim enumerator As IEnumerator = Me.lvwUnitList.Items.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj2 As Object = enumerator.Current
					listViewItem = CType(obj2, ListViewItem)
					IL_C6:
					num = 14
					Debug.WriteLine(listViewItem.Text.Trim() + " , " + Me.UnitData(num3).Manuf.Trim())
					IL_FB:
					num = 15
					If Operators.CompareString(listViewItem.Text.Trim(), Me.UnitData(num3).Manuf.Trim(), False) = 0 Then
						IL_12D:
						num = 16
						If Operators.CompareString(listViewItem.SubItems(0).Text.Trim(), Me.UnitData(num3).APIDesignation.Trim(), False) = 0 Or Operators.CompareString(listViewItem.SubItems(1).Text.Trim(), Me.UnitData(num3).APIDesignation.Trim(), False) = 0 Or Operators.CompareString(listViewItem.SubItems(2).Text.Trim(), Me.UnitData(num3).APIDesignation.Trim(), False) = 0 Then
							IL_1DA:
							num = 17
							If Operators.CompareString(listViewItem.SubItems(0).Text.Trim(), Me.UnitData(num3).UnitName.Trim(), False) = 0 Or Operators.CompareString(listViewItem.SubItems(1).Text.Trim(), Me.UnitData(num3).UnitName.Trim(), False) = 0 Or Operators.CompareString(listViewItem.SubItems(2).Text.Trim(), Me.UnitData(num3).UnitName.Trim(), False) = 0 Then
								IL_284:
								num = 18
								obj = listViewItem.Index
								IL_295:
								Exit While
							End If
						End If
					End If
					IL_297:
					num = 23
				End While
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_2BC:
				num = 25
				listViewItem = CType(NewLateBinding.LateGet(Me.lvwUnitList.Items, Nothing, "Item", New Object() { RuntimeHelpers.GetObjectValue(obj) }, Nothing, Nothing, Nothing), ListViewItem)
				IL_2F4:
				num = 26
				Me.lvwUnitList.SelectedItems.Clear()
				IL_308:
				num = 27
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.lvwUnitList.Items, Nothing, "Item", New Object() { RuntimeHelpers.GetObjectValue(obj) }, Nothing, Nothing, Nothing), Nothing, "Selected", New Object() { True }, Nothing, Nothing, False, True)
				IL_35D:
				num = 28
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.lvwUnitList.Items, Nothing, "Item", New Object() { RuntimeHelpers.GetObjectValue(obj) }, Nothing, Nothing, Nothing), Nothing, "Focused", New Object() { True }, Nothing, Nothing, False, True)
				IL_3B2:
				num = 29
				If listViewItem Is Nothing Then
					GoTo IL_704
				End If
				IL_3BC:
				num = 30
				Me.bUnitListClicked = False
				IL_3C7:
				num = 31
				If Not Operators.ConditionalCompareObjectLess(obj, 0, False) Then
					GoTo IL_3F2
				End If
				IL_3DB:
				num = 32
				obj = Me.GetIndexFromText(listViewItem.Text)
				IL_3F2:
				num = 34
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.lvwUnitList.Items, Nothing, "Item", New Object() { RuntimeHelpers.GetObjectValue(obj) }, Nothing, Nothing, Nothing), Nothing, "Selected", New Object() { True }, Nothing, Nothing, False, True)
				IL_447:
				GoTo IL_704
				IL_44C:
				num = 37
				IL_450:
				num = 38
				Dim cRODSTAR2 As cRODSTAR = cRODSTAR
				Dim pu As RSWIN_DESC.PUDataRec = cRODSTAR2.PU
				Dim num4 As Integer = CInt(CUSTOMPU.AddCustomPU(pu, text, False))
				cRODSTAR2.PU = pu
				If num4 = 0 Then
					GoTo IL_548
				End If
				IL_47C:
				num = 39
				If cRODSTAR.PU.FileRecord = 0S Then
					GoTo IL_536
				End If
				IL_496:
				num = 40
				Me.cboManufMenu.SelectedIndex = 0
				IL_4A6:
				num = 41
				Dim cboManufMenu As ComboBox = Me.cboManufMenu
				IL_4B2:
				num = 42
				Me.cboManufMenu_Click_1(0, True)
				IL_4BE:
				num = 43
				Me.bManufMenuClicked = False
				IL_4C9:
				IL_4CC:
				num = 45
				Me.LoadUnitMenu(True)
				IL_4D7:
				num = 46
				Dim indexFromText As Integer = Me.GetIndexFromText(text.Trim())
				IL_4E9:
				num = 47
				If indexFromText = -1 Then
					GoTo IL_536
				End If
				IL_4F1:
				num = 48
				Me.lvwUnitList.Items(indexFromText).Selected = True
				IL_50C:
				num = 49
				Me.txtUnitID.Text = "Custom" + (indexFromText + 2).ToString().Trim()
				IL_536:
				num = 52
				Me.lvwUnitList.Enabled = True
				IL_546:
				GoTo IL_57C
				IL_548:
				num = 54
				IL_54C:
				num = 55
				Me.cboManufMenu.Enabled = False
				IL_55C:
				num = 56
				Me.lvwUnitList.Enabled = False
				IL_56C:
				num = 57
				Me.chkCustomPUDB.Enabled = False
				IL_57C:
				num = 59
				If cRODSTAR.PU.CrankHoles <> 0S Then
					GoTo IL_62B
				End If
				IL_596:
				num = 60
				Dim pu2 As RSWIN_DESC.PUDataRec
				pu2.Initialize()
				IL_5A1:
				num = 61
				pu2 = cRODSTAR.PU
				IL_5AE:
				num = 62
				pu2.CrankRadii(0) = cRODSTAR.PU.R
				IL_5CB:
				num = 63
				pu2.CrankHoles = 1S
				IL_5D7:
				num = 64
				pu2.CrankHole = 1S
				IL_5E3:
				num = 65
				kinemat.Kinconst(pu2)
				IL_5EE:
				num = 66
				kinemat.Unitstroke(pu2)
				IL_5F9:
				num = 67
				pu2.Strokes(0) = CSng(Conversion.Int(CDbl(pu2.KinematicStroke) + 0.5))
				IL_61E:
				num = 68
				cRODSTAR.PU = pu2
				IL_62B:
				num = 70
				If cRODSTAR.PU.UnitType <> 10S Then
					GoTo IL_6F0
				End If
				IL_646:
				num = 71
				Dim flag As Boolean = cRODSTAR.AdjustedStrokeLength = -1F
				pu = cRODSTAR.PU
				If Not(flag And pu.MaxStroke <> 0F And cRODSTAR.PU.MaxStroke <> 0F) Then
					GoTo IL_6DE
				End If
				IL_690:
				num = 72
				cRODSTAR.AdjustedStrokeLength = cRODSTAR.PU.MaxStroke
				IL_6AB:
				num = 73
				Me.txtAdjustedStrokeLength.Tag = "cee"
				IL_6BF:
				num = 74
				Me.txtAdjustedStrokeLength.Text = cRODSTAR.AdjustedStrokeLength.ToString()
				IL_6DE:
				num = 76
				Me.pnlCombinationBeamCrank.Visible = False
				IL_6EE:
				GoTo IL_704
				IL_6F0:
				num = 78
				IL_6F4:
				num = 79
				Me.pnlCombinationBeamCrank.Visible = False
				IL_704:
				cRODSTAR = Nothing
				IL_707:
				IL_70C:
				GoTo IL_8B5
				IL_711:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_871:
				GoTo IL_8AA
				IL_873:
				num6 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_886:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num2 <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_873
			End Try
			IL_8AA:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_8B5:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub LoadPUData()
			RSWIN_DESC.frmMain.ToolbarButtonSetState(16, False)
			If(Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) And RSWIN_DESC.rst.UnknownM) Or ((RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) And RSWIN_DESC.rst.bUnknownUnbalance) Then
				RSWIN_DESC.rst.CBDataType = 0S
			ElseIf Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) And Not RSWIN_DESC.rst.UnknownM And RSWIN_DESC.rst.CBEffect > 0F And RSWIN_DESC.rst.CBAngle > 0F And RSWIN_DESC.rst.get_M(2) = 0F And RSWIN_DESC.rst.CBDataType = 0S Then
				RSWIN_DESC.rst.CBDataType = 2S
			ElseIf((RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) And Not RSWIN_DESC.rst.bUnknownUnbalance) Or (Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) And Not RSWIN_DESC.rst.UnknownM And RSWIN_DESC.rst.get_M(2) > 0F And RSWIN_DESC.rst.CBDataType = 0S) Then
				RSWIN_DESC.rst.CBDataType = 1S
			End If
			Me.ShowManuf()
			Me.ShowUnit(True)
			Me.ShowCounterbalanceOptions(0)
			Me.ShowUnitInfo(True)
			If RSWIN_DESC.rst.PU.CrankRotation = 1S Then
				Me.cboCrankRotation.SelectedIndex = 0
			ElseIf RSWIN_DESC.rst.PU.CrankRotation = -1S Then
				Me.cboCrankRotation.SelectedIndex = 1
			End If
			If RSWIN_DESC.rst.PU.UnitType = 10S Then
				Me.txtAdjustedStrokeLength.Tag = "cee"
				Me.txtAdjustedStrokeLength.Text = Conversions.ToString(RSWIN_DESC.rst.AdjustedStrokeLength)
			ElseIf RSWIN_DESC.rst.PU.UnitType = 11S Then
				If RSWIN_DESC.rst.bUseCrankBalancedCalcs Then
					Me.optUseCrankBalancedCalcs.Checked = True
				Else
					Me.optUseBeamBalancedCalcs.Checked = True
				End If
			End If
			Me.ValidatePUData(True)
		End Sub

		Private Sub chkCustomPUDB_Click_1(Checked As Boolean, Clicked As Boolean)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				Me.chkCustomPUDB.Checked = Checked
				Dim flag As Boolean = False
				If Me.cboManufMenu.SelectedIndex >= 0 And Me.lvwUnitList.Enabled And (Me.lvwUnitList.SelectedItems IsNot Nothing Or Operators.CompareString(Me.txtUnitID.Text, "", False) <> 0) Then
					Try
						Dim text As String = Me.txtUnitID.Text
						Dim num As Short
						Dim text2 As String
						If text.Length = 0 Then
							flag = False
						Else
							Dim obj As Object = num
							PUDATA1.ParseUnitID(text, text2, obj)
							num = Conversions.ToShort(obj)
						End If
						If Not Checked Then
							flag = True
						ElseIf Me.cboManufMenu.SelectedIndex = 0 Then
							flag = True
						Else
							Dim text3 As String = Strings.Space(8192)
							Dim num2 As Integer = Custom.CustomPumpingUnitLists_SelectRow(text2.Trim(), text3, False, "")
							Dim num3 As Short = CShort(text3.Trim().Length)
							text3 = text3.Trim()
							If Strings.InStr("," + text3 + ",", "," + Conversions.ToString(CInt(num)) + ",", CompareMethod.Binary) > 0 Then
								flag = True
							Else
								Dim msg As String = Me.sDYWCustomPU
								Dim bDefaultYes As Boolean = True
								Dim flag2 As Boolean = False
								If Util.YesNo(msg, bDefaultYes, flag2) Then
									flag = True
									If Strings.Len(text3) = 0 Then
										text3 = Convert.ToString(num)
									Else
										text3 = text3 + "," + Convert.ToString(num)
									End If
									Custom.CustomPumpingUnitLists_DBUpdateRow(text2.Trim(), text3.Trim(), False, "")
								End If
							End If
						End If
					Catch ex2 As Exception
					End Try
				End If
				Util.BusyCursor()
				Dim cboManufMenu As ComboBox = Me.cboManufMenu
				Me.LoadManufMenu(cboManufMenu, Checked)
				Me.cboManufMenu = cboManufMenu
				If flag Then
					Me.ShowManuf()
					Me.ShowUnit(True)
				End If
				Util.UnbusyCursor()
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub InitListView()
			Me.lvwUnitList.Items.Clear()
			Me.lvwUnitList.Columns.Clear()
			Me.lvwUnitList.View = View.Details
			Me.lvwUnitList.FullRowSelect = True
			Me.lvwUnitList.GridLines = True
		End Sub

		Private Sub InitPUData()
			Me.lblUnitID.Text = Me.sUnitID
			Me.txtUnitID.Enabled = True
			Me.lblUnitID.Enabled = True
			Me.lblUnitID.Visible = True
			Me.txtUnitID.Visible = True
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			RSWIN_DESC.frmMain.ToolbarButtonSetState(16, False)
			cRODSTAR.Counterbalance = Conversions.ToSingle(ini.GetDataValue("Counterbalance", 4, False, 0))
			cRODSTAR.CrankHole = Conversions.ToShort(ini.GetDataValue("CrankHole", 3, False, 1))
			cRODSTAR.Rotation = Conversions.ToShort(ini.GetDataValue("CrankRotation", 3, False, 1))
			cRODSTAR.Unbalance = Conversions.ToSingle(ini.GetDataValue("Unbalance", 4, False, 0))
			cRODSTAR.UnknownM = Conversions.ToBoolean(ini.GetDataValue("UnknownM", 11, False, True))
			cRODSTAR.CBAngle = Conversions.ToSingle(ini.GetDataValue("CBAngle", 4, False, 0))
			cRODSTAR.CBDataType = Conversions.ToShort(ini.GetDataValue("CBDataType", 3, False, 1))
			cRODSTAR.CBEffect = Conversions.ToSingle(ini.GetDataValue("CBEffect", 4, False, 0))
			Me.cboManufMenu.SelectedIndex = -1
			Me.cboCrankHole.Enabled = False
			Me.cboCrankHole.SelectedIndex = -1
			Me.txtUnbalance.Text = ""
			Try
				If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
					Me.optCBSource_Click_1(PUData.CBSource.cbsUnknown, False, False)
					Me.optCBDataType_Click_1(0, If((-If((RSWIN_DESC.rst.bUnknownUnbalance > False), 1, 0)), 1, 0), 0)
				ElseIf cRODSTAR.CBDataType = 1S And Not RSWIN_DESC.rst.UnknownM Then
					Me.optCBSource_Click_1(PUData.CBSource.cbsEntered, RSWIN_DESC.rst.UnknownM, False)
					Me.optCBDataType_Click_1(1, If((-If((RSWIN_DESC.rst.UnknownM > False), 1, 0)), 1, 0), 0)
				Else
					Me.optCBSource_Click_1(PUData.CBSource.cbsUnknown, False, False)
					Me.optCBDataType_Click_1(0, If((-If((RSWIN_DESC.rst.UnknownM > False), 1, 0)), 1, 0), 0)
				End If
			Catch ex As Exception
			End Try
			Me.cmdUnitSizeRecommendation.Text = Me.sUnitSizeRecommendation
			Me.cmdUnitSizeRecommendation.Enabled = False
			Dim pu As RSWIN_DESC.PUDataRec = cRODSTAR.PU
			pu.Initialize()
			pu.Manuf = ""
			pu.UnitType = -1S
			pu.CrankHole = cRODSTAR.CrankHole
			cRODSTAR.PU = pu
			cRODSTAR.UnitID = ""
			Dim num As Short = 0S
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("UnitID", 8, False, ""))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				cRODSTAR.IDEntered = -1S
				cRODSTAR.UnitID = Strings.Trim(Conversions.ToString(objectValue))
				Me.ShowManuf()
				Me.ShowUnit(True)
				num = -1S
				If cRODSTAR.CBDataType = 1S And Not RSWIN_DESC.rst.UnknownM Then
					Me.optCBDataType_1.Checked = True
				End If
			Else
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("UnitName", 8, False, DBNull.Value))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					Me.bManufMenuClicked = True
					Dim selectedIndex As Short
					Me.cboManufMenu.SelectedIndex = CInt(selectedIndex)
				Else
					Me.bManufMenuClicked = False
					Dim selectedIndex As Short
					Me.cboManufMenu.SelectedIndex = CInt(selectedIndex)
					num = -1S
				End If
			End If
			If Not num <> 0S Then
				cRODSTAR.UnknownM = True
			Else
				If cRODSTAR.Rotation = 1S Or cRODSTAR.Rotation = 0S Then
					pu = RSWIN_DESC.rst.PU
					pu.CrankRotation = 1S
					RSWIN_DESC.rst.PU = pu
					Me.bCrankRotationClicked = False
					Me.cboCrankRotation.SelectedIndex = 0
				Else
					cRODSTAR.Rotation = -1S
					pu = RSWIN_DESC.rst.PU
					pu.CrankRotation = -1S
					RSWIN_DESC.rst.PU = pu
					Me.bCrankRotationClicked = False
					Me.cboCrankRotation.SelectedIndex = 1
				End If
				If Not Information.IsDBNull(cRODSTAR.CrankHole) AndAlso CInt(cRODSTAR.CrankHole) < Me.cboCrankHole.Items.Count Then
					Me.bCrankHoleClicked = True
					Me.cboCrankHole.SelectedIndex = CInt((cRODSTAR.CrankHole - 1S))
				End If
				If Information.IsDBNull(cRODSTAR.Unbalance) Then
					Me.txtUnbalance.Text = Conversions.ToString(cRODSTAR.PU.Unbalance)
				ElseIf cRODSTAR.Unbalance = 0F Then
					Me.txtUnbalance.Text = Conversions.ToString(cRODSTAR.PU.Unbalance)
				Else
					Me.txtUnbalance.Text = Conversions.ToString(cRODSTAR.Unbalance)
					If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) Then
						pu = RSWIN_DESC.rst.PU
						pu.Unbalance = cRODSTAR.Unbalance
						RSWIN_DESC.rst.PU = pu
					End If
				End If
				If Not Information.IsDBNull(cRODSTAR.UnknownM) Then
					If cRODSTAR.UnknownM Or Information.IsDBNull(cRODSTAR.Counterbalance) Then
						Me.SetCounterbalanceTag()
						Me.txtCounterbalance.Text = ""
						Dim txtCounterbalance As TextBox = Me.txtCounterbalance
						Dim lblMInLbs As Label = Me.lblMInLbs
						Me.TextBox_Change(txtCounterbalance, lblMInLbs)
						Me.lblMInLbs = lblMInLbs
						Me.txtCounterbalance = txtCounterbalance
					Else
						Me.SetCounterbalanceTag()
						Me.txtCounterbalance.Text = Conversions.ToString(cRODSTAR.Counterbalance)
					End If
				End If
			End If
			If RSWIN_DESC.NewData(6) <> 0S Then
				Me.bInit = True
			Else
				Me.bInit = False
			End If
			If Operators.CompareString(RSWIN_DESC.rst.UnitID.Trim(), "", False) = 0 AndAlso (If((-If((Me.cboManufMenu.SelectedIndex > 0 > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.NewData(6) And If((-If((Me.bRecPULoaded > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				Me.SetRecommendedUnit(False)
			End If
			Try
				If Me.cboCrankHole.Enabled AndAlso Me.cboCrankHole.SelectedIndex = -1 Then
					cRODSTAR.CrankHole = Conversions.ToShort(ini.GetDataValue("CrankHole", 3, False, 1))
					If cRODSTAR.CrankHole > 0S Then
						' The following expression was wrapped in a checked-expression
						Me.cboCrankHole.SelectedIndex = CInt((cRODSTAR.CrankHole - 1S))
					Else
						Me.cboCrankHole.SelectedIndex = 0
					End If
				End If
			Catch ex2 As Exception
			End Try
			If RSWIN_DESC.rst.PU.UnitType = 10S Then
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("AdjustedStrokeLength", 4, False, DBNull.Value))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.AdjustedStrokeLength = -1F
				Else
					cRODSTAR.AdjustedStrokeLength = Conversions.ToSingle(objectValue)
					If cRODSTAR.AdjustedStrokeLength = -1F And cRODSTAR.PU.MaxStroke <> 0F Then
						cRODSTAR.AdjustedStrokeLength = cRODSTAR.PU.MaxStroke
					End If
					Me.txtAdjustedStrokeLength.Tag = "cee"
					Me.txtAdjustedStrokeLength.Text = cRODSTAR.AdjustedStrokeLength.ToString()
				End If
			ElseIf RSWIN_DESC.rst.PU.UnitType = 11S Then
				cRODSTAR.bUseCrankBalancedCalcs = Conversions.ToBoolean(ini.GetDataValue("UseCrankBalancedCalcs", 11, False, True))
				If cRODSTAR.bUseCrankBalancedCalcs Then
					Me.optUseCrankBalancedCalcs.Checked = True
				Else
					Me.optUseBeamBalancedCalcs.Checked = True
				End If
			End If
			cRODSTAR = Nothing
		End Sub

		Private Sub PUData_Enter(eventSender As Object, eventArgs As EventArgs)
			If Not Me.bFormLoaded And RSWIN_DESC.rst IsNot Nothing Then
				Me.PUDataLoad()
				Me.bFormLoaded = True
				Return
			End If
		End Sub

		Private Sub PUData_Leave(eventSender As Object, eventArgs As EventArgs)
			Me.bFormLoaded = False
			Me.m_bClosing = False
		End Sub

		Private Sub PUData_Load(eventSender As Object, eventArgs As EventArgs)
			SUPERPRO.NewCheckSentinel(True)
			Me.m_bClosing = False
			RSWIN_DESC.sCurrentFormName = "PUData"
			RSWIN.GetMeasurementUnit()
			Me.ResetClock()
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
			Me.PUDataLoad()
			Me.LoadPURecommendation()
			Dim num As Integer = RSWIN_DESC.frmMain.Width - Me.Width
			Dim num2 As Integer
			Me.Top = CInt(Math.Round(CDbl(num2) / 2.0 + CDbl(RSWIN_DESC.frmMain.pnlToolbar.Height)))
			Me.Left = CInt(Math.Round(CDbl(num) / 2.0))
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
			End If
			Me.CenterForm()
		End Sub

		Private Sub PUDataLoad()
			Try
				Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
				Me.bFormLoaded = True
				Me.chkCustomPUDB_Click_1(False, False)
				If RSWIN_DESC.rst IsNot Nothing Then
					If(If((-If(((Information.IsDBNull(RSWIN_DESC.rst.UnitID) Or Operators.CompareString(RSWIN_DESC.rst.UnitID, "          ", False) = 0) > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.NewData(6)) <> 0S Then
						Me.InitPUData()
						Me.cboManufMenu.Focus()
					Else
						Me.LoadPUData()
						Me.bInit = False
						Me.lvwUnitList.Focus()
					End If
				End If
			Catch ex As Exception
				MessageBox.Show("Error in Load PUData: " + ex.Message)
			End Try
		End Sub

		Private Sub txtUnitID_TextChanged(sender As Object, e As EventArgs)
			Dim num As Integer = 0
			Dim num2 As Short = -2S
			Try
				Dim flag As Boolean = Me.ActiveControl Is Me.txtUnitID
				Dim txtUnitID As TextBox = Me.txtUnitID
				Dim lblUnitID As Label = Me.lblUnitID
				Me.TextBox_Change(txtUnitID, lblUnitID)
				Me.lblUnitID = lblUnitID
				Me.txtUnitID = txtUnitID
				Dim text As String = Strings.UCase(Me.txtUnitID.Text.Trim())
				If Operators.CompareString(text, "", False) = 0 Then
					RSWIN_DESC.frmMain.ToolbarButtonSetState(16, False)
				Else
					RSWIN_DESC.frmMain.ToolbarButtonSetState(16, True)
				End If
				Dim pu As RSWIN_DESC.PUDataRec
				If RSWIN_DESC.rst.PU.CrankHole > 0S Then
					pu = RSWIN_DESC.rst.PU
					num = CInt(pu.CrankHole)
				End If
				pu = RSWIN_DESC.rst.PU
				num2 = pu.CrankRotation
				If Strings.InStr(text, "CUSTOM", CompareMethod.Binary) > 0 Then
					Me.bCustomUnit = True
				Else
					Me.bCustomUnit = False
				End If
				If text.Length > 0 Then
					If Operators.CompareString(text, Me.savedUnitID, False) = 0 And Me.cboCrankHole.Enabled Then
						Me.txtUnitID.Text = text
					Else
						Dim id As String = text
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						pu = rst.PU
						Dim flag2 As Boolean = PUDATA1.ReadPUData(id, pu, True, True)
						rst.PU = pu
						If Not flag2 Then
							Me.txtUnitID.Focus()
						Else
							RSWIN_DESC.rst.IDEntered = -1S
							RSWIN_DESC.rst.UnitID = Strings.UCase(Me.txtUnitID.Text.Trim())
							Try
								If flag Then
									Dim rst2 As cRODSTAR = RSWIN_DESC.rst
									pu = RSWIN_DESC.rst.PU
									rst2.Unbalance = pu.Unbalance
								ElseIf Information.IsDBNull(RSWIN_DESC.rst.Unbalance) Then
									Dim rst3 As cRODSTAR = RSWIN_DESC.rst
									pu = RSWIN_DESC.rst.PU
									rst3.Unbalance = pu.Unbalance
								ElseIf RSWIN_DESC.rst.Unbalance = 0F Then
									Dim rst4 As cRODSTAR = RSWIN_DESC.rst
									pu = RSWIN_DESC.rst.PU
									rst4.Unbalance = pu.Unbalance
								End If
							Catch ex As Exception
								Dim rst5 As cRODSTAR = RSWIN_DESC.rst
								pu = RSWIN_DESC.rst.PU
								rst5.Unbalance = pu.Unbalance
							End Try
							Me.ShowManuf()
							If Not Me.bCustomUnit Then
								Me.ShowUnit(True)
							End If
							Me.CheckUnitType()
							Me.ShowCounterbalanceOptions(0)
							Me.ShowUnitInfo(True)
							ini.SaveDataValue("UnitID", RSWIN_DESC.rst.UnitID.Trim())
							ini.SaveDataValue("IDEntered", RSWIN_DESC.rst.IDEntered)
							Me.bCrankHoleClicked = False
							If num > 0 And Me.cboCrankHole.Items.Count >= num Then
								' The following expression was wrapped in a checked-expression
								Me.cboCrankHole.SelectedIndex = num - 1
							Else
								Me.cboCrankHole.SelectedIndex = 0
							End If
							pu = RSWIN_DESC.rst.PU
							If(Not pu.RequiredRotation And If((-If(((num2 <> -2S) > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.PU.CrankRotation <> num2) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
								Dim pu2 As RSWIN_DESC.PUDataRec
								pu2.Initialize()
								pu2 = RSWIN_DESC.rst.PU
								pu2.CrankRotation = num2
								RSWIN_DESC.rst.PU = pu2
							End If
						End If
					End If
					If Me.bCustomUnit Then
						Me.txtUnitID.Visible = False
					Else
						Me.txtUnitID.Visible = True
					End If
					Me.lblUnitID.Visible = Me.txtUnitID.Visible
					If flag Then
						Try
							Dim unbalance As Single = RSWIN_DESC.rst.Unbalance
							pu = RSWIN_DESC.rst.PU
							If CDbl(Math.Abs(unbalance - pu.Unbalance)) > 0.1 And RSWIN_DESC.rst.Unbalance <> 0F And RSWIN_DESC.rst.PU.UnitType = 8S Then
								Dim dialogResult As DialogResult = MessageBox.Show(Me.sUpdateUnbalance, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
								If dialogResult = DialogResult.Yes Then
									Dim rst6 As cRODSTAR = RSWIN_DESC.rst
									pu = RSWIN_DESC.rst.PU
									rst6.Unbalance = pu.Unbalance
									Me.txtUnbalance.Tag = "lee"
									Me.txtUnbalance.Text = Conversions.ToString(RSWIN_DESC.rst.Unbalance)
								End If
							Else
								pu = RSWIN_DESC.rst.PU
								If pu.UnitType <> 8S Then
									RSWIN_DESC.rst.Unbalance = RSWIN_DESC.rst.PU.Unbalance
									Me.txtUnbalance.Tag = "lee"
									Me.txtUnbalance.Text = Conversions.ToString(RSWIN_DESC.rst.Unbalance)
								End If
							End If
							Me.txtUnitID.SelectionStart = Me.txtUnitID.Text.Length
							Me.txtUnitID.Focus()
						Catch ex2 As Exception
						End Try
						Try
							pu = RSWIN_DESC.rst.PU
							If pu.UnitType = 10S And RSWIN_DESC.rst.PU.MaxStroke <> 0F Then
								RSWIN_DESC.rst.AdjustedStrokeLength = RSWIN_DESC.rst.PU.MaxStroke
								Me.txtAdjustedStrokeLength.Tag = "cee"
								Me.txtAdjustedStrokeLength.Text = Conversions.ToString(RSWIN_DESC.rst.AdjustedStrokeLength)
							End If
						Catch ex3 As Exception
						End Try
					End If
					Me.pnlHydraulic.Visible = False
					Me.grpCounterBalance.Visible = True
					Select Case RSWIN_DESC.rst.PU.UnitType
						Case 6S
							Me.optCBDataType_3.Text = Me.sUnknownAirTankPressure
							Me.optCBDataType_1.Text = Me.sExistingAirTankPressure
							Me.txtCounterbalance.Tag = "gee"
							Me.optCBDataType_5.Enabled = False
							Me.optCBDataType_5.Text = Me.sUseXBALInformation
							Me.txtCounterbalance.Visible = True
							Me.lblMInLbs.Visible = True
							Me.lblMInLbs.Left = Me.optCBDataType_1.Left + Me.optCBDataType_1.Width + 10
							Me.lblCounterbalance_Disabled.Visible = True
							Me.pnlCombinationBeamCrank.Visible = False
							GoTo IL_880
						Case 7S, 10S
							Me.optCBDataType_3.Text = Me.sUnknownCounterbalanceWeight
							Me.optCBDataType_1.Text = Me.sExistingCounterbalanceWeight
							Me.txtCounterbalance.Tag = "lee"
							Me.optCBDataType_5.Enabled = False
							Me.optCBDataType_5.Text = Me.sUseXBALInformation
							Me.txtCounterbalance.Visible = True
							Me.lblMInLbs.Visible = True
							Me.lblMInLbs.Left = Me.optCBDataType_1.Left + Me.optCBDataType_1.Width + 10
							Me.lblCounterbalance_Disabled.Visible = True
							Me.pnlCombinationBeamCrank.Visible = False
							If RSWIN_DESC.rst.PU.UnitType = 10S Then
								Me.pnlHydraulic.Visible = True
								Me.grpCounterBalance.Visible = False
								GoTo IL_880
							End If
							GoTo IL_880
						Case 8S
							Me.optCBDataType_3.Text = Me.sUnknownCounterbalanceData
							Me.optCBDataType_1.Text = Me.sExistingStructuralUnbalance
							Me.txtCounterbalance.Tag = "lee"
							Me.optCBDataType_5.Enabled = True
							Me.optCBDataType_5.Text = Me.sUseXBALInformation
							Me.txtCounterbalance.Visible = False
							Me.lblMInLbs.Visible = False
							Me.lblCounterbalance_Disabled.Visible = False
							Me.pnlCombinationBeamCrank.Visible = False
							GoTo IL_880
					End Select
					Me.optCBDataType_3.Text = Me.sUnknownMCM
					Me.optCBDataType_1.Text = Me.sExistingMaximumCounterbalanceMoment
					Me.txtCounterbalance.Tag = "Lee"
					Me.optCBDataType_5.Enabled = True
					Me.optCBDataType_5.Text = Me.sUseXBALInformation
					Me.txtCounterbalance.Visible = True
					Me.lblMInLbs.Visible = True
					Me.lblMInLbs.Left = Me.optCBDataType_1.Left + Me.optCBDataType_1.Width + 10
					Me.lblCounterbalance_Disabled.Visible = True
					If RSWIN_DESC.rst.PU.UnitType = 9S Then
						Me.SetUnbalanceVisible(False)
					Else
						Me.SetUnbalanceVisible(True)
					End If
					Me.pnlCombinationBeamCrank.Visible = False
					IL_880:
					Me.SetCBMTooltipText()
				End If
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub txtUnbalance_TextChanged(sender As Object, e As EventArgs)
			Dim txtUnbalance As TextBox = Me.txtUnbalance
			Dim lblStructuralUnbalance As Label = Me.lblStructuralUnbalance
			Me.TextBox_Change(txtUnbalance, lblStructuralUnbalance)
			Me.lblStructuralUnbalance = lblStructuralUnbalance
			Me.txtUnbalance = txtUnbalance
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtUnbalance, True, True, obj) Then
				Return
			End If
			If Not Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(obj, 0, False), RSWIN_DESC.rst.PU.UnitType = 5S)) Then
				ini.SaveDataValue("Unbalance", RuntimeHelpers.GetObjectValue(obj))
				If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.rst.Unbalance = Conversions.ToSingle(obj)
					If RSWIN_DESC.rst.PU.UnitType = 9S Then
						RSWIN_DESC.rst.Unbalance = 0F
					End If
					If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) Then
						Dim pu As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
						pu.Unbalance = Conversions.ToSingle(obj)
						RSWIN_DESC.rst.PU = pu
					Else
						RSWIN_DESC.rst.set_RequiredUnbalance(2, Conversions.ToSingle(obj))
					End If
				End If
			End If
		End Sub

		Private Sub TextBox_Change(ByRef txt As TextBox, ByRef lbl As Label)
			Try
				If Me.ActiveControl IsNot txt Then
					CtrlUI.TextBox_LostFocus(txt, lbl, True)
				Else
					Me.bValidated = False
					RSWIN_DESC.rst.gbInputDataChanged = True
					Me.TurnOffViewReportOption()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cmdReadCBLFile_Click(sender As Object, e As EventArgs)
			Me.cmdReadCBLFileClick()
		End Sub

		Private Sub cmdReadCBLFileClick()
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim flag2 As Boolean
				Dim flag As Boolean = Me.OpenCBFile(-2, flag2)
				If flag And Not flag2 Then
					Me.SetCounterbalanceTag()
					Dim txtCounterbalance As TextBox = Me.txtCounterbalance
					Dim num As Single = RSWIN_DESC.rst.get_M(2) / 1000F
					Dim text As String = "0.0"
					txtCounterbalance.Text = Util.Format(num, text)
					Dim txtCounterbalance2 As TextBox = Me.txtCounterbalance
					Dim bValidIfEmpty As Boolean = True
					Dim bShowMessage As Boolean = False
					Dim num2 As Single
					Dim obj As Object = num2
					Dim flag3 As Boolean = CtrlUI.CheckValid(txtCounterbalance2, bValidIfEmpty, bShowMessage, obj)
					num2 = Conversions.ToSingle(obj)
					If flag3 Then
						RSWIN_DESC.rst.Counterbalance = num2
					End If
					Me.optCBDataType_Click_1(0, 0, 0)
					If Strings.Len(rst.CBDataFile) > 0 Then
						Me.lblCBDataFile.Text = "File:  (" + Util.FileName(rst.CBDataFile) + ")"
						Me.lblCBDataFile.Visible = True
					Else
						Me.lblCBDataFile.Text = Me.sFileNoneSelected
						Me.lblCBDataFile.Visible = True
					End If
					If rst.CBDataType <> 1S Then
						Me.optCBDataType_Click_1(1, -1, -1)
					End If
					ini.SaveDataValue("Counterbalance", rst.get_M(2))
					ini.SaveDataValue("UnknownM", rst.UnknownM)
					ini.SaveDataValue("CBDataFile", rst.CBDataFile)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetCBALANCEData(ByRef bNotUsed As Boolean) As Short
			bNotUsed = False
			Dim result As Short
			Try
				Dim importedmoment As Util.IMPORTEDMOMENT
				Dim num As Short = If((-If((CLIPXML.ImportCBMoment(importedmoment, True) > False), 1S, 0S)), 1S, 0S)
				Dim num2 As Short = 0S
				Dim num3 As Short = 0S
				If num <> 0S Then
					If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) Then
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							Dim txtCBM As TextBox = Me.dlgCBData.txtCBM
							Dim num4 As Single = importedmoment.CBMoment / 1000F * RSWIN_DESC.MINLB__NM
							Dim text As String = "0.0"
							txtCBM.Text = Util.Format(num4, text) + " N-m"
						Else
							Dim txtCBM2 As TextBox = Me.dlgCBData.txtCBM
							Dim num4 As Single = importedmoment.CBMoment / 1000F
							Dim text As String = "0.0"
							txtCBM2.Text = Util.Format(num4, text) + " M in-lbs"
						End If
					ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						Dim txtCBM3 As TextBox = Me.dlgCBData.txtCBM
						Dim num4 As Single = importedmoment.CBMoment * RSWIN_DESC.LB__N
						Dim text As String = "0.0"
						txtCBM3.Text = Util.Format(num4, text) + " N "
					Else
						Dim txtCBM4 As TextBox = Me.dlgCBData.txtCBM
						Dim text As String = "0.0"
						txtCBM4.Text = Util.Format(importedmoment.CBMoment, text) + " lbs"
					End If
					Try
						Me.ResetClock()
					Catch ex As Exception
					End Try
					Try
						Me.dlgCBData.ShowDialog()
					Catch ex2 As Exception
						Try
							Me.dlgCBData = New dlgCBData()
							Me.dlgCBData.ShowDialog()
						Catch ex3 As Exception
						End Try
					End Try
					If Not Me.dlgCBData.bCancel Then
						Dim dlgCBData As Form = Me.dlgCBData
						Dim flag As Boolean = RSWIN.IsFormLoaded(dlgCBData)
						Me.dlgCBData = CType(dlgCBData, dlgCBData)
						If flag Then
							num3 = If((-If(((Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dlgCBData.Tag)) <> 0.0) > False), 1S, 0S)), 1S, 0S)
							Me.dlgCBData.Close()
						Else
							num2 = -1S
						End If
						dlgCBData.DefInstance = Nothing
					Else
						num2 = -1S
					End If
				End If
				If num2 <> 0S Then
					result = 0S
				Else
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					If num3 <> 0S Then
						If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) Then
							rst.set_M(2, importedmoment.CBMoment)
						Else
							rst.Unbalance = importedmoment.CBMoment
							rst.bUnknownUnbalance = False
						End If
						rst.UnknownM = (rst.get_M(2) = 0F)
						rst.CBDataFile = RSWIN_DESC.sNull
						rst.CBDataType = 1S
						result = -1S
					Else
						Dim flag2 As Boolean = Me.OpenCBFile(-2, bNotUsed)
						result = If((-If((flag2 > False), 1S, 0S)), 1S, 0S)
						If flag2 Then
							rst.UnknownM = False
							If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
								rst.bUnknownUnbalance = False
							End If
						End If
					End If
				End If
			Catch ex4 As Exception
			End Try
			Return result
		End Function

		Private Sub cboCrankHole_Click(sender As Object, e As EventArgs)
			Me.bCrankHoleClicked = True
		End Sub

		Private Sub cboCrankHole_Changed(sender As Object, e As EventArgs)
		End Sub

		Public Sub DisplayPUDataError(sMsg As String, ByRef bCancel As Boolean)
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

		Private Sub PUData_Validating(sender As Object, e As CancelEventArgs)
			Me.CheckPUData()
		End Sub

		Private Function CheckPUData() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				pu = rst.PU
				pu.CrankHole = CShort((Me.cboCrankHole.SelectedIndex + 1))
				pu.R = rst.PU.CrankRadii(CInt((pu.CrankHole - 1S)))
				Dim cboCrankRotation As ComboBox = Me.cboCrankRotation
				Dim obj As Object = Support.GetItemData(Me.cboCrankRotation, cboCrankRotation.SelectedIndex)
				If cboCrankRotation.SelectedIndex = 0 Then
					pu.CrankRotation = 1S
					RSWIN_DESC.rst.Rotation = 1S
				Else
					pu.CrankRotation = -1S
					RSWIN_DESC.rst.Rotation = -1S
				End If
				rst.PU = pu
				If rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Or rst.PU.UnitType = 6S Then
					rst.CalcMotorSPV = 0S
					rst.MotorSPV = 0F
				End If
				If rst.UnknownM Then
					rst.set_M(2, 0F)
				End If
				If RSWIN_DESC.NewData(6) <> 0S Then
					RSWIN_DESC.NewData(6) = 0S
					ini.SaveDataValue("PUData", True)
				End If
				result = True
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function CheckDimensions() As Short
			Dim result As Short = -1S
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If rst.PU.P + rst.PU.R + rst.PU.C <= rst.PU.K Then
				result = 0S
			End If
			If rst.PU.P + rst.PU.R + rst.PU.K <= rst.PU.C Then
				result = 0S
			End If
			If rst.PU.P + rst.PU.R > rst.PU.C + rst.PU.K Then
				result = 0S
			End If
			If rst.PU.P - rst.PU.R + rst.PU.C <= rst.PU.K Then
				result = 0S
			End If
			If rst.PU.P - rst.PU.R + rst.PU.K <= rst.PU.C Then
				result = 0S
			End If
			If rst.PU.P - rst.PU.R > rst.PU.C + rst.PU.K Then
				result = 0S
			End If
			If rst.PU.K <= rst.PU.I Then
				result = 0S
			End If
			Return result
		End Function

		Private Sub lvwUnitList_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.Control_SelectedIndexChanged(Me.bUnitListClicked)
			Dim lvwUnitList As ListView = Me.lvwUnitList
			If lvwUnitList.SelectedItems.Count > 0 Then
				Dim listViewItem As ListViewItem = lvwUnitList.SelectedItems(0)
				If listViewItem IsNot Nothing Then
					Me.bUnitListClicked = (Me.ActiveControl Is Me.lvwUnitList)
					Me.lvwUnitList_ItemClick_1(listViewItem, Me.bUnitListClicked)
					Me.bUnitListClicked = False
				End If
				Dim flag As Boolean = Me.ValidatePUData(True)
				If flag Then
					If RSWIN_DESC.rst.PU.UnitType = 10S Then
						Me.pnlHydraulic.Visible = True
						Me.pnlCombinationBeamCrank.Visible = False
					Else
						Me.pnlHydraulic.Visible = False
						Me.grpCounterBalance.Visible = True
						Me.pnlCombinationBeamCrank.Visible = False
					End If
				End If
			End If
		End Sub

		Private Sub lvwUnitList_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.lvwUnitList.Items
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					listViewItem.BackColor = Color.White
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If Me.lvwUnitList.SelectedItems.Count > 0 AndAlso Me.lvwUnitList Is Me.ActiveControl Then
				If CDbl(Math.Abs(RSWIN_DESC.rst.Unbalance - RSWIN_DESC.rst.PU.Unbalance)) > 0.1 And RSWIN_DESC.rst.Unbalance <> 0F And RSWIN_DESC.rst.PU.UnitType = 8S And Not Me.bUnbalancedAsked Then
					Dim dialogResult As DialogResult = MessageBox.Show(Me.sUpdateUnbalance, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					If dialogResult = DialogResult.Yes Then
						RSWIN_DESC.rst.Unbalance = RSWIN_DESC.rst.PU.Unbalance
						Me.txtUnbalance.Tag = "lee"
						Me.txtUnbalance.Text = Conversions.ToString(RSWIN_DESC.rst.Unbalance)
					End If
				ElseIf Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) Then
					RSWIN_DESC.rst.Unbalance = RSWIN_DESC.rst.PU.Unbalance
					Me.txtUnbalance.Tag = "lee"
					Me.txtUnbalance.Text = Conversions.ToString(RSWIN_DESC.rst.Unbalance)
				End If
				Try
					If RSWIN_DESC.rst.PU.UnitType = 9S Then
						RSWIN_DESC.rst.Unbalance = 0F
					End If
				Catch ex As Exception
				End Try
				Try
					If RSWIN_DESC.rst.PU.UnitType = 10S Then
						RSWIN_DESC.rst.AdjustedStrokeLength = RSWIN_DESC.rst.PU.MaxStroke
						Me.txtAdjustedStrokeLength.Tag = "cee"
						Me.txtAdjustedStrokeLength.Text = Conversions.ToString(RSWIN_DESC.rst.AdjustedStrokeLength)
					End If
				Catch ex2 As Exception
				End Try
			End If
			Me.bUnitListClicked = True
		End Sub

		Private Sub cboCrankRotation_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.Control_SelectedIndexChanged(Me.cboCrankRotation Is Me.ActiveControl)
			Me.cboCrankRotation_Click_1(CShort(Me.cboCrankRotation.SelectedIndex), Me.bCrankRotationClicked)
			Me.bCrankRotationClicked = False
		End Sub

		Private Sub cboCrankHole_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.Control_SelectedIndexChanged(Me.cboCrankHole Is Me.ActiveControl)
			Me.cboCrankHole_Click_1(CShort(Me.cboCrankHole.SelectedIndex), Me.bCrankHoleClicked)
			Me.bCrankHoleClicked = False
		End Sub

		Private Sub optCBDataType_1_CheckedChanged(sender As Object, e As EventArgs)
			Me.optCBSource_Click_1(PUData.CBSource.cbsEntered, Me.optCBDataType_1.Checked, True)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.optCBDataType_1)
		End Sub

		Private Sub optCBDataType_3_CheckedChanged(sender As Object, e As EventArgs)
			Me.optCBSource_Click_1(PUData.CBSource.cbsUnknown, Me.optCBDataType_3.Checked, True)
			If Me.optCBDataType_3.Checked Then
				RSWIN_DESC.rst.CBDataType = 0S
				RSWIN_DESC.rst.UnknownM = True
				If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
					RSWIN_DESC.rst.bUnknownUnbalance = True
				End If
			End If
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.optCBDataType_3)
		End Sub

		Public Function CheckLow(fVal1 As Single, fVal2 As Single, sMsg As String) As Boolean
			If fVal1 < fVal2 Then
				Return True
			End If
			If Not RSWIN_DESC.rst.gbBatch And RSWIN_DESC.bRSWINEXE Then
				Interaction.Beep()
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				Return False
			End If
			Dim result As Boolean
			Return result
		End Function

		Public Function CheckHigh(fVal1 As Single, fVal2 As Single, sMsg As String) As Boolean
			If fVal1 > fVal2 Then
				Return True
			End If
			If Not RSWIN_DESC.rst.gbBatch And RSWIN_DESC.bRSWINEXE Then
				Interaction.Beep()
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				Return False
			End If
			Dim result As Boolean
			Return result
		End Function

		Public Sub GetCounterbalanceParams(iUnitType As Integer, ByRef Factor As Single, ByRef IMin As Single, ByRef IMax As Single, ByRef EtoM As Single, ByRef iErrNum As Integer, ByRef sMsg As String, bQuiet As Boolean)
			Select Case iUnitType
				Case 6
					IMin = 25F
					IMax = 1000F
					Factor = 1F
					EtoM = RSWIN_DESC.PSI__KPA
					iErrNum = 5
					GoTo IL_1CA
				Case 7, 10
					iErrNum = 0
					Dim text As String = Strings.Trim(RSWIN_DESC.rst.UnitID)
					If Operators.CompareString(text, "R1", False) = 0 Then
						IMin = 9.4F
						IMax = 25F
					ElseIf Operators.CompareString(text, "R2", False) = 0 OrElse Operators.CompareString(text, "R6", False) = 0 Then
						IMin = 6.2F
						IMax = 22.5F
					ElseIf Operators.CompareString(text, "R3", False) = 0 OrElse Operators.CompareString(text, "R4", False) = 0 Then
						IMin = 13.5F
						IMax = 32.5F
					ElseIf Operators.CompareString(text, "R5", False) = 0 Then
						IMin = 9.4F
						IMax = 21.5F
					Else
						IMin = 0.5F
						IMax = 100F
						iErrNum = 13
					End If
					Factor = 1000F
					EtoM = RSWIN_DESC.LB__N * Factor
					If iErrNum = 0 Then
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							Util.LoadMessage(15, sMsg)
							Util.ApplyNumber(IMin, sMsg)
							Util.ApplyNumber(IMax, sMsg)
						Else
							Util.LoadMessage(16, sMsg)
							Util.ApplyNumber(IMin, sMsg)
							Util.ApplyNumber(IMax, sMsg)
							Util.ApplyNumber(IMin * EtoM, sMsg)
							Util.ApplyNumber(IMax * EtoM, sMsg)
							If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								IMin *= Factor
								IMax *= Factor
								Factor = 1F
							End If
						End If
						GoTo IL_1CA
					End If
					GoTo IL_1CA
			End Select
			IMin = 1F
			IMax = 8000F
			Factor = 1000F
			EtoM = RSWIN_DESC.MINLB__NM
			iErrNum = 11
			IL_1CA:
			If bQuiet And Me.ActiveControl IsNot Me.txtCounterbalance Then
				sMsg = ""
				Return
			End If
		End Sub

		Private Sub txtCounterbalance_Leave(sender As Object, e As EventArgs)
			Try
				Dim txtCounterbalance As Control = Me.txtCounterbalance
				CtrlUI.Control_LostFocus(txtCounterbalance)
				Me.txtCounterbalance = CType(txtCounterbalance, TextBox)
				Me.AssignCounterbalanceValue(False, True)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub AssignCounterbalanceValue(bQuiet As Boolean, bLeavingTxtCounterbalance As Boolean)
			Try
				If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
					bQuiet = True
				End If
				Dim num As Single
				Dim num2 As Single
				Dim num3 As Single
				Dim num4 As Single
				Dim num5 As Integer
				Dim text As String
				Me.GetCounterbalanceParams(CInt(RSWIN_DESC.rst.PU.UnitType), num, num2, num3, num4, num5, text, bQuiet)
				If bQuiet And Me.ActiveControl IsNot Me.txtCounterbalance Then
					text = ""
				End If
				Dim flag As Boolean = False
				Dim obj As Object
				If flag <> CtrlUI.CheckValid(Me.txtCounterbalance, True, False, obj) Then
					Dim obj2 As Object = flag
					Dim lowerBound As Single = num2
					Dim inclusive As Integer = -1
					Dim errnum As Integer = num5
					Dim useMetric As Integer = -1
					Dim canadianIsMetric As Integer = -1
					Dim bQuiet2 As Boolean = bQuiet
					Dim text2 As String = ""
					If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet2, text2), False) Then
						If Not bQuiet Then
							If num5 <> 0 Then
								Me.txtCounterbalance.Focus()
							ElseIf Operators.CompareString(text, "", False) <> 0 Then
								Dim msg As String = text
								Dim bDefaultYes As Boolean = True
								Dim flag2 As Boolean = False
								If Not Util.YesNo(msg, bDefaultYes, flag2) Then
									Me.txtCounterbalance.Focus()
								End If
							Else
								ini.SaveDataValue("Counterbalance", Operators.MultiplyObject(num, obj))
								If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
									RSWIN_DESC.rst.set_M(2, Conversions.ToSingle(Operators.MultiplyObject(num, obj)))
								End If
							End If
						End If
					Else
						Dim obj3 As Object = flag
						Dim upperBound As Single = num3
						Dim inclusive2 As Integer = -1
						Dim errnum2 As Integer = num5
						Dim useMetric2 As Integer = -1
						Dim canadianIsMetric2 As Integer = -1
						Dim bQuiet3 As Boolean = bQuiet Or Me.ActiveControl Is Me.txtCounterbalance
						text2 = ""
						If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet3, text2), False) Then
							If bLeavingTxtCounterbalance Then
								text = ""
							End If
							If Not bQuiet Or Me.ActiveControl Is Me.txtCounterbalance Then
								If num5 <> 0 Then
									Me.txtCounterbalance.Focus()
								ElseIf Operators.CompareString(text, "", False) <> 0 Then
									If Me.ActiveControl Is Me.txtCounterbalance Then
										MessageBox.Show(text.Replace("Do you want to continue, using the value you entered?", ""))
									End If
								Else
									ini.SaveDataValue("Counterbalance", Operators.MultiplyObject(num, obj))
									If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
										RSWIN_DESC.rst.set_M(2, Conversions.ToSingle(Operators.MultiplyObject(num, obj)))
									End If
								End If
							End If
						Else
							ini.SaveDataValue("Counterbalance", Operators.MultiplyObject(num, obj))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
								RSWIN_DESC.rst.set_M(2, Conversions.ToSingle(Operators.MultiplyObject(num, obj)))
							End If
						End If
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

		Private Sub txtUnitID_Enter(sender As Object, e As EventArgs)
			Me.txtUnitID.BackColor = RSWIN_DESC.rgbEditFocus
			Me.savedUnitID = Strings.UCase(Me.txtUnitID.Text.Trim())
		End Sub

		Private Sub cboManufMenu_Enter(sender As Object, e As EventArgs)
			Me.cboManufMenu.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboManufMenu_Leave(sender As Object, e As EventArgs)
			Dim cboManufMenu As Control = Me.cboManufMenu
			CtrlUI.Control_LostFocus(cboManufMenu)
			Me.cboManufMenu = CType(cboManufMenu, ComboBox)
		End Sub

		Private Sub cboCrankRotation_Enter(sender As Object, e As EventArgs)
			Me.cboCrankRotation.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboCrankRotation_Leave(sender As Object, e As EventArgs)
			Dim cboCrankRotation As Control = Me.cboCrankRotation
			CtrlUI.Control_LostFocus(cboCrankRotation)
			Me.cboCrankRotation = CType(cboCrankRotation, ComboBox)
		End Sub

		Private Sub cboCrankHole_Enter(sender As Object, e As EventArgs)
			Me.cboCrankHole.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboCrankHole_Leave(sender As Object, e As EventArgs)
			Dim cboCrankHole As Control = Me.cboCrankHole
			CtrlUI.Control_LostFocus(cboCrankHole)
			Me.cboCrankHole = CType(cboCrankHole, ComboBox)
		End Sub

		Private Sub txtUnbalance_Enter(sender As Object, e As EventArgs)
			Me.txtUnbalance.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtCounterbalance_Enter(sender As Object, e As EventArgs)
			Me.txtCounterbalance.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub lvwUnitList_Enter(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtUnbalance_Leave(sender As Object, e As EventArgs)
			Dim text As String = ""
			Dim txtUnbalance As Control = Me.txtUnbalance
			CtrlUI.Control_LostFocus(txtUnbalance)
			Me.txtUnbalance = CType(txtUnbalance, TextBox)
			Dim num As Integer
			Dim newValue As String
			Dim newValue2 As String
			Dim num2 As Integer
			Dim newValue3 As String
			Dim newValue4 As String
			If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
				num = 100
				newValue = "100"
				newValue2 = "445"
				num2 = 15000
				newValue3 = "15,000"
				newValue4 = "66,723"
			ElseIf RSWIN_DESC.rst.PU.UnitType = 5S Then
				num = -10000
				newValue = "-10,000"
				newValue2 = "-44,482"
				num2 = 0
				newValue3 = "0"
				newValue4 = "0"
			Else
				num = -12000
				newValue = "-12,000"
				newValue2 = "-53,379"
				num2 = 12000
				newValue3 = "12,000"
				newValue4 = "53,379"
			End If
			Dim errnum As Integer
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				errnum = 85
			Else
				errnum = 84
			End If
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtUnbalance, True, False, obj) Then
				Return
			End If
			If Operators.ConditionalCompareObjectEqual(flag, Util.CheckLower(obj, CSng(num), -1, errnum, -1, -1, True, text), False) Then
				text = text.Replace("-12,000", newValue)
				text = text.Replace("12,000", newValue3)
				text = text.Replace("-53,379", newValue2)
				text = text.Replace("53,379", newValue4)
				MessageBox.Show(text)
				Me.txtUnbalance.Focus()
				Return
			End If
			If Operators.ConditionalCompareObjectEqual(flag, Util.CheckUpper(obj, CSng(num2), -1, errnum, -1, -1, True, text), False) Then
				text = text.Replace("-12,000", newValue)
				text = text.Replace("12,000", newValue3)
				text = text.Replace("-53,379", newValue2)
				text = text.Replace("53,379", newValue4)
				MessageBox.Show(text)
				Me.txtUnbalance.Focus()
				Return
			End If
			If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(obj, 0, False), RSWIN_DESC.rst.PU.UnitType = 5S)) Then
				Util.cErrmsg(27)
				Me.txtUnbalance.Focus()
			Else
				ini.SaveDataValue("Unbalance", RuntimeHelpers.GetObjectValue(obj))
				If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
					If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) Then
						Dim pu As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
						pu.Unbalance = Conversions.ToSingle(obj)
						RSWIN_DESC.rst.PU = pu
					End If
					RSWIN_DESC.rst.Unbalance = Conversions.ToSingle(obj)
				End If
			End If
		End Sub

		Private Sub txtUnitID_Leave(sender As Object, e As EventArgs)
			Try
				Dim txtUnitID As Control = Me.txtUnitID
				CtrlUI.Control_LostFocus(txtUnitID)
				Me.txtUnitID = CType(txtUnitID, TextBox)
				Dim text As String = Strings.UCase(Me.txtUnitID.Text.Trim())
				If text.Length <> 0 Then
					If Operators.CompareString(text, Me.savedUnitID, False) = 0 And Me.cboCrankHole.Enabled Then
						Me.txtUnitID.Text = text
					Else
						Dim text2 As String = Me.txtUnitID.Text
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						Dim pu As RSWIN_DESC.PUDataRec = rst.PU
						Dim flag As Boolean = PUDATA1.ReadPUData(text2, pu, False, True)
						rst.PU = pu
						If Not flag Then
							Util.Errmsg(Me.sProdNotValid)
							Me.txtUnitID.Focus()
						Else
							RSWIN_DESC.rst.IDEntered = -1S
							Dim rst2 As cRODSTAR = RSWIN_DESC.rst
							pu = RSWIN_DESC.rst.PU
							rst2.Unbalance = pu.Unbalance
							Me.ShowManuf()
							Me.ShowUnit(True)
							Me.CheckUnitType()
							Me.ShowCounterbalanceOptions(0)
							Me.ShowUnitInfo(True)
							ini.SaveDataValue("UnitID", RSWIN_DESC.rst.UnitID.Trim())
							ini.SaveDataValue("IDEntered", RSWIN_DESC.rst.IDEntered)
						End If
					End If
				End If
			Catch ex As Exception
				MessageBox.Show("Error txtUnitID_Leave: " + ex.Message)
			End Try
		End Sub

		Private Sub chkCustomPUDB_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub chkCustomPUDB_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkCustomPUDB_Click_1(Me.chkCustomPUDB.Checked, True)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.chkCustomPUDB)
		End Sub

		Private Sub cboCrankRotation_Click(sender As Object, e As EventArgs)
			Me.bCrankRotationClicked = True
		End Sub

		Private Sub cboManufMenu_Click(sender As Object, e As EventArgs)
			Me.bManufMenuClicked = True
		End Sub

		Private Sub lvwUnitList_Leave(sender As Object, e As EventArgs)
			Try
				Me.lvwUnitList.SelectedItems(0).EnsureVisible()
				Me.lvwUnitList.SelectedItems(0).Focused = True
				Me.lvwUnitList.SelectedItems(0).BackColor = Color.Gray
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtCounterbalance_TextChanged(sender As Object, e As EventArgs)
			Try
				Dim txtCounterbalance As TextBox = Me.txtCounterbalance
				Dim lblMInLbs As Label = Me.lblMInLbs
				Me.TextBox_Change(txtCounterbalance, lblMInLbs)
				Me.lblMInLbs = lblMInLbs
				Me.txtCounterbalance = txtCounterbalance
				If Me.txtCounterbalance.Enabled Then
					Me.AssignCounterbalanceValue(Me.ActiveControl Is Me.txtCounterbalance, False)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PUData_Activated(sender As Object, e As EventArgs)
			Me.m_bClosing = False
			RSWIN_DESC.sCurrentFormName = "PUData"
			If Strings.InStr(RSWIN_DESC.rst.UnitID.Trim(), "CUSTOM", CompareMethod.Binary) > 0 Then
				If RSWIN_DESC.rst.PU.RequiredRotation = 1S Or RSWIN_DESC.rst.PU.RequiredRotation = -1S Then
					Me.cboCrankRotation.Enabled = False
					Dim pu As RSWIN_DESC.PUDataRec
					pu.Initialize()
					pu = RSWIN_DESC.rst.PU
					pu.CrankRotation = RSWIN_DESC.rst.PU.RequiredRotation
					RSWIN_DESC.rst.PU = pu
					If RSWIN_DESC.rst.PU.RequiredRotation = 1S Then
						Me.cboCrankRotation.SelectedIndex = 0
					ElseIf RSWIN_DESC.rst.PU.RequiredRotation = -1S Then
						Me.cboCrankRotation.SelectedIndex = 1
					End If
				Else
					Me.cboCrankRotation.Enabled = True
				End If
				Return
			End If
		End Sub

		Private Sub PUData_Closed(sender As Object, e As EventArgs)
			Me.m_bClosing = False
		End Sub

		Private Sub PUData_Closing(sender As Object, e As CancelEventArgs)
			Me.m_bClosing = True
			Dim flag As Boolean = Me.ValidatePUData(False)
			If Not Me.m_bClosing Or (Me.m_bClosing And Not flag) Then
				e.Cancel = True
				Return
			End If
			RSWIN_DESC.sCurrentFormName = ""
		End Sub

		Private Sub PUData_Deactivate(sender As Object, e As EventArgs)
		End Sub

		Private Sub PUData_Disposed(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtCBAngle_Layout(sender As Object, e As LayoutEventArgs)
		End Sub

		Private Sub cmdCBApplet_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean
				If Me.GetCBALANCEData(flag) <> 0S Then
					If Not flag Then
						If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) Then
							Me.SetCounterbalanceTag()
							Dim txtCounterbalance As TextBox = Me.txtCounterbalance
							Dim num As Single = RSWIN_DESC.rst.get_M(2) / 1000F
							Dim text As String = "0.0"
							txtCounterbalance.Text = Util.Format(num, text)
							Dim txtCounterbalance2 As TextBox = Me.txtCounterbalance
							Dim bValidIfEmpty As Boolean = True
							Dim bShowMessage As Boolean = False
							Dim num2 As Single
							Dim obj As Object = num2
							Dim flag2 As Boolean = CtrlUI.CheckValid(txtCounterbalance2, bValidIfEmpty, bShowMessage, obj)
							num2 = Conversions.ToSingle(obj)
							If flag2 Then
								RSWIN_DESC.rst.Counterbalance = num2
							End If
							RSWIN_DESC.rst.UnknownM = False
							Me.optCBDataType_1.Checked = True
							RSWIN_DESC.rst.CBDataType = 1S
							Me.ShowCounterbalance()
							ini.SaveDataValue("Counterbalance", RSWIN_DESC.rst.get_M(2))
							ini.SaveDataValue("UnknownM", RSWIN_DESC.rst.UnknownM)
							ini.SaveDataValue("CBDataFile", RSWIN_DESC.rst.CBDataFile)
						Else
							Me.txtUnbalance.Tag = "lee"
							Me.txtUnbalance.Text = Conversions.ToString(RSWIN_DESC.rst.Unbalance)
							RSWIN_DESC.rst.UnknownM = False
							RSWIN_DESC.rst.bUnknownUnbalance = False
							Me.optCBDataType_1.Checked = True
							RSWIN_DESC.rst.CBDataType = 1S
							Me.ShowCounterbalance()
							ini.SaveDataValue("Unbalance", RSWIN_DESC.rst.Unbalance)
						End If
					End If
				Else
					Me.cmdReadCBLFileClick()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub optCBDataType_5_CheckedChanged(sender As Object, e As EventArgs)
			Me.optCBSource_Click_1(CType(5, PUData.CBSource), Me.optCBDataType_5.Checked, True)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.optCBDataType_5)
		End Sub

		Private Sub optCBDataType_6_CheckedChanged(sender As Object, e As EventArgs)
			Me.optCBSource_Click_1(CType(6, PUData.CBSource), Me.optCBDataType_6.Checked, True)
			Me.cmdReadCBLFile.Enabled = Me.optCBDataType_6.Enabled
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.optCBDataType_6)
		End Sub

		Public Function OpenCBFile(iFile As Integer, ByRef bNotUsed As Boolean) As Boolean
			Dim result As Boolean
			Try
				Dim text As String = Interaction.Command()
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
				Dim flag As Boolean = False
				Dim fileName As String = mCbalance_dec.cbf.FileName
				bNotUsed = False
				Dim text2 As String
				If iFile = -2 Then
					text2 = ""
					openFileDialog.InitialDirectory = Conversions.ToString(RSWIN.GetInitialDir(".CBL", ""))
					openFileDialog.Filter = "XBAL files (*.xblx)|*.xblx|CBALANCE Files(*.cbl,*.cblx)|*.cbl;*.cblx"
					openFileDialog.FilterIndex = 1
					openFileDialog.Title = "Open XBAL file."
					openFileDialog.ShowHelp = True
					openFileDialog.RestoreDirectory = True
					Try
						Me.ResetClock()
					Catch ex As Exception
					End Try
					If openFileDialog.ShowDialog() = DialogResult.OK Then
						text2 = openFileDialog.FileName
						Dim num As Integer = Strings.InStrRev(text2, "\", -1, CompareMethod.Binary)
						If num > 0 Then
							mCbalance_dec.msCBLDir = Strings.Mid(text2, 1, num)
						End If
					End If
				End If
				If Operators.CompareString(text2, "", False) <> 0 Then
					mCbalance_dec.cbf.FileName = text2
					Try
						mCbalance_dec.cbf.ReadFile()
						If mCbalance_dec.cbf.FileRead Then
							flag = True
							mCbalance_dec.gbInputDataChanged = 0
							RSWIN_DESC.rst.CBDataFile = text2
							If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
								If Operators.CompareString(mCbalance_dec.cbf.UnitTypeKey.ToUpper(), "SNT", False) = 0 Or Operators.CompareString(mCbalance_dec.cbf.UnitTypeKey.ToUpper(), "CHC", False) = 0 Or Operators.CompareString(mCbalance_dec.cbf.UnitTypeKey.ToUpper(), "JNS", False) = 0 Then
									RSWIN_DESC.rst.Unbalance = mCbalance_dec.cbf.ExistingMCM
								Else
									Dim dialogResult As DialogResult = MessageBox.Show(Me.sXBALFileMessage2, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
									If dialogResult = DialogResult.Yes Then
										RSWIN_DESC.rst.Unbalance = mCbalance_dec.cbf.ExistingMCM
									Else
										RSWIN_DESC.rst.CBDataFile = ""
										bNotUsed = True
									End If
								End If
							ElseIf Operators.CompareString(mCbalance_dec.cbf.UnitTypeKey.ToUpper(), "SNT", False) = 0 Or Operators.CompareString(mCbalance_dec.cbf.UnitTypeKey.ToUpper(), "CHC", False) = 0 Or Operators.CompareString(mCbalance_dec.cbf.UnitTypeKey.ToUpper(), "JNS", False) = 0 Then
								Dim dialogResult As DialogResult = MessageBox.Show(Me.sXBALFileMessage1, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
								If dialogResult = DialogResult.Yes Then
									RSWIN_DESC.rst.set_M(2, mCbalance_dec.cbf.ExistingMCM)
								Else
									RSWIN_DESC.rst.CBDataFile = ""
									bNotUsed = True
								End If
							Else
								RSWIN_DESC.rst.set_M(2, mCbalance_dec.cbf.ExistingMCM)
							End If
						Else
							Interaction.MsgBox("Unable to open file " + mCbalance_dec.cbf.FileName, MsgBoxStyle.Exclamation, Nothing)
							mCbalance_dec.cbf.FileName = fileName
						End If
					Catch ex2 As Exception
						Dim text3 As String
						If Information.Err().Number = 53 Or Information.Err().Number = 9953 Then
							text3 = "File not found: " + mCbalance_dec.cbf.FileName
						Else
							text3 = "Unable to open file " + mCbalance_dec.cbf.FileName + vbCrLf + mCbalance_dec.cbf.CBErrDescription
							If Operators.CompareString(mCbalance_dec.cbf.CBErrDescription, "", False) = 0 Then
								text3 = text3 + vbCrLf + ex2.Message
							End If
						End If
						Interaction.MsgBox(text3, MsgBoxStyle.Exclamation, Nothing)
						mCbalance_dec.cbf.FileName = fileName
					End Try
				End If
				result = flag
			Catch ex3 As Exception
			End Try
			Return result
		End Function

		Private Sub lblCalcStroke_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub cmdUnitSizeRecommendation_Click(sender As Object, e As EventArgs)
			Try
				Me.SetRecommendedUnit(True)
				Me.TurnOffViewReportOption()
			Catch ex As Exception
			End Try
		End Sub

		Public Function RecommendPUData(ByRef GearboxRating As Integer, ByRef StructRating As Integer, ByRef MaxStroke As Integer) As Boolean
			Dim bFiberglass As Boolean = False
			Dim result As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim flag As Boolean
				If rst.SPMEntered <> 0S Then
					flag = False
				Else
					If rst.RodStringType = 3S Then
						If rst.giRodDesignStyle = 0S Then
							bFiberglass = False
							rst.gbSteelRodString = True
						ElseIf rst.giRodDesignStyle = 1S Then
							bFiberglass = True
							rst.gbSteelRodString = False
						End If
					Else
						bFiberglass = False
						Dim num As Integer = 1
						Dim numRods As Integer = CInt(rst.NumRods)
						For i As Integer = num To numRods
							If RODUTIL.IsFG(rst.Sections(i).Grade) Then
								bFiberglass = True
								Exit For
							End If
						Next
					End If
					flag = Me.GetPUDataRecommendation(bFiberglass, RSWIN_DESC.rst.TargetBFPD, RSWIN_DESC.rst.PumpDepth, GearboxRating, StructRating, MaxStroke)
				End If
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub SetUnit(PUNum As Integer, Clicked As Boolean)
			Dim listViewItem As ListViewItem = New ListViewItem()
			Try
				Dim text As String = "*" + Convert.ToString(PUNum)
				Try
					For Each obj As Object In Me.lvwUnitList.Items
						listViewItem = CType(obj, ListViewItem)
						Debug.WriteLine(listViewItem.Text + " , " + listViewItem.ToString())
						If LikeOperator.LikeString(listViewItem.Text, text, CompareMethod.Binary) AndAlso Me.CheckNumbers(listViewItem.Text, text) Then
							Me.lvwUnitList.Items(Me.GetIndexFromText(listViewItem.Text)).Selected = True
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex As Exception
			End Try
		End Sub

		Public Function CheckNumbers(sVal1 As String, sVal2 As String) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim num As Integer = Convert.ToInt32(sVal2.Substring(1))
				Dim text As String = ""
				Dim num2 As Integer = 1
				Dim length As Integer = sVal1.Length
				For i As Integer = num2 To length
					Dim text2 As String = sVal1.Substring(i - 1, 1)
					If Versioned.IsNumeric(text2) Then
						text += text2
					End If
				Next
				If Versioned.IsNumeric(text) Then
					Dim num3 As Integer = Convert.ToInt32(text)
					If num3 = num Then
						flag = True
					End If
				End If
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub PUData_MenuStart(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtCounterbalance_EnabledChanged(sender As Object, e As EventArgs)
			If Not Me.txtCounterbalance.Enabled Then
				Me.txtCounterbalance.BackColor = Color.LightGray
				Me.lblCounterbalance_Disabled.BringToFront()
				Return
			End If
			Me.txtCounterbalance.BackColor = Color.White
			Me.lblCounterbalance_Disabled.SendToBack()
		End Sub

		Public Sub PopulateRecPUAL()
			Try
				If Me.cboManufMenu.SelectedItem IsNot Nothing Then
					If Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "Mark II", CompareMethod.Binary) > 0 Then
						Me.bMarkII = True
					Else
						Me.bMarkII = False
					End If
					If Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "Reverse", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "American Producer II", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "Maximizer II", CompareMethod.Binary) > 0 Then
						Me.bRMark = True
					Else
						Me.bRMark = False
					End If
					If Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "Rotaflex", CompareMethod.Binary) > 0 Then
						Me.bRotaflex = True
					Else
						Me.bRotaflex = False
					End If
					If Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "Air", CompareMethod.Binary) > 0 And Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "Balanced", CompareMethod.Binary) > 0 Then
						Me.bAB = True
					Else
						Me.bAB = False
					End If
				Else
					If RSWIN_DESC.rst.PU.UnitType = 5S Then
						Me.bMarkII = True
					Else
						Me.bMarkII = False
					End If
					If RSWIN_DESC.rst.PU.UnitType = 2S Or Strings.InStr(RSWIN_DESC.rst.PU.Manuf, "Reverse", CompareMethod.Binary) > 0 Or Strings.InStr(RSWIN_DESC.rst.PU.Manuf, "American Producer II", CompareMethod.Binary) > 0 Or Strings.InStr(RSWIN_DESC.rst.PU.Manuf, "Maximizer II", CompareMethod.Binary) > 0 Then
						Me.bRMark = True
					Else
						Me.bRMark = False
					End If
					If RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S Or Operators.CompareString(RSWIN_DESC.rst.PU.Manuf.Trim(), "Rotaflex", False) = 0 Then
						Me.bRotaflex = True
					Else
						Me.bRotaflex = False
					End If
					If RSWIN_DESC.rst.PU.UnitType = 6S Then
						Me.bAB = True
					Else
						Me.bAB = False
					End If
				End If
			Catch ex As Exception
			End Try
			If Me.bMarkII Then
				Me.PopulateRecPUFGal_MarkII()
				Me.PopulateRecPUSTAL_MarkII()
				Return
			End If
			If Me.bRMark Then
				Me.PopulateRecPUFGAL_RMark()
				Me.PopulateRecPUStal_RMark()
				Return
			End If
			If Me.bRotaflex Then
				Me.PopulateRecPUFGAL_Rotaflex()
				Me.PopulateRecPUSTAL_Rotaflex()
				Return
			End If
			If Me.bAB Then
				Me.PopulateRecPUStal_AB()
				Me.PopulateRecPUFGal_AB()
				Return
			End If
			Me.PopulateRecPUFGal()
			Me.PopulateRecPUStal_Conv()
		End Sub

		Private Sub PopulateRecPUFGal()
			Try
				Me.table_2000_fg.Clear()
				Me.table_2000_fg.Add(New cRecPU(100, 40, 67, 36))
				Me.table_2000_fg.Add(New cRecPU(150, 57, 76, 42))
				Me.table_2000_fg.Add(New cRecPU(200, 80, 76, 42))
				Me.table_2000_fg.Add(New cRecPU(300, 114, 119, 54))
				Me.table_2000_fg.Add(New cRecPU(350, 160, 119, 64))
				Me.table_2000_fg.Add(New cRecPU(400, 160, 119, 74))
				Me.table_2000_fg.Add(New cRecPU(450, 228, 121, 74))
				Me.table_2000_fg.Add(New cRecPU(550, 228, 121, 86))
				Me.table_2000_fg.Add(New cRecPU(650, 320, 121, 100))
				Me.table_2000_fg.Add(New cRecPU(750, 320, 121, 120))
				Me.table_2000_fg.Add(New cRecPU(800, 320, 143, 120))
				Me.table_2000_fg.Add(New cRecPU(900, 456, 143, 120))
				Me.table_2000_fg.Add(New cRecPU(1100, 456, 160, 120))
				Me.table_2000_fg.Add(New cRecPU(1300, 640, 198, 144))
				Me.table_2000_fg.Add(New cRecPU(1400, 640, 198, 168))
				Me.table_2000_fg.Add(New cRecPU(1900, 912, 212, 192))
				Me.table_2000_fg.Add(New cRecPU(2200, 1280, 246, 192))
				Me.table_2000_fg.Add(New cRecPU(2500, 1280, 246, 216))
				Me.table_2000_fg.Add(New cRecPU(2800, 1824, 305, 240))
				Me.table_2500_fg.Clear()
				Me.table_2500_fg.Add(New cRecPU(100, 80, 75, 48))
				Me.table_2500_fg.Add(New cRecPU(150, 114, 95, 48))
				Me.table_2500_fg.Add(New cRecPU(250, 160, 119, 64))
				Me.table_2500_fg.Add(New cRecPU(300, 160, 121, 64))
				Me.table_2500_fg.Add(New cRecPU(400, 228, 121, 74))
				Me.table_2500_fg.Add(New cRecPU(450, 228, 160, 86))
				Me.table_2500_fg.Add(New cRecPU(600, 320, 165, 100))
				Me.table_2500_fg.Add(New cRecPU(700, 456, 165, 120))
				Me.table_2500_fg.Add(New cRecPU(750, 456, 200, 120))
				Me.table_2500_fg.Add(New cRecPU(800, 456, 213, 120))
				Me.table_2500_fg.Add(New cRecPU(1100, 640, 200, 144))
				Me.table_2500_fg.Add(New cRecPU(1200, 640, 212, 144))
				Me.table_2500_fg.Add(New cRecPU(1600, 912, 256, 168))
				Me.table_2500_fg.Add(New cRecPU(1800, 1280, 305, 192))
				Me.table_2500_fg.Add(New cRecPU(2000, 1824, 305, 216))
				Me.table_2500_fg.Add(New cRecPU(2100, 1824, 305, 240))
				Me.table_2500_fg.Add(New cRecPU(2300, 1824, 305, 260))
				Me.table_3000_fg.Clear()
				Me.table_3000_fg.Add(New cRecPU(100, 80, 95, 48))
				Me.table_3000_fg.Add(New cRecPU(200, 114, 133, 48))
				Me.table_3000_fg.Add(New cRecPU(300, 160, 143, 64))
				Me.table_3000_fg.Add(New cRecPU(350, 228, 143, 64))
				Me.table_3000_fg.Add(New cRecPU(400, 320, 150, 74))
				Me.table_3000_fg.Add(New cRecPU(450, 320, 165, 74))
				Me.table_3000_fg.Add(New cRecPU(600, 320, 212, 86))
				Me.table_3000_fg.Add(New cRecPU(750, 456, 212, 100))
				Me.table_3000_fg.Add(New cRecPU(900, 640, 212, 120))
				Me.table_3000_fg.Add(New cRecPU(1000, 640, 253, 144))
				Me.table_3000_fg.Add(New cRecPU(1200, 912, 253, 168))
				Me.table_3000_fg.Add(New cRecPU(1300, 912, 253, 192))
				Me.table_3000_fg.Add(New cRecPU(1600, 1280, 253, 192))
				Me.table_3000_fg.Add(New cRecPU(1800, 1824, 253, 216))
				Me.table_3000_fg.Add(New cRecPU(2000, 1824, 305, 240))
				Me.table_3500_fg.Clear()
				Me.table_3500_fg.Add(New cRecPU(50, 80, 95, 48))
				Me.table_3500_fg.Add(New cRecPU(100, 114, 119, 54))
				Me.table_3500_fg.Add(New cRecPU(150, 160, 133, 54))
				Me.table_3500_fg.Add(New cRecPU(200, 160, 169, 54))
				Me.table_3500_fg.Add(New cRecPU(300, 228, 169, 64))
				Me.table_3500_fg.Add(New cRecPU(400, 320, 200, 74))
				Me.table_3500_fg.Add(New cRecPU(450, 320, 212, 86))
				Me.table_3500_fg.Add(New cRecPU(550, 456, 212, 100))
				Me.table_3500_fg.Add(New cRecPU(750, 640, 213, 120))
				Me.table_3500_fg.Add(New cRecPU(900, 640, 253, 120))
				Me.table_3500_fg.Add(New cRecPU(1000, 912, 256, 144))
				Me.table_3500_fg.Add(New cRecPU(1200, 912, 305, 168))
				Me.table_3500_fg.Add(New cRecPU(1400, 1280, 305, 192))
				Me.table_3500_fg.Add(New cRecPU(1500, 1280, 305, 192))
				Me.table_3500_fg.Add(New cRecPU(1600, 1824, 305, 216))
				Me.table_3500_fg.Add(New cRecPU(1730, 1824, 305, 260))
				Me.table_4000_fg.Clear()
				Me.table_4000_fg.Add(New cRecPU(50, 80, 95, 48))
				Me.table_4000_fg.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4000_fg.Add(New cRecPU(150, 160, 169, 54))
				Me.table_4000_fg.Add(New cRecPU(200, 228, 173, 64))
				Me.table_4000_fg.Add(New cRecPU(350, 320, 200, 74))
				Me.table_4000_fg.Add(New cRecPU(400, 320, 246, 74))
				Me.table_4000_fg.Add(New cRecPU(550, 456, 298, 86))
				Me.table_4000_fg.Add(New cRecPU(650, 640, 298, 100))
				Me.table_4000_fg.Add(New cRecPU(800, 912, 305, 120))
				Me.table_4000_fg.Add(New cRecPU(850, 912, 305, 144))
				Me.table_4000_fg.Add(New cRecPU(1000, 1280, 365, 168))
				Me.table_4000_fg.Add(New cRecPU(1100, 1280, 365, 192))
				Me.table_4000_fg.Add(New cRecPU(1300, 1824, 305, 216))
				Me.table_4000_fg.Add(New cRecPU(1500, 1824, 305, 240))
				Me.table_4500_fg.Clear()
				Me.table_4500_fg.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4500_fg.Add(New cRecPU(150, 160, 169, 54))
				Me.table_4500_fg.Add(New cRecPU(250, 228, 173, 64))
				Me.table_4500_fg.Add(New cRecPU(300, 320, 173, 74))
				Me.table_4500_fg.Add(New cRecPU(350, 456, 213, 86))
				Me.table_4500_fg.Add(New cRecPU(400, 456, 256, 100))
				Me.table_4500_fg.Add(New cRecPU(550, 640, 305, 120))
				Me.table_4500_fg.Add(New cRecPU(600, 912, 305, 120))
				Me.table_4500_fg.Add(New cRecPU(800, 912, 305, 144))
				Me.table_4500_fg.Add(New cRecPU(1100, 1280, 365, 192))
				Me.table_4500_fg.Add(New cRecPU(1200, 1824, 305, 240))
				Me.table_5000_fg.Clear()
				Me.table_5000_fg.Add(New cRecPU(100, 114, 119, 54))
				Me.table_5000_fg.Add(New cRecPU(150, 160, 169, 54))
				Me.table_5000_fg.Add(New cRecPU(200, 228, 173, 64))
				Me.table_5000_fg.Add(New cRecPU(250, 320, 173, 74))
				Me.table_5000_fg.Add(New cRecPU(350, 456, 256, 86))
				Me.table_5000_fg.Add(New cRecPU(400, 456, 298, 86))
				Me.table_5000_fg.Add(New cRecPU(500, 640, 305, 120))
				Me.table_5000_fg.Add(New cRecPU(650, 912, 305, 120))
				Me.table_5000_fg.Add(New cRecPU(750, 912, 356, 144))
				Me.table_5000_fg.Add(New cRecPU(800, 1280, 356, 168))
				Me.table_5000_fg.Add(New cRecPU(950, 1824, 365, 216))
				Me.table_5000_fg.Add(New cRecPU(1000, 1824, 305, 240))
				Me.table_5500_fg.Clear()
				Me.table_5500_fg.Add(New cRecPU(100, 160, 143, 74))
				Me.table_5500_fg.Add(New cRecPU(150, 228, 173, 74))
				Me.table_5500_fg.Add(New cRecPU(300, 320, 212, 86))
				Me.table_5500_fg.Add(New cRecPU(350, 456, 298, 86))
				Me.table_5500_fg.Add(New cRecPU(400, 640, 298, 100))
				Me.table_5500_fg.Add(New cRecPU(450, 640, 305, 120))
				Me.table_5500_fg.Add(New cRecPU(600, 912, 305, 144))
				Me.table_5500_fg.Add(New cRecPU(650, 912, 356, 144))
				Me.table_5500_fg.Add(New cRecPU(700, 1280, 365, 192))
				Me.table_5500_fg.Add(New cRecPU(750, 1824, 365, 216))
				Me.table_6000_fg.Clear()
				Me.table_6000_fg.Add(New cRecPU(100, 114, 143, 64))
				Me.table_6000_fg.Add(New cRecPU(150, 228, 173, 74))
				Me.table_6000_fg.Add(New cRecPU(200, 320, 212, 86))
				Me.table_6000_fg.Add(New cRecPU(350, 456, 256, 100))
				Me.table_6000_fg.Add(New cRecPU(400, 640, 305, 120))
				Me.table_6000_fg.Add(New cRecPU(450, 912, 305, 144))
				Me.table_6000_fg.Add(New cRecPU(650, 1280, 365, 192))
				Me.table_6000_fg.Add(New cRecPU(750, 1824, 365, 216))
				Me.table_6000_fg.Add(New cRecPU(800, 1824, 365, 240))
				Me.table_6500_fg.Clear()
				Me.table_6500_fg.Add(New cRecPU(50, 160, 119, 86))
				Me.table_6500_fg.Add(New cRecPU(150, 228, 200, 74))
				Me.table_6500_fg.Add(New cRecPU(200, 320, 212, 86))
				Me.table_6500_fg.Add(New cRecPU(350, 456, 256, 100))
				Me.table_6500_fg.Add(New cRecPU(450, 640, 305, 120))
				Me.table_6500_fg.Add(New cRecPU(550, 912, 356, 144))
				Me.table_6500_fg.Add(New cRecPU(600, 1280, 365, 168))
				Me.table_6500_fg.Add(New cRecPU(700, 1280, 365, 192))
				Me.table_6500_fg.Add(New cRecPU(800, 1824, 365, 216))
				Me.table_7000_fg.Clear()
				Me.table_7000_fg.Add(New cRecPU(50, 160, 150, 86))
				Me.table_7000_fg.Add(New cRecPU(100, 228, 213, 86))
				Me.table_7000_fg.Add(New cRecPU(200, 320, 213, 86))
				Me.table_7000_fg.Add(New cRecPU(350, 456, 256, 100))
				Me.table_7000_fg.Add(New cRecPU(400, 640, 305, 120))
				Me.table_7000_fg.Add(New cRecPU(550, 912, 305, 144))
				Me.table_7000_fg.Add(New cRecPU(700, 1280, 305, 192))
				Me.table_7000_fg.Add(New cRecPU(800, 1824, 305, 240))
				Me.table_7500_fg.Clear()
				Me.table_7500_fg.Add(New cRecPU(50, 160, 150, 86))
				Me.table_7500_fg.Add(New cRecPU(100, 228, 213, 86))
				Me.table_7500_fg.Add(New cRecPU(150, 320, 246, 86))
				Me.table_7500_fg.Add(New cRecPU(200, 320, 298, 86))
				Me.table_7500_fg.Add(New cRecPU(300, 456, 298, 100))
				Me.table_7500_fg.Add(New cRecPU(400, 640, 305, 120))
				Me.table_7500_fg.Add(New cRecPU(450, 912, 305, 144))
				Me.table_7500_fg.Add(New cRecPU(650, 912, 356, 144))
				Me.table_7500_fg.Add(New cRecPU(750, 1280, 365, 168))
				Me.table_7500_fg.Add(New cRecPU(850, 1824, 365, 216))
				Me.table_8000_fg.Clear()
				Me.table_8000_fg.Add(New cRecPU(50, 160, 173, 86))
				Me.table_8000_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_8000_fg.Add(New cRecPU(200, 320, 298, 86))
				Me.table_8000_fg.Add(New cRecPU(300, 456, 298, 100))
				Me.table_8000_fg.Add(New cRecPU(350, 640, 305, 120))
				Me.table_8000_fg.Add(New cRecPU(450, 912, 305, 144))
				Me.table_8000_fg.Add(New cRecPU(500, 912, 356, 144))
				Me.table_8000_fg.Add(New cRecPU(550, 1280, 365, 168))
				Me.table_8000_fg.Add(New cRecPU(650, 1280, 365, 192))
				Me.table_8000_fg.Add(New cRecPU(800, 1824, 365, 216))
				Me.table_8000_fg.Add(New cRecPU(850, 1824, 365, 240))
				Me.table_8500_fg.Clear()
				Me.table_8500_fg.Add(New cRecPU(50, 160, 200, 74))
				Me.table_8500_fg.Add(New cRecPU(100, 228, 246, 74))
				Me.table_8500_fg.Add(New cRecPU(150, 320, 246, 86))
				Me.table_8500_fg.Add(New cRecPU(200, 456, 256, 100))
				Me.table_8500_fg.Add(New cRecPU(300, 640, 305, 120))
				Me.table_8500_fg.Add(New cRecPU(450, 912, 356, 144))
				Me.table_8500_fg.Add(New cRecPU(500, 912, 356, 168))
				Me.table_8500_fg.Add(New cRecPU(600, 1280, 365, 192))
				Me.table_8500_fg.Add(New cRecPU(700, 1824, 365, 216))
				Me.table_8500_fg.Add(New cRecPU(750, 1824, 365, 260))
				Me.table_8500_fg.Add(New cRecPU(800, 1824, 365, 240))
				Me.table_9000_fg.Clear()
				Me.table_9000_fg.Add(New cRecPU(50, 160, 200, 74))
				Me.table_9000_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_9000_fg.Add(New cRecPU(150, 320, 305, 100))
				Me.table_9000_fg.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9000_fg.Add(New cRecPU(250, 456, 305, 120))
				Me.table_9000_fg.Add(New cRecPU(300, 640, 305, 120))
				Me.table_9000_fg.Add(New cRecPU(450, 912, 356, 144))
				Me.table_9000_fg.Add(New cRecPU(500, 1280, 365, 168))
				Me.table_9000_fg.Add(New cRecPU(650, 1280, 365, 192))
				Me.table_9000_fg.Add(New cRecPU(800, 1824, 365, 240))
				Me.table_9500_fg.Clear()
				Me.table_9500_fg.Add(New cRecPU(50, 160, 200, 74))
				Me.table_9500_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_9500_fg.Add(New cRecPU(150, 320, 305, 100))
				Me.table_9500_fg.Add(New cRecPU(250, 456, 305, 120))
				Me.table_9500_fg.Add(New cRecPU(300, 640, 305, 144))
				Me.table_9500_fg.Add(New cRecPU(500, 912, 356, 168))
				Me.table_9500_fg.Add(New cRecPU(650, 1280, 365, 192))
				Me.table_9500_fg.Add(New cRecPU(700, 1824, 365, 216))
				Me.table_9500_fg.Add(New cRecPU(750, 1824, 365, 240))
				Me.table_10000_fg.Clear()
				Me.table_10000_fg.Add(New cRecPU(50, 228, 246, 74))
				Me.table_10000_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_10000_fg.Add(New cRecPU(150, 320, 298, 100))
				Me.table_10000_fg.Add(New cRecPU(200, 456, 305, 120))
				Me.table_10000_fg.Add(New cRecPU(250, 640, 305, 144))
				Me.table_10000_fg.Add(New cRecPU(350, 912, 356, 144))
				Me.table_10000_fg.Add(New cRecPU(450, 912, 356, 168))
				Me.table_10000_fg.Add(New cRecPU(550, 1280, 365, 192))
				Me.table_10000_fg.Add(New cRecPU(650, 1824, 365, 216))
				Me.table_10000_fg.Add(New cRecPU(700, 1824, 365, 240))
				Me.table_10500_fg.Clear()
				Me.table_10500_fg.Add(New cRecPU(50, 228, 246, 74))
				Me.table_10500_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_10500_fg.Add(New cRecPU(150, 456, 305, 120))
				Me.table_10500_fg.Add(New cRecPU(250, 640, 305, 144))
				Me.table_10500_fg.Add(New cRecPU(400, 912, 365, 168))
				Me.table_10500_fg.Add(New cRecPU(500, 1280, 427, 192))
				Me.table_10500_fg.Add(New cRecPU(600, 1824, 365, 240))
				Me.table_11000_fg.Clear()
				Me.table_11000_fg.Add(New cRecPU(50, 228, 246, 86))
				Me.table_11000_fg.Add(New cRecPU(100, 320, 305, 100))
				Me.table_11000_fg.Add(New cRecPU(150, 456, 305, 120))
				Me.table_11000_fg.Add(New cRecPU(250, 640, 356, 144))
				Me.table_11000_fg.Add(New cRecPU(350, 912, 365, 168))
				Me.table_11000_fg.Add(New cRecPU(400, 1280, 365, 192))
				Me.table_11000_fg.Add(New cRecPU(450, 1280, 427, 192))
				Me.table_11000_fg.Add(New cRecPU(500, 1824, 427, 216))
				Me.table_11000_fg.Add(New cRecPU(550, 1824, 427, 240))
				Me.table_11500_fg.Clear()
				Me.table_11500_fg.Add(New cRecPU(50, 228, 246, 86))
				Me.table_11500_fg.Add(New cRecPU(75, 320, 298, 100))
				Me.table_11500_fg.Add(New cRecPU(150, 456, 305, 120))
				Me.table_11500_fg.Add(New cRecPU(200, 640, 356, 144))
				Me.table_11500_fg.Add(New cRecPU(250, 912, 356, 168))
				Me.table_11500_fg.Add(New cRecPU(350, 912, 365, 168))
				Me.table_11500_fg.Add(New cRecPU(400, 1280, 365, 192))
				Me.table_11500_fg.Add(New cRecPU(450, 1824, 305, 260))
				Me.table_12000_fg.Clear()
				Me.table_12000_fg.Add(New cRecPU(50, 228, 256, 100))
				Me.table_12000_fg.Add(New cRecPU(100, 320, 256, 100))
				Me.table_12000_fg.Add(New cRecPU(200, 640, 356, 144))
				Me.table_12000_fg.Add(New cRecPU(250, 640, 305, 168))
				Me.table_12000_fg.Add(New cRecPU(300, 912, 365, 168))
				Me.table_12000_fg.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_12000_fg.Add(New cRecPU(400, 1824, 365, 216))
				Me.table_12000_fg.Add(New cRecPU(450, 1280, 427, 192))
				Me.table_12500_fg.Clear()
				Me.table_12500_fg.Add(New cRecPU(50, 320, 256, 120))
				Me.table_12500_fg.Add(New cRecPU(100, 456, 305, 120))
				Me.table_12500_fg.Add(New cRecPU(150, 640, 305, 144))
				Me.table_12500_fg.Add(New cRecPU(250, 912, 305, 168))
				Me.table_12500_fg.Add(New cRecPU(300, 912, 305, 192))
				Me.table_12500_fg.Add(New cRecPU(350, 1280, 365, 192))
				Me.table_12500_fg.Add(New cRecPU(400, 1280, 365, 216))
				Me.table_12500_fg.Add(New cRecPU(450, 1824, 365, 260))
				Me.table_13000_fg.Clear()
				Me.table_13000_fg.Add(New cRecPU(75, 320, 256, 120))
				Me.table_13000_fg.Add(New cRecPU(150, 640, 305, 144))
				Me.table_13000_fg.Add(New cRecPU(250, 912, 305, 168))
				Me.table_13000_fg.Add(New cRecPU(300, 912, 365, 192))
				Me.table_13000_fg.Add(New cRecPU(350, 1280, 365, 192))
				Me.table_13000_fg.Add(New cRecPU(400, 1824, 365, 240))
				Me.table_13000_fg.Add(New cRecPU(450, 1824, 365, 260))
				Me.table_13500_fg.Clear()
				Me.table_13500_fg.Add(New cRecPU(50, 320, 256, 120))
				Me.table_13500_fg.Add(New cRecPU(75, 456, 305, 144))
				Me.table_13500_fg.Add(New cRecPU(100, 640, 305, 168))
				Me.table_13500_fg.Add(New cRecPU(250, 912, 305, 192))
				Me.table_13500_fg.Add(New cRecPU(350, 1280, 356, 216))
				Me.table_13500_fg.Add(New cRecPU(475, 1824, 356, 240))
				Me.table_14000_fg.Clear()
				Me.table_14000_fg.Add(New cRecPU(75, 320, 256, 120))
				Me.table_14000_fg.Add(New cRecPU(100, 456, 305, 120))
				Me.table_14000_fg.Add(New cRecPU(150, 640, 356, 144))
				Me.table_14000_fg.Add(New cRecPU(200, 912, 356, 168))
				Me.table_14000_fg.Add(New cRecPU(300, 912, 365, 192))
				Me.table_14000_fg.Add(New cRecPU(350, 1280, 365, 216))
				Me.table_14000_fg.Add(New cRecPU(450, 1824, 305, 240))
				Me.table_15000_fg.Clear()
				Me.table_15000_fg.Add(New cRecPU(50, 320, 305, 120))
				Me.table_15000_fg.Add(New cRecPU(100, 456, 305, 144))
				Me.table_15000_fg.Add(New cRecPU(150, 640, 356, 168))
				Me.table_15000_fg.Add(New cRecPU(250, 912, 305, 192))
				Me.table_15000_fg.Add(New cRecPU(300, 1280, 305, 216))
				Me.table_15000_fg.Add(New cRecPU(350, 1824, 356, 240))
				Me.table_15000_fg.Add(New cRecPU(400, 1824, 356, 260))
				Me.table_16000_fg.Clear()
				Me.table_16000_fg.Add(New cRecPU(75, 456, 305, 144))
				Me.table_16000_fg.Add(New cRecPU(100, 640, 356, 168))
				Me.table_16000_fg.Add(New cRecPU(200, 912, 365, 192))
				Me.table_16000_fg.Add(New cRecPU(250, 1280, 365, 216))
				Me.table_16000_fg.Add(New cRecPU(300, 1280, 305, 240))
				Me.table_16000_fg.Add(New cRecPU(350, 1824, 356, 240))
				Me.table_16000_fg.Add(New cRecPU(400, 1824, 356, 260))
				Me.table_17000_fg.Clear()
				Me.table_17000_fg.Add(New cRecPU(50, 456, 356, 144))
				Me.table_17000_fg.Add(New cRecPU(100, 640, 356, 168))
				Me.table_17000_fg.Add(New cRecPU(150, 912, 365, 192))
				Me.table_17000_fg.Add(New cRecPU(200, 1280, 427, 216))
				Me.table_17000_fg.Add(New cRecPU(275, 1824, 365, 240))
				Me.table_17000_fg.Add(New cRecPU(325, 1824, 365, 260))
				Me.table_18000_fg.Clear()
				Me.table_18000_fg.Add(New cRecPU(50, 456, 356, 168))
				Me.table_18000_fg.Add(New cRecPU(75, 640, 356, 168))
				Me.table_18000_fg.Add(New cRecPU(100, 640, 365, 192))
				Me.table_18000_fg.Add(New cRecPU(150, 912, 365, 216))
				Me.table_18000_fg.Add(New cRecPU(200, 1280, 365, 240))
				Me.table_18000_fg.Add(New cRecPU(250, 1280, 305, 260))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUFGAL_last()
			Try
				Me.table_2000_fg.Clear()
				Me.table_2000_fg.Add(New cRecPU(100, 40, 67, 36))
				Me.table_2000_fg.Add(New cRecPU(150, 57, 76, 42))
				Me.table_2000_fg.Add(New cRecPU(200, 80, 76, 42))
				Me.table_2000_fg.Add(New cRecPU(350, 160, 121, 64))
				Me.table_2000_fg.Add(New cRecPU(400, 160, 121, 74))
				Me.table_2000_fg.Add(New cRecPU(450, 228, 121, 74))
				Me.table_2000_fg.Add(New cRecPU(550, 228, 121, 86))
				Me.table_2000_fg.Add(New cRecPU(650, 320, 143, 100))
				Me.table_2000_fg.Add(New cRecPU(800, 320, 143, 120))
				Me.table_2000_fg.Add(New cRecPU(1000, 456, 143, 120))
				Me.table_2000_fg.Add(New cRecPU(1100, 456, 198, 120))
				Me.table_2000_fg.Add(New cRecPU(1200, 456, 198, 144))
				Me.table_2000_fg.Add(New cRecPU(1300, 640, 198, 144))
				Me.table_2000_fg.Add(New cRecPU(1400, 640, 198, 168))
				Me.table_2000_fg.Add(New cRecPU(1900, 912, 212, 192))
				Me.table_2000_fg.Add(New cRecPU(2200, 1280, 246, 192))
				Me.table_2000_fg.Add(New cRecPU(2500, 1280, 246, 216))
				Me.table_2000_fg.Add(New cRecPU(2800, 1824, 305, 240))
				Me.table_2000_fg.Add(New cRecPU(3100, 1824, 305, 260))
				Me.table_2500_fg.Clear()
				Me.table_2500_fg.Add(New cRecPU(100, 80, 75, 48))
				Me.table_2500_fg.Add(New cRecPU(150, 114, 95, 48))
				Me.table_2500_fg.Add(New cRecPU(200, 114, 119, 64))
				Me.table_2500_fg.Add(New cRecPU(250, 160, 119, 64))
				Me.table_2500_fg.Add(New cRecPU(300, 160, 119, 74))
				Me.table_2500_fg.Add(New cRecPU(450, 228, 121, 86))
				Me.table_2500_fg.Add(New cRecPU(550, 320, 143, 100))
				Me.table_2500_fg.Add(New cRecPU(600, 320, 165, 100))
				Me.table_2500_fg.Add(New cRecPU(700, 456, 165, 120))
				Me.table_2500_fg.Add(New cRecPU(750, 456, 200, 120))
				Me.table_2500_fg.Add(New cRecPU(800, 456, 213, 120))
				Me.table_2500_fg.Add(New cRecPU(1100, 640, 200, 144))
				Me.table_2500_fg.Add(New cRecPU(1100, 640, 200, 144))
				Me.table_2500_fg.Add(New cRecPU(1200, 640, 212, 144))
				Me.table_2500_fg.Add(New cRecPU(1600, 912, 256, 168))
				Me.table_2500_fg.Add(New cRecPU(1800, 1280, 305, 192))
				Me.table_2500_fg.Add(New cRecPU(2000, 1824, 305, 216))
				Me.table_2500_fg.Add(New cRecPU(2100, 1824, 305, 240))
				Me.table_2500_fg.Add(New cRecPU(2300, 1824, 305, 260))
				Me.table_3000_fg.Clear()
				Me.table_3000_fg.Add(New cRecPU(100, 80, 95, 48))
				Me.table_3000_fg.Add(New cRecPU(200, 114, 133, 48))
				Me.table_3000_fg.Add(New cRecPU(300, 160, 143, 64))
				Me.table_3000_fg.Add(New cRecPU(350, 228, 143, 64))
				Me.table_3000_fg.Add(New cRecPU(400, 320, 150, 74))
				Me.table_3000_fg.Add(New cRecPU(450, 320, 165, 74))
				Me.table_3000_fg.Add(New cRecPU(650, 320, 212, 86))
				Me.table_3000_fg.Add(New cRecPU(750, 456, 212, 100))
				Me.table_3000_fg.Add(New cRecPU(900, 456, 213, 120))
				Me.table_3000_fg.Add(New cRecPU(1000, 640, 253, 144))
				Me.table_3000_fg.Add(New cRecPU(1200, 912, 253, 168))
				Me.table_3000_fg.Add(New cRecPU(1500, 912, 253, 192))
				Me.table_3000_fg.Add(New cRecPU(2000, 1280, 305, 216))
				Me.table_3000_fg.Add(New cRecPU(2100, 1824, 305, 240))
				Me.table_3500_fg.Clear()
				Me.table_3500_fg.Add(New cRecPU(100, 80, 95, 48))
				Me.table_3500_fg.Add(New cRecPU(150, 114, 133, 54))
				Me.table_3500_fg.Add(New cRecPU(200, 160, 169, 54))
				Me.table_3500_fg.Add(New cRecPU(300, 228, 200, 64))
				Me.table_3500_fg.Add(New cRecPU(400, 320, 200, 74))
				Me.table_3500_fg.Add(New cRecPU(450, 320, 212, 86))
				Me.table_3500_fg.Add(New cRecPU(550, 456, 212, 100))
				Me.table_3500_fg.Add(New cRecPU(600, 456, 213, 120))
				Me.table_3500_fg.Add(New cRecPU(750, 640, 213, 120))
				Me.table_3500_fg.Add(New cRecPU(900, 640, 253, 120))
				Me.table_3500_fg.Add(New cRecPU(1000, 912, 256, 144))
				Me.table_3500_fg.Add(New cRecPU(1200, 912, 305, 168))
				Me.table_3500_fg.Add(New cRecPU(1400, 1280, 305, 192))
				Me.table_3500_fg.Add(New cRecPU(1500, 1280, 305, 192))
				Me.table_3500_fg.Add(New cRecPU(1600, 1824, 305, 216))
				Me.table_3500_fg.Add(New cRecPU(1730, 1824, 305, 260))
				Me.table_4000_fg.Clear()
				Me.table_4000_fg.Add(New cRecPU(50, 80, 119, 54))
				Me.table_4000_fg.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4000_fg.Add(New cRecPU(200, 160, 169, 54))
				Me.table_4000_fg.Add(New cRecPU(300, 228, 173, 64))
				Me.table_4000_fg.Add(New cRecPU(350, 228, 173, 74))
				Me.table_4000_fg.Add(New cRecPU(400, 320, 212, 74))
				Me.table_4000_fg.Add(New cRecPU(450, 456, 212, 86))
				Me.table_4000_fg.Add(New cRecPU(500, 456, 246, 86))
				Me.table_4000_fg.Add(New cRecPU(550, 456, 253, 86))
				Me.table_4000_fg.Add(New cRecPU(600, 640, 253, 100))
				Me.table_4000_fg.Add(New cRecPU(650, 912, 305, 120))
				Me.table_4000_fg.Add(New cRecPU(850, 912, 305, 144))
				Me.table_4000_fg.Add(New cRecPU(900, 1280, 305, 168))
				Me.table_4000_fg.Add(New cRecPU(1100, 1280, 305, 192))
				Me.table_4000_fg.Add(New cRecPU(1300, 1824, 305, 216))
				Me.table_4000_fg.Add(New cRecPU(1400, 1824, 305, 240))
				Me.table_4500_fg.Clear()
				Me.table_4500_fg.Add(New cRecPU(100, 80, 119, 54))
				Me.table_4500_fg.Add(New cRecPU(150, 160, 169, 54))
				Me.table_4500_fg.Add(New cRecPU(250, 228, 173, 64))
				Me.table_4500_fg.Add(New cRecPU(300, 228, 173, 74))
				Me.table_4500_fg.Add(New cRecPU(350, 320, 213, 86))
				Me.table_4500_fg.Add(New cRecPU(400, 456, 213, 100))
				Me.table_4500_fg.Add(New cRecPU(450, 456, 256, 100))
				Me.table_4500_fg.Add(New cRecPU(550, 640, 304, 120))
				Me.table_4500_fg.Add(New cRecPU(600, 912, 304, 120))
				Me.table_4500_fg.Add(New cRecPU(800, 912, 304, 144))
				Me.table_4500_fg.Add(New cRecPU(1000, 1280, 365, 192))
				Me.table_4500_fg.Add(New cRecPU(1100, 1824, 365, 216))
				Me.table_4500_fg.Add(New cRecPU(1250, 1824, 305, 240))
				Me.table_5000_fg.Clear()
				Me.table_5000_fg.Add(New cRecPU(100, 114, 119, 54))
				Me.table_5000_fg.Add(New cRecPU(150, 160, 169, 54))
				Me.table_5000_fg.Add(New cRecPU(200, 228, 173, 64))
				Me.table_5000_fg.Add(New cRecPU(250, 320, 173, 74))
				Me.table_5000_fg.Add(New cRecPU(350, 320, 173, 86))
				Me.table_5000_fg.Add(New cRecPU(400, 456, 256, 100))
				Me.table_5000_fg.Add(New cRecPU(500, 456, 213, 120))
				Me.table_5000_fg.Add(New cRecPU(550, 640, 305, 120))
				Me.table_5000_fg.Add(New cRecPU(650, 912, 305, 120))
				Me.table_5000_fg.Add(New cRecPU(800, 912, 305, 144))
				Me.table_5000_fg.Add(New cRecPU(900, 1280, 365, 192))
				Me.table_5000_fg.Add(New cRecPU(950, 1824, 365, 216))
				Me.table_5500_fg.Clear()
				Me.table_5500_fg.Add(New cRecPU(100, 160, 143, 74))
				Me.table_5500_fg.Add(New cRecPU(150, 228, 173, 74))
				Me.table_5500_fg.Add(New cRecPU(300, 320, 212, 86))
				Me.table_5500_fg.Add(New cRecPU(350, 456, 298, 86))
				Me.table_5500_fg.Add(New cRecPU(400, 456, 298, 100))
				Me.table_5500_fg.Add(New cRecPU(450, 640, 304, 120))
				Me.table_5500_fg.Add(New cRecPU(550, 912, 305, 144))
				Me.table_5500_fg.Add(New cRecPU(650, 912, 356, 144))
				Me.table_5500_fg.Add(New cRecPU(750, 1280, 365, 192))
				Me.table_5500_fg.Add(New cRecPU(800, 1824, 305, 240))
				Me.table_6000_fg.Clear()
				Me.table_6000_fg.Add(New cRecPU(100, 114, 143, 64))
				Me.table_6000_fg.Add(New cRecPU(150, 228, 173, 74))
				Me.table_6000_fg.Add(New cRecPU(200, 320, 212, 86))
				Me.table_6000_fg.Add(New cRecPU(350, 456, 256, 100))
				Me.table_6000_fg.Add(New cRecPU(400, 640, 305, 120))
				Me.table_6000_fg.Add(New cRecPU(450, 912, 305, 144))
				Me.table_6000_fg.Add(New cRecPU(650, 1280, 365, 192))
				Me.table_6000_fg.Add(New cRecPU(750, 1824, 365, 216))
				Me.table_6000_fg.Add(New cRecPU(800, 1824, 365, 240))
				Me.table_6500_fg.Clear()
				Me.table_6500_fg.Add(New cRecPU(50, 160, 119, 86))
				Me.table_6500_fg.Add(New cRecPU(150, 228, 200, 74))
				Me.table_6500_fg.Add(New cRecPU(200, 320, 212, 86))
				Me.table_6500_fg.Add(New cRecPU(350, 456, 256, 100))
				Me.table_6500_fg.Add(New cRecPU(450, 640, 305, 120))
				Me.table_6500_fg.Add(New cRecPU(550, 912, 356, 144))
				Me.table_6500_fg.Add(New cRecPU(600, 1280, 365, 168))
				Me.table_6500_fg.Add(New cRecPU(700, 1280, 365, 192))
				Me.table_6500_fg.Add(New cRecPU(800, 1824, 365, 216))
				Me.table_7000_fg.Clear()
				Me.table_7000_fg.Add(New cRecPU(50, 160, 150, 86))
				Me.table_7000_fg.Add(New cRecPU(100, 228, 213, 86))
				Me.table_7000_fg.Add(New cRecPU(200, 320, 213, 86))
				Me.table_7000_fg.Add(New cRecPU(350, 456, 256, 100))
				Me.table_7000_fg.Add(New cRecPU(400, 640, 305, 120))
				Me.table_7000_fg.Add(New cRecPU(550, 912, 305, 144))
				Me.table_7000_fg.Add(New cRecPU(700, 1280, 305, 192))
				Me.table_7000_fg.Add(New cRecPU(800, 1824, 305, 240))
				Me.table_7500_fg.Clear()
				Me.table_7500_fg.Add(New cRecPU(50, 160, 150, 86))
				Me.table_7500_fg.Add(New cRecPU(100, 228, 213, 86))
				Me.table_7500_fg.Add(New cRecPU(150, 320, 246, 86))
				Me.table_7500_fg.Add(New cRecPU(200, 320, 298, 86))
				Me.table_7500_fg.Add(New cRecPU(300, 456, 298, 100))
				Me.table_7500_fg.Add(New cRecPU(400, 640, 305, 120))
				Me.table_7500_fg.Add(New cRecPU(450, 912, 305, 144))
				Me.table_7500_fg.Add(New cRecPU(650, 912, 356, 144))
				Me.table_7500_fg.Add(New cRecPU(750, 1280, 365, 168))
				Me.table_7500_fg.Add(New cRecPU(850, 1824, 365, 216))
				Me.table_8000_fg.Clear()
				Me.table_8000_fg.Add(New cRecPU(50, 160, 173, 86))
				Me.table_8000_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_8000_fg.Add(New cRecPU(200, 320, 298, 86))
				Me.table_8000_fg.Add(New cRecPU(300, 456, 298, 100))
				Me.table_8000_fg.Add(New cRecPU(350, 640, 305, 120))
				Me.table_8000_fg.Add(New cRecPU(450, 912, 305, 144))
				Me.table_8000_fg.Add(New cRecPU(500, 912, 356, 144))
				Me.table_8000_fg.Add(New cRecPU(550, 1280, 365, 168))
				Me.table_8000_fg.Add(New cRecPU(650, 1280, 365, 192))
				Me.table_8000_fg.Add(New cRecPU(800, 1824, 365, 216))
				Me.table_8000_fg.Add(New cRecPU(850, 1824, 365, 240))
				Me.table_8500_fg.Clear()
				Me.table_8500_fg.Add(New cRecPU(50, 160, 200, 74))
				Me.table_8500_fg.Add(New cRecPU(100, 228, 246, 74))
				Me.table_8500_fg.Add(New cRecPU(150, 320, 246, 86))
				Me.table_8500_fg.Add(New cRecPU(200, 456, 256, 100))
				Me.table_8500_fg.Add(New cRecPU(300, 640, 305, 120))
				Me.table_8500_fg.Add(New cRecPU(450, 912, 356, 144))
				Me.table_8500_fg.Add(New cRecPU(500, 912, 356, 168))
				Me.table_8500_fg.Add(New cRecPU(600, 1280, 365, 192))
				Me.table_8500_fg.Add(New cRecPU(700, 1824, 365, 216))
				Me.table_8500_fg.Add(New cRecPU(750, 1824, 365, 260))
				Me.table_8500_fg.Add(New cRecPU(800, 1824, 365, 240))
				Me.table_9000_fg.Clear()
				Me.table_9000_fg.Add(New cRecPU(50, 160, 200, 74))
				Me.table_9000_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_9000_fg.Add(New cRecPU(150, 320, 305, 100))
				Me.table_9000_fg.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9000_fg.Add(New cRecPU(250, 456, 305, 120))
				Me.table_9000_fg.Add(New cRecPU(300, 640, 305, 120))
				Me.table_9000_fg.Add(New cRecPU(450, 912, 356, 144))
				Me.table_9000_fg.Add(New cRecPU(500, 1280, 365, 168))
				Me.table_9000_fg.Add(New cRecPU(650, 1280, 365, 192))
				Me.table_9000_fg.Add(New cRecPU(800, 1824, 365, 240))
				Me.table_9500_fg.Clear()
				Me.table_9500_fg.Add(New cRecPU(50, 160, 200, 74))
				Me.table_9500_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_9500_fg.Add(New cRecPU(150, 320, 305, 100))
				Me.table_9500_fg.Add(New cRecPU(250, 456, 305, 120))
				Me.table_9500_fg.Add(New cRecPU(300, 640, 305, 144))
				Me.table_9500_fg.Add(New cRecPU(500, 912, 356, 168))
				Me.table_9500_fg.Add(New cRecPU(650, 1280, 365, 192))
				Me.table_9500_fg.Add(New cRecPU(700, 1824, 365, 216))
				Me.table_9500_fg.Add(New cRecPU(750, 1824, 365, 240))
				Me.table_10000_fg.Clear()
				Me.table_10000_fg.Add(New cRecPU(50, 228, 246, 74))
				Me.table_10000_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_10000_fg.Add(New cRecPU(150, 320, 298, 100))
				Me.table_10000_fg.Add(New cRecPU(200, 456, 305, 120))
				Me.table_10000_fg.Add(New cRecPU(250, 640, 305, 144))
				Me.table_10000_fg.Add(New cRecPU(350, 912, 356, 144))
				Me.table_10000_fg.Add(New cRecPU(450, 912, 356, 168))
				Me.table_10000_fg.Add(New cRecPU(550, 1280, 365, 192))
				Me.table_10000_fg.Add(New cRecPU(650, 1824, 365, 216))
				Me.table_10000_fg.Add(New cRecPU(700, 1824, 365, 240))
				Me.table_10500_fg.Clear()
				Me.table_10500_fg.Add(New cRecPU(50, 228, 246, 74))
				Me.table_10500_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_10500_fg.Add(New cRecPU(150, 456, 305, 120))
				Me.table_10500_fg.Add(New cRecPU(250, 640, 305, 144))
				Me.table_10500_fg.Add(New cRecPU(400, 912, 365, 168))
				Me.table_10500_fg.Add(New cRecPU(500, 1280, 427, 192))
				Me.table_10500_fg.Add(New cRecPU(600, 1824, 365, 240))
				Me.table_11000_fg.Clear()
				Me.table_11000_fg.Add(New cRecPU(50, 228, 246, 86))
				Me.table_11000_fg.Add(New cRecPU(100, 320, 305, 100))
				Me.table_11000_fg.Add(New cRecPU(150, 456, 305, 120))
				Me.table_11000_fg.Add(New cRecPU(250, 640, 356, 144))
				Me.table_11000_fg.Add(New cRecPU(350, 912, 365, 168))
				Me.table_11000_fg.Add(New cRecPU(400, 1280, 365, 192))
				Me.table_11000_fg.Add(New cRecPU(450, 1280, 427, 192))
				Me.table_11000_fg.Add(New cRecPU(500, 1824, 427, 216))
				Me.table_11000_fg.Add(New cRecPU(550, 1824, 427, 240))
				Me.table_11500_fg.Clear()
				Me.table_11500_fg.Add(New cRecPU(50, 228, 246, 86))
				Me.table_11500_fg.Add(New cRecPU(75, 320, 298, 100))
				Me.table_11500_fg.Add(New cRecPU(150, 456, 305, 120))
				Me.table_11500_fg.Add(New cRecPU(200, 640, 356, 144))
				Me.table_11500_fg.Add(New cRecPU(250, 912, 356, 168))
				Me.table_11500_fg.Add(New cRecPU(350, 912, 365, 168))
				Me.table_11500_fg.Add(New cRecPU(400, 1280, 365, 192))
				Me.table_11500_fg.Add(New cRecPU(450, 1824, 305, 260))
				Me.table_12000_fg.Clear()
				Me.table_12000_fg.Add(New cRecPU(50, 228, 256, 100))
				Me.table_12000_fg.Add(New cRecPU(100, 320, 256, 100))
				Me.table_12000_fg.Add(New cRecPU(200, 640, 356, 144))
				Me.table_12000_fg.Add(New cRecPU(250, 640, 305, 168))
				Me.table_12000_fg.Add(New cRecPU(300, 912, 365, 168))
				Me.table_12000_fg.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_12000_fg.Add(New cRecPU(400, 1824, 365, 216))
				Me.table_12000_fg.Add(New cRecPU(450, 1280, 427, 192))
				Me.table_12500_fg.Clear()
				Me.table_12500_fg.Add(New cRecPU(50, 320, 256, 120))
				Me.table_12500_fg.Add(New cRecPU(100, 456, 305, 120))
				Me.table_12500_fg.Add(New cRecPU(150, 640, 305, 144))
				Me.table_12500_fg.Add(New cRecPU(250, 912, 305, 168))
				Me.table_12500_fg.Add(New cRecPU(300, 912, 305, 192))
				Me.table_12500_fg.Add(New cRecPU(350, 1280, 365, 192))
				Me.table_12500_fg.Add(New cRecPU(400, 1280, 365, 216))
				Me.table_12500_fg.Add(New cRecPU(450, 1824, 365, 260))
				Me.table_13000_fg.Clear()
				Me.table_13000_fg.Add(New cRecPU(75, 320, 256, 120))
				Me.table_13000_fg.Add(New cRecPU(150, 640, 305, 144))
				Me.table_13000_fg.Add(New cRecPU(250, 912, 305, 168))
				Me.table_13000_fg.Add(New cRecPU(300, 912, 365, 192))
				Me.table_13000_fg.Add(New cRecPU(350, 1280, 365, 192))
				Me.table_13000_fg.Add(New cRecPU(400, 1824, 365, 240))
				Me.table_13000_fg.Add(New cRecPU(450, 1824, 365, 260))
				Me.table_13500_fg.Clear()
				Me.table_13500_fg.Add(New cRecPU(50, 320, 256, 120))
				Me.table_13500_fg.Add(New cRecPU(75, 456, 305, 144))
				Me.table_13500_fg.Add(New cRecPU(100, 640, 305, 168))
				Me.table_13500_fg.Add(New cRecPU(250, 912, 305, 192))
				Me.table_13500_fg.Add(New cRecPU(350, 1280, 356, 216))
				Me.table_13500_fg.Add(New cRecPU(475, 1824, 356, 240))
				Me.table_14000_fg.Clear()
				Me.table_14000_fg.Add(New cRecPU(75, 320, 256, 120))
				Me.table_14000_fg.Add(New cRecPU(100, 456, 305, 120))
				Me.table_14000_fg.Add(New cRecPU(150, 640, 356, 144))
				Me.table_14000_fg.Add(New cRecPU(200, 912, 356, 168))
				Me.table_14000_fg.Add(New cRecPU(300, 912, 365, 192))
				Me.table_14000_fg.Add(New cRecPU(350, 1280, 365, 216))
				Me.table_14000_fg.Add(New cRecPU(450, 1824, 305, 240))
				Me.table_15000_fg.Clear()
				Me.table_15000_fg.Add(New cRecPU(50, 320, 305, 120))
				Me.table_15000_fg.Add(New cRecPU(100, 456, 305, 144))
				Me.table_15000_fg.Add(New cRecPU(150, 640, 356, 168))
				Me.table_15000_fg.Add(New cRecPU(250, 912, 305, 192))
				Me.table_15000_fg.Add(New cRecPU(300, 1280, 305, 216))
				Me.table_15000_fg.Add(New cRecPU(350, 1824, 356, 240))
				Me.table_15000_fg.Add(New cRecPU(400, 1824, 356, 260))
				Me.table_16000_fg.Clear()
				Me.table_16000_fg.Add(New cRecPU(75, 456, 305, 144))
				Me.table_16000_fg.Add(New cRecPU(100, 640, 356, 168))
				Me.table_16000_fg.Add(New cRecPU(200, 912, 365, 192))
				Me.table_16000_fg.Add(New cRecPU(250, 1280, 365, 216))
				Me.table_16000_fg.Add(New cRecPU(300, 1280, 305, 240))
				Me.table_16000_fg.Add(New cRecPU(350, 1824, 356, 240))
				Me.table_16000_fg.Add(New cRecPU(400, 1824, 356, 260))
				Me.table_17000_fg.Clear()
				Me.table_17000_fg.Add(New cRecPU(50, 456, 356, 144))
				Me.table_17000_fg.Add(New cRecPU(100, 640, 356, 168))
				Me.table_17000_fg.Add(New cRecPU(150, 912, 365, 192))
				Me.table_17000_fg.Add(New cRecPU(200, 1280, 427, 216))
				Me.table_17000_fg.Add(New cRecPU(275, 1824, 365, 240))
				Me.table_17000_fg.Add(New cRecPU(325, 1824, 365, 260))
				Me.table_18000_fg.Clear()
				Me.table_18000_fg.Add(New cRecPU(50, 456, 356, 168))
				Me.table_18000_fg.Add(New cRecPU(75, 640, 356, 168))
				Me.table_18000_fg.Add(New cRecPU(100, 640, 365, 192))
				Me.table_18000_fg.Add(New cRecPU(150, 912, 365, 216))
				Me.table_18000_fg.Add(New cRecPU(200, 1280, 365, 240))
				Me.table_18000_fg.Add(New cRecPU(250, 1280, 305, 260))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUFGAL_RMark()
			Try
				Me.table_1000_fg.Clear()
				Me.table_1000_fg.Add(New cRecPU(50, 20, 30, 44))
				Me.table_1000_fg.Add(New cRecPU(100, 25, 35, 44))
				Me.table_1000_fg.Add(New cRecPU(150, 35, 35, 58))
				Me.table_1000_fg.Add(New cRecPU(200, 55, 45, 74))
				Me.table_1000_fg.Add(New cRecPU(250, 65, 55, 74))
				Me.table_1000_fg.Add(New cRecPU(300, 70, 55, 74))
				Me.table_1000_fg.Add(New cRecPU(350, 80, 65, 74))
				Me.table_1000_fg.Add(New cRecPU(450, 85, 75, 74))
				Me.table_1000_fg.Add(New cRecPU(500, 95, 75, 74))
				Me.table_1000_fg.Add(New cRecPU(550, 114, 75, 86))
				Me.table_1000_fg.Add(New cRecPU(600, 114, 75, 86))
				Me.table_1000_fg.Add(New cRecPU(700, 160, 80, 86))
				Me.table_1000_fg.Add(New cRecPU(850, 160, 100, 86))
				Me.table_1000_fg.Add(New cRecPU(1000, 228, 100, 100))
				Me.table_1000_fg.Add(New cRecPU(1100, 228, 110, 100))
				Me.table_1000_fg.Add(New cRecPU(1200, 228, 110, 120))
				Me.table_1000_fg.Add(New cRecPU(1500, 320, 140, 120))
				Me.table_1000_fg.Add(New cRecPU(1800, 456, 140, 120))
				Me.table_1000_fg.Add(New cRecPU(1900, 456, 150, 144))
				Me.table_1000_fg.Add(New cRecPU(2000, 640, 150, 156))
				Me.table_1000_fg.Add(New cRecPU(2300, 640, 160, 156))
				Me.table_1000_fg.Add(New cRecPU(2500, 640, 160, 168))
				Me.table_1000_fg.Add(New cRecPU(2700, 640, 200, 192))
				Me.table_1000_fg.Add(New cRecPU(2800, 912, 200, 192))
				Me.table_1000_fg.Add(New cRecPU(2900, 912, 200, 192))
				Me.table_1000_fg.Add(New cRecPU(3200, 912, 220, 192))
				Me.table_1500_fg.Clear()
				Me.table_1500_fg.Add(New cRecPU(50, 25, 40, 44))
				Me.table_1500_fg.Add(New cRecPU(100, 32, 50, 44))
				Me.table_1500_fg.Add(New cRecPU(150, 45, 60, 44))
				Me.table_1500_fg.Add(New cRecPU(200, 65, 60, 58))
				Me.table_1500_fg.Add(New cRecPU(250, 80, 60, 74))
				Me.table_1500_fg.Add(New cRecPU(300, 90, 62, 74))
				Me.table_1500_fg.Add(New cRecPU(350, 114, 70, 74))
				Me.table_1500_fg.Add(New cRecPU(400, 114, 75, 74))
				Me.table_1500_fg.Add(New cRecPU(450, 114, 80, 74))
				Me.table_1500_fg.Add(New cRecPU(550, 160, 100, 86))
				Me.table_1500_fg.Add(New cRecPU(600, 228, 100, 86))
				Me.table_1500_fg.Add(New cRecPU(650, 228, 110, 86))
				Me.table_1500_fg.Add(New cRecPU(850, 228, 135, 86))
				Me.table_1500_fg.Add(New cRecPU(900, 228, 150, 86))
				Me.table_1500_fg.Add(New cRecPU(1000, 320, 150, 100))
				Me.table_1500_fg.Add(New cRecPU(1200, 456, 150, 120))
				Me.table_1500_fg.Add(New cRecPU(1300, 456, 180, 120))
				Me.table_1500_fg.Add(New cRecPU(1500, 640, 180, 144))
				Me.table_1500_fg.Add(New cRecPU(1600, 640, 180, 156))
				Me.table_1500_fg.Add(New cRecPU(1700, 640, 180, 168))
				Me.table_1500_fg.Add(New cRecPU(1800, 912, 220, 168))
				Me.table_1500_fg.Add(New cRecPU(2000, 912, 220, 192))
				Me.table_1500_fg.Add(New cRecPU(2100, 912, 230, 192))
				Me.table_2000_fg.Clear()
				Me.table_2000_fg.Add(New cRecPU(50, 30, 50, 44))
				Me.table_2000_fg.Add(New cRecPU(100, 44, 60, 44))
				Me.table_2000_fg.Add(New cRecPU(150, 55, 65, 44))
				Me.table_2000_fg.Add(New cRecPU(200, 85, 75, 58))
				Me.table_2000_fg.Add(New cRecPU(250, 114, 85, 58))
				Me.table_2000_fg.Add(New cRecPU(300, 114, 119, 58))
				Me.table_2000_fg.Add(New cRecPU(450, 160, 119, 74))
				Me.table_2000_fg.Add(New cRecPU(500, 228, 119, 86))
				Me.table_2000_fg.Add(New cRecPU(550, 320, 130, 86))
				Me.table_2000_fg.Add(New cRecPU(600, 320, 150, 86))
				Me.table_2000_fg.Add(New cRecPU(850, 320, 160, 86))
				Me.table_2000_fg.Add(New cRecPU(900, 320, 170, 100))
				Me.table_2000_fg.Add(New cRecPU(950, 456, 185, 120))
				Me.table_2000_fg.Add(New cRecPU(1000, 456, 160, 144))
				Me.table_2000_fg.Add(New cRecPU(1200, 640, 200, 144))
				Me.table_2000_fg.Add(New cRecPU(1300, 640, 220, 144))
				Me.table_2000_fg.Add(New cRecPU(1600, 912, 240, 156))
				Me.table_2000_fg.Add(New cRecPU(1700, 912, 305, 168))
				Me.table_2000_fg.Add(New cRecPU(1800, 912, 305, 192))
				Me.table_2500_fg.Clear()
				Me.table_2500_fg.Add(New cRecPU(50, 40, 60, 44))
				Me.table_2500_fg.Add(New cRecPU(100, 60, 75, 44))
				Me.table_2500_fg.Add(New cRecPU(150, 75, 90, 44))
				Me.table_2500_fg.Add(New cRecPU(200, 114, 90, 58))
				Me.table_2500_fg.Add(New cRecPU(250, 160, 90, 74))
				Me.table_2500_fg.Add(New cRecPU(300, 160, 119, 74))
				Me.table_2500_fg.Add(New cRecPU(350, 228, 135, 74))
				Me.table_2500_fg.Add(New cRecPU(500, 228, 173, 74))
				Me.table_2500_fg.Add(New cRecPU(600, 320, 173, 86))
				Me.table_2500_fg.Add(New cRecPU(700, 320, 200, 86))
				Me.table_2500_fg.Add(New cRecPU(850, 456, 200, 100))
				Me.table_2500_fg.Add(New cRecPU(950, 456, 256, 100))
				Me.table_2500_fg.Add(New cRecPU(1100, 640, 256, 120))
				Me.table_2500_fg.Add(New cRecPU(1300, 912, 245, 156))
				Me.table_2500_fg.Add(New cRecPU(1350, 912, 245, 168))
				Me.table_2500_fg.Add(New cRecPU(1400, 912, 245, 192))
				Me.table_2500_fg.Add(New cRecPU(1500, 1280, 250, 192))
				Me.table_3000_fg.Clear()
				Me.table_3000_fg.Add(New cRecPU(50, 45, 70, 44))
				Me.table_3000_fg.Add(New cRecPU(100, 75, 85, 58))
				Me.table_3000_fg.Add(New cRecPU(150, 114, 119, 58))
				Me.table_3000_fg.Add(New cRecPU(175, 114, 119, 74))
				Me.table_3000_fg.Add(New cRecPU(200, 160, 119, 86))
				Me.table_3000_fg.Add(New cRecPU(250, 228, 135, 86))
				Me.table_3000_fg.Add(New cRecPU(300, 228, 150, 86))
				Me.table_3000_fg.Add(New cRecPU(350, 320, 150, 86))
				Me.table_3000_fg.Add(New cRecPU(550, 320, 165, 86))
				Me.table_3000_fg.Add(New cRecPU(650, 320, 200, 86))
				Me.table_3000_fg.Add(New cRecPU(700, 456, 200, 100))
				Me.table_3000_fg.Add(New cRecPU(800, 456, 256, 100))
				Me.table_3000_fg.Add(New cRecPU(1100, 640, 256, 120))
				Me.table_3500_fg.Clear()
				Me.table_3500_fg.Add(New cRecPU(50, 55, 90, 44))
				Me.table_3500_fg.Add(New cRecPU(100, 70, 119, 44))
				Me.table_3500_fg.Add(New cRecPU(150, 114, 119, 58))
				Me.table_3500_fg.Add(New cRecPU(200, 228, 135, 74))
				Me.table_3500_fg.Add(New cRecPU(300, 228, 173, 74))
				Me.table_3500_fg.Add(New cRecPU(350, 320, 173, 86))
				Me.table_3500_fg.Add(New cRecPU(450, 320, 200, 86))
				Me.table_3500_fg.Add(New cRecPU(700, 456, 256, 100))
				Me.table_3500_fg.Add(New cRecPU(900, 640, 256, 120))
				Me.table_3500_fg.Add(New cRecPU(1000, 912, 305, 144))
				Me.table_4000_fg.Clear()
				Me.table_4000_fg.Add(New cRecPU(50, 90, 90, 74))
				Me.table_4000_fg.Add(New cRecPU(100, 114, 119, 74))
				Me.table_4000_fg.Add(New cRecPU(150, 160, 135, 74))
				Me.table_4000_fg.Add(New cRecPU(250, 228, 173, 74))
				Me.table_4000_fg.Add(New cRecPU(300, 320, 173, 100))
				Me.table_4000_fg.Add(New cRecPU(400, 456, 200, 120))
				Me.table_4000_fg.Add(New cRecPU(650, 640, 256, 120))
				Me.table_4000_fg.Add(New cRecPU(950, 912, 304, 144))
				Me.table_4000_fg.Add(New cRecPU(1000, 912, 305, 168))
				Me.table_4500_fg.Clear()
				Me.table_4500_fg.Add(New cRecPU(50, 90, 119, 58))
				Me.table_4500_fg.Add(New cRecPU(100, 114, 119, 74))
				Me.table_4500_fg.Add(New cRecPU(200, 228, 173, 74))
				Me.table_4500_fg.Add(New cRecPU(250, 228, 173, 86))
				Me.table_4500_fg.Add(New cRecPU(300, 320, 246, 86))
				Me.table_4500_fg.Add(New cRecPU(350, 456, 256, 100))
				Me.table_4500_fg.Add(New cRecPU(500, 640, 256, 120))
				Me.table_4500_fg.Add(New cRecPU(600, 640, 305, 120))
				Me.table_4500_fg.Add(New cRecPU(700, 912, 305, 144))
				Me.table_4500_fg.Add(New cRecPU(750, 1280, 365, 168))
				Me.table_5000_fg.Clear()
				Me.table_5000_fg.Add(New cRecPU(50, 90, 119, 58))
				Me.table_5000_fg.Add(New cRecPU(100, 160, 173, 74))
				Me.table_5000_fg.Add(New cRecPU(200, 228, 173, 74))
				Me.table_5000_fg.Add(New cRecPU(300, 320, 246, 86))
				Me.table_5000_fg.Add(New cRecPU(500, 456, 256, 100))
				Me.table_5000_fg.Add(New cRecPU(550, 640, 256, 120))
				Me.table_5000_fg.Add(New cRecPU(600, 640, 305, 120))
				Me.table_5000_fg.Add(New cRecPU(800, 912, 305, 144))
				Me.table_5500_fg.Clear()
				Me.table_5500_fg.Add(New cRecPU(50, 160, 145, 74))
				Me.table_5500_fg.Add(New cRecPU(100, 228, 173, 74))
				Me.table_5500_fg.Add(New cRecPU(200, 228, 200, 74))
				Me.table_5500_fg.Add(New cRecPU(300, 320, 246, 86))
				Me.table_5500_fg.Add(New cRecPU(550, 456, 256, 100))
				Me.table_5500_fg.Add(New cRecPU(600, 640, 305, 120))
				Me.table_5500_fg.Add(New cRecPU(900, 912, 305, 144))
				Me.table_6000_fg.Clear()
				Me.table_6000_fg.Add(New cRecPU(150, 160, 173, 74))
				Me.table_6000_fg.Add(New cRecPU(200, 228, 200, 74))
				Me.table_6000_fg.Add(New cRecPU(350, 320, 246, 86))
				Me.table_6000_fg.Add(New cRecPU(550, 456, 305, 100))
				Me.table_6000_fg.Add(New cRecPU(700, 640, 305, 120))
				Me.table_6000_fg.Add(New cRecPU(800, 912, 305, 144))
				Me.table_6500_fg.Clear()
				Me.table_6500_fg.Add(New cRecPU(50, 114, 173, 64))
				Me.table_6500_fg.Add(New cRecPU(200, 228, 200, 74))
				Me.table_6500_fg.Add(New cRecPU(350, 320, 246, 86))
				Me.table_6500_fg.Add(New cRecPU(450, 456, 256, 100))
				Me.table_6500_fg.Add(New cRecPU(500, 640, 256, 120))
				Me.table_6500_fg.Add(New cRecPU(600, 640, 305, 120))
				Me.table_6500_fg.Add(New cRecPU(800, 912, 305, 144))
				Me.table_7000_fg.Clear()
				Me.table_7000_fg.Add(New cRecPU(50, 160, 173, 74))
				Me.table_7000_fg.Add(New cRecPU(100, 160, 200, 74))
				Me.table_7000_fg.Add(New cRecPU(200, 228, 200, 74))
				Me.table_7000_fg.Add(New cRecPU(300, 320, 246, 74))
				Me.table_7000_fg.Add(New cRecPU(400, 456, 256, 100))
				Me.table_7000_fg.Add(New cRecPU(425, 640, 305, 120))
				Me.table_7000_fg.Add(New cRecPU(500, 640, 305, 144))
				Me.table_7000_fg.Add(New cRecPU(700, 912, 305, 156))
				Me.table_7000_fg.Add(New cRecPU(800, 912, 356, 156))
				Me.table_7500_fg.Clear()
				Me.table_7500_fg.Add(New cRecPU(50, 160, 173, 74))
				Me.table_7500_fg.Add(New cRecPU(100, 160, 200, 74))
				Me.table_7500_fg.Add(New cRecPU(150, 228, 213, 86))
				Me.table_7500_fg.Add(New cRecPU(250, 320, 246, 86))
				Me.table_7500_fg.Add(New cRecPU(300, 456, 256, 100))
				Me.table_7500_fg.Add(New cRecPU(400, 640, 256, 120))
				Me.table_7500_fg.Add(New cRecPU(500, 640, 305, 120))
				Me.table_7500_fg.Add(New cRecPU(700, 912, 365, 144))
				Me.table_8000_fg.Clear()
				Me.table_8000_fg.Add(New cRecPU(100, 160, 200, 74))
				Me.table_8000_fg.Add(New cRecPU(150, 228, 200, 74))
				Me.table_8000_fg.Add(New cRecPU(200, 228, 246, 86))
				Me.table_8000_fg.Add(New cRecPU(250, 320, 305, 100))
				Me.table_8000_fg.Add(New cRecPU(350, 456, 305, 120))
				Me.table_8000_fg.Add(New cRecPU(450, 640, 305, 144))
				Me.table_8000_fg.Add(New cRecPU(550, 912, 356, 156))
				Me.table_8000_fg.Add(New cRecPU(600, 912, 365, 168))
				Me.table_8000_fg.Add(New cRecPU(800, 1280, 365, 192))
				Me.table_8500_fg.Clear()
				Me.table_8500_fg.Add(New cRecPU(100, 160, 200, 74))
				Me.table_8500_fg.Add(New cRecPU(150, 228, 246, 86))
				Me.table_8500_fg.Add(New cRecPU(250, 320, 256, 100))
				Me.table_8500_fg.Add(New cRecPU(350, 456, 305, 120))
				Me.table_8500_fg.Add(New cRecPU(400, 640, 305, 144))
				Me.table_8500_fg.Add(New cRecPU(450, 640, 365, 144))
				Me.table_8500_fg.Add(New cRecPU(500, 640, 365, 144))
				Me.table_8500_fg.Add(New cRecPU(550, 912, 405, 156))
				Me.table_8500_fg.Add(New cRecPU(650, 912, 365, 168))
				Me.table_8500_fg.Add(New cRecPU(750, 1280, 365, 192))
				Me.table_9000_fg.Clear()
				Me.table_9000_fg.Add(New cRecPU(50, 160, 200, 74))
				Me.table_9000_fg.Add(New cRecPU(150, 228, 213, 86))
				Me.table_9000_fg.Add(New cRecPU(200, 320, 305, 100))
				Me.table_9000_fg.Add(New cRecPU(300, 456, 305, 120))
				Me.table_9000_fg.Add(New cRecPU(350, 640, 305, 144))
				Me.table_9000_fg.Add(New cRecPU(400, 640, 365, 144))
				Me.table_9000_fg.Add(New cRecPU(550, 912, 365, 168))
				Me.table_9000_fg.Add(New cRecPU(700, 1280, 365, 192))
				Me.table_9500_fg.Clear()
				Me.table_9500_fg.Add(New cRecPU(50, 160, 213, 86))
				Me.table_9500_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_9500_fg.Add(New cRecPU(150, 320, 256, 100))
				Me.table_9500_fg.Add(New cRecPU(200, 456, 305, 120))
				Me.table_9500_fg.Add(New cRecPU(300, 640, 305, 144))
				Me.table_9500_fg.Add(New cRecPU(350, 640, 305, 168))
				Me.table_9500_fg.Add(New cRecPU(450, 912, 305, 168))
				Me.table_9500_fg.Add(New cRecPU(550, 912, 305, 192))
				Me.table_9500_fg.Add(New cRecPU(600, 912, 365, 192))
				Me.table_10000_fg.Clear()
				Me.table_10000_fg.Add(New cRecPU(50, 160, 213, 86))
				Me.table_10000_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_10000_fg.Add(New cRecPU(150, 320, 256, 100))
				Me.table_10000_fg.Add(New cRecPU(200, 456, 305, 120))
				Me.table_10000_fg.Add(New cRecPU(300, 640, 305, 144))
				Me.table_10000_fg.Add(New cRecPU(350, 640, 305, 168))
				Me.table_10000_fg.Add(New cRecPU(400, 912, 305, 192))
				Me.table_10000_fg.Add(New cRecPU(550, 912, 365, 192))
				Me.table_10500_fg.Clear()
				Me.table_10500_fg.Add(New cRecPU(50, 228, 246, 86))
				Me.table_10500_fg.Add(New cRecPU(100, 320, 256, 100))
				Me.table_10500_fg.Add(New cRecPU(150, 320, 305, 120))
				Me.table_10500_fg.Add(New cRecPU(250, 456, 305, 144))
				Me.table_10500_fg.Add(New cRecPU(350, 640, 305, 168))
				Me.table_10500_fg.Add(New cRecPU(450, 912, 305, 192))
				Me.table_10500_fg.Add(New cRecPU(500, 912, 427, 192))
				Me.table_11000_fg.Clear()
				Me.table_11000_fg.Add(New cRecPU(50, 228, 246, 86))
				Me.table_11000_fg.Add(New cRecPU(100, 320, 256, 100))
				Me.table_11000_fg.Add(New cRecPU(150, 320, 305, 120))
				Me.table_11000_fg.Add(New cRecPU(200, 456, 365, 144))
				Me.table_11000_fg.Add(New cRecPU(300, 640, 365, 168))
				Me.table_11000_fg.Add(New cRecPU(400, 912, 365, 192))
				Me.table_11000_fg.Add(New cRecPU(450, 912, 427, 192))
				Me.table_12000_fg.Clear()
				Me.table_12000_fg.Add(New cRecPU(50, 228, 256, 100))
				Me.table_12000_fg.Add(New cRecPU(100, 320, 305, 120))
				Me.table_12000_fg.Add(New cRecPU(150, 456, 305, 144))
				Me.table_12000_fg.Add(New cRecPU(200, 640, 305, 156))
				Me.table_12000_fg.Add(New cRecPU(250, 912, 365, 168))
				Me.table_12000_fg.Add(New cRecPU(300, 912, 427, 168))
				Me.table_12000_fg.Add(New cRecPU(400, 912, 427, 192))
				Me.table_13000_fg.Clear()
				Me.table_13000_fg.Add(New cRecPU(50, 320, 256, 100))
				Me.table_13000_fg.Add(New cRecPU(75, 320, 305, 120))
				Me.table_13000_fg.Add(New cRecPU(100, 456, 305, 144))
				Me.table_13000_fg.Add(New cRecPU(150, 640, 305, 156))
				Me.table_13000_fg.Add(New cRecPU(200, 640, 365, 168))
				Me.table_13000_fg.Add(New cRecPU(300, 912, 427, 192))
				Me.table_14000_fg.Clear()
				Me.table_14000_fg.Add(New cRecPU(75, 320, 305, 120))
				Me.table_14000_fg.Add(New cRecPU(100, 456, 305, 144))
				Me.table_14000_fg.Add(New cRecPU(150, 640, 365, 156))
				Me.table_14000_fg.Add(New cRecPU(175, 912, 365, 168))
				Me.table_14000_fg.Add(New cRecPU(250, 912, 365, 192))
				Me.table_15000_fg.Clear()
				Me.table_15000_fg.Add(New cRecPU(75, 456, 305, 144))
				Me.table_15000_fg.Add(New cRecPU(150, 640, 305, 168))
				Me.table_15000_fg.Add(New cRecPU(200, 640, 305, 192))
				Me.table_16000_fg.Clear()
				Me.table_16000_fg.Add(New cRecPU(50, 640, 365, 144))
				Me.table_16000_fg.Add(New cRecPU(175, 640, 305, 192))
				Me.table_17000_fg.Clear()
				Me.table_17000_fg.Add(New cRecPU(50, 640, 365, 144))
				Me.table_17000_fg.Add(New cRecPU(100, 912, 365, 168))
				Me.table_17000_fg.Add(New cRecPU(150, 912, 365, 192))
				Me.table_18000_fg.Clear()
				Me.table_18000_fg.Add(New cRecPU(50, 912, 365, 168))
				Me.table_18000_fg.Add(New cRecPU(125, 912, 365, 192))
				Me.table_19000_fg.Clear()
				Me.table_19000_fg.Add(New cRecPU(100, 912, 365, 192))
				Me.table_20000_fg.Clear()
				Me.table_20000_fg.Add(New cRecPU(50, 912, 365, 192))
				Me.table_20000_fg.Add(New cRecPU(100, 912, 427, 192))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUFGAL_SAVE()
			Try
				Me.table_2000_fg.Clear()
				Me.table_2000_fg.Add(New cRecPU(100, 40, 67, 36))
				Me.table_2000_fg.Add(New cRecPU(150, 57, 76, 42))
				Me.table_2000_fg.Add(New cRecPU(200, 80, 76, 42))
				Me.table_2000_fg.Add(New cRecPU(300, 114, 119, 54))
				Me.table_2000_fg.Add(New cRecPU(400, 160, 143, 64))
				Me.table_2000_fg.Add(New cRecPU(600, 228, 143, 86))
				Me.table_2000_fg.Add(New cRecPU(800, 320, 143, 100))
				Me.table_2000_fg.Add(New cRecPU(1000, 456, 213, 120))
				Me.table_2000_fg.Add(New cRecPU(1250, 456, 213, 144))
				Me.table_2000_fg.Add(New cRecPU(1500, 640, 213, 168))
				Me.table_2000_fg.Add(New cRecPU(1750, 912, 305, 192))
				Me.table_2000_fg.Add(New cRecPU(2500, 1280, 305, 216))
				Me.table_2000_fg.Add(New cRecPU(2750, 1824, 305, 240))
				Me.table_2000_fg.Add(New cRecPU(3000, 1824, 305, 260))
				Me.table_3000_fg.Clear()
				Me.table_3000_fg.Add(New cRecPU(100, 80, 95, 48))
				Me.table_3000_fg.Add(New cRecPU(200, 114, 133, 48))
				Me.table_3000_fg.Add(New cRecPU(250, 160, 143, 64))
				Me.table_3000_fg.Add(New cRecPU(300, 228, 200, 64))
				Me.table_3000_fg.Add(New cRecPU(400, 320, 212, 74))
				Me.table_3000_fg.Add(New cRecPU(500, 320, 212, 86))
				Me.table_3000_fg.Add(New cRecPU(600, 456, 212, 100))
				Me.table_3000_fg.Add(New cRecPU(700, 456, 256, 100))
				Me.table_3000_fg.Add(New cRecPU(800, 640, 256, 120))
				Me.table_3000_fg.Add(New cRecPU(900, 640, 256, 144))
				Me.table_3000_fg.Add(New cRecPU(1250, 912, 305, 168))
				Me.table_3000_fg.Add(New cRecPU(1400, 912, 305, 192))
				Me.table_3000_fg.Add(New cRecPU(1600, 1280, 305, 192))
				Me.table_3000_fg.Add(New cRecPU(1700, 1280, 305, 216))
				Me.table_3000_fg.Add(New cRecPU(1800, 1824, 305, 260))
				Me.table_3500_fg.Clear()
				Me.table_3500_fg.Add(New cRecPU(100, 80, 95, 48))
				Me.table_3500_fg.Add(New cRecPU(200, 160, 169, 54))
				Me.table_3500_fg.Add(New cRecPU(300, 228, 200, 64))
				Me.table_3500_fg.Add(New cRecPU(400, 320, 200, 74))
				Me.table_3500_fg.Add(New cRecPU(500, 320, 200, 86))
				Me.table_3500_fg.Add(New cRecPU(550, 456, 200, 100))
				Me.table_3500_fg.Add(New cRecPU(600, 640, 200, 120))
				Me.table_3500_fg.Add(New cRecPU(650, 640, 253, 120))
				Me.table_3500_fg.Add(New cRecPU(800, 912, 256, 144))
				Me.table_3500_fg.Add(New cRecPU(850, 912, 305, 168))
				Me.table_3500_fg.Add(New cRecPU(900, 912, 305, 192))
				Me.table_3500_fg.Add(New cRecPU(1200, 1280, 305, 192))
				Me.table_3500_fg.Add(New cRecPU(1450, 1280, 305, 192))
				Me.table_3500_fg.Add(New cRecPU(1650, 1280, 305, 216))
				Me.table_3500_fg.Add(New cRecPU(1750, 1824, 305, 260))
				Me.table_4000_fg.Clear()
				Me.table_4000_fg.Add(New cRecPU(50, 80, 119, 54))
				Me.table_4000_fg.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4000_fg.Add(New cRecPU(200, 160, 169, 54))
				Me.table_4000_fg.Add(New cRecPU(300, 228, 200, 64))
				Me.table_4000_fg.Add(New cRecPU(400, 320, 212, 74))
				Me.table_4000_fg.Add(New cRecPU(500, 320, 212, 86))
				Me.table_4000_fg.Add(New cRecPU(550, 456, 212, 100))
				Me.table_4000_fg.Add(New cRecPU(600, 640, 253, 120))
				Me.table_4000_fg.Add(New cRecPU(700, 912, 305, 144))
				Me.table_4000_fg.Add(New cRecPU(800, 912, 305, 168))
				Me.table_4000_fg.Add(New cRecPU(1000, 1280, 305, 192))
				Me.table_4000_fg.Add(New cRecPU(1100, 1824, 305, 240))
				Me.table_5000_fg.Clear()
				Me.table_5000_fg.Add(New cRecPU(100, 114, 119, 54))
				Me.table_5000_fg.Add(New cRecPU(150, 160, 169, 54))
				Me.table_5000_fg.Add(New cRecPU(200, 228, 173, 64))
				Me.table_5000_fg.Add(New cRecPU(300, 228, 173, 74))
				Me.table_5000_fg.Add(New cRecPU(350, 320, 213, 86))
				Me.table_5000_fg.Add(New cRecPU(450, 456, 213, 100))
				Me.table_5000_fg.Add(New cRecPU(500, 456, 298, 100))
				Me.table_5000_fg.Add(New cRecPU(600, 640, 305, 120))
				Me.table_5000_fg.Add(New cRecPU(750, 912, 305, 144))
				Me.table_5000_fg.Add(New cRecPU(800, 1280, 305, 192))
				Me.table_5000_fg.Add(New cRecPU(900, 1824, 356, 192))
				Me.table_6000_fg.Clear()
				Me.table_6000_fg.Add(New cRecPU(100, 114, 143, 64))
				Me.table_6000_fg.Add(New cRecPU(150, 228, 173, 74))
				Me.table_6000_fg.Add(New cRecPU(200, 320, 173, 86))
				Me.table_6000_fg.Add(New cRecPU(300, 456, 256, 100))
				Me.table_6000_fg.Add(New cRecPU(400, 640, 246, 120))
				Me.table_6000_fg.Add(New cRecPU(450, 912, 256, 144))
				Me.table_6000_fg.Add(New cRecPU(600, 912, 305, 144))
				Me.table_6000_fg.Add(New cRecPU(700, 912, 305, 144))
				Me.table_6000_fg.Add(New cRecPU(800, 1824, 305, 216))
				Me.table_7000_fg.Clear()
				Me.table_7000_fg.Add(New cRecPU(50, 160, 173, 86))
				Me.table_7000_fg.Add(New cRecPU(100, 228, 213, 86))
				Me.table_7000_fg.Add(New cRecPU(200, 320, 213, 86))
				Me.table_7000_fg.Add(New cRecPU(300, 456, 256, 100))
				Me.table_7000_fg.Add(New cRecPU(400, 640, 305, 120))
				Me.table_7000_fg.Add(New cRecPU(550, 912, 305, 144))
				Me.table_7000_fg.Add(New cRecPU(700, 1280, 305, 192))
				Me.table_7000_fg.Add(New cRecPU(800, 1824, 305, 240))
				Me.table_8000_fg.Clear()
				Me.table_8000_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_8000_fg.Add(New cRecPU(200, 320, 246, 86))
				Me.table_8000_fg.Add(New cRecPU(300, 456, 256, 100))
				Me.table_8000_fg.Add(New cRecPU(400, 456, 298, 100))
				Me.table_8000_fg.Add(New cRecPU(450, 640, 305, 120))
				Me.table_8000_fg.Add(New cRecPU(500, 912, 305, 144))
				Me.table_8000_fg.Add(New cRecPU(550, 1280, 305, 168))
				Me.table_8000_fg.Add(New cRecPU(650, 1280, 305, 192))
				Me.table_8000_fg.Add(New cRecPU(700, 1824, 305, 216))
				Me.table_8000_fg.Add(New cRecPU(750, 1824, 305, 240))
				Me.table_9000_fg.Clear()
				Me.table_9000_fg.Add(New cRecPU(50, 160, 200, 74))
				Me.table_9000_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_9000_fg.Add(New cRecPU(200, 320, 305, 100))
				Me.table_9000_fg.Add(New cRecPU(250, 456, 305, 120))
				Me.table_9000_fg.Add(New cRecPU(300, 640, 305, 120))
				Me.table_9000_fg.Add(New cRecPU(400, 912, 305, 144))
				Me.table_9000_fg.Add(New cRecPU(550, 1280, 305, 192))
				Me.table_9000_fg.Add(New cRecPU(650, 1824, 305, 216))
				Me.table_9000_fg.Add(New cRecPU(700, 1824, 305, 240))
				Me.table_10000_fg.Clear()
				Me.table_10000_fg.Add(New cRecPU(100, 320, 256, 100))
				Me.table_10000_fg.Add(New cRecPU(200, 320, 305, 120))
				Me.table_10000_fg.Add(New cRecPU(300, 456, 305, 120))
				Me.table_10000_fg.Add(New cRecPU(400, 640, 365, 120))
				Me.table_10000_fg.Add(New cRecPU(500, 912, 356, 144))
				Me.table_10000_fg.Add(New cRecPU(600, 1280, 427, 168))
				Me.table_10000_fg.Add(New cRecPU(700, 1824, 427, 192))
				Me.table_11000_fg.Clear()
				Me.table_11000_fg.Add(New cRecPU(50, 228, 246, 86))
				Me.table_11000_fg.Add(New cRecPU(100, 320, 305, 100))
				Me.table_11000_fg.Add(New cRecPU(200, 456, 305, 120))
				Me.table_11000_fg.Add(New cRecPU(300, 640, 356, 144))
				Me.table_11000_fg.Add(New cRecPU(400, 912, 356, 168))
				Me.table_11000_fg.Add(New cRecPU(450, 1280, 365, 192))
				Me.table_11000_fg.Add(New cRecPU(550, 1824, 427, 216))
				Me.table_12000_fg.Clear()
				Me.table_12000_fg.Add(New cRecPU(50, 228, 256, 100))
				Me.table_12000_fg.Add(New cRecPU(75, 320, 256, 120))
				Me.table_12000_fg.Add(New cRecPU(100, 456, 305, 120))
				Me.table_12000_fg.Add(New cRecPU(200, 640, 356, 144))
				Me.table_12000_fg.Add(New cRecPU(300, 912, 356, 168))
				Me.table_12000_fg.Add(New cRecPU(350, 912, 365, 168))
				Me.table_12000_fg.Add(New cRecPU(400, 1280, 365, 192))
				Me.table_12000_fg.Add(New cRecPU(450, 1280, 427, 192))
				Me.table_13000_fg.Clear()
				Me.table_13000_fg.Add(New cRecPU(50, 320, 256, 120))
				Me.table_13000_fg.Add(New cRecPU(75, 320, 305, 120))
				Me.table_13000_fg.Add(New cRecPU(150, 456, 305, 144))
				Me.table_13000_fg.Add(New cRecPU(200, 640, 305, 168))
				Me.table_13000_fg.Add(New cRecPU(300, 912, 365, 192))
				Me.table_13000_fg.Add(New cRecPU(450, 1280, 365, 240))
				Me.table_14000_fg.Clear()
				Me.table_14000_fg.Add(New cRecPU(75, 320, 256, 120))
				Me.table_14000_fg.Add(New cRecPU(100, 456, 305, 120))
				Me.table_14000_fg.Add(New cRecPU(150, 640, 365, 168))
				Me.table_14000_fg.Add(New cRecPU(200, 912, 356, 168))
				Me.table_14000_fg.Add(New cRecPU(250, 912, 365, 192))
				Me.table_14000_fg.Add(New cRecPU(350, 1280, 365, 216))
				Me.table_14000_fg.Add(New cRecPU(400, 1280, 305, 240))
				Me.table_14000_fg.Add(New cRecPU(450, 1824, 305, 240))
				Me.table_15000_fg.Clear()
				Me.table_15000_fg.Add(New cRecPU(50, 320, 305, 120))
				Me.table_15000_fg.Add(New cRecPU(100, 456, 305, 144))
				Me.table_15000_fg.Add(New cRecPU(150, 640, 356, 168))
				Me.table_15000_fg.Add(New cRecPU(250, 912, 305, 192))
				Me.table_15000_fg.Add(New cRecPU(300, 1280, 305, 216))
				Me.table_15000_fg.Add(New cRecPU(350, 1824, 356, 240))
				Me.table_15000_fg.Add(New cRecPU(400, 1824, 356, 260))
				Me.table_16000_fg.Clear()
				Me.table_16000_fg.Add(New cRecPU(75, 456, 305, 144))
				Me.table_16000_fg.Add(New cRecPU(100, 640, 356, 168))
				Me.table_16000_fg.Add(New cRecPU(200, 912, 365, 192))
				Me.table_16000_fg.Add(New cRecPU(250, 1280, 365, 216))
				Me.table_16000_fg.Add(New cRecPU(300, 1280, 305, 240))
				Me.table_16000_fg.Add(New cRecPU(350, 1824, 356, 240))
				Me.table_16000_fg.Add(New cRecPU(400, 1824, 356, 260))
				Me.table_17000_fg.Clear()
				Me.table_17000_fg.Add(New cRecPU(50, 456, 305, 144))
				Me.table_17000_fg.Add(New cRecPU(100, 640, 356, 168))
				Me.table_17000_fg.Add(New cRecPU(150, 912, 365, 192))
				Me.table_17000_fg.Add(New cRecPU(200, 1280, 365, 216))
				Me.table_17000_fg.Add(New cRecPU(275, 1824, 365, 240))
				Me.table_17000_fg.Add(New cRecPU(325, 1824, 365, 260))
				Me.table_18000_fg.Clear()
				Me.table_18000_fg.Add(New cRecPU(50, 456, 305, 168))
				Me.table_18000_fg.Add(New cRecPU(75, 640, 356, 168))
				Me.table_18000_fg.Add(New cRecPU(100, 640, 365, 192))
				Me.table_18000_fg.Add(New cRecPU(150, 912, 365, 216))
				Me.table_18000_fg.Add(New cRecPU(200, 1280, 305, 240))
				Me.table_18000_fg.Add(New cRecPU(250, 1280, 305, 260))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUFGAL_OLD()
			Try
				Me.table_2000_fg.Clear()
				Me.table_2000_fg.Add(New cRecPU(100, 40, 76, 36))
				Me.table_2000_fg.Add(New cRecPU(200, 57, 76, 42))
				Me.table_2000_fg.Add(New cRecPU(300, 114, 119, 54))
				Me.table_2000_fg.Add(New cRecPU(400, 160, 133, 74))
				Me.table_2000_fg.Add(New cRecPU(500, 228, 143, 86))
				Me.table_2000_fg.Add(New cRecPU(600, 456, 213, 100))
				Me.table_2000_fg.Add(New cRecPU(800, 640, 305, 120))
				Me.table_2000_fg.Add(New cRecPU(1000, 640, 365, 120))
				Me.table_2000_fg.Add(New cRecPU(1250, 912, 365, 144))
				Me.table_2000_fg.Add(New cRecPU(1500, 912, 365, 144))
				Me.table_3000_fg.Clear()
				Me.table_3000_fg.Add(New cRecPU(100, 80, 133, 48))
				Me.table_3000_fg.Add(New cRecPU(200, 114, 133, 48))
				Me.table_3000_fg.Add(New cRecPU(300, 114, 169, 54))
				Me.table_3000_fg.Add(New cRecPU(400, 228, 173, 74))
				Me.table_3000_fg.Add(New cRecPU(500, 320, 212, 86))
				Me.table_3000_fg.Add(New cRecPU(600, 456, 213, 100))
				Me.table_3000_fg.Add(New cRecPU(800, 640, 305, 120))
				Me.table_3000_fg.Add(New cRecPU(1000, 912, 305, 144))
				Me.table_3000_fg.Add(New cRecPU(1250, 912, 365, 144))
				Me.table_4000_fg.Clear()
				Me.table_4000_fg.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4000_fg.Add(New cRecPU(200, 114, 169, 54))
				Me.table_4000_fg.Add(New cRecPU(300, 160, 169, 54))
				Me.table_4000_fg.Add(New cRecPU(400, 320, 246, 74))
				Me.table_4000_fg.Add(New cRecPU(500, 320, 246, 86))
				Me.table_4000_fg.Add(New cRecPU(600, 456, 256, 100))
				Me.table_4000_fg.Add(New cRecPU(800, 912, 305, 144))
				Me.table_4000_fg.Add(New cRecPU(900, 912, 305, 144))
				Me.table_4000_fg.Add(New cRecPU(1000, 1280, 305, 192))
				Me.table_5000_fg.Clear()
				Me.table_5000_fg.Add(New cRecPU(100, 114, 169, 54))
				Me.table_5000_fg.Add(New cRecPU(200, 160, 173, 64))
				Me.table_5000_fg.Add(New cRecPU(300, 228, 213, 86))
				Me.table_5000_fg.Add(New cRecPU(400, 320, 213, 86))
				Me.table_5000_fg.Add(New cRecPU(450, 456, 256, 100))
				Me.table_5000_fg.Add(New cRecPU(500, 456, 298, 100))
				Me.table_5000_fg.Add(New cRecPU(550, 640, 305, 120))
				Me.table_5000_fg.Add(New cRecPU(600, 640, 305, 120))
				Me.table_5000_fg.Add(New cRecPU(750, 640, 305, 120))
				Me.table_5000_fg.Add(New cRecPU(800, 912, 305, 144))
				Me.table_5000_fg.Add(New cRecPU(900, 1824, 356, 192))
				Me.table_6000_fg.Clear()
				Me.table_6000_fg.Add(New cRecPU(100, 228, 213, 86))
				Me.table_6000_fg.Add(New cRecPU(200, 160, 173, 100))
				Me.table_6000_fg.Add(New cRecPU(300, 228, 246, 100))
				Me.table_6000_fg.Add(New cRecPU(400, 320, 213, 100))
				Me.table_6000_fg.Add(New cRecPU(450, 456, 256, 100))
				Me.table_6000_fg.Add(New cRecPU(500, 456, 256, 120))
				Me.table_6000_fg.Add(New cRecPU(550, 640, 305, 120))
				Me.table_6000_fg.Add(New cRecPU(600, 640, 305, 120))
				Me.table_6000_fg.Add(New cRecPU(700, 912, 305, 144))
				Me.table_6000_fg.Add(New cRecPU(800, 1824, 356, 192))
				Me.table_7000_fg.Clear()
				Me.table_7000_fg.Add(New cRecPU(100, 228, 213, 86))
				Me.table_7000_fg.Add(New cRecPU(200, 228, 246, 100))
				Me.table_7000_fg.Add(New cRecPU(300, 320, 256, 100))
				Me.table_7000_fg.Add(New cRecPU(400, 456, 256, 120))
				Me.table_7000_fg.Add(New cRecPU(550, 640, 305, 120))
				Me.table_7000_fg.Add(New cRecPU(600, 640, 305, 120))
				Me.table_7000_fg.Add(New cRecPU(700, 912, 305, 144))
				Me.table_7000_fg.Add(New cRecPU(800, 1280, 356, 168))
				Me.table_8000_fg.Clear()
				Me.table_8000_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_8000_fg.Add(New cRecPU(200, 228, 246, 100))
				Me.table_8000_fg.Add(New cRecPU(300, 320, 305, 100))
				Me.table_8000_fg.Add(New cRecPU(400, 456, 305, 120))
				Me.table_8000_fg.Add(New cRecPU(500, 640, 305, 120))
				Me.table_8000_fg.Add(New cRecPU(650, 912, 356, 144))
				Me.table_8000_fg.Add(New cRecPU(800, 1280, 365, 168))
				Me.table_9000_fg.Clear()
				Me.table_9000_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_9000_fg.Add(New cRecPU(200, 320, 305, 100))
				Me.table_9000_fg.Add(New cRecPU(300, 456, 305, 120))
				Me.table_9000_fg.Add(New cRecPU(400, 640, 305, 120))
				Me.table_9000_fg.Add(New cRecPU(500, 640, 305, 120))
				Me.table_9000_fg.Add(New cRecPU(600, 912, 356, 144))
				Me.table_9000_fg.Add(New cRecPU(700, 1280, 427, 168))
				Me.table_10000_fg.Clear()
				Me.table_10000_fg.Add(New cRecPU(100, 320, 256, 100))
				Me.table_10000_fg.Add(New cRecPU(200, 320, 305, 120))
				Me.table_10000_fg.Add(New cRecPU(300, 456, 305, 120))
				Me.table_10000_fg.Add(New cRecPU(400, 640, 365, 120))
				Me.table_10000_fg.Add(New cRecPU(500, 912, 356, 144))
				Me.table_10000_fg.Add(New cRecPU(600, 1280, 427, 168))
				Me.table_10000_fg.Add(New cRecPU(700, 1824, 427, 192))
				Me.table_11000_fg.Clear()
				Me.table_11000_fg.Add(New cRecPU(100, 320, 305, 100))
				Me.table_11000_fg.Add(New cRecPU(200, 320, 305, 120))
				Me.table_11000_fg.Add(New cRecPU(300, 640, 356, 144))
				Me.table_11000_fg.Add(New cRecPU(400, 912, 427, 144))
				Me.table_11000_fg.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_11000_fg.Add(New cRecPU(600, 1824, 470, 216))
				Me.table_12000_fg.Clear()
				Me.table_12000_fg.Add(New cRecPU(100, 320, 305, 120))
				Me.table_12000_fg.Add(New cRecPU(200, 456, 305, 144))
				Me.table_12000_fg.Add(New cRecPU(250, 640, 356, 144))
				Me.table_12000_fg.Add(New cRecPU(350, 912, 305, 144))
				Me.table_12000_fg.Add(New cRecPU(400, 912, 356, 144))
				Me.table_12000_fg.Add(New cRecPU(500, 1824, 427, 216))
				Me.table_13000_fg.Clear()
				Me.table_13000_fg.Add(New cRecPU(100, 320, 305, 120))
				Me.table_13000_fg.Add(New cRecPU(150, 456, 305, 144))
				Me.table_13000_fg.Add(New cRecPU(200, 640, 305, 144))
				Me.table_13000_fg.Add(New cRecPU(300, 912, 427, 144))
				Me.table_13000_fg.Add(New cRecPU(400, 1280, 427, 168))
				Me.table_14000_fg.Clear()
				Me.table_14000_fg.Add(New cRecPU(100, 456, 305, 120))
				Me.table_14000_fg.Add(New cRecPU(200, 640, 356, 144))
				Me.table_14000_fg.Add(New cRecPU(350, 912, 427, 144))
				Me.table_14000_fg.Add(New cRecPU(400, 1280, 470, 168))
				Me.table_15000_fg.Clear()
				Me.table_15000_fg.Add(New cRecPU(125, 456, 365, 120))
				Me.table_15000_fg.Add(New cRecPU(200, 640, 427, 144))
				Me.table_15000_fg.Add(New cRecPU(300, 912, 427, 144))
				Me.table_15000_fg.Add(New cRecPU(400, 1280, 470, 168))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUSTAL_older2()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(250, 25, 53, 24))
				Me.table_1000_st.Add(New cRecPU(300, 40, 67, 30))
				Me.table_1000_st.Add(New cRecPU(400, 57, 67, 42))
				Me.table_1000_st.Add(New cRecPU(500, 80, 76, 48))
				Me.table_1000_st.Add(New cRecPU(600, 80, 76, 54))
				Me.table_1000_st.Add(New cRecPU(700, 114, 76, 54))
				Me.table_1000_st.Add(New cRecPU(800, 114, 109, 54))
				Me.table_1000_st.Add(New cRecPU(900, 160, 143, 64))
				Me.table_1000_st.Add(New cRecPU(1250, 228, 173, 74))
				Me.table_1000_st.Add(New cRecPU(1600, 320, 212, 86))
				Me.table_1000_st.Add(New cRecPU(1750, 456, 256, 120))
				Me.table_1000_st.Add(New cRecPU(2000, 456, 256, 144))
				Me.table_1000_st.Add(New cRecPU(2400, 640, 305, 120))
				Me.table_1000_st.Add(New cRecPU(3250, 912, 305, 144))
				Me.table_1000_st.Add(New cRecPU(3500, 1280, 305, 168))
				Me.table_1000_st.Add(New cRecPU(3750, 1280, 305, 192))
				Me.table_1000_st.Add(New cRecPU(4000, 1280, 305, 240))
				Me.table_1000_st.Add(New cRecPU(5000, 1824, 356, 240))
				Me.table_1000_st.Add(New cRecPU(7000, 1824, 356, 260))
				Me.table_1500_st.Clear()
				Me.table_1500_st.Add(New cRecPU(100, 25, 53, 24))
				Me.table_1500_st.Add(New cRecPU(150, 37, 53, 34))
				Me.table_1500_st.Add(New cRecPU(200, 57, 56, 36))
				Me.table_1500_st.Add(New cRecPU(300, 57, 67, 42))
				Me.table_1500_st.Add(New cRecPU(400, 80, 95, 48))
				Me.table_1500_st.Add(New cRecPU(500, 114, 119, 54))
				Me.table_1500_st.Add(New cRecPU(600, 119, 119, 64))
				Me.table_1500_st.Add(New cRecPU(900, 228, 121, 86))
				Me.table_1500_st.Add(New cRecPU(1000, 228, 143, 100))
				Me.table_1500_st.Add(New cRecPU(1100, 320, 213, 120))
				Me.table_1500_st.Add(New cRecPU(1300, 456, 213, 120))
				Me.table_1500_st.Add(New cRecPU(1600, 640, 253, 144))
				Me.table_1500_st.Add(New cRecPU(2000, 640, 256, 144))
				Me.table_1500_st.Add(New cRecPU(2500, 912, 256, 168))
				Me.table_1500_st.Add(New cRecPU(3000, 1280, 305, 192))
				Me.table_1500_st.Add(New cRecPU(3500, 1280, 305, 240))
				Me.table_1500_st.Add(New cRecPU(4000, 1824, 305, 260))
				Me.table_1500_st.Add(New cRecPU(4500, 1824, 365, 260))
				Me.table_1500_st.Add(New cRecPU(5000, 1824, 365, 260))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(50, 25, 53, 24))
				Me.table_2000_st.Add(New cRecPU(100, 40, 67, 30))
				Me.table_2000_st.Add(New cRecPU(150, 57, 89, 42))
				Me.table_2000_st.Add(New cRecPU(200, 57, 76, 42))
				Me.table_2000_st.Add(New cRecPU(250, 80, 95, 48))
				Me.table_2000_st.Add(New cRecPU(300, 114, 119, 54))
				Me.table_2000_st.Add(New cRecPU(400, 114, 119, 54))
				Me.table_2000_st.Add(New cRecPU(500, 160, 119, 64))
				Me.table_2000_st.Add(New cRecPU(700, 228, 173, 74))
				Me.table_2000_st.Add(New cRecPU(900, 320, 212, 86))
				Me.table_2000_st.Add(New cRecPU(1000, 320, 213, 86))
				Me.table_2000_st.Add(New cRecPU(1100, 320, 256, 100))
				Me.table_2000_st.Add(New cRecPU(1250, 456, 256, 100))
				Me.table_2000_st.Add(New cRecPU(1500, 640, 305, 120))
				Me.table_2000_st.Add(New cRecPU(2000, 912, 305, 144))
				Me.table_2000_st.Add(New cRecPU(2250, 1280, 305, 168))
				Me.table_2000_st.Add(New cRecPU(2500, 1824, 305, 192))
				Me.table_2000_st.Add(New cRecPU(3000, 1824, 365, 192))
				Me.table_2000_st.Add(New cRecPU(4000, 1824, 365, 216))
				Me.table_2000_st.Add(New cRecPU(4500, 2560, 365, 240))
				Me.table_2500_st.Clear()
				Me.table_2500_st.Add(New cRecPU(50, 40, 67, 30))
				Me.table_2500_st.Add(New cRecPU(100, 57, 89, 36))
				Me.table_2500_st.Add(New cRecPU(150, 80, 109, 42))
				Me.table_2500_st.Add(New cRecPU(200, 114, 133, 48))
				Me.table_2500_st.Add(New cRecPU(250, 114, 119, 54))
				Me.table_2500_st.Add(New cRecPU(300, 160, 143, 64))
				Me.table_2500_st.Add(New cRecPU(400, 160, 173, 64))
				Me.table_2500_st.Add(New cRecPU(600, 228, 173, 74))
				Me.table_2500_st.Add(New cRecPU(800, 320, 213, 86))
				Me.table_2500_st.Add(New cRecPU(1000, 456, 256, 100))
				Me.table_2500_st.Add(New cRecPU(1250, 640, 305, 120))
				Me.table_2500_st.Add(New cRecPU(1500, 912, 305, 144))
				Me.table_2500_st.Add(New cRecPU(1750, 912, 356, 144))
				Me.table_2500_st.Add(New cRecPU(2000, 1280, 356, 144))
				Me.table_2500_st.Add(New cRecPU(2500, 1280, 365, 192))
				Me.table_2500_st.Add(New cRecPU(3000, 1824, 365, 216))
				Me.table_2500_st.Add(New cRecPU(3500, 2560, 470, 240))
				Me.table_2500_st.Add(New cRecPU(4000, 2560, 470, 260))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(50, 57, 89, 42))
				Me.table_3000_st.Add(New cRecPU(100, 80, 95, 48))
				Me.table_3000_st.Add(New cRecPU(150, 114, 133, 48))
				Me.table_3000_st.Add(New cRecPU(200, 160, 143, 64))
				Me.table_3000_st.Add(New cRecPU(300, 228, 173, 74))
				Me.table_3000_st.Add(New cRecPU(500, 320, 212, 86))
				Me.table_3000_st.Add(New cRecPU(600, 456, 256, 100))
				Me.table_3000_st.Add(New cRecPU(900, 640, 256, 100))
				Me.table_3000_st.Add(New cRecPU(1100, 640, 305, 120))
				Me.table_3000_st.Add(New cRecPU(1400, 912, 305, 144))
				Me.table_3000_st.Add(New cRecPU(1500, 912, 305, 168))
				Me.table_3000_st.Add(New cRecPU(1750, 1280, 305, 192))
				Me.table_3000_st.Add(New cRecPU(2000, 1280, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2400, 1824, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2700, 1824, 365, 216))
				Me.table_3000_st.Add(New cRecPU(3000, 2560, 470, 240))
				Me.table_3500_st.Clear()
				Me.table_3500_st.Add(New cRecPU(50, 80, 95, 48))
				Me.table_3500_st.Add(New cRecPU(100, 114, 133, 48))
				Me.table_3500_st.Add(New cRecPU(150, 160, 133, 54))
				Me.table_3500_st.Add(New cRecPU(200, 160, 143, 64))
				Me.table_3500_st.Add(New cRecPU(250, 228, 173, 74))
				Me.table_3500_st.Add(New cRecPU(350, 320, 246, 74))
				Me.table_3500_st.Add(New cRecPU(450, 456, 256, 86))
				Me.table_3500_st.Add(New cRecPU(600, 456, 256, 100))
				Me.table_3500_st.Add(New cRecPU(800, 640, 305, 120))
				Me.table_3500_st.Add(New cRecPU(1000, 912, 305, 144))
				Me.table_3500_st.Add(New cRecPU(1200, 912, 305, 168))
				Me.table_3500_st.Add(New cRecPU(1400, 1280, 305, 192))
				Me.table_3500_st.Add(New cRecPU(1800, 1824, 365, 192))
				Me.table_3500_st.Add(New cRecPU(2000, 1824, 365, 216))
				Me.table_3500_st.Add(New cRecPU(2200, 1824, 365, 240))
				Me.table_3500_st.Add(New cRecPU(2400, 2560, 365, 260))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(50, 80, 109, 48))
				Me.table_4000_st.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4000_st.Add(New cRecPU(150, 160, 169, 64))
				Me.table_4000_st.Add(New cRecPU(200, 228, 200, 64))
				Me.table_4000_st.Add(New cRecPU(300, 320, 240, 74))
				Me.table_4000_st.Add(New cRecPU(400, 456, 298, 86))
				Me.table_4000_st.Add(New cRecPU(600, 640, 305, 100))
				Me.table_4000_st.Add(New cRecPU(900, 912, 356, 120))
				Me.table_4000_st.Add(New cRecPU(1200, 1280, 365, 168))
				Me.table_4000_st.Add(New cRecPU(1400, 1824, 365, 216))
				Me.table_4000_st.Add(New cRecPU(1700, 1824, 365, 240))
				Me.table_4000_st.Add(New cRecPU(2000, 2560, 427, 260))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(50, 114, 133, 48))
				Me.table_5000_st.Add(New cRecPU(100, 160, 169, 54))
				Me.table_5000_st.Add(New cRecPU(150, 228, 200, 64))
				Me.table_5000_st.Add(New cRecPU(200, 320, 246, 74))
				Me.table_5000_st.Add(New cRecPU(300, 456, 298, 86))
				Me.table_5000_st.Add(New cRecPU(400, 640, 305, 100))
				Me.table_5000_st.Add(New cRecPU(600, 912, 356, 144))
				Me.table_5000_st.Add(New cRecPU(900, 1280, 356, 192))
				Me.table_5000_st.Add(New cRecPU(1200, 1824, 365, 192))
				Me.table_5000_st.Add(New cRecPU(1500, 2560, 427, 216))
				Me.table_5000_st.Add(New cRecPU(1750, 2560, 470, 260))
				Me.table_5500_st.Clear()
				Me.table_5500_st.Add(New cRecPU(50, 114, 169, 54))
				Me.table_5500_st.Add(New cRecPU(100, 228, 200, 64))
				Me.table_5500_st.Add(New cRecPU(150, 320, 246, 74))
				Me.table_5500_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_5500_st.Add(New cRecPU(300, 456, 298, 100))
				Me.table_5500_st.Add(New cRecPU(500, 640, 365, 100))
				Me.table_5500_st.Add(New cRecPU(600, 912, 365, 120))
				Me.table_5500_st.Add(New cRecPU(800, 1280, 356, 168))
				Me.table_5500_st.Add(New cRecPU(1000, 1824, 365, 192))
				Me.table_5500_st.Add(New cRecPU(1200, 2560, 427, 240))
				Me.table_5500_st.Add(New cRecPU(1500, 2560, 470, 260))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(50, 114, 169, 44))
				Me.table_6000_st.Add(New cRecPU(75, 114, 200, 48))
				Me.table_6000_st.Add(New cRecPU(100, 160, 200, 54))
				Me.table_6000_st.Add(New cRecPU(150, 228, 246, 54))
				Me.table_6000_st.Add(New cRecPU(200, 456, 256, 100))
				Me.table_6000_st.Add(New cRecPU(300, 640, 305, 100))
				Me.table_6000_st.Add(New cRecPU(400, 912, 356, 120))
				Me.table_6000_st.Add(New cRecPU(450, 912, 356, 144))
				Me.table_6000_st.Add(New cRecPU(500, 1280, 365, 168))
				Me.table_6000_st.Add(New cRecPU(600, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(800, 1824, 365, 192))
				Me.table_6000_st.Add(New cRecPU(900, 1824, 365, 216))
				Me.table_6000_st.Add(New cRecPU(1000, 2560, 470, 216))
				Me.table_6000_st.Add(New cRecPU(1250, 2560, 470, 240))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(100, 228, 200, 64))
				Me.table_7000_st.Add(New cRecPU(150, 320, 246, 74))
				Me.table_7000_st.Add(New cRecPU(200, 456, 298, 86))
				Me.table_7000_st.Add(New cRecPU(250, 456, 298, 100))
				Me.table_7000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_7000_st.Add(New cRecPU(400, 912, 356, 144))
				Me.table_7000_st.Add(New cRecPU(500, 1280, 365, 144))
				Me.table_7000_st.Add(New cRecPU(600, 1824, 365, 192))
				Me.table_7000_st.Add(New cRecPU(700, 1824, 427, 192))
				Me.table_7000_st.Add(New cRecPU(800, 2560, 427, 240))
				Me.table_7000_st.Add(New cRecPU(1000, 2560, 470, 240))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_8000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8000_st.Add(New cRecPU(300, 640, 365, 120))
				Me.table_8000_st.Add(New cRecPU(350, 912, 365, 144))
				Me.table_8000_st.Add(New cRecPU(400, 1280, 365, 192))
				Me.table_8000_st.Add(New cRecPU(600, 1824, 365, 192))
				Me.table_8000_st.Add(New cRecPU(650, 1824, 365, 216))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_9000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_9000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9000_st.Add(New cRecPU(300, 640, 365, 120))
				Me.table_9000_st.Add(New cRecPU(350, 912, 365, 144))
				Me.table_9000_st.Add(New cRecPU(400, 1280, 427, 192))
				Me.table_9000_st.Add(New cRecPU(500, 1824, 427, 192))
				Me.table_9000_st.Add(New cRecPU(600, 2560, 470, 240))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_10000_st.Add(New cRecPU(75, 320, 256, 100))
				Me.table_10000_st.Add(New cRecPU(150, 456, 298, 100))
				Me.table_10000_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10000_st.Add(New cRecPU(250, 912, 365, 144))
				Me.table_10000_st.Add(New cRecPU(300, 1280, 365, 168))
				Me.table_10000_st.Add(New cRecPU(400, 1824, 427, 216))
				Me.table_10000_st.Add(New cRecPU(450, 1824, 470, 240))
				Me.table_10000_st.Add(New cRecPU(500, 2560, 470, 260))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(50, 228, 305, 64))
				Me.table_11000_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_11000_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_11000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_11000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11000_st.Add(New cRecPU(300, 1280, 427, 192))
				Me.table_11000_st.Add(New cRecPU(400, 1824, 470, 240))
				Me.table_11000_st.Add(New cRecPU(450, 2560, 470, 260))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(50, 228, 305, 74))
				Me.table_12000_st.Add(New cRecPU(75, 320, 305, 86))
				Me.table_12000_st.Add(New cRecPU(175, 456, 365, 100))
				Me.table_12000_st.Add(New cRecPU(200, 640, 365, 100))
				Me.table_12000_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_12000_st.Add(New cRecPU(350, 1824, 427, 192))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(50, 228, 356, 86))
				Me.table_13000_st.Add(New cRecPU(75, 320, 356, 86))
				Me.table_13000_st.Add(New cRecPU(100, 456, 365, 100))
				Me.table_13000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13000_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_13000_st.Add(New cRecPU(250, 1280, 427, 192))
				Me.table_13000_st.Add(New cRecPU(300, 1824, 470, 216))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(50, 320, 356, 86))
				Me.table_14000_st.Add(New cRecPU(100, 456, 365, 100))
				Me.table_14000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14000_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_14000_st.Add(New cRecPU(250, 1824, 470, 216))
				Me.table_14000_st.Add(New cRecPU(275, 2560, 470, 300))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_15000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_15000_st.Add(New cRecPU(150, 912, 427, 120))
				Me.table_15000_st.Add(New cRecPU(200, 1824, 470, 216))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_16000_st.Add(New cRecPU(75, 456, 427, 120))
				Me.table_16000_st.Add(New cRecPU(100, 640, 470, 120))
				Me.table_16000_st.Add(New cRecPU(150, 912, 470, 144))
				Me.table_17000_st.Clear()
				Me.table_17000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_17000_st.Add(New cRecPU(100, 912, 427, 120))
				Me.table_17000_st.Add(New cRecPU(150, 912, 470, 144))
				Me.table_18000_st.Clear()
				Me.table_18000_st.Add(New cRecPU(50, 640, 470, 100))
				Me.table_18000_st.Add(New cRecPU(75, 640, 470, 120))
				Me.table_19000_st.Clear()
				Me.table_19000_st.Add(New cRecPU(50, 640, 470, 120))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUStal_Conv_extra()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(200, 25, 53, 24))
				Me.table_1000_st.Add(New cRecPU(300, 40, 67, 30))
				Me.table_1000_st.Add(New cRecPU(400, 57, 67, 42))
				Me.table_1000_st.Add(New cRecPU(500, 80, 76, 48))
				Me.table_1000_st.Add(New cRecPU(600, 80, 76, 54))
				Me.table_1000_st.Add(New cRecPU(700, 114, 76, 54))
				Me.table_1000_st.Add(New cRecPU(800, 114, 109, 54))
				Me.table_1000_st.Add(New cRecPU(900, 160, 143, 64))
				Me.table_1000_st.Add(New cRecPU(1250, 228, 143, 74))
				Me.table_1000_st.Add(New cRecPU(1600, 320, 143, 86))
				Me.table_1000_st.Add(New cRecPU(1750, 320, 173, 86))
				Me.table_1000_st.Add(New cRecPU(1850, 456, 173, 100))
				Me.table_1000_st.Add(New cRecPU(2000, 456, 173, 120))
				Me.table_1000_st.Add(New cRecPU(2300, 640, 173, 144))
				Me.table_1000_st.Add(New cRecPU(2800, 640, 256, 168))
				Me.table_1000_st.Add(New cRecPU(3400, 912, 256, 168))
				Me.table_1000_st.Add(New cRecPU(3500, 1280, 305, 168))
				Me.table_1000_st.Add(New cRecPU(3750, 1280, 305, 192))
				Me.table_1000_st.Add(New cRecPU(4000, 1280, 305, 240))
				Me.table_1000_st.Add(New cRecPU(5000, 1824, 356, 240))
				Me.table_1000_st.Add(New cRecPU(7000, 1824, 356, 260))
				Me.table_1500_st.Clear()
				Me.table_1500_st.Add(New cRecPU(50, 25, 53, 24))
				Me.table_1500_st.Add(New cRecPU(150, 40, 67, 30))
				Me.table_1500_st.Add(New cRecPU(200, 57, 67, 36))
				Me.table_1500_st.Add(New cRecPU(250, 80, 76, 42))
				Me.table_1500_st.Add(New cRecPU(300, 80, 95, 48))
				Me.table_1500_st.Add(New cRecPU(400, 114, 95, 54))
				Me.table_1500_st.Add(New cRecPU(450, 114, 119, 54))
				Me.table_1500_st.Add(New cRecPU(600, 160, 119, 64))
				Me.table_1500_st.Add(New cRecPU(750, 228, 121, 74))
				Me.table_1500_st.Add(New cRecPU(850, 228, 121, 86))
				Me.table_1500_st.Add(New cRecPU(950, 320, 121, 100))
				Me.table_1500_st.Add(New cRecPU(1000, 320, 143, 100))
				Me.table_1500_st.Add(New cRecPU(1100, 320, 143, 100))
				Me.table_1500_st.Add(New cRecPU(1200, 456, 150, 120))
				Me.table_1500_st.Add(New cRecPU(1400, 456, 155, 120))
				Me.table_1500_st.Add(New cRecPU(1600, 640, 165, 144))
				Me.table_1500_st.Add(New cRecPU(1900, 640, 200, 144))
				Me.table_1500_st.Add(New cRecPU(2100, 640, 253, 144))
				Me.table_1500_st.Add(New cRecPU(2500, 912, 253, 168))
				Me.table_1500_st.Add(New cRecPU(2600, 912, 253, 192))
				Me.table_1500_st.Add(New cRecPU(2800, 1280, 253, 192))
				Me.table_1500_st.Add(New cRecPU(3000, 1280, 253, 216))
				Me.table_1500_st.Add(New cRecPU(3400, 1280, 305, 216))
				Me.table_1500_st.Add(New cRecPU(4000, 1824, 356, 216))
				Me.table_1500_st.Add(New cRecPU(4300, 1824, 365, 216))
				Me.table_1500_st.Add(New cRecPU(5000, 1824, 365, 240))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(50, 25, 67, 30))
				Me.table_2000_st.Add(New cRecPU(100, 40, 67, 30))
				Me.table_2000_st.Add(New cRecPU(150, 57, 89, 42))
				Me.table_2000_st.Add(New cRecPU(200, 80, 95, 48))
				Me.table_2000_st.Add(New cRecPU(275, 114, 95, 48))
				Me.table_2000_st.Add(New cRecPU(300, 114, 119, 48))
				Me.table_2000_st.Add(New cRecPU(400, 160, 119, 54))
				Me.table_2000_st.Add(New cRecPU(500, 228, 143, 74))
				Me.table_2000_st.Add(New cRecPU(700, 228, 173, 74))
				Me.table_2000_st.Add(New cRecPU(1000, 320, 213, 86))
				Me.table_2000_st.Add(New cRecPU(1250, 456, 256, 100))
				Me.table_2000_st.Add(New cRecPU(1500, 640, 305, 120))
				Me.table_2000_st.Add(New cRecPU(1700, 912, 305, 144))
				Me.table_2000_st.Add(New cRecPU(2000, 912, 305, 168))
				Me.table_2000_st.Add(New cRecPU(2800, 1280, 365, 168))
				Me.table_2000_st.Add(New cRecPU(3300, 1824, 365, 192))
				Me.table_2000_st.Add(New cRecPU(3800, 1824, 365, 216))
				Me.table_2000_st.Add(New cRecPU(4200, 2560, 365, 240))
				Me.table_2500_st.Clear()
				Me.table_2500_st.Add(New cRecPU(50, 40, 89, 36))
				Me.table_2500_st.Add(New cRecPU(100, 57, 89, 36))
				Me.table_2500_st.Add(New cRecPU(150, 80, 109, 42))
				Me.table_2500_st.Add(New cRecPU(200, 114, 133, 48))
				Me.table_2500_st.Add(New cRecPU(250, 160, 143, 54))
				Me.table_2500_st.Add(New cRecPU(300, 160, 143, 64))
				Me.table_2500_st.Add(New cRecPU(450, 228, 173, 64))
				Me.table_2500_st.Add(New cRecPU(550, 228, 200, 64))
				Me.table_2500_st.Add(New cRecPU(650, 320, 200, 74))
				Me.table_2500_st.Add(New cRecPU(700, 320, 213, 86))
				Me.table_2500_st.Add(New cRecPU(800, 456, 213, 86))
				Me.table_2500_st.Add(New cRecPU(900, 456, 256, 100))
				Me.table_2500_st.Add(New cRecPU(1000, 640, 256, 100))
				Me.table_2500_st.Add(New cRecPU(1300, 640, 305, 120))
				Me.table_2500_st.Add(New cRecPU(1700, 912, 305, 144))
				Me.table_2500_st.Add(New cRecPU(1750, 912, 356, 144))
				Me.table_2500_st.Add(New cRecPU(2000, 1280, 305, 168))
				Me.table_2500_st.Add(New cRecPU(2500, 1824, 365, 192))
				Me.table_2500_st.Add(New cRecPU(2750, 1824, 365, 216))
				Me.table_2500_st.Add(New cRecPU(3150, 2560, 427, 216))
				Me.table_2500_st.Add(New cRecPU(3750, 2560, 427, 240))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(50, 57, 89, 42))
				Me.table_3000_st.Add(New cRecPU(100, 80, 95, 48))
				Me.table_3000_st.Add(New cRecPU(150, 114, 133, 48))
				Me.table_3000_st.Add(New cRecPU(200, 160, 143, 64))
				Me.table_3000_st.Add(New cRecPU(250, 228, 133, 74))
				Me.table_3000_st.Add(New cRecPU(300, 228, 173, 74))
				Me.table_3000_st.Add(New cRecPU(500, 320, 212, 86))
				Me.table_3000_st.Add(New cRecPU(800, 456, 256, 100))
				Me.table_3000_st.Add(New cRecPU(1000, 640, 305, 120))
				Me.table_3000_st.Add(New cRecPU(1300, 912, 305, 144))
				Me.table_3000_st.Add(New cRecPU(1500, 1280, 365, 168))
				Me.table_3000_st.Add(New cRecPU(1700, 1280, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2000, 1824, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2200, 1824, 365, 216))
				Me.table_3000_st.Add(New cRecPU(2500, 1824, 365, 240))
				Me.table_3000_st.Add(New cRecPU(2900, 2560, 470, 240))
				Me.table_3500_st.Clear()
				Me.table_3500_st.Add(New cRecPU(50, 80, 95, 48))
				Me.table_3500_st.Add(New cRecPU(100, 114, 133, 48))
				Me.table_3500_st.Add(New cRecPU(150, 160, 133, 54))
				Me.table_3500_st.Add(New cRecPU(200, 160, 143, 64))
				Me.table_3500_st.Add(New cRecPU(250, 228, 173, 74))
				Me.table_3500_st.Add(New cRecPU(350, 320, 246, 74))
				Me.table_3500_st.Add(New cRecPU(450, 456, 256, 86))
				Me.table_3500_st.Add(New cRecPU(600, 456, 256, 100))
				Me.table_3500_st.Add(New cRecPU(800, 640, 305, 120))
				Me.table_3500_st.Add(New cRecPU(1000, 912, 305, 144))
				Me.table_3500_st.Add(New cRecPU(1200, 912, 305, 168))
				Me.table_3500_st.Add(New cRecPU(1400, 1280, 365, 192))
				Me.table_3500_st.Add(New cRecPU(1800, 1824, 365, 192))
				Me.table_3500_st.Add(New cRecPU(2000, 1824, 365, 216))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(50, 80, 109, 48))
				Me.table_4000_st.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4000_st.Add(New cRecPU(150, 160, 169, 54))
				Me.table_4000_st.Add(New cRecPU(200, 228, 200, 64))
				Me.table_4000_st.Add(New cRecPU(350, 320, 246, 74))
				Me.table_4000_st.Add(New cRecPU(400, 456, 298, 86))
				Me.table_4000_st.Add(New cRecPU(525, 640, 305, 100))
				Me.table_4000_st.Add(New cRecPU(575, 640, 305, 120))
				Me.table_4000_st.Add(New cRecPU(650, 912, 305, 144))
				Me.table_4000_st.Add(New cRecPU(700, 912, 305, 168))
				Me.table_4000_st.Add(New cRecPU(750, 912, 305, 192))
				Me.table_4000_st.Add(New cRecPU(900, 1280, 305, 192))
				Me.table_4000_st.Add(New cRecPU(1100, 1280, 365, 192))
				Me.table_4000_st.Add(New cRecPU(1300, 1824, 365, 192))
				Me.table_4000_st.Add(New cRecPU(1400, 1824, 365, 216))
				Me.table_4000_st.Add(New cRecPU(1700, 1824, 365, 240))
				Me.table_4500_st.Clear()
				Me.table_4500_st.Add(New cRecPU(75, 114, 133, 48))
				Me.table_4500_st.Add(New cRecPU(125, 160, 169, 54))
				Me.table_4500_st.Add(New cRecPU(200, 228, 200, 64))
				Me.table_4500_st.Add(New cRecPU(250, 320, 246, 74))
				Me.table_4500_st.Add(New cRecPU(350, 456, 298, 86))
				Me.table_4500_st.Add(New cRecPU(375, 456, 298, 100))
				Me.table_4500_st.Add(New cRecPU(475, 640, 305, 120))
				Me.table_4500_st.Add(New cRecPU(500, 640, 305, 144))
				Me.table_4500_st.Add(New cRecPU(650, 912, 305, 144))
				Me.table_4500_st.Add(New cRecPU(700, 912, 305, 168))
				Me.table_4500_st.Add(New cRecPU(800, 1280, 305, 192))
				Me.table_4500_st.Add(New cRecPU(950, 1280, 356, 192))
				Me.table_4500_st.Add(New cRecPU(1100, 1824, 356, 216))
				Me.table_4500_st.Add(New cRecPU(1200, 1824, 365, 216))
				Me.table_4500_st.Add(New cRecPU(1350, 1824, 365, 240))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(50, 114, 133, 48))
				Me.table_5000_st.Add(New cRecPU(100, 160, 169, 54))
				Me.table_5000_st.Add(New cRecPU(150, 228, 200, 64))
				Me.table_5000_st.Add(New cRecPU(200, 320, 246, 74))
				Me.table_5000_st.Add(New cRecPU(300, 456, 298, 86))
				Me.table_5000_st.Add(New cRecPU(400, 640, 305, 100))
				Me.table_5000_st.Add(New cRecPU(425, 640, 305, 120))
				Me.table_5000_st.Add(New cRecPU(430, 640, 305, 144))
				Me.table_5000_st.Add(New cRecPU(600, 912, 356, 144))
				Me.table_5000_st.Add(New cRecPU(700, 1280, 356, 168))
				Me.table_5000_st.Add(New cRecPU(900, 1280, 356, 192))
				Me.table_5000_st.Add(New cRecPU(1100, 1824, 365, 216))
				Me.table_5000_st.Add(New cRecPU(1250, 2560, 427, 240))
				Me.table_5500_st.Clear()
				Me.table_5500_st.Add(New cRecPU(50, 114, 169, 54))
				Me.table_5500_st.Add(New cRecPU(75, 160, 169, 64))
				Me.table_5500_st.Add(New cRecPU(150, 228, 200, 64))
				Me.table_5500_st.Add(New cRecPU(180, 320, 246, 74))
				Me.table_5500_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_5500_st.Add(New cRecPU(300, 456, 298, 100))
				Me.table_5500_st.Add(New cRecPU(500, 640, 365, 100))
				Me.table_5500_st.Add(New cRecPU(550, 912, 365, 120))
				Me.table_5500_st.Add(New cRecPU(700, 1280, 365, 144))
				Me.table_5500_st.Add(New cRecPU(750, 1280, 365, 168))
				Me.table_5500_st.Add(New cRecPU(950, 1824, 365, 192))
				Me.table_5500_st.Add(New cRecPU(1000, 1824, 365, 216))
				Me.table_5500_st.Add(New cRecPU(1200, 2560, 427, 240))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(50, 114, 169, 44))
				Me.table_6000_st.Add(New cRecPU(75, 160, 200, 54))
				Me.table_6000_st.Add(New cRecPU(100, 228, 200, 64))
				Me.table_6000_st.Add(New cRecPU(150, 320, 246, 74))
				Me.table_6000_st.Add(New cRecPU(200, 456, 256, 100))
				Me.table_6000_st.Add(New cRecPU(250, 456, 305, 100))
				Me.table_6000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_6000_st.Add(New cRecPU(450, 912, 305, 144))
				Me.table_6000_st.Add(New cRecPU(475, 912, 305, 168))
				Me.table_6000_st.Add(New cRecPU(550, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(600, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(800, 1824, 365, 192))
				Me.table_6000_st.Add(New cRecPU(900, 1824, 365, 216))
				Me.table_6000_st.Add(New cRecPU(1000, 1824, 365, 240))
				Me.table_6500_st.Clear()
				Me.table_6500_st.Add(New cRecPU(75, 160, 200, 54))
				Me.table_6500_st.Add(New cRecPU(100, 228, 246, 64))
				Me.table_6500_st.Add(New cRecPU(200, 320, 246, 74))
				Me.table_6500_st.Add(New cRecPU(250, 456, 246, 86))
				Me.table_6500_st.Add(New cRecPU(350, 456, 298, 86))
				Me.table_6500_st.Add(New cRecPU(400, 640, 298, 100))
				Me.table_6500_st.Add(New cRecPU(500, 912, 365, 120))
				Me.table_6500_st.Add(New cRecPU(550, 1280, 365, 168))
				Me.table_6500_st.Add(New cRecPU(700, 1824, 365, 192))
				Me.table_6500_st.Add(New cRecPU(800, 1824, 365, 216))
				Me.table_6500_st.Add(New cRecPU(850, 1824, 427, 240))
				Me.table_6500_st.Add(New cRecPU(950, 2560, 427, 260))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(100, 228, 200, 64))
				Me.table_7000_st.Add(New cRecPU(150, 320, 246, 74))
				Me.table_7000_st.Add(New cRecPU(200, 456, 298, 86))
				Me.table_7000_st.Add(New cRecPU(250, 456, 298, 100))
				Me.table_7000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_7000_st.Add(New cRecPU(400, 912, 356, 144))
				Me.table_7000_st.Add(New cRecPU(450, 1280, 365, 168))
				Me.table_7000_st.Add(New cRecPU(550, 1824, 365, 192))
				Me.table_7000_st.Add(New cRecPU(600, 1824, 427, 192))
				Me.table_7000_st.Add(New cRecPU(700, 1824, 427, 216))
				Me.table_7000_st.Add(New cRecPU(800, 2560, 427, 240))
				Me.table_7500_st.Clear()
				Me.table_7500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_7500_st.Add(New cRecPU(175, 320, 298, 86))
				Me.table_7500_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_7500_st.Add(New cRecPU(260, 456, 298, 100))
				Me.table_7500_st.Add(New cRecPU(275, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(325, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(350, 912, 365, 144))
				Me.table_7500_st.Add(New cRecPU(400, 1280, 365, 168))
				Me.table_7500_st.Add(New cRecPU(425, 1280, 365, 192))
				Me.table_7500_st.Add(New cRecPU(500, 1824, 365, 192))
				Me.table_7500_st.Add(New cRecPU(550, 1824, 365, 216))
				Me.table_7500_st.Add(New cRecPU(625, 1824, 427, 216))
				Me.table_7500_st.Add(New cRecPU(650, 1824, 427, 240))
				Me.table_7500_st.Add(New cRecPU(700, 2560, 427, 260))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_8000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8000_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_8000_st.Add(New cRecPU(300, 640, 365, 120))
				Me.table_8000_st.Add(New cRecPU(325, 912, 365, 144))
				Me.table_8000_st.Add(New cRecPU(350, 1280, 365, 168))
				Me.table_8000_st.Add(New cRecPU(400, 1824, 365, 192))
				Me.table_8000_st.Add(New cRecPU(550, 1824, 427, 192))
				Me.table_8000_st.Add(New cRecPU(600, 2560, 427, 240))
				Me.table_8000_st.Add(New cRecPU(650, 2560, 427, 260))
				Me.table_8500_st.Clear()
				Me.table_8500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8500_st.Add(New cRecPU(150, 320, 298, 86))
				Me.table_8500_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8500_st.Add(New cRecPU(250, 640, 365, 120))
				Me.table_8500_st.Add(New cRecPU(350, 912, 365, 120))
				Me.table_8500_st.Add(New cRecPU(375, 912, 427, 144))
				Me.table_8500_st.Add(New cRecPU(400, 1280, 427, 168))
				Me.table_8500_st.Add(New cRecPU(500, 1824, 427, 192))
				Me.table_8500_st.Add(New cRecPU(550, 1824, 427, 216))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_9000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_9000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9000_st.Add(New cRecPU(250, 640, 365, 120))
				Me.table_9000_st.Add(New cRecPU(400, 912, 427, 120))
				Me.table_9000_st.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_9000_st.Add(New cRecPU(525, 1824, 427, 216))
				Me.table_9500_st.Clear()
				Me.table_9500_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_9500_st.Add(New cRecPU(100, 320, 298, 100))
				Me.table_9500_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9500_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_9500_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_9500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_9500_st.Add(New cRecPU(400, 1824, 427, 216))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_10000_st.Add(New cRecPU(75, 320, 298, 100))
				Me.table_10000_st.Add(New cRecPU(150, 456, 298, 100))
				Me.table_10000_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_10000_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10000_st.Add(New cRecPU(325, 1280, 427, 192))
				Me.table_10000_st.Add(New cRecPU(375, 1824, 427, 216))
				Me.table_10000_st.Add(New cRecPU(400, 2560, 427, 240))
				Me.table_10500_st.Clear()
				Me.table_10500_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_10500_st.Add(New cRecPU(75, 228, 305, 74))
				Me.table_10500_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_10500_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_10500_st.Add(New cRecPU(225, 640, 427, 120))
				Me.table_10500_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_10500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_10500_st.Add(New cRecPU(375, 1824, 427, 216))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(50, 320, 298, 86))
				Me.table_11000_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_11000_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_11000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_11000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11000_st.Add(New cRecPU(275, 1280, 427, 192))
				Me.table_11000_st.Add(New cRecPU(325, 1824, 427, 192))
				Me.table_11000_st.Add(New cRecPU(375, 1824, 470, 240))
				Me.table_11500_st.Clear()
				Me.table_11500_st.Add(New cRecPU(75, 320, 305, 100))
				Me.table_11500_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_11500_st.Add(New cRecPU(175, 640, 427, 120))
				Me.table_11500_st.Add(New cRecPU(275, 912, 427, 120))
				Me.table_11500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_11500_st.Add(New cRecPU(350, 1824, 427, 192))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(75, 320, 305, 100))
				Me.table_12000_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_12000_st.Add(New cRecPU(175, 640, 427, 100))
				Me.table_12000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_12000_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_12000_st.Add(New cRecPU(325, 1824, 427, 192))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_13000_st.Add(New cRecPU(75, 456, 365, 100))
				Me.table_13000_st.Add(New cRecPU(100, 456, 427, 100))
				Me.table_13000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13000_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_13000_st.Add(New cRecPU(250, 1280, 470, 168))
				Me.table_13000_st.Add(New cRecPU(300, 1824, 470, 216))
				Me.table_13500_st.Clear()
				Me.table_13500_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_13500_st.Add(New cRecPU(75, 456, 365, 100))
				Me.table_13500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13500_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_13500_st.Add(New cRecPU(250, 1280, 427, 168))
				Me.table_13500_st.Add(New cRecPU(275, 1824, 470, 216))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_14000_st.Add(New cRecPU(100, 456, 365, 100))
				Me.table_14000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14000_st.Add(New cRecPU(175, 912, 427, 144))
				Me.table_14000_st.Add(New cRecPU(200, 1280, 427, 168))
				Me.table_14000_st.Add(New cRecPU(225, 1824, 427, 192))
				Me.table_14000_st.Add(New cRecPU(250, 1824, 470, 216))
				Me.table_14500_st.Clear()
				Me.table_14500_st.Add(New cRecPU(50, 456, 365, 100))
				Me.table_14500_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_14500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14500_st.Add(New cRecPU(175, 912, 427, 120))
				Me.table_14500_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_14500_st.Add(New cRecPU(225, 1824, 427, 192))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_15000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_15000_st.Add(New cRecPU(125, 640, 427, 126))
				Me.table_15000_st.Add(New cRecPU(175, 912, 427, 120))
				Me.table_15000_st.Add(New cRecPU(200, 1824, 427, 216))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_16000_st.Add(New cRecPU(75, 456, 427, 120))
				Me.table_16000_st.Add(New cRecPU(125, 640, 470, 120))
				Me.table_16000_st.Add(New cRecPU(150, 640, 470, 126))
				Me.table_17000_st.Clear()
				Me.table_17000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_17000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_17000_st.Add(New cRecPU(125, 912, 427, 120))
				Me.table_18000_st.Clear()
				Me.table_18000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_18000_st.Add(New cRecPU(75, 640, 470, 100))
				Me.table_18000_st.Add(New cRecPU(100, 640, 470, 126))
				Me.table_18000_st.Add(New cRecPU(125, 912, 470, 144))
				Me.table_19000_st.Clear()
				Me.table_19000_st.Add(New cRecPU(50, 640, 470, 120))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUStal_Conv()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(200, 25, 53, 24))
				Me.table_1000_st.Add(New cRecPU(300, 40, 67, 30))
				Me.table_1000_st.Add(New cRecPU(350, 57, 67, 54))
				Me.table_1000_st.Add(New cRecPU(400, 80, 67, 54))
				Me.table_1000_st.Add(New cRecPU(550, 80, 76, 48))
				Me.table_1000_st.Add(New cRecPU(600, 80, 95, 48))
				Me.table_1000_st.Add(New cRecPU(700, 114, 95, 64))
				Me.table_1000_st.Add(New cRecPU(800, 119, 95, 64))
				Me.table_1000_st.Add(New cRecPU(900, 160, 95, 64))
				Me.table_1000_st.Add(New cRecPU(1100, 160, 95, 74))
				Me.table_1000_st.Add(New cRecPU(1400, 228, 121, 74))
				Me.table_1000_st.Add(New cRecPU(1600, 228, 121, 86))
				Me.table_1000_st.Add(New cRecPU(1800, 320, 143, 100))
				Me.table_1000_st.Add(New cRecPU(1900, 320, 143, 120))
				Me.table_1000_st.Add(New cRecPU(2000, 456, 143, 120))
				Me.table_1000_st.Add(New cRecPU(2200, 456, 143, 144))
				Me.table_1000_st.Add(New cRecPU(2300, 456, 150, 144))
				Me.table_1000_st.Add(New cRecPU(2600, 640, 173, 168))
				Me.table_1000_st.Add(New cRecPU(3100, 640, 200, 168))
				Me.table_1000_st.Add(New cRecPU(3200, 912, 200, 168))
				Me.table_1000_st.Add(New cRecPU(3400, 912, 212, 168))
				Me.table_1000_st.Add(New cRecPU(4000, 912, 256, 168))
				Me.table_1000_st.Add(New cRecPU(4200, 912, 256, 192))
				Me.table_1000_st.Add(New cRecPU(4500, 1280, 305, 240))
				Me.table_1000_st.Add(New cRecPU(5200, 1280, 305, 260))
				Me.table_1500_st.Clear()
				Me.table_1500_st.Add(New cRecPU(50, 25, 53, 24))
				Me.table_1500_st.Add(New cRecPU(150, 40, 67, 30))
				Me.table_1500_st.Add(New cRecPU(200, 57, 67, 36))
				Me.table_1500_st.Add(New cRecPU(250, 80, 95, 42))
				Me.table_1500_st.Add(New cRecPU(300, 80, 95, 48))
				Me.table_1500_st.Add(New cRecPU(400, 114, 95, 54))
				Me.table_1500_st.Add(New cRecPU(450, 114, 119, 54))
				Me.table_1500_st.Add(New cRecPU(600, 160, 119, 64))
				Me.table_1500_st.Add(New cRecPU(750, 228, 121, 74))
				Me.table_1500_st.Add(New cRecPU(800, 228, 121, 86))
				Me.table_1500_st.Add(New cRecPU(850, 320, 121, 86))
				Me.table_1500_st.Add(New cRecPU(900, 320, 121, 100))
				Me.table_1500_st.Add(New cRecPU(1100, 320, 143, 100))
				Me.table_1500_st.Add(New cRecPU(1200, 456, 150, 120))
				Me.table_1500_st.Add(New cRecPU(1400, 456, 165, 120))
				Me.table_1500_st.Add(New cRecPU(1900, 640, 200, 144))
				Me.table_1500_st.Add(New cRecPU(2100, 640, 253, 144))
				Me.table_1500_st.Add(New cRecPU(2500, 912, 253, 168))
				Me.table_1500_st.Add(New cRecPU(2600, 912, 253, 192))
				Me.table_1500_st.Add(New cRecPU(2800, 1280, 253, 192))
				Me.table_1500_st.Add(New cRecPU(3000, 1280, 253, 216))
				Me.table_1500_st.Add(New cRecPU(3400, 1280, 305, 216))
				Me.table_1500_st.Add(New cRecPU(4000, 1824, 356, 216))
				Me.table_1500_st.Add(New cRecPU(4300, 1824, 365, 216))
				Me.table_1500_st.Add(New cRecPU(4600, 1824, 305, 240))
				Me.table_1500_st.Add(New cRecPU(4800, 1824, 365, 240))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(50, 25, 67, 30))
				Me.table_2000_st.Add(New cRecPU(100, 57, 89, 36))
				Me.table_2000_st.Add(New cRecPU(150, 80, 89, 42))
				Me.table_2000_st.Add(New cRecPU(200, 80, 95, 48))
				Me.table_2000_st.Add(New cRecPU(275, 114, 95, 48))
				Me.table_2000_st.Add(New cRecPU(300, 114, 119, 48))
				Me.table_2000_st.Add(New cRecPU(350, 114, 119, 54))
				Me.table_2000_st.Add(New cRecPU(400, 160, 119, 54))
				Me.table_2000_st.Add(New cRecPU(450, 160, 143, 64))
				Me.table_2000_st.Add(New cRecPU(500, 228, 143, 74))
				Me.table_2000_st.Add(New cRecPU(700, 320, 173, 74))
				Me.table_2000_st.Add(New cRecPU(1000, 320, 213, 86))
				Me.table_2000_st.Add(New cRecPU(1250, 456, 256, 100))
				Me.table_2000_st.Add(New cRecPU(1500, 640, 305, 120))
				Me.table_2000_st.Add(New cRecPU(1700, 912, 305, 144))
				Me.table_2000_st.Add(New cRecPU(2000, 912, 305, 168))
				Me.table_2000_st.Add(New cRecPU(2800, 1280, 365, 168))
				Me.table_2000_st.Add(New cRecPU(3300, 1824, 365, 192))
				Me.table_2000_st.Add(New cRecPU(3800, 1824, 365, 216))
				Me.table_2000_st.Add(New cRecPU(4200, 2560, 365, 240))
				Me.table_2500_st.Clear()
				Me.table_2500_st.Add(New cRecPU(50, 40, 89, 36))
				Me.table_2500_st.Add(New cRecPU(100, 57, 89, 36))
				Me.table_2500_st.Add(New cRecPU(150, 80, 109, 42))
				Me.table_2500_st.Add(New cRecPU(200, 114, 133, 48))
				Me.table_2500_st.Add(New cRecPU(250, 160, 143, 54))
				Me.table_2500_st.Add(New cRecPU(300, 160, 143, 64))
				Me.table_2500_st.Add(New cRecPU(450, 228, 173, 64))
				Me.table_2500_st.Add(New cRecPU(550, 228, 200, 64))
				Me.table_2500_st.Add(New cRecPU(650, 320, 200, 74))
				Me.table_2500_st.Add(New cRecPU(700, 320, 213, 86))
				Me.table_2500_st.Add(New cRecPU(800, 456, 213, 86))
				Me.table_2500_st.Add(New cRecPU(900, 456, 256, 100))
				Me.table_2500_st.Add(New cRecPU(1000, 640, 256, 100))
				Me.table_2500_st.Add(New cRecPU(1300, 640, 305, 120))
				Me.table_2500_st.Add(New cRecPU(1700, 912, 305, 144))
				Me.table_2500_st.Add(New cRecPU(1750, 912, 356, 144))
				Me.table_2500_st.Add(New cRecPU(2000, 1280, 365, 168))
				Me.table_2500_st.Add(New cRecPU(2500, 1824, 365, 192))
				Me.table_2500_st.Add(New cRecPU(2950, 1824, 365, 216))
				Me.table_2500_st.Add(New cRecPU(3150, 2560, 427, 216))
				Me.table_2500_st.Add(New cRecPU(3750, 2560, 427, 240))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(50, 57, 89, 42))
				Me.table_3000_st.Add(New cRecPU(100, 80, 95, 48))
				Me.table_3000_st.Add(New cRecPU(150, 114, 133, 48))
				Me.table_3000_st.Add(New cRecPU(200, 160, 143, 64))
				Me.table_3000_st.Add(New cRecPU(250, 228, 133, 74))
				Me.table_3000_st.Add(New cRecPU(300, 228, 173, 74))
				Me.table_3000_st.Add(New cRecPU(500, 320, 212, 86))
				Me.table_3000_st.Add(New cRecPU(800, 456, 256, 100))
				Me.table_3000_st.Add(New cRecPU(850, 640, 256, 144))
				Me.table_3000_st.Add(New cRecPU(1000, 640, 305, 120))
				Me.table_3000_st.Add(New cRecPU(1300, 912, 305, 144))
				Me.table_3000_st.Add(New cRecPU(1500, 1280, 365, 168))
				Me.table_3000_st.Add(New cRecPU(1700, 1280, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2000, 1824, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2200, 1824, 365, 216))
				Me.table_3000_st.Add(New cRecPU(2500, 1824, 365, 240))
				Me.table_3000_st.Add(New cRecPU(2900, 2560, 470, 240))
				Me.table_3500_st.Clear()
				Me.table_3500_st.Add(New cRecPU(50, 80, 95, 48))
				Me.table_3500_st.Add(New cRecPU(100, 114, 133, 48))
				Me.table_3500_st.Add(New cRecPU(150, 160, 143, 64))
				Me.table_3500_st.Add(New cRecPU(200, 228, 143, 64))
				Me.table_3500_st.Add(New cRecPU(250, 228, 173, 74))
				Me.table_3500_st.Add(New cRecPU(350, 320, 246, 74))
				Me.table_3500_st.Add(New cRecPU(450, 456, 256, 86))
				Me.table_3500_st.Add(New cRecPU(600, 456, 256, 100))
				Me.table_3500_st.Add(New cRecPU(800, 640, 305, 120))
				Me.table_3500_st.Add(New cRecPU(1000, 912, 305, 144))
				Me.table_3500_st.Add(New cRecPU(1200, 912, 305, 168))
				Me.table_3500_st.Add(New cRecPU(1400, 1280, 365, 192))
				Me.table_3500_st.Add(New cRecPU(1800, 1824, 365, 192))
				Me.table_3500_st.Add(New cRecPU(2000, 1824, 365, 216))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(50, 80, 109, 48))
				Me.table_4000_st.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4000_st.Add(New cRecPU(150, 160, 169, 54))
				Me.table_4000_st.Add(New cRecPU(200, 228, 200, 64))
				Me.table_4000_st.Add(New cRecPU(300, 320, 246, 74))
				Me.table_4000_st.Add(New cRecPU(350, 456, 256, 86))
				Me.table_4000_st.Add(New cRecPU(400, 456, 298, 86))
				Me.table_4000_st.Add(New cRecPU(500, 456, 256, 100))
				Me.table_4000_st.Add(New cRecPU(525, 640, 305, 100))
				Me.table_4000_st.Add(New cRecPU(600, 640, 305, 120))
				Me.table_4000_st.Add(New cRecPU(650, 640, 253, 144))
				Me.table_4000_st.Add(New cRecPU(675, 640, 256, 144))
				Me.table_4000_st.Add(New cRecPU(950, 912, 305, 168))
				Me.table_4000_st.Add(New cRecPU(1100, 1280, 305, 192))
				Me.table_4000_st.Add(New cRecPU(1300, 1824, 365, 192))
				Me.table_4000_st.Add(New cRecPU(1400, 1824, 365, 216))
				Me.table_4000_st.Add(New cRecPU(1700, 1824, 365, 240))
				Me.table_4500_st.Clear()
				Me.table_4500_st.Add(New cRecPU(75, 114, 133, 48))
				Me.table_4500_st.Add(New cRecPU(125, 160, 169, 54))
				Me.table_4500_st.Add(New cRecPU(200, 228, 200, 64))
				Me.table_4500_st.Add(New cRecPU(250, 320, 246, 74))
				Me.table_4500_st.Add(New cRecPU(350, 456, 298, 86))
				Me.table_4500_st.Add(New cRecPU(375, 456, 256, 100))
				Me.table_4500_st.Add(New cRecPU(475, 640, 256, 120))
				Me.table_4500_st.Add(New cRecPU(550, 912, 256, 144))
				Me.table_4500_st.Add(New cRecPU(650, 912, 305, 144))
				Me.table_4500_st.Add(New cRecPU(800, 1280, 305, 192))
				Me.table_4500_st.Add(New cRecPU(1100, 1280, 356, 192))
				Me.table_4500_st.Add(New cRecPU(1350, 1824, 365, 216))
				Me.table_4500_st.Add(New cRecPU(1400, 1824, 365, 216))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(50, 114, 133, 48))
				Me.table_5000_st.Add(New cRecPU(100, 160, 169, 54))
				Me.table_5000_st.Add(New cRecPU(150, 228, 200, 64))
				Me.table_5000_st.Add(New cRecPU(200, 320, 246, 74))
				Me.table_5000_st.Add(New cRecPU(300, 456, 246, 86))
				Me.table_5000_st.Add(New cRecPU(325, 640, 246, 100))
				Me.table_5000_st.Add(New cRecPU(350, 640, 305, 120))
				Me.table_5000_st.Add(New cRecPU(450, 640, 305, 120))
				Me.table_5000_st.Add(New cRecPU(600, 912, 305, 144))
				Me.table_5000_st.Add(New cRecPU(750, 1280, 356, 168))
				Me.table_5000_st.Add(New cRecPU(900, 1824, 365, 192))
				Me.table_5000_st.Add(New cRecPU(950, 1824, 365, 216))
				Me.table_5000_st.Add(New cRecPU(1000, 1824, 365, 240))
				Me.table_5000_st.Add(New cRecPU(1250, 2560, 470, 240))
				Me.table_5500_st.Clear()
				Me.table_5500_st.Add(New cRecPU(50, 160, 169, 54))
				Me.table_5500_st.Add(New cRecPU(75, 160, 169, 64))
				Me.table_5500_st.Add(New cRecPU(150, 228, 200, 64))
				Me.table_5500_st.Add(New cRecPU(180, 320, 246, 74))
				Me.table_5500_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_5500_st.Add(New cRecPU(300, 456, 298, 100))
				Me.table_5500_st.Add(New cRecPU(500, 640, 365, 100))
				Me.table_5500_st.Add(New cRecPU(550, 912, 365, 120))
				Me.table_5500_st.Add(New cRecPU(650, 1280, 365, 144))
				Me.table_5500_st.Add(New cRecPU(700, 1280, 365, 168))
				Me.table_5500_st.Add(New cRecPU(950, 1824, 365, 192))
				Me.table_5500_st.Add(New cRecPU(1000, 1824, 365, 216))
				Me.table_5500_st.Add(New cRecPU(1200, 2560, 427, 240))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(50, 114, 169, 44))
				Me.table_6000_st.Add(New cRecPU(75, 160, 200, 54))
				Me.table_6000_st.Add(New cRecPU(85, 228, 200, 64))
				Me.table_6000_st.Add(New cRecPU(175, 320, 246, 74))
				Me.table_6000_st.Add(New cRecPU(200, 456, 256, 100))
				Me.table_6000_st.Add(New cRecPU(250, 456, 305, 100))
				Me.table_6000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_6000_st.Add(New cRecPU(450, 912, 305, 144))
				Me.table_6000_st.Add(New cRecPU(475, 1280, 305, 192))
				Me.table_6000_st.Add(New cRecPU(550, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(600, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(750, 1824, 365, 192))
				Me.table_6000_st.Add(New cRecPU(900, 1824, 365, 216))
				Me.table_6000_st.Add(New cRecPU(1000, 1824, 365, 240))
				Me.table_6500_st.Clear()
				Me.table_6500_st.Add(New cRecPU(75, 160, 200, 54))
				Me.table_6500_st.Add(New cRecPU(100, 228, 246, 64))
				Me.table_6500_st.Add(New cRecPU(200, 320, 246, 74))
				Me.table_6500_st.Add(New cRecPU(250, 456, 246, 86))
				Me.table_6500_st.Add(New cRecPU(350, 456, 298, 86))
				Me.table_6500_st.Add(New cRecPU(400, 640, 298, 100))
				Me.table_6500_st.Add(New cRecPU(500, 912, 427, 120))
				Me.table_6500_st.Add(New cRecPU(550, 1280, 365, 168))
				Me.table_6500_st.Add(New cRecPU(650, 1824, 365, 192))
				Me.table_6500_st.Add(New cRecPU(750, 1824, 365, 216))
				Me.table_6500_st.Add(New cRecPU(850, 1824, 427, 240))
				Me.table_6500_st.Add(New cRecPU(950, 2560, 427, 260))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(100, 228, 200, 64))
				Me.table_7000_st.Add(New cRecPU(150, 320, 298, 74))
				Me.table_7000_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_7000_st.Add(New cRecPU(275, 640, 298, 100))
				Me.table_7000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_7000_st.Add(New cRecPU(400, 912, 356, 144))
				Me.table_7000_st.Add(New cRecPU(450, 1280, 365, 168))
				Me.table_7000_st.Add(New cRecPU(550, 1824, 365, 192))
				Me.table_7000_st.Add(New cRecPU(600, 1824, 427, 192))
				Me.table_7000_st.Add(New cRecPU(700, 1824, 427, 216))
				Me.table_7000_st.Add(New cRecPU(800, 2560, 427, 240))
				Me.table_7500_st.Clear()
				Me.table_7500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_7500_st.Add(New cRecPU(175, 320, 298, 86))
				Me.table_7500_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_7500_st.Add(New cRecPU(260, 456, 298, 100))
				Me.table_7500_st.Add(New cRecPU(275, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(325, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(350, 912, 365, 144))
				Me.table_7500_st.Add(New cRecPU(400, 1280, 365, 168))
				Me.table_7500_st.Add(New cRecPU(425, 1280, 365, 192))
				Me.table_7500_st.Add(New cRecPU(500, 1824, 427, 192))
				Me.table_7500_st.Add(New cRecPU(625, 1824, 427, 216))
				Me.table_7500_st.Add(New cRecPU(650, 1824, 427, 240))
				Me.table_7500_st.Add(New cRecPU(700, 2560, 427, 260))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_8000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8000_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_8000_st.Add(New cRecPU(300, 640, 365, 120))
				Me.table_8000_st.Add(New cRecPU(325, 912, 365, 144))
				Me.table_8000_st.Add(New cRecPU(350, 1280, 365, 168))
				Me.table_8000_st.Add(New cRecPU(400, 1824, 365, 192))
				Me.table_8000_st.Add(New cRecPU(550, 1824, 427, 192))
				Me.table_8000_st.Add(New cRecPU(600, 2560, 427, 240))
				Me.table_8000_st.Add(New cRecPU(650, 2560, 427, 260))
				Me.table_8500_st.Clear()
				Me.table_8500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8500_st.Add(New cRecPU(150, 320, 298, 86))
				Me.table_8500_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8500_st.Add(New cRecPU(250, 640, 365, 120))
				Me.table_8500_st.Add(New cRecPU(350, 912, 365, 120))
				Me.table_8500_st.Add(New cRecPU(375, 912, 427, 144))
				Me.table_8500_st.Add(New cRecPU(400, 1280, 427, 168))
				Me.table_8500_st.Add(New cRecPU(500, 1824, 427, 192))
				Me.table_8500_st.Add(New cRecPU(550, 1824, 427, 216))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_9000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_9000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9000_st.Add(New cRecPU(250, 640, 365, 120))
				Me.table_9000_st.Add(New cRecPU(400, 912, 427, 120))
				Me.table_9000_st.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_9000_st.Add(New cRecPU(525, 1824, 427, 216))
				Me.table_9500_st.Clear()
				Me.table_9500_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_9500_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9500_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_9500_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_9500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_9500_st.Add(New cRecPU(400, 1824, 427, 216))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_10000_st.Add(New cRecPU(75, 320, 298, 100))
				Me.table_10000_st.Add(New cRecPU(150, 456, 298, 100))
				Me.table_10000_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_10000_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10000_st.Add(New cRecPU(325, 1280, 427, 192))
				Me.table_10000_st.Add(New cRecPU(375, 1824, 427, 216))
				Me.table_10000_st.Add(New cRecPU(400, 2560, 427, 240))
				Me.table_10500_st.Clear()
				Me.table_10500_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_10500_st.Add(New cRecPU(75, 228, 305, 74))
				Me.table_10500_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_10500_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_10500_st.Add(New cRecPU(190, 640, 427, 120))
				Me.table_10500_st.Add(New cRecPU(225, 912, 427, 120))
				Me.table_10500_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_10500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10500_st.Add(New cRecPU(375, 1824, 470, 216))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(50, 320, 298, 86))
				Me.table_11000_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_11000_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_11000_st.Add(New cRecPU(175, 640, 427, 120))
				Me.table_11000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11000_st.Add(New cRecPU(275, 1280, 427, 192))
				Me.table_11000_st.Add(New cRecPU(325, 1824, 427, 192))
				Me.table_11000_st.Add(New cRecPU(375, 1824, 427, 240))
				Me.table_11500_st.Clear()
				Me.table_11500_st.Add(New cRecPU(75, 320, 305, 100))
				Me.table_11500_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_11500_st.Add(New cRecPU(175, 640, 427, 120))
				Me.table_11500_st.Add(New cRecPU(275, 912, 427, 120))
				Me.table_11500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_11500_st.Add(New cRecPU(350, 1824, 427, 192))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(50, 320, 305, 100))
				Me.table_12000_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_12000_st.Add(New cRecPU(175, 640, 427, 100))
				Me.table_12000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_12000_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_12000_st.Add(New cRecPU(325, 1824, 427, 192))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(50, 320, 365, 100))
				Me.table_13000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_13000_st.Add(New cRecPU(100, 456, 427, 100))
				Me.table_13000_st.Add(New cRecPU(150, 640, 470, 120))
				Me.table_13000_st.Add(New cRecPU(175, 912, 427, 144))
				Me.table_13000_st.Add(New cRecPU(200, 1280, 427, 168))
				Me.table_13000_st.Add(New cRecPU(250, 1280, 470, 192))
				Me.table_13000_st.Add(New cRecPU(300, 1824, 470, 216))
				Me.table_13500_st.Clear()
				Me.table_13500_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_13500_st.Add(New cRecPU(75, 456, 365, 100))
				Me.table_13500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13500_st.Add(New cRecPU(175, 912, 427, 144))
				Me.table_13500_st.Add(New cRecPU(250, 1280, 427, 168))
				Me.table_13500_st.Add(New cRecPU(275, 1824, 470, 216))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_14000_st.Add(New cRecPU(100, 456, 365, 100))
				Me.table_14000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14000_st.Add(New cRecPU(175, 912, 427, 144))
				Me.table_14000_st.Add(New cRecPU(200, 1280, 427, 168))
				Me.table_14000_st.Add(New cRecPU(225, 1824, 470, 192))
				Me.table_14000_st.Add(New cRecPU(250, 1824, 470, 216))
				Me.table_14500_st.Clear()
				Me.table_14500_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_14500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14500_st.Add(New cRecPU(175, 912, 456, 120))
				Me.table_14500_st.Add(New cRecPU(200, 912, 456, 144))
				Me.table_14500_st.Add(New cRecPU(225, 1824, 470, 192))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_15000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_15000_st.Add(New cRecPU(125, 640, 427, 126))
				Me.table_15000_st.Add(New cRecPU(175, 912, 427, 120))
				Me.table_15000_st.Add(New cRecPU(200, 1824, 470, 216))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_16000_st.Add(New cRecPU(75, 456, 456, 120))
				Me.table_16000_st.Add(New cRecPU(125, 640, 470, 120))
				Me.table_16000_st.Add(New cRecPU(150, 640, 470, 126))
				Me.table_17000_st.Clear()
				Me.table_17000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_17000_st.Add(New cRecPU(100, 640, 456, 120))
				Me.table_17000_st.Add(New cRecPU(125, 912, 427, 120))
				Me.table_18000_st.Clear()
				Me.table_18000_st.Add(New cRecPU(50, 456, 456, 100))
				Me.table_18000_st.Add(New cRecPU(75, 640, 470, 100))
				Me.table_18000_st.Add(New cRecPU(100, 640, 470, 126))
				Me.table_19000_st.Clear()
				Me.table_19000_st.Add(New cRecPU(50, 640, 470, 120))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUStal_Conv_Last()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(200, 25, 53, 24))
				Me.table_1000_st.Add(New cRecPU(300, 40, 67, 30))
				Me.table_1000_st.Add(New cRecPU(400, 57, 67, 42))
				Me.table_1000_st.Add(New cRecPU(550, 80, 76, 48))
				Me.table_1000_st.Add(New cRecPU(600, 80, 95, 48))
				Me.table_1000_st.Add(New cRecPU(750, 114, 95, 62))
				Me.table_1000_st.Add(New cRecPU(800, 114, 109, 54))
				Me.table_1000_st.Add(New cRecPU(900, 160, 143, 64))
				Me.table_1000_st.Add(New cRecPU(1000, 160, 143, 74))
				Me.table_1000_st.Add(New cRecPU(1200, 228, 143, 74))
				Me.table_1000_st.Add(New cRecPU(1600, 228, 121, 86))
				Me.table_1000_st.Add(New cRecPU(1700, 320, 143, 100))
				Me.table_1000_st.Add(New cRecPU(1800, 320, 143, 100))
				Me.table_1000_st.Add(New cRecPU(1900, 320, 143, 120))
				Me.table_1000_st.Add(New cRecPU(2000, 456, 143, 120))
				Me.table_1000_st.Add(New cRecPU(2200, 456, 143, 144))
				Me.table_1000_st.Add(New cRecPU(2300, 456, 150, 144))
				Me.table_1000_st.Add(New cRecPU(2600, 640, 173, 168))
				Me.table_1000_st.Add(New cRecPU(3100, 640, 200, 168))
				Me.table_1000_st.Add(New cRecPU(3400, 912, 200, 168))
				Me.table_1000_st.Add(New cRecPU(4000, 912, 256, 168))
				Me.table_1000_st.Add(New cRecPU(4200, 912, 256, 192))
				Me.table_1000_st.Add(New cRecPU(4500, 1280, 305, 240))
				Me.table_1000_st.Add(New cRecPU(5200, 1280, 305, 260))
				Me.table_1500_st.Clear()
				Me.table_1500_st.Add(New cRecPU(50, 25, 53, 24))
				Me.table_1500_st.Add(New cRecPU(150, 40, 67, 30))
				Me.table_1500_st.Add(New cRecPU(200, 57, 67, 36))
				Me.table_1500_st.Add(New cRecPU(250, 80, 76, 42))
				Me.table_1500_st.Add(New cRecPU(300, 80, 95, 48))
				Me.table_1500_st.Add(New cRecPU(400, 114, 95, 54))
				Me.table_1500_st.Add(New cRecPU(450, 114, 119, 54))
				Me.table_1500_st.Add(New cRecPU(600, 160, 119, 64))
				Me.table_1500_st.Add(New cRecPU(750, 228, 121, 74))
				Me.table_1500_st.Add(New cRecPU(850, 228, 121, 86))
				Me.table_1500_st.Add(New cRecPU(950, 320, 121, 100))
				Me.table_1500_st.Add(New cRecPU(1000, 320, 143, 100))
				Me.table_1500_st.Add(New cRecPU(1100, 320, 143, 100))
				Me.table_1500_st.Add(New cRecPU(1200, 456, 150, 120))
				Me.table_1500_st.Add(New cRecPU(1400, 456, 155, 120))
				Me.table_1500_st.Add(New cRecPU(1600, 640, 165, 144))
				Me.table_1500_st.Add(New cRecPU(1900, 640, 200, 144))
				Me.table_1500_st.Add(New cRecPU(2100, 640, 253, 144))
				Me.table_1500_st.Add(New cRecPU(2500, 912, 253, 168))
				Me.table_1500_st.Add(New cRecPU(2600, 912, 253, 192))
				Me.table_1500_st.Add(New cRecPU(2800, 1280, 253, 192))
				Me.table_1500_st.Add(New cRecPU(3000, 1280, 253, 216))
				Me.table_1500_st.Add(New cRecPU(3400, 1280, 305, 216))
				Me.table_1500_st.Add(New cRecPU(4000, 1824, 356, 216))
				Me.table_1500_st.Add(New cRecPU(4300, 1824, 365, 216))
				Me.table_1500_st.Add(New cRecPU(5000, 1824, 365, 240))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(50, 25, 67, 30))
				Me.table_2000_st.Add(New cRecPU(100, 40, 67, 30))
				Me.table_2000_st.Add(New cRecPU(150, 57, 89, 42))
				Me.table_2000_st.Add(New cRecPU(200, 80, 95, 48))
				Me.table_2000_st.Add(New cRecPU(275, 114, 95, 48))
				Me.table_2000_st.Add(New cRecPU(300, 114, 119, 48))
				Me.table_2000_st.Add(New cRecPU(350, 114, 119, 54))
				Me.table_2000_st.Add(New cRecPU(400, 160, 119, 54))
				Me.table_2000_st.Add(New cRecPU(450, 160, 143, 64))
				Me.table_2000_st.Add(New cRecPU(500, 228, 143, 74))
				Me.table_2000_st.Add(New cRecPU(700, 228, 173, 74))
				Me.table_2000_st.Add(New cRecPU(1000, 320, 213, 86))
				Me.table_2000_st.Add(New cRecPU(1250, 456, 256, 100))
				Me.table_2000_st.Add(New cRecPU(1500, 640, 305, 120))
				Me.table_2000_st.Add(New cRecPU(1700, 912, 305, 144))
				Me.table_2000_st.Add(New cRecPU(2000, 912, 305, 168))
				Me.table_2000_st.Add(New cRecPU(2800, 1280, 365, 168))
				Me.table_2000_st.Add(New cRecPU(3300, 1824, 365, 192))
				Me.table_2000_st.Add(New cRecPU(3800, 1824, 365, 216))
				Me.table_2000_st.Add(New cRecPU(4200, 2560, 365, 240))
				Me.table_2500_st.Clear()
				Me.table_2500_st.Add(New cRecPU(50, 40, 89, 36))
				Me.table_2500_st.Add(New cRecPU(100, 57, 89, 36))
				Me.table_2500_st.Add(New cRecPU(150, 80, 109, 42))
				Me.table_2500_st.Add(New cRecPU(200, 114, 133, 48))
				Me.table_2500_st.Add(New cRecPU(250, 160, 143, 54))
				Me.table_2500_st.Add(New cRecPU(300, 160, 143, 64))
				Me.table_2500_st.Add(New cRecPU(450, 228, 173, 64))
				Me.table_2500_st.Add(New cRecPU(550, 228, 200, 64))
				Me.table_2500_st.Add(New cRecPU(650, 320, 200, 74))
				Me.table_2500_st.Add(New cRecPU(700, 320, 213, 86))
				Me.table_2500_st.Add(New cRecPU(800, 456, 213, 86))
				Me.table_2500_st.Add(New cRecPU(900, 456, 256, 100))
				Me.table_2500_st.Add(New cRecPU(1000, 640, 256, 100))
				Me.table_2500_st.Add(New cRecPU(1300, 640, 305, 120))
				Me.table_2500_st.Add(New cRecPU(1700, 912, 305, 144))
				Me.table_2500_st.Add(New cRecPU(1750, 912, 356, 144))
				Me.table_2500_st.Add(New cRecPU(2000, 1280, 365, 168))
				Me.table_2500_st.Add(New cRecPU(2500, 1824, 365, 192))
				Me.table_2500_st.Add(New cRecPU(2800, 1824, 365, 216))
				Me.table_2500_st.Add(New cRecPU(3150, 2560, 427, 216))
				Me.table_2500_st.Add(New cRecPU(3750, 2560, 427, 240))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(50, 57, 89, 42))
				Me.table_3000_st.Add(New cRecPU(100, 80, 95, 48))
				Me.table_3000_st.Add(New cRecPU(150, 114, 133, 48))
				Me.table_3000_st.Add(New cRecPU(200, 160, 143, 64))
				Me.table_3000_st.Add(New cRecPU(250, 228, 133, 74))
				Me.table_3000_st.Add(New cRecPU(300, 228, 173, 74))
				Me.table_3000_st.Add(New cRecPU(500, 320, 212, 86))
				Me.table_3000_st.Add(New cRecPU(800, 456, 256, 100))
				Me.table_3000_st.Add(New cRecPU(1000, 640, 305, 120))
				Me.table_3000_st.Add(New cRecPU(1300, 912, 305, 144))
				Me.table_3000_st.Add(New cRecPU(1500, 1280, 365, 168))
				Me.table_3000_st.Add(New cRecPU(1700, 1280, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2000, 1824, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2200, 1824, 365, 216))
				Me.table_3000_st.Add(New cRecPU(2500, 1824, 365, 240))
				Me.table_3000_st.Add(New cRecPU(2900, 2560, 470, 240))
				Me.table_3500_st.Clear()
				Me.table_3500_st.Add(New cRecPU(50, 80, 95, 48))
				Me.table_3500_st.Add(New cRecPU(100, 114, 133, 48))
				Me.table_3500_st.Add(New cRecPU(150, 160, 143, 64))
				Me.table_3500_st.Add(New cRecPU(200, 228, 143, 64))
				Me.table_3500_st.Add(New cRecPU(250, 228, 173, 74))
				Me.table_3500_st.Add(New cRecPU(350, 320, 246, 74))
				Me.table_3500_st.Add(New cRecPU(450, 456, 256, 86))
				Me.table_3500_st.Add(New cRecPU(600, 456, 256, 100))
				Me.table_3500_st.Add(New cRecPU(800, 640, 305, 120))
				Me.table_3500_st.Add(New cRecPU(1000, 912, 305, 144))
				Me.table_3500_st.Add(New cRecPU(1200, 912, 305, 168))
				Me.table_3500_st.Add(New cRecPU(1400, 1280, 365, 192))
				Me.table_3500_st.Add(New cRecPU(1800, 1824, 365, 192))
				Me.table_3500_st.Add(New cRecPU(2000, 1824, 365, 216))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(50, 80, 109, 48))
				Me.table_4000_st.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4000_st.Add(New cRecPU(150, 160, 169, 54))
				Me.table_4000_st.Add(New cRecPU(200, 228, 200, 64))
				Me.table_4000_st.Add(New cRecPU(300, 320, 246, 74))
				Me.table_4000_st.Add(New cRecPU(350, 456, 256, 86))
				Me.table_4000_st.Add(New cRecPU(400, 456, 298, 86))
				Me.table_4000_st.Add(New cRecPU(500, 456, 256, 100))
				Me.table_4000_st.Add(New cRecPU(525, 640, 305, 100))
				Me.table_4000_st.Add(New cRecPU(575, 640, 305, 120))
				Me.table_4000_st.Add(New cRecPU(650, 640, 253, 144))
				Me.table_4000_st.Add(New cRecPU(675, 640, 256, 144))
				Me.table_4000_st.Add(New cRecPU(800, 912, 305, 168))
				Me.table_4000_st.Add(New cRecPU(1100, 1280, 305, 192))
				Me.table_4000_st.Add(New cRecPU(1300, 1824, 365, 192))
				Me.table_4000_st.Add(New cRecPU(1400, 1824, 365, 216))
				Me.table_4000_st.Add(New cRecPU(1700, 1824, 365, 240))
				Me.table_4500_st.Clear()
				Me.table_4500_st.Add(New cRecPU(75, 114, 133, 48))
				Me.table_4500_st.Add(New cRecPU(125, 160, 169, 54))
				Me.table_4500_st.Add(New cRecPU(200, 228, 200, 64))
				Me.table_4500_st.Add(New cRecPU(250, 320, 246, 74))
				Me.table_4500_st.Add(New cRecPU(350, 456, 298, 86))
				Me.table_4500_st.Add(New cRecPU(375, 456, 256, 100))
				Me.table_4500_st.Add(New cRecPU(475, 640, 305, 120))
				Me.table_4500_st.Add(New cRecPU(500, 912, 305, 144))
				Me.table_4500_st.Add(New cRecPU(650, 912, 305, 144))
				Me.table_4500_st.Add(New cRecPU(800, 1280, 305, 192))
				Me.table_4500_st.Add(New cRecPU(1100, 1280, 356, 192))
				Me.table_4500_st.Add(New cRecPU(1350, 1824, 365, 216))
				Me.table_4500_st.Add(New cRecPU(1400, 1824, 365, 216))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(50, 114, 133, 48))
				Me.table_5000_st.Add(New cRecPU(100, 160, 169, 54))
				Me.table_5000_st.Add(New cRecPU(150, 228, 200, 64))
				Me.table_5000_st.Add(New cRecPU(200, 320, 246, 74))
				Me.table_5000_st.Add(New cRecPU(300, 456, 246, 86))
				Me.table_5000_st.Add(New cRecPU(325, 640, 246, 100))
				Me.table_5000_st.Add(New cRecPU(350, 640, 305, 120))
				Me.table_5000_st.Add(New cRecPU(450, 640, 305, 120))
				Me.table_5000_st.Add(New cRecPU(600, 912, 305, 144))
				Me.table_5000_st.Add(New cRecPU(750, 1280, 356, 168))
				Me.table_5000_st.Add(New cRecPU(900, 1824, 365, 192))
				Me.table_5000_st.Add(New cRecPU(950, 1824, 365, 216))
				Me.table_5000_st.Add(New cRecPU(1000, 1824, 365, 240))
				Me.table_5000_st.Add(New cRecPU(1250, 2560, 470, 240))
				Me.table_5500_st.Clear()
				Me.table_5500_st.Add(New cRecPU(50, 160, 169, 54))
				Me.table_5500_st.Add(New cRecPU(75, 160, 169, 64))
				Me.table_5500_st.Add(New cRecPU(150, 228, 200, 64))
				Me.table_5500_st.Add(New cRecPU(180, 320, 246, 74))
				Me.table_5500_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_5500_st.Add(New cRecPU(300, 456, 298, 100))
				Me.table_5500_st.Add(New cRecPU(500, 640, 365, 100))
				Me.table_5500_st.Add(New cRecPU(550, 912, 365, 120))
				Me.table_5500_st.Add(New cRecPU(650, 1280, 365, 144))
				Me.table_5500_st.Add(New cRecPU(700, 1280, 365, 168))
				Me.table_5500_st.Add(New cRecPU(950, 1824, 365, 192))
				Me.table_5500_st.Add(New cRecPU(1000, 1824, 365, 216))
				Me.table_5500_st.Add(New cRecPU(1200, 2560, 427, 240))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(50, 114, 169, 44))
				Me.table_6000_st.Add(New cRecPU(75, 160, 200, 54))
				Me.table_6000_st.Add(New cRecPU(85, 228, 200, 64))
				Me.table_6000_st.Add(New cRecPU(175, 320, 246, 74))
				Me.table_6000_st.Add(New cRecPU(200, 456, 256, 100))
				Me.table_6000_st.Add(New cRecPU(250, 456, 305, 100))
				Me.table_6000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_6000_st.Add(New cRecPU(450, 912, 305, 144))
				Me.table_6000_st.Add(New cRecPU(475, 1280, 305, 192))
				Me.table_6000_st.Add(New cRecPU(550, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(600, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(750, 1824, 365, 192))
				Me.table_6000_st.Add(New cRecPU(900, 1824, 365, 216))
				Me.table_6000_st.Add(New cRecPU(1000, 1824, 365, 240))
				Me.table_6500_st.Clear()
				Me.table_6500_st.Add(New cRecPU(75, 160, 200, 54))
				Me.table_6500_st.Add(New cRecPU(100, 228, 246, 64))
				Me.table_6500_st.Add(New cRecPU(200, 320, 246, 74))
				Me.table_6500_st.Add(New cRecPU(250, 456, 246, 86))
				Me.table_6500_st.Add(New cRecPU(350, 456, 298, 86))
				Me.table_6500_st.Add(New cRecPU(400, 640, 298, 100))
				Me.table_6500_st.Add(New cRecPU(500, 912, 427, 120))
				Me.table_6500_st.Add(New cRecPU(550, 1280, 365, 168))
				Me.table_6500_st.Add(New cRecPU(650, 1824, 365, 192))
				Me.table_6500_st.Add(New cRecPU(750, 1824, 365, 216))
				Me.table_6500_st.Add(New cRecPU(850, 1824, 427, 240))
				Me.table_6500_st.Add(New cRecPU(950, 2560, 427, 260))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(100, 228, 200, 64))
				Me.table_7000_st.Add(New cRecPU(150, 320, 298, 74))
				Me.table_7000_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_7000_st.Add(New cRecPU(275, 640, 298, 100))
				Me.table_7000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_7000_st.Add(New cRecPU(400, 912, 356, 144))
				Me.table_7000_st.Add(New cRecPU(450, 1280, 365, 168))
				Me.table_7000_st.Add(New cRecPU(550, 1824, 365, 192))
				Me.table_7000_st.Add(New cRecPU(600, 1824, 427, 192))
				Me.table_7000_st.Add(New cRecPU(700, 1824, 427, 216))
				Me.table_7000_st.Add(New cRecPU(800, 2560, 427, 240))
				Me.table_7500_st.Clear()
				Me.table_7500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_7500_st.Add(New cRecPU(175, 320, 298, 86))
				Me.table_7500_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_7500_st.Add(New cRecPU(260, 456, 298, 100))
				Me.table_7500_st.Add(New cRecPU(275, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(325, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(350, 912, 365, 144))
				Me.table_7500_st.Add(New cRecPU(400, 1280, 365, 168))
				Me.table_7500_st.Add(New cRecPU(425, 1280, 365, 192))
				Me.table_7500_st.Add(New cRecPU(500, 1824, 427, 192))
				Me.table_7500_st.Add(New cRecPU(625, 1824, 427, 216))
				Me.table_7500_st.Add(New cRecPU(650, 1824, 427, 240))
				Me.table_7500_st.Add(New cRecPU(700, 2560, 427, 260))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_8000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8000_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_8000_st.Add(New cRecPU(300, 640, 365, 120))
				Me.table_8000_st.Add(New cRecPU(325, 912, 365, 144))
				Me.table_8000_st.Add(New cRecPU(350, 1280, 365, 168))
				Me.table_8000_st.Add(New cRecPU(400, 1824, 365, 192))
				Me.table_8000_st.Add(New cRecPU(550, 1824, 427, 192))
				Me.table_8000_st.Add(New cRecPU(600, 2560, 427, 240))
				Me.table_8000_st.Add(New cRecPU(650, 2560, 427, 260))
				Me.table_8500_st.Clear()
				Me.table_8500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8500_st.Add(New cRecPU(150, 320, 298, 86))
				Me.table_8500_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8500_st.Add(New cRecPU(250, 640, 365, 120))
				Me.table_8500_st.Add(New cRecPU(350, 912, 365, 120))
				Me.table_8500_st.Add(New cRecPU(375, 912, 427, 144))
				Me.table_8500_st.Add(New cRecPU(400, 1280, 427, 168))
				Me.table_8500_st.Add(New cRecPU(500, 1824, 427, 192))
				Me.table_8500_st.Add(New cRecPU(550, 1824, 427, 216))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_9000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_9000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9000_st.Add(New cRecPU(250, 640, 365, 120))
				Me.table_9000_st.Add(New cRecPU(400, 912, 427, 120))
				Me.table_9000_st.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_9000_st.Add(New cRecPU(525, 1824, 427, 216))
				Me.table_9500_st.Clear()
				Me.table_9500_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_9500_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9500_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_9500_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_9500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_9500_st.Add(New cRecPU(400, 1824, 427, 216))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_10000_st.Add(New cRecPU(75, 320, 298, 100))
				Me.table_10000_st.Add(New cRecPU(150, 456, 298, 100))
				Me.table_10000_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_10000_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10000_st.Add(New cRecPU(325, 1280, 427, 192))
				Me.table_10000_st.Add(New cRecPU(375, 1824, 427, 216))
				Me.table_10000_st.Add(New cRecPU(400, 2560, 427, 240))
				Me.table_10500_st.Clear()
				Me.table_10500_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_10500_st.Add(New cRecPU(75, 228, 305, 74))
				Me.table_10500_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_10500_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_10500_st.Add(New cRecPU(190, 640, 427, 120))
				Me.table_10500_st.Add(New cRecPU(225, 912, 427, 120))
				Me.table_10500_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_10500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10500_st.Add(New cRecPU(375, 1824, 470, 216))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(50, 320, 298, 86))
				Me.table_11000_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_11000_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_11000_st.Add(New cRecPU(175, 640, 427, 120))
				Me.table_11000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11000_st.Add(New cRecPU(275, 1280, 427, 192))
				Me.table_11000_st.Add(New cRecPU(325, 1824, 427, 192))
				Me.table_11000_st.Add(New cRecPU(375, 1824, 427, 240))
				Me.table_11500_st.Clear()
				Me.table_11500_st.Add(New cRecPU(75, 320, 305, 100))
				Me.table_11500_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_11500_st.Add(New cRecPU(175, 640, 427, 120))
				Me.table_11500_st.Add(New cRecPU(275, 912, 427, 120))
				Me.table_11500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_11500_st.Add(New cRecPU(350, 1824, 427, 192))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(50, 320, 305, 100))
				Me.table_12000_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_12000_st.Add(New cRecPU(175, 640, 427, 100))
				Me.table_12000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_12000_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_12000_st.Add(New cRecPU(325, 1824, 427, 192))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(50, 320, 365, 100))
				Me.table_13000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_13000_st.Add(New cRecPU(100, 456, 427, 100))
				Me.table_13000_st.Add(New cRecPU(150, 640, 470, 120))
				Me.table_13000_st.Add(New cRecPU(175, 912, 427, 144))
				Me.table_13000_st.Add(New cRecPU(200, 1280, 427, 168))
				Me.table_13000_st.Add(New cRecPU(250, 1280, 470, 192))
				Me.table_13000_st.Add(New cRecPU(300, 1824, 470, 216))
				Me.table_13500_st.Clear()
				Me.table_13500_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_13500_st.Add(New cRecPU(75, 456, 365, 100))
				Me.table_13500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13500_st.Add(New cRecPU(175, 912, 427, 144))
				Me.table_13500_st.Add(New cRecPU(250, 1280, 427, 168))
				Me.table_13500_st.Add(New cRecPU(275, 1824, 470, 216))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_14000_st.Add(New cRecPU(100, 456, 365, 100))
				Me.table_14000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14000_st.Add(New cRecPU(175, 912, 427, 144))
				Me.table_14000_st.Add(New cRecPU(200, 1280, 427, 168))
				Me.table_14000_st.Add(New cRecPU(225, 1824, 470, 192))
				Me.table_14000_st.Add(New cRecPU(250, 1824, 470, 216))
				Me.table_14500_st.Clear()
				Me.table_14500_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_14500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14500_st.Add(New cRecPU(175, 912, 456, 120))
				Me.table_14500_st.Add(New cRecPU(200, 912, 456, 144))
				Me.table_14500_st.Add(New cRecPU(225, 1824, 470, 192))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_15000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_15000_st.Add(New cRecPU(125, 640, 427, 126))
				Me.table_15000_st.Add(New cRecPU(175, 912, 427, 120))
				Me.table_15000_st.Add(New cRecPU(200, 1824, 470, 216))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_16000_st.Add(New cRecPU(75, 456, 456, 120))
				Me.table_16000_st.Add(New cRecPU(125, 640, 470, 120))
				Me.table_16000_st.Add(New cRecPU(150, 640, 470, 126))
				Me.table_17000_st.Clear()
				Me.table_17000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_17000_st.Add(New cRecPU(100, 640, 456, 120))
				Me.table_17000_st.Add(New cRecPU(125, 912, 427, 120))
				Me.table_18000_st.Clear()
				Me.table_18000_st.Add(New cRecPU(50, 456, 456, 100))
				Me.table_18000_st.Add(New cRecPU(75, 640, 470, 100))
				Me.table_18000_st.Add(New cRecPU(100, 640, 470, 126))
				Me.table_19000_st.Clear()
				Me.table_19000_st.Add(New cRecPU(50, 640, 470, 120))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUStal_Conv_keep()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(200, 25, 53, 24))
				Me.table_1000_st.Add(New cRecPU(300, 40, 67, 30))
				Me.table_1000_st.Add(New cRecPU(400, 57, 67, 42))
				Me.table_1000_st.Add(New cRecPU(500, 80, 76, 48))
				Me.table_1000_st.Add(New cRecPU(600, 80, 76, 54))
				Me.table_1000_st.Add(New cRecPU(700, 114, 76, 54))
				Me.table_1000_st.Add(New cRecPU(800, 114, 109, 54))
				Me.table_1000_st.Add(New cRecPU(900, 160, 143, 64))
				Me.table_1000_st.Add(New cRecPU(1250, 228, 143, 74))
				Me.table_1000_st.Add(New cRecPU(1600, 320, 143, 86))
				Me.table_1000_st.Add(New cRecPU(1750, 320, 173, 86))
				Me.table_1000_st.Add(New cRecPU(1850, 456, 173, 100))
				Me.table_1000_st.Add(New cRecPU(2000, 456, 173, 120))
				Me.table_1000_st.Add(New cRecPU(2300, 640, 173, 144))
				Me.table_1000_st.Add(New cRecPU(2800, 640, 256, 168))
				Me.table_1000_st.Add(New cRecPU(3400, 912, 256, 168))
				Me.table_1000_st.Add(New cRecPU(3500, 1280, 305, 168))
				Me.table_1000_st.Add(New cRecPU(3750, 1280, 305, 192))
				Me.table_1000_st.Add(New cRecPU(4000, 1280, 305, 240))
				Me.table_1000_st.Add(New cRecPU(5000, 1824, 356, 240))
				Me.table_1000_st.Add(New cRecPU(7000, 1824, 356, 260))
				Me.table_1500_st.Clear()
				Me.table_1500_st.Add(New cRecPU(50, 25, 53, 24))
				Me.table_1500_st.Add(New cRecPU(150, 40, 67, 30))
				Me.table_1500_st.Add(New cRecPU(200, 57, 67, 36))
				Me.table_1500_st.Add(New cRecPU(250, 80, 76, 42))
				Me.table_1500_st.Add(New cRecPU(300, 80, 95, 48))
				Me.table_1500_st.Add(New cRecPU(400, 114, 95, 54))
				Me.table_1500_st.Add(New cRecPU(450, 114, 119, 54))
				Me.table_1500_st.Add(New cRecPU(600, 160, 119, 64))
				Me.table_1500_st.Add(New cRecPU(750, 228, 121, 74))
				Me.table_1500_st.Add(New cRecPU(850, 228, 121, 86))
				Me.table_1500_st.Add(New cRecPU(950, 320, 121, 100))
				Me.table_1500_st.Add(New cRecPU(1000, 320, 143, 100))
				Me.table_1500_st.Add(New cRecPU(1100, 320, 143, 100))
				Me.table_1500_st.Add(New cRecPU(1200, 456, 150, 120))
				Me.table_1500_st.Add(New cRecPU(1400, 456, 155, 120))
				Me.table_1500_st.Add(New cRecPU(1600, 640, 165, 144))
				Me.table_1500_st.Add(New cRecPU(1900, 640, 200, 144))
				Me.table_1500_st.Add(New cRecPU(2100, 640, 253, 144))
				Me.table_1500_st.Add(New cRecPU(2500, 912, 253, 168))
				Me.table_1500_st.Add(New cRecPU(2600, 912, 253, 192))
				Me.table_1500_st.Add(New cRecPU(2800, 1280, 253, 192))
				Me.table_1500_st.Add(New cRecPU(3000, 1280, 253, 216))
				Me.table_1500_st.Add(New cRecPU(3400, 1280, 305, 216))
				Me.table_1500_st.Add(New cRecPU(4000, 1824, 356, 216))
				Me.table_1500_st.Add(New cRecPU(4300, 1824, 365, 216))
				Me.table_1500_st.Add(New cRecPU(5000, 1824, 365, 240))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(50, 25, 67, 30))
				Me.table_2000_st.Add(New cRecPU(100, 40, 67, 30))
				Me.table_2000_st.Add(New cRecPU(150, 57, 89, 42))
				Me.table_2000_st.Add(New cRecPU(200, 80, 95, 48))
				Me.table_2000_st.Add(New cRecPU(275, 114, 95, 48))
				Me.table_2000_st.Add(New cRecPU(300, 114, 119, 48))
				Me.table_2000_st.Add(New cRecPU(400, 160, 119, 54))
				Me.table_2000_st.Add(New cRecPU(500, 228, 143, 74))
				Me.table_2000_st.Add(New cRecPU(700, 228, 173, 74))
				Me.table_2000_st.Add(New cRecPU(1000, 320, 213, 86))
				Me.table_2000_st.Add(New cRecPU(1250, 456, 256, 100))
				Me.table_2000_st.Add(New cRecPU(1500, 640, 305, 120))
				Me.table_2000_st.Add(New cRecPU(1700, 912, 305, 144))
				Me.table_2000_st.Add(New cRecPU(2000, 912, 305, 168))
				Me.table_2000_st.Add(New cRecPU(2800, 1280, 365, 168))
				Me.table_2000_st.Add(New cRecPU(3300, 1824, 365, 192))
				Me.table_2000_st.Add(New cRecPU(3800, 1824, 365, 216))
				Me.table_2000_st.Add(New cRecPU(4200, 2560, 365, 240))
				Me.table_2500_st.Clear()
				Me.table_2500_st.Add(New cRecPU(50, 40, 89, 36))
				Me.table_2500_st.Add(New cRecPU(100, 57, 89, 36))
				Me.table_2500_st.Add(New cRecPU(150, 80, 109, 42))
				Me.table_2500_st.Add(New cRecPU(200, 114, 133, 48))
				Me.table_2500_st.Add(New cRecPU(250, 160, 143, 54))
				Me.table_2500_st.Add(New cRecPU(300, 160, 143, 64))
				Me.table_2500_st.Add(New cRecPU(450, 228, 173, 64))
				Me.table_2500_st.Add(New cRecPU(550, 228, 200, 64))
				Me.table_2500_st.Add(New cRecPU(650, 320, 200, 74))
				Me.table_2500_st.Add(New cRecPU(700, 320, 213, 86))
				Me.table_2500_st.Add(New cRecPU(800, 456, 213, 86))
				Me.table_2500_st.Add(New cRecPU(900, 456, 256, 100))
				Me.table_2500_st.Add(New cRecPU(1000, 640, 256, 100))
				Me.table_2500_st.Add(New cRecPU(1300, 640, 305, 120))
				Me.table_2500_st.Add(New cRecPU(1700, 912, 305, 144))
				Me.table_2500_st.Add(New cRecPU(1750, 912, 356, 144))
				Me.table_2500_st.Add(New cRecPU(2000, 1280, 305, 168))
				Me.table_2500_st.Add(New cRecPU(2500, 1824, 365, 192))
				Me.table_2500_st.Add(New cRecPU(2750, 1824, 365, 216))
				Me.table_2500_st.Add(New cRecPU(3150, 2560, 427, 216))
				Me.table_2500_st.Add(New cRecPU(3750, 2560, 427, 240))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(50, 57, 89, 42))
				Me.table_3000_st.Add(New cRecPU(100, 80, 95, 48))
				Me.table_3000_st.Add(New cRecPU(150, 114, 133, 48))
				Me.table_3000_st.Add(New cRecPU(200, 160, 143, 64))
				Me.table_3000_st.Add(New cRecPU(250, 228, 133, 74))
				Me.table_3000_st.Add(New cRecPU(300, 228, 173, 74))
				Me.table_3000_st.Add(New cRecPU(500, 320, 212, 86))
				Me.table_3000_st.Add(New cRecPU(800, 456, 256, 100))
				Me.table_3000_st.Add(New cRecPU(1000, 640, 305, 120))
				Me.table_3000_st.Add(New cRecPU(1300, 912, 305, 144))
				Me.table_3000_st.Add(New cRecPU(1500, 1280, 365, 168))
				Me.table_3000_st.Add(New cRecPU(1700, 1280, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2000, 1824, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2200, 1824, 365, 216))
				Me.table_3000_st.Add(New cRecPU(2500, 1824, 365, 240))
				Me.table_3000_st.Add(New cRecPU(2900, 2560, 470, 240))
				Me.table_3500_st.Clear()
				Me.table_3500_st.Add(New cRecPU(50, 80, 95, 48))
				Me.table_3500_st.Add(New cRecPU(100, 114, 133, 48))
				Me.table_3500_st.Add(New cRecPU(150, 160, 133, 54))
				Me.table_3500_st.Add(New cRecPU(200, 160, 143, 64))
				Me.table_3500_st.Add(New cRecPU(250, 228, 173, 74))
				Me.table_3500_st.Add(New cRecPU(350, 320, 246, 74))
				Me.table_3500_st.Add(New cRecPU(450, 456, 256, 86))
				Me.table_3500_st.Add(New cRecPU(600, 456, 256, 100))
				Me.table_3500_st.Add(New cRecPU(800, 640, 305, 120))
				Me.table_3500_st.Add(New cRecPU(1000, 912, 305, 144))
				Me.table_3500_st.Add(New cRecPU(1200, 912, 305, 168))
				Me.table_3500_st.Add(New cRecPU(1400, 1280, 365, 192))
				Me.table_3500_st.Add(New cRecPU(1800, 1824, 365, 192))
				Me.table_3500_st.Add(New cRecPU(2000, 1824, 365, 216))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(50, 80, 109, 48))
				Me.table_4000_st.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4000_st.Add(New cRecPU(150, 160, 169, 54))
				Me.table_4000_st.Add(New cRecPU(200, 228, 200, 64))
				Me.table_4000_st.Add(New cRecPU(350, 320, 246, 74))
				Me.table_4000_st.Add(New cRecPU(400, 456, 298, 86))
				Me.table_4000_st.Add(New cRecPU(525, 640, 305, 100))
				Me.table_4000_st.Add(New cRecPU(575, 640, 305, 120))
				Me.table_4000_st.Add(New cRecPU(650, 912, 305, 144))
				Me.table_4000_st.Add(New cRecPU(700, 912, 305, 168))
				Me.table_4000_st.Add(New cRecPU(750, 912, 305, 192))
				Me.table_4000_st.Add(New cRecPU(900, 1280, 305, 192))
				Me.table_4000_st.Add(New cRecPU(1100, 1280, 365, 192))
				Me.table_4000_st.Add(New cRecPU(1300, 1824, 365, 192))
				Me.table_4000_st.Add(New cRecPU(1400, 1824, 365, 216))
				Me.table_4000_st.Add(New cRecPU(1700, 1824, 365, 240))
				Me.table_4500_st.Clear()
				Me.table_4500_st.Add(New cRecPU(75, 114, 133, 48))
				Me.table_4500_st.Add(New cRecPU(125, 160, 169, 54))
				Me.table_4500_st.Add(New cRecPU(200, 228, 200, 64))
				Me.table_4500_st.Add(New cRecPU(250, 320, 246, 74))
				Me.table_4500_st.Add(New cRecPU(350, 456, 298, 86))
				Me.table_4500_st.Add(New cRecPU(375, 456, 298, 100))
				Me.table_4500_st.Add(New cRecPU(475, 640, 305, 120))
				Me.table_4500_st.Add(New cRecPU(500, 640, 305, 144))
				Me.table_4500_st.Add(New cRecPU(650, 912, 305, 144))
				Me.table_4500_st.Add(New cRecPU(700, 912, 305, 168))
				Me.table_4500_st.Add(New cRecPU(800, 1280, 305, 192))
				Me.table_4500_st.Add(New cRecPU(950, 1280, 356, 192))
				Me.table_4500_st.Add(New cRecPU(1100, 1824, 356, 216))
				Me.table_4500_st.Add(New cRecPU(1200, 1824, 365, 216))
				Me.table_4500_st.Add(New cRecPU(1350, 1824, 365, 240))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(50, 114, 133, 48))
				Me.table_5000_st.Add(New cRecPU(100, 160, 169, 54))
				Me.table_5000_st.Add(New cRecPU(150, 228, 200, 64))
				Me.table_5000_st.Add(New cRecPU(200, 320, 246, 74))
				Me.table_5000_st.Add(New cRecPU(300, 456, 298, 86))
				Me.table_5000_st.Add(New cRecPU(400, 640, 305, 100))
				Me.table_5000_st.Add(New cRecPU(425, 640, 305, 120))
				Me.table_5000_st.Add(New cRecPU(430, 640, 305, 144))
				Me.table_5000_st.Add(New cRecPU(600, 912, 356, 144))
				Me.table_5000_st.Add(New cRecPU(700, 1280, 356, 168))
				Me.table_5000_st.Add(New cRecPU(900, 1280, 356, 192))
				Me.table_5000_st.Add(New cRecPU(1100, 1824, 365, 216))
				Me.table_5000_st.Add(New cRecPU(1250, 2560, 427, 240))
				Me.table_5500_st.Clear()
				Me.table_5500_st.Add(New cRecPU(50, 114, 169, 54))
				Me.table_5500_st.Add(New cRecPU(75, 160, 169, 64))
				Me.table_5500_st.Add(New cRecPU(150, 228, 200, 64))
				Me.table_5500_st.Add(New cRecPU(180, 320, 246, 74))
				Me.table_5500_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_5500_st.Add(New cRecPU(300, 456, 298, 100))
				Me.table_5500_st.Add(New cRecPU(500, 640, 365, 100))
				Me.table_5500_st.Add(New cRecPU(550, 912, 365, 120))
				Me.table_5500_st.Add(New cRecPU(700, 1280, 365, 144))
				Me.table_5500_st.Add(New cRecPU(750, 1280, 365, 168))
				Me.table_5500_st.Add(New cRecPU(950, 1824, 365, 192))
				Me.table_5500_st.Add(New cRecPU(1000, 1824, 365, 216))
				Me.table_5500_st.Add(New cRecPU(1200, 2560, 427, 240))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(50, 114, 169, 44))
				Me.table_6000_st.Add(New cRecPU(75, 160, 200, 54))
				Me.table_6000_st.Add(New cRecPU(100, 228, 200, 64))
				Me.table_6000_st.Add(New cRecPU(150, 320, 246, 74))
				Me.table_6000_st.Add(New cRecPU(200, 456, 256, 100))
				Me.table_6000_st.Add(New cRecPU(250, 456, 305, 100))
				Me.table_6000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_6000_st.Add(New cRecPU(450, 912, 305, 144))
				Me.table_6000_st.Add(New cRecPU(475, 912, 305, 168))
				Me.table_6000_st.Add(New cRecPU(550, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(600, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(800, 1824, 365, 192))
				Me.table_6000_st.Add(New cRecPU(900, 1824, 365, 216))
				Me.table_6000_st.Add(New cRecPU(1000, 1824, 365, 240))
				Me.table_6500_st.Clear()
				Me.table_6500_st.Add(New cRecPU(75, 160, 200, 54))
				Me.table_6500_st.Add(New cRecPU(100, 228, 246, 64))
				Me.table_6500_st.Add(New cRecPU(200, 320, 246, 74))
				Me.table_6500_st.Add(New cRecPU(250, 456, 246, 86))
				Me.table_6500_st.Add(New cRecPU(350, 456, 298, 86))
				Me.table_6500_st.Add(New cRecPU(400, 640, 298, 100))
				Me.table_6500_st.Add(New cRecPU(500, 912, 365, 120))
				Me.table_6500_st.Add(New cRecPU(550, 1280, 365, 168))
				Me.table_6500_st.Add(New cRecPU(700, 1824, 365, 192))
				Me.table_6500_st.Add(New cRecPU(800, 1824, 365, 216))
				Me.table_6500_st.Add(New cRecPU(850, 1824, 427, 240))
				Me.table_6500_st.Add(New cRecPU(950, 2560, 427, 260))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(100, 228, 200, 64))
				Me.table_7000_st.Add(New cRecPU(150, 320, 246, 74))
				Me.table_7000_st.Add(New cRecPU(200, 456, 298, 86))
				Me.table_7000_st.Add(New cRecPU(250, 456, 298, 100))
				Me.table_7000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_7000_st.Add(New cRecPU(400, 912, 356, 144))
				Me.table_7000_st.Add(New cRecPU(450, 1280, 365, 168))
				Me.table_7000_st.Add(New cRecPU(550, 1824, 365, 192))
				Me.table_7000_st.Add(New cRecPU(600, 1824, 427, 192))
				Me.table_7000_st.Add(New cRecPU(700, 1824, 427, 216))
				Me.table_7000_st.Add(New cRecPU(800, 2560, 427, 240))
				Me.table_7500_st.Clear()
				Me.table_7500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_7500_st.Add(New cRecPU(175, 320, 298, 86))
				Me.table_7500_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_7500_st.Add(New cRecPU(260, 456, 298, 100))
				Me.table_7500_st.Add(New cRecPU(275, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(325, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(350, 912, 365, 144))
				Me.table_7500_st.Add(New cRecPU(400, 1280, 365, 168))
				Me.table_7500_st.Add(New cRecPU(425, 1280, 365, 192))
				Me.table_7500_st.Add(New cRecPU(500, 1824, 365, 192))
				Me.table_7500_st.Add(New cRecPU(550, 1824, 365, 216))
				Me.table_7500_st.Add(New cRecPU(625, 1824, 427, 216))
				Me.table_7500_st.Add(New cRecPU(650, 1824, 427, 240))
				Me.table_7500_st.Add(New cRecPU(700, 2560, 427, 260))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_8000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8000_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_8000_st.Add(New cRecPU(300, 640, 365, 120))
				Me.table_8000_st.Add(New cRecPU(325, 912, 365, 144))
				Me.table_8000_st.Add(New cRecPU(350, 1280, 365, 168))
				Me.table_8000_st.Add(New cRecPU(400, 1824, 365, 192))
				Me.table_8000_st.Add(New cRecPU(550, 1824, 427, 192))
				Me.table_8000_st.Add(New cRecPU(600, 2560, 427, 240))
				Me.table_8000_st.Add(New cRecPU(650, 2560, 427, 260))
				Me.table_8500_st.Clear()
				Me.table_8500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8500_st.Add(New cRecPU(150, 320, 298, 86))
				Me.table_8500_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8500_st.Add(New cRecPU(250, 640, 365, 120))
				Me.table_8500_st.Add(New cRecPU(350, 912, 365, 120))
				Me.table_8500_st.Add(New cRecPU(375, 912, 427, 144))
				Me.table_8500_st.Add(New cRecPU(400, 1280, 427, 168))
				Me.table_8500_st.Add(New cRecPU(500, 1824, 427, 192))
				Me.table_8500_st.Add(New cRecPU(550, 1824, 427, 216))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_9000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_9000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9000_st.Add(New cRecPU(250, 640, 365, 120))
				Me.table_9000_st.Add(New cRecPU(400, 912, 427, 120))
				Me.table_9000_st.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_9000_st.Add(New cRecPU(525, 1824, 427, 216))
				Me.table_9500_st.Clear()
				Me.table_9500_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_9500_st.Add(New cRecPU(100, 320, 298, 100))
				Me.table_9500_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9500_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_9500_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_9500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_9500_st.Add(New cRecPU(400, 1824, 427, 216))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_10000_st.Add(New cRecPU(75, 320, 298, 100))
				Me.table_10000_st.Add(New cRecPU(150, 456, 298, 100))
				Me.table_10000_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_10000_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10000_st.Add(New cRecPU(325, 1280, 427, 192))
				Me.table_10000_st.Add(New cRecPU(375, 1824, 427, 216))
				Me.table_10000_st.Add(New cRecPU(400, 2560, 427, 240))
				Me.table_10500_st.Clear()
				Me.table_10500_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_10500_st.Add(New cRecPU(75, 228, 305, 74))
				Me.table_10500_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_10500_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_10500_st.Add(New cRecPU(225, 640, 427, 120))
				Me.table_10500_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_10500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_10500_st.Add(New cRecPU(375, 1824, 427, 216))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(50, 320, 298, 86))
				Me.table_11000_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_11000_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_11000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_11000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11000_st.Add(New cRecPU(275, 1280, 427, 192))
				Me.table_11000_st.Add(New cRecPU(325, 1824, 427, 192))
				Me.table_11000_st.Add(New cRecPU(375, 1824, 470, 240))
				Me.table_11500_st.Clear()
				Me.table_11500_st.Add(New cRecPU(75, 320, 305, 100))
				Me.table_11500_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_11500_st.Add(New cRecPU(175, 640, 427, 120))
				Me.table_11500_st.Add(New cRecPU(275, 912, 427, 120))
				Me.table_11500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_11500_st.Add(New cRecPU(350, 1824, 427, 192))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(75, 320, 305, 100))
				Me.table_12000_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_12000_st.Add(New cRecPU(175, 640, 427, 100))
				Me.table_12000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_12000_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_12000_st.Add(New cRecPU(325, 1824, 427, 192))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_13000_st.Add(New cRecPU(75, 456, 365, 100))
				Me.table_13000_st.Add(New cRecPU(100, 456, 427, 100))
				Me.table_13000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13000_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_13000_st.Add(New cRecPU(250, 1280, 470, 168))
				Me.table_13000_st.Add(New cRecPU(300, 1824, 470, 216))
				Me.table_13500_st.Clear()
				Me.table_13500_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_13500_st.Add(New cRecPU(75, 456, 365, 100))
				Me.table_13500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13500_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_13500_st.Add(New cRecPU(250, 1280, 427, 168))
				Me.table_13500_st.Add(New cRecPU(275, 1824, 470, 216))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_14000_st.Add(New cRecPU(100, 456, 365, 100))
				Me.table_14000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14000_st.Add(New cRecPU(175, 912, 427, 144))
				Me.table_14000_st.Add(New cRecPU(200, 1280, 427, 168))
				Me.table_14000_st.Add(New cRecPU(225, 1824, 427, 192))
				Me.table_14000_st.Add(New cRecPU(250, 1824, 470, 216))
				Me.table_14500_st.Clear()
				Me.table_14500_st.Add(New cRecPU(50, 456, 365, 100))
				Me.table_14500_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_14500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14500_st.Add(New cRecPU(175, 912, 427, 120))
				Me.table_14500_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_14500_st.Add(New cRecPU(225, 1824, 427, 192))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_15000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_15000_st.Add(New cRecPU(125, 640, 427, 126))
				Me.table_15000_st.Add(New cRecPU(175, 912, 427, 120))
				Me.table_15000_st.Add(New cRecPU(200, 1824, 427, 216))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_16000_st.Add(New cRecPU(75, 456, 427, 120))
				Me.table_16000_st.Add(New cRecPU(125, 640, 470, 120))
				Me.table_16000_st.Add(New cRecPU(150, 640, 470, 126))
				Me.table_17000_st.Clear()
				Me.table_17000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_17000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_17000_st.Add(New cRecPU(125, 912, 427, 120))
				Me.table_18000_st.Clear()
				Me.table_18000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_18000_st.Add(New cRecPU(75, 640, 470, 100))
				Me.table_18000_st.Add(New cRecPU(100, 640, 470, 126))
				Me.table_18000_st.Add(New cRecPU(125, 912, 470, 144))
				Me.table_19000_st.Clear()
				Me.table_19000_st.Add(New cRecPU(50, 640, 470, 120))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUStal_Old()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(200, 25, 53, 24))
				Me.table_1000_st.Add(New cRecPU(300, 40, 67, 30))
				Me.table_1000_st.Add(New cRecPU(400, 57, 67, 42))
				Me.table_1000_st.Add(New cRecPU(500, 80, 76, 48))
				Me.table_1000_st.Add(New cRecPU(600, 80, 76, 54))
				Me.table_1000_st.Add(New cRecPU(700, 114, 76, 54))
				Me.table_1000_st.Add(New cRecPU(800, 114, 109, 54))
				Me.table_1000_st.Add(New cRecPU(900, 160, 143, 64))
				Me.table_1000_st.Add(New cRecPU(1250, 228, 143, 74))
				Me.table_1000_st.Add(New cRecPU(1600, 320, 143, 86))
				Me.table_1000_st.Add(New cRecPU(1750, 320, 173, 86))
				Me.table_1000_st.Add(New cRecPU(1850, 456, 173, 100))
				Me.table_1000_st.Add(New cRecPU(2000, 456, 173, 120))
				Me.table_1000_st.Add(New cRecPU(2300, 640, 173, 144))
				Me.table_1000_st.Add(New cRecPU(2800, 640, 256, 168))
				Me.table_1000_st.Add(New cRecPU(3400, 912, 256, 168))
				Me.table_1000_st.Add(New cRecPU(3500, 1280, 305, 168))
				Me.table_1000_st.Add(New cRecPU(3750, 1280, 305, 192))
				Me.table_1000_st.Add(New cRecPU(4000, 1280, 305, 240))
				Me.table_1000_st.Add(New cRecPU(5000, 1824, 356, 240))
				Me.table_1000_st.Add(New cRecPU(7000, 1824, 356, 260))
				Me.table_1500_st.Clear()
				Me.table_1500_st.Add(New cRecPU(100, 25, 53, 24))
				Me.table_1500_st.Add(New cRecPU(150, 37, 53, 34))
				Me.table_1500_st.Add(New cRecPU(200, 57, 56, 36))
				Me.table_1500_st.Add(New cRecPU(300, 57, 67, 42))
				Me.table_1500_st.Add(New cRecPU(400, 80, 95, 48))
				Me.table_1500_st.Add(New cRecPU(500, 114, 119, 54))
				Me.table_1500_st.Add(New cRecPU(600, 119, 119, 64))
				Me.table_1500_st.Add(New cRecPU(900, 228, 121, 86))
				Me.table_1500_st.Add(New cRecPU(1000, 228, 143, 100))
				Me.table_1500_st.Add(New cRecPU(1100, 320, 213, 120))
				Me.table_1500_st.Add(New cRecPU(1300, 456, 213, 120))
				Me.table_1500_st.Add(New cRecPU(1600, 640, 253, 144))
				Me.table_1500_st.Add(New cRecPU(2000, 640, 256, 144))
				Me.table_1500_st.Add(New cRecPU(2500, 912, 256, 168))
				Me.table_1500_st.Add(New cRecPU(3000, 1280, 305, 192))
				Me.table_1500_st.Add(New cRecPU(3500, 1280, 305, 240))
				Me.table_1500_st.Add(New cRecPU(4000, 1824, 305, 260))
				Me.table_1500_st.Add(New cRecPU(4500, 1824, 365, 260))
				Me.table_1500_st.Add(New cRecPU(5000, 1824, 365, 260))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(50, 25, 53, 24))
				Me.table_2000_st.Add(New cRecPU(100, 40, 67, 30))
				Me.table_2000_st.Add(New cRecPU(150, 57, 89, 42))
				Me.table_2000_st.Add(New cRecPU(200, 57, 76, 42))
				Me.table_2000_st.Add(New cRecPU(250, 80, 95, 48))
				Me.table_2000_st.Add(New cRecPU(300, 114, 119, 54))
				Me.table_2000_st.Add(New cRecPU(400, 114, 119, 54))
				Me.table_2000_st.Add(New cRecPU(500, 160, 119, 64))
				Me.table_2000_st.Add(New cRecPU(700, 228, 173, 74))
				Me.table_2000_st.Add(New cRecPU(900, 320, 212, 86))
				Me.table_2000_st.Add(New cRecPU(1000, 320, 213, 86))
				Me.table_2000_st.Add(New cRecPU(1100, 320, 256, 100))
				Me.table_2000_st.Add(New cRecPU(1250, 456, 256, 100))
				Me.table_2000_st.Add(New cRecPU(1500, 640, 305, 120))
				Me.table_2000_st.Add(New cRecPU(2000, 912, 305, 144))
				Me.table_2000_st.Add(New cRecPU(2250, 1280, 305, 168))
				Me.table_2000_st.Add(New cRecPU(2500, 1824, 305, 192))
				Me.table_2000_st.Add(New cRecPU(3000, 1824, 365, 192))
				Me.table_2000_st.Add(New cRecPU(4000, 1824, 365, 216))
				Me.table_2000_st.Add(New cRecPU(4500, 2560, 365, 240))
				Me.table_2500_st.Clear()
				Me.table_2500_st.Add(New cRecPU(50, 40, 67, 30))
				Me.table_2500_st.Add(New cRecPU(100, 57, 89, 36))
				Me.table_2500_st.Add(New cRecPU(150, 80, 109, 42))
				Me.table_2500_st.Add(New cRecPU(200, 114, 133, 48))
				Me.table_2500_st.Add(New cRecPU(250, 114, 119, 54))
				Me.table_2500_st.Add(New cRecPU(300, 160, 143, 64))
				Me.table_2500_st.Add(New cRecPU(400, 160, 173, 64))
				Me.table_2500_st.Add(New cRecPU(600, 228, 173, 74))
				Me.table_2500_st.Add(New cRecPU(800, 320, 213, 86))
				Me.table_2500_st.Add(New cRecPU(1000, 456, 256, 100))
				Me.table_2500_st.Add(New cRecPU(1250, 640, 305, 120))
				Me.table_2500_st.Add(New cRecPU(1500, 912, 305, 144))
				Me.table_2500_st.Add(New cRecPU(1750, 912, 356, 144))
				Me.table_2500_st.Add(New cRecPU(2000, 1280, 356, 144))
				Me.table_2500_st.Add(New cRecPU(2500, 1280, 365, 192))
				Me.table_2500_st.Add(New cRecPU(3000, 1824, 365, 216))
				Me.table_2500_st.Add(New cRecPU(3500, 2560, 470, 240))
				Me.table_2500_st.Add(New cRecPU(4000, 2560, 470, 260))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(50, 57, 89, 42))
				Me.table_3000_st.Add(New cRecPU(100, 80, 95, 48))
				Me.table_3000_st.Add(New cRecPU(150, 114, 133, 48))
				Me.table_3000_st.Add(New cRecPU(200, 160, 143, 64))
				Me.table_3000_st.Add(New cRecPU(300, 228, 173, 74))
				Me.table_3000_st.Add(New cRecPU(500, 320, 212, 86))
				Me.table_3000_st.Add(New cRecPU(600, 456, 256, 100))
				Me.table_3000_st.Add(New cRecPU(900, 640, 256, 100))
				Me.table_3000_st.Add(New cRecPU(1100, 640, 305, 120))
				Me.table_3000_st.Add(New cRecPU(1400, 912, 305, 144))
				Me.table_3000_st.Add(New cRecPU(1500, 912, 305, 168))
				Me.table_3000_st.Add(New cRecPU(1750, 1280, 305, 192))
				Me.table_3000_st.Add(New cRecPU(2000, 1280, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2400, 1824, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2700, 1824, 365, 216))
				Me.table_3000_st.Add(New cRecPU(3000, 2560, 470, 240))
				Me.table_3500_st.Clear()
				Me.table_3500_st.Add(New cRecPU(50, 80, 95, 48))
				Me.table_3500_st.Add(New cRecPU(100, 114, 133, 48))
				Me.table_3500_st.Add(New cRecPU(150, 160, 133, 54))
				Me.table_3500_st.Add(New cRecPU(200, 160, 143, 64))
				Me.table_3500_st.Add(New cRecPU(250, 228, 173, 74))
				Me.table_3500_st.Add(New cRecPU(350, 320, 246, 74))
				Me.table_3500_st.Add(New cRecPU(450, 456, 256, 86))
				Me.table_3500_st.Add(New cRecPU(600, 456, 256, 100))
				Me.table_3500_st.Add(New cRecPU(800, 640, 305, 120))
				Me.table_3500_st.Add(New cRecPU(1000, 912, 305, 144))
				Me.table_3500_st.Add(New cRecPU(1200, 912, 305, 168))
				Me.table_3500_st.Add(New cRecPU(1400, 1280, 305, 192))
				Me.table_3500_st.Add(New cRecPU(1800, 1824, 365, 192))
				Me.table_3500_st.Add(New cRecPU(2000, 1824, 365, 216))
				Me.table_3500_st.Add(New cRecPU(2200, 1824, 365, 240))
				Me.table_3500_st.Add(New cRecPU(2400, 2560, 365, 260))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(50, 80, 109, 48))
				Me.table_4000_st.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4000_st.Add(New cRecPU(150, 160, 169, 64))
				Me.table_4000_st.Add(New cRecPU(200, 228, 200, 64))
				Me.table_4000_st.Add(New cRecPU(300, 320, 240, 74))
				Me.table_4000_st.Add(New cRecPU(400, 456, 298, 86))
				Me.table_4000_st.Add(New cRecPU(600, 640, 305, 100))
				Me.table_4000_st.Add(New cRecPU(900, 912, 356, 120))
				Me.table_4000_st.Add(New cRecPU(1200, 1280, 365, 168))
				Me.table_4000_st.Add(New cRecPU(1400, 1824, 365, 216))
				Me.table_4000_st.Add(New cRecPU(1700, 1824, 365, 240))
				Me.table_4000_st.Add(New cRecPU(2000, 2560, 427, 260))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(50, 114, 133, 48))
				Me.table_5000_st.Add(New cRecPU(100, 160, 169, 54))
				Me.table_5000_st.Add(New cRecPU(150, 228, 200, 64))
				Me.table_5000_st.Add(New cRecPU(200, 320, 246, 74))
				Me.table_5000_st.Add(New cRecPU(300, 456, 298, 86))
				Me.table_5000_st.Add(New cRecPU(400, 640, 305, 100))
				Me.table_5000_st.Add(New cRecPU(425, 640, 305, 120))
				Me.table_5000_st.Add(New cRecPU(430, 640, 305, 144))
				Me.table_5000_st.Add(New cRecPU(600, 912, 356, 144))
				Me.table_5000_st.Add(New cRecPU(700, 1280, 356, 168))
				Me.table_5000_st.Add(New cRecPU(900, 1280, 356, 192))
				Me.table_5000_st.Add(New cRecPU(1100, 1824, 365, 216))
				Me.table_5000_st.Add(New cRecPU(1250, 2560, 427, 240))
				Me.table_5500_st.Clear()
				Me.table_5500_st.Add(New cRecPU(50, 114, 169, 54))
				Me.table_5500_st.Add(New cRecPU(75, 160, 169, 64))
				Me.table_5500_st.Add(New cRecPU(150, 228, 200, 64))
				Me.table_5500_st.Add(New cRecPU(180, 320, 246, 74))
				Me.table_5500_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_5500_st.Add(New cRecPU(300, 456, 298, 100))
				Me.table_5500_st.Add(New cRecPU(500, 640, 365, 100))
				Me.table_5500_st.Add(New cRecPU(550, 912, 365, 120))
				Me.table_5500_st.Add(New cRecPU(700, 1280, 365, 144))
				Me.table_5500_st.Add(New cRecPU(750, 1280, 365, 168))
				Me.table_5500_st.Add(New cRecPU(950, 1824, 365, 192))
				Me.table_5500_st.Add(New cRecPU(1000, 1824, 365, 216))
				Me.table_5500_st.Add(New cRecPU(1200, 2560, 427, 240))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(50, 114, 169, 44))
				Me.table_6000_st.Add(New cRecPU(75, 160, 200, 54))
				Me.table_6000_st.Add(New cRecPU(100, 228, 200, 64))
				Me.table_6000_st.Add(New cRecPU(150, 320, 246, 74))
				Me.table_6000_st.Add(New cRecPU(200, 456, 256, 100))
				Me.table_6000_st.Add(New cRecPU(250, 456, 305, 100))
				Me.table_6000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_6000_st.Add(New cRecPU(450, 912, 305, 144))
				Me.table_6000_st.Add(New cRecPU(475, 912, 305, 168))
				Me.table_6000_st.Add(New cRecPU(550, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(600, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(800, 1824, 365, 192))
				Me.table_6000_st.Add(New cRecPU(900, 1824, 365, 216))
				Me.table_6000_st.Add(New cRecPU(1000, 1824, 365, 240))
				Me.table_6500_st.Clear()
				Me.table_6500_st.Add(New cRecPU(75, 160, 200, 54))
				Me.table_6500_st.Add(New cRecPU(100, 228, 246, 64))
				Me.table_6500_st.Add(New cRecPU(200, 320, 246, 74))
				Me.table_6500_st.Add(New cRecPU(250, 456, 246, 86))
				Me.table_6500_st.Add(New cRecPU(350, 456, 298, 86))
				Me.table_6500_st.Add(New cRecPU(400, 640, 298, 100))
				Me.table_6500_st.Add(New cRecPU(500, 912, 365, 120))
				Me.table_6500_st.Add(New cRecPU(550, 1280, 365, 168))
				Me.table_6500_st.Add(New cRecPU(700, 1824, 365, 192))
				Me.table_6500_st.Add(New cRecPU(800, 1824, 365, 216))
				Me.table_6500_st.Add(New cRecPU(850, 1824, 427, 240))
				Me.table_6500_st.Add(New cRecPU(950, 2560, 427, 260))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(100, 228, 200, 64))
				Me.table_7000_st.Add(New cRecPU(150, 320, 246, 74))
				Me.table_7000_st.Add(New cRecPU(200, 456, 298, 86))
				Me.table_7000_st.Add(New cRecPU(250, 456, 298, 100))
				Me.table_7000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_7000_st.Add(New cRecPU(400, 912, 356, 144))
				Me.table_7000_st.Add(New cRecPU(450, 1280, 365, 168))
				Me.table_7000_st.Add(New cRecPU(550, 1824, 365, 192))
				Me.table_7000_st.Add(New cRecPU(600, 1824, 427, 192))
				Me.table_7000_st.Add(New cRecPU(700, 1824, 427, 216))
				Me.table_7000_st.Add(New cRecPU(800, 2560, 427, 240))
				Me.table_7500_st.Clear()
				Me.table_7500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_7500_st.Add(New cRecPU(175, 320, 298, 86))
				Me.table_7500_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_7500_st.Add(New cRecPU(260, 456, 298, 100))
				Me.table_7500_st.Add(New cRecPU(275, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(325, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(350, 912, 365, 144))
				Me.table_7500_st.Add(New cRecPU(400, 1280, 365, 168))
				Me.table_7500_st.Add(New cRecPU(425, 1280, 365, 192))
				Me.table_7500_st.Add(New cRecPU(500, 1824, 365, 192))
				Me.table_7500_st.Add(New cRecPU(550, 1824, 365, 216))
				Me.table_7500_st.Add(New cRecPU(625, 1824, 427, 216))
				Me.table_7500_st.Add(New cRecPU(650, 1824, 427, 240))
				Me.table_7500_st.Add(New cRecPU(700, 2560, 427, 260))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_8000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8000_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_8000_st.Add(New cRecPU(300, 640, 365, 120))
				Me.table_8000_st.Add(New cRecPU(325, 912, 365, 144))
				Me.table_8000_st.Add(New cRecPU(350, 1280, 365, 168))
				Me.table_8000_st.Add(New cRecPU(400, 1824, 365, 192))
				Me.table_8000_st.Add(New cRecPU(550, 1824, 427, 192))
				Me.table_8000_st.Add(New cRecPU(600, 2560, 427, 240))
				Me.table_8000_st.Add(New cRecPU(650, 2560, 427, 260))
				Me.table_8500_st.Clear()
				Me.table_8500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8500_st.Add(New cRecPU(150, 320, 298, 86))
				Me.table_8500_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8500_st.Add(New cRecPU(250, 640, 365, 120))
				Me.table_8500_st.Add(New cRecPU(350, 912, 365, 120))
				Me.table_8500_st.Add(New cRecPU(375, 912, 427, 144))
				Me.table_8500_st.Add(New cRecPU(400, 1280, 427, 168))
				Me.table_8500_st.Add(New cRecPU(500, 1824, 427, 192))
				Me.table_8500_st.Add(New cRecPU(550, 1824, 427, 216))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_9000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_9000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9000_st.Add(New cRecPU(250, 640, 365, 120))
				Me.table_9000_st.Add(New cRecPU(400, 912, 427, 120))
				Me.table_9000_st.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_9000_st.Add(New cRecPU(525, 1824, 427, 216))
				Me.table_9500_st.Clear()
				Me.table_9500_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_9500_st.Add(New cRecPU(100, 320, 298, 100))
				Me.table_9500_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9500_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_9500_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_9500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_9500_st.Add(New cRecPU(400, 1824, 427, 216))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_10000_st.Add(New cRecPU(75, 320, 298, 100))
				Me.table_10000_st.Add(New cRecPU(150, 456, 298, 100))
				Me.table_10000_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_10000_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10000_st.Add(New cRecPU(325, 1280, 427, 192))
				Me.table_10000_st.Add(New cRecPU(375, 1824, 427, 216))
				Me.table_10000_st.Add(New cRecPU(400, 2560, 427, 240))
				Me.table_10500_st.Clear()
				Me.table_10500_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_10500_st.Add(New cRecPU(75, 228, 305, 74))
				Me.table_10500_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_10500_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_10500_st.Add(New cRecPU(225, 640, 427, 120))
				Me.table_10500_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_10500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_10500_st.Add(New cRecPU(375, 1824, 427, 216))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(50, 320, 298, 86))
				Me.table_11000_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_11000_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_11000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_11000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11000_st.Add(New cRecPU(275, 1280, 427, 192))
				Me.table_11000_st.Add(New cRecPU(325, 1824, 427, 192))
				Me.table_11000_st.Add(New cRecPU(375, 1824, 470, 240))
				Me.table_11500_st.Clear()
				Me.table_11500_st.Add(New cRecPU(75, 320, 305, 100))
				Me.table_11500_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_11500_st.Add(New cRecPU(175, 640, 427, 120))
				Me.table_11500_st.Add(New cRecPU(275, 912, 427, 120))
				Me.table_11500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_11500_st.Add(New cRecPU(350, 1824, 427, 192))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(75, 320, 305, 100))
				Me.table_12000_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_12000_st.Add(New cRecPU(175, 640, 427, 100))
				Me.table_12000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_12000_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_12000_st.Add(New cRecPU(325, 1824, 427, 192))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_13000_st.Add(New cRecPU(75, 456, 365, 100))
				Me.table_13000_st.Add(New cRecPU(100, 456, 427, 100))
				Me.table_13000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13000_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_13000_st.Add(New cRecPU(250, 1280, 470, 168))
				Me.table_13000_st.Add(New cRecPU(300, 1824, 470, 216))
				Me.table_13500_st.Clear()
				Me.table_13500_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_13500_st.Add(New cRecPU(75, 456, 365, 100))
				Me.table_13500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13500_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_13500_st.Add(New cRecPU(250, 1280, 427, 168))
				Me.table_13500_st.Add(New cRecPU(275, 1824, 470, 216))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_14000_st.Add(New cRecPU(100, 456, 365, 100))
				Me.table_14000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14000_st.Add(New cRecPU(175, 912, 427, 144))
				Me.table_14000_st.Add(New cRecPU(200, 1280, 427, 168))
				Me.table_14000_st.Add(New cRecPU(225, 1824, 427, 192))
				Me.table_14000_st.Add(New cRecPU(250, 1824, 470, 216))
				Me.table_14500_st.Clear()
				Me.table_14500_st.Add(New cRecPU(50, 456, 365, 100))
				Me.table_14500_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_14500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14500_st.Add(New cRecPU(175, 912, 427, 120))
				Me.table_14500_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_14500_st.Add(New cRecPU(225, 1824, 427, 192))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_15000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_15000_st.Add(New cRecPU(125, 640, 427, 126))
				Me.table_15000_st.Add(New cRecPU(175, 912, 427, 120))
				Me.table_15000_st.Add(New cRecPU(200, 1824, 427, 216))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_16000_st.Add(New cRecPU(75, 456, 427, 120))
				Me.table_16000_st.Add(New cRecPU(125, 640, 470, 120))
				Me.table_16000_st.Add(New cRecPU(150, 640, 470, 126))
				Me.table_17000_st.Clear()
				Me.table_17000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_17000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_17000_st.Add(New cRecPU(125, 912, 427, 120))
				Me.table_18000_st.Clear()
				Me.table_18000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_18000_st.Add(New cRecPU(75, 640, 470, 100))
				Me.table_18000_st.Add(New cRecPU(100, 640, 470, 126))
				Me.table_18000_st.Add(New cRecPU(125, 912, 470, 144))
				Me.table_19000_st.Clear()
				Me.table_19000_st.Add(New cRecPU(50, 640, 470, 120))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUSTAL_OLDER()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(250, 25, 53, 24))
				Me.table_1000_st.Add(New cRecPU(300, 40, 67, 30))
				Me.table_1000_st.Add(New cRecPU(400, 40, 67, 36))
				Me.table_1000_st.Add(New cRecPU(500, 57, 76, 42))
				Me.table_1000_st.Add(New cRecPU(600, 80, 95, 48))
				Me.table_1000_st.Add(New cRecPU(700, 80, 95, 48))
				Me.table_1000_st.Add(New cRecPU(800, 114, 119, 54))
				Me.table_1000_st.Add(New cRecPU(900, 160, 143, 64))
				Me.table_1000_st.Add(New cRecPU(1250, 228, 173, 74))
				Me.table_1000_st.Add(New cRecPU(1600, 320, 212, 86))
				Me.table_1000_st.Add(New cRecPU(1750, 456, 256, 100))
				Me.table_1000_st.Add(New cRecPU(2000, 456, 256, 100))
				Me.table_1000_st.Add(New cRecPU(2400, 640, 305, 120))
				Me.table_1000_st.Add(New cRecPU(3250, 912, 305, 144))
				Me.table_1000_st.Add(New cRecPU(3500, 1280, 356, 168))
				Me.table_1000_st.Add(New cRecPU(3750, 1280, 356, 192))
				Me.table_1000_st.Add(New cRecPU(4000, 1824, 356, 192))
				Me.table_1000_st.Add(New cRecPU(5000, 1824, 356, 240))
				Me.table_1500_st.Clear()
				Me.table_1500_st.Add(New cRecPU(50, 25, 53, 24))
				Me.table_1500_st.Add(New cRecPU(100, 25, 53, 30))
				Me.table_1500_st.Add(New cRecPU(150, 37, 53, 34))
				Me.table_1500_st.Add(New cRecPU(200, 40, 56, 36))
				Me.table_1500_st.Add(New cRecPU(250, 57, 67, 36))
				Me.table_1500_st.Add(New cRecPU(300, 57, 67, 42))
				Me.table_1500_st.Add(New cRecPU(400, 80, 76, 48))
				Me.table_1500_st.Add(New cRecPU(500, 80, 76, 54))
				Me.table_1500_st.Add(New cRecPU(600, 114, 76, 64))
				Me.table_1500_st.Add(New cRecPU(700, 160, 76, 74))
				Me.table_1500_st.Add(New cRecPU(800, 160, 80, 86))
				Me.table_1500_st.Add(New cRecPU(900, 228, 89, 86))
				Me.table_1500_st.Add(New cRecPU(1000, 228, 119, 100))
				Me.table_1500_st.Add(New cRecPU(1250, 320, 127, 100))
				Me.table_1500_st.Add(New cRecPU(1500, 456, 180, 100))
				Me.table_1500_st.Add(New cRecPU(2000, 640, 200, 120))
				Me.table_1500_st.Add(New cRecPU(2500, 912, 246, 168))
				Me.table_1500_st.Add(New cRecPU(3500, 1280, 305, 192))
				Me.table_1500_st.Add(New cRecPU(4000, 1824, 365, 192))
				Me.table_1500_st.Add(New cRecPU(4500, 1280, 365, 216))
				Me.table_1500_st.Add(New cRecPU(5000, 1824, 365, 240))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(50, 25, 53, 24))
				Me.table_2000_st.Add(New cRecPU(100, 40, 67, 30))
				Me.table_2000_st.Add(New cRecPU(150, 40, 67, 36))
				Me.table_2000_st.Add(New cRecPU(200, 57, 76, 42))
				Me.table_2000_st.Add(New cRecPU(250, 80, 95, 48))
				Me.table_2000_st.Add(New cRecPU(300, 80, 95, 48))
				Me.table_2000_st.Add(New cRecPU(350, 114, 119, 54))
				Me.table_2000_st.Add(New cRecPU(400, 114, 119, 54))
				Me.table_2000_st.Add(New cRecPU(500, 160, 173, 64))
				Me.table_2000_st.Add(New cRecPU(600, 160, 143, 74))
				Me.table_2000_st.Add(New cRecPU(700, 228, 115, 74))
				Me.table_2000_st.Add(New cRecPU(800, 320, 150, 86))
				Me.table_2000_st.Add(New cRecPU(900, 320, 150, 100))
				Me.table_2000_st.Add(New cRecPU(1000, 320, 150, 100))
				Me.table_2000_st.Add(New cRecPU(1100, 320, 173, 100))
				Me.table_2000_st.Add(New cRecPU(1250, 456, 256, 100))
				Me.table_2000_st.Add(New cRecPU(1500, 640, 305, 120))
				Me.table_2000_st.Add(New cRecPU(2000, 912, 305, 144))
				Me.table_2000_st.Add(New cRecPU(2250, 1280, 305, 168))
				Me.table_2000_st.Add(New cRecPU(2500, 1824, 365, 192))
				Me.table_2000_st.Add(New cRecPU(3000, 1824, 427, 192))
				Me.table_2000_st.Add(New cRecPU(3500, 2560, 470, 240))
				Me.table_2500_st.Clear()
				Me.table_2500_st.Add(New cRecPU(50, 40, 67, 30))
				Me.table_2500_st.Add(New cRecPU(100, 57, 89, 36))
				Me.table_2500_st.Add(New cRecPU(150, 80, 109, 42))
				Me.table_2500_st.Add(New cRecPU(200, 114, 109, 48))
				Me.table_2500_st.Add(New cRecPU(250, 114, 109, 54))
				Me.table_2500_st.Add(New cRecPU(300, 160, 133, 64))
				Me.table_2500_st.Add(New cRecPU(400, 228, 143, 64))
				Me.table_2500_st.Add(New cRecPU(600, 228, 173, 74))
				Me.table_2500_st.Add(New cRecPU(700, 320, 213, 86))
				Me.table_2500_st.Add(New cRecPU(800, 320, 256, 100))
				Me.table_2500_st.Add(New cRecPU(1000, 456, 256, 100))
				Me.table_2500_st.Add(New cRecPU(1250, 640, 256, 120))
				Me.table_2500_st.Add(New cRecPU(1500, 912, 305, 120))
				Me.table_2500_st.Add(New cRecPU(1750, 912, 305, 144))
				Me.table_2500_st.Add(New cRecPU(2000, 1280, 427, 144))
				Me.table_2500_st.Add(New cRecPU(3000, 1824, 420, 192))
				Me.table_2500_st.Add(New cRecPU(3500, 2560, 470, 240))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(50, 37, 80, 34))
				Me.table_3000_st.Add(New cRecPU(100, 57, 89, 36))
				Me.table_3000_st.Add(New cRecPU(150, 80, 109, 42))
				Me.table_3000_st.Add(New cRecPU(200, 160, 119, 64))
				Me.table_3000_st.Add(New cRecPU(300, 160, 143, 74))
				Me.table_3000_st.Add(New cRecPU(400, 228, 173, 74))
				Me.table_3000_st.Add(New cRecPU(500, 228, 173, 86))
				Me.table_3000_st.Add(New cRecPU(600, 320, 256, 100))
				Me.table_3000_st.Add(New cRecPU(700, 320, 256, 100))
				Me.table_3000_st.Add(New cRecPU(800, 456, 305, 120))
				Me.table_3000_st.Add(New cRecPU(900, 640, 305, 144))
				Me.table_3000_st.Add(New cRecPU(1000, 640, 305, 144))
				Me.table_3000_st.Add(New cRecPU(1250, 912, 305, 168))
				Me.table_3000_st.Add(New cRecPU(1400, 1280, 305, 168))
				Me.table_3000_st.Add(New cRecPU(1500, 1280, 356, 168))
				Me.table_3000_st.Add(New cRecPU(1750, 1280, 356, 168))
				Me.table_3000_st.Add(New cRecPU(2000, 1824, 470, 192))
				Me.table_3000_st.Add(New cRecPU(2500, 2560, 470, 240))
				Me.table_3000_st.Add(New cRecPU(3000, 2560, 470, 300))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(50, 80, 95, 48))
				Me.table_4000_st.Add(New cRecPU(75, 114, 119, 48))
				Me.table_4000_st.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4000_st.Add(New cRecPU(150, 228, 173, 64))
				Me.table_4000_st.Add(New cRecPU(200, 228, 200, 64))
				Me.table_4000_st.Add(New cRecPU(250, 228, 200, 64))
				Me.table_4000_st.Add(New cRecPU(300, 228, 200, 64))
				Me.table_4000_st.Add(New cRecPU(400, 320, 213, 74))
				Me.table_4000_st.Add(New cRecPU(450, 456, 256, 86))
				Me.table_4000_st.Add(New cRecPU(500, 456, 256, 100))
				Me.table_4000_st.Add(New cRecPU(600, 640, 305, 120))
				Me.table_4000_st.Add(New cRecPU(700, 640, 305, 120))
				Me.table_4000_st.Add(New cRecPU(800, 912, 305, 120))
				Me.table_4000_st.Add(New cRecPU(900, 912, 305, 120))
				Me.table_4000_st.Add(New cRecPU(1000, 912, 305, 144))
				Me.table_4000_st.Add(New cRecPU(1250, 1280, 305, 192))
				Me.table_4000_st.Add(New cRecPU(1400, 1280, 305, 192))
				Me.table_4000_st.Add(New cRecPU(1500, 1824, 470, 192))
				Me.table_4000_st.Add(New cRecPU(2000, 2560, 470, 240))
				Me.table_4000_st.Add(New cRecPU(2500, 2560, 470, 300))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(50, 114, 133, 48))
				Me.table_5000_st.Add(New cRecPU(100, 160, 169, 54))
				Me.table_5000_st.Add(New cRecPU(150, 160, 169, 54))
				Me.table_5000_st.Add(New cRecPU(200, 228, 200, 64))
				Me.table_5000_st.Add(New cRecPU(250, 320, 200, 74))
				Me.table_5000_st.Add(New cRecPU(300, 456, 256, 100))
				Me.table_5000_st.Add(New cRecPU(400, 640, 256, 120))
				Me.table_5000_st.Add(New cRecPU(500, 640, 305, 120))
				Me.table_5000_st.Add(New cRecPU(600, 912, 305, 144))
				Me.table_5000_st.Add(New cRecPU(700, 912, 305, 144))
				Me.table_5000_st.Add(New cRecPU(800, 1280, 356, 168))
				Me.table_5000_st.Add(New cRecPU(1000, 1280, 365, 192))
				Me.table_5000_st.Add(New cRecPU(1250, 1824, 365, 192))
				Me.table_5000_st.Add(New cRecPU(1500, 1824, 427, 192))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(50, 114, 150, 54))
				Me.table_6000_st.Add(New cRecPU(75, 160, 170, 54))
				Me.table_6000_st.Add(New cRecPU(100, 228, 213, 86))
				Me.table_6000_st.Add(New cRecPU(150, 320, 256, 86))
				Me.table_6000_st.Add(New cRecPU(200, 320, 256, 100))
				Me.table_6000_st.Add(New cRecPU(250, 456, 256, 100))
				Me.table_6000_st.Add(New cRecPU(300, 456, 256, 120))
				Me.table_6000_st.Add(New cRecPU(400, 640, 305, 120))
				Me.table_6000_st.Add(New cRecPU(500, 912, 356, 144))
				Me.table_6000_st.Add(New cRecPU(600, 1280, 356, 192))
				Me.table_6000_st.Add(New cRecPU(800, 1824, 365, 192))
				Me.table_6000_st.Add(New cRecPU(1000, 1824, 427, 192))
				Me.table_6000_st.Add(New cRecPU(1250, 2560, 470, 240))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(50, 160, 173, 64))
				Me.table_7000_st.Add(New cRecPU(100, 228, 200, 74))
				Me.table_7000_st.Add(New cRecPU(200, 320, 246, 86))
				Me.table_7000_st.Add(New cRecPU(250, 456, 298, 100))
				Me.table_7000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_7000_st.Add(New cRecPU(350, 640, 305, 120))
				Me.table_7000_st.Add(New cRecPU(400, 912, 305, 120))
				Me.table_7000_st.Add(New cRecPU(500, 640, 356, 144))
				Me.table_7000_st.Add(New cRecPU(600, 912, 365, 144))
				Me.table_7000_st.Add(New cRecPU(700, 1824, 365, 192))
				Me.table_7000_st.Add(New cRecPU(800, 1824, 427, 192))
				Me.table_7000_st.Add(New cRecPU(900, 1824, 427, 216))
				Me.table_7000_st.Add(New cRecPU(1000, 2560, 470, 240))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(50, 160, 200, 74))
				Me.table_8000_st.Add(New cRecPU(100, 228, 246, 74))
				Me.table_8000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8000_st.Add(New cRecPU(250, 456, 298, 100))
				Me.table_8000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_8000_st.Add(New cRecPU(350, 912, 305, 144))
				Me.table_8000_st.Add(New cRecPU(400, 912, 356, 168))
				Me.table_8000_st.Add(New cRecPU(500, 1280, 356, 168))
				Me.table_8000_st.Add(New cRecPU(600, 1824, 365, 192))
				Me.table_8000_st.Add(New cRecPU(700, 1824, 365, 192))
				Me.table_8000_st.Add(New cRecPU(800, 2560, 470, 240))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(50, 228, 246, 64))
				Me.table_9000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_9000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_9000_st.Add(New cRecPU(400, 912, 356, 144))
				Me.table_9000_st.Add(New cRecPU(500, 1824, 365, 192))
				Me.table_9000_st.Add(New cRecPU(600, 1824, 470, 192))
				Me.table_9000_st.Add(New cRecPU(700, 2560, 470, 240))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(50, 228, 246, 64))
				Me.table_10000_st.Add(New cRecPU(100, 320, 256, 100))
				Me.table_10000_st.Add(New cRecPU(150, 456, 298, 100))
				Me.table_10000_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10000_st.Add(New cRecPU(250, 912, 365, 144))
				Me.table_10000_st.Add(New cRecPU(300, 1280, 365, 168))
				Me.table_10000_st.Add(New cRecPU(400, 1824, 470, 192))
				Me.table_10000_st.Add(New cRecPU(500, 1824, 470, 240))
				Me.table_10000_st.Add(New cRecPU(600, 2560, 470, 240))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(50, 228, 298, 64))
				Me.table_11000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_11000_st.Add(New cRecPU(150, 456, 356, 100))
				Me.table_11000_st.Add(New cRecPU(200, 640, 356, 144))
				Me.table_11000_st.Add(New cRecPU(250, 912, 365, 144))
				Me.table_11000_st.Add(New cRecPU(300, 1280, 427, 192))
				Me.table_11000_st.Add(New cRecPU(400, 1824, 470, 192))
				Me.table_11000_st.Add(New cRecPU(500, 1824, 470, 240))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(50, 228, 298, 64))
				Me.table_12000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_12000_st.Add(New cRecPU(150, 456, 356, 100))
				Me.table_12000_st.Add(New cRecPU(175, 640, 356, 120))
				Me.table_12000_st.Add(New cRecPU(200, 912, 365, 144))
				Me.table_12000_st.Add(New cRecPU(250, 912, 365, 144))
				Me.table_12000_st.Add(New cRecPU(300, 1280, 427, 192))
				Me.table_12000_st.Add(New cRecPU(350, 1824, 470, 192))
				Me.table_12000_st.Add(New cRecPU(400, 1824, 470, 216))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(50, 228, 298, 86))
				Me.table_13000_st.Add(New cRecPU(100, 320, 356, 100))
				Me.table_13000_st.Add(New cRecPU(150, 640, 365, 120))
				Me.table_13000_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_13000_st.Add(New cRecPU(250, 1280, 427, 192))
				Me.table_13000_st.Add(New cRecPU(300, 1824, 470, 216))
				Me.table_13000_st.Add(New cRecPU(350, 1824, 470, 240))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(50, 228, 305, 86))
				Me.table_14000_st.Add(New cRecPU(100, 456, 365, 100))
				Me.table_14000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14000_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_14000_st.Add(New cRecPU(250, 1824, 470, 216))
				Me.table_14000_st.Add(New cRecPU(275, 1824, 470, 240))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_15000_st.Add(New cRecPU(75, 456, 365, 120))
				Me.table_15000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_15000_st.Add(New cRecPU(150, 912, 427, 144))
				Me.table_15000_st.Add(New cRecPU(200, 1824, 470, 216))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_16000_st.Add(New cRecPU(75, 456, 365, 120))
				Me.table_16000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_16000_st.Add(New cRecPU(125, 912, 427, 144))
				Me.table_16000_st.Add(New cRecPU(150, 1824, 500, 168))
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetPUDataRecommendation(bFiberglass As Boolean, TargetBFPD As Single, PumpDepth As Single, ByRef GearboxRating As Integer, ByRef StructRating As Integer, ByRef MaxStroke As Integer) As Boolean
			Dim result As Boolean = False
			Try
				Try
					Me.bMarkII = False
					Me.bRMark = False
					Me.bRotaflex = False
					Me.bAB = False
					If Me.cboManufMenu.SelectedItem IsNot Nothing Then
						If Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "Mark II", CompareMethod.Binary) > 0 Then
							Me.bMarkII = True
						Else
							Me.bMarkII = False
						End If
						If Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "Reverse", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "American Producer II", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "Maximizer II", CompareMethod.Binary) > 0 Then
							Me.bRMark = True
						Else
							Me.bRMark = False
						End If
						If Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "Rotaflex", CompareMethod.Binary) > 0 Then
							Me.bRotaflex = True
						Else
							Me.bRotaflex = False
						End If
						If Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "Air", CompareMethod.Binary) > 0 And Strings.InStr(Conversions.ToString(Me.cboManufMenu.SelectedItem), "Balanced", CompareMethod.Binary) > 0 Then
							Me.bAB = True
						Else
							Me.bAB = False
						End If
					Else
						If RSWIN_DESC.rst.PU.UnitType = 5S Then
							Me.bMarkII = True
						Else
							Me.bMarkII = False
						End If
						If RSWIN_DESC.rst.PU.UnitType = 2S Or Strings.InStr(RSWIN_DESC.rst.PU.Manuf, "Reverse", CompareMethod.Binary) > 0 Or Strings.InStr(RSWIN_DESC.rst.PU.Manuf, "American Producer II", CompareMethod.Binary) > 0 Or Strings.InStr(RSWIN_DESC.rst.PU.Manuf, "Maximizer II", CompareMethod.Binary) > 0 Then
							Me.bRMark = True
						Else
							Me.bRMark = False
						End If
						If(RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S) And Operators.CompareString(RSWIN_DESC.rst.PU.Manuf.Trim(), "Rotaflex", False) = 0 Then
							Me.bRotaflex = True
						Else
							Me.bRotaflex = False
						End If
						If RSWIN_DESC.rst.PU.UnitType = 6S Then
							Me.bAB = True
						Else
							Me.bAB = False
						End If
					End If
				Catch ex As Exception
				End Try
				If bFiberglass Then
					If Me.bRMark Then
						Dim flag As Boolean = True
						If flag = PumpDepth <= 1000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_1000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 1500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_1500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 2000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_2000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 2500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_2500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 3000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_3000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 3500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_3500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 4000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_4000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 4500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_4500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 5000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_5000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 5500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_5500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 6000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_6000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 6500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_6500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 7000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_7000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 7500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_7500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 8000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_8000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 8500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_8500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 9000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_9000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 9500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_9500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 10000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_10000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 10500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_10500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 11000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_11000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 12000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_12000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 13000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_13000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 14000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_14000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 15000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_15000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 16000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_16000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 17000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_17000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 18000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_18000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 19000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_19000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth <= 20000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_20000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag = PumpDepth > 20000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_20000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						End If
					ElseIf Me.bAB Then
						Dim flag2 As Boolean = True
						If flag2 = PumpDepth <= 1000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_1000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 1500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_1500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 2000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_2000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 2500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_2500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 3000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_3000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 3500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_3500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 4000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_4000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 4500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_4500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 5000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_5000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 5500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_5500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 6000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_6000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 6500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_6500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 7000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_7000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 7500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_7500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 8000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_8000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 8500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_8500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 9000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_9000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 9500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_9500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 10000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_10000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 10500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_10500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 11000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_11000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 12000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_12000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 13000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_13000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 14000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_14000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 15000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_15000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 16000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_16000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 17000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_17000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 18000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_18000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 19000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_19000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth <= 20000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_20000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag2 = PumpDepth > 20000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_20000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						End If
					ElseIf Me.bMarkII Then
						Dim flag3 As Boolean = True
						If flag3 = PumpDepth <= 2000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_2000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 2500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_2500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 3000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_3000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 3500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_3500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 4000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_4000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 4500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_4500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 5000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_5000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 5500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_5500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 6000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_6000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 6500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_6500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 7000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_7000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 7500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_7500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 8000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_8000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 8500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_8500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 9000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_9000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 9500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_9500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 10000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_10000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 10500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_10500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 11000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_11000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 12000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_12000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 13000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_13000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 14000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_14000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 15000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_15000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 16000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_16000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 17000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_17000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 18000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_18000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth <= 19000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_19000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag3 = PumpDepth > 19000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_20000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						End If
					ElseIf Me.bRotaflex Then
						Dim flag4 As Boolean = True
						If flag4 = PumpDepth <= 1000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_1000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 2000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_2000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 3000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_3000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 3500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_3500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 4000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_4000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 4500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_4500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 5000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_5000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 5500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_5500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 6000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_6000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 6500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_6500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 7000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_7000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 7500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_7500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 8000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_8000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 8500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_8500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 9000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_9000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 9500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_9500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 10000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_10000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 10500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_10500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 11000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_11000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 11500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_11500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 12000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_12000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 12500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_12500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 13000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_13000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 13500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_13500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 14000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_14000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 14500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_14500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 15000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_15000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 15500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_15500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 16000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_16000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 16500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_16500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 17000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_17000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 17500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_17500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 18000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_18000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth <= 18500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_18500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag4 = PumpDepth > 18500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_19000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						End If
					Else
						Dim flag5 As Boolean = True
						If flag5 = PumpDepth <= 2000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_2000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 3000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_3000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 3500F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_3500_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 4000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_4000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 5000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_5000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 6000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_6000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 7000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_7000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 8000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_8000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 9000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_9000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 10000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_10000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 11000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_11000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 12000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_12000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 13000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_13000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 14000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_14000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 15000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_15000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 16000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_16000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 17000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_17000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth <= 18000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_18000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						ElseIf flag5 = PumpDepth > 18000F Then
							result = Me.RecPumpingUnitTableLookup(Me.table_18000_fg, TargetBFPD, GearboxRating, StructRating, MaxStroke)
						End If
					End If
				ElseIf Me.bMarkII Then
					Dim flag6 As Boolean = True
					If flag6 = PumpDepth <= 1000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_1000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 1500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_1500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 2000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_2000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 2500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_2500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 3000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_3000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 3500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_3500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 4000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_4000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 4500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_4500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 5000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_5000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 5500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_5500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 6000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_6000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 6500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_6500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 7000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_7000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 7500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_7500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 8000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_8000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 8500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_8500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 9000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_9000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 9500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_9500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 10000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_10000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 10500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_10500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 11000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_11000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 11500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_11500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 12000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_12000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 12500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_12500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 13000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_13000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 13500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_13500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 14000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_14000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 14500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_14500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 15000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_15000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 15500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_15500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 16000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_16000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 17000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_17000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 17500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_17500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag6 = PumpDepth <= 18000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_18000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					Else
						result = (flag6 = PumpDepth <= 18500F AndAlso Me.RecPumpingUnitTableLookup(Me.table_18500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke))
					End If
				ElseIf Me.bRMark Then
					Dim flag7 As Boolean = True
					If flag7 = PumpDepth <= 1000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_1000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 1500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_1500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 2000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_2000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 2500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_2500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 3000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_3000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 3500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_3500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 4000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_4000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 4500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_4500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 5000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_5000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 5500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_5500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 6000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_6000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 6500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_6500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 7000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_7000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 7500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_7500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 8000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_8000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 8500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_8500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 9000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_9000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 9500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_9500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 10000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_10000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 10500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_10500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 11000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_11000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 11500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_11500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 12000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_12000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 12500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_12500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 13000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_13000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 13500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_13500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 14000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_14000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 14500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_14500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 15000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_15000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 16000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_16000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 17000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_17000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth <= 18000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_18000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag7 = PumpDepth > 18000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_18000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					End If
				ElseIf Me.bRotaflex Then
					Dim flag8 As Boolean = True
					If flag8 = PumpDepth <= 1000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_1000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 2000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_2000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 3000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_3000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 3500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_3500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 4000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_4000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 4500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_4500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 5000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_5000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 5500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_5500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 6000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_6000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 6500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_6500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 7000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_7000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 7500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_7500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 8000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_8000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 8500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_8500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 9000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_9000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 9500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_9500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 10000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_10000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 10500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_10500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 11000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_11000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 11500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_11500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 12000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_12000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 12500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_12500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 13000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_13000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 13500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_13500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 14000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_14000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 15000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_15000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 16000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_16000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 17000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_17000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth <= 18000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_17500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag8 = PumpDepth > 18000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_17500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					End If
				ElseIf Me.bAB Then
					Dim flag9 As Boolean = True
					If flag9 = PumpDepth <= 1000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_1000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 1500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_1500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 2000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_2000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 2500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_2500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 3000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_3000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 3500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_3500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 4000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_4000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 4500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_4500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 5000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_5000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 5500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_5500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 6000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_6000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 6500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_6500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 7000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_7000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 7500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_7500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 8000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_8000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 8500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_8500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 9000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_9000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 9500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_9500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 10000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_10000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 10500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_10500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 11000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_11000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 11500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_11500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 12000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_12000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 12500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_12500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 13000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_13000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 13500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_13500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 14000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_14000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 15000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_15000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 16000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_16000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 17000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_17000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth <= 18000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_18000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag9 = PumpDepth > 18000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_18000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					End If
				Else
					Dim flag10 As Boolean = True
					If flag10 = PumpDepth <= 1000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_1000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 1500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_1500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 2000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_2000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 2500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_2500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 3000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_3000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 3500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_3500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 4000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_4000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 4500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_4500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 5000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_5000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 5500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_5500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 6000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_6000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 6500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_6500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 7000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_7000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 7500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_7500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 8000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_8000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 8500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_8500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 9000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_9000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 9500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_9500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 10000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_10000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 10500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_10500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 11000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_11000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 11500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_11500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 12000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_12000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 13000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_13000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 13500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_13500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 14000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_14000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 14500F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_14500_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 15000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_15000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 16000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_16000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 17000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_17000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 18000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_18000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					ElseIf flag10 = PumpDepth <= 19000F Then
						result = Me.RecPumpingUnitTableLookup(Me.table_19000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke)
					Else
						result = (flag10 = PumpDepth > 19000F AndAlso Me.RecPumpingUnitTableLookup(Me.table_19000_st, TargetBFPD, GearboxRating, StructRating, MaxStroke))
					End If
				End If
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function RecPumpingUnitTableLookup(ByRef lookuptable As ArrayList, TargetBFPD As Single, ByRef iGB As Integer, ByRef iSR As Integer, ByRef iSL As Integer) As Boolean
			Dim flag As Boolean = False
			Dim num As Single = 0F
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Dim num4 As Integer = 0
			Try
				Dim enumerator As IEnumerator = lookuptable.GetEnumerator()
				enumerator.Reset()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim cRecPU As cRecPU = CType(obj, cRecPU)
					If CSng(cRecPU.TargetProduction) > num Then
						num = CSng(cRecPU.TargetProduction)
						num2 = cRecPU.GearBox
						num3 = cRecPU.StructRating
						num4 = cRecPU.StrokeLength
					End If
					If TargetBFPD <= CSng(cRecPU.TargetProduction) Then
						iGB = cRecPU.GearBox
						iSR = cRecPU.StructRating
						iSL = cRecPU.StrokeLength
						flag = True
						Exit While
					End If
				End While
				If Not flag And num <> 0F And TargetBFPD > num Then
					iGB = num2
					iSR = num3
					iSL = num4
					flag = True
				End If
			Catch ex As Exception
				flag = False
			End Try
			Return flag
		End Function

		Public Function ValidatePUData(Optional bQuiet As Boolean = True) As Boolean
			Dim flag As Boolean = False
			If Me.MyParentFrm Is Nothing Then
				Me.MyParentFrm = New RODSTAR()
				Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
			End If
			Try
				If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
					RSWIN_DESC.bBeamBalanced = True
				Else
					RSWIN_DESC.bBeamBalanced = False
				End If
			Catch ex As Exception
			End Try
			Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
			If Me.MyParentFrm Is Nothing Then
				Return True
			End If
			If Not Me.MyParentFrm.bClosing Then
				Dim flag2 As Boolean = True
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Not rst.IDEntered <> 0S Then
					If Not bQuiet Then
						Me.DisplayPUDataError("Please select a pumping unit manufacturer.", flag)
						If Not flag Then
							Dim control As Control = Me.cboManufMenu
							Me.SetActiveControl(control)
							Me.cboManufMenu = CType(control, ComboBox)
							flag2 = False
						End If
					End If
				ElseIf Strings.Trim(rst.UnitID).Length = 0 Then
					If Not bQuiet Then
						Me.DisplayPUDataError("Please select a pumping unit.", flag)
						If Not flag Then
							Dim control As Control = Me.lvwUnitList
							Me.SetActiveControl(control)
							Me.lvwUnitList = CType(control, ListView)
							flag2 = False
						End If
					End If
				ElseIf Operators.CompareString(Me.txtUnitID.Text.Trim(), "", False) = 0 Then
					If Not bQuiet Then
						Me.DisplayPUDataError("Please select a pumping unit.", flag)
						If Not flag Then
							Dim control As Control = Me.txtUnitID
							Me.SetActiveControl(control)
							Me.txtUnitID = CType(control, TextBox)
							flag2 = False
						End If
					End If
				ElseIf Not(RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs)) And RSWIN_DESC.rst.PU.UnitType <> 10S And (Not rst.UnknownM And RSWIN_DESC.rst.get_M(2) = 0F And rst.CBDataType <> 2S) Then
					If Not bQuiet Then
						Dim str As String
						If rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Then
							str = Me.sExistingMaximumCounterbalanceWeight
						ElseIf rst.PU.UnitType = 6S Then
							str = Me.sExistingAirTankPressure
						Else
							str = Me.sExistingMaximumCounterbalanceMoment
						End If
						Me.DisplayPUDataError("Please enter a value for " + str + ".", flag)
						If Not flag Then
							Dim control As Control = Me.txtCounterbalance
							Me.SetActiveControl(control)
							Me.txtCounterbalance = CType(control, TextBox)
							flag2 = False
						End If
					End If
				ElseIf rst.PU.CrankHole = 0S And RSWIN_DESC.rst.PU.UnitType <> 10S Then
					If Not bQuiet Then
						Me.DisplayPUDataError("Please enter a value for crank hole.", flag)
						If Not flag Then
							Dim control As Control = Me.cboCrankHole
							Me.SetActiveControl(control)
							Me.cboCrankHole = CType(control, ComboBox)
							flag2 = False
						End If
					End If
				ElseIf(rst.PU.CrankRotation <> 1S And rst.PU.CrankRotation <> -1S And RSWIN_DESC.rst.PU.UnitType <> 10S) AndAlso Not bQuiet Then
					Me.DisplayPUDataError("Please enter a value for direction of crank rotation.", flag)
					If Not flag Then
						Dim control As Control = Me.cboCrankRotation
						Me.SetActiveControl(control)
						Me.cboCrankRotation = CType(control, ComboBox)
						flag2 = False
					End If
				End If
				RSWIN_DESC.frmMain.ToolbarButtonSetState(16, flag2 Or Me.bCustomUnit)
				If Strings.Trim(rst.UnitID).Length = 0 Or Operators.CompareString(Me.txtUnitID.Text.Trim(), "", False) = 0 Then
					RSWIN_DESC.frmMain.ToolbarButtonSetState(16, False)
				End If
				Me.m_bValidated = True
				Return flag2
			End If
			Return True
		End Function

		Private Sub SetActiveControl(ByRef myControl As Control)
			Try
				myControl.Focus()
				Me.ActiveControl = myControl
			Catch ex As Exception
			End Try
		End Sub

		Private Sub optCBDataType_5_EnabledChanged(sender As Object, e As EventArgs)
			Me.cmdCBApplet.Enabled = Me.optCBDataType_5.Enabled
		End Sub

		Private Sub SetCrankRotationCombo(CrankRotation As Short)
			If CrankRotation = 1S Then
				Me.cboCrankRotation.SelectedIndex = 0
				Return
			End If
			If CrankRotation = -1S Or CrankRotation = 0S Then
				Me.cboCrankRotation.SelectedIndex = 1
				Return
			End If
		End Sub

		Public Sub CenterForm()
			' The following expression was wrapped in a checked-statement
			Try
				If Me.MyParentFrm Is Nothing Then
					Me.MyParentFrm = New RODSTAR()
					Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
				End If
				Me.Left = CInt(Math.Round(CDbl((Me.MyParentFrm.Width - Me.Width)) / 2.0 - 8.0))
				Me.Top = CInt(Math.Round(CDbl((Me.MyParentFrm.Height - Me.Height)) / 2.0 - CDbl(Me.MyParentFrm.ParentToolbarHeight())))
			Catch ex As Exception
			End Try
		End Sub

		Private Function GetCustomPU(lvw As ListViewItem, ByRef PU As RSWIN_DESC.PUDataRec) As Integer
			Dim result As Integer = -1
			Dim num As Integer = 0
			Dim num2 As Integer = Information.UBound(Me.UnitData, 1)
			For i As Integer = num To num2
				Debug.WriteLine(lvw.Text.Trim() + "  ,  " + Me.UnitData(i).Manuf.Trim())
				If Operators.CompareString(lvw.Text.Trim(), Me.UnitData(i).Manuf.Trim(), False) = 0 AndAlso (Operators.CompareString(lvw.SubItems(0).Text.Trim(), Me.UnitData(i).APIDesignation.Trim(), False) = 0 Or Operators.CompareString(lvw.SubItems(1).Text.Trim(), Me.UnitData(i).APIDesignation.Trim(), False) = 0 Or Operators.CompareString(lvw.SubItems(2).Text.Trim(), Me.UnitData(i).APIDesignation.Trim(), False) = 0) AndAlso (Operators.CompareString(lvw.SubItems(0).Text.Trim(), Me.UnitData(i).UnitName.Trim(), False) = 0 Or Operators.CompareString(lvw.SubItems(1).Text.Trim(), Me.UnitData(i).UnitName.Trim(), False) = 0 Or Operators.CompareString(lvw.SubItems(2).Text.Trim(), Me.UnitData(i).UnitName.Trim(), False) = 0) Then
					result = i
					PU.Initialize()
					PU.Manuf = Me.UnitData(i).Manuf
					PU.APIDesignation = Me.UnitData(i).APIDesignation
					PU.UnitName = Me.UnitData(i).UnitName
					PU.OtherInfo = Me.UnitData(i).OtherInfo
					PU.UnitType = Me.UnitData(i).UnitType
					PU.RequiredRotation = Me.UnitData(i).RequiredRotation
					PU.CrankHoles = Me.UnitData(i).CrankHoles
					PU.CrankRadii(0) = Me.UnitData(i).CrankRadii(0)
					PU.CrankRadii(1) = Me.UnitData(i).CrankRadii(1)
					PU.CrankRadii(2) = Me.UnitData(i).CrankRadii(2)
					PU.CrankRadii(3) = Me.UnitData(i).CrankRadii(3)
					PU.CrankRadii(4) = Me.UnitData(i).CrankRadii(4)
					PU.Strokes(0) = Me.UnitData(i).Strokes(0)
					PU.Strokes(1) = Me.UnitData(i).Strokes(1)
					PU.Strokes(2) = Me.UnitData(i).Strokes(2)
					PU.Strokes(3) = Me.UnitData(i).Strokes(3)
					PU.Strokes(4) = Me.UnitData(i).Strokes(4)
					PU.FileRecord = Me.UnitData(i).FileRecord
					PU.KinematicStroke = Me.UnitData(i).KinematicStroke
					PU.R = Me.UnitData(i).R
					PU.A = Me.UnitData(i).A
					PU.C = Me.UnitData(i).C
					PU.I = Me.UnitData(i).I
					PU.K = Me.UnitData(i).K
					PU.P = Me.UnitData(i).P
					PU.M = Me.UnitData(i).M
					PU.S = Me.UnitData(i).S
					PU.V0 = Me.UnitData(i).V0
					PU.DrumDiamRatio = Me.UnitData(i).DrumDiamRatio
					PU.SprocketRadius = Me.UnitData(i).SprocketRadius
					PU.SprocketDistance = Me.UnitData(i).SprocketDistance
					PU.Unbalance = Me.UnitData(i).Unbalance
					PU.CrankOffset = Me.UnitData(i).CrankOffset
					PU.StructRating = Me.UnitData(i).StructRating
					PU.GearboxRating = Me.UnitData(i).GearboxRating
					PU.MaxStroke = Me.UnitData(i).MaxStroke
					PU.ArtInertia = Me.UnitData(i).ArtInertia
					Exit For
				End If
			Next
			Return result
		End Function

		Private Sub lvwUnitList_DoubleClick(sender As Object, e As EventArgs)
		End Sub

		Private Sub lvwUnitList_ItemActivate(sender As Object, e As EventArgs)
		End Sub

		Private Sub lvwUnitList_KeyDown(sender As Object, e As KeyEventArgs)
		End Sub

		Private Sub lvwUnitList_KeyUp(sender As Object, e As KeyEventArgs)
		End Sub

		Private Sub txtUnbalance_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtUnbalance As TextBox = Me.txtUnbalance
			Dim lblStructuralUnbalance As Label = Me.lblStructuralUnbalance
			CtrlUI.TextBox_KeyDown(txtUnbalance, lblStructuralUnbalance, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me.lblStructuralUnbalance = lblStructuralUnbalance
			Me.txtUnbalance = txtUnbalance
		End Sub

		Private Sub txtCounterbalance_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtCounterbalance As TextBox = Me.txtCounterbalance
			Dim lblMInLbs As Label = Me.lblMInLbs
			CtrlUI.TextBox_KeyDown(txtCounterbalance, lblMInLbs, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me.lblMInLbs = lblMInLbs
			Me.txtCounterbalance = txtCounterbalance
		End Sub

		Private Sub lblMInLbs_TextChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub SetCounterbalanceTag()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Select Case rst.PU.UnitType
				Case 6S
					Me.txtCounterbalance.Tag = "gee"
					Return
				Case 7S, 10S
					Me.txtCounterbalance.Tag = "lee"
					Return
			End Select
			Me.txtCounterbalance.Tag = "Lee"
		End Sub

		Private Sub SetUnbalanceVisible(bValue As Boolean)
			Me.txtUnbalance.Visible = bValue
			Me.lblStructuralUnbalance.Visible = bValue
			Me.lblStructuralUnbalance.Visible = bValue
		End Sub

		Private Sub TurnOffViewReportOption()
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
					RSWIN_DESC.rst.set_RequiredUnbalance(1, 0F)
					RSWIN_DESC.rst.set_RequiredUnbalance(0, 0F)
				Else
					RSWIN_DESC.rst.set_M(1, 0F)
					RSWIN_DESC.rst.set_M(0, 0F)
				End If
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
				Return
			End If
		End Sub

		Private Sub PopulateRecPUFGAL_Rotaflex()
			Try
				Me.table_1000_fg.Clear()
				Me.table_1000_fg.Add(New cRecPU(2800, 228, 300, 288))
				Me.table_2000_fg.Clear()
				Me.table_2000_fg.Add(New cRecPU(2000, 228, 300, 288))
				Me.table_3000_fg.Clear()
				Me.table_3000_fg.Add(New cRecPU(1600, 228, 300, 288))
				Me.table_3000_fg.Add(New cRecPU(1900, 320, 500, 366))
				Me.table_3500_fg.Clear()
				Me.table_3500_fg.Add(New cRecPU(1500, 228, 300, 288))
				Me.table_3500_fg.Add(New cRecPU(1600, 320, 500, 366))
				Me.table_4000_fg.Clear()
				Me.table_4000_fg.Add(New cRecPU(1200, 228, 300, 288))
				Me.table_4000_fg.Add(New cRecPU(1500, 320, 500, 366))
				Me.table_4500_fg.Clear()
				Me.table_4500_fg.Add(New cRecPU(1200, 228, 300, 288))
				Me.table_5000_fg.Clear()
				Me.table_5000_fg.Add(New cRecPU(1000, 228, 300, 288))
				Me.table_5000_fg.Add(New cRecPU(1200, 320, 500, 366))
				Me.table_5500_fg.Clear()
				Me.table_5500_fg.Add(New cRecPU(600, 228, 300, 288))
				Me.table_5500_fg.Add(New cRecPU(800, 320, 360, 288))
				Me.table_5500_fg.Add(New cRecPU(1100, 320, 500, 366))
				Me.table_6000_fg.Clear()
				Me.table_6000_fg.Add(New cRecPU(500, 228, 300, 288))
				Me.table_6000_fg.Add(New cRecPU(900, 320, 500, 366))
				Me.table_6500_fg.Clear()
				Me.table_6500_fg.Add(New cRecPU(500, 228, 300, 288))
				Me.table_6500_fg.Add(New cRecPU(700, 320, 360, 288))
				Me.table_6500_fg.Add(New cRecPU(900, 320, 500, 366))
				Me.table_7000_fg.Clear()
				Me.table_7000_fg.Add(New cRecPU(400, 228, 300, 288))
				Me.table_7000_fg.Add(New cRecPU(600, 320, 360, 288))
				Me.table_7000_fg.Add(New cRecPU(700, 320, 500, 306))
				Me.table_7000_fg.Add(New cRecPU(900, 320, 500, 366))
				Me.table_7500_fg.Clear()
				Me.table_7500_fg.Add(New cRecPU(400, 228, 300, 288))
				Me.table_7500_fg.Add(New cRecPU(550, 320, 360, 288))
				Me.table_7500_fg.Add(New cRecPU(600, 320, 500, 306))
				Me.table_7500_fg.Add(New cRecPU(800, 320, 500, 366))
				Me.table_8000_fg.Clear()
				Me.table_8000_fg.Add(New cRecPU(400, 228, 300, 288))
				Me.table_8000_fg.Add(New cRecPU(500, 320, 360, 288))
				Me.table_8000_fg.Add(New cRecPU(700, 320, 500, 366))
				Me.table_8500_fg.Clear()
				Me.table_8500_fg.Add(New cRecPU(200, 228, 300, 288))
				Me.table_8500_fg.Add(New cRecPU(400, 320, 360, 288))
				Me.table_8500_fg.Add(New cRecPU(500, 320, 500, 306))
				Me.table_8500_fg.Add(New cRecPU(650, 320, 500, 366))
				Me.table_9000_fg.Clear()
				Me.table_9000_fg.Add(New cRecPU(200, 228, 300, 288))
				Me.table_9000_fg.Add(New cRecPU(400, 320, 360, 288))
				Me.table_9000_fg.Add(New cRecPU(650, 320, 500, 366))
				Me.table_9500_fg.Clear()
				Me.table_9500_fg.Add(New cRecPU(300, 228, 300, 288))
				Me.table_9500_fg.Add(New cRecPU(400, 320, 500, 306))
				Me.table_9500_fg.Add(New cRecPU(500, 320, 500, 366))
				Me.table_10000_fg.Clear()
				Me.table_10000_fg.Add(New cRecPU(300, 320, 360, 288))
				Me.table_10000_fg.Add(New cRecPU(500, 320, 500, 366))
				Me.table_10500_fg.Clear()
				Me.table_10500_fg.Add(New cRecPU(200, 228, 300, 288))
				Me.table_10500_fg.Add(New cRecPU(300, 320, 500, 306))
				Me.table_10500_fg.Add(New cRecPU(450, 320, 500, 366))
				Me.table_11000_fg.Clear()
				Me.table_11000_fg.Add(New cRecPU(250, 320, 360, 288))
				Me.table_11000_fg.Add(New cRecPU(300, 320, 500, 306))
				Me.table_11000_fg.Add(New cRecPU(375, 320, 500, 366))
				Me.table_11500_fg.Clear()
				Me.table_11500_fg.Add(New cRecPU(200, 320, 360, 288))
				Me.table_11500_fg.Add(New cRecPU(250, 320, 500, 306))
				Me.table_11500_fg.Add(New cRecPU(350, 320, 500, 366))
				Me.table_12000_fg.Clear()
				Me.table_12000_fg.Add(New cRecPU(250, 320, 500, 306))
				Me.table_12000_fg.Add(New cRecPU(350, 320, 500, 366))
				Me.table_12500_fg.Clear()
				Me.table_12500_fg.Add(New cRecPU(250, 320, 500, 306))
				Me.table_12500_fg.Add(New cRecPU(325, 320, 500, 366))
				Me.table_13000_fg.Clear()
				Me.table_13000_fg.Add(New cRecPU(250, 320, 500, 306))
				Me.table_13000_fg.Add(New cRecPU(275, 320, 500, 366))
				Me.table_13500_fg.Clear()
				Me.table_13500_fg.Add(New cRecPU(200, 320, 500, 306))
				Me.table_13500_fg.Add(New cRecPU(275, 320, 500, 366))
				Me.table_14000_fg.Clear()
				Me.table_14000_fg.Add(New cRecPU(200, 320, 500, 306))
				Me.table_14000_fg.Add(New cRecPU(250, 320, 500, 366))
				Me.table_14500_fg.Clear()
				Me.table_14500_fg.Add(New cRecPU(200, 320, 500, 306))
				Me.table_14500_fg.Add(New cRecPU(250, 320, 500, 366))
				Me.table_15000_fg.Clear()
				Me.table_15000_fg.Add(New cRecPU(200, 320, 500, 306))
				Me.table_15500_fg.Clear()
				Me.table_15500_fg.Add(New cRecPU(150, 320, 500, 306))
				Me.table_15500_fg.Add(New cRecPU(200, 320, 500, 366))
				Me.table_16000_fg.Clear()
				Me.table_16000_fg.Add(New cRecPU(175, 320, 500, 306))
				Me.table_16500_fg.Clear()
				Me.table_16500_fg.Add(New cRecPU(150, 320, 500, 306))
				Me.table_17000_fg.Clear()
				Me.table_17000_fg.Add(New cRecPU(150, 320, 500, 306))
				Me.table_17500_fg.Clear()
				Me.table_17500_fg.Add(New cRecPU(125, 320, 500, 306))
				Me.table_18000_fg.Clear()
				Me.table_18000_fg.Add(New cRecPU(100, 320, 500, 306))
				Me.table_18500_fg.Clear()
				Me.table_18500_fg.Add(New cRecPU(100, 320, 500, 306))
				Me.table_19000_fg.Clear()
				Me.table_19000_fg.Add(New cRecPU(100, 320, 360, 288))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUSTAL_Rotaflex()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(3400, 228, 300, 288))
				Me.table_1000_st.Add(New cRecPU(3600, 320, 500, 306))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(2800, 228, 300, 288))
				Me.table_2000_st.Add(New cRecPU(3600, 320, 360, 288))
				Me.table_2000_st.Add(New cRecPU(3800, 320, 500, 306))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(1600, 228, 300, 288))
				Me.table_3000_st.Add(New cRecPU(2200, 320, 360, 288))
				Me.table_3000_st.Add(New cRecPU(3000, 320, 500, 306))
				Me.table_3000_st.Add(New cRecPU(3800, 420, 500, 366))
				Me.table_3500_st.Clear()
				Me.table_3500_st.Add(New cRecPU(1400, 228, 300, 288))
				Me.table_3500_st.Add(New cRecPU(1800, 320, 360, 288))
				Me.table_3500_st.Add(New cRecPU(2000, 320, 500, 306))
				Me.table_3500_st.Add(New cRecPU(3600, 420, 500, 366))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(1200, 228, 300, 288))
				Me.table_4000_st.Add(New cRecPU(1800, 320, 360, 288))
				Me.table_4000_st.Add(New cRecPU(2000, 320, 500, 306))
				Me.table_4000_st.Add(New cRecPU(2200, 320, 500, 366))
				Me.table_4000_st.Add(New cRecPU(3000, 420, 500, 366))
				Me.table_4500_st.Clear()
				Me.table_4500_st.Add(New cRecPU(1000, 228, 300, 288))
				Me.table_4500_st.Add(New cRecPU(1200, 320, 360, 288))
				Me.table_4500_st.Add(New cRecPU(1800, 320, 500, 306))
				Me.table_4500_st.Add(New cRecPU(2100, 320, 500, 366))
				Me.table_4500_st.Add(New cRecPU(2300, 420, 500, 366))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(900, 228, 300, 288))
				Me.table_5000_st.Add(New cRecPU(1200, 320, 360, 288))
				Me.table_5000_st.Add(New cRecPU(1500, 320, 500, 306))
				Me.table_5000_st.Add(New cRecPU(2000, 320, 500, 366))
				Me.table_5000_st.Add(New cRecPU(2100, 420, 500, 366))
				Me.table_5500_st.Clear()
				Me.table_5500_st.Add(New cRecPU(700, 228, 300, 288))
				Me.table_5500_st.Add(New cRecPU(900, 320, 360, 288))
				Me.table_5500_st.Add(New cRecPU(1200, 320, 500, 306))
				Me.table_5500_st.Add(New cRecPU(1500, 420, 500, 366))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(600, 228, 300, 288))
				Me.table_6000_st.Add(New cRecPU(850, 320, 360, 288))
				Me.table_6000_st.Add(New cRecPU(1100, 320, 500, 306))
				Me.table_6000_st.Add(New cRecPU(1400, 320, 500, 366))
				Me.table_6500_st.Clear()
				Me.table_6500_st.Add(New cRecPU(500, 228, 300, 288))
				Me.table_6500_st.Add(New cRecPU(700, 320, 360, 288))
				Me.table_6500_st.Add(New cRecPU(900, 320, 500, 306))
				Me.table_6500_st.Add(New cRecPU(1100, 320, 500, 366))
				Me.table_6500_st.Add(New cRecPU(1200, 420, 500, 366))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(400, 228, 300, 288))
				Me.table_7000_st.Add(New cRecPU(500, 320, 360, 288))
				Me.table_7000_st.Add(New cRecPU(900, 320, 500, 306))
				Me.table_7000_st.Add(New cRecPU(950, 320, 500, 366))
				Me.table_7000_st.Add(New cRecPU(1050, 420, 500, 366))
				Me.table_7500_st.Clear()
				Me.table_7500_st.Add(New cRecPU(400, 228, 300, 288))
				Me.table_7500_st.Add(New cRecPU(550, 320, 360, 288))
				Me.table_7500_st.Add(New cRecPU(900, 320, 500, 306))
				Me.table_7500_st.Add(New cRecPU(1000, 320, 500, 366))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(400, 228, 300, 288))
				Me.table_8000_st.Add(New cRecPU(750, 320, 500, 306))
				Me.table_8000_st.Add(New cRecPU(850, 420, 500, 366))
				Me.table_8500_st.Clear()
				Me.table_8500_st.Add(New cRecPU(350, 228, 300, 288))
				Me.table_8500_st.Add(New cRecPU(450, 320, 360, 288))
				Me.table_8500_st.Add(New cRecPU(750, 320, 500, 306))
				Me.table_8500_st.Add(New cRecPU(800, 320, 500, 366))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(300, 228, 300, 288))
				Me.table_9000_st.Add(New cRecPU(400, 320, 360, 288))
				Me.table_9000_st.Add(New cRecPU(700, 320, 500, 306))
				Me.table_9000_st.Add(New cRecPU(750, 320, 500, 366))
				Me.table_9500_st.Clear()
				Me.table_9500_st.Add(New cRecPU(300, 228, 300, 288))
				Me.table_9500_st.Add(New cRecPU(550, 320, 500, 306))
				Me.table_9500_st.Add(New cRecPU(600, 320, 500, 366))
				Me.table_9500_st.Add(New cRecPU(625, 420, 500, 366))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(200, 228, 300, 288))
				Me.table_10000_st.Add(New cRecPU(300, 320, 360, 288))
				Me.table_10000_st.Add(New cRecPU(500, 320, 500, 306))
				Me.table_10000_st.Add(New cRecPU(600, 320, 500, 366))
				Me.table_10500_st.Clear()
				Me.table_10500_st.Add(New cRecPU(200, 228, 300, 288))
				Me.table_10500_st.Add(New cRecPU(450, 320, 500, 306))
				Me.table_10500_st.Add(New cRecPU(575, 320, 500, 366))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(250, 320, 360, 288))
				Me.table_11000_st.Add(New cRecPU(350, 320, 500, 306))
				Me.table_11000_st.Add(New cRecPU(500, 320, 500, 366))
				Me.table_11500_st.Clear()
				Me.table_11500_st.Add(New cRecPU(400, 320, 500, 306))
				Me.table_11500_st.Add(New cRecPU(450, 320, 500, 366))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(350, 320, 500, 306))
				Me.table_12000_st.Add(New cRecPU(425, 320, 500, 366))
				Me.table_12500_st.Clear()
				Me.table_12500_st.Add(New cRecPU(300, 320, 500, 306))
				Me.table_12500_st.Add(New cRecPU(350, 320, 500, 366))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(275, 320, 500, 306))
				Me.table_13000_st.Add(New cRecPU(350, 320, 500, 366))
				Me.table_13500_st.Clear()
				Me.table_13500_st.Add(New cRecPU(275, 320, 500, 306))
				Me.table_13500_st.Add(New cRecPU(300, 320, 500, 366))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(200, 320, 500, 306))
				Me.table_14000_st.Add(New cRecPU(250, 320, 500, 366))
				Me.table_14500_st.Clear()
				Me.table_14500_st.Add(New cRecPU(200, 320, 500, 306))
				Me.table_14500_st.Add(New cRecPU(250, 320, 500, 366))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(200, 320, 500, 306))
				Me.table_15000_st.Add(New cRecPU(225, 320, 500, 366))
				Me.table_15500_st.Clear()
				Me.table_15500_st.Add(New cRecPU(150, 320, 500, 306))
				Me.table_15500_st.Add(New cRecPU(160, 320, 500, 366))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(125, 320, 500, 306))
				Me.table_16000_st.Add(New cRecPU(150, 320, 500, 366))
				Me.table_16500_st.Clear()
				Me.table_16500_st.Add(New cRecPU(125, 320, 500, 306))
				Me.table_17000_st.Clear()
				Me.table_17000_st.Add(New cRecPU(100, 320, 500, 306))
				Me.table_17500_st.Clear()
				Me.table_17500_st.Add(New cRecPU(50, 320, 500, 306))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUSTAL_Rotaflex_old()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(3400, 228, 300, 288))
				Me.table_1000_st.Add(New cRecPU(3600, 320, 500, 306))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(2800, 228, 300, 288))
				Me.table_2000_st.Add(New cRecPU(3600, 320, 360, 288))
				Me.table_2000_st.Add(New cRecPU(3800, 320, 500, 306))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(1600, 228, 300, 288))
				Me.table_3000_st.Add(New cRecPU(2200, 320, 360, 288))
				Me.table_3000_st.Add(New cRecPU(3000, 320, 500, 306))
				Me.table_3000_st.Add(New cRecPU(3800, 420, 500, 366))
				Me.table_3500_st.Clear()
				Me.table_3500_st.Add(New cRecPU(1400, 228, 300, 288))
				Me.table_3500_st.Add(New cRecPU(1800, 320, 360, 288))
				Me.table_3500_st.Add(New cRecPU(2000, 320, 500, 306))
				Me.table_3500_st.Add(New cRecPU(3600, 420, 500, 366))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(1200, 228, 300, 288))
				Me.table_4000_st.Add(New cRecPU(1800, 320, 360, 288))
				Me.table_4000_st.Add(New cRecPU(2000, 320, 500, 306))
				Me.table_4000_st.Add(New cRecPU(2200, 320, 500, 366))
				Me.table_4000_st.Add(New cRecPU(3000, 420, 500, 366))
				Me.table_4500_st.Clear()
				Me.table_4500_st.Add(New cRecPU(1000, 228, 300, 288))
				Me.table_4500_st.Add(New cRecPU(1200, 320, 360, 288))
				Me.table_4500_st.Add(New cRecPU(1800, 320, 500, 306))
				Me.table_4500_st.Add(New cRecPU(2100, 320, 500, 366))
				Me.table_4500_st.Add(New cRecPU(2300, 420, 500, 366))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(900, 228, 300, 288))
				Me.table_5000_st.Add(New cRecPU(1200, 320, 360, 288))
				Me.table_5000_st.Add(New cRecPU(1500, 320, 500, 306))
				Me.table_5000_st.Add(New cRecPU(2000, 320, 500, 366))
				Me.table_5000_st.Add(New cRecPU(2100, 420, 500, 366))
				Me.table_5500_st.Clear()
				Me.table_5500_st.Add(New cRecPU(700, 228, 300, 288))
				Me.table_5500_st.Add(New cRecPU(900, 320, 360, 288))
				Me.table_5500_st.Add(New cRecPU(1200, 320, 500, 306))
				Me.table_5500_st.Add(New cRecPU(1500, 420, 500, 366))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(600, 228, 300, 288))
				Me.table_6000_st.Add(New cRecPU(850, 320, 360, 288))
				Me.table_6000_st.Add(New cRecPU(1100, 320, 500, 306))
				Me.table_6000_st.Add(New cRecPU(1400, 320, 500, 366))
				Me.table_6500_st.Clear()
				Me.table_6500_st.Add(New cRecPU(500, 228, 300, 288))
				Me.table_6500_st.Add(New cRecPU(700, 320, 360, 288))
				Me.table_6500_st.Add(New cRecPU(900, 320, 500, 306))
				Me.table_6500_st.Add(New cRecPU(1100, 320, 500, 366))
				Me.table_6500_st.Add(New cRecPU(1200, 420, 500, 366))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(400, 228, 300, 288))
				Me.table_7000_st.Add(New cRecPU(500, 320, 360, 288))
				Me.table_7000_st.Add(New cRecPU(900, 320, 500, 306))
				Me.table_7000_st.Add(New cRecPU(950, 320, 500, 366))
				Me.table_7000_st.Add(New cRecPU(1050, 420, 500, 366))
				Me.table_7500_st.Clear()
				Me.table_7500_st.Add(New cRecPU(400, 228, 300, 288))
				Me.table_7500_st.Add(New cRecPU(550, 320, 360, 288))
				Me.table_7500_st.Add(New cRecPU(900, 320, 500, 306))
				Me.table_7500_st.Add(New cRecPU(1000, 320, 500, 366))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(400, 228, 300, 288))
				Me.table_8000_st.Add(New cRecPU(750, 320, 500, 306))
				Me.table_8000_st.Add(New cRecPU(850, 420, 500, 366))
				Me.table_8500_st.Clear()
				Me.table_8500_st.Add(New cRecPU(350, 228, 300, 288))
				Me.table_8500_st.Add(New cRecPU(450, 320, 360, 288))
				Me.table_8500_st.Add(New cRecPU(750, 320, 500, 306))
				Me.table_8500_st.Add(New cRecPU(800, 320, 500, 366))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(300, 228, 300, 288))
				Me.table_9000_st.Add(New cRecPU(400, 320, 360, 288))
				Me.table_9000_st.Add(New cRecPU(700, 320, 500, 306))
				Me.table_9000_st.Add(New cRecPU(750, 320, 500, 366))
				Me.table_9500_st.Clear()
				Me.table_9500_st.Add(New cRecPU(300, 228, 300, 288))
				Me.table_9500_st.Add(New cRecPU(550, 320, 500, 306))
				Me.table_9500_st.Add(New cRecPU(600, 320, 500, 366))
				Me.table_9500_st.Add(New cRecPU(625, 420, 500, 366))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(200, 228, 300, 288))
				Me.table_10000_st.Add(New cRecPU(300, 320, 360, 288))
				Me.table_10000_st.Add(New cRecPU(500, 320, 500, 306))
				Me.table_10000_st.Add(New cRecPU(600, 320, 500, 366))
				Me.table_10500_st.Clear()
				Me.table_10500_st.Add(New cRecPU(200, 228, 300, 288))
				Me.table_10500_st.Add(New cRecPU(450, 320, 500, 306))
				Me.table_10500_st.Add(New cRecPU(575, 320, 500, 366))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(250, 320, 360, 288))
				Me.table_11000_st.Add(New cRecPU(350, 320, 500, 306))
				Me.table_11000_st.Add(New cRecPU(500, 320, 500, 366))
				Me.table_11500_st.Clear()
				Me.table_11500_st.Add(New cRecPU(400, 320, 500, 306))
				Me.table_11500_st.Add(New cRecPU(450, 320, 500, 366))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(350, 320, 500, 306))
				Me.table_12000_st.Add(New cRecPU(425, 320, 500, 366))
				Me.table_12500_st.Clear()
				Me.table_12500_st.Add(New cRecPU(300, 320, 500, 306))
				Me.table_12500_st.Add(New cRecPU(350, 320, 500, 366))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(275, 320, 500, 306))
				Me.table_13000_st.Add(New cRecPU(350, 320, 500, 366))
				Me.table_13500_st.Clear()
				Me.table_13500_st.Add(New cRecPU(275, 320, 500, 306))
				Me.table_13500_st.Add(New cRecPU(300, 320, 500, 366))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(200, 320, 500, 306))
				Me.table_14000_st.Add(New cRecPU(250, 320, 500, 366))
				Me.table_14500_st.Clear()
				Me.table_14500_st.Add(New cRecPU(200, 320, 500, 306))
				Me.table_14500_st.Add(New cRecPU(250, 320, 500, 366))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(200, 320, 500, 306))
				Me.table_15000_st.Add(New cRecPU(225, 320, 500, 366))
				Me.table_15500_st.Clear()
				Me.table_15500_st.Add(New cRecPU(150, 320, 500, 306))
				Me.table_15500_st.Add(New cRecPU(160, 320, 500, 366))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(125, 320, 500, 306))
				Me.table_16000_st.Add(New cRecPU(150, 320, 500, 366))
				Me.table_16500_st.Clear()
				Me.table_16500_st.Add(New cRecPU(125, 320, 500, 306))
				Me.table_17000_st.Clear()
				Me.table_17000_st.Add(New cRecPU(100, 320, 500, 306))
				Me.table_17500_st.Clear()
				Me.table_17500_st.Add(New cRecPU(50, 320, 500, 306))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUSTAL_MarkII()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(50, 25, 35, 52))
				Me.table_1000_st.Add(New cRecPU(150, 35, 35, 64))
				Me.table_1000_st.Add(New cRecPU(250, 45, 45, 64))
				Me.table_1000_st.Add(New cRecPU(300, 47, 46, 64))
				Me.table_1000_st.Add(New cRecPU(350, 47, 50, 64))
				Me.table_1000_st.Add(New cRecPU(400, 60, 54, 64))
				Me.table_1000_st.Add(New cRecPU(500, 65, 58, 64))
				Me.table_1000_st.Add(New cRecPU(600, 65, 62, 64))
				Me.table_1000_st.Add(New cRecPU(700, 80, 72, 64))
				Me.table_1000_st.Add(New cRecPU(800, 114, 90, 64))
				Me.table_1000_st.Add(New cRecPU(900, 114, 95, 64))
				Me.table_1000_st.Add(New cRecPU(950, 114, 100, 74))
				Me.table_1000_st.Add(New cRecPU(1100, 160, 100, 74))
				Me.table_1000_st.Add(New cRecPU(1200, 160, 100, 86))
				Me.table_1000_st.Add(New cRecPU(1400, 228, 119, 100))
				Me.table_1000_st.Add(New cRecPU(1600, 228, 119, 120))
				Me.table_1000_st.Add(New cRecPU(1700, 320, 119, 144))
				Me.table_1000_st.Add(New cRecPU(1900, 456, 119, 168))
				Me.table_1000_st.Add(New cRecPU(2000, 640, 125, 192))
				Me.table_1000_st.Add(New cRecPU(2100, 640, 140, 192))
				Me.table_1000_st.Add(New cRecPU(2200, 640, 140, 216))
				Me.table_1000_st.Add(New cRecPU(2800, 912, 145, 216))
				Me.table_1000_st.Add(New cRecPU(3000, 912, 170, 216))
				Me.table_1000_st.Add(New cRecPU(3100, 912, 180, 216))
				Me.table_1000_st.Add(New cRecPU(3300, 1280, 200, 216))
				Me.table_1000_st.Add(New cRecPU(3500, 1280, 210, 216))
				Me.table_1500_st.Clear()
				Me.table_1500_st.Add(New cRecPU(50, 37, 40, 64))
				Me.table_1500_st.Add(New cRecPU(100, 44, 47, 64))
				Me.table_1500_st.Add(New cRecPU(150, 50, 52, 64))
				Me.table_1500_st.Add(New cRecPU(200, 57, 56, 64))
				Me.table_1500_st.Add(New cRecPU(250, 62, 66, 64))
				Me.table_1500_st.Add(New cRecPU(350, 80, 75, 64))
				Me.table_1500_st.Add(New cRecPU(400, 114, 75, 74))
				Me.table_1500_st.Add(New cRecPU(500, 114, 80, 86))
				Me.table_1500_st.Add(New cRecPU(550, 160, 80, 100))
				Me.table_1500_st.Add(New cRecPU(650, 160, 90, 100))
				Me.table_1500_st.Add(New cRecPU(700, 228, 90, 120))
				Me.table_1500_st.Add(New cRecPU(800, 228, 100, 120))
				Me.table_1500_st.Add(New cRecPU(850, 228, 119, 120))
				Me.table_1500_st.Add(New cRecPU(950, 320, 119, 120))
				Me.table_1500_st.Add(New cRecPU(1000, 320, 125, 144))
				Me.table_1500_st.Add(New cRecPU(1200, 456, 130, 144))
				Me.table_1500_st.Add(New cRecPU(1400, 640, 150, 168))
				Me.table_1500_st.Add(New cRecPU(1800, 640, 160, 192))
				Me.table_1500_st.Add(New cRecPU(2000, 912, 160, 216))
				Me.table_1500_st.Add(New cRecPU(2300, 1280, 200, 216))
				Me.table_1500_st.Add(New cRecPU(2400, 1280, 210, 216))
				Me.table_1500_st.Add(New cRecPU(2900, 1280, 240, 216))
				Me.table_1500_st.Add(New cRecPU(3100, 1280, 250, 216))
				Me.table_1500_st.Add(New cRecPU(3300, 1280, 260, 216))
				Me.table_1500_st.Add(New cRecPU(3500, 1280, 305, 216))
				Me.table_1500_st.Add(New cRecPU(3700, 1824, 305, 216))
				Me.table_1500_st.Add(New cRecPU(4500, 1824, 356, 216))
				Me.table_1500_st.Add(New cRecPU(4700, 1824, 427, 216))
				Me.table_1500_st.Add(New cRecPU(5000, 1824, 427, 216))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(50, 37, 56, 52))
				Me.table_2000_st.Add(New cRecPU(100, 45, 64, 52))
				Me.table_2000_st.Add(New cRecPU(150, 50, 76, 52))
				Me.table_2000_st.Add(New cRecPU(200, 65, 86, 52))
				Me.table_2000_st.Add(New cRecPU(250, 80, 90, 64))
				Me.table_2000_st.Add(New cRecPU(300, 114, 95, 74))
				Me.table_2000_st.Add(New cRecPU(350, 114, 100, 74))
				Me.table_2000_st.Add(New cRecPU(450, 114, 143, 74))
				Me.table_2000_st.Add(New cRecPU(600, 160, 143, 74))
				Me.table_2000_st.Add(New cRecPU(650, 160, 173, 74))
				Me.table_2000_st.Add(New cRecPU(700, 228, 173, 100))
				Me.table_2000_st.Add(New cRecPU(900, 320, 173, 120))
				Me.table_2000_st.Add(New cRecPU(1100, 456, 173, 144))
				Me.table_2000_st.Add(New cRecPU(1100, 456, 173, 144))
				Me.table_2000_st.Add(New cRecPU(1300, 640, 200, 168))
				Me.table_2000_st.Add(New cRecPU(1700, 912, 200, 192))
				Me.table_2000_st.Add(New cRecPU(1800, 912, 200, 216))
				Me.table_2000_st.Add(New cRecPU(2050, 1280, 253, 192))
				Me.table_2000_st.Add(New cRecPU(2100, 1280, 305, 192))
				Me.table_2000_st.Add(New cRecPU(2400, 1280, 305, 216))
				Me.table_2000_st.Add(New cRecPU(2900, 1824, 305, 216))
				Me.table_2000_st.Add(New cRecPU(3200, 1824, 356, 216))
				Me.table_2000_st.Add(New cRecPU(3700, 1824, 427, 216))
				Me.table_2500_st.Clear()
				Me.table_2500_st.Add(New cRecPU(50, 40, 65, 52))
				Me.table_2500_st.Add(New cRecPU(100, 50, 80, 52))
				Me.table_2500_st.Add(New cRecPU(150, 65, 100, 52))
				Me.table_2500_st.Add(New cRecPU(200, 85, 100, 64))
				Me.table_2500_st.Add(New cRecPU(250, 114, 143, 64))
				Me.table_2500_st.Add(New cRecPU(300, 160, 143, 74))
				Me.table_2500_st.Add(New cRecPU(450, 160, 173, 74))
				Me.table_2500_st.Add(New cRecPU(550, 228, 173, 74))
				Me.table_2500_st.Add(New cRecPU(600, 228, 200, 86))
				Me.table_2500_st.Add(New cRecPU(650, 228, 213, 86))
				Me.table_2500_st.Add(New cRecPU(700, 320, 200, 100))
				Me.table_2500_st.Add(New cRecPU(750, 320, 200, 120))
				Me.table_2500_st.Add(New cRecPU(800, 456, 200, 144))
				Me.table_2500_st.Add(New cRecPU(1000, 640, 220, 144))
				Me.table_2500_st.Add(New cRecPU(1200, 640, 246, 168))
				Me.table_2500_st.Add(New cRecPU(1300, 912, 245, 168))
				Me.table_2500_st.Add(New cRecPU(1400, 912, 245, 192))
				Me.table_2500_st.Add(New cRecPU(1500, 912, 253, 192))
				Me.table_2500_st.Add(New cRecPU(1700, 1280, 253, 216))
				Me.table_2500_st.Add(New cRecPU(1900, 1280, 305, 216))
				Me.table_2500_st.Add(New cRecPU(2000, 1824, 305, 216))
				Me.table_2500_st.Add(New cRecPU(2200, 1824, 346, 216))
				Me.table_2500_st.Add(New cRecPU(2900, 1824, 427, 216))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(50, 40, 80, 40))
				Me.table_3000_st.Add(New cRecPU(100, 50, 80, 52))
				Me.table_3000_st.Add(New cRecPU(150, 90, 119, 52))
				Me.table_3000_st.Add(New cRecPU(200, 114, 143, 64))
				Me.table_3000_st.Add(New cRecPU(250, 160, 143, 74))
				Me.table_3000_st.Add(New cRecPU(400, 160, 173, 74))
				Me.table_3000_st.Add(New cRecPU(450, 228, 200, 84))
				Me.table_3000_st.Add(New cRecPU(600, 320, 200, 100))
				Me.table_3000_st.Add(New cRecPU(750, 456, 256, 120))
				Me.table_3000_st.Add(New cRecPU(800, 640, 256, 120))
				Me.table_3000_st.Add(New cRecPU(1000, 640, 256, 144))
				Me.table_3000_st.Add(New cRecPU(1200, 912, 305, 168))
				Me.table_3000_st.Add(New cRecPU(1500, 1280, 305, 192))
				Me.table_3000_st.Add(New cRecPU(1600, 1280, 356, 216))
				Me.table_3000_st.Add(New cRecPU(1800, 1824, 356, 216))
				Me.table_3000_st.Add(New cRecPU(2500, 1824, 427, 216))
				Me.table_3500_st.Clear()
				Me.table_3500_st.Add(New cRecPU(50, 55, 90, 52))
				Me.table_3500_st.Add(New cRecPU(100, 80, 119, 52))
				Me.table_3500_st.Add(New cRecPU(200, 114, 143, 52))
				Me.table_3500_st.Add(New cRecPU(250, 160, 173, 74))
				Me.table_3500_st.Add(New cRecPU(300, 228, 173, 74))
				Me.table_3500_st.Add(New cRecPU(350, 320, 173, 100))
				Me.table_3500_st.Add(New cRecPU(450, 320, 256, 100))
				Me.table_3500_st.Add(New cRecPU(650, 456, 256, 120))
				Me.table_3500_st.Add(New cRecPU(850, 640, 305, 120))
				Me.table_3500_st.Add(New cRecPU(900, 912, 305, 144))
				Me.table_3500_st.Add(New cRecPU(1200, 912, 356, 144))
				Me.table_3500_st.Add(New cRecPU(1400, 1280, 427, 192))
				Me.table_3500_st.Add(New cRecPU(2000, 1824, 427, 216))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(50, 55, 119, 52))
				Me.table_4000_st.Add(New cRecPU(100, 85, 143, 52))
				Me.table_4000_st.Add(New cRecPU(150, 114, 169, 64))
				Me.table_4000_st.Add(New cRecPU(200, 160, 173, 74))
				Me.table_4000_st.Add(New cRecPU(250, 228, 173, 74))
				Me.table_4000_st.Add(New cRecPU(300, 228, 200, 74))
				Me.table_4000_st.Add(New cRecPU(325, 320, 256, 100))
				Me.table_4000_st.Add(New cRecPU(400, 320, 200, 100))
				Me.table_4000_st.Add(New cRecPU(450, 456, 200, 120))
				Me.table_4000_st.Add(New cRecPU(500, 640, 253, 144))
				Me.table_4000_st.Add(New cRecPU(650, 640, 256, 144))
				Me.table_4000_st.Add(New cRecPU(700, 640, 305, 168))
				Me.table_4000_st.Add(New cRecPU(900, 912, 305, 192))
				Me.table_4000_st.Add(New cRecPU(1000, 1280, 305, 216))
				Me.table_4000_st.Add(New cRecPU(1450, 1824, 427, 216))
				Me.table_4000_st.Add(New cRecPU(1700, 1824, 470, 216))
				Me.table_4500_st.Clear()
				Me.table_4500_st.Add(New cRecPU(50, 70, 119, 52))
				Me.table_4500_st.Add(New cRecPU(100, 80, 143, 52))
				Me.table_4500_st.Add(New cRecPU(125, 114, 169, 52))
				Me.table_4500_st.Add(New cRecPU(150, 160, 173, 74))
				Me.table_4500_st.Add(New cRecPU(200, 160, 200, 74))
				Me.table_4500_st.Add(New cRecPU(250, 228, 246, 74))
				Me.table_4500_st.Add(New cRecPU(260, 228, 246, 86))
				Me.table_4500_st.Add(New cRecPU(300, 320, 256, 100))
				Me.table_4500_st.Add(New cRecPU(400, 456, 256, 120))
				Me.table_4500_st.Add(New cRecPU(550, 640, 256, 144))
				Me.table_4500_st.Add(New cRecPU(650, 912, 305, 168))
				Me.table_4500_st.Add(New cRecPU(700, 1280, 305, 192))
				Me.table_4500_st.Add(New cRecPU(750, 1280, 305, 216))
				Me.table_4500_st.Add(New cRecPU(1300, 1824, 427, 216))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(50, 80, 143, 52))
				Me.table_5000_st.Add(New cRecPU(75, 114, 173, 64))
				Me.table_5000_st.Add(New cRecPU(150, 160, 173, 74))
				Me.table_5000_st.Add(New cRecPU(200, 228, 173, 74))
				Me.table_5000_st.Add(New cRecPU(250, 320, 200, 100))
				Me.table_5000_st.Add(New cRecPU(275, 320, 256, 100))
				Me.table_5000_st.Add(New cRecPU(350, 456, 256, 100))
				Me.table_5000_st.Add(New cRecPU(400, 456, 256, 120))
				Me.table_5000_st.Add(New cRecPU(425, 456, 305, 120))
				Me.table_5000_st.Add(New cRecPU(500, 640, 305, 100))
				Me.table_5000_st.Add(New cRecPU(550, 640, 365, 120))
				Me.table_5000_st.Add(New cRecPU(600, 912, 356, 144))
				Me.table_5000_st.Add(New cRecPU(700, 1280, 427, 192))
				Me.table_5000_st.Add(New cRecPU(1200, 1824, 427, 216))
				Me.table_5500_st.Clear()
				Me.table_5500_st.Add(New cRecPU(50, 114, 143, 64))
				Me.table_5500_st.Add(New cRecPU(150, 160, 200, 74))
				Me.table_5500_st.Add(New cRecPU(175, 228, 246, 86))
				Me.table_5500_st.Add(New cRecPU(250, 320, 256, 100))
				Me.table_5500_st.Add(New cRecPU(350, 456, 256, 120))
				Me.table_5500_st.Add(New cRecPU(400, 640, 305, 120))
				Me.table_5500_st.Add(New cRecPU(450, 640, 365, 120))
				Me.table_5500_st.Add(New cRecPU(500, 912, 305, 144))
				Me.table_5500_st.Add(New cRecPU(550, 912, 356, 144))
				Me.table_5500_st.Add(New cRecPU(600, 1280, 356, 168))
				Me.table_5500_st.Add(New cRecPU(700, 1280, 427, 192))
				Me.table_5500_st.Add(New cRecPU(850, 1824, 427, 216))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(50, 114, 169, 64))
				Me.table_6000_st.Add(New cRecPU(100, 114, 173, 64))
				Me.table_6000_st.Add(New cRecPU(125, 160, 200, 74))
				Me.table_6000_st.Add(New cRecPU(200, 228, 246, 74))
				Me.table_6000_st.Add(New cRecPU(250, 320, 256, 84))
				Me.table_6000_st.Add(New cRecPU(300, 456, 305, 100))
				Me.table_6000_st.Add(New cRecPU(450, 640, 305, 120))
				Me.table_6000_st.Add(New cRecPU(525, 912, 427, 192))
				Me.table_6000_st.Add(New cRecPU(575, 1280, 427, 216))
				Me.table_6000_st.Add(New cRecPU(750, 1824, 427, 216))
				Me.table_6000_st.Add(New cRecPU(850, 1824, 470, 216))
				Me.table_6500_st.Clear()
				Me.table_6500_st.Add(New cRecPU(50, 114, 173, 64))
				Me.table_6500_st.Add(New cRecPU(100, 160, 200, 74))
				Me.table_6500_st.Add(New cRecPU(150, 228, 246, 74))
				Me.table_6500_st.Add(New cRecPU(250, 320, 256, 84))
				Me.table_6500_st.Add(New cRecPU(300, 456, 256, 100))
				Me.table_6500_st.Add(New cRecPU(450, 640, 305, 120))
				Me.table_6500_st.Add(New cRecPU(475, 912, 365, 168))
				Me.table_6500_st.Add(New cRecPU(500, 1280, 427, 192))
				Me.table_6500_st.Add(New cRecPU(700, 1824, 427, 216))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(50, 114, 173, 64))
				Me.table_7000_st.Add(New cRecPU(100, 160, 200, 74))
				Me.table_7000_st.Add(New cRecPU(150, 228, 246, 74))
				Me.table_7000_st.Add(New cRecPU(165, 320, 256, 84))
				Me.table_7000_st.Add(New cRecPU(350, 456, 305, 100))
				Me.table_7000_st.Add(New cRecPU(400, 640, 305, 120))
				Me.table_7000_st.Add(New cRecPU(450, 912, 356, 144))
				Me.table_7000_st.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_7000_st.Add(New cRecPU(550, 1280, 427, 192))
				Me.table_7000_st.Add(New cRecPU(600, 1824, 427, 216))
				Me.table_7000_st.Add(New cRecPU(700, 1824, 470, 216))
				Me.table_7500_st.Clear()
				Me.table_7500_st.Add(New cRecPU(50, 114, 200, 64))
				Me.table_7500_st.Add(New cRecPU(100, 160, 200, 74))
				Me.table_7500_st.Add(New cRecPU(150, 228, 246, 74))
				Me.table_7500_st.Add(New cRecPU(175, 320, 298, 100))
				Me.table_7500_st.Add(New cRecPU(200, 456, 305, 120))
				Me.table_7500_st.Add(New cRecPU(350, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(400, 912, 427, 144))
				Me.table_7500_st.Add(New cRecPU(450, 912, 427, 168))
				Me.table_7500_st.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_7500_st.Add(New cRecPU(550, 1280, 427, 192))
				Me.table_7500_st.Add(New cRecPU(600, 1824, 427, 216))
				Me.table_7500_st.Add(New cRecPU(700, 1824, 470, 216))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(50, 114, 200, 60))
				Me.table_8000_st.Add(New cRecPU(100, 160, 246, 64))
				Me.table_8000_st.Add(New cRecPU(150, 228, 246, 74))
				Me.table_8000_st.Add(New cRecPU(175, 320, 256, 84))
				Me.table_8000_st.Add(New cRecPU(200, 456, 305, 120))
				Me.table_8000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_8000_st.Add(New cRecPU(400, 640, 365, 120))
				Me.table_8000_st.Add(New cRecPU(550, 912, 365, 144))
				Me.table_8000_st.Add(New cRecPU(575, 1824, 470, 216))
				Me.table_8500_st.Clear()
				Me.table_8500_st.Add(New cRecPU(50, 160, 256, 60))
				Me.table_8500_st.Add(New cRecPU(75, 160, 246, 74))
				Me.table_8500_st.Add(New cRecPU(100, 228, 256, 74))
				Me.table_8500_st.Add(New cRecPU(150, 320, 298, 84))
				Me.table_8500_st.Add(New cRecPU(175, 320, 305, 100))
				Me.table_8500_st.Add(New cRecPU(200, 456, 305, 100))
				Me.table_8500_st.Add(New cRecPU(350, 640, 365, 120))
				Me.table_8500_st.Add(New cRecPU(450, 912, 365, 144))
				Me.table_8500_st.Add(New cRecPU(500, 912, 427, 144))
				Me.table_8500_st.Add(New cRecPU(550, 1280, 427, 192))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(50, 160, 246, 74))
				Me.table_9000_st.Add(New cRecPU(100, 228, 246, 74))
				Me.table_9000_st.Add(New cRecPU(150, 320, 305, 84))
				Me.table_9000_st.Add(New cRecPU(200, 456, 365, 100))
				Me.table_9000_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_9000_st.Add(New cRecPU(350, 640, 427, 100))
				Me.table_9000_st.Add(New cRecPU(400, 912, 427, 144))
				Me.table_9000_st.Add(New cRecPU(475, 1280, 470, 192))
				Me.table_9000_st.Add(New cRecPU(550, 1280, 427, 192))
				Me.table_9000_st.Add(New cRecPU(600, 1824, 470, 216))
				Me.table_9500_st.Clear()
				Me.table_9500_st.Add(New cRecPU(50, 160, 246, 74))
				Me.table_9500_st.Add(New cRecPU(100, 228, 246, 74))
				Me.table_9500_st.Add(New cRecPU(125, 320, 305, 84))
				Me.table_9500_st.Add(New cRecPU(175, 456, 305, 100))
				Me.table_9500_st.Add(New cRecPU(200, 640, 356, 120))
				Me.table_9500_st.Add(New cRecPU(225, 640, 356, 144))
				Me.table_9500_st.Add(New cRecPU(300, 912, 427, 144))
				Me.table_9500_st.Add(New cRecPU(350, 912, 427, 144))
				Me.table_9500_st.Add(New cRecPU(450, 1280, 427, 168))
				Me.table_9500_st.Add(New cRecPU(500, 1280, 470, 192))
				Me.table_9500_st.Add(New cRecPU(600, 1824, 470, 216))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(50, 160, 246, 74))
				Me.table_10000_st.Add(New cRecPU(75, 228, 246, 86))
				Me.table_10000_st.Add(New cRecPU(100, 320, 256, 100))
				Me.table_10000_st.Add(New cRecPU(125, 320, 298, 100))
				Me.table_10000_st.Add(New cRecPU(150, 456, 305, 100))
				Me.table_10000_st.Add(New cRecPU(175, 456, 365, 100))
				Me.table_10000_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10000_st.Add(New cRecPU(350, 912, 427, 144))
				Me.table_10000_st.Add(New cRecPU(400, 1280, 427, 144))
				Me.table_10000_st.Add(New cRecPU(500, 1280, 470, 168))
				Me.table_10000_st.Add(New cRecPU(550, 1824, 470, 216))
				Me.table_10500_st.Clear()
				Me.table_10500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_10500_st.Add(New cRecPU(100, 320, 305, 84))
				Me.table_10500_st.Add(New cRecPU(150, 456, 305, 100))
				Me.table_10500_st.Add(New cRecPU(175, 456, 356, 100))
				Me.table_10500_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10500_st.Add(New cRecPU(250, 640, 365, 144))
				Me.table_10500_st.Add(New cRecPU(300, 912, 427, 168))
				Me.table_10500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_10500_st.Add(New cRecPU(400, 1824, 427, 216))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_11000_st.Add(New cRecPU(100, 320, 305, 84))
				Me.table_11000_st.Add(New cRecPU(150, 456, 305, 100))
				Me.table_11000_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_11000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11000_st.Add(New cRecPU(300, 1280, 470, 168))
				Me.table_11000_st.Add(New cRecPU(400, 1824, 470, 216))
				Me.table_11500_st.Clear()
				Me.table_11500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_11500_st.Add(New cRecPU(100, 320, 305, 84))
				Me.table_11500_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_11500_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_11500_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_11500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_11500_st.Add(New cRecPU(400, 1824, 427, 216))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(50, 228, 305, 74))
				Me.table_12000_st.Add(New cRecPU(100, 320, 305, 84))
				Me.table_12000_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_12000_st.Add(New cRecPU(175, 640, 365, 144))
				Me.table_12000_st.Add(New cRecPU(250, 912, 427, 168))
				Me.table_12000_st.Add(New cRecPU(325, 1280, 427, 192))
				Me.table_12000_st.Add(New cRecPU(350, 1824, 427, 216))
				Me.table_12500_st.Clear()
				Me.table_12500_st.Add(New cRecPU(100, 320, 305, 84))
				Me.table_12500_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_12500_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_12500_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_12500_st.Add(New cRecPU(300, 1280, 427, 192))
				Me.table_12500_st.Add(New cRecPU(325, 1824, 427, 216))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(50, 320, 305, 84))
				Me.table_13000_st.Add(New cRecPU(100, 320, 356, 84))
				Me.table_13000_st.Add(New cRecPU(125, 640, 427, 100))
				Me.table_13000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_13000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_13000_st.Add(New cRecPU(300, 1280, 470, 168))
				Me.table_13000_st.Add(New cRecPU(325, 1824, 470, 216))
				Me.table_13500_st.Clear()
				Me.table_13500_st.Add(New cRecPU(50, 320, 305, 84))
				Me.table_13500_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_13500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13500_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_13500_st.Add(New cRecPU(250, 1280, 427, 192))
				Me.table_13500_st.Add(New cRecPU(275, 1824, 427, 216))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(50, 456, 365, 100))
				Me.table_14000_st.Add(New cRecPU(100, 640, 365, 120))
				Me.table_14000_st.Add(New cRecPU(125, 912, 427, 120))
				Me.table_14000_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_14000_st.Add(New cRecPU(250, 1280, 470, 168))
				Me.table_14000_st.Add(New cRecPU(275, 1824, 427, 216))
				Me.table_14500_st.Clear()
				Me.table_14500_st.Add(New cRecPU(50, 456, 427, 84))
				Me.table_14500_st.Add(New cRecPU(100, 640, 427, 100))
				Me.table_14500_st.Add(New cRecPU(125, 912, 427, 144))
				Me.table_14500_st.Add(New cRecPU(175, 912, 427, 144))
				Me.table_14500_st.Add(New cRecPU(200, 1280, 427, 192))
				Me.table_14500_st.Add(New cRecPU(250, 1824, 427, 216))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(50, 912, 427, 120))
				Me.table_15000_st.Add(New cRecPU(125, 912, 427, 130))
				Me.table_15000_st.Add(New cRecPU(150, 912, 427, 144))
				Me.table_15000_st.Add(New cRecPU(200, 1280, 427, 168))
				Me.table_15500_st.Clear()
				Me.table_15500_st.Add(New cRecPU(50, 912, 427, 120))
				Me.table_15500_st.Add(New cRecPU(150, 912, 427, 144))
				Me.table_15500_st.Add(New cRecPU(200, 1280, 427, 192))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(100, 912, 427, 144))
				Me.table_16000_st.Add(New cRecPU(150, 1280, 427, 192))
				Me.table_17000_st.Clear()
				Me.table_17000_st.Add(New cRecPU(50, 640, 427, 120))
				Me.table_17000_st.Add(New cRecPU(75, 912, 427, 168))
				Me.table_17000_st.Add(New cRecPU(100, 1280, 427, 192))
				Me.table_17000_st.Add(New cRecPU(120, 1824, 427, 216))
				Me.table_17500_st.Clear()
				Me.table_17500_st.Add(New cRecPU(80, 912, 427, 168))
				Me.table_17500_st.Add(New cRecPU(100, 1280, 427, 216))
				Me.table_17500_st.Add(New cRecPU(120, 1824, 427, 216))
				Me.table_18000_st.Clear()
				Me.table_18000_st.Add(New cRecPU(60, 912, 427, 168))
				Me.table_18000_st.Add(New cRecPU(70, 912, 427, 192))
				Me.table_18000_st.Add(New cRecPU(80, 1280, 427, 216))
				Me.table_18000_st.Add(New cRecPU(100, 1824, 427, 216))
				Me.table_18500_st.Clear()
				Me.table_18500_st.Add(New cRecPU(60, 912, 427, 168))
				Me.table_18500_st.Add(New cRecPU(70, 912, 427, 192))
				Me.table_18500_st.Add(New cRecPU(80, 1280, 470, 216))
				Me.table_18500_st.Add(New cRecPU(100, 1824, 470, 216))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUSTAL_MarkII_Save()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(50, 25, 35, 52))
				Me.table_1000_st.Add(New cRecPU(150, 35, 35, 64))
				Me.table_1000_st.Add(New cRecPU(250, 45, 45, 64))
				Me.table_1000_st.Add(New cRecPU(300, 47, 50, 64))
				Me.table_1000_st.Add(New cRecPU(350, 47, 50, 64))
				Me.table_1000_st.Add(New cRecPU(400, 60, 52, 64))
				Me.table_1000_st.Add(New cRecPU(500, 65, 56, 64))
				Me.table_1000_st.Add(New cRecPU(600, 65, 60, 64))
				Me.table_1000_st.Add(New cRecPU(750, 80, 70, 64))
				Me.table_1000_st.Add(New cRecPU(800, 114, 85, 64))
				Me.table_1000_st.Add(New cRecPU(900, 114, 90, 64))
				Me.table_1000_st.Add(New cRecPU(1000, 114, 100, 74))
				Me.table_1000_st.Add(New cRecPU(1100, 160, 100, 74))
				Me.table_1000_st.Add(New cRecPU(1200, 160, 100, 86))
				Me.table_1000_st.Add(New cRecPU(1400, 228, 119, 100))
				Me.table_1000_st.Add(New cRecPU(1600, 228, 119, 120))
				Me.table_1000_st.Add(New cRecPU(1800, 320, 119, 144))
				Me.table_1000_st.Add(New cRecPU(1900, 456, 119, 168))
				Me.table_1000_st.Add(New cRecPU(2000, 456, 119, 192))
				Me.table_1000_st.Add(New cRecPU(2100, 640, 125, 192))
				Me.table_1000_st.Add(New cRecPU(2200, 640, 125, 216))
				Me.table_1000_st.Add(New cRecPU(2700, 912, 135, 216))
				Me.table_1500_st.Clear()
				Me.table_1500_st.Add(New cRecPU(50, 37, 40, 64))
				Me.table_1500_st.Add(New cRecPU(100, 44, 47, 64))
				Me.table_1500_st.Add(New cRecPU(150, 50, 52, 64))
				Me.table_1500_st.Add(New cRecPU(200, 57, 56, 64))
				Me.table_1500_st.Add(New cRecPU(250, 62, 66, 64))
				Me.table_1500_st.Add(New cRecPU(350, 80, 75, 64))
				Me.table_1500_st.Add(New cRecPU(400, 114, 75, 74))
				Me.table_1500_st.Add(New cRecPU(500, 114, 75, 86))
				Me.table_1500_st.Add(New cRecPU(550, 160, 80, 100))
				Me.table_1500_st.Add(New cRecPU(650, 160, 90, 100))
				Me.table_1500_st.Add(New cRecPU(700, 228, 90, 120))
				Me.table_1500_st.Add(New cRecPU(800, 228, 100, 120))
				Me.table_1500_st.Add(New cRecPU(850, 228, 119, 120))
				Me.table_1500_st.Add(New cRecPU(950, 320, 119, 120))
				Me.table_1500_st.Add(New cRecPU(1000, 320, 125, 144))
				Me.table_1500_st.Add(New cRecPU(1200, 456, 150, 144))
				Me.table_1500_st.Add(New cRecPU(1400, 640, 150, 168))
				Me.table_1500_st.Add(New cRecPU(1800, 640, 150, 192))
				Me.table_1500_st.Add(New cRecPU(2100, 912, 160, 216))
				Me.table_1500_st.Add(New cRecPU(2400, 1280, 200, 216))
				Me.table_1500_st.Add(New cRecPU(2700, 1280, 210, 216))
				Me.table_1500_st.Add(New cRecPU(2800, 1280, 220, 216))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(50, 37, 56, 52))
				Me.table_2000_st.Add(New cRecPU(100, 40, 64, 52))
				Me.table_2000_st.Add(New cRecPU(150, 50, 76, 52))
				Me.table_2000_st.Add(New cRecPU(200, 62, 86, 52))
				Me.table_2000_st.Add(New cRecPU(250, 80, 90, 64))
				Me.table_2000_st.Add(New cRecPU(300, 114, 95, 74))
				Me.table_2000_st.Add(New cRecPU(350, 114, 100, 74))
				Me.table_2000_st.Add(New cRecPU(450, 114, 143, 74))
				Me.table_2000_st.Add(New cRecPU(600, 160, 143, 74))
				Me.table_2000_st.Add(New cRecPU(650, 160, 173, 74))
				Me.table_2000_st.Add(New cRecPU(700, 228, 173, 100))
				Me.table_2000_st.Add(New cRecPU(900, 320, 173, 120))
				Me.table_2000_st.Add(New cRecPU(1100, 456, 173, 144))
				Me.table_2000_st.Add(New cRecPU(1100, 456, 173, 144))
				Me.table_2000_st.Add(New cRecPU(1300, 640, 173, 168))
				Me.table_2000_st.Add(New cRecPU(1500, 640, 180, 192))
				Me.table_2000_st.Add(New cRecPU(1700, 912, 200, 192))
				Me.table_2000_st.Add(New cRecPU(1800, 912, 200, 216))
				Me.table_2000_st.Add(New cRecPU(2050, 1280, 253, 192))
				Me.table_2000_st.Add(New cRecPU(2500, 1280, 305, 192))
				Me.table_2500_st.Clear()
				Me.table_2500_st.Add(New cRecPU(50, 40, 65, 52))
				Me.table_2500_st.Add(New cRecPU(100, 50, 84, 52))
				Me.table_2500_st.Add(New cRecPU(150, 65, 100, 52))
				Me.table_2500_st.Add(New cRecPU(200, 85, 100, 64))
				Me.table_2500_st.Add(New cRecPU(250, 114, 143, 64))
				Me.table_2500_st.Add(New cRecPU(300, 160, 143, 74))
				Me.table_2500_st.Add(New cRecPU(450, 160, 173, 74))
				Me.table_2500_st.Add(New cRecPU(550, 228, 173, 74))
				Me.table_2500_st.Add(New cRecPU(600, 228, 200, 86))
				Me.table_2500_st.Add(New cRecPU(650, 228, 213, 86))
				Me.table_2500_st.Add(New cRecPU(700, 320, 200, 100))
				Me.table_2500_st.Add(New cRecPU(750, 320, 200, 120))
				Me.table_2500_st.Add(New cRecPU(800, 456, 200, 144))
				Me.table_2500_st.Add(New cRecPU(1000, 640, 253, 144))
				Me.table_2500_st.Add(New cRecPU(1100, 912, 256, 168))
				Me.table_2500_st.Add(New cRecPU(1200, 640, 253, 144))
				Me.table_2500_st.Add(New cRecPU(1300, 912, 245, 168))
				Me.table_2500_st.Add(New cRecPU(1400, 912, 245, 192))
				Me.table_2500_st.Add(New cRecPU(1500, 912, 253, 192))
				Me.table_2500_st.Add(New cRecPU(1700, 1280, 256, 216))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(50, 40, 80, 40))
				Me.table_3000_st.Add(New cRecPU(100, 50, 80, 52))
				Me.table_3000_st.Add(New cRecPU(200, 114, 119, 64))
				Me.table_3000_st.Add(New cRecPU(300, 114, 143, 64))
				Me.table_3000_st.Add(New cRecPU(400, 160, 173, 74))
				Me.table_3000_st.Add(New cRecPU(450, 228, 173, 74))
				Me.table_3000_st.Add(New cRecPU(500, 228, 200, 86))
				Me.table_3000_st.Add(New cRecPU(600, 320, 256, 100))
				Me.table_3000_st.Add(New cRecPU(700, 456, 256, 120))
				Me.table_3000_st.Add(New cRecPU(800, 640, 256, 120))
				Me.table_3000_st.Add(New cRecPU(1000, 640, 256, 144))
				Me.table_3000_st.Add(New cRecPU(1100, 912, 305, 168))
				Me.table_3000_st.Add(New cRecPU(1500, 1280, 305, 192))
				Me.table_3000_st.Add(New cRecPU(1600, 1280, 305, 216))
				Me.table_3000_st.Add(New cRecPU(1675, 1824, 356, 216))
				Me.table_3500_st.Clear()
				Me.table_3500_st.Add(New cRecPU(50, 45, 90, 52))
				Me.table_3500_st.Add(New cRecPU(100, 80, 119, 52))
				Me.table_3500_st.Add(New cRecPU(200, 114, 143, 52))
				Me.table_3500_st.Add(New cRecPU(300, 160, 173, 60))
				Me.table_3500_st.Add(New cRecPU(400, 228, 173, 74))
				Me.table_3500_st.Add(New cRecPU(500, 320, 256, 84))
				Me.table_3500_st.Add(New cRecPU(600, 456, 256, 120))
				Me.table_3500_st.Add(New cRecPU(800, 640, 305, 120))
				Me.table_3500_st.Add(New cRecPU(1000, 912, 305, 144))
				Me.table_3500_st.Add(New cRecPU(1200, 912, 356, 144))
				Me.table_3500_st.Add(New cRecPU(1400, 1280, 427, 192))
				Me.table_3500_st.Add(New cRecPU(1600, 1824, 427, 216))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(50, 55, 119, 52))
				Me.table_4000_st.Add(New cRecPU(100, 80, 119, 52))
				Me.table_4000_st.Add(New cRecPU(200, 114, 143, 52))
				Me.table_4000_st.Add(New cRecPU(250, 160, 173, 74))
				Me.table_4000_st.Add(New cRecPU(300, 228, 173, 74))
				Me.table_4000_st.Add(New cRecPU(350, 228, 200, 86))
				Me.table_4000_st.Add(New cRecPU(400, 320, 200, 100))
				Me.table_4000_st.Add(New cRecPU(450, 456, 256, 120))
				Me.table_4000_st.Add(New cRecPU(500, 456, 256, 144))
				Me.table_4000_st.Add(New cRecPU(650, 640, 256, 144))
				Me.table_4000_st.Add(New cRecPU(700, 640, 305, 168))
				Me.table_4000_st.Add(New cRecPU(900, 912, 305, 192))
				Me.table_4000_st.Add(New cRecPU(1000, 1280, 305, 216))
				Me.table_4000_st.Add(New cRecPU(1450, 1824, 427, 216))
				Me.table_4500_st.Clear()
				Me.table_4500_st.Add(New cRecPU(50, 60, 120, 52))
				Me.table_4500_st.Add(New cRecPU(100, 80, 125, 52))
				Me.table_4500_st.Add(New cRecPU(150, 114, 143, 64))
				Me.table_4500_st.Add(New cRecPU(200, 160, 173, 74))
				Me.table_4500_st.Add(New cRecPU(250, 228, 200, 74))
				Me.table_4500_st.Add(New cRecPU(300, 320, 256, 100))
				Me.table_4500_st.Add(New cRecPU(350, 456, 256, 120))
				Me.table_4500_st.Add(New cRecPU(550, 640, 256, 144))
				Me.table_4500_st.Add(New cRecPU(650, 912, 305, 168))
				Me.table_4500_st.Add(New cRecPU(700, 912, 305, 192))
				Me.table_4500_st.Add(New cRecPU(750, 1280, 427, 216))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(50, 80, 143, 52))
				Me.table_5000_st.Add(New cRecPU(100, 80, 143, 52))
				Me.table_5000_st.Add(New cRecPU(125, 114, 173, 64))
				Me.table_5000_st.Add(New cRecPU(150, 160, 173, 74))
				Me.table_5000_st.Add(New cRecPU(250, 228, 173, 74))
				Me.table_5000_st.Add(New cRecPU(300, 228, 200, 74))
				Me.table_5000_st.Add(New cRecPU(375, 320, 256, 84))
				Me.table_5000_st.Add(New cRecPU(425, 456, 305, 88))
				Me.table_5000_st.Add(New cRecPU(500, 640, 305, 100))
				Me.table_5000_st.Add(New cRecPU(525, 640, 365, 120))
				Me.table_5000_st.Add(New cRecPU(600, 912, 356, 144))
				Me.table_5000_st.Add(New cRecPU(700, 1280, 427, 192))
				Me.table_5000_st.Add(New cRecPU(1000, 1824, 427, 216))
				Me.table_5500_st.Clear()
				Me.table_5500_st.Add(New cRecPU(100, 114, 143, 64))
				Me.table_5500_st.Add(New cRecPU(150, 160, 173, 74))
				Me.table_5500_st.Add(New cRecPU(200, 228, 200, 74))
				Me.table_5500_st.Add(New cRecPU(250, 320, 256, 100))
				Me.table_5500_st.Add(New cRecPU(350, 456, 256, 120))
				Me.table_5500_st.Add(New cRecPU(450, 640, 305, 120))
				Me.table_5500_st.Add(New cRecPU(550, 912, 356, 144))
				Me.table_5500_st.Add(New cRecPU(600, 912, 356, 168))
				Me.table_5500_st.Add(New cRecPU(700, 1280, 427, 192))
				Me.table_5500_st.Add(New cRecPU(750, 1824, 427, 216))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(100, 114, 169, 64))
				Me.table_6000_st.Add(New cRecPU(125, 160, 200, 74))
				Me.table_6000_st.Add(New cRecPU(150, 228, 200, 74))
				Me.table_6000_st.Add(New cRecPU(200, 228, 246, 74))
				Me.table_6000_st.Add(New cRecPU(250, 320, 256, 84))
				Me.table_6000_st.Add(New cRecPU(350, 456, 305, 100))
				Me.table_6000_st.Add(New cRecPU(450, 640, 305, 120))
				Me.table_6000_st.Add(New cRecPU(525, 912, 427, 192))
				Me.table_6000_st.Add(New cRecPU(600, 1280, 427, 216))
				Me.table_6500_st.Clear()
				Me.table_6500_st.Add(New cRecPU(50, 114, 173, 64))
				Me.table_6500_st.Add(New cRecPU(100, 114, 200, 64))
				Me.table_6500_st.Add(New cRecPU(150, 228, 246, 74))
				Me.table_6500_st.Add(New cRecPU(250, 320, 256, 84))
				Me.table_6500_st.Add(New cRecPU(300, 456, 256, 100))
				Me.table_6500_st.Add(New cRecPU(450, 640, 305, 120))
				Me.table_6500_st.Add(New cRecPU(475, 912, 365, 168))
				Me.table_6500_st.Add(New cRecPU(500, 1280, 427, 192))
				Me.table_6500_st.Add(New cRecPU(575, 1824, 427, 216))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(50, 114, 173, 64))
				Me.table_7000_st.Add(New cRecPU(100, 160, 200, 74))
				Me.table_7000_st.Add(New cRecPU(150, 228, 246, 74))
				Me.table_7000_st.Add(New cRecPU(200, 320, 256, 84))
				Me.table_7000_st.Add(New cRecPU(350, 456, 305, 100))
				Me.table_7000_st.Add(New cRecPU(400, 640, 305, 120))
				Me.table_7000_st.Add(New cRecPU(450, 640, 305, 144))
				Me.table_7000_st.Add(New cRecPU(500, 912, 356, 168))
				Me.table_7000_st.Add(New cRecPU(550, 1280, 427, 192))
				Me.table_7000_st.Add(New cRecPU(600, 1824, 427, 216))
				Me.table_7500_st.Clear()
				Me.table_7500_st.Add(New cRecPU(50, 114, 173, 64))
				Me.table_7500_st.Add(New cRecPU(100, 160, 200, 74))
				Me.table_7500_st.Add(New cRecPU(150, 228, 246, 74))
				Me.table_7500_st.Add(New cRecPU(200, 320, 298, 100))
				Me.table_7500_st.Add(New cRecPU(300, 456, 305, 120))
				Me.table_7500_st.Add(New cRecPU(400, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(500, 912, 356, 144))
				Me.table_7500_st.Add(New cRecPU(575, 1280, 427, 192))
				Me.table_7500_st.Add(New cRecPU(650, 1824, 427, 216))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(50, 114, 200, 64))
				Me.table_8000_st.Add(New cRecPU(100, 160, 246, 64))
				Me.table_8000_st.Add(New cRecPU(150, 228, 246, 74))
				Me.table_8000_st.Add(New cRecPU(175, 320, 256, 84))
				Me.table_8000_st.Add(New cRecPU(200, 456, 305, 120))
				Me.table_8000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_8000_st.Add(New cRecPU(400, 640, 365, 120))
				Me.table_8000_st.Add(New cRecPU(550, 912, 365, 144))
				Me.table_8000_st.Add(New cRecPU(550, 1280, 427, 192))
				Me.table_8000_st.Add(New cRecPU(650, 1824, 427, 216))
				Me.table_8500_st.Clear()
				Me.table_8500_st.Add(New cRecPU(50, 114, 200, 64))
				Me.table_8500_st.Add(New cRecPU(75, 160, 246, 74))
				Me.table_8500_st.Add(New cRecPU(100, 228, 298, 74))
				Me.table_8500_st.Add(New cRecPU(150, 320, 298, 84))
				Me.table_8500_st.Add(New cRecPU(175, 320, 305, 100))
				Me.table_8500_st.Add(New cRecPU(200, 456, 305, 100))
				Me.table_8500_st.Add(New cRecPU(300, 640, 365, 120))
				Me.table_8500_st.Add(New cRecPU(450, 912, 365, 144))
				Me.table_8500_st.Add(New cRecPU(500, 912, 427, 144))
				Me.table_8500_st.Add(New cRecPU(550, 1280, 427, 192))
				Me.table_8500_st.Add(New cRecPU(650, 1824, 427, 216))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(50, 160, 246, 74))
				Me.table_9000_st.Add(New cRecPU(100, 228, 305, 74))
				Me.table_9000_st.Add(New cRecPU(175, 320, 305, 84))
				Me.table_9000_st.Add(New cRecPU(200, 456, 365, 100))
				Me.table_9000_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_9000_st.Add(New cRecPU(350, 640, 427, 100))
				Me.table_9000_st.Add(New cRecPU(400, 640, 427, 104))
				Me.table_9000_st.Add(New cRecPU(500, 912, 427, 144))
				Me.table_9000_st.Add(New cRecPU(525, 1280, 427, 168))
				Me.table_9000_st.Add(New cRecPU(550, 1280, 427, 192))
				Me.table_9000_st.Add(New cRecPU(650, 1824, 427, 216))
				Me.table_9500_st.Clear()
				Me.table_9500_st.Add(New cRecPU(50, 160, 246, 74))
				Me.table_9500_st.Add(New cRecPU(100, 228, 305, 74))
				Me.table_9500_st.Add(New cRecPU(125, 320, 305, 84))
				Me.table_9500_st.Add(New cRecPU(175, 456, 305, 100))
				Me.table_9500_st.Add(New cRecPU(200, 640, 356, 120))
				Me.table_9500_st.Add(New cRecPU(225, 640, 356, 144))
				Me.table_9500_st.Add(New cRecPU(300, 912, 365, 144))
				Me.table_9500_st.Add(New cRecPU(350, 912, 427, 144))
				Me.table_9500_st.Add(New cRecPU(450, 1280, 427, 168))
				Me.table_9500_st.Add(New cRecPU(500, 1280, 427, 192))
				Me.table_9500_st.Add(New cRecPU(600, 1824, 427, 216))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(50, 160, 246, 74))
				Me.table_10000_st.Add(New cRecPU(75, 228, 246, 86))
				Me.table_10000_st.Add(New cRecPU(125, 320, 256, 100))
				Me.table_10000_st.Add(New cRecPU(150, 456, 305, 100))
				Me.table_10000_st.Add(New cRecPU(175, 456, 365, 104))
				Me.table_10000_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10000_st.Add(New cRecPU(400, 912, 427, 144))
				Me.table_10000_st.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_10000_st.Add(New cRecPU(550, 1824, 427, 216))
				Me.table_10500_st.Clear()
				Me.table_10500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_10500_st.Add(New cRecPU(100, 320, 305, 84))
				Me.table_10500_st.Add(New cRecPU(150, 456, 305, 100))
				Me.table_10500_st.Add(New cRecPU(175, 456, 356, 104))
				Me.table_10500_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10500_st.Add(New cRecPU(250, 640, 365, 144))
				Me.table_10500_st.Add(New cRecPU(300, 912, 427, 168))
				Me.table_10500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_10500_st.Add(New cRecPU(425, 1824, 427, 216))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_11000_st.Add(New cRecPU(100, 320, 305, 84))
				Me.table_11000_st.Add(New cRecPU(150, 456, 305, 100))
				Me.table_11000_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_11000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11000_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_11000_st.Add(New cRecPU(425, 1824, 427, 216))
				Me.table_11500_st.Clear()
				Me.table_11500_st.Add(New cRecPU(50, 228, 305, 74))
				Me.table_11500_st.Add(New cRecPU(100, 320, 305, 84))
				Me.table_11500_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_11500_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_11500_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_11500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_11500_st.Add(New cRecPU(400, 1824, 427, 216))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(50, 228, 305, 74))
				Me.table_12000_st.Add(New cRecPU(100, 320, 305, 84))
				Me.table_12000_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_12000_st.Add(New cRecPU(175, 640, 365, 144))
				Me.table_12000_st.Add(New cRecPU(250, 912, 427, 168))
				Me.table_12000_st.Add(New cRecPU(325, 1280, 427, 192))
				Me.table_12000_st.Add(New cRecPU(350, 1824, 427, 216))
				Me.table_12500_st.Clear()
				Me.table_12500_st.Add(New cRecPU(100, 320, 305, 84))
				Me.table_12500_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_12500_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_12500_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_12500_st.Add(New cRecPU(300, 1280, 427, 192))
				Me.table_12500_st.Add(New cRecPU(325, 1824, 427, 216))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(50, 320, 305, 84))
				Me.table_13000_st.Add(New cRecPU(100, 320, 356, 84))
				Me.table_13000_st.Add(New cRecPU(125, 640, 427, 100))
				Me.table_13000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_13000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_13000_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_13000_st.Add(New cRecPU(325, 1824, 427, 216))
				Me.table_13500_st.Clear()
				Me.table_13500_st.Add(New cRecPU(50, 320, 305, 84))
				Me.table_13500_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_13500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13500_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_13500_st.Add(New cRecPU(250, 1280, 427, 192))
				Me.table_13500_st.Add(New cRecPU(275, 1824, 427, 216))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(50, 320, 356, 84))
				Me.table_14000_st.Add(New cRecPU(100, 456, 365, 100))
				Me.table_14000_st.Add(New cRecPU(125, 640, 427, 120))
				Me.table_14000_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_14000_st.Add(New cRecPU(250, 1280, 427, 168))
				Me.table_14000_st.Add(New cRecPU(275, 1824, 427, 216))
				Me.table_14500_st.Clear()
				Me.table_14500_st.Add(New cRecPU(50, 320, 356, 84))
				Me.table_14500_st.Add(New cRecPU(100, 456, 427, 100))
				Me.table_14500_st.Add(New cRecPU(125, 640, 427, 120))
				Me.table_14500_st.Add(New cRecPU(175, 912, 427, 144))
				Me.table_14500_st.Add(New cRecPU(200, 1280, 427, 192))
				Me.table_14500_st.Add(New cRecPU(250, 1824, 427, 216))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(50, 320, 356, 84))
				Me.table_15000_st.Add(New cRecPU(100, 456, 427, 100))
				Me.table_15000_st.Add(New cRecPU(125, 640, 427, 120))
				Me.table_15000_st.Add(New cRecPU(150, 912, 365, 144))
				Me.table_15000_st.Add(New cRecPU(200, 1280, 427, 168))
				Me.table_15000_st.Add(New cRecPU(225, 1824, 427, 216))
				Me.table_15500_st.Clear()
				Me.table_15500_st.Add(New cRecPU(50, 456, 365, 100))
				Me.table_15500_st.Add(New cRecPU(125, 640, 427, 120))
				Me.table_15500_st.Add(New cRecPU(150, 912, 427, 144))
				Me.table_15500_st.Add(New cRecPU(180, 1280, 427, 192))
				Me.table_15500_st.Add(New cRecPU(200, 1824, 427, 216))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(50, 456, 365, 100))
				Me.table_16000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_16000_st.Add(New cRecPU(150, 912, 427, 144))
				Me.table_16000_st.Add(New cRecPU(170, 1280, 427, 168))
				Me.table_17000_st.Clear()
				Me.table_17000_st.Add(New cRecPU(50, 640, 427, 120))
				Me.table_17000_st.Add(New cRecPU(75, 912, 427, 168))
				Me.table_17000_st.Add(New cRecPU(80, 912, 427, 192))
				Me.table_17000_st.Add(New cRecPU(100, 1280, 427, 192))
				Me.table_17000_st.Add(New cRecPU(120, 1824, 427, 216))
				Me.table_17500_st.Clear()
				Me.table_17500_st.Add(New cRecPU(60, 912, 427, 168))
				Me.table_17500_st.Add(New cRecPU(80, 912, 427, 192))
				Me.table_17500_st.Add(New cRecPU(100, 1280, 427, 216))
				Me.table_17500_st.Add(New cRecPU(120, 1824, 427, 216))
				Me.table_18000_st.Clear()
				Me.table_18000_st.Add(New cRecPU(60, 912, 427, 168))
				Me.table_18000_st.Add(New cRecPU(70, 912, 427, 192))
				Me.table_18000_st.Add(New cRecPU(80, 1280, 427, 216))
				Me.table_18000_st.Add(New cRecPU(110, 1824, 427, 216))
				Me.table_18500_st.Clear()
				Me.table_18500_st.Add(New cRecPU(60, 912, 427, 168))
				Me.table_18500_st.Add(New cRecPU(70, 912, 427, 192))
				Me.table_18500_st.Add(New cRecPU(80, 1280, 427, 216))
				Me.table_18500_st.Add(New cRecPU(100, 1824, 427, 216))
				Me.table_19000_st.Clear()
				Me.table_19000_st.Add(New cRecPU(60, 912, 427, 168))
				Me.table_19000_st.Add(New cRecPU(80, 1280, 450, 192))
				Me.table_19500_st.Clear()
				Me.table_19500_st.Add(New cRecPU(60, 912, 450, 168))
				Me.table_20000_st.Clear()
				Me.table_20000_st.Add(New cRecPU(50, 1280, 470, 168))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUFGal_AB()
			Try
				Me.table_1000_fg.Clear()
				Me.table_1000_fg.Add(New cRecPU(50, 25, 30, 54))
				Me.table_1000_fg.Add(New cRecPU(100, 30, 35, 54))
				Me.table_1000_fg.Add(New cRecPU(150, 35, 40, 54))
				Me.table_1000_fg.Add(New cRecPU(250, 55, 50, 64))
				Me.table_1000_fg.Add(New cRecPU(300, 60, 55, 64))
				Me.table_1000_fg.Add(New cRecPU(350, 65, 55, 64))
				Me.table_1000_fg.Add(New cRecPU(400, 70, 55, 64))
				Me.table_1000_fg.Add(New cRecPU(500, 75, 65, 64))
				Me.table_1000_fg.Add(New cRecPU(600, 90, 70, 64))
				Me.table_1000_fg.Add(New cRecPU(750, 114, 80, 64))
				Me.table_1000_fg.Add(New cRecPU(850, 114, 90, 64))
				Me.table_1000_fg.Add(New cRecPU(950, 160, 100, 74))
				Me.table_1000_fg.Add(New cRecPU(1000, 160, 110, 74))
				Me.table_1000_fg.Add(New cRecPU(1200, 160, 120, 74))
				Me.table_1000_fg.Add(New cRecPU(1300, 228, 130, 86))
				Me.table_1000_fg.Add(New cRecPU(1400, 228, 140, 86))
				Me.table_1000_fg.Add(New cRecPU(1500, 320, 140, 100))
				Me.table_1000_fg.Add(New cRecPU(1600, 320, 140, 120))
				Me.table_1000_fg.Add(New cRecPU(1900, 456, 140, 120))
				Me.table_1000_fg.Add(New cRecPU(2000, 456, 150, 144))
				Me.table_1000_fg.Add(New cRecPU(2200, 640, 150, 168))
				Me.table_1000_fg.Add(New cRecPU(2300, 640, 150, 192))
				Me.table_1000_fg.Add(New cRecPU(2500, 640, 150, 216))
				Me.table_1000_fg.Add(New cRecPU(2700, 912, 160, 216))
				Me.table_1000_fg.Add(New cRecPU(2800, 912, 170, 216))
				Me.table_1000_fg.Add(New cRecPU(2900, 912, 200, 216))
				Me.table_1000_fg.Add(New cRecPU(3300, 912, 200, 216))
				Me.table_1000_fg.Add(New cRecPU(3500, 1280, 200, 240))
				Me.table_1000_fg.Add(New cRecPU(3800, 1280, 220, 240))
				Me.table_1500_fg.Clear()
				Me.table_1500_fg.Add(New cRecPU(50, 35, 44, 54))
				Me.table_1500_fg.Add(New cRecPU(100, 40, 50, 54))
				Me.table_1500_fg.Add(New cRecPU(150, 55, 55, 54))
				Me.table_1500_fg.Add(New cRecPU(200, 60, 60, 54))
				Me.table_1500_fg.Add(New cRecPU(300, 85, 60, 74))
				Me.table_1500_fg.Add(New cRecPU(350, 114, 80, 74))
				Me.table_1500_fg.Add(New cRecPU(500, 114, 90, 74))
				Me.table_1500_fg.Add(New cRecPU(550, 160, 90, 74))
				Me.table_1500_fg.Add(New cRecPU(600, 160, 100, 74))
				Me.table_1500_fg.Add(New cRecPU(650, 160, 120, 74))
				Me.table_1500_fg.Add(New cRecPU(750, 160, 130, 74))
				Me.table_1500_fg.Add(New cRecPU(800, 160, 135, 74))
				Me.table_1500_fg.Add(New cRecPU(900, 228, 135, 86))
				Me.table_1500_fg.Add(New cRecPU(950, 228, 140, 86))
				Me.table_1500_fg.Add(New cRecPU(1000, 228, 150, 86))
				Me.table_1500_fg.Add(New cRecPU(1100, 320, 155, 86))
				Me.table_1500_fg.Add(New cRecPU(1200, 320, 175, 100))
				Me.table_1500_fg.Add(New cRecPU(1300, 456, 180, 100))
				Me.table_1500_fg.Add(New cRecPU(1400, 456, 195, 100))
				Me.table_1500_fg.Add(New cRecPU(1500, 456, 200, 120))
				Me.table_1500_fg.Add(New cRecPU(1600, 640, 185, 144))
				Me.table_1500_fg.Add(New cRecPU(1800, 640, 200, 144))
				Me.table_1500_fg.Add(New cRecPU(1900, 640, 220, 144))
				Me.table_1500_fg.Add(New cRecPU(2000, 640, 225, 144))
				Me.table_1500_fg.Add(New cRecPU(2300, 912, 230, 168))
				Me.table_1500_fg.Add(New cRecPU(2500, 1280, 230, 192))
				Me.table_1500_fg.Add(New cRecPU(2700, 1280, 200, 240))
				Me.table_1500_fg.Add(New cRecPU(2800, 1280, 245, 240))
				Me.table_2000_fg.Clear()
				Me.table_2000_fg.Add(New cRecPU(50, 45, 55, 54))
				Me.table_2000_fg.Add(New cRecPU(100, 55, 65, 54))
				Me.table_2000_fg.Add(New cRecPU(150, 65, 70, 54))
				Me.table_2000_fg.Add(New cRecPU(200, 85, 75, 54))
				Me.table_2000_fg.Add(New cRecPU(250, 114, 80, 64))
				Me.table_2000_fg.Add(New cRecPU(350, 114, 85, 64))
				Me.table_2000_fg.Add(New cRecPU(400, 114, 173, 64))
				Me.table_2000_fg.Add(New cRecPU(450, 160, 95, 74))
				Me.table_2000_fg.Add(New cRecPU(500, 228, 95, 86))
				Me.table_2000_fg.Add(New cRecPU(550, 228, 110, 86))
				Me.table_2000_fg.Add(New cRecPU(600, 228, 115, 100))
				Me.table_2000_fg.Add(New cRecPU(650, 320, 130, 120))
				Me.table_2000_fg.Add(New cRecPU(750, 456, 130, 144))
				Me.table_2000_fg.Add(New cRecPU(900, 456, 150, 144))
				Me.table_2000_fg.Add(New cRecPU(1000, 456, 160, 144))
				Me.table_2000_fg.Add(New cRecPU(1100, 456, 180, 144))
				Me.table_2000_fg.Add(New cRecPU(1300, 640, 180, 168))
				Me.table_2000_fg.Add(New cRecPU(1400, 640, 200, 168))
				Me.table_2000_fg.Add(New cRecPU(1500, 640, 220, 168))
				Me.table_2000_fg.Add(New cRecPU(1800, 912, 220, 192))
				Me.table_2000_fg.Add(New cRecPU(1900, 912, 230, 192))
				Me.table_2000_fg.Add(New cRecPU(2000, 912, 240, 192))
				Me.table_2000_fg.Add(New cRecPU(2100, 1280, 240, 240))
				Me.table_2500_fg.Clear()
				Me.table_2500_fg.Add(New cRecPU(50, 55, 75, 54))
				Me.table_2500_fg.Add(New cRecPU(100, 70, 75, 54))
				Me.table_2500_fg.Add(New cRecPU(150, 80, 80, 54))
				Me.table_2500_fg.Add(New cRecPU(200, 114, 100, 54))
				Me.table_2500_fg.Add(New cRecPU(250, 114, 110, 54))
				Me.table_2500_fg.Add(New cRecPU(350, 160, 130, 64))
				Me.table_2500_fg.Add(New cRecPU(400, 228, 135, 74))
				Me.table_2500_fg.Add(New cRecPU(450, 228, 140, 74))
				Me.table_2500_fg.Add(New cRecPU(500, 228, 145, 74))
				Me.table_2500_fg.Add(New cRecPU(550, 320, 170, 86))
				Me.table_2500_fg.Add(New cRecPU(750, 320, 180, 86))
				Me.table_2500_fg.Add(New cRecPU(1000, 456, 200, 100))
				Me.table_2500_fg.Add(New cRecPU(1100, 640, 213, 120))
				Me.table_2500_fg.Add(New cRecPU(1200, 640, 235, 120))
				Me.table_2500_fg.Add(New cRecPU(1300, 640, 235, 144))
				Me.table_2500_fg.Add(New cRecPU(1400, 912, 305, 168))
				Me.table_3000_fg.Clear()
				Me.table_3000_fg.Add(New cRecPU(50, 65, 80, 54))
				Me.table_3000_fg.Add(New cRecPU(100, 90, 90, 54))
				Me.table_3000_fg.Add(New cRecPU(200, 114, 100, 54))
				Me.table_3000_fg.Add(New cRecPU(250, 160, 130, 64))
				Me.table_3000_fg.Add(New cRecPU(300, 160, 140, 64))
				Me.table_3000_fg.Add(New cRecPU(450, 228, 150, 74))
				Me.table_3000_fg.Add(New cRecPU(550, 320, 165, 86))
				Me.table_3000_fg.Add(New cRecPU(600, 320, 175, 86))
				Me.table_3000_fg.Add(New cRecPU(700, 456, 200, 100))
				Me.table_3000_fg.Add(New cRecPU(850, 640, 200, 120))
				Me.table_3000_fg.Add(New cRecPU(900, 640, 220, 120))
				Me.table_3000_fg.Add(New cRecPU(1000, 640, 220, 144))
				Me.table_3000_fg.Add(New cRecPU(1100, 912, 220, 168))
				Me.table_3000_fg.Add(New cRecPU(1200, 1280, 220, 240))
				Me.table_3000_fg.Add(New cRecPU(1300, 1280, 235, 240))
				Me.table_3500_fg.Clear()
				Me.table_3500_fg.Add(New cRecPU(50, 80, 90, 54))
				Me.table_3500_fg.Add(New cRecPU(100, 114, 119, 54))
				Me.table_3500_fg.Add(New cRecPU(150, 160, 119, 64))
				Me.table_3500_fg.Add(New cRecPU(200, 160, 125, 64))
				Me.table_3500_fg.Add(New cRecPU(300, 228, 150, 74))
				Me.table_3500_fg.Add(New cRecPU(350, 228, 160, 74))
				Me.table_3500_fg.Add(New cRecPU(450, 320, 180, 86))
				Me.table_3500_fg.Add(New cRecPU(500, 320, 200, 86))
				Me.table_3500_fg.Add(New cRecPU(650, 456, 200, 100))
				Me.table_3500_fg.Add(New cRecPU(700, 456, 200, 120))
				Me.table_3500_fg.Add(New cRecPU(750, 640, 213, 120))
				Me.table_3500_fg.Add(New cRecPU(850, 640, 235, 120))
				Me.table_3500_fg.Add(New cRecPU(900, 912, 235, 120))
				Me.table_3500_fg.Add(New cRecPU(1000, 912, 305, 120))
				Me.table_3500_fg.Add(New cRecPU(1100, 912, 310, 144))
				Me.table_4000_fg.Clear()
				Me.table_4000_fg.Add(New cRecPU(50, 90, 119, 54))
				Me.table_4000_fg.Add(New cRecPU(100, 114, 119, 54))
				Me.table_4000_fg.Add(New cRecPU(150, 160, 135, 64))
				Me.table_4000_fg.Add(New cRecPU(250, 160, 135, 64))
				Me.table_4000_fg.Add(New cRecPU(350, 320, 173, 74))
				Me.table_4000_fg.Add(New cRecPU(450, 320, 200, 74))
				Me.table_4000_fg.Add(New cRecPU(600, 456, 256, 100))
				Me.table_4000_fg.Add(New cRecPU(750, 640, 256, 120))
				Me.table_4000_fg.Add(New cRecPU(800, 912, 256, 144))
				Me.table_4000_fg.Add(New cRecPU(850, 912, 256, 168))
				Me.table_4000_fg.Add(New cRecPU(900, 912, 256, 192))
				Me.table_4500_fg.Clear()
				Me.table_4500_fg.Add(New cRecPU(50, 114, 130, 54))
				Me.table_4500_fg.Add(New cRecPU(100, 160, 150, 64))
				Me.table_4500_fg.Add(New cRecPU(150, 228, 160, 74))
				Me.table_4500_fg.Add(New cRecPU(200, 320, 173, 74))
				Me.table_4500_fg.Add(New cRecPU(300, 320, 200, 74))
				Me.table_4500_fg.Add(New cRecPU(350, 320, 213, 74))
				Me.table_4500_fg.Add(New cRecPU(500, 456, 256, 86))
				Me.table_4500_fg.Add(New cRecPU(550, 456, 305, 86))
				Me.table_4500_fg.Add(New cRecPU(650, 640, 305, 100))
				Me.table_4500_fg.Add(New cRecPU(800, 912, 305, 120))
				Me.table_5000_fg.Clear()
				Me.table_5000_fg.Add(New cRecPU(50, 114, 173, 64))
				Me.table_5000_fg.Add(New cRecPU(150, 160, 173, 64))
				Me.table_5000_fg.Add(New cRecPU(200, 228, 173, 74))
				Me.table_5000_fg.Add(New cRecPU(225, 320, 200, 86))
				Me.table_5000_fg.Add(New cRecPU(250, 456, 200, 100))
				Me.table_5000_fg.Add(New cRecPU(300, 456, 213, 100))
				Me.table_5000_fg.Add(New cRecPU(400, 456, 246, 100))
				Me.table_5000_fg.Add(New cRecPU(550, 640, 256, 100))
				Me.table_5000_fg.Add(New cRecPU(750, 640, 305, 100))
				Me.table_5500_fg.Clear()
				Me.table_5500_fg.Add(New cRecPU(50, 114, 173, 64))
				Me.table_5500_fg.Add(New cRecPU(100, 160, 173, 64))
				Me.table_5500_fg.Add(New cRecPU(150, 228, 173, 74))
				Me.table_5500_fg.Add(New cRecPU(200, 320, 200, 86))
				Me.table_5500_fg.Add(New cRecPU(250, 456, 256, 100))
				Me.table_5500_fg.Add(New cRecPU(300, 640, 256, 120))
				Me.table_5500_fg.Add(New cRecPU(400, 640, 305, 120))
				Me.table_5500_fg.Add(New cRecPU(700, 640, 305, 100))
				Me.table_5500_fg.Add(New cRecPU(750, 640, 305, 120))
				Me.table_5500_fg.Add(New cRecPU(850, 912, 305, 120))
				Me.table_6000_fg.Clear()
				Me.table_6000_fg.Add(New cRecPU(50, 228, 173, 74))
				Me.table_6000_fg.Add(New cRecPU(100, 160, 173, 74))
				Me.table_6000_fg.Add(New cRecPU(200, 320, 213, 86))
				Me.table_6000_fg.Add(New cRecPU(250, 456, 213, 86))
				Me.table_6000_fg.Add(New cRecPU(350, 456, 246, 86))
				Me.table_6000_fg.Add(New cRecPU(400, 456, 305, 86))
				Me.table_6000_fg.Add(New cRecPU(550, 640, 305, 100))
				Me.table_6000_fg.Add(New cRecPU(750, 640, 356, 100))
				Me.table_6000_fg.Add(New cRecPU(850, 912, 365, 120))
				Me.table_6500_fg.Clear()
				Me.table_6500_fg.Add(New cRecPU(100, 228, 173, 74))
				Me.table_6500_fg.Add(New cRecPU(150, 228, 200, 74))
				Me.table_6500_fg.Add(New cRecPU(200, 320, 213, 86))
				Me.table_6500_fg.Add(New cRecPU(300, 456, 246, 86))
				Me.table_6500_fg.Add(New cRecPU(350, 456, 305, 86))
				Me.table_6500_fg.Add(New cRecPU(500, 640, 305, 100))
				Me.table_6500_fg.Add(New cRecPU(550, 640, 356, 100))
				Me.table_6500_fg.Add(New cRecPU(650, 912, 365, 120))
				Me.table_6500_fg.Add(New cRecPU(775, 1280, 365, 144))
				Me.table_7000_fg.Clear()
				Me.table_7000_fg.Add(New cRecPU(100, 228, 200, 74))
				Me.table_7000_fg.Add(New cRecPU(200, 320, 200, 86))
				Me.table_7000_fg.Add(New cRecPU(300, 456, 246, 86))
				Me.table_7000_fg.Add(New cRecPU(400, 640, 305, 100))
				Me.table_7000_fg.Add(New cRecPU(550, 912, 365, 120))
				Me.table_7000_fg.Add(New cRecPU(650, 1280, 365, 144))
				Me.table_7000_fg.Add(New cRecPU(700, 1280, 427, 144))
				Me.table_7000_fg.Add(New cRecPU(800, 1824, 356, 192))
				Me.table_7500_fg.Clear()
				Me.table_7500_fg.Add(New cRecPU(100, 228, 200, 74))
				Me.table_7500_fg.Add(New cRecPU(150, 320, 213, 86))
				Me.table_7500_fg.Add(New cRecPU(200, 320, 235, 86))
				Me.table_7500_fg.Add(New cRecPU(300, 456, 305, 100))
				Me.table_7500_fg.Add(New cRecPU(400, 640, 365, 120))
				Me.table_7500_fg.Add(New cRecPU(500, 912, 305, 144))
				Me.table_7500_fg.Add(New cRecPU(600, 1280, 305, 168))
				Me.table_7500_fg.Add(New cRecPU(650, 1280, 356, 192))
				Me.table_7500_fg.Add(New cRecPU(800, 1824, 356, 192))
				Me.table_8000_fg.Clear()
				Me.table_8000_fg.Add(New cRecPU(150, 228, 213, 74))
				Me.table_8000_fg.Add(New cRecPU(200, 320, 305, 86))
				Me.table_8000_fg.Add(New cRecPU(300, 456, 305, 100))
				Me.table_8000_fg.Add(New cRecPU(375, 640, 305, 120))
				Me.table_8000_fg.Add(New cRecPU(450, 912, 305, 144))
				Me.table_8000_fg.Add(New cRecPU(500, 1280, 305, 168))
				Me.table_8000_fg.Add(New cRecPU(650, 1280, 305, 192))
				Me.table_8000_fg.Add(New cRecPU(700, 1824, 305, 192))
				Me.table_8500_fg.Clear()
				Me.table_8500_fg.Add(New cRecPU(100, 228, 246, 74))
				Me.table_8500_fg.Add(New cRecPU(200, 320, 246, 86))
				Me.table_8500_fg.Add(New cRecPU(250, 456, 305, 100))
				Me.table_8500_fg.Add(New cRecPU(350, 640, 305, 120))
				Me.table_8500_fg.Add(New cRecPU(400, 912, 305, 144))
				Me.table_8500_fg.Add(New cRecPU(450, 912, 305, 144))
				Me.table_8500_fg.Add(New cRecPU(550, 1280, 305, 168))
				Me.table_8500_fg.Add(New cRecPU(650, 1280, 365, 168))
				Me.table_8500_fg.Add(New cRecPU(750, 1824, 365, 192))
				Me.table_9000_fg.Clear()
				Me.table_9000_fg.Add(New cRecPU(100, 228, 200, 74))
				Me.table_9000_fg.Add(New cRecPU(150, 320, 213, 100))
				Me.table_9000_fg.Add(New cRecPU(175, 456, 256, 120))
				Me.table_9000_fg.Add(New cRecPU(250, 640, 256, 120))
				Me.table_9000_fg.Add(New cRecPU(300, 912, 305, 144))
				Me.table_9000_fg.Add(New cRecPU(450, 912, 365, 144))
				Me.table_9000_fg.Add(New cRecPU(500, 1280, 305, 168))
				Me.table_9000_fg.Add(New cRecPU(600, 1280, 305, 192))
				Me.table_9000_fg.Add(New cRecPU(700, 1824, 305, 216))
				Me.table_9500_fg.Clear()
				Me.table_9500_fg.Add(New cRecPU(50, 228, 246, 74))
				Me.table_9500_fg.Add(New cRecPU(100, 320, 246, 86))
				Me.table_9500_fg.Add(New cRecPU(150, 456, 246, 100))
				Me.table_9500_fg.Add(New cRecPU(250, 640, 305, 120))
				Me.table_9500_fg.Add(New cRecPU(300, 640, 305, 144))
				Me.table_9500_fg.Add(New cRecPU(400, 912, 365, 144))
				Me.table_9500_fg.Add(New cRecPU(450, 1280, 365, 168))
				Me.table_9500_fg.Add(New cRecPU(500, 1280, 365, 192))
				Me.table_9500_fg.Add(New cRecPU(700, 1824, 365, 216))
				Me.table_9500_fg.Add(New cRecPU(725, 1824, 365, 240))
				Me.table_10000_fg.Clear()
				Me.table_10000_fg.Add(New cRecPU(50, 228, 246, 86))
				Me.table_10000_fg.Add(New cRecPU(100, 320, 246, 100))
				Me.table_10000_fg.Add(New cRecPU(150, 456, 246, 100))
				Me.table_10000_fg.Add(New cRecPU(200, 640, 305, 120))
				Me.table_10000_fg.Add(New cRecPU(300, 912, 305, 144))
				Me.table_10000_fg.Add(New cRecPU(400, 912, 305, 168))
				Me.table_10000_fg.Add(New cRecPU(500, 1280, 365, 192))
				Me.table_10000_fg.Add(New cRecPU(650, 1824, 365, 216))
				Me.table_10000_fg.Add(New cRecPU(700, 1824, 365, 240))
				Me.table_10500_fg.Clear()
				Me.table_10500_fg.Add(New cRecPU(50, 228, 246, 86))
				Me.table_10500_fg.Add(New cRecPU(100, 320, 256, 100))
				Me.table_10500_fg.Add(New cRecPU(150, 456, 256, 120))
				Me.table_10500_fg.Add(New cRecPU(200, 640, 305, 144))
				Me.table_10500_fg.Add(New cRecPU(350, 912, 305, 168))
				Me.table_10500_fg.Add(New cRecPU(400, 1280, 305, 192))
				Me.table_10500_fg.Add(New cRecPU(500, 1824, 427, 192))
				Me.table_10500_fg.Add(New cRecPU(600, 1824, 427, 216))
				Me.table_10500_fg.Add(New cRecPU(700, 1824, 365, 240))
				Me.table_11000_fg.Clear()
				Me.table_11000_fg.Add(New cRecPU(50, 228, 246, 86))
				Me.table_11000_fg.Add(New cRecPU(100, 320, 246, 100))
				Me.table_11000_fg.Add(New cRecPU(150, 456, 305, 120))
				Me.table_11000_fg.Add(New cRecPU(250, 640, 305, 144))
				Me.table_11000_fg.Add(New cRecPU(300, 912, 335, 168))
				Me.table_11000_fg.Add(New cRecPU(400, 1280, 365, 192))
				Me.table_11000_fg.Add(New cRecPU(450, 1824, 427, 216))
				Me.table_11000_fg.Add(New cRecPU(600, 1824, 427, 240))
				Me.table_12000_fg.Clear()
				Me.table_12000_fg.Add(New cRecPU(50, 228, 246, 86))
				Me.table_12000_fg.Add(New cRecPU(100, 456, 305, 120))
				Me.table_12000_fg.Add(New cRecPU(200, 640, 305, 144))
				Me.table_12000_fg.Add(New cRecPU(200, 640, 305, 156))
				Me.table_12000_fg.Add(New cRecPU(250, 912, 365, 168))
				Me.table_12000_fg.Add(New cRecPU(300, 912, 427, 196))
				Me.table_12000_fg.Add(New cRecPU(350, 1280, 427, 216))
				Me.table_12000_fg.Add(New cRecPU(400, 1824, 427, 240))
				Me.table_13000_fg.Clear()
				Me.table_13000_fg.Add(New cRecPU(50, 320, 256, 100))
				Me.table_13000_fg.Add(New cRecPU(75, 456, 273, 120))
				Me.table_13000_fg.Add(New cRecPU(100, 456, 305, 120))
				Me.table_13000_fg.Add(New cRecPU(200, 912, 305, 168))
				Me.table_13000_fg.Add(New cRecPU(250, 1280, 427, 192))
				Me.table_13000_fg.Add(New cRecPU(300, 1280, 427, 216))
				Me.table_14000_fg.Clear()
				Me.table_14000_fg.Add(New cRecPU(75, 456, 305, 120))
				Me.table_14000_fg.Add(New cRecPU(100, 640, 305, 144))
				Me.table_14000_fg.Add(New cRecPU(150, 912, 365, 168))
				Me.table_14000_fg.Add(New cRecPU(200, 1280, 365, 192))
				Me.table_14000_fg.Add(New cRecPU(250, 1280, 427, 216))
				Me.table_15000_fg.Clear()
				Me.table_15000_fg.Add(New cRecPU(50, 456, 305, 144))
				Me.table_15000_fg.Add(New cRecPU(100, 640, 305, 168))
				Me.table_15000_fg.Add(New cRecPU(150, 912, 365, 192))
				Me.table_15000_fg.Add(New cRecPU(200, 1280, 427, 216))
				Me.table_15000_fg.Add(New cRecPU(350, 1824, 427, 240))
				Me.table_16000_fg.Clear()
				Me.table_16000_fg.Add(New cRecPU(100, 640, 335, 168))
				Me.table_16000_fg.Add(New cRecPU(150, 912, 335, 192))
				Me.table_16000_fg.Add(New cRecPU(200, 1280, 335, 216))
				Me.table_16000_fg.Add(New cRecPU(300, 1824, 470, 240))
				Me.table_17000_fg.Clear()
				Me.table_17000_fg.Add(New cRecPU(50, 640, 335, 168))
				Me.table_17000_fg.Add(New cRecPU(100, 912, 365, 192))
				Me.table_17000_fg.Add(New cRecPU(150, 912, 365, 216))
				Me.table_17000_fg.Add(New cRecPU(250, 1280, 365, 240))
				Me.table_18000_fg.Clear()
				Me.table_18000_fg.Add(New cRecPU(100, 912, 365, 192))
				Me.table_18000_fg.Add(New cRecPU(150, 1280, 427, 216))
				Me.table_19000_fg.Clear()
				Me.table_19000_fg.Add(New cRecPU(50, 912, 427, 192))
				Me.table_19000_fg.Add(New cRecPU(100, 912, 427, 216))
				Me.table_19000_fg.Add(New cRecPU(150, 1280, 470, 240))
				Me.table_20000_fg.Clear()
				Me.table_20000_fg.Add(New cRecPU(100, 912, 427, 216))
				Me.table_20000_fg.Add(New cRecPU(150, 1280, 470, 240))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUStal_AB()
			Try
				Me.table_1000_fg.Clear()
				Me.table_1000_fg.Add(New cRecPU(50, 25, 35, 54))
				Me.table_1000_fg.Add(New cRecPU(100, 35, 40, 54))
				Me.table_1000_fg.Add(New cRecPU(150, 40, 40, 54))
				Me.table_1000_fg.Add(New cRecPU(200, 75, 85, 54))
				Me.table_1000_fg.Add(New cRecPU(300, 55, 50, 64))
				Me.table_1000_fg.Add(New cRecPU(350, 60, 55, 64))
				Me.table_1000_fg.Add(New cRecPU(400, 65, 55, 64))
				Me.table_1000_fg.Add(New cRecPU(450, 70, 60, 64))
				Me.table_1000_fg.Add(New cRecPU(500, 75, 60, 64))
				Me.table_1000_fg.Add(New cRecPU(600, 80, 70, 64))
				Me.table_1000_fg.Add(New cRecPU(650, 95, 80, 64))
				Me.table_1000_fg.Add(New cRecPU(700, 114, 80, 64))
				Me.table_1000_fg.Add(New cRecPU(750, 114, 80, 74))
				Me.table_1000_fg.Add(New cRecPU(800, 160, 80, 74))
				Me.table_1000_fg.Add(New cRecPU(950, 160, 80, 86))
				Me.table_1000_fg.Add(New cRecPU(1000, 228, 90, 100))
				Me.table_1000_fg.Add(New cRecPU(1100, 228, 90, 120))
				Me.table_1000_fg.Add(New cRecPU(1250, 228, 100, 120))
				Me.table_1000_fg.Add(New cRecPU(1300, 228, 105, 120))
				Me.table_1000_fg.Add(New cRecPU(1600, 320, 110, 120))
				Me.table_1000_fg.Add(New cRecPU(1900, 456, 120, 144))
				Me.table_1000_fg.Add(New cRecPU(2600, 456, 160, 144))
				Me.table_1000_fg.Add(New cRecPU(2800, 640, 173, 144))
				Me.table_1000_fg.Add(New cRecPU(2900, 640, 173, 168))
				Me.table_1000_fg.Add(New cRecPU(3200, 640, 190, 168))
				Me.table_1000_fg.Add(New cRecPU(3500, 912, 190, 216))
				Me.table_1000_fg.Add(New cRecPU(3700, 912, 190, 240))
				Me.table_1000_fg.Add(New cRecPU(3800, 1280, 200, 240))
				Me.table_1000_fg.Add(New cRecPU(4200, 1280, 220, 240))
				Me.table_1000_fg.Add(New cRecPU(4600, 1280, 246, 240))
				Me.table_1000_fg.Add(New cRecPU(5200, 1824, 305, 240))
				Me.table_1000_fg.Add(New cRecPU(5400, 1824, 315, 240))
				Me.table_1000_fg.Add(New cRecPU(6100, 1824, 356, 240))
				Me.table_1500_fg.Clear()
				Me.table_1500_fg.Add(New cRecPU(50, 35, 43, 54))
				Me.table_1500_fg.Add(New cRecPU(100, 45, 53, 54))
				Me.table_1500_fg.Add(New cRecPU(150, 50, 55, 54))
				Me.table_1500_fg.Add(New cRecPU(200, 60, 65, 54))
				Me.table_1500_fg.Add(New cRecPU(300, 70, 75, 54))
				Me.table_1500_fg.Add(New cRecPU(350, 80, 85, 54))
				Me.table_1500_fg.Add(New cRecPU(400, 114, 85, 64))
				Me.table_1500_fg.Add(New cRecPU(500, 114, 100, 64))
				Me.table_1500_fg.Add(New cRecPU(550, 114, 119, 64))
				Me.table_1500_fg.Add(New cRecPU(650, 160, 119, 64))
				Me.table_1500_fg.Add(New cRecPU(700, 160, 135, 74))
				Me.table_1500_fg.Add(New cRecPU(750, 228, 135, 74))
				Me.table_1500_fg.Add(New cRecPU(800, 228, 150, 74))
				Me.table_1500_fg.Add(New cRecPU(1000, 228, 160, 86))
				Me.table_1500_fg.Add(New cRecPU(1100, 320, 160, 92))
				Me.table_1500_fg.Add(New cRecPU(1200, 320, 173, 100))
				Me.table_1500_fg.Add(New cRecPU(1300, 320, 160, 120))
				Me.table_1500_fg.Add(New cRecPU(1400, 456, 173, 120))
				Me.table_1500_fg.Add(New cRecPU(1600, 456, 190, 120))
				Me.table_1500_fg.Add(New cRecPU(1800, 640, 190, 144))
				Me.table_1500_fg.Add(New cRecPU(2000, 640, 200, 144))
				Me.table_1500_fg.Add(New cRecPU(2300, 640, 246, 144))
				Me.table_1500_fg.Add(New cRecPU(2500, 912, 246, 168))
				Me.table_1500_fg.Add(New cRecPU(2900, 912, 246, 192))
				Me.table_1500_fg.Add(New cRecPU(3200, 1280, 246, 216))
				Me.table_1500_fg.Add(New cRecPU(3500, 1280, 269, 216))
				Me.table_1500_fg.Add(New cRecPU(3600, 1280, 280, 216))
				Me.table_1500_fg.Add(New cRecPU(4000, 1280, 305, 216))
				Me.table_1500_fg.Add(New cRecPU(4300, 1824, 305, 240))
				Me.table_1500_fg.Add(New cRecPU(4500, 1824, 310, 240))
				Me.table_1500_fg.Add(New cRecPU(4700, 1824, 356, 240))
				Me.table_1500_fg.Add(New cRecPU(4800, 1824, 365, 240))
				Me.table_1500_fg.Add(New cRecPU(6000, 2560, 427, 240))
				Me.table_2000_fg.Clear()
				Me.table_2000_fg.Add(New cRecPU(50, 40, 53, 54))
				Me.table_2000_fg.Add(New cRecPU(100, 57, 67, 54))
				Me.table_2000_fg.Add(New cRecPU(150, 65, 72, 54))
				Me.table_2000_fg.Add(New cRecPU(200, 75, 80, 54))
				Me.table_2000_fg.Add(New cRecPU(250, 82, 90, 54))
				Me.table_2000_fg.Add(New cRecPU(300, 114, 102, 54))
				Me.table_2000_fg.Add(New cRecPU(350, 114, 115, 54))
				Me.table_2000_fg.Add(New cRecPU(400, 160, 119, 64))
				Me.table_2000_fg.Add(New cRecPU(550, 160, 130, 64))
				Me.table_2000_fg.Add(New cRecPU(750, 228, 173, 74))
				Me.table_2000_fg.Add(New cRecPU(800, 320, 173, 86))
				Me.table_2000_fg.Add(New cRecPU(1000, 320, 190, 86))
				Me.table_2000_fg.Add(New cRecPU(1200, 456, 200, 100))
				Me.table_2000_fg.Add(New cRecPU(1300, 456, 246, 100))
				Me.table_2000_fg.Add(New cRecPU(1600, 640, 246, 120))
				Me.table_2000_fg.Add(New cRecPU(1700, 640, 305, 120))
				Me.table_2000_fg.Add(New cRecPU(1800, 912, 269, 144))
				Me.table_2000_fg.Add(New cRecPU(1900, 912, 273, 144))
				Me.table_2000_fg.Add(New cRecPU(2000, 912, 305, 144))
				Me.table_2000_fg.Add(New cRecPU(2100, 912, 305, 168))
				Me.table_2000_fg.Add(New cRecPU(2600, 1280, 305, 168))
				Me.table_2000_fg.Add(New cRecPU(2700, 1280, 310, 192))
				Me.table_2000_fg.Add(New cRecPU(2900, 1280, 320, 192))
				Me.table_2000_fg.Add(New cRecPU(3100, 1824, 320, 216))
				Me.table_2000_fg.Add(New cRecPU(3300, 1824, 356, 216))
				Me.table_2000_fg.Add(New cRecPU(3400, 1824, 356, 216))
				Me.table_2000_fg.Add(New cRecPU(3600, 1824, 365, 216))
				Me.table_2000_fg.Add(New cRecPU(3800, 1824, 427, 216))
				Me.table_2000_fg.Add(New cRecPU(4200, 1824, 427, 240))
				Me.table_2500_fg.Clear()
				Me.table_2500_fg.Add(New cRecPU(50, 45, 67, 54))
				Me.table_2500_fg.Add(New cRecPU(100, 60, 80, 54))
				Me.table_2500_fg.Add(New cRecPU(150, 80, 95, 54))
				Me.table_2500_fg.Add(New cRecPU(200, 114, 110, 54))
				Me.table_2500_fg.Add(New cRecPU(300, 114, 130, 54))
				Me.table_2500_fg.Add(New cRecPU(350, 160, 135, 64))
				Me.table_2500_fg.Add(New cRecPU(400, 160, 150, 64))
				Me.table_2500_fg.Add(New cRecPU(500, 228, 160, 74))
				Me.table_2500_fg.Add(New cRecPU(550, 228, 173, 74))
				Me.table_2500_fg.Add(New cRecPU(650, 320, 173, 86))
				Me.table_2500_fg.Add(New cRecPU(700, 320, 200, 86))
				Me.table_2500_fg.Add(New cRecPU(750, 320, 213, 86))
				Me.table_2500_fg.Add(New cRecPU(1000, 456, 213, 100))
				Me.table_2500_fg.Add(New cRecPU(1100, 456, 246, 100))
				Me.table_2500_fg.Add(New cRecPU(1300, 640, 269, 100))
				Me.table_2500_fg.Add(New cRecPU(1400, 640, 273, 100))
				Me.table_2500_fg.Add(New cRecPU(1500, 640, 305, 100))
				Me.table_2500_fg.Add(New cRecPU(1800, 912, 365, 120))
				Me.table_2500_fg.Add(New cRecPU(2000, 1280, 365, 144))
				Me.table_2500_fg.Add(New cRecPU(2500, 1280, 427, 144))
				Me.table_2500_fg.Add(New cRecPU(2700, 1824, 427, 168))
				Me.table_2500_fg.Add(New cRecPU(2900, 1824, 427, 192))
				Me.table_2500_fg.Add(New cRecPU(3100, 1824, 470, 192))
				Me.table_2500_fg.Add(New cRecPU(3700, 2560, 470, 240))
				Me.table_3000_fg.Clear()
				Me.table_3000_fg.Add(New cRecPU(50, 57, 90, 54))
				Me.table_3000_fg.Add(New cRecPU(100, 75, 100, 54))
				Me.table_3000_fg.Add(New cRecPU(150, 95, 110, 54))
				Me.table_3000_fg.Add(New cRecPU(200, 114, 120, 64))
				Me.table_3000_fg.Add(New cRecPU(300, 160, 145, 74))
				Me.table_3000_fg.Add(New cRecPU(350, 228, 160, 74))
				Me.table_3000_fg.Add(New cRecPU(450, 228, 173, 74))
				Me.table_3000_fg.Add(New cRecPU(550, 320, 200, 86))
				Me.table_3000_fg.Add(New cRecPU(600, 320, 190, 92))
				Me.table_3000_fg.Add(New cRecPU(950, 456, 246, 100))
				Me.table_3000_fg.Add(New cRecPU(1000, 640, 250, 120))
				Me.table_3000_fg.Add(New cRecPU(1100, 640, 269, 120))
				Me.table_3000_fg.Add(New cRecPU(1200, 912, 305, 120))
				Me.table_3000_fg.Add(New cRecPU(1500, 912, 365, 120))
				Me.table_3000_fg.Add(New cRecPU(1600, 1280, 365, 168))
				Me.table_3000_fg.Add(New cRecPU(1900, 1280, 365, 192))
				Me.table_3000_fg.Add(New cRecPU(2100, 1824, 427, 192))
				Me.table_3000_fg.Add(New cRecPU(3200, 2560, 470, 240))
				Me.table_3500_fg.Clear()
				Me.table_3500_fg.Add(New cRecPU(50, 70, 100, 54))
				Me.table_3500_fg.Add(New cRecPU(100, 85, 112, 54))
				Me.table_3500_fg.Add(New cRecPU(150, 114, 160, 54))
				Me.table_3500_fg.Add(New cRecPU(200, 160, 200, 64))
				Me.table_3500_fg.Add(New cRecPU(350, 228, 200, 74))
				Me.table_3500_fg.Add(New cRecPU(400, 228, 190, 86))
				Me.table_3500_fg.Add(New cRecPU(450, 320, 200, 86))
				Me.table_3500_fg.Add(New cRecPU(500, 320, 246, 86))
				Me.table_3500_fg.Add(New cRecPU(550, 456, 246, 100))
				Me.table_3500_fg.Add(New cRecPU(650, 456, 246, 120))
				Me.table_3500_fg.Add(New cRecPU(900, 640, 246, 120))
				Me.table_3500_fg.Add(New cRecPU(950, 640, 256, 120))
				Me.table_3500_fg.Add(New cRecPU(1000, 640, 269, 120))
				Me.table_3500_fg.Add(New cRecPU(1100, 912, 273, 144))
				Me.table_3500_fg.Add(New cRecPU(1200, 912, 356, 144))
				Me.table_3500_fg.Add(New cRecPU(1300, 1280, 356, 168))
				Me.table_3500_fg.Add(New cRecPU(1400, 1280, 356, 168))
				Me.table_3500_fg.Add(New cRecPU(1700, 1824, 427, 190))
				Me.table_3500_fg.Add(New cRecPU(2000, 1824, 427, 216))
				Me.table_3500_fg.Add(New cRecPU(2400, 2560, 470, 240))
				Me.table_4000_fg.Clear()
				Me.table_4000_fg.Add(New cRecPU(50, 80, 110, 54))
				Me.table_4000_fg.Add(New cRecPU(100, 114, 160, 54))
				Me.table_4000_fg.Add(New cRecPU(150, 160, 160, 64))
				Me.table_4000_fg.Add(New cRecPU(250, 228, 160, 74))
				Me.table_4000_fg.Add(New cRecPU(300, 228, 173, 74))
				Me.table_4000_fg.Add(New cRecPU(350, 320, 200, 86))
				Me.table_4000_fg.Add(New cRecPU(450, 320, 246, 86))
				Me.table_4000_fg.Add(New cRecPU(500, 456, 200, 100))
				Me.table_4000_fg.Add(New cRecPU(550, 456, 246, 100))
				Me.table_4000_fg.Add(New cRecPU(600, 640, 200, 120))
				Me.table_4000_fg.Add(New cRecPU(750, 640, 246, 144))
				Me.table_4000_fg.Add(New cRecPU(800, 912, 250, 168))
				Me.table_4000_fg.Add(New cRecPU(900, 912, 269, 168))
				Me.table_4000_fg.Add(New cRecPU(1050, 912, 305, 168))
				Me.table_4000_fg.Add(New cRecPU(1100, 1280, 310, 192))
				Me.table_4000_fg.Add(New cRecPU(1300, 1824, 356, 192))
				Me.table_4000_fg.Add(New cRecPU(1400, 1824, 365, 192))
				Me.table_4000_fg.Add(New cRecPU(1500, 1824, 410, 192))
				Me.table_4000_fg.Add(New cRecPU(1600, 1824, 427, 240))
				Me.table_4000_fg.Add(New cRecPU(1700, 2560, 427, 240))
				Me.table_4000_fg.Add(New cRecPU(2100, 2560, 470, 240))
				Me.table_4500_fg.Clear()
				Me.table_4500_fg.Add(New cRecPU(100, 114, 160, 54))
				Me.table_4500_fg.Add(New cRecPU(150, 160, 190, 64))
				Me.table_4500_fg.Add(New cRecPU(200, 228, 200, 74))
				Me.table_4500_fg.Add(New cRecPU(300, 320, 246, 86))
				Me.table_4500_fg.Add(New cRecPU(350, 456, 246, 88))
				Me.table_4500_fg.Add(New cRecPU(450, 456, 246, 100))
				Me.table_4500_fg.Add(New cRecPU(500, 640, 256, 100))
				Me.table_4500_fg.Add(New cRecPU(600, 640, 302, 100))
				Me.table_4500_fg.Add(New cRecPU(650, 912, 302, 120))
				Me.table_4500_fg.Add(New cRecPU(850, 912, 310, 144))
				Me.table_4500_fg.Add(New cRecPU(950, 912, 350, 144))
				Me.table_4500_fg.Add(New cRecPU(1050, 1280, 360, 144))
				Me.table_4500_fg.Add(New cRecPU(1100, 1280, 370, 144))
				Me.table_4500_fg.Add(New cRecPU(1200, 1824, 410, 192))
				Me.table_4500_fg.Add(New cRecPU(1300, 1824, 420, 192))
				Me.table_4500_fg.Add(New cRecPU(1600, 1824, 470, 200))
				Me.table_4500_fg.Add(New cRecPU(1650, 2560, 470, 240))
				Me.table_5000_fg.Clear()
				Me.table_5000_fg.Add(New cRecPU(50, 114, 135, 54))
				Me.table_5000_fg.Add(New cRecPU(100, 160, 200, 64))
				Me.table_5000_fg.Add(New cRecPU(150, 228, 246, 64))
				Me.table_5000_fg.Add(New cRecPU(200, 228, 246, 74))
				Me.table_5000_fg.Add(New cRecPU(250, 320, 246, 86))
				Me.table_5000_fg.Add(New cRecPU(350, 456, 246, 100))
				Me.table_5000_fg.Add(New cRecPU(400, 640, 269, 100))
				Me.table_5000_fg.Add(New cRecPU(450, 640, 273, 120))
				Me.table_5000_fg.Add(New cRecPU(550, 912, 273, 144))
				Me.table_5000_fg.Add(New cRecPU(600, 912, 305, 144))
				Me.table_5000_fg.Add(New cRecPU(700, 912, 335, 144))
				Me.table_5000_fg.Add(New cRecPU(800, 1280, 350, 168))
				Me.table_5000_fg.Add(New cRecPU(900, 1280, 365, 168))
				Me.table_5000_fg.Add(New cRecPU(1000, 1280, 365, 192))
				Me.table_5000_fg.Add(New cRecPU(1100, 1824, 360, 216))
				Me.table_5000_fg.Add(New cRecPU(1200, 1824, 427, 240))
				Me.table_5000_fg.Add(New cRecPU(1300, 1824, 470, 240))
				Me.table_5000_fg.Add(New cRecPU(1500, 2560, 470, 240))
				Me.table_5500_fg.Clear()
				Me.table_5500_fg.Add(New cRecPU(50, 114, 173, 64))
				Me.table_5500_fg.Add(New cRecPU(100, 160, 200, 64))
				Me.table_5500_fg.Add(New cRecPU(150, 228, 246, 74))
				Me.table_5500_fg.Add(New cRecPU(200, 320, 246, 86))
				Me.table_5500_fg.Add(New cRecPU(250, 456, 246, 100))
				Me.table_5500_fg.Add(New cRecPU(350, 456, 273, 86))
				Me.table_5500_fg.Add(New cRecPU(450, 640, 273, 120))
				Me.table_5500_fg.Add(New cRecPU(500, 912, 335, 120))
				Me.table_5500_fg.Add(New cRecPU(550, 912, 365, 120))
				Me.table_5500_fg.Add(New cRecPU(850, 1280, 427, 144))
				Me.table_5500_fg.Add(New cRecPU(950, 1824, 427, 168))
				Me.table_5500_fg.Add(New cRecPU(1150, 1824, 470, 200))
				Me.table_6000_fg.Clear()
				Me.table_6000_fg.Add(New cRecPU(50, 114, 173, 64))
				Me.table_6000_fg.Add(New cRecPU(75, 160, 200, 74))
				Me.table_6000_fg.Add(New cRecPU(100, 228, 200, 74))
				Me.table_6000_fg.Add(New cRecPU(150, 320, 246, 86))
				Me.table_6000_fg.Add(New cRecPU(250, 456, 246, 100))
				Me.table_6000_fg.Add(New cRecPU(400, 640, 305, 100))
				Me.table_6000_fg.Add(New cRecPU(500, 912, 365, 120))
				Me.table_6000_fg.Add(New cRecPU(650, 1280, 427, 144))
				Me.table_6000_fg.Add(New cRecPU(750, 1280, 427, 168))
				Me.table_6000_fg.Add(New cRecPU(850, 1824, 427, 192))
				Me.table_6000_fg.Add(New cRecPU(950, 1824, 470, 240))
				Me.table_6000_fg.Add(New cRecPU(1000, 2560, 470, 240))
				Me.table_6000_fg.Add(New cRecPU(1100, 2560, 515, 240))
				Me.table_6500_fg.Clear()
				Me.table_6500_fg.Add(New cRecPU(50, 160, 200, 64))
				Me.table_6500_fg.Add(New cRecPU(100, 228, 246, 74))
				Me.table_6500_fg.Add(New cRecPU(200, 320, 246, 74))
				Me.table_6500_fg.Add(New cRecPU(250, 456, 246, 86))
				Me.table_6500_fg.Add(New cRecPU(300, 456, 273, 86))
				Me.table_6500_fg.Add(New cRecPU(350, 640, 305, 100))
				Me.table_6500_fg.Add(New cRecPU(500, 912, 365, 120))
				Me.table_6500_fg.Add(New cRecPU(600, 1280, 427, 144))
				Me.table_6500_fg.Add(New cRecPU(700, 1824, 427, 192))
				Me.table_6500_fg.Add(New cRecPU(750, 1824, 427, 216))
				Me.table_6500_fg.Add(New cRecPU(1000, 2560, 470, 240))
				Me.table_7000_fg.Clear()
				Me.table_7000_fg.Add(New cRecPU(100, 228, 246, 64))
				Me.table_7000_fg.Add(New cRecPU(200, 320, 246, 74))
				Me.table_7000_fg.Add(New cRecPU(250, 456, 275, 86))
				Me.table_7000_fg.Add(New cRecPU(350, 640, 305, 100))
				Me.table_7000_fg.Add(New cRecPU(450, 912, 365, 120))
				Me.table_7000_fg.Add(New cRecPU(500, 1280, 427, 144))
				Me.table_7000_fg.Add(New cRecPU(550, 1280, 427, 168))
				Me.table_7000_fg.Add(New cRecPU(600, 1824, 427, 192))
				Me.table_7000_fg.Add(New cRecPU(650, 1824, 427, 216))
				Me.table_7000_fg.Add(New cRecPU(800, 1824, 470, 240))
				Me.table_7000_fg.Add(New cRecPU(900, 2560, 470, 240))
				Me.table_7500_fg.Clear()
				Me.table_7500_fg.Add(New cRecPU(50, 228, 246, 74))
				Me.table_7500_fg.Add(New cRecPU(100, 320, 269, 86))
				Me.table_7500_fg.Add(New cRecPU(250, 456, 305, 86))
				Me.table_7500_fg.Add(New cRecPU(300, 640, 305, 100))
				Me.table_7500_fg.Add(New cRecPU(400, 912, 365, 120))
				Me.table_7500_fg.Add(New cRecPU(450, 1280, 427, 144))
				Me.table_7500_fg.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_7500_fg.Add(New cRecPU(550, 1824, 427, 216))
				Me.table_7500_fg.Add(New cRecPU(600, 1824, 470, 200))
				Me.table_7500_fg.Add(New cRecPU(750, 1824, 470, 240))
				Me.table_8000_fg.Clear()
				Me.table_8000_fg.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8000_fg.Add(New cRecPU(100, 320, 273, 86))
				Me.table_8000_fg.Add(New cRecPU(200, 456, 305, 100))
				Me.table_8000_fg.Add(New cRecPU(250, 640, 305, 100))
				Me.table_8000_fg.Add(New cRecPU(300, 640, 365, 100))
				Me.table_8000_fg.Add(New cRecPU(350, 912, 365, 120))
				Me.table_8000_fg.Add(New cRecPU(450, 1280, 427, 144))
				Me.table_8000_fg.Add(New cRecPU(500, 1824, 427, 192))
				Me.table_8000_fg.Add(New cRecPU(650, 1824, 470, 240))
				Me.table_8500_fg.Clear()
				Me.table_8500_fg.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8500_fg.Add(New cRecPU(100, 320, 305, 74))
				Me.table_8500_fg.Add(New cRecPU(200, 456, 305, 86))
				Me.table_8500_fg.Add(New cRecPU(300, 640, 356, 100))
				Me.table_8500_fg.Add(New cRecPU(400, 912, 427, 120))
				Me.table_8500_fg.Add(New cRecPU(450, 1280, 427, 144))
				Me.table_8500_fg.Add(New cRecPU(500, 1824, 470, 240))
				Me.table_8500_fg.Add(New cRecPU(550, 2560, 470, 240))
				Me.table_9000_fg.Clear()
				Me.table_9000_fg.Add(New cRecPU(50, 228, 280, 86))
				Me.table_9000_fg.Add(New cRecPU(100, 320, 246, 86))
				Me.table_9000_fg.Add(New cRecPU(200, 456, 305, 100))
				Me.table_9000_fg.Add(New cRecPU(250, 640, 365, 120))
				Me.table_9000_fg.Add(New cRecPU(350, 912, 427, 120))
				Me.table_9000_fg.Add(New cRecPU(400, 1280, 427, 144))
				Me.table_9000_fg.Add(New cRecPU(450, 912, 427, 120))
				Me.table_9000_fg.Add(New cRecPU(500, 1824, 470, 200))
				Me.table_9500_fg.Clear()
				Me.table_9500_fg.Add(New cRecPU(50, 228, 280, 74))
				Me.table_9500_fg.Add(New cRecPU(100, 320, 246, 86))
				Me.table_9500_fg.Add(New cRecPU(150, 320, 305, 74))
				Me.table_9500_fg.Add(New cRecPU(200, 456, 305, 100))
				Me.table_9500_fg.Add(New cRecPU(250, 640, 365, 120))
				Me.table_9500_fg.Add(New cRecPU(300, 912, 427, 144))
				Me.table_9500_fg.Add(New cRecPU(325, 1280, 427, 168))
				Me.table_9500_fg.Add(New cRecPU(350, 1824, 427, 192))
				Me.table_9500_fg.Add(New cRecPU(400, 1824, 470, 240))
				Me.table_9500_fg.Add(New cRecPU(475, 2560, 470, 240))
				Me.table_10000_fg.Clear()
				Me.table_10000_fg.Add(New cRecPU(50, 320, 305, 100))
				Me.table_10000_fg.Add(New cRecPU(150, 456, 365, 100))
				Me.table_10000_fg.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10000_fg.Add(New cRecPU(300, 912, 427, 144))
				Me.table_10000_fg.Add(New cRecPU(350, 1280, 427, 168))
				Me.table_10000_fg.Add(New cRecPU(375, 1824, 470, 240))
				Me.table_10000_fg.Add(New cRecPU(400, 2560, 470, 240))
				Me.table_10500_fg.Clear()
				Me.table_10500_fg.Add(New cRecPU(100, 320, 305, 86))
				Me.table_10500_fg.Add(New cRecPU(200, 456, 365, 100))
				Me.table_10500_fg.Add(New cRecPU(225, 640, 365, 100))
				Me.table_10500_fg.Add(New cRecPU(275, 912, 427, 144))
				Me.table_10500_fg.Add(New cRecPU(350, 1280, 427, 168))
				Me.table_11000_fg.Clear()
				Me.table_11000_fg.Add(New cRecPU(100, 320, 305, 86))
				Me.table_11000_fg.Add(New cRecPU(150, 456, 365, 100))
				Me.table_11000_fg.Add(New cRecPU(175, 640, 427, 120))
				Me.table_11000_fg.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11000_fg.Add(New cRecPU(325, 1280, 427, 168))
				Me.table_11500_fg.Clear()
				Me.table_11500_fg.Add(New cRecPU(50, 320, 256, 100))
				Me.table_11500_fg.Add(New cRecPU(75, 456, 310, 100))
				Me.table_11500_fg.Add(New cRecPU(150, 456, 365, 100))
				Me.table_11500_fg.Add(New cRecPU(175, 640, 427, 120))
				Me.table_11500_fg.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11500_fg.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_11500_fg.Add(New cRecPU(350, 1824, 470, 192))
				Me.table_12000_fg.Clear()
				Me.table_12000_fg.Add(New cRecPU(50, 456, 305, 100))
				Me.table_12000_fg.Add(New cRecPU(100, 456, 335, 100))
				Me.table_12000_fg.Add(New cRecPU(125, 456, 365, 100))
				Me.table_12000_fg.Add(New cRecPU(175, 640, 427, 120))
				Me.table_12000_fg.Add(New cRecPU(275, 912, 427, 144))
				Me.table_12000_fg.Add(New cRecPU(300, 1280, 427, 144))
				Me.table_12500_fg.Clear()
				Me.table_12500_fg.Add(New cRecPU(50, 456, 305, 100))
				Me.table_12500_fg.Add(New cRecPU(125, 456, 365, 100))
				Me.table_12500_fg.Add(New cRecPU(175, 640, 427, 120))
				Me.table_12500_fg.Add(New cRecPU(225, 912, 427, 144))
				Me.table_12500_fg.Add(New cRecPU(275, 1824, 470, 240))
				Me.table_13000_fg.Clear()
				Me.table_13000_fg.Add(New cRecPU(50, 320, 320, 100))
				Me.table_13000_fg.Add(New cRecPU(100, 456, 320, 100))
				Me.table_13000_fg.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13000_fg.Add(New cRecPU(225, 912, 427, 144))
				Me.table_13000_fg.Add(New cRecPU(250, 1280, 427, 168))
				Me.table_13000_fg.Add(New cRecPU(275, 1824, 470, 240))
				Me.table_13500_fg.Clear()
				Me.table_13500_fg.Add(New cRecPU(50, 320, 320, 100))
				Me.table_13500_fg.Add(New cRecPU(100, 456, 335, 100))
				Me.table_13500_fg.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13500_fg.Add(New cRecPU(200, 912, 427, 144))
				Me.table_14000_fg.Clear()
				Me.table_14000_fg.Add(New cRecPU(50, 456, 365, 120))
				Me.table_14000_fg.Add(New cRecPU(100, 640, 427, 120))
				Me.table_14000_fg.Add(New cRecPU(175, 912, 427, 144))
				Me.table_14000_fg.Add(New cRecPU(200, 1824, 470, 200))
				Me.table_15000_fg.Clear()
				Me.table_15000_fg.Add(New cRecPU(50, 456, 365, 120))
				Me.table_15000_fg.Add(New cRecPU(125, 640, 427, 120))
				Me.table_16000_fg.Clear()
				Me.table_16000_fg.Add(New cRecPU(50, 640, 427, 120))
				Me.table_16000_fg.Add(New cRecPU(100, 640, 427, 120))
				Me.table_17000_fg.Clear()
				Me.table_17000_fg.Add(New cRecPU(50, 456, 427, 120))
				Me.table_17000_fg.Add(New cRecPU(100, 1280, 470, 200))
				Me.table_18000_fg.Clear()
				Me.table_18000_fg.Add(New cRecPU(50, 1280, 470, 200))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUStal_RMark()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(50, 17, 30, 44))
				Me.table_1000_st.Add(New cRecPU(100, 30, 35, 59))
				Me.table_1000_st.Add(New cRecPU(150, 40, 37, 74))
				Me.table_1000_st.Add(New cRecPU(200, 52, 42, 74))
				Me.table_1000_st.Add(New cRecPU(250, 55, 45, 74))
				Me.table_1000_st.Add(New cRecPU(300, 64, 50, 74))
				Me.table_1000_st.Add(New cRecPU(400, 64, 55, 74))
				Me.table_1000_st.Add(New cRecPU(450, 70, 58, 74))
				Me.table_1000_st.Add(New cRecPU(500, 80, 60, 74))
				Me.table_1000_st.Add(New cRecPU(550, 80, 62, 74))
				Me.table_1000_st.Add(New cRecPU(650, 90, 65, 74))
				Me.table_1000_st.Add(New cRecPU(750, 114, 80, 74))
				Me.table_1000_st.Add(New cRecPU(800, 114, 82, 74))
				Me.table_1000_st.Add(New cRecPU(850, 130, 85, 74))
				Me.table_1000_st.Add(New cRecPU(1000, 145, 95, 74))
				Me.table_1000_st.Add(New cRecPU(1100, 160, 100, 86))
				Me.table_1000_st.Add(New cRecPU(1200, 180, 119, 86))
				Me.table_1000_st.Add(New cRecPU(1300, 228, 119, 100))
				Me.table_1000_st.Add(New cRecPU(1350, 228, 119, 100))
				Me.table_1000_st.Add(New cRecPU(1450, 320, 119, 120))
				Me.table_1000_st.Add(New cRecPU(1700, 320, 119, 144))
				Me.table_1000_st.Add(New cRecPU(1800, 320, 121, 144))
				Me.table_1000_st.Add(New cRecPU(1900, 456, 121, 168))
				Me.table_1000_st.Add(New cRecPU(2000, 456, 121, 192))
				Me.table_1000_st.Add(New cRecPU(2200, 640, 143, 192))
				Me.table_1000_st.Add(New cRecPU(2400, 640, 155, 192))
				Me.table_1000_st.Add(New cRecPU(2500, 640, 165, 192))
				Me.table_1000_st.Add(New cRecPU(2700, 640, 185, 192))
				Me.table_1000_st.Add(New cRecPU(3100, 640, 200, 192))
				Me.table_1000_st.Add(New cRecPU(3400, 912, 200, 192))
				Me.table_1000_st.Add(New cRecPU(3600, 912, 220, 192))
				Me.table_1000_st.Add(New cRecPU(4100, 1280, 305, 192))
				Me.table_1000_st.Add(New cRecPU(4700, 1280, 365, 192))
				Me.table_1000_st.Add(New cRecPU(4800, 1824, 365, 192))
				Me.table_1500_st.Clear()
				Me.table_1500_st.Add(New cRecPU(50, 24, 43, 44))
				Me.table_1500_st.Add(New cRecPU(100, 42, 50, 59))
				Me.table_1500_st.Add(New cRecPU(150, 58, 54, 74))
				Me.table_1500_st.Add(New cRecPU(200, 70, 60, 74))
				Me.table_1500_st.Add(New cRecPU(250, 80, 64, 74))
				Me.table_1500_st.Add(New cRecPU(300, 85, 67, 74))
				Me.table_1500_st.Add(New cRecPU(350, 90, 70, 74))
				Me.table_1500_st.Add(New cRecPU(400, 114, 85, 74))
				Me.table_1500_st.Add(New cRecPU(450, 160, 90, 74))
				Me.table_1500_st.Add(New cRecPU(600, 160, 119, 74))
				Me.table_1500_st.Add(New cRecPU(700, 180, 119, 74))
				Me.table_1500_st.Add(New cRecPU(750, 228, 121, 74))
				Me.table_1500_st.Add(New cRecPU(900, 228, 121, 86))
				Me.table_1500_st.Add(New cRecPU(1000, 320, 155, 100))
				Me.table_1500_st.Add(New cRecPU(1100, 320, 165, 100))
				Me.table_1500_st.Add(New cRecPU(1200, 456, 165, 120))
				Me.table_1500_st.Add(New cRecPU(1300, 456, 200, 144))
				Me.table_1500_st.Add(New cRecPU(1500, 640, 200, 144))
				Me.table_1500_st.Add(New cRecPU(1600, 640, 220, 144))
				Me.table_1500_st.Add(New cRecPU(2000, 640, 256, 144))
				Me.table_1500_st.Add(New cRecPU(2600, 912, 305, 168))
				Me.table_1500_st.Add(New cRecPU(2700, 912, 305, 192))
				Me.table_1500_st.Add(New cRecPU(2900, 1280, 305, 192))
				Me.table_1500_st.Add(New cRecPU(3800, 1280, 365, 192))
				Me.table_1500_st.Add(New cRecPU(4500, 1824, 427, 192))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(50, 30, 55, 44))
				Me.table_2000_st.Add(New cRecPU(100, 40, 64, 44))
				Me.table_2000_st.Add(New cRecPU(150, 75, 75, 74))
				Me.table_2000_st.Add(New cRecPU(200, 85, 80, 74))
				Me.table_2000_st.Add(New cRecPU(250, 114, 85, 74))
				Me.table_2000_st.Add(New cRecPU(300, 114, 119, 74))
				Me.table_2000_st.Add(New cRecPU(350, 160, 119, 74))
				Me.table_2000_st.Add(New cRecPU(400, 160, 119, 86))
				Me.table_2000_st.Add(New cRecPU(450, 228, 119, 86))
				Me.table_2000_st.Add(New cRecPU(500, 228, 125, 86))
				Me.table_2000_st.Add(New cRecPU(600, 228, 130, 86))
				Me.table_2000_st.Add(New cRecPU(650, 228, 140, 86))
				Me.table_2000_st.Add(New cRecPU(700, 320, 160, 86))
				Me.table_2000_st.Add(New cRecPU(800, 320, 170, 86))
				Me.table_2000_st.Add(New cRecPU(950, 456, 256, 100))
				Me.table_2000_st.Add(New cRecPU(1000, 456, 256, 120))
				Me.table_2000_st.Add(New cRecPU(1300, 640, 256, 120))
				Me.table_2000_st.Add(New cRecPU(1400, 640, 256, 144))
				Me.table_2000_st.Add(New cRecPU(1600, 912, 305, 144))
				Me.table_2000_st.Add(New cRecPU(1800, 912, 305, 168))
				Me.table_2000_st.Add(New cRecPU(1900, 912, 305, 192))
				Me.table_2000_st.Add(New cRecPU(2400, 1280, 365, 168))
				Me.table_2000_st.Add(New cRecPU(2700, 1280, 365, 192))
				Me.table_2000_st.Add(New cRecPU(3700, 1824, 427, 192))
				Me.table_2500_st.Clear()
				Me.table_2500_st.Add(New cRecPU(50, 35, 70, 44))
				Me.table_2500_st.Add(New cRecPU(100, 52, 80, 44))
				Me.table_2500_st.Add(New cRecPU(150, 80, 90, 58))
				Me.table_2500_st.Add(New cRecPU(200, 114, 119, 74))
				Me.table_2500_st.Add(New cRecPU(250, 160, 119, 74))
				Me.table_2500_st.Add(New cRecPU(300, 228, 119, 86))
				Me.table_2500_st.Add(New cRecPU(350, 228, 130, 86))
				Me.table_2500_st.Add(New cRecPU(500, 228, 150, 86))
				Me.table_2500_st.Add(New cRecPU(550, 320, 160, 86))
				Me.table_2500_st.Add(New cRecPU(600, 320, 170, 100))
				Me.table_2500_st.Add(New cRecPU(650, 456, 170, 120))
				Me.table_2500_st.Add(New cRecPU(700, 456, 200, 120))
				Me.table_2500_st.Add(New cRecPU(750, 456, 213, 120))
				Me.table_2500_st.Add(New cRecPU(1100, 640, 256, 144))
				Me.table_2500_st.Add(New cRecPU(1500, 912, 305, 168))
				Me.table_2500_st.Add(New cRecPU(1800, 1280, 365, 192))
				Me.table_2500_st.Add(New cRecPU(2200, 1824, 365, 192))
				Me.table_2500_st.Add(New cRecPU(2500, 1824, 427, 192))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(50, 50, 85, 44))
				Me.table_3000_st.Add(New cRecPU(100, 85, 119, 58))
				Me.table_3000_st.Add(New cRecPU(150, 114, 119, 58))
				Me.table_3000_st.Add(New cRecPU(200, 160, 130, 74))
				Me.table_3000_st.Add(New cRecPU(350, 228, 173, 74))
				Me.table_3000_st.Add(New cRecPU(400, 228, 173, 86))
				Me.table_3000_st.Add(New cRecPU(450, 320, 173, 86))
				Me.table_3000_st.Add(New cRecPU(550, 320, 246, 86))
				Me.table_3000_st.Add(New cRecPU(650, 456, 256, 100))
				Me.table_3000_st.Add(New cRecPU(700, 640, 256, 120))
				Me.table_3000_st.Add(New cRecPU(750, 640, 256, 144))
				Me.table_3000_st.Add(New cRecPU(800, 640, 256, 156))
				Me.table_3000_st.Add(New cRecPU(850, 640, 256, 168))
				Me.table_3000_st.Add(New cRecPU(950, 912, 256, 168))
				Me.table_3000_st.Add(New cRecPU(1100, 912, 305, 168))
				Me.table_3000_st.Add(New cRecPU(1200, 912, 305, 192))
				Me.table_3000_st.Add(New cRecPU(1500, 1280, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2100, 1824, 427, 192))
				Me.table_3500_st.Clear()
				Me.table_3500_st.Add(New cRecPU(50, 60, 95, 58))
				Me.table_3500_st.Add(New cRecPU(100, 114, 119, 58))
				Me.table_3500_st.Add(New cRecPU(150, 145, 133, 74))
				Me.table_3500_st.Add(New cRecPU(200, 180, 173, 74))
				Me.table_3500_st.Add(New cRecPU(250, 228, 173, 74))
				Me.table_3500_st.Add(New cRecPU(300, 320, 173, 86))
				Me.table_3500_st.Add(New cRecPU(350, 320, 173, 100))
				Me.table_3500_st.Add(New cRecPU(600, 456, 256, 120))
				Me.table_3500_st.Add(New cRecPU(800, 640, 256, 120))
				Me.table_3500_st.Add(New cRecPU(1000, 912, 365, 144))
				Me.table_3500_st.Add(New cRecPU(1200, 1280, 365, 168))
				Me.table_3500_st.Add(New cRecPU(1375, 1280, 365, 192))
				Me.table_3500_st.Add(New cRecPU(1375, 1280, 365, 192))
				Me.table_3500_st.Add(New cRecPU(1600, 1824, 427, 192))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(50, 70, 119, 58))
				Me.table_4000_st.Add(New cRecPU(100, 114, 173, 64))
				Me.table_4000_st.Add(New cRecPU(150, 170, 173, 74))
				Me.table_4000_st.Add(New cRecPU(200, 228, 200, 74))
				Me.table_4000_st.Add(New cRecPU(250, 320, 200, 86))
				Me.table_4000_st.Add(New cRecPU(300, 320, 246, 86))
				Me.table_4000_st.Add(New cRecPU(350, 456, 256, 100))
				Me.table_4000_st.Add(New cRecPU(450, 456, 256, 120))
				Me.table_4000_st.Add(New cRecPU(600, 640, 256, 120))
				Me.table_4000_st.Add(New cRecPU(650, 640, 256, 144))
				Me.table_4000_st.Add(New cRecPU(750, 912, 305, 168))
				Me.table_4000_st.Add(New cRecPU(800, 912, 305, 192))
				Me.table_4000_st.Add(New cRecPU(1000, 1280, 365, 192))
				Me.table_4000_st.Add(New cRecPU(1200, 1280, 427, 192))
				Me.table_4000_st.Add(New cRecPU(1400, 1824, 427, 192))
				Me.table_4500_st.Clear()
				Me.table_4500_st.Add(New cRecPU(50, 90, 119, 58))
				Me.table_4500_st.Add(New cRecPU(100, 160, 173, 64))
				Me.table_4500_st.Add(New cRecPU(150, 228, 173, 74))
				Me.table_4500_st.Add(New cRecPU(250, 320, 246, 86))
				Me.table_4500_st.Add(New cRecPU(400, 456, 256, 100))
				Me.table_4500_st.Add(New cRecPU(500, 640, 256, 120))
				Me.table_4500_st.Add(New cRecPU(550, 640, 305, 144))
				Me.table_4500_st.Add(New cRecPU(650, 912, 305, 144))
				Me.table_4500_st.Add(New cRecPU(700, 912, 305, 168))
				Me.table_4500_st.Add(New cRecPU(825, 1280, 365, 168))
				Me.table_4500_st.Add(New cRecPU(950, 1280, 427, 168))
				Me.table_4500_st.Add(New cRecPU(1000, 1280, 365, 192))
				Me.table_4500_st.Add(New cRecPU(1200, 1824, 427, 192))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(50, 114, 119, 74))
				Me.table_5000_st.Add(New cRecPU(100, 160, 173, 74))
				Me.table_5000_st.Add(New cRecPU(150, 228, 200, 74))
				Me.table_5000_st.Add(New cRecPU(200, 320, 246, 86))
				Me.table_5000_st.Add(New cRecPU(250, 456, 256, 100))
				Me.table_5000_st.Add(New cRecPU(350, 456, 256, 120))
				Me.table_5000_st.Add(New cRecPU(450, 640, 256, 144))
				Me.table_5000_st.Add(New cRecPU(550, 912, 305, 144))
				Me.table_5000_st.Add(New cRecPU(600, 912, 305, 156))
				Me.table_5000_st.Add(New cRecPU(650, 1280, 365, 168))
				Me.table_5000_st.Add(New cRecPU(750, 1280, 365, 192))
				Me.table_5000_st.Add(New cRecPU(1000, 1824, 427, 192))
				Me.table_5500_st.Clear()
				Me.table_5500_st.Add(New cRecPU(50, 160, 173, 74))
				Me.table_5500_st.Add(New cRecPU(100, 228, 200, 74))
				Me.table_5500_st.Add(New cRecPU(150, 228, 213, 74))
				Me.table_5500_st.Add(New cRecPU(200, 320, 246, 86))
				Me.table_5500_st.Add(New cRecPU(250, 456, 256, 100))
				Me.table_5500_st.Add(New cRecPU(300, 456, 256, 120))
				Me.table_5500_st.Add(New cRecPU(400, 640, 305, 120))
				Me.table_5500_st.Add(New cRecPU(500, 912, 305, 144))
				Me.table_5500_st.Add(New cRecPU(550, 912, 365, 144))
				Me.table_5500_st.Add(New cRecPU(700, 1280, 365, 168))
				Me.table_5500_st.Add(New cRecPU(800, 1824, 365, 192))
				Me.table_5500_st.Add(New cRecPU(1000, 1824, 427, 192))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(50, 114, 169, 64))
				Me.table_6000_st.Add(New cRecPU(75, 160, 200, 64))
				Me.table_6000_st.Add(New cRecPU(100, 228, 200, 74))
				Me.table_6000_st.Add(New cRecPU(200, 320, 246, 86))
				Me.table_6000_st.Add(New cRecPU(250, 456, 256, 100))
				Me.table_6000_st.Add(New cRecPU(300, 640, 256, 120))
				Me.table_6000_st.Add(New cRecPU(400, 912, 305, 144))
				Me.table_6000_st.Add(New cRecPU(500, 912, 365, 144))
				Me.table_6000_st.Add(New cRecPU(650, 1280, 365, 168))
				Me.table_6000_st.Add(New cRecPU(700, 1824, 365, 192))
				Me.table_6000_st.Add(New cRecPU(800, 1824, 427, 192))
				Me.table_6000_st.Add(New cRecPU(850, 1824, 470, 192))
				Me.table_6500_st.Clear()
				Me.table_6500_st.Add(New cRecPU(50, 160, 200, 74))
				Me.table_6500_st.Add(New cRecPU(100, 228, 200, 74))
				Me.table_6500_st.Add(New cRecPU(200, 320, 246, 86))
				Me.table_6500_st.Add(New cRecPU(250, 456, 256, 100))
				Me.table_6500_st.Add(New cRecPU(300, 456, 305, 100))
				Me.table_6500_st.Add(New cRecPU(450, 640, 305, 120))
				Me.table_6500_st.Add(New cRecPU(500, 912, 365, 144))
				Me.table_6500_st.Add(New cRecPU(550, 1280, 365, 168))
				Me.table_6500_st.Add(New cRecPU(700, 1824, 427, 192))
				Me.table_6500_st.Add(New cRecPU(850, 1824, 470, 192))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(50, 160, 200, 74))
				Me.table_7000_st.Add(New cRecPU(100, 228, 200, 74))
				Me.table_7000_st.Add(New cRecPU(150, 320, 246, 86))
				Me.table_7000_st.Add(New cRecPU(200, 456, 305, 100))
				Me.table_7000_st.Add(New cRecPU(400, 640, 305, 120))
				Me.table_7000_st.Add(New cRecPU(450, 912, 365, 144))
				Me.table_7000_st.Add(New cRecPU(550, 1280, 427, 168))
				Me.table_7000_st.Add(New cRecPU(600, 1824, 470, 168))
				Me.table_7000_st.Add(New cRecPU(700, 1824, 470, 192))
				Me.table_7500_st.Clear()
				Me.table_7500_st.Add(New cRecPU(50, 160, 246, 86))
				Me.table_7500_st.Add(New cRecPU(100, 228, 246, 86))
				Me.table_7500_st.Add(New cRecPU(150, 320, 256, 100))
				Me.table_7500_st.Add(New cRecPU(200, 320, 305, 100))
				Me.table_7500_st.Add(New cRecPU(250, 456, 305, 100))
				Me.table_7500_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(400, 640, 365, 120))
				Me.table_7500_st.Add(New cRecPU(450, 912, 365, 144))
				Me.table_7500_st.Add(New cRecPU(550, 1280, 427, 168))
				Me.table_7500_st.Add(New cRecPU(600, 1824, 427, 192))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(50, 228, 246, 86))
				Me.table_8000_st.Add(New cRecPU(100, 228, 256, 86))
				Me.table_8000_st.Add(New cRecPU(150, 320, 256, 100))
				Me.table_8000_st.Add(New cRecPU(250, 456, 365, 120))
				Me.table_8000_st.Add(New cRecPU(300, 640, 365, 120))
				Me.table_8000_st.Add(New cRecPU(350, 640, 365, 144))
				Me.table_8000_st.Add(New cRecPU(450, 912, 427, 144))
				Me.table_8000_st.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_8000_st.Add(New cRecPU(600, 1824, 427, 192))
				Me.table_8500_st.Clear()
				Me.table_8500_st.Add(New cRecPU(50, 228, 246, 86))
				Me.table_8500_st.Add(New cRecPU(100, 320, 256, 100))
				Me.table_8500_st.Add(New cRecPU(150, 320, 305, 100))
				Me.table_8500_st.Add(New cRecPU(200, 456, 305, 120))
				Me.table_8500_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_8500_st.Add(New cRecPU(400, 912, 365, 144))
				Me.table_8500_st.Add(New cRecPU(450, 912, 427, 144))
				Me.table_8500_st.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_8500_st.Add(New cRecPU(550, 1824, 427, 192))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(50, 228, 246, 86))
				Me.table_9000_st.Add(New cRecPU(100, 320, 305, 100))
				Me.table_9000_st.Add(New cRecPU(200, 456, 305, 120))
				Me.table_9000_st.Add(New cRecPU(250, 640, 305, 120))
				Me.table_9000_st.Add(New cRecPU(400, 912, 427, 144))
				Me.table_9000_st.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_9500_st.Clear()
				Me.table_9500_st.Add(New cRecPU(100, 228, 246, 86))
				Me.table_9500_st.Add(New cRecPU(150, 320, 305, 100))
				Me.table_9500_st.Add(New cRecPU(200, 456, 305, 120))
				Me.table_9500_st.Add(New cRecPU(250, 640, 305, 120))
				Me.table_9500_st.Add(New cRecPU(350, 912, 427, 144))
				Me.table_9500_st.Add(New cRecPU(400, 1280, 427, 168))
				Me.table_9500_st.Add(New cRecPU(425, 1280, 427, 192))
				Me.table_9500_st.Add(New cRecPU(450, 1824, 427, 192))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(100, 228, 246, 86))
				Me.table_10000_st.Add(New cRecPU(150, 320, 305, 100))
				Me.table_10000_st.Add(New cRecPU(200, 456, 365, 120))
				Me.table_10000_st.Add(New cRecPU(350, 912, 427, 144))
				Me.table_10000_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10000_st.Add(New cRecPU(400, 1280, 427, 168))
				Me.table_10000_st.Add(New cRecPU(450, 1824, 427, 192))
				Me.table_10500_st.Clear()
				Me.table_10500_st.Add(New cRecPU(150, 320, 305, 100))
				Me.table_10500_st.Add(New cRecPU(200, 456, 365, 120))
				Me.table_10500_st.Add(New cRecPU(250, 640, 427, 120))
				Me.table_10500_st.Add(New cRecPU(400, 912, 427, 144))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(100, 320, 305, 100))
				Me.table_11000_st.Add(New cRecPU(150, 456, 305, 120))
				Me.table_11000_st.Add(New cRecPU(200, 456, 365, 120))
				Me.table_11000_st.Add(New cRecPU(300, 640, 427, 144))
				Me.table_11000_st.Add(New cRecPU(400, 912, 427, 144))
				Me.table_11500_st.Clear()
				Me.table_11500_st.Add(New cRecPU(150, 320, 305, 100))
				Me.table_11500_st.Add(New cRecPU(200, 456, 365, 120))
				Me.table_11500_st.Add(New cRecPU(300, 640, 427, 144))
				Me.table_11500_st.Add(New cRecPU(350, 912, 427, 144))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(50, 320, 305, 100))
				Me.table_12000_st.Add(New cRecPU(300, 640, 427, 144))
				Me.table_12500_st.Clear()
				Me.table_12500_st.Add(New cRecPU(100, 456, 365, 120))
				Me.table_12500_st.Add(New cRecPU(200, 640, 427, 144))
				Me.table_12500_st.Add(New cRecPU(300, 912, 427, 144))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(100, 456, 365, 120))
				Me.table_13000_st.Add(New cRecPU(200, 640, 427, 144))
				Me.table_13000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_13500_st.Clear()
				Me.table_13500_st.Add(New cRecPU(100, 456, 365, 120))
				Me.table_13500_st.Add(New cRecPU(150, 640, 427, 144))
				Me.table_13500_st.Add(New cRecPU(250, 912, 427, 168))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(100, 456, 365, 120))
				Me.table_14000_st.Add(New cRecPU(150, 640, 427, 144))
				Me.table_14000_st.Add(New cRecPU(200, 912, 427, 168))
				Me.table_14500_st.Clear()
				Me.table_14500_st.Add(New cRecPU(150, 640, 427, 144))
				Me.table_14500_st.Add(New cRecPU(200, 912, 427, 168))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(150, 640, 427, 144))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(100, 640, 427, 144))
				Me.table_17000_st.Clear()
				Me.table_17000_st.Add(New cRecPU(100, 640, 427, 144))
				Me.table_18000_st.Clear()
				Me.table_18000_st.Add(New cRecPU(50, 912, 427, 144))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateRecPUSTAL_RMark_Old()
			Try
				Me.table_1000_st.Clear()
				Me.table_1000_st.Add(New cRecPU(50, 17, 30, 44))
				Me.table_1000_st.Add(New cRecPU(100, 30, 35, 59))
				Me.table_1000_st.Add(New cRecPU(150, 40, 37, 74))
				Me.table_1000_st.Add(New cRecPU(200, 52, 42, 74))
				Me.table_1000_st.Add(New cRecPU(250, 55, 45, 74))
				Me.table_1000_st.Add(New cRecPU(300, 64, 50, 74))
				Me.table_1000_st.Add(New cRecPU(400, 64, 55, 74))
				Me.table_1000_st.Add(New cRecPU(450, 70, 58, 74))
				Me.table_1000_st.Add(New cRecPU(500, 80, 60, 74))
				Me.table_1000_st.Add(New cRecPU(550, 80, 62, 74))
				Me.table_1000_st.Add(New cRecPU(650, 90, 65, 74))
				Me.table_1000_st.Add(New cRecPU(750, 114, 80, 74))
				Me.table_1000_st.Add(New cRecPU(800, 114, 82, 74))
				Me.table_1000_st.Add(New cRecPU(850, 130, 85, 74))
				Me.table_1000_st.Add(New cRecPU(1000, 145, 95, 74))
				Me.table_1000_st.Add(New cRecPU(1100, 160, 100, 86))
				Me.table_1000_st.Add(New cRecPU(1200, 180, 119, 86))
				Me.table_1000_st.Add(New cRecPU(1300, 228, 119, 100))
				Me.table_1000_st.Add(New cRecPU(1350, 228, 119, 100))
				Me.table_1000_st.Add(New cRecPU(1450, 320, 119, 120))
				Me.table_1000_st.Add(New cRecPU(1700, 320, 119, 144))
				Me.table_1000_st.Add(New cRecPU(1800, 320, 121, 144))
				Me.table_1000_st.Add(New cRecPU(1900, 456, 121, 168))
				Me.table_1000_st.Add(New cRecPU(2000, 456, 121, 192))
				Me.table_1000_st.Add(New cRecPU(2200, 640, 143, 192))
				Me.table_1000_st.Add(New cRecPU(2400, 640, 155, 192))
				Me.table_1000_st.Add(New cRecPU(2500, 640, 165, 192))
				Me.table_1000_st.Add(New cRecPU(2700, 640, 185, 192))
				Me.table_1000_st.Add(New cRecPU(3100, 640, 200, 192))
				Me.table_1000_st.Add(New cRecPU(3400, 912, 200, 192))
				Me.table_1000_st.Add(New cRecPU(3600, 912, 220, 192))
				Me.table_1000_st.Add(New cRecPU(4100, 1280, 305, 192))
				Me.table_1000_st.Add(New cRecPU(4700, 1280, 365, 192))
				Me.table_1000_st.Add(New cRecPU(4800, 1824, 365, 192))
				Me.table_1500_st.Clear()
				Me.table_1500_st.Add(New cRecPU(50, 24, 43, 44))
				Me.table_1500_st.Add(New cRecPU(100, 42, 50, 59))
				Me.table_1500_st.Add(New cRecPU(150, 58, 54, 74))
				Me.table_1500_st.Add(New cRecPU(200, 70, 60, 74))
				Me.table_1500_st.Add(New cRecPU(250, 80, 64, 74))
				Me.table_1500_st.Add(New cRecPU(300, 85, 67, 74))
				Me.table_1500_st.Add(New cRecPU(350, 90, 70, 74))
				Me.table_1500_st.Add(New cRecPU(400, 114, 85, 74))
				Me.table_1500_st.Add(New cRecPU(450, 160, 90, 74))
				Me.table_1500_st.Add(New cRecPU(600, 160, 119, 74))
				Me.table_1500_st.Add(New cRecPU(700, 180, 119, 74))
				Me.table_1500_st.Add(New cRecPU(750, 228, 121, 74))
				Me.table_1500_st.Add(New cRecPU(900, 228, 121, 86))
				Me.table_1500_st.Add(New cRecPU(1000, 320, 155, 100))
				Me.table_1500_st.Add(New cRecPU(1100, 320, 165, 100))
				Me.table_1500_st.Add(New cRecPU(1200, 456, 165, 120))
				Me.table_1500_st.Add(New cRecPU(1300, 456, 200, 144))
				Me.table_1500_st.Add(New cRecPU(1500, 640, 200, 144))
				Me.table_1500_st.Add(New cRecPU(1600, 640, 220, 144))
				Me.table_1500_st.Add(New cRecPU(2000, 640, 256, 144))
				Me.table_1500_st.Add(New cRecPU(2600, 912, 305, 168))
				Me.table_1500_st.Add(New cRecPU(2700, 912, 305, 192))
				Me.table_1500_st.Add(New cRecPU(2900, 1280, 305, 192))
				Me.table_1500_st.Add(New cRecPU(3800, 1280, 365, 192))
				Me.table_1500_st.Add(New cRecPU(4500, 1824, 427, 192))
				Me.table_2000_st.Clear()
				Me.table_2000_st.Add(New cRecPU(50, 30, 55, 44))
				Me.table_2000_st.Add(New cRecPU(100, 40, 64, 44))
				Me.table_2000_st.Add(New cRecPU(150, 75, 75, 74))
				Me.table_2000_st.Add(New cRecPU(200, 85, 80, 74))
				Me.table_2000_st.Add(New cRecPU(250, 114, 85, 74))
				Me.table_2000_st.Add(New cRecPU(300, 114, 119, 74))
				Me.table_2000_st.Add(New cRecPU(350, 160, 119, 74))
				Me.table_2000_st.Add(New cRecPU(400, 160, 119, 86))
				Me.table_2000_st.Add(New cRecPU(450, 228, 119, 86))
				Me.table_2000_st.Add(New cRecPU(500, 228, 125, 86))
				Me.table_2000_st.Add(New cRecPU(600, 228, 130, 86))
				Me.table_2000_st.Add(New cRecPU(650, 228, 140, 86))
				Me.table_2000_st.Add(New cRecPU(700, 320, 160, 86))
				Me.table_2000_st.Add(New cRecPU(800, 320, 170, 86))
				Me.table_2000_st.Add(New cRecPU(950, 456, 256, 100))
				Me.table_2000_st.Add(New cRecPU(1000, 456, 256, 120))
				Me.table_2000_st.Add(New cRecPU(1300, 640, 256, 120))
				Me.table_2000_st.Add(New cRecPU(1400, 640, 256, 144))
				Me.table_2000_st.Add(New cRecPU(1600, 912, 305, 144))
				Me.table_2000_st.Add(New cRecPU(1800, 912, 305, 168))
				Me.table_2000_st.Add(New cRecPU(1900, 912, 305, 192))
				Me.table_2000_st.Add(New cRecPU(2400, 1280, 365, 168))
				Me.table_2000_st.Add(New cRecPU(2700, 1280, 365, 192))
				Me.table_2000_st.Add(New cRecPU(3700, 1824, 427, 192))
				Me.table_2500_st.Clear()
				Me.table_2500_st.Add(New cRecPU(50, 35, 70, 44))
				Me.table_2500_st.Add(New cRecPU(100, 52, 80, 44))
				Me.table_2500_st.Add(New cRecPU(150, 80, 90, 58))
				Me.table_2500_st.Add(New cRecPU(200, 114, 119, 74))
				Me.table_2500_st.Add(New cRecPU(250, 160, 119, 74))
				Me.table_2500_st.Add(New cRecPU(300, 228, 119, 86))
				Me.table_2500_st.Add(New cRecPU(350, 228, 130, 86))
				Me.table_2500_st.Add(New cRecPU(500, 228, 150, 86))
				Me.table_2500_st.Add(New cRecPU(550, 320, 160, 86))
				Me.table_2500_st.Add(New cRecPU(600, 320, 170, 100))
				Me.table_2500_st.Add(New cRecPU(650, 456, 170, 120))
				Me.table_2500_st.Add(New cRecPU(700, 456, 200, 120))
				Me.table_2500_st.Add(New cRecPU(750, 456, 213, 120))
				Me.table_2500_st.Add(New cRecPU(1100, 640, 256, 144))
				Me.table_2500_st.Add(New cRecPU(1500, 912, 305, 168))
				Me.table_2500_st.Add(New cRecPU(1800, 1280, 365, 192))
				Me.table_2500_st.Add(New cRecPU(2200, 1824, 365, 192))
				Me.table_2500_st.Add(New cRecPU(2500, 1824, 427, 192))
				Me.table_3000_st.Clear()
				Me.table_3000_st.Add(New cRecPU(50, 50, 85, 44))
				Me.table_3000_st.Add(New cRecPU(100, 85, 119, 58))
				Me.table_3000_st.Add(New cRecPU(150, 114, 119, 58))
				Me.table_3000_st.Add(New cRecPU(200, 160, 130, 74))
				Me.table_3000_st.Add(New cRecPU(350, 228, 173, 74))
				Me.table_3000_st.Add(New cRecPU(400, 228, 173, 86))
				Me.table_3000_st.Add(New cRecPU(450, 320, 173, 86))
				Me.table_3000_st.Add(New cRecPU(550, 320, 246, 86))
				Me.table_3000_st.Add(New cRecPU(650, 456, 256, 100))
				Me.table_3000_st.Add(New cRecPU(700, 640, 256, 120))
				Me.table_3000_st.Add(New cRecPU(750, 640, 256, 144))
				Me.table_3000_st.Add(New cRecPU(800, 640, 256, 156))
				Me.table_3000_st.Add(New cRecPU(850, 640, 256, 168))
				Me.table_3000_st.Add(New cRecPU(950, 912, 256, 168))
				Me.table_3000_st.Add(New cRecPU(1100, 912, 305, 168))
				Me.table_3000_st.Add(New cRecPU(1200, 912, 305, 192))
				Me.table_3000_st.Add(New cRecPU(1500, 1280, 365, 192))
				Me.table_3000_st.Add(New cRecPU(2100, 1824, 427, 192))
				Me.table_3500_st.Clear()
				Me.table_3500_st.Add(New cRecPU(50, 60, 95, 58))
				Me.table_3500_st.Add(New cRecPU(100, 114, 119, 58))
				Me.table_3500_st.Add(New cRecPU(150, 145, 133, 74))
				Me.table_3500_st.Add(New cRecPU(200, 180, 173, 74))
				Me.table_3500_st.Add(New cRecPU(250, 228, 173, 74))
				Me.table_3500_st.Add(New cRecPU(300, 320, 173, 86))
				Me.table_3500_st.Add(New cRecPU(350, 320, 173, 100))
				Me.table_3500_st.Add(New cRecPU(600, 456, 256, 120))
				Me.table_3500_st.Add(New cRecPU(800, 640, 256, 120))
				Me.table_3500_st.Add(New cRecPU(1000, 912, 365, 144))
				Me.table_3500_st.Add(New cRecPU(1200, 1280, 365, 168))
				Me.table_3500_st.Add(New cRecPU(1375, 1280, 365, 192))
				Me.table_3500_st.Add(New cRecPU(1375, 1280, 365, 192))
				Me.table_3500_st.Add(New cRecPU(1600, 1824, 427, 192))
				Me.table_4000_st.Clear()
				Me.table_4000_st.Add(New cRecPU(50, 70, 119, 58))
				Me.table_4000_st.Add(New cRecPU(100, 114, 173, 64))
				Me.table_4000_st.Add(New cRecPU(150, 170, 173, 74))
				Me.table_4000_st.Add(New cRecPU(200, 228, 200, 74))
				Me.table_4000_st.Add(New cRecPU(250, 320, 200, 86))
				Me.table_4000_st.Add(New cRecPU(300, 320, 246, 86))
				Me.table_4000_st.Add(New cRecPU(350, 456, 256, 100))
				Me.table_4000_st.Add(New cRecPU(450, 456, 256, 120))
				Me.table_4000_st.Add(New cRecPU(600, 640, 256, 120))
				Me.table_4000_st.Add(New cRecPU(650, 640, 256, 144))
				Me.table_4000_st.Add(New cRecPU(750, 912, 305, 168))
				Me.table_4000_st.Add(New cRecPU(800, 912, 305, 192))
				Me.table_4000_st.Add(New cRecPU(1000, 1280, 365, 192))
				Me.table_4000_st.Add(New cRecPU(1200, 1280, 427, 192))
				Me.table_4000_st.Add(New cRecPU(1400, 1824, 427, 192))
				Me.table_4500_st.Clear()
				Me.table_4500_st.Add(New cRecPU(50, 90, 119, 58))
				Me.table_4500_st.Add(New cRecPU(100, 160, 173, 64))
				Me.table_4500_st.Add(New cRecPU(150, 228, 173, 74))
				Me.table_4500_st.Add(New cRecPU(250, 320, 246, 86))
				Me.table_4500_st.Add(New cRecPU(400, 456, 256, 100))
				Me.table_4500_st.Add(New cRecPU(500, 640, 256, 120))
				Me.table_4500_st.Add(New cRecPU(550, 640, 305, 144))
				Me.table_4500_st.Add(New cRecPU(650, 912, 305, 144))
				Me.table_4500_st.Add(New cRecPU(700, 912, 305, 168))
				Me.table_4500_st.Add(New cRecPU(825, 1280, 365, 168))
				Me.table_4500_st.Add(New cRecPU(950, 1280, 427, 168))
				Me.table_4500_st.Add(New cRecPU(1000, 1280, 365, 192))
				Me.table_4500_st.Add(New cRecPU(1200, 1824, 427, 192))
				Me.table_5000_st.Clear()
				Me.table_5000_st.Add(New cRecPU(50, 114, 119, 74))
				Me.table_5000_st.Add(New cRecPU(100, 160, 173, 74))
				Me.table_5000_st.Add(New cRecPU(150, 228, 200, 74))
				Me.table_5000_st.Add(New cRecPU(200, 320, 246, 86))
				Me.table_5000_st.Add(New cRecPU(250, 456, 256, 100))
				Me.table_5000_st.Add(New cRecPU(350, 456, 256, 120))
				Me.table_5000_st.Add(New cRecPU(450, 640, 256, 144))
				Me.table_5000_st.Add(New cRecPU(550, 912, 305, 144))
				Me.table_5000_st.Add(New cRecPU(600, 912, 305, 156))
				Me.table_5000_st.Add(New cRecPU(650, 1280, 365, 168))
				Me.table_5000_st.Add(New cRecPU(750, 1280, 365, 192))
				Me.table_5000_st.Add(New cRecPU(1000, 1824, 427, 192))
				Me.table_5500_st.Clear()
				Me.table_5500_st.Add(New cRecPU(50, 160, 173, 74))
				Me.table_5500_st.Add(New cRecPU(100, 228, 200, 74))
				Me.table_5500_st.Add(New cRecPU(150, 228, 213, 74))
				Me.table_5500_st.Add(New cRecPU(200, 320, 246, 86))
				Me.table_5500_st.Add(New cRecPU(250, 456, 256, 100))
				Me.table_5500_st.Add(New cRecPU(300, 456, 256, 120))
				Me.table_5500_st.Add(New cRecPU(400, 640, 305, 120))
				Me.table_5500_st.Add(New cRecPU(500, 912, 305, 144))
				Me.table_5500_st.Add(New cRecPU(500, 640, 365, 100))
				Me.table_5500_st.Add(New cRecPU(550, 912, 365, 120))
				Me.table_5500_st.Add(New cRecPU(700, 1280, 365, 144))
				Me.table_5500_st.Add(New cRecPU(750, 1280, 365, 168))
				Me.table_5500_st.Add(New cRecPU(950, 1824, 365, 192))
				Me.table_5500_st.Add(New cRecPU(1000, 1824, 365, 216))
				Me.table_5500_st.Add(New cRecPU(1200, 2560, 427, 240))
				Me.table_6000_st.Clear()
				Me.table_6000_st.Add(New cRecPU(50, 114, 169, 44))
				Me.table_6000_st.Add(New cRecPU(75, 160, 200, 54))
				Me.table_6000_st.Add(New cRecPU(100, 228, 200, 64))
				Me.table_6000_st.Add(New cRecPU(150, 320, 246, 74))
				Me.table_6000_st.Add(New cRecPU(200, 456, 256, 100))
				Me.table_6000_st.Add(New cRecPU(250, 456, 305, 100))
				Me.table_6000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_6000_st.Add(New cRecPU(450, 912, 305, 144))
				Me.table_6000_st.Add(New cRecPU(475, 912, 305, 168))
				Me.table_6000_st.Add(New cRecPU(550, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(600, 1280, 365, 192))
				Me.table_6000_st.Add(New cRecPU(800, 1824, 365, 192))
				Me.table_6000_st.Add(New cRecPU(900, 1824, 365, 216))
				Me.table_6000_st.Add(New cRecPU(1000, 1824, 365, 240))
				Me.table_6500_st.Clear()
				Me.table_6500_st.Add(New cRecPU(75, 160, 200, 54))
				Me.table_6500_st.Add(New cRecPU(100, 228, 246, 64))
				Me.table_6500_st.Add(New cRecPU(200, 320, 246, 74))
				Me.table_6500_st.Add(New cRecPU(250, 456, 246, 86))
				Me.table_6500_st.Add(New cRecPU(350, 456, 298, 86))
				Me.table_6500_st.Add(New cRecPU(400, 640, 298, 100))
				Me.table_6500_st.Add(New cRecPU(500, 912, 365, 120))
				Me.table_6500_st.Add(New cRecPU(550, 1280, 365, 168))
				Me.table_6500_st.Add(New cRecPU(700, 1824, 365, 192))
				Me.table_6500_st.Add(New cRecPU(800, 1824, 365, 216))
				Me.table_6500_st.Add(New cRecPU(850, 1824, 427, 240))
				Me.table_6500_st.Add(New cRecPU(950, 2560, 427, 260))
				Me.table_7000_st.Clear()
				Me.table_7000_st.Add(New cRecPU(100, 228, 200, 64))
				Me.table_7000_st.Add(New cRecPU(150, 320, 246, 74))
				Me.table_7000_st.Add(New cRecPU(200, 456, 298, 86))
				Me.table_7000_st.Add(New cRecPU(250, 456, 298, 100))
				Me.table_7000_st.Add(New cRecPU(300, 640, 305, 120))
				Me.table_7000_st.Add(New cRecPU(400, 912, 356, 144))
				Me.table_7000_st.Add(New cRecPU(450, 1280, 365, 168))
				Me.table_7000_st.Add(New cRecPU(550, 1824, 365, 192))
				Me.table_7000_st.Add(New cRecPU(600, 1824, 427, 192))
				Me.table_7000_st.Add(New cRecPU(700, 1824, 427, 216))
				Me.table_7000_st.Add(New cRecPU(800, 2560, 427, 240))
				Me.table_7500_st.Clear()
				Me.table_7500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_7500_st.Add(New cRecPU(175, 320, 298, 86))
				Me.table_7500_st.Add(New cRecPU(250, 456, 298, 86))
				Me.table_7500_st.Add(New cRecPU(260, 456, 298, 100))
				Me.table_7500_st.Add(New cRecPU(275, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(325, 640, 305, 120))
				Me.table_7500_st.Add(New cRecPU(350, 912, 365, 144))
				Me.table_7500_st.Add(New cRecPU(400, 1280, 365, 168))
				Me.table_7500_st.Add(New cRecPU(425, 1280, 365, 192))
				Me.table_7500_st.Add(New cRecPU(500, 1824, 365, 192))
				Me.table_7500_st.Add(New cRecPU(550, 1824, 365, 216))
				Me.table_7500_st.Add(New cRecPU(625, 1824, 427, 216))
				Me.table_7500_st.Add(New cRecPU(650, 1824, 427, 240))
				Me.table_7500_st.Add(New cRecPU(700, 2560, 427, 260))
				Me.table_8000_st.Clear()
				Me.table_8000_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_8000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8000_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_8000_st.Add(New cRecPU(300, 640, 365, 120))
				Me.table_8000_st.Add(New cRecPU(325, 912, 365, 144))
				Me.table_8000_st.Add(New cRecPU(350, 1280, 365, 168))
				Me.table_8000_st.Add(New cRecPU(400, 1824, 365, 192))
				Me.table_8000_st.Add(New cRecPU(550, 1824, 427, 192))
				Me.table_8000_st.Add(New cRecPU(600, 2560, 427, 240))
				Me.table_8000_st.Add(New cRecPU(650, 2560, 427, 260))
				Me.table_8500_st.Clear()
				Me.table_8500_st.Add(New cRecPU(50, 228, 246, 74))
				Me.table_8500_st.Add(New cRecPU(150, 320, 298, 86))
				Me.table_8500_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_8500_st.Add(New cRecPU(250, 640, 365, 120))
				Me.table_8500_st.Add(New cRecPU(350, 912, 365, 120))
				Me.table_8500_st.Add(New cRecPU(375, 912, 427, 144))
				Me.table_8500_st.Add(New cRecPU(400, 1280, 427, 168))
				Me.table_8500_st.Add(New cRecPU(500, 1824, 427, 192))
				Me.table_8500_st.Add(New cRecPU(550, 1824, 427, 216))
				Me.table_9000_st.Clear()
				Me.table_9000_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_9000_st.Add(New cRecPU(100, 320, 298, 86))
				Me.table_9000_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9000_st.Add(New cRecPU(250, 640, 365, 120))
				Me.table_9000_st.Add(New cRecPU(400, 912, 427, 120))
				Me.table_9000_st.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_9000_st.Add(New cRecPU(525, 1824, 427, 216))
				Me.table_9500_st.Clear()
				Me.table_9500_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_9500_st.Add(New cRecPU(100, 320, 298, 100))
				Me.table_9500_st.Add(New cRecPU(200, 456, 298, 100))
				Me.table_9500_st.Add(New cRecPU(250, 640, 365, 100))
				Me.table_9500_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_9500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_9500_st.Add(New cRecPU(400, 1824, 427, 216))
				Me.table_10000_st.Clear()
				Me.table_10000_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_10000_st.Add(New cRecPU(75, 320, 298, 100))
				Me.table_10000_st.Add(New cRecPU(150, 456, 298, 100))
				Me.table_10000_st.Add(New cRecPU(200, 640, 365, 120))
				Me.table_10000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_10000_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10000_st.Add(New cRecPU(325, 1280, 427, 192))
				Me.table_10000_st.Add(New cRecPU(375, 1824, 427, 216))
				Me.table_10000_st.Add(New cRecPU(400, 2560, 427, 240))
				Me.table_10500_st.Clear()
				Me.table_10500_st.Add(New cRecPU(50, 228, 298, 74))
				Me.table_10500_st.Add(New cRecPU(75, 228, 305, 74))
				Me.table_10500_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_10500_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_10500_st.Add(New cRecPU(225, 640, 427, 120))
				Me.table_10500_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_10500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_10500_st.Add(New cRecPU(350, 1280, 427, 192))
				Me.table_10500_st.Add(New cRecPU(375, 1824, 427, 216))
				Me.table_11000_st.Clear()
				Me.table_11000_st.Add(New cRecPU(50, 320, 298, 86))
				Me.table_11000_st.Add(New cRecPU(100, 320, 305, 86))
				Me.table_11000_st.Add(New cRecPU(150, 456, 365, 100))
				Me.table_11000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_11000_st.Add(New cRecPU(250, 912, 427, 144))
				Me.table_11000_st.Add(New cRecPU(275, 1280, 427, 192))
				Me.table_11000_st.Add(New cRecPU(325, 1824, 427, 192))
				Me.table_11000_st.Add(New cRecPU(375, 1824, 470, 240))
				Me.table_11500_st.Clear()
				Me.table_11500_st.Add(New cRecPU(75, 320, 305, 100))
				Me.table_11500_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_11500_st.Add(New cRecPU(175, 640, 427, 120))
				Me.table_11500_st.Add(New cRecPU(275, 912, 427, 120))
				Me.table_11500_st.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_11500_st.Add(New cRecPU(350, 1824, 427, 192))
				Me.table_12000_st.Clear()
				Me.table_12000_st.Add(New cRecPU(75, 320, 305, 100))
				Me.table_12000_st.Add(New cRecPU(125, 456, 365, 100))
				Me.table_12000_st.Add(New cRecPU(175, 640, 427, 100))
				Me.table_12000_st.Add(New cRecPU(200, 640, 427, 120))
				Me.table_12000_st.Add(New cRecPU(300, 912, 427, 120))
				Me.table_12000_st.Add(New cRecPU(325, 1824, 427, 192))
				Me.table_13000_st.Clear()
				Me.table_13000_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_13000_st.Add(New cRecPU(75, 456, 365, 100))
				Me.table_13000_st.Add(New cRecPU(100, 456, 427, 100))
				Me.table_13000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13000_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_13000_st.Add(New cRecPU(250, 1280, 470, 168))
				Me.table_13000_st.Add(New cRecPU(300, 1824, 470, 216))
				Me.table_13500_st.Clear()
				Me.table_13500_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_13500_st.Add(New cRecPU(75, 456, 365, 100))
				Me.table_13500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_13500_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_13500_st.Add(New cRecPU(250, 1280, 427, 168))
				Me.table_13500_st.Add(New cRecPU(275, 1824, 470, 216))
				Me.table_14000_st.Clear()
				Me.table_14000_st.Add(New cRecPU(50, 320, 356, 100))
				Me.table_14000_st.Add(New cRecPU(100, 456, 365, 100))
				Me.table_14000_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14000_st.Add(New cRecPU(175, 912, 427, 144))
				Me.table_14000_st.Add(New cRecPU(200, 1280, 427, 168))
				Me.table_14000_st.Add(New cRecPU(225, 1824, 427, 192))
				Me.table_14000_st.Add(New cRecPU(250, 1824, 470, 216))
				Me.table_14500_st.Clear()
				Me.table_14500_st.Add(New cRecPU(50, 456, 365, 100))
				Me.table_14500_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_14500_st.Add(New cRecPU(150, 640, 427, 120))
				Me.table_14500_st.Add(New cRecPU(175, 912, 427, 120))
				Me.table_14500_st.Add(New cRecPU(200, 912, 427, 144))
				Me.table_14500_st.Add(New cRecPU(225, 1824, 427, 192))
				Me.table_15000_st.Clear()
				Me.table_15000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_15000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_15000_st.Add(New cRecPU(125, 640, 427, 126))
				Me.table_15000_st.Add(New cRecPU(175, 912, 427, 120))
				Me.table_15000_st.Add(New cRecPU(200, 1824, 427, 216))
				Me.table_16000_st.Clear()
				Me.table_16000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_16000_st.Add(New cRecPU(75, 456, 427, 120))
				Me.table_16000_st.Add(New cRecPU(125, 640, 470, 120))
				Me.table_16000_st.Add(New cRecPU(150, 640, 470, 126))
				Me.table_17000_st.Clear()
				Me.table_17000_st.Add(New cRecPU(75, 456, 427, 100))
				Me.table_17000_st.Add(New cRecPU(100, 640, 427, 120))
				Me.table_17000_st.Add(New cRecPU(125, 912, 427, 120))
				Me.table_18000_st.Clear()
				Me.table_18000_st.Add(New cRecPU(50, 456, 427, 100))
				Me.table_18000_st.Add(New cRecPU(75, 640, 470, 100))
				Me.table_18000_st.Add(New cRecPU(100, 640, 470, 126))
				Me.table_18000_st.Add(New cRecPU(125, 912, 470, 144))
				Me.table_19000_st.Clear()
				Me.table_19000_st.Add(New cRecPU(50, 640, 470, 120))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub lvwUnitList_MouseDown(sender As Object, e As MouseEventArgs)
			Me.bUnitListClicked = True
		End Sub

		Public Function CheckCrankHoles(ByRef puRec As RSWIN_DESC.PUDataRec, ByRef UnitData As RSWIN_DESC.PUDataRec, ByRef iCrankHoleRet As Integer, ByRef fStroke As Single, ByRef bUseSmallest As Boolean) As Boolean
			Dim flag As Boolean = False
			Dim num As Integer = -1
			fStroke = -1F
			Debug.WriteLine(String.Concat(New String() { Conversions.ToString(CInt(UnitData.CrankHole)), " , ", Conversions.ToString(UnitData.MaxStroke), " , ", Conversions.ToString(puRec.MaxStroke) }))
			Dim num2 As Integer = 0
			Dim num3 As Integer = CInt((UnitData.CrankHoles - 1S))
			For i As Integer = num2 To num3
				Debug.WriteLine(UnitData.Strokes(i))
				If Math.Abs(puRec.MaxStroke - UnitData.Strokes(i)) < 4F Then
					iCrankHoleRet = i
					fStroke = UnitData.Strokes(i)
					flag = True
				ElseIf(Not flag And i > 0) AndAlso (UnitData.Strokes(i) < UnitData.Strokes(i - 1) And UnitData.Strokes(i) >= puRec.MaxStroke) Then
					num = i
					fStroke = UnitData.Strokes(i)
				End If
			Next
			If Not flag And bUseSmallest And num <> -1 Then
				iCrankHoleRet = num
				fStroke = UnitData.Strokes(num)
				flag = True
			End If
			Return flag
		End Function

		Private Sub PopulateRecPUFGal_MarkII()
			Try
				Me.table_2000_fg.Clear()
				Me.table_2000_fg.Add(New cRecPU(100, 55, 60, 64))
				Me.table_2000_fg.Add(New cRecPU(150, 60, 70, 64))
				Me.table_2000_fg.Add(New cRecPU(200, 80, 75, 64))
				Me.table_2000_fg.Add(New cRecPU(250, 90, 75, 64))
				Me.table_2000_fg.Add(New cRecPU(300, 114, 85, 64))
				Me.table_2000_fg.Add(New cRecPU(400, 114, 95, 64))
				Me.table_2000_fg.Add(New cRecPU(450, 160, 105, 74))
				Me.table_2000_fg.Add(New cRecPU(500, 160, 115, 74))
				Me.table_2000_fg.Add(New cRecPU(550, 160, 125, 74))
				Me.table_2000_fg.Add(New cRecPU(600, 160, 125, 86))
				Me.table_2000_fg.Add(New cRecPU(650, 228, 130, 86))
				Me.table_2000_fg.Add(New cRecPU(700, 228, 173, 100))
				Me.table_2000_fg.Add(New cRecPU(900, 320, 173, 120))
				Me.table_2000_fg.Add(New cRecPU(1000, 456, 173, 120))
				Me.table_2000_fg.Add(New cRecPU(1200, 456, 200, 120))
				Me.table_2000_fg.Add(New cRecPU(1300, 640, 200, 144))
				Me.table_2000_fg.Add(New cRecPU(1500, 640, 200, 168))
				Me.table_2000_fg.Add(New cRecPU(1600, 912, 200, 192))
				Me.table_2000_fg.Add(New cRecPU(1700, 912, 256, 168))
				Me.table_2000_fg.Add(New cRecPU(1900, 912, 246, 192))
				Me.table_2000_fg.Add(New cRecPU(2200, 1280, 246, 216))
				Me.table_2500_fg.Clear()
				Me.table_2500_fg.Add(New cRecPU(50, 45, 70, 52))
				Me.table_2500_fg.Add(New cRecPU(100, 65, 70, 64))
				Me.table_2500_fg.Add(New cRecPU(150, 80, 80, 64))
				Me.table_2500_fg.Add(New cRecPU(200, 80, 85, 64))
				Me.table_2500_fg.Add(New cRecPU(250, 114, 95, 74))
				Me.table_2500_fg.Add(New cRecPU(300, 160, 115, 74))
				Me.table_2500_fg.Add(New cRecPU(400, 160, 135, 74))
				Me.table_2500_fg.Add(New cRecPU(450, 160, 143, 74))
				Me.table_2500_fg.Add(New cRecPU(500, 228, 143, 86))
				Me.table_2500_fg.Add(New cRecPU(600, 228, 173, 86))
				Me.table_2500_fg.Add(New cRecPU(700, 320, 173, 100))
				Me.table_2500_fg.Add(New cRecPU(750, 320, 200, 100))
				Me.table_2500_fg.Add(New cRecPU(900, 456, 200, 120))
				Me.table_2500_fg.Add(New cRecPU(950, 456, 213, 120))
				Me.table_2500_fg.Add(New cRecPU(1100, 640, 256, 120))
				Me.table_2500_fg.Add(New cRecPU(1200, 640, 256, 144))
				Me.table_2500_fg.Add(New cRecPU(1300, 912, 305, 168))
				Me.table_2500_fg.Add(New cRecPU(1500, 912, 305, 192))
				Me.table_3000_fg.Clear()
				Me.table_3000_fg.Add(New cRecPU(50, 60, 70, 64))
				Me.table_3000_fg.Add(New cRecPU(100, 80, 80, 64))
				Me.table_3000_fg.Add(New cRecPU(150, 114, 100, 64))
				Me.table_3000_fg.Add(New cRecPU(200, 114, 119, 64))
				Me.table_3000_fg.Add(New cRecPU(350, 160, 143, 74))
				Me.table_3000_fg.Add(New cRecPU(400, 228, 143, 86))
				Me.table_3000_fg.Add(New cRecPU(450, 228, 173, 86))
				Me.table_3000_fg.Add(New cRecPU(600, 320, 200, 100))
				Me.table_3000_fg.Add(New cRecPU(700, 456, 213, 120))
				Me.table_3000_fg.Add(New cRecPU(800, 456, 256, 120))
				Me.table_3000_fg.Add(New cRecPU(950, 640, 256, 120))
				Me.table_3000_fg.Add(New cRecPU(1100, 912, 305, 144))
				Me.table_3000_fg.Add(New cRecPU(1200, 912, 305, 192))
				Me.table_3000_fg.Add(New cRecPU(1250, 1280, 305, 216))
				Me.table_3500_fg.Clear()
				Me.table_3500_fg.Add(New cRecPU(50, 80, 80, 64))
				Me.table_3500_fg.Add(New cRecPU(100, 80, 100, 64))
				Me.table_3500_fg.Add(New cRecPU(150, 114, 129, 64))
				Me.table_3500_fg.Add(New cRecPU(250, 160, 143, 74))
				Me.table_3500_fg.Add(New cRecPU(300, 160, 173, 74))
				Me.table_3500_fg.Add(New cRecPU(350, 228, 200, 86))
				Me.table_3500_fg.Add(New cRecPU(450, 320, 200, 100))
				Me.table_3500_fg.Add(New cRecPU(600, 456, 200, 120))
				Me.table_3500_fg.Add(New cRecPU(700, 456, 256, 120))
				Me.table_3500_fg.Add(New cRecPU(850, 640, 256, 120))
				Me.table_3500_fg.Add(New cRecPU(950, 912, 305, 168))
				Me.table_3500_fg.Add(New cRecPU(1050, 1280, 305, 192))
				Me.table_3500_fg.Add(New cRecPU(1100, 1280, 305, 216))
				Me.table_4000_fg.Clear()
				Me.table_4000_fg.Add(New cRecPU(50, 80, 112, 64))
				Me.table_4000_fg.Add(New cRecPU(100, 114, 112, 64))
				Me.table_4000_fg.Add(New cRecPU(150, 114, 143, 64))
				Me.table_4000_fg.Add(New cRecPU(250, 160, 143, 74))
				Me.table_4000_fg.Add(New cRecPU(300, 228, 200, 74))
				Me.table_4000_fg.Add(New cRecPU(400, 320, 213, 100))
				Me.table_4000_fg.Add(New cRecPU(500, 456, 213, 120))
				Me.table_4000_fg.Add(New cRecPU(550, 640, 213, 144))
				Me.table_4000_fg.Add(New cRecPU(600, 640, 305, 168))
				Me.table_4000_fg.Add(New cRecPU(750, 912, 305, 168))
				Me.table_4000_fg.Add(New cRecPU(750, 912, 305, 192))
				Me.table_4000_fg.Add(New cRecPU(800, 1280, 305, 192))
				Me.table_4000_fg.Add(New cRecPU(850, 1280, 305, 216))
				Me.table_4500_fg.Clear()
				Me.table_4500_fg.Add(New cRecPU(50, 80, 100, 64))
				Me.table_4500_fg.Add(New cRecPU(150, 114, 143, 64))
				Me.table_4500_fg.Add(New cRecPU(200, 160, 143, 74))
				Me.table_4500_fg.Add(New cRecPU(250, 228, 173, 74))
				Me.table_4500_fg.Add(New cRecPU(300, 228, 200, 74))
				Me.table_4500_fg.Add(New cRecPU(350, 320, 200, 86))
				Me.table_4500_fg.Add(New cRecPU(500, 456, 256, 100))
				Me.table_4500_fg.Add(New cRecPU(600, 640, 256, 120))
				Me.table_4500_fg.Add(New cRecPU(650, 912, 305, 192))
				Me.table_4500_fg.Add(New cRecPU(700, 912, 305, 192))
				Me.table_5000_fg.Clear()
				Me.table_5000_fg.Add(New cRecPU(50, 80, 115, 64))
				Me.table_5000_fg.Add(New cRecPU(100, 114, 143, 64))
				Me.table_5000_fg.Add(New cRecPU(150, 160, 143, 74))
				Me.table_5000_fg.Add(New cRecPU(200, 228, 173, 74))
				Me.table_5000_fg.Add(New cRecPU(250, 228, 200, 86))
				Me.table_5000_fg.Add(New cRecPU(300, 320, 200, 100))
				Me.table_5000_fg.Add(New cRecPU(500, 456, 256, 100))
				Me.table_5000_fg.Add(New cRecPU(550, 640, 256, 120))
				Me.table_5000_fg.Add(New cRecPU(650, 640, 305, 120))
				Me.table_5000_fg.Add(New cRecPU(750, 912, 305, 128))
				Me.table_5500_fg.Clear()
				Me.table_5500_fg.Add(New cRecPU(100, 114, 143, 64))
				Me.table_5500_fg.Add(New cRecPU(150, 160, 173, 74))
				Me.table_5500_fg.Add(New cRecPU(250, 228, 200, 86))
				Me.table_5500_fg.Add(New cRecPU(300, 320, 256, 100))
				Me.table_5500_fg.Add(New cRecPU(400, 456, 256, 120))
				Me.table_5500_fg.Add(New cRecPU(450, 640, 256, 120))
				Me.table_5500_fg.Add(New cRecPU(550, 640, 305, 120))
				Me.table_5500_fg.Add(New cRecPU(750, 912, 305, 144))
				Me.table_6000_fg.Clear()
				Me.table_6000_fg.Add(New cRecPU(50, 144, 143, 64))
				Me.table_6000_fg.Add(New cRecPU(100, 160, 173, 74))
				Me.table_6000_fg.Add(New cRecPU(150, 228, 173, 74))
				Me.table_6000_fg.Add(New cRecPU(200, 228, 173, 74))
				Me.table_6000_fg.Add(New cRecPU(300, 320, 256, 84))
				Me.table_6000_fg.Add(New cRecPU(350, 456, 256, 100))
				Me.table_6000_fg.Add(New cRecPU(450, 640, 256, 120))
				Me.table_6000_fg.Add(New cRecPU(500, 640, 305, 120))
				Me.table_6000_fg.Add(New cRecPU(700, 912, 305, 144))
				Me.table_6500_fg.Clear()
				Me.table_6500_fg.Add(New cRecPU(50, 114, 173, 64))
				Me.table_6500_fg.Add(New cRecPU(100, 160, 173, 74))
				Me.table_6500_fg.Add(New cRecPU(150, 228, 173, 74))
				Me.table_6500_fg.Add(New cRecPU(200, 228, 200, 74))
				Me.table_6500_fg.Add(New cRecPU(250, 320, 256, 86))
				Me.table_6500_fg.Add(New cRecPU(400, 456, 256, 100))
				Me.table_6500_fg.Add(New cRecPU(500, 640, 305, 120))
				Me.table_6500_fg.Add(New cRecPU(600, 912, 305, 144))
				Me.table_6500_fg.Add(New cRecPU(650, 912, 356, 144))
				Me.table_7000_fg.Clear()
				Me.table_7000_fg.Add(New cRecPU(50, 114, 173, 64))
				Me.table_7000_fg.Add(New cRecPU(100, 160, 173, 74))
				Me.table_7000_fg.Add(New cRecPU(150, 228, 200, 74))
				Me.table_7000_fg.Add(New cRecPU(200, 320, 256, 86))
				Me.table_7000_fg.Add(New cRecPU(350, 456, 256, 100))
				Me.table_7000_fg.Add(New cRecPU(450, 640, 305, 120))
				Me.table_7000_fg.Add(New cRecPU(550, 912, 305, 144))
				Me.table_7000_fg.Add(New cRecPU(700, 1280, 356, 168))
				Me.table_7000_fg.Add(New cRecPU(750, 1280, 427, 168))
				Me.table_7500_fg.Clear()
				Me.table_7500_fg.Add(New cRecPU(50, 114, 173, 52))
				Me.table_7500_fg.Add(New cRecPU(100, 160, 173, 74))
				Me.table_7500_fg.Add(New cRecPU(150, 228, 246, 74))
				Me.table_7500_fg.Add(New cRecPU(200, 320, 256, 86))
				Me.table_7500_fg.Add(New cRecPU(250, 456, 256, 100))
				Me.table_7500_fg.Add(New cRecPU(400, 640, 305, 120))
				Me.table_7500_fg.Add(New cRecPU(500, 912, 305, 144))
				Me.table_7500_fg.Add(New cRecPU(750, 1280, 427, 168))
				Me.table_8000_fg.Clear()
				Me.table_8000_fg.Add(New cRecPU(50, 114, 200, 60))
				Me.table_8000_fg.Add(New cRecPU(100, 160, 200, 60))
				Me.table_8000_fg.Add(New cRecPU(150, 228, 246, 74))
				Me.table_8000_fg.Add(New cRecPU(200, 320, 256, 86))
				Me.table_8000_fg.Add(New cRecPU(250, 456, 256, 100))
				Me.table_8000_fg.Add(New cRecPU(350, 640, 305, 120))
				Me.table_8000_fg.Add(New cRecPU(550, 912, 356, 144))
				Me.table_8000_fg.Add(New cRecPU(650, 1280, 427, 168))
				Me.table_8000_fg.Add(New cRecPU(800, 1824, 427, 192))
				Me.table_8500_fg.Clear()
				Me.table_8500_fg.Add(New cRecPU(50, 114, 200, 64))
				Me.table_8500_fg.Add(New cRecPU(100, 228, 200, 74))
				Me.table_8500_fg.Add(New cRecPU(150, 320, 256, 84))
				Me.table_8500_fg.Add(New cRecPU(250, 456, 256, 100))
				Me.table_8500_fg.Add(New cRecPU(300, 640, 305, 120))
				Me.table_8500_fg.Add(New cRecPU(450, 912, 305, 144))
				Me.table_8500_fg.Add(New cRecPU(600, 1280, 365, 168))
				Me.table_8500_fg.Add(New cRecPU(750, 1824, 427, 192))
				Me.table_8500_fg.Add(New cRecPU(800, 1824, 427, 216))
				Me.table_9000_fg.Clear()
				Me.table_9000_fg.Add(New cRecPU(50, 160, 200, 74))
				Me.table_9000_fg.Add(New cRecPU(100, 228, 246, 74))
				Me.table_9000_fg.Add(New cRecPU(150, 320, 256, 100))
				Me.table_9000_fg.Add(New cRecPU(200, 456, 256, 120))
				Me.table_9000_fg.Add(New cRecPU(300, 640, 305, 120))
				Me.table_9000_fg.Add(New cRecPU(450, 912, 356, 144))
				Me.table_9000_fg.Add(New cRecPU(550, 1280, 427, 168))
				Me.table_9000_fg.Add(New cRecPU(600, 1824, 427, 192))
				Me.table_9000_fg.Add(New cRecPU(700, 1824, 427, 216))
				Me.table_9500_fg.Clear()
				Me.table_9500_fg.Add(New cRecPU(50, 160, 200, 74))
				Me.table_9500_fg.Add(New cRecPU(100, 228, 246, 86))
				Me.table_9500_fg.Add(New cRecPU(150, 320, 256, 100))
				Me.table_9500_fg.Add(New cRecPU(175, 456, 256, 120))
				Me.table_9500_fg.Add(New cRecPU(250, 640, 305, 120))
				Me.table_9500_fg.Add(New cRecPU(300, 640, 356, 144))
				Me.table_9500_fg.Add(New cRecPU(400, 912, 356, 144))
				Me.table_9500_fg.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_9500_fg.Add(New cRecPU(550, 1280, 427, 192))
				Me.table_9500_fg.Add(New cRecPU(650, 1824, 427, 216))
				Me.table_10000_fg.Clear()
				Me.table_10000_fg.Add(New cRecPU(50, 160, 200, 74))
				Me.table_10000_fg.Add(New cRecPU(75, 228, 256, 84))
				Me.table_10000_fg.Add(New cRecPU(100, 320, 256, 100))
				Me.table_10000_fg.Add(New cRecPU(150, 456, 256, 120))
				Me.table_10000_fg.Add(New cRecPU(200, 640, 305, 120))
				Me.table_10000_fg.Add(New cRecPU(300, 912, 356, 144))
				Me.table_10000_fg.Add(New cRecPU(350, 912, 356, 168))
				Me.table_10000_fg.Add(New cRecPU(500, 1280, 427, 168))
				Me.table_10000_fg.Add(New cRecPU(550, 1824, 427, 192))
				Me.table_10000_fg.Add(New cRecPU(600, 1824, 427, 216))
				Me.table_10500_fg.Clear()
				Me.table_10500_fg.Add(New cRecPU(50, 228, 200, 74))
				Me.table_10500_fg.Add(New cRecPU(100, 320, 256, 100))
				Me.table_10500_fg.Add(New cRecPU(150, 456, 304, 120))
				Me.table_10500_fg.Add(New cRecPU(200, 640, 304, 144))
				Me.table_10500_fg.Add(New cRecPU(300, 912, 305, 168))
				Me.table_10500_fg.Add(New cRecPU(400, 1280, 427, 168))
				Me.table_10500_fg.Add(New cRecPU(450, 1824, 427, 192))
				Me.table_10500_fg.Add(New cRecPU(600, 1824, 427, 216))
				Me.table_11000_fg.Clear()
				Me.table_11000_fg.Add(New cRecPU(50, 228, 246, 86))
				Me.table_11000_fg.Add(New cRecPU(100, 320, 256, 100))
				Me.table_11000_fg.Add(New cRecPU(200, 640, 305, 144))
				Me.table_11000_fg.Add(New cRecPU(250, 912, 356, 144))
				Me.table_11000_fg.Add(New cRecPU(450, 1280, 365, 192))
				Me.table_11000_fg.Add(New cRecPU(550, 1824, 365, 216))
				Me.table_11000_fg.Add(New cRecPU(600, 1824, 427, 216))
				Me.table_12000_fg.Clear()
				Me.table_12000_fg.Add(New cRecPU(50, 320, 256, 100))
				Me.table_12000_fg.Add(New cRecPU(100, 456, 256, 120))
				Me.table_12000_fg.Add(New cRecPU(150, 640, 305, 144))
				Me.table_12000_fg.Add(New cRecPU(250, 912, 305, 168))
				Me.table_12000_fg.Add(New cRecPU(300, 1280, 427, 168))
				Me.table_12000_fg.Add(New cRecPU(350, 1824, 427, 192))
				Me.table_13000_fg.Clear()
				Me.table_13000_fg.Add(New cRecPU(50, 320, 256, 100))
				Me.table_13000_fg.Add(New cRecPU(100, 456, 256, 120))
				Me.table_13000_fg.Add(New cRecPU(150, 640, 305, 144))
				Me.table_13000_fg.Add(New cRecPU(300, 1280, 356, 192))
				Me.table_13000_fg.Add(New cRecPU(350, 1824, 365, 216))
				Me.table_13000_fg.Add(New cRecPU(400, 1824, 427, 216))
				Me.table_14000_fg.Clear()
				Me.table_14000_fg.Add(New cRecPU(50, 456, 304, 120))
				Me.table_14000_fg.Add(New cRecPU(100, 640, 305, 144))
				Me.table_14000_fg.Add(New cRecPU(150, 912, 305, 144))
				Me.table_14000_fg.Add(New cRecPU(200, 912, 305, 168))
				Me.table_14000_fg.Add(New cRecPU(300, 1824, 356, 216))
				Me.table_15000_fg.Clear()
				Me.table_15000_fg.Add(New cRecPU(50, 640, 305, 144))
				Me.table_15000_fg.Add(New cRecPU(100, 912, 356, 144))
				Me.table_15000_fg.Add(New cRecPU(150, 912, 356, 168))
				Me.table_15000_fg.Add(New cRecPU(200, 1280, 356, 192))
				Me.table_15000_fg.Add(New cRecPU(250, 1824, 427, 216))
				Me.table_16000_fg.Clear()
				Me.table_16000_fg.Add(New cRecPU(50, 912, 305, 168))
				Me.table_16000_fg.Add(New cRecPU(100, 912, 356, 168))
				Me.table_16000_fg.Add(New cRecPU(150, 1280, 356, 192))
				Me.table_16000_fg.Add(New cRecPU(200, 1280, 356, 216))
				Me.table_16000_fg.Add(New cRecPU(250, 1824, 356, 216))
				Me.table_17000_fg.Clear()
				Me.table_17000_fg.Add(New cRecPU(50, 912, 305, 168))
				Me.table_17000_fg.Add(New cRecPU(100, 912, 356, 168))
				Me.table_17000_fg.Add(New cRecPU(150, 1280, 427, 192))
				Me.table_17000_fg.Add(New cRecPU(200, 1824, 356, 216))
				Me.table_18000_fg.Clear()
				Me.table_18000_fg.Add(New cRecPU(50, 912, 356, 168))
				Me.table_18000_fg.Add(New cRecPU(100, 1280, 427, 192))
				Me.table_18000_fg.Add(New cRecPU(150, 1280, 356, 216))
				Me.table_19000_fg.Clear()
				Me.table_19000_fg.Add(New cRecPU(100, 1824, 427, 216))
			Catch ex As Exception
			End Try
		End Sub

		Public Function SetCBMTooltipText() As Object
			Try
				If Me.MyParentFrm Is Nothing Then
					Me.MyParentFrm = New RODSTAR()
					Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
				End If
				If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
					Me.MyParentFrm.tbrCBM.ToolTipText = Me.sExportRequiredUnbalance
				Else
					Me.MyParentFrm.tbrCBM.ToolTipText = Me.sExportCBMoment
				End If
			Catch ex As Exception
			End Try
			Dim result As Object
			Return result
		End Function

		Private Sub txtPercentUpstrokeSPM_TextChanged(sender As Object, e As EventArgs)
			If Me.txtPercentUpstrokeSPM Is Me.ActiveControl Then
				Dim flag As Boolean = False
				Dim flag2 As Boolean = flag
				Dim txtPercentUpstrokeSPM As TextBox = Me.txtPercentUpstrokeSPM
				Dim bValidIfEmpty As Boolean = 1
				Dim bShowMessage As Boolean = 0
				Dim num As Single
				Dim obj As Object = num
				Dim flag3 As Boolean = CtrlUI.CheckValid(txtPercentUpstrokeSPM, bValidIfEmpty, bShowMessage, obj)
				num = Conversions.ToSingle(obj)
				If flag2 <> flag3 Then
					If Not Information.IsDBNull(num) AndAlso (num < 100F And num > 0F) Then
						RSWIN_DESC.rst.PercentUpstrokeSPM = num
						RSWIN_DESC.rst.PercentDownstrokeSPM = 100F - RSWIN_DESC.rst.PercentUpstrokeSPM
						Me.txtPercentDownstrokeSPM.Text = Conversions.ToString(RSWIN_DESC.rst.PercentDownstrokeSPM)
						ini.SaveDataValue("PercentUpstrokePumpingSpeed", RSWIN_DESC.rst.PercentUpstrokeSPM)
						ini.SaveDataValue("PercentDownstrokeSPMPumpingSpeed", RSWIN_DESC.rst.PercentDownstrokeSPM)
					End If
				End If
				Return
			End If
		End Sub

		Private Sub txtPercentDownstrokeSPM_TextChanged(sender As Object, e As EventArgs)
			If Me.txtPercentDownstrokeSPM Is Me.ActiveControl Then
				Dim flag As Boolean = False
				Dim flag2 As Boolean = flag
				Dim txtPercentDownstrokeSPM As TextBox = Me.txtPercentDownstrokeSPM
				Dim bValidIfEmpty As Boolean = 1
				Dim bShowMessage As Boolean = 0
				Dim num As Single
				Dim obj As Object = num
				Dim flag3 As Boolean = CtrlUI.CheckValid(txtPercentDownstrokeSPM, bValidIfEmpty, bShowMessage, obj)
				num = Conversions.ToSingle(obj)
				If flag2 <> flag3 Then
					If Not Information.IsDBNull(num) AndAlso (num < 100F And num > 0F) Then
						RSWIN_DESC.rst.PercentDownstrokeSPM = num
						RSWIN_DESC.rst.PercentUpstrokeSPM = 100F - RSWIN_DESC.rst.PercentDownstrokeSPM
						Me.txtPercentUpstrokeSPM.Text = Conversions.ToString(RSWIN_DESC.rst.PercentUpstrokeSPM)
						ini.SaveDataValue("PercentUpstrokePumpingSpeed", RSWIN_DESC.rst.PercentUpstrokeSPM)
						ini.SaveDataValue("PercentDownstrokeSPMPumpingSpeed", RSWIN_DESC.rst.PercentDownstrokeSPM)
					End If
				End If
				Return
			End If
		End Sub

		Private Sub optUseBeamBalancedCalcs_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.optUseBeamBalancedCalcs Is Me.ActiveControl Then
				RSWIN_DESC.rst.bUseCrankBalancedCalcs = False
				ini.SaveDataValue("UseCrankBalancedCalcs", RSWIN_DESC.rst.bUseCrankBalancedCalcs)
			End If
			If RSWIN_DESC.rst.bUseCrankBalancedCalcs Then
				Me.optCBDataType_3.Text = Me.sUnknownMCM
				Me.optCBDataType_1.Text = Me.sExistingMaximumCounterbalanceMoment
				Me.txtCounterbalance.Tag = "Lee"
				Me.optCBDataType_5.Enabled = True
				Me.optCBDataType_5.Text = Me.sUseXBALInformation
				Me.txtCounterbalance.Visible = True
				Me.lblMInLbs.Visible = True
				Me.lblMInLbs.Left = Me.optCBDataType_1.Left + Me.optCBDataType_1.Width + 10
				Me.lblCounterbalance_Disabled.Visible = True
				Me.pnlHydraulic.Visible = False
				Me.grpCounterBalance.Visible = True
				Me.pnlCombinationBeamCrank.Visible = False
				Return
			End If
			Me.optCBDataType_3.Text = Me.sUnknownCounterbalanceData
			Me.optCBDataType_1.Text = Me.sExistingStructuralUnbalance
			Me.txtCounterbalance.Tag = "lee"
			Me.optCBDataType_5.Enabled = True
			Me.optCBDataType_5.Text = Me.sUseXBALInformation
			Me.txtCounterbalance.Visible = False
			Me.lblMInLbs.Visible = False
			Me.lblCounterbalance_Disabled.Visible = False
			Me.pnlHydraulic.Visible = False
			Me.grpCounterBalance.Visible = True
			Me.pnlCombinationBeamCrank.Visible = False
		End Sub

		Private Sub optUseCrankBalancedCalcs_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.optUseCrankBalancedCalcs Is Me.ActiveControl Then
				RSWIN_DESC.rst.bUseCrankBalancedCalcs = True
				ini.SaveDataValue("UseCrankBalancedCalcs", RSWIN_DESC.rst.bUseCrankBalancedCalcs)
			End If
			If RSWIN_DESC.rst.bUseCrankBalancedCalcs Then
				Me.optCBDataType_3.Text = Me.sUnknownMCM
				Me.optCBDataType_1.Text = Me.sExistingMaximumCounterbalanceMoment
				Me.txtCounterbalance.Tag = "Lee"
				Me.optCBDataType_5.Enabled = True
				Me.optCBDataType_5.Text = Me.sUseXBALInformation
				Me.txtCounterbalance.Visible = True
				Me.lblMInLbs.Visible = True
				Me.lblMInLbs.Left = Me.optCBDataType_1.Left + Me.optCBDataType_1.Width + 10
				Me.lblCounterbalance_Disabled.Visible = True
				Me.pnlHydraulic.Visible = False
				Me.grpCounterBalance.Visible = True
				Me.pnlCombinationBeamCrank.Visible = False
				Return
			End If
			Me.optCBDataType_3.Text = Me.sUnknownCounterbalanceData
			Me.optCBDataType_1.Text = Me.sExistingStructuralUnbalance
			Me.txtCounterbalance.Tag = "lee"
			Me.optCBDataType_5.Enabled = True
			Me.optCBDataType_5.Text = Me.sUseXBALInformation
			Me.txtCounterbalance.Visible = False
			Me.lblMInLbs.Visible = False
			Me.lblCounterbalance_Disabled.Visible = False
			Me.pnlHydraulic.Visible = False
			Me.grpCounterBalance.Visible = True
			Me.pnlCombinationBeamCrank.Visible = False
		End Sub

		Private Sub pnlHydraulic_VisibleChanged(sender As Object, e As EventArgs)
			Me.bHydraulic = Me.pnlHydraulic.Visible
		End Sub

		Private Sub txtPercentUpstrokeSPM_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = flag
			Dim txtPercentUpstrokeSPM As TextBox = Me.txtPercentUpstrokeSPM
			Dim bValidIfEmpty As Boolean = 1
			Dim bShowMessage As Boolean = 0
			Dim num As Single
			Dim obj As Object = num
			Dim flag3 As Boolean = CtrlUI.CheckValid(txtPercentUpstrokeSPM, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			If flag2 = flag3 Then
				Return
			End If
			If Not Information.IsDBNull(num) Then
				If num > 80F Then
					MessageBox.Show("Percent Upstroke SPM cannot be greater than 80%")
					Me.txtPercentUpstrokeSPM.Text = Conversions.ToString(80)
					Me.txtPercentDownstrokeSPM.Text = Conversions.ToString(20)
				ElseIf num < 20F Then
					MessageBox.Show("Percent Upstroke SPM cannot be less than 20%")
					Me.txtPercentUpstrokeSPM.Text = Conversions.ToString(20)
					Me.txtPercentDownstrokeSPM.Text = Conversions.ToString(80)
				End If
				ini.SaveDataValue("PercentUpstrokePumpingSpeed", RSWIN_DESC.rst.PercentUpstrokeSPM)
				ini.SaveDataValue("PercentDownstrokeSPMPumpingSpeed", RSWIN_DESC.rst.PercentDownstrokeSPM)
			End If
		End Sub

		Private Sub txtPercentDownstrokeSPM_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = flag
			Dim txtPercentDownstrokeSPM As TextBox = Me.txtPercentDownstrokeSPM
			Dim bValidIfEmpty As Boolean = 1
			Dim bShowMessage As Boolean = 0
			Dim num As Single
			Dim obj As Object = num
			Dim flag3 As Boolean = CtrlUI.CheckValid(txtPercentDownstrokeSPM, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			If flag2 = flag3 Then
				Return
			End If
			If Not Information.IsDBNull(num) Then
				If num > 80F Then
					MessageBox.Show("Percent Downstroke SPM cannot be greater than 80%")
					Me.txtPercentDownstrokeSPM.Text = Conversions.ToString(80)
					Me.txtPercentUpstrokeSPM.Text = Conversions.ToString(20)
				ElseIf num < 20F Then
					MessageBox.Show("Percent Downstroke SPM cannot be less than 20%")
					Me.txtPercentDownstrokeSPM.Text = Conversions.ToString(20)
					Me.txtPercentUpstrokeSPM.Text = Conversions.ToString(80)
				End If
				ini.SaveDataValue("PercentUpstrokePumpingSpeed", RSWIN_DESC.rst.PercentUpstrokeSPM)
				ini.SaveDataValue("PercentDownstrokeSPMPumpingSpeed", RSWIN_DESC.rst.PercentDownstrokeSPM)
			End If
		End Sub

		Private Sub txtAdjustedStrokeLength_Enter(sender As Object, e As EventArgs)
			Me.txtAdjustedStrokeLength.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtAdjustedStrokeLength_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtAdjustedStrokeLength As TextBox = Me.txtAdjustedStrokeLength
			Dim lblAdjustedStrokeLength As Label = Me.lblAdjustedStrokeLength
			CtrlUI.TextBox_KeyDown(txtAdjustedStrokeLength, lblAdjustedStrokeLength, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me.lblAdjustedStrokeLength = lblAdjustedStrokeLength
			Me.txtAdjustedStrokeLength = txtAdjustedStrokeLength
		End Sub

		Private Sub txtAdjustedStrokeLength_TextChanged(sender As Object, e As EventArgs)
			Try
				If Me.ActiveControl Is Me.txtAdjustedStrokeLength Then
					If Versioned.IsNumeric(Me.txtAdjustedStrokeLength.Text) Then
						Dim txtAdjustedStrokeLength As TextBox = Me.txtAdjustedStrokeLength
						Dim bValidIfEmpty As Boolean = True
						Dim bShowMessage As Boolean = False
						Dim num As Single
						Dim obj As Object = num
						Dim flag As Boolean = CtrlUI.CheckValid(txtAdjustedStrokeLength, bValidIfEmpty, bShowMessage, obj)
						num = Conversions.ToSingle(obj)
						If flag Then
							If num > RSWIN_DESC.rst.PU.MaxStroke Then
								num = RSWIN_DESC.rst.PU.MaxStroke
								Me.txtAdjustedStrokeLength.Tag = "cee"
								Me.txtAdjustedStrokeLength.Text = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
							End If
							RSWIN_DESC.rst.AdjustedStrokeLength = num
							ini.SaveDataValue("AdjustedStrokeLength", num)
						End If
					End If
				ElseIf Versioned.IsNumeric(Me.txtAdjustedStrokeLength.Text) Then
					ini.SaveDataValue("AdjustedStrokeLength", RSWIN_DESC.rst.AdjustedStrokeLength)
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

		Private Sub PUData_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PUData_MouseDown(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PUData_MouseEnter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PUData_MouseMove(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PUData_MouseUp(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PUData_MouseWheel(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PUData_Move(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PUData_Scroll(sender As Object, e As ScrollEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PUData_KeyPress(sender As Object, e As KeyPressEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PUData_KeyUp(sender As Object, e As KeyEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PUData_DragDrop(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PUData_DragEnter(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PUData_FormClosed(sender As Object, e As FormClosedEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub PUData_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub PUData_LostFocus(sender As Object, e As EventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub PUData_GotFocus(sender As Object, e As EventArgs)
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

		Private Sub optCBDataType_5_TextChanged(sender As Object, e As EventArgs)
		End Sub

		Private bMarkII As Boolean

		Private bRMark As Boolean

		Private bRotaflex As Boolean

		Private bAB As Boolean

		Private bHydraulic As Boolean

		Private m_bClosing As Boolean

		Private m_bValidated As Boolean

		Private bFormLoaded As Boolean

		Private bInit As Boolean

		Private bRecPULoaded As Boolean

		Private bCustomUnit As Boolean

		Private sUnknownCounterbalanceWeight As String

		Private sExistingCounterbalanceWeight As String

		Private sUseXBALInformation As String

		Private sUnknownAirTankPressure As String

		Private sExistingAirTankPressure As String

		Private sUnknownCounterbalanceData As String

		Private sExistingStructuralUnbalance As String

		Private sUnknownMCM As String

		Private sExistingMaximumCounterbalanceMoment As String

		Private sExistingMaximumCounterbalanceWeight As String

		Private sFileNoneSelected As String

		Private sFile As String

		Private sUnitID As String

		Private sUnitSizeRecommendation As String

		Private sSelectUnitSizeRecommendation As String

		Private csHDR_APIDES As String

		Private csHDR_UNITDES As String

		Private csHDR_MANUF As String

		Private csHDR_OTHER As String

		Private csHDR_UNAME As String

		Private csKEY_APIDES As String

		Private csKEY_MANUF As String

		Private csKEY_OTHER As String

		Private csKEY_UNAME As String

		Private sPUNotEntered As String

		Private sPUNoInfo As String

		Private sProdNotValid As String

		Private sRecommendedUnitSize As String

		Private sNoRecommendation As String

		Private sSelect As String

		Private sUpdateUnbalance As String

		Private bUnbalancedAsked As Boolean

		Private sExportCBMoment As String

		Private sExportRequiredUnbalance As String

		Private sXBALFileMessage1 As String

		Private sXBALFileMessage2 As String

		<AccessedThroughProperty("pnlPUData")>
		Private _pnlPUData As Panel

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("lblCalcStroke")>
		Private _lblCalcStroke As Label

		<AccessedThroughProperty("grpCounterBalance")>
		Private _grpCounterBalance As GroupBox

		<AccessedThroughProperty("lblMInLbs")>
		Private _lblMInLbs As Label

		<AccessedThroughProperty("lblUnitID")>
		Private _lblUnitID As Label

		<AccessedThroughProperty("lblStructuralUnbalance")>
		Private _lblStructuralUnbalance As Label

		<AccessedThroughProperty("lblStrokeLength")>
		Private _lblStrokeLength As Label

		<AccessedThroughProperty("txtUnbalance")>
		Private _txtUnbalance As TextBox

		<AccessedThroughProperty("cmdReadCBLFile")>
		Private _cmdReadCBLFile As Button

		<AccessedThroughProperty("optCBDataType_1")>
		Private _optCBDataType_1 As RadioButton

		<AccessedThroughProperty("lvwUnitList")>
		Private _lvwUnitList As ListView

		<AccessedThroughProperty("txtUnitID")>
		Private _txtUnitID As TextBox

		<AccessedThroughProperty("cboManufMenu")>
		Private _cboManufMenu As ComboBox

		<AccessedThroughProperty("cboCrankHole")>
		Private _cboCrankHole As ComboBox

		<AccessedThroughProperty("cboCrankRotation")>
		Private _cboCrankRotation As ComboBox

		<AccessedThroughProperty("chkCustomPUDB")>
		Private _chkCustomPUDB As CheckBox

		<AccessedThroughProperty("lblCBDataFile")>
		Private _lblCBDataFile As Label

		<AccessedThroughProperty("lblAPI")>
		Private _lblAPI As Label

		<AccessedThroughProperty("txtCounterbalance")>
		Private _txtCounterbalance As TextBox

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		<AccessedThroughProperty("optCBDataType_3")>
		Private _optCBDataType_3 As RadioButton

		<AccessedThroughProperty("optCBDataType_5")>
		Private _optCBDataType_5 As RadioButton

		<AccessedThroughProperty("optCBDataType_6")>
		Private _optCBDataType_6 As RadioButton

		<AccessedThroughProperty("cmdCBApplet")>
		Private _cmdCBApplet As Button

		<AccessedThroughProperty("cmdUnitSizeRecommendation")>
		Private _cmdUnitSizeRecommendation As Button

		<AccessedThroughProperty("ToolTip1")>
		Private _ToolTip1 As ToolTip

		<AccessedThroughProperty("lblManufacturer")>
		Private _lblManufacturer As Label

		<AccessedThroughProperty("lblCrankRotation")>
		Private _lblCrankRotation As Label

		<AccessedThroughProperty("lblCrankHole")>
		Private _lblCrankHole As Label

		<AccessedThroughProperty("lblCounterbalance_Disabled")>
		Private _lblCounterbalance_Disabled As Label

		<AccessedThroughProperty("pnlHydraulic")>
		Private _pnlHydraulic As Panel

		<AccessedThroughProperty("txtPercentDownstrokeSPM")>
		Private _txtPercentDownstrokeSPM As TextBox

		<AccessedThroughProperty("txtPercentUpstrokeSPM")>
		Private _txtPercentUpstrokeSPM As TextBox

		<AccessedThroughProperty("pnlCombinationBeamCrank")>
		Private _pnlCombinationBeamCrank As Panel

		<AccessedThroughProperty("optUseCrankBalancedCalcs")>
		Private _optUseCrankBalancedCalcs As RadioButton

		<AccessedThroughProperty("optUseBeamBalancedCalcs")>
		Private _optUseBeamBalancedCalcs As RadioButton

		<AccessedThroughProperty("lblPercentDownstrokeSPM")>
		Private _lblPercentDownstrokeSPM As Label

		<AccessedThroughProperty("lblPercentUpstrokeSPM")>
		Private _lblPercentUpstrokeSPM As Label

		<AccessedThroughProperty("lblAdjustedStrokeLength")>
		Private _lblAdjustedStrokeLength As Label

		<AccessedThroughProperty("txtAdjustedStrokeLength")>
		Private _txtAdjustedStrokeLength As TextBox

		Private Shared m_vb6FormDefInstance As PUData

		Private Shared m_InitializingDefInstance As Boolean

		Private Const cMAXHEIGHT As Integer = 4365

		Private Const cMAXWIDTH As Integer = 7875

		Private Const LT As Short = -1S

		Private Const EQ As Short = 0S

		Private Const GT As Short = 1S

		Private Const LBLCOUNTERBALANCE As Short = 9S

		Private bCBALShown As Boolean

		Private Const KEY_MANUF As Integer = 1

		Private Const KEY_APIDES As Integer = 2

		Private Const KEY_UNAME As Integer = 3

		Private Const KEY_OTHER As Integer = 4

		Private iKEY_APIDES As Integer

		Private iKEY_MANUF As Integer

		Private iKEY_OTHER As Integer

		Private iKEY_UNAME As Integer

		Private uIdx As Integer()

		Private bCrankRotationClicked As Boolean

		Private bCrankHoleClicked As Boolean

		Private bUnitListClicked As Boolean

		Private bManufMenuClicked As Boolean

		Private table_1000_fg As ArrayList

		Private table_1500_fg As ArrayList

		Private table_2000_fg As ArrayList

		Private table_2500_fg As ArrayList

		Private table_3000_fg As ArrayList

		Private table_3500_fg As ArrayList

		Private table_4000_fg As ArrayList

		Private table_4500_fg As ArrayList

		Private table_5000_fg As ArrayList

		Private table_5500_fg As ArrayList

		Private table_6000_fg As ArrayList

		Private table_6500_fg As ArrayList

		Private table_7500_fg As ArrayList

		Private table_7000_fg As ArrayList

		Private table_8000_fg As ArrayList

		Private table_8500_fg As ArrayList

		Private table_9000_fg As ArrayList

		Private table_9500_fg As ArrayList

		Private table_10000_fg As ArrayList

		Private table_10500_fg As ArrayList

		Private table_11000_fg As ArrayList

		Private table_11500_fg As ArrayList

		Private table_12000_fg As ArrayList

		Private table_12500_fg As ArrayList

		Private table_13000_fg As ArrayList

		Private table_13500_fg As ArrayList

		Private table_14000_fg As ArrayList

		Private table_14500_fg As ArrayList

		Private table_15000_fg As ArrayList

		Private table_15500_fg As ArrayList

		Private table_16000_fg As ArrayList

		Private table_16500_fg As ArrayList

		Private table_17000_fg As ArrayList

		Private table_17500_fg As ArrayList

		Private table_18000_fg As ArrayList

		Private table_18500_fg As ArrayList

		Private table_19000_fg As ArrayList

		Private table_20000_fg As ArrayList

		Private table_1000_st As ArrayList

		Private table_1500_st As ArrayList

		Private table_2000_st As ArrayList

		Private table_2500_st As ArrayList

		Private table_3000_st As ArrayList

		Private table_3500_st As ArrayList

		Private table_4000_st As ArrayList

		Private table_4500_st As ArrayList

		Private table_5000_st As ArrayList

		Private table_5500_st As ArrayList

		Private table_6000_st As ArrayList

		Private table_6500_st As ArrayList

		Private table_7000_st As ArrayList

		Private table_7500_st As ArrayList

		Private table_8000_st As ArrayList

		Private table_8500_st As ArrayList

		Private table_9000_st As ArrayList

		Private table_9500_st As ArrayList

		Private table_10000_st As ArrayList

		Private table_10500_st As ArrayList

		Private table_11000_st As ArrayList

		Private table_11500_st As ArrayList

		Private table_12000_st As ArrayList

		Private table_12500_st As ArrayList

		Private table_13000_st As ArrayList

		Private table_13500_st As ArrayList

		Private table_14000_st As ArrayList

		Private table_14500_st As ArrayList

		Private table_15000_st As ArrayList

		Private table_15500_st As ArrayList

		Private table_16000_st As ArrayList

		Private table_16500_st As ArrayList

		Private table_17000_st As ArrayList

		Private table_17500_st As ArrayList

		Private table_18000_st As ArrayList

		Private table_18500_st As ArrayList

		Private table_19000_st As ArrayList

		Private table_19500_st As ArrayList

		Private table_20000_st As ArrayList

		<AccessedThroughProperty("dlgCBData")>
		Private _dlgCBData As dlgCBData

		Private mbFirstResize As Boolean

		Private miCBSource As PUData.CBSource

		Private UnitTypeInfoList As RSWIN_DESC.UnitTypeInfo()

		Private nUnitTypes As Short

		Private UnitData As RSWIN_DESC.PUDataRec()

		Private savedUnitID As String

		Private myKeyValueHT As Hashtable

		Private sDYWCustomPU As String

		Private MyParentFrm As RODSTAR

		Private $STATIC$GetCBALANCEData$2016102$CF_CBALANCE As Short

		Private $STATIC$cboCrankRotation_Click_1$202162$busy As Boolean

		Private $STATIC$optCBDataType_Click_1$2031888$busy As Integer

		Private Enum CBSource
			cbsUnknown
			cbsEntered
			cbsCBImport
			cbsCBDataFile
		End Enum
	End Class
End Namespace
