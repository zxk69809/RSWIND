Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module Custom
		Public Sub DBClose()
			Try
				Custom.myCustom.CloseDB()
				Custom.bDBOpened = False
			Catch ex As Exception
			End Try
		End Sub

		Public Sub DBOpen(Optional bForceDBLocation As Boolean = False, Optional sDBFilename As String = "")
			If bForceDBLocation And Operators.CompareString(sDBFilename.Trim(), "", False) <> 0 Then
				Custom.DataBaseFileName = sDBFilename
				Try
					Custom.myCustom = New cCustom(Custom.DataBaseFileName)
					Custom.bDBOpened = True
					Return
				Catch ex As Exception
					Dim message As String = ex.Message
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(message, sMsgType, bClosing, dialogResult)
					Return
				End Try
			End If
			If Not(Strings.Len(Custom.DataBaseFileName) = 0 Or Not Custom.bDBOpened) Then
				Return
			End If
			Try
				FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), Custom.DataBaseFileName, 2S, False, False, False, False)
				Custom.myCustom = New cCustom(Custom.DataBaseFileName)
				Custom.bDBOpened = True
			Catch ex2 As Exception
				Dim message2 As String = ex2.Message
				Dim sMsgType2 As String = ""
				Dim bClosing2 As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(message2, sMsgType2, bClosing2, dialogResult)
			End Try
		End Sub

		Public Sub LoadCustomRodGradeList(ByRef CustomRodGradeList As RSWIN_DESC.CustomRodGrade(), Optional bForceDBLocation As Boolean = False, Optional sDBFilename As String = "")
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
			Try
				If bForceDBLocation And Operators.CompareString(sDBFilename.Trim(), "", False) <> 0 Then
					Custom.DataBaseFileName = sDBFilename
					Custom.DBOpen(bForceDBLocation, sDBFilename)
				Else
					Try
						FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), Custom.DataBaseFileName, 2S, False, False, False, False)
						Custom.DBOpen(False, "")
					Catch ex As Exception
						Dim message As String = ex.Message
						Dim sMsgType As String = ""
						Dim bClosing As Boolean = False
						Dim dialogResult As DialogResult = DialogResult.OK
						Util.SendMessage(message, sMsgType, bClosing, dialogResult)
					End Try
				End If
				Dim customRodGradesTable As DataTable = Custom.myCustom.CustomRodGradesTable
				CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(customRodGradesTable.Rows.Count + 1 - 1) {}
				Dim num As Integer = 0
				Try
					For Each obj As Object In customRodGradesTable.Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						num += 1
						Custom.sName = Conversions.ToString(dataRow("RodType"))
						Custom.bSteel = Conversions.ToBoolean(dataRow("Steel"))
						Custom.fTensileStrength = Conversions.ToSingle(dataRow("TensileStrength"))
						Custom.fElasticity = Conversions.ToSingle(dataRow("Elasticity"))
						Custom.fRodWeight = Conversions.ToSingle(dataRow("RodWeight"))
						Custom.fStressMethod = Conversions.ToSingle(dataRow("StressMethod"))
						Custom.bSinkerBar = Conversions.ToBoolean(dataRow("SinkerBar"))
						CustomRodGradeList(num).RodType = Custom.sName
						CustomRodGradeList(num).Steel = If(-If((Custom.bSteel > False), 1S, 0S), 1S, 0S)
						CustomRodGradeList(num).TensileStrength = Custom.fTensileStrength
						CustomRodGradeList(num).Elasticity = Custom.fElasticity
						CustomRodGradeList(num).RodWeight = Custom.fRodWeight
						CustomRodGradeList(num).StressMethod = CShort(Math.Round(CDbl(Custom.fStressMethod)))
						CustomRodGradeList(num).SinkerBar = If(-If((Custom.bSinkerBar > False), 1S, 0S), 1S, 0S)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Try
					Custom.DBClose()
				Catch ex2 As Exception
				End Try
			Catch ex3 As Exception
			End Try
		End Sub

		Public Function CustomRodGrades_DBUpdateRow(ByRef NewRodGrade As RSWIN_DESC.CustomRodGrade, sOldRodType As String, Optional bForceDBLocation As Boolean = False, Optional sDBFilename As String = "") As Integer
			If bForceDBLocation And Operators.CompareString(sDBFilename.Trim(), "", False) <> 0 Then
				Custom.DataBaseFileName = sDBFilename
			Else
				Try
					FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), Custom.DataBaseFileName, 2S, False, False, False, False)
				Catch ex As Exception
					Dim message As String = ex.Message
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(message, sMsgType, bClosing, dialogResult)
				End Try
			End If
			Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Custom.DataBaseFileName
			Dim num As Integer = 0
			Dim text As String = "CustomRodGrades"
			Dim text2 As String
			If Operators.CompareString(sOldRodType, "", False) <> 0 And Operators.CompareString(sOldRodType, NewRodGrade.RodType, False) <> 0 Then
				text2 = sOldRodType
			Else
				text2 = NewRodGrade.RodType
			End If
			Dim selectCommandText As String = String.Concat(New String() { "Select * from ", text, " where RodType=", RSWIN_DESC.sSnglQuote, text2, RSWIN_DESC.sSnglQuote })
			Dim result As Integer
			Try
				Try
					Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
					Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection)
					oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
					Dim dataSet As DataSet = New DataSet(text)
					oleDbDataAdapter.Fill(dataSet, text)
					Debug.WriteLine(dataSet.Tables(text).Rows.Count)
					If dataSet.Tables(text).Rows.Count > 0 Then
						Dim dataRow As DataRow = dataSet.Tables(text).Rows(0)
						If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dataRow("RodType"), Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), text2.Trim(), False) Then
							dataRow("RodType") = NewRodGrade.RodType
							dataRow("Steel") = NewRodGrade.Steel
							dataRow("TensileStrength") = NewRodGrade.TensileStrength
							dataRow("Elasticity") = NewRodGrade.Elasticity
							dataRow("RodWeight") = NewRodGrade.RodWeight
							dataRow("StressMethod") = NewRodGrade.StressMethod
							dataRow("SinkerBar") = NewRodGrade.SinkerBar
							Dim oleDbCommandBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(oleDbDataAdapter)
							num = oleDbDataAdapter.Update(dataSet, text)
							Try
								oleDbConnection.Close()
								Custom.bDBOpened = False
							Catch ex2 As OleDbException
							End Try
							Try
								If oleDbConnection.State = ConnectionState.Open Then
									oleDbConnection.Close()
									Custom.bDBOpened = False
								End If
							Catch ex3 As OleDbException
							End Try
						End If
						result = num
					Else
						num = 0
						result = num
					End If
				Catch ex4 As OleDbException
					MessageBox.Show(ex4.Message, "OleDb Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			Catch ex5 As Exception
			End Try
			Return result
		End Function

		Public Function CustomRodGrades_DeleteDBRow(sRodType As String) As Integer
			Try
				FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), Custom.DataBaseFileName, 2S, False, False, False, False)
			Catch ex As Exception
				Dim message As String = ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(message, sMsgType, bClosing, dialogResult)
			End Try
			Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Custom.DataBaseFileName
			Dim text As String = "CustomRodGrades"
			Dim cmdText As String = String.Concat(New String() { "Delete from ", text, " where RodType='", sRodType, "'" })
			Dim selectCommandText As String = String.Concat(New String() { "Select * from ", text, " where RodType='", sRodType, "'" })
			Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
			Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection)
			oleDbDataAdapter.DeleteCommand = New OleDbCommand(cmdText, oleDbConnection)
			oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
			Dim dataSet As DataSet = New DataSet(text)
			oleDbDataAdapter.Fill(dataSet, text)
			Dim count As Integer = dataSet.Tables(0).Rows.Count
			Try
				If count > 0 Then
					dataSet.Tables(0).Rows(0).Delete()
					oleDbDataAdapter.Update(dataSet, text)
					Dim obj As Object = dataSet.Tables(0).Rows.Count
				End If
			Catch ex2 As Exception
			End Try
			Try
				oleDbConnection.Close()
				Custom.bDBOpened = False
			Catch ex3 As OleDbException
			End Try
			Try
				If oleDbConnection.State = ConnectionState.Open Then
					oleDbConnection.Close()
					Custom.bDBOpened = False
				End If
			Catch ex4 As OleDbException
			End Try
			Return count
		End Function

		Public Function CustomPumpingUnitLists_DeleteDBRow(sManufacturer As String) As Integer
			Try
				FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), Custom.DataBaseFileName, 2S, False, False, False, False)
			Catch ex As Exception
				Dim message As String = ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(message, sMsgType, bClosing, dialogResult)
			End Try
			Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Custom.DataBaseFileName
			Dim text As String = "CustomPumpingUnitLists"
			Dim cmdText As String = String.Concat(New String() { "Delete from ", text, " where Manufacturer='", sManufacturer.Trim(), "'" })
			Dim selectCommandText As String = String.Concat(New String() { "Select * from ", text, " where Manufacturer='", sManufacturer.Trim(), "'" })
			Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
			Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection)
			oleDbDataAdapter.DeleteCommand = New OleDbCommand(cmdText, oleDbConnection)
			oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
			Dim dataSet As DataSet = New DataSet(text)
			oleDbDataAdapter.Fill(dataSet, text)
			Dim count As Integer = dataSet.Tables(0).Rows.Count
			Try
				If count > 0 Then
					dataSet.Tables(0).Rows(0).Delete()
					oleDbDataAdapter.Update(dataSet, text)
					Dim obj As Object = dataSet.Tables(0).Rows.Count
				End If
			Catch ex2 As Exception
			End Try
			Try
				oleDbConnection.Close()
				Custom.bDBOpened = False
			Catch ex3 As OleDbException
			End Try
			Try
				If oleDbConnection.State = ConnectionState.Open Then
					oleDbConnection.Close()
					Custom.bDBOpened = False
				End If
			Catch ex4 As OleDbException
			End Try
			Return count
		End Function

		Public Sub CustomRodGrades_DBAddRow(ByRef NewRodGrade As RSWIN_DESC.CustomRodGrade, Optional bForceDBLocation As Boolean = False, Optional sDBFilename As String = "")
			If bForceDBLocation And Operators.CompareString(sDBFilename.Trim(), "", False) <> 0 Then
				Custom.DataBaseFileName = sDBFilename
			Else
				Try
					FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), Custom.DataBaseFileName, 2S, False, False, False, False)
				Catch ex As Exception
					Dim message As String = ex.Message
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(message, sMsgType, bClosing, dialogResult)
				End Try
			End If
			Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Custom.DataBaseFileName
			Dim text As String = "CustomRodGrades"
			Dim selectCommandText As String = "Select * from " + text
			Try
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection)
				oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
				Dim dataSet As DataSet = New DataSet(text)
				Try
					oleDbDataAdapter.Fill(dataSet, text)
				Catch ex2 As OleDbException
				End Try
				Dim count As Integer
				Try
					count = dataSet.Tables(0).Rows.Count
				Catch ex3 As OleDbException
				End Try
				Dim dataRow As DataRow = dataSet.Tables(0).NewRow()
				Try
					dataRow("RodType") = NewRodGrade.RodType
					dataRow("Steel") = NewRodGrade.Steel
					dataRow("TensileStrength") = NewRodGrade.TensileStrength
					dataRow("Elasticity") = NewRodGrade.Elasticity
					dataRow("RodWeight") = NewRodGrade.RodWeight
					dataRow("StressMethod") = NewRodGrade.StressMethod
					dataRow("SinkerBar") = NewRodGrade.SinkerBar
				Catch ex4 As Exception
					MessageBox.Show(ex4.Message)
				End Try
				Try
					Try
						dataSet.Tables(0).Rows.Add(dataRow)
					Catch ex5 As OleDbException
						MessageBox.Show(ex5.Message)
					End Try
				Catch ex6 As Exception
					MessageBox.Show(ex6.Message)
				End Try
				Dim oleDbCommandBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(oleDbDataAdapter)
				Try
					Dim num As Integer = oleDbDataAdapter.Update(dataSet, text)
				Catch ex7 As OleDbException
					MessageBox.Show(ex7.Message)
				End Try
				count = dataSet.Tables(0).Rows.Count
				Try
					oleDbConnection.Close()
					Custom.bDBOpened = False
				Catch ex8 As OleDbException
				End Try
				Try
					If oleDbConnection.State = ConnectionState.Open Then
						oleDbConnection.Close()
						Custom.bDBOpened = False
					End If
				Catch ex9 As OleDbException
				End Try
			Catch ex10 As OleDbException
				MessageBox.Show("Error in DBAddCustomRodGrades: " + ex10.Message)
			End Try
		End Sub

		Public Sub LoadCustomizedPumpingUnitLists(ByRef PumpUnitList As RSWIN_DESC.CustomPumpUnitList(), Optional bForceDBLocation As Boolean = False, Optional sDBFilename As String = "")
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
			Try
				If bForceDBLocation And Operators.CompareString(sDBFilename.Trim(), "", False) <> 0 Then
					Custom.DataBaseFileName = sDBFilename
					Custom.DBOpen(bForceDBLocation, sDBFilename)
				Else
					Try
						FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), Custom.DataBaseFileName, 2S, False, False, False, False)
						Custom.DBOpen(False, "")
					Catch ex As Exception
						Dim message As String = ex.Message
						Dim sMsgType As String = ""
						Dim bClosing As Boolean = False
						Dim dialogResult As DialogResult = DialogResult.OK
						Util.SendMessage(message, sMsgType, bClosing, dialogResult)
					End Try
				End If
				Dim customPumpingUnitListsTable As DataTable = Custom.myCustom.CustomPumpingUnitListsTable
				PumpUnitList = New RSWIN_DESC.CustomPumpUnitList(customPumpingUnitListsTable.Rows.Count + 1 - 1) {}
				Dim num As Integer = 0
				Try
					For Each obj As Object In customPumpingUnitListsTable.Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						num += 1
						Dim text As String = Conversions.ToString(dataRow("Manufacturer"))
						Dim text2 As String = Conversions.ToString(dataRow("Data"))
						PumpUnitList(num).Manufacturer = text.Trim()
						PumpUnitList(num).Data = text2.Trim()
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Try
					Custom.DBClose()
				Catch ex2 As Exception
				End Try
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub CustomPumpingUnitLists_DBAddRow(sManufacturer As String, sData As String, Optional bForceDBLocation As Boolean = False, Optional sDBFilename As String = "")
			If bForceDBLocation And Operators.CompareString(sDBFilename.Trim(), "", False) <> 0 Then
				Custom.DataBaseFileName = sDBFilename
			Else
				Try
					FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), Custom.DataBaseFileName, 2S, False, False, False, False)
				Catch ex As Exception
					Dim message As String = ex.Message
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(message, sMsgType, bClosing, dialogResult)
				End Try
			End If
			Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Custom.DataBaseFileName
			Dim text As String = "CustomPumpingUnitLists"
			Dim selectCommandText As String = "Select * from " + text
			Try
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection)
				oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
				Dim dataSet As DataSet = New DataSet(text)
				Try
					oleDbDataAdapter.Fill(dataSet, text)
				Catch ex2 As OleDbException
				End Try
				Dim count As Integer
				Try
					count = dataSet.Tables(0).Rows.Count
				Catch ex3 As OleDbException
				End Try
				Dim dataRow As DataRow = dataSet.Tables(0).NewRow()
				Try
					dataRow("Manufacturer") = sManufacturer.Trim()
					dataRow("Data") = sData.Trim()
				Catch ex4 As Exception
					MessageBox.Show(ex4.Message)
				End Try
				Try
					Try
						dataSet.Tables(0).Rows.Add(dataRow)
					Catch ex5 As OleDbException
						MessageBox.Show(ex5.Message)
					End Try
				Catch ex6 As Exception
					MessageBox.Show(ex6.Message)
				End Try
				Dim oleDbCommandBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(oleDbDataAdapter)
				Try
					Dim num As Integer = oleDbDataAdapter.Update(dataSet, text)
				Catch ex7 As OleDbException
					MessageBox.Show(ex7.Message)
				End Try
				count = dataSet.Tables(0).Rows.Count
				Try
					oleDbConnection.Close()
					Custom.bDBOpened = False
				Catch ex8 As OleDbException
				End Try
				Try
					oleDbConnection.Close()
					Custom.bDBOpened = False
					If oleDbConnection.State = ConnectionState.Open Then
						oleDbConnection.Close()
						Custom.bDBOpened = False
					End If
				Catch ex9 As OleDbException
				End Try
			Catch ex10 As OleDbException
				MessageBox.Show("Error in DBAddCustomPumpingUnitLists: " + ex10.Message)
			End Try
		End Sub

		Public Function CustomPumpingUnitLists_DBUpdateRow(sManufacturer As String, sData As String, Optional bForceDBLocation As Boolean = False, Optional sDBFilename As String = "") As Integer
			If bForceDBLocation And Operators.CompareString(sDBFilename.Trim(), "", False) <> 0 Then
				Custom.DataBaseFileName = sDBFilename
			Else
				Try
					FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), Custom.DataBaseFileName, 2S, False, False, False, False)
				Catch ex As Exception
					Dim message As String = ex.Message
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(message, sMsgType, bClosing, dialogResult)
				End Try
			End If
			Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Custom.DataBaseFileName
			Dim num As Integer = 0
			Dim text As String = "CustomPumpingUnitLists"
			Dim selectCommandText As String = String.Concat(New String() { "Select * from ", text, " where Manufacturer=", RSWIN_DESC.sSnglQuote, sManufacturer.Trim(), RSWIN_DESC.sSnglQuote })
			Dim result As Integer
			Try
				Try
					Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
					Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection)
					oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
					Dim dataSet As DataSet = New DataSet(text)
					oleDbDataAdapter.Fill(dataSet, text)
					Debug.WriteLine(dataSet.Tables(text).Rows.Count)
					Dim dataRow As DataRow
					If dataSet.Tables(text).Rows.Count > 0 Then
						dataRow = dataSet.Tables(text).Rows(0)
					End If
					If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dataRow("Manufacturer"), Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), sManufacturer.Trim(), False) Then
						dataRow("Manufacturer") = sManufacturer.Trim()
						dataRow("Data") = sData.Trim()
						Dim oleDbCommandBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(oleDbDataAdapter)
						num = oleDbDataAdapter.Update(dataSet, text)
						Try
							oleDbConnection.Close()
							Custom.bDBOpened = False
						Catch ex2 As OleDbException
						End Try
						Try
							If oleDbConnection.State = ConnectionState.Open Then
								oleDbConnection.Close()
								Custom.bDBOpened = False
							End If
						Catch ex3 As OleDbException
						End Try
					End If
					result = num
				Catch ex4 As OleDbException
					MessageBox.Show(ex4.Message, "OleDb Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			Catch ex5 As Exception
			End Try
			Return result
		End Function

		Public Function CustomPumpingUnitLists_SelectRow(sManufacturer As String, ByRef sData As String, Optional bForceDBLocation As Boolean = False, Optional sDBFilename As String = "") As Integer
			If bForceDBLocation And Operators.CompareString(sDBFilename.Trim(), "", False) <> 0 Then
				Custom.DataBaseFileName = sDBFilename
			Else
				Try
					FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), Custom.DataBaseFileName, 2S, False, False, False, False)
				Catch ex As Exception
					Dim message As String = ex.Message
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(message, sMsgType, bClosing, dialogResult)
				End Try
			End If
			sData = ""
			Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Custom.DataBaseFileName
			Dim num As Integer = 0
			Dim text As String = "CustomPumpingUnitLists"
			Dim selectCommandText As String = String.Concat(New String() { "Select * from ", text, " where Manufacturer=", RSWIN_DESC.sSnglQuote, sManufacturer.Trim(), RSWIN_DESC.sSnglQuote })
			Dim result As Integer
			Try
				Try
					Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
					Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection)
					oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
					Dim dataSet As DataSet = New DataSet(text)
					oleDbDataAdapter.Fill(dataSet, text)
					Dim dataRow As DataRow
					Try
						Dim count As Integer = dataSet.Tables(0).Rows.Count
						If count <= 0 Then
							Try
								oleDbConnection.Close()
								Custom.bDBOpened = False
							Catch ex2 As Exception
							End Try
							num = 0
							Return num
						End If
						dataRow = dataSet.Tables(text).Rows(0)
					Catch ex3 As OleDbException
					End Try
					sData = ""
					If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(dataRow("Manufacturer"), Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), sManufacturer.Trim(), False) Then
						sData = Conversions.ToString(dataRow("Data"))
						sData = sData.Trim()
						num = 1
					End If
					Try
						oleDbConnection.Close()
						Custom.bDBOpened = False
					Catch ex4 As OleDbException
					End Try
					Try
						If oleDbConnection.State = ConnectionState.Open Then
							oleDbConnection.Close()
							Custom.bDBOpened = False
						End If
					Catch ex5 As OleDbException
					End Try
					result = num
				Catch ex6 As OleDbException
					MessageBox.Show(ex6.Message, "OleDb Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			Catch ex7 As Exception
			End Try
			Return result
		End Function

		Public Sub InitializeCustomPumpingUnitLists()
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
			Dim array As RSWIN_DESC.UnitTypeInfo() = New RSWIN_DESC.UnitTypeInfo(CInt((num2 + 1S)) - 1) {}
			num3 = 1S
			num4 = num2
			For num5 As Short = num3 To num4
				Dim fileNumber As Integer = CInt(num)
				Dim valueType As ValueType = unitTypeInfo
				FileSystem.FileGet(fileNumber, valueType, -1L)
				Dim valueType2 As ValueType = valueType
				Dim unitTypeInfo2 As RSWIN_DESC.UnitTypeInfo
				unitTypeInfo = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.UnitTypeInfo), unitTypeInfo2)
				Dim text2 As String = Strings.Trim(unitTypeInfo.Abbrev)
				Dim text3 As String = "Custom Pumping Unit Database"
				Dim text4 As String = ""
				Dim num6 As Short = CShort(RSWIN.GetRegProfileString(text3, text2, text4, text, False))
				If num6 = 0S Then
					text2 = ""
				Else
					Debug.WriteLine(" ")
				End If
				If Strings.Len(text2) > 0 Then
					Dim text5 As String
					Dim num7 As Integer = Custom.CustomPumpingUnitLists_SelectRow(text2.Trim(), text5, False, "")
					If num7 = 0 Then
						Custom.CustomPumpingUnitLists_DBAddRow(text2, text.Substring(0, CInt(num6)), False, "")
					ElseIf num7 = 1 Then
						num6 = CShort(text5.Trim().Length)
						If num6 > 0S And text5.Length > 0 Then
							Dim text6 As String = Custom.MergeUnitLists(text.Substring(0, CInt(num6)), text5)
							text5 = text6
						End If
						Custom.CustomPumpingUnitLists_DBUpdateRow(text2.Trim(), text5, False, "")
					End If
				End If
			Next
			FileSystem.FileClose(New Integer() { CInt(num) })
		End Sub

		Public Function MergeUnitLists(sList1 As String, sList2 As String) As String
			' The following expression was wrapped in a checked-statement
			Dim result As String
			Try
				Dim array As Integer() = New Integer(0) {}
				Dim array2 As Integer() = New Integer(0) {}
				Dim array3 As Integer() = New Integer(0) {}
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				If sList1.Length > 0 Then
					sList1 = sList1.Trim()
					Dim i As Integer = 1
					Dim num4 As Integer
					Do
						Dim num3 As Integer = -1
						num4 = Strings.InStr(i, sList1, ",", CompareMethod.Binary)
						If num4 = 0 Then
							If Versioned.IsNumeric(Strings.Mid(sList1, i)) Then
								num3 = CInt(Conversions.ToShort(Strings.Mid(sList1, i)))
							End If
						ElseIf Versioned.IsNumeric(Strings.Mid(sList1, i, num4 - i)) Then
							num3 = CInt(Conversions.ToShort(Strings.Mid(sList1, i, num4 - i)))
						End If
						If num3 > 0 Then
							num += 1
							array = CType(Utils.CopyArray(CType(array, Array), New Integer(num + 1 - 1) {}), Integer())
							array(num) = num3
						End If
						i = num4 + Strings.Len(",")
					Loop While num4 <> 0
				End If
				Array.Sort(Of Integer)(array)
				array3 = New Integer(num + 1 - 1) {}
				Dim num5 As Integer = 1
				Dim num6 As Integer = num
				For i As Integer = num5 To num6
					array3(i) = array(i)
				Next
				If sList2.Length > 0 Then
					sList2 = sList2.Trim()
					Dim i As Integer = 1
					Dim num4 As Integer
					Do
						Dim num3 As Integer = -1
						num4 = Strings.InStr(i, sList2, ",", CompareMethod.Binary)
						If num4 = 0 Then
							If Versioned.IsNumeric(Strings.Mid(sList2, i)) Then
								num3 = CInt(Conversions.ToShort(Strings.Mid(sList2, i)))
							End If
						ElseIf Versioned.IsNumeric(Strings.Mid(sList2, i, num4 - i)) Then
							num3 = CInt(Conversions.ToShort(Strings.Mid(sList2, i, num4 - i)))
						End If
						If num3 > 0 Then
							num2 += 1
							array2 = CType(Utils.CopyArray(CType(array2, Array), New Integer(num2 + 1 - 1) {}), Integer())
							array2(num2) = num3
						End If
						i = num4 + Strings.Len(",")
					Loop While num4 <> 0
				End If
				Array.Sort(Of Integer)(array2)
				Dim num7 As Integer = num + num2
				array3 = CType(Utils.CopyArray(CType(array3, Array), New Integer(num7 + 1 - 1) {}), Integer())
				Dim num8 As Integer = 1
				Dim num9 As Integer = num2
				For i As Integer = num8 To num9
					array3(num + i) = array2(i)
				Next
				Array.Sort(Of Integer)(array3)
				Dim text As String = Conversions.ToString(array3(1))
				Dim num10 As Integer = 2
				Dim num11 As Integer = num7
				For i As Integer = num10 To num11
					If array3(i) <> array3(i - 1) Then
						text = text + "," + Conversions.ToString(array3(i))
					End If
				Next
				result = text
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private myCustom As cCustom

		Private DataBaseFileName As String

		Private sName As String

		Private bSteel As Boolean

		Private bSinkerBar As Boolean

		Private fTensileStrength As Single

		Private fElasticity As Single

		Private fRodWeight As Single

		Private fStressMethod As Single

		Private bDBOpened As Boolean = False
	End Module
End Namespace
