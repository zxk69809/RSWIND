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
	Friend Partial Class dlgCustomRG
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgCustomRG_Load
			Me.sAlreadyRG = "There is already a custom rod grade with this name. Please select a different name."
			Me.m_lstRGEquip = New ListView()
			If dlgCustomRG.m_vb6FormDefInstance Is Nothing Then
				If dlgCustomRG.m_InitializingDefInstance Then
					dlgCustomRG.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgCustomRG.m_vb6FormDefInstance = Me
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

		Public Overridable Property cboStressMethod As ComboBox
			Get
				Return Me._cboStressMethod
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboStressMethod_DropDown
				Dim value3 As EventHandler = AddressOf Me.cboStressMethod_SelectedIndexChanged
				Dim value4 As EventHandler = AddressOf Me.cboStressMethod_Leave
				Dim value5 As EventHandler = AddressOf Me.cboStressMethod_Enter
				If Me._cboStressMethod IsNot Nothing Then
					RemoveHandler Me._cboStressMethod.DropDown, value2
					RemoveHandler Me._cboStressMethod.SelectedIndexChanged, value3
					RemoveHandler Me._cboStressMethod.Leave, value4
					RemoveHandler Me._cboStressMethod.Enter, value5
				End If
				Me._cboStressMethod = value
				If Me._cboStressMethod IsNot Nothing Then
					AddHandler Me._cboStressMethod.DropDown, value2
					AddHandler Me._cboStressMethod.SelectedIndexChanged, value3
					AddHandler Me._cboStressMethod.Leave, value4
					AddHandler Me._cboStressMethod.Enter, value5
				End If
			End Set
		End Property

		Public Overridable Property txtTensileStrength As TextBox
			Get
				Return Me._txtTensileStrength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTensileStrength_Enter
				Dim value3 As EventHandler = AddressOf Me.txtTensileStrength_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtTensileStrength_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtTensileStrength_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtTensileStrength_TextChanged
				If Me._txtTensileStrength IsNot Nothing Then
					RemoveHandler Me._txtTensileStrength.Enter, value2
					RemoveHandler Me._txtTensileStrength.Leave, value3
					RemoveHandler Me._txtTensileStrength.KeyPress, value4
					RemoveHandler Me._txtTensileStrength.KeyDown, value5
					RemoveHandler Me._txtTensileStrength.TextChanged, value6
				End If
				Me._txtTensileStrength = value
				If Me._txtTensileStrength IsNot Nothing Then
					AddHandler Me._txtTensileStrength.Enter, value2
					AddHandler Me._txtTensileStrength.Leave, value3
					AddHandler Me._txtTensileStrength.KeyPress, value4
					AddHandler Me._txtTensileStrength.KeyDown, value5
					AddHandler Me._txtTensileStrength.TextChanged, value6
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

		Public Overridable Property _Label_2 As Label
			Get
				Return Me.__Label_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_2 = value
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

		Friend Overridable Property txtRodGrade As TextBox
			Get
				Return Me._txtRodGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtRodGrade_Leave
				Dim value3 As EventHandler = AddressOf Me.txtRodGrade_Enter
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtRodGrade_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtRodGrade_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtRodGrade_TextChanged
				If Me._txtRodGrade IsNot Nothing Then
					RemoveHandler Me._txtRodGrade.Leave, value2
					RemoveHandler Me._txtRodGrade.Enter, value3
					RemoveHandler Me._txtRodGrade.KeyPress, value4
					RemoveHandler Me._txtRodGrade.KeyDown, value5
					RemoveHandler Me._txtRodGrade.TextChanged, value6
				End If
				Me._txtRodGrade = value
				If Me._txtRodGrade IsNot Nothing Then
					AddHandler Me._txtRodGrade.Leave, value2
					AddHandler Me._txtRodGrade.Enter, value3
					AddHandler Me._txtRodGrade.KeyPress, value4
					AddHandler Me._txtRodGrade.KeyDown, value5
					AddHandler Me._txtRodGrade.TextChanged, value6
				End If
			End Set
		End Property

		Friend Overridable Property chkSinkerBar As CheckBox
			Get
				Return Me._chkSinkerBar
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkSinkerBar = value
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

		Public Shared Property DefInstance As dlgCustomRG
			Get
				If dlgCustomRG.m_vb6FormDefInstance Is Nothing OrElse dlgCustomRG.m_vb6FormDefInstance.IsDisposed Then
					dlgCustomRG.m_InitializingDefInstance = True
					dlgCustomRG.m_vb6FormDefInstance = New dlgCustomRG()
					dlgCustomRG.m_InitializingDefInstance = False
				End If
				Return dlgCustomRG.m_vb6FormDefInstance
			End Get
			Set(value As dlgCustomRG)
				dlgCustomRG.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub cboStressMethod_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			Dim obj As Object = Me.cboStressMethod.SelectedIndex
		End Sub

		Private Sub cboStressMethod_DropDown(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			Me.Close()
		End Sub

		Private Sub cmdHelp_Click(eventSender As Object, eventArgs As EventArgs)
			Dim parameter As String = "Custom rod grade entry"
			Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.KeywordIndex, parameter)
			Me.ResetClock()
		End Sub

		Private Sub cmdOK_Click(eventSender As Object, eventArgs As EventArgs)
			Try
				Me.ResetClock()
				Dim obj As Object
				If Strings.Len(Strings.Trim(Me.txtRodGrade.Text)) = 0 Then
					Dim sMsg As String = "Please enter a name for this custom rod grade."
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
					Me.txtRodGrade.Focus()
				ElseIf Not CtrlUI.CheckValid(Me.txtTensileStrength, True, True, obj) Then
					Me.txtTensileStrength.Focus()
				ElseIf Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					Dim sMsg2 As String = "Please enter the tensile strength of this custom rod grade."
					Dim sMsgType2 As String = ""
					Dim bClosing2 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg2, sMsgType2, bClosing2, dialogResult)
					Me.txtTensileStrength.Focus()
				ElseIf Operators.ConditionalCompareObjectLess(obj, 15000, False) Then
					Dim sMsg3 As String = "Please enter the tensile strength of this custom rod grade."
					Dim sMsgType3 As String = ""
					Dim bClosing3 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg3, sMsgType3, bClosing3, dialogResult)
					Me.txtTensileStrength.Focus()
				ElseIf Me.cboStressMethod.SelectedIndex < 0 Then
					Dim sMsg4 As String = "Please select the stress analysis method for this custom rod grade."
					Dim sMsgType4 As String = ""
					Dim bClosing4 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg4, sMsgType4, bClosing4, dialogResult)
					Me.cboStressMethod.Focus()
				Else
					Dim text As String = Strings.Trim(Me.txtRodGrade.Text)
					Dim listView As ListView
					If Strings.StrComp(text, Conversions.ToString(Me.Tag), CompareMethod.Text) <> 0 Then
						listView = Me.m_lstRGEquip
						Dim num As Integer = 0
						Dim num2 As Integer = listView.Items.Count - 1
						For i As Integer = num To num2
							Dim text2 As String = listView.Items(i).Text
							If Strings.StrComp(text2, Conversions.ToString(Me.Tag), CompareMethod.Text) <> 0 AndAlso Strings.StrComp(text2, text, CompareMethod.Text) = 0 Then
								Dim sMsg5 As String = Me.sAlreadyRG
								Dim sMsgType5 As String = ""
								Dim bClosing5 As Boolean = False
								Dim dialogResult As DialogResult = DialogResult.OK
								Util.SendMessage(sMsg5, sMsgType5, bClosing5, dialogResult)
								listView = Nothing
								Return
							End If
						Next
					End If
					If Me.SaveType = 1 Then
						Dim text2 As String = Strings.Trim(Me.txtRodGrade.Text)
						Dim num3 As Short = If((-If((CtrlUI.CheckValid(Me.txtTensileStrength, True, True, obj) > False), 1S, 0S)), 1S, 0S)
						Dim stressMethod As Short = Conversions.ToShort(Me.cboStressMethod.SelectedValue)
						Dim sinkerBar As Short = If((-If((Me.chkSinkerBar.Checked > False), 1S, 0S)), 1S, 0S)
						Me.Close()
						Dim customRodGrade As RSWIN_DESC.CustomRodGrade
						customRodGrade.Steel = -1S
						customRodGrade.RodType = text2
						customRodGrade.TensileStrength = Conversions.ToSingle(obj)
						customRodGrade.Elasticity = 0F
						customRodGrade.RodWeight = 0F
						customRodGrade.StressMethod = stressMethod
						customRodGrade.SinkerBar = sinkerBar
						Dim flag As Boolean = True
						CUSTOMRG.AddCustomRodGrade(RSWIN_DESC.CustomRodGradeList, customRodGrade, flag)
						Dim num4 As Integer = 1
						Dim num5 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
						For i As Integer = num4 To num5
							If Strings.StrComp(text2, Strings.Trim(RSWIN_DESC.CustomRodGradeList(i).RodType), CompareMethod.Text) = 0 Then
								listView.Items.Insert(i - 1, text2)
							End If
						Next
					ElseIf Me.SaveType = 2 Then
						Dim text2 As String = Strings.Trim(Me.txtRodGrade.Text)
						Dim num3 As Short = If((-If((CtrlUI.CheckValid(Me.txtTensileStrength, True, True, obj) > False), 1S, 0S)), 1S, 0S)
						Dim stressMethod As Short = Conversions.ToShort(Me.cboStressMethod.SelectedValue)
						Dim sinkerBar As Short = If((-If((Me.chkSinkerBar.Checked > False), 1S, 0S)), 1S, 0S)
						Dim customRodGrade As RSWIN_DESC.CustomRodGrade
						customRodGrade.Steel = -1S
						Dim sOldRodType As String = Conversions.ToString(Me.Tag)
						customRodGrade.RodType = text2
						customRodGrade.TensileStrength = Conversions.ToSingle(obj)
						customRodGrade.Elasticity = 0F
						customRodGrade.RodWeight = 0F
						customRodGrade.StressMethod = stressMethod
						customRodGrade.SinkerBar = sinkerBar
						RSWIN_DESC.CustomRodGradeList(Me.m_ModifyIndex) = customRodGrade
						Custom.CustomRodGrades_DBUpdateRow(customRodGrade, sOldRodType, False, "")
					End If
					Me.Hide()
				End If
			Catch ex As Exception
				Dim sMsg6 As String = "Error in cmdOK: " + ex.Message
				Dim sMsgType6 As String = ""
				Dim bClosing6 As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg6, sMsgType6, bClosing6, dialogResult)
			End Try
		End Sub

		Private Sub LoadCboStressMethod()
			Dim arrayList As ArrayList = New ArrayList()
			Try
				Me.cboStressMethod.Items.Clear()
				arrayList.Add(New dlgCustomRG.clsCustomRGList(RODUTIL.StressMethodName(0), 0))
				arrayList.Add(New dlgCustomRG.clsCustomRGList(RODUTIL.StressMethodName(3), 3))
				arrayList.Add(New dlgCustomRG.clsCustomRGList(RODUTIL.StressMethodName(1), 1))
				arrayList.Add(New dlgCustomRG.clsCustomRGList(RODUTIL.StressMethodName(2), 2))
				arrayList.Add(New dlgCustomRG.clsCustomRGList(RODUTIL.StressMethodName(4), 4))
				Me.cboStressMethod.DataSource = arrayList
				Me.cboStressMethod.DisplayMember = "Name"
				Me.cboStressMethod.ValueMember = "Index"
				Me.cboStressMethod.SelectedIndex = 0
			Catch ex As Exception
			End Try
		End Sub

		Private Sub dlgCustomRG_Load(eventSender As Object, eventArgs As EventArgs)
			SUPERPRO.NewCheckSentinel(True)
			Me.ResetClock()
			RSWIN.GetMeasurementUnit()
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
			Try
				Me.Icon = RSWIN_DESC.frmMain.Icon
			Catch ex As Exception
			End Try
			Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			Me.LoadCboStressMethod()
			Me.Tag = Strings.Trim(Me.txtRodGrade.Text)
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
			End If
		End Sub

		Private Sub TextBox_Change(ByRef txt As TextBox, ByRef lbl As Label)
			If Me.ActiveControl IsNot txt Then
				CtrlUI.TextBox_LostFocus(txt, lbl, True)
			End If
			Me.ResetClock()
		End Sub

		Private Sub txtRodGrade_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtRodGrade As TextBox = Me.txtRodGrade
			Dim label_ As Label = Me._Label_0
			Me.TextBox_Change(txtRodGrade, label_)
			Me._Label_0 = label_
			Me.txtRodGrade = txtRodGrade
			If Me.ActiveControl Is Me.txtRodGrade Then
				If Me.txtRodGrade.Text.Length > 13 Then
					MessageBox.Show("Rod Grade names greater than 13 characters are truncated in Output Report.")
				End If
				Return
			End If
		End Sub

		Private Sub txtRodGrade_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtRodGrade_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtTensileStrength_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtTensileStrength As TextBox = Me.txtTensileStrength
			Dim label_ As Label = Me._Label_1
			Me.TextBox_Change(txtTensileStrength, label_)
			Me._Label_1 = label_
			Me.txtTensileStrength = txtTensileStrength
			If Me.txtTensileStrength Is Me.ActiveControl Then
				If Me.txtTensileStrength.Text.Trim().Length > 0 AndAlso Not Versioned.IsNumeric(Me.txtTensileStrength.Text) Then
					Dim sMsg As String = "Please enter numeric value for Minimum Tensile Strength."
					Dim sMsgType As String = "Data Entry Error"
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
					Me.txtTensileStrength.Text = ""
				End If
				Return
			End If
		End Sub

		Private Sub txtTensileStrength_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtTensileStrength_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtTensileStrength_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtTensileStrength As Control = Me.txtTensileStrength
			CtrlUI.Control_LostFocus(txtTensileStrength)
			Me.txtTensileStrength = CType(txtTensileStrength, TextBox)
			Dim obj As Object
			If Not CtrlUI.CheckValid(Me.txtTensileStrength, True, False, obj) Then
				Me.txtTensileStrength.Focus()
			End If
		End Sub

		Public Sub NewCustomRG(ByRef lst As ListView)
			Me.SaveType = 1
			Me.Text = "New " + Me.Text
			Me.Tag = RSWIN_DESC.sNull
			Me.m_lstRGEquip = lst
			Me.txtRodGrade.Text = ""
			Me.txtTensileStrength.Text = ""
			Me.cboStressMethod.SelectedIndex = -1
			Me.chkSinkerBar.Checked = False
			Me.ShowDialog()
		End Sub

		Public Sub ModifyCustomRG(ByRef lvw As ListView, ModifyIndex As Integer)
			Me.SaveType = 2
			Me.m_ModifyIndex = ModifyIndex
			Try
				Dim num As Short
				Dim num2 As Short
				Dim num3 As Short
				num = CShort(Me.m_ModifyIndex)
				Me.Text = "Modify Custom Rod Grade Information"
				Me.txtRodGrade.Text = Strings.Trim(RSWIN_DESC.CustomRodGradeList(CInt(num)).RodType)
				Me.txtTensileStrength.Text = Convert.ToString(RSWIN_DESC.CustomRodGradeList(CInt(num)).TensileStrength)
				If Me.cboStressMethod.Items.Count = 0 Then
					Me.LoadCboStressMethod()
				End If
				num2 = 0S
				num3 = CShort((Me.cboStressMethod.Items.Count - 1))
				For num4 As Short = num2 To num3
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.cboStressMethod.Items(CInt(num4)))
					If Operators.ConditionalCompareObjectEqual(RSWIN_DESC.CustomRodGradeList(CInt(num)).StressMethod, NewLateBinding.LateGet(objectValue, Nothing, "Index", New Object(-1) {}, Nothing, Nothing, Nothing), False) Then
						Me.cboStressMethod.SelectedIndex = CInt(num4)
						Exit For
					End If
				Next
				Me.chkSinkerBar.Checked = (RSWIN_DESC.CustomRodGradeList(CInt(num)).SinkerBar <> 0S)
				Me.ShowDialog()
			Catch ex As Exception
				Dim sMsg As String = "Error in ModifyCustomRG: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub LoadCustomRodGradeList()
			RSWIN_DESC.CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(0) {}
			Dim sSection As String = "Custom Rod Grade List"
			Dim obj As Object
			Dim num As Integer = Conversions.ToInteger(obj)
			Dim array As String()
			ini.GetPrivateProfileKeyList(sSection, array, num)
			obj = num
			If Operators.ConditionalCompareObjectGreater(obj, 0, False) Then
				RSWIN_DESC.CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(0) {}
				Dim obj2 As Object
				Dim obj3 As Object
				If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj2, 0, Operators.SubtractObject(obj, 1), 1, obj3, obj2) Then
					Do
						Dim obj4 As Object = 128
						Dim text As String = Strings.Space(Conversions.ToInteger(obj4))
						Dim text2 As String = "Custom Rod Grade List"
						Dim array2 As String() = array
						Dim num2 As Integer = Conversions.ToInteger(obj2)
						Dim sNull As String = RSWIN_DESC.sNull
						Dim privateProfileString As Integer = LibWrap.GetPrivateProfileString(text2, array2(num2), sNull, text, Conversions.ToInteger(obj4), RSWIN_DESC.THETA_INI)
						RSWIN_DESC.sNull = sNull
						Dim obj5 As Object = privateProfileString
						text = text.Substring(0, Conversions.ToInteger(obj5))
						Dim obj6 As Object = Strings.InStr(1, text, ",", CompareMethod.Binary)
						If Operators.ConditionalCompareObjectGreater(obj6, 0, False) Then
							Dim obj7 As Object = Strings.InStr(Conversions.ToInteger(Operators.AddObject(obj6, 1)), text, ",", CompareMethod.Binary)
							If Operators.ConditionalCompareObjectGreater(obj7, 0, False) Then
								Dim obj8 As Object = Strings.InStr(Conversions.ToInteger(Operators.AddObject(obj7, 1)), text, ",", CompareMethod.Binary)
								If Operators.ConditionalCompareObjectGreater(obj8, 0, False) Then
									Dim obj9 As Object = Strings.InStr(Conversions.ToInteger(Operators.AddObject(obj8, 1)), text, ",", CompareMethod.Binary)
									Dim customRodGrade As RSWIN_DESC.CustomRodGrade
									customRodGrade.RodType = array(Conversions.ToInteger(obj2))
									customRodGrade.Steel = CShort(Math.Round(Conversion.Val(text.Substring(0, Conversions.ToInteger(Operators.SubtractObject(obj6, 1))))))
									customRodGrade.TensileStrength = CSng(Conversion.Val(Strings.Mid(text, Conversions.ToInteger(Operators.AddObject(obj6, 1)))))
									customRodGrade.Elasticity = CSng(Conversion.Val(Strings.Mid(text, Conversions.ToInteger(Operators.AddObject(obj7, 1)))))
									customRodGrade.RodWeight = CSng(Conversion.Val(Strings.Mid(text, Conversions.ToInteger(Operators.AddObject(obj8, 1)))))
									If Operators.ConditionalCompareObjectEqual(obj9, 0, False) Then
										customRodGrade.StressMethod = 0S
										customRodGrade.SinkerBar = 0S
									Else
										customRodGrade.StressMethod = CShort(Math.Round(Conversion.Val(Strings.Mid(text, Conversions.ToInteger(Operators.AddObject(obj9, 1))))))
										Dim obj10 As Object = Strings.InStr(Conversions.ToInteger(Operators.AddObject(obj9, 1)), text, ",", CompareMethod.Binary)
										If Operators.ConditionalCompareObjectGreater(obj10, 0, False) Then
											customRodGrade.SinkerBar = CShort(Math.Round(Conversion.Val(Strings.Mid(text, Conversions.ToInteger(Operators.AddObject(obj10, 1))))))
										End If
									End If
									If customRodGrade.Steel <> 0S Then
										Dim flag As Boolean = False
										CUSTOMRG.AddCustomRodGrade(RSWIN_DESC.CustomRodGradeList, customRodGrade, flag)
									End If
								End If
							End If
						End If
					Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj2, obj3, obj2)
				End If
			End If
		End Sub

		Private Sub txtRodGrade_Enter(sender As Object, e As EventArgs)
			Me.txtRodGrade.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtRodGrade_Leave(sender As Object, e As EventArgs)
			Dim txtRodGrade As Control = Me.txtRodGrade
			CtrlUI.Control_LostFocus(txtRodGrade)
			Me.txtRodGrade = CType(txtRodGrade, TextBox)
		End Sub

		Private Sub txtTensileStrength_Enter(sender As Object, e As EventArgs)
			Me.txtTensileStrength.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboStressMethod_Enter(sender As Object, e As EventArgs)
			Me.cboStressMethod.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboStressMethod_Leave(sender As Object, e As EventArgs)
			Dim txtTensileStrength As Control = Me.txtTensileStrength
			CtrlUI.Control_LostFocus(txtTensileStrength)
			Me.txtTensileStrength = CType(txtTensileStrength, TextBox)
		End Sub

		Public Sub Control__LostFocus(ByRef cntrl As Control)
			cntrl.BackColor = Color.White
			cntrl.ForeColor = Color.Black
			Me.ResetClock()
		End Sub

		Public Sub ResetClock()
			Try
				If RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
					If Me.MyParentFrm Is Nothing Then
						Try
							Me.MyParentFrm = RSWIN_DESC.frmMain
						Catch ex As Exception
						End Try
					End If
					Me.MyParentFrm.ResetClock()
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		<AccessedThroughProperty("cmdHelp")>
		Private _cmdHelp As Button

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("cboStressMethod")>
		Private _cboStressMethod As ComboBox

		<AccessedThroughProperty("txtTensileStrength")>
		Private _txtTensileStrength As TextBox

		<AccessedThroughProperty("_Label_3")>
		Private __Label_3 As Label

		<AccessedThroughProperty("_Label_1")>
		Private __Label_1 As Label

		<AccessedThroughProperty("_Label_0")>
		Private __Label_0 As Label

		<AccessedThroughProperty("_Label_2")>
		Private __Label_2 As Label

		<AccessedThroughProperty("_SSPanel_0")>
		Private __SSPanel_0 As Panel

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As PanelArray

		<AccessedThroughProperty("txtRodGrade")>
		Private _txtRodGrade As TextBox

		<AccessedThroughProperty("chkSinkerBar")>
		Private _chkSinkerBar As CheckBox

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		Private Shared m_vb6FormDefInstance As dlgCustomRG

		Private Shared m_InitializingDefInstance As Boolean

		Private MyParentFrm As RODSTAR

		Private sAlreadyRG As String

		Private m_ModifyIndex As Integer

		Private m_lstRGEquip As ListView

		Private SaveType As Integer

		Private Class clsCustomRGList
			Public Property Name As String
				Get
					Return Conversions.ToString(Me.m_Name)
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

			Public Sub New(sN As String, nIndx As Integer)
				Me.m_Name = sN
				Me.m_Index = nIndx
			End Sub

			Private m_Name As Object

			Private m_Index As Integer
		End Class
	End Class
End Namespace
