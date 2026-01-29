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
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgPUList
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgPUList_Load
			AddHandler MyBase.MouseMove, AddressOf Me.dlgPUList_MouseMove
			AddHandler MyBase.Resize, AddressOf Me.dlgPUList_Resize
			Me.myAL_Selected = New ArrayList()
			Me.myAL_Available = New ArrayList()
			Me.bSourceToTarget = False
			Me.bTargetToSource = False
			If dlgPUList.m_vb6FormDefInstance Is Nothing Then
				If dlgPUList.m_InitializingDefInstance Then
					dlgPUList.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgPUList.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property cmdHelp As Button
			Get
				Return Me._cmdHelp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdHelp_Click
				If Me._cmdHelp IsNot Nothing Then
					RemoveHandler Me._cmdHelp.Click, value2
				End If
				Me._cmdHelp = value
				If Me._cmdHelp IsNot Nothing Then
					AddHandler Me._cmdHelp.Click, value2
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

		Public Overridable Property Timer1 As System.Windows.Forms.Timer
			Get
				Return Me._Timer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Me._Timer1 = value
			End Set
		End Property

		Public Overridable Property lstCustomPUDB As ListBox
			Get
				Return Me._lstCustomPUDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Me._lstCustomPUDB = value
			End Set
		End Property

		Public Overridable Property cboManufMenu As ComboBox
			Get
				Return Me._cboManufMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboManufMenu_DropDown
				Dim value3 As EventHandler = AddressOf Me.cboManufMenu_SelectedIndexChanged
				Dim value4 As EventHandler = AddressOf Me.cboManufMenu_Leave
				Dim value5 As EventHandler = AddressOf Me.cboManufMenu_Enter
				If Me._cboManufMenu IsNot Nothing Then
					RemoveHandler Me._cboManufMenu.DropDown, value2
					RemoveHandler Me._cboManufMenu.SelectedIndexChanged, value3
					RemoveHandler Me._cboManufMenu.Leave, value4
					RemoveHandler Me._cboManufMenu.Enter, value5
				End If
				Me._cboManufMenu = value
				If Me._cboManufMenu IsNot Nothing Then
					AddHandler Me._cboManufMenu.DropDown, value2
					AddHandler Me._cboManufMenu.SelectedIndexChanged, value3
					AddHandler Me._cboManufMenu.Leave, value4
					AddHandler Me._cboManufMenu.Enter, value5
				End If
			End Set
		End Property

		Public Overridable Property cmdRemove As Button
			Get
				Return Me._cmdRemove
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdRemove_Click
				If Me._cmdRemove IsNot Nothing Then
					RemoveHandler Me._cmdRemove.Click, value2
				End If
				Me._cmdRemove = value
				If Me._cmdRemove IsNot Nothing Then
					AddHandler Me._cmdRemove.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdAdd As Button
			Get
				Return Me._cmdAdd
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdAdd_Click
				If Me._cmdAdd IsNot Nothing Then
					RemoveHandler Me._cmdAdd.Click, value2
				End If
				Me._cmdAdd = value
				If Me._cmdAdd IsNot Nothing Then
					AddHandler Me._cmdAdd.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property lstSelected As ListBox
			Get
				Return Me._lstSelected
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As QueryContinueDragEventHandler = AddressOf Me.lstSelected_QueryContinueDrag
				Dim value3 As GiveFeedbackEventHandler = AddressOf Me.lstSelected_GiveFeedback
				Dim value4 As MouseEventHandler = AddressOf Me.lstSelected_MouseMove
				Dim value5 As MouseEventHandler = AddressOf Me.lstSelected_MouseUp
				Dim value6 As MouseEventHandler = AddressOf Me.lstSelected_MouseDown
				Dim value7 As EventHandler = AddressOf Me.lstSelected_DragLeave
				Dim value8 As DragEventHandler = AddressOf Me.lstSelected_DragEnter
				Dim value9 As DragEventHandler = AddressOf Me.lstSelected_DragOver
				Dim value10 As DragEventHandler = AddressOf Me.lstSelected_DragDrop
				Dim value11 As EventHandler = AddressOf Me.lstSelected_DoubleClick
				Dim value12 As EventHandler = AddressOf Me.lstSelected_SelectedIndexChanged
				If Me._lstSelected IsNot Nothing Then
					RemoveHandler Me._lstSelected.QueryContinueDrag, value2
					RemoveHandler Me._lstSelected.GiveFeedback, value3
					RemoveHandler Me._lstSelected.MouseMove, value4
					RemoveHandler Me._lstSelected.MouseUp, value5
					RemoveHandler Me._lstSelected.MouseDown, value6
					RemoveHandler Me._lstSelected.DragLeave, value7
					RemoveHandler Me._lstSelected.DragEnter, value8
					RemoveHandler Me._lstSelected.DragOver, value9
					RemoveHandler Me._lstSelected.DragDrop, value10
					RemoveHandler Me._lstSelected.DoubleClick, value11
					RemoveHandler Me._lstSelected.SelectedIndexChanged, value12
				End If
				Me._lstSelected = value
				If Me._lstSelected IsNot Nothing Then
					AddHandler Me._lstSelected.QueryContinueDrag, value2
					AddHandler Me._lstSelected.GiveFeedback, value3
					AddHandler Me._lstSelected.MouseMove, value4
					AddHandler Me._lstSelected.MouseUp, value5
					AddHandler Me._lstSelected.MouseDown, value6
					AddHandler Me._lstSelected.DragLeave, value7
					AddHandler Me._lstSelected.DragEnter, value8
					AddHandler Me._lstSelected.DragOver, value9
					AddHandler Me._lstSelected.DragDrop, value10
					AddHandler Me._lstSelected.DoubleClick, value11
					AddHandler Me._lstSelected.SelectedIndexChanged, value12
				End If
			End Set
		End Property

		Public Overridable Property lstAvailable As ListBox
			Get
				Return Me._lstAvailable
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lstAvailable_DragLeave
				Dim value3 As DragEventHandler = AddressOf Me.lstAvailable_DragEnter
				Dim value4 As QueryContinueDragEventHandler = AddressOf Me.lstAvailable_QueryContinueDrag
				Dim value5 As GiveFeedbackEventHandler = AddressOf Me.lstAvailable_GiveFeedback
				Dim value6 As MouseEventHandler = AddressOf Me.lstAvailable_MouseMove
				Dim value7 As MouseEventHandler = AddressOf Me.lstAvailable_MouseUp
				Dim value8 As MouseEventHandler = AddressOf Me.lstAvailable_MouseDown
				Dim value9 As DragEventHandler = AddressOf Me.lstAvailable_DragOver
				Dim value10 As DragEventHandler = AddressOf Me.lstAvailable_DragDrop
				Dim value11 As EventHandler = AddressOf Me.lstAvailable_DoubleClick
				Dim value12 As EventHandler = AddressOf Me.lstAvailable_SelectedIndexChanged
				If Me._lstAvailable IsNot Nothing Then
					RemoveHandler Me._lstAvailable.DragLeave, value2
					RemoveHandler Me._lstAvailable.DragEnter, value3
					RemoveHandler Me._lstAvailable.QueryContinueDrag, value4
					RemoveHandler Me._lstAvailable.GiveFeedback, value5
					RemoveHandler Me._lstAvailable.MouseMove, value6
					RemoveHandler Me._lstAvailable.MouseUp, value7
					RemoveHandler Me._lstAvailable.MouseDown, value8
					RemoveHandler Me._lstAvailable.DragOver, value9
					RemoveHandler Me._lstAvailable.DragDrop, value10
					RemoveHandler Me._lstAvailable.DoubleClick, value11
					RemoveHandler Me._lstAvailable.SelectedIndexChanged, value12
				End If
				Me._lstAvailable = value
				If Me._lstAvailable IsNot Nothing Then
					AddHandler Me._lstAvailable.DragLeave, value2
					AddHandler Me._lstAvailable.DragEnter, value3
					AddHandler Me._lstAvailable.QueryContinueDrag, value4
					AddHandler Me._lstAvailable.GiveFeedback, value5
					AddHandler Me._lstAvailable.MouseMove, value6
					AddHandler Me._lstAvailable.MouseUp, value7
					AddHandler Me._lstAvailable.MouseDown, value8
					AddHandler Me._lstAvailable.DragOver, value9
					AddHandler Me._lstAvailable.DragDrop, value10
					AddHandler Me._lstAvailable.DoubleClick, value11
					AddHandler Me._lstAvailable.SelectedIndexChanged, value12
				End If
			End Set
		End Property

		Public Overridable Property _panOtherInfo_1 As Label
			Get
				Return Me.__panOtherInfo_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__panOtherInfo_1 = value
			End Set
		End Property

		Public Overridable Property _panUnitName_1 As Label
			Get
				Return Me.__panUnitName_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__panUnitName_1 = value
			End Set
		End Property

		Public Overridable Property _panOtherInfo_0 As Label
			Get
				Return Me.__panOtherInfo_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__panOtherInfo_0 = value
			End Set
		End Property

		Public Overridable Property _panUnitName_0 As Label
			Get
				Return Me.__panUnitName_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__panUnitName_0 = value
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

		Public Overridable Property _lblUnitName_1 As Label
			Get
				Return Me.__lblUnitName_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__lblUnitName_1 = value
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

		Public Overridable Property _lblUnitName_0 As Label
			Get
				Return Me.__lblUnitName_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__lblUnitName_0 = value
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

		Public Overridable Property _SSPanel_0 As Panel
			Get
				Return Me.__SSPanel_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__SSPanel_0 = value
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

		Public Overridable Property lblUnitName As LabelArray
			Get
				Return Me._lblUnitName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._lblUnitName = value
			End Set
		End Property

		Public Overridable Property panOtherInfo As LabelArray
			Get
				Return Me._panOtherInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._panOtherInfo = value
			End Set
		End Property

		Public Overridable Property panUnitName As LabelArray
			Get
				Return Me._panUnitName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._panUnitName = value
			End Set
		End Property

		Friend Overridable Property HelpProvider1 As HelpProvider
			Get
				Return Me._HelpProvider1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As HelpProvider)
				Me._HelpProvider1 = value
			End Set
		End Property

		Public Shared Property DefInstance As dlgPUList
			Get
				If dlgPUList.m_vb6FormDefInstance Is Nothing OrElse dlgPUList.m_vb6FormDefInstance.IsDisposed Then
					dlgPUList.m_InitializingDefInstance = True
					dlgPUList.m_vb6FormDefInstance = New dlgPUList()
					dlgPUList.m_InitializingDefInstance = False
				End If
				Return dlgPUList.m_vb6FormDefInstance
			End Get
			Set(value As dlgPUList)
				dlgPUList.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub BeginDragMode(ByRef ctl As Control, wObjType As Short)
		End Sub

		Private Sub cboManufMenu_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(Me.cboManufMenu.SelectedIndex)
			If num >= 0S Then
				Dim showNames As Short = Me.UnitTypeInfoList(CInt((num + 1S))).ShowNames
				Dim text As String = Strings.Trim(Me.UnitTypeInfoList(CInt((num + 1S))).Abbrev)
				If Operators.ConditionalCompareObjectNotEqual(text, Me.cboManufMenu.Tag, False) Then
					Dim text2 As String
					Me.StoreUnitList(Me.$STATIC$cboManufMenu_SelectedIndexChanged$20211C1241$iPrevIndex, text2)
					Me.lblUnitName(0S).Text = Conversions.ToString(Interaction.IIf(showNames <> 0S, "API:", "Name:"))
					Me.panUnitName(0S).Text = RSWIN_DESC.sNull
					Me.panOtherInfo(0S).Text = RSWIN_DESC.sNull
					Me.lblUnitName(1S).Text = Me.lblUnitName(0S).Text
					Me.panUnitName(1S).Text = RSWIN_DESC.sNull
					Me.panOtherInfo(1S).Text = RSWIN_DESC.sNull
					Me.LoadUnitMenu(text, False)
					Me.cboManufMenu.Tag = text
					Me.$STATIC$cboManufMenu_SelectedIndexChanged$20211C1241$iPrevIndex = num
				End If
			End If
		End Sub

		Private Sub cboManufMenu_DragDrop(ByRef Source As Control, ByRef X As Single, ByRef Y As Single)
			Dim num As Short = Me.EndDragMode(0S)
		End Sub

		Private Sub cboManufMenu_DragOver(ByRef Source As Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
			Dim num As Short = Me.DragValid(Source, 0S, State)
		End Sub

		Private Sub cboManufMenu_DropDown(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub cboManufMenu_Enter(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub cboManufMenu_Leave(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub CheckButtons()
			If Not Me.bDragging <> 0S Then
				Dim num As Short = If((-If((Me.lstAvailable.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S)
				Dim num2 As Short = If((-If((Me.lstSelected.SelectedIndex >= 0 > False), 1S, 0S)), 1S, 0S)
				Me.cmdAdd.Enabled = (num <> 0S)
				Me.cmdRemove.Enabled = (num2 <> 0S)
			End If
		End Sub

		Private Sub cmdAdd_Click(eventSender As Object, eventArgs As EventArgs)
			Dim num As Short
			Dim num3 As Short
			Dim num4 As Short
			Dim index As Short = CShort(Me.lstAvailable.SelectedIndex)
			num = CShort(Support.GetItemData(Me.lstAvailable, CInt(index)))
			Dim num2 As Short = 0S
			num3 = CShort((Me.lstSelected.Items.Count - 1))
			num4 = num2
			While num4 <= num3 AndAlso CInt(num) >= Support.GetItemData(Me.lstSelected, CInt(num4))
				num4 += 1S
			End While
			Dim lstAvailable As ListBox = Me.lstAvailable
			Dim iSrcIndex As Object = Me.lstAvailable.SelectedIndex
			Dim lstSelected As ListBox = Me.lstSelected
			Me.MoveItem(lstAvailable, iSrcIndex, lstSelected, num4, True)
			Me.lstSelected = lstSelected
			Me.lstAvailable = lstAvailable
			Me.lstAvailable.SelectedIndex = -1
		End Sub

		Private Sub cmdAdd_DragDrop(ByRef Source As Control, ByRef X As Single, ByRef Y As Single)
			Dim num As Short = Me.EndDragMode(0S)
		End Sub

		Private Sub cmdAdd_DragOver(ByRef Source As Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
			Dim num As Short = Me.DragValid(Source, 0S, State)
		End Sub

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			Me.Close()
		End Sub

		Private Sub cmdCancel_DragDrop(ByRef Source As Control, ByRef X As Single, ByRef Y As Single)
			Dim num As Short = Me.EndDragMode(0S)
		End Sub

		Private Sub cmdCancel_DragOver(ByRef Source As Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
			Dim num As Short = Me.DragValid(Source, 0S, State)
		End Sub

		Private Sub cmdOK_Click(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				If Me.cboManufMenu.SelectedIndex <> -1 Then
					Dim text As String
					Me.StoreUnitList(Me.cboManufMenu.SelectedIndex, text)
					Dim num As Integer = 0
					Dim num2 As Integer = Me.lstCustomPUDB.Items.Count - 1
					For i As Integer = num To num2
						Dim text2 As String
						Try
							text2 = Strings.Trim(Me.UnitTypeInfoList(i + 1).Abbrev)
						Catch ex As Exception
							text2 = ""
						End Try
						If Operators.CompareString(text2, "", False) <> 0 Then
							Try
								text = Support.GetItemString(Me.lstCustomPUDB, i)
							Catch ex2 As Exception
								text = ""
							End Try
							Dim text3 As String
							Dim num3 As Integer
							Dim length As Integer
							If text.Trim().Length = 0 Or Operators.CompareString(text.Trim(), "", False) = 0 Then
								Try
									num3 = Custom.CustomPumpingUnitLists_SelectRow(text2.Trim(), text3, False, "")
									length = text.Trim().Length
									If length = 0 And num3 <> 0 Then
										Custom.CustomPumpingUnitLists_DeleteDBRow(text2.Trim())
									End If
									GoTo IL_180
								Catch ex3 As Exception
									GoTo IL_180
								End Try
							End If
							num3 = Custom.CustomPumpingUnitLists_SelectRow(text2.Trim(), text3, False, "")
							length = text.Trim().Length
							If length > 0 Then
								If num3 <> 0 Then
									Custom.CustomPumpingUnitLists_DBUpdateRow(text2.Trim(), text.Trim(), False, "")
								Else
									Custom.CustomPumpingUnitLists_DBAddRow(text2.Trim(), text.Trim(), False, "")
								End If
							End If
						End If
						IL_180:
					Next
				End If
			Catch ex4 As Exception
			End Try
			Me.Close()
		End Sub

		Private Sub cmdOK_DragDrop(ByRef Source As Control, ByRef X As Single, ByRef Y As Single)
			Dim num As Short = Me.EndDragMode(0S)
		End Sub

		Private Sub cmdOK_DragOver(ByRef Source As Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
			Dim num As Short = Me.DragValid(Source, 0S, State)
		End Sub

		Private Sub cmdRemove_Click(eventSender As Object, eventArgs As EventArgs)
			Dim num As Short
			Dim num3 As Short
			Dim num4 As Short
			Dim index As Short = CShort(Me.lstSelected.SelectedIndex)
			num = CShort(Support.GetItemData(Me.lstSelected, CInt(index)))
			Dim num2 As Short = 0S
			num3 = CShort((Me.lstAvailable.Items.Count - 1))
			num4 = num2
			While num4 <= num3 AndAlso CInt(num) >= Support.GetItemData(Me.lstAvailable, CInt(num4))
				num4 += 1S
			End While
			Dim lstSelected As ListBox = Me.lstSelected
			Dim iSrcIndex As Object = Me.lstSelected.SelectedIndex
			Dim lstAvailable As ListBox = Me.lstAvailable
			Me.MoveItem(lstSelected, iSrcIndex, lstAvailable, num4, True)
			Me.lstAvailable = lstAvailable
			Me.lstSelected = lstSelected
			Me.lstSelected.SelectedIndex = -1
		End Sub

		Private Sub cmdRemove_DragDrop(ByRef Source As Control, ByRef X As Single, ByRef Y As Single)
			Dim num As Short = Me.EndDragMode(0S)
		End Sub

		Private Sub cmdRemove_DragOver(ByRef Source As Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
			Dim num As Short = Me.DragValid(Source, 0S, State)
		End Sub

		Private Function DragValid(ByRef src As Control, wMask As Short, iState As Short) As Short
			Dim result As Short
			Return result
		End Function

		Private Function EndDragMode(wMask As Short) As Short
			Dim num As Short = If((-If((Me.Timer1.Enabled > False), 1S, 0S)), 1S, 0S)
			Me.Timer1.Enabled = False
			Dim result As Short
			If num <> 0S Then
				result = -1S
			Else
				Me.bDragging = 0S
				result = If((-If((((wMask And Me.wDragType) <> 0S) > False), 1S, 0S)), 1S, 0S)
			End If
			Return result
		End Function

		Private Sub Form_DragDrop(ByRef Source As Control, ByRef X As Single, ByRef Y As Single)
			Dim num As Short = Me.EndDragMode(0S)
		End Sub

		Private Sub Form_DragOver(ByRef Source As Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
			Dim num As Short = Me.DragValid(Source, 0S, State)
		End Sub

		Private Sub dlgPUList_Load(eventSender As Object, eventArgs As EventArgs)
			Try
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
				Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
				Me.LoadManufMenu()
				Util.UnbusyCursor()
				Try
					Me.Icon = RSWIN_DESC.frmMain.Icon
				Catch ex As Exception
				End Try
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter(Me.Name)
					Util.WriteControlStrings(Me, Me.ToolTip1)
					Util.CloseResourceWriter()
				End If
			Catch ex2 As Exception
				Dim sMsg As String = "Error in Load dlgPUList: " + ex2.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub dlgPUList_MouseMove(eventSender As Object, eventArgs As MouseEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort((eventArgs.Button / MouseButtons.Left))
			Dim num2 As Short = CShort((Control.ModifierKeys / Keys.Shift))
			Dim num3 As Single = CSng(eventArgs.X)
			Dim num4 As Single = CSng(eventArgs.Y)
			If Me.bDragging <> 0S AndAlso (num And 1S) = 0S Then
				Dim num5 As Short = Me.EndDragMode(0S)
			End If
		End Sub

		Private Sub Label_DragDrop(ByRef Index As Short, ByRef Source As Control, ByRef X As Single, ByRef Y As Single)
			Dim num As Short = Me.EndDragMode(0S)
		End Sub

		Private Sub Label_DragOver(ByRef Index As Short, ByRef Source As Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
			Dim num As Short = Me.DragValid(Source, 0S, State)
		End Sub

		Private Sub lblUnitName_DragOver(ByRef Index As Short, ByRef Source As Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
			Dim num As Short = Me.DragValid(Source, 0S, State)
		End Sub

		Private Sub LoadManufMenu()
			Dim expression As String = ""
			Dim fileName As String = ""
			Try
				FILEUTIL.LocateFile("UNITINFO32.PUD", fileName, 2S, False, False, False, False)
				Dim num As Short
				Dim unitTypeInfo As RSWIN_DESC.UnitTypeInfo
				Dim text As String
				Dim num3 As Short
				Dim num4 As Short
				num = CShort(FileSystem.FreeFile())
				FileSystem.FileOpen(CInt(num), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
				Dim num2 As Short = CShort((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(unitTypeInfo))))
				Me.UnitTypeInfoList = New RSWIN_DESC.UnitTypeInfo(0) {}
				Me.nUnitTypes = 0S
				text = Strings.Space(16384)
				num3 = 1S
				num4 = num2
				For num5 As Short = num3 To num4
					Dim fileNumber As Integer = CInt(num)
					Dim valueType As ValueType = unitTypeInfo
					FileSystem.FileGet(fileNumber, valueType, -1L)
					Dim valueType2 As ValueType = valueType
					Dim unitTypeInfo2 As RSWIN_DESC.UnitTypeInfo
					unitTypeInfo = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.UnitTypeInfo), unitTypeInfo2)
					FILEUTIL.LocateFile(Strings.RTrim(unitTypeInfo.Abbrev) + "32.PUD", expression, 0S, False, False, False, False)
					If Strings.Len(expression) > 0 Then
						If Me.nUnitTypes = 0S Then
							Me.UnitTypeInfoList = New RSWIN_DESC.UnitTypeInfo(1) {}
						Else
							Me.UnitTypeInfoList = CType(Utils.CopyArray(CType(Me.UnitTypeInfoList, Array), New RSWIN_DESC.UnitTypeInfo(CInt((1S + Me.nUnitTypes + 1S)) - 1) {}), RSWIN_DESC.UnitTypeInfo())
						End If
						Me.nUnitTypes += 1S
						Me.UnitTypeInfoList(CInt(Me.nUnitTypes)) = unitTypeInfo
						Me.cboManufMenu.Items.Add(Me.UnitTypeInfoList(CInt(Me.nUnitTypes)).Manuf)
						Dim num6 As Integer = Custom.CustomPumpingUnitLists_SelectRow(unitTypeInfo.Abbrev, text, False, "")
						Dim num7 As Short = CShort(text.Trim().Length)
						If num6 = 0 Then
							Me.lstCustomPUDB.Items.Add(RSWIN_DESC.sNull)
						Else
							Me.lstCustomPUDB.Items.Add(text)
						End If
					End If
				Next
				FileSystem.FileClose(New Integer() { CInt(num) })
				Me.cboManufMenu.Tag = RSWIN_DESC.sNull
			Catch ex As Exception
				Dim sMsg As String = "Error in LoadManuMenu: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub LoadUnitMenu(sPUType As String, bShow As Object)
			Dim fileName As String = ""
			Try
				FILEUTIL.LocateFile(sPUType + "32.PUD", fileName, 2S, False, False, False, False)
				Dim num As Short
				Dim num2 As Short
				Dim num3 As Short
				num = CShort(FileSystem.FreeFile())
				Me.UnitData = New RSWIN_DESC.PUDataRec(10) {}
				FileSystem.FileOpen(CInt(num), fileName, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(Me.UnitData(0)))
				Me.nUnits = CShort((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(Me.UnitData(0)))))
				Me.UnitData = New RSWIN_DESC.PUDataRec(CInt((Me.nUnits + 1S)) - 1) {}
				Me.uIdx = New Object(CInt((Me.nUnits + 1S)) - 1) {}
				num2 = 1S
				num3 = Me.nUnits
				For num4 As Short = num2 To num3
					Dim fileNumber As Integer = CInt(num)
					Dim unitData As RSWIN_DESC.PUDataRec() = Me.UnitData
					Dim num5 As Integer = CInt(num4)
					Dim valueType As ValueType = unitData(num5)
					FileSystem.FileGet(fileNumber, valueType, CLng(num4))
					Dim unitData2 As RSWIN_DESC.PUDataRec() = Me.UnitData
					Dim num6 As Integer = num5
					Dim valueType2 As ValueType = valueType
					Dim pudataRec As RSWIN_DESC.PUDataRec
					unitData2(num6) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
				Next
				FileSystem.FileClose(New Integer() { CInt(num) })
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.IIf(Me.UnitTypeInfoList(Me.cboManufMenu.SelectedIndex + 1).SortByNames <> 0S, 0, 1))
				PUDATA1.OSortPUnits(Me.UnitData, Me.uIdx, objectValue)
				Dim num7 As Short = 1S
				Dim num8 As Short = Me.nUnits
				For num4 As Short = num7 To num8
					Me.UnitData(CInt(num4)).FileRecord = 0S
				Next
				Dim itemString As String = Support.GetItemString(Me.lstCustomPUDB, Me.cboManufMenu.SelectedIndex)
				Dim showNames As Short
				Dim num11 As Short
				Dim num12 As Short
				If Strings.Len(itemString) > 0 Then
					Dim num4 As Short = 1S
					Dim num10 As Short
					Do
						Dim num9 As Short = -1S
						num10 = CShort(Strings.InStr(CInt(num4), itemString, ",", CompareMethod.Binary))

							If num10 = 0S Then
								If Versioned.IsNumeric(Strings.Mid(itemString, CInt(num4))) Then
									num9 = Conversions.ToShort(Strings.Mid(itemString, CInt(num4)))
								End If
							ElseIf Versioned.IsNumeric(Strings.Mid(itemString, CInt(num4), CInt((num10 - num4)))) Then
								num9 = Conversions.ToShort(Strings.Mid(itemString, CInt(num4), CInt((num10 - num4))))
							End If
							If num9 > 0S And num9 <= Me.nUnits Then
								Me.UnitData(CInt(num9)).FileRecord = 1S
							End If

						num4 = CShort((CInt(num10) + Strings.Len(",")))
					Loop While num10 <> 0S
				End If
				Me.lstSelected.Visible = False
				Me.lstSelected.Items.Clear()
				Me.lstAvailable.Visible = False
				Me.lstAvailable.Items.Clear()
				showNames = Me.UnitTypeInfoList(Me.cboManufMenu.SelectedIndex + 1).ShowNames
				num11 = 1S
				num12 = Me.nUnits
				For num4 As Short = num11 To num12
					Try
						Dim text As String
						If showNames <> 0S Then
							text = Me.UnitData(Conversions.ToInteger(Me.uIdx(CInt(num4)))).UnitName
						Else
							text = Me.UnitData(Conversions.ToInteger(Me.uIdx(CInt(num4)))).APIDesignation
						End If
						If Not Information.IsDBNull(text) And text <> Nothing Then
							If Me.UnitData(Conversions.ToInteger(Me.uIdx(CInt(num4)))).FileRecord <> 0S Then
								Me.lstSelected.Items.Add(New ListBoxItem(Strings.Trim(text), CInt(num4)))
							Else
								Me.lstAvailable.Items.Add(New ListBoxItem(text, CInt(num4)))
							End If
						End If
					Catch ex As Exception
					End Try
				Next
				Me.lstSelected.Visible = True
				Me.lstAvailable.Visible = True
			Catch ex2 As Exception
				Dim sMsg As String = "Error in LoadUnitMenu: " + ex2.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub lstAvailable_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			Me._panUnitName_1.Text = ""
			Me._panOtherInfo_1.Text = ""
			Me.CheckButtons()
			Dim showNames As Short = Me.UnitTypeInfoList(Me.cboManufMenu.SelectedIndex + 1).ShowNames
			Dim num As Short = CShort(Me.lstAvailable.SelectedIndex)
			If num < 0S Then
				Me.panUnitName(1S).Text = RSWIN_DESC.sNull
				Me.panOtherInfo(1S).Text = RSWIN_DESC.sNull
			Else
				Dim num2 As Short = Conversions.ToShort(Me.uIdx(Support.GetItemData(Me.lstAvailable, CInt(num))))
				Me.panUnitName(1S).Text = Conversions.ToString(Interaction.IIf(showNames <> 0S, Me.UnitData(CInt(num2)).APIDesignation, Me.UnitData(CInt(num2)).UnitName))
				Me.panOtherInfo(1S).Text = Me.UnitData(CInt(num2)).OtherInfo
			End If
		End Sub

		Private Sub lstAvailable_DoubleClick(eventSender As Object, eventArgs As EventArgs)
			Me.cmdAdd_Click(Me.cmdAdd, New EventArgs())
		End Sub

		Private Sub lstAvailable_DragDrop(ByRef Source As Control, ByRef X As Single, ByRef Y As Single)
			If Me.EndDragMode(2S) <> 0S Then
				Me.cmdRemove_Click(Me.cmdRemove, New EventArgs())
			End If
		End Sub

		Private Sub lstAvailable_DragOver(ByRef Source As Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
			Dim num As Short = Me.DragValid(Source, 3S, State)
		End Sub

		Private Sub lstSelected_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			Me._panUnitName_0.Text = ""
			Me._panOtherInfo_0.Text = ""
			Me.CheckButtons()
			Dim showNames As Short = Me.UnitTypeInfoList(Me.cboManufMenu.SelectedIndex + 1).ShowNames
			Dim num As Short = CShort(Me.lstSelected.SelectedIndex)
			If num < 0S Then
				Me.panUnitName(0S).Text = RSWIN_DESC.sNull
				Me.panOtherInfo(0S).Text = RSWIN_DESC.sNull
			Else
				Dim num2 As Short = Conversions.ToShort(Me.uIdx(Support.GetItemData(Me.lstSelected, CInt(num))))
				Me.panUnitName(0S).Text = Conversions.ToString(Interaction.IIf(showNames <> 0S, Me.UnitData(CInt(num2)).APIDesignation, Me.UnitData(CInt(num2)).UnitName))
				Me.panOtherInfo(0S).Text = Me.UnitData(CInt(num2)).OtherInfo
			End If
		End Sub

		Private Sub lstSelected_DoubleClick(eventSender As Object, eventArgs As EventArgs)
			Me.cmdRemove_Click(Me.cmdRemove, New EventArgs())
		End Sub

		Private Sub lstSelected_DragDrop(ByRef Source As Control, ByRef X As Single, ByRef Y As Single)
			If Me.EndDragMode(1S) <> 0S Then
				Me.cmdAdd_Click(Me.cmdAdd, New EventArgs())
			End If
		End Sub

		Private Sub MoveItem(ByRef lstSrc As ListBox, iSrcIndex As Object, ByRef lstDest As ListBox, iDestIndex As Object, bSetListIndex As Object)
			Dim itemString As String = Support.GetItemString(lstSrc, Conversions.ToInteger(iSrcIndex))
			Dim itemData As Integer = Support.GetItemData(lstSrc, Conversions.ToInteger(iSrcIndex))
			lstSrc.Items.RemoveAt(Conversions.ToInteger(iSrcIndex))
			Dim num As Short
			If Operators.ConditionalCompareObjectLess(iDestIndex, 0, False) Then
				lstDest.Items.Add(itemString)
				num = CShort((lstDest.Items.Count - 1))
			Else
				lstDest.Items.Insert(Conversions.ToInteger(iDestIndex), itemString)
				num = Conversions.ToShort(iDestIndex)
			End If
			Try
				Support.SetItemData(lstDest, CInt(num), itemData)
			Catch ex As Exception
			End Try
			If Conversions.ToBoolean(bSetListIndex) Then
				lstDest.SelectedIndex = CInt(num)
			End If
		End Sub

		Private Sub panOtherInfo_DragDrop(ByRef Index As Short, ByRef Source As Control, ByRef X As Single, ByRef Y As Single)
			Dim num As Short = Me.EndDragMode(0S)
		End Sub

		Private Sub panOtherInfo_DragOver(ByRef Index As Short, ByRef Source As Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
			Dim num As Short = Me.DragValid(Source, 0S, State)
		End Sub

		Private Sub panUnitName_DragDrop(ByRef Index As Short, ByRef Source As Control, ByRef X As Single, ByRef Y As Single)
			Dim num As Short = Me.EndDragMode(0S)
		End Sub

		Private Sub panUnitName_DragOver(ByRef Index As Short, ByRef Source As Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
			Dim num As Short = Me.DragValid(Source, 0S, State)
		End Sub

		Private Sub SSPanel_DragDrop(ByRef Index As Short, ByRef Source As Control, ByRef X As Single, ByRef Y As Single)
			Dim num As Short = Me.EndDragMode(0S)
		End Sub

		Private Sub SSPanel_DragOver(ByRef Index As Short, ByRef Source As Control, ByRef X As Single, ByRef Y As Single, ByRef State As Short)
			Dim num As Short = Me.DragValid(Source, 0S, State)
		End Sub

		Private Sub StoreUnitList(iListIndex As Object, ByRef sUnitList As String)
			sUnitList = ""
			If Strings.Len(RuntimeHelpers.GetObjectValue(Me.cboManufMenu.Tag)) > 0 Then
				sUnitList = RSWIN_DESC.sNull
				If Me.lstSelected.Items.Count > 0 Then
					Dim num As Short = 0S
					Dim num2 As Short = CShort((Me.lstSelected.Items.Count - 1))
					For num3 As Short = num To num2
						sUnitList = sUnitList + "," + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.uIdx(Support.GetItemData(Me.lstSelected, CInt(num3)))))
					Next
					sUnitList = Strings.Mid(sUnitList, 2)
				End If
				Support.SetItemString(Me.lstCustomPUDB, Conversions.ToInteger(iListIndex), sUnitList)
				Return
			End If
		End Sub

		Private Sub lstAvailable_MouseDown(sender As Object, e As MouseEventArgs)
			Me.bSourceToTarget = True
			Me.bTargetToSource = False
			Me.indexOfItemUnderMouseToDrag = Me.lstAvailable.IndexFromPoint(e.X, e.Y)
			If Me.indexOfItemUnderMouseToDrag <> -1 Then
				Dim dragSize As Size = SystemInformation.DragSize
				Dim location As Point = New Point(CInt(Math.Round(CDbl(e.X) - CDbl(dragSize.Width) / 2.0)), CInt(Math.Round(CDbl(e.Y) - CDbl(dragSize.Height) / 2.0)))
				Me.dragBoxFromMouseDown = New Rectangle(location, dragSize)
			Else
				Me.dragBoxFromMouseDown = Rectangle.Empty
			End If
		End Sub

		Private Sub lstAvailable_MouseUp(sender As Object, e As MouseEventArgs)
			Me.dragBoxFromMouseDown = Rectangle.Empty
		End Sub

		Private Sub lstAvailable_MouseMove(sender As Object, e As MouseEventArgs)
			If((e.Button And MouseButtons.Left) = MouseButtons.Left And Me.bSourceToTarget) AndAlso (Me.dragBoxFromMouseDown <> Rectangle.Empty And Not Me.dragBoxFromMouseDown.Contains(e.X, e.Y)) Then
				Try
					Me.MyNormalCursor = Cursors.Arrow
					Me.MyNoDropCursor = Cursors.NoMove2D
				Catch ex As Exception
				Finally
					Me.screenOffset = SystemInformation.WorkingArea.Location
					Dim dragDropEffects As DragDropEffects = Me.lstAvailable.DoDragDrop(RuntimeHelpers.GetObjectValue(Me.lstAvailable.Items(Me.indexOfItemUnderMouseToDrag)), DragDropEffects.Copy Or DragDropEffects.Move Or DragDropEffects.Link Or DragDropEffects.Scroll)
					If dragDropEffects = DragDropEffects.Move Then
						If Me.indexOfItemUnderMouseToDrag > 0 Then
							' The following expression was wrapped in a checked-expression
							Me.lstAvailable.SelectedIndex = Me.indexOfItemUnderMouseToDrag - 1
						ElseIf Me.lstAvailable.Items.Count > 0 Then
							Me.lstAvailable.SelectedIndex = 0
						End If
					End If
					If Me.MyNormalCursor IsNot Nothing Then
						Me.MyNormalCursor.Dispose()
					End If
					If Me.MyNoDropCursor IsNot Nothing Then
						Me.MyNoDropCursor.Dispose()
					End If
				End Try
			End If
		End Sub

		Private Sub lstAvailable_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs)
			If Me.bSourceToTarget Then
				e.UseDefaultCursors = True
				If(e.Effect And DragDropEffects.Move) = DragDropEffects.Move Then
					Cursor.Current = Me.MyNormalCursor
				Else
					Cursor.Current = Me.MyNoDropCursor
				End If
			End If
		End Sub

		Private Sub lstSelected_DragOver(sender As Object, e As DragEventArgs)
			If Me.bSourceToTarget Then
				e.Effect = DragDropEffects.Copy
			ElseIf Me.bTargetToSource Then
				e.Effect = DragDropEffects.Move
			End If
			If(e.KeyState And 40) = 40 And (e.AllowedEffect And DragDropEffects.Link) = DragDropEffects.Link Then
				e.Effect = DragDropEffects.Link
			ElseIf(e.KeyState And 32) = 32 And (e.AllowedEffect And DragDropEffects.Link) = DragDropEffects.Link Then
				e.Effect = DragDropEffects.Link
			ElseIf(e.KeyState And 4) = 4 And (e.AllowedEffect And DragDropEffects.Move) = DragDropEffects.Move Then
				e.Effect = DragDropEffects.Move
			ElseIf(e.KeyState And 8) = 8 And (e.AllowedEffect And DragDropEffects.Copy) = DragDropEffects.Copy Then
				e.Effect = DragDropEffects.Copy
			ElseIf(e.AllowedEffect And DragDropEffects.Move) = DragDropEffects.Move Then
				e.Effect = DragDropEffects.Move
			Else
				e.Effect = DragDropEffects.None
			End If
			Dim lstSelected As ListBox = Me.lstSelected
			Dim lstSelected2 As Control = Me.lstSelected
			Dim p As Point = New Point(e.X, e.Y)
			Me.indexOfItemUnderMouseToDrop = lstSelected.IndexFromPoint(lstSelected2.PointToClient(p))
			If Me.indexOfItemUnderMouseToDrop = -1 Then
			End If
		End Sub

		Private Sub lstSelected_DragDrop(sender As Object, e As DragEventArgs)
			If Me.bSourceToTarget Then
				Dim num As Integer
				If Me.indexOfItemUnderMouseToDrop <> -1 Then
					num = Me.indexOfItemUnderMouseToDrop
				Else
					num = -1
				End If
				Dim lstAvailable As ListBox = Me.lstAvailable
				Dim iSrcIndex As Object = Me.lstAvailable.SelectedIndex
				Dim lstSelected As ListBox = Me.lstSelected
				Me.MoveItem(lstAvailable, iSrcIndex, lstSelected, num, True)
				Me.lstSelected = lstSelected
				Me.lstAvailable = lstAvailable
				Me.lstAvailable.SelectedIndex = -1
				Cursor.Current = Cursors.[Default]
				Me.bSourceToTarget = False
			End If
		End Sub

		Private Sub lstAvailable_QueryContinueDrag(sender As Object, e As QueryContinueDragEventArgs)
			Dim listBox As ListBox = CType(sender, ListBox)
			If listBox IsNot Nothing Then
				Dim form As Form = listBox.FindForm()
				If Control.MousePosition.X - Me.screenOffset.X < form.DesktopBounds.Left Or Control.MousePosition.X - Me.screenOffset.X > form.DesktopBounds.Right Or Control.MousePosition.Y - Me.screenOffset.Y < form.DesktopBounds.Top Or Control.MousePosition.Y - Me.screenOffset.Y > form.DesktopBounds.Bottom Then
					e.Action = DragAction.Cancel
				End If
			End If
		End Sub

		Private Sub lstSelected_DragEnter(sender As Object, e As DragEventArgs)
		End Sub

		Private Sub lstSelected_DragLeave(sender As Object, e As EventArgs)
		End Sub

		Private Sub lstSelected_MouseDown(sender As Object, e As MouseEventArgs)
			Me.bTargetToSource = True
			Me.bSourceToTarget = False
			Me.indexOfItemUnderMouseToDrag = Me.lstSelected.IndexFromPoint(e.X, e.Y)
			If Me.indexOfItemUnderMouseToDrag <> -1 Then
				Dim dragSize As Size = SystemInformation.DragSize
				Dim location As Point = New Point(CInt(Math.Round(CDbl(e.X) - CDbl(dragSize.Width) / 2.0)), CInt(Math.Round(CDbl(e.Y) - CDbl(dragSize.Height) / 2.0)))
				Me.dragBoxFromMouseDown = New Rectangle(location, dragSize)
			Else
				Me.dragBoxFromMouseDown = Rectangle.Empty
			End If
		End Sub

		Private Sub lstSelected_MouseUp(sender As Object, e As MouseEventArgs)
			Me.dragBoxFromMouseDown = Rectangle.Empty
		End Sub

		Private Sub lstSelected_MouseMove(sender As Object, e As MouseEventArgs)
			If((e.Button And MouseButtons.Left) = MouseButtons.Left And Me.bTargetToSource) AndAlso (Me.dragBoxFromMouseDown <> Rectangle.Empty And Not Me.dragBoxFromMouseDown.Contains(e.X, e.Y)) Then
				Try
					Me.MyNormalCursor = Cursors.Arrow
					Me.MyNoDropCursor = Cursors.NoMove2D
				Catch ex As Exception
				Finally
					Me.screenOffset = SystemInformation.WorkingArea.Location
					Dim dragDropEffects As DragDropEffects = Me.lstSelected.DoDragDrop(RuntimeHelpers.GetObjectValue(Me.lstSelected.Items(Me.indexOfItemUnderMouseToDrag)), DragDropEffects.Copy Or DragDropEffects.Move Or DragDropEffects.Link Or DragDropEffects.Scroll)
					If dragDropEffects = DragDropEffects.Move Then
						If Me.indexOfItemUnderMouseToDrag > 0 Then
							' The following expression was wrapped in a checked-expression
							Me.lstSelected.SelectedIndex = Me.indexOfItemUnderMouseToDrag - 1
						ElseIf Me.lstSelected.Items.Count > 0 Then
							Me.lstSelected.SelectedIndex = 0
						End If
					End If
					If Me.MyNormalCursor IsNot Nothing Then
						Me.MyNormalCursor.Dispose()
					End If
					If Me.MyNoDropCursor IsNot Nothing Then
						Me.MyNoDropCursor.Dispose()
					End If
				End Try
			End If
		End Sub

		Private Sub lstSelected_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs)
			If Me.bTargetToSource Then
				e.UseDefaultCursors = True
				If(e.Effect And DragDropEffects.Move) = DragDropEffects.Move Then
					Cursor.Current = Me.MyNormalCursor
				Else
					Cursor.Current = Me.MyNoDropCursor
				End If
			End If
		End Sub

		Private Sub lstAvailable_DragOver(sender As Object, e As DragEventArgs)
			If Me.bTargetToSource Then
				e.Effect = DragDropEffects.Copy
			ElseIf Me.bSourceToTarget Then
				e.Effect = DragDropEffects.Move
			End If
			If(e.KeyState And 40) = 40 And (e.AllowedEffect And DragDropEffects.Link) = DragDropEffects.Link Then
				e.Effect = DragDropEffects.Link
			ElseIf(e.KeyState And 32) = 32 And (e.AllowedEffect And DragDropEffects.Link) = DragDropEffects.Link Then
				e.Effect = DragDropEffects.Link
			ElseIf(e.KeyState And 4) = 4 And (e.AllowedEffect And DragDropEffects.Move) = DragDropEffects.Move Then
				e.Effect = DragDropEffects.Move
			ElseIf(e.KeyState And 8) = 8 And (e.AllowedEffect And DragDropEffects.Copy) = DragDropEffects.Copy Then
				e.Effect = DragDropEffects.Copy
			ElseIf(e.AllowedEffect And DragDropEffects.Move) = DragDropEffects.Move Then
				e.Effect = DragDropEffects.Move
			Else
				e.Effect = DragDropEffects.None
			End If
			Dim lstAvailable As ListBox = Me.lstAvailable
			Dim lstAvailable2 As Control = Me.lstAvailable
			Dim p As Point = New Point(e.X, e.Y)
			Me.indexOfItemUnderMouseToDrop = lstAvailable.IndexFromPoint(lstAvailable2.PointToClient(p))
			If Me.indexOfItemUnderMouseToDrop = -1 Then
			End If
		End Sub

		Private Sub lstAvailable_DragDrop(sender As Object, e As DragEventArgs)
			If Me.bTargetToSource Then
				Dim num As Integer
				If Me.indexOfItemUnderMouseToDrop <> -1 Then
					num = Me.indexOfItemUnderMouseToDrop
				Else
					num = -1
				End If
				Dim lstSelected As ListBox = Me.lstSelected
				Dim iSrcIndex As Object = Me.lstSelected.SelectedIndex
				Dim lstAvailable As ListBox = Me.lstAvailable
				Me.MoveItem(lstSelected, iSrcIndex, lstAvailable, num, True)
				Me.lstAvailable = lstAvailable
				Me.lstSelected = lstSelected
				Me.lstSelected.SelectedIndex = -1
				Cursor.Current = Cursors.[Default]
				Me.bTargetToSource = False
			End If
		End Sub

		Private Sub lstSelected_QueryContinueDrag(sender As Object, e As QueryContinueDragEventArgs)
			Dim listBox As ListBox = CType(sender, ListBox)
			If listBox IsNot Nothing Then
				Dim form As Form = listBox.FindForm()
				If Control.MousePosition.X - Me.screenOffset.X < form.DesktopBounds.Left Or Control.MousePosition.X - Me.screenOffset.X > form.DesktopBounds.Right Or Control.MousePosition.Y - Me.screenOffset.Y < form.DesktopBounds.Top Or Control.MousePosition.Y - Me.screenOffset.Y > form.DesktopBounds.Bottom Then
					e.Action = DragAction.Cancel
				End If
			End If
		End Sub

		Private Sub lstAvailable_DragEnter(sender As Object, e As DragEventArgs)
		End Sub

		Private Sub lstAvailable_DragLeave(sender As Object, e As EventArgs)
		End Sub

		Private Sub cmdHelp_Click(sender As Object, e As EventArgs)
			Dim helpKeyword As String = Me.HelpProvider1.GetHelpKeyword(Me.lstAvailable)
			If Strings.Len(helpKeyword) <> 0 Then
				Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.KeywordIndex, helpKeyword)
			End If
		End Sub

		Private Sub dlgPUList_Resize(sender As Object, e As EventArgs)
		End Sub

		<AccessedThroughProperty("cmdHelp")>
		Private _cmdHelp As Button

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As System.Windows.Forms.Timer

		<AccessedThroughProperty("lstCustomPUDB")>
		Private _lstCustomPUDB As ListBox

		<AccessedThroughProperty("cboManufMenu")>
		Private _cboManufMenu As ComboBox

		<AccessedThroughProperty("cmdRemove")>
		Private _cmdRemove As Button

		<AccessedThroughProperty("cmdAdd")>
		Private _cmdAdd As Button

		<AccessedThroughProperty("lstSelected")>
		Private _lstSelected As ListBox

		<AccessedThroughProperty("lstAvailable")>
		Private _lstAvailable As ListBox

		<AccessedThroughProperty("_panOtherInfo_1")>
		Private __panOtherInfo_1 As Label

		<AccessedThroughProperty("_panUnitName_1")>
		Private __panUnitName_1 As Label

		<AccessedThroughProperty("_panOtherInfo_0")>
		Private __panOtherInfo_0 As Label

		<AccessedThroughProperty("_panUnitName_0")>
		Private __panUnitName_0 As Label

		<AccessedThroughProperty("_Label_5")>
		Private __Label_5 As Label

		<AccessedThroughProperty("_Label_4")>
		Private __Label_4 As Label

		<AccessedThroughProperty("_lblUnitName_1")>
		Private __lblUnitName_1 As Label

		<AccessedThroughProperty("_Label_3")>
		Private __Label_3 As Label

		<AccessedThroughProperty("_lblUnitName_0")>
		Private __lblUnitName_0 As Label

		<AccessedThroughProperty("_Label_0")>
		Private __Label_0 As Label

		<AccessedThroughProperty("_Label_2")>
		Private __Label_2 As Label

		<AccessedThroughProperty("_Label_1")>
		Private __Label_1 As Label

		<AccessedThroughProperty("_SSPanel_0")>
		Private __SSPanel_0 As Panel

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As PanelArray

		<AccessedThroughProperty("lblUnitName")>
		Private _lblUnitName As LabelArray

		<AccessedThroughProperty("panOtherInfo")>
		Private _panOtherInfo As LabelArray

		<AccessedThroughProperty("panUnitName")>
		Private _panUnitName As LabelArray

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		Private Shared m_vb6FormDefInstance As dlgPUList

		Private Shared m_InitializingDefInstance As Boolean

		Private Const LT As Short = -1S

		Private Const EQ As Short = 0S

		Private Const GT As Short = 1S

		Private Const ID_SELECTED As Short = 0S

		Private Const ID_AVAILABLE As Short = 1S

		Private Const MASK_NONE As Short = 0S

		Private Const MASK_AVAILABLE As Short = 1S

		Private Const MASK_SELECTED As Short = 2S

		Private bDragging As Short

		Private bInserting As Short

		Private bNoDrop As Short

		Private wDragType As Short

		Private ctlSource As Control

		Private UnitTypeInfoList As RSWIN_DESC.UnitTypeInfo()

		Private nUnitTypes As Short

		Private UnitData As RSWIN_DESC.PUDataRec()

		Private uIdx As Object()

		Private nUnits As Short

		Private myAL_Selected As ArrayList

		Private myAL_Available As ArrayList

		Private indexOfItemUnderMouseToDrag As Integer

		Private indexOfItemUnderMouseToDrop As Integer

		Private dragBoxFromMouseDown As Rectangle

		Private screenOffset As Point

		Private MyNoDropCursor As Cursor

		Private MyNormalCursor As Cursor

		Private bSourceToTarget As Boolean

		Private bTargetToSource As Boolean

		Private $STATIC$cboManufMenu_SelectedIndexChanged$20211C1241$iPrevIndex As Short

		Private Class clsItem
			Public Property Name As String
				Get
					Return Me.m_Name
				End Get
				Set(value As String)
					Me.m_Name = value
				End Set
			End Property

			Public Property Index As String
				Get
					Return Conversions.ToString(Me.m_Index)
				End Get
				Set(value As String)
					Me.m_Index = Conversions.ToInteger(value)
				End Set
			End Property

			Public Sub New(Optional sN As String = "", Optional nIndx As Integer = 0)
				Me.m_Name = sN
				Me.m_Index = nIndx
			End Sub

			Private m_Name As String

			Private m_Index As Integer
		End Class
	End Class
End Namespace
