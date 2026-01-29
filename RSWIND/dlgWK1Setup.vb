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
	Friend Partial Class dlgWK1Setup
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgWK1Setup_Load
			Me.sAlreadyFormat = "There is already a format with this name. Please select a different name."
			Me.bSourceToTarget = False
			Me.bTargetToSource = False
			If dlgWK1Setup.m_vb6FormDefInstance Is Nothing Then
				If dlgWK1Setup.m_InitializingDefInstance Then
					dlgWK1Setup.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgWK1Setup.m_vb6FormDefInstance = Me
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

		Public Overridable Property cmdLoad As Button
			Get
				Return Me._cmdLoad
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdLoad_Click
				If Me._cmdLoad IsNot Nothing Then
					RemoveHandler Me._cmdLoad.Click, value2
				End If
				Me._cmdLoad = value
				If Me._cmdLoad IsNot Nothing Then
					AddHandler Me._cmdLoad.Click, value2
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

		Public Overridable Property txtFormatName As TextBox
			Get
				Return Me._txtFormatName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtFormatName_TextChanged
				If Me._txtFormatName IsNot Nothing Then
					RemoveHandler Me._txtFormatName.TextChanged, value2
				End If
				Me._txtFormatName = value
				If Me._txtFormatName IsNot Nothing Then
					AddHandler Me._txtFormatName.TextChanged, value2
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

		Public Overridable Property cmdInsert As Button
			Get
				Return Me._cmdInsert
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdInsert_Click
				If Me._cmdInsert IsNot Nothing Then
					RemoveHandler Me._cmdInsert.Click, value2
				End If
				Me._cmdInsert = value
				If Me._cmdInsert IsNot Nothing Then
					AddHandler Me._cmdInsert.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdAppend As Button
			Get
				Return Me._cmdAppend
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdAppend_Click
				If Me._cmdAppend IsNot Nothing Then
					RemoveHandler Me._cmdAppend.Click, value2
				End If
				Me._cmdAppend = value
				If Me._cmdAppend IsNot Nothing Then
					AddHandler Me._cmdAppend.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdMoveDown As Button
			Get
				Return Me._cmdMoveDown
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdMoveDown_Click
				If Me._cmdMoveDown IsNot Nothing Then
					RemoveHandler Me._cmdMoveDown.Click, value2
				End If
				Me._cmdMoveDown = value
				If Me._cmdMoveDown IsNot Nothing Then
					AddHandler Me._cmdMoveDown.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdMoveUp As Button
			Get
				Return Me._cmdMoveUp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdMoveUp_Click
				If Me._cmdMoveUp IsNot Nothing Then
					RemoveHandler Me._cmdMoveUp.Click, value2
				End If
				Me._cmdMoveUp = value
				If Me._cmdMoveUp IsNot Nothing Then
					AddHandler Me._cmdMoveUp.Click, value2
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
				Dim value11 As EventHandler = AddressOf Me.lstSelected_SelectedIndexChanged
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
					RemoveHandler Me._lstSelected.SelectedIndexChanged, value11
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
					AddHandler Me._lstSelected.SelectedIndexChanged, value11
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
				Dim value11 As EventHandler = AddressOf Me.lstAvailable_SelectedIndexChanged
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
					RemoveHandler Me._lstAvailable.SelectedIndexChanged, value11
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
					AddHandler Me._lstAvailable.SelectedIndexChanged, value11
				End If
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

		Friend Overridable Property chkIncludeRodString As CheckBox
			Get
				Return Me._chkIncludeRodString
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkIncludeRodString_CheckedChanged
				If Me._chkIncludeRodString IsNot Nothing Then
					RemoveHandler Me._chkIncludeRodString.CheckedChanged, value2
				End If
				Me._chkIncludeRodString = value
				If Me._chkIncludeRodString IsNot Nothing Then
					AddHandler Me._chkIncludeRodString.CheckedChanged, value2
				End If
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

		Public Shared Property DefInstance As dlgWK1Setup
			Get
				If dlgWK1Setup.m_vb6FormDefInstance Is Nothing OrElse dlgWK1Setup.m_vb6FormDefInstance.IsDisposed Then
					dlgWK1Setup.m_InitializingDefInstance = True
					dlgWK1Setup.m_vb6FormDefInstance = New dlgWK1Setup()
					dlgWK1Setup.m_InitializingDefInstance = False
				End If
				Return dlgWK1Setup.m_vb6FormDefInstance
			End Get
			Set(value As dlgWK1Setup)
				dlgWK1Setup.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property cmdLoadTag As String
			Get
				Return Me.m_cmdLoadTag
			End Get
			Set(value As String)
				Me.m_cmdLoadTag = value
			End Set
		End Property

		Public Property cmdLoadValue As Boolean
			Get
				Return Me.m_cmdLoadValue
			End Get
			Set(value As Boolean)
				Me.m_cmdLoadValue = value
				If value Then
					Me.LoadList()
				End If
			End Set
		End Property

		Public Property bCancel As Boolean
			Get
				Return Me.m_bCancel
			End Get
			Set(value As Boolean)
				Me.m_bCancel = value
			End Set
		End Property

		Public Property IncludeRodString As Boolean
			Get
				Return Me.m_IncludeRodString
			End Get
			Set(value As Boolean)
				Me.m_IncludeRodString = value
			End Set
		End Property

		Public Property FormatName As String
			Get
				Return Me.m_FormatName
			End Get
			Set(value As String)
				Me.m_FormatName = value
			End Set
		End Property

		Private Sub CheckButtons()
			Dim flag As Boolean = Me.lstAvailable.SelectedIndex >= 0
			Dim flag2 As Boolean = Me.lstSelected.SelectedIndex >= 0
			Me.cmdAppend.Enabled = (flag AndAlso flag2)
			Me.cmdInsert.Enabled = (flag AndAlso flag2)
			Me.cmdMoveDown.Enabled = flag2
			Me.cmdMoveUp.Enabled = flag2
			Me.cmdRemove.Enabled = flag2
		End Sub

		Private Sub cmdAppend_Click(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(Me.lstAvailable.SelectedIndex)
			Dim num2 As Short = CShort(Me.lstSelected.SelectedIndex)
			If num >= 0S And num2 >= 0S Then
				Dim lstAvailable As ListBox = Me.lstAvailable
				Dim iSrcIndex As Object = num
				Dim lstSelected As ListBox = Me.lstSelected
				Me.MoveItem(lstAvailable, iSrcIndex, lstSelected, CInt((num2 + 1S)), True)
				Me.lstSelected = lstSelected
				Me.lstAvailable = lstAvailable
			End If
		End Sub

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			Me.m_bCancel = True
			Me.Close()
		End Sub

		Private Sub cmdInsert_Click(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(Me.lstAvailable.SelectedIndex)
			Dim num2 As Short = CShort(Me.lstSelected.SelectedIndex)
			If num >= 0S And num2 >= 0S Then
				Dim lstAvailable As ListBox = Me.lstAvailable
				Dim iSrcIndex As Object = num
				Dim lstSelected As ListBox = Me.lstSelected
				Me.MoveItem(lstAvailable, iSrcIndex, lstSelected, num2, True)
				Me.lstSelected = lstSelected
				Me.lstAvailable = lstAvailable
			End If
		End Sub

		Private Sub cmdLoad_Click(eventSender As Object, eventArgs As EventArgs)
			Me.LoadList()
		End Sub

		Private Sub LoadList()
			Dim array As String() = New String(0) {}
			Me.lstAvailable.Items.Clear()
			Me.lstSelected.Items.Clear()
			Dim num As Short
			Util.LoadMenu(RSWIN_DESC.WK1ITEMS_LIST, num, array)
			Dim num5 As Short
			Dim num6 As Short
			If Not RSWIN_DESC.bRodStarD Then
				array = CType(Utils.CopyArray(CType(array, Array), New String(CInt((num - 4S + 1S)) - 1) {}), String())
				num -= 4S
			End If
			Dim text As String = Me.cmdLoadTag
			Dim num2 As Short
			If Strings.Len(text) = 0 Then
				text = RSWIN_DESC.DEFAULT_WK1ORDER
				Me.Tag = RSWIN_DESC.sNull
			Else
				num2 = CShort(Strings.InStr(text, Me.sFortySpaces, CompareMethod.Binary))
				If num2 > 0S Then
					Me.Tag = text.Substring(0, CInt((num2 - 1S)))
					Me.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Spreadsheet Setup - [", Me.Tag), "]"))
					text = Strings.Mid(text, CInt((num2 + 1S)))
				End If
			End If
			Me.txtFormatName.Text = Conversions.ToString(Me.Tag)
			Me.lstSelected.Items.Clear()
			num2 = 1S
			Dim num4 As Short
			Do
				Dim num3 As Short = -1S
				num4 = CShort(Strings.InStr(CInt(num2), text, ",", CompareMethod.Binary))

					If num4 = 0S Then
						If Versioned.IsNumeric(Strings.Mid(text, CInt(num2))) Then
							num3 = Conversions.ToShort(Strings.Mid(text, CInt(num2)))
						End If
					ElseIf Versioned.IsNumeric(Strings.Mid(text, CInt(num2), CInt((num4 - num2)))) Then
						num3 = Conversions.ToShort(Strings.Mid(text, CInt(num2), CInt((num4 - num2))))
					End If

				If num3 = -1S Then
					Me.chkIncludeRodString.Checked = True
				ElseIf num3 >= 0S And num3 <= num Then
					Dim text2 As String = array(CInt(num3))
					If text2.Length > 0 Then
						text2 = text2.Substring(0, Strings.InStr(text2, "!", CompareMethod.Binary) - 1)
						Me.lstSelected.Items.Add(New ListBoxItem(text2, CInt(num3)))
						array(CInt(num3)) = RSWIN_DESC.sNull
					End If
				End If
				num2 = CShort((CInt(num4) + Strings.Len(",")))
			Loop While num4 <> 0S
			Me.lstAvailable.Items.Clear()
			num5 = 0S
			num6 = num
			For num2 As Short = num5 To num6
				If Strings.Len(array(CInt(num2))) > 0 Then
					Dim text2 As String = array(CInt(num2))
					text2 = text2.Substring(0, Strings.InStr(text2, "!", CompareMethod.Binary) - 1)
					Me.lstAvailable.Items.Add(New ListBoxItem(text2, CInt(num2)))
				End If
			Next
		End Sub

		Private Sub cmdMoveDown_Click(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(Me.lstSelected.SelectedIndex)
			If num >= 0S And CInt(num) < Me.lstSelected.Items.Count - 1 Then
				Dim lstSelected As ListBox = Me.lstSelected
				Dim iSrcIndex As Object = num
				Dim lstSelected2 As ListBox = Me.lstSelected
				Me.MoveItem(lstSelected, iSrcIndex, lstSelected2, CInt((num + 1S)), True)
				Me.lstSelected = lstSelected2
				Me.lstSelected = lstSelected
			End If
		End Sub

		Private Sub cmdMoveUp_Click(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(Me.lstSelected.SelectedIndex)
			If num > 0S Then
				Dim lstSelected As ListBox = Me.lstSelected
				Dim iSrcIndex As Object = num
				Dim lstSelected2 As ListBox = Me.lstSelected
				Me.MoveItem(lstSelected, iSrcIndex, lstSelected2, CInt((num - 1S)), True)
				Me.lstSelected = lstSelected2
				Me.lstSelected = lstSelected
			End If
		End Sub

		Public Property WK1List As ListBox
			Get
				Return Me.m_WK1List
			End Get
			Set(value As ListBox)
				Me.m_WK1List = value
			End Set
		End Property

		Public Property SelectList As ListBox
			Get
				Return Me.m_SelectList
			End Get
			Set(value As ListBox)
				Me.m_SelectList = value
			End Set
		End Property

		Public Property AvailableList As ListBox
			Get
				Return Me.m_AvailableList
			End Get
			Set(value As ListBox)
				Me.m_AvailableList = value
			End Set
		End Property

		Private Sub cmdOK_Click_Save()
			Dim text As String = Strings.Trim(Me.txtFormatName.Text)
			If Strings.Len(text) = 0 Then
				Util.Errmsg("Please enter a name for this format.")
				Me.txtFormatName.Focus()
				Return
			End If
			Dim num5 As Short
			Dim text2 As String
			If Strings.StrComp(text, Conversions.ToString(Me.Tag), CompareMethod.Text) <> 0 Then
				Dim lstWK1Formats As ListBox = RswinSetup.DefInstance.lstWK1Formats
				Dim sect_WK1FORMATS As String = RSWIN_DESC.SECT_WK1FORMATS
				Dim num2 As Short
				Dim num As Integer = CInt(num2)
				Dim array As String()
				Dim array2 As String()
				ini.GetPrivateProfileKeyList(sect_WK1FORMATS, array, array2, num, False)
				num2 = CShort(num)
				Dim num3 As Short = 1S
				Dim num4 As Short = num2
				num5 = num3
				While num5 <= num4
					text2 = Conversions.ToString(lstWK1Formats.Items(CInt(num5)))
					text2 = text2.Substring(0, Strings.InStr(text2, Me.sFortySpaces, CompareMethod.Binary) - 1)
					If Strings.StrComp(text2, Conversions.ToString(Me.Tag), CompareMethod.Text) <> 0 AndAlso Strings.StrComp(text2, text, CompareMethod.Text) = 0 Then
						Util.Errmsg(Me.sAlreadyFormat)
						Return
					End If
					num5 += 1S
				End While
			End If
			Dim num6 As Short
			Dim num7 As Short
			RSWIN_DESC.nItems = CShort(Me.lstSelected.Items.Count)
			text2 = RSWIN_DESC.sNull
			num6 = 0S
			num7 = RSWIN_DESC.nItems - 1S
			num5 = num6
			While num5 <= num7
				text2 = text2 + "," + Convert.ToString(Support.GetItemData(Me.lstSelected, CInt(num5)))
				num5 += 1S
			End While
			text2 = Strings.Mid(text2, 2)
			If Me.chkIncludeRodString.Checked Then
				text2 += ",-1"
			End If
			text = Strings.Trim(Me.txtFormatName.Text)
			Dim num8 As Short = 1S
			Dim num9 As Short = CShort((Me.m_WK1List.Items.Count - 1))
			num5 = num8
			While num5 <= num9
				Dim itemString As String = Support.GetItemString(Me.m_WK1List, CInt(num5))
				If Strings.StrComp(text, itemString.Trim(), CompareMethod.Text) < 0 Then
					Exit While
				End If
				num5 += 1S
			End While
			Me.m_WK1List.Items.Insert(CInt(num5), text + Me.sFortySpaces + text2)
			Me.m_WK1List.SelectedIndex = CInt(num5)
			Dim num10 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_WK1FORMATS, text, text2, RSWIN_DESC.THETA_INI)
			Me.m_SelectList = Me.lstSelected
			Me.Hide()
		End Sub

		Public Sub cmdOK_Click(eventSender As Object, eventArgs As EventArgs)
			Dim text As String = Me.txtFormatName.Text.Trim()
			Me.m_bCancel = False
			If Strings.Len(text) = 0 Then
				Util.Errmsg("Please enter a name for this format.")
				Me.txtFormatName.Focus()
				Return
			End If
			Me.m_SelectList = Me.lstSelected
			Me.m_AvailableList = Me.lstAvailable
			If Strings.StrComp(text, Conversions.ToString(Me.Tag), CompareMethod.Text) <> 0 Then
				Dim num As Integer = 1
				Dim num2 As Integer = Me.m_WK1List.Items.Count - 1
				For i As Integer = num To num2
					Dim text2 As String = Conversions.ToString(Me.m_WK1List.Items(i))
					text2 = text2.Substring(0, Strings.InStr(text2, Me.sFortySpaces, CompareMethod.Binary) - 1)
					If Strings.StrComp(text2, Conversions.ToString(Me.Tag), CompareMethod.Text) <> 0 AndAlso Strings.StrComp(text2, text, CompareMethod.Text) = 0 Then
						Util.Errmsg(Me.sAlreadyFormat)
						Return
					End If
				Next
			End If
			Me.Hide()
		End Sub

		Private Sub cmdRemove_Click(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(Me.lstSelected.SelectedIndex)
			If num >= 0S Then
				Dim lstSelected As ListBox = Me.lstSelected
				Dim iSrcIndex As Object = num
				Dim lstAvailable As ListBox = Me.lstAvailable
				Me.MoveItem(lstSelected, iSrcIndex, lstAvailable, -1, False)
				Me.lstAvailable = lstAvailable
				Me.lstSelected = lstSelected
				If CInt(num) < Me.lstSelected.Items.Count Then
					Me.lstSelected.SelectedIndex = CInt(num)
				Else
					Me.lstSelected.SelectedIndex = Me.lstSelected.Items.Count - 1
				End If
			End If
		End Sub

		Private Sub dlgWK1Setup_Load(eventSender As Object, eventArgs As EventArgs)
			Me.sFortySpaces = "                                        "
			If Operators.CompareString(RSWIN_DESC.HelpNameSpace, "", False) <> 0 Or RSWIN_DESC.HelpNameSpace <> Nothing Then
				Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			End If
			Me.cmdLoad.Tag = Me.cmdLoadTag
			Me.LoadList()
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private Sub lstAvailable_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			Me.CheckButtons()
		End Sub

		Private Sub lstSelected_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			Me.CheckButtons()
		End Sub

		Private Sub MoveItem(ByRef lstSrc As ListBox, iSrcIndex As Object, ByRef lstDest As ListBox, iDestIndex As Object, bSetListIndex As Object)
			Dim itemString As String = Support.GetItemString(lstSrc, Conversions.ToInteger(iSrcIndex))
			Dim itemData As Short = CShort(Support.GetItemData(lstSrc, Conversions.ToInteger(iSrcIndex)))
			lstSrc.Items.RemoveAt(Conversions.ToInteger(iSrcIndex))
			Dim num As Short
			If Operators.ConditionalCompareObjectLess(iDestIndex, 0, False) Then
				lstDest.Items.Add(itemString)
				num = CShort((lstDest.Items.Count - 1))
			Else
				lstDest.Items.Insert(Conversions.ToInteger(iDestIndex), itemString)
				num = Conversions.ToShort(iDestIndex)
			End If
			Support.SetItemData(lstDest, CInt(num), CInt(itemData))
			If Conversions.ToBoolean(bSetListIndex) Then
				lstDest.SelectedIndex = CInt(num)
			End If
		End Sub

		Private Sub lstAvailable_MouseUp(sender As Object, e As MouseEventArgs)
			Me.bAvailableMouseDown = False
			Me.dragBoxFromMouseDown = Rectangle.Empty
		End Sub

		Private Sub chkIncludeRodString_CheckedChanged(sender As Object, e As EventArgs)
			Me.m_IncludeRodString = Me.chkIncludeRodString.Checked
		End Sub

		Private Sub txtFormatName_TextChanged(sender As Object, e As EventArgs)
			Me.FormatName = Me.txtFormatName.Text
		End Sub

		Private Sub lstAvailable_MouseDown(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				Me.bAvailableMouseDown = True
				Me.bSelectedMouseDown = False
				Me.cmdInsert.Enabled = True
				Me.cmdAppend.Enabled = True
				Me.cmdMoveUp.Enabled = False
				Me.cmdMoveDown.Enabled = False
				Me.cmdRemove.Enabled = False
			End If
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
				Me.bSourceToTarget = False
				Cursor.Current = Cursors.[Default]
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
			If e.Button = MouseButtons.Left Then
				Me.bSelectedMouseDown = True
				Me.cmdInsert.Enabled = False
				Me.cmdAppend.Enabled = False
				Me.cmdRemove.Enabled = True
				Me.cmdMoveUp.Enabled = True
				Me.cmdMoveDown.Enabled = True
			End If
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
			Me.bSelectedMouseDown = False
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
				Me.bTargetToSource = False
				Cursor.Current = Cursors.[Default]
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
			Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.KeywordIndex, "Spreadsheet formats")
		End Sub

		<AccessedThroughProperty("cmdHelp")>
		Private _cmdHelp As Button

		<AccessedThroughProperty("cmdLoad")>
		Private _cmdLoad As Button

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("txtFormatName")>
		Private _txtFormatName As TextBox

		<AccessedThroughProperty("cmdRemove")>
		Private _cmdRemove As Button

		<AccessedThroughProperty("cmdInsert")>
		Private _cmdInsert As Button

		<AccessedThroughProperty("cmdAppend")>
		Private _cmdAppend As Button

		<AccessedThroughProperty("cmdMoveDown")>
		Private _cmdMoveDown As Button

		<AccessedThroughProperty("cmdMoveUp")>
		Private _cmdMoveUp As Button

		<AccessedThroughProperty("lstSelected")>
		Private _lstSelected As ListBox

		<AccessedThroughProperty("lstAvailable")>
		Private _lstAvailable As ListBox

		<AccessedThroughProperty("_Label_3")>
		Private __Label_3 As Label

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

		<AccessedThroughProperty("chkIncludeRodString")>
		Private _chkIncludeRodString As CheckBox

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		Private Shared m_vb6FormDefInstance As dlgWK1Setup

		Private Shared m_InitializingDefInstance As Boolean

		Private sAlreadyFormat As String

		Private bInserting As Short

		Private DragMode As Boolean

		Private bAvailableMouseDown As Boolean

		Private bSelectedMouseDown As Boolean

		Private sFortySpaces As String

		Private m_cmdLoadTag As String

		Private m_cmdLoadValue As Boolean

		Private m_bCancel As Boolean

		Private m_IncludeRodString As Boolean

		Private m_FormatName As String

		Private m_WK1List As ListBox

		Private m_SelectList As ListBox

		Private m_AvailableList As ListBox

		Private indexOfItemUnderMouseToDrag As Integer

		Private indexOfItemUnderMouseToDrop As Integer

		Private dragBoxFromMouseDown As Rectangle

		Private screenOffset As Point

		Private MyNoDropCursor As Cursor

		Private MyNormalCursor As Cursor

		Private bSourceToTarget As Boolean

		Private bTargetToSource As Boolean
	End Class
End Namespace
