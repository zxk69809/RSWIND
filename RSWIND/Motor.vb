Imports System
Imports System.Collections
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports ThetaStdInfo

Namespace RSWINV3
	Friend NotInheritable Module Motor
		Public Function GetMotorInfo(iInfoType As Integer) As Object
			Dim result As Object = DBNull.Value
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Select Case iInfoType
				Case 0
					result = rst.mfRatedHP
				Case 1
					result = rst.msMotorKindName
				Case 2
					result = rst.msMotorSettingName
				Case 3
					result = rst.msMotorSizeName
				Case 4
					result = CInt((rst.miMotorKind + 1S))
				Case 5
					result = False
					Dim motorInfo As Object = Motor.GetMotorInfo(4)
					If Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 3, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 2, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 4, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 6, False))), True, False)) Then
						result = True
					End If
				Case 6
					result = rst.mnMotorSettings
			End Select
			Return result
		End Function

		Public Sub MotorEfficiency(Tq As Single, ByRef MotorEff As Single, ByRef bOutOfRange As Boolean)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Single = CSng((CDbl(rst.TotalTheta) / 6.283185307179586))
			Dim num2 As Single = rst.SPM * num
			Dim num3 As Single = rst.mfFullLoadSpeed / num2
			Tq /= num3
			If Tq < rst.mfTorque(0) Then
				Tq = -Tq
			End If
			If Tq > rst.mfTorque(CInt((rst.mnMotorCurvePoints - 1S))) Then
				Tq = rst.mfTorque(CInt((rst.mnMotorCurvePoints - 1S)))
				bOutOfRange = True
			Else
				bOutOfRange = False
			End If
			Dim num4 As Integer = 1
			Dim num5 As Integer = CInt((rst.mnMotorCurvePoints - 1S))
			For i As Integer = num4 To num5
				If Tq <= rst.mfTorque(i) Then
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					MotorEff = rst.mfEfficiency(i - 1) + (Tq - rst.mfTorque(i - 1)) / (rst.mfTorque(i) - rst.mfTorque(i - 1)) * (rst.mfEfficiency(i) - rst.mfEfficiency(i - 1))
					Exit For
				End If
			Next
			MotorEff /= 100F
		End Sub

		Public Sub WriteMotorData(frn As Short)
			Dim value As Short = 1S
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			FileSystem.FilePut(CInt(frn), value, -1L)
			FileSystem.FilePut(CInt(frn), rst.miMotorKind, -1L)
			If rst.miMotorKind + 1S > 9S Then
				Dim text As String = Conversions.ToString(Motor.GetMotorInfo(3))
				Dim text2 As String = Conversions.ToString(Motor.GetMotorInfo(2))
				If Strings.InStr(text, "АДЧР", CompareMethod.Binary) > 0 Then
					text = text.Replace("АДЧР", "ADYP")
				Else
					text = text
				End If
				If Strings.InStr(text, "ВА", CompareMethod.Binary) > 0 Then
					text = text.Replace("ВА", "BA")
				End If
				If Strings.InStr(text, "М", CompareMethod.Binary) > 0 Then
					text = text.Replace("М", "M")
				End If
				If Strings.InStr(text, "S", CompareMethod.Binary) > 0 Then
					text = text.Replace("S", "S")
				End If
				If Strings.InStr(text, "L", CompareMethod.Binary) > 0 Then
					text = text.Replace("L", "L")
				End If
				If Strings.InStr(text, "IP", CompareMethod.Binary) > 0 Then
					text = text.Replace("IP", "IP")
				End If
				If Strings.InStr(text2, "АДЧР", CompareMethod.Binary) > 0 Then
					text2 = text2.Replace("АДЧР", "ADYP")
				Else
					text2 = text2
				End If
				If Strings.InStr(text2, "ВА", CompareMethod.Binary) > 0 Then
					text2 = text2.Replace("ВА", "BA")
				End If
				If Strings.InStr(text2, "М", CompareMethod.Binary) > 0 Then
					text2 = text2.Replace("М", "M")
				End If
				If Strings.InStr(text2, "S", CompareMethod.Binary) > 0 Then
					text2 = text2.Replace("S", "S")
				End If
				If Strings.InStr(text2, "L", CompareMethod.Binary) > 0 Then
					text2 = text2.Replace("L", "L")
				End If
				If Strings.InStr(text2, "IP", CompareMethod.Binary) > 0 Then
					text2 = text2.Replace("IP", "IP")
				End If
				FILEIO.PutString(frn, text)
				FILEIO.PutString(frn, text2)
			Else
				FILEIO.PutString(frn, rst.msMotorSizeName)
				FILEIO.PutString(frn, rst.msMotorSettingName)
			End If
		End Sub

		Public Sub ReadMotorData(frn As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Short
				FileSystem.FileGet(frn, num, -1L)
				Dim num2 As Short
				Dim text As String
				Dim text2 As String
				If num = 1S Then
					FileSystem.FileGet(frn, num2, -1L)
					Motor.SelectMotorKind(CInt(num2))
					FILEIO.GetString(CShort(frn), text)
					If num2 > 7S Then
						Motor.CorrectMotorSizeSettingName(CInt((num2 + 1S)), text)
					End If
					Motor.SelectMotorSizeByName(text)
					FILEIO.GetString(CShort(frn), text2)
					If num2 > 7S Then
						Motor.CorrectMotorSizeSettingName(CInt((num2 + 1S)), text2)
					End If
					Motor.SelectMotorSettingByName(text2)
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					rst.miMotorKind = num2
					rst.msMotorSizeName = text
					rst.msMotorSettingName = text2
				End If
				Try
					If num2 = 0S AndAlso Operators.CompareString(text2.Trim(), "", False) = 0 Then
						text2 = text
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
				Dim sMsg As String = "Error in ReadMotorData: " + ex2.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub SelectMotorKind(iMotorKind As Integer)
			' The following expression was wrapped in a checked-statement
			Dim teMotorKind As teMotorKind = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.MotorDB().MotorKinds().Item(iMotorKind + 1)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.miMotorKind = CShort(iMotorKind)
			rst.msMotorKindName = teMotorKind.Name
			rst.mnMotorSizes = CShort(teMotorKind.MotorSizes.Count())
		End Sub

		Public Sub SelectMotorKindByMotorType(iMotorType As Integer)
			' The following expression was wrapped in a checked-expression
			Motor.SelectMotorKind(iMotorType - 1)
		End Sub

		Public Sub SelectMotorSetting(iMotorSetting As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				cRODSTAR.miMotorSetting = CShort(iMotorSetting)
				Dim teMotorSetting As teMotorSetting = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.MotorDB().MotorKinds().Item(CInt((cRODSTAR.miMotorKind + 1S))).MotorSizes.Item(CInt(cRODSTAR.miMotorSize) + cRODSTAR.iFirstSizeID).MotorSettings.Item(iMotorSetting + cRODSTAR.iFirstSettingID)
				If teMotorSetting Is Nothing Then
					Dim motorSettings As teMotorSettings = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.MotorDB().MotorKinds().Item(CInt((cRODSTAR.miMotorKind + 1S))).MotorSizes.Item(CInt(cRODSTAR.miMotorSize) + cRODSTAR.iFirstSizeID).MotorSettings
					If motorSettings IsNot Nothing Then
						Dim i As Integer = 0
						Try
							For Each obj As Object In motorSettings
								Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
								teMotorSetting = CType(NewLateBinding.LateGet(objectValue, Nothing, "value", New Object(-1) {}, Nothing, Nothing, Nothing), teMotorSetting)
								If i = iMotorSetting Then
									Exit For
								End If
								i += 1
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If
				End If
				If teMotorSetting IsNot Nothing Then
					cRODSTAR.msMotorSettingName = teMotorSetting.Name
					cRODSTAR.mfMaxLoad = teMotorSetting.MaxLoad
					cRODSTAR.mfMaxSPV = teMotorSetting.MaxSPV
					cRODSTAR.mfFullLoadSpeed = teMotorSetting.FullLoadRPM
					cRODSTAR.mfRatedHP = teMotorSetting.RatedHP
					Dim motorCurves As Object = teMotorSetting.MotorCurves
					Dim array As teMotorCurve() = New teMotorCurve(Conversions.ToInteger(NewLateBinding.LateGet(motorCurves, Nothing, "count", New Object(-1) {}, Nothing, Nothing, Nothing)) + 1 - 1) {}
					Dim i As Integer = Conversions.ToInteger(NewLateBinding.LateGet(motorCurves, Nothing, "count", New Object(-1) {}, Nothing, Nothing, Nothing))
					cRODSTAR.mnMotorCurvePoints = CShort(i)
					cRODSTAR.iFirstCurvePointID = 10000
					Try
						For Each obj2 As Object In CType(motorCurves, IEnumerable)
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj2)
							Dim teMotorCurve As teMotorCurve = CType(NewLateBinding.LateGet(objectValue, Nothing, "value", New Object(-1) {}, Nothing, Nothing, Nothing), teMotorCurve)
							If teMotorCurve.MotorCurvePointID < cRODSTAR.iFirstCurvePointID Then
								cRODSTAR.iFirstCurvePointID = teMotorCurve.MotorCurvePointID
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					Try
						For Each obj3 As Object In CType(motorCurves, IEnumerable)
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj3)
							Dim teMotorCurve As teMotorCurve = CType(NewLateBinding.LateGet(objectValue, Nothing, "value", New Object(-1) {}, Nothing, Nothing, Nothing), teMotorCurve)
							array(teMotorCurve.MotorCurvePointID - cRODSTAR.iFirstCurvePointID) = teMotorCurve
						Next
					Finally
						Dim enumerator3 As IEnumerator
						If TypeOf enumerator3 Is IDisposable Then
							TryCast(enumerator3, IDisposable).Dispose()
						End If
					End Try
					Dim array2 As Single() = New Single(CInt((cRODSTAR.mnMotorCurvePoints - 1S + 1S)) - 1) {}
					cRODSTAR.mfTorque = array2
					array2 = New Single(CInt((cRODSTAR.mnMotorCurvePoints - 1S + 1S)) - 1) {}
					cRODSTAR.mfEfficiency = array2
					Dim num As Integer = 0
					Dim num2 As Integer = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(motorCurves, Nothing, "count", New Object(-1) {}, Nothing, Nothing, Nothing), 1))
					i = num
					While i <= num2
						cRODSTAR.mfTorque(i) = array(i).Torque
						cRODSTAR.mfEfficiency(i) = array(i).Efficiency
						i += 1
					End While
				End If
				cRODSTAR = Nothing
			Catch ex As Exception
				Dim sMsg As String = "Error in SelectMotorSetting: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub GetMotorInfoList(iList As Integer, ByRef asMotorInfoList As String())
			Dim num As Integer = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.MotorDB().MotorKinds().Count()
			Dim array As teMotorKind() = New teMotorKind(num + 1 - 1) {}
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Select Case iList
					Case 0
						Dim num2 As Integer = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.MotorDB().MotorKinds().Count()
						If num2 > 0 Then
							asMotorInfoList = New String(num2 - 1 + 1 - 1) {}
						Else
							asMotorInfoList = New String(0) {}
						End If
						Try
							For Each obj As Object In RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.MotorDB().MotorKinds()
								Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
								Dim teMotorKind As teMotorKind = CType(NewLateBinding.LateGet(objectValue, Nothing, "value", New Object(-1) {}, Nothing, Nothing, Nothing), teMotorKind)
								array(teMotorKind.MotorKindID) = teMotorKind
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						Dim num3 As Integer = 1
						Dim num4 As Integer = num
						For i As Integer = num3 To num4
							Dim teMotorKind As teMotorKind = array(i)
							asMotorInfoList(i - 1) = teMotorKind.Name
							Debug.WriteLine(String.Concat(New String() { teMotorKind.Name, " , ", Conversions.ToString(teMotorKind.MotorKindID), " , ", Conversions.ToString(teMotorKind.UltraHighSlip) }))
						Next
						GoTo IL_473
					Case 1
						Dim motorSizes As teMotorSizes = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.MotorDB().MotorKinds().Item(CInt((cRODSTAR.miMotorKind + 1S))).MotorSizes
						Dim i As Integer = motorSizes.Count()
						cRODSTAR.mnMotorSizes = CShort(i)
						If cRODSTAR.mnMotorSizes > 0S Then
							asMotorInfoList = New String(CInt((cRODSTAR.mnMotorSizes - 1S + 1S)) - 1) {}
						Else
							asMotorInfoList = New String(0) {}
						End If
						cRODSTAR.iFirstSizeID = 10000
						Try
							For Each obj2 As Object In motorSizes
								Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(obj2)
								Dim teMotorSize As teMotorSize = CType(NewLateBinding.LateGet(objectValue2, Nothing, "Value", New Object(-1) {}, Nothing, Nothing, Nothing), teMotorSize)
								If teMotorSize.MotorSizeID < cRODSTAR.iFirstSizeID Then
									cRODSTAR.iFirstSizeID = teMotorSize.MotorSizeID
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
						Try
							For Each obj3 As Object In motorSizes
								Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(obj3)
								Dim teMotorSize As teMotorSize = CType(NewLateBinding.LateGet(objectValue2, Nothing, "Value", New Object(-1) {}, Nothing, Nothing, Nothing), teMotorSize)
								i = teMotorSize.MotorSizeID - cRODSTAR.iFirstSizeID
								asMotorInfoList(i) = teMotorSize.Name
							Next
							GoTo IL_473
						Finally
							Dim enumerator3 As IEnumerator
							If TypeOf enumerator3 Is IDisposable Then
								TryCast(enumerator3, IDisposable).Dispose()
							End If
						End Try
					Case 2
					Case Else
						GoTo IL_473
				End Select
				If cRODSTAR.mnMotorSettings > 0S Then
					Dim teMotorSize As teMotorSize = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.MotorDB().MotorKinds().Item(CInt((cRODSTAR.miMotorKind + 1S))).MotorSizes.Item(CInt(cRODSTAR.miMotorSize) + cRODSTAR.iFirstSizeID)
					cRODSTAR.iFirstSettingID = 10000
					Try
						For Each obj4 As Object In teMotorSize.MotorSettings
							Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(obj4)
							Dim teMotorSetting As teMotorSetting = CType(NewLateBinding.LateGet(objectValue3, Nothing, "value", New Object(-1) {}, Nothing, Nothing, Nothing), teMotorSetting)
							If teMotorSetting.MotorSettingID < cRODSTAR.iFirstSettingID Then
								cRODSTAR.iFirstSettingID = teMotorSetting.MotorSettingID
							End If
						Next
					Finally
						Dim enumerator4 As IEnumerator
						If TypeOf enumerator4 Is IDisposable Then
							TryCast(enumerator4, IDisposable).Dispose()
						End If
					End Try
					Dim motorSettings As teMotorSettings = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.MotorDB().MotorKinds().Item(CInt((cRODSTAR.miMotorKind + 1S))).MotorSizes.Item(CInt(cRODSTAR.miMotorSize) + cRODSTAR.iFirstSizeID).MotorSettings
					If motorSettings.Count() > 0 Then
						asMotorInfoList = New String(motorSettings.Count() - 1 + 1 - 1) {}
						cRODSTAR.mnMotorSettings = CShort(motorSettings.Count())
					Else
						asMotorInfoList = New String(0) {}
						cRODSTAR.mnMotorSettings = 1S
					End If
					Try
						For Each obj5 As Object In motorSettings
							Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(obj5)
							Dim teMotorSetting As teMotorSetting = CType(NewLateBinding.LateGet(objectValue2, Nothing, "value", New Object(-1) {}, Nothing, Nothing, Nothing), teMotorSetting)
							Dim i As Integer = teMotorSetting.MotorSettingID - cRODSTAR.iFirstSettingID
							asMotorInfoList(i) = teMotorSetting.Name
						Next
					Finally
						Dim enumerator5 As IEnumerator
						If TypeOf enumerator5 Is IDisposable Then
							TryCast(enumerator5, IDisposable).Dispose()
						End If
					End Try
				End If
				IL_473:
				cRODSTAR = Nothing
			Catch ex As Exception
				Dim sMsg As String = "Error in GetMotorInfoList: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub SelectMotorSettingByName(sMotorSettingName As String)
			Try
				Dim length As Integer = sMotorSettingName.Length
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If(If((-If(((length = 0) > False), 1S, 0S)), 1S, 0S) Or rst.CalcMotorSize) <> 0S Then
					Motor.SelectMotorSetting(0)
				Else
					Dim array As String()
					Motor.GetMotorInfoList(2, array)
					If array IsNot Nothing Then
						Dim num As Integer = 0
						Dim num2 As Integer = Information.UBound(array, 1)
						For i As Integer = num To num2
							If Strings.InStr(Strings.LCase(array(i)), Strings.LCase(sMotorSettingName), CompareMethod.Binary) > 0 Then
								Motor.SelectMotorSetting(i)
								Exit For
							End If
						Next
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in GetMotorSettingByName: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub SelectMotorSettingByTorqueMode(iTorqueMode As Integer)
			' The following expression was wrapped in a checked-expression
			Motor.SelectMotorSetting(iTorqueMode - 1)
		End Sub

		Public Sub SelectMotorSize(iMotorSize As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.miMotorSize = CShort(iMotorSize)
				Dim teMotorSize As teMotorSize = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.MotorDB().MotorKinds().Item(CInt((rst.miMotorKind + 1S))).MotorSizes.Item(iMotorSize + rst.iFirstSizeID)
				rst.msMotorSizeName = teMotorSize.Name
				rst.mnMotorSettings = CShort(teMotorSize.MotorSettings.Count())
			Catch ex As Exception
			End Try
		End Sub

		Public Sub SelectMotorSizeByName(sMotorSizeName As String)
			' The following expression was wrapped in a checked-statement
			Try
				Dim array As String()
				Motor.GetMotorInfoList(1, array)
				Dim num As Integer = 0
				Dim num2 As Integer = Information.UBound(array, 1)
				For i As Integer = num To num2
					If Strings.InStr(Strings.LCase(array(i)), Strings.LCase(sMotorSizeName), CompareMethod.Binary) = 1 Then
						Motor.SelectMotorSize(i)
						Exit For
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Sub SelectMotorSizeByRatedHP(fRatedHP As Single)
			' The following expression was wrapped in a checked-statement
			Try
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Motor.GetMotorInfo(4))
				Dim num As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue))
				If num = 1 Or num = 7 Or num >= 8 Then
					Dim array As String()
					Motor.GetMotorInfoList(1, array)
					Dim num2 As Integer = 0
					Dim num3 As Integer = Information.UBound(array, 1)
					For i As Integer = num2 To num3
						Dim length As Integer = Strings.InStr(array(i), " ", CompareMethod.Binary)
						Dim text As String = array(i).Substring(0, length)
						If Operators.CompareString(text.Trim(), "", False) = 0 Then
							text = array(i)
						End If
						If Conversion.Val(text) = CDbl(fRatedHP) Then
							Motor.SelectMotorSize(i)
							Exit For
						End If
					Next
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function CalculateMotorSPV(bSilentOnError As Boolean, ByRef fRet As Single) As Boolean
			Dim flag As Boolean = True
			fRet = 0F
			Dim result As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim motorInfo As Object = Motor.GetMotorInfo(4)
				Dim num As Single
				If Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 1, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 7, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 8, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 9, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 10, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 11, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 12, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 13, False))), True, False)) Then
					If rst.CalcMotorSize <> 0S Then
						rst.mfMaxLoad = 1F
						num = 1F
					Else
						num = CSng((1.75 * Math.Pow(CDbl(rst.PlungerSize), 2.0) * CDbl(rst.SPM) * CDbl(rst.PU.KinematicStroke) * CDbl(rst.FluidLevel) * CDbl(rst.FluidSPGR) / 720000.0))
						If num > rst.mfRatedHP Then
							num = rst.mfRatedHP
						End If
						rst.mfMaxLoad = rst.mfRatedHP
					End If
					rst.mfMaxSPV = 10F
				ElseIf Operators.ConditionalCompareObjectEqual(motorInfo, 3, False) Then
					num = CSng((1.3 * Math.Pow(CDbl(rst.PlungerSize), 2.0) * CDbl(rst.SPM) * CDbl(rst.PU.KinematicStroke) * CDbl(rst.FluidLevel) * CDbl(rst.FluidSPGR) / 720000.0))
					If num > rst.mfRatedHP AndAlso bSilentOnError Then
						num = rst.mfRatedHP
					End If
				ElseIf Operators.ConditionalCompareObjectEqual(motorInfo, 2, False) Then
					Dim num2 As Single = CSng((0.001211 - 0.000116832 * CDbl(rst.PlungerSize) + 0.1168 * Math.Pow(CDbl(rst.PlungerSize), 2.0)))
					Dim num3 As Single = CSng((0.000673375 + 0.0192648 * CDbl(rst.SPM) - 0.000272575 * Math.Pow(CDbl(rst.SPM), 2.0)))
					num = num2 * rst.FluidLevel * rst.PU.KinematicStroke * num3 * rst.FluidSPGR
					If num > rst.mfRatedHP AndAlso bSilentOnError Then
						num = rst.mfRatedHP
					End If
				ElseIf Operators.ConditionalCompareObjectEqual(motorInfo, 4, False) Then
					Dim num2 As Single = CSng((0.001211 - 0.000116832 * CDbl(rst.PlungerSize) + 0.1168 * Math.Pow(CDbl(rst.PlungerSize), 2.0)))
					Dim num3 As Single = CSng((0.000673375 + 0.0192648 * CDbl(rst.SPM) - 0.000272575 * Math.Pow(CDbl(rst.SPM), 2.0)))
					num = num2 * rst.FluidLevel * rst.PU.KinematicStroke * num3 * rst.FluidSPGR
					If num > rst.mfRatedHP AndAlso bSilentOnError Then
						num = rst.mfRatedHP
					End If
				ElseIf Operators.ConditionalCompareObjectEqual(motorInfo, 5, False) Then
					num = CSng((1.75 * Math.Pow(CDbl(rst.PlungerSize), 2.0) * CDbl(rst.SPM) * CDbl(rst.PU.KinematicStroke) * CDbl(rst.FluidLevel) * CDbl(rst.FluidSPGR) / 720000.0))
					If num > rst.mfRatedHP Then
						num = rst.mfRatedHP
					End If
					rst.mfMaxLoad = rst.mfRatedHP
					rst.mfMaxSPV = 6F
				ElseIf Operators.ConditionalCompareObjectEqual(motorInfo, 6, False) Then
					Dim num2 As Single = CSng((0.001211 - 0.000116832 * CDbl(rst.PlungerSize) + 0.1168 * Math.Pow(CDbl(rst.PlungerSize), 2.0)))
					Dim num3 As Single = CSng((0.000673375 + 0.0192648 * CDbl(rst.SPM) - 0.000272575 * Math.Pow(CDbl(rst.SPM), 2.0)))
					num = num2 * rst.FluidLevel * rst.PU.KinematicStroke * num3 * rst.FluidSPGR
					If num > rst.mfRatedHP AndAlso bSilentOnError Then
						num = rst.mfRatedHP
					End If
				End If
				If Conversions.ToBoolean(Operators.OrObject(num <= rst.mfMaxLoad, Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)))) Then
					fRet = num / rst.mfMaxLoad * rst.mfMaxSPV / 100F
				Else
					num = rst.mfMaxLoad
					fRet = num / rst.mfMaxLoad * rst.mfMaxSPV / 100F
					flag = False
					Dim sMsg As String
					Util.LoadMessage(206, sMsg)
					If RSWIN_DESC.rst.gbBatch Then
						Batch.BatchMessage(sMsg)
					ElseIf Not bSilentOnError Then
						Try
							flag = True
						Catch ex As Exception
						End Try
					End If
				End If
				result = flag
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Public Sub SelectMotorFromOldInfo(iMotorType As Integer, fMotorSize As Single, sMotorSizeName As String, iTorqueMode As Integer)
			Motor.SelectMotorKindByMotorType(iMotorType)
			If iMotorType = 1 Or iMotorType = 7 Or iMotorType >= 8 Then
				Motor.SelectMotorSizeByRatedHP(fMotorSize)
			Else
				Motor.SelectMotorSizeByName(sMotorSizeName)
			End If
			If RSWIN_DESC.rst.mnMotorSettings = 1S Then
				Motor.SelectMotorSetting(0)
			ElseIf Not(iMotorType = 1 Or iMotorType = 7 Or iMotorType >= 8) Then
				Motor.SelectMotorSettingByTorqueMode(iTorqueMode)
			End If
		End Sub

		Public Sub LogMotorData()
			' The following expression was wrapped in a checked-statement
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Debug.WriteLine(String.Concat(New String() { Conversions.ToString(CInt(rst.miMotorKind)), " , ", rst.msMotorKindName, " , ", Conversions.ToString(CInt(rst.miFirstSize)), " , ", Conversions.ToString(CInt(rst.mnMotorSizes)) }))
				Debug.WriteLine(String.Concat(New String() { rst.msMotorSettingName, " , ", Conversions.ToString(rst.mfMaxLoad), " , ", Conversions.ToString(rst.mfMaxSPV), " , ", Conversions.ToString(rst.mfFullLoadSpeed), " , ", Conversions.ToString(rst.mfRatedHP), " , ", Conversions.ToString(CInt(rst.mnMotorCurvePoints)) }))
				Debug.WriteLine(String.Concat(New String() { rst.msMotorSizeName, " , ", Conversions.ToString(CInt(rst.miFirstSetting)), " , ", Conversions.ToString(CInt(rst.mnMotorSettings)) }))
				Dim num As Integer = 1
				Dim num2 As Integer = CInt((rst.mnMotorCurvePoints - 1S))
				For i As Integer = num To num2
					Debug.WriteLine(Conversions.ToString(rst.mfTorque(i)) + " , " + Conversions.ToString(rst.mfEfficiency(i)))
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Sub CorrectMotorSizeSettingName(iMotorType As Integer, ByRef sName As String)
			Try
				If Strings.InStr(sName, "?", CompareMethod.Binary) > 0 Then
					Select Case iMotorType
						Case 9
							If Strings.InStr(sName, "74 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "225", CompareMethod.Binary) > 0 Then
								sName = "74 ВА225М4"
							ElseIf Strings.InStr(sName, "53.5 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "280", CompareMethod.Binary) > 0 Then
								sName = "53.5 АДЧР280S8"
							ElseIf Strings.InStr(sName, "53.5 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "250", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "53.5 АДЧР250S6"
							ElseIf Strings.InStr(sName, "53.5 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "250", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "53.5 АДЧР250М8"
							ElseIf Strings.InStr(sName, "40", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "40 АДЧР200L6"
							ElseIf Strings.InStr(sName, "40", CompareMethod.Binary) > 0 And Strings.InStr(sName, "180", CompareMethod.Binary) > 0 And Strings.InStr(sName, "4", CompareMethod.Binary) > 0 Then
								sName = "40 АДЧР180М4"
							ElseIf Strings.InStr(sName, "37.5 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "37.5 АДЧР200L6"
							ElseIf Strings.InStr(sName, "29.5 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "180", CompareMethod.Binary) > 0 And Strings.InStr(sName, "4", CompareMethod.Binary) > 0 Then
								sName = "29.5 ВА180S4"
							ElseIf Strings.InStr(sName, "27 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "27 АДЧР200L8"
							ElseIf Strings.InStr(sName, "25 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "180", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "25 ВА180М6"
							ElseIf Strings.InStr(sName, "25 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "4", CompareMethod.Binary) > 0 Then
								sName = "25 ВА160М4"
							ElseIf Strings.InStr(sName, "23 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "23 АДЧР200М8"
							ElseIf Strings.InStr(sName, "23 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "180", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "23 АДЧР180М6"
							ElseIf Strings.InStr(sName, "20 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "20 ВА160М6"
							ElseIf Strings.InStr(sName, "19 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "19 АДЧР160М6"
							ElseIf Strings.InStr(sName, "17.5 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "4", CompareMethod.Binary) > 0 Then
								sName = "17.5 АДЧР160S4"
							ElseIf Strings.InStr(sName, "7.5 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "132", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "7.5 ВА132S6"
							ElseIf Strings.InStr(sName, "7.5 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "132", CompareMethod.Binary) > 0 And Strings.InStr(sName, "4", CompareMethod.Binary) > 0 Then
								sName = "7.5 ВА132S4"
							End If
						Case 10
							If Strings.InStr(sName, "10", CompareMethod.Binary) > 0 Then
								sName = sName.Replace("????", "АДЧР")
								sName = sName.Replace("?", "S")
							ElseIf Strings.InStr(sName, "15", CompareMethod.Binary) > 0 Then
								sName = sName.Replace("????", "АДЧР")
								sName = sName.Replace("?", "М")
							End If
						Case 11
							If Strings.InStr(sName, "120 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "250", CompareMethod.Binary) > 0 Then
								sName = "120 АДЧР250М4"
							ElseIf Strings.InStr(sName, "74 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "250", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "74 АДЧР250М6"
							ElseIf Strings.InStr(sName, "67 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "280", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "67 АДЧР280S8"
							ElseIf Strings.InStr(sName, "54 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "250", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "54 АДЧР250М8"
							ElseIf Strings.InStr(sName, "50 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "225", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "50 АДЧР225М6"
							ElseIf Strings.InStr(sName, "50 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "250", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "50 АДЧР250S8"
							ElseIf Strings.InStr(sName, "50 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 And Strings.InStr(sName, "4", CompareMethod.Binary) > 0 Then
								sName = "50 АДЧР200М4"
							ElseIf Strings.InStr(sName, "50 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 And Strings.InStr(sName, "23", CompareMethod.Binary) > 0 Then
								sName = "50 АДЧР200L6 IP23"
							ElseIf Strings.InStr(sName, "48 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "250", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "48 АДЧР250S8"
							ElseIf Strings.InStr(sName, "47 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "250", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "47 АДЧР250S8"
							ElseIf Strings.InStr(sName, "40 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "225", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "40 АДЧР225М8"
							ElseIf Strings.InStr(sName, "40 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "180", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "40 АДЧР180М6"
							ElseIf Strings.InStr(sName, "40 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "180", CompareMethod.Binary) > 0 And Strings.InStr(sName, "4", CompareMethod.Binary) > 0 Then
								sName = "40 АДЧР180М4"
							ElseIf Strings.InStr(sName, "30 ???", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "30 АДЧР200L8"
							ElseIf Strings.InStr(sName, "30 ???", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "30 АДЧР200M6"
							ElseIf Strings.InStr(sName, "30 ??", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "30 ВА200L8"
							ElseIf Strings.InStr(sName, "30 ??", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "30 ВА200L6"
							ElseIf Strings.InStr(sName, "30", CompareMethod.Binary) > 0 And Strings.InStr(sName, "180", CompareMethod.Binary) > 0 And Strings.InStr(sName, "4", CompareMethod.Binary) > 0 Then
								sName = "30 АДЧР180S4"
							ElseIf Strings.InStr(sName, "25", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "25 АДЧР200М8"
							ElseIf Strings.InStr(sName, "25", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "25 АДЧР200L8"
							ElseIf Strings.InStr(sName, "25", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "4", CompareMethod.Binary) > 0 Then
								sName = "25 АДЧР160М4"
							ElseIf Strings.InStr(sName, "20", CompareMethod.Binary) > 0 And Strings.InStr(sName, "180", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "20 АДЧР180М8"
							ElseIf Strings.InStr(sName, "20", CompareMethod.Binary) > 0 And Strings.InStr(sName, "180", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "20 АДЧР180М6"
							ElseIf Strings.InStr(sName, "20", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "20 АДЧР160М6"
							ElseIf Strings.InStr(sName, "20", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "4", CompareMethod.Binary) > 0 Then
								sName = "20 АДЧР160S4"
							ElseIf Strings.InStr(sName, "17.5", CompareMethod.Binary) > 0 And Strings.InStr(sName, "180", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "17.5 АДЧР180М8"
							ElseIf Strings.InStr(sName, "17.5", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "17.5 АДЧР160М6"
							ElseIf Strings.InStr(sName, "17.5", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "17.5 АДЧР160S6"
							ElseIf Strings.InStr(sName, "15", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "15 АДЧР160М8'"
							ElseIf Strings.InStr(sName, "15", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "15 АДЧР160S6"
							ElseIf Strings.InStr(sName, "10", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "8", CompareMethod.Binary) > 0 Then
								sName = "10 АДЧР160S8"
							ElseIf Strings.InStr(sName, "10", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "10 АДЧР160S6"
							ElseIf Strings.InStr(sName, "10", CompareMethod.Binary) > 0 And Strings.InStr(sName, "132", CompareMethod.Binary) > 0 And Strings.InStr(sName, "6", CompareMethod.Binary) > 0 Then
								sName = "10 АДЧР132М6"
							ElseIf Strings.InStr(sName, "10", CompareMethod.Binary) > 0 And Strings.InStr(sName, "132", CompareMethod.Binary) > 0 And Strings.InStr(sName, "4", CompareMethod.Binary) > 0 Then
								sName = "10 АДЧР132S4"
							End If
						Case 12
							sName = sName.Replace("????", "АДЧР")
							sName = sName.Replace("?", "М")
						Case 13
							If Strings.InStr(sName, "50 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "225", CompareMethod.Binary) > 0 Then
								sName = "50 АДЧР225М6"
							ElseIf Strings.InStr(sName, "40 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "225", CompareMethod.Binary) > 0 Then
								sName = "40 АДЧР225М8"
							ElseIf Strings.InStr(sName, "25 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "200", CompareMethod.Binary) > 0 Then
								sName = "25 АДЧР200М8"
							ElseIf Strings.InStr(sName, "25 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "180", CompareMethod.Binary) > 0 Then
								sName = "25 АДЧР180М6"
							ElseIf Strings.InStr(sName, "25 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 And Strings.InStr(sName, "4", CompareMethod.Binary) > 0 Then
								sName = "25 АДЧР160М4"
							ElseIf Strings.InStr(sName, "25 ", CompareMethod.Binary) > 0 And Strings.InStr(sName, "160", CompareMethod.Binary) > 0 Then
								sName = "25 АДЧР160М2"
							End If
					End Select
				Else
					sName = sName.Replace("ADYP", "АДЧР")
					sName = sName.Replace("BA", "ВА")
					sName = sName.Replace("M", "М")
					sName = sName.Replace("S", "S")
					sName = sName.Replace("L", "L")
					sName = sName.Replace("IP", "IP")
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private output As StringBuilder

		Private fs As FileStream

		Private r As BinaryReader

		Private mhMotorDB As Integer
	End Module
End Namespace
