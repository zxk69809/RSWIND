Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module Batch
		Public Sub BatchAddWorksheetData(bAddLabels As Boolean, ByRef bAddFGlassMessage As Boolean)
			Dim libWrap As LibWrap = New LibWrap()
			Dim flag As Boolean = False
			Dim text As String = " Motor speed variation: not included."
			Dim text2 As String = " Motor speed variation: included."
			Dim truePart As String = "Detent"
			Dim falsePart As String = "Non-detent"
			Try
				If bAddLabels Then
					Dim default_WK1ORDER As String = RSWIN_DESC.DEFAULT_WK1ORDER
					Dim text3 As String = Strings.Space(1024)
					Dim setup_WK1Format As String = RSWIN_DESC.SETUP_WK1Format
					Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_WK1FORMATS, setup_WK1Format, default_WK1ORDER, text3, False)
					RSWIN_DESC.SETUP_WK1Format = setup_WK1Format
					Dim length As Integer = regProfileString
					text3 = Strings.Trim(Strings.Left(text3, length))
					Dim i As Integer = 1
					Dim num As Integer = 0
					Batch.$STATIC$BatchAddWorksheetData$0212102$nItems = Batch.GetItemCount(text3)
					Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order = New Short(Batch.$STATIC$BatchAddWorksheetData$0212102$nItems - 1 + 1 - 1) {}
					Dim num2 As Integer
					Do
						num2 = Strings.InStr(i, text3, ",", CompareMethod.Binary)
						If num2 = 0 Then
							If Versioned.IsNumeric(Strings.Mid(text3, i)) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(num) = Convert.ToInt16(Strings.Mid(text3, i))
							End If
						ElseIf Versioned.IsNumeric(Strings.Mid(text3, i, num2 - i)) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(num) = Convert.ToInt16(Strings.Mid(text3, i, num2 - i))
							num += 1
						End If
						i = num2 + Strings.Len(",")
					Loop While num2 <> 0
					RSWIN_DESC.nMaxRodSections = 0
					Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = 0
					Dim j As Integer = -1
					j += 1
					If RSWIN_DESC.bRodStarD Then
						Dim objExcel As Object = RSWIN_DESC.objExcel
						Dim type As Type = Nothing
						Dim text4 As String = "XLWorkSheetAddString"
						Dim array As Object() = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j, RSWIN_DESC.sProgramNameD + " Predictive Analysis Summary" }
						Dim array2 As Object() = array
						Dim array3 As String() = Nothing
						Dim array4 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel, type, text4, array2, array3, array4, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Integer)))
						End If
						If array5(1) Then
							j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(1)), GetType(Integer)))
						End If
					Else
						Dim objExcel2 As Object = RSWIN_DESC.objExcel
						Dim type2 As Type = Nothing
						Dim text5 As String = "XLWorkSheetAddString"
						Dim array6 As Object() = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j, RSWIN_DESC.sProgramNameV + " Predictive Analysis Summary" }
						Dim array7 As Object() = array6
						Dim array8 As String() = Nothing
						Dim array9 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel2, type2, text5, array7, array8, array9, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(1) Then
							j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
						End If
					End If
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						Dim objExcel3 As Object = RSWIN_DESC.objExcel
						Dim type3 As Type = Nothing
						Dim text6 As String = "XLWorkSheetAddString"
						Dim array6 As Object() = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Company name: " + RSWIN_DESC.rst_save.ACompanyName }
						Dim array10 As Object() = array6
						Dim array11 As String() = Nothing
						Dim array12 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { True, False, False }
						NewLateBinding.LateCall(objExcel3, type3, text6, array10, array11, array12, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						Dim objExcel4 As Object = RSWIN_DESC.objExcel
						Dim type4 As Type = Nothing
						Dim text7 As String = "XLWorkSheetAddString"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Well name: " + RSWIN_DESC.rst_save.WellName }
						Dim array13 As Object() = array6
						Dim array14 As String() = Nothing
						Dim array15 As Type() = Nothing
						array5 = New Boolean() { True, False, False }
						NewLateBinding.LateCall(objExcel4, type4, text7, array13, array14, array15, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						Dim objExcel5 As Object = RSWIN_DESC.objExcel
						Dim type5 As Type = Nothing
						Dim text8 As String = "XLWorkSheetAddString"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Lease:" }
						Dim array16 As Object() = array6
						Dim array17 As String() = Nothing
						Dim array18 As Type() = Nothing
						array5 = New Boolean() { True, False, False }
						NewLateBinding.LateCall(objExcel5, type5, text8, array16, array17, array18, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						Dim objExcel6 As Object = RSWIN_DESC.objExcel
						Dim type6 As Type = Nothing
						Dim text9 As String = "XLWorkSheetAddString"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Date: " + Convert.ToString(DateTime.Now).Trim() }
						Dim array19 As Object() = array6
						Dim array20 As String() = Nothing
						Dim array21 As Type() = Nothing
						array5 = New Boolean() { True, False, False }
						NewLateBinding.LateCall(objExcel6, type6, text9, array19, array20, array21, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel7 As Object = RSWIN_DESC.objExcel
							Dim type7 As Type = Nothing
							Dim text10 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, String.Concat(New String() { "  Pump depth: ", Conversions.ToString(RSWIN_DESC.rst_save.PumpDepth), " (", RSWIN_DESC.ft.ToLower(), "),  Target production: ", Conversions.ToString(RSWIN_DESC.rst_save.TargetBFPD), " (", RSWIN_DESC.bpd.ToLower(), ")" }) }
							Dim array22 As Object() = array6
							Dim array23 As String() = Nothing
							Dim array24 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel7, type7, text10, array22, array23, array24, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							Dim objExcel8 As Object = RSWIN_DESC.objExcel
							Dim type8 As Type = Nothing
							Dim text11 As String = "XLWorkSheetAddString"
							Dim array As Object() = New Object(2) {}
							array(0) = Batch.$STATIC$BatchAddWorksheetData$0212102$iRow
							array(1) = 0
							Dim array25 As Object() = array
							Dim num3 As Integer = 2
							Dim str As String = "  Run time: "
							Dim str2 As String = Conversions.ToString(RSWIN_DESC.rst_save.Runtime)
							Dim str3 As String = " (hrs),  Pump Efficiency: "
							Dim num4 As Single = RSWIN_DESC.rst_save.PumpEfficiency / 100F
							setup_WK1Format = "###%"
							array25(num3) = str + str2 + str3 + Util.Format(num4, setup_WK1Format)
							array6 = array
							Dim array26 As Object() = array6
							Dim array27 As String() = Nothing
							Dim array28 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel8, type8, text11, array26, array27, array28, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
						Else
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel9 As Object = RSWIN_DESC.objExcel
							Dim type9 As Type = Nothing
							Dim text12 As String = "XLWorkSheetAddString"
							Dim array As Object() = New Object(2) {}
							array(0) = Batch.$STATIC$BatchAddWorksheetData$0212102$iRow
							array(1) = 0
							Dim array29 As Object() = array
							Dim num5 As Integer = 2
							Dim array30 As String() = New String(8) {}
							array30(0) = "  Pump depth: "
							Dim array31 As String() = array30
							Dim num6 As Integer = 1

								Dim num7 As Single = RSWIN_DESC.rst_save.PumpDepth * RSWIN_DESC.FT__M
								Dim text13 As String = "#.##"
								array31(num6) = Util.Format(num7, text13)
								array30(2) = " ("
								array30(3) = RSWIN_DESC.m.ToLower()
								array30(4) = "),  Target production: "
								Dim array32 As String() = array30
								Dim num8 As Integer = 5
								Dim num4 As Single = RSWIN_DESC.rst_save.TargetBFPD * RSWIN_DESC.BPD__M3D
								setup_WK1Format = "#.#"
								array32(num8) = Util.Format(num4, setup_WK1Format)
								array30(6) = " ("
								array30(7) = RSWIN_DESC.m3D.ToLower()
								array30(8) = ")"
								array29(num5) = String.Concat(array30)
								array6 = array
								Dim array33 As Object() = array6
								Dim array34 As String() = Nothing
								Dim array35 As Type() = Nothing
								array5 = New Boolean() { True, False, False }
								NewLateBinding.LateCall(objExcel9, type9, text12, array33, array34, array35, array5, True)
								If array5(0) Then
									Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
								End If
								Dim objExcel10 As Object = RSWIN_DESC.objExcel
								Dim type10 As Type = Nothing
								Dim text14 As String = "XLWorkSheetAddString"
								array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Run time: " + Conversions.ToString(RSWIN_DESC.rst_save.Runtime) + " (hrs) " }
								Dim array36 As Object() = array6
								Dim array37 As String() = Nothing
								Dim array38 As Type() = Nothing
								array5 = New Boolean() { True, False, False }
								NewLateBinding.LateCall(objExcel10, type10, text14, array36, array37, array38, array5, True)
								If array5(0) Then
									Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
								End If

						End If
						If RSWIN_DESC.SETUP_bUseSteelRodsOnly And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel11 As Object = RSWIN_DESC.objExcel
							Dim type11 As Type = Nothing
							Dim text15 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Designing for both steel rods and fiberglass with steel on bottom." }
							Dim array39 As Object() = array6
							Dim array40 As String() = Nothing
							Dim array41 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel11, type11, text15, array39, array40, array41, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel12 As Object = RSWIN_DESC.objExcel
							Dim type12 As Type = Nothing
							Dim text16 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Steel rod service factor: " + Conversions.ToString(RSWIN_DESC.AIFilePreferences.ServiceFactorPreference) + "." }
							Dim array42 As Object() = array6
							Dim array43 As String() = Nothing
							Dim array44 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel12, type12, text16, array42, array43, array44, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel13 As Object = RSWIN_DESC.objExcel
							Dim type13 As Type = Nothing
							Dim text17 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Preferred rod type stronger than API grade D: " + RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod) + " " }
							Dim array45 As Object() = array6
							Dim array46 As String() = Nothing
							Dim array47 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel13, type13, text17, array45, array46, array47, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel14 As Object = RSWIN_DESC.objExcel
							Dim type14 As Type = Nothing
							Dim text18 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Preferred fiberglass rod: " + RODUTIL.RodGrade(RSWIN_DESC.FGGradeRod) + " " }
							Dim array48 As Object() = array6
							Dim array49 As String() = Nothing
							Dim array50 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel14, type14, text18, array48, array49, array50, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel15 As Object = RSWIN_DESC.objExcel
							Dim type15 As Type = Nothing
							Dim text19 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Sinker Bars: " + RODUTIL.RodGrade(RSWIN_DESC.SBGradeRod) + " " }
							Dim array51 As Object() = array6
							Dim array52 As String() = Nothing
							Dim array53 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel15, type15, text19, array51, array52, array53, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
						ElseIf RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel16 As Object = RSWIN_DESC.objExcel
							Dim type16 As Type = Nothing
							Dim text20 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Designing for steel rods only (steel rod service factor: " + Conversions.ToString(RSWIN_DESC.AIFilePreferences.ServiceFactorPreference) + ")." }
							Dim array54 As Object() = array6
							Dim array55 As String() = Nothing
							Dim array56 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel16, type16, text20, array54, array55, array56, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel17 As Object = RSWIN_DESC.objExcel
							Dim type17 As Type = Nothing
							Dim text21 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Preferred rod type stronger than API grade D: " + RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod) + " " }
							Dim array57 As Object() = array6
							Dim array58 As String() = Nothing
							Dim array59 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel17, type17, text21, array57, array58, array59, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel18 As Object = RSWIN_DESC.objExcel
							Dim type18 As Type = Nothing
							Dim text22 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Sinker Bars: " + RODUTIL.RodGrade(RSWIN_DESC.SBGradeRod) + " " }
							Dim array60 As Object() = array6
							Dim array61 As String() = Nothing
							Dim array62 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel18, type18, text22, array60, array61, array62, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
						ElseIf RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel19 As Object = RSWIN_DESC.objExcel
							Dim type19 As Type = Nothing
							Dim text23 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Designing for fiberglass with steel on bottom (steel rod service factor: " + Conversions.ToString(RSWIN_DESC.AIFilePreferences.ServiceFactorPreference) + ")." }
							Dim array63 As Object() = array6
							Dim array64 As String() = Nothing
							Dim array65 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel19, type19, text23, array63, array64, array65, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel20 As Object = RSWIN_DESC.objExcel
							Dim type20 As Type = Nothing
							Dim text24 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Preferred rod type stronger than API grade D: " + RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod) + " " }
							Dim array66 As Object() = array6
							Dim array67 As String() = Nothing
							Dim array68 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel20, type20, text24, array66, array67, array68, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel21 As Object = RSWIN_DESC.objExcel
							Dim type21 As Type = Nothing
							Dim text25 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Preferred fiberglass rod: " + RODUTIL.RodGrade(RSWIN_DESC.FGGradeRod) + " " }
							Dim array69 As Object() = array6
							Dim array70 As String() = Nothing
							Dim array71 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel21, type21, text25, array69, array70, array71, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel22 As Object = RSWIN_DESC.objExcel
							Dim type22 As Type = Nothing
							Dim text26 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Sinker Bars: " + RODUTIL.RodGrade(RSWIN_DESC.SBGradeRod) + " " }
							Dim array72 As Object() = array6
							Dim array73 As String() = Nothing
							Dim array74 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel22, type22, text26, array72, array73, array74, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
						End If
						If RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel23 As Object = RSWIN_DESC.objExcel
							Dim type23 As Type = Nothing
							Dim text27 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Using average calculated rod-tubing friction coefficients." }
							Dim array75 As Object() = array6
							Dim array76 As String() = Nothing
							Dim array77 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel23, type23, text27, array75, array76, array77, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
						Else
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel24 As Object = RSWIN_DESC.objExcel
							Dim type24 As Type = Nothing
							Dim text28 As String = "XLWorkSheetAddString"
							Dim array As Object() = New Object(2) {}
							array(0) = Batch.$STATIC$BatchAddWorksheetData$0212102$iRow
							array(1) = 0
							Dim array78 As Object() = array
							Dim num9 As Integer = 2
							Dim str4 As String = "  Using "
							Dim num7 As Single = RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff
							array78(num9) = str4 + num7.ToString().Trim() + " times average calculated rod-tubing friction coefficients."
							array6 = array
							Dim array79 As Object() = array6
							Dim array80 As String() = Nothing
							Dim array81 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel24, type24, text28, array79, array80, array81, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
						End If
						Dim text29 As String
						If RSWIN_DESC.SETUP_IncludeMotorSPV Then
							text29 = text2
						Else
							text29 = text
						End If
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						Dim objExcel25 As Object = RSWIN_DESC.objExcel
						Dim type25 As Type = Nothing
						Dim text30 As String = "XLWorkSheetAddString"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Electricity Cost: " + Conversions.ToString(RSWIN_DESC.AIFilePreferences.ElectricityCostPreference) }
						Dim array82 As Object() = array6
						Dim array83 As String() = Nothing
						Dim array84 As Type() = Nothing
						array5 = New Boolean() { True, False, False }
						NewLateBinding.LateCall(objExcel25, type25, text30, array82, array83, array84, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						Dim objExcel26 As Object = RSWIN_DESC.objExcel
						Dim type26 As Type = Nothing
						Dim text31 As String = "XLWorkSheetAddString"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("  Power meter type: ", Interaction.IIf(RSWIN_DESC.SETUP_PowerMeterType = 1S, truePart, falsePart)), ", "), text29) }
						Dim array85 As Object() = array6
						Dim array86 As String() = Nothing
						Dim array87 As Type() = Nothing
						array5 = New Boolean() { True, False, False }
						NewLateBinding.LateCall(objExcel26, type26, text31, array85, array86, array87, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If Not RSWIN_DESC.SETUP_UseXRODVTubingSizes Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
							Dim objExcel27 As Object = RSWIN_DESC.objExcel
							Dim type27 As Type = Nothing
							Dim text32 As String = "XLWorkSheetAddString"
							array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, String.Concat(New String() { "  Casing Size: ", Conversions.ToString(RSWIN_DESC.MaxCasingSize), RSWIN_DESC.sDblQuote, ",  Tubing Size OD: ", Conversions.ToString(RSWIN_DESC.MaxTubingSizeOD), RSWIN_DESC.sDblQuote, " " }) }
							Dim array88 As Object() = array6
							Dim array89 As String() = Nothing
							Dim array90 As Type() = Nothing
							array5 = New Boolean() { True, False, False }
							NewLateBinding.LateCall(objExcel27, type27, text32, array88, array89, array90, array5, True)
							If array5(0) Then
								Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
							End If
						End If
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						Dim objExcel28 As Object = RSWIN_DESC.objExcel
						Dim type28 As Type = Nothing
						Dim text33 As String = "XLWorkSheetAddString"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "  Polished Rod Diameter: " + Conversions.ToString(RSWIN_DESC.rst.PR_Diameter) }
						Dim array91 As Object() = array6
						Dim array92 As String() = Nothing
						Dim array93 As Type() = Nothing
						array5 = New Boolean() { True, False, False }
						NewLateBinding.LateCall(objExcel28, type28, text33, array91, array92, array93, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
					Else
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						j = -1
						j += 1
						Dim objExcel29 As Object = RSWIN_DESC.objExcel
						Dim type29 As Type = Nothing
						Dim text34 As String = "XLWorkSheetAddString"
						Dim array6 As Object() = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j, "Company:" }
						Dim array94 As Object() = array6
						Dim array95 As String() = Nothing
						Dim array96 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel29, type29, text34, array94, array95, array96, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(1) Then
							j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
						End If
						j += 1
						Dim objExcel30 As Object = RSWIN_DESC.objExcel
						Dim type30 As Type = Nothing
						Dim text35 As String = "XLWorkSheetAddString"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j, "'" + RSWIN_DESC.rst.ACompanyName }
						Dim array97 As Object() = array6
						Dim array98 As String() = Nothing
						Dim array99 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel30, type30, text35, array97, array98, array99, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(1) Then
							j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
						End If
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						j = -1
						j += 1
						Dim objExcel31 As Object = RSWIN_DESC.objExcel
						Dim type31 As Type = Nothing
						Dim text36 As String = "XLWorkSheetAddString"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j, "Lease:" }
						Dim array100 As Object() = array6
						Dim array101 As String() = Nothing
						Dim array102 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel31, type31, text36, array100, array101, array102, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(1) Then
							j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
						End If
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						j = -1
						j += 1
						Dim objExcel32 As Object = RSWIN_DESC.objExcel
						Dim type32 As Type = Nothing
						Dim text37 As String = "XLWorkSheetAddString"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j, "Date:" }
						Dim array103 As Object() = array6
						Dim array104 As String() = Nothing
						Dim array105 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel32, type32, text37, array103, array104, array105, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(1) Then
							j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
						End If
						j += 1
						Dim objExcel33 As Object = RSWIN_DESC.objExcel
						Dim type33 As Type = Nothing
						Dim text38 As String = "XLWorkSheetAddDate"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j, Convert.ToString(DateTime.Now).Trim() }
						Dim array106 As Object() = array6
						Dim array107 As String() = Nothing
						Dim array108 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel33, type33, text38, array106, array107, array108, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(1) Then
							j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
						End If
					End If
					Dim wk1ITEMS_LIST As String = RSWIN_DESC.WK1ITEMS_LIST
					Dim num10 As Short = CShort(Batch.$STATIC$BatchAddWorksheetData$0212102$nWK1Items)
					Dim array109 As String()
					Util.LoadMenu(wk1ITEMS_LIST, num10, array109)
					Batch.$STATIC$BatchAddWorksheetData$0212102$nWK1Items = CInt(num10)
					If Not RSWIN_DESC.bRodStarD Then
						array109 = CType(Utils.CopyArray(CType(array109, Array), New String(Batch.$STATIC$BatchAddWorksheetData$0212102$nWK1Items - 4 + 1 - 1) {}), String())
						Batch.$STATIC$BatchAddWorksheetData$0212102$nWK1Items -= 4
					End If
					Dim array110 As String() = New String(Batch.$STATIC$BatchAddWorksheetData$0212102$nItems - 1 + 1 - 1) {}
					Dim num11 As Integer = 0
					Dim num12 As Integer = Batch.$STATIC$BatchAddWorksheetData$0212102$nItems - 1
					i = num11
					While i <= num12
						If Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(i) >= 0S Then
							array110(i) = Strings.Mid(array109(CInt(Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(i))), Strings.InStr(array109(CInt(Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(i))), "!", CompareMethod.Binary) + 1)
							Debug.WriteLine(array110(i))
							If Operators.CompareString(array110(i), "PRHP", False) = 0 And RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Debug.WriteLine(" ")
								array110(i) = "PRP (kW)"
							ElseIf Operators.CompareString(array110(i), "PRP (kW)", False) = 0 And RSWIN_DESC.SETUP_MeasurementSystem <> 3 Then
								array110(i) = "PRHP"
							End If
						End If
						i += 1
					End While
					array109 = Nothing
					Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
					Dim num13 As Integer
					num10 = CShort(num13)
					Dim num15 As Integer
					Dim num14 As Short = CShort(num15)
					Dim array111 As String(,)
					Batch.MakeColHeaders(array110, array111, num10, num14)
					num15 = CInt(num14)
					num13 = CInt(num10)
					Dim num16 As Integer = 0
					Dim num17 As Integer = num13 - 1
					i = num16
					While i <= num17
						If i = num13 - 1 Then
							NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow + i, 0, "File Name" }, Nothing, Nothing, Nothing, True)
							If RSWIN_DESC.bExpert Then
								NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow + i, 1, "Total Score" }, Nothing, Nothing, Nothing, True)
							End If
						End If
						Dim num18 As Integer = 0
						Dim num19 As Integer = num15 - 1
						j = num18
						While j <= num19
							If Strings.Len(array111(i, j)) > 0 Then
								If RSWIN_DESC.bExpert Then
									Dim objExcel34 As Object = RSWIN_DESC.objExcel
									Dim type34 As Type = Nothing
									Dim text39 As String = "XLWorkSheetAddString"
									Dim array As Object() = New Object(2) {}
									array(0) = Batch.$STATIC$BatchAddWorksheetData$0212102$iRow + i
									array(1) = j + 2
									Dim array112 As Object() = array
									Dim num20 As Integer = 2
									Dim array113 As String(,) = array111
									Dim num21 As Integer = i
									Dim num22 As Integer = num21
									Dim num23 As Integer = j
									array112(num20) = array113(num22, num23)
									Dim array6 As Object() = array
									Dim array114 As Object() = array6
									Dim array115 As String() = Nothing
									Dim array116 As Type() = Nothing
									Dim array5 As Boolean() = New Boolean() { False, False, True }
									NewLateBinding.LateCall(objExcel34, type34, text39, array114, array115, array116, array5, True)
									If array5(2) Then
										array111(num21, num23) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(String)))
									End If
								Else
									Dim objExcel35 As Object = RSWIN_DESC.objExcel
									Dim type35 As Type = Nothing
									Dim text40 As String = "XLWorkSheetAddString"
									Dim array As Object() = New Object(2) {}
									array(0) = Batch.$STATIC$BatchAddWorksheetData$0212102$iRow + i
									array(1) = j + 1
									Dim array117 As Object() = array
									Dim num24 As Integer = 2
									Dim array118 As String(,) = array111
									Dim num23 As Integer = i
									Dim num25 As Integer = num23
									Dim num21 As Integer = j
									array117(num24) = array118(num25, num21)
									Dim array6 As Object() = array
									Dim array119 As Object() = array6
									Dim array120 As String() = Nothing
									Dim array121 As Type() = Nothing
									Dim array5 As Boolean() = New Boolean() { False, False, True }
									NewLateBinding.LateCall(objExcel35, type35, text40, array119, array120, array121, array5, True)
									If array5(2) Then
										array111(num23, num21) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(String)))
									End If
								End If
							End If
							j += 1
						End While
						i += 1
					End While
					Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = Batch.$STATIC$BatchAddWorksheetData$0212102$iRow + num13 - 1
					Batch.$STATIC$BatchAddWorksheetData$0212102$iUnitsRow = Batch.$STATIC$BatchAddWorksheetData$0212102$iRow
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And (RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And RSWIN_DESC.SETUP_bUseSteelRodsOnly) Then
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						Dim objExcel36 As Object = RSWIN_DESC.objExcel
						Dim type36 As Type = Nothing
						Dim text41 As String = "XLWorkSheetAddString"
						Dim array6 As Object() = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "..." }
						Dim array122 As Object() = array6
						Dim array123 As String() = Nothing
						Dim array124 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { True, False, False }
						NewLateBinding.LateCall(objExcel36, type36, text41, array122, array123, array124, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						Dim objExcel37 As Object = RSWIN_DESC.objExcel
						Dim type37 As Type = Nothing
						Dim text42 As String = "XLWorkSheetAddString"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "Steel rods only designs:" }
						Dim array125 As Object() = array6
						Dim array126 As String() = Nothing
						Dim array127 As Type() = Nothing
						array5 = New Boolean() { True, False, False }
						NewLateBinding.LateCall(objExcel37, type37, text42, array125, array126, array127, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
					End If
				Else
					Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
					If Batch.$STATIC$BatchAddWorksheetData$0212102$nWK1Items = 0 Then
						Batch.$STATIC$BatchAddWorksheetData$0212102$nWK1Items = 100
					End If
					Dim array128 As Object()
					Dim array129 As Integer()
					RSWIN.GetSpreadsheetValueList(array128, array129, Batch.$STATIC$BatchAddWorksheetData$0212102$nWK1Items)
					Dim j As Integer = 0
					Dim array5 As Boolean()
					Dim array6 As Object()
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And (RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And RSWIN_DESC.SETUP_bUseSteelRodsOnly) And bAddFGlassMessage Then
						Dim objExcel38 As Object = RSWIN_DESC.objExcel
						Dim type38 As Type = Nothing
						Dim text43 As String = "XLWorkSheetAddString"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "..." }
						Dim array130 As Object() = array6
						Dim array131 As String() = Nothing
						Dim array132 As Type() = Nothing
						array5 = New Boolean() { True, False, False }
						NewLateBinding.LateCall(objExcel38, type38, text43, array130, array131, array132, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						Dim objExcel39 As Object = RSWIN_DESC.objExcel
						Dim type39 As Type = Nothing
						Dim text44 As String = "XLWorkSheetAddString"
						array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, 0, "Fiberglass with steel on bottom designs:" }
						Dim array133 As Object() = array6
						Dim array134 As String() = Nothing
						Dim array135 As Type() = Nothing
						array5 = New Boolean() { True, False, False }
						NewLateBinding.LateCall(objExcel39, type39, text44, array133, array134, array135, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow += 1
						bAddFGlassMessage = False
					End If
					Dim objExcel40 As Object = RSWIN_DESC.objExcel
					Dim type40 As Type = Nothing
					Dim text45 As String = "XLWorkSheetAddString"
					array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j, Strings.UCase(Util.FileName(RSWIN_DESC.Inputfile)) }
					Dim array136 As Object() = array6
					Dim array137 As String() = Nothing
					Dim array138 As Type() = Nothing
					array5 = New Boolean() { True, True, False }
					NewLateBinding.LateCall(objExcel40, type40, text45, array136, array137, array138, array5, True)
					If array5(0) Then
						Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
					End If
					If array5(1) Then
						j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
					End If
					If RSWIN_DESC.bExpert Then
						Dim num26 As Integer = 0
						Dim num27 As Integer = 0
						Dim num28 As Integer = 0
						Dim num29 As Integer = 0
						Dim num30 As Integer = 0
						Dim num31 As Integer = 0
						Dim bCheckToAdd As Boolean = False
						Dim flag2 As Boolean = False
						Dim num32 As Single
						Dim text46 As String = RSWIN.TotalExpertScore(num26, num27, num28, num29, num30, num31, num32, bCheckToAdd, flag, flag2, False, False)
						j += 1
						Dim objExcel41 As Object = RSWIN_DESC.objExcel
						Dim type41 As Type = Nothing
						Dim text47 As String = "XLWorkSheetAddString"
						Dim array As Object() = New Object(2) {}
						array(0) = Batch.$STATIC$BatchAddWorksheetData$0212102$iRow
						array(1) = j
						Dim array139 As Object() = array
						Dim num33 As Integer = 2
						Dim text13 As String = "###%"
						array139(num33) = Util.Format(num32, text13)
						array6 = array
						Dim array140 As Object() = array6
						Dim array141 As String() = Nothing
						Dim array142 As Type() = Nothing
						array5 = New Boolean() { True, True, False }
						NewLateBinding.LateCall(objExcel41, type41, text47, array140, array141, array142, array5, True)
						If array5(0) Then
							Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
						End If
						If array5(1) Then
							j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
						End If
					End If
					Dim num34 As Integer = 0
					Dim num35 As Integer = Batch.$STATIC$BatchAddWorksheetData$0212102$nItems - 1
					Dim num37 As Integer
					For i As Integer = num34 To num35
						If Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(i) <> -1S Then
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(array128(CInt(Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(i))))
							j += 1
							Select Case Information.VarType(RuntimeHelpers.GetObjectValue(objectValue))
								Case VariantType.[Integer]
									Dim objExcel42 As Object = RSWIN_DESC.objExcel
									Dim type42 As Type = Nothing
									Dim text48 As String = "XLWorkSheetAddInteger"
									array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j, RuntimeHelpers.GetObjectValue(objectValue) }
									Dim array143 As Object() = array6
									Dim array144 As String() = Nothing
									Dim array145 As Type() = Nothing
									array5 = New Boolean() { True, True, True }
									NewLateBinding.LateCall(objExcel42, type42, text48, array143, array144, array145, array5, True)
									If array5(0) Then
										Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
									End If
									If array5(1) Then
										j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
									End If
									If array5(2) Then
										objectValue = RuntimeHelpers.GetObjectValue(array6(2))
										GoTo IL_271D
									End If
									GoTo IL_271D
								Case VariantType.[Single], VariantType.[Long]
									Dim objExcel43 As Object = RSWIN_DESC.objExcel
									Dim type43 As Type = Nothing
									Dim text49 As String = "XLWorkSheetAddFloat"
									Dim array As Object() = New Object(3) {}
									array(0) = Batch.$STATIC$BatchAddWorksheetData$0212102$iRow
									array(1) = j
									array(2) = RuntimeHelpers.GetObjectValue(objectValue)
									Dim array146 As Object() = array
									Dim num36 As Integer = 3
									Dim array147 As Integer() = array129
									Dim num23 As Integer = CInt(Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(i))
									array146(num36) = array147(num23)
									array6 = array
									Dim array148 As Object() = array6
									Dim array149 As String() = Nothing
									Dim array150 As Type() = Nothing
									array5 = New Boolean() { True, True, True, True }
									NewLateBinding.LateCall(objExcel43, type43, text49, array148, array149, array150, array5, True)
									If array5(0) Then
										Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
									End If
									If array5(1) Then
										j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
									End If
									If array5(2) Then
										objectValue = RuntimeHelpers.GetObjectValue(array6(2))
									End If
									If array5(3) Then
										array129(num23) = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(3)), GetType(Integer)))
										GoTo IL_271D
									End If
									GoTo IL_271D
								Case VariantType.[Double]
									If Not(Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(i) = 0S Or Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(i) = 18S Or Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(i) = 19S) Then
										Dim objExcel44 As Object = RSWIN_DESC.objExcel
										Dim type44 As Type = Nothing
										Dim text50 As String = "XLWorkSheetAddPercent"
										array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j, RuntimeHelpers.GetObjectValue(objectValue) }
										Dim array151 As Object() = array6
										Dim array152 As String() = Nothing
										Dim array153 As Type() = Nothing
										array5 = New Boolean() { True, True, True }
										NewLateBinding.LateCall(objExcel44, type44, text50, array151, array152, array153, array5, True)
										If array5(0) Then
											Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
										End If
										If array5(1) Then
											j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
										End If
										If array5(2) Then
											objectValue = RuntimeHelpers.GetObjectValue(array6(2))
										End If
										GoTo IL_271D
									End If
									Dim objExcel45 As Object = RSWIN_DESC.objExcel
									Dim type45 As Type = Nothing
									Dim text51 As String = "XLWorkSheetAddPercent"
									array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j, RuntimeHelpers.GetObjectValue(objectValue), 1 }
									Dim array154 As Object() = array6
									Dim array155 As String() = Nothing
									Dim array156 As Type() = Nothing
									array5 = New Boolean() { True, True, True, False }
									NewLateBinding.LateCall(objExcel45, type45, text51, array154, array155, array156, array5, True)
									If array5(0) Then
										Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
									End If
									If array5(1) Then
										j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
									End If
									If array5(2) Then
										objectValue = RuntimeHelpers.GetObjectValue(array6(2))
										GoTo IL_271D
									End If
									GoTo IL_271D
								Case VariantType.[String]
									Dim objExcel46 As Object = RSWIN_DESC.objExcel
									Dim type46 As Type = Nothing
									Dim text52 As String = "XLWorkSheetAddString"
									array6 = New Object() { Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j, RuntimeHelpers.GetObjectValue(objectValue) }
									Dim array157 As Object() = array6
									Dim array158 As String() = Nothing
									Dim array159 As Type() = Nothing
									array5 = New Boolean() { True, True, True }
									NewLateBinding.LateCall(objExcel46, type46, text52, array157, array158, array159, array5, True)
									If array5(0) Then
										Batch.$STATIC$BatchAddWorksheetData$0212102$iRow = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Integer)))
									End If
									If array5(1) Then
										j = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
									End If
									If array5(2) Then
										objectValue = RuntimeHelpers.GetObjectValue(array6(2))
										GoTo IL_271D
									End If
									GoTo IL_271D
							End Select
							If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
								If Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(i) = -1S Then
									num37 = -1
								Else
									RSWIN.GetSpreadsheetValueSpecial(CInt(Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(i)), array129(CInt(Batch.$STATIC$BatchAddWorksheetData$0212102$WK1Order(i))), Batch.$STATIC$BatchAddWorksheetData$0212102$iRow, j)
								End If
							End If
						Else
							num37 = -1
						End If
						IL_271D:
					Next
					If num37 <> 0 Then
						Dim iUnitsRow As Short = CShort(Batch.$STATIC$BatchAddWorksheetData$0212102$iUnitsRow)
						Dim iRow As Short = CShort(Batch.$STATIC$BatchAddWorksheetData$0212102$iRow)
						Dim num14 As Short = CShort(j)
						Batch.ProcessRodStringData(iUnitsRow, iRow, num14)
						j = CInt(num14)
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in BatchAddWorksheetData: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Function GetItemCount(sItem As String) As Integer
			If Strings.InStr(sItem, ",", CompareMethod.Binary) = 0 And sItem.Length > 0 Then
				Return 1
			End If
			Dim num As Integer = 0
			While Strings.InStr(sItem, ",", CompareMethod.Binary) > 0
				Dim num2 As Integer = Strings.InStr(sItem, ",", CompareMethod.Binary)
				If num2 > 0 Then
					num += 1
					sItem = sItem.Substring(num2)
				End If
			End While
			Return num + 1
		End Function

		Public Function BatchCheckDiskSpace(nFiles As Object) As Object
			Return True
		End Function

		Public Function BatchGetNextFileName(ByRef sRSTFile As String) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				If RSWIN_DESC.bRunGuru Then
					Dim text As String = Conversions.ToString(Operators.ConcatenateObject(RSWIN_DESC.SETUP_GURUTEMPDIR, Interaction.IIf(Operators.CompareString(Strings.Right(RSWIN_DESC.SETUP_GURUTEMPDIR, 1), "\", False) = 0, "", "\")))
				Else
					Dim text As String = Conversions.ToString(Operators.ConcatenateObject(RSWIN_DESC.SETUP_RSWINDIR, Interaction.IIf(Operators.CompareString(Strings.Right(RSWIN_DESC.SETUP_RSWINDIR, 1), "\", False) = 0, "", "\")))
				End If
				Dim flag As Boolean = False
				If RSWIN_DESC.miBatchCurFile < RSWIN_DESC.mcBatchFiles Then
					sRSTFile = RSWIN_DESC.mrgBatchFileList(RSWIN_DESC.miBatchCurFile)
					If RSWIN_DESC.gbDemoMode Then
						sRSTFile = Application.StartupPath + "\" + RSWIN_DESC.gsDemoFile
					End If
					RSWIN_DESC.miBatchCurFile += 1
					flag = True
				End If
				result = flag
			Catch ex As Exception
				Dim sMsg As String = "Error in BatchGetNextFileName: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
			Return result
		End Function

		Public Sub PrintAutoBatchLog(sFileName As String)
			Try
				Batch.streamToPrint = New StreamReader(sFileName)
				Try
					Batch.printFont = New Font("Arial", 10F)
					Dim printDocument As PrintDocument = New PrintDocument()
					AddHandler printDocument.PrintPage, AddressOf Batch.pd_PrintPage
					printDocument.Print()
				Finally
					Batch.streamToPrint.Close()
				End Try
			Catch ex As Exception
			End Try
		End Sub

		Private Sub pd_PrintPage(sender As Object, ev As PrintPageEventArgs)
			Dim num As Integer = 0
			Dim x As Single = CSng(ev.MarginBounds.Left)
			Dim num2 As Single = CSng(ev.MarginBounds.Top)
			Dim num3 As Single = CSng(ev.MarginBounds.Height) / Batch.printFont.GetHeight(ev.Graphics)
			Dim text As String = Batch.streamToPrint.ReadLine()
			While CSng(num) < num3 And Operators.CompareString(text, Nothing, False) <> 0
				Dim y As Single = num2 + CSng(num) * Batch.printFont.GetHeight(ev.Graphics)
				ev.Graphics.DrawString(text, Batch.printFont, Brushes.Black, x, y, New StringFormat())
				num += 1
				If CSng(num) < num3 Then
					text = Batch.streamToPrint.ReadLine()
				End If
			End While
			If text IsNot Nothing Then
				ev.HasMorePages = True
			Else
				ev.HasMorePages = False
			End If
		End Sub

		Public Sub BatchPrintMessageList(ByRef asBatchMessageList As String())
			Dim obj As Object = New String(" "c, 75)
			Dim obj2 As Object = New String("-"c, 125)
			Util.BusyCursor()
			Dim num As Short
			If Not RSWIN_DESC.rst.gbAutomatic Then
				RSWIN_DESC.msBatchLogFile = RSWIN.App.Path + "\" + RSWIN_DESC.BATCHLOGNAME
				If FILEUTIL.FileExists(RSWIN_DESC.msBatchLogFile) Then
					Try
						FileSystem.FileClose(New Integer() { CInt(num) })
					Catch ex As Exception
					End Try
					Try
						FileSystem.Kill(RSWIN_DESC.msBatchLogFile)
					Catch ex2 As Exception
					End Try
				End If
				num = FILEIO.OpenTheFile(RSWIN_DESC.msBatchLogFile, 545S, 0S)
			End If
			Try
				Dim num2 As Integer
				If RSWIN_DESC.rst.gbAutomatic Then
					num2 = 0
					FileSystem.Seek(CInt(num), 1L)
					While Not FileSystem.EOF(CInt(num))
						Dim text As String = FileSystem.LineInput(CInt(num))
						num2 += 1
					End While
				Else
					num2 = asBatchMessageList.Length
				End If
				Dim num3 As Integer = 50
				Dim num4 As Integer = num2 / num3
				If num2 Mod num3 <> 0 Then
					num4 += 1
				End If
				obj = Strings.Space(Strings.Len(RuntimeHelpers.GetObjectValue(obj)))
				Dim text2 As String = "BATCH RUN LOG ON " + DateAndTime.Now.ToShortDateString() + " AT " + DateAndTime.Now.ToShortTimeString()
				Dim text3 As String = String.Concat(New String() { VERSION1.ProgramTitle(), " ", Application.ProductVersion, RSWIN_DESC.sForWindows, text2 })
				Dim text4 As String = Conversions.ToString(obj)
				StringType.MidStmtStr(text4, 1, Strings.Len(text3), text3)
				obj = text4
				If RSWIN_DESC.rst.gbAutomatic Then
					FileSystem.Seek(CInt(num), 1L)
				End If
				Dim num5 As Integer = 0
				Batch.nNumberOfLines = 0
				Dim num6 As Integer = 0
				Dim num7 As Integer = num2 - 1
				For i As Integer = num6 To num7
					If i Mod num3 = 0 Then
						num5 += 1
						Dim str As String = "Page "
						Dim obj3 As Object = num5
						Dim str2 As String = Util.Format(obj3)
						num5 = Conversions.ToInteger(obj3)
						Dim str3 As String = "/"
						Dim obj4 As Object = num4
						Dim str4 As String = Util.Format(obj4)
						num4 = Conversions.ToInteger(obj4)
						Dim text5 As String = str + str2 + str3 + str4
						text4 = Conversions.ToString(obj)
						StringType.MidStmtStr(text4, Strings.Len(RuntimeHelpers.GetObjectValue(obj)) - Strings.Len(text5) + 1, Strings.Len(text5), text5)
						obj = text4
						If Not RSWIN_DESC.rst.gbAutomatic Then
							FileSystem.PrintLine(CInt(num), New Object() { RuntimeHelpers.GetObjectValue(obj) })
							FileSystem.PrintLine(CInt(num), New Object() { RuntimeHelpers.GetObjectValue(obj2) })
							Batch.nNumberOfLines += 2
						End If
					End If
					If RSWIN_DESC.rst.gbAutomatic Then
						Dim text As String = FileSystem.LineInput(CInt(num))
					Else
						Dim text As String = asBatchMessageList(i)
						If Operators.CompareString(text, "", False) = 0 Then
							text = "    "
						End If
						Batch.nNumberOfLines += 1
						FileSystem.PrintLine(CInt(num), New Object() { text })
					End If
					If Not RSWIN_DESC.rst.gbAutomatic Then
						Dim text As String = asBatchMessageList(i)
					End If
					If i Mod num3 = 0 Then
						FileSystem.PrintLine(CInt(num), New Object() { "" })
						Batch.nNumberOfLines += 1
					End If
				Next
				If Not RSWIN_DESC.rst.gbAutomatic Then
					FileSystem.FileClose(New Integer() { CInt(num) })
				End If
				Batch.PrintAutoBatchLog(RSWIN_DESC.msBatchLogFile)
			Catch ex3 As Exception
			End Try
			Util.UnbusyCursor()
		End Sub

		Public Sub BatchRunFiles(asFileList As String(), cFiles As Integer, ByRef bRST As Boolean)
			' The following expression was wrapped in a checked-statement
			RSWIN_DESC.mrgBatchFileList = New String(cFiles - 1 + 1 - 1) {}
			bRST = True
			Dim num As Integer = 0
			Dim num2 As Integer = cFiles - 1
			For i As Integer = num To num2
				RSWIN_DESC.mrgBatchFileList(i) = asFileList(i)
				If Strings.InStr(asFileList(i), "rsvx", CompareMethod.Binary) > 0 Or Strings.InStr(asFileList(i), "RSVX", CompareMethod.Binary) > 0 Or Strings.InStr(asFileList(i), "rsdx", CompareMethod.Binary) > 0 Or Strings.InStr(asFileList(i), "RSDX", CompareMethod.Binary) > 0 Then
					bRST = False
				End If
			Next
			RSWIN_DESC.mcBatchFiles = cFiles
			RSWIN_DESC.miBatchCurFile = 0
		End Sub

		Private Function Inc(iVal As Object) As Integer
			iVal = Operators.AddObject(iVal, 1)
			Return Conversions.ToInteger(iVal)
		End Function

		Private Sub MakeColHeaders(ByRef asLabel As String(), ByRef asColHeader As String(,), ByRef nRows As Short, ByRef nCols As Short)
			Try
				nRows = 0S
				nCols = 0S
				Dim num As Short = 0S
				Dim num2 As Short = 0S
				Dim num3 As Short = CShort(Information.UBound(asLabel, 1))
				For num4 As Short = num2 To num3
					' The following expression was wrapped in a checked-statement
					Dim num5 As Short = CShort(Strings.InStr(asLabel(CInt(num4)), "!", CompareMethod.Binary))
					Dim text As String
					If num5 = 0S Then
						text = RSWIN_DESC.sNull
					Else
						num = -1S
						text = Strings.Mid(asLabel(CInt(num4)), CInt(num5))
						asLabel(CInt(num4)) = Strings.Left(asLabel(CInt(num4)), CInt((num5 - 1S)))
					End If
					Dim num6 As Short = 0S
					Do
						Dim num7 As Short = CShort((CInt(num6) + Strings.Len(",")))
						num6 = CShort(Strings.InStr(CInt(num7), asLabel(CInt(num4)), ",", CompareMethod.Binary))
						Dim text2 As String
						If num6 = 0S Then
							text2 = Strings.Mid(asLabel(CInt(num4)), CInt(num7))
						Else
							' The following expression was wrapped in a unchecked-expression
							text2 = Strings.Mid(asLabel(CInt(num4)), CInt(num7), CInt((num6 - num7)))
						End If
						nCols += 1S
						Dim num8 As Short = 0S
						Dim num9 As Short = 0S
						Do
							Dim num10 As Short = CShort((CInt(num9) + Strings.Len("~")))
							num9 = CShort(Strings.InStr(CInt(num10), text2, "~", CompareMethod.Binary))
							num8 += 1S
						Loop While num9 <> 0S
						If num8 > nRows Then
							nRows = num8
						End If
					Loop While num6 <> 0S
					asLabel(CInt(num4)) = asLabel(CInt(num4)) + text
				Next
				Dim num11 As Short
				Dim num12 As Short
				Dim num13 As Short
				Dim num14 As Short
				num11 = nRows - 1S
				If num <> 0S Then
					nRows += 1S
				End If
				asColHeader = New String(CInt((nRows - 1S + 1S)) - 1, CInt((nCols - 1S + 1S)) - 1) {}
				num12 = 0S
				num13 = 0S
				num14 = CShort(Information.UBound(asLabel, 1))
				For num4 As Short = num13 To num14
					' The following expression was wrapped in a checked-statement
					Dim num5 As Short = CShort(Strings.InStr(asLabel(CInt(num4)), "!", CompareMethod.Binary))
					Dim text As String
					If num5 = 0S Then
						text = RSWIN_DESC.sNull
					Else
						text = Strings.Mid(asLabel(CInt(num4)), CInt((num5 + 1S)))
						asLabel(CInt(num4)) = Strings.Left(asLabel(CInt(num4)), CInt((num5 - 1S)))
						num5 = CShort(Strings.InStr(text, ",", CompareMethod.Binary))
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							text = Strings.Left(text, CInt((num5 - 1S)))
						Else
							text = Strings.Mid(text, CInt((num5 + 1S)))
							num5 = CShort(Strings.InStr(text, ",", CompareMethod.Binary))
							If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
								text = Strings.Left(text, CInt((num5 - 1S)))
							Else
								text = Strings.Mid(text, CInt((num5 + 1S)))
							End If
						End If
					End If
					Dim num6 As Short = 0S
					Do
						Dim num7 As Short = CShort((CInt(num6) + Strings.Len(",")))
						num6 = CShort(Strings.InStr(CInt(num7), asLabel(CInt(num4)), ",", CompareMethod.Binary))
						Dim text2 As String
						If num6 = 0S Then
							text2 = Strings.Mid(asLabel(CInt(num4)), CInt(num7))
						Else
							' The following expression was wrapped in a unchecked-expression
							text2 = Strings.Mid(asLabel(CInt(num4)), CInt(num7), CInt((num6 - num7)))
						End If
						Dim num8 As Short = 0S
						Dim num9 As Short = 0S
						Do
							Dim num10 As Short = CShort((CInt(num9) + Strings.Len("~")))
							num9 = CShort(Strings.InStr(CInt(num10), text2, "~", CompareMethod.Binary))
							If num9 = 0S Then
								asColHeader(CInt(num8), CInt(num12)) = Strings.Mid(text2, CInt(num10))
							Else
								' The following expression was wrapped in a unchecked-expression
								asColHeader(CInt(num8), CInt(num12)) = Strings.Mid(text2, CInt(num10), CInt((num9 - num10)))
							End If
							num8 += 1S
						Loop While num9 <> 0S
						If num8 <= num11 Then
							Dim num15 As Short = 0S
							Dim num16 As Short = num8 - 1S

								num5 = num15
								While num5 <= num16
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a unchecked-expression
									asColHeader(CInt((num11 - num5)), CInt(num12)) = asColHeader(CInt((num8 - num5 - 1S)), CInt(num12))
									num5 += 1S
								End While
								Dim num17 As Short = 0S
								Dim num18 As Short = num11 - num8
								num5 = num17
								While num5 <= num18
									asColHeader(CInt(num5), CInt(num12)) = RSWIN_DESC.sNull
									num5 += 1S
								End While

						End If
						If Strings.Len(text) > 0 Then
							asColHeader(CInt((nRows - 1S)), CInt(num12)) = text
						End If
						num12 += 1S
					Loop While num6 <> 0S
				Next
			Catch ex As Exception
				Dim sMsg As String = "Error in MakeColHeaders: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub ProcessRodStringData(iUnitsRow As Short, iRow As Short, ByRef iCol As Short)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num As Short
				Dim numRods As Short
				iCol += 1S
				num = 1S
				numRods = rst.NumRods
				For num2 As Short = num To numRods
					Dim text As String
					If CUSTOMRG.IsOtherSteel(CInt(rst.Sections(CInt(num2)).Grade)) Then
						text = Strings.Trim(rst.Sections(CInt(num2)).RodType)
					Else
						text = RODUTIL.RodGrade(rst.Sections(CInt(num2)).Grade)
						If RODUTIL.IsCorodH(rst.Sections(CInt(num2)).Grade) Then
							If CDbl(rst.Sections(CInt(num2)).Area) < 0.7 Then
								text += " 682"
							Else
								text += " 757"
							End If
						End If
					End If
					If CInt(num2) > RSWIN_DESC.nMaxRodSections Then
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 2S)), CInt((iCol + 0S)), "Section #" + Conversions.ToString(CInt(num2)) }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 1S)), CInt((iCol + 0S)), "Rod Grade" }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 2S)), CInt((iCol + 1S)), "Section #" + Conversions.ToString(CInt(num2)) }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 1S)), CInt((iCol + 1S)), "Diameter" }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 0S)), CInt((iCol + 1S)), RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, "(" + RSWIN_DESC.mm + ")", "(in)")) }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 2S)), CInt((iCol + 2S)), "Section #" + Conversions.ToString(CInt(num2)) }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 1S)), CInt((iCol + 2S)), "Length" }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 0S)), CInt((iCol + 2S)), RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, "(" + RSWIN_DESC.m + ")", "(" + RSWIN_DESC.ft + ")")) }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 2S)), CInt((iCol + 3S)), "Section #" + Conversions.ToString(CInt(num2)) }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 1S)), CInt((iCol + 3S)), "Loading" }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 2S)), CInt((iCol + 4S)), "Section #" + Conversions.ToString(CInt(num2)) }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 1S)), CInt((iCol + 4S)), "Bot.Min.Str" }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 0S)), CInt((iCol + 4S)), RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, "(" + RSWIN_DESC.kPa + ")", "(psi)")) }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 2S)), CInt((iCol + 5S)), "Section #" + Conversions.ToString(CInt(num2)) }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 1S)), CInt((iCol + 5S)), "Top Min.Str" }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 0S)), CInt((iCol + 5S)), RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, "(" + RSWIN_DESC.kPa + ")", "(psi)")) }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 2S)), CInt((iCol + 6S)), "Section #" + Conversions.ToString(CInt(num2)) }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 1S)), CInt((iCol + 6S)), "Top Max.Str" }, Nothing, Nothing, Nothing, True)
						NewLateBinding.LateCall(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetAddString", New Object() { CInt((iUnitsRow - 0S)), CInt((iCol + 6S)), RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, "(" + RSWIN_DESC.kPa + ")", "(psi)")) }, Nothing, Nothing, Nothing, True)
						RSWIN_DESC.nMaxRodSections = CInt(num2)
					End If
					Dim objExcel As Object = RSWIN_DESC.objExcel
					Dim type As Type = Nothing
					Dim text2 As String = "XLWorkSheetAddString"
					Dim array As Object() = New Object() { iRow, CInt((iCol + 0S)), text }
					Dim array2 As Object() = array
					Dim array3 As String() = Nothing
					Dim array4 As Type() = Nothing
					Dim array5 As Boolean() = New Boolean() { True, False, True }
					NewLateBinding.LateCall(objExcel, type, text2, array2, array3, array4, array5, True)
					If array5(0) Then
						iRow = CShort(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Short)))
					End If
					If array5(2) Then
						text = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(2)), GetType(String)))
					End If
					Dim objExcel2 As Object = RSWIN_DESC.objExcel
					Dim type2 As Type = Nothing
					Dim text3 As String = "XLWorkSheetAddFloat"
					Dim array6 As Object() = New Object() { iRow, CInt((iCol + 1S)), CtrlUI.ConvertUnits(rst.Sections(CInt(num2)).Diameter, 2), 3 }
					Dim array7 As Object() = array6
					Dim array8 As String() = Nothing
					Dim array9 As Type() = Nothing
					array5 = New Boolean() { True, False, False, False }
					NewLateBinding.LateCall(objExcel2, type2, text3, array7, array8, array9, array5, True)
					If array5(0) Then
						iRow = CShort(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Short)))
					End If
					Dim objExcel3 As Object = RSWIN_DESC.objExcel
					Dim type3 As Type = Nothing
					Dim text4 As String = "XLWorkSheetAddFloat"
					array6 = New Object() { iRow, CInt((iCol + 2S)), CtrlUI.ConvertUnits(rst.Sections(CInt(num2)).length, 1), 1 }
					Dim array10 As Object() = array6
					Dim array11 As String() = Nothing
					Dim array12 As Type() = Nothing
					array5 = New Boolean() { True, False, False, False }
					NewLateBinding.LateCall(objExcel3, type3, text4, array10, array11, array12, array5, True)
					If array5(0) Then
						iRow = CShort(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Short)))
					End If
					Dim objExcel4 As Object = RSWIN_DESC.objExcel
					Dim type4 As Type = Nothing
					Dim text5 As String = "XLWorkSheetAddPercent"
					array = New Object(3) {}
					array(0) = iRow
					array(1) = CInt((iCol + 3S))
					Dim array13 As Object() = array
					Dim num3 As Integer = 2
					Dim stressL As Single() = rst.StressL
					Dim array14 As Single() = stressL
					Dim num4 As Integer = CInt(num2)
					array13(num3) = array14(num4)
					array(3) = 1
					array6 = array
					Dim array15 As Object() = array6
					Dim array16 As String() = Nothing
					Dim array17 As Type() = Nothing
					array5 = New Boolean() { True, False, True, False }
					NewLateBinding.LateCall(objExcel4, type4, text5, array15, array16, array17, array5, True)
					If array5(0) Then
						iRow = CShort(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Short)))
					End If
					If array5(2) Then
						stressL(num4) = CSng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(2)), GetType(Single)))
					End If
					Dim objExcel5 As Object = RSWIN_DESC.objExcel
					Dim type5 As Type = Nothing
					Dim text6 As String = "XLWorkSheetAddString"
					Dim array18 As Object() = New Object() { iRow, CInt((iCol + 4S)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Nothing, GetType(Util), "Format", New Object() { RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, CtrlUI.ConvertUnits(rst.minStressBot(CInt(num2)), 7), rst.minStressBot(CInt(num2)))), "0" }, Nothing, Nothing, Nothing)) }
					Dim array19 As Object() = array18
					Dim array20 As String() = Nothing
					Dim array21 As Type() = Nothing
					array5 = New Boolean() { True, False, False }
					NewLateBinding.LateCall(objExcel5, type5, text6, array19, array20, array21, array5, True)
					If array5(0) Then
						iRow = CShort(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array18(0)), GetType(Short)))
					End If
					Dim objExcel6 As Object = RSWIN_DESC.objExcel
					Dim type6 As Type = Nothing
					Dim text7 As String = "XLWorkSheetAddString"
					array6 = New Object() { iRow, CInt((iCol + 5S)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Nothing, GetType(Util), "Format", New Object() { RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, CtrlUI.ConvertUnits(rst.minStressTop(CInt(num2)), 7), rst.minStressTop(CInt(num2)))), "0" }, Nothing, Nothing, Nothing)) }
					Dim array22 As Object() = array6
					Dim array23 As String() = Nothing
					Dim array24 As Type() = Nothing
					array5 = New Boolean() { True, False, False }
					NewLateBinding.LateCall(objExcel6, type6, text7, array22, array23, array24, array5, True)
					If array5(0) Then
						iRow = CShort(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Short)))
					End If
					Dim objExcel7 As Object = RSWIN_DESC.objExcel
					Dim type7 As Type = Nothing
					Dim text8 As String = "XLWorkSheetAddString"
					array6 = New Object() { iRow, CInt((iCol + 6S)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Nothing, GetType(Util), "Format", New Object() { RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, CtrlUI.ConvertUnits(rst.maxStressTop(CInt(num2)), 7), rst.maxStressTop(CInt(num2)))), "0" }, Nothing, Nothing, Nothing)) }
					Dim array25 As Object() = array6
					Dim array26 As String() = Nothing
					Dim array27 As Type() = Nothing
					array5 = New Boolean() { True, False, False }
					NewLateBinding.LateCall(objExcel7, type7, text8, array25, array26, array27, array5, True)
					If array5(0) Then
						iRow = CShort(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(Short)))
					End If
					iCol += 7S
				Next
			Catch ex As Exception
				Dim sMsg As String = "Error in ProcessRodStringData: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub BatchPercent(Percent As Object)
			If Not RSWIN_DESC.rst.gbAutomatic Then
				Batch.doc_batchlog.UpdateProgress()
				Batch.doc_batchlog.RefreshPercentComplete()
				Application.DoEvents()
			End If
		End Sub

		Public Sub BatchMessage(sMsg As String)
			Dim flag As Boolean = True
			If Not RSWIN_DESC.rst.gbBatch Then
				Return
			End If
			If RSWIN_DESC.rst.gbAutomatic Then
				If RSWIN_DESC.msBatchLogFile Is Nothing Then
					flag = False
				ElseIf RSWIN_DESC.msBatchLogFile.Length = 0 Then
					flag = False
				End If
			End If
			Dim num As Integer = -1
			Dim flag2 As Boolean = True
			If flag2 <> (sMsg.Length = 0) Then
				If flag2 <> (Operators.CompareString(sMsg.Substring(sMsg.Length - 1, 1), ":", False) <> 0) Then
					Dim flag3 As Boolean = flag2
					Dim text As String = sMsg.Substring(0, sMsg.Length - 1)
					If flag3 <> Not FILEUTIL.FileExists(text) Then
						num = 0
					End If
				End If
			End If
			If Not num <> 0 Then
				If RSWIN_DESC.rst.gbAutomatic AndAlso flag Then
					FileSystem.PrintLine(RSWIN_DESC.mhBatchLog, New Object() { sMsg })
				End If
				Batch.doc_batchlog.AddListItem(sMsg)
				Return
			End If
			Util.ReformText(sMsg, 150)
			Dim num2 As Integer
			Do
				num2 = Strings.InStr(sMsg, "~", CompareMethod.Binary)
				Dim text2 As String
				If num2 = 0 Then
					text2 = sMsg
				Else
					text2 = sMsg.Substring(0, num2 - 1)
					sMsg = Strings.Mid(sMsg, num2 + 1)
				End If
				If RSWIN_DESC.rst.gbAutomatic AndAlso flag Then
					FileSystem.PrintLine(RSWIN_DESC.mhBatchLog, New Object() { text2 })
				End If
				Batch.doc_batchlog.AddListItem(text2)
			Loop While num2 <> 0
		End Sub

		Private Sub batch_PrintPage(sender As Object, ev As PrintPageEventArgs)
			Dim x As Single = CSng(ev.MarginBounds.Left)
			Dim num As Single = CSng(ev.MarginBounds.Top)
			Dim num2 As Single = CSng(ev.MarginBounds.Height) / Batch.printFont.GetHeight(ev.Graphics)
			Dim num3 As Integer = 0
			While CSng(num3) < num2
				Batch.nCurrentLine += 1
				Dim text As String = Batch.BatchMessagesLines(Batch.nCurrentLine)
				If text Is Nothing Then
					Exit While
				End If
				Dim y As Single = num + CSng(num3) * Batch.printFont.GetHeight(ev.Graphics)
				ev.Graphics.DrawString(text, Batch.printFont, Brushes.Black, x, y, New StringFormat())
				num3 += 1
			End While
			If Batch.nCurrentLine <= Batch.nNumberOfLines Then
				ev.HasMorePages = True
				Return
			End If
			ev.HasMorePages = False
		End Sub

		Private BatchMessagesLines As String()

		Private nNumberOfLines As Integer

		Private nCurrentLine As Integer

		Private printFont As Font

		Private streamToPrint As StreamReader

		Public doc_batchlog As BatchLog

		Private $STATIC$BatchAddWorksheetData$0212102$WK1Order As Short()

		Private $STATIC$BatchAddWorksheetData$0212102$iRow As Integer

		Private $STATIC$BatchAddWorksheetData$0212102$iUnitsRow As Integer

		Private $STATIC$BatchAddWorksheetData$0212102$nItems As Integer

		Private $STATIC$BatchAddWorksheetData$0212102$nWK1Items As Integer

		Public Structure BatchLogEntry
			Public Sub Initialize()
				Me.sComment = New String(20) {}
				Me.iCount = 0
			End Sub

			Public sFileName As String

			Public Score As Single

			Public sComment As String()

			Public iCount As Integer
		End Structure
	End Module
End Namespace
