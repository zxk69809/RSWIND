Imports System
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module CUSTOMPU
		Public Function OpenCustomPUDB(bRead As Boolean, bMustOpen As Boolean) As Short
			' The following expression was wrapped in a checked-statement
			Dim result As Short
			Try
				Dim num As Short = -1S
				Dim pudataRec As RSWIN_DESC.PUDataRec
				If bRead Then
					Dim text As String
					FILEUTIL.LocateFile("CUSTOM32.PUD", text, Conversions.ToShort(Interaction.IIf(bMustOpen, 2S, 0)), False, False, False, False)
					If Strings.Len(text) > 0 Then
						num = CShort(FileSystem.FreeFile())
						FileSystem.FileOpen(CInt(num), text, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(pudataRec))
					End If
				Else
					Dim num2 As Short = 0S
					Dim text As String
					FILEUTIL.LocateFile("CUSTOM32.PUD", text, 0S, False, False, False, False)
					If Strings.Len(text) = 0 Then
						num2 = -1S
						FILEUTIL.LocateFile("CUSTOM32.PUD", text, 1S, False, False, False, False)
					End If
					If Strings.Len(text) = 0 Then
						Util.Errmsg("The custom pumping unit database could not be created.")
					Else
						num = CShort(FileSystem.FreeFile())
						FileSystem.FileOpen(CInt(num), text, OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockWrite, Strings.Len(pudataRec))
						If num2 <> 0S Then
							pudataRec.UnitName = "CUSTOMPUDB"
							FileSystem.FilePut(CInt(num), pudataRec, 1L)
						End If
					End If
				End If
				If num >= 0S Then
					Dim fileNumber As Integer = CInt(num)
					Dim valueType As ValueType = pudataRec
					FileSystem.FileGet(fileNumber, valueType, 1L)
					Dim valueType2 As ValueType = valueType
					Dim pudataRec2 As RSWIN_DESC.PUDataRec
					pudataRec = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec2)
					If Operators.CompareString(Strings.Trim(pudataRec.UnitName), "CUSTOMPUDB", False) <> 0 Then
						FileSystem.FileClose(New Integer() { CInt(num) })
						num = -1S
						Util.Errmsg("The custom pumping unit database is invalid.")
					End If
				End If
				result = num
			Catch ex As Exception
				Util.Errmsg("Error occurred when trying to open custom pumping unit database." + ex.Message)
			End Try
			Return result
		End Function

		Public Function AddCustomPU(ByRef PU As RSWIN_DESC.PUDataRec, Optional ByRef sAddedItem As String = "", Optional bDontAsk As Boolean = False) As Short
			Dim result As Short
			Try
				sAddedItem = ""
				result = 0S
				Dim num As Short = -1S
				Dim num2 As Short = CUSTOMPU.OpenCustomPUDB(True, False)
				Dim num3 As Short
				If num2 < 0S Then
					num3 = 2S
				Else
					Dim pudataRec As RSWIN_DESC.PUDataRec
					Dim num5 As Short
					Dim num6 As Short
					Dim num4 As Short = CShort(Math.Round(CDbl(FileSystem.LOF(CInt(num2))) / CDbl(Strings.Len(pudataRec))))
					num3 = num4 + 1S
					num5 = 2S
					num6 = num4
					For num7 As Short = num5 To num6
						Dim fileNumber As Integer = CInt(num2)
						Dim valueType As ValueType = pudataRec
						FileSystem.FileGet(fileNumber, valueType, CLng(num7))
						Dim valueType2 As ValueType = valueType
						Dim pudataRec2 As RSWIN_DESC.PUDataRec
						pudataRec = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec2)
						If Strings.Len(Strings.Trim(pudataRec.Manuf)) = 0 Then
							num3 = num7
						ElseIf Strings.StrComp(Strings.Trim(PU.Manuf), Strings.Trim(pudataRec.Manuf), CompareMethod.Text) = 0 And Strings.StrComp(Strings.Trim(PU.UnitName), Strings.Trim(pudataRec.UnitName), CompareMethod.Text) = 0 And Strings.StrComp(Strings.Trim(PU.APIDesignation), Strings.Trim(pudataRec.APIDesignation), CompareMethod.Text) = 0 Then
							num = 0S
							PU.FileRecord = 0S
							result = -1S
							Exit For
						End If
					Next
				End If
				If num <> 0S Then
					Dim flag As Boolean
					If bDontAsk Then
						flag = True
					Else
						Dim msg As String = "The pumping unit in this file is not on your list of measured pumping units. Do you want to add this pumping unit to the list?"
						Dim bDefaultYes As Boolean = True
						Dim flag2 As Boolean = False
						flag = Util.YesNo(msg, bDefaultYes, flag2)
					End If
					If flag Then
						FileSystem.FileClose(New Integer() { CInt(num2) })
						If Strings.Len(Strings.Trim(PU.Manuf)) = 0 Then
							Dialogs.dlgGetPUManuf(PU.Manuf)
						End If
						num2 = CUSTOMPU.OpenCustomPUDB(False, False)
						If num2 >= 0S Then
							If PU.CrankHoles = 0S Then
								PU.CrankRadii(0) = PU.R
								PU.CrankHoles = 1S
								PU.CrankHole = 1S
								kinemat.Kinconst(PU)
								kinemat.Unitstroke(PU)
								PU.Strokes(0) = CSng(Conversion.Int(CDbl(PU.KinematicStroke) + 0.5))
							End If
							FileSystem.FilePut(CInt(num2), PU, CLng(num3))
							FileSystem.FileClose(New Integer() { CInt(num2) })
							PU.FileRecord = 1S
							result = -1S
							sAddedItem = PU.Manuf
							If Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 Then
								Try
									CUSTOMPU.GetCustomPumpingUnit(sAddedItem)
								Catch ex As Exception
								End Try
							End If
						End If
					End If
				End If
			Catch ex2 As Exception
				Util.Errmsg("Error occurred when trying to add to custom pumping unit database." + ex2.Message)
			End Try
			Return result
		End Function

		Public Function UpdateCustomPU(ByRef PU As RSWIN_DESC.PUDataRec, iIndex As Integer) As Boolean
			Dim result As Boolean
			Try
				Dim fileName As String
				FILEUTIL.LocateFile("CUSTOM32.PUD", fileName, 0S, False, False, False, False)
				Dim num As Short = CShort(FileSystem.FreeFile())
				Dim pudataRec As RSWIN_DESC.PUDataRec
				FileSystem.FileOpen(CInt(num), fileName, OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockWrite, Strings.Len(pudataRec))
				If num >= 0S Then
					Dim fileNumber As Integer = CInt(num)
					Dim valueType As ValueType = pudataRec
					FileSystem.FileGet(fileNumber, valueType, CLng((iIndex + 1)))
					Dim valueType2 As ValueType = valueType
					Dim pudataRec2 As RSWIN_DESC.PUDataRec
					pudataRec = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec2)
					pudataRec.Manuf = ""
					FileSystem.FilePut(CInt(num), pudataRec, CLng((iIndex + 1)))
					FileSystem.FileClose(New Integer() { CInt(num) })
					Try
						Dim text As String
						CUSTOMPU.AddCustomPU(PU, text, True)
					Catch ex As Exception
					End Try
				End If
				result = True
			Catch ex2 As Exception
				Util.Errmsg("Error occurred when trying to update to custom pumping unit database." + ex2.Message)
				Dim num As Short
				FileSystem.FileClose(New Integer() { CInt(num) })
				result = False
			End Try
			Return result
		End Function

		Public Sub GetCustomUnitNames(ByRef lvw As ListView)
			Dim array As RSWIN_DESC.PUDataRec() = New RSWIN_DESC.PUDataRec(100) {}
			Try
				Dim listView As ListView = lvw
				listView.Items.Clear()
				listView.View = View.Details
				listView.FullRowSelect = True
				listView.GridLines = True
				Dim num As Integer = CInt(CUSTOMPU.OpenCustomPUDB(True, False))
				If num >= 0 Then
					' The following expression was wrapped in a unchecked-expression
					Dim num2 As Integer = CInt((FileSystem.LOF(num) / CLng(Strings.Len(array(0)))))
					If num2 >= 2 Then
						array = New RSWIN_DESC.PUDataRec(num2 + 2 + 1 - 1) {}
						Dim array2 As Integer() = New Integer(num2 + 2 + 1 - 1) {}
						Dim num3 As Integer = 2
						Dim num4 As Integer = num2
						For i As Integer = num3 To num4
							Dim fileNumber As Integer = num
							Dim array3 As RSWIN_DESC.PUDataRec() = array
							Dim num5 As Integer = i
							Dim valueType As ValueType = array3(num5)
							FileSystem.FileGet(fileNumber, valueType, -1L)
							Dim array4 As RSWIN_DESC.PUDataRec() = array
							Dim num6 As Integer = num5
							Dim valueType2 As ValueType = valueType
							Dim pudataRec As RSWIN_DESC.PUDataRec
							array4(num6) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
						Next
						Dim obj As Object = 3
						PUDATA1.SortPUnits(array, array2, obj, 2, num2)
						Dim items As ListView.ListViewItemCollection = lvw.Items
						Dim num7 As Integer = 2
						Dim num8 As Integer = num2
						For i As Integer = num7 To num8
							Dim num9 As Integer = i
							Dim text As String = Strings.Trim(array(array2(num9)).APIDesignation)
							Dim text2 As String = Strings.Trim(array(array2(num9)).Manuf)
							Dim text3 As String = Strings.Trim(array(array2(num9)).OtherInfo)
							Dim text4 As String = Strings.Trim(array(array2(num9)).UnitName)
							Debug.WriteLine(text2 + " , " + text4)
							If Not CUSTOMPU.IsStringEmpty(text2) Then
								Dim listViewItem As ListViewItem = items.Add(text2)
								Dim subItems As ListViewItem.ListViewSubItemCollection = listViewItem.SubItems
								subItems.Add(CUSTOMPU.csKEY_APIDES).Text = text
								subItems.Add(CUSTOMPU.csKEY_UNAME).Text = text4
								subItems.Add(CUSTOMPU.csKEY_OTHER).Text = text3
								subItems.Add(CUSTOMPU.czKey_LOCATION).Text = array2(i).ToString()
							End If
						Next
					End If
					FileSystem.FileClose(New Integer() { num })
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub GetCustomUnitNames(ByRef sCustomUnits As RSWIN_DESC.PUDataRec(), ByRef Indxs As Integer(), sDatabaseFile As String)
			Dim array As RSWIN_DESC.PUDataRec() = New RSWIN_DESC.PUDataRec(100) {}
			Dim num As Integer = 0
			Try
				sCustomUnits = New RSWIN_DESC.PUDataRec(0) {}
				Indxs = New Integer(0) {}
				Dim num2 As Integer
				If Strings.Len(sDatabaseFile) > 0 Then
					num2 = FileSystem.FreeFile()
					Dim pudataRec As RSWIN_DESC.PUDataRec
					FileSystem.FileOpen(num2, sDatabaseFile, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(pudataRec))
				End If
				If num2 >= 0 Then
					' The following expression was wrapped in a unchecked-expression
					Dim num3 As Integer = CInt((FileSystem.LOF(num2) / CLng(Strings.Len(array(0)))))
					If num3 >= 2 Then
						array = New RSWIN_DESC.PUDataRec(num3 + 2 + 1 - 1) {}
						Dim array2 As Integer() = New Integer(num3 + 2 + 1 - 1) {}
						Dim num4 As Integer = 2
						Dim num5 As Integer = num3
						For i As Integer = num4 To num5
							Dim fileNumber As Integer = num2
							Dim array3 As RSWIN_DESC.PUDataRec() = array
							Dim num6 As Integer = i
							Dim valueType As ValueType = array3(num6)
							FileSystem.FileGet(fileNumber, valueType, -1L)
							Dim array4 As RSWIN_DESC.PUDataRec() = array
							Dim num7 As Integer = num6
							Dim valueType2 As ValueType = valueType
							Dim pudataRec2 As RSWIN_DESC.PUDataRec
							array4(num7) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec2)
						Next
						Dim obj As Object = 3
						PUDATA1.SortPUnits(array, array2, obj, 2, num3)
						Dim num8 As Integer = 2
						Dim num9 As Integer = num3
						For i As Integer = num8 To num9
							Dim num10 As Integer = i
							Dim pudataRec3 As RSWIN_DESC.PUDataRec
							Try
								pudataRec3.Initialize()
								pudataRec3.Manuf = array(array2(num10)).Manuf
								pudataRec3.UnitName = array(array2(num10)).UnitName
								pudataRec3.APIDesignation = array(array2(num10)).APIDesignation
								pudataRec3.UnitType = array(array2(num10)).UnitType
								pudataRec3.RequiredRotation = array(array2(num10)).RequiredRotation
								pudataRec3.CrankRotation = array(array2(num10)).CrankRotation
								pudataRec3.CrankHole = array(array2(num10)).CrankHole
								pudataRec3.CrankHoles = array(array2(num10)).CrankHoles
								pudataRec3.CrankRadii(0) = array(array2(num10)).CrankRadii(0)
								pudataRec3.CrankRadii(1) = array(array2(num10)).CrankRadii(1)
								pudataRec3.CrankRadii(2) = array(array2(num10)).CrankRadii(2)
								pudataRec3.CrankRadii(3) = array(array2(num10)).CrankRadii(3)
								pudataRec3.CrankRadii(4) = array(array2(num10)).CrankRadii(4)
								pudataRec3.Strokes(0) = array(array2(num10)).Strokes(0)
								pudataRec3.Strokes(1) = array(array2(num10)).Strokes(1)
								pudataRec3.Strokes(2) = array(array2(num10)).Strokes(2)
								pudataRec3.Strokes(3) = array(array2(num10)).Strokes(3)
								pudataRec3.Strokes(4) = array(array2(num10)).Strokes(4)
								pudataRec3.KinematicStroke = array(array2(num10)).KinematicStroke
								pudataRec3.R = array(array2(num10)).R
								pudataRec3.A = array(array2(num10)).A
								pudataRec3.C = array(array2(num10)).C
								pudataRec3.I = array(array2(num10)).I
								pudataRec3.K = array(array2(num10)).K
								pudataRec3.P = array(array2(num10)).P
								pudataRec3.M = array(array2(num10)).M
								pudataRec3.S = array(array2(num10)).S
								pudataRec3.V0 = array(array2(num10)).V0
								pudataRec3.DrumDiamRatio = array(array2(num10)).DrumDiamRatio
								pudataRec3.SprocketRadius = array(array2(num10)).SprocketRadius
								pudataRec3.SprocketDistance = array(array2(num10)).SprocketDistance
								pudataRec3.Unbalance = array(array2(num10)).Unbalance
								pudataRec3.CrankOffset = array(array2(num10)).CrankOffset
								pudataRec3.StructRating = array(array2(num10)).StructRating
								pudataRec3.GearboxRating = array(array2(num10)).GearboxRating
								pudataRec3.MaxStroke = array(array2(num10)).MaxStroke
								pudataRec3.ArtInertia = array(array2(num10)).ArtInertia
								pudataRec3.OtherInfo = array(array2(num10)).OtherInfo
							Catch ex As Exception
							End Try
							If Not CUSTOMPU.IsStringEmpty(pudataRec3.Manuf) Then
								num += 1
								sCustomUnits = CType(Utils.CopyArray(CType(sCustomUnits, Array), New RSWIN_DESC.PUDataRec(num + 1 - 1) {}), RSWIN_DESC.PUDataRec())
								Indxs = CType(Utils.CopyArray(CType(Indxs, Array), New Integer(num + 1 - 1) {}), Integer())
								Dim num11 As Integer = num
								Try
									sCustomUnits(num11).Initialize()
									sCustomUnits(num11).Manuf = pudataRec3.Manuf
									sCustomUnits(num11).UnitName = pudataRec3.UnitName
									sCustomUnits(num11).APIDesignation = pudataRec3.APIDesignation
									sCustomUnits(num11).UnitType = pudataRec3.UnitType
									sCustomUnits(num11).RequiredRotation = pudataRec3.RequiredRotation
									sCustomUnits(num11).CrankRotation = pudataRec3.CrankRotation
									sCustomUnits(num11).CrankHole = pudataRec3.CrankHole
									sCustomUnits(num11).CrankHoles = pudataRec3.CrankHoles
									sCustomUnits(num11).CrankRadii(0) = pudataRec3.CrankRadii(0)
									sCustomUnits(num11).CrankRadii(1) = pudataRec3.CrankRadii(1)
									sCustomUnits(num11).CrankRadii(2) = pudataRec3.CrankRadii(2)
									sCustomUnits(num11).CrankRadii(3) = pudataRec3.CrankRadii(3)
									sCustomUnits(num11).CrankRadii(4) = pudataRec3.CrankRadii(4)
									sCustomUnits(num11).Strokes(0) = pudataRec3.Strokes(0)
									sCustomUnits(num11).Strokes(1) = pudataRec3.Strokes(1)
									sCustomUnits(num11).Strokes(2) = pudataRec3.Strokes(2)
									sCustomUnits(num11).Strokes(3) = pudataRec3.Strokes(3)
									sCustomUnits(num11).Strokes(4) = pudataRec3.Strokes(4)
									sCustomUnits(num11).KinematicStroke = pudataRec3.KinematicStroke
									sCustomUnits(num11).R = pudataRec3.R
									sCustomUnits(num11).A = pudataRec3.A
									sCustomUnits(num11).C = pudataRec3.C
									sCustomUnits(num11).I = pudataRec3.I
									sCustomUnits(num11).K = pudataRec3.K
									sCustomUnits(num11).P = pudataRec3.P
									sCustomUnits(num11).M = pudataRec3.M
									sCustomUnits(num11).S = pudataRec3.S
									sCustomUnits(num11).V0 = pudataRec3.V0
									sCustomUnits(num11).DrumDiamRatio = pudataRec3.DrumDiamRatio
									sCustomUnits(num11).SprocketRadius = pudataRec3.SprocketRadius
									sCustomUnits(num11).SprocketDistance = pudataRec3.SprocketDistance
									sCustomUnits(num11).Unbalance = pudataRec3.Unbalance
									sCustomUnits(num11).CrankOffset = pudataRec3.CrankOffset
									sCustomUnits(num11).StructRating = pudataRec3.StructRating
									sCustomUnits(num11).GearboxRating = pudataRec3.GearboxRating
									sCustomUnits(num11).MaxStroke = pudataRec3.MaxStroke
									sCustomUnits(num11).ArtInertia = pudataRec3.ArtInertia
									sCustomUnits(num11).OtherInfo = pudataRec3.OtherInfo
								Catch ex2 As Exception
								End Try
								Indxs(num) = i
							End If
						Next
					End If
					FileSystem.FileClose(New Integer() { num2 })
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Function IsStringEmpty(myStr As String) As Boolean
			Dim obj As Object = False
			Dim num As Integer = 0
			Dim num2 As Integer = myStr.Length - 1
			For i As Integer = num To num2
				Dim num3 As Integer = Strings.Asc(myStr.Substring(i))
				If num3 = 0 Then
					obj = True
				End If
			Next
			Return Conversions.ToBoolean(obj)
		End Function

		Public Function GetCustomPumpingUnit(sManuf As String) As Boolean
			Dim array As RSWIN_DESC.PUDataRec() = New RSWIN_DESC.PUDataRec(100) {}
			Dim flag As Boolean = False
			Dim result As Boolean
			Try
				Dim num As Integer = CInt(CUSTOMPU.OpenCustomPUDB(True, False))
				If num >= 0 Then
					' The following expression was wrapped in a unchecked-expression
					Dim num2 As Integer = CInt((FileSystem.LOF(num) / CLng(Strings.Len(array(0)))))
					If num2 >= 2 Then
						array = New RSWIN_DESC.PUDataRec(num2 + 2 + 1 - 1) {}
						Dim array2 As Integer() = New Integer(num2 + 2 + 1 - 1) {}
						Dim num3 As Integer = 2
						Dim num4 As Integer = num2
						Dim i As Integer
						i = num3
						While i <= num4
							Dim fileNumber As Integer = num
							Dim array3 As RSWIN_DESC.PUDataRec() = array
							Dim num5 As Integer = i
							Dim valueType As ValueType = array3(num5)
							FileSystem.FileGet(fileNumber, valueType, -1L)
							Dim array4 As RSWIN_DESC.PUDataRec() = array
							Dim num6 As Integer = num5
							Dim valueType2 As ValueType = valueType
							Dim pudataRec As RSWIN_DESC.PUDataRec
							array4(num6) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
							i += 1
						End While
						Dim obj As Object = 3
						PUDATA1.SortPUnits(array, array2, obj, 2, num2)
						Dim num7 As Integer = 2
						Dim num8 As Integer = num2
						i = num7
						While i <= num8
							Dim num9 As Integer = i
							If array(array2(num9)).Manuf IsNot Nothing AndAlso Not CUSTOMPU.IsStringEmpty(array(array2(num9)).Manuf) AndAlso Operators.CompareString(sManuf.Trim(), array(array2(num9)).Manuf.Trim(), False) = 0 AndAlso (Operators.CompareString(RSWIN_DESC.rst.PU.APIDesignation.Trim(), array(array2(num9)).APIDesignation.Trim(), False) = 0 And Operators.CompareString(RSWIN_DESC.rst.PU.UnitName.Trim(), array(array2(num9)).UnitName.Trim(), False) = 0) Then
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
					FileSystem.FileClose(New Integer() { num })
				End If
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private csHDR_APIDES As String = "API designation"

		Private csHDR_MANUF As String = "Manufacturer"

		Private csHDR_OTHER As String = "Other info"

		Private csHDR_UNAME As String = "Unit name"

		Private csKEY_APIDES As String = "APIDesignation"

		Private csKEY_MANUF As String = "Manufacturer"

		Private csKEY_OTHER As String = "OtherInfo"

		Private csKEY_UNAME As String = "UnitName"

		Private czKey_LOCATION As String = "UnitLocation"

		Private Const KEY_MANUF As Integer = 1

		Private Const KEY_APIDES As Integer = 2

		Private Const KEY_UNAME As Integer = 3

		Private Const KEY_OTHER As Integer = 4

		Private iKEY_APIDES As Integer

		Private iKEY_MANUF As Integer

		Private iKEY_OTHER As Integer

		Private iKEY_UNAME As Integer
	End Module
End Namespace
