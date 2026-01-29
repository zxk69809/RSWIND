Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Namespace RSWINV3
	Public Class cCustom
		Public Sub New(Optional DataBaseFileName As String = "")
			Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DataBaseFileName
			Try
				Me.Connection = New OleDbConnection(connectionString)
			Catch ex As Exception
				Dim sMsg As String = "Error in cCustom: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Property Connection As OleDbConnection
			Get
				Return Me.mvarConnection
			End Get
			Set(value As OleDbConnection)
				Me.mvarConnection = value
				Me.GetTables()
			End Set
		End Property

		Private Sub GetTables()
			Dim oleDbCommand As OleDbCommand = New OleDbCommand()
			Try
				Me.mvarDataSet = New DataSet("Custom")
				oleDbCommand.Connection = Me.mvarConnection
				Try
					If Me.mvarConnection.State <> ConnectionState.Open Then
						Me.mvarConnection.Open()
					Else
						While Me.mvarConnection.State = ConnectionState.Open
							Application.DoEvents()
						End While
						Me.mvarConnection.Open()
					End If
				Catch ex As Exception
				End Try
				oleDbCommand.CommandType = CommandType.TableDirect
				Me.GetTable(oleDbCommand, "CustomRodGrades")
				Me.GetTable(oleDbCommand, "CustomPumpingUnitLists")
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub GetTable(sc As OleDbCommand, TableName As String)
			Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter()
			sc.CommandText = TableName
			oleDbDataAdapter.SelectCommand = sc
			oleDbDataAdapter.Fill(Me.mvarDataSet, TableName)
		End Sub

		Public ReadOnly Property CustomRodGradesTable As DataTable
			Get
				Return Me.mvarDataSet.Tables("CustomRodGrades")
			End Get
		End Property

		Public ReadOnly Property CustomPumpingUnitListsTable As DataTable
			Get
				Return Me.mvarDataSet.Tables("CustomPumpingUnitLists")
			End Get
		End Property

		Public Function CustomPumpingUnitListsDataSet() As DataSet
			Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter()
			Dim oleDbCommand As OleDbCommand = New OleDbCommand()
			Dim dataSet As DataSet = New DataSet()
			oleDbCommand.Connection = Me.mvarConnection
			If Me.mvarConnection.State = ConnectionState.Closed Then
				Me.mvarConnection.Open()
			End If
			oleDbCommand.CommandType = CommandType.TableDirect
			oleDbCommand.CommandText = "CustomPumpingUnitLists"
			oleDbDataAdapter.SelectCommand = oleDbCommand
			Try
				oleDbDataAdapter.Fill(dataSet)
			Catch ex As OleDbException
				Dim message As String = ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(message, sMsgType, bClosing, dialogResult)
			Catch ex2 As Exception
				Dim sMsg As String = "Unspecified error"
				Dim sMsgType2 As String = "Error"
				Dim bClosing2 As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType2, bClosing2, dialogResult)
			End Try
			Return dataSet
		End Function

		Public Function CustomRodGradesDataSet() As DataSet
			Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter()
			Dim oleDbCommand As OleDbCommand = New OleDbCommand()
			Dim dataSet As DataSet = New DataSet()
			oleDbCommand.Connection = Me.mvarConnection
			If Me.mvarConnection.State = ConnectionState.Closed Then
				Me.mvarConnection.Open()
			End If
			oleDbCommand.CommandType = CommandType.TableDirect
			oleDbCommand.CommandText = "CustomRodGrades"
			oleDbDataAdapter.SelectCommand = oleDbCommand
			Try
				oleDbDataAdapter.Fill(dataSet)
			Catch ex As OleDbException
				Dim message As String = ex.Message
				Dim sMsgType As String = "OleDb Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(message, sMsgType, bClosing, dialogResult)
			Catch ex2 As Exception
				Dim sMsg As String = "Unspecified error"
				Dim sMsgType2 As String = "Error"
				Dim bClosing2 As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType2, bClosing2, dialogResult)
			End Try
			Return dataSet
		End Function

		Public Sub CloseDB()
			Try
				Me.mvarConnection.Close()
			Catch ex As Exception
			End Try
			Try
				Me.mvarConnection.Close()
				If Me.mvarConnection.State = ConnectionState.Open Then
					Me.mvarConnection.Close()
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private mvarDataSet As DataSet

		Private mvarConnection As OleDbConnection
	End Class
End Namespace
