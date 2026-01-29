Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module PREDICT
		Public Function Predict(Optional bVBeltRatio As Boolean = True, Optional sCallingProc As String = "") As Boolean
			Dim num As Integer
			Dim flag2 As Boolean
			Dim num11 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				PREDICT.$STATIC$Predict$0222E$iCnt += 1
				If Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch Then
					Util.BusyCursor()
					Application.DoEvents()
				End If
				RSWIN_DESC.bCombinedTapers = False
				If RSWIN_DESC.rst.PU.UnitType = 10S And Not RSWIN_DESC.rst.UnknownM Then
					RSWIN_DESC.rst.UnknownM = True
				End If
				Application.DoEvents()
				RSWIN_DESC.bOverwriteDownstrokeValues = (RSWIN_DESC.SETUP_UseImpred <> 0S AndAlso RSWIN_DESC.bRodStarD)
				Dim flag As Boolean
				Dim num5 As Single
				Dim ntsteps As Integer
				Dim num6 As Integer
				If RSWIN_DESC.rst.PumpDepth < 1500F AndAlso RSWIN_DESC.rst.IncludeFluidInertia <> 0S AndAlso RSWIN_DESC.bOverwriteDownstrokeValues Then
					RSWIN_DESC.rst.IncludeFluidInertia = 0S
					If RSWIN_DESC.SETUP_UseImpred <> 0S AndAlso RSWIN_DESC.bRodStarD Then
						MImpred.bVBeltRatio = bVBeltRatio
						flag = MImpred.Impred()
						If RSWIN_DESC.SETUP_UseImpred <> 0S AndAlso RSWIN_DESC.bRodStarD Then
							RSWIN_DESC.Impred_NOFI = New TEImpred()
							Dim impredObj As TEImpred = MImpred.ImpredObj
							RSWIN_DESC.Impred_NOFI = impredObj
						End If
					Else
						RSWIN_DESC.SETUP_UseImpred = 0S
						MJPred.RunJPred("")
						RSWIN_DESC.rst_NOFI = New cRODSTAR()
						RSWIN_DESC.rst_NOFI = RSWIN_DESC.rst
					End If
					Dim surfPos As Single() = RSWIN_DESC.rst.SurfPos
					Dim num2 As Single = 0F
					Dim num3 As Single = 0F
					Dim num4 As Single = 0F
					Util.Maxmin(surfPos, num2, num3, num5, num4)
					ntsteps = CInt(RSWIN_DESC.rst.Ntsteps)
					num6 = CInt(Math.Round(CDbl(num5)))
					RSWIN_DESC.rst.IncludeFluidInertia = -1S
				End If
				If RSWIN_DESC.SETUP_UseImpred <> 0S AndAlso RSWIN_DESC.bRodStarD Then
					MImpred.bVBeltRatio = bVBeltRatio
					flag = MImpred.Impred()
				Else
					RSWIN_DESC.SETUP_UseImpred = 0S
					MJPred.RunJPred("")
					flag = True
				End If
				If RSWIN_DESC.rst.PumpDepth < 1500F AndAlso RSWIN_DESC.rst.IncludeFluidInertia <> 0S AndAlso RSWIN_DESC.bOverwriteDownstrokeValues Then
					Dim surfPos2 As Single() = RSWIN_DESC.rst.SurfPos
					Dim num4 As Single = 0F
					Dim num3 As Single = 0F
					Dim num2 As Single = 0F
					Util.Maxmin(surfPos2, num4, num3, num5, num2)
					Dim num7 As Integer = CInt(Math.Round(CDbl(num5)))
					If RSWIN_DESC.SETUP_UseImpred <> 0S AndAlso RSWIN_DESC.bRodStarD Then
						PREDICT.OverwriteDownstroke(num7, num6, ntsteps)
					Else
						Dim num8 As Integer = 0
						Dim num9 As Integer = num6
						Dim num10 As Integer = ntsteps - 1
						For i As Integer = num9 To num10
							RSWIN_DESC.rst.SurfPos(num7 + num8) = RSWIN_DESC.rst_NOFI.SurfPos(i)
							RSWIN_DESC.rst.SurfLoad(num7 + num8) = RSWIN_DESC.rst_NOFI.SurfLoad(i)
							RSWIN_DESC.rst.PumpPos(num7 + num8) = RSWIN_DESC.rst_NOFI.PumpPos(i)
							RSWIN_DESC.rst.PumpLoad(num7 + num8) = RSWIN_DESC.rst_NOFI.PumpLoad(i)
							RSWIN_DESC.rst.PermLoad(num7 + num8) = RSWIN_DESC.rst_NOFI.PermLoad(i)
							RSWIN_DESC.rst.Tf(num7 + num8) = RSWIN_DESC.rst_NOFI.Tf(i)
							RSWIN_DESC.rst.Thetac(num7 + num8) = RSWIN_DESC.rst_NOFI.Thetac(i)
							RSWIN_DESC.rst.prvel(num7 + num8) = RSWIN_DESC.rst_NOFI.prvel(i)
							If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And Not RSWIN_DESC.bBeamBalanced Then
								RSWIN_DESC.rst.Tnet(1, num7 + num8) = RSWIN_DESC.rst_NOFI.Tnet(1, i)
								RSWIN_DESC.rst.Tnet(2, num7 + num8) = RSWIN_DESC.rst_NOFI.Tnet(2, i)
							End If
							num8 += 1
						Next
						If CInt(RSWIN_DESC.rst.Ntsteps) <> ntsteps Or num7 <> num6 Then
							RSWIN_DESC.rst.Ntsteps = CShort((num7 + num8))
							Dim rst As cRODSTAR = RSWIN_DESC.rst
							Dim array As Single() = rst.SurfPos
							array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
							rst.SurfPos = array
							rst = RSWIN_DESC.rst
							array = rst.SurfLoad
							array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
							rst.SurfLoad = array
							rst = RSWIN_DESC.rst
							array = rst.PumpPos
							array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
							rst.PumpPos = array
							rst = RSWIN_DESC.rst
							array = rst.PumpLoad
							array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
							rst.PumpLoad = array
							rst = RSWIN_DESC.rst
							array = rst.PermLoad
							array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
							rst.PermLoad = array
							rst = RSWIN_DESC.rst
							array = rst.Tf
							array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
							rst.Tf = array
							rst = RSWIN_DESC.rst
							array = rst.Thetac
							array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
							rst.Thetac = array
							rst = RSWIN_DESC.rst
							array = rst.prvel
							array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
							rst.prvel = array
						End If
					End If
				End If
				flag2 = flag
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				IL_5F1:
				GoTo IL_638
				IL_5F3:
				num11 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_609:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num11 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_5F3
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_638:
			Dim result As Boolean = flag2
			If num11 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub OverwriteDownstroke(NtstepsUpstroke As Integer, NOFL_NtstepsUpstroke As Integer, NOFL_Ntsteps As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Single = 3.1415927F
				Dim flag As Boolean = True
				Dim impred_NOFI As TEImpred = RSWIN_DESC.Impred_NOFI
				Dim num2 As Integer = 0
				For i As Integer = NOFL_NtstepsUpstroke + 1 To NOFL_Ntsteps
					Dim timestep_data_type As TEImpred.timestep_data_type = impred_NOFI.get_t_s(i)
					RSWIN_DESC.rst.SurfPos(NtstepsUpstroke + num2) = CSng(timestep_data_type.p_r_position)
					If i < CInt(RSWIN_DESC.rst.NtstepsUpstroke) Then
						' The following expression was wrapped in a unchecked-expression
						RSWIN_DESC.rst.SurfLoad(NtstepsUpstroke + num2) = CSng((timestep_data_type.p_r_force + CDbl(RSWIN_DESC.rst.StuffingBoxFriction) - CDbl(RSWIN_DESC.rst.TubingPressure) * Math.Pow(CDbl(RSWIN_DESC.rst.PR_Diameter), 2.0) * 3.141592653589793 / 4.0))
					Else
						' The following expression was wrapped in a unchecked-expression
						RSWIN_DESC.rst.SurfLoad(NtstepsUpstroke + num2) = CSng((timestep_data_type.p_r_force - CDbl(RSWIN_DESC.rst.StuffingBoxFriction) - CDbl(RSWIN_DESC.rst.TubingPressure) * Math.Pow(CDbl(RSWIN_DESC.rst.PR_Diameter), 2.0) * 3.141592653589793 / 4.0))
					End If
					RSWIN_DESC.rst.PermLoad(NtstepsUpstroke + num2) = CSng(timestep_data_type.p_r_force_permissible)
					If RSWIN_DESC.rst.SurfLoad(NtstepsUpstroke + num2) > RSWIN_DESC.rst.Pprload Then
						RSWIN_DESC.rst.Pprload = RSWIN_DESC.rst.SurfLoad(NtstepsUpstroke + num2)
					End If
					If RSWIN_DESC.rst.SurfLoad(NtstepsUpstroke + num2) < RSWIN_DESC.rst.Mprload Then
						RSWIN_DESC.rst.Mprload = RSWIN_DESC.rst.SurfLoad(NtstepsUpstroke + num2)
					End If
					RSWIN_DESC.rst.PumpPos(NtstepsUpstroke + num2) = CSng((timestep_data_type.pump_displacement * 12.0))
					RSWIN_DESC.rst.PumpLoad(NtstepsUpstroke + num2) = CSng(timestep_data_type.pump_force)
					Dim crank_angle As Double = timestep_data_type.crank_angle
					Dim num3 As Double = 0.0
					Dim num4 As Double = 0.0
					Dim num5 As Double = 0.0
					Dim num7 As Single
					Dim num6 As Double = CDbl(num7)
					kinemat.Kinematics(crank_angle, num3, num4, num5, num6, -1, 0F)
					num7 = CSng(num6)
					RSWIN_DESC.rst.prvel(NtstepsUpstroke + num2) = num7
					RSWIN_DESC.rst.Tf(NtstepsUpstroke + num2) = CSng(timestep_data_type.torq_fact)
					RSWIN_DESC.rst.Thetac(NtstepsUpstroke + num2) = CSng(timestep_data_type.crank_angle)
					If RSWIN_DESC.rst.PU.UnitType <> 7S And RSWIN_DESC.rst.PU.UnitType <> 10S Then
						While RSWIN_DESC.rst.Thetac(NtstepsUpstroke + num2) < 0F
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							RSWIN_DESC.rst.Thetac(NtstepsUpstroke + num2) = RSWIN_DESC.rst.Thetac(NtstepsUpstroke + num2) + 2F * num
						End While
						While RSWIN_DESC.rst.Thetac(NtstepsUpstroke + num2) >= 2F * num
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							RSWIN_DESC.rst.Thetac(NtstepsUpstroke + num2) = RSWIN_DESC.rst.Thetac(NtstepsUpstroke + num2) - 2F * num
						End While
					End If
					RSWIN_DESC.rst.Tnet(2, NtstepsUpstroke + num2) = CSng((timestep_data_type.torq_crank * 12.0))
					RSWIN_DESC.rst.Tnet(1, NtstepsUpstroke + num2) = CSng((timestep_data_type.torq_crank_bal * 12.0))
					num2 += 1
				Next
				If CInt(RSWIN_DESC.rst.Ntsteps) <> NOFL_Ntsteps Or NtstepsUpstroke <> NOFL_NtstepsUpstroke Then
					RSWIN_DESC.rst.Ntsteps = CShort((NtstepsUpstroke + num2))
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim array As Single() = rst.SurfPos
					array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
					rst.SurfPos = array
					rst = RSWIN_DESC.rst
					array = rst.SurfLoad
					array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
					rst.SurfLoad = array
					rst = RSWIN_DESC.rst
					array = rst.PumpPos
					array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
					rst.PumpPos = array
					rst = RSWIN_DESC.rst
					array = rst.PumpLoad
					array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
					rst.PumpLoad = array
					rst = RSWIN_DESC.rst
					array = rst.PermLoad
					array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
					rst.PermLoad = array
					rst = RSWIN_DESC.rst
					array = rst.Tf
					array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
					rst.Tf = array
					rst = RSWIN_DESC.rst
					array = rst.Thetac
					array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
					rst.Thetac = array
					rst = RSWIN_DESC.rst
					array = rst.prvel
					array = CType(Utils.CopyArray(CType(array, Array), New Single(CInt((RSWIN_DESC.rst.Ntsteps + 1S)) - 1) {}), Single())
					rst.prvel = array
				End If
				If If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred And (If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV) And If((-If((flag > False), 1S, 0S)), 1S, 0S) <> 0S AndAlso RSWIN_DESC.rst.SurfLoad(0) <> RSWIN_DESC.rst.SurfLoad(CInt((RSWIN_DESC.rst.Ntsteps - 1S))) Then
					RSWIN_DESC.rst.SurfLoad(0) = RSWIN_DESC.rst.SurfLoad(CInt((RSWIN_DESC.rst.Ntsteps - 1S)))
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private $STATIC$Predict$0222E$iCnt As Integer
	End Module
End Namespace
