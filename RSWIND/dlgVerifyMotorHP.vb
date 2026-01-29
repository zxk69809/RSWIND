Imports System
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
	Friend Partial Class dlgVerifyMotorHP
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgVerifyMotorHP_Load
			If dlgVerifyMotorHP.m_vb6FormDefInstance Is Nothing Then
				If dlgVerifyMotorHP.m_InitializingDefInstance Then
					dlgVerifyMotorHP.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgVerifyMotorHP.m_vb6FormDefInstance = Me
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

		Public Overridable Property cmdMinMotorHP As Button
			Get
				Return Me._cmdMinMotorHP
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdMinMotorHP_TextChanged
				Dim value3 As EventHandler = AddressOf Me.cmdMinMotorHP_Click
				If Me._cmdMinMotorHP IsNot Nothing Then
					RemoveHandler Me._cmdMinMotorHP.TextChanged, value2
					RemoveHandler Me._cmdMinMotorHP.Click, value3
				End If
				Me._cmdMinMotorHP = value
				If Me._cmdMinMotorHP IsNot Nothing Then
					AddHandler Me._cmdMinMotorHP.TextChanged, value2
					AddHandler Me._cmdMinMotorHP.Click, value3
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

		Public Shared Property DefInstance As dlgVerifyMotorHP
			Get
				If dlgVerifyMotorHP.m_vb6FormDefInstance Is Nothing OrElse dlgVerifyMotorHP.m_vb6FormDefInstance.IsDisposed Then
					dlgVerifyMotorHP.m_InitializingDefInstance = True
					dlgVerifyMotorHP.m_vb6FormDefInstance = New dlgVerifyMotorHP()
					dlgVerifyMotorHP.m_InitializingDefInstance = False
				End If
				Return dlgVerifyMotorHP.m_vb6FormDefInstance
			End Get
			Set(value As dlgVerifyMotorHP)
				dlgVerifyMotorHP.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property bChange As Boolean
			Get
				Return Me.m_bChange
			End Get
			Set(value As Boolean)
				Me.m_bChange = value
			End Set
		End Property

		Public Property bUseRecommended As Boolean
			Get
				Return Me.m_bUseRecommended
			End Get
			Set(value As Boolean)
				Me.m_bUseRecommended = value
			End Set
		End Property

		Private Sub cmdChangeSPM_Click(eventSender As Object, eventArgs As EventArgs)
			Me.bChange = True
			Me.bUseRecommended = False
			Me.Close()
		End Sub

		Private Sub cmdContinue_Click(eventSender As Object, eventArgs As EventArgs)
			Me.bChange = False
			Me.bUseRecommended = False
			Me.Enabled = True
			Me.Hide()
		End Sub

		Private Sub cmdMinMotorHP_Click(eventSender As Object, eventArgs As EventArgs)
			Me.bChange = False
			Me.bUseRecommended = True
			Me.Enabled = False
			Me.Hide()
		End Sub

		Private Sub dlgVerifyMotorHP_Load(eventSender As Object, eventArgs As EventArgs)
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bChangeCultures Then
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
				If RSWIN_DESC.bReadResXFile Then
					Util.AssignValuesToControls(Me)
				End If
			End If
			Dim form As Form = Me
			Util.CenterForm(form, RSWIN_DESC.frmMain, RSWIN_DESC.frmMain.pnlToolbar.Height, False)
			Me.Tag = Me.m_RecMotorHP
			Me.txtMessageNumber.Text = Me.m_MessageNumber
			Me.MessageNumberTextChanged()
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
			End If
		End Sub

		Private Sub txtMessageNumber_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Me.MessageNumberTextChanged()
		End Sub

		Private Sub MessageNumberTextChanged()
			Try
				If Versioned.IsNumeric(Me.txtMessageNumber.Text) Then
					' The following expression was wrapped in a checked-expression
					Dim nErrorNumber As Short = CShort(Math.Round(Conversion.Val(Me.txtMessageNumber.Text)))
					Dim text As String
					Util.LoadMessage(CInt(nErrorNumber), text)
					If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.Tag)) Then
						Dim value As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(Me.Tag))
						Util.ApplyNumber(value, text)
						Util.ApplyNumber(Conversions.ToSingle(Motor.GetMotorInfo(0)), text)
					End If
					Me.Label.Text = text
				End If
				If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.Tag)) Then
					Dim text As String = Me.cmdMinMotorHP.Text
					Util.ApplyNumber(Convert.ToSingle(RuntimeHelpers.GetObjectValue(Me.Tag)), text)
					Me.cmdMinMotorHP.Text = text
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Property RecMotorHP As String
			Get
				Return Me.m_RecMotorHP
			End Get
			Set(value As String)
				Me.m_RecMotorHP = value
			End Set
		End Property

		Public Property MessageNumber As String
			Get
				Return Me.m_MessageNumber
			End Get
			Set(value As String)
				Me.m_MessageNumber = value
				Me.txtMessageNumber.Text = Me.m_MessageNumber
			End Set
		End Property

		Private Sub cmdMinMotorHP_TextChanged(sender As Object, e As EventArgs)
		End Sub

		<AccessedThroughProperty("txtMessageNumber")>
		Private _txtMessageNumber As TextBox

		<AccessedThroughProperty("cmdChangeSPM")>
		Private _cmdChangeSPM As Button

		<AccessedThroughProperty("picQuestion")>
		Private _picQuestion As PictureBox

		<AccessedThroughProperty("cmdMinMotorHP")>
		Private _cmdMinMotorHP As Button

		<AccessedThroughProperty("cmdContinue")>
		Private _cmdContinue As Button

		<AccessedThroughProperty("Label")>
		Private _Label As Label

		Private Shared m_vb6FormDefInstance As dlgVerifyMotorHP

		Private Shared m_InitializingDefInstance As Boolean

		Private m_bChange As Boolean

		Private m_bUseRecommended As Boolean

		Private m_RecMotorHP As String

		Private m_MessageNumber As String
	End Class
End Namespace
