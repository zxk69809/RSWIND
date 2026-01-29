Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module Verify
		Public Property bMotorVerified As Boolean
			Get
				Return Verify.m_bMotorVerified
			End Get
			Set(value As Boolean)
				Verify.m_bMotorVerified = value
			End Set
		End Property

		Public Function VerifyMotorSize(Optional bShow As Boolean = True) As Boolean
			Dim flag As Boolean = False
			Dim msg As String = "The motor size you specified does not have enough capacity for this system. Please change your input and run the case again."
			Dim result As Boolean = True
			If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred And (If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV)) <> 0S Then
				flag = True
			End If
			If Not Verify.bMotorVerified Then
				Verify.bMotorVerified = True
				Dim motorInfo As Object = Motor.GetMotorInfo(4)
				If Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 1, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 7, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 8, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 9, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 10, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 11, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 12, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 13, False))), True, False)) Then
					If Not RSWIN_DESC.rst.CalcMotorSize <> 0S Then
						Dim num As Single
						If RSWIN_DESC.rst.giRodDesignStyle = 0S Or RSWIN_DESC.rst.gbSteelRodString Then
							num = 1.1F
						Else
							num = 1.15F
						End If
						Dim num2 As Single = Conversions.ToSingle(Motor.GetMotorInfo(0))
						Dim num3 As Single
						Torquebal.CLFactor(1, num3)
						Dim num4 As Single = RODUTIL.StdMotorSize(CSng((CDbl((num3 * RSWIN_DESC.rst.Prhp)) / 0.9 * CDbl(num))))
						Dim num5 As Single = 0F
						Do
							Dim num6 As Single = num5
							num5 = RODUTIL.StdMotorSize(num6 + 1F)
						Loop While num5 < num4
						Dim num7 As Single
						Dim num9 As Single
						If RSWIN_DESC.rst.UnknownM Then
							num7 = num4
						Else
							Dim num8 As Single = RODUTIL.StdMotorSize(num4 + 1F)
							Torquebal.CLFactor(2, num3)
							num9 = RODUTIL.StdMotorSize(CSng((CDbl((num3 * RSWIN_DESC.rst.Prhp)) / 0.9 * CDbl(num))))
							num7 = Conversions.ToSingle(Util.Max(num4, num9))
						End If
						Dim num10 As Integer = -1
						Dim flag2 As Boolean
						If num2 < num4 Then
							If RSWIN_DESC.rst.gbBatch Then
								If flag Then
									Verify.VerifyReturnToMain(msg)
									num10 = 0
								Else
									Dim msg2 As String
									Util.LoadMessage(191, msg2)
									Util.ApplyNumber(num7, msg2)
									Verify.VerifyContinue(msg2)
								End If
							ElseIf bShow Then
								If flag Then
									Verify.VerifyReturnToMain(msg)
									num10 = 0
								Else
									num10 = Dialogs.dlgVerifyMotorSize(190, -1, num7, flag2)
								End If
							Else
								num10 = -1
							End If
						ElseIf Not RSWIN_DESC.rst.UnknownM AndAlso num2 < num9 Then
							If RSWIN_DESC.rst.gbBatch Then
								If flag Then
									Verify.VerifyReturnToMain(msg)
									num10 = 0
								Else
									Dim msg2 As String
									Util.LoadMessage(193, msg2)
									Util.ApplyNumber(num7, msg2)
									Util.ApplyNumber(num2, msg2)
									Verify.VerifyContinue(msg2)
								End If
							ElseIf bShow Then
								If flag Then
									Verify.VerifyReturnToMain(msg)
									num10 = 0
								Else
									num10 = Dialogs.dlgVerifyMotorSize(192, -1, num7, flag2)
								End If
							Else
								num10 = -1
							End If
						End If
						If Not num10 <> 0 Then
							result = (num10 <> 0)
							Motor.SelectMotorSizeByRatedHP(num7)
							Motor.SelectMotorSetting(0)
							If RSWIN_DESC.bChangeMotorSize Then
								Return False
							End If
							If flag2 Then
								result = True
							End If
						End If
					End If
				ElseIf Operators.ConditionalCompareObjectEqual(motorInfo, 5, False) Then
					If Operators.ConditionalCompareObjectLess(Motor.GetMotorInfo(0), RSWIN_DESC.rst.MinMotorHP, False) Then
						If flag Then
							Verify.VerifyReturnToMain(msg)
						Else
							Dim msg2 As String
							Util.LoadMessage(205, msg2)
							result = Verify.VerifyContinueOrReturn(msg2, True)
						End If
					End If
				ElseIf Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 3, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 2, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 4, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 6, False))), True, False)) Then
					Dim num11 As Integer = 0
					Dim num12 As Integer = 0
					If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 8, False)), RSWIN_DESC.rst.CalcMotorSize)) Then
						Dim fRatedHP As Single = Conversions.ToSingle(Motor.GetMotorInfo(0))
						Motor.SelectMotorSizeByRatedHP(RSWIN_DESC.rst.HpNemaD(1))
						Motor.SelectMotorSetting(0)
						Dim num13 As Integer = 0
						Dim num14 As Integer = CInt((RSWIN_DESC.rst.Ntsteps - 1S))
						Dim num15 As Integer
						Dim num16 As Single
						For i As Integer = num13 To num14
							Dim tq As Single = RSWIN_DESC.rst.Tnet(1, i)
							Dim flag3 As Boolean = num15 <> 0
							Motor.MotorEfficiency(tq, num16, flag3)
							num15 = If(-If((flag3 > False), 1, 0), 1, 0)
							If(If(-If((CDbl(num16) <= 0.001 > False), 1, 0), 1, 0) Or num15) <> 0 Then
								num11 += 1
							End If
						Next
						Motor.SelectMotorSizeByRatedHP(RSWIN_DESC.rst.HpNemaD(2))
						Motor.SelectMotorSetting(0)
						Dim num17 As Integer = 0
						Dim num18 As Integer = CInt((RSWIN_DESC.rst.Ntsteps - 1S))
						For i As Integer = num17 To num18
							Dim tq2 As Single = RSWIN_DESC.rst.Tnet(2, i)
							Dim flag3 As Boolean = num15 <> 0
							Motor.MotorEfficiency(tq2, num16, flag3)
							num15 = If(-If((flag3 > False), 1, 0), 1, 0)
							If(If(-If((CDbl(num16) <= 0.001 > False), 1, 0), 1, 0) Or num15) <> 0 Then
								num12 += 1
							End If
						Next
						Motor.SelectMotorSizeByRatedHP(fRatedHP)
						Motor.SelectMotorSetting(0)
					Else
						Dim num19 As Integer = 0
						Dim num20 As Integer = CInt((RSWIN_DESC.rst.Ntsteps - 1S))
						For i As Integer = num19 To num20
							Dim tq3 As Single = RSWIN_DESC.rst.Tnet(1, i)
							Dim num15 As Integer
							Dim flag3 As Boolean = num15 <> 0
							Dim num16 As Single
							Motor.MotorEfficiency(tq3, num16, flag3)

								num15 = If((-If((flag3 > False), 1, 0)), 1, 0)
								If(If((-If((CDbl(num16) <= 0.001 > False), 1, 0)), 1, 0) Or num15) <> 0 Then
									' The following expression was wrapped in a checked-statement
									num11 += 1
								End If
								Dim tq4 As Single = RSWIN_DESC.rst.Tnet(2, i)
								flag3 = (num15 <> 0)
								Motor.MotorEfficiency(tq4, num16, flag3)
								num15 = If((-If((flag3 > False), 1, 0)), 1, 0)

							If(If(-If((CDbl(num16) <= 0.001 > False), 1, 0), 1, 0) Or num15) <> 0 Then
								num12 += 1
							End If
						Next
					End If
					If num11 >= 5 Then
						If flag Then
							Verify.VerifyReturnToMain(msg)
							result = False
						Else
							Dim msg2 As String
							Util.LoadMessage(206, msg2)
							result = Verify.VerifyContinueOrReturn(msg2, True)
						End If
					ElseIf num12 >= 5 Then
						If flag Then
							Verify.VerifyReturnToMain(msg)
							result = False
						Else
							Dim msg2 As String
							Util.LoadMessage(207, msg2)
							result = Verify.VerifyContinueOrReturn(msg2, True)
						End If
					End If
				End If
			End If
			Return result
		End Function

		Private Sub FixPoints(PointType As Integer, SETUP_CorrectDynoCard As Boolean, ByRef nWrongOrder As Integer, I As Integer, iLastInOrder As Integer, ByRef SurfPos As Single())
			' The following expression was wrapped in a checked-statement
			If SETUP_CorrectDynoCard Then
				If PointType <> 1 Then
				End If
				Dim obj As Object = SurfPos(I) - SurfPos(iLastInOrder) / CSng((nWrongOrder + 1))
				Dim num As Integer = 1
				Dim num2 As Integer = nWrongOrder
				For i As Integer = num To num2
					SurfPos(iLastInOrder + i) = Conversions.ToSingle(Operators.AddObject(SurfPos(iLastInOrder), Operators.MultiplyObject(i, obj)))
				Next
				nWrongOrder = 0
			End If
		End Sub

		Public Function VerifyReturnToMain(msg As String) As Boolean
			Dim result As Boolean
			Try
				If RSWIN_DESC.rst.gbBatch Then
					Batch.BatchMessage(msg)
				Else
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(msg, sMsgType, bClosing, dialogResult)
				End If
				result = False
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub VerifyRodsNotBuckling()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim obj As Object
			Dim obj2 As Object
			If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, RSWIN_DESC.rst.NumRods, 1, obj2, obj) Then
				While Not RODUTIL.IsFG(rst.Sections(Conversions.ToInteger(obj)).Grade)
					If Not ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj2, obj) Then
						GoTo IL_59
					End If
				End While
				Return
			End If
			IL_59:
			If rst.PumpDepth > 1500F Then
				Dim obj3 As Object = rst.NumRods
				Dim obj4 As Object
				Dim obj5 As Object
				If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj4, CInt((rst.NumRods - 1S)), 1, -1, obj5, obj4) Then
					Do
						If rst.Sections(Conversions.ToInteger(obj4)).Diameter < rst.Sections(Conversions.ToInteger(obj3)).Diameter Then
							obj3 = RuntimeHelpers.GetObjectValue(obj4)
						End If
					Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj4, obj5, obj4)
				End If
				Dim num As Single
				If RSWIN_DESC.rst.PumpDepth < 4750F Then
					num = CSng(((0.615 * CDbl(RSWIN_DESC.rst.PumpDepth) - 922.5) / CDbl(rst.Sections(Conversions.ToInteger(obj3)).Area)))
				Else
					num = 2000F / rst.Sections(Conversions.ToInteger(obj3)).Area
				End If
				num = CSng((CDbl(num) * 0.75))
				If RSWIN_DESC.rst.minStressTop(Conversions.ToInteger(obj3)) < num And RSWIN_DESC.rst.minStressBot(Conversions.ToInteger(obj3)) <= 0F Then
					Dim text As String = Util.AssignValueToConstant("VerifyRodsNotBuckling", "sMsg1", "To minimize possible rod buckling problems on rod section #" + Util.Format(obj3) + ", try one of the following:" + Convert.ToString(RSWIN_DESC.LF))
					text = text.Replace("#1", "#" + Util.Format(obj3))
					Dim str As String = Util.AssignValueToConstant("VerifyRodsNotBuckling", "sMsg2", "1) Add sinker bars or sinker rods at the bottom")
					Dim str2 As String = Util.AssignValueToConstant("VerifyRodsNotBuckling", "sMsg3", "2) Slow down the pumping unit")
					Dim text2 As String = Util.AssignValueToConstant("VerifyRodsNotBuckling", "sMsg4", "3) Don't use 3/4 rods")
					Dim text3 As String = text2
					Dim oldValue As String = "3/4"
					Dim sections As RSWIN_DESC.RodSection() = rst.Sections
					Dim array As RSWIN_DESC.RodSection() = sections
					Dim num2 As Integer = Conversions.ToInteger(obj3)
					Dim obj6 As Object = array(num2).Diameter
					Dim newValue As String = Util.Format(obj6)
					sections(num2).Diameter = Conversions.ToSingle(obj6)
					text2 = text3.Replace(oldValue, newValue)
					Dim text4 As String = text + Conversions.ToString(RSWIN_DESC.LF)
					text4 = text4 + str + Conversions.ToString(RSWIN_DESC.LF)
					text4 = text4 + str2 + Conversions.ToString(RSWIN_DESC.LF)
					If CDbl(rst.Sections(Conversions.ToInteger(obj3)).Diameter) < 0.875 Then
						text4 += text2
					End If
					Verify.VerifyContinue(text4)
				End If
			End If
		End Sub

		Public Sub VerifyContinue(msg As String)
			If RSWIN_DESC.rst.gbBatch Then
				If Not(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) Then
					Batch.BatchMessage(msg)
					Return
				End If
				If Not RSWIN_DESC.bSuppressWarningMessages Then
					Batch.BatchMessage(msg)
					Return
				End If
			Else
				If RSWIN_DESC.bSuppressWarningMessages Then
					Return
				End If
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(msg, sMsgType, bClosing, dialogResult)
			End If
		End Sub

		Public Function VerifyContinueOrReturn(msg As String, bAddText As Boolean) As Boolean
			If RSWIN_DESC.rst.gbBatch Then
				If bAddText Then
					msg = msg + Conversions.ToString(RSWIN_DESC.LF) + "Continuing."
				End If
				If Not(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) Then
					Batch.BatchMessage(msg)
				ElseIf Not RSWIN_DESC.bSuppressWarningMessages Then
					Batch.BatchMessage(msg)
				End If
				Return True
			End If
			If bAddText Then
				msg = msg + Convert.ToString(RSWIN_DESC.LF) + Verify.sDYWContinueWithData
			End If
			Dim msg2 As String = msg
			Dim bDefaultYes As Boolean = True
			Dim flag As Boolean = False
			Return Util.YesNo(msg2, bDefaultYes, flag)
		End Function

		Public Function VerifyFGRodStringDesign() As Boolean
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				Dim msg As String = ""
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If(If((-If(((rst.RodStringType = 3S And rst.giRodDesignStyle <> 0S And CDbl(rst.FoSkr) >= 0.9) > False), 1S, 0S)), 1S, 0S) And Not rst.CalcPlungerSize) <> 0S Then
					Util.LoadMessage(159, msg)
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						RSWIN_DESC.bFGUnderTravel = True
						flag = False
					Else
						flag = Verify.VerifyReturnToMain(msg)
					End If
				End If
				result = flag
			Catch ex As Exception
				result = True
			End Try
			Return result
		End Function

		Public Sub VerifyFGNotInCompression()
			Dim num As Integer
			Dim num8 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Not rst.gbSteelRodString Then
					Dim num2 As Short = 0S
					Dim num3 As Short = 0S
					Dim num4 As Short = 1S
					Dim numRods As Short = rst.NumRods
					Dim num7 As Short
					Dim area As Single
					For num5 As Short = num4 To numRods
						If RODUTIL.IsFG(rst.Sections(CInt(num5)).Grade) Then
							Dim num6 As Single = rst.minStressBot(CInt(num5)) * rst.Sections(CInt(num5)).Area
							If num6 <= 0F Then
								num2 = -1S
								num7 = If((-If((RODUTIL.IsRibbonRod(rst.Sections(CInt(num5)).Grade) > False), 1S, 0S)), 1S, 0S)
								area = rst.Sections(CInt(num5)).Area
								Exit For
							End If
							If num6 <= 500F Then
								num3 = -1S
								num7 = If((-If((RODUTIL.IsRibbonRod(rst.Sections(CInt(num5)).Grade) > False), 1S, 0S)), 1S, 0S)
								area = rst.Sections(CInt(num5)).Area
							End If
						End If
					Next
					Dim text As String = RSWIN_DESC.sNull
					If num2 <> 0S Then
						If num7 <> 0S Then
							If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Util.LoadMessage(203, text)
							Else
								Util.LoadMessage(202, text)
							End If
						ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							Util.LoadMessage(163, text)
						Else
							Util.LoadMessage(162, text)
						End If
					ElseIf num3 <> 0S Then
						If num7 <> 0S Then
							If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Util.LoadMessage(201, text)
							Else
								Util.LoadMessage(200, text)
							End If
						ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							Util.LoadMessage(161, text)
						Else
							Util.LoadMessage(160, text)
						End If
					End If
					If Strings.Len(text) > 0 Then
						Util.ApplyNumber(500F / area, text)
						Util.ApplyNumber(CtrlUI.ConvertUnits(500F / area, 9), text)
						If(num7 And If((-If((rst.FGPercent <= 20F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							text += vbLf & vbLf & "Lowering the pumping speed will help avoid compression as well."
						End If
						If Not RSWIN_DESC.bRunningPred Then
							Verify.VerifyContinue(text)
						End If
					End If
				End If
				IL_214:
				GoTo IL_25B
				IL_216:
				num8 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_22C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_216
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_25B:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub VerifyFluidVelocity()
			Dim num As Integer
			Dim num13 As Integer
			Dim obj5 As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num2 As Single = 0F
				Dim num3 As Short = 0S
				Dim num4 As Short = 1S
				Dim numRods As Short = rst.NumRods
				Dim num6 As Short
				For num5 As Short = num4 To numRods
					If Not RODUTIL.IsCorodH(rst.Sections(CInt(num5)).Grade) Then
						Dim quiet As Object = True
						Dim grade As Object = rst.Sections(CInt(num5)).Grade
						Dim diameter As Object = rst.Sections(CInt(num5)).Diameter
						Dim flag As Boolean
						Dim obj As Object = flag
						Dim flag2 As Boolean
						Dim obj2 As Object = flag2
						Dim obj3 As Object = Nothing
						Dim flag3 As Boolean
						Dim obj4 As Object = flag3
						RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj, obj2, obj3, obj4, num5)
						flag3 = Conversions.ToBoolean(obj4)
						flag2 = Conversions.ToBoolean(obj2)
						flag = Conversions.ToBoolean(obj)
						If flag Then
							Dim pinSize As Single = RODUTIL.GetPinSize(rst.Sections(CInt(num5)).Grade, rst.Sections(CInt(num5)).Diameter)
							If pinSize > num2 Then
								num2 = pinSize
								num3 = num5
								num6 = If((-If((flag2 > False), 1S, 0S)), 1S, 0S)
							End If
						End If
					End If
				Next
				If num3 <> 0S Then
					Dim num7 As Single
					Dim num8 As Single
					If(If((-If((RODUTIL.IsCorod(rst.Sections(CInt(num3)).Grade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(rst.Sections(CInt(num3)).Grade))) <> 0 Then
						num7 = rst.Sections(CInt(num3)).Diameter
						num8 = num7
					Else
						Dim num9 As Single = num2
						If num9 <= 0.5F Then
							num7 = 1F
							num8 = 1F
						ElseIf num9 <= 0.625F Then
							num7 = 1.25F
							num8 = 1.5F
						ElseIf num9 <= 0.75F Then
							num7 = 1.5F
							num8 = 1.625F
						ElseIf num9 <= 0.875F Then
							num7 = 1.625F
							num8 = 1.8125F
						ElseIf num9 <= 1F Then
							num7 = 2F
							num8 = 2.1875F
						Else
							num7 = 2.375F
							num8 = 2.375F
						End If
					End If
					Dim num10 As Single
					If num6 <> 0S Then
						num10 = CSng(((Math.Pow(CDbl(rst.TubingID), 2.0) - Math.Pow(CDbl(num7), 2.0)) * 3.141592653589793 / 4.0 / 144.0))
					Else
						num10 = CSng(((Math.Pow(CDbl(rst.TubingID), 2.0) - Math.Pow(CDbl(num8), 2.0)) * 3.141592653589793 / 4.0 / 144.0))
					End If
					Dim num11 As Single = CSng((CDbl((rst.BPDsurface * (24F / rst.Runtime))) * 6.49836E-05))
					Dim num12 As Single = num11 / num10
					If CDbl(num12) > 6.5 Then
						Dim str As String
						Util.LoadMessage(164, str)
						Dim str2 As String
						Util.LoadMessage(165, str2)
						Util.ApplyNumber(CSng(num3), str)
						If rst.PumpType = 3S Then
							str += "  This may also cause the on-off tool used for the large bore pump to fail prematurely."
						End If
						Dim msg As String = str + str2
						Verify.VerifyContinue(msg)
					End If
				End If
				IL_329:
				GoTo IL_370
				IL_32B:
				num13 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_341:
			Catch obj6 When endfilter(TypeOf obj5 Is Exception And num <> 0 And num13 = 0)
				Dim ex As Exception = CType(obj6, Exception)
				GoTo IL_32B
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_370:
			If num13 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function VerifyInputDataConsistency() As Boolean
			Dim flag As Boolean = True
			Dim result As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim text As String = "GuideToUse"
				Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
				Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
				RSWIN_DESC.MOLDED = CShort(molded)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
				Dim text2 As String
				If rst.gbUseIPR Then
					If rst.gbCalcPumpCondition Then
						rst.FluidLevelEntered = False
					Else
						If rst.FluidLevelEntered Then
							rst.PumpIntakePressure = CSng((0.433 * CDbl(rst.OilSPGR) * CDbl((rst.PumpDepth - rst.FluidLevel)) + CDbl(rst.CasingPressure) + 14.7))
						End If
						If IPR.iprPwfFromPip(rst.PumpIntakePressure) >= rst.StaticBHPressure Then
							If rst.FluidLevelEntered Then
								Util.LoadMessage(104, text2)
							Else
								Util.LoadMessage(124, text2)
							End If
							flag = Verify.VerifyReturnToMain(text2)
						End If
					End If
				End If
				If(If((-If((rst.gbUseIPR > False), 1S, 0S)), 1S, 0S) And Not rst.SPMEntered And If((-If((Not rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					IPR.iprSetup()
					Dim num As Single = IPR.iprPwfFromPip(rst.CasingPressure)
					If rst.TargetBFPD > IPR.iprProductionFromPwf(num) + rst.WaterPI * (rst.StaticBHPressure - num) Then
						Util.LoadMessage(146, text2)
						flag = Verify.VerifyReturnToMain(text2)
					End If
				End If
				If(rst.SPMEntered And If((-If((rst.SPM < 0F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					text2 = "lease enter the pumping speed before running this case."
					If rst.gbCalcPumpCondition Then
						Util.Errmsg("Because you chose to have " + VERSION1.ProgramTitle() + " calculate the pump condition, p" + text2)
					Else
						Util.Errmsg("P" + text2)
					End If
					flag = False
				End If
				If(Not RSWIN_DESC.rst.CalcPlungerSize And If((-If((RSWIN_DESC.rst.PlungerSize <= 0F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
						Util.LoadMessage(39, text2)
					Else
						Util.LoadMessage(40, text2)
					End If
					flag = Verify.VerifyReturnToMain(text2)
				End If
				If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade) Then
					Util.LoadMessage(101, text2)
					Verify.VerifyReturnToMain(text2)
					flag = False
				End If
				result = flag
			Catch ex As Exception
				result = True
			End Try
			Return result
		End Function

		Public Function VerifyMaxPumpSpeed(MaxSPM As Single) As Boolean
			Dim num As Integer
			Dim flag12 As Boolean
			Dim num6 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim num2 As Single = 0F
				Dim flag As Boolean = True
				Dim flag2 As Boolean = True
				Dim flag3 As Boolean = False
				Dim flag4 As Boolean = False
				Dim text As String = "The recommended maximum SPM is X. Would you like to continue with your entered SPM?"
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				RSWIN_DESC.bChangeSPM = False
				Dim text2 As String
				If rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Then
					' The following expression was wrapped in a checked-statement
					If rst.PU.UnitType = 7S Then
						Dim flag5 As Boolean = True
						If flag5 = Strings.InStr(rst.UnitID.Trim().ToUpper(), "HSP", CompareMethod.Binary) > 0 Then
							If rst.SPM > 4F Then
								num2 = 4F
								flag2 = False
							End If
						Else
							If flag5 <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R1", False) = 0) Then
								If flag5 <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R2", False) = 0) Then
									If flag5 <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R5", False) = 0) Then
										If flag5 <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R6", False) = 0) Then
											If flag5 <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R9", False) = 0) Then
												If flag5 <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R10", False) = 0) Then
													If flag5 <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R13", False) = 0) Then
														If flag5 = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R3", False) = 0) OrElse flag5 = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R4", False) = 0) Then
															If CDbl(rst.SPM) > 4.3 Then
																num2 = 4.3F
																flag2 = False
																GoTo IL_A09
															End If
															GoTo IL_A09
														ElseIf flag5 = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R7", False) = 0) Then
															If CDbl(rst.SPM) > 3.75 Then
																num2 = 3.75F
																flag2 = False
																GoTo IL_A09
															End If
															GoTo IL_A09
														ElseIf flag5 = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R8", False) = 0) Then
															If CDbl(rst.SPM) > 3.64 Then
																num2 = 3.64F
																flag2 = False
																GoTo IL_A09
															End If
															GoTo IL_A09
														ElseIf flag5 = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R11", False) = 0) OrElse flag5 = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R12", False) = 0) Then
															If CDbl(rst.SPM) > 5.0 Then
																num2 = 5F
																flag2 = False
																GoTo IL_A09
															End If
															GoTo IL_A09
														ElseIf flag5 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) > 368F Then
															If CDbl(rst.SPM) > 3.75 Then
																num2 = 3.75F
																flag2 = False
																GoTo IL_A09
															End If
															GoTo IL_A09
														ElseIf flag5 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 340F Then
															If CDbl(rst.SPM) > 3.64 Then
																num2 = 3.64F
																flag2 = False
																GoTo IL_A09
															End If
															GoTo IL_A09
														ElseIf flag5 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) > 325F Then
															If CDbl(rst.SPM) > 4.0 Then
																num2 = 4F
																flag2 = False
																GoTo IL_A09
															End If
															GoTo IL_A09
														ElseIf flag5 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) > 315F Then
															If CDbl(rst.SPM) > 4.15 Then
																num2 = 4.15F
																flag2 = False
																GoTo IL_A09
															End If
															GoTo IL_A09
														ElseIf flag5 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) > 310F Then
															If CDbl(rst.SPM) > 4.25 Then
																num2 = 4.25F
																flag2 = False
																GoTo IL_A09
															End If
															GoTo IL_A09
														ElseIf flag5 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) > 300F Then
															If CDbl(rst.SPM) > 4.3 Then
																num2 = 4.3F
																flag2 = False
																GoTo IL_A09
															End If
															GoTo IL_A09
														ElseIf flag5 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 288F Then
															If CDbl(rst.SPM) > 4.5 Then
																num2 = 4.5F
																flag2 = False
																GoTo IL_A09
															End If
															GoTo IL_A09
														Else
															If flag5 <> rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) > 280F Then
																' The following expression was wrapped in a unchecked-expression
																' The following expression was wrapped in a checked-expression
																' The following expression was wrapped in a checked-expression
																Dim num3 As Single = CSng((-1.4E-05 * Math.Pow(CDbl(rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S)))), 2.0) + 0.0002 * CDbl(rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S)))) + 5.5))
																If rst.SPM > num3 Then
																	num2 = num3
																	flag2 = False
																	flag4 = True
																	text = text.Replace("X", Conversions.ToString(Verify.RoundToNearestQuarter(num3)))
																End If
																GoTo IL_A09
															End If
															If CDbl(rst.SPM) > 4.65 Then
																num2 = 4.65F
																flag2 = False
																GoTo IL_A09
															End If
															GoTo IL_A09
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
							If CDbl(rst.SPM) > 4.5 Then
								num2 = 4.5F
								flag2 = False
							End If
						End If
					ElseIf rst.PU.UnitType = 10S Then
						Dim flag6 As Boolean = True
						If flag6 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 360F OrElse flag6 = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "DNP1", False) = 0) Then
							If rst.SPM > 3F Then
								num2 = 3F
								flag2 = False
							End If
						ElseIf flag6 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 336F OrElse flag6 = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "DNP2", False) = 0) Then
							If CDbl(rst.SPM) > 3.4 Then
								num2 = 3.4F
								flag2 = False
							End If
						ElseIf flag6 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 288F OrElse flag6 = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "DNP3", False) = 0) Then
							If CDbl(rst.SPM) > 4.0 Then
								num2 = 4F
								flag2 = False
							End If
						ElseIf flag6 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 240F OrElse flag6 = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "DNP4", False) = 0) Then
							If CDbl(rst.SPM) > 4.8 Then
								num2 = 4.8F
								flag2 = False
							End If
						ElseIf flag6 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 168F OrElse flag6 = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "DNP5", False) = 0) Then
							If CDbl(rst.SPM) > 6.9 Then
								num2 = 6.9F
								flag2 = False
							End If
						ElseIf flag6 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) < 168F OrElse flag6 = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "DNP5", False) = 0) Then
							If CDbl(rst.SPM) > 6.9 Then
								num2 = 6.9F
								flag2 = False
							End If
						Else
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							Dim num3 As Single = CSng((-1.4E-05 * Math.Pow(CDbl(rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S)))), 2.0) + 0.0002 * CDbl(rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S)))) + 5.5))
							If rst.SPM > num3 Then
								num2 = num3
								flag2 = False
								flag4 = True
								text = text.Replace("X", Conversions.ToString(Verify.RoundToNearestQuarter(num3)))
							End If
						End If
					End If
					IL_A09:
					If num2 <> 0F Then
						MaxSPM = num2
					End If
					If RSWIN_DESC.rst.SPM = MaxSPM Then
						flag2 = True
					End If
					If(If((-If((Not flag2 > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.WarnedAboutHighSPM) <> 0S Then
						If rst.gbBatch Then
							Util.LoadMessage(169, text2)
							If num2 <> 0F Then
								text2 = text2.Replace("%{0.0}", "%{0.0##}")
							End If
							Util.ApplyNumber(MaxSPM, text2)
							Util.ApplyNumber(rst.SPM, text2)
							flag = Verify.VerifyContinueOrReturn(text2, False)
							RSWIN_DESC.WarnedAboutHighSPM = -1S
						ElseIf flag4 Then
							Dim msg As String = text
							Dim bDefaultYes As Boolean = True
							Dim flag7 As Boolean = False
							If Not Util.YesNo(msg, bDefaultYes, flag7) Then
								rst.SPM = MaxSPM
							End If
							RSWIN_DESC.WarnedAboutHighSPM = -1S
							flag = True
						Else
							If Not Dialogs.dlgVerifyPumpingSpeed(170S, -1S, flag3, num2) Then
								If RSWIN_DESC.bChangeSPM Then
									flag = False
								ElseIf flag3 Then
									rst.SPM = MaxSPM
								End If
							End If
							RSWIN_DESC.WarnedAboutHighSPM = -1S
						End If
					End If
				End If
				If flag2 AndAlso Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) <= 0 Then
					If rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Then
						num2 = CSng((CDbl(MaxSPM) + 1.5))
						If rst.gbBatch Then
							Dim flag8 As Boolean = True
							If flag8 = (rst.SPM >= num2 And num2 > 0F) Then
								Util.LoadMessage(211, text2)
								flag = Verify.VerifyReturnToMain(text2)
							ElseIf flag8 = (rst.SPM > MaxSPM And MaxSPM > 0F) Then
								If Not RSWIN_DESC.WarnedAboutHighSPM <> 0S Then
									Util.LoadMessage(169, text2)
									Util.ApplyNumber(MaxSPM, text2)
									Util.ApplyNumber(rst.SPM, text2)
									flag = Verify.VerifyContinueOrReturn(text2, False)
									RSWIN_DESC.WarnedAboutHighSPM = -1S
								End If
							End If
						ElseIf Not RSWIN_DESC.WarnedAboutHighSPM <> 0S Then
							Dim flag9 As Boolean = True
							If flag9 = (rst.SPM >= num2 And num2 > 0F) Then
								Dim iMessage As Short = 210S
								Dim bAllowContinue As Short = 0S
								Dim flag7 As Boolean = False
								flag = Dialogs.dlgVerifyPumpingSpeed(iMessage, bAllowContinue, flag7, 0F)
								If RSWIN_DESC.bChangeSPM Then
									flag = False
								Else
									rst.SPM = MaxSPM
								End If
							ElseIf flag9 = (rst.SPM > MaxSPM And MaxSPM > 0F) AndAlso Not Dialogs.dlgVerifyPumpingSpeed(170S, -1S, flag3, 0F) Then
								If RSWIN_DESC.bChangeSPM Then
									flag = False
								ElseIf flag3 Then
									rst.SPM = MaxSPM
								End If
							End If
							RSWIN_DESC.WarnedAboutHighSPM = -1S
						End If
					Else
						num2 = MaxSPM * 2F
						Dim num4 As Single = CSng((CDbl(MaxSPM) + 0.5))
						If rst.SPM < 5F Then
							If Not RSWIN_DESC.WarnedAboutLowSPM <> 0S Then
								Util.LoadMessage(183, text2)
								Verify.VerifyContinue(text2)
								RSWIN_DESC.WarnedAboutLowSPM = -1S
							End If
						ElseIf rst.gbBatch Then
							Dim flag10 As Boolean = True
							If flag10 = (rst.SPM >= num2 And num2 > 0F) Then
								Util.LoadMessage(209, text2)
								flag = Verify.VerifyReturnToMain(text2)
							ElseIf flag10 = (rst.SPM >= num4 And num4 > 0F) Then
								If Not RSWIN_DESC.WarnedAboutHighSPM <> 0S Then
									Util.LoadMessage(169, text2)
									Util.ApplyNumber(MaxSPM, text2)
									Util.ApplyNumber(rst.SPM, text2)
									flag = Verify.VerifyContinueOrReturn(text2, False)
									RSWIN_DESC.WarnedAboutHighSPM = -1S
								End If
							End If
						ElseIf Not RSWIN_DESC.WarnedAboutHighSPM <> 0S Then
							Dim flag11 As Boolean = True
							If flag11 = (rst.SPM >= num2 And num2 > 0F) Then
								Dim iMessage2 As Short = 208S
								Dim bAllowContinue2 As Short = 0S
								Dim flag7 As Boolean = False
								Dim num5 As Short = If((-If((Dialogs.dlgVerifyPumpingSpeed(iMessage2, bAllowContinue2, flag7, 0F) > False), 1S, 0S)), 1S, 0S)
								If RSWIN_DESC.bChangeSPM Then
									flag = False
								Else
									rst.SPM = MaxSPM
								End If
							ElseIf flag11 = (rst.SPM > num4 And num4 > 0F) AndAlso Not Dialogs.dlgVerifyPumpingSpeed(171S, -1S, flag3, 0F) Then
								If RSWIN_DESC.bChangeSPM Then
									flag = False
								ElseIf flag3 Then
									rst.SPM = MaxSPM
								End If
							End If
							RSWIN_DESC.WarnedAboutHighSPM = -1S
						End If
					End If
				End If
				flag12 = flag
				IL_E3A:
				GoTo IL_E81
				IL_E3C:
				num6 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_E52:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_E3C
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_E81:
			Dim result As Boolean = flag12
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Function VerifyMaxPumpSpeed_Save(MaxSPM As Single) As Boolean
			Dim num As Integer
			Dim flag7 As Boolean
			Dim num5 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim flag As Boolean = True
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) <= 0 Then
					If rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Then
						Dim num2 As Single = CSng((CDbl(MaxSPM) + 1.5))
						If rst.gbBatch Then
							Dim flag2 As Boolean = True
							If flag2 = (rst.SPM >= num2 And num2 > 0F) Then
								Dim msg As String
								Util.LoadMessage(211, msg)
								flag = Verify.VerifyReturnToMain(msg)
							ElseIf flag2 = (rst.SPM > MaxSPM And MaxSPM > 0F) Then
								If Not RSWIN_DESC.WarnedAboutHighSPM <> 0S Then
									Dim msg As String
									Util.LoadMessage(169, msg)
									Util.ApplyNumber(MaxSPM, msg)
									Util.ApplyNumber(rst.SPM, msg)
									flag = Verify.VerifyContinueOrReturn(msg, False)
									RSWIN_DESC.WarnedAboutHighSPM = -1S
								End If
							End If
						ElseIf Not RSWIN_DESC.WarnedAboutHighSPM <> 0S Then
							Dim flag3 As Boolean = True
							If flag3 = (rst.SPM >= num2 And num2 > 0F) Then
								Dim iMessage As Short = 210S
								Dim bAllowContinue As Short = 0S
								Dim flag4 As Boolean = False
								flag = Dialogs.dlgVerifyPumpingSpeed(iMessage, bAllowContinue, flag4, 0F)
								rst.SPM = MaxSPM
							ElseIf flag3 = (rst.SPM > MaxSPM And MaxSPM > 0F) Then
								Dim iMessage2 As Short = 170S
								Dim bAllowContinue2 As Short = -1S
								Dim flag4 As Boolean = False
								If Not Dialogs.dlgVerifyPumpingSpeed(iMessage2, bAllowContinue2, flag4, 0F) Then
									rst.SPM = MaxSPM
								End If
							End If
							RSWIN_DESC.WarnedAboutHighSPM = -1S
						End If
					Else
						Dim num2 As Single = MaxSPM * 2F
						Dim num3 As Single = CSng((CDbl(MaxSPM) + 0.5))
						If rst.SPM < 5F Then
							If Not RSWIN_DESC.WarnedAboutLowSPM <> 0S Then
								Dim msg As String
								Util.LoadMessage(183, msg)
								Verify.VerifyContinue(msg)
								RSWIN_DESC.WarnedAboutLowSPM = -1S
							End If
						ElseIf rst.gbBatch Then
							Dim flag5 As Boolean = True
							If flag5 = (rst.SPM >= num2 And num2 > 0F) Then
								Dim msg As String
								Util.LoadMessage(209, msg)
								flag = Verify.VerifyReturnToMain(msg)
							ElseIf flag5 = (rst.SPM >= num3 And num3 > 0F) Then
								If Not RSWIN_DESC.WarnedAboutHighSPM <> 0S Then
									Dim msg As String
									Util.LoadMessage(169, msg)
									Util.ApplyNumber(MaxSPM, msg)
									Util.ApplyNumber(rst.SPM, msg)
									flag = Verify.VerifyContinueOrReturn(msg, False)
									RSWIN_DESC.WarnedAboutHighSPM = -1S
								End If
							End If
						ElseIf Not RSWIN_DESC.WarnedAboutHighSPM <> 0S Then
							Dim flag6 As Boolean = True
							If flag6 = (rst.SPM >= num2 And num2 > 0F) Then
								Dim iMessage3 As Short = 208S
								Dim bAllowContinue3 As Short = 0S
								Dim flag4 As Boolean = False
								Dim num4 As Short = If((-If((Dialogs.dlgVerifyPumpingSpeed(iMessage3, bAllowContinue3, flag4, 0F) > False), 1S, 0S)), 1S, 0S)
								rst.SPM = MaxSPM
							ElseIf flag6 = (rst.SPM > num3 And num3 > 0F) Then
								Dim iMessage4 As Short = 171S
								Dim bAllowContinue4 As Short = -1S
								Dim flag4 As Boolean = False
								If Not Dialogs.dlgVerifyPumpingSpeed(iMessage4, bAllowContinue4, flag4, 0F) Then
									rst.SPM = MaxSPM
								End If
							End If
							RSWIN_DESC.WarnedAboutHighSPM = -1S
						End If
					End If
				End If
				flag7 = flag
				IL_311:
				GoTo IL_358
				IL_313:
				num5 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_329:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_313
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_358:
			Dim result As Boolean = flag7
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub VerifyMPRL()
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num2 As Single
				If rst.PumpDepth < 2000F Then
					num2 = 50F
				Else
					num2 = 100F
				End If
				Dim mprload As Single = rst.Mprload
				If mprload < 0F Then
					Dim msg As String
					Util.LoadMessage(187, msg)
					Verify.VerifyContinue(msg)
				ElseIf mprload < num2 Then
					Dim msg As String
					Util.LoadMessage(186, msg)
					Verify.VerifyContinue(msg)
				End If
				IL_66:
				GoTo IL_AD
				IL_68:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_68
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_AD:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function VerifyPumpEfficiency() As Boolean
			Dim num As Integer
			Dim flag2 As Boolean
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim flag As Boolean = True
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If rst.IncludeFluidInertia <> 0S Then
					If rst.gbCalcPumpCondition Then
						If(If((-If((rst.PumpFillage < 90F > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.WarnedAboutLowPumpFillage) <> 0S Then
							Dim text As String
							Util.LoadMessage(178, text)
							Verify.VerifyContinue(text)
							Util.LoadMessage(180, text)
							flag = Verify.VerifyContinueOrReturn(text + New String(vbLf, 2) + Verify.sDYWContinueRun, False)
							RSWIN_DESC.WarnedAboutLowPumpFillage = -1S
						End If
					ElseIf rst.PumpCondition = 1S Then
						If(If((-If((rst.PumpEfficiency < 90F > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.WarnedAboutLowPumpEfficiency) <> 0S Then
							Dim text As String
							Util.LoadMessage(177, text)
							flag = Verify.VerifyContinueOrReturn(text, True)
							RSWIN_DESC.WarnedAboutLowPumpEfficiency = -1S
						End If
					ElseIf(If((-If((rst.PumpFillage < 90F > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.WarnedAboutLowPumpFillage) <> 0S Then
						Dim text As String
						Util.LoadMessage(178, text)
						Verify.VerifyContinue(text)
						Util.LoadMessage(179, text)
						flag = Verify.VerifyContinueOrReturn(text, True)
						RSWIN_DESC.WarnedAboutLowPumpFillage = -1S
					End If
				End If
				flag2 = flag
				IL_11D:
				GoTo IL_164
				IL_11F:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_135:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_11F
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_164:
			Dim result As Boolean = flag2
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub VerifyPumpIntakePressure()
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Not rst.gbCalcPumpCondition And Not rst.FluidLevelEntered Then
					Dim fluidLevel As Single = rst.FluidLevel
					If fluidLevel < 0F Then
						Dim msg As String
						Util.LoadMessage(168, msg)
						Dim flag As Boolean = Verify.VerifyReturnToMain(msg)
					ElseIf fluidLevel > rst.PumpDepth Then
						Dim msg As String
						Util.LoadMessage(181, msg)
						Dim flag As Boolean = Verify.VerifyReturnToMain(msg)
					End If
				End If
				IL_67:
				GoTo IL_AE
				IL_69:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_69
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_AE:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function VerifyPumpStroke() As Boolean
			Dim num As Integer
			Dim flag2 As Boolean
			Dim num3 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim flag As Boolean = True
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num2 As Short = 0S
				If CDbl(rst.FoSkr) >= 0.8 Then
					num2 = -1S
				ElseIf CDbl(rst.FoSkr) >= 0.775 Then
					If CDbl(rst.NoverNoP) <= 0.55 Then
						num2 = -1S
					End If
				ElseIf CDbl(rst.FoSkr) >= 0.7 Then
					If CDbl(rst.NoverNoP) <= 0.3 Then
						num2 = -1S
					End If
				ElseIf CDbl(rst.FoSkr) >= 0.6 Then
					If CDbl(rst.NoverNoP) <= 0.22 Then
						num2 = -1S
					End If
				ElseIf CDbl(rst.FoSkr) >= 0.5 Then
					If CDbl(rst.NoverNoP) < 0.15 Then
						num2 = -1S
					End If
				ElseIf CDbl(rst.FoSkr) >= 0.4 AndAlso CDbl(rst.NoverNoP) < 0.1 Then
					num2 = -1S
				End If
				If(num2 And Not RSWIN_DESC.WarnedAboutFoSkr) <> 0S Then
					If rst.FoSkr > 1F Then
						Dim text As String
						Util.LoadMessage(167, text)
						flag = Verify.VerifyReturnToMain(text)
						RSWIN_DESC.WarnedAboutFoSkr = -1S
					ElseIf Not RSWIN_DESC.WarnedAboutFoSkr <> 0S Then
						If rst.gbSteelRodString Then
							Dim text As String
							If rst.gbBatch Then
								Util.LoadMessage(158, text)
							Else
								Util.LoadMessage(157, text)
							End If
							Util.ApplyNumber(rst.PlungerSize, text)
							flag = Verify.VerifyContinueOrReturn(text, False)
						ElseIf CDbl(rst.FoSkr) <= 0.65 Then
							Dim text As String
							Util.LoadMessage(176, text)
							If RSWIN_DESC.rst.PU.CrankHole = 1S Then
								text += " Or use a pumping unit with a larger stroke length."
							End If
							flag = Verify.VerifyContinueOrReturn(text, True)
							RSWIN_DESC.WarnedAboutFoSkr = -1S
						Else
							Dim text As String
							Util.LoadMessage(156, text)
							If RSWIN_DESC.rst.PU.CrankHole = 1S Then
								text += " Or use a pumping unit with a larger stroke length."
							End If
							flag = Verify.VerifyContinueOrReturn(text, True)
						End If
						RSWIN_DESC.WarnedAboutFoSkr = -1S
					End If
				End If
				flag2 = flag
				IL_22C:
				GoTo IL_273
				IL_22E:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_244:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_22E
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_273:
			Dim result As Boolean = flag2
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub VerifyResults()
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Verify.VerifyFluidVelocity()
				Verify.VerifyMPRL()
				Verify.VerifyFGNotInCompression()
				IL_18:
				GoTo IL_5B
				IL_1A:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1A
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_5B:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function VerifyRodsInTubing() As Boolean
			Dim num As Integer
			Dim flag4 As Boolean
			Dim num4 As Integer
			Dim obj5 As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim flag As Boolean = True
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If rst.RodStringType = 3S Then
					Dim text As String = RSWIN_DESC.sNull
					Dim quiet As Object = True
					Dim grade As Object = rst.RSGrade
					Dim diameter As Object = rst.RSMinSize
					Dim flag2 As Boolean
					Dim obj As Object = flag2
					Dim obj2 As Object = False
					Dim obj3 As Object = text
					Dim flag3 As Boolean
					Dim obj4 As Object = flag3
					RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj, obj2, obj3, obj4, 0)
					flag3 = Conversions.ToBoolean(obj4)
					text = Conversions.ToString(obj3)
					flag2 = Conversions.ToBoolean(obj)
					If Not flag2 And Not RSWIN_DESC.bRodsInTubingMsgShown And Not(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.SETUP_FixTubingSize) Then
						Util.LoadMessage(204, text)
						flag = Verify.VerifyReturnToMain(text)
					End If
				Else
					Dim num2 As Short = 1S
					Dim numRods As Short = rst.NumRods
					For num3 As Short = num2 To numRods
						Dim quiet2 As Object = True
						Dim grade2 As Object = rst.Sections(CInt(num3)).Grade
						Dim diameter2 As Object = rst.Sections(CInt(num3)).Diameter
						Dim flag2 As Boolean
						Dim obj4 As Object = flag2
						Dim obj3 As Object = False
						Dim text As String
						Dim obj2 As Object = text
						Dim flag3 As Boolean
						Dim obj As Object = flag3
						RODUTIL.CheckRodsInTubing(quiet2, grade2, diameter2, obj4, obj3, obj2, obj, num3)
						flag3 = Conversions.ToBoolean(obj)
						text = Conversions.ToString(obj2)
						flag2 = Conversions.ToBoolean(obj4)
						If Not flag2 Then
							If CDbl(rst.Sections(CInt(num3)).Diameter) = 1.125 And CDbl(rst.TubingOD) = 2.875 And Not RSWIN_DESC.bRodsInTubingMsgShown Then
								text += vbLf & vbLf & "However, 1.125"" sinker bars will fit in the tubing."
								flag = Verify.VerifyContinueOrReturn(text, True)
							ElseIf Not RSWIN_DESC.bRodsInTubingMsgShown Then
								flag = Verify.VerifyReturnToMain(text)
							End If
						End If
					Next
				End If
				flag4 = flag
				IL_1D6:
				GoTo IL_21D
				IL_1D8:
				num4 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1EE:
			Catch obj6 When endfilter(TypeOf obj5 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj6, Exception)
				GoTo IL_1D8
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_21D:
			Dim result As Boolean = flag4
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Function VerifyTargetBFPD() As Boolean
			Dim flag As Boolean = False
			Dim flag2 As Boolean = True
			Dim result As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num As Short = -1S
				If(If((-If(((rst.RodStringType = 3S) > False), 1S, 0S)), 1S, 0S) Or rst.SPMEntered Or RSWIN_DESC.WarnedAboutBFPD) <> 0S Then
					num = 0S
				Else
					Dim num2 As Short = 1S
					Dim numRods As Short = rst.NumRods
					For num3 As Short = num2 To numRods
						If RODUTIL.IsRibbonRod(rst.Sections(CInt(num3)).Grade) Or rst.Sections(CInt(num3)).Grade = 16393S Then
							num = 0S
							Exit For
						End If
					Next
				End If
				If num <> 0S Then
					Dim num4 As Single = rst.MaxSPM
					If rst.gbSteelRodString Then
						Dim num5 As Single = CSng((0.45 * CDbl(rst.No) * CDbl(rst.Fc)))
						If num5 < num4 Then
							num4 = num5
						End If
					End If
					Dim num6 As Single = num4 / rst.No
					Dim noverNoP As Single = num6 / rst.Fc
					rst.GrossPumpStroke = APIROD.SpOverS(noverNoP, rst.FoSkr, rst.PU.UnitType) * rst.PU.KinematicStroke - rst.TubStretch
					Dim num7 As Single = RUNCALC.BPDsurf(rst.GrossPumpStroke, num4, rst.PlungerSize, rst.Pfill) * rst.Runtime / 24F
					Dim msg As String
					If rst.TargetBFPD > num7 + 10F Then
						If rst.gbBatch Then
							If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
								Util.LoadMessage(174, msg)
							Else
								Util.LoadMessage(175, msg)
							End If
						ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							Util.LoadMessage(172, msg)
						Else
							Util.LoadMessage(173, msg)
						End If
						Util.ApplyNumber(CtrlUI.ConvertUnits(num7, 0), msg)
						Util.ApplyNumber(CtrlUI.ConvertUnits(rst.TargetBFPD, 0), msg)
						Dim flag3 As Boolean = Verify.VerifyContinueOrReturn(msg, False)
						flag2 = flag3
						RSWIN_DESC.WarnedAboutBFPD = -1S
					End If
					Dim num8 As Single
					If rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Then
						num8 = 1F
					ElseIf rst.gbSteelRodString Then
						num8 = 5F
					Else
						num8 = CSng((0.3 * CDbl(rst.No) * CDbl(rst.Fc)))
					End If
					Dim num9 As Single = num8 / rst.No
					Dim noverNoP2 As Single = num9 / rst.Fc
					rst.GrossPumpStroke = APIROD.SpOverS(noverNoP2, rst.FoSkr, rst.PU.UnitType) * rst.PU.KinematicStroke - rst.TubStretch
					Dim num10 As Single = RUNCALC.BPDsurf(rst.GrossPumpStroke, num8, rst.PlungerSize, rst.Pfill) * rst.Runtime / 24F
					If Not flag Then
						flag2 = True
						RSWIN_DESC.WarnedAboutBFPD = -1S
					ElseIf(If((-If((rst.gbUseIPR > False), 1S, 0S)), 1S, 0S) And Not rst.SPMEntered And If((-If((rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						flag2 = True
					ElseIf rst.TargetBFPD < num10 - 10F And num7 > num10 Then
						If rst.gbBatch Then
							Util.LoadMessage(185, msg)
						Else
							Util.LoadMessage(184, msg)
						End If
						Util.ApplyNumber(num10, msg)
						Util.ApplyNumber(rst.TargetBFPD, msg)
						Dim flag3 As Boolean = Verify.VerifyContinueOrReturn(msg, False)
						flag2 = flag3
						RSWIN_DESC.WarnedAboutBFPD = -1S
					End If
				End If
				result = flag2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function UsingNorrisGuides() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If RSWIN_DESC.rst.Sections(i).Guide < 4S Then
						flag = False
					End If
				Next
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function RoundToNearestQuarter(fValue As Single) As Single
			Dim result As Single
			Try
				fValue = CSng((CDbl(fValue) / 0.25))
				Dim num As Integer = CInt(Math.Round(CDbl(Conversion.Int(fValue))))
				Dim num2 As Single = CSng((CDbl(num) * 0.25))
				result = num2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Friend gbWarnedAboutMeasuredStroke As Integer

		Private sDYWContinueRun As String = Util.AssignValueToConstant("DoYouWant", "sDYWContinueRun", "Do you want to continue the run?")

		Private sDYWContinueWithData As String = Util.AssignValueToConstant("DoYouWant", "sDYWContinueWithData", "Do you want to continue, using your data?")

		Private m_bMotorVerified As Boolean = False
	End Module
End Namespace
