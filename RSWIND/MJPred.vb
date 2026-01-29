Imports System
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module MJPred
		Public Property IndPumpOp As Short
			Get
				Return MJPred.m_IndPumpOp
			End Get
			Set(value As Short)
				MJPred.m_IndPumpOp = value
			End Set
		End Property

		Public Property Pumpfill As Single
			Get
				Return MJPred.m_Pumpfill
			End Get
			Set(value As Single)
				MJPred.m_Pumpfill = value
			End Set
		End Property

		Public Property dflnu As Single
			Get
				Return MJPred.m_dflnu
			End Get
			Set(value As Single)
				MJPred.m_dflnu = value
			End Set
		End Property

		Public Property Peff As Single
			Get
				Return MJPred.m_Peff
			End Get
			Set(value As Single)
				MJPred.m_Peff = value
			End Set
		End Property

		Public ReadOnly Property JPred As cJPred
			Get
				If MJPred.m_JPred Is Nothing Then
					MJPred.m_JPred = New cJPred()
				End If
				Return MJPred.m_JPred
			End Get
		End Property

		Public Sub InitJPred()
			If MJPred.m_JPred Is Nothing Then
				MJPred.m_JPred = New cJPred()
			End If
		End Sub

		Public Sub RunJPred(sTask As String)
			Try
				Dim nelem As Short
				Dim dt As Double
				Dim dx As Double
				Dim speemax As Double
				MJPred.CalcNtsteps(nelem, dt, dx, speemax)
				If(If((-If((RSWIN_DESC.rst.Ntsteps >= 750S > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.WarnedAboutLargeNtsteps) <> 0S Then
					Dim msg As String
					If RSWIN_DESC.rst.SPMEntered <> 0S Then
						Util.LoadMessage(70, msg)
					Else
						Util.LoadMessage(149, msg)
					End If
					Verify.VerifyContinueOrReturn(msg, True)
					RSWIN_DESC.WarnedAboutLargeNtsteps = -1S
				End If
				Dim num As Single
				If RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru Then
					Try
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						If Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.MaxTubingSizeOD <> 0F Then
							If Not RSWIN_DESC.SETUP_FixTubingSize And rst.TubingOD > RSWIN_DESC.MaxTubingSizeOD Then
								rst.TubingOD = RSWIN_DESC.MaxTubingSizeOD
								rst.TubingID = RODUTIL.GetMaxTubingSizeID(rst.TubingOD)
							ElseIf RSWIN_DESC.SETUP_FixTubingSize And rst.TubingOD <> RSWIN_DESC.MaxTubingSizeOD Then
								rst.TubingOD = RSWIN_DESC.MaxTubingSizeOD
								rst.TubingID = RODUTIL.GetMaxTubingSizeID(rst.TubingOD)
							End If
							Dim maxCasingSize As Single = RSWIN_DESC.MaxCasingSize
							num = RSWIN_DESC.MaxTubingSizeOD
							Dim num2 As Single
							Dim num3 As Single
							Dim num4 As Single
							RODUTIL.GetSizeFromCasingSize(maxCasingSize, num, num2, num3, num4, False)
							RSWIN_DESC.MaxTubingSizeOD = num
							If rst.RSMaxSize > num2 Then
								rst.RSMaxSize = num2
							End If
							If rst.RSMinSize > num2 Then
								rst.RSMinSize = num2
							End If
							If rst.PlungerSize > num3 Then
								rst.PlungerSize = num3
							End If
							If rst.SinkerBar.Diameter > num4 Then
								Dim sinkerBar As RSWIN_DESC.RodSection
								sinkerBar.Initialize()
								sinkerBar = rst.SinkerBar
								sinkerBar.Diameter = num4
								RODUTIL.LookupElasticity(sinkerBar)
								RODUTIL.LookupRodWeight(sinkerBar)
								RODUTIL.LookupTensileStrength(sinkerBar)
								rst.SinkerBar = sinkerBar
							End If
						End If
					Catch ex As Exception
					End Try
				End If
				Dim jpred As cJPred = MJPred.m_JPred
				RSWIN_DESC.rst.Apump = CSng((3.141592653589793 * CDbl(RSWIN_DESC.rst.PlungerSize) * CDbl(RSWIN_DESC.rst.PlungerSize) / 4.0))
				jpred.Apump = RSWIN_DESC.rst.Apump
				jpred.CalcFriction = (RSWIN_DESC.rst.CalcFriction <> 0S)
				jpred.CasingPressure = RSWIN_DESC.rst.CasingPressure
				jpred.CompressibilityIndex = RSWIN_DESC.rst.CompressibilityIndex
				jpred.dflnu = MJPred.dflnu
				jpred.DownstrokeFriction = RSWIN_DESC.rst.DownstrokeFriction
				jpred.DownstrokeFrictionFactor = 1F
				jpred.Dt = dt
				jpred.Dx = dx
				jpred.FluidDens = RSWIN_DESC.rst.FluidDens
				jpred.FluidLevel = RSWIN_DESC.rst.FluidLevel
				jpred.FluidLoad = RSWIN_DESC.rst.FluidLoad
				jpred.FluidSPGR = RSWIN_DESC.rst.FluidSPGR
				jpred.IncludeFluidInertia = (RSWIN_DESC.rst.IncludeFluidInertia <> 0S)
				jpred.IndPumpOp = MJPred.IndPumpOp
				jpred.Iart = RSWIN_DESC.rst.Iart
				jpred.Irot = RSWIN_DESC.rst.Irot
				jpred.M_BalancedT = RSWIN_DESC.rst.get_M(1)
				jpred.M_Existing = RSWIN_DESC.rst.get_M(2)
				jpred.MotorSPV = RSWIN_DESC.rst.MotorSPV
				jpred.Ncycles = 0S
				jpred.nelem = nelem
				jpred.Ntsteps = RSWIN_DESC.rst.Ntsteps
				jpred.NumRods = RSWIN_DESC.rst.NumRods
				jpred.Peff = MJPred.Peff
				jpred.Pintake = RSWIN_DESC.rst.PumpIntakePressure
				jpred.PlungerSize = RSWIN_DESC.rst.PlungerSize
				jpred.PU_A = RSWIN_DESC.rst.PU.A
				If RSWIN_DESC.rst.PU.UnitType = 9S Then
					jpred.PU_CrankOffset = RSWIN_DESC.rst.PU.CrankOffset
				Else
					jpred.PU_CrankOffset = RSWIN_DESC.rst.PU.CrankOffset
				End If
				jpred.PU_DrumDiamRatio = RSWIN_DESC.rst.PU.DrumDiamRatio
				jpred.PU_KinematicStroke = RSWIN_DESC.rst.PU.KinematicStroke
				jpred.PU_M = RSWIN_DESC.rst.PU.M
				jpred.PU_S = RSWIN_DESC.rst.PU.S
				jpred.PU_Unbalance = RSWIN_DESC.rst.PU.Unbalance
				jpred.PU_UnitType = RSWIN_DESC.rst.PU.UnitType
				jpred.PU_V0 = RSWIN_DESC.rst.PU.V0
				jpred.PumpCondition = RSWIN_DESC.rst.PumpCondition
				jpred.PumpDepth = RSWIN_DESC.rst.PumpDepth
				If RSWIN_DESC.rst.PU.UnitType = 9S Then
					jpred.PU_Unbalance = 0F
				End If
				jpred.Pumpfill = MJPred.Pumpfill
				jpred.PumpFriction = RSWIN_DESC.rst.PumpFriction
				jpred.PumpLoadAdj = RSWIN_DESC.rst.PumpLoadAdj
				jpred.Speemax = speemax
				jpred.SPM = RSWIN_DESC.rst.SPM
				jpred.SteelRodString = RSWIN_DESC.rst.gbSteelRodString
				jpred.StuffingBoxFriction = RSWIN_DESC.rst.StuffingBoxFriction
				jpred.TotalTheta = RSWIN_DESC.rst.TotalTheta
				jpred.TubingID = RSWIN_DESC.rst.TubingID
				jpred.TubingPressure = RSWIN_DESC.rst.TubingPressure
				jpred.TubStretch = RSWIN_DESC.rst.TubStretch
				jpred.UpstrokeFriction = RSWIN_DESC.rst.UpstrokeFriction
				jpred.UpstrokeFrictionFactor = 1F
				jpred.WrodsInFluid = RSWIN_DESC.rst.WrodsInFluid
				If RSWIN_DESC.DEBUG_SetNcycles <> 0S Then
					jpred.Ncycles = RSWIN_DESC.DEBUG_SetNcycles
				End If
				Dim num5 As Short = 1S
				Dim numRods As Short = RSWIN_DESC.rst.NumRods
				For num6 As Short = num5 To numRods
					jpred.set_RodDiameter(CInt(num6), RSWIN_DESC.rst.Sections(CInt(num6)).Diameter)
					RODUTIL.LookupElasticity(RSWIN_DESC.rst.Sections(CInt(num6)))
					jpred.set_RodElasticity(CInt(num6), RSWIN_DESC.rst.Sections(CInt(num6)).Elasticity)
					jpred.set_RodGrade(CInt(num6), CInt(RSWIN_DESC.rst.Sections(CInt(num6)).Grade))
					jpred.set_RodLength(CInt(num6), RSWIN_DESC.rst.Sections(CInt(num6)).length)
					RODUTIL.LookupRodWeight(RSWIN_DESC.rst.Sections(CInt(num6)))
					jpred.set_RodWeight(CInt(num6), RSWIN_DESC.rst.Sections(CInt(num6)).RodWeight)
					RODUTIL.CheckSuckerRodLength(RSWIN_DESC.rst.Sections(CInt(num6)), True)
					If RSWIN_DESC.rst.Sections(CInt(num6)).friction_coef = 0F And RSWIN_DESC.bRodStarD Then
						RSWIN_DESC.rst.Sections(CInt(num6)).friction_coef = RODUTIL.GetFricCoeff(CInt(RSWIN_DESC.rst.Sections(CInt(num6)).Guide), True)
					End If
					RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(CInt(num6)))
				Next
				If RSWIN_DESC.rst.bHasFGlass Then
					If CDbl(RSWIN_DESC.rst.DownstrokeFriction) < 0.5 Then
						jpred.DownstrokeFriction = 0.5F
					End If
					If CDbl(RSWIN_DESC.rst.UpstrokeFriction) < 0.5 Then
						jpred.UpstrokeFriction = 0.5F
					End If
				End If
				MJPred.ShowData(MJPred.m_JPred)
				Dim jpred2 As cJPred = MJPred.m_JPred
				jpred2.JPred()
				Dim jpred3 As cJPred = MJPred.m_JPred
				If RSWIN_DESC.rst.CalcFriction <> 0S Then
					RSWIN_DESC.rst.DownstrokeFriction = jpred3.DownstrokeFriction
					RSWIN_DESC.rst.UpstrokeFriction = jpred3.UpstrokeFriction
					ini.SaveDataValue("DownstrokeFriction", RSWIN_DESC.rst.DownstrokeFriction)
					ini.SaveDataValue("UpstrokeFriction", RSWIN_DESC.rst.UpstrokeFriction)
				End If
				RSWIN_DESC.rst.set_M(1, jpred3.M_BalancedT)
				Dim num7 As Short
				Dim num8 As Short
				Dim num9 As Short
				Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.SurfPos = array
				array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.SurfLoad = array
				array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.PumpPos = array
				array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.PumpLoad = array
				array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.PermLoad = array
				array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.Tf = array
				array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.Thetac = array
				array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.prvel = array
				Dim tnet As Single(,) = New Single(2, CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.Tnet = tnet
				If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
					Dim text As String = "c:\TempRSWINFiles\JPred-Torques.csv"
					If FILEUTIL.FileExists(text) Then
						FileSystem.Kill("c:\TempRSWINFiles\JPred-Torques.csv")
					End If
					num7 = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num7), "c:\TempRSWINFiles\JPred-Torques.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
					FileSystem.PrintLine(CInt(num7), New Object() { "Index , Existing , BalancedT" })
				End If
				num8 = 0S
				num9 = RSWIN_DESC.rst.Ntsteps - 1S
				For num6 As Short = num8 To num9
					' The following expression was wrapped in a checked-statement
					RSWIN_DESC.rst.SurfPos(CInt(num6)) = jpred3.get_SurfPos(CInt((num6 + 1S)))
					RSWIN_DESC.rst.SurfLoad(CInt(num6)) = jpred3.get_SurfLoad(CInt((num6 + 1S)))
					RSWIN_DESC.rst.PumpPos(CInt(num6)) = jpred3.get_PumpPos(CInt((num6 + 1S)))
					RSWIN_DESC.rst.PumpLoad(CInt(num6)) = jpred3.get_PumpLoad(CInt((num6 + 1S)))
					RSWIN_DESC.rst.PermLoad(CInt(num6)) = jpred3.get_PermLoad(CInt((num6 + 1S)))
					RSWIN_DESC.rst.Tf(CInt(num6)) = jpred3.get_Tf(CInt((num6 + 1S)))
					RSWIN_DESC.rst.Thetac(CInt(num6)) = jpred3.get_Thetac(CInt((num6 + 1S)))
					RSWIN_DESC.rst.prvel(CInt(num6)) = jpred3.get_prvel(CInt((num6 + 1S)))
					If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And Not RSWIN_DESC.bBeamBalanced Then
						RSWIN_DESC.rst.Tnet(1, CInt(num6)) = jpred3.get_TnetB(CInt((num6 + 1S)))
						RSWIN_DESC.rst.Tnet(2, CInt(num6)) = jpred3.get_TnetE(CInt((num6 + 1S)))
					End If
					If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
						FileSystem.PrintLine(CInt(num7), New Object() { String.Concat(New String() { Conversions.ToString(CInt(num6)), " , ", Conversions.ToString(RSWIN_DESC.rst.Tnet(2, CInt(num6))), " , ", Conversions.ToString(RSWIN_DESC.rst.Tnet(1, CInt(num6))) }) })
					End If
				Next
				Dim pumpPos As Single() = RSWIN_DESC.rst.PumpPos
				num = 0F
				Dim pprload As Single = 0F
				Dim num10 As Single
				Dim num11 As Single
				Util.Maxmin(pumpPos, num10, num11, num, pprload)
				Dim num12 As Single
				Dim num13 As Single
				Dim num14 As Single
				Dim num15 As Single
				Util.Maxmin(RSWIN_DESC.rst.SurfPos, num12, num13, num14, num15)
				If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
					FileSystem.FileClose(New Integer() { CInt(num7) })
				End If
				Dim surfLoad As Single() = RSWIN_DESC.rst.SurfLoad
				Dim rst2 As cRODSTAR = RSWIN_DESC.rst
				pprload = rst2.Pprload
				Dim rst3 As cRODSTAR = RSWIN_DESC.rst
				num = rst3.Mprload
				Dim num16 As Single = 0F
				Dim num17 As Single = 0F
				Util.Maxmin(surfLoad, pprload, num, num16, num17)
				rst3.Mprload = num
				rst2.Pprload = pprload
				Dim pumpLoad As Single() = RSWIN_DESC.rst.PumpLoad
				num17 = 0F
				num16 = 0F
				Dim num18 As Single
				Dim num19 As Single
				Util.Maxmin(pumpLoad, num18, num19, num17, num16)
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub CalcNtsteps(ByRef Nelem As Short, ByRef Dt As Double, ByRef dx As Double, ByRef Speemax As Double)
			Dim num As Integer
			Dim num9 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				RSWIN_DESC.rst.RodstringL = 0F
				Dim num2 As Short = 1S
				Dim numRods As Short = RSWIN_DESC.rst.NumRods
				For num3 As Short = num2 To numRods
					RSWIN_DESC.rst.RodstringL = RSWIN_DESC.rst.RodstringL + RSWIN_DESC.rst.Sections(CInt(num3)).length
				Next
				Dim num4 As Single = 0F
				Dim num5 As Short = 1S
				Dim numRods2 As Short = rst.NumRods
				For num3 As Short = num5 To numRods2
					If rst.Sections(CInt(num3)).Elasticity = 0F Then
						RODUTIL.LookupElasticity(rst.Sections(CInt(num3)))
					End If
					If rst.Sections(CInt(num3)).Grade = 20481S Then
						rst.Sections(CInt(num3)).RodDensity = 100F
					ElseIf rst.Sections(CInt(num3)).Grade = 16393S Then
						rst.Sections(CInt(num3)).RodDensity = 125F
					ElseIf RODUTIL.IsFG(rst.Sections(CInt(num3)).Grade) Then
						rst.Sections(CInt(num3)).RodDensity = 130F
					Else
						rst.Sections(CInt(num3)).RodDensity = 491F
					End If
					Dim num6 As Single = rst.Sections(CInt(num3)).Elasticity / rst.Sections(CInt(num3)).RodDensity
					If num6 > num4 Then
						num4 = num6
					End If
				Next
				Speemax = Math.Sqrt(CDbl((4633.056F * num4)))
				Dim num7 As Double = CDbl((60F / rst.SPM))
				Dim num8 As Short
				If rst.PumpCondition <> 1S And rst.PumpIntakePressure < 600F Then
					num8 = 300S
				ElseIf rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Then
					num8 = 250S
				ElseIf rst.IncludeFluidInertia <> 0S Then
					If rst.PumpDepth < 1500F Then
						num8 = 250S
					Else
						num8 = 200S
					End If
				ElseIf Not rst.gbSteelRodString Then
					num8 = 200S
				Else
					num8 = 160S
				End If
				Do
					Nelem = 0S
					Do
						Nelem += 1S
						dx = CDbl((rst.RodstringL / CSng(Nelem)))
						Dt = dx / Speemax
						rst.Ntsteps = CShort(Math.Round(num7 / Dt)) + 1S
						Dt = num7 / CDbl(rst.Ntsteps)
					Loop While rst.Ntsteps < num8
					If Nelem >= 2S And rst.Ntsteps > 325S Then
						num8 -= 15S
					End If
				Loop While Not(Nelem = 1S Or rst.Ntsteps <= 325S)
				Speemax = dx / Dt
				IL_2D4:
				GoTo IL_31B
				IL_2D6:
				num9 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2EC:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num9 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2D6
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_31B:
			If num9 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function FluidInertiaPossible() As Boolean
			Dim result As Boolean = True
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If rst.PumpCondition = 3S Then
				result = False
			ElseIf rst.CalcPlungerSize <> 0S Then
				If rst.PumpDepth >= 4250F Then
					result = False
				ElseIf(Not rst.SPMEntered And If((-If((rst.TargetBFPD < 500F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					result = False
				End If
			Else
				Dim pumpDepth As Single = rst.PumpDepth
				If pumpDepth > 5000F Then
					result = False
				ElseIf pumpDepth >= 4250F Then
					If CDbl(rst.PlungerSize) < 2.75 Then
						result = False
					End If
				ElseIf rst.PlungerSize < 2F Then
					result = False
				End If
			End If
			Return result
		End Function

		Public Sub PumpBoundCond()
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If rst.FluidLevelEntered Then
					rst.PumpIntakePressure = CSng((CDbl(((rst.PumpDepth - rst.FluidLevel) * rst.OilSPGR)) * 0.433 + CDbl(rst.CasingPressure) + 14.7))
				Else
					rst.FluidLevel = CSng((CDbl(rst.PumpDepth) - (CDbl((rst.PumpIntakePressure - rst.CasingPressure)) - 14.7) / (CDbl(rst.OilSPGR) * 0.433)))
				End If
				MJPred.Peff = rst.PumpEfficiency / 100F
				MJPred.Pumpfill = rst.PumpFillage / 100F
				rst.FluidDens = CSng((CDbl(rst.FluidSPGR) * 62.4))
				rst.FeetOverPump = rst.PumpDepth - rst.FluidLevel
				rst.Apump = CSng((3.141592653589793 * CDbl(rst.PlungerSize) * CDbl(rst.PlungerSize) / 4.0))
				rst.FluidLoad = CSng(((0.433 * CDbl((rst.FluidSPGR * rst.PumpDepth - rst.OilSPGR * rst.FeetOverPump)) + CDbl(rst.TubingPressure) - CDbl(rst.CasingPressure)) * CDbl(rst.Apump)))
				Dim num As Single
				If Not rst.TubingAnchored <> 0S Then
					num = rst.PumpDepth
					rst.TubStretch = RUNCALC.TubingStretch(num)
				Else
					num = rst.PumpDepth - rst.TubingAnchorDepth
					If num > 50F Then
						rst.TubStretch = RUNCALC.TubingStretch(num)
					Else
						rst.TubStretch = 0F
					End If
				End If
				MJPred.IndPumpOp = 0S
				If rst.PumpCondition = 1S Then
					rst.Pfill = MJPred.Peff
					If num > 100F And CDbl(rst.TubStretch) > 0.25 Then
						MJPred.dflnu = rst.TubStretch
						MJPred.IndPumpOp = 2S
					Else
						MJPred.dflnu = 0F
						MJPred.IndPumpOp = 0S
					End If
				Else
					rst.Pfill = MJPred.Pumpfill
					If num > 100F And rst.TubStretch >= 1F Then
						MJPred.dflnu = rst.TubStretch
						MJPred.IndPumpOp = 3S
					Else
						MJPred.dflnu = 0F
						MJPred.IndPumpOp = 1S
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowArray(sTitle As String, ByRef rgArray As Single())
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim num2 As Single = 0F
				Dim num3 As Short
				Dim num4 As Short
				num3 = CShort(Information.LBound(rgArray, 1))
				num4 = CShort(Information.UBound(rgArray, 1))
				For num5 As Short = num3 To num4
					num2 += rgArray(CInt(num5))
				Next
				IL_35:
				GoTo IL_7A
				IL_37:
				num6 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_4C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_37
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7A:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub ShowArrayD(sTitle As String, ByRef rgArray As Double())
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim num2 As Double = 0.0
				Dim num3 As Short
				Dim num4 As Short
				num3 = CShort(Information.LBound(rgArray, 1))
				num4 = CShort(Information.UBound(rgArray, 1))
				For num5 As Short = num3 To num4
					num2 += rgArray(CInt(num5))
				Next
				IL_39:
				GoTo IL_7E
				IL_3B:
				num6 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_50:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_3B
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7E:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub ShowData(ByRef P As cJPred)
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				IL_0A:
				GoTo IL_51
				IL_0C:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_22:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_0C
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_51:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Const GravCon As Double = 32.174

		Private Const WaterSpWt As Double = 62.4

		Private m_JPred As cJPred

		Private m_Pumpfill As Single

		Private m_dflnu As Single

		Private m_Peff As Single

		Private m_IndPumpOp As Short
	End Module
End Namespace
