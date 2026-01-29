Imports System
Imports System.Data
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module LOADRST
		Public Function LoadRodstarFile(frn As Short, ByRef sInputFile As String) As Boolean
			Dim num As Short
			FileSystem.FileGet(CInt(frn), num, -1L)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.giThisVersion = num
			Dim result As Boolean
			If num > 31S Then
				Util.cErrmsg(114)
			Else
				If num >= 30S Then
					rst.bDeviated = True
				Else
					rst.bDeviated = False
				End If
				If num >= 26S Then
					Dim num2 As Short
					FileSystem.FileGet(CInt(frn), num2, -1L)
				End If
				Dim num3 As Short
				If num <= 20S Then
					num3 = 0S
				Else
					FileSystem.FileGet(CInt(frn), num3, -1L)
				End If
				rst.gbOutputOld = (num3 < 1S)
				Dim flag2 As Boolean
				Dim flag As Boolean = LOADRST.LoadInputData(frn, num, flag2)
				flag2 = True
				Dim flag3 As Boolean
				If Not flag Then
					flag3 = False
					rst.gbOutputLoaded = False
				ElseIf flag2 Then
					flag3 = True
					rst.gbOutputLoaded = False
				Else
					LOADRST.LoadOutputData(frn, num, flag3)
				End If
				Dim flag4 As Boolean
				If rst.gbBatch Then
					flag4 = flag
				Else
					flag4 = (flag AndAlso flag3)
				End If
				If flag4 Then
					LOADRST.CheckInputData(num)
					Dim num4 As Integer
					LOADRST.LoadDeviationProfile(sInputFile, num4)
				End If
				result = flag4
			End If
			Return result
		End Function

		Private Sub CheckInputData(ThisVersion As Short)
			Dim pu As RSWIN_DESC.PUDataRec
			pu.Initialize()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.OilSPGR = CSng((141.5 / (CDbl(rst.OilAPI) + 131.5)))
			RSWIN_DESC.WarnedAboutFluidInertia = -1S
			RSWIN_DESC.WarnedAboutPlungerSize = -1S
			If Not rst.gbCalcPumpCondition AndAlso rst.PumpCondition = 1S Then
				rst.PumpFillage = 0F
			End If
			If(Not rst.SPMEntered And If((-If((Not rst.gbOutputLoaded > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				rst.SPM = 0F
			End If
			rst.UnknownM = (rst.get_M(2) = 0F)
			If rst.RodStringType = 1S Then
				rst.APIRodType = rst.Sections(1).RodType
				rst.APITensileStrength = rst.Sections(1).TensileStrength
			Else
				rst.APIRod = 0S
				rst.APIGrade = 0S
			End If
			If rst.RodStringType = 3S Then
				If(If((-If(((rst.giRodDesignStyle <> 0S) > False), 1S, 0S)), 1S, 0S) And Not rst.RSIncludeSB And Not rst.RSFGIncludeSteel) <> 0S Then
					rst.RSIncludeSB = -1S
				End If
			Else
				rst.RSGrade = 0S
				rst.RSMaxSize = 0F
				rst.RSMinSize = 0F
				Dim sinkerBar As RSWIN_DESC.RodSection
				rst.SinkerBar = sinkerBar
			End If
			If Not rst.IncludeFluidInertia <> 0S Then
				rst.CompressibilityIndex = 3F
			End If
			Dim unitID As String = RSWIN_DESC.rst.UnitID
			Dim num As Short
			Dim obj As Object = num
			Dim text As String
			PUDATA1.ParseUnitID(unitID, text, obj)
			num = Conversions.ToShort(obj)
			Dim text2 As String = text
			If Operators.CompareString(text2, "CAB", False) = 0 Then
				Dim cRODSTAR As cRODSTAR = rst
				Dim str As String = "CAA"
				obj = CInt((num + 98S))
				cRODSTAR.UnitID = str + Util.Format(obj).Trim()
			End If
			If(If((-If((ThisVersion <= 17S > False), 1S, 0S)), 1S, 0S) And Not rst.IDEntered And If((-If(((rst.PU.CrankHole = 0S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				pu = rst.PU
				pu.CrankHole = 1S
				pu.CrankHoles = 1S
				pu.CrankRadii(1) = rst.PU.R
				pu.Strokes(1) = CSng(Conversion.Int(CDbl(rst.PU.KinematicStroke) + 0.5))
				rst.PU = pu
			End If
			If(If((-If(((rst.RodStringType = 3S) > False), 1S, 0S)), 1S, 0S) And (If((-If(((rst.giRodDesignStyle <> 0S) > False), 1S, 0S)), 1S, 0S) Or rst.RSIncludeSB)) <> 0S Then
				Dim sinkerBar2 As RSWIN_DESC.RodSection = rst.SinkerBar
				If sinkerBar2.SuckerRodLength = 0F Then
					If(If((-If((RODUTIL.IsCorod(sinkerBar2.Grade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(sinkerBar2.Grade))) <> 0 Then
						sinkerBar2.SuckerRodLength = 1F
					ElseIf RODUTIL.IsSteel(CInt(sinkerBar2.Grade)) <> 0 Then
						sinkerBar2.SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
					ElseIf sinkerBar2.Grade <> 16385S And sinkerBar2.Grade <> 16389S And sinkerBar2.Grade <> 16390S Then
						sinkerBar2.SuckerRodLength = 37.5F
					End If
				End If
				rst.SinkerBar = sinkerBar2
			End If
			rst.DragSettings = 0S
			rst.FluidDamping = Conversions.ToSingle(ini.GetDataValue("FluidDamping", 4, True, 0.1))
			rst.PumpDragUpstrokeMax = Conversions.ToSingle(ini.GetDataValue("PumpDragUpstrokeMax", 4, True, 200))
			rst.PumpDragDownstrokeMax = Conversions.ToSingle(ini.GetDataValue("PumpDragDownstrokeMax", 4, True, 200))
			RODUTIL.CheckCustomRodGrades()
		End Sub

		Public Function LoadDeviationProfile(ByRef sRodstarFile As String, ByRef iCount As Integer) As Boolean
			Dim num As Integer
			Dim flag5 As Boolean
			Dim num12 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 2
				IL_08:
				Dim num2 As Integer = 2
				Dim flag As Boolean = False
				IL_0D:
				num2 = 3
				MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
				IL_1B:
				num2 = 4
				Dim flag2 As Boolean = False
				IL_21:
				num2 = 7
				If flag2 <> (Strings.Len(sRodstarFile) <> 0) Then
					GoTo IL_3A
				End If
				IL_35:
				GoTo IL_446
				IL_3A:
				num2 = 9
				Dim flag3 As Boolean = flag2
				Dim text As String = Nothing
				Dim text2 As String
				Dim text3 As String
				Dim text4 As String
				If flag3 <> FILEIO.SplitPath(sRodstarFile, text2, text3, text4, text) Then
					GoTo IL_58
				End If
				IL_53:
				GoTo IL_446
				IL_58:
				num2 = 11
				Dim flag4 As Boolean = flag2
				text = "deviationprofile"
				Dim fileName As String
				If flag4 <> FILEIO.MakePath(fileName, text2, text3, text4, text) Then
					GoTo IL_7B
				End If
				IL_76:
				GoTo IL_446
				IL_7B:
				num2 = 13
				If flag2 <> FILEUTIL.FileExists(fileName) Then
					GoTo IL_8F
				End If
				IL_8A:
				GoTo IL_446
				IL_8F:
				num2 = 16
				Dim num3 As Integer = FileSystem.FreeFile()
				IL_99:
				num2 = 17
				FileSystem.FileOpen(num3, fileName, OpenMode.Input, OpenAccess.Read, OpenShare.LockWrite, -1)
				IL_A9:
				num2 = 18
				Dim num4 As Integer
				FileSystem.Input(num3, num4)
				IL_B5:
				num2 = 19
				Dim num5 As Integer = num4
				IL_BD:
				num2 = 22
				If num5 <> 1 Then
					GoTo IL_446
				End If
				IL_C9:
				num2 = 23
				Dim num6 As Integer
				FileSystem.Input(num3, num6)
				IL_D5:
				num2 = 24
				If num6 <= 0 Then
					GoTo IL_167
				End If
				IL_E0:
				num2 = 25
				Dim num13 As Integer
				Dim array As Double() = New Double(num6 - 1 + 1 - 1) {}
				IL_F0:
				num2 = 28
				Dim array2 As String() = New String(num6 - 1 + 1 - 1) {}
				IL_100:
				num2 = 31
				Dim array3 As String() = New String(num6 - 1 + 1 - 1) {}
				IL_110:
				num2 = 34
				Dim num7 As Integer = 0
				Dim num8 As Integer = num6 - 1
				For i As Integer = num7 To num8
					IL_11E:
					num2 = 35
					FileSystem.Input(num3, array(i))
					IL_131:
					num2 = 36
					FileSystem.Input(num3, array3(i))
					IL_144:
					num2 = 37
					FileSystem.Input(num3, array2(i))
					IL_157:
					num2 = 38
				Next
				IL_167:
				num2 = 40
				flag = True
				IL_16D:
				num2 = 41
				iCount = num6
				IL_174:
				num2 = 42
				Dim dataSet As DataSet = RSWIN_DESC.mdsDeviationProfile
				IL_17F:
				num2 = 43
				Dim num9 As Integer = 0
				Dim num10 As Integer = num6 - 1
				For i As Integer = num9 To num10
					IL_190:
					num2 = 44
					Dim dataRow As DataRow = dataSet.Tables(0).NewRow()
					IL_1A8:
					num2 = 45
					dataRow("EntryNumber") = i + 1
					IL_1C1:
					num2 = 46
					dataRow("Depth") = array(i)
					IL_1DB:
					num2 = 47
					dataRow("Inclination") = Util.CheckDec(array3(i))
					IL_1F5:
					num2 = 48
					dataRow("Azimuth") = Util.CheckDec(array2(i))
					IL_20F:
					num2 = 49
					dataRow("Dogleg") = DBNull.Value
					IL_224:
					num2 = 50
					dataRow("TVDepth") = DBNull.Value
					IL_239:
					num2 = 51
					dataRow("NorthSouth") = DBNull.Value
					IL_24E:
					num2 = 52
					dataRow("EastWest") = DBNull.Value
					IL_263:
					num2 = 53
					If Conversions.ToBoolean(Operators.AndObject(i + 1 = 1, Operators.NotObject(Operators.CompareObjectEqual(dataRow("Depth"), 0, False)))) Then
						IL_29F:
						num2 = 54
						Dim num11 As Single = Conversions.ToSingle(dataRow("Depth"))
						IL_2B6:
						num2 = 55
						Dim value As String = Conversions.ToString(dataRow("Inclination"))
						IL_2CD:
						num2 = 56
						Dim value2 As String = Conversions.ToString(dataRow("Azimuth"))
						IL_2E4:
						num2 = 57
						dataRow("Depth") = 0
						IL_2FA:
						num2 = 58
						dataRow("Inclination") = "0"
						IL_30F:
						num2 = 59
						dataRow("Azimuth") = "0"
						IL_324:
						num2 = 60
						RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Add(dataRow)
						IL_344:
						num2 = 61
						i += 1
						IL_34E:
						num2 = 62
						dataSet.Tables(0).Rows.Add(dataRow)
						IL_36B:
						num2 = 63
						dataRow("EntryNumber") = i + 1
						IL_384:
						num2 = 64
						dataRow("Depth") = num11
						IL_39B:
						num2 = 65
						dataRow("Inclination") = value
						IL_3AD:
						num2 = 66
						dataRow("Azimuth") = value2
						IL_3BF:
						num2 = 67
						dataRow("Dogleg") = DBNull.Value
						IL_3D4:
						num2 = 68
						dataRow("TVDepth") = DBNull.Value
						IL_3E9:
						num2 = 69
						dataRow("NorthSouth") = DBNull.Value
						IL_3FE:
						num2 = 70
						dataRow("EastWest") = DBNull.Value
					End If
					IL_413:
					num2 = 72
					dataSet.Tables(0).Rows.Add(dataRow)
					IL_430:
					num2 = 73
				Next
				IL_443:
				dataSet = Nothing
				IL_446:
				num2 = 77
				LOADRST.DeleteTempDeviationFile()
				IL_44F:
				num2 = 78
				FileSystem.FileClose(New Integer() { num3 })
				IL_467:
				num2 = 79
				flag5 = flag
				IL_46E:
				GoTo IL_634
				IL_473:
				num2 = 81
				ProjectData.ClearProjectError()
				If num12 <> 0 Then
					GoTo IL_490
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_48B:
				GoTo IL_634
				IL_490:
				num13 = num12
				GoTo IL_498
				IL_494:
				num13 = num12 + 1
				IL_498:
				num12 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num13)
				IL_5EC:
				GoTo IL_629
				IL_5EE:
				num12 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_605:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num12 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_5EE
			End Try
			IL_629:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_634:
			Dim result As Boolean = flag5
			If num12 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub DeleteTempDeviationFile()
			Try
				Dim str As String = "temp.deviationprofile"
				Dim str2 As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\" + VERSION1.ProgramName()
				Dim pathName As String = str2 + "\" + str
				If FILEUTIL.FileExists(pathName) Then
					FileSystem.Kill(pathName)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function LoadTempDeviationProfile(ByRef sWellName As String, bNewCase As Boolean) As Boolean
			Dim flag As Boolean = True
			sWellName = ""
			Dim result As Boolean
			Try
				Dim str As String = "temp.deviationprofile"
				Dim str2 As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\" + VERSION1.ProgramName()
				Dim fileName As String = str2 + "\" + str
				If Not FILEUTIL.FileExists(fileName) Then
					result = False
				Else
					Dim flag2 As Boolean = False
					Dim num As Integer = FileSystem.FreeFile()
					FileSystem.FileOpen(num, fileName, OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
					Dim num2 As Integer
					FileSystem.Input(num, num2)
					Dim num3 As Integer = num2
					If num3 = 1 Then
						Dim num4 As Integer
						FileSystem.Input(num, num4)
						Dim array As Double()
						Dim array2 As String()
						Dim array3 As String()
						If num4 > 0 Then
							array = New Double(num4 - 1 + 1 - 1) {}
							array2 = New String(num4 - 1 + 1 - 1) {}
							array3 = New String(num4 - 1 + 1 - 1) {}
							Dim num5 As Integer = 0
							Dim num6 As Integer = num4 - 1
							For i As Integer = num5 To num6
								FileSystem.Input(num, array(i))
								FileSystem.Input(num, array3(i))
								FileSystem.Input(num, array2(i))
							Next
						End If
						Try
							FileSystem.Input(num, sWellName)
						Catch ex As Exception
						End Try
						flag2 = True
						If bNewCase And num4 > 1 And RSWIN_DESC.bRodStarD And RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count <= 2 Then
							If Not RSWIN_DESC.bNewCaseAsked Then
								Dim msg As String = "Load previously used deviation profile survey?"
								Dim bDefaultYes As Boolean = False
								Dim flag3 As Boolean = False
								flag = Util.YesNo(msg, bDefaultYes, flag3)
								RSWIN_DESC.bNewCaseAsked = True
							Else
								flag = False
							End If
						End If
						If flag And num4 > 1 Then
							MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
							Dim mdsDeviationProfile As DataSet = RSWIN_DESC.mdsDeviationProfile
							Dim num7 As Integer = 0
							Dim num8 As Integer = num4 - 1
							For i As Integer = num7 To num8
								Dim dataRow As DataRow = RSWIN_DESC.mdsDeviationProfile.Tables(0).NewRow()
								dataRow("EntryNumber") = i + 1
								dataRow("Depth") = array(i)
								dataRow("Inclination") = Util.CheckDec(array3(i))
								dataRow("Azimuth") = Util.CheckDec(array2(i))
								dataRow("Dogleg") = DBNull.Value
								dataRow("TVDepth") = DBNull.Value
								dataRow("NorthSouth") = DBNull.Value
								dataRow("EastWest") = DBNull.Value
								mdsDeviationProfile.Tables(0).Rows.Add(dataRow)
							Next
						End If
					End If
					FileSystem.FileClose(New Integer() { num })
					result = flag2
				End If
			Catch ex2 As Exception
				Try
					If flag Then
						Dim num As Integer
						FileSystem.FileClose(New Integer() { num })
					End If
					result = False
					ProjectData.ClearProjectError()
				Catch ex3 As Exception
				End Try
			End Try
			Return result
		End Function

		Private Function LoadInputData(frn As Short, ThisVersion As Short, ByRef bInputChanged As Boolean) As Boolean
			Dim text As String = New String(" "c, 40)
			Dim rodType As String = New String(" "c, 20)
			Dim result As Boolean = False
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				cRODSTAR.ACompanyName = text
				cRODSTAR.WellName = text
				cRODSTAR.UserName = text
				cRODSTAR.UserDate = text
				Dim cRODSTAR2 As cRODSTAR = cRODSTAR
				Dim text2 As String = cRODSTAR2.ACompanyName
				FileSystem.FileGet(CInt(frn), text2, -1L, False)
				cRODSTAR2.ACompanyName = text2
				cRODSTAR2 = cRODSTAR
				text2 = cRODSTAR2.WellName
				FileSystem.FileGet(CInt(frn), text2, -1L, False)
				cRODSTAR2.WellName = text2
				cRODSTAR2 = cRODSTAR
				text2 = cRODSTAR2.UserName
				FileSystem.FileGet(CInt(frn), text2, -1L, False)
				cRODSTAR2.UserName = text2
				cRODSTAR2 = cRODSTAR
				text2 = cRODSTAR2.UserDate
				FileSystem.FileGet(CInt(frn), text2, -1L, False)
				cRODSTAR2.UserDate = text2
				cRODSTAR2 = cRODSTAR
				Dim num As Short = cRODSTAR2.PumpCondition
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.PumpCondition = num
				cRODSTAR2 = cRODSTAR
				Dim num2 As Single = cRODSTAR2.PumpEfficiency
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.PumpEfficiency = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.PumpFillage
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.PumpFillage = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.PumpDepth
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.PumpDepth = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.FluidLevel
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.FluidLevel = num2
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.SPMEntered
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.SPMEntered = num
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.SPM
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.SPM = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.TargetBFPD
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.TargetBFPD = num2
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.PumpType
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.PumpType = num
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.PlungerSize
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.PlungerSize = num2
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.CalcPlungerSize
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.CalcPlungerSize = num
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.FluidSPGR
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.FluidSPGR = num2
				If ThisVersion < 8S Then
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.Friction
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.Friction = num2
					cRODSTAR.UpstrokeFriction = cRODSTAR.Friction
					cRODSTAR.DownstrokeFriction = cRODSTAR.Friction
				End If
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.CalcFriction
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.CalcFriction = num
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.IncludeFluidInertia
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.IncludeFluidInertia = num
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.CompressibilityIndex
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.CompressibilityIndex = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.TubingOD
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.TubingOD = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.TubingID
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.TubingID = num2
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.TubingAnchored
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.TubingAnchored = num
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.TubingAnchorDepth
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.TubingAnchorDepth = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.TubingPressure
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.TubingPressure = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.CasingPressure
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.CasingPressure = num2
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.RodStringType
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.RodStringType = num
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.APIRod
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.APIRod = num
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.APIGrade
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.APIGrade = num
				Dim rodSection As RSWIN_DESC.RodSection
				If cRODSTAR.RodStringType = 1S Then
					cRODSTAR.RodStringType = 2S
					rodSection.Grade = cRODSTAR.APIGrade
					If RODUTIL.ConvertRodGrade(rodSection) <> 0 Then
						cRODSTAR.APIGrade = rodSection.Grade
						bInputChanged = True
					End If
				End If
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.NumRods
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.NumRods = num
				RSWIN_DESC.rst.bHasFGlass = False
				RSWIN_DESC.rst.bHasRR = False
				Dim num3 As Short = 1S
				Dim numRods As Short = cRODSTAR.NumRods
				Dim num5 As Single
				For num4 As Short = num3 To numRods
					FileSystem.FileGet(CInt(frn), cRODSTAR.Sections(CInt(num4)).Grade, -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.Sections(CInt(num4)).Diameter, -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.Sections(CInt(num4)).length, -1L)
					If ThisVersion < 12S Then
						FileSystem.FileGet(CInt(frn), num5, -1L)
					End If
					FileSystem.FileGet(CInt(frn), cRODSTAR.Sections(CInt(num4)).SuckerRodLength, -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.Sections(CInt(num4)).RodDensity, -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.Sections(CInt(num4)).RodWeight, -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.Sections(CInt(num4)).Elasticity, -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.Sections(CInt(num4)).Area, -1L)
					If RODUTIL.ConvertRodGrade(cRODSTAR.Sections(CInt(num4))) <> 0 Then
						bInputChanged = True
					End If
					If ThisVersion >= 9S Then
						cRODSTAR.Sections(CInt(num4)).RodType = rodType
						FileSystem.FileGet(CInt(frn), cRODSTAR.Sections(CInt(num4)).RodType, -1L, False)
						FileSystem.FileGet(CInt(frn), cRODSTAR.Sections(CInt(num4)).TensileStrength, -1L)
					Else
						cRODSTAR.Sections(CInt(num4)).RodType = rodType
						cRODSTAR.Sections(CInt(num4)).RodType = RODUTIL.RodGrade(cRODSTAR.Sections(CInt(num4)).Grade)
						RODUTIL.LookupTensileStrength(cRODSTAR.Sections(CInt(num4)))
					End If
					If ThisVersion < 12S Then
						If(If((-If((RODUTIL.IsCorod(cRODSTAR.Sections(CInt(num4)).Grade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(cRODSTAR.Sections(CInt(num4)).Grade))) <> 0 Then
							cRODSTAR.Sections(CInt(num4)).SuckerRodLength = 1F
						ElseIf RODUTIL.IsSteel(CInt(cRODSTAR.Sections(CInt(num4)).Grade)) <> 0 Then
							cRODSTAR.Sections(CInt(num4)).SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
						ElseIf cRODSTAR.Sections(CInt(num4)).Grade <> 16385S And cRODSTAR.Sections(CInt(num4)).Grade <> 16389S And cRODSTAR.Sections(CInt(num4)).Grade <> 16390S Then
							cRODSTAR.Sections(CInt(num4)).SuckerRodLength = 37.5F
						End If
					End If
					If cRODSTAR.Sections(CInt(num4)).Grade = 4096S Then
						If ThisVersion >= 20S Then
							FileSystem.FileGet(CInt(frn), cRODSTAR.Sections(CInt(num4)).StressMethod, -1L)
						Else
							cRODSTAR.Sections(CInt(num4)).StressMethod = 0S
						End If
					End If
					If ThisVersion > 29S Then
						FileSystem.FileGet(CInt(frn), cRODSTAR.Sections(CInt(num4)).Guide, -1L)
					End If
					If ThisVersion > 29S Then
						Dim num6 As Single
						FileSystem.FileGet(CInt(frn), num6, -1L)
						FileSystem.FileGet(CInt(frn), num6, -1L)
						FileSystem.FileGet(CInt(frn), num6, -1L)
					End If
					Try
						cRODSTAR.Sections(CInt(num4)).Guide = RSWIN_DESC.MOLDED
						cRODSTAR.Sections(CInt(num4)).friction_coef = 0.2F
					Catch ex As Exception
					End Try
					If RODUTIL.IsRibbonRod(cRODSTAR.Sections(CInt(num4)).Grade) Then
						RSWIN_DESC.rst.bHasRR = True
					ElseIf RODUTIL.IsFG(cRODSTAR.Sections(CInt(num4)).Grade) Then
						RSWIN_DESC.rst.bHasFGlass = True
					End If
					Debug.WriteLine(cRODSTAR.Sections(CInt(num4)).Grade)
					Debug.WriteLine(cRODSTAR.Sections(CInt(num4)).Diameter)
					Debug.WriteLine(cRODSTAR.Sections(CInt(num4)).length)
					Debug.WriteLine(cRODSTAR.Sections(CInt(num4)).SuckerRodLength)
					Debug.WriteLine(cRODSTAR.Sections(CInt(num4)).RodDensity)
					Debug.WriteLine(cRODSTAR.Sections(CInt(num4)).RodWeight)
					Debug.WriteLine(cRODSTAR.Sections(CInt(num4)).Elasticity)
					Debug.WriteLine(cRODSTAR.Sections(CInt(num4)).Area)
					Debug.WriteLine(cRODSTAR.Sections(CInt(num4)).RodType)
					Debug.WriteLine(cRODSTAR.Sections(CInt(num4)).TensileStrength)
					Debug.WriteLine(cRODSTAR.Sections(CInt(num4)).StressMethod)
				Next
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.RSGrade
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.RSGrade = num
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.RSSuckerRodLength
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.RSSuckerRodLength = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.RSMaxSize
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.RSMaxSize = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.RSMinSize
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.RSMinSize = num2
				Debug.WriteLine(cRODSTAR.RSGrade)
				Debug.WriteLine(cRODSTAR.RSSuckerRodLength)
				Debug.WriteLine(cRODSTAR.RSMaxSize)
				Debug.WriteLine(cRODSTAR.RSMinSize)
				If cRODSTAR.RodStringType = 3S Then
					If cRODSTAR.RSGrade = -1S And ThisVersion <= 17S Then
						cRODSTAR.RSFGIncludeSteel = 0S
						cRODSTAR.gbSteelRodString = False
						cRODSTAR.giRodDesignStyle = 1S
					End If
					rodSection.Grade = cRODSTAR.RSGrade
					rodSection.Diameter = 0F
					rodSection.SuckerRodLength = cRODSTAR.RSSuckerRodLength
					If RODUTIL.ConvertRodGrade(rodSection) <> 0 Then
						rodSection.Grade = cRODSTAR.RSGrade
						rodSection.Diameter = cRODSTAR.RSMaxSize
						rodSection.SuckerRodLength = cRODSTAR.RSSuckerRodLength
						If RODUTIL.ConvertRodGrade(rodSection) <> 0 Then
							cRODSTAR.RSMaxSize = rodSection.Diameter
						End If
						rodSection.Grade = cRODSTAR.RSGrade
						rodSection.Diameter = cRODSTAR.RSMinSize
						rodSection.SuckerRodLength = cRODSTAR.RSSuckerRodLength
						If RODUTIL.ConvertRodGrade(rodSection) <> 0 Then
							cRODSTAR.RSMinSize = rodSection.Diameter
						End If
						rodSection.Grade = cRODSTAR.RSGrade
						rodSection.Diameter = 0F
						rodSection.SuckerRodLength = cRODSTAR.RSSuckerRodLength
						If RODUTIL.ConvertRodGrade(rodSection) <> 0 Then
							cRODSTAR.RSGrade = rodSection.Grade
						End If
						bInputChanged = True
					End If
				End If
				Dim sinkerBar As RSWIN_DESC.RodSection
				sinkerBar.Initialize()
				If ThisVersion < 7S Then
					FileSystem.FileGet(CInt(frn), sinkerBar.Diameter, -1L)
					FileSystem.FileGet(CInt(frn), sinkerBar.Grade, -1L)
					If RODUTIL.ConvertRodGrade(sinkerBar) <> 0 Then
						bInputChanged = True
					Else
						sinkerBar.Area = CSng((Math.Pow(CDbl(sinkerBar.Diameter), 2.0) * 3.141592653589793 / 4.0))
						sinkerBar.Elasticity = 30500000F
						sinkerBar.RodDensity = 491F
						sinkerBar.RodType = rodType
						sinkerBar.RodType = RODUTIL.RodGrade(sinkerBar.Grade)
						RODUTIL.LookupRodWeight(sinkerBar)
						RODUTIL.LookupTensileStrength(sinkerBar)
					End If
				End If
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.ServiceFactor
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.ServiceFactor = num2
				cRODSTAR2 = cRODSTAR
				text2 = cRODSTAR2.UnitID
				FileSystem.FileGet(CInt(frn), text2, -1L, False)
				cRODSTAR2.UnitID = text2
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.IDEntered
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.IDEntered = num
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				cRODSTAR.PU.Initialize()
				pu.Manuf = text
				pu.UnitName = text
				pu.APIDesignation = text
				pu.OtherInfo = text
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
				Dim num7 As Single
				If ThisVersion <= 13S Then
					FileSystem.FileGet(CInt(frn), num7, -1L)
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
				If ThisVersion < 10S Then
					Dim num8 As Single
					FileSystem.FileGet(CInt(frn), num8, -1L)
				End If
				cRODSTAR.PU = pu
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.ElectricityCost
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.ElectricityCost = num2
				If cRODSTAR.ElectricityCost = 0F Then
					Try
						Dim cRODSTAR3 As cRODSTAR = cRODSTAR
						Dim sDefaultName As String = "ElectricityCost"
						Dim vNotPresentDefault As Object = 0.06
						Dim flag As Boolean = False
						cRODSTAR3.ElectricityCost = Conversions.ToSingle(ini.GetDefault(sDefaultName, vNotPresentDefault, flag))
					Catch ex2 As Exception
					End Try
				End If
				cRODSTAR2 = cRODSTAR
				num = cRODSTAR2.PowerMeterType
				FileSystem.FileGet(CInt(frn), num, -1L)
				cRODSTAR2.PowerMeterType = num
				If ThisVersion < 10S Then
					FileSystem.FileGet(CInt(frn), num7, -1L)
				End If
				cRODSTAR2 = cRODSTAR
				Dim cRODSTAR4 As cRODSTAR = cRODSTAR2
				Dim index As Integer = 2
				num2 = cRODSTAR4.get_M(index)
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.set_M(index, num2)
				cRODSTAR.UnknownM = (cRODSTAR.get_M(2) = 0F)
				If ThisVersion < 5S Then
					Dim num9 As Single
					FileSystem.FileGet(CInt(frn), num9, -1L)
					Dim value As Single
					FileSystem.FileGet(CInt(frn), value, -1L)
					Select Case cRODSTAR.PU.UnitType
						Case 6S
							cRODSTAR.set_M(2, value)
							GoTo IL_1101
						Case 7S, 10S
							cRODSTAR.set_M(2, CSng((CDbl(num9) * 1000.0)))
							GoTo IL_1101
						Case 8S
							cRODSTAR.set_M(2, cRODSTAR.PU.M * 1000F)
							GoTo IL_1101
					End Select
					cRODSTAR.set_M(2, CSng((CDbl(cRODSTAR.get_M(2)) * 1000.0)))
				End If
				IL_1101:
				If ThisVersion >= 2S Then
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.MotorSPV
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.MotorSPV = num2
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.Iart
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.Iart = num2
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.Irot
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.Irot = num2
				Else
					cRODSTAR.MotorSPV = 0F
					cRODSTAR.Iart = cRODSTAR.PU.ArtInertia
					cRODSTAR.Irot = 0F
				End If
				If ThisVersion >= 3S Then
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.IrotEntered
					FileSystem.FileGet(CInt(frn), num, -1L)
					cRODSTAR2.IrotEntered = num
				Else
					cRODSTAR.IrotEntered = If((-If(((CDbl(cRODSTAR.MotorSPV) > 0.0 And CDbl(cRODSTAR.Irot) > 0.0) > False), 1S, 0S)), 1S, 0S)
				End If
				If ThisVersion >= 4S Then
					cRODSTAR2 = cRODSTAR
					Dim flag As Boolean = cRODSTAR2.FluidLevelEntered
					FileSystem.FileGet(CInt(frn), flag, -1L)
					cRODSTAR2.FluidLevelEntered = flag
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.PumpIntakePressure
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.PumpIntakePressure = num2
				Else
					cRODSTAR.FluidLevelEntered = True
				End If
				If ThisVersion >= 6S Then
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.Runtime
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.Runtime = num2
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.WaterCut
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.WaterCut = num2
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.OilAPI
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.OilAPI = num2
				Else
					cRODSTAR.Runtime = 24F
					cRODSTAR.WaterCut = 0F
					cRODSTAR.OilAPI = 30F
				End If
				If ThisVersion >= 7S Then
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.RSIncludeSB
					FileSystem.FileGet(CInt(frn), num, -1L)
					cRODSTAR2.RSIncludeSB = num
					sinkerBar.Initialize()
					FileSystem.FileGet(CInt(frn), sinkerBar.Grade, -1L)
					FileSystem.FileGet(CInt(frn), sinkerBar.Diameter, -1L)
					FileSystem.FileGet(CInt(frn), sinkerBar.length, -1L)
					If cRODSTAR.RSIncludeSB <> 0S AndAlso RODUTIL.ConvertRodGrade(sinkerBar) <> 0 Then
						bInputChanged = True
					End If
					If ThisVersion < 12S Then
						FileSystem.FileGet(CInt(frn), num5, -1L)
					End If
					FileSystem.FileGet(CInt(frn), sinkerBar.SuckerRodLength, -1L)
					FileSystem.FileGet(CInt(frn), sinkerBar.RodDensity, -1L)
					FileSystem.FileGet(CInt(frn), sinkerBar.RodWeight, -1L)
					FileSystem.FileGet(CInt(frn), sinkerBar.Elasticity, -1L)
					FileSystem.FileGet(CInt(frn), sinkerBar.Area, -1L)
					If ThisVersion >= 9S Then
						sinkerBar.RodType = rodType
						FileSystem.FileGet(CInt(frn), sinkerBar.RodType, -1L, False)
						FileSystem.FileGet(CInt(frn), sinkerBar.TensileStrength, -1L)
					End If
					If ThisVersion < 9S Or sinkerBar.Area = 0F Or sinkerBar.Elasticity = 0F Or sinkerBar.RodDensity = 0F Or sinkerBar.RodWeight = 0F Then
						sinkerBar.Area = CSng((Math.Pow(CDbl(sinkerBar.Diameter), 2.0) * 3.141592653589793 / 4.0))
						sinkerBar.Elasticity = 30500000F
						sinkerBar.RodDensity = 491F
						sinkerBar.RodType = RODUTIL.RodGrade(sinkerBar.Grade)
						If sinkerBar.RodType IsNot Nothing Then
							RODUTIL.LookupRodWeight(sinkerBar)
							RODUTIL.LookupTensileStrength(sinkerBar)
						End If
					End If
					If sinkerBar.Grade = 4096S Then
						If ThisVersion >= 20S Then
							FileSystem.FileGet(CInt(frn), sinkerBar.StressMethod, -1L)
						Else
							sinkerBar.StressMethod = 0S
						End If
					End If
				Else
					cRODSTAR.RSIncludeSB = 0S
				End If
				cRODSTAR.SinkerBar = sinkerBar
				If ThisVersion >= 8S Then
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.UpstrokeFriction
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.UpstrokeFriction = num2
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.DownstrokeFriction
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.DownstrokeFriction = num2
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.StuffingBoxFriction
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.StuffingBoxFriction = num2
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.PumpLoadAdj
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.PumpLoadAdj = num2
				Else
					cRODSTAR.StuffingBoxFriction = 100F
					cRODSTAR.PumpLoadAdj = 0F
				End If
				If ThisVersion >= 9S Then
					cRODSTAR2 = cRODSTAR
					text2 = cRODSTAR2.APIRodType
					FILEIO.GetString(frn, text2)
					cRODSTAR2.APIRodType = text2
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.APITensileStrength
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.APITensileStrength = num2
					cRODSTAR2 = cRODSTAR
					text2 = cRODSTAR2.RSRodType
					FILEIO.GetString(frn, text2)
					cRODSTAR2.RSRodType = text2
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.RSTensileStrength
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.RSTensileStrength = num2
				Else
					If cRODSTAR.RodStringType = 1S Then
						cRODSTAR.APIRodType = RODUTIL.RodGrade(cRODSTAR.APIGrade)
						rodSection.Grade = cRODSTAR.APIGrade
						RODUTIL.LookupTensileStrength(rodSection)
						cRODSTAR.APITensileStrength = rodSection.TensileStrength
					Else
						cRODSTAR.APIRodType = RSWIN_DESC.sNull
						cRODSTAR.APITensileStrength = 0F
					End If
					If cRODSTAR.RodStringType = 3S Then
						cRODSTAR.RSRodType = RODUTIL.RodGrade(cRODSTAR.RSGrade)
						rodSection.Grade = cRODSTAR.RSGrade
						RODUTIL.LookupTensileStrength(rodSection)
						cRODSTAR.RSTensileStrength = rodSection.TensileStrength
					Else
						cRODSTAR.RSRodType = RSWIN_DESC.sNull
						cRODSTAR.RSTensileStrength = 0F
					End If
				End If
				If ThisVersion >= 10S Then
					FileSystem.FileGet(CInt(frn), pu.OtherInfo, -1L, False)
				Else
					pu.OtherInfo = RSWIN_DESC.sNull
				End If
				cRODSTAR.PU = pu
				If ThisVersion >= 11S Then
					cRODSTAR2 = cRODSTAR
					text2 = cRODSTAR2.CBDataFile
					FILEIO.GetString(frn, text2)
					cRODSTAR2.CBDataFile = text2
				Else
					cRODSTAR.CBDataFile = RSWIN_DESC.sNull
				End If
				Dim iMotorType As Short
				Dim fMotorSize As Single
				Dim iTorqueMode As Short
				Dim sNull As String
				If ThisVersion >= 12S Then
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.CalcMotorSPV
					FileSystem.FileGet(CInt(frn), num, -1L)
					cRODSTAR2.CalcMotorSPV = num
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.CalcMotorSize
					FileSystem.FileGet(CInt(frn), num, -1L)
					cRODSTAR2.CalcMotorSize = num
					If ThisVersion < 25S Then
						FileSystem.FileGet(CInt(frn), iMotorType, -1L)
						FileSystem.FileGet(CInt(frn), fMotorSize, -1L)
						FileSystem.FileGet(CInt(frn), iTorqueMode, -1L)
						FILEIO.GetString(frn, sNull)
					End If
				Else
					cRODSTAR.CalcMotorSPV = 0S
					cRODSTAR.CalcMotorSize = -1S
					iMotorType = 1S
					fMotorSize = 50F
					iTorqueMode = 1S
					sNull = RSWIN_DESC.sNull
				End If
				If ThisVersion >= 13S Then
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.WaterSPGR
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.WaterSPGR = num2
					If cRODSTAR.WaterSPGR < 1F Then
						cRODSTAR.WaterSPGR = 1F
					ElseIf CDbl(cRODSTAR.WaterSPGR) > 1.5 Then
						cRODSTAR.WaterSPGR = 1.5F
					End If
				Else
					cRODSTAR.WaterSPGR = 1F
				End If
				If ThisVersion >= 14S Then
					cRODSTAR2 = cRODSTAR
					Dim flag As Boolean = cRODSTAR2.gbRoddiagFile
					FileSystem.FileGet(CInt(frn), flag, -1L)
					cRODSTAR2.gbRoddiagFile = flag
					If cRODSTAR.gbRoddiagFile Then
						cRODSTAR2 = cRODSTAR
						num = cRODSTAR2.RDNtsteps
						FileSystem.FileGet(CInt(frn), num, -1L)
						cRODSTAR2.RDNtsteps = num
						Dim array As Single() = New Single(CInt((cRODSTAR.RDNtsteps - 1S + 1S)) - 1) {}
						cRODSTAR.RDSurfPos = array
						array = New Single(CInt((cRODSTAR.RDNtsteps - 1S + 1S)) - 1) {}
						cRODSTAR.RDSurfLoad = array
						If cRODSTAR.RDNtsteps > 0S Then
							Dim num10 As Short = 0S
							Dim num11 As Short = cRODSTAR.RDNtsteps - 1S
							For num4 As Short = num10 To num11
								FileSystem.FileGet(CInt(frn), cRODSTAR.RDSurfPos(CInt(num4)), -1L)
								FileSystem.FileGet(CInt(frn), cRODSTAR.RDSurfLoad(CInt(num4)), -1L)
							Next
						Else
							cRODSTAR.gbRoddiagFile = False
						End If
					Else
						cRODSTAR.gbRoddiagFile = False
					End If
				End If
				If ThisVersion >= 17S Then
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.RSExtraCost
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.RSExtraCost = num2
					cRODSTAR2 = cRODSTAR
					text2 = cRODSTAR2.RSExtraCostLabel
					FILEIO.GetString(frn, text2)
					cRODSTAR2.RSExtraCostLabel = text2
				Else
					cRODSTAR.RSExtraCost = 0F
					cRODSTAR.RSExtraCostLabel = ""
				End If
				If ThisVersion >= 18S Then
					cRODSTAR2 = cRODSTAR
					Dim flag As Boolean = cRODSTAR2.gbSteelRodString
					FileSystem.FileGet(CInt(frn), flag, -1L)
					cRODSTAR2.gbSteelRodString = flag
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.RSFGGrade
					FileSystem.FileGet(CInt(frn), num, -1L)
					cRODSTAR2.RSFGGrade = num
					rodSection.Grade = cRODSTAR.RSFGGrade
					rodSection.Diameter = 0F
					rodSection.SuckerRodLength = cRODSTAR.RSSuckerRodLength
					If RODUTIL.ConvertRodGrade(rodSection) <> 0 Then
						cRODSTAR.RSFGGrade = rodSection.Grade
					End If
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.RSFGIncludeSteel
					FileSystem.FileGet(CInt(frn), num, -1L)
					cRODSTAR2.RSFGIncludeSteel = num
					cRODSTAR2 = cRODSTAR
					flag = cRODSTAR2.gbUseIPR
					FileSystem.FileGet(CInt(frn), flag, -1L)
					cRODSTAR2.gbUseIPR = flag
					cRODSTAR2 = cRODSTAR
					flag = cRODSTAR2.gbCalcTargetBFPD
					FileSystem.FileGet(CInt(frn), flag, -1L)
					cRODSTAR2.gbCalcTargetBFPD = flag
					cRODSTAR2 = cRODSTAR
					flag = cRODSTAR2.gbCalcPumpCondition
					FileSystem.FileGet(CInt(frn), flag, -1L)
					cRODSTAR2.gbCalcPumpCondition = flag
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.giIPRMethod
					FileSystem.FileGet(CInt(frn), num, -1L)
					cRODSTAR2.giIPRMethod = num
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.MidPerfDepth
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.MidPerfDepth = num2
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.StaticBHPressure
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.StaticBHPressure = num2
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.BubblePoint
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.BubblePoint = num2
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.gnTestPoints
					FileSystem.FileGet(CInt(frn), num, -1L)
					cRODSTAR2.gnTestPoints = num
					If cRODSTAR.gnTestPoints = 0S Then
						Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(0) {}
						cRODSTAR.TestPoints = testPoints
					Else
						' The following expression was wrapped in a checked-expression
						Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(CInt((cRODSTAR.gnTestPoints + 1S)) - 1) {}
						cRODSTAR.TestPoints = testPoints
					End If
					Dim num12 As Short = 1S
					Dim gnTestPoints As Short = cRODSTAR.gnTestPoints
					For num4 As Short = num12 To gnTestPoints
						FileSystem.FileGet(CInt(frn), cRODSTAR.TestPoints(CInt(num4)).bPIEntered, -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.TestPoints(CInt(num4)).Pintake, -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.TestPoints(CInt(num4)).Pwf, -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.TestPoints(CInt(num4)).Production, -1L)
					Next
					If Not cRODSTAR.gbUseIPR Then
						cRODSTAR.giIPRMethod = -1S
						cRODSTAR.MidPerfDepth = -1F
						cRODSTAR.StaticBHPressure = -1F
						cRODSTAR.BubblePoint = -1F
						cRODSTAR.gnTestPoints = 0S
						Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(0) {}
						cRODSTAR.TestPoints = testPoints
					End If
				Else
					If cRODSTAR.RodStringType = 3S Then
						If Not RODUTIL.IsFG(cRODSTAR.RSGrade) And cRODSTAR.RSGrade > 0S Then
							cRODSTAR.gbSteelRodString = True
						Else
							cRODSTAR.gbSteelRodString = False
							cRODSTAR.RSFGGrade = cRODSTAR.RSGrade
							cRODSTAR.RSFGIncludeSteel = 0S
							cRODSTAR.RSIncludeSB = -1S
						End If
					End If
					cRODSTAR.gbCalcTargetBFPD = False
					cRODSTAR.gbCalcPumpCondition = False
					cRODSTAR.gbUseIPR = False
					cRODSTAR.giIPRMethod = -1S
					cRODSTAR.MidPerfDepth = -1F
					cRODSTAR.StaticBHPressure = -1F
					cRODSTAR.BubblePoint = -1F
					cRODSTAR.gnTestPoints = 0S
					Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(0) {}
					cRODSTAR.TestPoints = testPoints
				End If
				If ThisVersion >= 19S Then
					cRODSTAR2 = cRODSTAR
					Dim flag As Boolean = cRODSTAR2.gbProducingBelowBPP
					FileSystem.FileGet(CInt(frn), flag, -1L)
					cRODSTAR2.gbProducingBelowBPP = flag
					If Not cRODSTAR.gbUseIPR Then
						cRODSTAR.gbProducingBelowBPP = False
					End If
				Else
					cRODSTAR.gbProducingBelowBPP = False
				End If
				If ThisVersion >= 22S Then
					cRODSTAR2 = cRODSTAR
					num = cRODSTAR2.giRodDesignStyle
					FileSystem.FileGet(CInt(frn), num, -1L)
					cRODSTAR2.giRodDesignStyle = num
					cRODSTAR2 = cRODSTAR
					Dim flag As Boolean = cRODSTAR2.gbCalcFetkovichN
					FileSystem.FileGet(CInt(frn), flag, -1L)
					cRODSTAR2.gbCalcFetkovichN = flag
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.FetkovichN
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.FetkovichN = num2
					If cRODSTAR.giIPRMethod <> 0S Then
						cRODSTAR.gbCalcFetkovichN = True
					End If
				Else
					If cRODSTAR.gbSteelRodString Then
						cRODSTAR.giRodDesignStyle = 0S
					Else
						cRODSTAR.giRodDesignStyle = 1S
					End If
					cRODSTAR.gbCalcFetkovichN = True
					cRODSTAR.FetkovichN = -1F
				End If
				If ThisVersion >= 23S Then
					cRODSTAR2 = cRODSTAR
					text2 = cRODSTAR2.FileComment
					FILEIO.GetString(frn, text2)
					cRODSTAR2.FileComment = text2
				Else
					cRODSTAR.FileComment = RSWIN_DESC.sNull
				End If
				If ThisVersion >= 24S Then
					cRODSTAR2 = cRODSTAR
					Dim flag As Boolean = cRODSTAR2.gbCalcPumpIntakePressure
					FileSystem.FileGet(CInt(frn), flag, -1L)
					cRODSTAR2.gbCalcPumpIntakePressure = flag
				Else
					cRODSTAR.gbCalcPumpIntakePressure = False
				End If
				If ThisVersion >= 25S Then
					Motor.ReadMotorData(CInt(frn))
				Else
					Select Case iMotorType
						Case 1S, 2S, 3S, 4S, 7S, 8S, 9S, 10S, 11S, 12S, 13S
							GoTo IL_1E59
					End Select
					iMotorType = 1S
					cRODSTAR.CalcMotorSize = -1S
					IL_1E59:
					Motor.SelectMotorFromOldInfo(CInt(iMotorType), fMotorSize, sNull, CInt(iTorqueMode))
				End If
				If ThisVersion >= 27S Then
					cRODSTAR2 = cRODSTAR
					num2 = cRODSTAR2.PumpFriction
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.PumpFriction = num2
				Else
					cRODSTAR.PumpFriction = 200F
				End If
				If ThisVersion >= 28S Then
					cRODSTAR2 = cRODSTAR
					Dim flag As Boolean = cRODSTAR2.gbIncludeBuoyancy
					FileSystem.FileGet(CInt(frn), flag, -1L)
					cRODSTAR2.gbIncludeBuoyancy = flag
				Else
					cRODSTAR.gbIncludeBuoyancy = False
				End If
				If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
					If ThisVersion >= 29S Then
						Try
							cRODSTAR2 = cRODSTAR
							Dim flag As Boolean = cRODSTAR2.bUnknownUnbalance
							FileSystem.FileGet(CInt(frn), flag, -1L)
							cRODSTAR2.bUnknownUnbalance = flag
							GoTo IL_1F2C
						Catch ex3 As Exception
							cRODSTAR.bUnknownUnbalance = True
							GoTo IL_1F2C
						End Try
					End If
					cRODSTAR.bUnknownUnbalance = True
				End If
				IL_1F2C:
				If RSWIN_DESC.bRodStarD AndAlso Not RSWIN_DESC.rst.bHasRR Then
					RSWIN_DESC.rst.Friction = 0.2F
					RSWIN_DESC.rst.DownstrokeFriction = 0.1F
					RSWIN_DESC.rst.UpstrokeFriction = 0.1F
				End If
				RSWIN_DESC.rst.DownstrokeFrictionFactor = 1F
				RSWIN_DESC.rst.UpstrokeFrictionFactor = 1F
				RSWIN_DESC.rst.SlideFricCoeff = 0.2F
				RSWIN_DESC.rst.gbCalcFluidSPGR = False
				result = True
				If RSWIN_DESC.rst.WaterSPGR < 1F Then
					RSWIN_DESC.rst.WaterSPGR = 1F
				ElseIf CDbl(RSWIN_DESC.rst.WaterSPGR) > 1.5 Then
					RSWIN_DESC.rst.WaterSPGR = 1.5F
				End If
				cRODSTAR = Nothing
			Catch ex4 As Exception
				MessageBox.Show("Input is not in the correct format!", "Error reading file!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				result = False
			End Try
			Return result
		End Function

		Private Sub LoadOutputData(frn As Short, ThisVersion As Short, ByRef bOutputLoaded As Boolean)
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			Try
				bOutputLoaded = False
				cRODSTAR.gbOutputLoaded = False
				If ThisVersion < 16S Then
					bOutputLoaded = True
					Return
				End If
				Dim num5 As Short
				Dim num As Integer = CInt(FileSystem.Seek(CInt(frn)))
				FileSystem.Seek(CInt(frn), FileSystem.LOF(CInt(frn)) - 1L)
				Dim flag As Boolean
				FileSystem.FileGet(CInt(frn), flag, -1L)
				If Not flag Then
					bOutputLoaded = True
					Return
				End If
				FileSystem.Seek(CInt(frn), CLng(num))
				Dim cRODSTAR2 As cRODSTAR = cRODSTAR
				Dim num2 As Single = cRODSTAR2.BPDsurface
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.BPDsurface = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.FluidLoad
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.FluidLoad = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.FoSkr
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.FoSkr = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.GrossPumpStroke
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.GrossPumpStroke = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.MaxRodStressL
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.MaxRodStressL = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.MinMotorHP
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.MinMotorHP = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.Mprload
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.Mprload = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.NoverNoP
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.NoverNoP = num2
				cRODSTAR2 = cRODSTAR
				Dim num3 As Short = cRODSTAR2.Ntsteps
				FileSystem.FileGet(CInt(frn), num3, -1L)
				cRODSTAR2.Ntsteps = num3
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.Pfill
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.Pfill = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.PlungerLength
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.PlungerLength = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.Pprload
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.Pprload = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.Prhp
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.Prhp = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.ProductionLoss
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.ProductionLoss = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.PumpLength
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.PumpLength = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.PumpSpacing
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.PumpSpacing = num2
				cRODSTAR2 = cRODSTAR
				Dim num4 As Integer = cRODSTAR2.StartDownstroke
				FileSystem.FileGet(CInt(frn), num4, -1L)
				cRODSTAR2.StartDownstroke = num4
				cRODSTAR2 = cRODSTAR
				num4 = cRODSTAR2.StartUpstroke
				FileSystem.FileGet(CInt(frn), num4, -1L)
				cRODSTAR2.StartUpstroke = num4
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.StructL
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.StructL = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.SystemEff
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.SystemEff = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.TotalTheta
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.TotalTheta = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.TubStretch
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.TubStretch = num2
				cRODSTAR2 = cRODSTAR
				num2 = cRODSTAR2.WrodsInFluid
				FileSystem.FileGet(CInt(frn), num2, -1L)
				cRODSTAR2.WrodsInFluid = num2
				Dim tnet As Single(,) = New Single(2, CInt((cRODSTAR.Ntsteps + 1S)) - 1) {}
				cRODSTAR.Tnet = tnet
				num5 = 0S
				Do
					FileSystem.FileGet(CInt(frn), cRODSTAR.CBE90(CInt(num5)), -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.Clf(CInt(num5)), -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.DollarsPerBblFluid(CInt(num5)), -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.DollarsPerBblOil(CInt(num5)), -1L)
					Dim cRODSTAR2 As cRODSTAR = cRODSTAR
					Dim cRODSTAR3 As cRODSTAR = cRODSTAR2
					Dim num3 As Short = num5
					Dim num2 As Single = cRODSTAR3.get_ElectricBillperMonth(CInt(num3))
					FileSystem.FileGet(CInt(frn), num2, -1L)
					cRODSTAR2.set_ElectricBillperMonth(CInt(num3), num2)
					FileSystem.FileGet(CInt(frn), cRODSTAR.GearboxLoading(CInt(num5)), -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.HpNemaD(CInt(num5)), -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.HpUhs(CInt(num5)), -1L)
					If(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And ThisVersion >= 29S Then
						cRODSTAR2 = cRODSTAR
						Dim cRODSTAR4 As cRODSTAR = cRODSTAR2
						num3 = num5
						num2 = cRODSTAR4.get_RequiredUnbalance(CInt(num3))
						FileSystem.FileGet(CInt(frn), num2, -1L)
						cRODSTAR2.set_RequiredUnbalance(CInt(num3), num2)
					Else
						cRODSTAR2 = cRODSTAR
						Dim cRODSTAR5 As cRODSTAR = cRODSTAR2
						num3 = num5
						num2 = cRODSTAR5.get_M(CInt(num3))
						FileSystem.FileGet(CInt(frn), num2, -1L)
						cRODSTAR2.set_M(CInt(num3), num2)
					End If
					FileSystem.FileGet(CInt(frn), cRODSTAR.MotorKWH(CInt(num5)), -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.PeakTorque(CInt(num5)), -1L)
					Dim num6 As Short = 0S
					Dim num7 As Short = cRODSTAR.Ntsteps - 1S
					For num8 As Short = num6 To num7
						FileSystem.FileGet(CInt(frn), cRODSTAR.Tnet(CInt(num5), CInt(num8)), -1L)
					Next
					num5 += 1S
				Loop While num5 <= 2S
				Dim num9 As Short = 1S
				Dim numRods As Short = cRODSTAR.NumRods
				num5 = num9
				While num5 <= numRods
					FileSystem.FileGet(CInt(frn), cRODSTAR.StressL(CInt(num5)), -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.maxStressTop(CInt(num5)), -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.minStressTop(CInt(num5)), -1L)
					FileSystem.FileGet(CInt(frn), cRODSTAR.minStressBot(CInt(num5)), -1L)
					num5 += 1S
				End While
				Dim num10 As Short
				Dim num11 As Short
				Dim array As Single() = New Single(CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
				cRODSTAR.SurfPos = array
				array = New Single(CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
				cRODSTAR.SurfLoad = array
				array = New Single(CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
				cRODSTAR.PumpPos = array
				array = New Single(CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
				cRODSTAR.PumpLoad = array
				array = New Single(CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
				cRODSTAR.PermLoad = array
				array = New Single(CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
				cRODSTAR.Thetac = array
				array = New Single(CInt((cRODSTAR.Ntsteps - 1S + 1S)) - 1) {}
				cRODSTAR.Tf = array
				num10 = 0S
				num11 = cRODSTAR.Ntsteps - 1S
				num5 = num10
				While num5 <= num11
					Try
						FileSystem.FileGet(CInt(frn), cRODSTAR.SurfPos(CInt(num5)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.SurfLoad(CInt(num5)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.PumpPos(CInt(num5)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.PumpLoad(CInt(num5)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.PermLoad(CInt(num5)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.Thetac(CInt(num5)), -1L)
						FileSystem.FileGet(CInt(frn), cRODSTAR.Tf(CInt(num5)), -1L)
					Catch ex As Exception
					End Try
					num5 += 1S
				End While
				Try
					Dim flag2 As Boolean
					FileSystem.FileGet(CInt(frn), flag2, -1L)
					Dim cRODSTAR2 As cRODSTAR = cRODSTAR
					Dim num3 As Short = cRODSTAR2.NtstepsUpstroke
					FileSystem.FileGet(CInt(frn), num3, -1L)
					cRODSTAR2.NtstepsUpstroke = num3
				Catch ex2 As Exception
				End Try
				Try
					Dim num12 As Short
					FileSystem.FileGet(CInt(frn), num12, -1L)
					If num12 > 0S Then
						Dim value As TEImpred.rod_element_data_type = Nothing
						impredObj.num_rod_elements = CInt(num12)
						Dim num13 As Short = 1S
						Dim num14 As Short = CShort(impredObj.num_rod_elements)
						num5 = num13
						While num5 <= num14
							FileSystem.FileGet(CInt(frn), value.m_d, -1L)
							FileSystem.FileGet(CInt(frn), value.dog, -1L)
							FileSystem.FileGet(CInt(frn), value.rad, -1L)
							FileSystem.FileGet(CInt(frn), value.ea, -1L)
							FileSystem.FileGet(CInt(frn), value.friction_coef, -1L)
							FileSystem.FileGet(CInt(frn), value.mass, -1L)
							FileSystem.FileGet(CInt(frn), value.buoy_weight, -1L)
							FileSystem.FileGet(CInt(frn), value.old_force, -1L)
							FileSystem.FileGet(CInt(frn), value.old_velocity, -1L)
							FileSystem.FileGet(CInt(frn), value.friction_force, -1L)
							FileSystem.FileGet(CInt(frn), value.gravity_force, -1L)
							FileSystem.FileGet(CInt(frn), value.pos.x, -1L)
							FileSystem.FileGet(CInt(frn), value.pos.y, -1L)
							FileSystem.FileGet(CInt(frn), value.pos.z, -1L)
							FileSystem.FileGet(CInt(frn), value.tan.x, -1L)
							FileSystem.FileGet(CInt(frn), value.tan.y, -1L)
							FileSystem.FileGet(CInt(frn), value.tan.z, -1L)
							FileSystem.FileGet(CInt(frn), value.nor.x, -1L)
							FileSystem.FileGet(CInt(frn), value.nor.y, -1L)
							FileSystem.FileGet(CInt(frn), value.nor.z, -1L)
							FileSystem.FileGet(CInt(frn), value.sfg.x, -1L)
							FileSystem.FileGet(CInt(frn), value.sfg.y, -1L)
							FileSystem.FileGet(CInt(frn), value.sfg.z, -1L)
							FileSystem.FileGet(CInt(frn), value.max_sf_total, -1L)
							FileSystem.FileGet(CInt(frn), value.inc, -1L)
							FileSystem.FileGet(CInt(frn), value.azi, -1L)
							FileSystem.FileGet(CInt(frn), value.max_force, -1L)
							FileSystem.FileGet(CInt(frn), value.min_force, -1L)
							FileSystem.FileGet(CInt(frn), value.damp_coef_dn, -1L)
							FileSystem.FileGet(CInt(frn), value.damp_coef_up, -1L)
							FileSystem.FileGet(CInt(frn), value.hydrostat_psia_tbg, -1L)
							FileSystem.FileGet(CInt(frn), value.hydrostat_psia_csg, -1L)
							FileSystem.FileGet(CInt(frn), value.dynamic_psia_tbg, -1L)
							FileSystem.FileGet(CInt(frn), value.dynamic_psia_csg, -1L)
							FileSystem.FileGet(CInt(frn), value.buckle_tendency, -1L)
							FileSystem.FileGet(CInt(frn), value.rod_area, -1L)
							impredObj.set_r_e(CInt((num5 + 1S)), value)
							num5 += 1S
						End While
					End If
				Catch ex3 As Exception
				End Try
				bOutputLoaded = True
				cRODSTAR.gbOutputLoaded = True
				If cRODSTAR.gbOutputLoaded Then
					Try
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						RSWIN_DESC.bBalancedEVarsOverwritten = False
						Dim num15 As Integer = 1
						If Not(rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And rst.get_M(2) = 0F Then
							rst.UnknownM = True
						End If
						If((Not(rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And Not rst.UnknownM) Or ((RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And Not rst.bUnknownUnbalance)) And rst.get_ElectricBillperMonth(2) < rst.get_ElectricBillperMonth(1) Then
							num15 = 2
						End If
						If((If((-If((CDbl(rst.get_ElectricBillperMonth(0)) >= 0.99 * CDbl(rst.get_ElectricBillperMonth(num15)) > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.DEBUG_ShowAllBalanced) Or If((-If(((RSWIN_DESC.rst.PU.UnitType = 10S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							RSWIN_DESC.bBalancedEVarsOverwritten = True
							RSWIN_DESC.iOverWriteIndex = num15
						End If
					Catch ex4 As Exception
						RSWIN_DESC.bBalancedEVarsOverwritten = False
					End Try
				End If
				Return
			Catch ex5 As Exception
				bOutputLoaded = True
				cRODSTAR.gbOutputLoaded = False
			End Try
			cRODSTAR = Nothing
		End Sub

		Private Const csKEY_ENTRYNUMBER As String = "EntryNumber"

		Private Const csKEY_AZIMUTH As String = "Azimuth"

		Private Const csKEY_DEPTH As String = "Depth"

		Private Const csKEY_DOGLEG As String = "Dogleg"

		Private Const csKEY_INCLINATION As String = "Inclination"

		Private Const csKEY_TVDEPTH As String = "TVDepth"

		Private Const csKEY_NORTHSOUTH As String = "NorthSouth"

		Private Const csKEY_EASTWEST As String = "EastWest"
	End Module
End Namespace
