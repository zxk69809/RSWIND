Imports System
Imports System.Diagnostics
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module PUDATA1
		Private Sub AddUnitTypeInfo(ByRef PU As RSWIN_DESC.PUDataRec, PUType As String)
			Try
				Dim unitTypeInfo As RSWIN_DESC.UnitTypeInfo
				unitTypeInfo.Initialize()
				Dim fileName As String
				FILEUTIL.LocateFile("UNITINFO32.PUD", fileName, 2S, False, False, False, False)
				Dim num As Short
				Dim num2 As Short
				Dim num3 As Short
				Dim num4 As Short
				num = CShort(FileSystem.FreeFile())
				FileSystem.FileOpen(CInt(num), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
				num2 = CShort((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(unitTypeInfo))))
				num3 = 1S
				num4 = num2
				Dim num5 As Short
				num5 = num3
				While num5 <= num4
					Dim fileNumber As Integer = CInt(num)
					Dim valueType As ValueType = unitTypeInfo
					FileSystem.FileGet(fileNumber, valueType, -1L)
					Dim valueType2 As ValueType = valueType
					Dim unitTypeInfo2 As RSWIN_DESC.UnitTypeInfo
					unitTypeInfo = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.UnitTypeInfo), unitTypeInfo2)
					If Operators.CompareString(PUType, Strings.RTrim(unitTypeInfo.Abbrev), False) = 0 Then
						Exit While
					End If
					num5 += 1S
				End While
				FileSystem.FileClose(New Integer() { CInt(num) })
				If num5 <= num2 Then
					PU.Manuf = unitTypeInfo.Manuf
					PU.UnitType = unitTypeInfo.UnitType
					Select Case unitTypeInfo.RequiredRotation
						Case -1S
							PU.RequiredRotation = -1S
							PU.CrankRotation = -1S
						Case 0S
							PU.RequiredRotation = 0S
						Case 1S
							PU.RequiredRotation = -1S
							PU.CrankRotation = 1S
					End Select
					If PU.RequiredRotation <> 0S Then
						ini.SaveDataValue("CrankRotation", DBNull.Value)
					End If
					PU.CrankRadii(0) = CSng((CDbl(PU.CrankRadii(0)) + 4.2))
					PU.CrankRadii(1) = CSng((CDbl(PU.CrankRadii(1)) - 5.15))
					PU.CrankRadii(2) = CSng((CDbl(PU.CrankRadii(2)) - 3.75))
					PU.CrankRadii(3) = CSng((CDbl(PU.CrankRadii(3)) + 1.9))
					PU.CrankRadii(4) = CSng((CDbl(PU.CrankRadii(4)) + 1.5))
					If PU.UnitType = 9S Then
						PU.A = 0F
					Else
						PU.A = CSng((CDbl(PU.A) + 15.75))
					End If
					PU.C = CSng((CDbl(PU.C) - 11.9))
					PU.I = CSng((CDbl(PU.I) - 9.6))
					PU.K = CSng((CDbl(PU.K) + 12.9))
					PU.P = CSng((CDbl(PU.P) - 9.65))
					PU.M = CSng((CDbl(PU.M) + 20.75))
					PU.S = CSng((CDbl(PU.S) - 13.4))
					PU.V0 = CSng((CDbl(PU.V0) + 9.0))
					PU.SprocketDistance = CSng((CDbl(PU.SprocketDistance) + 8.6))
					PU.SprocketRadius = CSng((CDbl(PU.SprocketRadius) - 5.5))
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in AddUnitTypeInfo: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub ParseUnitID(ID As String, ByRef PUType As String, ByRef PUNum As Integer)
			PUType = ""
			While Strings.Len(ID) > 0 AndAlso (65 <= Strings.Asc(ID) And Strings.Asc(ID) <= 90)
				PUType += Strings.Left(ID, 1)
				ID = Strings.Mid(ID, 2)
			End While
			Dim text As String = ""
			While Strings.Len(ID) > 0 AndAlso (48 <= Strings.Asc(ID) And Strings.Asc(ID) <= 57)
				text += Strings.Left(ID, 1)
				ID = Strings.Mid(ID, 2)
			End While
			PUNum = Convert.ToInt32(text)
		End Sub

		Public Function CheckFourthLCCrankHole(bClicked As Boolean, iCrankhole As Integer) As Boolean
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim result As Boolean
			If rst.UnitID.Length <> 0 Then
				Dim obj As Object = Nothing
				Dim typeFromHandle As Type = GetType(PUDATA1)
				Dim text As String = "ParseUnitID"
				Dim array As Object() = New Object(2) {}
				Dim array2 As Object() = array
				Dim num As Integer = 0
				Dim cRODSTAR As cRODSTAR = rst
				array2(num) = cRODSTAR.UnitID
				Dim objectValue As Object
				array(1) = RuntimeHelpers.GetObjectValue(objectValue)
				array(2) = 0
				Dim array3 As Object() = array
				Dim array4 As Object() = array3
				Dim array5 As String() = Nothing
				Dim array6 As Type() = Nothing
				Dim array7 As Boolean() = New Boolean() { True, True, False }
				NewLateBinding.LateCall(obj, typeFromHandle, text, array4, array5, array6, array7, True)
				If array7(0) Then
					cRODSTAR.UnitID = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(0)), GetType(String)))
				End If
				If array7(1) Then
					objectValue = RuntimeHelpers.GetObjectValue(array3(1))
				End If
				If Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(objectValue, "CL", False), iCrankhole <> 4)) Then
					result = True
				ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Not PUDATA1.bFourthCrank AndAlso bClicked, Operators.CompareObjectEqual(objectValue, "CL", False)), iCrankhole = 4)) Then
					PUDATA1.bFourthCrank = True
					result = True
					MessageBox.Show("The fourth crank hole may not be available for Lufkin conventional units manufacturered after 1982.")
				End If
			Else
				result = False
			End If
			Return result
		End Function

		Public Function ComparePU(Unit1 As RSWIN_DESC.PUDataRec, Unit2 As RSWIN_DESC.PUDataRec, iSortOrder As Integer) As Object
			Dim result As Object
			Try
				Select Case iSortOrder
					Case 0
						result = Strings.StrComp(Unit1.UnitName, Unit2.UnitName, CompareMethod.Binary)
					Case 1
						Dim obj As Object
						If Unit1.MaxStroke < Unit2.MaxStroke Then
							obj = -1S
						ElseIf Unit1.MaxStroke > Unit2.MaxStroke Then
							obj = 1S
						ElseIf Unit1.GearboxRating < Unit2.GearboxRating Then
							obj = -1S
						ElseIf Unit1.GearboxRating > Unit2.GearboxRating Then
							obj = 1S
						ElseIf Unit1.StructRating < Unit2.StructRating Then
							obj = -1S
						ElseIf Unit1.StructRating > Unit2.StructRating Then
							obj = 1S
						Else
							obj = 0S
						End If
						If Operators.ConditionalCompareObjectEqual(obj, -1S, False) Then
							result = 1S
						ElseIf Operators.ConditionalCompareObjectEqual(obj, 0S, False) Then
							result = 0S
						Else
							result = -1S
						End If
					Case 2
						Dim obj As Object
						If Unit1.GearboxRating < Unit2.GearboxRating Then
							obj = -1S
						ElseIf Unit1.GearboxRating > Unit2.GearboxRating Then
							obj = 1S
						ElseIf Unit1.StructRating < Unit2.StructRating Then
							obj = -1S
						ElseIf Unit1.StructRating > Unit2.StructRating Then
							obj = 1S
						ElseIf Unit1.MaxStroke < Unit2.MaxStroke Then
							obj = -1S
						ElseIf Unit1.MaxStroke > Unit2.MaxStroke Then
							obj = 1S
						Else
							obj = 0S
						End If
						If Operators.ConditionalCompareObjectEqual(obj, -1S, False) Then
							result = 1S
						ElseIf Operators.ConditionalCompareObjectEqual(obj, 0S, False) Then
							result = 0S
						Else
							result = -1S
						End If
					Case 3
						Dim obj As Object = Strings.StrComp(Strings.Trim(Unit1.Manuf), Strings.Trim(Unit2.Manuf), CompareMethod.Text)
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							obj = RuntimeHelpers.GetObjectValue(PUDATA1.ComparePU(Unit1, Unit2, 1))
						End If
						result = RuntimeHelpers.GetObjectValue(obj)
					Case 4
						Dim obj As Object
						If Unit1.GearboxRating < Unit2.GearboxRating Then
							obj = -1S
						ElseIf Unit1.GearboxRating > Unit2.GearboxRating Then
							obj = 1S
						ElseIf Unit1.MaxStroke < Unit2.MaxStroke Then
							obj = -1S
						ElseIf Unit1.MaxStroke > Unit2.MaxStroke Then
							obj = 1S
						ElseIf Unit1.StructRating < Unit2.StructRating Then
							obj = -1S
						ElseIf Unit1.StructRating > Unit2.StructRating Then
							obj = 1S
						Else
							obj = 0S
						End If
						If Operators.ConditionalCompareObjectEqual(obj, -1S, False) Then
							result = 1S
						ElseIf Operators.ConditionalCompareObjectEqual(obj, 0S, False) Then
							result = 0S
						Else
							result = -1S
						End If
					Case 5
						Dim obj As Object
						If Unit1.StructRating < Unit2.StructRating Then
							obj = -1S
						ElseIf Unit1.StructRating > Unit2.StructRating Then
							obj = 1S
						ElseIf Unit1.GearboxRating < Unit2.GearboxRating Then
							obj = -1S
						ElseIf Unit1.GearboxRating > Unit2.GearboxRating Then
							obj = 1S
						ElseIf Unit1.MaxStroke < Unit2.MaxStroke Then
							obj = -1S
						ElseIf Unit1.MaxStroke > Unit2.MaxStroke Then
							obj = 1S
						Else
							obj = 0S
						End If
						If Operators.ConditionalCompareObjectEqual(obj, -1S, False) Then
							result = 1S
						ElseIf Operators.ConditionalCompareObjectEqual(obj, 0S, False) Then
							result = 0S
						Else
							result = -1S
						End If
					Case 6
						Dim obj As Object
						If Unit1.StructRating < Unit2.StructRating Then
							obj = -1S
						ElseIf Unit1.StructRating > Unit2.StructRating Then
							obj = 1S
						ElseIf Unit1.MaxStroke < Unit2.MaxStroke Then
							obj = -1S
						ElseIf Unit1.MaxStroke > Unit2.MaxStroke Then
							obj = 1S
						ElseIf Unit1.GearboxRating < Unit2.GearboxRating Then
							obj = -1S
						ElseIf Unit1.GearboxRating > Unit2.GearboxRating Then
							obj = 1S
						Else
							obj = 0S
						End If
						If Operators.ConditionalCompareObjectEqual(obj, -1S, False) Then
							result = 1S
						ElseIf Operators.ConditionalCompareObjectEqual(obj, 0S, False) Then
							result = 0S
						Else
							result = -1S
						End If
				End Select
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub ComparePU_Extra(Unit1 As RSWIN_DESC.PUDataRec, Unit2 As RSWIN_DESC.PUDataRec, ByRef ComparePU_GearboxRating As Short, ByRef ComparePU_StructRating As Short, ByRef ComparePU_MaxStroke As Short, iSortOrder As Integer)
			Try
				Select Case iSortOrder
					Case 1
						Dim num As Short
						If Unit1.MaxStroke < Unit2.MaxStroke Then
							num = -1S
						ElseIf Unit1.MaxStroke > Unit2.MaxStroke Then
							num = 1S
						End If
						Dim num2 As Short
						If Unit1.GearboxRating < Unit2.GearboxRating Then
							num2 = -1S
						ElseIf Unit1.GearboxRating > Unit2.GearboxRating Then
							num2 = 1S
						End If
						Dim num3 As Short
						If Unit1.StructRating < Unit2.StructRating Then
							num3 = -1S
						ElseIf Unit1.StructRating > Unit2.StructRating Then
							num3 = 1S
						Else
							num3 = 0S
						End If
						If num = -1S Then
							ComparePU_MaxStroke = 1S
						ElseIf num = 0S Then
							ComparePU_MaxStroke = 0S
						Else
							ComparePU_MaxStroke = -1S
						End If
						If num2 = -1S Then
							ComparePU_GearboxRating = 1S
						Else
							ComparePU_GearboxRating = -1S
						End If
						If num3 = -1S Then
							ComparePU_StructRating = 1S
						Else
							ComparePU_StructRating = -1S
						End If
					Case 2
						Debug.WriteLine(String.Concat(New String() { Conversions.ToString(Unit1.GearboxRating), "-", Conversions.ToString(Unit1.StructRating), "-", Conversions.ToString(Unit1.MaxStroke), "  ,  ", Conversions.ToString(Unit2.GearboxRating), "-", Conversions.ToString(Unit2.StructRating), "-", Conversions.ToString(Unit2.MaxStroke) }))
						Dim num2 As Short
						If Unit1.GearboxRating < Unit2.GearboxRating Then
							num2 = -1S
						ElseIf Unit1.GearboxRating > Unit2.GearboxRating Then
							num2 = 1S
						Else
							num2 = 0S
						End If
						Dim num3 As Short
						If Unit1.StructRating < Unit2.StructRating Then
							num3 = -1S
						ElseIf Unit1.StructRating > Unit2.StructRating Then
							num3 = 1S
						Else
							num3 = 0S
						End If
						Dim num As Short
						If Unit1.MaxStroke < Unit2.MaxStroke Then
							num = -1S
						ElseIf Unit1.MaxStroke > Unit2.MaxStroke Then
							num = 1S
						Else
							num = 0S
						End If
						If num2 = -1S Then
							ComparePU_GearboxRating = 1S
						ElseIf num2 = 0S Then
							ComparePU_GearboxRating = 0S
						ElseIf num2 = 1S Then
							ComparePU_GearboxRating = -1S
						End If
						If num3 = -1S Then
							ComparePU_StructRating = 1S
						ElseIf num3 = 0S Then
							ComparePU_StructRating = 0S
						ElseIf ComparePU_StructRating = 1S Then
							ComparePU_StructRating = -1S
						End If
						If num = -1S Then
							ComparePU_MaxStroke = 1S
						ElseIf num = 0S Then
							ComparePU_MaxStroke = 0S
						ElseIf num = 1S Then
							ComparePU_MaxStroke = -1S
						End If
				End Select
			Catch ex As Exception
			End Try
		End Sub

		Public Sub SortPUnits(UnitData As RSWIN_DESC.PUDataRec(), ByRef uIdx As Short(), iSortOrder As Integer)
			Try
				Dim obj As Object = Information.LBound(UnitData, 1)
				Dim obj2 As Object = Information.UBound(UnitData, 1)
				Dim obj3 As Object = Operators.AddObject(Operators.SubtractObject(obj2, obj), 1)
				Dim obj4 As Object = 1
				Do
					obj4 = Operators.AddObject(Operators.MultiplyObject(3, obj4), 1)
				Loop While Operators.ConditionalCompareObjectLessEqual(obj4, obj3, False)
				uIdx = New Short(Conversions.ToInteger(obj2) + 1 - 1) {}
				Dim obj5 As Object
				Dim obj6 As Object
				If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj5, obj, obj2, 1, obj6, obj5) Then
					Do
						uIdx(Conversions.ToInteger(obj5)) = Conversions.ToShort(obj5)
					Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj5, obj6, obj5)
				End If
				Do
					obj4 = Operators.IntDivideObject(obj4, 3)
					Dim obj7 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj5, Operators.AddObject(obj4, 1), obj3, 1, obj7, obj5) Then
						Do
							Dim obj8 As Object = uIdx(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(obj5, obj), 1)))
							Dim obj9 As Object = RuntimeHelpers.GetObjectValue(obj5)
							While Operators.ConditionalCompareObjectEqual(PUDATA1.ComparePU(UnitData(CInt(uIdx(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(obj9, obj4), obj), 1))))), UnitData(Conversions.ToInteger(obj8)), iSortOrder), 1S, False)
								uIdx(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(obj9, obj), 1))) = uIdx(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(obj9, obj4), obj), 1)))
								obj9 = Operators.SubtractObject(obj9, obj4)
								If Operators.ConditionalCompareObjectLessEqual(obj9, obj4, False) Then
									Exit While
								End If
							End While
							uIdx(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(obj9, obj), 1))) = Conversions.ToShort(obj8)
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj5, obj7, obj5)
					End If
				Loop While Operators.ConditionalCompareObjectNotEqual(obj4, 1, False)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub SortPUnits(ByRef UnitData As RSWIN_DESC.PUDataRec(), ByRef uIdx As Integer(), ByRef iSortOrder As Object, iLBound As Integer, iUBound As Integer)
			Try
				Dim num As Short
				Dim num3 As Short
				Dim num4 As Short
				Dim num5 As Short
				Dim num6 As Short
				num = CShort(iLBound)
				Dim num2 As Short = CShort(iUBound)
				num3 = num2 - num + 1S
				num4 = 1S
				Do
					num4 = 3S * num4 + 1S
				Loop While num4 <= num3
				uIdx = New Integer(CInt((num2 + 1S)) - 1) {}
				num5 = num
				num6 = num2
				For num7 As Short = num5 To num6
					uIdx(CInt(num7)) = CInt(num7)
				Next
				Do
					num4 /= 3S
					Dim num8 As Short = num4 + 1S
					Dim num9 As Short = num3
					For num7 As Short = num8 To num9
						' The following expression was wrapped in a checked-statement
						Dim num10 As Short = CShort(uIdx(CInt((num7 + num - 1S))))
						Dim num11 As Short = num7
						While PUDATA1.ComparePU(UnitData(uIdx(CInt((num11 - num4 + num - 1S)))), UnitData(CInt(num10)), RuntimeHelpers.GetObjectValue(iSortOrder)) = 1S
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a unchecked-expression
							uIdx(CInt((num11 + num - 1S))) = uIdx(CInt((num11 - num4 + num - 1S)))

								num11 -= num4
								If num11 <= num4 Then
									Exit While
								End If

						End While
						uIdx(CInt((num11 + num - 1S))) = CInt(num10)
					Next
				Loop While num4 <> 1S
			Catch ex As Exception
			End Try
		End Sub

		Public Sub SortPUnits(ByRef UnitData As RSWIN_DESC.PUDataRec(), ByRef uIdx As Object(), ByRef iSortOrder As Object, iLBound As Integer, iUBound As Integer)
			Try
				Dim num As Short
				Dim num3 As Short
				Dim num4 As Short
				Dim num5 As Short
				Dim num6 As Short
				num = CShort(iLBound)
				Dim num2 As Short = CShort(iUBound)
				num3 = num2 - num + 1S
				num4 = 1S
				Do
					num4 = 3S * num4 + 1S
				Loop While num4 <= num3
				uIdx = New Object(CInt((num2 + 1S)) - 1) {}
				num5 = num
				num6 = num2
				For num7 As Short = num5 To num6
					uIdx(CInt(num7)) = num7
				Next
				Do
					num4 /= 3S
					Dim num8 As Short = num4 + 1S
					Dim num9 As Short = num3
					For num7 As Short = num8 To num9
						' The following expression was wrapped in a checked-statement
						Dim num10 As Short = Conversions.ToShort(uIdx(CInt((num7 + num - 1S))))
						Dim num11 As Short = num7
						While PUDATA1.ComparePU(UnitData(Conversions.ToInteger(uIdx(CInt((num11 - num4 + num - 1S))))), UnitData(CInt(num10)), RuntimeHelpers.GetObjectValue(iSortOrder)) = 1S
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a unchecked-expression
							uIdx(CInt((num11 + num - 1S))) = RuntimeHelpers.GetObjectValue(uIdx(CInt((num11 - num4 + num - 1S))))

								num11 -= num4
								If num11 <= num4 Then
									Exit While
								End If

						End While
						uIdx(CInt((num11 + num - 1S))) = num10
					Next
				Loop While num4 <> 1S
			Catch ex As Exception
			End Try
		End Sub

		Public Sub OSortPUnits(ByRef UnitData As RSWIN_DESC.PUDataRec(), ByRef uIdx As Object(), ByRef iSortOrder As Object)
			Try
				Dim num As Short
				Dim num3 As Short
				Dim num4 As Short
				Dim num5 As Short
				Dim num6 As Short
				num = CShort(Information.LBound(UnitData, 1))
				Dim num2 As Short = CShort(Information.UBound(UnitData, 1))
				num3 = num2 - num + 1S
				num4 = 1S
				Do
					num4 = 3S * num4 + 1S
				Loop While num4 <= num3
				uIdx = New Object(CInt((num2 + 1S)) - 1) {}
				num5 = num
				num6 = num2
				For num7 As Short = num5 To num6
					uIdx(CInt(num7)) = num7
				Next
				Do
					num4 /= 3S
					Dim num8 As Short = num4 + 1S
					Dim num9 As Short = num3
					For num7 As Short = num8 To num9
						' The following expression was wrapped in a checked-statement
						Dim num10 As Short = Conversions.ToShort(uIdx(CInt((num7 + num - 1S))))
						Dim num11 As Short = num7
						While PUDATA1.ComparePU(UnitData(Conversions.ToInteger(uIdx(CInt((num11 - num4 + num - 1S))))), UnitData(CInt(num10)), RuntimeHelpers.GetObjectValue(iSortOrder)) = 1S
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a unchecked-expression
							uIdx(CInt((num11 + num - 1S))) = RuntimeHelpers.GetObjectValue(uIdx(CInt((num11 - num4 + num - 1S))))

								num11 -= num4
								If num11 <= num4 Then
									Exit While
								End If

						End While
						uIdx(CInt((num11 + num - 1S))) = num10
					Next
				Loop While num4 <> 1S
			Catch ex As Exception
			End Try
		End Sub

		Public Function ComparePU(ByRef Unit1 As RSWIN_DESC.PUDataRec, ByRef Unit2 As RSWIN_DESC.PUDataRec, iSortOrder As Object) As Short
			' The following expression was wrapped in a checked-statement
			Dim result As Short
			If Operators.ConditionalCompareObjectEqual(iSortOrder, 0, False) Then
				result = CShort(Strings.StrComp(Unit1.UnitName, Unit2.UnitName, CompareMethod.Binary))
			ElseIf Operators.ConditionalCompareObjectEqual(iSortOrder, 1, False) Then
				Dim num As Short
				If Unit1.MaxStroke < Unit2.MaxStroke Then
					num = -1S
				ElseIf Unit1.MaxStroke > Unit2.MaxStroke Then
					num = 1S
				ElseIf Unit1.GearboxRating < Unit2.GearboxRating Then
					num = -1S
				ElseIf Unit1.GearboxRating > Unit2.GearboxRating Then
					num = 1S
				ElseIf Unit1.StructRating < Unit2.StructRating Then
					num = -1S
				ElseIf Unit1.StructRating > Unit2.StructRating Then
					num = 1S
				Else
					num = 0S
				End If
				If num = -1S Then
					result = 1S
				ElseIf num = 0S Then
					result = 0S
				Else
					result = -1S
				End If
			ElseIf Operators.ConditionalCompareObjectEqual(iSortOrder, 2, False) Then
				Dim num As Short
				If Unit1.GearboxRating < Unit2.GearboxRating Then
					num = -1S
				ElseIf Unit1.GearboxRating > Unit2.GearboxRating Then
					num = 1S
				ElseIf Unit1.StructRating < Unit2.StructRating Then
					num = -1S
				ElseIf Unit1.StructRating > Unit2.StructRating Then
					num = 1S
				ElseIf Unit1.MaxStroke < Unit2.MaxStroke Then
					num = -1S
				ElseIf Unit1.MaxStroke > Unit2.MaxStroke Then
					num = 1S
				Else
					num = 0S
				End If
				If num = -1S Then
					result = 1S
				ElseIf num = 0S Then
					result = 0S
				Else
					result = -1S
				End If
			ElseIf Operators.ConditionalCompareObjectEqual(iSortOrder, 5, False) Then
				Dim num As Short
				If Unit1.StructRating < Unit2.StructRating Then
					num = -1S
				ElseIf Unit1.StructRating > Unit2.StructRating Then
					num = 1S
				ElseIf Unit1.GearboxRating < Unit2.GearboxRating Then
					num = -1S
				ElseIf Unit1.GearboxRating > Unit2.GearboxRating Then
					num = 1S
				ElseIf Unit1.MaxStroke < Unit2.MaxStroke Then
					num = -1S
				ElseIf Unit1.MaxStroke > Unit2.MaxStroke Then
					num = 1S
				Else
					num = 0S
				End If
				If num = -1S Then
					result = 1S
				ElseIf num = 0S Then
					result = 0S
				Else
					result = -1S
				End If
			ElseIf Operators.ConditionalCompareObjectEqual(iSortOrder, 6, False) Then
				Dim num As Short
				If Unit1.StructRating < Unit2.StructRating Then
					num = -1S
				ElseIf Unit1.StructRating > Unit2.StructRating Then
					num = 1S
				ElseIf Unit1.MaxStroke < Unit2.MaxStroke Then
					num = -1S
				ElseIf Unit1.MaxStroke > Unit2.MaxStroke Then
					num = 1S
				ElseIf Unit1.GearboxRating < Unit2.GearboxRating Then
					num = -1S
				ElseIf Unit1.GearboxRating > Unit2.GearboxRating Then
					num = 1S
				Else
					num = 0S
				End If
				If num = -1S Then
					result = 1S
				ElseIf num = 0S Then
					result = 0S
				Else
					result = -1S
				End If
			ElseIf Operators.ConditionalCompareObjectEqual(iSortOrder, 3, False) Then
				Dim num As Short = CShort(Strings.StrComp(Strings.Trim(Unit1.Manuf), Strings.Trim(Unit2.Manuf), CompareMethod.Text))
				If num = 0S Then
					num = Conversions.ToShort(PUDATA1.ComparePU(Unit1, Unit2, 1))
				End If
				result = num
			End If
			Return result
		End Function

		Public Function ComparePU(ByRef Unit1 As RSWIN_DESC.PUDataRec, ByRef Unit2 As RSWIN_DESC.PUDataRec) As Boolean
			Dim flag As Boolean = False
			Dim result As Boolean
			Try
				Dim flag2 As Boolean = True
				If flag2 = (Operators.CompareString(Unit1.Manuf.Trim(), Unit2.Manuf.Trim(), False) <> 0) Then
					flag = True
				ElseIf flag2 = (Operators.CompareString(Unit1.UnitName.Trim(), Unit2.UnitName.Trim(), False) <> 0) Then
					flag = True
				ElseIf flag2 = (Operators.CompareString(Unit1.APIDesignation.Trim(), Unit2.APIDesignation.Trim(), False) <> 0) Then
					flag = True
				ElseIf flag2 = (Unit1.UnitType <> Unit2.UnitType) Then
					flag = True
				ElseIf flag2 = (Unit1.RequiredRotation <> Unit2.RequiredRotation) Then
					flag = True
				ElseIf flag2 = (Unit1.CrankHoles <> Unit2.CrankHoles) Then
					flag = True
				ElseIf flag2 = (Unit1.UnitType = 7S) OrElse flag2 = (Unit1.UnitType = 10S) Then
					Dim flag3 As Boolean = True
					If flag3 = (Unit1.DrumDiamRatio <> Unit2.DrumDiamRatio) Then
						flag = True
					ElseIf flag3 = (Unit1.SprocketRadius <> Unit2.SprocketRadius) Then
						flag = True
					ElseIf flag3 = (Unit1.SprocketDistance <> Unit2.SprocketDistance) Then
						flag = True
					End If
				ElseIf flag2 = Unit1.CrankHoles >= 5S Then
					Dim num As Integer = 0
					Do
						Dim flag4 As Boolean = True
						If flag4 = (Unit1.CrankRadii(num) <> Unit2.CrankRadii(num)) Then
							flag = True
						ElseIf flag4 = (Unit1.Strokes(num) <> Unit2.Strokes(num)) Then
							flag = True
						End If
						num += 1
					Loop While num <= 4
				ElseIf flag2 = Unit1.CrankHoles >= 4S Then
					Dim num As Integer = 0
					Do
						Dim flag5 As Boolean = True
						If flag5 = (Unit1.CrankRadii(num) <> Unit2.CrankRadii(num)) Then
							flag = True
						ElseIf flag5 = (Unit1.Strokes(num) <> Unit2.Strokes(num)) Then
							flag = True
						End If
						num += 1
					Loop While num <= 3
				ElseIf flag2 = Unit1.CrankHoles >= 3S Then
					Dim num As Integer = 0
					Do
						Dim flag6 As Boolean = True
						If flag6 = (Unit1.CrankRadii(num) <> Unit2.CrankRadii(num)) Then
							flag = True
						ElseIf flag6 = (Unit1.Strokes(num) <> Unit2.Strokes(num)) Then
							flag = True
						End If
						num += 1
					Loop While num <= 2
				ElseIf flag2 = Unit1.CrankHoles >= 2S Then
					Dim num As Integer = 0
					Do
						Dim flag7 As Boolean = True
						If flag7 = (Unit1.CrankRadii(num) <> Unit2.CrankRadii(num)) Then
							flag = True
						ElseIf flag7 = (Unit1.Strokes(num) <> Unit2.Strokes(num)) Then
							flag = True
						End If
						num += 1
					Loop While num <= 1
				ElseIf flag2 = Unit1.CrankHoles >= 1S Then
					Dim flag8 As Boolean = True
					If flag8 = (Unit1.CrankRadii(0) <> Unit2.CrankRadii(0)) Then
						flag = True
					ElseIf flag8 = (Unit1.Strokes(0) <> Unit2.Strokes(0)) Then
						flag = True
					End If
				ElseIf flag2 = (Unit1.R <> Unit2.R) Then
					flag = True
				ElseIf flag2 = (Unit1.A <> Unit2.A) Then
					flag = True
				ElseIf flag2 = (Unit1.C <> Unit2.C) Then
					flag = True
				ElseIf flag2 = (Unit1.I <> Unit2.I) Then
					flag = True
				ElseIf flag2 = (Unit1.K <> Unit2.K) Then
					flag = True
				ElseIf flag2 = (Unit1.P <> Unit2.P) Then
					flag = True
				ElseIf flag2 = (Unit1.M <> Unit2.M) Then
					flag = True
				ElseIf flag2 = (Unit1.S <> Unit2.S) Then
					flag = True
				ElseIf flag2 = (Unit1.V0 <> Unit2.V0) Then
					flag = True
				ElseIf flag2 = (Unit1.Unbalance <> Unit2.Unbalance) Then
					flag = True
				ElseIf flag2 = (Unit1.CrankOffset <> Unit2.CrankOffset) Then
					flag = True
				ElseIf flag2 = (Unit1.StructRating <> Unit2.StructRating) Then
					flag = True
				ElseIf flag2 = (Unit1.GearboxRating <> Unit2.GearboxRating) Then
					flag = True
				ElseIf flag2 = (Unit1.MaxStroke <> Unit2.MaxStroke) Then
					flag = True
				ElseIf flag2 = (Unit1.ArtInertia <> Unit2.ArtInertia) Then
					flag = True
				ElseIf flag2 = (Operators.CompareString(Unit1.OtherInfo.Trim(), Unit2.OtherInfo.Trim(), False) <> 0) Then
					flag = True
				End If
				result = flag
			Catch ex As Exception
				result = True
			End Try
			Return result
		End Function

		Public Sub ParseUnitID(ByRef ID As String, ByRef PUType As String, ByRef PUNum As Object)
			If ID.Length = 0 Then
				Return
			End If
			PUType = ""
			While Strings.Len(ID) > 0 AndAlso (65 <= Strings.Asc(ID) And Strings.Asc(ID) <= 90)
				PUType += Strings.Left(ID, 1)
				ID = Strings.Mid(ID, 2)
			End While
			Dim text As String = ""
			While Strings.Len(ID) > 0 AndAlso (48 <= Strings.Asc(ID) And Strings.Asc(ID) <= 57)
				text += Strings.Left(ID, 1)
				ID = Strings.Mid(ID, 2)
			End While
			PUNum = Convert.ToInt16(text)
		End Sub

		Public Function ReadPUData(ID As String, ByRef PU As RSWIN_DESC.PUDataRec, Optional bSuppressErrMsg As Boolean = False, Optional bSetUnitId As Boolean = True) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				result = False
				Dim text As String = Strings.Trim(ID)
				Dim num As Short
				Do
					num = CShort(Strings.InStr(text, " ", CompareMethod.Binary))
					If num > 0S Then
						text = text.Substring(0, CInt((num - 1S))) + Strings.Mid(text, CInt((num + 1S)))
					End If
				Loop While num > 0S
				text = Strings.UCase(text)
				ID = text
				If Strings.Len(text) <> 0 Then
					text = ID
					Dim num2 As Short
					Dim obj As Object = num2
					Dim text2 As String
					PUDATA1.ParseUnitID(text, text2, obj)
					num2 = Conversions.ToShort(obj)
					If Not(Strings.Len(text) <> 0 Or Strings.Len(text2) = 0 Or num2 <= 0S) Then
						Dim text3 As String
						FILEUTIL.LocateFile(text2 + "32.PUD", text3, 0S, False, False, False, False)
						If Strings.Len(text3) <> 0 Then
							Dim num3 As Short = CShort(FileSystem.FreeFile())
							FileSystem.FileOpen(CInt(num3), text3, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(PU))
							Dim num4 As Short = CShort((FileSystem.LOF(CInt(num3)) / CLng(Strings.Len(PU))))
							If num4 < num2 Then
								FileSystem.FileClose(New Integer() { CInt(num3) })
							Else
								result = True
								Dim fileNumber As Integer = CInt(num3)
								Dim valueType As ValueType = PU
								FileSystem.FileGet(fileNumber, valueType, CLng(num2))
								Dim valueType2 As ValueType = valueType
								Dim pudataRec As RSWIN_DESC.PUDataRec
								PU = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
								FileSystem.FileClose(New Integer() { CInt(num3) })
								If bSetUnitId Then
									RSWIN_DESC.rst.UnitID = text2 + Conversions.ToString(CInt(num2))
									PUDATA1.AddUnitTypeInfo(PU, text2)
								Else
									PUDATA1.AddUnitTypeInfo(PU, text2)
								End If
								If PU.UnitType = 10S Then
									PU.P = 0F
								End If
							End If
						End If
					End If
				End If
			Catch ex As Exception
				If Not bSuppressErrMsg Then
					Dim sMsg As String = "Error in ReadPUData: " + ex.Message
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				End If
			End Try
			Return result
		End Function

		Private Function GetCustomPUfromNum(i As Integer, ByRef PU As RSWIN_DESC.PUDataRec) As Boolean
			Dim flag As Boolean = True
			Dim result As Boolean
			Try
				Debug.WriteLine(PUDATA1.UnitData(i).Manuf.Trim())
				PU.Initialize()
				PU.Manuf = PUDATA1.UnitData(i).Manuf
				PU.APIDesignation = PUDATA1.UnitData(i).APIDesignation
				PU.UnitName = PUDATA1.UnitData(i).UnitName
				PU.OtherInfo = PUDATA1.UnitData(i).OtherInfo
				PU.UnitType = PUDATA1.UnitData(i).UnitType
				PU.RequiredRotation = PUDATA1.UnitData(i).RequiredRotation
				PU.CrankHoles = PUDATA1.UnitData(i).CrankHoles
				PU.CrankRadii(0) = PUDATA1.UnitData(i).CrankRadii(0)
				PU.CrankRadii(1) = PUDATA1.UnitData(i).CrankRadii(1)
				PU.CrankRadii(2) = PUDATA1.UnitData(i).CrankRadii(2)
				PU.CrankRadii(3) = PUDATA1.UnitData(i).CrankRadii(3)
				PU.CrankRadii(4) = PUDATA1.UnitData(i).CrankRadii(4)
				PU.Strokes(0) = PUDATA1.UnitData(i).Strokes(0)
				PU.Strokes(1) = PUDATA1.UnitData(i).Strokes(1)
				PU.Strokes(2) = PUDATA1.UnitData(i).Strokes(2)
				PU.Strokes(3) = PUDATA1.UnitData(i).Strokes(3)
				PU.Strokes(4) = PUDATA1.UnitData(i).Strokes(4)
				PU.FileRecord = PUDATA1.UnitData(i).FileRecord
				PU.KinematicStroke = PUDATA1.UnitData(i).KinematicStroke
				PU.R = PUDATA1.UnitData(i).R
				PU.A = PUDATA1.UnitData(i).A
				PU.C = PUDATA1.UnitData(i).C
				PU.I = PUDATA1.UnitData(i).I
				PU.K = PUDATA1.UnitData(i).K
				PU.P = PUDATA1.UnitData(i).P
				PU.M = PUDATA1.UnitData(i).M
				PU.S = PUDATA1.UnitData(i).S
				PU.V0 = PUDATA1.UnitData(i).V0
				PU.DrumDiamRatio = PUDATA1.UnitData(i).DrumDiamRatio
				PU.SprocketRadius = PUDATA1.UnitData(i).SprocketRadius
				PU.SprocketDistance = PUDATA1.UnitData(i).SprocketDistance
				PU.Unbalance = PUDATA1.UnitData(i).Unbalance
				PU.CrankOffset = PUDATA1.UnitData(i).CrankOffset
				PU.StructRating = PUDATA1.UnitData(i).StructRating
				PU.GearboxRating = PUDATA1.UnitData(i).GearboxRating
				PU.MaxStroke = PUDATA1.UnitData(i).MaxStroke
				PU.ArtInertia = PUDATA1.UnitData(i).ArtInertia
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub GetCustomUnitList(ByRef iFirstUnit As Short, ByRef nUnits As Short)
			Dim str As String = "CUSTOM"
			Dim text As String
			FILEUTIL.LocateFile(str + "32.PUD", text, 0S, False, False, False, False)
			If Strings.Len(text) = 0 Then
				PUDATA1.UnitData = New RSWIN_DESC.PUDataRec(0) {}
				Return
			End If
			Dim num As Short = CShort(FileSystem.FreeFile())
			Dim pudataRec As RSWIN_DESC.PUDataRec
			FileSystem.FileOpen(CInt(num), text, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(pudataRec))
			nUnits = CShort((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(pudataRec))))
			iFirstUnit = 1S
			If nUnits < iFirstUnit Then
				PUDATA1.UnitData = Nothing
			Else
				PUDATA1.UnitData = New RSWIN_DESC.PUDataRec(CInt((nUnits + 1S)) - 1) {}
				Dim num2 As Short = 0S
				Dim num3 As Short = CShort(Information.UBound(PUDATA1.UnitData, 1))

					For num4 As Short = num2 To num3
						PUDATA1.UnitData(CInt(num4)).Initialize()
					Next
					Dim num5 As Short = 1S
					Dim num6 As Short = nUnits
					For num4 As Short = num5 To num6
						Dim fileNumber As Integer = CInt(num)
						Dim unitData As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
						Dim num7 As Integer = CInt(num4)
						Dim valueType As ValueType = unitData(num7)
						FileSystem.FileGet(fileNumber, valueType, -1L)
						Dim unitData2 As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
						Dim num8 As Integer = num7
						Dim valueType2 As ValueType = valueType
						Dim pudataRec2 As RSWIN_DESC.PUDataRec
						unitData2(num8) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec2)
						Debug.WriteLine(" ")
						Debug.WriteLine(Conversions.ToString(CInt(num4)) + " " + PUDATA1.UnitData(CInt(num4)).Manuf)
					Next

			End If
			FileSystem.FileClose(New Integer() { CInt(num) })
		End Sub

		Public Function CheckCustomUnitList(ByRef TempPU As RSWIN_DESC.PUDataRec, sFileName As String) As Boolean
			Dim array As RSWIN_DESC.PUDataRec() = New RSWIN_DESC.PUDataRec(100) {}
			Dim flag As Boolean = False
			Dim num As Integer = -1
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim result As Boolean
			Try
				Dim num2 As Integer = CInt(CUSTOMPU.OpenCustomPUDB(True, False))
				Dim num3 As Integer
				If num2 >= 0 Then
					' The following expression was wrapped in a unchecked-expression
					num3 = CInt((FileSystem.LOF(num2) / CLng(Strings.Len(array(0)))))
					If num3 >= 2 Then
						array = New RSWIN_DESC.PUDataRec(num3 + 2 + 1 - 1) {}
						Dim array2 As Integer() = New Integer(num3 + 2 + 1 - 1) {}
						Dim num4 As Integer = 2
						Dim num5 As Integer = num3
						Dim i As Integer
						i = num4
						While i <= num5
							Dim fileNumber As Integer = num2
							Dim array3 As RSWIN_DESC.PUDataRec() = array
							Dim num6 As Integer = i
							Dim valueType As ValueType = array3(num6)
							FileSystem.FileGet(fileNumber, valueType, -1L)
							Dim array4 As RSWIN_DESC.PUDataRec() = array
							Dim num7 As Integer = num6
							Dim valueType2 As ValueType = valueType
							Dim pudataRec As RSWIN_DESC.PUDataRec
							array4(num7) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
							i += 1
						End While
						Dim obj As Object = 3
						PUDATA1.SortPUnits(array, array2, obj, 2, num3)
						Dim num8 As Integer = 2
						Dim num9 As Integer = num3
						i = num8
						While i <= num9
							Dim num10 As Integer = i
							If array(array2(num10)).Manuf IsNot Nothing AndAlso Not CUSTOMPU.IsStringEmpty(array(array2(num10)).Manuf) AndAlso Operators.CompareString(TempPU.Manuf.Trim(), array(array2(num10)).Manuf.Trim(), False) = 0 AndAlso (Operators.CompareString(TempPU.APIDesignation.Trim(), array(array2(num10)).APIDesignation.Trim(), False) = 0 And Operators.CompareString(TempPU.UnitName.Trim(), array(array2(num10)).UnitName.Trim(), False) = 0) Then
								flag3 = True
								Try
									Dim num11 As Integer = i
									If TempPU.CrankHole > 0S Then
										array(array2(num11)).CrankHole = TempPU.CrankHole
										array(array2(num11)).R = array(array2(num11)).CrankRadii(CInt((array(array2(num11)).CrankHole - 1S)))
									End If
									If array(array2(num11)).KinematicStroke = 0F Then
										kinemat.Unitstroke(array(array2(i)))
									End If
								Catch ex As Exception
								End Try
								flag = PUDATA1.ComparePU(TempPU, array(array2(i)))
								If flag Then
									num = array2(i)
								End If
								Dim text As String = RSWIN_DESC.rst.UnitID.Replace("CUSTOM", "")
								If Versioned.IsNumeric(text) Then
									If array2(i) <> Convert.ToInt32(text) Then
										RSWIN_DESC.rst.UnitID = "CUSTOM" + array2(i).ToString().Trim()
									End If
									RSWIN_DESC.rst.IDEntered = -1S
									Exit While
								End If
								Exit While
							Else
								i += 1
							End If
						End While
					End If
					FileSystem.FileClose(New Integer() { num2 })
				End If
				If flag Then
					Dim dlgDuplicateCustomPumpingUnit As dlgDuplicateCustomPumpingUnit = New dlgDuplicateCustomPumpingUnit()
					Dim dlgDuplicateCustomPumpingUnit2 As dlgDuplicateCustomPumpingUnit = dlgDuplicateCustomPumpingUnit
					dlgDuplicateCustomPumpingUnit2.TempPU1 = TempPU
					dlgDuplicateCustomPumpingUnit2.TempPU2 = array(num)
					dlgDuplicateCustomPumpingUnit2.UnitName = TempPU.Manuf.Trim() + ": " + TempPU.APIDesignation.Trim() + ": "
					dlgDuplicateCustomPumpingUnit.ShowDialog()
					If dlgDuplicateCustomPumpingUnit.bUseFile Then
						Dim dialogResult As DialogResult = MessageBox.Show("Update custom pumping unit in Setup with pumping unit in file?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
						If dialogResult = DialogResult.Yes Then
							array(num) = TempPU
							PUDATA1.UpdateCustomPumpingUnit(TempPU, num)
						End If
					ElseIf dlgDuplicateCustomPumpingUnit.bUseSetup Then
						TempPU = array(num)
						RSWIN_DESC.rst.PU = TempPU
						flag2 = True
					End If
					dlgDuplicateCustomPumpingUnit.Close()
				ElseIf Not flag3 Then
					Dim text2 As String = ""
					If CUSTOMPU.AddCustomPU(TempPU, text2, False) <> 0S Then
						num3 += 1
						RSWIN_DESC.rst.UnitID = "CUSTOM" + num3.ToString().Trim()
						Try
							PUDATA1.SAVEAFILE(sFileName)
						Catch ex2 As Exception
						End Try
					End If
				End If
				result = flag2
			Catch ex3 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub UpdateCustomPumpingUnit(TempPU As RSWIN_DESC.PUDataRec, nIndex As Integer)
			Try
				Dim num As Short = CUSTOMPU.OpenCustomPUDB(False, True)
				If num > 0S Then
					Dim fileNumber As Integer = CInt(num)
					Dim pudataRec As RSWIN_DESC.PUDataRec
					Dim valueType As ValueType = pudataRec
					FileSystem.FileGet(fileNumber, valueType, CLng(nIndex))
					Dim valueType2 As ValueType = valueType
					Dim pudataRec2 As RSWIN_DESC.PUDataRec
					pudataRec = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec2)
					If pudataRec.Manuf IsNot Nothing AndAlso Not CUSTOMPU.IsStringEmpty(pudataRec.Manuf) AndAlso Operators.CompareString(TempPU.Manuf.Trim(), pudataRec.Manuf.Trim(), False) = 0 AndAlso (Operators.CompareString(TempPU.APIDesignation.Trim(), pudataRec.APIDesignation.Trim(), False) = 0 And Operators.CompareString(TempPU.UnitName.Trim(), pudataRec.UnitName.Trim(), False) = 0) Then
						FileSystem.FilePut(CInt(num), TempPU, CLng(nIndex))
					End If
					FileSystem.FileClose(New Integer() { CInt(num) })
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function FindSmallestUnitID() As Boolean
			Dim sPUType As String = ""
			Dim result As Boolean
			Try
				If RSWIN_DESC.bXRODUseCustomizedLists And RSWIN_DESC.bXRODUseClosestUnit And RSWIN_DESC.bUsingClosestUnit Then
					RSWIN_DESC.SmallestUnitID = ""
					result = False
				Else
					RSWIN_DESC.SmallestUnitID = ""
					RSWIN_DESC.bSmallestUnitGearbox = False
					RSWIN_DESC.bSmallestUnitStructL = False
					Dim unitID As String = RSWIN_DESC.rst.UnitID
					If Strings.InStr(unitID, "CUSTOM", CompareMethod.Binary) <= 0 Then
						Dim num As Integer
						PUDATA1.ParseUnitID(unitID, sPUType, num)
						If unitID.Trim().Length = 0 Then
							result = False
						Else
							RSWIN_DESC.SmallestUnitID = PUDATA1.LoadSmallestUnitID(sPUType, RSWIN_DESC.rst.PU.MaxStroke)
						End If
					End If
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Function LoadSmallestUnitID(sPUType As String, MaxStroke As Single) As String
			Dim text As String = ""
			Dim num As Single = 10000F
			Dim result As String
			Try
				If Not(RSWIN_DESC.bXRODUseCustomizedLists And RSWIN_DESC.bXRODUseClosestUnit And RSWIN_DESC.bUsingClosestUnit) Then
					Dim fileName As String
					FILEUTIL.LocateFile(sPUType + "32.PUD", fileName, 2S, False, False, False, False)
					Dim num2 As Short
					Dim array As RSWIN_DESC.PUDataRec()
					Dim num3 As Short
					Dim array2 As Object()
					Dim num4 As Short
					Dim num5 As Short
					num2 = CShort(FileSystem.FreeFile())
					array = New RSWIN_DESC.PUDataRec(10) {}
					FileSystem.FileOpen(CInt(num2), fileName, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(array(0)))
					num3 = CShort((FileSystem.LOF(CInt(num2)) / CLng(Strings.Len(array(0)))))
					array = New RSWIN_DESC.PUDataRec(CInt((num3 + 1S)) - 1) {}
					array2 = New Object(CInt((num3 + 1S)) - 1) {}
					num4 = 1S
					num5 = num3
					For num6 As Short = num4 To num5
						Dim fileNumber As Integer = CInt(num2)
						Dim array3 As RSWIN_DESC.PUDataRec() = array
						Dim num7 As Integer = CInt(num6)
						Dim valueType As ValueType = array3(num7)
						FileSystem.FileGet(fileNumber, valueType, CLng(num6))
						Dim array4 As RSWIN_DESC.PUDataRec() = array
						Dim num8 As Integer = num7
						Dim valueType2 As ValueType = valueType
						Dim pudataRec As RSWIN_DESC.PUDataRec
						array4(num8) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
					Next
					FileSystem.FileClose(New Integer() { CInt(num2) })
					Dim obj As Object = 1
					PUDATA1.OSortPUnits(array, array2, obj)
					Dim num9 As Short = 1S
					Dim num10 As Short = num3
					For num6 As Short = num9 To num10
						If array(Conversions.ToInteger(array2(CInt(num6)))).MaxStroke = MaxStroke AndAlso array(Conversions.ToInteger(array2(CInt(num6)))).GearboxRating <= num Then
							text = sPUType.Trim() + Convert.ToString(RuntimeHelpers.GetObjectValue(array2(CInt(num6)))).Trim()
							Debug.WriteLine(String.Concat(New String() { text, " , ", Conversions.ToString(array(Conversions.ToInteger(array2(CInt(num6)))).GearboxRating), " , ", Conversions.ToString(array(Conversions.ToInteger(array2(CInt(num6)))).MaxStroke) }))
							num = array(Conversions.ToInteger(array2(CInt(num6)))).GearboxRating
						End If
					Next
					result = text
				End If
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function

		Private Sub SAVEAFILE(sFileName As String)
			Try
				Dim text As String
				If Operators.CompareString(sFileName, "", False) <> 0 Then
					text = sFileName
				Else
					sFileName = sFileName
					text = sFileName
				End If
				If Strings.Len(text) > 0 AndAlso (Strings.InStr(text.ToLower(), ".rsvx", CompareMethod.Binary) > 0 Or Strings.InStr(text.ToLower(), ".rsdx", CompareMethod.Binary) > 0 Or (Strings.InStr(text.ToLower(), ".xrvx", CompareMethod.Binary) > 0 And RSWIN_DESC.SETUP_bGuru)) Then
					If FILEUTIL.FileExists(text) Then
						FileSystem.Kill(text)
					End If
					Dim flag2 As Boolean
					Dim flag3 As Boolean
					Dim flag As Boolean = MRodstarXML.StoreXML(text, RSWIN_DESC.rst.gbOutputLoaded, flag2, flag3)
					If Not flag And (RSWIN_DESC.rst.gbOutputLoaded And Not flag3) Then
						If FILEUTIL.FileExists(text) Then
							FileSystem.Kill(text)
						End If
						flag = MRodstarXML.StoreXML(text, False, flag2, flag3)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Function GetExtension(sInputFile As String, sOrgExt As String, ByRef sExt As String) As Boolean
			Dim flag As Boolean = True
			If Strings.InStr(sInputFile, ".rsvx", CompareMethod.Binary) > 0 Then
				sExt = "rsvx"
			ElseIf Strings.InStr(sInputFile, ".RSVX", CompareMethod.Binary) > 0 Then
				sExt = "RSVX"
			ElseIf Strings.InStr(sInputFile, ".xrvx", CompareMethod.Binary) > 0 Then
				sExt = "xrvx"
			ElseIf Strings.InStr(sInputFile, ".XRVX", CompareMethod.Binary) > 0 Then
				sExt = "XRVX"
			ElseIf Strings.InStr(sInputFile, ".rsdx", CompareMethod.Binary) > 0 Then
				sExt = "rsdx"
			ElseIf Strings.InStr(sInputFile, ".RSDX", CompareMethod.Binary) > 0 Then
				sExt = "RSDX"
			ElseIf Strings.InStr(sInputFile, ".rst", CompareMethod.Binary) > 0 Then
				sExt = "rst"
			ElseIf Strings.InStr(sInputFile, ".RST", CompareMethod.Binary) > 0 Then
				sExt = "RST"
			Else
				flag = False
			End If
			If flag And Operators.CompareString(sOrgExt.ToLower().Trim(), sExt.ToLower().Trim(), False) = 0 Then
				flag = False
			End If
			Return flag
		End Function

		Public Sub SetGuruPumpingUnit(PUManuf_Preference As String)
			Dim num As Integer = -1
			Dim flag As Boolean = True
			Try
				Dim array As RSWIN_DESC.UnitTypeInfo()
				Dim num2 As Integer
				PUDATA1.LoadUnitTypeInfoList(array, num2)
				Dim unitID As String = RSWIN_DESC.rst.UnitID
				Dim manuf As String = RSWIN_DESC.rst.PU.Manuf
				If Operators.CompareString(PUManuf_Preference.Trim(), manuf.Trim(), False) <> 0 Then
					Dim num3 As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.rst.PU.GearboxRating)))
					Dim num4 As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.rst.PU.StructRating)))
					Dim num5 As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.rst.PU.MaxStroke)))
					Dim crankHole As Short = RSWIN_DESC.rst.PU.CrankHole
					Dim crankRotation As Short = RSWIN_DESC.rst.PU.CrankRotation
					Dim num6 As Integer = -1
					Dim num7 As Integer = 1
					Dim num8 As Integer = num2
					For i As Integer = num7 To num8
						If Operators.CompareString(PUManuf_Preference.Trim(), array(i).Manuf.Trim(), False) = 0 Then
							num6 = i
							Exit For
						End If
					Next
					If num6 <> -1 Then
						Dim text As String = array(num6).Abbrev.Trim()
						Dim sortByNames As Short = array(num6).SortByNames
						Dim num9 As Integer
						PUDATA1.GuruLoadUnitData(text, sortByNames, num9)
						Dim obj As Object = 2
						PUDATA1.SortPUnits(PUDATA1.UnitData, PUDATA1.uIdx, obj, Information.LBound(PUDATA1.UnitData, 1), Information.UBound(PUDATA1.UnitData, 1))
						Dim unit As RSWIN_DESC.PUDataRec
						unit.GearboxRating = CSng(num3)
						unit.StructRating = CSng(num4)
						unit.MaxStroke = CSng(num5)
						Dim num10 As Integer = Information.LBound(PUDATA1.UnitData, 1)
						Dim num11 As Integer = Information.UBound(PUDATA1.UnitData, 1)
						Dim num12 As Integer = num10
						Dim num13 As Integer = num11
						Dim j As Integer = num12
						While j <= num13
							Dim obj2 As Object = PUDATA1.ComparePU(unit, PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))), 2)
							If Operators.ConditionalCompareObjectEqual(obj2, 0S, False) Then
								Exit While
							End If
							If Operators.ConditionalCompareObjectEqual(obj2, -1S, False) Then
								If j > num10 Then
									j -= 1
									Exit While
								End If
								Exit While
							Else
								j += 1
							End If
						End While
						Dim num14 As Integer = j
						Dim flag2 As Boolean
						Dim num16 As Single
						If unit.GearboxRating = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).GearboxRating And unit.StructRating = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).StructRating Then
							flag2 = False
						ElseIf unit.MaxStroke = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).MaxStroke Then
							flag2 = False
						Else
							Dim unitData As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
							Dim num15 As Integer = Conversions.ToInteger(PUDATA1.uIdx(j))
							Dim flag3 As Boolean = False
							flag2 = Not PUDATA1.CheckCrankHoles(unit, unitData(num15), num, num16, flag3)
						End If
						If flag2 Then
							Dim num17 As Integer = num10
							Dim num18 As Integer = num11
							j = num17
							While j <= num18
								Dim obj3 As Object = PUDATA1.ComparePU(unit, PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))), 4)
								If Operators.ConditionalCompareObjectEqual(obj3, 0S, False) Then
									Exit While
								End If
								If Operators.ConditionalCompareObjectEqual(obj3, -1S, False) Then
									If j > num10 Then
										j -= 1
										Exit While
									End If
									Exit While
								Else
									j += 1
								End If
							End While
							If(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).MaxStroke > unit.MaxStroke And PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num14))).MaxStroke > unit.MaxStroke And PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).MaxStroke > PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num14))).MaxStroke) Or PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).MaxStroke = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num14))).MaxStroke Then
								j = num14
								flag2 = False
							End If
						End If
						If(unit.MaxStroke > PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).MaxStroke And Not flag2) AndAlso j - 1 >= num10 Then
							Dim flag4 As Boolean = True
							Dim num19 As Integer = j
							While flag4
								Dim flag5 As Boolean = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num19))).GearboxRating = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num19 - 1))).GearboxRating
								Dim flag6 As Boolean = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num19))).StructRating = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num19 - 1))).StructRating
								If(flag5 AndAlso flag6) And unit.MaxStroke > PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num19))).MaxStroke And PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num19 - 1))).MaxStroke > PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num19))).MaxStroke Then
									j = num19 - 1
								Else
									flag4 = False
								End If
								If flag4 And num19 - 1 >= num10 Then
									num19 -= 1
								Else
									flag4 = False
								End If
							End While
						End If
						If j > num11 Then
							j = num11
						End If
						Dim pu As RSWIN_DESC.PUDataRec
						pu.Initialize()
						Dim flag7 As Boolean = PUDATA1.ReadPUData(text + PUDATA1.uIdx(j).ToString().Trim(), pu, False, True)
						If flag7 Then
							If unit.MaxStroke <> pu.MaxStroke Then
								Dim flag3 As Boolean = True
								Dim flag8 As Boolean = PUDATA1.CheckCrankHoles(unit, pu, num, num16, flag3)
								If flag8 And num <> -1 Then
									crankHole = CShort((num + 1))
								End If
							End If
							pu.CrankHole = crankHole
							RSWIN_DESC.rst.CrankHole = pu.CrankHole
							pu.CrankRotation = crankRotation
							If Not(pu.UnitType = 7S Or pu.UnitType = 10S) Then
								pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
							Else
								pu.R = pu.CrankRadii(0)
							End If
							kinemat.Kinconst(pu)
							kinemat.Unitstroke(pu)
							RSWIN_DESC.rst.PU = pu
							RSWIN_DESC.rst.UnitID = text + PUDATA1.uIdx(j).ToString().Trim()
							If flag Then
								Try
									If unit.StructRating > PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).StructRating Then
										Dim num20 As Integer = 0
										Dim structRating As Single = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).StructRating
										Dim maxStroke As Single = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).MaxStroke
										Dim gearboxRating As Single = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).GearboxRating
										Dim num21 As Single = structRating
										obj = 5
										PUDATA1.SortPUnits(PUDATA1.UnitData, PUDATA1.uIdx, obj, Information.LBound(PUDATA1.UnitData, 1), Information.UBound(PUDATA1.UnitData, 1))
										num10 = Information.LBound(PUDATA1.UnitData, 1)
										num11 = Information.UBound(PUDATA1.UnitData, 1)
										Dim flag9 As Boolean = True
										Dim num22 As Integer = -1
										While flag9
											num20 += 1
											Dim num23 As Integer = -1
											Dim num24 As Integer = num11
											Dim num25 As Integer = num10
											j = num24
											While j >= num25
												If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).StructRating > num21 And PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).StructRating >= unit.StructRating Then
													num21 = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).StructRating
													num23 = j
													Exit While
												End If
												j += -1
											End While
											If num23 = -1 Then
												flag9 = False
											Else
												flag9 = True
												Dim num26 As Integer = num10
												Dim num27 As Integer = num11
												j = num26
												While j <= num27
													If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).StructRating = num21 Then
														If(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).GearboxRating = unit.GearboxRating And PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).MaxStroke = unit.MaxStroke) Or (PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).GearboxRating = gearboxRating And PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).MaxStroke = maxStroke) Then
															num22 = j
															flag9 = False
															Exit While
														End If
														If(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).GearboxRating >= unit.GearboxRating And PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).MaxStroke >= unit.MaxStroke) Or (PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).GearboxRating >= gearboxRating And PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(j))).MaxStroke >= maxStroke) Then
															num22 = j
															flag9 = False
														End If
													End If
													j += 1
												End While
											End If
											If num20 > 10 Then
												flag9 = False
											End If
										End While
										If num22 <> -1 AndAlso PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num22))).GearboxRating = gearboxRating Then
											flag7 = PUDATA1.ReadPUData(text + PUDATA1.uIdx(num22).ToString().Trim(), pu, False, True)
											If flag7 Then
												If unit.MaxStroke <> pu.MaxStroke Then
													Dim flag3 As Boolean = True
													Dim flag8 As Boolean = PUDATA1.CheckCrankHoles(unit, pu, num, num16, flag3)
													If flag8 And num <> -1 Then
														crankHole = CShort((num + 1))
													End If
												End If
												pu.CrankHole = crankHole
												RSWIN_DESC.rst.CrankHole = pu.CrankHole
												pu.CrankRotation = crankRotation
												If Not(pu.UnitType = 7S Or pu.UnitType = 10S) Then
													pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
												Else
													pu.R = pu.CrankRadii(0)
												End If
												kinemat.Kinconst(pu)
												kinemat.Unitstroke(pu)
												RSWIN_DESC.rst.PU = pu
												RSWIN_DESC.rst.UnitID = text + PUDATA1.uIdx(num22).ToString().Trim()
												Debug.WriteLine(String.Concat(New String() { Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating), ",", Conversions.ToString(RSWIN_DESC.rst.PU.StructRating), ",", Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke) }))
											End If
										End If
									End If
								Catch ex As Exception
								End Try
							End If
						End If
					End If
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Function MatchClosestToCustomizedList() As Boolean
			Dim str As String = ""
			Dim num As Integer = -1
			Dim result As Boolean
			Try
				Dim num2 As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.rst.PU.GearboxRating)))
				Dim num3 As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.rst.PU.StructRating)))
				Dim num4 As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.rst.PU.MaxStroke)))
				Dim pu As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
				Dim crankHole As Short = RSWIN_DESC.rst.PU.CrankHole
				Dim crankRotation As Short = RSWIN_DESC.rst.PU.CrankRotation
				RSWIN_DESC.sRecommendedUnit = String.Concat(New String() { "(", Conversions.ToString(pu.GearboxRating), "-", Conversions.ToString(pu.StructRating), "-", Conversions.ToString(pu.MaxStroke), ")" })
				Dim flag As Boolean = PUDATA1.LoadCustomizedPumpingUnits(RSWIN_DESC.rst.UnitID, str, True)
				Application.DoEvents()
				If flag Then
					Dim num5 As Integer = Information.LBound(PUDATA1.CustomizedUnitData, 1)
					Dim num6 As Integer = Information.UBound(PUDATA1.CustomizedUnitData, 1)
					Dim i As Integer
					Dim num11 As Single
					If(num5 = 0 And num6 = 0) Or PUDATA1.CustomizedUnitData.Count() = 1 Then
						i = 0
					Else
						Dim num7 As Integer = num5
						Dim num8 As Integer = num6
						i = num7
						While i <= num8
							Dim obj As Object = PUDATA1.ComparePU(pu, PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), 5)
							If Operators.ConditionalCompareObjectEqual(obj, 0S, False) Then
								Exit While
							End If
							If Operators.ConditionalCompareObjectEqual(obj, -1S, False) Then
								If i > num5 Then
									i -= 1
									Exit While
								End If
								Exit While
							Else
								If Operators.ConditionalCompareObjectEqual(obj, 1S, False) Then
									Debug.WriteLine("GT")
								ElseIf Operators.ConditionalCompareObjectEqual(obj, 2S, False) Then
									Debug.WriteLine("GE")
								End If
								i += 1
							End If
						End While
						If i > num6 Then
							i = num6
						End If
						Dim num9 As Integer = i
						Dim flag2 As Boolean
						If pu.GearboxRating = PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating And pu.StructRating = PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating Then
							flag2 = False
						ElseIf pu.MaxStroke = PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke Then
							flag2 = False
						Else
							Dim customizedUnitData As RSWIN_DESC.PUDataRec() = PUDATA1.CustomizedUnitData
							Dim num10 As Integer = Conversions.ToInteger(PUDATA1.uIdx(i))
							Dim flag3 As Boolean = False
							flag2 = Not PUDATA1.CheckCrankHoles(pu, customizedUnitData(num10), num, num11, flag3)
						End If
						If flag2 Then
							Dim num12 As Integer = num5
							Dim num13 As Integer = num6
							i = num12
							While i <= num13
								Dim obj2 As Object = PUDATA1.ComparePU(pu, PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), 6)
								If Operators.ConditionalCompareObjectEqual(obj2, 0S, False) Then
									Exit While
								End If
								If Operators.ConditionalCompareObjectEqual(obj2, -1S, False) Then
									If i > num5 Then
										i -= 1
										Exit While
									End If
									Exit While
								Else
									If Operators.ConditionalCompareObjectEqual(obj2, 1S, False) Then
										Debug.WriteLine("GT")
									End If
									i += 1
								End If
							End While
							If i > num6 Then
								i = num6
							End If
							If(PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke > pu.MaxStroke And PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(num9))).MaxStroke > pu.MaxStroke And PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke > PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(num9))).MaxStroke) Or PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke = PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(num9))).MaxStroke Then
								i = num9
								flag2 = False
							End If
						End If
						Application.DoEvents()
						If(pu.MaxStroke > PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke And Not flag2) AndAlso i - 1 >= num5 Then
							Dim flag4 As Boolean = True
							Dim num14 As Integer = i
							While flag4
								Dim flag5 As Boolean = PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(num14))).StructRating = PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(num14 - 1))).StructRating
								Dim flag6 As Boolean = PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(num14))).GearboxRating = PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(num14 - 1))).GearboxRating
								If(flag6 AndAlso flag5) And pu.MaxStroke > PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(num14))).MaxStroke And PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(num14 - 1))).MaxStroke > PUDATA1.CustomizedUnitData(Conversions.ToInteger(PUDATA1.uIdx(num14))).MaxStroke Then
									i = num14 - 1
								Else
									flag4 = False
								End If
								If flag4 And num14 - 1 >= num5 Then
									num14 -= 1
								Else
									flag4 = False
								End If
							End While
						End If
						If i > num6 Then
							i = num6
						End If
					End If
					Dim pu2 As RSWIN_DESC.PUDataRec
					pu2.Initialize()
					flag = PUDATA1.ReadPUData(str + PUDATA1.iCustomArray(Conversions.ToInteger(PUDATA1.uIdx(i))).ToString().Trim(), pu2, False, True)
					Application.DoEvents()
					If flag Then
						If pu.MaxStroke <> pu2.MaxStroke Then
							Dim flag3 As Boolean = True
							Dim flag7 As Boolean = PUDATA1.CheckCrankHoles(pu, pu2, num, num11, flag3)
							If flag7 And num <> -1 Then
								crankHole = CShort((num + 1))
							End If
						End If
						pu2.CrankHole = crankHole
						pu2.CrankRotation = crankRotation
						If Not(pu2.UnitType = 7S Or pu2.UnitType = 10S) Then
							pu2.R = pu2.CrankRadii(CInt((pu2.CrankHole - 1S)))
						Else
							pu2.R = pu2.CrankRadii(0)
						End If
						kinemat.Kinconst(pu2)
						kinemat.Unitstroke(pu2)
						RSWIN_DESC.rst.PU = pu2
						RSWIN_DESC.rst.UnitID = str + PUDATA1.iCustomArray(Conversions.ToInteger(PUDATA1.uIdx(i))).ToString().Trim()
					End If
					If flag Then
						If RSWIN_DESC.bXRODUseGeneralList Then
							If CSng(num2) <> RSWIN_DESC.rst.PU.GearboxRating And CSng(num3) <> RSWIN_DESC.rst.PU.StructRating And CSng(num4) <> RSWIN_DESC.rst.PU.MaxStroke Then
								flag = False
								If RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug Then
									Batch.BatchMessage(String.Concat(New String() { "> Use General List true in setup and equivalent match not found ( ", RSWIN_DESC.rst.UnitID, " , ", Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.StructRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke), ")" }))
								End If
							Else
								RSWIN_DESC.bUsingGeneralList = True
							End If
						ElseIf RSWIN_DESC.bXRODUseClosestUnit Then
							flag = True
							RSWIN_DESC.bUsingClosestUnit = True
						End If
					End If
				End If
				Application.DoEvents()
				result = flag
			Catch ex As Exception
				Debug.WriteLine(ex.Message)
			End Try
			Return result
		End Function

		Private Sub LoadUnitTypeInfoList(ByRef UnitTypeInfoList As RSWIN_DESC.UnitTypeInfo(), ByRef nUnitTypes As Integer)
			Dim text As String = New String(" "c, 2)
			Dim fileName As String
			FILEUTIL.LocateFile("UNITINFO32.PUD", fileName, 2S, False, False, False, False)
			Dim num As Short
			Dim unitTypeInfo As RSWIN_DESC.UnitTypeInfo
			Dim num3 As Short
			Dim num4 As Short
			num = CShort(FileSystem.FreeFile())
			FileSystem.FileOpen(CInt(num), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
			Dim num2 As Short = CShort((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(unitTypeInfo))))
			UnitTypeInfoList = New RSWIN_DESC.UnitTypeInfo(CInt((num2 + 1S)) - 1) {}
			nUnitTypes = 0
			num3 = 1S
			num4 = num2
			For num5 As Short = num3 To num4
				Dim fileNumber As Integer = CInt(num)
				Dim valueType As ValueType = unitTypeInfo
				FileSystem.FileGet(fileNumber, valueType, -1L)
				Dim valueType2 As ValueType = valueType
				Dim unitTypeInfo2 As RSWIN_DESC.UnitTypeInfo
				unitTypeInfo = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.UnitTypeInfo), unitTypeInfo2)
				Dim expression As String = Strings.Trim(unitTypeInfo.Abbrev)
				If Strings.Len(expression) > 0 Then
					nUnitTypes += 1
					UnitTypeInfoList(nUnitTypes) = unitTypeInfo
				End If
			Next
			FileSystem.FileClose(New Integer() { CInt(num) })
		End Sub

		Private Sub GuruLoadUnitData(sPUType As String, SortByNames As Short, ByRef nUnits As Integer)
			Try
				Dim fileName As String
				FILEUTIL.LocateFile(sPUType + "32.PUD", fileName, 2S, False, False, False, False)
				Dim num As Short
				Dim num2 As Short
				Dim num3 As Short
				num = CShort(FileSystem.FreeFile())
				PUDATA1.UnitData = New RSWIN_DESC.PUDataRec(10) {}
				FileSystem.FileOpen(CInt(num), fileName, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(PUDATA1.UnitData(0)))
				nUnits = CInt((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(PUDATA1.UnitData(0)))))
				PUDATA1.UnitData = New RSWIN_DESC.PUDataRec(nUnits + 1 - 1) {}
				PUDATA1.uIdx = New Object(nUnits + 1 - 1) {}
				num2 = 1S
				num3 = CShort(nUnits)
				For num4 As Short = num2 To num3
					Dim fileNumber As Integer = CInt(num)
					Dim unitData As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
					Dim num5 As Integer = CInt(num4)
					Dim valueType As ValueType = unitData(num5)
					FileSystem.FileGet(fileNumber, valueType, CLng(num4))
					Dim unitData2 As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
					Dim num6 As Integer = num5
					Dim valueType2 As ValueType = valueType
					Dim pudataRec As RSWIN_DESC.PUDataRec
					unitData2(num6) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
				Next
				FileSystem.FileClose(New Integer() { CInt(num) })
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.IIf(SortByNames <> 0S, 0, 1))
				PUDATA1.OSortPUnits(PUDATA1.UnitData, PUDATA1.uIdx, objectValue)
				Dim num7 As Short = 1S
				Dim num8 As Short = CShort(nUnits)
				For num4 As Short = num7 To num8
					PUDATA1.UnitData(CInt(num4)).FileRecord = 0S
				Next
			Catch ex As Exception
				Dim sMsg As String = "Error in GuruLoadUnitData: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Function LoadCustomizedPumpingUnits(sUnitID As String, ByRef sPUType As String, Optional bByStructure As Boolean = False) As Boolean
			Dim flag As Boolean = False
			sPUType = ""
			Dim result As Boolean
			Try
				Dim num As Integer
				PUDATA1.ParseUnitID(sUnitID, sPUType, num)
				Dim fileName As String
				FILEUTIL.LocateFile(sPUType + "32.PUD", fileName, 2S, False, False, False, False)
				Dim num2 As Short = CShort(FileSystem.FreeFile())
				Dim num3 As Short = -1S
				Dim text As String = Strings.Space(8192)
				PUDATA1.iCustomArray = New Integer(0) {}
				Dim num4 As Integer = Custom.CustomPumpingUnitLists_SelectRow(sPUType.Trim(), text, False, "")
				Dim length As Integer = text.Length
				If(length <> 0 And num4 <> 0) AndAlso text.Length > 0 Then
					Dim array As String() = Strings.Split(text.Trim(), ",", -1, CompareMethod.Binary)
					Dim num5 As Short = CShort(Information.LBound(array, 1))
					Dim num6 As Short = CShort(Information.UBound(array, 1))
					For num7 As Short = num5 To num6
						If Versioned.IsNumeric(array(CInt(num7))) Then
							Dim num8 As Short = Conversions.ToShort(array(CInt(num7)))
							If num8 > 0S Then
								num3 += 1S
								PUDATA1.iCustomArray = CType(Utils.CopyArray(CType(PUDATA1.iCustomArray, Array), New Integer(CInt((num3 + 1S)) - 1) {}), Integer())
								PUDATA1.iCustomArray(CInt(num3)) = CInt(num8)
							End If
						End If
					Next
				End If
				If num3 <> -1S Then
					PUDATA1.CustomizedUnitData = New RSWIN_DESC.PUDataRec(10) {}
					FileSystem.FileOpen(CInt(num2), fileName, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(PUDATA1.CustomizedUnitData(0)))
					Dim num9 As Integer = CInt((FileSystem.LOF(CInt(num2)) / CLng(Strings.Len(PUDATA1.CustomizedUnitData(0)))))
					PUDATA1.CustomizedUnitData = New RSWIN_DESC.PUDataRec(num9 + 1 - 1) {}
					PUDATA1.uIdx = New Object(num9 + 1 - 1) {}
					Array.Sort(Of Integer)(PUDATA1.iCustomArray)
					Dim num10 As Integer = 0
					PUDATA1.CustomizedUnitData = New RSWIN_DESC.PUDataRec(0) {}
					PUDATA1.uIdx = New Object(0) {}
					Dim num11 As Short = 1S
					Dim num12 As Short = CShort(num9)
					Dim num13 As Integer
					Dim num14 As Integer

						For num7 As Short = num11 To num12
							Dim pudataRec As RSWIN_DESC.PUDataRec
							pudataRec.Initialize()
							Dim fileNumber As Integer = CInt(num2)
							Dim valueType As ValueType = pudataRec
							FileSystem.FileGet(fileNumber, valueType, CLng(num7))
							Dim valueType2 As ValueType = valueType
							Dim pudataRec2 As RSWIN_DESC.PUDataRec
							pudataRec = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec2)
							If CInt(num7) = PUDATA1.iCustomArray(num10) Then
								PUDATA1.CustomizedUnitData = CType(Utils.CopyArray(CType(PUDATA1.CustomizedUnitData, Array), New RSWIN_DESC.PUDataRec(num10 + 1 - 1) {}), RSWIN_DESC.PUDataRec())
								PUDATA1.uIdx = CType(Utils.CopyArray(CType(PUDATA1.uIdx, Array), New Object(num10 + 1 - 1) {}), Object())
								PUDATA1.CustomizedUnitData(num10).Initialize()
								PUDATA1.CustomizedUnitData(num10) = pudataRec
								PUDATA1.uIdx(num10) = num10
								If num10 >= CInt(num3) Then
									Exit For
								End If
								num10 += 1
							End If
						Next
						FileSystem.FileClose(New Integer() { CInt(num2) })
						num13 = Information.LBound(PUDATA1.CustomizedUnitData, 1)
						num14 = Information.UBound(PUDATA1.CustomizedUnitData, 1)

					Dim num15 As Short = CShort(num13)
					Dim num16 As Short = CShort(num14)

						For num7 As Short = num15 To num16
							Dim num17 As Integer = CInt(num7)
							Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Conversions.ToString(PUDATA1.iCustomArray(CInt(num7))) + " , ", PUDATA1.uIdx(CInt(num7))), " , "), PUDATA1.CustomizedUnitData(num17).GearboxRating), "-"), PUDATA1.CustomizedUnitData(num17).StructRating), "-"), PUDATA1.CustomizedUnitData(num17).MaxStroke))
						Next
						If bByStructure Then
							Dim obj As Object = 5
							PUDATA1.SortPUnits(PUDATA1.CustomizedUnitData, PUDATA1.uIdx, obj, Information.LBound(PUDATA1.CustomizedUnitData, 1), Information.UBound(PUDATA1.CustomizedUnitData, 1))
						Else
							Dim obj As Object = 2
							PUDATA1.SortPUnits(PUDATA1.CustomizedUnitData, PUDATA1.uIdx, obj, Information.LBound(PUDATA1.CustomizedUnitData, 1), Information.UBound(PUDATA1.CustomizedUnitData, 1))
						End If
						flag = True

				End If
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function CheckCrankHoles(ByRef puRec As RSWIN_DESC.PUDataRec, ByRef UnitData As RSWIN_DESC.PUDataRec, ByRef iCrankHoleRet As Integer, ByRef fStroke As Single, ByRef bUseSmallest As Boolean) As Boolean
			Dim flag As Boolean = False
			fStroke = -1F
			Dim num As Integer = -1
			Dim num2 As Integer = 0
			Dim num3 As Integer = CInt((UnitData.CrankHoles - 1S))
			For i As Integer = num2 To num3
				Debug.WriteLine(UnitData.Strokes(i))
				If Math.Abs(puRec.MaxStroke - UnitData.Strokes(i)) < 4F Then
					iCrankHoleRet = i
					fStroke = UnitData.Strokes(i)
					flag = True
				ElseIf(Not flag And i > 0) AndAlso (UnitData.Strokes(i) < UnitData.Strokes(i - 1) And UnitData.Strokes(i) >= puRec.MaxStroke) Then
					num = i
					fStroke = UnitData.Strokes(i)
				End If
			Next
			If Not flag And bUseSmallest And num <> -1 Then
				iCrankHoleRet = num
				fStroke = UnitData.Strokes(num)
				flag = True
			End If
			Return flag
		End Function

		Public Function AdjustGearboxForScore(fGearboxRating As Single, fStructRating As Single, fMaxStroke As Single, ByRef sNewUnitId As String, Optional ByRef bSmallerGearbox As Boolean = False, Optional ByRef bFoundSB As Boolean = False, Optional ByRef bFindSmallerStrokeLength As Boolean = False, Optional ByRef bSmallerGBFound As Boolean = False, Optional ByRef bSmallerSLFound As Boolean = False, Optional bOnlyChangeGB As Boolean = False, Optional bLookForLargerOnlyForLargerFriction As Boolean = False) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim array As Single() = New Single(0) {}
				Dim num As Integer = -1
				If RSWIN_DESC.bXRODUseCustomizedLists And RSWIN_DESC.bXRODUseClosestUnit And RSWIN_DESC.bUsingClosestUnit Then
					sNewUnitId = ""
				Else
					bFoundSB = False
					bSmallerGearbox = False
					If CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.8 And Not bLookForLargerOnlyForLargerFriction Then
						bSmallerGearbox = True
					End If
					sNewUnitId = ""
					Dim unitID As String = RSWIN_DESC.rst.UnitID
					Dim str As String
					Dim num2 As Integer
					PUDATA1.ParseUnitID(unitID, str, num2)
					Dim fileName As String
					FILEUTIL.LocateFile(str + "32.PUD", fileName, 2S, False, False, False, False)
					Dim num3 As Short = CShort(FileSystem.FreeFile())
					PUDATA1.UnitData = New RSWIN_DESC.PUDataRec(10) {}
					FileSystem.FileOpen(CInt(num3), fileName, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(PUDATA1.UnitData(0)))
					PUDATA1.nUnits = CInt((FileSystem.LOF(CInt(num3)) / CLng(Strings.Len(PUDATA1.UnitData(0)))))
					PUDATA1.UnitData = New RSWIN_DESC.PUDataRec(PUDATA1.nUnits + 1 - 1) {}
					PUDATA1.uIdx = New Object(PUDATA1.nUnits + 1 - 1) {}
					array = New Single(0) {}
					Dim num4 As Integer = -1
					Dim num5 As Integer = 1
					Dim num6 As Integer = PUDATA1.nUnits
					For i As Integer = num5 To num6
						Dim fileNumber As Integer = CInt(num3)
						Dim unitData As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
						Dim num7 As Integer = i
						Dim valueType As ValueType = unitData(num7)
						FileSystem.FileGet(fileNumber, valueType, CLng(i))
						Dim unitData2 As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
						Dim num8 As Integer = num7
						Dim valueType2 As ValueType = valueType
						Dim pudataRec As RSWIN_DESC.PUDataRec
						unitData2(num8) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
						If bOnlyChangeGB Then
							If PUDATA1.UnitData(i).StructRating = fStructRating And PUDATA1.UnitData(i).GearboxRating <= fGearboxRating Then
								num4 += 1
								array = CType(Utils.CopyArray(CType(array, Array), New Single(num4 + 1 - 1) {}), Single())
								array(num4) = PUDATA1.UnitData(i).GearboxRating
							End If
						Else
							num4 += 1
							array = CType(Utils.CopyArray(CType(array, Array), New Single(num4 + 1 - 1) {}), Single())
							array(num4) = PUDATA1.UnitData(i).GearboxRating
						End If
					Next
					FileSystem.FileClose(New Integer() { CInt(num3) })
					Array.Sort(Of Single)(array)
					Dim num9 As Single = -1F
					Dim num10 As Single = -1F
					bFoundSB = False
					Dim num11 As Integer = Information.LBound(array, 1)
					Dim num12 As Integer = Information.UBound(array, 1)
					For i As Integer = num11 To num12
						If array(i) < fGearboxRating Then
							num9 = array(i)
						End If
						If array(i) > fGearboxRating And Not bFoundSB Then
							num10 = array(i)
							bFoundSB = True
						End If
					Next
					If num9 = -1F Then
						num9 = fGearboxRating
					End If
					If num10 = -1F Then
						num10 = fGearboxRating
					End If
					Dim num13 As Single
					If bSmallerGearbox Then
						num13 = num9
					Else
						num13 = num10
					End If
					Dim num14 As Integer = Information.LBound(PUDATA1.UnitData, 1)
					Dim num15 As Integer = Information.UBound(PUDATA1.UnitData, 1)
					Dim obj As Object = 5
					PUDATA1.SortPUnits(PUDATA1.UnitData, PUDATA1.uIdx, obj, num14, num15)
					Dim flag As Boolean = False
					Dim num16 As Integer = num14
					Dim num17 As Integer = num15
					For i As Integer = num16 To num17
						If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating = num13 Then
							If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating = fStructRating And PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), fMaxStroke, 0S) Then
								flag = True
								num = i
								Exit For
							End If
							If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating >= fStructRating AndAlso PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), fMaxStroke, 2S) Then
								num = i
							End If
						End If
					Next
					If num = -1 And bFindSmallerStrokeLength Then
						Dim num18 As Integer = num14
						Dim num19 As Integer = num15
						For i As Integer = num18 To num19
							Debug.WriteLine(Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating) + " , " + Conversions.ToString(num13))
							If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating = num13 Then
								Debug.WriteLine(String.Concat(New String() { i.ToString(), " : ", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke) }))
								If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating >= fStructRating AndAlso PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), fMaxStroke, -1S) Then
									num = i
								End If
							End If
						Next
					End If
					If bFoundSB And Not bSmallerGearbox And Not flag And num = -1 Then
						Dim flag2 As Boolean = True
						While flag2
							fGearboxRating = num10
							bFoundSB = False
							Dim num20 As Integer = Information.LBound(array, 1)
							Dim num21 As Integer = Information.UBound(array, 1)
							For i As Integer = num20 To num21
								If array(i) > fGearboxRating And Not bFoundSB Then
									num10 = array(i)
									num13 = num10
									bFoundSB = True
								End If
							Next
							If Not bFoundSB Then
								flag2 = False
							Else
								Dim num22 As Integer = num14
								Dim num23 As Integer = num15
								For i As Integer = num22 To num23
									If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating = num13 AndAlso PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), fMaxStroke, 0S) AndAlso PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating >= fStructRating Then
										num = i
										flag2 = False
										Exit For
									End If
								Next
							End If
						End While
					End If
					bSmallerSLFound = False
					If num <> -1 Then
						bSmallerGBFound = True
					Else
						bSmallerGBFound = False
					End If
					If bFindSmallerStrokeLength And num <> -1 Then
						sNewUnitId = str + PUDATA1.uIdx(num).ToString().Trim()
						Dim text As String = sNewUnitId
						If Not PUDATA1.CheckForSmallerStrokeLength(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num))).GearboxRating, PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num))).StructRating, PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num))).MaxStroke, sNewUnitId, bSmallerSLFound) Then
							sNewUnitId = text
						End If
						result = True
					ElseIf num <> -1 Then
						sNewUnitId = str + PUDATA1.uIdx(num).ToString().Trim()
						result = True
					Else
						sNewUnitId = ""
						result = False
					End If
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function AdjustGearbox(fGearboxRating As Single, fStructRating As Single, fMaxStroke As Single, ByRef sNewUnitId As String, bSmallerGearbox As Boolean, Optional ByRef bFoundSB As Boolean = False, Optional ByRef bFindSmallerStrokeLength As Boolean = False, Optional ByRef bSmallerGBFound As Boolean = False, Optional ByRef bSmallerSLFound As Boolean = False, Optional bOnlyChangeGB As Boolean = False, Optional bLookForLargerOnlyForLargerFriction As Boolean = False) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim array As Single() = New Single(0) {}
				Dim num As Integer = -1
				If RSWIN_DESC.bXRODUseCustomizedLists And RSWIN_DESC.bXRODUseClosestUnit And RSWIN_DESC.bUsingClosestUnit Then
					sNewUnitId = ""
				Else
					bFoundSB = False
					sNewUnitId = ""
					Dim unitID As String = RSWIN_DESC.rst.UnitID
					Dim str As String
					Dim num2 As Integer
					PUDATA1.ParseUnitID(unitID, str, num2)
					Dim fileName As String
					FILEUTIL.LocateFile(str + "32.PUD", fileName, 2S, False, False, False, False)
					Dim num3 As Short = CShort(FileSystem.FreeFile())
					PUDATA1.UnitData = New RSWIN_DESC.PUDataRec(10) {}
					FileSystem.FileOpen(CInt(num3), fileName, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(PUDATA1.UnitData(0)))
					PUDATA1.nUnits = CInt((FileSystem.LOF(CInt(num3)) / CLng(Strings.Len(PUDATA1.UnitData(0)))))
					PUDATA1.UnitData = New RSWIN_DESC.PUDataRec(PUDATA1.nUnits + 1 - 1) {}
					PUDATA1.uIdx = New Object(PUDATA1.nUnits + 1 - 1) {}
					array = New Single(0) {}
					Dim num4 As Integer = -1
					Dim num5 As Integer = 1
					Dim num6 As Integer = PUDATA1.nUnits
					For i As Integer = num5 To num6
						Dim fileNumber As Integer = CInt(num3)
						Dim unitData As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
						Dim num7 As Integer = i
						Dim valueType As ValueType = unitData(num7)
						FileSystem.FileGet(fileNumber, valueType, CLng(i))
						Dim unitData2 As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
						Dim num8 As Integer = num7
						Dim valueType2 As ValueType = valueType
						Dim pudataRec As RSWIN_DESC.PUDataRec
						unitData2(num8) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
						If bOnlyChangeGB Then
							If PUDATA1.UnitData(i).StructRating = fStructRating And PUDATA1.UnitData(i).GearboxRating <= fGearboxRating Then
								num4 += 1
								array = CType(Utils.CopyArray(CType(array, Array), New Single(num4 + 1 - 1) {}), Single())
								array(num4) = PUDATA1.UnitData(i).GearboxRating
							End If
						Else
							num4 += 1
							array = CType(Utils.CopyArray(CType(array, Array), New Single(num4 + 1 - 1) {}), Single())
							array(num4) = PUDATA1.UnitData(i).GearboxRating
						End If
					Next
					FileSystem.FileClose(New Integer() { CInt(num3) })
					Array.Sort(Of Single)(array)
					Dim num9 As Single = -1F
					Dim num10 As Single = -1F
					bFoundSB = False
					Dim num11 As Integer = Information.LBound(array, 1)
					Dim num12 As Integer = Information.UBound(array, 1)
					For i As Integer = num11 To num12
						If array(i) < fGearboxRating Then
							num9 = array(i)
						End If
						If array(i) > fGearboxRating And Not bFoundSB Then
							num10 = array(i)
							bFoundSB = True
						End If
					Next
					If num9 = -1F Then
						num9 = fGearboxRating
					End If
					If num10 = -1F Then
						num10 = fGearboxRating
					End If
					Dim num13 As Single
					If bSmallerGearbox Then
						num13 = num9
					Else
						num13 = num10
					End If
					Dim num14 As Integer = Information.LBound(PUDATA1.UnitData, 1)
					Dim num15 As Integer = Information.UBound(PUDATA1.UnitData, 1)
					Dim obj As Object = 5
					PUDATA1.SortPUnits(PUDATA1.UnitData, PUDATA1.uIdx, obj, num14, num15)
					Dim flag As Boolean = False
					Dim num16 As Integer = num14
					Dim num17 As Integer = num15
					For i As Integer = num16 To num17
						If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating = num13 Then
							If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating = fStructRating And PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), fMaxStroke, 0S) Then
								flag = True
								num = i
								Exit For
							End If
							If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating >= fStructRating AndAlso PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), fMaxStroke, 2S) Then
								num = i
							End If
						End If
					Next
					If num = -1 And bFindSmallerStrokeLength Then
						Dim num18 As Integer = num14
						Dim num19 As Integer = num15
						For i As Integer = num18 To num19
							Debug.WriteLine(Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating) + " , " + Conversions.ToString(num13))
							If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating = num13 Then
								Debug.WriteLine(String.Concat(New String() { i.ToString(), " : ", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke) }))
								If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating >= fStructRating AndAlso PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), fMaxStroke, -1S) Then
									num = i
								End If
							End If
						Next
					End If
					If bFoundSB And Not bSmallerGearbox And Not flag And num = -1 Then
						Dim flag2 As Boolean = True
						While flag2
							fGearboxRating = num10
							bFoundSB = False
							Dim num20 As Integer = Information.LBound(array, 1)
							Dim num21 As Integer = Information.UBound(array, 1)
							For i As Integer = num20 To num21
								If array(i) > fGearboxRating And Not bFoundSB Then
									num10 = array(i)
									num13 = num10
									bFoundSB = True
								End If
							Next
							If Not bFoundSB Then
								flag2 = False
							Else
								Dim num22 As Integer = num14
								Dim num23 As Integer = num15
								For i As Integer = num22 To num23
									If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating = num13 AndAlso PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), fMaxStroke, 0S) AndAlso PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating >= fStructRating Then
										num = i
										flag2 = False
										Exit For
									End If
								Next
							End If
						End While
					End If
					bSmallerSLFound = False
					If num <> -1 Then
						bSmallerGBFound = True
					Else
						bSmallerGBFound = False
					End If
					If bFindSmallerStrokeLength And num <> -1 Then
						sNewUnitId = str + PUDATA1.uIdx(num).ToString().Trim()
						Dim text As String = sNewUnitId
						If Not PUDATA1.CheckForSmallerStrokeLength(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num))).GearboxRating, PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num))).StructRating, PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num))).MaxStroke, sNewUnitId, bSmallerSLFound) Then
							sNewUnitId = text
						End If
						result = True
					ElseIf num <> -1 Then
						sNewUnitId = str + PUDATA1.uIdx(num).ToString().Trim()
						result = True
					Else
						sNewUnitId = ""
						result = False
					End If
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function AdjustStructureForScore(fGearboxRating As Single, fStructRating As Single, fMaxStroke As Single, ByRef sNewUnitId As String, bWriteDebugLines As Boolean, ByRef bExtraSLCheckDone As Boolean, Optional bCheckforSmallerStructure As Boolean = False, Optional bLookForLargerOnlyForLargerFriction As Boolean = False, Optional bLookForLargerStructure As Boolean = False, Optional iStructure As Integer = 0) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim array As Single() = New Single(0) {}
				Dim num As Integer = -1
				Dim flag As Boolean = False
				Dim num2 As Integer = -1
				Dim flag2 As Boolean = True
				If RSWIN_DESC.bXRODUseCustomizedLists And RSWIN_DESC.bXRODUseClosestUnit And RSWIN_DESC.bUsingClosestUnit Then
					sNewUnitId = ""
				Else
					If iStructure <> 0 Then
						fStructRating = CSng(iStructure)
					End If
					bExtraSLCheckDone = False
					If(CDbl(RSWIN_DESC.rst.StructL) < 0.8 OrElse bCheckforSmallerStructure) And Not bLookForLargerOnlyForLargerFriction Then
						flag = True
					End If
					sNewUnitId = ""
					Dim unitID As String = RSWIN_DESC.rst.UnitID
					Dim str As String
					Dim num3 As Integer
					PUDATA1.ParseUnitID(unitID, str, num3)
					Dim fileName As String
					FILEUTIL.LocateFile(str + "32.PUD", fileName, 2S, False, False, False, False)
					Dim num4 As Short = CShort(FileSystem.FreeFile())
					PUDATA1.UnitData = New RSWIN_DESC.PUDataRec(10) {}
					FileSystem.FileOpen(CInt(num4), fileName, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(PUDATA1.UnitData(0)))
					PUDATA1.nUnits = CInt((FileSystem.LOF(CInt(num4)) / CLng(Strings.Len(PUDATA1.UnitData(0)))))
					PUDATA1.UnitData = New RSWIN_DESC.PUDataRec(PUDATA1.nUnits + 1 - 1) {}
					PUDATA1.uIdx = New Object(PUDATA1.nUnits + 1 - 1) {}
					Dim num5 As Integer = 1
					Dim num6 As Integer = PUDATA1.nUnits
					For i As Integer = num5 To num6
						Dim fileNumber As Integer = CInt(num4)
						Dim unitData As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
						Dim num7 As Integer = i
						Dim valueType As ValueType = unitData(num7)
						FileSystem.FileGet(fileNumber, valueType, CLng(i))
						Dim unitData2 As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
						Dim num8 As Integer = num7
						Dim valueType2 As ValueType = valueType
						Dim pudataRec As RSWIN_DESC.PUDataRec
						unitData2(num8) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
						num += 1
						array = CType(Utils.CopyArray(CType(array, Array), New Single(num + 1 - 1) {}), Single())
						array(num) = PUDATA1.UnitData(i).StructRating
					Next
					FileSystem.FileClose(New Integer() { CInt(num4) })
					Array.Sort(Of Single)(array)
					Dim num9 As Single = -1F
					Dim num10 As Single = -1F
					Dim flag3 As Boolean = False
					Dim num11 As Integer = Information.LBound(array, 1)
					Dim num12 As Integer = Information.UBound(array, 1)
					For i As Integer = num11 To num12
						Debug.WriteLine(i.ToString() + " : " + Conversions.ToString(array(i)))
						If array(i) < fStructRating Then
							num9 = array(i)
						End If
						If array(i) > fStructRating And Not flag3 Then
							num10 = array(i)
							flag3 = True
						ElseIf iStructure <> 0 And array(i) >= fStructRating And Not flag3 Then
							num10 = array(i)
							flag3 = True
						End If
					Next
					If num9 = -1F Then
						num9 = fStructRating
					End If
					If num10 = -1F Then
						If iStructure <> 0 Then
							num10 = num9
						Else
							num10 = fStructRating
						End If
					End If
					Dim num13 As Single
					If flag Then
						num13 = num9
					Else
						num13 = num10
					End If
					Dim num14 As Integer = Information.LBound(PUDATA1.UnitData, 1)
					Dim num15 As Integer = Information.UBound(PUDATA1.UnitData, 1)
					Dim obj As Object = 2
					PUDATA1.SortPUnits(PUDATA1.UnitData, PUDATA1.uIdx, obj, num14, num15)
					Debug.WriteLine(String.Concat(New String() { Conversions.ToString(fGearboxRating), "-", Conversions.ToString(fStructRating), "-", Conversions.ToString(fMaxStroke) }))
					Dim num16 As Integer = num14
					Dim num17 As Integer = num15
					For i As Integer = num16 To num17
						If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating = num13 Then
							Debug.WriteLine(String.Concat(New String() { i.ToString(), " : ", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke) }))
							If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating = fGearboxRating And PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), fMaxStroke, 0S) Then
								num2 = i
								Exit For
							End If
							If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating >= fGearboxRating AndAlso PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), fMaxStroke, 2S) Then
								num2 = i
							End If
						End If
					Next
					Dim flag4 As Boolean
					If num2 <> -1 Then
						Debug.WriteLine(String.Concat(New String() { PUDATA1.uIdx(num2).ToString(), " : ", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num2))).GearboxRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num2))).StructRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num2))).MaxStroke) }))
						sNewUnitId = str + PUDATA1.uIdx(num2).ToString().Trim()
						flag4 = True
					ElseIf num13 = num10 AndAlso flag2 Then
						Dim num18 As Single = -1F
						Dim num19 As Integer = num14
						Dim num20 As Integer = num15
						Dim structRating As Single
						For i As Integer = num19 To num20
							If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating = fGearboxRating Then
								Debug.WriteLine(String.Concat(New String() { i.ToString(), " : ", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke) }))
								If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating >= num13 And PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke < fMaxStroke And PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke > num18 Then
									num18 = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke
									structRating = PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating
								End If
							End If
						Next
						If num18 <> -1F Then
							num13 = structRating
							Dim num21 As Integer = num14
							Dim num22 As Integer = num15
							For i As Integer = num21 To num22
								If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating = fGearboxRating Then
									Debug.WriteLine(String.Concat(New String() { i.ToString(), " : ", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke) }))
									If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating = num13 And (PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), num18, 0S) Or PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), fMaxStroke, 0S)) Then
										num2 = i
										Exit For
									End If
									If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating = num13 And (PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), num18, 2S) Or PUDATA1.CheckStroke(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))), fMaxStroke, 2S)) Then
										num2 = i
									End If
								End If
							Next
						End If
						If num2 <> -1 Then
							Debug.WriteLine(String.Concat(New String() { PUDATA1.uIdx(num2).ToString(), " : ", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num2))).GearboxRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num2))).StructRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num2))).MaxStroke) }))
							sNewUnitId = str + PUDATA1.uIdx(num2).ToString().Trim()
							If Not bLookForLargerOnlyForLargerFriction Then
								If bWriteDebugLines Then
									Batch.BatchMessage("> No unit found. Trying unit with larger structure and crankhole 2 ")
								End If
								flag4 = PUDATA1.RunNewUnitandCrankHole(sNewUnitId)
								If flag4 Then
									If bWriteDebugLines Then
										Batch.BatchMessage("> Keeping new unit and crankhole 2  ")
									End If
									bExtraSLCheckDone = True
								Else
									sNewUnitId = ""
									If bWriteDebugLines Then
										Batch.BatchMessage("> Reverting to older unit ")
									End If
								End If
							Else
								flag4 = True
							End If
						Else
							sNewUnitId = ""
							flag4 = False
						End If
					Else
						sNewUnitId = ""
					End If
					result = flag4
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function CheckStroke(UnitData As RSWIN_DESC.PUDataRec, fMaxStroke As Single, iType As Short) As Boolean
			Dim result As Boolean
			Try
				If iType = 0S Then
					If UnitData.MaxStroke = fMaxStroke Then
						result = True
					ElseIf Math.Abs(UnitData.MaxStroke - fMaxStroke) < 4F Then
						result = True
					ElseIf UnitData.Strokes IsNot Nothing Then
						Dim num As Integer = -1
						Dim num2 As Integer = 0
						Dim num3 As Integer = CInt((UnitData.CrankHoles - 1S))
						For i As Integer = num2 To num3
							' The following expression was wrapped in a unchecked-expression
							If UnitData.Strokes(i) = fMaxStroke Or Math.Abs(UnitData.Strokes(i) - fMaxStroke) < 2F Then
								num = i
								Exit For
							End If
						Next
						If num <> -1 Then
							result = True
						Else
							result = False
						End If
					Else
						result = False
					End If
				ElseIf iType = 2S Then
					If UnitData.MaxStroke >= fMaxStroke Then
						result = True
					Else
						result = False
					End If
				ElseIf iType = -1S Then
					If UnitData.MaxStroke < fMaxStroke Then
						result = True
					Else
						result = False
					End If
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function IsInCustomizedPUList(sUnitID As String) As Boolean
			Dim result As Boolean = False
			Dim text As String = ""
			Dim num As Integer
			PUDATA1.ParseUnitID(sUnitID, text, num)
			Dim text2 As String = Strings.Space(8192)
			Dim num2 As Integer = Custom.CustomPumpingUnitLists_SelectRow(text.Trim(), text2, False, "")
			Dim length As Integer = text2.Length
			If(length <> 0 And num2 <> 0) AndAlso text2.Length > 0 Then
				Dim array As String() = Strings.Split(text2.Trim(), ",", -1, CompareMethod.Binary)
				Dim num3 As Integer = Information.LBound(array, 1)
				Dim num4 As Integer = Information.UBound(array, 1)
				For i As Integer = num3 To num4
					If Versioned.IsNumeric(array(i)) Then
						Dim num5 As Short = Conversions.ToShort(array(i))
						If num5 > 0S AndAlso num = CInt(num5) Then
							result = True
							Exit For
						End If
					End If
				Next
			End If
			Return result
		End Function

		Public Function RunNewUnitandCrankHole(sNewUnitId As String) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				Dim bCheckToAdd As Boolean = False
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim num7 As Single
				Dim text As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, bCheckToAdd, flag, flag2, False, False)
				Dim num8 As Integer = num3
				Dim num9 As Single = num7
				Dim maxStroke As Single = RSWIN_DESC.rst.PU.MaxStroke
				Dim unitID As String = RSWIN_DESC.rst.UnitID
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				pu = RSWIN_DESC.rst.PU
				RSWIN_DESC.rst.UnitID = sNewUnitId
				Dim crankHole As Integer = CInt(RSWIN_DESC.rst.PU.CrankHole)
				Dim pu2 As RSWIN_DESC.PUDataRec
				pu2.Initialize()
				PUDATA1.ReadPUData(sNewUnitId, pu2, False, True)
				pu2.CrankHole = 2S
				RSWIN_DESC.rst.CrankHole = 2S
				If pu2.CrankHole > 0S Then
					RSWIN_DESC.rst.CrankHole = pu2.CrankHole
				End If
				If Not(pu2.UnitType = 7S Or pu2.UnitType = 10S) And pu2.CrankHole > 0S Then
					pu2.R = pu2.CrankRadii(CInt((pu2.CrankHole - 1S)))
				Else
					pu2.R = pu2.CrankRadii(0)
				End If
				kinemat.Kinconst(pu2)
				kinemat.Unitstroke(pu2)
				RSWIN_DESC.rst.PU = pu2
				Dim flag3 As Boolean = DESIGN.Design()
				Dim bCheckToAdd2 As Boolean = False
				flag2 = False
				flag = False
				text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, bCheckToAdd2, flag2, flag, False, False)
				Dim flag4 As Boolean
				If num3 >= num8 And num7 > num9 Then
					crankHole = CInt(pu2.CrankHole)
					flag4 = True
				Else
					RSWIN_DESC.rst.UnitID = unitID
					pu2.Initialize()
					pu2 = pu
					pu2.CrankHole = CShort(crankHole)
					If pu2.CrankHole > 0S Then
						RSWIN_DESC.rst.CrankHole = pu2.CrankHole
					End If
					If Not(pu2.UnitType = 7S Or pu2.UnitType = 10S) And pu2.CrankHole > 0S Then
						pu2.R = pu2.CrankRadii(CInt((pu2.CrankHole - 1S)))
					Else
						pu2.R = pu2.CrankRadii(0)
					End If
					kinemat.Kinconst(pu2)
					kinemat.Unitstroke(pu2)
					RSWIN_DESC.rst.PU = pu2
					flag3 = DESIGN.Design()
					Dim bCheckToAdd3 As Boolean = False
					flag2 = False
					flag = False
					text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, bCheckToAdd3, flag2, flag, False, False)
					flag4 = False
					sNewUnitId = ""
				End If
				result = flag4
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function CheckForSmallerStrokeLength(fGearboxRating As Single, fStructRating As Single, fMaxStroke As Single, ByRef sNewUnitId As String, ByRef bFoundSLSmaller As Boolean) As Boolean
			Dim num As Integer = -1
			Dim result As Boolean
			Try
				bFoundSLSmaller = False
				Dim id As String = sNewUnitId
				Dim str As String
				Dim num2 As Integer
				PUDATA1.ParseUnitID(id, str, num2)
				Dim num3 As Integer = Information.LBound(PUDATA1.UnitData, 1)
				Dim num4 As Integer = Information.UBound(PUDATA1.UnitData, 1)
				Dim num5 As Single = fMaxStroke
				bFoundSLSmaller = False
				Dim num6 As Integer = num3
				Dim num7 As Integer = num4
				For i As Integer = num6 To num7
					If PUDATA1.UnitData(i).GearboxRating = fGearboxRating And PUDATA1.UnitData(i).StructRating = fStructRating Then
						Debug.WriteLine(String.Concat(New String() { i.ToString(), " : ", Conversions.ToString(PUDATA1.UnitData(i).GearboxRating), "-", Conversions.ToString(PUDATA1.UnitData(i).StructRating), "-", Conversions.ToString(PUDATA1.UnitData(i).MaxStroke) }))
						If PUDATA1.UnitData(i).MaxStroke < fMaxStroke And Not bFoundSLSmaller Then
							num5 = PUDATA1.UnitData(i).MaxStroke
							bFoundSLSmaller = True
							num = i
						ElseIf PUDATA1.UnitData(i).MaxStroke > num5 And PUDATA1.UnitData(i).MaxStroke < fMaxStroke And bFoundSLSmaller Then
							num5 = PUDATA1.UnitData(i).MaxStroke
							bFoundSLSmaller = True
							num = i
						End If
					End If
				Next
				If num <> -1 Then
					Debug.WriteLine(String.Concat(New String() { num.ToString(), " : ", Conversions.ToString(PUDATA1.UnitData(num).GearboxRating), "-", Conversions.ToString(PUDATA1.UnitData(num).StructRating), "-", Conversions.ToString(PUDATA1.UnitData(num).MaxStroke) }))
					sNewUnitId = str + num.ToString().Trim()
					result = True
				Else
					result = False
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function CheckForSmallerStructure(fGearboxRating As Single, fStructRating As Single, fMaxStroke As Single, bCheckforSmallerStructure As Boolean, ByRef sNewUnitId As String) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim num As Single = -1F
				Dim array As Single() = New Single(0) {}
				Dim num2 As Integer = -1
				Dim num3 As Integer = -1
				sNewUnitId = ""
				If Not(RSWIN_DESC.bXRODUseCustomizedLists And RSWIN_DESC.bXRODUseClosestUnit And RSWIN_DESC.bUsingClosestUnit) Then
					Dim flag2 As Boolean
					If CDbl(RSWIN_DESC.rst.StructL) < 0.8 OrElse bCheckforSmallerStructure Then
						Dim flag As Boolean = True
						sNewUnitId = ""
						Dim unitID As String = RSWIN_DESC.rst.UnitID
						Dim str As String
						Dim num4 As Integer
						PUDATA1.ParseUnitID(unitID, str, num4)
						Dim fileName As String
						FILEUTIL.LocateFile(str + "32.PUD", fileName, 2S, False, False, False, False)
						Dim num5 As Short = CShort(FileSystem.FreeFile())
						PUDATA1.UnitData = New RSWIN_DESC.PUDataRec(10) {}
						FileSystem.FileOpen(CInt(num5), fileName, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(PUDATA1.UnitData(0)))
						PUDATA1.nUnits = CInt((FileSystem.LOF(CInt(num5)) / CLng(Strings.Len(PUDATA1.UnitData(0)))))
						PUDATA1.UnitData = New RSWIN_DESC.PUDataRec(PUDATA1.nUnits + 1 - 1) {}
						PUDATA1.uIdx = New Object(PUDATA1.nUnits + 1 - 1) {}
						Dim num6 As Integer = 1
						Dim num7 As Integer = PUDATA1.nUnits
						For i As Integer = num6 To num7
							Dim fileNumber As Integer = CInt(num5)
							Dim unitData As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
							Dim num8 As Integer = i
							Dim valueType As ValueType = unitData(num8)
							FileSystem.FileGet(fileNumber, valueType, CLng(i))
							Dim unitData2 As RSWIN_DESC.PUDataRec() = PUDATA1.UnitData
							Dim num9 As Integer = num8
							Dim valueType2 As ValueType = valueType
							Dim pudataRec As RSWIN_DESC.PUDataRec
							unitData2(num9) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
							num2 += 1
							array = CType(Utils.CopyArray(CType(array, Array), New Single(num2 + 1 - 1) {}), Single())
							array(num2) = PUDATA1.UnitData(i).StructRating
						Next
						FileSystem.FileClose(New Integer() { CInt(num5) })
						Array.Sort(Of Single)(array)
						Dim num10 As Single = -1F
						Dim num11 As Integer = Information.LBound(array, 1)
						Dim num12 As Integer = Information.UBound(array, 1)
						For i As Integer = num11 To num12
							Debug.WriteLine(i.ToString() + " : " + Conversions.ToString(array(i)))
							If array(i) < fStructRating Then
								num10 = array(i)
							End If
						Next
						If num10 = -1F Then
							num10 = fStructRating
						End If
						If flag Then
							num = num10
						End If
						Dim num13 As Integer = Information.LBound(PUDATA1.UnitData, 1)
						Dim num14 As Integer = Information.UBound(PUDATA1.UnitData, 1)
						Dim obj As Object = 2
						PUDATA1.SortPUnits(PUDATA1.UnitData, PUDATA1.uIdx, obj, num13, num14)
						Debug.WriteLine(String.Concat(New String() { Conversions.ToString(fGearboxRating), "-", Conversions.ToString(fStructRating), "-", Conversions.ToString(fMaxStroke) }))
						Dim num15 As Integer = num13
						Dim num16 As Integer = num14
						For i As Integer = num15 To num16
							If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating = num Then
								Debug.WriteLine(String.Concat(New String() { i.ToString(), " : ", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).StructRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke) }))
								If PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).GearboxRating = fGearboxRating And PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(i))).MaxStroke = fMaxStroke Then
									num3 = i
									Exit For
								End If
							End If
						Next
						If num3 <> -1 Then
							Debug.WriteLine(String.Concat(New String() { PUDATA1.uIdx(num3).ToString(), " : ", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num3))).GearboxRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num3))).StructRating), "-", Conversions.ToString(PUDATA1.UnitData(Conversions.ToInteger(PUDATA1.uIdx(num3))).MaxStroke) }))
							sNewUnitId = str + PUDATA1.uIdx(num3).ToString().Trim()
							flag2 = True
						Else
							flag2 = False
						End If
					Else
						flag2 = False
					End If
					result = flag2
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Const LT As Short = -1S

		Private Const EQ As Short = 0S

		Private Const GT As Short = 1S

		Private Const GE As Short = 2S

		Private UnitData As RSWIN_DESC.PUDataRec()

		Private uIdx As Object()

		Private nUnits As Integer

		Public CustomizedUnitData As RSWIN_DESC.PUDataRec()

		Public iCustomArray As Integer()

		Private iFirst As Integer

		Private iLast As Integer

		Private bFourthCrank As Boolean = False
	End Module
End Namespace
