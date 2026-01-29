Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgCustomUnitComparison
		Inherits Form

		Friend Overridable Property rbtUseLocalUnit As RadioButton
			Get
				Return Me._rbtUseLocalUnit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbtUseLocalUnit = value
			End Set
		End Property

		Friend Overridable Property rbtUseBoth As RadioButton
			Get
				Return Me._rbtUseBoth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbtUseBoth = value
			End Set
		End Property

		Friend Overridable Property rbtUseServerUnit As RadioButton
			Get
				Return Me._rbtUseServerUnit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbtUseServerUnit = value
			End Set
		End Property

		Public Overridable Property ulgUnits As UltraGrid
			Get
				Return Me._ulgUnits
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As InitializeLayoutEventHandler = AddressOf Me.ulgUnits_InitializeLayout
				If Me._ulgUnits IsNot Nothing Then
					RemoveHandler Me._ulgUnits.InitializeLayout, value2
				End If
				Me._ulgUnits = value
				If Me._ulgUnits IsNot Nothing Then
					AddHandler Me._ulgUnits.InitializeLayout, value2
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgCustomUnitComparison_Load
			AddHandler MyBase.Activated, AddressOf Me.dlgCustomUnitComparison_Activated
			Dim point As Point = New Point(0, 0)
			Me.StartPoint = point
			Me.m_bUseBothUnits = False
			Me.m_bUseLocalUnit = False
			Me.m_bUseServerUnit = False
			If dlgCustomUnitComparison.m_vb6FormDefInstance Is Nothing Then
				If dlgCustomUnitComparison.m_InitializingDefInstance Then
					dlgCustomUnitComparison.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgCustomUnitComparison.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

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

		Friend Overridable Property Panel1 As Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
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

		Public Shared Property DefInstance As dlgCustomUnitComparison
			Get
				If dlgCustomUnitComparison.m_vb6FormDefInstance Is Nothing OrElse dlgCustomUnitComparison.m_vb6FormDefInstance.IsDisposed Then
					dlgCustomUnitComparison.m_InitializingDefInstance = True
					dlgCustomUnitComparison.m_vb6FormDefInstance = New dlgCustomUnitComparison()
					dlgCustomUnitComparison.m_InitializingDefInstance = False
				End If
				Return dlgCustomUnitComparison.m_vb6FormDefInstance
			End Get
			Set(value As dlgCustomUnitComparison)
				dlgCustomUnitComparison.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property LocalUnit As RSWIN_DESC.PUDataRec
			Get
				Return Me.m_LocalUnit
			End Get
			Set(value As RSWIN_DESC.PUDataRec)
				Me.m_LocalUnit = value
			End Set
		End Property

		Public Property ServerUnit As RSWIN_DESC.PUDataRec
			Get
				Return Me.m_ServerUnit
			End Get
			Set(value As RSWIN_DESC.PUDataRec)
				Me.m_ServerUnit = value
			End Set
		End Property

		Public Property bUseBothUnits As Boolean
			Get
				Return Me.m_bUseBothUnits
			End Get
			Set(value As Boolean)
				Me.m_bUseBothUnits = value
			End Set
		End Property

		Public Property bUseLocalUnit As Boolean
			Get
				Return Me.m_bUseLocalUnit
			End Get
			Set(value As Boolean)
				Me.m_bUseLocalUnit = value
			End Set
		End Property

		Public Property bUseServerUnit As Boolean
			Get
				Return Me.m_bUseServerUnit
			End Get
			Set(value As Boolean)
				Me.m_bUseServerUnit = value
			End Set
		End Property

		Private Sub dlgCustomUnitComparison_Load(eventSender As Object, eventArgs As EventArgs)
			RSWIN.GetMeasurementUnit()
			Me.ResetClock()
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
			Me.AssignUnitData()
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Public Function GetUnitType(iUnitType As Integer) As String
			Dim text As String = ""
			Dim result As String
			Try
				If iUnitType = 1 Then
					text = "Conventional"
				ElseIf iUnitType = 2 Then
					text = "Enhanced"
				ElseIf iUnitType = 4 Then
					text = "Low Profile"
				ElseIf iUnitType = 5 Then
					text = "MarkII"
				ElseIf iUnitType = 6 Then
					text = "Air Balanced"
				ElseIf iUnitType = 7 Then
					text = "Long Stroke"
				ElseIf iUnitType = 8 Then
					text = "Beam Balanced"
				ElseIf iUnitType = 9 Then
					text = "Belt Low Profile"
				ElseIf iUnitType = 10 Then
					text = "Hydraulic"
				ElseIf iUnitType = 11 Then
					text = "Combination Beam Crank"
				ElseIf iUnitType = 1 Then
					text = ""
				End If
				result = text
			Catch ex As Exception
				result = "Conventional"
			End Try
			Return result
		End Function

		Private Sub AssignUnitData()
			Dim flag As Boolean = RSWIN_DESC.SETUP_MeasurementSystem = 1
			Try
				Me.ulgUnits.DataSource = Nothing
				Me.InitUnitsDataset(Me.mdsUnits)
				Dim unitType As Integer = CInt(Me.LocalUnit.UnitType)
				Dim dataRow As DataRow = Me.mdsUnits.Tables(0).NewRow()
				dataRow(0) = "Manufacturer "
				dataRow(1) = Me.LocalUnit.Manuf
				dataRow(2) = Me.ServerUnit.Manuf
				Me.mdsUnits.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsUnits.Tables(0).NewRow()
				dataRow(0) = "API Designation "
				dataRow(1) = Me.LocalUnit.APIDesignation
				dataRow(2) = Me.ServerUnit.APIDesignation
				Me.mdsUnits.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsUnits.Tables(0).NewRow()
				dataRow(0) = "Unit Name "
				dataRow(1) = Me.LocalUnit.UnitName
				dataRow(2) = Me.ServerUnit.UnitName
				Me.mdsUnits.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsUnits.Tables(0).NewRow()
				dataRow(0) = "Other Info "
				dataRow(1) = Me.LocalUnit.OtherInfo
				dataRow(2) = Me.ServerUnit.OtherInfo
				Me.mdsUnits.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsUnits.Tables(0).NewRow()
				dataRow(0) = "Unit Type "
				dataRow(1) = Me.GetUnitType(CInt(Me.LocalUnit.UnitType))
				dataRow(2) = Me.GetUnitType(CInt(Me.ServerUnit.UnitType))
				Me.mdsUnits.Tables(0).Rows.Add(dataRow)
				If Me.LocalUnit.UnitType = Me.ServerUnit.UnitType Then
					If unitType <> 10 Then
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Required Rotation "
						dataRow(1) = RuntimeHelpers.GetObjectValue(Interaction.IIf(Me.LocalUnit.RequiredRotation <> 0S, "True", "False"))
						dataRow(2) = RuntimeHelpers.GetObjectValue(Interaction.IIf(Me.ServerUnit.RequiredRotation <> 0S, "True", "False"))
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Crank Rotation "
						dataRow(1) = RuntimeHelpers.GetObjectValue(Interaction.IIf(Me.LocalUnit.CrankRotation = 1S, "CW", "CCW"))
						dataRow(2) = RuntimeHelpers.GetObjectValue(Interaction.IIf(Me.ServerUnit.CrankRotation = 1S, "CW", "CCW"))
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					End If
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					dataRow(0) = "# Crank Holes "
					dataRow(1) = Me.LocalUnit.CrankHoles
					dataRow(2) = Me.ServerUnit.CrankHoles
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					Dim crankHoles As Integer
					If Me.LocalUnit.CrankHoles > Me.ServerUnit.CrankHoles Then
						crankHoles = CInt(Me.LocalUnit.CrankHoles)
					Else
						crankHoles = CInt(Me.ServerUnit.CrankHoles)
					End If
					Dim num As Integer = 1
					Dim num2 As Integer = crankHoles
					Dim text As String
					For i As Integer = num To num2
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow2 As DataRow = dataRow
						Dim columnIndex As Integer = 0
						text = "Crank Radii #" + i.ToString().Trim() + " (^) "
						dataRow2(columnIndex) = CtrlUI.MakeUnitsLabel(text, "c", flag)
						dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.CrankRadii(i - 1), "c", flag)
						dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.CrankRadii(i - 1), "c", flag)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					Next
					Dim num3 As Integer = 1
					Dim num4 As Integer = crankHoles
					For i As Integer = num3 To num4
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow3 As DataRow = dataRow
						Dim columnIndex2 As Integer = 0
						text = "Strokes #" + i.ToString().Trim() + " (^) "
						dataRow3(columnIndex2) = CtrlUI.MakeUnitsLabel(text, "c", flag)
						dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.Strokes(i - 1), "c", flag)
						dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.Strokes(i - 1), "c", flag)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					Next
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					Dim dataRow4 As DataRow = dataRow
					Dim columnIndex3 As Integer = 0
					text = "KinematicStroke (^) "
					dataRow4(columnIndex3) = CtrlUI.MakeUnitsLabel(text, "c", flag)
					dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.KinematicStroke, "c", flag)
					dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.KinematicStroke, "c", flag)
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					Dim dataRow5 As DataRow = dataRow
					Dim columnIndex4 As Integer = 0
					text = "R (^) "
					dataRow5(columnIndex4) = CtrlUI.MakeUnitsLabel(text, "c", flag)
					dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.R, "c", flag)
					dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.R, "c", flag)
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					If unitType <> 7 And unitType <> 10 And unitType <> 5 And unitType <> 6 And unitType <> 9 Then
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow6 As DataRow = dataRow
						Dim columnIndex5 As Integer = 0
						text = "A (^) "
						dataRow6(columnIndex5) = CtrlUI.MakeUnitsLabel(text, "c", flag)
						dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.A, "c", flag)
						dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.A, "c", flag)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						If unitType = 9 Then
							dataRow = Me.mdsUnits.Tables(0).NewRow()
							Dim dataRow7 As DataRow = dataRow
							Dim columnIndex6 As Integer = 0
							text = "D (^) "
							dataRow7(columnIndex6) = CtrlUI.MakeUnitsLabel(text, "c", flag)
							dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.C, "c", flag)
							dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.C, "c", flag)
							Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						Else
							dataRow = Me.mdsUnits.Tables(0).NewRow()
							Dim dataRow8 As DataRow = dataRow
							Dim columnIndex7 As Integer = 0
							text = "C (^) "
							dataRow8(columnIndex7) = CtrlUI.MakeUnitsLabel(text, "c", flag)
							dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.C, "c", flag)
							dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.C, "c", flag)
							Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						End If
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow9 As DataRow = dataRow
						Dim columnIndex8 As Integer = 0
						text = "I (^) "
						dataRow9(columnIndex8) = CtrlUI.MakeUnitsLabel(text, "c", flag)
						dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.I, "c", flag)
						dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.I, "c", flag)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow10 As DataRow = dataRow
						Dim columnIndex9 As Integer = 0
						text = "K (^) "
						dataRow10(columnIndex9) = CtrlUI.MakeUnitsLabel(text, "c", flag)
						dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.K, "c", flag)
						dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.K, "c", flag)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						If unitType <> 9 Then
							dataRow = Me.mdsUnits.Tables(0).NewRow()
							Dim dataRow11 As DataRow = dataRow
							Dim columnIndex10 As Integer = 0
							text = "P (^) "
							dataRow11(columnIndex10) = CtrlUI.MakeUnitsLabel(text, "c", flag)
							dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.P, "c", flag)
							dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.P, "c", flag)
							Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						End If
					End If
					If unitType = 6 Then
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow12 As DataRow = dataRow
						Dim columnIndex11 As Integer = 0
						text = "M (^) "
						dataRow12(columnIndex11) = CtrlUI.MakeUnitsLabel(text, "i", flag)
						dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.M, "i", flag)
						dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.M, "i", flag)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow13 As DataRow = dataRow
						Dim columnIndex12 As Integer = 0
						text = "S (^) "
						dataRow13(columnIndex12) = CtrlUI.MakeUnitsLabel(text, "P", flag)
						dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.S, "P", flag)
						dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.S, "P", flag)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow14 As DataRow = dataRow
						Dim columnIndex13 As Integer = 0
						text = "V0 (^) "
						dataRow14(columnIndex13) = CtrlUI.MakeUnitsLabel(text, "I", flag)
						dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.V0, "I", flag)
						dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.V0, "I", flag)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					End If
					If unitType = 7 Or unitType = 10 Then
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Drum. Diam. Ratio "
						dataRow(1) = Me.LocalUnit.DrumDiamRatio
						dataRow(2) = Me.ServerUnit.DrumDiamRatio
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow15 As DataRow = dataRow
						Dim columnIndex14 As Integer = 0
						text = "Sprocket Radius (^) "
						dataRow15(columnIndex14) = CtrlUI.MakeUnitsLabel(text, "m", flag)
						dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.SprocketRadius, "m", flag)
						dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.SprocketRadius, "m", flag)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow16 As DataRow = dataRow
						Dim columnIndex15 As Integer = 0
						text = "Sprocket Distance (^) "
						dataRow16(columnIndex15) = CtrlUI.MakeUnitsLabel(text, "c", flag)
						dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.SprocketDistance, "c", flag)
						dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.SprocketDistance, "c", flag)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow17 As DataRow = dataRow
						Dim columnIndex16 As Integer = 0
						text = "Pitman arm length (^) "
						dataRow17(columnIndex16) = CtrlUI.MakeUnitsLabel(text, "c", flag)
						dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.P, "c", flag)
						dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.P, "c", flag)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					End If
					If unitType <> 6 And unitType <> 7 And unitType <> 10 And unitType <> 9 Then
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow18 As DataRow = dataRow
						Dim columnIndex17 As Integer = 0
						text = "Unbalance (^) "
						dataRow18(columnIndex17) = CtrlUI.MakeUnitsLabel(text, "l", flag)
						dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.Unbalance, "l", flag)
						dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.Unbalance, "l", flag)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Crank Offset "
						dataRow(1) = Me.LocalUnit.CrankOffset
						dataRow(2) = Me.ServerUnit.CrankOffset
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					End If
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					Dim dataRow19 As DataRow = dataRow
					Dim columnIndex18 As Integer = 0
					text = "Struct Rating (^) "
					dataRow19(columnIndex18) = CtrlUI.MakeUnitsLabel(text, "h", flag)
					dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.StructRating, "h", flag)
					dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.StructRating, "h", flag)
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					Dim dataRow20 As DataRow = dataRow
					Dim columnIndex19 As Integer = 0
					text = "Gearbox Rating (^) "
					dataRow20(columnIndex19) = CtrlUI.MakeUnitsLabel(text, "h", flag)
					dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.GearboxRating, "h", flag)
					dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.GearboxRating, "h", flag)
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					Dim dataRow21 As DataRow = dataRow
					Dim columnIndex20 As Integer = 0
					text = "Max. Stroke (^) "
					dataRow21(columnIndex20) = CtrlUI.MakeUnitsLabel(text, "c", flag)
					dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.MaxStroke, "c", flag)
					dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.MaxStroke, "c", flag)
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					Dim dataRow22 As DataRow = dataRow
					Dim columnIndex21 As Integer = 0
					text = "Art. Inertia (^) "
					dataRow22(columnIndex21) = CtrlUI.MakeUnitsLabel(text, "N", flag)
					dataRow(1) = CtrlUI.fConvertValue(Me.LocalUnit.ArtInertia, "N", flag)
					dataRow(2) = CtrlUI.fConvertValue(Me.ServerUnit.ArtInertia, "N", flag)
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
				End If
				Me.ulgUnits.DataSource = Me.mdsUnits
				Me.ulgUnits.Rows.Refresh(RefreshRow.RefreshDisplay, True)
				Me.ulgUnits.Visible = True
				Me.SetGridColors()
				Me.bUseServerUnit = False
				Me.bUseLocalUnit = False
				Me.bUseBothUnits = False
				Try
					If Screen.PrimaryScreen.Bounds.Height < 800 Or Screen.PrimaryScreen.Bounds.Width < 1100 Then
						Me.AutoScroll = True
						Dim startPoint As Object = Me.StartPoint
						Dim point As Point
						Me.AutoScrollPosition = If((startPoint IsNot Nothing), CType(startPoint, Point), point)
						Me._SSPanel_0.AutoScroll = True
						Dim sspanel_ As ScrollableControl = Me._SSPanel_0
						Dim startPoint2 As Object = Me.StartPoint
						sspanel_.AutoScrollPosition = If((startPoint2 IsNot Nothing), CType(startPoint2, Point), point)
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub AssignUnitData_old()
			' The following expression was wrapped in a checked-statement
			Try
				Me.ulgUnits.DataSource = Nothing
				Me.InitUnitsDataset(Me.mdsUnits)
				Dim unitType As Integer = CInt(Me.LocalUnit.UnitType)
				Dim dataRow As DataRow = Me.mdsUnits.Tables(0).NewRow()
				dataRow(0) = "Manufacturer "
				dataRow(1) = Me.LocalUnit.Manuf
				dataRow(2) = Me.ServerUnit.Manuf
				Me.mdsUnits.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsUnits.Tables(0).NewRow()
				dataRow(0) = "API Designation "
				dataRow(1) = Me.LocalUnit.APIDesignation
				dataRow(2) = Me.ServerUnit.APIDesignation
				Me.mdsUnits.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsUnits.Tables(0).NewRow()
				dataRow(0) = "Unit Name "
				dataRow(1) = Me.LocalUnit.UnitName
				dataRow(2) = Me.ServerUnit.UnitName
				Me.mdsUnits.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsUnits.Tables(0).NewRow()
				dataRow(0) = "Other Info "
				dataRow(1) = Me.LocalUnit.OtherInfo
				dataRow(2) = Me.ServerUnit.OtherInfo
				Me.mdsUnits.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsUnits.Tables(0).NewRow()
				dataRow(0) = "Unit Type "
				dataRow(1) = Me.GetUnitType(CInt(Me.LocalUnit.UnitType))
				dataRow(2) = Me.GetUnitType(CInt(Me.ServerUnit.UnitType))
				Me.mdsUnits.Tables(0).Rows.Add(dataRow)
				If Me.LocalUnit.UnitType = Me.ServerUnit.UnitType Then
					If unitType <> 10 Then
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Required Rotation "
						dataRow(1) = RuntimeHelpers.GetObjectValue(Interaction.IIf(Me.LocalUnit.RequiredRotation <> 0S, "True", "False"))
						dataRow(2) = RuntimeHelpers.GetObjectValue(Interaction.IIf(Me.ServerUnit.RequiredRotation <> 0S, "True", "False"))
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Crank Rotation "
						dataRow(1) = RuntimeHelpers.GetObjectValue(Interaction.IIf(Me.LocalUnit.CrankRotation = 1S, "CW", "CCW"))
						dataRow(2) = RuntimeHelpers.GetObjectValue(Interaction.IIf(Me.ServerUnit.CrankRotation = 1S, "CW", "CCW"))
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					End If
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					dataRow(0) = "# Crank Holes "
					dataRow(1) = Me.LocalUnit.CrankHoles
					dataRow(2) = Me.ServerUnit.CrankHoles
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					Dim crankHoles As Integer
					If Me.LocalUnit.CrankHoles > Me.ServerUnit.CrankHoles Then
						crankHoles = CInt(Me.LocalUnit.CrankHoles)
					Else
						crankHoles = CInt(Me.ServerUnit.CrankHoles)
					End If
					Dim num As Integer = 1
					Dim num2 As Integer = crankHoles
					For i As Integer = num To num2
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Crank Radii(" + i.ToString().Trim() + ") "
						dataRow(1) = Me.LocalUnit.CrankRadii(i - 1)
						dataRow(2) = Me.ServerUnit.CrankRadii(i - 1)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					Next
					Dim num3 As Integer = 1
					Dim num4 As Integer = crankHoles
					For i As Integer = num3 To num4
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Strokes(0) "
						dataRow(1) = Me.LocalUnit.Strokes(i - 1)
						dataRow(2) = Me.ServerUnit.Strokes(i - 1)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					Next
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					dataRow(0) = "KinematicStroke "
					dataRow(1) = Me.LocalUnit.KinematicStroke
					dataRow(2) = Me.ServerUnit.KinematicStroke
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					dataRow(0) = "R "
					dataRow(1) = Me.LocalUnit.R
					dataRow(2) = Me.ServerUnit.R
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					If unitType <> 7 And unitType <> 10 And unitType <> 5 And unitType <> 6 And unitType <> 9 Then
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						Dim dataRow2 As DataRow = dataRow
						Dim columnIndex As Integer = 0
						Dim w As Object = 2
						Dim text As String = "A "
						Dim a As Single = Me.LocalUnit.A
						Dim in__CM As Single = RSWIN_DESC.IN__CM
						Dim text2 As String = "#.0"
						Dim text3 As String = "#.0"
						dataRow2(columnIndex) = Me.MkSummEM(w, text, a, in__CM, RSWIN_DESC.ins, text2, RSWIN_DESC.cm, text3, 1, True, False)
						Dim dataRow3 As DataRow = dataRow
						Dim columnIndex2 As Integer = 1
						Dim w2 As Object = 0
						text3 = ""
						Dim a2 As Single = Me.LocalUnit.A
						Dim in__CM2 As Single = RSWIN_DESC.IN__CM
						text2 = "#.0"
						text = "#.0"
						dataRow3(columnIndex2) = Me.MkSummEM(w2, text3, a2, in__CM2, RSWIN_DESC.ins, text2, RSWIN_DESC.cm, text, 1, False, True)
						Dim dataRow4 As DataRow = dataRow
						Dim columnIndex3 As Integer = 2
						Dim w3 As Object = 0
						text3 = ""
						Dim a3 As Single = Me.ServerUnit.A
						Dim in__CM3 As Single = RSWIN_DESC.IN__CM
						text2 = "#.0"
						text = "#.0"
						dataRow4(columnIndex3) = Me.MkSummEM(w3, text3, a3, in__CM3, RSWIN_DESC.ins, text2, RSWIN_DESC.cm, text, 1, False, True)
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						If unitType = 9 Then
							dataRow = Me.mdsUnits.Tables(0).NewRow()
							dataRow(0) = "D "
							dataRow(1) = Me.LocalUnit.C
							dataRow(2) = Me.ServerUnit.C
							Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						Else
							dataRow = Me.mdsUnits.Tables(0).NewRow()
							dataRow(0) = "C "
							dataRow(1) = Me.LocalUnit.C
							dataRow(2) = Me.ServerUnit.C
							Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						End If
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "I "
						dataRow(1) = Me.LocalUnit.I
						dataRow(2) = Me.ServerUnit.I
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "K "
						dataRow(1) = Me.LocalUnit.K
						dataRow(2) = Me.ServerUnit.K
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						If unitType <> 9 Then
							dataRow = Me.mdsUnits.Tables(0).NewRow()
							dataRow(0) = "P "
							dataRow(1) = Me.LocalUnit.P
							dataRow(2) = Me.ServerUnit.P
							Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						End If
					End If
					If unitType <> 6 Then
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "M "
						dataRow(1) = Me.LocalUnit.M
						dataRow(2) = Me.ServerUnit.M
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "S "
						dataRow(1) = Me.LocalUnit.S
						dataRow(2) = Me.ServerUnit.S
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "V0 "
						dataRow(1) = Me.LocalUnit.V0
						dataRow(2) = Me.ServerUnit.V0
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					End If
					If unitType = 7 And unitType = 10 Then
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Drum. Diam. Ratio "
						dataRow(1) = Me.LocalUnit.DrumDiamRatio
						dataRow(2) = Me.ServerUnit.DrumDiamRatio
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Sprocket Radius "
						dataRow(1) = Me.LocalUnit.SprocketRadius
						dataRow(2) = Me.ServerUnit.SprocketRadius
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Sprocket Distance "
						dataRow(1) = Me.LocalUnit.SprocketDistance
						dataRow(2) = Me.ServerUnit.SprocketDistance
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Pitman arm length "
						dataRow(1) = Me.LocalUnit.P
						dataRow(2) = Me.ServerUnit.P
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					End If
					If unitType <> 6 And unitType <> 7 And unitType <> 10 And unitType <> 9 Then
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Unbalance "
						dataRow(1) = Me.LocalUnit.Unbalance
						dataRow(2) = Me.ServerUnit.Unbalance
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsUnits.Tables(0).NewRow()
						dataRow(0) = "Crank Offset "
						dataRow(1) = Me.LocalUnit.CrankOffset
						dataRow(2) = Me.ServerUnit.CrankOffset
						Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					End If
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					dataRow(0) = "Struct Rating "
					dataRow(1) = Me.LocalUnit.StructRating
					dataRow(2) = Me.ServerUnit.StructRating
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					dataRow(0) = "Gearbox Rating "
					dataRow(1) = Me.LocalUnit.GearboxRating
					dataRow(2) = Me.ServerUnit.GearboxRating
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					dataRow(0) = "Max. Stroke "
					dataRow(1) = Me.LocalUnit.MaxStroke
					dataRow(2) = Me.ServerUnit.MaxStroke
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsUnits.Tables(0).NewRow()
					dataRow(0) = "Art. Inertia "
					dataRow(1) = Me.LocalUnit.ArtInertia
					dataRow(2) = Me.ServerUnit.ArtInertia
					Me.mdsUnits.Tables(0).Rows.Add(dataRow)
				End If
				Me.ulgUnits.DataSource = Me.mdsUnits
				Me.ulgUnits.Rows.Refresh(RefreshRow.RefreshDisplay, True)
				Me.ulgUnits.Visible = True
				Me.SetGridColors()
				Me.bUseServerUnit = False
				Me.bUseLocalUnit = False
				Me.bUseBothUnits = False
				Try
					If Screen.PrimaryScreen.Bounds.Height < 800 Or Screen.PrimaryScreen.Bounds.Width < 1100 Then
						Me.AutoScroll = True
						Dim startPoint As Object = Me.StartPoint
						Dim point As Point
						Me.AutoScrollPosition = If((startPoint IsNot Nothing), CType(startPoint, Point), point)
						Me._SSPanel_0.AutoScroll = True
						Dim sspanel_ As ScrollableControl = Me._SSPanel_0
						Dim startPoint2 As Object = Me.StartPoint
						sspanel_.AutoScrollPosition = If((startPoint2 IsNot Nothing), CType(startPoint2, Point), point)
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub cmdOK_Click(sender As Object, e As EventArgs)
			Me.bUseServerUnit = False
			Me.bUseLocalUnit = False
			Me.bUseBothUnits = False
			If Me.rbtUseLocalUnit.Checked Then
				Me.bUseLocalUnit = True
			ElseIf Me.rbtUseServerUnit.Checked Then
				Me.bUseServerUnit = True
			ElseIf Me.rbtUseBoth.Checked Then
				Me.bUseBothUnits = True
			End If
			Me.Close()
		End Sub

		Private Sub ulgUnits_InitializeLayout(eventSender As Object, eventArgs As InitializeLayoutEventArgs)
			Try
				Dim layout As UltraGridLayout = eventArgs.Layout
				layout.TabNavigation = TabNavigation.NextCell
				Dim ultraGridBand As UltraGridBand = layout.Bands(0)
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns(0)
				ultraGridColumn.Header.Caption = "Dimension Name"
				ultraGridColumn.Width = 200
				Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns(1)
				ultraGridColumn2.Header.Caption = "Local Value"
				ultraGridColumn2.Width = 200
				Dim ultraGridColumn3 As UltraGridColumn = ultraGridBand.Columns(2)
				ultraGridColumn3.Header.Caption = "Server Value"
				ultraGridColumn3.Width = 200
				ultraGridColumn3.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGrid As UltraGrid = Me.ulgUnits
				Try
					ultraGrid.ActiveRow = ultraGrid.GetRow(ChildRow.First)
				Catch ex As Exception
				End Try
				Dim override As UltraGridOverride = ultraGrid.DisplayLayout.Override
				override.AllowColMoving = AllowColMoving.NotAllowed
				override.AllowColSizing = AllowColSizing.None
				override.AllowColSwapping = AllowColSwapping.NotAllowed
				override.BorderStyleCell = UIElementBorderStyle.InsetSoft
				override.BorderStyleRow = UIElementBorderStyle.RaisedSoft
				override.RowSelectors = DefaultableBoolean.[False]
				override.RowSizing = RowSizing.Fixed
				override.ActiveRowAppearance.BorderColor = SystemColors.Highlight
				override.ActiveRowAppearance.BorderColor3DBase = SystemColors.Highlight
				ultraGrid = Nothing
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub InitUnitsDataset(ByRef mdsUnits As DataSet)
			Try
				mdsUnits = Nothing
				mdsUnits = New DataSet("Units")
				Dim dataTable As DataTable = New DataTable("Units")
				Dim dataColumn As DataColumn = New DataColumn("Dimension Name", GetType(String))
				dataColumn.AllowDBNull = True
				dataTable.Columns.Add(dataColumn)
				Dim dataColumn2 As DataColumn = New DataColumn("Local Value", GetType(String))
				dataColumn2.AllowDBNull = True
				dataTable.Columns.Add(dataColumn2)
				Dim dataColumn3 As DataColumn = New DataColumn("Server Value", GetType(String))
				dataColumn3.AllowDBNull = True
				dataTable.Columns.Add(dataColumn3)
				mdsUnits.Tables.Add(dataTable)
				mdsUnits.Tables(0).Clear()
			Catch ex As Exception
				MessageBox.Show("Error in InitUnitsDataset: " + ex.Message)
			End Try
		End Sub

		Private Sub SetGridColors()
			Try
				Dim ultraGridRow As UltraGridRow = Me.ulgUnits.GetRow(ChildRow.First)
				While ultraGridRow IsNot Nothing
					If Operators.ConditionalCompareObjectEqual(ultraGridRow.Cells("Local Value").Value, ultraGridRow.Cells("Server Value").Value, False) Then
						ultraGridRow.Cells("Local Value").Appearance.BackColor = Color.LightGreen
						ultraGridRow.Cells("Server Value").Appearance.BackColor = Color.LightGreen
					Else
						ultraGridRow.Cells("Local Value").Appearance.BackColor = Color.LightBlue
						ultraGridRow.Cells("Server Value").Appearance.BackColor = Color.LightBlue
					End If
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
					Else
						ultraGridRow = Nothing
					End If
				End While
			Catch ex As Exception
			End Try
		End Sub

		Private Sub dlgCustomUnitComparison_Activated(sender As Object, e As EventArgs)
			RSWIN.GetMeasurementUnit()
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

		Public Function MkSummEM(W As Object, ByRef Label As String, v As Single, EtoM As Single, ByRef EU As String, ByRef EFmt As String, ByRef MU As String, ByRef MFmt As String, cUnits As Object, Optional bShowLabelOnly As Boolean = False, Optional bShowValueOnly As Boolean = False) As String
			Dim num As Short
			Select Case RSWIN_DESC.SETUP_MeasurementSystem
				Case 1
					num = 0S
				Case 2
					num = Conversions.ToShort(Operators.CompareObjectEqual(cUnits, 3, False))
				Case 3
					num = -1S
			End Select
			Dim str As String = ""
			Dim text As String
			If num <> 0S Then
				If Strings.Len(MU) > 0 Then
					str = " (" + MU + ")"
				End If
				v *= EtoM
				text = MFmt
			Else
				If Strings.Len(EU) > 0 Then
					str = " (" + EU + ")"
				End If
				text = EFmt
			End If
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(W)
			Dim text2 As String = Label + str + ":"
			Return Me.MkSumm(objectValue, text2, v, text, bShowLabelOnly, bShowValueOnly)
		End Function

		Public Function MkSumm(W As Object, ByRef L As String, Value As Single, ByRef Fmt As String, Optional bShowLabelOnly As Boolean = False, Optional bShowValueOnly As Boolean = False) As String
			Dim result As String
			Try
				Dim text As String = Util.Format(Value, Fmt)
				If text Is Nothing Then
					text = "0"
				ElseIf Operators.CompareString(text.Trim(), "%", False) = 0 Then
					text = "0%"
				End If
				Dim text2 As String = Strings.Space(Conversions.ToInteger(W))
				If bShowLabelOnly Then
					StringType.MidStmtStr(text2, 1, Strings.Len(L), L)
				ElseIf bShowValueOnly Then
					If Operators.ConditionalCompareObjectGreater(W, 0, False) Then
						StringType.MidStmtStr(text2, Conversions.ToInteger(Operators.AddObject(Operators.SubtractObject(W, Strings.Len(text)), 1)), Strings.Len(text), text)
					Else
						text2 = text
					End If
				Else
					StringType.MidStmtStr(text2, 1, Strings.Len(L), L)
					StringType.MidStmtStr(text2, Conversions.ToInteger(Operators.AddObject(Operators.SubtractObject(W, Strings.Len(text)), 1)), Strings.Len(text), text)
				End If
				result = text2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Const sDimensionName As String = "Dimension Name"

		Private Const sLocalValue As String = "Local Value"

		Private Const sServerValue As String = "Server Value"

		Private Const shdr_DimensionName As String = "DimensionName"

		Private Const shdr_LocalValue As String = "LocalValue"

		Private Const shdr_ServerValue As String = "ServerValue"

		<AccessedThroughProperty("rbtUseLocalUnit")>
		Private _rbtUseLocalUnit As RadioButton

		<AccessedThroughProperty("rbtUseBoth")>
		Private _rbtUseBoth As RadioButton

		<AccessedThroughProperty("rbtUseServerUnit")>
		Private _rbtUseServerUnit As RadioButton

		<AccessedThroughProperty("ulgUnits")>
		Private _ulgUnits As UltraGrid

		Private StartPoint As Object

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

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		Private Shared m_vb6FormDefInstance As dlgCustomUnitComparison

		Private Shared m_InitializingDefInstance As Boolean

		Private m_LocalUnit As RSWIN_DESC.PUDataRec

		Private m_ServerUnit As RSWIN_DESC.PUDataRec

		Private m_bUseBothUnits As Boolean

		Private m_bUseLocalUnit As Boolean

		Private m_bUseServerUnit As Boolean

		Private mdsUnits As DataSet

		Private MyParentFrm As RODSTAR
	End Class
End Namespace
