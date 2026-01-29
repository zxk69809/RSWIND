Imports System
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module kinemat
		Public Function ArcCosine(X As Single) As Double
			Dim result As Double
			If CDbl(X) >= 1.0 Then
				result = 0.0
			ElseIf CDbl(X) <= -1.0 Then
				result = 3.141592653589793
			Else
				result = 1.5707963267948966 - Math.Atan(CDbl(X) / Math.Sqrt(1.0 - CDbl((X * X))))
			End If
			Return result
		End Function

		Private Function ArcSine(X As Single) As Double
			Dim result As Double
			If CDbl(Math.Abs(X)) >= 1.0 Then
				result = 1.5707963267948966 * CDbl(Math.Sign(X))
			Else
				result = Math.Atan(CDbl(X) / Math.Sqrt(1.0 - CDbl((X * X))))
			End If
			Return result
		End Function

		Private Sub bKinconst(PU As RSWIN_DESC.PUDataRec, bShowMessages As Boolean)
			Dim num As Single
			If PU.UnitType = 7S Then
				num = PU.SprocketDistance
			ElseIf PU.UnitType = 10S Then
				num = PU.SprocketDistance - (PU.MaxStroke - RSWIN_DESC.rst.AdjustedStrokeLength)
			End If
			If PU.UnitType = 7S Or PU.UnitType = 10S Then
				kinemat.Thetat = CDbl((num / PU.SprocketRadius))
				kinemat.Srad = 2.0 * kinemat.Thetat + 6.283185307179586
				If PU.P < 1F Then
					kinemat.Xwtop = CDbl((PU.SprocketRadius + num))
					kinemat.Xwbot = CDbl((-CDbl(PU.SprocketRadius)))
					kinemat.Xwa = CDbl(num)
				Else
					kinemat.Xwtop = CDbl((PU.SprocketRadius + PU.P + num))
					kinemat.Xwbot = CDbl((PU.P - PU.SprocketRadius))
					kinemat.Gamma = kinemat.ArcSine(PU.SprocketRadius / PU.P)
					kinemat.Xwa = CDbl(PU.P) * Math.Cos(kinemat.Gamma) + CDbl(num)
				End If
				kinemat.Xwb = kinemat.Xwa - CDbl(num)
				kinemat.ThA = 1.5707963267948966
				kinemat.ThB = 1.5707963267948966 + kinemat.Thetat
				kinemat.ThC = 1.5707963267948966 + kinemat.Thetat + 3.141592653589793
				kinemat.ThD = 1.5707963267948966 + kinemat.Thetat + 3.141592653589793 + kinemat.Thetat
				RSWIN_DESC.rst.CrankSpeed = CSng((CDbl(RSWIN_DESC.rst.SPM) * kinemat.Srad / 60.0))
				RSWIN_DESC.rst.TotalTheta = CSng(kinemat.Srad)
			Else
				kinemat.XK2 = CDbl((PU.K * PU.K))
				kinemat.XKsqr = kinemat.XK2
				kinemat.XR2 = CDbl((PU.R * PU.R))
				kinemat.XRsqr = kinemat.XR2
				kinemat.XC2 = CDbl((PU.C * PU.C))
				kinemat.XCsqr = kinemat.XC2
				kinemat.XP2 = CDbl((PU.P * PU.P))
				kinemat.XPsqr = kinemat.XP2
				kinemat.XKR = CDbl((PU.K * PU.R))
				kinemat.TwoP = CDbl((2F * PU.P))
				kinemat.TwoC = CDbl((2F * PU.C))
				If PU.UnitType <> 9S Then
					kinemat.ARoverC = CDbl((PU.A * PU.R / PU.C))
				Else
					kinemat.ARoverC = 0.0
				End If
				kinemat.TwoCK = CDbl((2F * PU.C * PU.K))
				kinemat.TwoKR = 2.0 * kinemat.XKR
				kinemat.TwoK = CDbl((2F * PU.K))
				kinemat.Alpha = kinemat.ArcSine(PU.I / PU.K)
				kinemat.Alph = kinemat.Alpha
				kinemat.Psib = kinemat.ArcCosine(CSng(((kinemat.XC2 + kinemat.XK2 - CDbl(((PU.P + PU.R) * (PU.P + PU.R)))) / kinemat.TwoCK)))
				kinemat.Psit = kinemat.ArcCosine(CSng(((kinemat.XC2 + kinemat.XK2 - CDbl(((PU.P - PU.R) * (PU.P - PU.R)))) / kinemat.TwoCK)))
				kinemat.Dpsi = kinemat.Psib - kinemat.Psit
				RSWIN_DESC.rst.CrankSpeed = CSng((CDbl(RSWIN_DESC.rst.SPM) * 3.141592653589793 / 30.0))
				RSWIN_DESC.rst.TotalTheta = 6.2831855F
				If PU.RequiredRotation <> 0S Then
					kinemat.RotationInConvention = -1
				Else
					kinemat.RotationInConvention = If((-If(((PU.CrankRotation = 1S) > False), 1, 0)), 1, 0)
				End If
				If PU.UnitType = 9S Then
					PU.KinematicStroke = PU.R * 2F
				End If
			End If
		End Sub

		Private Sub CBAngleFromPrp(Prp As Single, Upstroke As Integer, ByRef Theta As Single)
			kinemat.ThetaFromPrp_Old(Prp, Upstroke <> 0, Theta, False)
			If Not kinemat.RotationInConvention <> 0 Then
				Theta = CSng((6.283185307179586 - CDbl(Theta)))
			End If
		End Sub

		Private Function CurveFit_Save(X As Integer(), Y As Double(), NumCoeff As Integer, ByRef StdError As Double) As Boolean
			Dim num As Integer = Information.UBound(X, 1)
			Dim array3 As Double()
			Dim i As Integer
			Dim num8 As Double
			Dim num26 As Double
			Dim array As Double() = New Double(2 * NumCoeff + 1 + 1 - 1) {}
			Dim array2 As Double(,) = New Double(NumCoeff + 1 + 1 - 1, NumCoeff + 2 + 1 - 1) {}
			array3 = New Double(NumCoeff + 2 + 1 - 1) {}
			array(1) = CDbl(num)
			Dim num2 As Integer = 1
			Dim num3 As Integer = num
			i = num2
			While i <= num3
				Dim num4 As Integer = 2
				Dim num5 As Integer = 2 * NumCoeff + 1
				For j As Integer = num4 To num5

						' The following expression was wrapped in a checked-expression
						array(j) += Math.Pow(CDbl(X(i)), CDbl((j - 1)))

				Next
				Dim num6 As Integer = 1
				Dim num7 As Integer = NumCoeff + 1
				For k As Integer = num6 To num7
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					num8 = array3(k) + Y(i) * Math.Pow(CDbl(X(i)), CDbl((k - 1)))
					array2(k, NumCoeff + 2) = num8
					array3(k) = num8
				Next
				array3(NumCoeff + 2) = array3(NumCoeff + 2) + Y(i) * Y(i)
				i += 1
			End While
			Dim num9 As Integer = 1
			Dim num10 As Integer = NumCoeff + 1
			For j As Integer = num9 To num10
				Dim num11 As Integer = 1
				Dim num12 As Integer = NumCoeff + 1
				For k As Integer = num11 To num12
					array2(j, k) = array(j + k - 1)
				Next
			Next
			Dim num13 As Integer = 1
			Dim num14 As Integer = NumCoeff + 1
			For j As Integer = num13 To num14
				Dim flag As Boolean = False
				Dim num15 As Integer = j
				Dim num16 As Integer = NumCoeff + 1
				Dim k As Integer
				k = num15
				While k <= num16
					If array2(k, j) <> 0.0 Then
						flag = True
						Exit While
					End If
					k += 1
				End While
				If Not flag Then
					MessageBox.Show("No unique solution.")
					Return False
				End If
				Dim num17 As Integer = 1
				Dim num18 As Integer = NumCoeff + 2
				i = num17
				While i <= num18
					Dim num19 As Double = array2(j, i)
					array2(j, i) = array2(k, i)
					array2(k, i) = num19
					i += 1
				End While
				num8 = 1.0 / array2(j, j)
				Dim num20 As Integer = 1
				Dim num21 As Integer = NumCoeff + 2
				i = num20
				While i <= num21
					' The following expression was wrapped in a unchecked-expression
					array2(j, i) = num8 * array2(j, i)
					i += 1
				End While
				Dim num22 As Integer = 1
				Dim num23 As Integer = NumCoeff + 1
				k = num22
				While k <= num23
					If k <> j Then
						' The following expression was wrapped in a unchecked-expression
						num8 = array2(k, j) * -1.0
						Dim num24 As Integer = 1
						Dim num25 As Integer = NumCoeff + 2
						i = num24
						While i <= num25

								array2(k, i) += num8 * array2(j, i)

							i += 1
						End While
					End If
					k += 1
				End While
			Next
			num26 = 0.0
			Dim num27 As Integer = 2
			Dim num28 As Integer = NumCoeff + 1
			For j As Integer = num27 To num28

					' The following expression was wrapped in a checked-expression
					num26 += array2(j, NumCoeff + 2) * (array3(j) - array(j) * array3(1) / CDbl(num))

			Next
			Dim num29 As Double = array3(NumCoeff + 2) - array3(1) * array3(1) / CDbl(num)
			num8 = num29 - num26
			i = num - NumCoeff - 1
			Dim num30 As Double = num26 / num29
			Dim num31 As Double = Math.Sqrt(num26 / num29)
			If i = 0 Then
				StdError = 0.0
			Else
				StdError = Math.Sqrt(Math.Abs(num8 / CDbl(i)))
			End If
			Return True
		End Function

		Private Function CurveFit(ByRef X As Double(), ByRef Y As Double(), ByRef Coeff As Double(), ByRef StdError As Double) As Boolean
			Dim num As Integer = Information.UBound(Coeff, 1)
			Dim num2 As Integer = Information.UBound(X, 1)
			StdError = 0.0
			Dim array3 As Double()
			Dim i As Integer
			Dim num9 As Double
			Dim num30 As Double
			Dim array As Double() = New Double(2 * num + 1 + 1 - 1) {}
			Dim array2 As Double(,) = New Double(num + 1 + 1 - 1, num + 2 + 1 - 1) {}
			array3 = New Double(num + 2 + 1 - 1) {}
			array(1) = CDbl(num2)
			Dim num3 As Integer = 1
			Dim num4 As Integer = num2
			i = num3
			While i <= num4
				Dim num5 As Integer = 2
				Dim num6 As Integer = 2 * num + 1
				For j As Integer = num5 To num6

						' The following expression was wrapped in a checked-expression
						array(j) += Math.Pow(X(i), CDbl((j - 1)))

				Next
				Dim num7 As Integer = 1
				Dim num8 As Integer = num + 1
				For k As Integer = num7 To num8
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					num9 = array3(k) + Y(i) * Math.Pow(X(i), CDbl((k - 1)))
					array2(k, num + 2) = num9
					array3(k) = num9
				Next
				array3(num + 2) = array3(num + 2) + Y(i) * Y(i)
				i += 1
			End While
			Dim num10 As Integer = 1
			Dim num11 As Integer = num + 1
			For j As Integer = num10 To num11
				Dim num12 As Integer = 1
				Dim num13 As Integer = num + 1
				For k As Integer = num12 To num13
					array2(j, k) = array(j + k - 1)
				Next
			Next
			Dim num14 As Integer = 1
			Dim num15 As Integer = num + 1
			For j As Integer = num14 To num15
				Dim num16 As Integer = 0
				Dim num17 As Integer = j
				Dim num18 As Integer = num + 1
				Dim k As Integer
				k = num17
				While k <= num18
					If array2(k, j) <> 0.0 Then
						num16 = -1
						Exit While
					End If
					k += 1
				End While
				If Not num16 <> 0 Then
					Interaction.MsgBox("No unique solution.", MsgBoxStyle.Critical, Nothing)
					Return False
				End If
				Dim num19 As Integer = 1
				Dim num20 As Integer = num + 2
				i = num19
				While i <= num20
					Dim num21 As Double = array2(j, i)
					array2(j, i) = array2(k, i)
					array2(k, i) = num21
					i += 1
				End While
				num9 = 1.0 / array2(j, j)
				Dim num22 As Integer = 1
				Dim num23 As Integer = num + 2
				i = num22
				While i <= num23
					' The following expression was wrapped in a unchecked-expression
					array2(j, i) = num9 * array2(j, i)
					i += 1
				End While
				Dim num24 As Integer = 1
				Dim num25 As Integer = num + 1
				k = num24
				While k <= num25
					If k <> j Then
						' The following expression was wrapped in a unchecked-expression
						num9 = array2(k, j) * -1.0
						Dim num26 As Integer = 1
						Dim num27 As Integer = num + 2
						i = num26
						While i <= num27

								array2(k, i) += num9 * array2(j, i)

							i += 1
						End While
					End If
					k += 1
				End While
			Next
			Dim num28 As Integer = 1
			Dim num29 As Integer = num + 1
			i = num28
			While i <= num29
				Coeff(i - 1) = array2(i, num + 2)
				i += 1
			End While
			num30 = 0.0
			Dim num31 As Integer = 2
			Dim num32 As Integer = num + 1
			For j As Integer = num31 To num32

					' The following expression was wrapped in a checked-expression
					num30 += array2(j, num + 2) * (array3(j) - array(j) * array3(1) / CDbl(num2))

			Next
			Dim num33 As Double = array3(num + 2) - array3(1) * array3(1) / CDbl(num2)
			num9 = num33 - num30
			i = num2 - num - 1
			Dim num34 As Double = num30 / num33
			Dim num35 As Double = Math.Sqrt(num30 / num33)
			If i = 0 Then
				StdError = 0.0
			Else
				StdError = Math.Sqrt(Math.Abs(num9 / CDbl(i)))
			End If
			Return True
		End Function

		Public Sub ProcessDynaCBE()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If rst.CBDataType = 4S Then
				If Not rst.bCBEFromDisk = 0S Then
					If rst.CBEffect = 0F Then
						kinemat.Kinconst(rst.PU)
						Dim cRODSTAR As cRODSTAR = rst
						Dim pu As RSWIN_DESC.PUDataRec = cRODSTAR.PU
						kinemat.Unitstroke(pu)
						cRODSTAR.PU = pu
						Dim measuredCBEpos As Single = rst.MeasuredCBEpos
						pu = rst.PU
						Dim prp As Single = measuredCBEpos * pu.KinematicStroke
						Dim measuredCBEupstroke As Integer = CInt(rst.MeasuredCBEupstroke)
						cRODSTAR = rst
						Dim cbangle As Single = cRODSTAR.CBAngle
						kinemat.CBAngleFromPrp(prp, measuredCBEupstroke, cbangle)
						cRODSTAR.CBAngle = cbangle
						rst.CBEffect = rst.MeasuredCBEffect
						Retail.VerifyCBE()
						rst.UnknownM = False
					End If
				End If
			End If
		End Sub

		Public Sub SortCard2(ByRef dSurfPos As Single(), ByRef dSurfLoad As Single())
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Integer = Information.LBound(dSurfPos, 1)
			Dim num2 As Integer = Information.UBound(dSurfPos, 1)
			Dim num3 As Integer = num2 - num + 1
			Dim array As Single() = New Single(CInt((rst.dNtsteps - 1S + 1S)) - 1) {}
			Dim array2 As Single() = New Single(CInt((rst.dNtsteps - 1S + 1S)) - 1) {}
			Dim a As Single() = dSurfPos
			Dim num4 As Single = 0F
			Dim num5 As Single = 0F
			Dim num7 As Integer
			Dim num6 As Single = CSng(num7)
			Dim num8 As Single = 0F
			Util.Maxmin(a, num4, num5, num6, num8)
			num7 = CInt(Math.Round(CDbl(num6)))
			Dim num9 As Integer = 0
			Dim num10 As Integer = CInt((rst.dNtsteps - 1S))
			For i As Integer = num9 To num10
				array2(i) = dSurfLoad((num7 - num + i) Mod CInt(rst.dNtsteps) + num)
				array(i) = dSurfPos((num7 - num + i) Mod CInt(rst.dNtsteps) + num)
			Next
			Dim a2 As Single() = array
			num8 = 0F
			num6 = 0F
			num5 = 0F
			Dim num11 As Integer
			num4 = CSng(num11)
			Util.Maxmin(a2, num8, num6, num5, num4)
			num11 = CInt(Math.Round(CDbl(num4)))
			dSurfPos = New Single(CInt((rst.dNtsteps - 1S + 1S)) - 1) {}
			dSurfLoad = New Single(CInt((rst.dNtsteps - 1S + 1S)) - 1) {}
			Dim num12 As Integer = 0
			Dim num13 As Integer = CInt((rst.dNtsteps - 1S))
			For i As Integer = num12 To num13
				dSurfLoad(i) = array2((num11 + i) Mod CInt(rst.dNtsteps))
				dSurfPos(i) = array((num11 + i) Mod CInt(rst.dNtsteps))
			Next
		End Sub

		Public Sub SortCard_KEEP2(ByRef dSurfPos As Single(), ByRef dSurfLoad As Single())
			Dim num As Integer = Information.UBound(dSurfLoad, 1)
			Dim array As Single() = New Single(num - 1 + 1 - 1) {}
			Dim array2 As Single() = New Single(num - 1 + 1 - 1) {}
			Dim a As Single() = dSurfPos
			Dim num3 As Integer
			Dim num2 As Single = CSng(num3)
			Dim num5 As Integer
			Dim num4 As Single = CSng(num5)
			Dim num6 As Single
			Dim num7 As Single
			Util.Maxmin(a, num6, num7, num2, num4)
			num5 = CInt(Math.Round(CDbl(num4)))
			num3 = CInt(Math.Round(CDbl(num2)))
			Dim num8 As Integer = 0
			Dim num9 As Integer = num - 1
			For i As Integer = num8 To num9
				array2(i) = dSurfLoad((num5 + i) Mod num)
				array(i) = dSurfPos((num5 + i) Mod num)
			Next
			Dim num10 As Integer = 0
			Dim num11 As Integer = num - 1
			For i As Integer = num10 To num11
				dSurfLoad(i) = array2(i)
				dSurfPos(i) = array(i)
			Next
			Dim a2 As Single() = dSurfPos
			num4 = CSng(num3)
			num2 = CSng(num5)
			Util.Maxmin(a2, num6, num7, num4, num2)
			num5 = CInt(Math.Round(CDbl(num2)))
			num3 = CInt(Math.Round(CDbl(num4)))
		End Sub

		Public Sub SortCard_Keep(ByRef dSurfPos As Single(), ByRef dSurfLoad As Single())
			Dim num As Integer = Information.LBound(dSurfPos, 1)
			Dim num2 As Integer = Information.UBound(dSurfPos, 1)
			Dim num3 As Integer = num2 - num + 1
			Dim array As Single() = New Single(num3 - 1 + 1 - 1) {}
			Dim array2 As Single() = New Single(num3 - 1 + 1 - 1) {}
			Dim a As Single() = dSurfPos
			Dim num4 As Single = 0F
			Dim num5 As Single = 0F
			Dim num7 As Integer
			Dim num6 As Single = CSng(num7)
			Dim num8 As Single = 0F
			Util.Maxmin(a, num4, num5, num6, num8)
			num7 = CInt(Math.Round(CDbl(num6)))
			Dim num9 As Integer = 0
			Dim num10 As Integer = num3 - 1
			For i As Integer = num9 To num10
				array2(i) = dSurfLoad((num7 - num + i) Mod num3 + num)
				array(i) = dSurfPos((num7 - num + i) Mod num3 + num)
			Next
			Dim a2 As Single() = array
			num8 = 0F
			num6 = 0F
			num5 = 0F
			Dim num11 As Integer
			num4 = CSng(num11)
			Util.Maxmin(a2, num8, num6, num5, num4)
			num11 = CInt(Math.Round(CDbl(num4)))
			dSurfPos = New Single(num3 - 1 + 1 - 1) {}
			dSurfLoad = New Single(num3 - 1 + 1 - 1) {}
			Dim num12 As Integer = 0
			Dim num13 As Integer = num3 - 1
			For i As Integer = num12 To num13
				dSurfLoad(i) = array2((num11 + i) Mod num3)
				dSurfPos(i) = array((num11 + i) Mod num3)
			Next
		End Sub

		Public Sub SortCard(ByRef dSurfPos As Single(), ByRef dSurfLoad As Single(), Optional iLB As Integer = 0, Optional iUB As Integer = 0)
			If iUB = 0 Then
				iUB = Information.UBound(dSurfPos, 1)
			End If
			Dim num As Integer = iUB - iLB + 1
			Dim array As Single() = New Single(num - 1 + 1 - 1) {}
			Dim array2 As Single() = New Single(num - 1 + 1 - 1) {}
			Dim a As Single() = dSurfPos
			Dim num3 As Integer
			Dim num2 As Single = CSng(num3)
			Dim num5 As Integer
			Dim num4 As Single = CSng(num5)
			Dim num6 As Single
			Dim num7 As Single
			Util.Maxmin(a, num6, num7, num2, num4)
			num5 = CInt(Math.Round(CDbl(num4)))
			num3 = CInt(Math.Round(CDbl(num2)))
			Dim num8 As Integer = 0
			Dim num9 As Integer = num - 1
			For i As Integer = num8 To num9
				array2(i) = dSurfLoad((num3 - iLB + i) Mod num + iLB)
				array(i) = dSurfPos((num3 - iLB + i) Mod num + iLB)
			Next
			Dim a2 As Single() = array
			num4 = CSng(num3)
			num2 = CSng(num5)
			Util.Maxmin(a2, num6, num7, num4, num2)
			num5 = CInt(Math.Round(CDbl(num2)))
			num3 = CInt(Math.Round(CDbl(num4)))
			dSurfPos = New Single(num - 1 + 1 - 1) {}
			dSurfLoad = New Single(num - 1 + 1 - 1) {}
			Dim num10 As Integer = 0
			Dim num11 As Integer = num - 1
			For i As Integer = num10 To num11
				dSurfLoad(i) = array2((num5 + i) Mod num)
				dSurfPos(i) = array((num5 + i) Mod num)
			Next
		End Sub

		Private Sub kinematics_new(Theta As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Velocity As Single, PU As RSWIN_DESC.PUDataRec)
			Dim num As Integer
			Dim num16 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 2
				IL_08:
				Dim num2 As Integer = 2
				Dim num3 As Double = 2.0 * kinemat.m_PI
				IL_1C:
				num2 = 3
				If RSWIN_DESC.rst.PU.UnitType <> 5S Then
					GoTo IL_3E
				End If
				IL_35:
				num2 = 4
				Dim num4 As Double = CDbl(Theta)
				IL_3C:
				GoTo IL_6F
				IL_3E:
				num2 = 6
				If RSWIN_DESC.rst.PU.CrankRotation <> 1S Then
					GoTo IL_60
				End If
				IL_57:
				num2 = 7
				num4 = CDbl(Theta)
				IL_5E:
				GoTo IL_6F
				IL_60:
				num2 = 9
				IL_64:
				num2 = 10
				num4 = num3 - CDbl(Theta)
				IL_6F:
				num2 = 12
				Dim num5 As Double
				Select Case RSWIN_DESC.rst.PU.UnitType
					Case 5S
						IL_97:
						num2 = 16
						num5 = kinemat.m_PI - num4 + kinemat.Alpha
						IL_AB:
					Case 6S
						IL_AD:
						num2 = 19
						num5 = kinemat.m_PI + num4 + kinemat.Alpha
						IL_C1:
					Case Else
						IL_C3:
						num2 = 22
						num5 = num3 - num4 + kinemat.Alpha
				End Select
				IL_D4:
				num2 = 24
				If num5 >= 0.0 Then
					GoTo IL_F0
				End If
				IL_E5:
				num2 = 25
				num5 += num3
				IL_F0:
				num2 = 27
				If num5 <= num3 Then
					GoTo IL_105
				End If
				IL_FA:
				num2 = 28
				num5 -= num3
				IL_105:
				num2 = 30
				Dim num6 As Double = Math.Sqrt(kinemat.XK2 + kinemat.XR2 - kinemat.TwoKR * Math.Cos(num5))
				IL_129:
				num2 = 31
				Dim num7 As Double = num6 * num6
				IL_134:
				num2 = 32
				Dim num8 As Double = kinemat.TwoC * num6
				IL_142:
				num2 = 33
				If num5 >= kinemat.m_PI Then
					GoTo IL_157
				End If
				IL_14F:
				num2 = 34
				Dim num9 As Integer = 1
				IL_155:
				GoTo IL_161
				IL_157:
				num2 = 36
				IL_15B:
				num2 = 37
				num9 = -1
				IL_161:
				num2 = 39
				Dim num10 As Double = kinemat.ArcCosine(CSng(((num7 + kinemat.XK2 - kinemat.XR2) / (kinemat.TwoK * num6)))) * CDbl(num9)
				IL_186:
				num2 = 40
				Dim num11 As Double = kinemat.ArcCosine(CSng(((kinemat.XC2 + num7 - kinemat.XP2) / num8))) + num10
				IL_1A4:
				num2 = 41
				Dim num12 As Double = kinemat.ArcCosine(CSng(((kinemat.XP2 + num7 - kinemat.XC2) / (kinemat.TwoP * num6)))) - num10
				IL_1C9:
				num2 = 42
				Dim num13 As Double = kinemat.ArcCosine(CSng(((kinemat.XP2 - kinemat.XC2 - num7) / num8))) - num10
				IL_1E8:
				num2 = 43
				Tf = CSng((CDbl((-RSWIN_DESC.rst.PU.CrankRotation)) * kinemat.ARoverC * Math.Sin(num12 - num5) / Math.Sin(num12 - num13)))
				IL_221:
				num2 = 44
				Dim num14 As Double
				Select Case RSWIN_DESC.rst.PU.UnitType
					Case 5S, 6S
						IL_249:
						num2 = 48
						num14 = (kinemat.Psit - num11) / -kinemat.Dpsi
						IL_25C:
					Case Else
						IL_25E:
						num2 = 51
						num14 = (kinemat.Psib - num11) / kinemat.Dpsi
				End Select
				IL_270:
				num2 = 53
				Prp = CSng((num14 * CDbl(RSWIN_DESC.rst.PU.KinematicStroke)))
				IL_28D:
				num2 = 54
				Dim num15 As Double = kinemat.m_PI * CDbl(RSWIN_DESC.rst.SPM) * CDbl(RSWIN_DESC.rst.PU.CrankRotation) / 30.0
				IL_2C3:
				num2 = 55
				Velocity = CSng((CDbl((CSng(RSWIN_DESC.rst.PU.CrankRotation) * Tf)) * num15 / 12.0))
				IL_2EF:
				GoTo IL_455
				IL_2F4:
				num2 = 57
				ProjectData.ClearProjectError()
				If num16 <> 0 Then
					GoTo IL_311
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_30C:
				GoTo IL_455
				IL_311:
				Dim num17 As Integer = num16
				GoTo IL_319
				IL_315:
				num17 = num16 + 1
				IL_319:
				num16 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num17)
				IL_40D:
				GoTo IL_44A
				IL_40F:
				num16 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_426:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num16 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_40F
			End Try
			IL_44A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_455:
			If num16 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function ThetaFromPrp(Prp As Single, Upstroke As Boolean) As Single
			Dim num As Integer
			Dim num23 As Single
			Dim num24 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 2
				IL_08:
				Dim num2 As Integer = 2
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				IL_12:
				num2 = 3
				If RSWIN_DESC.rst.PU.UnitType <> 7S Then
					GoTo IL_45
				End If
				IL_2B:
				num2 = 4
				Dim num3 As Single = RSWIN_DESC.rst.PU.SprocketDistance
				IL_43:
				GoTo IL_96
				IL_45:
				num2 = 6
				If RSWIN_DESC.rst.PU.UnitType <> 10S Then
					GoTo IL_96
				End If
				IL_5F:
				num2 = 7
				num3 = RSWIN_DESC.rst.PU.SprocketDistance - (RSWIN_DESC.rst.PU.MaxStroke - RSWIN_DESC.rst.AdjustedStrokeLength)
				IL_96:
				num2 = 9
				Dim num4 As Single = CSng((2.0 * kinemat.m_PI))
				IL_AC:
				num2 = 10
				If Not(cRODSTAR.PU.UnitType = 7S Or cRODSTAR.PU.UnitType = 10S) Then
					GoTo IL_337
				End If
				IL_DD:
				num2 = 11
				Dim num5 As Single = CSng((kinemat.Xwtop - CDbl(Prp)))
				IL_EC:
				num2 = 12
				Dim num6 As Single = num5
				IL_F4:
				num2 = 15
				If num6 < CSng(kinemat.Xwa) Then
					GoTo IL_1EC
				End If
				IL_105:
				num2 = 16
				If CDbl(num5) <= kinemat.Xwtop Then
					GoTo IL_11F
				End If
				IL_113:
				num2 = 17
				num5 = CSng(kinemat.Xwtop)
				IL_11F:
				num2 = 19
				If cRODSTAR.PU.P < 1F Then
					GoTo IL_1C1
				End If
				IL_13D:
				num2 = 20
				Dim num7 As Single = CSng(kinemat.ArcCosine(CSng(((Math.Pow(CDbl((num5 - num3)), 0.2) + Math.Pow(CDbl(cRODSTAR.PU.SprocketRadius), 2.0) - Math.Pow(CDbl(cRODSTAR.PU.P), 2.0)) / CDbl((2F * (num5 - num3) * cRODSTAR.PU.SprocketRadius))))))
				IL_1BC:
				GoTo IL_318
				IL_1C1:
				num2 = 22
				IL_1C5:
				num2 = 23
				num7 = CSng(kinemat.ArcCosine((num5 - num3) / cRODSTAR.PU.SprocketRadius))
				IL_1E7:
				GoTo IL_318
				IL_1EC:
				num2 = 26
				If num6 < CSng(kinemat.Xwb) Then
					GoTo IL_231
				End If
				IL_1FA:
				num2 = 27
				num7 = CSng((kinemat.m_PI / 2.0 + (kinemat.Xwa - CDbl(num5)) / CDbl(cRODSTAR.PU.SprocketRadius)))
				IL_22C:
				GoTo IL_318
				IL_231:
				num2 = 30
				If CDbl(num5) >= kinemat.Xwbot Then
					GoTo IL_24B
				End If
				IL_23F:
				num2 = 31
				num5 = CSng(kinemat.Xwbot)
				IL_24B:
				num2 = 33
				If cRODSTAR.PU.P < 1F Then
					GoTo IL_2EF
				End If
				IL_269:
				num2 = 34
				num7 = CSng((kinemat.ArcCosine(CSng(((Math.Pow(CDbl(num5), 2.0) + Math.Pow(CDbl(cRODSTAR.PU.SprocketRadius), 2.0) - Math.Pow(CDbl(cRODSTAR.PU.P), 2.0)) / 2.0 / CDbl(num5) / CDbl(cRODSTAR.PU.SprocketRadius)))) + kinemat.Thetat))
				IL_2ED:
				GoTo IL_318
				IL_2EF:
				num2 = 36
				IL_2F3:
				num2 = 37
				num7 = CSng((kinemat.ArcCosine(num5 / cRODSTAR.PU.SprocketRadius) + kinemat.Thetat))
				IL_318:
				num2 = 40
				If Upstroke Then
					GoTo IL_803
				End If
				IL_322:
				num2 = 41
				num7 = CSng((kinemat.Srad - CDbl(num7)))
				IL_332:
				GoTo IL_803
				IL_337:
				num2 = 44
				If cRODSTAR.PU.UnitType <> 9S Then
					GoTo IL_5DE
				End If
				IL_352:
				num2 = 45
				Dim c As Single = RSWIN_DESC.rst.PU.C
				IL_36A:
				num2 = 46
				Dim i As Single = RSWIN_DESC.rst.PU.I
				IL_383:
				num2 = 47
				Dim k As Single = RSWIN_DESC.rst.PU.K
				IL_39C:
				num2 = 48
				Dim r As Single = RSWIN_DESC.rst.PU.R
				IL_3B5:
				num2 = 49
				Dim num8 As Single = CSng((Math.Sin(Math.Acos(CDbl((i / k)))) * CDbl(k)))
				IL_3D0:
				num2 = 50
				Dim num9 As Single = k - r
				IL_3DB:
				num2 = 51
				Dim num10 As Single = 2F * r
				IL_3E9:
				num2 = 52
				Dim num11 As Single = num8 + c / 2F
				IL_3F9:
				num2 = 53
				Dim num12 As Single = CSng(Math.Atan(CDbl((num11 / i))))
				IL_40A:
				num2 = 54
				If RSWIN_DESC.rst.PU.CrankRotation <> 1S Then
					GoTo IL_463
				End If
				IL_424:
				num2 = 55
				If Not(CDbl(num7) > 1.5707963267948966 - CDbl(num12) And CDbl(num7) < 4.71238898038469 - CDbl(num12)) Then
					GoTo IL_456
				End If
				IL_44D:
				num2 = 56
				Dim num13 As Integer = 1
				IL_454:
				GoTo IL_4B8
				IL_456:
				num2 = 58
				IL_45A:
				num2 = 59
				num13 = -1
				IL_461:
				GoTo IL_4B8
				IL_463:
				num2 = 62
				IL_467:
				num2 = 63
				Dim num14 As Single = CSng((6.283185307179586 - CDbl(num7)))
				IL_47B:
				num2 = 64
				If Not(CDbl(num14) > 1.5707963267948966 - CDbl(num12) And CDbl(num14) < 4.71238898038469 - CDbl(num12)) Then
					GoTo IL_4AD
				End If
				IL_4A4:
				num2 = 65
				num13 = -1
				IL_4AB:
				GoTo IL_4B8
				IL_4AD:
				num2 = 67
				IL_4B1:
				num2 = 68
				num13 = 1
				IL_4B8:
				num2 = 71
				Dim num15 As Single = num9 + Prp
				IL_4C2:
				num2 = 72
				Dim num16 As Single = CSng(Math.Acos((Math.Pow(CDbl(k), 2.0) + Math.Pow(CDbl(r), 2.0) - Math.Pow(CDbl(num15), 2.0)) / CDbl((2F * k * r))))
				IL_50F:
				num2 = 73
				If Not(RSWIN_DESC.rst.PU.CrankRotation = 1S And num13 = 1) Then
					GoTo IL_53A
				End If
				IL_531:
				num2 = 74
				num16 = -num16
				IL_538:
				GoTo IL_563
				IL_53A:
				num2 = 76
				If Not(RSWIN_DESC.rst.PU.CrankRotation = -1S And num13 = -1) Then
					GoTo IL_563
				End If
				IL_55C:
				num2 = 77
				num16 = -num16
				IL_563:
				num2 = 79
				num7 = CSng((CDbl(num16) - 1.5707963267948966 + CDbl(num12)))
				IL_579:
				num2 = 80
				num7 = CSng((1.5707963267948966 - CDbl(num12) - CDbl(num16)))
				IL_58F:
				num2 = 81
				If num7 >= 0F Then
					GoTo IL_5B0
				End If
				IL_59C:
				num2 = 82
				num7 = CSng((CDbl(num7) + 6.283185307179586))
				IL_5B0:
				num2 = 84
				If CDbl(num7) <= 6.283185307179586 Then
					GoTo IL_803
				End If
				IL_5C5:
				num2 = 85
				num7 = CSng((CDbl(num7) - 6.283185307179586))
				IL_5D9:
				GoTo IL_803
				IL_5DE:
				num2 = 88
				IL_5E2:
				num2 = 89
				Dim num17 As Single = Prp / cRODSTAR.PU.KinematicStroke
				IL_5FA:
				num2 = 90
				If Not(cRODSTAR.PU.UnitType = 5S Or cRODSTAR.PU.UnitType = 6S) Then
					GoTo IL_63E
				End If
				IL_627:
				num2 = 91
				Dim num18 As Single = CSng((kinemat.Psit + CDbl(num17) * kinemat.Dpsi))
				IL_63C:
				GoTo IL_657
				IL_63E:
				num2 = 93
				IL_642:
				num2 = 94
				num18 = CSng((kinemat.Psib - CDbl(num17) * kinemat.Dpsi))
				IL_657:
				num2 = 96
				Dim num19 As Single = CSng(Math.Sqrt(kinemat.XC2 + kinemat.XK2 - kinemat.TwoCK * Math.Cos(CDbl(num18))))
				IL_67C:
				num2 = 97
				Dim num20 As Single = CSng(kinemat.ArcSine(CSng((CDbl(cRODSTAR.PU.C) * Math.Sin(CDbl(num18)) / CDbl(num19)))))
				IL_6A6:
				num2 = 98
				num12 = CSng(kinemat.ArcCosine(CSng(((Math.Pow(CDbl(num19), 2.0) + kinemat.XR2 - kinemat.XP2) / CDbl((2F * num19 * cRODSTAR.PU.R))))))
				IL_6EA:
				num2 = 99
				If Not Upstroke Then
					GoTo IL_709
				End If
				IL_6F1:
				num2 = 100
				Dim num21 As Integer = CInt(cRODSTAR.PU.CrankRotation)
				IL_707:
				GoTo IL_725
				IL_709:
				num2 = 102
				IL_70D:
				num2 = 103
				num21 = CInt((-cRODSTAR.PU.CrankRotation))
				IL_725:
				num2 = 105
				Dim num22 As Single = num20 - num12 * CSng(num21)
				IL_733:
				num2 = 106
				Select Case cRODSTAR.PU.UnitType
					Case 5S
						IL_758:
						num2 = 110
						num7 = CSng((kinemat.m_PI - CDbl(num22) + kinemat.Alpha))
						IL_76E:
					Case 6S
						IL_770:
						num2 = 113
						num7 = CSng((CDbl(num22) - kinemat.m_PI - kinemat.Alpha))
						IL_786:
					Case Else
						IL_788:
						num2 = 116
						num7 = CSng((CDbl((num4 - num22)) + kinemat.Alpha))
				End Select
				IL_79B:
				num2 = 118
				If Not(cRODSTAR.PU.CrankRotation = -1S And cRODSTAR.PU.UnitType <> 5S) Then
					GoTo IL_7D6
				End If
				IL_7CB:
				num2 = 119
				num7 = num4 - num7
				IL_7D6:
				num2 = 121
				If num7 >= 0F Then
					GoTo IL_7EE
				End If
				IL_7E3:
				num2 = 122
				num7 += num4
				IL_7EE:
				num2 = 124
				If num7 <= num4 Then
					GoTo IL_803
				End If
				IL_7F8:
				num2 = 125
				num7 -= num4
				IL_803:
				num2 = 128
				num23 = num7
				IL_80E:
				cRODSTAR = Nothing
				IL_811:
				GoTo IL_AA2
				IL_816:
				num2 = 131
				ProjectData.ClearProjectError()
				If num24 <> 0 Then
					GoTo IL_836
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_831:
				GoTo IL_AA2
				IL_836:
				Dim num25 As Integer = num24
				GoTo IL_83E
				IL_83A:
				num25 = num24 + 1
				IL_83E:
				num24 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num25)
				IL_A5A:
				GoTo IL_A97
				IL_A5C:
				num24 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_A73:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num24 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_A5C
			End Try
			IL_A97:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_AA2:
			Dim result As Single = num23
			If num24 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Function ThetaFromPrp_Dbl(Prp As Double, Upstroke As Boolean, Optional bUsePrp As Boolean = False) As Double
			Dim num As Integer
			Dim num23 As Double
			Dim num24 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 2
				IL_08:
				Dim num2 As Integer = 2
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				IL_12:
				num2 = 3
				If RSWIN_DESC.rst.PU.UnitType <> 7S Then
					GoTo IL_45
				End If
				IL_2B:
				num2 = 4
				Dim num3 As Single = RSWIN_DESC.rst.PU.SprocketDistance
				IL_43:
				GoTo IL_96
				IL_45:
				num2 = 6
				If RSWIN_DESC.rst.PU.UnitType <> 10S Then
					GoTo IL_96
				End If
				IL_5F:
				num2 = 7
				num3 = RSWIN_DESC.rst.PU.SprocketDistance - (RSWIN_DESC.rst.PU.MaxStroke - RSWIN_DESC.rst.AdjustedStrokeLength)
				IL_96:
				num2 = 9
				Dim num4 As Double = 2.0 * kinemat.m_PI
				IL_AB:
				num2 = 10
				If Not(cRODSTAR.PU.UnitType = 7S Or cRODSTAR.PU.UnitType = 10S) Then
					GoTo IL_32E
				End If
				IL_DC:
				num2 = 11
				Dim num5 As Double = kinemat.Xwtop - Prp
				IL_E9:
				num2 = 12
				Dim num6 As Double = num5
				IL_F1:
				num2 = 15
				If num6 < kinemat.Xwa Then
					GoTo IL_1EC
				End If
				IL_101:
				num2 = 16
				If num5 <= kinemat.Xwtop Then
					GoTo IL_119
				End If
				IL_10E:
				num2 = 17
				num5 = kinemat.Xwtop
				IL_119:
				num2 = 19
				If cRODSTAR.PU.P < 1F Then
					GoTo IL_1BF
				End If
				IL_137:
				num2 = 20
				Dim num7 As Double = kinemat.ArcCosine(CSng(((Math.Pow(num5 - CDbl(num3), 0.2) + Math.Pow(CDbl(cRODSTAR.PU.SprocketRadius), 2.0) - Math.Pow(CDbl(cRODSTAR.PU.P), 2.0)) / (2.0 * (num5 - CDbl(num3)) * CDbl(cRODSTAR.PU.SprocketRadius)))))
				IL_1BA:
				GoTo IL_311
				IL_1BF:
				num2 = 22
				IL_1C3:
				num2 = 23
				num7 = kinemat.ArcCosine(CSng(((num5 - CDbl(num3)) / CDbl(cRODSTAR.PU.SprocketRadius))))
				IL_1E7:
				GoTo IL_311
				IL_1EC:
				num2 = 26
				If num6 < kinemat.Xwb Then
					GoTo IL_22E
				End If
				IL_1F9:
				num2 = 27
				num7 = kinemat.m_PI / 2.0 + (kinemat.Xwa - num5) / CDbl(cRODSTAR.PU.SprocketRadius)
				IL_229:
				GoTo IL_311
				IL_22E:
				num2 = 30
				If num5 >= kinemat.Xwbot Then
					GoTo IL_246
				End If
				IL_23B:
				num2 = 31
				num5 = kinemat.Xwbot
				IL_246:
				num2 = 33
				If cRODSTAR.PU.P < 1F Then
					GoTo IL_2E7
				End If
				IL_264:
				num2 = 34
				num7 = kinemat.ArcCosine(CSng(((Math.Pow(num5, 2.0) + Math.Pow(CDbl(cRODSTAR.PU.SprocketRadius), 2.0) - Math.Pow(CDbl(cRODSTAR.PU.P), 2.0)) / 2.0 / num5 / CDbl(cRODSTAR.PU.SprocketRadius)))) + kinemat.Thetat
				IL_2E5:
				GoTo IL_311
				IL_2E7:
				num2 = 36
				IL_2EB:
				num2 = 37
				num7 = kinemat.ArcCosine(CSng((num5 / CDbl(cRODSTAR.PU.SprocketRadius)))) + kinemat.Thetat
				IL_311:
				num2 = 40
				If Upstroke Then
					GoTo IL_82D
				End If
				IL_31B:
				num2 = 41
				num7 = kinemat.Srad - num7
				IL_329:
				GoTo IL_82D
				IL_32E:
				num2 = 44
				If cRODSTAR.PU.UnitType <> 9S Then
					GoTo IL_5FE
				End If
				IL_349:
				num2 = 45
				Dim c As Single = RSWIN_DESC.rst.PU.C
				IL_361:
				num2 = 46
				Dim i As Single = RSWIN_DESC.rst.PU.I
				IL_37A:
				num2 = 47
				Dim k As Single = RSWIN_DESC.rst.PU.K
				IL_393:
				num2 = 48
				Dim r As Single = RSWIN_DESC.rst.PU.R
				IL_3AC:
				num2 = 49
				Dim num8 As Single = CSng((Math.Sin(Math.Acos(CDbl((i / k)))) * CDbl(k)))
				IL_3C7:
				num2 = 50
				Dim num9 As Single = k - r
				IL_3D2:
				num2 = 51
				Dim num10 As Single = 2F * r
				IL_3E0:
				num2 = 52
				Dim num11 As Single = num8 + c / 2F
				IL_3F0:
				num2 = 53
				Dim num12 As Double = Math.Atan(CDbl((num11 / i)))
				IL_400:
				num2 = 54
				If Not bUsePrp Then
					GoTo IL_433
				End If
				IL_407:
				num2 = 55
				If Prp <> 0.0 Then
					GoTo IL_423
				End If
				IL_417:
				num2 = 56
				Dim num13 As Integer = 1
				IL_41E:
				GoTo IL_4DB
				IL_423:
				num2 = 58
				IL_427:
				num2 = 59
				num13 = -1
				IL_42E:
				GoTo IL_4DB
				IL_433:
				num2 = 62
				IL_437:
				num2 = 63
				If RSWIN_DESC.rst.PU.CrankRotation <> 1S Then
					GoTo IL_48C
				End If
				IL_451:
				num2 = 64
				If Not(num7 > 1.5707963267948966 - num12 And num7 < 4.71238898038469 - num12) Then
					GoTo IL_47F
				End If
				IL_476:
				num2 = 65
				num13 = 1
				IL_47D:
				GoTo IL_4DB
				IL_47F:
				num2 = 67
				IL_483:
				num2 = 68
				num13 = -1
				IL_48A:
				GoTo IL_4DB
				IL_48C:
				num2 = 71
				IL_490:
				num2 = 72
				Dim num14 As Double = 6.283185307179586 - num7
				IL_4A2:
				num2 = 73
				If Not(num14 > 1.5707963267948966 - num12 And num14 < 4.71238898038469 - num12) Then
					GoTo IL_4D0
				End If
				IL_4C7:
				num2 = 74
				num13 = -1
				IL_4CE:
				GoTo IL_4DB
				IL_4D0:
				num2 = 76
				IL_4D4:
				num2 = 77
				num13 = 1
				IL_4DB:
				num2 = 81
				Dim num15 As Single = CSng((CDbl(num9) + Prp))
				IL_4E7:
				num2 = 82
				Dim num16 As Single = CSng(Math.Acos((Math.Pow(CDbl(k), 2.0) + Math.Pow(CDbl(r), 2.0) - Math.Pow(CDbl(num15), 2.0)) / CDbl((2F * k * r))))
				IL_534:
				num2 = 83
				If Not(RSWIN_DESC.rst.PU.CrankRotation = 1S And num13 = 1) Then
					GoTo IL_55F
				End If
				IL_556:
				num2 = 84
				num16 = -num16
				IL_55D:
				GoTo IL_588
				IL_55F:
				num2 = 86
				If Not(RSWIN_DESC.rst.PU.CrankRotation = -1S And num13 = -1) Then
					GoTo IL_588
				End If
				IL_581:
				num2 = 87
				num16 = -num16
				IL_588:
				num2 = 89
				num7 = CDbl(num16) - 1.5707963267948966 + num12
				IL_59C:
				num2 = 90
				num7 = 1.5707963267948966 - num12 - CDbl(num16)
				IL_5B0:
				num2 = 91
				If num7 >= 0.0 Then
					GoTo IL_5D3
				End If
				IL_5C1:
				num2 = 92
				num7 += 6.283185307179586
				IL_5D3:
				num2 = 94
				If num7 <= 6.283185307179586 Then
					GoTo IL_82D
				End If
				IL_5E7:
				num2 = 95
				num7 -= 6.283185307179586
				IL_5F9:
				GoTo IL_82D
				IL_5FE:
				num2 = 98
				IL_602:
				num2 = 99
				Dim num17 As Double = Prp / CDbl(cRODSTAR.PU.KinematicStroke)
				IL_61B:
				num2 = 100
				If Not(cRODSTAR.PU.UnitType = 5S Or cRODSTAR.PU.UnitType = 6S) Then
					GoTo IL_65D
				End If
				IL_648:
				num2 = 101
				Dim num18 As Double = kinemat.Psit + num17 * kinemat.Dpsi
				IL_65B:
				GoTo IL_674
				IL_65D:
				num2 = 103
				IL_661:
				num2 = 104
				num18 = kinemat.Psib - num17 * kinemat.Dpsi
				IL_674:
				num2 = 106
				Dim num19 As Double = Math.Sqrt(kinemat.XC2 + kinemat.XK2 - kinemat.TwoCK * Math.Cos(num18))
				IL_697:
				num2 = 107
				Dim num20 As Double = kinemat.ArcSine(CSng((CDbl(cRODSTAR.PU.C) * Math.Sin(num18) / num19)))
				IL_6BE:
				num2 = 108
				num12 = kinemat.ArcCosine(CSng(((Math.Pow(num19, 2.0) + kinemat.XR2 - kinemat.XP2) / (2.0 * num19 * CDbl(cRODSTAR.PU.R)))))
				IL_704:
				num2 = 109
				If Not Upstroke Then
					GoTo IL_723
				End If
				IL_70B:
				num2 = 110
				Dim num21 As Integer = CInt(cRODSTAR.PU.CrankRotation)
				IL_721:
				GoTo IL_73F
				IL_723:
				num2 = 112
				IL_727:
				num2 = 113
				num21 = CInt((-cRODSTAR.PU.CrankRotation))
				IL_73F:
				num2 = 115
				Dim num22 As Double = num20 - num12 * CDbl(num21)
				IL_74D:
				num2 = 116
				Select Case cRODSTAR.PU.UnitType
					Case 5S
						IL_772:
						num2 = 120
						num7 = kinemat.m_PI - num22 + kinemat.Alpha
						IL_786:
					Case 6S
						IL_788:
						num2 = 123
						num7 = num22 - kinemat.m_PI - kinemat.Alpha
						IL_79C:
					Case Else
						IL_79E:
						num2 = 126
						num7 = num4 - num22 + kinemat.Alpha
				End Select
				IL_7AF:
				num2 = 128
				If Not(cRODSTAR.PU.CrankRotation = -1S And cRODSTAR.PU.UnitType <> 5S) Then
					GoTo IL_7F0
				End If
				IL_7E2:
				num2 = 129
				num7 = num4 - num7
				IL_7F0:
				num2 = 131
				If num7 >= 0.0 Then
					GoTo IL_812
				End If
				IL_804:
				num2 = 132
				num7 += num4
				IL_812:
				num2 = 134
				If num7 <= num4 Then
					GoTo IL_82D
				End If
				IL_81F:
				num2 = 135
				num7 -= num4
				IL_82D:
				num2 = 138
				num23 = num7
				IL_838:
				cRODSTAR = Nothing
				IL_83B:
				GoTo IL_AF4
				IL_840:
				num2 = 141
				ProjectData.ClearProjectError()
				If num24 <> 0 Then
					GoTo IL_860
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_85B:
				GoTo IL_AF4
				IL_860:
				Dim num25 As Integer = num24
				GoTo IL_868
				IL_864:
				num25 = num24 + 1
				IL_868:
				num24 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num25)
				IL_AAC:
				GoTo IL_AE9
				IL_AAE:
				num24 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_AC5:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num24 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_AAE
			End Try
			IL_AE9:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_AF4:
			Dim result As Double = num23
			If num24 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub ThetaFromPrp_Old(Prp As Single, Upstroke As Boolean, ByRef Theta As Single, Optional bUsePrp As Boolean = False)
			Dim num As Single = 6.2831855F
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num2 As Single
			If RSWIN_DESC.rst.PU.UnitType = 7S Then
				num2 = RSWIN_DESC.rst.PU.SprocketDistance
			ElseIf RSWIN_DESC.rst.PU.UnitType = 10S Then
				num2 = RSWIN_DESC.rst.PU.SprocketDistance - (RSWIN_DESC.rst.PU.MaxStroke - RSWIN_DESC.rst.AdjustedStrokeLength)
			End If
			If rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Then
				Dim num3 As Single = CSng((kinemat.Xwtop - CDbl(Prp)))
				Dim num4 As Single = num3
				If num4 >= CSng(kinemat.Xwa) Then
					If CDbl(num3) > kinemat.Xwtop Then
						num3 = CSng(kinemat.Xwtop)
					End If
					If rst.PU.P >= 1F Then
						Theta = CSng(kinemat.ArcCosine(CSng(((Math.Pow(CDbl((num3 - num2)), 2.0) + Math.Pow(CDbl(rst.PU.SprocketRadius), 2.0) - Math.Pow(CDbl(rst.PU.P), 2.0)) / CDbl((2F * (num3 - num2) * rst.PU.SprocketRadius))))))
					Else
						Theta = CSng(kinemat.ArcCosine((num3 - num2) / rst.PU.SprocketRadius))
					End If
				ElseIf num4 >= CSng(kinemat.Xwb) Then
					Theta = CSng((1.5707963267948966 + (kinemat.Xwa - CDbl(num3)) / CDbl(rst.PU.SprocketRadius)))
				Else
					If CDbl(num3) < kinemat.Xwbot Then
						num3 = CSng(kinemat.Xwbot)
					End If
					If rst.PU.P >= 1F Then
						Theta = CSng((kinemat.ArcCosine(CSng(((Math.Pow(CDbl(num3), 2.0) + Math.Pow(CDbl(rst.PU.SprocketRadius), 2.0) - Math.Pow(CDbl(rst.PU.P), 2.0)) / 2.0 / CDbl(num3) / CDbl(rst.PU.SprocketRadius)))) + kinemat.Thetat))
					Else
						Theta = CSng((kinemat.ArcCosine(num3 / rst.PU.SprocketRadius) + kinemat.Thetat))
					End If
				End If
				If Not Upstroke Then
					Theta = CSng((kinemat.Srad - CDbl(Theta)))
				End If
			ElseIf rst.PU.UnitType = 9S Then
				Dim c As Single = RSWIN_DESC.rst.PU.C
				Dim i As Single = RSWIN_DESC.rst.PU.I
				Dim k As Single = RSWIN_DESC.rst.PU.K
				Dim r As Single = RSWIN_DESC.rst.PU.R
				Dim num5 As Single = CSng((Math.Sin(Math.Acos(CDbl((i / k)))) * CDbl(k)))
				Dim num6 As Single = k - r
				Dim num7 As Single = 2F * r
				Dim num8 As Single = num5 + c / 2F
				Dim num9 As Single = CSng(Math.Atan(CDbl((num8 / i))))
				Dim num10 As Integer
				If bUsePrp Then
					If Prp = 0F Then
						num10 = 1
					Else
						num10 = -1
					End If
				ElseIf RSWIN_DESC.rst.PU.CrankRotation = 1S Then
					If CDbl(Theta) > 1.5707963267948966 - CDbl(num9) And CDbl(Theta) < 4.71238898038469 - CDbl(num9) Then
						num10 = 1
					Else
						num10 = -1
					End If
				Else
					Dim num11 As Single = CSng((6.283185307179586 - CDbl(Theta)))
					If CDbl(num11) > 1.5707963267948966 - CDbl(num9) And CDbl(num11) < 4.71238898038469 - CDbl(num9) Then
						num10 = -1
					Else
						num10 = 1
					End If
				End If
				Dim num12 As Single = num6 + Prp
				Dim num13 As Single = CSng(Math.Acos((Math.Pow(CDbl(k), 2.0) + Math.Pow(CDbl(r), 2.0) - Math.Pow(CDbl(num12), 2.0)) / CDbl((2F * k * r))))
				If RSWIN_DESC.rst.PU.CrankRotation = 1S And num10 = 1 Then
					num13 = -num13
				ElseIf RSWIN_DESC.rst.PU.CrankRotation = -1S And num10 = -1 Then
					num13 = -num13
				End If
				Theta = CSng((CDbl(num13) - 1.5707963267948966 + CDbl(num9)))
				Theta = CSng((1.5707963267948966 - CDbl(num9) - CDbl(num13)))
				If Theta < 0F Then
					Theta = CSng((CDbl(Theta) + 6.283185307179586))
				End If
				If CDbl(Theta) > 6.283185307179586 Then
					Theta = CSng((CDbl(Theta) - 6.283185307179586))
				End If
			Else
				Dim num14 As Single = Prp / rst.PU.KinematicStroke
				Dim num15 As Single
				If rst.PU.UnitType = 5S Or rst.PU.UnitType = 6S Then
					num15 = CSng((kinemat.Psit + CDbl(num14) * kinemat.Dpsi))
				Else
					num15 = CSng((kinemat.Psib - CDbl(num14) * kinemat.Dpsi))
				End If
				Dim num16 As Single = CSng(Math.Sqrt(kinemat.XC2 + kinemat.XK2 - kinemat.TwoCK * Math.Cos(CDbl(num15))))
				Dim num17 As Single = CSng(kinemat.ArcSine(CSng((CDbl(rst.PU.C) * Math.Sin(CDbl(num15)) / CDbl(num16)))))
				Dim num9 As Single = CSng(kinemat.ArcCosine(CSng(((Math.Pow(CDbl(num16), 2.0) + kinemat.XR2 - kinemat.XP2) / CDbl((2F * num16 * rst.PU.R))))))
				Dim num18 As Integer
				If Upstroke Then
					num18 = CInt(rst.PU.CrankRotation)
				Else
					num18 = CInt((-rst.PU.CrankRotation))
				End If
				Dim num19 As Single = num17 - num9 * CSng(num18)
				Select Case rst.PU.UnitType
					Case 5S
						Theta = CSng((3.141592653589793 - CDbl(num19) + kinemat.Alpha))
					Case 6S
						Theta = CSng((CDbl(num19) - 3.141592653589793 - kinemat.Alpha))
					Case Else
						Theta = CSng((CDbl((num - num19)) + kinemat.Alpha))
				End Select
				If rst.PU.CrankRotation = -1S And rst.PU.UnitType <> 5S Then
					Theta = num - Theta
				End If
				If Theta < 0F Then
					Theta += num
				End If
				If Theta > num Then
					Theta -= num
				End If
			End If
		End Sub

		Public Sub Unitstroke(ByRef PU As RSWIN_DESC.PUDataRec)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 2
				IL_08:
				Dim num2 As Integer = 2
				If RSWIN_DESC.rst.PU.UnitType <> 7S Then
					GoTo IL_39
				End If
				IL_20:
				num2 = 3
				Dim num3 As Single = RSWIN_DESC.rst.PU.SprocketDistance
				IL_37:
				GoTo IL_88
				IL_39:
				num2 = 5
				If RSWIN_DESC.rst.PU.UnitType <> 10S Then
					GoTo IL_88
				End If
				IL_53:
				num2 = 6
				num3 = RSWIN_DESC.rst.PU.SprocketDistance - (RSWIN_DESC.rst.PU.MaxStroke - RSWIN_DESC.rst.AdjustedStrokeLength)
				IL_88:
				num2 = 8
				If Strings.InStr(RSWIN.App.Title, "DEMO", CompareMethod.Binary) = 0 Then
					GoTo IL_1EA
				End If
				IL_A6:
				num2 = 9
				If Not(PU.UnitType = 7S Or PU.UnitType = 10S) Then
					GoTo IL_F7
				End If
				IL_C0:
				num2 = 10
				PU.KinematicStroke = num3 + 2F * PU.SprocketRadius
				IL_D8:
				num2 = 11
				RSWIN_DESC.rst.StrokeFeet = PU.KinematicStroke / 12F
				IL_F2:
				GoTo IL_348
				IL_F7:
				num2 = 13
				IL_FB:
				num2 = 14
				kinemat.Psib = kinemat.ArcCosine(CSng(((kinemat.XC2 + kinemat.XK2 - Math.Pow(CDbl((PU.P + PU.R)), 2.0)) / kinemat.TwoCK)))
				IL_138:
				num2 = 15
				kinemat.Psit = kinemat.ArcCosine(CSng(((kinemat.XC2 + kinemat.XK2 - Math.Pow(CDbl((PU.P - PU.R)), 2.0)) / kinemat.TwoCK)))
				IL_175:
				num2 = 16
				kinemat.Dpsi = kinemat.Psib - kinemat.Psit
				IL_189:
				num2 = 17
				If PU.UnitType <> 9S Then
					GoTo IL_1AF
				End If
				IL_197:
				num2 = 18
				PU.KinematicStroke = PU.R * 2F
				IL_1AD:
				GoTo IL_1CB
				IL_1AF:
				num2 = 20
				IL_1B3:
				num2 = 21
				PU.KinematicStroke = CSng((CDbl(PU.A) * kinemat.Dpsi))
				IL_1CB:
				num2 = 23
				RSWIN_DESC.rst.StrokeFeet = PU.KinematicStroke / 12F
				IL_1E5:
				GoTo IL_348
				IL_1EA:
				num2 = 26
				IL_1EE:
				num2 = 27
				Dim jpred As cJPred = MJPred.JPred
				IL_1F8:
				num2 = 28
				jpred.Kinconst()
				IL_202:
				num2 = 29
				PU.KinematicStroke = MJPred.JPred.PU_KinematicStroke
				IL_216:
				num2 = 30
				If PU.UnitType <> 9S Then
					GoTo IL_23A
				End If
				IL_224:
				num2 = 31
				PU.KinematicStroke = PU.R * 2F
				IL_23A:
				GoTo IL_348
				IL_23F:
				num2 = 35
				ProjectData.ClearProjectError()
				If num4 <> 0 Then
					GoTo IL_25C
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_257:
				GoTo IL_348
				IL_25C:
				Dim num5 As Integer = num4
				GoTo IL_264
				IL_260:
				num5 = num4 + 1
				IL_264:
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_300:
				GoTo IL_33D
				IL_302:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_319:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_302
			End Try
			IL_33D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_348:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub bKinconst_new(PU As RSWIN_DESC.PUDataRec, Optional bShowMessages As Boolean = False)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 2
				IL_07:
				Dim num2 As Integer = 2
				If RSWIN_DESC.rst.PU.UnitType <> 7S Then
					GoTo IL_2C
				End If
				IL_1F:
				num2 = 3
				Dim num3 As Single = PU.SprocketDistance
				IL_2A:
				GoTo IL_63
				IL_2C:
				num2 = 5
				If RSWIN_DESC.rst.PU.UnitType <> 10S Then
					GoTo IL_63
				End If
				IL_45:
				num2 = 6
				num3 = PU.SprocketDistance - (PU.MaxStroke - RSWIN_DESC.rst.AdjustedStrokeLength)
				IL_63:
				num2 = 8
				If Not(PU.UnitType = 7S Or PU.UnitType = 10S) Then
					GoTo IL_1F9
				End If
				IL_81:
				num2 = 9
				kinemat.Xwtop = CDbl(PU.SprocketRadius) + kinemat.m_P + CDbl(num3)
				IL_9B:
				num2 = 10
				kinemat.Xwbot = kinemat.m_P - CDbl(PU.SprocketRadius)
				IL_B2:
				num2 = 11
				If kinemat.m_P >= 1.0 Then
					GoTo IL_D3
				End If
				IL_C6:
				num2 = 12
				kinemat.Xwa = CDbl(num3)
				IL_D1:
				GoTo IL_110
				IL_D3:
				num2 = 14
				IL_D7:
				num2 = 15
				kinemat.Gamma = kinemat.ArcSine(CSng((CDbl(PU.SprocketRadius) / kinemat.m_P)))
				IL_F4:
				num2 = 16
				kinemat.Xwa = kinemat.m_P * Math.Cos(kinemat.Gamma) + CDbl(num3)
				IL_110:
				num2 = 18
				kinemat.Xwb = kinemat.Xwa - CDbl(num3)
				IL_121:
				num2 = 19
				kinemat.Thetat = CDbl((num3 / PU.SprocketRadius))
				IL_134:
				num2 = 20
				kinemat.Srad = 2.0 * kinemat.Thetat + 2.0 * kinemat.m_PI
				IL_15C:
				num2 = 21
				kinemat.ThA = kinemat.m_PI / 2.0
				IL_174:
				num2 = 22
				kinemat.ThB = kinemat.m_PI / 2.0 + kinemat.Thetat
				IL_192:
				num2 = 23
				kinemat.ThC = kinemat.m_PI / 2.0 + kinemat.Thetat + kinemat.m_PI
				IL_1B6:
				num2 = 24
				kinemat.ThD = kinemat.m_PI / 2.0 + kinemat.Thetat + kinemat.m_PI + kinemat.Thetat
				IL_1E0:
				num2 = 25
				RSWIN_DESC.rst.TotalTheta = CSng(kinemat.Srad)
				IL_1F4:
				GoTo IL_590
				IL_1F9:
				num2 = 27
				IL_1FD:
				num2 = 28
				kinemat.XK2 = kinemat.m_K * kinemat.m_K
				IL_211:
				num2 = 29
				kinemat.XR2 = kinemat.m_R * kinemat.m_R
				IL_225:
				num2 = 30
				kinemat.XC2 = kinemat.m_C * kinemat.m_C
				IL_239:
				num2 = 31
				kinemat.XP2 = kinemat.m_P * kinemat.m_P
				IL_24D:
				num2 = 32
				kinemat.XKR = kinemat.m_K * kinemat.m_R
				IL_261:
				num2 = 33
				kinemat.TwoP = 2.0 * kinemat.m_P
				IL_279:
				num2 = 34
				kinemat.TwoC = 2.0 * kinemat.m_C
				IL_291:
				num2 = 35
				If PU.UnitType = 9S Then
					GoTo IL_2BC
				End If
				IL_2A0:
				num2 = 36
				kinemat.ARoverC = kinemat.m_A * kinemat.m_R / kinemat.m_C
				IL_2BA:
				GoTo IL_2D2
				IL_2BC:
				num2 = 38
				IL_2C0:
				num2 = 39
				kinemat.ARoverC = 0.0
				IL_2D2:
				num2 = 41
				kinemat.TwoCK = 2.0 * kinemat.m_C * kinemat.m_K
				IL_2F0:
				num2 = 42
				kinemat.TwoKR = 2.0 * kinemat.XKR
				IL_308:
				num2 = 43
				kinemat.TwoK = 2.0 * kinemat.m_K
				IL_320:
				num2 = 44
				kinemat.Alpha = kinemat.ArcSine(CSng((kinemat.m_I / kinemat.m_K)))
				IL_33A:
				num2 = 45
				kinemat.Psib = kinemat.ArcCosine(CSng(((kinemat.XC2 + kinemat.XK2 - (kinemat.m_P + kinemat.m_R) * (kinemat.m_P + kinemat.m_R)) / kinemat.TwoCK)))
				IL_372:
				num2 = 46
				kinemat.Psit = kinemat.ArcCosine(CSng(((kinemat.XC2 + kinemat.XK2 - (kinemat.m_P - kinemat.m_R) * (kinemat.m_P - kinemat.m_R)) / kinemat.TwoCK)))
				IL_3AA:
				num2 = 47
				kinemat.Dpsi = kinemat.Psib - kinemat.Psit
				IL_3BE:
				num2 = 48
				RSWIN_DESC.rst.CrankSpeed = CSng((CDbl(RSWIN_DESC.rst.SPM) * 3.141592653589793 / 30.0))
				IL_3EC:
				num2 = 49
				RSWIN_DESC.rst.TotalTheta = CSng((8.0 * Math.Atan(1.0)))
				IL_413:
				num2 = 50
				If PU.UnitType <> 9S Then
					GoTo IL_43A
				End If
				IL_422:
				num2 = 51
				PU.KinematicStroke = PU.R * 2F
				IL_43A:
				GoTo IL_590
				IL_43F:
				num2 = 55
				ProjectData.ClearProjectError()
				If num4 <> 0 Then
					GoTo IL_45B
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_456:
				GoTo IL_590
				IL_45B:
				Dim num5 As Integer = num4
				GoTo IL_461
				IL_45E:
				num5 = num4 + 1
				IL_461:
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_54C:
				GoTo IL_585
				IL_54E:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_563:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_54E
			End Try
			IL_585:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_590:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub fKinconst(PU As RSWIN_DESC.PUDataRec)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 2
				IL_07:
				Dim num2 As Integer = 2
				Dim cJPred As cJPred = MJPred.JPred
				IL_10:
				num2 = 3
				cJPred.PU_A = PU.A
				IL_20:
				num2 = 4
				cJPred.PU_C = PU.C
				IL_30:
				num2 = 5
				cJPred.PU_CrankOffset = PU.CrankOffset
				IL_40:
				num2 = 6
				cJPred.PU_CrankRotation = PU.CrankRotation
				IL_50:
				num2 = 7
				cJPred.PU_DrumDiamRatio = PU.DrumDiamRatio
				IL_60:
				num2 = 8
				cJPred.PU_I = PU.I
				IL_70:
				num2 = 9
				cJPred.PU_K = PU.K
				IL_81:
				num2 = 10
				If RSWIN_DESC.rst.PU.UnitType <> 10S Then
					GoTo IL_AC
				End If
				IL_9B:
				num2 = 11
				cJPred.PU_P = 0F
				IL_AA:
				GoTo IL_C1
				IL_AC:
				num2 = 13
				IL_B0:
				num2 = 14
				cJPred.PU_P = PU.P
				IL_C1:
				num2 = 16
				cJPred.PU_R = PU.R
				IL_D2:
				num2 = 17
				cJPred.PU_SprocketDistance = PU.SprocketDistance
				IL_E3:
				num2 = 18
				cJPred.PU_SprocketRadius = PU.SprocketRadius
				IL_F4:
				num2 = 19
				cJPred.PU_UnitType = PU.UnitType
				IL_105:
				cJPred = Nothing
				IL_107:
				num2 = 21
				Dim jpred As cJPred = MJPred.JPred
				IL_111:
				num2 = 22
				jpred.Kinconst()
				IL_11B:
				num2 = 23
				RSWIN_DESC.rst.TotalTheta = MJPred.JPred.TotalTheta
				IL_133:
				GoTo IL_217
				IL_138:
				num2 = 25
				ProjectData.ClearProjectError()
				If num3 <> 0 Then
					GoTo IL_155
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_150:
				GoTo IL_217
				IL_155:
				Dim num4 As Integer = num3
				GoTo IL_15D
				IL_159:
				num4 = num3 + 1
				IL_15D:
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_1D1:
				GoTo IL_20C
				IL_1D3:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1E9:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1D3
			End Try
			IL_20C:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_217:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub Kinconst(PU As RSWIN_DESC.PUDataRec)
			kinemat.m_PI = 3.141592653589793
			kinemat.m_A = Convert.ToDouble(PU.A)
			kinemat.m_C = Convert.ToDouble(PU.C)
			kinemat.m_I = Convert.ToDouble(PU.I)
			kinemat.m_K = Convert.ToDouble(PU.K)
			kinemat.m_P = Convert.ToDouble(PU.P)
			kinemat.m_R = Convert.ToDouble(PU.R)
			kinemat.bKinconst(PU, kinemat.bShowMessages)
			kinemat.fKinconst(PU)
		End Sub

		Public Sub Kinematics(Theta As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Velocity As Single, PU As RSWIN_DESC.PUDataRec, Optional iTime As Integer = -1, Optional dTheta As Single = 0F)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 2
				IL_07:
				Dim num2 As Integer = 2
				Select Case PU.UnitType
					Case 7S
						IL_29:
						num2 = 6
						kinemat.KinRota(Theta, Prp, Tf, Velocity)
						IL_34:
						GoTo IL_68
					Case 9S
						IL_46:
						num2 = 12
						kinemat.Kinematic_BeltLowProfile(Theta, Prp, Tf, Velocity, PU, iTime, dTheta)
						IL_58:
						GoTo IL_68
					Case 10S
						IL_36:
						num2 = 9
						kinemat.Kinematic_Hydraulic(Theta, Prp, Tf, Velocity, iTime)
						IL_44:
						GoTo IL_68
				End Select
				IL_5A:
				num2 = 15
				kinemat.kinematics1(Theta, Prp, Tf, Velocity, PU)
				IL_68:
				num2 = 17
				If CDbl(Math.Abs(Tf)) >= 0.0001 Then
					GoTo IL_88
				End If
				IL_7E:
				num2 = 18
				Tf = 0F
				IL_88:
				GoTo IL_154
				IL_8D:
				num2 = 21
				ProjectData.ClearProjectError()
				If num3 <> 0 Then
					GoTo IL_A8
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_A3:
				GoTo IL_154
				IL_A8:
				Dim num4 As Integer = num3
				GoTo IL_AE
				IL_AB:
				num4 = num3 + 1
				IL_AE:
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_111:
				GoTo IL_149
				IL_113:
				num3 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_127:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_113
			End Try
			IL_149:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_154:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub Kinematics(Theta As Double, ByRef Prp As Double, ByRef Tf As Double, ByRef Velocity As Double, PU As RSWIN_DESC.PUDataRec, Optional iTime As Integer = -1, Optional dTheta As Single = 0F)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 2
				IL_08:
				Dim num2 As Integer = 2
				Select Case PU.UnitType
					Case 7S
						IL_2E:
						num2 = 6
						Dim theta As Single = CSng(Theta)
						Dim num3 As Single = CSng(Prp)
						Dim num4 As Single = CSng(Tf)
						Dim num5 As Single = CSng(Velocity)
						kinemat.KinRota(theta, num3, num4, num5)
						Velocity = CDbl(num5)
						Tf = CDbl(num4)
						Prp = CDbl(num3)
						IL_56:
						GoTo IL_CD
					Case 9S
						IL_85:
						num2 = 12
						Dim theta2 As Single = CSng(Theta)
						Dim num5 As Single = CSng(Prp)
						Dim num4 As Single = CSng(Tf)
						Dim num3 As Single = CSng(Velocity)
						kinemat.Kinematic_BeltLowProfile(theta2, num5, num4, num3, RSWIN_DESC.rst.PU, iTime, dTheta)
						Velocity = CDbl(num3)
						Tf = CDbl(num4)
						Prp = CDbl(num5)
						IL_BC:
						GoTo IL_CD
					Case 10S
						IL_58:
						num2 = 9
						Dim theta3 As Single = CSng(Theta)
						Dim num5 As Single = CSng(Prp)
						Dim num4 As Single = CSng(Tf)
						Dim num3 As Single = CSng(Velocity)
						kinemat.Kinematic_Hydraulic(theta3, num5, num4, num3, iTime)
						Velocity = CDbl(num3)
						Tf = CDbl(num4)
						Prp = CDbl(num5)
						IL_83:
						GoTo IL_CD
				End Select
				IL_BE:
				num2 = 15
				kinemat.kinematics1(Theta, Prp, Tf, Velocity, PU)
				IL_CD:
				num2 = 17
				If Math.Abs(Tf) >= 0.0001 Then
					GoTo IL_F2
				End If
				IL_E3:
				num2 = 18
				Tf = 0.0
				IL_F2:
				GoTo IL_1C8
				IL_F7:
				num2 = 21
				ProjectData.ClearProjectError()
				If num6 <> 0 Then
					GoTo IL_114
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_10F:
				GoTo IL_1C8
				IL_114:
				Dim num7 As Integer = num6
				GoTo IL_11C
				IL_118:
				num7 = num6 + 1
				IL_11C:
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_180:
				GoTo IL_1BD
				IL_182:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_199:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_182
			End Try
			IL_1BD:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1C8:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub kinematics1(Theta As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Prv As Single, PU As RSWIN_DESC.PUDataRec)
			Dim num As Single = 6.2831855F
			Dim num2 As Single
			If PU.UnitType = 5S Then
				num2 = Theta
			ElseIf PU.CrankRotation = 1S Then
				num2 = Theta
			Else
				num2 = num - Theta
			End If
			Dim num3 As Single
			Select Case PU.UnitType
				Case 5S
					num3 = CSng((3.141592653589793 - CDbl(num2) + kinemat.Alpha))
				Case 6S
					num3 = CSng((3.141592653589793 + CDbl(num2) + kinemat.Alpha))
				Case Else
					num3 = CSng((CDbl((num - num2)) + kinemat.Alpha))
			End Select
			If num3 < 0F Then
				num3 += num
			End If
			If num3 > num Then
				num3 -= num
			End If
			Dim num4 As Single = CSng(Math.Sqrt(kinemat.XK2 + kinemat.XR2 - kinemat.TwoKR * Math.Cos(CDbl(num3))))
			Dim num5 As Single = num4 * num4
			Dim num6 As Single = CSng((kinemat.TwoC * CDbl(num4)))
			Dim num7 As Integer
			If CDbl(num3) < 3.141592653589793 Then
				num7 = 1
			Else
				num7 = -1
			End If
			Dim num8 As Single = CSng((kinemat.ArcCosine(CSng(((CDbl(num5) + kinemat.XK2 - kinemat.XR2) / (kinemat.TwoK * CDbl(num4))))) * CDbl(num7)))
			Dim num9 As Single = CSng((kinemat.ArcCosine(CSng(((kinemat.XC2 + CDbl(num5) - kinemat.XP2) / CDbl(num6)))) + CDbl(num8)))
			Dim num10 As Single = CSng((kinemat.ArcCosine(CSng(((kinemat.XP2 + CDbl(num5) - kinemat.XC2) / (kinemat.TwoP * CDbl(num4))))) - CDbl(num8)))
			Dim num11 As Single = CSng((kinemat.ArcCosine(CSng(((kinemat.XP2 - kinemat.XC2 - CDbl(num5)) / CDbl(num6)))) - CDbl(num8)))
			Dim num12 As Single
			If PU.UnitType = 5S Or PU.UnitType = 6S Then
				num12 = CSng(((kinemat.Psit - CDbl(num9)) / -CSng(kinemat.Dpsi)))
			Else
				num12 = CSng(((kinemat.Psib - CDbl(num9)) / kinemat.Dpsi))
			End If
			Prp = num12 * PU.KinematicStroke
			If Prp = 0F Then
				Tf = 0F
			Else
				Tf = CSng((CDbl((-PU.CrankRotation)) * kinemat.ARoverC * Math.Sin(CDbl((num10 - num3))) / Math.Sin(CDbl((num10 - num11)))))
			End If
			Prv = CSng((CDbl((Tf * RSWIN_DESC.rst.CrankSpeed)) / 12.0))
		End Sub

		Private Sub kinematics1(Theta As Double, ByRef Prp As Double, ByRef Tf As Double, ByRef Prv As Double, PU As RSWIN_DESC.PUDataRec)
			Dim num As Double = 6.283185307179586
			Dim num2 As Double
			If PU.UnitType = 5S Then
				num2 = Theta
			ElseIf PU.CrankRotation = 1S Then
				num2 = Theta
			Else
				num2 = num - Theta
			End If
			Dim num3 As Double
			Select Case PU.UnitType
				Case 5S
					num3 = 3.141592653589793 - num2 + kinemat.Alpha
				Case 6S
					num3 = 3.141592653589793 + num2 + kinemat.Alpha
				Case Else
					num3 = num - num2 + kinemat.Alpha
			End Select
			If num3 < 0.0 Then
				num3 += num
			End If
			If num3 > num Then
				num3 -= num
			End If
			Dim num4 As Double = Math.Sqrt(kinemat.XK2 + kinemat.XR2 - kinemat.TwoKR * Math.Cos(num3))
			Dim num5 As Double = num4 * num4
			Dim num6 As Double = kinemat.TwoC * num4
			Dim num7 As Integer
			If num3 < 3.141592653589793 Then
				num7 = 1
			Else
				num7 = -1
			End If
			Dim num8 As Double = kinemat.ArcCosine(CSng(((num5 + kinemat.XK2 - kinemat.XR2) / (kinemat.TwoK * num4)))) * CDbl(num7)
			Dim num9 As Double = kinemat.ArcCosine(CSng(((kinemat.XC2 + num5 - kinemat.XP2) / num6))) + num8
			Dim num10 As Double = kinemat.ArcCosine(CSng(((kinemat.XP2 + num5 - kinemat.XC2) / (kinemat.TwoP * num4)))) - num8
			Dim num11 As Double = kinemat.ArcCosine(CSng(((kinemat.XP2 - kinemat.XC2 - num5) / num6))) - num8
			Dim num12 As Double
			If PU.UnitType = 5S Or PU.UnitType = 6S Then
				num12 = (kinemat.Psit - num9) / -kinemat.Dpsi
			Else
				num12 = (kinemat.Psib - num9) / kinemat.Dpsi
			End If
			Prp = num12 * CDbl(PU.KinematicStroke)
			If Prp = 0.0 Then
				Tf = 0.0
			Else
				Tf = CDbl((-PU.CrankRotation)) * kinemat.ARoverC * Math.Sin(num10 - num3) / Math.Sin(num10 - num11)
			End If
			Prv = Tf * CDbl(RSWIN_DESC.rst.CrankSpeed) / 12.0
		End Sub

		Public Sub KinInterpolate(ByRef oldSurfPos As Single(), ByRef oldSurfLoad As Single(), ByRef newSurfPos As Single(), ByRef newSurfLoad As Single(), ByRef NtstepsUpstroke As Short, PU As RSWIN_DESC.PUDataRec)
			Dim num As Integer
			Dim num27 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 2
				IL_08:
				Dim num2 As Integer = 2
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				IL_12:
				num2 = 3
				Dim beltLowProfileBOS As Single
				kinemat.ThetaFromPrp_Old(0F, True, beltLowProfileBOS, False)
				IL_23:
				num2 = 4
				If cRODSTAR.PU.UnitType <> 9S Then
					GoTo IL_44
				End If
				IL_3A:
				num2 = 5
				beltLowProfileBOS = RSWIN_DESC.BeltLowProfileBOS
				IL_44:
				num2 = 7
				Dim num3 As Integer = Information.UBound(oldSurfPos, 1) + 1
				IL_52:
				num2 = 8
				Dim num4 As Integer = Information.UBound(newSurfPos, 1) + 1
				IL_61:
				num2 = 9
				Dim array As Single() = New Single(num3 - 1 + 1 - 1) {}
				IL_71:
				num2 = 12
				Dim array2 As Single() = New Single(num3 - 1 + 1 - 1) {}
				IL_81:
				num2 = 15
				Dim num5 As Integer = 0
				IL_87:
				num2 = 16
				Dim num6 As Integer = 0
				Dim num7 As Integer = num3 - 1
				Dim i As Integer
				i = num6
				While i <= num7
					IL_94:
					num2 = 17
					If i = 0 Then
						IL_9C:
						num2 = 18
						array(num5) = oldSurfPos(i)
						IL_A8:
						num2 = 19
						array2(num5) = oldSurfLoad(i)
						IL_B4:
						num2 = 20
						num5 += 1
						IL_BC:
					Else
						IL_BE:
						num2 = 22
						If oldSurfPos(i) <> oldSurfPos(i - 1) Then
							IL_CE:
							num2 = 23
							array(num5) = oldSurfPos(i)
							IL_DA:
							num2 = 24
							array2(num5) = oldSurfLoad(i)
							IL_E6:
							num2 = 25
							num5 += 1
						End If
					End If
					IL_EE:
					num2 = 27
					i += 1
				End While
				IL_FB:
				num2 = 28
				num3 = num5
				IL_101:
				num2 = 29
				array = CType(Utils.CopyArray(CType(array, Array), New Single(num3 - 1 + 1 - 1) {}), Single())
				IL_122:
				num2 = 32
				array2 = CType(Utils.CopyArray(CType(array2, Array), New Single(num3 - 1 + 1 - 1) {}), Single())
				IL_143:
				num2 = 35
				Dim a As Single() = array
				Dim num8 As Single = 0F
				Dim num9 As Single = 0F
				Dim num10 As Single
				Dim num11 As Single
				Util.Maxmin(a, num10, num11, num8, num9)
				IL_164:
				num2 = 36
				Dim num12 As Integer = 0
				Dim num13 As Integer = num3 - 1
				i = num12
				While i <= num13
					IL_171:
					num2 = 37
					array(i) = (array(i) - num11) / (num10 - num11) * PU.KinematicStroke
					IL_18E:
					num2 = 38
					i += 1
				End While
				IL_19B:
				num2 = 39
				Dim num14 As Integer = 1
				Dim num15 As Integer = num3
				i = num14
				While i <= num15
					IL_1A6:
					num2 = 40
					If array(i Mod num3) = array(i - 1) Then
						IL_1B8:
						num2 = 41
						array(i Mod num3) = CSng((CDbl(array(i Mod num3)) + 1E-05))
					End If
					IL_1D4:
					num2 = 43
					i += 1
				End While
				IL_1E1:
				num2 = 44
				Dim a2 As Single() = array
				Dim num16 As Integer
				num9 = CSng(num16)
				Dim num17 As Integer
				num8 = CSng(num17)
				Util.Maxmin(a2, num10, num11, num9, num8)
				num17 = CInt(Math.Round(CDbl(num8)))
				num16 = CInt(Math.Round(CDbl(num9)))
				IL_214:
				num2 = 45
				If Not(PU.UnitType <> 7S And PU.UnitType <> 10S) Then
					GoTo IL_243
				End If
				IL_236:
				num2 = 46
				Dim num18 As Single = 6.2831855F
				IL_241:
				GoTo IL_253
				IL_243:
				num2 = 48
				IL_247:
				num2 = 49
				num18 = CSng(kinemat.Srad)
				IL_253:
				num2 = 51
				i = 0
				IL_259:
				num2 = 52
				Dim num19 As Integer = 0
				IL_260:
				num2 = 53
				Dim value As Single = 0F
				IL_26B:
				num2 = 54
				Dim num20 As Single = num18 / CSng(num4)
				IL_276:
				num2 = 55
				Debug.WriteLine("Theta  ,  Ttf")
				While True
					IL_284:
					num2 = 57
					Dim num23 As Single

						Dim num21 As Single = beltLowProfileBOS + num20 * CSng(i)
						IL_291:
						While True
							IL_29E:
							num2 = 59
							If num21 >= 0F Then
								Exit For
							End If
							IL_293:
							num2 = 60
							num21 += num18
						End While
						IL_2AB:
						While True
							IL_2B8:
							num2 = 63
							If num21 < num18 Then
								Exit For
							End If
							IL_2AD:
							num2 = 64
							num21 -= num18
						End While
						IL_2C2:
						num2 = 66
						Dim num22 As Single = 0F
						IL_2CD:
						num2 = 67
						kinemat.Kinematics(num21, newSurfPos(i), num23, num22, PU, i, 0F)
						IL_2EC:
						num2 = 68
						Debug.WriteLine(Conversions.ToString(num21) + " , " + Conversions.ToString(num23))
						IL_30D:
						num2 = 69
						If i > 2 And Math.Sign(num23) <> Math.Sign(value) Then
							Exit For
						End If
						IL_330:
						num2 = 72

					If newSurfPos(i) <= num11 Then
						IL_33C:
						num2 = 73
						newSurfLoad(i) = array2(num17)
						IL_349:
					Else
						IL_34B:
						num2 = 75
						If newSurfPos(i) >= num10 Then
							IL_357:
							num2 = 76
							newSurfLoad(i) = array2(num16)
							IL_364:
						Else
							IL_366:
							num2 = 78
							IL_36A:
							While True
								IL_376:
								num2 = 80
								If newSurfPos(i) < array(num19 + 1) Then
									Exit For
								End If
								IL_36C:
								num2 = 81
								num19 += 1
							End While
							IL_387:
							num2 = 83
							newSurfLoad(i) = (newSurfPos(i) - array(num19)) / (array(num19 + 1) - array(num19)) * (array2(num19 + 1) - array2(num19)) + array2(num19)
						End If
					End If
					IL_3BB:
					num2 = 85
					i += 1
					IL_3C3:
					num2 = 86
					If i > Information.UBound(newSurfLoad, 1) Then
						Exit For
					End If
					IL_3D2:
					num2 = 89
					value = num23
					IL_3DA:
				End While
				IL_32B:
				IL_3DF:
				num2 = 91
				NtstepsUpstroke = CShort(i)
				IL_3E8:
				num2 = 92
				Dim num24 As Integer = CInt(NtstepsUpstroke)
				Dim num25 As Integer = num4 - 1
				i = num24
				While i <= num25
					IL_3FB:
					num2 = 93

						Dim num21 As Single = beltLowProfileBOS + num18 / CSng(num4) * CSng(i)
						IL_40D:
						While True
							IL_41A:
							num2 = 95
							If num21 >= 0F Then
								Exit For
							End If
							IL_40F:
							num2 = 96
							num21 += num18
						End While
						IL_427:
						While True
							IL_434:
							num2 = 99
							If num21 < num18 Then
								Exit For
							End If
							IL_429:
							num2 = 100
							num21 -= num18
						End While
						IL_43E:
						num2 = 102
						Dim num22 As Single = 0F
						IL_449:
						num2 = 103
						Dim theta As Single = num21
						Dim array3 As Single() = newSurfPos
						Dim num26 As Integer = i
						num9 = 0F
						kinemat.Kinematics(theta, array3(num26), num9, num22, PU, i, 0F)
						IL_46F:
						num2 = 104

					If newSurfPos(i) < num11 Then
						IL_47B:
						num2 = 105
						newSurfLoad(i) = array2(num17)
						IL_488:
					Else
						IL_48D:
						num2 = 107
						If newSurfPos(i) <= num10 Then
							IL_4AB:
							num2 = 110
							While True
								IL_4AF:
								num2 = 112
								If num19 = num3 - 1 Then
									Exit For
								End If
								IL_4BA:
								num2 = 115
								If newSurfPos(i) >= array(num19 + 1) Then
									Exit For
								End If
								IL_4CD:
								num2 = 118
								num19 += 1
								IL_4D7:
							End While
							IL_4D9:
							num2 = 120
							If num19 = num3 - 1 Then
								IL_4E4:
								num2 = 121
								newSurfLoad(i) = (newSurfPos(i) - array(num19)) / (array(0) - array(num19)) * (array2(0) - array2(num19)) + array2(num19)
								IL_512:
								GoTo IL_54C
							End If
							IL_514:
							num2 = 123
							IL_518:
							num2 = 124
							newSurfLoad(i) = (newSurfPos(i) - array(num19)) / (array(num19 + 1) - array(num19)) * (array2(num19 + 1) - array2(num19)) + array2(num19)
							GoTo IL_54C
							IL_4CB:
							GoTo IL_4D9
						End If
						IL_499:
						num2 = 108
						newSurfLoad(i) = array2(num16)
						IL_4A6:
					End If
					IL_54C:
					num2 = 127
					i += 1
				End While
				IL_55C:
				cRODSTAR = Nothing
				IL_55F:
				GoTo IL_7E8
				IL_564:
				num2 = 130
				ProjectData.ClearProjectError()
				If num27 <> 0 Then
					GoTo IL_584
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_57F:
				GoTo IL_7E8
				IL_584:
				Dim num28 As Integer = num27 + 1
				num27 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num28)
				IL_7A0:
				GoTo IL_7DD
				IL_7A2:
				num27 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7B9:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num27 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_7A2
			End Try
			IL_7DD:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7E8:
			If num27 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub TestCurveFit()
			Dim num As Integer = 193
			Dim array As Double() = New Double(num + 1 - 1) {}
			Dim array2 As Double() = New Double(num + 1 - 1) {}
			Dim array3 As Double() = New Double(40) {}
			Dim num2 As Integer = FileSystem.FreeFile()
			FileSystem.FileOpen(num2, "c:\Inputs.txt", OpenMode.Input, OpenAccess.Read, OpenShare.[Default], -1)
			array(0) = 0.0
			Dim num3 As Integer = 0
			Dim num4 As Integer = num - 1
			For i As Integer = num3 To num4
				array(i + 1) = CDbl((i + 1))
				FileSystem.Input(num2, array2(i + 1))
			Next
			FileSystem.FileClose(New Integer() { num2 })
			Dim num5 As Double
			Dim flag As Boolean = kinemat.CurveFit(array, array2, array3, num5)
		End Sub

		Public Sub Kinematics(Theta As Double, ByRef Theta1 As Double, ByRef Prp As Double, ByRef Tf As Double, ByRef Velocity As Double, Optional iTime As Integer = -1, Optional dTheta As Single = 0F)
			Select Case RSWIN_DESC.rst.PU.UnitType
				Case 7S
					Dim theta As Single = CSng(Theta)
					Dim num As Single = CSng(Prp)
					Dim num2 As Single = CSng(Tf)
					Dim num3 As Single = CSng(Velocity)
					kinemat.KinRota(theta, num, num2, num3)
					Velocity = CDbl(num3)
					Tf = CDbl(num2)
					Prp = CDbl(num)
					Return
				Case 9S
					Dim theta2 As Single = CSng(Theta)
					Dim num3 As Single = CSng(Prp)
					Dim num2 As Single = CSng(Tf)
					Dim num As Single = CSng(Velocity)
					kinemat.Kinematic_BeltLowProfile(theta2, num3, num2, num, RSWIN_DESC.rst.PU, iTime, dTheta)
					Velocity = CDbl(num)
					Tf = CDbl(num2)
					Prp = CDbl(num3)
					Return
				Case 10S
					Dim theta3 As Single = CSng(Theta)
					Dim num3 As Single = CSng(Prp)
					Dim num2 As Single = CSng(Tf)
					Dim num As Single = CSng(Velocity)
					kinemat.Kinematic_Hydraulic(theta3, num3, num2, num, iTime)
					Velocity = CDbl(num)
					Tf = CDbl(num2)
					Prp = CDbl(num3)
					Return
			End Select
			kinemat.kinematics1(Theta, Theta1, Prp, Tf, Velocity)
		End Sub

		Private Sub KinRota(Theta As Single, SPM0 As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Velocity As Single)
			Dim flag As Boolean = True
			Dim flag2 As Boolean = True
			Dim num As Double = kinemat.Srad * CDbl(SPM0) / 60.0
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num2 As Single
			Dim num4 As Single
			Dim num5 As Single
			If Theta >= 0F And CDbl(Theta) < kinemat.ThA Then
				num2 = Theta
				If rst.PU.P >= 1F Then
					Dim num3 As Single
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * (Math.Sin(CDbl(num2)) + Math.Cos(CDbl(num2)) * Math.Tan(CDbl(num3)))))
				Else
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * Math.Sin(CDbl(num2))))
				End If
				flag = True
				flag2 = True
			ElseIf CDbl(Theta) >= kinemat.ThA And CDbl(Theta) <= kinemat.ThB Then
				Tf = -rst.PU.SprocketRadius
				num4 = CSng((kinemat.Xwa - CDbl(rst.PU.SprocketRadius) * (CDbl(Theta) - 1.5707963267948966)))
				num5 = CSng((CDbl(Tf) * num))
				flag = False
			ElseIf CDbl(Theta) > kinemat.ThB And CDbl(Theta) < kinemat.ThC Then
				num2 = CSng((CDbl(Theta) - kinemat.Thetat))
				If rst.PU.P >= 1F Then
					Dim num3 As Single
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * (Math.Sin(CDbl(num2)) + Math.Cos(CDbl(num2)) * Math.Tan(CDbl(num3)))))
				Else
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * Math.Sin(CDbl(num2))))
				End If
				flag = True
				flag2 = False
			ElseIf CDbl(Theta) >= kinemat.ThC And CDbl(Theta) < kinemat.ThD Then
				Tf = rst.PU.SprocketRadius
				num4 = CSng((kinemat.Xwb + CDbl(rst.PU.SprocketRadius) * (CDbl(Theta) - kinemat.Thetat - 4.71238898038469)))
				num5 = CSng((CDbl(Tf) * num))
				flag = False
			ElseIf CDbl(Theta) >= kinemat.ThD And CDbl(Theta) <= kinemat.Srad Then
				num2 = CSng((CDbl(Theta) - 2.0 * kinemat.Thetat))
				If rst.PU.P >= 1F Then
					Dim num3 As Single
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * (Math.Sin(CDbl(num2)) + Math.Cos(CDbl(num2)) * Math.Tan(CDbl(num3)))))
				Else
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * Math.Sin(CDbl(num2))))
				End If
				flag = True
				flag2 = True
			End If
			If flag Then
				If rst.PU.P < 1F Then
					num4 = CSng((CDbl(rst.PU.SprocketRadius) * Math.Cos(CDbl(num2))))
					If flag2 Then
						num4 += rst.PU.SprocketDistance
					End If
					num5 = CSng((CDbl(Tf) * num))
				Else
					Dim num3 As Single = CSng(kinemat.asn(CSng((CDbl(rst.PU.SprocketRadius) * Math.Sin(CDbl(num2)) / CDbl(rst.PU.P)))))
					num4 = CSng((CDbl(rst.PU.SprocketRadius) * Math.Cos(CDbl(num2)) + CDbl(rst.PU.P) * Math.Cos(CDbl(num3))))
					If flag2 Then
						num4 += rst.PU.SprocketDistance
					End If
					num5 = CSng((CDbl(Tf) * num))
				End If
			End If
			Tf = -Tf
			If RSWIN_DESC.rst.StrokeFeet = 0F Then
				RSWIN_DESC.rst.StrokeFeet = rst.PU.KinematicStroke / 12F
			End If
			Prp = CSng(((kinemat.Xwtop - CDbl(num4)) / CDbl(rst.PU.KinematicStroke) * CDbl(RSWIN_DESC.rst.StrokeFeet)))
			Velocity = -num5 / 12F
		End Sub

		Private Sub Kinematic_Hydraulic(Theta As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Velocity As Single, iTimeStep As Integer)
			Dim num As Single = RSWIN_DESC.rst.PU.SprocketDistance - (RSWIN_DESC.rst.PU.MaxStroke - RSWIN_DESC.rst.AdjustedStrokeLength)
			Dim num2 As Single = RSWIN_DESC.rst.PercentUpstrokeSPM / 100F
			Dim num3 As Single = RSWIN_DESC.rst.PercentDownstrokeSPM / 100F
			Dim num4 As Single
			If iTimeStep = -1 Or RSWIN_DESC.rst.NtstepsUpstroke = 0S Then
				num4 = RSWIN_DESC.rst.SPM
			ElseIf iTimeStep <= CInt((RSWIN_DESC.rst.NtstepsUpstroke - 1S)) Then
				num4 = RSWIN_DESC.rst.SPM / (2F * num2)
			Else
				num4 = RSWIN_DESC.rst.SPM / (2F * num3)
			End If
			Dim flag As Boolean = True
			Dim flag2 As Boolean = True
			Dim num5 As Double = kinemat.Srad * CDbl(num4) / 60.0
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num6 As Single
			Dim num8 As Single
			Dim num9 As Single
			If Theta >= 0F And CDbl(Theta) < kinemat.ThA Then
				num6 = Theta
				If rst.PU.P >= 1F Then
					Dim num7 As Single
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * (Math.Sin(CDbl(num6)) + Math.Cos(CDbl(num6)) * Math.Tan(CDbl(num7)))))
				Else
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * Math.Sin(CDbl(num6))))
				End If
				flag = True
				flag2 = True
			ElseIf CDbl(Theta) >= kinemat.ThA And CDbl(Theta) <= kinemat.ThB Then
				Tf = -rst.PU.SprocketRadius
				num8 = CSng((kinemat.Xwa - CDbl(rst.PU.SprocketRadius) * (CDbl(Theta) - 1.5707963267948966)))
				num9 = CSng((CDbl(Tf) * num5))
				flag = False
			ElseIf CDbl(Theta) > kinemat.ThB And CDbl(Theta) < kinemat.ThC Then
				num6 = CSng((CDbl(Theta) - kinemat.Thetat))
				If rst.PU.P >= 1F Then
					Dim num7 As Single
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * (Math.Sin(CDbl(num6)) + Math.Cos(CDbl(num6)) * Math.Tan(CDbl(num7)))))
				Else
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * Math.Sin(CDbl(num6))))
				End If
				flag = True
				flag2 = False
			ElseIf CDbl(Theta) >= kinemat.ThC And CDbl(Theta) < kinemat.ThD Then
				Tf = rst.PU.SprocketRadius
				num8 = CSng((kinemat.Xwb + CDbl(rst.PU.SprocketRadius) * (CDbl(Theta) - kinemat.Thetat - 4.71238898038469)))
				num9 = CSng((CDbl(Tf) * num5))
				flag = False
			ElseIf CDbl(Theta) >= kinemat.ThD And CDbl(Theta) <= kinemat.Srad Then
				num6 = CSng((CDbl(Theta) - 2.0 * kinemat.Thetat))
				If rst.PU.P >= 1F Then
					Dim num7 As Single
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * (Math.Sin(CDbl(num6)) + Math.Cos(CDbl(num6)) * Math.Tan(CDbl(num7)))))
				Else
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * Math.Sin(CDbl(num6))))
				End If
				flag = True
				flag2 = True
			End If
			If flag Then
				If rst.PU.P < 1F Then
					num8 = CSng((CDbl(rst.PU.SprocketRadius) * Math.Cos(CDbl(num6))))
					If flag2 Then
						num8 += num
					End If
					num9 = CSng((CDbl(Tf) * num5))
				Else
					Dim num7 As Single = CSng(kinemat.asn(CSng((CDbl(rst.PU.SprocketRadius) * Math.Sin(CDbl(num6)) / CDbl(rst.PU.P)))))
					num8 = CSng((CDbl(rst.PU.SprocketRadius) * Math.Cos(CDbl(num6)) + CDbl(rst.PU.P) * Math.Cos(CDbl(num7))))
					If flag2 Then
						num8 += num
					End If
					num9 = CSng((CDbl(Tf) * num5))
				End If
			End If
			Tf = -Tf
			If RSWIN_DESC.rst.StrokeFeet = 0F Then
				RSWIN_DESC.rst.StrokeFeet = rst.PU.KinematicStroke / 12F
			End If
			Prp = CSng(((kinemat.Xwtop - CDbl(num8)) / CDbl(rst.PU.KinematicStroke) * CDbl(RSWIN_DESC.rst.StrokeFeet)))
			Velocity = -num9 / 12F
		End Sub

		Private Sub KinRota(Theta As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Velocity As Single)
			Dim flag As Boolean = True
			Dim flag2 As Boolean = True
			Dim num As Double = kinemat.Srad * CDbl(RSWIN_DESC.rst.SPM) / 60.0
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num2 As Single
			Dim num4 As Single
			Dim num5 As Single
			If Theta >= 0F And CDbl(Theta) < kinemat.ThA Then
				num2 = Theta
				If rst.PU.P >= 1F Then
					Dim num3 As Single
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * (Math.Sin(CDbl(num2)) + Math.Cos(CDbl(num2)) * Math.Tan(CDbl(num3)))))
				Else
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * Math.Sin(CDbl(num2))))
				End If
				flag = True
				flag2 = True
			ElseIf CDbl(Theta) >= kinemat.ThA And CDbl(Theta) <= kinemat.ThB Then
				Tf = -rst.PU.SprocketRadius
				num4 = CSng((kinemat.Xwa - CDbl(rst.PU.SprocketRadius) * (CDbl(Theta) - 1.5707963267948966)))
				num5 = CSng((CDbl(Tf) * num))
				flag = False
			ElseIf CDbl(Theta) > kinemat.ThB And CDbl(Theta) < kinemat.ThC Then
				num2 = CSng((CDbl(Theta) - kinemat.Thetat))
				If rst.PU.P >= 1F Then
					Dim num3 As Single
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * (Math.Sin(CDbl(num2)) + Math.Cos(CDbl(num2)) * Math.Tan(CDbl(num3)))))
				Else
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * Math.Sin(CDbl(num2))))
				End If
				flag = True
				flag2 = False
			ElseIf CDbl(Theta) >= kinemat.ThC And CDbl(Theta) < kinemat.ThD Then
				Tf = rst.PU.SprocketRadius
				num4 = CSng((kinemat.Xwb + CDbl(rst.PU.SprocketRadius) * (CDbl(Theta) - kinemat.Thetat - 4.71238898038469)))
				num5 = CSng((CDbl(Tf) * num))
				flag = False
			ElseIf CDbl(Theta) >= kinemat.ThD And CDbl(Theta) <= kinemat.Srad Then
				num2 = CSng((CDbl(Theta) - 2.0 * kinemat.Thetat))
				If rst.PU.P >= 1F Then
					Dim num3 As Single
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * (Math.Sin(CDbl(num2)) + Math.Cos(CDbl(num2)) * Math.Tan(CDbl(num3)))))
				Else
					Tf = CSng((CDbl((-CDbl(rst.PU.SprocketRadius))) * Math.Sin(CDbl(num2))))
				End If
				flag = True
				flag2 = True
			End If
			If flag Then
				If rst.PU.P < 1F Then
					num4 = CSng((CDbl(rst.PU.SprocketRadius) * Math.Cos(CDbl(num2))))
					If flag2 Then
						num4 += rst.PU.SprocketDistance
					End If
					num5 = CSng((CDbl(Tf) * num))
				Else
					Dim num3 As Single = CSng(kinemat.asn(CSng((CDbl(rst.PU.SprocketRadius) * Math.Sin(CDbl(num2)) / CDbl(rst.PU.P)))))
					num4 = CSng((CDbl(rst.PU.SprocketRadius) * Math.Cos(CDbl(num2)) + CDbl(rst.PU.P) * Math.Cos(CDbl(num3))))
					If flag2 Then
						num4 += rst.PU.SprocketDistance
					End If
					num5 = CSng((CDbl(Tf) * num))
				End If
			End If
			Tf = -Tf
			If RSWIN_DESC.rst.StrokeFeet = 0F Then
				RSWIN_DESC.rst.StrokeFeet = rst.PU.KinematicStroke / 12F
			End If
			Prp = CSng(((kinemat.Xwtop - CDbl(num4)) / CDbl(rst.PU.KinematicStroke) * CDbl(RSWIN_DESC.rst.StrokeFeet)))
			Velocity = -num5 / 12F
		End Sub

		Private Function asn(X As Single) As Double
			Dim result As Double
			If Math.Abs(X) >= 1F Then
				result = 1.5707963267948966 * CDbl(Math.Sign(X))
			Else
				result = Math.Atan(CDbl(X) / Math.Sqrt(CDbl((1F - X * X))))
			End If
			Return result
		End Function

		Private Sub kinematics1(Theta As Double, ByRef Theta1 As Double, ByRef Prp As Double, ByRef Tf As Double, ByRef Velocity As Double)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Double = 6.283185307179586
			If rst.PU.UnitType = 5S Then
				Theta1 = Theta
			ElseIf rst.PU.CrankRotation = 1S Then
				Theta1 = Theta
			Else
				Theta1 = num - Theta
			End If
			Dim num2 As Double
			Select Case rst.PU.UnitType
				Case 5S
					num2 = kinemat.m_PI - Theta1 + kinemat.Alph
				Case 6S
					num2 = kinemat.m_PI + Theta1 + kinemat.Alph
				Case Else
					num2 = num - Theta1 + kinemat.Alph
			End Select
			If num2 < 0.0 Then
				num2 += num
			End If
			If num2 > num Then
				num2 -= num
			End If
			Dim num3 As Double = Math.Sqrt(kinemat.XKsqr + kinemat.XRsqr - kinemat.TwoKR * Math.Cos(num2))
			Dim num4 As Double = num3 * num3
			Dim num5 As Double = kinemat.TwoC * num3
			Dim num6 As Short
			If num2 < kinemat.m_PI Then
				num6 = 1S
			Else
				num6 = -1S
			End If
			Dim num7 As Double = Math.Acos((num4 + kinemat.XKsqr - kinemat.XRsqr) / (kinemat.TwoK * num3)) * CDbl(num6)
			Dim num8 As Double = Math.Acos((kinemat.XCsqr + num4 - kinemat.XPsqr) / num5) + num7
			Dim num9 As Double = Math.Acos((kinemat.XPsqr + num4 - kinemat.XCsqr) / (kinemat.TwoP * num3)) - num7
			Dim num10 As Double = Math.Acos((kinemat.XPsqr - kinemat.XCsqr - num4) / num5) - num7
			Tf = CDbl((-rst.PU.CrankRotation)) * kinemat.ARoverC * Math.Sin(num9 - num2) / Math.Sin(num9 - num10)
			Dim num11 As Double
			Select Case rst.PU.UnitType
				Case 5S, 6S
					num11 = (kinemat.Psit - num8) / -kinemat.Dpsi
				Case Else
					num11 = (kinemat.Psib - num8) / kinemat.Dpsi
			End Select
			Prp = num11 * CDbl(rst.PU.KinematicStroke)
			Dim num12 As Double = kinemat.m_PI * CDbl(rst.SPM) * CDbl(rst.PU.CrankRotation) / 30.0
			Velocity = CDbl(rst.PU.CrankRotation) * Tf * num12 / 12.0
		End Sub

		Public Sub Kinematic_BeltLowProfile(Theta As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Velocity As Single, PU As RSWIN_DESC.PUDataRec, iTime As Integer, dTheta As Single)
			Try
				Dim num As Single = CSng((CDbl(RSWIN_DESC.rst.SPM) * 3.141592653589793 / 30.0))
				Dim c As Single = PU.C
				Dim i As Single = PU.I
				Dim k As Single = PU.K
				Dim r As Single = PU.R
				Dim num2 As Single = CSng((Math.Sin(Math.Acos(CDbl((i / k)))) * CDbl(k)))
				Dim num3 As Single = k + r
				Dim num4 As Single = k - r
				Dim num5 As Single = 2F * r
				PU.KinematicStroke = num5
				Dim num6 As Single = num2 + c / 2F
				Dim num7 As Single = CSng(Math.Atan(CDbl((num6 / i))))
				If num7 < 0F Then
					num7 = Math.Abs(num7)
				End If
				If RSWIN_DESC.rst.PU.CrankRotation = 1S Then
					Theta = Theta
				Else
					Theta = CSng((6.283185307179586 - CDbl(Theta)))
				End If
				Dim num8 As Single = CSng((1.5707963267948966 - CDbl(num7) - CDbl(Theta)))
				Dim num9 As Single = CSng(Math.Sqrt(Math.Pow(CDbl(k), 2.0) + Math.Pow(CDbl(r), 2.0) - CDbl((2F * k * r)) * Math.Cos(CDbl(Theta))))
				Prp = (num4 - num9) / -num5
				Dim num10 As Single = CSng(Math.Acos((Math.Pow(CDbl(num9), 2.0) + Math.Pow(CDbl(r), 2.0) - Math.Pow(CDbl(k), 2.0)) / CDbl((2F * num9 * r))))
				Tf = CSng((CDbl(r) * Math.Sin(CDbl(num10))))
				If RSWIN_DESC.rst.PU.CrankRotation = 1S Then
					If CDbl(Theta) < 6.283185307179586 And CDbl(Theta) > 3.141592653589793 Then
						Tf = -Tf
					End If
				ElseIf Theta > 0F And CDbl(Theta) < 3.141592653589793 Then
					Tf = -Tf
				End If
				num9 = num4 + Prp * num5
				num8 = CSng(Math.Acos((Math.Pow(CDbl(k), 2.0) + Math.Pow(CDbl(r), 2.0) - Math.Pow(CDbl(num9), 2.0)) / CDbl((2F * k * r))))
				If CDbl(Theta) > 3.141592653589793 And CDbl(Theta) < 6.283185307179586 Then
					num8 = -num8
				End If
				Dim num11 As Single = num8
				If num11 < 0F Then
					num11 = CSng((CDbl(num11) + 6.283185307179586))
				End If
				If CDbl(num11) > 6.283185307179586 Then
					num11 = CSng((CDbl(num11) - 6.283185307179586))
				End If
				Velocity = Tf * num / 12F
				Prp = PU.KinematicStroke * Prp
			Catch ex As Exception
			End Try
		End Sub

		Private Alpha As Double

		Private XR2 As Double

		Private XC2 As Double

		Private XK2 As Double

		Private XP2 As Double

		Private XKR As Double

		Private TwoP As Double

		Private TwoC As Double

		Private ARoverC As Double

		Private TwoCK As Double

		Private TwoKR As Double

		Private TwoK As Double

		Private Psib As Double

		Private Psit As Double

		Private Dpsi As Double

		Private RotationInConvention As Integer

		Private Srad As Double

		Private Xwa As Double

		Private Xwb As Double

		Private Xwtop As Double

		Private Xwbot As Double

		Private Gamma As Double

		Private Thetat As Double

		Private ThA As Double

		Private ThB As Double

		Private ThC As Double

		Private ThD As Double

		Private m_PI As Double

		Private m_A As Double

		Private m_C As Double

		Private m_I As Double

		Private m_K As Double

		Private m_P As Double

		Private m_R As Double

		Private Alph As Double

		Private XCsqr As Double

		Private XKsqr As Double

		Private XPsqr As Double

		Private XRsqr As Double

		Private bShowMessages As Boolean
	End Module
End Namespace
