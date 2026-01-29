Imports System
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module APIROD
		Private Function Fcc(A As Object, VA1 As Object, VA2 As Object, VA0 As Object, L1 As Object, L2 As Object, FCO As Object) As Single
			Dim num As Single = CSng((2.0 * Math.Atan(1.0)))
			Return Conversions.ToSingle(Operators.SubtractObject(1, Operators.MultiplyObject(Operators.MultiplyObject(A, Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject(num, VA0), VA2), L2), FCO)))), Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject(num, VA0), VA1), L1), FCO))))))
		End Function

		Public Sub FcFG(ByRef Sections As RSWIN_DESC.RodSection(), FGRod As Short, PercentFG As Object, ByRef Fc As Object)
			Dim array As Single()
			Dim num As Single
			Dim num2 As Single
			Dim num3 As Single
			array = New Single(CInt((FGRod + 1S + 1S)) - 1) {}
			array(CInt(FGRod)) = 12F / Sections(CInt(FGRod)).Elasticity / Sections(CInt(FGRod)).Area
			array(CInt((FGRod + 1S))) = 12F / Sections(CInt((FGRod + 1S))).Elasticity / Sections(CInt((FGRod + 1S))).Area
			num = CSng(Math.Sqrt(386.4 / CDbl(array(CInt(FGRod))) / CDbl(Sections(CInt(FGRod)).RodWeight)))
			num2 = CSng(Math.Sqrt(386.4 / CDbl(array(CInt((FGRod + 1S)))) / CDbl(Sections(CInt((FGRod + 1S))).RodWeight)))
			num3 = Conversions.ToSingle(PercentFG)
			Dim num4 As Single = 1F - num3
			Dim num5 As Single = num3 * array(CInt(FGRod)) + num4 * array(CInt((FGRod + 1S)))
			Dim num6 As Single = num3 * Sections(CInt(FGRod)).RodWeight + num4 * Sections(CInt((FGRod + 1S))).RodWeight
			Dim num7 As Single = CSng(Math.Sqrt(386.4 / CDbl(num5) / CDbl(num6)))
			Dim num8 As Single = array(CInt(FGRod)) * num / (array(CInt((FGRod + 1S))) * num2)
			Dim num9 As Single = 0F
			Dim num10 As Single
			Dim num11 As Single
			Dim num12 As Single
			Dim num13 As Single
			Dim num14 As Single
			Dim num15 As Single
			Do
				num9 = CSng((CDbl(num9) + 0.1))
				num10 = 1F + num9
				num11 = 1F
				num12 = 1F - num9
				num13 = APIROD.Fcc(num8, num, num2, num7, num3, num4, num10)
				num14 = APIROD.Fcc(num8, num, num2, num7, num3, num4, 1F)
				num15 = APIROD.Fcc(num8, num, num2, num7, num3, num4, num12)
			Loop While Not(num13 > 0F Xor num15 > 0F)
			Do
				If num13 > 0F Xor num14 > 0F Then
					num12 = num11
					num15 = APIROD.Fcc(num8, num, num2, num7, num3, num4, num12)
				Else
					num10 = num11
					num13 = APIROD.Fcc(num8, num, num2, num7, num3, num4, num10)
				End If
				num11 = (num12 + num10) / 2F
				num14 = APIROD.Fcc(num8, num, num2, num7, num3, num4, num11)
			Loop While CDbl(Math.Abs(num14)) >= 1E-05
			Fc = num11
		End Sub

		Public Sub FcSteel(Fcf As Object, NumRods As Short, ByRef Sections As RSWIN_DESC.RodSection(), RodstringL As Single, ByRef Fc As Object)
			Dim array As Single()
			Dim array2 As Single()
			Dim num As Short
			Dim num2 As Single
			Dim num3 As Short
			array = New Single(CInt((NumRods + 1S)) - 1) {}
			array2 = New Single(CInt((NumRods + 1S)) - 1) {}
			Fc = 1
			Fcf = 1
			num = 1S
			num2 = 1.5707964F
			num3 = 0S
			For num4 As Short = 1S To NumRods
				If Sections(CInt(num4)).length >= 100F Then
					' The following expression was wrapped in a checked-statement
					num3 += 1S
					array(CInt(num3)) = Sections(CInt(num4)).length / RodstringL
					array2(CInt(num3)) = num2 * array(CInt(num3))
				End If
			Next
			Select Case num3
				Case 0S
					Return
				Case 1S
					Return
				Case 2S
					Dim num5 As Single = Sections(1).Area / Sections(2).Area
					Dim num6 As Single = Sections(2).Area / Sections(1).Area
					Dim num7 As Single = CSng((Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf))) - CDbl(num5)))
					Dim num4 As Short = 1S
					Do
						Dim num8 As Single = CSng((Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf))) - CDbl(num5)))
						Dim obj As Object = num8
						Dim obj2 As Object = num7
						APIROD.ModFcSteel(Fcf, obj, obj2, Fc, num)
						num7 = Conversions.ToSingle(obj2)
						num8 = Conversions.ToSingle(obj)
						num4 += 1S
					Loop While num4 <= 25S
					Return
				Case 3S
					Dim num5 As Single = Sections(1).Area / Sections(2).Area
					Dim num9 As Single = Sections(2).Area / Sections(3).Area
					Dim num6 As Single = Sections(2).Area / Sections(1).Area
					Dim num10 As Single = Sections(3).Area / Sections(1).Area
					Dim num11 As Single = Sections(3).Area / Sections(2).Area
					Dim num7 As Single = CSng(((CDbl(num5) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf))) + Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf)))) / (CDbl(num5) - Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf)))) - CDbl(num9) / Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(3), Fcf)))))
					Dim num4 As Short = 1S
					Do
						Dim num8 As Single = CSng(((CDbl(num5) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf))) + Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf)))) / (CDbl(num5) - Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf)))) - CDbl(num9) / Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(3), Fcf)))))
						Dim obj2 As Object = num8
						Dim obj As Object = num7
						APIROD.ModFcSteel(Fcf, obj2, obj, Fc, num)
						num7 = Conversions.ToSingle(obj)
						num8 = Conversions.ToSingle(obj2)
						num4 += 1S
					Loop While num4 <= 25S
					Return
				Case 4S
					Dim num5 As Single = Sections(1).Area / Sections(2).Area
					Dim num9 As Single = Sections(2).Area / Sections(3).Area
					Dim num6 As Single = Sections(2).Area / Sections(1).Area
					Dim num10 As Single = Sections(3).Area / Sections(1).Area
					Dim num11 As Single = Sections(3).Area / Sections(2).Area
					Dim num12 As Single = Sections(4).Area / Sections(1).Area
					Dim num13 As Single = Sections(1).Area / Sections(3).Area
					Dim num14 As Single = CSng((1.0 - CDbl(num6) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf))) - CDbl(num10) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(3), Fcf))) - CDbl(num11) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(3), Fcf)))))
					Dim num7 As Single = CSng((CDbl(num14) - CDbl(num12) * (Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf))) + CDbl(num5) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf))) + CDbl(num13) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(3), Fcf))) - CDbl(num9) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(3), Fcf)))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(4), Fcf)))))
					Dim num4 As Short = 1S
					Do
						num14 = CSng((1.0 - CDbl(num6) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf))) - CDbl(num10) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(3), Fcf))) - CDbl(num11) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(3), Fcf)))))
						Dim num8 As Single = CSng((CDbl(num14) - CDbl(num12) * (Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf))) + CDbl(num5) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf))) + CDbl(num13) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(3), Fcf))) - CDbl(num9) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(1), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(2), Fcf))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(3), Fcf)))) * Math.Tan(Conversions.ToDouble(Operators.MultiplyObject(array2(4), Fcf)))))
						Dim obj2 As Object = num8
						Dim obj As Object = num7
						APIROD.ModFcSteel(Fcf, obj2, obj, Fc, num)
						num7 = Conversions.ToSingle(obj)
						num8 = Conversions.ToSingle(obj2)
						num4 += 1S
					Loop While num4 <= 30S
			End Select
		End Sub

		Private Sub ModFcSteel(ByRef Fcf As Object, ByRef f As Object, ByRef F1 As Object, ByRef Fc As Object, ByRef Jc As Short)
			If Jc <> 1S Then
				If Jc <> 2S Then
					If Conversions.ToBoolean(Operators.AndObject(Jc = 3S, Operators.CompareObjectGreater(Operators.MultiplyObject(f, F1), 0, False))) Then
						Fcf = Operators.AddObject(Fcf, 0.001)
						GoTo IL_154
					End If
					If Conversions.ToBoolean(Operators.AndObject(Jc = 3S, Operators.CompareObjectLessEqual(Operators.MultiplyObject(f, F1), 0, False))) Then
						Fc = Operators.SubtractObject(Fcf, 0.001)
						Return
					End If
				Else
					If Operators.ConditionalCompareObjectGreater(Operators.MultiplyObject(f, F1), 0, False) Then
						Fcf = Operators.AddObject(Fcf, 0.01)
						GoTo IL_154
					End If
					If Operators.ConditionalCompareObjectLessEqual(Operators.MultiplyObject(f, F1), 0, False) Then
						Jc = 3S
					End If
					Fcf = Operators.SubtractObject(Fcf, 0.011)
					Return
				End If
			End If
			If Not Operators.ConditionalCompareObjectGreater(Operators.MultiplyObject(f, F1), 0, False) Then
				If Operators.ConditionalCompareObjectLessEqual(Operators.MultiplyObject(f, F1), 0, False) Then
					Jc = 2S
				End If
				Fcf = Operators.SubtractObject(Fcf, 0.06)
				Return
			End If
			Fcf = Operators.AddObject(Fcf, 0.05)
			IL_154:
			F1 = RuntimeHelpers.GetObjectValue(f)
		End Sub

		Public Function SpOverS(NoverNoP As Single, FoSkr As Single, UnitType As Short) As Single
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Short = 0S
			Dim num2 As Short = 0S
			Dim num3 As Short = 1S
			Dim numRods As Short = rst.NumRods
			For num4 As Short = num3 To numRods
				If rst.Sections(CInt(num4)).Grade = 20481S Then
					num2 = -1S
				ElseIf RODUTIL.IsFG(rst.Sections(CInt(num4)).Grade) Then
					num = -1S
				End If
			Next
			Dim result As Single
			If num <> 0S Then
				Dim num5 As Single = FoSkr * FoSkr
				Dim num6 As Single = num5 * FoSkr
				Dim num7 As Single = num6 * FoSkr
				Dim num8 As Single = num7 * FoSkr
				Dim num9 As Single = CSng((4.053 - 52.91 * CDbl(FoSkr) + 283.18 * CDbl(num5) - 659.24 * CDbl(num6) + 682.7 * CDbl(num7) - 260.903 * CDbl(num8)))
				Dim num10 As Single = CSng((-25.36 + 409.64 * CDbl(FoSkr) - CDbl((2210F * num5)) + CDbl((5110F * num6)) - CDbl((5250F * num7)) + CDbl((1990F * num8))))
				Dim num11 As Single = CSng((67.93 - 968.727 * CDbl(FoSkr) + CDbl((5104F * num5)) - CDbl((11657F * num6)) + CDbl((11870F * num7)) - CDbl((4475F * num8))))
				Dim num12 As Single = CSng((-67.012 + 771.397 * CDbl(FoSkr) - CDbl((3745F * num5)) + CDbl((8266F * num6)) - CDbl((8240F * num7)) + CDbl((3059F * num8))))
				Dim num13 As Single = CSng((23.4 - 124.6 * CDbl(FoSkr) + 312.55 * CDbl(num5) - 417.07 * CDbl(num6) + 233.3 * CDbl(num7) - 27.515 * CDbl(num8)))
				Dim num14 As Single = NoverNoP * NoverNoP
				Dim num15 As Single = num14 * NoverNoP
				Dim num16 As Single = num15 * NoverNoP
				Dim num17 As Single = num9 + num10 * NoverNoP + num11 * num14 + num12 * num15 + num13 * num16
				If CDbl(num17) < 0.1 Then
					num17 = 0.1F
				End If
				result = num17
			ElseIf num2 <> 0S Then
				Dim num5 As Single = FoSkr * FoSkr
				Dim num6 As Single = num5 * FoSkr
				Dim num7 As Single = num6 * FoSkr
				Dim num8 As Single = num7 * FoSkr
				Dim num9 As Single = CSng((0.8022 + 6.1324 * CDbl(FoSkr) - 63.405 * CDbl(num5) + 198.857 * CDbl(num6) - 250.33 * CDbl(num7) + 108.6 * CDbl(num8)))
				Dim num10 As Single = CSng((-0.6027 + 9.57 * CDbl(FoSkr) + 59.458 * CDbl(num5) - 296.7 * CDbl(num6) + 448.8 * CDbl(num7) - 215.7647 * CDbl(num8)))
				Dim num11 As Single = CSng((5.5309 - 62.72 * CDbl(FoSkr) - 474.94 * CDbl(num5) + 2213.76 * CDbl(num6) - 3196.75 * CDbl(num7) + 1483.09 * CDbl(num8)))
				Dim num12 As Single = CSng((-10.92111 + 141.418 * CDbl(FoSkr) + 1366.4 * CDbl(num5) - 5863.1 * CDbl(num6) + 8102.2 * CDbl(num7) - 3649.4 * CDbl(num8)))
				Dim num13 As Single = CSng((9.3575 - 100.4 * CDbl(FoSkr) - 1253.8 * CDbl(num5) + 5022.8 * CDbl(num6) - 6709.95 * CDbl(num7) + 2951.9 * CDbl(num8)))
				Dim num14 As Single = NoverNoP * NoverNoP
				Dim num15 As Single = num14 * NoverNoP
				Dim num16 As Single = num15 * NoverNoP
				Dim num17 As Single = num9 + num10 * NoverNoP + num11 * num14 + num12 * num15 + num13 * num16
				If CDbl(num17) < 0.1 Then
					num17 = 0.1F
				End If
				result = num17
			Else
				Dim array As Short(,) = New Short(10, 6) {}
				Select Case UnitType
					Case 2S
						array(0, 0) = 0S
						array(0, 1) = 1S
						array(0, 2) = 1S
						array(0, 3) = 1S
						array(0, 4) = 1S
						array(0, 5) = 1S
						array(0, 6) = 1S
						array(1, 0) = 0S
						array(1, 1) = 1S
						array(1, 2) = 1S
						array(1, 3) = 1S
						array(1, 4) = 1S
						array(1, 5) = 1S
						array(1, 6) = 1S
						array(2, 0) = 0S
						array(2, 1) = 1S
						array(2, 2) = 1S
						array(2, 3) = 1S
						array(2, 4) = 1S
						array(2, 5) = 1S
						array(2, 6) = 1S
						array(3, 0) = 0S
						array(3, 1) = 1S
						array(3, 2) = 1S
						array(3, 3) = 1S
						array(3, 4) = 1S
						array(3, 5) = 1S
						array(3, 6) = 1S
						array(4, 0) = 0S
						array(4, 1) = 1S
						array(4, 2) = 1S
						array(4, 3) = 1S
						array(4, 4) = 1S
						array(4, 5) = 1S
						array(4, 6) = 1S
						array(5, 0) = 1S
						array(5, 1) = 1S
						array(5, 2) = 1S
						array(5, 3) = 1S
						array(5, 4) = 1S
						array(5, 5) = 1S
						array(5, 6) = 1S
						array(6, 0) = 1S
						array(6, 1) = 1S
						array(6, 2) = 1S
						array(6, 3) = 1S
						array(6, 4) = 1S
						array(6, 5) = 1S
						array(6, 6) = 1S
						array(7, 0) = 1S
						array(7, 1) = 1S
						array(7, 2) = 1S
						array(7, 3) = 1S
						array(7, 4) = 1S
						array(7, 5) = 1S
						array(7, 6) = 1S
						array(8, 0) = 1S
						array(8, 1) = 1S
						array(8, 2) = 1S
						array(8, 3) = 1S
						array(8, 4) = 1S
						array(8, 5) = 1S
						array(8, 6) = 1S
						array(9, 0) = 1S
						array(9, 1) = 1S
						array(9, 2) = 1S
						array(9, 3) = 1S
						array(9, 4) = 1S
						array(9, 5) = 1S
						array(9, 6) = 1S
						array(10, 0) = 1S
						array(10, 1) = 1S
						array(10, 2) = 1S
						array(10, 3) = 1S
						array(10, 4) = 1S
						array(10, 5) = 1S
						array(10, 6) = 1S
						GoTo IL_D8B
					Case 5S, 6S
						array(0, 0) = 0S
						array(0, 1) = 1S
						array(0, 2) = 1S
						array(0, 3) = 1S
						array(0, 4) = 1S
						array(0, 5) = 1S
						array(0, 6) = 1S
						array(1, 0) = 0S
						array(1, 1) = 1S
						array(1, 2) = 1S
						array(1, 3) = 1S
						array(1, 4) = 1S
						array(1, 5) = 1S
						array(1, 6) = 1S
						array(2, 0) = 0S
						array(2, 1) = 1S
						array(2, 2) = 1S
						array(2, 3) = 1S
						array(2, 4) = 1S
						array(2, 5) = 1S
						array(2, 6) = 1S
						array(3, 0) = 0S
						array(3, 1) = 1S
						array(3, 2) = 1S
						array(3, 3) = 1S
						array(3, 4) = 1S
						array(3, 5) = 1S
						array(3, 6) = 1S
						array(4, 0) = 0S
						array(4, 1) = 1S
						array(4, 2) = 1S
						array(4, 3) = 1S
						array(4, 4) = 1S
						array(4, 5) = 1S
						array(4, 6) = 1S
						array(5, 0) = 1S
						array(5, 1) = 1S
						array(5, 2) = 1S
						array(5, 3) = 1S
						array(5, 4) = 1S
						array(5, 5) = 1S
						array(5, 6) = 1S
						array(6, 0) = 1S
						array(6, 1) = 1S
						array(6, 2) = 1S
						array(6, 3) = 1S
						array(6, 4) = 1S
						array(6, 5) = 1S
						array(6, 6) = 1S
						array(7, 0) = 1S
						array(7, 1) = 1S
						array(7, 2) = 1S
						array(7, 3) = 1S
						array(7, 4) = 1S
						array(7, 5) = 1S
						array(7, 6) = 1S
						array(8, 0) = 1S
						array(8, 1) = 1S
						array(8, 2) = 1S
						array(8, 3) = 1S
						array(8, 4) = 1S
						array(8, 5) = 1S
						array(8, 6) = 1S
						array(9, 0) = 1S
						array(9, 1) = 1S
						array(9, 2) = 1S
						array(9, 3) = 1S
						array(9, 4) = 1S
						array(9, 5) = 1S
						array(9, 6) = 2S
						array(10, 0) = 1S
						array(10, 1) = 1S
						array(10, 2) = 1S
						array(10, 3) = 1S
						array(10, 4) = 2S
						array(10, 5) = 2S
						array(10, 6) = 2S
						GoTo IL_D8B
				End Select
				array(0, 0) = 0S
				array(0, 1) = 0S
				array(0, 2) = 1S
				array(0, 3) = 1S
				array(0, 4) = 1S
				array(0, 5) = 1S
				array(0, 6) = 1S
				array(1, 0) = 0S
				array(1, 1) = 1S
				array(1, 2) = 1S
				array(1, 3) = 1S
				array(1, 4) = 1S
				array(1, 5) = 1S
				array(1, 6) = 1S
				array(2, 0) = 0S
				array(2, 1) = 1S
				array(2, 2) = 1S
				array(2, 3) = 1S
				array(2, 4) = 1S
				array(2, 5) = 1S
				array(2, 6) = 1S
				array(3, 0) = 0S
				array(3, 1) = 1S
				array(3, 2) = 1S
				array(3, 3) = 1S
				array(3, 4) = 1S
				array(3, 5) = 1S
				array(3, 6) = 1S
				array(4, 0) = 1S
				array(4, 1) = 1S
				array(4, 2) = 1S
				array(4, 3) = 1S
				array(4, 4) = 1S
				array(4, 5) = 1S
				array(4, 6) = 1S
				array(5, 0) = 1S
				array(5, 1) = 1S
				array(5, 2) = 1S
				array(5, 3) = 1S
				array(5, 4) = 1S
				array(5, 5) = 1S
				array(5, 6) = 1S
				array(6, 0) = 1S
				array(6, 1) = 1S
				array(6, 2) = 1S
				array(6, 3) = 1S
				array(6, 4) = 1S
				array(6, 5) = 1S
				array(6, 6) = 1S
				array(7, 0) = 1S
				array(7, 1) = 1S
				array(7, 2) = 1S
				array(7, 3) = 1S
				array(7, 4) = 1S
				array(7, 5) = 1S
				array(7, 6) = 1S
				array(8, 0) = 1S
				array(8, 1) = 1S
				array(8, 2) = 1S
				array(8, 3) = 1S
				array(8, 4) = 1S
				array(8, 5) = 1S
				array(8, 6) = 1S
				array(9, 0) = 1S
				array(9, 1) = 1S
				array(9, 2) = 1S
				array(9, 3) = 1S
				array(9, 4) = 1S
				array(9, 5) = 1S
				array(9, 6) = 1S
				array(10, 0) = 1S
				array(10, 1) = 1S
				array(10, 2) = 1S
				array(10, 3) = 1S
				array(10, 4) = 1S
				array(10, 5) = 1S
				array(10, 6) = 2S
				IL_D8B:
				Dim num18 As Single
				Dim num19 As Single
				If CDbl(NoverNoP) >= 0.5 Then
					NoverNoP = 0.5F
					num18 = 9F
					num19 = 10F
				Else
					num18 = CSng(Conversion.Fix(CDbl(NoverNoP) / 0.05))
					num19 = num18 + 1F
				End If
				Dim num20 As Single = CSng((0.05 * Conversion.Fix(CDbl(NoverNoP) / 0.05)))
				Dim num10 As Single
				Dim num11 As Single
				Dim num21 As Single
				Dim num22 As Single
				If CDbl(FoSkr) >= 0.6 Then
					num21 = 0.6F
					num10 = 0F
					num11 = 1F
					num22 = CSng((0.6 / CDbl(FoSkr)))
				Else
					num21 = FoSkr
					num11 = CSng((6.0 - Conversion.Fix(CDbl(num21) / 0.1)))
					num10 = num11 - 1F
					num22 = 1F
				End If
				Dim num23 As Single = CSng((0.1 * Conversion.Fix(CDbl(num21) / 0.1)))
				If CDbl(num21) < 0.1 Then
					num23 = 0.01F
				End If
				Dim num24 As Single = 0.1F
				If CDbl(num21) < 0.1 Then
					num24 = 0.09000001F
				End If
				Dim num25 As Single = CSng((CDbl((CSng((array(CInt(Math.Round(CDbl(num19))), CInt(Math.Round(CDbl(num10)))) - array(CInt(Math.Round(CDbl(num18))), CInt(Math.Round(CDbl(num10)))))) * (NoverNoP - num20))) / 0.05 + CDbl(array(CInt(Math.Round(CDbl(num18))), CInt(Math.Round(CDbl(num10)))))))
				Dim num26 As Single = CSng((CDbl((CSng((array(CInt(Math.Round(CDbl(num19))), CInt(Math.Round(CDbl(num11)))) - array(CInt(Math.Round(CDbl(num18))), CInt(Math.Round(CDbl(num11)))))) * (NoverNoP - num20))) / 0.05 + CDbl(array(CInt(Math.Round(CDbl(num18))), CInt(Math.Round(CDbl(num11)))))))
				result = (num26 - (num26 - num25) * (num21 - num23) / num24) * num22
				Array.Clear(array, 0, array.Length)
			End If
			Return result
		End Function
	End Module
End Namespace
