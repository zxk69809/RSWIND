Imports System
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module cImplementGuideChanges
		Public Property iOrigNumRods As Integer
			Get
				Return cImplementGuideChanges.m_iOrigNumRods
			End Get
			Set(value As Integer)
				cImplementGuideChanges.m_iOrigNumRods = value
			End Set
		End Property

		Public Property sMaximum As String
			Get
				Return cImplementGuideChanges.m_sMaximum
			End Get
			Set(value As String)
				cImplementGuideChanges.m_sMaximum = value
			End Set
		End Property

		Public Property sMinimum As String
			Get
				Return cImplementGuideChanges.m_sMinimum
			End Get
			Set(value As String)
				cImplementGuideChanges.m_sMinimum = value
			End Set
		End Property

		Public Function RoundToNearestSuckerRod(fDepth As Single, iTaper As Integer, bToPrevious As Boolean) As Single
			Dim result As Single
			Try
				Dim num As Single
				If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(iTaper).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(iTaper).Grade)) Then
					num = 37.5F
				Else
					num = RSWIN_DESC.SETUP_SteelSuckerRodLength
				End If
				Dim num2 As Single
				If fDepth < num Then
					num2 = 0F
				Else
					Dim num3 As Single = fDepth Mod num
					If num3 = 0F Then
						num2 = fDepth
					Else
						' The following expression was wrapped in a checked-expression
						Dim num4 As Integer = CInt((CLng(Math.Round(CDbl(fDepth))) / CLng(Math.Round(CDbl(num)))))
						If bToPrevious Then
							' The following expression was wrapped in a checked-expression
							num2 = CSng((num4 - 1)) * num
						Else
							' The following expression was wrapped in a checked-expression
							num2 = CSng((num4 + 1)) * num
						End If
					End If
				End If
				result = num2
			Catch ex As Exception
				result = fDepth
			End Try
			Return result
		End Function

		Public Function PushRodGuidesAndAdjustForParaffin(Optional bGetSideLoads As Boolean = False) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
			Dim num As Single = 0F
			Dim num2 As Single = 0F
			Dim num3 As Single = 0F
			Dim num4 As Single = 0F
			Dim array2 As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
			Dim flag As Boolean = False
			Dim flag2 As Boolean = True
			Dim flag3 As Boolean = False
			Dim result As Boolean
			Try
				Util.BusyCursor()
				Try
					If bGetSideLoads Then
						MImpred.GetRodSideLoads(RSWIN_DESC.rod_sideloads, RSWIN_DESC.rod_suckerrodlength, True)
					End If
				Catch ex As Exception
				End Try
				Dim num5 As Single
				Dim num6 As Single
				Try
					Dim flag4 As Boolean = cImplementGuideChanges.FindFirstLastSideLoads(num, num2, num3, num4, True, num5, num6)
					Debug.WriteLine(String.Concat(New String() { Conversions.ToString(num), " , ", Conversions.ToString(num3), " , ", Conversions.ToString(num2), " , ", Conversions.ToString(num4) }))
				Catch ex2 As Exception
				End Try
				If num3 > 0F And num4 > 0F Then
					Try
						Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						cImplementGuideChanges.sMaximum = ""
						cImplementGuideChanges.sMinimum = ""
						Dim num7 As Integer
						Try
							Try
								MImpred.GetSectionIndex(num3, num7)
							Catch ex3 As Exception
							End Try
							Try
								Dim num8 As Integer
								MImpred.GetSectionIndex(num4, num8)
							Catch ex4 As Exception
							End Try
						Catch ex5 As Exception
						End Try
						Try
							Dim flag4 As Boolean = cImplementGuideChanges.FindFirstLastSideLoads(num, num2, num3, num4, True, num5, num6)
						Catch ex6 As Exception
						End Try
						If RSWIN_DESC.rst.gbParaffin And RSWIN_DESC.rst.ParaffinDepth > 0F Then
							Dim num9 As Single
							Try
								' The following expression was wrapped in a unchecked-expression
								num9 = CSng((CInt(Math.Round(CDbl((RSWIN_DESC.SETUP_SteelSuckerRodLength * 12F / RSWIN_DESC.rst.PU.KinematicStroke)) + 0.5)) + 1))
							Catch ex7 As Exception
							End Try
							Try
								RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
								array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
								array(0) = 0F
								RSWIN_DESC.taper_lens(0) = 0F
								Dim num10 As Integer = 1
								Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
								For i As Integer = num10 To numRods3
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a checked-expression
									array(i) = array(i - 1) + RSWIN_DESC.rst.Sections(i).length
									RSWIN_DESC.taper_lens(i) = array(i)
									Debug.WriteLine(String.Concat(New String() { Conversions.ToString(i), " , ", Conversions.ToString(RSWIN_DESC.rst.Sections(i).length), " , ", Conversions.ToString(RSWIN_DESC.taper_lens(i)), " , ", Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(i).NumGuides)) }))
								Next
							Catch ex8 As Exception
							End Try
							Dim num11 As Integer
							Try
								MImpred.GetSectionIndex(RSWIN_DESC.rst.ParaffinDepth, num11)
								MImpred.GetSectionIndex(num3, num7)
							Catch ex9 As Exception
							End Try
							If RSWIN_DESC.rst.ParaffinDepth >= 150F Then
								Dim num12 As Single
								If num11 = 1 Then
									num12 = RSWIN_DESC.rst.ParaffinDepth
								Else
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a checked-expression
									num12 = RSWIN_DESC.rst.ParaffinDepth - array(num11 - 1)
								End If
								num12 = cImplementGuideChanges.RoundToNearestSuckerRod(num12, num11, False)
								If RSWIN_DESC.rst.Sections(num11).length >= 300F And num12 >= 100F And RSWIN_DESC.rst.Sections(num11).length - num12 >= 150F Then
									Dim numGuides As Integer = CInt(RSWIN_DESC.rst.Sections(num11).NumGuides)
									cImplementGuideChanges.NewAddRodSection(num11, num11, False, False, True, False, num12, True, False, False, False)
									RSWIN_DESC.rst.Sections(num11).NumGuides = CShort(Math.Round(CDbl(num9)))
									RSWIN_DESC.rst.Sections(num11 + 1).NumGuides = CShort(numGuides)
									RSWIN_DESC.rst.Sections(num11).Guide = CShort(RSWIN_DESC.SETUP_ParaffinRodGuide)
									RSWIN_DESC.rst.Sections(num11).friction_coef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_ParaffinRodGuide, True)
									flag3 = True
									Try
										Try
											RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
											array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
											array(0) = 0F
											RSWIN_DESC.taper_lens(0) = 0F
											Dim num13 As Integer = 1
											Dim numRods4 As Integer = CInt(RSWIN_DESC.rst.NumRods)
											For j As Integer = num13 To numRods4
												' The following expression was wrapped in a unchecked-expression
												' The following expression was wrapped in a checked-expression
												array(j) = array(j - 1) + RSWIN_DESC.rst.Sections(j).length
												RSWIN_DESC.taper_lens(j) = array(j)
											Next
										Catch ex10 As Exception
										End Try
										Dim flag4 As Boolean = cImplementGuideChanges.FindFirstLastSideLoads(num, num2, num3, num4, True, num5, num6)
										Debug.WriteLine(String.Concat(New String() { Conversions.ToString(num), " , ", Conversions.ToString(num3), " , ", Conversions.ToString(num2), " , ", Conversions.ToString(num4) }))
										Try
											MImpred.GetSectionIndex(RSWIN_DESC.rst.ParaffinDepth, num11)
											MImpred.GetSectionIndex(num3, num7)
										Catch ex11 As Exception
										End Try
									Catch ex12 As Exception
									End Try
								End If
							End If
							If CInt(RSWIN_DESC.rst.NumRods) > num11 AndAlso flag2 Then
								Dim numGuides As Integer
								If num11 = num7 Then
									numGuides = CInt(RSWIN_DESC.rst.Sections(num7).NumGuides)
								Else
									numGuides = CInt(RSWIN_DESC.rst.Sections(num11 + 1).NumGuides)
								End If
								Dim num14 As Integer = 1
								Dim num15 As Integer = num11
								For j As Integer = num14 To num15
									If num9 > CSng(numGuides) Then
										RSWIN_DESC.rst.Sections(j).NumGuides = CShort(Math.Round(CDbl(num9)))
										RSWIN_DESC.rst.Sections(j).Guide = CShort(RSWIN_DESC.SETUP_ParaffinRodGuide)
										RSWIN_DESC.rst.Sections(j).friction_coef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_ParaffinRodGuide, True)
										flag3 = True
									ElseIf CInt(RSWIN_DESC.rst.Sections(j).NumGuides) <> numGuides And numGuides <> 0 Then
										RSWIN_DESC.rst.Sections(j).NumGuides = CShort(numGuides)
									End If
								Next
							End If
						End If
					Catch ex13 As Exception
					End Try
					Dim num24 As Integer
					Try
						Dim num16 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						Dim flag5 As Boolean = True
						While flag5
							Try
								flag = False
								Dim num17 As Integer = 1
								Dim num18 As Integer = CInt((RSWIN_DESC.rst.NumRods - 1S))
								For j As Integer = num17 To num18
									Dim num19 As Integer = j + 1
									If RSWIN_DESC.rst.Sections(j).Grade = RSWIN_DESC.rst.Sections(num19).Grade And RSWIN_DESC.rst.Sections(j).Diameter = RSWIN_DESC.rst.Sections(num19).Diameter And RSWIN_DESC.rst.Sections(j).friction_coef = RSWIN_DESC.rst.Sections(num19).friction_coef And RSWIN_DESC.rst.Sections(j).NumGuides = RSWIN_DESC.rst.Sections(num19).NumGuides Then
										' The following expression was wrapped in a unchecked-expression
										RSWIN_DESC.rst.Sections(j).length = RSWIN_DESC.rst.Sections(j).length + RSWIN_DESC.rst.Sections(num19).length
										RSWIN_DESC.rst.Sections(num19).length = 0F
										flag = True
										num16 -= 1
									End If
								Next
							Catch ex14 As Exception
							End Try
							If flag Then
								Dim i As Integer = 0
								array2 = New RSWIN_DESC.RodSection(i + 1 - 1) {}
								Dim num20 As Integer = 1
								Dim numRods5 As Integer = CInt(RSWIN_DESC.rst.NumRods)
								For j As Integer = num20 To numRods5
									If RSWIN_DESC.rst.Sections(j).length <> 0F Then
										i += 1
										array2 = CType(Utils.CopyArray(CType(array2, Array), New RSWIN_DESC.RodSection(i + 1 - 1) {}), RSWIN_DESC.RodSection())
										array2(i) = RSWIN_DESC.rst.Sections(j)
									End If
								Next
								If i < CInt(RSWIN_DESC.rst.NumRods) Then
									RSWIN_DESC.rst.NumRods = CShort(i)
									Dim sections As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
									RSWIN_DESC.rst.Sections = sections
									Dim num21 As Integer = 1
									Dim num22 As Integer = i
									For j As Integer = num21 To num22
										RSWIN_DESC.rst.Sections(j) = array2(j)
									Next
								End If
								Try
									RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
									array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
									array(0) = 0F
									RSWIN_DESC.taper_lens(0) = 0F
									Dim num23 As Integer = 1
									Dim numRods6 As Integer = CInt(RSWIN_DESC.rst.NumRods)
									For j As Integer = num23 To numRods6
										' The following expression was wrapped in a unchecked-expression
										' The following expression was wrapped in a checked-expression
										array(j) = array(j - 1) + RSWIN_DESC.rst.Sections(j).length
										RSWIN_DESC.taper_lens(j) = array(j)
									Next
								Catch ex15 As Exception
								End Try
								Try
									cImplementGuideChanges.InitializeGuideFrequencyArrays2()
								Catch ex16 As Exception
								End Try
								Try
									cImplementGuideChanges.InitSummaryReportXML2(num24)
								Catch ex17 As Exception
								End Try
							End If
							flag5 = flag
						End While
						Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					Catch ex18 As Exception
					End Try
					Try
						RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
						array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
						array(0) = 0F
						RSWIN_DESC.taper_lens(0) = 0F
						Dim num25 As Integer = 1
						Dim numRods7 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For j As Integer = num25 To numRods7
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							array(j) = array(j - 1) + RSWIN_DESC.rst.Sections(j).length
							RSWIN_DESC.taper_lens(j) = array(j)
						Next
					Catch ex19 As Exception
					End Try
					Try
						cImplementGuideChanges.InitializeGuideFrequencyArrays2()
					Catch ex20 As Exception
					End Try
					Try
						cImplementGuideChanges.InitSummaryReportXML2(num24)
					Catch ex21 As Exception
					End Try
				End If
				result = flag3
			Catch ex22 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function GetSideLoadPerGuide(Indx As Integer) As Single
			Dim num As Integer
			If Indx = -1 Then
				num = RSWIN_DESC.SETUP_GuideToUse
			Else
				num = CInt(RSWIN_DESC.rst.Sections(Indx).Guide)
			End If
			Dim num2 As Integer = num
			Dim result As Single
			If num2 = CInt(RSWIN_DESC.MOLDED) Then
				result = RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD
			ElseIf num2 = 2 Then
				result = RSWIN_DESC.SETUP_WHEELGUIDE_LOAD
			ElseIf num2 = 3 Then
				result = RSWIN_DESC.SETUP_OTHERGUIDE_LOAD
			ElseIf num2 = 4 OrElse num2 = CInt(RSWIN_DESC.NorrisSidewinderGuide) OrElse num2 = 6 OrElse num2 = 7 OrElse num2 = 8 OrElse num2 = 9 OrElse num2 = 10 OrElse num2 = 11 Then
				Dim num3 As Single
				If num3 = 0F Then
					Try
						' The following expression was wrapped in a checked-expression
						MImpred.GetSidewinderNameAndLoad(CShort(num), num3)
					Catch ex As Exception
					End Try
				End If
				result = num3
			Else
				result = RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD
			End If
			Return result
		End Function

		Private Sub PushRodGuides(iFirstTaper As Integer, iLastTaper As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim array As Boolean() = New Boolean(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim array2 As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
				Dim array3 As Single() = New Single(40) {}
				Try
					RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
					array3 = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
					array3(0) = 0F
					RSWIN_DESC.taper_lens(0) = 0F
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						array3(i) = array3(i - 1) + RSWIN_DESC.rst.Sections(i).length
						RSWIN_DESC.taper_lens(i) = array3(i)
					Next
				Catch ex As Exception
				End Try
				Try
					cImplementGuideChanges.InitializeGuideFrequencyArrays2()
				Catch ex2 As Exception
				End Try
				Dim num2 As Integer
				Try
					cImplementGuideChanges.InitSummaryReportXML2(num2)
				Catch ex3 As Exception
				End Try
				Dim num3 As Single
				Dim num4 As Single
				Dim num5 As Single
				Dim num6 As Single
				Dim num7 As Single
				Dim num8 As Single
				Try
					Dim flag3 As Boolean = cImplementGuideChanges.FindFirstLastSideLoads(num3, num4, num5, num6, True, num7, num8)
					Debug.WriteLine("FirstSideLoad  , FirstDepth  , LastSideLoad  , LastDepth")
					Debug.WriteLine(String.Concat(New String() { Conversions.ToString(num3), " , ", Conversions.ToString(num5), " , ", Conversions.ToString(num4), " , ", Conversions.ToString(num6) }))
				Catch ex4 As Exception
				End Try
				Dim num9 As Integer
				MImpred.GetSectionIndex(num5, num9)
				Dim fDepth As Single = num6
				Dim num11 As Single
				Dim num10 As Integer = CInt(Math.Round(CDbl(num11)))
				MImpred.GetSectionIndex(fDepth, num10)
				num11 = CSng(num10)
				If num5 = RSWIN_DESC.taper_lens(num9) Then
					iFirstTaper = num9 + 1
				End If
				If RSWIN_DESC.rst.NumRods > 1S Then
					Dim numGuides As Integer
					If iFirstTaper > 1 Then
						Dim num12 As Integer = iFirstTaper - 1
						If RSWIN_DESC.rst.Sections(iFirstTaper).NumGuides <> 0S And RSWIN_DESC.rst.Sections(num12).NumGuides = 0S Then
							If RSWIN_DESC.rst.Sections(num12).length >= CSng((RSWIN_DESC.Setup_RodGuideOverlap + 100)) Then
								numGuides = CInt(RSWIN_DESC.rst.Sections(iFirstTaper).NumGuides)
								Dim num13 As Single
								If num5 > RSWIN_DESC.taper_lens(num12) And num5 < RSWIN_DESC.taper_lens(iFirstTaper) Then
									' The following expression was wrapped in a unchecked-expression
									num13 = CSng(RSWIN_DESC.Setup_RodGuideOverlap) - (num5 - RSWIN_DESC.taper_lens(num12))
									If num13 < 0F Then
										num13 = 0F
									End If
								Else
									num13 = CSng(RSWIN_DESC.Setup_RodGuideOverlap)
								End If
								num13 = cImplementGuideChanges.RoundToSuckerRodLength(num13, True)
								If num13 > 0F Then
									cImplementGuideChanges.NewAddRodSection(iFirstTaper, iFirstTaper, False, True, False, False, num13, True, False, False, False)
									flag = True
									If CInt(RSWIN_DESC.rst.Sections(iFirstTaper).NumGuides) <> numGuides Then
										RSWIN_DESC.rst.Sections(iFirstTaper).NumGuides = CShort(numGuides)
									End If
									If CInt(RSWIN_DESC.rst.Sections(iFirstTaper + 1).NumGuides) <> numGuides Then
										RSWIN_DESC.rst.Sections(iFirstTaper + 1).NumGuides = CShort(numGuides)
									End If
								End If
							ElseIf RSWIN_DESC.rst.Sections(num12).NumGuides < RSWIN_DESC.rst.Sections(iFirstTaper).NumGuides Then
								RSWIN_DESC.rst.Sections(num12).NumGuides = RSWIN_DESC.rst.Sections(iFirstTaper).NumGuides

									If CSng(RSWIN_DESC.Setup_RodGuideOverlap) > RSWIN_DESC.rst.Sections(num12).length And num12 > 1 Then
										' The following expression was wrapped in a checked-expression
										' The following expression was wrapped in a checked-expression
										If RSWIN_DESC.rst.Sections(num12 - 1).length > CSng(RSWIN_DESC.Setup_RodGuideOverlap) - RSWIN_DESC.rst.Sections(num12).length And CSng(RSWIN_DESC.Setup_RodGuideOverlap) - RSWIN_DESC.rst.Sections(num12).length >= 100F Then
											Dim num13 As Single = CSng(RSWIN_DESC.Setup_RodGuideOverlap) - RSWIN_DESC.rst.Sections(num12).length
											If num13 < 0F Then
												num13 = 0F
											End If
											num13 = cImplementGuideChanges.RoundToSuckerRodLength(num13, True)
											If num13 > 0F Then
												cImplementGuideChanges.NewAddRodSection(num12, num12, False, True, False, False, num13, True, False, False, False)
												flag = True
											End If
										ElseIf RSWIN_DESC.rst.Sections(num12 - 1).length <= CSng(RSWIN_DESC.Setup_RodGuideOverlap) - RSWIN_DESC.rst.Sections(num12).length And CSng(RSWIN_DESC.Setup_RodGuideOverlap) - RSWIN_DESC.rst.Sections(num12).length > 0F Then
											' The following expression was wrapped in a checked-expression
											RSWIN_DESC.rst.Sections(num12 - 1).NumGuides = RSWIN_DESC.rst.Sections(num12).NumGuides
										End If
									End If

							End If
						End If
					ElseIf iFirstTaper = 1 And RSWIN_DESC.rst.NumRods > 1S Then
						Dim sideLoadPerGuide As Single = cImplementGuideChanges.GetSideLoadPerGuide(iFirstTaper)

							If num3 >= sideLoadPerGuide Then
								If RSWIN_DESC.rst.Sections(1).length > num5 And num5 - CSng(RSWIN_DESC.Setup_RodGuideOverlap) >= 100F Then
									Dim num13 As Single = num5 - CSng(RSWIN_DESC.Setup_RodGuideOverlap)
									num13 = cImplementGuideChanges.RoundToSuckerRodLength(num13, True)
									If num13 >= 100F Then
										If RSWIN_DESC.rst.Sections(1).length - num13 >= 100F Then
											If RSWIN_DESC.rst.Sections(2).NumGuides > 0S And RSWIN_DESC.rst.Sections(1).NumGuides = 0S Then
												numGuides = CInt(RSWIN_DESC.rst.Sections(2).NumGuides)
											Else
												numGuides = CInt(RSWIN_DESC.rst.Sections(1).NumGuides)
											End If
											If num13 < 0F Then
												num13 = 0F
											End If
											If num13 > 0F Then
												cImplementGuideChanges.NewAddRodSection(1, 1, False, False, True, False, num13, True, False, False, False)
												flag = True
											End If
											RSWIN_DESC.rst.Sections(1).NumGuides = 0S
											RSWIN_DESC.rst.Sections(2).NumGuides = CShort(numGuides)
										End If
									End If
								ElseIf num5 <= RSWIN_DESC.rst.Sections(1).length Then
									If RSWIN_DESC.rst.Sections(1).length >= 200F Then
										Dim num13 As Single = num5 - CSng(RSWIN_DESC.Setup_RodGuideOverlap)
										num13 = cImplementGuideChanges.RoundToSuckerRodLength(num13, True)
										If num13 < 100F Then
											num13 = 100F
										End If
										If num13 >= 100F Then
											If RSWIN_DESC.rst.Sections(1).length - num13 >= 100F Then
												If RSWIN_DESC.rst.Sections(2).NumGuides > 0S And RSWIN_DESC.rst.Sections(1).NumGuides = 0S Then
													numGuides = CInt(RSWIN_DESC.rst.Sections(2).NumGuides)
												Else
													numGuides = CInt(RSWIN_DESC.rst.Sections(1).NumGuides)
												End If
												cImplementGuideChanges.NewAddRodSection(1, 1, False, False, False, True, num13, True, False, False, False)
												flag = True
												RSWIN_DESC.rst.Sections(1).NumGuides = 0S
												RSWIN_DESC.rst.Sections(2).NumGuides = CShort(numGuides)
											End If
										End If
									ElseIf RSWIN_DESC.rst.Sections(2).NumGuides > RSWIN_DESC.rst.Sections(1).NumGuides Then
										RSWIN_DESC.rst.Sections(1).NumGuides = RSWIN_DESC.rst.Sections(2).NumGuides
									End If
								End If
							End If

					End If
					Try
						RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
						array3 = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
						array3(0) = 0F
						RSWIN_DESC.taper_lens(0) = 0F
						Dim num14 As Integer = 1
						Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num14 To numRods2
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							array3(i) = array3(i - 1) + RSWIN_DESC.rst.Sections(i).length
							RSWIN_DESC.taper_lens(i) = array3(i)
						Next
					Catch ex5 As Exception
					End Try
					If flag Then
						Dim flag4 As Boolean = PREDICT.Predict(True, "DesignUser")
					End If
					Try
						cImplementGuideChanges.InitializeGuideFrequencyArrays2()
					Catch ex6 As Exception
					End Try
					Try
						cImplementGuideChanges.InitSummaryReportXML2(num2)
					Catch ex7 As Exception
					End Try
					Try
						Dim flag3 As Boolean = cImplementGuideChanges.FindFirstLastSideLoads(num3, num4, num5, num6, True, num7, num8)
						Try
							MImpred.GetSectionIndex(num5, iFirstTaper)
						Catch ex8 As Exception
						End Try
						Try
							MImpred.GetSectionIndex(num6, iLastTaper)
						Catch ex9 As Exception
						End Try
					Catch ex10 As Exception
					End Try
					If iLastTaper <> 0 And iLastTaper < CInt(RSWIN_DESC.rst.NumRods) Then
						Dim num15 As Integer = iLastTaper + 1
						If RSWIN_DESC.rst.Sections(iLastTaper).NumGuides <> 0S And RSWIN_DESC.rst.Sections(num15).NumGuides < RSWIN_DESC.rst.Sections(iLastTaper).NumGuides Then
							If RSWIN_DESC.rst.Sections(num15).length >= CSng((RSWIN_DESC.Setup_RodGuideOverlap + 100)) Then
								numGuides = CInt(RSWIN_DESC.rst.Sections(iLastTaper).NumGuides)
								Dim num13 As Single
								If num6 > RSWIN_DESC.taper_lens(iLastTaper - 1) And num6 < RSWIN_DESC.taper_lens(iLastTaper) Then
									' The following expression was wrapped in a unchecked-expression
									num13 = CSng(RSWIN_DESC.Setup_RodGuideOverlap) - (RSWIN_DESC.taper_lens(iLastTaper) - num6)
									If num13 < 0F Then
										num13 = 0F
									End If
								Else
									num13 = CSng(RSWIN_DESC.Setup_RodGuideOverlap)
								End If
								num13 = cImplementGuideChanges.RoundToSuckerRodLength(num13, True)
								If num13 > 0F Then
									cImplementGuideChanges.NewAddRodSection(num15, num15, False, False, True, False, num13, True, False, False, False)
									flag = True
									If CInt(RSWIN_DESC.rst.Sections(num15).NumGuides) <> numGuides Then
										RSWIN_DESC.rst.Sections(num15).NumGuides = CShort(numGuides)
									End If
								End If
								flag = True
							Else
								If num6 >= RSWIN_DESC.taper_lens(num15 - 1) And num6 <= RSWIN_DESC.taper_lens(num15) Then
									RSWIN_DESC.rst.Sections(num15).NumGuides = RSWIN_DESC.rst.Sections(iLastTaper).NumGuides
								End If
								If num15 < CInt(RSWIN_DESC.rst.NumRods) AndAlso (RSWIN_DESC.rst.Sections(num15 + 1).length <= CSng(RSWIN_DESC.Setup_RodGuideOverlap) - RSWIN_DESC.rst.Sections(num15).length And CSng(RSWIN_DESC.Setup_RodGuideOverlap) - RSWIN_DESC.rst.Sections(num15).length > 0F) Then
									RSWIN_DESC.rst.Sections(num15 + 1).NumGuides = RSWIN_DESC.rst.Sections(iLastTaper).NumGuides
								End If
							End If
						ElseIf iLastTaper = CInt(RSWIN_DESC.rst.NumRods) And RSWIN_DESC.rst.NumRods > 1S And RSWIN_DESC.rst.Sections(iLastTaper).NumGuides > 0S Then
							' The following expression was wrapped in a unchecked-expression
							If num6 >= RSWIN_DESC.taper_lens(iLastTaper - 1) And num6 <= RSWIN_DESC.taper_lens(iLastTaper) And RSWIN_DESC.taper_lens(iLastTaper) - CSng(RSWIN_DESC.Setup_RodGuideOverlap) >= 100F Then
								numGuides = CInt(RSWIN_DESC.rst.Sections(iLastTaper - 1).NumGuides)
								If RSWIN_DESC.rst.Sections(iLastTaper).length - CSng(RSWIN_DESC.Setup_RodGuideOverlap) >= 100F Then
									Dim num13 As Single = CSng(RSWIN_DESC.Setup_RodGuideOverlap)
									num13 = cImplementGuideChanges.RoundToSuckerRodLength(num13, True)
									cImplementGuideChanges.NewAddRodSection(iLastTaper, iLastTaper, False, False, True, False, num13, True, False, False, False)
									flag = True
									RSWIN_DESC.rst.Sections(iLastTaper).NumGuides = CShort(numGuides)
									RSWIN_DESC.rst.Sections(iLastTaper + 1).NumGuides = 0S
								End If
							End If
						ElseIf RSWIN_DESC.rst.Sections(num15).NumGuides > 0S And num6 < RSWIN_DESC.taper_lens(iLastTaper) Then
							' The following expression was wrapped in a unchecked-expression
							Dim num13 As Single = CSng(RSWIN_DESC.Setup_RodGuideOverlap) - (RSWIN_DESC.taper_lens(iLastTaper) - num6)
							num13 = cImplementGuideChanges.RoundToSuckerRodLength(num13, True)
							If num13 < 0F Then
								num13 = 0F
							End If
							If num13 > 0F And RSWIN_DESC.rst.Sections(num15).length >= num13 + 100F Then
								cImplementGuideChanges.NewAddRodSection(num15, num15, False, False, True, False, num13, True, False, False, False)
								flag = True
								RSWIN_DESC.rst.Sections(num15).NumGuides = CShort(numGuides)
								RSWIN_DESC.rst.Sections(num15 + 1).NumGuides = 0S
							Else
								RSWIN_DESC.rst.Sections(num15).NumGuides = 0S
							End If
						End If
					ElseIf iLastTaper = CInt(RSWIN_DESC.rst.NumRods) AndAlso (RSWIN_DESC.rst.Sections(iLastTaper).NumGuides > 0S And num6 < RSWIN_DESC.taper_lens(iLastTaper)) Then
						numGuides = CInt(RSWIN_DESC.rst.Sections(iLastTaper).NumGuides)
						Dim num13 As Single = CSng(RSWIN_DESC.Setup_RodGuideOverlap) - (RSWIN_DESC.taper_lens(iLastTaper) - num6)
						num13 = cImplementGuideChanges.RoundToSuckerRodLength(num13, True)
						If num13 < 0F Then
							num13 = 0F
						End If
						If num13 > 0F And RSWIN_DESC.rst.Sections(iLastTaper).length >= num13 + 100F Then
							cImplementGuideChanges.NewAddRodSection(iLastTaper, iLastTaper, False, False, True, False, num13, True, False, False, False)
							flag = True
							RSWIN_DESC.rst.Sections(iLastTaper).NumGuides = CShort(numGuides)
							RSWIN_DESC.rst.Sections(iLastTaper + 1).NumGuides = 0S
						Else
							RSWIN_DESC.rst.Sections(iLastTaper).NumGuides = 0S
						End If
					End If
				End If
				If flag Then
					Try
						RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
						array3 = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
						array3(0) = 0F
						RSWIN_DESC.taper_lens(0) = 0F
						Dim num16 As Integer = 1
						Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num16 To numRods3
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							array3(i) = array3(i - 1) + RSWIN_DESC.rst.Sections(i).length
							RSWIN_DESC.taper_lens(i) = array3(i)
						Next
					Catch ex11 As Exception
					End Try
					Dim num17 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					Dim flag5 As Boolean = True
					While flag5
						Try
							flag2 = False
							Dim num18 As Integer = 1
							Dim num19 As Integer = CInt((RSWIN_DESC.rst.NumRods - 1S))
							For j As Integer = num18 To num19
								Dim num20 As Integer = j + 1
								If RSWIN_DESC.rst.Sections(j).Grade = RSWIN_DESC.rst.Sections(num20).Grade And RSWIN_DESC.rst.Sections(j).Diameter = RSWIN_DESC.rst.Sections(num20).Diameter And RSWIN_DESC.rst.Sections(j).friction_coef = RSWIN_DESC.rst.Sections(num20).friction_coef And RSWIN_DESC.rst.Sections(j).NumGuides = RSWIN_DESC.rst.Sections(num20).NumGuides Then
									' The following expression was wrapped in a unchecked-expression
									RSWIN_DESC.rst.Sections(j).length = RSWIN_DESC.rst.Sections(j).length + RSWIN_DESC.rst.Sections(num20).length
									RSWIN_DESC.rst.Sections(num20).length = 0F
									flag2 = True
									num17 -= 1
								End If
							Next
						Catch ex12 As Exception
						End Try
						If flag2 Then
							Dim i As Integer = 0
							array2 = New RSWIN_DESC.RodSection(i + 1 - 1) {}
							Dim num21 As Integer = 1
							Dim numRods4 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For j As Integer = num21 To numRods4
								If RSWIN_DESC.rst.Sections(j).length <> 0F Then
									i += 1
									array2 = CType(Utils.CopyArray(CType(array2, Array), New RSWIN_DESC.RodSection(i + 1 - 1) {}), RSWIN_DESC.RodSection())
									array2(i) = RSWIN_DESC.rst.Sections(j)
								End If
							Next
							If i < CInt(RSWIN_DESC.rst.NumRods) Then
								RSWIN_DESC.rst.NumRods = CShort(i)
								Dim sections As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
								RSWIN_DESC.rst.Sections = sections
								Dim num22 As Integer = 1
								Dim num23 As Integer = i
								For j As Integer = num22 To num23
									RSWIN_DESC.rst.Sections(j) = array2(j)
								Next
							End If
							Try
								RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
								array3 = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
								array3(0) = 0F
								RSWIN_DESC.taper_lens(0) = 0F
								Dim num24 As Integer = 1
								Dim numRods5 As Integer = CInt(RSWIN_DESC.rst.NumRods)
								For j As Integer = num24 To numRods5
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a checked-expression
									array3(j) = array3(j - 1) + RSWIN_DESC.rst.Sections(j).length
									RSWIN_DESC.taper_lens(j) = array3(j)
								Next
							Catch ex13 As Exception
							End Try
							Try
								cImplementGuideChanges.InitializeGuideFrequencyArrays2()
							Catch ex14 As Exception
							End Try
							Try
								cImplementGuideChanges.InitSummaryReportXML2(num2)
							Catch ex15 As Exception
							End Try
						End If
						flag5 = flag2
					End While
				End If
			Catch ex16 As Exception
			End Try
		End Sub

		Private Sub NewAddRodSection(Indx As Integer, J As Integer, bAddToNextTaperFirstHalf As Boolean, bAddToPreviousTaperSecondHalf As Boolean, bAddToSameTaperFirstHalf As Boolean, bAddToSameTaperSecondHalf As Boolean, fLength As Single, Optional bUseActualLength As Boolean = False, Optional bAllowZero As Boolean = False, Optional bConsiderSplit As Boolean = False, Optional bAssignNumRodGuides As Boolean = False)
			Dim flag As Boolean = False
			Dim num As Integer = CInt((RSWIN_DESC.rst.NumRods + 1S))
			Dim array As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(num + 1 - 1) {}
			Try
				If num < 40 Then
					If bAddToSameTaperFirstHalf OrElse bAddToSameTaperSecondHalf Then
						Dim num2 As Integer
						If Indx = 1 Then
							array(1) = RSWIN_DESC.rst.Sections(1)
							array(2) = RSWIN_DESC.rst.Sections(1)
							num2 = 2
						Else
							Dim i As Integer
							i = 1
							While i <= Indx
								array(i) = RSWIN_DESC.rst.Sections(i)
								i += 1
							End While
							array(i) = RSWIN_DESC.rst.Sections(Indx)
							num2 = Indx + 1
						End If
						Dim num3 As Integer = num2
						Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num3 To numRods
							array(i + 1) = RSWIN_DESC.rst.Sections(i)
						Next
						If bAddToSameTaperFirstHalf Then
							If Not bUseActualLength Then
								' The following expression was wrapped in a unchecked-expression
								array(Indx).length = CSng(CInt(Math.Round(CDbl((RSWIN_DESC.rst.Sections(Indx).length / 2F - fLength)) + 0.5)))
								array(Indx + 1).length = CSng(CInt(Math.Round(CDbl((RSWIN_DESC.rst.Sections(Indx).length / 2F + fLength)) + 0.5)))

									' The following expression was wrapped in a checked-expression
									If RSWIN_DESC.rst.Sections(Indx).length < array(Indx).length + array(Indx + 1).length Then
										If array(Indx).length > RSWIN_DESC.rst.Sections(Indx).length / 2F - fLength Then
											array(Indx).length = array(Indx).length - 1F
										Else
											' The following expression was wrapped in a checked-expression
											' The following expression was wrapped in a checked-expression
											array(Indx + 1).length = array(Indx + 1).length - 1F
										End If
									End If

							Else
								array(Indx).length = fLength
								array(Indx + 1).length = RSWIN_DESC.rst.Sections(Indx).length - fLength
							End If
							If bAssignNumRodGuides Then
								array(Indx).NumGuides = CShort(RSWIN_DESC.MaxRecNumGuides_2(J * 2 - 1))
								If RSWIN_DESC.MaxRecNumGuides_2(J * 2) <> 0 OrElse bAllowZero Then
									array(Indx + 1).NumGuides = CShort(RSWIN_DESC.MaxRecNumGuides_2(J * 2))
								End If
							End If

								' The following expression was wrapped in a checked-expression
								Dim num4 As Single = array(Indx).length + array(Indx + 1).length
								If RSWIN_DESC.rst.Sections(Indx).length <> num4 And Math.Abs(RSWIN_DESC.rst.Sections(Indx).length - num4) < 2F Then
									If RSWIN_DESC.rst.Sections(Indx).length > num4 Then
										' The following expression was wrapped in a checked-expression
										' The following expression was wrapped in a checked-expression
										array(Indx + 1).length = array(Indx + 1).length + (RSWIN_DESC.rst.Sections(Indx).length - num4)
									ElseIf num4 > RSWIN_DESC.rst.Sections(Indx).length Then
										' The following expression was wrapped in a checked-expression
										' The following expression was wrapped in a checked-expression
										array(Indx + 1).length = array(Indx + 1).length - (num4 - RSWIN_DESC.rst.Sections(Indx).length)
									End If
								End If

						ElseIf bAddToSameTaperSecondHalf Then
							If Not bUseActualLength Then
								If Not bConsiderSplit Then
									' The following expression was wrapped in a unchecked-expression
									array(Indx).length = CSng(CInt(Math.Round(CDbl((RSWIN_DESC.rst.Sections(Indx).length / 2F + fLength)) + 0.5)))
									array(Indx + 1).length = CSng(CInt(Math.Round(CDbl((RSWIN_DESC.rst.Sections(Indx).length / 2F - fLength)) + 0.5)))

										' The following expression was wrapped in a checked-expression
										If RSWIN_DESC.rst.Sections(Indx).length < array(Indx).length + array(Indx + 1).length Then
											If array(Indx).length > RSWIN_DESC.rst.Sections(Indx).length / 2F + fLength Then
												array(Indx).length = array(Indx).length - 1F
											Else
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												array(Indx + 1).length = array(Indx + 1).length - 1F
											End If
										End If

								Else
									' The following expression was wrapped in a unchecked-expression
									array(Indx).length = CSng(CInt(Math.Round(CDbl((cImplementGuideChanges.fSplit(J) + fLength)) + 0.5)))
									array(Indx + 1).length = CSng(CInt(Math.Round(CDbl((RSWIN_DESC.rst.Sections(Indx).length - array(Indx).length)) + 0.5)))

										' The following expression was wrapped in a checked-expression
										If array(Indx).length > cImplementGuideChanges.fSplit(J) + fLength Then
											array(Indx).length = array(Indx).length - 1F
										ElseIf array(Indx + 1).length = RSWIN_DESC.rst.Sections(Indx).length - array(Indx).length Then
											' The following expression was wrapped in a checked-expression
											' The following expression was wrapped in a checked-expression
											array(Indx + 1).length = array(Indx + 1).length - 1F
										End If

								End If
							Else
								array(Indx).length = fLength
								array(Indx + 1).length = RSWIN_DESC.rst.Sections(Indx).length - fLength
							End If
							If bAssignNumRodGuides Then
								array(Indx).NumGuides = CShort(RSWIN_DESC.MaxRecNumGuides_2(J * 2 - 1))
								If RSWIN_DESC.MaxRecNumGuides_2(J * 2) <> 0 OrElse bAllowZero Then
									array(Indx + 1).NumGuides = CShort(RSWIN_DESC.MaxRecNumGuides_2(J * 2))
								End If
							End If

								' The following expression was wrapped in a checked-expression
								Dim num4 As Single = array(Indx).length + array(Indx + 1).length
								If RSWIN_DESC.rst.Sections(Indx).length <> num4 And Math.Abs(RSWIN_DESC.rst.Sections(Indx).length - num4) < 2F Then
									If RSWIN_DESC.rst.Sections(Indx).length > num4 Then
										' The following expression was wrapped in a checked-expression
										' The following expression was wrapped in a checked-expression
										array(Indx + 1).length = array(Indx + 1).length + (RSWIN_DESC.rst.Sections(Indx).length - num4)
									ElseIf num4 > RSWIN_DESC.rst.Sections(Indx).length Then
										' The following expression was wrapped in a checked-expression
										' The following expression was wrapped in a checked-expression
										array(Indx + 1).length = array(Indx + 1).length - (num4 - RSWIN_DESC.rst.Sections(Indx).length)
									End If
								End If

						End If
						RSWIN_DESC.rst.NumRods = CShort(num)
						flag = True
					ElseIf bAddToPreviousTaperSecondHalf Then
						If Indx > 1 Then
							Dim num5 As Integer = 1
							Dim num6 As Integer = Indx - 1
							Dim i As Integer
							i = num5
							While i <= num6
								array(i) = RSWIN_DESC.rst.Sections(i)
								i += 1
							End While
							array(i) = RSWIN_DESC.rst.Sections(Indx - 1)
							array(i).length = fLength
							array(i - 1).length = RSWIN_DESC.rst.Sections(Indx - 1).length - fLength
							Dim num4 As Single = array(i).length + array(i - 1).length
							If RSWIN_DESC.rst.Sections(Indx - 1).length <> num4 And Math.Abs(RSWIN_DESC.rst.Sections(Indx - 1).length - num4) < 2F Then
								If RSWIN_DESC.rst.Sections(Indx - 1).length > num4 Then
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									array(i - 1).length = array(i - 1).length + (RSWIN_DESC.rst.Sections(Indx - 1).length - num4)
								ElseIf num4 > RSWIN_DESC.rst.Sections(Indx - 1).length Then
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									array(i - 1).length = array(i - 1).length - (num4 - RSWIN_DESC.rst.Sections(Indx - 1).length)
								End If
							End If
							If bAssignNumRodGuides AndAlso RSWIN_DESC.MaxRecNumGuides_2(J * 2 - 1) <> 0 Then
								array(i).NumGuides = CShort(RSWIN_DESC.MaxRecNumGuides_2(J * 2 - 1))
							End If
							Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							i = Indx
							While i <= numRods2
								array(i + 1) = RSWIN_DESC.rst.Sections(i)
								i += 1
							End While
							RSWIN_DESC.rst.NumRods = CShort(num)
							flag = True
						End If
					ElseIf bAddToNextTaperFirstHalf AndAlso Indx <= CInt(RSWIN_DESC.rst.NumRods) Then
						Dim i As Integer
						i = 1
						While i <= Indx
							array(i) = RSWIN_DESC.rst.Sections(i)
							i += 1
						End While
						array(i) = RSWIN_DESC.rst.Sections(Indx)
						array(i - 1).length = fLength
						array(i).length = RSWIN_DESC.rst.Sections(Indx).length - fLength
						If bAssignNumRodGuides Then
							If RSWIN_DESC.MaxRecNumGuides_2(J * 2) <> 0 Then
								array(i - 1).NumGuides = CShort(RSWIN_DESC.MaxRecNumGuides_2(J * 2))
							End If
							If RSWIN_DESC.MaxRecNumGuides_2((J + 1) * 2) > RSWIN_DESC.MaxRecNumGuides_2((J + 1) * 2 - 1) Then
								array(i).NumGuides = CShort(RSWIN_DESC.MaxRecNumGuides_2((J + 1) * 2))
							ElseIf RSWIN_DESC.MaxRecNumGuides_2((J + 1) * 2 - 1) <> 0 Then
								array(i).NumGuides = CShort(RSWIN_DESC.MaxRecNumGuides_2((J + 1) * 2 - 1))
							End If
						End If

							' The following expression was wrapped in a checked-expression
							Dim num4 As Single = array(i).length + array(i - 1).length
							If RSWIN_DESC.rst.Sections(Indx).length <> num4 And Math.Abs(RSWIN_DESC.rst.Sections(Indx).length - num4) < 2F Then
								If RSWIN_DESC.rst.Sections(Indx).length > num4 Then
									array(i).length = array(i).length + (RSWIN_DESC.rst.Sections(Indx).length - num4)
								ElseIf num4 > RSWIN_DESC.rst.Sections(Indx).length Then
									array(i).length = array(i).length - (num4 - RSWIN_DESC.rst.Sections(Indx).length)
								End If
							End If

						RSWIN_DESC.rst.NumRods = CShort(num)
						i = Indx + 2
						While i <= CInt(RSWIN_DESC.rst.NumRods)
							array(i) = RSWIN_DESC.rst.Sections(i - 1)
							i += 1
						End While
						flag = True
					End If
					If flag Then
						If Information.UBound(RSWIN_DESC.rst.Sections, 1) < num Then
							Dim sections As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(num + 1 - 1) {}
							RSWIN_DESC.rst.Sections = sections
						End If
						cImplementGuideChanges.f200 = New Single(num + 1 - 1) {}
						cImplementGuideChanges.f300 = New Single(num + 1 - 1) {}
						cImplementGuideChanges.f400 = New Single(num + 1 - 1) {}
						Dim num7 As Integer = 1
						Dim num8 As Integer = num
						For i As Integer = num7 To num8
							RSWIN_DESC.rst.Sections(i) = array(i)
							If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Then
								cImplementGuideChanges.f200(i) = 225F
								cImplementGuideChanges.f300(i) = 300F
								cImplementGuideChanges.f400(i) = 450F
							ElseIf RSWIN_DESC.SETUP_SteelSuckerRodLength = 30F Then
								cImplementGuideChanges.f200(i) = 210F
								cImplementGuideChanges.f300(i) = 300F
								cImplementGuideChanges.f400(i) = 420F
							Else
								cImplementGuideChanges.f200(i) = 200F
								cImplementGuideChanges.f300(i) = 300F
								cImplementGuideChanges.f400(i) = 400F
							End If
						Next
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub DetermineMostFrequentRods()
			RSWIN_DESC.MaxRecNumGuides_2 = New Integer(80) {}
			Try
				Dim num As Integer = CInt((RSWIN_DESC.rst.NumRods * 2S))
				Dim num2 As Integer = 1
				Dim num3 As Integer = num
				For i As Integer = num2 To num3
					RSWIN_DESC.MaxRecNumGuides_2(0) = 0
				Next
				Dim num4 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num4 To numRods
					num = RSWIN_DESC.GuideFrequencyArray(i).NumberOfSubSections
					Dim num5 As Integer = 1
					Dim num6 As Integer = num
					For j As Integer = num5 To num6
						cImplementGuideChanges.SetMostFrequentRodGuidesInSubSection(i, j)
						Debug.WriteLine(String.Concat(New String() { "   Taper  ", Conversions.ToString(i), " SubSections ", Conversions.ToString(j), " , MostFrequent ", Conversions.ToString(RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).MostFrequentNumberOfGuides) }))
						If j = 1 Then
							RSWIN_DESC.MaxRecNumGuides_2(i * 2 - 1) = CInt(Math.Round(CDbl(RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).MostFrequentNumberOfGuides)))
						ElseIf j = 2 Then
							RSWIN_DESC.MaxRecNumGuides_2(i * 2) = CInt(Math.Round(CDbl(RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).MostFrequentNumberOfGuides)))
						End If
					Next
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Sub DetermineMaxNumRodGuides(Optional bAfterParaffinPush As Boolean = False)
			RSWIN_DESC.MaxRecNumGuides = New Integer(40) {}
			Try
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				Dim num As Integer = 1
				Dim num2 As Integer = numRods
				For i As Integer = num To num2
					RSWIN_DESC.MaxRecNumGuides(i) = 0
				Next
				Dim num3 As Integer = 1
				Dim num4 As Integer = numRods
				For i As Integer = num3 To num4
					RSWIN_DESC.MaxRecNumGuides(i) = cImplementGuideChanges.GetMaxRodGuides(i)
					Debug.WriteLine(Conversions.ToString(i) + " , " + Conversions.ToString(RSWIN_DESC.MaxRecNumGuides(i)))
					If Not bAfterParaffinPush Then
						RSWIN_DESC.rst.Sections(i).NumGuides = CShort(RSWIN_DESC.MaxRecNumGuides(i))
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Function IsInList(icheck As Integer, guides As Integer()) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim num As Integer = Information.LBound(guides, 1)
				Dim num2 As Integer = Information.UBound(guides, 1)
				Dim flag As Boolean = False
				If num = 0 And num2 = 0 Then
					result = False
				Else
					Dim num3 As Integer = num
					Dim num4 As Integer = num2
					For i As Integer = num3 To num4
						If guides(i) = icheck Then
							flag = True
							Exit For
						End If
					Next
					result = flag
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetNumberInList(I As Integer, J As Integer, iGuideNumber As Integer) As Integer
			' The following expression was wrapped in a checked-statement
			Dim result As Integer
			Try
				Dim numberOfSuckerRodsInSection As Integer = RSWIN_DESC.GuideFrequencyArray(I).SubSections(J).NumberOfSuckerRodsInSection
				Dim num As Integer = 0
				Dim num2 As Integer = 1
				Dim num3 As Integer = numberOfSuckerRodsInSection
				For i As Integer = num2 To num3
					If CSng(iGuideNumber) = RSWIN_DESC.GuideFrequencyArray(I).SubSections(J).SuckerRodNumGuides(i) Then
						num += 1
					End If
				Next
				result = num
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub SetMostFrequentRodGuidesInSubSection(I As Integer, J As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim numberOfSuckerRodsInSection As Integer = RSWIN_DESC.GuideFrequencyArray(I).SubSections(J).NumberOfSuckerRodsInSection
				Dim array As Integer() = New Integer(1) {}
				Dim array2 As Integer() = New Integer(1) {}
				Dim obj As Object = 0
				numberOfSuckerRodsInSection = RSWIN_DESC.GuideFrequencyArray(I).SubSections(J).NumberOfSuckerRodsInSection
				Dim num As Integer = 1
				Dim num2 As Integer = numberOfSuckerRodsInSection
				For i As Integer = num To num2
					Dim num3 As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.GuideFrequencyArray(I).SubSections(J).SuckerRodNumGuides(i))))
					If Not cImplementGuideChanges.IsInList(num3, array) Then
						obj = Operators.AddObject(obj, 1)
						array = CType(Utils.CopyArray(CType(array, Array), New Integer(Conversions.ToInteger(obj) + 1 - 1) {}), Integer())
						array2 = CType(Utils.CopyArray(CType(array2, Array), New Integer(Conversions.ToInteger(obj) + 1 - 1) {}), Integer())
						array(Conversions.ToInteger(obj)) = num3
						array2(Conversions.ToInteger(obj)) = 1
					End If
				Next
				Dim num4 As Integer = 0
				Dim num5 As Integer = Conversions.ToInteger(obj)
				For i As Integer = num4 To num5
					Dim num3 As Integer = array(i)
					array2(i) = cImplementGuideChanges.GetNumberInList(I, J, num3)
				Next
				Dim num6 As Integer = -1
				Dim num7 As Integer = 0
				Dim num8 As Integer = 0
				Dim num9 As Integer = 0
				Dim num10 As Integer = Conversions.ToInteger(obj)
				For i As Integer = num9 To num10
					If array2(i) > num6 Then
						num6 = array2(i)
						num7 = i
						num8 = array(i)
					ElseIf array2(i) = num6 AndAlso array(i) > num8 Then
						num6 = array2(i)
						num7 = i
						num8 = array(i)
					End If
				Next
				RSWIN_DESC.GuideFrequencyArray(I).SubSections(J).MostFrequentNumberOfGuides = CSng(array(num7))
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetMaxRodGuides(I As Integer) As Integer
			' The following expression was wrapped in a checked-statement
			Dim result As Integer
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = 1
				Dim numberOfSubSections As Integer = RSWIN_DESC.GuideFrequencyArray(I).NumberOfSubSections
				For i As Integer = num2 To numberOfSubSections
					Dim numberOfSuckerRodsInSection As Integer = RSWIN_DESC.GuideFrequencyArray(I).SubSections(i).NumberOfSuckerRodsInSection
					Dim num3 As Integer = 1
					Dim num4 As Integer = numberOfSuckerRodsInSection
					For j As Integer = num3 To num4
						Dim num5 As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.GuideFrequencyArray(I).SubSections(i).SuckerRodNumGuides(j))))
						If num5 > num Then
							num = num5
						End If
					Next
				Next
				result = num
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub DivideTapersBeforeImplementation(ByRef bCondensedBeforeDivision As Boolean)
			' The following expression was wrapped in a checked-statement
			Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim num As Integer = 0
			Dim flag As Boolean = True
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				array(0) = 0F
				RSWIN_DESC.taper_lens(0) = 0F
				Dim num2 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num2 To numRods
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					array(i) = array(i - 1) + RSWIN_DESC.rst.Sections(i).length
					RSWIN_DESC.taper_lens(i) = array(i)
				Next
				bCondensedBeforeDivision = False
				If RSWIN_DESC.rst.NumRods > 1S AndAlso flag Then
					Dim array2 As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
					Dim flag2 As Boolean = False
					Try
						Dim num3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = CInt(RSWIN_DESC.rst.NumRods)To 2 Step -1
							Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
							Dim num4 As Integer = i
							If sections(num4).Grade = RSWIN_DESC.rst.Sections(i - 1).Grade And sections(num4).Diameter = RSWIN_DESC.rst.Sections(i - 1).Diameter And (sections(num4).Guide = RSWIN_DESC.rst.Sections(i - 1).Guide Or (sections(num4).Guide = 0S Or RSWIN_DESC.rst.Sections(i - 1).Guide = 0S)) And sections(num4).NumGuides = RSWIN_DESC.rst.Sections(i - 1).NumGuides And sections(num4).friction_coef = RSWIN_DESC.rst.Sections(i - 1).friction_coef Then
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								RSWIN_DESC.rst.Sections(i - 1).length = RSWIN_DESC.rst.Sections(i - 1).length + sections(num4).length
								sections(num4).length = 0F
								flag2 = True
								num3 -= 1
							End If
						Next
					Catch ex As Exception
					End Try
					If flag2 Then
						bCondensedBeforeDivision = True
						Dim j As Integer = 0
						array2 = New RSWIN_DESC.RodSection(j + 1 - 1) {}
						Dim num5 As Integer = 1
						Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num5 To numRods2
							If RSWIN_DESC.rst.Sections(i).length <> 0F Then
								j += 1
								array2 = CType(Utils.CopyArray(CType(array2, Array), New RSWIN_DESC.RodSection(j + 1 - 1) {}), RSWIN_DESC.RodSection())
								array2(j) = RSWIN_DESC.rst.Sections(i)
							End If
						Next
						If j < CInt(RSWIN_DESC.rst.NumRods) Then
							RSWIN_DESC.rst.NumRods = CShort(j)
							Dim sections2 As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
							RSWIN_DESC.rst.Sections = sections2
							Dim num6 As Integer = 1
							Dim num7 As Integer = j
							For i As Integer = num6 To num7
								RSWIN_DESC.rst.Sections(i) = array2(i)
							Next
						End If
						RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
						RSWIN_DESC.taper_lens(1) = RSWIN_DESC.rst.Sections(1).length
						array(1) = RSWIN_DESC.taper_lens(1)
						Dim num8 As Integer = 2
						Dim num9 As Integer = j
						For i As Integer = num8 To num9
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							RSWIN_DESC.taper_lens(i) = RSWIN_DESC.taper_lens(i - 1) + RSWIN_DESC.rst.Sections(i).length
							array(i) = RSWIN_DESC.taper_lens(i)
						Next
					End If
					flag2 = False
				End If
				Dim num10 As Single = CSng(RSWIN_DESC.rst.NumRods)
				num = 0
				Try
					For i As Integer = 1 To CInt(RSWIN_DESC.rst.NumRods)
						If RSWIN_DESC.rst.Sections(i).length >= 400F Then
							Dim num11 As Single = 0F
							Dim flag4 As Boolean
							Dim flag5 As Boolean
							Dim num12 As Single
							Dim num13 As Single
							Dim flag3 As Boolean = cImplementGuideChanges.CheckSideLoads(array(i - 1), array(i), num11, flag4, flag5, num12, num13)
							Dim sideLoadPerGuide As Single = cImplementGuideChanges.GetSideLoadPerGuide(i)
							If flag3 And num11 >= RSWIN_DESC.SETUP_MaxSideLoadLimit Then
								num += 1
								If RSWIN_DESC.rst.NumRods < 39S Then
									Try
										If RSWIN_DESC.rst.Sections(i).length >= 600F Then

												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												If flag4 AndAlso flag5 Then
													' The following expression was wrapped in a checked-expression
													' The following expression was wrapped in a unchecked-expression
													Dim num14 As Single = CSng((CInt(Math.Round(CDbl((RSWIN_DESC.rst.Sections(i).length / 2F)) + 0.5))))
													num14 = cImplementGuideChanges.RoundToSuckerRodLength(num14, True)
													cImplementGuideChanges.NewAddRodSection(i, i, False, False, False, True, num14, True, False, False, False)
												ElseIf(Not flag4 AndAlso flag5) And num13 - array(i - 1) >= 300F And RSWIN_DESC.rst.Sections(i).length - (num13 - array(i - 1)) >= 300F Then
													' The following expression was wrapped in a checked-expression
													Dim num14 As Single = num13 - array(i - 1)
													num14 = cImplementGuideChanges.RoundToSuckerRodLength(num14, True)
													cImplementGuideChanges.NewAddRodSection(i, i, False, False, False, True, num14, True, False, False, False)
												ElseIf flag4 And Not flag5 And num12 - array(i - 1) >= 300F And RSWIN_DESC.rst.Sections(i).length - (num12 - array(i - 1)) >= 300F Then
													' The following expression was wrapped in a checked-expression
													Dim num14 As Single = num12 - array(i - 1)
													num14 = cImplementGuideChanges.RoundToSuckerRodLength(num14, False)
													cImplementGuideChanges.NewAddRodSection(i, i, False, False, True, False, num14, True, False, False, False)
												Else
													' The following expression was wrapped in a checked-expression
													' The following expression was wrapped in a unchecked-expression
													Dim num14 As Single = CSng((CInt(Math.Round(CDbl((RSWIN_DESC.rst.Sections(i).length / 2F)) + 0.5))))
													num14 = cImplementGuideChanges.RoundToSuckerRodLength(num14, True)
													cImplementGuideChanges.NewAddRodSection(i, i, False, False, False, True, num14, True, False, False, False)
												End If

										ElseIf RSWIN_DESC.rst.Sections(i).length > 400F And RSWIN_DESC.rst.Sections(i).length < 600F Then
											' The following expression was wrapped in a unchecked-expression
											Dim num14 As Single = CSng(CInt(Math.Round(CDbl((RSWIN_DESC.rst.Sections(i).length / 2F)) + 0.5)))
											num14 = cImplementGuideChanges.RoundToSuckerRodLength(num14, True)
											cImplementGuideChanges.NewAddRodSection(i, i, False, False, False, True, num14, True, False, False, False)
										End If
									Catch ex2 As Exception
									End Try
									Try
										RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
										array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
										array(0) = 0F
										RSWIN_DESC.taper_lens(0) = 0F
										Dim num15 As Integer = 1
										Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
										For j As Integer = num15 To numRods3
											' The following expression was wrapped in a unchecked-expression
											' The following expression was wrapped in a checked-expression
											array(j) = array(j - 1) + RSWIN_DESC.rst.Sections(j).length
											RSWIN_DESC.taper_lens(j) = array(j)
										Next
									Catch ex3 As Exception
									End Try
									Try
										cImplementGuideChanges.InitializeGuideFrequencyArrays2()
									Catch ex4 As Exception
									End Try
									Try
										Dim num16 As Integer
										cImplementGuideChanges.InitSummaryReportXML2(num16)
									Catch ex5 As Exception
									End Try
									Try
										cImplementGuideChanges.DetermineMostFrequentRods()
									Catch ex6 As Exception
									End Try
								End If
							End If
						End If
					Next
				Catch ex7 As Exception
				End Try
			Catch ex8 As Exception
			End Try
		End Sub

		Public Sub NewDivideTapers(ByRef iFirstTaper As Integer, ByRef iLastTaper As Integer)
			' The following expression was wrapped in a checked-expression
			Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim flag As Boolean = True
			Dim num As Single = CSng(RSWIN_DESC.rst.NumRods)
			Dim setup_NumRodsPerBundle As Integer = RSWIN_DESC.Setup_NumRodsPerBundle
			Dim num2 As Single = RSWIN_DESC.SETUP_SteelSuckerRodLength * CSng(RSWIN_DESC.Setup_NumRodsPerBundle)
			Dim num3 As Single = CSng((37.5 * CDbl(RSWIN_DESC.Setup_NumRodsPerBundle)))
			Dim array2 As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
			Dim flag2 As Boolean = iFirstTaper > 1
			Dim flag3 As Boolean = CInt(RSWIN_DESC.rst.NumRods) >= iLastTaper + 1
			Try
				Dim num4 As Single = num2
				Dim num5 As Single = num3
				RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				array(0) = 0F
				RSWIN_DESC.taper_lens(0) = 0F
				Dim num6 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				Dim i As Integer
				i = num6
				While i <= numRods
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					array(i) = array(i - 1) + RSWIN_DESC.rst.Sections(i).length
					RSWIN_DESC.taper_lens(i) = array(i)
					i += 1
				End While
				i = 1
				Do
					array2(i).Initialize()
					i += 1
				Loop While i <= 40
				Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				Dim j As Integer = 1
				Dim num7 As Integer = 0
				If flag2 Then
					Dim num8 As Integer = 1
					Dim num9 As Integer = iFirstTaper - 1
					i = num8
					While i <= num9
						array2(j) = RSWIN_DESC.rst.Sections(i)
						j += 1
						num7 += 1
						i += 1
					End While
				End If
				Dim num10 As Integer = iFirstTaper
				Dim num11 As Integer = iLastTaper
				i = num10
				While i <= num11
					Dim num12 As Single
					Dim flag5 As Boolean
					Dim flag6 As Boolean
					Dim num13 As Single
					Dim num14 As Single
					Dim flag4 As Boolean = cImplementGuideChanges.CheckSideLoads(array(i - 1), array(i), num12, flag5, flag6, num13, num14)
					Dim sideLoadPerGuide As Single = cImplementGuideChanges.GetSideLoadPerGuide(i)
					Dim num19 As Integer
					If flag4 And num12 >= RSWIN_DESC.SETUP_MaxSideLoadLimit Then
						Dim length As Single = RSWIN_DESC.rst.Sections(i).length
						Dim num16 As Single
						If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Then
							If length > num5 Then
								Dim num15 As Integer = 1
								num5 = num3
								num16 = length / num3
								Dim num17 As Single = length Mod num3
								While num17 <> 0F And num16 >= 1F And num15 < 100
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a checked-expression
									num5 = CSng((37.5 * CDbl((setup_NumRodsPerBundle + num15))))
									num16 = length / num5
									num17 = length Mod num5
									num15 += 1
								End While
								If num16 < 1F Then
									num16 = 1F
								End If
								If num15 > RSWIN_DESC.Setup_NumRodsPerBundle And CDbl((length / num3)) > 1.5 Then
									num5 = num3
									num16 = length / num3
									num17 = length Mod num3
								End If
							Else
								num16 = 1F
							End If
						ElseIf length > num4 Then
							Dim num15 As Integer = 1
							num4 = num2
							num16 = length / num2
							Dim num17 As Single = length Mod num2
							While num17 <> 0F And num16 >= 1F And num15 < 100
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								num4 = RSWIN_DESC.SETUP_SteelSuckerRodLength * CSng((setup_NumRodsPerBundle + num15))
								num16 = length / num4
								num17 = length Mod num4
								num15 += 1
							End While
							If num16 < 1F Then
								num16 = 1F
							End If
							If num15 > RSWIN_DESC.Setup_NumRodsPerBundle And CDbl((length / num2)) > 1.5 Then
								num4 = num2
								num16 = length / num2
								num17 = length Mod num2
							End If
						Else
							num16 = 1F
						End If
						If num16 > 1F Then
							Dim num18 As Integer = CInt(Math.Round(CDbl(num16)))
							If CDbl(num16) > CDbl(num18) + 0.5 Then
								num19 = num18 + 1
							Else
								num19 = num18
							End If
						Else
							num19 = 1
						End If
					Else
						num19 = 1
					End If
					If num19 = 1 Then
						array2(j) = RSWIN_DESC.rst.Sections(i)
						j += 1
						num7 += 1
					Else
						Dim length As Single = RSWIN_DESC.rst.Sections(i).length
						Dim num20 As Single = CSng(CInt(Math.Round(CDbl((length / CSng(num19))) + 0.5)))
						num20 = cImplementGuideChanges.RoundToNearestSuckerRod(num20, i, False)
						Dim num21 As Single = 0F
						Dim num22 As Integer = 1
						Dim num23 As Integer = num19 - 1
						For k As Integer = num22 To num23
							array2(j) = RSWIN_DESC.rst.Sections(i)
							array2(j).length = num20

								num21 += num20

							j += 1
							num7 += 1
						Next

							num20 = RSWIN_DESC.rst.Sections(i).length - num21
							array2(j) = RSWIN_DESC.rst.Sections(i)
							array2(j).length = num20
							num21 += num20

						j += 1
						num7 += 1
					End If
					i += 1
				End While
				If flag3 Then
					Dim num24 As Integer = iLastTaper + 1
					Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					i = num24
					While i <= numRods3
						array2(j) = RSWIN_DESC.rst.Sections(i)
						j += 1
						num7 += 1
						i += 1
					End While
				End If
				If num7 > CInt(RSWIN_DESC.rst.NumRods) Then
					Dim sections As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(num7 + 1 - 1) {}
					RSWIN_DESC.rst.Sections = sections
					Dim num25 As Integer = 1
					Dim num26 As Integer = num7
					i = num25
					While i <= num26
						RSWIN_DESC.rst.Sections(i).Initialize()
						RSWIN_DESC.rst.Sections(i) = array2(i)
						i += 1
					End While
					RSWIN_DESC.rst.NumRods = CShort(num7)
				End If
				Try
					RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
					array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
					array(0) = 0F
					RSWIN_DESC.taper_lens(0) = 0F
					Dim num27 As Integer = 1
					Dim numRods4 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					j = num27
					While j <= numRods4
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						array(j) = array(j - 1) + RSWIN_DESC.rst.Sections(j).length
						RSWIN_DESC.taper_lens(j) = array(j)
						Dim fricCoeff As Single = RODUTIL.GetFricCoeff(CInt(RSWIN_DESC.rst.Sections(j).Guide), True)
						If fricCoeff <> RSWIN_DESC.rst.Sections(j).friction_coef AndAlso flag Then
							RSWIN_DESC.rst.Sections(j).friction_coef = fricCoeff
						End If
						j += 1
					End While
				Catch ex As Exception
				End Try
				Try
					cImplementGuideChanges.InitializeGuideFrequencyArrays2()
				Catch ex2 As Exception
				End Try
				Try
					Dim num28 As Integer
					cImplementGuideChanges.InitSummaryReportXML2(num28)
				Catch ex3 As Exception
				End Try
				Try
					cImplementGuideChanges.DetermineMaxNumRodGuides(False)
				Catch ex4 As Exception
				End Try
			Catch ex5 As Exception
			End Try
		End Sub

		Public Function CheckSideLoads(fTaperDepthBegin As Single, fTaperDepthEnd As Single, ByRef fMaxSideLoad As Single, ByRef bFirstHalf As Boolean, ByRef bSecondHalf As Boolean, ByRef fFirstHalfDepth As Single, ByRef fSecondHalfDepth As Single) As Boolean
			Dim flag As Boolean = False
			fMaxSideLoad = 0F
			Dim result As Boolean
			Try
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				Dim num As Integer = CInt(Math.Round(Conversion.Int(CDbl((RSWIN_DESC.rst.PumpDepth / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
				Dim num2 As Integer = 0
				Dim num3 As Single = 0F
				Dim num4 As Short = 1S
				Dim numRods As Short = RSWIN_DESC.rst.NumRods
				For num5 As Short = num4 To numRods
					num3 += RSWIN_DESC.rst.Sections(CInt(num5)).length
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num5)).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(CInt(num5)).Grade)) Then
						' The following expression was wrapped in a unchecked-expression
						num2 = CInt(Math.Round(CDbl(num2) + Conversion.Int(CDbl(RSWIN_DESC.rst.Sections(CInt(num5)).length) / 37.5 + 0.5)))
					Else
						' The following expression was wrapped in a unchecked-expression
						num2 = CInt(Math.Round(CDbl(num2) + Conversion.Int(CDbl((RSWIN_DESC.rst.Sections(CInt(num5)).length / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
					End If
				Next
				Dim num6 As Single = (fTaperDepthEnd + fTaperDepthBegin) / 2F
				bFirstHalf = False
				bSecondHalf = False
				fFirstHalfDepth = 0F
				fSecondHalfDepth = -1F
				num3 = 0F
				Dim num7 As Short = 1S
				Dim num8 As Short = CShort(num2)
				For num5 As Short = num7 To num8
					Try
						If RSWIN_DESC.rod_suckerrodlength(CInt(num5)) <> 0F Then
							num3 += RSWIN_DESC.rod_suckerrodlength(CInt(num5))
						Else
							num3 += RSWIN_DESC.SETUP_SteelSuckerRodLength
						End If
						If num3 >= fTaperDepthBegin And num3 <= fTaperDepthEnd Then
							Dim num9 As Single = RSWIN_DESC.rod_sideloads(CInt(num5))
							Dim indx As Integer
							MImpred.GetSectionIndex(num3, indx)
							Dim sideLoadPerGuide As Single = cImplementGuideChanges.GetSideLoadPerGuide(indx)
							If num9 >= sideLoadPerGuide Then
								flag = True
								If num9 > fMaxSideLoad Then
									fMaxSideLoad = num9
								End If
								If num3 <= num6 Then
									bFirstHalf = True
									fFirstHalfDepth = num3
								ElseIf num3 > num6 Then
									bSecondHalf = True
									If fSecondHalfDepth = -1F Then
										fSecondHalfDepth = num3
										Exit Try
									End If
								End If
							End If
						End If
					Catch ex As Exception
					End Try
				Next
				result = flag
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Public Function FindFirstLastSideLoads(ByRef fFirstSideLoad As Single, ByRef fLastSideLoad As Single, ByRef fFirstDepth As Single, ByRef fLastDepth As Single, bPushingGuides As Boolean, ByRef fDiffUp As Single, ByRef fDiffDown As Single) As Boolean
			Dim flag As Boolean = False
			Dim num As Single = 0F
			Dim pumpDepth As Single = RSWIN_DESC.rst.PumpDepth
			fFirstSideLoad = 0F
			fLastSideLoad = 0F
			fFirstDepth = 0F
			fLastDepth = 0F
			Dim result As Boolean
			Try
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				Dim num2 As Integer = CInt(Math.Round(Conversion.Int(CDbl((RSWIN_DESC.rst.PumpDepth / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
				Dim num3 As Integer = 0
				Dim num4 As Single = 0F
				Dim num5 As Short = 1S
				Dim numRods As Short = RSWIN_DESC.rst.NumRods
				For num6 As Short = num5 To numRods
					num4 += RSWIN_DESC.rst.Sections(CInt(num6)).length
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num6)).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(CInt(num6)).Grade)) Then
						' The following expression was wrapped in a unchecked-expression
						num3 = CInt(Math.Round(CDbl(num3) + Conversion.Int(CDbl(RSWIN_DESC.rst.Sections(CInt(num6)).length) / 37.5 + 0.5)))
					Else
						' The following expression was wrapped in a unchecked-expression
						num3 = CInt(Math.Round(CDbl(num3) + Conversion.Int(CDbl((RSWIN_DESC.rst.Sections(CInt(num6)).length / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
					End If
				Next
				num4 = 0F
				Dim num7 As Short = 1S
				Dim num8 As Short = CShort(num3)
				For num6 As Short = num7 To num8
					Try
						If RSWIN_DESC.rod_suckerrodlength(CInt(num6)) <> 0F Then
							num4 += RSWIN_DESC.rod_suckerrodlength(CInt(num6))
						Else
							num4 += RSWIN_DESC.SETUP_SteelSuckerRodLength
						End If
						If num4 >= num And num4 <= pumpDepth Then
							Dim num9 As Single = RSWIN_DESC.rod_sideloads(CInt(num6))
							If RSWIN_DESC.bConsiderSideLoadPerGuide Then
								Dim indx As Integer
								MImpred.GetSectionIndex(num4, indx)
								Dim sideLoadPerGuide As Single = cImplementGuideChanges.GetSideLoadPerGuide(indx)
								If num9 > 0F And fFirstSideLoad = 0F And num9 >= RSWIN_DESC.SETUP_MaxSideLoadLimit Then
									fFirstSideLoad = num9
									fFirstDepth = num4
								End If
								If num9 > 0F And num9 >= RSWIN_DESC.SETUP_MaxSideLoadLimit Then
									fLastSideLoad = num9
									fLastDepth = num4
								End If
							Else
								If num9 > 0F And fFirstSideLoad = 0F Then
									fFirstSideLoad = num9
									fFirstDepth = num4
								End If
								If num9 > 0F Then
									fLastSideLoad = num9
									fLastDepth = num4
								End If
							End If
						End If
					Catch ex As Exception
					End Try
				Next
				fDiffUp = 0F
				fDiffDown = 0F
				If Not bPushingGuides Then
					If fFirstDepth > 0F And fFirstDepth - RSWIN_DESC.SETUP_SteelSuckerRodLength * 3F > 0F And fFirstDepth > 300F Then
						fDiffUp = RSWIN_DESC.SETUP_SteelSuckerRodLength * 3F
						fFirstDepth -= RSWIN_DESC.SETUP_SteelSuckerRodLength * 3F
					ElseIf fFirstDepth > 0F And fFirstDepth - RSWIN_DESC.SETUP_SteelSuckerRodLength * 2F > 0F And fFirstDepth > 100F Then
						fDiffUp = RSWIN_DESC.SETUP_SteelSuckerRodLength * 2F
						fFirstDepth -= RSWIN_DESC.SETUP_SteelSuckerRodLength * 2F
					ElseIf fFirstDepth > 0F And fFirstDepth - RSWIN_DESC.SETUP_SteelSuckerRodLength > 0F Then
						fDiffUp = RSWIN_DESC.SETUP_SteelSuckerRodLength
						fFirstDepth -= RSWIN_DESC.SETUP_SteelSuckerRodLength
					End If
					If fLastDepth > 0F And fLastDepth + RSWIN_DESC.SETUP_SteelSuckerRodLength < RSWIN_DESC.rst.PumpDepth And fFirstDepth > 50F Then
						fDiffDown = RSWIN_DESC.SETUP_SteelSuckerRodLength
						fLastDepth += RSWIN_DESC.SETUP_SteelSuckerRodLength
					End If
				End If
				If fFirstDepth <> 0F And fLastDepth <> 0F And fFirstSideLoad <> 0F And fLastSideLoad <> 0F Then
					flag = True
				End If
				result = flag
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Public Sub InitializeGuideFrequencyArrays2()
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					RSWIN_DESC.GuideFrequencyArray(i).SectionLength = RSWIN_DESC.rst.Sections(i).length
					RSWIN_DESC.GuideFrequencyArray(i).NumberOfSubSections = 0
					RSWIN_DESC.GuideFrequencyArray(i).SubSections = New RSWIN_DESC.SubSectionType(0) {}
					RSWIN_DESC.GuideFrequencyArray(i).SubSections(0).Length = 0F
					RSWIN_DESC.GuideFrequencyArray(i).SubSections(0).Added = False
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Then
						RSWIN_DESC.GuideFrequencyArray(i).SuckerRodLength = 37.5F
					Else
						RSWIN_DESC.GuideFrequencyArray(i).SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
					End If
				Next
				If RSWIN_DESC.rst.NumRods > 1S Then
					Dim num2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					Dim flag As Boolean = True
					Dim num3 As Integer = 1
					While flag
						num3 = num2
						flag = False
						num2 -= 1
						If num2 = 0 Then
							flag = False
						End If
					End While
					If num3 > 1 Then
						Dim i As Integer = num3
						If RSWIN_DESC.GuideFrequencyArray(i).SectionLength >= 600F Then
							RSWIN_DESC.GuideFrequencyArray(i).NumberOfSubSections = 2
							RSWIN_DESC.GuideFrequencyArray(i).SubSections = New RSWIN_DESC.SubSectionType(2) {}
							Dim j As Integer = 1
							Do
								RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).Length = RSWIN_DESC.GuideFrequencyArray(i).SectionLength / 2F
								RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).Added = False
								j += 1
							Loop While j <= 2
						Else
							RSWIN_DESC.GuideFrequencyArray(i).NumberOfSubSections = 1
							RSWIN_DESC.GuideFrequencyArray(i).SubSections = New RSWIN_DESC.SubSectionType(1) {}
							RSWIN_DESC.GuideFrequencyArray(i).SubSections(1).Length = RSWIN_DESC.GuideFrequencyArray(i).SectionLength
							RSWIN_DESC.GuideFrequencyArray(i).SubSections(1).Added = False
						End If
						i = num3 - 1
						While i >= 1
							If RSWIN_DESC.GuideFrequencyArray(i).SectionLength >= 600F Then
								RSWIN_DESC.GuideFrequencyArray(i).NumberOfSubSections = 2
								RSWIN_DESC.GuideFrequencyArray(i).SubSections = New RSWIN_DESC.SubSectionType(2) {}
								Dim j As Integer = 1
								Do
									RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).Length = RSWIN_DESC.GuideFrequencyArray(i).SectionLength / 2F
									RSWIN_DESC.GuideFrequencyArray(i).SubSections(j).Added = False
									j += 1
								Loop While j <= 2
							Else
								RSWIN_DESC.GuideFrequencyArray(i).NumberOfSubSections = 1
								RSWIN_DESC.GuideFrequencyArray(i).SubSections = New RSWIN_DESC.SubSectionType(1) {}
								RSWIN_DESC.GuideFrequencyArray(i).SubSections(1).Length = RSWIN_DESC.GuideFrequencyArray(i).SectionLength
								RSWIN_DESC.GuideFrequencyArray(i).SubSections(1).Added = False
							End If
							i += -1
						End While
					End If
				End If
				RSWIN_DESC.GuideFrequencyArray(1).SectionDepth = RSWIN_DESC.GuideFrequencyArray(1).SectionLength
				Dim num4 As Integer = 2
				Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num4 To numRods2
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					RSWIN_DESC.GuideFrequencyArray(i).SectionDepth = RSWIN_DESC.GuideFrequencyArray(i - 1).SectionDepth + RSWIN_DESC.GuideFrequencyArray(i).SectionLength
				Next
				RSWIN_DESC.GuideFrequencyArray(0).SectionDepth = 0F
				Dim num5 As Integer = 1
				Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num5 To numRods3
					Dim num6 As Integer = i
					RSWIN_DESC.GuideFrequencyArray(num6).SubSections(0).Depth = RSWIN_DESC.GuideFrequencyArray(i - 1).SectionDepth
					Dim num7 As Integer = 1
					Dim numberOfSubSections As Integer = RSWIN_DESC.GuideFrequencyArray(num6).NumberOfSubSections
					For j As Integer = num7 To numberOfSubSections
						Try
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Grade = RSWIN_DESC.rst.Sections(i).Grade
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).RodType = RSWIN_DESC.rst.Sections(i).RodType
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Diameter = RSWIN_DESC.rst.Sections(i).Diameter
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Area = RSWIN_DESC.rst.Sections(i).Area
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodLength = RSWIN_DESC.rst.Sections(i).SuckerRodLength
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).RodDensity = RSWIN_DESC.rst.Sections(i).RodDensity
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).RodWeight = RSWIN_DESC.rst.Sections(i).RodWeight
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Elasticity = RSWIN_DESC.rst.Sections(i).Elasticity
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).TensileStrength = RSWIN_DESC.rst.Sections(i).TensileStrength
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).StressMethod = RSWIN_DESC.rst.Sections(i).StressMethod
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Guide = RSWIN_DESC.rst.Sections(i).Guide
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).friction_coef = RSWIN_DESC.rst.Sections(i).friction_coef
						Catch ex As Exception
						End Try
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).NumberOfSuckerRodsInSection = CInt(Math.Round(CDbl((RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Length / RSWIN_DESC.GuideFrequencyArray(i).SuckerRodLength)) + 0.5))
						Dim numberOfSuckerRodsInSection As Integer = RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).NumberOfSuckerRodsInSection
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodDepths = New Single(numberOfSuckerRodsInSection + 1 - 1) {}
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodNumGuides = New Single(numberOfSuckerRodsInSection + 1 - 1) {}
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Start = RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j - 1).Depth
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Depth = RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j - 1).Depth + RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Length
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodDepths(0) = RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).Start
						RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodNumGuides(0) = 0F
						Dim num8 As Integer = 1
						Dim num9 As Integer = numberOfSuckerRodsInSection
						For k As Integer = num8 To num9
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodDepths(k) = RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodDepths(k - 1) + RSWIN_DESC.GuideFrequencyArray(i).SuckerRodLength
							RSWIN_DESC.GuideFrequencyArray(num6).SubSections(j).SuckerRodNumGuides(k) = 0F
						Next
					Next
				Next
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub InitSummaryReportXML2(ByRef iNumOfLines As Integer)
			Dim bGuidesEntered As Boolean = False
			Dim num As Single = 30F
			Dim num2 As Single = 50F
			Dim num3 As Single = 50F
			Dim num4 As Single = 30F
			Dim num5 As Single = 70F
			Dim num6 As Single = 100F
			Dim num7 As Single = 60F
			Dim num8 As Single = 50F
			Try
				RSWIN_DESC.MaxRecNumGuides = New Integer(40) {}
				RSWIN_DESC.MaxRecNumGuides_2 = New Integer(80) {}
				Dim num9 As Short = 1S
				Do
					RSWIN_DESC.MaxRecNumGuides(CInt(num9)) = 0
					RSWIN_DESC.MaxRecNumGuides_2(CInt(num9)) = 0
					num9 += 1S
				Loop While num9 <= 40S
				num9 = 41S
				Do
					RSWIN_DESC.MaxRecNumGuides_2(CInt(num9)) = 0
					num9 += 1S
				Loop While num9 <= 80S
				Dim setup_BAREROD_LOAD As Single = RSWIN_DESC.SETUP_BAREROD_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(setup_BAREROD_LOAD, "l", False)
				End If
				Dim setup_MOLDEDGUIDE_LOAD As Single = RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(setup_MOLDEDGUIDE_LOAD, "l", False)
				End If
				Dim setup_WHEELGUIDE_LOAD As Single = RSWIN_DESC.SETUP_WHEELGUIDE_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(setup_WHEELGUIDE_LOAD, "l", False)
				End If
				Dim setup_OTHERGUIDE_LOAD As Single = RSWIN_DESC.SETUP_OTHERGUIDE_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(setup_OTHERGUIDE_LOAD, "l", False)
				End If
				num = RSWIN_DESC.SETUP_NorrisStandardGuide_Load
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(num, "l", False)
				End If
				num2 = RSWIN_DESC.SETUP_NorrisSidewinderGuide_Load
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(num2, "l", False)
				End If
				num3 = RSWIN_DESC.SETUP_RGIJakeCouplingGuide_Load
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(num3, "l", False)
				End If
				num4 = RSWIN_DESC.SETUP_RGISVTGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(num4, "l", False)
				End If
				num5 = RSWIN_DESC.SETUP_RGITomahawkGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(num5, "l", False)
				End If
				num6 = RSWIN_DESC.SETUP_RGITornadoGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(num6, "l", False)
				End If
				num7 = RSWIN_DESC.SETUP_RGITwisterGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(num7, "l", False)
				End If
				num8 = RSWIN_DESC.SETUP_RGIWVTGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(num8, "l", False)
				End If
				Dim text As String = ""
				Dim num10 As Short = 0S
				iNumOfLines = 0
				Dim num11 As Integer = CInt(Math.Round(Conversion.Int(CDbl((RSWIN_DESC.rst.PumpDepth / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
				Dim num12 As Integer = 0
				Dim num13 As Single = 0F
				Dim num14 As Short = 1S
				Dim numRods As Short = RSWIN_DESC.rst.NumRods
				num9 = num14
				While num9 <= numRods
					num13 += RSWIN_DESC.rst.Sections(CInt(num9)).length
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num9)).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(CInt(num9)).Grade)) Then
						' The following expression was wrapped in a unchecked-expression
						num12 = CInt(Math.Round(CDbl(num12) + Conversion.Int(CDbl(RSWIN_DESC.rst.Sections(CInt(num9)).length) / 37.5 + 0.5)))
					Else
						' The following expression was wrapped in a unchecked-expression
						num12 = CInt(Math.Round(CDbl(num12) + Conversion.Int(CDbl((RSWIN_DESC.rst.Sections(CInt(num9)).length / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
					End If
					num9 += 1S
				End While
				Dim teimpred As TEImpred
				Dim num15 As Short
				Dim num16 As Short
				RSWIN_DESC.rod_sideloads = New Single(num12 + 1 - 1) {}
				RSWIN_DESC.rod_num_guides = New Integer(0) {}
				RSWIN_DESC.rod_num_guides = New Integer(num12 + 1 - 1) {}
				RSWIN_DESC.rod_num_depths = New Single(0) {}
				RSWIN_DESC.rod_num_depths = New Single(num12 + 1 - 1) {}
				RSWIN_DESC.rod_suckerrodlength = New Single(0) {}
				RSWIN_DESC.rod_suckerrodlength = New Single(num12 + 1 - 1) {}
				MImpred.GetRodSideLoads(RSWIN_DESC.rod_sideloads, RSWIN_DESC.rod_suckerrodlength, True)
				RSWIN_DESC.rod_num_guides(0) = 0
				RSWIN_DESC.rod_num_depths(0) = 0F
				RSWIN_DESC.iSumMOLDED = 0
				RSWIN_DESC.iSumWHEELED = 0
				RSWIN_DESC.iSumOther = 0
				RSWIN_DESC.iSumNorrisStandard = 0
				RSWIN_DESC.iSumNorrisSidewinder = 0
				RSWIN_DESC.iSumRGIJakeCoupling = 0
				RSWIN_DESC.iSumRGISVT = 0
				RSWIN_DESC.iSumRGITomahawk = 0
				RSWIN_DESC.iSumRGITornado = 0
				RSWIN_DESC.iSumRGITwister = 0
				RSWIN_DESC.iSumRGIWVT = 0
				num13 = 0F
				Try
					teimpred = New TEImpred()
					teimpred = MImpred.ImpredObj
				Catch ex As Exception
				End Try
				num15 = 1S
				num16 = CShort(num12)
				num9 = num15
				While num9 <= num16
					Try
						Dim num17 As Integer
						iNumOfLines += 1
						num17 = 0
						If RSWIN_DESC.rod_suckerrodlength(CInt(num9)) <> 0F Then
							num13 += RSWIN_DESC.rod_suckerrodlength(CInt(num9))
						Else
							num13 += RSWIN_DESC.SETUP_SteelSuckerRodLength
						End If
						MImpred.GetSectionIndex(num13, num17)
						Dim num18 As Single = RSWIN_DESC.rod_sideloads(CInt(num9))
						Try
							Dim flag As Boolean
							Dim text2 As String
							Dim flag2 As Boolean
							Dim text3 As String
							Dim text4 As String
							cImplementGuideChanges.GetGuideAndNum(num17, CDbl(num13), CDbl(num18), text, num10, flag, text2, flag2, text3, text4, bGuidesEntered, teimpred.num_rod_elements)
						Catch ex2 As Exception
						End Try
						RSWIN_DESC.rod_num_guides(CInt(num9)) = CInt(num10)
						RSWIN_DESC.rod_num_depths(CInt(num9)) = num13
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							CtrlUI.ConvertValue(num18, "l", False)
						End If
						If num10 <> 0S And num18 <> 0F Then
							If num17 = 0 Then
								MImpred.GetSectionIndex(num13, num17)
							End If
							If CInt(num10) > RSWIN_DESC.MaxRecNumGuides(num17) Then
								RSWIN_DESC.MaxRecNumGuides(num17) = CInt(num10)
							End If
							Try
								cImplementGuideChanges.GuideFrequencyArrayIndex(num17, num13, CInt(num10))
							Catch ex3 As Exception
							End Try
							Dim num19 As Integer
							MImpred.GetSectionIndex2(num13, num19)
							If CInt(num10) > RSWIN_DESC.MaxRecNumGuides_2(num19) Then
								RSWIN_DESC.MaxRecNumGuides_2(num19) = CInt(num10)
							End If
						End If
					Catch ex4 As Exception
					End Try
					num9 += 1S
				End While
			Catch ex5 As Exception
			End Try
		End Sub

		Private Sub GetGuideAndNum(Indx As Integer, fDepth As Double, fMaxSideLoad As Double, ByRef sGuide As String, ByRef iNumOfGuides As Short, ByRef bMinFootnote As Boolean, ByRef sMinFootnote As String, ByRef bMaxFootnote As Boolean, ByRef sMaxFootnote As String, ByRef sGuideMsg As String, bGuidesEntered As Boolean, iNumRodElements As Integer)
			Dim num As Double = 0.0
			iNumOfGuides = 0S
			Try
				If Indx <> 0 Then
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(Indx).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(Indx).Grade)) Then
					End If
				End If
			Catch ex As Exception
			End Try
			Dim num2 As Short = 1S
			Dim numRods As Short = RSWIN_DESC.rst.NumRods
			Dim num4 As Short
			For num3 As Short = num2 To numRods
				num += CDbl(RSWIN_DESC.rst.Sections(CInt(num3)).length)
				If fDepth < num Then
					num4 = num3
					Exit For
				End If
				If fDepth = num Then
					num4 = num3
					Exit For
				End If
				If fDepth > CDbl(RSWIN_DESC.rst.PumpDepth) Then
					num4 = RSWIN_DESC.rst.NumRods
					Exit For
				End If
			Next
			Dim guideType As Short = MImpred.GetGuideType(RSWIN_DESC.rst.Sections(CInt(num4)).Guide, CInt(num4))
			Dim num5 As Short = guideType
			If num5 = RSWIN_DESC.MOLDED Then
				sGuide = "Molded"
				If fMaxSideLoad >= CDbl(RSWIN_DESC.SETUP_MaxSideLoadLimit) Then
					Dim num6 As Single = CSng((fMaxSideLoad / CDbl(RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD)))
					iNumOfGuides = CShort(Math.Round(Conversion.Int(fMaxSideLoad / CDbl(RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD) + 0.5)))
					If num6 > CSng(iNumOfGuides) Then
						iNumOfGuides += 1S
					End If
				Else
					iNumOfGuides = 0S
				End If
			ElseIf num5 = 2S Then
				sGuide = "Wheeled"
				If fMaxSideLoad >= CDbl(RSWIN_DESC.SETUP_MaxSideLoadLimit) Then
					Dim num6 As Single = CSng((fMaxSideLoad / CDbl(RSWIN_DESC.SETUP_WHEELGUIDE_LOAD)))
					iNumOfGuides = CShort(Math.Round(Conversion.Int(fMaxSideLoad / CDbl(RSWIN_DESC.SETUP_WHEELGUIDE_LOAD) + 0.5)))
					If num6 > CSng(iNumOfGuides) Then
						iNumOfGuides += 1S
					End If
				Else
					iNumOfGuides = 0S
				End If
			ElseIf num5 = 3S Then
				Dim text As String = New String(" "c, 8192)
				Dim text2 As String = "OtherGuide"
				Dim text3 As String = "Other"
				Dim length As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, text, True))
				sGuide = text.Substring(0, CInt(length))
				If fMaxSideLoad >= CDbl(RSWIN_DESC.SETUP_MaxSideLoadLimit) Then
					Dim num6 As Single = CSng((fMaxSideLoad / CDbl(RSWIN_DESC.SETUP_OTHERGUIDE_LOAD)))
					iNumOfGuides = CShort(Math.Round(Conversion.Int(fMaxSideLoad / CDbl(RSWIN_DESC.SETUP_OTHERGUIDE_LOAD) + 0.5)))
					If num6 > CSng(iNumOfGuides) Then
						iNumOfGuides += 1S
					End If
				Else
					iNumOfGuides = 0S
				End If
			ElseIf num5 = 4S OrElse num5 = RSWIN_DESC.NorrisSidewinderGuide OrElse num5 = 6S OrElse num5 = 7S OrElse num5 = 8S OrElse num5 = 9S OrElse num5 = 10S OrElse num5 = 11S Then
				Dim num7 As Single
				If num7 = 0F Then
					Try
						MImpred.GetSidewinderNameAndLoad(guideType, num7)
					Catch ex2 As Exception
					End Try
				End If
				sGuide = MImpred.GetSidewinderNameAndLoad(guideType, num7)
				If fMaxSideLoad >= CDbl(RSWIN_DESC.SETUP_MaxSideLoadLimit) Then
					Dim num6 As Single = CSng((fMaxSideLoad / CDbl(num7)))
					iNumOfGuides = CShort(Math.Round(Conversion.Int(fMaxSideLoad / CDbl(num7) + 0.5)))
					If num6 > CSng(iNumOfGuides) Then
						iNumOfGuides += 1S
					End If
				End If
			End If
			sGuideMsg = " "
			If iNumOfGuides > 0S And Not RSWIN_DESC.bHasGuides Then
				RSWIN_DESC.bHasGuides = True
			End If
			If RSWIN_DESC.bHasGuides Then
				Dim num8 As Short = guideType
				If num8 = RSWIN_DESC.MOLDED Then
					RSWIN_DESC.iSumMOLDED += 1
				ElseIf num8 = 2S Then
					RSWIN_DESC.iSumWHEELED += 1
				ElseIf num8 = 3S Then
					RSWIN_DESC.iSumOther += 1
				ElseIf num8 = 4S Then
					RSWIN_DESC.iSumNorrisStandard += 1
				ElseIf num8 = RSWIN_DESC.NorrisSidewinderGuide Then
					RSWIN_DESC.iSumNorrisSidewinder += 1
				ElseIf num8 = 6S Then
					RSWIN_DESC.iSumRGIJakeCoupling += 1
				ElseIf num8 = 7S Then
					RSWIN_DESC.iSumRGISVT += 1
				ElseIf num8 = 8S Then
					RSWIN_DESC.iSumRGITomahawk += 1
				ElseIf num8 = 9S Then
					RSWIN_DESC.iSumRGITornado += 1
				ElseIf num8 = 10S Then
					RSWIN_DESC.iSumRGITwister += 1
				ElseIf num8 = 11S Then
					RSWIN_DESC.iSumRGIWVT += 1
				End If
				Return
			End If
		End Sub

		Public Sub GuideFrequencyArrayIndex(Indx As Integer, fDepth As Single, iNumGuides As Integer)
			Dim flag As Boolean = True
			Try
				Dim num As Integer = 1
				Dim numberOfSubSections As Integer = RSWIN_DESC.GuideFrequencyArray(Indx).NumberOfSubSections
				For i As Integer = num To numberOfSubSections
					Dim depth As Single = RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).Depth
					If fDepth < depth Then
						If Not flag Then
							Dim num2 As Integer = 1
							Dim numberOfSuckerRodsInSection As Integer = RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).NumberOfSuckerRodsInSection
							For j As Integer = num2 To numberOfSuckerRodsInSection
								Dim num3 As Single = RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).SuckerRodDepths(j)
								If fDepth <= num3 Then
									RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).SuckerRodNumGuides(j) = CSng(iNumGuides)
								End If
							Next
						Else
							RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).SuckerRodNumGuides(0) = 0F
							Dim num4 As Integer = 1
							Dim numberOfSuckerRodsInSection2 As Integer = RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).NumberOfSuckerRodsInSection
							For j As Integer = num4 To numberOfSuckerRodsInSection2
								Dim num3 As Single = RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).SuckerRodDepths(j)
								Dim num5 As Single = RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).SuckerRodDepths(j - 1)
								If fDepth <= num3 And fDepth > num5 Then
									RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).SuckerRodNumGuides(j) = CSng(iNumGuides)
									Exit For
								End If
							Next
						End If
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Function RoundToSuckerRodLength(fOldLength As Single, Optional bGoDown As Boolean = True) As Single
			Dim result As Single
			Try
				Dim num As Single = fOldLength Mod RSWIN_DESC.SETUP_SteelSuckerRodLength
				If num = 0F Then
					result = fOldLength
				Else
					' The following expression was wrapped in a checked-expression
					Dim num2 As Single = CSng((CLng(Math.Round(CDbl(fOldLength))) / 1L))
					num = num2 Mod RSWIN_DESC.SETUP_SteelSuckerRodLength
					While num <> 0F
						If bGoDown Then
							num2 -= 1F
						Else
							num2 += 1F
						End If
						num = num2 Mod RSWIN_DESC.SETUP_SteelSuckerRodLength
					End While
					result = num2
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub NewImplementationLogic(iIteration As Integer)
			' The following expression was wrapped in a checked-statement
			Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
			Dim num As Single = 0F
			Dim num2 As Single = 0F
			Dim num3 As Single = 0F
			Dim num4 As Single = 0F
			Dim array2 As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
			Dim flag As Boolean = False
			Dim flag2 As Boolean = True
			Try
				Util.BusyCursor()
				Dim num6 As Integer
				Dim num7 As Single
				Dim num8 As Single
				Try
					Try
						RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
						array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
						array(0) = 0F
						RSWIN_DESC.taper_lens(0) = 0F
						Dim num5 As Integer = 1
						Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num5 To numRods2
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							array(i) = array(i - 1) + RSWIN_DESC.rst.Sections(i).length
							RSWIN_DESC.taper_lens(i) = array(i)
						Next
					Catch ex As Exception
					End Try
					Try
						cImplementGuideChanges.InitializeGuideFrequencyArrays2()
					Catch ex2 As Exception
					End Try
					Try
						cImplementGuideChanges.InitSummaryReportXML2(num6)
					Catch ex3 As Exception
					End Try
					Try
						cImplementGuideChanges.DetermineMaxNumRodGuides(False)
					Catch ex4 As Exception
					End Try
					Dim flag3 As Boolean = cImplementGuideChanges.FindFirstLastSideLoads(num, num2, num3, num4, False, num7, num8)
				Catch ex5 As Exception
				End Try
				If num > 0F And num2 > 0F Then
					Try
						Dim num9 As Integer
						Dim num12 As Integer

							Try
								MImpred.GetSectionIndex(num3, num9)
								Dim num10 As Single
								If num9 = 1 Then
									num10 = num3
								Else
									' The following expression was wrapped in a checked-expression
									num10 = num3 - array(num9 - 1)
								End If
								num10 = cImplementGuideChanges.RoundToNearestSuckerRod(num10, num9, False)
								If RSWIN_DESC.rst.Sections(num9).length >= 300F And num10 >= 100F And RSWIN_DESC.rst.Sections(num9).length - num10 >= 150F Then
									cImplementGuideChanges.NewAddRodSection(num9, num9, False, False, True, False, num10, True, False, False, False)
								End If
								Try
									Try
										RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
										array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
										array(0) = 0F
										RSWIN_DESC.taper_lens(0) = 0F
										Dim num11 As Integer = 1
										Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
										For i As Integer = num11 To numRods3
											' The following expression was wrapped in a unchecked-expression
											' The following expression was wrapped in a checked-expression
											array(i) = array(i - 1) + RSWIN_DESC.rst.Sections(i).length
											RSWIN_DESC.taper_lens(i) = array(i)
										Next
									Catch ex6 As Exception
									End Try
									Dim flag3 As Boolean = cImplementGuideChanges.FindFirstLastSideLoads(num, num2, num3, num4, False, num7, num8)
								Catch ex7 As Exception
								End Try
								MImpred.GetSectionIndex(num4, num12)
								If num12 = 1 Then
									num10 = num4
								Else
									' The following expression was wrapped in a checked-expression
									num10 = num4 - array(num12 - 1)
								End If
								num10 = cImplementGuideChanges.RoundToNearestSuckerRod(num10, num12, False)
								If RSWIN_DESC.rst.Sections(num12).length > 300F And num10 >= 100F And RSWIN_DESC.rst.Sections(num12).length - num10 >= 150F Then
									cImplementGuideChanges.NewAddRodSection(num12, num12, False, False, False, True, num10, True, False, False, False)
								End If
							Catch ex8 As Exception
							End Try

						Try
							Try
								RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
								array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
								array(0) = 0F
								RSWIN_DESC.taper_lens(0) = 0F
								Dim num13 As Integer = 1
								Dim numRods4 As Integer = CInt(RSWIN_DESC.rst.NumRods)
								For i As Integer = num13 To numRods4
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a checked-expression
									array(i) = array(i - 1) + RSWIN_DESC.rst.Sections(i).length
									RSWIN_DESC.taper_lens(i) = array(i)
								Next
							Catch ex9 As Exception
							End Try
							Dim flag3 As Boolean = cImplementGuideChanges.FindFirstLastSideLoads(num, num2, num3, num4, False, num7, num8)
							Debug.WriteLine(String.Concat(New String() { Conversions.ToString(num), " , ", Conversions.ToString(num3), " , ", Conversions.ToString(num2), " , ", Conversions.ToString(num4) }))
						Catch ex10 As Exception
						End Try
						MImpred.GetSectionIndex(num3, num9)
						MImpred.GetSectionIndex(num4, num12)
						If num4 - num3 / CSng(RSWIN_DESC.Setup_NumRodsPerBundle) > 20F And RSWIN_DESC.Setup_NumRodsPerBundle < 20 Then
							RSWIN_DESC.Setup_NumRodsPerBundle = 20
						End If
						cImplementGuideChanges.NewDivideTapers(num9, num12)
						Try
							RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
							array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
							array(0) = 0F
							RSWIN_DESC.taper_lens(0) = 0F
							Dim num14 As Integer = 1
							Dim numRods5 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num14 To numRods5
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								array(i) = array(i - 1) + RSWIN_DESC.rst.Sections(i).length
								RSWIN_DESC.taper_lens(i) = array(i)
							Next
						Catch ex11 As Exception
						End Try
						If numRods <> CInt(RSWIN_DESC.rst.NumRods) Then
							Try
								RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
								array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
								RSWIN_DESC.GuideFrequencyArray = New RSWIN_DESC.GuideFrequencyStructure(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
								array(0) = 0F
								RSWIN_DESC.taper_lens(0) = 0F
								Dim num15 As Integer = 1
								Dim numRods6 As Integer = CInt(RSWIN_DESC.rst.NumRods)
								For i As Integer = num15 To numRods6
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a checked-expression
									array(i) = array(i - 1) + RSWIN_DESC.rst.Sections(i).length
									RSWIN_DESC.taper_lens(i) = array(i)
								Next
							Catch ex12 As Exception
							End Try
							Try
								cImplementGuideChanges.InitializeGuideFrequencyArrays2()
							Catch ex13 As Exception
							End Try
							Try
								cImplementGuideChanges.InitSummaryReportXML2(num6)
							Catch ex14 As Exception
							End Try
							Try
								cImplementGuideChanges.DetermineMaxNumRodGuides(False)
							Catch ex15 As Exception
							End Try
							If flag2 Then
								Try
									Dim flag4 As Boolean = cImplementGuideChanges.CheckAllTapers()
								Catch ex16 As Exception
								End Try
							End If
							Dim num16 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							Dim flag5 As Boolean = True
							While flag5
								Try
									flag = False
									Dim num17 As Integer = 1
									Dim num18 As Integer = CInt((RSWIN_DESC.rst.NumRods - 1S))
									For i As Integer = num17 To num18
										Dim num19 As Integer = i + 1
										If RSWIN_DESC.rst.Sections(i).Grade = RSWIN_DESC.rst.Sections(num19).Grade And RSWIN_DESC.rst.Sections(i).Diameter = RSWIN_DESC.rst.Sections(num19).Diameter And RSWIN_DESC.rst.Sections(i).friction_coef = RSWIN_DESC.rst.Sections(num19).friction_coef And RSWIN_DESC.rst.Sections(i).NumGuides = RSWIN_DESC.rst.Sections(num19).NumGuides Then
											' The following expression was wrapped in a unchecked-expression
											RSWIN_DESC.rst.Sections(i).length = RSWIN_DESC.rst.Sections(i).length + RSWIN_DESC.rst.Sections(num19).length
											RSWIN_DESC.rst.Sections(num19).length = 0F
											flag = True
											num16 -= 1
										End If
									Next
								Catch ex17 As Exception
								End Try
								If flag Then
									Dim num20 As Integer = 0
									array2 = New RSWIN_DESC.RodSection(num20 + 1 - 1) {}
									Dim num21 As Integer = 1
									Dim numRods7 As Integer = CInt(RSWIN_DESC.rst.NumRods)
									For i As Integer = num21 To numRods7
										If RSWIN_DESC.rst.Sections(i).length <> 0F Then
											num20 += 1
											array2 = CType(Utils.CopyArray(CType(array2, Array), New RSWIN_DESC.RodSection(num20 + 1 - 1) {}), RSWIN_DESC.RodSection())
											array2(num20) = RSWIN_DESC.rst.Sections(i)
										End If
									Next
									If num20 < CInt(RSWIN_DESC.rst.NumRods) Then
										RSWIN_DESC.rst.NumRods = CShort(num20)
										Dim sections As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
										RSWIN_DESC.rst.Sections = sections
										Dim num22 As Integer = 1
										Dim num23 As Integer = num20
										For i As Integer = num22 To num23
											RSWIN_DESC.rst.Sections(i) = array2(i)
										Next
									End If
									RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
									array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
									Try
										array(0) = 0F
										RSWIN_DESC.taper_lens(0) = 0F
										Dim num24 As Integer = 1
										Dim numRods8 As Integer = CInt(RSWIN_DESC.rst.NumRods)
										For i As Integer = num24 To numRods8
											' The following expression was wrapped in a unchecked-expression
											' The following expression was wrapped in a checked-expression
											array(i) = array(i - 1) + RSWIN_DESC.rst.Sections(i).length
											RSWIN_DESC.taper_lens(i) = array(i)
										Next
									Catch ex18 As Exception
									End Try
									Try
										cImplementGuideChanges.InitializeGuideFrequencyArrays2()
									Catch ex19 As Exception
									End Try
									Try
										cImplementGuideChanges.InitSummaryReportXML2(num6)
									Catch ex20 As Exception
									End Try
									Try
										cImplementGuideChanges.DetermineMaxNumRodGuides(False)
									Catch ex21 As Exception
									End Try
								End If
								flag5 = flag
							End While
						End If
					Catch ex22 As Exception
					End Try
				End If
				Dim numRods9 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				Try
					RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
					array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
					array(0) = 0F
					RSWIN_DESC.taper_lens(0) = 0F
					Dim num25 As Integer = 1
					Dim numRods10 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num25 To numRods10
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						array(i) = array(i - 1) + RSWIN_DESC.rst.Sections(i).length
						RSWIN_DESC.taper_lens(i) = array(i)
					Next
				Catch ex23 As Exception
				End Try
				Dim num26 As Integer = 1
				Dim numRods11 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num26 To numRods11
					Dim numGuides As Integer = CInt(RSWIN_DESC.rst.Sections(i).NumGuides)
					Dim flag6 As Boolean = RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(i).Grade))
					If flag6 Then
						If numGuides <> 0 And numGuides > RSWIN_DESC.SETUP_MaxNumGuidesPerRod And RSWIN_DESC.SETUP_MaxNumGuidesPerRod <> 0 Then
							RSWIN_DESC.rst.Sections(i).NumGuides = CShort(RSWIN_DESC.SETUP_MaxNumGuidesPerRod)
						End If
					ElseIf numGuides <> 0 And numGuides > RSWIN_DESC.SETUP_MaxNumGuidesPerRod And RSWIN_DESC.SETUP_MaxNumGuidesPerRod <> 0 Then
						RSWIN_DESC.rst.Sections(i).NumGuides = CShort(RSWIN_DESC.SETUP_MaxNumGuidesPerRod)
					End If
					If numGuides <> 0 And numGuides < RSWIN_DESC.SETUP_MinNumGuidesPerRod And RSWIN_DESC.SETUP_MinNumGuidesPerRod <> 0 Then
						RSWIN_DESC.rst.Sections(i).NumGuides = CShort(RSWIN_DESC.SETUP_MinNumGuidesPerRod)
					End If
				Next
			Catch ex24 As Exception
			End Try
		End Sub

		Public Function CheckImplementationChanges(ByRef bAllZeroGuides As Boolean) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				bAllZeroGuides = True
				Try
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						If RSWIN_DESC.rst.Sections(i).NumGuides <> 0S Then
							bAllZeroGuides = False
							Exit For
						End If
					Next
				Catch ex As Exception
				End Try
				If CInt(RSWIN_DESC.rst.NumRods) <> cImplementGuideChanges.iOrigNumRods Then
					flag = True
				Else
					Try
						Dim num2 As Integer = 1
						Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num2 To numRods2
							If RSWIN_DESC.rst.Sections(i).length <> RSWIN_DESC.SaveSections(i).length Or RSWIN_DESC.rst.Sections(i).NumGuides <> RSWIN_DESC.SaveSections(i).NumGuides Then
								flag = True
								Exit For
							End If
						Next
					Catch ex2 As Exception
					End Try
				End If
				result = flag
			Catch ex3 As Exception
				result = True
			End Try
			Return result
		End Function

		Public Function CurrentSolutionSameAsPrevious(iIndx As Integer) As Boolean
			Dim result As Boolean = True
			If iIndx = 1 Then
				result = False
			ElseIf RSWIN_DESC.saved_num_rods(1) <> RSWIN_DESC.saved_num_rods(2) Then
				result = False
			Else
				Try
					Dim num As Integer = RSWIN_DESC.saved_num_rods(2)
					Dim num2 As Integer = 1
					Dim num3 As Integer = num
					For i As Integer = num2 To num3
						If RSWIN_DESC.saved_rod_designs(1).Sections(i).Grade <> RSWIN_DESC.saved_rod_designs(2).Sections(i).Grade Or RSWIN_DESC.saved_rod_designs(1).Sections(i).NumGuides <> RSWIN_DESC.saved_rod_designs(2).Sections(i).NumGuides Then
							result = False
							Exit For
						End If
					Next
				Catch ex As Exception
					result = False
				End Try
			End If
			Return result
		End Function

		Public Function CheckImplementationResults() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim num As Integer = 0
				Dim array As Integer() = New Integer(40) {}
				Dim text As String = "RODSTAR-D recommends guides on taper #. Would you like to use recommended guides?"
				Dim text2 As String = "RODSTAR-D recommends guides on tapers #. Would you like to use recommended guides?"
				Dim flag As Boolean = False
				Dim num2 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num2 To numRods
					If RSWIN_DESC.rst.Sections(i).Guide = 0S And RSWIN_DESC.rst.Sections(i).NumGuides > 0S Then
						num += 1
						array(num) = i
					ElseIf RSWIN_DESC.rst.Sections(i).NumGuides = 0S And RSWIN_DESC.rst.Sections(i).Guide <> 0S Then
						RSWIN_DESC.rst.Sections(i).Guide = 0S
					End If
				Next
				If num = 1 Then
					text = text.Replace("#", Conversions.ToString(array(num)))
					RSWIN_DESC.rst.Sections(array(num)).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
					RSWIN_DESC.rst.Sections(array(num)).friction_coef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
					flag = True
				ElseIf num > 1 Then
					Dim text3 As String = Conversions.ToString(array(1))
					Dim num3 As Integer = 2
					Dim num4 As Integer = num
					For i As Integer = num3 To num4
						If i = num Then
							text3 = text3 + ", and " + Conversions.ToString(array(i))
						Else
							text3 = text3 + ", " + Conversions.ToString(array(i))
						End If
					Next
					text2 = text2.Replace("#", text3)
					Dim num5 As Integer = 1
					Dim num6 As Integer = num
					For i As Integer = num5 To num6
						Debug.WriteLine(array(i))
						RSWIN_DESC.rst.Sections(array(i)).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
						RSWIN_DESC.rst.Sections(array(i)).friction_coef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
						flag = True
					Next
				End If
				Try
					Dim num7 As Integer = 1
					Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num7 To numRods2
						If RSWIN_DESC.rst.Sections(i).NumGuides = 0S And RSWIN_DESC.rst.Sections(i).Guide <> 0S Then
							RSWIN_DESC.rst.Sections(i).Guide = 0S
						End If
						If RSWIN_DESC.rst.Sections(i).Guide = 0S Or RSWIN_DESC.rst.Sections(i).NumGuides = 0S Then
							RSWIN_DESC.rst.Sections(i).friction_coef = 0.2F
						End If
					Next
				Catch ex As Exception
				End Try
				result = flag
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Public Sub ExecuteImplementation()
			Dim flag As Boolean = True
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim array As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
			Dim flag4 As Boolean = False
			Dim array2 As Single() = New Single(40) {}
			RSWIN_DESC.bSuppressWarningMessages_Override = True
			RSWIN_DESC.rst.RodStringType = 2S
			Dim num As Single
			Try
				Try
					Dim sideLoadPerGuide As Single = cImplementGuideChanges.GetSideLoadPerGuide(-1)
					Dim text As String = "MaxSideLoadLimit"
					num = 30F
					RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, num))
				Catch ex As Exception
				End Try
				Try
					If RSWIN_DESC.rst.gbParaffin And RSWIN_DESC.rst.ParaffinDepth > 0F Then
						Dim text As String = "ParaffinRodGuide"
						Dim setup_GuideToUse As Integer = RSWIN_DESC.SETUP_GuideToUse
						Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, setup_GuideToUse)
						RSWIN_DESC.SETUP_GuideToUse = setup_GuideToUse
						RSWIN_DESC.SETUP_ParaffinRodGuide = Conversions.ToInteger(regProfileStringByInt)
					End If
				Catch ex2 As Exception
				End Try
				Dim i As Integer = 1
				Do
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					RSWIN_DESC.saved_rod_designs(i).Initialize()
					Try
						Dim num2 As Integer = 1
						Do
							RSWIN_DESC.saved_rod_designs(i).Sections(num2).Initialize()
							num2 += 1
						Loop While num2 <= 40
					Catch ex3 As Exception
					End Try
					Try
						RSWIN_DESC.saved_rst(i) = New cRODSTAR()
						RSWIN_DESC.saved_rst(i) = RSWIN_DESC.saved_rst(0)
					Catch ex4 As Exception
					End Try
					Try
						RSWIN_DESC.saved_Impred(i) = New TEImpred()
						Dim teimpred As TEImpred = New TEImpred()
						teimpred = MImpred.ImpredObj
						RSWIN_DESC.saved_Impred(i) = New TEImpred()
						RSWIN_DESC.saved_Impred(i) = RSWIN_DESC.saved_Impred(0)
					Catch ex5 As Exception
					End Try
					i += 1
				Loop While i <= 2
			Catch ex6 As Exception
			End Try
			Dim flag5 As Boolean
			Try
				If RSWIN_DESC.SETUP_GuideToUse >= 6 Then
					cImplementGuideChanges.iMinGuide = 3
				Else
					cImplementGuideChanges.iMinGuide = 4
				End If
				If RSWIN_DESC.SaveRodStringType = 2S Then
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					flag4 = True
					Dim num3 As Integer = 1
					Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					Dim guide As Integer
					For i As Integer = num3 To numRods2
						If RSWIN_DESC.rst.Sections(i).Guide <> 0S Then
							flag4 = False
							guide = CInt(RSWIN_DESC.rst.Sections(i).Guide)
						End If
					Next
					numRods = CInt(RSWIN_DESC.rst.NumRods)
					Dim num4 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					flag = True
					While flag
						Try
							flag5 = False
							Dim num5 As Integer = 1
							Dim num6 As Integer = CInt((RSWIN_DESC.rst.NumRods - 1S))
							For i As Integer = num5 To num6
								Dim num7 As Integer = i + 1
								If RSWIN_DESC.rst.Sections(i).Grade = RSWIN_DESC.rst.Sections(num7).Grade And RSWIN_DESC.rst.Sections(i).Diameter = RSWIN_DESC.rst.Sections(num7).Diameter Then
									' The following expression was wrapped in a unchecked-expression
									RSWIN_DESC.rst.Sections(i).length = RSWIN_DESC.rst.Sections(i).length + RSWIN_DESC.rst.Sections(num7).length
									RSWIN_DESC.rst.Sections(num7).length = 0F
									flag5 = True
									num4 -= 1
								End If
							Next
						Catch ex7 As Exception
						End Try
						If flag5 Then
							Dim num2 As Integer = 0
							array = New RSWIN_DESC.RodSection(num2 + 1 - 1) {}
							Dim num8 As Integer = 1
							Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num8 To numRods3
								If RSWIN_DESC.rst.Sections(i).length <> 0F Then
									num2 += 1
									array = CType(Utils.CopyArray(CType(array, Array), New RSWIN_DESC.RodSection(num2 + 1 - 1) {}), RSWIN_DESC.RodSection())
									array(num2) = RSWIN_DESC.rst.Sections(i)
								End If
							Next
							If num2 < CInt(RSWIN_DESC.rst.NumRods) Then
								RSWIN_DESC.rst.NumRods = CShort(num2)
								Dim sections As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
								RSWIN_DESC.rst.Sections = sections
								Dim num9 As Integer = 1
								Dim num10 As Integer = num2
								For i As Integer = num9 To num10
									RSWIN_DESC.rst.Sections(i) = array(i)
								Next
							End If
						End If
						flag = flag5
					End While
					If numRods <> CInt(RSWIN_DESC.rst.NumRods) Then
						RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
						array2 = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
						Try
							array2(0) = 0F
							RSWIN_DESC.taper_lens(0) = 0F
							Dim num11 As Integer = 1
							Dim numRods4 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num11 To numRods4
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								array2(i) = array2(i - 1) + RSWIN_DESC.rst.Sections(i).length
								RSWIN_DESC.taper_lens(i) = array2(i)
								If flag4 Then
									RSWIN_DESC.rst.Sections(i).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
								ElseIf RSWIN_DESC.rst.Sections(i).Guide = 0S Then
									RSWIN_DESC.rst.Sections(i).Guide = CShort(guide)
								End If
							Next
						Catch ex8 As Exception
						End Try
					End If
				End If
			Catch ex9 As Exception
			End Try
			Dim num12 As Integer = 1
			Dim numRods5 As Integer = CInt(RSWIN_DESC.rst.NumRods)
			For i As Integer = num12 To numRods5
				If RSWIN_DESC.rst.Sections(i).Guide <> 0S And CInt(RSWIN_DESC.rst.Sections(i).Guide) <> RSWIN_DESC.SETUP_GuideToUse Then
					RSWIN_DESC.rst.Sections(i).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
				End If
			Next
			Dim num13 As Integer = 1
			RSWIN_DESC.iBundleIncr = 0
			flag = True
			Dim text2 As String
			While flag
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				Try
					cImplementGuideChanges.NewImplementationLogic(num13)
				Catch ex10 As Exception
				End Try
				Try
					Dim flag6 As Boolean = cImplementGuideChanges.CheckImplementationChanges(flag2)
					If Not(flag6 And Not flag2) Then
						Application.DoEvents()
						Exit Try
					End If
					If num13 = 1 Then
						RSWIN_DESC.SETUP_RECOMMEND_GUIDES = False
						Try
							Dim text As String = "RecommendGuides"
							text2 = Conversions.ToString(RSWIN_DESC.SETUP_RECOMMEND_GUIDES)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_RECOMMEND_GUIDES = Conversions.ToBoolean(text2)
						Catch ex11 As Exception
						End Try
					End If
					Try
						Dim num14 As Integer = 1
						Dim numRods6 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num14 To numRods6
							Dim fricCoeff As Single = RODUTIL.GetFricCoeff(CInt(RSWIN_DESC.rst.Sections(i).Guide), True)
							If fricCoeff <> RSWIN_DESC.rst.Sections(i).friction_coef Then
								RSWIN_DESC.rst.Sections(i).friction_coef = fricCoeff
							End If
						Next
					Catch ex12 As Exception
					End Try
					Try
						Application.DoEvents()
						Util.BusyCursor()
						Try
							RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
							array2 = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
							array2(0) = 0F
							RSWIN_DESC.taper_lens(0) = 0F
							Dim num15 As Integer = 1
							Dim numRods7 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num15 To numRods7
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								array2(i) = array2(i - 1) + RSWIN_DESC.rst.Sections(i).length
								RSWIN_DESC.taper_lens(i) = array2(i)
							Next
						Catch ex13 As Exception
						End Try
						flag6 = PREDICT.Predict(True, "DesignUser")
						If RSWIN_DESC.bImplementingRodGuides And Not flag6 And RSWIN_DESC.Setup_NumRodsPerBundle < 30 And Not RSWIN_DESC.bRestartImplementation Then
							RSWIN_DESC.Setup_NumRodsPerBundle = 30
							RSWIN_DESC.bRestartImplementation = True
							Return
						End If
						Application.DoEvents()
					Catch ex14 As Exception
					End Try
					If num13 > 1 Then
						Try
							RSWIN_DESC.saved_num_rods(1) = RSWIN_DESC.saved_num_rods(2)
							Dim num16 As Integer = 1
							Dim num17 As Integer = RSWIN_DESC.saved_num_rods(2)
							For i As Integer = num16 To num17
								RSWIN_DESC.saved_rod_designs(1).Sections(i) = RSWIN_DESC.saved_rod_designs(2).Sections(i)
							Next
						Catch ex15 As Exception
						End Try
						Try
							RSWIN_DESC.saved_rst(1) = RSWIN_DESC.saved_rst(2)
						Catch ex16 As Exception
						End Try
						Try
							RSWIN_DESC.saved_Impred(1) = RSWIN_DESC.saved_Impred(2)
						Catch ex17 As Exception
						End Try
					End If
					Try
						RSWIN_DESC.saved_num_rods(2) = CInt(RSWIN_DESC.rst.NumRods)
						Dim num18 As Integer = 1
						Dim numRods8 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num18 To numRods8
							RSWIN_DESC.saved_rod_designs(2).Sections(i) = RSWIN_DESC.rst.Sections(i)
						Next
					Catch ex18 As Exception
					End Try
					Try
						RSWIN_DESC.saved_rst(2) = RSWIN_DESC.rst
					Catch ex19 As Exception
					End Try
					Try
						Dim teimpred As TEImpred = MImpred.ImpredObj
						RSWIN_DESC.saved_Impred(2) = New TEImpred()
						RSWIN_DESC.saved_Impred(2) = teimpred
					Catch ex20 As Exception
					End Try
					num13 += 1
					If num13 > RSWIN_DESC.Setup_NumImplIters Or cImplementGuideChanges.CurrentSolutionSameAsPrevious(num13 - 1) Then
						flag = False
					End If
				Catch ex21 As Exception
					Application.DoEvents()
					Exit Try
				End Try
			End While
			Try
				RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				array2 = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				array2(0) = 0F
				RSWIN_DESC.taper_lens(0) = 0F
				Dim num19 As Integer = 1
				Dim numRods9 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num19 To numRods9
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					array2(i) = array2(i - 1) + RSWIN_DESC.rst.Sections(i).length
					RSWIN_DESC.taper_lens(i) = array2(i)
				Next
			Catch ex22 As Exception
			End Try
			Try
				cImplementGuideChanges.InitializeGuideFrequencyArrays2()
			Catch ex23 As Exception
			End Try
			Dim num20 As Integer
			Try
				cImplementGuideChanges.InitSummaryReportXML2(num20)
			Catch ex24 As Exception
			End Try
			Try
				cImplementGuideChanges.DetermineMaxNumRodGuides(False)
			Catch ex25 As Exception
			End Try
			Dim num21 As Single
			Dim num22 As Single
			Dim num23 As Single
			Dim num24 As Single
			Dim num25 As Single
			Dim num26 As Single
			Try
				Dim flag7 As Boolean = cImplementGuideChanges.FindFirstLastSideLoads(num21, num22, num23, num24, False, num25, num26)
			Catch ex26 As Exception
			End Try
			Try
				Debug.WriteLine("Guides Before Push - ")
				Debug.WriteLine("Taper , length  , Diameter  , friction_coef  , NumGuides  ,  Guide , Depth")
				Dim num27 As Integer = 1
				Dim numRods10 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num27 To numRods10
					Dim sections2 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
					Dim num28 As Integer = i
					Debug.WriteLine(String.Concat(New String() { Conversions.ToString(i), " , ", Conversions.ToString(sections2(num28).length), " , ", Conversions.ToString(sections2(num28).Diameter), " , ", Conversions.ToString(sections2(num28).friction_coef), " , ", Conversions.ToString(CInt(sections2(num28).NumGuides)), " , ", Conversions.ToString(array2(i)) }))
				Next
			Catch ex27 As Exception
			End Try
			Try
				If RSWIN_DESC.rst.gbParaffin And RSWIN_DESC.rst.ParaffinDepth > 0F Then
					Dim flag8 As Boolean = cImplementGuideChanges.PushRodGuidesAndAdjustForParaffin(False)
				End If
			Catch ex28 As Exception
			End Try
			Try
				Debug.WriteLine("Guides After Push (after condense) - ")
				Debug.WriteLine("Taper , length  , Diameter  , friction_coef  , NumGuides  ,  Guide , Depth")
				Dim num29 As Integer = 1
				Dim numRods11 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num29 To numRods11
					Dim sections3 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
					Dim num30 As Integer = i
					Debug.WriteLine(String.Concat(New String() { Conversions.ToString(i), " , ", Conversions.ToString(sections3(num30).length), " , ", Conversions.ToString(sections3(num30).Diameter), " , ", Conversions.ToString(sections3(num30).friction_coef), " , ", Conversions.ToString(CInt(sections3(num30).NumGuides)), " , ", Conversions.ToString(array2(i)) }))
				Next
			Catch ex29 As Exception
			End Try
			Try
				flag3 = cImplementGuideChanges.CheckImplementationResults()
				Try
					Debug.WriteLine("Guides After Push (after CheckImplementationResults) - ")
					Debug.WriteLine("Taper , length  , Diameter  , friction_coef  , NumGuides  ,  Guide , Depth")
					Dim num31 As Integer = 1
					Dim numRods12 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num31 To numRods12
						Dim sections4 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
						Dim num32 As Integer = i
						Debug.WriteLine(String.Concat(New String() { Conversions.ToString(i), " , ", Conversions.ToString(sections4(num32).length), " , ", Conversions.ToString(sections4(num32).Diameter), " , ", Conversions.ToString(sections4(num32).friction_coef), " , ", Conversions.ToString(CInt(sections4(num32).NumGuides)), " , ", Conversions.ToString(array2(i)) }))
					Next
				Catch ex30 As Exception
				End Try
				Try
					Dim flag6 As Boolean = PREDICT.Predict(True, "DesignUser")
				Catch ex31 As Exception
				End Try
				Try
					RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
					array2 = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
					array2(0) = 0F
					RSWIN_DESC.taper_lens(0) = 0F
					Dim num33 As Integer = 1
					Dim numRods13 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num33 To numRods13
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						array2(i) = array2(i - 1) + RSWIN_DESC.rst.Sections(i).length
						RSWIN_DESC.taper_lens(i) = array2(i)
					Next
				Catch ex32 As Exception
				End Try
				Try
					cImplementGuideChanges.InitializeGuideFrequencyArrays2()
				Catch ex33 As Exception
				End Try
				Try
					cImplementGuideChanges.InitSummaryReportXML2(num20)
				Catch ex34 As Exception
				End Try
				Try
					cImplementGuideChanges.DetermineMaxNumRodGuides(True)
				Catch ex35 As Exception
				End Try
				Try
					Dim flag7 As Boolean = cImplementGuideChanges.FindFirstLastSideLoads(num21, num22, num23, num24, False, num25, num26)
				Catch ex36 As Exception
				End Try
				Try
					Debug.WriteLine("Guides After Push (after CheckImplementationResults) - ")
					Debug.WriteLine("Taper , length  , Diameter  , friction_coef  , NumGuides  ,  Guide , Depth")
					Dim num34 As Integer = 1
					Dim numRods14 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num34 To numRods14
						Dim sections5 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
						Dim num35 As Integer = i
						Debug.WriteLine(String.Concat(New String() { Conversions.ToString(i), " , ", Conversions.ToString(sections5(num35).length), " , ", Conversions.ToString(sections5(num35).Diameter), " , ", Conversions.ToString(sections5(num35).friction_coef), " , ", Conversions.ToString(CInt(sections5(num35).NumGuides)), " , ", Conversions.ToString(array2(i)) }))
					Next
				Catch ex37 As Exception
				End Try
			Catch ex38 As Exception
			End Try
			Try
				If RSWIN_DESC.rst.gbParaffin And RSWIN_DESC.rst.ParaffinDepth > 0F Then
					Dim flag8 As Boolean = cImplementGuideChanges.PushRodGuidesAndAdjustForParaffin(False)
					If flag8 Then
						Try
							Dim flag6 As Boolean = PREDICT.Predict(True, "DesignUser")
						Catch ex39 As Exception
						End Try
					End If
				End If
			Catch ex40 As Exception
			End Try
			cImplementGuideChanges.sMaximum = ""
			cImplementGuideChanges.sMinimum = ""
			Dim flag9 As Boolean = False
			Dim num36 As Integer = 1
			Dim numRods15 As Integer = CInt(RSWIN_DESC.rst.NumRods)
			For i As Integer = num36 To numRods15
				Dim numGuides As Integer = CInt(RSWIN_DESC.rst.Sections(i).NumGuides)
				Dim flag10 As Boolean = RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(i).Grade))
				If flag10 Then
					If numGuides <> 0 And (numGuides > 6 Or numGuides > RSWIN_DESC.SETUP_MaxNumGuidesPerRod) And RSWIN_DESC.SETUP_MaxNumGuidesPerRod <> 0 Then
						If RSWIN_DESC.rst.Sections(i).Guide >= 4S Then
							If RSWIN_DESC.SETUP_MaxNumGuidesPerRod <> 6 Then
								cImplementGuideChanges.sMaximum = "* - The manufacturer recommends a maximum of 6 rod guides per rod (maximum number in Setup is " + Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod) + ")."
							Else
								cImplementGuideChanges.sMaximum = "* - The manufacturer recommends a maximum of 6 rod guides per rod."
							End If
							RSWIN_DESC.rst.Sections(i).NumGuides = CShort(RSWIN_DESC.SETUP_MaxNumGuidesPerRod)
							flag9 = True
						ElseIf numGuides > RSWIN_DESC.SETUP_MaxNumGuidesPerRod Then
							cImplementGuideChanges.sMaximum = "* - The maximum number of rod guides per rod in Setup is ." + Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod) + "."
							RSWIN_DESC.rst.Sections(i).NumGuides = CShort(RSWIN_DESC.SETUP_MaxNumGuidesPerRod)
							flag9 = True
						End If
					End If
				ElseIf numGuides <> 0 And (numGuides > 6 Or numGuides > RSWIN_DESC.SETUP_MaxNumGuidesPerRod) And RSWIN_DESC.SETUP_MaxNumGuidesPerRod <> 0 Then
					If RSWIN_DESC.rst.Sections(i).Guide >= 4S Then
						cImplementGuideChanges.sMaximum = Conversions.ToString(Operators.ConcatenateObject("* - The manufacturer recommends a maximum of 6 rod guides per rod.", Interaction.IIf(Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(RSWIN_DESC.SETUP_MaxNumGuidesPerRod, Interaction.IIf(RSWIN_DESC.SETUP_SteelSuckerRodLength > 25F, 12, 10), False))), " The maximum number of rod guides in Setup is " + Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod) + ".", "")))
						RSWIN_DESC.rst.Sections(i).NumGuides = CShort(RSWIN_DESC.SETUP_MaxNumGuidesPerRod)
						flag9 = True
					ElseIf numGuides > RSWIN_DESC.SETUP_MaxNumGuidesPerRod Then
						cImplementGuideChanges.sMaximum = "* - The maximum number of rod guides per rod in Setup is ." + Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod) + "."
						RSWIN_DESC.rst.Sections(i).NumGuides = CShort(RSWIN_DESC.SETUP_MaxNumGuidesPerRod)
						flag9 = True
					End If
				End If
				If numGuides <> 0 And (numGuides < RSWIN_DESC.SETUP_MinNumGuidesPerRod Or numGuides < cImplementGuideChanges.iMinGuide) And RSWIN_DESC.SETUP_MinNumGuidesPerRod <> 0 Then
					If RSWIN_DESC.rst.Sections(i).Guide >= 4S Then
						RSWIN_DESC.rst.Sections(i).NumGuides = CShort(RSWIN_DESC.SETUP_MinNumGuidesPerRod)
						flag9 = True
						cImplementGuideChanges.sMinimum = Conversions.ToString(Operators.ConcatenateObject("** - The manufacturer recommends a minimum of " + Conversions.ToString(cImplementGuideChanges.iMinGuide) + " rod guides per rod.", Interaction.IIf(RSWIN_DESC.SETUP_MinNumGuidesPerRod <> 3, " The minimum number of rod guides in Setup is " + Conversions.ToString(RSWIN_DESC.SETUP_MinNumGuidesPerRod) + ".", "")))
					ElseIf numGuides < RSWIN_DESC.SETUP_MinNumGuidesPerRod Then
						RSWIN_DESC.rst.Sections(i).NumGuides = CShort(RSWIN_DESC.SETUP_MinNumGuidesPerRod)
						flag9 = True
						cImplementGuideChanges.sMinimum = "** - The minimum number of rod guides per rod in Setup is ." + Conversions.ToString(RSWIN_DESC.SETUP_MinNumGuidesPerRod) + "."
					End If
				End If
			Next
			If flag9 OrElse flag3 Then
				Try
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					Dim num4 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					flag = True
					While flag
						Try
							flag5 = False
							Dim num37 As Integer = 1
							Dim num38 As Integer = CInt((RSWIN_DESC.rst.NumRods - 1S))
							For i As Integer = num37 To num38
								Dim num7 As Integer = i + 1
								If RSWIN_DESC.rst.Sections(i).Grade = RSWIN_DESC.rst.Sections(num7).Grade And RSWIN_DESC.rst.Sections(i).Diameter = RSWIN_DESC.rst.Sections(num7).Diameter And RSWIN_DESC.rst.Sections(i).friction_coef = RSWIN_DESC.rst.Sections(num7).friction_coef And RSWIN_DESC.rst.Sections(i).NumGuides = RSWIN_DESC.rst.Sections(num7).NumGuides Then
									' The following expression was wrapped in a unchecked-expression
									RSWIN_DESC.rst.Sections(i).length = RSWIN_DESC.rst.Sections(i).length + RSWIN_DESC.rst.Sections(num7).length
									RSWIN_DESC.rst.Sections(num7).length = 0F
									flag5 = True
									num4 -= 1
								End If
							Next
						Catch ex41 As Exception
						End Try
						If flag5 Then
							Dim num2 As Integer = 0
							array = New RSWIN_DESC.RodSection(num2 + 1 - 1) {}
							Dim num39 As Integer = 1
							Dim numRods16 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num39 To numRods16
								If RSWIN_DESC.rst.Sections(i).length <> 0F Then
									num2 += 1
									array = CType(Utils.CopyArray(CType(array, Array), New RSWIN_DESC.RodSection(num2 + 1 - 1) {}), RSWIN_DESC.RodSection())
									array(num2) = RSWIN_DESC.rst.Sections(i)
								End If
							Next
							If num2 < CInt(RSWIN_DESC.rst.NumRods) Then
								RSWIN_DESC.rst.NumRods = CShort(num2)
								Dim sections As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
								RSWIN_DESC.rst.Sections = sections
								Dim num40 As Integer = 1
								Dim num41 As Integer = num2
								For i As Integer = num40 To num41
									RSWIN_DESC.rst.Sections(i) = array(i)
								Next
							End If
						End If
						flag = flag5
					End While
					If numRods <> CInt(RSWIN_DESC.rst.NumRods) Then
						Try
							RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
							array2 = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
							array2(0) = 0F
							RSWIN_DESC.taper_lens(0) = 0F
							Dim num42 As Integer = 1
							Dim numRods17 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num42 To numRods17
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								array2(i) = array2(i - 1) + RSWIN_DESC.rst.Sections(i).length
								RSWIN_DESC.taper_lens(i) = array2(i)
							Next
						Catch ex42 As Exception
						End Try
					End If
				Catch ex43 As Exception
				End Try
			End If
			text2 = "MaxSideLoadLimit"
			num = 30F
			RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num))
			RSWIN_DESC.rst.bImplementedDesign = True
			RSWIN_DESC.bSuppressWarningMessages_Override = False
		End Sub

		Public Function CheckAllTapers() As Boolean
			' The following expression was wrapped in a checked-expression
			Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Dim flag As Boolean = False
			Dim num As Single = RSWIN_DESC.SETUP_SteelSuckerRodLength * CSng(RSWIN_DESC.Setup_NumRodsPerBundle)
			Dim num2 As Single = CSng((37.5 * CDbl(RSWIN_DESC.Setup_NumRodsPerBundle)))
			Dim result As Boolean
			Try
				Dim i As Integer
				Try
					RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
					array(0) = 0F
					RSWIN_DESC.taper_lens(0) = 0F
					Dim num3 As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					i = num3
					While i <= numRods
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						array(i) = array(i - 1) + RSWIN_DESC.rst.Sections(i).length
						RSWIN_DESC.taper_lens(i) = array(i)
						i += 1
					End While
				Catch ex As Exception
				End Try
				Dim flag2 As Boolean
				Dim num8 As Integer
				Dim num9 As Integer
				Try
					Dim num4 As Single
					Dim num5 As Single
					Dim fDepth As Single
					Dim fDepth2 As Single
					Dim num6 As Single
					Dim num7 As Single
					flag2 = cImplementGuideChanges.FindFirstLastSideLoads(num4, num5, fDepth, fDepth2, False, num6, num7)
					MImpred.GetSectionIndex(fDepth, num8)
					MImpred.GetSectionIndex(fDepth2, num9)
				Catch ex2 As Exception
				End Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num10 As Integer = num8 + 1
				Dim num11 As Integer = num9 - 1
				If RSWIN_DESC.rst.NumRods > 3S And num11 > num10 Then
					Dim num12 As Integer = num10
					Dim num13 As Integer = num11
					For j As Integer = num12 To num13
						Dim num17 As Single
						Try
							Dim num14 As Single
							Dim num15 As Single
							Dim num16 As Single
							flag2 = cImplementGuideChanges.FindFirstLastSideLoadsInTaper(array(j - 1), array(j), num14, num15, num16, num17)
						Catch ex3 As Exception
						End Try
						If flag2 Then
							Dim num18 As Single

								' The following expression was wrapped in a checked-expression
								num18 = num17 - array(j - 1)
								If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Or (CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(i).Grade)) And num18 < num2) Then
									num18 = CSng((CDbl(num2) + 37.5))
								ElseIf num18 < num Then
									num18 = num + RSWIN_DESC.SETUP_SteelSuckerRodLength
								End If
								num18 = cImplementGuideChanges.RoundToNearestSuckerRod(num18, j, False)

							If RSWIN_DESC.rst.Sections(j).NumGuides > 0S And RSWIN_DESC.rst.Sections(j).length > 300F And num18 >= 300F And RSWIN_DESC.rst.Sections(j).length - num18 >= 300F Then
								cImplementGuideChanges.NewAddRodSection(j, j, False, False, False, True, num18, True, False, False, False)
								RSWIN_DESC.rst.Sections(j + 1).NumGuides = 0S
								RSWIN_DESC.rst.Sections(j + 1).friction_coef = 0.2F
								flag = True
								j += 1
								num11 += 1
								Try
									RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
									array = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
									array(0) = 0F
									RSWIN_DESC.taper_lens(0) = 0F
									Dim num19 As Integer = 1
									Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
									i = num19
									While i <= numRods2
										' The following expression was wrapped in a unchecked-expression
										' The following expression was wrapped in a checked-expression
										array(i) = array(i - 1) + RSWIN_DESC.rst.Sections(i).length
										RSWIN_DESC.taper_lens(i) = array(i)
										i += 1
									End While
								Catch ex4 As Exception
								End Try
							End If
						End If
					Next
					If flag Then
						Try
							cImplementGuideChanges.InitializeGuideFrequencyArrays2()
						Catch ex5 As Exception
						End Try
						Try
							Dim num20 As Integer
							cImplementGuideChanges.InitSummaryReportXML2(num20)
						Catch ex6 As Exception
						End Try
						Try
							cImplementGuideChanges.DetermineMaxNumRodGuides(False)
						Catch ex7 As Exception
						End Try
					End If
				End If
				result = flag
			Catch ex8 As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function FindFirstLastSideLoadsInTaper(fTaperDepthBegin As Single, fTaperDepthEnd As Single, ByRef fFirstSideLoad As Single, ByRef fLastSideLoad As Single, ByRef fFirstDepth As Single, ByRef fLastDepth As Single) As Boolean
			Dim flag As Boolean = False
			fFirstSideLoad = 0F
			fLastSideLoad = 0F
			fFirstDepth = 0F
			fLastDepth = 0F
			Dim result As Boolean
			Try
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				Dim num As Integer = CInt(Math.Round(Conversion.Int(CDbl((RSWIN_DESC.rst.PumpDepth / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
				Dim num2 As Integer = 0
				Dim num3 As Single = 0F
				Dim num4 As Short = 1S
				Dim numRods As Short = RSWIN_DESC.rst.NumRods
				For num5 As Short = num4 To numRods
					num3 += RSWIN_DESC.rst.Sections(CInt(num5)).length
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num5)).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(CInt(num5)).Grade)) Then
						' The following expression was wrapped in a unchecked-expression
						num2 = CInt(Math.Round(CDbl(num2) + Conversion.Int(CDbl(RSWIN_DESC.rst.Sections(CInt(num5)).length) / 37.5 + 0.5)))
					Else
						' The following expression was wrapped in a unchecked-expression
						num2 = CInt(Math.Round(CDbl(num2) + Conversion.Int(CDbl((RSWIN_DESC.rst.Sections(CInt(num5)).length / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
					End If
				Next
				num3 = 0F
				Dim num6 As Short = 1S
				Dim num7 As Short = CShort(num2)
				For num5 As Short = num6 To num7
					Try
						If RSWIN_DESC.rod_suckerrodlength(CInt(num5)) <> 0F Then
							num3 += RSWIN_DESC.rod_suckerrodlength(CInt(num5))
						Else
							num3 += RSWIN_DESC.SETUP_SteelSuckerRodLength
						End If
						If num3 >= fTaperDepthBegin And num3 <= fTaperDepthEnd Then
							Dim num8 As Single = RSWIN_DESC.rod_sideloads(CInt(num5))
							If RSWIN_DESC.bConsiderSideLoadPerGuide Then
								Dim indx As Integer
								MImpred.GetSectionIndex(num3, indx)
								Dim sideLoadPerGuide As Single = cImplementGuideChanges.GetSideLoadPerGuide(indx)
								If num8 > 0F And fFirstSideLoad = 0F And num8 >= RSWIN_DESC.SETUP_MaxSideLoadLimit Then
									fFirstSideLoad = num8
									fFirstDepth = num3
								End If
								If num8 > 0F And num8 >= RSWIN_DESC.SETUP_MaxSideLoadLimit Then
									fLastSideLoad = num8
									fLastDepth = num3
								End If
							Else
								If num8 > 0F And fFirstSideLoad = 0F Then
									fFirstSideLoad = num8
									fFirstDepth = num3
								End If
								If num8 > 0F Then
									fLastSideLoad = num8
									fLastDepth = num3
								End If
							End If
						End If
					Catch ex As Exception
					End Try
				Next
				If fFirstDepth > 0F And fFirstDepth - RSWIN_DESC.SETUP_SteelSuckerRodLength * 3F > 0F And fFirstDepth > 300F Then
					fFirstDepth -= RSWIN_DESC.SETUP_SteelSuckerRodLength * 3F
				ElseIf fFirstDepth > 0F And fFirstDepth - RSWIN_DESC.SETUP_SteelSuckerRodLength * 2F > 0F And fFirstDepth > 100F Then
					fFirstDepth -= RSWIN_DESC.SETUP_SteelSuckerRodLength * 2F
				ElseIf fFirstDepth > 0F And fFirstDepth - RSWIN_DESC.SETUP_SteelSuckerRodLength > 0F Then
					fFirstDepth -= RSWIN_DESC.SETUP_SteelSuckerRodLength
				End If
				If fLastDepth > 0F And fLastDepth + RSWIN_DESC.SETUP_SteelSuckerRodLength < RSWIN_DESC.rst.PumpDepth And fFirstDepth > 50F Then
					fLastDepth += RSWIN_DESC.SETUP_SteelSuckerRodLength
				End If
				If fFirstDepth <> 0F And fLastDepth <> 0F And fFirstSideLoad <> 0F And fLastSideLoad <> 0F Then
					flag = True
				End If
				result = flag
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Public Sub UndoGuideImplementation()
			Try
				Try
					RSWIN_DESC.rst = RSWIN_DESC.saved_rst(0)
				Catch ex As Exception
				End Try
				Try
					MImpred.ImpredObj = RSWIN_DESC.saved_Impred(0)
				Catch ex2 As Exception
				End Try
				Util.BusyCursor()
				Dim flag As Boolean
				RSWIN_DESC.rst.NumRods = CShort(cImplementGuideChanges.iOrigNumRods)
				Try
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						RSWIN_DESC.rst.Sections(i) = RSWIN_DESC.SaveSections(i)
					Next
				Catch ex3 As Exception
				End Try
				Try
					flag = PREDICT.Predict(True, "DesignUser")
				Catch ex4 As Exception
				End Try
				Try
					Dim moment As Single = RSWIN_DESC.rst.get_M(RSWIN_DESC.rst.iUnknownM)
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim permLoad As Single() = rst.PermLoad
					Torquebal.CalculatePL(moment, permLoad, RSWIN_DESC.rst.iUnknownM, flag)
					rst.PermLoad = permLoad
				Catch ex5 As Exception
				End Try
				If flag Then
					Try
						flag = MWDown.StressAnalysis()
						If flag Then
							Dim pumpPos As Single() = RSWIN_DESC.rst.PumpPos
							Dim num2 As Single = 0F
							Dim num3 As Single = 0F
							Dim num4 As Single
							Dim num5 As Single
							Util.Maxmin(pumpPos, num4, num5, num2, num3)
							RSWIN_DESC.rst.GrossPumpStroke = num4 - num5
							If(If((-If(((RSWIN_DESC.rst.BPDsurface = 0F Or Not RSWIN_DESC.bRodStarD) > False), 1S, 0S)), 1S, 0S) Or (If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.SETUP_UseImpred)) <> 0S Then
								RSWIN_DESC.rst.BPDsurface = RUNCALC.BPDsurf(RSWIN_DESC.rst.GrossPumpStroke - RSWIN_DESC.rst.TubStretch, RSWIN_DESC.rst.SPM, RSWIN_DESC.rst.PlungerSize, RSWIN_DESC.rst.Pfill) * RSWIN_DESC.rst.Runtime / 24F
								If RSWIN_DESC.rst.PumpCondition = 2S Or RSWIN_DESC.rst.PumpCondition = 3S Then
									RSWIN_DESC.rst.BPDsurface = RSWIN_DESC.rst.BPDsurface * RSWIN_DESC.rst.PumpEfficiency / 100F
								End If
							End If
							RSWIN_DESC.rst.ProductionLoss = RUNCALC.BPDsurf(RSWIN_DESC.rst.TubStretch, RSWIN_DESC.rst.SPM, RSWIN_DESC.rst.PlungerSize, RSWIN_DESC.rst.Pfill) * RSWIN_DESC.rst.Runtime / 24F
						End If
					Catch ex6 As Exception
					End Try
				End If
			Catch ex7 As Exception
			End Try
			Try
				RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				RSWIN_DESC.taper_lens(0) = 0F
				Dim num6 As Integer = 1
				Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num6 To numRods2
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					RSWIN_DESC.taper_lens(i) = RSWIN_DESC.taper_lens(i - 1) + RSWIN_DESC.rst.Sections(i).length
				Next
			Catch ex8 As Exception
			End Try
			Try
				Dim num7 As Integer
				Dim flag2 As Boolean
				Dim text As String
				Dim flag3 As Boolean
				Dim text2 As String
				Dim text3 As String
				MImpred.InitSummaryReportXML(num7, flag2, text, flag3, text2, text3)
			Catch ex9 As Exception
			End Try
		End Sub

		Private iMinGuide As Integer

		Private fSplit As Single() = New Single(40) {}

		Private f200 As Single() = New Single(40) {}

		Private f300 As Single() = New Single(40) {}

		Private f400 As Single() = New Single(40) {}

		Private m_iOrigNumRods As Integer

		Private m_sMaximum As String

		Private m_sMinimum As String
	End Module
End Namespace
