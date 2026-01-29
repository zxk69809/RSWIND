Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices
Imports ThetaStdInfo

Namespace RSWINV3
	Friend NotInheritable Module COSTDB
		Public Property nDBfrn As Short
			Get
				Return COSTDB.m_nDBfrn
			End Get
			Set(value As Short)
				COSTDB.m_nDBfrn = value
			End Set
		End Property

		Public Sub CostDBFillListBoxes(ByRef cboRodType As ComboBox, cboPUManuf As ListBox)
			Dim num As Integer = 0
			Try
				For Each obj As Object In RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.PumpingUnitDB().PumpingUnitLists()
					Dim tePumpingUnitList As tePumpingUnitList = CType(obj, tePumpingUnitList)
					cboPUManuf.Items.Add(New ListBoxItem(Strings.Trim(tePumpingUnitList.Manufacturer), num))
					num += 1
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Public Sub CostDBFillListBoxes(ByRef cboRodType As ComboBox, cboPUManuf As ComboBox)
			cboRodType.Items.Clear()
			cboRodType.Items.Add("Conventional steel")
			cboRodType.Items.Add("Sinker bars")
			cboRodType.Items.Add("Corod")
			cboRodType.Items.Add("Pro Rod")
			cboRodType.Items.Add("Fiberglass")
			cboPUManuf.Items.Clear()
			Dim text As String = New String(" "c, 2)
			Dim fileName As String
			FILEUTIL.LocateFile("UNITINFO32.PUD", fileName, 2S, False, False, False, False)
			Dim array As RSWIN_DESC.UnitTypeInfo()
			Dim num7 As Short
			Dim num8 As Short
			Dim num As Short = CShort(FileSystem.FreeFile())
			FileSystem.FileOpen(CInt(num), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
			Dim unitTypeInfo As RSWIN_DESC.UnitTypeInfo
			Dim num2 As Short = CShort((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(unitTypeInfo))))
			array = New RSWIN_DESC.UnitTypeInfo(CInt((num2 + 1S)) - 1) {}
			Dim num3 As Short = 0S
			Dim num4 As Short = 1S
			Dim num5 As Short = num2
			For num6 As Short = num4 To num5
				Dim fileNumber As Integer = CInt(num)
				Dim valueType As ValueType = unitTypeInfo
				FileSystem.FileGet(fileNumber, valueType, -1L)
				Dim valueType2 As ValueType = valueType
				Dim unitTypeInfo2 As RSWIN_DESC.UnitTypeInfo
				unitTypeInfo = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.UnitTypeInfo), unitTypeInfo2)
				Dim expression As String = Strings.Trim(unitTypeInfo.Abbrev)
				If Strings.Len(expression) > 0 Then
					num3 += 1S
					array(CInt(num3)) = unitTypeInfo
				End If
			Next
			FileSystem.FileClose(New Integer() { CInt(num) })
			array = CType(Utils.CopyArray(CType(array, Array), New RSWIN_DESC.UnitTypeInfo(CInt((num3 + 1S)) - 1) {}), RSWIN_DESC.UnitTypeInfo())
			cboPUManuf.Items.Clear()
			num7 = 1S
			num8 = num3
			For num6 As Short = num7 To num8
				cboPUManuf.Items.Add(New ListBoxItem(array(CInt(num6)).Manuf, CInt(num6)))
			Next
		End Sub

		Public Sub GetDIAMSfromThetaStdInfo(iGrade As Short, ByRef items As String(), ByRef diams As Single(), ByRef nItems As Short, Optional bSort As Boolean = False)
			' The following expression was wrapped in a checked-statement
			Try
				Dim rodSizeList As teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iGrade, StdInfoConstants.RodGradeConstants)).RodSizeList
				nItems = 0S
				diams = New Single(CInt((nItems + 1S)) - 1) {}
				items = New String(CInt((nItems + 1S)) - 1) {}
				Try
					For Each obj As Object In rodSizeList
						Dim dictionaryEntry As DictionaryEntry
						Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
						nItems += 1S
						diams = CType(Utils.CopyArray(CType(diams, Array), New Single(CInt((nItems + 1S)) - 1) {}), Single())
						items = CType(Utils.CopyArray(CType(items, Array), New String(CInt((nItems + 1S)) - 1) {}), String())
						diams(CInt(nItems)) = teRodSize.Diameter
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							items(CInt(nItems)) = teRodSize.DisplayName
						Else
							items(CInt(nItems)) = teRodSize.MetricDisplayName
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If bSort Then
					Dim flag As Boolean = False
					While Not flag
						flag = True
						Dim num As Integer = 1
						Dim num2 As Integer = CInt((nItems - 1S))
						For i As Integer = num To num2
							Debug.WriteLine(diams(i))
							If diams(i) > diams(i + 1) Then
								flag = False
								Dim num3 As Single = diams(i)
								diams(i) = diams(i + 1)
								diams(i + 1) = num3
							End If
						Next
					End While
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub CostDBGetDiameterList(iGrade As Short, sRodType As String, ByRef items As String(), ByRef sDBKeyList As String(), ByRef nItems As Short)
			Dim flag As Boolean = True
			Dim array As Single()
			Dim num4 As Short
			Dim num5 As Short
			If flag = (iGrade = 20481S) Then
				nItems = 1S
				array = New Single(CInt((nItems + 1S)) - 1) {}
				items = New String(CInt((nItems + 1S)) - 1) {}
				items(0) = RSWIN_DESC.sNull
				items(1) = "1.45x.212"""
				array(1) = CSng(Math.Sqrt(0.391393836051589))
			ElseIf flag = RODUTIL.IsCorodH(iGrade) Then
				nItems = 2S
				array = New Single(CInt((nItems + 1S)) - 1) {}
				items = New String(CInt((nItems + 1S)) - 1) {}
				items(0) = RSWIN_DESC.sNull
				items(1) = "682"
				items(2) = "757"

					array(1) = CSng((2.0 * Math.Sqrt(0.21708734237734525)))
					array(2) = CSng((2.0 * Math.Sqrt(0.24096058384112956)))

			ElseIf flag = RODUTIL.IsCorodSE(iGrade) Then
				Dim array2 As Object() = New Object(0) {}
				COSTDB.GetDIAMSfromThetaStdInfo(iGrade, items, array, nItems, False)
			Else
				Dim str As String
				Dim sMenu As String
				If RODUTIL.IsSinkerBar1(CInt(iGrade), sRodType) = 0 Then
					If iGrade = 16385S OrElse iGrade = 16389S OrElse iGrade = 16390S Then
						str = "FIBERFLEX"
					ElseIf iGrade = 16386S Then
						str = "PETROROD"
					ElseIf iGrade = 16388S Then
						str = "DURAROD"
					ElseIf iGrade = 16387S Then
						str = "NORRISFG"
					ElseIf iGrade = 8195S Then
						str = "FLEXBAR-C"
					ElseIf iGrade = 8196S Then
						str = "FLEXBAR-K"
					ElseIf iGrade = 12804S Then
						str = "COROD-C-R"
					ElseIf iGrade = 12801S Then
						str = "COROD-D-R"
					ElseIf iGrade = 12802S OrElse iGrade = 12803S Then
						str = "COROD-HS41-R"
					ElseIf iGrade = 24577S Then
						str = "PROROD-620"
					ElseIf iGrade = 24578S Then
						str = "PROROD-790"
					ElseIf iGrade = 24579S Then
						str = "PROROD-780"
					ElseIf iGrade = 24580S Then
						str = "PROROD-750"
					ElseIf iGrade = 24581S Then
						str = "PROROD-960"
					ElseIf iGrade = 24582S Then
						str = "PROROD-970"
					ElseIf Not RODUTIL.IsAPI(CInt(iGrade), sRodType) Then
						str = "STEEL-NONAPI"
					Else
						str = "DEFAULT"
					End If
					sMenu = "RODSECT-DIAMS-" + str
				End If
				Dim array3 As String() = New String(0) {}
				COSTDB.GetDIAMSfromThetaStdInfo(iGrade, items, array, nItems, False)
				If RODUTIL.IsSinkerBar1(CInt(iGrade), sRodType) <> 0 Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
						sMenu = "RSSB-DIAMSTRS-DEFAULT"
					Else
						sMenu = "RSSB-DIAMSTRS-DEFAULT-METRIC"
					End If
				ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					sMenu = "RODSECT-DIAMSTRS-" + str
				Else
					sMenu = "RODSECT-DIAMSTRS-" + str + "-METRIC"
				End If
				If nItems = 0S And items = Nothing Then
					array3 = New String(0) {}
					Util.LoadMenu(sMenu, nItems, array3)
					array = New Single(CInt((nItems + 1S)) - 1) {}
					items = New String(CInt((nItems + 1S)) - 1) {}
					Dim num As Short = 1S
					Dim num2 As Short = nItems

						For num3 As Short = num To num2
							array(CInt(num3)) = CSng(Conversion.Val(array3(CInt(num3))))
							Debug.WriteLine(array3(CInt(num3)))
							items(CInt(num3)) = array3(CInt(num3))
							If RSWIN_DESC.SETUP_MeasurementSystem = 1 AndAlso Strings.InStr("""", items(CInt(num3)), CompareMethod.Binary) <= 0 Then
								items(CInt(num3)) = items(CInt(num3)) + """"
							End If
						Next
						Array.Clear(array3, 0, array3.Length)

				End If
			End If
			sDBKeyList = New String(CInt((nItems + 1S)) - 1) {}
			num4 = 1S
			num5 = nItems
			For num3 As Short = num4 To num5
				Try
					COSTDB.MakeRGKey(iGrade, sRodType, array(CInt(num3)), sDBKeyList(CInt(num3)))
				Catch ex As Exception
				End Try
			Next
		End Sub

		Public Sub CostDBGetGuideList(ByRef Guides As String(), ByRef sDBKeyList As String(), ByRef nItems As Short)
			nItems = 12S
			Guides = New String(CInt((nItems + 1S)) - 1) {}
			sDBKeyList = New String(CInt((nItems + 1S)) - 1) {}
			Guides(1) = "Molded"
			Guides(2) = "Wheeled"
			Guides(3) = "Other Guided"
			Guides(4) = "Sidewinder Guide"
			Guides(5) = "Norris Standard Guide"
			Guides(6) = "Norris Sidewinder Guide"
			Guides(7) = "RGI Jake Coupling Guide"
			Guides(8) = "RGI SVT Guide"
			Guides(9) = "RGI Tomahawk Guide"
			Guides(10) = "RGI Tornado Guide"
			Guides(11) = "RGI Twister Guide"
			Guides(12) = "RGI WVT Guide"
			sDBKeyList(1) = "MOLDED"
			sDBKeyList(2) = "WHEELED"
			sDBKeyList(3) = "OtherGuided"
			sDBKeyList(4) = "SidewinderGuide"
			sDBKeyList(5) = "NorrisStandardGuide"
			sDBKeyList(6) = "NorrisSidewinderGuide"
			sDBKeyList(7) = "RGIJakeCouplingGuide"
			sDBKeyList(8) = "RGISVTGuide"
			sDBKeyList(9) = "RGITomahawkGuide"
			sDBKeyList(10) = "RGITornadoGuide"
			sDBKeyList(11) = "RGITwisterGuide"
			sDBKeyList(12) = "RGIWVTGuide"
		End Sub

		Public Sub CostDBGetPUList(nManufIndex As Short, ByRef asLabels As String(), ByRef asDBKeys As String(), ByRef asAPIDes As String(), ByRef asUnitNames As String(), ByRef asOtherInfo As String(), ByRef cItems As Short)
			Dim fileName As String
			FILEUTIL.LocateFile("UNITINFO32.PUD", fileName, 2S, False, False, False, False)
			Dim num As Short = CShort(FileSystem.FreeFile())
			Dim unitTypeInfo As RSWIN_DESC.UnitTypeInfo
			FileSystem.FileOpen(CInt(num), fileName, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(unitTypeInfo))
			Dim fileNumber As Integer = CInt(num)
			Dim valueType As ValueType = unitTypeInfo
			FileSystem.FileGet(fileNumber, valueType, CLng(nManufIndex))
			Dim valueType2 As ValueType = valueType
			Dim unitTypeInfo2 As RSWIN_DESC.UnitTypeInfo
			unitTypeInfo = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.UnitTypeInfo), unitTypeInfo2)
			FileSystem.FileClose(New Integer() { CInt(num) })
			Dim text As String = Strings.Trim(unitTypeInfo.Abbrev)
			Dim fileName2 As String
			FILEUTIL.LocateFile(text + "32.PUD", fileName2, 2S, False, False, False, False)
			Dim array As RSWIN_DESC.PUDataRec()
			Dim num2 As Short
			Dim num3 As Short
			num = CShort(FileSystem.FreeFile())
			FileSystem.FileOpen(CInt(num), fileName2, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
			array = New RSWIN_DESC.PUDataRec(0) {}
			cItems = CShort((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(array(0)))))
			array = New RSWIN_DESC.PUDataRec(CInt((cItems + 1S)) - 1) {}
			num2 = 1S
			num3 = cItems
			For num4 As Short = num2 To num3
				Dim fileNumber2 As Integer = CInt(num)
				Dim array2 As RSWIN_DESC.PUDataRec() = array
				Dim num5 As Integer = CInt(num4)
				valueType = array2(num5)
				FileSystem.FileGet(fileNumber2, valueType, -1L)
				Dim array3 As RSWIN_DESC.PUDataRec() = array
				Dim num6 As Integer = num5
				Dim valueType3 As ValueType = valueType
				Dim pudataRec As RSWIN_DESC.PUDataRec
				array3(num6) = If((valueType3 IsNot Nothing), CType(valueType3, RSWIN_DESC.PUDataRec), pudataRec)
			Next
			FileSystem.FileClose(New Integer() { CInt(num) })
			Dim array4 As Short()
			PUDATA1.SortPUnits(array, array4, Conversions.ToInteger(Interaction.IIf(unitTypeInfo.SortByNames <> 0S, 0, 1)))
			Dim num7 As Short
			Dim num8 As Short
			asLabels = New String(CInt((cItems + 1S)) - 1) {}
			asDBKeys = New String(CInt((cItems + 1S)) - 1) {}
			asAPIDes = New String(CInt((cItems + 1S)) - 1) {}
			asUnitNames = New String(CInt((cItems + 1S)) - 1) {}
			asOtherInfo = New String(CInt((cItems + 1S)) - 1) {}
			text = "PU/" + text
			num7 = 1S
			num8 = cItems
			For num4 As Short = num7 To num8
				If unitTypeInfo.ShowNames <> 0S Then
					asLabels(CInt(num4)) = RESULTS1.VTrim(array(CInt(array4(CInt(num4)))).UnitName)
				Else
					asLabels(CInt(num4)) = RESULTS1.VTrim(array(CInt(array4(CInt(num4)))).APIDesignation)
				End If
				asDBKeys(CInt(num4)) = text + Conversions.ToString(CInt(array4(CInt(num4))))
				asAPIDes(CInt(num4)) = RESULTS1.VTrim(array(CInt(array4(CInt(num4)))).APIDesignation)
				asUnitNames(CInt(num4)) = RESULTS1.VTrim(array(CInt(array4(CInt(num4)))).UnitName)
				asOtherInfo(CInt(num4)) = RESULTS1.VTrim(array(CInt(array4(CInt(num4)))).OtherInfo)
			Next
			FileSystem.FileClose(New Integer() { CInt(num) })
		End Sub

		Public Sub CostDBGetValues(ByRef sDBKeyList As String(), ByRef Values As Single(), nItems As Short)
			For num As Short = 1S To nItems
				COSTDB.DBLookup(sDBKeyList(CInt(num)), Values(CInt(num)))
			Next
		End Sub

		Public Sub CostDBInit(ByRef cboRodType As ComboBox, ByRef cboPUManuf As ComboBox)
			COSTDB.CostDBFillListBoxes(cboRodType, cboPUManuf)
		End Sub

		Public Sub CostDBLoadGrid(iType As Integer, ByRef mdsCostDB As DataSet, ByRef grdCostDB As UltraGrid, nItems As Short, ByRef asLabels As String(), ByRef asDBKeys As String(), ByRef asAPIDesc As String(), ByRef asExtraInfo As String())
			' The following expression was wrapped in a checked-expression
			Dim array As Single() = New Single(CInt((nItems + 1S)) - 1) {}
			COSTDB.CostDBGetValues(asDBKeys, array, nItems)
			mdsCostDB.Clear()
			For num As Short = 1S To nItems
				If asDBKeys(CInt(num)) IsNot Nothing AndAlso Operators.CompareString(asDBKeys(CInt(num)).Trim(), "", False) <> 0 AndAlso asLabels(CInt(num)) IsNot Nothing AndAlso Operators.CompareString(asLabels(CInt(num)).Trim(), "", False) <> 0 Then
					Dim dataRow As DataRow = mdsCostDB.Tables(0).NewRow()
					dataRow("DBKey") = asDBKeys(CInt(num))
					dataRow("Label") = asLabels(CInt(num))
					If Versioned.IsNumeric(array(CInt(num))) Then
						If array(CInt(num)) = 0F Then
							dataRow("Value") = ""
						Else
							Dim dataRow2 As DataRow = dataRow
							Dim columnName As String = "Value"
							Dim array2 As Single() = array
							Dim num2 As Integer = CInt(num)
							Dim text As String = "c"
							dataRow2(columnName) = Util.Format(array2(num2), text)
						End If
					Else
						dataRow("Value") = ""
					End If
					If iType = 0 Then
						dataRow("APIDesc") = asAPIDesc(CInt(num))
					End If
					dataRow("ExtraInfo") = asExtraInfo(CInt(num))
					Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow("DBKey"), ","), dataRow("Label")), ","), dataRow("Value")))
					mdsCostDB.Tables(0).Rows.Add(dataRow)
				End If
			Next
			Try
				Dim ultraGrid As UltraGrid = grdCostDB
				ultraGrid.DataSource = Nothing
				ultraGrid.DataSource = mdsCostDB
				ultraGrid.Rows.Refresh(RefreshRow.RefreshDisplay, True)
				ultraGrid.Refresh()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try
		End Sub

		Public Sub CostDBSetUnitSystem(ByRef grdCostDB As UltraGrid, iUnitSystem As Short)
			CtrlUI.fpSetText(grdCostDB, 3, 0, Convert.ToString(iUnitSystem))
		End Sub

		Public Sub CostDBSetUnitType(ByRef grdCostDB As UltraGrid, ByRef sUnitType As String)
			grdCostDB.Tag = sUnitType
		End Sub

		Public Sub CostDBShowGrid(ByRef grdCostDB As UltraGrid)
			grdCostDB.Enabled = True
			COSTDB.CostDBShowValues(grdCostDB)
			grdCostDB.Visible = True
		End Sub

		Public Sub CostDBShowValues(ByRef grdCostDB As UltraGrid)
			If grdCostDB.Enabled Then
				Dim tag As Object = grdCostDB.Tag
				If Operators.ConditionalCompareObjectEqual(tag, "d", False) Then
					CtrlUI.fpSetText(grdCostDB, 2, 0, RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, "$/ft", "$/m")))
					Dim num As Single = 1F / RSWIN_DESC.FT__M
				End If
				Return
			End If
		End Sub

		Public Sub DBConvert()
			Dim sFileTitle As String = "RODSTAR.CDB"
			Dim oldPath As String
			FILEUTIL.LocateFile(sFileTitle, oldPath, 9S, False, False, False, False)
			If Not FILEUTIL.FileExists(oldPath) Then
				Return
			End If
			COSTDB.DBOpen("")
			Dim nRecords As Short = COSTDB.DBHead.nRecords
			Dim array As COSTDB.DBItemRec() = New COSTDB.DBItemRec(CInt((nRecords + 1S)) - 1) {}
			Dim num As Short = 2S
			Dim num2 As Short = nRecords
			For num3 As Short = num To num2
				Dim nDBfrn As Integer = CInt(COSTDB.nDBfrn)
				Dim array2 As COSTDB.DBItemRec() = array
				Dim num4 As Integer = CInt(num3)
				Dim valueType As ValueType = array2(num4)
				FileSystem.FileGet(nDBfrn, valueType, CLng(num3))
				Dim array3 As COSTDB.DBItemRec() = array
				Dim num5 As Integer = num4
				Dim valueType2 As ValueType = valueType
				Dim dbitemRec As COSTDB.DBItemRec
				array3(num5) = If((valueType2 IsNot Nothing), CType(valueType2, COSTDB.DBItemRec), dbitemRec)
			Next
			COSTDB.DBClose()
			COSTDB.nDBfrn = 0S
			FileSystem.Rename(oldPath, "RSCDB.SAV")
			COSTDB.DBOpen("")
			Dim num6 As Short = 2S
			Dim num7 As Short = nRecords
			For num3 As Short = num6 To num7
				Dim text As String = Strings.Trim(array(CInt(num3)).sKey)
				If Operators.CompareString(Strings.Left(text, 2), "RG", False) = 0 Then
					Dim text2 As String = Strings.Mid(text, 4)
					Dim text3 As String = Strings.Mid(text2, Strings.InStr(text2, "/", CompareMethod.Binary) + 1)
					text2 = Strings.Left(text2, Strings.InStr(text2, "/", CompareMethod.Binary) - 1)
					If Versioned.IsNumeric(text2) Then
						Dim rodSection As RSWIN_DESC.RodSection
						rodSection.Grade = Conversions.ToShort(text2)
						rodSection.Diameter = CSng(Conversion.Val(text3))
						rodSection.SuckerRodLength = CSng(Conversion.Val(text3))
						Dim flag As Boolean = RODUTIL.ConvertRodGrade(rodSection) <> 0
						Dim grade As Short = rodSection.Grade
						Dim num8 As Short = grade
						If num8 = 16385S OrElse num8 = 16389S OrElse num8 = 16390S Then
							If Strings.InStr(text3, "/", CompareMethod.Binary) > 0 Then
								text3 = Strings.Mid(text3, Strings.InStr(text3, "/", CompareMethod.Binary) + 1)
							End If
						ElseIf num8 = -1S Then
							text2 = RSWIN_DESC.sNull
						End If
						If Strings.Len(text2) > 0 Then
							text = "RG/" + text2 + "/" + text3
						End If
					End If
				End If
				COSTDB.DBInsert(text, Conversions.ToString(array(CInt(num3)).Value))
			Next
			COSTDB.DBClose()
		End Sub

		Public Sub DBInsert(sDBKey As String, Value As String)
			Try
				Dim value As Single
				If Value Is Nothing Then
					value = 0F
				ElseIf Operators.CompareString(Value.Trim(), "", False) = 0 Then
					value = 0F
				Else
					Try
						Value = Value.Replace("$", "")
					Catch ex As Exception
					End Try
					value = Convert.ToSingle(Value)
				End If
				COSTDB.DBOpen("")
				Dim num As Short = COSTDB.DBHead.nHead
				Dim dbitemRec As COSTDB.DBItemRec
				dbitemRec.sKey = sDBKey
				dbitemRec.nLeft = 0S
				dbitemRec.nRight = 0S
				Dim dbitemRec3 As COSTDB.DBItemRec
				If num = 0S Then
					num = COSTDB.AllocNewRecord()
					COSTDB.DBHead.nHead = num
					FileSystem.FilePut(CInt(COSTDB.nDBfrn), COSTDB.DBHead, 1L)
				Else
					Dim nDBfrn As Integer = CInt(COSTDB.nDBfrn)
					Dim dbitemRec2 As COSTDB.DBItemRec
					Dim valueType As ValueType = dbitemRec2
					FileSystem.FileGet(nDBfrn, valueType, CLng(num))
					Dim valueType2 As ValueType = valueType
					dbitemRec2 = If((valueType2 IsNot Nothing), CType(valueType2, COSTDB.DBItemRec), dbitemRec3)
					While Not FileSystem.EOF(CInt(COSTDB.nDBfrn)) AndAlso num <> 0S
						If Operators.CompareString(Strings.Trim(sDBKey), Strings.Trim(dbitemRec2.sKey), False) < 0 Then
							If dbitemRec2.nLeft = 0S Then
								dbitemRec2.nLeft = COSTDB.AllocNewRecord()
								FileSystem.FilePut(CInt(COSTDB.nDBfrn), dbitemRec2, CLng(num))
								num = dbitemRec2.nLeft
								Exit While
							End If
							num = dbitemRec2.nLeft
						Else
							If Operators.CompareString(Strings.Trim(sDBKey), Strings.Trim(dbitemRec2.sKey), False) <= 0 Then
								dbitemRec = dbitemRec2
								Exit While
							End If
							If dbitemRec2.nRight = 0S Then
								dbitemRec2.nRight = COSTDB.AllocNewRecord()
								FileSystem.FilePut(CInt(COSTDB.nDBfrn), dbitemRec2, CLng(num))
								num = dbitemRec2.nRight
								Exit While
							End If
							num = dbitemRec2.nRight
						End If
						Try
							Dim nDBfrn2 As Integer = CInt(COSTDB.nDBfrn)
							valueType = dbitemRec2
							FileSystem.FileGet(nDBfrn2, valueType, CLng(num))
							Dim valueType3 As ValueType = valueType
							dbitemRec2 = If((valueType3 IsNot Nothing), CType(valueType3, COSTDB.DBItemRec), dbitemRec3)
						Catch ex2 As Exception
						End Try
					End While
					If Operators.CompareString(Strings.Trim(sDBKey), Strings.Trim(dbitemRec2.sKey), False) < 0 Then
						If dbitemRec2.nLeft <> 0S Then
							num = dbitemRec2.nLeft
						Else
							dbitemRec2.nLeft = COSTDB.AllocNewRecord()
							FileSystem.FilePut(CInt(COSTDB.nDBfrn), dbitemRec2, CLng(num))
							num = dbitemRec2.nLeft
						End If
					ElseIf Operators.CompareString(Strings.Trim(sDBKey), Strings.Trim(dbitemRec2.sKey), False) > 0 Then
						If dbitemRec2.nRight <> 0S Then
							num = dbitemRec2.nRight
						Else
							dbitemRec2.nRight = COSTDB.AllocNewRecord()
							FileSystem.FilePut(CInt(COSTDB.nDBfrn), dbitemRec2, CLng(num))
							num = dbitemRec2.nRight
						End If
					Else
						dbitemRec = dbitemRec2
					End If
				End If
				dbitemRec.Value = value
				FileSystem.FilePut(CInt(COSTDB.nDBfrn), dbitemRec, CLng(num))
				Try
					Dim nDBfrn3 As Integer = CInt(COSTDB.nDBfrn)
					Dim dbitemRec4 As COSTDB.DBItemRec
					Dim valueType As ValueType = dbitemRec4
					FileSystem.FileGet(nDBfrn3, valueType, CLng(num))
					Dim valueType4 As ValueType = valueType
					dbitemRec4 = If((valueType4 IsNot Nothing), CType(valueType4, COSTDB.DBItemRec), dbitemRec3)
				Catch ex3 As Exception
				End Try
				COSTDB.DBClose()
			Catch ex4 As Exception
			End Try
		End Sub

		Public Sub DBLookup(sDBKey As String, ByRef Value As Single)
			Try
				COSTDB.DBOpen("")
				Value = 0F
				Dim num As Short = COSTDB.DBHead.nHead
				Dim nDBfrn As Integer = CInt(COSTDB.nDBfrn)
				Dim dbitemRec As COSTDB.DBItemRec
				Dim valueType As ValueType = dbitemRec
				FileSystem.FileGet(nDBfrn, valueType, CLng(num))
				Dim valueType2 As ValueType = valueType
				Dim dbitemRec2 As COSTDB.DBItemRec
				dbitemRec = If((valueType2 IsNot Nothing), CType(valueType2, COSTDB.DBItemRec), dbitemRec2)
				While Not FileSystem.EOF(CInt(COSTDB.nDBfrn)) AndAlso num <> 0S
					If Operators.CompareString(Strings.Trim(sDBKey), Strings.Trim(dbitemRec.sKey), False) < 0 Then
						num = dbitemRec.nLeft
					Else
						If Operators.CompareString(Strings.Trim(sDBKey), Strings.Trim(dbitemRec.sKey), False) <= 0 Then
							Value = dbitemRec.Value
							Exit While
						End If
						num = dbitemRec.nRight
					End If
					Try
						Dim nDBfrn2 As Integer = CInt(COSTDB.nDBfrn)
						valueType = dbitemRec
						FileSystem.FileGet(nDBfrn2, valueType, CLng(num))
						Dim valueType3 As ValueType = valueType
						dbitemRec = If((valueType3 IsNot Nothing), CType(valueType3, COSTDB.DBItemRec), dbitemRec2)
					Catch ex As Exception
					End Try
				End While
				If Operators.CompareString(Strings.Trim(sDBKey), Strings.Trim(dbitemRec.sKey), False) = 0 Then
					Value = dbitemRec.Value
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub DBVisit()
			COSTDB.DBOpen("")
			Dim num As Short = 0S
			Dim num2 As Short = 20S
			Dim array As Short() = New Short(CInt((num2 - 1S + 1S)) - 1) {}
			Dim num3 As Short = COSTDB.DBHead.nHead
			If num3 = 0S Then
				Return
			End If
			Dim dbitemRec As COSTDB.DBItemRec
			Dim valueType As ValueType
			Dim dbitemRec2 As COSTDB.DBItemRec
			While True
				Dim nDBfrn As Integer = CInt(COSTDB.nDBfrn)
				valueType = dbitemRec
				FileSystem.FileGet(nDBfrn, valueType, CLng(num3))
				Dim valueType2 As ValueType = valueType
				dbitemRec = If((valueType2 IsNot Nothing), CType(valueType2, COSTDB.DBItemRec), dbitemRec2)
				If dbitemRec.nLeft = 0S Then
					Exit For
				End If
				If num >= num2 Then
					num2 += 20S
					array = CType(Utils.CopyArray(CType(array, Array), New Short(CInt((num2 + 1S)) - 1) {}), Short())
				End If
				array(CInt(num)) = num3
				num += 1S
				num3 = dbitemRec.nLeft
			End While
			Dim num4 As Short = num3
			Dim nDBfrn2 As Integer = CInt(COSTDB.nDBfrn)
			Dim dbitemRec3 As COSTDB.DBItemRec
			valueType = dbitemRec3
			FileSystem.FileGet(nDBfrn2, valueType, CLng(num4))
			Dim valueType3 As ValueType = valueType
			dbitemRec3 = If((valueType3 IsNot Nothing), CType(valueType3, COSTDB.DBItemRec), dbitemRec2)
			While num4 <> 0S
				If num = 0S Then
					num4 = 0S
				Else
					num -= 1S
					num4 = array(CInt(num))
					Dim nDBfrn3 As Integer = CInt(COSTDB.nDBfrn)
					valueType = dbitemRec3
					FileSystem.FileGet(nDBfrn3, valueType, CLng(num4))
					Dim valueType4 As ValueType = valueType
					dbitemRec3 = If((valueType4 IsNot Nothing), CType(valueType4, COSTDB.DBItemRec), dbitemRec2)
					num3 = dbitemRec3.nRight
					While num3 <> 0S
						If num >= num2 Then
							num2 += 20S
							array = CType(Utils.CopyArray(CType(array, Array), New Short(CInt((num2 + 1S)) - 1) {}), Short())
						End If
						array(CInt(num)) = num3
						num += 1S
						num3 = dbitemRec.nLeft
					End While
				End If
			End While
			COSTDB.DBClose()
		End Sub

		Public Sub MakeRGKey(iGrade As Short, sRodType As String, diam As Single, ByRef sKey As String)
			If iGrade = 4096S Then
				sKey = "RG/" + sRodType
			Else
				Dim str As String = "RG/"
				Dim obj As Object = iGrade
				Dim str2 As String = Util.Format(obj)
				iGrade = Conversions.ToShort(obj)
				sKey = str + str2
			End If
			Dim flag As Boolean = True
			If flag = RODUTIL.IsRibbonRod(iGrade) Then
				sKey += "/212"
				Return
			End If
			If flag = RODUTIL.IsCorodH(iGrade) Then
				Dim num As Double = 3.141592653589793 * Math.Pow(CDbl(diam), 2.0) / 4.0
				If num < 0.7 Then
					sKey += "/682"
					Return
				End If
				sKey += "/757"
				Return
			Else
				If flag = RODUTIL.IsCorodSE(iGrade) Then
					sKey = sKey + "/" + Strings.Trim(Conversion.Str(Conversion.Int(diam * 16F) - 10F))
					Return
				End If
				sKey = sKey + "/" + Strings.Trim(Conversion.Str(diam))
				Return
			End If
		End Sub

		Private Function AllocNewRecord() As Short
			' The following expression was wrapped in a checked-expression
			COSTDB.DBHead.nRecords = COSTDB.DBHead.nRecords + 1S
			FileSystem.FilePut(CInt(COSTDB.nDBfrn), COSTDB.DBHead, 1L)
			Return COSTDB.DBHead.nRecords
		End Function

		Public Sub DBClose()
			Try
				FileSystem.FileClose(New Integer() { CInt(COSTDB.nDBfrn) })
			Catch ex As Exception
			End Try
		End Sub

		Private Sub DBOpen(Optional sDBPath As String = "")
			Try
				If COSTDB.nDBfrn > 0S Then
					Try
						COSTDB.DBClose()
						COSTDB.nDBfrn = 0S
					Catch ex As Exception
						COSTDB.nDBfrn = 0S
					End Try
				End If
				Dim obj As Object
				If Operators.CompareString(sDBPath, "", False) = 0 Then
					Dim sFileTitle As String = "RODSTAR.CDB"
					FILEUTIL.LocateFile(sFileTitle, sDBPath, 9S, False, False, False, False)
					obj = FILEUTIL.FileExists(sDBPath)
				End If
				COSTDB.nDBfrn = CShort(FileSystem.FreeFile())
				Try
					FileSystem.FileOpen(CInt(COSTDB.nDBfrn), sDBPath, OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockWrite, Strings.Len(COSTDB.DBHead))
				Catch ex2 As Exception
				End Try
				If Conversions.ToBoolean(obj) Then
					Dim nDBfrn As Integer = CInt(COSTDB.nDBfrn)
					Dim valueType As ValueType = COSTDB.DBHead
					FileSystem.FileGet(nDBfrn, valueType, 1L)
					Dim valueType2 As ValueType = valueType
					Dim dbheadRec As COSTDB.DBHeadRec
					COSTDB.DBHead = If((valueType2 IsNot Nothing), CType(valueType2, COSTDB.DBHeadRec), dbheadRec)
					If COSTDB.DBHead.nVersion < 2S Then
						Util.BusyCursor()
						COSTDB.DBConvert()
						Util.UnbusyCursor()
					End If
				Else
					COSTDB.DBHead.nVersion = 2S
					COSTDB.DBHead.nHead = 0S
					COSTDB.DBHead.nRecords = 1S
					COSTDB.DBHead.nFirstDel = 0S
					COSTDB.DBHead.sFluff = New String(vbNullChar, Strings.Len(COSTDB.DBHead.sFluff))
					FileSystem.FilePut(CInt(COSTDB.nDBfrn), COSTDB.DBHead, 1L)
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub DBCleanup()
			Dim sFileTitle As String = "RODSTAR.CDB"
			Dim text As String
			FILEUTIL.LocateFile(sFileTitle, text, 9S, False, False, False, False)
			If Not FILEUTIL.FileExists(text) Then
				Return
			End If
			COSTDB.DBOpen("")
			Dim nRecords As Short = COSTDB.DBHead.nRecords
			Dim num As Short
			Dim array4 As COSTDB.DBItemRec()
			Dim array As COSTDB.DBItemRec() = New COSTDB.DBItemRec(CInt((nRecords + 1S)) - 1) {}
			num = 1S
			Dim num2 As Short = 2S
			Dim num3 As Short = nRecords
			Dim num4 As Short = num2
			While num4 <= num3
				Dim nDBfrn As Integer = CInt(COSTDB.nDBfrn)
				Dim array2 As COSTDB.DBItemRec() = array
				Dim num5 As Integer = CInt(num4)
				Dim valueType As ValueType = array2(num5)
				FileSystem.FileGet(nDBfrn, valueType, CLng(num4))
				Dim array3 As COSTDB.DBItemRec() = array
				Dim num6 As Integer = num5
				Dim valueType2 As ValueType = valueType
				Dim dbitemRec As COSTDB.DBItemRec
				array3(num6) = If((valueType2 IsNot Nothing), CType(valueType2, COSTDB.DBItemRec), dbitemRec)
				Dim dbitemRec2 As COSTDB.DBItemRec = array(CInt(num4))
				Dim text2 As String = dbitemRec2.sKey
				Dim value As Single = dbitemRec2.Value
				If Operators.CompareString(text2.Substring(0, 3), "PU/", False) = 0 Then
					Try
						value = dbitemRec2.Value
						If value > 100F Then
							num += 1S
							array4 = CType(Utils.CopyArray(CType(array4, Array), New COSTDB.DBItemRec(CInt((num + 1S)) - 1) {}), COSTDB.DBItemRec())
							array4(CInt(num)) = dbitemRec2
						End If
						GoTo IL_158
					Catch ex As Exception
						GoTo IL_158
					End Try
					GoTo IL_126
				End If
				GoTo IL_126
				IL_158:

					num4 += 1S
					Continue While
					IL_126:

				num += 1S
				array4 = CType(Utils.CopyArray(CType(array4, Array), New COSTDB.DBItemRec(CInt((num + 1S)) - 1) {}), COSTDB.DBItemRec())
				array4(CInt(num)) = dbitemRec2
				GoTo IL_158
			End While
			COSTDB.DBClose()
			COSTDB.nDBfrn = 0S
			If num > 2S Then
				Try
					Dim pathName As String = text.Replace("RODSTAR.CDB", "RSCDB.BKP")
					If FILEUTIL.FileExists(pathName) Then
						FileSystem.Kill(pathName)
					End If
					FileSystem.Rename(text, "RSCDB.BKP")
				Catch ex2 As Exception
				End Try
				COSTDB.DBOpen(text)
				Dim num7 As Short = 2S
				Dim num8 As Short = num
				For num4 As Short = num7 To num8
					Dim text2 As String = Strings.Trim(array4(CInt(num4)).sKey)
					COSTDB.DBInsert(text2, Conversions.ToString(array4(CInt(num4)).Value))
				Next
				COSTDB.DBClose()
				Return
			End If
		End Sub

		Private Const CDBVersion As Short = 2S

		Private m_nDBfrn As Short

		Private DBHead As COSTDB.DBHeadRec

		Private Structure DBHeadRec
			Public nVersion As Short

			Public nHead As Short

			Public nRecords As Short

			Public nFirstDel As Short

			<VBFixedString(24)>
			<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 24)>
			Public sFluff As String
		End Structure

		Private Structure DBItemRec
			<VBFixedString(24)>
			<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 24)>
			Public sKey As String

			Public Value As Single

			Public nLeft As Short

			Public nRight As Short
		End Structure
	End Module
End Namespace
