Imports System
Imports System.Collections
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module DESIGN
		Public Property fIncr As Single
			Get
				Return DESIGN.m_fIncr
			End Get
			Set(value As Single)
				DESIGN.m_fIncr = value
			End Set
		End Property

		Private Sub CalcInitialSPM()
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim unitType As Short = rst.PU.UnitType
				Dim kinematicStroke As Single = rst.PU.KinematicStroke
				Dim cRODSTAR As cRODSTAR = rst
				Dim maxSPM As Single = cRODSTAR.MaxSPM
				RUNCALC.MaxRecSPM(unitType, kinematicStroke, maxSPM)
				cRODSTAR.MaxSPM = maxSPM
				rst.SPM = CSng((0.85 * CDbl(rst.MaxSPM)))
				If rst.SPM > 10F Then
					rst.SPM = 10F
				End If
				IL_77:
				GoTo IL_BE
				IL_79:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_8F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_79
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_BE:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub CalcRodStringValues_Save()
			Dim num As Integer
			Dim num12 As Integer
			Dim obj2 As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.WrodsInFluid = CSng((CDbl((rst.PU.KinematicStroke / 12F)) * 1.3 * 5.2))
				rst.RodstringL = 0F
				Dim num2 As Double = 0.0
				Dim num3 As Double = 0.0
				Dim num4 As Short = 1S
				Dim numRods As Short = rst.NumRods
				For num5 As Short = num4 To numRods
					Dim num6 As Double
					If(If((-If((RODUTIL.IsCorod(rst.Sections(CInt(num5)).Grade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(rst.Sections(CInt(num5)).Grade))) <> 0 Then
						num6 = 1.0
					Else
						num6 = 1.07
					End If
					rst.WrodsInFluid = CSng((CDbl(rst.WrodsInFluid) + CDbl(rst.Sections(CInt(num5)).length) * (CDbl(rst.Sections(CInt(num5)).RodWeight) - num6 * (62.4 * CDbl(rst.FluidSPGR) * CDbl(rst.Sections(CInt(num5)).Area) / 144.0))))
					rst.RodstringL += rst.Sections(CInt(num5)).length
					num2 += CDbl((rst.Sections(CInt(num5)).length / (rst.Sections(CInt(num5)).Elasticity * rst.Sections(CInt(num5)).Area)))
					num3 += CDbl((rst.Sections(CInt(num5)).RodWeight * rst.Sections(CInt(num5)).length))
				Next
				rst.WrodsInFluid += 150F
				num2 = CDbl((12F / rst.RodstringL)) * num2
				num3 = CDbl((1F / rst.RodstringL)) * num3
				Dim num7 As Double = num2 * CDbl(rst.RodstringL)
				Dim num8 As Double = CDbl(rst.PU.KinematicStroke) / num7
				rst.FoSkr = CSng((CDbl(rst.FluidLoad) / num8))
				rst.No = CSng((CDbl((15F / rst.RodstringL)) * Math.Sqrt(386.4 / (num2 * num3))))
				If rst.gbSteelRodString Then
					Dim fcf As Object = 1
					Dim numRods2 As Short = rst.NumRods
					Dim cRODSTAR As cRODSTAR = rst
					Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
					Dim rodstringL As Single = rst.RodstringL
					Dim cRODSTAR2 As cRODSTAR = rst
					Dim obj As Object = cRODSTAR2.Fc
					APIROD.FcSteel(fcf, numRods2, sections, rodstringL, obj)
					cRODSTAR2.Fc = Conversions.ToSingle(obj)
					cRODSTAR.Sections = sections
				Else
					Dim num9 As Short = 1S
					Dim numRods3 As Short = rst.NumRods
					Dim num10 As Short
					For num5 As Short = num9 To numRods3
						If RODUTIL.IsFG(rst.Sections(CInt(num5)).Grade) Then
							num10 = num5
						End If
					Next
					Dim num11 As Double = CDbl((rst.Sections(CInt(num10)).length / rst.RodstringL))
					Dim cRODSTAR2 As cRODSTAR = rst
					Dim sections As RSWIN_DESC.RodSection() = cRODSTAR2.Sections
					Dim fgrod As Short = num10
					Dim percentFG As Object = num11
					Dim cRODSTAR As cRODSTAR = rst
					Dim obj As Object = cRODSTAR.Fc
					APIROD.FcFG(sections, fgrod, percentFG, obj)
					cRODSTAR.Fc = Conversions.ToSingle(obj)
					cRODSTAR2.Sections = sections
				End If
				rst.NoverNoP = rst.SPM / (rst.No * rst.Fc)
				IL_372:
				GoTo IL_3B9
				IL_374:
				num12 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_38A:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num12 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_374
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3B9:
			If num12 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub CalcRodStringValues()
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			cRODSTAR.WrodsInFluid = 0F
			cRODSTAR.RodstringL = 0F
			Dim num As Double = 0.0
			Dim num2 As Double = 0.0
			Dim num3 As Integer = 1
			Dim numRods As Integer = CInt(cRODSTAR.NumRods)
			Dim rodstringL As Single
			For i As Integer = num3 To numRods

					Try
						If RSWIN_DESC.rst.Sections(i).Elasticity = 0F Then
							RODUTIL.LookupElasticity(RSWIN_DESC.rst.Sections(i))
						End If
						If RSWIN_DESC.rst.Sections(i).Area = 0F Then
							RSWIN_DESC.rst.Sections(i).Area = CSng((3.141592653589793 * Math.Pow(CDbl(RSWIN_DESC.rst.Sections(i).Diameter), 2.0) / 4.0))
						End If
						Try
							RODUTIL.LookupRodWeight(RSWIN_DESC.rst.Sections(i))
						Catch ex As Exception
						End Try
						If RSWIN_DESC.rst.Sections(i).TensileStrength = 0F Then
							RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(i))
						End If
						If cRODSTAR.Sections(i).RodDensity = 0F Then
							If cRODSTAR.Sections(i).Grade = 20481S Then
								cRODSTAR.Sections(i).RodDensity = 100F
							ElseIf cRODSTAR.Sections(i).Grade = 16393S Then
								cRODSTAR.Sections(i).RodDensity = 125F
							ElseIf RODUTIL.IsFG(cRODSTAR.Sections(i).Grade) Then
								cRODSTAR.Sections(i).RodDensity = 130F
							Else
								cRODSTAR.Sections(i).RodDensity = 491F
							End If
						End If
					Catch ex2 As Exception
					End Try
					Dim num4 As Double
					If(If((-If((RODUTIL.IsCorod(cRODSTAR.Sections(i).Grade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(cRODSTAR.Sections(i).Grade))) <> 0 Then
						num4 = 1.0
					Else
						num4 = 1.07
					End If
					cRODSTAR.WrodsInFluid = CSng((CDbl(cRODSTAR.WrodsInFluid) + CDbl(cRODSTAR.Sections(i).length) * (CDbl(cRODSTAR.Sections(i).RodWeight) - num4 * (62.4 * CDbl(cRODSTAR.FluidSPGR) * CDbl(cRODSTAR.Sections(i).Area) / 144.0))))
					cRODSTAR.RodstringL += cRODSTAR.Sections(i).length
					num += CDbl((cRODSTAR.Sections(i).length / (cRODSTAR.Sections(i).Elasticity * cRODSTAR.Sections(i).Area)))
					num2 += CDbl((cRODSTAR.Sections(i).RodWeight * cRODSTAR.Sections(i).length))

				If RSWIN_DESC.rst.RodStringType = 3S Then
					If RSWIN_DESC.bRodStarD Then
						RSWIN_DESC.rst.Sections(i).Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
						If RSWIN_DESC.rst.Sections(i).friction_coef = 0F Then
							RSWIN_DESC.rst.Sections(i).friction_coef = RODUTIL.GetFricCoeff(RSWIN_DESC.rst.RSRodGuide, True)
						End If
					ElseIf RSWIN_DESC.rst.RSFricCoef = 0F Then
						cRODSTAR.Sections(i).friction_coef = 0.2F
					Else
						cRODSTAR.Sections(i).friction_coef = RSWIN_DESC.rst.RSFricCoef
					End If
				End If
			Next
			rodstringL = cRODSTAR.RodstringL
			Dim num5 As Single = cRODSTAR.PumpDepth - rodstringL
			If num5 > 0F Then
				Dim num6 As Single = CSng((0.5 * CDbl(num5)))
				Dim num7 As Single = CSng((0.5 * CDbl(num5)))
				Dim num8 As Single = CSng((5.2 * CDbl(num6)))
				Dim num9 As Single = 2F * num7
				cRODSTAR.WrodsInFluid = cRODSTAR.WrodsInFluid + num8 + num9
			End If
			num = CDbl((12F / cRODSTAR.RodstringL)) * num
			num2 = CDbl((1F / cRODSTAR.RodstringL)) * num2
			Dim num10 As Double = num * CDbl(cRODSTAR.RodstringL)
			Dim num11 As Double = CDbl(cRODSTAR.PU.KinematicStroke) / num10
			cRODSTAR.FoSkr = CSng((CDbl(cRODSTAR.FluidLoad) / num11))
			cRODSTAR.No = CSng((CDbl((15F / cRODSTAR.RodstringL)) * Math.Sqrt(386.4 / (num * num2))))
			If cRODSTAR.gbSteelRodString Then
				Dim fcf As Object = 1
				Dim numRods2 As Short = cRODSTAR.NumRods
				Dim cRODSTAR2 As cRODSTAR = cRODSTAR
				Dim sections As RSWIN_DESC.RodSection() = cRODSTAR2.Sections
				Dim rodstringL2 As Single = cRODSTAR.RodstringL
				Dim cRODSTAR3 As cRODSTAR = cRODSTAR
				Dim obj As Object = cRODSTAR3.Fc
				APIROD.FcSteel(fcf, numRods2, sections, rodstringL2, obj)
				cRODSTAR3.Fc = Conversions.ToSingle(obj)
				cRODSTAR2.Sections = sections
			Else
				Dim num12 As Integer = 1
				Dim numRods3 As Integer = CInt(cRODSTAR.NumRods)
				Dim num13 As Integer
				For i As Integer = num12 To numRods3
					If RODUTIL.IsFG(cRODSTAR.Sections(i).Grade) Then
						num13 = i
					End If
				Next
				Dim num14 As Double = CDbl((cRODSTAR.Sections(num13).length / cRODSTAR.RodstringL))
				Dim cRODSTAR3 As cRODSTAR = cRODSTAR
				Dim sections As RSWIN_DESC.RodSection() = cRODSTAR3.Sections
				Dim fgrod As Short = CShort(num13)
				Dim percentFG As Object = num14
				Dim cRODSTAR2 As cRODSTAR = cRODSTAR
				Dim obj As Object = cRODSTAR2.Fc
				APIROD.FcFG(sections, fgrod, percentFG, obj)
				cRODSTAR2.Fc = Conversions.ToSingle(obj)
				cRODSTAR3.Sections = sections
			End If
			cRODSTAR.NoverNoP = cRODSTAR.SPM / (cRODSTAR.No * cRODSTAR.Fc)
			cRODSTAR = Nothing
		End Sub

		Private Sub CalcSPM(bUseNominalSPM As Boolean)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If bUseNominalSPM Then
					rst.SPM = CSng((0.85 * CDbl(rst.MaxSPM)))
					If rst.SPM > 10F Then
						rst.SPM = 10F
					End If
				Else
					rst.SPM = CSng((CDbl(rst.TargetBFPD) / (0.1166 * CDbl(rst.PU.KinematicStroke) * Math.Pow(CDbl(rst.PlungerSize), 2.0) * CDbl(rst.Pfill)) * 24.0 / CDbl(rst.Runtime)))
					If rst.SPM > rst.MaxSPM Then
						rst.SPM = rst.MaxSPM
					End If
					rst.NoverNoP = rst.SPM / (rst.No * rst.Fc)
					Dim num2 As Short = 1S
					Do
						Dim num3 As Single = rst.PU.KinematicStroke * APIROD.SpOverS(rst.NoverNoP, rst.FoSkr, rst.PU.UnitType) - rst.TubStretch
						Dim num4 As Single = RUNCALC.BPDsurf(num3, rst.SPM, rst.PlungerSize, rst.Pfill) * rst.Runtime / 24F
						Dim num5 As Single = Math.Abs((num4 - rst.TargetBFPD) / rst.TargetBFPD) * 100F
						If num5 <= 4F Then
							Exit Do
						End If
						rst.SPM = CSng((CDbl(rst.TargetBFPD) / (0.1166 * CDbl(num3) * CDbl(rst.PlungerSize) * CDbl(rst.PlungerSize) * CDbl(rst.Pfill)) * 24.0 / CDbl(rst.Runtime)))
						If rst.SPM > rst.MaxSPM Then
							rst.SPM = rst.MaxSPM
						End If
						rst.NoverNoP = rst.SPM / (rst.No * rst.Fc)
						num2 += 1S
					Loop While num2 <= 6S
					DESIGN.lCount = 0S
				End If
				IL_21A:
				GoTo IL_261
				IL_21C:
				num6 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_232:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_21C
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_261:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub CalculatePumpIntakePressure()
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				RSWIN_DESC.rst.PumpIntakePressure = IPR.iprPipFromPwf(IPR.iprPwfFromFluidProduction(RSWIN_DESC.rst.TargetBFPD))
				IL_27:
				GoTo IL_6A
				IL_29:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_29
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6A:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function CheckProduction() As Boolean
			Dim result As Boolean = True
			Dim flag As Boolean = False
			Dim sMsg As String = ""
			Dim result2 As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num As Single
				If RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S Then
					num = 0.7F
				Else
					num = 1F
				End If
				DESIGN.lCount = 0S
				Dim num2 As Integer
				If RSWIN_DESC.bRodStarD Then
					DESIGN.fIncr = 1F
					num2 = 10
				Else
					DESIGN.fIncr = 0.1F
					num2 = 40
				End If
				If rst.SPMEntered = 0S Then
					Dim flag2 As Boolean = False
					While Not DESIGN.CheckSPM() = 0S
						Dim pumpPos As Single() = rst.PumpPos
						Dim num3 As Single = 0F
						Dim num4 As Single = 0F
						Dim num5 As Single
						Dim num6 As Single
						Util.Maxmin(pumpPos, num5, num6, num3, num4)
						rst.GrossPumpStroke = num5 - num6
						If(If((-If(((rst.BPDsurface = 0F Or Not RSWIN_DESC.bRodStarD) > False), 1S, 0S)), 1S, 0S) Or (If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.SETUP_UseImpred)) <> 0S Then
							Application.DoEvents()
							rst.BPDsurface = RUNCALC.BPDsurf(rst.GrossPumpStroke - rst.TubStretch, rst.SPM, rst.PlungerSize, rst.Pfill) * rst.Runtime / 24F
							If RSWIN_DESC.rst.PumpCondition = 2S Or RSWIN_DESC.rst.PumpCondition = 3S Then
								rst.BPDsurface = rst.BPDsurface * rst.PumpEfficiency / 100F
							End If
						End If
						If Not(rst.BPDsurface / rst.TargetBFPD >= 1F And CDbl((rst.BPDsurface / rst.TargetBFPD)) <= 1.02) Then
							Dim spm As Single
							If Not flag Then
								spm = rst.SPM
								rst.SPM = CSng((CDbl(rst.TargetBFPD) / (0.1166 * CDbl(rst.GrossPumpStroke) * CDbl(rst.PlungerSize) * CDbl(rst.PlungerSize) * CDbl(rst.Pfill)) * 24.0 / CDbl(rst.Runtime)))
								flag = True
							End If
							If rst.SPM > rst.MaxSPM Then
								spm = rst.SPM
								rst.SPM = rst.MaxSPM
							End If
							DESIGN.lCount += 1S
							If CInt(DESIGN.lCount) > num2 Then
								flag2 = True
							End If
							If flag2 Then
								rst.SPM = spm
							Else
								If rst.TargetBFPD > rst.BPDsurface Then
									If CDbl(Math.Abs(rst.SPM + DESIGN.fIncr - spm)) < 0.001 AndAlso CDbl(DESIGN.fIncr) > 0.1 Then
										DESIGN.fIncr /= 2F
									End If
									spm = rst.SPM
									rst.SPM += DESIGN.fIncr
								Else
									If CDbl(Math.Abs(rst.SPM - DESIGN.fIncr - spm)) < 0.001 AndAlso CDbl(DESIGN.fIncr) > 0.1 Then
										DESIGN.fIncr /= 2F
									End If
									spm = rst.SPM
									rst.SPM -= DESIGN.fIncr
								End If
								rst.NoverNoP = rst.SPM / (rst.No * rst.Fc)
							End If
							If rst.SPM < num Then
								rst.SPM = num
								result = False
								flag2 = True
								If rst.gbBatch Then
									Util.LoadMessage(276, sMsg)
									Batch.BatchMessage(sMsg)
								Else
									Util.cErrmsg(276)
								End If
							End If
							Application.DoEvents()
							Application.DoEvents()
							Application.DoEvents()
							Application.DoEvents()
							Application.DoEvents()
							If Not flag2 Then
								Continue While
							End If
						End If
						IL_3BA:
						rst.NoverNoP = rst.SPM / (rst.No * rst.Fc)
						Return result
					End While
					GoTo IL_3BA
				End If
			Catch ex As Exception
				MessageBox.Show("Error in CheckProduction: " + ex.Message)
				result2 = False
			End Try
			Return result2
		End Function

		Private Function CheckSPM() As Short
			Dim result As Short
			Try
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				Dim num As Short = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num2 As Single
				If rst.PumpDepth < 2000F Then
					num2 = 50F
				Else
					num2 = 100F
				End If
				result = -1S
				Dim flag As Boolean
				While True
					Dim num3 As Short = -1S
					flag = PREDICT.Predict(True, "CheckSPM")
					If RSWIN_DESC.bRodStarD AndAlso RSWIN_DESC.bAbortRun Then
						Exit For
					End If
					If Not flag Then
						GoTo IL_1DC
					End If
					If(RSWIN_DESC.bRodStarD And RSWIN_DESC.bDoNegativeStressCheck) AndAlso DESIGN.CheckForNegativeStresses() Then
						flag = PREDICT.Predict(True, "CheckSPM")
					End If
					If rst.Mprload <= num2 Then
						result = 0S
						If rst.Mprload < -2500F Then
							rst.SPM = CSng((CDbl(rst.SPM) * 0.8))
						ElseIf rst.Mprload < -1500F Then
							rst.SPM = CSng((CDbl(rst.SPM) * 0.9))
						Else
							rst.SPM = CSng((CDbl(rst.SPM) * 0.95))
						End If
						num3 = 0S
					End If
					If(num3 And If((-If(((rst.RodStringType = 3S) > False), 1S, 0S)), 1S, 0S) And If((-If(((rst.giRodDesignStyle <> 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						flag = MWDown.StressAnalysis()
						If rst.giRodDesignStyle <> 0S And rst.minStressBot(1) < -1000F Then
							rst.SPM = CSng((CDbl(rst.SPM) * 0.8))
							num3 = 0S
						ElseIf rst.giRodDesignStyle <> 0S And rst.minStressBot(1) < 200F Then
							rst.SPM = CSng((CDbl(rst.SPM) * 0.95))
							num3 = 0S
						End If
					End If
					If Not num3 <> 0S Then
						MImpred.ImpredObj = Nothing
					End If
					Application.DoEvents()
					Application.DoEvents()
					If num3 <> 0S Then
						GoTo IL_1DC
					End If
				End While
				flag = False
				IL_1DC:
				result = If((-If((flag > False), 1S, 0S)), 1S, 0S)
			Catch ex As Exception
				MessageBox.Show("Error in CheckSPM: " + ex.Message)
			End Try
			Return result
		End Function

		Public Function Design() As Boolean
			Dim gbIncludeBuoyancy As Boolean = RSWIN_DESC.rst.gbIncludeBuoyancy
			Dim flag As Boolean = True
			RSWIN_DESC.bFGUnderTravel = False
			RSWIN_DESC.bSinkerBarDepthChanged = False
			RSWIN_DESC.fNewSinkerbarDepth = 0F
			RSWIN_DESC.fNewTaperLength = 0F
			Dim result As Boolean
			Try
				Dim num As Short = 0S
				Do
					DESIGN.SSResults(CInt(num)) = 1S
					num += 1S
				Loop While num <= 9S
				num = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
				SUPERPRO.NewCheckSentinel(True)
				If RSWIN_DESC.rst.gbCalcFluidSPGR Then
					Util.CheckFluidSPGR()
					If RSWIN_DESC.rst.FluidSPGR = 0F Then
						RSWIN_DESC.rst.FluidSPGR = RSWIN_DESC.rst.gfMaxFluidSPGR
					End If
				End If
				Dim flag2 As Boolean = DESIGN.CheckSanity()
				If flag2 Then
					flag2 = Verify.VerifyInputDataConsistency()
				End If
				If flag2 Then
					RSWIN_DESC.WarnedAboutBFPD = 0S
					RSWIN_DESC.WarnedAboutFoSkr = 0S
					RSWIN_DESC.WarnedAboutLowSPM = 0S
					RSWIN_DESC.WarnedAboutHighSPM = 0S
					RSWIN_DESC.WarnedAboutLargeNtsteps = 0S
					RSWIN_DESC.WarnedAboutLowPumpFillage = 0S
					RSWIN_DESC.WarnedAboutLowPumpEfficiency = 0S
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					If rst.gbUseIPR Then
						IPR.iprSetup()
					End If
					If Not rst.gbCalcPumpCondition Then
						flag2 = DESIGN.InitDesign()
						If Not flag2 Then
							Return flag2
						End If
						Select Case rst.RodStringType
							Case 1S, 2S, 4S
								flag2 = DESIGN.DesignUser()
								If flag2 And RSWIN_DESC.bRodStarD And RSWIN_DESC.bDoNegativeStressCheck Then
									If DESIGN.CheckForNegativeStresses() Then
										flag2 = DESIGN.DesignUser()
									End If
									GoTo IL_AB8
								End If
								GoTo IL_AB8
						End Select
						Select Case rst.giRodDesignStyle
							Case 0S
								If RSWIN_DESC.rst.RSIncludeSB <> 0S Then
									If RSWIN_DESC.rst.SinkerBar.RodDensity = 0F Or RSWIN_DESC.rst.SinkerBar.Elasticity = 0F Or RSWIN_DESC.rst.SinkerBar.RodWeight = 0F Or RSWIN_DESC.rst.SinkerBar.TensileStrength = 0F Then
										DESIGN.CheckSinkerBar()
									End If
									If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.Setup_bAlterSBPumpDepth And If((-If(((RODUTIL.IsSinkerBarGrade(rst.SinkerBar.Grade) Or CUSTOMRG.IsOtherSinkerBar(CInt(rst.SinkerBar.Grade))) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
										Dim length As Single = RSWIN_DESC.rst.SinkerBar.length
										RSWIN_DESC.fSBMaxLength = DESIGN.GetSBMaxLength(flag)
										If Not flag Then
											Dim num2 As Single
											RSWIN_DESC.fNewSinkerbarDepth = DESIGN.GetDepthFromInclination(length, num2, flag)
											If RSWIN_DESC.fNewSinkerbarDepth = RSWIN_DESC.rst.PumpDepth AndAlso flag Then
												RSWIN_DESC.bSinkerBarDepthChanged = False
											ElseIf RSWIN_DESC.fNewSinkerbarDepth <> RSWIN_DESC.rst.PumpDepth Then
												RSWIN_DESC.bSinkerBarDepthChanged = True
												RSWIN_DESC.fNewTaperLength = RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.fNewSinkerbarDepth
											Else
												RSWIN_DESC.bSinkerBarDepthChanged = False
												If Not RSWIN_DESC.rst.gbBatch Then
													MessageBox.Show(String.Format(DESIGN.sSinkerBarWarning, RSWIN_DESC.Setup_fInclinationLimit))
												Else
													Batch.BatchMessage(String.Format(DESIGN.sSinkerBarWarning, RSWIN_DESC.Setup_fInclinationLimit))
												End If
												RSWIN_DESC.rst.RSIncludeSB = 0S
											End If
										Else
											RSWIN_DESC.bSinkerBarDepthChanged = False
										End If
									Else
										RSWIN_DESC.bSinkerBarDepthChanged = False
									End If
								Else
									RSWIN_DESC.bSinkerBarDepthChanged = False
								End If
								If RSWIN_DESC.bRodStarD Then
									RSWIN_DESC.SETUP_UseImpred = -1S
									If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
										RSWIN_DESC.SETUP_RECOMMEND_GUIDES = True
										Dim text As String = "RecommendGuides"
										Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_RECOMMEND_GUIDES)
										RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
										RSWIN_DESC.SETUP_RECOMMEND_GUIDES = Conversions.ToBoolean(text2)
									End If
								Else
									RSWIN_DESC.SETUP_UseImpred = 0S
								End If
								If RSWIN_DESC.bDoExpertBuoyancyChange Then
									RSWIN_DESC.rst.gbIncludeBuoyancy = False
								End If
								flag2 = Conversions.ToBoolean(DESIGNST.DesignSteel())
								If(flag2 And RSWIN_DESC.bRodStarD And RSWIN_DESC.bDoNegativeStressCheck) AndAlso DESIGN.CheckForNegativeStresses() Then
									flag2 = Conversions.ToBoolean(DESIGNST.DesignSteel())
								End If
								If RSWIN_DESC.bDoExpertBuoyancyChange Then
									RSWIN_DESC.rst.gbIncludeBuoyancy = gbIncludeBuoyancy
								End If
								If(If((-If((RSWIN_DESC.bExpert > False), 1S, 0S)), 1S, 0S) And rst.RSIncludeSB And If((-If((RSWIN_DESC.bDesignSinkerbar > False), 1S, 0S)), 1S, 0S) And If((-If((RSWIN_DESC.rst.NumRods > 1S > False), 1S, 0S)), 1S, 0S) And If((-If((flag2 > False), 1S, 0S)), 1S, 0S)) <> 0S Then
									' The following expression was wrapped in a checked-statement
									If RSWIN.bIsSB(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) AndAlso (CDbl(RSWIN_DESC.rst.StressL(CInt(RSWIN_DESC.rst.NumRods))) >= 0.95 And (RSWIN_DESC.rst.SinkerBar.Grade >= 8193S And RSWIN_DESC.rst.SinkerBar.Grade <= 8196S)) Then
										Dim sinkerBar As RSWIN_DESC.RodSection
										sinkerBar.Initialize()
										sinkerBar = RSWIN_DESC.rst.SinkerBar
										sinkerBar.Grade += 4S
										RSWIN_DESC.rst.SinkerBar = sinkerBar
										If RSWIN_DESC.bDoExpertBuoyancyChange Then
											RSWIN_DESC.rst.gbIncludeBuoyancy = False
										End If
										flag2 = Conversions.ToBoolean(DESIGNST.DesignSteel())
										If RSWIN_DESC.bDoExpertBuoyancyChange Then
											RSWIN_DESC.rst.gbIncludeBuoyancy = gbIncludeBuoyancy
										End If
									End If
									Dim flag3 As Boolean = Conversions.ToBoolean(DESIGN.DesignSinkerbar("DesignSteel", False))
								End If
								If RSWIN_DESC.rst.gbIncludeBuoyancy Or (RSWIN_DESC.bRodStarD And RSWIN_DESC.bSinkerBarDepthChanged) Then
									flag2 = DESIGN.DesignUser()
									If(flag2 And RSWIN_DESC.bRodStarD And RSWIN_DESC.bDoNegativeStressCheck) AndAlso DESIGN.CheckForNegativeStresses() Then
										flag2 = DESIGN.DesignUser()
									End If
								End If
							Case 1S
								If RSWIN_DESC.rst.RSIncludeSB <> 0S Then
									If RSWIN_DESC.rst.SinkerBar.RodDensity = 0F Or RSWIN_DESC.rst.SinkerBar.Elasticity = 0F Or RSWIN_DESC.rst.SinkerBar.RodWeight = 0F Or RSWIN_DESC.rst.SinkerBar.TensileStrength = 0F Then
										DESIGN.CheckSinkerBar()
									End If
									If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.Setup_bAlterSBPumpDepth And If((-If(((RODUTIL.IsSinkerBarGrade(rst.SinkerBar.Grade) Or CUSTOMRG.IsOtherSinkerBar(CInt(rst.SinkerBar.Grade))) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
										Dim length As Single = RSWIN_DESC.rst.SinkerBar.length
										RSWIN_DESC.fSBMaxLength = DESIGN.GetSBMaxLength(flag)
										If Not flag Then
											Dim num2 As Single
											RSWIN_DESC.fNewSinkerbarDepth = DESIGN.GetDepthFromInclination(length, num2, flag)
											If RSWIN_DESC.fNewSinkerbarDepth = RSWIN_DESC.rst.PumpDepth AndAlso flag Then
												RSWIN_DESC.bSinkerBarDepthChanged = False
											ElseIf RSWIN_DESC.fNewSinkerbarDepth <> RSWIN_DESC.rst.PumpDepth Then
												RSWIN_DESC.bSinkerBarDepthChanged = True
												RSWIN_DESC.fNewTaperLength = RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.fNewSinkerbarDepth
											Else
												RSWIN_DESC.bSinkerBarDepthChanged = False
												If Not RSWIN_DESC.rst.gbBatch Then
													MessageBox.Show(DESIGN.sSinkerBarWarning)
												Else
													Batch.BatchMessage(DESIGN.sSinkerBarWarning)
												End If
												RSWIN_DESC.rst.RSIncludeSB = 0S
											End If
										Else
											RSWIN_DESC.bSinkerBarDepthChanged = True
										End If
									Else
										RSWIN_DESC.bSinkerBarDepthChanged = False
									End If
								Else
									RSWIN_DESC.bSinkerBarDepthChanged = False
								End If
								If RSWIN_DESC.bDoExpertBuoyancyChange Then
									RSWIN_DESC.rst.gbIncludeBuoyancy = True
								End If
								If RSWIN_DESC.bRodStarD AndAlso Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
									RSWIN_DESC.SETUP_RECOMMEND_GUIDES = True
									Dim text2 As String = "RecommendGuides"
									Dim text As String = Conversions.ToString(RSWIN_DESC.SETUP_RECOMMEND_GUIDES)
									RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
									RSWIN_DESC.SETUP_RECOMMEND_GUIDES = Conversions.ToBoolean(text)
								End If
								flag2 = DESIGNFG.DesignFG()
								If(flag2 And RSWIN_DESC.bRodStarD And RSWIN_DESC.bDoNegativeStressCheck) AndAlso DESIGN.CheckForNegativeStresses() Then
									flag2 = DESIGNFG.DesignFG()
								End If
								If RSWIN_DESC.bDoExpertBuoyancyChange Then
									RSWIN_DESC.rst.gbIncludeBuoyancy = gbIncludeBuoyancy
								End If
								If(If((-If((RSWIN_DESC.bExpert > False), 1S, 0S)), 1S, 0S) And rst.RSIncludeSB And If((-If((RSWIN_DESC.bDesignSinkerbar > False), 1S, 0S)), 1S, 0S) And If((-If((RSWIN_DESC.rst.NumRods > 1S > False), 1S, 0S)), 1S, 0S) And If((-If((flag2 > False), 1S, 0S)), 1S, 0S)) <> 0S Then
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									If Not RSWIN_DESC.rst.RSFGIncludeSteel <> 0S Then
										Dim flag3 As Boolean = Conversions.ToBoolean(DESIGN.DesignSinkerbar("DesignFG", True))
									ElseIf RSWIN_DESC.rst.NumRods > 2S AndAlso (RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) Or If((-If((CUSTOMRG.IsOtherSteel(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) > False), 1, 0)), 1, 0)) <> 0 Then
										Dim flag3 As Boolean = Conversions.ToBoolean(DESIGN.DesignSinkerbar("DesignFG", False))
									End If
								End If
								If Not RSWIN_DESC.rst.gbIncludeBuoyancy Or (RSWIN_DESC.bRodStarD And RSWIN_DESC.bSinkerBarDepthChanged) Then
									flag2 = DESIGN.DesignUser()
									If(flag2 And RSWIN_DESC.bRodStarD And RSWIN_DESC.bDoNegativeStressCheck) AndAlso DESIGN.CheckForNegativeStresses() Then
										flag2 = DESIGN.DesignUser()
									End If
								End If
						End Select
					Else
						If Not rst.gbUseIPR Then
							Util.Errmsg(DESIGN.sIPRMust)
							flag2 = False
							If Not flag2 Then
								If RSWIN_DESC.bDoExpertBuoyancyChange Then
									RSWIN_DESC.rst.gbIncludeBuoyancy = gbIncludeBuoyancy
								End If
								Return flag2
							End If
						End If
						Dim num3 As Single = CSng((CDbl(rst.CasingPressure) + 14.7))
						rst.BPDsurface = -1F
						rst.PumpCondition = 1S
						Dim num4 As Single = IPR.iprPwfFromPip(num3)
						Dim num5 As Single = IPR.iprProductionFromPwf(num4) + (rst.StaticBHPressure - num4) * rst.WaterPI
						While True
							Dim bpdsurface As Single = rst.BPDsurface
							rst.PumpIntakePressure = num3
							flag2 = DESIGN.InitDesign()
							If Not flag2 Then
								Exit For
							End If
							Select Case rst.RodStringType
								Case 1S, 2S, 4S
									flag2 = DESIGN.DesignUser()
									If Not flag2 Then
										GoTo Block_61
									End If
								Case 3S
									GoTo IL_977
								Case Else
									GoTo IL_977
							End Select
							IL_9EA:
							If rst.PumpCondition = 2S Then
								GoTo Block_67
							End If
							If rst.BPDsurface > num5 Then
								rst.PumpCondition = 2S
								rst.PumpFillage = num5 / rst.BPDsurface * 100F
								num3 = CSng((CDbl(rst.CasingPressure) + 14.7))
							Else
								Dim num7 As Single
								Dim num6 As Single = num7
								num7 = num3
								num4 = IPR.iprPwfFromFluidProduction(rst.BPDsurface)
								num3 = IPR.iprPipFromPwf(num4)
								If num3 = num6 Then
									Exit For
								End If
								If Math.Abs(rst.PumpIntakePressure - num3) <= 5F And (bpdsurface >= 0F And CDbl((Math.Abs(rst.BPDsurface - bpdsurface) / bpdsurface)) < 0.01) Then
									Exit For
								End If
							End If
							Continue For
							IL_977:
							Select Case rst.giRodDesignStyle
								Case 0S
									If RSWIN_DESC.bDoExpertBuoyancyChange Then
										RSWIN_DESC.rst.gbIncludeBuoyancy = False
									End If
									flag2 = Conversions.ToBoolean(DESIGNST.DesignSteel())
									If RSWIN_DESC.bDoExpertBuoyancyChange Then
										RSWIN_DESC.rst.gbIncludeBuoyancy = gbIncludeBuoyancy
										GoTo IL_9EA
									End If
									GoTo IL_9EA
								Case 1S
									If RSWIN_DESC.bDoExpertBuoyancyChange Then
										RSWIN_DESC.rst.gbIncludeBuoyancy = True
									End If
									flag2 = DESIGNFG.DesignFG()
									If RSWIN_DESC.bDoExpertBuoyancyChange Then
										RSWIN_DESC.rst.gbIncludeBuoyancy = gbIncludeBuoyancy
										GoTo IL_9EA
									End If
									GoTo IL_9EA
								Case Else
									GoTo IL_9EA
							End Select
						End While
						GoTo IL_AB8
						Block_61:
						Return flag2
						Block_67:
						rst.BPDsurface = num5
					End If
					IL_AB8:
					If Not flag2 Then
						If RSWIN_DESC.bDoExpertBuoyancyChange Then
							RSWIN_DESC.rst.gbIncludeBuoyancy = gbIncludeBuoyancy
						End If
						Return flag2
					End If
					Dim text3 As String
					If DESIGN.bFGStringOverloaded <> 0S Then
						If rst.RodStringType = 3S Then
							Util.LoadMessage(197, text3)
						Else
							Util.LoadMessage(198, text3)
						End If
						Dim msg As String = text3 + vbLf & vbLf & "Continue?"
						Dim bDefaultYes As Boolean = True
						Dim flag4 As Boolean = False
						If Not Util.YesNo(msg, bDefaultYes, flag4) Then
							flag2 = False
							If RSWIN_DESC.bDoExpertBuoyancyChange Then
								RSWIN_DESC.rst.gbIncludeBuoyancy = gbIncludeBuoyancy
							End If
							Return flag2
						End If
					End If
					If Not rst.SPMEntered <> 0S AndAlso CDbl((rst.BPDsurface / rst.TargetBFPD)) < 0.965 Then
						If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bOneGuruFile And Not DESIGN.$STATIC$Design$002$bProductionMessageShown Then
							Util.LoadMessage(77, text3)
							text3 = Util.AssignValueToConstant("ErrorMessages", 77.ToString().Trim(), text3)
							MessageBox.Show(text3)
							DESIGN.$STATIC$Design$002$bProductionMessageShown = True
						Else
							Util.cErrmsg(77)
						End If
					End If
					num = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
					Application.DoEvents()
					Application.DoEvents()
					flag2 = DESIGN.SurfCalc(True)
					Application.DoEvents()
					Application.DoEvents()
					If Not flag2 Then
						Return False
					End If
					Verify.VerifyResults()
					If RSWIN_DESC.DEBUG_CreateDYN <> 0S Then
						Dim title As String = RSWIN.App.Title
						RSWIN.App.Title = title + " DEMO"
						kinemat.Kinconst(rst.PU)
						Dim cRODSTAR As cRODSTAR = rst
						Dim pu As RSWIN_DESC.PUDataRec = cRODSTAR.PU
						kinemat.Unitstroke(pu)
						cRODSTAR.PU = pu
						RSWIN.App.Title = title
						Dim str As String
						Dim num8 As Short
						Dim num9 As Short
						Dim num10 As Short
						str = Strings.Left(RSWIN_DESC.Inputfile, Strings.Len(RSWIN_DESC.Inputfile) - 3)
						num8 = 0S
						num9 = 1S
						num10 = rst.Ntsteps - 1S
						num = num9
						While num <= num10
							' The following expression was wrapped in a checked-statement
							If rst.SurfPos(CInt((num + 1S))) < rst.SurfPos(CInt((num8 + 1S))) Then
								num8 = num - 1S
							End If
							num += 1S
						End While
						Dim num11 As Short
						If(RSWIN_DESC.DEBUG_CreateDYN And 1S) <> 0S Then
							Dim num12 As Short
							Dim num13 As Short
							num11 = CShort(FileSystem.FreeFile())
							FileSystem.FileOpen(CInt(num11), str + "DYN", OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite, -1)
							FileSystem.WriteLine(CInt(num11), New Object() { rst.Ntsteps })
							num12 = 0S
							num13 = rst.Ntsteps - 1S
							num = num12
							While num <= num13
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a unchecked-expression
								FileSystem.WriteLine(CInt(num11), New Object() { rst.SurfPos(CInt((num8 + num Mod rst.Ntsteps + 1S))), rst.SurfLoad(CInt((num8 + num Mod rst.Ntsteps + 1S))) })
								num += 1S
							End While
							num = 0S
							FileSystem.WriteLine(CInt(num11), New Object() { num })
							FileSystem.WriteLine(CInt(num11), New Object() { rst.SPM })
							Dim fileNumber As Integer = CInt(num11)
							Dim array As Object() = New Object(0) {}
							Dim array2 As Object() = array
							Dim num14 As Integer = 0
							pu = rst.PU
							array2(num14) = pu.KinematicStroke
							FileSystem.WriteLine(fileNumber, array)
							FileSystem.WriteLine(CInt(num11), New Object() { num })
							FileSystem.WriteLine(CInt(num11), New Object() { num })
							FileSystem.WriteLine(CInt(num11), New Object() { num })
							FileSystem.FileClose(New Integer() { CInt(num11) })
						End If
						If(RSWIN_DESC.DEBUG_CreateDYN And 2S) <> 0S Then
							FileSystem.FileOpen(CInt(num11), str + "TF", OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite, -1)
							FileSystem.WriteLine(CInt(num11), New Object() { rst.Ntsteps })
							Dim num15 As Short = 0S
							Dim num16 As Short = rst.Ntsteps - 1S
							num = num15
							While num <= num16
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a unchecked-expression
								FileSystem.WriteLine(CInt(num11), New Object() { rst.SurfPos(CInt((num8 + num Mod rst.Ntsteps + 1S))), rst.Thetac(CInt((num8 + num Mod rst.Ntsteps + 1S))), rst.Tf(CInt((num8 + num Mod rst.Ntsteps + 1S))) })
								num += 1S
							End While
							Dim num17 As Double = CDbl(kinemat.ThetaFromPrp(0F, False))
							Dim theta As Double = num17
							Dim num18 As Double = 0.0
							Dim num19 As Double = 0.0
							Dim num20 As Double = 0.0
							Dim num21 As Double
							kinemat.Kinematics(theta, num18, num19, num21, num20, -1, 0F)
							FileSystem.WriteLine(CInt(num11), New Object() { 0, num17, num21 })
							pu = rst.PU
							num17 = CDbl(kinemat.ThetaFromPrp(pu.KinematicStroke, True))
							Dim theta2 As Double = num17
							num20 = 0.0
							num19 = 0.0
							num18 = 0.0
							kinemat.Kinematics(theta2, num20, num19, num21, num18, -1, 0F)
							Dim fileNumber2 As Integer = CInt(num11)
							Dim array As Object() = New Object(2) {}
							Dim array3 As Object() = array
							Dim num22 As Integer = 0
							pu = rst.PU
							array3(num22) = pu.KinematicStroke
							array(1) = num17
							array(2) = num21
							FileSystem.WriteLine(fileNumber2, array)
							FileSystem.FileClose(New Integer() { CInt(num11) })
						End If
						If(RSWIN_DESC.DEBUG_CreateDYN And 4S) <> 0S Then
							Dim num23 As Short
							Dim num24 As Short
							num11 = CShort(FileSystem.FreeFile())
							FileSystem.FileOpen(CInt(num11), str + "TQ", OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite, -1)
							FileSystem.WriteLine(CInt(num11), New Object() { rst.Ntsteps })
							num23 = 0S
							num24 = rst.Ntsteps - 1S
							num = num23
							While num <= num24
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a unchecked-expression
								FileSystem.WriteLine(CInt(num11), New Object() { rst.SurfPos(CInt((num8 + num Mod rst.Ntsteps + 1S))), rst.Tnet(2, CInt((num8 + num Mod rst.Ntsteps + 1S))), RSWIN_DESC.PermLoad(CInt((num8 + num Mod rst.Ntsteps + 1S))) })
								num += 1S
							End While
							FileSystem.FileClose(New Integer() { CInt(num11) })
						End If
						If(RSWIN_DESC.DEBUG_CreateDYN And 8S) <> 0S Then
							num8 = 0S
							Dim num25 As Short = 1S
							Dim num26 As Short = rst.Ntsteps - 1S
							num = num25
							While num <= num26
								' The following expression was wrapped in a checked-statement
								If rst.PumpPos(CInt((num + 1S))) < rst.PumpPos(CInt((num8 + 1S))) Then
									num8 = num - 1S
								End If
								num += 1S
							End While
							Dim num27 As Short
							Dim num28 As Short
							num11 = CShort(FileSystem.FreeFile())
							FileSystem.FileOpen(CInt(num11), str + "DPC", OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite, -1)
							FileSystem.WriteLine(CInt(num11), New Object() { rst.Ntsteps })
							num27 = 0S
							num28 = rst.Ntsteps - 1S
							num = num27
							While num <= num28
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a unchecked-expression
								FileSystem.WriteLine(CInt(num11), New Object() { rst.PumpPos(CInt((num8 + num Mod rst.Ntsteps + 1S))), rst.PumpLoad(CInt((num8 + num Mod rst.Ntsteps + 1S))) })
								num += 1S
							End While
							FileSystem.FileClose(New Integer() { CInt(num11) })
						End If
					End If
				End If
				If RSWIN_DESC.bDoExpertBuoyancyChange Then
					RSWIN_DESC.rst.gbIncludeBuoyancy = gbIncludeBuoyancy
				End If
				SUPERPRO.NewCheckSentinel(True)
				result = flag2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function DesignUser() As Boolean
			Dim num As Integer
			Dim flag2 As Boolean
			Dim num7 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim i As Integer = CInt(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
				If rst.RodStringType = 1S Then
					RODUTIL.MakeAPIString(rst.PumpDepth, rst.APIRod, rst.APIGrade, rst.APIRodType)
				End If
				Dim flag As Boolean = DESIGN.ProcessRodString(False)
				If Not flag Then
					flag2 = flag
				Else
					flag = Verify.VerifyPumpStroke()
					If Not flag Then
						flag2 = flag
					Else
						If rst.SPMEntered <> 0S Then
							If(If((-If((Not RSWIN_DESC.bBETA > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S AndAlso Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV)) AndAlso RSWIN_DESC.SETUP_CalcVBeltRatio <> 0S Then
								flag = PREDICT.Predict(False, "DesignUser")
								If(flag And RSWIN_DESC.bRodStarD And RSWIN_DESC.bDoNegativeStressCheck) AndAlso DESIGN.CheckForNegativeStresses() Then
									flag = PREDICT.Predict(False, "DesignUser")
								End If
							End If
							flag = PREDICT.Predict(True, "DesignUser")
							If flag And RSWIN_DESC.bRodStarD And RSWIN_DESC.bDoNegativeStressCheck Then
								If DESIGN.CheckForNegativeStresses() Then
									flag = PREDICT.Predict(True, "DesignUser")
								End If
							End If
						Else
							flag = DESIGN.CheckProduction()
						End If
						If RSWIN_DESC.bRodStarD AndAlso RSWIN_DESC.bAbortRun Then
							flag = False
						End If
						If flag Then
							flag = MWDown.StressAnalysis()
							If flag Then
								DESIGN.bFGStringOverloaded = 0S
								Dim num5 As Single
								Dim num6 As Single
								If rst.giRodDesignStyle <> 0S Then
									Dim num2 As Integer = 1
									Dim numRods As Integer = CInt(rst.NumRods)
									i = num2
									While i <= numRods
										If Not RODUTIL.IsRibbonRod(rst.Sections(i).Grade) And RODUTIL.IsFG(rst.Sections(i).Grade) And rst.maxStressTop(i) > 35000F Then
											DESIGN.bFGStringOverloaded = -1S
											Exit While
										End If
										i += 1
									End While
								End If
								i = CInt(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
								Dim pumpPos As Single() = rst.PumpPos
								Dim num3 As Single = 0F
								Dim num4 As Single = 0F
								Util.Maxmin(pumpPos, num5, num6, num3, num4)
								rst.GrossPumpStroke = num5 - num6
								If(If((-If(((rst.BPDsurface = 0F Or Not RSWIN_DESC.bRodStarD) > False), 1S, 0S)), 1S, 0S) Or (If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.SETUP_UseImpred)) <> 0S Then
									rst.BPDsurface = RUNCALC.BPDsurf(rst.GrossPumpStroke - rst.TubStretch, rst.SPM, rst.PlungerSize, rst.Pfill) * rst.Runtime / 24F
									If RSWIN_DESC.rst.PumpCondition = 2S Or RSWIN_DESC.rst.PumpCondition = 3S Then
										RSWIN_DESC.rst.BPDsurface = RSWIN_DESC.rst.BPDsurface * RSWIN_DESC.rst.PumpEfficiency / 100F
									End If
								End If
								rst.ProductionLoss = RUNCALC.BPDsurf(rst.TubStretch, rst.SPM, rst.PlungerSize, rst.Pfill) * rst.Runtime / 24F
								i = CInt(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
							End If
						End If
						flag2 = flag
					End If
				End If
				IL_37F:
				GoTo IL_3C6
				IL_381:
				num7 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_397:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_381
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3C6:
			Dim result As Boolean = flag2
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Function InitDesign() As Boolean
			Dim result As Boolean
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Dim flag As Boolean = True
				Select Case cRODSTAR.RodStringType
					Case 1S
						cRODSTAR.gbSteelRodString = True
					Case 2S, 4S
						cRODSTAR.gbSteelRodString = True
						Dim num As Short = 1S
						Dim numRods As Short = cRODSTAR.NumRods
						For num2 As Short = num To numRods
							If RODUTIL.IsFG(cRODSTAR.Sections(CInt(num2)).Grade) Then
								cRODSTAR.gbSteelRodString = False
							End If
						Next
					Case 3S
						Select Case cRODSTAR.giRodDesignStyle
							Case 0S
								cRODSTAR.gbSteelRodString = True
							Case 1S
								cRODSTAR.gbSteelRodString = False
						End Select
				End Select
				If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
					MImpred.PumpBoundCond()
				Else
					MJPred.PumpBoundCond()
				End If
				kinemat.Kinconst(cRODSTAR.PU)
				Dim cRODSTAR2 As cRODSTAR = cRODSTAR
				Dim pu As RSWIN_DESC.PUDataRec = cRODSTAR2.PU
				kinemat.Unitstroke(pu)
				cRODSTAR2.PU = pu
				flag = Verify.VerifyRodsInTubing()
				flag = DESIGN.VerifyPumpIntakePressure()
				flag = Verify.VerifyPumpEfficiency()
				If Not cRODSTAR.IrotEntered <> 0S Then
					MImpred.EstimateRotatingInertia()
				End If
				If cRODSTAR.gbUseIPR Then
					If cRODSTAR.gbCalcTargetBFPD Then
						DESIGN.CalculateTargetBFPD()
					ElseIf cRODSTAR.gbCalcPumpIntakePressure Then
						DESIGN.CalculatePumpIntakePressure()
					End If
				End If
				If cRODSTAR.CalcPlungerSize <> 0S Then
					Dim plungerSize As Single = cRODSTAR.PlungerSize
					RUNCALC.CalculatePlungerSize(cRODSTAR.Pfill)
					Try
						If plungerSize <> cRODSTAR.PlungerSize Then
							If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
								MImpred.PumpBoundCond()
							Else
								MJPred.PumpBoundCond()
							End If
						End If
					Catch ex As Exception
					End Try
				End If
				If Not cRODSTAR.SPMEntered <> 0S Then
					pu = cRODSTAR.PU
					Dim unitType As Short = pu.UnitType
					Dim kinematicStroke As Single = cRODSTAR.PU.KinematicStroke
					cRODSTAR2 = cRODSTAR
					Dim maxSPM As Single = cRODSTAR2.MaxSPM
					RUNCALC.MaxRecSPM(unitType, kinematicStroke, maxSPM)
					cRODSTAR2.MaxSPM = maxSPM
					cRODSTAR.SPM = CSng((0.85 * CDbl(cRODSTAR.MaxSPM)))
					If cRODSTAR.SPM > 10F Then
						cRODSTAR.SPM = 10F
					End If
				End If
				cRODSTAR = Nothing
				result = flag
			Catch ex2 As Exception
				result = True
			End Try
			Return result
		End Function

		Public Function ProcessRodString(bUseNominalSPM As Boolean) As Boolean
			Dim num As Integer
			Dim flag2 As Boolean
			Dim num5 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim num2 As Short = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
				DESIGN.CalcRodStringValues()
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim flag As Boolean
				If rst.RodStringType = 3S And rst.giRodDesignStyle <> 0S Then
					flag = DESIGNFG.CheckUndertravel()
					If Not flag Then
						flag2 = flag
						GoTo IL_254
					End If
				End If
				Dim unitType As Short = rst.PU.UnitType
				Dim kinematicStroke As Single = rst.PU.KinematicStroke
				Dim cRODSTAR As cRODSTAR = rst
				Dim num3 As Single = cRODSTAR.MaxSPM
				RUNCALC.MaxRecSPM(unitType, kinematicStroke, num3)
				cRODSTAR.MaxSPM = num3
				If rst.giRodDesignStyle = 0S Then
					Dim num4 As Single = rst.No * rst.Fc
					If rst.MaxSPM > num4 And num4 > 0F Then
						rst.MaxSPM = num4
					End If
				End If
				If rst.SPMEntered <> 0S Then
					flag = Verify.VerifyMaxPumpSpeed(rst.MaxSPM)
				Else
					flag = Verify.VerifyTargetBFPD()
					If flag Then
						DESIGN.CalcSPM(bUseNominalSPM)
					End If
				End If
				If flag Then
					If rst.UnknownM Then
						Select Case rst.PU.UnitType
							Case 6S
								rst.set_M(1, 400F)
								GoTo IL_1DB
							Case 7S, 10S
								rst.set_M(1, rst.PU.DrumDiamRatio * (2F * rst.WrodsInFluid + rst.FluidLoad) / 2F)
								GoTo IL_1DB
							Case 8S
								rst.set_M(1, 0F)
								GoTo IL_1DB
						End Select
						rst.set_M(1, (rst.FluidLoad / 2F + rst.WrodsInFluid) * rst.PU.KinematicStroke / 2F)
					Else
						rst.set_M(1, rst.get_M(2))
					End If
					IL_1DB:
					If rst.CalcMotorSPV <> 0S Then
						Dim bSilentOnError As Boolean = False
						cRODSTAR = rst
						num3 = cRODSTAR.MotorSPV
						Dim flag3 As Boolean = Motor.CalculateMotorSPV(bSilentOnError, num3)
						cRODSTAR.MotorSPV = num3
						flag = flag3
					End If
				End If
				flag2 = flag
				IL_20D:
				GoTo IL_254
				IL_20F:
				num5 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_225:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_20F
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_254:
			Dim result As Boolean = flag2
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Function SurfCalc(Optional bShow As Boolean = True) As Boolean
			Dim result As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Application.DoEvents()
				rst.MaxRodStressL = rst.StressL(1)
				Dim num As Short = 2S
				Dim numRods As Short = rst.NumRods
				For num2 As Short = num To numRods
					If rst.StressL(CInt(num2)) > rst.MaxRodStressL Then
						rst.MaxRodStressL = rst.StressL(CInt(num2))
					End If
				Next
				Dim cRODSTAR As cRODSTAR
				Dim array As Single()
				Dim cRODSTAR2 As cRODSTAR
				Dim array2 As Single()
				Dim cRODSTAR3 As cRODSTAR
				Dim num3 As Single
				If(If((-If(((rst.Prhp = 0F Or Not RSWIN_DESC.bRodStarD) > False), 1S, 0S)), 1S, 0S) Or (If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.SETUP_UseImpred)) <> 0S Then
					cRODSTAR = rst
					array = cRODSTAR.prvel
					cRODSTAR2 = rst
					array2 = cRODSTAR2.SurfLoad
					Dim ntsteps As Short = rst.Ntsteps
					cRODSTAR3 = rst
					num3 = cRODSTAR3.Prhp
					Torquebal.Polhpsub(array, array2, ntsteps, num3)
					cRODSTAR3.Prhp = num3
					cRODSTAR2.SurfLoad = array2
					cRODSTAR.prvel = array
				End If
				Application.DoEvents()
				Application.DoEvents()
				cRODSTAR3 = rst
				array2 = cRODSTAR3.prvel
				cRODSTAR2 = rst
				array = cRODSTAR2.PermLoad
				Dim ntsteps2 As Short = rst.Ntsteps
				cRODSTAR = rst
				num3 = cRODSTAR.Plhp
				Torquebal.Polhpsub(array2, array, ntsteps2, num3)
				cRODSTAR.Plhp = num3
				cRODSTAR2.PermLoad = array
				cRODSTAR3.prvel = array2
				If(If((-If((rst.PumpDepth < 1500F > False), 1S, 0S)), 1S, 0S) And rst.IncludeFluidInertia) <> 0S Then
					rst.Prhp = CSng((0.95 * CDbl(rst.Prhp)))
				End If
				Application.DoEvents()
				If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And RSWIN_DESC.rst.PU.UnitType <> 9S Then
					If((If((-If(((rst.MotorSPV = 0F) > False), 1S, 0S)), 1S, 0S) And Not rst.CalcMotorSPV) Or (If((-If((RSWIN_DESC.bBETA > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred)) <> 0S Then
						If Not RSWIN_DESC.SETUP_UseImpred <> 0S Then
							cRODSTAR3 = rst
							array2 = cRODSTAR3.SurfPos
							cRODSTAR2 = rst
							array = cRODSTAR2.SurfLoad
							cRODSTAR = rst
							Dim array3 As Single() = cRODSTAR.Tf
							Dim cRODSTAR4 As cRODSTAR = rst
							Dim array4 As Single() = cRODSTAR4.Thetac
							Dim moment As Single = rst.get_M(2)
							Dim cRODSTAR5 As cRODSTAR = rst
							Dim tnet As Single(,) = cRODSTAR5.Tnet
							Torquebal.Torque(array2, array, array3, array4, moment, tnet)
							cRODSTAR5.Tnet = tnet
							cRODSTAR4.Thetac = array4
							cRODSTAR.Tf = array3
							cRODSTAR2.SurfLoad = array
							cRODSTAR3.SurfPos = array2
						ElseIf RSWIN_DESC.bCalcNetTorque Then
							Dim cRODSTAR5 As cRODSTAR = rst
							Dim array4 As Single() = cRODSTAR5.SurfPos
							Dim cRODSTAR4 As cRODSTAR = rst
							Dim array3 As Single() = cRODSTAR4.SurfLoad
							cRODSTAR3 = rst
							array2 = cRODSTAR3.Tf
							cRODSTAR2 = rst
							array = cRODSTAR2.Thetac
							Dim moment2 As Single = rst.get_M(2)
							cRODSTAR = rst
							Dim tnet As Single(,) = cRODSTAR.Tnet
							Torquebal.Torque(array4, array3, array2, array, moment2, tnet)
							cRODSTAR.Tnet = tnet
							cRODSTAR2.Thetac = array
							cRODSTAR3.Tf = array2
							cRODSTAR4.SurfLoad = array3
							cRODSTAR5.SurfPos = array4
						End If
						Application.DoEvents()
						Torquebal.Balance(1)
					End If
				Else
					If(RSWIN_DESC.rst.PU.UnitType = 8S And Not RSWIN_DESC.rst.bUnknownUnbalance) Or (RSWIN_DESC.rst.PU.UnitType = 9S And Not RSWIN_DESC.rst.UnknownM) Then
						Dim cRODSTAR5 As cRODSTAR = rst
						Dim array4 As Single() = cRODSTAR5.SurfPos
						Dim cRODSTAR4 As cRODSTAR = rst
						Dim array3 As Single() = cRODSTAR4.SurfLoad
						cRODSTAR3 = rst
						array2 = cRODSTAR3.Tf
						cRODSTAR2 = rst
						array = cRODSTAR2.Thetac
						Dim unbalance As Single = rst.Unbalance
						cRODSTAR = rst
						Dim tnet As Single(,) = cRODSTAR.Tnet
						Torquebal.Torque(array4, array3, array2, array, unbalance, tnet)
						cRODSTAR.Tnet = tnet
						cRODSTAR2.Thetac = array
						cRODSTAR3.Tf = array2
						cRODSTAR4.SurfLoad = array3
						cRODSTAR5.SurfPos = array4
					End If
					Torquebal.Balance(1)
				End If
				Dim num4 As Single
				Torquebal.CLFactor(rst.iUnknownM, num4)
				rst.MinMotorHP = CSng((CDbl((num4 * rst.Prhp)) / 0.9))
				Application.DoEvents()
				Dim flag As Boolean = Verify.VerifyMotorSize(bShow)
				If Not flag Then
					result = False
				Else
					Dim cRODSTAR4 As cRODSTAR
					Dim cRODSTAR5 As cRODSTAR
					If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) Then
						If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
							Torquebal.Balance(0)
						Else
							If Not DESIGN.NonZeroTorqueFound() Then
								cRODSTAR5 = rst
								Dim array4 As Single() = cRODSTAR5.SurfPos
								cRODSTAR4 = rst
								Dim array3 As Single() = cRODSTAR4.SurfLoad
								cRODSTAR3 = rst
								array2 = cRODSTAR3.Tf
								cRODSTAR2 = rst
								array = cRODSTAR2.Thetac
								Dim moment3 As Single = rst.get_M(2)
								cRODSTAR = rst
								Dim tnet As Single(,) = cRODSTAR.Tnet
								Torquebal.Torque(array4, array3, array2, array, moment3, tnet)
								cRODSTAR.Tnet = tnet
								cRODSTAR2.Thetac = array
								cRODSTAR3.Tf = array2
								cRODSTAR4.SurfLoad = array3
								cRODSTAR5.SurfPos = array4
							End If
							Torquebal.Balance_JPred(0)
						End If
					Else
						If Not RSWIN_DESC.rst.bUnknownUnbalance Then
							cRODSTAR5 = rst
							Dim array4 As Single() = cRODSTAR5.SurfPos
							cRODSTAR4 = rst
							Dim array3 As Single() = cRODSTAR4.SurfLoad
							cRODSTAR3 = rst
							array2 = cRODSTAR3.Tf
							cRODSTAR2 = rst
							array = cRODSTAR2.Thetac
							Dim unbalance2 As Single = rst.Unbalance
							cRODSTAR = rst
							Dim tnet As Single(,) = cRODSTAR.Tnet
							Torquebal.Torque(array4, array3, array2, array, unbalance2, tnet)
							cRODSTAR.Tnet = tnet
							cRODSTAR2.Thetac = array
							cRODSTAR3.Tf = array2
							cRODSTAR4.SurfLoad = array3
							cRODSTAR5.SurfPos = array4
						End If
						Torquebal.Balance_JPred(0)
					End If
					Dim num5 As Short = 0S
					Dim num6 As Short = CShort(rst.iUnknownM)
					For num7 As Short = num5 To num6
						Torquebal.CLFactor(CInt(num7), rst.Clf(CInt(num7)))
						Torquebal.FindMaxTorque(CInt(num7), rst.PeakTorque(CInt(num7)))
					Next
					Dim surfPos As Single() = rst.SurfPos
					num3 = 0F
					Dim num8 As Single = 0F
					cRODSTAR5 = rst
					Dim num9 As Single = CSng(cRODSTAR5.StartDownstroke)
					cRODSTAR4 = rst
					Dim num10 As Single = CSng(cRODSTAR4.StartUpstroke)
					Util.Maxmin(surfPos, num3, num8, num9, num10)
					cRODSTAR4.StartUpstroke = CInt(Math.Round(CDbl(num10)))
					cRODSTAR5.StartDownstroke = CInt(Math.Round(CDbl(num9)))
					Dim moment4 As Single = rst.get_M(rst.iUnknownM)
					cRODSTAR5 = rst
					Dim array4 As Single() = cRODSTAR5.PermLoad
					Torquebal.CalculatePL(moment4, array4, rst.iUnknownM, flag)
					cRODSTAR5.PermLoad = array4
					If Not flag Then
						result = False
					Else
						cRODSTAR5 = rst
						Dim array4 As Single() = cRODSTAR5.prvel
						cRODSTAR4 = rst
						Dim array3 As Single() = cRODSTAR4.PermLoad
						Dim ntsteps3 As Short = rst.Ntsteps
						cRODSTAR3 = rst
						num10 = cRODSTAR3.Plhp
						Torquebal.Polhpsub(array4, array3, ntsteps3, num10)
						cRODSTAR3.Plhp = num10
						cRODSTAR4.PermLoad = array3
						cRODSTAR5.prvel = array4
						If RODUTIL.IsCrankBalanced(rst.PU.UnitType) Or (rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) Then
							Dim theta As Double
							If rst.PU.UnitType = 9S Then
								theta = 1.5707963267948966 - CDbl(rst.PU.CrankOffset) * 3.141592653589793 / 180.0
							ElseIf rst.PU.UnitType = 1S And rst.PU.CrankRotation = -1S Then
								theta = 4.71238898038469 - CDbl(rst.PU.CrankOffset)
							Else
								theta = 1.5707963267948966 - CDbl(rst.PU.CrankOffset)
							End If
							Dim num11 As Double
							Dim num12 As Double
							Dim num13 As Double
							Dim num14 As Double
							kinemat.Kinematics(theta, num11, num12, num13, num14, -1, 0F)
							If rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
								rst.CBE90(2) = CSng((Math.Abs(CDbl(rst.get_M(2)) / num13) + CDbl(rst.get_RequiredUnbalance(2))))
								rst.CBE90(1) = CSng((Math.Abs(CDbl(rst.get_M(1)) / num13) + CDbl(rst.get_RequiredUnbalance(1))))
								rst.CBE90(0) = CSng((Math.Abs(CDbl(rst.get_M(0)) / num13) + CDbl(rst.get_RequiredUnbalance(0))))
							Else
								rst.CBE90(2) = CSng((Math.Abs(CDbl(rst.get_M(2)) / num13) + CDbl(rst.PU.Unbalance)))
								rst.CBE90(1) = CSng((Math.Abs(CDbl(rst.get_M(1)) / num13) + CDbl(rst.PU.Unbalance)))
								rst.CBE90(0) = CSng((Math.Abs(CDbl(rst.get_M(0)) / num13) + CDbl(rst.PU.Unbalance)))
							End If
						End If
						Dim num2 As Short = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
						rst.StructL = CSng((CDbl(rst.Pprload) / (CDbl(rst.PU.StructRating) * 100.0)))
						rst.GearboxLoading(2) = CSng((CDbl(Math.Abs(rst.PeakTorque(2))) / (CDbl(rst.PU.GearboxRating) * 1000.0)))
						rst.GearboxLoading(1) = CSng((CDbl(Math.Abs(rst.PeakTorque(1))) / (CDbl(rst.PU.GearboxRating) * 1000.0)))
						rst.GearboxLoading(0) = CSng((CDbl(Math.Abs(rst.PeakTorque(0))) / (CDbl(rst.PU.GearboxRating) * 1000.0)))
						If rst.GearboxLoading(0) < rst.GearboxLoading(1) Then
							rst.GearboxLoading(1) = rst.GearboxLoading(0)
						End If
						Dim num15 As Single
						If rst.giRodDesignStyle = 0S Then
							num15 = 1.1F
						Else
							num15 = 1.15F
						End If
						Dim num16 As Short = 0S
						Dim num17 As Short = CShort(rst.iUnknownM)
						num2 = num16
						While num2 <= num17
							Dim num18 As Single = CSng((CDbl((rst.Clf(CInt(num2)) * rst.Prhp)) / 0.9))
							rst.HpNemaD(CInt(num2)) = RODUTIL.StdMotorSize(num18 * num15)
							rst.HpUhs(CInt(num2)) = RODUTIL.StdMotorSize(CSng((0.85 * CDbl(num18) * CDbl(num15))))
							If rst.HpUhs(CInt(num2)) <= num18 Then
								rst.HpUhs(CInt(num2)) = rst.HpNemaD(CInt(num2))
							End If
							num2 += 1S
						End While
						Dim iMotorType As Short
						Dim sMotorSizeName As String
						Dim sMotorSettingName As String
						Dim num19 As Short
						Dim num20 As Short
						num2 = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
						iMotorType = Conversions.ToShort(Motor.GetMotorInfo(4))
						sMotorSizeName = Conversions.ToString(Motor.GetMotorInfo(3))
						sMotorSettingName = Conversions.ToString(Motor.GetMotorInfo(2))
						num19 = 0S
						num20 = CShort(rst.iUnknownM)
						num2 = num19
						While num2 <= num20
							If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), rst.CalcMotorSize)) Then
								Motor.SelectMotorKindByMotorType(Conversions.ToInteger(Motor.GetMotorInfo(4)))
								Motor.SelectMotorSizeByRatedHP(rst.HpNemaD(CInt(num2)))
								Motor.SelectMotorSetting(0)
							End If
							RUNCALC.CalculateEnergyConsumption(num2, rst.MotorKWH(CInt(num2)))
							Dim num21 As Single = CSng((7.373E-06 * CDbl(rst.BPDsurface) * CDbl(rst.FluidLevel) * CDbl(rst.FluidSPGR)))
							Dim num22 As Single = CSng((CDbl(num21) / 1.3405 * CDbl(rst.Runtime)))
							Dim num23 As Double = CDbl(rst.MotorKWH(CInt(num2)))
							If num23 <> 0.0 Then
								rst.SystemEff = CSng((CDbl(num22) / num23 * 24.0 / CDbl(rst.Runtime)))
							Else
								rst.SystemEff = 0F
							End If
							rst.set_ElectricBillperMonth(CInt(num2), CSng((CDbl(rst.MotorKWH(CInt(num2))) * 30.5 * CDbl(rst.ElectricityCost))))
							rst.DollarsPerBblFluid(CInt(num2)) = rst.MotorKWH(CInt(num2)) * rst.ElectricityCost / rst.BPDsurface
							rst.DollarsPerBblOil(CInt(num2)) = CSng((CDbl(rst.DollarsPerBblFluid(CInt(num2))) / (1.0 - CDbl(rst.WaterCut) / 100.0)))
							num2 += 1S
						End While
						If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), rst.CalcMotorSize)) Then
							Motor.SelectMotorKindByMotorType(CInt(iMotorType))
							Motor.SelectMotorSizeByName(sMotorSizeName)
							Motor.SelectMotorSettingByName(sMotorSettingName)
						End If
						RSWIN_DESC.bBalancedEVarsOverwritten = False
						Dim num24 As Short = 1S
						If((Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And Not rst.UnknownM) Or ((RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And Not rst.bUnknownUnbalance)) And rst.get_ElectricBillperMonth(2) < rst.get_ElectricBillperMonth(1) And RSWIN_DESC.rst.PU.UnitType <> 10S Then
							num24 = 2S
						End If
						If((If((-If((CDbl(rst.get_ElectricBillperMonth(0)) >= 0.99 * CDbl(rst.get_ElectricBillperMonth(CInt(num24))) > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.DEBUG_ShowAllBalanced) Or If((-If(((RSWIN_DESC.rst.PU.UnitType = 10S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							RSWIN_DESC.bBalancedEVarsOverwritten = True
							RSWIN_DESC.iOverWriteIndex = CInt(num24)
							rst.set_M(0, rst.get_M(CInt(num24)))
							If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
								rst.set_RequiredUnbalance(0, rst.get_RequiredUnbalance(CInt(num24)))
							End If
							rst.PeakTorque(0) = rst.PeakTorque(CInt(num24))
							rst.Clf(0) = rst.Clf(CInt(num24))
							rst.GearboxLoading(0) = rst.GearboxLoading(CInt(num24))
							rst.CBE90(0) = rst.CBE90(CInt(num24))
							rst.HpNemaD(0) = rst.HpNemaD(CInt(num24))
							rst.HpUhs(0) = rst.HpUhs(CInt(num24))
							rst.MotorKWH(0) = rst.MotorKWH(CInt(num24))
							rst.set_ElectricBillperMonth(0, rst.get_ElectricBillperMonth(CInt(num24)))
							rst.DollarsPerBblFluid(0) = rst.DollarsPerBblFluid(CInt(num24))
							rst.DollarsPerBblOil(0) = rst.DollarsPerBblOil(CInt(num24))
							Dim num25 As Short = 0S
							Dim num26 As Short = rst.Ntsteps - 1S
							num2 = num25
							While num2 <= num26
								rst.Tnet(0, CInt(num2)) = rst.Tnet(CInt(num24), CInt(num2))
								num2 += 1S
							End While
						End If
						Dim pumpPos As Single() = rst.PumpPos
						num10 = 0F
						num9 = 0F
						num8 = 0F
						Dim num27 As Single
						Util.Maxmin(pumpPos, num10, num27, num9, num8)
						Dim num28 As Short = 0S
						Dim num29 As Short = rst.Ntsteps - 1S
						num2 = num28
						While num2 <= num29
							rst.PumpPos(CInt(num2)) = rst.PumpPos(CInt(num2)) - num27
							If rst.PumpPos(CInt(num2)) < 0F Then
								rst.PumpPos(CInt(num2)) = 0F
							End If
							num2 += 1S
						End While
						num2 = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
						Dim pumpDepth As Single = rst.PumpDepth
						If pumpDepth <= 3500F Then
							rst.PlungerLength = 2F
						ElseIf pumpDepth <= 5000F Then
							rst.PlungerLength = 3F
						ElseIf pumpDepth <= 6000F Then
							rst.PlungerLength = 4F
						ElseIf pumpDepth <= 7000F Then
							rst.PlungerLength = 5F
						Else
							rst.PlungerLength = 6F
						End If
						Dim num30 As Single = 0F
						Dim num31 As Short = 1S
						Dim numRods2 As Short = rst.NumRods
						num2 = num31
						While num2 <= numRods2
							If RODUTIL.IsFG(rst.Sections(CInt(num2)).Grade) Then
								num30 += rst.Sections(CInt(num2)).length
							End If
							num2 += 1S
						End While
						If num30 = 0F Then
							rst.PumpSpacing = 3F * rst.PumpDepth / 1000F
						Else
							rst.PumpSpacing = (9F * num30 + 2F * rst.PumpDepth) / 1000F
						End If
						rst.PumpLength = Conversions.ToSingle(Operators.DivideObject(Operators.AddObject(Operators.AddObject(CDbl((9F * num30)) * 1.75 / 1000.0 + CDbl((2F * rst.PumpDepth / 1000F)), Util.Max(rst.GrossPumpStroke, rst.PU.KinematicStroke)), 12F * rst.PlungerLength), 12))
						If rst.IDEntered <> 0S Then
							Dim unitID As String = RSWIN_DESC.rst.UnitID
							Dim num32 As Short
							Dim obj As Object = num32
							Dim text As String
							PUDATA1.ParseUnitID(unitID, text, obj)
							num32 = Conversions.ToShort(obj)
							If Operators.CompareString(text, "R", False) = 0 Then
								Dim num33 As Integer = 1
								Dim num34 As Single
								If num33 = Strings.InStr(rst.PU.UnitName, "700", CompareMethod.Binary) Then
									num34 = 0.2992F
								ElseIf num33 = Strings.InStr(rst.PU.UnitName, "800", CompareMethod.Binary) Then
									num34 = 0.2494F
								ElseIf num33 = Strings.InStr(rst.PU.UnitName, "900", CompareMethod.Binary) Then
									num34 = 0.2078F
								ElseIf num33 = Strings.InStr(rst.PU.UnitName, "1000", CompareMethod.Binary) Then
									num34 = 0.1813F
								ElseIf num33 = Strings.InStr(rst.PU.UnitName, "1100", CompareMethod.Binary) Then
									num34 = 0.1586F
								ElseIf num33 = Strings.InStr(rst.PU.UnitName, "1200", CompareMethod.Binary) Then
									num34 = 0.1269F
								End If
								rst.PumpSpacing = rst.PumpSpacing + num34 * rst.Pprload / 1000F + 12F
							End If
						End If
						If num30 = 0F Then
							If CDbl(rst.PlungerSize) > 2.0 Then
								rst.PumpLength = CSng((CDbl(rst.PumpLength) + 2.0))
							End If
							rst.PumpLength = Conversion.Int(rst.PumpLength + rst.PumpSpacing / 12F) + 1F
						End If
						result = True
					End If
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub CalculateTargetBFPD()
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim num2 As Single = IPR.iprPwfFromPip(RSWIN_DESC.rst.PumpIntakePressure)
				RSWIN_DESC.rst.TargetBFPD = IPR.iprProductionFromPwf(num2) + RSWIN_DESC.rst.WaterPI * (RSWIN_DESC.rst.StaticBHPressure - num2)
				IL_42:
				GoTo IL_85
				IL_44:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_58:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_44
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_85:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function CheckSanity() As Boolean
			Dim flag As Boolean = True
			Dim flag2 As Boolean = True
			Dim result As Boolean
			Try
				' The following expression was wrapped in a checked-statement
				If Operators.CompareString(RSWIN_DESC.rst.UnitID.Trim(), "", False) = 0 Then
					Util.Errmsg("Please enter pumping unit.")
					flag = False
				Else
					Dim pu As RSWIN_DESC.PUDataRec
					pu.Initialize()
					pu = RSWIN_DESC.rst.PU
					If RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S Or RSWIN_DESC.rst.PU.UnitType = 6S Then
						RSWIN_DESC.rst.CalcMotorSPV = 0S
						RSWIN_DESC.rst.MotorSPV = 0F
					ElseIf RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
						If RSWIN_DESC.rst.bUnknownUnbalance Then
							RSWIN_DESC.rst.UnknownM = True
						End If
					ElseIf RSWIN_DESC.rst.PU.UnitType = 9S Then
						pu.Unbalance = 0F
						RSWIN_DESC.rst.Unbalance = 0F
						RSWIN_DESC.rst.PU = pu
					End If
					Try
						If RSWIN_DESC.rst.PU.UnitType = 10S Then
							pu.P = 0F
							RSWIN_DESC.rst.PU = pu
						End If
					Catch ex As Exception
					End Try
					Try
						If pu.CrankHole <> 0S AndAlso pu.R <> pu.CrankRadii(CInt((pu.CrankHole - 1S))) Then
							pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
							RSWIN_DESC.rst.PU = pu
						End If
					Catch ex2 As Exception
					End Try
					If Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 And (RSWIN_DESC.rst.PU.RequiredRotation = 1S Or RSWIN_DESC.rst.PU.RequiredRotation = -1S) And RSWIN_DESC.rst.PU.CrankRotation <> RSWIN_DESC.rst.PU.RequiredRotation Then
						pu.CrankRotation = RSWIN_DESC.rst.PU.RequiredRotation
						RSWIN_DESC.rst.PU = pu
					End If
					If RSWIN_DESC.rst.PU.CrankRotation = 0S Then
						pu.CrankRotation = -1S
						RSWIN_DESC.rst.PU = pu
					End If
				End If
				If(Not RSWIN_DESC.rst.SPMEntered And If((-If((RSWIN_DESC.rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S) And If((-If((Not RSWIN_DESC.rst.gbUseIPR > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Util.Errmsg(DESIGN.sInvalidProd)
					flag = False
				ElseIf RSWIN_DESC.rst.ServiceFactor = 0F Then
					Util.Errmsg("Please enter a value for service factor")
					flag = False
				Else
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim obj As Object = rst.ServiceFactor
					Dim lowerBound As Single = 0.5F
					Dim inclusive As Integer = -1
					Dim errnum As Integer = 61
					Dim useMetric As Integer = -1
					Dim canadianIsMetric As Integer = -1
					Dim bQuiet As Boolean = False
					Dim text As String = ""
					Dim obj2 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text)
					rst.ServiceFactor = Conversions.ToSingle(obj)
					If Conversions.ToBoolean(Operators.NotObject(obj2)) Then
						flag = False
					Else
						rst = RSWIN_DESC.rst
						obj = rst.ServiceFactor
						Dim upperBound As Single = 1F
						Dim inclusive2 As Integer = -1
						Dim errnum2 As Integer = 61
						Dim useMetric2 As Integer = -1
						Dim canadianIsMetric2 As Integer = -1
						Dim bQuiet2 As Boolean = False
						text = ""
						Dim obj3 As Object = Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text)
						rst.ServiceFactor = Conversions.ToSingle(obj)
						If Conversions.ToBoolean(Operators.NotObject(obj3)) Then
							flag = False
						End If
					End If
				End If
				If RSWIN_DESC.rst.RodStringType = 2S Or RSWIN_DESC.rst.RodStringType = 4S Then
					Dim num As Single = 0F
					Dim flag3 As Boolean = False
					Try
						Dim num2 As Integer = 1
						Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num2 To numRods
							If RSWIN_DESC.rst.Sections(i).Grade = 0S Or RSWIN_DESC.rst.Sections(i).length = 0F Or RSWIN_DESC.rst.Sections(i).Diameter = 0F Then
								Util.Errmsg(DESIGN.sEnterStringDesign)
								flag = False
								Exit For
							End If
						Next
						If Not flag Then
							Return result
						End If
					Catch ex3 As Exception
					End Try
					Dim num3 As Integer = 1
					Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For j As Integer = num3 To numRods2

							num += RSWIN_DESC.rst.Sections(j).length
							If RSWIN_DESC.rst.Sections(j).length < RSWIN_DESC.SETUP_SteelSuckerRodLength Then
								flag3 = True
							End If

					Next
					If(flag3 AndAlso flag2) And Not(RSWIN_DESC.bSuppressWarningMessages And RSWIN_DESC.bExpert) Then
						flag = False
						Util.Errmsg(DESIGN.sTooShort)
					End If
					If Not flag3 And (num < RSWIN_DESC.rst.PumpDepth - 50F Or num > RSWIN_DESC.rst.PumpDepth + 2F) And Not(RSWIN_DESC.bSuppressWarningMessages And RSWIN_DESC.bExpert) Then
						flag = False
						If num < RSWIN_DESC.rst.PumpDepth - 50F Then
							Util.Errmsg(DESIGN.sTotalDepth2)
						Else
							Util.Errmsg(DESIGN.sTotalDepth1)
						End If
					End If
				ElseIf(RSWIN_DESC.bRodStarD And RSWIN_DESC.bSinkerBarDepthChanged) AndAlso RSWIN_DESC.rst.RSSRSize = 0F Then
					RSWIN_DESC.rst.RSSRSize = RSWIN_DESC.rst.RSMinSize
				End If
				If RSWIN_DESC.rst.FluidLevel > RSWIN_DESC.rst.PumpDepth Then
					RSWIN_DESC.rst.FluidLevel = RSWIN_DESC.rst.PumpDepth
				End If
				If RSWIN_DESC.rst.TubingAnchorDepth > RSWIN_DESC.rst.PumpDepth Then
					RSWIN_DESC.rst.TubingAnchorDepth = RSWIN_DESC.rst.PumpDepth
				End If
				If Information.IsDBNull(RSWIN_DESC.rst.Unbalance) Then
					RSWIN_DESC.rst.Unbalance = RSWIN_DESC.rst.PU.Unbalance
				ElseIf RSWIN_DESC.rst.Unbalance = 0F Then
					RSWIN_DESC.rst.Unbalance = RSWIN_DESC.rst.PU.Unbalance
				End If
				If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
					RSWIN_DESC.rst.set_RequiredUnbalance(2, RSWIN_DESC.rst.Unbalance)
					RSWIN_DESC.rst.CalcMotorSPV = 0S
				End If
				If RSWIN_DESC.rst.PU.Unbalance = 0F And RSWIN_DESC.rst.Unbalance <> 0F Then
					Dim pu As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
					pu.Unbalance = RSWIN_DESC.rst.Unbalance
					RSWIN_DESC.rst.PU = pu
				End If
				If RSWIN_DESC.bRodStarD AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count < 2 Then
					Util.Errmsg(DESIGN.sRODSTARDSurveyRequired)
					flag = False
				End If
				If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
					RSWIN_DESC.bBeamBalanced = True
				Else
					RSWIN_DESC.bBeamBalanced = False
				End If
				If RSWIN_DESC.bRodStarD Then
					DESIGN.CheckGuides()
				End If
				If RSWIN_DESC.rst.PR_Diameter = 0F Then
					RSWIN_DESC.rst.PR_Diameter = 1.5F
				End If
				result = flag
			Catch ex4 As Exception
				result = True
			End Try
			Return result
		End Function

		Public Function VerifyPumpIntakePressure() As Boolean
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Not rst.gbCalcPumpCondition And Not rst.FluidLevelEntered Then
					Dim fluidLevel As Single = rst.FluidLevel
					If fluidLevel < 0F Then
						Dim msg As String
						Util.LoadMessage(168, msg)
						flag = Verify.VerifyReturnToMain(msg)
					ElseIf fluidLevel > rst.PumpDepth Then
						Dim msg As String
						Util.LoadMessage(181, msg)
						flag = Verify.VerifyReturnToMain(msg)
					End If
				End If
				result = flag
			Catch ex As Exception
				result = True
			End Try
			Return result
		End Function

		Private Function NonZeroTorqueFound() As Boolean
			Dim result As Boolean = False
			Dim num As Integer = 0
			Dim num2 As Integer = CInt((RSWIN_DESC.rst.Ntsteps - 1S))
			For i As Integer = num To num2
				If RSWIN_DESC.rst.Tnet(2, i) <> 0F Then
					result = True
				End If
			Next
			Return result
		End Function

		Public Function DesignSinkerbar(sPredictType As String, bFG As Boolean) As Object
			Dim flag As Boolean = False
			Dim num As Integer = 25
			Dim num2 As Integer = 0
			Dim rptExpertSummary As rptExpertSummary = New rptExpertSummary()
			Dim num3 As Integer = -1
			Dim flag2 As Boolean = False
			Dim gbIncludeBuoyancy As Boolean = RSWIN_DESC.rst.gbIncludeBuoyancy
			Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim array2 As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim array3 As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim array4 As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim array5 As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim array6 As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim array7 As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim array8 As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim result As Object
			Try
				DESIGN.CalculateBuoyedAndUnbouyedStress(bFG, array, array2, array3, array4, array5, array6, array7, array8)
				Dim flag3 As Boolean = True
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num5 As Single
				Dim num6 As Single
				If bFG Then
					Dim num4 As Integer
					Dim flag4 As Boolean = RSWIN.HasFG(num4)
					num5 = 1225F
					num6 = array(CInt((RSWIN_DESC.rst.NumRods - 1S)))
					If num6 > 1000F Then
						flag3 = False
					End If
				Else
					num5 = 800F
					num6 = array5(CInt((RSWIN_DESC.rst.NumRods - 1S)))
					If num6 >= 300F And num6 <= 500F Then
						flag3 = False
					End If
				End If
				If flag3 Then
					Dim sinkerBar As RSWIN_DESC.RodSection
					sinkerBar.Initialize()
					sinkerBar = RSWIN_DESC.rst.SinkerBar
					sinkerBar.length = CSng(DESIGN.GetInitialSBLength(num6))
					If sinkerBar.length > num5 Then
						sinkerBar.length = num5
					End If
					RSWIN_DESC.rst.SinkerBar = sinkerBar
					Dim length As Single = RSWIN_DESC.rst.SinkerBar.length
					Dim num7 As Single = -111111F
					Dim num8 As Single = num6
					Dim flag4 As Boolean = True
					Dim num9 As Integer = 0
					If Not RSWIN_DESC.bImprovingScore AndAlso (RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug) Then
						Batch.BatchMessage("> Bot. Min. Stress taper above SB start SB design: " + Conversions.ToString(num6))
					End If
					Do
						num9 += 1
						If Operators.CompareString(sPredictType, "DesignSteel", False) = 0 Then
							If RSWIN_DESC.bDoExpertBuoyancyChange Then
								RSWIN_DESC.rst.gbIncludeBuoyancy = False
							End If
							flag4 = Conversions.ToBoolean(DESIGNST.DesignSteel())
							DESIGN.CalculateBuoyedAndUnbouyedStress(bFG, array, array2, array3, array4, array5, array6, array7, array8)
							If RSWIN_DESC.bDoExpertBuoyancyChange Then
								RSWIN_DESC.rst.gbIncludeBuoyancy = gbIncludeBuoyancy
							End If
							If Not flag4 Then
								Exit Do
							End If
							num8 = array5(CInt((RSWIN_DESC.rst.NumRods - 1S)))
							If(num8 >= 300F And num8 <= 600F) Or (num7 < 300F And num7 <> -111111F And num8 > 600F) Then
								Exit Do
							End If
							sinkerBar.Initialize()
							sinkerBar = RSWIN_DESC.rst.SinkerBar

								If num7 > 600F And num8 < 300F And RSWIN_DESC.rst.SinkerBar.length <= num5 Then
									sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num8, num7, False))
									RSWIN_DESC.rst.SinkerBar = sinkerBar
									num3 = 0
								ElseIf num7 > 600F And num8 < 300F And RSWIN_DESC.rst.SinkerBar.length <= num5 Then
									sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num8, num7, False))
									RSWIN_DESC.rst.SinkerBar = sinkerBar
									num3 = 0
								ElseIf num8 < 300F And RSWIN_DESC.rst.SinkerBar.length <= num5 Then
									sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num8, num7, False))
									RSWIN_DESC.rst.SinkerBar = sinkerBar
									num3 = 0
								ElseIf num8 >= 600F And RSWIN_DESC.rst.SinkerBar.length >= 50F Then
									sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length - CSng(DESIGN.GetIncrement(num, False, num3, num8, num7, False))
									RSWIN_DESC.rst.SinkerBar = sinkerBar
									num3 = 1
								End If
								length = RSWIN_DESC.rst.SinkerBar.length

						ElseIf Operators.CompareString(sPredictType, "DesignFG", False) = 0 Then
							If RSWIN_DESC.bDoExpertBuoyancyChange Then
								RSWIN_DESC.rst.gbIncludeBuoyancy = True
							End If
							flag4 = DESIGNFG.DesignFG()
							DESIGN.CalculateBuoyedAndUnbouyedStress(bFG, array, array2, array3, array4, array5, array6, array7, array8)
							If RSWIN_DESC.bDoExpertBuoyancyChange Then
								RSWIN_DESC.rst.gbIncludeBuoyancy = gbIncludeBuoyancy
							End If
							If Not flag4 Then
								Exit Do
							End If
							If bFG Then
								num8 = array(CInt((RSWIN_DESC.rst.NumRods - 1S)))
								If num8 >= 1000F Then
									Exit Do
								End If
								sinkerBar.Initialize()
								sinkerBar = RSWIN_DESC.rst.SinkerBar
								If num8 < 1000F And RSWIN_DESC.rst.SinkerBar.length <= num5 Then
									' The following expression was wrapped in a unchecked-expression
									sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num8, num7, True))
									RSWIN_DESC.rst.SinkerBar = sinkerBar
									num3 = 0
								End If
								length = RSWIN_DESC.rst.SinkerBar.length
							ElseIf RSWIN_DESC.rst.NumRods > 2S AndAlso RSWIN_DESC.rst.RSFGIncludeSteel <> 0S Then
								num8 = array5(CInt((RSWIN_DESC.rst.NumRods - 1S)))

									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									If(RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) Or If((-If((CUSTOMRG.IsOtherSteel(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) > False), 1, 0)), 1, 0)) <> 0 Then
										If(num8 >= 300F And num8 <= 600F) Or (num7 < 300F And num7 <> -111111F And num8 > 600F) Then
											Exit Do
										End If
										sinkerBar.Initialize()
										sinkerBar = RSWIN_DESC.rst.SinkerBar
										If num7 > 600F And num8 < 300F And RSWIN_DESC.rst.SinkerBar.length <= num5 Then
											sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num8, num7, False))
											RSWIN_DESC.rst.SinkerBar = sinkerBar
											num3 = 0
										ElseIf num7 > 600F And num8 < 300F And RSWIN_DESC.rst.SinkerBar.length <= num5 Then
											sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num8, num7, False))
											RSWIN_DESC.rst.SinkerBar = sinkerBar
											num3 = 0
										ElseIf num8 < 300F And RSWIN_DESC.rst.SinkerBar.length <= num5 Then
											sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num8, num7, False))
											RSWIN_DESC.rst.SinkerBar = sinkerBar
											num3 = 0
										ElseIf num8 >= 600F And RSWIN_DESC.rst.SinkerBar.length >= 50F Then
											sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length - CSng(DESIGN.GetIncrement(num, False, num3, num8, num7, False))
											RSWIN_DESC.rst.SinkerBar = sinkerBar
											num3 = 1
										End If
										length = RSWIN_DESC.rst.SinkerBar.length
									End If

							End If
						End If
						If num9 > 55 Then
							flag = True
						ElseIf num7 = num8 Then
							num2 += 1
							If num2 > 5 Then
								flag = True
							End If
						Else
							num2 = 0
						End If
						num7 = num8
						Application.DoEvents()
						If RSWIN_DESC.rst.SinkerBar.length > num5 And num9 <= 55 And Not flag Then
							If Not flag2 Then
								sinkerBar.length = num5
								RSWIN_DESC.rst.SinkerBar = sinkerBar
								flag = False
								flag2 = True
							Else
								flag = True
							End If
						ElseIf sinkerBar.length < 50F And num9 <= 55 And Not flag Then
							If Not flag2 Then
								sinkerBar.length = 50F
								RSWIN_DESC.rst.SinkerBar = sinkerBar
								flag = False
								flag2 = True
							Else
								flag = True
							End If
						End If
					Loop While Not flag
					If Not RSWIN_DESC.bImprovingScore AndAlso (RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug) Then
						Batch.BatchMessage(String.Concat(New String() { "> Bot. Min. Stress taper above SB end SB design: ", Conversions.ToString(num8), "  , Length=", Conversions.ToString(RSWIN_DESC.rst.SinkerBar.length), "  , count=", Conversions.ToString(num9) }))
					End If
					Application.DoEvents()
					Application.DoEvents()
					result = flag4
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function DesignSinkerbar_Old(fStress As Single, sPredictType As String) As Object
			Dim flag As Boolean = False
			Dim num As Integer = 25
			Dim num2 As Integer = 0
			Dim rptExpertSummary As rptExpertSummary = New rptExpertSummary()
			Dim num3 As Integer = -1
			Dim flag2 As Boolean = False
			Dim result As Object
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim sinkerBar As RSWIN_DESC.RodSection
				sinkerBar.Initialize()
				sinkerBar = RSWIN_DESC.rst.SinkerBar
				sinkerBar.length = CSng(DESIGN.GetInitialSBLength(fStress))
				RSWIN_DESC.rst.SinkerBar = sinkerBar
				Dim length As Single = RSWIN_DESC.rst.SinkerBar.length
				Dim num4 As Single = -111111F
				Dim num5 As Single = fStress
				Dim flag3 As Boolean = True
				Dim num6 As Integer = 0
				If Not RSWIN_DESC.bImprovingScore AndAlso (RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug) Then
					Batch.BatchMessage("> Bot. Min. Stress taper above SB start SB design: " + Conversions.ToString(fStress))
				End If
				Do
					num6 += 1
					Dim num7 As Single
					If Operators.CompareString(sPredictType, "DesignSteel", False) = 0 Then
						num7 = 800F
						flag3 = Conversions.ToBoolean(DESIGNST.DesignSteel())
						If Not flag3 Then
							Exit Do
						End If
						num5 = RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
						If(num5 >= 300F And num5 <= 600F) Or (num4 < 300F And num4 <> -111111F And num5 > 600F) Then
							Exit Do
						End If
						sinkerBar.Initialize()
						sinkerBar = RSWIN_DESC.rst.SinkerBar

							If num4 > 600F And num5 < 300F And RSWIN_DESC.rst.SinkerBar.length <= num7 Then
								sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num5, num4, False))
								RSWIN_DESC.rst.SinkerBar = sinkerBar
								num3 = 0
							ElseIf num4 > 600F And num5 < 300F And RSWIN_DESC.rst.SinkerBar.length <= num7 Then
								sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num5, num4, False))
								RSWIN_DESC.rst.SinkerBar = sinkerBar
								num3 = 0
							ElseIf num5 < 300F And RSWIN_DESC.rst.SinkerBar.length <= num7 Then
								sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num5, num4, False))
								RSWIN_DESC.rst.SinkerBar = sinkerBar
								num3 = 0
							ElseIf num5 >= 600F And RSWIN_DESC.rst.SinkerBar.length >= 50F Then
								sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length - CSng(DESIGN.GetIncrement(num, False, num3, num5, num4, False))
								RSWIN_DESC.rst.SinkerBar = sinkerBar
								num3 = 1
							End If
							length = RSWIN_DESC.rst.SinkerBar.length

					ElseIf Operators.CompareString(sPredictType, "DesignFG", False) = 0 Then
						flag3 = DESIGNFG.DesignFG()
						If Not flag3 Then
							Exit Do
						End If
						Dim num8 As Integer
						Dim flag4 As Boolean = RSWIN.HasFG(num8)
						If num8 = CInt((RSWIN_DESC.rst.NumRods - 1S)) Then
							num7 = 1225F
						ElseIf(RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) Or If(-If((CUSTOMRG.IsOtherSteel(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) > False), 1, 0), 1, 0)) <> 0 Then
							num7 = 800F
						Else
							num7 = 1225F
						End If
						If flag4 And num8 = CInt((RSWIN_DESC.rst.NumRods - 1S)) Then
							num5 = RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
							If num5 >= 1000F Then
								Exit Do
							End If
							sinkerBar.Initialize()
							sinkerBar = RSWIN_DESC.rst.SinkerBar
							If num5 < 1000F And RSWIN_DESC.rst.SinkerBar.length <= num7 Then
								' The following expression was wrapped in a unchecked-expression
								sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num5, num4, True))
								RSWIN_DESC.rst.SinkerBar = sinkerBar
								num3 = 0
							End If
							length = RSWIN_DESC.rst.SinkerBar.length
						Else
							num5 = RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
							Dim num9 As Integer
							Dim stlbotMinStressScore As Boolean = rptExpertSummary.GetSTLBotMinStressScore(num5, num9)
							If RSWIN_DESC.rst.NumRods > 2S Then
								If num8 = CInt((RSWIN_DESC.rst.NumRods - 2S)) Then
									Dim fStress2 As Single = RSWIN_DESC.rst.minStressBot(num8)
									Dim num10 As Integer
									Dim fgbotMinStressScore As Boolean = rptExpertSummary.GetFGBotMinStressScore(fStress2, num10)
								End If

									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									If RSWIN_DESC.rst.RSFGIncludeSteel <> 0S AndAlso (RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) Or If((-If((CUSTOMRG.IsOtherSteel(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) > False), 1, 0)), 1, 0)) <> 0 Then
										If(num5 >= 300F And num5 <= 600F) Or (num4 < 300F And num4 <> -111111F And num5 > 600F) Then
											Exit Do
										End If
										sinkerBar.Initialize()
										sinkerBar = RSWIN_DESC.rst.SinkerBar
										If num4 > 600F And num5 < 300F And RSWIN_DESC.rst.SinkerBar.length <= num7 Then
											sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num5, num4, False))
											RSWIN_DESC.rst.SinkerBar = sinkerBar
											num3 = 0
										ElseIf num4 > 600F And num5 < 300F And RSWIN_DESC.rst.SinkerBar.length <= num7 Then
											sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num5, num4, False))
											RSWIN_DESC.rst.SinkerBar = sinkerBar
											num3 = 0
										ElseIf num5 < 300F And RSWIN_DESC.rst.SinkerBar.length <= num7 Then
											sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length + CSng(DESIGN.GetIncrement(num, True, num3, num5, num4, False))
											RSWIN_DESC.rst.SinkerBar = sinkerBar
											num3 = 0
										ElseIf num5 >= 600F And RSWIN_DESC.rst.SinkerBar.length >= 50F Then
											sinkerBar.length = RSWIN_DESC.rst.SinkerBar.length - CSng(DESIGN.GetIncrement(num, False, num3, num5, num4, False))
											RSWIN_DESC.rst.SinkerBar = sinkerBar
											num3 = 1
										End If
										length = RSWIN_DESC.rst.SinkerBar.length
									End If

							End If
						End If
					End If
					If num6 > 55 Then
						flag = True
					ElseIf num4 = num5 Then
						num2 += 1
						If num2 > 5 Then
							flag = True
						End If
					Else
						num2 = 0
					End If
					num4 = num5
					Application.DoEvents()
					If RSWIN_DESC.rst.SinkerBar.length > num7 And num6 <= 55 And Not flag Then
						If Not flag2 Then
							sinkerBar.length = num7
							RSWIN_DESC.rst.SinkerBar = sinkerBar
							flag = False
							flag2 = True
						Else
							flag = True
						End If
					ElseIf sinkerBar.length < 50F And num6 <= 55 And Not flag Then
						If Not flag2 Then
							sinkerBar.length = 50F
							RSWIN_DESC.rst.SinkerBar = sinkerBar
							flag = False
							flag2 = True
						Else
							flag = True
						End If
					End If
				Loop While Not flag
				If Not RSWIN_DESC.bImprovingScore AndAlso (RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug) Then
					Batch.BatchMessage(String.Concat(New String() { "> Bot. Min. Stress taper above SB end SB design: ", Conversions.ToString(num5), "  , Length=", Conversions.ToString(RSWIN_DESC.rst.SinkerBar.length), "  , count=", Conversions.ToString(num6) }))
				End If
				Application.DoEvents()
				Application.DoEvents()
				result = flag3
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function CheckForNegativeStresses() As Boolean
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = False
			Dim flag5 As Boolean = False
			Dim result As Boolean
			Try
				If RSWIN_DESC.bRodStarD And Not RSWIN_DESC.bQuickFix And RSWIN_DESC.rst.NumRods >= 2S Then
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						' The following expression was wrapped in a unchecked-expression
						If(RODUTIL.IsSinkerBar(i) Or If(-If((CUSTOMRG.IsOtherSinkerBar(CInt(RSWIN_DESC.rst.Sections(i).Grade)) > False), 1, 0), 1, 0)) <> 0 Then
							flag = True
							If i = CInt(RSWIN_DESC.rst.NumRods) Then
								flag4 = True
							End If
						ElseIf RSWIN_DESC.rst.Sections(i).Grade >= 16384S And RSWIN_DESC.rst.Sections(i).Grade < 20480S Then
							flag2 = True
						ElseIf RSWIN_DESC.rst.Sections(i).Grade >= 20480S And RSWIN_DESC.rst.Sections(i).Grade < 24576S Then
							flag3 = True
						End If
					Next
					If(flag AndAlso flag4) And (Not flag2 AndAlso Not flag3) Then
						flag5 = True
						Dim num2 As Integer = 1
						Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For j As Integer = num2 To numRods2
							If RSWIN_DESC.rst.minStressBot(j) >= 0F Then
								flag5 = False
							End If
						Next
					End If
					If flag5 Then
						Util.Message("Second stage calculations in progress! " + RSWIN_DESC.sPleaseWait)
					End If
				End If
				result = flag5
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetIncrement(ByRef iIncr As Integer, bIncrease As Boolean, ByRef iDecrement As Integer, fCurrentStress As Single, fPrevStress As Single, bFGlass As Boolean) As Integer
			Dim result As Integer
			Try
				If fPrevStress <> -111111F Then
					If Not bFGlass Then
						If fCurrentStress < -3000F Or fCurrentStress > 4000F Then
							iIncr = 225
						ElseIf fCurrentStress < -2500F Or fCurrentStress > 3500F Then
							iIncr = 200
						ElseIf fCurrentStress < -2000F Or fCurrentStress > 3000F Then
							iIncr = 175
						ElseIf fCurrentStress < -1500F Or fCurrentStress > 2500F Then
							iIncr = 150
						ElseIf fCurrentStress < -1000F Or fCurrentStress > 2000F Then
							iIncr = 100
						ElseIf fCurrentStress < -500F Or fCurrentStress > 1500F Then
							iIncr = 75
						ElseIf fCurrentStress < 0F Or fCurrentStress > 1000F Then
							iIncr = 50
						ElseIf(fCurrentStress >= 0F And fCurrentStress <= 300F) Or (fCurrentStress >= 600F And fCurrentStress <= 1000F) Then
							iIncr = 25
						End If
					ElseIf fCurrentStress < -3000F Then
						iIncr = 225
					ElseIf fCurrentStress < -2500F Then
						iIncr = 200
					ElseIf fCurrentStress < -2000F Then
						iIncr = 175
					ElseIf fCurrentStress < -1500F Then
						iIncr = 150
					ElseIf fCurrentStress < -1000F Then
						iIncr = 100
					ElseIf fCurrentStress < -500F Then
						iIncr = 75
					ElseIf fCurrentStress < 0F Then
						iIncr = 50
					ElseIf fCurrentStress >= 0F And fCurrentStress <= 400F Then
						iIncr = 25
					End If
				Else
					iIncr = 25
				End If
				If(bIncrease And iDecrement = 1) Or (Not bIncrease And iDecrement = 0) Or iDecrement = -1 Then
					iIncr = 25
				End If
				result = iIncr
			Catch ex As Exception
				result = 25
			End Try
			Return result
		End Function

		Public Function GetInitialSBLength(fCurrentStress As Single) As Integer
			Dim result As Integer
			Try
				If fCurrentStress < -3000F Or fCurrentStress > 4000F Then
					result = 950
				ElseIf fCurrentStress < -2500F Or fCurrentStress > 3500F Then
					result = 900
				ElseIf fCurrentStress < -2000F Or fCurrentStress > 3000F Then
					result = 850
				ElseIf fCurrentStress < -1500F Or fCurrentStress > 2500F Then
					result = 700
				ElseIf fCurrentStress < -1000F Or fCurrentStress > 2000F Then
					result = 600
				ElseIf fCurrentStress < -500F Or fCurrentStress > 1500F Then
					result = 500
				ElseIf fCurrentStress < 0F Or fCurrentStress > 1000F Then
					result = 400
				Else
					result = 200
				End If
			Catch ex As Exception
				result = 200
			End Try
			Return result
		End Function

		Public Sub CheckGuides()
			' The following expression was wrapped in a checked-statement
			Try
				If RSWIN_DESC.rst.RodStringType = 3S And (RSWIN_DESC.rst.giRodDesignStyle = 1S Or RSWIN_DESC.rst.giRodDesignStyle = 0S) Then
					Try
						If RSWIN_DESC.rst.NumRods <> 0S Then
							Dim num As Integer = 1
							Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num To numRods
								If CInt(RSWIN_DESC.rst.Sections(i).Guide) <> RSWIN_DESC.SETUP_GuideToUse Then
									RSWIN_DESC.rst.Sections(i).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
								End If
							Next
						End If
					Catch ex As Exception
					End Try
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub CalculateBuoyedAndUnbouyedStress(bFG As Boolean, ByRef minStressBot_w_buoy As Single(), ByRef maxStressBot_w_buoy As Single(), ByRef minStressTop_w_buoy As Single(), ByRef maxStressTop_w_buoy As Single(), ByRef minStressBot_wo_buoy As Single(), ByRef maxStressBot_wo_buoy As Single(), ByRef minStressTop_wo_buoy As Single(), ByRef maxStressTop_wo_buoy As Single())
			Try
				Dim array As Single()
				Dim array2 As Object()
				Dim array3 As Object()
				Dim rst As cRODSTAR
				array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				array2 = New Object(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				array3 = New Object(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				rst = RSWIN_DESC.rst
				array(0) = 0F
				array2(0) = rst.Pprload - rst.StuffingBoxFriction
				array3(0) = rst.Mprload + rst.StuffingBoxFriction
				Dim num As Single = rst.PumpLoad(1)
				Dim num2 As Single = rst.PumpLoad(1)
				Dim num3 As Short = 1S
				Dim numRods As Short = rst.NumRods
				For num4 As Short = num3 To numRods
					' The following expression was wrapped in a checked-expression
					array(CInt(num4)) = array(CInt((num4 - 1S))) + rst.Sections(CInt(num4)).length
					num = RSWIN_DESC.RLoad_Save(CInt(num4), 1)
					num2 = RSWIN_DESC.RLoad_Save(CInt(num4), 1)
					Dim num5 As Short = 1S
					Dim num6 As Short = rst.Ntsteps - 1S
					For num7 As Short = num5 To num6
						If RSWIN_DESC.RLoad_Save(CInt(num4), CInt(num7)) > num Then
							num = RSWIN_DESC.RLoad_Save(CInt(num4), CInt(num7))
						End If
						If RSWIN_DESC.RLoad_Save(CInt(num4), CInt(num7)) < num2 Then
							num2 = RSWIN_DESC.RLoad_Save(CInt(num4), CInt(num7))
						End If
					Next
					array2(CInt(num4)) = num
					array3(CInt(num4)) = num2
				Next
				If rst.NumRods <> 1S Then
					Dim num8 As Single = 0F
					Dim num9 As Single = 0F
					Dim num10 As Short = 1S
					Dim numRods2 As Short = rst.NumRods
					For num4 As Short = num10 To numRods2
						Dim num11 As Single
						Dim num12 As Single
						num11 = MWDown.EffRodArea(rst.Sections(CInt(num4)), CShort(RODUTIL.IsSinkerBar(CInt(num4))))
						If num4 = 1S Then
							num12 = num11
						Else
							num12 = MWDown.EffRodArea(rst.Sections(CInt((num4 - 1S))), CShort(RODUTIL.IsSinkerBar(CInt((num4 - 1S)))))
							If num12 > num11 Then
								num12 = num11
							End If
						End If
						Dim num13 As Single = CSng(((CDbl(rst.TubingPressure) + 0.433 * CDbl(rst.FluidSPGR) * CDbl(array(CInt((num4 - 1S))))) * CDbl(num12)))
						Dim num14 As Single = CSng(((CDbl(rst.TubingPressure) + 0.433 * CDbl(rst.FluidSPGR) * CDbl(array(CInt(num4)))) * CDbl(num11)))
						maxStressTop_wo_buoy(CInt(num4)) = Conversions.ToSingle(Operators.DivideObject(Operators.AddObject(array2(CInt((num4 - 1S))), num13), num11))
						minStressTop_wo_buoy(CInt(num4)) = Conversions.ToSingle(Operators.DivideObject(Operators.AddObject(array3(CInt((num4 - 1S))), num13), num11))
						maxStressBot_wo_buoy(CInt(num4)) = Conversions.ToSingle(Operators.DivideObject(Operators.AddObject(array2(CInt(num4)), num14), num11))
						minStressBot_wo_buoy(CInt(num4)) = Conversions.ToSingle(Operators.DivideObject(Operators.AddObject(array3(CInt(num4)), num14), num11))
						maxStressTop_w_buoy(CInt(num4)) = Conversions.ToSingle(Operators.DivideObject(Operators.AddObject(array2(CInt((num4 - 1S))), num8), num11))
						minStressTop_w_buoy(CInt(num4)) = Conversions.ToSingle(Operators.DivideObject(Operators.AddObject(array3(CInt((num4 - 1S))), num8), num11))
						maxStressBot_w_buoy(CInt(num4)) = Conversions.ToSingle(Operators.DivideObject(Operators.AddObject(array2(CInt(num4)), num9), num11))
						minStressBot_w_buoy(CInt(num4)) = Conversions.ToSingle(Operators.DivideObject(Operators.AddObject(array3(CInt(num4)), num9), num11))
						If num4 > 1S Then
							If rst.Sections(CInt((num4 - 1S))).Diameter = rst.Sections(CInt(num4)).Diameter And minStressBot_wo_buoy(CInt(num4)) >= minStressTop_wo_buoy(CInt(num4)) Then
								' The following expression was wrapped in a unchecked-expression
								minStressTop_wo_buoy(CInt(num4)) = CSng((CDbl(minStressBot_wo_buoy(CInt(num4))) + CDbl(rst.Sections(CInt(num4)).length) * (CDbl(rst.Sections(CInt(num4)).RodWeight) - 1.07 * (62.4 * CDbl(rst.FluidSPGR) * CDbl(rst.Sections(CInt(num4)).Area) / 144.0)) / CDbl(num11)))
								minStressBot_wo_buoy(CInt((num4 - 1S))) = minStressTop_wo_buoy(CInt(num4))
							End If
							If rst.Sections(CInt((num4 - 1S))).Diameter = rst.Sections(CInt(num4)).Diameter And minStressBot_w_buoy(CInt(num4)) >= minStressTop_w_buoy(CInt(num4)) Then
								' The following expression was wrapped in a unchecked-expression
								minStressTop_w_buoy(CInt(num4)) = CSng((CDbl(minStressBot_w_buoy(CInt(num4))) + CDbl(rst.Sections(CInt(num4)).length) * (CDbl(rst.Sections(CInt(num4)).RodWeight) - 1.07 * (62.4 * CDbl(rst.FluidSPGR) * CDbl(rst.Sections(CInt(num4)).Area) / 144.0)) / CDbl(num11)))
								minStressBot_w_buoy(CInt((num4 - 1S))) = minStressTop_w_buoy(CInt(num4))
							End If
						End If
					Next
					minStressBot_w_buoy(CInt(RSWIN_DESC.rst.NumRods)) = CSng((-CSng((CDbl(rst.FluidSPGR) * 0.433 * CDbl(array(CInt(RSWIN_DESC.rst.NumRods))) * 1.075 + CDbl(rst.TubingPressure)))))
					minStressBot_wo_buoy(CInt(RSWIN_DESC.rst.NumRods)) = 0F
					minStressBot_w_buoy(CInt(RSWIN_DESC.rst.NumRods)) = minStressBot_w_buoy(CInt(RSWIN_DESC.rst.NumRods)) - rst.PumpFriction / rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Area
					minStressBot_wo_buoy(CInt(RSWIN_DESC.rst.NumRods)) = minStressBot_wo_buoy(CInt(RSWIN_DESC.rst.NumRods)) - rst.PumpFriction / rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Area
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub CheckSinkerBar()
			Try
				If RSWIN_DESC.rst.RSIncludeSB <> 0S AndAlso (RSWIN_DESC.rst.SinkerBar.RodDensity = 0F Or RSWIN_DESC.rst.SinkerBar.Elasticity = 0F Or RSWIN_DESC.rst.SinkerBar.RodWeight = 0F Or RSWIN_DESC.rst.SinkerBar.TensileStrength = 0F) Then
					Dim sinkerBar As RSWIN_DESC.RodSection
					sinkerBar.Initialize()
					sinkerBar = RSWIN_DESC.rst.SinkerBar
					If sinkerBar.RodDensity = 0F Then
						sinkerBar.RodDensity = 491F
					End If
					If sinkerBar.Elasticity = 0F Then
						sinkerBar.Elasticity = RODUTIL.LookupElasticity(sinkerBar.Grade)
					End If
					If sinkerBar.RodWeight = 0F Then
						sinkerBar.RodWeight = RODUTIL.LookupRodWeight(sinkerBar.Grade, sinkerBar.Diameter)
					End If
					If sinkerBar.TensileStrength = 0F Then
						sinkerBar.TensileStrength = RODUTIL.LookupTensileStrength(CSng(sinkerBar.Grade))
					End If
					If(If((-If((RODUTIL.IsCorod(sinkerBar.Grade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(sinkerBar.Grade))) <> 0 Then
						sinkerBar.SuckerRodLength = 1F
					ElseIf RODUTIL.IsSteel(CInt(sinkerBar.Grade)) <> 0 Then
						sinkerBar.SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
					End If
					sinkerBar.friction_coef = RSWIN_DESC.rst.RSFricCoef
					sinkerBar.Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
					RSWIN_DESC.rst.SinkerBar = sinkerBar
					If RSWIN_DESC.rst.RSSBGrade = 0S Then
						RSWIN_DESC.rst.RSSBGrade = RSWIN_DESC.rst.SinkerBar.Grade
					End If
					If RSWIN_DESC.rst.RSSBDiameter = 0F Then
						RSWIN_DESC.rst.RSSBDiameter = RSWIN_DESC.rst.SinkerBar.Diameter
					End If
					If RSWIN_DESC.rst.RSSBLength = 0F Then
						RSWIN_DESC.rst.RSSBLength = RSWIN_DESC.rst.SinkerBar.length
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetSBMaxLength(ByRef bIncsOK As Boolean) As Single
			' The following expression was wrapped in a checked-statement
			Dim result As Single
			Try
				Dim pumpDepth As Single = RSWIN_DESC.rst.PumpDepth
				Dim dataView As DataView = New DataView(RSWIN_DESC.mdsDeviationProfile.Tables(0))
				Dim pumpDepth2 As Single = RSWIN_DESC.rst.PumpDepth
				Dim setup_SteelSuckerRodLength As Single = RSWIN_DESC.SETUP_SteelSuckerRodLength
				Dim num As Single = 0F
				Dim count As Integer = RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count
				If count <= 2 Then
					result = pumpDepth
				Else
					If RSWIN_DESC.SETUP_SteelSuckerRodLength = 30F Then
					End If
					If RSWIN_DESC.rst.giRodDesignStyle = 0S Then
						DESIGNST.BuildInitialSteelString()
					Else
						DESIGNFG.BuildInitialFGString()
					End If
					Dim num2 As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num2 To numRods
						Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
						Dim num3 As Integer = i

							Try
								If sections(num3).Elasticity = 0F Then
									RODUTIL.LookupElasticity(RSWIN_DESC.rst.Sections(i))
								End If
								If sections(num3).Area = 0F Then
									sections(num3).Area = CSng((3.141592653589793 * Math.Pow(CDbl(sections(num3).Diameter), 2.0) / 4.0))
								End If
								Try
									RODUTIL.LookupRodWeight(RSWIN_DESC.rst.Sections(i))
								Catch ex As Exception
								End Try
								If sections(num3).TensileStrength = 0F Then
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(i))
								End If
								If sections(num3).RodDensity = 0F Then
									If sections(num3).Grade = 20481S Then
										sections(num3).RodDensity = 100F
									ElseIf sections(num3).Grade = 16393S Then
										sections(num3).RodDensity = 125F
									ElseIf RODUTIL.IsFG(sections(num3).Grade) Then
										sections(num3).RodDensity = 130F
									Else
										sections(num3).RodDensity = 491F
									End If
								End If
							Catch ex2 As Exception
							End Try
							Try
								Dim num4 As Single
								If(If((-If((RODUTIL.IsCorod(sections(num3).Grade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(sections(num3).Grade))) <> 0 Then
									num4 = 1F
								Else
									num4 = 1.07F
								End If
								RSWIN_DESC.rst.WrodsInFluid = CSng((CDbl(RSWIN_DESC.rst.WrodsInFluid) + CDbl(sections(num3).length) * (CDbl(sections(num3).RodWeight) - CDbl(num4) * (62.4 * CDbl(RSWIN_DESC.rst.FluidSPGR) * CDbl(sections(num3).Area) / 144.0))))
								RSWIN_DESC.rst.RodstringL = RSWIN_DESC.rst.RodstringL + sections(num3).length
							Catch ex3 As Exception
							End Try

					Next
					bIncsOK = True
					Dim flag As Boolean = PREDICT.Predict(True, "DesignSteel")
					If flag Then
						Try
							RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
							RSWIN_DESC.taper_lens(0) = 0F
							Dim num5 As Integer = 1
							Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num5 To numRods2
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								RSWIN_DESC.taper_lens(i) = RSWIN_DESC.taper_lens(i - 1) + RSWIN_DESC.rst.Sections(i).length
							Next
						Catch ex4 As Exception
						End Try
						Dim impredObj As TEImpred = MImpred.ImpredObj
						pumpDepth2 = RSWIN_DESC.rst.PumpDepth
						Dim num6 As Single = 0F
						Dim num7 As Single = 0F
						bIncsOK = True
						Dim num8 As Integer = 0
						Dim num9 As Integer = impredObj.num_rod_elements - 1
						For i As Integer = num8 To num9
							Dim num10 As Single = CSng(impredObj.get_r_e(i + 1).m_d)
							Dim num11 As Single = CSng((impredObj.get_r_e(i + 1).inc * 180.0 / 3.141592653589793))
							Dim num12 As Single = CSng(impredObj.get_r_e(i + 1).azi)
							Dim num13 As Single = CSng(impredObj.get_r_e(i + 1).length)

								If num11 <= RSWIN_DESC.Setup_fInclinationLimit And (num10 <= pumpDepth2 And num10 > pumpDepth2 / 2F) Then
									If num6 = 0F Then
										num6 = num10
									End If
									If num6 <> 0F Then
										num7 = num10
									End If
									If num6 <> 0F And num7 <> 0F Then
										If num < num7 - num6 Then
											num = num7 - num6
										End If
									End If
								ElseIf num11 > RSWIN_DESC.Setup_fInclinationLimit Then
									bIncsOK = False
									num6 = 0F
									num7 = 0F
								End If

						Next
						result = num
					Else
						result = pumpDepth
					End If
				End If
			Catch ex5 As Exception
				result = RSWIN_DESC.rst.PumpDepth
			End Try
			Return result
		End Function

		Public Function Check_Inclination_from_Survey(fSBLength As Single, fDepth As Single, ByRef fFirstOverDepth As Single) As Boolean
			Dim result As Boolean
			Try
				Dim dataView As DataView = New DataView(RSWIN_DESC.mdsDeviationProfile.Tables(0))
				Dim flag As Boolean = True
				Dim count As Integer = RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count
				fFirstOverDepth = 0F
				Dim num As Single = fDepth - fSBLength
				If count > 2 And num > 0F Then
					Try
						For Each obj As Object In dataView
							Dim dataRowView As DataRowView = CType(obj, DataRowView)
							Dim row As DataRow = dataRowView.Row
							Dim num2 As Single = CSng(Convert.ToDouble(RuntimeHelpers.GetObjectValue(row(1))))
							Dim value As String = MImpred.InclinationCheck(Conversions.ToString(row(2)))
							Dim num3 As Single = CSng(Convert.ToDouble(value))
							If num3 > RSWIN_DESC.Setup_fInclinationLimit And fFirstOverDepth = 0F Then
								fFirstOverDepth = num2
							End If
							If(num2 >= num And num2 <= fDepth) AndAlso num3 > RSWIN_DESC.Setup_fInclinationLimit Then
								flag = False
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function GetDepthFromInclination(ByRef fSaveSBLength As Single, ByRef fNewSBLength As Single, ByRef bIncsOK As Boolean) As Single
			Dim result As Single
			Try
				Dim num As Single = RSWIN_DESC.rst.PumpDepth
				Dim dataView As DataView = New DataView(RSWIN_DESC.mdsDeviationProfile.Tables(0))
				Dim num2 As Single = RSWIN_DESC.rst.PumpDepth
				Dim flag As Boolean = True
				Dim num3 As Single = RSWIN_DESC.SETUP_SteelSuckerRodLength
				Dim num4 As Single = 150F
				Dim num5 As Single = 0F
				Dim count As Integer = RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count
				If count <= 2 Then
					result = num
				Else
					If RSWIN_DESC.SETUP_SteelSuckerRodLength = 30F Then
						num3 = 20F
					Else
						num3 = 25F
					End If
					bIncsOK = True
					Dim impredObj As TEImpred = MImpred.ImpredObj
					flag = True
					Dim sinkerBar As RSWIN_DESC.RodSection
					While flag
						Dim num6 As Integer = 0
						num2 = RSWIN_DESC.rst.PumpDepth
						Dim flag2 As Boolean = True
						While flag2
							bIncsOK = True
							Dim flag3 As Boolean = False
							Dim num7 As Single = 0F
							For i As Integer = impredObj.num_rod_elements - 1 To 0 Step -1
								Dim num8 As Single = CSng(impredObj.get_r_e(i + 1).m_d)
								Dim num9 As Single = CSng((impredObj.get_r_e(i + 1).inc * 180.0 / 3.141592653589793))
								Dim num10 As Single = CSng(impredObj.get_r_e(i + 1).azi)
								Dim num11 As Single = CSng(impredObj.get_r_e(i + 1).length)
								If num9 > RSWIN_DESC.Setup_fInclinationLimit And Not flag3 Then
									flag3 = True
								End If
								Dim num12 As Single
								If num9 <= RSWIN_DESC.Setup_fInclinationLimit And (num8 <= num2 And num8 > 0F) Then
									' The following expression was wrapped in a unchecked-expression
									If i = impredObj.num_rod_elements - 2 And (num9 <= RSWIN_DESC.Setup_fInclinationLimit And num12 <= RSWIN_DESC.Setup_fInclinationLimit) And num7 <> 0F And num7 - num8 >= fSaveSBLength Then
										num6 = i + 2
										num = RSWIN_DESC.rst.PumpDepth
										bIncsOK = True
										Return num
									End If
									If num8 <= RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.rst.SinkerBar.length And Not flag3 Then
										num6 = i + 2
										num = RSWIN_DESC.rst.PumpDepth
										bIncsOK = True
										Return num
									End If
									If num8 <= num2 - RSWIN_DESC.rst.SinkerBar.length Then
										num6 = i + 1
										num = num8
										Exit For
									End If
								ElseIf num9 > RSWIN_DESC.Setup_fInclinationLimit Then
									bIncsOK = False
								End If
								num7 = num8
								num12 = num9
							Next
							Dim flag4 As Boolean = DESIGN.Check_Inclination_from_Survey(RSWIN_DESC.rst.SinkerBar.length, num2, num5)
							If num5 > 0F And bIncsOK Then
								bIncsOK = False
							End If
							If num < RSWIN_DESC.rst.PumpDepth / 2F Or num >= num2 Then
								num = RSWIN_DESC.rst.PumpDepth
								flag2 = False
							ElseIf bIncsOK Then
								num = RSWIN_DESC.rst.PumpDepth
								flag2 = False
							Else
								Dim num13 As Single = num
								Dim num14 As Single = num13 + RSWIN_DESC.rst.SinkerBar.length
								flag2 = False
								Dim flag5 As Boolean = False
								Dim num15 As Integer = 0
								Dim num16 As Integer = impredObj.num_rod_elements - 1
								For i As Integer = num15 To num16
									Dim num8 As Single = CSng(impredObj.get_r_e(i + 1).m_d)
									Dim num11 As Single = CSng(impredObj.get_r_e(i + 1).length)

										If num8 >= num13 And num8 < num14 Then
											' The following expression was wrapped in a checked-expression
											Dim num9 As Single = CSng((impredObj.get_r_e(i + 1).inc * 180.0 / 3.141592653589793))
											If num8 > 0F And num9 > RSWIN_DESC.Setup_fInclinationLimit Then
												flag5 = True
												flag2 = True
												num2 -= num11
												Exit For
											End If
											If num8 >= num5 And num9 > RSWIN_DESC.Setup_fInclinationLimit - 1F Then
												If Not DESIGN.Check_Inclination_from_Survey(RSWIN_DESC.rst.SinkerBar.length, num2, num5) Then
													flag5 = True
													flag2 = True
													num2 -= num11
													Exit For
												End If
											ElseIf(num8 >= num5 And num9 <= RSWIN_DESC.Setup_fInclinationLimit - 1F) AndAlso Not DESIGN.Check_Inclination_from_Survey(RSWIN_DESC.rst.SinkerBar.length, num2, num5) Then
												flag5 = True
												flag2 = True
												num2 -= num11
												Exit For
											End If
										End If

								Next
								If Not flag5 Then
									Dim num17 As Single
									Try
										num17 = 0F
										If num6 > 0 AndAlso impredObj.get_r_e(num6).length > CDbl(num3) Then
											num17 = num3
										End If
									Catch ex As Exception
										num17 = 0F
									End Try
									num = num + RSWIN_DESC.rst.SinkerBar.length - num17
									Exit While
								End If
							End If
						End While
						If num <> RSWIN_DESC.rst.PumpDepth Then
							flag = False
						ElseIf num = RSWIN_DESC.rst.PumpDepth And bIncsOK Then
							flag = False
						Else
							fNewSBLength -= num3
							If fNewSBLength < num4 Then
								flag = False
							Else
								sinkerBar.Initialize()
								sinkerBar = RSWIN_DESC.rst.SinkerBar
								sinkerBar.length = fNewSBLength
								RSWIN_DESC.rst.SinkerBar = sinkerBar
							End If
						End If
					End While
					If num >= RSWIN_DESC.rst.PumpDepth Then
						num = RSWIN_DESC.rst.PumpDepth
						If RSWIN_DESC.rst.SinkerBar.length <> fSaveSBLength Then
							sinkerBar.Initialize()
							sinkerBar = RSWIN_DESC.rst.SinkerBar
							sinkerBar.length = fSaveSBLength
							RSWIN_DESC.rst.SinkerBar = sinkerBar
						End If
					End If
					result = num
				End If
			Catch ex2 As Exception
				result = RSWIN_DESC.rst.PumpDepth
			End Try
			Return result
		End Function

		Public Function AddTaperBelowSinkerBar(fLength As Single) As Boolean
			Dim result As Boolean
			Try
				Dim array As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
				Dim flag As Boolean = False
				If RSWIN_DESC.rst.NumRods > 1S AndAlso (CInt(RSWIN_DESC.rst.RSIncludeSB) Or (RODUTIL.IsSinkerBar(CInt(RSWIN_DESC.rst.NumRods)) Or If((-If((CUSTOMRG.IsOtherSinkerBar(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) > False), 1, 0)), 1, 0))) <> 0 Then
					Dim rodSection As RSWIN_DESC.RodSection
					rodSection.Initialize()
					rodSection = RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S)))
					rodSection.length = fLength
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						array(i).Initialize()
						array(i) = RSWIN_DESC.rst.Sections(i)
					Next
					array(CInt((RSWIN_DESC.rst.NumRods + 1S))) = rodSection
					Dim sections As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
					RSWIN_DESC.rst.Sections = sections
					RSWIN_DESC.rst.NumRods = RSWIN_DESC.rst.NumRods + 1S
					Dim num2 As Integer = 1
					Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num2 To numRods2
						RSWIN_DESC.rst.Sections(i).Initialize()
						RSWIN_DESC.rst.Sections(i) = array(i)
					Next
					flag = True
				End If
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private bFGStringOverloaded As Short

		Private lCount As Short

		Private sInvalidProd As String = "Invalid target production and IPR data not specified!"

		Private sIPRMust As String = "You must enter IPR data to be able to calculate the pump condition."

		Private sTotalDepth1 As String = Util.AssignValueToConstant("RSInput", "sTotalDepth1", "Total of rod taper lengths cannot be greater than pump depth. Please check input data. ")

		Private sTotalDepth2 As String = Util.AssignValueToConstant("RSInput", "sTotalDepth2", "Total of rod taper lengths cannot be less than pump depth. Please check input data. ")

		Private sTooShort As String = Util.AssignValueToConstant("RSInput", "sTooShort", "Each rod taper length much be at least equal to standard steel sucker rod length. Please check input data. ")

		Private sEnterStringDesign As String = Util.AssignValueToConstant("RSInput", "sEnterStringDesign", "Rod string design must be entered. Please review input.")

		Private sRODSTARDSurveyRequired As String = Util.AssignValueToConstant("RSInput", "sRODSTARDSurveyRequired", "RODSTAR-D requires an entered Deviation Profile Survey. Please check input data. ")

		Private sSinkerBarWarning As String = "In Setup you specified that sinker bars are to be used only where the inclination is {0} degrees or less. The deviation profile of this well exceeds this limit and therefore sinker bars cannot be used unless entered manually or the limit in Setup is changed."

		Private diams As Single()

		Public SSResults As Short() = New Short(9) {}

		Private m_fIncr As Single

		Private $STATIC$Design$002$bProductionMessageShown As Boolean
	End Module
End Namespace
