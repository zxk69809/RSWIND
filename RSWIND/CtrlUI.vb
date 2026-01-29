Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module CtrlUI
		Public Function ConvertUnits(Value As Single, iValueType As Integer) As Single
			Dim num As Integer = If((-If(((RSWIN_DESC.SETUP_MeasurementSystem = 1) > False), 1, 0)), 1, 0)
			Dim num2 As Integer = If((-If(((RSWIN_DESC.SETUP_MeasurementSystem <> 3) > False), 1, 0)), 1, 0)
			Dim result As Single
			Select Case iValueType
				Case 0
					result = Conversions.ToSingle(Operators.MultiplyObject(Value, Interaction.IIf(num <> 0, 1, RSWIN_DESC.BPD__M3D)))
				Case 1
					result = Conversions.ToSingle(Operators.MultiplyObject(Value, Interaction.IIf(num <> 0, 1, RSWIN_DESC.FT__M)))
				Case 2
					result = Conversions.ToSingle(Operators.MultiplyObject(Value, Interaction.IIf(num <> 0, 1, RSWIN_DESC.IN__MM)))
				Case 3
					result = Conversions.ToSingle(Operators.MultiplyObject(Value, Interaction.IIf(num <> 0, 1, RSWIN_DESC.FT__M)))
				Case 4
					result = Conversions.ToSingle(Interaction.IIf(num2 <> 0, Value, 141.5 / (131.5 + CDbl(Value))))
				Case 5
					result = Conversions.ToSingle(Operators.MultiplyObject(Value, Interaction.IIf(num2 <> 0, 1, RSWIN_DESC.IN__MM)))
				Case 6
					result = Conversions.ToSingle(Operators.MultiplyObject(Value, Interaction.IIf(num <> 0, 1, 1F / RSWIN_DESC.BPD__M3D)))
				Case 7
					result = Conversions.ToSingle(Operators.MultiplyObject(Value, Interaction.IIf(num <> 0, 1, RSWIN_DESC.PSI__KPA)))
				Case 8
					result = Conversions.ToSingle(Operators.MultiplyObject(Value, Interaction.IIf(num2 <> 0, 1, RSWIN_DESC.IN__CM)))
				Case 9
					result = Conversions.ToSingle(Operators.MultiplyObject(Value, Interaction.IIf(num2 <> 0, 1, RSWIN_DESC.PSI__KPA)))
				Case 10
					result = Conversions.ToSingle(Operators.MultiplyObject(Value, Interaction.IIf(num2 <> 0, 1, RSWIN_DESC.MINLB__NM)))
				Case 11
					result = Conversions.ToSingle(Operators.MultiplyObject(Value, Interaction.IIf(num <> 0, 1, RSWIN_DESC.IN__MM)))
				Case 12
					result = Conversions.ToSingle(Operators.MultiplyObject(Value, Interaction.IIf(num2 <> 0, 1, RSWIN_DESC.LB__N)))
			End Select
			Return result
		End Function

		Public Function Grid_CountCols(ByRef grd As UltraGrid) As Integer
			Return grd.DisplayLayout.Bands(0).Columns.Count
		End Function

		Public Function Grid_CountRows(ByRef grd As UltraGrid) As Integer
			Dim num3 As Integer
			Dim num4 As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim num2 As Integer = 0
				IL_05:
				ProjectData.ClearProjectError()
				num3 = 1
				IL_0C:
				num = 3
				Dim ultraGridRow As UltraGridRow = grd.GetRow(ChildRow.First)
				IL_18:
				ProjectData.ClearProjectError()
				num3 = 0
				IL_1F:
				While True
					IL_4B:
					num = 6
					If ultraGridRow Is Nothing Then
						Exit For
					End If
					IL_21:
					num = 7
					num2 += 1
					IL_28:
					num = 8
					If ultraGridRow.HasNextSibling() Then
						IL_33:
						num = 9
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						IL_3F:
					Else
						IL_41:
						num = 11
						IL_45:
						num = 12
						ultraGridRow = Nothing
					End If
				End While
				IL_51:
				num = 15
				num4 = num2
				IL_57:
				GoTo IL_EE
				IL_5C:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_AC:
				GoTo IL_E3
				IL_AE:
				num6 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_C0:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num3 <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_AE
			End Try
			IL_E3:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_EE:
			Dim result As Integer = num4
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub Grid_SetLabels(ByRef grd As UltraGrid, bUseCanadian As Boolean)
			Dim num As Short = 0S
			Dim num2 As Short = CShort((grd.DisplayLayout.Bands(0).Columns.Count - 1))
			For num3 As Short = num To num2
				Dim flag As Boolean = RSWIN_DESC.SETUP_MeasurementSystem = 1
				Dim units As String = CtrlUI.Grid_GetUnitType(grd, CInt(num3))
				Dim text As String = CtrlUI.Grid_GetLabelInfo(grd, CInt(num3))
				Dim text2 As String = CtrlUI.MakeUnitsLabel(text, units, flag)
				If text2 IsNot Nothing AndAlso Operators.CompareString(text2, "", False) <> 0 Then
					grd.DisplayLayout.Bands(0).Columns(CInt(num3)).Header.Caption = text2
					CtrlUI.Grid_SetUnitSystem(grd, num3, Conversions.ToShort(Interaction.IIf(flag, 1, 3)))
				End If
			Next
		End Sub

		Public Function fpGetText(ByRef grid As UltraGrid, Col As Integer, Row As Integer, ByRef lpVar As Object) As Boolean
			Dim ultraGrid As UltraGrid = grid
			If Row = 0 Then
				lpVar = RuntimeHelpers.GetObjectValue(ultraGrid.DisplayLayout.Bands(0).Columns(Col).Tag)
			Else
				' The following expression was wrapped in a checked-expression
				lpVar = RuntimeHelpers.GetObjectValue(grid.Rows(Row - 1).Cells(Col).Value)
			End If
			Return lpVar IsNot Nothing
		End Function

		Public Sub fpSetText(ByRef grid As UltraGrid, Col As Integer, Row As Integer, Var As Object)
			Dim ultraGrid As UltraGrid = grid
			If Row = 0 Then
				ultraGrid.DisplayLayout.Bands(0).Columns(Col).Tag = RuntimeHelpers.GetObjectValue(Var)
			Else
				' The following expression was wrapped in a checked-expression
				grid.Rows(Row - 1).Cells(Col).Value = RuntimeHelpers.GetObjectValue(Var)
			End If
		End Sub

		Private Sub Grid_SetUnitSystem(ByRef grd As UltraGrid, Col As Short, UnitSystem As Short)
			Dim obj As Object
			CtrlUI.fpGetText(grd, CInt(Col), 0, obj)
			Dim text As String = Conversions.ToString(obj)
			Dim num As Short = CShort(Strings.InStrRev(text, vbLf, -1, CompareMethod.Binary))
			If num > 0S Then
				Dim str As String = Strings.Mid(text, CInt((num + 1S)))
				StringType.MidStmtStr(str, 2, 1, Conversions.ToString(Interaction.IIf(UnitSystem = 1S, "e", "m")))
				text = Strings.Left(text, CInt(num)) + str
				CtrlUI.fpSetText(grd, CInt(Col), 0, text)
			End If
		End Sub

		Public Sub Grid_ToggleUnits(ByRef grd As UltraGrid, Col As Short, Row As Short, Optional sFormat As String = "")
			Try
				If Col >= 0S Then
					If Strings.Len(CtrlUI.Grid_GetUnitInfo(grd, CInt(Col))) > 0 Then
						Dim flag As Boolean = Operators.ConditionalCompareObjectNotEqual(CtrlUI.Grid_GetUnitSystem(grd, CInt(Col)), 1, False)
						CtrlUI.Grid_SetUnitSystem(grd, Col, Conversions.ToShort(Interaction.IIf(flag, 1, 3)))
						Dim units As String = CtrlUI.Grid_GetUnitType(grd, CInt(Col))
						If Row >= 0S Then
							Dim obj As Object
							If CtrlUI.fpGetText(grd, CInt(Col), CInt(Row), obj) Then
								Dim num As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(obj))
								CtrlUI.ConvertValue(num, units, flag)
								If Operators.CompareString(sFormat, "", False) = 0 Then
									CtrlUI.fpSetText(grd, CInt(Col), CInt(Row), num)
								Else
									CtrlUI.fpSetText(grd, CInt(Col), CInt(Row), Util.Format(num, sFormat))
								End If
							End If
						Else
							Dim num2 As Short = 1S
							Dim num3 As Short = CShort(grd.Rows.Count)
							Row = num2
							While Row <= num3
								Dim obj As Object
								If CtrlUI.fpGetText(grd, CInt(Col), CInt(Row), obj) Then
									Dim num As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(obj))
									CtrlUI.ConvertValue(num, units, flag)
									If Operators.CompareString(sFormat, "", False) = 0 Then
										CtrlUI.fpSetText(grd, CInt(Col), CInt(Row), num)
									Else
										CtrlUI.fpSetText(grd, CInt(Col), CInt(Row), Util.Format(num, sFormat))
									End If
								End If
								Row += 1S
							End While
						End If
					End If
				Else
					Dim num4 As Short = 0S
					Dim num5 As Short = CShort((grd.DisplayLayout.Bands(0).Columns.Count - 1))
					Col = num4
					While Col <= num5
						Row = -1S
						If Strings.Len(CtrlUI.Grid_GetUnitInfo(grd, CInt(Col))) > 0 Then
							Dim flag As Boolean = Operators.ConditionalCompareObjectNotEqual(CtrlUI.Grid_GetUnitSystem(grd, CInt(Col)), 1, False)
							CtrlUI.Grid_SetUnitSystem(grd, Col, Conversions.ToShort(Interaction.IIf(flag, 1, 3)))
							Dim units As String = CtrlUI.Grid_GetUnitType(grd, CInt(Col))
							If Row >= 0S Then
								Dim obj As Object
								If CtrlUI.fpGetText(grd, CInt(Col), CInt(Row), obj) Then
									Dim num As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(obj))
									CtrlUI.ConvertValue(num, units, flag)
									If Operators.CompareString(sFormat, "", False) = 0 Then
										CtrlUI.fpSetText(grd, CInt(Col), CInt(Row), num)
									Else
										CtrlUI.fpSetText(grd, CInt(Col), CInt(Row), Util.Format(num, sFormat))
									End If
								End If
							Else
								Dim num6 As Short = 1S
								Dim num7 As Short = CShort(grd.Rows.Count)
								Row = num6
								While Row <= num7
									Dim obj As Object
									If CtrlUI.fpGetText(grd, CInt(Col), CInt(Row), obj) Then
										Dim num As Single
										Try
											If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
												num = Convert.ToSingle(RuntimeHelpers.GetObjectValue(obj))
											Else
												num = 0F
											End If
										Catch ex As Exception
											num = 0F
										End Try
										CtrlUI.ConvertValue(num, units, flag)
										If Operators.CompareString(sFormat, "", False) = 0 Then
											CtrlUI.fpSetText(grd, CInt(Col), CInt(Row), num)
										Else
											CtrlUI.fpSetText(grd, CInt(Col), CInt(Row), Util.Format(num, sFormat))
										End If
									End If
									Row += 1S
								End While
							End If
						End If
						Col += 1S
					End While
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub Grid_Advance(grd As UltraGrid, bAdvanceNext As Boolean)
		End Sub

		Public Function Grid_CheckValid(grd As UltraGrid, Col As Integer, Row As Integer, Value As Object, bShowMessage As Boolean) As Object
			Dim result As Object = True
			Dim obj As Object = CtrlUI.fpGetText(grd, Col, Row, Value)
			If Not Util.ValidNumber(Conversions.ToString(Value), If((-If((bShowMessage > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				result = False
			ElseIf Strings.Len(Strings.Trim(Conversions.ToString(Value))) > 0 AndAlso Operators.ConditionalCompareObjectNotEqual(CtrlUI.Grid_GetUnitSystem(grd, Col), 1, False) Then
				Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Value)
				Dim num As Single = Conversions.ToSingle(obj2)
				CtrlUI.ConvertValue(num, CtrlUI.Grid_GetUnitType(grd, Col), True)
				obj2 = num
				Value = RuntimeHelpers.GetObjectValue(obj2)
			End If
			Return result
		End Function

		Public Sub Grid_EditMode(grd As UltraGrid, Col As Integer, Row As Integer, Mode As Integer, bChangeMade As Boolean)
		End Sub

		Private Function Grid_GetCanadianUnitSystem(grd As Control, Col As Integer) As Object
			Dim result As Object
			If TypeOf grd Is UltraGrid Then
				If Operators.CompareString(Strings.Mid(CtrlUI.Grid_GetUnitInfo(grd, Col), 3, 1), "e", False) = 0 Then
					result = 1
				Else
					result = 3
				End If
			End If
			Return result
		End Function

		Public Sub Grid_SetValue(ByRef grd As UltraGrid, Col As Short, Row As Short, v As Single)
			Dim flag As Boolean
			If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				flag = Operators.ConditionalCompareObjectEqual(CtrlUI.Grid_GetCanadianUnitSystem(grd, CInt(Col)), 3, False)
			Else
				flag = (RSWIN_DESC.SETUP_MeasurementSystem = 3)
			End If
			If flag Then
				CtrlUI.ConvertValue(v, CtrlUI.Grid_GetUnitType(grd, CInt(Col)), False)
			End If
			CtrlUI.fpSetText(grd, CInt(Col), CInt(Row), v)
		End Sub

		Private Function Grid_GetLabelInfo(grd As Control, Col As Integer) As String
			Dim ultraGrid As UltraGrid = CType(grd, UltraGrid)
			Dim obj As Object
			CtrlUI.fpGetText(ultraGrid, Col, 0, obj)
			grd = ultraGrid
			Dim text As String = Convert.ToString(RuntimeHelpers.GetObjectValue(obj))
			Dim num As Integer = Strings.InStrRev(text, vbLf, -1, CompareMethod.Binary)
			Dim result As String
			If num = 0 Then
				result = text
			Else
				' The following expression was wrapped in a checked-expression
				result = Strings.Left(text, num - 1)
			End If
			Return result
		End Function

		Private Function Grid_GetUnitInfo(grd As Control, Col As Integer) As String
			Dim result As String
			Try
				result = Nothing
				Dim ultraGrid As UltraGrid = CType(grd, UltraGrid)
				Dim obj As Object
				CtrlUI.fpGetText(ultraGrid, Col, 0, obj)
				grd = ultraGrid
				Dim text As String = Conversions.ToString(obj)
				Dim num As Integer = Strings.InStrRev(text, vbLf, -1, CompareMethod.Binary)
				If num > 0 Then
					' The following expression was wrapped in a checked-expression
					result = Strings.Mid(text, num + 1)
				End If
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function

		Private Function Grid_GetUnitSystem(grd As Control, Col As Integer) As Object
			Dim result As Object
			If TypeOf grd Is UltraGrid Then
				If Operators.CompareString(Strings.Mid(CtrlUI.Grid_GetUnitInfo(grd, Col), 2, 1), "e", False) = 0 Then
					result = 1
				Else
					result = 3
				End If
			End If
			Return result
		End Function

		Private Function Grid_GetUnitType(grd As Control, Col As Integer) As String
			Dim result As String
			If TypeOf grd Is UltraGrid Then
				result = Strings.Mid(CtrlUI.Grid_GetUnitInfo(grd, Col), 1, 1)
			End If
			Return result
		End Function

		Public Sub SetEditRequired(ByRef frm As Form, sControls As String())
			' The following expression was wrapped in a checked-statement
			Try
				For Each obj As Object In frm.Controls
					Dim control As Control = CType(obj, Control)
					Dim num As Integer = 0
					If TypeOf control Is ComboBox Then
						num = -1
					ElseIf TypeOf control Is TextBox Then
						Dim num2 As Integer = 0
						Dim num3 As Integer = Information.UBound(sControls, 1) - 1
						For i As Integer = num2 To num3
							If Operators.CompareString(control.Name, sControls(i), False) = 0 Then
								num = -1
								Exit For
							End If
						Next
					End If
					If num <> 0 Then
						control.BackColor = RSWIN_DESC.rgbEditRequired
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Public Function TextBox_GetCanadianUnitSystem(ByRef txt As Control) As Object
			Dim result As Object
			If TypeOf txt Is TextBox Then
				Dim text As String = Conversions.ToString(txt.Tag)
				If Strings.Len(text) < 3 Then
					result = 1
				ElseIf Operators.CompareString(Strings.Mid(text, 3, 1), "e", False) = 0 Then
					result = 1
				Else
					result = 3
				End If
			End If
			Return result
		End Function

		Public Sub TextBox_GotFocus(ByRef txt As TextBox)
			txt.BackColor = RSWIN_DESC.rgbEditFocus
			txt.BackColor = RSWIN_DESC.rgbEditFocus
			If Strings.Len(RuntimeHelpers.GetObjectValue(txt.Tag)) > 0 AndAlso RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				Util.Message("Press [F2] to convert units.")
			End If
		End Sub

		Public Sub TextBox_KeyDown(ByRef txt As TextBox, ByRef lbl As Label, KeyCode As Integer, Shift As Integer)
			If Strings.Len(RuntimeHelpers.GetObjectValue(txt.Tag)) > 0 And KeyCode = 113 And Shift = 0 Then
				Dim control As Control = txt
				CtrlUI.TextBox_ToggleUnits(control, lbl)
				txt = CType(control, TextBox)
				Dim flag As Boolean
				If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					Dim obj As Object = CtrlUI.TextBox_GetUnitSystem(txt)
					control = txt
					Dim obj2 As Object = CtrlUI.TextBox_GetCanadianUnitSystem(control)
					txt = CType(control, TextBox)
					flag = Operators.ConditionalCompareObjectNotEqual(obj, obj2, False)
				Else
					flag = (CtrlUI.TextBox_GetUnitSystem(txt) <> RSWIN_DESC.SETUP_MeasurementSystem)
				End If
				If flag Then
					txt.BackColor = Color.PaleGreen
				Else
					txt.BackColor = RSWIN_DESC.rgbEditFocus
				End If
				txt.Focus()
			End If
		End Sub

		Public Sub Control_LostFocus(ByRef cntrl As Control)
			cntrl.BackColor = Color.White
			cntrl.ForeColor = Color.Black
		End Sub

		Public Sub TextBox_LostFocus(ByRef txt As TextBox, Optional ByRef lbl As Label = Nothing, Optional bRequiredColor As Boolean = True)
			Dim backColor As Color
			If bRequiredColor Then
				backColor = RSWIN_DESC.rgbEditRequired
			Else
				backColor = RSWIN_DESC.rgbEditComplete
			End If
			If Strings.Len(Strings.Trim(txt.Text)) = 0 Then
				txt.BackColor = backColor
			Else
				Dim control As Control = txt
				CtrlUI.Control_LostFocus(control)
				txt = CType(control, TextBox)
			End If
			If Strings.Len(RuntimeHelpers.GetObjectValue(txt.Tag)) > 0 Then
				Dim obj3 As Object
				If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					Dim obj As Object = CtrlUI.TextBox_GetUnitSystem(txt)
					Dim control As Control = txt
					Dim obj2 As Object = CtrlUI.TextBox_GetCanadianUnitSystem(control)
					txt = CType(control, TextBox)
					obj3 = RuntimeHelpers.GetObjectValue(Operators.CompareObjectNotEqual(obj, obj2, False))
				Else
					Dim num As Integer = CtrlUI.TextBox_GetUnitSystem(txt)
					obj3 = (CtrlUI.TextBox_GetUnitSystem(txt) <> RSWIN_DESC.SETUP_MeasurementSystem)
				End If
				If Conversions.ToBoolean(Operators.AndObject(obj3, lbl IsNot Nothing)) Then
					Dim control As Control = txt
					CtrlUI.TextBox_ToggleUnits(control, lbl)
					txt = CType(control, TextBox)
				End If
				Return
			End If
		End Sub

		Public Sub SetLabelOnly(ByRef txt As TextBox, ByRef lbl As Label, Optional bRequiredColor As Boolean = True)
			If Strings.Len(RuntimeHelpers.GetObjectValue(txt.Tag)) > 0 Then
				Dim flag As Boolean
				If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					Dim obj As Object = CtrlUI.TextBox_GetUnitSystem(txt)
					Dim control As Control = txt
					Dim obj2 As Object = CtrlUI.TextBox_GetCanadianUnitSystem(control)
					txt = CType(control, TextBox)
					flag = Operators.ConditionalCompareObjectNotEqual(obj, obj2, False)
				Else
					flag = (CtrlUI.TextBox_GetUnitSystem(txt) <> RSWIN_DESC.SETUP_MeasurementSystem)
				End If
				If flag Then
					Dim bEnglishUnits As Boolean = CtrlUI.TextBox_GetUnitSystem(txt) <> 1
					Dim control As Control = txt
					Dim text As String = CtrlUI.TextBox_GetUnitType(control)
					txt = CType(control, TextBox)
					Dim units As String = text
					control = lbl
					CtrlUI.TextBox_SetLabel(control, units, bEnglishUnits)
					lbl = CType(control, Label)
				End If
			End If
		End Sub

		Public Sub TextBox_SetLabel(ByRef lbl As Control, Units As String, bEnglishUnits As Boolean)
			Dim text As String
			If Strings.Len(RuntimeHelpers.GetObjectValue(lbl.Tag)) > 0 Then
				text = Conversions.ToString(lbl.Tag)
			Else
				text = lbl.Text
			End If
			lbl.Text = CtrlUI.MakeUnitsLabel(text, Units, bEnglishUnits)
		End Sub

		Public Sub TextBox_SetUnitSystem(ByRef txt As Control, UnitSystem As Integer)
			If TypeOf txt Is TextBox Then
				Dim sInsert As String = Conversions.ToString(Interaction.IIf(UnitSystem = 1, "e", "m"))
				Dim text As String = Conversions.ToString(txt.Tag)
				If Strings.Len(text) < 2 Then
					text = Strings.Left(text + Strings.Space(2), 2)
				End If
				StringType.MidStmtStr(text, 2, 1, sInsert)
				txt.Tag = text
			End If
		End Sub

		Public Sub TextBox_ToggleUnits(ByRef txt As Control, ByRef lbl As Label)
			Try
				If TypeOf txt Is TextBox Then
					Dim text As String = Conversions.ToString(CtrlUI.TextBox_GetUnitSystem(txt) <> 1)
					Dim units As String = CtrlUI.TextBox_GetUnitType(txt)
					CtrlUI.TextBox_SetUnitSystem(txt, Conversions.ToInteger(Interaction.IIf(Conversions.ToBoolean(text), 1, 3)))
					If Strings.Len(Strings.Trim(txt.Text)) > 0 And Versioned.IsNumeric(txt.Text) Then
						Dim num As Single = Convert.ToSingle(txt.Text)
						CtrlUI.ConvertValue(num, units, Conversions.ToBoolean(text))
						txt.Text = Util.QFormat(num)
					End If
					Dim control As Control = lbl
					CtrlUI.TextBox_SetLabel(control, units, Conversions.ToBoolean(text))
					lbl = CType(control, Label)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ToolbarButtonSetState(nIndex As Integer, bEnabled As Integer)
			If nIndex = -1 Then
				Return
			End If
			Try
				RODSTAR.DefInstance.ToolbarButtonSetState(nIndex, bEnabled <> 0)
			Catch ex As Exception
			End Try
			Select Case nIndex
				Case 0
					RODSTAR.DefInstance.mnuFile.Enabled = (bEnabled <> 0)
					RODSTAR.DefInstance.mnuEdit.Enabled = (bEnabled <> 0)
					RODSTAR.DefInstance.mnuRun.Enabled = (bEnabled <> 0)
					RODSTAR.DefInstance.mnuWindow.Enabled = (bEnabled <> 0)
					RODSTAR.DefInstance.mnuHelp.Enabled = (bEnabled <> 0)
					Application.DoEvents()
					Return
				Case 1, 3, 5, 6, 7, 12, 15
				Case 2
					RODSTAR.DefInstance.mnuFileSaveAsPDF_.Enabled = (bEnabled <> 0)
					RODSTAR.DefInstance.mnuWindowViewReport.Enabled = (bEnabled <> 0)
					RODSTAR.DefInstance.mnuToolsExportDYN.Enabled = (bEnabled <> 0)
					RODSTAR.DefInstance.mnuToolsExportMCM.Enabled = (bEnabled <> 0)
					RODSTAR.DefInstance.tbrCBM.Enabled = (bEnabled <> 0)
					Return
				Case 4
					RODSTAR.DefInstance.mnuFilePrint_.Enabled = (bEnabled <> 0)
				Case 8
					RODSTAR.DefInstance.mnuWindowInput(1S).Enabled = (bEnabled <> 0)
					Return
				Case 9
					RODSTAR.DefInstance.mnuWindowInput(2S).Enabled = (bEnabled <> 0)
					Return
				Case 10
					RODSTAR.DefInstance.mnuWindowInput(3S).Enabled = (bEnabled <> 0)
					Return
				Case 11
					RODSTAR.DefInstance.mnuWindowInput(4S).Enabled = (bEnabled <> 0)
					Return
				Case 13
					RODSTAR.DefInstance.mnuWindowInput(6S).Enabled = (bEnabled <> 0)
					Return
				Case 14
					RODSTAR.DefInstance.mnuWindowInput(7S).Enabled = (bEnabled <> 0)
					Return
				Case 16
					RODSTAR.DefInstance.mnuWindowNextScreen.Enabled = (bEnabled <> 0)
					If RSWIN_DESC.bRunIconEnabled Then
						RODSTAR.DefInstance.mnuRun.Enabled = (bEnabled <> 0)
						Return
					End If
				Case Else
					Return
			End Select
		End Sub

		Public Sub ComboBox_LostFocus(cbo As ComboBox)
			Dim backColor As Color = RSWIN_DESC.rgbEditComplete
			If cbo.SelectedIndex < 0 Then
				If cbo.DropDownStyle = ComboBoxStyle.DropDownList Then
					backColor = RSWIN_DESC.rgbEditRequired
				ElseIf Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbo.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), 0, False) Then
					backColor = RSWIN_DESC.rgbEditRequired
				End If
			End If
			cbo.BackColor = backColor
		End Sub

		Public Function TextBox_GetUnitSystem(txt As Control) As Integer
			If TypeOf txt Is TextBox Then
				Dim text As String = Conversions.ToString(txt.Tag)
				Dim result As Integer
				If Strings.Len(text) < 2 Then
					result = 1
				ElseIf Operators.CompareString(Strings.Mid(text, 2, 1), "e", False) = 0 Then
					result = 1
				Else
					result = 3
				End If
				Return result
			End If
			Dim result2 As Integer
			Return result2
		End Function

		Public Sub ConvertValue(ByRef v As Single, Units As String, bToEnglish As Boolean)
			Try
				Dim num As Single = v
				Dim num2 As Short = 0S
				Dim num3 As Single
				If Operators.CompareString(Units, "A", False) = 0 OrElse Operators.CompareString(Units, "a", False) = 0 Then
					num2 = -1S
				ElseIf Operators.CompareString(Units, "b", False) = 0 Then
					num3 = RSWIN_DESC.BPD__M3D
				ElseIf Operators.CompareString(Units, "d", False) = 0 Then
					num3 = 1F / RSWIN_DESC.FT__M
				ElseIf Operators.CompareString(Units, "f", False) = 0 Then
					num3 = RSWIN_DESC.FT__M
				ElseIf Operators.CompareString(Units, "c", False) = 0 Then
					num3 = RSWIN_DESC.IN__CM
				ElseIf Operators.CompareString(Units, "i", False) = 0 Then
					num3 = CSng(Math.Pow(CDbl(RSWIN_DESC.IN__CM), 2.0))
				ElseIf Operators.CompareString(Units, "I", False) = 0 Then
					num3 = CSng(Math.Pow(CDbl(RSWIN_DESC.IN__CM), 3.0))
				ElseIf Operators.CompareString(Units, "m", False) = 0 Then
					num3 = RSWIN_DESC.IN__MM
				ElseIf Operators.CompareString(Units, "l", False) = 0 Then
					num3 = RSWIN_DESC.LB__N
				ElseIf Operators.CompareString(Units, "k", False) = 0 Then
					num3 = RSWIN_DESC.LBFT__KGM
				ElseIf Operators.CompareString(Units, "N", False) = 0 Then
					num3 = RSWIN_DESC.LBFT2__KGM2
				ElseIf Operators.CompareString(Units, "L", False) = 0 Then
					num3 = RSWIN_DESC.MINLB__NM
				ElseIf Operators.CompareString(Units, "k", False) = 0 Then
					num3 = RSWIN_DESC.LB__N * 1000F
				ElseIf Operators.CompareString(Units, "P", False) = 0 Then
					num3 = RSWIN_DESC.PSI__KPA
				ElseIf Operators.CompareString(Units, "p", False) = 0 Then
					num3 = RSWIN_DESC.PSI__KPA
				ElseIf Operators.CompareString(Units, "g", False) = 0 Then
					num3 = RSWIN_DESC.PSI__KPA
				ElseIf Operators.CompareString(Units, "h", False) = 0 Then
					num3 = RSWIN_DESC.LB__N * 100F
				Else
					num3 = 1F
				End If
				If bToEnglish Then
					If num2 <> 0S Then
						v = CSng((141.5 / CDbl(v) - 131.5))
					Else
						v /= num3
					End If
				ElseIf num2 <> 0S Then
					v = CSng((141.5 / (CDbl(v) + 131.5)))
				Else
					v *= num3
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function fConvertValue(v As Single, Units As String, bToEnglish As Boolean) As Single
			Dim result As Single
			Try
				Dim num As Short = 0S
				Dim num2 As Single
				If Operators.CompareString(Units, "A", False) = 0 OrElse Operators.CompareString(Units, "a", False) = 0 Then
					num = -1S
				ElseIf Operators.CompareString(Units, "b", False) = 0 Then
					num2 = RSWIN_DESC.BPD__M3D
				ElseIf Operators.CompareString(Units, "d", False) = 0 Then
					num2 = 1F / RSWIN_DESC.FT__M
				ElseIf Operators.CompareString(Units, "f", False) = 0 Then
					num2 = RSWIN_DESC.FT__M
				ElseIf Operators.CompareString(Units, "c", False) = 0 Then
					num2 = RSWIN_DESC.IN__CM
				ElseIf Operators.CompareString(Units, "i", False) = 0 Then
					num2 = CSng(Math.Pow(CDbl(RSWIN_DESC.IN__CM), 2.0))
				ElseIf Operators.CompareString(Units, "I", False) = 0 Then
					num2 = CSng(Math.Pow(CDbl(RSWIN_DESC.IN__CM), 3.0))
				ElseIf Operators.CompareString(Units, "m", False) = 0 Then
					num2 = RSWIN_DESC.IN__MM
				ElseIf Operators.CompareString(Units, "l", False) = 0 Then
					num2 = RSWIN_DESC.LB__N
				ElseIf Operators.CompareString(Units, "k", False) = 0 Then
					num2 = RSWIN_DESC.LBFT__KGM
				ElseIf Operators.CompareString(Units, "N", False) = 0 Then
					num2 = RSWIN_DESC.LBFT2__KGM2
				ElseIf Operators.CompareString(Units, "L", False) = 0 Then
					num2 = RSWIN_DESC.MINLB__NM
				ElseIf Operators.CompareString(Units, "k", False) = 0 Then
					num2 = RSWIN_DESC.LB__N * 1000F
				ElseIf Operators.CompareString(Units, "P", False) = 0 Then
					num2 = RSWIN_DESC.PSI__KPA
				ElseIf Operators.CompareString(Units, "p", False) = 0 Then
					num2 = RSWIN_DESC.PSI__KPA
				ElseIf Operators.CompareString(Units, "g", False) = 0 Then
					num2 = RSWIN_DESC.PSI__KPA
				ElseIf Operators.CompareString(Units, "h", False) = 0 Then
					num2 = RSWIN_DESC.LB__N * 100F
				Else
					num2 = 1F
				End If
				If bToEnglish Then
					If num <> 0S Then
						v = CSng((141.5 / CDbl(v) - 131.5))
					Else
						v /= num2
					End If
				ElseIf num <> 0S Then
					v = CSng((141.5 / (CDbl(v) + 131.5)))
				Else
					v *= num2
				End If
				result = v
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function CheckValid(txt As TextBox, bValidIfEmpty As Boolean, bShowMessage As Boolean, ByRef Value As Object) As Boolean
			Dim text As String = ""
			Value = VariantType.Null
			If Not Util.ValidNumber(txt.Text, If((-If((bShowMessage > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				Return False
			End If
			If Strings.Len(Strings.Trim(txt.Text)) = 0 Then
				Return bValidIfEmpty
			End If
			text = txt.Text.Trim()
			Try
				If Strings.InStr(text, "-", CompareMethod.Binary) > 0 Then
					text = "-" + text.Replace("-", "")
				End If
			Catch ex As Exception
				text = txt.Text.Trim()
			End Try
			Value = Convert.ToSingle(text)
			If Strings.Len(RuntimeHelpers.GetObjectValue(txt.Tag)) > 0 AndAlso CtrlUI.TextBox_GetUnitSystem(txt) <> 1 Then
				Dim num As Single = Conversions.ToSingle(Value)
				Dim control As Control = txt
				Dim units As String = CtrlUI.TextBox_GetUnitType(control)
				txt = CType(control, TextBox)
				CtrlUI.ConvertValue(num, units, True)
				Value = num
			End If
			Return True
		End Function

		Public Sub SetIndexByItemData(cbo As ComboBox, ItemDataToFind As Long, Optional ResetIfItemNotFound As Boolean = False)
			Dim flag As Boolean = False
			Dim num As Integer = 0
			Dim num2 As Integer = cbo.Items.Count - 1
			Dim selectedIndex As Integer
			For i As Integer = num To num2
				' The following expression was wrapped in a unchecked-expression
				If CLng(Support.GetItemData(cbo, i)) = ItemDataToFind Then
					flag = True
					selectedIndex = i
					Exit For
				End If
			Next
			If flag Then
				cbo.SelectedIndex = selectedIndex
			ElseIf ResetIfItemNotFound Then
				cbo.SelectedIndex = -1
			End If
		End Sub

		Public Function TextBox_GetUnitType(ByRef txt As Control) As String
			If TypeOf txt Is TextBox Then
				Return Strings.Mid(Conversions.ToString(txt.Tag), 1, 1)
			End If
			Dim result As String
			Return result
		End Function

		Public Function MakeUnitsLabel(ByRef sTemplate As String, Units As String, bEnglishUnits As Boolean) As String
			Dim text As String = Units
			If Operators.CompareString(text, "A", False) = 0 OrElse Operators.CompareString(text, "a", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.sAPI, RSWIN_DESC.gcm3))
			ElseIf Operators.CompareString(text, "a", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.gravityAPI, RSWIN_DESC.densitygcm3))
			ElseIf Operators.CompareString(text, "b", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.bfpd, RSWIN_DESC.m3D))
			ElseIf Operators.CompareString(text, "d", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.dollarperft, RSWIN_DESC.dollarperM))
			ElseIf Operators.CompareString(text, "f", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.ft, RSWIN_DESC.m))
			ElseIf Operators.CompareString(text, "c", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.inch, RSWIN_DESC.cm))
			ElseIf Operators.CompareString(text, "i", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.inch2, RSWIN_DESC.cm2))
			ElseIf Operators.CompareString(text, "I", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.inch3, RSWIN_DESC.cm3))
			ElseIf Operators.CompareString(text, "m", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.inch, RSWIN_DESC.mm))
			ElseIf Operators.CompareString(text, "l", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.lbs, RSWIN_DESC.N))
			ElseIf Operators.CompareString(text, "k", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.lbft, RSWIN_DESC.kgm))
			ElseIf Operators.CompareString(text, "N", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.lbft, RSWIN_DESC.Nm))
			ElseIf Operators.CompareString(text, "L", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.Minlbs, RSWIN_DESC.Nm))
			ElseIf Operators.CompareString(text, "k", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.Mlbs, RSWIN_DESC.N))
			ElseIf Operators.CompareString(text, "P", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.MMpsi, RSWIN_DESC.GPa))
			ElseIf Operators.CompareString(text, "p", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.psi, RSWIN_DESC.kPa))
			ElseIf Operators.CompareString(text, "g", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.psig, RSWIN_DESC.kPa))
			ElseIf Operators.CompareString(text, "h", False) = 0 Then
				Units = Conversions.ToString(Interaction.IIf(bEnglishUnits, RSWIN_DESC.x100lbs, RSWIN_DESC.N))
			End If
			Dim text2 As String = sTemplate
			Dim num As Integer = Strings.InStr(text2, "^", CompareMethod.Binary)
			Dim result As String
			If num = 0 Then
				result = text2
			Else
				' The following expression was wrapped in a checked-expression
				result = Strings.Left(text2, num - 1) + Units + Strings.Mid(text2, num + 1)
			End If
			Return result
		End Function

		Public Sub Label_Click_1(ByRef Form As Form, Index As Short)
			Dim num As Integer
			Dim num8 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim num3 As Short = 0S
				Dim num4 As Short = CShort((Form.Controls.Count - 1))
				Dim num5 As Short = num3
				While num5 <= num4
					IL_1E:
					num2 = 3
					Information.Err().Clear()
					IL_2B:
					num2 = 4
					Dim num6 As Short = CShort(Form.Controls(CInt(num5)).TabIndex)
					IL_42:
					num2 = 5
					If Information.Err().Number = 0 And num6 = Index Then
						IL_59:
						num2 = 6
						If Form.Controls(CInt(num5)).Visible Then
							IL_70:
							num2 = 7
							Form.Controls(CInt(num5)).Focus()
							IL_86:
							Exit While
						End If
						Exit While
					Else
						IL_8B:
						num2 = 11
						num5 += 1S
					End If
				End While
				IL_98:
				GoTo IL_11F
				IL_9D:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_DD:
				GoTo IL_114
				IL_DF:
				num8 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_F1:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_DF
			End Try
			IL_114:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_11F:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub Label_DblClick_1(ByRef Form As Form, Index As Short)
			Dim num As Integer
			Dim num8 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim num3 As Short = 0S
				Dim num4 As Short = CShort((Form.Controls.Count - 1))
				Dim num5 As Short = num3
				While num5 <= num4
					IL_21:
					num2 = 3
					Information.Err().Clear()
					IL_2E:
					num2 = 4
					Dim num6 As Short = CShort(Form.Controls(CInt(num5)).TabIndex)
					IL_45:
					num2 = 5
					If Information.Err().Number = 0 And num6 = Index Then
						IL_5C:
						num2 = 6
						If Form.Controls(CInt(num5)).Visible Then
							IL_73:
							num2 = 7
							Form.Controls(CInt(num5)).Focus()
							IL_89:
							num2 = 8
							If Information.Err().Number = 0 Then
							End If
							IL_99:
							Exit While
						End If
						Exit While
					Else
						IL_9E:
						num2 = 13
						num5 += 1S
					End If
				End While
				IL_AE:
				GoTo IL_13D
				IL_B3:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_FB:
				GoTo IL_132
				IL_FD:
				num8 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_10F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_FD
			End Try
			IL_132:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_13D:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function IfNull(Value As Object, NullValue As Object) As Object
			Return RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(Value)), RuntimeHelpers.GetObjectValue(NullValue), RuntimeHelpers.GetObjectValue(Value)))
		End Function

		Private Const SzENGLISH As String = "e"

		Private Const SzMETRIC As String = "m"

		Private Const SzAPI_GMCM3 As String = "A"

		Private Const SzAPI_GMCM3_WELLINFO As String = "a"

		Private Const SzBFPD_M3D As String = "b"

		Private Const SzDPFT_DPM As String = "d"

		Private Const SzFT_M As String = "f"

		Private Const SzIN_CM As String = "c"

		Private Const SzIN2_CM2 As String = "i"

		Private Const SzIN3_CM3 As String = "I"

		Private Const SzIN_MM As String = "m"

		Private Const SzLB_N As String = "l"

		Private Const SzLBFT_KGM As String = "k"

		Private Const SzLBFT2_NM2 As String = "N"

		Private Const SzMINLB_NM As String = "L"

		Private Const SzMLB_N As String = "k"

		Private Const SzMPSI_GPA As String = "P"

		Private Const SzPSI_KPA As String = "p"

		Private Const SzPSIG_KPA As String = "g"

		Private Const Sz100LB_N As String = "h"
	End Module
End Namespace
