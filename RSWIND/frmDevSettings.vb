Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Partial Class frmDevSettings
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmDevSettings_Load
			Me.sMsg_FluidDamping = "The fluid damping must be between 0 and 5."
			Me.sMaxDStrokeDrag = "The maximum downstroke pump drag must be between 0 and {0!0} lbs."
			Me.sMaxUStrokeDrag = "The maximum upstroke pump drag must be between 0 and {0!0} lbs."
			Me.InitializeComponent()
		End Sub

		Friend Overridable Property GroupBox1 As GroupBox
			Get
				Return Me._GroupBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Dim value2 As EventHandler = AddressOf Me.GroupBox1_Enter
				If Me._GroupBox1 IsNot Nothing Then
					RemoveHandler Me._GroupBox1.Enter, value2
				End If
				Me._GroupBox1 = value
				If Me._GroupBox1 IsNot Nothing Then
					AddHandler Me._GroupBox1.Enter, value2
				End If
			End Set
		End Property

		Public Overridable Property _fraPumpDrag_2 As GroupBox
			Get
				Return Me.__fraPumpDrag_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me.__fraPumpDrag_2 = value
			End Set
		End Property

		Public Overridable Property _optPolishedRodDrag_0 As RadioButton
			Get
				Return Me.__optPolishedRodDrag_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPolishedRodDrag_0_CheckedChanged
				If Me.__optPolishedRodDrag_0 IsNot Nothing Then
					RemoveHandler Me.__optPolishedRodDrag_0.CheckedChanged, value2
				End If
				Me.__optPolishedRodDrag_0 = value
				If Me.__optPolishedRodDrag_0 IsNot Nothing Then
					AddHandler Me.__optPolishedRodDrag_0.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optPolishedRodDrag_1 As RadioButton
			Get
				Return Me.__optPolishedRodDrag_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPolishedRodDrag_1_CheckedChanged
				If Me.__optPolishedRodDrag_1 IsNot Nothing Then
					RemoveHandler Me.__optPolishedRodDrag_1.CheckedChanged, value2
				End If
				Me.__optPolishedRodDrag_1 = value
				If Me.__optPolishedRodDrag_1 IsNot Nothing Then
					AddHandler Me.__optPolishedRodDrag_1.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optPolishedRodDrag_2 As RadioButton
			Get
				Return Me.__optPolishedRodDrag_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPolishedRodDrag_2_CheckedChanged
				If Me.__optPolishedRodDrag_2 IsNot Nothing Then
					RemoveHandler Me.__optPolishedRodDrag_2.CheckedChanged, value2
				End If
				Me.__optPolishedRodDrag_2 = value
				If Me.__optPolishedRodDrag_2 IsNot Nothing Then
					AddHandler Me.__optPolishedRodDrag_2.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _fraPumpDrag_1 As GroupBox
			Get
				Return Me.__fraPumpDrag_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me.__fraPumpDrag_1 = value
			End Set
		End Property

		Public Overridable Property _optPumpDragDown_0 As RadioButton
			Get
				Return Me.__optPumpDragDown_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPumpDragDown_0_CheckedChanged
				If Me.__optPumpDragDown_0 IsNot Nothing Then
					RemoveHandler Me.__optPumpDragDown_0.CheckedChanged, value2
				End If
				Me.__optPumpDragDown_0 = value
				If Me.__optPumpDragDown_0 IsNot Nothing Then
					AddHandler Me.__optPumpDragDown_0.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optPumpDragDown_1 As RadioButton
			Get
				Return Me.__optPumpDragDown_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPumpDragDown_1_CheckedChanged
				If Me.__optPumpDragDown_1 IsNot Nothing Then
					RemoveHandler Me.__optPumpDragDown_1.CheckedChanged, value2
				End If
				Me.__optPumpDragDown_1 = value
				If Me.__optPumpDragDown_1 IsNot Nothing Then
					AddHandler Me.__optPumpDragDown_1.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optPumpDragDown_2 As RadioButton
			Get
				Return Me.__optPumpDragDown_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPumpDragDown_2_CheckedChanged
				If Me.__optPumpDragDown_2 IsNot Nothing Then
					RemoveHandler Me.__optPumpDragDown_2.CheckedChanged, value2
				End If
				Me.__optPumpDragDown_2 = value
				If Me.__optPumpDragDown_2 IsNot Nothing Then
					AddHandler Me.__optPumpDragDown_2.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _fraPumpDrag_0 As GroupBox
			Get
				Return Me.__fraPumpDrag_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me.__fraPumpDrag_0 = value
			End Set
		End Property

		Public Overridable Property _optPumpDragUp_2 As RadioButton
			Get
				Return Me.__optPumpDragUp_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPumpDragUp_2_CheckedChanged
				If Me.__optPumpDragUp_2 IsNot Nothing Then
					RemoveHandler Me.__optPumpDragUp_2.CheckedChanged, value2
				End If
				Me.__optPumpDragUp_2 = value
				If Me.__optPumpDragUp_2 IsNot Nothing Then
					AddHandler Me.__optPumpDragUp_2.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optPumpDragUp_1 As RadioButton
			Get
				Return Me.__optPumpDragUp_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPumpDragUp_1_CheckedChanged
				If Me.__optPumpDragUp_1 IsNot Nothing Then
					RemoveHandler Me.__optPumpDragUp_1.CheckedChanged, value2
				End If
				Me.__optPumpDragUp_1 = value
				If Me.__optPumpDragUp_1 IsNot Nothing Then
					AddHandler Me.__optPumpDragUp_1.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optPumpDragUp_0 As RadioButton
			Get
				Return Me.__optPumpDragUp_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optPumpDragUp_0_CheckedChanged
				If Me.__optPumpDragUp_0 IsNot Nothing Then
					RemoveHandler Me.__optPumpDragUp_0.CheckedChanged, value2
				End If
				Me.__optPumpDragUp_0 = value
				If Me.__optPumpDragUp_0 IsNot Nothing Then
					AddHandler Me.__optPumpDragUp_0.CheckedChanged, value2
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

		Public Overridable Property txtPumpDragDownstrokeMax As TextBox
			Get
				Return Me._txtPumpDragDownstrokeMax
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtPumpDragDownstrokeMax_Leave
				If Me._txtPumpDragDownstrokeMax IsNot Nothing Then
					RemoveHandler Me._txtPumpDragDownstrokeMax.Leave, value2
				End If
				Me._txtPumpDragDownstrokeMax = value
				If Me._txtPumpDragDownstrokeMax IsNot Nothing Then
					AddHandler Me._txtPumpDragDownstrokeMax.Leave, value2
				End If
			End Set
		End Property

		Public Overridable Property txtPumpDragUpstrokeMax As TextBox
			Get
				Return Me._txtPumpDragUpstrokeMax
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtPumpDragUpstrokeMax_Leave
				If Me._txtPumpDragUpstrokeMax IsNot Nothing Then
					RemoveHandler Me._txtPumpDragUpstrokeMax.Leave, value2
				End If
				Me._txtPumpDragUpstrokeMax = value
				If Me._txtPumpDragUpstrokeMax IsNot Nothing Then
					AddHandler Me._txtPumpDragUpstrokeMax.Leave, value2
				End If
			End Set
		End Property

		Public Overridable Property txtFluidDamping As TextBox
			Get
				Return Me._txtFluidDamping
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtFluidDamping_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtFluidDamping_Leave
				If Me._txtFluidDamping IsNot Nothing Then
					RemoveHandler Me._txtFluidDamping.TextChanged, value2
					RemoveHandler Me._txtFluidDamping.Leave, value3
				End If
				Me._txtFluidDamping = value
				If Me._txtFluidDamping IsNot Nothing Then
					AddHandler Me._txtFluidDamping.TextChanged, value2
					AddHandler Me._txtFluidDamping.Leave, value3
				End If
			End Set
		End Property

		Public Overridable Property _Label_12 As Label
			Get
				Return Me.__Label_12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_12 = value
			End Set
		End Property

		Public Overridable Property _Label_11 As Label
			Get
				Return Me.__Label_11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_11 = value
			End Set
		End Property

		Public Overridable Property _Label_10 As Label
			Get
				Return Me.__Label_10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_10 = value
			End Set
		End Property

		Friend Overridable Property cmdCancel As Button
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

		Friend Overridable Property cmdOK As Button
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

		Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtFluidDamping_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtFluidDamping, True, False, obj) Then
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
			Dim msgtxt As String
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Util.Errmsg(msgtxt)
				Me.txtFluidDamping.Focus()
				Return
			End If
			Dim obj3 As Object = flag
			Dim upperBound As Single = 5F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = -1
			Dim useMetric2 As Integer = 0
			Dim canadianIsMetric2 As Integer = 0
			Dim bQuiet2 As Boolean = False
			text = ""
			If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
				Util.Errmsg(msgtxt)
				Me.txtFluidDamping.Focus()
				Return
			End If
			ini.SaveDataValue("FluidDamping", RuntimeHelpers.GetObjectValue(obj))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.rst.FluidDamping = Conversions.ToSingle(obj)
			End If
		End Sub

		Private Sub txtPumpDragDownstrokeMax_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim num As Double = (Conversion.Int(0.15 * CDbl(RSWIN_DESC.rst.PumpDepth) / 100.0) + 1.0) * 100.0
			Dim msgtxt As String = Util.FormatMessage(Me.sMaxDStrokeDrag, New Object() { num })
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtPumpDragDownstrokeMax, True, False, obj) Then
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
					Me.txtPumpDragDownstrokeMax.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = CSng(num)
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = -1
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtPumpDragDownstrokeMax.Focus()
					Else
						ini.SaveDataValue("PumpDragDownstrokeMax", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.PumpDragDownstrokeMax = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtPumpDragUpstrokeMax_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim num As Double = (Conversion.Int(0.15 * CDbl(RSWIN_DESC.rst.PumpDepth) / 100.0) + 1.0) * 100.0
			Dim msgtxt As String = Util.FormatMessage(Me.sMaxUStrokeDrag, New Object() { num })
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtPumpDragUpstrokeMax, True, False, obj) Then
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
					Me.txtPumpDragUpstrokeMax.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = CSng(num)
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = -1
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtPumpDragUpstrokeMax.Focus()
					Else
						ini.SaveDataValue("PumpDragUpstrokeMax", RuntimeHelpers.GetObjectValue(obj))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.PumpDragUpstrokeMax = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub optPolishedRodDrag_Click(Index As Integer)
			' The following expression was wrapped in a checked-expression
			RSWIN_DESC.rst.DragSettings = CShort((Index * 16 Or CInt((RSWIN_DESC.rst.DragSettings And -49S))))
		End Sub

		Private Sub optPumpDragDown_Click(Index As Integer)
			' The following expression was wrapped in a checked-expression
			RSWIN_DESC.rst.DragSettings = CShort((Index * 4 Or CInt((RSWIN_DESC.rst.DragSettings And -13S))))
		End Sub

		Private Sub optPumpDragUp_Click(Index As Integer)
			' The following expression was wrapped in a checked-expression
			RSWIN_DESC.rst.DragSettings = CShort((Index Or CInt((RSWIN_DESC.rst.DragSettings And -4S))))
		End Sub

		Private Sub _optPumpDragUp_0_CheckedChanged(sender As Object, e As EventArgs)
			Me.optPumpDragUp_Click(0)
		End Sub

		Private Sub _optPumpDragDown_0_CheckedChanged(sender As Object, e As EventArgs)
			Me.optPumpDragDown_Click(0)
		End Sub

		Private Sub _optPumpDragDown_1_CheckedChanged(sender As Object, e As EventArgs)
			Me.optPumpDragDown_Click(1)
		End Sub

		Private Sub _optPolishedRodDrag_0_CheckedChanged(sender As Object, e As EventArgs)
			Me.optPolishedRodDrag_Click(0)
		End Sub

		Private Sub _optPumpDragUp_1_CheckedChanged(sender As Object, e As EventArgs)
			Me.optPumpDragUp_Click(1)
		End Sub

		Private Sub _optPumpDragUp_2_CheckedChanged(sender As Object, e As EventArgs)
			Me.optPumpDragUp_Click(2)
		End Sub

		Private Sub _optPumpDragDown_2_CheckedChanged(sender As Object, e As EventArgs)
			Me.optPumpDragDown_Click(2)
		End Sub

		Private Sub _optPolishedRodDrag_1_CheckedChanged(sender As Object, e As EventArgs)
			Me.optPolishedRodDrag_Click(1)
		End Sub

		Private Sub _optPolishedRodDrag_2_CheckedChanged(sender As Object, e As EventArgs)
			Me.optPolishedRodDrag_Click(2)
		End Sub

		Private Sub txtFluidDamping_TextChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub frmDevSettings_Load(sender As Object, e As EventArgs)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Me.txtFluidDamping.Text = Convert.ToString(rst.FluidDamping)
			Me.txtPumpDragUpstrokeMax.Text = Convert.ToString(rst.PumpDragUpstrokeMax)
			Me.txtPumpDragDownstrokeMax.Text = Convert.ToString(rst.PumpDragDownstrokeMax)
			Me.SetoptPumpDragUp(CInt((rst.DragSettings And 3S)))
			Me.SetoptPumpDragDown(CInt((rst.DragSettings / 4S And 3S)))
			Me.SetoptPolishedRodDrag(CInt((rst.DragSettings / 16S And 3S)))
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Nothing)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private Sub SetoptPolishedRodDrag(Index As Integer)
			Select Case Index
				Case 0
					Me._optPolishedRodDrag_0.Checked = True
				Case 1
					Me._optPolishedRodDrag_1.Checked = True
				Case 2
					Me._optPolishedRodDrag_2.Checked = True
			End Select
		End Sub

		Private Sub SetoptPumpDragDown(Index As Integer)
			Select Case Index
				Case 0
					Me._optPumpDragDown_0.Checked = True
				Case 1
					Me._optPumpDragDown_1.Checked = True
				Case 2
					Me._optPumpDragDown_2.Checked = True
			End Select
		End Sub

		Private Sub SetoptPumpDragUp(Index As Integer)
			Select Case Index
				Case 0
					Me._optPumpDragUp_0.Checked = True
				Case 1
					Me._optPumpDragUp_1.Checked = True
				Case 2
					Me._optPumpDragUp_2.Checked = True
			End Select
		End Sub

		Private Sub cmdOK_Click(sender As Object, e As EventArgs)
			Me.Hide()
		End Sub

		Private Sub cmdCancel_Click(sender As Object, e As EventArgs)
			Me.Hide()
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

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("_fraPumpDrag_2")>
		Private __fraPumpDrag_2 As GroupBox

		<AccessedThroughProperty("_optPolishedRodDrag_0")>
		Private __optPolishedRodDrag_0 As RadioButton

		<AccessedThroughProperty("_optPolishedRodDrag_1")>
		Private __optPolishedRodDrag_1 As RadioButton

		<AccessedThroughProperty("_optPolishedRodDrag_2")>
		Private __optPolishedRodDrag_2 As RadioButton

		<AccessedThroughProperty("_fraPumpDrag_1")>
		Private __fraPumpDrag_1 As GroupBox

		<AccessedThroughProperty("_optPumpDragDown_0")>
		Private __optPumpDragDown_0 As RadioButton

		<AccessedThroughProperty("_optPumpDragDown_1")>
		Private __optPumpDragDown_1 As RadioButton

		<AccessedThroughProperty("_optPumpDragDown_2")>
		Private __optPumpDragDown_2 As RadioButton

		<AccessedThroughProperty("_fraPumpDrag_0")>
		Private __fraPumpDrag_0 As GroupBox

		<AccessedThroughProperty("_optPumpDragUp_2")>
		Private __optPumpDragUp_2 As RadioButton

		<AccessedThroughProperty("_optPumpDragUp_1")>
		Private __optPumpDragUp_1 As RadioButton

		<AccessedThroughProperty("_optPumpDragUp_0")>
		Private __optPumpDragUp_0 As RadioButton

		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		<AccessedThroughProperty("txtPumpDragDownstrokeMax")>
		Private _txtPumpDragDownstrokeMax As TextBox

		<AccessedThroughProperty("txtPumpDragUpstrokeMax")>
		Private _txtPumpDragUpstrokeMax As TextBox

		<AccessedThroughProperty("txtFluidDamping")>
		Private _txtFluidDamping As TextBox

		<AccessedThroughProperty("_Label_12")>
		Private __Label_12 As Label

		<AccessedThroughProperty("_Label_11")>
		Private __Label_11 As Label

		<AccessedThroughProperty("_Label_10")>
		Private __Label_10 As Label

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		Private MyParentFrm As RODSTAR

		Private sMsg_FluidDamping As String

		Private sMaxDStrokeDrag As String

		Private sMaxUStrokeDrag As String
	End Class
End Namespace
