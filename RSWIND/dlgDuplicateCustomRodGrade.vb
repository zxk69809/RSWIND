Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgDuplicateCustomRodGrade
		Inherits Form

		Public Property bUseFile As Boolean
			Get
				Return Me.m_bUseFile
			End Get
			Set(value As Boolean)
				Me.m_bUseFile = value
			End Set
		End Property

		Public Property bUseSetup As Boolean
			Get
				Return Me.m_bUseSetup
			End Get
			Set(value As Boolean)
				Me.m_bUseSetup = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgDuplicateCustomRodGrade_Load
			Me.m_bUseFile = False
			Me.m_bUseSetup = False
			If dlgDuplicateCustomRodGrade.m_vb6FormDefInstance Is Nothing Then
				If dlgDuplicateCustomRodGrade.m_InitializingDefInstance Then
					dlgDuplicateCustomRodGrade.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgDuplicateCustomRodGrade.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property cmdUseSetup As Button
			Get
				Return Me._cmdUseSetup
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdUseSetup_Click
				If Me._cmdUseSetup IsNot Nothing Then
					RemoveHandler Me._cmdUseSetup.Click, value2
				End If
				Me._cmdUseSetup = value
				If Me._cmdUseSetup IsNot Nothing Then
					AddHandler Me._cmdUseSetup.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdUseFile As Button
			Get
				Return Me._cmdUseFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdUseFile_Click
				If Me._cmdUseFile IsNot Nothing Then
					RemoveHandler Me._cmdUseFile.Click, value2
				End If
				Me._cmdUseFile = value
				If Me._cmdUseFile IsNot Nothing Then
					AddHandler Me._cmdUseFile.Click, value2
				End If
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

		Public Overridable Property _Label_5 As Label
			Get
				Return Me.__Label_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_5 = value
			End Set
		End Property

		Public Overridable Property _Label_4 As Label
			Get
				Return Me.__Label_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_4 = value
			End Set
		End Property

		Public Overridable Property _Label_3 As Label
			Get
				Return Me.__Label_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_3 = value
			End Set
		End Property

		Public Overridable Property _Label_2 As Label
			Get
				Return Me.__Label_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_2 = value
			End Set
		End Property

		Public Overridable Property _Label_1 As Label
			Get
				Return Me.__Label_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_1 = value
			End Set
		End Property

		Public Overridable Property _Label_0 As Label
			Get
				Return Me.__Label_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_0 = value
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

		Public Overridable Property Label As LabelArray
			Get
				Return Me._Label
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._Label = value
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

		Friend Overridable Property panRodGrade As Label
			Get
				Return Me._panRodGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._panRodGrade = value
			End Set
		End Property

		Friend Overridable Property panStressSetup As Label
			Get
				Return Me._panStressSetup
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._panStressSetup = value
			End Set
		End Property

		Friend Overridable Property panStressFile As Label
			Get
				Return Me._panStressFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._panStressFile = value
			End Set
		End Property

		Friend Overridable Property panTSFile As Label
			Get
				Return Me._panTSFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._panTSFile = value
			End Set
		End Property

		Friend Overridable Property panTSSetup As Label
			Get
				Return Me._panTSSetup
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._panTSSetup = value
			End Set
		End Property

		Public Shared Property DefInstance As dlgDuplicateCustomRodGrade
			Get
				If dlgDuplicateCustomRodGrade.m_vb6FormDefInstance Is Nothing OrElse dlgDuplicateCustomRodGrade.m_vb6FormDefInstance.IsDisposed Then
					dlgDuplicateCustomRodGrade.m_InitializingDefInstance = True
					dlgDuplicateCustomRodGrade.m_vb6FormDefInstance = New dlgDuplicateCustomRodGrade()
					dlgDuplicateCustomRodGrade.m_InitializingDefInstance = False
				End If
				Return dlgDuplicateCustomRodGrade.m_vb6FormDefInstance
			End Get
			Set(value As dlgDuplicateCustomRodGrade)
				dlgDuplicateCustomRodGrade.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub cmdUseFile_Click(eventSender As Object, eventArgs As EventArgs)
			Me.m_bUseSetup = False
			Me.m_bUseFile = True
			Me.Hide()
		End Sub

		Private Sub cmdUseSetup_Click(eventSender As Object, eventArgs As EventArgs)
			Me.m_bUseFile = False
			Me.m_bUseSetup = True
			Me.Hide()
		End Sub

		Private Sub dlgDuplicateCustomRodGrade_Load(eventSender As Object, eventArgs As EventArgs)
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
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private m_bUseFile As Boolean

		Private m_bUseSetup As Boolean

		<AccessedThroughProperty("cmdUseSetup")>
		Private _cmdUseSetup As Button

		<AccessedThroughProperty("cmdUseFile")>
		Private _cmdUseFile As Button

		<AccessedThroughProperty("_SSPanel_1")>
		Private __SSPanel_1 As Panel

		<AccessedThroughProperty("_Label_5")>
		Private __Label_5 As Label

		<AccessedThroughProperty("_Label_4")>
		Private __Label_4 As Label

		<AccessedThroughProperty("_Label_3")>
		Private __Label_3 As Label

		<AccessedThroughProperty("_Label_2")>
		Private __Label_2 As Label

		<AccessedThroughProperty("_Label_1")>
		Private __Label_1 As Label

		<AccessedThroughProperty("_Label_0")>
		Private __Label_0 As Label

		<AccessedThroughProperty("_SSPanel_0")>
		Private __SSPanel_0 As Panel

		<AccessedThroughProperty("Image")>
		Private _Image As PictureBox

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As PanelArray

		<AccessedThroughProperty("panRodGrade")>
		Private _panRodGrade As Label

		<AccessedThroughProperty("panStressSetup")>
		Private _panStressSetup As Label

		<AccessedThroughProperty("panStressFile")>
		Private _panStressFile As Label

		<AccessedThroughProperty("panTSFile")>
		Private _panTSFile As Label

		<AccessedThroughProperty("panTSSetup")>
		Private _panTSSetup As Label

		Private Shared m_vb6FormDefInstance As dlgDuplicateCustomRodGrade

		Private Shared m_InitializingDefInstance As Boolean
	End Class
End Namespace
