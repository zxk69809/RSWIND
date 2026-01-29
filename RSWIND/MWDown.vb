Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module MWDown
		Private Function CalcRodStress() As Boolean
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim cRODSTAR As cRODSTAR = rst
				Dim surfPos As Single() = cRODSTAR.SurfPos
				Dim cRODSTAR2 As cRODSTAR = rst
				Dim surfLoad As Single() = cRODSTAR2.SurfLoad
				MWDown.DownWave(surfPos, surfLoad)
				cRODSTAR2.SurfLoad = surfLoad
				cRODSTAR.SurfPos = surfPos
				Dim array As Single()
				Dim array2 As Single()
				Dim array3 As Single()
				array = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
				array2 = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
				array3 = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
				array(0) = 0F
				array2(0) = rst.Pprload - rst.StuffingBoxFriction
				array3(0) = rst.Mprload + rst.StuffingBoxFriction
				Dim num As Short = 1S
				Dim num2 As Short = MWDown.miNumRodsStr
				For num3 As Short = num To num2
					' The following expression was wrapped in a checked-expression
					array(CInt(num3)) = array(CInt((num3 - 1S))) + MWDown.mrgRodsStr(CInt(num3)).length
					Dim num4 As Single = MWDown.RLoad(CInt(num3), 1)
					Dim num5 As Single = MWDown.RLoad(CInt(num3), 1)
					Dim num6 As Short = 1S
					Dim num7 As Short = rst.Ntsteps - 1S
					For num8 As Short = num6 To num7
						If MWDown.RLoad(CInt(num3), CInt(num8)) > num4 Then
							num4 = MWDown.RLoad(CInt(num3), CInt(num8))
						End If
						If MWDown.RLoad(CInt(num3), CInt(num8)) < num5 Then
							num5 = MWDown.RLoad(CInt(num3), CInt(num8))
						End If
					Next
					array2(CInt(num3)) = num4
					array3(CInt(num3)) = num5
				Next
				Dim num9 As Short = 1S
				Dim num10 As Short = MWDown.miNumRodsStr
				For num3 As Short = num9 To num10
					' The following expression was wrapped in a checked-expression
					Dim num11 As Single = MWDown.EffRodArea(MWDown.mrgRodsStr(CInt(num3)), CShort(RODUTIL.IsSinkerBar(CInt(num3))))
					Dim num12 As Single
					Dim num13 As Single
					If rst.gbIncludeBuoyancy Then
						num12 = 0F
						num13 = 0F
					Else
						Dim num14 As Single
						If num3 = 1S Then
							num14 = num11
						Else
							' The following expression was wrapped in a checked-expression
							num14 = MWDown.EffRodArea(MWDown.mrgRodsStr(CInt((num3 - 1S))), CShort(RODUTIL.IsSinkerBar(CInt((num3 - 1S)))))
							If num14 > num11 Then
								num14 = num11
							End If
						End If
						num12 = CSng(((CDbl(rst.TubingPressure) + 0.433 * CDbl(rst.FluidSPGR) * CDbl(array(CInt((num3 - 1S))))) * CDbl(num14)))
						num13 = CSng(((CDbl(rst.TubingPressure) + 0.433 * CDbl(rst.FluidSPGR) * CDbl(array(CInt(num3)))) * CDbl(num11)))
					End If
					MWDown.smaxTop(CInt(num3)) = (array2(CInt((num3 - 1S))) + num12) / num11
					MWDown.sminTop(CInt(num3)) = (array3(CInt((num3 - 1S))) + num12) / num11
					MWDown.smaxBot(CInt(num3)) = (array2(CInt(num3)) + num13) / num11
					MWDown.sminBot(CInt(num3)) = (array3(CInt(num3)) + num13) / num11
					If num3 > 1S AndAlso (MWDown.mrgRodsStr(CInt((num3 - 1S))).Diameter = MWDown.mrgRodsStr(CInt(num3)).Diameter And MWDown.sminBot(CInt(num3)) >= MWDown.sminTop(CInt(num3))) Then
						MWDown.sminTop(CInt(num3)) = CSng((CDbl(MWDown.sminBot(CInt(num3))) + CDbl(MWDown.mrgRodsStr(CInt(num3)).length) * (CDbl(MWDown.mrgRodsStr(CInt(num3)).RodWeight) - 1.07 * (62.4 * CDbl(rst.FluidSPGR) * CDbl(MWDown.mrgRodsStr(CInt(num3)).Area) / 144.0)) / CDbl(num11)))
						MWDown.sminBot(CInt((num3 - 1S))) = MWDown.sminTop(CInt(num3))
					End If
				Next
				If rst.gbIncludeBuoyancy Then
					MWDown.sminBot(CInt(MWDown.miNumRodsStr)) = CSng((-CSng((CDbl(rst.FluidSPGR) * 0.433 * CDbl(array(CInt(MWDown.miNumRodsStr))) * 1.075 + CDbl(rst.TubingPressure)))))
				Else
					MWDown.sminBot(CInt(MWDown.miNumRodsStr)) = 0F
				End If
				MWDown.sminBot(CInt(MWDown.miNumRodsStr)) = MWDown.sminBot(CInt(MWDown.miNumRodsStr)) - rst.PumpFriction / MWDown.mrgRodsStr(CInt(MWDown.miNumRodsStr)).Area
				Dim num15 As Short = 1S
				Dim num16 As Short = MWDown.miNumRodsStr
				For num3 As Short = num15 To num16
					RODUTIL.LookupTensileStrength(MWDown.mrgRodsStr(CInt(num3)))
					Dim num17 As Single = MWDown.smaxTop(CInt(num3)) - MWDown.sminTop(CInt(num3))
					Select Case RODUTIL.LookupStressMethod(MWDown.mrgRodsStr(CInt(num3)))
						Case 0
							Dim num18 As Single = CSng(((CDbl((MWDown.mrgRodsStr(CInt(num3)).TensileStrength / 4F)) + 0.5625 * CDbl(MWDown.sminTop(CInt(num3)))) * CDbl(rst.ServiceFactor)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 1
							Dim num18 As Single = CSng(((CDbl(MWDown.mrgRodsStr(CInt(num3)).TensileStrength) / 2.8 + 0.375 * CDbl(MWDown.sminTop(CInt(num3)))) * CDbl(rst.ServiceFactor)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 2
							Dim num18 As Single = CSng(((CDbl((MWDown.mrgRodsStr(CInt(num3)).TensileStrength / 3F)) + 0.5625 * CDbl(MWDown.sminTop(CInt(num3)))) * CDbl(rst.ServiceFactor)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 3
							Dim num18 As Single = CSng(((55000.0 + 0.2143 * CDbl(MWDown.sminTop(CInt(num3)))) * CDbl(rst.ServiceFactor)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 4
							rst.StressL(CInt(num3)) = CSng(((CDbl(MWDown.smaxTop(CInt(num3))) - 0.5625 * CDbl(MWDown.sminTop(CInt(num3)))) / CDbl((MWDown.mrgRodsStr(CInt(num3)).TensileStrength / 4F * rst.ServiceFactor))))
						Case 5
							Dim num20 As Single = MWDown.sminTop(CInt(num3)) / 5000F
							Dim num18 As Single = CSng((13756.4 + 9816.09 * CDbl(num20) + 8892.61 * Math.Pow(CDbl(num20), 2.0) - 11380.1 * Math.Pow(CDbl(num20), 3.0) + 4828.34 * Math.Pow(CDbl(num20), 4.0) - 993.188 * Math.Pow(CDbl(num20), 5.0) + 100.304 * Math.Pow(CDbl(num20), 6.0) - 3.98389 * Math.Pow(CDbl(num20), 7.0)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 6
							Dim num21 As Single = CSng((CDbl(MWDown.sminTop(CInt(num3))) / 5428.6))
							If CDbl(num21) < 0.3 Then
								num21 = 0.3F
							End If
							Dim num18 As Single = CSng((CDbl((19268F + 6152F * num21)) - 964.2 * Math.Pow(CDbl(num21), 2.0) + 67.5 * Math.Pow(CDbl(num21), 3.0)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 7
							Dim diameter As Single = MWDown.mrgRodsStr(CInt(num3)).Diameter
							Dim num18 As Single
							If diameter < 0.8125F Then
								num18 = CSng((0.7 * CDbl(MWDown.sminTop(CInt(num3))) + 17778.0))
							ElseIf diameter >= 0.8125F AndAlso diameter <= 1.125F Then
								num18 = CSng((0.7 * CDbl(MWDown.sminTop(CInt(num3))) + 20000.0))
							ElseIf diameter > 1.125F Then
								num18 = CSng((0.625 * CDbl(MWDown.sminTop(CInt(num3))) + 19400.0))
							End If
							If num18 > 30000F Then
								num18 = 30000F
							End If
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 8
							rst.StressL(CInt(num3)) = MWDown.smaxTop(CInt(num3)) / 58000F
						Case 9
							Dim num18 As Single
							If MWDown.sminTop(CInt(num3)) >= 1250F And MWDown.sminTop(CInt(num3)) <= 5000F Then
								num18 = MWDown.sminTop(CInt(num3)) + 22500F
							ElseIf MWDown.sminTop(CInt(num3)) > 5000F Then
								num18 = MWDown.sminTop(CInt(num3)) / 4F + 26250F
							ElseIf MWDown.sminTop(CInt(num3)) < 1250F Then
								num18 = MWDown.sminTop(CInt(num3)) + 22500F
								If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										Util.Errmsg(RSWIN_DESC.sMinFiberodStressWarning_Meter)
									Else
										Util.Errmsg(RSWIN_DESC.sMinFiberodStressWarning_English)
									End If
								End If
							End If
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 10
							Dim num18 As Single = 50000F * RSWIN_DESC.rst.ServiceFactor
							RSWIN_DESC.rst.StressL(CInt(num3)) = MWDown.smaxTop(CInt(num3)) / num18
						Case 11
							Dim num18 As Single = 12500F + MWDown.sminTop(CInt(num3)) / 2F
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 12
							Dim num18 As Single = CSng(((CDbl(MWDown.mrgRodsStr(CInt(num3)).TensileStrength) / 2.3 + 0.375 * CDbl(MWDown.sminTop(CInt(num3)))) * CDbl(rst.ServiceFactor)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 13
							Dim num18 As Single
							If MWDown.sminTop(CInt(num3)) >= 0F And MWDown.sminTop(CInt(num3)) <= 5000F Then
								num18 = CSng((2.2 * CDbl(MWDown.sminTop(CInt(num3))) + 14000.0))
							ElseIf MWDown.sminTop(CInt(num3)) > 5000F And MWDown.sminTop(CInt(num3)) <= 7000F Then
								num18 = CSng((1.25 * CDbl(MWDown.sminTop(CInt(num3))) + 18750.0))
							ElseIf MWDown.sminTop(CInt(num3)) > 7000F And MWDown.sminTop(CInt(num3)) <= 12000F Then
								num18 = CSng((0.5 * CDbl(MWDown.sminTop(CInt(num3))) + 24000.0))
							ElseIf MWDown.sminTop(CInt(num3)) > 12000F And MWDown.sminTop(CInt(num3)) <= 35000F Then
								num18 = CSng((0.21739130434782608 * CDbl(MWDown.sminTop(CInt(num3))) + 27391.3))
							End If
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 14
							Dim num18 As Single = CSng((CDbl(MWDown.sminTop(CInt(num3))) * 0.3125 + 27500.0))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 15
							Dim num18 As Single
							If MWDown.sminTop(CInt(num3)) >= 1000F And MWDown.sminTop(CInt(num3)) <= 5000F Then
								num18 = CSng((2.1875 * CDbl(MWDown.sminTop(CInt(num3))) + 14062.5))
							ElseIf MWDown.sminTop(CInt(num3)) > 5000F And MWDown.sminTop(CInt(num3)) < 10000F Then
								num18 = CSng((0.9332 * CDbl(MWDown.sminTop(CInt(num3))) + 20334.0))
							ElseIf MWDown.sminTop(CInt(num3)) >= 10000F And MWDown.sminTop(CInt(num3)) < 35000F Then
								num18 = CSng((0.21336 * CDbl(MWDown.sminTop(CInt(num3))) + 27532.4))
							ElseIf MWDown.sminTop(CInt(num3)) >= 35000F Then
								If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										Util.Errmsg(RSWIN_DESC.sMaxFibercoStressWarning_Meter)
									Else
										Util.Errmsg(RSWIN_DESC.sMaxFibercoStressWarning_English)
									End If
								End If
							ElseIf MWDown.sminTop(CInt(num3)) < 1000F Then
								num18 = CSng((2.1875 * CDbl(MWDown.sminTop(CInt(num3))) + 14062.5))
								If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										Util.Errmsg(RSWIN_DESC.sMinFibercoStressWarning_Meter)
									Else
										Util.Errmsg(RSWIN_DESC.sMinFibercoStressWarning_English)
									End If
								End If
							End If
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
						Case 16
							Dim num18 As Single = CSng(((CDbl(rst.Sections(CInt(num3)).TensileStrength) / 2.6 + 0.375 * CDbl(MWDown.sminTop(CInt(num3)))) * CDbl(rst.ServiceFactor)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num3))
							rst.StressL(CInt(num3)) = num17 / num19
					End Select
					If rst.StressL(CInt(num3)) < 0F Then
						rst.StressL(CInt(num3)) = 3F
					End If
				Next
				result = flag
			Catch ex As Exception
				result = True
			End Try
			Return result
		End Function

		Private Function CalcStressLoads() As Boolean
			Dim result As Boolean = True
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If MWDown.miNumRodsStr <> 1S Then
				' The following expression was wrapped in a checked-expression
				Dim array As Single() = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
				array(0) = 0F
				Dim num As Short = 1S
				Dim num2 As Short = MWDown.miNumRodsStr
				For num3 As Short = num To num2
					' The following expression was wrapped in a checked-expression
					array(CInt(num3)) = array(CInt((num3 - 1S))) + MWDown.mrgRodsStr(CInt(num3)).length
				Next
				Dim num4 As Short = 1S
				Dim num5 As Short = MWDown.miNumRodsStr
				For num3 As Short = num4 To num5
					' The following expression was wrapped in a checked-expression
					Dim num6 As Single = MWDown.EffRodArea(MWDown.mrgRodsStr(CInt(num3)), CShort(RODUTIL.IsSinkerBar(CInt(num3))))
					Dim num7 As Single
					Dim num8 As Single
					If rst.gbIncludeBuoyancy Then
						num7 = 0F
						num8 = 0F
					Else
						Dim num9 As Single
						If num3 = 1S Then
							num9 = num6
						Else
							' The following expression was wrapped in a checked-expression
							num9 = MWDown.EffRodArea(MWDown.mrgRodsStr(CInt((num3 - 1S))), CShort(RODUTIL.IsSinkerBar(CInt((num3 - 1S)))))
							If num9 > num6 Then
								num9 = num6
							End If
						End If
						num7 = CSng(((CDbl(rst.TubingPressure) + 0.433 * CDbl(rst.FluidSPGR) * CDbl(array(CInt((num3 - 1S))))) * CDbl(num9)))
						num8 = CSng(((CDbl(rst.TubingPressure) + 0.433 * CDbl(rst.FluidSPGR) * CDbl(array(CInt(num3)))) * CDbl(num6)))
					End If
					rst.maxStressTop(CInt(num3)) = rst.maxStressTop(CInt(num3)) + num7 / num6
					rst.minStressTop(CInt(num3)) = rst.minStressTop(CInt(num3)) + num7 / num6
					If num3 <> MWDown.miNumRodsStr Then
						rst.maxStressBot(CInt(num3)) = rst.maxStressBot(CInt(num3)) + num8 / num6
						rst.minStressBot(CInt(num3)) = rst.minStressBot(CInt(num3)) + num8 / num6
					Else
						Dim num10 As Double
						Try
							num10 = 3.141592653589793 * Math.Pow(CDbl(MWDown.mrgRodsStr(CInt(num3)).Diameter), 2.0) / 4.0
						Catch ex As Exception
							num10 = 0.0
						End Try
						If CDbl(num6) > num10 Then
							rst.minStressBot(CInt(num3)) = rst.PumpFriction / num6 * -1F
						Else
							rst.minStressBot(CInt(num3)) = CSng((CDbl(rst.PumpFriction) / num10 * -1.0))
						End If
					End If
				Next
			End If
			Dim num11 As Short = 1S
			Dim num12 As Short = MWDown.miNumRodsStr
			For num3 As Short = num11 To num12
				RODUTIL.LookupTensileStrength(MWDown.mrgRodsStr(CInt(num3)))
				Dim num13 As Single = rst.maxStressTop(CInt(num3)) - rst.minStressTop(CInt(num3))
				Select Case RODUTIL.LookupStressMethod(MWDown.mrgRodsStr(CInt(num3)))
					Case 0
						Dim num14 As Single = CSng(((CDbl((MWDown.mrgRodsStr(CInt(num3)).TensileStrength / 4F)) + 0.5625 * CDbl(rst.minStressTop(CInt(num3)))) * CDbl(rst.ServiceFactor)))
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 1
						Dim num14 As Single = CSng(((CDbl(MWDown.mrgRodsStr(CInt(num3)).TensileStrength) / 2.8 + 0.375 * CDbl(rst.minStressTop(CInt(num3)))) * CDbl(rst.ServiceFactor)))
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 2
						Dim num14 As Single = CSng(((CDbl((MWDown.mrgRodsStr(CInt(num3)).TensileStrength / 3F)) + 0.5625 * CDbl(rst.minStressTop(CInt(num3)))) * CDbl(rst.ServiceFactor)))
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 3
						Dim num14 As Single = CSng(((55000.0 + 0.2143 * CDbl(rst.minStressTop(CInt(num3)))) * CDbl(rst.ServiceFactor)))
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 4
						rst.StressL(CInt(num3)) = CSng(((CDbl(rst.maxStressTop(CInt(num3))) - 0.5625 * CDbl(rst.minStressTop(CInt(num3)))) / CDbl((MWDown.mrgRodsStr(CInt(num3)).TensileStrength / 4F * rst.ServiceFactor))))
					Case 5
						Dim num16 As Single = rst.minStressTop(CInt(num3)) / 5000F
						Dim num14 As Single = CSng((13756.4 + 9816.09 * CDbl(num16) + 8892.61 * Math.Pow(CDbl(num16), 2.0) - 11380.1 * Math.Pow(CDbl(num16), 3.0) + 4828.34 * Math.Pow(CDbl(num16), 4.0) - 993.188 * Math.Pow(CDbl(num16), 5.0) + 100.304 * Math.Pow(CDbl(num16), 6.0) - 3.98389 * Math.Pow(CDbl(num16), 7.0)))
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 6
						Dim num17 As Single = CSng((CDbl(rst.minStressTop(CInt(num3))) / 5428.6))
						If CDbl(num17) < 0.3 Then
							num17 = 0.3F
						End If
						Dim num14 As Single = CSng((CDbl((19268F + 6152F * num17)) - 964.2 * Math.Pow(CDbl(num17), 2.0) + 67.5 * Math.Pow(CDbl(num17), 3.0)))
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 7
						Dim diameter As Single = MWDown.mrgRodsStr(CInt(num3)).Diameter
						Dim num14 As Single
						If diameter < 0.8125F Then
							num14 = CSng((0.7 * CDbl(rst.minStressTop(CInt(num3))) + 17778.0))
						ElseIf diameter >= 0.8125F AndAlso diameter <= 1.125F Then
							num14 = CSng((0.7 * CDbl(rst.minStressTop(CInt(num3))) + 20000.0))
						ElseIf diameter > 1.125F Then
							num14 = CSng((0.625 * CDbl(rst.minStressTop(CInt(num3))) + 19400.0))
						End If
						If num14 > 30000F Then
							num14 = 30000F
						End If
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 8
						rst.StressL(CInt(num3)) = rst.maxStressTop(CInt(num3)) / 58000F
					Case 9
						Dim num14 As Single
						If rst.minStressTop(CInt(num3)) >= 1250F And rst.minStressTop(CInt(num3)) <= 5000F Then
							num14 = rst.minStressTop(CInt(num3)) + 22500F
						ElseIf rst.minStressTop(CInt(num3)) > 5000F Then
							num14 = rst.minStressTop(CInt(num3)) / 4F + 26250F
						ElseIf rst.minStressTop(CInt(num3)) < 1250F Then
							num14 = rst.minStressTop(CInt(num3)) + 22500F
							If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									Util.Errmsg(RSWIN_DESC.sMinFiberodStressWarning_Meter)
								Else
									Util.Errmsg(RSWIN_DESC.sMinFiberodStressWarning_English)
								End If
							End If
						End If
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 11
						Dim num14 As Single = 12500F + rst.minStressTop(CInt(num3)) / 2F
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 12
						Dim num14 As Single = CSng(((CDbl(MWDown.mrgRodsStr(CInt(num3)).TensileStrength) / 2.3 + 0.375 * CDbl(rst.minStressTop(CInt(num3)))) * CDbl(rst.ServiceFactor)))
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 13
						Dim num14 As Single
						If rst.minStressTop(CInt(num3)) >= 0F And rst.minStressTop(CInt(num3)) <= 5000F Then
							num14 = CSng((2.2 * CDbl(rst.minStressTop(CInt(num3))) + 14000.0))
						ElseIf rst.minStressTop(CInt(num3)) > 5000F And rst.minStressTop(CInt(num3)) <= 7000F Then
							num14 = CSng((1.25 * CDbl(rst.minStressTop(CInt(num3))) + 18750.0))
						ElseIf rst.minStressTop(CInt(num3)) > 7000F And rst.minStressTop(CInt(num3)) <= 12000F Then
							num14 = CSng((0.5 * CDbl(rst.minStressTop(CInt(num3))) + 24000.0))
						ElseIf rst.minStressTop(CInt(num3)) > 12000F And rst.minStressTop(CInt(num3)) <= 35000F Then
							num14 = CSng((0.21739130434782608 * CDbl(rst.minStressTop(CInt(num3))) + 27391.3))
						End If
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 14
						Dim num14 As Single = CSng((CDbl(rst.minStressTop(CInt(num3))) * 0.3125 + 27500.0))
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 15
						Dim num14 As Single
						If rst.minStressTop(CInt(num3)) >= 1000F And rst.minStressTop(CInt(num3)) <= 5000F Then
							num14 = CSng((2.1875 * CDbl(rst.minStressTop(CInt(num3))) + 14062.5))
						ElseIf rst.minStressTop(CInt(num3)) > 5000F And rst.minStressTop(CInt(num3)) < 10000F Then
							num14 = CSng((0.9332 * CDbl(rst.minStressTop(CInt(num3))) + 20334.0))
						ElseIf rst.minStressTop(CInt(num3)) >= 10000F And rst.minStressTop(CInt(num3)) < 35000F Then
							num14 = CSng((0.21336 * CDbl(rst.minStressTop(CInt(num3))) + 27532.4))
						ElseIf rst.minStressTop(CInt(num3)) >= 35000F Then
							If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									Util.Errmsg(RSWIN_DESC.sMaxFibercoStressWarning_Meter)
								Else
									Util.Errmsg(RSWIN_DESC.sMaxFibercoStressWarning_English)
								End If
							End If
						ElseIf rst.minStressTop(CInt(num3)) < 1000F Then
							num14 = CSng((2.1875 * CDbl(rst.minStressTop(CInt(num3))) + 14062.5))
							If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									Util.Errmsg(RSWIN_DESC.sMinFibercoStressWarning_Meter)
								Else
									Util.Errmsg(RSWIN_DESC.sMinFibercoStressWarning_English)
								End If
							End If
						End If
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
					Case 16
						Dim num14 As Single = CSng(((CDbl(rst.Sections(CInt(num3)).TensileStrength) / 2.6 + 0.375 * CDbl(rst.minStressTop(CInt(num3)))) * CDbl(rst.ServiceFactor)))
						Dim num15 As Single = num14 - rst.minStressTop(CInt(num3))
						rst.StressL(CInt(num3)) = num13 / num15
				End Select
				If rst.StressL(CInt(num3)) < 0F Then
					rst.StressL(CInt(num3)) = 3F
				End If
			Next
			Return result
		End Function

		Private Sub DownWave(ByRef SurfPos As Single(), ByRef SurfLoad As Single())
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num As Single
				Dim num2 As Single
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					num = RSWIN_DESC.rst.PercentUpstrokeSPM / 100F
					num2 = RSWIN_DESC.rst.PercentDownstrokeSPM / 100F
				End If
				Dim num3 As Single = 60F / rst.SPM
				Dim array As Single()
				Dim array2 As Single()
				Dim num4 As Short
				Dim num5 As Short
				array = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
				array2 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
				num4 = 0S
				num5 = rst.Ntsteps - 1S
				For num6 As Short = num4 To num5
					array(CInt(num6)) = SurfPos(CInt(num6))
					array2(CInt(num6)) = SurfLoad(CInt(num6))
				Next
				MWDown.SortCard(array, array2, rst.Ntsteps)
				Dim num7 As Short = 0S
				Dim num8 As Short = rst.NtstepsUpstroke - 1S
				For num6 As Short = num7 To num8
					array2(CInt(num6)) = array2(CInt(num6)) - rst.StuffingBoxFriction
				Next
				Dim ntstepsUpstroke As Short = rst.NtstepsUpstroke
				Dim num9 As Short = rst.Ntsteps - 1S
				For num6 As Short = ntstepsUpstroke To num9
					array2(CInt(num6)) = array2(CInt(num6)) + rst.StuffingBoxFriction
				Next
				Dim array3 As Single(,)
				Dim array4 As Single(,)
				Dim array5 As Single()
				Dim array6 As Single()
				Dim array7 As Single()
				Dim array8 As Single()
				Dim array9 As Single()
				Dim array10 As Single()
				Dim num10 As Short
				Dim num11 As Short
				array3 = New Single(CInt((rst.Ntsteps + 1S)) - 1, 12) {}
				array4 = New Single(CInt((rst.Ntsteps + 1S)) - 1, 12) {}
				array5 = New Single(CInt((rst.Ntsteps + 1S)) - 1) {}
				array6 = New Single(CInt((rst.Ntsteps + 1S)) - 1) {}
				array7 = New Single(12) {}
				array8 = New Single(12) {}
				array9 = New Single(12) {}
				array10 = New Single(12) {}
				MWDown.RPos = New Single(12, CInt((rst.Ntsteps + 1S)) - 1) {}
				MWDown.RLoad = New Single(12, CInt((rst.Ntsteps + 1S)) - 1) {}
				RSWIN_DESC.RLoad_Save = New Single(12, CInt((rst.Ntsteps + 1S)) - 1) {}
				num3 = 60F / rst.SPM
				num10 = 0S
				num11 = rst.Ntsteps - 1S
				For num6 As Short = num10 To num11
					If RSWIN_DESC.rst.PU.UnitType = 10S And RSWIN_DESC.rst.NtstepsUpstroke <> 0S Then
						' The following expression was wrapped in a checked-expression
						If num6 <= RSWIN_DESC.rst.NtstepsUpstroke - 1S Then
							num3 = 60F / RSWIN_DESC.rst.SPM * 2F * num
						Else
							num3 = 60F / RSWIN_DESC.rst.SPM * 2F * num2
						End If
					End If
					array5(CInt(num6)) = CSng(num6) * num3 / CSng(rst.Ntsteps)
				Next
				If RSWIN_DESC.rst.PU.UnitType = 10S And RSWIN_DESC.rst.NtstepsUpstroke <> 0S Then
					' The following expression was wrapped in a checked-expression
					If rst.Ntsteps <= RSWIN_DESC.rst.NtstepsUpstroke - 1S Then
						num3 = 60F / RSWIN_DESC.rst.SPM * 2F * num
					Else
						num3 = 60F / RSWIN_DESC.rst.SPM * 2F * num2
					End If
				End If
				array5(CInt(rst.Ntsteps)) = array5(0) + num3
				MWDown.omega = CSng((6.283185307179586 / CDbl(num3)))
				Dim num12 As Short = 0S
				Dim ntsteps As Short = rst.Ntsteps
				For num6 As Short = num12 To ntsteps
					If RSWIN_DESC.rst.PU.UnitType = 10S And RSWIN_DESC.rst.NtstepsUpstroke <> 0S Then
						' The following expression was wrapped in a checked-expression
						If num6 <= RSWIN_DESC.rst.NtstepsUpstroke - 1S Then
							MWDown.omega = CSng((6.283185307179586 / CDbl((60F / RSWIN_DESC.rst.SPM * 2F * num))))
						Else
							MWDown.omega = CSng((6.283185307179586 / CDbl((60F / RSWIN_DESC.rst.SPM * 2F * num2))))
						End If
					End If
					Dim num13 As Single = MWDown.omega * array5(CInt(num6))
					array3(CInt(num6), 1) = CSng(Math.Cos(CDbl(num13)))
					array3(CInt(num6), 2) = 2F * array3(CInt(num6), 1) * array3(CInt(num6), 1) - 1F
					array4(CInt(num6), 1) = CSng(Math.Sin(CDbl(num13)))
					array4(CInt(num6), 2) = 2F * array3(CInt(num6), 1) * array4(CInt(num6), 1)
					Dim num14 As Short = 3S
					Do
						' The following expression was wrapped in a checked-expression
						' The following expression was wrapped in a checked-expression
						array3(CInt(num6), CInt(num14)) = 2F * array3(CInt(num6), 1) * array3(CInt(num6), CInt((num14 - 1S))) - array3(CInt(num6), CInt((num14 - 2S)))
						array4(CInt(num6), CInt(num14)) = 2F * array3(CInt(num6), 1) * array4(CInt(num6), CInt((num14 - 1S))) - array4(CInt(num6), CInt((num14 - 2S)))
						num14 += 1S
					Loop While num14 <= 12S
				Next
				array6(0) = (array5(CInt(rst.Ntsteps)) - array5(CInt((rst.Ntsteps - 1S))) + (array5(1) - array5(0))) / 2F
				Dim num15 As Single = array2(0) * array6(0)
				Dim num16 As Single = -array(0) / 12F * array6(0)
				Dim num17 As Short = 1S
				Dim num18 As Short = rst.Ntsteps - 1S
				Dim num19 As Short
				num19 = num17
				While num19 <= num18
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					array6(CInt(num19)) = (array5(CInt((num19 + 1S))) - array5(CInt((num19 - 1S)))) / 2F
					num15 += array6(CInt(num19)) * array2(CInt(num19))
					num16 += array6(CInt(num19)) * -array(CInt(num19)) / 12F
					num19 += 1S
				End While
				num15 /= num3
				num16 /= num3
				num19 = 1S
				Do
					array9(CInt(num19)) = 0F
					array10(CInt(num19)) = 0F
					array8(CInt(num19)) = 0F
					array7(CInt(num19)) = 0F
					Dim num20 As Short = 0S
					Dim num21 As Short = rst.Ntsteps - 1S
					For num6 As Short = num20 To num21
						Dim num22 As Single = array3(CInt(num6), CInt(num19)) * array6(CInt(num6))
						Dim num23 As Single = array4(CInt(num6), CInt(num19)) * array6(CInt(num6))
						array9(CInt(num19)) = array9(CInt(num19)) + num22 * array2(CInt(num6))
						array10(CInt(num19)) = array10(CInt(num19)) + num23 * array2(CInt(num6))
						array8(CInt(num19)) = array8(CInt(num19)) + num22 * -array(CInt(num6)) / 12F
						array7(CInt(num19)) = array7(CInt(num19)) + num23 * -array(CInt(num6)) / 12F
					Next
					array9(CInt(num19)) = array9(CInt(num19)) * 2F / num3
					array10(CInt(num19)) = array10(CInt(num19)) * 2F / num3
					array8(CInt(num19)) = array8(CInt(num19)) * 2F / num3
					array7(CInt(num19)) = array7(CInt(num19)) * 2F / num3
					num19 += 1S
				Loop While num19 <= 12S
				Dim num24 As Single = rst.UpstrokeFriction
				Dim num25 As Single = rst.DownstrokeFriction
				If RSWIN_DESC.rst.bHasFGlass Then
					If CDbl(num24) < 0.5 Then
						num24 = 0.5F
					End If
					If CDbl(num25) < 0.5 Then
						num25 = 0.5F
					End If
				End If
				Dim dampCoeff As Single = (num24 + num25) / 2F
				Dim num26 As Single = 0F
				Dim num27 As Short = 1S
				Dim num28 As Short = MWDown.miNumRodsStr
				For num6 As Short = num27 To num28
					num26 += MWDown.mrgRodsStr(CInt(num6)).length
					MWDown.Wstring(array8, array7, array10, array9, dampCoeff, MWDown.mrgRodsStr(CInt(num6)))
					Dim area As Single = MWDown.mrgRodsStr(CInt(num6)).Area
					Dim num29 As Single
					If num6 = MWDown.miNumRodsStr Then
						num29 = 0F
					Else
						' The following expression was wrapped in a checked-expression
						Dim area2 As Single = MWDown.mrgRodsStr(CInt((num6 + 1S))).Area
						If area < area2 Then
							num29 = 0F
						Else
							num29 = (area - area2) * (num26 * rst.FluidDens / 144F + rst.TubingPressure)
						End If
					End If
					Dim num30 As Single = MWDown.mrgRodsStr(CInt(num6)).length * MWDown.mrgRodsStr(CInt(num6)).length / MWDown.mrgRodsStr(CInt(num6)).Elasticity * MWDown.mrgRodsStr(CInt(num6)).RodDensity / 288F
					num15 -= MWDown.mrgRodsStr(CInt(num6)).length * MWDown.mrgRodsStr(CInt(num6)).RodWeight - num29
					num16 = num16 + num30 + num15 * MWDown.mrgRodsStr(CInt(num6)).length / (MWDown.mrgRodsStr(CInt(num6)).Elasticity * area)
					Dim num31 As Short = 0S
					Dim num32 As Short = rst.Ntsteps - 1S
					num19 = num31
					While num19 <= num32
						Dim num33 As Single = num15
						Dim num34 As Single = num16
						Dim num14 As Short = 1S
						Do
							Dim num22 As Single = array3(CInt(num19), CInt(num14))
							Dim num23 As Single = array4(CInt(num19), CInt(num14))
							num33 = num33 + num22 * array9(CInt(num14)) + num23 * array10(CInt(num14))
							num34 = num34 + num22 * array8(CInt(num14)) + num23 * array7(CInt(num14))
							num14 += 1S
						Loop While num14 <= 12S
						MWDown.RLoad(CInt(num6), CInt(num19)) = num33
						MWDown.RPos(CInt(num6), CInt(num19)) = num34
						RSWIN_DESC.RLoad_Save(CInt(num6), CInt(num19)) = num33
						num19 += 1S
					End While
				Next
				Array.Clear(array3, 0, array3.Length)
				Array.Clear(array4, 0, array4.Length)
				Array.Clear(array6, 0, array6.Length)
				Array.Clear(array8, 0, array8.Length)
				Array.Clear(array7, 0, array7.Length)
				Array.Clear(array9, 0, array9.Length)
				Array.Clear(array10, 0, array10.Length)
			Catch ex As Exception
			End Try
		End Sub

		Public Function EffRodArea(ByRef sect As RSWIN_DESC.RodSection, bIsSinkerBar As Short) As Single
			Dim num As Integer
			Dim num4 As Single
			Dim num5 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim num2 As Single
				If Not RODUTIL.IsSteel(CInt(sect.Grade)) <> 0 Then
					num2 = sect.Area
				ElseIf RODUTIL.IsNoNeck(sect.Grade) Then
					num2 = sect.Area
				Else
					Dim num3 As Single = 0F
					Dim diameter As Single = sect.Diameter
					If diameter > 1.624F Then
						num3 = 1F
					ElseIf diameter > 1.49F Then
						num3 = 1F
					ElseIf diameter > 1.374F Then
						num3 = 1F
					ElseIf diameter > 1.24F AndAlso bIsSinkerBar <> 0S Then
						num3 = 0.875F
					End If
					If num3 = 0F Then
						num2 = sect.Area
					Else
						num2 = CSng((3.141592653589793 * Math.Pow(CDbl(num3), 2.0) / 4.0))
					End If
				End If
				num4 = num2
				IL_CA:
				GoTo IL_111
				IL_CC:
				num5 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_E2:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_CC
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_111:
			Dim result As Single = num4
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Sub SortCard(ByRef dSurfPos As Single(), ByRef dSurfLoad As Single(), dNtsteps As Short)
			' The following expression was wrapped in a checked-statement
			Dim array As Single() = New Single(CInt((dNtsteps - 1S + 1S)) - 1) {}
			Dim array2 As Single() = New Single(CInt((dNtsteps - 1S + 1S)) - 1) {}
			Try
				Dim a As Single() = dSurfPos
				Dim num As Single = 0F
				Dim num2 As Single = 0F
				Dim num3 As Single = 0F
				Dim num5 As Short
				Dim num4 As Single = CSng(num5)
				Util.Maxmin(a, num, num2, num3, num4)
				num5 = CShort(Math.Round(CDbl(num4)))
				Dim num6 As Short = 0S
				Dim num7 As Short = dNtsteps - 1S
				Dim num11 As Short

					For num8 As Short = num6 To num7
						array2(CInt(num8)) = dSurfLoad(CInt(((num5 + num8) Mod dNtsteps)))
						array(CInt(num8)) = dSurfPos(CInt(((num5 + num8) Mod dNtsteps)))
					Next
					Dim num9 As Short = 0S
					Dim num10 As Short = dNtsteps - 1S
					For num8 As Short = num9 To num10
						dSurfLoad(CInt(num8)) = array2(CInt(num8))
						dSurfPos(CInt(num8)) = array(CInt(num8))
					Next
					Dim a2 As Single() = dSurfPos
					num4 = 0F
					num3 = 0F
					num2 = CSng(num11)
					num = 0F
					Util.Maxmin(a2, num4, num3, num2, num)

				num11 = CShort(Math.Round(CDbl(num2)))
				RSWIN_DESC.rst.NtstepsUpstroke = num11
			Catch ex As Exception
			End Try
		End Sub

		Public Function JPred_StressAnalysis() As Boolean
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			MWDown.miNumRodsStr = rst.NumRods
			MWDown.mrgRodsStr = New RSWIN_DESC.RodSection(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
			Dim num As Integer = 1
			Dim num2 As Integer = CInt(MWDown.miNumRodsStr)
			For i As Integer = num To num2
				MWDown.mrgRodsStr(i) = rst.Sections(i)
			Next
			MWDown.smaxTop = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
			MWDown.sminTop = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
			MWDown.smaxBot = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
			MWDown.sminBot = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
			Dim result As Boolean = MWDown.CalcRodStress()
			If MWDown.miNumRodsStr <> rst.NumRods Then
				MWDown.sminBot(CInt((MWDown.miNumRodsStr - 1S))) = MWDown.sminBot(CInt(MWDown.miNumRodsStr))
			End If
			Dim num3 As Integer = 1
			Dim numRods As Integer = CInt(rst.NumRods)
			For i As Integer = num3 To numRods
				rst.maxStressTop(i) = MWDown.smaxTop(i)
				rst.minStressTop(i) = MWDown.sminTop(i)
				rst.maxStressBot(i) = MWDown.smaxBot(i)
				rst.minStressBot(i) = MWDown.sminBot(i)
			Next
			MWDown.smaxTop = Nothing
			MWDown.sminTop = Nothing
			MWDown.smaxBot = Nothing
			MWDown.sminBot = Nothing
			MWDown.mrgRodsStr = Nothing
			MWDown.miNumRodsStr = 0S
			Return result
		End Function

		Public Function StressAnalysis() As Boolean
			Dim flag As Boolean = True
			Dim result As Boolean
			Try
				If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Dim flag2 As Boolean = MWDown.CalcStressLoadOnly()
					result = flag2
				Else
					Dim flag2 As Boolean
					If(If((-If((Not RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) Or (If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.SETUP_UseImpred)) <> 0S Then
						flag2 = MWDown.JPred_StressAnalysis()
					Else
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						Dim flag3 As Boolean = True
						Dim num As Short = 1S
						Dim numRods As Short = RSWIN_DESC.rst.NumRods
						For num2 As Short = num To numRods
							If RSWIN_DESC.rst.maxStressTop(CInt(num2)) <> 0F And RSWIN_DESC.rst.minStressTop(CInt(num2)) <> 0F Then
								flag3 = False
							End If
						Next
						MWDown.miNumRodsStr = rst.NumRods
						MWDown.mrgRodsStr = New RSWIN_DESC.RodSection(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
						Dim num3 As Short = 1S
						Dim num4 As Short = MWDown.miNumRodsStr
						For num2 As Short = num3 To num4
							MWDown.mrgRodsStr(CInt(num2)).Initialize()
							MWDown.mrgRodsStr(CInt(num2)) = rst.Sections(CInt(num2))
						Next
						MWDown.smaxTop = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
						MWDown.sminTop = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
						MWDown.smaxBot = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
						MWDown.sminBot = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
						If Not flag3 Then
							flag2 = MWDown.CalcStressLoads()
						Else
							flag2 = MWDown.CalcRodStress()
							If MWDown.miNumRodsStr <> rst.NumRods Then
								' The following expression was wrapped in a checked-expression
								MWDown.sminBot(CInt((MWDown.miNumRodsStr - 1S))) = MWDown.sminBot(CInt(MWDown.miNumRodsStr))
							End If
							Dim num5 As Short = 1S
							Dim numRods2 As Short = rst.NumRods
							For num2 As Short = num5 To numRods2
								rst.maxStressTop(CInt(num2)) = MWDown.smaxTop(CInt(num2))
								rst.minStressTop(CInt(num2)) = MWDown.sminTop(CInt(num2))
								rst.maxStressBot(CInt(num2)) = MWDown.smaxBot(CInt(num2))
								rst.minStressBot(CInt(num2)) = MWDown.sminBot(CInt(num2))
							Next
						End If
						MWDown.smaxTop = Nothing
						MWDown.sminTop = Nothing
						MWDown.smaxBot = Nothing
						MWDown.sminBot = Nothing
						MWDown.mrgRodsStr = Nothing
						MWDown.miNumRodsStr = 0S
					End If
					result = flag2
				End If
			Catch ex As Exception
				result = True
			End Try
			Return result
		End Function

		Private Sub Wstring(ByRef Ni As Single(), ByRef Delta As Single(), ByRef Taf As Single(), ByRef Sigma As Single(), DampCoeff As Single, ByRef RodSect As RSWIN_DESC.RodSection)
			Dim num As Integer
			Dim num19 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim array As Object() = New Object(12) {}
				Dim array2 As Object() = New Object(12) {}
				Dim num2 As Single = CSng(Math.Sqrt(CDbl(RodSect.Elasticity) * 4632.4800000000005 / CDbl(RodSect.RodDensity)))
				Dim num3 As Short = 1S
				Do
					Dim num4 As Single = CSng((CDbl((CSng(num3) * MWDown.omega / num2)) / 1.4142135))
					Dim num5 As Single = CSng(Math.Sqrt(1.0 + CDbl((DampCoeff / CSng(num3))) / Math.Pow(CDbl(MWDown.omega), 2.0)))
					array(CInt(num3)) = CDbl(num4) * Math.Sqrt(CDbl((num5 + 1F)))
					array2(CInt(num3)) = CDbl(num4) * Math.Sqrt(CDbl((num5 - 1F)))
					num3 += 1S
				Loop While num3 <= 12S
				Dim area As Single = RodSect.Area
				Dim num6 As Single = RodSect.Elasticity * area
				num3 = 1S
				Do
					Dim num7 As Single = Conversions.ToSingle(Operators.MultiplyObject(num6, Operators.AddObject(Operators.MultiplyObject(array(CInt(num3)), array(CInt(num3))), Operators.MultiplyObject(array2(CInt(num3)), array2(CInt(num3))))))
					Dim num8 As Single = Conversions.ToSingle(Operators.DivideObject(Operators.AddObject(Operators.MultiplyObject(Sigma(CInt(num3)), array(CInt(num3))), Operators.MultiplyObject(Taf(CInt(num3)), array2(CInt(num3)))), num7))
					Dim num9 As Single = Conversions.ToSingle(Operators.DivideObject(Operators.SubtractObject(Operators.MultiplyObject(Sigma(CInt(num3)), array2(CInt(num3))), Operators.MultiplyObject(Taf(CInt(num3)), array(CInt(num3)))), num7))
					Dim num10 As Single = CSng(Math.Cos(Conversions.ToDouble(Operators.MultiplyObject(array(CInt(num3)), RodSect.length))))
					Dim num11 As Single = CSng(Math.Sin(Conversions.ToDouble(Operators.MultiplyObject(array(CInt(num3)), RodSect.length))))
					Dim num12 As Single = CSng(Math.Exp(Conversions.ToDouble(Operators.MultiplyObject(array2(CInt(num3)), RodSect.length))))
					Dim num13 As Single = (num12 - 1F / num12) / 2F
					Dim num14 As Single = (num12 + 1F / num12) / 2F
					Dim num15 As Single = (num8 * num14 + Delta(CInt(num3)) * num13) * num11 + (num9 * num13 + Ni(CInt(num3)) * num14) * num10
					Dim num16 As Single = (num8 * num13 + Delta(CInt(num3)) * num14) * num10 - (num9 * num14 + Ni(CInt(num3)) * num13) * num11
					Dim num17 As Single = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject(Taf(CInt(num3)) / num6 * num13, Operators.MultiplyObject(Operators.SubtractObject(Operators.MultiplyObject(Delta(CInt(num3)), array2(CInt(num3))), Operators.MultiplyObject(Ni(CInt(num3)), array(CInt(num3)))), num14)), num11))
					num17 = Conversions.ToSingle(Operators.AddObject(num17, Operators.MultiplyObject(Operators.AddObject(Sigma(CInt(num3)) / num6 * num14, Operators.MultiplyObject(Operators.AddObject(Operators.MultiplyObject(Ni(CInt(num3)), array2(CInt(num3))), Operators.MultiplyObject(Delta(CInt(num3)), array(CInt(num3)))), num13)), num10)))
					Dim num18 As Single = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject(Taf(CInt(num3)) / num6 * num14, Operators.MultiplyObject(Operators.SubtractObject(Operators.MultiplyObject(Delta(CInt(num3)), array2(CInt(num3))), Operators.MultiplyObject(Ni(CInt(num3)), array(CInt(num3)))), num13)), num10))
					num18 = Conversions.ToSingle(Operators.SubtractObject(num18, Operators.MultiplyObject(Operators.AddObject(Sigma(CInt(num3)) / num6 * num13, Operators.MultiplyObject(Operators.AddObject(Operators.MultiplyObject(Ni(CInt(num3)), array2(CInt(num3))), Operators.MultiplyObject(Delta(CInt(num3)), array(CInt(num3)))), num14)), num11)))
					Ni(CInt(num3)) = num15
					Delta(CInt(num3)) = num16
					Sigma(CInt(num3)) = num17 * num6
					Taf(CInt(num3)) = num18 * num6
					num3 += 1S
				Loop While num3 <= 12S
				IL_42C:
				GoTo IL_473
				IL_42E:
				num19 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_444:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num19 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_42E
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_473:
			If num19 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Function CalcRodStress_New() As Boolean
			Dim flag As Boolean = True
			Dim result As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim array As Single()
				Dim array2 As Single()
				Dim array3 As Single()
				array = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
				array2 = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
				array3 = New Single(CInt((MWDown.miNumRodsStr + 1S)) - 1) {}
				array(0) = 0F
				array2(0) = rst.Pprload - rst.StuffingBoxFriction
				array3(0) = rst.Mprload + rst.StuffingBoxFriction
				Dim num As Single = rst.PumpLoad(1)
				Dim num2 As Single = rst.PumpLoad(1)
				Dim num3 As Short = 1S
				Dim num4 As Short = rst.Ntsteps - 1S
				For num5 As Short = num3 To num4
					If rst.PumpLoad(CInt(num5)) > num Then
						num = rst.PumpLoad(CInt(num5))
					End If
					If rst.PumpLoad(CInt(num5)) < num2 Then
						num2 = rst.PumpLoad(CInt(num5))
					End If
				Next
				Dim num6 As Short = 1S
				Dim num7 As Short = MWDown.miNumRodsStr
				For num8 As Short = num6 To num7
					' The following expression was wrapped in a checked-expression
					array(CInt(num8)) = array(CInt((num8 - 1S))) + MWDown.mrgRodsStr(CInt(num8)).length
					array2(CInt(num8)) = num
					array3(CInt(num8)) = num2
				Next
				Dim num9 As Short = 1S
				Dim num10 As Short = MWDown.miNumRodsStr
				For num8 As Short = num9 To num10
					' The following expression was wrapped in a checked-expression
					Dim num11 As Single = MWDown.EffRodArea(MWDown.mrgRodsStr(CInt(num8)), CShort(RODUTIL.IsSinkerBar(CInt(num8))))
					Dim num12 As Single
					Dim num13 As Single
					If rst.gbIncludeBuoyancy Then
						num12 = 0F
						num13 = 0F
					Else
						Dim num14 As Single
						If num8 = 1S Then
							num14 = num11
						Else
							' The following expression was wrapped in a checked-expression
							num14 = MWDown.EffRodArea(MWDown.mrgRodsStr(CInt((num8 - 1S))), CShort(RODUTIL.IsSinkerBar(CInt((num8 - 1S)))))
							If num14 > num11 Then
								num14 = num11
							End If
						End If
						num12 = CSng(((CDbl(rst.TubingPressure) + 0.433 * CDbl(rst.FluidSPGR) * CDbl(array(CInt((num8 - 1S))))) * CDbl(num14)))
						num13 = CSng(((CDbl(rst.TubingPressure) + 0.433 * CDbl(rst.FluidSPGR) * CDbl(array(CInt(num8)))) * CDbl(num11)))
					End If
					MWDown.smaxTop(CInt(num8)) = (array2(CInt((num8 - 1S))) + num12) / num11
					MWDown.sminTop(CInt(num8)) = (array3(CInt((num8 - 1S))) + num12) / num11
					MWDown.smaxBot(CInt(num8)) = (array2(CInt(num8)) + num13) / num11
					MWDown.sminBot(CInt(num8)) = (array3(CInt(num8)) + num13) / num11
					If num8 > 1S AndAlso (MWDown.mrgRodsStr(CInt((num8 - 1S))).Diameter = MWDown.mrgRodsStr(CInt(num8)).Diameter And MWDown.sminBot(CInt(num8)) >= MWDown.sminTop(CInt(num8))) Then
						MWDown.sminTop(CInt(num8)) = CSng((CDbl(MWDown.sminBot(CInt(num8))) + CDbl(MWDown.mrgRodsStr(CInt(num8)).length) * (CDbl(MWDown.mrgRodsStr(CInt(num8)).RodWeight) - 1.07 * (62.4 * CDbl(rst.FluidSPGR) * CDbl(MWDown.mrgRodsStr(CInt(num8)).Area) / 144.0)) / CDbl(num11)))
						MWDown.sminBot(CInt((num8 - 1S))) = MWDown.sminTop(CInt(num8))
					End If
				Next
				If rst.gbIncludeBuoyancy Then
					MWDown.sminBot(CInt(MWDown.miNumRodsStr)) = CSng((-CSng((CDbl(rst.FluidSPGR) * 0.433 * CDbl(array(CInt(MWDown.miNumRodsStr))) * 1.075 + CDbl(rst.TubingPressure)))))
				Else
					MWDown.sminBot(CInt(MWDown.miNumRodsStr)) = 0F
				End If
				MWDown.sminBot(CInt(MWDown.miNumRodsStr)) = MWDown.sminBot(CInt(MWDown.miNumRodsStr)) - rst.PumpFriction / MWDown.mrgRodsStr(CInt(MWDown.miNumRodsStr)).Area
				Dim num15 As Short = 1S
				Dim num16 As Short = MWDown.miNumRodsStr
				For num8 As Short = num15 To num16
					RODUTIL.LookupTensileStrength(MWDown.mrgRodsStr(CInt(num8)))
					Dim num17 As Single = MWDown.smaxTop(CInt(num8)) - MWDown.sminTop(CInt(num8))
					Select Case RODUTIL.LookupStressMethod(MWDown.mrgRodsStr(CInt(num8)))
						Case 0
							Dim num18 As Single = CSng(((CDbl((MWDown.mrgRodsStr(CInt(num8)).TensileStrength / 4F)) + 0.5625 * CDbl(MWDown.sminTop(CInt(num8)))) * CDbl(rst.ServiceFactor)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 1
							Dim num18 As Single = CSng(((CDbl(MWDown.mrgRodsStr(CInt(num8)).TensileStrength) / 2.8 + 0.375 * CDbl(MWDown.sminTop(CInt(num8)))) * CDbl(rst.ServiceFactor)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 2
							Dim num18 As Single = CSng(((CDbl((MWDown.mrgRodsStr(CInt(num8)).TensileStrength / 3F)) + 0.5625 * CDbl(MWDown.sminTop(CInt(num8)))) * CDbl(rst.ServiceFactor)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 3
							Dim num18 As Single = CSng(((55000.0 + 0.2143 * CDbl(MWDown.sminTop(CInt(num8)))) * CDbl(rst.ServiceFactor)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 4
							rst.StressL(CInt(num8)) = CSng(((CDbl(MWDown.smaxTop(CInt(num8))) - 0.5625 * CDbl(MWDown.sminTop(CInt(num8)))) / CDbl((MWDown.mrgRodsStr(CInt(num8)).TensileStrength / 4F * rst.ServiceFactor))))
						Case 5
							Dim num20 As Single = MWDown.sminTop(CInt(num8)) / 5000F
							Dim num18 As Single = CSng((13756.4 + 9816.09 * CDbl(num20) + 8892.61 * Math.Pow(CDbl(num20), 2.0) - 11380.1 * Math.Pow(CDbl(num20), 3.0) + 4828.34 * Math.Pow(CDbl(num20), 4.0) - 993.188 * Math.Pow(CDbl(num20), 5.0) + 100.304 * Math.Pow(CDbl(num20), 6.0) - 3.98389 * Math.Pow(CDbl(num20), 7.0)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 6
							Dim num21 As Single = CSng((CDbl(MWDown.sminTop(CInt(num8))) / 5428.6))
							If CDbl(num21) < 0.3 Then
								num21 = 0.3F
							End If
							Dim num18 As Single = CSng((CDbl((19268F + 6152F * num21)) - 964.2 * Math.Pow(CDbl(num21), 2.0) + 67.5 * Math.Pow(CDbl(num21), 3.0)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 7
							Dim diameter As Single = MWDown.mrgRodsStr(CInt(num8)).Diameter
							Dim num18 As Single
							If diameter < 0.8125F Then
								num18 = CSng((0.7 * CDbl(MWDown.sminTop(CInt(num8))) + 17778.0))
							ElseIf diameter >= 0.8125F AndAlso diameter <= 1.125F Then
								num18 = CSng((0.7 * CDbl(MWDown.sminTop(CInt(num8))) + 20000.0))
							ElseIf diameter > 1.125F Then
								num18 = CSng((0.625 * CDbl(MWDown.sminTop(CInt(num8))) + 19400.0))
							End If
							If num18 > 30000F Then
								num18 = 30000F
							End If
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 8
							rst.StressL(CInt(num8)) = MWDown.smaxTop(CInt(num8)) / 58000F
						Case 9
							Dim num18 As Single
							If MWDown.sminTop(CInt(num8)) >= 1250F And MWDown.sminTop(CInt(num8)) <= 5000F Then
								num18 = MWDown.sminTop(CInt(num8)) + 22500F
							ElseIf MWDown.sminTop(CInt(num8)) > 5000F Then
								num18 = MWDown.sminTop(CInt(num8)) / 4F + 26250F
							ElseIf MWDown.sminTop(CInt(num8)) < 1250F Then
								num18 = MWDown.sminTop(CInt(num8)) + 22500F
								If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										Util.Errmsg(RSWIN_DESC.sMinFiberodStressWarning_Meter)
									Else
										Util.Errmsg(RSWIN_DESC.sMinFiberodStressWarning_English)
									End If
								End If
							End If
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 10
							Dim num18 As Single = 50000F * RSWIN_DESC.rst.ServiceFactor
							RSWIN_DESC.rst.StressL(CInt(num8)) = MWDown.smaxTop(CInt(num8)) / num18
						Case 11
							Dim num18 As Single = 12500F + MWDown.sminTop(CInt(num8)) / 2F
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 12
							Dim num18 As Single = CSng(((CDbl(MWDown.mrgRodsStr(CInt(num8)).TensileStrength) / 2.3 + 0.375 * CDbl(MWDown.sminTop(CInt(num8)))) * CDbl(rst.ServiceFactor)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 13
							Dim num18 As Single
							If MWDown.sminTop(CInt(num8)) >= 0F And MWDown.sminTop(CInt(num8)) <= 5000F Then
								num18 = CSng((2.2 * CDbl(MWDown.sminTop(CInt(num8))) + 14000.0))
							ElseIf MWDown.sminTop(CInt(num8)) > 5000F And MWDown.sminTop(CInt(num8)) <= 7000F Then
								num18 = CSng((1.25 * CDbl(MWDown.sminTop(CInt(num8))) + 18750.0))
							ElseIf MWDown.sminTop(CInt(num8)) > 7000F And MWDown.sminTop(CInt(num8)) <= 12000F Then
								num18 = CSng((0.5 * CDbl(MWDown.sminTop(CInt(num8))) + 24000.0))
							ElseIf MWDown.sminTop(CInt(num8)) > 12000F And MWDown.sminTop(CInt(num8)) <= 35000F Then
								num18 = CSng((0.21739130434782608 * CDbl(MWDown.sminTop(CInt(num8))) + 27391.3))
							End If
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 14
							Dim num18 As Single = CSng((CDbl(MWDown.sminTop(CInt(num8))) * 0.3125 + 27500.0))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 15
							Dim num18 As Single
							If MWDown.sminTop(CInt(num8)) >= 1000F And MWDown.sminTop(CInt(num8)) <= 5000F Then
								num18 = CSng((2.1875 * CDbl(MWDown.sminTop(CInt(num8))) + 14062.5))
							ElseIf MWDown.sminTop(CInt(num8)) > 5000F And MWDown.sminTop(CInt(num8)) < 10000F Then
								num18 = CSng((0.9332 * CDbl(MWDown.sminTop(CInt(num8))) + 20334.0))
							ElseIf MWDown.sminTop(CInt(num8)) >= 10000F And MWDown.sminTop(CInt(num8)) < 35000F Then
								num18 = CSng((0.21336 * CDbl(MWDown.sminTop(CInt(num8))) + 27532.4))
							ElseIf MWDown.sminTop(CInt(num8)) >= 35000F Then
								If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										Util.Errmsg(RSWIN_DESC.sMaxFibercoStressWarning_Meter)
									Else
										Util.Errmsg(RSWIN_DESC.sMaxFibercoStressWarning_English)
									End If
								End If
							ElseIf MWDown.sminTop(CInt(num8)) < 1000F Then
								num18 = CSng((2.1875 * CDbl(MWDown.sminTop(CInt(num8))) + 14062.5))
								If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										Util.Errmsg(RSWIN_DESC.sMinFibercoStressWarning_Meter)
									Else
										Util.Errmsg(RSWIN_DESC.sMinFibercoStressWarning_English)
									End If
								End If
							End If
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
						Case 16
							Dim num18 As Single = CSng(((CDbl(rst.Sections(CInt(num8)).TensileStrength) / 2.6 + 0.375 * CDbl(MWDown.sminTop(CInt(num8)))) * CDbl(rst.ServiceFactor)))
							Dim num19 As Single = num18 - MWDown.sminTop(CInt(num8))
							rst.StressL(CInt(num8)) = num17 / num19
					End Select
					If rst.StressL(CInt(num8)) < 0F Then
						rst.StressL(CInt(num8)) = 3F
					End If
				Next
				result = flag
			Catch ex As Exception
				result = True
			End Try
			Return result
		End Function

		Public Function CalcStressLoadOnly() As Boolean
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(rst.NumRods)
				For i As Integer = num To numRods
					RODUTIL.LookupTensileStrength(rst.Sections(i))
					Dim num2 As Single = rst.maxStressTop(i) - rst.minStressTop(i)
					Select Case RODUTIL.LookupStressMethod(rst.Sections(i))
						Case 0
							Dim num3 As Single = CSng(((CDbl(rst.Sections(i).TensileStrength) / 4.0 + 0.5625 * CDbl(rst.minStressTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 1
							Dim num3 As Single = CSng(((CDbl(rst.Sections(i).TensileStrength) / 2.8 + 0.375 * CDbl(rst.minStressTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 2
							Dim num3 As Single = CSng(((CDbl((rst.Sections(i).TensileStrength / 3F)) + 0.5625 * CDbl(rst.minStressTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 3
							Dim num3 As Single = CSng(((55000.0 + 0.2143 * CDbl(rst.minStressTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 4
							rst.StressL(i) = CSng(((CDbl(rst.maxStressTop(i)) - 0.5625 * CDbl(rst.minStressTop(i))) / (CDbl(rst.Sections(i).TensileStrength) / 4.0 * CDbl(rst.ServiceFactor))))
						Case 5
							Dim num5 As Single = rst.minStressTop(i) / 5000F
							Dim num3 As Single = CSng((13756.4 + 9816.09 * CDbl(num5) + 8892.61 * Math.Pow(CDbl(num5), 2.0) - 11380.1 * Math.Pow(CDbl(num5), 3.0) + 4828.34 * Math.Pow(CDbl(num5), 4.0) - 993.188 * Math.Pow(CDbl(num5), 5.0) + 100.304 * Math.Pow(CDbl(num5), 6.0) - 3.98389 * Math.Pow(CDbl(num5), 7.0)))
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 6
							Dim num6 As Single = CSng((CDbl(rst.minStressTop(i)) / 5428.6))
							If CDbl(num6) < 0.3 Then
								num6 = 0.3F
							End If
							Dim num3 As Single = CSng((19268.0 + 6152.0 * CDbl(num6) - 964.2 * Math.Pow(CDbl(num6), 2.0) + 67.5 * Math.Pow(CDbl(num6), 3.0)))
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 7
							Dim diameter As Single = rst.Sections(i).Diameter
							Dim num3 As Single
							If diameter < 0.8125F Then
								num3 = CSng((0.7 * CDbl(rst.minStressTop(i)) + 17778.0))
							ElseIf diameter >= 0.8125F AndAlso diameter <= 1.125F Then
								num3 = CSng((0.7 * CDbl(rst.minStressTop(i)) + 20000.0))
							ElseIf diameter > 1.125F Then
								num3 = CSng((0.625 * CDbl(rst.minStressTop(i)) + 19400.0))
							End If
							If num3 > 30000F Then
								num3 = 30000F
							End If
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 8
							rst.StressL(i) = rst.maxStressTop(i) / 58000F
						Case 9
							Dim num3 As Single
							If rst.minStressTop(i) >= 1250F And rst.minStressTop(i) <= 5000F Then
								num3 = rst.minStressTop(i) + 22500F
							ElseIf rst.minStressTop(i) > 5000F Then
								num3 = rst.minStressTop(i) / 4F + 26250F
							ElseIf rst.minStressTop(i) < 1250F Then
								num3 = rst.minStressTop(i) + 22500F
								If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										Util.Errmsg(RSWIN_DESC.sMinFiberodStressWarning_Meter)
									Else
										Util.Errmsg(RSWIN_DESC.sMinFiberodStressWarning_English)
									End If
								End If
							End If
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 10
							Dim num3 As Single = 50000F * RSWIN_DESC.rst.ServiceFactor
							RSWIN_DESC.rst.StressL(i) = rst.maxStressTop(i) / num3
						Case 11
							Dim num3 As Single = 12500F + rst.minStressTop(i) / 2F
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 12
							Dim num3 As Single = CSng(((CDbl(rst.Sections(i).TensileStrength) / 2.3 + 0.375 * CDbl(rst.minStressTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 13
							Dim num3 As Single
							If rst.minStressTop(i) >= 0F And rst.minStressTop(i) <= 5000F Then
								num3 = CSng((2.2 * CDbl(rst.minStressTop(i)) + 14000.0))
							ElseIf rst.minStressTop(i) > 5000F And rst.minStressTop(i) <= 7000F Then
								num3 = CSng((1.25 * CDbl(rst.minStressTop(i)) + 18750.0))
							ElseIf rst.minStressTop(i) > 7000F And rst.minStressTop(i) <= 12000F Then
								num3 = CSng((0.5 * CDbl(rst.minStressTop(i)) + 24000.0))
							ElseIf rst.minStressTop(i) > 12000F And rst.minStressTop(i) <= 35000F Then
								num3 = CSng((0.21739130434782608 * CDbl(rst.minStressTop(i)) + 27391.3))
							End If
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 14
							Dim num3 As Single = CSng((CDbl(rst.minStressTop(i)) * 0.3125 + 27500.0))
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 15
							Dim num3 As Single
							If rst.minStressTop(i) >= 1000F And rst.minStressTop(i) <= 5000F Then
								num3 = CSng((2.1875 * CDbl(rst.minStressTop(i)) + 14062.5))
							ElseIf rst.minStressTop(i) > 5000F And rst.minStressTop(i) < 10000F Then
								num3 = CSng((0.9332 * CDbl(rst.minStressTop(i)) + 20334.0))
							ElseIf rst.minStressTop(i) >= 10000F And rst.minStressTop(i) < 35000F Then
								num3 = CSng((0.21336 * CDbl(rst.minStressTop(i)) + 27532.4))
							ElseIf rst.minStressTop(i) >= 35000F Then
								If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										Util.Errmsg(RSWIN_DESC.sMaxFibercoStressWarning_Meter)
									Else
										Util.Errmsg(RSWIN_DESC.sMaxFibercoStressWarning_English)
									End If
								End If
							ElseIf rst.minStressTop(i) < 1000F Then
								num3 = CSng((2.1875 * CDbl(rst.minStressTop(i)) + 14062.5))
								If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										Util.Errmsg(RSWIN_DESC.sMinFibercoStressWarning_Meter)
									Else
										Util.Errmsg(RSWIN_DESC.sMinFibercoStressWarning_English)
									End If
								End If
							End If
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
						Case 16
							Dim num3 As Single = CSng(((CDbl(rst.Sections(i).TensileStrength) / 2.6 + 0.375 * CDbl(rst.minStressTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num4 As Single = num3 - rst.minStressTop(i)
							rst.StressL(i) = num2 / num4
					End Select
					If rst.StressL(i) < 0F Then
						rst.StressL(i) = 3F
					End If
				Next
				result = flag
			Catch ex As Exception
				result = True
			End Try
			Return result
		End Function

		Private Const NEWRODLOGIC As Boolean = False

		Private Const NFourCoeff As Short = 12S

		Private RPos As Single(,)

		Private RLoad As Single(,)

		Private omega As Single

		Private miNumRodsStr As Short

		Private mrgRodsStr As RSWIN_DESC.RodSection()

		Private smaxTop As Single()

		Private sminTop As Single()

		Private smaxBot As Single()

		Private sminBot As Single()
	End Module
End Namespace
