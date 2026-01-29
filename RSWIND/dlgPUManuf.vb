Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6

Namespace RSWINV3
	Friend Partial Class dlgPUManuf
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgPUManuf_Load
			AddHandler MyBase.Closing, AddressOf Me.dlgPUManuf_Closing
			If dlgPUManuf.m_vb6FormDefInstance Is Nothing Then
				If dlgPUManuf.m_InitializingDefInstance Then
					dlgPUManuf.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgPUManuf.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

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

		Public Overridable Property txtPUManuf As TextBox
			Get
				Return Me._txtPUManuf
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtPUManuf = value
			End Set
		End Property

		Public Overridable Property _SSPanel_1 As Panel
			Get
				Return Me.__SSPanel_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__SSPanel_1 = value
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

		Public Overridable Property _SSPanel_0 As Panel
			Get
				Return Me.__SSPanel_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__SSPanel_0 = value
			End Set
		End Property

		Public Overridable Property Image As PictureBox
			Get
				Return Me._Image
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._Image = value
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

		Public Shared Property DefInstance As dlgPUManuf
			Get
				If dlgPUManuf.m_vb6FormDefInstance Is Nothing OrElse dlgPUManuf.m_vb6FormDefInstance.IsDisposed Then
					dlgPUManuf.m_InitializingDefInstance = True
					dlgPUManuf.m_vb6FormDefInstance = New dlgPUManuf()
					dlgPUManuf.m_InitializingDefInstance = False
				End If
				Return dlgPUManuf.m_vb6FormDefInstance
			End Get
			Set(value As dlgPUManuf)
				dlgPUManuf.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub cmdOK_Click(eventSender As Object, eventArgs As EventArgs)
			Me.Hide()
		End Sub

		Private Sub dlgPUManuf_Load(eventSender As Object, eventArgs As EventArgs)
			Dim form As Form = Me
			Util.CenterForm(form, RSWIN_DESC.frmMain, RSWIN_DESC.frmMain.pnlToolbar.Height, False)
			Me.txtPUManuf.SelectionStart = 0
			Me.txtPUManuf.SelectionLength = Strings.Len(Me.txtPUManuf.Text)
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private Sub dlgPUManuf_Closing(eventSender As Object, eventArgs As CancelEventArgs)
			Dim num As Short = If((-If((eventArgs.Cancel > False), 1S, 0S)), 1S, 0S)
			Me.Hide()
		End Sub

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("txtPUManuf")>
		Private _txtPUManuf As TextBox

		<AccessedThroughProperty("_SSPanel_1")>
		Private __SSPanel_1 As Panel

		<AccessedThroughProperty("Label")>
		Private _Label As Label

		<AccessedThroughProperty("_SSPanel_0")>
		Private __SSPanel_0 As Panel

		<AccessedThroughProperty("Image")>
		Private _Image As PictureBox

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As PanelArray

		Private Shared m_vb6FormDefInstance As dlgPUManuf

		Private Shared m_InitializingDefInstance As Boolean
	End Class
End Namespace
