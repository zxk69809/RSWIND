Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports ChartFX.WinForms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace RSWINV3
	Friend NotInheritable Module RSWIN
		Public Sub GetSpreadsheetValueList(ByRef vValues As Object(), ByRef Dec As Integer(), nWK1Items As Integer)
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Dim num4 As Integer = 0
			Dim num5 As Integer = 0
			Dim num6 As Integer = 0
			Try
				Dim cRODSTAR As cRODSTAR
				If Not RSWIN_DESC.bRodStarD And nWK1Items < 58 Then
					vValues = New Object(58) {}
					Dec = New Integer(58) {}
				ElseIf RSWIN_DESC.bRodStarD And nWK1Items < 62 Then
					vValues = New Object(62) {}
					Dec = New Integer(62) {}
				Else
					vValues = New Object(nWK1Items + 1 - 1) {}
					Dec = New Integer(nWK1Items + 1 - 1) {}
				End If
				cRODSTAR = RSWIN_DESC.rst
				Dec(0) = 0
				vValues(0) = DBNull.Value
				Dec(1) = 0
				vValues(1) = DBNull.Value
				Dec(2) = 0
				vValues(2) = DBNull.Value
				Dec(3) = 0
				vValues(3) = DBNull.Value
				Dec(4) = 1
				vValues(4) = DBNull.Value
				Dec(5) = 1
				vValues(5) = DBNull.Value
				Dec(6) = 0
				vValues(6) = DBNull.Value
				Dec(7) = 3
				vValues(7) = DBNull.Value
				Dec(8) = 3
				vValues(8) = DBNull.Value
				Dec(9) = 1
				vValues(9) = CtrlUI.ConvertUnits(cRODSTAR.PU.KinematicStroke, 8)
				vValues(10) = RuntimeHelpers.GetObjectValue(Interaction.IIf(cRODSTAR.PumpCondition = 1S, "N/A", Convert.ToDouble(cRODSTAR.PumpFillage / 100F)))
				If cRODSTAR.PumpCondition = 1S Then
					vValues(10) = "100%"
				End If
				Dec(11) = 0
				vValues(11) = CtrlUI.ConvertUnits(cRODSTAR.BPDsurface, 0)
				Dec(12) = 4
				vValues(12) = CtrlUI.ConvertUnits(cRODSTAR.PlungerSize, 5)
				Dec(13) = 0
				vValues(13) = CtrlUI.ConvertUnits(cRODSTAR.PumpDepth, 1)
				vValues(14) = Convert.ToDouble(cRODSTAR.SystemEff)
				Dec(15) = 1
				vValues(15) = cRODSTAR.SPM
				Dec(16) = 1
				Dim text As String
				Dim cRODSTAR2 As cRODSTAR
				Dim num10 As Single
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					Dim array As Object() = vValues
					Dim num7 As Integer = 16
					Dim num8 As Double = CDbl(RSWIN_DESC.rst.Prhp) * 0.746
					text = "##.#"
					array(num7) = Util.Format(num8, text)
				Else
					Dim array2 As Object() = vValues
					Dim num9 As Integer = 16
					cRODSTAR2 = cRODSTAR
					num10 = cRODSTAR2.Prhp
					text = "##.#"
					Dim text2 As String = Util.Format(num10, text)
					cRODSTAR2.Prhp = num10
					array2(num9) = text2
				End If
				vValues(17) = RuntimeHelpers.GetObjectValue(Interaction.IIf(cRODSTAR.UnknownM, "N/A", RuntimeHelpers.GetObjectValue(Interaction.IIf(CDbl((Math.Abs(cRODSTAR.get_M(2) - cRODSTAR.get_M(1)) / cRODSTAR.get_M(1))) <= 0.02, "No", "Yes"))))
				Dec(18) = 1
				vValues(18) = Convert.ToDouble(cRODSTAR.StructL)
				Dec(19) = 1
				vValues(19) = Convert.ToDouble(cRODSTAR.MaxRodStressL)
				Dec(20) = -1
				vValues(20) = cRODSTAR.Runtime
				Dec(21) = 0
				vValues(21) = CtrlUI.ConvertUnits(cRODSTAR.TubingPressure, 7)
				Dec(22) = 0
				vValues(22) = CtrlUI.ConvertUnits(cRODSTAR.CasingPressure, 7)
				Dec(23) = -1
				vValues(23) = cRODSTAR.WaterCut
				Dec(24) = 2
				Dim array3 As Object() = vValues
				Dim num11 As Integer = 24
				cRODSTAR2 = cRODSTAR
				num10 = cRODSTAR2.WaterSPGR
				text = "####.##"
				Dim text3 As String = Util.Format(num10, text)
				cRODSTAR2.WaterSPGR = num10
				array3(num11) = text3
				Dec(25) = 2
				Dim array4 As Object() = vValues
				Dim num12 As Integer = 25
				num10 = CtrlUI.ConvertUnits(cRODSTAR.OilAPI, 4)
				text = "####.##"
				array4(num12) = Util.Format(num10, text)
				Dec(26) = 4
				Dim array5 As Object() = vValues
				Dim num13 As Integer = 26
				cRODSTAR2 = cRODSTAR
				num10 = cRODSTAR2.FluidSPGR
				text = "####.####"
				Dim text4 As String = Util.Format(num10, text)
				cRODSTAR2.FluidSPGR = num10
				array5(num13) = text4
				Dec(27) = 0
				vValues(27) = CtrlUI.ConvertUnits(cRODSTAR.Pprload, 12)
				Dec(28) = 0
				vValues(28) = CtrlUI.ConvertUnits(cRODSTAR.Mprload, 12)
				Dec(29) = 0
				vValues(29) = CtrlUI.ConvertUnits(cRODSTAR.WrodsInFluid, 12)
				Try
					Dim [string] As String = "SIZE "
					Dim text5 As String = Conversions.ToString(Motor.GetMotorInfo(3))
					If Strings.InStr(1, text5, [string], CompareMethod.Text) = 1 Then
						text5 = Strings.Mid(text5, 6)
					End If
					Dec(30) = 0
					vValues(30) = text5
				Catch ex As Exception
				End Try
				Dec(31) = 0
				vValues(31) = cRODSTAR.MinMotorHP
				Dec(32) = 0
				vValues(32) = CtrlUI.ConvertUnits(cRODSTAR.FluidLoad, 12)
				Dec(33) = 0
				vValues(33) = CtrlUI.ConvertUnits(cRODSTAR.PumpIntakePressure, 7)
				Dec(34) = 1
				vValues(34) = CtrlUI.ConvertUnits(cRODSTAR.GrossPumpStroke, 8)
				Dec(35) = 0
				vValues(35) = RuntimeHelpers.GetObjectValue(Interaction.IIf(cRODSTAR.SPMEntered <> 0S, "N/A", CtrlUI.ConvertUnits(cRODSTAR.TargetBFPD, 0)))
				Dec(36) = 1
				vValues(36) = RuntimeHelpers.GetObjectValue(Interaction.IIf(cRODSTAR.MotorSPV = 0F, "N/A", Convert.ToDouble(cRODSTAR.MotorSPV)))
				Dec(37) = 1
				vValues(37) = CtrlUI.ConvertUnits(cRODSTAR.TubStretch, 8)
				Dec(38) = 2
				vValues(38) = DBNull.Value
				Dec(39) = 1
				vValues(39) = CtrlUI.ConvertUnits(cRODSTAR.PumpSpacing, 8)
				Dec(40) = 1
				vValues(40) = RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, CtrlUI.ConvertUnits(cRODSTAR.PumpLength, 3), cRODSTAR.PumpLength))
				Dec(41) = 1
				vValues(41) = RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, CtrlUI.ConvertUnits(cRODSTAR.PlungerLength, 3), cRODSTAR.PlungerLength))
				Dec(42) = 3
				vValues(42) = cRODSTAR.NoverNoP
				Dec(43) = 3
				vValues(43) = cRODSTAR.FoSkr
				Dec(44) = 0
				vValues(44) = CtrlUI.ConvertUnits(cRODSTAR.PumpDepth - cRODSTAR.FluidLevel, 3)
				Dec(45) = 0
				vValues(45) = CtrlUI.ConvertUnits(cRODSTAR.FluidLevel, 3)
				vValues(46) = RESULTS1.VTrim(cRODSTAR.PU.APIDesignation)
				vValues(47) = RESULTS1.VTrim(cRODSTAR.PU.Manuf)
				vValues(48) = RESULTS1.VTrim(cRODSTAR.PU.UnitName)
				Dec(49) = -1
				vValues(49) = DBNull.Value
				Dec(50) = 2
				vValues(50) = DBNull.Value
				vValues(51) = Strings.Trim(cRODSTAR.FileComment)
				vValues(52) = RuntimeHelpers.GetObjectValue(Interaction.IIf(cRODSTAR.PU.CrankRotation = 1S, "CW", "CCW"))
				vValues(53) = DBNull.Value
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					vValues(54) = cRODSTAR.PumpFriction * RSWIN_DESC.LB__N
				Else
					vValues(54) = cRODSTAR.PumpFriction
				End If
				Dec(55) = 1
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					Dim array6 As Object() = vValues
					Dim num14 As Integer = 55
					Dim num8 As Double = CDbl(RSWIN_DESC.rst.Plhp) * 0.746
					text = "##.#"
					array6(num14) = Util.Format(num8, text)
				Else
					Dim array7 As Object() = vValues
					Dim num15 As Integer = 55
					cRODSTAR2 = cRODSTAR
					num10 = cRODSTAR2.Plhp
					text = "##.#"
					Dim text6 As String = Util.Format(num10, text)
					cRODSTAR2.Plhp = num10
					array7(num15) = text6
				End If
				Dec(56) = 2
				If cRODSTAR.Plhp = 0F Then
					vValues(56) = "N/A"
				Else
					vValues(56) = cRODSTAR.Prhp / cRODSTAR.Plhp
				End If
				Dec(57) = 2
				vValues(57) = CtrlUI.ConvertUnits(cRODSTAR.TubingOD, 11)
				Try
					Dim flag As Boolean
					Dim bCheckToAdd As Boolean = flag
					Dim flag2 As Boolean = False
					Dim num16 As Single
					Dim flag3 As Boolean
					Dim text7 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num16, bCheckToAdd, flag3, flag2, True, False)
					Dec(58) = 0
					vValues(58) = text7.Replace("System Design Score:", "")
				Catch ex2 As Exception
				End Try
				If RSWIN_DESC.bRodStarD Then
					Dim num17 As Single = 0F
					Dim num18 As Single = 0F
					Dim num19 As Single = 0F
					Dim num20 As Single = 0F
					Try
						If MImpred.CheckSurveyForDeviation() Then
							RSWIN.GetMaxAvgSideloadDogleg(num17, num18, num19, num20)
						End If
					Catch ex3 As Exception
					End Try
					Dec(59) = 1
					vValues(59) = num18
					Dec(60) = 1
					vValues(60) = num17
					Dec(61) = 1
					vValues(61) = num20
					Dec(62) = 1
					vValues(62) = num19
				End If
				cRODSTAR = Nothing
			Catch ex4 As Exception
			End Try
		End Sub

		Public Sub GetMaxAvgSideloadDogleg(ByRef fMaxSideload As Single, ByRef fAvgSideload As Single, ByRef fMaxDogleg As Single, ByRef fAvgDogleg As Single)
			' The following expression was wrapped in a checked-statement
			Try
				Dim impredObj As TEImpred = MImpred.ImpredObj
				fMaxSideload = -111111F
				fMaxDogleg = -111111F
				Dim num As Single = 0F
				Dim num2 As Single = 0F
				Dim array As Single() = New Single(impredObj.num_rod_elements - 1 + 1 - 1) {}
				Dim num3 As Single = 0F
				Dim num4 As Integer = 0
				Dim num5 As Integer = impredObj.num_rod_elements - 1
				For i As Integer = num4 To num5
					Dim num6 As Single = CSng(impredObj.get_r_e(i + 1).m_d)
					If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
						CtrlUI.ConvertValue(num6, "f", False)
					End If
					Dim num7 As Single = num6 - num3
					array(i) = num7
					num3 = num6
				Next
				Dim num8 As Single
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					num8 = 7.62F
				Else
					num8 = 25F
				End If
				Dim num9 As Integer = 0
				Dim num10 As Integer = impredObj.num_rod_elements - 1
				For i As Integer = num9 To num10
					Dim num11 As Single = CSng(impredObj.get_r_e(i + 1).max_sf_total)
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						CtrlUI.ConvertValue(num11, "l", False)
					End If

						Dim num12 As Single = CSng(Math.Abs(Math.Round(CDbl((num11 / array(i) * num8)), 2)))
						If num12 > fMaxSideload Then
							fMaxSideload = num12
						End If
						num += num12
						Dim num13 As Single = CSng(impredObj.get_r_e(i + 1).dog)
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							num13 = CSng(Math.Round(CDbl(num13) / 1.5707963267948966 * 90.0 / CDbl(array(i)) * 100.0, 2))
						Else
							num13 = CSng(Math.Round(CDbl(num13) / 1.5707963267948966 * 90.0 / CDbl(array(i)) * 30.0, 2))
						End If
						If num13 > fMaxDogleg Then
							fMaxDogleg = num13
						End If
						num2 += num13

				Next
				fAvgSideload = num / CSng(impredObj.num_rod_elements)
				fAvgDogleg = num2 / CSng(impredObj.num_rod_elements)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub GetSpreadsheetValueSpecial(iItem As Integer, iDecPlaces As Integer, ByRef iRow As Integer, ByRef iCol As Integer)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Select Case iItem
				Case -1
					Return
				Case 0
					Dim array As Object()
					Dim array5 As Boolean()
					Dim array7 As Single()
					Dim num2 As Integer
					Dim array9 As Object()
					If rst.UnknownM Then
						Dim objExcel As Object = RSWIN_DESC.objExcel
						Dim type As Type = Nothing
						Dim text As String = "XLWorkSheetAddString"
						array = New Object() { iRow, iCol, "N/A" }
						Dim array2 As Object() = array
						Dim array3 As String() = Nothing
						Dim array4 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel, type, text, array2, array3, array4, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(1)), GetType(Integer)))
						End If
					Else
						Dim objExcel2 As Object = RSWIN_DESC.objExcel
						Dim type2 As Type = Nothing
						Dim text2 As String = "XLWorkSheetAddPercent"
						array = New Object(3) {}
						array(0) = iRow
						array(1) = iCol
						Dim array6 As Object() = array
						Dim num As Integer = 2
						array7 = rst.GearboxLoading
						Dim array8 As Single() = array7
						num2 = 2
						array6(num) = array8(num2)
						array(3) = 1
						array9 = array
						Dim array10 As Object() = array9
						Dim array11 As String() = Nothing
						Dim array12 As Type() = Nothing
						array5 = New Boolean() { True, True, True, False }
						NewLateBinding.LateCall(objExcel2, type2, text2, array10, array11, array12, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
						If array5(2) Then
							array7(num2) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
						End If
					End If
					Dim objExcel3 As Object = RSWIN_DESC.objExcel
					Dim type3 As Type = Nothing
					Dim text3 As String = "XLWorkSheetAddPercent"
					array = New Object(3) {}
					array(0) = iRow
					array(1) = iCol + 1
					Dim array13 As Object() = array
					Dim num3 As Integer = 2
					array7 = rst.GearboxLoading
					Dim array14 As Single() = array7
					num2 = 1
					array13(num3) = array14(num2)
					array(3) = 1
					array9 = array
					Dim array15 As Object() = array9
					Dim array16 As String() = Nothing
					Dim array17 As Type() = Nothing
					array5 = New Boolean() { True, False, True, False }
					NewLateBinding.LateCall(objExcel3, type3, text3, array15, array16, array17, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(2) Then
						array7(num2) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
					End If
					Dim objExcel4 As Object = RSWIN_DESC.objExcel
					Dim type4 As Type = Nothing
					Dim text4 As String = "XLWorkSheetAddPercent"
					array = New Object(3) {}
					array(0) = iRow
					array(1) = iCol + 2
					Dim array18 As Object() = array
					Dim num4 As Integer = 2
					array7 = rst.GearboxLoading
					Dim array19 As Single() = array7
					num2 = 0
					array18(num4) = array19(num2)
					array(3) = 1
					array9 = array
					Dim array20 As Object() = array9
					Dim array21 As String() = Nothing
					Dim array22 As Type() = Nothing
					array5 = New Boolean() { True, False, True, False }
					NewLateBinding.LateCall(objExcel4, type4, text4, array20, array21, array22, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(2) Then
						array7(num2) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
					End If
					iCol += 2
					Return
				Case 1
					Dim array5 As Boolean()
					Dim array9 As Object()
					If rst.UnknownM Then
						Dim objExcel5 As Object = RSWIN_DESC.objExcel
						Dim type5 As Type = Nothing
						Dim text5 As String = "XLWorkSheetAddString"
						array9 = New Object() { iRow, iCol, "N/A" }
						Dim array23 As Object() = array9
						Dim array24 As String() = Nothing
						Dim array25 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel5, type5, text5, array23, array24, array25, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
					Else
						Dim objExcel6 As Object = RSWIN_DESC.objExcel
						Dim type6 As Type = Nothing
						Dim text6 As String = "XLWorkSheetAddFloat"
						array9 = New Object() { iRow, iCol, CtrlUI.ConvertUnits(rst.PeakTorque(2) / 1000F, 10), iDecPlaces }
						Dim array26 As Object() = array9
						Dim array27 As String() = Nothing
						Dim array28 As Type() = Nothing
						array5 = New Boolean() { True, True, False, True }
						NewLateBinding.LateCall(objExcel6, type6, text6, array26, array27, array28, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
						End If
					End If
					Dim objExcel7 As Object = RSWIN_DESC.objExcel
					Dim type7 As Type = Nothing
					Dim text7 As String = "XLWorkSheetAddFloat"
					array9 = New Object() { iRow, iCol + 1, CtrlUI.ConvertUnits(rst.PeakTorque(1) / 1000F, 10), iDecPlaces }
					Dim array29 As Object() = array9
					Dim array30 As String() = Nothing
					Dim array31 As Type() = Nothing
					array5 = New Boolean() { True, False, False, True }
					NewLateBinding.LateCall(objExcel7, type7, text7, array29, array30, array31, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					Dim objExcel8 As Object = RSWIN_DESC.objExcel
					Dim type8 As Type = Nothing
					Dim text8 As String = "XLWorkSheetAddFloat"
					array9 = New Object() { iRow, iCol + 2, CtrlUI.ConvertUnits(rst.PeakTorque(0) / 1000F, 10), iDecPlaces }
					Dim array32 As Object() = array9
					Dim array33 As String() = Nothing
					Dim array34 As Type() = Nothing
					array5 = New Boolean() { True, False, False, True }
					NewLateBinding.LateCall(objExcel8, type8, text8, array32, array33, array34, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					iCol += 2
					Return
				Case 2
					Dim array5 As Boolean()
					Dim array9 As Object()
					If rst.UnknownM Then
						Dim objExcel9 As Object = RSWIN_DESC.objExcel
						Dim type9 As Type = Nothing
						Dim text9 As String = "XLWorkSheetAddString"
						array9 = New Object() { iRow, iCol, "N/A" }
						Dim array35 As Object() = array9
						Dim array36 As String() = Nothing
						Dim array37 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel9, type9, text9, array35, array36, array37, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
					Else
						Dim objExcel10 As Object = RSWIN_DESC.objExcel
						Dim type10 As Type = Nothing
						Dim text10 As String = "XLWorkSheetAddFloat"
						array9 = New Object() { iRow, iCol, CtrlUI.ConvertUnits(rst.CBE90(2), 12), iDecPlaces }
						Dim array38 As Object() = array9
						Dim array39 As String() = Nothing
						Dim array40 As Type() = Nothing
						array5 = New Boolean() { True, True, False, True }
						NewLateBinding.LateCall(objExcel10, type10, text10, array38, array39, array40, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
						End If
					End If
					Dim objExcel11 As Object = RSWIN_DESC.objExcel
					Dim type11 As Type = Nothing
					Dim text11 As String = "XLWorkSheetAddFloat"
					array9 = New Object() { iRow, iCol + 1, CtrlUI.ConvertUnits(rst.CBE90(1), 12), iDecPlaces }
					Dim array41 As Object() = array9
					Dim array42 As String() = Nothing
					Dim array43 As Type() = Nothing
					array5 = New Boolean() { True, False, False, True }
					NewLateBinding.LateCall(objExcel11, type11, text11, array41, array42, array43, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					Dim objExcel12 As Object = RSWIN_DESC.objExcel
					Dim type12 As Type = Nothing
					Dim text12 As String = "XLWorkSheetAddFloat"
					array9 = New Object() { iRow, iCol + 2, CtrlUI.ConvertUnits(rst.CBE90(0), 12), iDecPlaces }
					Dim array44 As Object() = array9
					Dim array45 As String() = Nothing
					Dim array46 As Type() = Nothing
					array5 = New Boolean() { True, False, False, True }
					NewLateBinding.LateCall(objExcel12, type12, text12, array44, array45, array46, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					iCol += 2
					Return
				Case 3
					Dim array5 As Boolean()
					Dim array9 As Object()
					If rst.UnknownM Then
						Dim objExcel13 As Object = RSWIN_DESC.objExcel
						Dim type13 As Type = Nothing
						Dim text13 As String = "XLWorkSheetAddString"
						array9 = New Object() { iRow, iCol, "N/A" }
						Dim array47 As Object() = array9
						Dim array48 As String() = Nothing
						Dim array49 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel13, type13, text13, array47, array48, array49, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
					Else
						Dim objExcel14 As Object = RSWIN_DESC.objExcel
						Dim type14 As Type = Nothing
						Dim text14 As String = "XLWorkSheetAddFloat"
						array9 = New Object() { iRow, iCol, CtrlUI.ConvertUnits(rst.get_M(2) / 1000F, 10), iDecPlaces }
						Dim array50 As Object() = array9
						Dim array51 As String() = Nothing
						Dim array52 As Type() = Nothing
						array5 = New Boolean() { True, True, False, True }
						NewLateBinding.LateCall(objExcel14, type14, text14, array50, array51, array52, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
						End If
					End If
					Dim objExcel15 As Object = RSWIN_DESC.objExcel
					Dim type15 As Type = Nothing
					Dim text15 As String = "XLWorkSheetAddFloat"
					array9 = New Object() { iRow, iCol + 1, CtrlUI.ConvertUnits(rst.get_M(1) / 1000F, 10), iDecPlaces }
					Dim array53 As Object() = array9
					Dim array54 As String() = Nothing
					Dim array55 As Type() = Nothing
					array5 = New Boolean() { True, False, False, True }
					NewLateBinding.LateCall(objExcel15, type15, text15, array53, array54, array55, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					Dim objExcel16 As Object = RSWIN_DESC.objExcel
					Dim type16 As Type = Nothing
					Dim text16 As String = "XLWorkSheetAddFloat"
					array9 = New Object() { iRow, iCol + 2, CtrlUI.ConvertUnits(rst.get_M(0) / 1000F, 10), iDecPlaces }
					Dim array56 As Object() = array9
					Dim array57 As String() = Nothing
					Dim array58 As Type() = Nothing
					array5 = New Boolean() { True, False, False, True }
					NewLateBinding.LateCall(objExcel16, type16, text16, array56, array57, array58, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					iCol += 2
					Return
				Case 4
					Dim array As Object()
					Dim array5 As Boolean()
					Dim array7 As Single()
					Dim num2 As Integer
					Dim array9 As Object()
					If rst.UnknownM Then
						Dim objExcel17 As Object = RSWIN_DESC.objExcel
						Dim type17 As Type = Nothing
						Dim text17 As String = "XLWorkSheetAddString"
						array9 = New Object() { iRow, iCol, "N/A" }
						Dim array59 As Object() = array9
						Dim array60 As String() = Nothing
						Dim array61 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel17, type17, text17, array59, array60, array61, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
					Else
						Dim objExcel18 As Object = RSWIN_DESC.objExcel
						Dim type18 As Type = Nothing
						Dim text18 As String = "XLWorkSheetAddFloat"
						array = New Object(3) {}
						array(0) = iRow
						array(1) = iCol
						Dim array62 As Object() = array
						Dim num5 As Integer = 2
						array7 = rst.Clf
						Dim array63 As Single() = array7
						num2 = 2
						array62(num5) = array63(num2)
						array(3) = iDecPlaces
						array9 = array
						Dim array64 As Object() = array9
						Dim array65 As String() = Nothing
						Dim array66 As Type() = Nothing
						array5 = New Boolean() { True, True, True, True }
						NewLateBinding.LateCall(objExcel18, type18, text18, array64, array65, array66, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
						If array5(2) Then
							array7(num2) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
						End If
					End If
					Dim objExcel19 As Object = RSWIN_DESC.objExcel
					Dim type19 As Type = Nothing
					Dim text19 As String = "XLWorkSheetAddFloat"
					array = New Object(3) {}
					array(0) = iRow
					array(1) = iCol + 1
					Dim array67 As Object() = array
					Dim num6 As Integer = 2
					array7 = rst.Clf
					Dim array68 As Single() = array7
					num2 = 1
					array67(num6) = array68(num2)
					array(3) = iDecPlaces
					array9 = array
					Dim array69 As Object() = array9
					Dim array70 As String() = Nothing
					Dim array71 As Type() = Nothing
					array5 = New Boolean() { True, False, True, True }
					NewLateBinding.LateCall(objExcel19, type19, text19, array69, array70, array71, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(2) Then
						array7(num2) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					Dim objExcel20 As Object = RSWIN_DESC.objExcel
					Dim type20 As Type = Nothing
					Dim text20 As String = "XLWorkSheetAddFloat"
					array = New Object(3) {}
					array(0) = iRow
					array(1) = iCol + 2
					Dim array72 As Object() = array
					Dim num7 As Integer = 2
					array7 = rst.Clf
					Dim array73 As Single() = array7
					num2 = 0
					array72(num7) = array73(num2)
					array(3) = iDecPlaces
					array9 = array
					Dim array74 As Object() = array9
					Dim array75 As String() = Nothing
					Dim array76 As Type() = Nothing
					array5 = New Boolean() { True, False, True, True }
					NewLateBinding.LateCall(objExcel20, type20, text20, array74, array75, array76, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(2) Then
						array7(num2) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					iCol += 2
					Return
				Case 5
					Dim array As Object()
					Dim array5 As Boolean()
					Dim array7 As Single()
					Dim num2 As Integer
					Dim array9 As Object()
					If rst.UnknownM Then
						Dim objExcel21 As Object = RSWIN_DESC.objExcel
						Dim type21 As Type = Nothing
						Dim text21 As String = "XLWorkSheetAddString"
						array9 = New Object() { iRow, iCol, "N/A" }
						Dim array77 As Object() = array9
						Dim array78 As String() = Nothing
						Dim array79 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel21, type21, text21, array77, array78, array79, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
					Else
						Dim objExcel22 As Object = RSWIN_DESC.objExcel
						Dim type22 As Type = Nothing
						Dim text22 As String = "XLWorkSheetAddFloat"
						array = New Object(3) {}
						array(0) = iRow
						array(1) = iCol
						Dim array80 As Object() = array
						Dim num8 As Integer = 2
						array7 = rst.MotorKWH
						Dim array81 As Single() = array7
						num2 = 2
						array80(num8) = array81(num2)
						array(3) = iDecPlaces
						array9 = array
						Dim array82 As Object() = array9
						Dim array83 As String() = Nothing
						Dim array84 As Type() = Nothing
						array5 = New Boolean() { True, True, True, True }
						NewLateBinding.LateCall(objExcel22, type22, text22, array82, array83, array84, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
						If array5(2) Then
							array7(num2) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
						End If
					End If
					Dim objExcel23 As Object = RSWIN_DESC.objExcel
					Dim type23 As Type = Nothing
					Dim text23 As String = "XLWorkSheetAddFloat"
					array = New Object(3) {}
					array(0) = iRow
					array(1) = iCol + 1
					Dim array85 As Object() = array
					Dim num9 As Integer = 2
					array7 = rst.MotorKWH
					Dim array86 As Single() = array7
					num2 = 1
					array85(num9) = array86(num2)
					array(3) = iDecPlaces
					array9 = array
					Dim array87 As Object() = array9
					Dim array88 As String() = Nothing
					Dim array89 As Type() = Nothing
					array5 = New Boolean() { True, False, True, True }
					NewLateBinding.LateCall(objExcel23, type23, text23, array87, array88, array89, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(2) Then
						array7(num2) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					Dim objExcel24 As Object = RSWIN_DESC.objExcel
					Dim type24 As Type = Nothing
					Dim text24 As String = "XLWorkSheetAddFloat"
					array = New Object(3) {}
					array(0) = iRow
					array(1) = iCol + 2
					Dim array90 As Object() = array
					Dim num10 As Integer = 2
					array7 = rst.MotorKWH
					Dim array91 As Single() = array7
					num2 = 0
					array90(num10) = array91(num2)
					array(3) = iDecPlaces
					array9 = array
					Dim array92 As Object() = array9
					Dim array93 As String() = Nothing
					Dim array94 As Type() = Nothing
					array5 = New Boolean() { True, False, True, True }
					NewLateBinding.LateCall(objExcel24, type24, text24, array92, array93, array94, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(2) Then
						array7(num2) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					iCol += 2
					Return
				Case 6
					Dim array As Object()
					Dim array5 As Boolean()
					Dim num2 As Integer
					Dim array9 As Object()
					Dim cRODSTAR As cRODSTAR
					If rst.UnknownM Then
						Dim objExcel25 As Object = RSWIN_DESC.objExcel
						Dim type25 As Type = Nothing
						Dim text25 As String = "XLWorkSheetAddString"
						array9 = New Object() { iRow, iCol, "N/A" }
						Dim array95 As Object() = array9
						Dim array96 As String() = Nothing
						Dim array97 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel25, type25, text25, array95, array96, array97, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
					Else
						Dim objExcel26 As Object = RSWIN_DESC.objExcel
						Dim type26 As Type = Nothing
						Dim text26 As String = "XLWorkSheetAddFloat"
						array = New Object(3) {}
						array(0) = iRow
						array(1) = iCol
						Dim array98 As Object() = array
						Dim num11 As Integer = 2
						cRODSTAR = rst
						Dim cRODSTAR2 As cRODSTAR = cRODSTAR
						num2 = 2
						array98(num11) = cRODSTAR2.get_ElectricBillperMonth(num2)
						array(3) = iDecPlaces
						array9 = array
						Dim array99 As Object() = array9
						Dim array100 As String() = Nothing
						Dim array101 As Type() = Nothing
						array5 = New Boolean() { True, True, True, True }
						NewLateBinding.LateCall(objExcel26, type26, text26, array99, array100, array101, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
						If array5(2) Then
							cRODSTAR.set_ElectricBillperMonth(num2, CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single))))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
						End If
					End If
					Dim objExcel27 As Object = RSWIN_DESC.objExcel
					Dim type27 As Type = Nothing
					Dim text27 As String = "XLWorkSheetAddFloat"
					array = New Object(3) {}
					array(0) = iRow
					array(1) = iCol + 1
					Dim array102 As Object() = array
					Dim num12 As Integer = 2
					cRODSTAR = rst
					Dim cRODSTAR3 As cRODSTAR = cRODSTAR
					num2 = 1
					array102(num12) = cRODSTAR3.get_ElectricBillperMonth(num2)
					array(3) = iDecPlaces
					array9 = array
					Dim array103 As Object() = array9
					Dim array104 As String() = Nothing
					Dim array105 As Type() = Nothing
					array5 = New Boolean() { True, False, True, True }
					NewLateBinding.LateCall(objExcel27, type27, text27, array103, array104, array105, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(2) Then
						cRODSTAR.set_ElectricBillperMonth(num2, CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single))))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					Dim objExcel28 As Object = RSWIN_DESC.objExcel
					Dim type28 As Type = Nothing
					Dim text28 As String = "XLWorkSheetAddFloat"
					array = New Object(3) {}
					array(0) = iRow
					array(1) = iCol + 2
					Dim array106 As Object() = array
					Dim num13 As Integer = 2
					cRODSTAR = rst
					Dim cRODSTAR4 As cRODSTAR = cRODSTAR
					num2 = 0
					array106(num13) = cRODSTAR4.get_ElectricBillperMonth(num2)
					array(3) = iDecPlaces
					array9 = array
					Dim array107 As Object() = array9
					Dim array108 As String() = Nothing
					Dim array109 As Type() = Nothing
					array5 = New Boolean() { True, False, True, True }
					NewLateBinding.LateCall(objExcel28, type28, text28, array107, array108, array109, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(2) Then
						cRODSTAR.set_ElectricBillperMonth(num2, CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single))))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					iCol += 2
					Return
				Case 7
					Dim array5 As Boolean()
					Dim array9 As Object()
					If rst.UnknownM Then
						Dim objExcel29 As Object = RSWIN_DESC.objExcel
						Dim type29 As Type = Nothing
						Dim text29 As String = "XLWorkSheetAddString"
						array9 = New Object() { iRow, iCol, "N/A" }
						Dim array110 As Object() = array9
						Dim array111 As String() = Nothing
						Dim array112 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel29, type29, text29, array110, array111, array112, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
					Else
						Dim objExcel30 As Object = RSWIN_DESC.objExcel
						Dim type30 As Type = Nothing
						Dim text30 As String = "XLWorkSheetAddFloat"
						array9 = New Object() { iRow, iCol, CtrlUI.ConvertUnits(rst.DollarsPerBblOil(2), 6), iDecPlaces }
						Dim array113 As Object() = array9
						Dim array114 As String() = Nothing
						Dim array115 As Type() = Nothing
						array5 = New Boolean() { True, True, False, True }
						NewLateBinding.LateCall(objExcel30, type30, text30, array113, array114, array115, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
						End If
					End If
					Dim objExcel31 As Object = RSWIN_DESC.objExcel
					Dim type31 As Type = Nothing
					Dim text31 As String = "XLWorkSheetAddFloat"
					array9 = New Object() { iRow, iCol + 1, CtrlUI.ConvertUnits(rst.DollarsPerBblOil(1), 6), iDecPlaces }
					Dim array116 As Object() = array9
					Dim array117 As String() = Nothing
					Dim array118 As Type() = Nothing
					array5 = New Boolean() { True, False, False, True }
					NewLateBinding.LateCall(objExcel31, type31, text31, array116, array117, array118, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					Dim objExcel32 As Object = RSWIN_DESC.objExcel
					Dim type32 As Type = Nothing
					Dim text32 As String = "XLWorkSheetAddFloat"
					array9 = New Object() { iRow, iCol + 2, CtrlUI.ConvertUnits(rst.DollarsPerBblOil(0), 6), iDecPlaces }
					Dim array119 As Object() = array9
					Dim array120 As String() = Nothing
					Dim array121 As Type() = Nothing
					array5 = New Boolean() { True, False, False, True }
					NewLateBinding.LateCall(objExcel32, type32, text32, array119, array120, array121, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					iCol += 2
					Return
				Case 8
					Dim array5 As Boolean()
					Dim array9 As Object()
					If rst.UnknownM Then
						Dim objExcel33 As Object = RSWIN_DESC.objExcel
						Dim type33 As Type = Nothing
						Dim text33 As String = "XLWorkSheetAddString"
						array9 = New Object() { iRow, iCol, "N/A" }
						Dim array122 As Object() = array9
						Dim array123 As String() = Nothing
						Dim array124 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel33, type33, text33, array122, array123, array124, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
					Else
						Dim objExcel34 As Object = RSWIN_DESC.objExcel
						Dim type34 As Type = Nothing
						Dim text34 As String = "XLWorkSheetAddFloat"
						array9 = New Object() { iRow, iCol, CtrlUI.ConvertUnits(rst.DollarsPerBblFluid(2), 6), iDecPlaces }
						Dim array125 As Object() = array9
						Dim array126 As String() = Nothing
						Dim array127 As Type() = Nothing
						array5 = New Boolean() { True, True, False, True }
						NewLateBinding.LateCall(objExcel34, type34, text34, array125, array126, array127, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
						End If
					End If
					Dim objExcel35 As Object = RSWIN_DESC.objExcel
					Dim type35 As Type = Nothing
					Dim text35 As String = "XLWorkSheetAddFloat"
					array9 = New Object() { iRow, iCol + 1, CtrlUI.ConvertUnits(rst.DollarsPerBblFluid(1), 6), iDecPlaces }
					Dim array128 As Object() = array9
					Dim array129 As String() = Nothing
					Dim array130 As Type() = Nothing
					array5 = New Boolean() { True, False, False, True }
					NewLateBinding.LateCall(objExcel35, type35, text35, array128, array129, array130, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					Dim objExcel36 As Object = RSWIN_DESC.objExcel
					Dim type36 As Type = Nothing
					Dim text36 As String = "XLWorkSheetAddFloat"
					array9 = New Object() { iRow, iCol + 2, CtrlUI.ConvertUnits(rst.DollarsPerBblFluid(0), 6), iDecPlaces }
					Dim array131 As Object() = array9
					Dim array132 As String() = Nothing
					Dim array133 As Type() = Nothing
					array5 = New Boolean() { True, False, False, True }
					NewLateBinding.LateCall(objExcel36, type36, text36, array131, array132, array133, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(3) Then
						iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
					End If
					iCol += 2
					Return
				Case 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 51, 52
					Return
				Case 37
					Dim num14 As Single = 0F
					Dim num15 As Integer = 1
					Dim numRods As Integer = CInt(rst.NumRods)
					For i As Integer = num15 To numRods
						Dim sDBKey As String
						COSTDB.MakeRGKey(rst.Sections(i).Grade, Strings.Trim(rst.Sections(i).RodType), rst.Sections(i).Diameter, sDBKey)
						Dim num16 As Single
						COSTDB.DBLookup(sDBKey, num16)

							If num16 = 0F Then
								num14 = -1F
							ElseIf num14 >= 0F Then
								num14 += num16 * rst.Sections(i).length
							End If

					Next

						Dim array5 As Boolean()
						Dim array9 As Object()
						If num14 >= 0F Then
							num14 += rst.RSExtraCost
							Dim objExcel37 As Object = RSWIN_DESC.objExcel
							Dim type37 As Type = Nothing
							Dim text37 As String = "XLWorkSheetAddFloat"
							array9 = New Object() { iRow, iCol, num14, iDecPlaces }
							Dim array134 As Object() = array9
							Dim array135 As String() = Nothing
							Dim array136 As Type() = Nothing
							array5 = New Boolean() { True, True, True, True }
							NewLateBinding.LateCall(objExcel37, type37, text37, array134, array135, array136, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
							End If
							If array5(2) Then
								num14 = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
							End If
							If array5(3) Then
								iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
							End If
							Return
						End If
						Dim objExcel38 As Object = RSWIN_DESC.objExcel
						Dim type38 As Type = Nothing
						Dim text38 As String = "XLWorkSheetAddString"
						array9 = New Object() { iRow, iCol, "N/A" }
						Dim array137 As Object() = array9
						Dim array138 As String() = Nothing
						Dim array139 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel38, type38, text38, array137, array138, array139, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
							Return
						End If
						Return

				Case 49
					Try
						If Conversions.ToBoolean(Operators.OrObject(Operators.NotObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False)), Not rst.CalcMotorSize)) Then
							Dim objExcel39 As Object = RSWIN_DESC.objExcel
							Dim type39 As Type = Nothing
							Dim text39 As String = "XLWorkSheetAddString"
							Dim array9 As Object() = New Object() { iRow, iCol, "N/A" }
							Dim array140 As Object() = array9
							Dim array141 As String() = Nothing
							Dim array142 As Type() = Nothing
							Dim array5 As Boolean() = New Boolean() { True, True, False }
							NewLateBinding.LateCall(objExcel39, type39, text39, array140, array141, array142, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
							End If
							Dim objExcel40 As Object = RSWIN_DESC.objExcel
							Dim type40 As Type = Nothing
							Dim text40 As String = "XLWorkSheetAddString"
							array9 = New Object() { iRow, iCol + 1, "N/A" }
							Dim array143 As Object() = array9
							Dim array144 As String() = Nothing
							Dim array145 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel40, type40, text40, array143, array144, array145, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
							End If
							Dim objExcel41 As Object = RSWIN_DESC.objExcel
							Dim type41 As Type = Nothing
							Dim text41 As String = "XLWorkSheetAddString"
							array9 = New Object() { iRow, iCol + 2, "N/A" }
							Dim array146 As Object() = array9
							Dim array147 As String() = Nothing
							Dim array148 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel41, type41, text41, array146, array147, array148, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
							End If
						Else
							Dim array As Object()
							Dim array5 As Boolean()
							Dim array7 As Single()
							Dim num2 As Integer
							Dim array9 As Object()
							If RSWIN_DESC.rst.CalcMotorSize <> 0S Then
								Dim objExcel42 As Object = RSWIN_DESC.objExcel
								Dim type42 As Type = Nothing
								Dim text42 As String = "XLWorkSheetAddString"
								array9 = New Object() { iRow, iCol, "N/A" }
								Dim array149 As Object() = array9
								Dim array150 As String() = Nothing
								Dim array151 As Type() = Nothing
								array5 = New Boolean() { True, True, False }
								NewLateBinding.LateCall(objExcel42, type42, text42, array149, array150, array151, array5, True)
								If array5(0) Then
									iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
								End If
								If array5(1) Then
									iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
								End If
							Else
								Dim objExcel43 As Object = RSWIN_DESC.objExcel
								Dim type43 As Type = Nothing
								Dim text43 As String = "XLWorkSheetAddFloat"
								array = New Object(3) {}
								array(0) = iRow
								array(1) = iCol
								Dim array152 As Object() = array
								Dim num17 As Integer = 2
								array7 = rst.HpNemaD
								Dim array153 As Single() = array7
								num2 = 2
								array152(num17) = array153(num2)
								array(3) = iDecPlaces
								array9 = array
								Dim array154 As Object() = array9
								Dim array155 As String() = Nothing
								Dim array156 As Type() = Nothing
								array5 = New Boolean() { True, True, True, True }
								NewLateBinding.LateCall(objExcel43, type43, text43, array154, array155, array156, array5, True)
								If array5(0) Then
									iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
								End If
								If array5(1) Then
									iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
								End If
								If array5(2) Then
									array7(num2) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
								End If
								If array5(3) Then
									iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
								End If
							End If
							Dim objExcel44 As Object = RSWIN_DESC.objExcel
							Dim type44 As Type = Nothing
							Dim text44 As String = "XLWorkSheetAddFloat"
							array = New Object(3) {}
							array(0) = iRow
							array(1) = iCol + 1
							Dim array157 As Object() = array
							Dim num18 As Integer = 2
							array7 = rst.HpNemaD
							Dim array158 As Single() = array7
							num2 = 1
							array157(num18) = array158(num2)
							array(3) = iDecPlaces
							array9 = array
							Dim array159 As Object() = array9
							Dim array160 As String() = Nothing
							Dim array161 As Type() = Nothing
							array5 = New Boolean() { True, False, True, True }
							NewLateBinding.LateCall(objExcel44, type44, text44, array159, array160, array161, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
							End If
							If array5(2) Then
								array7(num2) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
							End If
							If array5(3) Then
								iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
							End If
							Dim objExcel45 As Object = RSWIN_DESC.objExcel
							Dim type45 As Type = Nothing
							Dim text45 As String = "XLWorkSheetAddFloat"
							array = New Object(3) {}
							array(0) = iRow
							array(1) = iCol + 2
							Dim array162 As Object() = array
							Dim num19 As Integer = 2
							array7 = rst.HpNemaD
							Dim array163 As Single() = array7
							num2 = 0
							array162(num19) = array163(num2)
							array(3) = iDecPlaces
							array9 = array
							Dim array164 As Object() = array9
							Dim array165 As String() = Nothing
							Dim array166 As Type() = Nothing
							array5 = New Boolean() { True, False, True, True }
							NewLateBinding.LateCall(objExcel45, type45, text45, array164, array165, array166, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
							End If
							If array5(2) Then
								array7(num2) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
							End If
							If array5(3) Then
								iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
							End If
						End If
					Catch ex As Exception
					End Try
					iCol += 2
					Return
				Case 50
					Try
						Dim sDBKey As String = "PU/" + rst.UnitID
						Dim num14 As Single
						COSTDB.DBLookup(sDBKey, num14)
						If num14 <= 0F Then
							Dim objExcel46 As Object = RSWIN_DESC.objExcel
							Dim type46 As Type = Nothing
							Dim text46 As String = "XLWorkSheetAddString"
							Dim array9 As Object() = New Object() { iRow, iCol, "N/A" }
							Dim array167 As Object() = array9
							Dim array168 As String() = Nothing
							Dim array169 As Type() = Nothing
							Dim array5 As Boolean() = New Boolean() { True, True, False }
							NewLateBinding.LateCall(objExcel46, type46, text46, array167, array168, array169, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
							End If
						Else
							Dim objExcel47 As Object = RSWIN_DESC.objExcel
							Dim type47 As Type = Nothing
							Dim text47 As String = "XLWorkSheetAddFloat"
							Dim array9 As Object() = New Object() { iRow, iCol, num14, iDecPlaces }
							Dim array170 As Object() = array9
							Dim array171 As String() = Nothing
							Dim array172 As Type() = Nothing
							Dim array5 As Boolean() = New Boolean() { True, True, True, True }
							NewLateBinding.LateCall(objExcel47, type47, text47, array170, array171, array172, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
							End If
							If array5(2) Then
								num14 = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(2)), GetType(Single)))
							End If
							If array5(3) Then
								iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(3)), GetType(Integer)))
							End If
						End If
						Return
					Catch ex2 As Exception
						Return
					End Try
				Case 53
				Case Else
					Return
			End Select
			Try
				If RSWIN_DESC.rst.gbIncludeBuoyancy Then
					Dim objExcel48 As Object = RSWIN_DESC.objExcel
					Dim type48 As Type = Nothing
					Dim text48 As String = "XLWorkSheetAddString"
					Dim array9 As Object() = New Object() { iRow, iCol, "Yes" }
					Dim array173 As Object() = array9
					Dim array174 As String() = Nothing
					Dim array175 As Type() = Nothing
					Dim array5 As Boolean() = New Boolean() { True, True, False }
					NewLateBinding.LateCall(objExcel48, type48, text48, array173, array174, array175, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(1) Then
						iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
					End If
				Else
					Dim objExcel49 As Object = RSWIN_DESC.objExcel
					Dim type49 As Type = Nothing
					Dim text49 As String = "XLWorkSheetAddString"
					Dim array9 As Object() = New Object() { iRow, iCol, "No" }
					Dim array176 As Object() = array9
					Dim array177 As String() = Nothing
					Dim array178 As Type() = Nothing
					Dim array5 As Boolean() = New Boolean() { True, True, False }
					NewLateBinding.LateCall(objExcel49, type49, text49, array176, array177, array178, array5, True)
					If array5(0) Then
						iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Integer)))
					End If
					If array5(1) Then
						iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(Integer)))
					End If
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub GetSpreadsheetValueSpecial_Save(iItem As Integer, iDecPlaces As Integer, ByRef iRow As Integer, ByRef iCol As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Select Case iItem
					Case 0
						Dim text As String = ""
						If RSWIN_DESC.gSysDiag.iDiagRodPart <> 0S Then
							text += "Rod part; "
						ElseIf RSWIN_DESC.gSysDiag.bStuckPump <> 0S Then
							text += "Stuck pump; "
						ElseIf RSWIN_DESC.gSysDiag.bSurfaceMatchPoor <> 0S Then
							text += "Possible severe pump wear; "
						ElseIf RSWIN_DESC.gSysDiag.bUnknownPumpCondition <> 0S Then
							text += "Unable to determine; "
						Else
							If(RSWIN_DESC.gSysDiag.bFullPump And RSWIN_DESC.gSysDiag.bPumpConditionGood) <> 0S Then
								text = "Full pump; "
							Else
								If Not RSWIN_DESC.gSysDiag.bFullPump <> 0S Then
									If RSWIN_DESC.gSysDiag.bFluidPound <> 0S Then
										text += "Fluid pound; "
									ElseIf RSWIN_DESC.gSysDiag.bGasInterference <> 0S Then
										text += "Gas interference; "
									Else
										text += "Incomplete pump fillage; "
									End If
									If RSWIN_DESC.gSysDiag.iWornPump = 0S Then
										Dim text2 As String = ""
										If(RSWIN_DESC.gSysDiag.iTVLeak And RSWIN_DESC.gSysDiag.iSVLeak) <> 0 Then
											text2 = "TV and SV leaks"
										ElseIf RSWIN_DESC.gSysDiag.iTVLeak <> 0 Then
											text2 = "TV leak"
										ElseIf RSWIN_DESC.gSysDiag.iSVLeak <> 0 Then
											text2 = "SV leak"
										End If
										If Strings.Len(text2) > 0 Then
											text = text + "possible " + text2 + "; "
										End If
									End If
								ElseIf RSWIN_DESC.gSysDiag.iWornPump = 0S Then
									Dim num As Integer = Convert.ToInt32(RSWIN_DESC.gSysDiag.iTVLeak)
									Dim text3 As String
									If num = -1073741824 Then
										text3 = "slight TV leak"
									ElseIf num = -2147483648 Then
										text3 = "TV leak"
									ElseIf num = 1073741824 Then
										text3 = "severe TV leak"
									End If
									Dim num2 As Integer = Convert.ToInt32(RSWIN_DESC.gSysDiag.iSVLeak)
									Dim text4 As String
									If num2 = -1073741824 Then
										text4 = "slight SV leak"
									ElseIf num2 = -2147483648 Then
										text4 = "SV leak"
									ElseIf num2 = 1073741824 Then
										text4 = "severe SV leak"
									End If
									If(RSWIN_DESC.gSysDiag.iTVLeak And RSWIN_DESC.gSysDiag.iSVLeak) <> 0 Then
										text = String.Concat(New String() { text, text3, "; ", text4, "; " })
									ElseIf RSWIN_DESC.gSysDiag.iTVLeak <> 0 Then
										text = text + text3 + "; "
									ElseIf RSWIN_DESC.gSysDiag.iSVLeak <> 0 Then
										text = text + text4 + "; "
									End If
								End If
								If RSWIN_DESC.gSysDiag.iWornPump > 0S Then
									Dim iWornPump As Short = RSWIN_DESC.gSysDiag.iWornPump
									If iWornPump = 3S Then
										text += "severe pump wear or rod part; "
									Else
										text += "worn pump; "
									End If
								End If
								If RSWIN_DESC.gSysDiag.iWornPumpBarrel <> 0S Then
									text += "worn pump barrel; "
								End If
								If RSWIN_DESC.gSysDiag.bBentPumpBarrel <> 0S Then
									text += "bent pump barrel or sticking plunger; "
								End If
								If RSWIN_DESC.gSysDiag.bHittingUp <> 0S Then
									text += "pump hitting up; "
								ElseIf RSWIN_DESC.gSysDiag.bHittingDown <> 0S Then
									text += "pump hitting down; "
								End If
								If RSWIN_DESC.gSysDiag.bRodTubingFriction <> 0S Then
									text += "high rod-tubing friction; "
								End If
							End If
							If RSWIN_DESC.rst.TubingAnchored <> 0S AndAlso RSWIN_DESC.gSysDiag.bTubingAnchorLoose <> 0S Then
								text += "anchor not holding; "
							End If
							If RSWIN_DESC.gSysDiag.iAdjustPhase <> 0S Then
								text += "phase shift in dyno card; "
							End If
						End If
						text = Strings.UCase(Strings.Left(text, 1)) + Strings.Mid(text, 2)
						Dim text5 As String = Strings.Left(text, Strings.InStr(text, ";", CompareMethod.Binary) - 1)
						StringType.MidStmtStr(text5, 1, 1, Strings.UCase(Strings.Left(text5, 1)))
						text = Strings.Mid(text, Strings.InStr(text, ";", CompareMethod.Binary) + 2)
						Dim text6 As String
						If Strings.InStr(text, ";", CompareMethod.Binary) > 0 Then
							text6 = Strings.Left(text, Strings.InStr(text, ";", CompareMethod.Binary) - 1)
							StringType.MidStmtStr(text6, 1, 1, Strings.UCase(Strings.Left(text6, 1)))
						Else
							text6 = ""
						End If
						Dim objExcel As Object = RSWIN_DESC.objExcel
						Dim type As Type = Nothing
						Dim text7 As String = "XLWorkSheetAddString"
						Dim array As Object() = New Object() { iRow, iCol, text5 }
						Dim array2 As Object() = array
						Dim array3 As String() = Nothing
						Dim array4 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { True, True, True }
						NewLateBinding.LateCall(objExcel, type, text7, array2, array3, array4, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(1)), GetType(Integer)))
						End If
						If array5(2) Then
							text5 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(2)), GetType(String)))
						End If
						If Strings.Len(text6) > 0 Then
							Dim objExcel2 As Object = RSWIN_DESC.objExcel
							Dim type2 As Type = Nothing
							Dim text8 As String = "XLWorkSheetAddString"
							Dim array6 As Object() = New Object() { iRow, iCol + 1, text6 }
							Dim array7 As Object() = array6
							Dim array8 As String() = Nothing
							Dim array9 As Type() = Nothing
							array5 = New Boolean() { True, False, True }
							NewLateBinding.LateCall(objExcel2, type2, text8, array7, array8, array9, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(2) Then
								text6 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(String)))
							End If
						End If
						iCol += 1
					Case 4
						Dim array5 As Boolean()
						Dim array6 As Object()
						If RSWIN_DESC.rst.UnknownM Then
							Dim objExcel3 As Object = RSWIN_DESC.objExcel
							Dim type3 As Type = Nothing
							Dim text9 As String = "XLWorkSheetAddString"
							array6 = New Object() { iRow, iCol, "N/A" }
							Dim array10 As Object() = array6
							Dim array11 As String() = Nothing
							Dim array12 As Type() = Nothing
							array5 = New Boolean() { True, True, False }
							NewLateBinding.LateCall(objExcel3, type3, text9, array10, array11, array12, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
						Else
							Dim objExcel4 As Object = RSWIN_DESC.objExcel
							Dim type4 As Type = Nothing
							Dim text10 As String = "XLWorkSheetAddFloat"
							array6 = New Object() { iRow, iCol, Operators.MultiplyObject(RSWIN_DESC.rst.DollarsPerBblOil(2), Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 1, 1F / RSWIN_DESC.BPD__M3D)), iDecPlaces }
							Dim array13 As Object() = array6
							Dim array14 As String() = Nothing
							Dim array15 As Type() = Nothing
							array5 = New Boolean() { True, True, False, True }
							NewLateBinding.LateCall(objExcel4, type4, text10, array13, array14, array15, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
							If array5(3) Then
								iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
							End If
						End If
						Dim objExcel5 As Object = RSWIN_DESC.objExcel
						Dim type5 As Type = Nothing
						Dim text11 As String = "XLWorkSheetAddFloat"
						array6 = New Object() { iRow, iCol + 1, Operators.MultiplyObject(RSWIN_DESC.rst.DollarsPerBblOil(1), Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 1, 1F / RSWIN_DESC.BPD__M3D)), iDecPlaces }
						Dim array16 As Object() = array6
						Dim array17 As String() = Nothing
						Dim array18 As Type() = Nothing
						array5 = New Boolean() { True, False, False, True }
						NewLateBinding.LateCall(objExcel5, type5, text11, array16, array17, array18, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						Dim objExcel6 As Object = RSWIN_DESC.objExcel
						Dim type6 As Type = Nothing
						Dim text12 As String = "XLWorkSheetAddFloat"
						array6 = New Object() { iRow, iCol + 2, Operators.MultiplyObject(RSWIN_DESC.rst.DollarsPerBblOil(0), Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 1, 1F / RSWIN_DESC.BPD__M3D)), iDecPlaces }
						Dim array19 As Object() = array6
						Dim array20 As String() = Nothing
						Dim array21 As Type() = Nothing
						array5 = New Boolean() { True, False, False, True }
						NewLateBinding.LateCall(objExcel6, type6, text12, array19, array20, array21, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						iCol += 2
					Case 10
						Dim array As Object()
						Dim array5 As Boolean()
						Dim array6 As Object()
						Dim array26 As Single()
						Dim num4 As Integer
						If RSWIN_DESC.rst.UnknownM Then
							Dim objExcel7 As Object = RSWIN_DESC.objExcel
							Dim type7 As Type = Nothing
							Dim text13 As String = "XLWorkSheetAddString"
							array6 = New Object() { iRow, iCol, "N/A" }
							Dim array22 As Object() = array6
							Dim array23 As String() = Nothing
							Dim array24 As Type() = Nothing
							array5 = New Boolean() { True, True, False }
							NewLateBinding.LateCall(objExcel7, type7, text13, array22, array23, array24, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
						Else
							Dim objExcel8 As Object = RSWIN_DESC.objExcel
							Dim type8 As Type = Nothing
							Dim text14 As String = "XLWorkSheetAddPercent"
							array = New Object(3) {}
							array(0) = iRow
							array(1) = iCol
							Dim array25 As Object() = array
							Dim num3 As Integer = 2
							array26 = RSWIN_DESC.rst.GearboxLoading
							Dim array27 As Single() = array26
							num4 = 2
							array25(num3) = array27(num4)
							array(3) = 1
							array6 = array
							Dim array28 As Object() = array6
							Dim array29 As String() = Nothing
							Dim array30 As Type() = Nothing
							array5 = New Boolean() { True, True, True, False }
							NewLateBinding.LateCall(objExcel8, type8, text14, array28, array29, array30, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
							If array5(2) Then
								array26(num4) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single)))
							End If
						End If
						Dim objExcel9 As Object = RSWIN_DESC.objExcel
						Dim type9 As Type = Nothing
						Dim text15 As String = "XLWorkSheetAddPercent"
						array = New Object(3) {}
						array(0) = iRow
						array(1) = iCol + 1
						Dim array31 As Object() = array
						Dim num5 As Integer = 2
						array26 = RSWIN_DESC.rst.GearboxLoading
						Dim array32 As Single() = array26
						num4 = 1
						array31(num5) = array32(num4)
						array(3) = 1
						array6 = array
						Dim array33 As Object() = array6
						Dim array34 As String() = Nothing
						Dim array35 As Type() = Nothing
						array5 = New Boolean() { True, False, True, False }
						NewLateBinding.LateCall(objExcel9, type9, text15, array33, array34, array35, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(2) Then
							array26(num4) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single)))
						End If
						Dim objExcel10 As Object = RSWIN_DESC.objExcel
						Dim type10 As Type = Nothing
						Dim text16 As String = "XLWorkSheetAddPercent"
						array = New Object(3) {}
						array(0) = iRow
						array(1) = iCol + 2
						Dim array36 As Object() = array
						Dim num6 As Integer = 2
						array26 = RSWIN_DESC.rst.GearboxLoading
						Dim array37 As Single() = array26
						num4 = 0
						array36(num6) = array37(num4)
						array(3) = 1
						array6 = array
						Dim array38 As Object() = array6
						Dim array39 As String() = Nothing
						Dim array40 As Type() = Nothing
						array5 = New Boolean() { True, False, True, False }
						NewLateBinding.LateCall(objExcel10, type10, text16, array38, array39, array40, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(2) Then
							array26(num4) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single)))
						End If
						iCol += 2
					Case 29
						Dim array5 As Boolean()
						Dim array6 As Object()
						If RSWIN_DESC.rst.UnknownM Then
							Dim objExcel11 As Object = RSWIN_DESC.objExcel
							Dim type11 As Type = Nothing
							Dim text17 As String = "XLWorkSheetAddString"
							array6 = New Object() { iRow, iCol, "N/A" }
							Dim array41 As Object() = array6
							Dim array42 As String() = Nothing
							Dim array43 As Type() = Nothing
							array5 = New Boolean() { True, True, False }
							NewLateBinding.LateCall(objExcel11, type11, text17, array41, array42, array43, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
						Else
							Dim objExcel12 As Object = RSWIN_DESC.objExcel
							Dim type12 As Type = Nothing
							Dim text18 As String = "XLWorkSheetAddFloat"
							array6 = New Object() { iRow, iCol, Operators.MultiplyObject(RSWIN_DESC.rst.PeakTorque(2) / 1000F, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 3, 1, RSWIN_DESC.MINLB__NM)), iDecPlaces }
							Dim array44 As Object() = array6
							Dim array45 As String() = Nothing
							Dim array46 As Type() = Nothing
							array5 = New Boolean() { True, True, False, True }
							NewLateBinding.LateCall(objExcel12, type12, text18, array44, array45, array46, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
							If array5(3) Then
								iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
							End If
						End If
						Dim objExcel13 As Object = RSWIN_DESC.objExcel
						Dim type13 As Type = Nothing
						Dim text19 As String = "XLWorkSheetAddFloat"
						array6 = New Object() { iRow, iCol + 1, Operators.MultiplyObject(RSWIN_DESC.rst.PeakTorque(1) / 1000F, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 3, 1, RSWIN_DESC.MINLB__NM)), iDecPlaces }
						Dim array47 As Object() = array6
						Dim array48 As String() = Nothing
						Dim array49 As Type() = Nothing
						array5 = New Boolean() { True, False, False, True }
						NewLateBinding.LateCall(objExcel13, type13, text19, array47, array48, array49, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						Dim objExcel14 As Object = RSWIN_DESC.objExcel
						Dim type14 As Type = Nothing
						Dim text20 As String = "XLWorkSheetAddFloat"
						array6 = New Object() { iRow, iCol + 2, Operators.MultiplyObject(RSWIN_DESC.rst.PeakTorque(0) / 1000F, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 3, 1, RSWIN_DESC.MINLB__NM)), iDecPlaces }
						Dim array50 As Object() = array6
						Dim array51 As String() = Nothing
						Dim array52 As Type() = Nothing
						array5 = New Boolean() { True, False, False, True }
						NewLateBinding.LateCall(objExcel14, type14, text20, array50, array51, array52, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						iCol += 2
					Case 30
						Dim array As Object()
						Dim array5 As Boolean()
						Dim array6 As Object()
						Dim array26 As Single()
						Dim num4 As Integer
						If RSWIN_DESC.rst.UnknownM Then
							Dim objExcel15 As Object = RSWIN_DESC.objExcel
							Dim type15 As Type = Nothing
							Dim text21 As String = "XLWorkSheetAddString"
							array6 = New Object() { iRow, iCol, "N/A" }
							Dim array53 As Object() = array6
							Dim array54 As String() = Nothing
							Dim array55 As Type() = Nothing
							array5 = New Boolean() { True, True, False }
							NewLateBinding.LateCall(objExcel15, type15, text21, array53, array54, array55, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
						Else
							Dim objExcel16 As Object = RSWIN_DESC.objExcel
							Dim type16 As Type = Nothing
							Dim text22 As String = "XLWorkSheetAddFloat"
							array = New Object(3) {}
							array(0) = iRow
							array(1) = iCol
							Dim array56 As Object() = array
							Dim num7 As Integer = 2
							array26 = RSWIN_DESC.rst.Clf
							Dim array57 As Single() = array26
							num4 = 2
							array56(num7) = array57(num4)
							array(3) = iDecPlaces
							array6 = array
							Dim array58 As Object() = array6
							Dim array59 As String() = Nothing
							Dim array60 As Type() = Nothing
							array5 = New Boolean() { True, True, True, True }
							NewLateBinding.LateCall(objExcel16, type16, text22, array58, array59, array60, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
							If array5(2) Then
								array26(num4) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single)))
							End If
							If array5(3) Then
								iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
							End If
						End If
						Dim objExcel17 As Object = RSWIN_DESC.objExcel
						Dim type17 As Type = Nothing
						Dim text23 As String = "XLWorkSheetAddFloat"
						array = New Object(3) {}
						array(0) = iRow
						array(1) = iCol + 1
						Dim array61 As Object() = array
						Dim num8 As Integer = 2
						array26 = RSWIN_DESC.rst.Clf
						Dim array62 As Single() = array26
						num4 = 1
						array61(num8) = array62(num4)
						array(3) = iDecPlaces
						array6 = array
						Dim array63 As Object() = array6
						Dim array64 As String() = Nothing
						Dim array65 As Type() = Nothing
						array5 = New Boolean() { True, False, True, True }
						NewLateBinding.LateCall(objExcel17, type17, text23, array63, array64, array65, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(2) Then
							array26(num4) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						Dim objExcel18 As Object = RSWIN_DESC.objExcel
						Dim type18 As Type = Nothing
						Dim text24 As String = "XLWorkSheetAddFloat"
						array = New Object(3) {}
						array(0) = iRow
						array(1) = iCol + 2
						Dim array66 As Object() = array
						Dim num9 As Integer = 2
						array26 = RSWIN_DESC.rst.Clf
						Dim array67 As Single() = array26
						num4 = 0
						array66(num9) = array67(num4)
						array(3) = iDecPlaces
						array6 = array
						Dim array68 As Object() = array6
						Dim array69 As String() = Nothing
						Dim array70 As Type() = Nothing
						array5 = New Boolean() { True, False, True, True }
						NewLateBinding.LateCall(objExcel18, type18, text24, array68, array69, array70, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(2) Then
							array26(num4) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						iCol += 2
					Case 31
						Dim array5 As Boolean()
						Dim array6 As Object()
						If RSWIN_DESC.rst.UnknownM Then
							Dim objExcel19 As Object = RSWIN_DESC.objExcel
							Dim type19 As Type = Nothing
							Dim text25 As String = "XLWorkSheetAddString"
							array6 = New Object() { iRow, iCol, "N/A" }
							Dim array71 As Object() = array6
							Dim array72 As String() = Nothing
							Dim array73 As Type() = Nothing
							array5 = New Boolean() { True, True, False }
							NewLateBinding.LateCall(objExcel19, type19, text25, array71, array72, array73, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
						Else
							Dim objExcel20 As Object = RSWIN_DESC.objExcel
							Dim type20 As Type = Nothing
							Dim text26 As String = "XLWorkSheetAddFloat"
							array6 = New Object() { iRow, iCol, Operators.MultiplyObject(RSWIN_DESC.rst.get_M(2) / 1000F, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 3, 1, RSWIN_DESC.MINLB__NM)), iDecPlaces }
							Dim array74 As Object() = array6
							Dim array75 As String() = Nothing
							Dim array76 As Type() = Nothing
							array5 = New Boolean() { True, True, False, True }
							NewLateBinding.LateCall(objExcel20, type20, text26, array74, array75, array76, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
							If array5(3) Then
								iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
							End If
						End If
						Dim objExcel21 As Object = RSWIN_DESC.objExcel
						Dim type21 As Type = Nothing
						Dim text27 As String = "XLWorkSheetAddFloat"
						array6 = New Object() { iRow, iCol + 1, Operators.MultiplyObject(RSWIN_DESC.rst.get_M(1) / 1000F, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 3, 1, RSWIN_DESC.MINLB__NM)), iDecPlaces }
						Dim array77 As Object() = array6
						Dim array78 As String() = Nothing
						Dim array79 As Type() = Nothing
						array5 = New Boolean() { True, False, False, True }
						NewLateBinding.LateCall(objExcel21, type21, text27, array77, array78, array79, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						Dim objExcel22 As Object = RSWIN_DESC.objExcel
						Dim type22 As Type = Nothing
						Dim text28 As String = "XLWorkSheetAddFloat"
						array6 = New Object() { iRow, iCol + 2, Operators.MultiplyObject(RSWIN_DESC.rst.get_M(0) / 1000F, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 3, 1, RSWIN_DESC.MINLB__NM)), iDecPlaces }
						Dim array80 As Object() = array6
						Dim array81 As String() = Nothing
						Dim array82 As Type() = Nothing
						array5 = New Boolean() { True, False, False, True }
						NewLateBinding.LateCall(objExcel22, type22, text28, array80, array81, array82, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						iCol += 2
					Case 32
						Dim array5 As Boolean()
						Dim array6 As Object()
						If RSWIN_DESC.rst.UnknownM Then
							Dim objExcel23 As Object = RSWIN_DESC.objExcel
							Dim type23 As Type = Nothing
							Dim text29 As String = "XLWorkSheetAddString"
							array6 = New Object() { iRow, iCol, "N/A" }
							Dim array83 As Object() = array6
							Dim array84 As String() = Nothing
							Dim array85 As Type() = Nothing
							array5 = New Boolean() { True, True, False }
							NewLateBinding.LateCall(objExcel23, type23, text29, array83, array84, array85, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
						Else
							Dim objExcel24 As Object = RSWIN_DESC.objExcel
							Dim type24 As Type = Nothing
							Dim text30 As String = "XLWorkSheetAddFloat"
							array6 = New Object() { iRow, iCol, Operators.MultiplyObject(RSWIN_DESC.rst.CBE90(2), Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 3, 1, RSWIN_DESC.LB__N)), iDecPlaces }
							Dim array86 As Object() = array6
							Dim array87 As String() = Nothing
							Dim array88 As Type() = Nothing
							array5 = New Boolean() { True, True, False, True }
							NewLateBinding.LateCall(objExcel24, type24, text30, array86, array87, array88, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
							If array5(3) Then
								iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
							End If
						End If
						Dim objExcel25 As Object = RSWIN_DESC.objExcel
						Dim type25 As Type = Nothing
						Dim text31 As String = "XLWorkSheetAddFloat"
						array6 = New Object() { iRow, iCol + 1, Operators.MultiplyObject(RSWIN_DESC.rst.CBE90(1), Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 3, 1, RSWIN_DESC.LB__N)), iDecPlaces }
						Dim array89 As Object() = array6
						Dim array90 As String() = Nothing
						Dim array91 As Type() = Nothing
						array5 = New Boolean() { True, False, False, True }
						NewLateBinding.LateCall(objExcel25, type25, text31, array89, array90, array91, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						Dim objExcel26 As Object = RSWIN_DESC.objExcel
						Dim type26 As Type = Nothing
						Dim text32 As String = "XLWorkSheetAddFloat"
						array6 = New Object() { iRow, iCol + 2, Operators.MultiplyObject(RSWIN_DESC.rst.CBE90(0), Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 3, 1, RSWIN_DESC.LB__N)), iDecPlaces }
						Dim array92 As Object() = array6
						Dim array93 As String() = Nothing
						Dim array94 As Type() = Nothing
						array5 = New Boolean() { True, False, False, True }
						NewLateBinding.LateCall(objExcel26, type26, text32, array92, array93, array94, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						iCol += 2
					Case 33
						Dim array As Object()
						Dim array5 As Boolean()
						Dim array6 As Object()
						Dim array26 As Single()
						Dim num4 As Integer
						If RSWIN_DESC.rst.UnknownM Then
							Dim objExcel27 As Object = RSWIN_DESC.objExcel
							Dim type27 As Type = Nothing
							Dim text33 As String = "XLWorkSheetAddString"
							array6 = New Object() { iRow, iCol, "N/A" }
							Dim array95 As Object() = array6
							Dim array96 As String() = Nothing
							Dim array97 As Type() = Nothing
							array5 = New Boolean() { True, True, False }
							NewLateBinding.LateCall(objExcel27, type27, text33, array95, array96, array97, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
						Else
							Dim objExcel28 As Object = RSWIN_DESC.objExcel
							Dim type28 As Type = Nothing
							Dim text34 As String = "XLWorkSheetAddFloat"
							array = New Object(3) {}
							array(0) = iRow
							array(1) = iCol
							Dim array98 As Object() = array
							Dim num10 As Integer = 2
							array26 = RSWIN_DESC.rst.MotorKWH
							Dim array99 As Single() = array26
							num4 = 2
							array98(num10) = array99(num4)
							array(3) = iDecPlaces
							array6 = array
							Dim array100 As Object() = array6
							Dim array101 As String() = Nothing
							Dim array102 As Type() = Nothing
							array5 = New Boolean() { True, True, True, True }
							NewLateBinding.LateCall(objExcel28, type28, text34, array100, array101, array102, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
							If array5(2) Then
								array26(num4) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single)))
							End If
							If array5(3) Then
								iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
							End If
						End If
						Dim objExcel29 As Object = RSWIN_DESC.objExcel
						Dim type29 As Type = Nothing
						Dim text35 As String = "XLWorkSheetAddFloat"
						array = New Object(3) {}
						array(0) = iRow
						array(1) = iCol + 1
						Dim array103 As Object() = array
						Dim num11 As Integer = 2
						array26 = RSWIN_DESC.rst.MotorKWH
						Dim array104 As Single() = array26
						num4 = 1
						array103(num11) = array104(num4)
						array(3) = iDecPlaces
						array6 = array
						Dim array105 As Object() = array6
						Dim array106 As String() = Nothing
						Dim array107 As Type() = Nothing
						array5 = New Boolean() { True, False, True, True }
						NewLateBinding.LateCall(objExcel29, type29, text35, array105, array106, array107, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(2) Then
							array26(num4) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						Dim objExcel30 As Object = RSWIN_DESC.objExcel
						Dim type30 As Type = Nothing
						Dim text36 As String = "XLWorkSheetAddFloat"
						array = New Object(3) {}
						array(0) = iRow
						array(1) = iCol + 2
						Dim array108 As Object() = array
						Dim num12 As Integer = 2
						array26 = RSWIN_DESC.rst.MotorKWH
						Dim array109 As Single() = array26
						num4 = 0
						array108(num12) = array109(num4)
						array(3) = iDecPlaces
						array6 = array
						Dim array110 As Object() = array6
						Dim array111 As String() = Nothing
						Dim array112 As Type() = Nothing
						array5 = New Boolean() { True, False, True, True }
						NewLateBinding.LateCall(objExcel30, type30, text36, array110, array111, array112, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(2) Then
							array26(num4) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						iCol += 2
					Case 34
						Dim array As Object()
						Dim array5 As Boolean()
						Dim array6 As Object()
						Dim num4 As Integer
						Dim rst As cRODSTAR
						If RSWIN_DESC.rst.UnknownM Then
							Dim objExcel31 As Object = RSWIN_DESC.objExcel
							Dim type31 As Type = Nothing
							Dim text37 As String = "XLWorkSheetAddString"
							array6 = New Object() { iRow, iCol, "N/A" }
							Dim array113 As Object() = array6
							Dim array114 As String() = Nothing
							Dim array115 As Type() = Nothing
							array5 = New Boolean() { True, True, False }
							NewLateBinding.LateCall(objExcel31, type31, text37, array113, array114, array115, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
						Else
							Dim objExcel32 As Object = RSWIN_DESC.objExcel
							Dim type32 As Type = Nothing
							Dim text38 As String = "XLWorkSheetAddFloat"
							array = New Object(3) {}
							array(0) = iRow
							array(1) = iCol
							Dim array116 As Object() = array
							Dim num13 As Integer = 2
							rst = RSWIN_DESC.rst
							Dim cRODSTAR As cRODSTAR = rst
							num4 = 2
							array116(num13) = cRODSTAR.get_ElectricBillperMonth(num4)
							array(3) = iDecPlaces
							array6 = array
							Dim array117 As Object() = array6
							Dim array118 As String() = Nothing
							Dim array119 As Type() = Nothing
							array5 = New Boolean() { True, True, True, True }
							NewLateBinding.LateCall(objExcel32, type32, text38, array117, array118, array119, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
							If array5(2) Then
								rst.set_ElectricBillperMonth(num4, CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single))))
							End If
							If array5(3) Then
								iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
							End If
						End If
						Dim objExcel33 As Object = RSWIN_DESC.objExcel
						Dim type33 As Type = Nothing
						Dim text39 As String = "XLWorkSheetAddFloat"
						array = New Object(3) {}
						array(0) = iRow
						array(1) = iCol + 1
						Dim array120 As Object() = array
						Dim num14 As Integer = 2
						rst = RSWIN_DESC.rst
						Dim cRODSTAR2 As cRODSTAR = rst
						num4 = 1
						array120(num14) = cRODSTAR2.get_ElectricBillperMonth(num4)
						array(3) = iDecPlaces
						array6 = array
						Dim array121 As Object() = array6
						Dim array122 As String() = Nothing
						Dim array123 As Type() = Nothing
						array5 = New Boolean() { True, False, True, True }
						NewLateBinding.LateCall(objExcel33, type33, text39, array121, array122, array123, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(2) Then
							rst.set_ElectricBillperMonth(num4, CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single))))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						Dim objExcel34 As Object = RSWIN_DESC.objExcel
						Dim type34 As Type = Nothing
						Dim text40 As String = "XLWorkSheetAddFloat"
						array = New Object(3) {}
						array(0) = iRow
						array(1) = iCol + 2
						Dim array124 As Object() = array
						Dim num15 As Integer = 2
						rst = RSWIN_DESC.rst
						Dim cRODSTAR3 As cRODSTAR = rst
						num4 = 0
						array124(num15) = cRODSTAR3.get_ElectricBillperMonth(num4)
						array(3) = iDecPlaces
						array6 = array
						Dim array125 As Object() = array6
						Dim array126 As String() = Nothing
						Dim array127 As Type() = Nothing
						array5 = New Boolean() { True, False, True, True }
						NewLateBinding.LateCall(objExcel34, type34, text40, array125, array126, array127, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(2) Then
							rst.set_ElectricBillperMonth(num4, CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single))))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						iCol += 2
					Case 35
						Dim array5 As Boolean()
						Dim array6 As Object()
						If RSWIN_DESC.rst.UnknownM Then
							Dim objExcel35 As Object = RSWIN_DESC.objExcel
							Dim type35 As Type = Nothing
							Dim text41 As String = "XLWorkSheetAddString"
							array6 = New Object() { iRow, iCol, "N/A" }
							Dim array128 As Object() = array6
							Dim array129 As String() = Nothing
							Dim array130 As Type() = Nothing
							array5 = New Boolean() { True, True, False }
							NewLateBinding.LateCall(objExcel35, type35, text41, array128, array129, array130, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
						Else
							Dim objExcel36 As Object = RSWIN_DESC.objExcel
							Dim type36 As Type = Nothing
							Dim text42 As String = "XLWorkSheetAddFloat"
							array6 = New Object() { iRow, iCol, Operators.MultiplyObject(RSWIN_DESC.rst.DollarsPerBblFluid(2), Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 1, 1F / RSWIN_DESC.BPD__M3D)), iDecPlaces }
							Dim array131 As Object() = array6
							Dim array132 As String() = Nothing
							Dim array133 As Type() = Nothing
							array5 = New Boolean() { True, True, False, True }
							NewLateBinding.LateCall(objExcel36, type36, text42, array131, array132, array133, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
							If array5(3) Then
								iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
							End If
						End If
						Dim objExcel37 As Object = RSWIN_DESC.objExcel
						Dim type37 As Type = Nothing
						Dim text43 As String = "XLWorkSheetAddFloat"
						array6 = New Object() { iRow, iCol + 1, Operators.MultiplyObject(RSWIN_DESC.rst.DollarsPerBblFluid(1), Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 1, 1F / RSWIN_DESC.BPD__M3D)), iDecPlaces }
						Dim array134 As Object() = array6
						Dim array135 As String() = Nothing
						Dim array136 As Type() = Nothing
						array5 = New Boolean() { True, False, False, True }
						NewLateBinding.LateCall(objExcel37, type37, text43, array134, array135, array136, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						Dim objExcel38 As Object = RSWIN_DESC.objExcel
						Dim type38 As Type = Nothing
						Dim text44 As String = "XLWorkSheetAddFloat"
						array6 = New Object() { iRow, iCol + 2, Operators.MultiplyObject(RSWIN_DESC.rst.DollarsPerBblFluid(0), Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 1, 1F / RSWIN_DESC.BPD__M3D)), iDecPlaces }
						Dim array137 As Object() = array6
						Dim array138 As String() = Nothing
						Dim array139 As Type() = Nothing
						array5 = New Boolean() { True, False, False, True }
						NewLateBinding.LateCall(objExcel38, type38, text44, array137, array138, array139, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(3) Then
							iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
						End If
						iCol += 2
					Case 43
						Dim text As String
						Dim text2 As String
						Dim array5 As Boolean()
						Dim array6 As Object()

							If(If((-If((Not RSWIN_DESC.rst.gbUseIPR > False), 1S, 0S)), 1S, 0S) Or (RSWIN_DESC.rst.ULineSettingsChanged And RSWIN_DESC.rst.ULinesSetH And If((-If((RSWIN_DESC.rst.UFluidLoad < 0F > False), 1S, 0S)), 1S, 0S)) Or (RSWIN_DESC.rst.XDLinesSetH And If((-If((RSWIN_DESC.rst.XDFluidLoad < 0F > False), 1S, 0S)), 1S, 0S))) <> 0S Then
								Dim objExcel39 As Object = RSWIN_DESC.objExcel
								Dim type39 As Type = Nothing
								Dim text45 As String = "XLWorkSheetAddString"
								array6 = New Object() { iRow, iCol, "N/A" }
								Dim array140 As Object() = array6
								Dim array141 As String() = Nothing
								Dim array142 As Type() = Nothing
								array5 = New Boolean() { True, True, False }
								NewLateBinding.LateCall(objExcel39, type39, text45, array140, array141, array142, array5, True)
								If array5(0) Then
									iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
								End If
								If array5(1) Then
									iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
								End If
							ElseIf CDbl(RSWIN_DESC.gSysDiag.PumpIntakePressure) - 14.7 <= CDbl(RSWIN_DESC.rst.CasingPressure) Then
								Dim objExcel40 As Object = RSWIN_DESC.objExcel
								Dim type40 As Type = Nothing
								Dim text46 As String = "XLWorkSheetAddFloat"
								array6 = New Object() { iRow, iCol, 0, iDecPlaces }
								Dim array143 As Object() = array6
								Dim array144 As String() = Nothing
								Dim array145 As Type() = Nothing
								array5 = New Boolean() { True, True, False, True }
								NewLateBinding.LateCall(objExcel40, type40, text46, array143, array144, array145, array5, True)
								If array5(0) Then
									iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
								End If
								If array5(1) Then
									iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
								End If
								If array5(3) Then
									iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
								End If
							Else
								IPR.iprSetup()
								Dim num16 As Single = IPR.iprPwfFromPip(CSng((CDbl(RSWIN_DESC.rst.CasingPressure) + 14.7)))
								Dim num17 As Single = IPR.iprProductionFromPwf(num16)
								Dim num18 As Single = IPR.iprPwfFromPip(RSWIN_DESC.gSysDiag.PumpIntakePressure)
								Dim num19 As Single = IPR.iprProductionFromPwf(num18)
								If CDbl((num17 - num19)) < 0.5 Then
									Dim objExcel41 As Object = RSWIN_DESC.objExcel
									Dim type41 As Type = Nothing
									Dim text47 As String = "XLWorkSheetAddFloat"
									array6 = New Object() { iRow, iCol, 0, iDecPlaces }
									Dim array146 As Object() = array6
									Dim array147 As String() = Nothing
									Dim array148 As Type() = Nothing
									array5 = New Boolean() { True, True, False, True }
									NewLateBinding.LateCall(objExcel41, type41, text47, array146, array147, array148, array5, True)
									If array5(0) Then
										iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
									End If
									If array5(1) Then
										iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
									End If
									If array5(3) Then
										iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
									End If
								Else
									Dim objExcel42 As Object = RSWIN_DESC.objExcel
									Dim type42 As Type = Nothing
									Dim text48 As String = "XLWorkSheetAddFloat"
									array6 = New Object() { iRow, iCol, Operators.MultiplyObject(num17 - num19, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 1, RSWIN_DESC.BPD__M3D)), iDecPlaces }
									Dim array149 As Object() = array6
									Dim array150 As String() = Nothing
									Dim array151 As Type() = Nothing
									array5 = New Boolean() { True, True, False, True }
									NewLateBinding.LateCall(objExcel42, type42, text48, array149, array150, array151, array5, True)
									If array5(0) Then
										iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
									End If
									If array5(1) Then
										iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
									End If
									If array5(3) Then
										iDecPlaces = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
									End If
								End If
							End If
							text2 = Strings.Left(text, 240)
							text = Strings.Mid(text, 241)
							Dim objExcel43 As Object = RSWIN_DESC.objExcel
							Dim type43 As Type = Nothing
							Dim text49 As String = "XLWorkSheetAddString"
							array6 = New Object() { iRow, iCol, text2 }
							Dim array152 As Object() = array6
							Dim array153 As String() = Nothing
							Dim array154 As Type() = Nothing
							array5 = New Boolean() { True, True, True }
							NewLateBinding.LateCall(objExcel43, type43, text49, array152, array153, array154, array5, True)
							If array5(0) Then
								iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							If array5(1) Then
								iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
							End If
							If array5(2) Then
								text2 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(String)))
							End If

						iCol += 1
						text2 = Strings.Left(text, 240)
						text = Strings.Mid(text, 241)
						Dim objExcel44 As Object = RSWIN_DESC.objExcel
						Dim type44 As Type = Nothing
						Dim text50 As String = "XLWorkSheetAddString"
						array6 = New Object() { iRow, iCol, text2 }
						Dim array155 As Object() = array6
						Dim array156 As String() = Nothing
						Dim array157 As Type() = Nothing
						array5 = New Boolean() { True, True, True }
						NewLateBinding.LateCall(objExcel44, type44, text50, array155, array156, array157, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
						End If
						If array5(2) Then
							text2 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(String)))
						End If
						iCol += 1
						text2 = Strings.Left(text, 240)
						text = Strings.Mid(text, 241)
						Dim objExcel45 As Object = RSWIN_DESC.objExcel
						Dim type45 As Type = Nothing
						Dim text51 As String = "XLWorkSheetAddString"
						array6 = New Object() { iRow, iCol, text2 }
						Dim array158 As Object() = array6
						Dim array159 As String() = Nothing
						Dim array160 As Type() = Nothing
						array5 = New Boolean() { True, True, True }
						NewLateBinding.LateCall(objExcel45, type45, text51, array158, array159, array160, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
						End If
						If array5(2) Then
							text2 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(String)))
						End If
						iCol += 1
						If Strings.Len(text) <= 240 Then
							text2 = text
						Else
							text2 = Strings.Left(text, 240) + "\"
						End If
						Dim objExcel46 As Object = RSWIN_DESC.objExcel
						Dim type46 As Type = Nothing
						Dim text52 As String = "XLWorkSheetAddString"
						array6 = New Object() { iRow, iCol, text2 }
						Dim array161 As Object() = array6
						Dim array162 As String() = Nothing
						Dim array163 As Type() = Nothing
						array5 = New Boolean() { True, True, True }
						NewLateBinding.LateCall(objExcel46, type46, text52, array161, array162, array163, array5, True)
						If array5(0) Then
							iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(1) Then
							iCol = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
						End If
						If array5(2) Then
							text2 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(String)))
						End If
				End Select
			Catch ex As Exception
				Dim sMsg As String = "Error in GetSpreadsheetValueSpecial: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub InitRODSTAR(ByRef sn As Integer, bUseLM32 As Boolean)
			Try
				If(Not RSWIN_DESC.gbDemoMode And RSWIN_DESC.bCheck4Sentinel) AndAlso Not bUseLM32 Then
					Dim flag As Boolean = RSWIN.RDInitSentinel()
					If Not flag Then
						Return
					End If
					sn = SUPERPRO.SentinelSerialNumber()
					If sn = 0 Then
						Return
					End If
					CHECKSN.CheckSN(sn)
				End If
				RSWIN_DESC.LF = vbLf
				RSWIN_DESC.RSMagic = "RODSTAR" & vbCrLf & ChrW(26)
				RSWIN_DESC.RDMagic = "RODDIAG" & vbCrLf & ChrW(26)
				RSWIN_DESC.CBMagic = "CBALANCE" & vbCrLf & ChrW(26)
				RSWIN_DESC.XDMagic = "XDIAG" & vbCrLf & ChrW(26)
				FILEUTIL.LocateFile("THETA32.INI", RSWIN_DESC.THETA_INI, 17S, False, False, False, False)
				If Strings.Len(RSWIN_DESC.THETA_INI) = 0 Then
					RSWIN_DESC.THETA_INI = "THETA32.INI"
				End If
				Dim sect_PROGWIN As String = RSWIN_DESC.SECT_PROGWIN32
				ini.CheckForSection(sect_PROGWIN)
				RSWIN_DESC.SECT_PROGWIN32 = sect_PROGWIN
				sect_PROGWIN = "Paths"
				Dim sect_PROGWIN2 As String = Application.StartupPath
				Dim num As Long = CLng(RSWIN.WriteRegProfileString(sect_PROGWIN, RSWIN_DESC.SECT_RSWIN, sect_PROGWIN2, RSWIN_DESC.sINIFile))
				RSWIN.LoadDefaults()
				Dim libWrap As LibWrap = New LibWrap()
				sect_PROGWIN2 = RSWIN_DESC.SECT_PROGWIN32
				ini.CheckForSection(sect_PROGWIN2)
				RSWIN_DESC.SECT_PROGWIN32 = sect_PROGWIN2
				sect_PROGWIN2 = "Paths"
				sect_PROGWIN = Application.StartupPath
				num = CLng(RSWIN.WriteRegProfileString(sect_PROGWIN2, RSWIN_DESC.SECT_RSWIN, sect_PROGWIN, RSWIN_DESC.sINIFile))
				Dim sDefaultName As String = "SteelSuckerRodLength"
				Dim vNotPresentDefault As Object = 25
				Dim flag2 As Boolean = False
				RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(ini.GetDefault(sDefaultName, vNotPresentDefault, flag2))
				RSWIN.InitDefaultArray()
				Dim text As String
				FILEUTIL.LocateFile(RSWIN_DESC.sHelpFile, text, 0S, False, False, False, False)
				If Strings.Len(text) > 0 Then
					RSWIN.App.HelpFile = text
					RSWIN_DESC.HelpNameSpace = text
				End If
				RSWIN_DESC.rst.Inputfile = ""
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.SetClassDefaults(False)
				Try
					rst.CBLDir = Conversions.ToString(RSWIN.GetInitialDir(".CBL", ""))
					rst.DYNDir = Conversions.ToString(RSWIN.GetInitialDir(".DYN", ""))
					rst.XDGDir = Conversions.ToString(RSWIN.GetInitialDir(".XDG", ""))
					If RSWIN_DESC.bExpert Then
						If RSWIN_DESC.SETUP_bGuru Then
							rst.RSTDir = Conversions.ToString(RSWIN.GetInitialDir(".XRVX", ""))
						Else
							rst.RSTDir = Conversions.ToString(RSWIN.GetInitialDir(".RSVX", ""))
						End If
					Else
						rst.RSTDir = Conversions.ToString(RSWIN.GetInitialDir(".RST", ""))
					End If
				Catch ex As Exception
					Dim sMsg As String = "Error while setting directories: " + ex.Message
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				End Try
				FileSystem.ChDrive(RSWIN.App.Path)
				FileSystem.ChDir(RSWIN.App.Path)
				Try
					RSWIN.LoadDefaults()
				Catch ex2 As Exception
				End Try
				RSWIN_DESC.FldNum = 0
				Dim num2 As Integer = 1
				Do
					RSWIN_DESC.NewData(num2) = -1S
					num2 += 1
				Loop While num2 <= 7
				RSWIN_DESC.nCmdShow = 0S
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub InitDefaultArray()
			Try
				Dim sDefaultListNames As String()
				Dim array As String()
				ini.GetPrivateProfileKeyList("Defaults", sDefaultListNames, array, RSWIN_DESC.nDefaultListSize, False)
				Dim array2 As String()
				Util.LoadMenu("SETUP-DEFAULTLIST", RSWIN_DESC.nItems, array2)
				Dim num As Short
				Dim nItems As Short
				RSWIN_DESC.adiDefaults = New RSWIN_DESC.DEFAULTITEM(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}
				RSWIN_DESC.sDefaultListNames = New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}
				RSWIN_DESC.sDefaultListValues = New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}
				RSWIN.CheckForRegDefaultCorruption()
				num = 0S
				nItems = RSWIN_DESC.nItems
				For num2 As Short = num To nItems
					' The following expression was wrapped in a checked-statement
					Dim num3 As Short = CShort(Strings.InStr(array2(CInt(num2)), "|", CompareMethod.Binary))
					RSWIN_DESC.adiDefaults(CInt(num2)).Title = array2(CInt(num2)).Substring(0, CInt((num3 - 1S)))
					array2(CInt(num2)) = Strings.Mid(array2(CInt(num2)), CInt((num3 + 1S)))
					num3 = CShort(Strings.InStr(array2(CInt(num2)), "|", CompareMethod.Binary))
					RSWIN_DESC.adiDefaults(CInt(num2)).Name = array2(CInt(num2)).Substring(0, CInt((num3 - 1S)))
					array2(CInt(num2)) = Strings.Mid(array2(CInt(num2)), CInt((num3 + 1S)))
					num3 = CShort(Strings.InStr(array2(CInt(num2)), "|", CompareMethod.Binary))
					RSWIN_DESC.adiDefaults(CInt(num2)).HelpContextID = Conversions.ToShort(array2(CInt(num2)).Substring(0, CInt((num3 - 1S))))
					RSWIN_DESC.adiDefaults(CInt(num2)).Type = Conversions.ToChar(Strings.Mid(array2(CInt(num2)), CInt((num3 + 1S)), 1))
					array2(CInt(num2)) = Strings.Mid(array2(CInt(num2)), CInt((num3 + 3S)))
					Dim type As Char = RSWIN_DESC.adiDefaults(CInt(num2)).Type
					If type = "f"c Then
						num3 = CShort(Strings.InStr(array2(CInt(num2)), "|", CompareMethod.Binary))
						Dim text As String = array2(CInt(num2)).Substring(0, CInt((num3 - 1S)))
						array2(CInt(num2)) = Strings.Mid(array2(CInt(num2)), CInt((num3 + 1S)))
						If Versioned.IsNumeric(text) Then
							RSWIN_DESC.adiDefaults(CInt(num2)).DefaultValue = Conversion.Val(text)
						Else
							RSWIN_DESC.adiDefaults(CInt(num2)).DefaultValue = 0
						End If
						num3 = CShort(Strings.InStr(array2(CInt(num2)), "|", CompareMethod.Binary))
						RSWIN_DESC.adiDefaults(CInt(num2)).Units = array2(CInt(num2)).Substring(0, CInt((num3 - 1S)))
						array2(CInt(num2)) = Strings.Mid(array2(CInt(num2)), CInt((num3 + 1S)))
					ElseIf type = "l"c OrElse type = "L"c Then
						num3 = CShort(Strings.InStr(array2(CInt(num2)), "|", CompareMethod.Binary))
						RSWIN_DESC.adiDefaults(CInt(num2)).DefaultValue = Conversion.Val(array2(CInt(num2)).Substring(0, CInt((num3 - 1S))))
						array2(CInt(num2)) = Strings.Mid(array2(CInt(num2)), CInt((num3 + 1S)))
						num3 = CShort(Strings.InStr(array2(CInt(num2)), "|", CompareMethod.Binary))
						RSWIN_DESC.adiDefaults(CInt(num2)).items = array2(CInt(num2)).Substring(0, CInt((num3 - 1S)))
						array2(CInt(num2)) = Strings.Mid(array2(CInt(num2)), CInt((num3 + 1S)))
					End If
					Dim num4 As Integer
					Dim text2 As String
					If RSWIN.InDefaultList(RSWIN_DESC.adiDefaults(CInt(num2)).Name, sDefaultListNames, num4) Then
						text2 = Convert.ToString(array(num4))
					Else
						text2 = Convert.ToString(RuntimeHelpers.GetObjectValue(RSWIN_DESC.adiDefaults(CInt(num2)).DefaultValue))
					End If
					Dim text3 As String = "Defaults"
					Dim adiDefaults As RSWIN_DESC.DEFAULTITEM() = RSWIN_DESC.adiDefaults
					Dim num5 As Integer = CInt(num2)
					Dim text4 As String = text2.ToString()
					Dim flag As Boolean = ini.CheckForSectionKey(text3, adiDefaults(num5).Name, text4)
					If flag Then
						RSWIN_DESC.sDefaultListValues(CInt(num2)) = text2
					Else
						RSWIN_DESC.sDefaultListNames(CInt(num2)) = RSWIN_DESC.adiDefaults(CInt(num2)).Name
						RSWIN_DESC.sDefaultListValues(CInt(num2)) = Convert.ToString(RuntimeHelpers.GetObjectValue(RSWIN_DESC.adiDefaults(CInt(num2)).DefaultValue))
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Function InDefaultList(sDefaultName As String, sDefaultListNames As String(), ByRef Indx As Integer) As Boolean
			Dim result As Boolean = False
			Dim num As Integer = 0
			Dim num2 As Integer = Information.UBound(sDefaultListNames, 1)
			Indx = num
			While Indx <= num2
				Try
					If Operators.CompareString(sDefaultName.Trim(), sDefaultListNames(Indx).Trim(), False) = 0 Then
						result = True
						Exit Try
					End If
				Catch ex As Exception
				End Try
				Indx += 1
			End While
			Return result
		End Function

		Public Function CheckRegKeys() As Boolean
			Dim result As Boolean
			Try
				If RSWIN_DESC.bUseCurrentUser Then
					If Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32))) Is Nothing Then
						Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32)))
						result = False
					Else
						result = True
					End If
				ElseIf Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32))) Is Nothing Then
					Registry.LocalMachine.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32)))
					result = False
				Else
					result = True
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Friend Function CheckForKey(ByRef sSection As String) As Boolean
			Dim result As Boolean
			Try
				If RSWIN_DESC.bUseCurrentUser Then
					If Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection))) Is Nothing Then
						Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection)))
						result = False
					Else
						result = True
					End If
				ElseIf Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection))) Is Nothing Then
					Registry.LocalMachine.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection)))
					result = False
				Else
					result = True
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetRegProfileString(ByRef lpKeyName As String, ByRef lpValueName As String, ByRef lpDefault As String, ByRef lpReturnedString As String, Optional bCheckFound As Boolean = False) As Integer
			Dim text As String = ""
			Dim result As Integer
			Try
				Dim num As Integer
				If RSWIN_DESC.bRunningChineseVersion And Operators.CompareString(lpKeyName, "General", False) = 0 And Operators.CompareString(lpValueName, "Language", False) = 0 Then
					lpReturnedString = RSWIN_DESC.sChinese
					num = lpReturnedString.Length
				Else
					text = Strings.Space(16384)
					Dim flag As Boolean = RSWIN.CheckForKey(lpKeyName)
					Dim registryKey As RegistryKey
					If RSWIN_DESC.bUseCurrentUser Then
						registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)))
					Else
						registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)))
					End If
					lpReturnedString = Conversions.ToString(registryKey.GetValue(lpValueName))
					If Not bCheckFound Then
						If Information.IsDBNull(lpReturnedString) Or lpReturnedString = Nothing Or Strings.Len(lpReturnedString) = 0 Then
							Dim privateProfileString As Integer = LibWrap.GetPrivateProfileString(lpKeyName, lpValueName, lpDefault, text, Strings.Len(text), RSWIN_DESC.sINIFile)
							If privateProfileString > 0 Then
								Dim text2 As String = text.Substring(0, privateProfileString)
								RSWIN.WriteRegProfileString(lpKeyName, lpValueName, text2, "")
								lpReturnedString = text.Substring(0, privateProfileString)
								num = privateProfileString
							Else
								lpReturnedString = lpDefault
								num = lpDefault.Length
							End If
							Return num
						End If
						num = lpReturnedString.Length
					ElseIf bCheckFound Then
						If Information.IsDBNull(lpReturnedString) Or lpReturnedString = Nothing Or (Strings.Len(lpReturnedString) = 0 And Not flag) Then
							Dim privateProfileString As Integer = LibWrap.GetPrivateProfileString(lpKeyName, lpValueName, lpDefault, text, Strings.Len(text), RSWIN_DESC.sINIFile)
							If privateProfileString > 0 Then
								Dim text2 As String = text.Substring(0, privateProfileString)
								RSWIN.WriteRegProfileString(lpKeyName, lpValueName, text2, "")
								lpReturnedString = text.Substring(0, privateProfileString)
								num = privateProfileString
							Else
								lpReturnedString = lpDefault
								num = lpDefault.Length
							End If
							Return num
						End If
						num = lpReturnedString.Length
					End If
				End If
				result = num
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function DeleteRegProfileStringFromKeyList(ByRef lpKeyName As String, ByRef lpValueName As String, ByRef lpValue As String, Optional IniFile As String = "") As Integer
			Dim result As Integer
			Try
				Dim flag As Boolean = RSWIN.CheckForKey(lpKeyName)
				Dim registryKey As RegistryKey
				If RSWIN_DESC.bUseCurrentUser Then
					registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)), True)
				Else
					registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)), True)
				End If
				Try
					registryKey.DeleteValue(lpValueName)
					result = 1
				Catch ex As Exception
					result = -1
				End Try
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Public Function WriteRegProfileString(ByRef lpKeyName As String, ByRef lpValueName As String, ByRef lpValue As String, Optional IniFile As String = "") As Integer
			Dim result As Integer
			Try
				Dim flag As Boolean = RSWIN.CheckForKey(lpKeyName)
				Dim registryKey As RegistryKey
				If RSWIN_DESC.bUseCurrentUser Then
					registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)), True)
				Else
					registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)), True)
				End If
				Try
					registryKey.SetValue(lpValueName, lpValue)
					result = 1
				Catch ex As Exception
					result = -1
				End Try
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Public Function ReCreateRegKey(ByRef lpKeyName As String) As Integer
			Dim result As Integer
			Try
				Dim flag As Boolean = RSWIN.CheckForKey(lpKeyName)
				Try
					If RSWIN_DESC.bUseCurrentUser Then
						Registry.CurrentUser.DeleteSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)), False)
						Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)))
					Else
						Registry.LocalMachine.DeleteSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)), False)
						Registry.LocalMachine.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)))
					End If
					result = 1
				Catch ex As Exception
					result = -1
				End Try
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Public Function GetRegProfileStringByNum(ByRef lpKeyName As String, ByRef lpValueName As String, ByRef lpDefault As Integer, ByRef lpReturnedString As String) As Integer
			Dim result As Integer
			Try
				result = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(lpKeyName, lpValueName, lpDefault))
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub WriteRegProfileStringByBoolean(ByRef lpKeyName As String, ByRef lpValueName As String, ByRef lpValue As Boolean)
			Try
				Dim flag As Boolean = RSWIN.CheckForKey(lpKeyName)
				Dim registryKey As RegistryKey
				If RSWIN_DESC.bUseCurrentUser Then
					registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)), True)
				Else
					registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)), True)
				End If
				registryKey.SetValue(lpValueName, lpValue)
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetRegProfileStringByBoolean(ByRef lpKeyName As String, ByRef lpValueName As String, ByRef bDefault As Boolean) As Boolean
			Dim result As Boolean
			Try
				Dim text As String = bDefault.ToString()
				Dim text2 As String
				RSWIN.GetRegProfileString(lpKeyName, lpValueName, text, text2, False)
				Try
					Dim flag As Boolean
					If text2 = Nothing Or Information.IsDBNull(text2) Or Operators.CompareString(text2, "", False) = 0 Then
						flag = bDefault
					Else
						flag = (Operators.CompareString(text2.Trim(), "-1", False) = 0 Or Operators.CompareString(text2.Trim(), "True", False) = 0)
					End If
					result = flag
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Public Sub WriteRegProfileStringByInt(ByRef lpKeyName As String, ByRef lpValueName As String, ByRef lpValue As Integer)
			Try
				Dim flag As Boolean = RSWIN.CheckForKey(lpKeyName)
				Dim registryKey As RegistryKey
				If RSWIN_DESC.bUseCurrentUser Then
					registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)), True)
				Else
					registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)), True)
				End If
				registryKey.SetValue(lpValueName, lpValue)
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetRegProfileStringByInt(ByRef lpKeyName As String, ByRef lpValueName As String, ByRef lpDefault As Integer) As String
			Dim result As String
			Try
				Dim text As String = lpDefault.ToString()
				Dim value As String
				RSWIN.GetRegProfileString(lpKeyName, lpValueName, text, value, False)
				result = Conversions.ToString(Convert.ToInt32(value))
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetRegProfileStringBySingle(ByRef lpKeyName As String, ByRef lpValueName As String, ByRef lpDefault As Single) As String
			Dim text As String = lpDefault.ToString()
			Dim value As String
			RSWIN.GetRegProfileString(lpKeyName, lpValueName, text, value, False)
			Return Conversions.ToString(Convert.ToSingle(value))
		End Function

		Public Sub LoadDefaults()
			Dim num4 As Integer
			Dim num6 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim text As String = "General"
				Dim text2 As String = "MeasurementSystem"
				Dim num2 As Integer = 1
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(text, text2, num2))
				IL_29:
				num = 2
				Select Case RSWIN_DESC.SETUP_MeasurementSystem
					Case 1, 2, 3
						IL_46:
					Case Else
						IL_48:
						num = 8
						RSWIN_DESC.SETUP_MeasurementSystem = 1
				End Select
				IL_51:
				num = 10
				text2 = "General"
				text = "Language"
				Dim text3 As String
				Dim obj As Object = RSWIN.GetRegProfileString(text2, text, RSWIN_DESC.sEnglish, text3, False)
				IL_7A:
				num = 11
				RSWIN_DESC.SETUP_Language = text3.Substring(0, Conversions.ToInteger(obj))
				IL_90:
				num = 12
				If RSWIN_DESC.bIntVersion Then
					GoTo IL_A9
				End If
				IL_9B:
				num = 13
				RSWIN_DESC.SETUP_Language = RSWIN_DESC.sEnglish
				IL_A9:
				num = 15
				text2 = "General"
				text = "ShowVisualInput"
				Dim flag As Boolean = True
				RSWIN_DESC.SETUP_ShowVisualInput = If((-If((RSWIN.GetRegProfileStringByBoolean(text2, text, flag) > False), 1S, 0S)), 1S, 0S)
				IL_D3:
				num = 16
				text2 = "General"
				text = "ExitIfIdle"
				flag = False
				RSWIN_DESC.SETUP_ExitIfIdle = If((-If((RSWIN.GetRegProfileStringByBoolean(text2, text, flag) > False), 1S, 0S)), 1S, 0S)
				IL_FD:
				num = 17
				text2 = "General"
				text = "SaveOpenFileOnExit"
				flag = False
				RSWIN_DESC.SETUP_SaveOpenFileOnExit = If((-If((RSWIN.GetRegProfileStringByBoolean(text2, text, flag) > False), 1S, 0S)), 1S, 0S)
				IL_127:
				num = 18
				text2 = "General"
				text = "TabletPort"
				num2 = 0
				RSWIN_DESC.SETUP_TabletPort = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(text2, text, num2))
				IL_151:
				num = 19
				If Not(RSWIN_DESC.bRodStarD And RSWIN_DESC.bAllowRodLimitEntry) Then
					GoTo IL_1C0
				End If
				IL_162:
				num = 20
				text2 = "General"
				text = "UseDefaultRodElementLimit"
				flag = True
				RSWIN_DESC.SETUP_UseDefaultRodElementLimit = RSWIN.GetRegProfileStringByBoolean(text2, text, flag)
				IL_187:
				num = 21
				If RSWIN_DESC.SETUP_UseDefaultRodElementLimit Then
					GoTo IL_1C0
				End If
				IL_192:
				num = 22
				text2 = "General"
				text = "RodElementLimit"
				num2 = 200
				RSWIN_DESC.SETUP_RodElementLimit = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(text2, text, num2))
				IL_1C0:
				num = 25
				text2 = "General"
				text = "UseDefaultDBLocation"
				flag = True
				RSWIN_DESC.SETUP_UseDefaultDBLocation = RSWIN.GetRegProfileStringByBoolean(text2, text, flag)
				IL_1E5:
				num = 26
				text2 = "General"
				text = "UseServerDBLocation"
				flag = False
				RSWIN_DESC.SETUP_UseServerDBLocation = RSWIN.GetRegProfileStringByBoolean(text2, text, flag)
				IL_20A:
				num = 27
				text2 = "General"
				text = "ServerDBLocation"
				Dim text4 As String = ""
				obj = RSWIN.GetRegProfileString(text2, text, text4, text3, False)
				IL_237:
				num = 28
				RSWIN_DESC.SETUP_ServerDBLocation = text3.Substring(0, Conversions.ToInteger(obj))
				IL_24D:
				num = 29
				If Operators.CompareString(RSWIN_DESC.SETUP_ServerDBLocation.Trim(), "", False) <> 0 Then
					GoTo IL_27D
				End If
				IL_269:
				num = 30
				RSWIN_DESC.SETUP_UseDefaultDBLocation = True
				IL_273:
				num = 31
				RSWIN_DESC.SETUP_UseServerDBLocation = False
				IL_27D:
				num = 33
				text4 = "General"
				text2 = "SaveXDIAGMeasuredCard"
				flag = True
				RSWIN_DESC.SETUP_SaveXDIAGMeasuredCard = If((-If((RSWIN.GetRegProfileStringByBoolean(text4, text2, flag) > False), 1S, 0S)), 1S, 0S)
				IL_2A7:
				num = 34
				If RSWIN_DESC.SETUP_MeasurementSystem <> 2 Then
					GoTo IL_2DD
				End If
				IL_2B3:
				num = 35
				text4 = "General"
				text2 = "DisplaySBinFeet"
				flag = True
				RSWIN_DESC.SETUP_DisplaySBinFeet = If((-If((RSWIN.GetRegProfileStringByBoolean(text4, text2, flag) > False), 1S, 0S)), 1S, 0S)
				IL_2DD:
				num = 37
				If RSWIN_DESC.SETUP_TabletPort <= 4 Then
					GoTo IL_2F3
				End If
				IL_2E9:
				num = 38
				RSWIN_DESC.SETUP_TabletPort = 4
				IL_2F3:
				num = 40
				text4 = "BatchPrintouts"
				flag = False
				RSWIN_DESC.SETUP_BatchPrintouts = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1, 0)), 1, 0)
				IL_318:
				num = 41
				text4 = "BatchSaveWorksheet"
				flag = True
				RSWIN_DESC.SETUP_BatchSaveWorksheet = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1, 0)), 1, 0)
				IL_33D:
				num = 42
				text4 = "BatchViewWorksheet"
				flag = True
				RSWIN_DESC.SETUP_BatchViewWorksheet = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1, 0)), 1, 0)
				IL_362:
				num = 43
				text4 = "BatchSkipProcessedFiles"
				flag = True
				RSWIN_DESC.SETUP_BatchSkipProcessedFiles = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1, 0)), 1, 0)
				IL_387:
				num = 44
				text4 = "BatchUpdateCustomRodGrades"
				flag = False
				RSWIN_DESC.SETUP_BatchUpdateCustomRodGrades = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1, 0)), 1, 0)
				IL_3AC:
				num = 45
				text4 = "Batch_CreatePDFs"
				flag = False
				RSWIN_DESC.SETUP_CreatePDFs = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1, 0)), 1, 0)
				IL_3D1:
				num = 46
				text4 = "ExcelInstalled"
				flag = True
				RSWIN_DESC.SETUP_ExcelInstalled = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag)
				IL_3F2:
				num = 47
				text4 = "UseImpred"
				flag = False
				RSWIN_DESC.SETUP_UseImpred = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_418:
				num = 48
				text4 = "UseAllDiameters"
				flag = False
				RSWIN_DESC.SETUP_UseAllDiameters = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag)
				IL_439:
				num = 49
				RSWIN_DESC.SETUP_UseBucklingTendencyStresses = True
				IL_443:
				num = 50
				RSWIN_DESC.SETUP_UseJeffsFix = True
				IL_44D:
				num = 51
				RSWIN_DESC.SETUP_UseJohnsFix = True
				IL_457:
				num = 52
				If Not RSWIN_DESC.bRodStarD Then
					GoTo IL_4BC
				End If
				IL_462:
				num = 53
				RSWIN_DESC.SETUP_UseImpred = -1S
				IL_46C:
				num = 54
				text4 = "AlterSBPumpDepth"
				flag = True
				RSWIN_DESC.Setup_bAlterSBPumpDepth = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_492:
				num = 55
				text4 = "InclinationLimit"
				Dim num3 As Single = 4F
				RSWIN_DESC.Setup_fInclinationLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text4, num3))
				IL_4BC:
				num = 57
				text4 = "GuideToUse"
				num2 = CInt(RSWIN_DESC.MOLDED)
				Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text4, num2)
				RSWIN_DESC.MOLDED = CShort(num2)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
				IL_4EE:
				num = 58
				If RSWIN_DESC.SETUP_GuideToUse <> 0 Then
					GoTo IL_53F
				End If
				IL_4FA:
				num = 59
				RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.MOLDED)
				IL_508:
				num = 60
				text4 = "GuideToUse"
				text2 = Conversions.ToString(CInt(RSWIN_DESC.MOLDED))
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.MOLDED = Conversions.ToShort(text2)
				IL_53F:
				num = 62
				text4 = "DisplayAZDIRToolbar"
				flag = False
				RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_565:
				num = 63
				text4 = "OptimizeSurvey"
				flag = False
				RSWIN_DESC.SETUP_OPTIMIZESURVEY = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_58B:
				num = 64
				RSWIN_DESC.SETUP_OPTIMIZESURVEY = 0S
				IL_595:
				num = 65
				text4 = "MDInt"
				num2 = 25
				RSWIN_DESC.SETUP_MDInt = Conversions.ToSingle(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text4, num2))
				IL_5BC:
				num = 66
				text4 = "DoglegLimit"
				num2 = 5
				RSWIN_DESC.SETUP_DoglegLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text4, num2))
				IL_5E2:
				num = 67
				text4 = "AllowSlideFric"
				flag = True
				RSWIN_DESC.SETUP_ALLOWSLIDEFRIC = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_608:
				num = 68
				If Not RSWIN_DESC.bExpert Then
					GoTo IL_65F
				End If
				IL_613:
				num = 69
				text4 = "DisplayRuntimeWarning"
				flag = True
				RSWIN_DESC.SETUP_DisplayRuntimeWarning = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_639:
				num = 70
				text4 = "DisplayTargetBFPDWarning"
				flag = True
				RSWIN_DESC.SETUP_DisplayTargetBFPDWarning = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_65F:
				num = 72
				If Not RSWIN_DESC.bRodStarD Then
					GoTo IL_676
				End If
				IL_66A:
				num = 73
				RSWIN_DESC.SETUP_ALLOWSLIDEFRIC = -1S
				IL_674:
				GoTo IL_684
				IL_676:
				num = 75
				IL_67A:
				num = 76
				RSWIN_DESC.SETUP_ALLOWSLIDEFRIC = 0S
				IL_684:
				num = 78
				text4 = "CalcVBeltRatio"
				flag = False
				RSWIN_DESC.SETUP_CalcVBeltRatio = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_6AA:
				num = 79
				text4 = "MaxSteelLoading"
				text2 = ".95"
				obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, text3, False)
				IL_6D3:
				num = 80
				RSWIN_DESC.SETUP_MaxSteelLoading = 0F
				IL_6E1:
				ProjectData.ClearProjectError()
				num4 = 1
				IL_6E9:
				num = 82
				ini.CheckForDecimal(text3)
				IL_6F4:
				num = 83
				RSWIN_DESC.SETUP_MaxSteelLoading = CSng(Convert.ToDouble(Strings.Left(text3, Conversions.ToInteger(obj))))
				IL_70F:
				ProjectData.ClearProjectError()
				num4 = 0
				IL_717:
				num = 85
				If Not(RSWIN_DESC.SETUP_MaxSteelLoading <= 0F Or RSWIN_DESC.SETUP_MaxSteelLoading > 1F) Then
					GoTo IL_747
				End If
				IL_739:
				num = 86
				RSWIN_DESC.SETUP_MaxSteelLoading = 0.95F
				IL_747:
				num = 88
				text4 = "MaxFGLoading"
				text2 = ".95"
				obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, text3, False)
				IL_770:
				num = 89
				RSWIN_DESC.SETUP_MaxFGLoading = 0F
				IL_77E:
				ProjectData.ClearProjectError()
				num4 = 1
				IL_786:
				num = 91
				ini.CheckForDecimal(text3)
				IL_791:
				num = 92
				RSWIN_DESC.SETUP_MaxFGLoading = CSng(Convert.ToDouble(Strings.Left(text3, Conversions.ToInteger(obj))))
				IL_7AC:
				ProjectData.ClearProjectError()
				num4 = 0
				IL_7B4:
				num = 94
				If Not(RSWIN_DESC.SETUP_MaxFGLoading <= 0F Or RSWIN_DESC.SETUP_MaxFGLoading > 1F) Then
					GoTo IL_7E4
				End If
				IL_7D6:
				num = 95
				RSWIN_DESC.SETUP_MaxFGLoading = 0.95F
				IL_7E4:
				num = 97
				If RSWIN_DESC.bBETA Then
					GoTo IL_8E0
				End If
				IL_7F2:
				num = 98
				text4 = "GearboxRatio"
				text2 = "28.45"
				obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, text3, False)
				IL_81B:
				num = 99
				If Not Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
					GoTo IL_83E
				End If
				IL_82E:
				num = 100
				RSWIN_DESC.SETUP_GearboxRatio = 28.45F
				IL_83C:
				GoTo IL_868
				IL_83E:
				num = 102
				IL_842:
				num = 103
				ini.CheckForDecimal(text3)
				IL_84D:
				num = 104
				RSWIN_DESC.SETUP_GearboxRatio = CSng(Convert.ToDouble(Strings.Left(text3, Conversions.ToInteger(obj))))
				IL_868:
				num = 106
				text4 = "VBeltRatio"
				text2 = "3.2961"
				obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, text3, False)
				IL_891:
				num = 107
				If Not Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
					GoTo IL_8B4
				End If
				IL_8A4:
				num = 108
				RSWIN_DESC.SETUP_VBeltRatio = 3.2961F
				IL_8B2:
				GoTo IL_900
				IL_8B4:
				num = 110
				IL_8B8:
				num = 111
				ini.CheckForDecimal(text3)
				IL_8C3:
				num = 112
				RSWIN_DESC.SETUP_VBeltRatio = CSng(Convert.ToDouble(Strings.Left(text3, Conversions.ToInteger(obj))))
				IL_8DE:
				GoTo IL_900
				IL_8E0:
				num = 115
				IL_8E4:
				num = 116
				RSWIN_DESC.SETUP_GearboxRatio = 28.45F
				IL_8F2:
				num = 117
				RSWIN_DESC.SETUP_VBeltRatio = 3.2961F
				IL_900:
				num = 119
				text4 = "CoverPage"
				flag = False
				RSWIN_DESC.SETUP_CoverPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_926:
				num = 120
				text4 = "OrderPage"
				flag = False
				RSWIN_DESC.SETUP_OrderPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_94C:
				num = 121
				text4 = "PrintData"
				flag = True
				RSWIN_DESC.SETUP_PrintData = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_972:
				num = 122
				text4 = "PrintCostAnalysis"
				flag = True
				RSWIN_DESC.SETUP_PrintCostAnalysis = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_998:
				num = 123
				text4 = "PrintDiagnosis"
				flag = True
				RSWIN_DESC.SETUP_PrintDiagnosis = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1, 0)), 1, 0)
				IL_9BD:
				num = 124
				text4 = "PrintDynoActual"
				flag = True
				RSWIN_DESC.SETUP_PrintDynoActual = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_9E3:
				num = 125
				text4 = "PrintDynoPred"
				flag = True
				RSWIN_DESC.SETUP_PrintDynoPred = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_A09:
				num = 126
				text4 = "PrintIPR"
				flag = True
				RSWIN_DESC.SETUP_PrintIPR = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_A2F:
				num = 127
				RSWIN_DESC.SETUP_PrintSinglePageDynoTorque = RSWIN_DESC.SETUP_PrintDynoPred
				IL_A3D:
				num = 128
				RSWIN_DESC.SETUP_PrintTorque = RSWIN_DESC.SETUP_PrintDynoPred
				IL_A4E:
				num = 129
				text4 = "PrintDevChart"
				flag = False
				RSWIN_DESC.SETUP_PrintDevChart = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_A77:
				num = 130
				text4 = "PrintGuide"
				flag = False
				RSWIN_DESC.SETUP_PrintGuide = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_AA0:
				num = 131
				text4 = "ReportDevSurvey"
				flag = False
				RSWIN_DESC.SETUP_ReportDevSurvey = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_AC9:
				num = 132
				text4 = "SummaryPage"
				flag = False
				RSWIN_DESC.SETUP_SummaryPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_AF2:
				num = 133
				text4 = "ScoringPage"
				flag = True
				RSWIN_DESC.SETUP_ScoringPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag) > False), 1S, 0S)), 1S, 0S)
				IL_B1B:
				num = 134
				RSWIN_DESC.rst.gbCoverPage = (RSWIN_DESC.SETUP_CoverPage <> 0S)
				IL_B34:
				num = 135
				RSWIN_DESC.rst.gbReportData = (RSWIN_DESC.SETUP_PrintData <> 0S)
				IL_B4D:
				num = 136
				RSWIN_DESC.rst.gbReportCostAnalysis = RSWIN_DESC.SETUP_PrintCostAnalysis
				IL_B63:
				num = 137
				RSWIN_DESC.rst.gbReportDynoActual = (RSWIN_DESC.SETUP_PrintDynoActual <> 0S)
				IL_B7C:
				num = 138
				RSWIN_DESC.rst.gbReportDynoPred = (RSWIN_DESC.SETUP_PrintDynoPred <> 0S)
				IL_B95:
				num = 139
				RSWIN_DESC.rst.gbReportIPR = (RSWIN_DESC.SETUP_PrintIPR <> 0S)
				IL_BAE:
				num = 140
				RSWIN_DESC.rst.gbReportTorque = (RSWIN_DESC.SETUP_PrintTorque <> 0S)
				IL_BC7:
				num = 141
				RSWIN_DESC.rst.gbReportSinglePageDynoTorque = (RSWIN_DESC.SETUP_PrintSinglePageDynoTorque <> 0S)
				IL_BE0:
				num = 142
				RSWIN_DESC.rst.gbReportDevChart = (RSWIN_DESC.SETUP_PrintDevChart <> 0S)
				IL_BF9:
				num = 143
				RSWIN_DESC.rst.gbReportGuide = (RSWIN_DESC.SETUP_PrintGuide <> 0S)
				IL_C12:
				num = 144
				RSWIN_DESC.rst.gbReportDevSurvey = (RSWIN_DESC.SETUP_ReportDevSurvey <> 0S)
				IL_C2B:
				num = 145
				RSWIN_DESC.rst.gbSummaryPage = (RSWIN_DESC.SETUP_SummaryPage <> 0S)
				IL_C44:
				num = 146
				RSWIN_DESC.rst.gbScoringPage = (RSWIN_DESC.SETUP_ScoringPage <> 0S)
				IL_C5D:
				num = 147
				text4 = "BeginTime"
				text2 = ""
				obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, text3, False)
				IL_C89:
				num = 148
				Dim text5 As String = Strings.Trim(Strings.Left(text3, Conversions.ToInteger(obj)))
				IL_CA3:
				num = 149
				If Not Information.IsDate(text5) Then
					GoTo IL_CC8
				End If
				IL_CB3:
				num = 150
				RSWIN_DESC.SETUP_BeginTime = Convert.ToDateTime(text5)
				IL_CC6:
				GoTo IL_CE5
				IL_CC8:
				num = 152
				IL_CCF:
				num = 153
				RSWIN_DESC.SETUP_BeginTime = Conversions.ToDate("00:00:00")
				IL_CE5:
				num = 155
				text4 = "IntervalTime"
				text2 = ""
				obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, text3, False)
				IL_D11:
				num = 156
				text5 = Strings.Trim(Strings.Left(text3, Conversions.ToInteger(obj)))
				IL_D2B:
				num = 157
				If Not Information.IsDate(text5) Then
					GoTo IL_D50
				End If
				IL_D3B:
				num = 158
				RSWIN_DESC.SETUP_IntervalTime = Convert.ToDateTime(text5)
				IL_D4E:
				GoTo IL_D6D
				IL_D50:
				num = 160
				IL_D57:
				num = 161
				RSWIN_DESC.SETUP_IntervalTime = Conversions.ToDate("00:20:00")
				IL_D6D:
				num = 163
				text4 = "RODSTARDirectory"
				text2 = ""
				obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, text3, False)
				IL_D99:
				num = 164
				RSWIN_DESC.SETUP_RSWINDIR = Strings.Trim(Strings.Left(text3, Conversions.ToInteger(obj)))
				IL_DB6:
				num = 165
				If Strings.Len(RSWIN_DESC.SETUP_RSWINDIR) <= 0 Then
					GoTo IL_E45
				End If
				IL_DCA:
				ProjectData.ClearProjectError()
				num4 = 1
				IL_DD2:
				num = 167
				Dim text6 As String = FileSystem.Dir(Conversions.ToString(Operators.ConcatenateObject(RSWIN_DESC.SETUP_RSWINDIR, Interaction.IIf(Operators.CompareString(Strings.Right(RSWIN_DESC.SETUP_RSWINDIR, 1), "\", False) = 0, "*.*", "\*.*"))), FileAttribute.Normal)
				IL_E18:
				num = 168
				If Information.Err().Number = 0 Then
					GoTo IL_E3D
				End If
				IL_E2C:
				num = 169
				RSWIN_DESC.SETUP_RSWINDIR = ""
				IL_E3D:
				ProjectData.ClearProjectError()
				num4 = 0
				IL_E45:
				num = 173
				If Not RSWIN_DESC.bExpert Then
					GoTo IL_E64
				End If
				IL_E53:
				num = 174
				RSWIN_DESC.SETUP_GURUTEMPDIR = "c:\Theta\TEMP\"
				IL_E64:
				num = 176
				text4 = "WK1Directory"
				text2 = ""
				obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, text3, False)
				IL_E90:
				num = 177
				RSWIN_DESC.SETUP_WK1Dir = Strings.Trim(Strings.Left(text3, Conversions.ToInteger(obj)))
				IL_EAD:
				num = 178
				If Strings.Len(RSWIN_DESC.SETUP_WK1Dir) <= 0 Then
					GoTo IL_F3C
				End If
				IL_EC1:
				ProjectData.ClearProjectError()
				num4 = 1
				IL_EC9:
				num = 180
				text6 = FileSystem.Dir(Conversions.ToString(Operators.ConcatenateObject(RSWIN_DESC.SETUP_WK1Dir, Interaction.IIf(Operators.CompareString(Strings.Right(RSWIN_DESC.SETUP_WK1Dir, 1), "\", False) = 0, "*.*", "\*.*"))), FileAttribute.Normal)
				IL_F0F:
				num = 181
				If Information.Err().Number = 0 Then
					GoTo IL_F34
				End If
				IL_F23:
				num = 182
				RSWIN_DESC.SETUP_WK1Dir = ""
				IL_F34:
				ProjectData.ClearProjectError()
				num4 = 0
				IL_F3C:
				num = 186
				text4 = "WK1Format"
				text2 = ""
				obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, text3, False)
				IL_F68:
				num = 187
				RSWIN_DESC.SETUP_WK1Format = Strings.Trim(Strings.Left(text3, Conversions.ToInteger(obj)))
				IL_F85:
				num = 188
				text4 = "InitializedCustomMDB"
				text2 = ""
				obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, text3, False)
				IL_FB1:
				num = 189
				Dim text7 As String = text3.Substring(0, Conversions.ToInteger(obj))
				IL_FC7:
				num = 190
				If Operators.CompareString(text7, "True", False) <> 0 Then
					GoTo IL_104A
				End If
				IL_FDE:
				num = 191
				Dim text8 As String
				FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), text8, 2S, False, False, False, False)
				IL_FFB:
				num = 192
				If Operators.CompareString(text8.Trim(), "", False) = 0 Then
					GoTo IL_102F
				End If
				IL_1016:
				num = 193
				Custom.LoadCustomRodGradeList(RSWIN_DESC.CustomRodGradeList, False, "")
				IL_102D:
				GoTo IL_1063
				IL_102F:
				num = 195
				IL_1036:
				num = 196
				CUSTOMRG.LoadCustomRodGradeList(RSWIN_DESC.CustomRodGradeList, False)
				IL_1048:
				GoTo IL_1063
				IL_104A:
				num = 199
				IL_1051:
				num = 200
				CUSTOMRG.LoadCustomRodGradeList(RSWIN_DESC.CustomRodGradeList, False)
				IL_1063:
				num = 202
				RSWIN_DESC.DEBUG_AllowDebugging = False
				IL_1070:
				num = 203
				If Not RSWIN_DESC.DEBUG_AllowDebugging Then
					GoTo IL_10AB
				End If
				IL_107E:
				num = 204
				text4 = "RSWINDebug"
				text2 = "PlotAllDownholeCards"
				flag = False
				RSWIN_DESC.DEBUG_PlotAllDownholeCards = RSWIN.GetRegProfileStringByBoolean(text4, text2, flag)
				IL_10A6:
				GoTo IL_115D
				IL_10AB:
				num = 206
				IL_10B2:
				num = 207
				text4 = "RSWINDebug"
				text2 = "AllowDebugging"
				text = Nothing
				RSWIN.DeleteRegProfileStringFromKeyList(text4, text2, text, RSWIN_DESC.sINIFile)
				IL_10DB:
				num = 208
				RSWIN_DESC.DEBUG_DebugMessages = 0S
				IL_10E8:
				num = 209
				RSWIN_DESC.DEBUG_DisableAutomatic = 0S
				IL_10F5:
				num = 210
				RSWIN_DESC.DEBUG_DisableOnError = 0S
				IL_1102:
				num = 211
				RSWIN_DESC.DEBUG_FixSinusoidalDyno = 0S
				IL_110F:
				num = 212
				RSWIN_DESC.DEBUG_NoFIReplaceGoodMatch = 0S
				IL_111C:
				num = 213
				RSWIN_DESC.DEBUG_RDGFilesFirst = 0S
				IL_1129:
				num = 214
				RSWIN_DESC.DEBUG_SaveCards = 0S
				IL_1136:
				num = 215
				RSWIN_DESC.DEBUG_ShowPredictInfo = 0S
				IL_1143:
				num = 216
				RSWIN_DESC.DEBUG_TreatAsSolidLine = 0S
				IL_1150:
				num = 217
				RSWIN_DESC.DEBUG_PlotAllDownholeCards = False
				IL_115D:
				num = 219
				If RSWIN_DESC.DEBUG_DisableAutomatic = 0S Then
					GoTo IL_1180
				End If
				IL_116E:
				num = 220
				RSWIN_DESC.rst.gbAutomaticEnabled = False
				IL_1180:
				num = 222
				If Not RSWIN_DESC.bExpert Then
					GoTo IL_11A7
				End If
				IL_118E:
				num = 223
				RSWIN.LoadExpertPreferences()
				IL_119A:
				num = 224
				MRodstarXML.SetAIFilePreferencesFromSetup(False)
				IL_11A7:
				num = 226
				text4 = "UseAllDiameters"
				flag = False
				RSWIN_DESC.SETUP_UseAllDiameters = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag)
				IL_11CB:
				num = 227
				RSWIN_DESC.SETUP_UseBucklingTendencyStresses = True
				IL_11D8:
				num = 228
				RSWIN_DESC.SETUP_UseJeffsFix = True
				IL_11E5:
				num = 229
				RSWIN_DESC.SETUP_UseJohnsFix = True
				IL_11F2:
				num = 230
				RSWIN_DESC.sCasingSizes(0) = "2.875"
				IL_1205:
				num = 231
				RSWIN_DESC.sCasingSizes(1) = "3.5"
				IL_1218:
				num = 232
				RSWIN_DESC.sCasingSizes(2) = "4"
				IL_122B:
				num = 233
				RSWIN_DESC.sCasingSizes(3) = "4.5"
				IL_123E:
				num = 234
				RSWIN_DESC.sCasingSizes(4) = "5"
				IL_1251:
				num = 235
				RSWIN_DESC.sCasingSizes(5) = "5.5"
				IL_1264:
				num = 236
				RSWIN_DESC.sCasingSizes(6) = "6.625"
				IL_1277:
				num = 237
				RSWIN_DESC.sCasingSizes(7) = "7"
				IL_128A:
				num = 238
				RSWIN_DESC.sCasingSizes(8) = "7.625"
				IL_129D:
				num = 239
				RSWIN_DESC.Reliance_Table(1, 1) = "256"
				IL_12B5:
				num = 240
				RSWIN_DESC.Reliance_Table(1, 2) = "Low (5.4 hp)"
				IL_12CD:
				num = 241
				RSWIN_DESC.Reliance_Table(1, 3) = "Medium/Low (6.8 hp)"
				IL_12E5:
				num = 242
				RSWIN_DESC.Reliance_Table(1, 4) = "Medium (8.5 hp)"
				IL_12FD:
				num = 243
				RSWIN_DESC.Reliance_Table(1, 5) = "High (12 hp)"
				IL_1315:
				num = 244
				RSWIN_DESC.Reliance_Table(2, 1) = "326"
				IL_132D:
				num = 245
				RSWIN_DESC.Reliance_Table(2, 2) = "Low (9.5 hp)"
				IL_1345:
				num = 246
				RSWIN_DESC.Reliance_Table(2, 3) = "Medium/Low (11.4 hp)"
				IL_135D:
				num = 247
				RSWIN_DESC.Reliance_Table(2, 4) = "Medium (13.5 hp)"
				IL_1375:
				num = 248
				RSWIN_DESC.Reliance_Table(2, 5) = "High (21.5 hp)"
				IL_138D:
				num = 249
				RSWIN_DESC.Reliance_Table(3, 1) = "404"
				IL_13A5:
				num = 250
				RSWIN_DESC.Reliance_Table(3, 2) = "Low (16.5 hp)"
				IL_13BD:
				num = 251
				RSWIN_DESC.Reliance_Table(3, 3) = "Medium/Low (20.7 hp)"
				IL_13D5:
				num = 252
				RSWIN_DESC.Reliance_Table(3, 4) = "Medium (26 hp)"
				IL_13ED:
				num = 253
				RSWIN_DESC.Reliance_Table(3, 5) = "High (41.5 hp)"
				IL_1405:
				num = 254
				RSWIN_DESC.Reliance_Table(4, 1) = "405"
				IL_141D:
				num = 255
				RSWIN_DESC.Reliance_Table(4, 2) = "Low (27.6 hp)"
				IL_1435:
				num = 256
				RSWIN_DESC.Reliance_Table(4, 3) = "Medium/Low (32.5 hp)"
				IL_144D:
				num = 257
				RSWIN_DESC.Reliance_Table(4, 4) = "Medium (42 hp)"
				IL_1465:
				num = 258
				RSWIN_DESC.Reliance_Table(4, 5) = "High (55 hp)"
				IL_147D:
				num = 259
				RSWIN_DESC.Reliance_Table(5, 1) = "445"
				IL_1495:
				num = 260
				RSWIN_DESC.Reliance_Table(5, 2) = "Low (30.5 hp)"
				IL_14AD:
				num = 261
				RSWIN_DESC.Reliance_Table(5, 3) = "Medium/Low (39.3 hp)"
				IL_14C5:
				num = 262
				RSWIN_DESC.Reliance_Table(5, 4) = "Medium (49.5 hp)"
				IL_14DD:
				num = 263
				RSWIN_DESC.Reliance_Table(5, 5) = "High (72 hp)"
				IL_14F5:
				num = 264
				RSWIN_DESC.Reliance_Table(6, 1) = "447"
				IL_150D:
				num = 265
				RSWIN_DESC.Reliance_Table(6, 2) = "Low (47.5 hp)"
				IL_1525:
				num = 266
				RSWIN_DESC.Reliance_Table(6, 3) = "Medium/Low (59.5 hp)"
				IL_153D:
				num = 267
				RSWIN_DESC.Reliance_Table(6, 4) = "Medium (74.5 hp)"
				IL_1555:
				num = 268
				RSWIN_DESC.Reliance_Table(6, 5) = "High (97 hp)"
				IL_156D:
				num = 269
				RSWIN_DESC.Reliance_Table(7, 1) = "449"
				IL_1585:
				num = 270
				RSWIN_DESC.Reliance_Table(7, 2) = "Low (60 hp)"
				IL_159D:
				num = 271
				RSWIN_DESC.Reliance_Table(7, 3) = "Medium/Low (75 hp)"
				IL_15B5:
				num = 272
				RSWIN_DESC.Reliance_Table(7, 4) = "Medium (94 hp)"
				IL_15CD:
				num = 273
				RSWIN_DESC.Reliance_Table(7, 5) = "High (120 hp)"
				IL_15E5:
				num = 274
				If Not RSWIN_DESC.bRodStarD Then
					GoTo IL_1617
				End If
				IL_15F3:
				num = 275
				text4 = "RecommendGuides"
				flag = True
				RSWIN_DESC.SETUP_RECOMMEND_GUIDES = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag)
				IL_1617:
				num = 277
				text4 = "ExcelInstalled"
				flag = True
				RSWIN_DESC.SETUP_ExcelInstalled = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text4, flag)
				IL_163B:
				num = 278
				If Not RSWIN_DESC.SETUP_ExcelInstalled Then
					GoTo IL_165F
				End If
				IL_1649:
				num = 279
				RSWIN_DESC.objExcel = New ExcelXLS()
				IL_165A:
				GoTo IL_1B49
				IL_165F:
				num = 281
				IL_1666:
				num = 282
				RSWIN_DESC.objExcel = New ExcelXLS_Infragistics()
				IL_1677:
				IL_167C:
				GoTo IL_1B49
				IL_1681:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_1B05:
				GoTo IL_1B3E
				IL_1B07:
				num6 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_1B1A:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num4 <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_1B07
			End Try
			IL_1B3E:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1B49:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function LoadSpeech(frm As Form) As Object
			Return False
		End Function

		Public Sub MenuSetup()
		End Sub

		Public Function MenuString(hMenu As Object, fwMenu As Object, wIDItem As Object) As String
			Dim result As String
			Return result
		End Function

		Public Sub ReadFile(Inputfile As String, ByRef bFileLoaded As Boolean, Optional bQuiet As Boolean = False)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			bFileLoaded = False
			RSWIN_DESC.fDefaultTargetProduction = 0F
			Try
				RSWIN_DESC.bReadingFile = True
				If Strings.InStr(Inputfile.ToLower(), ".xddx", CompareMethod.Binary) > 0 Then
					Dim flag3 As Boolean = MRodstarXML.ValidateXML(Inputfile)
					If flag3 Then
						MessageBox.Show("File is not valid!", "Open File Error", MessageBoxButtons.OK)
					Else
						bFileLoaded = MRodstarXML.LoadXDIAGXML(Inputfile, True)
					End If
				ElseIf LikeOperator.LikeString(Strings.LCase(Inputfile), "*.rstx", CompareMethod.Binary) Or LikeOperator.LikeString(Strings.LCase(Inputfile), "*.rsvx", CompareMethod.Binary) Or LikeOperator.LikeString(Strings.LCase(Inputfile), "*.rsdx", CompareMethod.Binary) Or (LikeOperator.LikeString(Strings.LCase(Inputfile), "*.xrvx", CompareMethod.Binary) And RSWIN_DESC.SETUP_bGuru) Then
					Dim flag3 As Boolean = MRodstarXML.ValidateXML(Inputfile)
					If flag3 Then
						MessageBox.Show("File is not valid!", "Open File Error", MessageBoxButtons.OK)
					Else
						bFileLoaded = MRodstarXML.LoadRodstarXML(Inputfile)
						If bFileLoaded Then
							FILEIO.CheckSurveyOrder()
							RSWIN_DESC.rst.Inputfile = Inputfile
							If(Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch) AndAlso (RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bExpert) Then
								If(If((-If((RSWIN_DESC.rst.Runtime < 24F > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_DisplayRuntimeWarning) <> 0S Then
									MessageBox.Show(RSWIN.sRunTimeMsg, "Run time")
								End If
								If RSWIN_DESC.rst.TargetBFPD = 0F Then
									If flag OrElse flag2 Then
										Dim dialogResult As DialogResult = MessageBox.Show("AI mode requires input of target production. Continue to Production Information data entry window? (To compare measured and predicted dynamometer cards, select 'NO' and switch to non-AI mode before opening the file).", "Target Production Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
										If dialogResult = DialogResult.Yes Then
											RSWIN_DESC.rst.TargetBFPD = RSWIN_DESC.fDefaultTargetProduction
											ini.SaveDataValue("TargetBFPD", RSWIN_DESC.fDefaultTargetProduction)
											RSWIN_DESC.frmMain.DisplayForm("ProdInfo", "txtSPMBFPD")
										End If
									Else
										RSWIN_DESC.frmMain.DisplayForm("ProdInfo", "txtSPMBFPD")
									End If
								End If
							End If
						End If
					End If
				ElseIf LikeOperator.LikeString(Strings.LCase(Inputfile), "*.xrvx", CompareMethod.Binary) And Not RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru Then
					MessageBox.Show("XRVX file type requires XROD-V and AI mode.", "Open File Error", MessageBoxButtons.OK)
				Else
					' The following expression was wrapped in a checked-expression
					Dim num As Short = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num), Inputfile, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
					If Strings.InStr(Inputfile, ".xdg", CompareMethod.Binary) > 0 Or Strings.InStr(Inputfile, ".XDG", CompareMethod.Binary) > 0 Then
						flag = True
					End If
					Dim flag4 As Boolean = True
					If flag4 = FILEIO.IsKindOfFile(num, RSWIN_DESC.RSMagic) Then
						bFileLoaded = LOADRST.LoadRodstarFile(num, Inputfile)
						If bFileLoaded Then
							FILEIO.CheckSurveyOrder()
							RSWIN_DESC.rst.Inputfile = Inputfile
						End If
					ElseIf flag4 = FILEIO.IsKindOfFile(num, RSWIN_DESC.RDMagic) Then
						Dim num2 As Short = If((-If((bFileLoaded > False), 1S, 0S)), 1S, 0S)
						LOADRDG.LoadRoddiagFile(num, num2, Inputfile)
						bFileLoaded = (num2 <> 0S)
						If bFileLoaded Then
							If Strings.InStr(Inputfile, ".rdg", CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = Inputfile.Replace(".rdg", ".rsvx")
							ElseIf Strings.InStr(Inputfile, ".RDG", CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = Inputfile.Replace(".RDG", ".rsvx")
							End If
							flag2 = True
						End If
					ElseIf flag4 = FILEIO.IsKindOfFile(num, RSWIN_DESC.XDMagic) Then
						Dim num3 As Integer = CInt(num)
						LoadXDG.LoadXdiagFile(num3, bFileLoaded, flag, Inputfile)
						num = CShort(num3)
						If bFileLoaded Then
							flag = True
							If Strings.InStr(Inputfile, ".xdg", CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = Inputfile.Replace(".xdg", ".rsvx")
							ElseIf Strings.InStr(Inputfile, ".XDG", CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = Inputfile.Replace(".XDG", ".rsvx")
							End If
						End If
					Else
						Util.cErrmsg(120)
					End If
					FileSystem.FileClose(New Integer() { CInt(num) })
					If bFileLoaded Then
						Try
							If Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 And Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch Then
								Dim pudataRec As RSWIN_DESC.PUDataRec = Nothing
								pudataRec.Initialize()
								pudataRec = RSWIN_DESC.rst.PU
								Dim flag5 As Boolean = PUDATA1.CheckCustomUnitList(pudataRec, Inputfile)
							End If
							If RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bExpert Then
								If(If((-If((RSWIN_DESC.rst.Runtime < 24F > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_DisplayRuntimeWarning) <> 0S Then
									MessageBox.Show(RSWIN.sRunTimeMsg, "Run time")
								End If
								If RSWIN_DESC.rst.TargetBFPD = 0F Then
									If flag OrElse flag2 Then
										Dim dialogResult As DialogResult = MessageBox.Show("AI mode requires input of target production. Continue to Production Information data entry window? (To compare measured and predicted dynamometer cards, select 'NO' and switch to non-AI mode before opening the file).", "Target Production Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
										If dialogResult = DialogResult.Yes Then
											RSWIN_DESC.rst.TargetBFPD = RSWIN_DESC.fDefaultTargetProduction
											ini.SaveDataValue("TargetBFPD", RSWIN_DESC.fDefaultTargetProduction)
											RSWIN_DESC.frmMain.DisplayForm("ProdInfo", "txtSPMBFPD")
										End If
									Else
										RSWIN_DESC.frmMain.DisplayForm("ProdInfo", "txtSPMBFPD")
									End If
								End If
							End If
						Catch ex As Exception
						End Try
					End If
				End If
				RSWIN_DESC.bReadingFile = False
			Catch ex2 As Exception
				Dim sMsg As String = "Error in ReadFile: " + ex2.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult2 As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult2)
				RSWIN_DESC.bReadingFile = False
			End Try
		End Sub

		Public Sub SaveDefaults()
			Try
				Dim setup_Language As String = "General"
				Dim text As String = "MeasurementSystem"
				Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text2 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				Dim text3 As String = text2
				Dim num As Long = CLng(RSWIN.WriteRegProfileString(setup_Language, text, text3, RSWIN_DESC.sINIFile))
				text3 = "General"
				text = "Language"
				setup_Language = RSWIN_DESC.SETUP_Language
				Dim num2 As Long = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
				RSWIN_DESC.SETUP_Language = setup_Language
				num = num2
				text3 = "General"
				text = "ShowVisualInput"
				setup_Language = Convert.ToString(RSWIN_DESC.SETUP_ShowVisualInput)
				num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
				text3 = "General"
				text = "ExitIfIdle"
				setup_Language = Convert.ToString(RSWIN_DESC.SETUP_ExitIfIdle)
				num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
				text3 = "General"
				text = "SaveOpenFileOnExit"
				setup_Language = Convert.ToString(RSWIN_DESC.SETUP_SaveOpenFileOnExit)
				num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
				text3 = "General"
				text = "TabletPort"
				obj = RSWIN_DESC.SETUP_TabletPort
				Dim text4 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_TabletPort = Conversions.ToInteger(obj)
				setup_Language = text4
				num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
				text3 = "General"
				text = "SaveXDIAGMeasuredCard"
				setup_Language = Convert.ToString(RSWIN_DESC.SETUP_SaveXDIAGMeasuredCard)
				num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
				If RSWIN_DESC.bRodStarD And RSWIN_DESC.bAllowRodLimitEntry Then
					text3 = "General"
					text = "UseDefaultRodElementLimit"
					setup_Language = Convert.ToString(RSWIN_DESC.SETUP_UseDefaultRodElementLimit)
					num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
					If Not RSWIN_DESC.SETUP_UseDefaultRodElementLimit Then
						text3 = "General"
						text = "RodElementLimit"
						obj = RSWIN_DESC.SETUP_RodElementLimit
						Dim text5 As String = Util.Format(obj)
						RSWIN_DESC.SETUP_RodElementLimit = Conversions.ToInteger(obj)
						setup_Language = text5
						num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
					End If
				End If
				If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					text3 = "General"
					text = "DisplaySBinFeet"
					setup_Language = Convert.ToString(RSWIN_DESC.SETUP_DisplaySBinFeet)
					num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
				End If
				text3 = "BatchPrintouts"
				obj = RSWIN_DESC.SETUP_BatchPrintouts
				Dim text6 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_BatchPrintouts = Conversions.ToInteger(obj)
				text = text6
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "BatchSaveWorksheet"
				obj = RSWIN_DESC.SETUP_BatchSaveWorksheet
				Dim text7 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_BatchSaveWorksheet = Conversions.ToInteger(obj)
				text = text7
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "BatchViewWorksheet"
				obj = RSWIN_DESC.SETUP_BatchViewWorksheet
				Dim text8 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_BatchViewWorksheet = Conversions.ToInteger(obj)
				text = text8
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "ExcelInstalled"
				obj = RSWIN_DESC.SETUP_ExcelInstalled
				Dim text9 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_ExcelInstalled = Conversions.ToBoolean(obj)
				text = text9
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "BatchSkipProcessedFiles"
				obj = RSWIN_DESC.SETUP_BatchSkipProcessedFiles
				Dim text10 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_BatchSkipProcessedFiles = Conversions.ToInteger(obj)
				text = text10
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "BatchUpdateCustomRodGrades"
				obj = RSWIN_DESC.SETUP_BatchUpdateCustomRodGrades
				Dim text11 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_BatchUpdateCustomRodGrades = Conversions.ToInteger(obj)
				text = text11
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "BatchCreatePDFs"
				obj = RSWIN_DESC.SETUP_CreatePDFs
				Dim text12 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_CreatePDFs = Conversions.ToInteger(obj)
				text = text12
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "UseImpred"
				text = Conversions.ToString(CInt(RSWIN_DESC.SETUP_UseImpred))
				Dim num3 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				RSWIN_DESC.SETUP_UseImpred = Conversions.ToShort(text)
				num = num3
				text3 = "GuideToUse"
				text = Conversions.ToString(RSWIN_DESC.SETUP_GuideToUse)
				Dim num4 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(text)
				num = num4
				text3 = "DisplayAZDIRToolbar"
				text = Conversions.ToString(CInt(RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR))
				Dim num5 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR = Conversions.ToShort(text)
				num = num5
				text3 = "OptimizeSurvey"
				text = Conversions.ToString(CInt(RSWIN_DESC.SETUP_OPTIMIZESURVEY))
				Dim num6 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				RSWIN_DESC.SETUP_OPTIMIZESURVEY = Conversions.ToShort(text)
				num = num6
				text3 = "AllowSlideFric"
				text = Conversions.ToString(CInt(RSWIN_DESC.SETUP_ALLOWSLIDEFRIC))
				Dim num7 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				RSWIN_DESC.SETUP_ALLOWSLIDEFRIC = Conversions.ToShort(text)
				num = num7
				text3 = "CalcVBeltRatio"
				text = Conversions.ToString(CInt(RSWIN_DESC.SETUP_CalcVBeltRatio))
				Dim num8 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				RSWIN_DESC.SETUP_CalcVBeltRatio = Conversions.ToShort(text)
				num = num8
				text3 = "UseAllDiameters"
				text = Conversions.ToString(RSWIN_DESC.SETUP_UseAllDiameters)
				Dim num9 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				RSWIN_DESC.SETUP_UseAllDiameters = Conversions.ToBoolean(text)
				num = num9
				text3 = "UseBucklingTendencyStresses"
				text = Conversions.ToString(RSWIN_DESC.SETUP_UseBucklingTendencyStresses)
				Dim num10 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				RSWIN_DESC.SETUP_UseBucklingTendencyStresses = Conversions.ToBoolean(text)
				num = num10
				text3 = "UseJeffsFix"
				text = Conversions.ToString(RSWIN_DESC.SETUP_UseJeffsFix)
				Dim num11 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				RSWIN_DESC.SETUP_UseJeffsFix = Conversions.ToBoolean(text)
				num = num11
				text3 = "UseJohnsFix"
				text = Conversions.ToString(RSWIN_DESC.SETUP_UseJohnsFix)
				Dim num12 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				RSWIN_DESC.SETUP_UseJohnsFix = Conversions.ToBoolean(text)
				num = num12
				If Not RSWIN_DESC.bBETA Then
					text3 = "GearboxRatio"
					obj = RSWIN_DESC.SETUP_GearboxRatio
					Dim text13 As String = Util.Format(obj)
					RSWIN_DESC.SETUP_GearboxRatio = Conversions.ToSingle(obj)
					text = text13
					num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
					text3 = "VBeltRatio"
					obj = RSWIN_DESC.SETUP_VBeltRatio
					Dim text14 As String = Util.Format(obj)
					RSWIN_DESC.SETUP_VBeltRatio = Conversions.ToSingle(obj)
					text = text14
					num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				End If
				If RSWIN_DESC.bExpert Then
					text3 = "DisplayRuntimeWarning"
					text = Conversions.ToString(CInt(RSWIN_DESC.SETUP_DisplayRuntimeWarning))
					Dim num13 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
					RSWIN_DESC.SETUP_DisplayRuntimeWarning = Conversions.ToShort(text)
					num = num13
					text3 = "DisplayTargetBFPDWarning"
					text = Conversions.ToString(CInt(RSWIN_DESC.SETUP_DisplayTargetBFPDWarning))
					Dim num14 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
					RSWIN_DESC.SETUP_DisplayTargetBFPDWarning = Conversions.ToShort(text)
					num = num14
				End If
				text3 = "MaxSteelLoading"
				obj = RSWIN_DESC.SETUP_MaxSteelLoading
				Dim text15 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MaxSteelLoading = Conversions.ToSingle(obj)
				text = text15
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "MaxFGLoading"
				obj = RSWIN_DESC.SETUP_MaxFGLoading
				Dim text16 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MaxFGLoading = Conversions.ToSingle(obj)
				text = text16
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "CoverPage"
				text = Convert.ToString(RSWIN_DESC.SETUP_CoverPage)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "OrderPage"
				text = Convert.ToString(RSWIN_DESC.SETUP_OrderPage)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "PrintData"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintData)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "PrintDiagnosis"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDiagnosis)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "PrintDynoPred"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "PrintDynoActual"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoActual)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "PrintIPR"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintIPR)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "PrintSinglePageDynoTorque"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "PrintTorque"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "PrintDevChart"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDevChart)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "PrintGuide"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintGuide)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "ReportDevSurvey"
				text = Convert.ToString(RSWIN_DESC.SETUP_ReportDevSurvey)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "SummaryPage"
				text = Convert.ToString(RSWIN_DESC.SETUP_SummaryPage)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				text3 = "ScoringPage"
				text = Convert.ToString(RSWIN_DESC.SETUP_ScoringPage)
				num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				If Not Information.IsDBNull(RSWIN_DESC.SETUP_BeginTime) Then
					text3 = "BeginTime"
					text = Convert.ToString(RSWIN_DESC.SETUP_BeginTime)
					num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				End If
				If Not Information.IsDBNull(RSWIN_DESC.SETUP_IntervalTime) Then
					text3 = "IntervalTime"
					text = Convert.ToString(RSWIN_DESC.SETUP_IntervalTime)
					num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				End If
				If Strings.Len(RSWIN_DESC.SETUP_RSWINDIR) > 0 Then
					text3 = "RODSTARDirectory"
					text = Strings.Trim(RSWIN_DESC.SETUP_RSWINDIR)
					num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				End If
				If Strings.Len(RSWIN_DESC.SETUP_WK1Dir) > 0 Then
					text3 = "WK1Directory"
					text = Strings.Trim(RSWIN_DESC.SETUP_WK1Dir)
					num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				End If
				If RSWIN_DESC.SETUP_WK1Format.Length > 0 Then
					text3 = "WK1Format"
					text = Strings.Trim(RSWIN_DESC.SETUP_WK1Format)
					num = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile))
				End If
				If RSWIN_DESC.DEBUG_AllowDebugging Then
					text3 = "RSWINDebug"
					text = "DebugMessages"
					setup_Language = Convert.ToString(RSWIN_DESC.DEBUG_DebugMessages)
					num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
					text3 = "RSWINDebug"
					text = "DisableAutomatic"
					setup_Language = Convert.ToString(RSWIN_DESC.DEBUG_DisableAutomatic)
					num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
					text3 = "RSWINDebug"
					text = "DisableOnError"
					setup_Language = Convert.ToString(RSWIN_DESC.DEBUG_DisableOnError)
					num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
					text3 = "RSWINDebug"
					text = "FixSinusoidalDyno"
					setup_Language = Convert.ToString(RSWIN_DESC.DEBUG_FixSinusoidalDyno)
					num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
					text3 = "RSWINDebug"
					text = "NoFIReplaceGoodMatch"
					setup_Language = Convert.ToString(RSWIN_DESC.DEBUG_NoFIReplaceGoodMatch)
					num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
					text3 = "RSWINDebug"
					text = "RDGFilesFirst"
					setup_Language = Convert.ToString(RSWIN_DESC.DEBUG_RDGFilesFirst)
					num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
					text3 = "RSWINDebug"
					text = "SaveCards"
					setup_Language = Convert.ToString(RSWIN_DESC.DEBUG_SaveCards)
					num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
					text3 = "RSWINDebug"
					text = "ShowPredictInfo"
					setup_Language = Convert.ToString(RSWIN_DESC.DEBUG_ShowPredictInfo)
					num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
					text3 = "RSWINDebug"
					text = "TreatAsSolidLine"
					setup_Language = Convert.ToString(RSWIN_DESC.DEBUG_TreatAsSolidLine)
					num = CLng(RSWIN.WriteRegProfileString(text3, text, setup_Language, RSWIN_DESC.sINIFile))
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ToolbarSetup()
		End Sub

		Public Function RDInitSentinel() As Boolean
			Dim num As Integer
			Try
				If Not num <> 0 Then
					If RSWIN_DESC.bRodStarD Then
						Dim text As String = "RODSTAR-D"
						Dim bAbortIfNotFound As Boolean = False
						Dim flag As Boolean = num <> 0
						SUPERPRO.InitSentinel(text, bAbortIfNotFound, flag)
						num = If((-If((flag > False), 1, 0)), 1, 0)
					ElseIf RSWIN_DESC.bExpert Then
						Dim text As String = "XRODV"
						Dim bAbortIfNotFound2 As Boolean = False
						Dim flag As Boolean = num <> 0
						SUPERPRO.InitSentinel(text, bAbortIfNotFound2, flag)
						num = If((-If((flag > False), 1, 0)), 1, 0)
					Else
						Dim text As String = "RSWIN"
						Dim bAbortIfNotFound3 As Boolean = False
						Dim flag As Boolean = num <> 0
						SUPERPRO.InitSentinel(text, bAbortIfNotFound3, flag)
						num = If((-If((flag > False), 1, 0)), 1, 0)
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in RDInitSentinel: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
			Return num <> 0
		End Function

		Public Sub CheckLoadedForms()
		End Sub

		Public Sub CloseDLLs()
			SUPERPRO.CloseSentinel()
		End Sub

		Public Sub DebugLog(ByRef sMessage As String)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(FileSystem.FreeFile())
			FileSystem.FileOpen(CInt(num), "C:\RSDEBUG.LOG", OpenMode.Append, OpenAccess.[Default], OpenShare.[Default], -1)
			FileSystem.PrintLine(CInt(num), New Object() { sMessage })
			FileSystem.FileClose(New Integer() { CInt(num) })
		End Sub

		Public Sub DoHelp(wCmd As Short, dwContextID As Integer)
		End Sub

		Public Sub ExitProgram()
		End Sub

		Public Function IsFormLoaded(ByRef frm As Form) As Boolean
			Dim result As Boolean
			If frm Is Nothing Then
				result = False
			ElseIf Not frm.Visible Then
				result = True
			ElseIf frm.Visible Then
				result = True
			End If
			Return result
		End Function

		Public Function IsFormLoadedByName(sFormName As String) As Boolean
			Dim result As Boolean
			Return result
		End Function

		Public Function IsFormLoadedByNum(frmNum As Short) As Boolean
			Dim result As Boolean
			Return result
		End Function

		Public Sub SetDataChanged(hwndCtl As Integer)
		End Sub

		Public Sub SetWindowChecked(frmNum As Short)
		End Sub

		Private Function CheckUnique() As Boolean
			Return True
		End Function

		Public Function GetRegValue(ByRef lpKeyName As String, ByRef lpValueName As String) As Boolean
			Dim result As Boolean
			Try
				Dim text As String = Strings.Space(16384)
				Dim flag As Boolean = RSWIN.CheckForKey(lpKeyName)
				Dim registryKey As RegistryKey
				If RSWIN_DESC.bUseCurrentUser Then
					registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)))
				Else
					registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)))
				End If
				Dim flag2 As Boolean = Conversions.ToBoolean(registryKey.GetValue(lpValueName))
				result = flag2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetInitialDir(sExt As String, Optional sDefault As String = "") As Object
			sExt = sExt.ToUpper()
			sDefault = Conversions.ToString(RSWIN_DESC.Default_File_Folder)
			Dim flag As Boolean = True
			Dim text As String
			Dim text2 As String
			Dim text3 As String
			Dim text4 As String
			Dim length As Short
			If flag = (Strings.InStr(sExt, ".XRVX", CompareMethod.Binary) > 0 And RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) Then
				text = "FolderDefaults"
				text2 = "DefaultFolderXRVX"
				text3 = ""
				length = CShort(RSWIN.GetRegProfileString(text, text2, text3, text4, False))
				RSWIN_DESC.DEFAULT_FOLDER_XRVX = Conversions.ToString(Interaction.IIf(text4.Substring(0, CInt(length)).Trim().Length > 0, text4.Substring(0, CInt(length)), sDefault))
				Return RSWIN_DESC.DEFAULT_FOLDER_XRVX
			End If
			If flag <> Strings.InStr(sExt, ".RST", CompareMethod.Binary) > 0 Then
				If flag <> Strings.InStr(sExt, ".RSTX", CompareMethod.Binary) > 0 Then
					If flag <> Strings.InStr(sExt, ".RSVX", CompareMethod.Binary) > 0 Then
						If flag <> Strings.InStr(sExt, ".RSDX", CompareMethod.Binary) > 0 Then
							If flag <> Strings.InStr(sExt, ".PDF", CompareMethod.Binary) > 0 Then
								If flag <> Strings.InStr(sExt, ".UPS", CompareMethod.Binary) > 0 Then
									If flag <> Strings.InStr(sExt, ".XDG", CompareMethod.Binary) > 0 Then
										If flag <> Strings.InStr(sExt, ".RDG", CompareMethod.Binary) > 0 Then
											If flag <> Strings.InStr(sExt, ".CBL", CompareMethod.Binary) > 0 Then
												If flag <> Strings.InStr(sExt, ".CBLX", CompareMethod.Binary) > 0 Then
													If flag <> Strings.InStr(sExt, ".XBLX", CompareMethod.Binary) > 0 Then
														If flag = Strings.InStr(sExt, ".IMP", CompareMethod.Binary) > 0 Then
															text3 = "FolderDefaults"
															text2 = "DefaultFolderIMP"
															text = ""
															length = CShort(RSWIN.GetRegProfileString(text3, text2, text, text4, False))
															RSWIN_DESC.DEFAULT_FOLDER_IMP = Conversions.ToString(Interaction.IIf(text4.Substring(0, CInt(length)).Trim().Length > 0, text4.Substring(0, CInt(length)), sDefault))
															Return RSWIN_DESC.DEFAULT_FOLDER_IMP
														End If
														If flag = Strings.InStr(sExt, ".DYN", CompareMethod.Binary) > 0 OrElse flag = Strings.InStr(sExt, ".DNS", CompareMethod.Binary) > 0 Then
															text3 = "FolderDefaults"
															text2 = "DefaultFolderDYN"
															text = ""
															length = CShort(RSWIN.GetRegProfileString(text3, text2, text, text4, False))
															RSWIN_DESC.DEFAULT_FOLDER_DYN = Conversions.ToString(Interaction.IIf(text4.Substring(0, CInt(length)).Trim().Length > 0, text4.Substring(0, CInt(length)), sDefault))
															Return RSWIN_DESC.DEFAULT_FOLDER_DYN
														End If
														If flag <> Strings.InStr(sExt, ".XLS", CompareMethod.Binary) > 0 AndAlso flag <> Strings.InStr(sExt, ".XLSX", CompareMethod.Binary) > 0 Then
															Return ""
														End If
														If RSWIN_DESC.rst.gbAutomatic Then
															Return RSWIN_DESC.SETUP_WK1Dir
														End If
														text3 = "FolderDefaults"
														text2 = "DefaultFolderXLS"
														text = ""
														length = CShort(RSWIN.GetRegProfileString(text3, text2, text, text4, False))
														RSWIN_DESC.DEFAULT_FOLDER_XLS = Conversions.ToString(Interaction.IIf(text4.Substring(0, CInt(length)).Trim().Length > 0, text4.Substring(0, CInt(length)), sDefault))
														Return RSWIN_DESC.DEFAULT_FOLDER_XLS
													End If
												End If
											End If
											text3 = "FolderDefaults"
											text2 = "DefaultFolderCBL"
											text = ""
											length = CShort(RSWIN.GetRegProfileString(text3, text2, text, text4, False))
											RSWIN_DESC.DEFAULT_FOLDER_CBL = Conversions.ToString(Interaction.IIf(text4.Substring(0, CInt(length)).Trim().Length > 0, text4.Substring(0, CInt(length)), sDefault))
											Return RSWIN_DESC.DEFAULT_FOLDER_CBL
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			text3 = "FolderDefaults"
			text2 = "DefaultFolderRST"
			text = ""
			length = CShort(RSWIN.GetRegProfileString(text3, text2, text, text4, False))
			RSWIN_DESC.DEFAULT_FOLDER_RST = Conversions.ToString(Interaction.IIf(text4.Substring(0, CInt(length)).Trim().Length > 0, text4.Substring(0, CInt(length)), sDefault))
			Return RSWIN_DESC.DEFAULT_FOLDER_RST
		End Function

		Public Sub WriteInitialDir(sExt As String, sVal As String)
			sExt = sExt.ToUpper()
			Dim flag As Boolean = True
			Dim text As String
			Dim text2 As String
			Dim num As Integer
			If flag <> Strings.InStr(sExt, ".RST", CompareMethod.Binary) > 0 Then
				If flag <> Strings.InStr(sExt, ".RSTX", CompareMethod.Binary) > 0 Then
					If flag <> Strings.InStr(sExt, ".RSVX", CompareMethod.Binary) > 0 Then
						If flag <> Strings.InStr(sExt, ".RSDX", CompareMethod.Binary) > 0 Then
							If flag <> Strings.InStr(sExt, ".PDF", CompareMethod.Binary) > 0 Then
								If flag <> Strings.InStr(sExt, ".UPS", CompareMethod.Binary) > 0 Then
									If flag <> Strings.InStr(sExt, ".XDG", CompareMethod.Binary) > 0 Then
										If flag <> Strings.InStr(sExt, ".RDG", CompareMethod.Binary) > 0 Then
											If flag = Strings.InStr(sExt, ".XRVX", CompareMethod.Binary) > 0 Then
												text = "FolderDefaults"
												text2 = "DefaultFolderXRVX"
												num = RSWIN.WriteRegProfileString(text, text2, sVal, RSWIN_DESC.sINIFile)
												RSWIN_DESC.DEFAULT_FOLDER_XRVX = sVal
												Return
											End If
											If flag <> Strings.InStr(sExt, ".CBL", CompareMethod.Binary) > 0 Then
												If flag <> Strings.InStr(sExt, ".CBLX", CompareMethod.Binary) > 0 Then
													If flag <> Strings.InStr(sExt, ".XBLX", CompareMethod.Binary) > 0 Then
														If flag = Strings.InStr(sExt, ".IMP", CompareMethod.Binary) > 0 Then
															text = "FolderDefaults"
															text2 = "DefaultFolderIMP"
															num = RSWIN.WriteRegProfileString(text, text2, sVal, RSWIN_DESC.sINIFile)
															RSWIN_DESC.DEFAULT_FOLDER_IMP = sVal
															Return
														End If
														If flag = Strings.InStr(sExt, ".DYN", CompareMethod.Binary) > 0 OrElse flag = Strings.InStr(sExt, ".DNS", CompareMethod.Binary) > 0 Then
															text = "FolderDefaults"
															text2 = "DefaultFolderDYN"
															num = RSWIN.WriteRegProfileString(text, text2, sVal, RSWIN_DESC.sINIFile)
															RSWIN_DESC.DEFAULT_FOLDER_DYN = sVal
															Return
														End If
														If(flag = Strings.InStr(sExt, ".XLS", CompareMethod.Binary) > 0 OrElse flag = Strings.InStr(sExt, ".XLSX", CompareMethod.Binary) > 0) AndAlso Not RSWIN_DESC.rst.gbAutomatic Then
															text = "FolderDefaults"
															text2 = "DefaultFolderXLS"
															num = RSWIN.WriteRegProfileString(text, text2, sVal, RSWIN_DESC.sINIFile)
															RSWIN_DESC.DEFAULT_FOLDER_XLS = sVal
														End If
														Return
													End If
												End If
											End If
											text = "FolderDefaults"
											text2 = "DefaultFolderCBL"
											num = RSWIN.WriteRegProfileString(text, text2, sVal, RSWIN_DESC.sINIFile)
											RSWIN_DESC.DEFAULT_FOLDER_CBL = sVal
											Return
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			text2 = "FolderDefaults"
			text = "DefaultFolderRST"
			num = RSWIN.WriteRegProfileString(text2, text, sVal, RSWIN_DESC.sINIFile)
			RSWIN_DESC.DEFAULT_FOLDER_RST = sVal
		End Sub

		Public Sub WriteAllInitialDirs()
			Dim text As String = "FolderDefaults"
			Dim text2 As String = "DefaultFolderRST"
			Dim num As Integer = RSWIN.WriteRegProfileString(text, text2, RSWIN_DESC.DEFAULT_FOLDER_RST, RSWIN_DESC.sINIFile)
			If Operators.CompareString(RSWIN_DESC.DEFAULT_FOLDER_XRVX.Trim(), "", False) = 0 Then
				RSWIN_DESC.DEFAULT_FOLDER_XRVX = RSWIN_DESC.DEFAULT_FOLDER_RST
			End If
			text2 = "FolderDefaults"
			text = "DefaultFolderXRVX"
			num = RSWIN.WriteRegProfileString(text2, text, RSWIN_DESC.DEFAULT_FOLDER_XRVX, RSWIN_DESC.sINIFile)
			text2 = "FolderDefaults"
			text = "DefaultFolderCBL"
			num = RSWIN.WriteRegProfileString(text2, text, RSWIN_DESC.DEFAULT_FOLDER_CBL, RSWIN_DESC.sINIFile)
			text2 = "FolderDefaults"
			text = "DefaultFolderIMP"
			num = RSWIN.WriteRegProfileString(text2, text, RSWIN_DESC.DEFAULT_FOLDER_IMP, RSWIN_DESC.sINIFile)
			text2 = "FolderDefaults"
			text = "DefaultFolderXLS"
			num = RSWIN.WriteRegProfileString(text2, text, RSWIN_DESC.DEFAULT_FOLDER_XLS, RSWIN_DESC.sINIFile)
			text2 = "FolderDefaults"
			text = "DefaultFolderDYN"
			num = RSWIN.WriteRegProfileString(text2, text, RSWIN_DESC.DEFAULT_FOLDER_DYN, RSWIN_DESC.sINIFile)
		End Sub

		Public Sub LoadExpertPreferences()
			' The following expression was wrapped in a checked-statement
			Try
				Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("FGGradeRod", 3, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.FGGradeRod = Conversions.ToShort(obj)
					RSWIN_DESC.FGRodType = RODUTIL.RodGrade(RSWIN_DESC.FGGradeRod)
				Else
					RSWIN_DESC.FGGradeRod = 16391S
					RSWIN_DESC.FGRodType = RODUTIL.RodGrade(RSWIN_DESC.FGGradeRod)
				End If
				obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("HSGradeRod", 3, 4101))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.HSGradeRod = Conversions.ToShort(obj)
					RSWIN_DESC.HSRodType = RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod)
				End If
				Dim guruDataBaseFileName As String
				Dim flag As Boolean
				If RSWIN_DESC.bExpert Then
					guruDataBaseFileName = "UseXRODVTubingSizes"
					flag = True
					RSWIN_DESC.SETUP_UseXRODVTubingSizes = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
					guruDataBaseFileName = "FixTubingSize"
					flag = False
					RSWIN_DESC.SETUP_FixTubingSize = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
					guruDataBaseFileName = "MaxCasingSize"
					Dim num As Single = 5.5F
					RSWIN_DESC.MaxCasingSize = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, num))
					guruDataBaseFileName = "MaxTubingSizeOD"
					num = 2.875F
					RSWIN_DESC.MaxTubingSizeOD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, num))
				Else
					RSWIN_DESC.SETUP_UseXRODVTubingSizes = True
					RSWIN_DESC.SETUP_FixTubingSize = False
					RSWIN_DESC.MaxCasingSize = 5.5F
					RSWIN_DESC.MaxTubingSizeOD = 2.875F
				End If
				guruDataBaseFileName = "bUseSteelRodsOnly"
				flag = True
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				guruDataBaseFileName = "bUseFGlassWithSteelOnBottom"
				flag = False
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				RSWIN_DESC.SETUP_bAdminDebug = False
				If RSWIN_DESC.bExpert AndAlso RSWIN_DESC.bXRODAdmin Then
					guruDataBaseFileName = "bXRODAdminDebug"
					flag = True
					RSWIN_DESC.SETUP_bAdminDebug = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				End If
				RSWIN_DESC.SETUP_bSinkerBar = True
				If RSWIN_DESC.SETUP_bSinkerBar Then
					obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("SBGradeRod", 3, 8195))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						RSWIN_DESC.SBGradeRod = Conversions.ToShort(obj)
						RSWIN_DESC.SBRodType = RODUTIL.RodGrade(RSWIN_DESC.SBGradeRod)
					End If
				Else
					obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("SBGradeRod", 3, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						RSWIN_DESC.SBGradeRod = Conversions.ToShort(obj)
						RSWIN_DESC.SBRodType = RODUTIL.RodGrade(RSWIN_DESC.SBGradeRod)
					End If
				End If
				ini.SavePreferenceDataValue("bSinkerBarPreference", Convert.ToString(RSWIN_DESC.SETUP_bSinkerBar))
				guruDataBaseFileName = "bUseNNSinkerbar"
				flag = True
				RSWIN_DESC.bUseNNSinkerbar = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("MaxTubingSizeOD", 4, 3.5))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.MaxTubingSizeOD = Conversions.ToSingle(obj)
					obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("MaxTubingSizeID", 4, 2.992))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						RSWIN_DESC.MaxTubingSizeID = Conversions.ToSingle(obj)
					End If
				End If
				obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("MinTubingSizeOD", 4, 2.875))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.MinTubingSizeOD = Conversions.ToSingle(obj)
					obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("MinTubingSizeID", 4, 2.441))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						RSWIN_DESC.MinTubingSizeID = Conversions.ToSingle(obj)
					End If
				End If
				guruDataBaseFileName = "UseXRODVTubingSizes"
				flag = True
				RSWIN_DESC.SETUP_UseXRODVTubingSizes = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				guruDataBaseFileName = "FixTubingSize"
				flag = False
				RSWIN_DESC.SETUP_FixTubingSize = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				RSWIN_DESC.SETUP_bRodstarTubingAnchored = True
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					RSWIN_DESC.bDesignSinkerbar = True
				End If
				guruDataBaseFileName = "XRODUseCustomizedLists"
				flag = False
				RSWIN_DESC.bXRODUseCustomizedLists = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				guruDataBaseFileName = "XRODUseGeneralList"
				flag = False
				RSWIN_DESC.bXRODUseGeneralList = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				guruDataBaseFileName = "XRODUseClosestUnit"
				flag = False
				RSWIN_DESC.bXRODUseClosestUnit = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				If RSWIN_DESC.bExpert Then
					guruDataBaseFileName = "UseXRODVTubingSizes"
					flag = True
					RSWIN_DESC.SETUP_UseXRODVTubingSizes = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
					guruDataBaseFileName = "FixTubingSize"
					flag = False
					RSWIN_DESC.SETUP_FixTubingSize = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
					guruDataBaseFileName = "MaxCasingSize"
					Dim num As Single = 5.5F
					RSWIN_DESC.MaxCasingSize = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, num))
					guruDataBaseFileName = "MaxTubingSizeOD"
					num = 2.875F
					RSWIN_DESC.MaxTubingSizeOD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, num))
				Else
					RSWIN_DESC.SETUP_UseXRODVTubingSizes = True
					RSWIN_DESC.SETUP_FixTubingSize = False
					RSWIN_DESC.MaxCasingSize = 5.5F
					RSWIN_DESC.MaxTubingSizeOD = 2.875F
				End If
				Dim num2 As Integer = 1
				Do
					Dim index As Integer = num2
					guruDataBaseFileName = "Use_PUManuf_Preference_" + num2.ToString().Trim()
					flag = False
					RSWIN_DESC.set_bUsePUManuf(index, RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag))
					obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("PUManuf_Preference_" + num2.ToString().Trim(), 8, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						If Strings.InStr(Conversions.ToString(obj), "American Conv. (100", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(obj), "American Conv. (less than 100", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(obj), "American (100", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(obj), "American (less than 100", CompareMethod.Binary) > 0 Then
							Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject("*", obj), "*"))
							obj = "American Conventional                   "
							ini.SavePreferenceDataValue("PUManuf_Preference_" + num2.ToString().Trim(), RuntimeHelpers.GetObjectValue(obj))
						End If
						RSWIN_DESC.set_PUManuf(num2, Conversions.ToString(obj))
					Else
						RSWIN_DESC.set_PUManuf(num2, "Lufkin Conventional - New               ")
						If num2 = 1 Then
							RSWIN_DESC.set_bUsePUManuf(num2, True)
						End If
					End If
					num2 += 1
				Loop While num2 <= 8
				guruDataBaseFileName = "bUseAvgRodTBGFricCoeff"
				flag = True
				RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = Conversions.ToSingle(ini.GetPreferenceDataValue("TimesAvgRodTBGFricCoeff", 4, 1.0))
				If RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Then
					RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F
				ElseIf RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F Then
					RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff = True
				Else
					RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff = False
				End If
				RSWIN_DESC.SETUP_ServiceFactorPreference = Conversions.ToSingle(ini.GetPreferenceDataValue("ServiceFactorPreference", 4, 0.9))
				RSWIN_DESC.SETUP_ElectricityCostPreference = Conversions.ToSingle(ini.GetPreferenceDataValue("ElectricityCostPreference", 4, RuntimeHelpers.GetObjectValue(ini.GetDataValue("ElectricityCost", 4, True, 0.06))))
				guruDataBaseFileName = "bInsertPump"
				flag = True
				RSWIN_DESC.bInsertPump = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				guruDataBaseFileName = "bTubingPump"
				flag = False
				RSWIN_DESC.bTubingPump = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				guruDataBaseFileName = "bLargeBorePump"
				flag = False
				RSWIN_DESC.bLargeBorePump = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				RSWIN_DESC.SETUP_bRodstarPumpType = True
				Dim bExpert As Boolean = RSWIN_DESC.bExpert
				guruDataBaseFileName = "bGuru"
				flag = False
				RSWIN_DESC.SETUP_bGuru = (bExpert And RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag))
				If RSWIN_DESC.SETUP_bGuru Then
					Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
					guruDataBaseFileName = RSWIN_DESC.GuruDataBaseFileName
					FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, False, False, False, False)
					RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
				End If
				If RSWIN_DESC.bExpert Then
					If Not RSWIN_DESC.bXRODAdmin Then
						RSWIN_DESC.SETUP_bGuruUseTemplateDatabase = True
					Else
						guruDataBaseFileName = "bXRODUseTemplateDatabase"
						flag = True
						RSWIN_DESC.SETUP_bGuruUseTemplateDatabase = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
					End If
				End If
				obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("PowerMeterType", 3, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.SETUP_PowerMeterType = Conversions.ToShort(obj)
				Else
					RSWIN_DESC.SETUP_PowerMeterType = 1S
				End If
				guruDataBaseFileName = "IncludeMotorSPV"
				flag = False
				RSWIN_DESC.SETUP_IncludeMotorSPV = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
			Catch ex As Exception
			End Try
		End Sub

		Public Function TotalExpertScore(ByRef iGBScore As Integer, ByRef iRLScore As Integer, ByRef iSLScore As Integer, ByRef iSEffScore As Integer, ByRef iBotMinStressScore As Integer, ByRef iMPRLScore As Integer, ByRef fTotalScore As Single, bCheckToAdd As Boolean, ByRef bNoRec As Boolean, ByRef bCheckForFGSteelUnderloading As Boolean, Optional bUseSystemDesignScore As Boolean = False, Optional bCheckSmallerSL As Boolean = False) As String
			' The following expression was wrapped in a checked-statement
			Dim result As String
			Try
				Dim flag As Boolean = True
				iGBScore = 0
				iRLScore = 0
				iSLScore = 0
				iSEffScore = 0
				iBotMinStressScore = 0
				iMPRLScore = 0
				Dim num As Single = 0F
				Dim flag2 As Boolean = False
				Dim text As String = ""
				Dim rptExpertSummary As rptExpertSummary = New rptExpertSummary()
				Dim prefixGuruFiles As RSWIN_DESC.GuruFileDataStructure() = New RSWIN_DESC.GuruFileDataStructure(0) {}
				Dim text2 As String = ""
				Dim text3 As String = ""
				Dim pumanuf As String = ""
				bCheckForFGSteelUnderloading = False
				iGBScore = rptExpertSummary.SetGearboxLoadingScore()
				iRLScore = rptExpertSummary.SetMaxRodLoadingScore(bCheckForFGSteelUnderloading)
				iSLScore = rptExpertSummary.SetStructureLoadingScore(bCheckSmallerSL)
				iSEffScore = rptExpertSummary.SetSYSTEMEFFICIENCYScore()
				iBotMinStressScore = rptExpertSummary.SetBotMinStressScore(flag2, bNoRec)
				iMPRLScore = rptExpertSummary.SetMPRLScore()
				Dim text4 As String
				If bUseSystemDesignScore Then
					text4 = "System Design Score: "
				Else
					text4 = "TOTAL SCORE: "
				End If
				If iGBScore = 0 Or iRLScore = 0 Or iSLScore = 0 Or iSEffScore = 0 Or iMPRLScore = 0 Then
					num = 0.35F
					Dim str As String = text4
					Dim guruDataBaseFileName As String = "###%"
					text = str + Util.Format(num, guruDataBaseFileName) + "  Grade: " + RSWIN.GetScoreGrade(num)
				ElseIf flag2 Then
					num = CSng((CDbl((iGBScore + iRLScore + iSLScore + iSEffScore + iBotMinStressScore + iMPRLScore)) / 100.0 / 6.0))
					Dim str2 As String = text4
					Dim guruDataBaseFileName As String = "###%"
					text = str2 + Util.Format(num, guruDataBaseFileName) + "  Grade: " + RSWIN.GetScoreGrade(num)
				Else
					num = CSng((CDbl((iGBScore + iRLScore + iSLScore + iSEffScore + iMPRLScore)) / 100.0 / 5.0))
					Dim str3 As String = text4
					Dim guruDataBaseFileName As String = "###%"
					text = str3 + Util.Format(num, guruDataBaseFileName) + "  Grade: " + RSWIN.GetScoreGrade(num)
				End If
				fTotalScore = num
				If bCheckToAdd Then
					text2 = RSWIN_DESC.sAI_DBPrefixes(RSWIN_DESC.iCurrentBatchFile - 1)
					Try
						pumanuf = RSWIN_DESC.sBatchGuruPUManufPreferences(RSWIN_DESC.iCurrentBatchFile - 1)
					Catch ex As Exception
					End Try
					Dim text5 As String = RSWIN.getpumpdepth(RSWIN_DESC.rst.PumpDepth)
					Dim text6 As String = RSWIN.gettargetbfpd(RSWIN_DESC.rst.TargetBFPD, RSWIN_DESC.rst.Runtime)
					text3 = text2 + text5 + "-" + text6
					prefixGuruFiles = New RSWIN_DESC.GuruFileDataStructure(0) {}
					Dim num2 As Single
					Dim num3 As Single
					RSWIN_DESC.frmMain.LoadPrefixGuruFiles(text2, prefixGuruFiles, num2, num3)
					If flag And RSWIN_DESC.AIFilePreferences.TimesAvgRodTBGFricCoeff = 1F Then
						If Not GURU_DB.DBFileNameKeyExistsFromArrayUsingPrefix(text3, text3, prefixGuruFiles, pumanuf) Then
							If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug Then
								Dim str4 As String = ">> Adding template "
								Dim str5 As String = text3
								Dim str6 As String = " ,   Score: "
								Dim guruDataBaseFileName As String = "###%"
								Batch.BatchMessage(str4 + str5 + str6 + Util.Format(num, guruDataBaseFileName))
							End If
							RSWIN.AddNewTemplateToDatabase(text3.Trim(), text5, text6, pumanuf, 0)
							If Operators.CompareString(RSWIN_DESC.GuruDataBaseFileName, RSWIN_DESC.sTemplateDBFileName, False) = 0 Then
								Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
								Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
								FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, False, False, False, False)
								RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
							End If
							Dim text7 As String = RSWIN_DESC.GuruDataBaseFileName.ToLower().Replace(".mdb", "_backup.mdb")
							Dim fileInfo As FileInfo = New FileInfo(text7)
							If fileInfo.Exists Then
								fileInfo.Delete()
							End If
							File.Copy(RSWIN_DESC.GuruDataBaseFileName, text7)
						ElseIf num > RSWIN_DESC.fTemplateTotalAIScore Then
							Try
								Dim guruFileDataStructure As RSWIN_DESC.GuruFileDataStructure
								guruFileDataStructure.Initialize()
								GURU_DB.CopyRST2Filedata(guruFileDataStructure, 0S)
								guruFileDataStructure.FileName = text3
								guruFileDataStructure.DateAdded = DateAndTime.Now.[Date]
								If guruFileDataStructure.FluidLevel > guruFileDataStructure.PumpDepth Then
									guruFileDataStructure.FluidLevel = guruFileDataStructure.PumpDepth
								End If
								If guruFileDataStructure.TubingAnchorDepth > guruFileDataStructure.PumpDepth Then
									guruFileDataStructure.TubingAnchorDepth = guruFileDataStructure.PumpDepth
								End If
								Dim filenameNumber As Integer = RSWIN_DESC.frmMain.GetFilenameNumber(text3.Trim(), "", True)
								guruFileDataStructure.Original = RSWIN_DESC.AllGuruFiles(filenameNumber).Original
								If filenameNumber <> -1 Then
									RSWIN_DESC.AllGuruFiles(filenameNumber) = guruFileDataStructure
									GURU_DB.UpdateRow(filenameNumber, guruFileDataStructure.FileName.Trim(), True)
								End If
							Catch ex2 As Exception
							End Try
						End If
					End If
				End If
				result = text
			Catch ex3 As Exception
				result = " "
			End Try
			Return result
		End Function

		Public Function GetMaxRodLoad(ByRef bRodGradeC As Single, ByRef fCStressL As Single) As Single
			Dim num As Short = 4098S
			Dim result As Single
			Try
				If RODUTIL.IsCorod(RSWIN_DESC.HSGradeRod) Then
					Dim hsgradeRod As Short = RSWIN_DESC.HSGradeRod
					If hsgradeRod = 12547S OrElse hsgradeRod = 12549S OrElse hsgradeRod = 12550S OrElse hsgradeRod = 12548S Then
						num = 12545S
					ElseIf hsgradeRod = 12802S OrElse hsgradeRod = 12803S OrElse hsgradeRod = 12805S OrElse hsgradeRod = 12806S OrElse hsgradeRod = 13057S OrElse hsgradeRod = 12808S OrElse hsgradeRod = 12807S Then
						num = 12804S
					End If
				ElseIf RODUTIL.IsProRod(CInt(RSWIN_DESC.HSGradeRod)) <> 0 Then
					num = 24579S
				Else
					num = 4098S
				End If
				Dim num2 As Single = 0F
				fCStressL = 0F
				Dim num3 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num3 To numRods
					If RSWIN_DESC.rst.StressL(i) > num2 Then
						num2 = RSWIN_DESC.rst.StressL(i)
					End If
					If RSWIN_DESC.rst.Sections(i).Grade = 4098S Or RSWIN_DESC.rst.Sections(i).Grade = num Then
						bRodGradeC = -1F
						If RSWIN_DESC.rst.StressL(i) > fCStressL Then
							fCStressL = RSWIN_DESC.rst.StressL(i)
						End If
					End If
				Next
				result = num2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function bIsSB(iGrade As Integer) As Boolean
			Dim result As Boolean = False
			If RODUTIL.IsSinkerBarGrade(iGrade) Then
				result = True
			ElseIf RODUTIL.IsSinkerBar(iGrade) <> 0 Then
				result = True
			ElseIf CUSTOMRG.IsOtherSinkerBar(iGrade) Then
				result = True
			End If
			Return result
		End Function

		Public Function HasFG(ByRef iFG As Integer) As Boolean
			Dim flag As Boolean = False
			Dim result As Boolean
			Try
				iFG = 0
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Then
						flag = True
						iFG = i
					End If
				Next
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function getpumpdepth(pumpdepth As Single) As String
			' The following expression was wrapped in a checked-statement
			Dim result As String
			Try
				Dim num As Integer = CInt(Math.Round(CDbl((pumpdepth Mod 100F))))
				Dim num2 As Single = Conversions.ToSingle(CInt(Math.Round(CDbl((pumpdepth - CSng(num))))).ToString().Trim())
				result = Conversions.ToString(num2)
			Catch ex As Exception
				MessageBox.Show("problem in getpumpdepth")
			End Try
			Return result
		End Function

		Public Function gettargetbfpd(targetbfpd As Single, RunTime As Single) As String
			' The following expression was wrapped in a checked-statement
			Dim result As String
			Try
				If RunTime < 24F Then
					targetbfpd /= RunTime / 24F
				End If
				Dim num As Integer = CInt(Math.Round(CDbl((targetbfpd / 25F))))
				Dim num2 As Single = Conversions.ToSingle((num * 25).ToString().Trim())
				result = Conversions.ToString(num2)
			Catch ex As Exception
				MessageBox.Show("problem in gettargetbfpd")
			End Try
			Return result
		End Function

		Public Sub AddNewTemplateToDatabase(FileName As String, sPumpDepth As String, sTargetBFPD As String, PUManuf As String, iOriginal As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim guruFileDataStructure As RSWIN_DESC.GuruFileDataStructure
				guruFileDataStructure.Initialize()
				GURU_DB.CopyRST2Filedata(guruFileDataStructure, CShort(iOriginal))
				guruFileDataStructure.FileName = FileName
				guruFileDataStructure.DateAdded = DateAndTime.Now.[Date]
				guruFileDataStructure.PumpDepth = Convert.ToSingle(sPumpDepth)
				guruFileDataStructure.TargetBFPD = Convert.ToSingle(sTargetBFPD)
				guruFileDataStructure.Original = CShort(iOriginal)
				If guruFileDataStructure.FluidLevel > guruFileDataStructure.PumpDepth Then
					guruFileDataStructure.FluidLevel = guruFileDataStructure.PumpDepth
				End If
				If guruFileDataStructure.TubingAnchorDepth > guruFileDataStructure.PumpDepth Then
					guruFileDataStructure.TubingAnchorDepth = guruFileDataStructure.PumpDepth
				End If
				Dim filenameNumber As Integer = RSWIN_DESC.frmMain.GetFilenameNumber(guruFileDataStructure.FileName.Trim(), PUManuf, False)
				If filenameNumber = -1 Then
					RSWIN_DESC.iGuruFileCount += 1
					Dim num As Integer = Information.UBound(RSWIN_DESC.AllGuruFiles, 1)
					If num < RSWIN_DESC.iGuruFileCount Then
						RSWIN_DESC.AllGuruFiles = CType(Utils.CopyArray(CType(RSWIN_DESC.AllGuruFiles, Array), New RSWIN_DESC.GuruFileDataStructure(RSWIN_DESC.iGuruFileCount + 1 - 1) {}), RSWIN_DESC.GuruFileDataStructure())
					End If
					RSWIN_DESC.AllGuruFiles(RSWIN_DESC.iGuruFileCount) = guruFileDataStructure
					GURU_DB.DBAddFiledata(guruFileDataStructure, False, True)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetScoreGrade(fScore As Single) As String
			Dim text As String = ""
			Dim result As String
			Try
				Dim flag As Boolean = True
				If flag = CDbl(fScore) > 0.95 Then
					text = RSWIN.sScoreAPlus
				ElseIf flag = (CDbl(fScore) >= 0.92 And CDbl(fScore) <= 0.95) Then
					text = RSWIN.sScoreA
				ElseIf flag = (CDbl(fScore) >= 0.9 And CDbl(fScore) <= 0.92) Then
					text = RSWIN.sScoreAMinus
				ElseIf flag = (CDbl(fScore) >= 0.85 And CDbl(fScore) < 0.9) Then
					text = RSWIN.sScoreBPlus
				ElseIf flag = (CDbl(fScore) >= 0.8 And CDbl(fScore) < 0.85) Then
					text = RSWIN.sScoreB
				ElseIf flag = (CDbl(fScore) >= 0.75 And CDbl(fScore) < 0.8) Then
					text = RSWIN.sScoreBMinus
				ElseIf flag = (CDbl(fScore) >= 0.65 And CDbl(fScore) < 0.75) Then
					text = RSWIN.sScoreC
				ElseIf flag = (CDbl(fScore) >= 0.6 And CDbl(fScore) < 0.65) Then
					text = RSWIN.sScoreD
				ElseIf flag = CDbl(fScore) < 0.6 Then
					text = RSWIN.sScoreF
				End If
				result = text
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub CheckToMoveRegistryKeysToTheta()
			Dim array As String() = New String(4) {}
			Dim array2 As String() = New String(4) {}
			Dim text As String = ""
			array(0) = "RSWIN32"
			array(1) = "RSWINV32"
			array(2) = "XDWIN32"
			array(3) = "RDWIN32"
			array(4) = "XRODV"
			array2(0) = "RODSTAR-D"
			array2(1) = "RODSTAR-V"
			array2(2) = "XDIAG"
			array2(3) = "RODDIAG"
			array2(4) = "XROD-V"
			Dim text2 As String
			If Strings.InStr(RSWIN_DESC.sProgramName, " ADMIN", CompareMethod.Binary) > 0 Then
				text2 = RSWIN_DESC.sProgramName.Replace(" ADMIN", "")
			Else
				text2 = RSWIN_DESC.sProgramName
			End If
			Dim num As Integer = 0
			Dim num2 As Integer
			While Operators.CompareString(array2(num), RSWIN_DESC.SECT_PROGWIN32, False) <> 0
				num += 1
				If num > 4 Then
					IL_CC:
					Dim registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), text2.Trim()), "\")), True)
					If registryKey IsNot Nothing Then
						text = Conversions.ToString(registryKey.GetValue("NewInstall"))
					End If
					Dim text3 As String = "Defaults"
					Dim flag As Boolean = RSWIN.CheckForKey(text3)
					If Operators.CompareString(text, "True", False) = 0 And Not flag Then
						CLIPXML.MoveXMLFile()
						Dim registryKey2 As RegistryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject("Software\", RSWIN_DESC.sOldThetaName)))
						If registryKey2 IsNot Nothing Then
							If Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName))) Is Nothing Then
								Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName)))
								Dim registryKey3 As RegistryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName)))
							End If
							Dim registryKey4 As RegistryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sOldThetaName), "\"), array(num2))))
							If registryKey4 IsNot Nothing Then
								If Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), array2(num2)))) Is Nothing Then
									Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), array2(num2))))
									Dim registryKey5 As RegistryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), array2(num2))))
								End If
								If registryKey4.SubKeyCount > 0 Then
									Dim subKeyNames As String() = registryKey4.GetSubKeyNames()
									If subKeyNames.Length > 0 Then
										Dim num3 As Integer = Information.LBound(subKeyNames, 1)
										Dim num4 As Integer = Information.UBound(subKeyNames, 1)
										For i As Integer = num3 To num4
											Dim registryKey6 As RegistryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sOldThetaName), "\"), array(num2)), "\"), subKeyNames(i))))
											Dim valueNames As String() = registryKey6.GetValueNames()
											Dim registryKey7 As RegistryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), array2(num2)), "\"), subKeyNames(i))), True)
											If registryKey7 Is Nothing Then
												Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), array2(num2)), "\"), subKeyNames(i))))
												registryKey7 = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), array2(num2)), "\"), subKeyNames(i))), True)
											End If
											Dim num5 As Integer = Information.LBound(valueNames, 1)
											Dim num6 As Integer = Information.UBound(valueNames, 1)
											For j As Integer = num5 To num6
												Try
													registryKey7.SetValue(valueNames(j), RuntimeHelpers.GetObjectValue(registryKey6.GetValue(valueNames(j))))
												Catch ex As Exception
												End Try
											Next
										Next
									End If
								End If
							End If
						End If
						Try
							GURU_DB.CheckAddedTemplatesForNewInstall()
						Catch ex2 As Exception
						End Try
						If registryKey IsNot Nothing Then
							registryKey.SetValue("NewInstall", "False")
						End If
						Return
					End If
					Return
				End If
			End While
			num2 = num
			GoTo IL_CC
		End Sub

		Private Sub CheckForRegDefaultCorruption()
			Dim str As String = ""
			Try
				Dim text As String = "Defaults"
				Dim text2 As String = "MotorType"
				Dim text3 As String
				Dim flag As Boolean = ini.CheckForSectionKey(text, text2, text3)
				Dim text4 As String
				If Operators.CompareString(text3.Trim(), "-1", False) = 0 Then
					text2 = "Defaults"
					text = "MotorType"
					text4 = "0"
					Dim num As Integer = RSWIN.WriteRegProfileString(text2, text, text4, RSWIN_DESC.sINIFile)
				End If
				text4 = "Defaults"
				text2 = "PumpType"
				flag = ini.CheckForSectionKey(text4, text2, text3)
				If Operators.CompareString(text3.Trim(), "-1", False) = 0 Then
					text4 = "Defaults"
					text2 = "PumpType"
					text = "0"
					Dim num As Integer = RSWIN.WriteRegProfileString(text4, text2, text, RSWIN_DESC.sINIFile)
				End If
				Try
					text4 = "MaxFGLoading"
					text2 = ".95"
					Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, str, False)
					RSWIN_DESC.SETUP_MaxFGLoading = 0F
					ini.CheckForDecimal(str)
					RSWIN_DESC.SETUP_MaxFGLoading = CSng(Convert.ToDouble(Strings.Left(str, regProfileString)))
					If RSWIN_DESC.SETUP_MaxFGLoading <= 0F Or RSWIN_DESC.SETUP_MaxFGLoading > 1F Then
						RSWIN_DESC.SETUP_MaxFGLoading = 0.95F
					End If
				Catch ex As Exception
				End Try
				Try
					text4 = "MaxSteelLoading"
					text2 = ".95"
					Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text2, str, False)
					RSWIN_DESC.SETUP_MaxSteelLoading = 0F
					ini.CheckForDecimal(str)
					RSWIN_DESC.SETUP_MaxSteelLoading = CSng(Convert.ToDouble(Strings.Left(str, regProfileString)))
					If RSWIN_DESC.SETUP_MaxSteelLoading <= 0F Or RSWIN_DESC.SETUP_MaxSteelLoading > 1F Then
						RSWIN_DESC.SETUP_MaxSteelLoading = 0.95F
					End If
				Catch ex2 As Exception
				End Try
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub GetMeasurementUnit()
			Dim text As String = "General"
			Dim text2 As String = "MeasurementSystem"
			Dim num As Integer = 1
			RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(text, text2, num))
			Try
				Application.DoEvents()
				If RSWIN_DESC.frmMain IsNot Nothing AndAlso Not RSWIN_DESC.frmMain.btnMeasUnit.Visible Then
					RSWIN_DESC.frmMain.btnMeasUnit.Visible = True
				End If
				Select Case RSWIN_DESC.SETUP_MeasurementSystem
					Case 1
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "E"
						End If
					Case 2
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "C"
						End If
					Case 3
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "M"
						End If
					Case Else
						RSWIN_DESC.SETUP_MeasurementSystem = 1
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "E"
						End If
				End Select
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ExportChartToClipboard(ByRef chart1 As Chart)
			Try
				Dim memoryStream As MemoryStream = New MemoryStream()
				chart1.Export(FileFormat.Bitmap, memoryStream)
				memoryStream.Position = 0L
				Dim bitmap As Bitmap = New Bitmap(memoryStream)
				Clipboard.SetDataObject(New DataObject(DataFormats.Bitmap, bitmap), True)
				bitmap.Dispose()
			Catch ex As Exception
			End Try
		End Sub

		Public Function SetPRDiameter(Indx As Integer) As Single
			Dim result As Single
			If Indx = 0 Then
				result = 1F
			ElseIf Indx = 1 Then
				result = 1.125F
			ElseIf Indx = 2 Then
				result = 1.25F
			ElseIf Indx = 3 Then
				result = 1.5F
			Else
				result = 1.5F
			End If
			Return result
		End Function

		Public Function AllNoGuides() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If RSWIN_DESC.rst.Sections(i).Guide <> 0S Then
						flag = True
						Exit For
					End If
				Next
				result = Not flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function AllZeroNumGuides() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If RSWIN_DESC.rst.Sections(i).NumGuides <> 0S Then
						flag = True
						Exit For
					End If
				Next
				result = Not flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function HasGuides(fDepth As Integer, ByRef indx As Integer) As Boolean
			Dim result As Boolean
			Try
				MImpred.GetSectionIndex(CSng(fDepth), indx)
				Dim flag As Boolean = RSWIN_DESC.rst.Sections(indx).Guide <> 0S
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function bHasRelocatedSB(ByRef iSB As Integer) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				If RSWIN_DESC.bRodStarD Then
					iSB = 0
					If Not RSWIN.bIsSB(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) Then
						Dim num As Integer = 1
						Dim num2 As Integer = CInt((RSWIN_DESC.rst.NumRods - 1S))
						For i As Integer = num To num2
							If RSWIN.bIsSB(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Then
								iSB = i
								flag = True
							End If
						Next
					Else
						iSB = CInt(RSWIN_DESC.rst.NumRods)
					End If
				ElseIf RSWIN.bIsSB(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) Then
					iSB = CInt(RSWIN_DESC.rst.NumRods)
				End If
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public sScoreAPlus As String = Util.AssignValueToConstant("RSWIN", "sScoreAPlus", "A+")

		Public sScoreA As String = Util.AssignValueToConstant("RSWIN", "sScoreA", "A")

		Public sScoreAMinus As String = Util.AssignValueToConstant("RSWIN", "sScoreAMinus", "A-")

		Public sScoreBPlus As String = Util.AssignValueToConstant("RSWIN", "sScoreBPlus", "B+")

		Public sScoreB As String = Util.AssignValueToConstant("RSWIN", "sScoreB", "B")

		Public sScoreBMinus As String = Util.AssignValueToConstant("RSWIN", "sScoreBMinus", "B-")

		Public sScoreC As String = Util.AssignValueToConstant("RSWIN", "sScoreC", "C")

		Public sScoreD As String = Util.AssignValueToConstant("RSWIN", "sScoreD", "D")

		Public sScoreF As String = Util.AssignValueToConstant("RSWIN", "sScoreF", "F")

		Private sRunTimeMsg As String = Util.AssignValueToConstant("DoYouWant", "sRunTimeMsg", "Run time for this case is less than 24 hours. Please adjust run time if desired for AI runs.")

		Private Const SECT_WK1FORMATS As String = "RSWK1Formats"

		Private Const WK1ITEMS_LIST As String = "SPREADSHEET-ITEMS"

		Private Const SECT_DATAENTRY As String = "RSW Data"

		Private Const SECT_DEBUGGING As String = "RSWINDebug"

		Private Const SECT_DEFAULTS As String = "Defaults"

		Private Const SECT_GENERAL As String = "General"

		Private Const SECT_XRODV As String = "XRODV"

		Private Const SECT_RODSTAR_V As String = "RSWIN"

		Private Const SECT_RODSTAR_D As String = "RODSTAR-D"

		Private Const SECT_FOLDER_DEFAULTS As String = "FolderDefaults"

		Private actlMenuList As Control()

		Public App As CThetaApp

		Private Commnd As String

		Public gsProcs As String
	End Module
End Namespace
