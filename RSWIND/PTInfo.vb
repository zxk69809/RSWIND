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
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Partial Class PTInfo
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

		Friend Overridable Property chkVSP As CheckBox
			Get
				Return Me._chkVSP
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkVSP_CheckedChanged
				If Me._chkVSP IsNot Nothing Then
					RemoveHandler Me._chkVSP.CheckedChanged, value2
				End If
				Me._chkVSP = value
				If Me._chkVSP IsNot Nothing Then
					AddHandler Me._chkVSP.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkInsertPump As CheckBox
			Get
				Return Me._chkInsertPump
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkInsertPump = value
			End Set
		End Property

		Friend Overridable Property chkTubingPump As CheckBox
			Get
				Return Me._chkTubingPump
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkTubingPump = value
			End Set
		End Property

		Friend Overridable Property chkLargeBorePump As CheckBox
			Get
				Return Me._chkLargeBorePump
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkLargeBorePump = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Enter, AddressOf Me.PTInfo_Enter
			AddHandler MyBase.Load, AddressOf Me.PTInfo_Load
			AddHandler MyBase.Validating, AddressOf Me.PTInfo_Validating
			AddHandler MyBase.Activated, AddressOf Me.PTInfo_Activated
			AddHandler MyBase.Closing, AddressOf Me.PTInfo_Closing
			AddHandler MyBase.Closed, AddressOf Me.PTInfo_Closed
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.PTInfo_MouseDoubleClick
			AddHandler MyBase.MouseDown, AddressOf Me.PTInfo_MouseDown
			AddHandler MyBase.MouseEnter, AddressOf Me.PTInfo_MouseEnter
			AddHandler MyBase.MouseMove, AddressOf Me.PTInfo_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.PTInfo_MouseUp
			AddHandler MyBase.MouseWheel, AddressOf Me.PTInfo_MouseWheel
			AddHandler MyBase.Move, AddressOf Me.PTInfo_Move
			AddHandler MyBase.Scroll, AddressOf Me.PTInfo_Scroll
			AddHandler MyBase.KeyPress, AddressOf Me.PTInfo_KeyPress
			AddHandler MyBase.KeyUp, AddressOf Me.PTInfo_KeyUp
			AddHandler MyBase.DragDrop, AddressOf Me.PTInfo_DragDrop
			AddHandler MyBase.DragEnter, AddressOf Me.PTInfo_DragEnter
			AddHandler MyBase.FormClosed, AddressOf Me.PTInfo_FormClosed
			AddHandler MyBase.FormClosing, AddressOf Me.PTInfo_FormClosing
			AddHandler MyBase.LostFocus, AddressOf Me.PTInfo_LostFocus
			AddHandler MyBase.GotFocus, AddressOf Me.PTInfo_GotFocus
			Me.sPumpDepthLess = Util.AssignValueToConstant("PTInfo", "sPumpDepthLess", "To include fluid iertia effects, the pump depth must be less than 4,250 feet (1,394 m), and the plunger size must be at least 2 inches (5.08).")
			Me.sSlideFriction = Util.AssignValueToConstant("PTInfo", "sSlideFriction", "Sliding friction coefficient must be between .2 (steel on steel) and .35 (guided)")
			Me.sDownStrokeFriction = Util.AssignValueToConstant("PTInfo", "sDownStrokeFriction", "Downstroke rod-tubing friction:")
			Me.sUpStrokeFriction = Util.AssignValueToConstant("PTInfo", "sUpStrokeFriction", "Upstroke rod-tubing friction:")
			Me.m_bClosing = False
			Me.m_bValidated = False
			Me.m_bFormLoaded = False
			Me.m_bLeavingForm = False
			Me.myKeyValueHT = New Hashtable()
			If PTInfo.m_vb6FormDefInstance Is Nothing Then
				If PTInfo.m_InitializingDefInstance Then
					PTInfo.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							PTInfo.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
			Me.Text = "Pump And Tubing Information"
		End Sub

		Friend Overridable Property pnlPTInfo As Panel
			Get
				Return Me._pnlPTInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlPTInfo = value
			End Set
		End Property

		Public Overridable Property txtTubingOD As TextBox
			Get
				Return Me._txtTubingOD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTubingOD_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtTubingOD_Enter
				Dim value4 As EventHandler = AddressOf Me.txtTubingOD_Leave
				Dim value5 As KeyEventHandler = AddressOf Me.txtTubingOD_KeyDown
				If Me._txtTubingOD IsNot Nothing Then
					RemoveHandler Me._txtTubingOD.TextChanged, value2
					RemoveHandler Me._txtTubingOD.Enter, value3
					RemoveHandler Me._txtTubingOD.Leave, value4
					RemoveHandler Me._txtTubingOD.KeyDown, value5
				End If
				Me._txtTubingOD = value
				If Me._txtTubingOD IsNot Nothing Then
					AddHandler Me._txtTubingOD.TextChanged, value2
					AddHandler Me._txtTubingOD.Enter, value3
					AddHandler Me._txtTubingOD.Leave, value4
					AddHandler Me._txtTubingOD.KeyDown, value5
				End If
			End Set
		End Property

		Public Overridable Property txtTubingID As TextBox
			Get
				Return Me._txtTubingID
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTubingID_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtTubingID_Enter
				Dim value4 As EventHandler = AddressOf Me.txtTubingID_Leave
				Dim value5 As KeyEventHandler = AddressOf Me.txtTubingID_KeyDown
				If Me._txtTubingID IsNot Nothing Then
					RemoveHandler Me._txtTubingID.TextChanged, value2
					RemoveHandler Me._txtTubingID.Enter, value3
					RemoveHandler Me._txtTubingID.Leave, value4
					RemoveHandler Me._txtTubingID.KeyDown, value5
				End If
				Me._txtTubingID = value
				If Me._txtTubingID IsNot Nothing Then
					AddHandler Me._txtTubingID.TextChanged, value2
					AddHandler Me._txtTubingID.Enter, value3
					AddHandler Me._txtTubingID.Leave, value4
					AddHandler Me._txtTubingID.KeyDown, value5
				End If
			End Set
		End Property

		Public Overridable Property cboTubingOD As ComboBox
			Get
				Return Me._cboTubingOD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboTubingOD_Leave
				Dim value3 As EventHandler = AddressOf Me.cboTubingOD_Enter
				Dim value4 As EventHandler = AddressOf Me.cboTubingOD_SelectedIndexChanged
				If Me._cboTubingOD IsNot Nothing Then
					RemoveHandler Me._cboTubingOD.Leave, value2
					RemoveHandler Me._cboTubingOD.Enter, value3
					RemoveHandler Me._cboTubingOD.SelectedIndexChanged, value4
				End If
				Me._cboTubingOD = value
				If Me._cboTubingOD IsNot Nothing Then
					AddHandler Me._cboTubingOD.Leave, value2
					AddHandler Me._cboTubingOD.Enter, value3
					AddHandler Me._cboTubingOD.SelectedIndexChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property txtTubingAnchorDepth As TextBox
			Get
				Return Me._txtTubingAnchorDepth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTubingAnchorDepth_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.txtTubingAnchorDepth_TextChanged
				Dim value4 As EventHandler = AddressOf Me.txtTubingAnchorDepth_Enter
				Dim value5 As EventHandler = AddressOf Me.txtTubingAnchorDepth_Leave
				Dim value6 As KeyEventHandler = AddressOf Me.txtTubingAnchorDepth_KeyDown
				If Me._txtTubingAnchorDepth IsNot Nothing Then
					RemoveHandler Me._txtTubingAnchorDepth.EnabledChanged, value2
					RemoveHandler Me._txtTubingAnchorDepth.TextChanged, value3
					RemoveHandler Me._txtTubingAnchorDepth.Enter, value4
					RemoveHandler Me._txtTubingAnchorDepth.Leave, value5
					RemoveHandler Me._txtTubingAnchorDepth.KeyDown, value6
				End If
				Me._txtTubingAnchorDepth = value
				If Me._txtTubingAnchorDepth IsNot Nothing Then
					AddHandler Me._txtTubingAnchorDepth.EnabledChanged, value2
					AddHandler Me._txtTubingAnchorDepth.TextChanged, value3
					AddHandler Me._txtTubingAnchorDepth.Enter, value4
					AddHandler Me._txtTubingAnchorDepth.Leave, value5
					AddHandler Me._txtTubingAnchorDepth.KeyDown, value6
				End If
			End Set
		End Property

		Public Overridable Property chkTubingAnchored As CheckBox
			Get
				Return Me._chkTubingAnchored
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkTubingAnchored_CheckedChanged
				If Me._chkTubingAnchored IsNot Nothing Then
					RemoveHandler Me._chkTubingAnchored.CheckedChanged, value2
				End If
				Me._chkTubingAnchored = value
				If Me._chkTubingAnchored IsNot Nothing Then
					AddHandler Me._chkTubingAnchored.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtPlungerSize As TextBox
			Get
				Return Me._txtPlungerSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtPlungerSize_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.txtPlungerSize_TextChanged
				Dim value4 As EventHandler = AddressOf Me.txtPlungerSize_Enter
				Dim value5 As EventHandler = AddressOf Me.txtPlungerSize_Leave
				Dim value6 As KeyEventHandler = AddressOf Me.txtPlungerSize_KeyDown
				If Me._txtPlungerSize IsNot Nothing Then
					RemoveHandler Me._txtPlungerSize.EnabledChanged, value2
					RemoveHandler Me._txtPlungerSize.TextChanged, value3
					RemoveHandler Me._txtPlungerSize.Enter, value4
					RemoveHandler Me._txtPlungerSize.Leave, value5
					RemoveHandler Me._txtPlungerSize.KeyDown, value6
				End If
				Me._txtPlungerSize = value
				If Me._txtPlungerSize IsNot Nothing Then
					AddHandler Me._txtPlungerSize.EnabledChanged, value2
					AddHandler Me._txtPlungerSize.TextChanged, value3
					AddHandler Me._txtPlungerSize.Enter, value4
					AddHandler Me._txtPlungerSize.Leave, value5
					AddHandler Me._txtPlungerSize.KeyDown, value6
				End If
			End Set
		End Property

		Public Overridable Property cboPlungerSize As ComboBox
			Get
				Return Me._cboPlungerSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboPlungerSize_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.cboPlungerSize_Click1
				Dim value4 As EventHandler = AddressOf Me.cboPlungerSize_Leave
				Dim value5 As EventHandler = AddressOf Me.cboPlungerSize_Enter
				Dim value6 As EventHandler = AddressOf Me.cboPlungerSize_Click
				Dim value7 As EventHandler = AddressOf Me.cboPlungerSize_SelectedIndexChanged
				If Me._cboPlungerSize IsNot Nothing Then
					RemoveHandler Me._cboPlungerSize.EnabledChanged, value2
					RemoveHandler Me._cboPlungerSize.Click, value3
					RemoveHandler Me._cboPlungerSize.Leave, value4
					RemoveHandler Me._cboPlungerSize.Enter, value5
					RemoveHandler Me._cboPlungerSize.SelectedIndexChanged, value6
					RemoveHandler Me._cboPlungerSize.SelectedIndexChanged, value7
				End If
				Me._cboPlungerSize = value
				If Me._cboPlungerSize IsNot Nothing Then
					AddHandler Me._cboPlungerSize.EnabledChanged, value2
					AddHandler Me._cboPlungerSize.Click, value3
					AddHandler Me._cboPlungerSize.Leave, value4
					AddHandler Me._cboPlungerSize.Enter, value5
					AddHandler Me._cboPlungerSize.SelectedIndexChanged, value6
					AddHandler Me._cboPlungerSize.SelectedIndexChanged, value7
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

		Public Overridable Property _linSeparator_2 As Label
			Get
				Return Me.__linSeparator_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linSeparator_2 = value
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

		Public Overridable Property chkIncludeBuoyancy As CheckBox
			Get
				Return Me._chkIncludeBuoyancy
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkIncludeBuoyancy_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.chkIncludeBuoyancy_CheckedChanged
				If Me._chkIncludeBuoyancy IsNot Nothing Then
					RemoveHandler Me._chkIncludeBuoyancy.EnabledChanged, value2
					RemoveHandler Me._chkIncludeBuoyancy.CheckedChanged, value3
				End If
				Me._chkIncludeBuoyancy = value
				If Me._chkIncludeBuoyancy IsNot Nothing Then
					AddHandler Me._chkIncludeBuoyancy.EnabledChanged, value2
					AddHandler Me._chkIncludeBuoyancy.CheckedChanged, value3
				End If
			End Set
		End Property

		Public Overridable Property optPumpType_1 As RadioButton
			Get
				Return Me._optPumpType_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optPumpType_1_CheckedChanged
				If Me._optPumpType_1 IsNot Nothing Then
					RemoveHandler Me._optPumpType_1.CheckedChanged, value2
				End If
				Me._optPumpType_1 = value
				If Me._optPumpType_1 IsNot Nothing Then
					AddHandler Me._optPumpType_1.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property optPumpType_2 As RadioButton
			Get
				Return Me._optPumpType_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optPumpType_2_CheckedChanged
				If Me._optPumpType_2 IsNot Nothing Then
					RemoveHandler Me._optPumpType_2.CheckedChanged, value2
				End If
				Me._optPumpType_2 = value
				If Me._optPumpType_2 IsNot Nothing Then
					AddHandler Me._optPumpType_2.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property optPumpType_3 As RadioButton
			Get
				Return Me._optPumpType_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optPumpType_3_CheckedChanged
				If Me._optPumpType_3 IsNot Nothing Then
					RemoveHandler Me._optPumpType_3.CheckedChanged, value2
				End If
				Me._optPumpType_3 = value
				If Me._optPumpType_3 IsNot Nothing Then
					AddHandler Me._optPumpType_3.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _Label_TubingID As Label
			Get
				Return Me.__Label_TubingID
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_TubingID = value
			End Set
		End Property

		Public Overridable Property _Label_TubingOD As Label
			Get
				Return Me.__Label_TubingOD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_TubingOD = value
			End Set
		End Property

		Public Overridable Property _Label_TubingAnchorDepth As Label
			Get
				Return Me.__Label_TubingAnchorDepth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_TubingAnchorDepth = value
			End Set
		End Property

		Public Overridable Property _Label_PlungerSize As Label
			Get
				Return Me.__Label_PlungerSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_PlungerSize = value
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

		Public Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Public Overridable Property Label2 As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Public Overridable Property Label3 As Label
			Get
				Return Me._Label3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		Public Overridable Property chkCalcPlungerSize As CheckBox
			Get
				Return Me._chkCalcPlungerSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkCalcPlungerSize_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.chkCalcPlungerSize_Click
				Dim value4 As EventHandler = AddressOf Me.chkCalcPlungerSize_CheckedChanged
				If Me._chkCalcPlungerSize IsNot Nothing Then
					RemoveHandler Me._chkCalcPlungerSize.EnabledChanged, value2
					RemoveHandler Me._chkCalcPlungerSize.Click, value3
					RemoveHandler Me._chkCalcPlungerSize.CheckedChanged, value4
				End If
				Me._chkCalcPlungerSize = value
				If Me._chkCalcPlungerSize IsNot Nothing Then
					AddHandler Me._chkCalcPlungerSize.EnabledChanged, value2
					AddHandler Me._chkCalcPlungerSize.Click, value3
					AddHandler Me._chkCalcPlungerSize.CheckedChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property chkIncludeFluidInertia As CheckBox
			Get
				Return Me._chkIncludeFluidInertia
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkIncludeFluidInertia_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.chkIncludeFluidInertia_Click
				Dim value4 As EventHandler = AddressOf Me.chkIncludeFluidInertia_CheckedChanged
				If Me._chkIncludeFluidInertia IsNot Nothing Then
					RemoveHandler Me._chkIncludeFluidInertia.EnabledChanged, value2
					RemoveHandler Me._chkIncludeFluidInertia.Click, value3
					RemoveHandler Me._chkIncludeFluidInertia.CheckedChanged, value4
				End If
				Me._chkIncludeFluidInertia = value
				If Me._chkIncludeFluidInertia IsNot Nothing Then
					AddHandler Me._chkIncludeFluidInertia.EnabledChanged, value2
					AddHandler Me._chkIncludeFluidInertia.Click, value3
					AddHandler Me._chkIncludeFluidInertia.CheckedChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property txtCompressibilityIndex As TextBox
			Get
				Return Me._txtCompressibilityIndex
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtCompressibilityIndex_Leave
				Dim value3 As EventHandler = AddressOf Me.txtCompressibilityIndex_TextChanged
				Dim value4 As EventHandler = AddressOf Me.txtCompressibilityIndex_EnabledChanged
				If Me._txtCompressibilityIndex IsNot Nothing Then
					RemoveHandler Me._txtCompressibilityIndex.Leave, value2
					RemoveHandler Me._txtCompressibilityIndex.TextChanged, value3
					RemoveHandler Me._txtCompressibilityIndex.EnabledChanged, value4
				End If
				Me._txtCompressibilityIndex = value
				If Me._txtCompressibilityIndex IsNot Nothing Then
					AddHandler Me._txtCompressibilityIndex.Leave, value2
					AddHandler Me._txtCompressibilityIndex.TextChanged, value3
					AddHandler Me._txtCompressibilityIndex.EnabledChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property txtDownstrokeFriction As TextBox
			Get
				Return Me._txtDownstrokeFriction
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtDownstrokeFriction_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtDownstrokeFriction_EnabledChanged
				Dim value4 As EventHandler = AddressOf Me.txtDownstrokeFriction_Enter
				Dim value5 As EventHandler = AddressOf Me.txtDownstrokeFriction_Leave
				If Me._txtDownstrokeFriction IsNot Nothing Then
					RemoveHandler Me._txtDownstrokeFriction.TextChanged, value2
					RemoveHandler Me._txtDownstrokeFriction.EnabledChanged, value3
					RemoveHandler Me._txtDownstrokeFriction.Enter, value4
					RemoveHandler Me._txtDownstrokeFriction.Leave, value5
				End If
				Me._txtDownstrokeFriction = value
				If Me._txtDownstrokeFriction IsNot Nothing Then
					AddHandler Me._txtDownstrokeFriction.TextChanged, value2
					AddHandler Me._txtDownstrokeFriction.EnabledChanged, value3
					AddHandler Me._txtDownstrokeFriction.Enter, value4
					AddHandler Me._txtDownstrokeFriction.Leave, value5
				End If
			End Set
		End Property

		Public Overridable Property txtUpstrokeFriction As TextBox
			Get
				Return Me._txtUpstrokeFriction
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtUpstrokeFriction_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtUpstrokeFriction_EnabledChanged
				Dim value4 As EventHandler = AddressOf Me.txtUpstrokeFriction_Enter
				Dim value5 As EventHandler = AddressOf Me.txtUpstrokeFriction_Leave
				If Me._txtUpstrokeFriction IsNot Nothing Then
					RemoveHandler Me._txtUpstrokeFriction.TextChanged, value2
					RemoveHandler Me._txtUpstrokeFriction.EnabledChanged, value3
					RemoveHandler Me._txtUpstrokeFriction.Enter, value4
					RemoveHandler Me._txtUpstrokeFriction.Leave, value5
				End If
				Me._txtUpstrokeFriction = value
				If Me._txtUpstrokeFriction IsNot Nothing Then
					AddHandler Me._txtUpstrokeFriction.TextChanged, value2
					AddHandler Me._txtUpstrokeFriction.EnabledChanged, value3
					AddHandler Me._txtUpstrokeFriction.Enter, value4
					AddHandler Me._txtUpstrokeFriction.Leave, value5
				End If
			End Set
		End Property

		Public Overridable Property txtPumpFriction As TextBox
			Get
				Return Me._txtPumpFriction
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.txtPumpFriction_KeyDown
				Dim value3 As EventHandler = AddressOf Me.txtPumpFriction_Enter
				Dim value4 As EventHandler = AddressOf Me.txtPumpFriction_Leave
				Dim value5 As EventHandler = AddressOf Me.txtPumpFriction_TextChanged
				If Me._txtPumpFriction IsNot Nothing Then
					RemoveHandler Me._txtPumpFriction.KeyDown, value2
					RemoveHandler Me._txtPumpFriction.Enter, value3
					RemoveHandler Me._txtPumpFriction.Leave, value4
					RemoveHandler Me._txtPumpFriction.TextChanged, value5
				End If
				Me._txtPumpFriction = value
				If Me._txtPumpFriction IsNot Nothing Then
					AddHandler Me._txtPumpFriction.KeyDown, value2
					AddHandler Me._txtPumpFriction.Enter, value3
					AddHandler Me._txtPumpFriction.Leave, value4
					AddHandler Me._txtPumpFriction.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property Label4 As Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		Public Overridable Property txtSlideFricCoeff As TextBox
			Get
				Return Me._txtSlideFricCoeff
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtSlideFricCoeff_Enter
				Dim value3 As EventHandler = AddressOf Me.txtSlideFricCoeff_Leave
				Dim value4 As EventHandler = AddressOf Me.txtSlideFricCoeff_TextChanged
				If Me._txtSlideFricCoeff IsNot Nothing Then
					RemoveHandler Me._txtSlideFricCoeff.Enter, value2
					RemoveHandler Me._txtSlideFricCoeff.Leave, value3
					RemoveHandler Me._txtSlideFricCoeff.TextChanged, value4
				End If
				Me._txtSlideFricCoeff = value
				If Me._txtSlideFricCoeff IsNot Nothing Then
					AddHandler Me._txtSlideFricCoeff.Enter, value2
					AddHandler Me._txtSlideFricCoeff.Leave, value3
					AddHandler Me._txtSlideFricCoeff.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property _Label_UpstrokeFriction As Label
			Get
				Return Me.__Label_UpstrokeFriction
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_UpstrokeFriction = value
			End Set
		End Property

		Public Overridable Property _Label_DownstrokeFriction As Label
			Get
				Return Me.__Label_DownstrokeFriction
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_DownstrokeFriction = value
			End Set
		End Property

		Public Overridable Property _Label_PumpFriction As Label
			Get
				Return Me.__Label_PumpFriction
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_PumpFriction = value
			End Set
		End Property

		Public Overridable Property _Label_SlideFricCoeff As Label
			Get
				Return Me.__Label_SlideFricCoeff
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_SlideFricCoeff = value
			End Set
		End Property

		Friend Overridable Property chkCalcFriction As CheckBox
			Get
				Return Me._chkCalcFriction
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkCalcFriction_CheckedChanged
				If Me._chkCalcFriction IsNot Nothing Then
					RemoveHandler Me._chkCalcFriction.CheckedChanged, value2
				End If
				Me._chkCalcFriction = value
				If Me._chkCalcFriction IsNot Nothing Then
					AddHandler Me._chkCalcFriction.CheckedChanged, value2
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

		Public Overridable Property _Label_CompressIndex As Label
			Get
				Return Me.__Label_CompressIndex
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_CompressIndex = value
			End Set
		End Property

		Public Overridable Property _Label_TubingSize As Label
			Get
				Return Me.__Label_TubingSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_TubingSize = value
			End Set
		End Property

		Public Overridable Property _Label_Plunger_Size As Label
			Get
				Return Me.__Label_Plunger_Size
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_Plunger_Size = value
			End Set
		End Property

		Public Overridable Property _Label_PumpType As Label
			Get
				Return Me.__Label_PumpType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_PumpType = value
			End Set
		End Property

		Friend Overridable Property lblTubingAnchorDepth_Disabled As Label
			Get
				Return Me._lblTubingAnchorDepth_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTubingAnchorDepth_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblUpstrokeFriction_Disabled As Label
			Get
				Return Me._lblUpstrokeFriction_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblUpstrokeFriction_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblDownstrokeFriction_Disabled As Label
			Get
				Return Me._lblDownstrokeFriction_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDownstrokeFriction_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblCompressibilityIndex_Disabled As Label
			Get
				Return Me._lblCompressibilityIndex_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCompressibilityIndex_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblPlungerSize_Disabled As Label
			Get
				Return Me._lblPlungerSize_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPlungerSize_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblcboPlungerSize_Disabled As Label
			Get
				Return Me._lblcboPlungerSize_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblcboPlungerSize_Disabled = value
			End Set
		End Property

		Friend Overridable Property chkUseExpertTubingSizePreferences As CheckBox
			Get
				Return Me._chkUseExpertTubingSizePreferences
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkUseExpertTubingSizePreferences = value
			End Set
		End Property

		Friend Overridable Property chkUseRODSTARPumpTypeRecommendation As CheckBox
			Get
				Return Me._chkUseRODSTARPumpTypeRecommendation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkUseRODSTARPumpTypeRecommendation = value
			End Set
		End Property

		Friend Overridable Property chkUseExpertTubingAnchored As CheckBox
			Get
				Return Me._chkUseExpertTubingAnchored
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkUseExpertTubingAnchored = value
			End Set
		End Property

		Public Shared Property DefInstance As PTInfo
			Get
				If PTInfo.m_vb6FormDefInstance Is Nothing OrElse PTInfo.m_vb6FormDefInstance.IsDisposed Then
					PTInfo.m_InitializingDefInstance = True
					PTInfo.m_vb6FormDefInstance = New PTInfo()
					PTInfo.m_InitializingDefInstance = False
				End If
				Return PTInfo.m_vb6FormDefInstance
			End Get
			Set(value As PTInfo)
				PTInfo.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub PTInfo_Enter(sender As Object, e As EventArgs)
			Try
				If Me.WindowState = FormWindowState.Maximized Then
					Me.WindowState = FormWindowState.Normal
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PTInfo_Load(sender As Object, e As EventArgs)
			SUPERPRO.NewCheckSentinel(True)
			Me.GetMeasurementUnit()
			Me.ResetClock()
			Me.m_bFormLoaded = True
			Me.m_bClosing = False
			RSWIN_DESC.sCurrentFormName = "PTInfo"
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
			Me.PTInfoLoad()
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				Me.chkIncludeBuoyancy.Checked = False
				Me.chkIncludeBuoyancy.Enabled = False
				Me.chkCalcFriction.Checked = True
				Me.chkCalcFriction.Enabled = False
				Me.chkCalcPlungerSize.Checked = True
				Me.chkCalcPlungerSize.Enabled = False
				Me.chkIncludeFluidInertia.Checked = False
				Me.chkIncludeFluidInertia.Enabled = False
				Me.optPumpType_1.Visible = False
				Me.optPumpType_2.Visible = False
				Me.optPumpType_3.Visible = False
				If RSWIN_DESC.SETUP_bRodstarPumpType Then
					Me.optPumpType_1.Enabled = False
					Me.optPumpType_1.Checked = False
					Me.optPumpType_2.Enabled = False
					Me.optPumpType_2.Checked = False
					Me.optPumpType_3.Enabled = False
					Me.optPumpType_3.Checked = False
					Me._Label_PumpType.Enabled = False
					Me.chkUseRODSTARPumpTypeRecommendation.Visible = True
					Me.chkUseRODSTARPumpTypeRecommendation.Checked = True
					Me.chkInsertPump.Checked = False
					Me.chkInsertPump.Enabled = False
					Me.chkInsertPump.Visible = True
					Me.chkTubingPump.Checked = False
					Me.chkTubingPump.Enabled = False
					Me.chkTubingPump.Visible = True
					Me.chkLargeBorePump.Checked = False
					Me.chkLargeBorePump.Enabled = False
					Me.chkLargeBorePump.Visible = True
				Else
					Me.chkInsertPump.Checked = RSWIN_DESC.bInsertPump
					Me.chkInsertPump.Enabled = False
					Me.chkInsertPump.Visible = True
					Me.chkTubingPump.Checked = RSWIN_DESC.bTubingPump
					Me.chkTubingPump.Enabled = False
					Me.chkTubingPump.Visible = True
					Me.chkLargeBorePump.Checked = RSWIN_DESC.bLargeBorePump
					Me.chkLargeBorePump.Enabled = False
					Me.chkLargeBorePump.Visible = True
					Me._Label_PumpType.Enabled = False
					Me.chkUseRODSTARPumpTypeRecommendation.Visible = True
					Me.chkUseRODSTARPumpTypeRecommendation.Checked = False
				End If
				Me._Label_TubingSize.Visible = False
				Me._Label_TubingOD.Visible = False
				Me._Label_TubingID.Visible = False
				Me.cboTubingOD.Visible = False
				Me.txtTubingOD.Visible = False
				Me.txtTubingID.Visible = False
				Me.chkUseExpertTubingSizePreferences.Visible = True
				Me.chkUseExpertTubingSizePreferences.Checked = True
				If RSWIN_DESC.SETUP_bRodstarTubingAnchored Then
					Me.chkUseExpertTubingAnchored.Visible = True
					Me.chkUseExpertTubingAnchored.Checked = True
					Me.chkUseExpertTubingAnchored.BringToFront()
					Me.chkTubingAnchored.Visible = False
					Me._Label_TubingAnchorDepth.Visible = False
					Me.lblTubingAnchorDepth_Disabled.Visible = False
					Me.txtTubingAnchorDepth.Visible = False
				Else
					Me.chkUseExpertTubingAnchored.Visible = False
					Me.chkUseExpertTubingAnchored.Checked = False
					Me.chkUseExpertTubingAnchored.SendToBack()
					Me.chkTubingAnchored.Visible = True
					Me._Label_TubingAnchorDepth.Visible = True
					Me.lblTubingAnchorDepth_Disabled.Visible = True
					Me.txtTubingAnchorDepth.Visible = True
					Me.chkTubingAnchored.Checked = RSWIN_DESC.SETUP_bTubingAnchored
				End If
			Else
				Me.chkUseExpertTubingSizePreferences.Visible = False
				Me.chkUseExpertTubingSizePreferences.Checked = False
				Me.chkUseRODSTARPumpTypeRecommendation.Visible = False
				Me.chkUseRODSTARPumpTypeRecommendation.Checked = False
				Me.chkInsertPump.Enabled = False
				Me.chkInsertPump.Visible = False
				Me.chkTubingPump.Enabled = False
				Me.chkTubingPump.Visible = False
				Me.chkLargeBorePump.Enabled = False
				Me.chkLargeBorePump.Visible = False
				Me.optPumpType_1.Visible = True
				Me.optPumpType_2.Visible = True
				Me.optPumpType_3.Visible = True
				Me.chkUseExpertTubingAnchored.Visible = False
				Me.chkUseExpertTubingAnchored.Checked = False
				Me.chkUseExpertTubingAnchored.SendToBack()
				Me.chkTubingAnchored.Visible = True
				Me._Label_TubingAnchorDepth.Visible = True
				Me.lblTubingAnchorDepth_Disabled.Visible = True
				Me.txtTubingAnchorDepth.Visible = True
			End If
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
			End If
			Me.m_bFormLoaded = False
			Me.CenterForm()
		End Sub

		Private Sub PTInfoLoad()
			Dim text As String = ""
			Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			Try
				RSWIN_DESC.bCheckPlunger = True
				Try
					If RSWIN_DESC.bRodStarD Then
						Me.chkCalcFriction.Visible = False
						Me.chkCalcFriction.Checked = False
					Else
						Me.chkCalcFriction.Visible = True
					End If
					If RSWIN_DESC.NewData(3) <> 0S Then
						Dim text2 As String = "IncludeBuoyancy"
						Dim text3 As String = ""
						Dim num As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, text3, text, False))
						Dim text4 As String = text.Substring(0, CInt(num))
						Dim checked As Boolean
						If num = 0S Then
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("IncludeBuoyancy", 11, False, DBNull.Value))
							If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
								objectValue = RuntimeHelpers.GetObjectValue(ini.GetListDefault("IncludeBuoyancy", 0, 1))
								If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
									RSWIN_DESC.rst.gbIncludeBuoyancy = Operators.ConditionalCompareObjectEqual(objectValue, 0, False)
								Else
									RSWIN_DESC.rst.gbIncludeBuoyancy = False
								End If
							End If
						Else
							checked = (Operators.CompareString(text4.Trim(), "0", False) = 0 OrElse (Operators.CompareString(text4.Trim(), "1", False) = 0 AndAlso False))
						End If
						Me.chkIncludeBuoyancy.Checked = checked
					Else
						Me.chkIncludeBuoyancy.Checked = RSWIN_DESC.rst.gbIncludeBuoyancy
					End If
				Catch ex As Exception
				End Try
				If RSWIN_DESC.bRodStarD Then
					Me.chkCalcFriction.Checked = False
				Else
					Me._Label_DownstrokeFriction.Text = Me.sDownStrokeFriction
					Me._Label_UpstrokeFriction.Text = Me.sUpStrokeFriction
					Me.chkCalcFriction.Checked = (RSWIN_DESC.rst.CalcFriction <> 0S)
				End If
				Me.chkCalcPlungerSize.Checked = (RSWIN_DESC.rst.CalcPlungerSize <> 0S)
				Me.LoadTubingSizeList()
				Me.LoadPlungerSizeList()
				If RSWIN_DESC.rst IsNot Nothing Then
					If Operators.CompareString(RSWIN_DESC.rst.Inputfile, "", False) = 0 Or Operators.CompareString(RSWIN_DESC.rst.Inputfile, "(Untitled)", False) = 0 Then
						Me.InitPTInfo()
					Else
						Me.LoadPTInfo()
					End If
				End If
			Catch ex2 As Exception
				Dim sMsg As String = "Error in Load PTInfo: " + ex2.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub InitPTInfo()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TubingOD", 4, False, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				rst.TubingOD = -1F
			Else
				rst.TubingOD = Conversions.ToSingle(obj)
				Me.txtTubingOD.Tag = "mem"
				Dim txtTubingOD As TextBox = Me.txtTubingOD
				Dim num As Single = rst.TubingOD
				txtTubingOD.Text = num.ToString()
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TubingID", 4, False, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				rst.TubingID = -1F
			Else
				rst.TubingID = Conversions.ToSingle(obj)
				Me.txtTubingID.Tag = "mem"
				Dim txtTubingID As TextBox = Me.txtTubingID
				Dim num As Single = rst.TubingID
				txtTubingID.Text = num.ToString()
			End If
			If rst.TubingOD < 0F And rst.TubingID < 0F Then
				obj = RuntimeHelpers.GetObjectValue(ini.GetListDefault("TubingSize", 0, Me.cboTubingOD.Items.Count - 1))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					Me.cboTubingOD.SelectedIndex = Conversions.ToInteger(obj)
				Else
					Dim num2 As Short = 0S
					Dim num3 As Short = CShort((Me.cboTubingOD.Items.Count - 1))

						For num4 As Short = num2 To num3
							If Strings.InStr(Conversions.ToString(Me.cboTubingOD.Items(CInt(num4))), "2 7/8", CompareMethod.Binary) = 1 Then
								Me.cboTubingOD.SelectedIndex = CInt(num4)
								Exit For
							End If
						Next

				End If
			Else
				Dim array As String() = New String(0) {}
				Dim array2 As String() = New String(0) {}
				Dim num5 As Short
				Util.LoadMenu("TUBING-ID", num5, array2)
				Util.LoadMenu("TUBING-OD", num5, array)
				Me.cboTubingOD.SelectedIndex = Me.cboTubingOD.Items.Count - 1
				Dim num6 As Short = 1S
				Dim num7 As Short = num5

					For num4 As Short = num6 To num7
						If Math.Abs(CDbl(rst.TubingOD) - Conversion.Val(array(CInt(num4)))) < 0.0001 And Math.Abs(CDbl(rst.TubingID) - Conversion.Val(array2(CInt(num4)))) < 0.0001 Then
							' The following expression was wrapped in a checked-expression
							Me.cboTubingOD.SelectedIndex = CInt((num4 - 1S))
							Exit For
						End If
					Next

			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpType", 3, False, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				obj = RuntimeHelpers.GetObjectValue(ini.GetListDefault("PumpType", 0, 2))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					obj = 1
				Else
					obj = Operators.AddObject(obj, 1)
				End If
			End If
			rst.VSP = False
			rst.PumpType = Conversions.ToShort(obj)
			Me.optPumpType_Click_1(rst.PumpType, -1S, False)
			If RSWIN_DESC.rst.SPMEntered <> 0S Then
				Me.chkCalcPlungerSize_Click_1(False, 0)
				Me.chkCalcPlungerSize.Enabled = False
				Me.cboPlungerSize.Visible = True
			Else
				Me.chkCalcPlungerSize.Enabled = True
				RSWIN_DESC.rst.CalcPlungerSize = Conversions.ToShort(ini.GetDataValue("CalcPlungerSize", 11, False, True))
				Me.chkCalcPlungerSize_Click_1(RSWIN_DESC.rst.CalcPlungerSize <> 0S, 0)
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PlungerSize", 4, False, DBNull.Value))
			Dim num As Single
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				obj = RuntimeHelpers.GetObjectValue(ini.GetListDefault("PlungerSize", 0, Me.cboPlungerSize.Items.Count - 1))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					Me.bPlungerSizeClicked = False
					Me.cboPlungerSize.SelectedIndex = Conversions.ToInteger(obj)
				Else
					Dim num8 As Short = 0S
					Dim num9 As Short = CShort((Me.cboPlungerSize.Items.Count - 1))

						For num4 As Short = num8 To num9
							If Conversion.Val(RuntimeHelpers.GetObjectValue(Me.cboPlungerSize.Items(CInt(num4)))) = 1.5 Then
								Me.bPlungerSizeClicked = False
								Me.cboPlungerSize.SelectedIndex = CInt(num4)
								Exit For
							End If
						Next

				End If
			Else
				rst.PlungerSize = Conversions.ToSingle(obj)
				Me.txtPlungerSize.Tag = "mem"
				Dim txtPlungerSize As TextBox = Me.txtPlungerSize
				num = rst.PlungerSize
				txtPlungerSize.Text = num.ToString()
				Me.bPlungerSizeClicked = False
				Me.cboPlungerSize.SelectedIndex = Me.cboPlungerSize.Items.Count - 1
				Dim num10 As Short = 0S
				Dim num11 As Short = CShort((Me.cboPlungerSize.Items.Count - 1))

					For num4 As Short = num10 To num11
						If CDbl(rst.PlungerSize) = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.cboPlungerSize.Items(CInt(num4)))) Then
							Me.bPlungerSizeClicked = False
							Me.cboPlungerSize.SelectedIndex = CInt(num4)
							Exit For
						End If
					Next

			End If
			rst.TubingAnchored = Conversions.ToShort(ini.GetDataValue("TubingAnchored", 11, False, RSWIN_DESC.rst.PumpDepth >= 3500F))
			Me.chkTubingAnchored.Checked = (rst.TubingAnchored <> 0S)
			Me.txtTubingAnchorDepth.Enabled = Me.chkTubingAnchored.Checked
			rst.TubingAnchorDepth = Conversions.ToSingle(ini.GetDataValue("TubingAnchorDepth", 4, False, rst.PumpDepth))
			If rst.PumpDepth = 0F Then
				obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpDepth", 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					rst.PumpDepth = Conversions.ToSingle(obj)
				End If
			End If
			If rst.TubingAnchorDepth > rst.PumpDepth Then
				rst.TubingAnchorDepth = rst.PumpDepth
			End If
			Me.txtTubingAnchorDepth.Tag = "fem"
			Dim txtTubingAnchorDepth As TextBox = Me.txtTubingAnchorDepth
			num = rst.TubingAnchorDepth
			txtTubingAnchorDepth.Text = num.ToString()
			If rst.TubingAnchored <> 0S Then
				Me.txtTubingAnchorDepth.Enabled = True
			Else
				Me.txtTubingAnchorDepth.Enabled = False
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("IncludeBuoyancy", 11, False, DBNull.Value))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				Me.chkIncludeBuoyancy_Click_1(Conversions.ToBoolean(obj), False)
			Else
				Me.chkIncludeBuoyancy_Click_1(False, False)
			End If
			If RSWIN_DESC.bRodStarD Then
				rst.gbCalcFriction = False
			Else
				obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("CalcFriction", 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					rst.gbCalcFriction = Conversions.ToBoolean(obj)
				Else
					rst.gbCalcFriction = True
				End If
			End If
			If RSWIN_DESC.bRodStarD Then
				rst.UpstrokeFriction = Conversions.ToSingle(ini.GetDataValue("UpstrokeFriction", 4, False, 0.1))
				rst.DownstrokeFriction = Conversions.ToSingle(ini.GetDataValue("DownstrokeFriction", 4, False, 0.1))
			Else
				rst.UpstrokeFriction = Conversions.ToSingle(ini.GetDataValue("UpstrokeFriction", 4, False, 1))
				rst.DownstrokeFriction = Conversions.ToSingle(ini.GetDataValue("DownstrokeFriction", 4, False, 1))
			End If
			Dim cRODSTAR As cRODSTAR
			Dim text As String
			If RSWIN_DESC.bRodStarD Then
				Dim txtUpstrokeFriction As TextBox = Me.txtUpstrokeFriction
				cRODSTAR = rst
				num = cRODSTAR.UpstrokeFriction
				text = "#0.0###"
				Dim text2 As String = Util.Format(num, text)
				cRODSTAR.UpstrokeFriction = num
				txtUpstrokeFriction.Text = text2
				Dim txtDownstrokeFriction As TextBox = Me.txtDownstrokeFriction
				cRODSTAR = rst
				num = cRODSTAR.DownstrokeFriction
				text = "#0.0###"
				Dim text3 As String = Util.Format(num, text)
				cRODSTAR.DownstrokeFriction = num
				txtDownstrokeFriction.Text = text3
			Else
				Dim txtUpstrokeFriction2 As TextBox = Me.txtUpstrokeFriction
				cRODSTAR = rst
				num = cRODSTAR.UpstrokeFriction
				text = "##0.0##"
				Dim text4 As String = Util.Format(num, text)
				cRODSTAR.UpstrokeFriction = num
				txtUpstrokeFriction2.Text = text4
				Dim txtDownstrokeFriction2 As TextBox = Me.txtDownstrokeFriction
				cRODSTAR = rst
				num = cRODSTAR.DownstrokeFriction
				text = "##0.0##"
				Dim text5 As String = Util.Format(num, text)
				cRODSTAR.DownstrokeFriction = num
				txtDownstrokeFriction2.Text = text5
			End If
			Me.txtUpstrokeFriction.Enabled = True
			Me.txtDownstrokeFriction.Enabled = True
			rst.PumpFriction = Conversions.ToSingle(ini.GetDataValue("PumpFriction", 4, True, 200))
			Dim txtPumpFriction As TextBox = Me.txtPumpFriction
			cRODSTAR = rst
			num = cRODSTAR.PumpFriction
			text = "###.###"
			Dim text6 As String = Util.Format(num, text)
			cRODSTAR.PumpFriction = num
			txtPumpFriction.Text = text6
			rst.IncludeFluidInertia = Conversions.ToShort(ini.GetDataValue("IncludeFluidInertia", 11, False, False))
			rst.CompressibilityIndex = Conversions.ToSingle(ini.GetDataValue("CompressibilityIndex", 4, True, 3))
			Me.chkIncludeFluidInertia_Click_1(rst.IncludeFluidInertia <> 0S, False)
			Me.txtCompressibilityIndex.Text = Conversions.ToString(rst.CompressibilityIndex)
			Dim flag As Boolean = Me.EnableFluidInertia()
			If Me.txtPlungerSize.Enabled Then
				Me.lblPlungerSize_Disabled.SendToBack()
			Else
				Me.lblPlungerSize_Disabled.BringToFront()
			End If
		End Sub

		Public Function EnableFluidInertia() As Boolean
			Dim flag As Boolean = MImpred.FluidInertiaPossible()
			Me.chkIncludeFluidInertia.Enabled = flag
			If Not flag Then
				RSWIN_DESC.rst.IncludeFluidInertia = 0S
			End If
			Return flag
		End Function

		Private Sub chkIncludeFluidInertia_Click_1(Checked As Boolean, Clicked As Boolean)
			Try
				If Me.chkIncludeFluidInertia.Checked And Not MImpred.FluidInertiaPossible() Then
					MessageBox.Show(Me.sPumpDepthLess)
					Me.chkIncludeFluidInertia.Checked = False
				End If
				If Clicked Then
					If Me.chkIncludeFluidInertia.Checked Then
						Me.txtCompressibilityIndex.Enabled = True
						RSWIN_DESC.rst.IncludeFluidInertia = -1S
					Else
						Me.txtCompressibilityIndex.Enabled = False
						RSWIN_DESC.rst.IncludeFluidInertia = 0S
					End If
				End If
				If Me.ActiveControl Is Me.chkIncludeFluidInertia AndAlso (If((-If((MImpred.FluidInertiaPossible() > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.rst.IncludeFluidInertia) <> 0S Then
					Dim text As String
					Util.LoadMessage(188, text)
					Dim msg As String = text
					Dim bDefaultYes As Boolean = True
					Dim flag As Boolean = False
					If Util.YesNo(msg, bDefaultYes, flag) Then
						Me.chkIncludeFluidInertia.Checked = True
						Me.txtCompressibilityIndex.Focus()
						Return
					End If
				End If
				ini.SaveDataValue("IncludeFluidInertia", RSWIN_DESC.rst.IncludeFluidInertia)
				Me.txtCompressibilityIndex.Enabled = (RSWIN_DESC.rst.IncludeFluidInertia <> 0S)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub LoadPTInfo()
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			Me.txtTubingOD.Tag = "mem"
			Me.txtTubingID.Tag = "mem"
			Dim txtTubingOD As TextBox = Me.txtTubingOD
			Dim num As Single = cRODSTAR.TubingOD
			txtTubingOD.Text = num.ToString()
			Dim txtTubingID As TextBox = Me.txtTubingID
			num = cRODSTAR.TubingID
			txtTubingID.Text = num.ToString()
			Dim array As String() = New String(0) {}
			Dim array2 As String() = New String(0) {}
			Dim sMenu As String = "TUBING-OD"
			Dim num3 As Integer
			Dim num2 As Short = CShort(num3)
			Util.LoadMenu(sMenu, num2, array)
			num3 = CInt(num2)
			Dim sMenu2 As String = "TUBING-ID"
			Dim num4 As Integer
			num2 = CShort(num4)
			Util.LoadMenu(sMenu2, num2, array2)
			num4 = CInt(num2)
			Me.cboTubingOD.SelectedIndex = Me.cboTubingOD.Items.Count - 1
			Dim num5 As Integer = 1
			Dim num6 As Integer = num3
			For i As Integer = num5 To num6
				' The following expression was wrapped in a unchecked-expression
				If Math.Abs(CDbl(cRODSTAR.TubingOD) - Conversion.Val(array(i))) < 0.0001 And Math.Abs(CDbl(cRODSTAR.TubingID) - Conversion.Val(array2(i))) < 0.0001 Then
					Me.cboTubingOD.SelectedIndex = i - 1
					Exit For
				End If
			Next
			Me.optPumpType_1.Checked = False
			Me.optPumpType_2.Checked = False
			Me.optPumpType_3.Checked = False
			Select Case cRODSTAR.PumpType
				Case 1S
					Me.optPumpType_1.Checked = True
				Case 2S
					Me.optPumpType_2.Checked = True
				Case 3S
					Me.optPumpType_3.Checked = True
			End Select
			Me.txtPlungerSize.Tag = "mem"
			Dim txtPlungerSize As TextBox = Me.txtPlungerSize
			num = cRODSTAR.PlungerSize
			txtPlungerSize.Text = num.ToString()
			Dim array3 As String() = New String(0) {}
			Dim sMenu3 As String = "PLUNGER-SIZE-LIST"
			Dim obj As Object
			num2 = Conversions.ToShort(obj)
			Util.LoadMenu(sMenu3, num2, array3)
			obj = num2
			Me.bPlungerSizeClicked = False
			Me.cboPlungerSize.SelectedIndex = Me.cboPlungerSize.Items.Count - 1
			Dim num7 As Integer = 1
			Dim num8 As Integer = Conversions.ToInteger(obj)
			For i As Integer = num7 To num8
				If CDbl(cRODSTAR.PlungerSize) = Conversion.Val(array3(i)) Then
					Me.cboPlungerSize.SelectedIndex = i - 1
					Exit For
				End If
			Next
			If Not RSWIN_DESC.rst.SPMEntered <> 0S Then
				If Not cRODSTAR.gbCalcTargetBFPD And cRODSTAR.TargetBFPD > 0F Then
					Me.chkCalcPlungerSize.Enabled = True
				End If
				Me.chkCalcPlungerSize_Click_1(RSWIN_DESC.rst.CalcPlungerSize <> 0S, 0)
			Else
				If RSWIN_DESC.rst.PlungerSize = 0F Then
					Me.cboPlungerSize.SelectedIndex = -1
					Me.cboPlungerSize.Focus()
				End If
				Me.chkCalcPlungerSize_Click_1(False, 0)
				Me.chkCalcPlungerSize.Enabled = False
			End If
			Try
				Me.chkTubingAnchored.Checked = (cRODSTAR.TubingAnchored <> 0S)
				Me.chkTubingAnchored_Click_1(cRODSTAR.TubingAnchored <> 0S, False)
				Me.txtTubingAnchorDepth.Tag = "fem"
				Dim txtTubingAnchorDepth As TextBox = Me.txtTubingAnchorDepth
				num = cRODSTAR.TubingAnchorDepth
				txtTubingAnchorDepth.Text = num.ToString()
			Catch ex As Exception
			End Try
			If RSWIN_DESC.bRodStarD Then
				Me.chkCalcFriction.Checked = False
			Else
				Me.chkCalcFriction.Checked = (cRODSTAR.CalcFriction <> 0S)
			End If
			Me.chkIncludeBuoyancy_Click_1(cRODSTAR.gbIncludeBuoyancy, False)
			Dim cRODSTAR2 As cRODSTAR
			Dim text As String
			If cRODSTAR.UpstrokeFriction <= 0F Then
				If RSWIN_DESC.bRodStarD Then
					Me.txtUpstrokeFriction.Text = "0.1"
				Else
					Me.txtUpstrokeFriction.Text = "1"
				End If
			ElseIf RSWIN_DESC.bRodStarD Then
				Dim txtUpstrokeFriction As TextBox = Me.txtUpstrokeFriction
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.UpstrokeFriction
				text = "#0.0###"
				Dim text2 As String = Util.Format(num, text)
				cRODSTAR2.UpstrokeFriction = num
				txtUpstrokeFriction.Text = text2
			Else
				Dim txtUpstrokeFriction2 As TextBox = Me.txtUpstrokeFriction
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.UpstrokeFriction
				text = "##0.0##"
				Dim text3 As String = Util.Format(num, text)
				cRODSTAR2.UpstrokeFriction = num
				txtUpstrokeFriction2.Text = text3
			End If
			Me.txtUpstrokeFriction.Enabled = True
			If cRODSTAR.DownstrokeFriction <= 0F Then
				If RSWIN_DESC.bRodStarD Then
					Me.txtDownstrokeFriction.Text = "0.1"
				Else
					Me.txtDownstrokeFriction.Text = "1"
				End If
			ElseIf RSWIN_DESC.bRodStarD Then
				Dim txtDownstrokeFriction As TextBox = Me.txtDownstrokeFriction
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.DownstrokeFriction
				text = "#0.0###"
				Dim text4 As String = Util.Format(num, text)
				cRODSTAR2.DownstrokeFriction = num
				txtDownstrokeFriction.Text = text4
			Else
				Dim txtDownstrokeFriction2 As TextBox = Me.txtDownstrokeFriction
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.DownstrokeFriction
				text = "##0.0##"
				Dim text5 As String = Util.Format(num, text)
				cRODSTAR2.DownstrokeFriction = num
				txtDownstrokeFriction2.Text = text5
			End If
			Me.txtDownstrokeFriction.Enabled = True
			If cRODSTAR.SlideFricCoeff <> 0F Then
				Me.txtSlideFricCoeff.Text = Convert.ToString(cRODSTAR.SlideFricCoeff)
			Else
				Me.txtSlideFricCoeff.Text = "0.30"
			End If
			Dim txtPumpFriction As TextBox = Me.txtPumpFriction
			cRODSTAR2 = cRODSTAR
			num = cRODSTAR2.PumpFriction
			text = "###.###"
			Dim text6 As String = Util.Format(num, text)
			cRODSTAR2.PumpFriction = num
			txtPumpFriction.Text = text6
			Me.chkIncludeBuoyancy_Click_1(cRODSTAR.gbIncludeBuoyancy, False)
			Dim flag As Boolean = Me.EnableFluidInertia()
			Me.chkIncludeFluidInertia.Checked = (cRODSTAR.IncludeFluidInertia <> 0S)
			If RSWIN_DESC.rst.IncludeFluidInertia <> 0S Then
				Me.chkIncludeFluidInertia.Enabled = True
				Me.txtCompressibilityIndex.Enabled = True
				Me.lblCompressibilityIndex_Disabled.SendToBack()
			Else
				Me.chkIncludeFluidInertia.Enabled = False
				Me.txtCompressibilityIndex.Enabled = False
				Me.lblCompressibilityIndex_Disabled.BringToFront()
			End If
			Dim txtCompressibilityIndex As TextBox = Me.txtCompressibilityIndex
			num = cRODSTAR.CompressibilityIndex
			txtCompressibilityIndex.Text = num.ToString()
			If Me.txtPlungerSize.Enabled Then
				Me.lblPlungerSize_Disabled.SendToBack()
			Else
				Me.lblPlungerSize_Disabled.BringToFront()
			End If
			cRODSTAR = Nothing
		End Sub

		Private Sub chkIncludeBuoyancy_Click_1(Checked As Boolean, Clicked As Boolean)
			Me.chkIncludeBuoyancy.Checked = Checked
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.gbIncludeBuoyancy = Checked
			ini.SaveDataValue("IncludeBuoyancy", rst.gbIncludeBuoyancy)
		End Sub

		Private Sub chkTubingAnchored_Click_1(Checked As Boolean, Clicked As Boolean)
			Me.chkTubingAnchored.Checked = Checked
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.TubingAnchored = If((-If((Checked > False), 1S, 0S)), 1S, 0S)
			ini.SaveDataValue("TubingAnchored", rst.TubingAnchored)
			Me.txtTubingAnchorDepth.Enabled = (rst.TubingAnchored <> 0S)
			If Checked Then
				Me.txtTubingAnchorDepth.Enabled = True
			Else
				Me.txtTubingAnchorDepth.Enabled = False
			End If
		End Sub

		Private Sub LoadPlungerSizeList()
			Me.LoadDiameterListFromMenu(Me.cboPlungerSize, "PLUNGER-SIZE-LIST", "PLUNGER-SIZE-LIST-METRIC")
			For i As Integer = Me.cboPlungerSize.Items.Count - 1 To 0 Step -1
				If Strings.Len(RuntimeHelpers.GetObjectValue(Me.cboPlungerSize.Items(i))) = 0 Then
					Me.cboPlungerSize.Items.Remove(RuntimeHelpers.GetObjectValue(Me.cboPlungerSize.Items(i)))
				End If
			Next
		End Sub

		Private Sub LoadTubingSizeList()
			Me.LoadDiameterListFromMenu(Me.cboTubingOD, "TUBING-SIZE", "TUBING-SIZE-METRIC")
			For i As Integer = Me.cboTubingOD.Items.Count - 1 To 0 Step -1
				If Strings.Len(RuntimeHelpers.GetObjectValue(Me.cboTubingOD.Items(i))) = 0 Then
					Me.cboTubingOD.Items.Remove(RuntimeHelpers.GetObjectValue(Me.cboTubingOD.Items(i)))
				End If
			Next
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

		Public Sub LoadDiameterListFromMenu(cbo As ComboBox, sMenu As String, sMenuMetric As String)
			Dim array As String() = New String(0) {}
			Dim num2 As Integer
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				Dim num As Short = CShort(num2)
				Util.LoadMenu(sMenu, num, array)
				num2 = CInt(num)
			Else
				Dim num As Short = CShort(num2)
				Util.LoadMenu(sMenuMetric, num, array)
				num2 = CInt(num)
				Dim num3 As Integer = 1
				Dim num4 As Integer = num2
				For i As Integer = num3 To num4
					Dim num5 As Integer = Strings.InStr(array(i), "(", CompareMethod.Binary)
					If num5 > 0 Then
						Dim num6 As Integer
						num6 = num5
						While num6 <> 1
							If Operators.CompareString(array(i).Substring(num6, 1), " ", False) <> 0 Then
								Exit While
							End If
							num6 -= 1
						End While
						If Operators.CompareString(array(i).Substring(num5 + 1, 1), " ", False) = 0 Then
							num5 += 1
							StringType.MidStmtStr(array(i), num5, 1, "(")
						End If
						array(i) = array(i).Substring(0, num6 - 1) + RSWIN_DESC.Chr9 + Strings.Mid(array(i), num5)
					End If
				Next
			End If
			cbo.Items.Clear()
			Dim num7 As Integer = 1
			Dim num8 As Integer = num2
			For i As Integer = num7 To num8
				cbo.Items.Add(array(i))
			Next
		End Sub

		Private Sub PTInfo_Validating(sender As Object, e As CancelEventArgs)
			Me.ValidatePTInfo(True)
		End Sub

		Public Function ValidatePTInfo(Optional bQuiet As Boolean = True) As Boolean
			Dim flag As Boolean = True
			Dim flag2 As Boolean = False
			If Me.MyParentFrm Is Nothing Then
				Try
					Me.MyParentFrm = New RODSTAR()
					Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
				Catch ex As Exception
				End Try
			End If
			If Me.MyParentFrm Is Nothing Then
				Return True
			End If
			If Not Me.MyParentFrm.bClosing Then
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim flag3 As Boolean = True
				If flag3 = Me.optPumpType_1.Checked Then
					rst.PumpType = 1S
				ElseIf flag3 = Me.optPumpType_2.Checked Then
					rst.PumpType = 2S
				ElseIf flag3 = Me.optPumpType_3.Checked Then
					rst.PumpType = 3S
				End If
				rst.TubingAnchored = If((-If((Me.chkTubingAnchored.Checked > False), 1S, 0S)), 1S, 0S)
				rst.gbIncludeBuoyancy = Me.chkIncludeBuoyancy.Checked
				If Me.chkIncludeFluidInertia.Enabled Then
					rst.IncludeFluidInertia = If((-If((Me.chkIncludeFluidInertia.Checked > False), 1S, 0S)), 1S, 0S)
					If Me.txtCompressibilityIndex.Enabled And Versioned.IsNumeric(Me.txtCompressibilityIndex.Text) Then
						RSWIN_DESC.rst.CompressibilityIndex = Conversions.ToSingle(Me.txtCompressibilityIndex.Text)
					End If
				End If
				If Not bQuiet Then
					If rst.TubingOD = 0F Then
						Me.DisplayPTInfoError("Please select value Tubing Size.", flag2)
						If Not flag2 Then
							Dim control As Control = Me.cboTubingOD
							Me.SetActiveControl(control)
							Me.cboTubingOD = CType(control, ComboBox)
							flag = False
						End If
					ElseIf rst.PlungerSize = 0F Then
						Me.DisplayPTInfoError("Please select value for plunger size.", flag2)
						If Not flag2 Then
							Dim control As Control = Me.cboPlungerSize
							Me.SetActiveControl(control)
							Me.cboPlungerSize = CType(control, ComboBox)
							flag = False
						End If
					ElseIf((If((-If(((rst.TubingAnchorDepth = 0F) > False), 1S, 0S)), 1S, 0S) And rst.TubingAnchored) Or If((-If(((Me.chkTubingAnchored.Checked And Operators.CompareString(Me.txtTubingAnchorDepth.Text, "", False) = 0) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						Me.DisplayPTInfoError("Please select value for tubing anchor depth.", flag2)
						If Not flag2 Then
							Dim control As Control = Me.txtTubingAnchorDepth
							Me.SetActiveControl(control)
							Me.txtTubingAnchorDepth = CType(control, TextBox)
							flag = False
						End If
					ElseIf(rst.IncludeFluidInertia And If((-If(((rst.CompressibilityIndex < 1F Or rst.CompressibilityIndex > 7F) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						Me.DisplayPTInfoError("Please select correct value for Fluid Compressibility Index.", flag2)
						If Not flag2 Then
							Dim control As Control = Me.txtCompressibilityIndex
							Me.SetActiveControl(control)
							Me.txtCompressibilityIndex = CType(control, TextBox)
							flag = False
						End If
					End If
					If Not((rst.TubingOD = 2.375F And rst.TubingID = 1.71F) Or (rst.TubingOD = 2.875F And rst.TubingID = 2.16F) Or (rst.TubingOD = 3.5F And rst.TubingID = 2.67F)) Then
						Dim num As Single
						Dim num2 As Single
						If CDbl(rst.TubingOD) > 5.5 Then
							num = CSng((CDbl(rst.TubingOD) - 0.5))
							num2 = rst.TubingOD - 1F
						Else
							Dim num3 As Single = CSng((-0.4366663 + 1.580083 * CDbl(rst.TubingOD) - 0.4333377 * Math.Pow(CDbl(rst.TubingOD), 2.0) + 0.1045154 * Math.Pow(CDbl(rst.TubingOD), 3.0) - 0.00845177 * Math.Pow(CDbl(rst.TubingOD), 4.0)))
							num = CSng((Conversion.Int((CDbl(num3) + 0.15) * 100.0) / 100.0))
							num2 = CSng((Conversion.Int((CDbl(num3) - 0.15) * 100.0) / 100.0))
						End If
						If rst.TubingID < num2 Or rst.TubingID > num Then
							Dim sMsg As String
							If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
								Util.LoadMessage(33, sMsg)
							Else
								Util.LoadMessage(34, sMsg)
							End If
							Util.ApplyNumber(num2, sMsg)
							Util.ApplyNumber(num, sMsg)
							Util.ApplyNumber(num2 * RSWIN_DESC.IN__MM, sMsg)
							Util.ApplyNumber(num * RSWIN_DESC.IN__MM, sMsg)
							Me.DisplayPTInfoError(sMsg, flag2)
							Dim control As Control = Me.txtTubingID
							Me.SetActiveControl(control)
							Me.txtTubingID = CType(control, TextBox)
							flag = False
						End If
					End If
				End If
				If(RSWIN_DESC.NewData(3) And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					RSWIN_DESC.NewData(3) = 0S
					ini.SaveDataValue("PTInfo", True)
				End If
				Return flag
			End If
			Return True
		End Function

		Private Sub chkTubingAnchored_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ActiveControl Is Me.chkTubingAnchored
			RSWIN_DESC.rst.TubingAnchored = If((-If((Me.chkTubingAnchored.Checked > False), 1S, 0S)), 1S, 0S)
			Me.txtTubingAnchorDepth.Enabled = Me.chkTubingAnchored.Checked
			Me.Control_SelectedIndexChanged(flag)
			If flag Then
				ini.SaveDataValue("TubingAnchored", RSWIN_DESC.rst.TubingAnchored)
				Return
			End If
		End Sub

		Private Sub cboPlungerSize_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ActiveControl Is Me.cboPlungerSize
			Me.Control_SelectedIndexChanged(flag)
			If Operators.CompareString(Strings.Trim(Conversions.ToString(Me.cboPlungerSize.SelectedItem)), "Other", False) = 0 Then
				Me.txtPlungerSize.Enabled = True
				Me.lblPlungerSize_Disabled.SendToBack()
			Else
				Me.txtPlungerSize.Enabled = False
				Me.lblPlungerSize_Disabled.BringToFront()
			End If
			Me.cboPlungerSize_Click_1(Me.cboPlungerSize.SelectedIndex, Me.bPlungerSizeClicked)
			If flag And Me.cboTubingOD.SelectedIndex >= 0 Then
				If RSWIN_DESC.frmMain.CheckPlungerInTubing(False) = 0S Then
					Me.cboPlungerSize.Focus()
				End If
				RSWIN_DESC.bCheckPlunger = False
			End If
			Me.chkIncludeFluidInertia.Enabled = Me.EnableFluidInertia()
			If flag Then
				If Not MImpred.FluidInertiaPossible() Then
					RSWIN_DESC.rst.IncludeFluidInertia = 0S
					Me.chkIncludeFluidInertia.Checked = False
				Else
					RSWIN_DESC.rst.IncludeFluidInertia = -1S
					Me.chkIncludeFluidInertia.Checked = True
				End If
				Return
			End If
		End Sub

		Private Sub txtPlungerSize_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			Dim txtPlungerSize As TextBox = Me.txtPlungerSize
			Dim label_PlungerSize As Label = Me._Label_PlungerSize
			CtrlUI.TextBox_KeyDown(txtPlungerSize, label_PlungerSize, CInt(eventArgs.KeyCode), If((-If((eventArgs.Shift > False), 1, 0)), 1, 0))
			Me._Label_PlungerSize = label_PlungerSize
			Me.txtPlungerSize = txtPlungerSize
		End Sub

		Private Sub txtTubingAnchorDepth_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			Dim txtTubingAnchorDepth As TextBox = Me.txtTubingAnchorDepth
			Dim label_TubingAnchorDepth As Label = Me._Label_TubingAnchorDepth
			CtrlUI.TextBox_KeyDown(txtTubingAnchorDepth, label_TubingAnchorDepth, CInt(eventArgs.KeyCode), If((-If((eventArgs.Shift > False), 1, 0)), 1, 0))
			Me._Label_TubingAnchorDepth = label_TubingAnchorDepth
			Me.txtTubingAnchorDepth = txtTubingAnchorDepth
		End Sub

		Private Sub txtTubingID_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			Dim txtTubingID As TextBox = Me.txtTubingID
			Dim label_TubingID As Label = Me._Label_TubingID
			CtrlUI.TextBox_KeyDown(txtTubingID, label_TubingID, CInt(eventArgs.KeyCode), If((-If((eventArgs.Shift > False), 1, 0)), 1, 0))
			Me._Label_TubingID = label_TubingID
			Me.txtTubingID = txtTubingID
		End Sub

		Private Sub txtTubingOD_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			Dim txtTubingOD As TextBox = Me.txtTubingOD
			Dim label_TubingOD As Label = Me._Label_TubingOD
			CtrlUI.TextBox_KeyDown(txtTubingOD, label_TubingOD, CInt(eventArgs.KeyCode), If((-If((eventArgs.Shift > False), 1, 0)), 1, 0))
			Me._Label_TubingOD = label_TubingOD
			Me.txtTubingOD = txtTubingOD
		End Sub

		Private Sub txtPlungerSize_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtPlungerSize As Control = Me.txtPlungerSize
			CtrlUI.Control_LostFocus(txtPlungerSize)
			Me.txtPlungerSize = CType(txtPlungerSize, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtPlungerSize, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 0.5F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 39
				Dim useMetric As Integer = -1
				Dim canadianIsMetric As Integer = -1
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtPlungerSize.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 9F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 39
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = -1
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtPlungerSize.Focus()
					Else
						Dim txtPlungerSize2 As TextBox = Me.txtPlungerSize
						Dim label_PlungerSize As Label = Me._Label_PlungerSize
						CtrlUI.TextBox_LostFocus(txtPlungerSize2, label_PlungerSize, True)
						Me._Label_PlungerSize = label_PlungerSize
						Me.txtPlungerSize = txtPlungerSize2
						ini.SaveDataValue("PlungerSize", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.PlungerSize = Conversions.ToSingle(obj)
							RSWIN_DESC.rst.Apump = CSng((3.141592653589793 * Math.Pow(CDbl(RSWIN_DESC.rst.PlungerSize), 2.0) / 4.0))
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtTubingAnchorDepth_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtTubingAnchorDepth As Control = Me.txtTubingAnchorDepth
			CtrlUI.Control_LostFocus(txtTubingAnchorDepth)
			Me.txtTubingAnchorDepth = CType(txtTubingAnchorDepth, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtTubingAnchorDepth, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = RSWIN_DESC.rst.PumpDepth / 2F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 4
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtTubingAnchorDepth.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = CSng((CDbl(RSWIN_DESC.rst.PumpDepth) + 100.1))
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 2
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = -1
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtTubingAnchorDepth.Focus()
					Else
						Dim txtTubingAnchorDepth2 As TextBox = Me.txtTubingAnchorDepth
						Dim label_TubingAnchorDepth As Label = Me._Label_TubingAnchorDepth
						CtrlUI.TextBox_LostFocus(txtTubingAnchorDepth2, label_TubingAnchorDepth, True)
						Me._Label_TubingAnchorDepth = label_TubingAnchorDepth
						Me.txtTubingAnchorDepth = txtTubingAnchorDepth2
						ini.SaveDataValue("TubingAnchorDepth", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.TubingAnchorDepth = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtTubingID_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtTubingID As Control = Me.txtTubingID
			CtrlUI.Control_LostFocus(txtTubingID)
			Me.txtTubingID = CType(txtTubingID, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtTubingID, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 0.5F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 80
				Dim useMetric As Integer = -1
				Dim canadianIsMetric As Integer = -1
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtTubingID.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 10.75F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 80
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = -1
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtTubingID.Focus()
					Else
						Dim txtTubingID2 As TextBox = Me.txtTubingID
						Dim label_TubingID As Label = Me._Label_TubingID
						CtrlUI.TextBox_LostFocus(txtTubingID2, label_TubingID, True)
						Me._Label_TubingID = label_TubingID
						Me.txtTubingID = txtTubingID2
						ini.SaveDataValue("TubingID", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.TubingID = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtTubingOD_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtTubingOD As Control = Me.txtTubingOD
			CtrlUI.Control_LostFocus(txtTubingOD)
			Me.txtTubingOD = CType(txtTubingOD, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtTubingOD, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 0.5F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 82
				Dim useMetric As Integer = -1
				Dim canadianIsMetric As Integer = -1
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtTubingOD.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 11F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 82
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = -1
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtTubingOD.Focus()
					Else
						Dim txtTubingOD2 As TextBox = Me.txtTubingOD
						Dim label_TubingOD As Label = Me._Label_TubingOD
						CtrlUI.TextBox_LostFocus(txtTubingOD2, label_TubingOD, True)
						Me._Label_TubingOD = label_TubingOD
						Me.txtTubingOD = txtTubingOD2
						ini.SaveDataValue("TubingOD", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.TubingOD = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub cboTubingOD_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			Me.Control_SelectedIndexChanged(Me.cboTubingOD Is Me.ActiveControl)
			Dim num As Single = Conversions.ToSingle(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 1, RSWIN_DESC.IN__MM))
			Me.sFmt = Conversions.ToString(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, "0.0##", "###.##"))
			Dim num2 As Short = CShort(Me.cboTubingOD.SelectedIndex)
			If num2 < 0S Or CInt(num2) = Me.cboTubingOD.Items.Count - 1 Then
				Me.txtTubingOD.Enabled = True
				Me.txtTubingID.Enabled = True
				Return
			End If
			If Me.$STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$nOD = 0S Then
				Me.$STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$OD = New String(0) {}
				Me.$STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$ID = New String(0) {}
				Util.LoadMenu("TUBING-OD", Me.$STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$nOD, Me.$STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$OD)
				Util.LoadMenu("TUBING-ID", Me.$STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$nID, Me.$STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$ID)
			End If
			RSWIN_DESC.rst.TubingOD = CSng(Conversion.Val(Me.$STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$OD(CInt((num2 + 1S)))))
			ini.SaveDataValue("TubingOD", RSWIN_DESC.rst.TubingOD)
			Me.txtTubingOD.Enabled = False
			Me.txtTubingOD.Tag = "mem"
			Me.txtTubingOD.Text = RSWIN_DESC.rst.TubingOD.ToString()
			RSWIN_DESC.rst.TubingID = CSng(Conversion.Val(Me.$STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$ID(CInt((num2 + 1S)))))
			ini.SaveDataValue("TubingID", RSWIN_DESC.rst.TubingID)
			Me.txtTubingID.Enabled = False
			Me.txtTubingID.Tag = "mem"
			Me.txtTubingID.Text = RSWIN_DESC.rst.TubingID.ToString()
			If(Me.ActiveControl Is Me.cboTubingOD And Me.cboTubingOD.SelectedIndex >= 0 And Me.cboPlungerSize.SelectedIndex >= 0) AndAlso RSWIN_DESC.frmMain.CheckPlungerInTubing(False) = 0S Then
				Me.cboPlungerSize.Focus()
			End If
			If Me.ActiveControl Is Me.cboTubingOD And RSWIN_DESC.bRodStarD Then
				If Util.IsPolyLined(RSWIN_DESC.rst.TubingID) Then
					Dim sReduceMsg As String = RSWIN_DESC.sReduceMsg
					Dim bDefaultYes As Boolean = True
					Dim flag As Boolean = False
					RSWIN_DESC.bReduceFricCoeff = Util.YesNo(sReduceMsg, bDefaultYes, flag)
					ini.SaveDataValue("ReduceFricCoeff", RSWIN_DESC.bReduceFricCoeff)
				Else
					ini.SaveDataValue("ReduceFricCoeff", False)
				End If
			End If
		End Sub

		Private Sub cboPlungerSize_Click(eventSender As Object, eventArgs As EventArgs)
			Me.cboPlungerSize_Click_1(Me.cboPlungerSize.SelectedIndex, True)
		End Sub

		Private Sub cboPlungerSize_Click_1(SelectedIndex As Object, bClicked As Object)
			Dim num As Single = Conversions.ToSingle(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 1, RSWIN_DESC.IN__MM))
			Me.sFmt = Conversions.ToString(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, "0.0##", "0.0"))
			If Operators.ConditionalCompareObjectEqual(SelectedIndex, Me.cboPlungerSize.Items.Count - 1, False) Then
				Me.txtPlungerSize.Enabled = True
				Return
			End If
			If Operators.ConditionalCompareObjectGreater(SelectedIndex, -1, False) Then
				If Me.$STATIC$cboPlungerSize_Click_1$20211C1C$nPS = 0S Then
					Me.$STATIC$cboPlungerSize_Click_1$20211C1C$PS = New String(0) {}
					Util.LoadMenu("PLUNGER-SIZE-LIST", Me.$STATIC$cboPlungerSize_Click_1$20211C1C$nPS, Me.$STATIC$cboPlungerSize_Click_1$20211C1C$PS)
				End If
				RSWIN_DESC.rst.PlungerSize = CSng(Conversion.Val(Me.$STATIC$cboPlungerSize_Click_1$20211C1C$PS(Conversions.ToInteger(Operators.AddObject(SelectedIndex, 1)))))
				RSWIN_DESC.rst.Apump = CSng((3.141592653589793 * Math.Pow(CDbl(RSWIN_DESC.rst.PlungerSize), 2.0) / 4.0))
				ini.SaveDataValue("PlungerSize", RSWIN_DESC.rst.PlungerSize)
				Me.txtPlungerSize.Enabled = False
				Me.lblPlungerSize_Disabled.BringToFront()
				Me.txtPlungerSize.Tag = "mem"
				Me.txtPlungerSize.Text = RSWIN_DESC.rst.PlungerSize.ToString()
				Return
			End If
		End Sub

		Private Function GetoptPumpType(Index As Integer) As Boolean
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Select Case Index
				Case 1
					Return Me.optPumpType_1.Checked
				Case 2
					Return Me.optPumpType_2.Checked
				Case 3
					Return Me.optPumpType_3.Checked
				Case Else
					Dim result As Boolean
					Return result
			End Select
		End Function

		Private Sub SetoptPumpType(Index As Integer, bVal As Boolean)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Select Case Index
				Case 1
					Me.optPumpType_1.Checked = bVal
					If Me.optPumpType_1.Checked Then
						RSWIN_DESC.rst.PumpType = 1S
					End If
					Me.chkVSP.Enabled = True
					Me.chkVSP.Checked = RSWIN_DESC.rst.VSP
				Case 2
					Me.optPumpType_2.Checked = bVal
					If Me.optPumpType_2.Checked Then
						RSWIN_DESC.rst.PumpType = 2S
					End If
					Me.chkVSP.Enabled = True
					Me.chkVSP.Checked = RSWIN_DESC.rst.VSP
				Case 3
					Me.optPumpType_3.Checked = bVal
					If Me.optPumpType_3.Checked Then
						RSWIN_DESC.rst.PumpType = 3S
					End If
					Me.chkVSP.Enabled = False
					Me.chkVSP.Checked = False
			End Select
			ini.SaveDataValue("PumpType", RSWIN_DESC.rst.PumpType)
		End Sub

		Private Sub optPumpType_Click_1(Index As Short, Value As Short, bClicked As Object)
			If Me.$STATIC$optPumpType_Click_1$2031661C$busy <> 0S Then
				Return
			End If
			If Not Me.GetoptPumpType(CInt(Index)) Then
				Me.$STATIC$optPumpType_Click_1$2031661C$busy = -1S
				Me.SetoptPumpType(CInt(Index), True)
				Me.$STATIC$optPumpType_Click_1$2031661C$busy = 0S
			End If
			If Value <> 0S Then
				RSWIN_DESC.rst.PumpType = Index
				ini.SaveDataValue("PumpType", RSWIN_DESC.rst.PumpType)
			End If
		End Sub

		Public Sub DisplayPTInfoError(sMsg As String, ByRef bCancel As Boolean)
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

		Private Sub chkIncludeBuoyancy_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ActiveControl Is Me.chkIncludeBuoyancy
			Me.chkIncludeBuoyancy_Click_1(Me.chkIncludeBuoyancy.Checked, flag)
			Me.Control_SelectedIndexChanged(flag)
		End Sub

		Private Sub optPumpType_1_CheckedChanged(sender As Object, e As EventArgs)
			Me.SetoptPumpType(1, Me.optPumpType_1.Checked)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.optPumpType_1)
		End Sub

		Private Sub optPumpType_3_CheckedChanged(sender As Object, e As EventArgs)
			Me.SetoptPumpType(3, Me.optPumpType_3.Checked)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.optPumpType_3)
		End Sub

		Private Sub optPumpType_2_CheckedChanged(sender As Object, e As EventArgs)
			Me.SetoptPumpType(2, Me.optPumpType_2.Checked)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.optPumpType_2)
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

		Private Sub txtTubingOD_Enter(sender As Object, e As EventArgs)
			Me.txtTubingOD.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtTubingID_Enter(sender As Object, e As EventArgs)
			Me.txtTubingID.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtTubingAnchorDepth_Enter(sender As Object, e As EventArgs)
			Me.txtTubingAnchorDepth.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtPlungerSize_Enter(sender As Object, e As EventArgs)
			Me.txtPlungerSize.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboPlungerSize_Enter(sender As Object, e As EventArgs)
			Me.cboPlungerSize.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboPlungerSize_Leave(sender As Object, e As EventArgs)
			Dim cboPlungerSize As Control = Me.cboPlungerSize
			CtrlUI.Control_LostFocus(cboPlungerSize)
			Me.cboPlungerSize = CType(cboPlungerSize, ComboBox)
		End Sub

		Private Sub cboTubingOD_Enter(sender As Object, e As EventArgs)
			Me.cboTubingOD.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboTubingOD_Leave(sender As Object, e As EventArgs)
			Dim cboTubingOD As Control = Me.cboTubingOD
			CtrlUI.Control_LostFocus(cboTubingOD)
			Me.cboTubingOD = CType(cboTubingOD, ComboBox)
		End Sub

		Private Sub txtTubingAnchorDepth_TextChanged(sender As Object, e As EventArgs)
			Dim txtTubingAnchorDepth As TextBox = Me.txtTubingAnchorDepth
			Dim label_TubingAnchorDepth As Label = Me._Label_TubingAnchorDepth
			Me.TextBox_Change(txtTubingAnchorDepth, label_TubingAnchorDepth)
			Me._Label_TubingAnchorDepth = label_TubingAnchorDepth
			Me.txtTubingAnchorDepth = txtTubingAnchorDepth
			txtTubingAnchorDepth = Me.txtTubingAnchorDepth
			Util.SetFieldColor(txtTubingAnchorDepth)
			Me.txtTubingAnchorDepth = txtTubingAnchorDepth
			If Not(Me.ActiveControl Is Me.txtTubingAnchorDepth And Versioned.IsNumeric(Me.txtTubingAnchorDepth.Text)) Then
				Return
			End If
			If Operators.CompareString(Me.txtTubingAnchorDepth.Text.Trim(), ".", False) = 0 Then
				Return
			End If
			If Me.txtTubingAnchorDepth.Text.Length > 0 Then
				If Not Versioned.IsNumeric(Me.txtTubingAnchorDepth.Text) Then
					Dim sMsg As String = "Please enter value for Tubing Anchor Depth"
					Dim sMsgType As String = "Data Entry Error"
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
					Me.txtTubingAnchorDepth.Text = ""
				Else
					Dim txtTubingAnchorDepth2 As TextBox = Me.txtTubingAnchorDepth
					Dim bValidIfEmpty As Boolean = True
					Dim bShowMessage As Boolean = False
					Dim num As Single
					Dim obj As Object = num
					Dim flag As Boolean = CtrlUI.CheckValid(txtTubingAnchorDepth2, bValidIfEmpty, bShowMessage, obj)
					num = Conversions.ToSingle(obj)
					If flag Then
						Dim obj2 As Object = num
						Dim upperBound As Single = CSng((CDbl(RSWIN_DESC.rst.PumpDepth) + 100.1))
						Dim inclusive As Integer = -1
						Dim errnum As Integer = 2
						Dim useMetric As Integer = -1
						Dim canadianIsMetric As Integer = -1
						Dim bQuiet As Boolean = False
						Dim text As String = ""
						Dim obj3 As Object = Util.CheckUpper(obj2, upperBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text)
						num = Conversions.ToSingle(obj2)
						If Conversions.ToBoolean(Operators.NotObject(obj3)) Then
							Me.txtTubingAnchorDepth.Tag = "fem"
							RSWIN_DESC.rst.TubingAnchorDepth = RSWIN_DESC.rst.PumpDepth + 100F
							Me.txtTubingAnchorDepth.Text = RSWIN_DESC.rst.TubingAnchorDepth.ToString()
							Me.txtTubingAnchorDepth.Focus()
						Else
							RSWIN_DESC.rst.TubingAnchorDepth = num
						End If
					End If
				End If
			Else
				RSWIN_DESC.rst.TubingAnchorDepth = 0F
			End If
		End Sub

		Private Sub txtTubingOD_TextChanged(sender As Object, e As EventArgs)
			Try
				If Me.ActiveControl Is Me.txtTubingOD Then
					Dim txtTubingOD As TextBox = Me.txtTubingOD
					Dim bValidIfEmpty As Boolean = True
					Dim bShowMessage As Boolean = False
					Dim num As Single
					Dim obj As Object = num
					Dim flag As Boolean = CtrlUI.CheckValid(txtTubingOD, bValidIfEmpty, bShowMessage, obj)
					num = Conversions.ToSingle(obj)
					If flag Then
						ini.SaveDataValue("TubingOD", num)
						If Not Information.IsDBNull(num) Then
							RSWIN_DESC.rst.TubingOD = num
						End If
						Dim txtTubingOD2 As TextBox = Me.txtTubingOD
						Dim label_TubingOD As Label = Me._Label_TubingOD
						Me.TextBox_Change(txtTubingOD2, label_TubingOD)
						Me._Label_TubingOD = label_TubingOD
						Me.txtTubingOD = txtTubingOD2
					End If
				Else
					If Versioned.IsNumeric(Me.txtTubingOD.Text) Then
						Dim txtTubingOD3 As TextBox = Me.txtTubingOD
						Dim num2 As Single = Convert.ToSingle(Me.txtTubingOD.Text)
						txtTubingOD3.Text = Util.Format(num2, Me.sFmt)
					End If
					Dim txtTubingOD2 As TextBox = Me.txtTubingOD
					Dim label_TubingOD As Label = Me._Label_TubingOD
					Me.TextBox_Change(txtTubingOD2, label_TubingOD)
					Me._Label_TubingOD = label_TubingOD
					Me.txtTubingOD = txtTubingOD2
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtTubingID_TextChanged(sender As Object, e As EventArgs)
			Try
				If Me.ActiveControl Is Me.txtTubingID Then
					Dim txtTubingID As TextBox = Me.txtTubingID
					Dim bValidIfEmpty As Boolean = True
					Dim bShowMessage As Boolean = False
					Dim num As Single
					Dim obj As Object = num
					Dim flag As Boolean = CtrlUI.CheckValid(txtTubingID, bValidIfEmpty, bShowMessage, obj)
					num = Conversions.ToSingle(obj)
					If flag Then
						ini.SaveDataValue("TubingID", num)
						If Not Information.IsDBNull(num) Then
							RSWIN_DESC.rst.TubingID = num
						End If
						Dim txtTubingID2 As TextBox = Me.txtTubingID
						Dim label_TubingID As Label = Me._Label_TubingID
						Me.TextBox_Change(txtTubingID2, label_TubingID)
						Me._Label_TubingID = label_TubingID
						Me.txtTubingID = txtTubingID2
					End If
				Else
					If Versioned.IsNumeric(Me.txtTubingID.Text) Then
						Dim txtTubingID3 As TextBox = Me.txtTubingID
						Dim num2 As Single = Convert.ToSingle(Me.txtTubingID.Text)
						txtTubingID3.Text = Util.Format(num2, Me.sFmt)
					End If
					Dim txtTubingID2 As TextBox = Me.txtTubingID
					Dim label_TubingID As Label = Me._Label_TubingID
					Me.TextBox_Change(txtTubingID2, label_TubingID)
					Me._Label_TubingID = label_TubingID
					Me.txtTubingID = txtTubingID2
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtPlungerSize_TextChanged(sender As Object, e As EventArgs)
			Try
				If Me.ActiveControl IsNot Me.txtPlungerSize AndAlso Versioned.IsNumeric(Me.txtPlungerSize.Text) Then
					Dim txtPlungerSize As TextBox = Me.txtPlungerSize
					Dim num As Single = Convert.ToSingle(Me.txtPlungerSize.Text)
					txtPlungerSize.Text = Util.Format(num, Me.sFmt)
				End If
				Dim txtPlungerSize2 As TextBox = Me.txtPlungerSize
				Dim label_PlungerSize As Label = Me._Label_PlungerSize
				Me.TextBox_Change(txtPlungerSize2, label_PlungerSize)
				Me._Label_PlungerSize = label_PlungerSize
				Me.txtPlungerSize = txtPlungerSize2
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboPlungerSize_Click1(sender As Object, e As EventArgs)
			Me.bPlungerSizeClicked = True
		End Sub

		Private Sub chkIncludeFluidInertia_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.ActiveControl Is Me.chkIncludeFluidInertia
				RSWIN_DESC.rst.IncludeFluidInertia = If((-If((Me.chkIncludeFluidInertia.Checked > False), 1S, 0S)), 1S, 0S)
				Me.chkIncludeFluidInertia_Click_1(Me.chkIncludeFluidInertia.Checked, True)
				Me.Control_SelectedIndexChanged(flag)
				If flag And Me.chkIncludeFluidInertia.Checked And RSWIN_DESC.rst.PumpCondition <> 1S Then
					Dim msg As String = "We recommend using a full pump condition when using fluid inertia effects. Using fluid inertia effects with incomplete pump fillage may cause the results to be unstable. Would you like to change the pump condition?"
					Dim bDefaultYes As Boolean = True
					Dim flag2 As Boolean = False
					If Util.YesNo(msg, bDefaultYes, flag2) Then
						If Me.MyParentFrm Is Nothing Then
							Try
								Me.MyParentFrm = New RODSTAR()
								Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
							Catch ex As Exception
							End Try
						End If
						Try
							Me.MyParentFrm.DisplayForm("WellInfo", "_Label_PumpCondition")
							Me.Close()
						Catch ex2 As Exception
						End Try
					End If
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub chkCalcPlungerSize_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkCalcPlungerSize_Click_1(Me.chkCalcPlungerSize.Checked, -1)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.chkCalcPlungerSize)
		End Sub

		Public Sub chkCalcPlungerSize_Click_1(Value As Boolean, bClicked As Integer)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Conversions.ToBoolean(Me.$STATIC$chkCalcPlungerSize_Click_1$202128$busy) Then
				Return
			End If
			If Me.chkCalcPlungerSize.Checked <> Value Then
				Me.$STATIC$chkCalcPlungerSize_Click_1$202128$busy = True
				Me.chkCalcPlungerSize.Checked = Value
				Me.$STATIC$chkCalcPlungerSize_Click_1$202128$busy = False
			End If
			RSWIN_DESC.rst.CalcPlungerSize = If((-If((Value > False), 1S, 0S)), 1S, 0S)
			ini.SaveDataValue("CalcPlungerSize", Value)
			If RSWIN_DESC.rst.CalcPlungerSize <> 0S Then
				Me.lblcboPlungerSize_Disabled.BringToFront()
				Me.lblPlungerSize_Disabled.BringToFront()
			Else
				Me.lblcboPlungerSize_Disabled.SendToBack()
				Me.lblPlungerSize_Disabled.SendToBack()
				If Operators.CompareString(Strings.Trim(Conversions.ToString(Me.cboPlungerSize.SelectedItem)), "Other", False) = 0 Then
					Me.txtPlungerSize.Enabled = True
					Me.lblPlungerSize_Disabled.SendToBack()
				Else
					Me.txtPlungerSize.Enabled = False
					Me.lblPlungerSize_Disabled.BringToFront()
				End If
			End If
			Dim flag As Boolean = Me.EnableFluidInertia()
			If(RSWIN_DESC.rst.CalcPlungerSize And Not RSWIN_DESC.rst.SPMEntered) <> 0S Then
				RSWIN_DESC.WarnedAboutFluidInertia = 0S
				Return
			End If
		End Sub

		Private Sub txtPumpFriction_TextChanged(sender As Object, e As EventArgs)
			Dim txtPumpFriction As TextBox = Me.txtPumpFriction
			Dim label_PumpFriction As Label = Me._Label_PumpFriction
			Me.TextBox_Change(txtPumpFriction, label_PumpFriction)
			Me._Label_PumpFriction = label_PumpFriction
			Me.txtPumpFriction = txtPumpFriction
		End Sub

		Private Sub txtPumpFriction_Leave(sender As Object, e As EventArgs)
			Dim txtPumpFriction As Control = Me.txtPumpFriction
			CtrlUI.Control_LostFocus(txtPumpFriction)
			Me.txtPumpFriction = CType(txtPumpFriction, TextBox)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = flag
			Dim txtPumpFriction2 As TextBox = Me.txtPumpFriction
			Dim bValidIfEmpty As Boolean = 1
			Dim bShowMessage As Boolean = 0
			Dim num As Single
			Dim obj As Object = num
			Dim flag3 As Boolean = CtrlUI.CheckValid(txtPumpFriction2, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			If flag2 <> flag3 Then
				Dim obj2 As Object = flag
				obj = num
				Dim lowerBound As Single = 0F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 128
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				Dim obj3 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text)
				num = Conversions.ToSingle(obj)
				If Operators.ConditionalCompareObjectEqual(obj2, obj3, False) Then
					Me.txtPumpFriction.Focus()
				Else
					Dim obj4 As Object = flag
					obj = num
					Dim upperBound As Single = 5000F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 126
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = -1
					Dim bQuiet2 As Boolean = False
					text = ""
					Dim obj5 As Object = Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text)
					num = Conversions.ToSingle(obj)
					If Operators.ConditionalCompareObjectEqual(obj4, obj5, False) Then
						Me.txtPumpFriction.Focus()
					Else
						ini.SaveDataValue("PumpFriction", num)
						If Not Information.IsDBNull(num) Then
							RSWIN_DESC.rst.PumpFriction = num
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtSlideFricCoeff_TextChanged(sender As Object, e As EventArgs)
			Dim txtSlideFricCoeff As TextBox = Me.txtSlideFricCoeff
			Dim label_SlideFricCoeff As Label = Me._Label_SlideFricCoeff
			Me.TextBox_Change(txtSlideFricCoeff, label_SlideFricCoeff)
			Me._Label_SlideFricCoeff = label_SlideFricCoeff
			Me.txtSlideFricCoeff = txtSlideFricCoeff
			If Versioned.IsNumeric(Me.txtSlideFricCoeff.Text) Then
				RSWIN_DESC.rst.SlideFricCoeff = Convert.ToSingle(Me.txtSlideFricCoeff.Text)
				ini.SaveDataValue("SlideFricCoeff", RSWIN_DESC.rst.SlideFricCoeff)
			End If
		End Sub

		Private Sub txtSlideFricCoeff_Leave(sender As Object, e As EventArgs)
			Dim txtSlideFricCoeff As Control = Me.txtSlideFricCoeff
			CtrlUI.Control_LostFocus(txtSlideFricCoeff)
			Me.txtSlideFricCoeff = CType(txtSlideFricCoeff, TextBox)
			If Me.ActiveControl Is Me.txtSlideFricCoeff AndAlso Versioned.IsNumeric(Me.txtSlideFricCoeff.Text) Then
				If CDbl(Convert.ToSingle(Me.txtSlideFricCoeff.Text)) < 0.2 Or CDbl(Convert.ToSingle(Me.txtSlideFricCoeff.Text)) > 0.35 Then
					MessageBox.Show(Me.sSlideFriction)
					Me.txtSlideFricCoeff.Focus()
				Else
					ini.SaveDataValue("SlideFricCoeff", Convert.ToSingle(Me.txtSlideFricCoeff.Text))
				End If
			End If
		End Sub

		Private Sub txtUpstrokeFriction_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Try
				If Versioned.IsNumeric(Me.txtUpstrokeFriction.Text) Then
					If Convert.ToSingle(Me.txtUpstrokeFriction.Text) <= 0F Then
						Dim str As String = Me._Label_DownstrokeFriction.Text.Replace(":", "")
						MessageBox.Show(str + " must be greater than zero!")
						Me.txtUpstrokeFriction.Focus()
					Else
						If RSWIN_DESC.rst.UpstrokeFriction <> Convert.ToSingle(Me.txtUpstrokeFriction.Text) Then
							flag = True
						End If
						RSWIN_DESC.rst.UpstrokeFriction = Conversions.ToSingle(Me.txtUpstrokeFriction.Text)
						Dim txtUpstrokeFriction As TextBox = Me.txtUpstrokeFriction
						Dim label_UpstrokeFriction As Label = Me._Label_UpstrokeFriction
						Me.TextBox_Change(txtUpstrokeFriction, label_UpstrokeFriction)
						Me._Label_UpstrokeFriction = label_UpstrokeFriction
						Me.txtUpstrokeFriction = txtUpstrokeFriction
						ini.SaveDataValue("UpstrokeFriction", RSWIN_DESC.rst.UpstrokeFriction)
					End If
				End If
			Catch ex As Exception
			End Try
			Dim txtUpstrokeFriction2 As Control = Me.txtUpstrokeFriction
			CtrlUI.Control_LostFocus(txtUpstrokeFriction2)
			Me.txtUpstrokeFriction = CType(txtUpstrokeFriction2, TextBox)
			If flag Then
				Me.TurnOffViewReportOption()
				Return
			End If
		End Sub

		Private Sub txtDownstrokeFriction_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Try
				If Versioned.IsNumeric(Me.txtDownstrokeFriction.Text) Then
					If Convert.ToSingle(Me.txtDownstrokeFriction.Text) <= 0F Then
						Dim str As String = Me._Label_DownstrokeFriction.Text.Replace(":", "")
						MessageBox.Show(str + " must be greater than zero!")
						Me.txtDownstrokeFriction.Focus()
					Else
						If RSWIN_DESC.rst.DownstrokeFriction <> Convert.ToSingle(Me.txtDownstrokeFriction.Text) Then
							flag = True
						End If
						RSWIN_DESC.rst.DownstrokeFriction = Conversions.ToSingle(Me.txtDownstrokeFriction.Text)
						Dim txtDownstrokeFriction As TextBox = Me.txtDownstrokeFriction
						Dim label_DownstrokeFriction As Label = Me._Label_DownstrokeFriction
						Me.TextBox_Change(txtDownstrokeFriction, label_DownstrokeFriction)
						Me._Label_DownstrokeFriction = label_DownstrokeFriction
						Me.txtDownstrokeFriction = txtDownstrokeFriction
						ini.SaveDataValue("DownstrokeFriction", RSWIN_DESC.rst.DownstrokeFriction)
					End If
				End If
			Catch ex As Exception
			End Try
			Dim txtDownstrokeFriction2 As Control = Me.txtDownstrokeFriction
			CtrlUI.Control_LostFocus(txtDownstrokeFriction2)
			Me.txtDownstrokeFriction = CType(txtDownstrokeFriction2, TextBox)
			If flag Then
				Me.TurnOffViewReportOption()
				Return
			End If
		End Sub

		Private Sub txtUpstrokeFriction_Enter(sender As Object, e As EventArgs)
			Me.txtUpstrokeFriction.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtDownstrokeFriction_Enter(sender As Object, e As EventArgs)
			Me.txtDownstrokeFriction.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtSlideFricCoeff_Enter(sender As Object, e As EventArgs)
			Me.txtSlideFricCoeff.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtPumpFriction_Enter(sender As Object, e As EventArgs)
			Me.txtPumpFriction.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub chkCalcFriction_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ActiveControl Is Me.chkCalcFriction
			If flag Then
				RSWIN_DESC.rst.CalcFriction = If((-If((Me.chkCalcFriction.Checked > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.rst.gbCalcFriction = Me.chkCalcFriction.Checked
				ini.SaveDataValue("CalcFriction", RSWIN_DESC.rst.CalcFriction)
			End If
			If Not Me.chkCalcFriction.Checked Then
				Me.txtUpstrokeFriction.Enabled = True
				If Not Versioned.IsNumeric(Me.txtUpstrokeFriction.Text) Then
					Me.txtUpstrokeFriction.Text = "1"
				End If
				Me.txtDownstrokeFriction.Enabled = True
				If Not Versioned.IsNumeric(Me.txtDownstrokeFriction.Text) Then
					Me.txtDownstrokeFriction.Text = "1"
				End If
			Else
				Me.txtUpstrokeFriction.Enabled = False
				Me.txtDownstrokeFriction.Enabled = False
			End If
			Me.Control_SelectedIndexChanged(flag)
		End Sub

		Private Sub PTInfo_Activated(sender As Object, e As EventArgs)
			Try
				Me.m_bClosing = False
				If Not Me.m_bFormLoaded Then
					If(Not RSWIN_DESC.rst.SPMEntered And If((-If((Not RSWIN_DESC.rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S) And If((-If((RSWIN_DESC.rst.TargetBFPD > 0F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						Me.chkCalcPlungerSize.Enabled = True
					End If
					If Me.txtPlungerSize.Enabled Then
						Me.lblPlungerSize_Disabled.SendToBack()
					Else
						Me.lblPlungerSize_Disabled.BringToFront()
					End If
					Me.chkIncludeFluidInertia.Enabled = Me.EnableFluidInertia()
					If Me.chkIncludeFluidInertia.Enabled Then
						Me.chkIncludeFluidInertia.Checked = (RSWIN_DESC.rst.IncludeFluidInertia <> 0S)
					End If
					If Me.chkIncludeFluidInertia.Enabled And Me.chkIncludeFluidInertia.Checked Then
						Me.txtCompressibilityIndex.Enabled = True
					Else
						Me.txtCompressibilityIndex.Enabled = False
					End If
					Me.chkTubingAnchored.Checked = (RSWIN_DESC.rst.TubingAnchored <> 0S)
					Me.txtTubingAnchorDepth.Enabled = Me.chkTubingAnchored.Checked
					If Operators.CompareString(Strings.Trim(Conversions.ToString(Me.cboPlungerSize.SelectedItem)), "Other", False) = 0 Then
						Me.txtPlungerSize.Enabled = True
						Me.lblPlungerSize_Disabled.SendToBack()
					Else
						Me.txtPlungerSize.Enabled = False
						Me.lblPlungerSize_Disabled.BringToFront()
					End If
					If RSWIN_DESC.bRodStarD Then
						Me.chkCalcFriction.Visible = False
						Me.chkCalcFriction.Checked = False
					Else
						Me.chkCalcFriction.Visible = True
					End If
					If Not Me.chkCalcFriction.Checked Then
						Me.txtUpstrokeFriction.Enabled = True
						Me.txtDownstrokeFriction.Enabled = True
					Else
						Me.txtUpstrokeFriction.Enabled = False
						Me.txtDownstrokeFriction.Enabled = False
					End If
				End If
				RSWIN_DESC.sCurrentFormName = "PTInfo"
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkCalcPlungerSize_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub chkIncludeFluidInertia_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtCompressibilityIndex_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtCompressibilityIndex.Enabled Then
				Me.lblCompressibilityIndex_Disabled.SendToBack()
				Return
			End If
			Me.lblCompressibilityIndex_Disabled.BringToFront()
		End Sub

		Private Sub txtTubingAnchorDepth_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtTubingAnchorDepth.Enabled Then
				Me.lblTubingAnchorDepth_Disabled.SendToBack()
				Return
			End If
			Me.lblTubingAnchorDepth_Disabled.BringToFront()
		End Sub

		Private Sub txtPlungerSize_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtPlungerSize.Enabled Then
				Me.lblPlungerSize_Disabled.SendToBack()
				Return
			End If
			Me.lblPlungerSize_Disabled.BringToFront()
		End Sub

		Private Sub txtUpstrokeFriction_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtUpstrokeFriction.Enabled Then
				Me.lblUpstrokeFriction_Disabled.SendToBack()
				Return
			End If
			Me.lblUpstrokeFriction_Disabled.BringToFront()
		End Sub

		Private Sub txtDownstrokeFriction_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtDownstrokeFriction.Enabled Then
				Me.lblDownstrokeFriction_Disabled.SendToBack()
				Return
			End If
			Me.lblDownstrokeFriction_Disabled.BringToFront()
		End Sub

		Private Sub cboPlungerSize_EnabledChanged(sender As Object, e As EventArgs)
			If Not Me.cboPlungerSize.Enabled Then
				Me.txtPlungerSize.Enabled = False
				Me.lblPlungerSize_Disabled.BringToFront()
				Return
			End If
			Me.lblPlungerSize_Disabled.SendToBack()
			If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(Me.cboPlungerSize.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), "Other", False) Then
				Me.txtPlungerSize.Enabled = True
				Return
			End If
			Me.txtPlungerSize.Enabled = False
		End Sub

		Private Sub PTInfo_Closing(sender As Object, e As CancelEventArgs)
			Me.m_bClosing = True
			Dim flag As Boolean = Me.ValidatePTInfo(False)
			If Not Me.m_bClosing Or (Me.m_bClosing And Not flag) Then
				e.Cancel = True
				Return
			End If
			RSWIN_DESC.sCurrentFormName = ""
		End Sub

		Private Sub PTInfo_Closed(sender As Object, e As EventArgs)
			Me.m_bClosing = False
		End Sub

		Private Sub SetActiveControl(ByRef myControl As Control)
			Try
				myControl.Focus()
				Me.ActiveControl = myControl
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtCompressibilityIndex_TextChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.txtCompressibilityIndex Then
				Dim txtCompressibilityIndex As Control = Me.txtCompressibilityIndex
				CtrlUI.Control_LostFocus(txtCompressibilityIndex)
				Me.txtCompressibilityIndex = CType(txtCompressibilityIndex, TextBox)
				Dim flag As Boolean = False
				Dim flag2 As Boolean = flag
				Dim txtCompressibilityIndex2 As TextBox = Me.txtCompressibilityIndex
				Dim bValidIfEmpty As Boolean = 1
				Dim bShowMessage As Boolean = 0
				Dim num As Single
				Dim obj As Object = num
				Dim flag3 As Boolean = CtrlUI.CheckValid(txtCompressibilityIndex2, bValidIfEmpty, bShowMessage, obj)
				num = Conversions.ToSingle(obj)
				If flag2 <> flag3 Then
					Dim obj2 As Object = flag
					obj = num
					Dim lowerBound As Single = 1F
					Dim inclusive As Integer = -1
					Dim errnum As Integer = 21
					Dim useMetric As Integer = 0
					Dim canadianIsMetric As Integer = 0
					Dim bQuiet As Boolean = False
					Dim text As String = ""
					Dim obj3 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text)
					num = Conversions.ToSingle(obj)
					If Operators.ConditionalCompareObjectEqual(obj2, obj3, False) Then
						Me.txtCompressibilityIndex.Focus()
					Else
						Dim obj4 As Object = flag
						obj = num
						Dim upperBound As Single = 7F
						Dim inclusive2 As Integer = -1
						Dim errnum2 As Integer = 21
						Dim useMetric2 As Integer = -1
						Dim canadianIsMetric2 As Integer = -1
						Dim bQuiet2 As Boolean = False
						text = ""
						Dim obj5 As Object = Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text)
						num = Conversions.ToSingle(obj)
						If Operators.ConditionalCompareObjectEqual(obj4, obj5, False) Then
							Me.txtCompressibilityIndex.Focus()
						Else
							ini.SaveDataValue("CompressibilityIndex", num)
							If Not Information.IsDBNull(num) Then
								RSWIN_DESC.rst.CompressibilityIndex = num
							End If
						End If
					End If
				End If
				Return
			End If
		End Sub

		Private Sub txtCompressibilityIndex_Leave(sender As Object, e As EventArgs)
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
				Me.Top = CInt(Math.Round(CDbl((Me.MyParentFrm.Height - Me.Height)) / 2.0 - CDbl(Me.MyParentFrm.ParentToolbarHeight())))
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub txtPumpFriction_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtPumpFriction As TextBox = Me.txtPumpFriction
			Dim label_PumpFriction As Label = Me._Label_PumpFriction
			CtrlUI.TextBox_KeyDown(txtPumpFriction, label_PumpFriction, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me._Label_PumpFriction = label_PumpFriction
			Me.txtPumpFriction = txtPumpFriction
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
				Return
			End If
		End Sub

		Private Sub chkCalcPlungerSize_EnabledChanged(sender As Object, e As EventArgs)
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Me.chkCalcPlungerSize.Enabled Then
				Me.chkCalcPlungerSize.Enabled = False
				Return
			End If
		End Sub

		Private Sub chkIncludeFluidInertia_EnabledChanged(sender As Object, e As EventArgs)
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Me.chkIncludeFluidInertia.Enabled Then
				Me.chkIncludeFluidInertia.Enabled = False
				Return
			End If
			If Not Me.chkIncludeFluidInertia.Enabled Then
				Me.txtCompressibilityIndex.Enabled = False
			ElseIf Me.chkIncludeFluidInertia.Checked Then
				Me.txtCompressibilityIndex.Enabled = True
			End If
		End Sub

		Private Sub chkIncludeBuoyancy_EnabledChanged(sender As Object, e As EventArgs)
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Me.chkIncludeBuoyancy.Enabled Then
				Me.chkIncludeBuoyancy.Enabled = False
				Return
			End If
		End Sub

		Private Sub txtUpstrokeFriction_TextChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.txtUpstrokeFriction Then
				Me.TurnOffViewReportOption()
				If RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.SavedUpstrokeFriction = RSWIN_DESC.rst.UpstrokeFriction
				End If
			End If
		End Sub

		Private Sub txtDownstrokeFriction_TextChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.txtDownstrokeFriction Then
				Me.TurnOffViewReportOption()
				If RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.SavedDownstrokeFriction = RSWIN_DESC.rst.DownstrokeFriction
				End If
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

		Private Sub PTInfo_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PTInfo_MouseDown(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PTInfo_MouseEnter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PTInfo_MouseMove(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PTInfo_MouseUp(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PTInfo_MouseWheel(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PTInfo_Move(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PTInfo_Scroll(sender As Object, e As ScrollEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PTInfo_KeyPress(sender As Object, e As KeyPressEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PTInfo_KeyUp(sender As Object, e As KeyEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PTInfo_DragDrop(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PTInfo_DragEnter(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub PTInfo_FormClosed(sender As Object, e As FormClosedEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub PTInfo_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub PTInfo_LostFocus(sender As Object, e As EventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub PTInfo_GotFocus(sender As Object, e As EventArgs)
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

		Private Sub chkVSP_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkVSP Then
				RSWIN_DESC.rst.VSP = Me.chkVSP.Checked
				ini.SaveDataValue("VSP", RSWIN_DESC.rst.VSP)
			End If
		End Sub

		Private Sub GetMeasurementUnit()
			Dim text As String = "MeasurementSystem"
			Dim num As Integer = 1
			RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_GENERAL, text, num))
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = New RODSTAR()
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				Application.DoEvents()
				If Me.MyParentFrm IsNot Nothing AndAlso Not Me.MyParentFrm.btnMeasUnit.Visible Then
					Me.MyParentFrm.btnMeasUnit.Visible = True
				End If
				Select Case RSWIN_DESC.SETUP_MeasurementSystem
					Case 1
						If Me.MyParentFrm IsNot Nothing Then
							Me.MyParentFrm.btnMeasUnit.Text = "E"
						End If
					Case 2
						If Me.MyParentFrm IsNot Nothing Then
							Me.MyParentFrm.btnMeasUnit.Text = "C"
						End If
					Case 3
						If Me.MyParentFrm IsNot Nothing Then
							Me.MyParentFrm.btnMeasUnit.Text = "M"
						End If
					Case Else
						RSWIN_DESC.SETUP_MeasurementSystem = 1
						If Me.MyParentFrm IsNot Nothing Then
							Me.MyParentFrm.btnMeasUnit.Text = "E"
						End If
				End Select
			Catch ex2 As Exception
			End Try
		End Sub

		Private MyParentFrm As RODSTAR

		Private sPumpDepthLess As String

		Private sSlideFriction As String

		Private sDownStrokeFriction As String

		Private sUpStrokeFriction As String

		Private m_bClosing As Boolean

		Private m_bValidated As Boolean

		Private m_bFormLoaded As Boolean

		<AccessedThroughProperty("chkVSP")>
		Private _chkVSP As CheckBox

		<AccessedThroughProperty("chkInsertPump")>
		Private _chkInsertPump As CheckBox

		<AccessedThroughProperty("chkTubingPump")>
		Private _chkTubingPump As CheckBox

		<AccessedThroughProperty("chkLargeBorePump")>
		Private _chkLargeBorePump As CheckBox

		Private m_bLeavingForm As Boolean

		<AccessedThroughProperty("pnlPTInfo")>
		Private _pnlPTInfo As Panel

		<AccessedThroughProperty("txtTubingOD")>
		Private _txtTubingOD As TextBox

		<AccessedThroughProperty("txtTubingID")>
		Private _txtTubingID As TextBox

		<AccessedThroughProperty("cboTubingOD")>
		Private _cboTubingOD As ComboBox

		<AccessedThroughProperty("txtTubingAnchorDepth")>
		Private _txtTubingAnchorDepth As TextBox

		<AccessedThroughProperty("chkTubingAnchored")>
		Private _chkTubingAnchored As CheckBox

		<AccessedThroughProperty("txtPlungerSize")>
		Private _txtPlungerSize As TextBox

		<AccessedThroughProperty("cboPlungerSize")>
		Private _cboPlungerSize As ComboBox

		<AccessedThroughProperty("_linSeparator_0")>
		Private __linSeparator_0 As Label

		<AccessedThroughProperty("_linSeparator_1")>
		Private __linSeparator_1 As Label

		<AccessedThroughProperty("_linSeparator_2")>
		Private __linSeparator_2 As Label

		<AccessedThroughProperty("_linSeparator_3")>
		Private __linSeparator_3 As Label

		<AccessedThroughProperty("chkIncludeBuoyancy")>
		Private _chkIncludeBuoyancy As CheckBox

		<AccessedThroughProperty("optPumpType_1")>
		Private _optPumpType_1 As RadioButton

		<AccessedThroughProperty("optPumpType_2")>
		Private _optPumpType_2 As RadioButton

		<AccessedThroughProperty("optPumpType_3")>
		Private _optPumpType_3 As RadioButton

		<AccessedThroughProperty("_Label_TubingID")>
		Private __Label_TubingID As Label

		<AccessedThroughProperty("_Label_TubingOD")>
		Private __Label_TubingOD As Label

		<AccessedThroughProperty("_Label_TubingAnchorDepth")>
		Private __Label_TubingAnchorDepth As Label

		<AccessedThroughProperty("_Label_PlungerSize")>
		Private __Label_PlungerSize As Label

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("chkCalcPlungerSize")>
		Private _chkCalcPlungerSize As CheckBox

		<AccessedThroughProperty("chkIncludeFluidInertia")>
		Private _chkIncludeFluidInertia As CheckBox

		<AccessedThroughProperty("txtCompressibilityIndex")>
		Private _txtCompressibilityIndex As TextBox

		<AccessedThroughProperty("txtDownstrokeFriction")>
		Private _txtDownstrokeFriction As TextBox

		<AccessedThroughProperty("txtUpstrokeFriction")>
		Private _txtUpstrokeFriction As TextBox

		<AccessedThroughProperty("txtPumpFriction")>
		Private _txtPumpFriction As TextBox

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("txtSlideFricCoeff")>
		Private _txtSlideFricCoeff As TextBox

		<AccessedThroughProperty("_Label_UpstrokeFriction")>
		Private __Label_UpstrokeFriction As Label

		<AccessedThroughProperty("_Label_DownstrokeFriction")>
		Private __Label_DownstrokeFriction As Label

		<AccessedThroughProperty("_Label_PumpFriction")>
		Private __Label_PumpFriction As Label

		<AccessedThroughProperty("_Label_SlideFricCoeff")>
		Private __Label_SlideFricCoeff As Label

		<AccessedThroughProperty("chkCalcFriction")>
		Private _chkCalcFriction As CheckBox

		<AccessedThroughProperty("ToolTip1")>
		Private _ToolTip1 As ToolTip

		<AccessedThroughProperty("_Label_CompressIndex")>
		Private __Label_CompressIndex As Label

		<AccessedThroughProperty("_Label_TubingSize")>
		Private __Label_TubingSize As Label

		<AccessedThroughProperty("_Label_Plunger_Size")>
		Private __Label_Plunger_Size As Label

		<AccessedThroughProperty("_Label_PumpType")>
		Private __Label_PumpType As Label

		<AccessedThroughProperty("lblTubingAnchorDepth_Disabled")>
		Private _lblTubingAnchorDepth_Disabled As Label

		<AccessedThroughProperty("lblUpstrokeFriction_Disabled")>
		Private _lblUpstrokeFriction_Disabled As Label

		<AccessedThroughProperty("lblDownstrokeFriction_Disabled")>
		Private _lblDownstrokeFriction_Disabled As Label

		<AccessedThroughProperty("lblCompressibilityIndex_Disabled")>
		Private _lblCompressibilityIndex_Disabled As Label

		<AccessedThroughProperty("lblPlungerSize_Disabled")>
		Private _lblPlungerSize_Disabled As Label

		<AccessedThroughProperty("lblcboPlungerSize_Disabled")>
		Private _lblcboPlungerSize_Disabled As Label

		<AccessedThroughProperty("chkUseExpertTubingSizePreferences")>
		Private _chkUseExpertTubingSizePreferences As CheckBox

		<AccessedThroughProperty("chkUseRODSTARPumpTypeRecommendation")>
		Private _chkUseRODSTARPumpTypeRecommendation As CheckBox

		<AccessedThroughProperty("chkUseExpertTubingAnchored")>
		Private _chkUseExpertTubingAnchored As CheckBox

		Private Shared m_vb6FormDefInstance As PTInfo

		Private Shared m_InitializingDefInstance As Boolean

		Private bPlungerSizeClicked As Boolean

		Private myKeyValueHT As Hashtable

		Private sFmt As String

		Private $STATIC$cboPlungerSize_Click_1$20211C1C$nPS As Short

		Private $STATIC$chkIncludeFluidInertia_Click_1$202122$busy As Boolean

		Private $STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$nOD As Short

		Private $STATIC$optPumpType_Click_1$2031661C$busy As Short

		Private $STATIC$chkCalcPlungerSize_Click_1$202128$busy As Object

		Private $STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$nID As Short

		Private $STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$OD As String()

		Private $STATIC$cboTubingOD_SelectedIndexChanged$20211C1241$ID As String()

		Private $STATIC$cboPlungerSize_Click_1$20211C1C$PS As String()
	End Class
End Namespace
