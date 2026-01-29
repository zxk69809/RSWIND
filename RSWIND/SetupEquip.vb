Imports System
Imports System.Collections
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
	Friend Partial Class SetupEquip
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.SetupEquip_Load
			Me.dlgPUList = New dlgPUList()
			Me.myKeyValueHT = New Hashtable()
			If SetupEquip.m_vb6FormDefInstance Is Nothing Then
				If SetupEquip.m_InitializingDefInstance Then
					SetupEquip.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							SetupEquip.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property cmdCheckData As Button
			Get
				Return Me._cmdCheckData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._cmdCheckData = value
			End Set
		End Property

		Public Overridable Property cmdPUList As Button
			Get
				Return Me._cmdPUList
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdPUList_Click
				If Me._cmdPUList IsNot Nothing Then
					RemoveHandler Me._cmdPUList.Click, value2
				End If
				Me._cmdPUList = value
				If Me._cmdPUList IsNot Nothing Then
					AddHandler Me._cmdPUList.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property lstRGEquip As ListBox
			Get
				Return Me._lstRGEquip
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Me._lstRGEquip = value
			End Set
		End Property

		Public Overridable Property panEquipList As Panel
			Get
				Return Me._panEquipList
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._panEquipList = value
			End Set
		End Property

		Public Overridable Property cmdEquipNew As Button
			Get
				Return Me._cmdEquipNew
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._cmdEquipNew = value
			End Set
		End Property

		Public Overridable Property cmdEquipModify As Button
			Get
				Return Me._cmdEquipModify
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._cmdEquipModify = value
			End Set
		End Property

		Public Overridable Property cmdEquipDelete As Button
			Get
				Return Me._cmdEquipDelete
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._cmdEquipDelete = value
			End Set
		End Property

		Public Overridable Property cboEquipList As ComboBox
			Get
				Return Me._cboEquipList
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._cboEquipList = value
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

		Public Overridable Property panContainer As Panel
			Get
				Return Me._panContainer
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._panContainer = value
			End Set
		End Property

		Public Overridable Property panPage As Panel
			Get
				Return Me._panPage
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._panPage = value
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

		Private Overridable Property dlgPUList As dlgPUList
			Get
				Return Me._dlgPUList
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dlgPUList)
				Me._dlgPUList = value
			End Set
		End Property

		Friend Overridable Property lstPUEquip As ListBox
			Get
				Return Me._lstPUEquip
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Me._lstPUEquip = value
			End Set
		End Property

		Public Shared Property DefInstance As SetupEquip
			Get
				If SetupEquip.m_vb6FormDefInstance Is Nothing OrElse SetupEquip.m_vb6FormDefInstance.IsDisposed Then
					SetupEquip.m_InitializingDefInstance = True
					SetupEquip.m_vb6FormDefInstance = New SetupEquip()
					SetupEquip.m_InitializingDefInstance = False
				End If
				Return SetupEquip.m_vb6FormDefInstance
			End Get
			Set(value As SetupEquip)
				SetupEquip.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub cmdPUList_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub SetupEquip_Load(sender As Object, e As EventArgs)
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
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter(Me.Name)
					Util.WriteControlStrings(Me, Me.ToolTip1)
					Util.CloseResourceWriter()
				End If
				Return
			End If
		End Sub

		<AccessedThroughProperty("cmdCheckData")>
		Private _cmdCheckData As Button

		<AccessedThroughProperty("cmdPUList")>
		Private _cmdPUList As Button

		<AccessedThroughProperty("lstRGEquip")>
		Private _lstRGEquip As ListBox

		<AccessedThroughProperty("panEquipList")>
		Private _panEquipList As Panel

		<AccessedThroughProperty("cmdEquipNew")>
		Private _cmdEquipNew As Button

		<AccessedThroughProperty("cmdEquipModify")>
		Private _cmdEquipModify As Button

		<AccessedThroughProperty("cmdEquipDelete")>
		Private _cmdEquipDelete As Button

		<AccessedThroughProperty("cboEquipList")>
		Private _cboEquipList As ComboBox

		<AccessedThroughProperty("_Label_0")>
		Private __Label_0 As Label

		<AccessedThroughProperty("panContainer")>
		Private _panContainer As Panel

		<AccessedThroughProperty("panPage")>
		Private _panPage As Panel

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As PanelArray

		<AccessedThroughProperty("dlgPUList")>
		Private _dlgPUList As dlgPUList

		<AccessedThroughProperty("lstPUEquip")>
		Private _lstPUEquip As ListBox

		Private Shared m_vb6FormDefInstance As SetupEquip

		Private Shared m_InitializingDefInstance As Boolean

		Private myKeyValueHT As Hashtable
	End Class
End Namespace
