Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class BatchLog
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Closed, AddressOf Me.BatchLog_Closed
			AddHandler MyBase.LocationChanged, AddressOf Me.BatchLog_LocationChanged
			AddHandler MyBase.Leave, AddressOf Me.BatchLog_Leave
			AddHandler MyBase.VisibleChanged, AddressOf Me.BatchLog_VisibleChanged
			AddHandler MyBase.Resize, AddressOf Me.BatchLog_Resize
			AddHandler MyBase.Enter, AddressOf Me.BatchLog_Enter
			AddHandler MyBase.Activated, AddressOf Me.BatchLog_Activated
			AddHandler MyBase.Closing, AddressOf Me.BatchLog_Closing
			AddHandler MyBase.FormClosing, AddressOf Me.BatchLog_FormClosing
			AddHandler MyBase.Load, AddressOf Me.BatchLog_Load
			Me.sLogEntry = "LogEntry"
			Me.m_bDisplayBatchOutput = False
			Me.sTOTALSCORE = Util.AssignValueToConstant("rptExpertSummary", "sTOTALSCORE", "TOTAL SCORE: ")
			Me.sGrade = Util.AssignValueToConstant("rptExpertSummary", "sGrade", "  Grade: ")
			Me.bDescending = False
			Me.sSaveItm = ""
			If BatchLog.m_vb6FormDefInstance Is Nothing Then
				If BatchLog.m_InitializingDefInstance Then
					BatchLog.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							BatchLog.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
			Me.Text = "Batch Run Log"
		End Sub

		Public Overridable Property cmdCancel As Button
			Get
				Return Me._cmdCancel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdCancel_Click
				If Me._cmdCancel IsNot Nothing Then
					RemoveHandler Me._cmdCancel.Click, value2
				End If
				Me._cmdCancel = value
				If Me._cmdCancel IsNot Nothing Then
					AddHandler Me._cmdCancel.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property Label As LabelArray
			Get
				Return Me._Label
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._Label = value
			End Set
		End Property

		Public Overridable Property SSPanel As PanelArray
			Get
				Return Me._SSPanel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PanelArray)
				Me._SSPanel = value
			End Set
		End Property

		Friend Overridable Property prgPercentComplete As ProgressBar
			Get
				Return Me._prgPercentComplete
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._prgPercentComplete = value
			End Set
		End Property

		Friend Overridable Property Panel1 As Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
			End Set
		End Property

		Public Overridable Property lblFilesComplete As Label
			Get
				Return Me._lblFilesComplete
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFilesComplete = value
			End Set
		End Property

		Public Overridable Property c As Label
			Get
				Return Me._c
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._c = value
			End Set
		End Property

		Public Overridable Property _Label_1 As Label
			Get
				Return Me.__Label_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_1 = value
			End Set
		End Property

		Public Overridable Property _Label_0 As Label
			Get
				Return Me.__Label_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_0 = value
			End Set
		End Property

		Friend Overridable Property lblCompleted As Label
			Get
				Return Me._lblCompleted
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.Label2_Click
				If Me._lblCompleted IsNot Nothing Then
					RemoveHandler Me._lblCompleted.Click, value2
				End If
				Me._lblCompleted = value
				If Me._lblCompleted IsNot Nothing Then
					AddHandler Me._lblCompleted.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property btnSort As Button
			Get
				Return Me._btnSort
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnSort_Click
				If Me._btnSort IsNot Nothing Then
					RemoveHandler Me._btnSort.Click, value2
				End If
				Me._btnSort = value
				If Me._btnSort IsNot Nothing Then
					AddHandler Me._btnSort.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property btnAcceptGuruRun As Button
			Get
				Return Me._btnAcceptGuruRun
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAcceptGuruRun_Click
				If Me._btnAcceptGuruRun IsNot Nothing Then
					RemoveHandler Me._btnAcceptGuruRun.Click, value2
				End If
				Me._btnAcceptGuruRun = value
				If Me._btnAcceptGuruRun IsNot Nothing Then
					AddHandler Me._btnAcceptGuruRun.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property btnAcceptAllGuruRun As Button
			Get
				Return Me._btnAcceptAllGuruRun
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAcceptAllGuruRun_Click
				If Me._btnAcceptAllGuruRun IsNot Nothing Then
					RemoveHandler Me._btnAcceptAllGuruRun.Click, value2
				End If
				Me._btnAcceptAllGuruRun = value
				If Me._btnAcceptAllGuruRun IsNot Nothing Then
					AddHandler Me._btnAcceptAllGuruRun.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlBatchLog As Panel
			Get
				Return Me._pnlBatchLog
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlBatchLog = value
			End Set
		End Property

		Public Overridable Property ulgBatchLog As UltraGrid
			Get
				Return Me._ulgBatchLog
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventHandler = AddressOf Me.ulgBatchLog_BeforeExitEditMode
				Dim value3 As DoubleClickCellEventHandler = AddressOf Me.ulgBatchLog_DoubleClickCell
				Dim value4 As CancelEventHandler = AddressOf Me.ulgBatchLog_BeforeEnterEditMode
				Dim value5 As InitializeLayoutEventHandler = AddressOf Me.ulgBatchLog_InitializeLayout
				Dim value6 As KeyPressEventHandler = AddressOf Me.ulgBatchLog_KeyPress
				Dim value7 As RowEventHandler = AddressOf Me.ulgBatchLog_AfterRowInsert
				If Me._ulgBatchLog IsNot Nothing Then
					RemoveHandler Me._ulgBatchLog.BeforeExitEditMode, value2
					RemoveHandler Me._ulgBatchLog.DoubleClickCell, value3
					RemoveHandler Me._ulgBatchLog.BeforeEnterEditMode, value4
					RemoveHandler Me._ulgBatchLog.InitializeLayout, value5
					RemoveHandler Me._ulgBatchLog.KeyPress, value6
					RemoveHandler Me._ulgBatchLog.AfterRowInsert, value7
				End If
				Me._ulgBatchLog = value
				If Me._ulgBatchLog IsNot Nothing Then
					AddHandler Me._ulgBatchLog.BeforeExitEditMode, value2
					AddHandler Me._ulgBatchLog.DoubleClickCell, value3
					AddHandler Me._ulgBatchLog.BeforeEnterEditMode, value4
					AddHandler Me._ulgBatchLog.InitializeLayout, value5
					AddHandler Me._ulgBatchLog.KeyPress, value6
					AddHandler Me._ulgBatchLog.AfterRowInsert, value7
				End If
			End Set
		End Property

		Friend Overridable Property lblStatus As Label
			Get
				Return Me._lblStatus
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.lblStatus_TextChanged
				If Me._lblStatus IsNot Nothing Then
					RemoveHandler Me._lblStatus.TextChanged, value2
				End If
				Me._lblStatus = value
				If Me._lblStatus IsNot Nothing Then
					AddHandler Me._lblStatus.TextChanged, value2
				End If
			End Set
		End Property

		Public Shared Property DefInstance As BatchLog
			Get
				If BatchLog.m_vb6FormDefInstance Is Nothing OrElse BatchLog.m_vb6FormDefInstance.IsDisposed Then
					BatchLog.m_InitializingDefInstance = True
					BatchLog.m_vb6FormDefInstance = New BatchLog()
					BatchLog.m_InitializingDefInstance = False
				End If
				Return BatchLog.m_vb6FormDefInstance
			End Get
			Set(value As BatchLog)
				BatchLog.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property bDisplayBatchOutput As Boolean
			Get
				Return Me.m_bDisplayBatchOutput
			End Get
			Set(value As Boolean)
				Me.m_bDisplayBatchOutput = value
				RSWIN_DESC.bDisplayingBatchOutput = value
			End Set
		End Property

		Public Property sBatchFileName As String
			Get
				Return Me.m_sBatchFileName
			End Get
			Set(value As String)
				Me.m_sBatchFileName = value
			End Set
		End Property

		Public Property UpdatePercent As Single
			Get
				Return Me.m_UpdatePercent
			End Get
			Set(value As Single)
				Me.m_UpdatePercent = value
				While CSng(Me.prgPercentComplete.Value) < value
					Me.prgPercentComplete.PerformStep()
				End While
				Me.prgPercentComplete.Refresh()
			End Set
		End Property

		Public Sub SetTopMost(bVal As Boolean)
			Me.TopMost = bVal
		End Sub

		Public Property FilesSelected As String
			Get
				Return Me.m_FilesSelected
			End Get
			Set(value As String)
				Me.m_FilesSelected = value
				Me.c.Text = value
			End Set
		End Property

		Public Property cmdCancelText As String
			Get
				Return Me.m_cmdCancelText
			End Get
			Set(value As String)
				Me.m_cmdCancelText = value
				Me.cmdCancel.Text = value
			End Set
		End Property

		Public Property FilesComplete As String
			Get
				Return Me.m_FilesComplete
			End Get
			Set(value As String)
				Me.m_FilesComplete = value
				Me.lblFilesComplete.Text = value
			End Set
		End Property

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			If Operators.CompareString(Me.cmdCancel.Text, "Cancel", False) = 0 Then
				Me.Tag = "Cancel"
			Else
				Me.Tag = "Close"
			End If
			If Not RSWIN_DESC.rst.gbAutomatic Then
				Me.TopMost = False
			End If
			RSWIN_DESC.rst.gbAutomatic = False
			RSWIN_DESC.rst.gbBatch = False
			Me.bDisplayBatchOutput = False
			Me.m_sBatchFileName = ""
			RSWIN_DESC.bRunGuru = False
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				Dim rodstar As RODSTAR = CType(Me.ParentForm, RODSTAR)
				If Operators.ConditionalCompareObjectEqual(Me.Tag, "Close", False) Then
					If rodstar.btnGuru.Visible Then
						rodstar.btnGuru.BringToFront()
					End If
					rodstar.lblGURU.BackColor = Color.LightGray
					If rodstar.btnGuru.Visible Then
						rodstar.StopAIAni()
						rodstar.btnGuru.BringToFront()
					End If
					If RSWIN_DESC.rst_save IsNot Nothing Then
						rodstar.ReloadAIRunInputs()
					End If
					rodstar.ToolbarButtonSetState2(2, False)
				End If
			End If
			If Operators.ConditionalCompareObjectEqual(Me.Tag, "Close", False) Then
				Me.Close()
				Return
			End If
		End Sub

		Public Sub Initialize()
			Me.prgPercentComplete.Value = 0
			Me.prgPercentComplete.Text = "0%"
			Me.UpdateProgress()
			Me.lblFilesComplete.Text = "0"
		End Sub

		Private Sub BatchLog_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.bDisplayBatchOutput = False
		End Sub

		Private Sub BatchLog_Load(eventSender As Object, eventArgs As EventArgs)
			SUPERPRO.NewCheckSentinel(True)
			RSWIN.GetMeasurementUnit()
			Me.ResetClock()
			Me.btnSort.Enabled = True
			Me.Left = CInt(Math.Round(CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0))
			Me.Height = Me.ParentForm.Height - 170
			Dim num As Integer = RSWIN_DESC.frmMain.Height - Me.Height
			Dim num2 As Integer = RSWIN_DESC.frmMain.Width - Me.Width
			Me.Top = 10
			Me.bDisplayBatchOutput = False
			Me.btnAcceptGuruRun.Visible = False
			Me.btnAcceptGuruRun.Enabled = False
			Me.btnAcceptAllGuruRun.Visible = False
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				Me.Text = "AI Mode Batch Run Log"
				Me._Label_0.Text = "Number of Files:"
			Else
				Me.Text = "Batch Run Log"
				Me._Label_0.Text = "Files selected:"
			End If
			Me.lblStatus.Text = ""
			Me.InitBatchLogDataset(Me.mdsBatchLog)
			Me.Initialize()
			Me.Tag = ""
			If RSWIN_DESC.bIntVersion And RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private Sub BatchLog_Closed(eventSender As Object, eventArgs As EventArgs)
			RSWIN.CheckLoadedForms()
			RSWIN_DESC.rst.gbBatch = False
			If Operators.ConditionalCompareObjectEqual(Me.Tag, "", False) Then
				Me.Tag = "Close"
				Return
			End If
		End Sub

		Public Sub SetAsideDYNFile(sDYNFile As String)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = sDYNFile.Substring(0, Strings.Len(sDYNFile) - 1) + "E"
				IL_24:
				num2 = 3
				FileSystem.Kill(text)
				IL_2D:
				num2 = 4
				Information.Err().Number = 0
				IL_3B:
				num2 = 5
				FileSystem.Rename(sDYNFile, text)
				IL_45:
				num2 = 6
				If Information.Err().Number = 0 Then
					GoTo IL_A4
				End If
				IL_55:
				num2 = 7
				Batch.BatchMessage(String.Concat(New String() { "Error ", Conversions.ToString(Information.Err().Number), " renaming <", sDYNFile, "> to <", text, ">." }))
				IL_A4:
				ProjectData.ClearProjectError()
				num = 0
				IL_AB:
				GoTo IL_123
				IL_AD:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_E3:
				GoTo IL_118
				IL_E5:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_F6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_E5
			End Try
			IL_118:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_123:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub RefreshPercentComplete()
			Me.prgPercentComplete.Refresh()
		End Sub

		Public Sub AddListItem(sMsg As String)
			Me.AddBatchlogEntry(sMsg)
		End Sub

		Public Sub UpdateProgress()
			Me.lblCompleted.Text = Conversions.ToString(Decimal.Truncate(New Decimal(Me.m_UpdatePercent))) + "%"
			Me.prgPercentComplete.Refresh()
			Application.DoEvents()
		End Sub

		Private Sub Label2_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub BatchLog_Leave(sender As Object, e As EventArgs)
		End Sub

		Private Sub BatchLog_Resize(sender As Object, e As EventArgs)
			Dim point As Point = New Point(0, 0)
			Dim obj As Object = point
			Me.Left = CInt(Math.Round(CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0))
			Me.ulgBatchLog.Height = Me.Height - Me.lblStatus.Height - 80
			Me.pnlBatchLog.Height = Me.ulgBatchLog.Height
			Me.Top = 10
			If Screen.PrimaryScreen.Bounds.Height < 700 Or Screen.PrimaryScreen.Bounds.Width < 1000 Then
				Me.AutoScroll = True
				Dim obj2 As Object = obj
				Dim point2 As Point
				Me.AutoScrollPosition = If((obj2 IsNot Nothing), CType(obj2, Point), point2)
				Me.pnlBatchLog.AutoScroll = True
				Dim pnlBatchLog As ScrollableControl = Me.pnlBatchLog
				Dim obj3 As Object = obj
				pnlBatchLog.AutoScrollPosition = If((obj3 IsNot Nothing), CType(obj3, Point), point2)
				If Screen.PrimaryScreen.Bounds.Width < Me.Width Then
					Me.Left = 2
					Me.Top = 2
					Me.Width = CInt(Math.Round(CDbl(RSWIN_DESC.frmMain.Width) * 0.925))
					Me.prgPercentComplete.Width = Me.prgPercentComplete.Width - 90
					Me.lblCompleted.Width = Me.prgPercentComplete.Width
					Me.ulgBatchLog.Width = Me.Width - 40
					Me.pnlBatchLog.Width = Me.ulgBatchLog.Width
					Me.pnlBatchLog.Left = 8
					Me.pnlBatchLog.Top = 64
					Me.ulgBatchLog.Left = 0
					Me.ulgBatchLog.Top = 0
					Me.cmdCancel.Left = Me.lblCompleted.Left + Me.lblCompleted.Width + 5
					Me.btnSort.Left = Me.cmdCancel.Left
					Me.btnAcceptGuruRun.Left = Me.cmdCancel.Left + Me.cmdCancel.Width + 10
					Me.btnAcceptAllGuruRun.Left = Me.btnAcceptGuruRun.Left
				End If
			End If
			Me.ulgBatchLog.Width = Me.pnlBatchLog.Width - 10
			Me.ulgBatchLog.Height = Me.pnlBatchLog.Height - 10
		End Sub

		Private Sub BatchLog_Enter(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Me.Left = CInt(Math.Round(CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0))
			Me.Height = Me.ParentForm.Height - 170
			Me.Top = 10
		End Sub

		Private Sub BatchLog_Activated(sender As Object, e As EventArgs)
			RSWIN_DESC.sCurrentFormName = ""
			Me.btnSort.Enabled = True
		End Sub

		Private Sub btnSort_Click(sender As Object, e As EventArgs)
			Me.lblStatus.Text = ""
			If RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bExpert Then
				If Me.bDescending Then
					Me.bDescending = False
				Else
					Me.bDescending = True
				End If
				Me.SortBatchLogList(Me.bDescending)
				Return
			End If
		End Sub

		Private Sub btnAcceptGuruRun_Click(sender As Object, e As EventArgs)
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				RSWIN_DESC.SETUP_GURUSAVEDIR = "c:\Theta\SavedXROD_Runs\"
				Dim directoryInfo As DirectoryInfo = New DirectoryInfo(RSWIN_DESC.SETUP_GURUSAVEDIR)
				Dim text As String = ""
				Try
					If Me.m_sBatchFileName IsNot Nothing AndAlso (Operators.CompareString(Me.m_sBatchFileName, "", False) <> 0 And FILEUTIL.FileExists(Me.m_sBatchFileName)) Then
						If Not directoryInfo.Exists Then
							Try
								directoryInfo.Create()
							Catch ex As Exception
							End Try
						End If
						Dim fileInfo As FileInfo = New FileInfo(Me.m_sBatchFileName)
						text = Me.m_sBatchFileName.Replace(RSWIN_DESC.SETUP_GURUTEMPDIR, RSWIN_DESC.SETUP_GURUSAVEDIR)
						If FILEUTIL.FileExists(text) Then
							FileSystem.Kill(text)
						End If
						fileInfo.CopyTo(text)
						Me.lblStatus.Text = "   File saved to " + RSWIN_DESC.SETUP_GURUSAVEDIR
					End If
				Catch ex2 As Exception
				End Try
				Return
			End If
		End Sub

		Private Sub BatchLog_Closing(sender As Object, e As CancelEventArgs)
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				Dim rodstar As RODSTAR = CType(Me.ParentForm, RODSTAR)
				If rodstar.btnGuru.Visible Then
					rodstar.btnGuru.BringToFront()
				End If
				rodstar.lblGURU.BackColor = Color.LightGray
			End If
		End Sub

		Private Sub btnAcceptAllGuruRun_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				RSWIN_DESC.SETUP_GURUSAVEDIR = "c:\Theta\SavedXROD_Runs\"
				Dim directoryInfo As DirectoryInfo = New DirectoryInfo(RSWIN_DESC.SETUP_GURUSAVEDIR)
				Dim text As String = ""
				Try
					Dim num As Integer = Information.LBound(RSWIN_DESC.mrgBatchFileList, 1)
					Dim num2 As Integer = Information.UBound(RSWIN_DESC.mrgBatchFileList, 1)
					For i As Integer = num To num2
						If RSWIN_DESC.mrgBatchFileList(i) IsNot Nothing Then
							Try
								If Operators.CompareString(RSWIN_DESC.mrgBatchFileList(i), "", False) <> 0 And FILEUTIL.FileExists(RSWIN_DESC.mrgBatchFileList(i)) Then
									If Not directoryInfo.Exists Then
										Try
											directoryInfo.Create()
										Catch ex As Exception
										End Try
									End If
									Dim fileInfo As FileInfo = New FileInfo(RSWIN_DESC.mrgBatchFileList(i))
									text = RSWIN_DESC.mrgBatchFileList(i).Replace(RSWIN_DESC.SETUP_GURUTEMPDIR, RSWIN_DESC.SETUP_GURUSAVEDIR)
									If FILEUTIL.FileExists(text) Then
										FileSystem.Kill(text)
									End If
									fileInfo.CopyTo(text)
								End If
							Catch ex2 As Exception
							End Try
						End If
					Next
					Me.lblStatus.Text = "   Files saved to " + RSWIN_DESC.SETUP_GURUSAVEDIR
				Catch ex3 As Exception
				End Try
				Return
			End If
		End Sub

		Private Sub SetGridColors()
			Try
				Dim ultraGridRow As UltraGridRow = Me.ulgBatchLog.GetRow(ChildRow.First)
				While ultraGridRow IsNot Nothing
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells(Me.sLogEntry).Value)) Then
						If Strings.InStr(Conversions.ToString(ultraGridRow.Cells(Me.sLogEntry).Value), "batch run is complete", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(ultraGridRow.Cells(Me.sLogEntry).Value), "run aborted", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(ultraGridRow.Cells(Me.sLogEntry).Value), "was canceled", CompareMethod.Binary) > 0 Then
							ultraGridRow.Cells(Me.sLogEntry).Appearance.FontData.Italic = DefaultableBoolean.[True]
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackGradientStyle = GradientStyle.Horizontal
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackColor2 = Color.LightGray
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackColor = Color.LightSlateGray
							ultraGridRow.Cells(Me.sLogEntry).Appearance.ForeColor = Color.White
						ElseIf Strings.InStr(Conversions.ToString(ultraGridRow.Cells(Me.sLogEntry).Value), "Unit with larger", CompareMethod.Binary) > 0 Then
							ultraGridRow.Cells(Me.sLogEntry).Appearance.FontData.Italic = DefaultableBoolean.[True]
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackGradientStyle = GradientStyle.Horizontal
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackColor2 = Color.LightYellow
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackColor = Color.Yellow
							ultraGridRow.Cells(Me.sLogEntry).Appearance.ForeColor = Color.Black
						ElseIf Strings.InStr(Conversions.ToString(ultraGridRow.Cells(Me.sLogEntry).Value), "XROD-V AI Batch Run", CompareMethod.Binary) > 0 Then
							ultraGridRow.Cells(Me.sLogEntry).Appearance.FontData.Italic = DefaultableBoolean.[True]
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackGradientStyle = GradientStyle.Horizontal
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackColor2 = Color.LightGreen
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackColor = Color.DarkGreen
							ultraGridRow.Cells(Me.sLogEntry).Appearance.ForeColor = Color.White
						ElseIf Strings.InStr(Conversions.ToString(ultraGridRow.Cells(Me.sLogEntry).Value), ".rsvx", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(ultraGridRow.Cells(Me.sLogEntry).Value), ".RSVX", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(ultraGridRow.Cells(Me.sLogEntry).Value), ".rsdx", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(ultraGridRow.Cells(Me.sLogEntry).Value), ".RSDX", CompareMethod.Binary) > 0 Then
							ultraGridRow.Cells(Me.sLogEntry).Appearance.FontData.Italic = DefaultableBoolean.[True]
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackGradientStyle = GradientStyle.Horizontal
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackColor2 = Color.LightBlue
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackColor = Color.DarkBlue
							ultraGridRow.Cells(Me.sLogEntry).Appearance.ForeColor = Color.White
						ElseIf Strings.InStr(Conversions.ToString(ultraGridRow.Cells(Me.sLogEntry).Value), "Using 2 3/8", CompareMethod.Binary) > 0 Then
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackColor = Color.White
							ultraGridRow.Cells(Me.sLogEntry).Appearance.ForeColor = Color.Blue
						Else
							ultraGridRow.Cells(Me.sLogEntry).Appearance.BackColor = Color.White
							ultraGridRow.Cells(Me.sLogEntry).Appearance.ForeColor = Color.Black
						End If
					End If
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
					Else
						ultraGridRow = Nothing
					End If
				End While
				Me.ulgBatchLog.ActiveRow = Nothing
			Catch ex As Exception
			End Try
		End Sub

		Public Sub InitBatchLogDataset(ByRef mdsBatchLog As DataSet)
			Try
				mdsBatchLog = Nothing
				mdsBatchLog = New DataSet("BatchLog")
				Dim dataTable As DataTable = New DataTable("BatchLog")
				Dim dataColumn As DataColumn = New DataColumn(Me.sLogEntry, GetType(String))
				dataColumn.AllowDBNull = True
				dataColumn.MaxLength = 1000
				dataTable.Columns.Add(dataColumn)
				mdsBatchLog.Tables.Add(dataTable)
				mdsBatchLog.Tables(0).Clear()
			Catch ex As Exception
				MessageBox.Show("Error in InitBatchLogDataset: " + ex.Message)
			End Try
		End Sub

		Private Sub ulgBatchLog_InitializeLayout(eventSender As Object, eventArgs As InitializeLayoutEventArgs)
			Try
				Dim layout As UltraGridLayout = eventArgs.Layout
				layout.TabNavigation = TabNavigation.NextCell
				Dim ultraGridBand As UltraGridBand = layout.Bands(0)
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns(Me.sLogEntry)
				ultraGridColumn.Header.Caption = Me.Text
				ultraGridColumn.Width = Me.ulgBatchLog.Width - 30
				ultraGridColumn.AutoSizeMode = ColumnAutoSizeMode.VisibleRows
				Dim ultraGrid As UltraGrid = Me.ulgBatchLog
				Try
					ultraGrid.ActiveRow = ultraGrid.GetRow(ChildRow.First)
				Catch ex As Exception
				End Try
				Dim override As UltraGridOverride = ultraGrid.DisplayLayout.Override
				override.AllowColMoving = AllowColMoving.NotAllowed
				override.AllowColSizing = AllowColSizing.None
				override.AllowColSwapping = AllowColSwapping.NotAllowed
				override.BorderStyleCell = UIElementBorderStyle.InsetSoft
				override.BorderStyleRow = UIElementBorderStyle.None
				override.RowSelectors = DefaultableBoolean.[False]
				override.RowSizing = RowSizing.Fixed
				override.ActiveRowAppearance.BorderColor = SystemColors.Highlight
				override.ActiveRowAppearance.BorderColor3DBase = SystemColors.Highlight
				ultraGrid = Nothing
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub AddBatchlogEntry(sValue As String)
			Try
				Debug.WriteLine(sValue)
				If Operators.CompareString(sValue.Trim(), "", False) <> 0 Then
					Dim dataRow As DataRow = Me.mdsBatchLog.Tables(0).NewRow()
					dataRow(Me.sLogEntry) = sValue.Trim()
					Try
						Me.mdsBatchLog.Tables(0).Rows.Add(dataRow)
					Catch ex As Exception
					End Try
					Me.ulgBatchLog.DataSource = Nothing
					Me.ulgBatchLog.DataSource = Me.mdsBatchLog
					Me.ulgBatchLog.Rows.Refresh(RefreshRow.RefreshDisplay, True)
					Me.SetGridColors()
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub ulgBatchLog_BeforeEnterEditMode(sender As Object, e As CancelEventArgs)
			Dim flag As Boolean = True
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bRunGuru Then
				flag = False
			End If
			Dim activeRow As UltraGridRow = Me.ulgBatchLog.ActiveRow
			If activeRow.Cells(Me.sLogEntry).Value IsNot Nothing Then
				Dim text As String = Conversions.ToString(activeRow.Cells(Me.sLogEntry).Value)
				Me.sSaveItm = text
				If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Strings.InStr(text, RSWIN_DESC.SETUP_GURUTEMPDIR, CompareMethod.Binary) > 0) Or (Not(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) And Operators.CompareString(text.Substring(text.Length - 1, 1), ":", False) = 0) Then
					Dim sBatchFileName As String = text.Substring(0, Strings.Len(text) - 1)
					activeRow.Cells(Me.sLogEntry).Appearance.BackColor = SystemColors.Highlight
					activeRow.Cells(Me.sLogEntry).Appearance.ForeColor = SystemColors.HighlightText
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						If FILEUTIL.FileExists(sBatchFileName) Then
							If flag Then
								Me.btnAcceptGuruRun.Visible = True
								Me.btnAcceptGuruRun.Enabled = True
							End If
							Me.m_sBatchFileName = sBatchFileName
						Else
							Me.m_sBatchFileName = ""
							Me.btnAcceptGuruRun.Enabled = False
						End If
					End If
				Else
					Me.m_sBatchFileName = ""
					Me.btnAcceptGuruRun.Enabled = False
				End If
				Return
			End If
		End Sub

		Private Sub ulgBatchLog_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs)
			Dim flag As Boolean = True
			Try
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bRunGuru Then
					flag = False
				End If
				Dim activeCell As UltraGridCell = Me.ulgBatchLog.ActiveCell
				If Me.ulgBatchLog.ActiveRow IsNot Nothing Then
					Dim activeRow As UltraGridRow = Me.ulgBatchLog.ActiveRow
					If activeRow.Cells(Me.sLogEntry).Value IsNot Nothing Then
						Dim text As String = Conversions.ToString(activeRow.Cells(Me.sLogEntry).Value)
						If Operators.CompareString(text.Substring(text.Length - 1, 1), ":", False) = 0 AndAlso flag Then
							Dim sBatchFileName As String = text.Substring(0, Strings.Len(text) - 1)
							If FILEUTIL.FileExists(sBatchFileName) Then
								Me.bDisplayBatchOutput = True
								Me.m_sBatchFileName = sBatchFileName
								RSWIN_DESC.rst.gbBatch = False
								Me.Tag = "DisplayReport"
								Try
									Dim rodstar As RODSTAR = CType(Me.ParentForm, RODSTAR)
									rodstar.mnuFileSaveAsPDF_.Enabled = True
									If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
										rodstar.StopAIAni()
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

		Private Sub ulgBatchLog_BeforeExitEditMode(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs)
			Me.sSaveItm = ""
			Dim activeRow As UltraGridRow = Me.ulgBatchLog.ActiveRow
			If activeRow.Cells(Me.sLogEntry).Value IsNot Nothing Then
				Dim text As String = Conversions.ToString(activeRow.Cells(Me.sLogEntry).Value)
				If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And Strings.InStr(text, RSWIN_DESC.SETUP_GURUTEMPDIR, CompareMethod.Binary) > 0) Or (Not(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) And Operators.CompareString(text.Substring(text.Length - 1, 1), ":", False) = 0) Then
					activeRow.Cells(Me.sLogEntry).Appearance.FontData.Italic = DefaultableBoolean.[True]
					activeRow.Cells(Me.sLogEntry).Appearance.BackGradientStyle = GradientStyle.Horizontal
					activeRow.Cells(Me.sLogEntry).Appearance.BackColor2 = Color.LightBlue
					activeRow.Cells(Me.sLogEntry).Appearance.BackColor = Color.DarkBlue
					activeRow.Cells(Me.sLogEntry).Appearance.ForeColor = Color.White
				End If
				Return
			End If
		End Sub

		Public Sub SortBatchLogList(bDescending As Boolean)
			Dim text As String = ""
			Dim array As Batch.BatchLogEntry() = New Batch.BatchLogEntry(100) {}
			Dim flag As Boolean = False
			Dim array2 As String() = New String(100) {}
			Dim flag2 As Boolean = False
			Dim obj As Object = "System Design Score: "
			Dim [string] As String = "TOTAL SCORE: "
			Try
				Dim dataSet As DataSet
				Try
					If Me.$STATIC$SortBatchLogList$20112$sLastItem Is Nothing Then
						Me.$STATIC$SortBatchLogList$20112$sLastItem = ""
					End If
					Dim num As Integer = 1
					array(num).Initialize()
					Dim num2 As Integer = 0
					Dim ultraGridRow As UltraGridRow = Me.ulgBatchLog.GetRow(ChildRow.First)
					While ultraGridRow IsNot Nothing
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells(Me.sLogEntry).Value)) Then
							text = Conversions.ToString(ultraGridRow.Cells(Me.sLogEntry).Value)
						Else
							text = ""
						End If
						Dim flag3 As Boolean = True
						If Operators.CompareString(text.Trim(), "", False) <> 0 Then
							If Operators.CompareString(text.Substring(0, 1), ">", False) = 0 Or Operators.CompareString(text.Trim(), Me.$STATIC$SortBatchLogList$20112$sLastItem.Trim(), False) = 0 Then
								flag3 = False
							End If
						Else
							flag3 = False
						End If
						If flag3 Then
							num2 += 1
							Try
								array2(num2) = text
							Catch ex As Exception
								num2 -= 1
							End Try
							If Operators.CompareString(text, "...", False) = 0 Then
								array(num).iCount = array(num).iCount + 1
								array(num).sComment(array(num).iCount) = text
								num += 1
								array(num).Initialize()
							ElseIf Operators.CompareString(text.Trim(), "", False) <> 0 Then
								If Strings.InStr(Strings.LCase(text), "xrvx", CompareMethod.Binary) > 0 And Strings.InStr(Strings.LCase(text), "complete", CompareMethod.Binary) <= 0 Then
									array(num).Initialize()
									array(num).sFileName = text
									array(num).Score = 0F
								ElseIf Strings.InStr(Strings.LCase(text), "rsvx", CompareMethod.Binary) > 0 Or Strings.InStr(Strings.LCase(text), "rsdx", CompareMethod.Binary) > 0 Then
									array(num).sFileName = text
								ElseIf Strings.InStr(text, Conversions.ToString(obj), CompareMethod.Binary) > 0 Then
									Dim text2 As String = text.Substring(Strings.InStr(text, Conversions.ToString(obj), CompareMethod.Binary) + 19).Trim()
									text2 = text2.Substring(0, Strings.InStr(text2, "%", CompareMethod.Binary) - 1)
									If Versioned.IsNumeric(text2) Then
										array(num).Score = Convert.ToSingle(text2)
									Else
										array(num).Score = 0F
									End If
									array(num).iCount = array(num).iCount + 1
									array(num).sComment(array(num).iCount) = text
								ElseIf Strings.InStr(text, [string], CompareMethod.Binary) > 0 Then
									Dim text2 As String = text.Substring(Strings.InStr(text, [string], CompareMethod.Binary) + 11).Trim()
									text2 = text2.Substring(0, Strings.InStr(text2, "%", CompareMethod.Binary) - 1)
									If Versioned.IsNumeric(text2) Then
										array(num).Score = Convert.ToSingle(text2)
									Else
										array(num).Score = 0F
									End If
									array(num).iCount = array(num).iCount + 1
									array(num).sComment(array(num).iCount) = text
								Else
									array(num).iCount = array(num).iCount + 1
									array(num).sComment(array(num).iCount) = text
								End If
							End If
						End If
						If ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							Me.$STATIC$SortBatchLogList$20112$sLastItem = text
							ultraGridRow = Nothing
						End If
					End While
					Dim flag4 As Boolean
					Do
						flag4 = True
						Dim num3 As Integer = 2
						Dim num4 As Integer = num - 1
						For i As Integer = num3 To num4
							If bDescending Then
								If array(i + 1).Score > array(i).Score Then
									flag4 = False
									flag = True
									Dim batchLogEntry As Batch.BatchLogEntry
									batchLogEntry.Initialize()
									batchLogEntry = array(i)
									array(i) = array(i + 1)
									array(i + 1) = batchLogEntry
								End If
							ElseIf array(i).Score > array(i + 1).Score And array(i + 1).Score <> 0F Then
								flag4 = False
								flag = True
								Dim batchLogEntry As Batch.BatchLogEntry
								batchLogEntry.Initialize()
								batchLogEntry = array(i)
								array(i) = array(i + 1)
								array(i + 1) = batchLogEntry
							End If
						Next
					Loop While Not flag4
					Try
						If flag Then
							Me.InitBatchLogDataset(dataSet)
							Dim num5 As Integer = 1
							Dim num6 As Integer = num - 1
							For i As Integer = num5 To num6
								Dim dataRow As DataRow = dataSet.Tables(0).NewRow()
								Try
									dataRow(Me.sLogEntry) = array(i).sFileName
								Catch ex2 As Exception
								End Try
								Try
									dataSet.Tables(0).Rows.Add(dataRow)
								Catch ex3 As Exception
								End Try
								Dim num7 As Integer = 1
								Dim iCount As Integer = array(i).iCount
								For j As Integer = num7 To iCount
									dataRow = dataSet.Tables(0).NewRow()
									Try
										dataRow(Me.sLogEntry) = array(i).sComment(j)
									Catch ex4 As Exception
									End Try
									Try
										dataSet.Tables(0).Rows.Add(dataRow)
									Catch ex5 As Exception
									End Try
								Next
							Next
							If Operators.CompareString(Me.$STATIC$SortBatchLogList$20112$sLastItem.Trim(), "", False) <> 0 Then
								Dim dataRow As DataRow = dataSet.Tables(0).NewRow()
								Try
									dataRow(Me.sLogEntry) = Me.$STATIC$SortBatchLogList$20112$sLastItem
								Catch ex6 As Exception
								End Try
								Try
									dataSet.Tables(0).Rows.Add(dataRow)
								Catch ex7 As Exception
								End Try
							End If
						End If
					Catch ex8 As Exception
						flag2 = True
					End Try
				Catch ex9 As Exception
					flag2 = True
				End Try
				If Not flag2 AndAlso flag Then
					Try
						Me.mdsBatchLog = dataSet
						Me.ulgBatchLog.DataSource = Nothing
						Me.ulgBatchLog.DataSource = Me.mdsBatchLog
						Me.ulgBatchLog.Rows.Refresh(RefreshRow.RefreshDisplay, True)
						Me.SetGridColors()
					Catch ex10 As Exception
					End Try
				End If
			Catch ex11 As Exception
			End Try
		End Sub

		Public Sub GetBatchList(ByRef asBatchMessageList As String())
			Dim num As Integer = -1
			Try
				Dim ultraGridRow As UltraGridRow = Me.ulgBatchLog.GetRow(ChildRow.First)
				While ultraGridRow IsNot Nothing
					num += 1
					asBatchMessageList = CType(Utils.CopyArray(CType(asBatchMessageList, Array), New String(num + 1 - 1) {}), String())
					asBatchMessageList(num) = Conversions.ToString(ultraGridRow.Cells(Me.sLogEntry).Value)
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
					Else
						ultraGridRow = Nothing
					End If
				End While
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgBatchLog_AfterRowInsert(sender As Object, e As RowEventArgs)
			Dim point As Point = New Point(0, 0)
			Dim obj As Object = point
			Try
				If Screen.PrimaryScreen.Bounds.Height < 700 Or Screen.PrimaryScreen.Bounds.Width < 1000 Then
					Me.pnlBatchLog.AutoScroll = True
					Dim pnlBatchLog As ScrollableControl = Me.pnlBatchLog
					Dim obj2 As Object = obj
					Dim point2 As Point
					pnlBatchLog.AutoScrollPosition = If((obj2 IsNot Nothing), CType(obj2, Point), point2)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgBatchLog_KeyPress(sender As Object, e As KeyPressEventArgs)
		End Sub

		Public Sub ResetClock()
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				Me.MyParentFrm.bEnd = False
				Me.MyParentFrm.tmrClock.Enabled = False
				Me.MyParentFrm.NowTime = DateAndTime.Now
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub BatchLog_LocationChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub BatchLog_VisibleChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub lblStatus_TextChanged(sender As Object, e As EventArgs)
		End Sub

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As PanelArray

		<AccessedThroughProperty("prgPercentComplete")>
		Private _prgPercentComplete As ProgressBar

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("lblFilesComplete")>
		Private _lblFilesComplete As Label

		<AccessedThroughProperty("c")>
		Private _c As Label

		<AccessedThroughProperty("_Label_1")>
		Private __Label_1 As Label

		<AccessedThroughProperty("_Label_0")>
		Private __Label_0 As Label

		<AccessedThroughProperty("lblCompleted")>
		Private _lblCompleted As Label

		<AccessedThroughProperty("btnSort")>
		Private _btnSort As Button

		<AccessedThroughProperty("btnAcceptGuruRun")>
		Private _btnAcceptGuruRun As Button

		<AccessedThroughProperty("btnAcceptAllGuruRun")>
		Private _btnAcceptAllGuruRun As Button

		<AccessedThroughProperty("pnlBatchLog")>
		Private _pnlBatchLog As Panel

		<AccessedThroughProperty("ulgBatchLog")>
		Private _ulgBatchLog As UltraGrid

		<AccessedThroughProperty("lblStatus")>
		Private _lblStatus As Label

		Private Shared m_vb6FormDefInstance As BatchLog

		Private Shared m_InitializingDefInstance As Boolean

		Private sLogEntry As String

		Private mdsBatchLog As DataSet

		Private m_bDisplayBatchOutput As Boolean

		Private sTOTALSCORE As String

		Private sGrade As String

		Private bDescending As Boolean

		Private sSaveItm As String

		Private m_sBatchFileName As String

		Private m_UpdatePercent As Single

		Private m_FilesSelected As String

		Private m_cmdCancelText As String

		Private m_FilesComplete As String

		Private MyParentFrm As RODSTAR

		Private $STATIC$SortBatchLogList$20112$sLastItem As String
	End Class
End Namespace
