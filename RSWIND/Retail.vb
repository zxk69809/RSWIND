Imports System
Imports System.Diagnostics
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module Retail
		Public Sub MakeCorrectedSurfCardFile()
			Dim num As Integer
			Dim num9 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				IL_12:
				num2 = 3
				If Not(RSWIN_DESC.rst.gbBatch And RSWIN_DESC.rst.gbAutomatic) Then
					GoTo IL_263
				End If
				IL_2F:
				num2 = 4
				Dim num3 As Integer = 0
				IL_34:
				num2 = 5
				Dim num4 As Integer = 0
				IL_39:
				num2 = 6
				If Not cRODSTAR.gbOutputLoaded Then
					GoTo IL_15D
				End If
				IL_48:
				num2 = 7
				num4 = num4 Or CInt((1S * -RSWIN_DESC.gSysDiag.bMeasuredStrokeCorrected))
				IL_5C:
				num2 = 8
				num4 = num4 Or CInt((2S * -(RSWIN_DESC.gSysDiag.bSurfPosKinematicCorrected And If((-If(((cRODSTAR.giDynoCorrectKinematic = 0S) > False), 1S, 0S)), 1S, 0S))))
				IL_80:
				num2 = 9
				num4 = num4 Or CInt((4S * -If((-If(((RSWIN_DESC.gSysDiag.iAdjustPhase <> 0S And RSWIN_DESC.gSysDiag.PhaseAdjustment <> 0F And cRODSTAR.giDynoCorrectPhase = 0S) > False), 1S, 0S)), 1S, 0S)))
				IL_C0:
				num2 = 10
				num4 = num4 Or CInt((8S * -If((-If(((cRODSTAR.gfDynoLoadAdjustment <> 0F) > False), 1S, 0S)), 1S, 0S)))
				IL_E1:
				num2 = 11
				num4 = num4 Or CInt((16S * -RSWIN_DESC.gSysDiag.bLoadShiftCorrected))
				IL_F7:
				num2 = 12
				num4 = num4 Or CInt((32S * -RSWIN_DESC.gSysDiag.bClamponLoadCell))
				IL_10D:
				num2 = 13
				num4 = num4 Or CInt((64S * -If((-If(((cRODSTAR.giDynoCorrectPhase = 2S Or cRODSTAR.giDynoCorrectPhase = 3S) > False), 1S, 0S)), 1S, 0S)))
				IL_133:
				num2 = 14
				num4 = num4 Or CInt((128S * -If((-If(((cRODSTAR.giDynoCorrectKinematic = 2S) > False), 1S, 0S)), 1S, 0S)))
				IL_151:
				num2 = 15
				num3 = CInt(cRODSTAR.Ntsteps)
				IL_15D:
				num2 = 17
				Dim cRODSTAR2 As cRODSTAR = cRODSTAR
				Dim inputfile As String = cRODSTAR2.Inputfile
				Dim text As String = ""
				Dim text2 As String = ""
				Dim text3 As String = ""
				Dim text4 As String
				FILEIO.SplitPath(inputfile, text, text2, text4, text3)
				cRODSTAR2.Inputfile = inputfile
				IL_19C:
				num2 = 18
				text3 = ""
				text2 = ".CSC"
				Dim fileName As String
				FILEIO.MakePath(fileName, text3, RSWIN_DESC.SETUP_WK1Dir, text4, text2)
				IL_1C1:
				num2 = 19
				Dim num5 As Integer
				FileSystem.FileOpen(num5, fileName, OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				IL_1D1:
				num2 = 20
				FileSystem.Print(num5, New Object() { num3, num4 })
				IL_1F9:
				num2 = 21
				Dim num6 As Integer = 0
				Dim num7 As Integer = num3 - 1
				For i As Integer = num6 To num7
					IL_206:
					num2 = 22
					FileSystem.Print(num5, New Object() { cRODSTAR.SurfPos(i), cRODSTAR.SurfLoad(i) })
					IL_23E:
					num2 = 23
				Next
				IL_24B:
				num2 = 24
				FileSystem.FileClose(New Integer() { num5 })
				IL_263:
				cRODSTAR = Nothing
				IL_266:
				GoTo IL_32B
				IL_26B:
				Dim num8 As Integer = num9 + 1
				num9 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8)
				IL_2E7:
				GoTo IL_320
				IL_2E9:
				num9 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2FC:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num9 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2E9
			End Try
			IL_320:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_32B:
			If num9 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub MakePredSurfCardFile()
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				IL_12:
				num2 = 3
				If Not(RSWIN_DESC.rst.gbBatch And RSWIN_DESC.rst.gbAutomatic) Then
					GoTo IL_15A
				End If
				IL_2F:
				num2 = 4
				Dim cRODSTAR2 As cRODSTAR = cRODSTAR
				Dim inputfile As String = cRODSTAR2.Inputfile
				Dim text As String = ""
				Dim text2 As String = ""
				Dim text3 As String = ""
				Dim text4 As String
				FILEIO.SplitPath(inputfile, text, text2, text4, text3)
				cRODSTAR2.Inputfile = inputfile
				IL_6D:
				num2 = 5
				text3 = ""
				text2 = ".PSC"
				Dim fileName As String
				FILEIO.MakePath(fileName, text3, RSWIN_DESC.SETUP_WK1Dir, text4, text2)
				IL_91:
				num2 = 6
				Dim num3 As Integer = FileSystem.FreeFile()
				IL_9A:
				num2 = 7
				FileSystem.FileOpen(num3, fileName, OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				IL_A8:
				num2 = 8
				FileSystem.Print(num3, New Object() { cRODSTAR.pNtsteps })
				IL_CB:
				num2 = 9
				Dim num4 As Integer = 0
				Dim num5 As Integer = CInt((cRODSTAR.pNtsteps - 1S))
				For i As Integer = num4 To num5
					IL_DE:
					num2 = 10
					FileSystem.Print(num3, New Object() { cRODSTAR.pSurfPos(i), cRODSTAR.pSurfLoad(i) })
					IL_116:
					num2 = 11
				Next
				IL_123:
				num2 = 12
				FileSystem.Print(num3, New Object() { cRODSTAR.DynoDate })
				IL_142:
				num2 = 13
				FileSystem.FileClose(New Integer() { num3 })
				IL_15A:
				cRODSTAR = Nothing
				IL_15D:
				GoTo IL_1F6
				IL_162:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_1B2:
				GoTo IL_1EB
				IL_1B4:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1C7:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1B4
			End Try
			IL_1EB:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1F6:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub MakePumpCardFile()
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_08:
				Dim num2 As Integer = 2
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				IL_12:
				num2 = 3
				If Not(RSWIN_DESC.rst.gbBatch And RSWIN_DESC.rst.gbAutomatic) Then
					GoTo IL_15A
				End If
				IL_2F:
				num2 = 4
				Dim cRODSTAR2 As cRODSTAR = cRODSTAR
				Dim inputfile As String = cRODSTAR2.Inputfile
				Dim text As String = ""
				Dim text2 As String = ""
				Dim text3 As String = ""
				Dim text4 As String
				FILEIO.SplitPath(inputfile, text, text2, text4, text3)
				cRODSTAR2.Inputfile = inputfile
				IL_6D:
				num2 = 5
				text3 = ""
				text2 = ".DPC"
				Dim fileName As String
				FILEIO.MakePath(fileName, text3, RSWIN_DESC.SETUP_WK1Dir, text4, text2)
				IL_91:
				num2 = 6
				Dim num3 As Integer = FileSystem.FreeFile()
				IL_9A:
				num2 = 7
				FileSystem.FileOpen(num3, fileName, OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				IL_A8:
				num2 = 8
				FileSystem.Print(num3, New Object() { cRODSTAR.Ntsteps })
				IL_CB:
				num2 = 9
				Dim num4 As Integer = 0
				Dim num5 As Integer = CInt((cRODSTAR.Ntsteps - 1S))
				For i As Integer = num4 To num5
					IL_DE:
					num2 = 10
					FileSystem.Print(num3, New Object() { cRODSTAR.PumpPos(i), cRODSTAR.PumpLoad(i) })
					IL_116:
					num2 = 11
				Next
				IL_123:
				num2 = 12
				FileSystem.Print(num3, New Object() { cRODSTAR.DynoDate })
				IL_142:
				num2 = 13
				FileSystem.FileClose(New Integer() { num3 })
				IL_15A:
				cRODSTAR = Nothing
				IL_15D:
				GoTo IL_1F6
				IL_162:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_1B2:
				GoTo IL_1EB
				IL_1B4:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1C7:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1B4
			End Try
			IL_1EB:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1F6:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub LogPUData(ByRef Unit1 As RSWIN_DESC.PUDataRec)
			Try
				Debug.WriteLine("PU.Manuf =" + Unit1.Manuf)
				Debug.WriteLine("PU.APIDesignation =" + Unit1.APIDesignation)
				Debug.WriteLine("PU.UnitName =" + Unit1.UnitName)
				Debug.WriteLine("PU.OtherInfo =" + Unit1.OtherInfo)
				Debug.WriteLine("PU.UnitTyp =" + Conversions.ToString(CInt(Unit1.UnitType)))
				Debug.WriteLine("PU.RequiredRotation =" + Conversions.ToString(CInt(Unit1.RequiredRotation)))
				Debug.WriteLine("PU.CrankRotation =" + Conversions.ToString(CInt(Unit1.CrankRotation)))
				Debug.WriteLine("PU.CrankHole =" + Conversions.ToString(CInt(Unit1.CrankHole)))
				Debug.WriteLine("PU.CrankHoles =" + Conversions.ToString(CInt(Unit1.CrankHoles)))
				Debug.WriteLine("PU.CrankRadii(0) =" + Conversions.ToString(Unit1.CrankRadii(0)))
				Debug.WriteLine("PU.CrankRadii(1) =" + Conversions.ToString(Unit1.CrankRadii(1)))
				Debug.WriteLine("PU.CrankRadii(2) =" + Conversions.ToString(Unit1.CrankRadii(2)))
				Debug.WriteLine("PU.CrankRadii(3) =" + Conversions.ToString(Unit1.CrankRadii(3)))
				Debug.WriteLine("PU.CrankRadii(4) =" + Conversions.ToString(Unit1.CrankRadii(4)))
				Debug.WriteLine("PU.Strokes(0) =" + Conversions.ToString(Unit1.Strokes(0)))
				Debug.WriteLine("PU.Strokes(1) =" + Conversions.ToString(Unit1.Strokes(1)))
				Debug.WriteLine("PU.Strokes(2) =" + Conversions.ToString(Unit1.Strokes(2)))
				Debug.WriteLine("PU.Strokes(3) =" + Conversions.ToString(Unit1.Strokes(3)))
				Debug.WriteLine("PU.Strokes(4) =" + Conversions.ToString(Unit1.Strokes(4)))
				Debug.WriteLine("PU.KinematicStroke =" + Conversions.ToString(Unit1.KinematicStroke))
				Debug.WriteLine("PU.FileRecord =" + Conversions.ToString(CInt(Unit1.FileRecord)))
				Debug.WriteLine("PU.iUnused0  =" + Conversions.ToString(CInt(Unit1.iUnused0)))
				Debug.WriteLine("PU.R =" + Conversions.ToString(Unit1.R))
				Debug.WriteLine("PU.A =" + Conversions.ToString(Unit1.A))
				Debug.WriteLine("PU.C =" + Conversions.ToString(Unit1.C))
				Debug.WriteLine("PU.I =" + Conversions.ToString(Unit1.I))
				Debug.WriteLine("PU.K =" + Conversions.ToString(Unit1.K))
				Debug.WriteLine("PU.P =" + Conversions.ToString(Unit1.P))
				Debug.WriteLine("PU.M =" + Conversions.ToString(Unit1.M))
				Debug.WriteLine("PU.S =" + Conversions.ToString(Unit1.S))
				Debug.WriteLine("PU.V0 =" + Conversions.ToString(Unit1.V0))
				Debug.WriteLine("PU.DrumDiamRatio =" + Conversions.ToString(Unit1.DrumDiamRatio))
				Debug.WriteLine("PU.SprocketRadius =" + Conversions.ToString(Unit1.SprocketRadius))
				Debug.WriteLine("PU.SprocketDistance =" + Conversions.ToString(Unit1.SprocketDistance))
				Debug.WriteLine("PU.Unbalance =" + Conversions.ToString(Unit1.Unbalance))
				Debug.WriteLine("PU.CrankOffset =" + Conversions.ToString(Unit1.CrankOffset))
				Debug.WriteLine("PU.StructRating =" + Conversions.ToString(Unit1.StructRating))
				Debug.WriteLine("PU.GearboxRating =" + Conversions.ToString(Unit1.GearboxRating))
				Debug.WriteLine("PU.MaxStroke =" + Conversions.ToString(Unit1.MaxStroke))
				Debug.WriteLine("PU.ArtInertia =" + Conversions.ToString(Unit1.ArtInertia))
			Catch ex As Exception
			End Try
		End Sub

		Public Sub LogPUData()
		End Sub

		Public Function DemoMode() As Integer
			Return 0
		End Function

		Public Sub RestoreUserData()
		End Sub

		Public Sub ShowGlossary()
		End Sub

		Public Sub UpdateFile()
			Try
				If Strings.InStr(RSWIN_DESC.rst.Inputfile, ".rdg", CompareMethod.Binary) > 0 Then
					RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace(".rdg", ".rsvx")
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".RDG", CompareMethod.Binary) > 0 Then
					RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace(".RDG", ".rsvx")
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".xdg", CompareMethod.Binary) > 0 Then
					RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace(".xdg", ".rsvx")
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".XDG", CompareMethod.Binary) > 0 Then
					RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace(".XDG", ".rsvx")
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".rst", CompareMethod.Binary) > 0 And Strings.InStr(RSWIN_DESC.rst.Inputfile, ".rstx", CompareMethod.Binary) = 0 Then
					RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace(".rst", "." + RSWIN_DESC.sFILETYPE)
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".RST", CompareMethod.Binary) > 0 And Strings.InStr(RSWIN_DESC.rst.Inputfile, ".RSTX", CompareMethod.Binary) = 0 Then
					RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace(".RST", "." + RSWIN_DESC.sFILETYPE)
				ElseIf Not RSWIN_DESC.bRodStarD And Strings.InStr(RSWIN_DESC.rst.Inputfile, ".rstx", CompareMethod.Binary) > 0 Then
					RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace(".rstx", "." + RSWIN_DESC.sFILETYPE)
				ElseIf Not RSWIN_DESC.bRodStarD And Strings.InStr(RSWIN_DESC.rst.Inputfile, ".RSTX", CompareMethod.Binary) > 0 Then
					RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace(".RSTX", "." + RSWIN_DESC.sFILETYPE)
				ElseIf RSWIN_DESC.bRodStarD Then
					Dim flag As Boolean = False
					If RSWIN_DESC.mdsDeviationProfile Is Nothing Then
						flag = True
					ElseIf RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count = 0 Then
						flag = True
					End If
					If flag Then
						If Strings.InStr(RSWIN_DESC.rst.Inputfile, ".rstx", CompareMethod.Binary) > 0 Then
							RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace(".rstx", "." + RSWIN_DESC.sOTHERFILETYPE)
						ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".RSTX", CompareMethod.Binary) > 0 Then
							RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace(".RSTX", "." + RSWIN_DESC.sOTHERFILETYPE)
						End If
					End If
				End If
				Dim bStoreOutput As Boolean = RSWIN_DESC.bRunGuru OrElse RSWIN_DESC.rst.gbOutputLoaded
				Dim flag3 As Boolean
				Dim flag4 As Boolean
				Dim flag2 As Boolean = MRodstarXML.StoreXML(RSWIN_DESC.rst.Inputfile, bStoreOutput, flag3, flag4)
				If Not flag2 And (RSWIN_DESC.rst.gbOutputLoaded And Not flag4) Then
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim inputfile As String = rst.Inputfile
					Dim flag5 As Boolean = FILEUTIL.FileExists(inputfile)
					rst.Inputfile = inputfile
					If flag5 Then
						FileSystem.Kill(RSWIN_DESC.rst.Inputfile)
					End If
					flag2 = MRodstarXML.StoreXML(RSWIN_DESC.rst.Inputfile, False, flag3, flag4)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub VerifyCBE()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Not(rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S) And rst.PU.UnitType <> 8S Then
				Dim obj As Object = CDbl(rst.CBAngle) / 3.141592653589793 * 180.0
				If Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Operators.ModObject(obj, 180), 15, False), Operators.CompareObjectGreater(Operators.ModObject(obj, 180), 165, False))) Then
					Dim msg As String
					Verify.VerifyContinueOrReturn(msg, False)
					rst.CBDataType = 1S
					rst.set_M(2, 0F)
					rst.UnknownM = True
				End If
			End If
		End Sub
	End Module
End Namespace
