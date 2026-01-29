Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class cGuruFileData
		Public Sub New()
			Me.FiledataDataAdapter = New OleDbDataAdapter()
			If Operators.CompareString(RSWIN_DESC.GuruDataBaseFileName, RSWIN_DESC.sTemplateDBFileName, False) = 0 Then
				Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
				Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
				FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, False, False, False, False)
				RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
			End If
			Dim connectionString As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + RSWIN_DESC.GuruDataBaseFileName + ";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password=", RSWIN_DESC.GuruDatabasePassword), ";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False"))
			Try
				Me.Connection = New OleDbConnection(connectionString)
			Catch ex As Exception
				MessageBox.Show("Error in New cGuruFile: " + ex.Message)
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

		Public Sub CloseDB()
			Try
				If Me.mvarConnection.State = ConnectionState.Open Then
					Me.mvarConnection.Close()
				End If
			Catch ex As Exception
				MessageBox.Show("Problem closing db: " + ex.Message)
			End Try
		End Sub

		Private Sub GetTables()
			Dim oleDbCommand As OleDbCommand = New OleDbCommand()
			Try
				Me.mvarDataSet = New DataSet("filedata")
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
				Me.GetTable(oleDbCommand, "filedata", Me.FiledataDataAdapter)
			Catch ex2 As OleDbException
				MessageBox.Show("Problem in GetTables: " + ex2.Message)
			End Try
		End Sub

		Public Sub RunOleDbTransaction(ByRef da As OleDbDataAdapter, ds As DataSet)
			Dim oleDbCommand As OleDbCommand = New OleDbCommand()
			oleDbCommand.Connection = Me.mvarConnection
			Dim oleDbTransaction As OleDbTransaction = Me.Connection.BeginTransaction()
			oleDbCommand.Transaction = oleDbTransaction
			Try
				da.Update(ds)
				oleDbTransaction.Commit()
				Console.WriteLine("Update successful.")
			Catch ex As Exception
				Try
					oleDbTransaction.Rollback()
				Catch ex2 As OleDbException
					If oleDbTransaction.Connection IsNot Nothing Then
						Console.WriteLine("An exception of type " + ex2.[GetType]().ToString() + " was encountered while attempting to roll back the transaction.")
					End If
				End Try
				Console.WriteLine("An exception of type " + ex.[GetType]().ToString() + " was encountered.")
				Console.WriteLine("Update failed.")
			End Try
		End Sub

		Public Sub UpdateDataAdapter(ByRef ds As DataSet)
			Try
				Me.RunOleDbTransaction(Me.FiledataDataAdapter, ds)
			Catch ex As Exception
				MessageBox.Show("Problem in UpdateDataAdapter: " + ex.Message)
			End Try
		End Sub

		Private Sub GetTable(sc As OleDbCommand, TableName As String, ByRef da As OleDbDataAdapter)
			Try
				sc.CommandText = TableName
				da.SelectCommand = sc
				da.Fill(Me.mvarDataSet, TableName)
				Me.FiledataDataAdapter = da
			Catch ex As OleDbException
				MessageBox.Show("Problem in GetTable: " + ex.Message)
			End Try
		End Sub

		Public ReadOnly Property FiledataTable As DataTable
			Get
				Return Me.mvarDataSet.Tables("Filedata")
			End Get
		End Property

		Public Function FiledataDataSet() As DataSet
			Dim oleDbCommand As OleDbCommand = New OleDbCommand()
			Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter()
			Dim dataSet As DataSet = New DataSet()
			oleDbCommand.Connection = Me.mvarConnection
			If Me.mvarConnection.State = ConnectionState.Closed Then
				Me.mvarConnection.Open()
			End If
			oleDbCommand.CommandType = CommandType.TableDirect
			oleDbCommand.CommandText = "C"
			oleDbDataAdapter.SelectCommand = oleDbCommand
			Try
				oleDbDataAdapter.Fill(dataSet)
			Catch ex As OleDbException
				MessageBox.Show(ex.Message, "OleDb Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Catch ex2 As Exception
				MessageBox.Show("Unspecified error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Dim result As DataSet = dataSet
			Me.FiledataDataAdapter = oleDbDataAdapter
			Return result
		End Function

		Private mvarDataSet As DataSet

		Private mvarConnection As OleDbConnection

		Public FiledataDataAdapter As OleDbDataAdapter
	End Class
End Namespace
