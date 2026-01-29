Imports System
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class cJPred
		Public Property ARoverC As Single
			Get
				Return Me.m_ARoverC
			End Get
			Set(value As Single)
				Me.m_ARoverC = value
			End Set
		End Property

		Public Property Apump As Single
			Get
				Return Me.m_Apump
			End Get
			Set(value As Single)
				Me.m_Apump = value
			End Set
		End Property

		Public Property CalcFriction As Boolean
			Get
				Return Me.m_CalcFriction
			End Get
			Set(value As Boolean)
				Me.m_CalcFriction = value
			End Set
		End Property

		Public Property CasingPressure As Single
			Get
				Return Me.m_CasingPressure
			End Get
			Set(value As Single)
				Me.m_CasingPressure = value
			End Set
		End Property

		Public Property CompressibilityIndex As Single
			Get
				Return Me.m_CompressibilityIndex
			End Get
			Set(value As Single)
				Me.m_CompressibilityIndex = value
			End Set
		End Property

		Public Property dflnu As Single
			Get
				Return Me.m_dflnu
			End Get
			Set(value As Single)
				Me.m_dflnu = value
			End Set
		End Property

		Public Property DownstrokeFriction As Single
			Get
				Return Me.m_DownstrokeFriction
			End Get
			Set(value As Single)
				Me.m_DownstrokeFriction = value
			End Set
		End Property

		Public Property DownstrokeFrictionFactor As Single
			Get
				Return Me.m_DownstrokeFrictionFactor
			End Get
			Set(value As Single)
				Me.m_DownstrokeFrictionFactor = value
			End Set
		End Property

		Public Property Dt As Double
			Get
				Return Me.m_Dt
			End Get
			Set(value As Double)
				Me.m_Dt = value
			End Set
		End Property

		Public Property Dx As Double
			Get
				Return Me.m_Dx
			End Get
			Set(value As Double)
				Me.m_Dx = value
			End Set
		End Property

		Public Property FluidDens As Single
			Get
				Return Me.m_FluidDens
			End Get
			Set(value As Single)
				Me.m_FluidDens = value
			End Set
		End Property

		Public Property FluidLevel As Single
			Get
				Return Me.m_FluidLevel
			End Get
			Set(value As Single)
				Me.m_FluidLevel = value
			End Set
		End Property

		Public Property FluidLoad As Single
			Get
				Return Me.m_FluidLoad
			End Get
			Set(value As Single)
				Me.m_FluidLoad = value
			End Set
		End Property

		Public Property FluidSPGR As Single
			Get
				Return Me.m_FluidSPGR
			End Get
			Set(value As Single)
				Me.m_FluidSPGR = value
			End Set
		End Property

		Public Property Iart As Single
			Get
				Return Me.m_Iart
			End Get
			Set(value As Single)
				Me.m_Iart = value
			End Set
		End Property

		Public Property IncludeFluidInertia As Boolean
			Get
				Return Me.m_IncludeFluidInertia
			End Get
			Set(value As Boolean)
				Me.m_IncludeFluidInertia = value
			End Set
		End Property

		Public Property IndPumpOp As Short
			Get
				Return Me.m_IndPumpOp
			End Get
			Set(value As Short)
				Me.m_IndPumpOp = value
			End Set
		End Property

		Public Property Irot As Single
			Get
				Return Me.m_Irot
			End Get
			Set(value As Single)
				Me.m_Irot = value
			End Set
		End Property

		Public Property M_BalancedT As Single
			Get
				Return Me.m_M_BalancedT
			End Get
			Set(value As Single)
				Me.m_M_BalancedT = value
			End Set
		End Property

		Public Property M_Existing As Single
			Get
				Return Me.m_M_Existing
			End Get
			Set(value As Single)
				Me.m_M_Existing = value
			End Set
		End Property

		Public Property MotorSPV As Single
			Get
				Return Me.m_MotorSPV
			End Get
			Set(value As Single)
				Me.m_MotorSPV = value
			End Set
		End Property

		Public Property Ncycles As Short
			Get
				Return Me.m_Ncycles
			End Get
			Set(value As Short)
				Me.m_Ncycles = value
			End Set
		End Property

		Public Property nelem As Short
			Get
				Return Me.m_nelem
			End Get
			Set(value As Short)
				Me.m_nelem = value
				Me.V = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.V1 = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.F = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.F1 = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.A = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.B = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.Cup = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.Cdown = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.AP = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.BP = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.CPup = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.CPdown = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.Pfld = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.Pfld1 = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.Vfld = New Single(CInt((Me.nelem + 1S)) - 1) {}
				Me.Vfld1 = New Single(CInt((Me.nelem + 1S)) - 1) {}
			End Set
		End Property

		Public Property Ntsteps As Short
			Get
				Return Me.m_Ntsteps
			End Get
			Set(value As Short)
				Me.m_Ntsteps = value
				Me.m_SurfPos = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
				Me.m_SurfLoad = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
				Me.m_PumpPos = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
				Me.m_PumpLoad = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
				Me.m_PermLoad = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
				Me.m_TnetB = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
				Me.m_TnetE = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
				Me.m_Tf = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
				Me.m_Thetac = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
				Me.m_prvel = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
				Me.Pp = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
				Me.TimeW = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
				Me.OMG1 = New Single(CInt((Me.m_Ntsteps + 1S + 1S)) - 1) {}
			End Set
		End Property

		Public Property NumRods As Short
			Get
				Return Me.m_NumRods
			End Get
			Set(value As Short)
				Me.m_NumRods = value
			End Set
		End Property

		Public Property Peff As Single
			Get
				Return Me.m_Peff
			End Get
			Set(value As Single)
				Me.m_Peff = value
			End Set
		End Property

		Public Property PermLoad(Index As Integer) As Single
			Get
				Return Me.m_PermLoad(Index)
			End Get
			Set(value As Single)
				Me.m_PermLoad(Index) = value
			End Set
		End Property

		Public Property Pintake As Single
			Get
				Return Me.m_Pintake
			End Get
			Set(value As Single)
				Me.m_Pintake = value
			End Set
		End Property

		Public Property PlungerSize As Single
			Get
				Return Me.m_PlungerSize
			End Get
			Set(value As Single)
				Me.m_PlungerSize = value
			End Set
		End Property

		Public Property prvel(Index As Integer) As Single
			Get
				Return Me.m_prvel(Index)
			End Get
			Set(value As Single)
				Me.m_prvel(Index) = value
			End Set
		End Property

		Public Property PU_A As Single
			Get
				Return Me.m_PU_A
			End Get
			Set(value As Single)
				Me.m_PU_A = value
			End Set
		End Property

		Public Property PU_C As Single
			Get
				Return Me.m_PU_C
			End Get
			Set(value As Single)
				Me.m_PU_C = value
			End Set
		End Property

		Public Property PU_CrankOffset As Single
			Get
				Return Me.m_PU_CrankOffset
			End Get
			Set(value As Single)
				Me.m_PU_CrankOffset = value
			End Set
		End Property

		Public Property PU_CrankRotation As Short
			Get
				Return Me.m_PU_CrankRotation
			End Get
			Set(value As Short)
				Me.m_PU_CrankRotation = value
			End Set
		End Property

		Public Property PU_DrumDiamRatio As Single
			Get
				Return Me.m_PU_DrumDiamRatio
			End Get
			Set(value As Single)
				Me.m_PU_DrumDiamRatio = value
			End Set
		End Property

		Public Property PU_I As Single
			Get
				Return Me.m_PU_I
			End Get
			Set(value As Single)
				Me.m_PU_I = value
			End Set
		End Property

		Public Property PU_K As Single
			Get
				Return Me.m_PU_K
			End Get
			Set(value As Single)
				Me.m_PU_K = value
			End Set
		End Property

		Public Property PU_KinematicStroke As Single
			Get
				Return Me.m_PU_KinematicStroke
			End Get
			Set(value As Single)
				Me.m_PU_KinematicStroke = value
			End Set
		End Property

		Public Property PU_M As Single
			Get
				Return Me.m_PU_M
			End Get
			Set(value As Single)
				Me.m_PU_M = value
			End Set
		End Property

		Public Property PU_P As Single
			Get
				Return Me.m_PU_P
			End Get
			Set(value As Single)
				Me.m_PU_P = value
			End Set
		End Property

		Public Property PU_R As Single
			Get
				Return Me.m_PU_R
			End Get
			Set(value As Single)
				Me.m_PU_R = value
			End Set
		End Property

		Public Property PU_S As Single
			Get
				Return Me.m_PU_S
			End Get
			Set(value As Single)
				Me.m_PU_S = value
			End Set
		End Property

		Public Property PU_SprocketDistance As Single
			Get
				Return Me.m_PU_SprocketDistance
			End Get
			Set(value As Single)
				Me.m_PU_SprocketDistance = value
			End Set
		End Property

		Public Property PU_SprocketRadius As Single
			Get
				Return Me.m_PU_SprocketRadius
			End Get
			Set(value As Single)
				Me.m_PU_SprocketRadius = value
			End Set
		End Property

		Public Property PU_Unbalance As Single
			Get
				Return Me.m_PU_Unbalance
			End Get
			Set(value As Single)
				Me.m_PU_Unbalance = value
			End Set
		End Property

		Public Property PU_UnitType As Short
			Get
				Return Me.m_PU_UnitType
			End Get
			Set(value As Short)
				Me.m_PU_UnitType = value
			End Set
		End Property

		Public Property PU_V0 As Single
			Get
				Return Me.m_PU_V0
			End Get
			Set(value As Single)
				Me.m_PU_V0 = value
			End Set
		End Property

		Public Property PumpCondition As Short
			Get
				Return Me.m_PumpCondition
			End Get
			Set(value As Short)
				Me.m_PumpCondition = value
			End Set
		End Property

		Public Property PumpDepth As Single
			Get
				Return Me.m_PumpDepth
			End Get
			Set(value As Single)
				Me.m_PumpDepth = value
			End Set
		End Property

		Public Property Pumpfill As Single
			Get
				Return Me.m_Pumpfill
			End Get
			Set(value As Single)
				Me.m_Pumpfill = value
			End Set
		End Property

		Public Property PumpFriction As Single
			Get
				Return Me.m_PumpFriction
			End Get
			Set(value As Single)
				Me.m_PumpFriction = value
			End Set
		End Property

		Public Property PumpLoad(Index As Integer) As Single
			Get
				Return Me.m_PumpLoad(Index)
			End Get
			Set(value As Single)
				Me.m_PumpLoad(Index) = value
			End Set
		End Property

		Public Property PumpLoadAdj As Single
			Get
				Return Me.m_PumpLoadAdj
			End Get
			Set(value As Single)
				Me.m_PumpLoadAdj = value
			End Set
		End Property

		Public Property PumpPos(Index As Integer) As Single
			Get
				Return Me.m_PumpPos(Index)
			End Get
			Set(value As Single)
				Me.m_PumpPos(Index) = value
			End Set
		End Property

		Public Property RodDiameter(Index As Integer) As Single
			Get
				Return Me.Sections(Index).Diameter
			End Get
			Set(value As Single)
				Me.Sections(Index).Diameter = value
				Me.Sections(Index).Area = CSng((3.141592653589793 * CDbl(value) * CDbl(value) / 4.0))
			End Set
		End Property

		Public Property RodElasticity(Index As Integer) As Single
			Get
				Return Me.Sections(Index).Elasticity
			End Get
			Set(value As Single)
				Me.Sections(Index).Elasticity = value
			End Set
		End Property

		Public Property RodGrade(Index As Integer) As Integer
			Get
				Return Me.Sections(Index).Grade
			End Get
			Set(value As Integer)
				Me.Sections(Index).Grade = value
			End Set
		End Property

		Public Property RodLength(Index As Integer) As Single
			Get
				Return Me.Sections(Index).Length
			End Get
			Set(value As Single)
				Me.Sections(Index).Length = value
			End Set
		End Property

		Public Property RodWeight(Index As Integer) As Single
			Get
				Return Me.Sections(Index).RodWeight
			End Get
			Set(value As Single)
				Me.Sections(Index).RodWeight = value
			End Set
		End Property

		Public Property Speemax As Double
			Get
				Return Me.m_Speemax
			End Get
			Set(value As Double)
				Me.m_Speemax = value
			End Set
		End Property

		Public Property SPM As Single
			Get
				Return Me.m_SPM
			End Get
			Set(value As Single)
				Me.m_SPM = value
			End Set
		End Property

		Public Property SteelRodString As Boolean
			Get
				Return Me.m_SteelRodString
			End Get
			Set(value As Boolean)
				Me.m_SteelRodString = value
			End Set
		End Property

		Public Property StuffingBoxFriction As Single
			Get
				Return Me.m_StuffingBoxFriction
			End Get
			Set(value As Single)
				Me.m_StuffingBoxFriction = value
			End Set
		End Property

		Public Property SurfLoad(Index As Integer) As Single
			Get
				Return Me.m_SurfLoad(Index)
			End Get
			Set(value As Single)
				Me.m_SurfLoad(Index) = value
			End Set
		End Property

		Public Property SurfPos(Index As Integer) As Single
			Get
				Return Me.m_SurfPos(Index)
			End Get
			Set(value As Single)
				Me.m_SurfPos(Index) = value
			End Set
		End Property

		Public Property TnetB(Index As Integer) As Single
			Get
				Return Me.m_TnetB(Index)
			End Get
			Set(value As Single)
				Me.m_TnetB(Index) = value
			End Set
		End Property

		Public Property TnetE(Index As Integer) As Single
			Get
				Return Me.m_TnetE(Index)
			End Get
			Set(value As Single)
				Me.m_TnetE(Index) = value
			End Set
		End Property

		Public Property Tf(Index As Integer) As Single
			Get
				Return Me.m_Tf(Index)
			End Get
			Set(value As Single)
				Me.m_Tf(Index) = value
			End Set
		End Property

		Public Property Thetac(Index As Integer) As Single
			Get
				Return Me.m_Thetac(Index)
			End Get
			Set(value As Single)
				Me.m_Thetac(Index) = value
			End Set
		End Property

		Public Property TotalTheta As Single
			Get
				Return Me.m_TotalTheta
			End Get
			Set(value As Single)
				Me.m_TotalTheta = value
			End Set
		End Property

		Public Property TubingID As Single
			Get
				Return Me.m_TubingID
			End Get
			Set(value As Single)
				Me.m_TubingID = value
			End Set
		End Property

		Public Property TubingPressure As Single
			Get
				Return Me.m_TubingPressure
			End Get
			Set(value As Single)
				Me.m_TubingPressure = value
			End Set
		End Property

		Public Property TubStretch As Single
			Get
				Return Me.m_TubStretch
			End Get
			Set(value As Single)
				Me.m_TubStretch = value
			End Set
		End Property

		Public Property UpstrokeFriction As Single
			Get
				Return Me.m_UpstrokeFriction
			End Get
			Set(value As Single)
				Me.m_UpstrokeFriction = value
			End Set
		End Property

		Public Property UpstrokeFrictionFactor As Single
			Get
				Return Me.m_UpstrokeFrictionFactor
			End Get
			Set(value As Single)
				Me.m_UpstrokeFrictionFactor = value
			End Set
		End Property

		Public Property WrodsInFluid As Single
			Get
				Return Me.m_WrodsInFluid
			End Get
			Set(value As Single)
				Me.m_WrodsInFluid = value
			End Set
		End Property

		Private Sub AddFluidInertiaLoad(Comp As Single, ByRef V As Single(), ByRef Vfld As Single(), ByRef Vfld1 As Single(), ByRef Pfld As Single(), ByRef Pfld1 As Single())
			If V(CInt(Me.m_nelem)) > 0F Then
				Vfld(CInt(Me.m_nelem)) = CSng((CDbl((-CDbl((Me.ApumpMod - Me.Sections(CInt(Me.m_NumRods)).Area)) * V(CInt(Me.m_nelem)))) / (Me.Atub - CDbl(Me.Sections(CInt(Me.m_NumRods)).Area))))
			Else
				Vfld(CInt(Me.m_nelem)) = CSng((CDbl((Me.Sections(CInt(Me.m_NumRods)).Area * V(CInt(Me.m_nelem)))) / (Me.Atub - CDbl(Me.Sections(CInt(Me.m_NumRods)).Area))))
			End If
			Dim num As Short
			Dim num2 As Double
			Dim num3 As Double
			Dim num4 As Double
			Dim num5 As Double
			num = Me.m_nelem - 1S
			While num >= 1S
				num2 = CDbl((Me.m_FluidDens * (1F + Comp * (Pfld1(CInt(num)) - Me.Po))))
				num3 = CDbl((Vfld1(CInt((num + 1S))) - Vfld1(CInt((num - 1S))))) / (4.0 * Me.m_Dx)
				num4 = 32.17399978637695 / num2 * (CDbl((Pfld1(CInt((num + 1S))) - Pfld1(CInt((num - 1S))))) / (2.0 * Me.m_Dx))
				num5 = CDbl((Me.Dampf / 2F))
				Vfld(CInt(num)) = CSng(((CDbl(Vfld1(CInt(num))) * (1.0 / Me.m_Dt - num3 - num5) - num4 + 32.17399978637695) / (1.0 / Me.m_Dt + num3 + num5)))
				num += -1S
			End While
			num = 0S
			num2 = CDbl((Me.m_FluidDens * (1F + Comp * (Pfld1(CInt(num)) - Me.Po))))
			num3 = CDbl((Vfld1(CInt((num + 1S))) - Vfld1(CInt(num)))) / (2.0 * Me.m_Dx)
			num4 = 32.17399978637695 / num2 * (CDbl((Pfld1(CInt((num + 1S))) - Pfld1(CInt(num)))) / Me.m_Dx)
			num5 = CDbl((Me.Dampf / 2F))
			Vfld(CInt(num)) = CSng(((CDbl(Vfld1(CInt(num))) * (1.0 / Me.m_Dt - num3 - num5) - num4 + 32.17399978637695) / (1.0 / Me.m_Dt + num3 + num5)))
			Pfld(0) = Me.Ptb
			Dim num6 As Short = 1S
			Dim num7 As Short = Me.m_nelem - 1S
			Dim num8 As Double
			Dim num9 As Double
			Dim num10 As Double
			Dim num11 As Double
			num = num6
			While num <= num7
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a checked-expression
				num8 = CDbl((Vfld(CInt((num + 1S))) - Vfld(CInt((num - 1S))))) / (2.0 * Me.m_Dx)
				num9 = CDbl((1F / Comp + Pfld1(CInt(num)) / 2F - Me.Po))
				num10 = CDbl(((Vfld(CInt(num)) + Vfld1(CInt(num))) / 2F))
				num11 = CDbl((Pfld1(CInt((num + 1S))) - Pfld1(CInt((num - 1S))))) / (2.0 * Me.m_Dx)
				Pfld(CInt(num)) = CSng(((CDbl(Pfld1(CInt(num))) / Me.m_Dt - num9 * num8 - num10 * num11) / (1.0 / Me.m_Dt + num8 / 2.0)))
				num += 1S
			End While
			num = Me.m_nelem
			num8 = CDbl((Vfld(CInt(num)) - Vfld(CInt((num - 1S))))) / Me.m_Dx
			num9 = CDbl((1F / Comp + Pfld1(CInt(num)) / 2F - Me.Po))
			num10 = CDbl(((Vfld(CInt(num)) + Vfld1(CInt(num))) / 2F))
			num11 = CDbl((Pfld1(CInt(num)) - Pfld1(CInt((num - 1S))))) / Me.m_Dx
			Pfld(CInt(num)) = CSng(((CDbl(Pfld1(CInt(num))) / Me.m_Dt - num9 * num8 - num10 * num11) / (1.0 / Me.m_Dt + num8 / 2.0)))
			Dim num12 As Single = CSng((CDbl((Me.m_FluidDens * (Me.m_PumpDepth - Me.m_FluidLevel))) + (CDbl(Me.m_CasingPressure) + 14.7) * 144.0))
			Me.Fluidloadd = Me.ApumpMod * (Pfld(CInt(Me.m_nelem)) - num12) / 144F - Me.PcAdj * Me.m_Apump + Me.m_PumpLoadAdj
			Dim num13 As Short = 0S
			Dim nelem As Short = Me.m_nelem
			num = num13
			While num <= nelem
				Vfld1(CInt(num)) = Vfld(CInt(num))
				Pfld1(CInt(num)) = Pfld(CInt(num))
				num += 1S
			End While
		End Sub

		Private Function acs(X As Single) As Double
			Dim result As Double
			If X >= 1F Then
				result = 0.0
			ElseIf X <= -1F Then
				result = 3.141592653589793
			Else
				result = 1.5707963267948966 - Math.Atan(CDbl(X) / Math.Sqrt(CDbl((1F - X * X))))
			End If
			Return result
		End Function

		Private Function asn(X As Single) As Double
			Dim result As Double
			If Math.Abs(X) >= 1F Then
				result = 1.5707963267948966 * CDbl(Math.Sign(X))
			Else
				result = Math.Atan(CDbl(X) / Math.Sqrt(CDbl((1F - X * X))))
			End If
			Return result
		End Function

		Private Sub CalcDamping()
			Dim num As Single = RSWIN_DESC.rst.SPM * Me.m_PU_KinematicStroke / 360F
			Dim num2 As Single
			If RSWIN_DESC.rst.bHasFGlass And RSWIN_DESC.rst.SPM >= 10F And Me.m_PumpDepth >= 6000F Then
				If CDbl(num) < 1.274 Then
					num2 = 0.5F
				Else
					num2 = CSng((0.3447 + 0.12187 * CDbl(num)))
					num2 = Conversions.ToSingle(Me.Min(num2, 0.85))
				End If
			Else
				Dim num3 As Single
				If CDbl(num) > 2.5 Then
					num3 = 0.15F
				Else
					num3 = CSng((0.17789 * Math.Pow(CDbl(num), -0.89166)))
				End If
				num2 = CSng((3.141592653589793 * Me.m_Speemax * CDbl(num3) / CDbl((2F * Me.m_PumpDepth))))
				If Me.m_PumpDepth < 1500F Then
					num2 /= 2F
				ElseIf Me.m_PumpDepth < 2500F Then
					num2 = CSng((CDbl(num2) / 1.75))
				ElseIf Me.m_PumpDepth < 3500F Then
					num2 = CSng((CDbl(num2) / 1.25))
				ElseIf Me.m_PumpDepth < 4500F Then
					num2 = CSng((CDbl(num2) / 1.125))
				End If
				If RSWIN_DESC.rst.bHasRR Then
					num2 = Conversions.ToSingle(Me.Min(RuntimeHelpers.GetObjectValue(Me.Max(num2, 0.5)), 1.35))
				Else
					num2 = Conversions.ToSingle(Me.Min(RuntimeHelpers.GetObjectValue(Me.Max(num2, 0.5)), 2F))
				End If
			End If
			Me.m_UpstrokeFriction = num2
			Me.m_DownstrokeFriction = num2
			If RSWIN_DESC.rst.bHasFGlass And Not RSWIN_DESC.rst.bHasRR Then
				Dim flag As Boolean = False
				Dim num4 As Short = 1S
				Dim numRods As Short = Me.m_NumRods
				For num5 As Short = num4 To numRods
					' The following expression was wrapped in a checked-expression
					If flag Then
						' The following expression was wrapped in a checked-expression
						If Me.IsSteel(CShort(Me.Sections(CInt(num5)).Grade)) And CDbl(Me.Sections(CInt(num5)).Diameter) > 1.62 And Me.Sections(CInt(num5)).Length > 1000F Then
							Me.m_UpstrokeFriction /= 2F
							Me.m_DownstrokeFriction = CSng((CDbl(Me.m_DownstrokeFriction) * 1.5))
							Exit For
						End If
					ElseIf Me.IsFG(CShort(Me.Sections(CInt(num5)).Grade)) Then
						flag = True
					End If
				Next
			End If
			Me.m_UpstrokeFriction *= Me.m_UpstrokeFrictionFactor
			Me.m_DownstrokeFriction *= Me.m_DownstrokeFrictionFactor
			Me.m_UpstrokeFriction = Conversion.Int(Me.m_UpstrokeFriction * 100F) / 100F
			Me.m_DownstrokeFriction = Conversion.Int(Me.m_DownstrokeFriction * 100F) / 100F
		End Sub

		Private Function IsCrankBalanced(PU_UnitType As cJPred.EPumpingUnitType) As Boolean
			Return PU_UnitType <> cJPred.EPumpingUnitType.PUT_AirBalanced And PU_UnitType <> cJPred.EPumpingUnitType.PUT_LONGSTROKE And PU_UnitType <> cJPred.EPumpingUnitType.PUT_BeamBalanced And PU_UnitType <> cJPred.EPumpingUnitType.PUT_Hydraulic
		End Function

		Private Function IsFG(RodGrade As Short) As Boolean
			Return(RodGrade >= 16384S And RodGrade < 20480S) Or (RodGrade >= 20480S And RodGrade < 24576S)
		End Function

		Private Function IsSteel(RodGrade As Short) As Boolean
			Return(RodGrade >= 4096S And RodGrade < 8192S) Or (RodGrade >= 8192S And RodGrade < 12288S)
		End Function

		Private Sub Kinematics(Theta As Single, SPM As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Velocity As Single, Optional iTime As Integer = 0)
			If Me.m_PU_UnitType = 7S Then
				Me.KinRota(Theta, SPM, Prp, Tf, Velocity)
				Return
			End If
			If Me.m_PU_UnitType = 10S Then
				Me.Kinematic_Hydraulic(Theta, SPM, Prp, Tf, Velocity, iTime)
				Return
			End If
			If Me.m_PU_UnitType = 9S Then
				Me.Kinematic_BeltLowProfile(Theta, SPM, Prp, Tf, Velocity, iTime)
				Return
			End If
			Me.kinematics1(Theta, SPM, Prp, Tf, Velocity, iTime)
		End Sub

		Private Sub kinematics1(Theta As Single, SPM As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Velocity As Single, iTime As Integer)
			Dim num As Single
			If Me.m_PU_UnitType = 5S Then
				num = Theta
			ElseIf Me.m_PU_CrankRotation = 1S Then
				num = Theta
			Else
				num = 6.2831855F - Theta
			End If
			Dim num2 As Single
			Select Case Me.m_PU_UnitType
				Case 5S
					num2 = CSng((3.141592653589793 - CDbl(num) + CDbl(Me.Alph)))
				Case 6S
					num2 = CSng((3.141592653589793 + CDbl(num) + CDbl(Me.Alph)))
				Case Else
					num2 = 6.2831855F - num + Me.Alph
			End Select
			If num2 < 0F Then
				num2 += 6.2831855F
			End If
			If num2 >= 6.2831855F Then
				num2 -= 6.2831855F
			End If
			Dim num3 As Single = CSng(Math.Sqrt(CDbl((Me.XKsqr + Me.XRsqr)) - CDbl(Me.TwoKR) * Math.Cos(CDbl(num2))))
			Dim num4 As Single = num3 * num3
			Dim num5 As Single = Me.TwoC * num3
			Dim num6 As Short
			If CDbl(num2) < 3.141592653589793 Then
				num6 = 1S
			Else
				num6 = -1S
			End If
			Dim num7 As Single = CSng((Me.acs((num4 + Me.XKsqr - Me.XRsqr) / (Me.TwoK * num3)) * CDbl(num6)))
			Dim num8 As Single = CSng((Me.acs((Me.XCsqr + num4 - Me.XPsqr) / num5) + CDbl(num7)))
			Dim num9 As Single = CSng((Me.acs((Me.XPsqr + num4 - Me.XCsqr) / (Me.TwoP * num3)) - CDbl(num7)))
			Dim num10 As Single = CSng((Me.acs((Me.XPsqr - Me.XCsqr - num4) / num5) - CDbl(num7)))
			Tf = CSng((CDbl((CSng((-Me.m_PU_CrankRotation)) * Me.ARoverC)) * Math.Sin(CDbl((num9 - num2))) / Math.Sin(CDbl((num9 - num10)))))
			Dim num11 As Single
			Select Case Me.m_PU_UnitType
				Case 5S, 6S
					num11 = (Me.Psit - num8) / -Me.Dpsi
				Case Else
					num11 = (Me.Psib - num8) / Me.Dpsi
			End Select
			Prp = Me.StrokeFeet * num11
			Dim num12 As Double = CDbl(Me.m_PU_CrankRotation) * 3.141592653589793 * CDbl(Me.m_SPM) / 30.0
			Velocity = CSng((CDbl((CSng(Me.m_PU_CrankRotation) * Tf)) * num12 / 12.0))
		End Sub

		Private Sub Kinematic_Hydraulic(Theta As Single, SPM0 As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Velocity As Single, iTimeStep As Integer)
			Dim num As Single
			If RSWIN_DESC.rst.PU.MaxStroke <> 0F Then
				num = RSWIN_DESC.rst.PU.SprocketDistance - (RSWIN_DESC.rst.PU.MaxStroke - RSWIN_DESC.rst.AdjustedStrokeLength)
			Else
				num = RSWIN_DESC.rst.PU.SprocketDistance
			End If
			Dim flag As Boolean = True
			Dim flag2 As Boolean = True
			Dim num2 As Double = CDbl((Me.Srad * SPM0 / 60F))
			Dim num3 As Single
			Dim num4 As Single
			Dim num5 As Single
			If Theta >= 0F And Theta < Me.ThA Then
				num3 = Theta
				If Me.m_PU_P >= 1F Then
					Tf = CSng((CDbl((-CDbl(Me.m_PU_SprocketRadius))) * (Math.Sin(CDbl(num3)) + Math.Cos(CDbl(num3)) * Math.Tan(CDbl(Me.GammaL)))))
				Else
					Tf = CSng((CDbl((-CDbl(Me.m_PU_SprocketRadius))) * Math.Sin(CDbl(num3))))
				End If
				flag = True
				flag2 = True
			ElseIf Theta >= Me.ThA And Theta <= Me.ThB Then
				Tf = -Me.m_PU_SprocketRadius
				num4 = CSng((CDbl(Me.Xwa) - CDbl(Me.m_PU_SprocketRadius) * (CDbl(Theta) - 1.5707963267948966)))
				num5 = CSng((CDbl(Tf) * num2))
				flag = False
			ElseIf Theta > Me.ThB And Theta < Me.ThC Then
				num3 = Theta - Me.Thetat
				If Me.m_PU_P >= 1F Then
					Tf = CSng((CDbl((-CDbl(Me.m_PU_SprocketRadius))) * (Math.Sin(CDbl(num3)) + Math.Cos(CDbl(num3)) * Math.Tan(CDbl(Me.GammaL)))))
				Else
					Tf = CSng((CDbl((-CDbl(Me.m_PU_SprocketRadius))) * Math.Sin(CDbl(num3))))
				End If
				flag = True
				flag2 = False
			ElseIf Theta >= Me.ThC And Theta < Me.ThD Then
				Tf = Me.m_PU_SprocketRadius
				num4 = CSng((CDbl(Me.Xwb) + CDbl(Me.m_PU_SprocketRadius) * (CDbl((Theta - Me.Thetat)) - 4.71238898038469)))
				num5 = CSng((CDbl(Tf) * num2))
				flag = False
			ElseIf Theta >= Me.ThD And Theta <= Me.Srad Then
				num3 = Theta - 2F * Me.Thetat
				If Me.m_PU_P >= 1F Then
					Tf = CSng((CDbl((-CDbl(Me.m_PU_SprocketRadius))) * (Math.Sin(CDbl(num3)) + Math.Cos(CDbl(num3)) * Math.Tan(CDbl(Me.GammaL)))))
				Else
					Tf = CSng((CDbl((-CDbl(Me.m_PU_SprocketRadius))) * Math.Sin(CDbl(num3))))
				End If
				flag = True
				flag2 = True
			End If
			If flag Then
				If Me.m_PU_P < 1F Then
					num4 = CSng((CDbl(Me.m_PU_SprocketRadius) * Math.Cos(CDbl(num3))))
					If flag2 Then
						num4 += num
					End If
					num5 = CSng((CDbl(Tf) * num2))
				Else
					Me.GammaL = CSng(Me.asn(CSng((CDbl(Me.m_PU_SprocketRadius) * Math.Sin(CDbl(num3)) / CDbl(Me.m_PU_P)))))
					num4 = CSng((CDbl(Me.m_PU_SprocketRadius) * Math.Cos(CDbl(num3)) + CDbl(Me.m_PU_P) * Math.Cos(CDbl(Me.GammaL))))
					If flag2 Then
						num4 += num
					End If
					num5 = CSng((CDbl(Tf) * num2))
				End If
			End If
			Tf = -Tf
			Prp = (Me.Xwtop - num4) / Me.m_PU_KinematicStroke * Me.StrokeFeet
			Velocity = -num5 / 12F
		End Sub

		Private Sub KinRota(Theta As Single, SPM0 As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Velocity As Single)
			Dim flag As Boolean = True
			Dim flag2 As Boolean = True
			Dim num As Double = CDbl((Me.Srad * SPM0 / 60F))
			Dim num2 As Single
			Dim num3 As Single
			Dim num4 As Single
			If Theta >= 0F And Theta < Me.ThA Then
				num2 = Theta
				If Me.m_PU_P >= 1F Then
					Tf = CSng((CDbl((-CDbl(Me.m_PU_SprocketRadius))) * (Math.Sin(CDbl(num2)) + Math.Cos(CDbl(num2)) * Math.Tan(CDbl(Me.GammaL)))))
				Else
					Tf = CSng((CDbl((-CDbl(Me.m_PU_SprocketRadius))) * Math.Sin(CDbl(num2))))
				End If
				flag = True
				flag2 = True
			ElseIf Theta >= Me.ThA And Theta <= Me.ThB Then
				Tf = -Me.m_PU_SprocketRadius
				num3 = CSng((CDbl(Me.Xwa) - CDbl(Me.m_PU_SprocketRadius) * (CDbl(Theta) - 1.5707963267948966)))
				num4 = CSng((CDbl(Tf) * num))
				flag = False
			ElseIf Theta > Me.ThB And Theta < Me.ThC Then
				num2 = Theta - Me.Thetat
				If Me.m_PU_P >= 1F Then
					Tf = CSng((CDbl((-CDbl(Me.m_PU_SprocketRadius))) * (Math.Sin(CDbl(num2)) + Math.Cos(CDbl(num2)) * Math.Tan(CDbl(Me.GammaL)))))
				Else
					Tf = CSng((CDbl((-CDbl(Me.m_PU_SprocketRadius))) * Math.Sin(CDbl(num2))))
				End If
				flag = True
				flag2 = False
			ElseIf Theta >= Me.ThC And Theta < Me.ThD Then
				Tf = Me.m_PU_SprocketRadius
				num3 = CSng((CDbl(Me.Xwb) + CDbl(Me.m_PU_SprocketRadius) * (CDbl((Theta - Me.Thetat)) - 4.71238898038469)))
				num4 = CSng((CDbl(Tf) * num))
				flag = False
			ElseIf Theta >= Me.ThD And Theta <= Me.Srad Then
				num2 = Theta - 2F * Me.Thetat
				If Me.m_PU_P >= 1F Then
					Tf = CSng((CDbl((-CDbl(Me.m_PU_SprocketRadius))) * (Math.Sin(CDbl(num2)) + Math.Cos(CDbl(num2)) * Math.Tan(CDbl(Me.GammaL)))))
				Else
					Tf = CSng((CDbl((-CDbl(Me.m_PU_SprocketRadius))) * Math.Sin(CDbl(num2))))
				End If
				flag = True
				flag2 = True
			End If
			If flag Then
				If Me.m_PU_P < 1F Then
					num3 = CSng((CDbl(Me.m_PU_SprocketRadius) * Math.Cos(CDbl(num2))))
					If flag2 Then
						num3 += Me.m_PU_SprocketDistance
					End If
					num4 = CSng((CDbl(Tf) * num))
				Else
					Me.GammaL = CSng(Me.asn(CSng((CDbl(Me.m_PU_SprocketRadius) * Math.Sin(CDbl(num2)) / CDbl(Me.m_PU_P)))))
					num3 = CSng((CDbl(Me.m_PU_SprocketRadius) * Math.Cos(CDbl(num2)) + CDbl(Me.m_PU_P) * Math.Cos(CDbl(Me.GammaL))))
					If flag2 Then
						num3 += Me.m_PU_SprocketDistance
					End If
					num4 = CSng((CDbl(Tf) * num))
				End If
			End If
			Tf = -Tf
			Prp = (Me.Xwtop - num3) / Me.m_PU_KinematicStroke * Me.StrokeFeet
			Velocity = -num4 / 12F
		End Sub

		Private Function Max(V1 As Object, v2 As Object) As Object
			Return RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectGreater(V1, v2, False), RuntimeHelpers.GetObjectValue(V1), RuntimeHelpers.GetObjectValue(v2)))
		End Function

		Private Sub Maxmin(ByRef rgArray As Single(), ByRef maxpp As Single, ByRef minpp As Single, ByRef maxppos As Short, ByRef minppos As Short, Ntsteps As Short)
			maxppos = 1S
			minppos = 1S
			For num As Short = 2S To Ntsteps
				If rgArray(CInt(num)) > rgArray(CInt(maxppos)) Then
					maxppos = num
				End If
				If rgArray(CInt(num)) < rgArray(CInt(minppos)) Then
					minppos = num
				End If
			Next
			maxpp = rgArray(CInt(maxppos))
			minpp = rgArray(CInt(minppos))
		End Sub

		Private Function MaxTorque(ByRef rgThetac As Single(), ByRef rgTnetB As Single(), newM As Single) As Single
			Dim num As Single = CSng(Math.Abs(CDbl(rgTnetB(1)) - CDbl((newM - Me.m_M_BalancedT)) * Math.Sin(CDbl((rgThetac(1) + Me.m_PU_CrankOffset)))))
			Dim num2 As Short = 1S
			Dim ntsteps As Short = Me.m_Ntsteps
			For num3 As Short = num2 To ntsteps
				num = Conversions.ToSingle(Me.Max(num, Math.Abs(CDbl(rgTnetB(CInt(num3))) - CDbl((newM - Me.m_M_BalancedT)) * Math.Sin(CDbl((rgThetac(CInt(num3)) + Me.m_PU_CrankOffset))))))
			Next
			Return num
		End Function

		Private Function Min(V1 As Object, v2 As Object) As Object
			Return RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectLess(V1, v2, False), RuntimeHelpers.GetObjectValue(V1), RuntimeHelpers.GetObjectValue(v2)))
		End Function

		Private Sub NjpredBalance(ByRef rgThetac As Single(), ByRef rgTnetB As Single())
			Dim num2 As Single
			If Me.m_PU_UnitType = 9S Then
				Dim num As Single = CSng(Math.Sqrt(Math.Pow(CDbl(Me.m_PU_K), 2.0) - Math.Pow(CDbl(Me.m_PU_I), 2.0)))
				Dim pu_C As Single = Me.m_PU_C
				num2 = CSng((1.5707963267948966 - Math.Tan(CDbl(((num + pu_C / 2F) / Me.m_PU_I)))))
			End If
			Dim num3 As Single
			Dim num4 As Single
			Select Case Me.m_PU_UnitType
				Case 6S
					num3 = 25F
					num4 = 1000F
					GoTo IL_C1
				Case 7S, 10S
					num3 = 500F
					num4 = 100000F
					GoTo IL_C1
				Case 8S
					num3 = 100F
					num4 = 50000F
					GoTo IL_C1
			End Select
			num3 = 1000F
			num4 = 8000000F
			IL_C1:
			Dim num5 As Single = num3 + 0.381966F * (num4 - num3)
			Dim num6 As Single = num3
			Dim num7 As Single = num5
			Dim num8 As Single = num5 + 0.381966F * (num4 - num5)
			Dim num9 As Single = num4
			Dim num10 As Single = Me.MaxTorque(rgThetac, rgTnetB, num7)
			Dim num11 As Single = Me.MaxTorque(rgThetac, rgTnetB, num8)
			While Math.Abs(num9 - num6) > 1E-05F * (Math.Abs(num7) + Math.Abs(num8))
				If num11 < num10 Then
					num6 = num7
					num7 = num8
					num8 = num7 + 0.381966F * (num9 - num7)
					num10 = num11
					num11 = Me.MaxTorque(rgThetac, rgTnetB, num8)
				Else
					num9 = num8
					num8 = num7
					num7 = num6 + 0.381966F * (num8 - num6)
					num11 = num10
					num10 = Me.MaxTorque(rgThetac, rgTnetB, num7)
				End If
			End While
			Dim num12 As Single
			If num10 < num11 Then
				num12 = num7
			Else
				num12 = num8
			End If
			Dim num13 As Short = 1S
			Dim ntsteps As Short = Me.m_Ntsteps
			For num14 As Short = num13 To ntsteps
				Dim num15 As Single
				If Me.m_PU_UnitType = 9S Then
					num15 = CSng((CDbl((num12 - Me.m_M_BalancedT)) * Math.Sin(CDbl((rgThetac(CInt(num14)) + Me.m_PU_CrankOffset + num2)))))
				Else
					num15 = CSng((CDbl((num12 - Me.m_M_BalancedT)) * Math.Sin(CDbl((rgThetac(CInt(num14)) + Me.m_PU_CrankOffset)))))
				End If
				rgTnetB(CInt(num14)) = rgTnetB(CInt(num14)) - num15
			Next
			If Me.m_PU_UnitType = 6S Then
				Me.m_M_BalancedT = CSng((CDbl(num12) - 14.696))
				Return
			End If
			Me.m_M_BalancedT = num12
		End Sub

		Private Sub Predict()
			Dim array As Single() = New Single(20) {}
			If Me.m_PU_UnitType = 10S Then
				Me.PercentUpstrokeSPM = RSWIN_DESC.rst.PercentUpstrokeSPM / 100F * 2F
				Me.PercentDownstrokeSPM = RSWIN_DESC.rst.PercentDownstrokeSPM / 100F * 2F
			End If
			Dim num As Short = 0S
			Me.m_Ncycles = 0S
			Me.ApumpMod = 0F
			Me.Atub = 0.0
			Me.Dampf = 0F
			Me.Fluidloadd = 0F
			Dim num2 As Single = 0F
			Dim num3 As Single = 0F
			Me.PcAdj = 0F
			Me.Po = 0F
			Dim num4 As Single = 0F
			Me.Ptb = 0F
			Dim num5 As Single = 0F
			Dim num6 As Single = 0F
			Dim num7 As Single = 0F
			Dim num8 As Single = 0F
			Dim num9 As Single = 0F
			Dim num10 As Short = 0S
			Do
				array(CInt(num10)) = 0F
				num10 += 1S
			Loop While num10 <= 20S
			Dim num11 As Double = 0.0
			Dim num12 As Double = 0.0
			Dim num13 As Double = 0.0
			Dim num14 As Double = 0.0
			array(0) = 0F
			Dim num15 As Short = 1S
			Dim numRods As Short = Me.m_NumRods
			num10 = num15
			While num10 <= numRods
				' The following expression was wrapped in a checked-expression
				array(CInt(num10)) = array(CInt((num10 - 1S))) + Me.Sections(CInt(num10)).Length
				num10 += 1S
			End While
			If Me.m_PU_UnitType = 10S And RSWIN_DESC.rst.NtstepsUpstroke <> 0S Then
				' The following expression was wrapped in a checked-expression
				If num <= RSWIN_DESC.rst.NtstepsUpstroke - 1S Then
					Me.m_SPM = RSWIN_DESC.rst.SPM * Me.PercentUpstrokeSPM
				Else
					Me.m_SPM = RSWIN_DESC.rst.SPM * Me.PercentDownstrokeSPM
				End If
			Else
				Me.m_SPM = RSWIN_DESC.rst.SPM
			End If
			Dim num16 As Double = 3.141592653589793 * CDbl(Me.m_SPM) / 30.0
			Dim num17 As Short = 0S
			Dim nelem As Short = Me.m_nelem
			num10 = num17
			While num10 <= nelem
				Me.Pfld(CInt(num10)) = 0F
				Me.Pfld1(CInt(num10)) = 0F
				Me.Vfld(CInt(num10)) = 0F
				Me.Vfld1(CInt(num10)) = 0F
				num10 += 1S
			End While
			If Me.m_Ncycles = 0S Then
				Me.m_Ncycles = 3S
				If Me.m_IncludeFluidInertia Or Me.m_IndPumpOp = 2S Then
					Me.m_Ncycles = 4S
				End If
				If Not Me.m_SteelRodString And (Me.m_IndPumpOp = 1S Or Me.m_IndPumpOp = 3S) Then
					Me.m_Ncycles = 4S
				End If
			End If
			Dim num18 As Short = Me.m_nelem - 1S
			Dim num19 As Single = 0F
			Me.ApumpMod = Me.m_Apump
			If Not Me.m_IncludeFluidInertia And (Me.m_IndPumpOp = 0S Or Me.m_IndPumpOp = 2S) And Me.m_PumpDepth < 1500F Then
				Me.ApumpMod = CSng((CDbl(Me.m_Apump) * 0.925))
				num19 = Me.m_PumpDepth / 15F
			End If
			If Me.m_IncludeFluidInertia And (Me.m_IndPumpOp = 0S Or Me.m_IndPumpOp = 2S) Then
				Me.ApumpMod = Me.m_Apump * Me.m_Peff
			End If
			num19 -= Me.m_PumpFriction
			If Me.m_CalcFriction Then
				Me.CalcDamping()
				If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso (Not RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff > 1F) Then
					Me.m_UpstrokeFriction *= RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff
					Me.m_DownstrokeFriction *= RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff
				End If
			End If
			If Me.m_IncludeFluidInertia Then
				Me.Dampf = 1F
				Me.Atub = 3.141592653589793 * CDbl((Me.m_TubingID * Me.m_TubingID)) / 4.0
				Me.Po = 14.7F
				num11 = 1E-06 * CDbl(Me.m_CompressibilityIndex)
				num11 /= 144.0
				Me.Po *= 144F
				Me.Ptb = CSng(((CDbl(Me.m_TubingPressure) + 14.7) * 144.0))
			End If
			Dim num20 As Single = CSng(((0.433 * CDbl(Me.m_FluidSPGR) * CDbl(Me.m_PumpDepth) + CDbl(Me.m_TubingPressure) + 14.7) * CDbl(Me.ApumpMod)))
			Dim num21 As Single = Me.m_dflnu / 12F
			Me.PcAdj = 0F
			If Me.m_IndPumpOp = 1S Or Me.m_IndPumpOp = 3S Then
				If CDbl(Me.m_PlungerSize) >= 2.5 Then
					Me.PcAdj = 125F
				ElseIf CDbl(Me.m_Pumpfill) >= 0.7 Then
					Dim num22 As Single = 1.25F
					Dim num23 As Single = Me.m_Pumpfill * Me.m_Pumpfill
					Dim num24 As Single = num23 * Me.m_Pumpfill
					Dim num25 As Single = CSng((CDbl(num22) * (CDbl(num20) * 0.03 + 14.7 - 17018.0 + 65357.0 * CDbl(Me.m_Pumpfill) - 83500.0 * CDbl(num23) + 35556.0 * CDbl(num24))))
					If CDbl(Me.m_Pumpfill) < 0.8 Then
						num25 = CSng((CDbl(num25) * 0.75))
					End If
					If Me.m_Pintake < num25 Then
						Me.PcAdj = num25 - Me.m_Pintake
					End If
					If Me.m_IndPumpOp = 3S Then
						If Me.m_TubStretch > 3F Then
							Me.PcAdj = CSng((CDbl(Me.PcAdj) * 1.5))
						End If
						If CDbl(Me.m_Pumpfill) > 0.9 Then
							Me.PcAdj += Me.m_dflnu * 20F * Me.m_Pumpfill
						End If
					End If
					Me.PcAdj = Conversions.ToSingle(Me.Min(Me.PcAdj, 200))
				End If
				If Me.PcAdj + Me.m_CasingPressure < 50F Then
					Me.PcAdj = 50F - Me.m_CasingPressure
				End If
			End If
			Me.m_Pintake += Me.PcAdj
			Dim num26 As Single = Me.m_PU_KinematicStroke * Me.ApumpMod * (1F - Me.m_Pumpfill) * Me.m_Pintake / 12F
			Me.Fluidloadd = Me.m_FluidLoad - Me.PcAdj * Me.ApumpMod
			If Me.m_IndPumpOp <> 1S And Me.m_IndPumpOp <> 3S Then
				Me.Fluidloadd += Me.m_PumpLoadAdj
			End If
			Dim num27 As Short = 1S
			Dim num28 As Short = 1S
			Dim nelem2 As Short = Me.m_nelem
			num10 = num28
			While num10 <= nelem2
				If Me.m_Dx * CDbl(num10) <= CDbl((array(CInt(num27)) + 2F)) Then
					Me.A(CInt(num10)) = Me.Sections(CInt(num27)).Elasticity * Me.Sections(CInt(num27)).Area
					Me.B(CInt(num10)) = Me.Sections(CInt(num27)).RodWeight / 32.174F
				Else
					' The following expression was wrapped in a checked-expression
					Dim num29 As Double = (CDbl(array(CInt(num27))) - Me.m_Dx * CDbl((num10 - 1S))) / Me.m_Dx
					Me.A(CInt(num10)) = CSng((num29 / CDbl((Me.Sections(CInt(num27)).Elasticity * Me.Sections(CInt(num27)).Area))))
					Me.B(CInt(num10)) = CSng((num29 * CDbl(Me.Sections(CInt(num27)).RodWeight) / 32.17399978637695))
					While True
						' The following expression was wrapped in a checked-statement
						num27 += 1S
						If Me.m_Dx * CDbl(num10) <= CDbl((array(CInt(num27)) + 2F)) Then
							Exit For
						End If
						num29 = CDbl((array(CInt(num27)) - array(CInt((num27 - 1S))))) / Me.m_Dx
						Me.A(CInt(num10)) = CSng((CDbl(Me.A(CInt(num10))) + num29 / CDbl((Me.Sections(CInt(num27)).Elasticity * Me.Sections(CInt(num27)).Area))))
						Me.B(CInt(num10)) = CSng((CDbl(Me.B(CInt(num10))) + num29 * CDbl(Me.Sections(CInt(num27)).RodWeight) / 32.17399978637695))
					End While
					num29 = (Me.m_Dx * CDbl(num10) - CDbl(array(CInt((num27 - 1S))))) / Me.m_Dx
					Me.A(CInt(num10)) = CSng((CDbl(Me.A(CInt(num10))) + num29 / CDbl((Me.Sections(CInt(num27)).Elasticity * Me.Sections(CInt(num27)).Area))))
					Me.B(CInt(num10)) = CSng((CDbl(Me.B(CInt(num10))) + num29 * CDbl(Me.Sections(CInt(num27)).RodWeight) / 32.17399978637695))
					Me.A(CInt(num10)) = 1F / Me.A(CInt(num10))
				End If
				Me.Cup(CInt(num10)) = Me.B(CInt(num10)) * Me.m_UpstrokeFriction / 2F
				Me.Cdown(CInt(num10)) = Me.B(CInt(num10)) * Me.m_DownstrokeFriction / 2F
				num10 += 1S
			End While
			Dim num30 As Short = 1S
			Dim num31 As Short = Me.m_nelem - 1S
			num10 = num30
			While num10 <= num31
				' The following expression was wrapped in a checked-expression
				Me.AP(CInt(num10)) = (Me.A(CInt((num10 + 1S))) + Me.A(CInt(num10))) / 4F
				Me.BP(CInt(num10)) = Me.B(CInt((num10 + 1S))) + Me.B(CInt(num10))
				Me.CPup(CInt(num10)) = Me.Cup(CInt((num10 + 1S))) + Me.Cup(CInt(num10))
				Me.CPdown(CInt(num10)) = Me.Cdown(CInt((num10 + 1S))) + Me.Cdown(CInt(num10))
				num10 += 1S
			End While
			Me.Pp(0) = 0F
			Dim num32 As Short = 0S
			Dim nelem3 As Short = Me.m_nelem
			num10 = num32
			While num10 <= nelem3
				Me.V(CInt(num10)) = 0F
				Me.V1(CInt(num10)) = 0F
				Me.F(CInt(num10)) = 0F
				Me.F1(CInt(num10)) = 0F
				num10 += 1S
			End While
			If Me.m_IncludeFluidInertia Then
				Me.Pfld1(0) = Me.Ptb
				Dim num33 As Short = 0S
				Dim num34 As Short = Me.m_nelem - 1S
				num10 = num33
				While num10 <= num34
					' The following expression was wrapped in a checked-expression
					Me.Pfld1(CInt((num10 + 1S))) = CSng((CDbl(Me.Pfld1(CInt(num10))) + CDbl(Me.m_FluidDens) * Me.m_Dx))
					Me.Vfld1(CInt(num10)) = 0F
					num10 += 1S
				End While
				Me.Vfld(1) = 0F
			End If
			Dim num35 As Single = Me.m_TotalTheta / CSng(Me.m_Ntsteps)
			Dim flag As Boolean = False
			Dim num36 As Short = 0S
			While True
				IL_BD2:
				Dim num37 As Short = 0S
				Dim num38 As Short = 1S
				Dim ncycles As Short = Me.m_Ncycles
				Dim num39 As Short = num38
				IL_1A33:
				While num39 <= ncycles
					Dim num40 As Single = 0F
					Dim num41 As Single = 0F
					num = 0S
					num37 += 1S
					While num <> Me.m_Ntsteps
						If num41 + num35 / 2F > Me.m_TotalTheta Then
							IL_1A2C:
							num39 += 1S
							GoTo IL_1A33
						End If
						num += 1S
						If Me.m_PU_UnitType = 10S And RSWIN_DESC.rst.NtstepsUpstroke <> 0S Then
							' The following expression was wrapped in a checked-expression
							If num <= RSWIN_DESC.rst.NtstepsUpstroke - 1S Then
								Me.m_SPM = RSWIN_DESC.rst.SPM * Me.PercentUpstrokeSPM
							Else
								Me.m_SPM = RSWIN_DESC.rst.SPM * Me.PercentDownstrokeSPM
							End If
							num16 = 3.141592653589793 * CDbl(Me.m_SPM) / 30.0
						End If
						num41 = CSng(num) * num35
						If flag Then
							' The following expression was wrapped in a checked-expression
							Me.m_Dt = CDbl((num35 * 2F / (Me.OMG1(CInt(num)) + Me.OMG1(CInt((num - 1S))))))
						End If
						num40 = CSng((CDbl(num40) + Me.m_Dt))
						Me.m_Speemax = Me.m_Dx / Me.m_Dt
						Dim theta As Single = num41
						Dim spm As Single = Me.m_SPM
						Dim num42 As Single = CSng(num12)
						Me.Kinematics(theta, spm, num4, num9, num42, CInt(num))
						num12 = CDbl(num42)
						Me.m_Thetac(CInt(num)) = num41
						Me.m_SurfPos(CInt(num)) = num4 * 12F
						Me.V(0) = CSng(num12)
						Me.m_prvel(CInt(num)) = CSng(num12)
						If flag Then
							Me.V(0) = CSng((CDbl((Me.V(0) * Me.OMG1(CInt(num)))) / num16))
							Me.m_Tf(CInt(num)) = Me.V(0) * 12F / Me.OMG1(CInt(num))
						Else
							Me.m_Tf(CInt(num)) = num9
						End If
						Dim num43 As Short = 1S
						Dim num44 As Short = Me.m_nelem - 1S
						num10 = num43
						While num10 <= num44
							Dim num45 As Double
							If Me.V(CInt(num10)) >= 0F Then
								num45 = CDbl(Me.CPup(CInt(num10)))
							Else
								num45 = CDbl(Me.CPdown(CInt(num10)))
							End If
							Me.V(CInt(num10)) = CSng((((CDbl(Me.BP(CInt(num10))) - num45 * Me.m_Dt) * CDbl(Me.V1(CInt(num10))) + CDbl((Me.F1(CInt((num10 - 1S))) - Me.F1(CInt((num10 + 1S))))) / Me.m_Speemax) / (CDbl(Me.BP(CInt(num10))) + num45 * Me.m_Dt)))
							num10 += 1S
						End While
						While True
							If num36 <> 1S Then
								GoTo IL_1025
							End If
							Me.V(CInt(Me.m_nelem)) = Me.V1(CInt(Me.m_nelem))
							Me.F(CInt(Me.m_nelem)) = Me.F1(CInt(Me.m_nelem))
							Dim num46 As Short = 0S
							Dim num47 As Single = 0.01F
							Do
								Dim num48 As Double = CDbl((Me.V(CInt(Me.m_nelem)) * 0.05F + Me.V1(CInt(Me.m_nelem)) * 0.95F))
								Dim num49 As Double = CDbl((Me.F(CInt(Me.m_nelem)) * 0.05F + Me.F1(CInt(Me.m_nelem)) * 0.95F))
								Dim num50 As Double = CDbl(Me.F1(CInt(Me.m_nelem))) + num48 * Math.Pow(CDbl(num20) - num49, 2.0) * Me.m_Dt / CDbl(num26)
								Dim num51 As Single
								If num14 > 0.0 Then
									num51 = Me.Cup(CInt(Me.m_nelem))
								Else
									num51 = Me.Cdown(CInt(Me.m_nelem))
								End If
								num14 = ((CDbl(Me.B(CInt(Me.m_nelem))) - CDbl(num51) * Me.m_Dt) * CDbl(Me.V1(CInt(Me.m_nelem))) - (num50 - CDbl(Me.F1(CInt(num18)))) / Me.m_Speemax) / (CDbl(Me.B(CInt(Me.m_nelem))) + CDbl(num51) * Me.m_Dt)
								Dim num52 As Double = Math.Abs((num50 - CDbl(Me.F(CInt(Me.m_nelem)))) / num50)
								Dim num53 As Double = Math.Abs((num14 - CDbl(Me.V(CInt(Me.m_nelem)))) / num14)
								Me.V(CInt(Me.m_nelem)) = CSng(num14)
								Me.F(CInt(Me.m_nelem)) = CSng(num50)
								num46 += 1S
								If num46 > 10S Then
									num47 *= 2F
								End If
								If num52 < CDbl(num47) And num53 < CDbl(num47) Then
									Exit Do
								End If
							Loop While num46 <= 1000S
							IL_11A9:
							If Me.F(CInt(Me.m_nelem)) > Me.Fluidloadd Then
								GoTo Block_46
							End If
							If Me.F(CInt(Me.m_nelem)) <= num19 Then
								GoTo Block_47
							End If
							If Not(num36 = 0S And num39 > 2S) Then
								Exit For
							End If
							If Me.m_IndPumpOp = 1S And Me.F(CInt(Me.m_nelem)) < Me.F1(CInt(Me.m_nelem)) And CDbl(num) > CDbl(Me.m_Ntsteps) / 3.0 And CDbl(num) < 0.8 * CDbl(Me.m_Ntsteps) Then
								num36 = 1S
								Continue For
							End If
							If Me.m_IndPumpOp = 2S Then
								num36 = 2S
							Else
								If Me.m_IndPumpOp = 3S And Me.F(CInt(Me.m_nelem)) < Me.F1(CInt(Me.m_nelem)) And CDbl(num) > CDbl(Me.m_Ntsteps) / 3.0 And CDbl(num) < 0.8 * CDbl(Me.m_Ntsteps) Then
									num36 = 1S
									Continue For
								End If
								If Me.m_IndPumpOp <> 3S Then
									Exit For
								End If
								num36 = 2S
							End If
							IL_1025:
							If num36 = 2S Then
								Me.V(CInt(Me.m_nelem)) = CSng((((CDbl(Me.B(CInt(Me.m_nelem))) - CDbl(Me.Cup(CInt(Me.m_nelem))) * Me.m_Dt) * CDbl(Me.V1(CInt(Me.m_nelem))) - (CDbl((Me.F1(CInt(Me.m_nelem)) - Me.F1(CInt(num18)))) + CDbl(Me.Fluidloadd) * Me.m_Dt * CDbl(Me.V1(CInt(Me.m_nelem))) / 2.0 / CDbl(num21)) / Me.m_Speemax) / (CDbl(Me.B(CInt(Me.m_nelem))) + CDbl(Me.Cup(CInt(Me.m_nelem))) * Me.m_Dt + CDbl(Me.Fluidloadd) * Me.m_Dt / 2.0 / CDbl(num21) / Me.m_Speemax)))
								Me.F(CInt(Me.m_nelem)) = CSng((CDbl(Me.F1(CInt(Me.m_nelem))) + CDbl(Me.Fluidloadd) * Me.m_Dt * CDbl((Me.V(CInt(Me.m_nelem)) + Me.V1(CInt(Me.m_nelem)))) / 2.0 / CDbl(num21)))
								GoTo IL_11A9
							End If
							Me.F(CInt(Me.m_nelem)) = CSng((CDbl(Me.F1(CInt(Me.m_nelem))) + CDbl((Me.A(CInt(Me.m_nelem)) * Me.V(CInt(num18)))) / Me.m_Speemax))
							Me.V(CInt(Me.m_nelem)) = 0F
							GoTo IL_11A9
						End While
						IL_1401:
						Me.F(0) = CSng((CDbl(Me.F1(0)) + CDbl((Me.A(1) * (Me.V(0) - Me.V(1)))) / Me.m_Speemax))
						If flag Then
							If Me.IsCrankBalanced(CType(Me.m_PU_UnitType, cJPred.EPumpingUnitType)) Then
								Dim num54 As Single = Me.m_Tf(CInt(num)) * (Me.F(0) + Me.m_WrodsInFluid - Me.m_PU_Unbalance)
								Dim num55 As Single = CSng((CDbl(Me.m_M_BalancedT) * Math.Sin(CDbl((num41 + Me.m_PU_CrankOffset)))))
								Dim num56 As Single = CSng((CDbl((12F * (Me.m_Irot / 32.174F))) * (num16 * CDbl((1F + Me.m_MotorSPV * num5 / (num6 - num7))) - CDbl(Me.OMG1(CInt(num)))) / Me.m_Dt))
								Dim num57 As Single
								If Me.m_Iart = 0F Then
									num57 = 0F
								Else
									num57 = CSng((CDbl((144F * Me.m_Tf(CInt(num)) * (Me.m_Iart / 32.174F) / Me.m_Iart)) * (CDbl(Me.V(0)) - num13) / Me.m_Dt / CDbl(Me.m_Iart)))
								End If
								Dim num58 As Single = CSng((1.0 + CDbl((12F * (Me.m_Irot / 32.174F))) / Me.m_Dt * num16 * CDbl(Me.m_MotorSPV) / CDbl((num6 - num7))))
								Me.m_TnetB(CInt(num)) = (num54 - num55 + num56 + num57) / num58
							End If
							Me.OMG1(CInt((num + 1S))) = CSng((num16 * CDbl((1F - Me.m_MotorSPV * (Me.m_TnetB(CInt(num)) - num5) / (num6 - num7)))))
							num13 = CDbl(Me.V(0))
							If num = Me.m_Ntsteps Then
								Me.OMG1(0) = Me.OMG1(CInt(num))
								Me.OMG1(1) = Me.OMG1(CInt((num + 1S)))
								Me.m_TnetB(1) = Me.get_TnetB(CInt(Me.m_Ntsteps))
							End If
						End If
						Dim num59 As Short = 1S
						Dim num60 As Short = Me.m_nelem - 1S
						num10 = num59
						While num10 <= num60
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							Me.F(CInt(num10)) = CSng((CDbl(Me.F1(CInt(num10))) + CDbl((Me.AP(CInt(num10)) * (Me.V(CInt((num10 - 1S))) - Me.V(CInt((num10 + 1S)))))) / Me.m_Speemax))
							num10 += 1S
						End While
						If Me.m_IncludeFluidInertia Then
							Me.AddFluidInertiaLoad(CSng(num11), Me.V, Me.Vfld, Me.Vfld1, Me.Pfld, Me.Pfld1)
						End If
						Dim num61 As Short = 0S
						Dim nelem4 As Short = Me.m_nelem
						num10 = num61
						While num10 <= nelem4
							Me.V1(CInt(num10)) = Me.V(CInt(num10))
							Me.F1(CInt(num10)) = Me.F(CInt(num10))
							num10 += 1S
						End While
						If(Me.m_IndPumpOp = 1S Or Me.m_IndPumpOp = 3S) And num39 = 1S Then
							' The following expression was wrapped in a checked-expression
							Me.Pp(CInt(num)) = CSng((CDbl((6F * (Me.V(CInt(Me.m_nelem)) + Me.V1(CInt(Me.m_nelem))))) * Me.m_Dt + CDbl(Me.Pp(CInt((num - 1S))))))
						End If
						If num39 = Me.m_Ncycles Then
							Dim num62 As Single
							If num <= 1S Then
								num62 = 0F
							Else
								' The following expression was wrapped in a checked-expression
								num62 = Me.m_PumpPos(CInt((num - 1S)))
							End If
							Me.m_SurfPos(CInt(num)) = Conversions.ToSingle(Me.Max(Me.m_SurfPos(CInt(num)), 0))
							Me.m_PumpPos(CInt(num)) = CSng((CDbl((6F * (Me.V(CInt(Me.m_nelem)) + Me.V1(CInt(Me.m_nelem))))) * Me.m_Dt + CDbl(num62)))
							If Me.V(0) > 0F Then
								Me.m_SurfLoad(CInt(num)) = CSng((CDbl((Me.F(0) + Me.m_WrodsInFluid + Me.m_StuffingBoxFriction)) - CDbl(RSWIN_DESC.rst.TubingPressure) * Math.Pow(CDbl(RSWIN_DESC.rst.PR_Diameter), 2.0) * 3.141592653589793 / 4.0))
							Else
								Me.m_SurfLoad(CInt(num)) = CSng((CDbl((Me.F(0) + Me.m_WrodsInFluid - Me.m_StuffingBoxFriction)) - CDbl(RSWIN_DESC.rst.TubingPressure) * Math.Pow(CDbl(RSWIN_DESC.rst.PR_Diameter), 2.0) * 3.141592653589793 / 4.0))
							End If
							Me.m_PumpLoad(CInt(num)) = Me.F(CInt(Me.m_nelem))
							Me.TimeW(CInt(num)) = num40
							If Not flag Then
								Me.Torque1(Me.m_SurfPos(CInt(num)), Me.m_SurfLoad(CInt(num)), Me.m_Tf(CInt(num)), Me.m_Thetac(CInt(num)), Me.m_M_BalancedT, num8, CSng(num))
								Me.m_TnetB(CInt(num)) = num8
							End If
							Continue While
						End If
						Continue While
						Block_46:
						Me.F(CInt(Me.m_nelem)) = Me.Fluidloadd
						Me.V(CInt(Me.m_nelem)) = CSng((((CDbl(Me.B(CInt(Me.m_nelem))) - CDbl(Me.Cup(CInt(Me.m_nelem))) * Me.m_Dt) * CDbl(Me.V1(CInt(Me.m_nelem))) - CDbl((Me.F(CInt(Me.m_nelem)) - Me.F(CInt(num18)))) / Me.m_Speemax) / (CDbl(Me.B(CInt(Me.m_nelem))) + CDbl(Me.Cup(CInt(Me.m_nelem))) * Me.m_Dt)))
						num36 = 0S
						GoTo IL_1401
						Block_47:
						Me.F(CInt(Me.m_nelem)) = num19
						Me.V(CInt(Me.m_nelem)) = CSng((((CDbl(Me.B(CInt(Me.m_nelem))) - CDbl(Me.Cup(CInt(Me.m_nelem))) * Me.m_Dt) * CDbl(Me.V1(CInt(Me.m_nelem))) + CDbl((Me.F(CInt(num18)) - Me.F(CInt(Me.m_nelem)))) / Me.m_Speemax) / (CDbl(Me.B(CInt(Me.m_nelem))) + CDbl(Me.Cup(CInt(Me.m_nelem))) * Me.m_Dt)))
						num36 = 0S
						GoTo IL_1401
					End While
					If Me.m_MotorSPV > 0F And (flag Or num39 = Me.m_Ncycles) Then
						If Me.IsCrankBalanced(CType(Me.m_PU_UnitType, cJPred.EPumpingUnitType)) Then
							Me.NjpredBalance(Me.m_Thetac, Me.m_TnetB)
						End If
						num6 = Me.m_TnetB(1)
						num7 = Me.m_TnetB(1)
						Dim num63 As Short = 1S
						Dim ntsteps As Short = Me.m_Ntsteps
						num10 = num63
						While num10 <= ntsteps
							num6 = Conversions.ToSingle(Me.Max(num6, Me.m_TnetB(CInt(num10))))
							num7 = Conversions.ToSingle(Me.Min(num7, Me.m_TnetB(CInt(num10))))
							num10 += 1S
						End While
						num5 = (num6 + num7) / 2F
						If Me.m_MotorSPV > 0F And Not flag Then
							flag = True
							Me.OMG1(1) = CSng(num16)
							Me.OMG1(0) = CSng(num16)
							num13 = CDbl(Me.V(0))
							GoTo IL_BD2
						End If
					End If
					If num39 = 1S And (Me.m_IndPumpOp = 1S Or Me.m_IndPumpOp = 3S) Then
						Dim num64 As Short = 0S
						Dim num65 As Short = 0S
						Me.Maxmin(Me.Pp, num2, num3, num64, num65, Me.m_Ntsteps)
						Dim num66 As Single = num2 - num3
						num26 = num66 * Me.m_Apump * (1F - Me.m_Pumpfill) * Me.m_Pintake / 12F
						GoTo IL_1A2C
					End If
					GoTo IL_1A2C
				End While
				Exit For
			End While
			Me.m_SurfLoad(1) = Me.m_SurfLoad(CInt(Me.m_Ntsteps))
			Me.m_PumpLoad(1) = Me.m_PumpLoad(CInt(Me.m_Ntsteps))
			Me.m_SurfPos(1) = Me.m_SurfPos(CInt(Me.m_Ntsteps))
			Me.m_PumpPos(1) = Me.m_PumpPos(CInt(Me.m_Ntsteps))
			If Me.IsCrankBalanced(CType(Me.m_PU_UnitType, cJPred.EPumpingUnitType)) And Me.m_M_Existing <> 0F Then
				Dim num67 As Short = 1S
				Dim ntsteps2 As Short = Me.m_Ntsteps
				num10 = num67
				While num10 <= ntsteps2
					Me.m_TnetE(CInt(num10)) = CSng((CDbl(Me.m_TnetB(CInt(num10))) - CDbl((Me.m_M_Existing - Me.m_M_BalancedT)) * Math.Sin(CDbl((Me.m_Thetac(CInt(num10)) + Me.m_PU_CrankOffset)))))
					num10 += 1S
				End While
				Return
			End If
		End Sub

		Private Sub Torque1(Prpos As Single, Prload As Single, Tf As Single, m_Thetac As Single, CB As Single, ByRef Tnet As Single, iTime As Single)
			Select Case Me.m_PU_UnitType
				Case 6S
					Dim num As Single = CSng((CDbl(CB) + 14.696))
					Dim num2 As Single = Me.m_PU_V0 + Me.m_PU_M * Prpos / 1728F
					Dim num3 As Single = CSng((CDbl(num) / Math.Pow(CDbl((num2 / Me.m_PU_V0)), 1.33) - 14.696))
					Tnet = Tf * (Prload - Me.m_PU_M * (num3 - Me.m_PU_S))
					Return
				Case 7S, 10S
					Tnet = Tf * (Prload * Me.m_PU_DrumDiamRatio - CB)
					Return
				Case 9S
					Dim pu_C As Single = Me.m_PU_C
					Dim num4 As Single = CSng(Math.Sqrt(Math.Pow(CDbl(Me.m_PU_K), 2.0) - Math.Pow(CDbl(Me.m_PU_I), 2.0)))
					Tnet = CSng((CDbl((Tf * Prload)) - CDbl(CB) * Math.Sin(CDbl((m_Thetac + Me.m_PU_CrankOffset)) + 1.5707963267948966 - Math.Tan(CDbl(((num4 + pu_C / 2F) / Me.m_PU_I))))))
					Return
			End Select
			Tnet = CSng((CDbl((Tf * (Prload - Me.m_PU_Unbalance))) - CDbl(CB) * Math.Sin(CDbl((m_Thetac + Me.m_PU_CrankOffset)))))
		End Sub

		Private Sub ClassInitialize()
		End Sub

		Public Sub New()
			Me.Sections = New cJPred.RodSection(20) {}
			Me.ClassInitialize()
		End Sub

		Private Sub Authenticate(dw1 As Integer, dw2 As Integer, dw3 As Integer, dw4 As Integer)
		End Sub

		Public Sub JPred()
			Me.Predict()
		End Sub

		Public Sub Kinconst()
			If Me.m_PU_UnitType = 7S Or Me.m_PU_UnitType = 10S Then
				Dim num As Single
				If Me.m_PU_UnitType = 7S Then
					num = Me.m_PU_SprocketDistance
				ElseIf Me.m_PU_UnitType = 10S Then
					If RSWIN_DESC.rst.PU.MaxStroke <> 0F Then
						num = Me.m_PU_SprocketDistance - (RSWIN_DESC.rst.PU.MaxStroke - RSWIN_DESC.rst.AdjustedStrokeLength)
					Else
						num = Me.m_PU_SprocketDistance
					End If
				End If
				Me.Xwtop = Me.m_PU_SprocketRadius + Me.m_PU_P + num
				Me.Xwbot = Me.m_PU_P - Me.m_PU_SprocketRadius
				If Me.m_PU_P < 1F Then
					Me.Xwa = num
				Else
					Me.GammaL = CSng(Me.asn(Me.m_PU_SprocketRadius / Me.m_PU_P))
					Me.Xwa = CSng((CDbl(Me.m_PU_P) * Math.Cos(CDbl(Me.GammaL)) + CDbl(num)))
				End If
				Me.Xwb = Me.Xwa - num
				Me.Thetat = num / Me.m_PU_SprocketRadius
				Me.Srad = CSng((CDbl((2F * Me.Thetat)) + 6.283185307179586))
				Me.ThA = 1.5707964F
				Me.ThB = CSng((1.5707963267948966 + CDbl(Me.Thetat)))
				Me.ThC = CSng((1.5707963267948966 + CDbl(Me.Thetat) + 3.141592653589793))
				Me.ThD = CSng((1.5707963267948966 + CDbl(Me.Thetat) + 3.141592653589793 + CDbl(Me.Thetat)))
				Me.m_PU_KinematicStroke = num + 2F * Me.m_PU_SprocketRadius
				Me.m_TotalTheta = Me.Srad
			Else
				Me.XCsqr = Me.m_PU_C * Me.m_PU_C
				Me.XKsqr = Me.m_PU_K * Me.m_PU_K
				Me.XPsqr = Me.m_PU_P * Me.m_PU_P
				Me.XRsqr = Me.m_PU_R * Me.m_PU_R
				Me.XKR = Me.m_PU_K * Me.m_PU_R
				Me.TwoC = 2F * Me.m_PU_C
				Me.TwoCK = 2F * Me.m_PU_C * Me.m_PU_K
				Me.TwoK = 2F * Me.m_PU_K
				Me.TwoKR = 2F * Me.XKR
				Me.TwoP = 2F * Me.m_PU_P
				If Me.m_PU_UnitType <> 9S Then
					Me.ARoverC = Me.m_PU_A * Me.m_PU_R / Me.m_PU_C
				Else
					Me.ARoverC = 0F
				End If
				Me.Alph = CSng(Me.asn(Me.m_PU_I / Me.m_PU_K))
				Me.Psib = CSng(Me.acs(CSng(((CDbl((Me.XCsqr + Me.XKsqr)) - Math.Pow(CDbl((Me.m_PU_P + Me.m_PU_R)), 2.0)) / CDbl(Me.TwoCK)))))
				Me.Psit = CSng(Me.acs(CSng(((CDbl((Me.XCsqr + Me.XKsqr)) - Math.Pow(CDbl((Me.m_PU_P - Me.m_PU_R)), 2.0)) / CDbl(Me.TwoCK)))))
				Me.Dpsi = Me.Psib - Me.Psit
				Me.m_TotalTheta = 6.2831855F
				If Me.m_PU_UnitType = 9S Then
					Me.m_PU_KinematicStroke = Me.m_PU_R * 2F
				Else
					Me.m_PU_KinematicStroke = Me.m_PU_A * Me.Dpsi
				End If
			End If
			Me.StrokeFeet = Me.m_PU_KinematicStroke / 12F
			RSWIN_DESC.rst.StrokeFeet = Me.StrokeFeet
		End Sub

		Public Sub JPred_Kinematics(Theta As Single, SPM As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Velocity As Single)
			Me.Kinematics(Theta, SPM, Prp, Tf, Velocity, 0)
		End Sub

		Public Sub Kinematic_BeltLowProfile(Theta As Single, SPM As Single, ByRef Prp As Single, ByRef Tf As Single, ByRef Velocity As Single, iTime As Integer)
			Try
				Dim num As Single = CSng((CDbl(RSWIN_DESC.rst.SPM) * 3.141592653589793 / 30.0))
				Dim pu_C As Single = Me.m_PU_C
				Dim pu_I As Single = Me.m_PU_I
				Dim pu_K As Single = Me.m_PU_K
				Dim pu_R As Single = Me.m_PU_R
				Dim num2 As Single = CSng((Math.Sin(Math.Acos(CDbl((pu_I / pu_K)))) * CDbl(pu_K)))
				Dim num3 As Single = pu_K + pu_R
				Dim num4 As Single = pu_K - pu_R
				Me.Dpsi = Math.Abs(num4 - num3)
				Dim num5 As Single = 2F * pu_R
				Me.m_PU_KinematicStroke = num5
				Dim num6 As Single = num2 + pu_C / 2F
				Dim num7 As Single = CSng(Math.Atan(CDbl((num6 / pu_I))))
				If num7 < 0F Then
					num7 = Math.Abs(num7)
				End If
				Dim num8 As Single
				If Me.m_PU_CrankRotation = 1S Then
					num8 = Theta
				Else
					num8 = CSng((6.283185307179586 - CDbl(Theta)))
				End If
				Dim num9 As Single = CSng((1.5707963267948966 - CDbl(num7) - CDbl(num8)))
				Dim num10 As Single = CSng(Math.Sqrt(Math.Pow(CDbl(pu_K), 2.0) + Math.Pow(CDbl(pu_R), 2.0) - CDbl((2F * pu_K * pu_R)) * Math.Cos(CDbl(num8))))
				Prp = (num4 - num10) / -num5
				Dim num11 As Single = CSng(Math.Acos((Math.Pow(CDbl(num10), 2.0) + Math.Pow(CDbl(pu_R), 2.0) - Math.Pow(CDbl(pu_K), 2.0)) / CDbl((2F * num10 * pu_R))))
				Tf = CSng((CDbl(pu_R) * Math.Sin(CDbl(num11))))
				If RSWIN_DESC.rst.PU.CrankRotation = 1S Then
					If CDbl(num8) < 6.283185307179586 And CDbl(num8) > 3.141592653589793 Then
						Tf = -Tf
					End If
				ElseIf num8 > 0F And CDbl(num8) < 3.141592653589793 Then
					Tf = -Tf
				End If
				num10 = num4 + Prp * num5
				num9 = CSng(Math.Acos((Math.Pow(CDbl(pu_K), 2.0) + Math.Pow(CDbl(pu_R), 2.0) - Math.Pow(CDbl(num10), 2.0)) / CDbl((2F * pu_K * pu_R))))
				If CDbl(num8) > 3.141592653589793 And CDbl(num8) < 6.283185307179586 Then
					num9 = -num9
				End If
				Dim num12 As Single = num9
				If num12 < 0F Then
					num12 = CSng((CDbl(num12) + 6.283185307179586))
				End If
				If CDbl(num12) > 6.283185307179586 Then
					num12 = CSng((CDbl(num12) - 6.283185307179586))
				End If
				Velocity = Tf * num / 12F
				Me.StrokeFeet = Me.m_PU_KinematicStroke / 12F
				Prp = Me.StrokeFeet * Prp
			Catch ex As Exception
			End Try
		End Sub

		Private Const GravCon As Single = 32.174F

		Private Const con As Single = 4633.056F

		Private Const CR_CLOCKWISE As Short = 1S

		Private Const CR_COUNTERCLOCKWISE As Short = -1S

		Private Const MAXNTSTEPS As Short = 325S

		Private Const MAXRODSECTION As Short = 20S

		Private Const T_BalancedE As Short = 0S

		Private Const T_BalancedT As Short = 1S

		Private Const T_Existing As Short = 2S

		Private Const twopi As Single = 6.2831855F

		Private Const WaterSpWt As Single = 62.4F

		Public Const PUSORT_BYNAME As Integer = 0

		Public Const PUSORT_BYSTROKE As Integer = 1

		Public Const PUSORT_BYGEARBOX As Integer = 2

		Public Const PUSORT_MEASUREDPU As Integer = 3

		Private PercentUpstrokeSPM As Single

		Private PercentDownstrokeSPM As Single

		Private RotationInConvention As Short

		Private Alph As Single

		Private ApumpMod As Single

		Private m_ARoverC As Single

		Private Atub As Double

		Private Dampf As Single

		Private Dpsi As Single

		Private Fluidloadd As Single

		Private GammaL As Single

		Private PcAdj As Single

		Private Po As Single

		Private Psib As Single

		Private Psit As Single

		Private Ptb As Single

		Private RodStringL As Single

		Private Srad As Single

		Private StrokeFeet As Single

		Private ThA As Single

		Private ThB As Single

		Private ThC As Single

		Private ThD As Single

		Private Thetat As Single

		Private TwoC As Single

		Private TwoCK As Single

		Private TwoK As Single

		Private TwoKR As Single

		Private TwoP As Single

		Private XCsqr As Single

		Private XKR As Single

		Private XKsqr As Single

		Private XPsqr As Single

		Private XRsqr As Single

		Private Xwa As Single

		Private Xwb As Single

		Private Xwbot As Single

		Private Xwtop As Single

		Private Sections As cJPred.RodSection()

		Private Pp As Single()

		Private TimeW As Single()

		Private OMG1 As Single()

		Private V As Single()

		Private V1 As Single()

		Private F As Single()

		Private F1 As Single()

		Private A As Single()

		Private AP As Single()

		Private B As Single()

		Private BP As Single()

		Private Cup As Single()

		Private CPup As Single()

		Private Cdown As Single()

		Private CPdown As Single()

		Private Pfld As Single()

		Private Pfld1 As Single()

		Private Vfld As Single()

		Private Vfld1 As Single()

		Private m_Apump As Single

		Private m_CalcFriction As Boolean

		Private m_CasingPressure As Single

		Private m_CompressibilityIndex As Single

		Private m_dflnu As Single

		Private m_DownstrokeFriction As Single

		Private m_DownstrokeFrictionFactor As Single

		Private m_Dt As Double

		Private m_Dx As Double

		Private m_FluidDens As Single

		Private m_FluidLevel As Single

		Private m_FluidLoad As Single

		Private m_FluidSPGR As Single

		Private m_Iart As Single

		Private m_IncludeFluidInertia As Boolean

		Private m_IndPumpOp As Short

		Private m_Irot As Single

		Private m_M_BalancedT As Single

		Private m_M_Existing As Single

		Private m_MotorSPV As Single

		Private m_Ncycles As Short

		Private m_nelem As Short

		Private m_Ntsteps As Short

		Private m_NumRods As Short

		Private m_Peff As Single

		Private m_Pintake As Single

		Private m_PlungerSize As Single

		Private m_PU_A As Single

		Private m_PU_C As Single

		Private m_PU_CrankOffset As Single

		Private m_PU_CrankRotation As Short

		Private m_PU_DrumDiamRatio As Single

		Private m_PU_I As Single

		Private m_PU_K As Single

		Private m_PU_KinematicStroke As Single

		Private m_PU_M As Single

		Private m_PU_P As Single

		Private m_PU_R As Single

		Private m_PU_S As Single

		Private m_PU_SprocketDistance As Single

		Private m_PU_SprocketRadius As Single

		Private m_PU_Unbalance As Single

		Private m_PU_UnitType As Short

		Private m_PU_V0 As Single

		Private m_PumpCondition As Short

		Private m_PumpDepth As Single

		Private m_Pumpfill As Single

		Private m_PumpFriction As Single

		Private m_PumpLoadAdj As Single

		Private m_Speemax As Double

		Private m_SPM As Single

		Private m_SteelRodString As Boolean

		Private m_StuffingBoxFriction As Single

		Private m_TotalTheta As Single

		Private m_TubingID As Single

		Private m_TubingPressure As Single

		Private m_TubStretch As Single

		Private m_UpstrokeFriction As Single

		Private m_UpstrokeFrictionFactor As Single

		Private m_WrodsInFluid As Single

		Private m_SurfPos As Single()

		Private m_SurfLoad As Single()

		Private m_PumpPos As Single()

		Private m_PumpLoad As Single()

		Private m_PermLoad As Single()

		Private m_TnetB As Single()

		Private m_TnetE As Single()

		Private m_Tf As Single()

		Private m_Thetac As Single()

		Private m_prvel As Single()

		Private Enum EPumpCondition
			PC_FULLPUMP = 1
			PC_FLUIDPOUND
			PC_GASINTERFERENCE
		End Enum

		Private Enum EPumpingUnitType
			PUT_CONVENTIONAL = 1
			PUT_ENHANCED
			PUT_GROOVES
			PUT_LOWPROFILE
			PUT_MarkII
			PUT_AirBalanced
			PUT_LONGSTROKE
			PUT_BeamBalanced
			PUT_BeltLowProfile
			PUT_Hydraulic
			PUT_CombinationBeamCrank
		End Enum

		Private Structure RodSection
			Public Grade As Integer

			Public Diameter As Single

			Public Area As Single

			Public Length As Single

			Public RodWeight As Single

			Public Elasticity As Single
		End Structure
	End Class
End Namespace
