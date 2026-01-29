Imports System
Imports System.Diagnostics
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module LOADRDG
		Private Sub LoadOutputData_new(ByRef frn As Object, ByRef ThisVersion As Short, ByRef bOutputLoaded As Boolean)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				bOutputLoaded = False
				rst.gbOutputLoaded = False
				If ThisVersion < 13S Then
					bOutputLoaded = True
				Else
					' The following expression was wrapped in a checked-expression
					Dim num As Integer = CInt(FileSystem.Seek(Conversions.ToInteger(frn)))
					If CLng(num) >= FileSystem.LOF(Conversions.ToInteger(frn)) - 1L Then
						bOutputLoaded = True
					Else
						' The following expression was wrapped in a checked-expression
						FileSystem.Seek(Conversions.ToInteger(frn), FileSystem.LOF(Conversions.ToInteger(frn)) - 1L)
						Dim num2 As Short
						FileSystem.FileGet(Conversions.ToInteger(frn), num2, -1L)
						If Not num2 <> 0S Then
							bOutputLoaded = True
						Else
							FileSystem.Seek(Conversions.ToInteger(frn), CLng(num))
							Dim fileNumber As Integer = Conversions.ToInteger(frn)
							Dim cRODSTAR As cRODSTAR = rst
							Dim num3 As Single = cRODSTAR.BPDsurface
							FileSystem.FileGet(fileNumber, num3, -1L)
							cRODSTAR.BPDsurface = num3
							Debug.WriteLine(" BPDsurface = " + Conversions.ToString(rst.BPDsurface))
							Dim fileNumber2 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.GrossPumpStroke
							FileSystem.FileGet(fileNumber2, num3, -1L)
							cRODSTAR.GrossPumpStroke = num3
							Dim fileNumber3 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.MaxRodStressL
							FileSystem.FileGet(fileNumber3, num3, -1L)
							cRODSTAR.MaxRodStressL = num3
							Dim fileNumber4 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.MinMotorHP
							FileSystem.FileGet(fileNumber4, num3, -1L)
							cRODSTAR.MinMotorHP = num3
							Dim fileNumber5 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.Mprload
							FileSystem.FileGet(fileNumber5, num3, -1L)
							cRODSTAR.Mprload = num3
							Dim fileNumber6 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							Dim num4 As Short = cRODSTAR.Ntsteps
							FileSystem.FileGet(fileNumber6, num4, -1L)
							cRODSTAR.Ntsteps = num4
							Dim fileNumber7 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num4 = cRODSTAR.NtstepsUpstroke
							FileSystem.FileGet(fileNumber7, num4, -1L)
							cRODSTAR.NtstepsUpstroke = num4
							Dim fileNumber8 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.Prhp
							FileSystem.FileGet(fileNumber8, num3, -1L)
							cRODSTAR.Prhp = num3
							Dim fileNumber9 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.Pprload
							FileSystem.FileGet(fileNumber9, num3, -1L)
							cRODSTAR.Pprload = num3
							Dim fileNumber10 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.StructL
							FileSystem.FileGet(fileNumber10, num3, -1L)
							cRODSTAR.StructL = num3
							Dim fileNumber11 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.USystemEff
							FileSystem.FileGet(fileNumber11, num3, -1L)
							cRODSTAR.USystemEff = num3
							Dim fileNumber12 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.TotalTheta
							FileSystem.FileGet(fileNumber12, num3, -1L)
							cRODSTAR.TotalTheta = num3
							Dim fileNumber13 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.WrodsInFluid
							FileSystem.FileGet(fileNumber13, num3, -1L)
							cRODSTAR.WrodsInFluid = num3
							Dim num5 As Short
							Dim array2 As Single()
							Dim array3 As Single()
							Dim array4 As Single()
							Dim array5 As Single()
							Dim array6 As Single()
							Dim array7 As Single()
							Dim array8 As Single()
							Dim num10 As Short
							Dim num11 As Short
							Dim array As Single(,) = New Single(2, CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							num5 = 0S
							Do
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.CBE90(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.Clf(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.DollarsPerBblFluid(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.DollarsPerBblOil(CInt(num5)), -1L)
								Dim fileNumber14 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								Dim cRODSTAR2 As cRODSTAR = cRODSTAR
								num4 = num5
								num3 = cRODSTAR2.get_ElectricBillperMonth(CInt(num4))
								FileSystem.FileGet(fileNumber14, num3, -1L)
								cRODSTAR.set_ElectricBillperMonth(CInt(num4), num3)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.GearboxLoading(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.HpNemaD(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.HpUhs(CInt(num5)), -1L)
								If(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And ThisVersion >= 25S Then
									Dim fileNumber15 As Integer = Conversions.ToInteger(frn)
									cRODSTAR = rst
									Dim cRODSTAR3 As cRODSTAR = cRODSTAR
									num4 = num5
									num3 = cRODSTAR3.get_RequiredUnbalance(CInt(num4))
									FileSystem.FileGet(fileNumber15, num3, -1L)
									cRODSTAR.set_RequiredUnbalance(CInt(num4), num3)
								Else
									Dim fileNumber16 As Integer = Conversions.ToInteger(frn)
									cRODSTAR = rst
									Dim cRODSTAR4 As cRODSTAR = cRODSTAR
									num4 = num5
									num3 = cRODSTAR4.get_M(CInt(num4))
									FileSystem.FileGet(fileNumber16, num3, -1L)
									cRODSTAR.set_M(CInt(num4), num3)
								End If
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.MotorKWH(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.PeakTorque(CInt(num5)), -1L)
								Dim num6 As Integer = CInt(FileSystem.Seek(Conversions.ToInteger(frn)))
								Dim num7 As Short = 0S
								Dim num8 As Short = rst.Ntsteps - 1S

									For num9 As Short = num7 To num8
										FileSystem.FileGet(Conversions.ToInteger(frn), array(CInt(num5), CInt(num9)), -1L)
									Next
									num5 += 1S

							Loop While num5 <= 2S
							rst.Tnet = array
							array2 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array3 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array4 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array5 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array6 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array7 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array8 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							num10 = 0S
							num11 = rst.Ntsteps - 1S
							num5 = num10
							While num5 <= num11
								FileSystem.FileGet(Conversions.ToInteger(frn), array2(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array3(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array4(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array5(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array6(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array7(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array8(CInt(num5)), -1L)
								num5 += 1S
							End While
							rst.SurfPos = array2
							rst.SurfLoad = array3
							rst.PumpPos = array4
							rst.PumpLoad = array5
							rst.PermLoad = array6
							rst.Thetac = array7
							rst.Tf = array8
							Dim num12 As Short = 1S
							Dim numRods As Short = rst.NumRods
							num5 = num12
							While num5 <= numRods
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.StressL(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.maxStressTop(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.minStressTop(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.minStressBot(CInt(num5)), -1L)
								num5 += 1S
							End While
							Dim flag As Boolean = True
							num5 = 1S
							Do
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.LineSettings(CInt(num5)).LSet, -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.LineSettings(CInt(num5)).Value, -1L)
								Debug.WriteLine(".LineSettings=" + rst.LineSettings(CInt(num5)).LSet.ToString() + " , " + rst.LineSettings(CInt(num5)).Value.ToString())
								If rst.LineSettings(CInt(num5)).LSet = 0S Then
									flag = False
								End If
								num5 += 1S
							Loop While num5 <= 4S
							If ThisVersion < 14S Then
								rst.UFeetFromSurface = 0F
								rst.UFeetOverPump = 0F
								rst.UFluidLoad = -1F
								rst.UNetProduction = 0F
								rst.UNetStrokeApparent = -1F
								rst.UPintakeFromLines = 0F
							Else
								Dim fileNumber17 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UFeetFromSurface
								FileSystem.FileGet(fileNumber17, num3, -1L)
								cRODSTAR.UFeetFromSurface = num3
								Dim fileNumber18 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UFeetOverPump
								FileSystem.FileGet(fileNumber18, num3, -1L)
								cRODSTAR.UFeetOverPump = num3
								Dim fileNumber19 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UFluidLoad
								FileSystem.FileGet(fileNumber19, num3, -1L)
								cRODSTAR.UFluidLoad = num3
								Dim fileNumber20 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UNetProduction
								FileSystem.FileGet(fileNumber20, num3, -1L)
								cRODSTAR.UNetProduction = num3
								Dim fileNumber21 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UNetStroke
								FileSystem.FileGet(fileNumber21, num3, -1L)
								cRODSTAR.UNetStroke = num3
								Dim fileNumber22 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UPintakeFromLines
								FileSystem.FileGet(fileNumber22, num3, -1L)
								cRODSTAR.UPintakeFromLines = num3
							End If
							Debug.WriteLine(" UNetProduction = " + Conversions.ToString(rst.UNetProduction))
							If ThisVersion < 21S Then
								rst.PumpFriction = -1F
							Else
								Dim fileNumber23 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.PumpFriction
								FileSystem.FileGet(fileNumber23, num3, -1L)
								cRODSTAR.PumpFriction = num3
							End If
							rst.PumpFriction = 200F
							If ThisVersion < 22S Then
								rst.ULinesSetH = (rst.LineSettings(3).LSet And rst.LineSettings(4).LSet)
								rst.ULinesSetV = (rst.LineSettings(1).LSet And rst.LineSettings(2).LSet)
								rst.UNetStroke = rst.UNetStrokeApparent
							Else
								Dim fileNumber24 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num4 = cRODSTAR.ULinesSetH
								FileSystem.FileGet(fileNumber24, num4, -1L)
								cRODSTAR.ULinesSetH = num4
								Dim fileNumber25 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num4 = cRODSTAR.ULinesSetV
								FileSystem.FileGet(fileNumber25, num4, -1L)
								cRODSTAR.ULinesSetV = num4
								Dim fileNumber26 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UNetStrokeApparent
								FileSystem.FileGet(fileNumber26, num3, -1L)
								cRODSTAR.UNetStrokeApparent = num3
							End If
							If flag And rst.UNetProduction > 2F Then
								RSWIN_DESC.fDefaultTargetProduction = CSng((CDbl(rst.UNetProduction) * 1.1))
							Else
								RSWIN_DESC.fDefaultTargetProduction = rst.BPDsurface
							End If
							bOutputLoaded = True
							rst.gbOutputLoaded = True
						End If
					End If
				End If
			Catch ex As Exception
				bOutputLoaded = True
				RSWIN_DESC.rst.gbOutputLoaded = False
			End Try
		End Sub

		Private Sub LoadOutputData(ByRef frn As Object, ByRef ThisVersion As Short, ByRef bOutputLoaded As Boolean)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				bOutputLoaded = False
				rst.gbOutputLoaded = False
				If ThisVersion < 13S Then
					bOutputLoaded = True
				Else
					' The following expression was wrapped in a checked-expression
					Dim num As Integer = CInt(FileSystem.Seek(Conversions.ToInteger(frn)))
					If CLng(num) >= FileSystem.LOF(Conversions.ToInteger(frn)) - 1L Then
						bOutputLoaded = True
					Else
						' The following expression was wrapped in a checked-expression
						FileSystem.Seek(Conversions.ToInteger(frn), FileSystem.LOF(Conversions.ToInteger(frn)) - 1L)
						Dim num2 As Short
						FileSystem.FileGet(Conversions.ToInteger(frn), num2, -1L)
						If Not num2 <> 0S Then
							bOutputLoaded = True
						Else
							FileSystem.Seek(Conversions.ToInteger(frn), CLng(num))
							Dim fileNumber As Integer = Conversions.ToInteger(frn)
							Dim cRODSTAR As cRODSTAR = rst
							Dim num3 As Single = cRODSTAR.BPDsurface
							FileSystem.FileGet(fileNumber, num3, -1L)
							cRODSTAR.BPDsurface = num3
							Dim fileNumber2 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.GrossPumpStroke
							FileSystem.FileGet(fileNumber2, num3, -1L)
							cRODSTAR.GrossPumpStroke = num3
							Dim fileNumber3 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.MaxRodStressL
							FileSystem.FileGet(fileNumber3, num3, -1L)
							cRODSTAR.MaxRodStressL = num3
							Dim fileNumber4 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.MinMotorHP
							FileSystem.FileGet(fileNumber4, num3, -1L)
							cRODSTAR.MinMotorHP = num3
							Dim fileNumber5 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.Mprload
							FileSystem.FileGet(fileNumber5, num3, -1L)
							cRODSTAR.Mprload = num3
							Dim fileNumber6 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							Dim num4 As Short = cRODSTAR.Ntsteps
							FileSystem.FileGet(fileNumber6, num4, -1L)
							cRODSTAR.Ntsteps = num4
							Dim fileNumber7 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num4 = cRODSTAR.NtstepsUpstroke
							FileSystem.FileGet(fileNumber7, num4, -1L)
							cRODSTAR.NtstepsUpstroke = num4
							Dim fileNumber8 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.Prhp
							FileSystem.FileGet(fileNumber8, num3, -1L)
							cRODSTAR.Prhp = num3
							Dim fileNumber9 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.Pprload
							FileSystem.FileGet(fileNumber9, num3, -1L)
							cRODSTAR.Pprload = num3
							Dim fileNumber10 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.StructL
							FileSystem.FileGet(fileNumber10, num3, -1L)
							cRODSTAR.StructL = num3
							Dim fileNumber11 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.USystemEff
							FileSystem.FileGet(fileNumber11, num3, -1L)
							cRODSTAR.USystemEff = num3
							Dim fileNumber12 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.TotalTheta
							FileSystem.FileGet(fileNumber12, num3, -1L)
							cRODSTAR.TotalTheta = num3
							Dim fileNumber13 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.WrodsInFluid
							FileSystem.FileGet(fileNumber13, num3, -1L)
							cRODSTAR.WrodsInFluid = num3
							Dim value As Single
							Dim value2 As Single
							If(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And ThisVersion >= 25S And Not rst.bUnknownUnbalance Then
								value = rst.get_RequiredUnbalance(2)
							ElseIf Not rst.UnknownM Then
								value2 = rst.get_M(2)
							End If
							Dim num5 As Short
							Dim array2 As Single()
							Dim array3 As Single()
							Dim array4 As Single()
							Dim array5 As Single()
							Dim array6 As Single()
							Dim array7 As Single()
							Dim array8 As Single()
							Dim num10 As Short
							Dim num11 As Short
							Dim array As Single(,) = New Single(2, CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							num5 = 0S
							Do
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.CBE90(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.Clf(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.DollarsPerBblFluid(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.DollarsPerBblOil(CInt(num5)), -1L)
								Dim fileNumber14 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								Dim cRODSTAR2 As cRODSTAR = cRODSTAR
								num4 = num5
								num3 = cRODSTAR2.get_ElectricBillperMonth(CInt(num4))
								FileSystem.FileGet(fileNumber14, num3, -1L)
								cRODSTAR.set_ElectricBillperMonth(CInt(num4), num3)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.GearboxLoading(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.HpNemaD(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.HpUhs(CInt(num5)), -1L)
								If(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And ThisVersion >= 25S Then
									Dim fileNumber15 As Integer = Conversions.ToInteger(frn)
									cRODSTAR = rst
									Dim cRODSTAR3 As cRODSTAR = cRODSTAR
									num4 = num5
									num3 = cRODSTAR3.get_RequiredUnbalance(CInt(num4))
									FileSystem.FileGet(fileNumber15, num3, -1L)
									cRODSTAR.set_RequiredUnbalance(CInt(num4), num3)
								Else
									Dim fileNumber16 As Integer = Conversions.ToInteger(frn)
									cRODSTAR = rst
									Dim cRODSTAR4 As cRODSTAR = cRODSTAR
									num4 = num5
									num3 = cRODSTAR4.get_M(CInt(num4))
									FileSystem.FileGet(fileNumber16, num3, -1L)
									cRODSTAR.set_M(CInt(num4), num3)
								End If
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.MotorKWH(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.PeakTorque(CInt(num5)), -1L)
								Dim num6 As Integer = CInt(FileSystem.Seek(Conversions.ToInteger(frn)))
								Dim num7 As Short = 0S
								Dim num8 As Short = rst.Ntsteps - 1S

									For num9 As Short = num7 To num8
										FileSystem.FileGet(Conversions.ToInteger(frn), array(CInt(num5), CInt(num9)), -1L)
									Next
									num5 += 1S

							Loop While num5 <= 2S
							If(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And ThisVersion >= 25S And Not rst.bUnknownUnbalance Then
								rst.set_RequiredUnbalance(2, value)
							ElseIf Not rst.UnknownM Then
								rst.set_M(2, value2)
							End If
							rst.Tnet = array
							array2 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array3 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array4 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array5 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array6 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array7 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array8 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							num10 = 0S
							num11 = rst.Ntsteps - 1S
							num5 = num10
							While num5 <= num11
								FileSystem.FileGet(Conversions.ToInteger(frn), array2(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array3(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array4(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array5(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array6(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array7(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array8(CInt(num5)), -1L)
								num5 += 1S
							End While
							rst.SurfPos = array2
							rst.SurfLoad = array3
							rst.PumpPos = array4
							rst.PumpLoad = array5
							rst.PermLoad = array6
							rst.Thetac = array7
							rst.Tf = array8
							Dim num12 As Short = 1S
							Dim numRods As Short = rst.NumRods
							num5 = num12
							While num5 <= numRods
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.StressL(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.maxStressTop(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.minStressTop(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.minStressBot(CInt(num5)), -1L)
								num5 += 1S
							End While
							num5 = 1S
							Do
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.LineSettings(CInt(num5)).LSet, -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.LineSettings(CInt(num5)).Value, -1L)
								num5 += 1S
							Loop While num5 <= 4S
							If ThisVersion < 14S Then
								rst.UFeetFromSurface = 0F
								rst.UFeetOverPump = 0F
								rst.UFluidLoad = -1F
								rst.UNetProduction = 0F
								rst.UNetStrokeApparent = -1F
								rst.UPintakeFromLines = 0F
							Else
								Dim fileNumber17 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UFeetFromSurface
								FileSystem.FileGet(fileNumber17, num3, -1L)
								cRODSTAR.UFeetFromSurface = num3
								Dim fileNumber18 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UFeetOverPump
								FileSystem.FileGet(fileNumber18, num3, -1L)
								cRODSTAR.UFeetOverPump = num3
								Dim fileNumber19 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UFluidLoad
								FileSystem.FileGet(fileNumber19, num3, -1L)
								cRODSTAR.UFluidLoad = num3
								Dim fileNumber20 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UNetProduction
								FileSystem.FileGet(fileNumber20, num3, -1L)
								cRODSTAR.UNetProduction = num3
								Dim fileNumber21 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UNetStroke
								FileSystem.FileGet(fileNumber21, num3, -1L)
								cRODSTAR.UNetStroke = num3
								Dim fileNumber22 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UPintakeFromLines
								FileSystem.FileGet(fileNumber22, num3, -1L)
								cRODSTAR.UPintakeFromLines = num3
							End If
							If ThisVersion < 21S Then
								rst.PumpFriction = -1F
							Else
								Dim fileNumber23 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.PumpFriction
								FileSystem.FileGet(fileNumber23, num3, -1L)
								cRODSTAR.PumpFriction = num3
							End If
							If ThisVersion < 22S Then
								rst.ULinesSetH = (rst.LineSettings(3).LSet And rst.LineSettings(4).LSet)
								rst.ULinesSetV = (rst.LineSettings(1).LSet And rst.LineSettings(2).LSet)
								rst.UNetStroke = rst.UNetStrokeApparent
							Else
								Dim fileNumber24 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num4 = cRODSTAR.ULinesSetH
								FileSystem.FileGet(fileNumber24, num4, -1L)
								cRODSTAR.ULinesSetH = num4
								Dim fileNumber25 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num4 = cRODSTAR.ULinesSetV
								FileSystem.FileGet(fileNumber25, num4, -1L)
								cRODSTAR.ULinesSetV = num4
								Dim fileNumber26 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UNetStrokeApparent
								FileSystem.FileGet(fileNumber26, num3, -1L)
								cRODSTAR.UNetStrokeApparent = num3
							End If
							bOutputLoaded = True
						End If
					End If
				End If
			Catch ex As Exception
				bOutputLoaded = True
				RSWIN_DESC.rst.gbOutputLoaded = False
			End Try
		End Sub

		Private Sub LoadInputData(ByRef frn As Short, ByRef iThisVersion As Short, ByRef bInputLoaded As Short)
			Dim array As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
			bInputLoaded = 0S
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				cRODSTAR.ACompanyName = New String(" "c, 40)
				Dim fileNumber As Integer = CInt(frn)
				Dim cRODSTAR2 As cRODSTAR = cRODSTAR
				Dim text As String = cRODSTAR2.ACompanyName
				FileSystem.FileGet(fileNumber, text, -1L, False)
				cRODSTAR2.ACompanyName = text
				cRODSTAR.WellName = New String(" "c, 40)
				Dim fileNumber2 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.WellName
				FileSystem.FileGet(fileNumber2, text, -1L, False)
				cRODSTAR2.WellName = text
				cRODSTAR.UserName = New String(" "c, 40)
				Dim fileNumber3 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.UserName
				FileSystem.FileGet(fileNumber3, text, -1L, False)
				cRODSTAR2.UserName = text
				cRODSTAR.UserDate = New String(" "c, 40)
				Dim fileNumber4 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.UserDate
				FileSystem.FileGet(fileNumber4, text, -1L, False)
				cRODSTAR2.UserDate = text
				Dim fileNumber5 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				Dim num As Single = cRODSTAR2.PumpDepth
				FileSystem.FileGet(fileNumber5, num, -1L)
				cRODSTAR2.PumpDepth = num
				Dim giFluidLevelSource As Short
				If iThisVersion < 15S Then
					Dim num2 As Short
					FileSystem.FileGet(CInt(frn), num2, -1L)
					giFluidLevelSource = Conversions.ToShort(Interaction.IIf(num2 <> 0S, 1, 0))
					cRODSTAR.giFluidLevelSource = giFluidLevelSource
				End If
				Dim fileNumber6 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.FluidLevel
				FileSystem.FileGet(fileNumber6, num, -1L)
				cRODSTAR2.FluidLevel = num
				Dim fileNumber7 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.SPM
				FileSystem.FileGet(fileNumber7, num, -1L)
				cRODSTAR2.SPM = num
				Dim num3 As Short
				FileSystem.FileGet(CInt(frn), num3, -1L)
				Dim fileNumber8 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				Dim num4 As Short = cRODSTAR2.PumpType
				FileSystem.FileGet(fileNumber8, num4, -1L)
				cRODSTAR2.PumpType = num4
				Dim fileNumber9 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.PlungerSize
				FileSystem.FileGet(fileNumber9, num, -1L)
				cRODSTAR2.PlungerSize = num
				Dim fileNumber10 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.FluidSPGR
				FileSystem.FileGet(fileNumber10, num, -1L)
				cRODSTAR2.FluidSPGR = num
				Dim num5 As Single
				FileSystem.FileGet(CInt(frn), num5, -1L)
				If RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.rst.Friction = 0.2F
					RSWIN_DESC.rst.DownstrokeFriction = 0.1F
					RSWIN_DESC.rst.UpstrokeFriction = 0.1F
				Else
					RSWIN_DESC.rst.Friction = 2F
					RSWIN_DESC.rst.DownstrokeFriction = 1F
					RSWIN_DESC.rst.UpstrokeFriction = 1F
				End If
				RSWIN_DESC.rst.SlideFricCoeff = 0.2F
				Dim fileNumber11 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingOD
				FileSystem.FileGet(fileNumber11, num, -1L)
				cRODSTAR2.TubingOD = num
				Dim fileNumber12 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingID
				FileSystem.FileGet(fileNumber12, num, -1L)
				cRODSTAR2.TubingID = num
				Dim fileNumber13 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.TubingAnchored
				FileSystem.FileGet(fileNumber13, num4, -1L)
				cRODSTAR2.TubingAnchored = num4
				Dim fileNumber14 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingAnchorDepth
				FileSystem.FileGet(fileNumber14, num, -1L)
				cRODSTAR2.TubingAnchorDepth = num
				Dim fileNumber15 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingPressure
				FileSystem.FileGet(fileNumber15, num, -1L)
				cRODSTAR2.TubingPressure = num
				Dim fileNumber16 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.CasingPressure
				FileSystem.FileGet(fileNumber16, num, -1L)
				cRODSTAR2.CasingPressure = num
				Dim fileNumber17 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.NumRods
				FileSystem.FileGet(fileNumber17, num4, -1L)
				cRODSTAR2.NumRods = num4
				Dim num6 As Integer = 1
				Dim numRods As Integer = CInt(cRODSTAR.NumRods)
				Dim pu As RSWIN_DESC.PUDataRec
				Dim flag As Boolean
				Dim num9 As Single
				Dim num10 As Short
				Dim iTorqueMode As Short
				Dim sMotorSizeName As String
				Dim obj As Object
				For i As Integer = num6 To numRods
					array(i).Initialize()
					FileSystem.FileGet(CInt(frn), array(i).Grade, -1L)
					FileSystem.FileGet(CInt(frn), array(i).Diameter, -1L)
					FileSystem.FileGet(CInt(frn), array(i).length, -1L)
					If iThisVersion < 11S Then
						FileSystem.FileGet(CInt(frn), num5, -1L)
					End If
					FileSystem.FileGet(CInt(frn), array(i).SuckerRodLength, -1L)
					FileSystem.FileGet(CInt(frn), array(i).RodDensity, -1L)
					FileSystem.FileGet(CInt(frn), array(i).RodWeight, -1L)
					FileSystem.FileGet(CInt(frn), array(i).Elasticity, -1L)
					FileSystem.FileGet(CInt(frn), array(i).Area, -1L)
					RODUTIL.ConvertRodGrade(array(i))
					If iThisVersion >= 9S Then
						FileSystem.FileGet(CInt(frn), array(i).RodType, -1L, False)
						FileSystem.FileGet(CInt(frn), array(i).TensileStrength, -1L)
					Else
						array(i).RodType = RODUTIL.RodGrade(array(i).Grade)
						RODUTIL.LookupTensileStrength(array(i))
					End If
					Try
						array(i).Guide = RSWIN_DESC.MOLDED
						array(i).friction_coef = 0.2F
					Catch ex As Exception
					End Try
				Next
				cRODSTAR.Sections = array
				Dim fileNumber18 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.ServiceFactor
				FileSystem.FileGet(fileNumber18, num, -1L)
				cRODSTAR2.ServiceFactor = num
				Dim fileNumber19 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.UnitID
				FileSystem.FileGet(fileNumber19, text, -1L, False)
				cRODSTAR2.UnitID = text
				Dim fileNumber20 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.IDEntered
				FileSystem.FileGet(fileNumber20, num4, -1L)
				cRODSTAR2.IDEntered = num4
				cRODSTAR.PU.Initialize()
				pu.Initialize()
				FileSystem.FileGet(CInt(frn), pu.Manuf, -1L, False)
				FileSystem.FileGet(CInt(frn), pu.UnitName, -1L, False)
				FileSystem.FileGet(CInt(frn), pu.APIDesignation, -1L, False)
				FileSystem.FileGet(CInt(frn), pu.UnitType, -1L)
				FileSystem.FileGet(CInt(frn), pu.RequiredRotation, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRotation, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankHole, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankHoles, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(0), -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(1), -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(2), -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(3), -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(4), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(0), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(1), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(2), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(3), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(4), -1L)
				FileSystem.FileGet(CInt(frn), pu.KinematicStroke, -1L)
				If iThisVersion <= 14S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
				End If
				FileSystem.FileGet(CInt(frn), pu.R, -1L)
				FileSystem.FileGet(CInt(frn), pu.A, -1L)
				FileSystem.FileGet(CInt(frn), pu.C, -1L)
				FileSystem.FileGet(CInt(frn), pu.I, -1L)
				FileSystem.FileGet(CInt(frn), pu.K, -1L)
				FileSystem.FileGet(CInt(frn), pu.P, -1L)
				FileSystem.FileGet(CInt(frn), pu.M, -1L)
				FileSystem.FileGet(CInt(frn), pu.S, -1L)
				FileSystem.FileGet(CInt(frn), pu.V0, -1L)
				FileSystem.FileGet(CInt(frn), pu.DrumDiamRatio, -1L)
				FileSystem.FileGet(CInt(frn), pu.SprocketRadius, -1L)
				FileSystem.FileGet(CInt(frn), pu.SprocketDistance, -1L)
				FileSystem.FileGet(CInt(frn), pu.Unbalance, -1L)
				cRODSTAR.Unbalance = pu.Unbalance
				FileSystem.FileGet(CInt(frn), pu.CrankOffset, -1L)
				FileSystem.FileGet(CInt(frn), pu.StructRating, -1L)
				FileSystem.FileGet(CInt(frn), pu.GearboxRating, -1L)
				FileSystem.FileGet(CInt(frn), pu.MaxStroke, -1L)
				FileSystem.FileGet(CInt(frn), pu.ArtInertia, -1L)
				If iThisVersion = 1S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
				End If
				Dim fileNumber21 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.ElectricityCost
				FileSystem.FileGet(fileNumber21, num, -1L)
				cRODSTAR2.ElectricityCost = num
				If cRODSTAR.ElectricityCost = 0F Then
					Try
						Dim cRODSTAR3 As cRODSTAR = cRODSTAR
						Dim sDefaultName As String = "ElectricityCost"
						Dim vNotPresentDefault As Object = 0.06
						flag = False
						cRODSTAR3.ElectricityCost = Conversions.ToSingle(ini.GetDefault(sDefaultName, vNotPresentDefault, flag))
					Catch ex2 As Exception
					End Try
				End If
				Dim fileNumber22 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.PowerMeterType
				FileSystem.FileGet(fileNumber22, num4, -1L)
				cRODSTAR2.PowerMeterType = num4
				If iThisVersion < 9S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
				End If
				Dim fileNumber23 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.CBDataType
				FileSystem.FileGet(fileNumber23, num4, -1L)
				cRODSTAR2.CBDataType = num4
				FileSystem.FileGet(CInt(frn), num5, -1L)
				FileSystem.FileGet(CInt(frn), num5, -1L)
				Dim fileNumber24 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				Dim cRODSTAR4 As cRODSTAR = cRODSTAR2
				Dim index As Integer = 2
				num = cRODSTAR4.get_M(index)
				FileSystem.FileGet(fileNumber24, num, -1L)
				cRODSTAR2.set_M(index, num)
				If iThisVersion < 3S Then
					Select Case pu.UnitType
						Case 6S
							FileSystem.FileGet(CInt(frn), num5, -1L)
							Dim fileNumber25 As Integer = CInt(frn)
							cRODSTAR2 = cRODSTAR
							Dim cRODSTAR5 As cRODSTAR = cRODSTAR2
							index = 2
							num = cRODSTAR5.get_M(index)
							FileSystem.FileGet(fileNumber25, num, -1L)
							cRODSTAR2.set_M(index, num)
							GoTo IL_9E7
						Case 7S, 10S
							Dim fileNumber26 As Integer = CInt(frn)
							cRODSTAR2 = cRODSTAR
							Dim cRODSTAR6 As cRODSTAR = cRODSTAR2
							index = 2
							num = cRODSTAR6.get_M(index)
							FileSystem.FileGet(fileNumber26, num, -1L)
							cRODSTAR2.set_M(index, num)
							FileSystem.FileGet(CInt(frn), num5, -1L)
							GoTo IL_9E7
					End Select
					FileSystem.FileGet(CInt(frn), num5, -1L)
					FileSystem.FileGet(CInt(frn), num5, -1L)
					cRODSTAR.set_M(2, cRODSTAR.get_M(2) * 1000F)
				End If
				IL_9E7:
				Dim fileNumber27 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.RDNtsteps
				FileSystem.FileGet(fileNumber27, num4, -1L)
				cRODSTAR2.RDNtsteps = num4
				If cRODSTAR.RDNtsteps > 0S Then
					Dim array2 As Single() = New Single(CInt((cRODSTAR.RDNtsteps - 1S + 1S)) - 1) {}
					Dim array3 As Single() = New Single(CInt((cRODSTAR.RDNtsteps - 1S + 1S)) - 1) {}
					Dim num7 As Integer = 0
					Dim num8 As Integer = CInt((cRODSTAR.RDNtsteps - 1S))
					For i As Integer = num7 To num8
						FileSystem.FileGet(CInt(frn), array2(i), -1L)
						FileSystem.FileGet(CInt(frn), array3(i), -1L)
					Next
					cRODSTAR.RDSurfPos = array2
					cRODSTAR.RDSurfLoad = array3
				End If
				Dim text2 As String
				If iThisVersion >= 2S Then
					If iThisVersion = 2S Then
						text2 = Strings.Space(CInt((FileSystem.LOF(CInt(frn)) - FileSystem.Loc(CInt(frn)) - 12L)))
						FileSystem.FileGet(CInt(frn), text2, -1L, False)
						cRODSTAR.DynaFile = ""
					Else
						Dim fileNumber28 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						text = cRODSTAR2.DynaFile
						FileSystem.FileGet(fileNumber28, text, -1L, False)
						cRODSTAR2.DynaFile = text
					End If
					Dim fileNumber29 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.Runtime
					FileSystem.FileGet(fileNumber29, num, -1L)
					cRODSTAR2.Runtime = num
					FileSystem.FileGet(CInt(frn), num5, -1L)
					Dim fileNumber30 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.WaterCut
					FileSystem.FileGet(fileNumber30, num, -1L)
					cRODSTAR2.WaterCut = num
				Else
					cRODSTAR.DynaFile = ""
					cRODSTAR.Runtime = 24F
					cRODSTAR.WaterCut = 0F
				End If
				If iThisVersion >= 3S Then
					Dim fileNumber31 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.OilAPI
					FileSystem.FileGet(fileNumber31, num, -1L)
					cRODSTAR2.OilAPI = num
				Else
					cRODSTAR.OilAPI = 30F
				End If
				If iThisVersion >= 4S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
				End If
				If iThisVersion < 5S Then
					num9 = 0F
				ElseIf iThisVersion < 11S Then
					FileSystem.FileGet(CInt(frn), num9, -1L)
					If num9 = 0F Then
						cRODSTAR.CalcMotorSize = -1S
						num9 = 50F
					Else
						cRODSTAR.CalcMotorSize = 0S
						num9 = RODUTIL.StdMotorSize(num9)
					End If
					num10 = 1S
				End If
				If iThisVersion >= 6S Then
					Dim fileNumber32 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.PumpFillage
					FileSystem.FileGet(fileNumber32, num, -1L)
					cRODSTAR2.PumpFillage = num
				End If
				If iThisVersion >= 7S Then
					FileSystem.FileGet(CInt(frn), num3, -1L)
					FILEIO.GetString(frn, text2)
					FileSystem.FileGet(CInt(frn), num3, -1L)
					FileSystem.FileGet(CInt(frn), num5, -1L)
				Else
					cRODSTAR.LeutertDynamometer = 0S
				End If
				If iThisVersion >= 8S Then
					FILEIO.GetString(frn, text2)
				End If
				If iThisVersion >= 9S Then
					FILEIO.GetString(frn, pu.OtherInfo)
				Else
					pu.OtherInfo = ""
				End If
				If iThisVersion >= 10S Then
					Dim frn2 As Short = frn
					cRODSTAR2 = cRODSTAR
					text = cRODSTAR2.CBDataFile
					FILEIO.GetString(frn2, text)
					cRODSTAR2.CBDataFile = text
				Else
					cRODSTAR.CBDataFile = ""
				End If
				If iThisVersion >= 11S Then
					Dim fileNumber33 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.WaterSPGR
					FileSystem.FileGet(fileNumber33, num, -1L)
					cRODSTAR2.WaterSPGR = num
					If cRODSTAR.WaterSPGR < 1F Then
						cRODSTAR.WaterSPGR = 1F
					ElseIf CDbl(cRODSTAR.WaterSPGR) > 1.5 Then
						cRODSTAR.WaterSPGR = 1.5F
					End If
					Dim fileNumber34 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num4 = cRODSTAR2.CalcMotorSize
					FileSystem.FileGet(fileNumber34, num4, -1L)
					cRODSTAR2.CalcMotorSize = num4
					If iThisVersion < 20S Then
						FileSystem.FileGet(CInt(frn), num10, -1L)
						FileSystem.FileGet(CInt(frn), num9, -1L)
						FileSystem.FileGet(CInt(frn), iTorqueMode, -1L)
						FILEIO.GetString(frn, sMotorSizeName)
					End If
				Else
					cRODSTAR.WaterSPGR = 1F
				End If
				If iThisVersion >= 15S Then
					Dim fileNumber35 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num4 = cRODSTAR2.giFluidLevelSource
					FileSystem.FileGet(fileNumber35, num4, -1L)
					cRODSTAR2.giFluidLevelSource = num4
					giFluidLevelSource = cRODSTAR.giFluidLevelSource
					Dim fileNumber36 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.UPumpIntakePressure
					FileSystem.FileGet(fileNumber36, num, -1L)
					cRODSTAR2.UPumpIntakePressure = num
					cRODSTAR.PumpIntakePressure = cRODSTAR.UPumpIntakePressure
					Dim fileNumber37 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					flag = cRODSTAR2.gbUseIPR
					FileSystem.FileGet(fileNumber37, flag, -1L)
					cRODSTAR2.gbUseIPR = flag
					Dim fileNumber38 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num4 = cRODSTAR2.giIPRMethod
					FileSystem.FileGet(fileNumber38, num4, -1L)
					cRODSTAR2.giIPRMethod = num4
					Dim fileNumber39 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.MidPerfDepth
					FileSystem.FileGet(fileNumber39, num, -1L)
					cRODSTAR2.MidPerfDepth = num
					Dim fileNumber40 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.StaticBHPressure
					FileSystem.FileGet(fileNumber40, num, -1L)
					cRODSTAR2.StaticBHPressure = num
					Dim fileNumber41 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.BubblePoint
					FileSystem.FileGet(fileNumber41, num, -1L)
					cRODSTAR2.BubblePoint = num
					Dim fileNumber42 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num4 = cRODSTAR2.gnTestPoints
					FileSystem.FileGet(fileNumber42, num4, -1L)
					cRODSTAR2.gnTestPoints = num4
					Dim array4 As RSWIN_DESC.IPRTESTPOINT()
					If cRODSTAR.gnTestPoints = 0S Then
						array4 = New RSWIN_DESC.IPRTESTPOINT(0) {}
					Else
						array4 = New RSWIN_DESC.IPRTESTPOINT(CInt((cRODSTAR.gnTestPoints + 1S)) - 1) {}
						Dim num11 As Integer = 1
						Dim gnTestPoints As Integer = CInt(cRODSTAR.gnTestPoints)
						For i As Integer = num11 To gnTestPoints
							FileSystem.FileGet(CInt(frn), array4(i).bPIEntered, -1L)
							FileSystem.FileGet(CInt(frn), array4(i).Pintake, -1L)
							FileSystem.FileGet(CInt(frn), array4(i).Pwf, -1L)
							FileSystem.FileGet(CInt(frn), array4(i).Production, -1L)
						Next
					End If
					cRODSTAR.TestPoints = array4
					If Not cRODSTAR.gbUseIPR Then
						cRODSTAR.gnTestPoints = 0S
						array4 = New RSWIN_DESC.IPRTESTPOINT(0) {}
						cRODSTAR.TestPoints = array4
						cRODSTAR.MidPerfDepth = -1F
						cRODSTAR.StaticBHPressure = -1F
						cRODSTAR.BubblePoint = -1F
					End If
				Else
					cRODSTAR.gbUseIPR = False
					cRODSTAR.gnTestPoints = 0S
					cRODSTAR.giIPRMethod = -1S
					cRODSTAR.MidPerfDepth = -1F
					cRODSTAR.StaticBHPressure = -1F
					cRODSTAR.BubblePoint = -1F
					Dim array4 As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(0) {}
					cRODSTAR.TestPoints = array4
				End If
				If iThisVersion >= 17S Then
					Dim fileNumber43 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					flag = cRODSTAR2.gbProducingBelowBPP
					FileSystem.FileGet(fileNumber43, flag, -1L)
					cRODSTAR2.gbProducingBelowBPP = flag
				Else
					cRODSTAR.gbProducingBelowBPP = False
				End If
				If iThisVersion >= 18S Then
					Dim frn3 As Short = frn
					cRODSTAR2 = cRODSTAR
					text = cRODSTAR2.FileComment
					FILEIO.GetString(frn3, text)
					cRODSTAR2.FileComment = text
					Dim fileNumber44 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					flag = cRODSTAR2.gbCalcFetkovichN
					FileSystem.FileGet(fileNumber44, flag, -1L)
					cRODSTAR2.gbCalcFetkovichN = flag
					Dim fileNumber45 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.FetkovichN
					FileSystem.FileGet(fileNumber45, num, -1L)
					cRODSTAR2.FetkovichN = num
					If cRODSTAR.giIPRMethod <> 0S Then
						cRODSTAR.gbCalcFetkovichN = True
					End If
				Else
					cRODSTAR.FileComment = RSWIN_DESC.sNull
					cRODSTAR.gbCalcFetkovichN = True
					cRODSTAR.FetkovichN = -1F
				End If
				If iThisVersion >= 19S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
					FileSystem.FileGet(CInt(frn), num5, -1L)
				Else
					cRODSTAR.MeasuredTVLoad = 0F
					cRODSTAR.MeasuredSVLoad = 0F
				End If
				If iThisVersion >= 20S Then
					Motor.ReadMotorData(CInt(frn))
				End If
				If iThisVersion >= 21S Then
					Dim fileNumber46 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					flag = cRODSTAR2.gbIncludeBuoyancy
					FileSystem.FileGet(fileNumber46, flag, -1L)
					cRODSTAR2.gbIncludeBuoyancy = flag
				Else
					cRODSTAR.gbIncludeBuoyancy = False
				End If
				If iThisVersion >= 23S Then
					FileSystem.FileGet(CInt(frn), num3, -1L)
				End If
				Try
					If iThisVersion >= 25S And (pu.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) Then
						Dim fileNumber47 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						flag = cRODSTAR2.bUnknownUnbalance
						FileSystem.FileGet(fileNumber47, flag, -1L)
						cRODSTAR2.bUnknownUnbalance = flag
					End If
				Catch ex3 As Exception
					cRODSTAR.gbOutputLoaded = False
				End Try
				If iThisVersion >= 26S Then
					Dim fileNumber48 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.StuffingBoxFriction
					FileSystem.FileGet(fileNumber48, num, -1L)
					cRODSTAR2.StuffingBoxFriction = num
				Else
					Dim cRODSTAR7 As cRODSTAR = cRODSTAR
					Dim sDefaultName2 As String = "StuffingBoxFriction"
					Dim vNotPresentDefault2 As Object = 100
					flag = False
					cRODSTAR7.StuffingBoxFriction = Conversions.ToSingle(ini.GetDefault(sDefaultName2, vNotPresentDefault2, flag))
				End If
				If RSWIN_DESC.rst.PU.UnitType = -1S Then
					RSWIN_DESC.rst.PU = pu
				End If
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					If iThisVersion > 26S Then
						Dim fileNumber49 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.AdjustedStrokeLength
						FileSystem.FileGet(fileNumber49, num, -1L)
						cRODSTAR2.AdjustedStrokeLength = num
					Else
						cRODSTAR.AdjustedStrokeLength = cRODSTAR.PU.MaxStroke
					End If
				End If
				If iThisVersion > 27S Then
					Dim fileNumber50 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.PR_Diameter
					FileSystem.FileGet(fileNumber50, num, -1L)
					cRODSTAR2.PR_Diameter = num
				Else
					Try
						Dim sDefaultName3 As String = "PolishedRodDiameter"
						Dim vNotPresentDefault3 As Object = 3
						flag = False
						Dim prdiameter As Integer = Conversions.ToInteger(ini.GetDefault(sDefaultName3, vNotPresentDefault3, flag))
						cRODSTAR.PR_Diameter = RSWIN.SetPRDiameter(prdiameter)
					Catch ex4 As Exception
						cRODSTAR.PR_Diameter = 1.5F
					End Try
				End If
				If iThisVersion > 28S Then
					Dim fileNumber51 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					flag = cRODSTAR2.VSP
					FileSystem.FileGet(fileNumber51, flag, -1L)
					cRODSTAR2.VSP = flag
				End If
				If iThisVersion >= 23S Then
					obj = frn
					flag = False
					LOADRDG.LoadOutputData_new(obj, iThisVersion, flag)
					frn = Conversions.ToShort(obj)
				End If
				bInputLoaded = -1S
				If cRODSTAR.CBDataType = 1S And cRODSTAR.get_M(2) <> 0F Then
					cRODSTAR.UnknownM = False
				Else
					cRODSTAR.UnknownM = True
				End If
				cRODSTAR.gbRoddiagFile = True
				cRODSTAR.PumpFriction = 200F
				cRODSTAR.SPMEntered = -1S
				cRODSTAR.CalcPlungerSize = 0S
				Select Case giFluidLevelSource
					Case 0S
						cRODSTAR.FluidLevel = cRODSTAR.PumpDepth
						cRODSTAR.FluidLevelEntered = True
					Case 1S
						cRODSTAR.FluidLevelEntered = True
					Case 2S
						cRODSTAR.FluidLevelEntered = False
				End Select
				If cRODSTAR.PumpFillage >= 0F Then
					cRODSTAR.PumpFillage = Conversion.Int(cRODSTAR.PumpFillage * 100F)
					If cRODSTAR.PumpFillage > 95F Then
						cRODSTAR.PumpFillage = 95F
					End If
				Else
					Dim cRODSTAR8 As cRODSTAR = cRODSTAR
					Dim sDefaultName4 As String = "PumpFillage"
					Dim vNotPresentDefault4 As Object = 85
					flag = False
					cRODSTAR8.PumpFillage = Conversions.ToSingle(ini.GetDefault(sDefaultName4, vNotPresentDefault4, flag))
				End If
				cRODSTAR.RodStringType = 2S
				cRODSTAR.APIRod = 0S
				cRODSTAR.APIGrade = 0S
				cRODSTAR.RSGrade = 0S
				cRODSTAR.RSMaxSize = 0F
				cRODSTAR.RSMinSize = 0F
				Dim sinkerBar As RSWIN_DESC.RodSection
				cRODSTAR.SinkerBar = sinkerBar
				cRODSTAR.OilSPGR = CSng((141.5 / (CDbl(cRODSTAR.OilAPI) + 131.5)))
				If cRODSTAR.FluidSPGR = 0F Then
					cRODSTAR.FluidSPGR = cRODSTAR.WaterCut / 100F * cRODSTAR.WaterSPGR + (1F - cRODSTAR.WaterCut / 100F) * cRODSTAR.OilSPGR
				End If
				If(If((-If((iThisVersion <= 15S > False), 1S, 0S)), 1S, 0S) And Not cRODSTAR.IDEntered And If((-If(((pu.CrankHole = 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					pu.CrankHole = 1S
					pu.CrankHoles = 1S
					pu.CrankRadii(0) = pu.R
					pu.Strokes(0) = CSng(Conversion.Int(CDbl(pu.KinematicStroke) + 0.5))
				End If
				cRODSTAR.PU = pu
				RSWIN_DESC.WarnedAboutFluidInertia = 0S
				RSWIN_DESC.WarnedAboutPlungerSize = 0S
				cRODSTAR.PumpCondition = 1S
				Dim cRODSTAR9 As cRODSTAR = cRODSTAR
				Dim sDefaultName5 As String = "PumpEfficiency"
				Dim vNotPresentDefault5 As Object = 85
				flag = False
				cRODSTAR9.PumpEfficiency = Conversions.ToSingle(ini.GetDefault(sDefaultName5, vNotPresentDefault5, flag))
				cRODSTAR.IncludeFluidInertia = If((-If(((MImpred.FluidInertiaPossible() And cRODSTAR.PumpDepth < 4250F And cRODSTAR.PlungerSize > 2F) > False), 1S, 0S)), 1S, 0S)
				Dim cRODSTAR10 As cRODSTAR = cRODSTAR
				Dim sDefaultName6 As String = "CompressibilityIndex"
				Dim vNotPresentDefault6 As Object = 3
				flag = False
				cRODSTAR10.CompressibilityIndex = Conversions.ToSingle(ini.GetDefault(sDefaultName6, vNotPresentDefault6, flag))
				If cRODSTAR.IDEntered <> 0S Then
					cRODSTAR.Iart = cRODSTAR.PU.ArtInertia
				End If
				cRODSTAR.Irot = 0F
				cRODSTAR.IrotEntered = 0S
				cRODSTAR.UpstrokeFriction = 0F
				cRODSTAR.DownstrokeFriction = 0F
				If RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.rst.Friction = 0.2F
					RSWIN_DESC.rst.DownstrokeFriction = 0.1F
					RSWIN_DESC.rst.UpstrokeFriction = 0.1F
					RSWIN_DESC.rst.CalcFriction = 0S
				Else
					RSWIN_DESC.rst.Friction = 2F
					RSWIN_DESC.rst.DownstrokeFriction = 1F
					RSWIN_DESC.rst.UpstrokeFriction = 1F
					RSWIN_DESC.rst.CalcFriction = -1S
				End If
				RSWIN_DESC.rst.SlideFricCoeff = 0.2F
				Dim unitID As String = cRODSTAR.UnitID
				Dim num12 As Short
				obj = num12
				Dim text3 As String
				PUDATA1.ParseUnitID(unitID, text3, obj)
				num12 = Conversions.ToShort(obj)
				Dim text4 As String = text3
				If Operators.CompareString(text4, "CAB", False) = 0 Then
					Dim cRODSTAR11 As cRODSTAR = cRODSTAR
					Dim str As String = "CAA"
					obj = CInt((num12 + 98S))
					cRODSTAR11.UnitID = str + Util.Format(obj).Trim()
				End If
				Dim cRODSTAR12 As cRODSTAR = cRODSTAR
				Dim sDefaultName7 As String = "PumpLoadAdjustment"
				Dim vNotPresentDefault7 As Object = 0
				flag = False
				cRODSTAR12.PumpLoadAdj = Conversions.ToSingle(ini.GetDefault(sDefaultName7, vNotPresentDefault7, flag))
				If iThisVersion <= 19S Then
					If num10 = 0S Then
						num10 = 1S
						cRODSTAR.CalcMotorSize = -1S
						num9 = 50F
					End If
					Motor.SelectMotorFromOldInfo(CInt(num10), num9, sMotorSizeName, CInt(iTorqueMode))
				End If
				Dim motorInfo As Object = Motor.GetMotorInfo(4)
				If Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 1, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 7, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 8, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 9, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 10, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 11, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 12, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 13, False))), True, False)) Then
					cRODSTAR.MotorSPV = 0F
					cRODSTAR.CalcMotorSPV = 0S
				ElseIf Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 3, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 2, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 4, False))), True, False)) Then
					cRODSTAR.MotorSPV = 0F
					cRODSTAR.CalcMotorSPV = -1S
				Else
					num10 = 1S
					cRODSTAR.CalcMotorSize = -1S
					cRODSTAR.CalcMotorSPV = 0S
				End If
				RODUTIL.CheckCustomRodGrades()
				cRODSTAR.gbOutputLoaded = False
				If RSWIN_DESC.rst.WaterSPGR < 1F Then
					RSWIN_DESC.rst.WaterSPGR = 1F
				ElseIf CDbl(RSWIN_DESC.rst.WaterSPGR) > 1.5 Then
					RSWIN_DESC.rst.WaterSPGR = 1.5F
				End If
				cRODSTAR = Nothing
			Catch ex5 As Exception
			End Try
		End Sub

		Private Sub LoadOutputData_old(ByRef frn As Object, ByRef ThisVersion As Short, ByRef bOutputLoaded As Boolean)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				bOutputLoaded = False
				rst.gbOutputLoaded = False
				If ThisVersion < 13S Then
					bOutputLoaded = True
				Else
					' The following expression was wrapped in a checked-expression
					Dim num As Integer = CInt(FileSystem.Seek(Conversions.ToInteger(frn)))
					If CLng(num) >= FileSystem.LOF(Conversions.ToInteger(frn)) - 1L Then
						bOutputLoaded = True
					Else
						' The following expression was wrapped in a checked-expression
						FileSystem.Seek(Conversions.ToInteger(frn), FileSystem.LOF(Conversions.ToInteger(frn)) - 1L)
						Dim num2 As Short
						FileSystem.FileGet(Conversions.ToInteger(frn), num2, -1L)
						If Not num2 <> 0S Then
							bOutputLoaded = True
						Else
							FileSystem.Seek(Conversions.ToInteger(frn), CLng(num))
							Dim fileNumber As Integer = Conversions.ToInteger(frn)
							Dim cRODSTAR As cRODSTAR = rst
							Dim num3 As Single = cRODSTAR.BPDsurface
							FileSystem.FileGet(fileNumber, num3, -1L)
							cRODSTAR.BPDsurface = num3
							Dim fileNumber2 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.GrossPumpStroke
							FileSystem.FileGet(fileNumber2, num3, -1L)
							cRODSTAR.GrossPumpStroke = num3
							Dim fileNumber3 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.MaxRodStressL
							FileSystem.FileGet(fileNumber3, num3, -1L)
							cRODSTAR.MaxRodStressL = num3
							Dim fileNumber4 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.MinMotorHP
							FileSystem.FileGet(fileNumber4, num3, -1L)
							cRODSTAR.MinMotorHP = num3
							Dim fileNumber5 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.Mprload
							FileSystem.FileGet(fileNumber5, num3, -1L)
							cRODSTAR.Mprload = num3
							Dim fileNumber6 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							Dim num4 As Short = cRODSTAR.Ntsteps
							FileSystem.FileGet(fileNumber6, num4, -1L)
							cRODSTAR.Ntsteps = num4
							Dim fileNumber7 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num4 = cRODSTAR.NtstepsUpstroke
							FileSystem.FileGet(fileNumber7, num4, -1L)
							cRODSTAR.NtstepsUpstroke = num4
							Dim fileNumber8 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.Prhp
							FileSystem.FileGet(fileNumber8, num3, -1L)
							cRODSTAR.Prhp = num3
							Dim fileNumber9 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.Pprload
							FileSystem.FileGet(fileNumber9, num3, -1L)
							cRODSTAR.Pprload = num3
							Dim fileNumber10 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.StructL
							FileSystem.FileGet(fileNumber10, num3, -1L)
							cRODSTAR.StructL = num3
							Dim fileNumber11 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.USystemEff
							FileSystem.FileGet(fileNumber11, num3, -1L)
							cRODSTAR.USystemEff = num3
							Dim fileNumber12 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.TotalTheta
							FileSystem.FileGet(fileNumber12, num3, -1L)
							cRODSTAR.TotalTheta = num3
							Dim fileNumber13 As Integer = Conversions.ToInteger(frn)
							cRODSTAR = rst
							num3 = cRODSTAR.WrodsInFluid
							FileSystem.FileGet(fileNumber13, num3, -1L)
							cRODSTAR.WrodsInFluid = num3
							Dim num5 As Short
							Dim array2 As Single()
							Dim array3 As Single()
							Dim array4 As Single()
							Dim array5 As Single()
							Dim array6 As Single()
							Dim array7 As Single()
							Dim array8 As Single()
							Dim num10 As Short
							Dim num11 As Short
							Dim array As Single(,) = New Single(2, CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							num5 = 0S
							Do
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.CBE90(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.Clf(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.DollarsPerBblFluid(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.DollarsPerBblOil(CInt(num5)), -1L)
								Dim fileNumber14 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								Dim cRODSTAR2 As cRODSTAR = cRODSTAR
								num4 = num5
								num3 = cRODSTAR2.get_ElectricBillperMonth(CInt(num4))
								FileSystem.FileGet(fileNumber14, num3, -1L)
								cRODSTAR.set_ElectricBillperMonth(CInt(num4), num3)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.GearboxLoading(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.HpNemaD(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.HpUhs(CInt(num5)), -1L)
								Dim fileNumber15 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								Dim cRODSTAR3 As cRODSTAR = cRODSTAR
								num4 = num5
								num3 = cRODSTAR3.get_M(CInt(num4))
								FileSystem.FileGet(fileNumber15, num3, -1L)
								cRODSTAR.set_M(CInt(num4), num3)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.MotorKWH(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.PeakTorque(CInt(num5)), -1L)
								Dim num6 As Integer = CInt(FileSystem.Seek(Conversions.ToInteger(frn)))
								Dim num7 As Short = 0S
								Dim num8 As Short = rst.Ntsteps - 1S

									For num9 As Short = num7 To num8
										FileSystem.FileGet(Conversions.ToInteger(frn), array(CInt(num5), CInt(num9)), -1L)
									Next
									num5 += 1S

							Loop While num5 <= 2S
							rst.Tnet = array
							array2 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array3 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array4 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array5 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array6 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array7 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							array8 = New Single(CInt((rst.Ntsteps - 1S + 1S)) - 1) {}
							num10 = 0S
							num11 = rst.Ntsteps - 1S
							num5 = num10
							While num5 <= num11
								FileSystem.FileGet(Conversions.ToInteger(frn), array2(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array3(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array4(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array5(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array6(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array7(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), array8(CInt(num5)), -1L)
								num5 += 1S
							End While
							rst.SurfPos = array2
							rst.SurfLoad = array3
							rst.PumpPos = array4
							rst.PumpLoad = array5
							rst.PermLoad = array6
							rst.Thetac = array7
							rst.Tf = array8
							Dim num12 As Short = 1S
							Dim numRods As Short = rst.NumRods
							num5 = num12
							While num5 <= numRods
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.StressL(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.maxStressTop(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.minStressTop(CInt(num5)), -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.minStressBot(CInt(num5)), -1L)
								num5 += 1S
							End While
							num5 = 1S
							Do
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.LineSettings(CInt(num5)).LSet, -1L)
								FileSystem.FileGet(Conversions.ToInteger(frn), rst.LineSettings(CInt(num5)).Value, -1L)
								num5 += 1S
							Loop While num5 <= 4S
							If ThisVersion < 14S Then
								rst.UFeetFromSurface = 0F
								rst.UFeetOverPump = 0F
								rst.UFluidLoad = -1F
								rst.UNetProduction = 0F
								rst.UNetStrokeApparent = -1F
								rst.UPintakeFromLines = 0F
							Else
								Dim fileNumber16 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UFeetFromSurface
								FileSystem.FileGet(fileNumber16, num3, -1L)
								cRODSTAR.UFeetFromSurface = num3
								Dim fileNumber17 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UFeetOverPump
								FileSystem.FileGet(fileNumber17, num3, -1L)
								cRODSTAR.UFeetOverPump = num3
								Dim fileNumber18 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UFluidLoad
								FileSystem.FileGet(fileNumber18, num3, -1L)
								cRODSTAR.UFluidLoad = num3
								Dim fileNumber19 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UNetProduction
								FileSystem.FileGet(fileNumber19, num3, -1L)
								cRODSTAR.UNetProduction = num3
								Dim fileNumber20 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UNetStroke
								FileSystem.FileGet(fileNumber20, num3, -1L)
								cRODSTAR.UNetStroke = num3
								Dim fileNumber21 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UPintakeFromLines
								FileSystem.FileGet(fileNumber21, num3, -1L)
								cRODSTAR.UPintakeFromLines = num3
							End If
							If ThisVersion < 21S Then
								rst.PumpFriction = -1F
							Else
								Dim fileNumber22 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.PumpFriction
								FileSystem.FileGet(fileNumber22, num3, -1L)
								cRODSTAR.PumpFriction = num3
							End If
							rst.PumpFriction = 200F
							If ThisVersion < 22S Then
								rst.ULinesSetH = (rst.LineSettings(3).LSet And rst.LineSettings(4).LSet)
								rst.ULinesSetV = (rst.LineSettings(1).LSet And rst.LineSettings(2).LSet)
								rst.UNetStroke = rst.UNetStrokeApparent
							Else
								Dim fileNumber23 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num4 = cRODSTAR.ULinesSetH
								FileSystem.FileGet(fileNumber23, num4, -1L)
								cRODSTAR.ULinesSetH = num4
								Dim fileNumber24 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num4 = cRODSTAR.ULinesSetV
								FileSystem.FileGet(fileNumber24, num4, -1L)
								cRODSTAR.ULinesSetV = num4
								Dim fileNumber25 As Integer = Conversions.ToInteger(frn)
								cRODSTAR = rst
								num3 = cRODSTAR.UNetStrokeApparent
								FileSystem.FileGet(fileNumber25, num3, -1L)
								cRODSTAR.UNetStrokeApparent = num3
							End If
							bOutputLoaded = True
						End If
					End If
				End If
			Catch ex As Exception
				bOutputLoaded = True
				RSWIN_DESC.rst.gbOutputLoaded = False
			End Try
		End Sub

		Public Sub LoadRoddiagFile(ByRef frn As Short, ByRef bFileLoaded As Short, sInputfile As String)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Short
			FileSystem.FileGet(CInt(frn), num, -1L)
			If num > 29S Then
				Util.cErrmsg(114)
				Return
			End If
			Dim num2 As Short
			If num <= 15S Then
				num2 = 0S
			Else
				FileSystem.FileGet(CInt(frn), num2, -1L)
			End If
			rst.gbOutputOld = (num2 < 1S)
			rst.gbOutputLoaded = False
			Dim flag As Boolean
			Dim num3 As Short = If((-If((flag > False), 1S, 0S)), 1S, 0S)
			LOADRDG.LoadInputData(frn, num, num3)
			flag = (num3 <> 0S)
			Dim flag2 As Boolean = True
			rst.gbOutputLoaded = False
			If rst.gbBatch Then
				bFileLoaded = If((-If((flag > False), 1S, 0S)), 1S, 0S)
			Else
				bFileLoaded = If((-If(((flag AndAlso flag2) > False), 1S, 0S)), 1S, 0S)
			End If
			If bFileLoaded <> 0S Then
				RSWIN_DESC.pNtsteps = 0S
				Select Case rst.CBDataType
					Case 1S, 2S, 3S, 4S
					Case Else
						rst.CBDataType = 1S
				End Select
				rst.UnknownM = (rst.CBDataType = 1S And rst.get_M(2) = 0F)
				rst.bCBEDigitized = If((-If(((rst.CBDataType = 3S) > False), 1S, 0S)), 1S, 0S)
				rst.bCBEFromDisk = If((-If(((rst.CBDataType = 4S) > False), 1S, 0S)), 1S, 0S)
				rst.Apump = CSng((3.141592653589793 * Math.Pow(CDbl(rst.PlungerSize), 2.0) / 4.0))
				rst.OilSPGR = CSng((141.5 / (CDbl(rst.OilAPI) + 131.5)))
				rst.gfMaxFluidSPGR = LoadXDG.MaxFluidSPGR(rst.WaterCut, rst.WaterSPGR, rst.OilSPGR)
				If rst.FluidSPGR = 0F Then
					rst.gbCalcFluidSPGR = True
					rst.FluidSPGR = rst.gfMaxFluidSPGR
				ElseIf Not rst.gbCalcFluidSPGR Then
					If CDbl(Math.Abs(rst.FluidSPGR - rst.gfMaxFluidSPGR)) < 0.0005 Then
						rst.gbCalcFluidSPGR = True
						rst.FluidSPGR = rst.gfMaxFluidSPGR
					ElseIf rst.FluidSPGR > rst.gfMaxFluidSPGR Then
						rst.gbOutputLoaded = False
					End If
				End If
				Nothing.Initialize()
				Dim pu As RSWIN_DESC.PUDataRec = rst.PU
				If(If((-If((num <= 15S > False), 1S, 0S)), 1S, 0S) And Not rst.IDEntered And If((-If(((rst.PU.CrankHole = 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					pu.CrankHole = 1S
					pu.CrankHoles = 1S
					pu.CrankRadii(1) = pu.R
					pu.Strokes(1) = CSng(Conversion.Int(CDbl(pu.KinematicStroke) + 0.5))
				End If
				rst.PU = pu
				Dim text As String
				Dim num4 As Integer
				PUDATA1.ParseUnitID(rst.UnitID, text, num4)
				Dim text2 As String = text
				If Operators.CompareString(text2, "CAB", False) = 0 Then
					Dim cRODSTAR As cRODSTAR = rst
					Dim str As String = "CAA"
					Dim obj As Object = num4 + 98
					cRODSTAR.UnitID = str + Util.Format(obj).Trim()
				End If
				RODUTIL.CheckCustomRodGrades()
			Else
				Util.cErrmsg(168)
			End If
		End Sub

		Private Sub LoadInputData_new(ByRef frn As Short, ByRef iThisVersion As Short, ByRef bInputLoaded As Short)
			Dim array As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
			bInputLoaded = 0S
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				cRODSTAR.ACompanyName = New String(" "c, 40)
				Dim fileNumber As Integer = CInt(frn)
				Dim cRODSTAR2 As cRODSTAR = cRODSTAR
				Dim text As String = cRODSTAR2.ACompanyName
				FileSystem.FileGet(fileNumber, text, -1L, False)
				cRODSTAR2.ACompanyName = text
				cRODSTAR.WellName = New String(" "c, 40)
				Dim fileNumber2 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.WellName
				FileSystem.FileGet(fileNumber2, text, -1L, False)
				cRODSTAR2.WellName = text
				cRODSTAR.UserName = New String(" "c, 40)
				Dim fileNumber3 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.UserName
				FileSystem.FileGet(fileNumber3, text, -1L, False)
				cRODSTAR2.UserName = text
				cRODSTAR.UserDate = New String(" "c, 40)
				Dim fileNumber4 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.UserDate
				FileSystem.FileGet(fileNumber4, text, -1L, False)
				cRODSTAR2.UserDate = text
				Dim fileNumber5 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				Dim num As Single = cRODSTAR2.PumpDepth
				FileSystem.FileGet(fileNumber5, num, -1L)
				cRODSTAR2.PumpDepth = num
				Dim num2 As Short
				If iThisVersion < 15S Then
					FileSystem.FileGet(CInt(frn), num2, -1L)
				End If
				Dim fileNumber6 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.FluidLevel
				FileSystem.FileGet(fileNumber6, num, -1L)
				cRODSTAR2.FluidLevel = num
				Dim fileNumber7 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.SPM
				FileSystem.FileGet(fileNumber7, num, -1L)
				cRODSTAR2.SPM = num
				Dim fileNumber8 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				Dim num3 As Short = cRODSTAR2.DynaSource
				FileSystem.FileGet(fileNumber8, num3, -1L)
				cRODSTAR2.DynaSource = num3
				Dim fileNumber9 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num3 = cRODSTAR2.PumpType
				FileSystem.FileGet(fileNumber9, num3, -1L)
				cRODSTAR2.PumpType = num3
				Dim fileNumber10 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.PlungerSize
				FileSystem.FileGet(fileNumber10, num, -1L)
				cRODSTAR2.PlungerSize = num
				Dim fileNumber11 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.FluidSPGR
				FileSystem.FileGet(fileNumber11, num, -1L)
				cRODSTAR2.FluidSPGR = num
				Dim fileNumber12 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.Friction
				FileSystem.FileGet(fileNumber12, num, -1L)
				cRODSTAR2.Friction = num
				Dim fileNumber13 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingOD
				FileSystem.FileGet(fileNumber13, num, -1L)
				cRODSTAR2.TubingOD = num
				Dim fileNumber14 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingID
				FileSystem.FileGet(fileNumber14, num, -1L)
				cRODSTAR2.TubingID = num
				Dim fileNumber15 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num3 = cRODSTAR2.TubingAnchored
				FileSystem.FileGet(fileNumber15, num3, -1L)
				cRODSTAR2.TubingAnchored = num3
				Dim fileNumber16 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingAnchorDepth
				FileSystem.FileGet(fileNumber16, num, -1L)
				cRODSTAR2.TubingAnchorDepth = num
				Dim fileNumber17 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingPressure
				FileSystem.FileGet(fileNumber17, num, -1L)
				cRODSTAR2.TubingPressure = num
				Dim fileNumber18 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.CasingPressure
				FileSystem.FileGet(fileNumber18, num, -1L)
				cRODSTAR2.CasingPressure = num
				Dim fileNumber19 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num3 = cRODSTAR2.NumRods
				FileSystem.FileGet(fileNumber19, num3, -1L)
				cRODSTAR2.NumRods = num3
				Dim num4 As Integer = 1
				Dim numRods As Integer = CInt(cRODSTAR.NumRods)
				Dim pu As RSWIN_DESC.PUDataRec
				Dim num5 As Single
				For i As Integer = num4 To numRods
					array(i).Initialize()
					Dim grade As Short
					FileSystem.FileGet(CInt(frn), grade, -1L)
					array(i).Grade = grade
					FileSystem.FileGet(CInt(frn), array(i).Diameter, -1L)
					FileSystem.FileGet(CInt(frn), array(i).length, -1L)
					If iThisVersion < 11S Then
						FileSystem.FileGet(CInt(frn), num5, -1L)
					End If
					FileSystem.FileGet(CInt(frn), array(i).SuckerRodLength, -1L)
					FileSystem.FileGet(CInt(frn), array(i).RodDensity, -1L)
					FileSystem.FileGet(CInt(frn), array(i).RodWeight, -1L)
					FileSystem.FileGet(CInt(frn), array(i).Elasticity, -1L)
					FileSystem.FileGet(CInt(frn), array(i).Area, -1L)
					RODUTIL.ConvertRodGrade(array(i))
					If iThisVersion >= 9S Then
						Dim str As String = New String(" "c, 20)
						FileSystem.FileGet(CInt(frn), str, -1L, False)
						array(i).RodType = Strings.Trim(str)
						FileSystem.FileGet(CInt(frn), array(i).TensileStrength, -1L)
					Else
						array(i).RodType = RODUTIL.RodGrade(array(i).Grade)
						RODUTIL.LookupTensileStrength(array(i))
					End If
				Next
				cRODSTAR.Sections = array
				Dim fileNumber20 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.ServiceFactor
				FileSystem.FileGet(fileNumber20, num, -1L)
				cRODSTAR2.ServiceFactor = num
				Dim fileNumber21 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.UnitID
				FileSystem.FileGet(fileNumber21, text, -1L, False)
				cRODSTAR2.UnitID = text
				Dim fileNumber22 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num3 = cRODSTAR2.IDEntered
				FileSystem.FileGet(fileNumber22, num3, -1L)
				cRODSTAR2.IDEntered = num3
				cRODSTAR.PU.Initialize()
				pu.Initialize()
				FileSystem.FileGet(CInt(frn), pu.Manuf, -1L, False)
				FileSystem.FileGet(CInt(frn), pu.UnitName, -1L, False)
				FileSystem.FileGet(CInt(frn), pu.APIDesignation, -1L, False)
				FileSystem.FileGet(CInt(frn), pu.UnitType, -1L)
				FileSystem.FileGet(CInt(frn), pu.RequiredRotation, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRotation, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankHole, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankHoles, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(0), -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(1), -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(2), -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(3), -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(4), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(0), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(1), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(2), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(3), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(4), -1L)
				FileSystem.FileGet(CInt(frn), pu.KinematicStroke, -1L)
				If iThisVersion <= 14S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
				End If
				FileSystem.FileGet(CInt(frn), pu.R, -1L)
				FileSystem.FileGet(CInt(frn), pu.A, -1L)
				FileSystem.FileGet(CInt(frn), pu.C, -1L)
				FileSystem.FileGet(CInt(frn), pu.I, -1L)
				FileSystem.FileGet(CInt(frn), pu.K, -1L)
				FileSystem.FileGet(CInt(frn), pu.P, -1L)
				FileSystem.FileGet(CInt(frn), pu.M, -1L)
				FileSystem.FileGet(CInt(frn), pu.S, -1L)
				FileSystem.FileGet(CInt(frn), pu.V0, -1L)
				FileSystem.FileGet(CInt(frn), pu.DrumDiamRatio, -1L)
				FileSystem.FileGet(CInt(frn), pu.SprocketRadius, -1L)
				FileSystem.FileGet(CInt(frn), pu.SprocketDistance, -1L)
				FileSystem.FileGet(CInt(frn), pu.Unbalance, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankOffset, -1L)
				FileSystem.FileGet(CInt(frn), pu.StructRating, -1L)
				FileSystem.FileGet(CInt(frn), pu.GearboxRating, -1L)
				FileSystem.FileGet(CInt(frn), pu.MaxStroke, -1L)
				FileSystem.FileGet(CInt(frn), pu.ArtInertia, -1L)
				If iThisVersion = 1S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
				End If
				Dim fileNumber23 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.ElectricityCost
				FileSystem.FileGet(fileNumber23, num, -1L)
				cRODSTAR2.ElectricityCost = num
				Dim fileNumber24 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num3 = cRODSTAR2.PowerMeterType
				FileSystem.FileGet(fileNumber24, num3, -1L)
				cRODSTAR2.PowerMeterType = num3
				If iThisVersion < 9S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
				End If
				Dim fileNumber25 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num3 = cRODSTAR2.CBDataType
				FileSystem.FileGet(fileNumber25, num3, -1L)
				cRODSTAR2.CBDataType = num3
				Dim fileNumber26 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.CBEffect
				FileSystem.FileGet(fileNumber26, num, -1L)
				cRODSTAR2.CBEffect = num
				Dim fileNumber27 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.CBAngle
				FileSystem.FileGet(fileNumber27, num, -1L)
				cRODSTAR2.CBAngle = num
				Dim fileNumber28 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				Dim cRODSTAR3 As cRODSTAR = cRODSTAR2
				Dim index As Integer = 2
				num = cRODSTAR3.get_M(index)
				FileSystem.FileGet(fileNumber28, num, -1L)
				cRODSTAR2.set_M(index, num)
				If iThisVersion < 3S Then
					Dim value As Single
					FileSystem.FileGet(CInt(frn), value, -1L)
					Dim value2 As Single
					FileSystem.FileGet(CInt(frn), value2, -1L)
					Select Case pu.UnitType
						Case 6S
							cRODSTAR.set_M(2, value2)
							GoTo IL_901
						Case 7S, 10S
							cRODSTAR.set_M(2, value)
							GoTo IL_901
						Case 8S
							cRODSTAR.set_M(2, cRODSTAR.PU.M * 1000F)
							GoTo IL_901
					End Select
					cRODSTAR.set_M(2, cRODSTAR.get_M(2) * 1000F)
				End If
				IL_901:
				Dim fileNumber29 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num3 = cRODSTAR2.dNtsteps
				FileSystem.FileGet(fileNumber29, num3, -1L)
				cRODSTAR2.dNtsteps = num3
				If cRODSTAR.dNtsteps > 0S Then
					Dim num9 As Single
					Dim num10 As Short
					Dim iTorqueMode As Short
					Dim sMotorSizeName As String
					Dim flag As Boolean
					Dim obj As Object
					Dim array2 As Single() = New Single(CInt((cRODSTAR.dNtsteps - 1S + 1S)) - 1) {}
					Dim array3 As Single() = New Single(CInt((cRODSTAR.dNtsteps - 1S + 1S)) - 1) {}
					Dim num6 As Integer = 0
					Dim num7 As Integer = CInt((cRODSTAR.dNtsteps - 1S))
					For i As Integer = num6 To num7
						FileSystem.FileGet(CInt(frn), array2(i), -1L)
						FileSystem.FileGet(CInt(frn), array3(i), -1L)
					Next
					cRODSTAR.dSurfPos = array2
					cRODSTAR.dSurfLoad = array3
					If iThisVersion >= 2S Then
						If iThisVersion = 2S Then
							Dim dynaFile As String = Strings.Space(CInt((FileSystem.LOF(CInt(frn)) - FileSystem.Loc(CInt(frn)) - 12L)))
							FileSystem.FileGet(CInt(frn), dynaFile, -1L, False)
							cRODSTAR.DynaFile = dynaFile
						Else
							Dim fileNumber30 As Integer = CInt(frn)
							cRODSTAR2 = cRODSTAR
							text = cRODSTAR2.DynaFile
							FileSystem.FileGet(fileNumber30, text, -1L, False)
							cRODSTAR2.DynaFile = text
						End If
						Dim fileNumber31 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.Runtime
						FileSystem.FileGet(fileNumber31, num, -1L)
						cRODSTAR2.Runtime = num
						Dim num8 As Single
						FileSystem.FileGet(CInt(frn), num8, -1L)
						Dim fileNumber32 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.WaterCut
						FileSystem.FileGet(fileNumber32, num, -1L)
						cRODSTAR2.WaterCut = num
					Else
						cRODSTAR.DynaFile = "(unknown)"
						cRODSTAR.Runtime = 24F
						Dim num8 As Single = 100F
						cRODSTAR.WaterCut = 0F
					End If
					If iThisVersion >= 3S Then
						Dim fileNumber33 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.OilAPI
						FileSystem.FileGet(fileNumber33, num, -1L)
						cRODSTAR2.OilAPI = num
					Else
						cRODSTAR.OilAPI = 30F
					End If
					If iThisVersion >= 4S Then
						Dim fileNumber34 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.MeasuredStroke
						FileSystem.FileGet(fileNumber34, num, -1L)
						cRODSTAR2.MeasuredStroke = num
					Else
						cRODSTAR.MeasuredStroke = 0F
					End If
					If iThisVersion < 5S Then
						num9 = 0F
					ElseIf iThisVersion < 11S Then
						FileSystem.FileGet(CInt(frn), num9, -1L)
						If num9 = 0F Then
							cRODSTAR.CalcMotorSize = -1S
							num9 = 50F
						Else
							cRODSTAR.CalcMotorSize = 0S
							num9 = RODUTIL.StdMotorSize(num9)
						End If
						num10 = 1S
					End If
					If iThisVersion >= 6S Then
						Dim fileNumber35 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.UPumpFillage
						FileSystem.FileGet(fileNumber35, num, -1L)
						cRODSTAR2.UPumpFillage = num
					End If
					If iThisVersion >= 7S Then
						Dim fileNumber36 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num3 = cRODSTAR2.LeutertDynamometer
						FileSystem.FileGet(fileNumber36, num3, -1L)
						cRODSTAR2.LeutertDynamometer = num3
						Dim frn2 As Short = frn
						cRODSTAR2 = cRODSTAR
						text = cRODSTAR2.LeutertModel
						FILEIO.GetString(frn2, text)
						cRODSTAR2.LeutertModel = text
						Dim fileNumber37 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num3 = cRODSTAR2.LeutertSpring
						FileSystem.FileGet(fileNumber37, num3, -1L)
						cRODSTAR2.LeutertSpring = num3
						Dim fileNumber38 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.LeutertScale
						FileSystem.FileGet(fileNumber38, num, -1L)
						cRODSTAR2.LeutertScale = num
					Else
						cRODSTAR.LeutertDynamometer = 0S
					End If
					If iThisVersion >= 8S Then
						Dim frn3 As Short = frn
						cRODSTAR2 = cRODSTAR
						text = cRODSTAR2.DynoDate
						FILEIO.GetString(frn3, text)
						cRODSTAR2.DynoDate = text
					Else
						cRODSTAR.DynoDate = RSWIN_DESC.sNull
					End If
					If iThisVersion >= 9S Then
						FILEIO.GetString(frn, pu.OtherInfo)
					Else
						pu.OtherInfo = ""
					End If
					cRODSTAR.PU = pu
					If iThisVersion >= 10S Then
						Dim frn4 As Short = frn
						cRODSTAR2 = cRODSTAR
						text = cRODSTAR2.CBDataFile
						FILEIO.GetString(frn4, text)
						cRODSTAR2.CBDataFile = text
					Else
						cRODSTAR.CBDataFile = ""
					End If
					If iThisVersion >= 11S Then
						Dim fileNumber39 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.WaterSPGR
						FileSystem.FileGet(fileNumber39, num, -1L)
						cRODSTAR2.WaterSPGR = num
						If cRODSTAR.WaterSPGR < 1F Then
							cRODSTAR.WaterSPGR = 1F
						ElseIf CDbl(cRODSTAR.WaterSPGR) > 1.5 Then
							cRODSTAR.WaterSPGR = 1.5F
						End If
						Dim fileNumber40 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num3 = cRODSTAR2.CalcMotorSize
						FileSystem.FileGet(fileNumber40, num3, -1L)
						cRODSTAR2.CalcMotorSize = num3
						If iThisVersion < 20S Then
							FileSystem.FileGet(CInt(frn), num10, -1L)
							FileSystem.FileGet(CInt(frn), num9, -1L)
							FileSystem.FileGet(CInt(frn), iTorqueMode, -1L)
							FILEIO.GetString(frn, sMotorSizeName)
						End If
					Else
						cRODSTAR.WaterSPGR = 1F
					End If
					If iThisVersion >= 15S Then
						Dim fileNumber41 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num3 = cRODSTAR2.giFluidLevelSource
						FileSystem.FileGet(fileNumber41, num3, -1L)
						cRODSTAR2.giFluidLevelSource = num3
						Dim fileNumber42 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.UPumpIntakePressure
						FileSystem.FileGet(fileNumber42, num, -1L)
						cRODSTAR2.UPumpIntakePressure = num
						Dim fileNumber43 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						flag = cRODSTAR2.gbUseIPR
						FileSystem.FileGet(fileNumber43, flag, -1L)
						cRODSTAR2.gbUseIPR = flag
						Dim fileNumber44 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num3 = cRODSTAR2.giIPRMethod
						FileSystem.FileGet(fileNumber44, num3, -1L)
						cRODSTAR2.giIPRMethod = num3
						Dim fileNumber45 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.MidPerfDepth
						FileSystem.FileGet(fileNumber45, num, -1L)
						cRODSTAR2.MidPerfDepth = num
						Dim fileNumber46 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.StaticBHPressure
						FileSystem.FileGet(fileNumber46, num, -1L)
						cRODSTAR2.StaticBHPressure = num
						Dim fileNumber47 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.BubblePoint
						FileSystem.FileGet(fileNumber47, num, -1L)
						cRODSTAR2.BubblePoint = num
						Dim fileNumber48 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num3 = cRODSTAR2.gnTestPoints
						FileSystem.FileGet(fileNumber48, num3, -1L)
						cRODSTAR2.gnTestPoints = num3
						Dim array4 As RSWIN_DESC.IPRTESTPOINT()
						If cRODSTAR.gnTestPoints = 0S Or Not cRODSTAR.gbUseIPR Then
							array4 = New RSWIN_DESC.IPRTESTPOINT(0) {}
						Else
							array4 = New RSWIN_DESC.IPRTESTPOINT(CInt((cRODSTAR.gnTestPoints + 1S)) - 1) {}
							Dim num11 As Integer = 1
							Dim gnTestPoints As Integer = CInt(cRODSTAR.gnTestPoints)
							For i As Integer = num11 To gnTestPoints
								FileSystem.FileGet(CInt(frn), array4(i).bPIEntered, -1L)
								FileSystem.FileGet(CInt(frn), array4(i).Pintake, -1L)
								FileSystem.FileGet(CInt(frn), array4(i).Pwf, -1L)
								FileSystem.FileGet(CInt(frn), array4(i).Production, -1L)
							Next
						End If
						cRODSTAR.TestPoints = array4
						If Not cRODSTAR.gbUseIPR Then
							cRODSTAR.gnTestPoints = 0S
							array4 = New RSWIN_DESC.IPRTESTPOINT(0) {}
							cRODSTAR.TestPoints = array4
							cRODSTAR.MidPerfDepth = -1F
							cRODSTAR.StaticBHPressure = -1F
							cRODSTAR.BubblePoint = -1F
						End If
					Else
						cRODSTAR.giFluidLevelSource = Conversions.ToShort(Interaction.IIf(num2 <> 0S, 1, 0))
						cRODSTAR.gbUseIPR = False
						cRODSTAR.gnTestPoints = 0S
						Dim array4 As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(0) {}
						cRODSTAR.TestPoints = array4
						cRODSTAR.MidPerfDepth = -1F
						cRODSTAR.StaticBHPressure = -1F
						cRODSTAR.BubblePoint = -1F
					End If
					If iThisVersion >= 17S Then
						Dim fileNumber49 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						flag = cRODSTAR2.gbProducingBelowBPP
						FileSystem.FileGet(fileNumber49, flag, -1L)
						cRODSTAR2.gbProducingBelowBPP = flag
					Else
						cRODSTAR.gbProducingBelowBPP = False
					End If
					If iThisVersion >= 18S Then
						Dim frn5 As Short = frn
						cRODSTAR2 = cRODSTAR
						text = cRODSTAR2.FileComment
						FILEIO.GetString(frn5, text)
						cRODSTAR2.FileComment = text
						Dim fileNumber50 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						flag = cRODSTAR2.gbCalcFetkovichN
						FileSystem.FileGet(fileNumber50, flag, -1L)
						cRODSTAR2.gbCalcFetkovichN = flag
						Dim fileNumber51 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.FetkovichN
						FileSystem.FileGet(fileNumber51, num, -1L)
						cRODSTAR2.FetkovichN = num
						If cRODSTAR.giIPRMethod <> 0S Then
							cRODSTAR.gbCalcFetkovichN = True
						End If
					Else
						cRODSTAR.FileComment = RSWIN_DESC.sNull
						cRODSTAR.gbCalcFetkovichN = True
						cRODSTAR.FetkovichN = -1F
					End If
					If iThisVersion >= 19S Then
						Dim fileNumber52 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.MeasuredTVLoad
						FileSystem.FileGet(fileNumber52, num, -1L)
						cRODSTAR2.MeasuredTVLoad = num
						Dim fileNumber53 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.MeasuredSVLoad
						FileSystem.FileGet(fileNumber53, num, -1L)
						cRODSTAR2.MeasuredSVLoad = num
					Else
						cRODSTAR.MeasuredTVLoad = 0F
						cRODSTAR.MeasuredSVLoad = 0F
					End If
					If iThisVersion >= 20S Then
						Motor.ReadMotorData(CInt(frn))
					Else
						Select Case num10
							Case 1S, 2S, 3S, 4S, 7S, 8S
								GoTo IL_1129
						End Select
						num10 = 1S
						cRODSTAR.CalcMotorSize = -1S
						IL_1129:
						Motor.SelectMotorFromOldInfo(CInt(num10), num9, sMotorSizeName, CInt(iTorqueMode))
					End If
					If iThisVersion >= 21S Then
						Dim fileNumber54 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						flag = cRODSTAR2.gbIncludeBuoyancy
						FileSystem.FileGet(fileNumber54, flag, -1L)
						cRODSTAR2.gbIncludeBuoyancy = flag
					Else
						cRODSTAR.gbIncludeBuoyancy = True
					End If
					If iThisVersion >= 23S Then
						Dim num12 As Integer = CInt(FileSystem.Seek(CInt(frn)))
						Dim fileNumber55 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						flag = cRODSTAR2.gbCalcFluidSPGR
						FileSystem.FileGet(fileNumber55, flag, -1L)
						cRODSTAR2.gbCalcFluidSPGR = flag
						Try
							If iThisVersion >= 25S And (pu.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) Then
								Dim fileNumber56 As Integer = CInt(frn)
								cRODSTAR2 = cRODSTAR
								flag = cRODSTAR2.bUnknownUnbalance
								FileSystem.FileGet(fileNumber56, flag, -1L)
								cRODSTAR2.bUnknownUnbalance = flag
							End If
						Catch ex As Exception
							cRODSTAR.gbOutputLoaded = False
						End Try
						obj = frn
						Dim flag2 As Boolean
						LOADRDG.LoadOutputData_new(obj, iThisVersion, flag2)
						frn = Conversions.ToShort(obj)
					ElseIf iThisVersion > 23S Then
						Dim fileNumber57 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						flag = cRODSTAR2.gbCalcFluidSPGR
						FileSystem.FileGet(fileNumber57, flag, -1L)
						cRODSTAR2.gbCalcFluidSPGR = flag
					Else
						cRODSTAR.gbCalcFluidSPGR = True
					End If
					bInputLoaded = -1S
					cRODSTAR.UnknownM = True
					If cRODSTAR.CBDataType = 1S And cRODSTAR.get_M(2) <> 0F Then
						cRODSTAR.UnknownM = False
					End If
					cRODSTAR.gbRoddiagFile = True
					cRODSTAR.PumpFriction = 200F
					cRODSTAR.SPMEntered = -1S
					cRODSTAR.CalcPlungerSize = 0S
					Dim num13 As Short
					Select Case num13
						Case 0S
							cRODSTAR.FluidLevel = cRODSTAR.PumpDepth
							cRODSTAR.FluidLevelEntered = True
						Case 1S
							cRODSTAR.FluidLevelEntered = True
						Case 2S
							cRODSTAR.FluidLevelEntered = False
					End Select
					If cRODSTAR.PumpFillage >= 0F Then
						cRODSTAR.PumpFillage = Conversion.Int(cRODSTAR.PumpFillage * 100F)
						If cRODSTAR.PumpFillage > 95F Then
							cRODSTAR.PumpFillage = 95F
						End If
					Else
						Dim cRODSTAR4 As cRODSTAR = cRODSTAR
						Dim sDefaultName As String = "PumpFillage"
						Dim vNotPresentDefault As Object = 85
						flag = False
						cRODSTAR4.PumpFillage = Conversions.ToSingle(ini.GetDefault(sDefaultName, vNotPresentDefault, flag))
					End If
					cRODSTAR.RodStringType = 2S
					cRODSTAR.APIRod = 0S
					cRODSTAR.APIGrade = 0S
					cRODSTAR.RSGrade = 0S
					cRODSTAR.RSMaxSize = 0F
					cRODSTAR.RSMinSize = 0F
					Dim sinkerBar As RSWIN_DESC.RodSection
					cRODSTAR.SinkerBar = sinkerBar
					cRODSTAR.OilSPGR = CSng((141.5 / (CDbl(cRODSTAR.OilAPI) + 131.5)))
					If cRODSTAR.FluidSPGR = 0F Then
						cRODSTAR.FluidSPGR = cRODSTAR.WaterCut / 100F * cRODSTAR.WaterSPGR + (1F - cRODSTAR.WaterCut / 100F) * cRODSTAR.OilSPGR
					End If
					If(If((-If((iThisVersion <= 15S > False), 1S, 0S)), 1S, 0S) And Not cRODSTAR.IDEntered And If((-If(((pu.CrankHole = 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						pu.CrankHole = 1S
						pu.CrankHoles = 1S
						pu.CrankRadii(0) = pu.R
						pu.Strokes(0) = CSng(Conversion.Int(CDbl(pu.KinematicStroke) + 0.5))
					End If
					cRODSTAR.PU = pu
					RSWIN_DESC.WarnedAboutFluidInertia = 0S
					RSWIN_DESC.WarnedAboutPlungerSize = 0S
					cRODSTAR.PumpCondition = 1S
					Dim cRODSTAR5 As cRODSTAR = cRODSTAR
					Dim sDefaultName2 As String = "PumpEfficiency"
					Dim vNotPresentDefault2 As Object = 85
					flag = False
					cRODSTAR5.PumpEfficiency = Conversions.ToSingle(ini.GetDefault(sDefaultName2, vNotPresentDefault2, flag))
					cRODSTAR.IncludeFluidInertia = If((-If(((MImpred.FluidInertiaPossible() And cRODSTAR.PumpDepth < 4250F And cRODSTAR.PlungerSize > 2F) > False), 1S, 0S)), 1S, 0S)
					Dim cRODSTAR6 As cRODSTAR = cRODSTAR
					Dim sDefaultName3 As String = "CompressibilityIndex"
					Dim vNotPresentDefault3 As Object = 3
					flag = False
					cRODSTAR6.CompressibilityIndex = Conversions.ToSingle(ini.GetDefault(sDefaultName3, vNotPresentDefault3, flag))
					If cRODSTAR.IDEntered <> 0S Then
						cRODSTAR.Iart = cRODSTAR.PU.ArtInertia
					End If
					cRODSTAR.Irot = 0F
					cRODSTAR.IrotEntered = 0S
					cRODSTAR.UpstrokeFriction = 0F
					cRODSTAR.DownstrokeFriction = 0F
					If RSWIN_DESC.bRodStarD Then
						RSWIN_DESC.rst.Friction = 0.2F
						RSWIN_DESC.rst.DownstrokeFriction = 0.1F
						RSWIN_DESC.rst.UpstrokeFriction = 0.1F
						RSWIN_DESC.rst.CalcFriction = 0S
					Else
						RSWIN_DESC.rst.Friction = 2F
						RSWIN_DESC.rst.DownstrokeFriction = 1F
						RSWIN_DESC.rst.UpstrokeFriction = 1F
						RSWIN_DESC.rst.CalcFriction = -1S
					End If
					RSWIN_DESC.rst.SlideFricCoeff = 0.2F
					Dim unitID As String = cRODSTAR.UnitID
					Dim num14 As Short
					obj = num14
					Dim text2 As String
					PUDATA1.ParseUnitID(unitID, text2, obj)
					num14 = Conversions.ToShort(obj)
					Dim text3 As String = text2
					If Operators.CompareString(text3, "CAB", False) = 0 Then
						Dim cRODSTAR7 As cRODSTAR = cRODSTAR
						Dim str2 As String = "CAA"
						obj = CInt((num14 + 98S))
						cRODSTAR7.UnitID = str2 + Util.Format(obj).Trim()
					End If
					Dim cRODSTAR8 As cRODSTAR = cRODSTAR
					Dim sDefaultName4 As String = "StuffingBoxFriction"
					Dim vNotPresentDefault4 As Object = 100
					flag = False
					cRODSTAR8.StuffingBoxFriction = Conversions.ToSingle(ini.GetDefault(sDefaultName4, vNotPresentDefault4, flag))
					Dim cRODSTAR9 As cRODSTAR = cRODSTAR
					Dim sDefaultName5 As String = "PumpLoadAdjustment"
					Dim vNotPresentDefault5 As Object = 0
					flag = False
					cRODSTAR9.PumpLoadAdj = Conversions.ToSingle(ini.GetDefault(sDefaultName5, vNotPresentDefault5, flag))
					If iThisVersion <= 19S Then
						If num10 = 0S Then
							num10 = 1S
							cRODSTAR.CalcMotorSize = -1S
							num9 = 50F
						End If
						Motor.SelectMotorFromOldInfo(CInt(num10), num9, sMotorSizeName, CInt(iTorqueMode))
					End If
					Dim motorInfo As Object = Motor.GetMotorInfo(4)
					If Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 1, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 7, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 8, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 9, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 10, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 11, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 12, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 13, False))), True, False)) Then
						cRODSTAR.MotorSPV = 0F
						cRODSTAR.CalcMotorSPV = 0S
					ElseIf Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 3, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 2, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 4, False))), True, False)) Then
						cRODSTAR.MotorSPV = 0F
						cRODSTAR.CalcMotorSPV = -1S
					Else
						num10 = 1S
						cRODSTAR.CalcMotorSize = -1S
						cRODSTAR.CalcMotorSPV = 0S
					End If
					RODUTIL.CheckCustomRodGrades()
					cRODSTAR.gbOutputLoaded = False
					If RSWIN_DESC.rst.WaterSPGR < 1F Then
						RSWIN_DESC.rst.WaterSPGR = 1F
					ElseIf CDbl(RSWIN_DESC.rst.WaterSPGR) > 1.5 Then
						RSWIN_DESC.rst.WaterSPGR = 1.5F
					End If
					cRODSTAR = Nothing
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub LoadInputData_old(ByRef frn As Short, ByRef iThisVersion As Short, ByRef bInputLoaded As Short)
			Dim array As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}
			bInputLoaded = 0S
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				cRODSTAR.ACompanyName = New String(" "c, 40)
				Dim fileNumber As Integer = CInt(frn)
				Dim cRODSTAR2 As cRODSTAR = cRODSTAR
				Dim text As String = cRODSTAR2.ACompanyName
				FileSystem.FileGet(fileNumber, text, -1L, False)
				cRODSTAR2.ACompanyName = text
				cRODSTAR.WellName = New String(" "c, 40)
				Dim fileNumber2 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.WellName
				FileSystem.FileGet(fileNumber2, text, -1L, False)
				cRODSTAR2.WellName = text
				cRODSTAR.UserName = New String(" "c, 40)
				Dim fileNumber3 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.UserName
				FileSystem.FileGet(fileNumber3, text, -1L, False)
				cRODSTAR2.UserName = text
				cRODSTAR.UserDate = New String(" "c, 40)
				Dim fileNumber4 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.UserDate
				FileSystem.FileGet(fileNumber4, text, -1L, False)
				cRODSTAR2.UserDate = text
				Dim fileNumber5 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				Dim num As Single = cRODSTAR2.PumpDepth
				FileSystem.FileGet(fileNumber5, num, -1L)
				cRODSTAR2.PumpDepth = num
				Dim giFluidLevelSource As Short
				If iThisVersion < 15S Then
					Dim num2 As Short
					FileSystem.FileGet(CInt(frn), num2, -1L)
					giFluidLevelSource = Conversions.ToShort(Interaction.IIf(num2 <> 0S, 1, 0))
					cRODSTAR.giFluidLevelSource = giFluidLevelSource
				End If
				Dim fileNumber6 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.FluidLevel
				FileSystem.FileGet(fileNumber6, num, -1L)
				cRODSTAR2.FluidLevel = num
				Dim fileNumber7 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.SPM
				FileSystem.FileGet(fileNumber7, num, -1L)
				cRODSTAR2.SPM = num
				Dim num3 As Short
				FileSystem.FileGet(CInt(frn), num3, -1L)
				Dim fileNumber8 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				Dim num4 As Short = cRODSTAR2.PumpType
				FileSystem.FileGet(fileNumber8, num4, -1L)
				cRODSTAR2.PumpType = num4
				Dim fileNumber9 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.PlungerSize
				FileSystem.FileGet(fileNumber9, num, -1L)
				cRODSTAR2.PlungerSize = num
				Dim fileNumber10 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.FluidSPGR
				FileSystem.FileGet(fileNumber10, num, -1L)
				cRODSTAR2.FluidSPGR = num
				Dim num5 As Single
				FileSystem.FileGet(CInt(frn), num5, -1L)
				If RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.rst.Friction = 0.2F
					RSWIN_DESC.rst.DownstrokeFriction = 0.1F
					RSWIN_DESC.rst.UpstrokeFriction = 0.1F
				Else
					RSWIN_DESC.rst.Friction = 2F
					RSWIN_DESC.rst.DownstrokeFriction = 1F
					RSWIN_DESC.rst.UpstrokeFriction = 1F
				End If
				RSWIN_DESC.rst.SlideFricCoeff = 0.2F
				Dim fileNumber11 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingOD
				FileSystem.FileGet(fileNumber11, num, -1L)
				cRODSTAR2.TubingOD = num
				Dim fileNumber12 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingID
				FileSystem.FileGet(fileNumber12, num, -1L)
				cRODSTAR2.TubingID = num
				Dim fileNumber13 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.TubingAnchored
				FileSystem.FileGet(fileNumber13, num4, -1L)
				cRODSTAR2.TubingAnchored = num4
				Dim fileNumber14 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingAnchorDepth
				FileSystem.FileGet(fileNumber14, num, -1L)
				cRODSTAR2.TubingAnchorDepth = num
				Dim fileNumber15 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingPressure
				FileSystem.FileGet(fileNumber15, num, -1L)
				cRODSTAR2.TubingPressure = num
				Dim fileNumber16 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.CasingPressure
				FileSystem.FileGet(fileNumber16, num, -1L)
				cRODSTAR2.CasingPressure = num
				Dim fileNumber17 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.NumRods
				FileSystem.FileGet(fileNumber17, num4, -1L)
				cRODSTAR2.NumRods = num4
				Dim num6 As Integer = 1
				Dim numRods As Integer = CInt(cRODSTAR.NumRods)
				Dim pu As RSWIN_DESC.PUDataRec
				Dim flag As Boolean
				Dim num9 As Single
				Dim num10 As Short
				Dim iTorqueMode As Short
				Dim sMotorSizeName As String
				For i As Integer = num6 To numRods
					array(i).Initialize()
					FileSystem.FileGet(CInt(frn), array(i).Grade, -1L)
					FileSystem.FileGet(CInt(frn), array(i).Diameter, -1L)
					FileSystem.FileGet(CInt(frn), array(i).length, -1L)
					If iThisVersion < 11S Then
						FileSystem.FileGet(CInt(frn), num5, -1L)
					End If
					FileSystem.FileGet(CInt(frn), array(i).SuckerRodLength, -1L)
					FileSystem.FileGet(CInt(frn), array(i).RodDensity, -1L)
					FileSystem.FileGet(CInt(frn), array(i).RodWeight, -1L)
					FileSystem.FileGet(CInt(frn), array(i).Elasticity, -1L)
					FileSystem.FileGet(CInt(frn), array(i).Area, -1L)
					RODUTIL.ConvertRodGrade(array(i))
					If iThisVersion >= 9S Then
						FileSystem.FileGet(CInt(frn), array(i).RodType, -1L, False)
						FileSystem.FileGet(CInt(frn), array(i).TensileStrength, -1L)
					Else
						array(i).RodType = RODUTIL.RodGrade(array(i).Grade)
						RODUTIL.LookupTensileStrength(array(i))
					End If
					Try
						array(i).Guide = RSWIN_DESC.MOLDED
						array(i).friction_coef = 0.2F
					Catch ex As Exception
					End Try
				Next
				cRODSTAR.Sections = array
				Dim fileNumber18 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.ServiceFactor
				FileSystem.FileGet(fileNumber18, num, -1L)
				cRODSTAR2.ServiceFactor = num
				Dim fileNumber19 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.UnitID
				FileSystem.FileGet(fileNumber19, text, -1L, False)
				cRODSTAR2.UnitID = text
				Dim fileNumber20 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.IDEntered
				FileSystem.FileGet(fileNumber20, num4, -1L)
				cRODSTAR2.IDEntered = num4
				cRODSTAR.PU.Initialize()
				pu.Initialize()
				FileSystem.FileGet(CInt(frn), pu.Manuf, -1L, False)
				FileSystem.FileGet(CInt(frn), pu.UnitName, -1L, False)
				FileSystem.FileGet(CInt(frn), pu.APIDesignation, -1L, False)
				FileSystem.FileGet(CInt(frn), pu.UnitType, -1L)
				FileSystem.FileGet(CInt(frn), pu.RequiredRotation, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRotation, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankHole, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankHoles, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(0), -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(1), -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(2), -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(3), -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankRadii(4), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(0), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(1), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(2), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(3), -1L)
				FileSystem.FileGet(CInt(frn), pu.Strokes(4), -1L)
				FileSystem.FileGet(CInt(frn), pu.KinematicStroke, -1L)
				If iThisVersion <= 14S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
				End If
				FileSystem.FileGet(CInt(frn), pu.R, -1L)
				FileSystem.FileGet(CInt(frn), pu.A, -1L)
				FileSystem.FileGet(CInt(frn), pu.C, -1L)
				FileSystem.FileGet(CInt(frn), pu.I, -1L)
				FileSystem.FileGet(CInt(frn), pu.K, -1L)
				FileSystem.FileGet(CInt(frn), pu.P, -1L)
				FileSystem.FileGet(CInt(frn), pu.M, -1L)
				FileSystem.FileGet(CInt(frn), pu.S, -1L)
				FileSystem.FileGet(CInt(frn), pu.V0, -1L)
				FileSystem.FileGet(CInt(frn), pu.DrumDiamRatio, -1L)
				FileSystem.FileGet(CInt(frn), pu.SprocketRadius, -1L)
				FileSystem.FileGet(CInt(frn), pu.SprocketDistance, -1L)
				FileSystem.FileGet(CInt(frn), pu.Unbalance, -1L)
				FileSystem.FileGet(CInt(frn), pu.CrankOffset, -1L)
				FileSystem.FileGet(CInt(frn), pu.StructRating, -1L)
				FileSystem.FileGet(CInt(frn), pu.GearboxRating, -1L)
				FileSystem.FileGet(CInt(frn), pu.MaxStroke, -1L)
				FileSystem.FileGet(CInt(frn), pu.ArtInertia, -1L)
				If iThisVersion = 1S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
				End If
				Dim fileNumber21 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.ElectricityCost
				FileSystem.FileGet(fileNumber21, num, -1L)
				cRODSTAR2.ElectricityCost = num
				If cRODSTAR.ElectricityCost = 0F Then
					Try
						Dim cRODSTAR3 As cRODSTAR = cRODSTAR
						Dim sDefaultName As String = "ElectricityCost"
						Dim vNotPresentDefault As Object = 0.06
						flag = False
						cRODSTAR3.ElectricityCost = Conversions.ToSingle(ini.GetDefault(sDefaultName, vNotPresentDefault, flag))
					Catch ex2 As Exception
					End Try
				End If
				Dim fileNumber22 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.PowerMeterType
				FileSystem.FileGet(fileNumber22, num4, -1L)
				cRODSTAR2.PowerMeterType = num4
				If iThisVersion < 9S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
				End If
				Dim fileNumber23 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.CBDataType
				FileSystem.FileGet(fileNumber23, num4, -1L)
				cRODSTAR2.CBDataType = num4
				FileSystem.FileGet(CInt(frn), num5, -1L)
				FileSystem.FileGet(CInt(frn), num5, -1L)
				Dim fileNumber24 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				Dim cRODSTAR4 As cRODSTAR = cRODSTAR2
				Dim index As Integer = 2
				num = cRODSTAR4.get_M(index)
				FileSystem.FileGet(fileNumber24, num, -1L)
				cRODSTAR2.set_M(index, num)
				If iThisVersion < 3S Then
					Select Case pu.UnitType
						Case 6S
							FileSystem.FileGet(CInt(frn), num5, -1L)
							Dim fileNumber25 As Integer = CInt(frn)
							cRODSTAR2 = cRODSTAR
							Dim cRODSTAR5 As cRODSTAR = cRODSTAR2
							index = 2
							num = cRODSTAR5.get_M(index)
							FileSystem.FileGet(fileNumber25, num, -1L)
							cRODSTAR2.set_M(index, num)
							GoTo IL_9D9
						Case 7S, 10S
							Dim fileNumber26 As Integer = CInt(frn)
							cRODSTAR2 = cRODSTAR
							Dim cRODSTAR6 As cRODSTAR = cRODSTAR2
							index = 2
							num = cRODSTAR6.get_M(index)
							FileSystem.FileGet(fileNumber26, num, -1L)
							cRODSTAR2.set_M(index, num)
							FileSystem.FileGet(CInt(frn), num5, -1L)
							GoTo IL_9D9
					End Select
					FileSystem.FileGet(CInt(frn), num5, -1L)
					FileSystem.FileGet(CInt(frn), num5, -1L)
					cRODSTAR.set_M(2, cRODSTAR.get_M(2) * 1000F)
				End If
				IL_9D9:
				Dim fileNumber27 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.RDNtsteps
				FileSystem.FileGet(fileNumber27, num4, -1L)
				cRODSTAR2.RDNtsteps = num4
				If cRODSTAR.RDNtsteps > 0S Then
					Dim array2 As Single() = New Single(CInt((cRODSTAR.RDNtsteps - 1S + 1S)) - 1) {}
					Dim array3 As Single() = New Single(CInt((cRODSTAR.RDNtsteps - 1S + 1S)) - 1) {}
					Dim num7 As Integer = 0
					Dim num8 As Integer = CInt((cRODSTAR.RDNtsteps - 1S))
					For i As Integer = num7 To num8
						FileSystem.FileGet(CInt(frn), array2(i), -1L)
						FileSystem.FileGet(CInt(frn), array3(i), -1L)
					Next
					cRODSTAR.RDSurfPos = array2
					cRODSTAR.RDSurfLoad = array3
				End If
				Dim text2 As String
				If iThisVersion >= 2S Then
					If iThisVersion = 2S Then
						text2 = Strings.Space(CInt((FileSystem.LOF(CInt(frn)) - FileSystem.Loc(CInt(frn)) - 12L)))
						FileSystem.FileGet(CInt(frn), text2, -1L, False)
						cRODSTAR.DynaFile = ""
					Else
						Dim fileNumber28 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						text = cRODSTAR2.DynaFile
						FileSystem.FileGet(fileNumber28, text, -1L, False)
						cRODSTAR2.DynaFile = text
					End If
					Dim fileNumber29 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.Runtime
					FileSystem.FileGet(fileNumber29, num, -1L)
					cRODSTAR2.Runtime = num
					FileSystem.FileGet(CInt(frn), num5, -1L)
					Dim fileNumber30 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.WaterCut
					FileSystem.FileGet(fileNumber30, num, -1L)
					cRODSTAR2.WaterCut = num
				Else
					cRODSTAR.DynaFile = ""
					cRODSTAR.Runtime = 24F
					cRODSTAR.WaterCut = 0F
				End If
				If iThisVersion >= 3S Then
					Dim fileNumber31 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.OilAPI
					FileSystem.FileGet(fileNumber31, num, -1L)
					cRODSTAR2.OilAPI = num
				Else
					cRODSTAR.OilAPI = 30F
				End If
				If iThisVersion >= 4S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
				End If
				If iThisVersion < 5S Then
					num9 = 0F
				ElseIf iThisVersion < 11S Then
					FileSystem.FileGet(CInt(frn), num9, -1L)
					If num9 = 0F Then
						cRODSTAR.CalcMotorSize = -1S
						num9 = 50F
					Else
						cRODSTAR.CalcMotorSize = 0S
						num9 = RODUTIL.StdMotorSize(num9)
					End If
					num10 = 1S
				End If
				If iThisVersion >= 6S Then
					Dim fileNumber32 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.PumpFillage
					FileSystem.FileGet(fileNumber32, num, -1L)
					cRODSTAR2.PumpFillage = num
				End If
				If iThisVersion >= 7S Then
					FileSystem.FileGet(CInt(frn), num3, -1L)
					FILEIO.GetString(frn, text2)
					FileSystem.FileGet(CInt(frn), num3, -1L)
					FileSystem.FileGet(CInt(frn), num5, -1L)
				Else
					cRODSTAR.LeutertDynamometer = 0S
				End If
				If iThisVersion >= 8S Then
					FILEIO.GetString(frn, text2)
				End If
				If iThisVersion >= 9S Then
					FILEIO.GetString(frn, pu.OtherInfo)
				Else
					pu.OtherInfo = ""
				End If
				If iThisVersion >= 10S Then
					Dim frn2 As Short = frn
					cRODSTAR2 = cRODSTAR
					text = cRODSTAR2.CBDataFile
					FILEIO.GetString(frn2, text)
					cRODSTAR2.CBDataFile = text
				Else
					cRODSTAR.CBDataFile = ""
				End If
				If iThisVersion >= 11S Then
					Dim fileNumber33 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.WaterSPGR
					FileSystem.FileGet(fileNumber33, num, -1L)
					cRODSTAR2.WaterSPGR = num
					If cRODSTAR.WaterSPGR < 1F Then
						cRODSTAR.WaterSPGR = 1F
					ElseIf CDbl(cRODSTAR.WaterSPGR) > 1.5 Then
						cRODSTAR.WaterSPGR = 1.5F
					End If
					Dim fileNumber34 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num4 = cRODSTAR2.CalcMotorSize
					FileSystem.FileGet(fileNumber34, num4, -1L)
					cRODSTAR2.CalcMotorSize = num4
					If iThisVersion < 20S Then
						FileSystem.FileGet(CInt(frn), num10, -1L)
						FileSystem.FileGet(CInt(frn), num9, -1L)
						FileSystem.FileGet(CInt(frn), iTorqueMode, -1L)
						FILEIO.GetString(frn, sMotorSizeName)
					End If
				Else
					cRODSTAR.WaterSPGR = 1F
				End If
				If iThisVersion >= 15S Then
					Dim fileNumber35 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num4 = cRODSTAR2.giFluidLevelSource
					FileSystem.FileGet(fileNumber35, num4, -1L)
					cRODSTAR2.giFluidLevelSource = num4
					giFluidLevelSource = cRODSTAR.giFluidLevelSource
					Dim fileNumber36 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.UPumpIntakePressure
					FileSystem.FileGet(fileNumber36, num, -1L)
					cRODSTAR2.UPumpIntakePressure = num
					cRODSTAR.PumpIntakePressure = cRODSTAR.UPumpIntakePressure
					Dim fileNumber37 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					flag = cRODSTAR2.gbUseIPR
					FileSystem.FileGet(fileNumber37, flag, -1L)
					cRODSTAR2.gbUseIPR = flag
					Dim fileNumber38 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num4 = cRODSTAR2.giIPRMethod
					FileSystem.FileGet(fileNumber38, num4, -1L)
					cRODSTAR2.giIPRMethod = num4
					Dim fileNumber39 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.MidPerfDepth
					FileSystem.FileGet(fileNumber39, num, -1L)
					cRODSTAR2.MidPerfDepth = num
					Dim fileNumber40 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.StaticBHPressure
					FileSystem.FileGet(fileNumber40, num, -1L)
					cRODSTAR2.StaticBHPressure = num
					Dim fileNumber41 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.BubblePoint
					FileSystem.FileGet(fileNumber41, num, -1L)
					cRODSTAR2.BubblePoint = num
					Dim fileNumber42 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num4 = cRODSTAR2.gnTestPoints
					FileSystem.FileGet(fileNumber42, num4, -1L)
					cRODSTAR2.gnTestPoints = num4
					Dim array4 As RSWIN_DESC.IPRTESTPOINT()
					If cRODSTAR.gnTestPoints = 0S Then
						array4 = New RSWIN_DESC.IPRTESTPOINT(0) {}
					Else
						array4 = New RSWIN_DESC.IPRTESTPOINT(CInt((cRODSTAR.gnTestPoints + 1S)) - 1) {}
						Dim num11 As Integer = 1
						Dim gnTestPoints As Integer = CInt(cRODSTAR.gnTestPoints)
						For i As Integer = num11 To gnTestPoints
							FileSystem.FileGet(CInt(frn), array4(i).bPIEntered, -1L)
							FileSystem.FileGet(CInt(frn), array4(i).Pintake, -1L)
							FileSystem.FileGet(CInt(frn), array4(i).Pwf, -1L)
							FileSystem.FileGet(CInt(frn), array4(i).Production, -1L)
						Next
					End If
					cRODSTAR.TestPoints = array4
					If Not cRODSTAR.gbUseIPR Then
						cRODSTAR.gnTestPoints = 0S
						array4 = New RSWIN_DESC.IPRTESTPOINT(0) {}
						cRODSTAR.TestPoints = array4
						cRODSTAR.MidPerfDepth = -1F
						cRODSTAR.StaticBHPressure = -1F
						cRODSTAR.BubblePoint = -1F
					End If
				Else
					cRODSTAR.gbUseIPR = False
					cRODSTAR.gnTestPoints = 0S
					cRODSTAR.giIPRMethod = -1S
					cRODSTAR.MidPerfDepth = -1F
					cRODSTAR.StaticBHPressure = -1F
					cRODSTAR.BubblePoint = -1F
					Dim array4 As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(0) {}
					cRODSTAR.TestPoints = array4
				End If
				If iThisVersion >= 17S Then
					Dim fileNumber43 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					flag = cRODSTAR2.gbProducingBelowBPP
					FileSystem.FileGet(fileNumber43, flag, -1L)
					cRODSTAR2.gbProducingBelowBPP = flag
				Else
					cRODSTAR.gbProducingBelowBPP = False
				End If
				If iThisVersion >= 18S Then
					Dim frn3 As Short = frn
					cRODSTAR2 = cRODSTAR
					text = cRODSTAR2.FileComment
					FILEIO.GetString(frn3, text)
					cRODSTAR2.FileComment = text
					Dim fileNumber44 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					flag = cRODSTAR2.gbCalcFetkovichN
					FileSystem.FileGet(fileNumber44, flag, -1L)
					cRODSTAR2.gbCalcFetkovichN = flag
					Dim fileNumber45 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.FetkovichN
					FileSystem.FileGet(fileNumber45, num, -1L)
					cRODSTAR2.FetkovichN = num
					If cRODSTAR.giIPRMethod <> 0S Then
						cRODSTAR.gbCalcFetkovichN = True
					End If
				Else
					cRODSTAR.FileComment = RSWIN_DESC.sNull
					cRODSTAR.gbCalcFetkovichN = True
					cRODSTAR.FetkovichN = -1F
				End If
				If iThisVersion >= 19S Then
					FileSystem.FileGet(CInt(frn), num5, -1L)
					FileSystem.FileGet(CInt(frn), num5, -1L)
				Else
					cRODSTAR.MeasuredTVLoad = 0F
					cRODSTAR.MeasuredSVLoad = 0F
				End If
				If iThisVersion >= 20S Then
					Motor.ReadMotorData(CInt(frn))
				End If
				If iThisVersion >= 21S Then
					Dim fileNumber46 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					flag = cRODSTAR2.gbIncludeBuoyancy
					FileSystem.FileGet(fileNumber46, flag, -1L)
					cRODSTAR2.gbIncludeBuoyancy = flag
				Else
					cRODSTAR.gbIncludeBuoyancy = False
				End If
				If iThisVersion >= 23S Then
					FileSystem.FileGet(CInt(frn), num3, -1L)
				End If
				bInputLoaded = -1S
				cRODSTAR.UnknownM = True
				If cRODSTAR.CBDataType = 1S And cRODSTAR.get_M(2) <> 0F Then
					cRODSTAR.UnknownM = False
				End If
				cRODSTAR.gbRoddiagFile = True
				cRODSTAR.PumpFriction = 200F
				cRODSTAR.SPMEntered = -1S
				cRODSTAR.CalcPlungerSize = 0S
				Select Case giFluidLevelSource
					Case 0S
						cRODSTAR.FluidLevel = cRODSTAR.PumpDepth
						cRODSTAR.FluidLevelEntered = True
					Case 1S
						cRODSTAR.FluidLevelEntered = True
					Case 2S
						cRODSTAR.FluidLevelEntered = False
				End Select
				If cRODSTAR.PumpFillage >= 0F Then
					cRODSTAR.PumpFillage = Conversion.Int(cRODSTAR.PumpFillage * 100F)
					If cRODSTAR.PumpFillage > 95F Then
						cRODSTAR.PumpFillage = 95F
					End If
				Else
					Dim cRODSTAR7 As cRODSTAR = cRODSTAR
					Dim sDefaultName2 As String = "PumpFillage"
					Dim vNotPresentDefault2 As Object = 85
					flag = False
					cRODSTAR7.PumpFillage = Conversions.ToSingle(ini.GetDefault(sDefaultName2, vNotPresentDefault2, flag))
				End If
				cRODSTAR.RodStringType = 2S
				cRODSTAR.APIRod = 0S
				cRODSTAR.APIGrade = 0S
				cRODSTAR.RSGrade = 0S
				cRODSTAR.RSMaxSize = 0F
				cRODSTAR.RSMinSize = 0F
				Dim sinkerBar As RSWIN_DESC.RodSection
				cRODSTAR.SinkerBar = sinkerBar
				cRODSTAR.OilSPGR = CSng((141.5 / (CDbl(cRODSTAR.OilAPI) + 131.5)))
				If cRODSTAR.FluidSPGR = 0F Then
					cRODSTAR.FluidSPGR = cRODSTAR.WaterCut / 100F * cRODSTAR.WaterSPGR + (1F - cRODSTAR.WaterCut / 100F) * cRODSTAR.OilSPGR
				End If
				If(If((-If((iThisVersion <= 15S > False), 1S, 0S)), 1S, 0S) And Not cRODSTAR.IDEntered And If((-If(((pu.CrankHole = 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					pu.CrankHole = 1S
					pu.CrankHoles = 1S
					pu.CrankRadii(0) = pu.R
					pu.Strokes(0) = CSng(Conversion.Int(CDbl(pu.KinematicStroke) + 0.5))
				End If
				cRODSTAR.PU = pu
				RSWIN_DESC.WarnedAboutFluidInertia = 0S
				RSWIN_DESC.WarnedAboutPlungerSize = 0S
				cRODSTAR.PumpCondition = 1S
				Dim cRODSTAR8 As cRODSTAR = cRODSTAR
				Dim sDefaultName3 As String = "PumpEfficiency"
				Dim vNotPresentDefault3 As Object = 85
				flag = False
				cRODSTAR8.PumpEfficiency = Conversions.ToSingle(ini.GetDefault(sDefaultName3, vNotPresentDefault3, flag))
				cRODSTAR.IncludeFluidInertia = If((-If(((MImpred.FluidInertiaPossible() And cRODSTAR.PumpDepth < 4250F And cRODSTAR.PlungerSize > 2F) > False), 1S, 0S)), 1S, 0S)
				Dim cRODSTAR9 As cRODSTAR = cRODSTAR
				Dim sDefaultName4 As String = "CompressibilityIndex"
				Dim vNotPresentDefault4 As Object = 3
				flag = False
				cRODSTAR9.CompressibilityIndex = Conversions.ToSingle(ini.GetDefault(sDefaultName4, vNotPresentDefault4, flag))
				If cRODSTAR.IDEntered <> 0S Then
					cRODSTAR.Iart = cRODSTAR.PU.ArtInertia
				End If
				cRODSTAR.Irot = 0F
				cRODSTAR.IrotEntered = 0S
				cRODSTAR.UpstrokeFriction = 0F
				cRODSTAR.DownstrokeFriction = 0F
				If RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.rst.Friction = 0.2F
					RSWIN_DESC.rst.DownstrokeFriction = 0.1F
					RSWIN_DESC.rst.UpstrokeFriction = 0.1F
					RSWIN_DESC.rst.CalcFriction = 0S
				Else
					RSWIN_DESC.rst.Friction = 2F
					RSWIN_DESC.rst.DownstrokeFriction = 1F
					RSWIN_DESC.rst.UpstrokeFriction = 1F
					RSWIN_DESC.rst.CalcFriction = -1S
				End If
				RSWIN_DESC.rst.SlideFricCoeff = 0.2F
				Dim unitID As String = cRODSTAR.UnitID
				Dim num12 As Short
				Dim obj As Object = num12
				Dim text3 As String
				PUDATA1.ParseUnitID(unitID, text3, obj)
				num12 = Conversions.ToShort(obj)
				Dim text4 As String = text3
				If Operators.CompareString(text4, "CAB", False) = 0 Then
					Dim cRODSTAR10 As cRODSTAR = cRODSTAR
					Dim str As String = "CAA"
					obj = CInt((num12 + 98S))
					cRODSTAR10.UnitID = str + Util.Format(obj).Trim()
				End If
				Dim cRODSTAR11 As cRODSTAR = cRODSTAR
				Dim sDefaultName5 As String = "StuffingBoxFriction"
				Dim vNotPresentDefault5 As Object = 100
				flag = False
				cRODSTAR11.StuffingBoxFriction = Conversions.ToSingle(ini.GetDefault(sDefaultName5, vNotPresentDefault5, flag))
				Dim cRODSTAR12 As cRODSTAR = cRODSTAR
				Dim sDefaultName6 As String = "PumpLoadAdjustment"
				Dim vNotPresentDefault6 As Object = 0
				flag = False
				cRODSTAR12.PumpLoadAdj = Conversions.ToSingle(ini.GetDefault(sDefaultName6, vNotPresentDefault6, flag))
				If iThisVersion <= 19S Then
					If num10 = 0S Then
						num10 = 1S
						cRODSTAR.CalcMotorSize = -1S
						num9 = 50F
					End If
					Motor.SelectMotorFromOldInfo(CInt(num10), num9, sMotorSizeName, CInt(iTorqueMode))
				End If
				Dim motorInfo As Object = Motor.GetMotorInfo(4)
				If Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 1, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 7, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 8, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 9, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 10, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 11, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 12, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 13, False))), True, False)) Then
					cRODSTAR.MotorSPV = 0F
					cRODSTAR.CalcMotorSPV = 0S
				ElseIf Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 3, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 2, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 4, False))), True, False)) Then
					cRODSTAR.MotorSPV = 0F
					cRODSTAR.CalcMotorSPV = -1S
				Else
					num10 = 1S
					cRODSTAR.CalcMotorSize = -1S
					cRODSTAR.CalcMotorSPV = 0S
				End If
				RODUTIL.CheckCustomRodGrades()
				cRODSTAR.gbOutputLoaded = False
				If RSWIN_DESC.rst.WaterSPGR < 1F Then
					RSWIN_DESC.rst.WaterSPGR = 1F
				ElseIf CDbl(RSWIN_DESC.rst.WaterSPGR) > 1.5 Then
					RSWIN_DESC.rst.WaterSPGR = 1.5F
				End If
				cRODSTAR = Nothing
			Catch ex3 As Exception
			End Try
		End Sub

		Private Const CBMoment As Integer = 1

		Private Const CBE As Integer = 2

		Private Const DigitizedCBE As Integer = 3

		Private Const DynaCBE As Integer = 4

		Private Const FL_NONE As Integer = 0

		Private Const FL_ENTERED As Integer = 1

		Private Const FL_PIP As Integer = 2
	End Module
End Namespace
