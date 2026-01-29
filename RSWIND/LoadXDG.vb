Imports System
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module LoadXDG
		Private Sub LoadOutputData(frn As Short, ByRef bOutputLoaded As Short)
			bOutputLoaded = 0S
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				cRODSTAR.gbOutputLoaded = False
				Dim num As Integer
				Dim num2 As Short
				Dim num3 As Short
				num = CInt(FileSystem.Seek(CInt(frn)))
				FileSystem.Seek(CInt(frn), FileSystem.LOF(CInt(frn)) - 3L)
				FileSystem.FileGet(CInt(frn), num2, -1L)
				FileSystem.FileGet(CInt(frn), num3, -1L)
				If Not num3 <> 0S Then
					bOutputLoaded = -1S
					cRODSTAR.gbOutputLoaded = False
				Else
					FileSystem.Seek(CInt(frn), CLng(num))
					Dim num4 As Integer
					FileSystem.FileGet(CInt(frn), num4, -1L)
					Dim num5 As Integer
					FileSystem.FileGet(CInt(frn), num5, -1L)
					Dim dateTime As DateTime
					Dim obj As Object = dateTime
					FileSystem.FileGetObject(CInt(frn), obj, -1L)
					dateTime = Conversions.ToDate(obj)
					Dim cRODSTAR2 As cRODSTAR = cRODSTAR
					Dim num6 As Single = cRODSTAR2.BPDsurface
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.BPDsurface = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.UFeetFromSurface
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.UFeetFromSurface = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.UFeetOverPump
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.UFeetOverPump = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.UFluidLoad
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.UFluidLoad = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.GrossPumpStroke
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.GrossPumpStroke = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.MaxRodStressL
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.MaxRodStressL = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.MinMotorHP
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.MinMotorHP = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.Mprload
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.Mprload = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.UNetProduction
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.UNetProduction = num6
					Dim str As String = ".UNetProduction="
					num6 = cRODSTAR.UNetProduction
					Debug.WriteLine(str + num6.ToString())
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.UNetStrokeApparent
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.UNetStrokeApparent = num6
					cRODSTAR.UNetStroke = cRODSTAR.UNetStrokeApparent
					cRODSTAR2 = cRODSTAR
					Dim num7 As Short = cRODSTAR2.Ntsteps
					FileSystem.FileGet(CInt(frn), num7, -1L)
					cRODSTAR2.Ntsteps = num7
					cRODSTAR2 = cRODSTAR
					num7 = cRODSTAR2.NtstepsUpstroke
					FileSystem.FileGet(CInt(frn), num7, -1L)
					cRODSTAR2.NtstepsUpstroke = num7
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.Prhp
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.Prhp = num6
					If num2 >= 25S Then
						cRODSTAR2 = cRODSTAR
						num6 = cRODSTAR2.Plhp
						FileSystem.FileGet(CInt(frn), num6, -1L)
						cRODSTAR2.Plhp = num6
					End If
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.Pprload
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.Pprload = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.UPintakeFromLines
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.UPintakeFromLines = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.UPumpFillage
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.UPumpFillage = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.PumpFriction
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.PumpFriction = num6
					cRODSTAR.PumpFriction = 200F
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.StructL
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.StructL = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.USystemEff
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.USystemEff = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.TotalTheta
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.TotalTheta = num6
					cRODSTAR2 = cRODSTAR
					num7 = cRODSTAR2.ULinesSetH
					FileSystem.FileGet(CInt(frn), num7, -1L)
					cRODSTAR2.ULinesSetH = num7
					cRODSTAR2 = cRODSTAR
					num7 = cRODSTAR2.ULinesSetV
					FileSystem.FileGet(CInt(frn), num7, -1L)
					cRODSTAR2.ULinesSetV = num7
					cRODSTAR2 = cRODSTAR
					num7 = cRODSTAR2.ULineSettingsChanged
					FileSystem.FileGet(CInt(frn), num7, -1L)
					cRODSTAR2.ULineSettingsChanged = num7
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.XDFeetFromSurface
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.XDFeetFromSurface = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.XDFeetOverPump
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.XDFeetOverPump = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.XDFluidLoad
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.XDFluidLoad = num6
					cRODSTAR2 = cRODSTAR
					num7 = cRODSTAR2.XDLinesSetH
					FileSystem.FileGet(CInt(frn), num7, -1L)
					cRODSTAR2.XDLinesSetH = num7
					cRODSTAR2 = cRODSTAR
					num7 = cRODSTAR2.XDLinesSetV
					FileSystem.FileGet(CInt(frn), num7, -1L)
					cRODSTAR2.XDLinesSetV = num7
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.XDNetProduction
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.XDNetProduction = num6
					Dim str2 As String = ".XDNetProduction="
					num6 = cRODSTAR.XDNetProduction
					Debug.WriteLine(str2 + num6.ToString())
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.XDNetStroke
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.XDNetStroke = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.XDNetStrokeApparent
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.XDNetStrokeApparent = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.XDPintakeFromLines
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.XDPintakeFromLines = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.XDPumpFillage
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.XDPumpFillage = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.XDSystemEff
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.XDSystemEff = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.WrodsInAir
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.WrodsInAir = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.WrodsInFluid
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.WrodsInFluid = num6
					cRODSTAR2 = cRODSTAR
					num6 = cRODSTAR2.g_FluidPoundFluidLoad
					FileSystem.FileGet(CInt(frn), num6, -1L)
					cRODSTAR2.g_FluidPoundFluidLoad = num6
					Dim value As Single
					Dim value2 As Single
					If RSWIN_DESC.rst.PU.UnitType = 8S And num2 >= 25S Then
						value = cRODSTAR.get_RequiredUnbalance(2)
					ElseIf Not cRODSTAR.UnknownM Then
						value2 = cRODSTAR.get_M(2)
					End If
					Dim num8 As Short
					Dim array2 As Single()
					Dim array3 As Single()
					Dim array4 As Single()
					Dim array5 As Single()
					Dim array6 As Single()
					Dim num12 As Short
					Dim num13 As Short
					Dim array As Single(,) = New Single(2, CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
					num8 = 0S
					Do
						FileSystem.FileGet(CInt(frn), cRODSTAR.CBE90(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.Clf(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.DollarsPerBblFluid(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.DollarsPerBblOil(CInt(num8)), -1L)
						cRODSTAR2 = cRODSTAR
						Dim cRODSTAR3 As cRODSTAR = cRODSTAR2
						num7 = num8
						num6 = cRODSTAR3.get_ElectricBillperMonth(CInt(num7))
						FileSystem.FileGet(CInt(frn), num6, -1L)
						cRODSTAR2.set_ElectricBillperMonth(CInt(num7), num6)
						FileSystem.FileGet(CInt(frn), cRODSTAR.GearboxLoading(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.HpNemaD(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.HpUhs(CInt(num8)), -1L)
						If RSWIN_DESC.rst.PU.UnitType = 8S And num2 >= 20S Then
							cRODSTAR2 = cRODSTAR
							Dim cRODSTAR4 As cRODSTAR = cRODSTAR2
							num7 = num8
							num6 = cRODSTAR4.get_RequiredUnbalance(CInt(num7))
							FileSystem.FileGet(CInt(frn), num6, -1L)
							cRODSTAR2.set_RequiredUnbalance(CInt(num7), num6)
						Else
							cRODSTAR2 = cRODSTAR
							Dim cRODSTAR5 As cRODSTAR = cRODSTAR2
							num7 = num8
							num6 = cRODSTAR5.get_M(CInt(num7))
							FileSystem.FileGet(CInt(frn), num6, -1L)
							cRODSTAR2.set_M(CInt(num7), num6)
						End If
						FileSystem.FileGet(CInt(frn), cRODSTAR.MotorKWH(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.PeakTorque(CInt(num8)), -1L)
						Dim num9 As Short = 0S
						Dim num10 As Short = cRODSTAR.Ntsteps - 1S

							For num11 As Short = num9 To num10
								FileSystem.FileGet(CInt(frn), array(CInt(num8), CInt(num11)), -1L)
							Next
							num8 += 1S

					Loop While num8 <= 2S
					If RSWIN_DESC.rst.PU.UnitType = 8S And num2 >= 25S And Not cRODSTAR.bUnknownUnbalance Then
						cRODSTAR.set_RequiredUnbalance(2, value)
					ElseIf Not cRODSTAR.UnknownM Then
						cRODSTAR.set_M(2, value2)
					End If
					cRODSTAR.Tnet = array
					array2 = New Single(CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
					array3 = New Single(CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
					array4 = New Single(CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
					array5 = New Single(CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
					array6 = New Single(CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
					num12 = 0S
					num13 = cRODSTAR.Ntsteps - 1S
					num8 = num12
					While num8 <= num13
						FileSystem.FileGet(CInt(frn), array2(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), array3(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), array4(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), array5(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), array6(CInt(num8)), -1L)
						num8 += 1S
					End While
					cRODSTAR.PumpPos = array2
					cRODSTAR.PumpLoad = array3
					cRODSTAR.PermLoad = array4
					cRODSTAR.Thetac = array5
					cRODSTAR.Tf = array6
					Dim num14 As Short = 1S
					Dim numRods As Short = cRODSTAR.NumRods
					num8 = num14
					While num8 <= numRods
						FileSystem.FileGet(CInt(frn), cRODSTAR.StressL(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.maxStressTop(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.minStressTop(CInt(num8)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.minStressBot(CInt(num8)), -1L)
						num8 += 1S
					End While
					Dim flag As Boolean = True
					num8 = 1S
					Do
						FileSystem.FileGet(CInt(frn), cRODSTAR.LineSettings(CInt(num8)).LSet, -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.LineSettings(CInt(num8)).Value, -1L)
						Debug.WriteLine(".LineSettings=" + cRODSTAR.LineSettings(CInt(num8)).LSet.ToString() + " , " + cRODSTAR.LineSettings(CInt(num8)).Value.ToString())
						If cRODSTAR.LineSettings(CInt(num8)).LSet = 0S Then
							flag = False
						End If
						num8 += 1S
					Loop While num8 <= 4S
					num8 = 1S
					Do
						FileSystem.FileGet(CInt(frn), cRODSTAR.XDLineSettings(CInt(num8)).LSet, -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.XDLineSettings(CInt(num8)).Value, -1L)
						Debug.WriteLine(".XDLineSettings=" + cRODSTAR.XDLineSettings(CInt(num8)).LSet.ToString() + " , " + cRODSTAR.XDLineSettings(CInt(num8)).Value.ToString())
						num8 += 1S
					Loop While num8 <= 4S
					Try
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bBentPumpBarrel, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bCrankHoleCorrected, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bExtremeRodTubingFriction, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bExcessiveRodTubingFriction, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bFluidInertia, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bFluidLevelCorrected, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bFluidPound, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bFullPump, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bGasInterference, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bGasLock, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bHittingDown, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bHittingUp, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bIncompleteFillage, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bIncorrectFluidSPGR, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bIncorrectPlungerSize, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bIncorrectProductionRate, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bIncorrectSPM, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bLoadShiftCorrected, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bMalfunctioningTubingAnchor, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bMeasuredStrokeCorrected, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bPlungerTooLarge, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bPlungerTooSmall, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bPumpConditionGood, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bPumpFriction, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bRodPart, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bRodTubingFriction, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bSevereDownholeProblem, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bShallowFriction, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bSinkerBarWaveReflection, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bSPMHigh, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bSPMLow, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bStuckPump, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bSurfaceMatchPoor, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bSurfPosKinematicCorrected, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bTubingAnchored, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bTubingAnchorLoose, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bTubingLeak, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bTubingMovement, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bUnknownPumpCondition, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.bUpperRingValvePump, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.iAdjustPhase, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.iCalcFrictionStatus, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.iDiagRodPart, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.iOrigCrankHole, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.iPumpFriction, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.iSectFluidVelocity, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.iSVLeak, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.iTVLeak, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.iWornPump, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.iWornPumpBarrel, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.FeetFromSurface, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.FluidSPGR, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.FluidVelocity, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.LoadShift, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.LoadShiftPct, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.MeasuredStroke, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.OrigStrokeLength, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.PhaseAdjustment, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.PlungerSize, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.PumpFillage, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.PumpIntakePressure, -1L)
						FileSystem.FileGet(CInt(frn), RSWIN_DESC.gSysDiag.TubingMovement, -1L)
						If flag And cRODSTAR.UNetProduction > 2F Then
							RSWIN_DESC.fDefaultTargetProduction = CSng((CDbl(cRODSTAR.UNetProduction) * 1.1))
						Else
							RSWIN_DESC.fDefaultTargetProduction = cRODSTAR.BPDsurface
						End If
					Catch ex As Exception
					End Try
					bOutputLoaded = -1S
					cRODSTAR.gbOutputLoaded = True
					cRODSTAR.gbOutputOld = False
					cRODSTAR = Nothing
				End If
			Catch ex2 As Exception
				bOutputLoaded = -1S
				RSWIN_DESC.rst.gbOutputLoaded = False
			End Try
		End Sub

		Private Sub LoadInputData(ByRef frn As Short, ThisVersion As Short, ByRef bInputLoaded As Boolean, IsXDIAG As Boolean)
			Try
				bInputLoaded = False
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
				If ThisVersion <= 2S Then
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
				num = cRODSTAR2.Runtime
				FileSystem.FileGet(fileNumber8, num, -1L)
				cRODSTAR2.Runtime = num
				Dim num3 As Single
				FileSystem.FileGet(CInt(frn), num3, -1L)
				Dim num4 As Short
				FileSystem.FileGet(CInt(frn), num4, -1L)
				Dim fileNumber9 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.DynaFile
				FileSystem.FileGet(fileNumber9, text, -1L, False)
				cRODSTAR2.DynaFile = text
				cRODSTAR.DynoDate = ""
				Dim text2 As String = ""
				FILEIO.GetString(frn, text2)
				FileSystem.FileGet(CInt(frn), num4, -1L)
				FILEIO.GetString(frn, text2)
				FileSystem.FileGet(CInt(frn), num4, -1L)
				FileSystem.FileGet(CInt(frn), num3, -1L)
				FileSystem.FileGet(CInt(frn), num3, -1L)
				Dim fileNumber10 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				Dim num5 As Short = cRODSTAR2.PumpType
				FileSystem.FileGet(fileNumber10, num5, -1L)
				cRODSTAR2.PumpType = num5
				Dim fileNumber11 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.PlungerSize
				FileSystem.FileGet(fileNumber11, num, -1L)
				cRODSTAR2.PlungerSize = num
				Dim fileNumber12 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.WaterCut
				FileSystem.FileGet(fileNumber12, num, -1L)
				cRODSTAR2.WaterCut = num
				Dim fileNumber13 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.WaterSPGR
				FileSystem.FileGet(fileNumber13, num, -1L)
				cRODSTAR2.WaterSPGR = num
				If cRODSTAR.WaterSPGR < 1F Then
					cRODSTAR.WaterSPGR = 1F
				ElseIf CDbl(cRODSTAR.WaterSPGR) > 1.5 Then
					cRODSTAR.WaterSPGR = 1.5F
				End If
				Dim fileNumber14 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.OilAPI
				FileSystem.FileGet(fileNumber14, num, -1L)
				cRODSTAR2.OilAPI = num
				Dim fileNumber15 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.FluidSPGR
				FileSystem.FileGet(fileNumber15, num, -1L)
				cRODSTAR2.FluidSPGR = num
				FileSystem.FileGet(CInt(frn), num3, -1L)
				Dim fileNumber16 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingOD
				FileSystem.FileGet(fileNumber16, num, -1L)
				cRODSTAR2.TubingOD = num
				Dim fileNumber17 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingID
				FileSystem.FileGet(fileNumber17, num, -1L)
				cRODSTAR2.TubingID = num
				RSWIN_DESC.rst.SlideFricCoeff = 0.2F
				If ThisVersion < 18S Then
					FileSystem.FileGet(CInt(frn), num4, -1L)
					FileSystem.FileGet(CInt(frn), num3, -1L)
				Else
					Dim fileNumber18 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num5 = cRODSTAR2.TubingAnchored
					FileSystem.FileGet(fileNumber18, num5, -1L)
					cRODSTAR2.TubingAnchored = num5
					Dim fileNumber19 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.TubingAnchorDepth
					FileSystem.FileGet(fileNumber19, num, -1L)
					cRODSTAR2.TubingAnchorDepth = num
				End If
				Dim fileNumber20 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingPressure
				FileSystem.FileGet(fileNumber20, num, -1L)
				cRODSTAR2.TubingPressure = num
				Dim fileNumber21 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.CasingPressure
				FileSystem.FileGet(fileNumber21, num, -1L)
				cRODSTAR2.CasingPressure = num
				Dim fileNumber22 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num5 = cRODSTAR2.NumRods
				FileSystem.FileGet(fileNumber22, num5, -1L)
				cRODSTAR2.NumRods = num5
				Dim num6 As Short = 1S
				Dim numRods As Short = cRODSTAR.NumRods
				For num7 As Short = num6 To numRods
					Dim rodSection As RSWIN_DESC.RodSection
					rodSection.Initialize()
					FileSystem.FileGet(CInt(frn), rodSection.Grade, -1L)
					FileSystem.FileGet(CInt(frn), rodSection.Diameter, -1L)
					FileSystem.FileGet(CInt(frn), rodSection.length, -1L)
					FileSystem.FileGet(CInt(frn), rodSection.SuckerRodLength, -1L)
					FileSystem.FileGet(CInt(frn), rodSection.RodDensity, -1L)
					FileSystem.FileGet(CInt(frn), rodSection.RodWeight, -1L)
					FileSystem.FileGet(CInt(frn), rodSection.Elasticity, -1L)
					FileSystem.FileGet(CInt(frn), rodSection.Area, -1L)
					FileSystem.FileGet(CInt(frn), rodSection.RodType, -1L, False)
					If rodSection.RodType Is Nothing Then
						rodSection.RodType = ""
					End If
					FileSystem.FileGet(CInt(frn), rodSection.TensileStrength, -1L)
					If RODUTIL.IsFG(rodSection.Grade) Then
					End If
					Try
						rodSection.Guide = RSWIN_DESC.MOLDED
						rodSection.friction_coef = 0.2F
					Catch ex As Exception
					End Try
					Try
						Dim grade As Short = rodSection.Grade
						Dim flag As Boolean = RODUTIL.ConvertRodGrade(rodSection) <> 0
					Catch ex2 As Exception
						Dim grade As Short
						rodSection.Grade = grade
					End Try
					cRODSTAR.Sections(CInt(num7)) = rodSection
				Next
				cRODSTAR.RodStringType = 2S
				Dim fileNumber23 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.ServiceFactor
				FileSystem.FileGet(fileNumber23, num, -1L)
				cRODSTAR2.ServiceFactor = num
				Dim fileNumber24 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.UnitID
				FileSystem.FileGet(fileNumber24, text, -1L, False)
				cRODSTAR2.UnitID = text
				Dim fileNumber25 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num5 = cRODSTAR2.IDEntered
				FileSystem.FileGet(fileNumber25, num5, -1L)
				cRODSTAR2.IDEntered = num5
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				cRODSTAR.PU.Initialize()
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
				FILEIO.GetString(frn, pu.OtherInfo)
				cRODSTAR.PU = pu
				Dim fileNumber26 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.ElectricityCost
				FileSystem.FileGet(fileNumber26, num, -1L)
				cRODSTAR2.ElectricityCost = num
				If cRODSTAR.ElectricityCost = 0F Then
					Try
						Dim cRODSTAR3 As cRODSTAR = cRODSTAR
						Dim sDefaultName As String = "ElectricityCost"
						Dim vNotPresentDefault As Object = 0.06
						Dim flag2 As Boolean = False
						cRODSTAR3.ElectricityCost = Conversions.ToSingle(ini.GetDefault(sDefaultName, vNotPresentDefault, flag2))
					Catch ex3 As Exception
					End Try
				End If
				Dim fileNumber27 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num5 = cRODSTAR2.PowerMeterType
				FileSystem.FileGet(fileNumber27, num5, -1L)
				cRODSTAR2.PowerMeterType = num5
				Dim fileNumber28 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num5 = cRODSTAR2.CalcMotorSize
				FileSystem.FileGet(fileNumber28, num5, -1L)
				cRODSTAR2.CalcMotorSize = num5
				Dim num8 As Short
				Dim fMotorSize As Single
				Dim iTorqueMode As Short
				Dim sMotorSizeName As String
				If ThisVersion < 8S Then
					FileSystem.FileGet(CInt(frn), num8, -1L)
					FileSystem.FileGet(CInt(frn), fMotorSize, -1L)
					FileSystem.FileGet(CInt(frn), iTorqueMode, -1L)
					FILEIO.GetString(frn, sMotorSizeName)
				End If
				Dim fileNumber29 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num5 = cRODSTAR2.CBDataType
				FileSystem.FileGet(fileNumber29, num5, -1L)
				cRODSTAR2.CBDataType = num5
				Dim fileNumber30 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.CBEffect
				FileSystem.FileGet(fileNumber30, num, -1L)
				cRODSTAR2.CBEffect = num
				Dim fileNumber31 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.CBAngle
				FileSystem.FileGet(fileNumber31, num, -1L)
				cRODSTAR2.CBAngle = num
				Dim fileNumber32 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				Dim cRODSTAR4 As cRODSTAR = cRODSTAR2
				Dim index As Integer = 2
				num = cRODSTAR4.get_M(index)
				FileSystem.FileGet(fileNumber32, num, -1L)
				cRODSTAR2.set_M(index, num)
				If cRODSTAR.get_M(2) <> 0F Then
					cRODSTAR.UnknownM = False
				End If
				Dim frn2 As Short = frn
				cRODSTAR2 = cRODSTAR
				text = cRODSTAR2.CBDataFile
				FILEIO.GetString(frn2, text)
				cRODSTAR2.CBDataFile = text
				Dim fileNumber33 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num5 = cRODSTAR2.RDNtsteps
				FileSystem.FileGet(fileNumber33, num5, -1L)
				cRODSTAR2.RDNtsteps = num5
				Dim array2 As Single()
				If cRODSTAR.RDNtsteps > 0S Then
					Dim array As Single()
					Dim num9 As Short
					Dim num10 As Short
					array = New Single(CInt((cRODSTAR.RDNtsteps - 1S + 1S)) - 1) {}
					array2 = New Single(CInt((cRODSTAR.RDNtsteps - 1S + 1S)) - 1) {}
					num9 = 0S
					num10 = cRODSTAR.RDNtsteps - 1S
					For num7 As Short = num9 To num10
						FileSystem.FileGet(CInt(frn), array(CInt(num7)), -1L)
						FileSystem.FileGet(CInt(frn), array2(CInt(num7)), -1L)
						If array(CInt(num7)) < 0F Then
							array(CInt(num7)) = 0F
						End If
					Next
					cRODSTAR.RDSurfPos = array
					cRODSTAR.RDSurfLoad = array2
				End If
				Dim fileNumber34 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num5 = cRODSTAR2.IncludeFluidInertia
				FileSystem.FileGet(fileNumber34, num5, -1L)
				cRODSTAR2.IncludeFluidInertia = num5
				Dim fileNumber35 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num5 = cRODSTAR2.PumpCondition
				FileSystem.FileGet(fileNumber35, num5, -1L)
				cRODSTAR2.PumpCondition = num5
				Dim fileNumber36 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.PumpEfficiency
				FileSystem.FileGet(fileNumber36, num, -1L)
				cRODSTAR2.PumpEfficiency = num
				Dim fileNumber37 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.PumpLoadAdj
				FileSystem.FileGet(fileNumber37, num, -1L)
				cRODSTAR2.PumpLoadAdj = num
				Dim fileNumber38 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.MotorSPV
				FileSystem.FileGet(fileNumber38, num, -1L)
				cRODSTAR2.MotorSPV = num
				Dim fileNumber39 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.Iart
				FileSystem.FileGet(fileNumber39, num, -1L)
				cRODSTAR2.Iart = num
				Dim fileNumber40 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.Irot
				FileSystem.FileGet(fileNumber40, num, -1L)
				cRODSTAR2.Irot = num
				FileSystem.FileGet(CInt(frn), num3, -1L)
				If num3 <> cRODSTAR.get_M(2) AndAlso num3 > cRODSTAR.get_M(2) Then
					cRODSTAR.set_M(2, num3)
				End If
				cRODSTAR.UnknownM = (cRODSTAR.CBDataType = 1S And CDbl(cRODSTAR.get_M(2)) = 0.0)
				Dim fileNumber41 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.UpstrokeFriction
				FileSystem.FileGet(fileNumber41, num, -1L)
				cRODSTAR2.UpstrokeFriction = num
				Dim fileNumber42 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.DownstrokeFriction
				FileSystem.FileGet(fileNumber42, num, -1L)
				cRODSTAR2.DownstrokeFriction = num
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
				RSWIN_DESC.rst.SlideFricCoeff = 0.2F
				Dim fileNumber43 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.CompressibilityIndex
				FileSystem.FileGet(fileNumber43, num, -1L)
				cRODSTAR2.CompressibilityIndex = num
				Dim num11 As Single
				FileSystem.FileGet(CInt(frn), num11, -1L)
				Dim fileNumber44 As Integer = CInt(frn)
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.PumpFillage
				FileSystem.FileGet(fileNumber44, num, -1L)
				cRODSTAR2.PumpFillage = num
				Dim num12 As Single
				If ThisVersion < 18S Then
					FileSystem.FileGet(CInt(frn), num12, -1L)
				End If
				If ThisVersion >= 18S Then
					FileSystem.FileGet(CInt(frn), num3, -1L)
				Else
					Dim fileNumber45 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.TubingAnchorDepth
					FileSystem.FileGet(fileNumber45, num, -1L)
					cRODSTAR2.TubingAnchorDepth = num
				End If
				If ThisVersion >= 9S Then
					FileSystem.FileGet(CInt(frn), num3, -1L)
				End If
				Dim num13 As Single
				Dim num14 As Single
				If ThisVersion < 13S Then
					num13 = 0F
					num14 = 0F
				ElseIf ThisVersion < 18S Then
					FileSystem.FileGet(CInt(frn), num13, -1L)
					FileSystem.FileGet(CInt(frn), num14, -1L)
				End If
				Dim num15 As Short
				Dim num16 As Short
				Dim array3 As Single()
				Dim array4 As Single()
				If ThisVersion >= 18S Then
					FileSystem.FileGet(CInt(frn), num15, -1L)
					FileSystem.FileGet(CInt(frn), num16, -1L)
					If num16 > 0S Then
						Dim num17 As Short
						Dim num18 As Short
						array3 = New Single(CInt((num16 - 1S + 1S)) - 1) {}
						array4 = New Single(CInt((num16 - 1S + 1S)) - 1) {}
						num17 = 0S
						num18 = num16 - 1S
						For num7 As Short = num17 To num18
							FileSystem.FileGet(CInt(frn), array3(CInt(num7)), -1L)
							FileSystem.FileGet(CInt(frn), array4(CInt(num7)), -1L)
						Next
					End If
				End If
				Dim giFluidLevelSource As Short
				If ThisVersion >= 3S Then
					FileSystem.FileGet(CInt(frn), giFluidLevelSource, -1L)
					cRODSTAR.giFluidLevelSource = giFluidLevelSource
					Dim fileNumber46 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.PumpIntakePressure
					FileSystem.FileGet(fileNumber46, num, -1L)
					cRODSTAR2.PumpIntakePressure = num
					Dim fileNumber47 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					Dim flag2 As Boolean = cRODSTAR2.gbUseIPR
					FileSystem.FileGet(fileNumber47, flag2, -1L)
					cRODSTAR2.gbUseIPR = flag2
					Dim fileNumber48 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num5 = cRODSTAR2.giIPRMethod
					FileSystem.FileGet(fileNumber48, num5, -1L)
					cRODSTAR2.giIPRMethod = num5
					Dim fileNumber49 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.MidPerfDepth
					FileSystem.FileGet(fileNumber49, num, -1L)
					cRODSTAR2.MidPerfDepth = num
					Dim fileNumber50 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.StaticBHPressure
					FileSystem.FileGet(fileNumber50, num, -1L)
					cRODSTAR2.StaticBHPressure = num
					Dim fileNumber51 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.BubblePoint
					FileSystem.FileGet(fileNumber51, num, -1L)
					cRODSTAR2.BubblePoint = num
					Dim fileNumber52 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num5 = cRODSTAR2.gnTestPoints
					FileSystem.FileGet(fileNumber52, num5, -1L)
					cRODSTAR2.gnTestPoints = num5
					Dim array5 As RSWIN_DESC.IPRTESTPOINT()
					If cRODSTAR.gnTestPoints = 0S Then
						array5 = New RSWIN_DESC.IPRTESTPOINT(0) {}
					Else
						' The following expression was wrapped in a checked-expression
						array5 = New RSWIN_DESC.IPRTESTPOINT(CInt((cRODSTAR.gnTestPoints + 1S)) - 1) {}
						Dim num19 As Short = 1S
						Dim gnTestPoints As Short = cRODSTAR.gnTestPoints
						For num7 As Short = num19 To gnTestPoints
							FileSystem.FileGet(CInt(frn), array5(CInt(num7)).bPIEntered, -1L)
							FileSystem.FileGet(CInt(frn), array5(CInt(num7)).Pintake, -1L)
							FileSystem.FileGet(CInt(frn), array5(CInt(num7)).Pwf, -1L)
							FileSystem.FileGet(CInt(frn), array5(CInt(num7)).Production, -1L)
						Next
					End If
					cRODSTAR.TestPoints = array5
					If(cRODSTAR.gbUseIPR And cRODSTAR.gnTestPoints = 0S) Or cRODSTAR.MidPerfDepth = 0F Or cRODSTAR.StaticBHPressure = 0F Then
						cRODSTAR.gbUseIPR = False
					End If
				Else
					cRODSTAR.giFluidLevelSource = Conversions.ToShort(Interaction.IIf(num2 <> 0S, 1, 0))
					giFluidLevelSource = cRODSTAR.giFluidLevelSource
					cRODSTAR.gbUseIPR = False
					cRODSTAR.gnTestPoints = 0S
					Dim array5 As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(0) {}
					cRODSTAR.TestPoints = array5
				End If
				If ThisVersion >= 4S Then
					Dim fileNumber53 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					Dim flag2 As Boolean = cRODSTAR2.gbProducingBelowBPP
					FileSystem.FileGet(fileNumber53, flag2, -1L)
					cRODSTAR2.gbProducingBelowBPP = flag2
				Else
					cRODSTAR.gbProducingBelowBPP = False
				End If
				If ThisVersion >= 5S Then
					Dim frn3 As Short = frn
					cRODSTAR2 = cRODSTAR
					text = cRODSTAR2.FileComment
					FILEIO.GetString(frn3, text)
					cRODSTAR2.FileComment = text
				Else
					cRODSTAR.FileComment = ""
				End If
				If ThisVersion >= 6S Then
					Dim fileNumber54 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					Dim flag2 As Boolean = cRODSTAR2.gbCalcFetkovichN
					FileSystem.FileGet(fileNumber54, flag2, -1L)
					cRODSTAR2.gbCalcFetkovichN = flag2
					Dim fileNumber55 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.FetkovichN
					FileSystem.FileGet(fileNumber55, num, -1L)
					cRODSTAR2.FetkovichN = num
					If cRODSTAR.giIPRMethod <> 0S Then
						cRODSTAR.gbCalcFetkovichN = True
					End If
				Else
					cRODSTAR.gbCalcFetkovichN = True
					cRODSTAR.FetkovichN = -1F
				End If
				If ThisVersion >= 7S Then
					FileSystem.FileGet(CInt(frn), num3, -1L)
					FileSystem.FileGet(CInt(frn), num3, -1L)
				Else
					cRODSTAR.MeasuredTVLoad = 0F
					cRODSTAR.MeasuredSVLoad = 0F
				End If
				If ThisVersion = 8S Then
					FileSystem.FileGet(CInt(frn), num3, -1L)
					Motor.ReadMotorData(CInt(frn))
				ElseIf ThisVersion > 8S Then
					Motor.ReadMotorData(CInt(frn))
				Else
					Select Case num8
						Case 1S, 2S, 3S, 4S, 7S, 8S, 9S, 10S, 11S, 12S, 13S
							GoTo IL_11DD
					End Select
					num8 = 1S
					cRODSTAR.CalcMotorSize = -1S
					IL_11DD:
					Motor.SelectMotorFromOldInfo(CInt(num8), fMotorSize, sMotorSizeName, CInt(iTorqueMode))
				End If
				If ThisVersion >= 9S Then
					Dim fileNumber56 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					Dim flag2 As Boolean = cRODSTAR2.gbIncludeBuoyancy
					FileSystem.FileGet(fileNumber56, flag2, -1L)
					cRODSTAR2.gbIncludeBuoyancy = flag2
				Else
					cRODSTAR.gbIncludeBuoyancy = False
				End If
				If ThisVersion >= 10S Then
					FileSystem.FileGet(CInt(frn), num4, -1L)
				End If
				If ThisVersion >= 14S Then
					Dim fileNumber57 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					Dim flag2 As Boolean = cRODSTAR2.gbCalcFluidSPGR
					FileSystem.FileGet(fileNumber57, flag2, -1L)
					cRODSTAR2.gbCalcFluidSPGR = flag2
				ElseIf ThisVersion >= 11S Then
					FileSystem.FileGet(CInt(frn), num3, -1L)
					cRODSTAR.gbCalcFluidSPGR = False
				Else
					cRODSTAR.gbCalcFluidSPGR = True
				End If
				If ThisVersion >= 12S Then
					FileSystem.FileGet(CInt(frn), num4, -1L)
				End If
				If ThisVersion >= 16S Then
					FileSystem.FileGet(CInt(frn), num4, -1L)
					FileSystem.FileGet(CInt(frn), num4, -1L)
					FileSystem.FileGet(CInt(frn), num3, -1L)
					FileSystem.FileGet(CInt(frn), num3, -1L)
					If ThisVersion >= 19S Then
						FileSystem.FileGet(CInt(frn), num4, -1L)
						FileSystem.FileGet(CInt(frn), num4, -1L)
					End If
				ElseIf ThisVersion >= 15S Then
					FileSystem.FileGet(CInt(frn), num4, -1L)
					FileSystem.FileGet(CInt(frn), num4, -1L)
					FileSystem.FileGet(CInt(frn), num4, -1L)
					FileSystem.FileGet(CInt(frn), num3, -1L)
					FileSystem.FileGet(CInt(frn), num3, -1L)
				End If
				If ThisVersion >= 17S Then
					FileSystem.FileGet(CInt(frn), num3, -1L)
				End If
				Try
					If ThisVersion >= 20S And pu.UnitType = 8S Then
						Dim fileNumber58 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						Dim flag2 As Boolean = cRODSTAR2.bUnknownUnbalance
						FileSystem.FileGet(fileNumber58, flag2, -1L)
						cRODSTAR2.bUnknownUnbalance = flag2
					End If
				Catch ex4 As Exception
					cRODSTAR.gbOutputLoaded = False
				End Try
				If ThisVersion >= 21S Then
					Dim fileNumber59 As Integer = CInt(frn)
					cRODSTAR2 = RSWIN_DESC.rst
					num = cRODSTAR2.StuffingBoxFriction
					FileSystem.FileGet(fileNumber59, num, -1L)
					cRODSTAR2.StuffingBoxFriction = num
				Else
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim sDefaultName2 As String = "StuffingBoxFriction"
					Dim vNotPresentDefault2 As Object = 100
					Dim flag2 As Boolean = False
					rst.StuffingBoxFriction = Conversions.ToSingle(ini.GetDefault(sDefaultName2, vNotPresentDefault2, flag2))
				End If
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					If ThisVersion > 21S Then
						Dim fileNumber60 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.AdjustedStrokeLength
						FileSystem.FileGet(fileNumber60, num, -1L)
						cRODSTAR2.AdjustedStrokeLength = num
					Else
						cRODSTAR.AdjustedStrokeLength = cRODSTAR.PU.MaxStroke
					End If
				End If
				If ThisVersion > 22S Then
					Dim fileNumber61 As Integer = CInt(frn)
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.PR_Diameter
					FileSystem.FileGet(fileNumber61, num, -1L)
					cRODSTAR2.PR_Diameter = num
				End If
				If cRODSTAR.PR_Diameter = 0F Then
					cRODSTAR.PR_Diameter = 1.5F
				End If
				Try
					If ThisVersion > 23S Then
						Dim fileNumber62 As Integer = CInt(frn)
						cRODSTAR2 = cRODSTAR
						Dim flag2 As Boolean = cRODSTAR2.VSP
						FileSystem.FileGet(fileNumber62, flag2, -1L)
						cRODSTAR2.VSP = flag2
					End If
				Catch ex5 As Exception
					cRODSTAR.VSP = False
				End Try
				cRODSTAR.gbRoddiagFile = (cRODSTAR.RDNtsteps > 0S)
				cRODSTAR.PumpFriction = 200F
				cRODSTAR.OilSPGR = CSng((141.5 / (CDbl(cRODSTAR.OilAPI) + 131.5)))
				cRODSTAR.SPMEntered = -1S
				cRODSTAR.CalcPlungerSize = 0S
				If RSWIN_DESC.bRodStarD Then
					cRODSTAR.CalcFriction = 0S
				Else
					cRODSTAR.CalcFriction = -1S
				End If
				If num11 >= 0F Then
					cRODSTAR.FluidLevelEntered = True
					cRODSTAR.giFluidLevelSource = 1S
					giFluidLevelSource = cRODSTAR.giFluidLevelSource
					cRODSTAR.FluidLevel = num11
				Else
					cRODSTAR.gbCalcPumpCondition = False
					Select Case giFluidLevelSource
						Case 0S
							cRODSTAR.FluidLevel = cRODSTAR.PumpDepth
							cRODSTAR.FluidLevelEntered = True
						Case 1S
							cRODSTAR.FluidLevelEntered = True
						Case 2S
							cRODSTAR.FluidLevelEntered = False
					End Select
				End If
				Select Case cRODSTAR.PumpCondition
					Case 1S, 2S, 3S
					Case Else
						cRODSTAR.PumpCondition = 1S
				End Select
				If cRODSTAR.PumpCondition = 1S Then
					If Not cRODSTAR.IncludeFluidInertia <> 0S Then
						cRODSTAR.PumpEfficiency = 85F
					End If
				ElseIf cRODSTAR.PumpFillage >= 0F Then
					cRODSTAR.PumpFillage = Conversion.Int(cRODSTAR.PumpFillage * 100F)
					If cRODSTAR.PumpFillage > 95F Then
						cRODSTAR.PumpFillage = 95F
					End If
					If cRODSTAR.PumpFillage < 10F Then
						cRODSTAR.PumpFillage = 10F
					End If
				Else
					cRODSTAR.PumpFillage = 85F
				End If
				cRODSTAR.RodStringType = 2S
				cRODSTAR.APIRod = 0S
				cRODSTAR.APIGrade = 0S
				cRODSTAR.RSGrade = 0S
				cRODSTAR.RSMaxSize = 0F
				cRODSTAR.RSMinSize = 0F
				Dim sinkerBar As RSWIN_DESC.RodSection
				cRODSTAR.SinkerBar = sinkerBar
				If cRODSTAR.CompressibilityIndex < 0F Then
					cRODSTAR.CompressibilityIndex = 3F
				End If
				cRODSTAR.IrotEntered = If((-If(((cRODSTAR.Irot <> 0F) > False), 1S, 0S)), 1S, 0S)
				Dim num20 As Single = cRODSTAR.WaterCut / 100F * cRODSTAR.WaterSPGR + (1F - cRODSTAR.WaterCut / 100F) * cRODSTAR.OilSPGR
				If cRODSTAR.FluidSPGR = 0F Or cRODSTAR.FluidSPGR > num20 Then
					cRODSTAR.FluidSPGR = num20
				End If
				If pu.R = 0F And pu.CrankHole <> 0S Then
					pu.R = pu.CrankRadii(CInt(pu.CrankHole))
				End If
				If(If((-If((ThisVersion <= 3S > False), 1S, 0S)), 1S, 0S) And Not cRODSTAR.IDEntered And If((-If(((pu.CrankHole = 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					pu.CrankHole = 1S
					pu.CrankHoles = 1S
					pu.CrankRadii(1) = pu.R
					pu.Strokes(1) = CSng(Conversion.Int(CDbl(pu.KinematicStroke) + 0.5))
				End If
				cRODSTAR.WarnedAboutFluidInertia = False
				cRODSTAR.WarnedAboutPlungerSize = False
				cRODSTAR.CalcMotorSPV = 0S
				cRODSTAR.IrotEntered = 0S
				If ThisVersion <= 7S Then
					Motor.SelectMotorFromOldInfo(CInt(num8), fMotorSize, sMotorSizeName, CInt(iTorqueMode))
				End If
				Dim motorInfo As Object = Motor.GetMotorInfo(4)
				If Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 1, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 7, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 8, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 9, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 10, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 11, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 12, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 13, False))), True, False)) Then
					cRODSTAR.MotorSPV = 0F
					cRODSTAR.CalcMotorSPV = 0S
				ElseIf Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 3, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 2, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 4, False))), True, False)) Then
					cRODSTAR.MotorSPV = 0F
					cRODSTAR.CalcMotorSPV = -1S
				Else
					num8 = 1S
					cRODSTAR.CalcMotorSize = -1S
					cRODSTAR.CalcMotorSPV = 0S
				End If
				cRODSTAR.DragSettings = 0S
				cRODSTAR.FluidDamping = Conversions.ToSingle(ini.GetDataValue("FluidDamping", 4, True, 0.1))
				cRODSTAR.PumpDragUpstrokeMax = Conversions.ToSingle(ini.GetDataValue("PumpDragUpstrokeMax", 4, True, 200))
				cRODSTAR.PumpDragDownstrokeMax = Conversions.ToSingle(ini.GetDataValue("PumpDragDownstrokeMax", 4, True, 200))
				Dim unitID As String = cRODSTAR.UnitID
				Dim num21 As Short
				Dim obj As Object = num21
				Dim text3 As String
				PUDATA1.ParseUnitID(unitID, text3, obj)
				num21 = Conversions.ToShort(obj)
				Dim text4 As String = text3
				If Operators.CompareString(text4, "CAB", False) = 0 Then
					Dim cRODSTAR5 As cRODSTAR = cRODSTAR
					Dim str As String = "CAA"
					obj = CInt((num21 + 98S))
					cRODSTAR5.UnitID = str + Util.Format(obj).Trim()
				End If
				Dim num22 As Single
				Select Case cRODSTAR.PU.UnitType
					Case 6S
						If cRODSTAR.CBDataType <> 1S Or cRODSTAR.UnknownM Then
							cRODSTAR.Counterbalance = 0F
						End If
						num22 = 1F
						GoTo IL_1AC0
					Case 7S, 10S
						If cRODSTAR.CBDataType <> 1S Or cRODSTAR.UnknownM Then
							cRODSTAR.Counterbalance = 0F
						End If
						num22 = 1000F
						GoTo IL_1AC0
					Case 8S
						cRODSTAR.Counterbalance = 0F
						num22 = 1F
						GoTo IL_1AC0
				End Select
				If cRODSTAR.CBDataType <> 1S Or cRODSTAR.UnknownM Then
					cRODSTAR.Counterbalance = 0F
				End If
				num22 = 1000F
				IL_1AC0:
				If cRODSTAR.CBDataType = 1S AndAlso Not RSWIN_DESC.rst.UnknownM AndAlso cRODSTAR.get_M(2) / num22 <> 0F Then
					cRODSTAR.Counterbalance = cRODSTAR.get_M(2) / num22
				End If
				If pu.CrankHoles = 0S Then
					pu.CrankRadii(0) = pu.R
					pu.CrankHoles = 1S
					pu.CrankHole = 1S
					kinemat.Kinconst(pu)
					kinemat.Unitstroke(pu)
					pu.Strokes(0) = CSng(Conversion.Int(CDbl(pu.KinematicStroke) + 0.5))
				End If
				cRODSTAR.Iart = pu.ArtInertia
				cRODSTAR.PU = pu
				If ThisVersion < 18S Then
					If num14 <> num13 Then
						Dim a As Single() = array2
						num = 0F
						Dim num23 As Single = 0F
						Dim num24 As Single
						Dim num25 As Single
						Util.Maxmin(a, num24, num25, num, num23)
						Dim num26 As Single = 1F / (num24 - num25) * (num13 - num14)
						Dim num27 As Short = 0S
						Dim num28 As Short = cRODSTAR.RDNtsteps - 1S
						For num7 As Short = num27 To num28
							array2(CInt(num7)) = num14 + (array2(CInt(num7)) - num25) * num26
						Next
					End If
					If num12 <> 0F Then
						Dim sDYWXDIAGCorrectCard As String = RSWIN_DESC.sDYWXDIAGCorrectCard
						Dim bDefaultYes As Boolean = True
						Dim flag2 As Boolean = False
						If Util.YesNo(sDYWXDIAGCorrectCard, bDefaultYes, flag2) Then
							Dim num29 As Short = 0S
							Dim num30 As Short = cRODSTAR.RDNtsteps - 1S
							For num7 As Short = num29 To num30
								array2(CInt(num7)) = array2(CInt(num7)) - num12
							Next
						End If
					End If
				ElseIf num16 <> 0S And num15 <> 0S Then
					Dim text5 As String = LoadXDG.sDYWXDIAGCorrected1
					text5 = Conversions.ToString(Operators.ConcatenateObject(text5, Interaction.IIf((num15 And 1S) = 0S, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + LoadXDG.sDYWXDIAGCorrected2)))
					text5 = Conversions.ToString(Operators.ConcatenateObject(text5, Interaction.IIf((num15 And 2S) = 0S, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + LoadXDG.sDYWXDIAGCorrected3)))
					text5 = Conversions.ToString(Operators.ConcatenateObject(text5, Interaction.IIf((num15 And 4S) = 0S, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + LoadXDG.sDYWXDIAGCorrected4)))
					text5 = Conversions.ToString(Operators.ConcatenateObject(text5, Interaction.IIf((num15 And 8S) = 0S, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + LoadXDG.sDYWXDIAGCorrected5)))
					text5 = Conversions.ToString(Operators.ConcatenateObject(text5, Interaction.IIf((num15 And 16S) = 0S, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + LoadXDG.sDYWXDIAGCorrected6)))
					text5 = Conversions.ToString(Operators.ConcatenateObject(text5, Interaction.IIf((num15 And 32S) = 0S, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + LoadXDG.sDYWXDIAGCorrected7)))
					text5 = Conversions.ToString(Operators.ConcatenateObject(text5, Interaction.IIf((num15 And 64S) = 0S, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + LoadXDG.sDYWXDIAGCorrected8)))
					text5 = Conversions.ToString(Operators.ConcatenateObject(text5, Interaction.IIf((num15 And 128S) = 0S, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + LoadXDG.sDYWXDIAGCorrected9)))
					text5 = text5 + Conversions.ToString(RSWIN_DESC.LF) + Conversions.ToString(RSWIN_DESC.LF) + LoadXDG.sDYWXDIAGCorrected10
					Dim msg As String = text5
					Dim bDefaultYes2 As Boolean = True
					Dim flag2 As Boolean = False
					If Util.YesNo(msg, bDefaultYes2, flag2) Then
						Dim array As Single()
						Dim num31 As Short
						Dim num32 As Short
						array2 = New Single(CInt((num16 - 1S + 1S)) - 1) {}
						array = New Single(CInt((num16 - 1S + 1S)) - 1) {}
						cRODSTAR.dNtsteps = num16
						num31 = 0S
						num32 = cRODSTAR.dNtsteps - 1S
						For num33 As Short = num31 To num32
							array2(CInt(num33)) = array4(CInt(num33))
							array(CInt(num33)) = array3(CInt(num33))
						Next
						cRODSTAR.RDNtsteps = num16
						cRODSTAR.RDSurfPos = array
						cRODSTAR.RDSurfLoad = array2
					End If
				End If
				If ThisVersion <= 7S Then
					Motor.SelectMotorFromOldInfo(CInt(num8), fMotorSize, sMotorSizeName, CInt(iTorqueMode))
				End If
				Dim motorInfo2 As Object = Motor.GetMotorInfo(4)
				If Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo2, 1, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo2, 7, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo2, 8, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo2, 9, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo2, 10, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo2, 11, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo2, 12, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo2, 13, False))), True, False)) Then
					cRODSTAR.MotorSPV = 0F
					cRODSTAR.CalcMotorSPV = 0S
				ElseIf Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo2, 3, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo2, 2, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo2, 4, False))), True, False)) Then
					cRODSTAR.MotorSPV = 0F
					cRODSTAR.CalcMotorSPV = -1S
				Else
					num8 = 1S
					cRODSTAR.CalcMotorSize = -1S
					cRODSTAR.CalcMotorSPV = 0S
				End If
				If cRODSTAR.giFluidLevelSource > 0S Then
					cRODSTAR.giFluidLevelSource -= 1S
				End If
				If Not IsXDIAG Then
					cRODSTAR.gbRoddiagFile = True
					cRODSTAR.PumpFriction = 200F
					cRODSTAR.SPMEntered = -1S
					cRODSTAR.CalcPlungerSize = 0S
					giFluidLevelSource = Conversions.ToShort(Interaction.IIf(cRODSTAR.FluidLevel > 0F, 1, 0))
					Select Case giFluidLevelSource
						Case 0S
							cRODSTAR.FluidLevel = cRODSTAR.PumpDepth
							cRODSTAR.FluidLevelEntered = True
						Case 1S
							cRODSTAR.FluidLevelEntered = True
						Case 2S
							cRODSTAR.FluidLevelEntered = False
					End Select
					Dim flag2 As Boolean
					If cRODSTAR.PumpFillage >= 0F Then
						cRODSTAR.PumpFillage = Conversion.Int(cRODSTAR.PumpFillage * 100F)
						If cRODSTAR.PumpFillage > 95F Then
							cRODSTAR.PumpFillage = 95F
						End If
					Else
						Dim cRODSTAR6 As cRODSTAR = cRODSTAR
						Dim sDefaultName3 As String = "PumpFillage"
						Dim vNotPresentDefault3 As Object = 85
						flag2 = False
						cRODSTAR6.PumpFillage = Conversions.ToSingle(ini.GetDefault(sDefaultName3, vNotPresentDefault3, flag2))
					End If
					cRODSTAR.RodStringType = 2S
					cRODSTAR.APIRod = 0S
					cRODSTAR.APIGrade = 0S
					cRODSTAR.RSGrade = 0S
					cRODSTAR.RSMaxSize = 0F
					cRODSTAR.RSMinSize = 0F
					cRODSTAR.SinkerBar = sinkerBar
					cRODSTAR.OilSPGR = CSng((141.5 / (CDbl(cRODSTAR.OilAPI) + 131.5)))
					If cRODSTAR.FluidSPGR = 0F Then
						cRODSTAR.FluidSPGR = cRODSTAR.WaterCut / 100F * cRODSTAR.WaterSPGR + (1F - cRODSTAR.WaterCut / 100F) * cRODSTAR.OilSPGR
					End If
					If(If((-If((ThisVersion <= 15S > False), 1S, 0S)), 1S, 0S) And Not cRODSTAR.IDEntered And If((-If(((pu.CrankHole = 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						pu.CrankHole = 1S
						pu.CrankHoles = 1S
						pu.CrankRadii(0) = pu.R
						pu.Strokes(0) = CSng(Conversion.Int(CDbl(pu.KinematicStroke) + 0.5))
					End If
					cRODSTAR.PU = pu
					RSWIN_DESC.WarnedAboutFluidInertia = 0S
					RSWIN_DESC.WarnedAboutPlungerSize = 0S
					cRODSTAR.PumpCondition = 1S
					Dim cRODSTAR7 As cRODSTAR = cRODSTAR
					Dim sDefaultName4 As String = "PumpEfficiency"
					Dim vNotPresentDefault4 As Object = 85
					flag2 = False
					cRODSTAR7.PumpEfficiency = Conversions.ToSingle(ini.GetDefault(sDefaultName4, vNotPresentDefault4, flag2))
					cRODSTAR.IncludeFluidInertia = If((-If(((MImpred.FluidInertiaPossible() And cRODSTAR.PumpDepth < 4250F And cRODSTAR.PlungerSize > 2F) > False), 1S, 0S)), 1S, 0S)
					Dim cRODSTAR8 As cRODSTAR = cRODSTAR
					Dim sDefaultName5 As String = "CompressibilityIndex"
					Dim vNotPresentDefault5 As Object = 3
					flag2 = False
					cRODSTAR8.CompressibilityIndex = Conversions.ToSingle(ini.GetDefault(sDefaultName5, vNotPresentDefault5, flag2))
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
					Dim cRODSTAR9 As cRODSTAR = cRODSTAR
					Dim sDefaultName6 As String = "PumpLoadAdjustment"
					Dim vNotPresentDefault6 As Object = 0
					flag2 = False
					cRODSTAR9.PumpLoadAdj = Conversions.ToSingle(ini.GetDefault(sDefaultName6, vNotPresentDefault6, flag2))
					If ThisVersion <= 19S Then
						If num8 = 0S Then
							num8 = 1S
							cRODSTAR.CalcMotorSize = -1S
							fMotorSize = 50F
						End If
						Motor.SelectMotorFromOldInfo(CInt(num8), fMotorSize, sMotorSizeName, CInt(iTorqueMode))
					End If
					Dim motorInfo3 As Object = Motor.GetMotorInfo(4)
					If Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo3, 1, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo3, 7, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo3, 8, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo3, 9, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo3, 10, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo3, 11, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo3, 12, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo3, 13, False))), True, False)) Then
						cRODSTAR.MotorSPV = 0F
						cRODSTAR.CalcMotorSPV = 0S
					ElseIf Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo3, 3, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo3, 2, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo3, 4, False))), True, False)) Then
						cRODSTAR.MotorSPV = 0F
						cRODSTAR.CalcMotorSPV = -1S
					Else
						num8 = 1S
						cRODSTAR.CalcMotorSize = -1S
						cRODSTAR.CalcMotorSPV = 0S
					End If
				Else
					Try
						cRODSTAR.IncludeFluidInertia = If((-If(((MImpred.FluidInertiaPossible() And cRODSTAR.PumpDepth < 4250F And cRODSTAR.PlungerSize > 2F) > False), 1S, 0S)), 1S, 0S)
					Catch ex6 As Exception
					End Try
				End If
				If cRODSTAR.CBDataType = 4S And Operators.CompareString(cRODSTAR.CBDataFile.Trim(), "", False) = 0 And Not cRODSTAR.UnknownM And cRODSTAR.get_M(2) <> 0F Then
					cRODSTAR.CBDataType = 1S
				End If
				cRODSTAR = Nothing
				If RSWIN_DESC.rst.WaterSPGR < 1F Then
					RSWIN_DESC.rst.WaterSPGR = 1F
				ElseIf CDbl(RSWIN_DESC.rst.WaterSPGR) > 1.5 Then
					RSWIN_DESC.rst.WaterSPGR = 1.5F
				End If
				RSWIN_DESC.rst.DownstrokeFrictionFactor = 1F
				RSWIN_DESC.rst.UpstrokeFrictionFactor = 1F
				bInputLoaded = True
				Try
					LoadXDG.CheckXDGInputData("")
				Catch ex7 As Exception
				End Try
			Catch ex8 As Exception
				Dim sMsg As String = "Error in LoadInputFile: " + ex8.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub LoadXdiagFile(ByRef frn As Integer, ByRef bFileLoaded As Boolean, IsXDIAG As Boolean, sInputfile As String)
			Try
				Dim num As Short
				FileSystem.FileGet(frn, num, -1L)
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num2 As Short = CShort(frn)
				Dim flag As Boolean
				LoadXDG.LoadInputData(num2, num, flag, IsXDIAG)
				frn = CInt(num2)
				Dim flag2 As Boolean
				If flag Then
					' The following expression was wrapped in a checked-expression
					Dim frn2 As Short = CShort(frn)
					num2 = If((-If((flag2 > False), 1S, 0S)), 1S, 0S)
					LoadXDG.LoadOutputData(frn2, num2)
					flag2 = (num2 <> 0S)
					MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
				End If
				rst.gbOutputLoaded = False
				If RSWIN_DESC.rst.gbBatch Then
					bFileLoaded = flag
				Else
					bFileLoaded = (flag AndAlso flag2)
				End If
				If bFileLoaded Then
					rst.pNtsteps = 0S
					rst.UnknownM = (rst.CBDataType = 1S And CDbl(rst.get_M(2)) = 0.0)
					rst.bCBEDigitized = If((-If(((rst.CBDataType = 3S) > False), 1S, 0S)), 1S, 0S)
					rst.bCBEFromDisk = If((-If(((rst.CBDataType = 4S) > False), 1S, 0S)), 1S, 0S)
					rst.Apump = CSng((3.141592653589793 * Math.Pow(CDbl(rst.PlungerSize), 2.0) / 4.0))
					rst.gbCalcFluidSPGR = False
					rst.OilSPGR = CSng((141.5 / (CDbl(rst.OilAPI) + 131.5)))
					rst.gfMaxFluidSPGR = LoadXDG.MaxFluidSPGR(rst.WaterCut, rst.WaterSPGR, rst.OilSPGR)
					If rst.FluidSPGR = 0F Then
						rst.gbCalcFluidSPGR = True
						rst.FluidSPGR = rst.gfMaxFluidSPGR
					ElseIf Not rst.gbCalcFluidSPGR Then
						If CDbl(Math.Abs(rst.FluidSPGR - rst.gfMaxFluidSPGR)) < 0.0005 Then
							rst.gbCalcFluidSPGR = False
							rst.FluidSPGR = rst.gfMaxFluidSPGR
						ElseIf rst.FluidSPGR > rst.gfMaxFluidSPGR Then
							rst.gbOutputLoaded = False
						End If
					End If
					Dim pu As RSWIN_DESC.PUDataRec = Nothing
					pu.Initialize()
					pu = rst.PU
					If pu.CrankHole <> 0S Then
						' The following expression was wrapped in a checked-expression
						pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
					End If
					If(If((-If((num <= 3S > False), 1S, 0S)), 1S, 0S) And Not rst.IDEntered And If((-If(((pu.CrankHole = 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						pu.CrankHole = 1S
						pu.CrankHoles = 1S
						pu.CrankRadii(0) = pu.R
						pu.Strokes(0) = CSng(Conversion.Int(CDbl(pu.KinematicStroke) + 0.5))
					End If
					rst.PU = pu
					Dim unitID As String = rst.UnitID
					Dim text As String
					Dim num3 As Integer
					PUDATA1.ParseUnitID(unitID, text, num3)
					Dim text2 As String = text
					If Operators.CompareString(text2, "CAB", False) = 0 Then
						Dim cRODSTAR As cRODSTAR = rst
						Dim str As String = "CAA"
						Dim obj As Object = num3 + 98
						cRODSTAR.UnitID = str + Util.Format(obj).Trim()
					End If
					If rst.dNtsteps = 0S Then
						rst.gbOutputLoaded = False
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in LoadXDiagFile: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub ConvertRodGrade(ByRef tSection As RSWIN_DESC.RodSection)
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
			ElseIf num4 = 107 OrElse num4 = 12803 Then
				num3 = 12806
			ElseIf num4 = 106 OrElse num4 = 12548 Then
				num3 = 12550
			ElseIf num4 = 103 Then
				num3 = 12801
			ElseIf num4 = 104 Then
				num3 = 12802
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
			ElseIf num4 = -2 Then
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

		Public Function MaxFluidSPGR(WaterCut As Single, WaterSPGR As Single, OilSPGR As Single) As Single
			Return WaterCut / 100F * WaterSPGR + (1F - WaterCut / 100F) * OilSPGR
		End Function

		Public Sub CheckXDGInputData(Optional sFileName As String = "")
			Dim num As Integer
			Dim num6 As Integer
			Dim obj2 As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim unitID As String = rst.UnitID
				pu = rst.PU
				rst.OilSPGR = CSng((141.5 / (CDbl(rst.OilAPI) + 131.5)))
				Dim num2 As Short
				Dim obj As Object = num2
				Dim text As String
				PUDATA1.ParseUnitID(unitID, text, obj)
				num2 = Conversions.ToShort(obj)
				Dim text2 As String = text
				If Operators.CompareString(text2, "CAB", False) = 0 Then
					Dim cRODSTAR As cRODSTAR = rst
					Dim str As String = "CAA"
					obj = CInt((num2 + 98S))
					cRODSTAR.UnitID = str + Util.Format(obj).Trim()
				End If
				Dim num3 As Integer = CInt(pu.CrankHole)
				Dim crankRotation As Integer = CInt(pu.CrankRotation)
				If Not MRodstarXML.bCustomPU Then
					PUDATA1.ReadPUData(rst.UnitID, pu, False, True)
				ElseIf MRodstarXML.bErrorCustomPU Then
					PUDATA1.ReadPUData(rst.UnitID, pu, False, True)
				End If
				pu.CrankHole = CShort(num3)
				pu.CrankRotation = CShort(crankRotation)
				If Not(pu.UnitType = 7S Or pu.UnitType = 10S) Then
					If num3 = 0 Then
						num3 = 1
						pu.CrankHole = CShort(num3)
					End If
					pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
				Else
					pu.R = pu.CrankRadii(0)
				End If
				kinemat.Kinconst(pu)
				kinemat.Unitstroke(pu)
				rst.PU = pu
				rst.Iart = rst.PU.ArtInertia
				RODUTIL.CheckCustomRodGrades()
				If rst.RodStringType = 2S Or rst.RodStringType = 4S Then
					Dim num4 As Integer = 1
					Dim numRods As Integer = CInt(rst.NumRods)
					For i As Integer = num4 To numRods
						RODUTIL.LookupRodDiameterForCorrection(rst.Sections(i))
						Dim sections As RSWIN_DESC.RodSection() = rst.Sections
						Dim num5 As Integer = i
						sections(num5).Area = CSng((CDbl((sections(num5).Diameter * sections(num5).Diameter)) * Math.Atan(1.0)))
						RODUTIL.LookupElasticity(rst.Sections(i))
						RODUTIL.LookupRodWeight(rst.Sections(i))
						RODUTIL.LookupStressMethod(rst.Sections(i))
						If Not CUSTOMRG.IsOtherSteel(CInt(rst.Sections(i).Grade)) Then
							RODUTIL.LookupTensileStrength(rst.Sections(i))
						ElseIf rst.Sections(i).TensileStrength = 0F Then
							RODUTIL.LookupTensileStrength(rst.Sections(i))
						End If
						If rst.Sections(i).Grade = 20481S Then
							rst.Sections(i).RodDensity = 100F
						ElseIf rst.Sections(i).Grade = 16393S Then
							rst.Sections(i).RodDensity = 125F
						ElseIf RODUTIL.IsFG(rst.Sections(i).Grade) Then
							rst.Sections(i).RodDensity = 130F
						Else
							rst.Sections(i).RodDensity = 491F
						End If
					Next
				End If
				IL_34F:
				GoTo IL_396
				IL_351:
				num6 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_367:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_351
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_396:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Const CB_CBE As Integer = 2

		Private Const CB_DIGITIZED As Integer = 3

		Private Const CB_DYNA As Integer = 4

		Private sDYWXDIAGCorrected1 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected1", "XDIAG corrected the following in the measured surface dynamometer card:")

		Private sDYWXDIAGCorrected2 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected2", "--  Stroke length (card rescaled)")

		Private sDYWXDIAGCorrected3 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected3", "--  Non-kinematic surface positions")

		Private sDYWXDIAGCorrected4 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected4", "--  Phase shift in surface positions")

		Private sDYWXDIAGCorrected5 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected5", "--  Surface load adjustment (user-specified)")

		Private sDYWXDIAGCorrected6 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected6", "--  Load shift (load cell measurement correction)")

		Private sDYWXDIAGCorrected7 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected7", "--  Load span")

		Private sDYWXDIAGCorrected8 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected8", "--  Phase shift in surface positions (user-specified)")

		Private sDYWXDIAGCorrected9 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected9", "--  Kinematic position replacement (user-specified)")

		Private sDYWXDIAGCorrected10 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected10", "Do you want to have the corrected card displayed instead of the measured card?")
	End Module
End Namespace
