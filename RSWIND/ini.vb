Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports ThetaStdInfo

Namespace RSWINV3
	Friend NotInheritable Module ini
		Public Function GetDataValue(sValueName As String, iVarType As Integer, bGetDefault As Boolean, vNotPresentDefault As Object) As Object
			Dim num2 As Integer
			Dim obj8 As Object
			Dim num4 As Integer
			Dim obj9 As Object
			Try
				IL_00:
				Dim num As Integer = 1
				If Not ini.INIKeyExists(RSWIN_DESC.SECT_DATAENTRY, sValueName) Then
					GoTo IL_2A8
				End If
				IL_13:
				num = 2
				If Operators.CompareString(sValueName, "DynoCard", False) <> 0 Then
					GoTo IL_35
				End If
				IL_25:
				num = 3
				Dim str As String = Strings.Space(6144)
				IL_33:
				GoTo IL_46
				IL_35:
				num = 5
				IL_38:
				num = 6
				str = Strings.Space(255)
				IL_46:
				num = 8
				Dim text As String = ""
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_DATAENTRY, sValueName, text, str, False)
				IL_62:
				num = 9
				Dim obj As Object = Strings.Left(str, regProfileString)
				IL_6F:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_77:
				num = 11
				Select Case iVarType
					Case 3
						IL_AC:
						num = 15
						If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
							GoTo IL_CF
						End If
						IL_BE:
						num = 16
						obj = RuntimeHelpers.GetObjectValue(vNotPresentDefault)
						IL_CA:
						Exit Select
						IL_CF:
						num = 18
						IL_D3:
						num = 19
						obj = Conversions.ToInteger(obj)
						IL_E5:
					Case 4
						IL_EA:
						num = 23
						If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
							GoTo IL_10D
						End If
						IL_FC:
						num = 24
						obj = RuntimeHelpers.GetObjectValue(vNotPresentDefault)
						IL_108:
						Exit Select
						IL_10D:
						num = 26
						IL_111:
						num = 27
						If Information.VarType(RuntimeHelpers.GetObjectValue(obj)) <> VariantType.[String] Then
							GoTo IL_13C
						End If
						IL_124:
						num = 28
						text = Conversions.ToString(obj)
						ini.CheckForDecimal(text)
						obj = text
						IL_13C:
						num = 30
						obj = Convert.ToSingle(RuntimeHelpers.GetObjectValue(obj))
						IL_153:
					Case 8
						IL_158:
						num = 34
						obj = Convert.ToString(RuntimeHelpers.GetObjectValue(obj))
						IL_16A:
					Case 11
						IL_16F:
						num = 37
						Dim obj2 As Object = Nothing
						Dim typeFromHandle As Type = GetType(Strings)
						Dim text2 As String = "UCase"
						Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(obj) }
						Dim array2 As Object() = array
						Dim array3 As String() = Nothing
						Dim array4 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { True }
						Dim obj3 As Object = NewLateBinding.LateGet(obj2, typeFromHandle, text2, array2, array3, array4, array5)
						If array5(0) Then
							obj = RuntimeHelpers.GetObjectValue(array(0))
						End If
						Dim obj4 As Object = obj3
						IL_1C5:
						num = 40
						If Not Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(obj4, "ON", False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(obj4, "YES", False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(obj4, "TRUE", False))), True, False)) Then
							GoTo IL_228
						End If
						IL_21A:
						num = 41
						obj = True
						IL_226:
						Exit Select
						IL_228:
						num = 43
						If Not Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(obj4, "OFF", False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(obj4, "NO", False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(obj4, "FALSE", False))), True, False)) Then
							GoTo IL_28B
						End If
						IL_27D:
						num = 44
						obj = False
						IL_289:
						Exit Select
						IL_28B:
						num = 47
						obj = (Conversions.ToInteger(obj) <> 0)
				End Select
				IL_2A3:
				GoTo IL_573
				IL_2A8:
				num = 51
				If Not bGetDefault Then
					GoTo IL_542
				End If
				IL_2B2:
				num = 52
				Dim sDefaultName As String = sValueName
				Dim value As Object = DBNull.Value
				Dim flag As Boolean = False
				obj = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag))
				IL_2CD:
				num = 53
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					GoTo IL_30C
				End If
				IL_2DF:
				num = 54
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(vNotPresentDefault)) Then
					GoTo IL_300
				End If
				IL_2F0:
				num = 55
				ini.SaveDataValue(sValueName, RuntimeHelpers.GetObjectValue(vNotPresentDefault))
				IL_300:
				num = 57
				obj = RuntimeHelpers.GetObjectValue(vNotPresentDefault)
				IL_30C:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_314:
				num = 60
				Select Case iVarType
					Case 3
						IL_349:
						num = 64
						If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
							GoTo IL_36C
						End If
						IL_35B:
						num = 65
						obj = RuntimeHelpers.GetObjectValue(vNotPresentDefault)
						IL_367:
						Exit Select
						IL_36C:
						num = 67
						IL_370:
						num = 68
						obj = Conversions.ToInteger(obj)
						IL_382:
					Case 4
						IL_387:
						num = 72
						If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
							GoTo IL_3AA
						End If
						IL_399:
						num = 73
						obj = RuntimeHelpers.GetObjectValue(vNotPresentDefault)
						IL_3A5:
						Exit Select
						IL_3AA:
						num = 75
						IL_3AE:
						num = 76
						If Information.VarType(RuntimeHelpers.GetObjectValue(obj)) <> VariantType.[String] Then
							GoTo IL_3D9
						End If
						IL_3C1:
						num = 77
						text = Conversions.ToString(obj)
						ini.CheckForDecimal(text)
						obj = text
						IL_3D9:
						num = 79
						obj = Convert.ToSingle(RuntimeHelpers.GetObjectValue(obj))
						IL_3F0:
					Case 8
						IL_3F5:
						num = 83
						obj = Convert.ToString(RuntimeHelpers.GetObjectValue(obj))
						IL_407:
					Case 11
						IL_40C:
						num = 86
						Dim obj5 As Object = Nothing
						Dim typeFromHandle2 As Type = GetType(Strings)
						Dim text3 As String = "UCase"
						Dim array6 As Object() = New Object() { RuntimeHelpers.GetObjectValue(obj) }
						Dim array7 As Object() = array6
						Dim array8 As String() = Nothing
						Dim array9 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { True }
						Dim obj6 As Object = NewLateBinding.LateGet(obj5, typeFromHandle2, text3, array7, array8, array9, array5)
						If array5(0) Then
							obj = RuntimeHelpers.GetObjectValue(array6(0))
						End If
						Dim obj7 As Object = obj6
						IL_462:
						num = 89
						If Not Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(obj7, "ON", False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(obj7, "YES", False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(obj7, "TRUE", False))), True, False)) Then
							GoTo IL_4C5
						End If
						IL_4B7:
						num = 90
						obj = True
						IL_4C3:
						Exit Select
						IL_4C5:
						num = 92
						If Not Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(obj7, "OFF", False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(obj7, "NO", False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(obj7, "FALSE", False))), True, False)) Then
							GoTo IL_528
						End If
						IL_51A:
						num = 93
						obj = False
						IL_526:
						Exit Select
						IL_528:
						num = 96
						obj = (Conversions.ToInteger(obj) <> 0)
				End Select
				IL_540:
				GoTo IL_573
				IL_542:
				num = 100
				IL_546:
				num = 101
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(vNotPresentDefault)) Then
					GoTo IL_567
				End If
				IL_557:
				num = 102
				ini.SaveDataValue(sValueName, RuntimeHelpers.GetObjectValue(vNotPresentDefault))
				IL_567:
				num = 104
				obj = RuntimeHelpers.GetObjectValue(vNotPresentDefault)
				IL_573:
				num = 106
				obj8 = obj
				IL_57F:
				GoTo IL_784
				IL_584:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_740:
				GoTo IL_779
				IL_742:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_755:
			Catch obj10 When endfilter(TypeOf obj9 Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj10, Exception)
				GoTo IL_742
			End Try
			IL_779:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_784:
			Dim result As Object = obj8
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub ReadRSInput()
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				If RSWIN_DESC.bRodStarD Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodStringType", 2, False, DBNull.Value))
					If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						cRODSTAR.RodStringType = 2S
					Else
						cRODSTAR.RodStringType = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
					End If
					If cRODSTAR.RodStringType = 3S Then
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodDesignStyle", 2, False, DBNull.Value))
						If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							cRODSTAR.giRodDesignStyle = 0S
						Else
							cRODSTAR.giRodDesignStyle = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
						End If
					End If
				Else
					cRODSTAR.RodStringType = Conversions.ToShort(ini.GetDataValue("RodStringType", 2, False, 3))
					If cRODSTAR.RodStringType = 3S Then
						cRODSTAR.giRodDesignStyle = Conversions.ToShort(ini.GetDataValue("RodDesignStyle", 2, False, 0))
					End If
				End If
				Dim num As Integer
				Select Case cRODSTAR.RodStringType
					Case 1S
						num = 4
					Case 2S
						num = 3
					Case 3S
						Select Case cRODSTAR.giRodDesignStyle
							Case 0S
								num = 0
							Case 1S
								num = 1
						End Select
				End Select
				If num = 0 Then
					ini.ReadRSInpRST()
				ElseIf num = 1 Then
					ini.ReadRSInpRFG()
				Else
					cRODSTAR.NumRods = Conversions.ToShort(ini.GetDataValue("NumRods", 2, False, 0))
					Dim num2 As Short = 1S
					Do
						cRODSTAR.Sections(CInt(num2)).Initialize()
						cRODSTAR.Sections(CInt(num2)).Grade = 0S
						cRODSTAR.Sections(CInt(num2)).RodType = ""
						cRODSTAR.Sections(CInt(num2)).Diameter = 0F
						cRODSTAR.Sections(CInt(num2)).length = 0F
						num2 += 1S
					Loop While num2 <= 40S
					Dim num3 As Short = 1S
					Dim numRods As Short = cRODSTAR.NumRods
					Dim objectValue As Object
					num2 = num3
					While num2 <= numRods
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodGrade" + num2.ToString(), 2, False, 4099))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							cRODSTAR.Sections(CInt(num2)).Grade = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
							Dim grade As Integer = CInt(cRODSTAR.Sections(CInt(num2)).Grade)
							Dim name As String
							Try
								name = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(cRODSTAR.Sections(CInt(num2)).Grade, StdInfoConstants.RodGradeConstants)).Name
							Catch ex As Exception
							End Try
							cRODSTAR.Sections(CInt(num2)).RodType = Conversions.ToString(ini.GetDataValue("RodType" + Conversions.ToString(CInt(num2)), 8, False, name))
							objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodDiam" + num2.ToString(), 4, False, 0.75))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
								cRODSTAR.Sections(CInt(num2)).Diameter = Conversions.ToSingle(objectValue)
							End If
							objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodLength" + num2.ToString(), 4, False, RSWIN_DESC.rst.PumpDepth))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
								cRODSTAR.Sections(CInt(num2)).length = Conversions.ToSingle(objectValue)
							End If
							objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodFrictionCoef" + num2.ToString(), 4, False, 0.2))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
								cRODSTAR.Sections(CInt(num2)).friction_coef = Conversions.ToSingle(objectValue)
							Else
								cRODSTAR.Sections(CInt(num2)).friction_coef = Conversions.ToSingle(objectValue)
							End If
							Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
							Dim num4 As Integer = CInt(num2)
							If sections(num4).friction_coef = 0F Then
								sections(num4).friction_coef = 0.2F
							End If
							If RSWIN_DESC.bRodStarD Then
								If RSWIN_DESC.SETUP_GuideToUse >= 4 Then
									objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodGuide" + num2.ToString(), 2, False, 4S))
									If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
										Dim num5 As Short = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
										If num5 < 4S Then
											num5 = 4S
										End If
										cRODSTAR.Sections(CInt(num2)).Guide = num5
									Else
										Dim num5 As Short = 4S
										cRODSTAR.Sections(CInt(num2)).Guide = num5
									End If
								End If
								If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES Then
									objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("NumGuides" + num2.ToString(), 2, False, 0))
									If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
										Dim num5 As Short = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
										cRODSTAR.Sections(CInt(num2)).NumGuides = num5
									Else
										Dim num5 As Short = 0S
										cRODSTAR.Sections(CInt(num2)).NumGuides = num5
									End If
								End If
							End If
						End If
						num2 += 1S
					End While
					cRODSTAR.ServiceFactor = Conversions.ToSingle(ini.GetDataValue("ServiceFactor", 4, True, 0.9))
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSExtraCost", 4, False, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						cRODSTAR.RSExtraCost = Conversions.ToSingle(objectValue)
					End If
					cRODSTAR.RSExtraCostLabel = Conversions.ToString(ini.GetDataValue("RSExtraCostLabel", 8, False, ""))
				End If
				cRODSTAR = Nothing
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub ReadRSInpRFG()
			Dim flag As Boolean = False
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				RSWIN_DESC.mbMaxMinNotYetSet = Information.IsDBNull(RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 3, False, DBNull.Value)))
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSFGGrade", 3, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.RSFGGrade = Conversions.ToShort(objectValue)
				End If
				cRODSTAR.RSFGIncludeSteel = Conversions.ToShort(ini.GetDataValue("RSFGIncludeSteel", 11, False, True))
				If cRODSTAR.RSFGIncludeSteel <> 0S Then
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 3, False, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						cRODSTAR.RSGrade = Conversions.ToShort(objectValue)
						cRODSTAR.RSRodType = Conversions.ToString(ini.GetDataValue("RSRodType", 8, False, ""))
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMaxSize", 4, False, 1))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							cRODSTAR.RSMaxSize = Conversions.ToSingle(objectValue)
							objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMinSize", 4, False, 0.75))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
								cRODSTAR.RSMinSize = Conversions.ToSingle(objectValue)
							End If
						End If
					End If
				End If
				Try
					If RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru Then
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("gbDesignSinkerbar", 11, False, False))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							cRODSTAR.gbDesignSinkerbar = Conversions.ToBoolean(objectValue)
						End If
					End If
				Catch ex As Exception
				End Try
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSIncludeSB", 11, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.RSIncludeSB = Conversions.ToShort(objectValue)
					If(Not cRODSTAR.RSIncludeSB And Not cRODSTAR.RSFGIncludeSteel) <> 0S Then
						cRODSTAR.RSIncludeSB = -1S
					End If
				End If
				Dim sinkerBar As RSWIN_DESC.RodSection
				If cRODSTAR.RSIncludeSB <> 0S Then
					flag = True
					sinkerBar.Initialize()
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBGrade", 3, False, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						sinkerBar.Grade = Conversions.ToShort(objectValue)
						sinkerBar.RodType = Conversions.ToString(ini.GetDataValue("RSSBRodType", 8, False, ""))
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBDiameter", 4, False, 1.5))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							sinkerBar.Diameter = Conversions.ToSingle(objectValue)
						End If
					End If
					If cRODSTAR.RSFGIncludeSteel <> 0S Then
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBLength", 4, False, DBNull.Value))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							sinkerBar.length = Conversions.ToSingle(objectValue)
						End If
					End If
				End If
				If flag Then
					cRODSTAR.SinkerBar = sinkerBar
				End If
				cRODSTAR.ServiceFactor = Conversions.ToSingle(ini.GetDataValue("ServiceFactor", 4, True, 0.9))
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSExtraCost", 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.RSExtraCost = Conversions.ToSingle(objectValue)
				End If
				cRODSTAR.RSExtraCostLabel = Conversions.ToString(ini.GetDataValue("RSExtraCostLabel", 8, False, ""))
				cRODSTAR = Nothing
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub ReadRSInpRST()
			Dim flag As Boolean = False
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim sinkerBar As RSWIN_DESC.RodSection
				sinkerBar.Initialize()
				rst.RSIncludeSB = Conversions.ToShort(ini.GetDataValue("RSIncludeSB", 11, False, False))
				RSWIN_DESC.mbMaxMinNotYetSet = Information.IsDBNull(RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 3, False, DBNull.Value)))
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 3, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					rst.RSGrade = Conversions.ToShort(objectValue)
					rst.RSRodType = Conversions.ToString(ini.GetDataValue("RSRodType", 8, False, ""))
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMaxSize", 4, False, 1))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						rst.RSMaxSize = Conversions.ToSingle(objectValue)
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMinSize", 4, False, 0.75))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							rst.RSMinSize = Conversions.ToSingle(objectValue)
						End If
					End If
				End If
				rst.RSIncludeSB = Conversions.ToShort(ini.GetDataValue("RSIncludeSB", 11, False, False))
				If rst.RSIncludeSB <> 0S Then
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBGrade", 3, False, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						flag = True
						sinkerBar.Grade = Conversions.ToShort(objectValue)
						sinkerBar.RodType = Conversions.ToString(ini.GetDataValue("RSSBRodType", 8, False, ""))
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBDiameter", 4, False, 1.5))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							sinkerBar.Diameter = Conversions.ToSingle(objectValue)
						End If
					End If
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBLength", 4, False, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						flag = True
						sinkerBar.length = Conversions.ToSingle(objectValue)
					End If
				End If
				If flag Then
					rst.SinkerBar = sinkerBar
				End If
				rst.ServiceFactor = Conversions.ToSingle(ini.GetDataValue("ServiceFactor", 4, True, 0.9))
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSExtraCost", 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					rst.RSExtraCost = Conversions.ToSingle(objectValue)
				End If
				rst.RSExtraCostLabel = Conversions.ToString(ini.GetDataValue("RSExtraCostLabel", 8, False, ""))
				Try
					If RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru Then
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("gbDesignSinkerbar", 11, False, False))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							rst.gbDesignSinkerbar = Conversions.ToBoolean(objectValue)
						End If
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub ReadRSInput_Save()
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			cRODSTAR.RodStringType = Conversions.ToShort(ini.GetDataValue("RodStringType", 2, False, 2))
			cRODSTAR.giRodDesignStyle = Conversions.ToShort(ini.GetDataValue("RodDesignStyle", 2, False, 0))
			cRODSTAR.RSMaxSize = 1F
			cRODSTAR.RSMinSize = 0.75F
			RSWIN_DESC.mbMaxMinNotYetSet = Information.IsDBNull(RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 2, False, DBNull.Value)))
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSFGGrade", 2, False, DBNull.Value))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				cRODSTAR.RSFGGrade = Conversions.ToShort(objectValue)
			End If
			cRODSTAR.RSFGIncludeSteel = Conversions.ToShort(ini.GetDataValue("RSFGIncludeSteel", 11, False, True))
			If cRODSTAR.RSFGIncludeSteel <> 0S Then
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 2, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.RSGrade = Conversions.ToShort(objectValue)
					cRODSTAR.RSRodType = Conversions.ToString(ini.GetDataValue("RSRodType", 8, False, RSWIN_DESC.sNull))
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMaxSize", 4, False, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						cRODSTAR.RSMaxSize = Conversions.ToSingle(objectValue)
						objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSMinSize", 4, False, DBNull.Value))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
							cRODSTAR.RSMinSize = Conversions.ToSingle(objectValue)
						End If
					End If
				End If
			End If
			objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSIncludeSB", 11, False, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				cRODSTAR.RSIncludeSB = Not cRODSTAR.RSFGIncludeSteel
			Else
				cRODSTAR.RSIncludeSB = Conversions.ToShort(objectValue)
				If(Not cRODSTAR.RSIncludeSB And Not cRODSTAR.RSFGIncludeSteel) <> 0S Then
					cRODSTAR.RSIncludeSB = -1S
				End If
			End If
			If cRODSTAR.RSIncludeSB <> 0S Then
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBGrade", 2, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					Dim sinkerBar As RSWIN_DESC.RodSection = cRODSTAR.SinkerBar
					sinkerBar.Grade = Conversions.ToShort(objectValue)
					sinkerBar.RodType = Conversions.ToString(ini.GetDataValue("RSSBRodType", 8, False, RSWIN_DESC.sNull))
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBDiameter", 4, False, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						sinkerBar.Diameter = Conversions.ToSingle(objectValue)
					End If
					cRODSTAR.SinkerBar = sinkerBar
				End If
				If cRODSTAR.RSFGIncludeSteel <> 0S Then
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSSBLength", 4, False, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						Dim sinkerBar2 As RSWIN_DESC.RodSection
						sinkerBar2.length = Conversions.ToSingle(objectValue)
						cRODSTAR.SinkerBar = sinkerBar2
					End If
				End If
			End If
			cRODSTAR.NumRods = Conversions.ToShort(ini.GetDataValue("NumRods", 2, False, 0))
			Dim num As Short = 1S
			Do
				cRODSTAR.Sections(CInt(num)).Initialize()
				cRODSTAR.Sections(CInt(num)).Grade = 0S
				cRODSTAR.Sections(CInt(num)).RodType = ""
				cRODSTAR.Sections(CInt(num)).Diameter = 0F
				cRODSTAR.Sections(CInt(num)).length = 0F
				num += 1S
			Loop While num <= 40S
			Dim num2 As Short = 1S
			Dim numRods As Short = cRODSTAR.NumRods
			num = num2
			While num <= numRods
				objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodGrade" + num.ToString(), 2, False, 4099))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
					cRODSTAR.Sections(CInt(num)).Grade = Convert.ToInt16(RuntimeHelpers.GetObjectValue(objectValue))
					Dim grade As Integer = CInt(cRODSTAR.Sections(CInt(num)).Grade)
					Dim name As String
					Try
						name = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(cRODSTAR.Sections(CInt(num)).Grade, StdInfoConstants.RodGradeConstants)).Name
					Catch ex As Exception
					End Try
					cRODSTAR.Sections(CInt(num)).RodType = Conversions.ToString(ini.GetDataValue("RodType" + Conversions.ToString(CInt(num)), 8, False, name))
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodDiam" + num.ToString(), 4, False, 0.75))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						cRODSTAR.Sections(CInt(num)).Diameter = Conversions.ToSingle(objectValue)
					End If
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodLength" + num.ToString(), 4, False, RSWIN_DESC.rst.PumpDepth))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						cRODSTAR.Sections(CInt(num)).length = Conversions.ToSingle(objectValue)
					End If
					objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RodFrictionCoef" + num.ToString(), 4, False, 0.2))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
						cRODSTAR.Sections(CInt(num)).friction_coef = Conversions.ToSingle(objectValue)
					Else
						cRODSTAR.Sections(CInt(num)).friction_coef = Conversions.ToSingle(objectValue)
					End If
					Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
					Dim num3 As Integer = CInt(num)
					If sections(num3).friction_coef = 0F Then
						sections(num3).friction_coef = 0.2F
					End If
				End If
				num += 1S
			End While
			cRODSTAR.ServiceFactor = Conversions.ToSingle(ini.GetDataValue("ServiceFactor", 4, True, 0.9))
			objectValue = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSExtraCost", 4, False, DBNull.Value))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				cRODSTAR.RSExtraCost = Conversions.ToSingle(objectValue)
			End If
			cRODSTAR.RSExtraCostLabel = Conversions.ToString(ini.GetDataValue("RSExtraCostLabel", 8, False, RSWIN_DESC.sNull))
			cRODSTAR = Nothing
		End Sub

		Public Sub ReadRSInput_Old()
			' The following expression was wrapped in a checked-statement
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.ServiceFactor = Conversions.ToSingle(ini.GetDataValue("ServiceFactor", 4, True, 0.9))
				Dim i As Integer = 1
				Do
					rst.Sections(i).Initialize()
					rst.Sections(i).Grade = 0S
					rst.Sections(i).RodType = ""
					rst.Sections(i).Diameter = 0F
					rst.Sections(i).length = 0F
					i += 1
				Loop While i <= 40
				rst.NumRods = Conversions.ToShort(ini.GetDataValue("NumRods", 3, False, 0))
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(rst.NumRods)
				i = num
				While i <= numRods
					rst.Sections(i).Initialize()
					rst.Sections(i).Grade = Conversions.ToShort(ini.GetDataValue("RodGrade" + Conversions.ToString(i), 3, False, DBNull.Value))
					rst.Sections(i).RodType = Conversions.ToString(ini.GetDataValue("RodType" + Conversions.ToString(i), 8, False, DBNull.Value))
					rst.Sections(i).Diameter = Conversions.ToSingle(ini.GetDataValue("RodDiam" + Conversions.ToString(i), 4, False, DBNull.Value))
					rst.Sections(i).length = Conversions.ToSingle(ini.GetDataValue("RodLength" + Conversions.ToString(i), 4, False, DBNull.Value))
					rst.Sections(i).Area = CSng((Math.Pow(CDbl(rst.Sections(i).Diameter), 2.0) * 3.141592653589793 / 4.0))
					If rst.Sections(i).Grade = 20481S Then
						rst.Sections(i).RodDensity = 100F
					ElseIf rst.Sections(i).Grade = 16393S Then
						rst.Sections(i).RodDensity = 125F
					ElseIf RODUTIL.IsFG(rst.Sections(i).Grade) Then
						rst.Sections(i).RodDensity = 130F
					Else
						rst.Sections(i).RodDensity = 491F
					End If
					Dim flag As Boolean = True
					If flag = (rst.Sections(i).Grade = 16385S) Then
						GoTo IL_2E4
					End If
					If flag = (rst.Sections(i).Grade = 16389S) Then
						GoTo IL_2E4
					End If
					If flag = (rst.Sections(i).Grade = 16390S) Then
						GoTo IL_2E4
					End If
					If flag = (RODUTIL.IsSteel(CInt(rst.Sections(i).Grade)) <> 0) Then
						Dim sections As RSWIN_DESC.RodSection() = rst.Sections
						Dim num2 As Integer = i
						Dim sDefaultName As String = "SteelSuckerRodLength"
						Dim vNotPresentDefault As Object = 25
						Dim flag2 As Boolean = False
						sections(num2).SuckerRodLength = Conversions.ToSingle(ini.GetDefault(sDefaultName, vNotPresentDefault, flag2))
					ElseIf flag = RODUTIL.IsCorod(rst.Sections(i).Grade) OrElse flag = (RODUTIL.IsProRod(CInt(rst.Sections(i).Grade)) <> 0) Then
						rst.Sections(i).SuckerRodLength = 1F
					Else
						rst.Sections(i).SuckerRodLength = 25F
					End If
					IL_3AF:
					RODUTIL.LookupElasticity(rst.Sections(i))
					RODUTIL.LookupRodWeight(rst.Sections(i))
					RODUTIL.LookupTensileStrength(rst.Sections(i))
					i += 1
					Continue While
					IL_2E4:
					rst.Sections(i).SuckerRodLength = 37.5F
					GoTo IL_3AF
				End While
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ReadDeviationProfile(bNewCase As Boolean)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.FluidDamping = Conversions.ToSingle(ini.GetDataValue("FluidDamping", 4, True, 0.1))
				rst.PumpDragUpstrokeMax = Conversions.ToSingle(ini.GetDataValue("PumpDragUpstrokeMax", 4, True, 200))
				rst.PumpDragDownstrokeMax = Conversions.ToSingle(ini.GetDataValue("PumpDragDownstrokeMax", 4, True, 200))
				rst.DragSettings = Conversions.ToShort(ini.GetDataValue("DragSettings", 2, True, 0))
				If Not RSWIN_DESC.bNewCaseAsked Then
					Dim text As String
					LOADRST.LoadTempDeviationProfile(text, bNewCase)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ReadWellInfo()
			RSWIN_DESC.sNull = ""
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.ACompanyName = Conversions.ToString(ini.GetDataValue("CompanyName", 8, True, RSWIN_DESC.sNull))
			rst.WellName = Conversions.ToString(ini.GetDataValue("WellName", 8, False, RSWIN_DESC.sNull))
			rst.UserName = Conversions.ToString(ini.GetDataValue("UserName", 8, True, RSWIN_DESC.sNull))
			rst.UserDate = Conversions.ToString(ini.GetDataValue("UserDate", 8, False, DateAndTime.Now.ToLongDateString()))
			rst.FileComment = Conversions.ToString(ini.GetDataValue("FileComment", 8, False, RSWIN_DESC.sNull))
			Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpDepth", 4, False, DBNull.Value))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				rst.PumpDepth = Conversions.ToSingle(obj)
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RunTime", 4, True, DBNull.Value))
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				rst.Runtime = Conversions.ToSingle(obj)
			End If
			rst.PumpLoadAdj = Conversions.ToSingle(ini.GetDataValue("PumpLoadAdjustment", 4, True, 0))
			rst.StuffingBoxFriction = Conversions.ToSingle(ini.GetDataValue("StuffingBoxFriction", 4, True, 100))
			rst.TubingPressure = Conversions.ToSingle(ini.GetDataValue("TubingPressure", 4, True, 50))
			rst.CasingPressure = Conversions.ToSingle(ini.GetDataValue("CasingPressure", 4, True, 50))
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("WaterCut", 4, True, DBNull.Value))
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) AndAlso Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, 0, False))) Then
				rst.WaterCut = Conversions.ToSingle(obj)
			End If
			rst.WaterSPGR = Conversions.ToSingle(ini.GetDataValue("WaterSPGR", 4, True, 1))
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("OilGravity", 4, True, DBNull.Value))
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) AndAlso Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, 0, False))) Then
				rst.OilAPI = Conversions.ToSingle(obj)
				rst.OilSPGR = CSng((141.5 / (CDbl(rst.OilAPI) + 131.5)))
			End If
			rst.gbCalcFluidSPGR = Conversions.ToBoolean(ini.GetDataValue("CalcFluidSPGR", 11, False, True))
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("FluidSPGR", 4, False, DBNull.Value))
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) AndAlso Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, 0, False))) Then
				rst.FluidSPGR = Conversions.ToSingle(obj)
			End If
			rst.DynaSource = Conversions.ToShort(ini.GetDataValue("DynaSource", 3, False, 0))
			Dim num As Short
			Select Case rst.DynaSource
				Case 0S
					rst.dNtsteps = 0S
					rst.Npoints = 0S
					rst.LeutertDynamometer = 0S
					num = -1S
				Case 1S, 2S
					rst.DynaSource = -1S
				Case 3S
					obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("DynoCard", 3, False, 0))
					rst.DynaFile = Conversions.ToString(ini.GetDataValue("DynaFile", 8, False, RSWIN_DESC.sNull))
					rst.dNtsteps = Conversions.ToShort(ini.GetDataValue("Ntsteps", 3, False, 0))
					Dim num2 As Short
					Dim num3 As Short
					Dim array As Single() = New Single(CInt((rst.dNtsteps - 1S + 1S)) - 1) {}
					rst.dSurfPos = array
					array = New Single(CInt((rst.dNtsteps - 1S + 1S)) - 1) {}
					rst.dSurfLoad = array
					rst.sDynoCard = Conversions.ToString(ini.GetDataValue("DynoCard", 8, False, RSWIN_DESC.sNull))
					num2 = 0S
					num3 = rst.dNtsteps - 1S
					For num4 As Short = num2 To num3
						Dim cRODSTAR As cRODSTAR = rst
						Dim sDynoCard As String = cRODSTAR.sDynoCard
						Dim token As String = Util.GetToken(sDynoCard, ";")
						cRODSTAR.sDynoCard = sDynoCard
						Dim value As String = token
						rst.dSurfPos(CInt(num4)) = CSng(Convert.ToDouble(Util.GetToken(value, ",")))
						rst.dSurfLoad(CInt(num4)) = CSng(Convert.ToDouble(value))
					Next
					rst.bCBEFromDisk = Conversions.ToShort(ini.GetDataValue("CBEFromDisk", 11, False, False))
					rst.MeasuredRuntime = Conversions.ToSingle(ini.GetDataValue("MeasuredRuntime", 4, False, 0))
					rst.MeasuredSPM = Conversions.ToSingle(ini.GetDataValue("MeasuredSPM", 4, False, 0))
					rst.MeasuredStroke = Conversions.ToSingle(ini.GetDataValue("MeasuredStroke", 4, False, 0))
					rst.MeasuredCBEffect = Conversions.ToSingle(ini.GetDataValue("MeasuredCBEffect", 4, False, 0))
					rst.MeasuredCBEpos = Conversions.ToSingle(ini.GetDataValue("MeasuredCBEpos", 4, False, 0))
					rst.MeasuredCBEupstroke = Conversions.ToShort(ini.GetDataValue("MeasuredCBEupstroke", 11, False, False))
					rst.MeasuredTVLoad = Conversions.ToSingle(ini.GetDataValue("MeasuredTVLoad", 4, False, 0))
					rst.MeasuredSVLoad = Conversions.ToSingle(ini.GetDataValue("MeasuredSVLoad", 4, False, 0))
					rst.Npoints = 0S
					If rst.MeasuredSPM > 0F Then
						rst.SPM = rst.MeasuredSPM
					End If
					If rst.MeasuredRuntime > 0F Then
						rst.Runtime = 24F * rst.MeasuredRuntime
					End If
				Case 6S
					rst.dNtsteps = 0S
					If rst.gbAutomaticEnabled Then
						num = 3S
					Else
						num = -1S
					End If
			End Select
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpCondition", 2, False, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				obj = RuntimeHelpers.GetObjectValue(ini.GetListDefault("PumpCondition", 1, 3))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					obj = 1
				End If
			End If
			RSWIN_DESC.rst.PumpCondition = Conversions.ToShort(obj)
			If RSWIN_DESC.rst.PumpCondition <> 1S Then
				RSWIN_DESC.rst.PumpFillage = Conversions.ToSingle(ini.GetDataValue("PumpFillage", 4, True, 85))
			End If
			RSWIN_DESC.rst.PumpEfficiency = Conversions.ToSingle(ini.GetDataValue("PumpEfficiency", 4, True, 85))
			If num = -1S Then
				num = 0S
			End If
			rst.gbClampOn = Conversions.ToShort(ini.GetDataValue("Clampon", 11, False, False))
			rst.giDynoCorrectKinematic = Conversions.ToShort(ini.GetDataValue("DynoCorrectKinematic", 11, False, False))
			rst.giDynoCorrectPhase = Conversions.ToShort(ini.GetDataValue("DynoCorrectPhase", 11, False, False))
			rst.gfDynoPhaseAdjustment = Conversions.ToSingle(ini.GetDataValue("DynoPhaseAdjustment", 4, False, 0))
			rst.gfDynoTOSAdjustment = Conversions.ToSingle(ini.GetDataValue("DynoTOSAdjustment", 4, False, 0))
			rst.giDynoDetectKinematic = Conversions.ToShort(ini.GetDataValue("DynoDetectKinematic", 11, False, -1))
			rst.giDynoDetectPhase = Conversions.ToShort(ini.GetDataValue("DynoDetectPhase", 11, False, -1))
			If RSWIN_DESC.bRodStarD Then
				rst.gbParaffin = Conversions.ToBoolean(ini.GetDataValue("Paraffin", 11, False, False))
				obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("ParaffinDepth", 4, False, DBNull.Value))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) And RSWIN_DESC.rst.PumpDepth > 0F Then
					Dim num5 As Single = RSWIN_DESC.rst.PumpDepth / 3F
					Dim sDynoCard As String = "######.##"
					obj = Util.Format(num5, sDynoCard)
					rst.ParaffinDepth = Conversions.ToSingle(obj)
				ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(obj, 0, False), RSWIN_DESC.rst.PumpDepth > 0F)) Then
						Dim num5 As Single = RSWIN_DESC.rst.PumpDepth / 3F
						Dim sDynoCard As String = "######.##"
						obj = Util.Format(num5, sDynoCard)
					End If
					rst.ParaffinDepth = Conversions.ToSingle(obj)
				End If
			End If
		End Sub

		Public Sub ReadWellInfo_Old()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.ACompanyName = Conversions.ToString(ini.GetDataValue("CompanyName", 8, True, ""))
			rst.WellName = Conversions.ToString(ini.GetDataValue("WellName", 8, False, ""))
			rst.UserName = Conversions.ToString(ini.GetDataValue("UserName", 8, True, ""))
			rst.UserDate = Conversions.ToString(ini.GetDataValue("UserDate", 8, False, ""))
			rst.FileComment = Conversions.ToString(ini.GetDataValue("FileComment", 8, False, ""))
			rst.PumpDepth = Conversions.ToSingle(ini.GetDataValue("PumpDepth", 4, False, 0))
			rst.Runtime = Conversions.ToSingle(ini.GetDataValue("RunTime", 4, True, 24))
			rst.TubingPressure = Conversions.ToSingle(ini.GetDataValue("TubingPressure", 4, True, 50))
			rst.CasingPressure = Conversions.ToSingle(ini.GetDataValue("CasingPressure", 4, True, 50))
			rst.WaterCut = Conversions.ToSingle(ini.GetDataValue("WaterCut", 4, True, 90))
			rst.WaterSPGR = Conversions.ToSingle(ini.GetDataValue("WaterSPGR", 4, True, 1))
			rst.OilAPI = Conversions.ToSingle(ini.GetDataValue("OilGravity", 4, True, 30))
			rst.OilSPGR = CSng((141.5 / (CDbl(rst.OilAPI) + 131.5)))
			rst.FluidSPGR = Conversions.ToSingle(ini.GetDataValue("FluidSPGR", 4, False, 1))
			rst.DynaSource = Conversions.ToShort(ini.GetDataValue("DynaSource", 3, False, 0))
			rst.DynoDate = Conversions.ToString(ini.GetDataValue("DynoDate", 8, False, ""))
			rst.gbClampOn = Conversions.ToShort(ini.GetDataValue("Clampon", 11, False, False))
			rst.giDynoCorrectKinematic = Conversions.ToShort(ini.GetDataValue("DynoCorrectKinematic", 3, False, 0))
			rst.giDynoCorrectPhase = Conversions.ToShort(ini.GetDataValue("DynoCorrectPhase", 3, False, 0))
			rst.gfDynoPhaseAdjustment = Conversions.ToSingle(ini.GetDataValue("DynoPhaseAdjustment", 4, False, 0))
			rst.gfDynoTOSAdjustment = Conversions.ToSingle(ini.GetDataValue("DynoTOSAdjustment", 4, False, 0))
			rst.giDynoDetectKinematic = Conversions.ToShort(ini.GetDataValue("DynoDetectKinematic", 3, False, -1))
			rst.giDynoDetectPhase = Conversions.ToShort(ini.GetDataValue("DynoDetectPhase", 3, False, -1))
			Select Case rst.DynaSource
				Case 0S, 6S
					rst.dNtsteps = 0S
					rst.Npoints = 0S
					rst.LeutertDynamometer = 0S
				Case 1S, 2S
					rst.LeutertDynamometer = Conversions.ToShort(ini.GetDataValue("LeutertDynamometer", 11, False, False))
					If rst.LeutertDynamometer <> 0S Then
						rst.LeutertModel = Conversions.ToString(ini.GetDataValue("LeutertModel", 8, False, ""))
						rst.LeutertScale = Conversions.ToSingle(ini.GetDataValue("LeutertScale", 4, False, 0))
						rst.LeutertSpring = Conversions.ToShort(ini.GetDataValue("LeutertSpring", 3, False, 0))
					End If
					rst.Npoints = Conversions.ToShort(ini.GetDataValue("Npoints", 3, False, 0))
					Dim digPoints As Single(,) = New Single(CInt((rst.Npoints - 1S + 1S)) - 1, 2) {}
					rst.DigPoints = digPoints
					rst.sDynoCard = Conversions.ToString(ini.GetDataValue("DynoCard", 8, False, ""))
					Dim num As Integer = 0
					Dim num2 As Integer = CInt((rst.Npoints - 1S))
					For i As Integer = num To num2
						Dim text As String
						Dim token As String = Util.GetToken(text, ";")
						rst.DigPoints(i, 1) = CSng(Convert.ToDouble(Util.GetToken(token, ",")))
						rst.DigPoints(i, 2) = CSng(Convert.ToDouble(token))
					Next
					rst.bCBEDigitized = Conversions.ToShort(ini.GetDataValue("CBEDigitized", 11, False, False))
					rst.BaselineLoad = Conversions.ToSingle(ini.GetDataValue("BaselineLoad", 4, False, 0))
					rst.CbeX = Conversions.ToSingle(ini.GetDataValue("CbeX", 4, False, 0))
					rst.CbeY = Conversions.ToSingle(ini.GetDataValue("CbeY", 4, False, 0))
					rst.LoadScale = Conversions.ToSingle(ini.GetDataValue("LoadScale", 4, False, 0))
					rst.bCBEFromDisk = 0S
					rst.MeasuredRuntime = 0F
					rst.MeasuredSPM = 0F
					rst.MeasuredStroke = 0F
					rst.MeasuredCBEffect = 0F
					rst.MeasuredCBEpos = 0F
					rst.MeasuredCBEupstroke = 0S
					rst.MeasuredTVLoad = 0F
					rst.MeasuredSVLoad = 0F
				Case 3S
					rst.DynaFile = Conversions.ToString(ini.GetDataValue("DynaFile", 8, False, ""))
					rst.dNtsteps = Conversions.ToShort(ini.GetDataValue("Ntsteps", 3, False, 0))
					Dim array As Single() = New Single(CInt((rst.dNtsteps - 1S + 1S)) - 1) {}
					Dim array2 As Single() = New Single(CInt((rst.dNtsteps - 1S + 1S)) - 1) {}
					rst.sDynoCard = Conversions.ToString(ini.GetDataValue("DynoCard", 8, False, ""))
					Dim num3 As Integer = 0
					Dim num4 As Integer = CInt((rst.dNtsteps - 1S))
					For i As Integer = num3 To num4
						Dim text As String
						Dim token As String = Util.GetToken(text, ";")
						array(i) = CSng(Convert.ToDouble(Util.GetToken(token, ",")))
						array2(i) = CSng(Convert.ToDouble(token))
					Next
					rst.dSurfPos = array
					rst.dSurfLoad = array2
					rst.bCBEFromDisk = Conversions.ToShort(ini.GetDataValue("CBEFromDisk", 11, False, False))
					rst.MeasuredRuntime = Conversions.ToSingle(ini.GetDataValue("MeasuredRuntime", 4, False, 0))
					rst.MeasuredSPM = Conversions.ToSingle(ini.GetDataValue("MeasuredSPM", 4, False, 0))
					rst.MeasuredStroke = Conversions.ToSingle(ini.GetDataValue("MeasuredStroke", 4, False, 0))
					rst.MeasuredCBEffect = Conversions.ToSingle(ini.GetDataValue("MeasuredCBEffect", 4, False, 0))
					rst.MeasuredCBEpos = Conversions.ToSingle(ini.GetDataValue("MeasuredCBEpos", 4, False, 0))
					rst.MeasuredCBEupstroke = Conversions.ToShort(ini.GetDataValue("MeasuredCBEupstroke", 11, False, False))
					rst.MeasuredTVLoad = Conversions.ToSingle(ini.GetDataValue("MeasuredTVLoad", 4, False, 0))
					rst.MeasuredSVLoad = Conversions.ToSingle(ini.GetDataValue("MeasuredSVLoad", 4, False, 0))
			End Select
		End Sub

		Public Sub SaveDataValue(sKey As String, vValue As Object)
			Try
				If Strings.Len(sKey) = 0 Then
					Dim text As String = Conversions.ToString(0L)
					Dim text2 As String = Conversions.ToString(0L)
					Dim num As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DATAENTRY, text, text2, RSWIN_DESC.sINIFile))
				ElseIf Information.IsDBNull(RuntimeHelpers.GetObjectValue(vValue)) Then
					Dim text2 As String = Conversions.ToString(0L)
					Dim num As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DATAENTRY, sKey, text2, RSWIN_DESC.sINIFile))
				Else
					Dim text2 As String = Convert.ToString(RuntimeHelpers.GetObjectValue(vValue))
					Dim num As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DATAENTRY, sKey, text2, RSWIN_DESC.sINIFile))
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in SaveDataValue: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Function GetSingleDefault(sDefaultName As String, vNotPresentDefault As Object) As Single
			Dim flag As Boolean
			Dim obj As Object = ini.GetSnglDefault(sDefaultName, RuntimeHelpers.GetObjectValue(vNotPresentDefault), flag)
			If Not flag Then
				Return 0F
			End If
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				Return 0F
			End If
			Dim result As Single
			Try
				If Information.VarType(RuntimeHelpers.GetObjectValue(obj)) = VariantType.[String] Then
					Dim text As String = Conversions.ToString(obj)
					ini.CheckForDecimal(text)
					obj = text
				End If
				result = Convert.ToSingle(RuntimeHelpers.GetObjectValue(obj))
			Catch ex As Exception
				result = 0F
			End Try
			Return result
		End Function

		Public Function GetIntegerDefault(sDefaultName As String, vNotPresentDefault As Object) As Integer
			Dim flag As Boolean
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, RuntimeHelpers.GetObjectValue(vNotPresentDefault), flag))
			If Not flag Then
				Return 0
			End If
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				Return 0
			End If
			Dim result As Integer
			Try
				result = Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue))
			Catch ex As Exception
				result = 0
			End Try
			Return result
		End Function

		Public Function GetDefault(sDefaultName As String, vNotPresentDefault As Object, Optional ByRef bFound As Boolean = False) As Object
			Dim result As Object
			Try
				bFound = False
				Dim obj As Object
				If ini.INIKeyExists(RSWIN_DESC.SECT_DEFAULTS, sDefaultName) Then
					Dim str As String = Strings.Space(255)
					Dim text As String = ""
					Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_DEFAULTS, sDefaultName, text, str, False)
					obj = Strings.Left(str, regProfileString)
					bFound = True
				Else
					bFound = ini.GetDefaultValue(sDefaultName, obj)
					If Not bFound Then
						obj = RuntimeHelpers.GetObjectValue(vNotPresentDefault)
					End If
				End If
				result = obj
			Catch ex As Exception
				Dim sMsg As String = "Error in GetDefault: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
			Return result
		End Function

		Public Function GetSnglDefault(sDefaultName As String, vNotPresentDefault As Object, Optional ByRef bFound As Boolean = False) As Single
			Dim result As Single
			Try
				bFound = False
				Dim obj As Object
				If ini.INIKeyExists(RSWIN_DESC.SECT_DEFAULTS, sDefaultName) Then
					Dim str As String = Strings.Space(255)
					Dim text As String = ""
					Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_DEFAULTS, sDefaultName, text, str, False)
					obj = Strings.Left(str, regProfileString)
					bFound = True
				Else
					bFound = ini.GetDefaultValue(sDefaultName, obj)
				End If
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					result = 0F
				Else
					If Information.VarType(RuntimeHelpers.GetObjectValue(obj)) = VariantType.[String] Then
						Dim text As String = Conversions.ToString(obj)
						ini.CheckForDecimal(text)
						obj = text
					End If
					result = Convert.ToSingle(RuntimeHelpers.GetObjectValue(obj))
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in GetDefault: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
			Return result
		End Function

		Public Function GetDefaultValue(sDefaultName As String, ByRef val As Object) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim num As Integer = 1
				Dim nItems As Integer = CInt(RSWIN_DESC.nItems)
				For i As Integer = num To nItems
					If Operators.CompareString(sDefaultName, RSWIN_DESC.adiDefaults(i).Name, False) = 0 Then
						val = RuntimeHelpers.GetObjectValue(RSWIN_DESC.adiDefaults(i).DefaultValue)
						flag = True
						Exit For
					End If
				Next
				result = flag
			Catch ex As Exception
				Dim sMsg As String = "Error in GetDefaultValue: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
			Return result
		End Function

		Public Function GetListDefault(sDefaultName As String, iMin As Integer, iMax As Integer) As Object
			Dim objectValue As Object
			Try
				Dim vNotPresentDefault As Object = True
				Dim flag As Boolean = False
				Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, vNotPresentDefault, flag))
				If Not Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
					obj = DBNull.Value
				ElseIf Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(obj, iMin, False), Operators.CompareObjectGreater(obj, iMax, False))) Then
					obj = DBNull.Value
				End If
				objectValue = RuntimeHelpers.GetObjectValue(obj)
			Catch ex As Exception
				Dim sMsg As String = "Error in GetListDefault: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
			Return objectValue
		End Function

		Public Sub GetPrivateProfileKeyListFromFile(sINIFile As String, sSection As String, ByRef asKeyList As String(), ByRef nKeys As Integer)
			Dim libWrap As LibWrap = New LibWrap()
			Try
				If Operators.CompareString(sINIFile, "", False) = 0 Then
					sINIFile = RSWIN_DESC.THETA_INI
					FILEUTIL.LocateFile(RSWIN_DESC.THETA_INI, sINIFile, 0S, True, False, False, False)
				End If
				Dim text As String = Strings.Space(16384)
				Dim text2 As String = Nothing
				Dim sNull As String = RSWIN_DESC.sNull
				Dim privateProfileString As Integer = LibWrap.GetPrivateProfileString(sSection, text2, sNull, text, Strings.Len(text), sINIFile)
				RSWIN_DESC.sNull = sNull
				Dim num As Integer = privateProfileString
				text = text.Substring(0, num)
				asKeyList = Nothing
				nKeys = 0
				If num > 0 Then
					Dim num2 As Integer = 1
					Do
						Dim num3 As Integer = Strings.InStr(num2, text, vbNullChar, CompareMethod.Binary)
						If nKeys = 0 Then
							asKeyList = New String(0) {}
						Else
							asKeyList = CType(Utils.CopyArray(CType(asKeyList, Array), New String(nKeys + 1 - 1) {}), String())
						End If
						If num2 = 1 Then
							asKeyList(nKeys) = Strings.Mid(text, num2, num3 - num2)
						Else
							Dim text3 As String = text.Substring(num2 - 2, num3 - num2 + 1)
							asKeyList(nKeys) = text3
						End If
						nKeys += 1
						num2 = num3 + Strings.Len(vbNullChar)
					Loop While num2 <= Strings.Len(text)
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in GetPrivateProfileKeyList: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub GetPrivateProfileKeyList(sSection As String, ByRef asKeyList As String(), ByRef nKeys As Integer)
			Dim text As String = Strings.Space(16384)
			Dim text2 As String = Nothing
			Dim sNull As String = RSWIN_DESC.sNull
			Dim privateProfileString As Integer = LibWrap.GetPrivateProfileString(sSection, text2, sNull, text, Strings.Len(text), RSWIN_DESC.sINIFile)
			RSWIN_DESC.sNull = sNull
			Dim num As Integer = privateProfileString
			text = text.Substring(0, num)
			asKeyList = Nothing
			nKeys = 0
			If num > 0 Then
				Dim num2 As Integer = 1
				Do
					Dim num3 As Integer = Strings.InStr(num2, text, vbNullChar, CompareMethod.Binary)
					If nKeys = 0 Then
						asKeyList = New String(0) {}
					Else
						asKeyList = CType(Utils.CopyArray(CType(asKeyList, Array), New String(nKeys + 1 - 1) {}), String())
					End If
					If num2 = 1 Then
						asKeyList(nKeys) = Strings.Mid(text, num2, num3 - num2)
					Else
						Dim text3 As String = text.Substring(num2 - 2, num3 - num2 + 1)
						asKeyList(nKeys) = text3
					End If
					nKeys += 1
					num2 = num3 + Strings.Len(vbNullChar)
				Loop While num2 <= Strings.Len(text)
			End If
		End Sub

		Private Function CheckForKey(ByRef sSection As String) As Boolean
			If RSWIN_DESC.bUseCurrentUser Then
				If Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection))) Is Nothing Then
					Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection)))
					Return False
				End If
				Return True
			Else
				If Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection))) Is Nothing Then
					Registry.LocalMachine.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection)))
					Return False
				End If
				Return True
			End If
		End Function

		Public Function CheckForSectionKey(ByRef sSection As String, ByRef sKey As String, Optional ByRef Val As String = Nothing) As Boolean
			Dim flag As Boolean = ini.CheckForKey(sSection)
			Dim registryKey As RegistryKey
			If RSWIN_DESC.bUseCurrentUser Then
				registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection)), True)
			Else
				registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection)), True)
			End If
			Dim text As String = Conversions.ToString(registryKey.GetValue(sKey))
			Dim result As Boolean
			If text = Nothing Or Operators.CompareString(text, "", False) = 0 Then
				If Val Is Nothing Then
					result = False
				Else
					Dim text2 As String = Val
					registryKey.SetValue(sKey, Val)
					Val = text2
					result = False
				End If
			Else
				Val = text
				result = True
			End If
			Return result
		End Function

		Public Function CheckForSection(ByRef sSection As String) As Boolean
			If RSWIN_DESC.bUseCurrentUser Then
				If Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), sSection))) Is Nothing Then
					Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), sSection)))
					Return False
				End If
				Return True
			Else
				If Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), sSection))) Is Nothing Then
					Registry.LocalMachine.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), sSection)))
					Return False
				End If
				Return True
			End If
		End Function

		Public Sub GetPrivateProfileKeyList(sSection As String, ByRef asKeyListNames As String(), ByRef asKeyListValues As String(), ByRef nKeys As Integer, Optional bCheckFound As Boolean = False)
			Dim array As String() = New String(10) {}
			Try
				Dim text As String = Strings.Space(16384)
				Dim flag As Boolean = ini.CheckForKey(sSection)
				Dim registryKey As RegistryKey
				If RSWIN_DESC.bUseCurrentUser Then
					registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection)))
				Else
					registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection)))
				End If
				Dim valueNames As String() = registryKey.GetValueNames()
				If valueNames.Length = 0 Then
					If(bCheckFound And Not flag) Or Not bCheckFound Then
						ini.GetPrivateProfileKeyListFromFile(RSWIN_DESC.sINIFile, sSection, array, nKeys)
					End If
					Dim num As Integer = 0
					Dim num2 As Integer = nKeys - 1
					For i As Integer = num To num2
						text = ""
						Dim array2 As String() = array
						Dim num3 As Integer = i
						Dim text2 As String = ""
						Dim obj As Object = RSWIN.GetRegProfileString(sSection, array2(num3), text2, text, False)
						ini.SaveDataValue(array(i), text.Substring(0, Conversions.ToInteger(obj)))
					Next
					flag = ini.CheckForKey(sSection)
					If RSWIN_DESC.bUseCurrentUser Then
						registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection)))
					Else
						registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection)))
					End If
					valueNames = registryKey.GetValueNames()
				End If
				asKeyListNames = Nothing
				asKeyListValues = Nothing
				If valueNames.Length = 0 Then
					asKeyListNames = New String(0) {}
					asKeyListValues = New String(0) {}
				Else
					nKeys = valueNames.Length
					asKeyListNames = CType(Utils.CopyArray(CType(asKeyListNames, Array), New String(nKeys + 1 - 1) {}), String())
					asKeyListValues = CType(Utils.CopyArray(CType(asKeyListValues, Array), New String(nKeys + 1 - 1) {}), String())
					asKeyListNames = valueNames
					Dim num4 As Integer = 0
					Dim num5 As Integer = valueNames.Length - 1
					For i As Integer = num4 To num5
						If Operators.CompareString(sSection, RSWIN_DESC.SECT_WK1FORMATS, False) = 0 Then
							asKeyListValues(i) = valueNames(i)
						Else
							text = Conversions.ToString(registryKey.GetValue(valueNames(i), ""))
							asKeyListValues(i) = text
						End If
					Next
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in GetPrivateProfileKeyList: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Function INIKeyExists(sSection As String, sKey As String) As Boolean
			Dim result As Boolean
			Try
				Dim text As String = Nothing
				Dim flag As Boolean = ini.CheckForSectionKey(sSection, sKey, text)
				result = flag
			Catch ex As Exception
				Dim sMsg As String = "Error in INIKeyExists: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
			Return result
		End Function

		Public Sub ReadMotorInfoData()
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.ElectricityCost = Conversions.ToSingle(ini.GetDataValue("ElectricityCost", 4, True, 0.06))
				rst.PowerMeterType = Conversions.ToShort(ini.GetDataValue("PowerMeterType", 3, False, 1))
				Motor.SelectMotorKind(Conversions.ToInteger(ini.GetDataValue("MotorType", 3, False, 0)))
				Dim num As Integer = Conversions.ToInteger(Motor.GetMotorInfo(4))
				If num = 1 Or num = 7 Or num >= 8 Then
					rst.CalcMotorSize = Conversions.ToShort(ini.GetDataValue("CalcMotorSize", 11, False, True))
				Else
					rst.CalcMotorSize = 0S
				End If
				If Not(If((-If(((num = 1 Or num = 7 Or num >= 8) > False), 1S, 0S)), 1S, 0S) And rst.CalcMotorSize) <> 0S Then
					Motor.SelectMotorSizeByName(Conversions.ToString(ini.GetDataValue("MotorSize", 8, False, "")))
					Motor.SelectMotorSettingByName(Conversions.ToString(ini.GetDataValue("MotorSetting", 8, False, "")))
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ReadProdInfo_Old()
			' The following expression was wrapped in a checked-statement
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.giFluidLevelSource = Conversions.ToShort(ini.GetDataValue("FluidLevelSource", 3, False, 0))
				rst.FluidLevel = Conversions.ToSingle(ini.GetDataValue("FluidLevel", 4, False, rst.PumpDepth))
				rst.UPumpIntakePressure = Conversions.ToSingle(ini.GetDataValue("PumpIntakePressure", 4, False, 50))
				rst.PumpIntakePressure = Conversions.ToSingle(ini.GetDataValue("PumpIntakePressure", 4, False, 50))
				rst.SPM = Conversions.ToSingle(ini.GetDataValue("PumpingSpeed", 4, True, 10))
				rst.TargetBFPD = Conversions.ToSingle(ini.GetDataValue("TargetBFPD", 4, True, 0))
				rst.gbUseIPR = Conversions.ToBoolean(ini.GetDataValue("UseIPR", 11, False, False))
				rst.gbCalcFetkovichN = Conversions.ToBoolean(ini.GetDataValue("CalcFetkovichN", 11, False, True))
				rst.FetkovichN = Conversions.ToSingle(ini.GetDataValue("FetkovichN", 4, False, -1))
				rst.giIPRMethod = Conversions.ToShort(ini.GetDataValue("IPRMethod", 3, False, 1))
				rst.MidPerfDepth = Conversions.ToSingle(ini.GetDataValue("MidPerfDepth", 4, False, -1))
				rst.StaticBHPressure = Conversions.ToSingle(ini.GetDataValue("StaticBHPressure", 4, False, -1))
				rst.BubblePoint = Conversions.ToSingle(ini.GetDataValue("BubblePoint", 4, False, -1))
				rst.gbProducingBelowBPP = Conversions.ToBoolean(ini.GetDataValue("ProducingBelowBPP", 11, False, False))
				rst.gnTestPoints = Conversions.ToShort(ini.GetDataValue("TestPoints", 3, False, 0))
				Dim array As RSWIN_DESC.IPRTESTPOINT()
				If rst.gnTestPoints = 0S Then
					array = New RSWIN_DESC.IPRTESTPOINT(0) {}
				Else
					array = New RSWIN_DESC.IPRTESTPOINT(CInt((rst.gnTestPoints + 1S)) - 1) {}
					Dim num As Integer = 1
					Dim gnTestPoints As Integer = CInt(rst.gnTestPoints)
					For i As Integer = num To gnTestPoints
						array(i).bPIEntered = Conversions.ToShort(ini.GetDataValue("PiEntered" + Conversions.ToString(i), 11, False, True))
						If array(i).bPIEntered <> 0S Then
							array(i).Pintake = Conversions.ToSingle(ini.GetDataValue("TestPointPressure" + Conversions.ToString(i), 4, False, -1))
						Else
							array(i).Pwf = Conversions.ToSingle(ini.GetDataValue("TestPointPressure" + Conversions.ToString(i), 4, False, -1))
						End If
						array(i).Production = Conversions.ToSingle(ini.GetDataValue("TestPointProduction" + Conversions.ToString(i), 4, False, -1))
					Next
				End If
				rst.TestPoints = array
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ReadProdInfo()
			RSWIN_DESC.rst.gbCalcPumpIntakePressure = Conversions.ToBoolean(ini.GetDataValue("CalcPumpIntakePressure", 11, False, False))
			RSWIN_DESC.rst.FluidLevelEntered = Conversions.ToBoolean(ini.GetDataValue("FluidLevelEntered", 11, False, True))
			Dim obj As Object
			If Not RSWIN_DESC.rst.gbCalcPumpCondition Then
				If Not RSWIN_DESC.rst.gbCalcPumpIntakePressure Then
					If RSWIN_DESC.rst.FluidLevelEntered Then
						RSWIN_DESC.rst.FluidLevel = Conversions.ToSingle(ini.GetDataValue("FluidLevel", 4, False, RSWIN_DESC.rst.PumpDepth))
						If RSWIN_DESC.rst.FluidLevel > RSWIN_DESC.rst.PumpDepth Then
							RSWIN_DESC.rst.FluidLevel = RSWIN_DESC.rst.PumpDepth
						End If
					Else
						obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpIntakePressure", 4, False, DBNull.Value))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							RSWIN_DESC.rst.PumpIntakePressure = Conversions.ToSingle(obj)
						Else
							RSWIN_DESC.rst.PumpIntakePressure = 0F
						End If
					End If
				End If
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("FluidLevelSource", 3, False, 0))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.rst.giFluidLevelSource = 0S
			ElseIf Operators.ConditionalCompareObjectEqual(obj, 1, False) Then
				RSWIN_DESC.rst.giFluidLevelSource = 1S
			ElseIf Operators.ConditionalCompareObjectEqual(obj, 2, False) Then
				RSWIN_DESC.rst.giFluidLevelSource = 2S
			ElseIf Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
				RSWIN_DESC.rst.giFluidLevelSource = 0S
			End If
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				rst.giFluidLevelSource = 0S
			Else
				rst.giFluidLevelSource = Conversions.ToShort(obj)
				Select Case rst.giFluidLevelSource
					Case 1S
						obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("FluidLevel", 4, False, DBNull.Value))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							rst.FluidLevel = Conversions.ToSingle(obj)
						End If
					Case 2S
						obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpIntakePressure", 4, False, DBNull.Value))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							rst.PumpIntakePressure = Conversions.ToSingle(obj)
						End If
				End Select
			End If
			rst.SPMEntered = Conversions.ToShort(ini.GetDataValue("SPMEntered", 11, False, True))
			rst.gbCalcTargetBFPD = Conversions.ToBoolean(ini.GetDataValue("CalcTargetBFPD", 11, False, False))
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpingSpeed", 4, True, DBNull.Value))
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				rst.SPM = Conversions.ToSingle(obj)
			Else
				rst.SPM = 0F
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TargetBFPD", 4, False, DBNull.Value))
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				rst.TargetBFPD = Conversions.ToSingle(obj)
			End If
			If(rst.SPMEntered Or If((-If(((rst.PumpCondition <> 1S) > False), 1S, 0S)), 1S, 0S)) = 0S Then
				If Not rst.gbCalcTargetBFPD AndAlso Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
					rst.TargetBFPD = Conversions.ToSingle(obj)
				End If
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpingSpeed", 4, True, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) AndAlso rst.SPM > 0F Then
				obj = rst.SPM
			End If
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) AndAlso Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, 0, False))) Then
				rst.SPM = Conversions.ToSingle(obj)
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TargetBFPD", 4, False, 0))
			rst.gbUseIPR = Conversions.ToBoolean(ini.GetDataValue("UseIPR", 11, False, False))
			rst.gbCalcFetkovichN = Conversions.ToBoolean(ini.GetDataValue("CalcFetkovichN", 11, False, True))
			rst.FetkovichN = Conversions.ToSingle(ini.GetDataValue("FetkovichN", 4, False, -1))
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("IPRMethod", 3, False, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				obj = RuntimeHelpers.GetObjectValue(ini.GetListDefault("IPRMethod", 0, 1))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					obj = 1
				End If
			End If
			rst.giIPRMethod = Conversions.ToShort(obj)
			rst.MidPerfDepth = Conversions.ToSingle(ini.GetDataValue("MidPerfDepth", 4, False, 0))
			rst.StaticBHPressure = Conversions.ToSingle(ini.GetDataValue("StaticBHPressure", 4, False, 0))
			rst.BubblePoint = Conversions.ToSingle(ini.GetDataValue("BubblePoint", 4, False, 0))
			rst.gbProducingBelowBPP = Conversions.ToBoolean(ini.GetDataValue("ProducingBelowBPP", 11, False, False))
			rst.gnTestPoints = Conversions.ToShort(ini.GetDataValue("TestPoints", 3, False, 0))
			If rst.gnTestPoints = 0S Then
				Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(0) {}
				rst.TestPoints = testPoints
			Else
				Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(CInt((rst.gnTestPoints + 1S)) - 1) {}
				rst.TestPoints = testPoints
			End If
			Dim num As Integer = 1
			Dim gnTestPoints As Integer = CInt(rst.gnTestPoints)
			For i As Integer = num To gnTestPoints
				rst.TestPoints(i).Pintake = -1F
				rst.TestPoints(i).Pwf = -1F
				obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TestPointPressure" + Conversions.ToString(i), 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					If rst.TestPoints(i).bPIEntered <> 0S Then
						rst.TestPoints(i).Pintake = Conversions.ToSingle(obj)
					Else
						rst.TestPoints(i).Pwf = Conversions.ToSingle(obj)
					End If
				End If
				rst.TestPoints(i).Production = -1F
				obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TestPointProduction" + Conversions.ToString(i), 4, False, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					rst.TestPoints(i).Production = Conversions.ToSingle(obj)
				End If
			Next
		End Sub

		Public Sub ReadPTInfo()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TubingOD", 4, False, 2.875))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				rst.TubingOD = -1F
			Else
				rst.TubingOD = Conversions.ToSingle(obj)
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TubingID", 4, False, 2.441))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				rst.TubingID = -1F
			Else
				rst.TubingID = Conversions.ToSingle(obj)
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpType", 3, False, 1))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				obj = RuntimeHelpers.GetObjectValue(ini.GetListDefault("PumpType", 0, 2))
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					obj = 1
				Else
					obj = Operators.AddObject(obj, 1)
				End If
			End If
			rst.PumpType = Conversions.ToShort(obj)
			If RSWIN_DESC.rst.SPMEntered = 0S Then
				RSWIN_DESC.rst.CalcPlungerSize = Conversions.ToShort(ini.GetDataValue("CalcPlungerSize", 11, False, True))
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PlungerSize", 4, False, 1.5))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				rst.PlungerSize = Conversions.ToSingle(obj)
			End If
			rst.TubingAnchored = Conversions.ToShort(ini.GetDataValue("TubingAnchored", 11, False, True))
			If rst.TubingAnchored <> 0S Then
				rst.TubingAnchorDepth = Conversions.ToSingle(ini.GetDataValue("TubingAnchorDepth", 4, False, rst.PumpDepth))
				If rst.PumpDepth = 0F Then
					obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("PumpDepth", 4, False, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						rst.PumpDepth = Conversions.ToSingle(obj)
					End If
				End If
				If rst.TubingAnchorDepth > rst.PumpDepth Then
					rst.TubingAnchorDepth = rst.PumpDepth
				End If
			End If
			obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("IncludeBuoyancy", 11, False, DBNull.Value))
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				obj = RuntimeHelpers.GetObjectValue(ini.GetListDefault("IncludeBuoyancy", 0, 1))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					rst.gbIncludeBuoyancy = Operators.ConditionalCompareObjectEqual(obj, 0, False)
				Else
					rst.gbIncludeBuoyancy = False
				End If
			End If
			rst.gbCalcFriction = Conversions.ToBoolean(ini.GetDataValue("CalcFriction", 11, False, True))
			If RSWIN_DESC.bRodStarD Then
				rst.gbCalcFriction = False
			End If
			If RSWIN_DESC.bRodStarD Then
				rst.UpstrokeFriction = Conversions.ToSingle(ini.GetDataValue("UpstrokeFriction", 4, False, 0.1))
				rst.DownstrokeFriction = Conversions.ToSingle(ini.GetDataValue("DownstrokeFriction", 4, False, 0.1))
			Else
				rst.UpstrokeFriction = Conversions.ToSingle(ini.GetDataValue("UpstrokeFriction", 4, False, 1))
				rst.DownstrokeFriction = Conversions.ToSingle(ini.GetDataValue("DownstrokeFriction", 4, False, 1))
			End If
			rst.PumpFriction = Conversions.ToSingle(ini.GetDataValue("PumpFriction", 4, True, 200))
			rst.IncludeFluidInertia = Conversions.ToShort(ini.GetDataValue("IncludeFluidInertia", 11, False, False))
			rst.CompressibilityIndex = Conversions.ToSingle(ini.GetDataValue("CompressibilityIndex", 4, True, 3))
		End Sub

		Public Sub ReadPTInfo_Old()
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.TubingOD = Conversions.ToSingle(ini.GetDataValue("TubingOD", 4, False, 2.875))
				rst.TubingID = Conversions.ToSingle(ini.GetDataValue("TubingID", 4, False, 2.441))
				rst.PumpType = Conversions.ToShort(ini.GetDataValue("PumpType", 3, False, 1))
				rst.PlungerSize = Conversions.ToSingle(ini.GetDataValue("PlungerSize", 4, False, 1.5))
				rst.Apump = CSng((Math.Pow(CDbl(rst.PlungerSize), 2.0) * 3.141592653589793 / 4.0))
				rst.TubingAnchored = Conversions.ToShort(ini.GetDataValue("TubingAnchored", 11, False, True))
				rst.TubingAnchorDepth = Conversions.ToSingle(ini.GetDataValue("TubingAnchorDepth", 4, False, rst.PumpDepth))
				rst.Friction = Conversions.ToSingle(ini.GetDataValue("Friction", 4, False, 1))
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ReadPUData1(ByRef PU As RSWIN_DESC.PUDataRec)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim pudataRec As RSWIN_DESC.PUDataRec
				pudataRec.Initialize()
				rst.IDEntered = Conversions.ToShort(ini.GetDataValue("IDEntered", 11, False, True))
				rst.UnitID = Conversions.ToString(ini.GetDataValue("UnitID", 8, False, ""))
				Dim num As Integer = If((-If((PUDATA1.ReadPUData(rst.UnitID, pudataRec, False, True) > False), 1, 0)), 1, 0)
				rst.set_M(2, Conversions.ToSingle(ini.GetDataValue("Counterbalance", 4, False, 0)))
				pudataRec.CrankHole = Conversions.ToShort(ini.GetDataValue("CrankHole", 3, False, 1))
				pudataRec.CrankRotation = Conversions.ToShort(ini.GetDataValue("CrankRotation", 3, False, 1))
				rst.Unbalance = Conversions.ToSingle(ini.GetDataValue("Unbalance", 4, False, rst.Unbalance))
				If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) Then
					pudataRec.Unbalance = rst.Unbalance
				End If
				rst.CBDataType = Conversions.ToShort(ini.GetDataValue(".CBDataType", 3, False, 0))
				If rst.CBDataType = 1S Then
					rst.UnknownM = Conversions.ToBoolean(ini.GetDataValue("UnknownM", 11, False, True))
				ElseIf rst.CBDataType = 2S Then
					rst.CBAngle = Conversions.ToSingle(ini.GetDataValue("CBAngle", 4, False, 0))
					rst.CBEffect = Conversions.ToSingle(ini.GetDataValue("CBEffect", 4, False, 0))
				End If
				If pudataRec.UnitType <> 7S And pudataRec.UnitType <> 10S Then
					' The following expression was wrapped in a checked-expression
					pudataRec.R = pudataRec.CrankRadii(CInt((pudataRec.CrankHole - 1S)))
				End If
				PU = pudataRec
				kinemat.Kinconst(PU)
				kinemat.Unitstroke(PU)
			Catch ex As Exception
			End Try
		End Sub

		Public Function CSng_Regional(sInput As String) As Single
			' The following expression was wrapped in a checked-statement
			Dim result As Single
			If Convert.ToSingle("1,000") = 1F Then
				Dim num As Integer = Strings.Len(sInput)
				Dim text As String = ""
				Dim num2 As Integer = 1
				Dim num3 As Integer = num
				For i As Integer = num2 To num3
					Dim text2 As String = Strings.Mid(sInput, i, 1)
					If Operators.CompareString(text2, ".", False) = 0 Then
						text += "|"
					Else
						text += text2
					End If
				Next
				Dim str As String = text
				text = ""
				Dim num4 As Integer = 1
				Dim num5 As Integer = num
				For i As Integer = num4 To num5
					Dim text2 As String = Strings.Mid(str, i, 1)
					If Operators.CompareString(text2, ",", False) = 0 Then
						text += "."
					Else
						text += text2
					End If
				Next
				str = text
				text = ""
				Dim num6 As Integer = 1
				Dim num7 As Integer = num
				For i As Integer = num6 To num7
					Dim text2 As String = Strings.Mid(str, i, 1)
					If Operators.CompareString(text2, "|", False) = 0 Then
						text += ","
					Else
						text += text2
					End If
				Next
				result = Convert.ToSingle(text)
			Else
				result = Convert.ToSingle(sInput)
			End If
			Return result
		End Function

		Public Function GetPreferenceDataValue(sValueName As String, iVarType As Integer, vNotPresentDefault As Object) As Object
			Dim num2 As Integer
			Dim obj5 As Object
			Dim num4 As Integer
			Dim obj6 As Object
			Try
				IL_00:
				Dim num As Integer = 1
				If Not ini.INIKeyExists(RSWIN_DESC.SECT_PREFERENCES, sValueName) Then
					GoTo IL_270
				End If
				IL_13:
				num = 2
				Dim text As String = ""
				Dim str As String
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_PREFERENCES, sValueName, text, str, False)
				IL_2F:
				num = 3
				Dim obj As Object = Strings.Left(str, regProfileString)
				IL_3B:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_43:
				num = 5
				Select Case iVarType
					Case 3
						IL_77:
						num = 9
						If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
							GoTo IL_9A
						End If
						IL_89:
						num = 10
						obj = RuntimeHelpers.GetObjectValue(vNotPresentDefault)
						IL_95:
						Exit Select
						IL_9A:
						num = 12
						IL_9E:
						num = 13
						obj = Conversions.ToInteger(obj)
						IL_B0:
					Case 4
						IL_B5:
						num = 17
						If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
							GoTo IL_D8
						End If
						IL_C7:
						num = 18
						obj = RuntimeHelpers.GetObjectValue(vNotPresentDefault)
						IL_D3:
						Exit Select
						IL_D8:
						num = 20
						IL_DC:
						num = 21
						If Information.VarType(RuntimeHelpers.GetObjectValue(obj)) <> VariantType.[String] Then
							GoTo IL_107
						End If
						IL_EF:
						num = 22
						text = Conversions.ToString(obj)
						ini.CheckForDecimal(text)
						obj = text
						IL_107:
						num = 24
						obj = Convert.ToSingle(RuntimeHelpers.GetObjectValue(obj))
						IL_11E:
					Case 8
						IL_123:
						num = 28
						obj = Convert.ToString(RuntimeHelpers.GetObjectValue(obj))
						IL_135:
					Case 11
						IL_13A:
						num = 31
						Dim obj2 As Object = Nothing
						Dim typeFromHandle As Type = GetType(Strings)
						Dim text2 As String = "UCase"
						Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(obj) }
						Dim array2 As Object() = array
						Dim array3 As String() = Nothing
						Dim array4 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { True }
						Dim obj3 As Object = NewLateBinding.LateGet(obj2, typeFromHandle, text2, array2, array3, array4, array5)
						If array5(0) Then
							obj = RuntimeHelpers.GetObjectValue(array(0))
						End If
						Dim obj4 As Object = obj3
						IL_190:
						num = 34
						If Not Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(obj4, "ON", False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(obj4, "YES", False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(obj4, "TRUE", False))), True, False)) Then
							GoTo IL_1F3
						End If
						IL_1E5:
						num = 35
						obj = True
						IL_1F1:
						Exit Select
						IL_1F3:
						num = 37
						If Not Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(obj4, "OFF", False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(obj4, "NO", False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(obj4, "FALSE", False))), True, False)) Then
							GoTo IL_256
						End If
						IL_248:
						num = 38
						obj = False
						IL_254:
						Exit Select
						IL_256:
						num = 41
						obj = (Conversions.ToInteger(obj) <> 0)
				End Select
				IL_26E:
				GoTo IL_280
				IL_270:
				num = 45
				IL_274:
				num = 46
				obj = RuntimeHelpers.GetObjectValue(vNotPresentDefault)
				IL_280:
				num = 48
				obj5 = obj
				IL_28C:
				GoTo IL_3A9
				IL_291:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_365:
				GoTo IL_39E
				IL_367:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_37A:
			Catch obj7 When endfilter(TypeOf obj6 Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj7, Exception)
				GoTo IL_367
			End Try
			IL_39E:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3A9:
			Dim result As Object = obj5
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub SavePreferenceDataValue(sKey As String, vValue As Object)
			Try
				If Strings.Len(sKey) = 0 Then
					Dim text As String = Conversions.ToString(0L)
					Dim text2 As String = Conversions.ToString(0L)
					Dim num As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_PREFERENCES, text, text2, RSWIN_DESC.sINIFile))
				ElseIf Information.IsDBNull(RuntimeHelpers.GetObjectValue(vValue)) Then
					Dim text2 As String = Conversions.ToString(0L)
					Dim num As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_PREFERENCES, sKey, text2, RSWIN_DESC.sINIFile))
				Else
					Dim text2 As String = Convert.ToString(RuntimeHelpers.GetObjectValue(vValue))
					Dim num As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_PREFERENCES, sKey, text2, RSWIN_DESC.sINIFile))
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in SavePreferenceDataValue: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub CheckForDecimal(ByRef vValue As String)
			Try
				If Strings.InStr(vValue, ".", CompareMethod.Binary) > 0 AndAlso Operators.CompareString(RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator, ".", False) <> 0 Then
					vValue = vValue.Replace(".", RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Enum EDesignStyle
			ersSteel
			ersFiberglass
			ersRibbonRod
			ersManual
			ersAPI
		End Enum
	End Module
End Namespace
