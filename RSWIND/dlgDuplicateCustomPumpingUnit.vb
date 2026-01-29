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
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgDuplicateCustomPumpingUnit
		Inherits Form

		Public Property TempPU1 As RSWIN_DESC.PUDataRec
			Get
				Return Me.m_TempPU1
			End Get
			Set(value As RSWIN_DESC.PUDataRec)
				Me.m_TempPU1 = value
			End Set
		End Property

		Public Property TempPU2 As RSWIN_DESC.PUDataRec
			Get
				Return Me.m_TempPU2
			End Get
			Set(value As RSWIN_DESC.PUDataRec)
				Me.m_TempPU2 = value
			End Set
		End Property

		Public Property UnitName As String
			Get
				Return Me.m_UnitName
			End Get
			Set(value As String)
				Me.m_UnitName = value
				Me.lblUnitName.Text = Me.m_UnitName
			End Set
		End Property

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
			AddHandler MyBase.Load, AddressOf Me.dlgDuplicateCustomPumpingUnit_Load
			Me.m_UnitName = ""
			Me.m_bUseFile = False
			Me.m_bUseSetup = False
			If dlgDuplicateCustomPumpingUnit.m_vb6FormDefInstance Is Nothing Then
				If dlgDuplicateCustomPumpingUnit.m_InitializingDefInstance Then
					dlgDuplicateCustomPumpingUnit.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgDuplicateCustomPumpingUnit.m_vb6FormDefInstance = Me
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

		Friend Overridable Property lblUnitName As Label
			Get
				Return Me._lblUnitName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblUnitName = value
			End Set
		End Property

		Friend Overridable Property RichTextBox1 As RichTextBox
			Get
				Return Me._RichTextBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._RichTextBox1 = value
			End Set
		End Property

		Public Shared Property DefInstance As dlgDuplicateCustomPumpingUnit
			Get
				If dlgDuplicateCustomPumpingUnit.m_vb6FormDefInstance Is Nothing OrElse dlgDuplicateCustomPumpingUnit.m_vb6FormDefInstance.IsDisposed Then
					dlgDuplicateCustomPumpingUnit.m_InitializingDefInstance = True
					dlgDuplicateCustomPumpingUnit.m_vb6FormDefInstance = New dlgDuplicateCustomPumpingUnit()
					dlgDuplicateCustomPumpingUnit.m_InitializingDefInstance = False
				End If
				Return dlgDuplicateCustomPumpingUnit.m_vb6FormDefInstance
			End Get
			Set(value As dlgDuplicateCustomPumpingUnit)
				dlgDuplicateCustomPumpingUnit.m_vb6FormDefInstance = value
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

		Private Sub dlgDuplicateCustomPumpingUnit_Load(eventSender As Object, eventArgs As EventArgs)
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
			Me.AssignRTBText()
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private Sub AssignRTBText()
			Try
				Dim text As String = "FROM FILE :" & vbTab & vbTab & vbTab & vbTab & vbTab & "FROM SETUP :" & vbCrLf
				Dim array As String() = New String(5) {}
				array(0) = text
				array(1) = "Manufacturer:" & vbTab
				Dim array2 As String() = array
				Dim num As Integer = 2
				Dim pudataRec As RSWIN_DESC.PUDataRec = Me.TempPU1
				array2(num) = pudataRec.Manuf.Trim()
				array(3) = vbTab & vbTab & vbTab
				Dim array3 As String() = array
				Dim num2 As Integer = 4
				Dim pudataRec2 As RSWIN_DESC.PUDataRec = Me.TempPU2
				array3(num2) = pudataRec2.Manuf.Trim()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Unit Name:" & vbTab
				Dim array4 As String() = array
				Dim num3 As Integer = 2
				pudataRec2 = Me.TempPU1
				array4(num3) = pudataRec2.UnitName.Trim()
				array(3) = vbTab & vbTab & vbTab
				Dim array5 As String() = array
				Dim num4 As Integer = 4
				pudataRec = Me.TempPU2
				array5(num4) = pudataRec.UnitName.Trim()
				array(5) = vbCrLf
				text = String.Concat(array)
				pudataRec = Me.TempPU1
				Dim pudataRec3 As RSWIN_DESC.PUDataRec
				If pudataRec.UnitType = 10S Then
					array = New String(5) {}
					array(0) = text
					array(1) = "Unit Designation:" & vbTab
					Dim array6 As String() = array
					Dim num5 As Integer = 2
					pudataRec3 = Me.TempPU1
					array6(num5) = pudataRec3.APIDesignation.Trim()
					array(3) = vbTab & vbTab & vbTab
					Dim array7 As String() = array
					Dim num6 As Integer = 4
					pudataRec2 = Me.TempPU2
					array7(num6) = pudataRec2.APIDesignation.Trim()
					array(5) = vbCrLf
					text = String.Concat(array)
				Else
					array = New String(5) {}
					array(0) = text
					array(1) = "API Designation:" & vbTab
					Dim array8 As String() = array
					Dim num7 As Integer = 2
					pudataRec = Me.TempPU1
					array8(num7) = pudataRec.APIDesignation.Trim()
					array(3) = vbTab & vbTab & vbTab
					Dim array9 As String() = array
					Dim num8 As Integer = 4
					pudataRec3 = Me.TempPU2
					array9(num8) = pudataRec3.APIDesignation.Trim()
					array(5) = vbCrLf
					text = String.Concat(array)
				End If
				array = New String(5) {}
				array(0) = text
				array(1) = "Unit Type:" & vbTab
				Dim array10 As String() = array
				Dim num9 As Integer = 2
				pudataRec = Me.TempPU1
				array10(num9) = pudataRec.UnitType.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array11 As String() = array
				Dim num10 As Integer = 4
				pudataRec3 = Me.TempPU2
				array11(num10) = pudataRec3.UnitType.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				Dim obj As Object = text + "Required Rotation:" + vbTab
				pudataRec = Me.TempPU1
				Dim obj2 As Object = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj, Interaction.IIf(pudataRec.RequiredRotation <> 0S, "true", "false")), vbTab), vbTab), vbTab), vbTab)
				pudataRec3 = Me.TempPU2
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(obj2, Interaction.IIf(pudataRec3.RequiredRotation <> 0S, "true", "false")), vbCrLf))
				Dim obj3 As Object = text + "Crank Rotation:" + vbTab
				pudataRec = Me.TempPU1
				Dim obj4 As Object = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj3, Interaction.IIf(pudataRec.CrankRotation = 1S, "CW", "CCW")), vbTab), vbTab), vbTab), vbTab)
				pudataRec3 = Me.TempPU2
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(obj4, Interaction.IIf(pudataRec3.CrankRotation = 1S, "CW", "CCW")), vbCrLf))
				array = New String(5) {}
				array(0) = text
				array(1) = "Crank Hole:" & vbTab
				Dim array12 As String() = array
				Dim num11 As Integer = 2
				pudataRec = Me.TempPU1
				array12(num11) = pudataRec.CrankHole.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array13 As String() = array
				Dim num12 As Integer = 4
				pudataRec3 = Me.TempPU2
				array13(num12) = pudataRec3.CrankHole.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Crank Holes:" & vbTab
				Dim array14 As String() = array
				Dim num13 As Integer = 2
				pudataRec = Me.TempPU1
				array14(num13) = pudataRec.CrankHoles.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array15 As String() = array
				Dim num14 As Integer = 4
				pudataRec3 = Me.TempPU2
				array15(num14) = pudataRec3.CrankHoles.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				pudataRec3 = Me.TempPU1
				If pudataRec3.CrankHoles >= 1S Then
					array = New String(5) {}
					array(0) = text
					array(1) = "Crank Radii(1):" & vbTab
					Dim array16 As String() = array
					Dim num15 As Integer = 2
					pudataRec2 = Me.TempPU1
					array16(num15) = pudataRec2.CrankRadii(0).ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array17 As String() = array
					Dim num16 As Integer = 4
					pudataRec = Me.TempPU2
					array17(num16) = pudataRec.CrankRadii(0).ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
				End If
				pudataRec3 = Me.TempPU1
				If pudataRec3.CrankHoles >= 2S Then
					array = New String(5) {}
					array(0) = text
					array(1) = "Crank Radii(2):" & vbTab
					Dim array18 As String() = array
					Dim num17 As Integer = 2
					pudataRec2 = Me.TempPU1
					array18(num17) = pudataRec2.CrankRadii(1).ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array19 As String() = array
					Dim num18 As Integer = 4
					pudataRec = Me.TempPU2
					array19(num18) = pudataRec.CrankRadii(1).ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
				End If
				pudataRec3 = Me.TempPU1
				If pudataRec3.CrankHoles >= 3S Then
					array = New String(5) {}
					array(0) = text
					array(1) = "Crank Radii(3):" & vbTab
					Dim array20 As String() = array
					Dim num19 As Integer = 2
					pudataRec2 = Me.TempPU1
					array20(num19) = pudataRec2.CrankRadii(2).ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array21 As String() = array
					Dim num20 As Integer = 4
					pudataRec = Me.TempPU2
					array21(num20) = pudataRec.CrankRadii(2).ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
				End If
				pudataRec3 = Me.TempPU1
				If pudataRec3.CrankHoles >= 4S Then
					array = New String(5) {}
					array(0) = text
					array(1) = "Crank Radii(4):" & vbTab
					Dim array22 As String() = array
					Dim num21 As Integer = 2
					pudataRec2 = Me.TempPU1
					array22(num21) = pudataRec2.CrankRadii(3).ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array23 As String() = array
					Dim num22 As Integer = 4
					pudataRec = Me.TempPU2
					array23(num22) = pudataRec.CrankRadii(3).ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
				End If
				pudataRec3 = Me.TempPU1
				If pudataRec3.CrankHoles >= 5S Then
					array = New String(5) {}
					array(0) = text
					array(1) = "Crank Radii(5):" & vbTab
					Dim array24 As String() = array
					Dim num23 As Integer = 2
					pudataRec2 = Me.TempPU1
					array24(num23) = pudataRec2.CrankRadii(4).ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array25 As String() = array
					Dim num24 As Integer = 4
					pudataRec = Me.TempPU2
					array25(num24) = pudataRec.CrankRadii(4).ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
				End If
				pudataRec3 = Me.TempPU1
				If pudataRec3.CrankHoles >= 1S Then
					array = New String(5) {}
					array(0) = text
					array(1) = "Strokes(1):" & vbTab
					Dim array26 As String() = array
					Dim num25 As Integer = 2
					pudataRec2 = Me.TempPU1
					array26(num25) = pudataRec2.Strokes(0).ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array27 As String() = array
					Dim num26 As Integer = 4
					pudataRec = Me.TempPU2
					array27(num26) = pudataRec.Strokes(0).ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
				End If
				pudataRec3 = Me.TempPU1
				If pudataRec3.CrankHoles >= 2S Then
					array = New String(5) {}
					array(0) = text
					array(1) = "Strokes(2):" & vbTab
					Dim array28 As String() = array
					Dim num27 As Integer = 2
					pudataRec2 = Me.TempPU1
					array28(num27) = pudataRec2.Strokes(1).ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array29 As String() = array
					Dim num28 As Integer = 4
					pudataRec = Me.TempPU2
					array29(num28) = pudataRec.Strokes(1).ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
				End If
				pudataRec3 = Me.TempPU1
				If pudataRec3.CrankHoles >= 3S Then
					array = New String(5) {}
					array(0) = text
					array(1) = "Strokes(3):" & vbTab
					Dim array30 As String() = array
					Dim num29 As Integer = 2
					pudataRec2 = Me.TempPU1
					array30(num29) = pudataRec2.Strokes(2).ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array31 As String() = array
					Dim num30 As Integer = 4
					pudataRec = Me.TempPU2
					array31(num30) = pudataRec.Strokes(2).ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
				End If
				pudataRec3 = Me.TempPU1
				If pudataRec3.CrankHoles >= 4S Then
					array = New String(5) {}
					array(0) = text
					array(1) = "Strokes(4):" & vbTab
					Dim array32 As String() = array
					Dim num31 As Integer = 2
					pudataRec2 = Me.TempPU1
					array32(num31) = pudataRec2.Strokes(3).ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array33 As String() = array
					Dim num32 As Integer = 4
					pudataRec = Me.TempPU2
					array33(num32) = pudataRec.Strokes(3).ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
				End If
				pudataRec3 = Me.TempPU1
				If pudataRec3.CrankHoles >= 5S Then
					array = New String(5) {}
					array(0) = text
					array(1) = "Strokes(5):" & vbTab
					Dim array34 As String() = array
					Dim num33 As Integer = 2
					pudataRec2 = Me.TempPU1
					array34(num33) = pudataRec2.Strokes(4).ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array35 As String() = array
					Dim num34 As Integer = 4
					pudataRec = Me.TempPU2
					array35(num34) = pudataRec.Strokes(4).ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
				End If
				array = New String(5) {}
				array(0) = text
				array(1) = "Dimension R:" & vbTab
				Dim array36 As String() = array
				Dim num35 As Integer = 2
				pudataRec = Me.TempPU1
				array36(num35) = pudataRec.R.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array37 As String() = array
				Dim num36 As Integer = 4
				pudataRec3 = Me.TempPU2
				array37(num36) = pudataRec3.R.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Dimension A:" & vbTab
				Dim array38 As String() = array
				Dim num37 As Integer = 2
				pudataRec = Me.TempPU1
				array38(num37) = pudataRec.A.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array39 As String() = array
				Dim num38 As Integer = 4
				pudataRec3 = Me.TempPU2
				array39(num38) = pudataRec3.A.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Dimension C:" & vbTab
				Dim array40 As String() = array
				Dim num39 As Integer = 2
				pudataRec = Me.TempPU1
				array40(num39) = pudataRec.C.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array41 As String() = array
				Dim num40 As Integer = 4
				pudataRec3 = Me.TempPU2
				array41(num40) = pudataRec3.C.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Dimension I:" & vbTab
				Dim array42 As String() = array
				Dim num41 As Integer = 2
				pudataRec = Me.TempPU1
				array42(num41) = pudataRec.I.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array43 As String() = array
				Dim num42 As Integer = 4
				pudataRec3 = Me.TempPU2
				array43(num42) = pudataRec3.I.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Dimension K:" & vbTab
				Dim array44 As String() = array
				Dim num43 As Integer = 2
				pudataRec = Me.TempPU1
				array44(num43) = pudataRec.K.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array45 As String() = array
				Dim num44 As Integer = 4
				pudataRec3 = Me.TempPU2
				array45(num44) = pudataRec3.K.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Dimension P:" & vbTab
				Dim array46 As String() = array
				Dim num45 As Integer = 2
				pudataRec = Me.TempPU1
				array46(num45) = pudataRec.P.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array47 As String() = array
				Dim num46 As Integer = 4
				pudataRec3 = Me.TempPU2
				array47(num46) = pudataRec3.P.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Dimension M:" & vbTab
				Dim array48 As String() = array
				Dim num47 As Integer = 2
				pudataRec = Me.TempPU1
				array48(num47) = pudataRec.M.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array49 As String() = array
				Dim num48 As Integer = 4
				pudataRec3 = Me.TempPU2
				array49(num48) = pudataRec3.M.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Dimension S:" & vbTab
				Dim array50 As String() = array
				Dim num49 As Integer = 2
				pudataRec = Me.TempPU1
				array50(num49) = pudataRec.S.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array51 As String() = array
				Dim num50 As Integer = 4
				pudataRec3 = Me.TempPU2
				array51(num50) = pudataRec3.S.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Dimension V0:" & vbTab
				Dim array52 As String() = array
				Dim num51 As Integer = 2
				pudataRec = Me.TempPU1
				array52(num51) = pudataRec.V0.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array53 As String() = array
				Dim num52 As Integer = 4
				pudataRec3 = Me.TempPU2
				array53(num52) = pudataRec3.V0.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				pudataRec3 = Me.TempPU1
				Dim flag As Boolean = pudataRec3.UnitType = 7S
				pudataRec = Me.TempPU1
				Dim pudataRec4 As RSWIN_DESC.PUDataRec
				If flag Or pudataRec.UnitType = 10S Then
					array = New String(5) {}
					array(0) = text
					array(1) = "Drum Diam Ratio:" & vbTab
					Dim array54 As String() = array
					Dim num53 As Integer = 2
					pudataRec4 = Me.TempPU1
					array54(num53) = pudataRec4.DrumDiamRatio.ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array55 As String() = array
					Dim num54 As Integer = 4
					pudataRec2 = Me.TempPU2
					array55(num54) = pudataRec2.DrumDiamRatio.ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
					array = New String(5) {}
					array(0) = text
					array(1) = "Sprocket Radius:" & vbTab
					Dim array56 As String() = array
					Dim num55 As Integer = 2
					pudataRec3 = Me.TempPU1
					array56(num55) = pudataRec3.SprocketRadius.ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array57 As String() = array
					Dim num56 As Integer = 4
					pudataRec4 = Me.TempPU2
					array57(num56) = pudataRec4.SprocketRadius.ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
					array = New String(5) {}
					array(0) = text
					array(1) = "Sprocket Distance:" & vbTab
					Dim array58 As String() = array
					Dim num57 As Integer = 2
					pudataRec3 = Me.TempPU1
					array58(num57) = pudataRec3.SprocketDistance.ToString()
					array(3) = vbTab & vbTab & vbTab & vbTab
					Dim array59 As String() = array
					Dim num58 As Integer = 4
					pudataRec4 = Me.TempPU2
					array59(num58) = pudataRec4.SprocketDistance.ToString()
					array(5) = vbCrLf
					text = String.Concat(array)
				End If
				array = New String(5) {}
				array(0) = text
				array(1) = "Unbalance:" & vbTab
				Dim array60 As String() = array
				Dim num59 As Integer = 2
				pudataRec3 = Me.TempPU1
				array60(num59) = pudataRec3.Unbalance.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array61 As String() = array
				Dim num60 As Integer = 4
				pudataRec4 = Me.TempPU2
				array61(num60) = pudataRec4.Unbalance.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Crank Offset:" & vbTab
				Dim array62 As String() = array
				Dim num61 As Integer = 2
				pudataRec3 = Me.TempPU1
				array62(num61) = pudataRec3.CrankOffset.ToString()
				array(3) = vbTab & vbTab & vbTab
				Dim array63 As String() = array
				Dim num62 As Integer = 4
				pudataRec4 = Me.TempPU2
				array63(num62) = pudataRec4.CrankOffset.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Structure Rating:" & vbTab
				Dim array64 As String() = array
				Dim num63 As Integer = 2
				pudataRec3 = Me.TempPU1
				array64(num63) = pudataRec3.StructRating.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array65 As String() = array
				Dim num64 As Integer = 4
				pudataRec4 = Me.TempPU2
				array65(num64) = pudataRec4.StructRating.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Gearbox Rating:" & vbTab
				Dim array66 As String() = array
				Dim num65 As Integer = 2
				pudataRec3 = Me.TempPU1
				array66(num65) = pudataRec3.GearboxRating.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array67 As String() = array
				Dim num66 As Integer = 4
				pudataRec4 = Me.TempPU2
				array67(num66) = pudataRec4.GearboxRating.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Max Stroke:" & vbTab
				Dim array68 As String() = array
				Dim num67 As Integer = 2
				pudataRec3 = Me.TempPU1
				array68(num67) = pudataRec3.MaxStroke.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array69 As String() = array
				Dim num68 As Integer = 4
				pudataRec4 = Me.TempPU2
				array69(num68) = pudataRec4.MaxStroke.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(5) {}
				array(0) = text
				array(1) = "Art. Inertia:" & vbTab
				Dim array70 As String() = array
				Dim num69 As Integer = 2
				pudataRec3 = Me.TempPU1
				array70(num69) = pudataRec3.ArtInertia.ToString()
				array(3) = vbTab & vbTab & vbTab & vbTab
				Dim array71 As String() = array
				Dim num70 As Integer = 4
				pudataRec4 = Me.TempPU2
				array71(num70) = pudataRec4.ArtInertia.ToString()
				array(5) = vbCrLf
				text = String.Concat(array)
				array = New String(4) {}
				array(0) = text
				array(1) = "Other Info:" & vbTab
				Dim array72 As String() = array
				Dim num71 As Integer = 2
				pudataRec3 = Me.TempPU1
				array72(num71) = pudataRec3.OtherInfo.Trim()
				array(3) = vbTab & vbTab
				Dim array73 As String() = array
				Dim num72 As Integer = 4
				pudataRec4 = Me.TempPU2
				array73(num72) = pudataRec4.OtherInfo.Trim()
				text = String.Concat(array)
				Me.RichTextBox1.Text = text
			Catch ex As Exception
			End Try
		End Sub

		Private m_TempPU1 As RSWIN_DESC.PUDataRec

		Private m_TempPU2 As RSWIN_DESC.PUDataRec

		Private m_UnitName As String

		Private m_bUseFile As Boolean

		Private m_bUseSetup As Boolean

		<AccessedThroughProperty("cmdUseSetup")>
		Private _cmdUseSetup As Button

		<AccessedThroughProperty("cmdUseFile")>
		Private _cmdUseFile As Button

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

		<AccessedThroughProperty("lblUnitName")>
		Private _lblUnitName As Label

		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox

		Private Shared m_vb6FormDefInstance As dlgDuplicateCustomPumpingUnit

		Private Shared m_InitializingDefInstance As Boolean
	End Class
End Namespace
