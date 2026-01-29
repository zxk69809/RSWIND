Imports System
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module DESIGNST
		Public Property RSMax As Short
			Get
				Return DESIGNST.m_RSMax
			End Get
			Set(value As Short)
				DESIGNST.m_RSMax = value
			End Set
		End Property

		Public Property RSMin As Short
			Get
				Return DESIGNST.m_RSMin
			End Get
			Set(value As Short)
				DESIGNST.m_RSMin = value
			End Set
		End Property

		Public Function BalanceSteelString() As Boolean
			Dim num As Integer
			Dim flag3 As Boolean
			Dim num14 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim flag As Boolean = True
				If rst.NumRods = 1S Then
					flag = True
				Else
					Dim num2 As Short
					If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
						If(If((-If((RODUTIL.IsCorod(rst.RSGrade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(rst.RSGrade))) <> 0 Then
							num2 = 10S
						Else
							num2 = 10S
						End If
					ElseIf(If((-If((RODUTIL.IsCorod(rst.RSGrade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(rst.RSGrade))) <> 0 Then
						num2 = 30S
					Else
						num2 = 20S
					End If
					Dim num3 As Short = Conversions.ToShort(Interaction.IIf(rst.giRodDesignStyle = 0S, 1, 2))
					Dim num4 As Short
					Dim num5 As Short
					Dim num6 As Short
					num4 = Conversions.ToShort(Interaction.IIf(rst.RSIncludeSB <> 0S, CInt((rst.NumRods - 1S)), rst.NumRods))
					If(rst.RSIncludeSB And If(-If((RSWIN_DESC.bSinkerBarDepthChanged > False), 1S, 0S), 1S, 0S)) <> 0S Then
						If RSWIN_DESC.fNewTaperLength = 0F Then
							num4 = rst.NumRods - 1S
						Else
							num4 = rst.NumRods - 2S
						End If
					End If
					num5 = 1S
					num6 = num2
					Dim num7 As Short
					Dim flag2 As Boolean
					num7 = num5
					While num7 <= num6
						flag2 = False
						Dim num8 As Single = rst.PumpDepth
						If rst.RSIncludeSB <> 0S Then
							If Not RSWIN_DESC.bSinkerBarDepthChanged Then
								num8 -= rst.SinkerBar.length
							ElseIf RSWIN_DESC.fNewTaperLength = 0F Then
								num8 -= rst.SinkerBar.length
							Else
								num8 = num8 - rst.SinkerBar.length - RSWIN_DESC.fNewTaperLength
							End If
						End If
						If rst.giRodDesignStyle <> 0S Then
							num8 -= rst.Sections(1).length
						End If
						Dim num9 As Short = num3
						Dim num10 As Short = num4 - 1S
						For num11 As Short = num9 To num10
							' The following expression was wrapped in a checked-expression
							If CDbl(Math.Abs(rst.StressL(CInt((num11 + 1S))) - rst.StressL(CInt(num11)))) > 0.0045 Then
								Dim num12 As Single
								If num7 < CShort(Math.Round(CDbl(num2) / 2.0)) Then
									' The following expression was wrapped in a checked-expression
									num12 = 1F + 3F * (rst.StressL(CInt((num11 + 1S))) - rst.StressL(CInt(num11)))
								Else
									' The following expression was wrapped in a checked-expression
									num12 = 1F + 2F * (rst.StressL(CInt((num11 + 1S))) - rst.StressL(CInt(num11)))
								End If
								If num12 <= 0F Then
									num12 = 0.5F
								End If
								rst.Sections(CInt(num11)).length = rst.Sections(CInt(num11)).length * num12
								flag2 = True
							End If
						Next
						If flag2 Then
							RODUTIL.RoundSectionLengths(num3, num4, num8)
							If rst.Sections(CInt(num4)).length < 100F Then
								Select Case rst.giRodDesignStyle
									Case 0S
										DESIGNST.RemoveBottomSteelSection()
									Case 1S
										DESIGNFG.FGRemoveBottomSteelSection()
								End Select
								flag = False
								flag3 = flag
								GoTo IL_47D
							End If
							If rst.Sections(CInt(num3)).length < 50F AndAlso rst.giRodDesignStyle = 0S Then
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								rst.Sections(CInt((num3 + 1S))).length = rst.Sections(CInt((num3 + 1S))).length + rst.Sections(CInt(num3)).length
								Dim num13 As Short = num3 + 1S
								Dim numRods As Short = rst.NumRods
								For num11 As Short = num13 To numRods
									' The following expression was wrapped in a checked-expression
									rst.Sections(CInt((num11 - 1S))) = rst.Sections(CInt(num11))
								Next
								rst.NumRods -= 1S
								flag = False
								flag3 = flag
								GoTo IL_47D
							End If
							DESIGN.CalcRodStringValues()
							flag = PREDICT.Predict(True, "BalanceSteelString")
							If flag Then
								MWDown.StressAnalysis()
							End If
						End If
						If Not flag Then
							Exit While
						End If
						If Not flag2 Then
							Exit While
						End If
						num7 += 1S
					End While
					If Not flag Then
						flag = False
						flag3 = flag
						GoTo IL_47D
					End If
					If num7 > num2 Then
						flag = True
					Else
						If rst.giRodDesignStyle = 0S And rst.StressL(CInt(num3)) + 0.005F > RSWIN_DESC.SETUP_MaxSteelLoading Then
							flag2 = DESIGNST.BuildLargerSteelString()
						End If
						flag = Not flag2
					End If
				End If
				flag3 = flag
				IL_436:
				GoTo IL_47D
				IL_438:
				num14 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_44E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num14 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_438
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_47D:
			Dim result As Boolean = flag3
			If num14 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Function DesignSteel() As Object
			Dim num As Single = 0F
			Dim flag As Boolean = False
			Dim num2 As Integer = 50
			Dim num3 As Integer = 5
			Dim flag2 As Boolean = False
			Dim result As Object
			Try
				If RSWIN_DESC.bRodStarD AndAlso (RSWIN_DESC.rst.RSIncludeSB And If((-If((RSWIN_DESC.rst.RSMaxSize <= RSWIN_DESC.rst.RSSBDiameter > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					flag2 = True
				End If
				RSWIN_DESC.bChangeSPM = False
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num4 As Short = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
				DESIGNST.BuildInitialSteelString()
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				Dim flag4 As Boolean
				While True
					num5 += 1
					Dim num7 As Integer = 0
					While True
						num7 += 1
						Dim num8 As Integer = 0
						Dim flag3 As Boolean
						Do
							num8 += 1
							DESIGN.ProcessRodString(True)
							flag3 = False
							If RSWIN_DESC.bRodStarD Then
								flag4 = PREDICT.Predict(True, "DesignSteel")
								If flag4 And RSWIN_DESC.bDoNegativeStressCheck Then
									If DESIGN.CheckForNegativeStresses() Then
										flag4 = PREDICT.Predict(True, "DesignSteel")
									End If
								End If
							ElseIf rst.SPMEntered <> 0S Then
								flag4 = PREDICT.Predict(True, "DesignSteel")
							Else
								flag4 = DESIGN.CheckProduction()
								If Not flag4 Then
									GoTo IL_119
								End If
								flag4 = PREDICT.Predict(True, "DesignSteel")
							End If
							If RSWIN_DESC.bChangeSPM Then
								Exit Do
							End If
							If Not flag4 Then
								Exit Do
							End If
							MWDown.StressAnalysis()
							If RSWIN_DESC.SETUP_UseAllDiameters And rst.giRodDesignStyle = 0S And Not(RSWIN_DESC.bExpert And RSWIN_DESC.bXRODAdmin) Then
								flag3 = False
							ElseIf rst.StressL(1) + 0.005F > RSWIN_DESC.SETUP_MaxSteelLoading Then
								flag3 = DESIGNST.BuildLargerSteelString()
							End If
							Application.DoEvents()
						Loop While flag3
						IL_17F:
						If(Not flag4 OrElse flag) Or RSWIN_DESC.bChangeSPM Then
							Exit For
						End If
						If Not rst.SPMEntered <> 0S Then
							Dim flag5 As Boolean = True
							Dim spm As Single
							If flag5 Then
								spm = rst.SPM
							End If
							DESIGN.ProcessRodString(False)
							If flag5 Then
								rst.SPM = spm
							End If
							flag4 = DESIGN.CheckProduction()
							If Not flag4 Then
								GoTo IL_202
							End If
							flag4 = PREDICT.Predict(True, "DesignSteel")
							If flag4 And RSWIN_DESC.bRodStarD And RSWIN_DESC.bDoNegativeStressCheck Then
								If DESIGN.CheckForNegativeStresses() Then
									flag4 = PREDICT.Predict(True, "DesignSteel")
								End If
							End If
							If Not flag4 Then
								Exit For
							End If
							MWDown.StressAnalysis()
						End If
						Application.DoEvents()
						Application.DoEvents()
						If DESIGNST.BalanceSteelString() Then
							Exit For
						End If
						Continue For
						IL_119:
						flag = True
						GoTo IL_17F
					End While
					IL_224:
					If flag Or RSWIN_DESC.bChangeSPM Then
						Exit For
					End If
					Dim flag7 As Boolean
					If rst.StressL(1) > RSWIN_DESC.SETUP_MaxSteelLoading Then
						Dim flag6 As Boolean = DESIGNST.CheckIfMaxDiameterReached(rst.RSGrade, rst.RSMaxSize)
						flag7 = Not(flag6 And num = rst.StressL(1))
					Else
						flag7 = False
					End If
					num = rst.StressL(1)
					If flag2 Then
						num6 += 1
						If num6 > num3 Then
							flag7 = False
						End If
					ElseIf num5 > num2 Then
						flag7 = False
					End If
					If Not flag7 Then
						Exit For
					End If
					Continue For
					GoTo IL_224
					IL_202:
					flag = True
					GoTo IL_224
				End While
				Application.DoEvents()
				Application.DoEvents()
				If flag Or RSWIN_DESC.bChangeSPM Then
					result = False
				Else
					If flag4 Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						num4 = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
						Dim pumpPos As Single() = rst.PumpPos
						Dim num9 As Single = 0F
						Dim num10 As Single = 0F
						Dim num11 As Single
						Dim num12 As Single
						Util.Maxmin(pumpPos, num11, num12, num9, num10)

							rst.GrossPumpStroke = num11 - num12
							If(If((-If(((rst.BPDsurface = 0F Or Not RSWIN_DESC.bRodStarD) > False), 1S, 0S)), 1S, 0S) Or (If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.SETUP_UseImpred)) <> 0S Then
								rst.BPDsurface = RUNCALC.BPDsurf(rst.GrossPumpStroke - rst.TubStretch, rst.SPM, rst.PlungerSize, rst.Pfill) * rst.Runtime / 24F
							End If
							If RSWIN_DESC.rst.PumpCondition = 2S Or RSWIN_DESC.rst.PumpCondition = 3S Then
								RSWIN_DESC.rst.BPDsurface = RSWIN_DESC.rst.BPDsurface * RSWIN_DESC.rst.PumpEfficiency / 100F
							End If
							rst.ProductionLoss = RUNCALC.BPDsurf(rst.TubStretch, rst.SPM, rst.PlungerSize, rst.Pfill) * rst.Runtime / 24F

						num4 = CShort(Math.Round(CDbl(Conversion.Int(VBMath.Rnd() * CSng((Information.UBound(DESIGN.SSResults, 1) + 1))))))
					End If
					If Not(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) Then
						flag4 = Verify.VerifyPumpStroke()
					End If
					result = flag4
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub BuildInitialSteelString()
			Dim array As String() = New String(1) {}
			Dim array2 As String() = New String(0) {}
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				If RODUTIL.IsCorod(cRODSTAR.RSGrade) Then
					Try
						Dim rsgrade As Short = cRODSTAR.RSGrade
						COSTDB.GetDIAMSfromThetaStdInfo(rsgrade, array, DESIGNST.diams, RSWIN_DESC.nItems, True)
						DESIGNST.nDiams = RSWIN_DESC.nItems
					Catch ex As Exception
						RSWIN_DESC.nItems = 0S
					End Try
					If RSWIN_DESC.nItems = 0S Then
						Dim rsgrade2 As Short = cRODSTAR.RSGrade
						If rsgrade2 = 13057S Then
							DESIGNST.nDiams = 2S
							DESIGNST.diams = New Single(CInt((DESIGNST.nDiams + 1S)) - 1) {}

								DESIGNST.diams(1) = CSng((2.0 * Math.Sqrt(0.21708734237734525)))
								DESIGNST.diams(2) = CSng((2.0 * Math.Sqrt(0.24096058384112956)))

						ElseIf rsgrade2 = 12801S Then
							DESIGNST.nDiams = 4S
							DESIGNST.diams = New Single(CInt((DESIGNST.nDiams + 1S)) - 1) {}
							DESIGNST.diams(1) = 0.8125F
							DESIGNST.diams(2) = 0.875F
							DESIGNST.diams(3) = 0.9375F
							DESIGNST.diams(4) = 1F
						ElseIf rsgrade2 = 12802S Then
							DESIGNST.nDiams = 4S
							DESIGNST.diams = New Single(CInt((DESIGNST.nDiams + 1S)) - 1) {}
							DESIGNST.diams(1) = 0.8125F
							DESIGNST.diams(2) = 0.875F
							DESIGNST.diams(3) = 0.9375F
							DESIGNST.diams(4) = 1F
						ElseIf rsgrade2 = 24581S OrElse rsgrade2 = 24582S Then
							DESIGNST.nDiams = 4S
							DESIGNST.diams = New Single(CInt((DESIGNST.nDiams + 1S)) - 1) {}
							DESIGNST.diams(1) = 0.8125F
							DESIGNST.diams(2) = 0.875F
							DESIGNST.diams(3) = 1F
							DESIGNST.diams(4) = 1.125F
						Else
							DESIGNST.nDiams = 7S
							DESIGNST.diams = New Single(CInt((DESIGNST.nDiams + 1S)) - 1) {}
							DESIGNST.diams(1) = 0.75F
							DESIGNST.diams(2) = 0.8125F
							DESIGNST.diams(3) = 0.875F
							DESIGNST.diams(4) = 0.9375F
							DESIGNST.diams(5) = 1F
							DESIGNST.diams(6) = 1.0625F
							DESIGNST.diams(7) = 1.125F
						End If
					End If
					If Not RSWIN_DESC.SETUP_UseAllDiameters Then
						Dim num As Integer = 1
						Dim num2 As Integer = CInt(DESIGNST.nDiams)
						For i As Integer = num To num2
							If cRODSTAR.RSMinSize = DESIGNST.diams(i) Then
								DESIGNST.RSMin = CShort(i)
								DESIGNST.RSMax = CShort(i)
								Exit For
							End If
						Next
					Else
						Dim flag As Boolean = False
						Dim flag2 As Boolean = False
						Dim num3 As Integer = 1
						Dim num4 As Integer = CInt(DESIGNST.nDiams)
						For i As Integer = num3 To num4
							If cRODSTAR.RSMinSize = DESIGNST.diams(i) And Not flag Then
								DESIGNST.RSMin = CShort(i)
								flag = True
							End If
							If cRODSTAR.RSMaxSize = DESIGNST.diams(i) And Not flag2 Then
								DESIGNST.RSMax = CShort(i)
								flag2 = True
							End If
						Next
					End If
					Debug.WriteLine(Conversions.ToString(CInt(DESIGNST.RSMin)) + " , " + Conversions.ToString(CInt(DESIGNST.RSMax)))
				ElseIf RODUTIL.IsProRod(CInt(cRODSTAR.RSGrade)) <> 0 Then
					Try
						Dim rsgrade As Short = cRODSTAR.RSGrade
						COSTDB.GetDIAMSfromThetaStdInfo(rsgrade, array, DESIGNST.diams, RSWIN_DESC.nItems, True)
						DESIGNST.nDiams = RSWIN_DESC.nItems
					Catch ex2 As Exception
						RSWIN_DESC.nItems = 0S
					End Try
					If RSWIN_DESC.nItems = 0S Then
						If cRODSTAR.RSGrade <> 24581S And cRODSTAR.RSGrade <> 24582S Then
							DESIGNST.nDiams = 5S
							DESIGNST.diams = New Single(CInt((DESIGNST.nDiams + 1S)) - 1) {}
							DESIGNST.diams(1) = 0.8125F
							DESIGNST.diams(2) = 0.875F
							DESIGNST.diams(3) = 1F
							DESIGNST.diams(4) = 1.0625F
							DESIGNST.diams(5) = 1.125F
						Else
							DESIGNST.nDiams = 4S
							DESIGNST.diams = New Single(CInt((DESIGNST.nDiams + 1S)) - 1) {}
							DESIGNST.diams(1) = 0.8125F
							DESIGNST.diams(2) = 0.875F
							DESIGNST.diams(3) = 1F
							DESIGNST.diams(4) = 1.125F
						End If
					End If
					If Not RSWIN_DESC.SETUP_UseAllDiameters Then
						Dim num5 As Integer = 1
						Dim num6 As Integer = CInt(DESIGNST.nDiams)
						For i As Integer = num5 To num6
							If cRODSTAR.RSMinSize = DESIGNST.diams(i) Then
								DESIGNST.RSMin = CShort(i)
								DESIGNST.RSMax = CShort(i)
								Exit For
							End If
						Next
					Else
						Dim flag As Boolean = False
						Dim flag2 As Boolean = False
						Dim num7 As Integer = 1
						Dim num8 As Integer = CInt(DESIGNST.nDiams)
						For i As Integer = num7 To num8
							If cRODSTAR.RSMinSize = DESIGNST.diams(i) And Not flag Then
								DESIGNST.RSMin = CShort(i)
								flag = True
							End If
							If cRODSTAR.RSMaxSize = DESIGNST.diams(i) And Not flag2 Then
								DESIGNST.RSMax = CShort(i)
								flag2 = True
							End If
						Next
					End If
				Else
					' The following expression was wrapped in a unchecked-expression
					DESIGNST.RSMin = CShort(Math.Round(CDbl((8F * cRODSTAR.RSMinSize))))
					If Not(RSWIN_DESC.bExpert And RSWIN_DESC.bXRODAdmin) And RSWIN_DESC.SETUP_UseAllDiameters And cRODSTAR.giRodDesignStyle = 0S Then
						' The following expression was wrapped in a unchecked-expression
						DESIGNST.RSMax = CShort(Math.Round(CDbl((8F * cRODSTAR.RSMaxSize))))
					Else
						' The following expression was wrapped in a unchecked-expression
						DESIGNST.RSMax = CShort(Math.Round(CDbl((8F * cRODSTAR.RSMinSize))))
					End If
				End If
				cRODSTAR = Nothing
				DESIGNST.BuildSteelString()
			Catch ex3 As Exception
			End Try
		End Sub

		Private Function BuildLargerSteelString() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim flag4 As Boolean
			Dim num2 As Integer
			Dim obj4 As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim flag As Boolean = False
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If RSWIN_DESC.SETUP_UseAllDiameters And rst.giRodDesignStyle = 0S And Not(RSWIN_DESC.bExpert And RSWIN_DESC.bXRODAdmin) Then
					flag = False
				ElseIf(If(-If((RODUTIL.IsCorod(rst.RSGrade) > False), 1, 0), 1, 0) Or RODUTIL.IsProRod(CInt(rst.RSGrade))) <> 0 Then
					If DESIGNST.diams(CInt(DESIGNST.RSMax)) < rst.RSMaxSize Then
						DESIGNST.RSMax += 1S
						flag = True
					End If
				ElseIf rst.RSGrade <> 20481S AndAlso DESIGNST.RSMax < CShort(Math.Round(CDbl((8F * rst.RSMaxSize)))) Then
					Dim quiet As Object = True
					Dim grade As Object = rst.RSGrade
					Dim diameter As Object = CDbl((DESIGNST.RSMax + 1S)) / 8.0
					Dim flag2 As Boolean
					Dim obj As Object = flag2
					Dim obj2 As Object = 0
					Dim sNull As Object = RSWIN_DESC.sNull
					Dim flag3 As Boolean
					Dim obj3 As Object = flag3
					RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj, obj2, sNull, obj3, 0)
					flag3 = Conversions.ToBoolean(obj3)
					RSWIN_DESC.sNull = Conversions.ToString(sNull)
					flag2 = Conversions.ToBoolean(obj)
					If flag2 Then
						DESIGNST.RSMax += 1S
						flag = True
					End If
				End If
				If flag Then
					DESIGNST.BuildSteelString()
				End If
				flag4 = flag
				IL_14F:
				GoTo IL_196
				IL_151:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_167:
			Catch obj5 When endfilter(TypeOf obj4 Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj5, Exception)
				GoTo IL_151
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_196:
			Dim result As Boolean = flag4
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Sub BuildSteelString()
			Dim num As Integer
			Dim num15 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num2 As Single = rst.PumpDepth
				Dim rodSection As RSWIN_DESC.RodSection
				If rst.RSIncludeSB <> 0S Then
					If Not RSWIN_DESC.bSinkerBarDepthChanged Then
						num2 -= rst.SinkerBar.length
					Else
						If(Not rst.RSFGIncludeSteel And If((-If((RSWIN_DESC.bSinkerBarDepthChanged > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							Dim length As Single = rst.SinkerBar.length
							Dim num3 As Single
							Dim flag As Boolean
							RSWIN_DESC.fNewSinkerbarDepth = DESIGN.GetDepthFromInclination(length, num3, flag)
							RSWIN_DESC.fNewTaperLength = RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.fNewSinkerbarDepth
						End If
						If RSWIN_DESC.fNewTaperLength <> 0F Then
							num2 = num2 - rst.SinkerBar.length - RSWIN_DESC.fNewTaperLength
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
						Else
							num2 -= rst.SinkerBar.length
						End If
					End If
				End If
				If RODUTIL.IsCorod(rst.RSGrade) Then
					If(rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S) And RODUTIL.IsCorodSE(rst.RSGrade) Then
						If DESIGNST.RSMax <= DESIGNST.RSMin + 1S Then
							rst.NumRods = 1S
							rst.Sections(1).Diameter = DESIGNST.diams(CInt(DESIGNST.RSMax))
						Else
							' The following expression was wrapped in a unchecked-expression
							rst.NumRods = DESIGNST.RSMax - DESIGNST.RSMin
							rst.Sections(1).Diameter = DESIGNST.diams(CInt(DESIGNST.RSMax))
							Dim num4 As Integer = 2
							Dim numRods As Integer = CInt(rst.NumRods)
							For i As Integer = num4 To numRods
								rst.Sections(i).Diameter = DESIGNST.diams(CInt(DESIGNST.RSMax) - i)
							Next
						End If
					Else
						' The following expression was wrapped in a unchecked-expression
						rst.NumRods = DESIGNST.RSMax - DESIGNST.RSMin + 1S
						Dim num5 As Integer = 1
						Dim numRods2 As Integer = CInt(rst.NumRods)
						For i As Integer = num5 To numRods2
							rst.Sections(i).Diameter = DESIGNST.diams(CInt(DESIGNST.RSMax) - i + 1)
						Next
					End If
					If rst.NumRods = 1S Then
						rst.Sections(1).length = num2
					Else
						Dim num6 As Single
						Dim num7 As Integer
						Dim numRods3 As Integer

							rst.Sections(1).length = CSng((0.1 * CDbl(num2)))
							num6 = num2 - rst.Sections(1).length
							num7 = 2
							numRods3 = CInt(rst.NumRods)

						For i As Integer = num7 To numRods3
							rst.Sections(i).length = num6 / CSng((rst.NumRods - 1S))
						Next
					End If
					Dim num8 As Integer = 1
					Dim numRods4 As Integer = CInt(rst.NumRods)
					For i As Integer = num8 To numRods4
						rst.Sections(i).Grade = rst.RSGrade
						rst.Sections(i).RodType = rst.RSRodType.PadRight(20, " "c)

							rst.Sections(i).Area = CSng((Math.Pow(CDbl(rst.Sections(i).Diameter), 2.0) * 3.141592653589793 / 4.0))
							rst.Sections(i).SuckerRodLength = 1F
							rst.Sections(i).RodDensity = 490F
							rst.Sections(i).Elasticity = 30500000F
							RODUTIL.LookupRodWeight(rst.Sections(i))
							RODUTIL.LookupTensileStrength(rst.Sections(i))
							If RODUTIL.IsCorodH(rst.Sections(i).Grade) Then
								Dim str As String = RODUTIL.RodGrade(rst.Sections(i).Grade)
								Dim num9 As Single = rst.Sections(i).Area * 1000F
								Dim text As String = " 0"
								Dim text2 As String = str + Util.Format(num9, text)
								rst.Sections(i).RodType = text2.PadRight(20, " "c)
							End If

						If RSWIN_DESC.bRodStarD AndAlso rst.Sections(i).Guide <= 0S Then
							rst.Sections(i).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
							rst.Sections(i).NumGuides = 0S
							rst.Sections(i).friction_coef = RSWIN_DESC.rst.RSFricCoef
							rst.Sections(i).Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
						End If
					Next
				ElseIf RODUTIL.IsProRod(CInt(rst.RSGrade)) <> 0 Then
					' The following expression was wrapped in a unchecked-expression
					rst.NumRods = DESIGNST.RSMax - DESIGNST.RSMin + 1S
					Dim num10 As Integer = 1
					Dim numRods5 As Integer = CInt(rst.NumRods)
					For i As Integer = num10 To numRods5
						rst.Sections(i).Diameter = DESIGNST.diams(CInt(DESIGNST.RSMax) - i + 1)
					Next
					If rst.NumRods = 1S Then
						rst.Sections(1).length = num2
					Else
						Dim num6 As Single
						Dim num11 As Integer
						Dim numRods6 As Integer

							rst.Sections(1).length = CSng((0.1 * CDbl(num2)))
							num6 = num2 - rst.Sections(1).length
							num11 = 2
							numRods6 = CInt(rst.NumRods)

						For i As Integer = num11 To numRods6
							rst.Sections(i).length = num6 / CSng((rst.NumRods - 1S))
						Next
					End If
					Dim num12 As Integer = 1
					Dim numRods7 As Integer = CInt(rst.NumRods)
					For i As Integer = num12 To numRods7
						rst.Sections(i).Grade = rst.RSGrade
						rst.Sections(i).RodType = rst.RSRodType.PadRight(20, " "c)
						rst.Sections(i).Area = CSng((Math.Pow(CDbl(rst.Sections(i).Diameter), 2.0) * 3.141592653589793 / 4.0))
						rst.Sections(i).SuckerRodLength = 1F
						rst.Sections(i).RodDensity = 490F
						rst.Sections(i).Elasticity = 30500000F
						RODUTIL.LookupRodWeight(rst.Sections(i))
						RODUTIL.LookupTensileStrength(rst.Sections(i))
						rst.Sections(i).StressMethod = CShort(RODUTIL.LookupStressMethod(rst.Sections(i)))
					Next
				Else
					If DESIGNST.RSMin < 10S Then
						rst.APIRod = 10S * DESIGNST.RSMax + DESIGNST.RSMin
					Else
						rst.APIRod = 100S * DESIGNST.RSMax + DESIGNST.RSMin
					End If
					RODUTIL.MakeAPIString(num2, rst.APIRod, rst.RSGrade, rst.RSRodType)
				End If
				If rst.RSIncludeSB <> 0S Then
					rst.NumRods += 1S
					rst.Sections(CInt(rst.NumRods)) = rst.SinkerBar
					If RSWIN_DESC.bSinkerBarDepthChanged And RSWIN_DESC.fNewTaperLength > 0F Then
						rst.NumRods += 1S
						rst.Sections(CInt(rst.NumRods)) = rodSection
					End If
				End If
				Dim num13 As Integer = 1
				Dim numRods8 As Integer = CInt(rst.NumRods)
				For i As Integer = num13 To numRods8
					If RSWIN_DESC.bRodStarD Then
						RSWIN_DESC.rst.Sections(i).friction_coef = RSWIN_DESC.rst.RSFricCoef
						RSWIN_DESC.rst.Sections(i).Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
					ElseIf RSWIN_DESC.rst.RSFricCoef = 0F Then
						rst.Sections(i).friction_coef = 0.2F
					Else
						rst.Sections(i).friction_coef = RSWIN_DESC.rst.RSFricCoef
					End If
				Next
				DESIGN.CalcRodStringValues()
				If RSWIN_DESC.bRodStarD Then
					Dim num14 As Integer = 1
					Dim numRods9 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num14 To numRods9
						RSWIN_DESC.rst.Sections(i).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
						RSWIN_DESC.rst.Sections(i).NumGuides = 0S
						RSWIN_DESC.rst.Sections(i).friction_coef = RSWIN_DESC.rst.RSFricCoef
						RSWIN_DESC.rst.Sections(i).Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
					Next
				End If
				IL_9B1:
				GoTo IL_9F8
				IL_9B3:
				num15 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_9C9:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num15 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_9B3
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_9F8:
			If num15 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub RemoveBottomSteelSection()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim flag As Boolean = False
				If DESIGNST.RSMin < DESIGNST.RSMax Then
					DESIGNST.RSMin += 1S
					flag = True
				End If
				If flag Then
					DESIGNST.BuildSteelString()
				End If
				IL_2C:
				GoTo IL_6F
				IL_2E:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_42:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2E
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6F:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Function CheckIfMaxDiameterReached(iRSGrade As Short, RSMaxSize As Single) As Boolean
			Dim flag As Boolean = False
			Dim result As Boolean
			Try
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				If(If((-If((RODUTIL.IsCorod(iRSGrade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(iRSGrade))) <> 0 Then
					If DESIGNST.diams(CInt(DESIGNST.RSMax)) >= RSMaxSize Then
						flag = True
					End If
				ElseIf iRSGrade <> 20481S AndAlso DESIGNST.RSMax >= CShort(Math.Round(CDbl((8F * RSMaxSize)))) Then
					flag = True
				End If
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function AllRodsOverloaded() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				Dim num As Integer = 1
				Dim num2 As Integer = CInt((RSWIN_DESC.rst.NumRods - 1S))
				For i As Integer = num To num2
					If RSWIN_DESC.rst.StressL(i) <= 1F Then
						flag = False
						Exit For
					End If
				Next
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private m_RSMax As Short

		Private m_RSMin As Short

		Private diams As Single()

		Private nDiams As Short

		Private Const fTol As Single = 0.005F
	End Module
End Namespace
