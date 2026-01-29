Imports System
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module IPR
		Public Function iprPipFromPwf(Pwf As Single) As Single
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Single
			If rst.PumpDepth >= rst.MidPerfDepth Then
				num = 0F
			Else
				num = rst.MidPerfDepth - rst.PumpDepth
			End If
			Return CSng((CDbl(Pwf) - CDbl(num) * 0.433 * CDbl(rst.FluidSPGR)))
		End Function

		Public Function iprProductionFromPwf(ByRef Pwf As Single) As Single
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim result As Single
			Select Case rst.giIPRMethod
				Case 0S
					If rst.StaticBHPressure <= rst.BubblePoint Or rst.gbProducingBelowBPP Then
						result = CSng((CDbl(IPR.J0Prime) * Math.Pow(Math.Pow(CDbl(rst.StaticBHPressure), 2.0) - Math.Pow(CDbl(Pwf), 2.0), CDbl(rst.FetkovichN))))
					ElseIf Pwf <= rst.BubblePoint Then
						result = CSng((CDbl((IPR.J0 * (rst.StaticBHPressure - rst.BubblePoint))) + CDbl(IPR.J0Prime) * Math.Pow(Math.Pow(CDbl(rst.BubblePoint), 2.0) - Math.Pow(CDbl(Pwf), 2.0), CDbl(rst.FetkovichN))))
					Else
						result = IPR.J0 * (rst.StaticBHPressure - Pwf)
					End If
				Case 1S
					If rst.gbProducingBelowBPP Or rst.TestPoints(1).Pwf < rst.BubblePoint Then
						Dim num As Single = CSng((1.0 - 0.2 * CDbl((rst.TestPoints(1).Pwf / rst.StaticBHPressure)) - 0.8 * Math.Pow(CDbl((rst.TestPoints(1).Pwf / rst.StaticBHPressure)), 2.0)))
						Dim num2 As Single = rst.TestPoints(1).Production * IPR.OilCut / num
						result = CSng((CDbl(num2) * (1.0 - 0.2 * CDbl((Pwf / rst.StaticBHPressure)) - 0.8 * Math.Pow(CDbl((Pwf / rst.StaticBHPressure)), 2.0))))
					Else
						Dim num3 As Single = rst.TestPoints(1).Production / (rst.StaticBHPressure - rst.TestPoints(1).Pwf)
						Dim num4 As Single = (rst.TestPoints(1).Pwf - rst.BubblePoint) * num3 * IPR.OilCut + rst.TestPoints(1).Production * IPR.OilCut
						Dim num As Single = CSng((1.0 - 0.2 * CDbl((rst.BubblePoint / rst.StaticBHPressure)) - 0.8 * Math.Pow(CDbl((rst.BubblePoint / rst.StaticBHPressure)), 2.0)))
						Dim num2 As Single = num4 / num
						result = CSng((CDbl(num2) * (1.0 - 0.2 * CDbl((Pwf / rst.StaticBHPressure)) - 0.8 * Math.Pow(CDbl((Pwf / rst.StaticBHPressure)), 2.0))))
					End If
			End Select
			Return result
		End Function

		Public Function iprPwfFromFluidProduction(Production As Single) As Single
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Single = IPR.iprPwfFromPip(rst.CasingPressure)
			Dim num2 As Single = rst.StaticBHPressure
			Dim num3 As Integer = 0
			Dim num4 As Single
			Dim num7 As Single
			Do
				' The following expression was wrapped in a checked-statement
				num3 += 1
				num4 = (num + num2) / 2F
				Dim num5 As Single = IPR.iprProductionFromPwf(num4)
				Dim num6 As Single = (rst.StaticBHPressure - num4) * rst.WaterPI
				num7 = num5 + num6
				If num7 > Production Then
					num = num4
				Else
					num2 = num4
				End If
			Loop While Not(num = num2 Or num7 = Production Or num3 > 100)
			Return num4
		End Function

		Public Function iprPwfFromPip(Pip As Single) As Single
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Single
			If rst.PumpDepth >= rst.MidPerfDepth Then
				num = 0F
			Else
				num = rst.MidPerfDepth - rst.PumpDepth
			End If
			Return CSng((CDbl(Pip) + CDbl(num) * 0.433 * CDbl(rst.FluidSPGR)))
		End Function

		Public Sub iprSetup()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.WaterPI = rst.TestPoints(1).Production * rst.WaterCut / 100F / (rst.StaticBHPressure - rst.TestPoints(1).Pwf)
			IPR.OilCut = 1F - rst.WaterCut / 100F
			Dim giIPRMethod As Short = rst.giIPRMethod
			If giIPRMethod = 0S AndAlso rst.gbCalcFetkovichN Then
				If rst.gnTestPoints <= 1S Then
					rst.FetkovichN = 1F
					If rst.gbProducingBelowBPP Or rst.TestPoints(1).Pwf <= rst.BubblePoint Then
						IPR.J0Prime = CSng((CDbl((rst.TestPoints(1).Production * IPR.OilCut)) / Math.Pow(Math.Pow(CDbl(rst.StaticBHPressure), 2.0) - Math.Pow(CDbl(rst.TestPoints(1).Pwf), 2.0), CDbl(rst.FetkovichN))))
						IPR.J0 = IPR.J0Prime * 2F * rst.BubblePoint
					Else
						IPR.J0 = rst.TestPoints(1).Production * IPR.OilCut / (rst.StaticBHPressure - rst.TestPoints(1).Pwf)
						IPR.J0Prime = IPR.J0 / (2F * rst.BubblePoint)
					End If
				Else
					Dim num As Single = CSng(Math.Pow(CDbl(rst.StaticBHPressure), 2.0))
					Dim num4 As Single
					Dim num5 As Single
					Dim array As Single() = New Single(CInt((rst.gnTestPoints - 1S + 1S)) - 1) {}
					Dim array2 As Single() = New Single(CInt((rst.gnTestPoints - 1S + 1S)) - 1) {}
					Dim num2 As Integer = 0
					Dim num3 As Integer = CInt((rst.gnTestPoints - 1S))
					For i As Integer = num2 To num3

							' The following expression was wrapped in a checked-expression
							array(i) = CSng(Math.Log(CDbl((rst.TestPoints(i + 1).Production * IPR.OilCut))))
							array2(i) = CSng(Math.Log(CDbl(num) - Math.Pow(CDbl(rst.TestPoints(i + 1).Pwf), 2.0)))

					Next
					IPR.LeastSquaresFit(array, array2, num4, num5)
					rst.FetkovichN = 1F / num4
					Dim num6 As Single = -num5 / num4
					IPR.J0Prime = CSng(Math.Exp(CDbl(num6)))
					IPR.J0 = IPR.J0Prime * 2F * rst.BubblePoint
				End If
			End If
		End Sub

		Public Sub LeastSquaresFit(ByRef X As Single(), ByRef Y As Single(), ByRef rfSlope As Single, ByRef rfYintercept As Single)
			Dim num As Integer = Information.LBound(X, 1)
			Dim num2 As Integer = Information.UBound(X, 1)
			If num <> Information.LBound(Y, 1) Or num2 <> Information.UBound(Y, 1) Or num = num2 Then
				Util.Errmsg("Array shape mismatch in LeastSquaresFit.")
				rfSlope = 0F
				rfYintercept = 0F
				Return
			End If
			Dim num3 As Integer
			Dim num4 As Single
			Dim num5 As Single
			Dim num6 As Single
			Dim num7 As Single
			num3 = num2 - num + 1
			num4 = 0F
			num5 = 0F
			num6 = 0F
			num7 = 0F
			Dim num8 As Integer = num
			Dim num9 As Integer = num2
			For i As Integer = num8 To num9

					num4 += X(i)
					num5 += Y(i)
					num6 += X(i) * Y(i)
					num7 += X(i) * X(i)

			Next
			rfSlope = (CSng(num3) * num6 - num4 * num5) / (CSng(num3) * num7 - num4 * num4)
			rfYintercept = (num7 * num5 - num4 * num6) / (CSng(num3) * num7 - num4 * num4)
		End Sub

		Public Function CheckIPR_AI(ByRef fTargetBFPD As Single, gbCalcTargetBFPD As Boolean) As Boolean
			Dim flag As Boolean
			Try
				fTargetBFPD = -1F
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				flag = (rst.MidPerfDepth >= 0F)
				flag = flag And (rst.StaticBHPressure > 0F)
				flag = flag And (rst.gbProducingBelowBPP Or rst.BubblePoint > 0F)
				flag = flag And (rst.gnTestPoints >= 1S)
				Dim num As Short = 1S
				Dim gnTestPoints As Short = rst.gnTestPoints
				For num2 As Short = num To gnTestPoints
					flag = flag And (rst.TestPoints(CInt(num2)).Pintake >= 0F Or rst.TestPoints(CInt(num2)).Pwf >= 0F)
					flag = flag And (rst.TestPoints(CInt(num2)).Production > 0F)
				Next
				If flag Then
					Dim num3 As Short = 1S
					Dim gnTestPoints2 As Short = rst.gnTestPoints
					For num2 As Short = num3 To gnTestPoints2
						If RSWIN_DESC.rst.TestPoints(CInt(num2)).bPIEntered <> 0S Then
							RSWIN_DESC.rst.TestPoints(CInt(num2)).Pwf = IPR.iprPwfFromPip(RSWIN_DESC.rst.TestPoints(CInt(num2)).Pintake)
						Else
							RSWIN_DESC.rst.TestPoints(CInt(num2)).Pintake = IPR.iprPipFromPwf(RSWIN_DESC.rst.TestPoints(CInt(num2)).Pwf)
						End If
						If RSWIN_DESC.rst.TestPoints(CInt(num2)).Pwf >= rst.StaticBHPressure Then
							flag = False
						ElseIf CDbl(RSWIN_DESC.rst.TestPoints(CInt(num2)).Pintake) < CDbl(rst.CasingPressure) + 14.7 Then
							flag = False
						End If
					Next
				End If
				If flag Then
					Dim num4 As Short = 1S
					Dim num5 As Short = rst.gnTestPoints - 1S
					For num2 As Short = num4 To num5
						' The following expression was wrapped in a checked-expression
						Dim num6 As Single = rst.TestPoints(CInt(num2)).Pwf - rst.TestPoints(CInt((num2 + 1S))).Pwf
						If num6 < 0F Then
							If rst.TestPoints(CInt(num2)).Production <= rst.TestPoints(CInt((num2 + 1S))).Production Then
								flag = False
							End If
						ElseIf num6 > 0F Then
							If rst.TestPoints(CInt(num2)).Production >= rst.TestPoints(CInt((num2 + 1S))).Production Then
								flag = False
							End If
						Else
							flag = False
							If rst.TestPoints(CInt(num2)).Production = rst.TestPoints(CInt((num2 + 1S))).Production Then
							End If
						End If
						If Not flag Then
							Exit For
						End If
					Next
				End If
				If Not flag Then
					If rst.gbCalcFetkovichN Then
						rst.FetkovichN = -1F
					End If
				Else
					IPR.iprSetup()
					Dim num7 As Single = IPR.iprPwfFromPip(rst.CasingPressure)
					If Not rst.SPMEntered <> 0S Then
						If rst.gbCalcPumpIntakePressure Then
							rst.PumpIntakePressure = IPR.iprPipFromPwf(IPR.iprPwfFromFluidProduction(rst.TargetBFPD))
						ElseIf gbCalcTargetBFPD Then
							If rst.FluidLevelEntered Then
								rst.PumpIntakePressure = CSng((0.433 * CDbl(rst.OilSPGR) * CDbl((rst.PumpDepth - rst.FluidLevel)) + CDbl(rst.CasingPressure) + 14.7))
							End If
							Dim num8 As Single = IPR.iprPwfFromPip(rst.PumpIntakePressure)
							If num8 > rst.StaticBHPressure Then
								fTargetBFPD = -1F
							Else
								fTargetBFPD = IPR.iprProductionFromPwf(num8) + rst.WaterPI * (rst.StaticBHPressure - num8)
							End If
						End If
					End If
				End If
			Catch ex As Exception
			End Try
			Return flag
		End Function

		Private J0 As Single

		Private J0Prime As Single

		Private OilCut As Single
	End Module
End Namespace
