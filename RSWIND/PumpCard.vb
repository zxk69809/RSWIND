Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module PumpCard
		Private Function BPDsurf(GrossPumpStroke As Single, SPM As Single, PlungerSize As Single, Runtime As Single) As Single
			Return CSng((0.1166 * CDbl(GrossPumpStroke) * CDbl(SPM) * Math.Pow(CDbl(PlungerSize), 2.0) * (CDbl(Runtime) / 24.0)))
		End Function

		Private Sub DownWave(ByRef SurfPos As Single(), ByRef SurfLoad As Single(), ByRef RPos As Single(,), ByRef RLoad As Single(,), Ntsteps As Integer)
			' The following expression was wrapped in a checked-statement
			Dim array As Single(,) = New Single(Ntsteps + 1 - 1, 13) {}
			Dim array2 As Single(,) = New Single(Ntsteps + 1 - 1, 13) {}
			Dim array3 As Single() = New Single(Ntsteps + 1 - 1) {}
			Dim array4 As Single() = New Single(Ntsteps + 1 - 1) {}
			Dim array5 As Single() = New Single(13) {}
			Dim array6 As Single() = New Single(13) {}
			Dim array7 As Single() = New Single(13) {}
			Dim array8 As Single() = New Single(13) {}
			RSWIN_DESC.RLoad_Save = New Single(12, CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num As Single = CSng((CDbl(rst.FluidSPGR) * 62.4))
				Dim num2 As Integer = 0
				Dim num3 As Integer = CInt((rst.Ntsteps - 1S))
				For i As Integer = num2 To num3
					' The following expression was wrapped in a unchecked-expression
					array3(i) = CSng(i) * PumpCard.mfPeriod / CSng(rst.Ntsteps)
				Next
				array3(Ntsteps) = array3(0) + PumpCard.mfPeriod
				Dim num4 As Integer = 0
				Dim ntsteps As Integer = CInt(rst.Ntsteps)
				For i As Integer = num4 To ntsteps

						Dim num5 As Single = PumpCard.mfOmega * array3(i)
						array(i, 1) = CSng(Math.Cos(CDbl(num5)))
						array(i, 2) = 2F * array(i, 1) * array(i, 1) - 1F
						array2(i, 1) = CSng(Math.Sin(CDbl(num5)))
						array2(i, 2) = 2F * array(i, 1) * array2(i, 1)
						Dim num6 As Integer = 3
						Do
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							array(i, num6) = 2F * array(i, 1) * array(i, num6 - 1) - array(i, num6 - 2)
							array2(i, num6) = 2F * array(i, 1) * array2(i, num6 - 1) - array2(i, num6 - 2)
							num6 += 1
						Loop While num6 <= 12

				Next
				Dim num7 As Single
				Dim num8 As Single
				Dim num9 As Integer

					' The following expression was wrapped in a checked-expression
					array4(0) = (array3(Ntsteps) - array3(Ntsteps - 1) + (array3(1) - array3(0))) / 2F
					num7 = SurfLoad(0) * array4(0)
					num8 = -SurfPos(0) / 12F * array4(0)
					num9 = 1

				Dim num10 As Integer = CInt((rst.Ntsteps - 1S))
				Dim j As Integer
				j = num9
				While j <= num10

						' The following expression was wrapped in a checked-expression
						' The following expression was wrapped in a checked-expression
						array4(j) = (array3(j + 1) - array3(j - 1)) / 2F
						num7 += array4(j) * SurfLoad(j)
						num8 += array4(j) * -SurfPos(j) / 12F

					j += 1
				End While
				num7 /= PumpCard.mfPeriod
				num8 /= PumpCard.mfPeriod
				j = 1
				Do
					array7(j) = 0F
					array8(j) = 0F
					array6(j) = 0F
					array5(j) = 0F
					Dim num11 As Integer = 0
					Dim num12 As Integer = CInt((rst.Ntsteps - 1S))
					For i As Integer = num11 To num12

							Dim num13 As Single = array(i, j) * array4(i)
							Dim num14 As Single = array2(i, j) * array4(i)
							array7(j) += num13 * SurfLoad(i)
							array8(j) += num14 * SurfLoad(i)
							array6(j) += num13 * -SurfPos(i) / 12F
							array5(j) += num14 * -SurfPos(i) / 12F

					Next

						array7(j) = array7(j) * 2F / PumpCard.mfPeriod
						array8(j) = array8(j) * 2F / PumpCard.mfPeriod
						array6(j) = array6(j) * 2F / PumpCard.mfPeriod
						array5(j) = array5(j) * 2F / PumpCard.mfPeriod

					j += 1
				Loop While j <= 12
				Dim dampCoeff As Single = rst.Friction / 10F
				dampCoeff = rst.UpstrokeFriction + rst.DownstrokeFriction / 2F
				Dim num15 As Single = 0F
				Dim num16 As Integer = 1
				Dim numRods As Integer = CInt(rst.NumRods)
				For i As Integer = num16 To numRods
					Dim num21 As Integer

						num15 += rst.Sections(i).length
						PumpCard.Wstring(array6, array5, array8, array7, dampCoeff, rst.Sections(i), num15)
						Dim num17 As Single = CSng((3.141592653589793 * CDbl(rst.Sections(i).Diameter) * CDbl(rst.Sections(i).Diameter) / 4.0))
						Dim num18 As Single
						If i = CInt(rst.NumRods) Then
							num18 = 0F
						Else
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							Dim num19 As Single = CSng((3.141592653589793 * CDbl(rst.Sections(i + 1).Diameter) * CDbl(rst.Sections(i + 1).Diameter) / 4.0))
							If num17 < num19 Then
								num18 = 0F
							Else
								num18 = CSng((CDbl((num17 - num19)) * (CDbl((num15 * num)) / 144.0 + CDbl(rst.TubingPressure))))
							End If
						End If
						Dim num20 As Single = rst.Sections(i).length * rst.Sections(i).length / rst.Sections(i).Elasticity * rst.Sections(i).RodDensity / 288F
						num7 -= rst.Sections(i).length * rst.Sections(i).RodWeight - num18
						num8 = num8 + num20 + num7 * rst.Sections(i).length / (rst.Sections(i).Elasticity * num17)
						num21 = 0

					Dim num22 As Integer = CInt((rst.Ntsteps - 1S))
					j = num21
					While j <= num22
						Dim num23 As Single = num7
						Dim num24 As Single = num8
						Dim num6 As Integer = 1
						Do
							Dim num13 As Single = array(j, num6)
							Dim num14 As Single = array2(j, num6)

								num23 = num23 + num13 * array7(num6) + num14 * array8(num6)
								num24 = num24 + num13 * array6(num6) + num14 * array5(num6)

							num6 += 1
						Loop While num6 <= 12
						RLoad(i, j) = num23
						RPos(i, j) = num24
						RSWIN_DESC.RLoad_Save(i, j) = num23
						j += 1
					End While
				Next
				If Not rst.gbIncludeBuoyancy Then
					Dim num25 As Single = PumpCard.CalcBotForce()
					Dim num26 As Integer = 0
					Dim num27 As Integer = CInt((rst.Ntsteps - 1S))
					For i As Integer = num26 To num27
						' The following expression was wrapped in a unchecked-expression
						RLoad(CInt(rst.NumRods), i) = RLoad(CInt(rst.NumRods), i) + num25
					Next
				End If
				array5 = Nothing
				array6 = Nothing
				array7 = Nothing
				array8 = Nothing
			Catch ex As Exception
			End Try
		End Sub

		Private Function EffRodArea(ByRef sect As RSWIN_DESC.RodSection, bIsSinkerBar As Integer) As Single
			Dim result As Single
			If Not RODUTIL.IsSteel(CInt(sect.Grade)) <> 0 Then
				result = sect.Area
			ElseIf RODUTIL.IsNoNeck(sect.Grade) Then
				result = sect.Area
			Else
				Dim num As Single = 0F
				Dim diameter As Single = sect.Diameter
				If diameter > 1.624F Then
					num = 1F
				ElseIf diameter > 1.49F Then
					num = 1F
				ElseIf diameter > 1.374F Then
					num = 1F
				ElseIf diameter > 1.24F AndAlso bIsSinkerBar <> 0 Then
					num = 0.875F
				End If
				If num = 0F Then
					result = sect.Area
				Else
					result = CSng((3.141592653589793 * Math.Pow(CDbl(num), 2.0) / 4.0))
				End If
			End If
			Return result
		End Function

		Private Function NewStressAnalysis(ByRef RLoad As Single(,)) As Boolean
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			PumpCard.miNumRodsStr = CInt(rst.NumRods)
			PumpCard.mrgRodsStr = New RSWIN_DESC.RodSection(PumpCard.miNumRodsStr + 1 - 1) {}
			PumpCard.mrgRodsStr.Initialize()
			Dim num As Integer = 1
			Dim num2 As Integer = PumpCard.miNumRodsStr
			For i As Integer = num To num2
				PumpCard.mrgRodsStr(i) = rst.Sections(i)
			Next
			PumpCard.smaxTop = New Single(PumpCard.miNumRodsStr + 1 - 1) {}
			PumpCard.sminTop = New Single(PumpCard.miNumRodsStr + 1 - 1) {}
			PumpCard.smaxBot = New Single(PumpCard.miNumRodsStr + 1 - 1) {}
			PumpCard.sminBot = New Single(PumpCard.miNumRodsStr + 1 - 1) {}
			Dim result As Boolean
			If Not rst.gbIncludeBuoyancy Then
				result = PumpCard.CalcRodStress(RLoad)
			Else
				rst.gbIncludeBuoyancy = False
				result = PumpCard.CalcRodStress(RLoad)
				Dim pumpFriction As Single = rst.PumpFriction
				rst.gbIncludeBuoyancy = False
				result = PumpCard.CalcRodStress(RLoad)
				rst.PumpFriction = pumpFriction
			End If
			If PumpCard.miNumRodsStr <> CInt(rst.NumRods) Then
				PumpCard.sminBot(PumpCard.miNumRodsStr - 1) = PumpCard.sminBot(PumpCard.miNumRodsStr)
			End If
			Dim num3 As Integer = 1
			Dim numRods As Integer = CInt(rst.NumRods)
			For i As Integer = num3 To numRods
				rst.maxStressTop(i) = PumpCard.smaxTop(i)
				rst.minStressTop(i) = PumpCard.sminTop(i)
				rst.maxStressBot(i) = PumpCard.smaxBot(i)
				rst.minStressBot(i) = PumpCard.sminBot(i)
			Next
			PumpCard.smaxTop = Nothing
			PumpCard.sminTop = Nothing
			PumpCard.smaxBot = Nothing
			PumpCard.sminBot = Nothing
			PumpCard.mrgRodsStr = Nothing
			PumpCard.miNumRodsStr = 0
			Return result
		End Function

		Private Function OldStressAnalysis(ByRef RLoad As Single(,)) As Boolean
			Dim result As Boolean = True
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim array As Object() = New Object(CInt((rst.NumRods + 1S)) - 1) {}
			Dim num As Integer = 1
			Dim numRods As Integer = CInt(rst.NumRods)
			For i As Integer = num To numRods
				If Not RODUTIL.IsSteel(CInt(rst.Sections(i).Grade)) <> 0 Then
					array(i) = rst.Sections(i).Area
				ElseIf RODUTIL.IsNoNeck(rst.Sections(i).Grade) Then
					array(i) = rst.Sections(i).Area
				Else
					Dim num2 As Single = 0F
					Dim diameter As Single = rst.Sections(i).Diameter
					If diameter > 1.624F Then
						num2 = 1F
					ElseIf diameter > 1.49F Then
						num2 = 1F
					ElseIf diameter > 1.374F Then
						num2 = 1F
					ElseIf diameter > 1.24F AndAlso RODUTIL.IsSinkerBar(i) <> 0 Then
						num2 = 0.875F
					End If
					If num2 = 0F Then
						array(i) = rst.Sections(i).Area
					Else
						' The following expression was wrapped in a unchecked-expression
						array(i) = 3.141592653589793 * Math.Pow(CDbl(num2), 2.0) / 4.0
					End If
				End If
			Next
			Dim surfLoad As Single() = rst.SurfLoad
			Dim num3 As Single = 0F
			Dim num4 As Single = 0F
			Dim num5 As Single
			Dim num6 As Single
			Util.Maxmin(surfLoad, num5, num6, num3, num4)
			rst.minStressTop(1) = Conversions.ToSingle(Operators.DivideObject(num6, array(1)))
			rst.maxStressTop(1) = Conversions.ToSingle(Operators.DivideObject(num5, array(1)))
			Dim num7 As Single = 0F
			Dim num8 As Integer = 1
			Dim numRods2 As Integer = CInt(rst.NumRods)
			For i As Integer = num8 To numRods2
				Dim num9 As Single
				Dim num10 As Single
				Dim num11 As Integer

					num7 += rst.Sections(i).length
					num9 = RLoad(i, 0)
					num10 = RLoad(i, 0)
					num11 = 1

				Dim num12 As Integer = CInt((rst.Ntsteps - 1S))
				For j As Integer = num11 To num12
					If RLoad(i, j) > num9 Then
						num9 = RLoad(i, j)
					End If
					If RLoad(i, j) < num10 Then
						num10 = RLoad(i, j)
					End If
				Next
				If i < CInt(rst.NumRods) Then
					rst.minStressTop(i + 1) = Conversions.ToSingle(Operators.DivideObject(num10, array(i + 1)))
					rst.maxStressTop(i + 1) = Conversions.ToSingle(Operators.DivideObject(num9, array(i + 1)))
					rst.minStressBot(i) = Conversions.ToSingle(Operators.DivideObject(Operators.MultiplyObject(rst.minStressTop(i + 1), array(i + 1)), array(i)))
				Else
					rst.minStressBot(i) = num10 / rst.Sections(i).Area
				End If
			Next
			Dim num13 As Integer = 1
			Dim numRods3 As Integer = CInt(rst.NumRods)
			For i As Integer = num13 To numRods3
				RODUTIL.LookupTensileStrength(rst.Sections(i))

					Dim num14 As Single = rst.maxStressTop(i) - rst.minStressTop(i)
					Select Case RODUTIL.LookupStressMethod(rst.Sections(i))
						Case 0
							Dim num15 As Single = CSng(((CDbl(rst.Sections(i).TensileStrength) / 4.0 + 0.5625 * CDbl(rst.minStressTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num16 As Single = num15 - rst.minStressTop(i)
							rst.StressL(i) = num14 / num16
						Case 1
							Dim num15 As Single = CSng(((CDbl(rst.Sections(i).TensileStrength) / 2.8 + 0.375 * CDbl(rst.minStressTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num16 As Single = num15 - rst.minStressTop(i)
							rst.StressL(i) = num14 / num16
						Case 2
							Dim num15 As Single = CSng(((CDbl((rst.Sections(i).TensileStrength / 3F)) + 0.5625 * CDbl(rst.minStressTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num16 As Single = num15 - rst.minStressTop(i)
							rst.StressL(i) = num14 / num16
						Case 3
							rst.StressL(i) = CSng((CDbl(rst.maxStressTop(i)) / (50000.0 * CDbl(rst.ServiceFactor))))
						Case 4
							rst.StressL(i) = CSng(((CDbl(rst.maxStressTop(i)) - 0.5625 * CDbl(rst.minStressTop(i))) / (CDbl(rst.Sections(i).TensileStrength) / 4.0 * CDbl(rst.ServiceFactor))))
						Case 5
							Dim num17 As Single = rst.minStressTop(i) / 5000F
							Dim num15 As Single = CSng((13756.4 + 9816.09 * CDbl(num17) + 8892.61 * Math.Pow(CDbl(num17), 2.0) - 11380.1 * Math.Pow(CDbl(num17), 3.0) + 4828.34 * Math.Pow(CDbl(num17), 4.0) - 993.188 * Math.Pow(CDbl(num17), 5.0) + 100.304 * Math.Pow(CDbl(num17), 6.0) - 3.98389 * Math.Pow(CDbl(num17), 7.0)))
							Dim num16 As Single = num15 - rst.minStressTop(i)
							rst.StressL(i) = num14 / num16
						Case 6
							Dim num18 As Single = CSng((CDbl(rst.minStressTop(i)) / 5428.6))
							If CDbl(num18) < 0.3 Then
								num18 = 0.3F
							End If
							Dim num15 As Single = CSng((19268.0 + 6152.0 * CDbl(num18) - 964.2 * Math.Pow(CDbl(num18), 2.0) + 67.5 * Math.Pow(CDbl(num18), 3.0)))
							Dim num16 As Single = num15 - rst.minStressTop(i)
							rst.StressL(i) = num14 / num16
						Case 7
							Dim diameter2 As Single = rst.Sections(i).Diameter
							Dim num15 As Single
							If diameter2 < 0.8125F Then
								num15 = CSng((0.7 * CDbl(rst.minStressTop(i)) + 17778.0))
							ElseIf diameter2 >= 0.8125F AndAlso diameter2 <= 1.125F Then
								num15 = CSng((0.7 * CDbl(rst.minStressTop(i)) + 20000.0))
							ElseIf diameter2 > 1.125F Then
								num15 = CSng((0.625 * CDbl(rst.minStressTop(i)) + 19400.0))
							End If
							If num15 > 30000F Then
								num15 = 30000F
							End If
							Dim num16 As Single = num15 - rst.minStressTop(i)
							rst.StressL(i) = num14 / num16
						Case 8
							rst.StressL(i) = rst.maxStressTop(i) / 58000F
						Case 12
							Dim num15 As Single = CSng(((CDbl(rst.Sections(i).TensileStrength) / 2.3 + 0.375 * CDbl(rst.minStressTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num16 As Single = num15 - rst.minStressTop(i)
							rst.StressL(i) = num14 / num16
						Case 16
							Dim num15 As Single = CSng(((CDbl(rst.Sections(i).TensileStrength) / 2.6 + 0.375 * CDbl(rst.minStressTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num16 As Single = num15 - rst.minStressTop(i)
							rst.StressL(i) = num14 / num16
					End Select

			Next
			Return result
		End Function

		Private Function StressAnalysis(ByRef RLoad As Single(,)) As Boolean
			Dim flag As Boolean = PumpCard.NewStressAnalysis(RLoad)
			Dim result As Boolean
			Return result
		End Function

		Private Sub Wstring(ByRef Ni As Single(), ByRef Delta As Single(), ByRef Taf As Single(), ByRef Sigma As Single(), DampCoeff As Single, ByRef RodSect As RSWIN_DESC.RodSection, ByRef Depth As Single)
			Dim array As Object() = New Object(12) {}
			Dim array2 As Object() = New Object(12) {}
			Dim num As Single = CSng(Math.Sqrt(CDbl(RodSect.Elasticity) * 4632.4800000000005 / CDbl(RodSect.RodDensity)))
			Dim num2 As Integer = 1
			Do
				Dim num3 As Single = CSng((CDbl((CSng(num2) * PumpCard.mfOmega / num)) / 1.4142135))
				Dim num4 As Single = CSng(Math.Sqrt(1.0 + CDbl((DampCoeff / CSng(num2))) / Math.Pow(CDbl(PumpCard.mfOmega), 2.0)))
				array(num2) = CDbl(num3) * Math.Sqrt(CDbl((num4 + 1F)))
				array2(num2) = CDbl(num3) * Math.Sqrt(CDbl((num4 - 1F)))
				num2 += 1
			Loop While num2 <= 12
			Dim num5 As Single = CSng((3.141592653589793 * Math.Pow(CDbl(RodSect.Diameter), 2.0) / 4.0))
			Dim num6 As Single = RodSect.Elasticity * num5
			num2 = 1
			Do
				Dim num7 As Single = Conversions.ToSingle(Operators.MultiplyObject(num6, Operators.AddObject(Operators.MultiplyObject(array(num2), array(num2)), Operators.MultiplyObject(array2(num2), array2(num2)))))
				Dim num8 As Single = Conversions.ToSingle(Operators.DivideObject(Operators.AddObject(Operators.MultiplyObject(Sigma(num2), array(num2)), Operators.MultiplyObject(Taf(num2), array2(num2))), num7))
				Dim num9 As Single = Conversions.ToSingle(Operators.DivideObject(Operators.SubtractObject(Operators.MultiplyObject(Sigma(num2), array2(num2)), Operators.MultiplyObject(Taf(num2), array(num2))), num7))
				Dim num10 As Single = CSng(Math.Cos(Conversions.ToDouble(Operators.MultiplyObject(array(num2), RodSect.length))))
				Dim num11 As Single = CSng(Math.Sin(Conversions.ToDouble(Operators.MultiplyObject(array(num2), RodSect.length))))
				Dim num12 As Single = CSng(Math.Exp(Conversions.ToDouble(Operators.MultiplyObject(array2(num2), RodSect.length))))
				Dim num13 As Single = (num12 - 1F / num12) / 2F
				Dim num14 As Single = (num12 + 1F / num12) / 2F
				Dim num15 As Single = (num8 * num14 + Delta(num2) * num13) * num11 + (num9 * num13 + Ni(num2) * num14) * num10
				Dim num16 As Single = (num8 * num13 + Delta(num2) * num14) * num10 - (num9 * num14 + Ni(num2) * num13) * num11
				Dim num17 As Single = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject(Taf(num2) / num6 * num13, Operators.MultiplyObject(Operators.SubtractObject(Operators.MultiplyObject(Delta(num2), array2(num2)), Operators.MultiplyObject(Ni(num2), array(num2))), num14)), num11))
				num17 = Conversions.ToSingle(Operators.AddObject(num17, Operators.MultiplyObject(Operators.AddObject(Sigma(num2) / num6 * num14, Operators.MultiplyObject(Operators.AddObject(Operators.MultiplyObject(Ni(num2), array2(num2)), Operators.MultiplyObject(Delta(num2), array(num2))), num13)), num10)))
				Dim num18 As Single = Conversions.ToSingle(Operators.MultiplyObject(Operators.AddObject(Taf(num2) / num6 * num14, Operators.MultiplyObject(Operators.SubtractObject(Operators.MultiplyObject(Delta(num2), array2(num2)), Operators.MultiplyObject(Ni(num2), array(num2))), num13)), num10))
				num18 = Conversions.ToSingle(Operators.SubtractObject(num18, Operators.MultiplyObject(Operators.AddObject(Sigma(num2) / num6 * num13, Operators.MultiplyObject(Operators.AddObject(Operators.MultiplyObject(Ni(num2), array2(num2)), Operators.MultiplyObject(Delta(num2), array(num2))), num14)), num11)))
				Ni(num2) = num15
				Delta(num2) = num16
				Sigma(num2) = num17 * num6
				Taf(num2) = num18 * num6
				num2 += 1
			Loop While num2 <= 12
		End Sub

		Private Function CalcBotForce() As Single
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Not rst.gbIncludeBuoyancy Then
				Dim num As Single = 0F
				Dim num2 As Single = 0F
				Dim num3 As Integer = 1
				Dim numRods As Integer = CInt(rst.NumRods)
				For i As Integer = num3 To numRods
					num += rst.Sections(i).length
					If i < CInt(rst.NumRods) Then
						' The following expression was wrapped in a checked-expression
						num2 = CSng((CDbl(num2) + 0.433 * CDbl(rst.FluidSPGR) * CDbl(num) * CDbl((rst.Sections(i).Area - rst.Sections(i + 1).Area))))
					Else
						num2 = CSng((CDbl(num2) + 0.433 * CDbl(rst.FluidSPGR) * CDbl(num) * CDbl(rst.Sections(i).Area)))
					End If
				Next
				Return num2
			End If
			Return 0F
		End Function

		Private Function CalcRodStress(ByRef RLoad As Single(,)) As Boolean
			Dim result As Boolean = True
			Dim array As Single()
			Dim array2 As Single()
			Dim array3 As Single()
			Dim rst As cRODSTAR
			array = New Single(PumpCard.miNumRodsStr + 1 - 1) {}
			array2 = New Single(PumpCard.miNumRodsStr + 1 - 1) {}
			array3 = New Single(PumpCard.miNumRodsStr + 1 - 1) {}
			rst = RSWIN_DESC.rst
			Dim stuffingBoxFriction As Single = rst.StuffingBoxFriction
			array(0) = 0F
			array2(0) = rst.Pprload - rst.StuffingBoxFriction
			array3(0) = rst.Mprload + rst.StuffingBoxFriction
			Dim num As Integer = 1
			Dim num2 As Integer = PumpCard.miNumRodsStr
			For i As Integer = num To num2
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				array(i) = array(i - 1) + PumpCard.mrgRodsStr(i).length
				Dim num3 As Single = RLoad(i, 1)
				Dim num4 As Single = RLoad(i, 1)
				Dim num5 As Integer = 2
				Dim num6 As Integer = CInt((rst.Ntsteps - 2S))
				For j As Integer = num5 To num6
					If RLoad(i, j) > num3 Then
						num3 = RLoad(i, j)
					End If
					If RLoad(i, j) < num4 Then
						num4 = RLoad(i, j)
					End If
				Next
				array2(i) = num3
				array3(i) = num4
			Next
			Dim num7 As Integer = 1
			Dim num8 As Integer = PumpCard.miNumRodsStr
			For i As Integer = num7 To num8
				Dim num9 As Single = PumpCard.EffRodArea(PumpCard.mrgRodsStr(i), RODUTIL.IsSinkerBar(i))

					Dim num10 As Single
					Dim num11 As Single
					If rst.gbIncludeBuoyancy Then
						num10 = 0F
						num11 = 0F
					Else
						Dim num12 As Single
						If i = 1 Then
							num12 = num9
						Else
							' The following expression was wrapped in a checked-expression
							num12 = PumpCard.EffRodArea(PumpCard.mrgRodsStr(i - 1), RODUTIL.IsSinkerBar(i - 1))
							If num12 > num9 Then
								num12 = num9
							End If
						End If
						num10 = CSng(((CDbl(rst.TubingPressure) + 0.433 * CDbl(rst.FluidSPGR) * CDbl(array(i - 1))) * CDbl(num12)))
						num11 = CSng(((CDbl(rst.TubingPressure) + 0.433 * CDbl(rst.FluidSPGR) * CDbl(array(i))) * CDbl(num9)))
					End If
					PumpCard.smaxTop(i) = (array2(i - 1) + num10) / num9
					PumpCard.sminTop(i) = (array3(i - 1) + num10) / num9
					PumpCard.smaxBot(i) = (array2(i) + num11) / num9
					PumpCard.sminBot(i) = (array3(i) + num11) / num9

			Next
			PumpCard.sminBot(PumpCard.miNumRodsStr) = array3(PumpCard.miNumRodsStr) / rst.Sections(PumpCard.miNumRodsStr).Area
			rst.PumpFriction = -array3(PumpCard.miNumRodsStr)
			Dim num13 As Integer = 1
			Dim num14 As Integer = PumpCard.miNumRodsStr
			For i As Integer = num13 To num14
				RODUTIL.LookupTensileStrength(PumpCard.mrgRodsStr(i))

					Dim num15 As Single = PumpCard.smaxTop(i) - PumpCard.sminTop(i)
					Select Case RODUTIL.LookupStressMethod(PumpCard.mrgRodsStr(i))
						Case 0
							Dim num16 As Single = CSng(((CDbl(PumpCard.mrgRodsStr(i).TensileStrength) / 4.0 + 0.5625 * CDbl(PumpCard.sminTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 1
							Dim num16 As Single = CSng(((CDbl(PumpCard.mrgRodsStr(i).TensileStrength) / 2.8 + 0.375 * CDbl(PumpCard.sminTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 2
							Dim num16 As Single = CSng(((CDbl((PumpCard.mrgRodsStr(i).TensileStrength / 3F)) + 0.5625 * CDbl(PumpCard.sminTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 3
							Dim num16 As Single = CSng(((55000.0 + 0.2143 * CDbl(PumpCard.sminTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 4
							rst.StressL(i) = CSng(((CDbl(PumpCard.smaxTop(i)) - 0.5625 * CDbl(PumpCard.sminTop(i))) / (CDbl(PumpCard.mrgRodsStr(i).TensileStrength) / 4.0 * CDbl(rst.ServiceFactor))))
						Case 5
							Dim num18 As Single = PumpCard.sminTop(i) / 5000F
							Dim num16 As Single = CSng((13756.4 + 9816.09 * CDbl(num18) + 8892.61 * Math.Pow(CDbl(num18), 2.0) - 11380.1 * Math.Pow(CDbl(num18), 3.0) + 4828.34 * Math.Pow(CDbl(num18), 4.0) - 993.188 * Math.Pow(CDbl(num18), 5.0) + 100.304 * Math.Pow(CDbl(num18), 6.0) - 3.98389 * Math.Pow(CDbl(num18), 7.0)))
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 6
							Dim num19 As Single = CSng((CDbl(PumpCard.sminTop(i)) / 5428.6))
							If CDbl(num19) < 0.3 Then
								num19 = 0.3F
							End If
							Dim num16 As Single = CSng((19268.0 + 6152.0 * CDbl(num19) - 964.2 * Math.Pow(CDbl(num19), 2.0) + 67.5 * Math.Pow(CDbl(num19), 3.0)))
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 7
							Dim diameter As Single = PumpCard.mrgRodsStr(i).Diameter
							Dim num16 As Single
							If diameter < 0.8125F Then
								num16 = CSng((0.7 * CDbl(PumpCard.sminTop(i)) + 17778.0))
							ElseIf diameter >= 0.8125F AndAlso diameter <= 1.125F Then
								num16 = CSng((0.7 * CDbl(PumpCard.sminTop(i)) + 20000.0))
							ElseIf diameter > 1.125F Then
								num16 = CSng((0.625 * CDbl(PumpCard.sminTop(i)) + 19400.0))
							End If
							If num16 > 30000F Then
								num16 = 30000F
							End If
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 8
							rst.StressL(i) = PumpCard.smaxTop(i) / 58000F
						Case 9
							Dim num16 As Single
							If PumpCard.sminTop(i) >= 1250F And PumpCard.sminTop(i) <= 5000F Then
								num16 = PumpCard.sminTop(i) + 22500F
							ElseIf PumpCard.sminTop(i) > 5000F Then
								num16 = PumpCard.sminTop(i) / 4F + 26250F
							ElseIf PumpCard.sminTop(i) < 1250F Then
								num16 = PumpCard.sminTop(i) + 22500F
								If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										Util.Errmsg(RSWIN_DESC.sMinFiberodStressWarning_Meter)
									Else
										Util.Errmsg(RSWIN_DESC.sMinFiberodStressWarning_English)
									End If
								End If
							End If
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 10
							Dim num16 As Single = 50000F * RSWIN_DESC.rst.ServiceFactor
							RSWIN_DESC.rst.StressL(i) = PumpCard.smaxTop(i) / num16
						Case 11
							Dim num16 As Single = 12500F + PumpCard.sminTop(i) / 2F
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 12
							Dim num16 As Single = CSng(((CDbl(PumpCard.mrgRodsStr(i).TensileStrength) / 2.3 + 0.375 * CDbl(PumpCard.sminTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 13
							Dim num16 As Single
							If PumpCard.sminTop(i) >= 0F And PumpCard.sminTop(i) <= 5000F Then
								num16 = CSng((2.2 * CDbl(PumpCard.sminTop(i)) + 14000.0))
							ElseIf PumpCard.sminTop(i) > 5000F And PumpCard.sminTop(i) <= 7000F Then
								num16 = CSng((1.25 * CDbl(PumpCard.sminTop(i)) + 18750.0))
							ElseIf PumpCard.sminTop(i) > 7000F And PumpCard.sminTop(i) <= 12000F Then
								num16 = CSng((0.5 * CDbl(PumpCard.sminTop(i)) + 24000.0))
							ElseIf PumpCard.sminTop(i) > 12000F And PumpCard.sminTop(i) <= 35000F Then
								num16 = CSng((0.21739130434782608 * CDbl(PumpCard.sminTop(i)) + 27391.3))
							End If
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 14
							Dim num16 As Single = CSng((CDbl(PumpCard.sminTop(i)) * 0.3125 + 27500.0))
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 15
							Dim num16 As Single
							If PumpCard.sminTop(i) >= 1000F And PumpCard.sminTop(i) <= 5000F Then
								num16 = CSng((2.1875 * CDbl(PumpCard.sminTop(i)) + 14062.5))
							ElseIf PumpCard.sminTop(i) > 5000F And PumpCard.sminTop(i) < 10000F Then
								num16 = CSng((0.9332 * CDbl(PumpCard.sminTop(i)) + 20334.0))
							ElseIf PumpCard.sminTop(i) >= 10000F And PumpCard.sminTop(i) < 35000F Then
								num16 = CSng((0.21336 * CDbl(PumpCard.sminTop(i)) + 27532.4))
							ElseIf rst.minStressTop(i) >= 35000F Then
								If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										Util.Errmsg(RSWIN_DESC.sMaxFibercoStressWarning_Meter)
									Else
										Util.Errmsg(RSWIN_DESC.sMaxFibercoStressWarning_English)
									End If
								End If
							ElseIf rst.minStressTop(i) < 1000F Then
								num16 = CSng((2.1875 * CDbl(PumpCard.sminTop(i)) + 14062.5))
								If Not RSWIN_DESC.rst.gbBatch And (rst.RodStringType = 2S Or rst.RodStringType = 4S) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										Util.Errmsg(RSWIN_DESC.sMinFibercoStressWarning_Meter)
									Else
										Util.Errmsg(RSWIN_DESC.sMinFibercoStressWarning_English)
									End If
								End If
							End If
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
						Case 16
							Dim num16 As Single = CSng(((CDbl(rst.Sections(i).TensileStrength) / 2.6 + 0.375 * CDbl(PumpCard.sminTop(i))) * CDbl(rst.ServiceFactor)))
							Dim num17 As Single = num16 - PumpCard.sminTop(i)
							rst.StressL(i) = num15 / num17
					End Select
					If rst.StressL(i) < 0F Then
						rst.StressL(i) = 3F
					End If

			Next
			Return result
		End Function

		Private Const NEWRODLOGIC As Integer = 0

		Private Const NFourCoeff As Integer = 12

		Private Const WaterSpWt As Double = 62.4

		Private miNumRodsStr As Integer

		Private mrgRodsStr As RSWIN_DESC.RodSection()

		Private smaxTop As Single()

		Private sminTop As Single()

		Private smaxBot As Single()

		Private sminBot As Single()

		Private mfOmega As Single

		Private mfPeriod As Single
	End Module
End Namespace
