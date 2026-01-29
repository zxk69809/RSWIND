Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgSelectDir
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgSelectDir_Load
			If dlgSelectDir.m_vb6FormDefInstance Is Nothing Then
				If dlgSelectDir.m_InitializingDefInstance Then
					dlgSelectDir.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgSelectDir.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property txtPath As TextBox
			Get
				Return Me._txtPath
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtPath_TextChanged
				If Me._txtPath IsNot Nothing Then
					RemoveHandler Me._txtPath.TextChanged, value2
				End If
				Me._txtPath = value
				If Me._txtPath IsNot Nothing Then
					AddHandler Me._txtPath.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdOK As Button
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

		Public Overridable Property cmdCancel As Button
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

		Public Overridable Property Drive1 As DriveListBox
			Get
				Return Me._Drive1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DriveListBox)
				Dim value2 As EventHandler = AddressOf Me.Drive1_SelectedIndexChanged
				If Me._Drive1 IsNot Nothing Then
					RemoveHandler Me._Drive1.SelectedIndexChanged, value2
				End If
				Me._Drive1 = value
				If Me._Drive1 IsNot Nothing Then
					AddHandler Me._Drive1.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property Dir1 As DirListBox
			Get
				Return Me._Dir1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DirListBox)
				Dim value2 As EventHandler = AddressOf Me.Dir1_SelectedIndexChanged
				Dim obj As EventHandler = AddressOf Me.Dir1_Change
				If Me._Dir1 IsNot Nothing Then
					RemoveHandler Me._Dir1.SelectedIndexChanged, value2
					RemoveHandler Me._Dir1.Change, obj
				End If
				Me._Dir1 = value
				If Me._Dir1 IsNot Nothing Then
					AddHandler Me._Dir1.SelectedIndexChanged, value2
					AddHandler Me._Dir1.Change, obj
				End If
			End Set
		End Property

		Public Overridable Property lblCurrentPath As Label
			Get
				Return Me._lblCurrentPath
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.lblCurrentPath_Click
				If Me._lblCurrentPath IsNot Nothing Then
					RemoveHandler Me._lblCurrentPath.Click, value2
				End If
				Me._lblCurrentPath = value
				If Me._lblCurrentPath IsNot Nothing Then
					AddHandler Me._lblCurrentPath.Click, value2
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

		Public Overridable Property lblCaption As Label
			Get
				Return Me._lblCaption
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCaption = value
			End Set
		End Property

		Public Overridable Property SSPanel As PanelArray
			Get
				Return Me._SSPanel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PanelArray)
				Me._SSPanel = value
			End Set
		End Property

		Public Shared Property DefInstance As dlgSelectDir
			Get
				If dlgSelectDir.m_vb6FormDefInstance Is Nothing OrElse dlgSelectDir.m_vb6FormDefInstance.IsDisposed Then
					dlgSelectDir.m_InitializingDefInstance = True
					dlgSelectDir.m_vb6FormDefInstance = New dlgSelectDir()
					dlgSelectDir.m_InitializingDefInstance = False
				End If
				Return dlgSelectDir.m_vb6FormDefInstance
			End Get
			Set(value As dlgSelectDir)
				dlgSelectDir.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property Path As String
			Get
				Return Me.m_Path
			End Get
			Set(value As String)
				Me.m_Path = value
			End Set
		End Property

		Public Property Caption As String
			Get
				Return Me.m_Caption
			End Get
			Set(value As String)
				Me.m_Caption = value
				Me.lblCaption.Text = value
			End Set
		End Property

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			Me.m_Path = ""
			Me.Close()
		End Sub

		Private Sub cmdOK_Click(eventSender As Object, eventArgs As EventArgs)
			Me.txtPath.Text = Me.Dir1.Path
			RSWIN_DESC.sSelectedFolder = Me.lblCurrentPath.Text
			Me.Hide()
		End Sub

		Private Sub Dir1_Change(eventSender As Object, eventArgs As EventArgs)
			Dim num As Short = 0S
			Dim num2 As Short
			Dim num3 As Short
			Dim num4 As Short
			Dim num5 As Short
			While Strings.Len(Me.Dir1.get_DirList(CInt((num - 1S)))) <> 0
				num -= 1S
			End While
			num2 = 0S
			num3 = 0S
			num4 = num
			num5 = CShort((Me.Dir1.DirListCount - 1))
			For num6 As Short = num4 To num5
				Dim str As String = Me.Dir1.get_DirList(CInt(num6))
				If num6 > num Then
					Dim expression As String
					str = Strings.Mid(str, Strings.Len(expression) + 1 - CInt(If(-If((num2 > 1S > False), 1S, 0S), 1S, 0S)))
				End If
				num3 += 1S
				If num6 < 0S Then
					num2 += 1S
				End If
				If num6 < 0S Then
					Dim expression As String = Me.Dir1.get_DirList(CInt(num6))
				End If
			Next
			Me.txtPath.Text = Me.Dir1.Path
			Me.lblCurrentPath.Text = Me.Dir1.Path
		End Sub

		Private Sub Drive1_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			Me.Dir1.Path = Me.Drive1.Drive
		End Sub

		Private Sub dlgSelectDir_Load(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub txtPath_TextChanged(eventSender As Object, eventArgs As EventArgs)
			If Operators.CompareString(Me.txtPath.Text, "", False) <> 0 Then
				Me.Dir1.Path = Me.txtPath.Text
				Me.m_Path = Me.txtPath.Text
			End If
		End Sub

		Private Sub lblCurrentPath_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub Dir1_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.Dir1.Path, "", False) <> 0 Then
				Me.txtPath.Text = Me.Dir1.Path
				Me.m_Path = Me.txtPath.Text
				Me.lblCurrentPath.Text = Me.m_Path
			End If
		End Sub

		<AccessedThroughProperty("txtPath")>
		Private _txtPath As TextBox

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("Drive1")>
		Private _Drive1 As DriveListBox

		<AccessedThroughProperty("Dir1")>
		Private _Dir1 As DirListBox

		<AccessedThroughProperty("lblCurrentPath")>
		Private _lblCurrentPath As Label

		<AccessedThroughProperty("Label")>
		Private _Label As Label

		<AccessedThroughProperty("lblCaption")>
		Private _lblCaption As Label

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As PanelArray

		Private Shared m_vb6FormDefInstance As dlgSelectDir

		Private Shared m_InitializingDefInstance As Boolean

		Private m_Path As String

		Private m_Caption As String
	End Class
End Namespace
