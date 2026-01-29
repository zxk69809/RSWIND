Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Partial Class WellInfo
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

		Public Property bQuietLeaveMsg As Boolean
			Get
				Return Me.m_bQuietLeaveMsg
			End Get
			Set(value As Boolean)
				Me.m_bQuietLeaveMsg = value
			End Set
		End Property

		Friend Overridable Property chkParaffin As CheckBox
			Get
				Return Me._chkParaffin
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkParaffin_CheckedChanged
				If Me._chkParaffin IsNot Nothing Then
					RemoveHandler Me._chkParaffin.CheckedChanged, value2
				End If
				Me._chkParaffin = value
				If Me._chkParaffin IsNot Nothing Then
					AddHandler Me._chkParaffin.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _Label_ParaffinDepth As Label
			Get
				Return Me.__Label_ParaffinDepth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_ParaffinDepth = value
			End Set
		End Property

		Friend Overridable Property lblParaffinDepth_Disabled As Label
			Get
				Return Me._lblParaffinDepth_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblParaffinDepth_Disabled = value
			End Set
		End Property

		Public Overridable Property txtParaffinDepth As TextBox
			Get
				Return Me._txtParaffinDepth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtParaffinDepth_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtParaffinDepth_Leave
				Dim value4 As KeyEventHandler = AddressOf Me.txtParaffinDepth_KeyDown
				Dim value5 As EventHandler = AddressOf Me.txtParaffinDepth_Enter
				If Me._txtParaffinDepth IsNot Nothing Then
					RemoveHandler Me._txtParaffinDepth.TextChanged, value2
					RemoveHandler Me._txtParaffinDepth.Leave, value3
					RemoveHandler Me._txtParaffinDepth.KeyDown, value4
					RemoveHandler Me._txtParaffinDepth.Enter, value5
				End If
				Me._txtParaffinDepth = value
				If Me._txtParaffinDepth IsNot Nothing Then
					AddHandler Me._txtParaffinDepth.TextChanged, value2
					AddHandler Me._txtParaffinDepth.Leave, value3
					AddHandler Me._txtParaffinDepth.KeyDown, value4
					AddHandler Me._txtParaffinDepth.Enter, value5
				End If
			End Set
		End Property

		Public Overridable Property _linSeparator_5 As Label
			Get
				Return Me.__linSeparator_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linSeparator_5 = value
			End Set
		End Property

		Public Overridable Property _linSeparator_4 As Label
			Get
				Return Me.__linSeparator_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linSeparator_4 = value
			End Set
		End Property

		Public Shared Property DefInstance As WellInfo
			Get
				If RSWINV3.WellInfo.m_vb6FormDefInstance Is Nothing OrElse RSWINV3.WellInfo.m_vb6FormDefInstance.IsDisposed Then
					RSWINV3.WellInfo.m_InitializingDefInstance = True
					RSWINV3.WellInfo.m_vb6FormDefInstance = New WellInfo()
					RSWINV3.WellInfo.m_InitializingDefInstance = False
				End If
				Return RSWINV3.WellInfo.m_vb6FormDefInstance
			End Get
			Set(value As WellInfo)
				RSWINV3.WellInfo.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.DoubleClick, AddressOf Me.WellInfo_DoubleClick
			AddHandler MyBase.KeyDown, AddressOf Me.WellInfo_KeyDown
			AddHandler MyBase.MouseClick, AddressOf Me.WellInfo_MouseClick
			AddHandler MyBase.TextChanged, AddressOf Me.WellInfo_TextChanged
			AddHandler MyBase.Validating, AddressOf Me.WellInfo_Validating
			AddHandler MyBase.Load, AddressOf Me.WellInfo_Load
			AddHandler MyBase.Enter, AddressOf Me.WellInfo_Enter
			AddHandler MyBase.Activated, AddressOf Me.WellInfo_Activated
			AddHandler MyBase.Closed, AddressOf Me.WellInfo_Closed
			AddHandler MyBase.Closing, AddressOf Me.WellInfo_Closing
			AddHandler MyBase.Click, AddressOf Me.WellInfo_Click
			AddHandler MyBase.Leave, AddressOf Me.WellInfo_Leave
			AddHandler MyBase.MinimumSizeChanged, AddressOf Me.WellInfo_MinimumSizeChanged
			AddHandler MyBase.MaximumSizeChanged, AddressOf Me.WellInfo_MaximumSizeChanged
			AddHandler MyBase.MaximizedBoundsChanged, AddressOf Me.WellInfo_MaximizedBoundsChanged
			AddHandler MyBase.Resize, AddressOf Me.WellInfo_Resize
			AddHandler MyBase.SizeChanged, AddressOf Me.WellInfo_SizeChanged
			AddHandler MyBase.Paint, AddressOf Me.WellInfo_Paint
			AddHandler MyBase.RightToLeftChanged, AddressOf Me.WellInfo_RightToLeftChanged
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.WellInfo_MouseDoubleClick
			AddHandler MyBase.MouseDown, AddressOf Me.WellInfo_MouseDown
			AddHandler MyBase.MouseEnter, AddressOf Me.WellInfo_MouseEnter
			AddHandler MyBase.MouseMove, AddressOf Me.WellInfo_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.WellInfo_MouseUp
			AddHandler MyBase.MouseWheel, AddressOf Me.WellInfo_MouseWheel
			AddHandler MyBase.Move, AddressOf Me.WellInfo_Move
			AddHandler MyBase.Scroll, AddressOf Me.WellInfo_Scroll
			AddHandler MyBase.KeyPress, AddressOf Me.WellInfo_KeyPress
			AddHandler MyBase.KeyUp, AddressOf Me.WellInfo_KeyUp
			AddHandler MyBase.DragDrop, AddressOf Me.WellInfo_DragDrop
			AddHandler MyBase.DragEnter, AddressOf Me.WellInfo_DragEnter
			AddHandler MyBase.FormClosed, AddressOf Me.WellInfo_FormClosed
			AddHandler MyBase.FormClosing, AddressOf Me.WellInfo_FormClosing
			AddHandler MyBase.LostFocus, AddressOf Me.WellInfo_LostFocus
			AddHandler MyBase.GotFocus, AddressOf Me.WellInfo_GotFocus
			Me.bAllowResize = True
			Me.bDynaSourceClicked = False
			Me.bPDMsgShown = False
			Me.myKeyValueHT = New Hashtable()
			Me.iWidth = 0
			Me.iHeight = 0
			Me.iParentWidth = 0
			Me.iParentHeight = 0
			Me.m_bClosing = False
			Me.m_bValidated = False
			Me.m_bQuietLeaveMsg = False
			Me.bAIPreferencesSet = False
			Me.myRodGuideAL = New ArrayList()
			If RSWINV3.WellInfo.m_vb6FormDefInstance Is Nothing Then
				If RSWINV3.WellInfo.m_InitializingDefInstance Then
					RSWINV3.WellInfo.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							RSWINV3.WellInfo.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.WellInfo = Me
			Me.InitializeComponent()
			Me.Text = "Well Information"
		End Sub

		Protected Sub LoadWellInfo_Clicked(sender As Object, e As EventArgs)
			Dim text As String = Me.Text
			Dim sMsgType As String = ""
			Dim bClosing As Boolean = False
			Dim dialogResult As DialogResult = DialogResult.OK
			Util.SendMessage(text, sMsgType, bClosing, dialogResult)
		End Sub

		Private Overridable Property WellInfo As Form
			Get
				Return Me._WellInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Form)
				Me._WellInfo = value
			End Set
		End Property

		Friend Overridable Property pnlWellInfo As Panel
			Get
				Return Me._pnlWellInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As PaintEventHandler = AddressOf Me.pnlWellInfo_Paint
				If Me._pnlWellInfo IsNot Nothing Then
					RemoveHandler Me._pnlWellInfo.Paint, value2
				End If
				Me._pnlWellInfo = value
				If Me._pnlWellInfo IsNot Nothing Then
					AddHandler Me._pnlWellInfo.Paint, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkCalcFluidSPGR As CheckBox
			Get
				Return Me._chkCalcFluidSPGR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkCalcFluidSPGR_CheckedChanged
				If Me._chkCalcFluidSPGR IsNot Nothing Then
					RemoveHandler Me._chkCalcFluidSPGR.CheckedChanged, value2
				End If
				Me._chkCalcFluidSPGR = value
				If Me._chkCalcFluidSPGR IsNot Nothing Then
					AddHandler Me._chkCalcFluidSPGR.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtComment As RichTextBox
			Get
				Return Me._txtComment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Dim value2 As EventHandler = AddressOf Me.txtComment_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtComment_Enter
				Dim value4 As EventHandler = AddressOf Me.txtComment_Leave
				If Me._txtComment IsNot Nothing Then
					RemoveHandler Me._txtComment.TextChanged, value2
					RemoveHandler Me._txtComment.Enter, value3
					RemoveHandler Me._txtComment.Leave, value4
				End If
				Me._txtComment = value
				If Me._txtComment IsNot Nothing Then
					AddHandler Me._txtComment.TextChanged, value2
					AddHandler Me._txtComment.Enter, value3
					AddHandler Me._txtComment.Leave, value4
				End If
			End Set
		End Property

		Public Overridable Property txtFluidSPGR As TextBox
			Get
				Return Me._txtFluidSPGR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtFluidSPGR_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.txtFluidSPGR_Enter
				Dim value4 As EventHandler = AddressOf Me.txtFluidSPGR_Leave
				Dim value5 As EventHandler = AddressOf Me.txtFluidSPGR_TextChanged
				If Me._txtFluidSPGR IsNot Nothing Then
					RemoveHandler Me._txtFluidSPGR.EnabledChanged, value2
					RemoveHandler Me._txtFluidSPGR.Enter, value3
					RemoveHandler Me._txtFluidSPGR.Leave, value4
					RemoveHandler Me._txtFluidSPGR.TextChanged, value5
				End If
				Me._txtFluidSPGR = value
				If Me._txtFluidSPGR IsNot Nothing Then
					AddHandler Me._txtFluidSPGR.EnabledChanged, value2
					AddHandler Me._txtFluidSPGR.Enter, value3
					AddHandler Me._txtFluidSPGR.Leave, value4
					AddHandler Me._txtFluidSPGR.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property txtOilAPI As TextBox
			Get
				Return Me._txtOilAPI
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtOilAPI_Enter
				Dim value3 As EventHandler = AddressOf Me.txtOilAPI_Leave
				Dim value4 As KeyEventHandler = AddressOf Me.txtOilAPI_KeyDown
				Dim value5 As EventHandler = AddressOf Me.txtOilAPI_TextChanged
				If Me._txtOilAPI IsNot Nothing Then
					RemoveHandler Me._txtOilAPI.Enter, value2
					RemoveHandler Me._txtOilAPI.Leave, value3
					RemoveHandler Me._txtOilAPI.KeyDown, value4
					RemoveHandler Me._txtOilAPI.TextChanged, value5
				End If
				Me._txtOilAPI = value
				If Me._txtOilAPI IsNot Nothing Then
					AddHandler Me._txtOilAPI.Enter, value2
					AddHandler Me._txtOilAPI.Leave, value3
					AddHandler Me._txtOilAPI.KeyDown, value4
					AddHandler Me._txtOilAPI.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property txtWaterSPGR As TextBox
			Get
				Return Me._txtWaterSPGR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtWaterSPGR_Enter
				Dim value3 As EventHandler = AddressOf Me.txtWaterSPGR_Leave
				Dim value4 As EventHandler = AddressOf Me.txtWaterSPGR_TextChanged
				If Me._txtWaterSPGR IsNot Nothing Then
					RemoveHandler Me._txtWaterSPGR.Enter, value2
					RemoveHandler Me._txtWaterSPGR.Leave, value3
					RemoveHandler Me._txtWaterSPGR.TextChanged, value4
				End If
				Me._txtWaterSPGR = value
				If Me._txtWaterSPGR IsNot Nothing Then
					AddHandler Me._txtWaterSPGR.Enter, value2
					AddHandler Me._txtWaterSPGR.Leave, value3
					AddHandler Me._txtWaterSPGR.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property txtWaterCut As TextBox
			Get
				Return Me._txtWaterCut
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtWaterCut_Enter
				Dim value3 As EventHandler = AddressOf Me.txtWaterCut_Leave
				Dim value4 As EventHandler = AddressOf Me.txtWaterCut_TextChanged
				If Me._txtWaterCut IsNot Nothing Then
					RemoveHandler Me._txtWaterCut.Enter, value2
					RemoveHandler Me._txtWaterCut.Leave, value3
					RemoveHandler Me._txtWaterCut.TextChanged, value4
				End If
				Me._txtWaterCut = value
				If Me._txtWaterCut IsNot Nothing Then
					AddHandler Me._txtWaterCut.Enter, value2
					AddHandler Me._txtWaterCut.Leave, value3
					AddHandler Me._txtWaterCut.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property txtCasingPressure As TextBox
			Get
				Return Me._txtCasingPressure
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtCasingPressure_Enter
				Dim value3 As EventHandler = AddressOf Me.txtCasingPressure_Leave
				Dim value4 As KeyEventHandler = AddressOf Me.txtCasingPressure_KeyDown
				Dim value5 As EventHandler = AddressOf Me.txtCasingPressure_TextChanged
				If Me._txtCasingPressure IsNot Nothing Then
					RemoveHandler Me._txtCasingPressure.Enter, value2
					RemoveHandler Me._txtCasingPressure.Leave, value3
					RemoveHandler Me._txtCasingPressure.KeyDown, value4
					RemoveHandler Me._txtCasingPressure.TextChanged, value5
				End If
				Me._txtCasingPressure = value
				If Me._txtCasingPressure IsNot Nothing Then
					AddHandler Me._txtCasingPressure.Enter, value2
					AddHandler Me._txtCasingPressure.Leave, value3
					AddHandler Me._txtCasingPressure.KeyDown, value4
					AddHandler Me._txtCasingPressure.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property txtTubingPressure As TextBox
			Get
				Return Me._txtTubingPressure
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTubingPressure_Enter
				Dim value3 As EventHandler = AddressOf Me.txtTubingPressure_Leave
				Dim value4 As KeyEventHandler = AddressOf Me.txtTubingPressure_KeyDown
				Dim value5 As EventHandler = AddressOf Me.txtTubingPressure_TextChanged
				If Me._txtTubingPressure IsNot Nothing Then
					RemoveHandler Me._txtTubingPressure.Enter, value2
					RemoveHandler Me._txtTubingPressure.Leave, value3
					RemoveHandler Me._txtTubingPressure.KeyDown, value4
					RemoveHandler Me._txtTubingPressure.TextChanged, value5
				End If
				Me._txtTubingPressure = value
				If Me._txtTubingPressure IsNot Nothing Then
					AddHandler Me._txtTubingPressure.Enter, value2
					AddHandler Me._txtTubingPressure.Leave, value3
					AddHandler Me._txtTubingPressure.KeyDown, value4
					AddHandler Me._txtTubingPressure.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property txtRuntime As TextBox
			Get
				Return Me._txtRuntime
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtRuntime_Enter
				Dim value3 As EventHandler = AddressOf Me.txtRuntime_Leave
				Dim value4 As KeyEventHandler = AddressOf Me.txtRuntime_KeyDown
				Dim value5 As EventHandler = AddressOf Me.txtRuntime_TextChanged
				If Me._txtRuntime IsNot Nothing Then
					RemoveHandler Me._txtRuntime.Enter, value2
					RemoveHandler Me._txtRuntime.Leave, value3
					RemoveHandler Me._txtRuntime.KeyDown, value4
					RemoveHandler Me._txtRuntime.TextChanged, value5
				End If
				Me._txtRuntime = value
				If Me._txtRuntime IsNot Nothing Then
					AddHandler Me._txtRuntime.Enter, value2
					AddHandler Me._txtRuntime.Leave, value3
					AddHandler Me._txtRuntime.KeyDown, value4
					AddHandler Me._txtRuntime.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property txtPumpDepth As TextBox
			Get
				Return Me._txtPumpDepth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtPumpDepth_Enter
				Dim value3 As EventHandler = AddressOf Me.txtPumpDepth_Leave
				Dim value4 As KeyEventHandler = AddressOf Me.txtPumpDepth_KeyDown
				Dim value5 As EventHandler = AddressOf Me.txtPumpDepth_TextChanged
				If Me._txtPumpDepth IsNot Nothing Then
					RemoveHandler Me._txtPumpDepth.Enter, value2
					RemoveHandler Me._txtPumpDepth.Leave, value3
					RemoveHandler Me._txtPumpDepth.KeyDown, value4
					RemoveHandler Me._txtPumpDepth.TextChanged, value5
				End If
				Me._txtPumpDepth = value
				If Me._txtPumpDepth IsNot Nothing Then
					AddHandler Me._txtPumpDepth.Enter, value2
					AddHandler Me._txtPumpDepth.Leave, value3
					AddHandler Me._txtPumpDepth.KeyDown, value4
					AddHandler Me._txtPumpDepth.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property txtUserDate As TextBox
			Get
				Return Me._txtUserDate
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtUserDate_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtUserDate_Enter
				Dim value4 As EventHandler = AddressOf Me.txtUserDate_Leave
				If Me._txtUserDate IsNot Nothing Then
					RemoveHandler Me._txtUserDate.TextChanged, value2
					RemoveHandler Me._txtUserDate.Enter, value3
					RemoveHandler Me._txtUserDate.Leave, value4
				End If
				Me._txtUserDate = value
				If Me._txtUserDate IsNot Nothing Then
					AddHandler Me._txtUserDate.TextChanged, value2
					AddHandler Me._txtUserDate.Enter, value3
					AddHandler Me._txtUserDate.Leave, value4
				End If
			End Set
		End Property

		Public Overridable Property txtUserName As TextBox
			Get
				Return Me._txtUserName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtUserName_Enter
				Dim value3 As EventHandler = AddressOf Me.txtUserName_Leave
				Dim value4 As EventHandler = AddressOf Me.txtUserName_TextChanged
				If Me._txtUserName IsNot Nothing Then
					RemoveHandler Me._txtUserName.Enter, value2
					RemoveHandler Me._txtUserName.Leave, value3
					RemoveHandler Me._txtUserName.TextChanged, value4
				End If
				Me._txtUserName = value
				If Me._txtUserName IsNot Nothing Then
					AddHandler Me._txtUserName.Enter, value2
					AddHandler Me._txtUserName.Leave, value3
					AddHandler Me._txtUserName.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property txtWellName As TextBox
			Get
				Return Me._txtWellName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtWellName_Leave
				Dim value3 As EventHandler = AddressOf Me.txtWellName_Enter
				Dim value4 As EventHandler = AddressOf Me.txtWellName_TextChanged
				If Me._txtWellName IsNot Nothing Then
					RemoveHandler Me._txtWellName.Leave, value2
					RemoveHandler Me._txtWellName.Enter, value3
					RemoveHandler Me._txtWellName.TextChanged, value4
				End If
				Me._txtWellName = value
				If Me._txtWellName IsNot Nothing Then
					AddHandler Me._txtWellName.Leave, value2
					AddHandler Me._txtWellName.Enter, value3
					AddHandler Me._txtWellName.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property txtCompanyName As TextBox
			Get
				Return Me._txtCompanyName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtCompanyName_Leave
				Dim value3 As EventHandler = AddressOf Me.txtCompanyName_Enter
				Dim value4 As EventHandler = AddressOf Me.txtCompanyName_TextChanged
				If Me._txtCompanyName IsNot Nothing Then
					RemoveHandler Me._txtCompanyName.Leave, value2
					RemoveHandler Me._txtCompanyName.Enter, value3
					RemoveHandler Me._txtCompanyName.TextChanged, value4
				End If
				Me._txtCompanyName = value
				If Me._txtCompanyName IsNot Nothing Then
					AddHandler Me._txtCompanyName.Leave, value2
					AddHandler Me._txtCompanyName.Enter, value3
					AddHandler Me._txtCompanyName.TextChanged, value4
				End If
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

		Public Overridable Property _linSeparator_2 As Label
			Get
				Return Me.__linSeparator_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linSeparator_2 = value
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

		Public Overridable Property _linSeparator_0 As Label
			Get
				Return Me.__linSeparator_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linSeparator_0 = value
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

		Public Overridable Property _Label_CasingPressure As Label
			Get
				Return Me.__Label_CasingPressure
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_CasingPressure = value
			End Set
		End Property

		Public Overridable Property _Label_TubingPressure As Label
			Get
				Return Me.__Label_TubingPressure
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_TubingPressure = value
			End Set
		End Property

		Public Overridable Property _Label_RunTime As Label
			Get
				Return Me.__Label_RunTime
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_RunTime = value
			End Set
		End Property

		Public Overridable Property _Label_PumpDepth As Label
			Get
				Return Me.__Label_PumpDepth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_PumpDepth = value
			End Set
		End Property

		Public Overridable Property _Label_OilAPI As Label
			Get
				Return Me.__Label_OilAPI
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me._Label_OilAPI_TextChanged
				If Me.__Label_OilAPI IsNot Nothing Then
					RemoveHandler Me.__Label_OilAPI.TextChanged, value2
				End If
				Me.__Label_OilAPI = value
				If Me.__Label_OilAPI IsNot Nothing Then
					AddHandler Me.__Label_OilAPI.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _Label_FluidSPGR As Label
			Get
				Return Me.__Label_FluidSPGR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_FluidSPGR = value
			End Set
		End Property

		Public Overridable Property _Label_WaterSPGR As Label
			Get
				Return Me.__Label_WaterSPGR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_WaterSPGR = value
			End Set
		End Property

		Public Overridable Property _Label_WaterCut As Label
			Get
				Return Me.__Label_WaterCut
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_WaterCut = value
			End Set
		End Property

		Public Overridable Property _Label_WellName As Label
			Get
				Return Me.__Label_WellName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_WellName = value
			End Set
		End Property

		Public Overridable Property _Label_UserDate As Label
			Get
				Return Me.__Label_UserDate
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_UserDate = value
			End Set
		End Property

		Public Overridable Property _Label_UserName As Label
			Get
				Return Me.__Label_UserName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_UserName = value
			End Set
		End Property

		Public Overridable Property _Label_CompanyName As Label
			Get
				Return Me.__Label_CompanyName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_CompanyName = value
			End Set
		End Property

		Public Overridable Property _Label_Comment As Label
			Get
				Return Me.__Label_Comment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_Comment = value
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

		Public Overridable Property txtPumpLoadAdj As TextBox
			Get
				Return Me._txtPumpLoadAdj
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.txtPumpLoadAdj_KeyDown
				Dim value3 As EventHandler = AddressOf Me.txtPumpLoadAdj_Enter
				Dim value4 As EventHandler = AddressOf Me.txtPumpLoadAdj_Leave
				Dim value5 As EventHandler = AddressOf Me.txtPumpLoadAdj_TextChanged
				If Me._txtPumpLoadAdj IsNot Nothing Then
					RemoveHandler Me._txtPumpLoadAdj.KeyDown, value2
					RemoveHandler Me._txtPumpLoadAdj.Enter, value3
					RemoveHandler Me._txtPumpLoadAdj.Leave, value4
					RemoveHandler Me._txtPumpLoadAdj.TextChanged, value5
				End If
				Me._txtPumpLoadAdj = value
				If Me._txtPumpLoadAdj IsNot Nothing Then
					AddHandler Me._txtPumpLoadAdj.KeyDown, value2
					AddHandler Me._txtPumpLoadAdj.Enter, value3
					AddHandler Me._txtPumpLoadAdj.Leave, value4
					AddHandler Me._txtPumpLoadAdj.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property txtStuffingBoxFriction As TextBox
			Get
				Return Me._txtStuffingBoxFriction
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.txtStuffingBoxFriction_KeyDown
				Dim value3 As EventHandler = AddressOf Me.txtStuffingBoxFriction_Enter
				Dim value4 As EventHandler = AddressOf Me.txtStuffingBoxFriction_Leave
				Dim value5 As EventHandler = AddressOf Me.txtStuffingBoxFriction_TextChanged
				If Me._txtStuffingBoxFriction IsNot Nothing Then
					RemoveHandler Me._txtStuffingBoxFriction.KeyDown, value2
					RemoveHandler Me._txtStuffingBoxFriction.Enter, value3
					RemoveHandler Me._txtStuffingBoxFriction.Leave, value4
					RemoveHandler Me._txtStuffingBoxFriction.TextChanged, value5
				End If
				Me._txtStuffingBoxFriction = value
				If Me._txtStuffingBoxFriction IsNot Nothing Then
					AddHandler Me._txtStuffingBoxFriction.KeyDown, value2
					AddHandler Me._txtStuffingBoxFriction.Enter, value3
					AddHandler Me._txtStuffingBoxFriction.Leave, value4
					AddHandler Me._txtStuffingBoxFriction.TextChanged, value5
				End If
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

		Public Overridable Property txtPumpFillage As TextBox
			Get
				Return Me._txtPumpFillage
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtPumpFillage_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.txtPumpFillage_TextChanged
				Dim value4 As EventHandler = AddressOf Me.txtPumpFillage_Leave
				Dim value5 As EventHandler = AddressOf Me.txtPumpFillage_Enter
				If Me._txtPumpFillage IsNot Nothing Then
					RemoveHandler Me._txtPumpFillage.EnabledChanged, value2
					RemoveHandler Me._txtPumpFillage.TextChanged, value3
					RemoveHandler Me._txtPumpFillage.Leave, value4
					RemoveHandler Me._txtPumpFillage.Enter, value5
				End If
				Me._txtPumpFillage = value
				If Me._txtPumpFillage IsNot Nothing Then
					AddHandler Me._txtPumpFillage.EnabledChanged, value2
					AddHandler Me._txtPumpFillage.TextChanged, value3
					AddHandler Me._txtPumpFillage.Leave, value4
					AddHandler Me._txtPumpFillage.Enter, value5
				End If
			End Set
		End Property

		Public Overridable Property txtPumpEfficiency As TextBox
			Get
				Return Me._txtPumpEfficiency
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtPumpEfficiency_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.txtPumpEfficiency_TextChanged
				Dim value4 As EventHandler = AddressOf Me.txtPumpEfficiency_Leave
				Dim value5 As EventHandler = AddressOf Me.txtPumpEfficiency_Enter
				If Me._txtPumpEfficiency IsNot Nothing Then
					RemoveHandler Me._txtPumpEfficiency.EnabledChanged, value2
					RemoveHandler Me._txtPumpEfficiency.TextChanged, value3
					RemoveHandler Me._txtPumpEfficiency.Leave, value4
					RemoveHandler Me._txtPumpEfficiency.Enter, value5
				End If
				Me._txtPumpEfficiency = value
				If Me._txtPumpEfficiency IsNot Nothing Then
					AddHandler Me._txtPumpEfficiency.EnabledChanged, value2
					AddHandler Me._txtPumpEfficiency.TextChanged, value3
					AddHandler Me._txtPumpEfficiency.Leave, value4
					AddHandler Me._txtPumpEfficiency.Enter, value5
				End If
			End Set
		End Property

		Public Overridable Property _optPumpCondition_0 As RadioButton
			Get
				Return Me.__optPumpCondition_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPumpCondition_0_CheckedChanged
				If Me.__optPumpCondition_0 IsNot Nothing Then
					RemoveHandler Me.__optPumpCondition_0.CheckedChanged, value2
				End If
				Me.__optPumpCondition_0 = value
				If Me.__optPumpCondition_0 IsNot Nothing Then
					AddHandler Me.__optPumpCondition_0.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optPumpCondition_3 As RadioButton
			Get
				Return Me.__optPumpCondition_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPumpCondition_3_CheckedChanged
				If Me.__optPumpCondition_3 IsNot Nothing Then
					RemoveHandler Me.__optPumpCondition_3.CheckedChanged, value2
				End If
				Me.__optPumpCondition_3 = value
				If Me.__optPumpCondition_3 IsNot Nothing Then
					AddHandler Me.__optPumpCondition_3.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optPumpCondition_2 As RadioButton
			Get
				Return Me.__optPumpCondition_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPumpCondition_2_CheckedChanged
				If Me.__optPumpCondition_2 IsNot Nothing Then
					RemoveHandler Me.__optPumpCondition_2.CheckedChanged, value2
				End If
				Me.__optPumpCondition_2 = value
				If Me.__optPumpCondition_2 IsNot Nothing Then
					AddHandler Me.__optPumpCondition_2.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optPumpCondition_1 As RadioButton
			Get
				Return Me.__optPumpCondition_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPumpCondition_1_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me._optPumpCondition_1_CheckedChanged
				If Me.__optPumpCondition_1 IsNot Nothing Then
					RemoveHandler Me.__optPumpCondition_1.EnabledChanged, value2
					RemoveHandler Me.__optPumpCondition_1.CheckedChanged, value3
				End If
				Me.__optPumpCondition_1 = value
				If Me.__optPumpCondition_1 IsNot Nothing Then
					AddHandler Me.__optPumpCondition_1.EnabledChanged, value2
					AddHandler Me.__optPumpCondition_1.CheckedChanged, value3
				End If
			End Set
		End Property

		Public Overridable Property lblStuffingBoxFriction As Label
			Get
				Return Me._lblStuffingBoxFriction
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblStuffingBoxFriction = value
			End Set
		End Property

		Public Overridable Property lblPumpLoadAdj As Label
			Get
				Return Me._lblPumpLoadAdj
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPumpLoadAdj = value
			End Set
		End Property

		Friend Overridable Property lblPumpEfficiency_Disabled As Label
			Get
				Return Me._lblPumpEfficiency_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPumpEfficiency_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblPumpFillage_Disabled As Label
			Get
				Return Me._lblPumpFillage_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPumpFillage_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblFluidSPGR_Disabled As Label
			Get
				Return Me._lblFluidSPGR_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFluidSPGR_Disabled = value
			End Set
		End Property

		Public Overridable Property _Label_PumpEfficiency As Label
			Get
				Return Me.__Label_PumpEfficiency
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_PumpEfficiency = value
			End Set
		End Property

		Public Overridable Property _Label_PumpFillage As Label
			Get
				Return Me.__Label_PumpFillage
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_PumpFillage = value
			End Set
		End Property

		Public Overridable Property _Label_PumpCondition As Label
			Get
				Return Me.__Label_PumpCondition
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_PumpCondition = value
			End Set
		End Property

		Friend Overridable Property btnUpdateDate As Button
			Get
				Return Me._btnUpdateDate
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnUpdateDate_Click
				If Me._btnUpdateDate IsNot Nothing Then
					RemoveHandler Me._btnUpdateDate.Click, value2
				End If
				Me._btnUpdateDate = value
				If Me._btnUpdateDate IsNot Nothing Then
					AddHandler Me._btnUpdateDate.Click, value2
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

		Friend Overridable Property btnCoverPageComments As Button
			Get
				Return Me._btnCoverPageComments
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
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

		Public Overridable Property cboPRDiameter As ComboBox
			Get
				Return Me._cboPRDiameter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboPRDiameter_SelectedIndexChanged
				If Me._cboPRDiameter IsNot Nothing Then
					RemoveHandler Me._cboPRDiameter.SelectedIndexChanged, value2
				End If
				Me._cboPRDiameter = value
				If Me._cboPRDiameter IsNot Nothing Then
					AddHandler Me._cboPRDiameter.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtPRDiameter As TextBox
			Get
				Return Me._txtPRDiameter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.txtPRDiameter_KeyDown
				Dim value3 As EventHandler = AddressOf Me.txtPRDiameter_Enter
				Dim value4 As EventHandler = AddressOf Me.txtPRDiameter_EnabledChanged
				Dim value5 As EventHandler = AddressOf Me.txtPRDiameter_Leave
				Dim value6 As EventHandler = AddressOf Me.txtPRDiameter_TextChanged
				If Me._txtPRDiameter IsNot Nothing Then
					RemoveHandler Me._txtPRDiameter.KeyDown, value2
					RemoveHandler Me._txtPRDiameter.Enter, value3
					RemoveHandler Me._txtPRDiameter.EnabledChanged, value4
					RemoveHandler Me._txtPRDiameter.Leave, value5
					RemoveHandler Me._txtPRDiameter.TextChanged, value6
				End If
				Me._txtPRDiameter = value
				If Me._txtPRDiameter IsNot Nothing Then
					AddHandler Me._txtPRDiameter.KeyDown, value2
					AddHandler Me._txtPRDiameter.Enter, value3
					AddHandler Me._txtPRDiameter.EnabledChanged, value4
					AddHandler Me._txtPRDiameter.Leave, value5
					AddHandler Me._txtPRDiameter.TextChanged, value6
				End If
			End Set
		End Property

		Friend Overridable Property lblPRDiameter_Disabled As Label
			Get
				Return Me._lblPRDiameter_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPRDiameter_Disabled = value
			End Set
		End Property

		Public Overridable Property lblPRDiam As Label
			Get
				Return Me._lblPRDiam
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPRDiam = value
			End Set
		End Property

		Private Sub WellInfo_DoubleClick(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_KeyDown(sender As Object, e As KeyEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_MouseClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_TextChanged(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_Validating(sender As Object, e As CancelEventArgs)
			Try
				Me.ValidateWellInfoData(True)
			Catch ex As Exception
			End Try
		End Sub

		Public Function ValidateWellInfoData(Optional bQuiet As Boolean = True) As Boolean
			Dim flag As Boolean = True
			Dim sMsg As String = ""
			Dim flag2 As Boolean = False
			Dim result As Boolean
			Try
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				If Me.MyParentFrm IsNot Nothing Then
					If Not Me.MyParentFrm.bClosing Then
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						Dim num As Single
						If Not bQuiet Then
							If Operators.CompareString(rst.WellName, "", False) = 0 Then
								Me.DisplayWellInfoError("Please enter a value for Well Name", flag2)
								If Not flag2 Then
									Dim control As Control = Me.txtWellName
									Me.SetActiveControl(control)
									Me.txtWellName = CType(control, TextBox)
									flag = False
								End If
							ElseIf rst.PumpDepth = 0F Or Operators.CompareString(Me.txtPumpDepth.Text, "", False) = 0 Then
								Me.DisplayWellInfoError("Please enter a value for Pump Depth", flag2)
								If Not flag2 Then
									Dim control As Control = Me.txtPumpDepth
									Me.SetActiveControl(control)
									Me.txtPumpDepth = CType(control, TextBox)
									flag = False
								End If
							Else
								Dim cRODSTAR As cRODSTAR = rst
								Dim obj As Object = cRODSTAR.PumpDepth
								Dim checkLowerMsg As Object = Util.GetCheckLowerMsg(obj, 100F, -1, 41, -1, 0, sMsg)
								cRODSTAR.PumpDepth = Conversions.ToSingle(obj)
								If Conversions.ToBoolean(checkLowerMsg) Then
									Me.DisplayWellInfoError(sMsg, flag2)
									If Not flag2 Then
										Dim control As Control = Me.txtPumpDepth
										Me.SetActiveControl(control)
										Me.txtPumpDepth = CType(control, TextBox)
										flag = False
									End If
								Else
									cRODSTAR = rst
									obj = cRODSTAR.PumpDepth
									Dim checkUpperMsg As Object = Util.GetCheckUpperMsg(obj, 20000F, -1, 41, -1, 0, sMsg)
									cRODSTAR.PumpDepth = Conversions.ToSingle(obj)
									If Conversions.ToBoolean(checkUpperMsg) Then
										Me.DisplayWellInfoError(sMsg, flag2)
										If Not flag2 Then
											Dim control As Control = Me.txtPumpDepth
											Me.SetActiveControl(control)
											Me.txtPumpDepth = CType(control, TextBox)
											flag = False
										End If
									ElseIf rst.Runtime = 0F Or Operators.CompareString(Me.txtRuntime.Text, "", False) = 0 Then
										Me.DisplayWellInfoError("Please enter a value for Run Time", flag2)
										If Not flag2 Then
											Dim control As Control = Me.txtRuntime
											Me.SetActiveControl(control)
											Me.txtRuntime = CType(control, TextBox)
											flag = False
										End If
									ElseIf rst.OilAPI = 0F Or Operators.CompareString(Me.txtOilAPI.Text, "", False) = 0 Then
										Me.DisplayWellInfoError("Please enter a value for Oil gravity (API °) ", flag2)
										If Not flag2 Then
											Dim control As Control = Me.txtOilAPI
											Me.SetActiveControl(control)
											Me.txtOilAPI = CType(control, TextBox)
											flag = False
										End If
									Else
										cRODSTAR = rst
										obj = cRODSTAR.OilAPI
										Dim checkLowerMsg2 As Object = Util.GetCheckLowerMsg(obj, 5F, -1, 35, -1, 0, sMsg)
										cRODSTAR.OilAPI = Conversions.ToSingle(obj)
										If Conversions.ToBoolean(checkLowerMsg2) Then
											Me.DisplayWellInfoError(sMsg, flag2)
											If Not flag2 Then
												Dim control As Control = Me.txtOilAPI
												Me.SetActiveControl(control)
												Me.txtOilAPI = CType(control, TextBox)
												flag = False
											End If
										Else
											cRODSTAR = rst
											obj = cRODSTAR.OilAPI
											Dim checkUpperMsg2 As Object = Util.GetCheckUpperMsg(obj, 70F, -1, 35, -1, 0, sMsg)
											cRODSTAR.OilAPI = Conversions.ToSingle(obj)
											If Conversions.ToBoolean(checkUpperMsg2) Then
												Me.DisplayWellInfoError(sMsg, flag2)
												If Not flag2 Then
													Dim control As Control = Me.txtOilAPI
													Me.SetActiveControl(control)
													Me.txtOilAPI = CType(control, TextBox)
													flag = False
												End If
											ElseIf rst.WaterSPGR = 0F Or Operators.CompareString(Me.txtWaterSPGR.Text, "", False) = 0 Then
												Me.DisplayWellInfoError("Please enter a value for Water SPGR", flag2)
												If Not flag2 Then
													Dim control As Control = Me.txtWaterSPGR
													Me.SetActiveControl(control)
													Me.txtWaterSPGR = CType(control, TextBox)
													flag = False
												End If
											ElseIf Not rst.gbCalcFluidSPGR And (Operators.CompareString(Me.txtFluidSPGR.Text, "", False) = 0 Or rst.FluidSPGR = 0F) Then
												Me.DisplayWellInfoError("Please enter a value for Fliud SPGR", flag2)
												If Not flag2 Then
													Dim control As Control = Me.txtFluidSPGR
													Me.SetActiveControl(control)
													Me.txtFluidSPGR = CType(control, TextBox)
													flag = False
												End If
											ElseIf rst.gbCalcFluidSPGR Then
												rst.gfMaxFluidSPGR = Me.MaxFluidSPGR(rst.WaterCut, rst.WaterSPGR, rst.OilSPGR)
												rst.FluidSPGR = rst.gfMaxFluidSPGR
											ElseIf rst.PR_Diameter < 1F Or rst.PR_Diameter > 2F Then
												If rst.PR_Diameter < 1F Then
													MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("The polished rod diameter cannot be less than 1" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", "  (25.4 mm)"))))
												ElseIf rst.PR_Diameter > 2F Then
													MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("The polished rod diameter cannot be greater than 2" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", "  (50.8 mm)"))))
												End If
												Dim control As Control = Me.txtPRDiameter
												Me.SetActiveControl(control)
												Me.txtPRDiameter = CType(control, TextBox)
												flag = False
											Else
												cRODSTAR = rst
												obj = cRODSTAR.StuffingBoxFriction
												Dim checkUpperMsg3 As Object = Util.GetCheckUpperMsg(obj, 2000F, -1, 75, -1, 0, sMsg)
												cRODSTAR.StuffingBoxFriction = Conversions.ToSingle(obj)
												If Conversions.ToBoolean(checkUpperMsg3) Then
													Dim control As Control = Me.txtStuffingBoxFriction
													Me.SetActiveControl(control)
													Me.txtStuffingBoxFriction = CType(control, TextBox)
													flag = False
												End If
											End If
										End If
									End If
								End If
							End If
							If flag And RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
								Dim flag3 As Boolean = False
								Dim flag4 As Boolean = flag3
								Dim txtPumpDepth As TextBox = Me.txtPumpDepth
								Dim bValidIfEmpty As Boolean = 1
								Dim bShowMessage As Boolean = 0
								Dim obj As Object = num
								Dim flag5 As Boolean = CtrlUI.CheckValid(txtPumpDepth, bValidIfEmpty, bShowMessage, obj)
								num = Conversions.ToSingle(obj)
								If flag4 <> flag5 Then
									Dim obj2 As Object = flag3
									obj = num
									Dim lowerBound As Single = 100F
									Dim inclusive As Integer = -1
									Dim errnum As Integer = 41
									Dim useMetric As Integer = -1
									Dim canadianIsMetric As Integer = -1
									Dim bQuiet2 As Boolean = False
									Dim text As String = ""
									Dim obj3 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet2, text)
									num = Conversions.ToSingle(obj)
									If Operators.ConditionalCompareObjectEqual(obj2, obj3, False) Then
										Dim control As Control = Me.txtPumpDepth
										Me.SetActiveControl(control)
										Me.txtPumpDepth = CType(control, TextBox)
										flag = False
									Else
										Dim obj4 As Object = flag3
										obj = num
										Dim upperBound As Single = 20000F
										Dim inclusive2 As Integer = -1
										Dim errnum2 As Integer = 41
										Dim useMetric2 As Integer = -1
										Dim canadianIsMetric2 As Integer = -1
										Dim bQuiet3 As Boolean = False
										text = ""
										Dim obj5 As Object = Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet3, text)
										num = Conversions.ToSingle(obj)
										If Operators.ConditionalCompareObjectEqual(obj4, obj5, False) Then
											Dim control As Control = Me.txtPumpDepth
											Me.SetActiveControl(control)
											Me.txtPumpDepth = CType(control, TextBox)
											flag = False
										End If
									End If
								End If
							End If
						End If
						rst.ACompanyName = Me.txtCompanyName.Text
						rst.WellName = Me.txtWellName.Text
						rst.UserName = Me.txtUserName.Text
						rst.UserDate = Me.txtUserDate.Text
						rst.FileComment = Me.txtComment.Text
						rst.Runtime = Conversions.ToSingle(Interaction.IIf(Operators.CompareString(Me.txtRuntime.Text, "", False) <> 0, Convert.ToSingle(Me.txtRuntime.Text), 0.0))
						rst.gbCalcFluidSPGR = Me.chkCalcFluidSPGR.Checked
						If rst.gbCalcFluidSPGR Then
							Me.CheckFluidSPGR()
							rst.FluidSPGR = rst.gfMaxFluidSPGR
						End If
						If RSWIN_DESC.bRodStarD Then
							rst.gbParaffin = Me.chkParaffin.Checked
							Dim txtParaffinDepth As TextBox = Me.txtParaffinDepth
							Dim bValidIfEmpty2 As Boolean = True
							Dim bShowMessage2 As Boolean = False
							Dim obj As Object = num
							Dim flag6 As Boolean = CtrlUI.CheckValid(txtParaffinDepth, bValidIfEmpty2, bShowMessage2, obj)
							num = Conversions.ToSingle(obj)
							If flag6 Then
								RSWIN_DESC.rst.ParaffinDepth = num
							End If
						End If
						If(RSWIN_DESC.NewData(1) And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							RSWIN_DESC.NewData(1) = 0S
							ini.SaveDataValue("WellInfo", True)
						End If
						If Not bQuiet Then
							Me.m_bValidated = True
						End If
						RSWIN_DESC.frmMain.ToolbarButtonSetState(15, Me.CheckRequiredTextFields())
						result = flag
					Else
						result = True
					End If
				Else
					result = True
				End If
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub InitWellInfo()
			RSWIN_DESC.sNull = ""
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			cRODSTAR.ACompanyName = Conversions.ToString(ini.GetDataValue("CompanyName", 8, True, RSWIN_DESC.sNull))
			cRODSTAR.WellName = Conversions.ToString(ini.GetDataValue("WellName", 8, False, RSWIN_DESC.sNull))
			cRODSTAR.UserName = Conversions.ToString(ini.GetDataValue("UserName", 8, True, RSWIN_DESC.sNull))
			cRODSTAR.UserDate = Conversions.ToString(ini.GetDataValue("UserDate", 8, False, DateAndTime.Now.ToLongDateString()))
			cRODSTAR.FileComment = Conversions.ToString(ini.GetDataValue("FileComment", 8, False, RSWIN_DESC.sNull))
			Me.txtCompanyName.Text = Strings.Trim(cRODSTAR.ACompanyName)
			Me.txtWellName.Text = Strings.Trim(cRODSTAR.WellName)
			Me.txtUserName.Text = Strings.Trim(cRODSTAR.UserName)
			Me.txtUserDate.Text = Strings.Trim(cRODSTAR.UserDate)
			Me.txtComment.Text = Strings.Trim(cRODSTAR.FileComment)
			Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpDepth", 4, False, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				Me.txtPumpDepth_TextChanged(Me.txtPumpDepth, New EventArgs())
			Else
				cRODSTAR.PumpDepth = Conversions.ToSingle(obj)
				Me.txtPumpDepth.Tag = "fem"
				Me.txtPumpDepth.Text = Convert.ToString(cRODSTAR.PumpDepth)
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RunTime", 4, True, DBNull.Value))
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				cRODSTAR.Runtime = Conversions.ToSingle(obj)
				Me.txtRuntime.Text = Convert.ToString(cRODSTAR.Runtime)
			End If
			cRODSTAR.PumpLoadAdj = Conversions.ToSingle(ini.GetDataValue("PumpLoadAdjustment", 4, True, 0))
			If RSWIN_DESC.bRodStarD Then
				cRODSTAR.PumpLoadAdj = 0F
			Else
				Me.txtPumpLoadAdj.Text = Convert.ToString(cRODSTAR.PumpLoadAdj)
			End If
			cRODSTAR.StuffingBoxFriction = Conversions.ToSingle(ini.GetDataValue("StuffingBoxFriction", 4, True, 100))
			Me.txtStuffingBoxFriction.Text = Convert.ToString(cRODSTAR.StuffingBoxFriction)
			cRODSTAR.TubingPressure = Conversions.ToSingle(ini.GetDataValue("TubingPressure", 4, True, 50))
			Me.txtTubingPressure.Text = Convert.ToString(cRODSTAR.TubingPressure)
			cRODSTAR.CasingPressure = Conversions.ToSingle(ini.GetDataValue("CasingPressure", 4, True, 50))
			Me.txtCasingPressure.Text = Convert.ToString(cRODSTAR.CasingPressure)
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("WaterCut", 4, True, DBNull.Value))
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
					Me.txtWaterCut.Text = ""
				Else
					cRODSTAR.WaterCut = Conversions.ToSingle(obj)
					Me.txtWaterCut.Text = Convert.ToString(cRODSTAR.WaterCut)
				End If
			End If
			cRODSTAR.WaterSPGR = Conversions.ToSingle(ini.GetDataValue("WaterSPGR", 4, True, 1))
			Me.txtWaterSPGR.Text = Convert.ToString(cRODSTAR.WaterSPGR)
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("OilGravity", 4, True, DBNull.Value))
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
					Me.txtOilAPI.Text = ""
				Else
					cRODSTAR.OilAPI = Conversions.ToSingle(obj)
					cRODSTAR.OilSPGR = CSng((141.5 / (CDbl(cRODSTAR.OilAPI) + 131.5)))
					Me.txtOilAPI.Text = Convert.ToString(cRODSTAR.OilAPI)
				End If
			End If
			Dim num As Single
			If RSWIN_DESC.bRodStarD Then
				cRODSTAR.gbParaffin = Conversions.ToBoolean(ini.GetDataValue("Paraffin", 11, False, False))
				Me.chkParaffin.Checked = cRODSTAR.gbParaffin
				obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("ParaffinDepth", 4, False, DBNull.Value))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) And RSWIN_DESC.rst.PumpDepth > 0F Then
					num = RSWIN_DESC.rst.PumpDepth / 3F
					Dim sDynoCard As String = "######.##"
					obj = Util.Format(num, sDynoCard)
					cRODSTAR.ParaffinDepth = Conversions.ToSingle(obj)
					Me.txtParaffinDepth.Tag = "fem"
					Me.txtParaffinDepth.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(obj))
				ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(obj, 0, False), RSWIN_DESC.rst.PumpDepth > 0F)) Then
						num = RSWIN_DESC.rst.PumpDepth / 3F
						Dim sDynoCard As String = "######.##"
						obj = Util.Format(num, sDynoCard)
					End If
					cRODSTAR.ParaffinDepth = Conversions.ToSingle(obj)
					Me.txtParaffinDepth.Tag = "fem"
					Me.txtParaffinDepth.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(obj))
				End If
				If cRODSTAR.gbParaffin Then
					Me.txtParaffinDepth.BringToFront()
					Me.lblParaffinDepth_Disabled.SendToBack()
				Else
					Me.txtParaffinDepth.SendToBack()
					Me.lblParaffinDepth_Disabled.BringToFront()
				End If
				Me.chkParaffin.Visible = True
				Me.txtParaffinDepth.Visible = True
				Me.lblParaffinDepth_Disabled.Visible = True
				Me._Label_ParaffinDepth.Visible = True
				Me._linSeparator_4.Visible = True
				Me._linSeparator_5.Visible = True
			Else
				Me.chkParaffin.Visible = False
				Me.txtParaffinDepth.Visible = False
				Me.lblParaffinDepth_Disabled.Visible = False
				Me._Label_ParaffinDepth.Visible = False
				Me._linSeparator_4.Visible = False
				Me._linSeparator_5.Visible = False
			End If
			cRODSTAR.gbCalcFluidSPGR = Conversions.ToBoolean(ini.GetDataValue("CalcFluidSPGR", 11, False, True))
			Me.chkCalcFluidSPGR.Checked = cRODSTAR.gbCalcFluidSPGR
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("FluidSPGR", 4, False, DBNull.Value))
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
					Me.txtFluidSPGR.Text = ""
				Else
					cRODSTAR.FluidSPGR = Conversions.ToSingle(obj)
					Me.txtFluidSPGR.Text = Convert.ToString(cRODSTAR.FluidSPGR)
				End If
			Else
				Me.txtFluidSPGR.Text = ""
			End If
			If cRODSTAR.gbCalcFluidSPGR Then
				Me.CheckFluidSPGR()
			End If
			cRODSTAR.DynaSource = Conversions.ToShort(ini.GetDataValue("DynaSource", 3, False, 0))
			Dim num2 As Short
			Select Case cRODSTAR.DynaSource
				Case 0S
					cRODSTAR.dNtsteps = 0S
					cRODSTAR.Npoints = 0S
					cRODSTAR.LeutertDynamometer = 0S
					num2 = -1S
				Case 1S, 2S
					cRODSTAR.DynaSource = -1S
				Case 3S
					obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("DynoCard", 3, False, 0))
					cRODSTAR.DynaFile = Conversions.ToString(ini.GetDataValue("DynaFile", 8, False, RSWIN_DESC.sNull))
					cRODSTAR.dNtsteps = Conversions.ToShort(ini.GetDataValue("Ntsteps", 3, False, 0))
					Dim num3 As Short
					Dim num4 As Short
					Dim array As Single() = New Single(CInt((cRODSTAR.dNtsteps - 1S + 1S)) - 1) {}
					cRODSTAR.dSurfPos = array
					array = New Single(CInt((cRODSTAR.dNtsteps - 1S + 1S)) - 1) {}
					cRODSTAR.dSurfLoad = array
					cRODSTAR.sDynoCard = Conversions.ToString(ini.GetDataValue("DynoCard", 8, False, RSWIN_DESC.sNull))
					num3 = 0S
					num4 = cRODSTAR.dNtsteps - 1S
					For num5 As Short = num3 To num4
						Dim cRODSTAR2 As cRODSTAR = cRODSTAR
						Dim sDynoCard As String = cRODSTAR2.sDynoCard
						Dim token As String = Util.GetToken(sDynoCard, ";")
						cRODSTAR2.sDynoCard = sDynoCard
						Dim value As String = token
						cRODSTAR.dSurfPos(CInt(num5)) = CSng(Convert.ToDouble(Util.GetToken(value, ",")))
						cRODSTAR.dSurfLoad(CInt(num5)) = CSng(Convert.ToDouble(value))
					Next
					cRODSTAR.bCBEFromDisk = Conversions.ToShort(ini.GetDataValue("CBEFromDisk", 11, False, False))
					cRODSTAR.MeasuredRuntime = Conversions.ToSingle(ini.GetDataValue("MeasuredRuntime", 4, False, 0))
					cRODSTAR.MeasuredSPM = Conversions.ToSingle(ini.GetDataValue("MeasuredSPM", 4, False, 0))
					cRODSTAR.MeasuredStroke = Conversions.ToSingle(ini.GetDataValue("MeasuredStroke", 4, False, 0))
					cRODSTAR.MeasuredCBEffect = Conversions.ToSingle(ini.GetDataValue("MeasuredCBEffect", 4, False, 0))
					cRODSTAR.MeasuredCBEpos = Conversions.ToSingle(ini.GetDataValue("MeasuredCBEpos", 4, False, 0))
					cRODSTAR.MeasuredCBEupstroke = Conversions.ToShort(ini.GetDataValue("MeasuredCBEupstroke", 11, False, False))
					cRODSTAR.MeasuredTVLoad = Conversions.ToSingle(ini.GetDataValue("MeasuredTVLoad", 4, False, 0))
					cRODSTAR.MeasuredSVLoad = Conversions.ToSingle(ini.GetDataValue("MeasuredSVLoad", 4, False, 0))
					cRODSTAR.Npoints = 0S
					If cRODSTAR.MeasuredSPM > 0F Then
						cRODSTAR.SPM = cRODSTAR.MeasuredSPM
					End If
					If cRODSTAR.MeasuredRuntime > 0F Then
						cRODSTAR.Runtime = 24F * cRODSTAR.MeasuredRuntime
						Me.txtRuntime.Text = Convert.ToString(cRODSTAR.Runtime)
					End If
				Case 6S
					cRODSTAR.dNtsteps = 0S
					If cRODSTAR.gbAutomaticEnabled Then
						num2 = 3S
					Else
						num2 = -1S
					End If
			End Select
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpCondition", 2, False, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				obj = RuntimeHelpers.GetObjectValue(ini.GetListDefault("PumpCondition", 1, 3))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					obj = 1
				End If
			End If
			RSWIN_DESC.rst.PumpCondition = Conversions.ToShort(obj)
			Me.SetPumpConditionValue(CInt(RSWIN_DESC.rst.PumpCondition), True)
			If RSWIN_DESC.rst.PumpCondition <> 1S Then
				RSWIN_DESC.rst.PumpFillage = Conversions.ToSingle(ini.GetDataValue("PumpFillage", 4, True, 85))
				If RSWIN_DESC.rst.PumpFillage <> 0F Then
					Me.txtPumpFillage.Text = Conversions.ToString(RSWIN_DESC.rst.PumpFillage)
				End If
			End If
			RSWIN_DESC.rst.PumpEfficiency = Conversions.ToSingle(ini.GetDataValue("PumpEfficiency", 4, True, 85))
			Me.txtPumpEfficiency.Text = Conversions.ToString(RSWIN_DESC.rst.PumpEfficiency)
			If num2 = -1S Then
				num2 = 0S
			End If
			Me.bDynaSourceClicked = False
			cRODSTAR.gbClampOn = Conversions.ToShort(ini.GetDataValue("Clampon", 11, False, False))
			cRODSTAR.giDynoCorrectKinematic = Conversions.ToShort(ini.GetDataValue("DynoCorrectKinematic", 11, False, False))
			cRODSTAR.giDynoCorrectPhase = Conversions.ToShort(ini.GetDataValue("DynoCorrectPhase", 11, False, False))
			cRODSTAR.gfDynoPhaseAdjustment = Conversions.ToSingle(ini.GetDataValue("DynoPhaseAdjustment", 4, False, 0))
			cRODSTAR.gfDynoTOSAdjustment = Conversions.ToSingle(ini.GetDataValue("DynoTOSAdjustment", 4, False, 0))
			cRODSTAR.giDynoDetectKinematic = Conversions.ToShort(ini.GetDataValue("DynoDetectKinematic", 11, False, -1))
			cRODSTAR.giDynoDetectPhase = Conversions.ToShort(ini.GetDataValue("DynoDetectPhase", 11, False, -1))
			Try
				cRODSTAR.PR_Diameter = Conversions.ToSingle(ini.GetDataValue("PRDiameter", 4, True, 0))
			Catch ex As Exception
				cRODSTAR.PR_Diameter = 0F
			End Try
			Try
				Me.PopulatePRDiameter()
			Catch ex2 As Exception
			End Try
			If cRODSTAR.PR_Diameter = 0F Then
				' The following expression was wrapped in a checked-expression
				obj = RuntimeHelpers.GetObjectValue(ini.GetListDefault("PolishedRodDiameter", 0, Me.cboPRDiameter.Items.Count - 1))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Or obj Is Nothing Then
					cRODSTAR.PR_Diameter = 1.5F
					Me.cboPRDiameter.SelectedIndex = 3
				ElseIf Operators.ConditionalCompareObjectEqual(obj, "0", False) Then
					cRODSTAR.PR_Diameter = 1F
					Me.cboPRDiameter.SelectedIndex = 0
				ElseIf Operators.ConditionalCompareObjectEqual(obj, "1", False) Then
					cRODSTAR.PR_Diameter = 1.125F
					Me.cboPRDiameter.SelectedIndex = 1
				ElseIf Operators.ConditionalCompareObjectEqual(obj, "2", False) Then
					cRODSTAR.PR_Diameter = 1.25F
					Me.cboPRDiameter.SelectedIndex = 2
				ElseIf Operators.ConditionalCompareObjectEqual(obj, "3", False) Then
					cRODSTAR.PR_Diameter = 1.5F
					Me.cboPRDiameter.SelectedIndex = 3
				Else
					cRODSTAR.PR_Diameter = 1.5F
					Me.cboPRDiameter.SelectedIndex = 3
				End If
			ElseIf cRODSTAR.PR_Diameter = 1F Then
				Me.cboPRDiameter.SelectedIndex = 0
			ElseIf CDbl(cRODSTAR.PR_Diameter) = 1.125 Then
				Me.cboPRDiameter.SelectedIndex = 1
			ElseIf CDbl(cRODSTAR.PR_Diameter) = 1.25 Then
				Me.cboPRDiameter.SelectedIndex = 2
			ElseIf CDbl(cRODSTAR.PR_Diameter) = 1.5 Then
				Me.cboPRDiameter.SelectedIndex = 3
			Else
				Me.cboPRDiameter.SelectedIndex = 4
			End If
			Me.txtPRDiameter.Tag = "mem"
			Dim txtPRDiameter As TextBox = Me.txtPRDiameter
			num = cRODSTAR.PR_Diameter
			txtPRDiameter.Text = num.ToString()
			cRODSTAR = Nothing
		End Sub

		Private Sub WellInfo_Load(sender As Object, e As EventArgs)
			Try
				SUPERPRO.NewCheckSentinel(True)
				RSWIN_DESC.sCurrentFormName = "WellInfo"
				Me.GetMeasurementUnit()
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
				Me.m_bClosing = False
				If RSWIN_DESC.bRodStarD Then
					Me.lblPumpLoadAdj.Visible = False
					Me.txtPumpLoadAdj.Visible = False
					Me.lblPumpLoadAdj.Enabled = False
					Me.txtPumpLoadAdj.Enabled = False
					RSWIN_DESC.rst.PumpLoadAdj = 0F
				Else
					Me.lblPumpLoadAdj.Visible = True
					Me.txtPumpLoadAdj.Visible = True
					Me.lblPumpLoadAdj.Enabled = True
					Me.txtPumpLoadAdj.Enabled = True
				End If
				Me.WellInfoLoad()
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					Me._optPumpCondition_1.Checked = True
					Me._optPumpCondition_1.Enabled = False
					Me._optPumpCondition_0.Enabled = False
					Me._optPumpCondition_2.Enabled = False
					Me._optPumpCondition_3.Enabled = False
					Me.txtPumpEfficiency.Enabled = False
				End If
				RSWIN_DESC.frmMain.ToolbarButtonSetState(16, Me.CheckRequiredTextFields())
				If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter(Me.Name)
					Util.WriteControlStrings(Me, Nothing)
					Util.CloseResourceWriter()
				End If
				Me.SetWidthHeight()
				Me.SetParentWidthHeight()
				Me.ToolTip1.SetToolTip(Me.btnUpdateDate, "Change date to today's date")
				Me.ToolTip1.SetToolTip(Me.btnCoverPageComments, "Edit Cover Page Comments")
				Me.CenterForm()
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SetRequiredTextFields()
			Try
				If Operators.CompareString(Me.txtWellName.Text, "", False) = 0 Then
					Me.txtWellName.BackColor = RSWIN_DESC.rgbEditRequired
				End If
				If Operators.CompareString(Me.txtRuntime.Text, "", False) = 0 Then
					Me.txtRuntime.BackColor = RSWIN_DESC.rgbEditRequired
				End If
				If Operators.CompareString(Me.txtPumpDepth.Text, "", False) = 0 Then
					Me.txtPumpDepth.BackColor = RSWIN_DESC.rgbEditRequired
				End If
				If Operators.CompareString(Me.txtTubingPressure.Text, "", False) = 0 Then
					Me.txtTubingPressure.BackColor = RSWIN_DESC.rgbEditRequired
				End If
				If Operators.CompareString(Me.txtCasingPressure.Text, "", False) = 0 Then
					Me.txtCasingPressure.BackColor = RSWIN_DESC.rgbEditRequired
				End If
				If Operators.CompareString(Me.txtWaterCut.Text, "", False) = 0 Then
					Me.txtWaterCut.BackColor = RSWIN_DESC.rgbEditRequired
				End If
				If Operators.CompareString(Me.txtWaterSPGR.Text, "", False) = 0 Then
					Me.txtWaterSPGR.BackColor = RSWIN_DESC.rgbEditRequired
				End If
				If Operators.CompareString(Me.txtOilAPI.Text, "", False) = 0 Then
					Me.txtOilAPI.BackColor = RSWIN_DESC.rgbEditRequired
				End If
				If Operators.CompareString(Me.txtFluidSPGR.Text, "", False) = 0 Then
					Me.txtFluidSPGR.BackColor = RSWIN_DESC.rgbEditRequired
				End If
				If(Me._optPumpCondition_2.Checked Or Me._optPumpCondition_3.Checked) And Operators.CompareString(Me.txtPumpFillage.Text.Trim(), "", False) = 0 Then
					Me.txtPumpFillage.BackColor = RSWIN_DESC.rgbEditRequired
				End If
				If(Me._optPumpCondition_0.Checked Or Me._optPumpCondition_1.Checked) And Operators.CompareString(Me.txtPumpEfficiency.Text.Trim(), "", False) = 0 Then
					Me.txtPumpEfficiency.BackColor = RSWIN_DESC.rgbEditRequired
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SetRequiredTextField(myControl As TextBox)
			Try
				Dim flag As Boolean = True
				Dim flag2 As Boolean = True
				If flag2 <> (myControl Is Me.txtWellName) Then
					If flag2 <> (myControl Is Me.txtRuntime) Then
						If flag2 <> (myControl Is Me.txtPumpDepth) Then
							If flag2 <> (myControl Is Me.txtTubingPressure) Then
								If flag2 <> (myControl Is Me.txtCasingPressure) Then
									If flag2 <> (myControl Is Me.txtWaterCut) Then
										If flag2 <> (myControl Is Me.txtWaterSPGR) Then
											If flag2 <> (myControl Is Me.txtOilAPI) Then
												If flag2 <> (myControl Is Me.txtFluidSPGR) Then
													flag = False
												End If
											End If
										End If
									End If
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

		Private Function CheckRequiredTextFields() As Boolean
			Dim flag As Boolean = True
			If((Me._optPumpCondition_0.Checked Or Me._optPumpCondition_1.Checked) And Operators.CompareString(Me.txtPumpEfficiency.Text.Trim(), "", False) = 0) Or ((Me._optPumpCondition_2.Checked Or Me._optPumpCondition_3.Checked) And Operators.CompareString(Me.txtPumpFillage.Text.Trim(), "", False) = 0) Then
				flag = False
			End If
			Return(Operators.CompareString(Me.txtWellName.Text, "", False) <> 0 And Operators.CompareString(Me.txtRuntime.Text, "", False) <> 0 And Operators.CompareString(Me.txtPumpDepth.Text, "", False) <> 0 And Operators.CompareString(Me.txtTubingPressure.Text, "", False) <> 0 And Operators.CompareString(Me.txtCasingPressure.Text, "", False) <> 0 And Operators.CompareString(Me.txtWaterCut.Text, "", False) <> 0 And Operators.CompareString(Me.txtWaterSPGR.Text, "", False) <> 0 And Operators.CompareString(Me.txtOilAPI.Text, "", False) <> 0 And (Operators.CompareString(Me.txtFluidSPGR.Text, "", False) <> 0 Or Me.chkCalcFluidSPGR.Checked)) AndAlso flag
		End Function

		Private Sub WellInfoLoad()
			Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			Try
				Me.bFormLoaded = False
				RSWIN_DESC.IsRodStar = True
				If RSWIN_DESC.rst IsNot Nothing Then
					Me.lblPumpFillage_Disabled.SendToBack()
					Me.lblPumpEfficiency_Disabled.SendToBack()
					Try
						Me.PopulatePRDiameter()
					Catch ex As Exception
					End Try
					Me.bTextChanged = False
					If RSWIN_DESC.NewData(1) <> 0S Then
						Me.InitWellInfo()
					Else
						Me.LoadWellInfo()
					End If
					If Not Me.CheckFields() Then
						Me.SetFieldColors()
					End If
					Me.bTextChanged = True
				End If
				Me.txtCompanyName.Focus()
				Me.bFormLoaded = True
			Catch ex2 As Exception
				Dim sMsg As String = "Error in Load WellInfo: " + ex2.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Function MaxFluidSPGR(WaterCut As Single, WaterSPGR As Single, OilSPGR As Single) As Single
			Return WaterCut / 100F * WaterSPGR + (1F - WaterCut / 100F) * OilSPGR
		End Function

		Public Sub LoadWellInfo()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Me.txtCompanyName.Text = Strings.Trim(rst.ACompanyName)
			Me.txtWellName.Text = Strings.Trim(rst.WellName)
			Me.txtUserName.Text = Strings.Trim(rst.UserName)
			Me.txtUserDate.Text = Strings.Trim(rst.UserDate)
			Me.txtComment.Text = Strings.Trim(rst.FileComment)
			Me.txtPumpDepth.Tag = "fem"
			Me.txtPumpDepth.Text = Conversions.ToString(rst.PumpDepth)
			Me.txtRuntime.Text = Conversions.ToString(rst.Runtime)
			Me.txtTubingPressure.Tag = "pem"
			Me.txtTubingPressure.Text = Conversions.ToString(rst.TubingPressure)
			Me.txtCasingPressure.Tag = "pem"
			Me.txtCasingPressure.Text = Conversions.ToString(rst.CasingPressure)
			Me.txtWaterCut.Text = Conversions.ToString(rst.WaterCut)
			Me.txtWaterSPGR.Text = Conversions.ToString(rst.WaterSPGR)
			Me.txtOilAPI.Text = Conversions.ToString(rst.OilAPI)
			Me.txtStuffingBoxFriction.Tag = "lee"
			Dim txtStuffingBoxFriction As TextBox = Me.txtStuffingBoxFriction
			Dim fluidSPGR As Single = rst.StuffingBoxFriction
			txtStuffingBoxFriction.Text = fluidSPGR.ToString()
			If Not RSWIN_DESC.bRodStarD Then
				Dim txtPumpLoadAdj As TextBox = Me.txtPumpLoadAdj
				fluidSPGR = rst.PumpLoadAdj
				txtPumpLoadAdj.Text = fluidSPGR.ToString()
			End If
			Dim txtFluidSPGR As TextBox = Me.txtFluidSPGR
			Dim cRODSTAR As cRODSTAR = rst
			fluidSPGR = cRODSTAR.FluidSPGR
			Dim text As String = "0.0###"
			Dim text2 As String = Util.Format(fluidSPGR, text)
			cRODSTAR.FluidSPGR = fluidSPGR
			txtFluidSPGR.Text = text2
			If rst.gbCalcFluidSPGR Then
				Me.chkCalcFluidSPGR.Checked = True
				Me.CheckFluidSPGR()
				If rst.FluidSPGR = 0F Then
					rst.FluidSPGR = rst.gfMaxFluidSPGR
				End If
				If rst.FluidSPGR <> 0F Then
					Dim txtFluidSPGR2 As TextBox = Me.txtFluidSPGR
					cRODSTAR = rst
					fluidSPGR = cRODSTAR.FluidSPGR
					text = "0.0###"
					Dim text3 As String = Util.Format(fluidSPGR, text)
					cRODSTAR.FluidSPGR = fluidSPGR
					txtFluidSPGR2.Text = text3
				End If
			Else
				Me.chkCalcFluidSPGR.Checked = False
			End If
			If RSWIN_DESC.rst.gbCalcPumpCondition Then
				Me.SetPumpConditionValue(0, True)
			Else
				Me.SetPumpConditionValue(CInt(RSWIN_DESC.rst.PumpCondition), True)
				If RSWIN_DESC.rst.PumpFillage <> 0F Then
					Me.txtPumpFillage.Text = Convert.ToString(RSWIN_DESC.rst.PumpFillage)
				End If
			End If
			Me.txtPumpEfficiency.Text = Convert.ToString(RSWIN_DESC.rst.PumpEfficiency)
			If rst.dNtsteps = 0S And Not(rst.DynaSource = 6S And rst.gbAutomaticEnabled) Then
				rst.DynaSource = 0S
				rst.Npoints = 0S
				rst.CBDataType = 0S
				rst.LeutertDynamometer = 0S
			Else
				Dim num As Integer
				If rst.LeutertDynamometer <> 0S Then
					num = 5
				Else
					Select Case rst.DynaSource
						Case 1S
							num = 3
						Case 2S
							num = 4
						Case 3S
							Dim text4 As String = rst.DynaFile.Substring(0, 3)
							If Operators.CompareString(text4, ".TFR", False) = 0 Then
								num = 1
							ElseIf Operators.CompareString(text4, ".DAT", False) = 0 Then
								num = 2
							Else
								num = 0
							End If
						Case 6S
							If RSWIN_DESC.rst.gbAutomatic Then
								num = 3
							Else
								num = -1
							End If
					End Select
				End If
				If Not RSWIN_DESC.rst.gbAutomatic And num >= 3 And num <> 3 Then
					num = 3
				End If
				Me.bDynaSourceClicked = False
			End If
			If rst.PR_Diameter = 0F Then
				rst.PR_Diameter = 1.5F
			End If
			If rst.PR_Diameter = 1F Then
				Me.cboPRDiameter.SelectedIndex = 0
			ElseIf CDbl(rst.PR_Diameter) = 1.125 Then
				Me.cboPRDiameter.SelectedIndex = 1
			ElseIf CDbl(rst.PR_Diameter) = 1.25 Then
				Me.cboPRDiameter.SelectedIndex = 2
			ElseIf CDbl(rst.PR_Diameter) = 1.5 Or rst.PR_Diameter = 0F Then
				Me.cboPRDiameter.SelectedIndex = 3
			Else
				Me.cboPRDiameter.SelectedIndex = 4
			End If
			Me.txtPRDiameter.Tag = "mem"
			Dim txtPRDiameter As TextBox = Me.txtPRDiameter
			fluidSPGR = rst.PR_Diameter
			txtPRDiameter.Text = fluidSPGR.ToString()
			If RSWIN_DESC.bRodStarD Then
				Me.chkParaffin.Checked = rst.gbParaffin
				Me.txtParaffinDepth.Tag = "fem"
				Me.txtParaffinDepth.Text = Convert.ToString(rst.ParaffinDepth)
				If RSWIN_DESC.rst.gbParaffin Then
					Me.txtParaffinDepth.BringToFront()
					Me.lblParaffinDepth_Disabled.SendToBack()
				Else
					Me.txtParaffinDepth.SendToBack()
					Me.lblParaffinDepth_Disabled.BringToFront()
				End If
				Me.chkParaffin.Visible = True
				Me.txtParaffinDepth.Visible = True
				Me.lblParaffinDepth_Disabled.Visible = True
				Me._Label_ParaffinDepth.Visible = True
				Me._linSeparator_4.Visible = True
				Me._linSeparator_5.Visible = True
			Else
				Me.chkParaffin.Visible = False
				Me.txtParaffinDepth.Visible = False
				Me.lblParaffinDepth_Disabled.Visible = False
				Me._Label_ParaffinDepth.Visible = False
				Me._linSeparator_4.Visible = False
				Me._linSeparator_5.Visible = False
			End If
			Me.SetRequiredTextFields()
			Me.txtCompanyName.Focus()
		End Sub

		Private Sub DisplayNextForm()
			For Each form As Form In Me.ParentForm.MdiChildren
				Dim text As String
				If Operators.CompareString(text, form.Name, False) = 0 Then
					form.Activate()
					form.Show()
				End If
			Next
		End Sub

		Private Sub txtCompanyName_TextChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.rst.ACompanyName = Me.txtCompanyName.Text
			Dim txtCompanyName As TextBox = Me.txtCompanyName
			Dim label_CompanyName As Label = Me._Label_CompanyName
			Me.TextBox_Change(txtCompanyName, label_CompanyName)
			Me._Label_CompanyName = label_CompanyName
			Me.txtCompanyName = txtCompanyName
		End Sub

		Private Sub WellInfo_Enter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Public Function IsValidated(ByRef ProblemControl As Control) As Boolean
			Dim flag As Boolean = False
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Operators.CompareString(rst.WellName, "", False) = 0 Then
				Dim sMsg As String = "Please enter value for Well Name"
				Dim sMsgType As String = "Data Entry Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				ProblemControl = Me.txtWellName
				flag = True
			ElseIf rst.PumpDepth = 0F Then
				Dim sMsg2 As String = "Please enter value for Pump Depth"
				Dim sMsgType2 As String = "Data Entry Error"
				Dim bClosing2 As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg2, sMsgType2, bClosing2, dialogResult)
				ProblemControl = Me.txtPumpDepth
				flag = True
			ElseIf rst.Runtime = 0F Then
				Dim sMsg3 As String = "Please enter value for Run Time"
				Dim sMsgType3 As String = "Data Entry Error"
				Dim bClosing3 As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg3, sMsgType3, bClosing3, dialogResult)
				ProblemControl = Me.txtRuntime
				flag = True
			ElseIf rst.OilAPI = 0F Then
				Dim sMsg4 As String = "Please enter value for Oil gravity (API °) "
				Dim sMsgType4 As String = "Data Entry Error"
				Dim bClosing4 As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg4, sMsgType4, bClosing4, dialogResult)
				ProblemControl = Me.txtOilAPI
				flag = True
			End If
			If flag Then
				ProblemControl.Focus()
				Me.SetFieldColors()
				Return False
			End If
			Return True
		End Function

		Public Function CheckFields() As Boolean
			Dim flag As Boolean = False
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Operators.CompareString(rst.WellName, "", False) = 0 Then
				flag = True
			ElseIf rst.PumpDepth = 0F Then
				flag = True
			ElseIf rst.Runtime = 0F Then
				flag = True
			ElseIf rst.WaterCut = 0F Then
				flag = True
			ElseIf rst.OilAPI = 0F Then
				flag = True
			End If
			Return Not flag
		End Function

		Public Sub DisplayWellInfoError(sMsg As String, ByRef bCancel As Boolean)
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

		Private Sub SetFieldColors()
			Dim textBox As TextBox = Me.txtWellName
			Util.SetFieldColor(textBox)
			Me.txtWellName = textBox
			textBox = Me.txtRuntime
			Util.SetFieldColor(textBox)
			Me.txtRuntime = textBox
			textBox = Me.txtPumpDepth
			Util.SetFieldColor(textBox)
			Me.txtPumpDepth = textBox
			textBox = Me.txtTubingPressure
			Util.SetFieldColor(textBox)
			Me.txtTubingPressure = textBox
			textBox = Me.txtCasingPressure
			Util.SetFieldColor(textBox)
			Me.txtCasingPressure = textBox
			textBox = Me.txtWaterCut
			Util.SetFieldColor(textBox)
			Me.txtWaterCut = textBox
			textBox = Me.txtWaterSPGR
			Util.SetFieldColor(textBox)
			Me.txtWaterSPGR = textBox
			textBox = Me.txtOilAPI
			Util.SetFieldColor(textBox)
			Me.txtOilAPI = textBox
			textBox = Me.txtFluidSPGR
			Util.SetFieldColor(textBox)
			Me.txtFluidSPGR = textBox
		End Sub

		Private Sub txtWellName_TextChanged(sender As Object, e As EventArgs)
			Dim txtWellName As TextBox = Me.txtWellName
			Dim label_WellName As Label = Me._Label_WellName
			Me.TextBox_Change(txtWellName, label_WellName)
			Me._Label_WellName = label_WellName
			Me.txtWellName = txtWellName
			If Me.ActiveControl Is Me.txtWellName AndAlso (Me.txtWellName.Text <> Nothing And Operators.CompareString(Me.txtWellName.Text, "", False) <> 0) Then
				txtWellName = Me.txtWellName
				Dim text As String = txtWellName.Text
				Me.CheckForSpecialChars(text)
				txtWellName.Text = text
			End If
			txtWellName = Me.txtWellName
			Util.SetFieldColor(txtWellName)
			Me.txtWellName = txtWellName
			RSWIN_DESC.rst.WellName = Me.txtWellName.Text
			ini.SaveDataValue("WellName", Strings.Trim(RSWIN_DESC.rst.WellName))
		End Sub

		Private Function CheckForSpecialChars(ByRef sWellName As String) As Boolean
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = RSWIN_DESC.sSpecialChars.Length - 1
				For i As Integer = num To num2
					If Strings.InStr(sWellName, RSWIN_DESC.sSpecialChars.Substring(i, 1), CompareMethod.Binary) > 0 Then
						MessageBox.Show(RSWIN_DESC.sSpecialCharsMessages)
						sWellName = sWellName.Replace(RSWIN_DESC.sSpecialChars.Substring(i, 1), "")
						Exit For
					End If
				Next
			Catch ex As Exception
			End Try
			Dim result As Boolean
			Return result
		End Function

		Private Sub txtRuntime_TextChanged(sender As Object, e As EventArgs)
			Dim txtRuntime As TextBox = Me.txtRuntime
			Util.SetFieldColor(txtRuntime)
			Me.txtRuntime = txtRuntime
			txtRuntime = Me.txtRuntime
			Dim label_RunTime As Label = Me._Label_RunTime
			Me.TextBox_Change(txtRuntime, label_RunTime)
			Me._Label_RunTime = label_RunTime
			Me.txtRuntime = txtRuntime
			If Operators.CompareString(Me.txtRuntime.Text.Trim(), ".", False) = 0 Then
				Return
			End If
			If Me.txtRuntime.Text.Length <= 0 Then
				If Me.ActiveControl Is Me.txtRuntime Then
					If Not Versioned.IsNumeric(Me.txtRuntime.Text) Then
						Me.txtRuntime.Text = ""
					End If
				Else
					RSWIN_DESC.rst.Runtime = 0F
				End If
				Return
			End If
			If Not Versioned.IsNumeric(Me.txtRuntime.Text) Then
				Me.txtRuntime.Text = ""
				Return
			End If
			RSWIN_DESC.rst.Runtime = Convert.ToSingle(Me.txtRuntime.Text)
		End Sub

		Private Sub txtPumpDepth_TextChanged(sender As Object, e As EventArgs)
			Dim txtPumpDepth As TextBox = Me.txtPumpDepth
			Dim label_PumpDepth As Label = Me._Label_PumpDepth
			Me.TextBox_Change(txtPumpDepth, label_PumpDepth)
			Me._Label_PumpDepth = label_PumpDepth
			Me.txtPumpDepth = txtPumpDepth
			txtPumpDepth = Me.txtPumpDepth
			Util.SetFieldColor(txtPumpDepth)
			Me.txtPumpDepth = txtPumpDepth
			If Me.ActiveControl Is Me.txtPumpDepth Then
				Me.bPDMsgShown = False
				If Versioned.IsNumeric(Me.txtPumpDepth.Text) Then
					If Operators.CompareString(Me.txtPumpDepth.Text.Trim(), ".", False) = 0 Then
						Return
					End If
					If Me.txtPumpDepth.Text.Length > 0 Then
						If Not Versioned.IsNumeric(Me.txtPumpDepth.Text) Then
							Dim sMsg As String = "Please enter value for Pump Depth"
							Dim sMsgType As String = "Data Entry Error"
							Dim bClosing As Boolean = False
							Dim dialogResult As DialogResult = DialogResult.OK
							Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
							Me.txtPumpDepth.Text = ""
						Else
							Dim txtPumpDepth2 As TextBox = Me.txtPumpDepth
							Dim bValidIfEmpty As Boolean = True
							Dim bShowMessage As Boolean = False
							Dim num As Single
							Dim obj As Object = num
							Dim flag As Boolean = CtrlUI.CheckValid(txtPumpDepth2, bValidIfEmpty, bShowMessage, obj)
							num = Conversions.ToSingle(obj)
							If flag Then
								RSWIN_DESC.rst.PumpDepth = num
							End If
						End If
					Else
						RSWIN_DESC.rst.PumpDepth = 0F
					End If
				End If
				Return
			End If
		End Sub

		Private Sub TextBox_Change(ByRef txt As TextBox, ByRef lbl As Label)
			Me.ResetClock()
			If Me.ActiveControl IsNot txt Then
				Me.TextBox__LostFocus(txt, lbl, True)
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

		Private Sub txtWaterCut_TextChanged(sender As Object, e As EventArgs)
			Dim txtWaterCut As TextBox = Me.txtWaterCut
			Dim label_WaterCut As Label = Me._Label_WaterCut
			Me.TextBox_Change(txtWaterCut, label_WaterCut)
			Me._Label_WaterCut = label_WaterCut
			Me.txtWaterCut = txtWaterCut
			txtWaterCut = Me.txtWaterCut
			Util.SetFieldColor(txtWaterCut)
			Me.txtWaterCut = txtWaterCut
			If Operators.CompareString(Me.txtWaterCut.Text.Trim(), ".", False) = 0 Then
				Return
			End If
			If Me.txtWaterCut.Text.Length > 0 Then
				Try
					If Not Versioned.IsNumeric(Me.txtWaterCut.Text) Then
						Dim sMsg As String = "Please enter value for Water Cut"
						Dim sMsgType As String = "Data Entry Error"
						Dim bClosing As Boolean = False
						Dim dialogResult As DialogResult = DialogResult.OK
						Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
						Me.txtWaterCut.Text = ""
						Return
					End If
					Dim txtWaterCut2 As TextBox = Me.txtWaterCut
					Dim bValidIfEmpty As Boolean = True
					Dim bShowMessage As Boolean = False
					Dim num As Single
					Dim obj As Object = num
					Dim flag As Boolean = CtrlUI.CheckValid(txtWaterCut2, bValidIfEmpty, bShowMessage, obj)
					num = Conversions.ToSingle(obj)
					If flag Then
						RSWIN_DESC.rst.WaterCut = num
						Me.CheckFluidSPGR()
					End If
					Return
				Catch ex As Exception
					Return
				End Try
			End If
			RSWIN_DESC.rst.WaterCut = 0F
		End Sub

		Private Sub txtOilAPI_TextChanged(sender As Object, e As EventArgs)
			Dim txtOilAPI As TextBox = Me.txtOilAPI
			Dim label_OilAPI As Label = Me._Label_OilAPI
			Me.TextBox_Change(txtOilAPI, label_OilAPI)
			Me._Label_OilAPI = label_OilAPI
			Me.txtOilAPI = txtOilAPI
			txtOilAPI = Me.txtOilAPI
			Util.SetFieldColor(txtOilAPI)
			Me.txtOilAPI = txtOilAPI
			If Operators.CompareString(Me.txtOilAPI.Text.Trim(), ".", False) = 0 Then
				Return
			End If
			If Me.txtOilAPI.Text.Length <= 0 Then
				RSWIN_DESC.rst.OilAPI = 0F
				Return
			End If
			If Not Versioned.IsNumeric(Me.txtOilAPI.Text) Then
				Dim sMsg As String = "Please enter value for Oil gravity (API °) "
				Dim sMsgType As String = "Data Entry Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				Me.txtOilAPI.Text = ""
				Return
			End If
			Dim txtOilAPI2 As TextBox = Me.txtOilAPI
			Dim bValidIfEmpty As Boolean = True
			Dim bShowMessage As Boolean = False
			Dim num As Single
			Dim obj As Object = num
			Dim flag As Boolean = CtrlUI.CheckValid(txtOilAPI2, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			If flag Then
				RSWIN_DESC.rst.OilAPI = num
				RSWIN_DESC.rst.OilSPGR = CSng((141.5 / (CDbl(RSWIN_DESC.rst.OilAPI) + 131.5)))
				Me.CheckFluidSPGR()
			End If
		End Sub

		Public Sub SetProblemControlFocus(ByRef ProblemControl As Control)
			ProblemControl.Focus()
		End Sub

		Private Sub chkCalcFluidSPGR_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			RSWIN_DESC.rst.gbCalcFluidSPGR = Me.chkCalcFluidSPGR.Checked
			ini.SaveDataValue("CalcFluidSPGR", RSWIN_DESC.rst.gbCalcFluidSPGR)
			If Not Me.chkCalcFluidSPGR.Checked Then
				Me.txtFluidSPGR.Enabled = True
				Me.txtFluidSPGR.BackColor = Color.White
				If Me.ActiveControl Is Me.chkCalcFluidSPGR Then
					Me.txtFluidSPGR.Focus()
				End If
			Else
				Me.txtFluidSPGR.Enabled = False
				Me.txtFluidSPGR.BackColor = Color.LightGray
				Me.CheckFluidSPGR()
			End If
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.chkCalcFluidSPGR)
		End Sub

		Private Sub txtTubingPressure_TextChanged(sender As Object, e As EventArgs)
			Dim txtTubingPressure As TextBox = Me.txtTubingPressure
			Util.SetFieldColor(txtTubingPressure)
			Me.txtTubingPressure = txtTubingPressure
			txtTubingPressure = Me.txtTubingPressure
			Dim label_TubingPressure As Label = Me._Label_TubingPressure
			Me.TextBox_Change(txtTubingPressure, label_TubingPressure)
			Me._Label_TubingPressure = label_TubingPressure
			Me.txtTubingPressure = txtTubingPressure
			If Operators.CompareString(Me.txtTubingPressure.Text.Trim(), ".", False) = 0 Then
				Return
			End If
			If Me.txtTubingPressure.Text.Length <= 0 Then
				RSWIN_DESC.rst.TubingPressure = 0F
				Return
			End If
			If Not Versioned.IsNumeric(Me.txtTubingPressure.Text) Then
				Dim sMsg As String = "Please enter numeric value for Tubing Pressure"
				Dim sMsgType As String = "Data Entry Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				Me.txtTubingPressure.Text = ""
				Return
			End If
			Dim txtTubingPressure2 As TextBox = Me.txtTubingPressure
			Dim bValidIfEmpty As Boolean = True
			Dim bShowMessage As Boolean = False
			Dim num As Single
			Dim obj As Object = num
			Dim flag As Boolean = CtrlUI.CheckValid(txtTubingPressure2, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			If flag Then
				RSWIN_DESC.rst.TubingPressure = num
			End If
		End Sub

		Private Sub txtCasingPressure_TextChanged(sender As Object, e As EventArgs)
			Dim txtCasingPressure As TextBox = Me.txtCasingPressure
			Util.SetFieldColor(txtCasingPressure)
			Me.txtCasingPressure = txtCasingPressure
			txtCasingPressure = Me.txtCasingPressure
			Dim label_CasingPressure As Label = Me._Label_CasingPressure
			Me.TextBox_Change(txtCasingPressure, label_CasingPressure)
			Me._Label_CasingPressure = label_CasingPressure
			Me.txtCasingPressure = txtCasingPressure
			If Operators.CompareString(Me.txtCasingPressure.Text.Trim(), ".", False) = 0 Then
				Return
			End If
			If Me.txtCasingPressure.Text.Length <= 0 Then
				RSWIN_DESC.rst.CasingPressure = 0F
				Return
			End If
			If Not Versioned.IsNumeric(Me.txtCasingPressure.Text) Then
				Dim sMsg As String = "Please enter numeric value for Casing Pressure"
				Dim sMsgType As String = "Data Entry Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				Me.txtCasingPressure.Text = ""
				Return
			End If
			Dim txtCasingPressure2 As TextBox = Me.txtCasingPressure
			Dim bValidIfEmpty As Boolean = True
			Dim bShowMessage As Boolean = False
			Dim num As Single
			Dim obj As Object = num
			Dim flag As Boolean = CtrlUI.CheckValid(txtCasingPressure2, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			If flag Then
				RSWIN_DESC.rst.CasingPressure = num
			End If
		End Sub

		Private Sub txtWaterSPGR_TextChanged(sender As Object, e As EventArgs)
			Dim txtWaterSPGR As TextBox = Me.txtWaterSPGR
			Util.SetFieldColor(txtWaterSPGR)
			Me.txtWaterSPGR = txtWaterSPGR
			txtWaterSPGR = Me.txtWaterSPGR
			Dim label_WaterSPGR As Label = Me._Label_WaterSPGR
			Me.TextBox_Change(txtWaterSPGR, label_WaterSPGR)
			Me._Label_WaterSPGR = label_WaterSPGR
			Me.txtWaterSPGR = txtWaterSPGR
			If Operators.CompareString(Me.txtWaterSPGR.Text.Trim(), ".", False) = 0 Then
				Return
			End If
			If Me.txtWaterSPGR.Text.Length <= 0 Then
				RSWIN_DESC.rst.WaterSPGR = 0F
				Return
			End If
			If Not Versioned.IsNumeric(Me.txtWaterSPGR.Text) Then
				Me.txtWaterSPGR.Text = ""
				Return
			End If
			Dim txtWaterSPGR2 As TextBox = Me.txtWaterSPGR
			Dim bValidIfEmpty As Boolean = True
			Dim bShowMessage As Boolean = False
			Dim num As Single
			Dim obj As Object = num
			Dim flag As Boolean = CtrlUI.CheckValid(txtWaterSPGR2, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			If flag Then
				RSWIN_DESC.rst.WaterSPGR = num
				Me.CheckFluidSPGR()
			End If
		End Sub

		Private Sub CheckTextControl(ByRef myControl As Control, ByRef nFieldValue As Single, sFieldName As String)
			If Me.bFormLoaded Then
				If myControl.Text.Length > 0 And Me.bTextChanged Then
					Try
						Dim txt As TextBox = CType(myControl, TextBox)
						Dim bValidIfEmpty As Boolean = True
						Dim bShowMessage As Boolean = False
						Dim num As Single
						Dim obj As Object = num
						Dim flag As Boolean = CtrlUI.CheckValid(txt, bValidIfEmpty, bShowMessage, obj)
						num = Conversions.ToSingle(obj)
						If flag Then
							nFieldValue = num
						End If
						Return
					Catch ex As Exception
						Dim sMsg As String = "Please enter numeric value for " + sFieldName
						Dim sMsgType As String = "Data Entry Error"
						Dim bClosing As Boolean = False
						Dim dialogResult As DialogResult = DialogResult.OK
						Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
						Me.bTextChanged = False
						myControl.Text = ""
						myControl.Focus()
						Me.bTextChanged = True
						Return
					End Try
				End If
				If Me.bTextChanged Then
					Dim sMsg2 As String = "Please enter value for " + sFieldName
					Dim sMsgType2 As String = "Data Entry Error"
					Dim bClosing2 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg2, sMsgType2, bClosing2, dialogResult)
					Me.SetFieldColors()
					myControl.Focus()
				Else
					Dim txt2 As TextBox = CType(myControl, TextBox)
					Dim bValidIfEmpty2 As Boolean = True
					Dim bShowMessage2 As Boolean = False
					Dim num2 As Single
					Dim obj As Object = num2
					Dim flag2 As Boolean = CtrlUI.CheckValid(txt2, bValidIfEmpty2, bShowMessage2, obj)
					num2 = Conversions.ToSingle(obj)
					If flag2 Then
						nFieldValue = num2
					End If
				End If
			End If
		End Sub

		Private Sub txtFluidSPGR_TextChanged(sender As Object, e As EventArgs)
			Dim txtFluidSPGR As TextBox = Me.txtFluidSPGR
			Dim label_FluidSPGR As Label = Me._Label_FluidSPGR
			Me.TextBox_Change(txtFluidSPGR, label_FluidSPGR)
			Me._Label_FluidSPGR = label_FluidSPGR
			Me.txtFluidSPGR = txtFluidSPGR
			txtFluidSPGR = Me.txtFluidSPGR
			Util.SetFieldColor(txtFluidSPGR)
			Me.txtFluidSPGR = txtFluidSPGR
			If Operators.CompareString(Me.txtFluidSPGR.Text.Trim(), ".", False) = 0 Then
				Return
			End If
			If Me.txtFluidSPGR.Text.Length <= 0 Then
				RSWIN_DESC.rst.FluidSPGR = 0F
				Return
			End If
			If Not Versioned.IsNumeric(Me.txtFluidSPGR.Text) Then
				Dim sMsg As String = "Please enter numeric value for Fluid SPGR"
				Dim sMsgType As String = "Data Entry Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				Me.txtFluidSPGR.Text = ""
				Return
			End If
			Dim txtFluidSPGR2 As TextBox = Me.txtFluidSPGR
			Dim bValidIfEmpty As Boolean = True
			Dim bShowMessage As Boolean = True
			Dim num As Single
			Dim obj As Object = num
			Dim flag As Boolean = CtrlUI.CheckValid(txtFluidSPGR2, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			If flag And Me.txtFluidSPGR Is Me.ActiveControl Then
				RSWIN_DESC.rst.FluidSPGR = num
			End If
		End Sub

		Private Sub txtRuntime_KeyDown(sender As Object, e As KeyEventArgs)
		End Sub

		Private Sub txtPumpDepth_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtPumpDepth As TextBox = Me.txtPumpDepth
			Dim label_PumpDepth As Label = Me._Label_PumpDepth
			Me.TextBox__KeyDown(txtPumpDepth, label_PumpDepth, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me._Label_PumpDepth = label_PumpDepth
			Me.txtPumpDepth = txtPumpDepth
		End Sub

		Private Sub txtPumpDepth_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim text As String = ""
			Dim txtPumpDepth As Control = Me.txtPumpDepth
			Me.Control__LostFocus(txtPumpDepth)
			Me.txtPumpDepth = CType(txtPumpDepth, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtPumpDepth, True, False, obj) Then
				Me.SetRequiredTextField(Me.txtPumpDepth)
				Return
			End If
			Dim obj2 As Object = flag
			Dim lowerBound As Single = 100F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 41
			Dim useMetric As Integer = -1
			Dim canadianIsMetric As Integer = -1
			Dim bQuiet As Boolean = False
			Dim text2 As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text2), False) Then
				Me.txtPumpDepth.Focus()
				Return
			End If
			If Operators.ConditionalCompareObjectEqual(flag, Util.CheckUpper(obj, 20000F, -1, 41, -1, -1, True, text), False) Then
				If Not Me.bPDMsgShown Then
					MessageBox.Show(text)
				End If
				Me.txtPumpDepth.Focus()
				Return
			End If
			Dim txtPumpDepth2 As TextBox = Me.txtPumpDepth
			Dim label_PumpDepth As Label = Me._Label_PumpDepth
			Me.TextBox__LostFocus(txtPumpDepth2, label_PumpDepth, True)
			Me._Label_PumpDepth = label_PumpDepth
			Me.txtPumpDepth = txtPumpDepth2
			ini.SaveDataValue("PumpDepth", RuntimeHelpers.GetObjectValue(obj))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.rst.PumpDepth = Conversions.ToSingle(obj)
			End If
		End Sub

		Private Sub txtTubingPressure_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtTubingPressure As TextBox = Me.txtTubingPressure
			Dim label_TubingPressure As Label = Me._Label_TubingPressure
			Me.TextBox__KeyDown(txtTubingPressure, label_TubingPressure, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me._Label_TubingPressure = label_TubingPressure
			Me.txtTubingPressure = txtTubingPressure
		End Sub

		Private Sub txtCasingPressure_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtCasingPressure As TextBox = Me.txtCasingPressure
			Dim label_CasingPressure As Label = Me._Label_CasingPressure
			Me.TextBox__KeyDown(txtCasingPressure, label_CasingPressure, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me._Label_CasingPressure = label_CasingPressure
			Me.txtCasingPressure = txtCasingPressure
		End Sub

		Private Sub txtOilAPI_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtOilAPI As TextBox = Me.txtOilAPI
			Dim label_OilAPI As Label = Me._Label_OilAPI
			Me.TextBox__KeyDown(txtOilAPI, label_OilAPI, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me._Label_OilAPI = label_OilAPI
			Me.txtOilAPI = txtOilAPI
		End Sub

		Private Sub txtTubingPressure_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim txtTubingPressure As Control = Me.txtTubingPressure
			Me.Control__LostFocus(txtTubingPressure)
			Me.txtTubingPressure = CType(txtTubingPressure, TextBox)
			If RSWIN_DESC.bPredictiveRunning Or RSWIN_DESC.bParentFormClosing Then
				flag = True
			End If
			Dim flag2 As Boolean = False
			Dim obj As Object
			If flag2 = CtrlUI.CheckValid(Me.txtTubingPressure, True, False, obj) Then
				Me.SetRequiredTextField(Me.txtTubingPressure)
			Else
				Dim obj2 As Object = flag2
				Dim lowerBound As Single = 0F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 153
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = flag
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtTubingPressure.Focus()
				Else
					Dim obj3 As Object = flag2
					Dim upperBound As Single = 1000F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 151
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = -1
					Dim bQuiet2 As Boolean = flag
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtTubingPressure.Focus()
					Else
						Dim txtTubingPressure2 As TextBox = Me.txtTubingPressure
						Dim label_TubingPressure As Label = Me._Label_TubingPressure
						Me.TextBox__LostFocus(txtTubingPressure2, label_TubingPressure, True)
						Me._Label_TubingPressure = label_TubingPressure
						Me.txtTubingPressure = txtTubingPressure2
						ini.SaveDataValue("TubingPressure", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.TubingPressure = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtCasingPressure_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim txtCasingPressure As Control = Me.txtCasingPressure
			Me.Control__LostFocus(txtCasingPressure)
			Me.txtCasingPressure = CType(txtCasingPressure, TextBox)
			If RSWIN_DESC.bPredictiveRunning Or RSWIN_DESC.bParentFormClosing Then
				flag = True
			End If
			Dim flag2 As Boolean = False
			Dim obj As Object
			If flag2 = CtrlUI.CheckValid(Me.txtCasingPressure, True, False, obj) Then
				Me.SetRequiredTextField(Me.txtCasingPressure)
			Else
				Dim obj2 As Object = flag2
				Dim lowerBound As Single = -50F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 91
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = flag
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtCasingPressure.Focus()
				Else
					Dim obj3 As Object = flag2
					Dim upperBound As Single = 1000F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 89
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = -1
					Dim bQuiet2 As Boolean = flag
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtCasingPressure.Focus()
					Else
						Dim txtCasingPressure2 As TextBox = Me.txtCasingPressure
						Dim label_CasingPressure As Label = Me._Label_CasingPressure
						Me.TextBox__LostFocus(txtCasingPressure2, label_CasingPressure, True)
						Me._Label_CasingPressure = label_CasingPressure
						Me.txtCasingPressure = txtCasingPressure2
						ini.SaveDataValue("CasingPressure", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.CasingPressure = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtOilAPI_Leave(sender As Object, e As EventArgs)
			Dim txtOilAPI As Control = Me.txtOilAPI
			Me.Control__LostFocus(txtOilAPI)
			Me.txtOilAPI = CType(txtOilAPI, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtOilAPI, True, False, obj) Then
				Me.SetRequiredTextField(Me.txtOilAPI)
			Else
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 5F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 35
				Dim useMetric As Integer = -1
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtOilAPI.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 70F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 35
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtOilAPI.Focus()
					Else
						Dim txtOilAPI2 As TextBox = Me.txtOilAPI
						Dim label_OilAPI As Label = Me._Label_OilAPI
						Me.TextBox__LostFocus(txtOilAPI2, label_OilAPI, True)
						Me._Label_OilAPI = label_OilAPI
						Me.txtOilAPI = txtOilAPI2
						ini.SaveDataValue("OilGravity", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.OilAPI = Conversions.ToSingle(obj)
							RSWIN_DESC.rst.OilSPGR = CSng((141.5 / (CDbl(RSWIN_DESC.rst.OilAPI) + 131.5)))
							Me.CheckFluidSPGR()
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtFluidSPGR_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtFluidSPGR As Control = Me.txtFluidSPGR
			Me.Control__LostFocus(txtFluidSPGR)
			Me.txtFluidSPGR = CType(txtFluidSPGR, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtFluidSPGR, True, False, obj) Then
				Me.SetRequiredTextField(Me.txtFluidSPGR)
			Else
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 0.1F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 67
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtFluidSPGR.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 1.5F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 67
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtFluidSPGR.Focus()
					Else
						Dim txtFluidSPGR2 As TextBox = Me.txtFluidSPGR
						Dim label_FluidSPGR As Label = Me._Label_FluidSPGR
						Me.TextBox__LostFocus(txtFluidSPGR2, label_FluidSPGR, True)
						Me._Label_FluidSPGR = label_FluidSPGR
						Me.txtFluidSPGR = txtFluidSPGR2
						ini.SaveDataValue("FluidSPGR", RuntimeHelpers.GetObjectValue(obj))
						If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							Me.CheckFluidSPGR()
							If Strings.Len(Me.txtFluidSPGR.Text) > 0 Then
								RSWIN_DESC.rst.FluidSPGR = Conversions.ToSingle(obj)
							End If
						Else
							RSWIN_DESC.rst.FluidSPGR = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtRuntime_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtRuntime As Control = Me.txtRuntime
			Me.Control__LostFocus(txtRuntime)
			Me.txtRuntime = CType(txtRuntime, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtRuntime, True, False, obj) Then
				Me.SetRequiredTextField(Me.txtRuntime)
			Else
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 0F
				Dim inclusive As Integer = 0
				Dim errnum As Integer = 134
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtRuntime.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 24F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 133
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtRuntime.Text = "24"
						Me.txtRuntime.Focus()
					Else
						Dim txtRuntime2 As TextBox = Me.txtRuntime
						Dim label_RunTime As Label = Me._Label_RunTime
						Me.TextBox__LostFocus(txtRuntime2, label_RunTime, True)
						Me._Label_RunTime = label_RunTime
						Me.txtRuntime = txtRuntime2
						ini.SaveDataValue("RunTime", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.Runtime = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtUserDate_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim flag As Boolean = True
			If flag Then
				RSWIN_DESC.rst.UserDate = Me.txtUserDate.Text
				Dim txtUserDate As TextBox = Me.txtUserDate
				Dim label_UserDate As Label = Me._Label_UserDate
				Me.TextBox__LostFocus(txtUserDate, label_UserDate, True)
				Me._Label_UserDate = label_UserDate
				Me.txtUserDate = txtUserDate
				ini.SaveDataValue("UserDate", Strings.Trim(RSWIN_DESC.rst.UserDate))
				Dim txtUserDate2 As Control = Me.txtUserDate
				Me.Control__LostFocus(txtUserDate2)
				Me.txtUserDate = CType(txtUserDate2, TextBox)
				Return
			End If
		End Sub

		Private Sub txtUserName_Leave(eventSender As Object, eventArgs As EventArgs)
			RSWIN_DESC.rst.UserName = Me.txtUserName.Text
			Dim txtUserName As TextBox = Me.txtUserName
			Dim label_UserName As Label = Me._Label_UserName
			Me.TextBox__LostFocus(txtUserName, label_UserName, False)
			Me._Label_UserName = label_UserName
			Me.txtUserName = txtUserName
			ini.SaveDataValue("UserName", Strings.Trim(RSWIN_DESC.rst.UserName))
		End Sub

		Private Sub txtWaterCut_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtWaterCut As Control = Me.txtWaterCut
			Me.Control__LostFocus(txtWaterCut)
			Me.txtWaterCut = CType(txtWaterCut, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtWaterCut, True, False, obj) Then
				Me.SetRequiredTextField(Me.txtWaterCut)
			Else
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 0F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 155
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtWaterCut.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 100F
					Dim inclusive2 As Integer = 0
					Dim errnum2 As Integer = 154
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtWaterCut.Text = "99.5"
						Me.txtWaterCut.Focus()
					Else
						Dim txtWaterCut2 As TextBox = Me.txtWaterCut
						Dim label_WaterCut As Label = Me._Label_WaterCut
						Me.TextBox__LostFocus(txtWaterCut2, label_WaterCut, True)
						Me._Label_WaterCut = label_WaterCut
						Me.txtWaterCut = txtWaterCut2
						ini.SaveDataValue("WaterCut", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.WaterCut = Conversions.ToSingle(obj)
							Me.CheckFluidSPGR()
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtWaterSPGR_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtWaterSPGR As Control = Me.txtWaterSPGR
			Me.Control__LostFocus(txtWaterSPGR)
			Me.txtWaterSPGR = CType(txtWaterSPGR, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtWaterSPGR, True, False, obj) Then
				Me.SetRequiredTextField(Me.txtWaterSPGR)
				Return
			End If
			Dim obj2 As Object = flag
			Dim lowerBound As Single = 1F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 88
			Dim useMetric As Integer = 0
			Dim canadianIsMetric As Integer = 0
			Dim bQuiet As Boolean = False
			Dim text As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Me.txtWaterSPGR.Focus()
				Return
			End If
			Dim obj3 As Object = flag
			Dim upperBound As Single = 1.5F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = 88
			Dim useMetric2 As Integer = 0
			Dim canadianIsMetric2 As Integer = 0
			Dim bQuiet2 As Boolean = False
			text = ""
			If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
				Me.txtWaterSPGR.Focus()
				Return
			End If
			Dim txtWaterSPGR2 As TextBox = Me.txtWaterSPGR
			Dim label_WaterSPGR As Label = Me._Label_WaterSPGR
			Me.TextBox__LostFocus(txtWaterSPGR2, label_WaterSPGR, True)
			Me._Label_WaterSPGR = label_WaterSPGR
			Me.txtWaterSPGR = txtWaterSPGR2
			ini.SaveDataValue("WaterSPGR", RuntimeHelpers.GetObjectValue(obj))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.rst.WaterSPGR = Conversions.ToSingle(obj)
				Me.CheckFluidSPGR()
			End If
		End Sub

		Private Sub txtCompanyName_Enter(sender As Object, e As EventArgs)
			Me.txtCompanyName.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtCompanyName_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtCompanyName As Control = Me.txtCompanyName
			Me.Control__LostFocus(txtCompanyName)
			Me.txtCompanyName = CType(txtCompanyName, TextBox)
			RSWIN_DESC.rst.ACompanyName = Me.txtCompanyName.Text
			ini.SaveDataValue("CompanyName", Strings.Trim(RSWIN_DESC.rst.ACompanyName))
			Dim txtCompanyName2 As TextBox = Me.txtCompanyName
			Dim label_CompanyName As Label = Me._Label_CompanyName
			Me.TextBox__LostFocus(txtCompanyName2, label_CompanyName, False)
			Me._Label_CompanyName = label_CompanyName
			Me.txtCompanyName = txtCompanyName2
		End Sub

		Private Sub txtComment_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtComment As Control = Me.txtComment
			Me.Control__LostFocus(txtComment)
			Me.txtComment = CType(txtComment, RichTextBox)
			RSWIN_DESC.rst.FileComment = Me.txtComment.Text
			ini.SaveDataValue("FileComment", Strings.Trim(RSWIN_DESC.rst.FileComment))
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

		Private Sub txtUserName_Enter(sender As Object, e As EventArgs)
			Me.txtUserName.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtWellName_Enter(sender As Object, e As EventArgs)
			Me.txtWellName.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtWellName_Leave(sender As Object, e As EventArgs)
			Dim txtWellName As Control = Me.txtWellName
			Me.Control__LostFocus(txtWellName)
			Me.txtWellName = CType(txtWellName, TextBox)
			Me.SetRequiredTextField(Me.txtWellName)
		End Sub

		Private Sub txtRuntime_Enter(sender As Object, e As EventArgs)
			Me.txtRuntime.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtPumpDepth_Enter(sender As Object, e As EventArgs)
			Me.txtPumpDepth.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtTubingPressure_Enter(sender As Object, e As EventArgs)
			Me.txtTubingPressure.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtCasingPressure_Enter(sender As Object, e As EventArgs)
			Me.txtCasingPressure.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtWaterCut_Enter(sender As Object, e As EventArgs)
			Me.txtWaterCut.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtWaterSPGR_Enter(sender As Object, e As EventArgs)
			Me.txtWaterSPGR.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtComment_Enter(sender As Object, e As EventArgs)
			Me.txtComment.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtUserDate_Enter(sender As Object, e As EventArgs)
			Me.txtUserDate.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtOilAPI_Enter(sender As Object, e As EventArgs)
			Me.txtOilAPI.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtFluidSPGR_Enter(sender As Object, e As EventArgs)
			Me.txtFluidSPGR.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtUserDate_TextChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.rst.UserDate = Me.txtUserDate.Text
			Dim txtUserDate As TextBox = Me.txtUserDate
			Dim label_UserDate As Label = Me._Label_UserDate
			Me.TextBox_Change(txtUserDate, label_UserDate)
			Me._Label_UserDate = label_UserDate
			Me.txtUserDate = txtUserDate
		End Sub

		Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.rst.UserName = Me.txtUserName.Text
			Dim txtUserName As TextBox = Me.txtUserName
			Dim label_UserName As Label = Me._Label_UserName
			Me.TextBox_Change(txtUserName, label_UserName)
			Me._Label_UserName = label_UserName
			Me.txtUserName = txtUserName
		End Sub

		Private Sub txtComment_TextChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.rst.FileComment = Me.txtComment.Text
		End Sub

		Private Sub _optPumpCondition_1_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				If Me.ActiveControl Is Me._optPumpCondition_1 Then
					Me.SetProdInfoLoaded(False)
				End If
				Me.optPumpCondition_CheckedChanged(1S, Me._optPumpCondition_1.Checked)
				Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me._optPumpCondition_1)
				If Me.ActiveControl Is Me._optPumpCondition_1 Then
					Me.SetRequiredTextFields()
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub _optPumpCondition_2_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				If Me.ActiveControl Is Me._optPumpCondition_2 Then
					Me.SetProdInfoLoaded(False)
				End If
				Me.optPumpCondition_CheckedChanged(2S, Me._optPumpCondition_2.Checked)
				If Me.ActiveControl Is Me._optPumpCondition_2 Then
					Me.SetRequiredTextFields()
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub _optPumpCondition_3_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				If Me.ActiveControl Is Me._optPumpCondition_3 Then
					Me.SetProdInfoLoaded(False)
				End If
				Me.optPumpCondition_CheckedChanged(3S, Me._optPumpCondition_3.Checked)
				If Me.ActiveControl Is Me._optPumpCondition_3 Then
					Me.SetRequiredTextFields()
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub optPumpCondition_CheckedChanged(Index As Short, bValue As Boolean)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Me.ResetClock()
				IL_09:
				num = 2
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				IL_12:
				num = 3
				If Index <> 0S OrElse Not bValue Then
					GoTo IL_46
				End If
				IL_1D:
				num = 4
				cRODSTAR.gbCalcPumpCondition = True
				IL_27:
				num = 5
				cRODSTAR.PumpCondition = 1S
				IL_31:
				num = 6
				ini.SaveDataValue("CalcPumpCondition", True)
				IL_44:
				GoTo IL_8F
				IL_46:
				num = 8
				If Not bValue Then
					GoTo IL_8F
				End If
				IL_4C:
				num = 9
				cRODSTAR.gbCalcPumpCondition = False
				IL_57:
				num = 10
				cRODSTAR.PumpCondition = Index
				IL_62:
				num = 11
				ini.SaveDataValue("CalcPumpCondition", False)
				IL_76:
				num = 12
				ini.SaveDataValue("PumpCondition", cRODSTAR.PumpCondition)
				IL_8F:
				num = 14
				If Not bValue Then
					GoTo IL_39F
				End If
				IL_99:
				num = 15
				If Index <> 0S Then
					GoTo IL_CD
				End If
				IL_A1:
				num = 16
				cRODSTAR.gbCalcPumpCondition = True
				IL_AC:
				num = 17
				cRODSTAR.PumpCondition = 1S
				IL_B7:
				num = 18
				ini.SaveDataValue("CalcPumpCondition", True)
				IL_CB:
				GoTo IL_114
				IL_CD:
				num = 20
				IL_D1:
				num = 21
				cRODSTAR.gbCalcPumpCondition = False
				IL_DC:
				num = 22
				cRODSTAR.PumpCondition = Index
				IL_E7:
				num = 23
				ini.SaveDataValue("CalcPumpCondition", False)
				IL_FB:
				num = 24
				ini.SaveDataValue("PumpCondition", cRODSTAR.PumpCondition)
				IL_114:
				num = 26
				Me.txtPumpFillage.Enabled = (Index <> 1S And Index <> 0S)
				IL_132:
				num = 27
				If Not RSWIN_DESC.bAllowPumpEffEntry Then
					GoTo IL_14F
				End If
				IL_13D:
				num = 28
				Me.txtPumpEfficiency.Enabled = True
				IL_14D:
				GoTo IL_192
				IL_14F:
				num = 30
				IL_153:
				num = 31
				Me.txtPumpEfficiency.Enabled = (Index <> 2S And Index <> 3S)
				IL_171:
				num = 32
				If Not Me.txtPumpEfficiency.Enabled Then
					GoTo IL_192
				End If
				IL_182:
				num = 33
				Me.txtPumpFillage.Enabled = False
				IL_192:
				num = 36
				If Not(RSWIN_DESC.bRodStarD And (Index = 2S Or Index = 3S)) Then
					GoTo IL_1C7
				End If
				IL_1A7:
				num = 37
				Me.txtPumpEfficiency.Enabled = True
				IL_1B7:
				num = 38
				Me.txtPumpFillage.Enabled = True
				IL_1C7:
				num = 40
				Dim flag As Boolean = True
				IL_1CD:
				num = 41
				If cRODSTAR.PumpCondition <> 1S Then
					GoTo IL_256
				End If
				IL_1DA:
				num = 42
				If Not Versioned.IsNumeric(Me.txtPumpEfficiency.Text) Then
					GoTo IL_233
				End If
				IL_1F0:
				num = 43
				If Not(50F > Convert.ToSingle(Me.txtPumpEfficiency.Text) Or Convert.ToSingle(Me.txtPumpEfficiency.Text) > 100F) Then
					GoTo IL_2CE
				End If
				IL_228:
				num = 44
				flag = False
				IL_22E:
				GoTo IL_2CE
				IL_233:
				num = 47
				IL_237:
				num = 48
				If Strings.Len(Me.txtPumpEfficiency.Text) = 0 Then
					GoTo IL_254
				End If
				IL_24E:
				num = 49
				flag = False
				IL_254:
				GoTo IL_2CE
				IL_256:
				num = 53
				IL_25A:
				num = 54
				If Not Versioned.IsNumeric(Me.txtPumpFillage.Text) Then
					GoTo IL_2AD
				End If
				IL_270:
				num = 55
				If Not(10F > Convert.ToSingle(Me.txtPumpFillage.Text) Or Convert.ToSingle(Me.txtPumpFillage.Text) > 95F) Then
					GoTo IL_2CE
				End If
				IL_2A5:
				num = 56
				flag = False
				IL_2AB:
				GoTo IL_2CE
				IL_2AD:
				num = 59
				IL_2B1:
				num = 60
				If Me.txtPumpFillage.Text.Length = 0 Then
					GoTo IL_2CE
				End If
				IL_2C8:
				num = 61
				flag = False
				IL_2CE:
				num = 65
				Dim defInstance As Form = ProdInfo.DefInstance
				Dim flag2 As Boolean = RSWIN.IsFormLoaded(defInstance)
				ProdInfo.DefInstance = CType(defInstance, ProdInfo)
				If flag2 Then
					GoTo IL_33C
				End If
				IL_2EC:
				num = 66
				If Not(cRODSTAR.gbCalcPumpCondition Or cRODSTAR.PumpCondition <> 1S) Then
					GoTo IL_340
				End If
				IL_305:
				num = 67
				If Not cRODSTAR.SPMEntered = 0S Then
					GoTo IL_324
				End If
				IL_315:
				num = 68
				cRODSTAR.SPM = -1F
				IL_324:
				num = 70
				cRODSTAR.SPMEntered = -1S
				IL_32F:
				num = 71
				cRODSTAR.gbCalcTargetBFPD = False
				IL_33A:
				GoTo IL_340
				IL_33C:
				num = 74
				IL_340:
				num = 76
				Me.EnableFluidInertia()
				IL_34A:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_352:
				num = 78
				Dim flag3 As Boolean = True
				IL_358:
				num = 81
				If flag3 <> flag Then
					GoTo IL_36D
				End If
				IL_360:
				num = 82
				Me.SetPumpConditionFocus(CInt(Index))
				IL_36B:
				GoTo IL_39F
				IL_36D:
				num = 84
				If flag3 <> (cRODSTAR.PumpCondition = 1S) Then
					GoTo IL_38F
				End If
				IL_37D:
				num = 85
				Me.txtPumpEfficiency.Focus()
				IL_38D:
				GoTo IL_39F
				IL_38F:
				num = 88
				Me.txtPumpFillage.Focus()
				IL_39F:
				num = 91
				If Not(RSWIN_DESC.bRodStarD And (Index = 2S Or Index = 3S)) Then
					GoTo IL_473
				End If
				IL_3B7:
				num = 92
				If Operators.CompareString(Me.txtPumpEfficiency.Text.Trim(), "", False) <> 0 Then
					GoTo IL_415
				End If
				IL_3D9:
				num = 93
				If RSWIN_DESC.rst.PumpEfficiency <> 0F Then
					GoTo IL_415
				End If
				IL_3EE:
				num = 94
				RSWIN_DESC.rst.PumpEfficiency = 85F
				IL_401:
				num = 95
				Me.txtPumpEfficiency.Text = "85"
				IL_415:
				num = 98
				If Operators.CompareString(Me.txtPumpFillage.Text.Trim(), "", False) <> 0 Then
					GoTo IL_473
				End If
				IL_437:
				num = 99
				If RSWIN_DESC.rst.PumpFillage <> 0F Then
					GoTo IL_473
				End If
				IL_44C:
				num = 100
				RSWIN_DESC.rst.PumpFillage = 85F
				IL_45F:
				num = 101
				Me.txtPumpFillage.Text = "85"
				IL_473:
				cRODSTAR = Nothing
				IL_475:
				GoTo IL_676
				IL_47A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_632:
				GoTo IL_66B
				IL_634:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_647:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_634
			End Try
			IL_66B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_676:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub SetPumpConditionFocus(Index As Integer)
			Select Case Index
				Case 0
					Me._optPumpCondition_0.Focus()
				Case 1
					Me._optPumpCondition_1.Focus()
				Case 2
					Me._optPumpCondition_2.Focus()
				Case 3
					Me._optPumpCondition_3.Focus()
			End Select
		End Sub

		Private Sub SetPumpConditionValue(Index As Integer, bVal As Boolean)
			Select Case Index
				Case 0
					Me._optPumpCondition_0.Checked = bVal
				Case 1
					Me._optPumpCondition_1.Checked = bVal
				Case 2
					Me._optPumpCondition_2.Checked = bVal
				Case 3
					Me._optPumpCondition_3.Checked = bVal
			End Select
		End Sub

		Private Sub txtPumpEfficiency_Enter(sender As Object, e As EventArgs)
			Me.txtPumpEfficiency.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtPumpFillage_Enter(sender As Object, e As EventArgs)
			Me.txtPumpFillage.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtPumpFillage_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtPumpFillage As Control = Me.txtPumpFillage
			Me.Control__LostFocus(txtPumpFillage)
			Me.txtPumpFillage = CType(txtPumpFillage, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtPumpFillage, True, False, obj) Then
				Me.SetRequiredTextField(Me.txtPumpFillage)
			Else
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 10F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 44
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuietLeaveMsg As Boolean = Me.bQuietLeaveMsg
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuietLeaveMsg, text), False) Then
					Me.txtPumpFillage.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 95F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 44
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuietLeaveMsg2 As Boolean = Me.bQuietLeaveMsg
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuietLeaveMsg2, text), False) Then
						Me.txtPumpFillage.Focus()
					Else
						ini.SaveDataValue("PumpFillage", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.PumpFillage = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
			Me.bQuietLeaveMsg = False
		End Sub

		Private Sub txtPumpEfficiency_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim num As Integer = 50
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				num = 75
			End If
			Dim txtPumpEfficiency As Control = Me.txtPumpEfficiency
			Me.Control__LostFocus(txtPumpEfficiency)
			Me.txtPumpEfficiency = CType(txtPumpEfficiency, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtPumpEfficiency, True, False, obj) Then
				Me.SetRequiredTextField(Me.txtPumpEfficiency)
			Else
				Dim obj2 As Object = flag
				Dim lowerBound As Single = CSng(num)
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 43
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = True
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Dim flag2 As Boolean
					Me.DisplayWellInfoError("The Pump Efficiency must be between " + num.ToString().Trim() + "% and 100%", flag2)
					Me.txtPumpEfficiency.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 100F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 43
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = True
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Dim flag2 As Boolean
						Me.DisplayWellInfoError("The Pump Efficiency must be between " + num.ToString().Trim() + "% and 100%", flag2)
						Me.txtPumpEfficiency.Focus()
					Else
						ini.SaveDataValue("PumpEfficiency", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.PumpEfficiency = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
			Me.bQuietLeaveMsg = False
		End Sub

		Public Sub EnableFluidInertia()
			If Not MImpred.FluidInertiaPossible() Then
				RSWIN_DESC.rst.IncludeFluidInertia = 0S
				Return
			End If
		End Sub

		Private Sub _optPumpCondition_0_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.optPumpCondition_CheckedChanged(0S, Me._optPumpCondition_0.Checked)
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me._optPumpCondition_0)
			If Me.ActiveControl Is Me._optPumpCondition_0 Then
				Me.SetRequiredTextFields()
				Return
			End If
		End Sub

		Private Sub txtPumpEfficiency_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.txtPumpEfficiency.Text) Then
				RSWIN_DESC.rst.PumpEfficiency = Convert.ToSingle(Me.txtPumpEfficiency.Text)
				If Me._optPumpCondition_0.Checked Or Me._optPumpCondition_1.Checked Or (RSWIN_DESC.bRodStarD And (Me._optPumpCondition_2.Checked Or Me._optPumpCondition_3.Checked)) Then
					Me.txtPumpEfficiency.BackColor = RSWIN_DESC.rgbEditComplete
				End If
			ElseIf Me.txtPumpEfficiency Is Me.ActiveControl AndAlso Operators.CompareString(Me.txtPumpEfficiency.Text.Trim(), "", False) = 0 Then
				RSWIN_DESC.rst.PumpEfficiency = 0F
				If Me._optPumpCondition_0.Checked Or Me._optPumpCondition_1.Checked Or (RSWIN_DESC.bRodStarD And (Me._optPumpCondition_2.Checked Or Me._optPumpCondition_3.Checked)) Then
					Me.txtPumpEfficiency.BackColor = RSWIN_DESC.rgbEditRequired
				End If
			End If
			Dim txtPumpEfficiency As TextBox = Me.txtPumpEfficiency
			Dim label_PumpEfficiency As Label = Me._Label_PumpEfficiency
			Me.TextBox_Change(txtPumpEfficiency, label_PumpEfficiency)
			Me._Label_PumpEfficiency = label_PumpEfficiency
			Me.txtPumpEfficiency = txtPumpEfficiency
		End Sub

		Private Sub txtPumpFillage_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.txtPumpFillage.Text) Then
				RSWIN_DESC.rst.PumpFillage = Convert.ToSingle(Me.txtPumpFillage.Text)
				If Me._optPumpCondition_2.Checked Or Me._optPumpCondition_3.Checked Then
					Me.txtPumpFillage.BackColor = RSWIN_DESC.rgbEditComplete
				End If
			ElseIf Me.txtPumpFillage Is Me.ActiveControl AndAlso Operators.CompareString(Me.txtPumpFillage.Text.Trim(), "", False) = 0 Then
				RSWIN_DESC.rst.PumpFillage = 0F
				If Me._optPumpCondition_2.Checked Or Me._optPumpCondition_3.Checked Then
					Me.txtPumpFillage.BackColor = RSWIN_DESC.rgbEditRequired
				End If
			End If
			Dim txtPumpFillage As TextBox = Me.txtPumpFillage
			Dim label_PumpFillage As Label = Me._Label_PumpFillage
			Me.TextBox_Change(txtPumpFillage, label_PumpFillage)
			Me._Label_PumpFillage = label_PumpFillage
			Me.txtPumpFillage = txtPumpFillage
		End Sub

		Private Sub txtStuffingBoxFriction_TextChanged(sender As Object, e As EventArgs)
			Dim text As String = "'"
			Dim txtStuffingBoxFriction As TextBox = Me.txtStuffingBoxFriction
			Dim lblStuffingBoxFriction As Label = Me.lblStuffingBoxFriction
			Me.TextBox_Change(txtStuffingBoxFriction, lblStuffingBoxFriction)
			Me.lblStuffingBoxFriction = lblStuffingBoxFriction
			Me.txtStuffingBoxFriction = txtStuffingBoxFriction
			txtStuffingBoxFriction = Me.txtStuffingBoxFriction
			Util.SetFieldColor(txtStuffingBoxFriction)
			Me.txtStuffingBoxFriction = txtStuffingBoxFriction
			If Operators.CompareString(Me.txtStuffingBoxFriction.Text.Trim(), ".", False) = 0 Then
				Return
			End If
			If Me.txtStuffingBoxFriction.Text.Length <= 0 Then
				RSWIN_DESC.rst.StuffingBoxFriction = 0F
				Return
			End If
			If Not Versioned.IsNumeric(Me.txtStuffingBoxFriction.Text) Then
				Dim sMsg As String = "Please enter value for Stuffing Box Friction"
				Dim sMsgType As String = "Data Entry Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				Me.txtStuffingBoxFriction.Text = ""
				Return
			End If
			If Me.ActiveControl Is Me.txtStuffingBoxFriction And Versioned.IsNumeric(Me.txtStuffingBoxFriction.Text) Then
				Dim flag As Boolean = False
				Dim flag2 As Boolean = flag
				Dim txtStuffingBoxFriction2 As TextBox = Me.txtStuffingBoxFriction
				Dim bValidIfEmpty As Boolean = 1
				Dim bShowMessage As Boolean = 0
				Dim num As Single
				Dim obj As Object = num
				Dim flag3 As Boolean = CtrlUI.CheckValid(txtStuffingBoxFriction2, bValidIfEmpty, bShowMessage, obj)
				num = Conversions.ToSingle(obj)
				If flag2 <> flag3 Then
					Dim obj2 As Object = flag
					obj = num
					Dim obj3 As Object = Util.CheckUpper(obj, 2000F, -1, 75, -1, 0, False, text)
					num = Conversions.ToSingle(obj)
					If Operators.ConditionalCompareObjectEqual(obj2, obj3, False) Then
						Dim txtStuffingBoxFriction3 As TextBox = Me.txtStuffingBoxFriction
						Dim bValidIfEmpty2 As Boolean = True
						Dim bShowMessage2 As Boolean = False
						Dim obj4 As Object = num
						Dim flag4 As Boolean = CtrlUI.CheckValid(txtStuffingBoxFriction3, bValidIfEmpty2, bShowMessage2, obj4)
						num = Conversions.ToSingle(obj4)
						If flag4 Then
							RSWIN_DESC.rst.StuffingBoxFriction = num
						End If
						Me.txtStuffingBoxFriction.Focus()
					Else
						ini.SaveDataValue("StuffingBoxFriction", num)
						RSWIN_DESC.rst.StuffingBoxFriction = num
					End If
				End If
			Else
				Dim txtStuffingBoxFriction4 As TextBox = Me.txtStuffingBoxFriction
				Dim bValidIfEmpty3 As Boolean = True
				Dim bShowMessage3 As Boolean = False
				Dim num As Single
				Dim obj4 As Object = num
				Dim flag5 As Boolean = CtrlUI.CheckValid(txtStuffingBoxFriction4, bValidIfEmpty3, bShowMessage3, obj4)
				num = Conversions.ToSingle(obj4)
				If flag5 Then
					RSWIN_DESC.rst.StuffingBoxFriction = num
				End If
			End If
		End Sub

		Private Sub txtPumpLoadAdj_TextChanged(sender As Object, e As EventArgs)
			Dim txtPumpLoadAdj As TextBox = Me.txtPumpLoadAdj
			Dim lblPumpLoadAdj As Label = Me.lblPumpLoadAdj
			Me.TextBox_Change(txtPumpLoadAdj, lblPumpLoadAdj)
			Me.lblPumpLoadAdj = lblPumpLoadAdj
			Me.txtPumpLoadAdj = txtPumpLoadAdj
		End Sub

		Private Sub txtStuffingBoxFriction_Leave(sender As Object, e As EventArgs)
			Dim txtStuffingBoxFriction As Control = Me.txtStuffingBoxFriction
			Me.Control__LostFocus(txtStuffingBoxFriction)
			Me.txtStuffingBoxFriction = CType(txtStuffingBoxFriction, TextBox)
			If Me.MyParentFrm Is Nothing Then
				Try
					Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
				Catch ex As Exception
				End Try
			End If
			If Me.MyParentFrm IsNot Nothing AndAlso Me.MyParentFrm.bClosing Then
				Return
			End If
			Dim flag As Boolean = False
			Dim flag2 As Boolean = flag
			Dim txtStuffingBoxFriction2 As TextBox = Me.txtStuffingBoxFriction
			Dim bValidIfEmpty As Boolean = 1
			Dim bShowMessage As Boolean = 0
			Dim num As Single
			Dim obj As Object = num
			Dim flag3 As Boolean = CtrlUI.CheckValid(txtStuffingBoxFriction2, bValidIfEmpty, bShowMessage, obj)
			num = Conversions.ToSingle(obj)
			If flag2 = flag3 Then
				Me.SetRequiredTextField(Me.txtStuffingBoxFriction)
				Return
			End If
			Dim obj2 As Object = flag
			obj = num
			Dim lowerBound As Single = 0F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 75
			Dim useMetric As Integer = -1
			Dim canadianIsMetric As Integer = 0
			Dim bQuiet As Boolean = False
			Dim text As String = ""
			Dim obj3 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text)
			num = Conversions.ToSingle(obj)
			If Operators.ConditionalCompareObjectEqual(obj2, obj3, False) Then
				Me.txtStuffingBoxFriction.Focus()
				Return
			End If
			Dim obj4 As Object = flag
			obj = num
			Dim upperBound As Single = 2000F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = 75
			Dim useMetric2 As Integer = -1
			Dim canadianIsMetric2 As Integer = 0
			Dim bQuiet2 As Boolean = False
			text = ""
			Dim obj5 As Object = Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text)
			num = Conversions.ToSingle(obj)
			If Operators.ConditionalCompareObjectEqual(obj4, obj5, False) Then
				Me.txtStuffingBoxFriction.Focus()
				Return
			End If
			Dim txtStuffingBoxFriction3 As TextBox = Me.txtStuffingBoxFriction
			Dim lblStuffingBoxFriction As Label = Me.lblStuffingBoxFriction
			Me.TextBox__LostFocus(txtStuffingBoxFriction3, lblStuffingBoxFriction, True)
			Me.lblStuffingBoxFriction = lblStuffingBoxFriction
			Me.txtStuffingBoxFriction = txtStuffingBoxFriction3
			ini.SaveDataValue("StuffingBoxFriction", num)
			If Not Information.IsDBNull(num) Then
				RSWIN_DESC.rst.StuffingBoxFriction = num
			End If
		End Sub

		Private Sub txtPumpLoadAdj_Leave(sender As Object, e As EventArgs)
			Me.ResetClock()
			Dim num As Single = CSng(((Conversion.Int(0.15 * CDbl(RSWIN_DESC.rst.PumpDepth) / 100.0) + 1.0) * 100.0))
			Dim msgtxt As String = Util.FormatMessage("The pump load adjustment must be between 0 and {0!0} lbs.", New Object() { num })
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtPumpLoadAdj, True, False, obj) Then
				Me.SetRequiredTextField(Me.txtPumpLoadAdj)
				Return
			End If
			Dim obj2 As Object = flag
			Dim lowerBound As Single = 0F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = -1
			Dim useMetric As Integer = 0
			Dim canadianIsMetric As Integer = 0
			Dim bQuiet As Boolean = False
			Dim text As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Util.Errmsg(msgtxt)
				Me.txtPumpLoadAdj.Focus()
				Return
			End If
			Dim txtPumpLoadAdj As TextBox = Me.txtPumpLoadAdj
			Dim lblPumpLoadAdj As Label = Me.lblPumpLoadAdj
			Me.TextBox__LostFocus(txtPumpLoadAdj, lblPumpLoadAdj, True)
			Me.lblPumpLoadAdj = lblPumpLoadAdj
			Me.txtPumpLoadAdj = txtPumpLoadAdj
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.rst.PumpLoadAdj = Conversions.ToSingle(obj)
				ini.SaveDataValue("PumpLoadAdjustment", RuntimeHelpers.GetObjectValue(obj))
			End If
		End Sub

		Private Sub txtPumpLoadAdj_Enter(sender As Object, e As EventArgs)
			Me.txtPumpLoadAdj.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtStuffingBoxFriction_Enter(sender As Object, e As EventArgs)
			Me.txtStuffingBoxFriction.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_Activated(sender As Object, e As EventArgs)
			Me.m_bClosing = False
			Me.SetWidthHeight()
			Me.SetParentWidthHeight()
			RSWIN_DESC.sCurrentFormName = "WellInfo"
		End Sub

		Private Sub SetProdInfoLoaded(bValue As Boolean)
			Try
				Dim prodInfo As ProdInfo = New ProdInfo()
				Dim formName As String = "ProdInfo"
				Dim form As Form = prodInfo
				Dim flag As Boolean = Me.ReturnMdiForm(formName, form)
				prodInfo = CType(form, ProdInfo)
				Dim flag2 As Boolean = flag
				If flag2 Then
					prodInfo.bFormLoaded = False
					prodInfo.bReloadProdInfo = True
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function ReturnMdiForm(FormName As String, ByRef retfrm As Form) As Boolean
			Dim flag As Boolean = False
			For Each form As Form In RSWIN_DESC.frmMain.MdiChildren
				If Operators.CompareString(FormName, form.Name, False) = 0 Then
					flag = True
					retfrm = form
				End If
			Next
			If Not flag Then
				retfrm = Nothing
			End If
			Return flag
		End Function

		Private Sub pnlWellInfo_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Private Sub txtPumpEfficiency_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtPumpEfficiency.Enabled Then
				Me.txtPumpEfficiency.BackColor = Color.White
				Me.lblPumpEfficiency_Disabled.SendToBack()
				Return
			End If
			Me.txtPumpEfficiency.BackColor = Color.LightGray
			Me.lblPumpEfficiency_Disabled.BringToFront()
		End Sub

		Private Sub txtPumpFillage_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtPumpFillage.Enabled Then
				Me.txtPumpFillage.BackColor = Color.White
				Me.lblPumpFillage_Disabled.SendToBack()
				Return
			End If
			Me.txtPumpFillage.BackColor = Color.LightGray
			Me.lblPumpFillage_Disabled.BringToFront()
		End Sub

		Private Sub WellInfo_Closed(sender As Object, e As EventArgs)
			Me.m_bClosing = False
		End Sub

		Private Sub WellInfo_Closing(sender As Object, e As CancelEventArgs)
			Me.m_bClosing = True
			Dim flag As Boolean = Me.ValidateWellInfoData(False)
			If Not Me.m_bClosing Or (Me.m_bClosing And Not flag) Then
				e.Cancel = True
				Return
			End If
			RSWIN_DESC.sCurrentFormName = ""
		End Sub

		Private Sub txtFluidSPGR_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtFluidSPGR.Enabled Then
				Me.lblFluidSPGR_Disabled.SendToBack()
				Return
			End If
			Me.lblFluidSPGR_Disabled.BringToFront()
		End Sub

		Private Sub SetActiveControl(ByRef myControl As Control)
			Try
				myControl.Focus()
				Me.ActiveControl = myControl
			Catch ex As Exception
			End Try
		End Sub

		Private Sub WellInfo_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub CheckFluidSPGR()
			Try
				If Me.chkCalcFluidSPGR.Checked Then
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim txtWaterCut As TextBox = Me.txtWaterCut
					Dim bValidIfEmpty As Boolean = True
					Dim bShowMessage As Boolean = False
					Dim num As Single
					Dim obj As Object = num
					Dim flag As Boolean = CtrlUI.CheckValid(txtWaterCut, bValidIfEmpty, bShowMessage, obj)
					num = Conversions.ToSingle(obj)
					Dim txtWaterSPGR As TextBox = Me.txtWaterSPGR
					Dim bValidIfEmpty2 As Boolean = True
					Dim bShowMessage2 As Boolean = False
					Dim obj2 As Object = num
					Dim flag2 As Boolean = CtrlUI.CheckValid(txtWaterSPGR, bValidIfEmpty2, bShowMessage2, obj2)
					num = Conversions.ToSingle(obj2)
					Dim flag3 As Boolean = flag AndAlso flag2
					Dim txtOilAPI As TextBox = Me.txtOilAPI
					Dim bValidIfEmpty3 As Boolean = True
					Dim bShowMessage3 As Boolean = False
					Dim obj3 As Object = num
					Dim flag4 As Boolean = CtrlUI.CheckValid(txtOilAPI, bValidIfEmpty3, bShowMessage3, obj3)
					num = Conversions.ToSingle(obj3)
					If flag3 AndAlso flag4 Then
						RSWIN_DESC.rst.OilSPGR = CSng((141.5 / (CDbl(RSWIN_DESC.rst.OilAPI) + 131.5)))
						rst.gfMaxFluidSPGR = Me.MaxFluidSPGR(rst.WaterCut, rst.WaterSPGR, rst.OilSPGR)
						rst.FluidSPGR = rst.gfMaxFluidSPGR
						Dim txtFluidSPGR As TextBox = Me.txtFluidSPGR
						Dim cRODSTAR As cRODSTAR = rst
						Dim fluidSPGR As Single = cRODSTAR.FluidSPGR
						Dim text As String = "0.0###"
						Dim text2 As String = Util.Format(fluidSPGR, text)
						cRODSTAR.FluidSPGR = fluidSPGR
						txtFluidSPGR.Text = text2
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub WellInfo_Leave(sender As Object, e As EventArgs)
			Me.DisableTimeClock()
			Me.ResetClock()
		End Sub

		Private Sub txtStuffingBoxFriction_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtStuffingBoxFriction As TextBox = Me.txtStuffingBoxFriction
			Dim lblStuffingBoxFriction As Label = Me.lblStuffingBoxFriction
			Me.TextBox__KeyDown(txtStuffingBoxFriction, lblStuffingBoxFriction, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me.lblStuffingBoxFriction = lblStuffingBoxFriction
			Me.txtStuffingBoxFriction = txtStuffingBoxFriction
		End Sub

		Private Sub txtPumpLoadAdj_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtPumpLoadAdj As TextBox = Me.txtPumpLoadAdj
			Dim lblPumpLoadAdj As Label = Me.lblPumpLoadAdj
			Me.TextBox__KeyDown(txtPumpLoadAdj, lblPumpLoadAdj, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me.lblPumpLoadAdj = lblPumpLoadAdj
			Me.txtPumpLoadAdj = txtPumpLoadAdj
		End Sub

		Private Sub WellInfo_MinimumSizeChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub WellInfo_MaximumSizeChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub WellInfo_MaximizedBoundsChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub WellInfo_Resize(sender As Object, e As EventArgs)
		End Sub

		Private Sub WellInfo_SizeChanged(sender As Object, e As EventArgs)
			Dim num As Integer = 1
			Dim flag As Boolean = False
			If Me.bAllowResize Then
				While Not flag And num < 10
					Application.DoEvents()
					flag = Me.CenterForm()
					num += 1
				End While
				Return
			End If
		End Sub

		Private Sub WellInfo_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Private Function CheckWidthHeight() As Boolean
			If Me.Width < 800 Then
				Me.Width = Me.iWidth
			End If
			If Me.Height < 300 Then
				Me.Height = Me.iHeight
			End If
			Return Not(Me.Width <> Me.iWidth Or Me.Height <> Me.iHeight)
		End Function

		Private Sub SetWidthHeight()
			Me.iWidth = Me.Width
			Me.iHeight = Me.Height
		End Sub

		Private Sub SetParentWidthHeight()
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				If Me.MyParentFrm IsNot Nothing Then
					Me.iParentWidth = Me.MyParentFrm.Width
					Me.iParentHeight = Me.MyParentFrm.Height
					Me.bAllowResize = Me.MyParentFrm.bAllowResize
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Function CenterForm() As Boolean
			Dim flag As Boolean = False
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				If Me.MyParentFrm IsNot Nothing Then
					Me.iParentWidth = Me.MyParentFrm.Width
					Me.iParentHeight = Me.MyParentFrm.Height
					Me.bAllowResize = Me.MyParentFrm.bAllowResize
				End If
				flag = Me.CheckWidthHeight()
				If(Me.iParentWidth <> 0 And Me.iParentHeight <> 0) AndAlso flag Then
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					Me.Left = CInt(Math.Round(CDbl((Me.iParentWidth - Me.Width)) / 2.0 - 8.0))
					Me.Top = CInt(Math.Round(CDbl((Me.iParentHeight - Me.Height)) / 2.0 - CDbl(Me.MyParentFrm.ParentToolbarHeight())))
					flag = True
				Else
					flag = False
				End If
			Catch ex2 As Exception
			End Try
			Return flag
		End Function

		Private Sub WellInfo_RightToLeftChanged(sender As Object, e As EventArgs)
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

		Private Sub _optPumpCondition_1_EnabledChanged(sender As Object, e As EventArgs)
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Me._optPumpCondition_1.Enabled Then
				Me._optPumpCondition_1.Enabled = False
				Return
			End If
		End Sub

		Private Sub btnUpdateDate_Click(sender As Object, e As EventArgs)
			Try
				RSWIN_DESC.rst.UserDate = DateAndTime.Now.ToLongDateString()
				Me.txtUserDate.Text = RSWIN_DESC.rst.UserDate.Trim()
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnCoverPageComments_Click(sender As Object, e As EventArgs)
			Dim dlgCoverPageComments As dlgCoverPageComments = New dlgCoverPageComments()
			Try
				Me.ResetClock()
				dlgCoverPageComments.ShowDialog()
				If RSWIN_DESC.rst.FileComment IsNot Nothing AndAlso Operators.CompareString(RSWIN_DESC.rst.FileComment, Me.txtComment.Text, False) <> 0 Then
					Me.txtComment.Text = RSWIN_DESC.rst.FileComment
				End If
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub _Label_OilAPI_TextChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub cboPRDiameter_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try
				If Operators.CompareString(Strings.Trim(Conversions.ToString(Me.cboPRDiameter.SelectedItem)), "Other", False) = 0 Then
					Me.txtPRDiameter.Enabled = True
					Me.lblPRDiameter_Disabled.SendToBack()
				Else
					Me.txtPRDiameter.Enabled = False
					Me.lblPRDiameter_Disabled.BringToFront()
					If Me.cboPRDiameter.SelectedIndex = 0 Then
						RSWIN_DESC.rst.PR_Diameter = 1F
					ElseIf Me.cboPRDiameter.SelectedIndex = 1 Then
						RSWIN_DESC.rst.PR_Diameter = 1.125F
					ElseIf Me.cboPRDiameter.SelectedIndex = 2 Then
						RSWIN_DESC.rst.PR_Diameter = 1.25F
					ElseIf Me.cboPRDiameter.SelectedIndex = 3 Then
						RSWIN_DESC.rst.PR_Diameter = 1.5F
					ElseIf Me.cboPRDiameter.SelectedIndex = 4 Then
						RSWIN_DESC.rst.PR_Diameter = 1.75F
					End If
				End If
				If Me.ActiveControl Is Me.cboPRDiameter Then
					ini.SaveDataValue("PRDiameter", RSWIN_DESC.rst.PR_Diameter)
				End If
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtPRDiameter_TextChanged(sender As Object, e As EventArgs)
			Dim txtPRDiameter As TextBox = Me.txtPRDiameter
			Dim lblPRDiam As Label = Me.lblPRDiam
			Me.TextBox_Change(txtPRDiameter, lblPRDiam)
			Me.lblPRDiam = lblPRDiam
			Me.txtPRDiameter = txtPRDiameter
			txtPRDiameter = Me.txtPRDiameter
			Util.SetFieldColor(txtPRDiameter)
			Me.txtPRDiameter = txtPRDiameter
			If Me.ActiveControl Is Me.txtPRDiameter Then
				If Versioned.IsNumeric(Me.txtPRDiameter.Text) Then
					If Operators.CompareString(Me.txtPRDiameter.Text.Trim(), ".", False) = 0 Then
						Return
					End If
					If Me.txtPRDiameter.Text.Length > 0 Then
						If Not Versioned.IsNumeric(Me.txtPRDiameter.Text) Then
							Dim sMsg As String = "Please enter value for Polished Rod Diameter"
							Dim sMsgType As String = "Data Entry Error"
							Dim bClosing As Boolean = False
							Dim dialogResult As DialogResult = DialogResult.OK
							Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
							Me.txtPRDiameter.Text = ""
						Else
							Dim txtPRDiameter2 As TextBox = Me.txtPRDiameter
							Dim bValidIfEmpty As Boolean = True
							Dim bShowMessage As Boolean = False
							Dim num As Single
							Dim obj As Object = num
							Dim flag As Boolean = CtrlUI.CheckValid(txtPRDiameter2, bValidIfEmpty, bShowMessage, obj)
							num = Conversions.ToSingle(obj)
							If flag Then
								RSWIN_DESC.rst.PR_Diameter = num
							End If
						End If
					Else
						RSWIN_DESC.rst.PR_Diameter = 0F
					End If
				End If
				Return
			End If
		End Sub

		Private Sub txtPRDiameter_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtPRDiameter As Control = Me.txtPRDiameter
			Me.Control__LostFocus(txtPRDiameter)
			Me.txtPRDiameter = CType(txtPRDiameter, TextBox)
			Dim obj As Object
			Dim flag As Boolean = CtrlUI.CheckValid(Me.txtPRDiameter, True, False, obj)
			Dim flag2 As Boolean = True
			If Operators.ConditionalCompareObjectEqual(flag2, Operators.CompareObjectLess(obj, 1, False), False) Then
				MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("The polished rod diameter cannot be less than 1" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", "  (25.4 mm)"))))
				Me.txtPRDiameter.Focus()
				Return
			End If
			If Operators.ConditionalCompareObjectEqual(flag2, Operators.CompareObjectGreater(obj, 2, False), False) Then
				MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject("The polished rod diameter cannot be greater than 2" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", "  (50.8 mm)"))))
				Me.txtPRDiameter.Focus()
				Return
			End If
			Dim txtPRDiameter2 As TextBox = Me.txtPRDiameter
			Dim lblPRDiam As Label = Me.lblPRDiam
			Me.TextBox__LostFocus(txtPRDiameter2, lblPRDiam, True)
			Me.lblPRDiam = lblPRDiam
			Me.txtPRDiameter = txtPRDiameter2
			ini.SaveDataValue("PRDiameter", RuntimeHelpers.GetObjectValue(obj))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.rst.PR_Diameter = Conversions.ToSingle(obj)
			End If
		End Sub

		Private Sub txtPRDiameter_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtPRDiameter.Enabled Then
				Me.lblPRDiameter_Disabled.SendToBack()
				Return
			End If
			Me.lblPRDiameter_Disabled.BringToFront()
		End Sub

		Private Sub txtPRDiameter_Enter(sender As Object, e As EventArgs)
			Me.txtPRDiameter.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtPRDiameter_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			Dim txtPRDiameter As TextBox = Me.txtPRDiameter
			Dim lblPRDiam As Label = Me.lblPRDiam
			Me.TextBox__KeyDown(txtPRDiameter, lblPRDiam, CInt(eventArgs.KeyCode), If((-If((eventArgs.Shift > False), 1, 0)), 1, 0))
			Me.lblPRDiam = lblPRDiam
			Me.txtPRDiameter = txtPRDiameter
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

		Private Sub WellInfo_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_MouseDown(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_MouseEnter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_MouseMove(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_MouseUp(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_MouseWheel(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_Move(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_Scroll(sender As Object, e As ScrollEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_KeyPress(sender As Object, e As KeyPressEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_KeyUp(sender As Object, e As KeyEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_DragDrop(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_DragEnter(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub WellInfo_FormClosed(sender As Object, e As FormClosedEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub WellInfo_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub WellInfo_LostFocus(sender As Object, e As EventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub WellInfo_GotFocus(sender As Object, e As EventArgs)
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

		Private Sub chkParaffin_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			RSWIN_DESC.rst.gbParaffin = Me.chkParaffin.Checked
			ini.SaveDataValue("Paraffin", RSWIN_DESC.rst.gbParaffin)
			If RSWIN_DESC.rst.gbParaffin Then
				If RSWIN_DESC.rst.ParaffinDepth = 0F And RSWIN_DESC.rst.PumpDepth > 0F Then
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim num As Single = RSWIN_DESC.rst.PumpDepth / 3F
					Dim text As String = "######.##"
					rst.ParaffinDepth = Conversions.ToSingle(Util.Format(num, text))
					Me.txtParaffinDepth.Tag = "fem"
					Me.txtParaffinDepth.Text = Convert.ToString(RSWIN_DESC.rst.ParaffinDepth)
				End If
				Me.txtParaffinDepth.BringToFront()
				Me.lblParaffinDepth_Disabled.SendToBack()
			Else
				Me.txtParaffinDepth.SendToBack()
				Me.lblParaffinDepth_Disabled.BringToFront()
			End If
			Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.chkParaffin)
		End Sub

		Private Sub txtParaffinDepth_Enter(sender As Object, e As EventArgs)
			Me.txtParaffinDepth.BackColor = RSWIN_DESC.rgbEditFocus
			Me.ResetClock()
		End Sub

		Private Sub txtParaffinDepth_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtParaffinDepth As TextBox = Me.txtParaffinDepth
			Dim label_ParaffinDepth As Label = Me._Label_ParaffinDepth
			Me.TextBox__KeyDown(txtParaffinDepth, label_ParaffinDepth, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me._Label_ParaffinDepth = label_ParaffinDepth
			Me.txtParaffinDepth = txtParaffinDepth
		End Sub

		Private Sub txtParaffinDepth_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtParaffinDepth As Control = Me.txtParaffinDepth
			Me.Control__LostFocus(txtParaffinDepth)
			Me.txtParaffinDepth = CType(txtParaffinDepth, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtParaffinDepth, True, False, obj) Then
				Me.SetRequiredTextField(Me.txtParaffinDepth)
				Return
			End If
			Dim txtParaffinDepth2 As TextBox = Me.txtParaffinDepth
			Dim label_ParaffinDepth As Label = Me._Label_ParaffinDepth
			Me.TextBox__LostFocus(txtParaffinDepth2, label_ParaffinDepth, True)
			Me._Label_ParaffinDepth = label_ParaffinDepth
			Me.txtParaffinDepth = txtParaffinDepth2
			ini.SaveDataValue("ParaffinDepth", RuntimeHelpers.GetObjectValue(obj))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.rst.ParaffinDepth = Conversions.ToSingle(obj)
			End If
		End Sub

		Private Sub txtParaffinDepth_TextChanged(sender As Object, e As EventArgs)
			Dim txtParaffinDepth As TextBox = Me.txtParaffinDepth
			Dim label_ParaffinDepth As Label = Me._Label_ParaffinDepth
			Me.TextBox_Change(txtParaffinDepth, label_ParaffinDepth)
			Me._Label_ParaffinDepth = label_ParaffinDepth
			Me.txtParaffinDepth = txtParaffinDepth
			txtParaffinDepth = Me.txtParaffinDepth
			Util.SetFieldColor(txtParaffinDepth)
			Me.txtParaffinDepth = txtParaffinDepth
			If Me.ActiveControl Is Me.txtParaffinDepth Then
				If Versioned.IsNumeric(Me.txtParaffinDepth.Text) Then
					If Operators.CompareString(Me.txtParaffinDepth.Text.Trim(), ".", False) = 0 Then
						Return
					End If
					If Me.txtParaffinDepth.Text.Length > 0 Then
						If Not Versioned.IsNumeric(Me.txtParaffinDepth.Text) Then
							Dim sMsg As String = "Please enter value for Paraffin Depth"
							Dim sMsgType As String = "Data Entry Error"
							Dim bClosing As Boolean = False
							Dim dialogResult As DialogResult = DialogResult.OK
							Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
							Me.txtParaffinDepth.Text = ""
						Else
							Dim txtParaffinDepth2 As TextBox = Me.txtParaffinDepth
							Dim bValidIfEmpty As Boolean = True
							Dim bShowMessage As Boolean = False
							Dim num As Single
							Dim obj As Object = num
							Dim flag As Boolean = CtrlUI.CheckValid(txtParaffinDepth2, bValidIfEmpty, bShowMessage, obj)
							num = Conversions.ToSingle(obj)
							If flag Then
								RSWIN_DESC.rst.ParaffinDepth = num
							End If
						End If
					Else
						RSWIN_DESC.rst.ParaffinDepth = 0F
					End If
				End If
				Return
			End If
		End Sub

		Public Sub PopulatePRDiameter()
			Try
				Me.cboPRDiameter.Items.Clear()
				Me.cboPRDiameter.Items.Add(Operators.ConcatenateObject("1" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", "  (25.4 mm)")))
				Me.cboPRDiameter.Items.Add(Operators.ConcatenateObject("1 1/8" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", " (28.5 mm)")))
				Me.cboPRDiameter.Items.Add(Operators.ConcatenateObject("1 1/4" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", " (31.8 mm)")))
				Me.cboPRDiameter.Items.Add(Operators.ConcatenateObject("1 1/2" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", "  (38.1 mm)")))
				Me.cboPRDiameter.Items.Add(Operators.ConcatenateObject("1 3/4" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", "  (44.5 mm)")))
				Me.cboPRDiameter.Items.Add("Other")
			Catch ex As Exception
			End Try
		End Sub

		Private bAllowResize As Boolean

		Private bTextChanged As Boolean

		Private bFormLoaded As Boolean

		Private bDynaSourceClicked As Boolean

		Private mbFirstResize As Boolean

		Private bPDMsgShown As Boolean

		Private Const DYS_AUTOBATCH_INDEX As Integer = 3

		Private myKeyValueHT As Hashtable

		Private iWidth As Integer

		Private iHeight As Integer

		Private iParentWidth As Integer

		Private iParentHeight As Integer

		Private MyParentFrm As RODSTAR

		Private m_bClosing As Boolean

		Private m_bValidated As Boolean

		Private m_bQuietLeaveMsg As Boolean

		Private bAIPreferencesSet As Boolean

		Private myRodGuideAL As ArrayList

		Private Shared m_vb6FormDefInstance As WellInfo

		<AccessedThroughProperty("chkParaffin")>
		Private _chkParaffin As CheckBox

		<AccessedThroughProperty("_Label_ParaffinDepth")>
		Private __Label_ParaffinDepth As Label

		<AccessedThroughProperty("lblParaffinDepth_Disabled")>
		Private _lblParaffinDepth_Disabled As Label

		<AccessedThroughProperty("txtParaffinDepth")>
		Private _txtParaffinDepth As TextBox

		<AccessedThroughProperty("_linSeparator_5")>
		Private __linSeparator_5 As Label

		<AccessedThroughProperty("_linSeparator_4")>
		Private __linSeparator_4 As Label

		Private Shared m_InitializingDefInstance As Boolean

		<AccessedThroughProperty("WellInfo")>
		Private _WellInfo As Form

		<AccessedThroughProperty("pnlWellInfo")>
		Private _pnlWellInfo As Panel

		<AccessedThroughProperty("chkCalcFluidSPGR")>
		Private _chkCalcFluidSPGR As CheckBox

		<AccessedThroughProperty("txtComment")>
		Private _txtComment As RichTextBox

		<AccessedThroughProperty("txtFluidSPGR")>
		Private _txtFluidSPGR As TextBox

		<AccessedThroughProperty("txtOilAPI")>
		Private _txtOilAPI As TextBox

		<AccessedThroughProperty("txtWaterSPGR")>
		Private _txtWaterSPGR As TextBox

		<AccessedThroughProperty("txtWaterCut")>
		Private _txtWaterCut As TextBox

		<AccessedThroughProperty("txtCasingPressure")>
		Private _txtCasingPressure As TextBox

		<AccessedThroughProperty("txtTubingPressure")>
		Private _txtTubingPressure As TextBox

		<AccessedThroughProperty("txtRuntime")>
		Private _txtRuntime As TextBox

		<AccessedThroughProperty("txtPumpDepth")>
		Private _txtPumpDepth As TextBox

		<AccessedThroughProperty("txtUserDate")>
		Private _txtUserDate As TextBox

		<AccessedThroughProperty("txtUserName")>
		Private _txtUserName As TextBox

		<AccessedThroughProperty("txtWellName")>
		Private _txtWellName As TextBox

		<AccessedThroughProperty("txtCompanyName")>
		Private _txtCompanyName As TextBox

		<AccessedThroughProperty("_linSeparator_3")>
		Private __linSeparator_3 As Label

		<AccessedThroughProperty("_linSeparator_2")>
		Private __linSeparator_2 As Label

		<AccessedThroughProperty("_linSeparator_1")>
		Private __linSeparator_1 As Label

		<AccessedThroughProperty("_linSeparator_0")>
		Private __linSeparator_0 As Label

		<AccessedThroughProperty("ContextMenu1")>
		Private _ContextMenu1 As ContextMenu

		<AccessedThroughProperty("_Label_CasingPressure")>
		Private __Label_CasingPressure As Label

		<AccessedThroughProperty("_Label_TubingPressure")>
		Private __Label_TubingPressure As Label

		<AccessedThroughProperty("_Label_RunTime")>
		Private __Label_RunTime As Label

		<AccessedThroughProperty("_Label_PumpDepth")>
		Private __Label_PumpDepth As Label

		<AccessedThroughProperty("_Label_OilAPI")>
		Private __Label_OilAPI As Label

		<AccessedThroughProperty("_Label_FluidSPGR")>
		Private __Label_FluidSPGR As Label

		<AccessedThroughProperty("_Label_WaterSPGR")>
		Private __Label_WaterSPGR As Label

		<AccessedThroughProperty("_Label_WaterCut")>
		Private __Label_WaterCut As Label

		<AccessedThroughProperty("_Label_WellName")>
		Private __Label_WellName As Label

		<AccessedThroughProperty("_Label_UserDate")>
		Private __Label_UserDate As Label

		<AccessedThroughProperty("_Label_UserName")>
		Private __Label_UserName As Label

		<AccessedThroughProperty("_Label_CompanyName")>
		Private __Label_CompanyName As Label

		<AccessedThroughProperty("_Label_Comment")>
		Private __Label_Comment As Label

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		<AccessedThroughProperty("txtPumpLoadAdj")>
		Private _txtPumpLoadAdj As TextBox

		<AccessedThroughProperty("txtStuffingBoxFriction")>
		Private _txtStuffingBoxFriction As TextBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("txtPumpFillage")>
		Private _txtPumpFillage As TextBox

		<AccessedThroughProperty("txtPumpEfficiency")>
		Private _txtPumpEfficiency As TextBox

		<AccessedThroughProperty("_optPumpCondition_0")>
		Private __optPumpCondition_0 As RadioButton

		<AccessedThroughProperty("_optPumpCondition_3")>
		Private __optPumpCondition_3 As RadioButton

		<AccessedThroughProperty("_optPumpCondition_2")>
		Private __optPumpCondition_2 As RadioButton

		<AccessedThroughProperty("_optPumpCondition_1")>
		Private __optPumpCondition_1 As RadioButton

		<AccessedThroughProperty("lblStuffingBoxFriction")>
		Private _lblStuffingBoxFriction As Label

		<AccessedThroughProperty("lblPumpLoadAdj")>
		Private _lblPumpLoadAdj As Label

		<AccessedThroughProperty("lblPumpEfficiency_Disabled")>
		Private _lblPumpEfficiency_Disabled As Label

		<AccessedThroughProperty("lblPumpFillage_Disabled")>
		Private _lblPumpFillage_Disabled As Label

		<AccessedThroughProperty("lblFluidSPGR_Disabled")>
		Private _lblFluidSPGR_Disabled As Label

		<AccessedThroughProperty("_Label_PumpEfficiency")>
		Private __Label_PumpEfficiency As Label

		<AccessedThroughProperty("_Label_PumpFillage")>
		Private __Label_PumpFillage As Label

		<AccessedThroughProperty("_Label_PumpCondition")>
		Private __Label_PumpCondition As Label

		<AccessedThroughProperty("btnUpdateDate")>
		Private _btnUpdateDate As Button

		<AccessedThroughProperty("ToolTip1")>
		Private _ToolTip1 As ToolTip

		<AccessedThroughProperty("btnCoverPageComments")>
		Private _btnCoverPageComments As Button

		<AccessedThroughProperty("cboPRDiameter")>
		Private _cboPRDiameter As ComboBox

		<AccessedThroughProperty("txtPRDiameter")>
		Private _txtPRDiameter As TextBox

		<AccessedThroughProperty("lblPRDiameter_Disabled")>
		Private _lblPRDiameter_Disabled As Label

		<AccessedThroughProperty("lblPRDiam")>
		Private _lblPRDiam As Label

		Private Class clsDynoTypeList
			Public Property Name As String
				Get
					Return Conversions.ToString(Me.m_Name)
				End Get
				Set(value As String)
					Me.m_Name = value
				End Set
			End Property

			Public Property Index As String
				Get
					Return Conversions.ToString(Me.m_Index)
				End Get
				Set(value As String)
					Me.m_Index = Conversions.ToInteger(value)
				End Set
			End Property

			Public Sub New(sN As String, nIndx As Integer)
				Me.m_Name = sN
				Me.m_Index = nIndx
			End Sub

			Private m_Name As Object

			Private m_Index As Integer
		End Class
	End Class
End Namespace
