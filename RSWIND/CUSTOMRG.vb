Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module CUSTOMRG
		Public Function IsCustomRodGrade(sRodType As String) As Boolean
			Dim result As Boolean = False
			Dim num As Short = 1S
			Dim num2 As Short = CShort(Information.UBound(RSWIN_DESC.CustomRodGradeList, 1))
			For num3 As Short = num To num2
				If Strings.StrComp(Strings.Trim(sRodType), Strings.Trim(RSWIN_DESC.CustomRodGradeList(CInt(num3)).RodType), CompareMethod.Text) = 0 Then
					result = True
					Exit For
				End If
			Next
			Return result
		End Function

		Public Sub LoadCustomRodGradeList_Last(ByRef CustomRodGradeList As RSWIN_DESC.CustomRodGrade())
			CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(0) {}
			Dim sSection As String = "Custom Rod Grade List"
			Dim num2 As Short
			Dim num As Integer = CInt(num2)
			Dim array As String()
			Dim array2 As String()
			ini.GetPrivateProfileKeyList(sSection, array, array2, num, False)
			num2 = CShort(num)
			If num2 > 0S Then
				CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(0) {}
				Dim num3 As Short = 0S
				Dim num4 As Short = num2 - 1S
				For num5 As Short = num3 To num4
					Dim number As Short = 128S
					Dim text As String = Strings.Space(CInt(number))
					Dim customRodGrade As RSWIN_DESC.CustomRodGrade
					customRodGrade.RodType = array(CInt(num5))
					text = array2(CInt(num5))
					Dim num6 As Short = CShort(Strings.InStr(1, text, ",", CompareMethod.Binary))
					If num6 > 0S Then
						Dim num7 As Short = CShort(Strings.InStr(CInt((num6 + 1S)), text, ",", CompareMethod.Binary))
						If num7 > 0S Then
							Dim num8 As Short = CShort(Strings.InStr(CInt((num7 + 1S)), text, ",", CompareMethod.Binary))
							If num8 > 0S Then
								Dim num9 As Short = CShort(Strings.InStr(CInt((num8 + 1S)), text, ",", CompareMethod.Binary))
								customRodGrade.Steel = CShort(Math.Round(Conversion.Val(text.Substring(0, CInt((num6 - 1S))))))
								customRodGrade.TensileStrength = CSng(Conversion.Val(Strings.Mid(text, CInt((num6 + 1S)))))
								customRodGrade.Elasticity = CSng(Conversion.Val(Strings.Mid(text, CInt((num7 + 1S)))))
								customRodGrade.RodWeight = CSng(Conversion.Val(Strings.Mid(text, CInt((num8 + 1S)))))
								If num9 = 0S Then
									customRodGrade.StressMethod = 0S
									customRodGrade.SinkerBar = 0S
								Else
									customRodGrade.StressMethod = CShort(Math.Round(Conversion.Val(Strings.Mid(text, CInt((num9 + 1S))))))
									Dim num10 As Short = CShort(Strings.InStr(CInt((num9 + 1S)), text, ",", CompareMethod.Binary))
									If num10 > 0S Then
										customRodGrade.SinkerBar = CShort(Math.Round(Conversion.Val(Strings.Mid(text, CInt((num10 + 1S))))))
									End If
								End If
								If customRodGrade.Steel <> 0S Then
									Dim flag As Boolean = False
									CUSTOMRG.AddCustomRodGrade(CustomRodGradeList, customRodGrade, flag)
								End If
							End If
						End If
					End If
				Next
				Return
			End If
		End Sub

		Public Sub LoadCustomRodGradeList(ByRef CustomRodGradeList As RSWIN_DESC.CustomRodGrade(), bAdd As Boolean)
			CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(0) {}
			Try
				Dim sSection As String = "Custom Rod Grade List"
				Dim num2 As Short
				Dim num As Integer = CInt(num2)
				Dim array As String()
				Dim array2 As String()
				ini.GetPrivateProfileKeyList(sSection, array, array2, num, False)
				num2 = CShort(num)
				If num2 > 0S Then
					CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(0) {}
					Dim num3 As Short = 0S
					Dim num4 As Short = num2 - 1S
					For num5 As Short = num3 To num4
						Dim number As Short = 128S
						Dim text As String = Strings.Space(CInt(number))
						Dim customRodGrade As RSWIN_DESC.CustomRodGrade
						customRodGrade.RodType = array(CInt(num5))
						text = array2(CInt(num5))
						Dim num6 As Short = CShort(Strings.InStr(1, text, ",", CompareMethod.Binary))
						If num6 > 0S Then
							Dim num7 As Short = CShort(Strings.InStr(CInt((num6 + 1S)), text, ",", CompareMethod.Binary))
							If num7 > 0S Then
								Dim num8 As Short = CShort(Strings.InStr(CInt((num7 + 1S)), text, ",", CompareMethod.Binary))
								If num8 > 0S Then
									Dim num9 As Short = CShort(Strings.InStr(CInt((num8 + 1S)), text, ",", CompareMethod.Binary))
									customRodGrade.Steel = CShort(Math.Round(Conversion.Val(text.Substring(0, CInt((num6 - 1S))))))
									customRodGrade.TensileStrength = CSng(Conversion.Val(Strings.Mid(text, CInt((num6 + 1S)))))
									customRodGrade.Elasticity = CSng(Conversion.Val(Strings.Mid(text, CInt((num7 + 1S)))))
									customRodGrade.RodWeight = CSng(Conversion.Val(Strings.Mid(text, CInt((num8 + 1S)))))
									If num9 = 0S Then
										customRodGrade.StressMethod = 0S
										customRodGrade.SinkerBar = 0S
									Else
										customRodGrade.StressMethod = CShort(Math.Round(Conversion.Val(Strings.Mid(text, CInt((num9 + 1S))))))
										Dim num10 As Short = CShort(Strings.InStr(CInt((num9 + 1S)), text, ",", CompareMethod.Binary))
										If num10 > 0S Then
											customRodGrade.SinkerBar = CShort(Math.Round(Conversion.Val(Strings.Mid(text, CInt((num10 + 1S))))))
										End If
									End If
									If customRodGrade.Steel <> 0S Then
										CUSTOMRG.AddCustomRodGrade(CustomRodGradeList, customRodGrade, bAdd)
									End If
								End If
							End If
						End If
					Next
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function CheckCustomRodGradeList(sCheck As String) As Boolean
			RSWIN_DESC.CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(0) {}
			Dim result As Boolean = False
			Dim sSection As String = "Custom Rod Grade List"
			Dim num2 As Short
			Dim num As Integer = CInt(num2)
			Dim array As String()
			Dim array2 As String()
			ini.GetPrivateProfileKeyList(sSection, array, array2, num, False)
			num2 = CShort(num)
			If num2 > 0S Then
				RSWIN_DESC.CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(0) {}
				Dim num3 As Short = 0S
				Dim num4 As Short = num2 - 1S
				For num5 As Short = num3 To num4
					Dim number As Short = 128S
					Dim text As String = Strings.Space(CInt(number))
					If Operators.CompareString(sCheck.Trim(), array(CInt(num5)).Trim(), False) = 0 Then
						result = True
					End If
				Next
			End If
			Return result
		End Function

		Public Sub LoadCustomRodGradeList_Save(ByRef CustomRodGradeList As RSWIN_DESC.CustomRodGrade())
			Dim text As String = "Custom Rod Grade List"
			CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(0) {}
			Dim sSection As String = text
			Dim obj As Object
			Dim num As Integer = Conversions.ToInteger(obj)
			Dim array As String()
			ini.GetPrivateProfileKeyList(sSection, array, num)
			obj = num
			If Operators.ConditionalCompareObjectGreater(obj, 0, False) Then
				CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(0) {}
				Dim obj2 As Object
				Dim obj3 As Object
				If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj2, 0, Operators.SubtractObject(obj, 1), 1, obj3, obj2) Then
					Do
						Dim obj4 As Object = 128
						Dim text2 As String = Strings.Space(Conversions.ToInteger(obj4))
						Dim array2 As String() = array
						Dim num2 As Integer = Conversions.ToInteger(obj2)
						Dim text3 As String = ""
						Dim obj5 As Object = RSWIN.GetRegProfileString(text, array2(num2), text3, text2, False)
						text2 = Strings.Left(text2, Conversions.ToInteger(obj5))
						Dim obj6 As Object = Strings.InStr(1, text2, ",", CompareMethod.Binary)
						If Operators.ConditionalCompareObjectGreater(obj6, 0, False) Then
							Dim obj7 As Object = Strings.InStr(Conversions.ToInteger(Operators.AddObject(obj6, 1)), text2, ",", CompareMethod.Binary)
							If Operators.ConditionalCompareObjectGreater(obj7, 0, False) Then
								Dim obj8 As Object = Strings.InStr(Conversions.ToInteger(Operators.AddObject(obj7, 1)), text2, ",", CompareMethod.Binary)
								If Operators.ConditionalCompareObjectGreater(obj8, 0, False) Then
									Dim obj9 As Object = Strings.InStr(Conversions.ToInteger(Operators.AddObject(obj8, 1)), text2, ",", CompareMethod.Binary)
									Dim customRodGrade As RSWIN_DESC.CustomRodGrade
									customRodGrade.RodType = array(Conversions.ToInteger(obj2))
									customRodGrade.Steel = CShort(Math.Round(Conversion.Val(Strings.Left(text2, Conversions.ToInteger(Operators.SubtractObject(obj6, 1))))))
									customRodGrade.TensileStrength = CSng(Conversion.Val(Strings.Mid(text2, Conversions.ToInteger(Operators.AddObject(obj6, 1)))))
									customRodGrade.Elasticity = CSng(Conversion.Val(Strings.Mid(text2, Conversions.ToInteger(Operators.AddObject(obj7, 1)))))
									customRodGrade.RodWeight = CSng(Conversion.Val(Strings.Mid(text2, Conversions.ToInteger(Operators.AddObject(obj8, 1)))))
									If Operators.ConditionalCompareObjectEqual(obj9, 0, False) Then
										customRodGrade.StressMethod = 0S
										customRodGrade.SinkerBar = 0S
									Else
										customRodGrade.StressMethod = CShort(Math.Round(Conversion.Val(Strings.Mid(text2, Conversions.ToInteger(Operators.AddObject(obj9, 1))))))
										Dim obj10 As Object = Strings.InStr(Conversions.ToInteger(Operators.AddObject(obj9, 1)), text2, ",", CompareMethod.Binary)
										If Operators.ConditionalCompareObjectGreater(obj10, 0, False) Then
											customRodGrade.SinkerBar = CShort(Math.Round(Conversion.Val(Strings.Mid(text2, Conversions.ToInteger(Operators.AddObject(obj10, 1))))))
										End If
									End If
									If customRodGrade.Steel <> 0S Then
										Dim flag As Boolean = False
										CUSTOMRG.AddCustomRodGrade(CustomRodGradeList, customRodGrade, flag)
									End If
								End If
							End If
						End If
					Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj2, obj3, obj2)
				End If
			End If
		End Sub

		Public Sub SaveCustomRodGradeListToDB()
			Dim text As String = "Custom Rod Grade List"
			Dim text2 As String = Nothing
			Dim text3 As String = Nothing
			Dim num2 As Short
			Dim num3 As Short
			Dim num As Short = CShort(RSWIN.WriteRegProfileString(text, text2, text3, RSWIN_DESC.THETA_INI))
			num2 = 1S
			num3 = CShort(Information.UBound(RSWIN_DESC.CustomRodGradeList, 1))
			For num4 As Short = num2 To num3
				Custom.CustomRodGrades_DBAddRow(RSWIN_DESC.CustomRodGradeList(CInt(num4)), False, "")
			Next
		End Sub

		Public Sub AddCustomRodGrade(ByRef CustomRodGradeList As RSWIN_DESC.CustomRodGrade(), ByRef newtype As RSWIN_DESC.CustomRodGrade, ByRef bAddToDB As Boolean)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Integer = Information.UBound(CustomRodGradeList, 1) + 1
			If num = 1 Then
				CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(num + 1 - 1) {}
			Else
				CustomRodGradeList = CType(Utils.CopyArray(CType(CustomRodGradeList, Array), New RSWIN_DESC.CustomRodGrade(num + 1 - 1) {}), RSWIN_DESC.CustomRodGrade())
			End If
			Dim [string] As String = Strings.Trim(newtype.RodType)
			For i As Integer = num To 1 Step -1
				If i = 1 Then
					CustomRodGradeList(i) = newtype
				Else
					If Strings.StrComp([string], Strings.Trim(CustomRodGradeList(i - 1).RodType), CompareMethod.Text) > 0 Then
						CustomRodGradeList(i) = newtype
						Exit For
					End If
					CustomRodGradeList(i) = CustomRodGradeList(i - 1)
				End If
			Next
			Try
				If bAddToDB Then
					Custom.CustomRodGrades_DBAddRow(newtype, False, "")
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub AddCustomRodGrades(ByRef NewTypes As RSWIN_DESC.CustomRodGrade(), nNewTypes As Short, bBatchUpdateCustomRodGrades As Short, bPartial As Boolean())
			Dim dlgDuplicateCustomRodGrade As dlgDuplicateCustomRodGrade = New dlgDuplicateCustomRodGrade()
			Dim num As Short = 0S
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			For num2 As Short = 1S To nNewTypes
				Dim text As String = NewTypes(CInt(num2)).RodType.Trim()
				If text.Trim().Length > 0 Then
					Dim num3 As Short = 1S
					Dim num4 As Short = CShort(Information.UBound(RSWIN_DESC.CustomRodGradeList, 1))
					For num5 As Short = num3 To num4
						If Strings.StrComp(text, RSWIN_DESC.CustomRodGradeList(CInt(num5)).RodType.Trim(), CompareMethod.Binary) = 0 Then
							Dim num6 As Short = -1S
							num6 = num6 And If((-If(((NewTypes(CInt(num2)).TensileStrength = RSWIN_DESC.CustomRodGradeList(CInt(num5)).TensileStrength) > False), 1S, 0S)), 1S, 0S)
							num6 = num6 And If((-If(((NewTypes(CInt(num2)).StressMethod = RSWIN_DESC.CustomRodGradeList(CInt(num5)).StressMethod) > False), 1S, 0S)), 1S, 0S)
							If Not num6 <> 0S Then
								Dim flag As Boolean
								If RSWIN_DESC.rst.gbBatch Then
									flag = (bBatchUpdateCustomRodGrades <> 0S)
								Else
									dlgDuplicateCustomRodGrade.panRodGrade.Text = Strings.Trim(RSWIN_DESC.CustomRodGradeList(CInt(num5)).RodType)
									If RSWIN_DESC.SETUP_MeasurementSystem <> 3 Then
										dlgDuplicateCustomRodGrade.panTSSetup.Text = Conversions.ToString(RSWIN_DESC.CustomRodGradeList(CInt(num5)).TensileStrength) + " psi"
										dlgDuplicateCustomRodGrade.panTSFile.Text = Conversions.ToString(NewTypes(CInt(num2)).TensileStrength) + " psi"
									Else
										Dim panTSSetup As Label = dlgDuplicateCustomRodGrade.panTSSetup
										Dim num7 As Single = RSWIN_DESC.CustomRodGradeList(CInt(num5)).TensileStrength * RSWIN_DESC.PSI__KPA
										Dim text2 As String = "0"
										panTSSetup.Text = Util.Format(num7, text2) + " kPa"
										Dim panTSFile As Label = dlgDuplicateCustomRodGrade.panTSFile
										num7 = NewTypes(CInt(num2)).TensileStrength * RSWIN_DESC.PSI__KPA
										text2 = "0"
										panTSFile.Text = Util.Format(num7, text2) + " kPa"
									End If
									dlgDuplicateCustomRodGrade.panStressSetup.Text = RODUTIL.StressMethodName(RSWIN_DESC.CustomRodGradeList(CInt(num5)).StressMethod)
									dlgDuplicateCustomRodGrade.panStressFile.Text = RODUTIL.StressMethodName(NewTypes(CInt(num2)).StressMethod)
									dlgDuplicateCustomRodGrade.ShowDialog()
									If dlgDuplicateCustomRodGrade.bUseFile Then
										flag = True
									ElseIf dlgDuplicateCustomRodGrade.bUseSetup Then
										flag = False
									End If
									dlgDuplicateCustomRodGrade.Close()
								End If
								If flag Then
									RSWIN_DESC.CustomRodGradeList(CInt(num5)).TensileStrength = NewTypes(CInt(num2)).TensileStrength
									RSWIN_DESC.CustomRodGradeList(CInt(num5)).StressMethod = NewTypes(CInt(num2)).StressMethod
								End If
							End If
							NewTypes(CInt(num2)).RodType = ""
							Exit For
						End If
					Next
					If NewTypes(CInt(num2)).RodType.Trim().Length > 0 Then
						num = -1S
					End If
				End If
			Next
			If num <> 0S Then
				Dim msg As String = "This file contains custom rod grades that are not in your setup.  Do you want to add them to your setup?"
				Dim bDefaultYes As Boolean = True
				Dim flag2 As Boolean = False
				If Util.YesNo(msg, bDefaultYes, flag2) Then
					For num2 As Short = 1S To nNewTypes
						If Strings.Len(Strings.Trim(NewTypes(CInt(num2)).RodType)) > 0 Then
							If Not bPartial(CInt(num2)) Then
								Dim array As RSWIN_DESC.CustomRodGrade() = NewTypes
								Dim num8 As Integer = CInt(num2)
								Dim flag3 As Boolean = True
								CUSTOMRG.AddCustomRodGrade(RSWIN_DESC.CustomRodGradeList, array(num8), flag3)
							Else
								MessageBox.Show("The file contains partial information for custom rod '" + NewTypes(CInt(num2)).RodType + "'. Please add custom rod in Setup and select rod before running this case.", "Rod could not be added")
							End If
						End If
					Next
				End If
			End If
		End Sub

		Public Function IsOtherSteel(iRodGrade As Integer) As Boolean
			Return(iRodGrade > 4143 And iRodGrade < 8000) Or iRodGrade = 4096
		End Function

		Public Function IsUPCO(iRodGrade As Integer) As Boolean
			Return(iRodGrade >= 4143 And iRodGrade < 8000) Or iRodGrade = 4096
		End Function

		Public Function IsOtherFG(iRodGrade As Integer) As Boolean
			Return(iRodGrade >= 16397 And iRodGrade < 20000) Or iRodGrade = 16384
		End Function

		Public Function IsOtherSinkerBar(iRodGrade As Integer) As Boolean
			Dim result As Boolean
			Try
				If iRodGrade >= 8311 And iRodGrade < 12000 Then
					result = True
				Else
					result = False
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function
	End Module
End Namespace
