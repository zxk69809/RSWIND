Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgBatchOpts
		Inherits Form

		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.dlgBatchOpts_KeyDown
			AddHandler MyBase.Load, AddressOf Me.dlgBatchOpts_Load
			Me.sDYWBatchPrint = Util.AssignValueToConstant("RODSTAR", "sDYWBatchPrint", "Do you want to have the batch run log printed?")
			Me.sBatchPrintNote = Util.AssignValueToConstant("RODSTAR", "sBatchPrintNote", "(Note that if you do not have the log printed, it will be very difficult to tell which cases have been run.)")
			If dlgBatchOpts.m_vb6FormDefInstance Is Nothing Then
				If dlgBatchOpts.m_InitializingDefInstance Then
					dlgBatchOpts.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgBatchOpts.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property cmdHelp As Button
			Get
				Return Me._cmdHelp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdHelp_Click
				If Me._cmdHelp IsNot Nothing Then
					RemoveHandler Me._cmdHelp.Click, value2
				End If
				Me._cmdHelp = value
				If Me._cmdHelp IsNot Nothing Then
					AddHandler Me._cmdHelp.Click, value2
				End If
			End Set
		End Property

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

		Public Overridable Property cmdProceed As Button
			Get
				Return Me._cmdProceed
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdProceed_Click
				If Me._cmdProceed IsNot Nothing Then
					RemoveHandler Me._cmdProceed.Click, value2
				End If
				Me._cmdProceed = value
				If Me._cmdProceed IsNot Nothing Then
					AddHandler Me._cmdProceed.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property chkPrintResults As CheckBox
			Get
				Return Me._chkPrintResults
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkPrintResults_CheckedChanged
				If Me._chkPrintResults IsNot Nothing Then
					RemoveHandler Me._chkPrintResults.CheckedChanged, value2
				End If
				Me._chkPrintResults = value
				If Me._chkPrintResults IsNot Nothing Then
					AddHandler Me._chkPrintResults.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkSaveWorksheet As CheckBox
			Get
				Return Me._chkSaveWorksheet
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkSaveWorksheet_CheckedChanged
				If Me._chkSaveWorksheet IsNot Nothing Then
					RemoveHandler Me._chkSaveWorksheet.CheckedChanged, value2
				End If
				Me._chkSaveWorksheet = value
				If Me._chkSaveWorksheet IsNot Nothing Then
					AddHandler Me._chkSaveWorksheet.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkSkipProcessedFiles As CheckBox
			Get
				Return Me._chkSkipProcessedFiles
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkSkipProcessedFiles = value
			End Set
		End Property

		Friend Overridable Property HelpProvider1 As HelpProvider
			Get
				Return Me._HelpProvider1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As HelpProvider)
				Me._HelpProvider1 = value
			End Set
		End Property

		Friend Overridable Property chkViewWorksheet As CheckBox
			Get
				Return Me._chkViewWorksheet
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkViewWorksheet = value
			End Set
		End Property

		Friend Overridable Property pnlAutomatic As Panel
			Get
				Return Me._pnlAutomatic
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlAutomatic = value
			End Set
		End Property

		Friend Overridable Property chkAutoPrintBatch As CheckBox
			Get
				Return Me._chkAutoPrintBatch
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkAutoPrintBatch = value
			End Set
		End Property

		Friend Overridable Property lblAutoPrintBatchNote As Label
			Get
				Return Me._lblAutoPrintBatchNote
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblAutoPrintBatchNote = value
			End Set
		End Property

		Public Overridable Property pnlBatch As Panel
			Get
				Return Me._pnlBatch
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlBatch = value
			End Set
		End Property

		Friend Overridable Property chkCreatePDFs As CheckBox
			Get
				Return Me._chkCreatePDFs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkCreatePDFs = value
			End Set
		End Property

		Friend Overridable Property lblDemoMode As Label
			Get
				Return Me._lblDemoMode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDemoMode = value
			End Set
		End Property

		Public Shared Property DefInstance As dlgBatchOpts
			Get
				If dlgBatchOpts.m_vb6FormDefInstance Is Nothing OrElse dlgBatchOpts.m_vb6FormDefInstance.IsDisposed Then
					dlgBatchOpts.m_InitializingDefInstance = True
					dlgBatchOpts.m_vb6FormDefInstance = New dlgBatchOpts()
					dlgBatchOpts.m_InitializingDefInstance = False
				End If
				Return dlgBatchOpts.m_vb6FormDefInstance
			End Get
			Set(value As dlgBatchOpts)
				dlgBatchOpts.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property bRST As Boolean
			Get
				Return Me.m_bRST
			End Get
			Set(value As Boolean)
				Me.m_bRST = value
			End Set
		End Property

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			RSWIN_DESC.CancelBatch = True
			Me.Close()
		End Sub

		Private Sub cmdHelp_Click(eventSender As Object, eventArgs As EventArgs)
			Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.KeywordIndex, "batch run options")
		End Sub

		Private Sub cmdProceed_Click(eventSender As Object, eventArgs As EventArgs)
			RSWIN_DESC.CancelBatch = False
			RSWIN_DESC.SETUP_BatchPrintouts = If((-If((Me.chkPrintResults.Checked > False), 1, 0)), 1, 0)
			RSWIN_DESC.SETUP_BatchSaveWorksheet = If((-If((Me.chkSaveWorksheet.Checked > False), 1, 0)), 1, 0)
			RSWIN_DESC.SETUP_BatchViewWorksheet = If((-If((Me.chkViewWorksheet.Checked > False), 1, 0)), 1, 0)
			If Not RSWIN_DESC.SETUP_BatchSaveWorksheet <> 0 Then
				RSWIN_DESC.SETUP_BatchViewWorksheet = 0
			End If
			RSWIN_DESC.SETUP_BatchSkipProcessedFiles = If((-If((Me.chkSkipProcessedFiles.Checked > False), 1, 0)), 1, 0)
			Dim text As String = "BatchPrintouts"
			Dim obj As Object = RSWIN_DESC.SETUP_BatchPrintouts
			Dim text2 As String = Util.Format(obj)
			RSWIN_DESC.SETUP_BatchPrintouts = Conversions.ToInteger(obj)
			Dim text3 As String = text2
			Dim obj2 As Object = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text3, RSWIN_DESC.sINIFile)
			text3 = "BatchSaveWorksheet"
			obj = RSWIN_DESC.SETUP_BatchSaveWorksheet
			Dim text4 As String = Util.Format(obj)
			RSWIN_DESC.SETUP_BatchSaveWorksheet = Conversions.ToInteger(obj)
			text = text4
			obj2 = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile)
			text3 = "BatchViewWorksheet"
			obj = RSWIN_DESC.SETUP_BatchViewWorksheet
			Dim text5 As String = Util.Format(obj)
			RSWIN_DESC.SETUP_BatchViewWorksheet = Conversions.ToInteger(obj)
			text = text5
			obj2 = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile)
			text3 = "BatchSkipProcessedFiles"
			obj = RSWIN_DESC.SETUP_BatchSkipProcessedFiles
			Dim text6 As String = Util.Format(obj)
			RSWIN_DESC.SETUP_BatchSkipProcessedFiles = Conversions.ToInteger(obj)
			text = text6
			obj2 = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile)
			text3 = "BatchCreatePDFs"
			obj = RSWIN_DESC.SETUP_CreatePDFs
			Dim text7 As String = Util.Format(obj)
			RSWIN_DESC.SETUP_CreatePDFs = Conversions.ToInteger(obj)
			text = text7
			obj2 = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile)
			Me.Hide()
		End Sub

		Private Sub dlgBatchOpts_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub dlgBatchOpts_Load(eventSender As Object, eventArgs As EventArgs)
			Try
				Me.pnlAutomatic.Visible = False
				Me.Height = 201
				If RSWIN_DESC.gbDemoMode Then
					Me.lblDemoMode.Visible = True
				Else
					Me.lblDemoMode.Visible = False
				End If
				If RSWIN_DESC.HelpNameSpace.Trim().Length > 0 Then
					Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
				End If
				Dim form As Form = Me
				Util.CenterForm(form, RSWIN_DESC.frmMain, RSWIN_DESC.frmMain.pnlToolbar.Height, False)
				RSWIN_DESC.rst.gbPrintBatchLog = False
				Dim text As String = "BatchPrintouts"
				Dim flag As Boolean = False
				RSWIN_DESC.SETUP_BatchPrintouts = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1, 0)), 1, 0)
				text = "BatchSaveWorksheet"
				flag = True
				RSWIN_DESC.SETUP_BatchSaveWorksheet = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1, 0)), 1, 0)
				text = "BatchViewWorksheet"
				flag = True
				RSWIN_DESC.SETUP_BatchViewWorksheet = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1, 0)), 1, 0)
				text = "BatchSkipProcessedFiles"
				flag = True
				RSWIN_DESC.SETUP_BatchSkipProcessedFiles = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1, 0)), 1, 0)
				text = "BatchCreatePDFs"
				flag = False
				RSWIN_DESC.SETUP_CreatePDFs = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag) > False), 1, 0)), 1, 0)
				Me.chkPrintResults.Checked = (RSWIN_DESC.SETUP_BatchPrintouts <> 0)
				Me.chkSaveWorksheet.Checked = (RSWIN_DESC.SETUP_BatchSaveWorksheet <> 0)
				Me.chkViewWorksheet.Enabled = Me.chkSaveWorksheet.Checked
				Me.chkViewWorksheet.Checked = (RSWIN_DESC.SETUP_BatchViewWorksheet <> 0)
				Me.chkCreatePDFs.Checked = (RSWIN_DESC.SETUP_CreatePDFs <> 0)
				text = "ExcelInstalled"
				flag = True
				RSWIN_DESC.SETUP_ExcelInstalled = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text, flag)
				Me.chkViewWorksheet.Enabled = RSWIN_DESC.SETUP_ExcelInstalled
				If Not Me.chkViewWorksheet.Enabled Then
					Me.chkViewWorksheet.Checked = False
				End If
				If Not Me.m_bRST Then
					Me.chkSkipProcessedFiles.Checked = (RSWIN_DESC.SETUP_BatchSkipProcessedFiles <> 0)
					Me.chkSkipProcessedFiles.Enabled = True
				Else
					RSWIN_DESC.SETUP_BatchSkipProcessedFiles = 0
					Me.chkSkipProcessedFiles.Checked = (RSWIN_DESC.SETUP_BatchSkipProcessedFiles <> 0)
					Me.chkSkipProcessedFiles.Enabled = False
				End If
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter(Me.Name)
					Util.WriteControlStrings(Me, Me.ToolTip1)
					Util.CloseResourceWriter()
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in dlgBatchOpts_Load: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub chkPrintResults_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub chkSaveWorksheet_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkViewWorksheet.Enabled = Me.chkSaveWorksheet.Checked
		End Sub

		<AccessedThroughProperty("cmdHelp")>
		Private _cmdHelp As Button

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("cmdProceed")>
		Private _cmdProceed As Button

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("chkPrintResults")>
		Private _chkPrintResults As CheckBox

		<AccessedThroughProperty("chkSaveWorksheet")>
		Private _chkSaveWorksheet As CheckBox

		<AccessedThroughProperty("chkSkipProcessedFiles")>
		Private _chkSkipProcessedFiles As CheckBox

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		<AccessedThroughProperty("chkViewWorksheet")>
		Private _chkViewWorksheet As CheckBox

		<AccessedThroughProperty("pnlAutomatic")>
		Private _pnlAutomatic As Panel

		<AccessedThroughProperty("chkAutoPrintBatch")>
		Private _chkAutoPrintBatch As CheckBox

		<AccessedThroughProperty("lblAutoPrintBatchNote")>
		Private _lblAutoPrintBatchNote As Label

		<AccessedThroughProperty("pnlBatch")>
		Private _pnlBatch As Panel

		<AccessedThroughProperty("chkCreatePDFs")>
		Private _chkCreatePDFs As CheckBox

		<AccessedThroughProperty("lblDemoMode")>
		Private _lblDemoMode As Label

		Private Shared m_vb6FormDefInstance As dlgBatchOpts

		Private Shared m_InitializingDefInstance As Boolean

		Private sDYWBatchPrint As String

		Private sBatchPrintNote As String

		Private m_bRST As Boolean
	End Class
End Namespace
