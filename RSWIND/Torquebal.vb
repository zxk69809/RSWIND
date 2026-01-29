Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module Torquebal
		Public Sub CalculateEnergyConsumption(TCondition As Integer, ByRef MotorKWH As Single)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.CrankSpeed = rst.SPM * rst.TotalTheta / 60F
			MotorKWH = 0F
			Dim num As Integer = 0
			Dim num5 As Single
			Dim num2 As Integer = CInt((rst.Ntsteps - 1S))
			For i As Integer = num To num2
				Dim tq As Single = rst.Tnet(TCondition, i)
				Dim flag As Boolean = False
				Dim num3 As Single
				Motor.MotorEfficiency(tq, num3, flag)

					If CDbl(rst.Tnet(TCondition, i)) >= 0.0 Then
						Dim num4 As Single = CSng((CDbl((rst.Tnet(TCondition, i) * rst.CrankSpeed)) / 6600.0 / 0.9800000190734863))
						MotorKWH += num4 / num3
					ElseIf rst.PowerMeterType = 2S Then
						Dim num4 As Single = CSng((CDbl((-CDbl(rst.Tnet(TCondition, i)) * rst.CrankSpeed)) / 6600.0 * 0.9800000190734863))
						MotorKWH -= num4 / num3
					End If

			Next
			num5 = CSng((60.0 / CDbl(rst.SPM) / CDbl(rst.Ntsteps)))
			MotorKWH = CSng((CDbl(MotorKWH) * (CDbl((rst.Runtime * rst.SPM * num5)) / 80.43)))
		End Sub

		Public Sub CalculateNewTorque(newM As Single, ByRef TCondition As Integer)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim flag As Boolean = True
			If flag = (rst.PU.UnitType = 6S) Then
				Dim num As Integer = 0
				Dim num2 As Integer = CInt((rst.Ntsteps - 1S))
				For i As Integer = num To num2

						Dim num3 As Single = rst.PU.V0 + rst.PU.M * rst.SurfPos(i) / 1728F
						Dim num4 As Single = CSng((CDbl(newM) / Math.Pow(CDbl((num3 / rst.PU.V0)), 1.33) - 14.696))
						rst.Tnet(TCondition, i) = rst.Tf(i) * (rst.SurfLoad(i) - rst.PU.M * (num4 - rst.PU.S))

				Next
			ElseIf flag = (rst.PU.UnitType = 7S) OrElse flag = (rst.PU.UnitType = 10S) Then
				Dim num5 As Integer = 0
				Dim num6 As Integer = CInt((rst.Ntsteps - 1S))
				For i As Integer = num5 To num6
					' The following expression was wrapped in a unchecked-expression
					rst.Tnet(TCondition, i) = rst.Tf(i) * (rst.SurfLoad(i) * rst.PU.DrumDiamRatio - newM)
				Next
			ElseIf flag = (rst.PU.UnitType = 8S) OrElse flag = RSWIN_DESC.bBeamBalanced Then
				Dim num7 As Integer = 0
				Dim num8 As Integer = CInt((rst.Ntsteps - 1S))
				For i As Integer = num7 To num8
					' The following expression was wrapped in a unchecked-expression
					rst.Tnet(TCondition, i) = CSng((CDbl((rst.Tf(i) * (rst.SurfLoad(i) - newM))) - CDbl(RSWIN_DESC.rst.get_M(2)) * Math.Sin(CDbl((rst.Thetac(i) + rst.PU.CrankOffset)))))
				Next
			ElseIf flag = (rst.PU.UnitType = 9S) Then
				Dim c As Single = rst.PU.C
				Dim num9 As Single = CSng(Math.Sqrt(Math.Pow(CDbl(rst.PU.K), 2.0) - Math.Pow(CDbl(rst.PU.I), 2.0)))
				Dim num10 As Integer = 0
				Dim num11 As Integer = CInt((rst.Ntsteps - 1S))
				For i As Integer = num10 To num11
					' The following expression was wrapped in a unchecked-expression
					rst.Tnet(TCondition, i) = CSng((CDbl((rst.Tf(i) * rst.SurfLoad(i))) - CDbl(newM) * Math.Sin(CDbl((rst.Thetac(i) + rst.PU.CrankOffset)) + 1.5707963267948966 - Math.Tan(CDbl(((num9 + c / 2F) / rst.PU.I))))))
				Next
			Else
				Dim num12 As Integer = 0
				Dim num13 As Integer = CInt((rst.Ntsteps - 1S))
				For i As Integer = num12 To num13
					' The following expression was wrapped in a unchecked-expression
					rst.Tnet(TCondition, i) = CSng((CDbl((rst.Tf(i) * (rst.SurfLoad(i) - rst.PU.Unbalance))) - CDbl(newM) * Math.Sin(CDbl((rst.Thetac(i) + rst.PU.CrankOffset)))))
				Next
			End If
		End Sub

		Public Sub CalculatePL(Moment As Single, ByRef Pl As Single(), TCondition As Integer, ByRef bRet As Boolean)
			Dim num As Integer = 1000000
			Try
				Application.DoEvents()
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				bRet = True
				Dim num2 As Single = CSng((100.0 * CDbl(cRODSTAR.PU.StructRating)))
				Dim num10 As Single
				Select Case cRODSTAR.PU.UnitType
					Case 6S
						' The following expression was wrapped in a unchecked-expression
						Dim num3 As Single = CSng((CDbl(Moment) + 14.696))
						Dim num4 As Integer = 0
						Dim num5 As Integer = CInt((cRODSTAR.Ntsteps - 1S))
						For i As Integer = num4 To num5

								If cRODSTAR.Tf(i) = 0F Then
									Pl(i) = Conversions.ToSingle(Interaction.IIf(i >= CInt(cRODSTAR.NtstepsUpstroke), 0, num2))
								Else
									Dim num6 As Single = cRODSTAR.PU.V0 + cRODSTAR.PU.M * cRODSTAR.SurfPos(i) / 1728F
									Dim num7 As Single = CSng((CDbl(num3) / Math.Pow(CDbl((num6 / cRODSTAR.PU.V0)), 1.33) - 14.696))
									Pl(i) = CSng((CDbl(cRODSTAR.PU.GearboxRating) * 1000.0 / CDbl(cRODSTAR.Tf(i)) + CDbl((cRODSTAR.PU.M * (num7 - cRODSTAR.PU.S)))))
								End If

						Next
						GoTo IL_61C
					Case 7S
						Try
							Dim num8 As Integer = 0
							Dim num9 As Integer = CInt((cRODSTAR.Ntsteps - 1S))
							For i As Integer = num8 To num9
								If cRODSTAR.Tf(i) = 0F Then
									Pl(i) = Conversions.ToSingle(Interaction.IIf(i >= CInt(cRODSTAR.NtstepsUpstroke), 0, num2))
								Else
									' The following expression was wrapped in a unchecked-expression
									Pl(i) = CSng((1.0 / CDbl(cRODSTAR.PU.DrumDiamRatio) * (CDbl(cRODSTAR.PU.GearboxRating) * 1000.0 / CDbl(cRODSTAR.Tf(i)) + CDbl(Moment))))
								End If
							Next
							GoTo IL_61C
						Catch ex As Exception
							GoTo IL_61C
						End Try
					Case 8S
						GoTo IL_48C
					Case 9S
						num10 = 0F
						Dim c As Single = cRODSTAR.PU.C
						Dim num11 As Single = CSng(Math.Sqrt(Math.Pow(CDbl(cRODSTAR.PU.K), 2.0) - Math.Pow(CDbl(cRODSTAR.PU.I), 2.0)))
						Dim num12 As Integer = 0
						Dim num13 As Integer = CInt((cRODSTAR.Ntsteps - 1S))
						For i As Integer = num12 To num13

								If CDbl(Math.Abs(cRODSTAR.Tf(i))) < 1E-06 Then
									Pl(i) = 1000000F
								Else
									If(If((-If((cRODSTAR.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.SETUP_UseImpred) <> 0S Then
										Dim num14 As Single = CSng((CDbl((cRODSTAR.Tf(i) * cRODSTAR.SurfLoad(i))) - CDbl(Moment) * Math.Sin(CDbl((cRODSTAR.Thetac(i) + cRODSTAR.PU.CrankOffset)) + 1.5707963267948966 - Math.Tan(CDbl(((num11 + c / 2F) / cRODSTAR.PU.I))))))
										num10 = num14 - cRODSTAR.Tnet(TCondition, i)
									End If
									Dim num15 As Single = cRODSTAR.PU.GearboxRating * 1000F
									Pl(i) = CSng(((CDbl(num15) + CDbl(Moment) * Math.Sin(CDbl(cRODSTAR.Thetac(i)) + (CDbl(cRODSTAR.PU.CrankOffset) + 1.5707963267948966 - Math.Tan(CDbl(((num11 + c / 2F) / cRODSTAR.PU.I))))) + CDbl(num10)) / CDbl(cRODSTAR.Tf(i))))
								End If

						Next
						GoTo IL_61C
					Case 10S
					Case Else
						GoTo IL_48C
				End Select
				Dim num16 As Integer = 0
				Dim num17 As Integer = CInt((cRODSTAR.NtstepsUpstroke - 1S))
				For i As Integer = num16 To num17
					' The following expression was wrapped in a unchecked-expression
					Pl(i) = cRODSTAR.PU.StructRating * 100F
				Next
				Dim ntstepsUpstroke As Integer = CInt(cRODSTAR.NtstepsUpstroke)
				Dim num18 As Integer = CInt((cRODSTAR.Ntsteps - 1S))
				For i As Integer = ntstepsUpstroke To num18
					Pl(i) = 0F
				Next
				GoTo IL_61C
				IL_48C:
				Dim num19 As Single
				If cRODSTAR.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
					If Not RSWIN_DESC.rst.bUnknownUnbalance And RSWIN_DESC.rst.Unbalance <> RSWIN_DESC.rst.PU.Unbalance Then
						num19 = cRODSTAR.Unbalance
					Else
						num19 = cRODSTAR.get_RequiredUnbalance(1)
					End If
				Else
					num19 = cRODSTAR.PU.Unbalance
				End If
				num10 = 0F
				Dim num20 As Integer = 0
				Dim num21 As Integer = CInt((cRODSTAR.Ntsteps - 1S))
				For i As Integer = num20 To num21

						If CDbl(Math.Abs(cRODSTAR.Tf(i))) < 1E-06 Then
							Pl(i) = 1000000F
						Else
							If(If((-If((cRODSTAR.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.SETUP_UseImpred) <> 0S Then
								Dim num14 As Single = CSng((CDbl((cRODSTAR.Tf(i) * (cRODSTAR.SurfLoad(i) - num19))) - CDbl(Moment) * Math.Sin(CDbl((cRODSTAR.Thetac(i) + cRODSTAR.PU.CrankOffset)))))
								num10 = num14 - cRODSTAR.Tnet(TCondition, i)
							End If
							Dim num15 As Single = cRODSTAR.PU.GearboxRating * 1000F
							Pl(i) = CSng(((CDbl(num15) + CDbl(Moment) * Math.Sin(CDbl((cRODSTAR.Thetac(i) + cRODSTAR.PU.CrankOffset))) + CDbl(num10)) / CDbl(cRODSTAR.Tf(i)) + CDbl(num19)))
						End If

				Next
				IL_61C:
				Application.DoEvents()
				Dim num22 As Integer = 0
				Dim num23 As Integer = CInt((cRODSTAR.Ntsteps - 1S))
				For i As Integer = num22 To num23
					If Pl(i) < 0F Then
						Pl(i) = 0F
					ElseIf Pl(i) > num2 Then
						Pl(i) = num2
					End If
				Next
				Dim num24 As Integer = 0
				Dim num25 As Integer = CInt((cRODSTAR.Ntsteps - 1S))
				For i As Integer = num24 To num25
					Dim num26 As Integer = (i + 1) Mod CInt(cRODSTAR.Ntsteps)
					Dim num27 As Single = Pl(num26) - Pl(i)
					If num27 = -num2 Then
						cRODSTAR.NtstepsUpstroke = CShort(num26)
					End If
				Next
				Application.DoEvents()
				If Not(cRODSTAR.PU.UnitType = 7S Or cRODSTAR.PU.UnitType = 10S) Then
					Dim num28 As Integer = 0
					Dim i As Integer = 0
					Dim num26 As Integer
					While True
						num28 += 1
						num26 = i Mod CInt((cRODSTAR.Ntsteps - 1S)) + 1
						If cRODSTAR.Tf(i) < 0F And cRODSTAR.Tf(num26) >= 0F Then
							Exit For
						End If
						i = num26
						If num28 > num Then
							GoTo Block_23
						End If
					End While
					GoTo IL_736
					Block_23:
					bRet = False
					IL_736:
					num28 = 0
					While True
						num28 += 1
						num26 = i Mod CInt((cRODSTAR.Ntsteps - 1S)) + 1
						If CDbl(Math.Abs(Pl(num26) - Pl(i))) > 0.5 * CDbl(num2) Then
							Exit For
						End If
						i = num26
						If num28 > num Then
							GoTo Block_25
						End If
					End While
					cRODSTAR.StartUpstroke = num26
					GoTo IL_78B
					Block_25:
					bRet = False
					IL_78B:
					num28 = 0
					i = 0
					While True
						num28 += 1
						num26 = i Mod CInt((cRODSTAR.Ntsteps - 1S)) + 1
						If cRODSTAR.Tf(i) > 0F And cRODSTAR.Tf(num26) <= 0F Then
							Exit For
						End If
						i = num26
						If num28 > num Then
							GoTo Block_27
						End If
					End While
					GoTo IL_7E2
					Block_27:
					bRet = False
					IL_7E2:
					num28 = 0
					While True
						num28 += 1
						num26 = i Mod CInt((cRODSTAR.Ntsteps - 1S)) + 1
						If CDbl(Math.Abs(Pl(num26) - Pl(i))) > 0.5 * CDbl(num2) Then
							Exit For
						End If
						i = num26
						If num28 > num Then
							GoTo Block_29
						End If
					End While
					cRODSTAR.StartDownstroke = num26
					GoTo IL_837
					Block_29:
					bRet = False
				End If
				IL_837:
				cRODSTAR = Nothing
				Application.DoEvents()
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub CLFactor(TCondition As Integer, ByRef Clf As Single)
			' The following expression was wrapped in a checked-statement
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num As Single = 0F
				Dim num2 As Single = 0F
				Dim num3 As Integer = 0
				Dim num4 As Integer = CInt((rst.Ntsteps - 1S))
				For i As Integer = num3 To num4

						num += rst.Tnet(TCondition, i) * rst.Tnet(TCondition, i)
						num2 += rst.Tnet(TCondition, i)

				Next
				Clf = CSng((Math.Sqrt(CDbl((num / CSng((rst.Ntsteps - 1S))))) / CDbl((num2 / CSng((rst.Ntsteps - 1S))))))
				If Single.IsInfinity(Clf) Or Single.IsNaN(Clf) Then
					Clf = 0F
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function F(M As Single, TCondition As Integer) As Single
			Torquebal.CalculateNewTorque(M, TCondition)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim result As Single
			If TCondition = 1 Then
				Torquebal.FindMaxTorque(1, result)
			Else
				If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), rst.CalcMotorSize)) Then
					Dim num As Single
					If rst.giRodDesignStyle = 0S Or rst.gbSteelRodString Then
						num = 1.1F
					Else
						num = 1.15F
					End If
					Dim num2 As Single
					Torquebal.CLFactor(0, num2)
					rst.HpNemaD(0) = RODUTIL.StdMotorSize(CSng((CDbl((num2 * rst.Prhp)) / 0.9 * CDbl(num))))
					Motor.SelectMotorSizeByRatedHP(rst.HpNemaD(0))
					Motor.SelectMotorSetting(0)
				End If
				Torquebal.CalculateEnergyConsumption(TCondition, result)
			End If
			Return result
		End Function

		Public Sub FindMaxTorque(TCondition As Integer, ByRef Maxt As Single)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Maxt = 0F
			Dim num As Integer = 0
			Dim num2 As Integer = CInt((rst.Ntsteps - 1S))
			For i As Integer = num To num2
				If Math.Abs(rst.Tnet(TCondition, i)) > Maxt Then
					Maxt = Math.Abs(rst.Tnet(TCondition, i))
				End If
			Next
		End Sub

		Public Sub Torque(ByRef Prpos As Single(), ByRef Prload As Single(), ByRef Tf As Single(), ByRef Thetac As Single(), Moment As Single, ByRef Tnet As Single(,))
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Integer = 0
			Dim num2 As Integer = CInt((rst.Ntsteps - 2S))
			For i As Integer = num To num2
				Torquebal.Torque1(Prpos(i), Prload(i), Tf(i), Thetac(i), Moment, Tnet(2, i))
			Next
			rst.Tnet(2, CInt((rst.Ntsteps - 1S))) = rst.Tnet(2, 0)
			Application.DoEvents()
		End Sub

		Public Sub Torque1(ByRef Prpos As Single, ByRef Prload As Single, ByRef Tf As Single, ByRef Thetac As Single, Moment As Single, ByRef Tnet As Single)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim flag As Boolean = True
			If flag = (rst.PU.UnitType = 6S) Then
				Dim num As Single = CSng((CDbl(Moment) + 14.696))
				Dim num2 As Single = rst.PU.V0 + rst.PU.M * Prpos / 1728F
				Dim num3 As Single = CSng((CDbl(num) / Math.Pow(CDbl((num2 / rst.PU.V0)), 1.33) - 14.696))
				Tnet = Tf * (Prload - rst.PU.M * (num3 - rst.PU.S))
			ElseIf flag = (rst.PU.UnitType = 7S) OrElse flag = (rst.PU.UnitType = 10S) Then
				Tnet = Tf * (Prload * rst.PU.DrumDiamRatio - Moment)
			ElseIf flag = (rst.PU.UnitType = 8S) OrElse flag = RSWIN_DESC.bBeamBalanced Then
				Tnet = CSng((CDbl((Tf * (Prload - Moment))) - CDbl(RSWIN_DESC.rst.get_M(2)) * Math.Sin(CDbl((Thetac + rst.PU.CrankOffset)))))
			ElseIf flag = (rst.PU.UnitType = 9S) Then
				Dim c As Single = rst.PU.C
				Dim num4 As Single = CSng(Math.Sqrt(Math.Pow(CDbl(rst.PU.K), 2.0) - Math.Pow(CDbl(rst.PU.I), 2.0)))
				Tnet = CSng((CDbl((Tf * Prload)) - CDbl(Moment) * Math.Sin(CDbl((Thetac + rst.PU.CrankOffset)) + 1.5707963267948966 - Math.Tan(CDbl(((num4 + c / 2F) / rst.PU.I))))))
			Else
				Tnet = CSng((CDbl((Tf * (Prload - rst.PU.Unbalance))) - CDbl(Moment) * Math.Sin(CDbl((Thetac + rst.PU.CrankOffset)))))
			End If
		End Sub

		Public Sub Torque_Save(ByRef Prpos As Single(), ByRef Prload As Single(), ByRef Tf As Single(), ByRef Thetac As Single(), Moment As Single, ByRef Tnet As Single(,), ByRef PU As RSWIN_DESC.PUDataRec)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Select Case PU.UnitType
				Case 6S
					' The following expression was wrapped in a unchecked-expression
					Dim num As Single = CSng((CDbl(Moment) + 14.696))
					Dim num2 As Integer = 0
					Dim num3 As Integer = CInt((rst.Ntsteps - 1S))
					For i As Integer = num2 To num3

							Dim num4 As Single = PU.V0 + PU.M * Prpos(i) / 1728F
							Dim num5 As Single = CSng((CDbl(num) / Math.Pow(CDbl((num4 / PU.V0)), 1.33) - 14.696))
							Tnet(2, i) = Tf(i) * (Prload(i) - PU.M * (num5 - PU.S))

					Next
					Return
				Case 7S, 10S
					Dim num6 As Integer = 0
					Dim num7 As Integer = CInt((rst.Ntsteps - 1S))
					For i As Integer = num6 To num7
						' The following expression was wrapped in a unchecked-expression
						Tnet(2, i) = Tf(i) * (Prload(i) * PU.DrumDiamRatio - Moment)
					Next
					Return
				Case 9S
					Dim c As Single = PU.C
					Dim num8 As Single = CSng(Math.Sqrt(Math.Pow(CDbl(PU.K), 2.0) - Math.Pow(CDbl(PU.I), 2.0)))
					Dim num9 As Integer = 0
					Dim num10 As Integer = CInt((rst.Ntsteps - 1S))
					For i As Integer = num9 To num10
						' The following expression was wrapped in a unchecked-expression
						Tnet(2, i) = CSng((CDbl((rst.Tf(i) * rst.SurfLoad(i))) - CDbl(Moment) * Math.Sin(CDbl((rst.Thetac(i) + PU.CrankOffset)) + 1.5707963267948966 - Math.Tan(CDbl(((num8 + c / 2F) / PU.I))))))
					Next
					Return
			End Select
			Dim num11 As Integer = 0
			Dim num12 As Integer = CInt((rst.Ntsteps - 1S))
			For i As Integer = num11 To num12
				' The following expression was wrapped in a unchecked-expression
				Tnet(2, i) = CSng((CDbl((Tf(i) * (Prload(i) - PU.Unbalance))) - CDbl(Moment) * Math.Sin(CDbl((Thetac(i) + PU.CrankOffset)))))
			Next
		End Sub

		Public Sub Balance(TCondition As Integer)
			RSWIN_DESC.iNeg = 0
			RSWIN_DESC.iPos = 0
			RSWIN_DESC.fSumNeg = 0F
			RSWIN_DESC.fSumPos = 0F
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim flag As Boolean = True
			Dim num As Single
			Dim num2 As Single
			If flag = (rst.PU.UnitType = 7S) OrElse flag = (rst.PU.UnitType = 10S) Then
				num = 500F
				num2 = 100000F
			ElseIf flag = (rst.PU.UnitType = 6S) Then
				num = 25F
				num2 = 1000F
			ElseIf flag = (rst.PU.UnitType = 8S) OrElse flag = RSWIN_DESC.bBeamBalanced Then
				num = 100F
				num2 = 50000F
			Else
				num = 1000F
				num2 = 8000000F
			End If
			Dim fRatedHP As Single
			If TCondition = 0 AndAlso Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), RSWIN_DESC.rst.CalcMotorSize)) Then
				fRatedHP = Conversions.ToSingle(Motor.GetMotorInfo(0))
			End If
			Dim num3 As Single = num + 0.381966F * (num2 - num)
			Dim num4 As Single = num
			Dim num5 As Single = num3
			Dim num6 As Single = num3 + 0.381966F * (num2 - num3)
			Dim num7 As Single = num2
			Dim num8 As Single = Torquebal.F(num5, TCondition)
			Dim num9 As Single = Torquebal.F(num6, TCondition)
			While Math.Abs(num7 - num4) > 1E-05F * (Math.Abs(num5) + Math.Abs(num6))
				If num9 < num8 Then
					num4 = num5
					num5 = num6
					num6 = num5 + 0.381966F * (num7 - num5)
					num8 = num9
					num9 = Torquebal.F(num6, TCondition)
				Else
					num7 = num6
					num6 = num5
					num5 = num4 + 0.381966F * (num6 - num4)
					num9 = num8
					num8 = Torquebal.F(num5, TCondition)
				End If
			End While
			If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
				If num8 < num9 Then
					rst.set_RequiredUnbalance(TCondition, num5)
				Else
					rst.set_RequiredUnbalance(TCondition, num6)
				End If
				If RSWIN_DESC.rst.Unbalance = 0F Then
					RSWIN_DESC.rst.set_RequiredUnbalance(2, RSWIN_DESC.rst.PU.Unbalance)
				Else
					RSWIN_DESC.rst.set_RequiredUnbalance(2, RSWIN_DESC.rst.Unbalance)
				End If
				Torquebal.CalculateNewTorque(rst.get_RequiredUnbalance(TCondition), TCondition)
			Else
				If num8 < num9 Then
					rst.set_M(TCondition, num5)
				Else
					rst.set_M(TCondition, num6)
				End If
				Torquebal.CalculateNewTorque(rst.get_M(TCondition), TCondition)
				If rst.PU.UnitType = 6S Then
					rst.set_M(TCondition, CSng((CDbl(rst.get_M(TCondition)) - 14.696)))
				End If
			End If
			If Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(TCondition = 0, Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False))), RSWIN_DESC.rst.CalcMotorSize)) Then
				Motor.SelectMotorSizeByRatedHP(fRatedHP)
				Motor.SelectMotorSetting(0)
			End If
		End Sub

		Public Sub Balance_JPred(TCondition As Integer)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim flag As Boolean = True
			Dim num As Single
			Dim num2 As Single
			If flag = (rst.PU.UnitType = 7S) OrElse flag = (rst.PU.UnitType = 10S) Then
				num = 500F
				num2 = 100000F
			ElseIf flag = (rst.PU.UnitType = 6S) Then
				num = 25F
				num2 = 1000F
			ElseIf flag = (rst.PU.UnitType = 8S) OrElse flag = RSWIN_DESC.bBeamBalanced Then
				num = 100F
				num2 = 50000F
			Else
				num = 1000F
				num2 = 8000000F
			End If
			Dim fRatedHP As Single
			If TCondition = 0 AndAlso Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), rst.CalcMotorSize)) Then
				fRatedHP = Conversions.ToSingle(Motor.GetMotorInfo(0))
			End If
			Dim num3 As Single = num + 0.381966F * (num2 - num)
			Dim num4 As Single = num
			Dim num5 As Single = num3
			Dim num6 As Single = num3 + 0.381966F * (num2 - num3)
			Dim num7 As Single = num2
			Dim num8 As Single = Torquebal.F(num5, TCondition)
			Dim num9 As Single = Torquebal.F(num6, TCondition)
			While Math.Abs(num7 - num4) > 1E-05F * (Math.Abs(num5) + Math.Abs(num6))
				If num9 < num8 Then
					num4 = num5
					num5 = num6
					num6 = num5 + 0.381966F * (num7 - num5)
					num8 = num9
					num9 = Torquebal.F(num6, TCondition)
				Else
					num7 = num6
					num6 = num5
					num5 = num4 + 0.381966F * (num6 - num4)
					num9 = num8
					num8 = Torquebal.F(num5, TCondition)
				End If
			End While
			If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
				If num8 < num9 Then
					rst.set_RequiredUnbalance(TCondition, num5)
				Else
					rst.set_RequiredUnbalance(TCondition, num6)
				End If
				RSWIN_DESC.rst.set_RequiredUnbalance(2, RSWIN_DESC.rst.Unbalance)
				Torquebal.CalculateNewTorque(rst.get_RequiredUnbalance(TCondition), TCondition)
			Else
				If num8 < num9 Then
					rst.set_M(TCondition, num5)
				Else
					rst.set_M(TCondition, num6)
				End If
				Torquebal.CalculateNewTorque(rst.get_M(TCondition), TCondition)
				If rst.PU.UnitType = 6S Then
					rst.set_M(TCondition, CSng((CDbl(rst.get_M(TCondition)) - 14.696)))
				End If
			End If
			If Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(TCondition = 0, Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False))), rst.CalcMotorSize)) Then
				Motor.SelectMotorSizeByRatedHP(fRatedHP)
				Motor.SelectMotorSetting(0)
			End If
		End Sub

		Public Sub CalcPRHP(ByRef SurfPos As Single(), ByRef SurfLoad As Single(), ByRef DynaSource As Integer, ByRef Prhp As Single)
			' The following expression was wrapped in a checked-statement
			Try
				Dim ntsteps As Integer = CInt(RSWIN_DESC.rst.Ntsteps)
				Dim array As Single()
				Dim array2 As Single()
				Dim num3 As Integer
				Dim num7 As Integer
				If DynaSource = 2 Or ntsteps >= 150 Then
					array = New Single(ntsteps - 1 + 1 - 1) {}
					array2 = New Single(ntsteps - 1 + 1 - 1) {}
					Dim num As Integer = 0
					Dim num2 As Integer = ntsteps - 1
					For i As Integer = num To num2
						array(i) = SurfPos(i)
						array2(i) = SurfLoad(i)
					Next
					num3 = ntsteps
					Dim a As Single() = array
					Dim num4 As Single = 0F
					Dim num5 As Single = 0F
					Dim num6 As Single = CSng(num7)
					Dim num8 As Single = 0F
					Util.Maxmin(a, num4, num5, num6, num8)
					num7 = CInt(Math.Round(CDbl(num6)))
				Else
					num3 = ntsteps
					If num3 < 150 Then
						num3 = 150
					End If
					array2 = New Single(num3 - 1 + 1 - 1) {}
					array = New Single(num3 - 1 + 1 - 1) {}
					Dim num9 As Short = CShort(num7)
					kinemat.KinInterpolate(SurfPos, SurfLoad, array, array2, num9, RSWIN_DESC.rst.PU)
					num7 = CInt(num9)
				End If
				Dim num10 As Single = 60F / RSWIN_DESC.rst.SPM
				Dim num11 As Single = num10 / CSng(num3)
				Dim num12 As Single = 0F
				Dim num13 As Integer = 0
				Dim num14 As Integer = num3 - 1
				For i As Integer = num13 To num14
					Dim num15 As Single
					kinemat.ThetaFromPrp_Old(array(i), i < num7, num15, False)
					Dim theta As Single = num15
					Dim num8 As Single = 0F
					Dim num6 As Single = 0F
					Dim num16 As Single
					kinemat.Kinematics(theta, num8, num6, num16, RSWIN_DESC.rst.PU, -1, 0F)

						Dim num17 As Single = -(num16 * array2(i))
						num12 += num11 * num17

				Next
				Prhp = Math.Abs(num12 / num10 / 550F)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub Polhpsub(ByRef prvel As Single(), ByRef Prload As Single(), Ntsteps As Short, ByRef Prhp As Single)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num As Single = 60F / rst.SPM
				Dim num2 As Double = CDbl((num / CSng(rst.Ntsteps)))
				Dim num3 As Single = 0F
				Dim num4 As Short = 0S
				Dim num5 As Short = rst.Ntsteps - 1S
				For num6 As Short = num4 To num5
					Dim num7 As Single = -Prload(CInt(num6)) * prvel(CInt(num6))
					num3 = CSng((CDbl(num3) + num2 * CDbl(num7)))
				Next
				Prhp = Math.Abs(num3 / num / 550F)
				Application.DoEvents()
			Catch ex As Exception
			End Try
		End Sub

		Private Const R As Single = 0.618034F

		Private Const C As Single = 0.381966F

		Private Const GOLD As Single = 1.618034F

		Private Const TOL As Single = 1E-05F
	End Module
End Namespace
