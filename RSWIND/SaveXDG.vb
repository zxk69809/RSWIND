Imports System
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module SaveXDG
		Public Sub StoreDataFile(rfn As String, ByRef bStoreOutput As Boolean, ByRef DataStored As Boolean, Optional bStoreAsText As Boolean = False)
			Dim num2 As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				DataStored = False
				IL_06:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_0E:
				num = 3
				If Not bStoreAsText Then
					GoTo IL_29
				End If
				IL_14:
				num = 4
				rfn = rfn.Replace(".xdg", ".txt")
				IL_29:
				num = 6
				If Not FILEUTIL.FileExists(rfn) Then
					GoTo IL_40
				End If
				IL_35:
				num = 7
				FileSystem.Kill(rfn)
				IL_3E:
				GoTo IL_53
				IL_40:
				num = 9
				IL_44:
				num = 10
				Information.Err().Number = 0
				IL_53:
				num = 12
				If Information.Err().Number = 0 Then
					GoTo IL_69
				End If
				IL_64:
				GoTo IL_38E
				IL_69:
				num = 14
				IL_6D:
				num = 15
				Dim num3 As Short = CShort(FileSystem.FreeFile())
				IL_78:
				num = 16
				If bStoreAsText Then
					GoTo IL_91
				End If
				IL_7F:
				num = 17
				FileSystem.FileOpen(CInt(num3), rfn, OpenMode.Binary, OpenAccess.Write, OpenShare.LockReadWrite, -1)
				IL_8F:
				GoTo IL_A4
				IL_91:
				num = 19
				IL_95:
				num = 20
				FileSystem.FileOpen(CInt(num3), rfn, OpenMode.Append, OpenAccess.[Default], OpenShare.[Default], -1)
				IL_A4:
				num = 22
				If bStoreAsText Then
					GoTo IL_CE
				End If
				IL_AB:
				num = 23
				Dim num4 As Integer = CInt(num3)
				Dim flag As Boolean
				Dim num5 As Integer = If((-If((flag > False), 1, 0)), 1, 0)
				SaveXDG.StoreInputData(num4, num5)
				flag = (num5 <> 0)
				num3 = CShort(num4)
				IL_CC:
				GoTo IL_F3
				IL_CE:
				num = 25
				IL_D2:
				num = 26
				num5 = CInt(num3)
				num4 = If((-If((flag > False), 1, 0)), 1, 0)
				SaveXDG.StoreInputDataAsText(num5, num4)
				flag = (num4 <> 0)
				num3 = CShort(num5)
				IL_F3:
				num = 28
				If Not flag Then
					GoTo IL_17D
				End If
				IL_FD:
				num = 29
				Dim flag2 As Boolean = SaveXDG.StoreOutputData(num3, bStoreOutput)
				IL_10B:
				num = 30
				If flag2 Then
					GoTo IL_17D
				End If
				IL_112:
				num = 31
				FileSystem.FileClose(New Integer() { CInt(num3) })
				IL_12A:
				num = 32
				FileSystem.Kill(rfn)
				IL_134:
				num = 33
				num3 = CShort(FileSystem.FreeFile())
				IL_13F:
				num = 34
				FileSystem.FileOpen(CInt(num3), rfn, OpenMode.Binary, OpenAccess.Write, OpenShare.LockReadWrite, -1)
				IL_14F:
				num = 35
				num5 = CInt(num3)
				num4 = If(-If((flag > False), 1, 0), 1, 0)
				SaveXDG.StoreInputData(num5, num4)
				flag = (num4 <> 0)
				num3 = CShort(num5)
				IL_170:
				num = 36
				flag2 = SaveXDG.StoreOutputData(num3, False)
				IL_17D:
				num = 39
				FileSystem.FileClose(New Integer() { CInt(num3) })
				IL_195:
				num = 40
				DataStored = (flag AndAlso flag2)
				IL_19E:
				num = 41
				If DataStored Then
					GoTo IL_1B0
				End If
				IL_1A6:
				num = 42
				FileSystem.Kill(rfn)
				IL_1B0:
				GoTo IL_38E
				IL_1B5:
				num = 46
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], Information.Err().Number - 61)
				GoTo IL_22D
				IL_1FD:
				num = 50
				Util.cErrmsg(94)
				IL_208:
				GoTo IL_38E
				IL_20D:
				num = 53
				Util.cErrmsg(95)
				IL_218:
				GoTo IL_38E
				IL_21D:
				num = 56
				Util.cErrmsg(93)
				IL_228:
				GoTo IL_38E
				IL_22D:
				num = 59
				Throw ProjectData.CreateProjectError(Information.Err().Number)
				IL_241:
				GoTo IL_38E
				IL_246:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_34A:
				GoTo IL_383
				IL_34C:
				num7 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_35F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_34C
			End Try
			IL_383:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_38E:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub StoreInputData(ByRef frn As Integer, ByRef bInputStored As Integer)
			If RSWIN_DESC.rst.PU.UnitType <> 8S And RSWIN_DESC.rst.UnknownM And RSWIN_DESC.rst.CBDataType = 1S Then
				RSWIN_DESC.rst.set_M(2, 0F)
			End If
			Dim value As Short = 24S
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			FileSystem.FilePut(frn, RSWIN_DESC.XDMagic, -1L, False)
			FileSystem.FilePut(frn, value, -1L)
			FileSystem.FilePut(frn, rst.ACompanyName.PadRight(40, " "c), -1L, False)
			FileSystem.FilePut(frn, rst.WellName.PadRight(40, " "c), -1L, False)
			FileSystem.FilePut(frn, rst.UserName.PadRight(40, " "c), -1L, False)
			FileSystem.FilePut(frn, rst.UserDate.PadRight(40, " "c), -1L, False)
			FileSystem.FilePut(frn, rst.PumpDepth, -1L)
			FileSystem.FilePut(frn, rst.FluidLevel, -1L)
			FileSystem.FilePut(frn, rst.SPM, -1L)
			FileSystem.FilePut(frn, rst.Runtime, -1L)
			FileSystem.FilePut(frn, rst.TargetBFPD, -1L)
			FileSystem.FilePut(frn, rst.DynaSource, -1L)
			FileSystem.FilePut(frn, rst.DynaFile.PadRight(128, " "c), -1L, False)
			Dim num As Short
			Dim numRods As Short
			FILEIO.PutString(CShort(frn), rst.DynoDate)
			FileSystem.FilePut(frn, rst.LeutertDynamometer, -1L)
			FILEIO.PutString(CShort(frn), rst.LeutertModel)
			FileSystem.FilePut(frn, rst.LeutertSpring, -1L)
			FileSystem.FilePut(frn, rst.LeutertScale, -1L)
			FileSystem.FilePut(frn, rst.MeasuredStroke, -1L)
			FileSystem.FilePut(frn, rst.PumpType, -1L)
			FileSystem.FilePut(frn, rst.PlungerSize, -1L)
			FileSystem.FilePut(frn, rst.WaterCut, -1L)
			FileSystem.FilePut(frn, rst.WaterSPGR, -1L)
			FileSystem.FilePut(frn, rst.OilAPI, -1L)
			FileSystem.FilePut(frn, rst.FluidSPGR, -1L)
			FileSystem.FilePut(frn, rst.Friction, -1L)
			FileSystem.FilePut(frn, rst.TubingOD, -1L)
			FileSystem.FilePut(frn, rst.TubingID, -1L)
			FileSystem.FilePut(frn, rst.TubingAnchored, -1L)
			FileSystem.FilePut(frn, rst.TubingAnchorDepth, -1L)
			FileSystem.FilePut(frn, rst.TubingPressure, -1L)
			FileSystem.FilePut(frn, rst.CasingPressure, -1L)
			FileSystem.FilePut(frn, rst.NumRods, -1L)
			num = 1S
			numRods = rst.NumRods
			For num2 As Short = num To numRods
				FileSystem.FilePut(frn, rst.Sections(CInt(num2)).Grade, -1L)
				FileSystem.FilePut(frn, rst.Sections(CInt(num2)).Diameter, -1L)
				FileSystem.FilePut(frn, rst.Sections(CInt(num2)).length, -1L)
				FileSystem.FilePut(frn, rst.Sections(CInt(num2)).SuckerRodLength, -1L)
				FileSystem.FilePut(frn, rst.Sections(CInt(num2)).RodDensity, -1L)
				FileSystem.FilePut(frn, rst.Sections(CInt(num2)).RodWeight, -1L)
				FileSystem.FilePut(frn, rst.Sections(CInt(num2)).Elasticity, -1L)
				FileSystem.FilePut(frn, rst.Sections(CInt(num2)).Area, -1L)
				FileSystem.FilePut(frn, rst.Sections(CInt(num2)).RodType.PadRight(20, " "c).Substring(0, 20), -1L, False)
				FileSystem.FilePut(frn, rst.Sections(CInt(num2)).TensileStrength, -1L)
			Next
			FileSystem.FilePut(frn, rst.ServiceFactor, -1L)
			FileSystem.FilePut(frn, rst.UnitID.PadRight(10, " "c), -1L, False)
			FileSystem.FilePut(frn, rst.IDEntered, -1L)
			FileSystem.FilePut(frn, rst.PU.Manuf.PadRight(40, " "c).Substring(0, 40), -1L, False)
			FileSystem.FilePut(frn, rst.PU.UnitName.PadRight(40, " "c).Substring(0, 40), -1L, False)
			FileSystem.FilePut(frn, rst.PU.APIDesignation.PadRight(40, " "c).Substring(0, 40), -1L, False)
			FileSystem.FilePut(frn, rst.PU.UnitType, -1L)
			FileSystem.FilePut(frn, rst.PU.RequiredRotation, -1L)
			FileSystem.FilePut(frn, rst.PU.CrankRotation, -1L)
			FileSystem.FilePut(frn, rst.PU.CrankHole, -1L)
			FileSystem.FilePut(frn, rst.PU.CrankHoles, -1L)
			FileSystem.FilePut(frn, rst.PU.CrankRadii(0), -1L)
			FileSystem.FilePut(frn, rst.PU.CrankRadii(1), -1L)
			FileSystem.FilePut(frn, rst.PU.CrankRadii(2), -1L)
			FileSystem.FilePut(frn, rst.PU.CrankRadii(3), -1L)
			FileSystem.FilePut(frn, rst.PU.CrankRadii(4), -1L)
			FileSystem.FilePut(frn, rst.PU.Strokes(0), -1L)
			FileSystem.FilePut(frn, rst.PU.Strokes(1), -1L)
			FileSystem.FilePut(frn, rst.PU.Strokes(2), -1L)
			FileSystem.FilePut(frn, rst.PU.Strokes(3), -1L)
			FileSystem.FilePut(frn, rst.PU.Strokes(4), -1L)
			FileSystem.FilePut(frn, rst.PU.KinematicStroke, -1L)
			FileSystem.FilePut(frn, rst.PU.R, -1L)
			FileSystem.FilePut(frn, rst.PU.A, -1L)
			FileSystem.FilePut(frn, rst.PU.C, -1L)
			FileSystem.FilePut(frn, rst.PU.I, -1L)
			FileSystem.FilePut(frn, rst.PU.K, -1L)
			FileSystem.FilePut(frn, rst.PU.P, -1L)
			FileSystem.FilePut(frn, rst.PU.M, -1L)
			FileSystem.FilePut(frn, rst.PU.S, -1L)
			FileSystem.FilePut(frn, rst.PU.V0, -1L)
			FileSystem.FilePut(frn, rst.PU.DrumDiamRatio, -1L)
			FileSystem.FilePut(frn, rst.PU.SprocketRadius, -1L)
			FileSystem.FilePut(frn, rst.PU.SprocketDistance, -1L)
			FileSystem.FilePut(frn, rst.PU.Unbalance, -1L)
			FileSystem.FilePut(frn, rst.PU.CrankOffset, -1L)
			FileSystem.FilePut(frn, rst.PU.StructRating, -1L)
			FileSystem.FilePut(frn, rst.PU.GearboxRating, -1L)
			FileSystem.FilePut(frn, rst.PU.MaxStroke, -1L)
			FileSystem.FilePut(frn, rst.PU.ArtInertia, -1L)
			Dim num3 As Short
			Dim num4 As Short
			FILEIO.PutString(CShort(frn), rst.PU.OtherInfo.PadRight(40, " "c).Substring(0, 40))
			FileSystem.FilePut(frn, rst.ElectricityCost, -1L)
			FileSystem.FilePut(frn, rst.PowerMeterType, -1L)
			FileSystem.FilePut(frn, rst.CalcMotorSize, -1L)
			FileSystem.FilePut(frn, rst.CBDataType, -1L)
			FileSystem.FilePut(frn, rst.CBEffect, -1L)
			FileSystem.FilePut(frn, rst.CBAngle, -1L)
			FileSystem.FilePut(frn, rst.get_M(2), -1L)
			FILEIO.PutString(CShort(frn), rst.CBDataFile)
			FileSystem.FilePut(frn, rst.dNtsteps, -1L)
			num3 = 0S
			num4 = rst.dNtsteps - 1S
			For num2 As Short = num3 To num4
				FileSystem.FilePut(frn, rst.dSurfPos(CInt(num2)), -1L)
				FileSystem.FilePut(frn, rst.dSurfLoad(CInt(num2)), -1L)
			Next
			Dim num7 As Short
			Dim num8 As Short
			Dim flag As Boolean
			Dim value2 As Single
			Dim value3 As Single
			Dim value4 As Single
			Dim value5 As Single
			Dim value6 As Single
			Dim num6 As Short
			If rst.gbOutputLoaded Then
				If RSWIN_DESC.gSysDiag.bSurfaceMatchPoor <> 0S Then
					rst.PumpCondition = 1S
				ElseIf RSWIN_DESC.gSysDiag.bFullPump <> 0S Then
					rst.PumpCondition = 1S
				ElseIf RSWIN_DESC.gSysDiag.bFluidPound <> 0S Then
					rst.PumpCondition = 2S
				Else
					rst.PumpCondition = 3S
				End If
				flag = (RSWIN_DESC.gSysDiag.bFluidInertia <> 0S)
				value2 = Conversions.ToSingle(Interaction.IIf(rst.CBDataType = 1S And rst.UnknownM, 0, rst.get_M(2)))
				value3 = RSWIN_DESC.gSysDiag.PumpFillage
				value4 = Conversions.ToSingle(Interaction.IIf((rst.ULineSettingsChanged And rst.ULinesSetH) <> 0S, rst.UFeetFromSurface, rst.XDFeetFromSurface))
				Dim ufluidLoad As Single = Conversions.ToSingle(Interaction.IIf((rst.ULineSettingsChanged And rst.ULinesSetH) <> 0S, rst.UFluidLoad, rst.XDFluidLoad))
				Dim num5 As Single = Conversions.ToSingle(Interaction.IIf(flag And Strings.Len(Strings.Trim(rst.gclsUpstroke(1).Pattern)) = 0, rst.PumpEfficiency, 85))
				If Not rst.TubingAnchored <> 0S Then
					value5 = 0F
				ElseIf RSWIN_DESC.gSysDiag.iTVLeak = 1073741824 Then
					value5 = Conversions.ToSingle(Interaction.IIf(rst.TubingAnchored <> 0S, rst.TubingAnchorDepth, 0))
				ElseIf RODUTIL.FreeTubing(ufluidLoad, RSWIN_DESC.gSysDiag.TubingMovement) >= rst.PumpDepth / 2F Then
					value5 = 0F
				Else
					' The following expression was wrapped in a unchecked-expression
					value5 = rst.PumpDepth - RODUTIL.FreeTubing(ufluidLoad, RSWIN_DESC.gSysDiag.TubingMovement)
				End If
				value6 = 0F
				num6 = 0S
				num6 = num6 Or 1S * -RSWIN_DESC.gSysDiag.bMeasuredStrokeCorrected
				num6 = num6 Or 2S * -(RSWIN_DESC.gSysDiag.bSurfPosKinematicCorrected And If((-If(((rst.giDynoCorrectKinematic = 0S) > False), 1S, 0S)), 1S, 0S))
				num6 = num6 Or 4S * -If((-If(((RSWIN_DESC.gSysDiag.iAdjustPhase <> 0S And RSWIN_DESC.gSysDiag.PhaseAdjustment <> 0F And rst.giDynoCorrectPhase = 0S) > False), 1S, 0S)), 1S, 0S)
				num6 = num6 Or 8S * -If((-If(((rst.gfDynoLoadAdjustment <> 0F) > False), 1S, 0S)), 1S, 0S)
				num6 = num6 Or 16S * -RSWIN_DESC.gSysDiag.bLoadShiftCorrected
				num6 = num6 Or 32S * -RSWIN_DESC.gSysDiag.bClamponLoadCell
				num6 = num6 Or 64S * -If((-If(((rst.giDynoCorrectPhase = 2S Or rst.giDynoCorrectPhase = 3S) > False), 1S, 0S)), 1S, 0S)
				num6 = num6 Or 128S * -If((-If(((rst.giDynoCorrectKinematic = 2S) > False), 1S, 0S)), 1S, 0S)
			Else
				flag = False
				rst.PumpCondition = -1S
				rst.PumpLoadAdj = 0F
				rst.MotorSPV = 0F
				rst.Iart = 0F
				rst.Irot = 0F
				rst.UpstrokeFriction = -1F
				rst.DownstrokeFriction = -1F
				rst.CompressibilityIndex = -1F
				value4 = -1F
				value3 = -1F
				value2 = Conversions.ToSingle(Interaction.IIf(rst.CBDataType = 1S And Not rst.UnknownM, rst.get_M(2), 0))
				value5 = Conversions.ToSingle(Interaction.IIf(rst.TubingAnchored <> 0S, rst.TubingAnchorDepth, 0))
				value6 = 0F
				num6 = 0S
				rst.Ntsteps = 0S
			End If
			FileSystem.FilePut(frn, flag, -1L)
			FileSystem.FilePut(frn, rst.PumpCondition, -1L)
			FileSystem.FilePut(frn, rst.PumpEfficiency, -1L)
			FileSystem.FilePut(frn, rst.PumpLoadAdj, -1L)
			FileSystem.FilePut(frn, rst.MotorSPV, -1L)
			FileSystem.FilePut(frn, rst.Iart, -1L)
			FileSystem.FilePut(frn, rst.Irot, -1L)
			FileSystem.FilePut(frn, value2, -1L)
			FileSystem.FilePut(frn, rst.UpstrokeFriction, -1L)
			FileSystem.FilePut(frn, rst.DownstrokeFriction, -1L)
			FileSystem.FilePut(frn, rst.CompressibilityIndex, -1L)
			FileSystem.FilePut(frn, value4, -1L)
			FileSystem.FilePut(frn, value3, -1L)
			FileSystem.FilePut(frn, value5, -1L)
			FileSystem.FilePut(frn, value6, -1L)
			FileSystem.FilePut(frn, num6, -1L)
			FileSystem.FilePut(frn, rst.Ntsteps, -1L)
			num7 = 0S
			num8 = rst.Ntsteps - 1S
			For num2 As Short = num7 To num8
				FileSystem.FilePut(frn, rst.SurfPos(CInt(num2)), -1L)
				FileSystem.FilePut(frn, rst.SurfLoad(CInt(num2)), -1L)
			Next
			FileSystem.FilePut(frn, rst.giFluidLevelSource, -1L)
			FileSystem.FilePut(frn, rst.PumpIntakePressure, -1L)
			FileSystem.FilePut(frn, rst.gbUseIPR, -1L)
			FileSystem.FilePut(frn, rst.giIPRMethod, -1L)
			FileSystem.FilePut(frn, rst.MidPerfDepth, -1L)
			FileSystem.FilePut(frn, rst.StaticBHPressure, -1L)
			FileSystem.FilePut(frn, rst.BubblePoint, -1L)
			FileSystem.FilePut(frn, rst.gnTestPoints, -1L)
			If rst.gnTestPoints > 0S Then
				Dim num9 As Short = 1S
				Dim gnTestPoints As Short = rst.gnTestPoints
				For num2 As Short = num9 To gnTestPoints
					FileSystem.FilePut(frn, rst.TestPoints(CInt(num2)).bPIEntered, -1L)
					FileSystem.FilePut(frn, rst.TestPoints(CInt(num2)).Pintake, -1L)
					FileSystem.FilePut(frn, rst.TestPoints(CInt(num2)).Pwf, -1L)
					FileSystem.FilePut(frn, rst.TestPoints(CInt(num2)).Production, -1L)
				Next
			End If
			FileSystem.FilePut(frn, rst.gbProducingBelowBPP, -1L)
			FILEIO.PutString(CShort(frn), rst.FileComment)
			FileSystem.FilePut(frn, rst.gbCalcFetkovichN, -1L)
			FileSystem.FilePut(frn, rst.FetkovichN, -1L)
			FileSystem.FilePut(frn, rst.MeasuredTVLoad, -1L)
			FileSystem.FilePut(frn, rst.MeasuredSVLoad, -1L)
			Motor.WriteMotorData(CShort(frn))
			FileSystem.FilePut(frn, rst.gbIncludeBuoyancy, -1L)
			FileSystem.FilePut(frn, rst.gbCalcFriction, -1L)
			FileSystem.FilePut(frn, rst.gbCalcFluidSPGR, -1L)
			FileSystem.FilePut(frn, rst.gbClampOn, -1L)
			FileSystem.FilePut(frn, rst.giDynoCorrectKinematic, -1L)
			FileSystem.FilePut(frn, rst.giDynoCorrectPhase, -1L)
			FileSystem.FilePut(frn, rst.gfDynoPhaseAdjustment, -1L)
			FileSystem.FilePut(frn, rst.gfDynoTOSAdjustment, -1L)
			FileSystem.FilePut(frn, rst.giDynoDetectKinematic, -1L)
			FileSystem.FilePut(frn, rst.giDynoDetectPhase, -1L)
			FileSystem.FilePut(frn, rst.gfDynoLoadAdjustment, -1L)
			If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
				FileSystem.FilePut(frn, rst.bUnknownUnbalance, -1L)
			End If
			bInputStored = -1
		End Sub

		Public Sub StoreInputDataAsText(ByRef frn As Integer, ByRef bInputStored As Integer)
			If RSWIN_DESC.rst.UnknownM And RSWIN_DESC.rst.CBDataType = 1S Then
				RSWIN_DESC.rst.set_M(2, 0F)
			End If
			Dim num As Short = 24S
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			FileSystem.PrintLine(frn, New Object() { RSWIN_DESC.XDMagic })
			FileSystem.PrintLine(frn, New Object() { num })
			FileSystem.PrintLine(frn, New Object() { rst.ACompanyName.PadRight(40, " "c) })
			FileSystem.PrintLine(frn, New Object() { rst.WellName.PadRight(40, " "c) })
			FileSystem.PrintLine(frn, New Object() { rst.UserName.PadRight(40, " "c) })
			FileSystem.PrintLine(frn, New Object() { rst.UserDate.PadRight(40, " "c) })
			FileSystem.PrintLine(frn, New Object() { rst.PumpDepth })
			FileSystem.PrintLine(frn, New Object() { rst.FluidLevel })
			FileSystem.PrintLine(frn, New Object() { rst.SPM })
			FileSystem.PrintLine(frn, New Object() { rst.Runtime })
			FileSystem.PrintLine(frn, New Object() { rst.TargetBFPD })
			FileSystem.PrintLine(frn, New Object() { rst.DynaSource })
			FileSystem.PrintLine(frn, New Object() { rst.DynaFile.PadRight(128, " "c) })
			FileSystem.PrintLine(frn, New Object() { rst.DynoDate })
			FileSystem.PrintLine(frn, New Object() { rst.LeutertDynamometer })
			FileSystem.PrintLine(frn, New Object() { rst.LeutertModel })
			FileSystem.PrintLine(frn, New Object() { rst.LeutertSpring })
			FileSystem.PrintLine(frn, New Object() { rst.LeutertScale })
			FileSystem.PrintLine(frn, New Object() { rst.MeasuredStroke })
			FileSystem.PrintLine(frn, New Object() { rst.PumpType })
			FileSystem.PrintLine(frn, New Object() { rst.PlungerSize })
			FileSystem.PrintLine(frn, New Object() { rst.WaterCut })
			FileSystem.PrintLine(frn, New Object() { rst.WaterSPGR })
			FileSystem.PrintLine(frn, New Object() { rst.OilAPI })
			FileSystem.PrintLine(frn, New Object() { rst.FluidSPGR })
			FileSystem.PrintLine(frn, New Object() { rst.Friction })
			FileSystem.PrintLine(frn, New Object() { rst.TubingOD })
			FileSystem.PrintLine(frn, New Object() { rst.TubingID })
			FileSystem.PrintLine(frn, New Object() { rst.TubingAnchored })
			FileSystem.PrintLine(frn, New Object() { rst.TubingAnchorDepth })
			FileSystem.PrintLine(frn, New Object() { rst.TubingPressure })
			FileSystem.PrintLine(frn, New Object() { rst.CasingPressure })
			FileSystem.PrintLine(frn, New Object() { rst.NumRods })
			Dim num2 As Short = 1S
			Dim numRods As Short = rst.NumRods
			For num3 As Short = num2 To numRods
				FileSystem.PrintLine(frn, New Object() { rst.Sections(CInt(num3)).Grade })
				FileSystem.PrintLine(frn, New Object() { rst.Sections(CInt(num3)).Diameter })
				FileSystem.PrintLine(frn, New Object() { rst.Sections(CInt(num3)).length })
				FileSystem.PrintLine(frn, New Object() { rst.Sections(CInt(num3)).SuckerRodLength })
				FileSystem.PrintLine(frn, New Object() { rst.Sections(CInt(num3)).RodDensity })
				FileSystem.PrintLine(frn, New Object() { rst.Sections(CInt(num3)).RodWeight })
				FileSystem.PrintLine(frn, New Object() { rst.Sections(CInt(num3)).Elasticity })
				FileSystem.PrintLine(frn, New Object() { rst.Sections(CInt(num3)).Area })
				FileSystem.PrintLine(frn, New Object() { rst.Sections(CInt(num3)).RodType.PadRight(20, " "c) })
				FileSystem.PrintLine(frn, New Object() { rst.Sections(CInt(num3)).TensileStrength })
			Next
			FileSystem.PrintLine(frn, New Object() { rst.ServiceFactor })
			FileSystem.PrintLine(frn, New Object() { rst.UnitID.PadRight(10, " "c) })
			FileSystem.PrintLine(frn, New Object() { rst.IDEntered })
			FileSystem.PrintLine(frn, New Object() { rst.PU.Manuf.PadRight(40, " "c) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.UnitName.PadRight(40, " "c) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.APIDesignation.PadRight(40, " "c) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.UnitType })
			FileSystem.PrintLine(frn, New Object() { rst.PU.RequiredRotation })
			FileSystem.PrintLine(frn, New Object() { rst.PU.CrankRotation })
			FileSystem.PrintLine(frn, New Object() { rst.PU.CrankHole })
			FileSystem.PrintLine(frn, New Object() { rst.PU.CrankHoles })
			FileSystem.PrintLine(frn, New Object() { rst.PU.CrankRadii(0) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.CrankRadii(1) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.CrankRadii(2) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.CrankRadii(3) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.CrankRadii(4) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.Strokes(0) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.Strokes(1) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.Strokes(2) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.Strokes(3) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.Strokes(4) })
			FileSystem.PrintLine(frn, New Object() { rst.PU.KinematicStroke })
			FileSystem.PrintLine(frn, New Object() { rst.PU.R })
			FileSystem.PrintLine(frn, New Object() { rst.PU.A })
			FileSystem.PrintLine(frn, New Object() { rst.PU.C })
			FileSystem.PrintLine(frn, New Object() { rst.PU.I })
			FileSystem.PrintLine(frn, New Object() { rst.PU.K })
			FileSystem.PrintLine(frn, New Object() { rst.PU.P })
			FileSystem.PrintLine(frn, New Object() { rst.PU.M })
			FileSystem.PrintLine(frn, New Object() { rst.PU.S })
			FileSystem.PrintLine(frn, New Object() { rst.PU.V0 })
			FileSystem.PrintLine(frn, New Object() { rst.PU.DrumDiamRatio })
			FileSystem.PrintLine(frn, New Object() { rst.PU.SprocketRadius })
			FileSystem.PrintLine(frn, New Object() { rst.PU.SprocketDistance })
			FileSystem.PrintLine(frn, New Object() { rst.PU.Unbalance })
			FileSystem.PrintLine(frn, New Object() { rst.PU.CrankOffset })
			FileSystem.PrintLine(frn, New Object() { rst.PU.StructRating })
			FileSystem.PrintLine(frn, New Object() { rst.PU.GearboxRating })
			FileSystem.PrintLine(frn, New Object() { rst.PU.MaxStroke })
			FileSystem.PrintLine(frn, New Object() { rst.PU.ArtInertia })
			FileSystem.PrintLine(frn, New Object() { rst.PU.OtherInfo.PadRight(40, " "c) })
			FileSystem.PrintLine(frn, New Object() { rst.ElectricityCost })
			FileSystem.PrintLine(frn, New Object() { rst.PowerMeterType })
			FileSystem.PrintLine(frn, New Object() { rst.CalcMotorSize })
			FileSystem.PrintLine(frn, New Object() { rst.CBDataType })
			FileSystem.PrintLine(frn, New Object() { rst.CBEffect })
			FileSystem.PrintLine(frn, New Object() { rst.CBAngle })
			FileSystem.PrintLine(frn, New Object() { rst.get_M(2) })
			FileSystem.PrintLine(frn, New Object() { rst.CBDataFile })
			FileSystem.PrintLine(frn, New Object() { rst.dNtsteps })
			Dim num4 As Short = 0S
			Dim num5 As Short = rst.dNtsteps - 1S
			For num3 As Short = num4 To num5
				FileSystem.PrintLine(frn, New Object() { rst.dSurfPos(CInt(num3)) })
				FileSystem.PrintLine(frn, New Object() { rst.dSurfLoad(CInt(num3)) })
			Next
			Dim num13 As Short
			Dim num14 As Short
			Dim flag As Boolean
			Dim num6 As Single
			Dim num7 As Single
			Dim num8 As Single
			Dim num10 As Single
			Dim num11 As Single
			Dim num12 As Short
			If rst.gbOutputLoaded Then
				If RSWIN_DESC.gSysDiag.bSurfaceMatchPoor <> 0S Then
					rst.PumpCondition = 1S
				ElseIf RSWIN_DESC.gSysDiag.bFullPump <> 0S Then
					rst.PumpCondition = 1S
				ElseIf RSWIN_DESC.gSysDiag.bFluidPound <> 0S Then
					rst.PumpCondition = 2S
				Else
					rst.PumpCondition = 3S
				End If
				flag = (RSWIN_DESC.gSysDiag.bFluidInertia <> 0S)
				num6 = Conversions.ToSingle(Interaction.IIf(rst.CBDataType = 1S And rst.UnknownM, 0, rst.get_M(2)))
				num7 = RSWIN_DESC.gSysDiag.PumpFillage
				num8 = Conversions.ToSingle(Interaction.IIf((rst.ULineSettingsChanged And rst.ULinesSetH) <> 0S, rst.UFeetFromSurface, rst.XDFeetFromSurface))
				Dim ufluidLoad As Single = Conversions.ToSingle(Interaction.IIf((rst.ULineSettingsChanged And rst.ULinesSetH) <> 0S, rst.UFluidLoad, rst.XDFluidLoad))
				Dim num9 As Single = Conversions.ToSingle(Interaction.IIf(flag And Strings.Len(Strings.Trim(rst.gclsUpstroke(1).Pattern)) = 0, rst.PumpEfficiency, 85))
				If Not rst.TubingAnchored <> 0S Then
					num10 = 0F
				ElseIf RSWIN_DESC.gSysDiag.iTVLeak = 1073741824 Then
					num10 = Conversions.ToSingle(Interaction.IIf(rst.TubingAnchored <> 0S, rst.TubingAnchorDepth, 0))
				ElseIf RODUTIL.FreeTubing(ufluidLoad, RSWIN_DESC.gSysDiag.TubingMovement) >= rst.PumpDepth / 2F Then
					num10 = 0F
				Else
					' The following expression was wrapped in a unchecked-expression
					num10 = rst.PumpDepth - RODUTIL.FreeTubing(ufluidLoad, RSWIN_DESC.gSysDiag.TubingMovement)
				End If
				num11 = 0F
				num12 = 0S
				num12 = num12 Or 1S * -RSWIN_DESC.gSysDiag.bMeasuredStrokeCorrected
				num12 = num12 Or 2S * -(RSWIN_DESC.gSysDiag.bSurfPosKinematicCorrected And If((-If(((rst.giDynoCorrectKinematic = 0S) > False), 1S, 0S)), 1S, 0S))
				num12 = num12 Or 4S * -If((-If(((RSWIN_DESC.gSysDiag.iAdjustPhase <> 0S And RSWIN_DESC.gSysDiag.PhaseAdjustment <> 0F And rst.giDynoCorrectPhase = 0S) > False), 1S, 0S)), 1S, 0S)
				num12 = num12 Or 8S * -If((-If(((rst.gfDynoLoadAdjustment <> 0F) > False), 1S, 0S)), 1S, 0S)
				num12 = num12 Or 16S * -RSWIN_DESC.gSysDiag.bLoadShiftCorrected
				num12 = num12 Or 32S * -RSWIN_DESC.gSysDiag.bClamponLoadCell
				num12 = num12 Or 64S * -If((-If(((rst.giDynoCorrectPhase = 2S Or rst.giDynoCorrectPhase = 3S) > False), 1S, 0S)), 1S, 0S)
				num12 = num12 Or 128S * -If((-If(((rst.giDynoCorrectKinematic = 2S) > False), 1S, 0S)), 1S, 0S)
			Else
				flag = False
				rst.PumpCondition = -1S
				rst.PumpLoadAdj = 0F
				rst.MotorSPV = 0F
				rst.Iart = 0F
				rst.Irot = 0F
				rst.UpstrokeFriction = -1F
				rst.DownstrokeFriction = -1F
				rst.CompressibilityIndex = -1F
				num8 = -1F
				num7 = -1F
				num6 = Conversions.ToSingle(Interaction.IIf(rst.CBDataType = 1S And Not rst.UnknownM, rst.get_M(2), 0))
				num10 = Conversions.ToSingle(Interaction.IIf(rst.TubingAnchored <> 0S, rst.TubingAnchorDepth, 0))
				num11 = 0F
				num12 = 0S
				rst.Ntsteps = 0S
			End If
			FileSystem.PrintLine(frn, New Object() { flag })
			FileSystem.PrintLine(frn, New Object() { rst.PumpCondition })
			FileSystem.PrintLine(frn, New Object() { rst.PumpEfficiency })
			FileSystem.PrintLine(frn, New Object() { rst.PumpLoadAdj })
			FileSystem.PrintLine(frn, New Object() { rst.MotorSPV })
			FileSystem.PrintLine(frn, New Object() { rst.Iart })
			FileSystem.PrintLine(frn, New Object() { rst.Irot })
			FileSystem.PrintLine(frn, New Object() { num6 })
			FileSystem.PrintLine(frn, New Object() { rst.UpstrokeFriction })
			FileSystem.PrintLine(frn, New Object() { rst.DownstrokeFriction })
			FileSystem.PrintLine(frn, New Object() { rst.CompressibilityIndex })
			FileSystem.PrintLine(frn, New Object() { num8 })
			FileSystem.PrintLine(frn, New Object() { num7 })
			FileSystem.PrintLine(frn, New Object() { num10 })
			FileSystem.PrintLine(frn, New Object() { num11 })
			FileSystem.PrintLine(frn, New Object() { num12 })
			FileSystem.PrintLine(frn, New Object() { rst.Ntsteps })
			num13 = 0S
			num14 = rst.Ntsteps - 1S
			For num3 As Short = num13 To num14
				FileSystem.PrintLine(frn, New Object() { rst.SurfPos(CInt(num3)) })
				FileSystem.PrintLine(frn, New Object() { rst.SurfLoad(CInt(num3)) })
			Next
			FileSystem.PrintLine(frn, New Object() { rst.giFluidLevelSource })
			FileSystem.PrintLine(frn, New Object() { rst.PumpIntakePressure })
			FileSystem.PrintLine(frn, New Object() { rst.gbUseIPR })
			FileSystem.PrintLine(frn, New Object() { rst.giIPRMethod })
			FileSystem.PrintLine(frn, New Object() { rst.MidPerfDepth })
			FileSystem.PrintLine(frn, New Object() { rst.StaticBHPressure })
			FileSystem.PrintLine(frn, New Object() { rst.BubblePoint })
			FileSystem.PrintLine(frn, New Object() { rst.gnTestPoints })
			If rst.gnTestPoints > 0S Then
				Dim num15 As Short = 1S
				Dim gnTestPoints As Short = rst.gnTestPoints
				For num3 As Short = num15 To gnTestPoints
					FileSystem.PrintLine(frn, New Object() { rst.TestPoints(CInt(num3)).bPIEntered })
					FileSystem.PrintLine(frn, New Object() { rst.TestPoints(CInt(num3)).Pintake })
					FileSystem.PrintLine(frn, New Object() { rst.TestPoints(CInt(num3)).Pwf })
					FileSystem.PrintLine(frn, New Object() { rst.TestPoints(CInt(num3)).Production })
				Next
			End If
			FileSystem.PrintLine(frn, New Object() { rst.gbProducingBelowBPP })
			FileSystem.PrintLine(frn, New Object() { rst.FileComment })
			FileSystem.PrintLine(frn, New Object() { rst.gbCalcFetkovichN })
			FileSystem.PrintLine(frn, New Object() { rst.FetkovichN })
			FileSystem.PrintLine(frn, New Object() { rst.MeasuredTVLoad })
			FileSystem.PrintLine(frn, New Object() { rst.MeasuredSVLoad })
			Motor.WriteMotorData(CShort(frn))
			FileSystem.PrintLine(frn, New Object() { rst.gbIncludeBuoyancy })
			FileSystem.PrintLine(frn, New Object() { rst.gbCalcFriction })
			FileSystem.PrintLine(frn, New Object() { rst.gbCalcFluidSPGR })
			FileSystem.PrintLine(frn, New Object() { rst.gbClampOn })
			FileSystem.PrintLine(frn, New Object() { rst.giDynoCorrectKinematic })
			FileSystem.PrintLine(frn, New Object() { rst.giDynoCorrectPhase })
			FileSystem.PrintLine(frn, New Object() { rst.gfDynoPhaseAdjustment })
			FileSystem.PrintLine(frn, New Object() { rst.gfDynoTOSAdjustment })
			FileSystem.PrintLine(frn, New Object() { rst.gfDynoLoadAdjustment })
			bInputStored = -1
		End Sub

		Public Function StoreOutputData(ByRef frn As Short, bStoreOutput As Boolean) As Boolean
			' The following expression was wrapped in a checked-statement
			If bStoreOutput Then
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim value As Integer
				FileSystem.FilePut(CInt(frn), value, -1L)
				Dim value2 As Integer
				FileSystem.FilePut(CInt(frn), value2, -1L)
				Dim dateTime As DateTime
				FileSystem.FilePutObject(CInt(frn), dateTime, -1L)
				FileSystem.FilePut(CInt(frn), rst.BPDsurface, -1L)
				FileSystem.FilePut(CInt(frn), rst.UFeetFromSurface, -1L)
				FileSystem.FilePut(CInt(frn), rst.UFeetOverPump, -1L)
				FileSystem.FilePut(CInt(frn), rst.UFluidLoad, -1L)
				FileSystem.FilePut(CInt(frn), rst.GrossPumpStroke, -1L)
				FileSystem.FilePut(CInt(frn), rst.MaxRodStressL, -1L)
				FileSystem.FilePut(CInt(frn), rst.MinMotorHP, -1L)
				FileSystem.FilePut(CInt(frn), rst.Mprload, -1L)
				FileSystem.FilePut(CInt(frn), rst.UNetProduction, -1L)
				FileSystem.FilePut(CInt(frn), rst.UNetStrokeApparent, -1L)
				FileSystem.FilePut(CInt(frn), rst.Ntsteps, -1L)
				FileSystem.FilePut(CInt(frn), rst.NtstepsUpstroke, -1L)
				FileSystem.FilePut(CInt(frn), rst.Prhp, -1L)
				FileSystem.FilePut(CInt(frn), rst.Pprload, -1L)
				FileSystem.FilePut(CInt(frn), rst.UPintakeFromLines, -1L)
				FileSystem.FilePut(CInt(frn), rst.UPumpFillage, -1L)
				FileSystem.FilePut(CInt(frn), rst.PumpFriction, -1L)
				FileSystem.FilePut(CInt(frn), rst.StructL, -1L)
				FileSystem.FilePut(CInt(frn), rst.USystemEff, -1L)
				FileSystem.FilePut(CInt(frn), rst.TotalTheta, -1L)
				FileSystem.FilePut(CInt(frn), rst.ULinesSetH, -1L)
				FileSystem.FilePut(CInt(frn), rst.ULinesSetV, -1L)
				FileSystem.FilePut(CInt(frn), rst.ULineSettingsChanged, -1L)
				FileSystem.FilePut(CInt(frn), rst.XDFeetFromSurface, -1L)
				FileSystem.FilePut(CInt(frn), rst.XDFeetOverPump, -1L)
				FileSystem.FilePut(CInt(frn), rst.XDFluidLoad, -1L)
				FileSystem.FilePut(CInt(frn), rst.XDLinesSetH, -1L)
				FileSystem.FilePut(CInt(frn), rst.XDLinesSetV, -1L)
				FileSystem.FilePut(CInt(frn), rst.XDNetProduction, -1L)
				FileSystem.FilePut(CInt(frn), rst.XDNetStroke, -1L)
				FileSystem.FilePut(CInt(frn), rst.XDNetStrokeApparent, -1L)
				FileSystem.FilePut(CInt(frn), rst.XDPintakeFromLines, -1L)
				FileSystem.FilePut(CInt(frn), rst.XDPumpFillage, -1L)
				FileSystem.FilePut(CInt(frn), rst.XDSystemEff, -1L)
				FileSystem.FilePut(CInt(frn), rst.WrodsInAir, -1L)
				FileSystem.FilePut(CInt(frn), rst.WrodsInFluid, -1L)
				FileSystem.FilePut(CInt(frn), rst.g_FluidPoundFluidLoad, -1L)
				Dim i As Integer = 0
				Do
					FileSystem.FilePut(CInt(frn), rst.CBE90(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.Clf(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.DollarsPerBblFluid(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.DollarsPerBblOil(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.get_ElectricBillperMonth(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.GearboxLoading(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.HpNemaD(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.HpUhs(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.get_M(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.MotorKWH(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.PeakTorque(i), -1L)
					Dim num As Integer = 0
					Dim num2 As Integer = CInt((rst.Ntsteps - 1S))
					For j As Integer = num To num2
						FileSystem.FilePut(CInt(frn), rst.Tnet(i, j), -1L)
					Next
					i += 1
				Loop While i <= 2
				Dim num3 As Integer = 0
				Dim num4 As Integer = CInt((rst.Ntsteps - 1S))
				i = num3
				While i <= num4
					FileSystem.FilePut(CInt(frn), rst.PumpPos(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.PumpLoad(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.PermLoad(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.Thetac(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.Tf(i), -1L)
					i += 1
				End While
				Dim num5 As Integer = 1
				Dim numRods As Integer = CInt(rst.NumRods)
				i = num5
				While i <= numRods
					FileSystem.FilePut(CInt(frn), rst.StressL(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.maxStressTop(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.minStressTop(i), -1L)
					FileSystem.FilePut(CInt(frn), rst.minStressBot(i), -1L)
					i += 1
				End While
				i = 1
				Do
					FileSystem.FilePut(CInt(frn), rst.LineSettings(i).LSet, -1L)
					FileSystem.FilePut(CInt(frn), rst.LineSettings(i).Value, -1L)
					i += 1
				Loop While i <= 4
				i = 1
				Do
					FileSystem.FilePut(CInt(frn), rst.XDLineSettings(i).LSet, -1L)
					FileSystem.FilePut(CInt(frn), rst.XDLineSettings(i).Value, -1L)
					i += 1
				Loop While i <= 4
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bBentPumpBarrel, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bCrankHoleCorrected, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bExtremeRodTubingFriction, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bExcessiveRodTubingFriction, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bFluidInertia, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bFluidLevelCorrected, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bFluidPound, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bFullPump, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bGasInterference, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bGasLock, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bHittingDown, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bHittingUp, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bIncompleteFillage, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bIncorrectFluidSPGR, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bIncorrectPlungerSize, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bIncorrectProductionRate, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bIncorrectSPM, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bLoadShiftCorrected, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bMalfunctioningTubingAnchor, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bMeasuredStrokeCorrected, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bPlungerTooLarge, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bPlungerTooSmall, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bPumpConditionGood, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bPumpFriction, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bRodPart, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bRodTubingFriction, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bSevereDownholeProblem, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bShallowFriction, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bSinkerBarWaveReflection, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bSPMHigh, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bSPMLow, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bStuckPump, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bSurfaceMatchPoor, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bSurfPosKinematicCorrected, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bTubingAnchored, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bTubingAnchorLoose, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bTubingLeak, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bTubingMovement, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bUnknownPumpCondition, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.bUpperRingValvePump, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.iAdjustPhase, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.iCalcFrictionStatus, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.iDiagRodPart, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.iOrigCrankHole, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.iPumpFriction, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.iSectFluidVelocity, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.iSVLeak, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.iTVLeak, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.iWornPump, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.iWornPumpBarrel, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.FeetFromSurface, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.FluidSPGR, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.FluidVelocity, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.LoadShift, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.LoadShiftPct, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.MeasuredStroke, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.OrigStrokeLength, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.PhaseAdjustment, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.PlungerSize, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.PumpFillage, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.PumpIntakePressure, -1L)
				FileSystem.FilePut(CInt(frn), RSWIN_DESC.gSysDiag.TubingMovement, -1L)
			End If
			Dim value3 As Short = 27S
			FileSystem.FilePut(CInt(frn), value3, -1L)
			FileSystem.FilePut(CInt(frn), bStoreOutput, -1L)
			Return True
		End Function

		Public Sub StoreFile(rfn As String, bStoreOutput As Boolean, ByRef DataStored As Boolean)
			Dim num2 As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				DataStored = False
				IL_06:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_0E:
				num = 3
				If Not FILEUTIL.FileExists(rfn) Then
					GoTo IL_23
				End If
				IL_1A:
				num = 4
				FileSystem.Kill(rfn)
				IL_23:
				num = 6
				If Information.Err().Number = 0 Then
					GoTo IL_45
				End If
				IL_33:
				num = 7
				Util.Errmsg("The data file could not be created.  Please make sure the file is writable, or choose a different file name.")
				IL_40:
				GoTo IL_2A2
				IL_45:
				num = 9
				IL_49:
				num = 10
				Dim num3 As Short = CShort(FileSystem.FreeFile())
				IL_54:
				num = 11
				FileSystem.FileOpen(CInt(num3), rfn, OpenMode.Binary, OpenAccess.Write, OpenShare.LockWrite, -1)
				IL_64:
				num = 12
				Dim num4 As Integer = CInt(num3)
				Dim flag As Boolean
				Dim num5 As Integer = If((-If((flag > False), 1, 0)), 1, 0)
				SaveXDG.StoreInputData(num4, num5)
				flag = (num5 <> 0)
				num3 = CShort(num4)
				IL_83:
				num = 13
				If Not flag Then
					GoTo IL_FC
				End If
				IL_8A:
				num = 14
				Dim flag2 As Boolean = SaveXDG.StoreOutputData(num3, bStoreOutput)
				IL_97:
				num = 15
				If flag2 Then
					GoTo IL_FC
				End If
				IL_9E:
				num = 16
				FileSystem.FileClose(New Integer() { CInt(num3) })
				IL_B6:
				num = 17
				FileSystem.Kill(rfn)
				IL_C0:
				num = 18
				FileSystem.FileOpen(CInt(num3), rfn, OpenMode.Binary, OpenAccess.Write, OpenShare.LockWrite, -1)
				IL_D0:
				num = 19
				num5 = CInt(num3)
				num4 = If((-If((flag > False), 1, 0)), 1, 0)
				SaveXDG.StoreInputData(num5, num4)
				flag = (num4 <> 0)
				num3 = CShort(num5)
				IL_EF:
				num = 20
				flag2 = SaveXDG.StoreOutputData(num3, False)
				IL_FC:
				num = 23
				FileSystem.FileClose(New Integer() { CInt(num3) })
				IL_114:
				GoTo IL_2A2
				IL_119:
				num = 26
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], Information.Err().Number - 61)
				GoTo IL_191
				IL_161:
				num = 30
				Util.cErrmsg(94)
				IL_16C:
				GoTo IL_2A2
				IL_171:
				num = 33
				Util.cErrmsg(95)
				IL_17C:
				GoTo IL_2A2
				IL_181:
				num = 36
				Util.cErrmsg(93)
				IL_18C:
				GoTo IL_2A2
				IL_191:
				num = 39
				Throw ProjectData.CreateProjectError(Information.Err().Number)
				IL_1A5:
				GoTo IL_2A2
				IL_1AA:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_25E:
				GoTo IL_297
				IL_260:
				num7 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_273:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_260
			End Try
			IL_297:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2A2:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub
	End Module
End Namespace
