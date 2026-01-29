Imports System
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module RUNCALC
		Public Function BPDsurf(GrossPumpStroke As Single, SPM As Single, PlungerSize As Single, Pfill As Single) As Single
			Return CSng((0.1166 * CDbl(GrossPumpStroke) * CDbl(SPM) * Math.Pow(CDbl(PlungerSize), 2.0) * CDbl(Pfill)))
		End Function

		Public Sub CalculateEnergyConsumption(TCondition As Short, ByRef MotorKWH As Single)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num As Single = rst.SPM * rst.TotalTheta / 60F
				MotorKWH = 0F
				Dim num2 As Short = 0S
				Dim num3 As Short = rst.Ntsteps - 1S
				For num4 As Short = num2 To num3
					Dim tq As Single = rst.Tnet(CInt(TCondition), CInt(num4))
					Dim flag As Boolean = False
					Dim num5 As Single
					Motor.MotorEfficiency(tq, num5, flag)
					If rst.Tnet(CInt(TCondition), CInt(num4)) >= 0F Then
						Dim num6 As Single = CSng((CDbl((rst.Tnet(CInt(TCondition), CInt(num4)) * num / 6600F)) / 0.98))
						MotorKWH += num6 / num5
					ElseIf rst.PowerMeterType = 2S Then
						Dim num6 As Single = CSng((CDbl((-CDbl(rst.Tnet(CInt(TCondition), CInt(num4))) * num / 6600F)) * 0.98))
						MotorKWH -= num6 / num5
					End If
				Next
				Dim num7 As Double = CDbl((60F / rst.SPM / CSng(rst.Ntsteps)))
				MotorKWH = CSng((CDbl(MotorKWH) * (CDbl((rst.Runtime * rst.SPM)) * num7 / 80.43)))
			Catch ex As Exception
			End Try
		End Sub

		Public Sub CalculatePlungerSize(Pfill As Single)
			Dim array As String() = New String(0) {}
			Dim num As Short
			Util.LoadMenu("PLUNGER-SIZE-LIST", num, array)
			Dim array2 As Single() = New Single(CInt((num + 1S)) - 1) {}
			Dim num2 As Integer = 0
			Dim num3 As Short = 1S
			Dim num4 As Short = num
			For num5 As Short = num3 To num4
				' The following expression was wrapped in a checked-statement
				If Versioned.IsNumeric(array(CInt(num5))) Then
					num2 += 1
					array2(num2) = CSng(Conversion.Val(array(num2)))
					If array2(num2) = 0F Then
						num2 -= 1
						Exit For
					End If
				End If
			Next
			num = CShort(num2)
			Array.Clear(array, 0, array.Length)
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			Dim kinematicStroke As Single = cRODSTAR.PU.KinematicStroke
			Dim num6 As Single
			If kinematicStroke <= 46F Then
				num6 = 18F
			ElseIf kinematicStroke <= 57F Then
				num6 = 15F
			ElseIf kinematicStroke <= 78F Then
				num6 = 13.5F
			ElseIf kinematicStroke <= 104F Then
				num6 = 12F
			ElseIf kinematicStroke <= 124F Then
				num6 = 10F
			ElseIf kinematicStroke <= 150F Then
				num6 = 9F
			ElseIf kinematicStroke <= 172F Then
				num6 = 7.5F
			ElseIf kinematicStroke <= 260F Then
				num6 = 6F
			Else
				num6 = 4.5F
			End If
			If RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S Then
				Dim num7 As Single = 4.5F
				RUNCALC.CheckSPMThresHold(num7)
				If num6 > num7 Then
					num6 = num7
				End If
			End If
			Dim num8 As Single
			Dim num9 As Single
			Select Case cRODSTAR.PumpType
				Case 1S
					Dim tubingOD As Single = cRODSTAR.TubingOD
					If tubingOD = 1.9F Then
						num8 = 1E+38F
						num9 = 1.0625F
					ElseIf tubingOD = 1.9F Then
						num8 = 1E+38F
						num9 = 1.0625F
					ElseIf tubingOD = 2.375F Then
						num8 = 1.25F
						num9 = 1.5F
					ElseIf tubingOD = 2.875F Then
						num8 = 1.75F
						num9 = 2F
					ElseIf tubingOD = 3.5F Then
						num8 = 2.25F
						num9 = 2.75F
					ElseIf tubingOD = 4F Then
						num8 = 1E+38F
						num9 = 3F
					ElseIf tubingOD = 4.5F Then
						num8 = 1E+38F
						num9 = 3.25F
					ElseIf tubingOD = 5.5F Then
						num8 = 1E+38F
						num9 = 3.75F
					Else
						num8 = 1E+38F
						num9 = CSng((CDbl(cRODSTAR.TubingID) - 0.25))
					End If
					If CDbl(num8) = 1E+38 Then
						num8 = num9
					End If
				Case 2S
					Dim tubingOD2 As Single = cRODSTAR.TubingOD
					If tubingOD2 = 1.9F Then
						num9 = 1.25F
					ElseIf tubingOD2 = 2.375F Then
						num9 = 1.75F
					ElseIf tubingOD2 = 2.875F Then
						num9 = 2.25F
					ElseIf tubingOD2 = 3.5F Then
						num9 = 2.75F
					ElseIf tubingOD2 = 4F Then
						num9 = 3.25F
					ElseIf tubingOD2 = 4.5F Then
						num9 = 3.75F
					ElseIf tubingOD2 = 5.5F Then
						num9 = 4.75F
					Else
						num9 = CSng((CDbl(cRODSTAR.TubingID) - 0.25))
					End If
					num8 = num9
				Case 3S
					num9 = 1E+38F
					num8 = num9
			End Select
			If(cRODSTAR.RodStringType = 3S And cRODSTAR.PumpDepth > 4500F And cRODSTAR.giRodDesignStyle <> 0S) AndAlso CDbl(num8) > 2.5 Then
				num8 = 2.5F
			End If
			cRODSTAR.PlungerSize = 1.5F
			Dim plungerSize As Single
			Do
				plungerSize = cRODSTAR.PlungerSize
				If cRODSTAR.RodStringType = 1S Then
					RODUTIL.MakeAPIString(cRODSTAR.PumpDepth, cRODSTAR.APIRod, cRODSTAR.APIGrade, cRODSTAR.APIRodType)
				End If
				Dim num10 As Single
				If cRODSTAR.RodStringType = 3S Then
					num10 = -1F
				Else
					cRODSTAR.RodstringL = 0F
					Dim num11 As Single = 0F
					Dim num12 As Single = 0F
					Dim num13 As Short = 1S
					Dim numRods As Short = cRODSTAR.NumRods
					For num14 As Short = num13 To numRods
						cRODSTAR.RodstringL += cRODSTAR.Sections(CInt(num14)).length
						Try
							RODUTIL.LookupElasticity(cRODSTAR.Sections(CInt(num14)))
						Catch ex As Exception
						End Try
						Try
							RODUTIL.LookupRodWeight(cRODSTAR.Sections(CInt(num14)))
						Catch ex2 As Exception
						End Try
						num11 += cRODSTAR.Sections(CInt(num14)).length / (cRODSTAR.Sections(CInt(num14)).Elasticity * cRODSTAR.Sections(CInt(num14)).Area)
						num12 += cRODSTAR.Sections(CInt(num14)).RodWeight * cRODSTAR.Sections(CInt(num14)).length
					Next
					num11 = 12F / cRODSTAR.RodstringL * num11
					num12 = 1F / cRODSTAR.RodstringL * num12
					Dim num15 As Single = num11 * cRODSTAR.RodstringL
					num10 = cRODSTAR.PU.KinematicStroke / num15
				End If
				cRODSTAR.PlungerSize = CSng(Math.Sqrt(10.72 * CDbl(cRODSTAR.TargetBFPD) / CDbl((cRODSTAR.Runtime / 24F)) / CDbl(Pfill) / CDbl(cRODSTAR.PU.KinematicStroke) / CDbl(num6)))
				Dim num5 As Short
				num5 = num
				While num5 >= 2S
					' The following expression was wrapped in a checked-expression
					If cRODSTAR.PlungerSize > array2(CInt((num5 - 1S))) Then
						Dim num16 As Short
						If num10 < 0F Then
							num16 = -1S
						Else
							cRODSTAR.FoSkr = CSng(((0.433 * CDbl((cRODSTAR.FluidSPGR * cRODSTAR.PumpDepth - cRODSTAR.OilSPGR * cRODSTAR.FeetOverPump)) + CDbl(cRODSTAR.TubingPressure) - CDbl(cRODSTAR.CasingPressure)) * (3.141592653589793 * Math.Pow(CDbl(array2(CInt(num5))), 2.0) / 4.0) / CDbl(num10)))
							num16 = If((-If((CDbl(cRODSTAR.FoSkr) < 0.65 > False), 1S, 0S)), 1S, 0S)
						End If
						If num16 <> 0S Then
							If cRODSTAR.PumpDepth <= 4500F Then
								If array2(CInt(num5)) <= num9 Then
									Exit While
								End If
							ElseIf array2(CInt(num5)) <= num8 Then
								Exit While
							End If
						End If
					End If
					num5 += -1S
				End While
				cRODSTAR.PlungerSize = array2(CInt(num5))
				Dim num17 As Short
				If cRODSTAR.RodStringType = 3S Then
					num17 = If((-If(((cRODSTAR.giRodDesignStyle <> 0S) > False), 1S, 0S)), 1S, 0S)
				Else
					num17 = 0S
					Dim num18 As Short = 1S
					Dim numRods2 As Short = cRODSTAR.NumRods
					For num14 As Short = num18 To numRods2
						If RODUTIL.IsFG(cRODSTAR.Sections(CInt(num14)).Grade) Then
							num17 = -1S
						End If
					Next
				End If
				If num17 <> 0S Then
					Dim fluidLevel As Single = cRODSTAR.FluidLevel
					If fluidLevel >= 14000F Then
						If CDbl(cRODSTAR.PlungerSize) > 1.0625 Then
							cRODSTAR.PlungerSize = 1.0625F
						End If
					ElseIf fluidLevel >= 13000F Then
						If CDbl(cRODSTAR.PlungerSize) > 1.25 Then
							cRODSTAR.PlungerSize = 1.25F
						End If
					ElseIf fluidLevel >= 12000F AndAlso CDbl(cRODSTAR.PlungerSize) > 1.5 Then
						cRODSTAR.PlungerSize = 1.5F
					End If
				End If
			Loop While Not(cRODSTAR.RodStringType <> 1S Or cRODSTAR.PlungerSize = plungerSize)
			cRODSTAR.Apump = CSng((3.141592653589793 * Math.Pow(CDbl(cRODSTAR.PlungerSize), 2.0) / 4.0))
			cRODSTAR.FluidLoad = CSng(((0.433 * CDbl((cRODSTAR.FluidSPGR * cRODSTAR.PumpDepth - cRODSTAR.OilSPGR * cRODSTAR.FeetOverPump)) + CDbl(cRODSTAR.TubingPressure) - CDbl(cRODSTAR.CasingPressure)) * CDbl(cRODSTAR.Apump)))
			cRODSTAR = Nothing
		End Sub

		Public Function ExcessiveUndertravel(FoSkr As Single, NoverNoP As Single) As Short
			Dim result As Short
			Try
				result = 0S
				If CDbl(FoSkr) >= 0.675 Or CDbl(NoverNoP) >= 0.98 Then
					result = -1S
				ElseIf CDbl(FoSkr) >= 0.6 Then
					If CDbl(NoverNoP) <= 0.7 Then
						result = -1S
					End If
				ElseIf CDbl(FoSkr) >= 0.55 Then
					If CDbl(NoverNoP) <= 0.5 Then
						result = -1S
					End If
				ElseIf CDbl(FoSkr) >= 0.5 Then
					If CDbl(NoverNoP) <= 0.45 Then
						result = -1S
					End If
				ElseIf CDbl(FoSkr) >= 0.4 AndAlso CDbl(NoverNoP) <= 0.375 Then
					result = -1S
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub MaxRecSPM(iUnitType As Short, CatalogStroke As Single, ByRef MaxSPM As Single)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If iUnitType = 7S Or iUnitType = 10S Then
				MaxSPM = 4.5F
				RUNCALC.CheckSPMThresHold(MaxSPM)
			Else
				Dim num As Short = 0S
				Dim num2 As Short = 0S
				Select Case rst.RodStringType
					Case 2S
						Dim num3 As Short = 1S
						Dim numRods As Short = rst.NumRods
						For num4 As Short = num3 To numRods
							If rst.Sections(CInt(num4)).Grade = 20481S Then
								num2 = -1S
							ElseIf RODUTIL.IsFG(rst.Sections(CInt(num4)).Grade) Then
								num = -1S
							End If
						Next
					Case 3S
						Dim giRodDesignStyle As Short = rst.giRodDesignStyle
						If giRodDesignStyle = 1S Then
							num = -1S
						End If
				End Select
				MaxSPM = CSng((39.04 - 0.347 * CDbl(CatalogStroke) + 0.00171 * Math.Pow(CDbl(CatalogStroke), 2.0) - 3.15E-06 * Math.Pow(CDbl(CatalogStroke), 3.0)))
				Select Case iUnitType
					Case 5S
						MaxSPM = CSng((0.75 * CDbl(MaxSPM)))
					Case 6S
						MaxSPM = CSng((0.85 * CDbl(MaxSPM)))
					Case Else
						MaxSPM = CSng((0.9 * CDbl(MaxSPM)))
				End Select
				If(num Or num2) <> 0S Then
					MaxSPM = CSng((CDbl(MaxSPM) * 1.25))
				End If
			End If
			If rst.IncludeFluidInertia <> 0S Then
				MaxSPM = CSng((CDbl(MaxSPM) * 1.1))
			End If
			RSWIN_DESC.rst.MaxSPM = MaxSPM
		End Sub

		Public Function TubingStretch(FreeTubing As Single) As Single
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Return CSng((15.28 * CDbl(rst.FluidLoad) * CDbl(FreeTubing) / ((Math.Pow(CDbl(rst.TubingOD), 2.0) - Math.Pow(CDbl(rst.TubingID), 2.0)) * 30500000.0)))
		End Function

		Public Sub CheckSPMThresHold(ByRef fSPMThresHold As Single)
			' The following expression was wrapped in a checked-statement
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If rst.PU.UnitType = 7S Then
					Dim flag As Boolean = True
					If flag = Strings.InStr(rst.UnitID.Trim().ToUpper(), "HSP", CompareMethod.Binary) > 0 Then
						If rst.SPM > 4F Then
							fSPMThresHold = 4F
						End If
					Else
						If flag <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R1", False) = 0) Then
							If flag <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R2", False) = 0) Then
								If flag <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R5", False) = 0) Then
									If flag <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R6", False) = 0) Then
										If flag <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R9", False) = 0) Then
											If flag <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R10", False) = 0) Then
												If flag <> (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R13", False) = 0) Then
													If flag = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R3", False) = 0) OrElse flag = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R4", False) = 0) Then
														If CDbl(rst.SPM) > 4.3 Then
															fSPMThresHold = 4.3F
															GoTo IL_6FE
														End If
														GoTo IL_6FE
													ElseIf flag = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R7", False) = 0) Then
														If CDbl(rst.SPM) > 3.75 Then
															fSPMThresHold = 3.75F
															GoTo IL_6FE
														End If
														GoTo IL_6FE
													ElseIf flag = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R8", False) = 0) Then
														If CDbl(rst.SPM) > 3.64 Then
															fSPMThresHold = 3.64F
															GoTo IL_6FE
														End If
														GoTo IL_6FE
													ElseIf flag = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R11", False) = 0) OrElse flag = (Operators.CompareString(rst.UnitID.Trim().ToUpper(), "R12", False) = 0) Then
														If CDbl(rst.SPM) > 5.0 Then
															fSPMThresHold = 5F
															GoTo IL_6FE
														End If
														GoTo IL_6FE
													ElseIf flag = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) > 368F Then
														If CDbl(rst.SPM) > 3.75 Then
															fSPMThresHold = 3.75F
															GoTo IL_6FE
														End If
														GoTo IL_6FE
													ElseIf flag = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 340F Then
														If CDbl(rst.SPM) > 3.64 Then
															fSPMThresHold = 3.64F
															GoTo IL_6FE
														End If
														GoTo IL_6FE
													ElseIf flag = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) > 325F Then
														If CDbl(rst.SPM) > 4.0 Then
															fSPMThresHold = 4F
															GoTo IL_6FE
														End If
														GoTo IL_6FE
													ElseIf flag = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) > 315F Then
														If CDbl(rst.SPM) > 4.15 Then
															fSPMThresHold = 4.15F
															GoTo IL_6FE
														End If
														GoTo IL_6FE
													ElseIf flag = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) > 310F Then
														If CDbl(rst.SPM) > 4.25 Then
															fSPMThresHold = 4.25F
															GoTo IL_6FE
														End If
														GoTo IL_6FE
													ElseIf flag = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) > 300F Then
														If CDbl(rst.SPM) > 4.3 Then
															fSPMThresHold = 4.3F
															GoTo IL_6FE
														End If
														GoTo IL_6FE
													ElseIf flag = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 288F Then
														If CDbl(rst.SPM) > 4.5 Then
															fSPMThresHold = 4.5F
															GoTo IL_6FE
														End If
														GoTo IL_6FE
													Else
														If flag = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) > 280F Then
															If CDbl(rst.SPM) > 4.65 Then
																fSPMThresHold = 4.65F
															End If
															GoTo IL_6FE
														End If
														GoTo IL_6FE
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
						If CDbl(rst.SPM) > 4.5 Then
							fSPMThresHold = 4.5F
						End If
					End If
				ElseIf rst.PU.UnitType = 10S Then
					Dim flag2 As Boolean = True
					If flag2 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 360F Then
						If rst.SPM > 3F Then
							fSPMThresHold = 3F
						End If
					ElseIf flag2 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 336F Then
						If CDbl(rst.SPM) > 3.4 Then
							fSPMThresHold = 3.4F
						End If
					ElseIf flag2 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 288F Then
						If CDbl(rst.SPM) > 4.0 Then
							fSPMThresHold = 4F
						End If
					ElseIf flag2 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 240F Then
						If CDbl(rst.SPM) > 4.8 Then
							fSPMThresHold = 4.8F
						End If
					ElseIf flag2 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) >= 168F Then
						If CDbl(rst.SPM) > 6.9 Then
							fSPMThresHold = 6.9F
						End If
					ElseIf flag2 = rst.PU.Strokes(CInt((rst.PU.CrankHole - 1S))) < 168F AndAlso CDbl(rst.SPM) > 6.9 Then
						fSPMThresHold = 6.9F
					End If
				End If
				IL_6FE:
			Catch ex As Exception
			End Try
		End Sub
	End Module
End Namespace
