Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Partial Class frmImportDialog
		Inherits Form

		Public Property bContinue As Boolean
			Get
				Return Me.m_bContinue
			End Get
			Set(value As Boolean)
				Me.m_bContinue = value
			End Set
		End Property

		Public Property bExcel As Boolean
			Get
				Return Me.m_bExcel
			End Get
			Set(value As Boolean)
				Me.m_bExcel = value
			End Set
		End Property

		Public Property bCSV As Boolean
			Get
				Return Me.m_bCSV
			End Get
			Set(value As Boolean)
				Me.m_bCSV = value
			End Set
		End Property

		Public Property bRodstar As Boolean
			Get
				Return Me.m_bRodstar
			End Get
			Set(value As Boolean)
				Me.m_bRodstar = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmImportDialog_Load
			Me.m_bContinue = False
			Me.m_bExcel = False
			Me.m_bCSV = False
			Me.m_bRodstar = False
			Me.InitializeComponent()
		End Sub

		Friend Overridable Property rdbRSTX As RadioButton
			Get
				Return Me._rdbRSTX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rdbRSTX_CheckedChanged
				If Me._rdbRSTX IsNot Nothing Then
					RemoveHandler Me._rdbRSTX.CheckedChanged, value2
				End If
				Me._rdbRSTX = value
				If Me._rdbRSTX IsNot Nothing Then
					AddHandler Me._rdbRSTX.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnContinue As Button
			Get
				Return Me._btnContinue
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnContinue_Click
				If Me._btnContinue IsNot Nothing Then
					RemoveHandler Me._btnContinue.Click, value2
				End If
				Me._btnContinue = value
				If Me._btnContinue IsNot Nothing Then
					AddHandler Me._btnContinue.Click, value2
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

		Friend Overridable Property rdbExcel As RadioButton
			Get
				Return Me._rdbExcel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rdbExcel_CheckedChanged
				If Me._rdbExcel IsNot Nothing Then
					RemoveHandler Me._rdbExcel.CheckedChanged, value2
				End If
				Me._rdbExcel = value
				If Me._rdbExcel IsNot Nothing Then
					AddHandler Me._rdbExcel.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property rdbCSV As RadioButton
			Get
				Return Me._rdbCSV
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rdbCSV_CheckedChanged
				If Me._rdbCSV IsNot Nothing Then
					RemoveHandler Me._rdbCSV.CheckedChanged, value2
				End If
				Me._rdbCSV = value
				If Me._rdbCSV IsNot Nothing Then
					AddHandler Me._rdbCSV.CheckedChanged, value2
				End If
			End Set
		End Property

		Private Sub rdbRSTX_CheckedChanged(sender As Object, e As EventArgs)
			Me.m_bExcel = False
			Me.m_bCSV = False
			Me.m_bRodstar = True
			Me.btnContinue.Enabled = True
		End Sub

		Private Sub btnContinue_Click(sender As Object, e As EventArgs)
			Me.m_bContinue = True
			Me.Close()
		End Sub

		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			Me.m_bContinue = False
			Me.m_bExcel = False
			Me.m_bCSV = False
			Me.m_bRodstar = False
			Me.Close()
		End Sub

		Private Sub rdbExcel_CheckedChanged(sender As Object, e As EventArgs)
			Me.m_bExcel = True
			Me.m_bRodstar = False
			Me.m_bCSV = False
			Me.btnContinue.Enabled = True
		End Sub

		Private Sub frmImportDialog_Load(sender As Object, e As EventArgs)
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
			Me.m_bContinue = False
			Me.m_bExcel = False
			Me.m_bRodstar = False
			Me.m_bCSV = False
			If Me.rdbExcel.Checked Then
				Me.m_bExcel = True
			ElseIf Me.rdbCSV.Checked Then
				Me.m_bCSV = True
			ElseIf Me.rdbRSTX.Checked Then
				Me.m_bRodstar = True
			End If
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Nothing)
				Util.CloseResourceWriter()
			End If
		End Sub

		Private Sub rdbCSV_CheckedChanged(sender As Object, e As EventArgs)
			Me.m_bCSV = True
			Me.m_bExcel = False
			Me.m_bRodstar = False
			Me.btnContinue.Enabled = True
		End Sub

		Private m_bContinue As Boolean

		Private m_bExcel As Boolean

		Private m_bCSV As Boolean

		Private m_bRodstar As Boolean

		<AccessedThroughProperty("rdbRSTX")>
		Private _rdbRSTX As RadioButton

		<AccessedThroughProperty("btnContinue")>
		Private _btnContinue As Button

		<AccessedThroughProperty("btnCancel")>
		Private _btnCancel As Button

		<AccessedThroughProperty("rdbExcel")>
		Private _rdbExcel As RadioButton

		<AccessedThroughProperty("rdbCSV")>
		Private _rdbCSV As RadioButton
	End Class
End Namespace
