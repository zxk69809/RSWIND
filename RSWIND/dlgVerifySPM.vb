Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgVerifySPM
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgVerifySPM_Load
			Me.myKeyValueHT = New Hashtable()
			If dlgVerifySPM.m_vb6FormDefInstance Is Nothing Then
				If dlgVerifySPM.m_InitializingDefInstance Then
					dlgVerifySPM.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgVerifySPM.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property txtMessageNumber As TextBox
			Get
				Return Me._txtMessageNumber
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMessageNumber_TextChanged
				If Me._txtMessageNumber IsNot Nothing Then
					RemoveHandler Me._txtMessageNumber.TextChanged, value2
				End If
				Me._txtMessageNumber = value
				If Me._txtMessageNumber IsNot Nothing Then
					AddHandler Me._txtMessageNumber.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdChangeSPM As Button
			Get
				Return Me._cmdChangeSPM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdChangeSPM_Click
				If Me._cmdChangeSPM IsNot Nothing Then
					RemoveHandler Me._cmdChangeSPM.Click, value2
				End If
				Me._cmdChangeSPM = value
				If Me._cmdChangeSPM IsNot Nothing Then
					AddHandler Me._cmdChangeSPM.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property picQuestion As PictureBox
			Get
				Return Me._picQuestion
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._picQuestion = value
			End Set
		End Property

		Public Overridable Property cmdMaxSPM As Button
			Get
				Return Me._cmdMaxSPM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdMaxSPM_Click
				If Me._cmdMaxSPM IsNot Nothing Then
					RemoveHandler Me._cmdMaxSPM.Click, value2
				End If
				Me._cmdMaxSPM = value
				If Me._cmdMaxSPM IsNot Nothing Then
					AddHandler Me._cmdMaxSPM.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdContinue As Button
			Get
				Return Me._cmdContinue
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdContinue_Click
				If Me._cmdContinue IsNot Nothing Then
					RemoveHandler Me._cmdContinue.Click, value2
				End If
				Me._cmdContinue = value
				If Me._cmdContinue IsNot Nothing Then
					AddHandler Me._cmdContinue.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property Label As Label
			Get
				Return Me._Label
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label = value
			End Set
		End Property

		Public Shared Property DefInstance As dlgVerifySPM
			Get
				If dlgVerifySPM.m_vb6FormDefInstance Is Nothing OrElse dlgVerifySPM.m_vb6FormDefInstance.IsDisposed Then
					dlgVerifySPM.m_InitializingDefInstance = True
					dlgVerifySPM.m_vb6FormDefInstance = New dlgVerifySPM()
					dlgVerifySPM.m_InitializingDefInstance = False
				End If
				Return dlgVerifySPM.m_vb6FormDefInstance
			End Get
			Set(value As dlgVerifySPM)
				dlgVerifySPM.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Declare Ansi Function LoadIconByNum Lib "user32" Alias "LoadIcon" (hInstance As Integer, lpIconName As Integer) As Integer

		Public Property MessageNumber As String
			Get
				Return Me.m_MessageNumber
			End Get
			Set(value As String)
				Me.m_MessageNumber = value
				Me.txtMessageNumber.Text = value
			End Set
		End Property

		Public Property bContinue As Boolean
			Get
				Return Me.m_bContinue
			End Get
			Set(value As Boolean)
				Me.m_bContinue = value
			End Set
		End Property

		Public Property bUseMaxSPM As Boolean
			Get
				Return Me.m_bUseMaxSPM
			End Get
			Set(value As Boolean)
				Me.m_bUseMaxSPM = value
			End Set
		End Property

		Public Property bChangeSPM As Boolean
			Get
				Return Me.m_bChangeSPM
			End Get
			Set(value As Boolean)
				Me.m_bChangeSPM = value
			End Set
		End Property

		Public Property bContinueVisible As Boolean
			Get
				Return Me.m_bContinueVisible
			End Get
			Set(value As Boolean)
				Me.m_bContinueVisible = value
				Me.cmdContinue.Visible = value
			End Set
		End Property

		Public Property SPMThreshold As Single
			Get
				Return Me.m_SPMThreshold
			End Get
			Set(value As Single)
				Me.m_SPMThreshold = value
			End Set
		End Property

		Private Sub cmdChangeSPM_Click(eventSender As Object, eventArgs As EventArgs)
			Me.m_bChangeSPM = True
			Me.m_bUseMaxSPM = False
			Me.m_bContinue = False
			Me.Close()
		End Sub

		Private Sub cmdContinue_Click(eventSender As Object, eventArgs As EventArgs)
			Me.m_bContinue = True
			Me.m_bUseMaxSPM = False
			Me.m_bChangeSPM = False
			Me.Enabled = True
			Me.Hide()
		End Sub

		Private Sub cmdMaxSPM_Click(eventSender As Object, eventArgs As EventArgs)
			Me.m_bUseMaxSPM = True
			Me.m_bContinue = False
			Me.m_bChangeSPM = False
			Me.Enabled = False
			Me.Hide()
		End Sub

		Private Sub dlgVerifySPM_Load(eventSender As Object, eventArgs As EventArgs)
			Try
				Dim form As Form = Me
				Util.CenterForm(form, RSWIN_DESC.frmMain, 0, False)
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
				Me.picQuestion.BackColor = SystemColors.Control
				If(RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S) And Me.SPMThreshold <> 0F And Strings.InStr(Me.cmdMaxSPM.Text, "%{", CompareMethod.Binary) <= 0 Then
					Dim text As String = Me.cmdMaxSPM.Text
					text = text.Replace("0.0", Me.SPMThreshold.ToString().Trim())
					If RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S Then
						text = text.Replace("Rotaflex", RSWIN_DESC.rst.PU.Manuf.TrimEnd(New Char(-1) {}) + " (" + RSWIN_DESC.rst.PU.APIDesignation.TrimEnd(New Char(-1) {}) + ") ")
					End If
					Me.cmdMaxSPM.Text = text
					Me.MessageNumberTextChanged(Me.SPMThreshold)
				Else
					Dim text As String = Me.cmdMaxSPM.Text
					If RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S Then
						text = text.Replace("Rotaflex", RSWIN_DESC.rst.PU.Manuf.TrimEnd(New Char(-1) {}) + " (" + RSWIN_DESC.rst.PU.APIDesignation.TrimEnd(New Char(-1) {}) + ") ")
					End If
					Util.ApplyNumber(RSWIN_DESC.rst.MaxSPM, text)
					Me.cmdMaxSPM.Text = text
					Me.MessageNumberTextChanged(0F)
				End If
				If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter(Me.Name)
					Util.WriteControlStrings(Me, Me.ToolTip1)
					Util.CloseResourceWriter()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtMessageNumber_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Me.MessageNumberTextChanged(0F)
		End Sub

		Private Sub MessageNumberTextChanged(Optional SPMThreshold As Single = 0F)
			Try
				If Versioned.IsNumeric(Me.txtMessageNumber.Text) Then
					Dim nErrorNumber As Integer = CInt(Conversions.ToShort(Me.txtMessageNumber.Text))
					Dim text As String
					Util.LoadMessage(nErrorNumber, text)
					If RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S Then
						text = text.Replace("Rotaflex", RSWIN_DESC.rst.PU.Manuf.TrimEnd(New Char(-1) {}) + " (" + RSWIN_DESC.rst.PU.APIDesignation.TrimEnd(New Char(-1) {}) + ") ")
					End If
					If(RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S) And SPMThreshold <> 0F Then
						RSWIN_DESC.rst.MaxSPM = SPMThreshold
						text = text.Replace("%{0.0}", "%{0.0##}")
						Util.ApplyNumber(SPMThreshold, text)
					Else
						Util.ApplyNumber(RSWIN_DESC.rst.MaxSPM, text)
					End If
					Util.ApplyNumber(RSWIN_DESC.rst.SPM, text)
					Me.Label.Text = text
				End If
			Catch ex As Exception
			End Try
		End Sub

		<AccessedThroughProperty("txtMessageNumber")>
		Private _txtMessageNumber As TextBox

		<AccessedThroughProperty("cmdChangeSPM")>
		Private _cmdChangeSPM As Button

		<AccessedThroughProperty("picQuestion")>
		Private _picQuestion As PictureBox

		<AccessedThroughProperty("cmdMaxSPM")>
		Private _cmdMaxSPM As Button

		<AccessedThroughProperty("cmdContinue")>
		Private _cmdContinue As Button

		<AccessedThroughProperty("Label")>
		Private _Label As Label

		Private Shared m_vb6FormDefInstance As dlgVerifySPM

		Private Shared m_InitializingDefInstance As Boolean

		Private myKeyValueHT As Hashtable

		Private m_MessageNumber As String

		Private m_bContinue As Boolean

		Private m_bUseMaxSPM As Boolean

		Private m_bChangeSPM As Boolean

		Private m_bContinueVisible As Boolean

		Private m_SPMThreshold As Single
	End Class
End Namespace
