Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Partial Class dlgSelectInput
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.SelInput_Load
			AddHandler MyBase.Activated, AddressOf Me.dlgSelectInput_Activated
			Me.iCharCount = 0
			Me.sPrevChar = " "c
			Me.myAL = New ArrayList()
			Me.m_bCancel = False
			Me.SFList = New Hashtable()
			If dlgSelectInput.m_vb6FormDefInstance Is Nothing Then
				If dlgSelectInput.m_InitializingDefInstance Then
					dlgSelectInput.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgSelectInput.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Friend Overridable Property Panel1 As Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
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

		Public Overridable Property Label As Label
			Get
				Return Me._Label
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label = value
			End Set
		End Property

		Friend Overridable Property lstFields As ListBox
			Get
				Return Me._lstFields
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As KeyPressEventHandler = AddressOf Me.lstFields_KeyPress
				Dim value3 As EventHandler = AddressOf Me.lstFields_DoubleClick
				Dim value4 As EventHandler = AddressOf Me.lstFields_Enter
				If Me._lstFields IsNot Nothing Then
					RemoveHandler Me._lstFields.KeyPress, value2
					RemoveHandler Me._lstFields.DoubleClick, value3
					RemoveHandler Me._lstFields.Enter, value4
				End If
				Me._lstFields = value
				If Me._lstFields IsNot Nothing Then
					AddHandler Me._lstFields.KeyPress, value2
					AddHandler Me._lstFields.DoubleClick, value3
					AddHandler Me._lstFields.Enter, value4
				End If
			End Set
		End Property

		Public Shared Property DefInstance As dlgSelectInput
			Get
				If dlgSelectInput.m_vb6FormDefInstance Is Nothing OrElse dlgSelectInput.m_vb6FormDefInstance.IsDisposed Then
					dlgSelectInput.m_InitializingDefInstance = True
					dlgSelectInput.m_vb6FormDefInstance = New dlgSelectInput()
					dlgSelectInput.m_InitializingDefInstance = False
				End If
				Return dlgSelectInput.m_vb6FormDefInstance
			End Get
			Set(value As dlgSelectInput)
				dlgSelectInput.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property ControlName As String
			Get
				Return Me.m_ControlName
			End Get
			Set(value As String)
				Me.m_ControlName = value
			End Set
		End Property

		Public Property TabName As String
			Get
				Return Me.m_TabName
			End Get
			Set(value As String)
				Me.m_TabName = value
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

		Private Sub GetScrnNum(sKey As String, ByRef ScrnNum As Integer)
			Dim enumerator As IDictionaryEnumerator = Me.SFList.GetEnumerator()
			While enumerator.MoveNext()
				If Operators.ConditionalCompareObjectEqual(enumerator.Key, sKey, False) Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator.Value)
					ScrnNum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue))
				End If
			End While
		End Sub

		Private Sub AddInputItem(sLabel As String, nForm As Object, nItem As Integer, Optional sControlName As String = "", Optional sTabName As String = "")
			' The following expression was wrapped in a checked-statement
			If nItem = -1 Then
				nItem = 0
			Else
				nItem += 1
			End If
			Me.lstFields.Items.Add(sLabel)
			If Operators.CompareString(sControlName, "", False) <> 0 Then
				If Operators.CompareString(sTabName, "", False) = 0 Then
					Me.myAL.Add(New cMenu(sLabel, sControlName, ""))
				Else
					Me.myAL.Add(New cMenu(sLabel, sControlName, sTabName))
				End If
				Try
					Me.SFList.Add(sControlName, nForm.ToString())
				Catch ex As Exception
				End Try
			End If
		End Sub

		Public Sub AddAllItems()
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = False
			Dim flag5 As Boolean = False
			Dim flag6 As Boolean = False
			Dim flag7 As Boolean = False
			If Not RSWIN_DESC.NewData(7) <> 0S Then
				flag = True
			End If
			If Not RSWIN_DESC.NewData(2) <> 0S Then
				flag2 = True
			End If
			If Not RSWIN_DESC.NewData(3) <> 0S Then
				flag3 = True
			End If
			If Not RSWIN_DESC.NewData(6) <> 0S Then
				flag4 = True
			End If
			If Not RSWIN_DESC.NewData(4) <> 0S Then
				flag5 = True
			End If
			If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.NewData(5)) <> 0S Then
				flag6 = True
			End If
			If Not RSWIN_DESC.NewData(1) <> 0S Then
				flag7 = True
			End If
			If flag2 Then
				Me.AddInputItem("     Bubble point pressure", 2, 5, "txtBubblePoint", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Casing pressure", 1, 9, "txtCasingPressure", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Comment", 1, 3, "txtComment", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Company name", 1, 0, "txtCompanyName", "")
			End If
			If flag4 Then
				Me.AddInputItem("     Crank hole number", 6, 4, "cboCrankHole", "")
			End If
			If flag4 Then
				Me.AddInputItem("     Crank rotation", 6, 3, "cboCrankRotation", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Date", 1, 4, "txtUserDate", "")
			End If
			If RSWIN_DESC.bRodStarD AndAlso flag6 Then
				Me.AddInputItem("     Deviation Survey Entry", 5, 0, "tabInput", "_tabInput_TabPage0")
			End If
			If RSWIN_DESC.bRodStarD AndAlso flag6 Then
				Me.AddInputItem("     Deviation Survey Plot", 5, 1, "tabInput", "_tabInput_TabPage2")
			End If
			If flag Then
				Me.AddInputItem("     Electricity cost", 7, 0, "txtElectricityCost", "")
			End If
			If RSWIN_DESC.rst.giFluidLevelSource = 1S AndAlso flag2 Then
				Me.AddInputItem("     Fluid level", 2, 0, "txtFLPIP", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Fluid specific gravity", 1, 13, "txtFluidSPGR", "")
			End If
			If flag3 Then
				Me.AddInputItem("     Friction", 3, 1, "chkCalcFriction", "")
			End If
			If flag2 Then
				Me.AddInputItem("     Mid-perf. depth", 2, 3, "txtMidPerfDepth", "")
			End If
			If flag4 Then
				Me.AddInputItem("     Maximum counterbalance moment", 6, 6, "txtCounterbalance", "")
			End If
			If Operators.ConditionalCompareObjectGreater(Motor.GetMotorInfo(6), 1, False) AndAlso flag Then
				Me.AddInputItem("     Motor setting", 7, 5, "", "")
			End If
			If flag Then
				Me.AddInputItem("     Motor size", 7, 1, "cboMotorSize", "")
			End If
			If flag Then
				Me.AddInputItem("     Motor speed variation", 7, 2, "chkIncludeMotorSPV", "")
			End If
			If flag Then
				Me.AddInputItem("     Motor type", 7, 3, "cboMotorType", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Oil gravity/density", 1, 12, "txtOilAPI", "")
			End If
			If flag Then
				Me.AddInputItem("     Power meter type (detent)", 7, 4, "optPowerMeterType_1", "")
			End If
			If flag Then
				Me.AddInputItem("     Power meter type (Non-detent)", 7, 4, "optPowerMeterType_2", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Pump depth", 1, 7, "txtPumpDepth", "")
			End If
			If flag4 Then
				Me.AddInputItem("     Pumping unit", 6, 1, "lvwUnitList", "")
			End If
			If flag4 Then
				Me.AddInputItem("     Pumping unit manufacturer", 6, 0, "cboManufMenu", "")
			End If
			If RSWIN_DESC.rst.giFluidLevelSource = 2S AndAlso flag2 Then
				Me.AddInputItem("     Pump intake pressure", 2, 0, "txtFLPIP", "")
			End If
			If flag2 Then
				Me.AddInputItem("     Pumping speed", 2, 1, "txtSPMBFPD", "")
			End If
			If flag3 Then
				Me.AddInputItem("     Plunger size", 3, 3, "cboPlungerSize", "")
			End If
			If flag3 Then
				Me.AddInputItem("     Pump type", 3, 4, "optPumpType_1", "")
			End If
			If RSWIN_DESC.rst.IDEntered <> 0S AndAlso flag4 Then
				Me.AddInputItem("     Pumping unit ID", 6, 2, "txtUnitID", "")
			End If
			If flag5 Then
				Me.AddInputItem("     Rod string", 4, 3, "ulgTapers", "")
			End If
			If flag3 Then
				Me.AddInputItem("     Rod-tubing friction", 3, 1, "txtFriction", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Run time", 1, 6, "txtRunTime", "")
			End If
			If flag5 Then
				Me.AddInputItem("     Service factor", 4, 2, "txtServiceFactor", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Specific gravity (produced fluid)", 1, 13, "txtFluidSPGR", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Specific gravity (water)", 1, 11, "txtWaterSPGR", "")
			End If
			If flag2 Then
				Me.AddInputItem("     SPM", 2, 1, "txtSPMBFPD", "")
			End If
			If flag2 Then
				Me.AddInputItem("     Static bottom hole pressure", 2, 4, "", "")
			End If
			If flag4 Then
				Me.AddInputItem("     Stroke Length", 6, 4, "cboCrankHole", "")
			End If
			If flag4 Then
				Me.AddInputItem("     Structural unbalance", 6, 5, "txtUnbalance", "")
			End If
			If flag2 Then
				Me.AddInputItem("     Target production", 2, 2, "txtSPMBFPD", "")
			End If
			If flag3 Then
				Me.AddInputItem("     Tubing anchor depth", 3, 2, "txtTubingAnchorDepth", "")
			End If
			If flag3 Then
				Me.AddInputItem("     Tubing size", 3, 0, "cboTubingOD", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Tubing pressure", 1, 8, "txtTubingPressure", "")
			End If
			If flag7 Then
				Me.AddInputItem("     User name", 1, 2, "txtUserName", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Water cut", 1, 10, "txtWaterCut", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Water specific gravity", 1, 11, "txtWaterSPGR", "")
			End If
			If flag7 Then
				Me.AddInputItem("     Well name", 1, 1, "txtWellName", "")
			End If
		End Sub

		Public Sub AddMotorDataItems()
			Me.AddInputItem("Motor Information", 7, -1, 7.ToString(), "")
			Me.AddInputItem("     Electricity cost", 7, 0, "txtElectricityCost", "")
			Me.AddInputItem("     Motor size", 7, 1, "cboMotorSize", "")
			Me.AddInputItem("     Motor speed variation", 7, 2, "chkIncludeMotorSPV", "")
			Me.AddInputItem("     Motor type", 7, 3, "cboMotorType", "")
			Me.AddInputItem("     Power meter type (detent)", 7, 4, "optPowerMeterType_1", "")
			Me.AddInputItem("     Power meter type (Non-detent)", 7, 4, "optPowerMeterType_2", "")
			If Operators.ConditionalCompareObjectGreater(Motor.GetMotorInfo(6), 1, False) Then
				Me.AddInputItem("     Motor setting", 7, 5, "", "")
			End If
		End Sub

		Public Sub AddProdInfoItems()
			Me.AddInputItem("Production Information", 2, -1, 2.ToString(), "")
			Me.AddInputItem("     Bubble point pressure", 2, 5, "txtBubblePoint", "")
			Me.AddInputItem("     Fluid level/pump intake pressure", 2, 0, "txtFLPIP", "")
			Me.AddInputItem("     Mid-perf. depth", 2, 3, "txtMidPerfDepth", "")
			Me.AddInputItem("     Pump intake pressure/fluid level", 2, 0, "txtFLPIP", "")
			Me.AddInputItem("     Pumping speed", 2, 1, "txtSPMBFPD", "")
			Me.AddInputItem("     SPM", 2, 1, "txtSPMBFPD", "")
			Me.AddInputItem("     Static bottom hole pressure", 2, 4, "", "")
			Me.AddInputItem("     Target production", 2, 2, "txtSPMBFPD", "")
		End Sub

		Public Sub AddPTInfoItems()
			Me.AddInputItem("Pump and Tubing Information", 3, -1, 3.ToString(), "")
			Me.AddInputItem("     Friction", 3, 1, "chkCalcFriction", "")
			Me.AddInputItem("     Plunger size", 3, 3, "cboPlungerSize", "")
			Me.AddInputItem("     Pump type", 3, 4, "optPumpType_1", "")
			Me.AddInputItem("     Rod-tubing friction", 3, 1, "txtFriction", "")
			Me.AddInputItem("     Tubing anchor depth", 3, 2, "txtTubingAnchorDepth", "")
			Me.AddInputItem("     Tubing size", 3, 0, "cboTubingOD", "")
		End Sub

		Public Sub AddPUDataItems()
			Me.AddInputItem("Pumping Unit Information", 6, -1, 6.ToString(), "")
			Me.AddInputItem("     Counterbalance effect", 6, 7, "txtCBEffect", "")
			Me.AddInputItem("     Crank hole number", 6, 4, "cboCrankHole", "")
			Me.AddInputItem("     Crank rotation", 6, 3, "cboCrankRotation", "")
			Me.AddInputItem("     Maximum counterbalance moment", 6, 6, "txtCounterbalance", "")
			Me.AddInputItem("     Pumping unit", 6, 1, "lvwUnitList", "")
			Me.AddInputItem("     Pumping unit manufacturer", 6, 0, "cboManufMenu", "")
			Me.AddInputItem("     Stroke Length", 6, 4, "cboCrankHole", "")
			Me.AddInputItem("     Structural unbalance", 6, 5, "txtUnbalance", "")
			If RSWIN_DESC.rst.IDEntered <> 0S Then
				Me.AddInputItem("     Pumping unit ID", 6, 2, "txtUnitID", "")
			End If
		End Sub

		Public Sub AddRSInputItems()
			Me.AddInputItem("Rod String Information", 4, -1, 4.ToString(), "")
			Me.AddInputItem("     Additional rod costs", 4, 0, "txtRSExtraCost", "")
			Me.AddInputItem("     Rod Cost description", 4, 1, "txtRSExtraCostLabel", "")
			Me.AddInputItem("     Rod string", 4, 3, "ulgTapers", "")
			Me.AddInputItem("     Service factor", 4, 2, "txtServiceFactor", "")
		End Sub

		Public Sub AddWellInfoItems()
			Me.AddInputItem("Well Information", 1, -1, 1.ToString(), "")
			Me.AddInputItem("     Casing pressure", 1, 9, "txtCasingPressure", "")
			Me.AddInputItem("     Comment", 1, 3, "txtComment", "")
			Me.AddInputItem("     Company name", 1, 0, "txtCompanyName", "")
			Me.AddInputItem("     Date", 1, 4, "txtUserDate", "")
			Me.AddInputItem("     Fluid specific gravity", 1, 13, "txtFluidSPGR", "")
			Me.AddInputItem("     Oil gravity/density", 1, 12, "txtOilAPI", "")
			Me.AddInputItem("     Pump depth", 1, 7, "txtPumpDepth", "")
			Me.AddInputItem("     Run time", 1, 6, "txtRunTime", "")
			Me.AddInputItem("     Specific gravity (produced fluid)", 1, 13, "txtFluidSPGR", "")
			Me.AddInputItem("     Specific gravity (water)", 1, 11, "txtWaterSPGR", "")
			Me.AddInputItem("     Tubing pressure", 1, 8, "txtTubingPressure", "")
			Me.AddInputItem("     User name", 1, 2, "txtUserName", "")
			Me.AddInputItem("     Water cut", 1, 10, "txtWaterCut", "")
			Me.AddInputItem("     Water specific gravity", 1, 11, "txtWaterSPGR", "")
			Me.AddInputItem("     Well name", 1, 1, "txtWellName", "")
		End Sub

		Private Sub SelInput_Load(sender As Object, e As EventArgs)
			Try
				Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
				Me.myAL.Clear()
				Me.SFList.Clear()
				Me.AddAllItems()
				If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter(Me.Name)
					Util.WriteControlStrings(Me, Nothing)
					Util.CloseResourceWriter()
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in SelInput Load: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub cmdOK_Click(sender As Object, e As EventArgs)
			Me.cmdOK_Clicked(True)
		End Sub

		Private Sub cmdCancel_Click(sender As Object, e As EventArgs)
			Try
				RSWIN_DESC.FormFieldIndex = 0
				Me.bCancel = True
				Me.Close()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub lstFields_KeyPress(sender As Object, e As KeyPressEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(Strings.Asc(e.KeyChar))
			Debug.WriteLine(Conversions.ToString(CInt(num)) + " , " + Conversions.ToString(e.KeyChar))
			If num = 0S Then
				e.Handled = True
			End If
			If Me.sPrevChar = e.KeyChar Then
				Me.iCharCount += 1
			Else
				Me.iCharCount = 0
			End If
			If(num >= 97S And num <= 122S) Or (num >= 65S And num <= 90S) Then
				Me.SelectItemByFirstChar(CInt(num), Me.iCharCount)
			End If
			Me.sPrevChar = e.KeyChar
		End Sub

		Public Sub SelectItemByFirstChar(KeyAscii As Integer, iCharCount As Integer)
			Dim num As Integer = 0
			Dim text As String = Conversions.ToString(Strings.Chr(KeyAscii))
			Dim num2 As Integer = 0
			Dim num3 As Integer = Me.lstFields.Items.Count - 1
			For i As Integer = num2 To num3
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.lstFields.Items(i))
				Dim text2 As String = Conversions.ToString(NewLateBinding.LateGet(objectValue, Nothing, "trim", New Object(-1) {}, Nothing, Nothing, Nothing))
				If Operators.CompareString(text2.Substring(0, 1).ToLower(), text.ToLower(), False) = 0 Then
					If iCharCount = num Then
						Me.lstFields.SelectedItem = RuntimeHelpers.GetObjectValue(objectValue)
						Return
					End If
					num += 1
				Else
					num = 0
				End If
			Next
		End Sub

		Private Sub dlgSelectInput_Activated(sender As Object, e As EventArgs)
			Me.lstFields.SelectedIndex = 0
			Me.lstFields.Focus()
		End Sub

		Private Sub lstFields_Enter(sender As Object, e As EventArgs)
			Me.BringToFront()
		End Sub

		Private Sub cmdOK_Clicked(bClicked As Boolean)
			Try
				Dim flag As Boolean = False
				Try
					Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					If Me.MyParentFrm.ValidateActiveMDIChild(RSWIN_DESC.sCurrentFormName) Then
						If Me.lstFields.SelectedItem IsNot Nothing Then
							Try
								For Each obj As Object In Me.myAL
									Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
									Dim obj2 As Object = NewLateBinding.LateGet(objectValue, Nothing, "MenuDisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)
									If Operators.ConditionalCompareObjectEqual(obj2, Me.lstFields.SelectedItem, False) Then
										RSWIN_DESC.FldNum = Me.myAL.IndexOf(RuntimeHelpers.GetObjectValue(objectValue))
										Me.m_ControlName = Conversions.ToString(NewLateBinding.LateGet(objectValue, Nothing, "ControlName", New Object(-1) {}, Nothing, Nothing, Nothing))
										Me.m_TabName = Conversions.ToString(NewLateBinding.LateGet(objectValue, Nothing, "TabName", New Object(-1) {}, Nothing, Nothing, Nothing))
										Me.GetScrnNum(Me.m_ControlName, RSWIN_DESC.ScrnNum)
										flag = True
										Exit For
									End If
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
						End If
						If Not RSWIN_DESC.bRodStarD AndAlso (RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso (RSWIN_DESC.ScrnNum <> 1 And RSWIN_DESC.ScrnNum <> 2) Then
							MessageBox.Show("While in AI Mode only Well Info and Production Info data entry screens are required and accessible.")
						ElseIf flag Then
							Application.DoEvents()
							Me.bCancel = False
							Me.MyParentFrm.UnloadDlgSelectInput()
							If bClicked Then
								Me.Close()
							Else
								Me.Hide()
							End If
						Else
							Me.bCancel = True
							Application.DoEvents()
							Me.Close()
						End If
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub lstFields_DoubleClick(sender As Object, e As EventArgs)
			Me.cmdOK_Clicked(False)
		End Sub

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("Label")>
		Private _Label As Label

		<AccessedThroughProperty("lstFields")>
		Private _lstFields As ListBox

		Private Shared m_vb6FormDefInstance As dlgSelectInput

		Private Shared m_InitializingDefInstance As Boolean

		Private iCharCount As Integer

		Private sPrevChar As Char

		Private myAL As ArrayList

		Private m_InputScreen As String

		Private m_ControlName As String

		Private m_TabName As String

		Private m_bCancel As Boolean

		Private MyParentFrm As RODSTAR

		Private SFList As Hashtable
	End Class
End Namespace
