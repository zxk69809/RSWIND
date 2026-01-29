Imports System
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module RESULTS1
		Public Sub ShowHeader(First As Object)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim text As String = Util.FileName(rst.Inputfile)
			Dim num As Short = CShort((Strings.Len(text) + 11))
			Dim num2 As Short = CShort((Strings.Len(Strings.Trim(rst.UserDate)) + 6))
			Dim num3 As Short
			If num > num2 Then
				num3 = 75S - num
			Else
				num3 = 75S - num2
			End If
			Dim tabStop As Object = 1
			Dim text2 As String = "Company: " + Strings.Left(Strings.Trim(rst.ACompanyName), CInt((num3 - 12S)))
			RESULTS1.MkLine(tabStop, text2, False)
			Dim tabStop2 As Object = num3
			text2 = "User: " + Strings.Left(Strings.Trim(rst.UserName), CInt((75S - num3 - 6S)))
			RESULTS1.MkLine(tabStop2, text2, True)
			Dim tabStop3 As Object = 1
			text2 = "Well: " + Strings.Trim(rst.WellName)
			RESULTS1.MkLine(tabStop3, text2, False)
			Dim tabStop4 As Object = num3
			text2 = "Disk file: " + text
			RESULTS1.MkLine(tabStop4, text2, True)
			Dim tabStop5 As Object = 1
			text2 = "Comment: " + Strings.Left(Strings.Trim(rst.FileComment), CInt((num3 - 12S)))
			RESULTS1.MkLine(tabStop5, text2, False)
			Dim tabStop6 As Object = num3
			text2 = "Date: " + Strings.Trim(rst.UserDate)
			RESULTS1.MkLine(tabStop6, text2, True)
			If Conversions.ToBoolean(First) Then
				Dim tabStop7 As Object = 1
				text2 = New String(ChrW(3), 36)
				RESULTS1.MkLine(tabStop7, text2, False)
				Dim tabStop8 As Object = 0
				text2 = ChrW(2)
				RESULTS1.MkLine(tabStop8, text2, False)
				Dim tabStop9 As Object = 0
				text2 = New String(ChrW(3), 38)
				RESULTS1.MkLine(tabStop9, text2, True)
			Else
				Dim tabStop10 As Object = 0
				text2 = New String(ChrW(3), 75)
				RESULTS1.MkLine(tabStop10, text2, True)
			End If
		End Sub

		Public Sub ShowIPRData()
			Dim tabStop As Object = 1
			Dim text As String = "INFLOW PERFORMANCE RELATIONSHIP INFORMATION"
			RESULTS1.MkLine(tabStop, text, True)
			Dim tabStop2 As Object = 1
			text = New String(ChrW(3), 75)
			RESULTS1.MkLine(tabStop2, text, True)
			Dim text2 As String = "Correlation: "
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim fetkovichN As Single
			Select Case rst.giIPRMethod
				Case 0S
					Dim str As String = text2
					Dim str2 As String = "Fetkovich (N="
					Dim cRODSTAR As cRODSTAR = rst
					fetkovichN = cRODSTAR.FetkovichN
					text = "0.000"
					Dim str3 As String = Util.Format(fetkovichN, text)
					cRODSTAR.FetkovichN = fetkovichN
					text2 = str + str2 + str3 + ")"
				Case 1S
					text2 += "Vogel"
				Case Else
					text2 += "Unknown"
			End Select
			RESULTS1.MkLine(1, text2, False)
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				text2 = "psi"
			Else
				text2 = RSWIN_DESC.kPa
			End If
			Dim tabStop3 As Object = 42
			Dim str4 As String = "Static b.h. pressure ("
			Dim str5 As String = text2
			Dim str6 As String = "): "
			fetkovichN = CtrlUI.ConvertUnits(rst.StaticBHPressure, 7)
			text = "0"
			Dim text3 As String = str4 + str5 + str6 + Util.Format(fetkovichN, text)
			RESULTS1.MkLine(tabStop3, text3, True)
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				text2 = "ft"
			Else
				text2 = "m"
			End If
			Dim tabStop4 As Object = 1
			Dim str7 As String = "Mid-perf depth ("
			Dim str8 As String = text2
			Dim str9 As String = "): "
			fetkovichN = CtrlUI.ConvertUnits(rst.MidPerfDepth, 1)
			text3 = "0"
			text = str7 + str8 + str9 + Util.Format(fetkovichN, text3)
			RESULTS1.MkLine(tabStop4, text, False)
			If rst.gbProducingBelowBPP Then
				Dim tabStop5 As Object = 34
				text3 = "Well is producing below the bubble point"
				RESULTS1.MkLine(tabStop5, text3, True)
			Else
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					text2 = "psi"
				Else
					text2 = RSWIN_DESC.kPa
				End If
				Dim tabStop6 As Object = 41
				Dim str10 As String = "Bubble point pressure ("
				Dim str11 As String = text2
				Dim str12 As String = "): "
				fetkovichN = CtrlUI.ConvertUnits(rst.BubblePoint, 7)
				text3 = "0"
				text = str10 + str11 + str12 + Util.Format(fetkovichN, text3)
				RESULTS1.MkLine(tabStop6, text, True)
			End If
			IPR.iprSetup()
			Dim num As Single = CSng((CDbl(rst.CasingPressure) + 14.7))
			Dim num2 As Single = rst.StaticBHPressure
			Dim num3 As Short
			Dim num4 As Single
			Dim num5 As Short
			If rst.PumpIntakePressure - num <= 10F Then
				num3 = 1S
				num4 = 1F
			Else
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					num *= RSWIN_DESC.PSI__KPA
					num2 *= RSWIN_DESC.PSI__KPA
				End If
				num = CSng((Conversion.Int(CDbl((num / 10F)) + 0.5) * 10.0))
				num2 = Conversion.Int(num2 / 10F) * 10F
				If num2 - num < 80F Then
					num4 = 10F
					num3 = CShort(Math.Round(CDbl(Conversion.Int(num2 - num / num4))))
				Else
					num3 = 0S
					num5 = 1S
					Dim num6 As Single
					Dim num7 As Single
					While True
						num4 = Conversions.ToSingle(Operators.MultiplyObject(num5, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 25, 100)))
						num6 = CSng((Conversion.Int(CDbl((num / num4)) + 0.5) * CDbl(num4)))
						num7 = Conversion.Int(CtrlUI.ConvertUnits(rst.PumpIntakePressure, 7) / num4) * num4
						If Conversion.Int((num7 - num6) / num4) <= 8F Then
							Exit For
						End If
						num5 += 1S
						If num5 > 4S Then
							GoTo IL_364
						End If
					End While
					num2 = num7
					num = num6
					IL_364:
					If num3 = 0S Then
						num2 = 7F * num4 + num
					End If
					num3 = CShort(Math.Round(CDbl((Conversion.Int((num2 - num) / num4) + 1F))))
				End If
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					num /= RSWIN_DESC.PSI__KPA
					num2 /= RSWIN_DESC.PSI__KPA
					num4 /= RSWIN_DESC.PSI__KPA
				End If
			End If
			Dim array As Single()
			Dim array2 As Single()
			Dim array3 As Single()
			Dim array4 As Single()
			Dim array5 As Single()
			Dim num8 As Short
			Dim num9 As Short
			array = New Single(CInt((num3 + 1S)) - 1) {}
			array2 = New Single(CInt((num3 + 1S)) - 1) {}
			array3 = New Single(CInt((num3 + 1S)) - 1) {}
			array4 = New Single(CInt((num3 + 1S)) - 1) {}
			array5 = New Single(CInt((num3 + 1S)) - 1) {}
			num8 = 1S
			num9 = num3
			num5 = num8
			While num5 <= num9
				array3(CInt(num5)) = num + CSng((num3 - num5)) * num4
				array4(CInt(num5)) = IPR.iprPwfFromPip(array3(CInt(num5)))
				array2(CInt(num5)) = IPR.iprProductionFromPwf(array4(CInt(num5)))
				array5(CInt(num5)) = (rst.StaticBHPressure - array4(CInt(num5))) * rst.WaterPI
				array(CInt(num5)) = array2(CInt(num5)) + array5(CInt(num5))
				num5 += 1S
			End While
			Dim text4 As String = "Pressure test points:   Pressure vs. production:"
			Dim text5 As String = " Flowing b.h.|Fl.Prod.   Pump intake|Flowing b.h.|  Oil  | Water | Fluid"
			Dim text6 As String = " press. (psi)| (BFPD)    press.(psi)|press. (psi)| (BOPD)| (BWPD)| (BFPD)"
			Dim text7 As String = " ------------+--------  ------------+------------+-------+-------+-------"
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				StringType.MidStmtStr(text6, 10, 3, RSWIN_DESC.kPa)
				StringType.MidStmtStr(text6, 15, 5, "(" + RSWIN_DESC.m3D)
				StringType.MidStmtStr(text6, 33, 3, RSWIN_DESC.kPa)
				StringType.MidStmtStr(text6, 46, 3, RSWIN_DESC.kPa)
				StringType.MidStmtStr(text6, 51, 5, "(" + RSWIN_DESC.m3D)
				StringType.MidStmtStr(text6, 59, 5, "(" + RSWIN_DESC.m3D)
				StringType.MidStmtStr(text6, 67, 5, "(" + RSWIN_DESC.m3D)
			End If
			RESULTS1.Trx(text4, "-", ChrW(3))
			RESULTS1.Trx(text4, "|", ChrW(1))
			RESULTS1.Trx(text5, "|", ChrW(1))
			RESULTS1.Trx(text6, "|", ChrW(1))
			RESULTS1.Trx(text7, "|", ChrW(1))
			RESULTS1.Trx(text7, "-", ChrW(3))
			RESULTS1.Trx(text7, "+", ChrW(4))
			Dim tabStop7 As Object = 0
			text3 = ""
			RESULTS1.MkLine(tabStop7, text3, True)
			RESULTS1.MkLine(1, text4, True)
			RESULTS1.MkLine(1, text5, True)
			RESULTS1.MkLine(1, text6, True)
			RESULTS1.MkLine(1, text7, True)
			num5 = 1S
			Do
				If num5 <= rst.gnTestPoints Then
					text2 = Util.RFormat(CtrlUI.ConvertUnits(rst.TestPoints(CInt(num5)).Pwf, 7), "###0.0") + "   |" + Util.RFormat(CtrlUI.ConvertUnits(rst.TestPoints(CInt(num5)).Production, 0), "###0.00")
					RESULTS1.Trx(text2, "|", ChrW(1))
					RESULTS1.MkLine(5, text2, False)
				End If
				If num5 <= num3 Then
					text2 = String.Concat(New String() { Util.RFormat(CtrlUI.ConvertUnits(array3(CInt(num5)), 7), "###0.0"), "   |   ", Util.RFormat(CtrlUI.ConvertUnits(array4(CInt(num5)), 7), "###0.0"), "   |", Util.RFormat(CtrlUI.ConvertUnits(array2(CInt(num5)), 0), "###0.00"), "|", Util.RFormat(CtrlUI.ConvertUnits(array5(CInt(num5)), 0), "###0.00"), "|", Util.RFormat(CtrlUI.ConvertUnits(array(CInt(num5)), 0), "###0.00") })
					RESULTS1.Trx(text2, "|", ChrW(1))
					RESULTS1.MkLine(28, text2, False)
				End If
				Dim tabStop8 As Object = 0
				text3 = ""
				RESULTS1.MkLine(tabStop8, text3, True)
				num5 += 1S
			Loop While Not(num5 > rst.gnTestPoints And num5 > num3)
		End Sub

		Public Sub ShowPumpingUnit()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim str As String
			Select Case rst.PU.CrankRotation
				Case -1S
					str = "CCW"
				Case 1S
					str = "CW"
			End Select
			Dim str2 As String
			If rst.IrotEntered <> 0S Then
				str2 = ""
			Else
				str2 = " (est.)"
			End If
			Dim tabStop As Object = 1
			Dim text As String = "PUMPING UNIT: " + Strings.Trim(rst.PU.Manuf)
			RESULTS1.MkLine(tabStop, text, True)
			If Strings.Len(RESULTS1.VTrim(rst.PU.UnitName)) > 0 Then
				Dim tabStop2 As Object = 1
				text = "   Unit name: " + RESULTS1.VTrim(rst.PU.UnitName)
				RESULTS1.MkLine(tabStop2, text, True)
			End If
			If Strings.Len(RESULTS1.VTrim(rst.PU.OtherInfo)) > 0 Then
				Dim tabStop3 As Object = 1
				text = "  Other info: " + RESULTS1.VTrim(rst.PU.OtherInfo)
				RESULTS1.MkLine(tabStop3, text, True)
			End If
			Dim tabStop4 As Object = 1
			text = New String(ChrW(3), 36)
			RESULTS1.MkLine(tabStop4, text, False)
			Dim tabStop5 As Object = 0
			text = ChrW(2)
			RESULTS1.MkLine(tabStop5, text, False)
			Dim tabStop6 As Object = 0
			text = New String(ChrW(3), 38)
			RESULTS1.MkLine(tabStop6, text, True)
			Dim text2 As String
			If rst.IDEntered <> 0S Then
				text2 = " Unit ID: " + Strings.Trim(rst.UnitID)
			Else
				text2 = ""
			End If
			If RSWIN_DESC.rst.PU.UnitType = 10S Then
				text = "Unit size: " + RESULTS1.VTrim(rst.PU.APIDesignation)
				RESULTS1.MkLine2(text, text2)
			Else
				text = "API size: " + RESULTS1.VTrim(rst.PU.APIDesignation)
				RESULTS1.MkLine2(text, text2)
			End If
			If rst.IDEntered <> 0S Then
				text2 = String.Concat(New String() { " Crank hole #", Conversion.Str(rst.PU.CrankHole), " (out of", Conversion.Str(rst.PU.CrankHoles), ")" })
			Else
				text2 = ""
			End If
			Dim str3 As String = "Calc. stroke length"
			Dim kinematicStroke As Single = rst.PU.KinematicStroke
			Dim in__CM As Single = RSWIN_DESC.IN__CM
			text = "in"
			Dim text3 As String = "0.0"
			Dim text4 As String = "0.0"
			Dim text5 As String = str3 + RESULTS1.MkVal(kinematicStroke, in__CM, text, text3, RSWIN_DESC.cm, text4, 1)
			RESULTS1.MkLine2(text5, text2)
			If RODUTIL.IsCrankBalanced(rst.PU.UnitType) Then
				Dim str4 As String = "Structural unbalance"
				Dim unbalance As Single = rst.PU.Unbalance
				Dim lb__N As Single = RSWIN_DESC.LB__N
				text5 = "0"
				text4 = "0"
				text = str4 + RESULTS1.MkVal(unbalance, lb__N, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text4, 1)
				Dim str5 As String = " Crank offset angle (deg): "
				Dim num As Double = CDbl((rst.PU.CrankOffset * 180F)) / 3.141592653589793
				text3 = "0.0"
				Dim text6 As String = str5 + Util.Format(num, text3)
				RESULTS1.MkLine2(text, text6)
			End If
			Dim sNull As String
			If Not rst.IDEntered <> 0S Then
				Dim tabStop7 As Object = 1
				Dim text6 As String = ""
				RESULTS1.MkLine(tabStop7, text6, False)
				If rst.PU.UnitType <> 7S And rst.PU.UnitType <> 10S Then
					Dim text7 As String
					Dim text8 As String
					Dim text9 As String
					Dim text10 As String
					Dim text11 As String
					Dim text12 As String
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						Dim num2 As Single = rst.PU.R * RSWIN_DESC.IN__CM
						text6 = "0.0"
						text7 = Util.Format(num2, text6)
						num2 = rst.PU.A * RSWIN_DESC.IN__CM
						text6 = "0.0"
						text8 = Util.Format(num2, text6)
						num2 = rst.PU.C * RSWIN_DESC.IN__CM
						text6 = "0.0"
						text9 = Util.Format(num2, text6)
						num2 = rst.PU.I * RSWIN_DESC.IN__CM
						text6 = "0.0"
						text10 = Util.Format(num2, text6)
						num2 = rst.PU.K * RSWIN_DESC.IN__CM
						text6 = "0.0"
						text11 = Util.Format(num2, text6)
						num2 = rst.PU.P * RSWIN_DESC.IN__CM
						text6 = "0.0"
						text12 = Util.Format(num2, text6)
					Else
						Dim num2 As Single = rst.PU.R
						text6 = "0.0"
						text7 = Util.Format(num2, text6)
						num2 = rst.PU.A
						text6 = "0.0"
						text8 = Util.Format(num2, text6)
						num2 = rst.PU.C
						text6 = "0.0"
						text9 = Util.Format(num2, text6)
						num2 = rst.PU.I
						text6 = "0.0"
						text10 = Util.Format(num2, text6)
						num2 = rst.PU.K
						text6 = "0.0"
						text11 = Util.Format(num2, text6)
						num2 = rst.PU.P
						text6 = "0.0"
						text12 = Util.Format(num2, text6)
					End If
					text6 = String.Concat(New String() { "R: ", text7, ",  A: ", text8, ",  C: ", text9 })
					text5 = String.Concat(New String() { " I: ", text10, ",  K: ", text11, ",  P: ", text12 })
					RESULTS1.MkLine2(text6, text5)
				Else
					Dim str6 As String = "Sprocket radius"
					Dim sprocketRadius As Single = rst.PU.SprocketRadius
					Dim in__CM2 As Single = RSWIN_DESC.IN__CM
					text6 = "in"
					text5 = "0.####"
					text4 = "0.####"
					text = str6 + RESULTS1.MkVal(sprocketRadius, in__CM2, text6, text5, RSWIN_DESC.cm, text4, 1)
					Dim str7 As String = " Drum diameter ratio: "
					Dim num2 As Single = rst.PU.DrumDiamRatio
					text3 = "0.####"
					sNull = str7 + Util.Format(num2, text3)
					RESULTS1.MkLine2(text, sNull)
					If rst.PU.P > 0F Then
						Dim str8 As String = " Pitman length"
						Dim p As Single = rst.PU.P
						Dim in__CM3 As Single = RSWIN_DESC.IN__CM
						sNull = "in"
						text6 = "0.####"
						text5 = "0.####"
						text2 = str8 + RESULTS1.MkVal(p, in__CM3, sNull, text6, RSWIN_DESC.cm, text5, 1)
					Else
						text2 = " (no Pitman arm)"
					End If
					Dim str9 As String = "Sprocket dist."
					Dim sprocketDistance As Single = rst.PU.SprocketDistance
					Dim in__CM4 As Single = RSWIN_DESC.IN__CM
					sNull = "in"
					text6 = "0.####"
					text5 = "0.####"
					text4 = str9 + RESULTS1.MkVal(sprocketDistance, in__CM4, sNull, text6, RSWIN_DESC.cm, text5, 1)
					RESULTS1.MkLine2(text4, text2)
				End If
			End If
			Dim str10 As String = ": Unknown"
			Select Case rst.PU.UnitType
				Case 6S
					If Not rst.UnknownM Then
						Dim v As Single = rst.get_M(2)
						Dim psi__KPA As Single = RSWIN_DESC.PSI__KPA
						sNull = "psig"
						Dim text6 As String = "0"
						text5 = "0"
						str10 = RESULTS1.MkVal(v, psi__KPA, sNull, text6, RSWIN_DESC.kPa, text5, 1)
					End If
					str10 = " Air tank press." + str10
					GoTo IL_8DB
				Case 7S, 10S
					If Not rst.UnknownM Then
						Dim v2 As Single = rst.get_M(2) / 1000F
						Dim etoM As Single = 1000F * RSWIN_DESC.LB__N
						sNull = "M lbs"
						Dim text6 As String = "0"
						text5 = "0"
						str10 = RESULTS1.MkVal(v2, etoM, sNull, text6, RSWIN_DESC.N, text5, 1)
					End If
					str10 = " CB weight" + str10
					GoTo IL_8DB
			End Select
			If Not rst.UnknownM Then
				Dim v3 As Single = rst.get_M(2) / 1000F
				Dim minlb__NM As Single = RSWIN_DESC.MINLB__NM
				sNull = "0"
				Dim text6 As String = "0"
				str10 = RESULTS1.MkVal(v3, minlb__NM, RSWIN_DESC.Minlbs, sNull, RSWIN_DESC.Nm, text6, 1)
			End If
			str10 = " Maximum CB moment" + str10
			IL_8DB:
			sNull = "Rotation with well to right: " + str
			RESULTS1.MkLine2(sNull, str10)
			If Strings.Len(rst.CBDataFile) > 0 Then
				If Strings.InStr(rst.CBDataFile.ToLower(), ".xblx", CompareMethod.Binary) > 0 Then
					sNull = RSWIN_DESC.sNull
					Dim text6 As String = "  (XBAL file: """ + Util.FileName(rst.CBDataFile) + """)"
					RESULTS1.MkLine2(sNull, text6)
					RSWIN_DESC.sNull = sNull
				Else
					sNull = RSWIN_DESC.sNull
					Dim text6 As String = "  (CBALANCE file: """ + Util.FileName(rst.CBDataFile) + """)"
					RESULTS1.MkLine2(sNull, text6)
					RSWIN_DESC.sNull = sNull
				End If
			End If
			If rst.MotorSPV > 0F Then
				Dim text7 As String
				Dim text8 As String
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					Dim str11 As String = "(kg-m²): "
					Dim num2 As Single = rst.Irot * RSWIN_DESC.LBFT2__KGM2
					sNull = "0"
					text7 = str11 + Util.Format(num2, sNull)
					Dim str12 As String = "(kg-m²): "
					num2 = rst.Iart * RSWIN_DESC.LBFT2__KGM2
					sNull = "0"
					text8 = str12 + Util.Format(num2, sNull)
				Else
					Dim str13 As String = "(lb-ft²): "
					Dim cRODSTAR As cRODSTAR = rst
					Dim num2 As Single = cRODSTAR.Irot
					sNull = "0"
					Dim str14 As String = Util.Format(num2, sNull)
					cRODSTAR.Irot = num2
					text7 = str13 + str14
					Dim str15 As String = "(lb-ft²): "
					cRODSTAR = rst
					num2 = cRODSTAR.Iart
					sNull = "0"
					Dim str16 As String = Util.Format(num2, sNull)
					cRODSTAR.Iart = num2
					text8 = str15 + str16
				End If
				sNull = "Rot.inert. " + text7 + str2
				Dim text6 As String = " Art. inertia " + text8
				RESULTS1.MkLine2(sNull, text6)
			End If
		End Sub

		Public Sub ShowRodString()
			Dim flag As Boolean = True
			RESULTS1.nNonAPICustomRG = 0S
			RESULTS1.aiStressMethods = New Short(0) {}
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			Dim num As Short = 1S
			Dim numRods As Short = cRODSTAR.NumRods
			For num2 As Short = num To numRods
				If Not RODUTIL.IsCorod(cRODSTAR.Sections(CInt(num2)).Grade) Then
					flag = False
				End If
				If CUSTOMRG.IsOtherSteel(CInt(cRODSTAR.Sections(CInt(num2)).Grade)) And cRODSTAR.Sections(CInt(num2)).StressMethod <> 0S Then
					Dim num3 As Short = 0S
					Dim num4 As Short = RESULTS1.nNonAPICustomRG - 1S
					Dim num5 As Short = num3
					While num5 <= num4 AndAlso cRODSTAR.Sections(CInt(num2)).StressMethod <> RESULTS1.aiStressMethods(CInt(num5))
						num5 += 1S
					End While
					If num5 >= RESULTS1.nNonAPICustomRG Then
						RESULTS1.aiStressMethods = CType(Utils.CopyArray(CType(RESULTS1.aiStressMethods, Array), New Short(CInt((RESULTS1.nNonAPICustomRG + 1S)) - 1) {}), Short())
						RESULTS1.aiStressMethods(CInt(RESULTS1.nNonAPICustomRG)) = cRODSTAR.Sections(CInt(num2)).StressMethod
						RESULTS1.nNonAPICustomRG += 1S
					End If
				End If
			Next
			Dim tabStop As Object = 1
			Dim text As String = "ROD STRING STRESS ANALYSIS"
			RESULTS1.MkLine(tabStop, text, False)
			Dim cRODSTAR2 As cRODSTAR
			Select Case cRODSTAR.RodStringType
				Case 1S
					Dim tabStop2 As Object = 0
					Dim str As String = " (API rod number: "
					cRODSTAR2 = cRODSTAR
					Dim obj As Object = cRODSTAR2.APIRod
					Dim str2 As String = Util.Format(obj)
					cRODSTAR2.APIRod = Conversions.ToShort(obj)
					text = str + str2 + ")"
					RESULTS1.MkLine(tabStop2, text, False)
				Case 3S
					Dim tabStop3 As Object = 0
					text = " (rod tapers calculated)"
					RESULTS1.MkLine(tabStop3, text, False)
			End Select
			Dim str3 As String = "Service factor: "
			cRODSTAR2 = cRODSTAR
			Dim serviceFactor As Single = cRODSTAR2.ServiceFactor
			text = "0.0##"
			Dim str4 As String = Util.Format(serviceFactor, text)
			cRODSTAR2.ServiceFactor = serviceFactor
			Dim expression As String = str3 + str4
			RESULTS1.MkLine(75 - Strings.Len(expression), expression, True)
			Dim tabStop4 As Object = 1
			text = New String(ChrW(3), 75)
			RESULTS1.MkLine(tabStop4, text, True)
			Dim text2 As String = "  Diam.|      Rod      | Len.|Tensile |Stress|Top Max. |Top Min. |Bot. Min."
			Dim text3 As String = "  (in) |     Grade     | (ft)|St.(psi)|Load %|Str.(psi)|Str.(psi)|Str.(psi)"
			Dim text4 As String = "-------+---------------+-----+--------+------+---------+---------+---------"
			RESULTS1.Trx(text2, "|", ChrW(1))
			RESULTS1.Trx(text3, "|", ChrW(1))
			RESULTS1.Trx(text4, "-", ChrW(3))
			RESULTS1.Trx(text4, "+", ChrW(4))
			If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				StringType.MidStmtStr(text3, 26, 4, "(m) ")
			End If
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				If Not flag Then
					StringType.MidStmtStr(text3, 3, 4, "(" + RSWIN_DESC.mm + ")")
				End If
				StringType.MidStmtStr(text3, 26, 4, "(m) ")
				StringType.MidStmtStr(text3, 35, 3, RSWIN_DESC.kPa)
				StringType.MidStmtStr(text3, 52, 3, RSWIN_DESC.kPa)
				StringType.MidStmtStr(text3, 62, 3, RSWIN_DESC.kPa)
				StringType.MidStmtStr(text3, 72, 3, RSWIN_DESC.kPa)
			End If
			RESULTS1.MkLine(1, text2, True)
			RESULTS1.MkLine(1, text3, True)
			RESULTS1.MkLine(1, text4, True)
			RESULTS1.bMsgFullOKNeeded = 0S
			RESULTS1.bMsgSlimNeededNeeded = 0S
			RESULTS1.bMsgElevatorNeck1_0Needed = 0S
			RESULTS1.bMsgNoNeckNeeded = 0S
			Dim num6 As Short = 1S
			Dim numRods2 As Short = cRODSTAR.NumRods
			For num2 As Short = num6 To numRods2
				Dim quiet As Object = True
				Dim grade As Object = cRODSTAR.Sections(CInt(num2)).Grade
				Dim diameter As Object = cRODSTAR.Sections(CInt(num2)).Diameter
				Dim flag2 As Boolean
				Dim obj As Object = flag2
				Dim flag3 As Boolean
				Dim obj2 As Object = flag3
				Dim obj3 As Object = ""
				Dim flag4 As Boolean
				Dim obj4 As Object = flag4
				RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj, obj2, obj3, obj4, num2)
				flag4 = Conversions.ToBoolean(obj4)
				flag3 = Conversions.ToBoolean(obj2)
				flag2 = Conversions.ToBoolean(obj)
				Dim str5 As String
				If Not flag2 Then
					str5 = "*"
					RESULTS1.bMsgFullOKNeeded = -1S
				ElseIf flag3 Then
					str5 = "+"
					RESULTS1.bMsgSlimNeededNeeded = -1S
				Else
					str5 = " "
				End If
				If RODUTIL.IsFG(cRODSTAR.Sections(CInt(num2)).Grade) Then
					str5 += " "
				ElseIf RODUTIL.IsNoNeck(cRODSTAR.Sections(CInt(num2)).Grade) Then
					str5 += "#"
					RESULTS1.bMsgNoNeckNeeded = -1S
				Else
					Dim diameter2 As Single = cRODSTAR.Sections(CInt(num2)).Diameter
					If diameter2 >= 1.374F Then
						str5 += "@"
						RESULTS1.bMsgElevatorNeck1_0Needed = -1S
					ElseIf RODUTIL.IsSinkerBar(CInt(num2)) <> 0 Then
						str5 += "@"
						RESULTS1.bMsgElevatorNeck1_0Needed = -1S
					Else
						str5 += " "
					End If
				End If
				Dim text5 As String
				If CUSTOMRG.IsOtherSteel(CInt(cRODSTAR.Sections(CInt(num2)).Grade)) Then
					text5 = Strings.Trim(cRODSTAR.Sections(CInt(num2)).RodType)
				ElseIf RODUTIL.IsCorodH(cRODSTAR.Sections(CInt(num2)).Grade) Then
					If CDbl(cRODSTAR.Sections(CInt(num2)).Area) < 0.7 Then
						text5 += " 682"
					Else
						text5 += " 757"
					End If
				Else
					text5 = RODUTIL.RodGrade(cRODSTAR.Sections(CInt(num2)).Grade)
				End If
				If RESULTS1.nNonAPICustomRG = 0S Then
					text5 = Strings.Left(text5, 15)
					text5 = Strings.Space(15 - Strings.Len(text5) / 2) + text5
				Else
					text5 = Strings.Left(text5, 13)
					Dim num7 As Short
					Dim num8 As Short
					text5 = Strings.Space((13 - Strings.Len(text5)) / 2 + 2) + text5
					num7 = 0S
					num8 = RESULTS1.nNonAPICustomRG - 1S
					For num5 As Short = num7 To num8
						If cRODSTAR.Sections(CInt(num2)).StressMethod = RESULTS1.aiStressMethods(CInt(num5)) Then
							' The following expression was wrapped in a checked-expression
							StringType.MidStmtStr(text5, 1, 1, Strings.Left(Convert.ToString(CInt((num5 + 1S))), 1))
							Exit For
						End If
					Next
				End If
				Dim text6 As String
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
					Dim num9 As Integer = CInt(num2)
					text = "0"
					text6 = Util.Format(sections(num9).length, text)
				Else
					serviceFactor = cRODSTAR.Sections(CInt(num2)).length * RSWIN_DESC.FT__M
					text = "0"
					text6 = Util.Format(serviceFactor, text)
				End If
				Dim text7 As String
				If RODUTIL.IsAPI(CInt(cRODSTAR.Sections(CInt(num2)).Grade), cRODSTAR.Sections(CInt(num2)).RodType) Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						serviceFactor = cRODSTAR.Sections(CInt(num2)).TensileStrength * RSWIN_DESC.PSI__KPA
						text = "0"
						text7 = Util.Format(serviceFactor, text)
					Else
						Dim sections2 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
						Dim num10 As Integer = CInt(num2)
						text = "0"
						text7 = Util.Format(sections2(num10).TensileStrength, text)
					End If
				Else
					Try
						If cRODSTAR.Sections(CInt(num2)).TensileStrength = 0F Then
							RODUTIL.LookupTensileStrength(cRODSTAR.Sections(CInt(num2)))
						End If
						If cRODSTAR.Sections(CInt(num2)).TensileStrength <> 0F Then
							If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								serviceFactor = cRODSTAR.Sections(CInt(num2)).TensileStrength * RSWIN_DESC.PSI__KPA
								text = "0"
								text7 = Util.Format(serviceFactor, text)
							Else
								Dim sections3 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
								Dim num11 As Integer = CInt(num2)
								text = "0"
								text7 = Util.Format(sections3(num11).TensileStrength, text)
							End If
						Else
							text7 = "N/A"
						End If
					Catch ex As Exception
						text7 = "N/A"
					End Try
				End If
				If RODUTIL.IsFG(cRODSTAR.Sections(CInt(num2)).Grade) Or cRODSTAR.Sections(CInt(num2)).Grade = 4100S Then
					text7 = "N/A"
				End If
				Dim text8 As String
				If RODUTIL.IsCorodH(cRODSTAR.Sections(CInt(num2)).Grade) Then
					text8 = "N/A"
				ElseIf RODUTIL.IsCorod(cRODSTAR.Sections(CInt(num2)).Grade) Then
					serviceFactor = cRODSTAR.Sections(CInt(num2)).Diameter * 16F
					text = "0"
					text8 = Util.Format(serviceFactor, text) + "/16"
					If Not flag And RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						text8 += """"
					End If
				ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					serviceFactor = cRODSTAR.Sections(CInt(num2)).Diameter * RSWIN_DESC.IN__MM
					text = "0.0"
					text8 = Util.Format(serviceFactor, text)
				Else
					Dim sections4 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
					Dim num12 As Integer = CInt(num2)
					text = "0.0##"
					text8 = Util.Format(sections4(num12).Diameter, text)
				End If
				Dim text9 As String
				Dim text10 As String
				Dim text11 As String
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					serviceFactor = cRODSTAR.maxStressTop(CInt(num2)) * RSWIN_DESC.PSI__KPA
					text = "0"
					text9 = Util.Format(serviceFactor, text)
					serviceFactor = cRODSTAR.minStressTop(CInt(num2)) * RSWIN_DESC.PSI__KPA
					text = "0"
					text10 = Util.Format(serviceFactor, text)
					serviceFactor = cRODSTAR.minStressBot(CInt(num2)) * RSWIN_DESC.PSI__KPA
					text = "0"
					text11 = Util.Format(serviceFactor, text)
				Else
					Dim maxStressTop As Single() = cRODSTAR.maxStressTop
					Dim num13 As Integer = CInt(num2)
					text = "0"
					text9 = Util.Format(maxStressTop(num13), text)
					Dim minStressTop As Single() = cRODSTAR.minStressTop
					Dim num14 As Integer = CInt(num2)
					text = "0"
					text10 = Util.Format(minStressTop(num14), text)
					Dim minStressBot As Single() = cRODSTAR.minStressBot
					Dim num15 As Integer = CInt(num2)
					text = "0"
					text11 = Util.Format(minStressBot(num15), text)
				End If
				Dim tabStop5 As Object = 1
				text = str5 + text8
				RESULTS1.MkLine(tabStop5, text, False)
				Dim tabStop6 As Object = 8
				text = ChrW(1)
				RESULTS1.MkLine(tabStop6, text, False)
				RESULTS1.MkLine(9, text5, False)
				Dim tabStop7 As Object = 24
				text = ChrW(1)
				RESULTS1.MkLine(tabStop7, text, False)
				RESULTS1.MkLine(26, text6, False)
				Dim tabStop8 As Object = 30
				text = ChrW(1)
				RESULTS1.MkLine(tabStop8, text, False)
				RESULTS1.MkLine(32, text7, False)
				Dim tabStop9 As Object = 39
				text = ChrW(1)
				RESULTS1.MkLine(tabStop9, text, False)
				Dim tabStop10 As Object = 41
				Dim stressL As Single() = cRODSTAR.StressL
				Dim num16 As Integer = CInt(num2)
				text = "0%"
				Dim text12 As String = Util.Format(stressL(num16), text)
				RESULTS1.MkLine(tabStop10, text12, False)
				Dim tabStop11 As Object = 46
				text12 = ChrW(1)
				RESULTS1.MkLine(tabStop11, text12, False)
				RESULTS1.MkLine(49, text9, False)
				Dim tabStop12 As Object = 56
				text12 = ChrW(1)
				RESULTS1.MkLine(tabStop12, text12, False)
				RESULTS1.MkLine(59, text10, False)
				Dim tabStop13 As Object = 66
				text12 = ChrW(1)
				RESULTS1.MkLine(tabStop13, text12, False)
				RESULTS1.MkLine(69, text11, True)
			Next
			If(RESULTS1.bMsgFullOKNeeded Or RESULTS1.bMsgSlimNeededNeeded Or RESULTS1.bMsgElevatorNeck1_0Needed Or RESULTS1.bMsgNoNeckNeeded Or If((-If((RESULTS1.nNonAPICustomRG > 0S > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				Dim tabStop14 As Object = 0
				Dim text12 As String = ""
				RESULTS1.MkLine(tabStop14, text12, True)
				If RESULTS1.bMsgFullOKNeeded <> 0S Then
					Dim tabStop15 As Object = 1
					text12 = "* May be too big for tubing. "
					RESULTS1.MkLine(tabStop15, text12, True)
				End If
				If RESULTS1.bMsgSlimNeededNeeded <> 0S Then
					Dim tabStop16 As Object = 1
					text12 = "+ Requires slimhole couplings."
					RESULTS1.MkLine(tabStop16, text12, True)
				End If
				If RESULTS1.bMsgElevatorNeck1_0Needed <> 0S Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					End If
					Dim tabStop17 As Object = 1
					text12 = "@ Stress calculations based on elevator neck of "
					RESULTS1.MkLine(tabStop17, text12, True)
					Dim tabStop18 As Object = 1
					text12 = "  7/8"" (for 1.25"" sinker bars) or 1"" (for other sinker bars)."
					RESULTS1.MkLine(tabStop18, text12, True)
				End If
				If RESULTS1.bMsgNoNeckNeeded <> 0S Then
					Dim tabStop19 As Object = 1
					text12 = "# Sinker bar has no elevator neck."
					RESULTS1.MkLine(tabStop19, text12, True)
				End If
				Dim num17 As Short = 0S
				Dim num18 As Short = RESULTS1.nNonAPICustomRG - 1S
				For num2 As Short = num17 To num18
					Dim tabStop20 As Object = 1
					text12 = Strings.Left(Convert.ToString(CInt((num2 + 1S))), 1) + " Stress loading, top maximum stress and top minimum stress"
					RESULTS1.MkLine(tabStop20, text12, True)
					Dim tabStop21 As Object = 1
					text12 = "  calculated using the " + RODUTIL.StressMethodName(RESULTS1.aiStressMethods(CInt(num2))) + " method."
					RESULTS1.MkLine(tabStop21, text12, True)
				Next
				If cRODSTAR.gbIncludeBuoyancy Then
					Dim tabStop22 As Object = 1
					text12 = "NOTE: Stress calculations include buoyancy effects."
					RESULTS1.MkLine(tabStop22, text12, True)
				Else
					Dim tabStop23 As Object = 1
					text12 = "NOTE: Stress calculations do not include buoyancy effects."
					RESULTS1.MkLine(tabStop23, text12, True)
				End If
			End If
			cRODSTAR = Nothing
		End Sub

		Public Sub SummTorqueAnalysis()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim str As String
			Dim str2 As String
			Dim str3 As String
			Dim str4 As String
			Dim str5 As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				str = "(N-m):"
				str2 = "(kPa):"
				str3 = "(N):"
				str4 = "(N-m):"
				str5 = "(N):"
			Else
				str = "(M in-lbs):"
				str2 = "(psig):"
				str3 = "(M lbs):"
				str4 = "(M in-lbs):"
				str5 = "(lbs):"
			End If
			Dim str6 As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				str6 = "bbl."
			Else
				str6 = "m³"
			End If
			If Not RODUTIL.IsCrankBalanced(rst.PU.UnitType) And rst.PU.UnitType <> 8S Then
				rst.CBE90(0) = 0F
				rst.CBE90(1) = 0F
				rst.CBE90(2) = 0F
			End If
			Dim text As String = "Torque analysis and"
			Dim sNull As String = " electricity consumption"
			RESULTS1.SummBEHeader(text, sNull)
			If Not rst.gbOutputLoaded Then
				Dim array As Single() = New Single(2) {}
				sNull = RSWIN_DESC.sNull
				Dim efactor As Single = 0F
				Dim mfactor As Single = 0F
				Dim etoM As Single = 0F
				text = "#"
				RESULTS1.SummBE(sNull, array, efactor, mfactor, etoM, text, True)
				RSWIN_DESC.sNull = sNull
				sNull = RSWIN_DESC.sNull
				Dim efactor2 As Single = 0F
				Dim mfactor2 As Single = 0F
				Dim etoM2 As Single = 0F
				text = "#"
				RESULTS1.SummBE(sNull, array, efactor2, mfactor2, etoM2, text, True)
				RSWIN_DESC.sNull = sNull
				sNull = RSWIN_DESC.sNull
				Dim efactor3 As Single = 0F
				Dim mfactor3 As Single = 0F
				Dim etoM3 As Single = 0F
				text = "#"
				RESULTS1.SummBE(sNull, array, efactor3, mfactor3, etoM3, text, True)
				RSWIN_DESC.sNull = sNull
				sNull = RSWIN_DESC.sNull
				Dim efactor4 As Single = 0F
				Dim mfactor4 As Single = 0F
				Dim etoM4 As Single = 0F
				text = "#"
				RESULTS1.SummBE(sNull, array, efactor4, mfactor4, etoM4, text, True)
				RSWIN_DESC.sNull = sNull
				sNull = RSWIN_DESC.sNull
				Dim efactor5 As Single = 0F
				Dim mfactor5 As Single = 0F
				Dim etoM5 As Single = 0F
				text = "#"
				RESULTS1.SummBE(sNull, array, efactor5, mfactor5, etoM5, text, True)
				RSWIN_DESC.sNull = sNull
				sNull = RSWIN_DESC.sNull
				Dim efactor6 As Single = 0F
				Dim mfactor6 As Single = 0F
				Dim etoM6 As Single = 0F
				text = "#"
				RESULTS1.SummBE(sNull, array, efactor6, mfactor6, etoM6, text, True)
				RSWIN_DESC.sNull = sNull
				sNull = RSWIN_DESC.sNull
				Dim efactor7 As Single = 0F
				Dim mfactor7 As Single = 0F
				Dim etoM7 As Single = 0F
				text = "#"
				RESULTS1.SummBE(sNull, array, efactor7, mfactor7, etoM7, text, True)
				RSWIN_DESC.sNull = sNull
				sNull = RSWIN_DESC.sNull
				Dim efactor8 As Single = 0F
				Dim mfactor8 As Single = 0F
				Dim etoM8 As Single = 0F
				text = "#"
				RESULTS1.SummBE(sNull, array, efactor8, mfactor8, etoM8, text, True)
				RSWIN_DESC.sNull = sNull
				sNull = RSWIN_DESC.sNull
				Dim efactor9 As Single = 0F
				Dim mfactor9 As Single = 0F
				Dim etoM9 As Single = 0F
				text = "#"
				RESULTS1.SummBE(sNull, array, efactor9, mfactor9, etoM9, text, True)
				RSWIN_DESC.sNull = sNull
			Else
				sNull = "Peak g'box torq. " + str
				Dim cRODSTAR As cRODSTAR = rst
				Dim array2 As Single() = cRODSTAR.PeakTorque
				Dim efactor10 As Single = 0.001F
				Dim mfactor10 As Single = 0.001F
				Dim minlb__NM As Single = RSWIN_DESC.MINLB__NM
				text = "0"
				RESULTS1.SummBE(sNull, array2, efactor10, mfactor10, minlb__NM, text, True)
				cRODSTAR.PeakTorque = array2
				sNull = "Gearbox loading:"
				cRODSTAR = rst
				array2 = cRODSTAR.GearboxLoading
				Dim efactor11 As Single = 1F
				Dim mfactor11 As Single = 1F
				Dim etoM10 As Single = 1F
				text = "0%"
				RESULTS1.SummBE(sNull, array2, efactor11, mfactor11, etoM10, text, True)
				cRODSTAR.GearboxLoading = array2
				sNull = "Cyclic load factor:"
				cRODSTAR = rst
				array2 = cRODSTAR.Clf
				Dim efactor12 As Single = 1F
				Dim mfactor12 As Single = 1F
				Dim etoM11 As Single = 1F
				text = "0.0#"
				RESULTS1.SummBE(sNull, array2, efactor12, mfactor12, etoM11, text, True)
				cRODSTAR.Clf = array2
				If rst.PU.UnitType = 6S Then
					sNull = "Max. air tank pres. " + str2
					cRODSTAR = rst
					array2 = cRODSTAR.M
					Dim efactor13 As Single = 1F
					Dim mfactor13 As Single = 1F
					Dim psi__KPA As Single = RSWIN_DESC.PSI__KPA
					text = "0"
					RESULTS1.SummBE(sNull, array2, efactor13, mfactor13, psi__KPA, text, True)
					cRODSTAR.M = array2
					sNull = RSWIN_DESC.sNull
					cRODSTAR = rst
					array2 = cRODSTAR.CBE90
					Dim efactor14 As Single = 1F
					Dim mfactor14 As Single = 1F
					Dim etoM12 As Single = 1F
					text = "#"
					RESULTS1.SummBE(sNull, array2, efactor14, mfactor14, etoM12, text, True)
					cRODSTAR.CBE90 = array2
					RSWIN_DESC.sNull = sNull
				ElseIf rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Then
					sNull = "Counterbalance weight " + str3
					cRODSTAR = rst
					array2 = cRODSTAR.M
					Dim efactor15 As Single = 0.001F
					Dim mfactor15 As Single = 1F
					Dim lb__N As Single = RSWIN_DESC.LB__N
					text = "0.00"
					RESULTS1.SummBE(sNull, array2, efactor15, mfactor15, lb__N, text, True)
					cRODSTAR.M = array2
					sNull = RSWIN_DESC.sNull
					cRODSTAR = rst
					array2 = cRODSTAR.CBE90
					Dim efactor16 As Single = 1F
					Dim mfactor16 As Single = 1F
					Dim etoM13 As Single = 1F
					text = "#"
					RESULTS1.SummBE(sNull, array2, efactor16, mfactor16, etoM13, text, True)
					cRODSTAR.CBE90 = array2
					RSWIN_DESC.sNull = sNull
				Else
					sNull = "Max. CB moment " + str4
					cRODSTAR = rst
					array2 = cRODSTAR.M
					Dim efactor17 As Single = 0.001F
					Dim mfactor17 As Single = 0.001F
					Dim minlb__NM2 As Single = RSWIN_DESC.MINLB__NM
					text = "0.00"
					RESULTS1.SummBE(sNull, array2, efactor17, mfactor17, minlb__NM2, text, True)
					cRODSTAR.M = array2
					sNull = "Counterbalance effect " + str5
					cRODSTAR = rst
					array2 = cRODSTAR.CBE90
					Dim efactor18 As Single = 1F
					Dim mfactor18 As Single = 1F
					Dim etoM14 As Single = 1F
					text = "0"
					RESULTS1.SummBE(sNull, array2, efactor18, mfactor18, etoM14, text, True)
					cRODSTAR.CBE90 = array2
				End If
				sNull = "Daily electr. use (KWH/day):"
				cRODSTAR = rst
				array2 = cRODSTAR.MotorKWH
				Dim efactor19 As Single = 1F
				Dim mfactor19 As Single = 1F
				Dim etoM15 As Single = 1F
				text = "###0"
				RESULTS1.SummBE(sNull, array2, efactor19, mfactor19, etoM15, text, True)
				cRODSTAR.MotorKWH = array2
				sNull = "Monthly electric bill:"
				cRODSTAR = rst
				array2 = cRODSTAR.ElectricBillperMonth
				Dim efactor20 As Single = 1F
				Dim mfactor20 As Single = 1F
				Dim etoM16 As Single = 1F
				text = "$0"
				RESULTS1.SummBE(sNull, array2, efactor20, mfactor20, etoM16, text, True)
				cRODSTAR.ElectricBillperMonth = array2
				sNull = "Electr. cost per " + str6 + " fluid:"
				cRODSTAR = rst
				array2 = cRODSTAR.DollarsPerBblFluid
				Dim efactor21 As Single = 1F
				Dim mfactor21 As Single = 1F
				Dim etoM17 As Single = 1F / RSWIN_DESC.BPD__M3D
				text = "$0.000"
				RESULTS1.SummBE(sNull, array2, efactor21, mfactor21, etoM17, text, False)
				cRODSTAR.DollarsPerBblFluid = array2
				If rst.WaterCut < 100F Then
					sNull = "Electr. cost per " + str6 + " oil:"
					cRODSTAR = rst
					array2 = cRODSTAR.DollarsPerBblOil
					Dim efactor22 As Single = 1F
					Dim mfactor22 As Single = 1F
					Dim etoM18 As Single = 1F / RSWIN_DESC.BPD__M3D
					text = "$0.000"
					RESULTS1.SummBE(sNull, array2, efactor22, mfactor22, etoM18, text, False)
					cRODSTAR.DollarsPerBblOil = array2
				Else
					RESULTS1.AddRLine(RSWIN_DESC.sNull)
				End If
			End If
			RESULTS1.AddRLine(RSWIN_DESC.sNull)
		End Sub

		Public Sub SummTrailer()
			Dim array As Short() = New Short(5) {}
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
			End If
			Dim num As Short = 0S
			Dim num2 As Short
			Dim num3 As Short
			If RESULTS1.bMsgFullOKNeeded <> 0S Then
				num += 1S
				array(CInt(num)) = Conversions.ToShort("* May be too big for tubing.")
			End If
			If RESULTS1.bMsgSlimNeededNeeded <> 0S Then
				num += 1S
				array(CInt(num)) = Conversions.ToShort("+ Requires slimhole couplings.")
			End If
			If RESULTS1.bMsgElevatorNeck1_0Needed <> 0S Then
				num += 1S
				array(CInt(num)) = Conversions.ToShort("@ Stress calculations based on elevator neck of 7/8"" (for 1.25"" sinker bars) or 1"" (for other sinker bars).")
			End If
			If RESULTS1.bMsgNoNeckNeeded <> 0S Then
				num += 1S
				array(CInt(num)) = Conversions.ToShort("# Sinker bar has no elevator neck.")
			End If
			num += 1S
			If rst.gbIncludeBuoyancy Then
				array(CInt(num)) = Conversions.ToShort("NOTE: Stress calculations include buoyancy effects.")
			Else
				array(CInt(num)) = Conversions.ToShort("NOTE: Stress calculations do not include buoyancy effects.")
			End If
			If rst.NumRods + num >= 10S Then
				num = 10S - rst.NumRods
			Else
				RESULTS1.SendLine(RSWIN_DESC.sNull)
			End If
			If num = 0S Then
				num = 1S
				array(1) = Conversions.ToShort(RSWIN_DESC.sNull)
			End If
			num2 = 1S
			num3 = num
			For num4 As Short = num2 To num3
				RESULTS1.SendLine(Convert.ToString(array(CInt(num4))))
			Next
		End Sub

		Public Sub SummTubingAndPump()
			RESULTS1.AddLLine("Tubing and pump information")
			RESULTS1.AddLLine(New String(ChrW(3), 50))
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim str As String = "Rod-tub. frict.: "
			Dim cRODSTAR As cRODSTAR = rst
			Dim num As Single = cRODSTAR.UpstrokeFriction
			Dim text As String = "0.000"
			Dim str2 As String = Util.Format(num, text)
			cRODSTAR.UpstrokeFriction = num
			Dim text2 As String = str + str2 + "(up)"
			If rst.CalcFriction <> 0S Then
				text2 = ChrW(5) + text2 + Conversions.ToString(Strings.Chr(255))
			End If
			Dim w As Object = 23
			text = "Tubing O.D."
			Dim tubingOD As Single = rst.TubingOD
			Dim in__MM As Single = RSWIN_DESC.IN__MM
			Dim text3 As String = "0.000"
			Dim text4 As String = "0.000"
			RESULTS1.AddLLine(RESULTS1.MkSummEM(w, text, tubingOD, in__MM, RSWIN_DESC.ins, text3, RSWIN_DESC.mm, text4, 3, False, False) + "  " + text2)
			cRODSTAR = rst
			num = cRODSTAR.DownstrokeFriction
			text4 = "0.000"
			Dim str3 As String = Util.Format(num, text4)
			cRODSTAR.DownstrokeFriction = num
			text2 = str3 + "(dn)"
			If rst.CalcFriction <> 0S Then
				text2 = ChrW(5) + text2 + Conversions.ToString(Strings.Chr(255))
			End If
			Dim w2 As Object = 23
			text4 = "Tubing I.D."
			Dim tubingID As Single = rst.TubingID
			Dim in__MM2 As Single = RSWIN_DESC.IN__MM
			text3 = "0.000"
			text = "0.000"
			RESULTS1.AddLLine(RESULTS1.MkSummEM(w2, text4, tubingID, in__MM2, RSWIN_DESC.ins, text3, RSWIN_DESC.mm, text, 3, False, False) + Strings.Space(19) + text2)
			RESULTS1.AddLLine(RSWIN_DESC.sNull)
			Dim text5 As String
			If rst.TubingAnchored <> 0S Then
				Dim w3 As Object = 25
				text4 = "Tub.anch.depth"
				Dim tubingAnchorDepth As Single = rst.TubingAnchorDepth
				Dim ft__M As Single = RSWIN_DESC.FT__M
				text3 = "0"
				text = "m"
				text5 = "0"
				text2 = RESULTS1.MkSummEM(w3, text4, tubingAnchorDepth, ft__M, RSWIN_DESC.ft, text3, text, text5, 3, False, False)
			Else
				text2 = Strings.Space(27)
				text2 = Strings.LSet("Tubing is not anchored", Strings.Len(text2))
			End If
			Dim w4 As Object = 23
			text5 = "Pump depth"
			Dim pumpDepth As Single = rst.PumpDepth
			Dim ft__M2 As Single = RSWIN_DESC.FT__M
			text4 = "0.0"
			text3 = "m"
			text = "0.0"
			RESULTS1.AddLLine(RESULTS1.MkSummEM(w4, text5, pumpDepth, ft__M2, RSWIN_DESC.ft, text4, text3, text, 3, False, False) + "  " + text2)
			Dim text6 As String
			Select Case rst.PumpCondition
				Case 1S
					text6 = "Full"
				Case 2S
					text6 = "Fl pound"
				Case 3S
					text6 = "Gas intf"
			End Select
			text6 = "#""" + text6 + """"
			Dim w5 As Object = 23
			text5 = "Pump condition:"
			text6 = RESULTS1.MkSumm(w5, text5, 0F, text6, False, False)
			If rst.gbCalcPumpCondition Then
				text6 = ChrW(5) + text6 + Conversions.ToString(Strings.Chr(255))
			End If
			Dim str4 As String = text6
			Dim str5 As String = "  "
			Dim w6 As Object = 25
			text5 = "Pump load adj."
			Dim pumpLoadAdj As Single = rst.PumpLoadAdj
			Dim lb__N As Single = RSWIN_DESC.LB__N
			text4 = "0"
			text3 = "0"
			RESULTS1.AddLLine(str4 + str5 + RESULTS1.MkSummEM(w6, text5, pumpLoadAdj, lb__N, RSWIN_DESC.lbs, text4, RSWIN_DESC.N, text3, 1, False, False))
			Select Case rst.PumpType
				Case 1S
					text6 = "Insert"
				Case 2S
					text6 = "Tubing"
				Case 3S
					text6 = "Large bore"
			End Select
			text6 = "#""" + text6 + """"
			If rst.gbCalcPumpCondition And rst.PumpCondition = 2S Then
				text2 = "Calc. pump fillage:"
			Else
				text2 = "Pump vol. efficiency:"
			End If
			Dim w7 As Object = 23
			text4 = "Pump type:"
			Dim str6 As String = RESULTS1.MkSumm(w7, text4, 0F, text6, False, False)
			Dim str7 As String = "  "
			Dim w8 As Object = 25
			Dim pfill As Single = rst.Pfill
			text5 = "0%"
			RESULTS1.AddLLine(str6 + str7 + RESULTS1.MkSumm(w8, text2, pfill, text5, False, False))
			Dim w9 As Object = 23
			text5 = "Plunger size"
			Dim plungerSize As Single = rst.PlungerSize
			Dim in__MM3 As Single = RSWIN_DESC.IN__MM
			text4 = "0.0##"
			text3 = "0.0"
			text6 = RESULTS1.MkSummEM(w9, text5, plungerSize, in__MM3, RSWIN_DESC.ins, text4, RSWIN_DESC.mm, text3, 1, False, False)
			If rst.CalcPlungerSize = -1S Then
				text6 = ChrW(5) + text6 + Conversions.ToString(Strings.Chr(255))
			End If
			Dim str8 As String = text6
			Dim str9 As String = "  "
			Dim w10 As Object = 25
			text5 = "Pump friction"
			Dim pumpFriction As Single = rst.PumpFriction
			Dim lb__N2 As Single = RSWIN_DESC.LB__N
			text4 = "0"
			text3 = "0"
			RESULTS1.AddLLine(str8 + str9 + RESULTS1.MkSummEM(w10, text5, pumpFriction, lb__N2, RSWIN_DESC.lbs, text4, RSWIN_DESC.N, text3, 1, False, False))
			RESULTS1.AddLLine(RSWIN_DESC.sNull)
		End Sub

		Public Sub SummTubingCalc()
			RESULTS1.AddRLine(" Tubing, pump and plunger calculations")
			RESULTS1.AddRLine(" " + New String(ChrW(3), 62))
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Not rst.gbOutputLoaded Then
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
			Else
				Dim w As Object = 47
				Dim text As String = " Tubing stretch"
				Dim tubStretch As Single = rst.TubStretch
				Dim in__CM As Single = RSWIN_DESC.IN__CM
				Dim text2 As String = "0.0"
				Dim text3 As String = "0.0"
				RESULTS1.AddRLine(RESULTS1.MkSummEM(w, text, tubStretch, in__CM, RSWIN_DESC.ins, text2, RSWIN_DESC.cm, text3, 1, False, False))
				Dim w2 As Object = 47
				text3 = " Prod. loss due to tubing stretch"
				Dim productionLoss As Single = rst.ProductionLoss
				Dim bpd__M3D As Single = RSWIN_DESC.BPD__M3D
				text2 = "0"
				text = "0.0"
				RESULTS1.AddRLine(RESULTS1.MkSummEM(w2, text3, productionLoss, bpd__M3D, RSWIN_DESC.bfpd, text2, RSWIN_DESC.m3D, text, 3, False, False))
				Dim w3 As Object = 47
				text3 = " Gross pump stroke"
				Dim grossPumpStroke As Single = rst.GrossPumpStroke
				Dim in__CM2 As Single = RSWIN_DESC.IN__CM
				text2 = "0"
				text = "0.0"
				RESULTS1.AddRLine(RESULTS1.MkSummEM(w3, text3, grossPumpStroke, in__CM2, RSWIN_DESC.ins, text2, RSWIN_DESC.cm, text, 1, False, False))
				Dim w4 As Object = 47
				text3 = " Pump spacing"
				Dim pumpSpacing As Single = rst.PumpSpacing
				Dim in__CM3 As Single = RSWIN_DESC.IN__CM
				text2 = "in. from bottom"
				text = "0.0"
				Dim text4 As String = "cm from bottom"
				Dim text5 As String = "0"
				RESULTS1.AddRLine(RESULTS1.MkSummEM(w4, text3, pumpSpacing, in__CM3, text2, text, text4, text5, 1, False, False))
				Dim w5 As Object = 47
				text5 = " Minimum pump length"
				Dim pumpLength As Single = rst.PumpLength
				Dim ft__M As Single = RSWIN_DESC.FT__M
				text4 = "0.0"
				text3 = "m"
				text2 = "0.0"
				RESULTS1.AddRLine(RESULTS1.MkSummEM(w5, text5, pumpLength, ft__M, RSWIN_DESC.ft, text4, text3, text2, 1, False, False))
				Dim w6 As Object = 47
				text5 = " Recommended plunger length"
				Dim plungerLength As Single = rst.PlungerLength
				Dim ft__M2 As Single = RSWIN_DESC.FT__M
				text4 = "0.0"
				text3 = "m"
				text2 = "0.0"
				RESULTS1.AddRLine(RESULTS1.MkSummEM(w6, text5, plungerLength, ft__M2, RSWIN_DESC.ft, text4, text3, text2, 1, False, False))
			End If
			RESULTS1.AddRLine(RSWIN_DESC.sNull)
		End Sub

		Public Sub Trx(ByRef A As String, sRep As String, sWith As String)
			While Strings.InStr(A, sRep, CompareMethod.Binary) > 0
				' The following expression was wrapped in a checked-expression
				Dim startPosition As Short = CShort(Strings.InStr(A, sRep, CompareMethod.Binary))
				StringType.MidStmtStr(A, CInt(startPosition), Strings.Len(sRep), sWith)
			End While
		End Sub

		Public Function VTrim(T As String) As String
			While Strings.Len(T) > 0
				Dim num As Integer = Strings.Asc(T)
				If num = 0 OrElse num = 9 Then
					T = Strings.Mid(T, 2)
				Else
					If num <> 32 Then
						IL_6A:
						While Strings.Len(T) > 0
							Dim num2 As Integer = Strings.Asc(Strings.Right(T, 1))
							If num2 = 0 OrElse num2 = 9 Then
								' The following expression was wrapped in a checked-expression
								T = Strings.Left(T, Strings.Len(T) - 1)
							Else
								If num2 <> 32 Then
									Exit While
								End If
								T = Strings.RTrim(T)
							End If
						End While
						Return T
					End If
					T = Strings.LTrim(T)
				End If
			End While
			GoTo IL_6A
		End Function

		Public Sub AddLLine(sLine As String)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort((Information.UBound(RESULTS1.lLines, 1) + 1))
			If num = 1S Then
				RESULTS1.lLines = New String(1) {}
			Else
				RESULTS1.lLines = CType(Utils.CopyArray(CType(RESULTS1.lLines, Array), New String(CInt((num + 1S)) - 1) {}), String())
			End If
			RESULTS1.lLines(CInt(num)) = sLine
		End Sub

		Public Sub AddRLine(sLine As String)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort((Information.UBound(RESULTS1.RLines, 1) + 1))
			If num = 1S Then
				RESULTS1.RLines = New String(1) {}
			Else
				RESULTS1.RLines = CType(Utils.CopyArray(CType(RESULTS1.RLines, Array), New String(CInt((num + 1S)) - 1) {}), String())
			End If
			RESULTS1.RLines(CInt(num)) = sLine
		End Sub

		Public Function CenterField(sVal As String, iWidth As Short) As String
			Dim result As String
			If Strings.Len(sVal) > CInt(iWidth) Then
				result = Strings.Left(sVal, CInt(iWidth))
			Else
				Dim text As String = Strings.Space(CInt(iWidth))
				StringType.MidStmtStr(text, CInt(Math.Round(CDbl((CInt(iWidth) - Strings.Len(sVal))) / 2.0 + 1.0)), Strings.Len(sVal), sVal)
				result = text
			End If
			Return result
		End Function

		Public Sub DrawLine(LineType As Object, X As Single, Y As Single)
		End Sub

		Public Sub DrawReport(ByRef pic As PictureBox, nPage As Object)
		End Sub

		Public Sub MkBEHeader()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim text As String = " BALANCED "
			Dim str As String = " EXISTING "
			Dim str2 As String = "(Min Ener)"
			Dim str3 As String = "(Min Torq)"
			Dim str4 As String = ChrW(4)
			Dim str5 As String = ChrW(1)
			Dim text2 As String = New String(ChrW(3), 10)
			Dim str6 As String
			Dim text3 As String
			Dim str7 As String
			If(RSWIN_DESC.rst.PU.UnitType <> 8S And rst.get_M(0) = rst.get_M(1)) Or (RSWIN_DESC.rst.PU.UnitType = 8S And rst.get_RequiredUnbalance(0) = rst.get_RequiredUnbalance(1)) Then
				str6 = ""
				text3 = ""
				str7 = ""
			Else
				str6 = text + str5
				text3 = str2 + str5
				str7 = text2 + str4
			End If
			str6 += text
			If Strings.Len(text3) > 0 Then
				text3 += str3
			End If
			str7 += text2
			If Not rst.UnknownM Then
				str6 = str6 + str5 + str
				If Strings.Len(text3) > 0 Then
					text3 += str5
				End If
				str7 = str7 + str4 + text2
			End If
			RESULTS1.MkLine(44, str6, True)
			If Strings.Len(text3) > 0 Then
				RESULTS1.MkLine(44, text3, True)
			End If
			RESULTS1.MkLine(44, str7, True)
		End Sub

		Public Sub MkLine(TabStop As Object, ByRef lin As String, addCRLF As Object)
			Monitor.Enter(RESULTS1.$STATIC$MkLine$0311C10E1C$CurLine$Init)
			Try
				If RESULTS1.$STATIC$MkLine$0311C10E1C$CurLine$Init.State = 0S Then
					RESULTS1.$STATIC$MkLine$0311C10E1C$CurLine$Init.State = 2S
					RESULTS1.$STATIC$MkLine$0311C10E1C$CurLine = New String(" "c, 80)
				ElseIf RESULTS1.$STATIC$MkLine$0311C10E1C$CurLine$Init.State = 2S Then
					Throw New IncompleteInitialization()
				End If
			Finally
				RESULTS1.$STATIC$MkLine$0311C10E1C$CurLine$Init.State = 1S
				Monitor.[Exit](RESULTS1.$STATIC$MkLine$0311C10E1C$CurLine$Init)
			End Try
			If RESULTS1.$STATIC$MkLine$0311C10E1C$CurPos = 0S Then
				RESULTS1.$STATIC$MkLine$0311C10E1C$CurLine = ""
				RESULTS1.$STATIC$MkLine$0311C10E1C$CurPos = 1S
			End If
			If Operators.ConditionalCompareObjectEqual(TabStop, 0, False) Then
				TabStop = RESULTS1.$STATIC$MkLine$0311C10E1C$CurPos
			End If
			If Strings.Len(lin) > 0 Then
				StringType.MidStmtStr(RESULTS1.$STATIC$MkLine$0311C10E1C$CurLine, Conversions.ToInteger(TabStop), Strings.Len(lin), lin)
			End If
			RESULTS1.$STATIC$MkLine$0311C10E1C$CurPos = Conversions.ToShort(Operators.AddObject(TabStop, Strings.Len(lin)))
			If Conversions.ToBoolean(addCRLF) Then
				RESULTS1.SendLine(Strings.RTrim(RESULTS1.$STATIC$MkLine$0311C10E1C$CurLine))
				RESULTS1.$STATIC$MkLine$0311C10E1C$CurLine = ""
				RESULTS1.$STATIC$MkLine$0311C10E1C$CurPos = 1S
			End If
		End Sub

		Public Sub MkLine2(ByRef LeftS As String, ByRef RightS As String)
			RESULTS1.MkLine(1, LeftS, False)
			Dim tabStop As Object = 37S
			Dim text As String = ChrW(1) + RightS
			RESULTS1.MkLine(tabStop, text, True)
		End Sub

		Public Sub MkLineBE(ByRef Label As String, ByRef v As Single(), EFactor As Single, MFactor As Single, EtoM As Single, ByRef Fmt As String, bCisE As Object)
			RESULTS1.MkLine(1, Label, False)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Short
			If(RSWIN_DESC.rst.PU.UnitType <> 8S And rst.get_M(0) = rst.get_M(1)) Or (RSWIN_DESC.rst.PU.UnitType = 8S And rst.get_RequiredUnbalance(0) = rst.get_RequiredUnbalance(1)) Then
				num = 1S
			Else
				num = 0S
			End If
			Dim num2 As Short = num
			Dim num3 As Short = If((-If((rst.UnknownM > False), 1S, 0S)), 1S, 0S)
			Dim text As String
			For num4 As Short = num2 To num3
				Dim num5 As Short
				num5 = 46S + 11S * num4 - num
				If num4 <> num Then
					Dim tabStop As Object = CInt((num5 - 3S))
					text = ChrW(1)
					RESULTS1.MkLine(tabStop, text, False)
				End If
				Dim num6 As Short
				If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					num6 = Conversions.ToShort(Operators.NotObject(bCisE))
				Else
					num6 = If((-If(((RSWIN_DESC.SETUP_MeasurementSystem = 3) > False), 1S, 0S)), 1S, 0S)
				End If
				If num6 <> 0S Then
					Dim tabStop2 As Object = num5
					Dim num7 As Single = v(CInt(num4)) * MFactor * EtoM
					text = Util.Format(num7, Fmt)
					RESULTS1.MkLine(tabStop2, text, False)
				Else
					Dim tabStop3 As Object = num5
					Dim num7 As Single = v(CInt(num4)) * EFactor
					text = Util.Format(num7, Fmt)
					RESULTS1.MkLine(tabStop3, text, False)
				End If
			Next
			Dim tabStop4 As Object = 0
			text = ""
			RESULTS1.MkLine(tabStop4, text, True)
		End Sub

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
			Return RESULTS1.MkSumm(objectValue, text2, v, text, bShowLabelOnly, bShowValueOnly)
		End Function

		Public Function MkSummEM_old(W As Object, ByRef Label As String, v As Single, EtoM As Single, ByRef EU As String, ByRef EFmt As String, ByRef MU As String, ByRef MFmt As String, cUnits As Object) As String
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
			Dim text2 As String = Label + str + ": "
			Return RESULTS1.MkSumm(objectValue, text2, v, text, False, False)
		End Function

		Public Function MkVal(v As Single, EtoM As Single, ByRef EU As String, ByRef EFmt As String, ByRef MU As String, ByRef MFmt As String, cUnits As Object) As String
			Dim num As Short
			Select Case RSWIN_DESC.SETUP_MeasurementSystem
				Case 1
					num = 0S
				Case 2
					num = Conversions.ToShort(Operators.CompareObjectEqual(cUnits, 3, False))
				Case 3
					num = -1S
			End Select
			Dim result As String
			If num <> 0S Then
				Dim str As String = " ("
				Dim str2 As String = MU
				Dim str3 As String = "): "
				Dim num2 As Single = v * EtoM
				result = str + str2 + str3 + Util.Format(num2, MFmt)
			Else
				result = " (" + EU + "): " + Util.Format(v, EFmt)
			End If
			Return result
		End Function

		Public Function MkVal3(v As Single, EtoM As Single, ByRef EU As String, ByRef EFmt As String, ByRef MU As String, ByRef MFmt As String) As String
			Dim text As String = Util.Format(v, EFmt)
			Dim num As Single = v * EtoM
			Dim text2 As String = Util.Format(num, MFmt)
			Dim text3 As String
			If Operators.CompareString(EU, "in", False) = 0 Then
				text3 = """"
			Else
				text3 = " " + EU
			End If
			Dim result As String
			Select Case RSWIN_DESC.SETUP_MeasurementSystem
				Case 1
					result = " (" + EU + "): " + text
				Case 2
					result = String.Concat(New String() { ": ", text, text3, " (", text2, " ", MU, ")" })
				Case 3
					result = " (" + MU + "): " + text2
			End Select
			Return result
		End Function

		Public Sub PrintCostAnalysis(iPage As Short, nPages As Short)
		End Sub

		Public Sub PrintReport()
		End Sub

		Public Sub PrintSummary(iPage As Short, nPages As Short)
			RESULTS1.toPrinter = -1S
			RESULTS1.CurLine = 0S
			RESULTS1.SummInitialize()
			RESULTS1.SummMiscInput()
			RESULTS1.SummFluidAndMotor()
			RESULTS1.SummPumpingUnit()
			RESULTS1.SummTubingAndPump()
			RESULTS1.SummRSInput()
			RESULTS1.SummCalculations()
			RESULTS1.SummPrimeMoverSize()
			RESULTS1.SummTorqueAnalysis()
			RESULTS1.SummTubingCalc()
			RESULTS1.SummRSCalc()
			RESULTS1.SummHeader(iPage, nPages)
			RESULTS1.SummPrint()
			RESULTS1.SummTrailer()
		End Sub

		Public Sub SendLine(sLine As String)
		End Sub

		Public Sub ShowEnergy()
			Dim array As Short() = New Short() { Conversions.ToShort(" (calc.)"), Conversions.ToShort(RSWIN_DESC.sNull) }
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim str As String
			Select Case rst.PowerMeterType
				Case 1S
					str = "Detent (no credit for generated power)"
				Case 2S
					str = "Non-detent (credit for generated power)"
			End Select
			Dim cRODSTAR As cRODSTAR
			Dim num As Single
			Dim text As String
			Dim array2 As Single()
			Dim text2 As String
			If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), rst.CalcMotorSize)) Then
				Dim str2 As String
				If rst.MotorSPV > 0F Then
					Dim obj As Object = Operators.AddObject(Operators.AddObject(Convert.ToDouble("(speed variation"), Interaction.IIf(rst.CalcMotorSPV <> 0S, array(0), array(1))), Convert.ToDouble(": "))
					cRODSTAR = rst
					num = cRODSTAR.MotorSPV
					text = "0.0%"
					Dim value As String = Util.Format(num, text)
					cRODSTAR.MotorSPV = num
					str2 = Convert.ToString(Operators.AddObject(Operators.AddObject(obj, Convert.ToDouble(value)), Convert.ToDouble(")")))
				Else
					str2 = "(speed variation not included)"
				End If
				Dim tabStop As Object = 1
				text = "REQUIRED PRIME MOVER SIZE " + str2
				RESULTS1.MkLine(tabStop, text, True)
				Dim tabStop2 As Object = 1
				text = New String(ChrW(3), 75)
				RESULTS1.MkLine(tabStop2, text, True)
				RESULTS1.MkBEHeader()
				If Operators.ConditionalCompareObjectEqual(Motor.GetMotorInfo(4), 7, False) Then
					text = "Marathon NEMA B motor:"
					cRODSTAR = rst
					array2 = cRODSTAR.HpNemaD
					Dim efactor As Single = 1F
					Dim mfactor As Single = 1F
					Dim etoM As Single = 1F
					text2 = "##0 \HP"
					RESULTS1.MkLineBE(text, array2, efactor, mfactor, etoM, text2, True)
					cRODSTAR.HpNemaD = array2
				ElseIf Operators.ConditionalCompareObjectEqual(Motor.GetMotorInfo(4), 8, False) Then
					text2 = "Tatung NEMA B motor:"
					cRODSTAR = rst
					array2 = cRODSTAR.HpNemaD
					Dim efactor2 As Single = 1F
					Dim mfactor2 As Single = 1F
					Dim etoM2 As Single = 1F
					text = "##0 \HP"
					RESULTS1.MkLineBE(text2, array2, efactor2, mfactor2, etoM2, text, True)
					cRODSTAR.HpNemaD = array2
				ElseIf Operators.ConditionalCompareObjectGreater(Motor.GetMotorInfo(4), 8, False) Then
					text2 = RESULTS1.GetMotorName(Conversions.ToInteger(Motor.GetMotorInfo(4))) + " motor:"
					cRODSTAR = rst
					array2 = cRODSTAR.HpNemaD
					Dim efactor3 As Single = 1F
					Dim mfactor3 As Single = 1F
					Dim etoM3 As Single = 1F
					text = "##0 \HP"
					RESULTS1.MkLineBE(text2, array2, efactor3, mfactor3, etoM3, text, True)
					cRODSTAR.HpNemaD = array2
				Else
					text2 = "NEMA D motor:"
					cRODSTAR = rst
					array2 = cRODSTAR.HpNemaD
					Dim efactor4 As Single = 1F
					Dim mfactor4 As Single = 1F
					Dim etoM4 As Single = 1F
					text = "##0 \HP"
					RESULTS1.MkLineBE(text2, array2, efactor4, mfactor4, etoM4, text, True)
					cRODSTAR.HpNemaD = array2
				End If
				text2 = "Single or double cylinder engine.:"
				cRODSTAR = rst
				array2 = cRODSTAR.HpUhs
				Dim efactor5 As Single = 1F
				Dim mfactor5 As Single = 1F
				Dim etoM5 As Single = 1F
				text = "##0 \HP"
				RESULTS1.MkLineBE(text2, array2, efactor5, mfactor5, etoM5, text, True)
				cRODSTAR.HpUhs = array2
				text2 = "Multicylinder engine:"
				cRODSTAR = rst
				array2 = cRODSTAR.HpNemaD
				Dim efactor6 As Single = 1F
				Dim mfactor6 As Single = 1F
				Dim etoM6 As Single = 1F
				text = "##0 \HP"
				RESULTS1.MkLineBE(text2, array2, efactor6, mfactor6, etoM6, text, True)
				cRODSTAR.HpNemaD = array2
			Else
				Dim tabStop3 As Object = 1
				text2 = "PRIME MOVER"
				RESULTS1.MkLine(tabStop3, text2, True)
				Dim tabStop4 As Object = 1
				text2 = New String(ChrW(3), 75)
				RESULTS1.MkLine(tabStop4, text2, True)
				Dim text3 As String = Conversions.ToString(Motor.GetMotorInfo(1))
				If Conversions.ToBoolean(Motor.GetMotorInfo(5)) Then
					text3 += " ultra-high slip motor"
				End If
				Dim str3 As String = Conversions.ToString(Motor.GetMotorInfo(3))
				Dim text4 As String = Conversions.ToString(Motor.GetMotorInfo(2))
				If Strings.Len(text4) > 0 Then
					text4 = "Prime mover setting: " + text4
				End If
				Dim tabStop5 As Object = 1
				text2 = "Prime mover type: " + text3
				RESULTS1.MkLine(tabStop5, text2, True)
				Dim tabStop6 As Object = 1
				text2 = "Prime mover size: " + str3
				RESULTS1.MkLine(tabStop6, text2, True)
				RESULTS1.MkLine(1, text4, True)
				Dim tabStop7 As Object = 0
				text2 = ""
				RESULTS1.MkLine(tabStop7, text2, True)
				If rst.MotorSPV = 0F Then
					Dim tabStop8 As Object = 1
					text2 = "Prime mover speed variation effects not included"
					RESULTS1.MkLine(tabStop8, text2, True)
				Else
					Dim tabStop9 As Object = 1
					Dim str4 As String = "Prime mover speed variation: "
					cRODSTAR = rst
					num = cRODSTAR.MotorSPV
					text2 = "0.0%"
					Dim str5 As String = Util.Format(num, text2)
					cRODSTAR.MotorSPV = num
					text = Conversions.ToString(Operators.AddObject(str4 + str5, Interaction.IIf(rst.CalcMotorSPV <> 0S, array(0), array(1))))
					RESULTS1.MkLine(tabStop9, text, True)
				End If
			End If
			Dim tabStop10 As Object = 0
			text2 = ""
			RESULTS1.MkLine(tabStop10, text2, True)
			Dim tabStop11 As Object = 1
			text2 = "ENERGY CONSUMPTION"
			RESULTS1.MkLine(tabStop11, text2, True)
			Dim tabStop12 As Object = 1
			text2 = New String(ChrW(3), 75)
			RESULTS1.MkLine(tabStop12, text2, True)
			Dim tabStop13 As Object = 1
			text2 = "Power meter type: " + str
			RESULTS1.MkLine(tabStop13, text2, True)
			Dim tabStop14 As Object = 1
			Dim str6 As String = "Electricity cost: $"
			cRODSTAR = rst
			num = cRODSTAR.ElectricityCost
			text2 = "0.00#"
			Dim str7 As String = Util.Format(num, text2)
			cRODSTAR.ElectricityCost = num
			text = str6 + str7 + "/KWH"
			RESULTS1.MkLine(tabStop14, text, True)
			Dim str8 As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				str8 = "barrel"
			Else
				str8 = "m³"
			End If
			RESULTS1.MkBEHeader()
			text2 = "Daily electricity consumption (KWH/day):"
			cRODSTAR = rst
			array2 = cRODSTAR.MotorKWH
			Dim efactor7 As Single = 1F
			Dim mfactor7 As Single = 1F
			Dim etoM7 As Single = 1F
			text = "###0"
			RESULTS1.MkLineBE(text2, array2, efactor7, mfactor7, etoM7, text, True)
			cRODSTAR.MotorKWH = array2
			text2 = "Monthly electric bill:"
			cRODSTAR = rst
			array2 = cRODSTAR.ElectricBillperMonth
			Dim efactor8 As Single = 1F
			Dim mfactor8 As Single = 1F
			Dim etoM8 As Single = 1F
			text = "$0"
			RESULTS1.MkLineBE(text2, array2, efactor8, mfactor8, etoM8, text, True)
			cRODSTAR.ElectricBillperMonth = array2
			text2 = "Electricity cost per " + str8 + " of fluid:"
			cRODSTAR = rst
			array2 = cRODSTAR.DollarsPerBblFluid
			Dim efactor9 As Single = 1F
			Dim mfactor9 As Single = 1F
			Dim etoM9 As Single = 1F / RSWIN_DESC.BPD__M3D
			text = "$0.00"
			RESULTS1.MkLineBE(text2, array2, efactor9, mfactor9, etoM9, text, False)
			cRODSTAR.DollarsPerBblFluid = array2
			If rst.WaterCut < 100F Then
				text2 = "Electricity cost per " + str8 + " of oil:"
				cRODSTAR = rst
				array2 = cRODSTAR.DollarsPerBblOil
				Dim efactor10 As Single = 1F
				Dim mfactor10 As Single = 1F
				Dim etoM10 As Single = 1F / RSWIN_DESC.BPD__M3D
				text = "$0.00"
				RESULTS1.MkLineBE(text2, array2, efactor10, mfactor10, etoM10, text, False)
				cRODSTAR.DollarsPerBblOil = array2
			End If
		End Sub

		Public Sub ShowRodStringCost()
		End Sub

		Public Sub ShowSummary()
			Dim array As Short() = New Short() { Conversions.ToShort(" (calc.)"), Conversions.ToShort(RSWIN_DESC.sNull) }
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim text As String
			Dim num As Short
			If rst.UnknownM Then
				text = "Balanced"
				num = 1S
			Else
				text = "Existing"
				num = 2S
			End If
			Dim str As String = "Production rate"
			Dim bpdsurface As Single = rst.BPDsurface
			Dim bpd__M3D As Single = RSWIN_DESC.BPD__M3D
			Dim text2 As String = "0"
			Dim text3 As String = "0.0"
			Dim text4 As String = str + RESULTS1.MkVal(bpdsurface, bpd__M3D, RSWIN_DESC.bfpd, text2, RSWIN_DESC.m3D, text3, 3)
			Dim str2 As String = " Peak polished rod load"
			Dim pprload As Single = rst.Pprload
			Dim lb__N As Single = RSWIN_DESC.LB__N
			Dim text5 As String = "0"
			Dim text6 As String = "0"
			Dim text7 As String = str2 + RESULTS1.MkVal(pprload, lb__N, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text6, 1)
			RESULTS1.MkLine2(text4, text7)
			Dim str3 As String = "Strokes per minute: "
			Dim cRODSTAR As cRODSTAR = rst
			Dim num2 As Single = cRODSTAR.SPM
			text7 = "0.0#"
			Dim str4 As String = Util.Format(num2, text7)
			cRODSTAR.SPM = num2
			text5 = Convert.ToString(Operators.AddObject(Convert.ToDouble(str3 + str4), Interaction.IIf(Not rst.SPMEntered <> 0S, " (calc.)", "")))
			Dim str5 As String = " Min. polished rod load"
			Dim mprload As Single = rst.Mprload
			Dim lb__N2 As Single = RSWIN_DESC.LB__N
			text4 = "0"
			text6 = "0"
			text3 = str5 + RESULTS1.MkVal(mprload, lb__N2, RSWIN_DESC.lbs, text4, RSWIN_DESC.N, text6, 1)
			RESULTS1.MkLine2(text5, text3)
			Dim str7 As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				Dim str6 As String = "power (kW): "
				Dim num3 As Double = CDbl(rst.Prhp) * 0.746
				text7 = "0.0"
				str7 = str6 + Util.Format(num3, text7)
			Else
				Dim str8 As String = "horsepower: "
				cRODSTAR = rst
				num2 = cRODSTAR.Prhp
				text7 = "0.0"
				Dim str9 As String = Util.Format(num2, text7)
				cRODSTAR.Prhp = num2
				str7 = str8 + str9
			End If
			Dim str10 As String = "Run time (hrs/day): "
			cRODSTAR = rst
			num2 = cRODSTAR.Runtime
			text7 = "0.0"
			Dim str11 As String = Util.Format(num2, text7)
			cRODSTAR.Runtime = num2
			text4 = str10 + str11
			text6 = " Polished rod " + str7
			RESULTS1.MkLine2(text4, text6)
			Dim str12 As String = "Surface stroke"
			Dim kinematicStroke As Single = rst.PU.KinematicStroke
			Dim in__CM As Single = RSWIN_DESC.IN__CM
			text7 = "0.0"
			text4 = "0.0"
			text5 = str12 + RESULTS1.MkVal3(kinematicStroke, in__CM, RSWIN_DESC.ins, text7, RSWIN_DESC.cm, text4)
			Dim str13 As String = " N/No': "
			cRODSTAR = rst
			num2 = cRODSTAR.NoverNoP
			text6 = "0.0##"
			Dim str14 As String = Util.Format(num2, text6)
			cRODSTAR.NoverNoP = num2
			text3 = str13 + str14
			RESULTS1.MkLine2(text5, text3)
			Dim str15 As String = "Water specific gravity: "
			cRODSTAR = rst
			num2 = cRODSTAR.WaterSPGR
			text7 = "0.0##"
			Dim str16 As String = Util.Format(num2, text7)
			cRODSTAR.WaterSPGR = num2
			text6 = str15 + str16
			Dim str17 As String = " Fo/SKr: "
			Dim cRODSTAR2 As cRODSTAR = rst
			Dim num4 As Single = cRODSTAR2.FoSkr
			text4 = "0.0##"
			Dim str18 As String = Util.Format(num4, text4)
			cRODSTAR2.FoSkr = num4
			text5 = str17 + str18
			RESULTS1.MkLine2(text6, text5)
			Dim str19 As String = "Water cut: "
			cRODSTAR2 = rst
			num4 = cRODSTAR2.WaterCut
			text7 = "0"
			Dim str20 As String = Util.Format(num4, text7)
			cRODSTAR2.WaterCut = num4
			text6 = str19 + str20 + "%"
			Dim str21 As String = " System efficiency (Motor->Pump): "
			cRODSTAR = rst
			num2 = cRODSTAR.SystemEff
			text4 = "0%"
			Dim str22 As String = Util.Format(num2, text4)
			cRODSTAR.SystemEff = num2
			text5 = str21 + str22
			RESULTS1.MkLine2(text6, text5)
			Dim text8 As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				Dim str23 As String = "Oil density (g/cm³): "
				Dim num3 As Double = 141.5 / (131.5 + CDbl(rst.OilAPI))
				text7 = "0.00"
				text8 = str23 + Util.Format(num3, text7)
			Else
				Dim str24 As String = "Oil API gravity: "
				cRODSTAR2 = rst
				num4 = cRODSTAR2.OilAPI
				text7 = "0.0#"
				Dim str25 As String = Util.Format(num4, text7)
				cRODSTAR2.OilAPI = num4
				text8 = str24 + str25
			End If
			Dim str26 As String = " "
			Dim str27 As String = text
			Dim str28 As String = " elect. cost"
			Dim v As Single = rst.DollarsPerBblFluid(CInt(num))
			Dim etoM As Single = 1F / RSWIN_DESC.BPD__M3D
			text7 = "$/bf"
			text4 = "#.00#"
			text6 = "$/m³f"
			text5 = "#.00#"
			text3 = str26 + str27 + str28 + RESULTS1.MkVal(v, etoM, text7, text4, text6, text5, 3)
			RESULTS1.MkLine2(text8, text3)
			Dim str29 As String = "Fluid specific gravity: "
			cRODSTAR2 = rst
			num4 = cRODSTAR2.FluidSPGR
			text7 = "0.0##"
			Dim str30 As String = Util.Format(num4, text7)
			cRODSTAR2.FluidSPGR = num4
			text2 = str29 + str30
			Dim str31 As String = " "
			Dim str32 As String = text
			Dim str33 As String = " elect. cost"
			Dim v2 As Single = rst.DollarsPerBblOil(CInt(num))
			Dim etoM2 As Single = 1F / RSWIN_DESC.BPD__M3D
			text4 = "$/bo"
			text6 = "#.00#"
			text5 = "$/m³o"
			text3 = "#.00#"
			Dim sNull As String = str31 + str32 + str33 + RESULTS1.MkVal(v2, etoM2, text4, text6, text5, text3, 3)
			RESULTS1.MkLine2(text2, sNull)
			sNull = RSWIN_DESC.sNull
			text7 = ""
			RESULTS1.MkLine2(sNull, text7)
			RSWIN_DESC.sNull = sNull
			Dim text9 As String
			If rst.FluidLevelEntered Then
				Dim str34 As String = "Fl. level from surface"
				Dim fluidLevel As Single = rst.FluidLevel
				Dim ft__M As Single = RSWIN_DESC.FT__M
				sNull = "0"
				text7 = "m"
				text4 = "0.0"
				text9 = str34 + RESULTS1.MkVal(fluidLevel, ft__M, RSWIN_DESC.ft, sNull, text7, text4, 3)
			Else
				Dim str35 As String = "Pump intake pressure"
				Dim pumpIntakePressure As Single = rst.PumpIntakePressure
				Dim psi__KPA As Single = RSWIN_DESC.PSI__KPA
				sNull = "0"
				text7 = "0"
				text9 = str35 + RESULTS1.MkVal(pumpIntakePressure, psi__KPA, RSWIN_DESC.psi, sNull, RSWIN_DESC.kPa, text7, 3)
			End If
			Dim str36 As String = " "
			Dim str37 As String = text
			Dim str38 As String = " min. req. motor HP: "
			cRODSTAR2 = rst
			num4 = cRODSTAR2.MinMotorHP
			sNull = "0"
			Dim str39 As String = Util.Format(num4, sNull)
			cRODSTAR2.MinMotorHP = num4
			text7 = str36 + str37 + str38 + str39
			RESULTS1.MkLine2(text9, text7)
			Dim text10 As String
			If rst.StructL > 1F Then
				text10 = "*"
			Else
				text10 = " "
			End If
			Dim obj As Object = "Fl. lev."
			Dim v3 As Single = rst.PumpDepth - rst.FluidLevel
			Dim ft__M2 As Single = RSWIN_DESC.FT__M
			sNull = RSWIN_DESC.ft + " over pump"
			text7 = "0"
			text4 = "m over pump"
			text6 = "0"
			text3 = Conversions.ToString(Operators.ConcatenateObject(obj, Operators.AddObject(RESULTS1.MkVal(v3, ft__M2, sNull, text7, text4, text6, 3), Interaction.IIf(Not rst.FluidLevelEntered, array(0), array(1)))))
			Dim str40 As String = text10
			Dim str41 As String = "Unit structure loading: "
			cRODSTAR2 = rst
			num4 = cRODSTAR2.StructL
			text5 = "0%"
			Dim str42 As String = Util.Format(num4, text5)
			cRODSTAR2.StructL = num4
			text2 = str40 + str41 + str42
			RESULTS1.MkLine2(text3, text2)
			Dim str43 As String
			If rst.UnknownM Then
				Dim gearboxLoading As Single() = rst.GearboxLoading
				Dim num5 As Integer = 1
				sNull = "0%"
				str43 = Util.Format(gearboxLoading(num5), sNull)
				If rst.GearboxLoading(1) > 1F Then
					text10 = "*"
				Else
					text10 = " "
				End If
			Else
				Dim gearboxLoading2 As Single() = rst.GearboxLoading
				Dim num6 As Integer = 2
				sNull = "0%"
				str43 = Util.Format(gearboxLoading2(num6), sNull)
				If rst.GearboxLoading(2) > 1F Then
					text10 = "*"
				Else
					text10 = " "
				End If
			End If
			Dim str44 As String = "Tubing pressure"
			Dim tubingPressure As Single = rst.TubingPressure
			Dim psi__KPA2 As Single = RSWIN_DESC.PSI__KPA
			sNull = "0.0"
			text7 = "0.0"
			text4 = str44 + RESULTS1.MkVal(tubingPressure, psi__KPA2, RSWIN_DESC.psi, sNull, RSWIN_DESC.kPa, text7, 3)
			text6 = text10 + text + " gearbox loading: " + str43
			RESULTS1.MkLine2(text4, text6)
			If rst.MaxRodStressL > 1F Then
				text10 = "*"
			Else
				text10 = " "
			End If
			Dim str45 As String = "Casing pressure"
			Dim casingPressure As Single = rst.CasingPressure
			Dim psi__KPA3 As Single = RSWIN_DESC.PSI__KPA
			sNull = "0.0"
			text7 = "0.0"
			text6 = str45 + RESULTS1.MkVal(casingPressure, psi__KPA3, RSWIN_DESC.psi, sNull, RSWIN_DESC.kPa, text7, 3)
			Dim str46 As String = text10
			Dim str47 As String = "Maximum rod loading: "
			cRODSTAR2 = rst
			num4 = cRODSTAR2.MaxRodStressL
			text4 = "0%"
			Dim str48 As String = Util.Format(num4, text4)
			cRODSTAR2.MaxRodStressL = num4
			text5 = str46 + str47 + str48
			RESULTS1.MkLine2(text6, text5)
			Dim str49 As String = "Buoyant weight of rods"
			Dim wrodsInFluid As Single = rst.WrodsInFluid
			Dim lb__N3 As Single = RSWIN_DESC.LB__N
			sNull = "0"
			text7 = "0"
			text5 = str49 + RESULTS1.MkVal(wrodsInFluid, lb__N3, RSWIN_DESC.lbs, sNull, RSWIN_DESC.N, text7, 1)
			Dim str50 As String = " Fluid load on pump"
			Dim fluidLoad As Single = rst.FluidLoad
			Dim lb__N4 As Single = RSWIN_DESC.LB__N
			text4 = "0"
			text6 = "0"
			text3 = str50 + RESULTS1.MkVal(fluidLoad, lb__N4, RSWIN_DESC.lbs, text4, RSWIN_DESC.N, text6, 1)
			RESULTS1.MkLine2(text5, text3)
			If MImpred.FluidInertiaPossible() Then
				If rst.IncludeFluidInertia <> 0S Then
					sNull = "Fluid inertia effects included"
					Dim str51 As String = " Compressibility index: "
					cRODSTAR2 = rst
					Dim obj2 As Object = cRODSTAR2.CompressibilityIndex
					Dim str52 As String = Util.Format(obj2)
					cRODSTAR2.CompressibilityIndex = Conversions.ToSingle(obj2)
					text7 = str51 + str52
					RESULTS1.MkLine2(sNull, text7)
				Else
					sNull = "Fluid inertia effects not included"
					text7 = ""
					RESULTS1.MkLine2(sNull, text7)
				End If
			End If
		End Sub

		Public Sub ShowTitle(iPage As Short)
			Dim text As String = RSWIN_DESC.sProgramLongName
			Dim num As Integer = SUPERPRO.SentinelSerialNumber()
			Dim text2 As String = "#"
			Dim text3 As String = Util.Format(num, text2)
			If Strings.Len(text3) > 0 Then
				text = text + " (SN#" + text3 + ")"
			End If
			Dim text4 As String = Util.Licensee()
			If Strings.Len(text4) > 0 Then
				text = text + " - Licensed to " + text4
			End If
			Dim expression As String = "* * *  " + text + "  * * *"
			Dim expression2 As String = "(C) Theta Oilfield Services, Inc."
			Dim expression3 As String = "Tel: (562) 694-3297"
			Dim num2 As Short = CShort(Math.Round(CDbl((75 - Strings.Len(expression))) / 2.0))
			Dim num3 As Short = CShort(Math.Round(CDbl((75 - Strings.Len(expression2))) / 2.0))
			Dim num4 As Short = CShort(Math.Round(CDbl((75 - Strings.Len(expression3))) / 2.0))
			Dim tabStop As Object = 0
			text2 = ""
			RESULTS1.MkLine(tabStop, text2, True)
			Dim tabStop2 As Object = 0
			text2 = ""
			RESULTS1.MkLine(tabStop2, text2, True)
			Dim tabStop3 As Object = 0
			text2 = ""
			RESULTS1.MkLine(tabStop3, text2, True)
			RESULTS1.MkLine(num2, expression, True)
			Dim tabStop4 As Object = 1
			text2 = "Page" + Conversion.Str(iPage)
			RESULTS1.MkLine(tabStop4, text2, False)
			RESULTS1.MkLine(num3, expression2, True)
			RESULTS1.MkLine(num3, expression3, True)
		End Sub

		Public Sub ShowTorqueAnalysis()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim text As String
			If rst.MotorSPV > 0F And (rst.Irot > 0F Or rst.Iart > 0F) Then
				Dim tabStop As Object = 1
				text = "TORQUE ANALYSIS (pumping unit inertia effects included)"
				RESULTS1.MkLine(tabStop, text, True)
			Else
				Dim tabStop2 As Object = 1
				text = "TORQUE ANALYSIS"
				RESULTS1.MkLine(tabStop2, text, True)
			End If
			Dim tabStop3 As Object = 1
			text = New String(ChrW(3), 75)
			RESULTS1.MkLine(tabStop3, text, True)
			RESULTS1.MkBEHeader()
			Dim str As String
			Dim str2 As String
			Dim str3 As String
			Dim str4 As String
			Dim str5 As String
			Dim str6 As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				str = "(N-m):"
				str2 = "(kPa):"
				str3 = "(N):"
				str4 = "(N-m):"
				str5 = "(N):"
				str6 = "(N):"
			Else
				str = "(M in-lbs):"
				str2 = "(psig):"
				str3 = "(M lbs):"
				str4 = "(M in-lbs):"
				str5 = "(lbs):"
				str6 = "(lbs):"
			End If
			text = "Peak gearbox torque " + str
			Dim cRODSTAR As cRODSTAR = rst
			Dim array As Single() = cRODSTAR.PeakTorque
			Dim efactor As Single = 0.001F
			Dim mfactor As Single = 0.001F
			Dim minlb__NM As Single = RSWIN_DESC.MINLB__NM
			Dim text2 As String = "0"
			RESULTS1.MkLineBE(text, array, efactor, mfactor, minlb__NM, text2, True)
			cRODSTAR.PeakTorque = array
			text2 = "Gearbox loading:"
			cRODSTAR = rst
			array = cRODSTAR.GearboxLoading
			Dim efactor2 As Single = 1F
			Dim mfactor2 As Single = 1F
			Dim etoM As Single = 1F
			text = "0%"
			RESULTS1.MkLineBE(text2, array, efactor2, mfactor2, etoM, text, True)
			cRODSTAR.GearboxLoading = array
			text2 = "Cyclic load factor:"
			cRODSTAR = rst
			array = cRODSTAR.Clf
			Dim efactor3 As Single = 1F
			Dim mfactor3 As Single = 1F
			Dim etoM2 As Single = 1F
			text = "0.0#"
			RESULTS1.MkLineBE(text2, array, efactor3, mfactor3, etoM2, text, True)
			cRODSTAR.Clf = array
			If rst.PU.UnitType = 6S Then
				text2 = "Air tank pressure, bottom of stroke " + str2
				cRODSTAR = rst
				array = cRODSTAR.M
				Dim efactor4 As Single = 1F
				Dim mfactor4 As Single = 1F
				Dim psi__KPA As Single = RSWIN_DESC.PSI__KPA
				text = "0"
				RESULTS1.MkLineBE(text2, array, efactor4, mfactor4, psi__KPA, text, True)
				cRODSTAR.M = array
			ElseIf rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Then
				text2 = "Counterbalance weight " + str3
				cRODSTAR = rst
				array = cRODSTAR.M
				Dim efactor5 As Single = 0.001F
				Dim mfactor5 As Single = 1F
				Dim lb__N As Single = RSWIN_DESC.LB__N
				text = "0.00"
				RESULTS1.MkLineBE(text2, array, efactor5, mfactor5, lb__N, text, True)
				cRODSTAR.M = array
			ElseIf rst.PU.UnitType = 8S Then
				text2 = "Required Unbalance " + str6
				cRODSTAR = rst
				array = cRODSTAR.RequiredUnbalance
				Dim efactor6 As Single = 0.001F
				Dim mfactor6 As Single = 0.001F
				Dim lb__N2 As Single = RSWIN_DESC.LB__N
				text = "0.00"
				RESULTS1.MkLineBE(text2, array, efactor6, mfactor6, lb__N2, text, True)
				cRODSTAR.RequiredUnbalance = array
				text2 = "Counterbalance effect " + str5
				cRODSTAR = rst
				array = cRODSTAR.CBE90
				Dim efactor7 As Single = 1F
				Dim mfactor7 As Single = 1F
				Dim etoM3 As Single = 1F
				text = "0"
				RESULTS1.MkLineBE(text2, array, efactor7, mfactor7, etoM3, text, True)
				cRODSTAR.CBE90 = array
			Else
				text2 = "Maximum counterbalance moment " + str4
				cRODSTAR = rst
				array = cRODSTAR.M
				Dim efactor8 As Single = 0.001F
				Dim mfactor8 As Single = 0.001F
				Dim minlb__NM2 As Single = RSWIN_DESC.MINLB__NM
				text = "0.00"
				RESULTS1.MkLineBE(text2, array, efactor8, mfactor8, minlb__NM2, text, True)
				cRODSTAR.M = array
				text2 = "Counterbalance effect " + str5
				cRODSTAR = rst
				array = cRODSTAR.CBE90
				Dim efactor9 As Single = 1F
				Dim mfactor9 As Single = 1F
				Dim etoM4 As Single = 1F
				text = "0"
				RESULTS1.MkLineBE(text2, array, efactor9, mfactor9, etoM4, text, True)
				cRODSTAR.CBE90 = array
			End If
		End Sub

		Public Sub ShowTubing()
			Dim array As Short() = New Short() { Conversions.ToShort(" (calc.)"), Conversions.ToShort(RSWIN_DESC.sNull) }
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim str As String
			Select Case rst.PumpType
				Case 1S
					str = "Insert"
				Case 2S
					str = "Tubing"
				Case 3S
					str = "Large bore"
			End Select
			Dim str2 As String
			Select Case rst.PumpCondition
				Case 1S
					str2 = "Full pump"
				Case 2S
					str2 = "Fluid pound"
				Case 3S
					str2 = "Gas interference"
			End Select
			Dim tabStop As Object = 1
			Dim text As String = "TUBING"
			RESULTS1.MkLine(tabStop, text, False)
			Dim tabStop2 As Object = 37
			text = " PUMP"
			RESULTS1.MkLine(tabStop2, text, True)
			Dim tabStop3 As Object = 1
			text = New String(ChrW(3), 36)
			RESULTS1.MkLine(tabStop3, text, False)
			Dim tabStop4 As Object = 0
			text = ChrW(2)
			RESULTS1.MkLine(tabStop4, text, False)
			Dim tabStop5 As Object = 0
			text = New String(ChrW(3), 38)
			RESULTS1.MkLine(tabStop5, text, True)
			Dim str3 As String = "Tubing O.D."
			Dim tubingOD As Single = rst.TubingOD
			Dim in__MM As Single = RSWIN_DESC.IN__MM
			text = "0.0##"
			Dim text2 As String = "0.0"
			Dim text3 As String = str3 + RESULTS1.MkVal3(tubingOD, in__MM, RSWIN_DESC.ins, text, RSWIN_DESC.mm, text2)
			Dim str4 As String = " Pump depth"
			Dim pumpDepth As Single = rst.PumpDepth
			Dim ft__M As Single = RSWIN_DESC.FT__M
			Dim text4 As String = "0"
			Dim text5 As String = "m"
			Dim sNull As String = "0"
			Dim text6 As String = str4 + RESULTS1.MkVal(pumpDepth, ft__M, RSWIN_DESC.ft, text4, text5, sNull, 3)
			RESULTS1.MkLine2(text3, text6)
			Dim str5 As String = "Tubing I.D."
			Dim tubingID As Single = rst.TubingID
			Dim in__MM2 As Single = RSWIN_DESC.IN__MM
			text6 = "0.0##"
			text3 = "0.0"
			sNull = str5 + RESULTS1.MkVal3(tubingID, in__MM2, RSWIN_DESC.ins, text6, RSWIN_DESC.mm, text3)
			text5 = " Pump condition: " + str2
			RESULTS1.MkLine2(sNull, text5)
			Dim text7 As String
			If rst.TubingAnchored <> 0S Then
				Dim str6 As String = "anchor depth"
				Dim tubingAnchorDepth As Single = rst.TubingAnchorDepth
				Dim ft__M2 As Single = RSWIN_DESC.FT__M
				text6 = "0"
				text3 = "m"
				sNull = "0.0"
				text7 = str6 + RESULTS1.MkVal(tubingAnchorDepth, ft__M2, RSWIN_DESC.ft, text6, text3, sNull, 3)
			Else
				text7 = "is not anchored"
			End If
			text6 = "Tubing " + text7
			text3 = " Pump type: " + str
			RESULTS1.MkLine2(text6, text3)
			Dim str7 As String = "Tubing stretch"
			Dim tubStretch As Single = rst.TubStretch
			Dim in__CM As Single = RSWIN_DESC.IN__CM
			text6 = "0.0"
			text3 = "0.0"
			text4 = str7 + RESULTS1.MkVal3(tubStretch, in__CM, RSWIN_DESC.ins, text6, RSWIN_DESC.cm, text3)
			Dim str8 As String = " Pump friction"
			Dim pumpFriction As Single = rst.PumpFriction
			Dim lb__N As Single = RSWIN_DESC.LB__N
			sNull = "0"
			text5 = "0"
			text2 = str8 + RESULTS1.MkVal(pumpFriction, lb__N, RSWIN_DESC.lbs, sNull, RSWIN_DESC.N, text5, 1)
			RESULTS1.MkLine2(text4, text2)
			Dim str9 As String = "Upstr. rod-tub. frict: "
			Dim cRODSTAR As cRODSTAR = rst
			Dim num As Single = cRODSTAR.UpstrokeFriction
			text6 = "0.0#"
			Dim str10 As String = Util.Format(num, text6)
			cRODSTAR.UpstrokeFriction = num
			text5 = Conversions.ToString(Operators.AddObject(str9 + str10, Interaction.IIf(rst.CalcFriction <> 0S, array(0), array(1))))
			Dim str11 As String = " Plunger size"
			Dim plungerSize As Single = rst.PlungerSize
			Dim in__MM3 As Single = RSWIN_DESC.IN__MM
			text3 = "0.0##"
			sNull = "0.0"
			text4 = Conversions.ToString(Operators.AddObject(str11 + RESULTS1.MkVal3(plungerSize, in__MM3, RSWIN_DESC.ins, text3, RSWIN_DESC.mm, sNull), Interaction.IIf(rst.CalcPlungerSize <> 0S, array(0), array(1))))
			RESULTS1.MkLine2(text5, text4)
			Dim str12 As String = "Downs. rod-tub. frict: "
			cRODSTAR = rst
			num = cRODSTAR.DownstrokeFriction
			text6 = "0.0#"
			Dim str13 As String = Util.Format(num, text6)
			cRODSTAR.DownstrokeFriction = num
			text5 = Convert.ToString(Convert.ToDouble(str12 + str13) + CDbl(array(CInt(rst.CalcFriction))))
			Dim str14 As String = " Gross pump stroke"
			Dim grossPumpStroke As Single = rst.GrossPumpStroke
			Dim in__CM2 As Single = RSWIN_DESC.IN__CM
			text3 = "0"
			sNull = "0.0"
			text4 = str14 + RESULTS1.MkVal(grossPumpStroke, in__CM2, RSWIN_DESC.ins, text3, RSWIN_DESC.cm, sNull, 1)
			RESULTS1.MkLine2(text5, text4)
			If rst.gbCalcPumpCondition And rst.PumpCondition = 2S Then
				text7 = " Calculated pump fillage: "
			Else
				text7 = " Assumed pump volum. efficiency: "
			End If
			Dim str15 As String = "Stuffing box friction"
			Dim stuffingBoxFriction As Single = rst.StuffingBoxFriction
			Dim lb__N2 As Single = RSWIN_DESC.LB__N
			text6 = "0"
			text3 = "0"
			text5 = str15 + RESULTS1.MkVal(stuffingBoxFriction, lb__N2, RSWIN_DESC.lbs, text6, RSWIN_DESC.N, text3, 1)
			Dim str16 As String = text7
			cRODSTAR = rst
			num = cRODSTAR.Pfill
			sNull = "0%"
			Dim str17 As String = Util.Format(num, sNull)
			cRODSTAR.Pfill = num
			text4 = str16 + str17
			RESULTS1.MkLine2(text5, text4)
			Dim str18 As String = "Pump load adjustment"
			Dim pumpLoadAdj As Single = rst.PumpLoadAdj
			Dim lb__N3 As Single = RSWIN_DESC.LB__N
			text6 = "0"
			text3 = "0"
			text = str18 + RESULTS1.MkVal(pumpLoadAdj, lb__N3, RSWIN_DESC.lbs, text6, RSWIN_DESC.N, text3, 1)
			Dim str19 As String = " Pump spacing"
			Dim pumpSpacing As Single = rst.PumpSpacing
			Dim in__CM3 As Single = RSWIN_DESC.IN__CM
			sNull = "in. from botm."
			text5 = "0.0"
			text4 = "cm from botm."
			text2 = "0"
			Dim text8 As String = str19 + RESULTS1.MkVal(pumpSpacing, in__CM3, sNull, text5, text4, text2, 1)
			RESULTS1.MkLine2(text, text8)
			Dim text9 As String = ""
			If rst.ProductionLoss >= 1F Then
				Dim str20 As String = "Prod.loss due to stretch"
				Dim productionLoss As Single = rst.ProductionLoss
				Dim bpd__M3D As Single = RSWIN_DESC.BPD__M3D
				text8 = "0"
				text6 = "0.0"
				text9 = str20 + RESULTS1.MkVal(productionLoss, bpd__M3D, RSWIN_DESC.bfpd, text8, RSWIN_DESC.m3D, text6, 3)
			End If
			Dim str21 As String = " Minimum pump length"
			Dim pumpLength As Single = rst.PumpLength
			Dim ft__M3 As Single = RSWIN_DESC.FT__M
			text8 = "0.0"
			text6 = "m"
			text3 = "0.0"
			sNull = str21 + RESULTS1.MkVal(pumpLength, ft__M3, RSWIN_DESC.ft, text8, text6, text3, 1)
			RESULTS1.MkLine2(text9, sNull)
			sNull = RSWIN_DESC.sNull
			Dim str22 As String = " Recom. plunger length"
			Dim plungerLength As Single = rst.PlungerLength
			Dim ft__M4 As Single = RSWIN_DESC.FT__M
			text8 = "0.0"
			text6 = "m"
			text3 = "0.0"
			text5 = str22 + RESULTS1.MkVal(plungerLength, ft__M4, RSWIN_DESC.ft, text8, text6, text3, 1)
			RESULTS1.MkLine2(sNull, text5)
			RSWIN_DESC.sNull = sNull
		End Sub

		Public Sub SummBE(ByRef Label As String, ByRef v As Single(), EFactor As Single, MFactor As Single, EtoM As Single, ByRef Fmt As String, bCisE As Object)
			Dim text As String = Strings.Space(30)
			text = Strings.LSet(" " + Label, Strings.Len(text))
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Short
			If(RSWIN_DESC.rst.PU.UnitType <> 8S And rst.get_M(0) = rst.get_M(1)) Or (RSWIN_DESC.rst.PU.UnitType = 8S And rst.get_RequiredUnbalance(0) = rst.get_RequiredUnbalance(1)) Then
				num = 1S
			Else
				num = 0S
			End If
			Dim num2 As Short = num
			Dim num3 As Short = If((-If((rst.UnknownM > False), 1S, 0S)), 1S, 0S)
			For num4 As Short = num2 To num3
				Dim text2 As String = Strings.Space(8)
				Dim num5 As Short
				If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					num5 = Conversions.ToShort(Operators.NotObject(bCisE))
				Else
					num5 = If((-If(((RSWIN_DESC.SETUP_MeasurementSystem = 3) > False), 1S, 0S)), 1S, 0S)
				End If
				If num5 <> 0S Then
					Dim num6 As Single = v(CInt(num4)) * MFactor * EtoM
					text2 = Strings.LSet(Util.Format(num6, Fmt), Strings.Len(text2))
				Else
					Dim num6 As Single = v(CInt(num4)) * EFactor
					text2 = Strings.LSet(Util.Format(num6, Fmt), Strings.Len(text2))
				End If
				text += text2
				If num4 <> If((-If((rst.UnknownM > False), 1S, 0S)), 1S, 0S) Then
					text += ChrW(1) & "  "
				End If
			Next
			RESULTS1.AddRLine(text)
		End Sub

		Public Sub SummBEHeader(ByRef t1 As String, ByRef t2 As String)
			Dim text As String = " BALANCED "
			Dim str As String = " EXISTING "
			Dim str2 As String = "(Min Ener)"
			Dim str3 As String = "(Min Torq)"
			Dim text2 As String = ChrW(4)
			Dim text3 As String = ChrW(1)
			Dim text4 As String = New String(ChrW(3), 10)
			Dim text5 As String = Strings.Space(28)
			text5 = Strings.LSet(" " + t1, Strings.Len(text5))
			Dim text6 As String = Strings.Space(28)
			text6 = Strings.LSet(" " + t2, Strings.Len(text6))
			Dim text7 As String = " " + New String(ChrW(3), 27)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If(RSWIN_DESC.rst.PU.UnitType <> 8S And rst.get_M(0) = rst.get_M(1)) Or (RSWIN_DESC.rst.PU.UnitType = 8S And rst.get_RequiredUnbalance(0) = rst.get_RequiredUnbalance(1)) Then
				text6 += text
				text7 += text4
				If Not rst.UnknownM Then
					text6 = text6 + text3 + str
					text7 = text7 + text2 + text4
				End If
			Else
				text5 = text5 + text + text3 + text
				text6 = text6 + str2 + text3 + str3
				text7 = text7 + text4 + text2 + text4
				If Not rst.UnknownM Then
					text5 = text5 + text3 + str
					text6 += text3
					text7 = text7 + text2 + text4
				End If
			End If
			RESULTS1.AddRLine(text5)
			RESULTS1.AddRLine(text6)
			RESULTS1.AddRLine(text7)
		End Sub

		Public Sub SummCalculations()
			Dim sLine As String = Strings.Space(60)
			StringType.MidStmtStr(sLine, 24, 18, "CALCULATED RESULTS")
			RESULTS1.AddRLine(sLine)
			RESULTS1.AddRLine(New String(ChrW(3), 60))
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Not rst.gbOutputLoaded Then
				RESULTS1.AddRLine(" The calculations have not been run for this case.")
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
			Else
				Dim str As String
				If rst.UnknownM Then
					str = "Balanced"
				Else
					str = "Existing"
				End If
				Dim w As Object = 32
				Dim text As String = " Peak pol. rod load"
				Dim pprload As Single = rst.Pprload
				Dim lb__N As Single = RSWIN_DESC.LB__N
				Dim text2 As String = "0"
				Dim text3 As String = "0"
				RESULTS1.AddRLine(RESULTS1.MkSummEM(w, text, pprload, lb__N, RSWIN_DESC.lbs, text2, RSWIN_DESC.N, text3, 1, False, False) + "  " + str + " minimum")
				Dim w2 As Object = 32
				text3 = " Min. pol. rod load"
				Dim mprload As Single = rst.Mprload
				Dim lb__N2 As Single = RSWIN_DESC.LB__N
				text2 = "0"
				text = "0"
				Dim str2 As String = RESULTS1.MkSummEM(w2, text3, mprload, lb__N2, RSWIN_DESC.lbs, text2, RSWIN_DESC.N, text, 1, False, False)
				Dim w3 As Object = 27
				Dim text4 As String = "   required motor HP:"
				Dim minMotorHP As Single = rst.MinMotorHP
				Dim text5 As String = "0.0"
				RESULTS1.AddRLine(str2 + RESULTS1.MkSumm(w3, text4, minMotorHP, text5, False, False))
				Dim str3 As String
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					Dim w4 As Object = 27
					text5 = "  PRP (kW): "
					Dim value As Single = CSng((CDbl(rst.Prhp) * 0.746))
					text4 = "0.0"
					str3 = RESULTS1.MkSumm(w4, text5, value, text4, False, False)
				Else
					Dim w5 As Object = 27
					text5 = "  PRHP: "
					Dim prhp As Single = rst.Prhp
					text4 = "0.0"
					str3 = RESULTS1.MkSumm(w5, text5, prhp, text4, False, False)
				End If
				Dim w6 As Object = 32
				text5 = " System eff. (Motor->Pump):"
				Dim systemEff As Single = rst.SystemEff
				text4 = "0%"
				RESULTS1.AddRLine(RESULTS1.MkSumm(w6, text5, systemEff, text4, False, False) + str3)
				Dim w7 As Object = 32
				text5 = " Fluid load on pump"
				Dim fluidLoad As Single = rst.FluidLoad
				Dim lb__N3 As Single = RSWIN_DESC.LB__N
				text4 = "0"
				text3 = "0"
				Dim str4 As String = RESULTS1.MkSummEM(w7, text5, fluidLoad, lb__N3, RSWIN_DESC.lbs, text4, RSWIN_DESC.N, text3, 1, False, False)
				Dim w8 As Object = 27
				text2 = "  Unit struct. loading:"
				Dim structL As Single = rst.StructL
				text = "0%"
				RESULTS1.AddRLine(str4 + RESULTS1.MkSumm(w8, text2, structL, text, False, False))
				Dim array As String() = New String(4) {}
				Dim array2 As String() = array
				Dim num As Integer = 0
				Dim w9 As Object = 32
				text3 = " Buoyant rod weight"
				Dim wrodsInFluid As Single = rst.WrodsInFluid
				Dim lb__N4 As Single = RSWIN_DESC.LB__N
				text2 = "0"
				text = "0"
				array2(num) = RESULTS1.MkSummEM(w9, text3, wrodsInFluid, lb__N4, RSWIN_DESC.lbs, text2, RSWIN_DESC.N, text, 1, False, False)
				array(1) = "  N/No':"
				Dim array3 As String() = array
				Dim num2 As Integer = 2
				Dim cRODSTAR As cRODSTAR = rst
				Dim noverNoP As Single = cRODSTAR.NoverNoP
				text4 = "0.000"
				Dim text6 As String = Util.Format(noverNoP, text4)
				cRODSTAR.NoverNoP = noverNoP
				array3(num2) = text6
				array(3) = ", Fo/SKr:"
				Dim array4 As String() = array
				Dim num3 As Integer = 4
				Dim cRODSTAR2 As cRODSTAR = rst
				Dim foSkr As Single = cRODSTAR2.FoSkr
				text5 = "0.000"
				Dim text7 As String = Util.Format(foSkr, text5)
				cRODSTAR2.FoSkr = foSkr
				array4(num3) = text7
				RESULTS1.AddRLine(String.Concat(array))
				Dim w10 As Object = 32
				text5 = " Production rate"
				Dim bpdsurface As Single = rst.BPDsurface
				Dim bpd__M3D As Single = RSWIN_DESC.BPD__M3D
				text4 = "0"
				text3 = "0.0"
				Dim str5 As String = RESULTS1.MkSummEM(w10, text5, bpdsurface, bpd__M3D, RSWIN_DESC.bfpd, text4, RSWIN_DESC.m3D, text3, 3, False, False)
				Dim w11 As Object = 27
				text2 = "  Oil production"
				Dim v As Single = rst.BPDsurface * (1F - rst.WaterCut / 100F)
				Dim bpd__M3D2 As Single = RSWIN_DESC.BPD__M3D
				text = "BOPD"
				Dim text8 As String = "0"
				Dim text9 As String = "0.0"
				RESULTS1.AddRLine(str5 + RESULTS1.MkSummEM(w11, text2, v, bpd__M3D2, text, text8, RSWIN_DESC.m3D, text9, 3, False, False))
				Dim str6 As String
				If rst.SPMEntered <> 0S Then
					str6 = ""
				Else
					Dim w12 As Object = 27
					text9 = "  Strokes per minute:"
					Dim spm As Single = rst.SPM
					text8 = "0.0#"
					str6 = RESULTS1.MkSumm(w12, text9, spm, text8, False, False)
				End If
				RESULTS1.AddRLine(Strings.Space(32) + str6)
			End If
			RESULTS1.AddRLine(RSWIN_DESC.sNull)
		End Sub

		Public Sub SummFluidAndMotor()
			RESULTS1.AddLLine("Fluid properties           Motor & power meter")
			RESULTS1.AddLLine(New String(ChrW(3), 24) + Strings.Space(3) + New String(ChrW(3), 21))
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim str As String
			Select Case rst.PowerMeterType
				Case 1S
					str = "Detent"
				Case 2S
					str = "Non-detent"
			End Select
			Dim w As Object = 24
			Dim text As String = "Water cut:"
			Dim value As Single = rst.WaterCut / 100F
			Dim text2 As String = "0%"
			RESULTS1.AddLLine(RESULTS1.MkSumm(w, text, value, text2, False, False) + "   Power meter: " + str)
			Dim w2 As Object = 24
			text = "Water sp. gravity:"
			Dim waterSPGR As Single = rst.WaterSPGR
			Dim text3 As String = "0.0##"
			Dim str2 As String = RESULTS1.MkSumm(w2, text, waterSPGR, text3, False, False)
			Dim str3 As String = "   Electr. cost: $"
			Dim cRODSTAR As cRODSTAR = rst
			Dim electricityCost As Single = cRODSTAR.ElectricityCost
			text2 = "#.00#"
			Dim str4 As String = Util.Format(electricityCost, text2)
			cRODSTAR.ElectricityCost = electricityCost
			RESULTS1.AddLLine(str2 + str3 + str4 + "/KWH")
			Dim motorInfo As Object = Motor.GetMotorInfo(4)
			Dim text4 As String
			If Operators.ConditionalCompareObjectEqual(motorInfo, 2, False) Then
				text4 = "Sargent EP-II ODP"
			ElseIf Operators.ConditionalCompareObjectEqual(motorInfo, 4, False) Then
				text4 = "Sargent EP-II TEFC"
			Else
				text4 = Conversions.ToString(Motor.GetMotorInfo(1))
			End If
			Dim str5 As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				Dim w3 As Object = 24
				text3 = "Oil density (g/cm³): "
				Dim value2 As Single = CSng((141.5 / (131.5 + CDbl(rst.OilAPI))))
				text2 = "0.00"
				str5 = RESULTS1.MkSumm(w3, text3, value2, text2, False, False)
			Else
				Dim w4 As Object = 24
				text3 = "Oil API gravity: "
				Dim oilAPI As Single = rst.OilAPI
				text2 = "0.0#"
				str5 = RESULTS1.MkSumm(w4, text3, oilAPI, text2, False, False)
			End If
			RESULTS1.AddLLine(str5 + "   Type: " + text4)
			If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), rst.CalcMotorSize)) Then
				text4 = ""
			Else
				text4 = Conversions.ToString(Motor.GetMotorInfo(3))
				If Strings.InStr(Strings.UCase(text4), "SIZE ", CompareMethod.Binary) = 1 Then
					text4 = Strings.Mid(text4, 6)
				End If
				text4 = "Size: " + text4
			End If
			Dim w5 As Object = 24
			text3 = "Fluid sp. gravity:"
			Dim fluidSPGR As Single = rst.FluidSPGR
			text2 = "0.0##"
			RESULTS1.AddLLine(RESULTS1.MkSumm(w5, text3, fluidSPGR, text2, False, False) + "   " + text4)
			Dim str6 As String
			If(If((-If((Not MImpred.FluidInertiaPossible() > False), 1S, 0S)), 1S, 0S) Or Not rst.IncludeFluidInertia) <> 0S Then
				str6 = Strings.Space(24)
			Else
				Dim w6 As Object = 24
				text3 = "Compress. index:"
				Dim compressibilityIndex As Single = rst.CompressibilityIndex
				text2 = "0.00"
				str6 = RESULTS1.MkSumm(w6, text3, compressibilityIndex, text2, False, False)
			End If
			Dim text5 As String = Conversions.ToString(Motor.GetMotorInfo(2))
			If Strings.Len(text5) > 0 Then
				Dim num As Short = CShort(Strings.InStr(text5, "Medium/Low", CompareMethod.Binary))
				If num > 0S Then
					text5 = Strings.Left(text5, CInt((num - 1S))) + "M/Low" + Strings.Mid(text5, CInt((num + 10S)))
				End If
				text5 = "Mode: " + text5
			End If
			RESULTS1.AddLLine(str6 + "   " + text5)
			RESULTS1.AddLLine(RSWIN_DESC.sNull)
		End Sub

		Public Sub SummHeader(iPage As Short, nPages As Short)
			Dim text As String = New String(" "c, 112)
			Dim text2 As String = RSWIN_DESC.sProgramLongName
			Dim num As Integer = SUPERPRO.SentinelSerialNumber()
			Dim text3 As String = "#"
			Dim text4 As String = Util.Format(num, text3)
			If Strings.Len(text4) > 0 Then
				text2 = text2 + " (SN#" + text4 + ")"
			End If
			If Strings.Len(Util.Licensee()) > 0 Then
				text2 = text2 + " - Licensed to " + Util.Licensee()
			End If
			text2 = "  * * *  " + text2 + "  * * *  "
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			text = ""
			StringType.MidStmtStr(text, (Strings.Len(text) - Strings.Len(text2)) / 2, Strings.Len(text2), text2)
			RESULTS1.SendLine(text)
			text = ""
			text = Strings.LSet("Company: " + Strings.Trim(rst.ACompanyName), Strings.Len(text))
			Dim text5 As String
			If iPage >= 1S Then
				text5 = "Page " + Conversions.ToString(CInt(iPage)) + "/" + Conversions.ToString(CInt(nPages))
				StringType.MidStmtStr(text, Strings.Len(text) - Strings.Len(text5) + 1, Strings.Len(text5), text5)
			End If
			RESULTS1.SendLine(text)
			text = ""
			text = Strings.LSet("Well: " + Strings.Trim(rst.WellName), Strings.Len(text))
			Dim text6 As String = RESULTS1.sThetaEnterprises
			StringType.MidStmtStr(text, (Strings.Len(text) - Strings.Len(text6)) / 2, Strings.Len(text6), text6)
			text5 = "User: " + Strings.Trim(rst.UserName)
			StringType.MidStmtStr(text, Strings.Len(text) - Strings.Len(text5) + 1, Strings.Len(text5), text5)
			RESULTS1.SendLine(text)
			text = ""
			text = Strings.LSet("Disk file: " + Util.FileName(rst.Inputfile), Strings.Len(text))
			Dim text7 As String = "Tel: (562) 694-3297"
			StringType.MidStmtStr(text, (Strings.Len(text) - Strings.Len(text7)) / 2, Strings.Len(text7), text7)
			text5 = "Date: " + Strings.Trim(rst.UserDate)
			StringType.MidStmtStr(text, Strings.Len(text) - Strings.Len(text5) + 1, Strings.Len(text5), text5)
			RESULTS1.SendLine(text)
			text = ""
			text = Strings.LSet("Comment: " + Strings.Left(rst.FileComment, 100), Strings.Len(text))
			RESULTS1.SendLine(text)
			RESULTS1.SendLine(New String("_"c, Strings.Len(text)))
			RESULTS1.SendLine(RSWIN_DESC.sNull)
		End Sub

		Public Sub SummInitialize()
			RESULTS1.lLines = New String(0) {}
			RESULTS1.RLines = New String(0) {}
		End Sub

		Public Sub SummMiscInput()
			Dim sLine As String = Strings.Space(51)
			StringType.MidStmtStr(sLine, 20, 10, "INPUT DATA")
			RESULTS1.AddLLine(sLine)
			RESULTS1.AddLLine(New String(ChrW(3), 51))
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim text As String
			Dim text2 As String
			Dim str As String
			Dim text3 As String
			If rst.SPMEntered <> 0S Then
				Dim w As Object = 24
				text = "Strokes per minute:"
				Dim spm As Single = rst.SPM
				text2 = "0.0#"
				str = RESULTS1.MkSumm(w, text, spm, text2, False, False)
			Else
				Dim w2 As Object = 24
				text2 = "Target prod."
				Dim targetBFPD As Single = rst.TargetBFPD
				Dim bpd__M3D As Single = RSWIN_DESC.BPD__M3D
				text = "0"
				text3 = "0.0"
				str = RESULTS1.MkSummEM(w2, text2, targetBFPD, bpd__M3D, RSWIN_DESC.bfpd, text, RSWIN_DESC.m3D, text3, 3, False, False)
			End If
			Dim w3 As Object = 24
			text3 = "Run time (hrs/day):"
			Dim runtime As Single = rst.Runtime
			text2 = "0.0"
			Dim str2 As String = RESULTS1.MkSumm(w3, text3, runtime, text2, False, False)
			Dim text4 As String
			Dim text5 As String
			Dim text6 As String
			Dim str3 As String
			If rst.FluidLevelEntered Then
				text4 = "Fluid level"
				Dim w4 As Object = 24
				text3 = ""
				Dim fluidLevel As Single = rst.FluidLevel
				Dim ft__M As Single = RSWIN_DESC.FT__M
				text2 = RSWIN_DESC.ft + " from surface"
				text = "0"
				text5 = "m from surface"
				text6 = "0.0"
				str3 = RESULTS1.MkSummEM(w4, text3, fluidLevel, ft__M, text2, text, text5, text6, 3, False, False)
			Else
				Dim w5 As Object = 24
				text6 = "Pump int. pr."
				Dim pumpIntakePressure As Single = rst.PumpIntakePressure
				Dim psi__KPA As Single = RSWIN_DESC.PSI__KPA
				text5 = "0"
				text3 = "0"
				text4 = RESULTS1.MkSummEM(w5, text6, pumpIntakePressure, psi__KPA, RSWIN_DESC.psi, text5, RSWIN_DESC.kPa, text3, 3, False, False)
				If rst.gbCalcPumpIntakePressure Then
					text4 = ChrW(5) + text4 + Conversions.ToString(Strings.Chr(255))
				End If
				str3 = "Fluid level"
			End If
			RESULTS1.AddLLine(str + "  " + text4)
			RESULTS1.AddLLine(str2 + "  " + str3)
			Dim w6 As Object = 24
			Dim text7 As String = "Tubing pres."
			Dim tubingPressure As Single = rst.TubingPressure
			Dim psi__KPA2 As Single = RSWIN_DESC.PSI__KPA
			Dim text8 As String = "0.0"
			Dim text9 As String = "0.0"
			Dim str4 As String = RESULTS1.MkSummEM(w6, text7, tubingPressure, psi__KPA2, RSWIN_DESC.psi, text8, RSWIN_DESC.kPa, text9, 3, False, False)
			Dim str5 As String = "  "
			Dim w7 As Object = 24
			text6 = ""
			Dim v As Single = rst.PumpDepth - rst.FluidLevel
			Dim ft__M2 As Single = RSWIN_DESC.FT__M
			text5 = RSWIN_DESC.ft + " over pump"
			text3 = "0"
			text2 = "m over pump"
			text = "0.0"
			RESULTS1.AddLLine(str4 + str5 + RESULTS1.MkSummEM(w7, text6, v, ft__M2, text5, text3, text2, text, 3, False, False))
			Dim w8 As Object = 24
			text6 = "Casing pres."
			Dim casingPressure As Single = rst.CasingPressure
			Dim psi__KPA3 As Single = RSWIN_DESC.PSI__KPA
			text5 = "0.0"
			text3 = "0.0"
			Dim str6 As String = RESULTS1.MkSummEM(w8, text6, casingPressure, psi__KPA3, RSWIN_DESC.psi, text5, RSWIN_DESC.kPa, text3, 3, False, False)
			Dim str7 As String = "  "
			Dim w9 As Object = 24
			text9 = "Stuf.box fr."
			Dim stuffingBoxFriction As Single = rst.StuffingBoxFriction
			Dim lb__N As Single = RSWIN_DESC.LB__N
			text8 = "0"
			text7 = "0"
			RESULTS1.AddLLine(str6 + str7 + RESULTS1.MkSummEM(w9, text9, stuffingBoxFriction, lb__N, RSWIN_DESC.lbs, text8, RSWIN_DESC.N, text7, 1, False, False))
			RESULTS1.AddLLine(RSWIN_DESC.sNull)
			RESULTS1.AddLLine(RSWIN_DESC.sNull)
		End Sub

		Public Sub SummPrimeMoverSize()
			Dim array As String() = New String() { "calc. ", "" }
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Not rst.gbOutputLoaded Then
				RESULTS1.AddRLine(" Prime mover speed variation")
				RESULTS1.AddRLine(" " + New String(ChrW(3), 27))
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
			ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), rst.CalcMotorSize)) Then
				Dim text As String = "Required prime mover size"
				Dim text2 As String
				Dim cRODSTAR As cRODSTAR
				Dim text3 As String
				If rst.MotorSPV = 0F Then
					text2 = " (speed var. not included)"
				Else
					Dim array2 As String() = New String(4) {}
					array2(0) = " ("
					array2(1) = array(CInt(rst.CalcMotorSPV))
					array2(2) = "speed var.: "
					Dim array3 As String() = array2
					Dim num As Integer = 3
					cRODSTAR = rst
					Dim motorSPV As Single = cRODSTAR.MotorSPV
					text3 = "0.0%"
					Dim text4 As String = Util.Format(motorSPV, text3)
					cRODSTAR.MotorSPV = motorSPV
					array3(num) = text4
					array2(4) = ")"
					text2 = String.Concat(array2)
				End If
				RESULTS1.SummBEHeader(text, text2)
				Dim array4 As Single()
				Dim text5 As String
				If Operators.ConditionalCompareObjectEqual(Motor.GetMotorInfo(4), 7, False) Then
					text3 = "Marathon NEMA B motor:"
					cRODSTAR = rst
					array4 = cRODSTAR.HpNemaD
					Dim efactor As Single = 1F
					Dim mfactor As Single = 1F
					Dim etoM As Single = 1F
					text5 = "##0 \HP"
					RESULTS1.SummBE(text3, array4, efactor, mfactor, etoM, text5, True)
					cRODSTAR.HpNemaD = array4
				ElseIf Operators.ConditionalCompareObjectEqual(Motor.GetMotorInfo(4), 8, False) Then
					text5 = "Tatung NEMA B motor:"
					cRODSTAR = rst
					array4 = cRODSTAR.HpNemaD
					Dim efactor2 As Single = 1F
					Dim mfactor2 As Single = 1F
					Dim etoM2 As Single = 1F
					text3 = "##0 \HP"
					RESULTS1.SummBE(text5, array4, efactor2, mfactor2, etoM2, text3, True)
					cRODSTAR.HpNemaD = array4
				ElseIf Operators.ConditionalCompareObjectGreater(Motor.GetMotorInfo(4), 8, False) Then
					text5 = RESULTS1.GetMotorName(Conversions.ToInteger(Motor.GetMotorInfo(4))) + " motor:"
					cRODSTAR = rst
					array4 = cRODSTAR.HpNemaD
					Dim efactor3 As Single = 1F
					Dim mfactor3 As Single = 1F
					Dim etoM3 As Single = 1F
					text3 = "##0 \HP"
					RESULTS1.SummBE(text5, array4, efactor3, mfactor3, etoM3, text3, True)
					cRODSTAR.HpNemaD = array4
				Else
					text5 = "NEMA D motor:"
					cRODSTAR = rst
					array4 = cRODSTAR.HpNemaD
					Dim efactor4 As Single = 1F
					Dim mfactor4 As Single = 1F
					Dim etoM4 As Single = 1F
					text3 = "##0 \HP"
					RESULTS1.SummBE(text5, array4, efactor4, mfactor4, etoM4, text3, True)
					cRODSTAR.HpNemaD = array4
				End If
				text5 = "Single/double cyl. engine:"
				cRODSTAR = rst
				array4 = cRODSTAR.HpUhs
				Dim efactor5 As Single = 1F
				Dim mfactor5 As Single = 1F
				Dim etoM5 As Single = 1F
				text3 = "##0 \HP"
				RESULTS1.SummBE(text5, array4, efactor5, mfactor5, etoM5, text3, True)
				cRODSTAR.HpUhs = array4
				text5 = "Multicylinder engine:"
				cRODSTAR = rst
				array4 = cRODSTAR.HpNemaD
				Dim efactor6 As Single = 1F
				Dim mfactor6 As Single = 1F
				Dim etoM6 As Single = 1F
				text3 = "##0 \HP"
				RESULTS1.SummBE(text5, array4, efactor6, mfactor6, etoM6, text3, True)
				cRODSTAR.HpNemaD = array4
			Else
				RESULTS1.AddRLine(" Prime mover speed variation")
				RESULTS1.AddRLine(" " + New String(ChrW(3), 27))
				If rst.CalcMotorSPV <> 0S Then
					Dim w As Object = 39
					Dim text5 As String = " Calculated speed variation:"
					Dim motorSPV2 As Single = rst.MotorSPV
					Dim text3 As String = "0.0%"
					RESULTS1.AddRLine(RESULTS1.MkSumm(w, text5, motorSPV2, text3, False, False))
				ElseIf rst.MotorSPV > 0F Then
					Dim w2 As Object = 39
					Dim text5 As String = " Entered speed variation:"
					Dim motorSPV3 As Single = rst.MotorSPV
					Dim text3 As String = "0.0%"
					RESULTS1.AddRLine(RESULTS1.MkSumm(w2, text5, motorSPV3, text3, False, False))
				Else
					RESULTS1.AddRLine(" Speed variation not considered")
				End If
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
				RESULTS1.AddRLine(RSWIN_DESC.sNull)
			End If
			RESULTS1.AddRLine(RSWIN_DESC.sNull)
		End Sub

		Public Sub SummPrint()
			Dim num As Short = 1S
			While CInt(num) <= Information.UBound(RESULTS1.lLines, 1) Or CInt(num) <= Information.UBound(RESULTS1.RLines, 1)
				Dim text As String
				If CInt(num) > Information.UBound(RESULTS1.lLines, 1) Then
					text = ""
				Else
					Dim num2 As Short = 51S
					Dim num3 As Short = 1S
					Dim num4 As Short = CShort(Strings.Len(RESULTS1.lLines(CInt(num))))
					For num5 As Short = num3 To num4
						Dim num6 As Integer = Strings.Asc(Strings.Mid(RESULTS1.lLines(CInt(num)), CInt(num5), 1))
						If num6 = 5 OrElse num6 = 255 Then
							num2 += 1S
						End If
					Next
					text = Strings.Space(CInt(num2))
					text = Strings.LSet(RESULTS1.lLines(CInt(num)), Strings.Len(text))
				End If
				Dim text2 As String
				If CInt(num) > Information.UBound(RESULTS1.RLines, 1) Then
					text2 = ""
				Else
					Dim num2 As Short = 60S
					Dim num7 As Short = 1S
					Dim num8 As Short = CShort(Strings.Len(RESULTS1.RLines(CInt(num))))
					For num5 As Short = num7 To num8
						Dim num9 As Integer = Strings.Asc(Strings.Mid(RESULTS1.RLines(CInt(num)), CInt(num5), 1))
						If num9 = 5 OrElse num9 = 255 Then
							num2 += 1S
						End If
					Next
					text2 = Strings.Space(CInt(num2))
					text2 = Strings.LSet(RESULTS1.RLines(CInt(num)), Strings.Len(text2))
				End If
				RESULTS1.SendLine(text + ChrW(1) + text2)
				num += 1S
			End While
		End Sub

		Public Sub SummPumpingUnit()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim text3 As String
			Dim text4 As String
			Dim text5 As String
			Dim str As String
			Dim str2 As String
			Dim str3 As String
			Dim str4 As String
			Dim str5 As String
			Dim str6 As String
			Dim str7 As String
			Dim str8 As String
			Dim str9 As String
			If(Not rst.IDEntered And If((-If(((rst.PU.UnitType <> 7S) > False), 1S, 0S)), 1S, 0S) And If((-If(((rst.PU.UnitType <> 10S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				Dim w As Object = 10
				Dim text As String = "R"
				Dim r As Single = rst.PU.R
				Dim in__CM As Single = RSWIN_DESC.IN__CM
				Dim text2 As String = ""
				text3 = "0.0##"
				text4 = ""
				text5 = "0.0##"
				str = RESULTS1.MkSummEM(w, text, r, in__CM, text2, text3, text4, text5, 1, False, False)
				Dim w2 As Object = 10
				text5 = "A"
				Dim a As Single = rst.PU.A
				Dim in__CM2 As Single = RSWIN_DESC.IN__CM
				text4 = ""
				text3 = "0.0##"
				text2 = ""
				text = "0.0##"
				str2 = RESULTS1.MkSummEM(w2, text5, a, in__CM2, text4, text3, text2, text, 1, False, False)
				Dim w3 As Object = 10
				text5 = "C"
				Dim c As Single = rst.PU.C
				Dim in__CM3 As Single = RSWIN_DESC.IN__CM
				text4 = ""
				text3 = "0.0##"
				text2 = ""
				text = "0.0##"
				str3 = RESULTS1.MkSummEM(w3, text5, c, in__CM3, text4, text3, text2, text, 1, False, False)
				Dim w4 As Object = 10
				text5 = "I"
				Dim i As Single = rst.PU.I
				Dim in__CM4 As Single = RSWIN_DESC.IN__CM
				text4 = ""
				text3 = "0.0##"
				text2 = ""
				text = "0.0##"
				str4 = RESULTS1.MkSummEM(w4, text5, i, in__CM4, text4, text3, text2, text, 1, False, False)
				Dim w5 As Object = 10
				text5 = "K"
				Dim k As Single = rst.PU.K
				Dim in__CM5 As Single = RSWIN_DESC.IN__CM
				text4 = ""
				text3 = "0.0##"
				text2 = ""
				text = "0.0##"
				str5 = RESULTS1.MkSummEM(w5, text5, k, in__CM5, text4, text3, text2, text, 1, False, False)
				Dim w6 As Object = 10
				text5 = "P"
				Dim p As Single = rst.PU.P
				Dim in__CM6 As Single = RSWIN_DESC.IN__CM
				text4 = ""
				text3 = "0.0##"
				text2 = ""
				text = "0.0##"
				str6 = RESULTS1.MkSummEM(w6, text5, p, in__CM6, text4, text3, text2, text, 1, False, False)
				If rst.PU.UnitType = 6S Then
					Dim w7 As Object = 10
					text5 = "M"
					Dim m As Single = rst.PU.M
					Dim etoM As Single = 6.4516F
					text4 = ""
					text3 = "0.0##"
					text2 = ""
					text = "0.0##"
					str7 = RESULTS1.MkSummEM(w7, text5, m, etoM, text4, text3, text2, text, 1, False, False)
					Dim w8 As Object = 10
					text5 = "S"
					Dim s As Single = rst.PU.S
					Dim etoM2 As Single = 6.894757F
					text4 = ""
					text3 = "0.0##"
					text2 = ""
					text = "0.0##"
					str8 = RESULTS1.MkSummEM(w8, text5, s, etoM2, text4, text3, text2, text, 1, False, False)
					Dim w9 As Object = 10
					text5 = "V0"
					Dim v As Single = rst.PU.V0
					Dim etoM3 As Single = 16.38706F
					text4 = ""
					text3 = "0.0##"
					text2 = ""
					text = "0.0##"
					str9 = RESULTS1.MkSummEM(w9, text5, v, etoM3, text4, text3, text2, text, 1, False, False)
				End If
			End If
			Dim text6 As String = "Pumping Unit: " + Strings.Trim(rst.PU.Manuf)
			Dim text7 As String = RESULTS1.VTrim(rst.PU.UnitName)
			Dim text10 As String
			Dim str10 As String
			Dim text11 As String
			Dim str11 As String
			Dim text12 As String
			Dim text13 As String
			Dim num As Short = CShort(Strings.Len(text7))
			Dim text8 As String = RESULTS1.VTrim(rst.PU.OtherInfo)
			Dim num2 As Short = CShort(Strings.Len(text8))
			If num > 0S Then
				If Strings.Len(text6) + CInt(num) + 3 > 50 Then
					text7 = Strings.Left(text7, 46 - Strings.Len(text6)) + "*"
				End If
				text6 = text6 + " (" + text7 + ")"
			ElseIf num2 > 0S Then
				If Strings.Len(text6) + CInt(num2) + 2 > 49 Then
					text8 = Strings.Left(text8, 47 - Strings.Len(text6)) + "*"
				End If
				text6 = text6 + "; " + text8
			End If
			RESULTS1.AddLLine(text6)
			RESULTS1.AddLLine(New String(ChrW(3), 50))
			Dim text9 As String
			If RSWIN_DESC.rst.PU.UnitType = 10S Then
				text9 = "Unit size: " + RESULTS1.VTrim(rst.PU.APIDesignation)
			Else
				text9 = "API size: " + RESULTS1.VTrim(rst.PU.APIDesignation)
			End If
			If rst.IDEntered <> 0S Then
				text9 = text9 + " (unit ID: " + Strings.Trim(rst.UnitID) + ")"
			End If
			RESULTS1.AddLLine(text9)
			If rst.IDEntered <> 0S Then
				Dim array As String() = New String(4) {}
				array(0) = "Crank hole #"
				Dim array2 As String() = array
				Dim num3 As Integer = 1
				Dim obj As Object = rst.PU.CrankHole
				array2(num3) = Util.Format(obj)
				array(2) = " (out of "
				Dim array3 As String() = array
				Dim num4 As Integer = 3
				Dim obj2 As Object = rst.PU.CrankHoles
				array3(num4) = Util.Format(obj2)
				array(4) = ")"
				text10 = String.Concat(array)
			Else
				text10 = Strings.Space(40) + str
			End If
			RESULTS1.AddLLine(text10)
			Dim w10 As Object = 36
			text5 = "Calculated stroke length"
			Dim kinematicStroke As Single = rst.PU.KinematicStroke
			Dim in__CM7 As Single = RSWIN_DESC.IN__CM
			text4 = "0.0"
			text3 = "0.0"
			text10 = RESULTS1.MkSummEM(w10, text5, kinematicStroke, in__CM7, RSWIN_DESC.ins, text4, RSWIN_DESC.cm, text3, 1, False, False)
			If Not rst.IDEntered <> 0S Then
				text10 = text10 + "    " + str2
			End If
			RESULTS1.AddLLine(text10)
			Select Case rst.PU.CrankRotation
				Case -1S
					text10 = "#""CCW"""
				Case 1S
					text10 = "#""CW"""
			End Select
			Dim w11 As Object = 36
			text5 = "Rotation with well to right:"
			text10 = RESULTS1.MkSumm(w11, text5, 0F, text10, False, False)
			If Not rst.IDEntered <> 0S Then
				text10 = text10 + "    " + str3
			End If
			RESULTS1.AddLLine(text10)
			str10 = Strings.Space(36)
			text11 = Strings.Space(36)
			str11 = Strings.Space(36)
			text12 = Strings.Space(36)
			If Strings.Len(rst.CBDataFile) > 0 Then
				If Strings.InStr(rst.CBDataFile.ToLower(), ".xblx", CompareMethod.Binary) > 0 Then
					text12 = Strings.LSet("XBAL file: """ + Util.FileName(rst.CBDataFile) + """", Strings.Len(text12))
				Else
					text12 = Strings.LSet("CBALANCE file: """ + Util.FileName(rst.CBDataFile) + """", Strings.Len(text12))
				End If
			End If
			text13 = "#""Unknown"""
			Dim str12 As String
			Dim str13 As String
			Select Case rst.PU.UnitType
				Case 6S
					str12 = "Air tank pressure at"
					text10 = "  bottom-of-stroke"
					If rst.UnknownM Then
						Dim w12 As Object = 36
						Dim v2 As Single = 0F
						Dim etoM4 As Single = 1F
						text5 = "psig"
						str13 = RESULTS1.MkSummEM(w12, text10, v2, etoM4, text5, text13, RSWIN_DESC.kPa, text13, 1, False, False)
						GoTo IL_BBE
					End If
					Dim w13 As Object = 36
					Dim v3 As Single = rst.get_M(2)
					Dim psi__KPA As Single = RSWIN_DESC.PSI__KPA
					text5 = "psig"
					text4 = "0"
					text3 = "0"
					str13 = RESULTS1.MkSummEM(w13, text10, v3, psi__KPA, text5, text4, RSWIN_DESC.kPa, text3, 1, False, False)
					GoTo IL_BBE
				Case 7S, 10S
					text10 = "Max. CB weight"
					If rst.UnknownM Then
						Dim w14 As Object = 36
						Dim v4 As Single = 0F
						Dim etoM5 As Single = 1F
						text5 = "M lbs"
						str12 = RESULTS1.MkSummEM(w14, text10, v4, etoM5, text5, text13, RSWIN_DESC.N, text13, 1, False, False)
					Else
						Dim w15 As Object = 36
						Dim v5 As Single = rst.get_M(2) / 1000F
						Dim etoM6 As Single = RSWIN_DESC.LB__N * 1000F
						text5 = "M lbs"
						text4 = "0.0"
						text3 = "0.0"
						str12 = RESULTS1.MkSummEM(w15, text10, v5, etoM6, text5, text4, RSWIN_DESC.N, text3, 1, False, False)
					End If
					If Not rst.IDEntered <> 0S Then
						Dim w16 As Object = 36
						text5 = "Sprocket radius"
						Dim sprocketRadius As Single = rst.PU.SprocketRadius
						Dim in__CM8 As Single = RSWIN_DESC.IN__CM
						text4 = "0.0"
						text3 = "0.0"
						str13 = RESULTS1.MkSummEM(w16, text5, sprocketRadius, in__CM8, RSWIN_DESC.ins, text4, RSWIN_DESC.cm, text3, 1, False, False)
						Dim w17 As Object = 36
						text5 = "C'line sprocket distance"
						Dim sprocketDistance As Single = rst.PU.SprocketDistance
						Dim in__CM9 As Single = RSWIN_DESC.IN__CM
						text4 = "0.0"
						text3 = "0.0"
						str10 = RESULTS1.MkSummEM(w17, text5, sprocketDistance, in__CM9, RSWIN_DESC.ins, text4, RSWIN_DESC.cm, text3, 1, False, False)
						Dim w18 As Object = 36
						text5 = "Drum diameter ratio:"
						Dim drumDiamRatio As Single = rst.PU.DrumDiamRatio
						text4 = "0.0#"
						text11 = RESULTS1.MkSumm(w18, text5, drumDiamRatio, text4, False, False)
						If rst.PU.P > 0F Then
							Dim w19 As Object = 36
							text5 = "Pitman arm length"
							Dim p2 As Single = rst.PU.P
							Dim in__CM10 As Single = RSWIN_DESC.IN__CM
							text4 = "0.0"
							text3 = "0.0"
							str11 = RESULTS1.MkSummEM(w19, text5, p2, in__CM10, RSWIN_DESC.ins, text4, RSWIN_DESC.cm, text3, 1, False, False)
						End If
						GoTo IL_BBE
					End If
					GoTo IL_BBE
			End Select
			text10 = "Max. CB moment"
			If rst.UnknownM Then
				str12 = RESULTS1.MkSummEM(36, text10, 0F, 1F, RSWIN_DESC.Minlbs, text13, RSWIN_DESC.Nm, text13, 1, False, False)
			Else
				Dim w20 As Object = 36
				Dim v6 As Single = rst.get_M(2) / 1000F
				Dim minlb__NM As Single = RSWIN_DESC.MINLB__NM
				text5 = "0"
				text4 = "0"
				str12 = RESULTS1.MkSummEM(w20, text10, v6, minlb__NM, RSWIN_DESC.Minlbs, text5, RSWIN_DESC.Nm, text4, 1, False, False)
			End If
			Dim w21 As Object = 36
			text5 = "Structural unbalance"
			Dim unbalance As Single = rst.PU.Unbalance
			Dim lb__N As Single = RSWIN_DESC.LB__N
			text4 = "0"
			text3 = "0"
			str13 = RESULTS1.MkSummEM(w21, text5, unbalance, lb__N, RSWIN_DESC.lbs, text4, RSWIN_DESC.N, text3, 1, False, False)
			Dim w22 As Object = 36
			text5 = "Crank offset angle (deg):"
			Dim value As Single = CSng((CDbl((rst.PU.CrankOffset * 180F)) / 3.141592653589793))
			text4 = "0.0"
			str10 = RESULTS1.MkSumm(w22, text5, value, text4, False, False)
			If rst.MotorSPV > 0F Then
				Dim w23 As Object = 36
				text5 = "Rot. inertia"
				Dim irot As Single = rst.Irot
				Dim lbft2__KGM As Single = RSWIN_DESC.LBFT2__KGM2
				text4 = "lb-ft²"
				text3 = "0"
				Dim text2 As String = "kg-m²"
				Dim text As String = "0"
				text11 = RESULTS1.MkSummEM(w23, text5, irot, lbft2__KGM, text4, text3, text2, text, 1, False, False)
				If Not rst.IrotEntered <> 0S Then
					text11 = ChrW(5) + text11 + Conversions.ToString(Strings.Chr(255))
				End If
				Dim w24 As Object = 36
				text5 = "Art. inertia"
				Dim iart As Single = rst.Iart
				Dim lbft2__KGM2 As Single = RSWIN_DESC.LBFT2__KGM2
				text4 = "lb-ft²"
				text3 = "0"
				text2 = "kg-m²"
				text = "0"
				str11 = RESULTS1.MkSummEM(w24, text5, iart, lbft2__KGM2, text4, text3, text2, text, 1, False, False)
			End If
			IL_BBE:
			RESULTS1.AddLLine(str12 + "    " + str4)
			RESULTS1.AddLLine(str13 + "    " + str5)
			RESULTS1.AddLLine(str10 + "    " + str6)
			RESULTS1.AddLLine(text11 + "    " + str7)
			RESULTS1.AddLLine(str11 + "    " + str8)
			RESULTS1.AddLLine(text12 + "   " + str9)
		End Sub

		Public Sub SummRSCalc()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim str As String = " Rod string stress analysis (service factor: "
			Dim cRODSTAR As cRODSTAR = rst
			Dim serviceFactor As Single = cRODSTAR.ServiceFactor
			Dim text As String = "0.0"
			Dim str2 As String = Util.Format(serviceFactor, text)
			cRODSTAR.ServiceFactor = serviceFactor
			RESULTS1.AddRLine(str + str2 + ")")
			RESULTS1.AddRLine(" " + New String(ChrW(3), 62))
			Dim sLine As String = "  Stress|Top Maximum |Top Minimum |Bot. Minimum|Stress Calc."
			Dim sLine2 As String = "  Load %|Stress (psi)|Stress (psi)|Stress (psi)|   Method   "
			Dim sLine3 As String = " -------+------------+------------+------------+------------"
			RESULTS1.Trx(sLine, "|", ChrW(1))
			RESULTS1.Trx(sLine2, "|", ChrW(1))
			RESULTS1.Trx(sLine3, "-", ChrW(3))
			RESULTS1.Trx(sLine3, "+", ChrW(4))
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				StringType.MidStmtStr(sLine2, 18, 3, RSWIN_DESC.kPa)
				StringType.MidStmtStr(sLine2, 31, 3, RSWIN_DESC.kPa)
				StringType.MidStmtStr(sLine2, 44, 3, RSWIN_DESC.kPa)
			End If
			RESULTS1.AddRLine(sLine)
			RESULTS1.AddRLine(sLine2)
			RESULTS1.AddRLine(sLine3)
			Dim num As Short = 1S
			Dim numRods As Short = rst.NumRods
			For num2 As Short = num To numRods
				Dim sVal As String
				Dim sVal2 As String
				Dim sVal3 As String
				Dim sVal4 As String
				If Not rst.gbOutputLoaded Then
					sVal = ""
					sVal2 = ""
					sVal3 = ""
					sVal4 = ""
				Else
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						serviceFactor = rst.maxStressTop(CInt(num2)) * RSWIN_DESC.PSI__KPA
						text = "0"
						sVal = Util.Format(serviceFactor, text)
						serviceFactor = rst.minStressTop(CInt(num2)) * RSWIN_DESC.PSI__KPA
						text = "0"
						sVal2 = Util.Format(serviceFactor, text)
						serviceFactor = rst.minStressBot(CInt(num2)) * RSWIN_DESC.PSI__KPA
						text = "0"
						sVal3 = Util.Format(serviceFactor, text)
					Else
						Dim maxStressTop As Single() = rst.maxStressTop
						Dim num3 As Integer = CInt(num2)
						text = "0"
						sVal = Util.Format(maxStressTop(num3), text)
						Dim minStressTop As Single() = rst.minStressTop
						Dim num4 As Integer = CInt(num2)
						text = "0"
						sVal2 = Util.Format(minStressTop(num4), text)
						Dim minStressBot As Single() = rst.minStressBot
						Dim num5 As Integer = CInt(num2)
						text = "0"
						sVal3 = Util.Format(minStressBot(num5), text)
					End If
					Dim stressL As Single() = rst.StressL
					Dim num6 As Integer = CInt(num2)
					text = "0%"
					sVal4 = Util.Format(stressL(num6), text)
				End If
				Dim sVal5 As String
				Select Case RODUTIL.LookupStressMethod(rst.Sections(CInt(num2)))
					Case 0
						sVal5 = "API MG"
					Case 1
						sVal5 = "API MG T/2.8"
					Case 2
						sVal5 = "API MG T/3"
					Case 3
						sVal5 = "WFT EL"
					Case 4
						sVal5 = "MGS"
					Case 5
						sVal5 = "Fiberflex"
					Case 6
						sVal5 = "Norris FG"
					Case 7
						sVal5 = "Durarod"
					Case 8
						sVal5 = "RR Amoco"
					Case 9
						sVal5 = "Fiberod"
					Case 10
						sVal5 = "Tenaris"
					Case 11
						sVal5 = "Fiberod CCR"
					Case 12
						sVal5 = "Tenaris PC"
					Case 13
						sVal5 = "FlexRod"
					Case 14
						sVal5 = "Superod"
				End Select
				Dim sLine4 As String = String.Concat(New String() { " ", RESULTS1.CenterField(sVal4, 7S), "|", RESULTS1.CenterField(sVal, 12S), "|", RESULTS1.CenterField(sVal2, 12S), "|", RESULTS1.CenterField(sVal3, 12S), "|", RESULTS1.CenterField(sVal5, 12S) })
				RESULTS1.Trx(sLine4, "|", ChrW(1))
				RESULTS1.AddRLine(sLine4)
			Next
		End Sub

		Public Sub SummRSInput()
			Dim flag As Boolean = True
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			Dim num As Short = 1S
			Dim numRods As Short = cRODSTAR.NumRods
			For num2 As Short = num To numRods
				If Not RODUTIL.IsCorod(cRODSTAR.Sections(CInt(num2)).Grade) Then
					flag = False
					Exit For
				End If
			Next
			Dim text As String
			Select Case cRODSTAR.RodStringType
				Case 1S
					Dim str As String = " (API rod number: "
					Dim cRODSTAR2 As cRODSTAR = cRODSTAR
					Dim obj As Object = cRODSTAR2.APIRod
					Dim str2 As String = Util.Format(obj)
					cRODSTAR2.APIRod = Conversions.ToShort(obj)
					text = str + str2 + ")"
					GoTo IL_A8
				Case 3S
					text = " (rod tapers calculated)"
					GoTo IL_A8
			End Select
			text = ""
			IL_A8:
			RESULTS1.AddLLine("Rod string design" + text)
			RESULTS1.AddLLine(New String(ChrW(3), 49))
			Dim sLine As String = " Diameter |     Rod     | Length |    Tensile"
			Dim sLine2 As String = " (inches) |    Grade    |  (ft)  | Strength (psi)"
			Dim sLine3 As String = "----------+-------------+--------+---------------"
			RESULTS1.Trx(sLine, "|", ChrW(1))
			RESULTS1.Trx(sLine2, "|", ChrW(1))
			RESULTS1.Trx(sLine3, "-", ChrW(3))
			RESULTS1.Trx(sLine3, "+", ChrW(4))
			If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				StringType.MidStmtStr(sLine2, 28, 4, "(m) ")
			End If
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				If Not flag Then
					StringType.MidStmtStr(sLine2, 2, 8, "  (mm)  ")
				End If
				StringType.MidStmtStr(sLine2, 28, 4, "(m) ")
				StringType.MidStmtStr(sLine2, 46, 3, RSWIN_DESC.kPa)
			End If
			RESULTS1.AddLLine(sLine)
			RESULTS1.AddLLine(sLine2)
			RESULTS1.AddLLine(sLine3)
			RESULTS1.bMsgFullOKNeeded = 0S
			RESULTS1.bMsgSlimNeededNeeded = 0S
			RESULTS1.bMsgElevatorNeck1_0Needed = 0S
			RESULTS1.bMsgNoNeckNeeded = 0S
			Dim num3 As Short = 1S
			Dim numRods2 As Short = cRODSTAR.NumRods
			For num2 As Short = num3 To numRods2
				Dim quiet As Object = True
				Dim grade As Object = cRODSTAR.Sections(CInt(num2)).Grade
				Dim diameter As Object = cRODSTAR.Sections(CInt(num2)).Diameter
				Dim flag2 As Boolean
				Dim obj As Object = flag2
				Dim flag3 As Boolean
				Dim obj2 As Object = flag3
				Dim obj3 As Object = ""
				Dim flag4 As Boolean
				Dim obj4 As Object = flag4
				RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj, obj2, obj3, obj4, num2)
				flag4 = Conversions.ToBoolean(obj4)
				flag3 = Conversions.ToBoolean(obj2)
				flag2 = Conversions.ToBoolean(obj)
				Dim text2 As String
				If Not flag2 Then
					text2 = "*"
					RESULTS1.bMsgFullOKNeeded = -1S
				ElseIf flag3 Then
					text2 = "+"
					RESULTS1.bMsgSlimNeededNeeded = -1S
				Else
					text2 = " "
				End If
				If RODUTIL.IsFG(cRODSTAR.Sections(CInt(num2)).Grade) Then
					text2 += " "
				ElseIf RODUTIL.IsNoNeck(cRODSTAR.Sections(CInt(num2)).Grade) Then
					text2 += "#"
					RESULTS1.bMsgNoNeckNeeded = -1S
				Else
					Dim diameter2 As Single = cRODSTAR.Sections(CInt(num2)).Diameter
					If diameter2 >= 1.374F Then
						text2 += "@"
						RESULTS1.bMsgElevatorNeck1_0Needed = -1S
					ElseIf RODUTIL.IsSinkerBar(CInt(num2)) <> 0 Then
						text2 += "@"
						RESULTS1.bMsgElevatorNeck1_0Needed = -1S
					Else
						text2 += " "
					End If
				End If
				Dim text3 As String
				If RODUTIL.IsCorodH(cRODSTAR.Sections(CInt(num2)).Grade) Then
					text3 = "N/A"
				ElseIf RODUTIL.IsCorod(cRODSTAR.Sections(CInt(num2)).Grade) Then
					Dim num4 As Single = cRODSTAR.Sections(CInt(num2)).Diameter * 16F
					Dim text4 As String = "0"
					text3 = Util.Format(num4, text4) + "/16"
					If Not flag And RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						text3 += """"
					End If
				ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					Dim num4 As Single = cRODSTAR.Sections(CInt(num2)).Diameter * RSWIN_DESC.IN__MM
					Dim text4 As String = "0.0"
					text3 = Util.Format(num4, text4)
				Else
					Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
					Dim num5 As Integer = CInt(num2)
					Dim text4 As String = "0.0###"
					text3 = Util.Format(sections(num5).Diameter, text4)
				End If
				Dim text5 As String
				If CUSTOMRG.IsOtherSteel(CInt(cRODSTAR.Sections(CInt(num2)).Grade)) Then
					text5 = Strings.Trim(cRODSTAR.Sections(CInt(num2)).RodType)
				ElseIf RODUTIL.IsCorodH(cRODSTAR.Sections(CInt(num2)).Grade) Then
					If CDbl(cRODSTAR.Sections(CInt(num2)).Area) < 0.7 Then
						text5 += " 682"
					Else
						text5 += " 757"
					End If
				Else
					text5 = RODUTIL.RodGrade(cRODSTAR.Sections(CInt(num2)).Grade)
				End If
				Dim text6 As String
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					Dim sections2 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
					Dim num6 As Integer = CInt(num2)
					Dim text4 As String = "0"
					text6 = Util.Format(sections2(num6).length, text4)
				Else
					Dim num4 As Single = cRODSTAR.Sections(CInt(num2)).length * RSWIN_DESC.FT__M
					Dim text4 As String = "0"
					text6 = Util.Format(num4, text4)
				End If
				Dim text7 As String
				If RODUTIL.IsAPI(CInt(cRODSTAR.Sections(CInt(num2)).Grade), cRODSTAR.Sections(CInt(num2)).RodType) Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						Dim num4 As Single = cRODSTAR.Sections(CInt(num2)).TensileStrength * RSWIN_DESC.PSI__KPA
						Dim text4 As String = "0"
						text7 = Util.Format(num4, text4)
					Else
						Dim sections3 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
						Dim num7 As Integer = CInt(num2)
						Dim text4 As String = "0"
						text7 = Util.Format(sections3(num7).TensileStrength, text4)
					End If
				Else
					Try
						If cRODSTAR.Sections(CInt(num2)).TensileStrength = 0F Then
							RODUTIL.LookupTensileStrength(cRODSTAR.Sections(CInt(num2)))
						End If
						If cRODSTAR.Sections(CInt(num2)).TensileStrength <> 0F Then
							If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Dim num4 As Single = cRODSTAR.Sections(CInt(num2)).TensileStrength * RSWIN_DESC.PSI__KPA
								Dim text4 As String = "0"
								text7 = Util.Format(num4, text4)
							Else
								Dim sections4 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
								Dim num8 As Integer = CInt(num2)
								Dim text4 As String = "0"
								text7 = Util.Format(sections4(num8).TensileStrength, text4)
							End If
						Else
							text7 = "N/A"
						End If
					Catch ex As Exception
						text7 = "N/A"
					End Try
				End If
				text = String.Concat(New String() { text2, " ", text3, Strings.Space(7 - Strings.Len(text3)), "| ", text5, " |  ", text6, Strings.Space(6 - Strings.Len(text6)), "|     ", text7 })
				RESULTS1.Trx(text, "|", ChrW(1))
				RESULTS1.AddLLine(text)
			Next
			cRODSTAR = Nothing
		End Sub

		Public Function GetMotorName(iMotorType As Integer) As String
			If 9 = iMotorType Then
				Return "Baranchi"
			End If
			If 10 = iMotorType Then
				Return "JSC"
			End If
			If 11 = iMotorType Then
				Return "Vladimir"
			End If
			If 12 = iMotorType Then
				Return "JSC Eldin"
			End If
			If 13 = iMotorType Then
				Return "Bulgaria"
			End If
			Dim result As String
			Return result
		End Function

		Private Const LD_VBAR As Short = 1S

		Private Const LD_TEEDOWN As Short = 2S

		Private Const LD_HBAR As Short = 3S

		Private Const LD_CROSS As Short = 4S

		Private Const LD_ITALIC As Short = 5S

		Private Const LD_NORMAL As Short = 255S

		Private Const MSGCHAR_1 As Short = 185S

		Private Const MSGCHAR_2 As Short = 178S

		Private Const MSGCHAR_3 As Short = 179S

		Private bMsgElevatorNeck1_0Needed As Short

		Private bMsgFullOKNeeded As Short

		Private bMsgNoNeckNeeded As Short

		Private bMsgSlimNeededNeeded As Short

		Private nNonAPICustomRG As Short

		Private aiStressMethods As Short()

		Private picReport As PictureBox

		Private lLines As String()

		Private RLines As String()

		Public giPaperSize As Short

		Private toPrinter As Short

		Private LineDraw As String

		Private CurLine As Short

		Private nReportLines As Short

		Private sThetaEnterprises As String = Util.AssignValueToConstant("rptCalcResults", "sThetaEnterprises", "(c) Theta Oilfield Services, Inc.")

		Private $STATIC$MkLine$0311C10E1C$CurLine As String

		Private $STATIC$MkLine$0311C10E1C$CurLine$Init As StaticLocalInitFlag = New StaticLocalInitFlag()

		Private $STATIC$MkLine$0311C10E1C$CurPos As Short
	End Module
End Namespace
