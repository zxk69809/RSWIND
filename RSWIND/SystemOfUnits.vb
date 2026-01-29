Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Partial Class SystemOfUnits
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.SystemOfUnits_Load
			Me.InitializeComponent()
		End Sub

		Friend Overridable Property grpSystemOfUnits As GroupBox
			Get
				Return Me._grpSystemOfUnits
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpSystemOfUnits = value
			End Set
		End Property

		Friend Overridable Property rbtMetric As RadioButton
			Get
				Return Me._rbtMetric
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtMetric_CheckedChanged
				If Me._rbtMetric IsNot Nothing Then
					RemoveHandler Me._rbtMetric.CheckedChanged, value2
				End If
				Me._rbtMetric = value
				If Me._rbtMetric IsNot Nothing Then
					AddHandler Me._rbtMetric.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property rbtCanadian As RadioButton
			Get
				Return Me._rbtCanadian
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtCanadian_CheckedChanged
				If Me._rbtCanadian IsNot Nothing Then
					RemoveHandler Me._rbtCanadian.CheckedChanged, value2
				End If
				Me._rbtCanadian = value
				If Me._rbtCanadian IsNot Nothing Then
					AddHandler Me._rbtCanadian.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property rbtEnglish As RadioButton
			Get
				Return Me._rbtEnglish
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtEnglish_CheckedChanged
				If Me._rbtEnglish IsNot Nothing Then
					RemoveHandler Me._rbtEnglish.CheckedChanged, value2
				End If
				Me._rbtEnglish = value
				If Me._rbtEnglish IsNot Nothing Then
					AddHandler Me._rbtEnglish.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnCancel As Button
			Get
				Return Me._btnCancel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnCancel_Click
				If Me._btnCancel IsNot Nothing Then
					RemoveHandler Me._btnCancel.Click, value2
				End If
				Me._btnCancel = value
				If Me._btnCancel IsNot Nothing Then
					AddHandler Me._btnCancel.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnOK As Button
			Get
				Return Me._btnOK
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnOK_Click
				If Me._btnOK IsNot Nothing Then
					RemoveHandler Me._btnOK.Click, value2
				End If
				Me._btnOK = value
				If Me._btnOK IsNot Nothing Then
					AddHandler Me._btnOK.Click, value2
				End If
			End Set
		End Property

		Private Sub btnOK_Click(sender As Object, e As EventArgs)
			Me.bSaveSetup_MeasurementSystem = RSWIN_DESC.SETUP_MeasurementSystem
			If Me.rbtEnglish.Checked Then
				RSWIN_DESC.SETUP_MeasurementSystem = 1
				If RSWIN_DESC.frmMain IsNot Nothing Then
					RSWIN_DESC.frmMain.btnMeasUnit.Text = "E"
				End If
			ElseIf Me.rbtMetric.Checked Then
				RSWIN_DESC.SETUP_MeasurementSystem = 3
				If RSWIN_DESC.frmMain IsNot Nothing Then
					RSWIN_DESC.frmMain.btnMeasUnit.Text = "M"
				End If
			ElseIf Me.rbtCanadian.Checked Then
				RSWIN_DESC.SETUP_MeasurementSystem = 2
				If RSWIN_DESC.frmMain IsNot Nothing Then
					RSWIN_DESC.frmMain.btnMeasUnit.Text = "C"
				End If
			End If
			If Me.bSaveSetup_MeasurementSystem <> RSWIN_DESC.SETUP_MeasurementSystem Then
				RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
			End If
			Me.Hide()
		End Sub

		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			If RSWIN_DESC.SETUP_MeasurementSystem <> Me.bSaveSetup_MeasurementSystem Then
				RSWIN_DESC.SETUP_MeasurementSystem = Me.bSaveSetup_MeasurementSystem
				Dim text As String = "MeasurementSystem"
				Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text2 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				Dim text3 As String = text2
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
				Select Case RSWIN_DESC.SETUP_MeasurementSystem
					Case 1
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "E"
						End If
					Case 2
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "C"
						End If
					Case 3
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "M"
						End If
					Case Else
						RSWIN_DESC.SETUP_MeasurementSystem = 1
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "E"
						End If
				End Select
			End If
			Me.Hide()
		End Sub

		Private Sub SystemOfUnits_Load(sender As Object, e As EventArgs)
			RSWIN.GetMeasurementUnit()
			Me.bSaveSetup_MeasurementSystem = RSWIN_DESC.SETUP_MeasurementSystem
			Select Case RSWIN_DESC.SETUP_MeasurementSystem
				Case 1
					Me.rbtEnglish.Checked = True
					Return
				Case 2
					Me.rbtCanadian.Checked = True
					Return
				Case 3
					Me.rbtMetric.Checked = True
					Return
				Case Else
					Return
			End Select
		End Sub

		Private Sub rbtEnglish_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbtEnglish.Checked Then
				RSWIN_DESC.SETUP_MeasurementSystem = 1
				Dim text As String = "MeasurementSystem"
				Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text2 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				Dim text3 As String = text2
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
				If RSWIN_DESC.frmMain IsNot Nothing Then
					RSWIN_DESC.frmMain.btnMeasUnit.Text = "E"
				End If
				Return
			End If
		End Sub

		Private Sub rbtCanadian_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbtCanadian.Checked Then
				RSWIN_DESC.SETUP_MeasurementSystem = 2
				Dim text As String = "MeasurementSystem"
				Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text2 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				Dim text3 As String = text2
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
				text3 = "DisplaySBinFeet"
				Dim flag As Boolean = True
				RSWIN_DESC.SETUP_DisplaySBinFeet = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_GENERAL, text3, flag) > False), 1S, 0S)), 1S, 0S)
				If RSWIN_DESC.frmMain IsNot Nothing Then
					RSWIN_DESC.frmMain.btnMeasUnit.Text = "C"
				End If
				Return
			End If
		End Sub

		Private Sub rbtMetric_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbtMetric.Checked Then
				RSWIN_DESC.SETUP_MeasurementSystem = 3
				Dim text As String = "MeasurementSystem"
				Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text2 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				Dim text3 As String = text2
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_DisplaySBinFeet = 0S
				If RSWIN_DESC.frmMain IsNot Nothing Then
					RSWIN_DESC.frmMain.btnMeasUnit.Text = "M"
				End If
				Return
			End If
		End Sub

		<AccessedThroughProperty("grpSystemOfUnits")>
		Private _grpSystemOfUnits As GroupBox

		<AccessedThroughProperty("rbtMetric")>
		Private _rbtMetric As RadioButton

		<AccessedThroughProperty("rbtCanadian")>
		Private _rbtCanadian As RadioButton

		<AccessedThroughProperty("rbtEnglish")>
		Private _rbtEnglish As RadioButton

		<AccessedThroughProperty("btnCancel")>
		Private _btnCancel As Button

		<AccessedThroughProperty("btnOK")>
		Private _btnOK As Button

		Private bSaveSetup_MeasurementSystem As Integer
	End Class
End Namespace
