Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	<DesignerGenerated()>
	Public Partial Class frmLoadGuruFNames
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmLoadGuruFilenames
			Me.InitializeComponent()
		End Sub

		Friend Overridable Property OleDbSelectCommand1 As OleDbCommand
			Get
				Return Me._OleDbSelectCommand1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OleDbCommand)
				Me._OleDbSelectCommand1 = value
			End Set
		End Property

		Friend Overridable Property OleDbInsertCommand1 As OleDbCommand
			Get
				Return Me._OleDbInsertCommand1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OleDbCommand)
				Me._OleDbInsertCommand1 = value
			End Set
		End Property

		Friend Overridable Property OleDbUpdateCommand1 As OleDbCommand
			Get
				Return Me._OleDbUpdateCommand1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OleDbCommand)
				Me._OleDbUpdateCommand1 = value
			End Set
		End Property

		Friend Overridable Property OleDbDeleteCommand1 As OleDbCommand
			Get
				Return Me._OleDbDeleteCommand1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OleDbCommand)
				Me._OleDbDeleteCommand1 = value
			End Set
		End Property

		Friend Overridable Property OleDbDataAdapter1 As OleDbDataAdapter
			Get
				Return Me._OleDbDataAdapter1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OleDbDataAdapter)
				Me._OleDbDataAdapter1 = value
			End Set
		End Property

		Friend Overridable Property OleDbConnection1 As OleDbConnection
			Get
				Return Me._OleDbConnection1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OleDbConnection)
				Me._OleDbConnection1 = value
			End Set
		End Property

		Public Overridable Property cmdOK As Button
			Get
				Return Me._cmdOK
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdOK_Click
				If Me._cmdOK IsNot Nothing Then
					RemoveHandler Me._cmdOK.Click, value2
				End If
				Me._cmdOK = value
				If Me._cmdOK IsNot Nothing Then
					AddHandler Me._cmdOK.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lboFilenames As ListBox
			Get
				Return Me._lboFilenames
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lboFilenames_DoubleClick
				Dim value3 As EventHandler = AddressOf Me.lboFilenames_SelectedIndexChanged
				If Me._lboFilenames IsNot Nothing Then
					RemoveHandler Me._lboFilenames.DoubleClick, value2
					RemoveHandler Me._lboFilenames.SelectedIndexChanged, value3
				End If
				Me._lboFilenames = value
				If Me._lboFilenames IsNot Nothing Then
					AddHandler Me._lboFilenames.DoubleClick, value2
					AddHandler Me._lboFilenames.SelectedIndexChanged, value3
				End If
			End Set
		End Property

		Public Property sFormCaption As String
			Get
				Return Me.m_sFormCaption
			End Get
			Set(value As String)
				Me.m_sFormCaption = value
				Me.Text = value
			End Set
		End Property

		Private Sub frmLoadGuruFilenames(sender As Object, e As EventArgs)
			Try
				RSWIN_DESC.sGuruFilenameKey = ""
				Me.LoadCombobox()
			Catch ex As Exception
			End Try
		End Sub

		Public Sub LoadCombobox()
			Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
			Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
			FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, False, False, False, False)
			RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
			Dim num As Integer = 0
			Me.myFile = New cGuruFileData()
			Dim filedataTable As DataTable = Me.myFile.FiledataTable
			Dim filedataDataAdapter As OleDbDataAdapter = Me.myFile.FiledataDataAdapter
			Me.lboFilenames.Items.Clear()
			Try
				For Each obj As Object In filedataTable.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					num += 1
					Me.lboFilenames.Items.Add(RuntimeHelpers.GetObjectValue(dataRow("FileName")))
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.lboFilenames.Sorted = True
		End Sub

		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub lboFilenames_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.lboFilenames.SelectedIndex <> -1 Then
				RSWIN_DESC.sGuruFilenameKey = Conversions.ToString(Me.lboFilenames.SelectedItem)
				Return
			End If
		End Sub

		Private Sub cmdOK_Click(sender As Object, e As EventArgs)
			If Me.lboFilenames.SelectedIndex <> -1 Then
				RSWIN_DESC.sGuruFilenameKey = Conversions.ToString(Me.lboFilenames.SelectedItem)
			End If
			Me.Hide()
		End Sub

		Private Sub lboFilenames_DoubleClick(sender As Object, e As EventArgs)
			If Me.lboFilenames.SelectedIndex <> -1 Then
				RSWIN_DESC.sGuruFilenameKey = Conversions.ToString(Me.lboFilenames.SelectedItem)
			End If
			Me.Hide()
		End Sub

		<AccessedThroughProperty("OleDbSelectCommand1")>
		Private _OleDbSelectCommand1 As OleDbCommand

		<AccessedThroughProperty("OleDbInsertCommand1")>
		Private _OleDbInsertCommand1 As OleDbCommand

		<AccessedThroughProperty("OleDbUpdateCommand1")>
		Private _OleDbUpdateCommand1 As OleDbCommand

		<AccessedThroughProperty("OleDbDeleteCommand1")>
		Private _OleDbDeleteCommand1 As OleDbCommand

		<AccessedThroughProperty("OleDbDataAdapter1")>
		Private _OleDbDataAdapter1 As OleDbDataAdapter

		<AccessedThroughProperty("OleDbConnection1")>
		Private _OleDbConnection1 As OleDbConnection

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("lboFilenames")>
		Private _lboFilenames As ListBox

		Private bRetVal As Boolean

		Private strConn As String

		Private iRecsUpdate As Integer

		Private TableName As String

		Private strSelectCmd As String

		Private dtSet As DataSet

		Private myFile As cGuruFileData

		Private m_sFormCaption As String
	End Class
End Namespace
