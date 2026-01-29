Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports ChartFX.WinForms
Imports ChartFX.WinForms.Adornments
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Partial Class MotorData
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

		Friend Overridable Property pnlMotorPairs As Panel
			Get
				Return Me._pnlMotorPairs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlMotorPairs = value
			End Set
		End Property

		Friend Overridable Property btnCloseMotorPairs As Button
			Get
				Return Me._btnCloseMotorPairs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnCloseMotorPairs_Click
				If Me._btnCloseMotorPairs IsNot Nothing Then
					RemoveHandler Me._btnCloseMotorPairs.Click, value2
				End If
				Me._btnCloseMotorPairs = value
				If Me._btnCloseMotorPairs IsNot Nothing Then
					AddHandler Me._btnCloseMotorPairs.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property chtMotorPairs As Chart
			Get
				Return Me._chtMotorPairs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Chart)
				Me._chtMotorPairs = value
			End Set
		End Property

		Friend Overridable Property btnPlotMotorPairs As Button
			Get
				Return Me._btnPlotMotorPairs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnPlotMotorPairs_Click
				If Me._btnPlotMotorPairs IsNot Nothing Then
					RemoveHandler Me._btnPlotMotorPairs.Click, value2
				End If
				Me._btnPlotMotorPairs = value
				If Me._btnPlotMotorPairs IsNot Nothing Then
					AddHandler Me._btnPlotMotorPairs.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblMotor As Label
			Get
				Return Me._lblMotor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMotor = value
			End Set
		End Property

		Friend Overridable Property btnUpdateDB As Button
			Get
				Return Me._btnUpdateDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnUpdateDB_Click
				If Me._btnUpdateDB IsNot Nothing Then
					RemoveHandler Me._btnUpdateDB.Click, value2
				End If
				Me._btnUpdateDB = value
				If Me._btnUpdateDB IsNot Nothing Then
					AddHandler Me._btnUpdateDB.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblWorking As Label
			Get
				Return Me._lblWorking
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblWorking = value
			End Set
		End Property

		Friend Overridable Property btnRefresh As Button
			Get
				Return Me._btnRefresh
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnRefresh_Click
				If Me._btnRefresh IsNot Nothing Then
					RemoveHandler Me._btnRefresh.Click, value2
				End If
				Me._btnRefresh = value
				If Me._btnRefresh IsNot Nothing Then
					AddHandler Me._btnRefresh.Click, value2
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Enter, AddressOf Me.MotorData_Enter
			AddHandler MyBase.Closing, AddressOf Me.QueryUnload
			AddHandler MyBase.Leave, AddressOf Me.MotorData_Leave
			AddHandler MyBase.Load, AddressOf Me.MotorData_Load
			AddHandler MyBase.Validating, AddressOf Me.MotorData_Validating
			AddHandler MyBase.Activated, AddressOf Me.MotorData_Activated
			AddHandler MyBase.Closed, AddressOf Me.MotorData_Closed
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.MotorData_MouseDoubleClick
			AddHandler MyBase.MouseDown, AddressOf Me.MotorData_MouseDown
			AddHandler MyBase.MouseEnter, AddressOf Me.MotorData_MouseEnter
			AddHandler MyBase.MouseMove, AddressOf Me.MotorData_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.MotorData_MouseUp
			AddHandler MyBase.MouseWheel, AddressOf Me.MotorData_MouseWheel
			AddHandler MyBase.Move, AddressOf Me.MotorData_Move
			AddHandler MyBase.Scroll, AddressOf Me.MotorData_Scroll
			AddHandler MyBase.KeyPress, AddressOf Me.MotorData_KeyPress
			AddHandler MyBase.KeyUp, AddressOf Me.MotorData_KeyUp
			AddHandler MyBase.DragDrop, AddressOf Me.MotorData_DragDrop
			AddHandler MyBase.DragEnter, AddressOf Me.MotorData_DragEnter
			AddHandler MyBase.FormClosed, AddressOf Me.MotorData_FormClosed
			AddHandler MyBase.FormClosing, AddressOf Me.MotorData_FormClosing
			AddHandler MyBase.LostFocus, AddressOf Me.MotorData_LostFocus
			AddHandler MyBase.GotFocus, AddressOf Me.MotorData_GotFocus
			AddHandler MyBase.SizeChanged, AddressOf Me.MotorData_SizeChanged
			Me.bCancel = False
			Me.Reg_Motor = New RegressionObject()
			Me.sCurrentMotorID = ""
			Me.fRPMs = New Single(0) {}
			Me.fTorques = New Single(0) {}
			Me.iMotorCurveIDs = New Integer(0) {}
			Me.m_bClosing = False
			Me.m_bValidated = False
			Me.myKeyValueHT = New Hashtable()
			If MotorData.m_vb6FormDefInstance Is Nothing Then
				If MotorData.m_InitializingDefInstance Then
					MotorData.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							MotorData.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
			Me.Text = "Motor Information"
		End Sub

		Friend Overridable Property pnlMotorData As Panel
			Get
				Return Me._pnlMotorData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlMotorData = value
			End Set
		End Property

		Public Overridable Property txtElectricityCost As TextBox
			Get
				Return Me._txtElectricityCost
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtElectricityCost_Leave
				Dim value3 As EventHandler = AddressOf Me.txtElectricityCost_Enter
				Dim value4 As EventHandler = AddressOf Me.txtElectricityCost_TextChanged
				If Me._txtElectricityCost IsNot Nothing Then
					RemoveHandler Me._txtElectricityCost.Leave, value2
					RemoveHandler Me._txtElectricityCost.Enter, value3
					RemoveHandler Me._txtElectricityCost.TextChanged, value4
				End If
				Me._txtElectricityCost = value
				If Me._txtElectricityCost IsNot Nothing Then
					AddHandler Me._txtElectricityCost.Leave, value2
					AddHandler Me._txtElectricityCost.Enter, value3
					AddHandler Me._txtElectricityCost.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property cboMotorType As ComboBox
			Get
				Return Me._cboMotorType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboMotorType_Leave
				Dim value3 As EventHandler = AddressOf Me.cboMotorType_Enter
				Dim value4 As EventHandler = AddressOf Me.cboMotorType_SelectedIndexChanged
				Dim value5 As EventHandler = AddressOf Me.cboMotorType_Clicked
				If Me._cboMotorType IsNot Nothing Then
					RemoveHandler Me._cboMotorType.Leave, value2
					RemoveHandler Me._cboMotorType.Enter, value3
					RemoveHandler Me._cboMotorType.SelectedIndexChanged, value4
					RemoveHandler Me._cboMotorType.Click, value5
				End If
				Me._cboMotorType = value
				If Me._cboMotorType IsNot Nothing Then
					AddHandler Me._cboMotorType.Leave, value2
					AddHandler Me._cboMotorType.Enter, value3
					AddHandler Me._cboMotorType.SelectedIndexChanged, value4
					AddHandler Me._cboMotorType.Click, value5
				End If
			End Set
		End Property

		Public Overridable Property cboMotorSize As ComboBox
			Get
				Return Me._cboMotorSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboMotorSize_Leave
				Dim value3 As EventHandler = AddressOf Me.cboMotorSize_Enter
				Dim value4 As EventHandler = AddressOf Me.cboMotorSize_Clicked
				Dim value5 As EventHandler = AddressOf Me.cboMotorSize_SelectedIndexChanged
				If Me._cboMotorSize IsNot Nothing Then
					RemoveHandler Me._cboMotorSize.Leave, value2
					RemoveHandler Me._cboMotorSize.Enter, value3
					RemoveHandler Me._cboMotorSize.Click, value4
					RemoveHandler Me._cboMotorSize.SelectedIndexChanged, value5
				End If
				Me._cboMotorSize = value
				If Me._cboMotorSize IsNot Nothing Then
					AddHandler Me._cboMotorSize.Leave, value2
					AddHandler Me._cboMotorSize.Enter, value3
					AddHandler Me._cboMotorSize.Click, value4
					AddHandler Me._cboMotorSize.SelectedIndexChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property cboMotorSetting As ComboBox
			Get
				Return Me._cboMotorSetting
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboMotorSetting_Leave
				Dim value3 As EventHandler = AddressOf Me.cboMotorSetting_Enter
				Dim value4 As EventHandler = AddressOf Me.cboMotorSetting_Clicked
				Dim value5 As EventHandler = AddressOf Me.cboMotorSetting_SelectedIndexChanged
				If Me._cboMotorSetting IsNot Nothing Then
					RemoveHandler Me._cboMotorSetting.Leave, value2
					RemoveHandler Me._cboMotorSetting.Enter, value3
					RemoveHandler Me._cboMotorSetting.Click, value4
					RemoveHandler Me._cboMotorSetting.SelectedIndexChanged, value5
				End If
				Me._cboMotorSetting = value
				If Me._cboMotorSetting IsNot Nothing Then
					AddHandler Me._cboMotorSetting.Leave, value2
					AddHandler Me._cboMotorSetting.Enter, value3
					AddHandler Me._cboMotorSetting.Click, value4
					AddHandler Me._cboMotorSetting.SelectedIndexChanged, value5
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

		Public Overridable Property _Line_1 As Label
			Get
				Return Me.__Line_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Line_1 = value
			End Set
		End Property

		Public Overridable Property optPowerMeterType_2 As RadioButton
			Get
				Return Me._optPowerMeterType_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optPowerMeterType_1_CheckedChanged
				If Me._optPowerMeterType_2 IsNot Nothing Then
					RemoveHandler Me._optPowerMeterType_2.CheckedChanged, value2
				End If
				Me._optPowerMeterType_2 = value
				If Me._optPowerMeterType_2 IsNot Nothing Then
					AddHandler Me._optPowerMeterType_2.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property optPowerMeterType_1 As RadioButton
			Get
				Return Me._optPowerMeterType_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optPowerMeterType_1_CheckedChanged
				If Me._optPowerMeterType_1 IsNot Nothing Then
					RemoveHandler Me._optPowerMeterType_1.CheckedChanged, value2
				End If
				Me._optPowerMeterType_1 = value
				If Me._optPowerMeterType_1 IsNot Nothing Then
					AddHandler Me._optPowerMeterType_1.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property FontDialog1 As FontDialog
			Get
				Return Me._FontDialog1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FontDialog)
				Me._FontDialog1 = value
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

		Public Overridable Property chkIncludeMotorSPV As CheckBox
			Get
				Return Me._chkIncludeMotorSPV
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkIncludeMotorSPV_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.chkIncludeMotorSPV_CheckedChanged
				If Me._chkIncludeMotorSPV IsNot Nothing Then
					RemoveHandler Me._chkIncludeMotorSPV.EnabledChanged, value2
					RemoveHandler Me._chkIncludeMotorSPV.CheckedChanged, value3
				End If
				Me._chkIncludeMotorSPV = value
				If Me._chkIncludeMotorSPV IsNot Nothing Then
					AddHandler Me._chkIncludeMotorSPV.EnabledChanged, value2
					AddHandler Me._chkIncludeMotorSPV.CheckedChanged, value3
				End If
			End Set
		End Property

		Public Overridable Property txtMotorSPV As TextBox
			Get
				Return Me._txtMotorSPV
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMotorSPV_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.txtMotorSPV_Leave
				Dim value4 As EventHandler = AddressOf Me.txtMotorSPV_Enter
				Dim value5 As EventHandler = AddressOf Me.txtMotorSPV_TextChanged
				If Me._txtMotorSPV IsNot Nothing Then
					RemoveHandler Me._txtMotorSPV.EnabledChanged, value2
					RemoveHandler Me._txtMotorSPV.Leave, value3
					RemoveHandler Me._txtMotorSPV.Enter, value4
					RemoveHandler Me._txtMotorSPV.TextChanged, value5
				End If
				Me._txtMotorSPV = value
				If Me._txtMotorSPV IsNot Nothing Then
					AddHandler Me._txtMotorSPV.EnabledChanged, value2
					AddHandler Me._txtMotorSPV.Leave, value3
					AddHandler Me._txtMotorSPV.Enter, value4
					AddHandler Me._txtMotorSPV.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property chkCalcMotorSPV As CheckBox
			Get
				Return Me._chkCalcMotorSPV
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkCalcMotorSPV_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.chkCalcMotorSPV_CheckedChanged
				If Me._chkCalcMotorSPV IsNot Nothing Then
					RemoveHandler Me._chkCalcMotorSPV.EnabledChanged, value2
					RemoveHandler Me._chkCalcMotorSPV.CheckedChanged, value3
				End If
				Me._chkCalcMotorSPV = value
				If Me._chkCalcMotorSPV IsNot Nothing Then
					AddHandler Me._chkCalcMotorSPV.EnabledChanged, value2
					AddHandler Me._chkCalcMotorSPV.CheckedChanged, value3
				End If
			End Set
		End Property

		Public Overridable Property txtIrot As TextBox
			Get
				Return Me._txtIrot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtIrot_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.txtIrot_Leave
				Dim value4 As EventHandler = AddressOf Me.txtIrot_Enter
				Dim value5 As EventHandler = AddressOf Me.txtIrot_TextChanged
				If Me._txtIrot IsNot Nothing Then
					RemoveHandler Me._txtIrot.EnabledChanged, value2
					RemoveHandler Me._txtIrot.Leave, value3
					RemoveHandler Me._txtIrot.Enter, value4
					RemoveHandler Me._txtIrot.TextChanged, value5
				End If
				Me._txtIrot = value
				If Me._txtIrot IsNot Nothing Then
					AddHandler Me._txtIrot.EnabledChanged, value2
					AddHandler Me._txtIrot.Leave, value3
					AddHandler Me._txtIrot.Enter, value4
					AddHandler Me._txtIrot.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property chkCalculateIrot As CheckBox
			Get
				Return Me._chkCalculateIrot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkCalculateIrot_CheckedChanged
				If Me._chkCalculateIrot IsNot Nothing Then
					RemoveHandler Me._chkCalculateIrot.CheckedChanged, value2
				End If
				Me._chkCalculateIrot = value
				If Me._chkCalculateIrot IsNot Nothing Then
					AddHandler Me._chkCalculateIrot.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtIart As TextBox
			Get
				Return Me._txtIart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtIart_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.txtIart_Leave
				Dim value4 As EventHandler = AddressOf Me.txtIart_Enter
				Dim value5 As EventHandler = AddressOf Me.txtIart_TextChanged
				If Me._txtIart IsNot Nothing Then
					RemoveHandler Me._txtIart.EnabledChanged, value2
					RemoveHandler Me._txtIart.Leave, value3
					RemoveHandler Me._txtIart.Enter, value4
					RemoveHandler Me._txtIart.TextChanged, value5
				End If
				Me._txtIart = value
				If Me._txtIart IsNot Nothing Then
					AddHandler Me._txtIart.EnabledChanged, value2
					AddHandler Me._txtIart.Leave, value3
					AddHandler Me._txtIart.Enter, value4
					AddHandler Me._txtIart.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property _Line_2 As Label
			Get
				Return Me.__Line_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Line_2 = value
			End Set
		End Property

		Public Overridable Property _Line_3 As Label
			Get
				Return Me.__Line_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Line_3 = value
			End Set
		End Property

		Public Overridable Property _Line_4 As Label
			Get
				Return Me.__Line_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Line_4 = value
			End Set
		End Property

		Public Overridable Property _Line_5 As Label
			Get
				Return Me.__Line_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Line_5 = value
			End Set
		End Property

		Public Overridable Property _Line_6 As Label
			Get
				Return Me.__Line_6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Line_6 = value
			End Set
		End Property

		Public Overridable Property _Line_7 As Label
			Get
				Return Me.__Line_7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Line_7 = value
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

		Public Overridable Property _Label_MotorSPV As Label
			Get
				Return Me.__Label_MotorSPV
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_MotorSPV = value
			End Set
		End Property

		Public Overridable Property _Label_Irot As Label
			Get
				Return Me.__Label_Irot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_Irot = value
			End Set
		End Property

		Public Overridable Property _Label_Iart As Label
			Get
				Return Me.__Label_Iart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_Iart = value
			End Set
		End Property

		Public Overridable Property _Label_MotorType As Label
			Get
				Return Me.__Label_MotorType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_MotorType = value
			End Set
		End Property

		Public Overridable Property _Label_MeterType As Label
			Get
				Return Me.__Label_MeterType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_MeterType = value
			End Set
		End Property

		Public Overridable Property _Label_ElectricityCost As Label
			Get
				Return Me.__Label_ElectricityCost
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_ElectricityCost = value
			End Set
		End Property

		Public Overridable Property _Label_MotorSize As Label
			Get
				Return Me.__Label_MotorSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_MotorSize = value
			End Set
		End Property

		Public Overridable Property _Label_MotorSetting As Label
			Get
				Return Me.__Label_MotorSetting
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_MotorSetting = value
			End Set
		End Property

		Friend Overridable Property lblMotorSPV_Disabled As Label
			Get
				Return Me._lblMotorSPV_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMotorSPV_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblIrot_Disabled As Label
			Get
				Return Me._lblIrot_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblIrot_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblIart_Disabled As Label
			Get
				Return Me._lblIart_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblIart_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblAsterisk As Label
			Get
				Return Me._lblAsterisk
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblAsterisk = value
			End Set
		End Property

		Friend Overridable Property lblFootnote1 As Label
			Get
				Return Me._lblFootnote1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFootnote1 = value
			End Set
		End Property

		Public Shared Property DefInstance As MotorData
			Get
				If MotorData.m_vb6FormDefInstance Is Nothing OrElse MotorData.m_vb6FormDefInstance.IsDisposed Then
					MotorData.m_InitializingDefInstance = True
					MotorData.m_vb6FormDefInstance = New MotorData()
					MotorData.m_InitializingDefInstance = False
				End If
				Return MotorData.m_vb6FormDefInstance
			End Get
			Set(value As MotorData)
				MotorData.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub MotorData_Enter(sender As Object, e As EventArgs)
			If Me.WindowState = FormWindowState.Maximized Then
				Me.WindowState = FormWindowState.Normal
				Return
			End If
		End Sub

		Public Sub QueryUnload(sender As Object, e As CancelEventArgs)
			Me.bFormLoaded = False
			Me.m_bClosing = True
			If Not Me.ValidateMotorData(False) Then
				e.Cancel = True
				Return
			End If
			RSWIN_DESC.sCurrentFormName = ""
		End Sub

		Private Sub MotorData_Leave(sender As Object, e As EventArgs)
			Me.bFormLoaded = False
			Me.m_bClosing = False
		End Sub

		Private Sub MotorData_Load(sender As Object, e As EventArgs)
			Me.m_bClosing = False
			Me.m_bValidated = False
			RSWIN_DESC.sCurrentFormName = "MotorData"
			SUPERPRO.NewCheckSentinel(True)
			Me.GetMeasurementUnit()
			Me.ResetClock()
			Me.sCurrentMotorID = ""
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
			If RSWIN_DESC.bRodStarD And RSWIN_DESC.rst.PumpCondition <> 1S Then
				Me.lblAsterisk.Visible = True
				Me.lblFootnote1.Text = "* In RODSTAR-D speed variation currently only available for full pump condition."
				Me.lblFootnote1.Visible = True
				Me.chkIncludeMotorSPV.Checked = False
				Me.chkIncludeMotorSPV.Enabled = False
				Me.chkCalcMotorSPV.Checked = False
				Me.chkCalcMotorSPV.Enabled = False
				Me.txtMotorSPV.Enabled = False
			ElseIf RSWIN_DESC.rst.PU.UnitType = 6S Then
				Me.lblAsterisk.Visible = True
				Me.lblFootnote1.Text = "* Speed variation unavailable for Air-Balanced Pumping Units."
				Me.lblFootnote1.Visible = True
			Else
				Me.lblAsterisk.Visible = False
				Me.lblFootnote1.Text = ""
			End If
			Me.MotorDataLoad()
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				Me.cboMotorType_Click_1(0, False)
				Me.cboMotorType.Enabled = False
				RSWIN_DESC.rst.CalcMotorSize = -1S
				Me.cboMotorSize_Click_1(0, 0)
				Me.cboMotorSize.Visible = True
				Me.cboMotorSize.Enabled = False
			End If
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
			End If
			Me.CenterForm()
		End Sub

		Private Sub MotorDataLoad()
			Try
				Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
				Me.SetupForm()
				If RSWIN_DESC.NewData(7) <> 0S Then
					Me.InitMotorData()
				Else
					Me.LoadMotorData()
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in Load MotorData: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
			Me.bFormLoaded = True
		End Sub

		Public Sub SetupForm()
			Dim iList As Integer = 0
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim asMotorKindList As String() = rst.asMotorKindList
			Motor.GetMotorInfoList(iList, asMotorKindList)
			rst.asMotorKindList = asMotorKindList
			Me.cboMotorType.Items.Clear()
			Dim num As Integer = 0
			Dim num2 As Integer = Information.UBound(RSWIN_DESC.rst.asMotorKindList, 1)
			For i As Integer = num To num2
				Me.cboMotorType.Items.Add(New ListBoxItem(RSWIN_DESC.rst.asMotorKindList(i), i))
			Next
		End Sub

		Public Sub cboMotorSize_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.Control_SelectedIndexChanged(Me.cboMotorSize Is Me.ActiveControl)
			If Me.cboMotorSizebClicked Then
				Me.cboMotorSize_Click_1(Me.cboMotorSize.SelectedIndex, -1)
			End If
		End Sub

		Public Sub cboMotorSize_Click_1(iListIndex As Integer, bClicked As Integer)
			Me.cboMotorSizebClicked = (bClicked <> 0)
			If Me.cboMotorSize.Items.Count > 0 And Me.cboMotorSize.SelectedIndex <> iListIndex Then
				Me.cboMotorSizebClicked = False
				Me.cboMotorSize.SelectedIndex = iListIndex
			End If
			If iListIndex < 0 Then
				Me.cboMotorSetting.Visible = False
				Me._Label_MotorSetting.Visible = False
			Else
				Dim flag As Boolean = True
				If Conversions.ToBoolean(Operators.NotObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)))) Then
					Motor.SelectMotorSize(iListIndex)
					ini.SaveDataValue("MotorSize", RuntimeHelpers.GetObjectValue(Motor.GetMotorInfo(3)))
					RSWIN_DESC.rst.CalcMotorSize = 0S
					ini.SaveDataValue("CalcMotorSize", RSWIN_DESC.rst.CalcMotorSize)
				Else
					If Strings.InStr(Support.GetItemString(Me.cboMotorSize, 0), "recommendation", CompareMethod.Binary) > 0 Then
						iListIndex -= 1
					End If
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					If iListIndex < 0 Then
						rst.CalcMotorSize = -1S
						ini.SaveDataValue("CalcMotorSize", rst.CalcMotorSize)
						flag = False
					Else
						If iListIndex >= 0 Then
							rst.CalcMotorSize = 0S
						Else
							rst.CalcMotorSize = -1S
						End If
						Motor.SelectMotorSize(iListIndex)
						ini.SaveDataValue("MotorSize", RuntimeHelpers.GetObjectValue(Motor.GetMotorInfo(3)))
						If bClicked <> 0 Then
							ini.SaveDataValue("MotorSetting", VariantType.Null)
						End If
						ini.SaveDataValue("CalcMotorSize", False)
					End If
				End If
				If flag Then
					Dim array As String()
					Motor.GetMotorInfoList(2, array)
					Me.cboMotorSetting.Items.Clear()
					Dim num As Integer = 0
					Dim num2 As Integer = Information.UBound(array, 1)
					For i As Integer = num To num2
						Me.cboMotorSetting.Items.Add(array(i))
					Next
				End If
				If Me.cboMotorSetting.Items.Count <= 1 Then
					Me.cboMotorSetting.Visible = False
					Me._Label_MotorSetting.Visible = False
					If Me.cboMotorSetting.Items.Count = 1 Then
						Me.cboMotorSetting_Click_1(0, bClicked <> 0)
					End If
				Else
					Me.cboMotorSetting.Visible = True
					Me._Label_MotorSetting.Visible = True
				End If
			End If
			Dim flag2 As Boolean = Me.ValidateMotorData(True)
		End Sub

		Public Sub cboMotorType_Click_1(iListIndex As Integer, bClicked As Boolean)
			Me.cboMotorTypebClicked = bClicked
			Me.cboMotorSetting.Visible = False
			Me._Label_MotorSetting.Visible = False
			If Me.cboMotorType.SelectedIndex <> iListIndex Then
				Me.cboMotorType.SelectedIndex = iListIndex
			End If
			Dim num As Integer = Conversions.ToInteger(Motor.GetMotorInfo(4))
			Dim num2 As Integer
			If iListIndex >= 0 Then
				ini.SaveDataValue("MotorType", Support.GetItemData(Me.cboMotorType, iListIndex))
				If bClicked Then
					ini.SaveDataValue("MotorSize", VariantType.Null)
					ini.SaveDataValue("MotorSetting", VariantType.Null)
				End If
				Motor.SelectMotorKind(Support.GetItemData(Me.cboMotorType, iListIndex))
				num2 = Conversions.ToInteger(Motor.GetMotorInfo(4))
			End If
			If num2 <> 0 And (num2 <> num Or Me.cboMotorSize.Items.Count = 0) Then
				Dim array As String()
				Motor.GetMotorInfoList(1, array)
				Me.cboMotorSize.Items.Clear()
				If num2 = 1 Or num2 = 7 Or num2 >= 8 Then
					If RSWIN_DESC.bExpert Then
						Me.cboMotorSize.Items.Add("XROD-V recommendation")
					Else
						Me.cboMotorSize.Items.Add("RODSTAR recommendation")
					End If
					If Me.ActiveControl Is Me.cboMotorType Then
						RSWIN_DESC.rst.miMotorSize = 0S
						RSWIN_DESC.rst.miMotorSetting = 0S
					End If
				End If
				Dim num3 As Integer = 0
				Dim num4 As Integer = Information.UBound(array, 1)
				For i As Integer = num3 To num4
					Me.cboMotorSize.Items.Add(array(i))
				Next
				Me.cboMotorSize_Click_1(-1, 0)
				If num2 = 1 Or num2 = 7 Or num2 >= 8 Then
					If bClicked Then
						If(num2 = 1 And num <> 1) Or (num2 = 7 And num <> 7) Or (num2 >= 8 And num < 8) Then
							Me.cboMotorSize_Click_1(0, 0)
						End If
					End If
				Else
					RSWIN_DESC.rst.CalcMotorSize = 0S
				End If
			End If
			Me.cboMotorSize.Visible = True
			Me._Label_MotorSize.Visible = True
			If num2 <> num Then
				Me.cboMotorSetting.Visible = False
				Me._Label_MotorSetting.Visible = False
			End If
			Dim flag As Boolean = Me.ValidateMotorData(True)
		End Sub

		Public Sub InitMotorData()
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("CalcMotorSize", 11, False, True))
				rst.ElectricityCost = Conversions.ToSingle(ini.GetDataValue("ElectricityCost", 4, True, 0.06))
				Me.txtElectricityCost.Text = Conversions.ToString(rst.ElectricityCost)
				If Operators.ConditionalCompareObjectEqual(ini.GetDataValue("PowerMeterType", 3, False, 1), 1, False) Then
					Me.optPowerMeterType_1.Checked = True
					Me.optPowerMeterType_2.Checked = False
				ElseIf Operators.ConditionalCompareObjectEqual(ini.GetDataValue("PowerMeterType", 3, False, 1), 2, False) Then
					Me.optPowerMeterType_1.Checked = False
					Me.optPowerMeterType_2.Checked = True
				End If
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("MotorType", 3, False, DBNull.Value))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue2)) Then
					objectValue2 = RuntimeHelpers.GetObjectValue(ini.GetListDefault("MotorType", 0, 5))
				End If
				Dim objectValue5 As Object
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue2)) Then
					Me.cboMotorType_Click_1(-1, False)
					Me.cboMotorSize.Visible = False
					Me.cboMotorSetting.Visible = False
					Me._Label_MotorSize.Visible = False
					Me.cboMotorSetting.Visible = False
					Me._Label_MotorSetting.Visible = False
				Else
					Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("MotorSize", 8, False, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) AndAlso Operators.ConditionalCompareObjectEqual(obj, "Null", False) Then
						obj = DBNull.Value
					End If
					Dim obj2 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("MotorSetting", 8, False, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj2)) AndAlso Operators.ConditionalCompareObjectEqual(obj2, "Null", False) Then
						obj2 = DBNull.Value
					End If
					Dim num As Integer = 0
					Dim num2 As Integer = Me.cboMotorType.Items.Count - 1
					For i As Integer = num To num2
						If Support.GetItemData(Me.cboMotorType, i) = Conversions.ToInteger(objectValue2) Then
							Me.cboMotorType_Click_1(i, False)
							Exit For
						End If
					Next
					Dim num3 As Integer = Conversions.ToInteger(Motor.GetMotorInfo(4))
					If Conversions.ToBoolean(Operators.AndObject(num3 = 1 Or num3 = 7 Or num3 >= 8, objectValue)) Then
						rst.CalcMotorSize = Conversions.ToShort(objectValue)
						Me.cboMotorSize_Click_1(0, 0)
					Else
						rst.CalcMotorSize = 0S
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							Motor.SelectMotorSizeByName(Conversions.ToString(obj))
							Me.cboMotorSize_Click_1(Me.cboMotorSize.Items.IndexOf(RuntimeHelpers.GetObjectValue(obj)), 0)
							If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj2)) Then
								If Operators.ConditionalCompareObjectEqual(Motor.GetMotorInfo(6), 1, False) Then
									Motor.SelectMotorSettingByTorqueMode(1)
								End If
							Else
								Motor.SelectMotorSettingByName(Conversions.ToString(obj2))
								If Strings.Len(RuntimeHelpers.GetObjectValue(obj2)) = 0 Then
									Me.cboMotorSetting_Click_1(0, False)
								Else
									Me.cboMotorSetting_Click_1(Me.cboMotorSetting.Items.IndexOf(RuntimeHelpers.GetObjectValue(obj2)), False)
								End If
							End If
						End If
					End If
				End If
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("CalcMotorSize", 11, False, True))
				Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("CalcMotorSPV", 11, False, False))
				Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("MotorSPV", 4, False, 0))
				objectValue5 = RuntimeHelpers.GetObjectValue(ini.GetDataValue("Iart", 4, False, RSWIN_DESC.rst.PU.ArtInertia))
				Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("IrotEntered", 11, False, True))
				rst.CalcMotorSPV = Conversions.ToShort(objectValue3)
				rst.MotorSPV = Conversions.ToSingle(objectValue4)
				rst.IrotEntered = Conversions.ToShort(objectValue6)
				If rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Or rst.PU.UnitType = 6S Then
					Me.chkIncludeMotorSPV.Enabled = False
				ElseIf(If((-If((rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or rst.CalcMotorSPV) <> 0S Then
					Me.mbSavedCalcMotorSPV = (rst.CalcMotorSPV <> 0S)
					Me.mbSavedIrotEntered = (rst.IrotEntered <> 0S)
					RSWIN_DESC.rst.IrotEntered = Conversions.ToShort(ini.GetDataValue("IrotEntered", 11, False, False))
					Me.txtMotorSPV.Text = Conversions.ToString(RSWIN_DESC.rst.MotorSPV * 100F)
				Else
					rst.CalcMotorSPV = -1S
					rst.IrotEntered = 0S
					Me.txtMotorSPV.Text = "8"
					Me.mbSavedCalcMotorSPV = (rst.CalcMotorSPV <> 0S)
					Me.mbSavedIrotEntered = (rst.IrotEntered <> 0S)
					Me.chkIncludeMotorSPV_Click_1(False, False)
				End If
				Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("Irot", 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue7)) Then
					rst.Irot = Conversions.ToSingle(objectValue7)
					Me.txtIrot.Text = Conversions.ToString(RSWIN_DESC.rst.Irot)
				End If
				rst.Iart = Conversions.ToSingle(objectValue5)
				Me.txtIart.Text = Conversions.ToString(RSWIN_DESC.rst.Iart)
				If rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Or rst.PU.UnitType = 6S Then
					Me.chkIncludeMotorSPV.Enabled = False
				Else
					Me.chkIncludeMotorSPV.Enabled = True
				End If
				Me.EnabledMotorSPVControls(Me.chkIncludeMotorSPV.Checked)
				If Me.chkIncludeMotorSPV.Checked Then
					If Me.chkCalcMotorSPV.Enabled Then
						If Not Me.chkCalcMotorSPV.Checked Then
							Me.txtMotorSPV.Enabled = True
						Else
							Me.txtMotorSPV.Enabled = False
						End If
					End If
					If Me.chkCalculateIrot.Enabled Then
						If Not Me.chkCalculateIrot.Checked Then
							Me.txtIrot.Enabled = True
							Me.txtIart.Enabled = True
						Else
							Me.txtIrot.Enabled = False
							Me.txtIart.Enabled = True
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub InitMotorData_OLD()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("CalcMotorSize", 11, False, True))
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("CalcMotorSPV", 11, False, False))
			Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("MotorSPV", 4, False, 0))
			Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("Iart", 4, False, rst.PU.ArtInertia))
			Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("IrotEntered", 11, False, True))
			Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("MotorSetting", 8, False, VariantType.Null))
			Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("MotorSize", 8, False, VariantType.Null))
			rst.ElectricityCost = Conversions.ToSingle(ini.GetDataValue("ElectricityCost", 4, True, 0.06))
			Me.txtElectricityCost.Text = Conversions.ToString(rst.ElectricityCost)
			If Operators.ConditionalCompareObjectEqual(ini.GetDataValue("PowerMeterType", 3, False, 1), 1, False) Then
				Me.optPowerMeterType_1.Checked = True
				Me.optPowerMeterType_2.Checked = False
			ElseIf Operators.ConditionalCompareObjectEqual(ini.GetDataValue("PowerMeterType", 3, False, 1), 2, False) Then
				Me.optPowerMeterType_1.Checked = False
				Me.optPowerMeterType_2.Checked = True
			End If
			Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("MotorType", 3, False, VariantType.Null))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue8)) Then
				objectValue8 = RuntimeHelpers.GetObjectValue(ini.GetListDefault("MotorType", 0, 5))
			End If
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue8)) Then
				Me.cboMotorType_Click_1(-1, False)
				Me.cboMotorSize.Visible = False
				Me._Label_MotorSize.Visible = False
				Me.cboMotorSetting.Visible = False
				Me._Label_MotorSetting.Visible = False
			Else
				objectValue7 = RuntimeHelpers.GetObjectValue(ini.GetDataValue("MotorSize", 8, False, VariantType.Null))
				objectValue6 = RuntimeHelpers.GetObjectValue(ini.GetDataValue("MotorSetting", 8, False, VariantType.Null))
				Dim num As Integer = 0
				Dim num2 As Integer = Me.cboMotorType.Items.Count - 1
				For i As Integer = num To num2
					If Support.GetItemData(Me.cboMotorType, i) = Conversions.ToInteger(objectValue8) Then
						Me.cboMotorType_Click_1(i, False)
						Exit For
					End If
				Next
				Dim num3 As Integer = Conversions.ToInteger(Motor.GetMotorInfo(4))
				If Conversions.ToBoolean(Operators.AndObject(num3 = 1 Or num3 = 7 Or num3 >= 8, objectValue)) Then
					rst.CalcMotorSize = Conversions.ToShort(objectValue)
					Me.cboMotorSize_Click_1(0, 0)
				Else
					rst.CalcMotorSize = 0S
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue7)) Then
						Motor.SelectMotorSizeByName(Conversions.ToString(objectValue7))
						Me.cboMotorSize_Click_1(Me.cboMotorSize.Items.IndexOf(RuntimeHelpers.GetObjectValue(objectValue7)), 0)
						If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue6)) Then
							If Operators.ConditionalCompareObjectEqual(Motor.GetMotorInfo(6), 1, False) Then
								Motor.SelectMotorSettingByTorqueMode(1)
							End If
						Else
							Motor.SelectMotorSettingByName(Conversions.ToString(objectValue6))
							If Strings.Len(RuntimeHelpers.GetObjectValue(objectValue6)) = 0 Then
								Me.cboMotorSetting_Click_1(0, False)
							Else
								Me.cboMotorSize_Click_1(Me.cboMotorSetting.Items.IndexOf(RuntimeHelpers.GetObjectValue(objectValue6)), 0)
							End If
						End If
					End If
				End If
			End If
		End Sub

		Public Function IsUHS(MotorType As Object) As Object
			Return Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(MotorType, 3, False), Operators.CompareObjectEqual(MotorType, 2, False)), Operators.CompareObjectEqual(MotorType, 4, False))
		End Function

		Public Sub cboMotorSetting_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.Control_SelectedIndexChanged(Me.cboMotorSetting Is Me.ActiveControl)
			If Me.cboMotorSettingbClicked Then
				Me.cboMotorSetting_Click_1(Me.cboMotorSetting.SelectedIndex, True)
				Return
			End If
		End Sub

		Private Sub cboMotorSetting_Clicked(sender As Object, e As EventArgs)
			Me.cboMotorSettingbClicked = True
		End Sub

		Public Sub cboMotorSetting_Click_1(iListIndex As Integer, bClicked As Boolean)
			Me.cboMotorSettingbClicked = bClicked
			If Me.cboMotorSetting.Items.Count > 0 And Me.cboMotorSetting.SelectedIndex <> iListIndex Then
				Me.cboMotorSetting.SelectedIndex = iListIndex
			End If
			If bClicked Then
				Motor.SelectMotorSetting(iListIndex)
				ini.SaveDataValue("MotorSetting", RuntimeHelpers.GetObjectValue(Motor.GetMotorInfo(2)))
			End If
			Dim flag As Boolean = Me.ValidateMotorData(True)
		End Sub

		Public Sub LoadMotorData()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If RSWIN_DESC.bRodStarD And RSWIN_DESC.rst.PumpCondition <> 1S Then
				rst.CalcMotorSPV = 0S
				rst.MotorSPV = 0F
				rst.IrotEntered = 0S
			End If
			Me.mbSavedCalcMotorSPV = (rst.CalcMotorSPV <> 0S)
			Me.mbSavedIrotEntered = (rst.IrotEntered <> 0S)
			Me.txtElectricityCost.Text = Conversions.ToString(rst.ElectricityCost)
			If rst.PowerMeterType = 1S Then
				Me.optPowerMeterType_1.Checked = True
				Me.optPowerMeterType_2.Checked = False
			Else
				Me.optPowerMeterType_1.Checked = False
				Me.optPowerMeterType_2.Checked = True
			End If
			Dim num As Integer = Conversions.ToInteger(Motor.GetMotorInfo(4))
			Dim num2 As Integer = 0
			Dim count As Integer = Me.cboMotorType.Items.Count
			For i As Integer = num2 To count
				If Support.GetItemData(Me.cboMotorType, i) = num - 1 Then
					Me.cboMotorType_Click_1(i, False)
					Exit For
				End If
			Next
			If(If((-If(((num = 1 Or num = 7 Or num >= 8) > False), 1S, 0S)), 1S, 0S) And rst.CalcMotorSize) <> 0S Then
				Me.cboMotorSize_Click_1(0, 0)
			Else
				Me.cboMotorSize_Click_1(Me.cboMotorSize.Items.IndexOf(RuntimeHelpers.GetObjectValue(Motor.GetMotorInfo(3))), 0)
				Dim text As String = Conversions.ToString(Motor.GetMotorInfo(2))
				If Strings.Len(text) = 0 Then
					Me.cboMotorSetting_Click_1(0, False)
				Else
					Dim num3 As Integer = Me.cboMotorSetting.Items.IndexOf(text)
					If num3 >= 0 Then
						Me.cboMotorSetting_Click_1(num3, True)
					Else
						num3 = Me.CheckMotorSetting(Me.cboMotorSetting, text)
						If num3 >= 0 Then
							Me.cboMotorSetting_Click_1(num3, True)
						End If
					End If
				End If
			End If
			If Me.cboMotorType.SelectedIndex = -1 Then
				Me.cboMotorType.BackColor = RSWIN_DESC.rgbEditRequired
			Else
				Me.cboMotorType.BackColor = Color.White
			End If
			If(If((-If(((Not RSWIN_DESC.bRodStarD And rst.MotorSPV > 0F) > False), 1S, 0S)), 1S, 0S) Or rst.CalcMotorSPV Or (If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And (If((-If((rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or rst.CalcMotorSPV) And If((-If(((RSWIN_DESC.rst.PumpCondition = 1S) > False), 1S, 0S)), 1S, 0S))) <> 0S Then
				Me.mbSavedCalcMotorSPV = (rst.CalcMotorSPV <> 0S)
				Me.mbSavedIrotEntered = (rst.IrotEntered <> 0S)
				Me.chkCalcMotorSPV.Checked = (rst.CalcMotorSPV <> 0S)
				Dim txtMotorSPV As TextBox = Me.txtMotorSPV
				Dim num4 As Single = rst.MotorSPV * 100F
				Dim text2 As String = "#####.##"
				txtMotorSPV.Text = Util.Format(num4, text2)
				Me.chkIncludeMotorSPV.Checked = True
				Me.chkIncludeMotorSPV_Click_1(True, False)
			Else
				rst.CalcMotorSPV = -1S
				rst.IrotEntered = 0S
				Me.txtMotorSPV.Text = "8"
				Me.chkIncludeMotorSPV.Checked = False
				Me.chkIncludeMotorSPV_Click_1(False, False)
			End If
			Me.txtIrot.Text = Convert.ToString(rst.Irot)
			Me.txtIart.Text = Convert.ToString(rst.Iart)
			If rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Or rst.PU.UnitType = 6S Then
				Me.chkIncludeMotorSPV.Enabled = False
			ElseIf Not RSWIN_DESC.bRodStarD Or (RSWIN_DESC.bRodStarD And RSWIN_DESC.rst.PumpCondition = 1S) Then
				Me.chkIncludeMotorSPV.Enabled = True
			End If
			Me.EnabledMotorSPVControls(Me.chkIncludeMotorSPV.Checked)
		End Sub

		Private Sub MotorData_Validating(sender As Object, e As CancelEventArgs)
			Dim flag As Boolean = Me.ValidateMotorData(True)
		End Sub

		Public Function ValidateMotorData(Optional bQuiet As Boolean = True) As Boolean
			If Me.MyParentFrm Is Nothing Then
				Try
					Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
				Catch ex As Exception
				End Try
			End If
			If Me.MyParentFrm Is Nothing Then
				Return True
			End If
			If Not Me.MyParentFrm.bClosing Then
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Me.optPowerMeterType_1.Checked Then
					rst.PowerMeterType = 1S
				ElseIf Me.optPowerMeterType_2.Checked Then
					rst.PowerMeterType = 2S
				End If
				Dim flag As Boolean = Me.CheckMotorData(bQuiet)
				RSWIN_DESC.frmMain.ToolbarButtonSetState(16, flag)
				Return flag
			End If
			Return True
		End Function

		Private Function CheckMotorData(bQuiet As Boolean) As Boolean
			Dim flag As Boolean = True
			If bQuiet Then
				If Me.txtElectricityCost.Text.Trim().Length = 0 Then
					flag = False
				ElseIf Me.cboMotorType.SelectedIndex < 0 Then
					flag = False
				ElseIf Me.cboMotorSize.SelectedIndex < 0 Then
					flag = False
				ElseIf Me.cboMotorSetting.Visible And Me.cboMotorSetting.SelectedIndex < 0 Then
					flag = False
				End If
				Return flag
			End If
			Dim text As String = "select"
			RSWIN_DESC.sNull = ""
			If Me.txtElectricityCost.Text.Trim().Length = 0 Then
				Dim text2 As String = "electricity cost"
				text = "enter"
				flag = False
				Dim sMsg As String = String.Concat(New String() { "Please ", text, " the ", text2, "." })
				Me.DisplayMotorDataError(sMsg, Me.bCancel)
				If Not Me.bCancel Then
					Me.txtElectricityCost.Focus()
					Return False
				End If
			ElseIf Me.cboMotorType.SelectedIndex < 0 Then
				Dim text2 As String = "motor type"
				flag = False
				Dim sMsg As String = String.Concat(New String() { "Please ", text, " the ", text2, "." })
				Me.DisplayMotorDataError(sMsg, Me.bCancel)
				If Not Me.bCancel Then
					Me.cboMotorType.Focus()
					Return False
				End If
			ElseIf Me.cboMotorSize.SelectedIndex < 0 Then
				Dim text2 As String = "motor size"
				flag = False
				Dim sMsg As String = String.Concat(New String() { "Please ", text, " the ", text2, "." })
				Me.DisplayMotorDataError(sMsg, Me.bCancel)
				If Not Me.bCancel Then
					Me.cboMotorSize.Focus()
					Return False
				End If
			ElseIf Me.cboMotorSetting.Visible And Me.cboMotorSetting.SelectedIndex < 0 Then
				Dim text2 As String = "torque mode"
				flag = False
				Dim sMsg As String = String.Concat(New String() { "Please ", text, " the ", text2, "." })
				Me.DisplayMotorDataError(sMsg, Me.bCancel)
				If Not Me.bCancel Then
					Me.cboMotorSetting.Focus()
					Return False
				End If
			End If
			Me.m_bValidated = True
			If(RSWIN_DESC.NewData(7) And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				RSWIN_DESC.NewData(7) = 0S
				ini.SaveDataValue("MotorData", True)
			End If
			Return True
		End Function

		Private Sub cboMotorType_Clicked(sender As Object, e As EventArgs)
			Me.cboMotorTypebClicked = True
		End Sub

		Private Sub cboMotorSize_Clicked(sender As Object, e As EventArgs)
			Me.cboMotorSizebClicked = True
		End Sub

		Private Sub cboMotorType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.Control_SelectedIndexChanged(Me.cboMotorType Is Me.ActiveControl)
			If Me.cboMotorType.SelectedIndex = -1 Then
				Me.cboMotorType.BackColor = RSWIN_DESC.rgbEditRequired
			Else
				Me.cboMotorType.BackColor = Color.White
			End If
			If Me.cboMotorTypebClicked Then
				Me.cboMotorType_Click_1(Me.cboMotorType.SelectedIndex, True)
			End If
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

		Private Sub txtElectricityCost_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = flag
			Dim txtElectricityCost As TextBox = Me.txtElectricityCost
			Dim bValidIfEmpty As Boolean = 1
			Dim bShowMessage As Boolean = 0
			Dim num As Single
			Dim obj As Object = num
			Dim flag3 As Boolean = CtrlUI.CheckValid(txtElectricityCost, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			Dim txtElectricityCost2 As TextBox
			Dim label_ElectricityCost As Label
			If flag2 <> flag3 Then
				txtElectricityCost2 = Me.txtElectricityCost
				label_ElectricityCost = Me._Label_ElectricityCost
				CtrlUI.TextBox_LostFocus(txtElectricityCost2, label_ElectricityCost, True)
				Me._Label_ElectricityCost = label_ElectricityCost
				Me.txtElectricityCost = txtElectricityCost2
				ini.SaveDataValue("ElectricityCost", num)
				If Me.txtElectricityCost.Text.Trim().Length > 0 Then
					RSWIN_DESC.rst.ElectricityCost = num
				End If
			End If
			txtElectricityCost2 = Me.txtElectricityCost
			label_ElectricityCost = Me._Label_ElectricityCost
			Me.TextBox_Change(txtElectricityCost2, label_ElectricityCost)
			Me._Label_ElectricityCost = label_ElectricityCost
			Me.txtElectricityCost = txtElectricityCost2
		End Sub

		Private Sub optPowerMeterType_1_CheckedChanged(sender As Object, e As EventArgs)
			If Me.optPowerMeterType_1.Checked Then
				RSWIN_DESC.rst.PowerMeterType = 1S
			ElseIf Me.optPowerMeterType_2.Checked Then
				RSWIN_DESC.rst.PowerMeterType = 2S
			End If
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.optPowerMeterType_1 Or Me.ActiveControl Is Me.optPowerMeterType_2)
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

		Private Sub txtElectricityCost_Enter(sender As Object, e As EventArgs)
			Me.txtElectricityCost.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtElectricityCost_Leave(sender As Object, e As EventArgs)
			Dim txtElectricityCost As Control = Me.txtElectricityCost
			CtrlUI.Control_LostFocus(txtElectricityCost)
			Me.txtElectricityCost = CType(txtElectricityCost, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtElectricityCost, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 0F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 98
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtElectricityCost.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 10F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 97
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtElectricityCost.Focus()
					Else
						Dim txtElectricityCost2 As TextBox = Me.txtElectricityCost
						Dim label_ElectricityCost As Label = Me._Label_ElectricityCost
						CtrlUI.TextBox_LostFocus(txtElectricityCost2, label_ElectricityCost, True)
						Me._Label_ElectricityCost = label_ElectricityCost
						Me.txtElectricityCost = txtElectricityCost2
						ini.SaveDataValue("ElectricityCost", RuntimeHelpers.GetObjectValue(obj))
						If Me.txtElectricityCost.Text.Trim().Length > 0 Then
							RSWIN_DESC.rst.ElectricityCost = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub cboMotorType_Enter(sender As Object, e As EventArgs)
			Me.cboMotorType.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboMotorType_Leave(sender As Object, e As EventArgs)
			Dim cboMotorType As Control = Me.cboMotorType
			CtrlUI.Control_LostFocus(cboMotorType)
			Me.cboMotorType = CType(cboMotorType, ComboBox)
		End Sub

		Private Sub cboMotorSize_Enter(sender As Object, e As EventArgs)
			Me.cboMotorSize.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboMotorSize_Leave(sender As Object, e As EventArgs)
			Dim cboMotorSize As Control = Me.cboMotorSize
			CtrlUI.Control_LostFocus(cboMotorSize)
			Me.cboMotorSize = CType(cboMotorSize, ComboBox)
		End Sub

		Private Sub cboMotorSetting_Enter(sender As Object, e As EventArgs)
			Me.cboMotorSetting.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboMotorSetting_Leave(sender As Object, e As EventArgs)
			Dim cboMotorSetting As Control = Me.cboMotorSetting
			CtrlUI.Control_LostFocus(cboMotorSetting)
			Me.cboMotorSetting = CType(cboMotorSetting, ComboBox)
		End Sub

		Private Sub chkIncludeMotorSPV_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkIncludeMotorSPV Then
				Dim chkIncludeMotorSPV As CheckBox = Me.chkIncludeMotorSPV
				Me.chkIncludeMotorSPV_Click_1(chkIncludeMotorSPV.Checked, True)
				Me.EnabledMotorSPVControls(chkIncludeMotorSPV.Checked)
				Try
					If Operators.CompareString(Me.txtIart.Text.Trim(), "", False) = 0 Then
						If RSWIN_DESC.rst.Iart <> 0F Then
							Me.txtIart.Text = Convert.ToString(RSWIN_DESC.rst.Iart)
						ElseIf RSWIN_DESC.rst.PU.ArtInertia <> 0F Then
							Me.txtIart.Text = Conversions.ToString(RSWIN_DESC.rst.PU.ArtInertia)
						End If
					End If
				Catch ex As Exception
				End Try
				Try
					If Operators.CompareString(Me.txtIrot.Text.Trim(), "", False) = 0 AndAlso RSWIN_DESC.rst.Irot <> 0F Then
						Me.txtIrot.Text = Convert.ToString(RSWIN_DESC.rst.Irot)
					End If
				Catch ex2 As Exception
				End Try
				Me.Control_SelectedIndexChanged(True)
				Return
			End If
		End Sub

		Private Sub chkIncludeMotorSPV_Click_1(Checked As Boolean, Clicked As Boolean)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Not Checked Or (RSWIN_DESC.bRodStarD And RSWIN_DESC.rst.PumpCondition <> 1S) Then
				Me.mbSavedCalcMotorSPV = (rst.CalcMotorSPV <> 0S)
				Me.mbSavedIrotEntered = (rst.IrotEntered <> 0S)
				rst.MotorSPV = 0F
				Me.chkCalcMotorSPV.Checked = False
				Me.chkCalcMotorSPV_Click_1(False, False)
				Me.chkCalculateIrot.Checked = False
				Me.chkCalculateIrot_Click_1(False, False)
				Me.chkCalcMotorSPV.Enabled = False
				Me.txtMotorSPV.Enabled = False
				Me.chkCalculateIrot.Enabled = False
				Me.txtIrot.Enabled = False
				Me.txtIart.Enabled = False
				ini.SaveDataValue("CalcMotorSPV", False)
				ini.SaveDataValue("MotorSPV", DBNull.Value)
				ini.SaveDataValue("IrotEntered", DBNull.Value)
				ini.SaveDataValue("Irot", DBNull.Value)
				ini.SaveDataValue("Iart", DBNull.Value)
			Else
				rst.CalcMotorSPV = If((-If((Me.mbSavedCalcMotorSPV > False), 1S, 0S)), 1S, 0S)
				rst.IrotEntered = If((-If((Me.mbSavedIrotEntered > False), 1S, 0S)), 1S, 0S)
				If(Util.ValidNumber(Me.txtMotorSPV.Text, 0S) And If((-If((Strings.Len(Strings.Trim(Me.txtMotorSPV.Text)) > 0 > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					rst.MotorSPV = Convert.ToSingle(Me.txtMotorSPV.Text) / 100F
					If Clicked Then
						ini.SaveDataValue("MotorSPV", rst.MotorSPV)
					End If
				End If
				Me.chkCalcMotorSPV.Checked = (rst.CalcMotorSPV <> 0S)
				Me.chkCalcMotorSPV_Click_1(rst.CalcMotorSPV <> 0S, False)
				Me.chkCalcMotorSPV.Enabled = True
				Me.chkCalculateIrot.Checked = (Not rst.IrotEntered <> 0S)
				Me.chkCalculateIrot_Click_1(Not rst.IrotEntered <> 0S, False)
				Me.chkCalculateIrot.Enabled = True
				Me.txtIart.Enabled = True
				ini.SaveDataValue("CalcMotorSPV", rst.CalcMotorSPV)
				ini.SaveDataValue("IrotEntered", rst.IrotEntered)
				ini.SaveDataValue("Irot", rst.Irot)
				ini.SaveDataValue("Iart", rst.Iart)
			End If
			RSWIN_DESC.WarnedAboutUHSMotor = 0S
		End Sub

		Private Sub chkCalcMotorSPV_Click_1(Checked As Boolean, Clicked As Boolean)
			RSWIN_DESC.rst.CalcMotorSPV = If((-If((Checked > False), 1S, 0S)), 1S, 0S)
			If Clicked Then
				ini.SaveDataValue("CalcMotorSPV", RSWIN_DESC.rst.CalcMotorSPV)
			End If
			If Not RSWIN_DESC.bRodStarD Then
				Me.txtMotorSPV.Enabled = (Not Checked And Me.chkIncludeMotorSPV.Checked)
				Return
			End If
			If RSWIN_DESC.rst.PumpCondition = 1S And Not Checked And Me.chkIncludeMotorSPV.Checked Then
				Me.txtMotorSPV.Enabled = True
				Return
			End If
			Me.txtMotorSPV.Enabled = False
		End Sub

		Private Sub chkCalcMotorSPV_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkCalcMotorSPV Then
				Me.chkCalcMotorSPV_Click_1(Me.chkCalcMotorSPV.Checked, True)
				Me.Control_SelectedIndexChanged(True)
				If Not Me.chkCalcMotorSPV.Checked Then
					Me.txtMotorSPV.Enabled = True
				Else
					Me.txtMotorSPV.Enabled = False
				End If
				Me.Refresh()
				Application.DoEvents()
				Return
			End If
		End Sub

		Public Sub EnabledMotorSPVControls(bVal As Boolean)
			If RSWIN_DESC.bRodStarD And RSWIN_DESC.rst.PumpCondition <> 1S Then
				Me.chkCalcMotorSPV.Enabled = False
				Me.chkCalculateIrot.Enabled = False
				Me.txtMotorSPV.Enabled = False
				Me.txtIrot.Enabled = False
				Me.txtIart.Enabled = False
			ElseIf Not bVal Then
				Me.chkCalcMotorSPV.Enabled = bVal
				Me.chkCalculateIrot.Enabled = bVal
				Me.txtMotorSPV.Enabled = bVal
				Me.txtIrot.Enabled = bVal
				Me.txtIart.Enabled = bVal
			Else
				Me.chkCalcMotorSPV.Enabled = bVal
				If Not Me.chkCalcMotorSPV.Checked Then
					Me.txtMotorSPV.Enabled = True
				Else
					Me.txtMotorSPV.Enabled = False
				End If
				If Not Me.chkCalculateIrot.Checked Then
					Me.txtIrot.Enabled = True
					Me.txtIart.Enabled = True
				Else
					Me.txtIrot.Enabled = False
					Me.txtIart.Enabled = True
				End If
			End If
			Me.Refresh()
			Application.DoEvents()
		End Sub

		Private Sub chkCalculateIrot_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkCalculateIrot Then
				Me.chkCalculateIrot_Click_1(Me.chkCalculateIrot.Checked, True)
				Me.Control_SelectedIndexChanged(True)
				If Not Me.chkCalculateIrot.Checked Then
					Me.txtIrot.Enabled = True
					Me.txtIart.Enabled = True
				Else
					Me.txtIrot.Enabled = False
					Me.txtIart.Enabled = True
				End If
				Me.Refresh()
				Application.DoEvents()
				Return
			End If
		End Sub

		Private Sub chkCalculateIrot_Click_1(Checked As Boolean, Clicked As Boolean)
			RSWIN_DESC.rst.IrotEntered = If((-If((Not Checked > False), 1S, 0S)), 1S, 0S)
			If Clicked Then
				ini.SaveDataValue("IrotEntered", RSWIN_DESC.rst.IrotEntered)
			End If
			Me.txtIrot.Enabled = (Not Checked And Me.chkIncludeMotorSPV.Checked)
		End Sub

		Private Sub txtMotorSPV_TextChanged(sender As Object, e As EventArgs)
			Dim txtMotorSPV As TextBox = Me.txtMotorSPV
			Dim label_MotorSPV As Label = Me._Label_MotorSPV
			Me.TextBox_Change(txtMotorSPV, label_MotorSPV)
			Me._Label_MotorSPV = label_MotorSPV
			Me.txtMotorSPV = txtMotorSPV
			If Me.ActiveControl Is Me.txtMotorSPV Then
				Dim flag As Boolean = False
				Dim flag2 As Boolean = flag
				Dim txtMotorSPV2 As TextBox = Me.txtMotorSPV
				Dim bValidIfEmpty As Boolean = 1
				Dim bShowMessage As Boolean = 0
				Dim num As Single
				Dim obj As Object = num
				Dim flag3 As Boolean = CtrlUI.CheckValid(txtMotorSPV2, bValidIfEmpty, bShowMessage, obj)
				num = Conversions.ToSingle(obj)
				If flag2 <> flag3 Then
					txtMotorSPV = Me.txtMotorSPV
					label_MotorSPV = Me._Label_MotorSPV
					CtrlUI.TextBox_LostFocus(txtMotorSPV, label_MotorSPV, True)
					Me._Label_MotorSPV = label_MotorSPV
					Me.txtMotorSPV = txtMotorSPV
					Dim txtMotorSPV3 As Control = Me.txtMotorSPV
					CtrlUI.Control_LostFocus(txtMotorSPV3)
					Me.txtMotorSPV = CType(txtMotorSPV3, TextBox)
					ini.SaveDataValue("MotorSPV", num / 100F)
					If Not Information.IsDBNull(num) Then
						RSWIN_DESC.rst.MotorSPV = num / 100F
					End If
				End If
				Return
			End If
		End Sub

		Private Sub txtIrot_TextChanged(sender As Object, e As EventArgs)
			Dim txtIrot As TextBox = Me.txtIrot
			Dim label_Irot As Label = Me._Label_Irot
			Me.TextBox_Change(txtIrot, label_Irot)
			Me._Label_Irot = label_Irot
			Me.txtIrot = txtIrot
		End Sub

		Private Sub txtIart_TextChanged(sender As Object, e As EventArgs)
			Dim txtIart As TextBox = Me.txtIart
			Dim label_Iart As Label = Me._Label_Iart
			Me.TextBox_Change(txtIart, label_Iart)
			Me._Label_Iart = label_Iart
			Me.txtIart = txtIart
		End Sub

		Private Sub txtMotorSPV_Enter(sender As Object, e As EventArgs)
			Me.txtMotorSPV.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtIrot_Enter(sender As Object, e As EventArgs)
			Me.txtIrot.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtIart_Enter(sender As Object, e As EventArgs)
			Me.txtIart.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtMotorSPV_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = flag
			Dim txtMotorSPV As TextBox = Me.txtMotorSPV
			Dim bValidIfEmpty As Boolean = 1
			Dim bShowMessage As Boolean = 0
			Dim num As Single
			Dim obj As Object = num
			Dim flag3 As Boolean = CtrlUI.CheckValid(txtMotorSPV, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			If flag2 <> flag3 Then
				Dim obj2 As Object = flag
				obj = num
				Dim lowerBound As Single = 2F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 32
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				Dim obj3 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text)
				num = Conversions.ToSingle(obj)
				If Operators.ConditionalCompareObjectEqual(obj2, obj3, False) Then
					Me.txtMotorSPV.Focus()
				Else
					Dim obj4 As Object = flag
					obj = num
					Dim upperBound As Single = 60F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 32
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					Dim obj5 As Object = Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text)
					num = Conversions.ToSingle(obj)
					If Operators.ConditionalCompareObjectEqual(obj4, obj5, False) Then
						Me.txtMotorSPV.Focus()
					Else
						Dim txtMotorSPV2 As TextBox = Me.txtMotorSPV
						Dim label_MotorSPV As Label = Me._Label_MotorSPV
						CtrlUI.TextBox_LostFocus(txtMotorSPV2, label_MotorSPV, True)
						Me._Label_MotorSPV = label_MotorSPV
						Me.txtMotorSPV = txtMotorSPV2
						Dim txtMotorSPV3 As Control = Me.txtMotorSPV
						CtrlUI.Control_LostFocus(txtMotorSPV3)
						Me.txtMotorSPV = CType(txtMotorSPV3, TextBox)
						ini.SaveDataValue("MotorSPV", num / 100F)
						If Not Information.IsDBNull(num) Then
							RSWIN_DESC.rst.MotorSPV = num / 100F
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtIrot_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = flag
			Dim txtIrot As TextBox = Me.txtIrot
			Dim bValidIfEmpty As Boolean = 1
			Dim bShowMessage As Boolean = 0
			Dim num As Single
			Dim obj As Object = num
			Dim flag3 As Boolean = CtrlUI.CheckValid(txtIrot, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			If flag2 <> flag3 Then
				Dim obj2 As Object = flag
				obj = num
				Dim lowerBound As Single = 0F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 54
				Dim useMetric As Integer = -1
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				Dim obj3 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text)
				num = Conversions.ToSingle(obj)
				If Operators.ConditionalCompareObjectEqual(obj2, obj3, False) Then
					Me.txtIart.Focus()
				Else
					Dim obj4 As Object = flag
					obj = num
					Dim upperBound As Single = 1E+09F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 54
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					Dim obj5 As Object = Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text)
					num = Conversions.ToSingle(obj)
					If Operators.ConditionalCompareObjectEqual(obj4, obj5, False) Then
						Me.txtIart.Focus()
					Else
						Dim txtIrot2 As TextBox = Me.txtIrot
						Dim label_Irot As Label = Me._Label_Irot
						CtrlUI.TextBox_LostFocus(txtIrot2, label_Irot, True)
						Me._Label_Irot = label_Irot
						Me.txtIrot = txtIrot2
						Dim txtIrot3 As Control = Me.txtIrot
						CtrlUI.Control_LostFocus(txtIrot3)
						Me.txtIrot = CType(txtIrot3, TextBox)
						ini.SaveDataValue("Irot", num)
						If Not Information.IsDBNull(num) Then
							RSWIN_DESC.rst.Irot = num
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtIart_Leave(sender As Object, e As EventArgs)
			Dim txtIart As Control = Me.txtIart
			CtrlUI.Control_LostFocus(txtIart)
			Me.txtIart = CType(txtIart, TextBox)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = flag
			Dim txtIart2 As TextBox = Me.txtIart
			Dim bValidIfEmpty As Boolean = 1
			Dim bShowMessage As Boolean = 0
			Dim num As Single
			Dim obj As Object = num
			Dim flag3 As Boolean = CtrlUI.CheckValid(txtIart2, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			If flag2 <> flag3 Then
				Dim obj2 As Object = flag
				obj = num
				Dim lowerBound As Single = 0F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 7
				Dim useMetric As Integer = -1
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				Dim obj3 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text)
				num = Conversions.ToSingle(obj)
				If Operators.ConditionalCompareObjectEqual(obj2, obj3, False) Then
					Me.txtIart.Focus()
				Else
					Dim obj4 As Object = flag
					obj = num
					Dim upperBound As Single = 1E+09F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 7
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					Dim obj5 As Object = Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text)
					num = Conversions.ToSingle(obj)
					If Operators.ConditionalCompareObjectEqual(obj4, obj5, False) Then
						Me.txtIart.Focus()
					Else
						Dim txtIart3 As TextBox = Me.txtIart
						Dim label_Iart As Label = Me._Label_Iart
						CtrlUI.TextBox_LostFocus(txtIart3, label_Iart, True)
						Me._Label_Iart = label_Iart
						Me.txtIart = txtIart3
						txtIart = Me.txtIart
						CtrlUI.Control_LostFocus(txtIart)
						Me.txtIart = CType(txtIart, TextBox)
						ini.SaveDataValue("Iart", num)
						If Not Information.IsDBNull(num) Then
							RSWIN_DESC.rst.Iart = num
						End If
					End If
				End If
			End If
		End Sub

		Private Sub MotorData_Activated(sender As Object, e As EventArgs)
			Try
				Me.m_bClosing = False
				If Not Me.bFormLoaded Then
					Me.MotorDataLoad()
				End If
				If RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S Then
					Me.chkIncludeMotorSPV.Checked = False
					Me.chkCalcMotorSPV.Checked = False
					Me.chkCalculateIrot.Checked = False
					Me.chkIncludeMotorSPV.Enabled = False
					Me.chkCalcMotorSPV.Enabled = False
					Me.chkCalculateIrot.Enabled = False
					Me.txtIart.Enabled = False
				End If
				RSWIN_DESC.frmMain.ToolbarButtonSetState(15, True)
				RSWIN_DESC.sCurrentFormName = "MotorData"
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtMotorSPV_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtMotorSPV.Enabled Then
				Me.lblMotorSPV_Disabled.SendToBack()
				Return
			End If
			Me.lblMotorSPV_Disabled.BringToFront()
		End Sub

		Private Sub txtIrot_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtIrot.Enabled Then
				Me.lblIrot_Disabled.SendToBack()
				Return
			End If
			Me.lblIrot_Disabled.BringToFront()
		End Sub

		Private Sub txtIart_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtIart.Enabled Then
				Me.lblIart_Disabled.SendToBack()
				Return
			End If
			Me.lblIart_Disabled.BringToFront()
		End Sub

		Private Function CheckMotorSetting(cboMotorSetting As ComboBox, sMotorSettingName As String) As Integer
			Dim result As Integer = -1
			Dim num As Integer = Strings.InStr(sMotorSettingName, "(", CompareMethod.Binary)
			If num > 0 Then
				Dim [string] As String = sMotorSettingName.Substring(0, num - 1)
				Dim num2 As Integer = 0
				Dim num3 As Integer = cboMotorSetting.Items.Count - 1
				For i As Integer = num2 To num3
					If Strings.InStr(Conversions.ToString(cboMotorSetting.Items(i)), [string], CompareMethod.Binary) <> 0 Then
						result = i
						Exit For
					End If
				Next
			End If
			Return result
		End Function

		Private Sub MotorData_Closed(sender As Object, e As EventArgs)
			Me.m_bClosing = False
		End Sub

		Private Function HasFGlass() As Boolean
			Dim result As Boolean = False
			Try
				If RSWIN_DESC.rst.RodStringType = 2S Then
					result = False
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(rst.NumRods)
					For i As Integer = num To numRods
						If RODUTIL.IsFG(rst.Sections(i).Grade) Then
							result = True
						End If
					Next
				ElseIf RSWIN_DESC.rst.RodStringType = 3S Then
					If RSWIN_DESC.rst.giRodDesignStyle = 1S Then
						result = True
					End If
				Else
					result = False
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub chkIncludeMotorSPV_EnabledChanged(sender As Object, e As EventArgs)
		End Sub

		Public Sub CenterForm()
			' The following expression was wrapped in a checked-statement
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				Me.Left = CInt(Math.Round(CDbl((Me.MyParentFrm.Width - Me.Width)) / 2.0 - 8.0))
				Me.Top = CInt(Math.Round(CDbl((Me.MyParentFrm.Height - Me.Height)) / 2.0 - CDbl(Me.MyParentFrm.ParentToolbarHeight())))
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub DisplayMotorDataError(sMsg As String, ByRef bCancel As Boolean)
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

		Private Sub MotorData_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub MotorData_MouseDown(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub MotorData_MouseEnter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub MotorData_MouseMove(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub MotorData_MouseUp(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub MotorData_MouseWheel(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub MotorData_Move(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub MotorData_Scroll(sender As Object, e As ScrollEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub MotorData_KeyPress(sender As Object, e As KeyPressEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub MotorData_KeyUp(sender As Object, e As KeyEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub MotorData_DragDrop(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub MotorData_DragEnter(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub MotorData_FormClosed(sender As Object, e As FormClosedEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub MotorData_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub MotorData_LostFocus(sender As Object, e As EventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub MotorData_GotFocus(sender As Object, e As EventArgs)
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

		Public Sub DisplayMotorPairs()
			Dim num As Single = -100000F
			Dim num2 As Single = -100000F
			Dim num3 As Single = 100000F
			Dim num4 As Single = 100000F
			Dim axisX As Axis = Me.chtMotorPairs.AxisX
			Dim axisY As Axis = Me.chtMotorPairs.AxisY
			Me.ResetClock()
			Dim text As String
			If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV)) Then
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Motor.GetMotorInfo(1), " "), Motor.GetMotorInfo(3)))
			ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 3, False), If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV)) Then
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Motor.GetMotorInfo(1), " "), Motor.GetMotorInfo(3)), " "), Motor.GetMotorInfo(2)))
			ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 5, False), If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV)) Then
				Dim text2 As String = Conversions.ToString(Motor.GetMotorInfo(2))
				If Operators.CompareString(text2, "25 hp", False) = 0 Then
					text2 = RSWIN_DESC.Reliance_Table(4, 2)
				ElseIf Operators.CompareString(text2, "34 hp", False) = 0 Then
					text2 = RSWIN_DESC.Reliance_Table(4, 3)
				ElseIf Operators.CompareString(text2, "50 hp", False) = 0 Then
					text2 = RSWIN_DESC.Reliance_Table(4, 4)
				ElseIf Operators.CompareString(text2, "60 hp", False) = 0 Then
					text2 = RSWIN_DESC.Reliance_Table(4, 5)
				End If
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Reliance SVP ", Motor.GetMotorInfo(3)), " "), text2))
			ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 2, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 4, False)), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 6, False)), If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV)) Then
				Dim iSizeIndex As Integer
				Dim relianceMotorSizeName As String = MImpred.GetRelianceMotorSizeName(Conversions.ToString(Motor.GetMotorInfo(3)), iSizeIndex)
				Dim text2 As String = Conversions.ToString(Motor.GetMotorInfo(2))
				text2 = MImpred.GetRelianceMotorSettingName(text2, iSizeIndex)
				text = "Reliance SVP " + relianceMotorSizeName + " " + text2
			End If
			If Strings.InStr(text, ".0 hp", CompareMethod.Binary) > 0 Then
				text = text.Replace(".0 hp", " hp")
			End If
			If Strings.InStr(text, "Marathon", CompareMethod.Binary) > 0 Then
				text = text.Replace("Marathon", "NEMA D")
			End If
			Dim motorSetting_Deviated As DataSet = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.GetMotorSetting_Deviated(text)
			Dim motorCurvePoints_Deviated As DataSet = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.GetMotorCurvePoints_Deviated(text)
			Dim count As Integer = motorSetting_Deviated.Tables(0).Rows.Count
			Dim count2 As Integer = motorCurvePoints_Deviated.Tables(0).Rows.Count
			If count2 > 0 Then
				Me.sCurrentMotorID = text
			Else
				Me.sCurrentMotorID = ""
			End If
			Dim dataView As DataView = New DataView(motorSetting_Deviated.Tables(0))
			Dim dataView2 As DataView = New DataView(motorCurvePoints_Deviated.Tables(0))
			Dim num5 As Single
			Dim num6 As Single
			Dim num7 As Integer
			Try
				For Each obj As Object In dataView
					Dim dataRowView As DataRowView = CType(obj, DataRowView)
					Dim row As DataRow = dataRowView.Row
					num5 = Conversions.ToSingle(row("FullLoadRPM"))
					num6 = Conversions.ToSingle(row("HalfLoadRPM"))
					num7 = Conversions.ToInteger(row("NumPairs"))
					If Operators.ConditionalCompareObjectEqual(Motor.GetMotorInfo(4), 7, False) Then
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.lblMotor.Text = "Motor: " + text
			dataView2.Sort = "MotorCurvePointID"
			Debug.WriteLine(text)
			Debug.WriteLine(num5)
			Debug.WriteLine(num6)
			Debug.WriteLine(num7)
			Dim num12 As Integer
			Dim num13 As Short
			Dim num14 As Short
			Me.fRPMs = New Single(num7 + 1 - 1) {}
			Me.fTorques = New Single(num7 + 1 - 1) {}
			Me.iMotorCurveIDs = New Integer(num7 + 1 - 1) {}
			Dim num8 As Short = 0S
			Try
				For Each obj2 As Object In dataView2
					Dim dataRowView As DataRowView = CType(obj2, DataRowView)
					Dim row As DataRow = dataRowView.Row
					Dim num9 As Integer = Conversions.ToInteger(row("MotorCurvePointID"))
					Dim num10 As Single = Conversions.ToSingle(row("RPM"))
					Dim num11 As Single = Conversions.ToSingle(row("Torque"))
					num8 += 1S
					Me.fRPMs(CInt(num8)) = num10
					Me.fTorques(CInt(num8)) = num11
					Me.iMotorCurveIDs(CInt(num8)) = num9
					Debug.WriteLine(Conversions.ToString(num10) + " , " + Conversions.ToString(num11))
					If num10 > num Then
						num = num10
					End If
					If num10 < num3 Then
						num3 = num10
					End If
					If num11 > num2 Then
						num2 = num11
					End If
					If num11 < num4 Then
						num4 = num11
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			num12 = CInt(num8)
			Me.Reg_Motor.Degree = 5
			num13 = 1S
			num14 = CShort(num12)
			For num15 As Short = num13 To num14
				Me.Reg_Motor.XYAdd(CDbl(Me.fRPMs(CInt(num15))), CDbl(Me.fTorques(CInt(num15))))
			Next
			If num12 > 0 Then
				Dim chtMotorPairs As Chart = Me.chtMotorPairs
				Dim titleDockable As TitleDockable = chtMotorPairs.Titles(0)
				titleDockable.Alignment = StringAlignment.Center
				titleDockable.Font = New Font("Arial", 12F, FontStyle.Bold)
				titleDockable.Text = "RPM  vs. Torque"
				titleDockable.TextColor = Color.Black
				axisX.Title.Text = String.Concat(New String() { "RPM   (full load: ", Conversions.ToString(num5), " half load: ", Conversions.ToString(num6), " num pairs: ", Conversions.ToString(num7), ")" })
				axisX.Title.Alignment = StringAlignment.Center
				axisX.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
				axisX.ForceZero = False
				axisX.AutoScale = True
				axisX.Min = CDbl(num3)
				axisX.Max = CDbl(num)
				axisY.Title.Text = "Torque "
				axisY.Title.Alignment = StringAlignment.Center
				axisY.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
				axisY.ForceZero = False
				axisY.AutoScale = True
				chtMotorPairs.Data.Series = 2
				chtMotorPairs.Series(0).MarkerShape = MarkerShape.None
				chtMotorPairs.Series(0).Text = "Torques"
				chtMotorPairs.Series(0).Color = Color.Gray
				chtMotorPairs.Series(0).AxisY = chtMotorPairs.AxisY
				chtMotorPairs.Series(0).Visible = True
				chtMotorPairs.Series(1).MarkerShape = MarkerShape.None
				chtMotorPairs.Series(1).Text = "Regression Torques"
				chtMotorPairs.Series(1).Color = Color.Red
				chtMotorPairs.Series(1).AxisY = chtMotorPairs.AxisY
				chtMotorPairs.Series(1).Visible = True
				chtMotorPairs.Data.Series = 2
				chtMotorPairs.Data.Points = 0
				chtMotorPairs.Data.Points = num12
				Dim num18 As Short
				Dim num19 As Short
				Dim points As Short = CShort(num12)
				chtMotorPairs.Data.Series = 2
				chtMotorPairs.Data.Points = CInt(points)
				Dim num16 As Short = 1S
				Dim num17 As Short = CShort(num12)
				For num15 As Short = num16 To num17
					chtMotorPairs.Data.X(0, CInt((num15 - 1S))) = CDbl(Me.fRPMs(CInt(num15)))
					chtMotorPairs.Data.Y(0, CInt((num15 - 1S))) = CDbl(Me.fTorques(CInt(num15)))
				Next
				num18 = 1S
				num19 = CShort(num12)
				For num15 As Short = num18 To num19
					' The following expression was wrapped in a checked-statement
					chtMotorPairs.Data.X(1, CInt((num15 - 1S))) = CDbl(Me.fRPMs(CInt(num15)))
					Dim reg_Motor As RegressionObject = Me.Reg_Motor
					Dim array As Single() = Me.fRPMs
					Dim num20 As Integer = CInt(num15)
					Dim num21 As Double = array(num20)
					Dim num22 As Single = CSng(reg_Motor.RegVal(num21))
					Me.fRPMs(num20) = CSng(num21)
					Dim num11 As Single = num22
					Debug.WriteLine(Conversions.ToString(Me.fRPMs(CInt(num15))) + " , " + Conversions.ToString(num11))
					chtMotorPairs.Data.Y(1, CInt((num15 - 1S))) = CDbl(num11)
					If num11 > num2 Then
						num2 = num11
					End If
					If num11 < num4 Then
						num4 = num11
					End If
				Next
				axisY.Min = CDbl(num4)
				axisY.Max = CDbl(num2)
				Dim axisX2 As AxisX = Me.chtMotorPairs.AxisX
				If axisX2.Min <> CDbl(num3) Then
					axisX2.Min = CDbl(num3)
				End If
				If axisX2.Max <> CDbl(num) Then
					axisX2.Max = CDbl(num)
				End If
				Dim axisY2 As AxisY = Me.chtMotorPairs.AxisY
				If axisY2.Min <> CDbl(num4) Then
					axisY2.Min = CDbl(num4)
				End If
				If axisY2.Max <> CDbl(num2) Then
					axisY2.Max = CDbl(num2)
				End If
				chtMotorPairs.Refresh()
			End If
			Me.chtMotorPairs.Visible = True
		End Sub

		Private Sub btnCloseMotorPairs_Click(sender As Object, e As EventArgs)
			Me.pnlMotorPairs.Visible = False
			Me.pnlMotorPairs.Left = -1333
		End Sub

		Private Sub btnPlotMotorPairs_Click(sender As Object, e As EventArgs)
			Me.lblWorking.Text = ""
			Me.lblWorking.Visible = True
			Me.pnlMotorPairs.Left = 8
			Me.pnlMotorPairs.Top = 0
			Try
				Me.DisplayMotorPairs()
			Catch ex As Exception
			End Try
			Me.pnlMotorPairs.Visible = True
		End Sub

		Public Function UpdateMotorRowWithRegressionValues(sMotorID As String) As Object
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Me.lblWorking.Text = "Working!"
			Me.lblWorking.Visible = True
			Dim result As Object
			Try
				Try
					Dim chtMotorPairs As Chart = Me.chtMotorPairs
					Dim num3 As Integer = 1
					Dim points As Integer = chtMotorPairs.Data.Points
					For i As Integer = num3 To points
						Dim motorCurvePointID As Integer = Me.iMotorCurveIDs(i)
						Dim fRPM As Single = CSng(chtMotorPairs.Data.X(1, i - 1))
						Dim fTorque As Single = CSng(chtMotorPairs.Data.Y(1, i - 1))
						Me.UpdateMotorRow(motorCurvePointID, fRPM, fTorque, num2)
						num += num2
					Next
					result = num
				Catch ex As OleDbException
					MessageBox.Show(ex.Message, "OleDb Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Public Sub UpdateMotorRow(MotorCurvePointID As Integer, fRPM As Single, fTorque As Single, ByRef iRecsUpdate As Integer)
			Dim text As String = "6REpwv3ohCAbpM"
			Dim text2 As String = "db_admin"
			Dim text3 As String = "ThetaStdInfo.mdb"
			Dim text4 As String = "ThetaStdInfo.mdw"
			Dim str As String = ""
			Me.LocateDatabaseFile("ThetaStdInfo.mdb", "ThetaStdInfo.mdw", str)
			If File.Exists(str + text3) Then
				text3 = str + text3
				text4 = str + text4
				Dim text5 As String = String.Concat(New String() { "Provider=Microsoft.Jet.OLEDB.4.0;Password=", text, ";User ID=", text2, ";Data Source=", text3, ";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database=", text4, ";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False" })
				Dim connectionString As String = text5
				Dim text6 As String = "MotorCurvePoints_Deviated"
				Dim selectCommandText As String = "Select * from " + text6 + " where MotorCurvePointID=" + Conversions.ToString(MotorCurvePointID)
				iRecsUpdate = 0
				Try
					Try
						Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
						Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection)
						oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
						Dim dataSet As DataSet = New DataSet(text6)
						Try
							oleDbDataAdapter.Fill(dataSet, text6)
						Catch ex As Exception
						End Try
						Dim dataRow As DataRow = dataSet.Tables(text6).Rows(0)
						Try
							Debug.WriteLine(Conversions.ToString(fRPM) + " , " + Conversions.ToString(fTorque))
							dataRow("RPM") = fRPM
							dataRow("Torque") = fTorque
						Catch ex2 As Exception
							MessageBox.Show(ex2.Message)
						End Try
						Dim oleDbCommandBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(oleDbDataAdapter)
						iRecsUpdate = oleDbDataAdapter.Update(dataSet, text6)
						If oleDbConnection.State = ConnectionState.Open Then
							oleDbConnection.Close()
						End If
					Catch ex3 As OleDbException
						MessageBox.Show(ex3.Message, "OleDb Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End Try
				Catch ex4 As Exception
				End Try
			End If
		End Sub

		Private Sub btnUpdateDB_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.sCurrentMotorID, "", False) <> 0 Then
				Dim obj As Object = MessageBox.Show("Update torques with regression values?", "Motor:  " + Me.sCurrentMotorID, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				If Operators.ConditionalCompareObjectEqual(obj, DialogResult.Yes, False) Then
					Me.lblWorking.Text = "Working!"
					Me.lblWorking.Visible = True
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Dim num As Integer = Conversions.ToInteger(Me.UpdateMotorRowWithRegressionValues(Me.sCurrentMotorID))
					Me.lblWorking.Text = "Done! " + Conversions.ToString(num) + " Records Update!"
				End If
				Return
			End If
		End Sub

		Public Sub LocateDatabaseFile(sDatabaseFile As String, sWorkgroupFile As String, ByRef sDirPath As String)
			Dim text As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\" + VERSION1.ProgramName() + "\"
			Dim flag As Boolean = False
			Try
				Dim fileInfo As FileInfo = New FileInfo(Application.StartupPath + "\" + sDatabaseFile)
				If fileInfo.Exists Then
					flag = True
				End If
				sDirPath = ""
				Dim fileInfo2 As FileInfo = New FileInfo(text + sDatabaseFile)
				If Not fileInfo2.Exists Then
					If Not Directory.Exists(text) Then
						Directory.CreateDirectory(text)
					End If
					If flag Then
						File.Copy(Application.StartupPath + "\" + sDatabaseFile, text + sDatabaseFile)
						Try
							File.Copy(Application.StartupPath + "\" + sWorkgroupFile, text + sWorkgroupFile)
						Catch ex As Exception
						End Try
						Dim text2 As String = text + sDatabaseFile
						sDirPath = text
					Else
						Dim fileInfo3 As FileInfo = New FileInfo("c:\Theta\" + sDatabaseFile)
						If fileInfo3.Exists Then
							File.Copy("c:\Theta\" + sDatabaseFile, text + sDatabaseFile)
							Try
								File.Copy(Application.StartupPath + "\" + sWorkgroupFile, text + sWorkgroupFile)
							Catch ex2 As Exception
							End Try
							Dim text2 As String = text + sDatabaseFile
							sDirPath = text
						End If
					End If
				Else
					Dim text2 As String = text + sDatabaseFile
					sDirPath = text
					If flag AndAlso DateTime.Compare(fileInfo.LastWriteTime, fileInfo2.LastWriteTime) > 0 Then
						fileInfo2.Delete()
						Dim fileInfo4 As FileInfo = New FileInfo(text + sWorkgroupFile)
						If fileInfo4.Exists Then
							fileInfo4.Delete()
						End If
						Try
							File.Copy(Application.StartupPath + "\" + sDatabaseFile, text + sDatabaseFile)
						Catch ex3 As Exception
						End Try
						Try
							File.Copy(Application.StartupPath + "\" + sWorkgroupFile, text + sWorkgroupFile)
						Catch ex4 As Exception
						End Try
					End If
				End If
			Catch ex5 As Exception
			End Try
		End Sub

		Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
			Try
				Me.chtMotorPairs.Data.Clear()
				Me.DisplayMotorPairs()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkCalcMotorSPV_EnabledChanged(sender As Object, e As EventArgs)
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

		Private Sub MotorData_SizeChanged(sender As Object, e As EventArgs)
		End Sub

		Private MyParentFrm As RODSTAR

		Private bCancel As Boolean

		Private Reg_Motor As RegressionObject

		Private sCurrentMotorID As String

		Private fRPMs As Single()

		Private fTorques As Single()

		Private iMotorCurveIDs As Integer()

		Private m_bClosing As Boolean

		Private m_bValidated As Boolean

		Private bFormLoaded As Boolean

		Private cboMotorSizebClicked As Boolean

		Private cboMotorTypebClicked As Boolean

		Private cboMotorSettingbClicked As Boolean

		Private mbSavedCalcMotorSPV As Boolean

		Private mbSavedIrotEntered As Boolean

		<AccessedThroughProperty("pnlMotorPairs")>
		Private _pnlMotorPairs As Panel

		<AccessedThroughProperty("btnCloseMotorPairs")>
		Private _btnCloseMotorPairs As Button

		<AccessedThroughProperty("chtMotorPairs")>
		Private _chtMotorPairs As Chart

		<AccessedThroughProperty("btnPlotMotorPairs")>
		Private _btnPlotMotorPairs As Button

		<AccessedThroughProperty("lblMotor")>
		Private _lblMotor As Label

		<AccessedThroughProperty("btnUpdateDB")>
		Private _btnUpdateDB As Button

		<AccessedThroughProperty("lblWorking")>
		Private _lblWorking As Label

		<AccessedThroughProperty("btnRefresh")>
		Private _btnRefresh As Button

		Private myKeyValueHT As Hashtable

		<AccessedThroughProperty("pnlMotorData")>
		Private _pnlMotorData As Panel

		<AccessedThroughProperty("txtElectricityCost")>
		Private _txtElectricityCost As TextBox

		<AccessedThroughProperty("cboMotorType")>
		Private _cboMotorType As ComboBox

		<AccessedThroughProperty("cboMotorSize")>
		Private _cboMotorSize As ComboBox

		<AccessedThroughProperty("cboMotorSetting")>
		Private _cboMotorSetting As ComboBox

		<AccessedThroughProperty("_Line_0")>
		Private __Line_0 As Label

		<AccessedThroughProperty("_Line_1")>
		Private __Line_1 As Label

		<AccessedThroughProperty("optPowerMeterType_2")>
		Private _optPowerMeterType_2 As RadioButton

		<AccessedThroughProperty("optPowerMeterType_1")>
		Private _optPowerMeterType_1 As RadioButton

		<AccessedThroughProperty("FontDialog1")>
		Private _FontDialog1 As FontDialog

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		<AccessedThroughProperty("chkIncludeMotorSPV")>
		Private _chkIncludeMotorSPV As CheckBox

		<AccessedThroughProperty("txtMotorSPV")>
		Private _txtMotorSPV As TextBox

		<AccessedThroughProperty("chkCalcMotorSPV")>
		Private _chkCalcMotorSPV As CheckBox

		<AccessedThroughProperty("txtIrot")>
		Private _txtIrot As TextBox

		<AccessedThroughProperty("chkCalculateIrot")>
		Private _chkCalculateIrot As CheckBox

		<AccessedThroughProperty("txtIart")>
		Private _txtIart As TextBox

		<AccessedThroughProperty("_Line_2")>
		Private __Line_2 As Label

		<AccessedThroughProperty("_Line_3")>
		Private __Line_3 As Label

		<AccessedThroughProperty("_Line_4")>
		Private __Line_4 As Label

		<AccessedThroughProperty("_Line_5")>
		Private __Line_5 As Label

		<AccessedThroughProperty("_Line_6")>
		Private __Line_6 As Label

		<AccessedThroughProperty("_Line_7")>
		Private __Line_7 As Label

		<AccessedThroughProperty("ToolTip1")>
		Private _ToolTip1 As ToolTip

		<AccessedThroughProperty("_Label_MotorSPV")>
		Private __Label_MotorSPV As Label

		<AccessedThroughProperty("_Label_Irot")>
		Private __Label_Irot As Label

		<AccessedThroughProperty("_Label_Iart")>
		Private __Label_Iart As Label

		<AccessedThroughProperty("_Label_MotorType")>
		Private __Label_MotorType As Label

		<AccessedThroughProperty("_Label_MeterType")>
		Private __Label_MeterType As Label

		<AccessedThroughProperty("_Label_ElectricityCost")>
		Private __Label_ElectricityCost As Label

		<AccessedThroughProperty("_Label_MotorSize")>
		Private __Label_MotorSize As Label

		<AccessedThroughProperty("_Label_MotorSetting")>
		Private __Label_MotorSetting As Label

		<AccessedThroughProperty("lblMotorSPV_Disabled")>
		Private _lblMotorSPV_Disabled As Label

		<AccessedThroughProperty("lblIrot_Disabled")>
		Private _lblIrot_Disabled As Label

		<AccessedThroughProperty("lblIart_Disabled")>
		Private _lblIart_Disabled As Label

		<AccessedThroughProperty("lblAsterisk")>
		Private _lblAsterisk As Label

		<AccessedThroughProperty("lblFootnote1")>
		Private _lblFootnote1 As Label

		Private Shared m_vb6FormDefInstance As MotorData

		Private Shared m_InitializingDefInstance As Boolean

		Private $STATIC$LocateDatabaseFile$2031EE10E$sUserProfileAppData As String

		Private $STATIC$LocateDatabaseFile$2031EE10E$sAppData As String

		Private $STATIC$LocateDatabaseFile$2031EE10E$sWin As String

		Private $STATIC$LocateDatabaseFile$2031EE10E$sUserProfile As String

		Private $STATIC$LocateDatabaseFile$2031EE10E$sWinSys As String
	End Class
End Namespace
