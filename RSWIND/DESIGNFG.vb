Imports System
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module DESIGNFG
		Public Property RSMax As Short
			Get
				Return DESIGNFG.m_RSMax
			End Get
			Set(value As Short)
				DESIGNFG.m_RSMax = value
			End Set
		End Property

		Public Property RSMin As Short
			Get
				Return DESIGNFG.m_RSMin
			End Get
			Set(value As Short)
				DESIGNFG.m_RSMin = value
			End Set
		End Property

		Public Sub BuildInitialFGString()
			DESIGNFG.FindLargestFG()
			DESIGNFG.MakeInitialFGSection(RSWIN_DESC.rst.Sections(1))
			Dim num As Integer = 1
			Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
			For i As Integer = num To numRods
				Debug.WriteLine(Conversions.ToString(i) + " " + Conversions.ToString(RSWIN_DESC.rst.Sections(i).length))
			Next
			If RSWIN_DESC.rst.Sections(1).Diameter > RSWIN_DESC.rst.LargestFG And RSWIN_DESC.rst.LargestFG <> 0F Then
				RSWIN_DESC.rst.Sections(1).Diameter = RSWIN_DESC.rst.LargestFG
				RSWIN_DESC.rst.Sections(1).Area = CSng((3.141592653589793 * Math.Pow(CDbl(RSWIN_DESC.rst.Sections(1).Diameter), 2.0) / 4.0))
			End If
			DESIGNFG.SetFGPercent(True)
			Dim num2 As Integer = 1
			Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
			For i As Integer = num2 To numRods2
				Debug.WriteLine(Conversions.ToString(i) + " " + Conversions.ToString(RSWIN_DESC.rst.Sections(i).length))
			Next
			If RSWIN_DESC.bRodStarD Then
				Dim num3 As Integer = 1
				Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num3 To numRods3
					RSWIN_DESC.rst.Sections(i).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
					RSWIN_DESC.rst.Sections(i).NumGuides = 0S
					RSWIN_DESC.rst.Sections(i).friction_coef = RSWIN_DESC.rst.RSFricCoef
					RSWIN_DESC.rst.Sections(i).Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
					Debug.WriteLine(Conversions.ToString(i) + " " + Conversions.ToString(RSWIN_DESC.rst.Sections(i).length))
				Next
				Return
			End If
		End Sub

		Private Function BuildSmallerFGString() As Short
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Short = -1S
			Dim rsfggrade As Short = rst.RSFGGrade
			If rsfggrade = 20481S OrElse rsfggrade = 16393S Then
				num = 0S
			ElseIf rsfggrade = 16385S OrElse rsfggrade = 16389S OrElse rsfggrade = 16390S Then
				Dim diameter As Single = rst.Sections(1).Diameter
				If diameter = 0.74F Then
					num = 0S
				ElseIf diameter = 0.865F Then
					rst.Sections(1).Diameter = 0.74F
				ElseIf diameter = 0.99F Then
					rst.Sections(1).Diameter = 0.865F
				ElseIf diameter = 1.24F Then
					rst.Sections(1).Diameter = 0.99F
				ElseIf diameter = 1.465F Then
					rst.Sections(1).Diameter = 1.24F
				End If
			ElseIf rsfggrade = 16386S Then
				Dim diameter2 As Single = rst.Sections(1).Diameter
				If diameter2 = 0.75F Then
					num = 0S
				ElseIf diameter2 = 0.87F Then
					rst.Sections(1).Diameter = 0.75F
				ElseIf diameter2 = 0.976F Then
					rst.Sections(1).Diameter = 0.87F
				ElseIf diameter2 = 1.25F Then
					rst.Sections(1).Diameter = 0.976F
				End If
			ElseIf rsfggrade = 16388S Then
				Dim diameter3 As Single = rst.Sections(1).Diameter
				If diameter3 = 0.75F Then
					num = 0S
				ElseIf diameter3 = 0.875F Then
					rst.Sections(1).Diameter = 0.75F
				ElseIf diameter3 = 1F Then
					rst.Sections(1).Diameter = 0.875F
				ElseIf diameter3 = 1.25F Then
					rst.Sections(1).Diameter = 1F
				End If
			ElseIf rsfggrade = 16387S Then
				Dim diameter4 As Single = rst.Sections(1).Diameter
				If diameter4 = 0.875F Then
					num = 0S
				ElseIf diameter4 = 1F Then
					rst.Sections(1).Diameter = 0.875F
				ElseIf diameter4 = 1.125F Then
					rst.Sections(1).Diameter = 1F
				ElseIf diameter4 = 1.25F Then
					rst.Sections(1).Diameter = 1.125F
				End If
			ElseIf rsfggrade = 16391S OrElse rsfggrade = 16395S Then
				Dim diameter5 As Single = rst.Sections(1).Diameter
				If diameter5 = 0.85F Then
					num = 0S
				ElseIf diameter5 = 0.98F Then
					rst.Sections(1).Diameter = 0.85F
				ElseIf diameter5 = 1.23F Then
					rst.Sections(1).Diameter = 0.98F
				End If
			ElseIf rsfggrade = 16394S OrElse rsfggrade = 16396S Then
				Dim diameter6 As Single = rst.Sections(1).Diameter
				If diameter6 = 1F Then
					num = 0S
				ElseIf diameter6 = 1.25F Then
					rst.Sections(1).Diameter = 1F
				End If
			ElseIf rsfggrade = 16393S Then
				rst.Sections(1).Diameter = 0.55F
			End If
			If num <> 0S Then
				rst.Sections(1).Area = CSng((3.141592653589793 * Math.Pow(CDbl(rst.Sections(1).Diameter), 2.0) / 4.0))
				RODUTIL.LookupRodWeight(rst.Sections(1))
			End If
			If RSWIN_DESC.bRodStarD Then
				Try
					If rst.Sections(1).Guide <= 0S Then
						rst.Sections(1).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
						rst.Sections(1).NumGuides = 0S
						rst.Sections(1).friction_coef = RSWIN_DESC.rst.RSFricCoef
						rst.Sections(1).Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
					End If
				Catch ex As Exception
				End Try
			End If
			Return num
		End Function

		Public Function CheckUndertravel() As Boolean
			Dim flag As Boolean = True
			Dim result As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				While RUNCALC.ExcessiveUndertravel(rst.FoSkr, rst.NoverNoP) <> 0S
					Dim num As Short = 0S
					Dim diameter As Single = rst.SinkerBar.Diameter
					If diameter >= 1.5F Then
						If rst.FGPercent > 65F Then
							num = -1S
						End If
					ElseIf diameter >= 1.25F Then
						If rst.FGPercent > 55F Then
							num = -1S
						End If
					ElseIf diameter >= 1.125F Then
						If rst.FGPercent > 50F Then
							num = -1S
						End If
					ElseIf diameter >= 1F Then
						If rst.FGPercent > 40F Then
							num = -1S
						End If
					Else
						num = -1S
					End If
					If num <> 0S Then
						If rst.FGPercent <= 30F Then
							Exit While
						End If
						rst.FGPercent -= 5F
						If rst.FGPercent < 30F Then
							rst.FGPercent = 30F
						End If
						DESIGNFG.SetFGPercent(False)
					ElseIf Not DESIGNFG.BuildLargerFGString() <> 0S Then
						If Not rst.CalcPlungerSize <> 0S Then
							Exit While
						End If
						If Not DESIGNFG.UseSmallerPlunger() <> 0S Then
							Exit While
						End If
					End If
					DESIGN.CalcRodStringValues()
				End While
				flag = Verify.VerifyFGRodStringDesign()
				result = flag
			Catch ex As Exception
				result = flag
			End Try
			Return result
		End Function

		Public Function DesignFG() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim flag4 As Boolean
			Dim num14 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim num2 As Short = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
				RSWIN_DESC.bChangeSPM = False
				RSWIN_DESC.bFGUnderTravel = False
				DESIGNFG.BuildInitialFGString()
				Dim flag3 As Boolean = DESIGNFG.ProcessInitialFGRodString() <> 0S
				If Not flag3 Then
					flag4 = flag3
				Else
					Dim flag5 As Boolean = True
					Dim flag6 As Boolean = False
					flag3 = True
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim num3 As Integer = 0
					Dim msgtxt As String
					While True
						Dim flag7 As Boolean = False
						Dim num4 As Single = 0F
						Dim num5 As Single = 0F
						num3 += 1
						Dim num6 As Integer = 0
						Dim flag11 As Boolean
						While True
							num6 += 1
							Dim num7 As Integer = 0
							Dim flag8 As Boolean
							Do
								num7 += 1
								If Not flag5 Then
									If RSWIN_DESC.bRodStarD Then
										flag3 = PREDICT.Predict(True, "DesignFG")
										If flag3 And RSWIN_DESC.bDoNegativeStressCheck Then
											If DESIGN.CheckForNegativeStresses() Then
												flag3 = PREDICT.Predict(True, "DesignFG")
											End If
										End If
									ElseIf rst.SPMEntered <> 0S Then
										flag3 = PREDICT.Predict(True, "DesignFG")
									Else
										flag3 = DESIGN.CheckProduction()
										If Not flag3 Then
											GoTo Block_9
										End If
									End If
									If Not flag3 Then
										Exit Do
									End If
									MWDown.StressAnalysis()
								End If

									If flag3 Then
										flag8 = True
										Dim flag9 As Boolean = False
										If flag5 Then
											flag5 = False
										End If
										If rst.StressL(1) + 0.005F > RSWIN_DESC.SETUP_MaxFGLoading Then
											flag9 = True
										End If
										If(If((-If((CDbl(rst.NoverNoP) > 0.9 > False), 1S, 0S)), 1S, 0S) Or (Not rst.SPMEntered And If((-If((rst.SPM > 11F > False), 1S, 0S)), 1S, 0S) And If((-If((CDbl(rst.FoSkr) > 0.55 > False), 1S, 0S)), 1S, 0S))) <> 0S Then
											flag9 = True
										End If
										If flag9 AndAlso DESIGNFG.BuildLargerFGString() <> 0S Then
											flag = False
											DESIGNFG.ProcessInitialFGRodString()
											flag5 = True
											flag7 = False
											flag8 = False
										End If
									End If
									Application.DoEvents()

							Loop While Not flag8
							IL_1AE:
							If flag2 Then
								Exit For
							End If
							If flag3 Then
								Dim flag10 As Boolean = True
								If RSWIN_DESC.rst.Sections(1).Grade <> 16393S Then
									If CDbl(rst.StressL(1)) > 1.45 Then
										flag10 = False
									End If
									If CDbl(rst.StressL(1)) > 1.15 And (rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S) And CDbl(rst.SPM) < 0.5 Then
										flag10 = False
									End If
									If CDbl(rst.StressL(1)) > 1.15 And Not(rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S) And rst.SPM < 2F Then
										flag10 = False
									End If
									If(rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S) And Single.IsNaN(rst.StressL(1)) Then
										flag10 = False
									End If
								End If
								If Not flag10 Then
									GoTo Block_24
								End If
								If rst.SPMEntered <> 0S Then
									flag3 = PREDICT.Predict(True, "DesignFG")
									If flag3 And RSWIN_DESC.bRodStarD And RSWIN_DESC.bDoNegativeStressCheck Then
										If DESIGN.CheckForNegativeStresses() Then
											flag3 = PREDICT.Predict(True, "DesignFG")
										End If
									End If
								Else
									flag3 = DESIGN.CheckProduction()
									If Not flag3 Then
										GoTo Block_28
									End If
								End If
								Dim surfLoad As Single() = rst.SurfLoad
								Dim cRODSTAR As cRODSTAR = rst
								Dim pprload As Single = cRODSTAR.Pprload
								Dim cRODSTAR2 As cRODSTAR = rst
								Dim mprload As Single = cRODSTAR2.Mprload
								Dim num8 As Single = 0F
								Dim num9 As Single = 0F
								Util.Maxmin(surfLoad, pprload, mprload, num8, num9)
								cRODSTAR2.Mprload = mprload
								cRODSTAR.Pprload = pprload
								MWDown.StressAnalysis()
								flag11 = False
								If Not RUNCALC.ExcessiveUndertravel(rst.FoSkr, rst.NoverNoP) <> 0S Then
									Dim array As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(CInt((rst.NumRods + 1S)) - 1) {}
									Dim num10 As Short = 1S
									Dim numRods As Short = rst.NumRods

										num2 = num10
										While num2 <= numRods
											array(CInt(num2)) = rst.Sections(CInt(num2))
											num2 += 1S
										End While
										If rst.minStressBot(1) > 3000F And CDbl(rst.StressL(1)) < 0.6 And Not flag6 Then
											If rst.minStressBot(1) <> num4 Or rst.StressL(1) <> num5 Then
												flag11 = (DESIGNFG.BuildSmallerFGString() <> 0S)
												num4 = rst.minStressBot(1)
												num5 = rst.StressL(1)
												flag = True
											Else
												flag = False
												Debug.Write("")
											End If
										ElseIf rst.minStressBot(1) > 5000F And rst.FGPercent <= 75F And Not flag7 Then
											rst.FGPercent += 10F
											DESIGNFG.SetFGPercent(False)
											flag11 = True
										ElseIf rst.RSFGGrade = 20481S Then
											If rst.minStressBot(1) > 1500F And rst.FGPercent <= 85F And Not flag7 Then
												If(rst.RSIncludeSB And If((-If((CDbl(rst.SinkerBar.Diameter) > 1.25 > False), 1S, 0S)), 1S, 0S)) <> 0S Then
													rst.FGPercent = CSng((CDbl(rst.FGPercent) + 2.5))
												Else
													rst.FGPercent += 5F
												End If
												DESIGNFG.SetFGPercent(False)
												flag11 = True
											ElseIf rst.minStressBot(1) * rst.Sections(1).Area <= 500F And rst.FGPercent > 20F Then
												rst.FGPercent = CSng((CDbl(rst.FGPercent) - 2.5))
												DESIGNFG.SetFGPercent(False)
												flag7 = True
												flag11 = True
											End If
										ElseIf rst.RSFGGrade = 16393S Then
											If rst.minStressBot(1) > 1250F And CDbl(rst.FGPercent) <= 92.5 And Not flag7 Then
												If(rst.RSIncludeSB And If((-If((CDbl(rst.SinkerBar.Diameter) > 1.25 > False), 1S, 0S)), 1S, 0S)) <> 0S Then
													rst.FGPercent = CSng((CDbl(rst.FGPercent) + 2.5))
												Else
													rst.FGPercent += 5F
													If rst.FGPercent > 95F Then
														rst.FGPercent = 95F
													End If
												End If
												DESIGNFG.SetFGPercent(False)
												flag11 = True
											ElseIf rst.minStressBot(1) * rst.Sections(1).Area <= 500F And CDbl(rst.FGPercent) > 7.5 Then
												rst.FGPercent = CSng((CDbl(rst.FGPercent) - 2.5))
												DESIGNFG.SetFGPercent(False)
												flag7 = True
												flag11 = True
											End If
										ElseIf rst.minStressBot(1) > 3000F And rst.FGPercent <= 85F And Not flag7 Then
											rst.FGPercent += 5F
											DESIGNFG.SetFGPercent(False)
											flag11 = True
										ElseIf rst.minStressBot(1) * rst.Sections(1).Area <= 500F And rst.FGPercent > 30F Then
											rst.FGPercent = CSng((CDbl(rst.FGPercent) - 2.5))
											DESIGNFG.SetFGPercent(False)
											flag7 = True
											flag11 = True
										End If
										If flag11 Then
											DESIGN.CalcRodStringValues()
											If RUNCALC.ExcessiveUndertravel(rst.FoSkr, rst.NoverNoP) <> 0S Then
												Dim num11 As Short = 1S
												Dim numRods2 As Short = rst.NumRods
												num2 = num11
												While num2 <= numRods2
													rst.Sections(CInt(num2)) = array(CInt(num2))
													num2 += 1S
												End While
												DESIGN.CalcRodStringValues()
												flag11 = False
											End If
										End If

								End If
							End If
							If Not flag11 OrElse Not flag3 Then
								Exit For
							End If
							Continue For
							Block_9:
							flag2 = True
							GoTo IL_1AE
						End While
						IL_855:
						If flag2 Then
							Exit For
						End If
						If flag3 Then
							If Conversions.ToBoolean(Operators.AndObject(Not rst.SPMEntered, Operators.CompareObjectLess(Operators.DivideObject(rst.BPDsurface, Interaction.IIf(rst.TargetBFPD = 0F, 1, rst.TargetBFPD)), 0.97, False))) Then
								flag11 = (DESIGNFG.BuildLargerFGString() <> 0S)
								flag = False
								If flag11 Then
									flag6 = True
								End If
							ElseIf CDbl(rst.NoverNoP) > 0.8 And Not flag Then
								flag11 = (DESIGNFG.BuildLargerFGString() <> 0S)
								flag = False
							End If
							If flag11 Then
								DESIGN.CalcRodStringValues()
							End If
						End If
						If Not flag11 OrElse Not flag3 Then
							Exit For
						End If
						Continue For
						GoTo IL_855
						Block_24:
						Util.LoadMessage(196, msgtxt)
						Util.Errmsg(msgtxt)
						flag3 = False
						GoTo IL_855
						Block_28:
						flag2 = True
						GoTo IL_855
					End While
					If RSWIN_DESC.rst.Sections(1).Grade = 16393S And CDbl(rst.StressL(1)) > 1.21 Then
						Util.LoadMessage(196, msgtxt)
						Util.Errmsg(msgtxt)
						flag3 = False
					End If
					If Not flag3 OrElse flag2 Then
						flag4 = False
					Else
						If rst.NumRods > 2S Then
							While Not DESIGNST.BalanceSteelString()
								flag3 = PREDICT.Predict(True, "DesignFG")
								If(flag3 And RSWIN_DESC.bRodStarD And RSWIN_DESC.bDoNegativeStressCheck) AndAlso DESIGN.CheckForNegativeStresses() Then
									flag3 = PREDICT.Predict(True, "DesignFG")
								End If
								If Not flag3 Then
									Exit While
								End If
								MWDown.StressAnalysis()
							End While
						End If
						If Not flag3 Then
							flag4 = False
						Else
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							num2 = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
							Dim pumpPos As Single() = rst.PumpPos
							Dim num9 As Single = 0F
							Dim num8 As Single = 0F
							Dim num12 As Single
							Dim num13 As Single
							Util.Maxmin(pumpPos, num12, num13, num9, num8)

								rst.GrossPumpStroke = num12 - num13
								If(If((-If(((rst.BPDsurface = 0F Or Not RSWIN_DESC.bRodStarD) > False), 1S, 0S)), 1S, 0S) Or (If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.SETUP_UseImpred)) <> 0S Then
									rst.BPDsurface = RUNCALC.BPDsurf(rst.GrossPumpStroke - rst.TubStretch, rst.SPM, rst.PlungerSize, rst.Pfill) * rst.Runtime / 24F
									If RSWIN_DESC.rst.PumpCondition = 2S Or RSWIN_DESC.rst.PumpCondition = 3S Then
										rst.BPDsurface = rst.BPDsurface * rst.PumpEfficiency / 100F
									End If
								End If
								rst.ProductionLoss = RUNCALC.BPDsurf(rst.TubStretch, rst.SPM, rst.PlungerSize, rst.Pfill) * rst.Runtime / 24F

							num2 = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
							If Not Verify.VerifyPumpStroke() Then
								flag4 = False
							Else
								flag4 = True
							End If
						End If
					End If
				End If
				IL_B3A:
				GoTo IL_B81
				IL_B3C:
				num14 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_B52:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num14 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_B3C
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_B81:
			Dim result As Boolean = flag4
			If num14 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub FGRemoveBottomSteelSection()
			Dim num As Short = 0S
			If DESIGNFG.RSMin < DESIGNFG.RSMax Then
				DESIGNFG.RSMin += 1S
				num = -1S
			End If
			If num <> 0S Then
				DESIGNFG.MakeSteelString(2, RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.rst.Sections(1).length, False)
				Return
			End If
		End Sub

		Private Sub FindLargestFG()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If RODUTIL.IsFG(rst.RSFGGrade) Then
				Dim rsfggrade As Short = rst.RSFGGrade
				Dim num As Short
				If rsfggrade = 20481S Then
					num = CShort(Information.UBound(New Object() { Nothing, Math.Sqrt(0.391393836051589) }, 1))
				ElseIf rsfggrade = 16385S OrElse rsfggrade = 16389S OrElse rsfggrade = 16390S Then
					DESIGNFG.diams = New Single(5) {}
					DESIGNFG.diams(1) = 0.74F
					DESIGNFG.diams(2) = 0.865F
					DESIGNFG.diams(3) = 0.99F
					DESIGNFG.diams(4) = 1.24F
					DESIGNFG.diams(5) = 1.465F
					num = CShort(Information.UBound(DESIGNFG.diams, 1))
				ElseIf rsfggrade = 16386S Then
					DESIGNFG.diams = New Single(4) {}
					DESIGNFG.diams(1) = 0.75F
					DESIGNFG.diams(2) = 0.87F
					DESIGNFG.diams(3) = 0.976F
					DESIGNFG.diams(4) = 1.25F
					num = CShort(Information.UBound(DESIGNFG.diams, 1))
				ElseIf rsfggrade = 16388S Then
					DESIGNFG.diams = New Single(4) {}
					DESIGNFG.diams(1) = 0.75F
					DESIGNFG.diams(2) = 0.875F
					DESIGNFG.diams(3) = 1F
					DESIGNFG.diams(4) = 1.25F
					num = CShort(Information.UBound(DESIGNFG.diams, 1))
				ElseIf rsfggrade = 16387S Then
					DESIGNFG.diams = New Single(4) {}
					DESIGNFG.diams(1) = 0.875F
					DESIGNFG.diams(2) = 1F
					DESIGNFG.diams(3) = 1.125F
					DESIGNFG.diams(4) = 1.25F
					num = CShort(Information.UBound(DESIGNFG.diams, 1))
				ElseIf rsfggrade = 16391S OrElse rsfggrade = 16395S Then
					DESIGNFG.diams = New Single(3) {}
					DESIGNFG.diams(1) = 0.85F
					DESIGNFG.diams(2) = 0.98F
					DESIGNFG.diams(3) = 1.23F
					num = CShort(Information.UBound(DESIGNFG.diams, 1))
				ElseIf rsfggrade = 16394S OrElse rsfggrade = 16396S Then
					DESIGNFG.diams = New Single(2) {}
					DESIGNFG.diams(1) = 1F
					DESIGNFG.diams(2) = 1.25F
					num = CShort(Information.UBound(DESIGNFG.diams, 1))
				ElseIf rsfggrade = 16393S Then
					DESIGNFG.diams = New Single(1) {}
					DESIGNFG.diams(1) = 0.55F
					num = CShort(Information.UBound(DESIGNFG.diams, 1))
				End If
				Dim num2 As Short
				num2 = num
				While num2 >= 1S
					Dim text As String = ""
					Dim quiet As Object = True
					Dim grade As Object = rst.RSFGGrade
					Dim diameter As Object = DESIGNFG.diams(CInt(num2))
					Dim flag As Boolean
					Dim obj As Object = flag
					Dim flag2 As Boolean
					Dim obj2 As Object = flag2
					Dim obj3 As Object = text
					Dim flag3 As Boolean
					Dim obj4 As Object = flag3
					RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj, obj2, obj3, obj4, 0)
					flag3 = Conversions.ToBoolean(obj4)
					text = Conversions.ToString(obj3)
					flag2 = Conversions.ToBoolean(obj2)
					flag = Conversions.ToBoolean(obj)
					If flag Then
						Exit While
					End If
					num2 += -1S
				End While
				If num2 = num Then
					rst.LargestFG = 0F
				Else
					rst.LargestFG = DESIGNFG.diams(CInt(num2))
				End If
			End If
		End Sub

		Private Sub MakeInitialFGSection(ByRef sect As RSWIN_DESC.RodSection)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim rsfggrade As Short = rst.RSFGGrade
			If rsfggrade = 20481S Then
				sect.Diameter = CSng(Math.Sqrt(0.391393836051589))
				sect.RodDensity = 100F
			ElseIf rsfggrade = 16385S OrElse rsfggrade = 16389S OrElse rsfggrade = 16390S Then
				Dim fluidLoad As Single = rst.FluidLoad
				If fluidLoad > 7000F Then
					sect.Diameter = 1.24F
				ElseIf fluidLoad > 5000F Then
					sect.Diameter = 0.99F
				ElseIf fluidLoad > 3500F Then
					sect.Diameter = 0.865F
				Else
					sect.Diameter = 0.74F
				End If
				sect.RodDensity = 155F
			ElseIf rsfggrade = 16387S Then
				Dim fluidLoad2 As Single = rst.FluidLoad
				If fluidLoad2 > 9000F Then
					sect.Diameter = 1.25F
				ElseIf fluidLoad2 > 5000F Then
					sect.Diameter = 1.125F
				ElseIf fluidLoad2 > 3500F Then
					sect.Diameter = 1F
				Else
					sect.Diameter = 0.875F
				End If
				sect.RodDensity = 155F
			ElseIf rsfggrade = 16386S Then
				Dim fluidLoad3 As Single = rst.FluidLoad
				If fluidLoad3 > 9000F Then
					sect.Diameter = 1.25F
				ElseIf fluidLoad3 > 5000F Then
					sect.Diameter = 0.976F
				ElseIf fluidLoad3 > 3500F Then
					sect.Diameter = 0.87F
				Else
					sect.Diameter = 0.75F
				End If
				sect.RodDensity = 155F
			ElseIf rsfggrade = 16388S Then
				Dim fluidLoad4 As Single = rst.FluidLoad
				If fluidLoad4 > 9000F Then
					sect.Diameter = 1.25F
				ElseIf fluidLoad4 > 5000F Then
					sect.Diameter = 1F
				ElseIf fluidLoad4 > 3500F Then
					sect.Diameter = 0.875F
				Else
					sect.Diameter = 0.75F
				End If
				sect.RodDensity = 155F
			ElseIf rsfggrade = 16391S OrElse rsfggrade = 16395S Then
				Dim fluidLoad5 As Single = rst.FluidLoad
				If fluidLoad5 > 5000F Then
					sect.Diameter = 1.23F
				ElseIf fluidLoad5 > 3500F Then
					sect.Diameter = 0.98F
				Else
					sect.Diameter = 0.85F
				End If
				sect.RodDensity = 130F
			ElseIf rsfggrade = 16394S OrElse rsfggrade = 16396S Then
				Dim fluidLoad6 As Single = rst.FluidLoad
				If fluidLoad6 > 5000F Then
					sect.Diameter = 1.25F
				ElseIf fluidLoad6 > 3500F Then
					sect.Diameter = 1F
				Else
					sect.Diameter = 1F
				End If
				sect.RodDensity = 130F
			ElseIf rsfggrade = 16393S Then
				sect.Diameter = 0.55F
				sect.RodDensity = 125F
			End If
			sect.Grade = rst.RSFGGrade
			sect.RodType = RODUTIL.RodGrade(rst.RSFGGrade)
			If rst.RSSuckerRodLength = 0F AndAlso (RODUTIL.IsFG(sect.Grade) Or CUSTOMRG.IsOtherFG(CInt(sect.Grade))) Then
				rst.RSSuckerRodLength = 37.5F
			End If
			sect.SuckerRodLength = rst.RSSuckerRodLength
			sect.Area = CSng((3.141592653589793 * Math.Pow(CDbl(sect.Diameter), 2.0) / 4.0))
			If RSWIN_DESC.bRodStarD Then
				sect.friction_coef = RSWIN_DESC.rst.RSFricCoef
				sect.Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
			ElseIf RSWIN_DESC.rst.RSFricCoef = 0F Then
				sect.friction_coef = 0.2F
			Else
				sect.friction_coef = RSWIN_DESC.rst.RSFricCoef
			End If
			RODUTIL.LookupElasticity(sect)
			RODUTIL.LookupRodWeight(sect)
			If RSWIN_DESC.bRodStarD Then
				Try
					If sect.Guide <= 0S Then
						sect.Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
						sect.NumGuides = 0S
						sect.friction_coef = RSWIN_DESC.rst.RSFricCoef
						sect.Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
					End If
				Catch ex As Exception
				End Try
				Return
			End If
		End Sub

		Private Sub MakeSteelString(iFirstSect As Object, totalLength As Single, bInitialize As Object)
			Dim array As String() = New String(1) {}
			Dim array2 As String() = New String(0) {}
			Dim flag As Boolean = False
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			Dim num As Single
			Dim flag2 As Boolean
			Dim rodSection As RSWIN_DESC.RodSection
			If cRODSTAR.RSIncludeSB <> 0S Then
				If(Not cRODSTAR.RSFGIncludeSteel And If((-If((RSWIN_DESC.bSinkerBarDepthChanged > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Dim length As Single = cRODSTAR.SinkerBar.length
					RSWIN_DESC.fNewSinkerbarDepth = DESIGN.GetDepthFromInclination(length, num, flag2)
					RSWIN_DESC.fNewTaperLength = RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.fNewSinkerbarDepth
				End If
				If RSWIN_DESC.bSinkerBarDepthChanged And RSWIN_DESC.fNewTaperLength <> 0F Then
					rodSection.Initialize()
					rodSection.length = RSWIN_DESC.fNewTaperLength
					If RSWIN_DESC.rst.RSGrade <> 0S Then
						rodSection.Grade = RSWIN_DESC.rst.RSGrade
					Else
						rodSection.Grade = 4124S
					End If
					If RSWIN_DESC.rst.RSSRSize > 0F Then
						rodSection.Diameter = RSWIN_DESC.rst.RSSRSize
					ElseIf RSWIN_DESC.rst.RSMinSize > 0F Then
						rodSection.Diameter = RSWIN_DESC.rst.RSMinSize
					Else
						rodSection.Diameter = 1F
					End If
					rodSection.SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
					RODUTIL.LookupElasticity(rodSection)
					RODUTIL.LookupRodWeight(rodSection)
					RODUTIL.LookupStressMethod(rodSection)
					rodSection.Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
					rodSection.friction_coef = RODUTIL.GetFricCoeff(CInt(rodSection.Guide), True)
				End If
			End If
			If Not cRODSTAR.RSFGIncludeSteel <> 0S Then
				cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)) = cRODSTAR.SinkerBar
				cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)).length = totalLength
				If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.rst.RSIncludeSB And Not cRODSTAR.RSFGIncludeSteel And If((-If((RSWIN_DESC.bSinkerBarDepthChanged > False), 1S, 0S)), 1S, 0S)) <> 0S AndAlso cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)).length > RSWIN_DESC.fSBMaxLength Then
					cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)).length = RSWIN_DESC.fSBMaxLength
					Dim fSBMaxLength As Single = RSWIN_DESC.fSBMaxLength
					Dim depthFromInclination As Single = DESIGN.GetDepthFromInclination(fSBMaxLength, num, flag2)
					RSWIN_DESC.fSBMaxLength = fSBMaxLength
					RSWIN_DESC.fNewSinkerbarDepth = depthFromInclination
					RSWIN_DESC.fNewTaperLength = RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.fNewSinkerbarDepth
				End If
				RODUTIL.LookupRodWeight(cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)))
				cRODSTAR.NumRods = Conversions.ToShort(iFirstSect)
				If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And cRODSTAR.RSIncludeSB And If((-If((RSWIN_DESC.bSinkerBarDepthChanged > False), 1S, 0S)), 1S, 0S) And If((-If((RSWIN_DESC.fNewTaperLength > 0F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)).length = cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)).length - RSWIN_DESC.fNewTaperLength
					If cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)).length > RSWIN_DESC.fSBMaxLength Then
						cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)).length = RSWIN_DESC.fSBMaxLength
						Dim fSBMaxLength As Single = RSWIN_DESC.fSBMaxLength
						Dim depthFromInclination2 As Single = DESIGN.GetDepthFromInclination(fSBMaxLength, num, flag2)
						RSWIN_DESC.fSBMaxLength = fSBMaxLength
						RSWIN_DESC.fNewSinkerbarDepth = depthFromInclination2
						RSWIN_DESC.fNewTaperLength = RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.fNewSinkerbarDepth
						rodSection.length = RSWIN_DESC.fNewTaperLength
					End If
					cRODSTAR.NumRods += 1S
					cRODSTAR.Sections(CInt(cRODSTAR.NumRods)) = rodSection
				End If
			ElseIf(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And cRODSTAR.RSIncludeSB And RSWIN_DESC.rst.RSFGIncludeSteel And If((-If((RSWIN_DESC.bSinkerBarDepthChanged > False), 1S, 0S)), 1S, 0S) And If((-If((RSWIN_DESC.fNewTaperLength > 0F > False), 1S, 0S)), 1S, 0S) And If((-If((cRODSTAR.SinkerBar.length + RSWIN_DESC.fNewTaperLength >= totalLength > False), 1S, 0S)), 1S, 0S) And If((-If((totalLength - RSWIN_DESC.fNewTaperLength > 50F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)) = cRODSTAR.SinkerBar
				cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)).length = totalLength
				RODUTIL.LookupRodWeight(cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)))
				cRODSTAR.NumRods = Conversions.ToShort(iFirstSect)
				cRODSTAR.NumRods += 1S
				cRODSTAR.Sections(CInt(cRODSTAR.NumRods)) = rodSection
				cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)).length = cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)).length - RSWIN_DESC.fNewTaperLength
			ElseIf(cRODSTAR.RSIncludeSB And If((-If((cRODSTAR.SinkerBar.length >= totalLength > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)) = cRODSTAR.SinkerBar
				cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)).length = totalLength
				RODUTIL.LookupRodWeight(cRODSTAR.Sections(Conversions.ToInteger(iFirstSect)))
				cRODSTAR.NumRods = Conversions.ToShort(iFirstSect)
			Else
				Dim array3 As Single()
				Dim num3 As Short
				If Conversions.ToBoolean(bInitialize) Then
					' The following expression was wrapped in a unchecked-expression
					DESIGNFG.RSMin = CShort(Math.Round(CDbl((8F * cRODSTAR.RSMinSize))))
					DESIGNFG.RSMax = CShort(Math.Round(CDbl((8F * cRODSTAR.RSMaxSize))))
				End If
				Dim num2 As Short
				If DESIGNFG.RSMin < 10S Then
					num2 = 10S * DESIGNFG.RSMax + DESIGNFG.RSMin
				Else
					num2 = 100S * DESIGNFG.RSMax + DESIGNFG.RSMin
				End If
				RODUTIL.GetAPITable(array3, num2, cRODSTAR.PlungerSize)
				num3 = CShort(Information.UBound(array3, 1))
				Dim array4 As Single()
				If(If((-If((RODUTIL.IsCorod(cRODSTAR.RSGrade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(cRODSTAR.RSGrade))) <> 0 Then
					Try
						Dim rsgrade As Short = cRODSTAR.RSGrade
						COSTDB.GetDIAMSfromThetaStdInfo(rsgrade, array, array4, RSWIN_DESC.nItems, True)
					Catch ex As Exception
						RSWIN_DESC.nItems = 0S
					End Try
				End If
				Dim num4 As Single = cRODSTAR.RSMaxSize
				Dim num5 As Short = 1S
				Dim num6 As Short = num3
				For num7 As Short = num5 To num6
					cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Grade = cRODSTAR.RSGrade
					cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).RodType = cRODSTAR.RSRodType
					If RSWIN_DESC.bRodStarD Then
						Try
							If cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Guide <= 0S Then
								cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
								cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).NumGuides = 0S
								cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).friction_coef = RSWIN_DESC.rst.RSFricCoef
								cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
							End If
						Catch ex2 As Exception
						End Try
					End If
					If RODUTIL.IsCorod(cRODSTAR.RSGrade) Then
						If Not flag Then
							' The following expression was wrapped in a checked-expression
							cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Diameter = CSng((CDbl(num4) - CDbl((num7 - 1S)) / 16.0))
						Else
							Dim num8 As Integer
							num8 += 1
							cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Diameter = CSng((CDbl(num4) - CDbl((num8 - 1)) / 16.0))
						End If
						If num7 = 1S AndAlso CDbl(num4) > 1.125 Then
							num4 = 1.125F
						End If
						Dim flag3 As Boolean = DESIGNFG.CheckCorodDiam(array4, cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Diameter)
						Dim num8 As Integer
						If Not flag Then
							num8 = CInt(num7)
						Else
							num8 = CInt((num7 + 1S))
						End If
						While Not flag3
							If num8 <= CInt(RSWIN_DESC.nItems) Then
								num8 += 1
								flag = True
								cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Diameter = CSng((CDbl(num4) - CDbl((num8 - 1)) / 16.0))
								flag3 = DESIGNFG.CheckCorodDiam(array4, cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Diameter)
							Else
								flag3 = True
							End If
						End While
					ElseIf RODUTIL.IsProRod(CInt(cRODSTAR.RSGrade)) <> 0 Then
						' The following expression was wrapped in a checked-expression
						If CDbl(cRODSTAR.RSMaxSize) - CDbl((num7 - 1S)) / 16.0 = 0.9375 Then
							cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Diameter = 0.875F
						Else
							' The following expression was wrapped in a checked-expression
							cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Diameter = CSng((CDbl(cRODSTAR.RSMaxSize) - CDbl((num7 - 1S)) / 16.0))
						End If
					Else
						' The following expression was wrapped in a checked-expression
						cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Diameter = CSng((CDbl(cRODSTAR.RSMaxSize) - CDbl((num7 - 1S)) / 8.0))
					End If
					cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Area = CSng((Math.Pow(CDbl(cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Diameter), 2.0) * 3.141592653589793 / 4.0))
				Next
				If cRODSTAR.RSIncludeSB <> 0S Then
					Dim num9 As Single
					If RSWIN_DESC.bRodStarD And RSWIN_DESC.bSinkerBarDepthChanged And RSWIN_DESC.fNewTaperLength > 0F Then
						num9 = 1F - (cRODSTAR.SinkerBar.length + RSWIN_DESC.fNewTaperLength) / totalLength
					Else
						num9 = 1F - cRODSTAR.SinkerBar.length / totalLength
					End If
					Dim num10 As Short = 1S
					Dim num11 As Short = num3
					For num7 As Short = num10 To num11
						array3(CInt(num7)) = array3(CInt(num7)) * num9
					Next
					num3 += 1S
					array3 = CType(Utils.CopyArray(CType(array3, Array), New Single(CInt((num3 + 1S)) - 1) {}), Single())
					cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num3), 1))) = cRODSTAR.SinkerBar
					array3(CInt(num3)) = 0F
					If RSWIN_DESC.bRodStarD And RSWIN_DESC.bSinkerBarDepthChanged And RSWIN_DESC.fNewTaperLength > 0F Then
						If Not cRODSTAR.RSFGIncludeSteel <> 0S Then
							Dim length As Single = cRODSTAR.SinkerBar.length
							RSWIN_DESC.fNewSinkerbarDepth = DESIGN.GetDepthFromInclination(length, num, flag2)
							RSWIN_DESC.fNewTaperLength = RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.fNewSinkerbarDepth
							rodSection.length = RSWIN_DESC.fNewTaperLength
						End If
						cRODSTAR.Sections(Conversions.ToInteger(Operators.AddObject(iFirstSect, num3))) = rodSection
					End If
				End If
				Dim num12 As Single = 0F
				Dim num13 As Short = 1S
				Dim num14 As Short = num3
				For num7 As Short = num13 To num14
					RODUTIL.LookupRodWeight(cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))))
					RODUTIL.LookupTensileStrength(cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))))
					If array3(CInt(num7)) > 0F Then
						cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).length = array3(CInt(num7)) * totalLength
					End If
					cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).Elasticity = 30500000F
					cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).RodDensity = 491F
					If(If((-If((RODUTIL.IsCorod(cRODSTAR.RSGrade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(cRODSTAR.RSGrade))) <> 0 Then
						cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).SuckerRodLength = 1F
					Else
						cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
					End If
					num12 += cRODSTAR.Sections(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(iFirstSect, num7), 1))).length
					If num12 < 0F Then
						Debug.WriteLine(num12)
					End If
				Next
				cRODSTAR.NumRods = Conversions.ToShort(Operators.SubtractObject(Operators.AddObject(iFirstSect, num3), 1))
				If RSWIN_DESC.bRodStarD And RSWIN_DESC.bSinkerBarDepthChanged And RSWIN_DESC.fNewTaperLength > 0F Then
					cRODSTAR.NumRods += 1S
					cRODSTAR.Sections(CInt(cRODSTAR.NumRods)) = rodSection
				End If
			End If
			cRODSTAR = Nothing
			If RSWIN_DESC.bRodStarD Then
				Dim num15 As Short = 1S
				Dim numRods As Short = RSWIN_DESC.rst.NumRods
				For num7 As Short = num15 To numRods
					' The following expression was wrapped in a checked-statement
					RSWIN_DESC.rst.Sections(CInt(num7)).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
					RSWIN_DESC.rst.Sections(CInt(num7)).NumGuides = 0S
					RSWIN_DESC.rst.Sections(CInt(num7)).friction_coef = RSWIN_DESC.rst.RSFricCoef
					RSWIN_DESC.rst.Sections(CInt(num7)).Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
					Debug.WriteLine(Conversions.ToString(CInt(num7)) + " , " + Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num7)).length))
				Next
				Return
			End If
		End Sub

		Private Function ProcessInitialFGRodString() As Short
			Dim num As Integer
			Dim num2 As Short
			Dim num3 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim flag As Boolean
				Dim flag2 As Boolean
				Do
					flag = DESIGN.ProcessRodString(True)
					If Not flag Then
						Exit Do
					End If
					flag2 = False
					flag = PREDICT.Predict(True, "ProcessInitialFGRodString")
					If Not flag Then
						Exit Do
					End If
					flag = MWDown.StressAnalysis()
					If Not flag Then
						Exit Do
					End If
					If rst.minStressBot(1) < 1000F And rst.FGPercent > 30F Then
						rst.FGPercent -= 5F
						If rst.FGPercent < 30F Then
							rst.FGPercent = 30F
						End If
						DESIGNFG.SetFGPercent(False)
						flag2 = True
					ElseIf CDbl(rst.StressL(1)) > CDbl(RSWIN_DESC.SETUP_MaxFGLoading) + 0.01 Or rst.StressL(1) >= 100F Or rst.StressL(1) < 0F Then
						flag2 = (DESIGNFG.BuildLargerFGString() <> 0S)
					End If
				Loop While flag2
				If(Not rst.SPMEntered And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					DESIGN.ProcessRodString(False)
					flag = PREDICT.Predict(True, "ProcessInitialFGRodString")
					If flag Then
						MWDown.StressAnalysis()
					End If
				End If
				num2 = If((-If((flag > False), 1S, 0S)), 1S, 0S)
				IL_124:
				GoTo IL_16B
				IL_126:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_13C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_126
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_16B:
			Dim result As Short = num2
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Sub SetFGPercent(bGetInitialFGPercent As Object)
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			If Conversions.ToBoolean(bGetInitialFGPercent) Then
				Dim num As Single
				If cRODSTAR.RSFGIncludeSteel <> 0S Then
					num = cRODSTAR.RSMaxSize
				Else
					num = cRODSTAR.SinkerBar.Diameter
				End If
				Dim num2 As Single = num
				If num2 >= 1.5F Then
					Dim fluidLoad As Single = cRODSTAR.FluidLoad
					If fluidLoad > 9000F Then
						cRODSTAR.FGPercent = 75F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 70F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 65F
						End If
					ElseIf fluidLoad > 7000F Then
						cRODSTAR.FGPercent = 80F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 75F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 70F
						End If
					ElseIf fluidLoad > 5000F Then
						cRODSTAR.FGPercent = 85F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 80F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 75F
						End If
					Else
						cRODSTAR.FGPercent = 90F
					End If
				ElseIf num2 >= 1.25F Then
					Dim fluidLoad2 As Single = cRODSTAR.FluidLoad
					If fluidLoad2 > 9000F Then
						cRODSTAR.FGPercent = 70F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 65F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 55F
						End If
					ElseIf fluidLoad2 > 7000F Then
						cRODSTAR.FGPercent = 75F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 70F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 65F
						End If
					ElseIf fluidLoad2 > 5000F Then
						cRODSTAR.FGPercent = 80F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 75F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 70F
						End If
					Else
						cRODSTAR.FGPercent = 85F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 80F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 75F
						End If
					End If
				ElseIf num2 >= 1.125F Then
					Dim fluidLoad3 As Single = cRODSTAR.FluidLoad
					If fluidLoad3 > 9000F Then
						cRODSTAR.FGPercent = 60F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 55F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 50F
						End If
					ElseIf fluidLoad3 > 7000F Then
						cRODSTAR.FGPercent = 65F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 60F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 55F
						End If
					ElseIf fluidLoad3 > 5000F Then
						cRODSTAR.FGPercent = 75F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 70F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 65F
						End If
					Else
						cRODSTAR.FGPercent = 80F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 75F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 70F
						End If
					End If
				ElseIf num2 >= 1F Then
					Dim fluidLoad4 As Single = cRODSTAR.FluidLoad
					If fluidLoad4 > 9000F Then
						cRODSTAR.FGPercent = 50F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 45F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 40F
						End If
					ElseIf fluidLoad4 > 7000F Then
						cRODSTAR.FGPercent = 60F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 50F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 45F
						End If
					ElseIf fluidLoad4 > 5000F Then
						cRODSTAR.FGPercent = 70F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 60F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 50F
						End If
					Else
						cRODSTAR.FGPercent = 75F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 65F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 55F
						End If
					End If
				ElseIf num2 >= 0.875F Then
					Dim fluidLoad5 As Single = cRODSTAR.FluidLoad
					If fluidLoad5 > 9000F Then
						cRODSTAR.FGPercent = 40F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 35F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 30F
						End If
					ElseIf fluidLoad5 > 7000F Then
						cRODSTAR.FGPercent = 45F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 40F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 35F
						End If
					ElseIf fluidLoad5 > 5000F Then
						cRODSTAR.FGPercent = 55F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 50F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 45F
						End If
					Else
						cRODSTAR.FGPercent = 60F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 55F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 50F
						End If
					End If
				Else
					Dim fluidLoad6 As Single = cRODSTAR.FluidLoad
					If fluidLoad6 > 9000F Then
						cRODSTAR.FGPercent = 30F
					ElseIf fluidLoad6 > 7000F Then
						cRODSTAR.FGPercent = 40F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 35F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 30F
						End If
					ElseIf fluidLoad6 > 5000F Then
						cRODSTAR.FGPercent = 45F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 40F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 35F
						End If
					Else
						cRODSTAR.FGPercent = 50F
						If cRODSTAR.PumpDepth < 8750F Then
							cRODSTAR.FGPercent = 45F
						End If
						If cRODSTAR.PumpDepth < 6250F Then
							cRODSTAR.FGPercent = 40F
						End If
					End If
				End If
			End If
			If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.rst.RSIncludeSB And If((-If((RSWIN_DESC.bSinkerBarDepthChanged > False), 1S, 0S)), 1S, 0S) And If((-If((RSWIN_DESC.fNewTaperLength > 0F > False), 1S, 0S)), 1S, 0S) And Not cRODSTAR.RSFGIncludeSteel) <> 0S Then
				Dim num3 As Single = (RSWIN_DESC.fNewSinkerbarDepth - RSWIN_DESC.rst.SinkerBar.length) / cRODSTAR.PumpDepth * 100F
				If cRODSTAR.FGPercent > num3 Then
					cRODSTAR.FGPercent = num3
				End If
			End If
			cRODSTAR.Sections(1).length = cRODSTAR.PumpDepth * cRODSTAR.FGPercent / 100F
			DESIGNFG.MakeSteelString(2, cRODSTAR.PumpDepth - cRODSTAR.Sections(1).length, True)
			Try
				Debug.WriteLine(" - ")
				Debug.WriteLine("Taper , Grade, Length, Diameter ")
				Dim num4 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num4 To numRods
					Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
					Dim num5 As Integer = i
					Debug.WriteLine(String.Concat(New String() { Conversions.ToString(i), " , ", RODUTIL.RodGrade(sections(num5).Grade), " , ", Conversions.ToString(sections(num5).length), " , ", Conversions.ToString(sections(num5).Diameter), " , " }))
				Next
				Debug.WriteLine(" - ")
			Catch ex As Exception
			End Try
			If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.rst.RSIncludeSB And If((-If((RSWIN_DESC.bSinkerBarDepthChanged > False), 1S, 0S)), 1S, 0S) And If((-If((RSWIN_DESC.fNewTaperLength > 0F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				If(cRODSTAR.RSFGIncludeSteel And cRODSTAR.RSIncludeSB) <> 0S Then
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					RODUTIL.RoundSectionLengths(1S, cRODSTAR.NumRods - 2S, cRODSTAR.PumpDepth - cRODSTAR.Sections(CInt((cRODSTAR.NumRods - 1S))).length - RSWIN_DESC.fNewTaperLength)
				ElseIf(cRODSTAR.RSIncludeSB And Not cRODSTAR.RSFGIncludeSteel) <> 0S Then
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					RODUTIL.RoundSectionLengths(1S, cRODSTAR.NumRods - 2S, cRODSTAR.PumpDepth - cRODSTAR.Sections(CInt((cRODSTAR.NumRods - 1S))).length - cRODSTAR.Sections(CInt(cRODSTAR.NumRods)).length)
				Else
					RODUTIL.RoundSectionLengths(1S, cRODSTAR.NumRods, cRODSTAR.PumpDepth)
				End If
			ElseIf(cRODSTAR.RSFGIncludeSteel And cRODSTAR.RSIncludeSB) <> 0S Then
				' The following expression was wrapped in a checked-expression
				RODUTIL.RoundSectionLengths(1S, cRODSTAR.NumRods - 1S, cRODSTAR.PumpDepth - cRODSTAR.Sections(CInt(cRODSTAR.NumRods)).length)
			Else
				RODUTIL.RoundSectionLengths(1S, cRODSTAR.NumRods, cRODSTAR.PumpDepth)
			End If
			cRODSTAR = Nothing
		End Sub

		Private Function UseSmallerPlunger() As Short
			Dim array As Object() = New Object(0) {}
			Dim sMenu As String = "PLUNGER-SIZE-LIST"
			Dim array2 As String() = CType(array, String())
			Dim num As Short
			Util.LoadMenu(sMenu, num, array2)
			array = array2
			Dim array3 As Single() = New Single(CInt((num + 1S)) - 1) {}
			Dim num2 As Integer = 0
			Dim num3 As Short = 1S
			Dim num4 As Short = num
			For num5 As Short = num3 To num4
				' The following expression was wrapped in a checked-statement
				If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(array(CInt(num5)))) Then
					num2 += 1
					array3(num2) = CSng(Conversion.Val(RuntimeHelpers.GetObjectValue(array(num2))))
					If array3(num2) = 0F Then
						num2 -= 1
						Exit For
					End If
				End If
			Next
			num = CShort(num2)
			Array.Clear(array, 0, array.Length)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim tubingOD As Single = rst.TubingOD
			Dim num6 As Single
			If tubingOD = 1.9F Then
				num6 = 1.0625F
			ElseIf tubingOD = 1.9F Then
				num6 = 1.0625F
			ElseIf tubingOD = 2.375F Then
				num6 = 1.125F
			Else
				num6 = 1.25F
			End If
			Dim result As Short = 0S
			If rst.PlungerSize > num6 Then
				' The following expression was wrapped in a checked-expression
				For num5 As Short = num - 1S To 1S Step -1S
					If rst.PlungerSize > array3(CInt(num5)) Then
						rst.PlungerSize = array3(CInt(num5))
						result = -1S
						rst.Apump = CSng((3.141592653589793 * Math.Pow(CDbl(rst.PlungerSize), 2.0) / 4.0))
						rst.FluidLoad = CSng(((0.433 * CDbl((rst.FluidSPGR * rst.PumpDepth - rst.OilSPGR * rst.FeetOverPump)) + CDbl(rst.TubingPressure) - CDbl(rst.CasingPressure)) * CDbl(rst.Apump)))
						Exit For
					End If
				Next
			End If
			Return result
		End Function

		Private Function BuildLargerFGString() As Short
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Short
			If rst.LargestFG > 0F And rst.Sections(1).Diameter >= rst.LargestFG Then
				num = 0S
			Else
				num = -1S
				Dim rsfggrade As Short = rst.RSFGGrade
				If rsfggrade = 20481S OrElse rsfggrade = 16393S Then
					num = 0S
				ElseIf rsfggrade = 16385S OrElse rsfggrade = 16389S OrElse rsfggrade = 16390S Then
					Dim diameter As Single = rst.Sections(1).Diameter
					If diameter = 0.74F Then
						rst.Sections(1).Diameter = 0.865F
					ElseIf diameter = 0.865F Then
						rst.Sections(1).Diameter = 0.99F
					ElseIf diameter = 0.99F Then
						rst.Sections(1).Diameter = 1.24F
					ElseIf diameter = 1.24F Then
						rst.Sections(1).Diameter = 1.465F
					ElseIf diameter = 1.465F Then
						num = 0S
					End If
				ElseIf rsfggrade = 16386S Then
					Dim diameter2 As Single = rst.Sections(1).Diameter
					If diameter2 = 0.75F Then
						rst.Sections(1).Diameter = 0.87F
					ElseIf diameter2 = 0.87F Then
						rst.Sections(1).Diameter = 0.976F
					ElseIf diameter2 = 0.976F Then
						rst.Sections(1).Diameter = 1.25F
					ElseIf diameter2 = 1.25F Then
						num = 0S
					End If
				ElseIf rsfggrade = 16388S Then
					Dim diameter3 As Single = rst.Sections(1).Diameter
					If diameter3 = 0.75F Then
						rst.Sections(1).Diameter = 0.875F
					ElseIf diameter3 = 0.875F Then
						rst.Sections(1).Diameter = 1F
					ElseIf diameter3 = 1F Then
						rst.Sections(1).Diameter = 1.25F
					ElseIf diameter3 = 1.25F Then
						num = 0S
					End If
				ElseIf rsfggrade = 16387S Then
					Dim diameter4 As Single = rst.Sections(1).Diameter
					If diameter4 = 0.875F Then
						rst.Sections(1).Diameter = 1F
					ElseIf diameter4 = 1F Then
						rst.Sections(1).Diameter = 1.125F
					ElseIf diameter4 = 1.125F Then
						rst.Sections(1).Diameter = 1.25F
					ElseIf diameter4 = 1.25F Then
						num = 0S
					End If
				ElseIf rsfggrade = 16391S OrElse rsfggrade = 16395S Then
					Dim diameter5 As Single = rst.Sections(1).Diameter
					If diameter5 = 0.85F Then
						rst.Sections(1).Diameter = 0.98F
					ElseIf diameter5 = 0.98F Then
						rst.Sections(1).Diameter = 1.23F
					ElseIf diameter5 = 1.23F Then
						num = 0S
					End If
				ElseIf rsfggrade = 16394S OrElse rsfggrade = 16396S Then
					Dim diameter6 As Single = rst.Sections(1).Diameter
					If diameter6 = 1F Then
						rst.Sections(1).Diameter = 1.25F
					ElseIf diameter6 = 1.25F Then
						num = 0S
					End If
				ElseIf rsfggrade = 16393S Then
					rst.Sections(1).Diameter = 0.55F
				End If
			End If
			If num <> 0S Then
				rst.Sections(1).Area = CSng((3.141592653589793 * Math.Pow(CDbl(rst.Sections(1).Diameter), 2.0) / 4.0))
				RODUTIL.LookupRodWeight(rst.Sections(1))
				DESIGNFG.SetFGPercent(True)
			End If
			If RSWIN_DESC.bRodStarD Then
				Try
					If rst.Sections(1).Guide <= 0S Then
						rst.Sections(1).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
						rst.Sections(1).NumGuides = 0S
						rst.Sections(1).friction_coef = RSWIN_DESC.rst.RSFricCoef
						rst.Sections(1).Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
					End If
				Catch ex As Exception
				End Try
			End If
			Return num
		End Function

		Public Function CheckCorodDiam(diams As Single(), fDiameter As Single) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim num As Integer = Information.LBound(diams, 1)
				Dim num2 As Integer = Information.UBound(diams, 1)
				Dim num3 As Integer = num
				Dim num4 As Integer = num2
				For i As Integer = num3 To num4
					If diams(i) = fDiameter Then
						flag = True
					End If
				Next
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private diams As Single()

		Private Const fTol As Single = 0.005F

		Private m_RSMax As Short

		Private m_RSMin As Short
	End Module
End Namespace
