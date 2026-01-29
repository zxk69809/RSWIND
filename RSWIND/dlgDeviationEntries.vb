Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgDeviationEntries
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgDeviationEntries_Load
			AddHandler MyBase.Activated, AddressOf Me.dlgDeviationEntries_Activated
			If dlgDeviationEntries.m_vb6FormDefInstance Is Nothing Then
				If dlgDeviationEntries.m_InitializingDefInstance Then
					dlgDeviationEntries.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgDeviationEntries.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property txtInteval As TextBox
			Get
				Return Me._txtInteval
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtInteval_TextChanged
				If Me._txtInteval IsNot Nothing Then
					RemoveHandler Me._txtInteval.TextChanged, value2
				End If
				Me._txtInteval = value
				If Me._txtInteval IsNot Nothing Then
					AddHandler Me._txtInteval.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtEntries As TextBox
			Get
				Return Me._txtEntries
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtEntries_Enter
				Dim value3 As EventHandler = AddressOf Me.txtEntries_TextChanged
				If Me._txtEntries IsNot Nothing Then
					RemoveHandler Me._txtEntries.Enter, value2
					RemoveHandler Me._txtEntries.TextChanged, value3
				End If
				Me._txtEntries = value
				If Me._txtEntries IsNot Nothing Then
					AddHandler Me._txtEntries.Enter, value2
					AddHandler Me._txtEntries.TextChanged, value3
				End If
			End Set
		End Property

		Public Overridable Property CancelButton_Renamed As Button
			Get
				Return Me._CancelButton_Renamed
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.CancelButton_Renamed_Click
				If Me._CancelButton_Renamed IsNot Nothing Then
					RemoveHandler Me._CancelButton_Renamed.Click, value2
				End If
				Me._CancelButton_Renamed = value
				If Me._CancelButton_Renamed IsNot Nothing Then
					AddHandler Me._CancelButton_Renamed.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property OKButton As Button
			Get
				Return Me._OKButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.OKButton_Click
				If Me._OKButton IsNot Nothing Then
					RemoveHandler Me._OKButton.Click, value2
				End If
				Me._OKButton = value
				If Me._OKButton IsNot Nothing Then
					AddHandler Me._OKButton.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property lblInterval As Label
			Get
				Return Me._lblInterval
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblInterval = value
			End Set
		End Property

		Public Overridable Property lblNumberOfEntries As Label
			Get
				Return Me._lblNumberOfEntries
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumberOfEntries = value
			End Set
		End Property

		Public Shared Property DefInstance As dlgDeviationEntries
			Get
				If dlgDeviationEntries.m_vb6FormDefInstance Is Nothing OrElse dlgDeviationEntries.m_vb6FormDefInstance.IsDisposed Then
					dlgDeviationEntries.m_InitializingDefInstance = True
					dlgDeviationEntries.m_vb6FormDefInstance = New dlgDeviationEntries()
					dlgDeviationEntries.m_InitializingDefInstance = False
				End If
				Return dlgDeviationEntries.m_vb6FormDefInstance
			End Get
			Set(value As dlgDeviationEntries)
				dlgDeviationEntries.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub CancelButton_Renamed_Click(eventSender As Object, eventArgs As EventArgs)
			RSWIN_DESC.iEntryNum = 0S
			RSWIN_DESC.iEntryInterval = 0S
			Me.Close()
		End Sub

		Private Sub OKButton_Click(eventSender As Object, eventArgs As EventArgs)
			If Versioned.IsNumeric(Me.txtEntries.Text) Then
				RSWIN_DESC.iEntryNum = Conversions.ToShort(Me.txtEntries.Text)
			End If
			If Versioned.IsNumeric(Me.txtInteval.Text) Then
				RSWIN_DESC.iEntryInterval = Conversions.ToShort(Me.txtInteval.Text)
			Else
				RSWIN_DESC.iEntryInterval = 0S
			End If
			Me.Close()
		End Sub

		Private Sub txtEntries_TextChanged(eventSender As Object, eventArgs As EventArgs)
			If Versioned.IsNumeric(Me.txtEntries.Text) Then
				RSWIN_DESC.iEntryNum = Conversions.ToShort(Me.txtEntries.Text)
			Else
				RSWIN_DESC.iEntryNum = 0S
			End If
		End Sub

		Private Sub txtInteval_TextChanged(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub dlgDeviationEntries_Load(sender As Object, e As EventArgs)
			Me.txtEntries.Focus()
			Me.txtEntries.BackColor = RSWIN_DESC.rgbEditFocus
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
			End If
		End Sub

		Private Sub txtEntries_Enter(sender As Object, e As EventArgs)
			Me.txtEntries.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub dlgDeviationEntries_Activated(sender As Object, e As EventArgs)
		End Sub

		<AccessedThroughProperty("txtInteval")>
		Private _txtInteval As TextBox

		<AccessedThroughProperty("txtEntries")>
		Private _txtEntries As TextBox

		<AccessedThroughProperty("CancelButton_Renamed")>
		Private _CancelButton_Renamed As Button

		<AccessedThroughProperty("OKButton")>
		Private _OKButton As Button

		<AccessedThroughProperty("lblInterval")>
		Private _lblInterval As Label

		<AccessedThroughProperty("lblNumberOfEntries")>
		Private _lblNumberOfEntries As Label

		Private Shared m_vb6FormDefInstance As dlgDeviationEntries

		Private Shared m_InitializingDefInstance As Boolean
	End Class
End Namespace
