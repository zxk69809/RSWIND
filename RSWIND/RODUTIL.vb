Imports System
Imports System.Collections
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices
Imports ThetaStdInfo

Namespace RSWINV3
	Friend NotInheritable Module RODUTIL
		Public Sub Split2(S As String, Ncols As Object, ByRef Arr As Single(,))
			Dim start As Short = 1S
			Dim num As Short = 1S
			Dim num2 As Short = 0S
			Dim num3 As Short
			Do
				num3 = CShort(Strings.InStr(CInt(start), S, ",", CompareMethod.Binary))
				If num3 > 0S Then
					num2 += 1S
					If Operators.ConditionalCompareObjectEqual(Operators.ModObject(num2, Ncols), 0, False) Then
						num += 1S
					End If
					start = num3 + 1S
				End If
			Loop While num3 <> 0S
			Arr = New Single(CInt((num + 1S)) - 1, Conversions.ToInteger(Ncols) + 1 - 1) {}
			start = 1S
			Dim num4 As Short = 1S
			Dim num5 As Short = 1S
			Do
				Dim num6 As Single = CSng(Conversion.Val(Strings.Mid(S, CInt(start))))
				Arr(CInt(num4), CInt(num5)) = num6
				num5 += 1S
				If Operators.ConditionalCompareObjectGreater(num5, Ncols, False) Then
					num5 = 1S
					num4 += 1S
				End If
				num3 = CShort(Strings.InStr(CInt(start), S, ",", CompareMethod.Binary))
				If num3 > 0S Then
					start = num3 + 1S
				End If
			Loop While num3 <> 0S
		End Sub

		Public Function CheckRodAvailability(bQuiet As Boolean, iGrade As Short, bSinkerBar As Boolean, Diameter As Single) As Boolean
			Dim num As Integer
			Dim flag As Boolean
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				flag = True
				IL_0B:
				GoTo IL_4E
				IL_0D:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_21:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_0D
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_4E:
			Dim result As Boolean = flag
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub GetAPITable(ByRef RodPercent As Single(), APIRod As Object, PlungerSize As Single)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Short
				Dim num2 As Short
				If Operators.ConditionalCompareObjectGreaterEqual(APIRod, 1000, False) Then
					num = Conversions.ToShort(Operators.IntDivideObject(APIRod, 100))
					num2 = Conversions.ToShort(Operators.ModObject(APIRod, 100))
				Else
					num = Conversions.ToShort(Operators.IntDivideObject(APIRod, 10))
					num2 = Conversions.ToShort(Operators.ModObject(APIRod, 10))
				End If
				Dim num3 As Short = num - num2 + 1S
				If RODUTIL.$STATIC$GetAPITable$031101DC1CC$dp Is Nothing Then
					Dim obj As Object = Strings.Split("1.06,1.25,1.5,1.75,2.0,2.25,2.5,2.75,3.25,3.75,4.75", ",", -1, CompareMethod.Binary)
					RODUTIL.$STATIC$GetAPITable$031101DC1CC$dp = New Single(Information.UBound(CType(obj, Array), 1) + 1 - 1) {}
					Dim num4 As Short = CShort(Information.LBound(CType(obj, Array), 1))
					Dim num5 As Short = CShort(Information.UBound(CType(obj, Array), 1))

						For num6 As Short = num4 To num5
							RODUTIL.$STATIC$GetAPITable$031101DC1CC$dp(CInt(num6)) = Convert.ToSingle(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { num6 }, Nothing)))
						Next

				End If
				Dim text As String
				If Operators.ConditionalCompareObjectEqual(APIRod, 54, False) Then
					text = ".446, .495, .564, .646, .737, .834, .935"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 64, False) Then
					text = ".333,.331, .372,.359, .423,.404, .474,.452"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 65, False) Then
					text = ".344, .373, .418, .469, .520, .584, .652, .725, .881"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 75, False) Then
					text = ".270,.274, .294,.298, .333,.333, .378,.370, .424,.413, .469,.458"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 76, False) Then
					text = ".285, .306, .338, .375, .417, .465, .508, .565, .687, .823"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 85, False) Then
					text = ".222,.224,.224, .239,.242,.243, .267,.274,.268, .296,.304,.295"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 86, False) Then
					text = ".226,.230, .243,.245, .268,.270, .294,.300, .328,.332, .369,.360, .406,.397, .445,.433"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 87, False) Then
					text = ".243, .257, .277, .303, .332, .364, .399, .439, .516, .612, .836"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 96, False) Then
					text = ".191,.192,.195, .205,.205,.207, .224,.225,.228, .248,.251,.251, .271,.279,.274, .296,.307,.298"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 97, False) Then
					text = ".196,.200, .208,.212, .225,.230, .245,.250, .268,.274, .294,.302, .325,.331, .361,.353, .429,.419"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 98, False) Then
					text = ".212, .222, .238, .257, .277, .301, .327, .356, .422, .497, .657"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 107, False) Then
					text = ".169,.168,.171, .179,.178,.180, .194,.192,.195, .210,.210,.212, .227,.228,.231, .250,.250,.250, .269,.277,.271, .291,.302,.293"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 108, False) Then
					text = ".173,.178, .181,.186, .194,.199, .209,.214, .226,.230, .245,.250, .265,.272, .287,.296, .346,.339, .406,.395"
				ElseIf Operators.ConditionalCompareObjectEqual(APIRod, 109, False) Then
					text = ".189, .196, .207, .221, .237, .254, .272, .294, .342, .399, .515"
				Else
					text = ""
				End If
				If Strings.Len(text) > 0 Then
					Dim apitable As Single(,) = New Single(0, 0) {}
					RSWIN_DESC.rst.APITable = apitable
					Dim s As String = text
					Dim ncols As Object = CInt((num3 - 1S))
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					apitable = rst.APITable
					RODUTIL.Split2(s, ncols, apitable)
					rst.APITable = apitable
				ElseIf num3 > 1S Then
					Dim apitable As Single(,) = New Single(1, CInt((num3 + 1S)) - 1) {}
					RSWIN_DESC.rst.APITable = apitable
					Dim num7 As Short = 1S
					Dim num8 As Short = num3 - 1S

						For num9 As Short = num7 To num8
							RSWIN_DESC.rst.APITable(1, CInt(num9)) = CSng((1.0 / CDbl(num3)))
						Next

				End If
				RodPercent = New Single(CInt((num3 + 1S)) - 1) {}
				RodPercent(CInt(num3)) = 1F
				If num3 > 1S Then
					Dim num10 As Short = CShort(Information.UBound(RSWIN_DESC.rst.APITable, 1))
					Dim num11 As Short = 1S
					Dim num12 As Short = num10 - 1S

						Dim num6 As Short
						num6 = num11
						While num6 <= num12
							If PlungerSize <= RODUTIL.$STATIC$GetAPITable$031101DC1CC$dp(CInt(num6)) Then
								Exit While
							End If
							num6 += 1S
						End While
						Dim num13 As Short = 1S
						Dim num14 As Short = num3 - 1S
						For num9 As Short = num13 To num14
							RodPercent(CInt(num9)) = RSWIN_DESC.rst.APITable(CInt(num6), CInt(num9))
							RodPercent(CInt(num3)) = RodPercent(CInt(num3)) - RodPercent(CInt(num9))
						Next

				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetPinSize(iGrade As Short, Diameter As Single) As Single
			Dim result As Single
			Try
				If RODUTIL.IsFG(iGrade) Then
					If Diameter <= 0.75F Then
						result = 0.625F
					ElseIf Diameter <= 0.875F Then
						result = 0.75F
					ElseIf Diameter <= 1F Then
						result = 0.875F
					ElseIf Diameter <= 1.25F Then
						If iGrade = 16387S And Diameter = 1.125F Then
							result = 0.875F
						Else
							result = 1F
						End If
					Else
						result = 1.125F
					End If
				ElseIf Diameter >= 2F Then
					result = 1F
				ElseIf Diameter >= 1.625F Then
					result = 0.875F
				ElseIf Diameter >= 1.375F Then
					result = 0.75F
				ElseIf Diameter >= 1.25F Then
					If iGrade = 4116S Or iGrade = 4101S Then
						result = 1.125F
					Else
						result = 0.625F
					End If
				Else
					result = Diameter
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsAPI(iGrade As Object, sRodType As String) As Short
			Dim result As Short
			Try
				Dim rodSection As RSWIN_DESC.RodSection
				rodSection.Grade = Conversions.ToShort(iGrade)
				rodSection.RodType = sRodType
				result = If((-If(((RODUTIL.LookupStressMethod(rodSection) = 0) > False), 1S, 0S)), 1S, 0S)
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsCorod(iRodGrade As Short) As Boolean
			Dim result As Boolean
			Try
				result = (RODUTIL.RodType(iRodGrade) = 3)
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsCorodH(iRodGrade As Short) As Boolean
			Dim result As Boolean
			Try
				result = False
				If RODUTIL.IsCorod(iRodGrade) Then
					Dim num As Short = iRodGrade And 3840S
					If num = 768S Then
						result = True
					End If
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsCorodR(iRodGrade As Short) As Boolean
			Dim result As Boolean
			Try
				result = False
				If RODUTIL.IsCorod(iRodGrade) Then
					Dim num As Short = iRodGrade And 3840S
					If num = 512S Then
						result = True
					End If
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsCorodSE(iRodGrade As Short) As Boolean
			Dim result As Boolean
			Try
				result = False
				If RODUTIL.IsCorod(iRodGrade) Then
					Dim num As Short = iRodGrade And 3840S
					If num = 256S Then
						result = True
					End If
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsCrankBalanced(UnitType As Short) As Boolean
			Return UnitType <> 6S And UnitType <> 7S And UnitType <> 8S And UnitType <> 10S
		End Function

		Public Function IsFG(iRodGrade As Short) As Boolean
			Dim result As Boolean
			Try
				result = False
				Select Case RODUTIL.RodType(iRodGrade)
					Case 4, 5
						result = True
				End Select
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsNoNeck(iRodGrade As Short) As Boolean
			Dim result As Boolean
			Try
				result = False
				If iRodGrade = 8197S OrElse iRodGrade = 8198S OrElse iRodGrade = 8199S OrElse iRodGrade = 8200S OrElse iRodGrade = 8306S OrElse iRodGrade = 8308S OrElse iRodGrade = 8310S Then
					result = True
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsRibbonRod(iRodGrade As Short) As Boolean
			Dim result As Boolean
			Try
				result = (RODUTIL.RodType(iRodGrade) = 5)
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsSinkerBar(sect As Object) As Boolean
			Dim result As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If RODUTIL.IsSinkerBarGrade(rst.Sections(Conversions.ToInteger(sect)).Grade) Then
					result = True
				Else
					result = False
					If RODUTIL.IsSteel(RuntimeHelpers.GetObjectValue(sect)) Then
						If Conversions.ToBoolean(Operators.AndObject(CDbl(rst.Sections(Conversions.ToInteger(sect)).Diameter) > 1.25, Operators.CompareObjectNotEqual(sect, 1, False))) Then
							result = True
						ElseIf Conversions.ToBoolean(Operators.AndObject(CDbl(rst.Sections(Conversions.ToInteger(sect)).Diameter) = 1.25, Operators.CompareObjectNotEqual(sect, 1, False))) Then
							Dim num As Short = 1S
							Dim numRods As Short = rst.NumRods
							For num2 As Short = num To numRods
								If CDbl(rst.Sections(CInt(num2)).Diameter) <> 1.25 Then
									result = True
									Exit For
								End If
							Next
						End If
					End If
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsSinkerBar1(iRodGrade As Object, sRodType As String) As Boolean
			Dim result As Boolean
			Try
				result = False
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If RODUTIL.RodType(RuntimeHelpers.GetObjectValue(iRodGrade)) = 2 Then
					result = True
				ElseIf CUSTOMRG.IsOtherSinkerBar(Conversions.ToInteger(iRodGrade)) Then
					Dim num As Short = 1S
					Dim num2 As Short = CShort(Information.UBound(RSWIN_DESC.CustomRodGradeList, 1))
					For num3 As Short = num To num2
						If(RSWIN_DESC.CustomRodGradeList(CInt(num3)).Steel And RSWIN_DESC.CustomRodGradeList(CInt(num3)).SinkerBar And If((-If(((Operators.CompareString(Strings.Trim(sRodType), Strings.Trim(RSWIN_DESC.CustomRodGradeList(CInt(num3)).RodType), False) = 0) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							result = True
							Exit For
						End If
					Next
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsSinkerBarGrade(iRodGrade As Object) As Boolean
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8193, False) Then
					If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8197, False) Then
						If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8194, False) Then
							If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8198, False) Then
								If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8195, False) Then
									If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8199, False) Then
										If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8196, False) Then
											If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8200, False) Then
												If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8301, False) Then
													If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8302, False) Then
														If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8303, False) Then
															If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8304, False) Then
																If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8305, False) Then
																	If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8306, False) Then
																		If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8307, False) Then
																			If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8308, False) Then
																				If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8309, False) Then
																					If Not Operators.ConditionalCompareObjectEqual(iRodGrade, 8310, False) Then
																						flag = False
																					End If
																				End If
																			End If
																		End If
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsSteel(iRodGrade As Object) As Boolean
			Dim result As Boolean
			Try
				result = False
				Select Case RODUTIL.RodType(RuntimeHelpers.GetObjectValue(iRodGrade))
					Case 1, 2, 3
						result = True
				End Select
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub MakeAPIString(fPumpDepth As Single, APIRod As Short, APIGrade As Short, sRodType As String)
			Try
				Dim num As Short
				Dim num2 As Short
				If APIRod >= 1000S Then
					num = APIRod / 100S
					num2 = APIRod Mod 100S
				Else
					num = APIRod / 10S
					num2 = APIRod Mod 10S
				End If
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.NumRods = num - num2 + 1S
				Dim num3 As Short = 1S
				Dim numRods As Short = rst.NumRods
				For num4 As Short = num3 To numRods
					If APIGrade = 20481S Then
						rst.Sections(CInt(num4)).Diameter = CSng(Math.Sqrt(0.391393836051589))
						rst.Sections(CInt(num4)).Elasticity = 16800000F
						rst.Sections(CInt(num4)).RodDensity = 100F
					ElseIf APIGrade = 16393S Then
						rst.Sections(CInt(num4)).Diameter = 0.55F
						rst.Sections(CInt(num4)).Elasticity = 6800000F
						rst.Sections(CInt(num4)).RodDensity = 125F
					Else
						' The following expression was wrapped in a checked-expression
						' The following expression was wrapped in a unchecked-expression
						rst.Sections(CInt(num4)).Diameter = CSng((num - num4 + 1S)) / 8F
						rst.Sections(CInt(num4)).Elasticity = 30500000F
						rst.Sections(CInt(num4)).RodDensity = 491F
					End If
					rst.Sections(CInt(num4)).Grade = APIGrade
					rst.Sections(CInt(num4)).RodType = sRodType.PadRight(20, " "c)
					rst.Sections(CInt(num4)).Area = CSng((Math.Pow(CDbl(rst.Sections(CInt(num4)).Diameter), 2.0) * 3.141592653589793 / 4.0))
					rst.Sections(CInt(num4)).SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
					RODUTIL.LookupRodWeight(rst.Sections(CInt(num4)))
					RODUTIL.LookupTensileStrength(rst.Sections(CInt(num4)))
					If RSWIN_DESC.bRodStarD Then
						If RSWIN_DESC.rst.RodStringType = 3S Then
							If rst.Sections(CInt(num4)).friction_coef <> RSWIN_DESC.rst.RSFricCoef And CDbl(RSWIN_DESC.rst.RSFricCoef) >= 0.2 Then
								rst.Sections(CInt(num4)).friction_coef = RSWIN_DESC.rst.RSFricCoef
							End If
							rst.Sections(CInt(num4)).Guide = CShort(RSWIN_DESC.rst.RSRodGuide)
						ElseIf rst.Sections(CInt(num4)).friction_coef = 0F Then
							rst.Sections(CInt(num4)).friction_coef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
						End If
					End If
				Next
				Dim array As Single()
				RODUTIL.GetAPITable(array, APIRod, rst.PlungerSize)
				Dim num5 As Short = 1S
				Dim num6 As Short = rst.NumRods - 1S
				For num4 As Short = num5 To num6
					rst.Sections(CInt(num4)).length = Conversion.Fix(fPumpDepth * array(CInt(num4)))
				Next
				RODUTIL.RoundSectionLengths(1S, rst.NumRods, fPumpDepth)
			Catch ex As Exception
			End Try
		End Sub

		Public Function FullRodGrade(iRodGrade As Short) As String
			Dim text As String = ""
			Dim result As String
			Try
				Try
					text = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iRodGrade, StdInfoConstants.RodGradeConstants)).Name
				Catch ex As Exception
					text = ""
				End Try
				If Operators.CompareString(text, "", False) = 0 Then
					If iRodGrade = 4097S Then
						text = "K (API)"
					ElseIf iRodGrade = 8194S Then
						text = "K (API, SB)"
					ElseIf iRodGrade = 4098S Then
						text = "C (API)"
					ElseIf iRodGrade = 8193S Then
						text = "C (API, SB)"
					ElseIf iRodGrade = 8198S Then
						text = "K (API, no neck)"
					ElseIf iRodGrade = 8197S Then
						text = "C (API, no neck)"
					ElseIf iRodGrade = 4099S Then
						text = "D (API)"
					ElseIf iRodGrade = 4101S Then
						text = "Norris 97"
					ElseIf iRodGrade = 4116S Then
						text = "Norris 96"
					ElseIf iRodGrade = 4102S Then
						text = "LTV HS"
					ElseIf iRodGrade = 4117S Then
						text = "Ten UHS-NR"
					ElseIf iRodGrade = 4118S Then
						text = "Ten MMS-NR"
					ElseIf iRodGrade = 4119S Then
						text = "Ten PLUS"
					ElseIf iRodGrade = 4138S Then
						text = "Ten D-PC"
					ElseIf iRodGrade = 4139S Then
						text = "Ten D Alloy"
					ElseIf iRodGrade = 4140S Then
						text = "Ten KD"
					ElseIf iRodGrade = 4115S Then
						text = "UPCO HS"
					ElseIf iRodGrade = 4141S Then
						text = "UPCO HX"
					ElseIf iRodGrade = 4104S Then
						text = "WFT T66/XD"
					ElseIf iRodGrade = 4105S Then
						text = "WFT S88"
					ElseIf iRodGrade = 4107S Then
						text = "WFT S87"
					ElseIf iRodGrade = 4108S Then
						text = "WFT S67"
					ElseIf iRodGrade = 4109S Then
						text = "WFT S60"
					ElseIf iRodGrade = 4100S Then
						text = "WFT EL"
					ElseIf iRodGrade = 4106S Then
						text = "Highland XD"
					ElseIf iRodGrade = 8195S Then
						text = "Flexbar C"
					ElseIf iRodGrade = 8199S Then
						text = "Flexbar C (nn)"
					ElseIf iRodGrade = 8196S Then
						text = "Flexbar K"
					ElseIf iRodGrade = 8200S Then
						text = "Flexbar K (nn)"
					ElseIf iRodGrade = 13057S Then
						text = "Corod-H"
					ElseIf iRodGrade = 12801S Then
						text = "Corod-R D"
					ElseIf iRodGrade = 12802S Then
						text = "Corod-R HS41"
					ElseIf iRodGrade = 12803S Then
						text = "Corod-R SE"
					ElseIf iRodGrade = 12545S Then
						text = "Corod-semi C"
					ElseIf iRodGrade = 12546S Then
						text = "Corod-semi D"
					ElseIf iRodGrade = 12547S Then
						text = "Corod-semi HS41"
					ElseIf iRodGrade = 12548S Then
						text = "Corod-semi SE"
					ElseIf iRodGrade = 12549S Then
						text = "Corod-semi DE"
					ElseIf iRodGrade = 12550S Then
						text = "Corod-semi SE"
					ElseIf iRodGrade = 12805S Then
						text = "Corod-R DE"
					ElseIf iRodGrade = 12806S Then
						text = "Corod-R SE"
					ElseIf iRodGrade = 12807S Then
						text = "Corod-R DW"
					ElseIf iRodGrade = 12808S Then
						text = "Corod-R SW"
					ElseIf iRodGrade = 24577S Then
						text = RSWIN_DESC.sPROROD620
					ElseIf iRodGrade = 24578S Then
						text = RSWIN_DESC.sPROROD790
					ElseIf iRodGrade = 24579S Then
						text = RSWIN_DESC.sPROROD780
					ElseIf iRodGrade = 24580S Then
						text = RSWIN_DESC.sPROROD750
					ElseIf iRodGrade = 24581S Then
						text = RSWIN_DESC.sPROROD960
					ElseIf iRodGrade = 24582S Then
						text = RSWIN_DESC.sPROROD970
					ElseIf iRodGrade = 8301S Then
						text = "NRS PR Steel"
					ElseIf iRodGrade = 8302S Then
						text = "NRS PR Alloy"
					ElseIf iRodGrade = 8303S Then
						text = "NRS PR Norloy"
					ElseIf iRodGrade = 8304S Then
						text = "NRS PR Piston "
					ElseIf iRodGrade = 16385S OrElse iRodGrade = 16389S OrElse iRodGrade = 16390S Then
						text = "Fiberflex"
					ElseIf iRodGrade = 16386S Then
						text = "Petrorod"
					ElseIf iRodGrade = 16387S Then
						text = "Norris FG"
					ElseIf iRodGrade = 16388S Then
						text = "LTV Durarod"
					ElseIf iRodGrade = 16391S Then
						text = "Fiberod"
					ElseIf iRodGrade = 16393S Then
						text = "Fiberod CCR"
					ElseIf iRodGrade = 16394S Then
						text = "FlexRod"
					ElseIf iRodGrade = 16395S Then
						text = "Superod"
					ElseIf iRodGrade = 20481S Then
						text = "Ribbon Rod"
					ElseIf iRodGrade = 4110S Then
						text = "UPCO C"
					ElseIf iRodGrade = 4111S Then
						text = "UPCO CD"
					ElseIf iRodGrade = 4112S Then
						text = "UPCO AD"
					ElseIf iRodGrade = 4113S Then
						text = "UPCO KD"
					ElseIf iRodGrade = 4114S Then
						text = "UPCO K"
					ElseIf iRodGrade = 4115S Then
						text = "UPCO HS"
					ElseIf CUSTOMRG.IsOtherFG(CInt(iRodGrade)) Then
						Dim num As Single = 0F
						text = RODUTIL.GetOtherFG(CInt(iRodGrade), num)
					ElseIf CUSTOMRG.IsOtherSinkerBar(CInt(iRodGrade)) Then
						Dim num As Single = 0F
						text = RODUTIL.GetOtherSinkerbar(CInt(iRodGrade), num)
					ElseIf CUSTOMRG.IsOtherSteel(CInt(iRodGrade)) Then
						Dim num As Single = 0F
						text = RODUTIL.GetOtherSteel(CInt(iRodGrade), num)
					End If
					result = text
				Else
					result = text
				End If
			Catch ex2 As Exception
				result = text
			End Try
			Return result
		End Function

		Public Function RodGrade(iRodGrade As Short) As String
			Dim text As String = ""
			Dim result As String
			Try
				Try
					text = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iRodGrade, StdInfoConstants.RodGradeConstants)).AbbrName
				Catch ex As Exception
					text = ""
				End Try
				If Operators.CompareString(text, "", False) = 0 Then
					If iRodGrade = 4097S Then
						text = "K (API)"
					ElseIf iRodGrade = 8194S Then
						text = "K (API, SB)"
					ElseIf iRodGrade = 4098S Then
						text = "C (API)"
					ElseIf iRodGrade = 8193S Then
						text = "C (API, SB)"
					ElseIf iRodGrade = 8198S Then
						text = "K (API, no neck)"
					ElseIf iRodGrade = 8197S Then
						text = "C (API, no neck)"
					ElseIf iRodGrade = 4099S Then
						text = "D (API)"
					ElseIf iRodGrade = 4101S Then
						text = "Norris 97"
					ElseIf iRodGrade = 4116S Then
						text = "Norris 96"
					ElseIf iRodGrade = 4102S Then
						text = "LTV HS"
					ElseIf iRodGrade = 4117S Then
						text = "Ten UHS-NR"
					ElseIf iRodGrade = 4118S Then
						text = "Ten MMS-NR"
					ElseIf iRodGrade = 4119S Then
						text = "Ten PLUS"
					ElseIf iRodGrade = 4138S Then
						text = "Ten D-PC"
					ElseIf iRodGrade = 4139S Then
						text = "Ten D Alloy"
					ElseIf iRodGrade = 4140S Then
						text = "Ten KD"
					ElseIf iRodGrade = 4115S Then
						text = "UPCO HS"
					ElseIf iRodGrade = 4141S Then
						text = "UPCO HX"
					ElseIf iRodGrade = 4104S Then
						text = "WFT T66/XD"
					ElseIf iRodGrade = 4105S Then
						text = "WFT S88"
					ElseIf iRodGrade = 4107S Then
						text = "WFT S87"
					ElseIf iRodGrade = 4108S Then
						text = "WFT S67"
					ElseIf iRodGrade = 4109S Then
						text = "WFT S60"
					ElseIf iRodGrade = 4100S Then
						text = "WFT EL"
					ElseIf iRodGrade = 4106S Then
						text = "Highland XD"
					ElseIf iRodGrade = 8195S Then
						text = "Flexbar C"
					ElseIf iRodGrade = 8199S Then
						text = "Flexbar C (nn)"
					ElseIf iRodGrade = 8196S Then
						text = "Flexbar K"
					ElseIf iRodGrade = 8200S Then
						text = "Flexbar K (nn)"
					ElseIf iRodGrade = 13057S Then
						text = "Corod-H"
					ElseIf iRodGrade = 12801S Then
						text = "Corod-R D"
					ElseIf iRodGrade = 12802S Then
						text = "Corod-R HS41"
					ElseIf iRodGrade = 12803S Then
						text = "Corod-R SE"
					ElseIf iRodGrade = 12545S Then
						text = "Corod-semi C"
					ElseIf iRodGrade = 12546S Then
						text = "Corod-semi D"
					ElseIf iRodGrade = 12547S Then
						text = "Corod-semi HS41"
					ElseIf iRodGrade = 12548S Then
						text = "Corod-semi SE"
					ElseIf iRodGrade = 12549S Then
						text = "Corod-semi DE"
					ElseIf iRodGrade = 12550S Then
						text = "Corod-semi SE"
					ElseIf iRodGrade = 12805S Then
						text = "Corod-R DE"
					ElseIf iRodGrade = 12806S Then
						text = "Corod-R SE"
					ElseIf iRodGrade = 12807S Then
						text = "Corod-R DW"
					ElseIf iRodGrade = 12808S Then
						text = "Corod-R SW"
					ElseIf iRodGrade = 24577S Then
						text = RSWIN_DESC.sPROROD620
					ElseIf iRodGrade = 24578S Then
						text = RSWIN_DESC.sPROROD790
					ElseIf iRodGrade = 24579S Then
						text = RSWIN_DESC.sPROROD780
					ElseIf iRodGrade = 24580S Then
						text = RSWIN_DESC.sPROROD750
					ElseIf iRodGrade = 24581S Then
						text = RSWIN_DESC.sPROROD960
					ElseIf iRodGrade = 24582S Then
						text = RSWIN_DESC.sPROROD970
					ElseIf iRodGrade = 8301S Then
						text = "NRS PR Steel"
					ElseIf iRodGrade = 8302S Then
						text = "NRS PR Alloy"
					ElseIf iRodGrade = 8303S Then
						text = "NRS PR Norloy"
					ElseIf iRodGrade = 8304S Then
						text = "NRS PR Piston "
					ElseIf iRodGrade = 16385S OrElse iRodGrade = 16389S OrElse iRodGrade = 16390S Then
						text = "Fiberflex"
					ElseIf iRodGrade = 16386S Then
						text = "Petrorod"
					ElseIf iRodGrade = 16387S Then
						text = "Norris FG"
					ElseIf iRodGrade = 16388S Then
						text = "LTV Durarod"
					ElseIf iRodGrade = 16391S Then
						text = "Fiberod"
					ElseIf iRodGrade = 16393S Then
						text = "Fiberod CCR"
					ElseIf iRodGrade = 16394S Then
						text = "FlexRod"
					ElseIf iRodGrade = 16395S Then
						text = "Superod"
					ElseIf iRodGrade = 20481S Then
						text = "Ribbon Rod"
					ElseIf iRodGrade = 4110S Then
						text = "UPCO C"
					ElseIf iRodGrade = 4111S Then
						text = "UPCO CD"
					ElseIf iRodGrade = 4112S Then
						text = "UPCO AD"
					ElseIf iRodGrade = 4113S Then
						text = "UPCO KD"
					ElseIf iRodGrade = 4114S Then
						text = "UPCO K"
					ElseIf iRodGrade = 4115S Then
						text = "UPCO HS"
					ElseIf CUSTOMRG.IsOtherFG(CInt(iRodGrade)) Then
						Dim num As Single = 0F
						text = RODUTIL.GetOtherFG(CInt(iRodGrade), num)
					ElseIf CUSTOMRG.IsOtherSinkerBar(CInt(iRodGrade)) Then
						Dim num As Single = 0F
						text = RODUTIL.GetOtherSinkerbar(CInt(iRodGrade), num)
					ElseIf CUSTOMRG.IsOtherSteel(CInt(iRodGrade)) Then
						Dim num As Single = 0F
						text = RODUTIL.GetOtherSteel(CInt(iRodGrade), num)
					End If
					result = text
				Else
					result = text
				End If
			Catch ex2 As Exception
				result = text
			End Try
			Return result
		End Function

		Public Sub RoundSectionLengths(iTopRod As Short, iBotRod As Short, fRodStringLength As Single)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num As Single = 0F
				Dim num2 As Short = iBotRod - 1S
				For num3 As Short = iTopRod To num2
					num += rst.Sections(CInt(num3)).length
				Next
				If fRodStringLength - num >= 0F Then
					rst.Sections(CInt(iBotRod)).length = fRodStringLength - num
				End If
				If iBotRod > iTopRod Then
					num = 0F
					Dim num4 As Short = iTopRod + 1S
					For num3 As Short = iBotRod To num4 Step -1S
						RODUTIL.CheckSuckerRodLength(rst.Sections(CInt(num3)), False)
						rst.Sections(CInt(num3)).length = CSng((Conversion.Int(CDbl((rst.Sections(CInt(num3)).length / rst.Sections(CInt(num3)).SuckerRodLength)) + 0.5) * CDbl(rst.Sections(CInt(num3)).SuckerRodLength)))
						num += rst.Sections(CInt(num3)).length
					Next
					If fRodStringLength - num >= 0F Then
						rst.Sections(CInt(iTopRod)).length = fRodStringLength - num
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function StdMotorSize(MotorHP As Single) As Single
			Dim result As Single
			Try
				If Not RODUTIL.$STATIC$StdMotorSize$01CC$bInitialized <> 0S Then
					Dim array As String() = New String(0) {}
					Util.LoadMenu("MOTOR-SIZES-NEMA-D", RODUTIL.$STATIC$StdMotorSize$01CC$nSizes, array)
					RODUTIL.$STATIC$StdMotorSize$01CC$afMotorSizes = New Single(CInt((RODUTIL.$STATIC$StdMotorSize$01CC$nSizes + 1S)) - 1) {}
					Dim num As Short = 1S
					Dim num2 As Short = RODUTIL.$STATIC$StdMotorSize$01CC$nSizes
					For num3 As Short = num To num2
						RODUTIL.$STATIC$StdMotorSize$01CC$afMotorSizes(CInt(num3)) = CSng(Conversion.Val(array(CInt(num3))))
					Next
					RODUTIL.$STATIC$StdMotorSize$01CC$bInitialized = -1S
				End If
				result = MotorHP + 5F
				For num3 As Short = RODUTIL.$STATIC$StdMotorSize$01CC$nSizes To 1S Step -1S
					If MotorHP <= RODUTIL.$STATIC$StdMotorSize$01CC$afMotorSizes(CInt(num3)) Then
						result = RODUTIL.$STATIC$StdMotorSize$01CC$afMotorSizes(CInt(num3))
						Exit For
					End If
				Next
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function StressMethodName(iStressMethod As Short) As String
			Dim result As String
			Try
				Select Case iStressMethod
					Case 0S
						result = "API Modified Goodman Diagram"
					Case 1S
						result = "Modified Goodman Diagram, T/2.8"
					Case 2S
						result = "Modified Goodman, with T/3"
					Case 3S
						result = "Weatherford EL"
					Case 4S
						result = "MGS (Modified Goodman Stress)"
					Case 8S
						result = "Ribbon Rod / Amoco"
					Case 9S
						result = "Fiberod"
					Case 10S
						result = "Tenaris"
					Case 11S
						result = "Fiberod CCR"
					Case 12S
						result = "Tenaris PC"
					Case 13S
						result = "FlexRod"
					Case 14S
						result = "Superod"
					Case 15S
						result = "Edge FiberCo"
					Case 16S
						result = "Tenaris PC"
				End Select
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function ConvertListIndexToRodGrade(ByRef RGList As ComboBox, iSelectedIndex As Integer) As Integer
			Dim result As Integer
			Try
				result = Conversions.ToInteger(NewLateBinding.LateGet(RGList.Items(iSelectedIndex), Nothing, "RodGradeID", New Object(-1) {}, Nothing, Nothing, Nothing))
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub ConvertRodGrade_Old(ByRef tSection As RSWIN_DESC.RodSection)
			Dim num As Integer = -1
			Dim num2 As Single = tSection.Diameter
			Dim suckerRodLength As Single = tSection.SuckerRodLength
			Dim num3 As Integer = CInt(tSection.Grade)
			Dim num4 As Integer = num3
			If num4 = 10 Then
				num3 = 8195
			ElseIf num4 = 11 Then
				num3 = 8196
			ElseIf num4 = 12 Then
				num3 = 20481
			ElseIf num4 = 100 Then
				num3 = 12545
			ElseIf num4 = 101 Then
				num3 = 12546
			ElseIf num4 = 102 Then
				num3 = 12547
			ElseIf num4 = 106 Then
				num3 = 12548
			ElseIf num4 = 103 Then
				num3 = 12801
			ElseIf num4 = 104 Then
				num3 = 12802
			ElseIf num4 = 107 Then
				num3 = 12803
			ElseIf num4 = 105 OrElse num4 = 13057 Then
				num3 = 12546
				Dim num5 As Double = CDbl((num2 * num2)) * Math.Atan(1.0)
				If num5 < 0.7 Then
					num2 = 0.9375F
				Else
					num2 = 1F
				End If
			ElseIf num4 = 0 Then
				num3 = 16384
			ElseIf num4 = -1 OrElse num4 = 16390 OrElse num4 = 16389 Then
				num3 = 16385
			ElseIf num4 = -1 OrElse num4 = 16390 OrElse num4 = 16389 Then
				num3 = 16385
				If CDbl(num2) < 1.18 Then
					num2 = 1.24F
				End If
			ElseIf num4 <> -2 Then
				If num4 = -2 Then
					num3 = 16386
				ElseIf num4 = -3 Then
					num3 = 16387
				ElseIf num4 = -4 Then
					num3 = 16388
				ElseIf num4 = 1 Then
					If CDbl(num2) < 1.25 Then
						num3 = 4097
					Else
						num3 = 8194
					End If
				ElseIf num4 = 2 Then
					If CDbl(num2) < 1.25 Then
						num3 = 4098
					Else
						num3 = 8193
					End If
				ElseIf num4 = 3 Then
					num3 = 4099
				ElseIf num4 = 4 Then
					num3 = 4100
				ElseIf num4 = 5 Then
					num3 = 4101
				ElseIf num4 = 6 Then
					num3 = 4102
				ElseIf num4 = 7 OrElse num4 = 4103 Then
					num3 = 4115
				ElseIf num4 = 8 Then
					num3 = 4104
				ElseIf num4 = 9 Then
					num3 = 4105
				ElseIf num4 = 16390 OrElse num4 = 16389 OrElse num4 = 16385 Then
					num3 = 16385
					If 1.17 < CDbl(num2) And CDbl(num2) < 1.18 Then
						num2 = 1.24F
					End If
				Else
					num = 0
				End If
			End If
			If num <> 0 Then
				tSection.Grade = CShort(num3)
				tSection.Diameter = num2
				tSection.Area = CSng((CDbl((num2 * num2)) * Math.Atan(1.0)))
				RODUTIL.LookupElasticity(tSection)
				RODUTIL.LookupRodWeight(tSection)
				RODUTIL.LookupTensileStrength(tSection)
				tSection.StressMethod = CShort(RODUTIL.LookupStressMethod(tSection))
				If num3 = 20481 Then
					tSection.RodDensity = 100F
				ElseIf num3 = 16393 Then
					tSection.RodDensity = 125F
				ElseIf RODUTIL.IsFG(CShort(num3)) Then
					tSection.RodDensity = 130F
				Else
					tSection.RodDensity = 491F
				End If
				If Not CUSTOMRG.IsOtherSteel(num3) Then
					tSection.RodType = RODUTIL.RodGrade(num3)
				End If
			End If
		End Sub

		Public Function FreeTubing(UFluidLoad As Single, TubingMovement As Single) As Single
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If UFluidLoad < 0F Then
				Dim num As Single
				If(If((-If(((rst.giFluidLevelSource <> 0S) > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.gSysDiag.bFluidLevelCorrected) <> 0S Then
					num = rst.FluidLevel
				Else
					num = RSWIN_DESC.gSysDiag.FeetFromSurface
				End If
				UFluidLoad = CSng(((0.433 * CDbl(rst.FluidSPGR) * CDbl(num) + CDbl(rst.TubingPressure) - CDbl(rst.CasingPressure)) * CDbl(rst.Apump)))
			End If
			Return CSng(((Math.Pow(CDbl(rst.TubingOD), 2.0) - Math.Pow(CDbl(rst.TubingID), 2.0)) * 30500000.0 * CDbl(rst.TubingMovement) / (15.28 * CDbl(rst.UFluidLoad))))
		End Function

		Public Sub GetPinSize(iGrade As Single, Diameter As Single, ByRef PinSize As Single)
			' The following expression was wrapped in a checked-expression
			If RODUTIL.IsFG(CShort(Math.Round(CDbl(iGrade)))) Then
				If Diameter <= 0.75F Then
					PinSize = 0.625F
				ElseIf Diameter <= 0.875F Then
					PinSize = 0.75F
				ElseIf Diameter <= 1F Then
					PinSize = 0.875F
				ElseIf Diameter <= 1.25F Then
					If iGrade = 16387F And Diameter = 1.125F Then
						PinSize = 0.875F
					Else
						PinSize = 1F
					End If
				Else
					PinSize = 1.125F
				End If
			ElseIf Diameter >= 2F Then
				PinSize = 1F
			ElseIf Diameter >= 1.625F Then
				PinSize = 0.875F
			ElseIf Diameter >= 1.375F Then
				PinSize = 0.75F
			ElseIf Diameter >= 1.25F Then
				If iGrade = 4116F Or iGrade = 4101F Then
					PinSize = 1.125F
				Else
					PinSize = 0.625F
				End If
			Else
				PinSize = Diameter
			End If
		End Sub

		Public Function IsAPI(iGrade As Integer, sRodType As String) As Boolean
			Dim rodSection As RSWIN_DESC.RodSection
			rodSection.Initialize()
			rodSection.Grade = CShort(iGrade)
			rodSection.RodType = sRodType
			Return RODUTIL.LookupStressMethod(rodSection) = 0
		End Function

		Public Function IsProRod(iRodGrade As Integer) As Integer
			Return If((-If(((RODUTIL.RodType(iRodGrade) = 6) > False), 1, 0)), 1, 0)
		End Function

		Public Function IsCorod(iRodGrade As Integer) As Integer
			Return If((-If(((RODUTIL.RodType(iRodGrade) = 3) > False), 1, 0)), 1, 0)
		End Function

		Public Function IsCorodH(iRodGrade As Integer) As Integer
			Dim result As Integer = 0
			If RODUTIL.IsCorod(iRodGrade) <> 0 Then
				Dim num As Integer = iRodGrade And 3840
				If num = 768 Then
					result = -1
				End If
			End If
			Return result
		End Function

		Public Function IsCorodR(iRodGrade As Integer) As Integer
			Dim result As Integer = 0
			If RODUTIL.IsCorod(iRodGrade) <> 0 Then
				Dim num As Integer = iRodGrade And 3840
				If num = 512 Then
					result = -1
				End If
			End If
			Return result
		End Function

		Public Function IsCorodSE(iRodGrade As Integer) As Integer
			Dim result As Integer = 0
			If RODUTIL.IsCorod(iRodGrade) <> 0 Then
				Dim num As Integer = iRodGrade And 3840
				If num = 256 Then
					result = -1
				End If
			End If
			Return result
		End Function

		Public Function IsSinkerBar(iSect As Integer) As Integer
			' The following expression was wrapped in a checked-statement
			Dim result As Integer
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If RODUTIL.RodType(rst.Sections(iSect).Grade) = 2 Then
					result = -1
				Else
					result = 0
					If RODUTIL.IsSteel(CInt(rst.Sections(iSect).Grade)) <> 0 Then
						If CDbl(rst.Sections(iSect).Diameter) > 1.25 And iSect <> 1 Then
							result = -1
						ElseIf CDbl(rst.Sections(iSect).Diameter) = 1.25 And iSect <> 1 Then
							Dim num As Integer = 1
							Dim numRods As Integer = CInt(rst.NumRods)
							For i As Integer = num To numRods
								If CDbl(rst.Sections(i).Diameter) <> 1.25 Then
									result = -1
									Exit For
								End If
							Next
						End If
					End If
				End If
			Catch ex As Exception
				result = 0
			End Try
			Return result
		End Function

		Public Function IsSinkerBar1(iRodGrade As Integer, sRodType As String) As Integer
			' The following expression was wrapped in a checked-statement
			Dim result As Integer
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				result = 0
				If RODUTIL.RodType(iRodGrade) = 2 Then
					result = -1
				ElseIf CUSTOMRG.IsOtherSinkerBar(iRodGrade) Then
					Dim num As Integer = 1
					Dim num2 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
					For i As Integer = num To num2
						' The following expression was wrapped in a unchecked-expression
						If(RSWIN_DESC.CustomRodGradeList(i).Steel And RSWIN_DESC.CustomRodGradeList(i).SinkerBar And If(-If(((Operators.CompareString(Strings.Trim(sRodType), Strings.Trim(RSWIN_DESC.CustomRodGradeList(i).RodType), False) = 0) > False), 1S, 0S), 1S, 0S)) <> 0S Then
							result = -1
							Exit For
						End If
					Next
				End If
			Catch ex As Exception
				result = 0
			End Try
			Return result
		End Function

		Public Function IsSteel(iRodGrade As Integer) As Integer
			Dim result As Integer = 0
			Select Case RODUTIL.RodType(iRodGrade)
				Case 1, 2, 3
					result = -1
			End Select
			Return result
		End Function

		Public Sub LookupElasticity(ByRef Section As RSWIN_DESC.RodSection)
			Dim flag As Boolean = False
			Try
				Dim num As Single = Conversions.ToSingle(RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(Section.Grade, StdInfoConstants.RodGradeConstants)).Elasticity)
				If Versioned.IsNumeric(num) AndAlso num <> 0F Then
					Section.Elasticity = num
					flag = True
				End If
			Catch ex As Exception
				flag = False
			End Try
			If Not flag Then
				Dim grade As Short = Section.Grade
				If grade = 16385S OrElse grade = 16389S OrElse grade = 16390S OrElse grade = 16391S Then
					Section.Elasticity = 7200000F
					flag = True
				ElseIf grade = 16393S Then
					Section.Elasticity = 6800000F
					flag = True
				ElseIf grade = 16387S Then
					Section.Elasticity = 7100000F
					flag = True
				ElseIf grade = 16386S Then
					Section.Elasticity = 8000000F
					flag = True
				ElseIf grade = 16388S Then
					Section.Elasticity = 6300000F
					flag = True
				ElseIf grade = 20481S Then
					Section.Elasticity = 16800000F
					flag = True
				Else
					Try
						If RSWIN_DESC.CustomRodGradeList IsNot Nothing Then
							Dim num2 As Integer = 1
							Dim num3 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
							For i As Integer = num2 To num3
								If(Not RSWIN_DESC.CustomRodGradeList(i).Steel And If((-If(((Operators.CompareString(RODUTIL.RodGrade(Section.Grade).Trim(), RSWIN_DESC.CustomRodGradeList(i).RodType.Trim(), False) = 0) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
									Section.Elasticity = RSWIN_DESC.CustomRodGradeList(i).Elasticity
									flag = True
									Exit For
								End If
								If(RSWIN_DESC.CustomRodGradeList(i).Steel And If((-If(((Operators.CompareString(RODUTIL.RodGrade(Section.Grade).Trim(), RSWIN_DESC.CustomRodGradeList(i).RodType.Trim(), False) = 0) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
									If RSWIN_DESC.CustomRodGradeList(i).Elasticity = 0F Then
										Section.Elasticity = 30500000F
									Else
										Section.Elasticity = RSWIN_DESC.CustomRodGradeList(i).Elasticity
									End If
									flag = True
									Exit For
								End If
							Next
						End If
					Catch ex2 As Exception
					End Try
				End If
				Return
			End If
		End Sub

		Public Function LookupElasticity(iGrade As Short) As Single
			Dim flag As Boolean = False
			Dim result As Single
			Try
				Dim num As Single = Conversions.ToSingle(RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iGrade, StdInfoConstants.RodGradeConstants)).Elasticity)
				If Versioned.IsNumeric(num) AndAlso num <> 0F Then
					result = num
					flag = True
				End If
			Catch ex As Exception
				flag = False
			End Try
			If Not flag Then
				If iGrade = 16385S OrElse iGrade = 16389S OrElse iGrade = 16390S OrElse iGrade = 16391S Then
					result = 7200000F
					flag = True
				ElseIf iGrade = 16393S Then
					result = 6800000F
					flag = True
				ElseIf iGrade = 16387S Then
					result = 7100000F
					flag = True
				ElseIf iGrade = 16386S Then
					result = 8000000F
					flag = True
				ElseIf iGrade = 16388S Then
					result = 6300000F
					flag = True
				ElseIf iGrade = 20481S Then
					result = 16800000F
					flag = True
				Else
					Try
						If RSWIN_DESC.CustomRodGradeList IsNot Nothing Then
							Dim num2 As Integer = 1
							Dim num3 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
							For i As Integer = num2 To num3
								If(Not RSWIN_DESC.CustomRodGradeList(i).Steel And If((-If(((Operators.CompareString(RODUTIL.RodGrade(iGrade).Trim(), RSWIN_DESC.CustomRodGradeList(i).RodType.Trim(), False) = 0) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
									result = RSWIN_DESC.CustomRodGradeList(i).Elasticity
									flag = True
									Exit For
								End If
								If(RSWIN_DESC.CustomRodGradeList(i).Steel And If((-If(((Operators.CompareString(RODUTIL.RodGrade(iGrade).Trim(), RSWIN_DESC.CustomRodGradeList(i).RodType.Trim(), False) = 0) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
									If RSWIN_DESC.CustomRodGradeList(i).Elasticity = 0F Then
										result = 30500000F
									Else
										result = RSWIN_DESC.CustomRodGradeList(i).Elasticity
									End If
									flag = True
									Exit For
								End If
							Next
						End If
					Catch ex2 As Exception
					End Try
				End If
			End If
			Return result
		End Function

		Public Sub LookupRodWeight(ByRef Section As RSWIN_DESC.RodSection)
			Dim flag As Boolean = False
			flag = False
			Dim dictionaryEntry As DictionaryEntry
			Dim rodWeight As Single
			Try
				Try
					Dim rodSizeList As teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(Section.Grade, StdInfoConstants.RodGradeConstants)).RodSizeList
					Try
						For Each obj As Object In rodSizeList
							Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
							If teRodSize.Diameter = Section.Diameter Then
								rodWeight = teRodSize.RodWeight
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					If Versioned.IsNumeric(rodWeight) AndAlso rodWeight <> 0F Then
						Section.RodWeight = rodWeight
						flag = True
						If Section.Area = 0F Then
							Section.Area = CSng((Math.Pow(CDbl(Section.Diameter), 2.0) * 3.141592653589793 / 4.0))
						End If
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
			If Not flag Then
				Dim grade As Short = Section.Grade
				If grade = 12545S OrElse grade = 12546S OrElse grade = 12547S OrElse grade = 12548S OrElse grade = 12804S OrElse grade = 12801S OrElse grade = 12802S OrElse grade = 12803S Then
					Dim diameter As Single = Section.Diameter
					If diameter = 0.75F Then
						Section.RodWeight = 1.5F
					ElseIf diameter = 0.8125F Then
						Section.RodWeight = 1.76F
					ElseIf diameter = 0.875F Then
						Section.RodWeight = 2.04F
					ElseIf diameter = 0.9375F Then
						Section.RodWeight = 2.35F
					ElseIf diameter = 1F Then
						Section.RodWeight = 2.67F
					ElseIf diameter = 1.0625F Then
						Section.RodWeight = 3.01F
					ElseIf diameter = 1.125F Then
						Section.RodWeight = 3.375F
					End If
				ElseIf grade = 20481S Then
					Section.RodWeight = 0.212F
				ElseIf grade = 13057S Then
					Dim area As Single = Section.Area
					If area < 0.7F Then
						Section.RodWeight = 2.316F
					Else
						Section.RodWeight = 2.571F
					End If
				ElseIf grade = 16387S Then
					Dim diameter2 As Single = Section.Diameter
					If diameter2 = 0.875F Then
						Section.RodWeight = 0.72F
					ElseIf diameter2 = 1F Then
						Section.RodWeight = 0.94F
					ElseIf diameter2 = 1.125F Then
						Section.RodWeight = 1.09F
					ElseIf diameter2 = 1.25F Then
						Section.RodWeight = 1.47F
					End If
				ElseIf grade = 16388S Then
					Dim diameter3 As Single = Section.Diameter
					If diameter3 = 0.75F Then
						Section.RodWeight = 0.512F
					ElseIf diameter3 = 0.875F Then
						Section.RodWeight = 0.677F
					ElseIf diameter3 = 1F Then
						Section.RodWeight = 0.843F
					ElseIf diameter3 = 1.25F Then
						Section.RodWeight = 1.363F
					End If
				ElseIf grade = 16386S Then
					Dim diameter4 As Single = Section.Diameter
					If diameter4 = 0.75F Then
						Section.RodWeight = 0.46F
					ElseIf diameter4 = 0.87F Then
						Section.RodWeight = 0.65F
					ElseIf diameter4 = 0.976F Then
						Section.RodWeight = 0.87F
					ElseIf diameter4 = 1.25F Then
						Section.RodWeight = 1.35F
					End If
				ElseIf grade = 16385S OrElse grade = 16389S OrElse grade = 16390S Then
					Dim diameter5 As Single = Section.Diameter
					If diameter5 = 0.74F Then
						Section.RodWeight = 0.4831F
					ElseIf diameter5 = 0.865F Then
						Section.RodWeight = 0.6108F
					ElseIf diameter5 = 0.99F Then
						Section.RodWeight = 0.8188F
					ElseIf diameter5 = 1.175F Then
						Section.RodWeight = 1.1846F
					ElseIf diameter5 = 1.24F Then
						Section.RodWeight = 1.2879F
					ElseIf diameter5 = 1.465F Then
						Section.RodWeight = 1.905F
					End If
				ElseIf grade = 16391S Then
					Dim diameter6 As Single = Section.Diameter
					If diameter6 <= 0.75F Then
						Section.RodWeight = 0.48F
					ElseIf diameter6 <= 0.875F Then
						Section.RodWeight = 0.61F
					ElseIf diameter6 <= 1F Then
						Section.RodWeight = 0.82F
					ElseIf diameter6 <= 1.25F Then
						Section.RodWeight = 1.29F
					End If
				ElseIf grade = 16393S Then
					Dim diameter7 As Single = Section.Diameter
					If diameter7 <= 0.6F Then
						Section.RodWeight = 0.22F
					End If
				Else
					' The following expression was wrapped in a checked-statement
					Try
						If RSWIN_DESC.CustomRodGradeList IsNot Nothing Then
							Dim num As Integer = 1
							Dim num2 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
							For i As Integer = num To num2
								' The following expression was wrapped in a unchecked-expression
								If(Not RSWIN_DESC.CustomRodGradeList(i).Steel And If(-If(((Operators.CompareString(RODUTIL.RodGrade(Section.Grade).Trim(), RSWIN_DESC.CustomRodGradeList(i).RodType.Trim(), False) = 0) > False), 1S, 0S), 1S, 0S)) <> 0S Then
									Section.RodWeight = RSWIN_DESC.CustomRodGradeList(i).RodWeight
									flag = True
									Exit For
								End If
							Next
						End If
					Catch ex3 As Exception
					End Try
					If Not flag Then
						If Section.Area = 0F Then
							Section.Area = CSng((Math.Pow(CDbl(Section.Diameter), 2.0) * 3.141592653589793 / 4.0))
						End If
						If CDbl(Section.Diameter) > 1.25 Then
							Section.RodWeight = CSng((CDbl(Section.Area) * 3.403))
						Else
							Section.RodWeight = CSng((CDbl(Section.Area) * 3.695))
						End If
						Try
							Try
								Dim rodSizeList As teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(Section.Grade, StdInfoConstants.RodGradeConstants)).RodSizeList
								Try
									For Each obj2 As Object In rodSizeList
										Dim teRodSize As teRodSize = CType(If((obj2 IsNot Nothing), CType(obj2, DictionaryEntry), dictionaryEntry).Value, teRodSize)
										If teRodSize.Diameter = Section.Diameter Then
											rodWeight = teRodSize.RodWeight
											Exit For
										End If
									Next
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
								If Versioned.IsNumeric(rodWeight) AndAlso rodWeight <> 0F Then
									Section.RodWeight = rodWeight
									flag = True
									If Section.Area = 0F Then
										Section.Area = CSng((Math.Pow(CDbl(Section.Diameter), 2.0) * 3.141592653589793 / 4.0))
									End If
								End If
							Catch ex4 As Exception
							End Try
						Catch ex5 As Exception
						End Try
					End If
				End If
				Return
			End If
		End Sub

		Public Function LookupRodWeight(iGrade As Short, fDiameter As Single) As Single
			Dim flag As Boolean = False
			Dim result As Single = 0F
			Dim num As Single = 0F
			flag = False
			Dim dictionaryEntry As DictionaryEntry
			Dim rodWeight As Single
			Try
				Try
					Dim rodSizeList As teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iGrade, StdInfoConstants.RodGradeConstants)).RodSizeList
					Try
						For Each obj As Object In rodSizeList
							Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
							If teRodSize.Diameter = fDiameter Then
								rodWeight = teRodSize.RodWeight
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					If Versioned.IsNumeric(rodWeight) AndAlso rodWeight <> 0F Then
						result = rodWeight
						flag = True
						If num = 0F Then
							num = CSng((Math.Pow(CDbl(fDiameter), 2.0) * 3.141592653589793 / 4.0))
						End If
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
			If Not flag Then
				If iGrade = 12545S OrElse iGrade = 12546S OrElse iGrade = 12547S OrElse iGrade = 12548S OrElse iGrade = 12804S OrElse iGrade = 12801S OrElse iGrade = 12802S OrElse iGrade = 12803S Then
					If fDiameter = 0.75F Then
						result = 1.5F
					ElseIf fDiameter = 0.8125F Then
						result = 1.76F
					ElseIf fDiameter = 0.875F Then
						result = 2.04F
					ElseIf fDiameter = 0.9375F Then
						result = 2.35F
					ElseIf fDiameter = 1F Then
						result = 2.67F
					ElseIf fDiameter = 1.0625F Then
						result = 3.01F
					ElseIf fDiameter = 1.125F Then
						result = 3.375F
					End If
				ElseIf iGrade = 20481S Then
					result = 0.212F
				ElseIf iGrade = 13057S Then
					Dim num2 As Single = num
					If num2 < 0.7F Then
						result = 2.316F
					Else
						result = 2.571F
					End If
				ElseIf iGrade = 16387S Then
					If fDiameter = 0.875F Then
						result = 0.72F
					ElseIf fDiameter = 1F Then
						result = 0.94F
					ElseIf fDiameter = 1.125F Then
						result = 1.09F
					ElseIf fDiameter = 1.25F Then
						result = 1.47F
					End If
				ElseIf iGrade = 16388S Then
					If fDiameter = 0.75F Then
						result = 0.512F
					ElseIf fDiameter = 0.875F Then
						result = 0.677F
					ElseIf fDiameter = 1F Then
						result = 0.843F
					ElseIf fDiameter = 1.25F Then
						result = 1.363F
					End If
				ElseIf iGrade = 16386S Then
					If fDiameter = 0.75F Then
						result = 0.46F
					ElseIf fDiameter = 0.87F Then
						result = 0.65F
					ElseIf fDiameter = 0.976F Then
						result = 0.87F
					ElseIf fDiameter = 1.25F Then
						result = 1.35F
					End If
				ElseIf iGrade = 16385S OrElse iGrade = 16389S OrElse iGrade = 16390S Then
					If fDiameter = 0.74F Then
						result = 0.4831F
					ElseIf fDiameter = 0.865F Then
						result = 0.6108F
					ElseIf fDiameter = 0.99F Then
						result = 0.8188F
					ElseIf fDiameter = 1.175F Then
						result = 1.1846F
					ElseIf fDiameter = 1.24F Then
						result = 1.2879F
					ElseIf fDiameter = 1.465F Then
						result = 1.905F
					End If
				ElseIf iGrade = 16391S Then
					If fDiameter <= 0.75F Then
						result = 0.48F
					ElseIf fDiameter <= 0.875F Then
						result = 0.61F
					ElseIf fDiameter <= 1F Then
						result = 0.82F
					ElseIf fDiameter <= 1.25F Then
						result = 1.29F
					End If
				ElseIf iGrade = 16393S Then
					If fDiameter <= 0.6F Then
						result = 0.22F
					End If
				Else
					' The following expression was wrapped in a checked-statement
					Try
						If RSWIN_DESC.CustomRodGradeList IsNot Nothing Then
							Dim num3 As Integer = 1
							Dim num4 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
							For i As Integer = num3 To num4
								' The following expression was wrapped in a unchecked-expression
								If(Not RSWIN_DESC.CustomRodGradeList(i).Steel And If(-If(((Operators.CompareString(RODUTIL.RodGrade(iGrade).Trim(), RSWIN_DESC.CustomRodGradeList(i).RodType.Trim(), False) = 0) > False), 1S, 0S), 1S, 0S)) <> 0S Then
									result = RSWIN_DESC.CustomRodGradeList(i).RodWeight
									flag = True
									Exit For
								End If
							Next
						End If
					Catch ex3 As Exception
					End Try
					If Not flag Then
						If num = 0F Then
							num = CSng((Math.Pow(CDbl(fDiameter), 2.0) * 3.141592653589793 / 4.0))
						End If
						If CDbl(fDiameter) > 1.25 Then
							result = CSng((CDbl(num) * 3.403))
						Else
							result = CSng((CDbl(num) * 3.695))
						End If
						Try
							Try
								Dim rodSizeList As teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iGrade, StdInfoConstants.RodGradeConstants)).RodSizeList
								Try
									For Each obj2 As Object In rodSizeList
										Dim teRodSize As teRodSize = CType(If((obj2 IsNot Nothing), CType(obj2, DictionaryEntry), dictionaryEntry).Value, teRodSize)
										If teRodSize.Diameter = fDiameter Then
											rodWeight = teRodSize.RodWeight
											Exit For
										End If
									Next
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
								If Versioned.IsNumeric(rodWeight) AndAlso rodWeight <> 0F Then
									result = rodWeight
									flag = True
									If num = 0F Then
										num = CSng((Math.Pow(CDbl(fDiameter), 2.0) * 3.141592653589793 / 4.0))
									End If
								End If
							Catch ex4 As Exception
							End Try
						Catch ex5 As Exception
						End Try
					End If
				End If
			End If
			Return result
		End Function

		Public Sub LookupRodDiameterForCorrection(ByRef Section As RSWIN_DESC.RodSection)
			Dim flag As Boolean = True
			If flag = Math.Abs(CDbl(Section.Diameter) - 0.74) < 1E-07 Then
				Section.Diameter = 0.74F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 0.75) < 1E-07 Then
				Section.Diameter = 0.75F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 0.8125) < 1E-07 Then
				Section.Diameter = 0.8125F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 0.865) < 1E-07 Then
				Section.Diameter = 0.865F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 0.87) < 1E-07 Then
				Section.Diameter = 0.87F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 0.875) < 1E-07 Then
				Section.Diameter = 0.875F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 0.9375) < 1E-07 Then
				Section.Diameter = 0.9375F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 0.976) < 1E-07 Then
				Section.Diameter = 0.976F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 0.99) < 1E-07 Then
				Section.Diameter = 0.99F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 1.0) < 1E-07 Then
				Section.Diameter = 1F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 1.0625) < 1E-07 Then
				Section.Diameter = 1.0625F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 1.125) < 1E-07 Then
				Section.Diameter = 1.125F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 1.175) < 1E-07 Then
				Section.Diameter = 1.175F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 1.24) < 1E-07 Then
				Section.Diameter = 1.24F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 1.25) < 1E-07 Then
				Section.Diameter = 1.25F
			ElseIf flag = Math.Abs(CDbl(Section.Diameter) - 1.465) < 1E-07 Then
				Section.Diameter = 1.465F
			End If
			If Section.Grade = 16391S Then
				If CDbl(Section.Diameter) > 0.98 And CDbl(Section.Diameter) < 1.0 Then
					Section.Diameter = 0.98F
				End If
				Return
			End If
		End Sub

		Public Function LookupStressMethod(ByRef Section As RSWIN_DESC.RodSection) As Integer
			Dim flag As Boolean = False
			Dim result As Integer
			Try
				result = 0
				Dim grade As Short = Section.Grade
				If grade = 4100S Then
					result = 3
				ElseIf grade = 12801S OrElse grade = 12546S OrElse grade = 12805S OrElse grade = 12549S OrElse grade = 12807S Then
					result = 0
				ElseIf grade = 12806S OrElse grade = 12550S OrElse grade = 12808S Then
					result = 2
				ElseIf grade = 4116S OrElse grade = 4101S OrElse grade = 4102S OrElse grade = 4104S OrElse grade = 4106S OrElse grade = 4105S OrElse grade = 4115S OrElse grade = 4117S OrElse grade = 4118S OrElse grade = 24581S OrElse grade = 24582S OrElse grade = 4131S Then
					result = 1
				ElseIf grade = 16385S OrElse grade = 16389S OrElse grade = 16390S OrElse grade = 16386S Then
					result = 5
				ElseIf grade = 16387S Then
					result = 6
				ElseIf grade = 16388S Then
					result = 7
				ElseIf grade = 20481S Then
					result = 8
				ElseIf grade = 16391S Then
					result = 9
				ElseIf grade = 16393S Then
					result = 11
				ElseIf grade = 4119S Then
					result = 10
				ElseIf grade = 4138S Then
					result = 12
				ElseIf grade = 4122S Then
					result = 0
				ElseIf grade = 4123S Then
					result = 1
				Else
					If CUSTOMRG.IsOtherFG(CInt(Section.Grade)) Then
						result = 5
						flag = True
					ElseIf RSWIN_DESC.CustomRodGradeList IsNot Nothing Then
						Dim num As Integer = 1
						Dim num2 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
						For i As Integer = num To num2
							' The following expression was wrapped in a unchecked-expression
							If Section.RodType IsNot Nothing AndAlso RSWIN_DESC.CustomRodGradeList(i).Steel And If((-If(((Operators.CompareString(Section.RodType.Trim(), "(Custom Steel)", False) = 0 Or CUSTOMRG.IsOtherSteel(CInt(Section.Grade))) > False), 1S, 0S)), 1S, 0S) And If((-If(((Operators.CompareString(RODUTIL.RodGrade(Section.Grade).Trim(), RSWIN_DESC.CustomRodGradeList(i).RodType.Trim(), False) = 0) > False), 1S, 0S)), 1S, 0S) <> 0S Then
								result = CInt(RSWIN_DESC.CustomRodGradeList(i).StressMethod)
								flag = True
								Exit For
							End If
						Next
					End If
					If Not flag Then
						Try
							Dim num3 As Short = CShort(RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(Section.Grade, StdInfoConstants.RodGradeConstants)).StressMethod)
							If Versioned.IsNumeric(num3) Then
								Section.StressMethod = num3
								result = CInt(num3)
							End If
						Catch ex As Exception
						End Try
					End If
				End If
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Public Sub LookupTensileStrength(ByRef Section As RSWIN_DESC.RodSection)
			Dim flag As Boolean = False
			Try
				Try
					Try
						Dim num As Single = Conversions.ToSingle(RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(Section.Grade, StdInfoConstants.RodGradeConstants)).TensileStrength)
						If Versioned.IsNumeric(num) AndAlso num <> 0F Then
							Section.TensileStrength = num
							flag = True
						End If
					Catch ex As Exception
					End Try
				Catch ex2 As Exception
				End Try
				If Not flag Then
					Dim grade As Short = Section.Grade
					If grade = 8196S OrElse grade = 8200S Then
						Section.TensileStrength = 85000F
						flag = True
					ElseIf grade = 4097S OrElse grade = 8194S OrElse grade = 8198S OrElse grade = 4098S OrElse grade = 8193S OrElse grade = 8197S OrElse grade = 8195S OrElse grade = 8199S OrElse grade = 12804S OrElse grade = 12545S Then
						Section.TensileStrength = 90000F
						flag = True
					ElseIf grade = 4099S OrElse grade = 13057S OrElse grade = 12801S OrElse grade = 12546S Then
						Section.TensileStrength = 115000F
						flag = True
					ElseIf grade = 4109S Then
						Section.TensileStrength = 100000F
						flag = True
					ElseIf grade = 4108S OrElse grade = 24577S OrElse grade = 24579S Then
						Section.TensileStrength = 120000F
						flag = True
					ElseIf grade = 4107S OrElse grade = 24580S Then
						Section.TensileStrength = 125000F
						flag = True
					ElseIf grade = 12802S OrElse grade = 12547S Then
						Section.TensileStrength = 130000F
						flag = True
					ElseIf grade = 4116S Then
						Section.TensileStrength = 135000F
						flag = True
					ElseIf grade = 12807S Then
						Section.TensileStrength = 115000F
						flag = True
					ElseIf grade = 12808S Then
						Section.TensileStrength = 145000F
						flag = True
					ElseIf grade = 12803S OrElse grade = 12548S OrElse grade = 4101S OrElse grade = 4102S OrElse grade = 4115S OrElse grade = 4104S OrElse grade = 4105S OrElse grade = 4106S OrElse grade = 24578S OrElse grade = 24581S OrElse grade = 24582S OrElse grade = 4117S OrElse grade = 4118S OrElse grade = 4131S Then
						Section.TensileStrength = 140000F
						flag = True
					ElseIf grade = 4116S Then
						Section.TensileStrength = 135000F
						flag = True
					ElseIf grade = 4110S OrElse grade = 4114S Then
						Section.TensileStrength = 90000F
						flag = True
					ElseIf grade = 4111S OrElse grade = 4112S OrElse grade = 4113S Then
						Section.TensileStrength = 115000F
						flag = True
					ElseIf grade = 8301S Then
						Section.TensileStrength = 115000F
						flag = True
					ElseIf grade = 8302S Then
						Section.TensileStrength = 125000F
						flag = True
					ElseIf grade = 8303S Then
						Section.TensileStrength = 100000F
						flag = True
					ElseIf grade = 8304S Then
						Section.TensileStrength = 90000F
						flag = True
					End If
					If Not flag Then
						Dim flag2 As Boolean = True
						If flag2 = CUSTOMRG.IsOtherSteel(CInt(Section.Grade)) Then
							If RSWIN_DESC.CustomRodGradeList IsNot Nothing Then
								RODUTIL.GetOtherSteel(CInt(Section.Grade), Section.TensileStrength)
							End If
						ElseIf flag2 = CUSTOMRG.IsOtherSinkerBar(CInt(Section.Grade)) AndAlso RSWIN_DESC.CustomRodGradeList IsNot Nothing Then
							RODUTIL.GetOtherSinkerbar(CInt(Section.Grade), Section.TensileStrength)
						End If
					End If
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Function LookupTensileStrength(Grade As Single) As Single
			Dim num As Single = 0F
			Dim flag As Boolean = False
			Dim result As Single
			Try
				Try
					Try
						Dim num2 As Single = Conversions.ToSingle(RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(Math.Round(CDbl(Grade)), StdInfoConstants.RodGradeConstants)).TensileStrength)
						If Versioned.IsNumeric(num2) AndAlso num2 <> 0F Then
							num = num2
							flag = True
						End If
					Catch ex As Exception
					End Try
				Catch ex2 As Exception
				End Try
				If Not flag Then
					If Grade = 8196F OrElse Grade = 8200F Then
						num = 85000F
						flag = True
					Else
						If Grade <> 4097F Then
							If Grade <> 8194F Then
								If Grade <> 8198F Then
									If Grade <> 4098F Then
										If Grade <> 8193F Then
											If Grade <> 8197F Then
												If Grade <> 8195F Then
													If Grade <> 8199F Then
														If Grade <> 12804F Then
															If Grade <> 12545F Then
																If Grade <> 4099F Then
																	If Grade <> 13057F Then
																		If Grade <> 12801F Then
																			If Grade <> 12546F Then
																				If Grade = 4109F Then
																					num = 100000F
																					flag = True
																					GoTo IL_31D
																				End If
																				If Grade <> 4108F Then
																					If Grade <> 24577F Then
																						If Grade <> 24579F Then
																							If Grade = 4107F OrElse Grade = 24580F Then
																								num = 125000F
																								flag = True
																								GoTo IL_31D
																							End If
																							If Grade = 12802F OrElse Grade = 12547F Then
																								num = 130000F
																								flag = True
																								GoTo IL_31D
																							End If
																							If Grade = 4116F Then
																								num = 135000F
																								flag = True
																								GoTo IL_31D
																							End If
																							If Grade = 12807F Then
																								num = 115000F
																								flag = True
																								GoTo IL_31D
																							End If
																							If Grade = 12808F Then
																								num = 145000F
																								flag = True
																								GoTo IL_31D
																							End If
																							If Grade <> 12803F Then
																								If Grade <> 12548F Then
																									If Grade <> 4101F Then
																										If Grade <> 4102F Then
																											If Grade <> 4115F Then
																												If Grade <> 4104F Then
																													If Grade <> 4105F Then
																														If Grade <> 4106F Then
																															If Grade <> 24578F Then
																																If Grade <> 24581F Then
																																	If Grade <> 24582F Then
																																		If Grade <> 4117F Then
																																			If Grade <> 4118F Then
																																				If Grade <> 4131F Then
																																					If Grade = 4116F Then
																																						num = 135000F
																																						flag = True
																																						GoTo IL_31D
																																					End If
																																					If Grade = 4110F OrElse Grade = 4114F Then
																																						num = 90000F
																																						flag = True
																																						GoTo IL_31D
																																					End If
																																					If Grade <> 4111F Then
																																						If Grade <> 4112F Then
																																							If Grade <> 4113F Then
																																								If Grade = 8301F Then
																																									num = 90000F
																																									flag = True
																																									GoTo IL_31D
																																								End If
																																								If Grade = 8302F Then
																																									num = 95000F
																																									flag = True
																																									GoTo IL_31D
																																								End If
																																								GoTo IL_31D
																																							End If
																																						End If
																																					End If
																																					num = 115000F
																																					flag = True
																																					GoTo IL_31D
																																				End If
																																			End If
																																		End If
																																	End If
																																End If
																															End If
																														End If
																													End If
																												End If
																											End If
																										End If
																									End If
																								End If
																							End If
																							num = 140000F
																							flag = True
																							GoTo IL_31D
																						End If
																					End If
																				End If
																				num = 120000F
																				flag = True
																				GoTo IL_31D
																			End If
																		End If
																	End If
																End If
																num = 115000F
																flag = True
																GoTo IL_31D
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
						num = 90000F
						flag = True
					End If
					IL_31D:
					If Not flag Then
						Dim flag2 As Boolean = True
						If flag2 = CUSTOMRG.IsOtherSteel(CInt(Math.Round(CDbl(Grade)))) Then
							If RSWIN_DESC.CustomRodGradeList IsNot Nothing Then
								RODUTIL.GetOtherSteel(CInt(Math.Round(CDbl(Grade))), num)
							End If
						ElseIf flag2 = CUSTOMRG.IsOtherSinkerBar(CInt(Math.Round(CDbl(Grade)))) AndAlso RSWIN_DESC.CustomRodGradeList IsNot Nothing Then
							RODUTIL.GetOtherSinkerbar(CInt(Math.Round(CDbl(Grade))), num)
						End If
					End If
				End If
				result = num
			Catch ex3 As Exception
				result = 0F
			End Try
			Return result
		End Function

		Public Function RodGrade(iRodGrade As Integer) As String
			Dim text As String = ""
			Try
				text = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iRodGrade, StdInfoConstants.RodGradeConstants)).AbbrName
			Catch ex As Exception
				text = ""
			End Try
			If Operators.CompareString(text, "", False) = 0 Then
				Dim result As String
				If iRodGrade = 4097 Then
					result = "K (API)"
				ElseIf iRodGrade = 8194 Then
					result = "K (API, SB)"
				ElseIf iRodGrade = 8198 Then
					result = "K (API, no neck)"
				ElseIf iRodGrade = 4098 Then
					result = "C (API)"
				ElseIf iRodGrade = 8193 Then
					result = "C (API, SB)"
				ElseIf iRodGrade = 8197 Then
					result = "C (API, no neck)"
				ElseIf iRodGrade = 4099 Then
					result = "D (API)"
				ElseIf iRodGrade = 4100 Then
					result = "WFT EL"
				ElseIf iRodGrade = 4101 Then
					result = "Norris 97"
				ElseIf iRodGrade = 4116 Then
					result = "Norris 96"
				ElseIf iRodGrade = 4102 Then
					result = "LTV HS"
				ElseIf iRodGrade = 4117 Then
					result = "Ten UHS-NR"
				ElseIf iRodGrade = 4118 Then
					result = "Ten MMS-NR"
				ElseIf iRodGrade = 4119 Then
					result = "Ten PLUS"
				ElseIf iRodGrade = 4138 Then
					result = "Ten D-PC"
				ElseIf iRodGrade = 4139 Then
					result = "Ten D Alloy"
				ElseIf iRodGrade = 4140 Then
					result = "Ten KD"
				ElseIf iRodGrade = 4104 Then
					result = "WFT T66/XD"
				ElseIf iRodGrade = 4105 Then
					result = "WFT S88"
				ElseIf iRodGrade = 4107 Then
					result = "WFT S87"
				ElseIf iRodGrade = 4108 Then
					result = "WFT S67"
				ElseIf iRodGrade = 4109 Then
					result = "WFT S60"
				ElseIf iRodGrade = 4100 Then
					result = "WFT EL"
				ElseIf iRodGrade = 4106 Then
					result = "Highland XD"
				ElseIf iRodGrade = 8195 Then
					result = "Flexbar C"
				ElseIf iRodGrade = 8199 Then
					result = "Flexbar C (nn)"
				ElseIf iRodGrade = 8196 Then
					result = "Flexbar K"
				ElseIf iRodGrade = 8200 Then
					result = "Flexbar K (nn)"
				ElseIf iRodGrade = 4110 Then
					result = "UPCO C"
				ElseIf iRodGrade = 4111 Then
					result = "UPCO CD"
				ElseIf iRodGrade = 4112 Then
					result = "UPCO AD"
				ElseIf iRodGrade = 4113 Then
					result = "UPCO KD"
				ElseIf iRodGrade = 4114 Then
					result = "UPCO K"
				ElseIf iRodGrade = 4115 Then
					result = "UPCO HS"
				ElseIf iRodGrade = 4141 Then
					result = "UPCO HX"
				ElseIf iRodGrade = 13057 Then
					result = "Corod-H"
				ElseIf iRodGrade = 12804 Then
					result = "Corod-R C"
				ElseIf iRodGrade = 12801 Then
					result = "Corod-R D"
				ElseIf iRodGrade = 12802 Then
					result = "Corod-R HS41"
				ElseIf iRodGrade = 12803 Then
					result = "Corod-R SE"
				ElseIf iRodGrade = 12545 Then
					result = "Corod-semi C"
				ElseIf iRodGrade = 12546 Then
					result = "Corod-semi D"
				ElseIf iRodGrade = 12547 Then
					result = "Corod-semi HS41"
				ElseIf iRodGrade = 12548 Then
					result = "Corod-semi SE"
				ElseIf iRodGrade = 12549 Then
					result = "Corod-semi DE"
				ElseIf iRodGrade = 12550 Then
					result = "Corod-semi SE"
				ElseIf iRodGrade = 12805 Then
					result = "Corod-R DE"
				ElseIf iRodGrade = 12806 Then
					result = "Corod-R SE"
				ElseIf iRodGrade = 12807 Then
					result = "Corod-R DW"
				ElseIf iRodGrade = 12808 Then
					result = "Corod-R SW"
				ElseIf iRodGrade = 24577 Then
					result = RSWIN_DESC.sPROROD620
				ElseIf iRodGrade = 24578 Then
					result = RSWIN_DESC.sPROROD790
				ElseIf iRodGrade = 24579 Then
					result = RSWIN_DESC.sPROROD780
				ElseIf iRodGrade = 24580 Then
					result = RSWIN_DESC.sPROROD750
				ElseIf iRodGrade = 24581 Then
					result = RSWIN_DESC.sPROROD960
				ElseIf iRodGrade = 24582 Then
					result = RSWIN_DESC.sPROROD970
				ElseIf iRodGrade = 8301 Then
					result = "NRS PR Steel"
				ElseIf iRodGrade = 8302 Then
					result = "NRS PR Alloy"
				ElseIf iRodGrade = 16385 OrElse iRodGrade = 16389 OrElse iRodGrade = 16390 Then
					result = "Fiberflex"
				ElseIf iRodGrade = 16386 Then
					result = "Petrorod"
				ElseIf iRodGrade = 16387 Then
					result = "Norris FG"
				ElseIf iRodGrade = 16388 Then
					result = "LTV Durarod"
				ElseIf iRodGrade = 16391 Then
					result = "Fiberod"
				ElseIf iRodGrade = 16393 Then
					result = "Fiberod CCR"
				ElseIf iRodGrade = 16394 Then
					result = "FlexRod"
				ElseIf iRodGrade = 16395 Then
					result = "Superod"
				ElseIf iRodGrade = 20481 Then
					result = "Ribbon Rod"
				ElseIf CUSTOMRG.IsOtherSinkerBar(iRodGrade) Then
					Dim num As Single = 0F
					result = RODUTIL.GetOtherSinkerbar(iRodGrade, num)
				ElseIf CUSTOMRG.IsOtherSteel(iRodGrade) Then
					Dim num As Single = 0F
					result = RODUTIL.GetOtherSteel(iRodGrade, num)
				ElseIf CUSTOMRG.IsOtherFG(iRodGrade) Then
					Dim num As Single = 0F
					result = RODUTIL.GetOtherFG(iRodGrade, num)
				End If
				Return result
			End If
			Return text
		End Function

		Public Function GetOtherSinkerbar(iRodGrade As Integer, Optional ByRef fTensileStrength As Single = 0F) As String
			Dim result As String = ""
			Dim num As Integer = -1
			Dim num2 As Integer = 1
			Dim num3 As Integer = Information.LBound(RSWIN_DESC.CustomRodGradeList, 1)
			Dim num4 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
			For i As Integer = num3 To num4
				If RSWIN_DESC.CustomRodGradeList(i).RodType IsNot Nothing AndAlso RSWIN_DESC.CustomRodGradeList(i).SinkerBar <> 0S Then
					If iRodGrade = 8311 + num2 Then
						num = i
						Exit For
					End If
					num2 += 1
				End If
			Next
			If num <> -1 Then
				result = RSWIN_DESC.CustomRodGradeList(num).RodType
				fTensileStrength = RSWIN_DESC.CustomRodGradeList(num).TensileStrength
			End If
			Return result
		End Function

		Public Function GetOtherSteel(iRodGrade As Integer, Optional ByRef fTensileStrength As Single = 0F) As String
			Dim result As String = "Other steel"
			Dim num As Integer = -1
			Dim num2 As Integer = 1
			Dim num3 As Integer = Information.LBound(RSWIN_DESC.CustomRodGradeList, 1)
			Dim num4 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
			For i As Integer = num3 To num4
				If RSWIN_DESC.CustomRodGradeList(i).RodType IsNot Nothing AndAlso (RSWIN_DESC.CustomRodGradeList(i).Steel And Not RSWIN_DESC.CustomRodGradeList(i).SinkerBar) <> 0S Then
					If iRodGrade = 4143 + num2 Then
						num = i
						Exit For
					End If
					num2 += 1
				End If
			Next
			If num <> -1 Then
				result = RSWIN_DESC.CustomRodGradeList(num).RodType
				fTensileStrength = RSWIN_DESC.CustomRodGradeList(num).TensileStrength
			End If
			Return result
		End Function

		Public Function GetOtherFG(iRodGrade As Integer, Optional ByRef fTensileStrength As Single = 0F) As String
			Dim result As String = "Other FG"
			Dim num As Integer = -1
			Dim num2 As Integer = 1
			Dim num3 As Integer = Information.LBound(RSWIN_DESC.CustomRodGradeList, 1)
			Dim num4 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
			For i As Integer = num3 To num4
				If RSWIN_DESC.CustomRodGradeList(i).RodType IsNot Nothing AndAlso Not RSWIN_DESC.CustomRodGradeList(i).SinkerBar <> 0S Then
					If iRodGrade = 16397 + num2 Then
						num = i
						Exit For
					End If
					num2 += 1
				End If
			Next
			If num <> -1 Then
				result = RSWIN_DESC.CustomRodGradeList(num).RodType
				fTensileStrength = RSWIN_DESC.CustomRodGradeList(num).TensileStrength
			End If
			Return result
		End Function

		Public Function RodType(iRodGrade As Object) As Integer
			Return Conversions.ToInteger(Operators.AndObject(Operators.IntDivideObject(iRodGrade, 4096), 15))
		End Function

		Public Sub RoundSectionLengths(NumRods As Integer, RodStringLength As Single)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Single = 0F
			Dim num2 As Single = 1F
			Dim num3 As Single = CSng((rst.NumRods - 1S))
			Dim num4 As Single = num2
			While num4 <= num3
				' The following expression was wrapped in a checked-expression
				RODUTIL.CheckSuckerRodLength(rst.Sections(CInt(Math.Round(CDbl(num4)))), False)
				rst.Sections(CInt(Math.Round(CDbl(num4)))).length = CSng((Conversion.Int(CDbl((rst.Sections(CInt(Math.Round(CDbl(num4)))).length / rst.Sections(CInt(Math.Round(CDbl(num4)))).SuckerRodLength)) + 0.5) * CDbl(rst.Sections(CInt(Math.Round(CDbl(num4)))).SuckerRodLength)))
				num += rst.Sections(CInt(Math.Round(CDbl(num4)))).length
				num4 += 1F
			End While
			rst.Sections(NumRods).length = RodStringLength - num
		End Sub

		Public Function StressMethodName(iStressMethod As Integer) As String
			Dim result As String
			Select Case iStressMethod
				Case 0
					result = "API Modified Goodman Diagram"
				Case 1
					result = "Modified Goodman, with T/2.8"
				Case 2
					result = "Modified Goodman, with T/3"
				Case 3
					result = "Weatherford EL"
				Case 4
					result = "MGS (Modified Goodman Stress)"
				Case 8
					result = "Ribbon Rod / Amoco"
				Case 9
					result = "Fiberod"
				Case 10
					result = "Tenaris"
				Case 11
					result = "Fiberod CCR"
				Case 12
					result = "Tenaris PC"
				Case 13
					result = "FlexRod"
				Case 14
					result = "Superod"
				Case 15
					result = "Edge FiberCo"
				Case 16
					result = "Tenaris PC"
			End Select
			Return result
		End Function

		Public Function TubingStretch(FluidLoad As Single, bTubingAnchored As Integer, TubingAnchorDepth As Single) As Object
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim result As Object
			If(bTubingAnchored And If((-If(((CDbl((rst.PumpDepth - TubingAnchorDepth)) <= 50.0 Or TubingAnchorDepth > rst.PumpDepth) > False), 1, 0)), 1, 0)) <> 0 Then
				result = 0.0
			Else
				Dim num As Single
				If bTubingAnchored <> 0 Then
					num = rst.PumpDepth - TubingAnchorDepth
				Else
					num = rst.PumpDepth
				End If
				If FluidLoad < 0F Then
					If rst.giFluidLevelSource = 0S And rst.XDFeetFromSurface < 0F Then
						Dim pumpLoad As Single() = rst.PumpLoad
						Dim num2 As Single = 0F
						Dim num3 As Single = 0F
						Dim num4 As Single
						Dim num5 As Single
						Util.Maxmin(pumpLoad, num4, num5, num2, num3)
						FluidLoad = CSng((0.8 * CDbl((num4 - num5))))
					Else
						Dim num6 As Single
						If(If((-If(((rst.giFluidLevelSource <> 0S) > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.gSysDiag.bFluidLevelCorrected) <> 0S Then
							num6 = rst.FluidLevel
						Else
							num6 = rst.XDFeetFromSurface
						End If
						FluidLoad = CSng(((0.433 * CDbl(rst.FluidSPGR) * CDbl(num6) + CDbl(rst.TubingPressure) - CDbl(rst.CasingPressure)) * CDbl(rst.Apump)))
					End If
				End If
				result = 15.28 * CDbl(FluidLoad) * CDbl(num) / ((Math.Pow(CDbl(rst.TubingOD), 2.0) - Math.Pow(CDbl(rst.TubingID), 2.0)) * 30500000.0)
			End If
			Return result
		End Function

		Public Sub CheckCustomRodGrades()
			RSWIN_DESC.nNewRGTypes = 0S
			RSWIN_DESC.NewRGTypes = New RSWIN_DESC.CustomRodGrade(CInt((RSWIN_DESC.nNewRGTypes + 1S)) - 1) {}
			Dim array As Boolean() = New Boolean(CInt((RSWIN_DESC.nNewRGTypes + 1S)) - 1) {}
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Integer = 1
			Dim numRods As Integer = CInt(rst.NumRods)
			For i As Integer = num To numRods
				If CUSTOMRG.IsOtherSteel(CInt(rst.Sections(i).Grade)) Or (rst.Sections(i).Grade = 0S And Operators.CompareString(rst.Sections(i).RodType.Trim(), "", False) <> 0) Then
					Dim flag As Boolean

						If rst.Sections(i).RodWeight = 0F Then
							If rst.Sections(i).Area = 0F Then
								rst.Sections(i).Area = CSng((Math.Pow(CDbl(rst.Sections(i).Diameter), 2.0) * 3.141592653589793 / 4.0))
							End If
							If CDbl(rst.Sections(i).Diameter) > 1.25 Then
								rst.Sections(i).RodWeight = CSng((CDbl(rst.Sections(i).Area) * 3.403))
							Else
								rst.Sections(i).RodWeight = CSng((CDbl(rst.Sections(i).Area) * 3.695))
							End If
						End If
						If rst.Sections(i).StressMethod = 0S Then
							rst.Sections(i).StressMethod = 0S
						End If
						If rst.Sections(i).TensileStrength = 0F Then
							flag = True
							If CDbl(rst.Sections(i).Diameter) > 1.25 Then
								rst.Sections(i).TensileStrength = 90000F
							Else
								rst.Sections(i).TensileStrength = 115000F
							End If
						Else
							flag = False
						End If

					If Not RODUTIL.RodTypeAlreadyAdded(rst.Sections(i).RodType) Then
						RSWIN_DESC.nNewRGTypes += 1S
						RSWIN_DESC.NewRGTypes = CType(Utils.CopyArray(CType(RSWIN_DESC.NewRGTypes, Array), New RSWIN_DESC.CustomRodGrade(CInt((RSWIN_DESC.nNewRGTypes + 1S)) - 1) {}), RSWIN_DESC.CustomRodGrade())
						array = CType(Utils.CopyArray(CType(array, Array), New Boolean(CInt((RSWIN_DESC.nNewRGTypes + 1S)) - 1) {}), Boolean())
						If rst.Sections(i).RodType Is Nothing Then
							rst.Sections(i).RodType = ""
						End If
						RSWIN_DESC.NewRGTypes(CInt(RSWIN_DESC.nNewRGTypes)).RodType = rst.Sections(i).RodType.Trim()
						RSWIN_DESC.NewRGTypes(CInt(RSWIN_DESC.nNewRGTypes)).Steel = -1S
						If CDbl(rst.Sections(i).Diameter) > 1.25 Then
							RSWIN_DESC.NewRGTypes(CInt(RSWIN_DESC.nNewRGTypes)).SinkerBar = -1S
						Else
							RSWIN_DESC.NewRGTypes(CInt(RSWIN_DESC.nNewRGTypes)).SinkerBar = 0S
						End If
						RSWIN_DESC.NewRGTypes(CInt(RSWIN_DESC.nNewRGTypes)).TensileStrength = rst.Sections(i).TensileStrength
						RSWIN_DESC.NewRGTypes(CInt(RSWIN_DESC.nNewRGTypes)).StressMethod = rst.Sections(i).StressMethod
						array(i) = flag
					End If
				End If
			Next
			CUSTOMRG.AddCustomRodGrades(RSWIN_DESC.NewRGTypes, RSWIN_DESC.nNewRGTypes, CShort(RSWIN_DESC.SETUP_BatchUpdateCustomRodGrades), array)
			Dim num2 As Integer = 1
			Dim numRods2 As Integer = CInt(rst.NumRods)
			For i As Integer = num2 To numRods2
				If rst.Sections(i).Grade = 0S And Operators.CompareString(rst.Sections(i).RodType.Trim(), "", False) <> 0 Then
					rst.Sections(i).Grade = CShort(MRodstarXML.DoCustomSteelRodGradeLookup(rst.Sections(i).RodType.Trim()))
				End If
			Next
		End Sub

		Private Function RodTypeAlreadyAdded(sRodType As Object) As Boolean
			Dim result As Boolean = False
			Dim num As Integer = Information.LBound(RSWIN_DESC.NewRGTypes, 1)
			Dim num2 As Integer = Information.UBound(RSWIN_DESC.NewRGTypes, 1)
			For i As Integer = num To num2
				If RSWIN_DESC.NewRGTypes(CInt(RSWIN_DESC.nNewRGTypes)).RodType IsNot Nothing AndAlso Operators.ConditionalCompareObjectEqual(RSWIN_DESC.NewRGTypes(CInt(RSWIN_DESC.nNewRGTypes)).RodType.Trim(), NewLateBinding.LateGet(sRodType, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), False) Then
					result = True
					Exit For
				End If
			Next
			Return result
		End Function

		Public Function CheckRodsInTubing(Quiet As Object, Grade As Object, Diameter As Object, ByRef FullOK As Object, ByRef SlimNeeded As Object, ByRef msg As Object, ByRef bMsgDisplayed As Object, iSect As Object) As Boolean
			Dim result As Boolean = True
			Dim num As Integer
			If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.CompareObjectEqual(Grade, 4116, False), Operators.CompareObjectEqual(Grade, 4101, False)), Operators.CompareObjectEqual(Diameter, 1.25, False))) Then
				num = -1
			Else
				num = 0
			End If
			FullOK = True
			SlimNeeded = False
			msg = ""
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim flag As Boolean = False
			If Operators.ConditionalCompareObjectEqual(iSect, 0, False) Then
				If Conversions.ToBoolean(Operators.OrObject(Operators.AndObject(Operators.AndObject(RODUTIL.IsSteel(RuntimeHelpers.GetObjectValue(Grade)), Operators.OrObject(Operators.AndObject(Operators.CompareObjectGreater(Diameter, 1.125, False), Operators.CompareObjectLessEqual(Diameter, 1.25, False)), Operators.CompareObjectGreater(Diameter, 2F, False))), Not num), Operators.AndObject(RODUTIL.IsSinkerBarGrade(RuntimeHelpers.GetObjectValue(Grade)), Operators.CompareObjectLessEqual(Diameter, 1.5, False)))) Then
					flag = True
				End If
			ElseIf Conversions.ToBoolean(Operators.OrObject(Operators.AndObject(Operators.AndObject(RODUTIL.IsSteel(RuntimeHelpers.GetObjectValue(Grade)), Operators.OrObject(Operators.AndObject(Operators.CompareObjectGreater(Diameter, 1.125, False), Operators.CompareObjectLessEqual(Diameter, 1.25, False)), Operators.CompareObjectGreater(Diameter, 2F, False))), Not num), Operators.AndObject(RODUTIL.IsSinkerBar(RuntimeHelpers.GetObjectValue(iSect)), Operators.CompareObjectLessEqual(Diameter, 1.5, False)))) Then
				flag = True
			End If
			Dim obj As Object = Nothing
			Dim typeFromHandle As Type = GetType(RODUTIL)
			Dim text As String = "IsCorodH"
			Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(Grade) }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True }
			Dim obj2 As Object = NewLateBinding.LateGet(obj, typeFromHandle, text, array2, array3, array4, array5)
			If array5(0) Then
				Grade = RuntimeHelpers.GetObjectValue(array(0))
			End If
			Dim array6 As Object()
			If Conversions.ToBoolean(obj2) Then
				Dim obj3 As Object = Operators.DivideObject(Operators.MultiplyObject(3.141592653589793, Operators.ExponentObject(Diameter, 2)), 4)
				If Operators.ConditionalCompareObjectLess(obj3, 0.7, False) Then
					If rst.TubingOD < 2.375F Then
						FullOK = False
					End If
				ElseIf rst.TubingOD < 2.875F Then
					FullOK = False
				End If
			Else
				Dim obj4 As Object = Nothing
				Dim typeFromHandle2 As Type = GetType(RODUTIL)
				Dim text2 As String = "IsCorod"
				array6 = New Object() { RuntimeHelpers.GetObjectValue(Grade) }
				Dim array7 As Object() = array6
				Dim array8 As String() = Nothing
				Dim array9 As Type() = Nothing
				array5 = New Boolean() { True }
				Dim obj5 As Object = NewLateBinding.LateGet(obj4, typeFromHandle2, text2, array7, array8, array9, array5)
				If array5(0) Then
					Grade = RuntimeHelpers.GetObjectValue(array6(0))
				End If
				If Conversions.ToBoolean(Operators.OrObject(obj5, RODUTIL.IsProRod(Conversions.ToInteger(Grade)))) Then
					Dim tubingOD As Single = rst.TubingOD
					If tubingOD < 3.5F Then
						If tubingOD >= 2.875F Then
							If Operators.ConditionalCompareObjectGreater(Diameter, 1.15625F, False) Then
								FullOK = False
							End If
						ElseIf tubingOD >= 2.375F Then
							Dim obj6 As Object = Nothing
							Dim typeFromHandle3 As Type = GetType(RODUTIL)
							Dim text3 As String = "IsCorodSE"
							array6 = New Object() { RuntimeHelpers.GetObjectValue(Grade) }
							Dim array10 As Object() = array6
							Dim array11 As String() = Nothing
							Dim array12 As Type() = Nothing
							array5 = New Boolean() { True }
							Dim obj7 As Object = NewLateBinding.LateGet(obj6, typeFromHandle3, text3, array10, array11, array12, array5)
							If array5(0) Then
								Grade = RuntimeHelpers.GetObjectValue(array6(0))
							End If
							If Conversions.ToBoolean(obj7) Then
								If Operators.ConditionalCompareObjectGreater(Diameter, 1.0625F, False) Then
									FullOK = False
								End If
							ElseIf Operators.ConditionalCompareObjectGreater(Diameter, 1F, False) Then
								FullOK = False
							End If
						ElseIf tubingOD >= 2.0625F Then
							Dim obj8 As Object = Nothing
							Dim typeFromHandle4 As Type = GetType(RODUTIL)
							Dim text4 As String = "IsCorodSE"
							array6 = New Object() { RuntimeHelpers.GetObjectValue(Grade) }
							Dim array13 As Object() = array6
							Dim array14 As String() = Nothing
							Dim array15 As Type() = Nothing
							array5 = New Boolean() { True }
							Dim obj9 As Object = NewLateBinding.LateGet(obj8, typeFromHandle4, text4, array13, array14, array15, array5)
							If array5(0) Then
								Grade = RuntimeHelpers.GetObjectValue(array6(0))
							End If
							If Conversions.ToBoolean(obj9) Then
								If Operators.ConditionalCompareObjectGreater(Diameter, 1F, False) Then
									FullOK = False
								End If
							ElseIf Operators.ConditionalCompareObjectGreater(Diameter, 0.9375F, False) Then
								FullOK = False
							End If
						ElseIf tubingOD >= 1.9F Then
							If Operators.ConditionalCompareObjectGreater(Diameter, 0.875F, False) Then
								FullOK = False
							End If
						ElseIf Operators.ConditionalCompareObjectGreater(Diameter, CDbl(rst.TubingOD) - 0.74, False) Then
							FullOK = False
						End If
					End If
				ElseIf Not flag Then
					Dim num2 As Single
					RODUTIL.GetPinSize(Conversions.ToSingle(Grade), Conversions.ToSingle(Diameter), num2)
					If Not((rst.TubingOD = 2.375F And rst.TubingID = 1.71F) Or (rst.TubingOD = 2.875F And rst.TubingID = 2.16F) Or (rst.TubingOD = 3.5F And rst.TubingID = 2.67F)) Then
						Dim num3 As Single = num2
						If num3 <= 0.5F Then
							If rst.TubingOD < 1.66F Then
								FullOK = False
							End If
						ElseIf num3 <= 0.625F Then
							If rst.TubingOD < 1.9F Then
								FullOK = False
							ElseIf rst.TubingOD < 2.0625F Then
								SlimNeeded = True
							End If
						ElseIf num3 <= 0.75F Then
							If rst.TubingOD < 2.0625F Then
								FullOK = False
							ElseIf rst.TubingOD < 2.375F Then
								SlimNeeded = True
							End If
						ElseIf num3 <= 0.875F Then
							If rst.TubingOD < 2.375F Then
								FullOK = False
							ElseIf rst.TubingOD < 2.875F Then
								SlimNeeded = True
							End If
						ElseIf num3 <= 1F Then
							If rst.TubingOD < 2.875F Then
								FullOK = False
							ElseIf rst.TubingOD < 3.5F Then
								SlimNeeded = True
							End If
						ElseIf num3 <= 1.125F Then
							If rst.TubingOD < 3.5F Then
								FullOK = False
							ElseIf rst.TubingOD < 3F Then
								SlimNeeded = True
							End If
						ElseIf num3 <= 1.25F Then
							If Operators.ConditionalCompareObjectLess(CDbl(rst.TubingID) - 0.6, Diameter, False) Then
								FullOK = False
							End If
						ElseIf num3 <= 1.375F Then
							If rst.TubingOD < 2.375F Then
								FullOK = False
							End If
						ElseIf num3 <= 1.5F Then
							If rst.TubingOD < 2.375F Then
								FullOK = False
							End If
						ElseIf num3 <= 1.625F Then
							If rst.TubingOD < 2.875F Then
								FullOK = False
							End If
						ElseIf num3 <= 1.75F Then
							If rst.TubingOD < 2.875F Then
								FullOK = False
							End If
						ElseIf num3 <= 2F Then
							If rst.TubingOD < 3.5F Then
								FullOK = False
							End If
						ElseIf Operators.ConditionalCompareObjectLess(CDbl(rst.TubingID) - 0.6, Diameter, False) Then
							FullOK = False
						End If
					Else
						Dim num4 As Single
						If rst.TubingOD = 2.375F And rst.TubingID = 1.71F Then
							num4 = 1.6F
						ElseIf rst.TubingOD = 2.875F And rst.TubingID = 2.16F Then
							num4 = 2F
						ElseIf rst.TubingOD = 3.5F And rst.TubingID = 2.67F Then
							num4 = 2.5F
						End If
						If Operators.ConditionalCompareObjectLess(CDbl(num4) - 0.6, Diameter, False) Then
							FullOK = False
						End If
					End If
				End If
			End If
			Dim obj10 As Object = RODUTIL.IsSteel(RuntimeHelpers.GetObjectValue(Grade))
			Dim obj11 As Object = Nothing
			Dim typeFromHandle5 As Type = GetType(RODUTIL)
			Dim text5 As String = "IsCorod"
			array6 = New Object() { RuntimeHelpers.GetObjectValue(Grade) }
			Dim array16 As Object() = array6
			Dim array17 As String() = Nothing
			Dim array18 As Type() = Nothing
			array5 = New Boolean() { True }
			Dim obj12 As Object = NewLateBinding.LateGet(obj11, typeFromHandle5, text5, array16, array17, array18, array5)
			If array5(0) Then
				Grade = RuntimeHelpers.GetObjectValue(array6(0))
			End If
			Dim text6 As String
			If Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(obj10, obj12), RODUTIL.IsProRod(Conversions.ToInteger(Grade)))) Then
				text6 = "steel "
			Else
				text6 = "fiberglass "
			End If
			Dim text7 As String
			If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(Diameter, 1.25, False), RODUTIL.IsSteel(RuntimeHelpers.GetObjectValue(Grade)))) Then
				text7 = "sinker bar "
			Else
				text7 = "rod section "
			End If
			Dim text9 As String
			Dim text11 As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				Dim obj13 As Object = Nothing
				Dim typeFromHandle6 As Type = GetType(Util)
				Dim text8 As String = "Format"
				array6 = New Object() { RuntimeHelpers.GetObjectValue(Diameter), "0.0##" }
				Dim array19 As Object() = array6
				Dim array20 As String() = Nothing
				Dim array21 As Type() = Nothing
				array5 = New Boolean() { True, False }
				Dim obj14 As Object = NewLateBinding.LateGet(obj13, typeFromHandle6, text8, array19, array20, array21, array5)
				If array5(0) Then
					Diameter = RuntimeHelpers.GetObjectValue(array6(0))
				End If
				text9 = Conversions.ToString(Operators.AddObject(Operators.AddObject(obj14, ""), " "))
				Dim cRODSTAR As cRODSTAR = rst
				Dim tubingOD2 As Single = cRODSTAR.TubingOD
				Dim text10 As String = "0.0##"
				Dim str As String = Util.Format(tubingOD2, text10)
				cRODSTAR.TubingOD = tubingOD2
				text11 = str + " "
			Else
				Dim obj15 As Object = Nothing
				Dim typeFromHandle7 As Type = GetType(Util)
				Dim text12 As String = "Format"
				Dim array22 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Diameter), "0.0##" }
				Dim array23 As Object() = array22
				Dim array24 As String() = Nothing
				Dim array25 As Type() = Nothing
				array5 = New Boolean() { True, False }
				Dim obj16 As Object = NewLateBinding.LateGet(obj15, typeFromHandle7, text12, array23, array24, array25, array5)
				If array5(0) Then
					Diameter = RuntimeHelpers.GetObjectValue(array22(0))
				End If
				text9 = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(obj16, ""), " ("), NewLateBinding.LateGet(Nothing, GetType(Util), "Format", New Object() { Operators.MultiplyObject(Diameter, RSWIN_DESC.IN__MM), "0.0" }, Nothing, Nothing, Nothing)), " mm) "))
				Dim cRODSTAR As cRODSTAR = rst
				Dim tubingOD3 As Single = cRODSTAR.TubingOD
				Dim text13 As String = "0.0##"
				Dim str2 As String = Util.Format(tubingOD3, text13)
				cRODSTAR.TubingOD = tubingOD3
				Dim str3 As String = " ("
				Dim tubingOD2 As Single = rst.TubingOD * RSWIN_DESC.IN__MM
				Dim text10 As String = "0.0"
				text11 = str2 + str3 + Util.Format(tubingOD2, text10) + " mm) "
			End If
			Dim text14 As String
			If Conversions.ToBoolean(SlimNeeded) Then
				text14 = "WARNING: A "
			Else
				text14 = "A "
			End If
			Dim text15 As String = "may be too large for the "
			Dim text16 As String = "requires slimhole couplings to fit in the "
			Dim text17 As String = "tubing you have selected."
			Dim text18 As String = " Please use a smaller rod diameter or larger tubing size."
			If Conversions.ToBoolean(Operators.NotObject(FullOK)) Then
				msg = String.Concat(New String() { text14, text9, text6, text7, text15, text11, text17, text18 })
			ElseIf Conversions.ToBoolean(SlimNeeded) Then
				msg = String.Concat(New String() { text14, text9, text6, text7, text16, text11, text17 })
			End If
			If Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Strings.Len(RuntimeHelpers.GetObjectValue(msg)) > 0, Operators.NotObject(Quiet)), Not RSWIN_DESC.bRodsInTubingMsgShown)) Then
				If Strings.InStr(Conversions.ToString(msg), "WARNING", CompareMethod.Binary) <= 0 Then
					result = Verify.VerifyContinueOrReturn(Conversions.ToString(msg), True)
				End If
				bMsgDisplayed = True
				RSWIN_DESC.bRodsInTubingMsgShown = True
			Else
				bMsgDisplayed = False
				result = True
			End If
			Return result
		End Function

		Public Function CheckRodsInTubing_Old(Quiet As Object, Grade As Object, Diameter As Object, ByRef FullOK As Object, ByRef SlimNeeded As Object, ByRef msg As Object, ByRef bMsgDisplayed As Object) As Boolean
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				msg = ""
				Dim num As Integer
				If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.CompareObjectEqual(Grade, 4116, False), Operators.CompareObjectEqual(Grade, 4101, False)), Operators.CompareObjectEqual(Diameter, 1.25, False))) Then
					num = -1
				Else
					num = 0
				End If
				FullOK = True
				SlimNeeded = False
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim obj As Object = Nothing
				Dim typeFromHandle As Type = GetType(RODUTIL)
				Dim text As String = "IsCorodH"
				Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(Grade) }
				Dim array2 As Object() = array
				Dim array3 As String() = Nothing
				Dim array4 As Type() = Nothing
				Dim array5 As Boolean() = New Boolean() { True }
				Dim obj2 As Object = NewLateBinding.LateGet(obj, typeFromHandle, text, array2, array3, array4, array5)
				If array5(0) Then
					Grade = RuntimeHelpers.GetObjectValue(array(0))
				End If
				Dim array6 As Object()
				Dim flag2 As Boolean
				If Conversions.ToBoolean(obj2) Then
					Dim obj3 As Object = Operators.DivideObject(Operators.MultiplyObject(3.141592653589793, Operators.ExponentObject(Diameter, 2)), 4)
					If Operators.ConditionalCompareObjectLess(obj3, 0.7F, False) Then
						If rst.TubingOD < 2.375F Then
							FullOK = False
						End If
					ElseIf rst.TubingOD < 2.875F Then
						FullOK = False
					End If
				Else
					Dim obj4 As Object = Nothing
					Dim typeFromHandle2 As Type = GetType(RODUTIL)
					Dim text2 As String = "IsCorod"
					array6 = New Object() { RuntimeHelpers.GetObjectValue(Grade) }
					Dim array7 As Object() = array6
					Dim array8 As String() = Nothing
					Dim array9 As Type() = Nothing
					array5 = New Boolean() { True }
					Dim obj5 As Object = NewLateBinding.LateGet(obj4, typeFromHandle2, text2, array7, array8, array9, array5)
					If array5(0) Then
						Grade = RuntimeHelpers.GetObjectValue(array6(0))
					End If
					If Conversions.ToBoolean(Operators.OrObject(obj5, RODUTIL.IsProRod(Conversions.ToInteger(Grade)))) Then
						Dim tubingOD As Single = rst.TubingOD
						If tubingOD < 3.5F Then
							If tubingOD >= 2.875F Then
								If Operators.ConditionalCompareObjectGreater(Diameter, 1.15625F, False) Then
									FullOK = False
								End If
							ElseIf tubingOD >= 2.375F Then
								Dim obj6 As Object = Nothing
								Dim typeFromHandle3 As Type = GetType(RODUTIL)
								Dim text3 As String = "IsCorodSE"
								array6 = New Object() { RuntimeHelpers.GetObjectValue(Grade) }
								Dim array10 As Object() = array6
								Dim array11 As String() = Nothing
								Dim array12 As Type() = Nothing
								array5 = New Boolean() { True }
								Dim obj7 As Object = NewLateBinding.LateGet(obj6, typeFromHandle3, text3, array10, array11, array12, array5)
								If array5(0) Then
									Grade = RuntimeHelpers.GetObjectValue(array6(0))
								End If
								If Conversions.ToBoolean(obj7) Then
									If Operators.ConditionalCompareObjectGreater(Diameter, 1.0625F, False) Then
										FullOK = False
									End If
								ElseIf Operators.ConditionalCompareObjectGreater(Diameter, 1F, False) Then
									FullOK = False
								End If
							ElseIf tubingOD >= 2.0625F Then
								Dim obj8 As Object = Nothing
								Dim typeFromHandle4 As Type = GetType(RODUTIL)
								Dim text4 As String = "IsCorodSE"
								array6 = New Object() { RuntimeHelpers.GetObjectValue(Grade) }
								Dim array13 As Object() = array6
								Dim array14 As String() = Nothing
								Dim array15 As Type() = Nothing
								array5 = New Boolean() { True }
								Dim obj9 As Object = NewLateBinding.LateGet(obj8, typeFromHandle4, text4, array13, array14, array15, array5)
								If array5(0) Then
									Grade = RuntimeHelpers.GetObjectValue(array6(0))
								End If
								If Conversions.ToBoolean(obj9) Then
									If Operators.ConditionalCompareObjectGreater(Diameter, 1F, False) Then
										FullOK = False
									End If
								ElseIf Operators.ConditionalCompareObjectGreater(Diameter, 0.9375F, False) Then
									FullOK = False
								End If
							ElseIf tubingOD >= 1.9F Then
								If Operators.ConditionalCompareObjectGreater(Diameter, 0.875F, False) Then
									FullOK = False
								End If
							ElseIf Operators.ConditionalCompareObjectGreater(Diameter, rst.TubingOD - 0.74F, False) Then
								FullOK = False
							End If
						End If
					ElseIf Not Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(RODUTIL.IsSteel(RuntimeHelpers.GetObjectValue(Grade)), Operators.OrObject(Operators.AndObject(Operators.CompareObjectGreater(Diameter, 1.125F, False), Operators.CompareObjectLessEqual(Diameter, 1.25F, False)), Operators.CompareObjectGreater(Diameter, 2F, False))), Not num)) Then
						Dim num2 As Single
						RODUTIL.GetPinSize(Conversions.ToSingle(Grade), Conversions.ToSingle(Diameter), num2)
						If Not((rst.TubingOD = 2.375F And rst.TubingID = 1.71F) Or (rst.TubingOD = 2.875F And rst.TubingID = 2.16F) Or (rst.TubingOD = 3.5F And rst.TubingID = 2.67F)) Then
							Dim num3 As Single = num2
							If num3 <= 0.5F Then
								If rst.TubingOD < 1.66F Then
									FullOK = False
								End If
							ElseIf num3 <= 0.625F Then
								If rst.TubingOD < 1.9F Then
									FullOK = False
								ElseIf rst.TubingOD < 2.0625F Then
									SlimNeeded = True
								End If
							ElseIf num3 <= 0.75F Then
								If rst.TubingOD < 2.0625F Then
									FullOK = False
								ElseIf rst.TubingOD < 2.375F Then
									SlimNeeded = True
								End If
							ElseIf num3 <= 0.875F Then
								If rst.TubingOD < 2.375F Then
									FullOK = False
								ElseIf rst.TubingOD < 2.875F Then
									SlimNeeded = True
								End If
							ElseIf num3 <= 1F Then
								If rst.TubingOD < 2.875F Then
									FullOK = False
								ElseIf rst.TubingOD < 3.5F Then
									SlimNeeded = True
								End If
							ElseIf num3 <= 1.125F Then
								If rst.TubingOD < 3.5F Then
									FullOK = False
								ElseIf rst.TubingOD < 3F Then
									SlimNeeded = True
								End If
							ElseIf num3 <= 1.25F Then
								If Operators.ConditionalCompareObjectLess(CDbl(rst.TubingID) - 0.6, Diameter, False) Then
									FullOK = False
								End If
							ElseIf num3 <= 1.375F Then
								If rst.TubingOD < 2.375F Then
									FullOK = False
								End If
							ElseIf num3 <= 1.5F Then
								If rst.TubingOD < 2.375F Then
									FullOK = False
								End If
							ElseIf num3 <= 1.625F Then
								If rst.TubingOD < 2.875F Then
									FullOK = False
								End If
							ElseIf num3 <= 1.75F Then
								If rst.TubingOD < 2.875F Then
									FullOK = False
								End If
							ElseIf num3 <= 2F Then
								If rst.TubingOD < 3.5F Then
									FullOK = False
								End If
							ElseIf Operators.ConditionalCompareObjectLess(CDbl(rst.TubingID) - 0.6, Diameter, False) Then
								FullOK = False
							End If
						Else
							flag2 = True
							Dim num4 As Single
							If rst.TubingOD = 2.375F And rst.TubingID = 1.71F Then
								num4 = 1.6F
							ElseIf rst.TubingOD = 2.875F And rst.TubingID = 2.16F Then
								num4 = 2F
							ElseIf rst.TubingOD = 3.5F And rst.TubingID = 2.67F Then
								num4 = 2.5F
							End If
							If Operators.ConditionalCompareObjectLess(CDbl(num4) - 0.6, Diameter, False) Then
								FullOK = False
							End If
						End If
					End If
				End If
				Dim obj10 As Object = RODUTIL.IsSteel(RuntimeHelpers.GetObjectValue(Grade))
				Dim obj11 As Object = Nothing
				Dim typeFromHandle5 As Type = GetType(RODUTIL)
				Dim text5 As String = "IsCorod"
				array6 = New Object() { RuntimeHelpers.GetObjectValue(Grade) }
				Dim array16 As Object() = array6
				Dim array17 As String() = Nothing
				Dim array18 As Type() = Nothing
				array5 = New Boolean() { True }
				Dim obj12 As Object = NewLateBinding.LateGet(obj11, typeFromHandle5, text5, array16, array17, array18, array5)
				If array5(0) Then
					Grade = RuntimeHelpers.GetObjectValue(array6(0))
				End If
				Dim text6 As String
				If Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(obj10, obj12), RODUTIL.IsProRod(Conversions.ToInteger(Grade)))) Then
					text6 = "steel "
				Else
					text6 = "fiberglass "
				End If
				Dim text7 As String
				If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(Diameter, 1.25, False), RODUTIL.IsSteel(RuntimeHelpers.GetObjectValue(Grade)))) Then
					text7 = "sinker bar "
				Else
					text7 = "rod section "
				End If
				Dim text9 As String
				Dim text11 As String
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					Dim obj13 As Object = Nothing
					Dim typeFromHandle6 As Type = GetType(Util)
					Dim text8 As String = "Format"
					array6 = New Object() { RuntimeHelpers.GetObjectValue(Diameter), "0.0##" }
					Dim array19 As Object() = array6
					Dim array20 As String() = Nothing
					Dim array21 As Type() = Nothing
					array5 = New Boolean() { True, False }
					Dim obj14 As Object = NewLateBinding.LateGet(obj13, typeFromHandle6, text8, array19, array20, array21, array5)
					If array5(0) Then
						Diameter = RuntimeHelpers.GetObjectValue(array6(0))
					End If
					text9 = Conversions.ToString(Operators.AddObject(Operators.AddObject(obj14, ""), " "))
					Dim cRODSTAR As cRODSTAR = rst
					Dim tubingOD2 As Single = cRODSTAR.TubingOD
					Dim text10 As String = "0.0##"
					Dim str As String = Util.Format(tubingOD2, text10)
					cRODSTAR.TubingOD = tubingOD2
					text11 = str + " "
				Else
					Dim obj15 As Object = Nothing
					Dim typeFromHandle7 As Type = GetType(Util)
					Dim text12 As String = "Format"
					Dim array22 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Diameter), "0.0##" }
					Dim array23 As Object() = array22
					Dim array24 As String() = Nothing
					Dim array25 As Type() = Nothing
					array5 = New Boolean() { True, False }
					Dim obj16 As Object = NewLateBinding.LateGet(obj15, typeFromHandle7, text12, array23, array24, array25, array5)
					If array5(0) Then
						Diameter = RuntimeHelpers.GetObjectValue(array22(0))
					End If
					text9 = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(obj16, ""), " ("), NewLateBinding.LateGet(Nothing, GetType(Util), "Format", New Object() { Operators.MultiplyObject(Diameter, RSWIN_DESC.IN__MM), "0.0" }, Nothing, Nothing, Nothing)), " mm) "))
					Dim cRODSTAR As cRODSTAR = rst
					Dim tubingOD3 As Single = cRODSTAR.TubingOD
					Dim text13 As String = "0.0##"
					Dim str2 As String = Util.Format(tubingOD3, text13)
					cRODSTAR.TubingOD = tubingOD3
					Dim str3 As String = " ("
					Dim tubingOD2 As Single = rst.TubingOD * RSWIN_DESC.IN__MM
					Dim text10 As String = "0.0"
					text11 = str2 + str3 + Util.Format(tubingOD2, text10) + " mm) "
				End If
				If Conversions.ToBoolean(Operators.NotObject(FullOK)) Then
					msg = String.Concat(New String() { "WARNING: A ", text9, text6, text7, "is too large for the ", text11, "tubing you have selected." })
				ElseIf Conversions.ToBoolean(SlimNeeded) Then
					msg = String.Concat(New String() { "WARNING: A ", text9, text6, text7, "requires slimhole couplings to fit in the ", text11, "tubing you have selected." })
				End If
				If Conversions.ToBoolean(Operators.NotObject(FullOK)) Then
					If flag2 Then
						msg = String.Concat(New String() { "WARNING: A ", text9, text6, text7, "is too large for the ", text11, "polylined tubing you have selected." })
					Else
						msg = String.Concat(New String() { "WARNING: A ", text9, text6, text7, "is too large for the ", text11, "tubing you have selected." })
					End If
				ElseIf Conversions.ToBoolean(SlimNeeded) Then
					If flag2 Then
						msg = String.Concat(New String() { "WARNING: A ", text9, text6, text7, "requires slimhole couplings to fit in the ", text11, "polylined tubing you have selected." })
					Else
						msg = String.Concat(New String() { "WARNING: A ", text9, text6, text7, "requires slimhole couplings to fit in the ", text11, "tubing you have selected." })
					End If
				End If
				If Conversions.ToBoolean(Operators.AndObject(Strings.Len(RuntimeHelpers.GetObjectValue(msg)) > 0, Operators.NotObject(Quiet))) Then
					Util.Errmsg(Conversions.ToString(msg))
					flag = False
					bMsgDisplayed = True
				ElseIf Strings.Len(RuntimeHelpers.GetObjectValue(msg)) > 0 Then
					flag = False
					bMsgDisplayed = False
				End If
				result = flag
			Catch ex As Exception
				MessageBox.Show("Error in CheckRodsInTubing: " + ex.Message)
			End Try
			Return result
		End Function

		Public Function LoadDiameterList(ByRef myAL As ArrayList, iRodGrade As Short, ByRef sRodType As String, bMaxMin As Boolean) As Boolean
			Dim result As Boolean = True
			Try
				myAL.Clear()
				Dim teRodSizeList As teRodSizeList
				If CUSTOMRG.IsOtherSteel(CInt(iRodGrade)) Or CUSTOMRG.IsOtherFG(CInt(iRodGrade)) Or CUSTOMRG.IsOtherSinkerBar(CInt(iRodGrade)) Then
					If Not RODUTIL.IsAPI(CInt(iRodGrade), sRodType) Then
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(14)
					ElseIf RODUTIL.IsSinkerBar1(CInt(iRodGrade), sRodType) <> 0 Then
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(13)
					ElseIf bMaxMin Then
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(32)
					Else
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(1)
					End If
				Else
					teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iRodGrade, StdInfoConstants.RodGradeConstants)).RodSizeList
				End If
				RSWIN_DESC.nItems = 0S
				Dim array As String() = New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}
				Dim array2 As String() = New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}
				Try
					For Each obj As Object In teRodSizeList
						Dim dictionaryEntry As DictionaryEntry
						Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
						RSWIN_DESC.nItems += 1S
						array = CType(Utils.CopyArray(CType(array, Array), New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}), String())
						array2 = CType(Utils.CopyArray(CType(array2, Array), New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}), String())
						array(CInt(RSWIN_DESC.nItems)) = Conversions.ToString(teRodSize.Diameter)
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							array2(CInt(RSWIN_DESC.nItems)) = teRodSize.DisplayName
						Else
							array2(CInt(RSWIN_DESC.nItems)) = teRodSize.MetricDisplayName
						End If
						RODUTIL.AddToDiameterArrayList(True, myAL, CInt(RSWIN_DESC.nItems), array2(CInt(RSWIN_DESC.nItems)))
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Sub LoadDiameterList_Old(ByRef myAL As ArrayList, iRodGrade As Short, ByRef sRodType As String, bMaxMin As Boolean)
			Try
				Dim text As String = ""
				Dim text2 As String = ""
				myAL.Clear()
				Dim text3 As String
				If iRodGrade = 20481S Then
					text3 = "RIBBON-ROD"
				ElseIf iRodGrade = 12545S OrElse iRodGrade = 12546S OrElse iRodGrade = 12547S OrElse iRodGrade = 12548S Then
					text3 = "COROD-SE"
				ElseIf iRodGrade = 12801S Then
					text3 = "COROD-D-R"
				ElseIf iRodGrade = 12802S OrElse iRodGrade = 12803S Then
					text3 = "COROD-HS41-R"
				ElseIf iRodGrade = 8195S Then
					text3 = "FLEXBAR-C"
				ElseIf iRodGrade = 8196S Then
					text3 = "FLEXBAR-K"
				ElseIf iRodGrade = 16388S Then
					text3 = "DURAROD"
				ElseIf iRodGrade = 16385S OrElse iRodGrade = 16389S OrElse iRodGrade = 16390S Then
					text3 = "FIBERFLEX"
				ElseIf iRodGrade = 16387S Then
					text3 = "NORRISFG"
				ElseIf iRodGrade = 16386S Then
					text3 = "PETROROD"
				ElseIf iRodGrade = 16391S OrElse iRodGrade = 16395S Then
					text3 = "FIBERCOM"
				ElseIf Not RODUTIL.IsAPI(CInt(iRodGrade), sRodType) Then
					text3 = "STEEL-NONAPI"
				Else
					text3 = "RSSB"
					If RODUTIL.IsSinkerBar1(CInt(iRodGrade), sRodType) <> 0 Then
						text = "RSSB-DIAMS-DEFAULT"
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							text2 = "RSSB-DIAMSTRS-DEFAULT"
						Else
							text2 = "RSSB-DIAMSTRS-DEFAULT-METRIC"
						End If
					ElseIf bMaxMin Then
						text = "RSINPRST-DIAMS-DEFAULT"
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							text2 = "RSINPRST-DIAMSTRS-DEFAULT"
						Else
							text2 = "RSINPRST-DIAMSTRS-DEFAULT-METRIC"
						End If
					Else
						text = "RODSECT-DIAMS-DEFAULT"
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							text2 = "RODSECT-DIAMSTRS-DEFAULT"
						Else
							text2 = "RODSECT-DIAMSTRS-DEFAULT-METRIC"
						End If
					End If
				End If
				If Strings.Len(text3) > 0 Then
					If Strings.Len(text) = 0 Then
						text = "RODSECT-DIAMS-" + text3
					End If
					If Strings.Len(text2) = 0 Then
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							text2 = "RODSECT-DIAMSTRS-" + text3
						Else
							text2 = "RODSECT-DIAMSTRS-" + text3 + "-METRIC"
						End If
					End If
					Dim array As String() = New String(0) {}
					Dim num As Short
					Util.LoadMenu(text, num, array)
					Dim array2 As String() = New String(0) {}
					Util.LoadMenu(text2, num, array2)
					If Strings.InStr(array2(0), "Nominal", CompareMethod.Binary) = 1 Then
						array2(0) = ""
						If Strings.InStr(text2, "METRIC", CompareMethod.Binary) = 0 Then
							Dim num2 As Short = 1S
							Dim num3 As Short = num
							For num4 As Short = num2 To num3
								' The following expression was wrapped in a checked-expression
								array2(CInt(num4)) = Strings.Trim(Strings.Left(array2(CInt(num4)), Strings.InStr(array2(CInt(num4)), "³", CompareMethod.Binary) - 1))
							Next
						Else
							Dim num5 As Short = 1S
							Dim num6 As Short = num
							For num4 As Short = num5 To num6
								' The following expression was wrapped in a checked-statement
								Dim num7 As Short = CShort(Strings.InStr(array2(CInt(num4)), "³", CompareMethod.Binary))
								Dim num8 As Short = CShort(Strings.InStr(array2(CInt(num4)), "(", CompareMethod.Binary))
								array2(CInt(num4)) = Strings.Trim(Strings.Left(array2(CInt(num4)), CInt((num7 - 1S)))) + " " + Strings.Trim(Strings.Mid(array2(CInt(num4)), CInt(num8)))
							Next
						End If
					End If
					myAL.Clear()
					Dim num9 As Short = 1S
					Dim num10 As Short = num
					For num4 As Short = num9 To num10
						' The following expression was wrapped in a checked-statement
						If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
							Dim num8 As Short = CShort(Strings.InStr(array2(CInt(num4)), "(", CompareMethod.Binary))
							If num8 > 0S Then
								Dim num7 As Short
								num7 = num8
								While num7 <> 1S
									If Operators.CompareString(Strings.Mid(array2(CInt(num4)), CInt(num7), 1), " ", False) <> 0 Then
										Exit While
									End If
									num7 -= 1S
								End While
								If Operators.CompareString(Strings.Mid(array2(CInt(num4)), CInt((num8 + 1S)), 1), " ", False) = 0 Then
									num8 += 1S
									StringType.MidStmtStr(array2(CInt(num4)), CInt(num8), 1, "(")
								End If
								array2(CInt(num4)) = Strings.Trim(Strings.Left(array2(CInt(num4)), CInt((num7 - 1S)))) + RSWIN_DESC.Chr9 + Strings.Trim(Strings.Mid(array2(CInt(num4)), CInt(num8)))
							End If
						End If
						If Strings.Asc(array2(CInt(num4))) = 1 Then
							array2(CInt(num4)) = Strings.Mid(array2(CInt(num4)), 3)
						End If
						RODUTIL.AddToDiameterArrayList(True, myAL, CInt(num4), array2(CInt(num4)))
					Next
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub AddToDiameterArrayList(bAdd As Boolean, ByRef myAL As ArrayList, iValue As Integer, sDisplayValue As String)
			Try
				If bAdd Then
					myAL.Add(New cRodSize(iValue, sDisplayValue))
					RODUTIL.$STATIC$AddToDiameterArrayList$0412101281458E$iCount = myAL.Count
				Else
					myAL.Insert(RODUTIL.$STATIC$AddToDiameterArrayList$0412101281458E$iCount, New cRodSize(iValue, sDisplayValue))
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function LoadCustomRodDiameterList(ByRef cboDiameter As ComboBox, iRodGrade As Short, sRodType As String, bMaxMin As Boolean) As Boolean
			Dim result As Boolean
			Try
				Dim text As String = ""
				Dim text2 As String = ""
				cboDiameter.Items.Clear()
				Dim text3 As String
				If iRodGrade = 20481S Then
					text3 = "RIBBON-ROD"
				ElseIf iRodGrade = 12545S OrElse iRodGrade = 12546S OrElse iRodGrade = 12547S OrElse iRodGrade = 12548S Then
					text3 = "COROD-SE"
				ElseIf iRodGrade = 12801S Then
					text3 = "COROD-D-R"
				ElseIf iRodGrade = 12802S OrElse iRodGrade = 12803S Then
					text3 = "COROD-HS41-R"
				ElseIf iRodGrade = 8195S Then
					text3 = "FLEXBAR-C"
				ElseIf iRodGrade = 8196S Then
					text3 = "FLEXBAR-K"
				ElseIf iRodGrade = 16388S Then
					text3 = "DURAROD"
				ElseIf iRodGrade = 16385S OrElse iRodGrade = 16389S OrElse iRodGrade = 16390S Then
					text3 = "FIBERFLEX"
				ElseIf iRodGrade = 16387S Then
					text3 = "NORRISFG"
				ElseIf iRodGrade = 16386S Then
					text3 = "PETROROD"
				ElseIf iRodGrade = 16391S OrElse iRodGrade = 16395S Then
					text3 = "FIBERCOM"
				ElseIf Not RODUTIL.IsAPI(CInt(iRodGrade), sRodType) Then
					text3 = "STEEL-NONAPI"
				Else
					text3 = "RSSB"
					If RODUTIL.IsSinkerBar1(CInt(iRodGrade), sRodType) <> 0 Then
						text = "RSSB-DIAMS-DEFAULT"
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							text2 = "RSSB-DIAMSTRS-DEFAULT"
						Else
							text2 = "RSSB-DIAMSTRS-DEFAULT-METRIC"
						End If
					ElseIf bMaxMin Then
						text = "RSINPRST-DIAMS-DEFAULT"
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							text2 = "RSINPRST-DIAMSTRS-DEFAULT"
						Else
							text2 = "RSINPRST-DIAMSTRS-DEFAULT-METRIC"
						End If
					Else
						text = "RODSECT-DIAMS-DEFAULT"
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							text2 = "RODSECT-DIAMSTRS-DEFAULT"
						Else
							text2 = "RODSECT-DIAMSTRS-DEFAULT-METRIC"
						End If
					End If
				End If
				If Strings.Len(text3) > 0 Then
					If Strings.Len(text) = 0 Then
						text = "RODSECT-DIAMS-" + text3
					End If
					If Strings.Len(text2) = 0 Then
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							text2 = "RODSECT-DIAMSTRS-" + text3
						Else
							text2 = "RODSECT-DIAMSTRS-" + text3 + "-METRIC"
						End If
					End If
					Dim array As String() = New String(0) {}
					Dim num As Short
					Util.LoadMenu(text, num, array)
					Dim array2 As String() = New String(0) {}
					Util.LoadMenu(text2, num, array2)
					If Strings.InStr(array2(0), "Nominal", CompareMethod.Binary) = 1 Then
						array2(0) = ""
						If Strings.InStr(text2, "METRIC", CompareMethod.Binary) = 0 Then
							Dim num2 As Short = 1S
							Dim num3 As Short = num
							For num4 As Short = num2 To num3
								' The following expression was wrapped in a checked-expression
								array2(CInt(num4)) = Strings.Trim(Strings.Left(array2(CInt(num4)), Strings.InStr(array2(CInt(num4)), "³", CompareMethod.Binary) - 1))
							Next
						Else
							Dim num5 As Short = 1S
							Dim num6 As Short = num
							For num4 As Short = num5 To num6
								' The following expression was wrapped in a checked-statement
								Dim num7 As Short = CShort(Strings.InStr(array2(CInt(num4)), "³", CompareMethod.Binary))
								Dim num8 As Short = CShort(Strings.InStr(array2(CInt(num4)), "(", CompareMethod.Binary))
								array2(CInt(num4)) = Strings.Trim(Strings.Left(array2(CInt(num4)), CInt((num7 - 1S)))) + " " + Strings.Trim(Strings.Mid(array2(CInt(num4)), CInt(num8)))
							Next
						End If
					End If
					Dim num9 As Short = 1S
					Dim num10 As Short = num
					For num4 As Short = num9 To num10
						' The following expression was wrapped in a checked-statement
						If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
							Dim num8 As Short = CShort(Strings.InStr(array2(CInt(num4)), "(", CompareMethod.Binary))
							If num8 > 0S Then
								Dim num7 As Short
								num7 = num8
								While num7 <> 1S
									If Operators.CompareString(Strings.Mid(array2(CInt(num4)), CInt(num7), 1), " ", False) <> 0 Then
										Exit While
									End If
									num7 -= 1S
								End While
								If Operators.CompareString(Strings.Mid(array2(CInt(num4)), CInt((num8 + 1S)), 1), " ", False) = 0 Then
									num8 += 1S
									StringType.MidStmtStr(array2(CInt(num4)), CInt(num8), 1, "(")
								End If
								array2(CInt(num4)) = Strings.Trim(Strings.Left(array2(CInt(num4)), CInt((num7 - 1S)))) + RSWIN_DESC.Chr9 + Strings.Trim(Strings.Mid(array2(CInt(num4)), CInt(num8)))
							End If
						End If
						If Strings.Asc(array2(CInt(num4))) = 1 Then
							array2(CInt(num4)) = Strings.Mid(array2(CInt(num4)), 3)
						End If
						RODUTIL.AddItemWithItemData(cboDiameter, array2(CInt(num4)), CInt(num4))
					Next
				End If
				result = True
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Sub AddItemWithItemData(ByRef cbo As ComboBox, item As String, ItemData As Integer)
			Dim comboBox As ComboBox = cbo
			comboBox.Items.Add(New ListBoxItem(item, ItemData))
		End Sub

		Public Function CvtStrDiamToSngl(myStr As String) As Single
			' The following expression was wrapped in a checked-statement
			Dim result As Single
			Try
				Dim text As String = myStr
				If Strings.InStr(myStr, "#", CompareMethod.Binary) > 0 Then
					Dim num As Integer = Strings.InStr(myStr, "#", CompareMethod.Binary)
					myStr = myStr.Substring(num + 3)
				End If
				If Strings.InStr(myStr, RSWIN_DESC.sDblQuote, CompareMethod.Binary) > 0 Then
					Dim num2 As Integer = Strings.InStr(myStr, RSWIN_DESC.sDblQuote, CompareMethod.Binary)
					myStr = myStr.Substring(0, num2 - 1)
				End If
				Dim text2 As String
				If Strings.InStr(myStr, "(", CompareMethod.Binary) > 0 And RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					Dim num3 As Integer = Strings.InStr(myStr, "(", CompareMethod.Binary)
					text2 = myStr.Substring(0, num3 - 1)
					text2 = text2.Trim()
				Else
					text2 = myStr
				End If
				Dim num4 As Single = 0F
				Dim num5 As Single = 0F
				Dim num6 As Single = 0F
				Dim num7 As Integer = -1
				Dim num8 As Integer = -1
				text2 = text2.Trim()
				If Strings.InStr(text2, ".", CompareMethod.Binary) <> 0 Then
					Try
						Return Convert.ToSingle(text2)
					Catch ex As Exception
						If Strings.InStr(text, ".", CompareMethod.Binary) > 0 Then
							Try
								If Strings.InStr(text, "/", CompareMethod.Binary) > 0 Then
									Dim text3 As String = text.Substring(0, Strings.InStr(text, "/", CompareMethod.Binary) - 1)
									Dim text4 As String = text.Substring(Strings.InStr(text, "/", CompareMethod.Binary))
									If Strings.InStr(text4, "(", CompareMethod.Binary) > 0 Then
										text4 = text4.Substring(0, Strings.InStr(text4, "(", CompareMethod.Binary) - 1)
										text4 = text4.Trim()
									End If
									If Strings.InStr(text3, RSWIN_DESC.sDblQuote, CompareMethod.Binary) > 0 Then
										Dim num2 As Integer = Strings.InStr(text3, RSWIN_DESC.sDblQuote, CompareMethod.Binary)
										text3 = text3.Substring(0, num2 - 1)
									End If
									If Strings.InStr(text4, RSWIN_DESC.sDblQuote, CompareMethod.Binary) > 0 Then
										Dim num2 As Integer = Strings.InStr(text4, RSWIN_DESC.sDblQuote, CompareMethod.Binary)
										text4 = text4.Substring(0, num2 - 1)
									End If
									If Versioned.IsNumeric(text3) And Versioned.IsNumeric(text4) Then
										result = Convert.ToSingle(text3) / Convert.ToSingle(text4)
										ProjectData.ClearProjectError()
									End If
								End If
							Catch ex2 As Exception
							End Try
						End If
						Return result
					End Try
				End If
				Dim num9 As Integer = Strings.InStr(text2, ":", CompareMethod.Binary)
				If num9 > 0 Then
					text2 = text2.Substring(num9 + 1)
				End If
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim num10 As Integer = 0
				Dim num11 As Integer = text2.Length - 1
				For i As Integer = num10 To num11
					Dim text5 As String = text2.Substring(i, 1)
					If Operators.CompareString(text5, " ", False) = 0 Then
						flag = True
						num7 = 0
					ElseIf Operators.CompareString(text5, "/", False) = 0 Then
						flag2 = True
						num8 = 0
					ElseIf Versioned.IsNumeric(text5) And Not flag And Not flag2 Then
						If i = 0 Then
							num4 = CSng(Convert.ToInt32(text5))
						Else
							' The following expression was wrapped in a unchecked-expression
							num4 = num4 * 10F + CSng(Convert.ToInt32(text5))
						End If
					ElseIf flag And Not flag2 Then
						If num7 = 0 Then
							num7 += 1
							num5 = CSng(Convert.ToInt32(text5))
						Else
							num7 += 1
							num5 = num5 * 10F + CSng(Convert.ToInt32(text5))
						End If
					ElseIf flag AndAlso flag2 Then
						If num8 = 0 Then
							num8 += 1
							num6 = CSng(Convert.ToInt32(text5))
						Else
							num8 += 1
							num6 = num6 * 10F + CSng(Convert.ToInt32(text5))
						End If
					ElseIf(Versioned.IsNumeric(text5) And Not flag) AndAlso flag2 Then
						If num8 = 0 Then
							num8 += 1
							num6 = CSng(Convert.ToInt32(text5))
						Else
							num8 += 1
							num6 = num6 * 10F + CSng(Convert.ToInt32(text5))
						End If
					End If
				Next
				Dim num12 As Single
				If num5 <> 0F And num6 <> 0F Then
					' The following expression was wrapped in a unchecked-expression
					num12 = num4 + num5 / num6
				ElseIf(num4 <> 0F And num6 <> 0F) AndAlso flag2 Then
					num12 = num4 / num6
				Else
					num12 = num4
				End If
				result = num12
			Catch ex3 As Exception
				Dim text As String
				If Strings.InStr(text, ".", CompareMethod.Binary) > 0 Then
					Try
						If Strings.InStr(text, "/", CompareMethod.Binary) > 0 Then
							Dim text3 As String = text.Substring(0, Strings.InStr(text, "/", CompareMethod.Binary) - 1)
							Dim text4 As String = text.Substring(Strings.InStr(text, "/", CompareMethod.Binary))
							If Strings.InStr(text4, "(", CompareMethod.Binary) > 0 Then
								text4 = text4.Substring(0, Strings.InStr(text4, "(", CompareMethod.Binary) - 1)
								text4 = text4.Trim()
							End If
							If Versioned.IsNumeric(text3) And Versioned.IsNumeric(text4) Then
								result = Convert.ToSingle(text3) / Convert.ToSingle(text4)
								ProjectData.ClearProjectError()
							End If
						End If
					Catch ex4 As Exception
					End Try
				End If
			End Try
			Return result
		End Function

		Public Sub AddToArrayList(bAdd As Boolean, ByRef myAL As ArrayList, iValue As Integer, sDisplayValue As String, iOrder As Integer, sAbbrName As String, sXMLstring As String)
			If bAdd Then
				myAL.Add(New cRodGrade(iValue, sDisplayValue, iOrder, sAbbrName, sXMLstring))
				RODUTIL.$STATIC$AddToArrayList$0712101281458E8EE$iCount = myAL.Count
				Return
			End If
			myAL.Insert(RODUTIL.$STATIC$AddToArrayList$0712101281458E8EE$iCount, New cRodGrade(iValue, sDisplayValue, iOrder, sAbbrName, sXMLstring))
		End Sub

		Public Sub LoadRodGradeList(ByRef cboRGList As ComboBox, iRodMatl As Integer, ByRef myAL As ArrayList, Optional bClearList As Boolean = True, Optional bAssignList As Boolean = True, Optional bAPIOnly As Boolean = False, Optional bUHSOnly As Boolean = False, Optional bOnlyUHSProrod As Boolean = False, Optional bExcludeNorrisDGrade As Boolean = False, Optional bExcludeFiberodCCR As Boolean = False)
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Try
				If bExcludeFiberodCCR Then
					Debug.WriteLine("Exclude Fiberod CCR")
				End If
				Dim obj As Object
				Select Case iRodMatl
					Case 0, 1
						obj = StdInfoConstants.RodMatlConstants.teRodMatlAPISteel
					Case 2
						obj = StdInfoConstants.RodMatlConstants.teRodMatlSinkerBar
					Case 3
						obj = StdInfoConstants.RodMatlConstants.teRodMatlCorod
					Case 4
						obj = StdInfoConstants.RodMatlConstants.teRodMatlFG
					Case 5
						obj = StdInfoConstants.RodMatlConstants.teRodMatlRR
					Case 6
						obj = StdInfoConstants.RodMatlConstants.teRodMatlProrod
				End Select
				Dim teRodGradeList As teRodGradeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().RodGradeLists().Item(RuntimeHelpers.GetObjectValue(obj))
				If bClearList Then
					myAL.Clear()
				End If
				Try
					For Each obj2 As Object In teRodGradeList
						Dim dictionaryEntry As DictionaryEntry
						Dim teRodGrade As teRodGrade = CType(If((obj2 IsNot Nothing), CType(obj2, DictionaryEntry), dictionaryEntry).Value, teRodGrade)
						If Not(LikeOperator.LikeString(teRodGrade.Name, "(Custom *)", CompareMethod.Binary) Or LikeOperator.LikeString(teRodGrade.Name, "(Unknown *)", CompareMethod.Binary)) And Not(Operators.CompareString(teRodGrade.Name, RSWIN_DESC.s_Steel, False) = 0 Or Operators.CompareString(teRodGrade.Name, RSWIN_DESC.s_SinkerBars, False) = 0 Or Operators.CompareString(teRodGrade.Name, RSWIN_DESC.s_Corod, False) = 0 Or Operators.CompareString(teRodGrade.Name, RSWIN_DESC.s_Fiberglass, False) = 0 Or Operators.CompareString(teRodGrade.Name, RSWIN_DESC.s_RibbonRod, False) = 0 Or Operators.CompareString(teRodGrade.Name, RSWIN_DESC.s_Prorod, False) = 0) Then
							If bExcludeFiberodCCR And teRodGrade.RodGradeID = StdInfoConstants.RodGradeConstants.teRodGradeFiberodCCR Then
								Debug.WriteLine("Not adding Fiberod CCR")
							ElseIf bUHSOnly Then
								Dim num3 As Single = RODUTIL.LookupTensileStrength(CSng(teRodGrade.RodGradeID))
								If bOnlyUHSProrod Then
									If teRodGrade.RodGradeID = StdInfoConstants.RodGradeConstants.teRodGradeProRod_960 Or teRodGrade.RodGradeID = StdInfoConstants.RodGradeConstants.teRodGradeProRod_970 Then
										num2 += 1
										RODUTIL.AddToArrayList(True, myAL, CInt(teRodGrade.RodGradeID), teRodGrade.Name, num2, teRodGrade.AbbrName, teRodGrade.XMLstring)
										num = num2
									End If
								ElseIf num3 > 115000F And num3 <= 145000F Then
									RODUTIL.AddToArrayList(True, myAL, CInt(teRodGrade.RodGradeID), teRodGrade.Name, Conversions.ToInteger(teRodGrade.DisplayOrder), teRodGrade.AbbrName, teRodGrade.XMLstring)
									If Operators.ConditionalCompareObjectGreater(teRodGrade.DisplayOrder, num, False) Then
										num = Conversions.ToInteger(teRodGrade.DisplayOrder)
									End If
								ElseIf Not bUHSOnly And Not RODUTIL.IsAPI(CInt(teRodGrade.RodGradeID), RODUTIL.RodGrade(CInt(teRodGrade.RodGradeID))) Then
									RODUTIL.AddToArrayList(True, myAL, CInt(teRodGrade.RodGradeID), teRodGrade.Name, Conversions.ToInteger(teRodGrade.DisplayOrder), teRodGrade.AbbrName, teRodGrade.XMLstring)
									If Operators.ConditionalCompareObjectGreater(teRodGrade.DisplayOrder, num, False) Then
										num = Conversions.ToInteger(teRodGrade.DisplayOrder)
									End If
								End If
							ElseIf Not bAPIOnly And Not bUHSOnly Then
								RODUTIL.AddToArrayList(True, myAL, CInt(teRodGrade.RodGradeID), teRodGrade.Name, Conversions.ToInteger(teRodGrade.DisplayOrder), teRodGrade.AbbrName, teRodGrade.XMLstring)
								If Operators.ConditionalCompareObjectGreater(teRodGrade.DisplayOrder, num, False) Then
									num = Conversions.ToInteger(teRodGrade.DisplayOrder)
								End If
							ElseIf bAPIOnly And RODUTIL.IsAPI(CInt(teRodGrade.RodGradeID), RODUTIL.RodGrade(CInt(teRodGrade.RodGradeID))) Then
								RODUTIL.AddToArrayList(True, myAL, CInt(teRodGrade.RodGradeID), teRodGrade.Name, Conversions.ToInteger(teRodGrade.DisplayOrder), teRodGrade.AbbrName, teRodGrade.XMLstring)
								If Operators.ConditionalCompareObjectGreater(teRodGrade.DisplayOrder, num, False) Then
									num = Conversions.ToInteger(teRodGrade.DisplayOrder)
								End If
							ElseIf bUHSOnly And Not RODUTIL.IsAPI(CInt(teRodGrade.RodGradeID), RODUTIL.RodGrade(CInt(teRodGrade.RodGradeID))) Then
								RODUTIL.AddToArrayList(True, myAL, CInt(teRodGrade.RodGradeID), teRodGrade.Name, Conversions.ToInteger(teRodGrade.DisplayOrder), teRodGrade.AbbrName, teRodGrade.XMLstring)
								If Operators.ConditionalCompareObjectGreater(teRodGrade.DisplayOrder, num, False) Then
									num = Conversions.ToInteger(teRodGrade.DisplayOrder)
								End If
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Dim comparer As RODUTIL.rgaComparer = New RODUTIL.rgaComparer()
				myAL.Sort(comparer)
				If bAssignList Then
					Try
						cboRGList.Items.Clear()
					Catch ex As Exception
					End Try
					Try
						cboRGList.DataSource = Nothing
					Catch ex2 As Exception
					End Try
					cboRGList.DataSource = myAL
					cboRGList.DisplayMember = "DisplayName"
					cboRGList.ValueMember = "RodGradeID"
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub LoadRodGradeList_OLD(ByRef cboRGList As ComboBox, iRodMatl As Integer)
			cboRGList.Items.Clear()
			If iRodMatl = 1 Or iRodMatl = 0 Then
				RODUTIL.AddItemWithItemData(cboRGList, "K (API)", 4097)
				RODUTIL.AddItemWithItemData(cboRGList, "C (API)", 4098)
				RODUTIL.AddItemWithItemData(cboRGList, "D (API)", 4099)
				RODUTIL.AddItemWithItemData(cboRGList, "Axelson S-88", 4105)
				RODUTIL.AddItemWithItemData(cboRGList, "Axelson S-87", 4107)
				RODUTIL.AddItemWithItemData(cboRGList, "Axelson S-67", 4108)
				RODUTIL.AddItemWithItemData(cboRGList, "Axelson S-60", 4109)
				RODUTIL.AddItemWithItemData(cboRGList, "Electra", 4100)
				RODUTIL.AddItemWithItemData(cboRGList, "Highland XD", 4106)
				RODUTIL.AddItemWithItemData(cboRGList, "Norris 96", 4116)
				RODUTIL.AddItemWithItemData(cboRGList, "Norris 97", 4101)
				RODUTIL.AddItemWithItemData(cboRGList, "LTV HS", 4102)
				RODUTIL.AddItemWithItemData(cboRGList, "Tenaris MMS-NR", 4118)
				RODUTIL.AddItemWithItemData(cboRGList, "Tenaris UHS-NR", 4117)
				RODUTIL.AddItemWithItemData(cboRGList, "Tenaris PLUS", 4119)
				RODUTIL.AddItemWithItemData(cboRGList, "Trico 66", 4104)
				RODUTIL.AddItemWithItemData(cboRGList, "UPCO C", 4110)
				RODUTIL.AddItemWithItemData(cboRGList, "UPCO CD", 4111)
				RODUTIL.AddItemWithItemData(cboRGList, "UPCO AD", 4112)
				RODUTIL.AddItemWithItemData(cboRGList, "UPCO KD", 4113)
				RODUTIL.AddItemWithItemData(cboRGList, "UPCO K", 4114)
				RODUTIL.AddItemWithItemData(cboRGList, "UPCO HS", 4115)
			End If
			If iRodMatl = 0 Or iRodMatl = 3 Then
				RODUTIL.AddItemWithItemData(cboRGList, "Corod (round), D", 12801)
				RODUTIL.AddItemWithItemData(cboRGList, "Corod (round), HS41", 12802)
				RODUTIL.AddItemWithItemData(cboRGList, "Corod (round), DE", 12805)
				RODUTIL.AddItemWithItemData(cboRGList, "Corod (round), SE", 12806)
				RODUTIL.AddItemWithItemData(cboRGList, "Corod (semi-el.), C", 12545)
				RODUTIL.AddItemWithItemData(cboRGList, "Corod (semi-el.), D", 12546)
				RODUTIL.AddItemWithItemData(cboRGList, "Corod (semi-el.), HS41", 12547)
				RODUTIL.AddItemWithItemData(cboRGList, "Corod (semi-el.), DE", 12549)
				RODUTIL.AddItemWithItemData(cboRGList, "Corod (semi-el.), SE", 12550)
			End If
			If iRodMatl = 0 Or iRodMatl = 6 Then
				RODUTIL.AddItemWithItemData(cboRGList, RSWIN_DESC.sPROROD620, 24577)
				RODUTIL.AddItemWithItemData(cboRGList, RSWIN_DESC.sPROROD750, 24580)
				RODUTIL.AddItemWithItemData(cboRGList, RSWIN_DESC.sPROROD780, 24579)
				RODUTIL.AddItemWithItemData(cboRGList, RSWIN_DESC.sPROROD790, 24578)
				RODUTIL.AddItemWithItemData(cboRGList, RSWIN_DESC.sPROROD960, 24581)
				RODUTIL.AddItemWithItemData(cboRGList, RSWIN_DESC.sPROROD970, 24582)
			End If
			If iRodMatl = 4 Then
				RODUTIL.AddItemWithItemData(cboRGList, "Fiberflex", 16385)
				RODUTIL.AddItemWithItemData(cboRGList, "PetroRod", 16386)
				RODUTIL.AddItemWithItemData(cboRGList, "Norris FG", 16387)
				RODUTIL.AddItemWithItemData(cboRGList, "Durarod", 16388)
				RODUTIL.AddItemWithItemData(cboRGList, "Fiberod", 16391)
			End If
			If iRodMatl = 5 Then
				RODUTIL.AddItemWithItemData(cboRGList, "Ribbon Rod", 20481)
			End If
			If iRodMatl = 2 Then
				RODUTIL.AddItemWithItemData(cboRGList, "C (API)", 8193)
				RODUTIL.AddItemWithItemData(cboRGList, "C (API, no neck)", 8197)
				RODUTIL.AddItemWithItemData(cboRGList, "K (API)", 8194)
				RODUTIL.AddItemWithItemData(cboRGList, "K (API, no neck)", 8198)
				RODUTIL.AddItemWithItemData(cboRGList, "Flexbar C", 8195)
				RODUTIL.AddItemWithItemData(cboRGList, "Flexbar C (no neck)", 8199)
				RODUTIL.AddItemWithItemData(cboRGList, "Flexbar K", 8196)
				RODUTIL.AddItemWithItemData(cboRGList, "Flexbar K (no neck)", 8200)
				RODUTIL.AddItemWithItemData(cboRGList, "Norris PR Steel", 8301)
				RODUTIL.AddItemWithItemData(cboRGList, "Norris PR Alloy", 8302)
			End If
			If RSWIN_DESC.CustomRodGradeList IsNot Nothing Then
				Dim obj As Object
				Dim obj2 As Object
				If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, Information.UBound(RSWIN_DESC.CustomRodGradeList, 1), 1, obj2, obj) Then
					Do
						If Not RSWIN_DESC.CustomRodGradeList(Conversions.ToInteger(obj)).Steel <> 0S Then
							If iRodMatl = 4 Then
								RODUTIL.AddItemWithItemData(cboRGList, RSWIN_DESC.CustomRodGradeList(Conversions.ToInteger(obj)).RodType, 16384)
							End If
						ElseIf Not RSWIN_DESC.CustomRodGradeList(Conversions.ToInteger(obj)).SinkerBar <> 0S Then
							If iRodMatl = 1 Or iRodMatl = 0 Then
								RODUTIL.AddItemWithItemData(cboRGList, RSWIN_DESC.CustomRodGradeList(Conversions.ToInteger(obj)).RodType, 4096)
							End If
						ElseIf iRodMatl = 2 Then
							RODUTIL.AddItemWithItemData(cboRGList, RSWIN_DESC.CustomRodGradeList(Conversions.ToInteger(obj)).RodType, 4096)
						End If
					Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj2, obj)
				End If
				Return
			End If
		End Sub

		Public Function ConvertRodGrade(ByRef tSection As RSWIN_DESC.RodSection) As Integer
			Dim num As Integer
			Try
				num = -1
				Dim num2 As Single = tSection.Diameter
				Dim num3 As Single = tSection.SuckerRodLength
				Dim num4 As Integer = CInt(tSection.Grade)
				Dim num5 As Integer = num4
				If num5 = 10 Then
					num4 = 8195
				ElseIf num5 = 11 Then
					num4 = 8196
				ElseIf num5 = 12 Then
					num4 = 20481
				ElseIf num5 = 100 Then
					num4 = 12545
				ElseIf num5 = 101 Then
					num4 = 12546
				ElseIf num5 = 102 Then
					num4 = 12547
				ElseIf num5 = 106 Then
					num4 = 12550
				ElseIf num5 = 12548 Then
					num4 = 12550
				ElseIf num5 = 103 Then
					num4 = 12801
				ElseIf num5 = 104 Then
					num4 = 12802
				ElseIf num5 = 107 Then
					num4 = 12806
				ElseIf num5 = 12803 Then
					num4 = 12806
				ElseIf num5 = 105 OrElse num5 = 13057 Then
					num4 = 12546
					Dim num6 As Double = CDbl((num2 * num2)) * Math.Atan(1.0)
					If num6 < 0.7 Then
						num2 = 0.9375F
					Else
						num2 = 1F
					End If
				ElseIf num5 = 0 Then
					num4 = 16384
				ElseIf num5 = -1 OrElse num5 = 16390 OrElse num5 = 16389 Then
					num4 = 16385
					num3 = 37.5F
					If CDbl(num2) < 1.18 Then
						num2 = 1.24F
					End If
				ElseIf num5 = -2 Then
					num4 = 16386
				ElseIf num5 = -3 Then
					num4 = 16387
				ElseIf num5 = -4 Then
					num4 = 16388
				ElseIf num5 = 1 Then
					If CDbl(num2) < 1.25 Then
						num4 = 4097
					Else
						num4 = 8194
					End If
				ElseIf num5 = 2 Then
					If CDbl(num2) < 1.25 Then
						num4 = 4098
					Else
						num4 = 8193
					End If
				ElseIf num5 = 3 Then
					num4 = 4099
				ElseIf num5 = 4 Then
					num4 = 4100
				ElseIf num5 = 5 Then
					num4 = 4101
				ElseIf num5 = 6 Then
					num4 = 4102
				ElseIf num5 = 7 OrElse num5 = 4103 Then
					num4 = 4115
				ElseIf num5 = 8 Then
					num4 = 4104
				ElseIf num5 = 9 Then
					num4 = 4105
				ElseIf num5 = 32767 Then
					num4 = 4096
				ElseIf num5 = 16385 OrElse num5 = 16389 OrElse num5 = 16385 Then
					num = 0
					If 1.17 < CDbl(num2) And CDbl(num2) < 1.18 Then
						num2 = 1.24F
						num = -1
					End If
					If CDbl(num3) <> 37.5 Then
						num3 = 37.5F
						num = -1
					End If
				Else
					num = 0
				End If
				If num <> 0 Then
					tSection.Grade = CShort(num4)
					tSection.Diameter = num2
					tSection.Area = CSng((CDbl((num2 * num2)) * Math.Atan(1.0)))
					RODUTIL.LookupElasticity(tSection)
					RODUTIL.LookupRodWeight(tSection)
					RODUTIL.LookupTensileStrength(tSection)
					tSection.StressMethod = CShort(RODUTIL.LookupStressMethod(tSection))
					If num4 = 20481 Then
						tSection.RodDensity = 100F
					ElseIf num4 = 16393 Then
						tSection.RodDensity = 125F
					ElseIf RODUTIL.IsFG(CShort(num4)) Then
						tSection.RodDensity = 130F
					Else
						tSection.RodDensity = 491F
					End If
					If num4 <> 4096 Then
						tSection.RodType = RODUTIL.RodGrade(num4)
					End If
					tSection.SuckerRodLength = num3
					If Not CUSTOMRG.IsOtherSteel(num4) Then
						tSection.RodType = RODUTIL.RodGrade(num4)
					End If
				End If
			Catch ex As Exception
			End Try
			Return num
		End Function

		Public Function GetCustomRodTypeName(iRodGrade As Short) As Object
			Dim flag As Boolean = False
			Dim text As String = ""
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim obj As Object = 0
			Dim result As Object
			Try
				Dim num3 As Integer = 1
				Dim num4 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
				For i As Integer = num3 To num4
					If Not RSWIN_DESC.CustomRodGradeList(i).Steel <> 0S Then
						num += 1
						If CInt(iRodGrade) = 16397 + num Then
							text = RSWIN_DESC.CustomRodGradeList(i).RodType
							flag = True
							Exit For
						End If
					ElseIf RSWIN_DESC.CustomRodGradeList(i).Steel <> 0S Then
						If Not RSWIN_DESC.CustomRodGradeList(i).SinkerBar <> 0S Then
							num2 += 1
							If CInt(iRodGrade) = 4143 + num2 Then
								text = RSWIN_DESC.CustomRodGradeList(i).RodType
								flag = True
								Exit For
							End If
						ElseIf RSWIN_DESC.CustomRodGradeList(i).SinkerBar <> 0S Then
							obj = Operators.AddObject(obj, 1)
							If Operators.ConditionalCompareObjectEqual(iRodGrade, Operators.AddObject(8311, obj), False) Then
								text = RSWIN_DESC.CustomRodGradeList(i).RodType
								flag = True
								Exit For
							End If
						End If
					End If
				Next
				If flag Then
					result = text
				Else
					result = ""
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetRodGradeName(I As Integer) As Object
			Dim text As String = ""
			Dim result As Object
			Try
				Dim grade As Short = RSWIN_DESC.rst.Sections(I).Grade
				If CUSTOMRG.IsOtherSteel(CInt(grade)) Or CUSTOMRG.IsOtherFG(CInt(grade)) Or CUSTOMRG.IsOtherSinkerBar(CInt(grade)) Then
					If CUSTOMRG.IsOtherFG(CInt(grade)) Then
						Dim iRodGrade As Integer = CInt(grade)
						Dim num As Single = 0F
						text = RODUTIL.GetOtherFG(iRodGrade, num)
					ElseIf CUSTOMRG.IsOtherSinkerBar(CInt(grade)) Then
						Dim iRodGrade2 As Integer = CInt(grade)
						Dim num As Single = 0F
						text = RODUTIL.GetOtherSinkerbar(iRodGrade2, num)
					ElseIf CUSTOMRG.IsOtherSteel(CInt(grade)) Then
						Dim iRodGrade3 As Integer = CInt(grade)
						Dim num As Single = 0F
						text = RODUTIL.GetOtherSteel(iRodGrade3, num)
					End If
				ElseIf RODUTIL.IsCorodH(grade) Then
					If CDbl(RSWIN_DESC.rst.Sections(I).Area) < 0.7 Then
						text += " 682"
					Else
						text += " 757"
					End If
				Else
					text = RODUTIL.RodGrade(grade)
				End If
				result = text
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function

		Public Function FindRodGrade(ByRef RGList As ComboBox, iRodGrade As Short, Optional sRodType As String = Nothing) As Short
			Dim result As Short = -1S
			Dim comboBox As ComboBox = RGList
			Dim num As Short = 0S
			Dim num2 As Short = CShort((comboBox.Items.Count - 1))
			For num3 As Short = num To num2
				If RODUTIL.ConvertListIndexToRodGrade(RGList, CInt(num3)) = CInt(iRodGrade) Then
					result = num3
					Exit For
				End If
			Next
			Return result
		End Function

		Public Function SetGuruRodDiameter(iRodGrade As Integer, fRodDiameter As Single) As Single
			Dim array As Single() = New Single(0) {}
			Dim num As Integer = -1
			Dim flag As Boolean = False
			Dim result As Single
			Try
				Dim rodSizeList As teRodSizeList
				Try
					rodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iRodGrade, StdInfoConstants.RodGradeConstants)).RodSizeList
				Catch ex As Exception
				End Try
				Dim num2 As Single
				Try
					For Each obj As Object In rodSizeList
						Dim dictionaryEntry As DictionaryEntry
						Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
						num2 = teRodSize.Diameter
						num += 1
						array = CType(Utils.CopyArray(CType(array, Array), New Single(num + 1 - 1) {}), Single())
						array(num) = num2
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Try
					Array.Sort(Of Single)(array)
				Catch ex2 As Exception
				End Try
				Dim num3 As Integer = Information.LBound(array, 1)
				Dim num4 As Integer = Information.UBound(array, 1)
				Dim num5 As Single
				For i As Integer = num3 To num4
					num2 = array(i)
					If num2 >= fRodDiameter Then
						num5 = num2
						flag = True
						Exit For
					End If
				Next
				If Not flag Then
					num5 = num2
				End If
				result = num5
			Catch ex3 As Exception
			End Try
			Return result
		End Function

		Public Sub CheckSuckerRodLength(ByRef sect As RSWIN_DESC.RodSection, Optional bCheck As Boolean = False)
			Try
				If sect.SuckerRodLength = 0F OrElse bCheck Then
					If(If((-If((RODUTIL.IsCorod(sect.Grade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(sect.Grade))) <> 0 Then
						sect.SuckerRodLength = 1F
					ElseIf(RODUTIL.IsSteel(CInt(sect.Grade)) Or If((-If((CUSTOMRG.IsOtherSteel(CInt(sect.Grade)) > False), 1, 0)), 1, 0)) <> 0 Then
						sect.SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
					ElseIf RODUTIL.IsFG(sect.Grade) Or CUSTOMRG.IsOtherFG(CInt(sect.Grade)) Then
						sect.SuckerRodLength = 37.5F
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Function GetNextLargestDiameter(nDiams As Integer, diams As Single()) As Single
			' The following expression was wrapped in a checked-statement
			Dim result As Single
			Try
				Dim num As Integer = -1
				Dim num2 As Single = RSWIN_DESC.rst.RSMinSize
				For i As Integer = 1 To nDiams
					If diams(i) > RSWIN_DESC.rst.RSMinSize Then
						num = i
					End If
				Next
				If num <> -1 AndAlso diams(num) >= num2 Then
					num2 = diams(num)
				End If
				result = num2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub TryLargerHSDiameter(ByRef iNum As Integer, ByRef iHS As Integer(), bWriteDebugLines As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				Dim flag As Boolean = True
				Dim flag2 As Boolean = False
				Dim num7 As Integer = 0
				Dim bCheckToAdd As Boolean = False
				Dim flag3 As Boolean = False
				Dim num8 As Single
				Dim text As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num8, bCheckToAdd, flag2, flag3, False, False)
				If num2 < 99 Then
					flag = True
				End If
				While flag
					num7 += 1
					Dim num9 As Integer = 1
					Dim num10 As Integer = iNum
					For i As Integer = num9 To num10
						Dim diameter As Single = RSWIN_DESC.rst.Sections(iHS(i)).Diameter
						Dim rsmaxSize As Single = RSWIN_DESC.rst.RSMaxSize
						Dim num11 As Integer
						Dim num12 As Integer
						Dim array As Single()
						Dim num13 As Single
						Dim flag4 As Boolean = RODUTIL.GetHSDiams(RSWIN_DESC.rst.Sections(iHS(i)).Grade, RSWIN_DESC.rst.Sections(iHS(i)).Diameter, num11, num12, array, num13)
						If num12 - num11 > 0 Then
							num11 -= 1
							Dim quiet As Object = True
							Dim grade As Object = RSWIN_DESC.rst.Sections(iHS(i)).Grade
							Dim diameter2 As Object = array(num11)
							Dim flag5 As Boolean
							Dim obj As Object = flag5
							Dim obj2 As Object = 0
							Dim obj3 As Object = RSWIN_DESC.sNull
							Dim flag6 As Boolean
							Dim obj4 As Object = flag6
							RODUTIL.CheckRodsInTubing(quiet, grade, diameter2, obj, obj2, obj3, obj4, iHS(i))
							flag6 = Conversions.ToBoolean(obj4)
							RSWIN_DESC.sNull = Conversions.ToString(obj3)
							flag5 = Conversions.ToBoolean(obj)
							If flag5 AndAlso RSWIN_DESC.rst.RSMaxSize < array(num11) Then
								RSWIN_DESC.rst.RSMaxSize = array(num11)
								RSWIN_DESC.rst.RSMinSize = RODUTIL.GetNextLargestDiameter(num12, array)
								If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Not RSWIN_DESC.SETUP_UseXRODVTubingSizes Then
									Dim maxCasingSize As Single = RSWIN_DESC.MaxCasingSize
									Dim maxTubingSizeOD As Single = RSWIN_DESC.MaxTubingSizeOD
									Dim num14 As Single
									Dim num15 As Single
									Dim num16 As Single
									RODUTIL.GetSizeFromCasingSize(maxCasingSize, maxTubingSizeOD, num14, num15, num16, False)
									RSWIN_DESC.MaxTubingSizeOD = maxTubingSizeOD
									If RSWIN_DESC.rst.RSMaxSize > num14 Then
										RSWIN_DESC.rst.RSMaxSize = num14
									End If
									If RSWIN_DESC.rst.RSMinSize > num14 Then
										RSWIN_DESC.rst.RSMinSize = num14
									End If
								End If
							End If
							If array(num11) <> 0F Then
								RSWIN_DESC.rst.Sections(iHS(i)).Diameter = array(num11)
							End If
						Else
							flag4 = RODUTIL.TryLargerTubingDiameter()
							If flag4 Then
								Dim quiet2 As Object = True
								Dim grade2 As Object = RSWIN_DESC.rst.Sections(iHS(i)).Grade
								Dim diameter3 As Object = array(num11)
								Dim flag5 As Boolean
								Dim obj4 As Object = flag5
								Dim obj3 As Object = 0
								Dim obj2 As Object = RSWIN_DESC.sNull
								Dim flag6 As Boolean
								Dim obj As Object = flag6
								RODUTIL.CheckRodsInTubing(quiet2, grade2, diameter3, obj4, obj3, obj2, obj, iHS(i))
								flag6 = Conversions.ToBoolean(obj)
								RSWIN_DESC.sNull = Conversions.ToString(obj2)
								flag5 = Conversions.ToBoolean(obj4)
								If flag5 AndAlso RSWIN_DESC.rst.RSMaxSize < array(num11) Then
									RSWIN_DESC.rst.RSMaxSize = array(num11)
									RSWIN_DESC.rst.RSMinSize = RODUTIL.GetNextLargestDiameter(num12, array)
									If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Not RSWIN_DESC.SETUP_UseXRODVTubingSizes Then
										Dim maxCasingSize2 As Single = RSWIN_DESC.MaxCasingSize
										Dim maxTubingSizeOD As Single = RSWIN_DESC.MaxTubingSizeOD
										Dim num14 As Single
										Dim num15 As Single
										Dim num16 As Single
										RODUTIL.GetSizeFromCasingSize(maxCasingSize2, maxTubingSizeOD, num14, num15, num16, False)
										RSWIN_DESC.MaxTubingSizeOD = maxTubingSizeOD
										If RSWIN_DESC.rst.RSMaxSize > num14 Then
											RSWIN_DESC.rst.RSMaxSize = num14
										End If
										If RSWIN_DESC.rst.RSMinSize > num14 Then
											RSWIN_DESC.rst.RSMinSize = num14
										End If
									End If
									If array(num11) <> 0F Then
										RSWIN_DESC.rst.Sections(iHS(i)).Diameter = array(num11)
									End If
								End If
							End If
						End If
						Debug.WriteLine("Was = " + Conversions.ToString(diameter) + " , now = " + Conversions.ToString(RSWIN_DESC.rst.Sections(iHS(i)).Diameter))
					Next
					Dim flag7 As Boolean = DESIGN.Design()
					Dim bCheckToAdd2 As Boolean = False
					flag3 = False
					Dim num17 As Single
					text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num17, bCheckToAdd2, flag2, flag3, False, False)
					Dim num18 As Single = 0F
					iNum = 0
					Dim num19 As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num19 To numRods
						If(RSWIN_DESC.rst.Sections(i).TensileStrength > 115000F And RSWIN_DESC.rst.Sections(i).TensileStrength <= 145000F) AndAlso RSWIN_DESC.rst.StressL(i) > num18 Then
							num18 = RSWIN_DESC.rst.StressL(i)
							iNum += 1
							iHS(iNum) = i
						End If
					Next
					flag = (num18 > 1F And num7 < 8)
				End While
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetHSDiams(iRSGrade As Short, fDiameter As Single, ByRef iDiam As Integer, ByRef nDiams As Integer, ByRef diams As Single(), ByRef fMaxSize As Single) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim rodSizeList As teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iRSGrade, StdInfoConstants.RodGradeConstants)).RodSizeList
				nDiams = 0
				Try
					For Each obj As Object In rodSizeList
						Dim dictionaryEntry As DictionaryEntry
						Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
						nDiams += 1
						diams = CType(Utils.CopyArray(CType(diams, Array), New Single(nDiams + 1 - 1) {}), Single())
						diams(nDiams) = teRodSize.Diameter
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				fMaxSize = diams(1)
				Dim flag As Boolean
				If fDiameter < fMaxSize Then
					iDiam = 0
					Dim num As Integer = 1
					Dim num2 As Integer = nDiams
					For i As Integer = num To num2
						If fDiameter = diams(i) Then
							iDiam = i
							Exit For
						End If
						If fDiameter < diams(i) Then
							iDiam = i
						End If
					Next
					flag = True
				Else
					flag = False
				End If
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetSmallerTubingDiameter(ByRef fTubingOD As Single, ByRef fTubingID As Single) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim array As String() = New String(0) {}
				Dim array2 As String() = New String(0) {}
				Dim flag As Boolean = False
				Dim sMenu As String = "TUBING-ID"
				Dim num2 As Integer
				Dim num As Short = CShort(num2)
				Util.LoadMenu(sMenu, num, array2)
				num2 = CInt(num)
				Dim sMenu2 As String = "TUBING-OD"
				num = CShort(num2)
				Util.LoadMenu(sMenu2, num, array)
				num2 = CInt(num)
				fTubingOD = -1F
				fTubingID = -1F
				For i As Integer = num2 To 1 Step -1
					If Convert.ToSingle(array(i)) < RSWIN_DESC.rst.TubingOD Then
						fTubingOD = Convert.ToSingle(array(i))
						fTubingID = Convert.ToSingle(array2(i))
						If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso (Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.MaxTubingSizeOD <> 0F) AndAlso fTubingOD > RSWIN_DESC.MaxTubingSizeOD Then
							fTubingOD = RSWIN_DESC.MaxTubingSizeOD
							fTubingID = RODUTIL.GetMaxTubingSizeID(fTubingOD)
						End If
						flag = True
						Exit For
					End If
				Next
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetLargerTubingDiameter(ByRef fTubingOD As Single, ByRef fTubingID As Single) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim array As String() = New String(0) {}
				Dim array2 As String() = New String(0) {}
				Dim flag As Boolean = False
				Dim sMenu As String = "TUBING-ID"
				Dim num2 As Integer
				Dim num As Short = CShort(num2)
				Util.LoadMenu(sMenu, num, array2)
				num2 = CInt(num)
				Dim sMenu2 As String = "TUBING-OD"
				num = CShort(num2)
				Util.LoadMenu(sMenu2, num, array)
				num2 = CInt(num)
				fTubingOD = -1F
				fTubingID = -1F
				For i As Integer = num2 To 1 Step -1
					If Convert.ToSingle(array(i)) > RSWIN_DESC.rst.TubingOD Then
						fTubingOD = Convert.ToSingle(array(i))
						fTubingID = Convert.ToSingle(array2(i))
						If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso (Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.MaxTubingSizeOD <> 0F) AndAlso fTubingOD > RSWIN_DESC.MaxTubingSizeOD Then
							fTubingOD = RSWIN_DESC.MaxTubingSizeOD
							fTubingID = RODUTIL.GetMaxTubingSizeID(fTubingOD)
						End If
						flag = True
						Exit For
					End If
				Next
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function TryLargerTubingDiameter() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim array As String() = New String(0) {}
				Dim array2 As String() = New String(0) {}
				Dim flag As Boolean = False
				Dim sMenu As String = "TUBING-ID"
				Dim num2 As Integer
				Dim num As Short = CShort(num2)
				Util.LoadMenu(sMenu, num, array2)
				num2 = CInt(num)
				Dim sMenu2 As String = "TUBING-OD"
				num = CShort(num2)
				Util.LoadMenu(sMenu2, num, array)
				num2 = CInt(num)
				Dim num3 As Integer = 1
				Dim num4 As Integer = num2
				For i As Integer = num3 To num4
					If Convert.ToSingle(array(i)) > RSWIN_DESC.rst.TubingOD Then
						RSWIN_DESC.rst.TubingOD = Convert.ToSingle(array(i))
						RSWIN_DESC.rst.TubingID = Convert.ToSingle(array2(i))
						If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso (Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.MaxTubingSizeOD <> 0F) AndAlso RSWIN_DESC.rst.TubingOD > RSWIN_DESC.MaxTubingSizeOD Then
							RSWIN_DESC.rst.TubingOD = RSWIN_DESC.MaxTubingSizeOD
							RSWIN_DESC.rst.TubingID = RODUTIL.GetMaxTubingSizeID(RSWIN_DESC.rst.TubingOD)
						End If
						flag = True
						Exit For
					End If
				Next
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function CheckForOverloadedRods() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If CDbl(RSWIN_DESC.rst.StressL(i)) > 0.95 Then
						flag = True
						Exit For
					End If
				Next
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function GetMaxTubingSizeID(fOD As Single) As Single
			' The following expression was wrapped in a checked-statement
			Dim result As Single
			Try
				Dim array As String() = New String(0) {}
				Dim array2 As String() = New String(0) {}
				Dim num As Single = 0F
				Dim sMenu As String = "TUBING-OD"
				Dim num3 As Integer
				Dim num2 As Short = CShort(num3)
				Util.LoadMenu(sMenu, num2, array)
				num3 = CInt(num2)
				Dim sMenu2 As String = "TUBING-ID"
				Dim num4 As Integer
				num2 = CShort(num4)
				Util.LoadMenu(sMenu2, num2, array2)
				num4 = CInt(num2)
				Dim num5 As Integer = Information.LBound(array, 1)
				Dim num6 As Integer = Information.UBound(array, 1)
				Dim num7 As Integer = num5
				Dim num8 As Integer = num6
				For i As Integer = num7 To num8
					' The following expression was wrapped in a unchecked-expression
					If Versioned.IsNumeric(array(i)) AndAlso Math.Abs(CDbl(RSWIN_DESC.rst.TubingOD) - Conversion.Val(array(i))) < 1E-06 Then
						num = CSng(Conversion.Val(array2(i)))
						Exit For
					End If
				Next
				result = num
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub GetSizeFromCasingSize(fCasingSize As Single, ByRef fMaxTubingSize As Single, ByRef fRodSize As Single, ByRef fMaxPumpSize As Single, ByRef fMaxSinkerbarDiam As Single, bUseOnlyCasingSize As Boolean)
			Try
				Dim num As Single
				Dim num2 As Single
				If bUseOnlyCasingSize Then
					If fCasingSize = 2.875F Then
						fMaxTubingSize = 1.9F
						fRodSize = 0.625F
						num = 1.25F
						num2 = 1.5F
						fMaxSinkerbarDiam = 1.125F
					ElseIf fCasingSize = 3.5F Then
						fMaxTubingSize = 2.0625F
						fRodSize = 0.75F
						num = 1.25F
						num2 = 1.5F
						fMaxSinkerbarDiam = 1.25F
					ElseIf fCasingSize = 4F Then
						fMaxTubingSize = 2.375F
						fRodSize = 0.875F
						num = 1.5F
						num2 = 1.75F
						fMaxSinkerbarDiam = 1.5F
					ElseIf fCasingSize = 4.5F Then
						fMaxTubingSize = 2.875F
						fRodSize = 1F
						num = 2F
						num2 = 2.25F
						fMaxSinkerbarDiam = 1.65F
					ElseIf fCasingSize = 5F Then
						fMaxTubingSize = 2.875F
						fRodSize = 1F
						num = 2F
						num2 = 2.25F
						fMaxSinkerbarDiam = 1.65F
					ElseIf fCasingSize = 5.5F OrElse fCasingSize = 6.625F Then
						fMaxTubingSize = 3.5F
						fRodSize = 1.25F
						num = 2.5F
						num2 = 2.75F
						fMaxSinkerbarDiam = 2F
					ElseIf fCasingSize = 7F Then
						fMaxTubingSize = 4.5F
						fRodSize = 1.25F
						num = 3.25F
						num2 = 3.75F
						fMaxSinkerbarDiam = 2F
					ElseIf fCasingSize = 7.625F Then
						fMaxTubingSize = 4.5F
						fRodSize = 1.25F
						num = 3.25F
						num2 = 3.75F
						fMaxSinkerbarDiam = 2F
					End If
				Else
					Dim flag As Boolean = True
					If flag = CDbl(fMaxTubingSize) <= 1.9 Then
						fRodSize = 0.625F
						num = 1.25F
						num2 = 1.5F
						fMaxSinkerbarDiam = 1.25F
					ElseIf flag = (CDbl(fMaxTubingSize) = 2.0625) Then
						fRodSize = 0.75F
						num = 1.25F
						num2 = 1.5F
						fMaxSinkerbarDiam = 1.5F
					ElseIf flag = (CDbl(fMaxTubingSize) = 2.375) Then
						fRodSize = 0.875F
						num = 1.5F
						num2 = 1.75F
						fMaxSinkerbarDiam = 1.5F
					ElseIf flag = (CDbl(fCasingSize) = 4.5 And CDbl(fMaxTubingSize) = 2.875) Then
						fRodSize = 1F
						num = 2F
						num2 = 2.25F
						fMaxSinkerbarDiam = 1.5F
					ElseIf flag = (CDbl(fMaxTubingSize) = 2.875) Then
						fRodSize = 1F
						num = 2F
						num2 = 2.25F
						fMaxSinkerbarDiam = 1.65F
					ElseIf flag = (CDbl(fMaxTubingSize) = 3.5) Then
						fRodSize = 1.25F
						num = 2.5F
						num2 = 2.75F
						fMaxSinkerbarDiam = 2F
					ElseIf flag = (fCasingSize = 7F And CDbl(fMaxTubingSize) = 4.5) Then
						fRodSize = 1.25F
						num = 3.25F
						num2 = 3.75F
						fMaxSinkerbarDiam = 2F
					ElseIf flag = (CDbl(fMaxTubingSize) = 4.5) OrElse flag = (fMaxTubingSize = 4F) Then
						fRodSize = 1.25F
						num = 3.25F
						num2 = 3.75F
						fMaxSinkerbarDiam = 2F
					End If
				End If
				If RSWIN_DESC.rst.PumpType = 1S Then
					fMaxPumpSize = num
				ElseIf RSWIN_DESC.rst.PumpType = 2S Then
					fMaxPumpSize = num2
				ElseIf RSWIN_DESC.rst.PumpType = 3S Then
					fMaxPumpSize = num
				Else
					fMaxPumpSize = num
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetFricCoeff(iGuide As Integer, Optional fReduce As Boolean = True) As Single
			Dim result As Single
			Try
				If RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = 0F Then
					Dim text As String = "BareRodFricCoeff"
					Dim num As Single = 0.2F
					RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, num))
					text = "MoldedFricCoeff"
					RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fDefaultFricCoeff))
					text = "WheelFricCoeff"
					RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fDefaultFricCoeff))
					text = "OtherFricCoeff"
					RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fDefaultFricCoeff))
					text = "NorrisStandardGuideFricCoeff"
					RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text = "NorrisSidewinderGuideFricCoeff"
					RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text = "RGIJakeCouplingGuideFricCoeff"
					RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text = "RGISVTGuideFricCoeff"
					RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text = "RGITomahawkGuideFricCoeff"
					RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text = "RGITornadoGuideFricCoeff"
					RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text = "RGITwisterGuideFricCoeff"
					RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text = "RGIWVTGuideFricCoeff"
					RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, RSWIN_DESC.fNorrisDefaultFricCoeff))
				End If
				Dim num2 As Single
				If iGuide = 0 Then
					num2 = RSWIN_DESC.SETUP_BAREROD_FRICCOEFF
				ElseIf iGuide = CInt(RSWIN_DESC.MOLDED) Then
					num2 = RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF
				ElseIf iGuide = 2 Then
					num2 = RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF
				ElseIf iGuide = 3 Then
					num2 = RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF
				ElseIf iGuide = 4 Then
					num2 = RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF
				ElseIf iGuide = CInt(RSWIN_DESC.NorrisSidewinderGuide) Then
					num2 = RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF
				ElseIf iGuide = 6 Then
					num2 = RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF
				ElseIf iGuide = 7 Then
					num2 = RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF
				ElseIf iGuide = 8 Then
					num2 = RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF
				ElseIf iGuide = 9 Then
					num2 = RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF
				ElseIf iGuide = 10 Then
					num2 = RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF
				ElseIf iGuide = 11 Then
					num2 = RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF
				End If
				If num2 = 0F Then
					num2 = 0.2F
				End If
				If(Util.IsPolyLined(RSWIN_DESC.rst.TubingID) And RSWIN_DESC.bReduceFricCoeff) AndAlso fReduce Then
					num2 /= 2F
				End If
				result = num2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Const sWa As String = "WARNING: A "

		Private Const stl As String = "is too large for the "

		Private Const srq As String = "requires slimhole couplings to fit in the "

		Private Const styhs As String = "tubing you have selected."

		Private Const sptyhs As String = "polylined tubing you have selected."

		Private Const sSteel As String = "steel "

		Private Const sFGlass As String = "fiberglass "

		Private Const sSinkerBar As String = "sinker bar "

		Private Const sRodSection As String = "rod section "

		Private $STATIC$GetAPITable$031101DC1CC$dp As Single()

		Private $STATIC$AddToDiameterArrayList$0412101281458E$iCount As Integer

		Private $STATIC$AddToArrayList$0712101281458E8EE$iCount As Integer

		Private $STATIC$StdMotorSize$01CC$nSizes As Short

		Private $STATIC$StdMotorSize$01CC$bInitialized As Short

		Private $STATIC$StdMotorSize$01CC$afMotorSizes As Single()

		Public Structure RodGradeArray
			Public RodGradeID As Integer

			Public DisplayName As String

			Public DisplayOrder As Integer
		End Structure

		Public Class rgaComparer
			Implements IComparer

			Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
				Dim result As Integer
				Try
					Dim num As Integer = New CaseInsensitiveComparer().Compare(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(x, Nothing, "DisplayOrder", New Object(-1) {}, Nothing, Nothing, Nothing)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(y, Nothing, "DisplayOrder", New Object(-1) {}, Nothing, Nothing, Nothing)))
					result = num
				Catch ex As Exception
				End Try
				Return result
			End Function
		End Class
	End Module
End Namespace
