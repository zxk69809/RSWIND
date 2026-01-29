Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class frmWizard
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Leave, AddressOf Me.frmWizard_Leave
			AddHandler MyBase.Load, AddressOf Me.frmWizard_Load
			Me.sExcelFormatError = Util.AssignValueToConstant("frmWizard", "sExcelFormatError", "This Excel file is not in a recognizable format for importing deviation survey data. Please call Theta technical support.")
			Me.sCouldNotCreateExcelApp = Util.AssignValueToConstant("frmWizard", "sCouldNotCreateExcelApp", "Could not create Excel Application object, (Error: ")
			Me.sCouldNotOpenExcelFile = Util.AssignValueToConstant("frmWizard", "sCouldNotOpenExcelFile", "Could not open Excel file ")
			Me.sCouldNotReadData = Util.AssignValueToConstant("frmWizard", "sCouldNotReadData", "Could not read data from Workbook in file ")
			Me.sErrorSearchingWorkbooks = Util.AssignValueToConstant("frmWizard", "sErrorSearchingWorkbooks", "An error occurred while searching for Workbooks (")
			Me.sCouldReadSS = Util.AssignValueToConstant("frmWizard", "sCouldReadSS", "Could not read spreadsheets (")
			Me.sSS = New String(1) {}
			Me.sWB = New String(1) {}
			Me.sMeasured2 = "Meas."
			Me.sMeasured3 = "MD ("
			Me.sMD = "MD"
			Me.sIncl = "Incl"
			Me.sInc = "Inc"
			Me.sAz = "AZ"
			Me.sAzm = "Azm"
			Me.smKB = "mKB"
			Me.sKOMD = "KO MD"
			Me.sMDTie = "MD Tie"
			Me.IsInitializing = True
			Me.InitializeComponent()
			Me.IsInitializing = False
		End Sub

		Public Overridable Property txtCode As TextBox
			Get
				Return Me._txtCode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtCode = value
			End Set
		End Property

		Public Overridable Property lblCode As Label
			Get
				Return Me._lblCode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCode = value
			End Set
		End Property

		Public Overridable Property lblScreen_1 As Label
			Get
				Return Me._lblScreen_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblScreen_1 = value
			End Set
		End Property

		Public Overridable Property pnlScreen_1 As Panel
			Get
				Return Me._pnlScreen_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As PaintEventHandler = AddressOf Me.pnlScreen_1_Paint
				If Me._pnlScreen_1 IsNot Nothing Then
					RemoveHandler Me._pnlScreen_1.Paint, value2
				End If
				Me._pnlScreen_1 = value
				If Me._pnlScreen_1 IsNot Nothing Then
					AddHandler Me._pnlScreen_1.Paint, value2
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

		Public Overridable Property cmdNext As Button
			Get
				Return Me._cmdNext
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdNext_Click
				If Me._cmdNext IsNot Nothing Then
					RemoveHandler Me._cmdNext.Click, value2
				End If
				Me._cmdNext = value
				If Me._cmdNext IsNot Nothing Then
					AddHandler Me._cmdNext.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdBack As Button
			Get
				Return Me._cmdBack
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdBack_Click
				If Me._cmdBack IsNot Nothing Then
					RemoveHandler Me._cmdBack.Click, value2
				End If
				Me._cmdBack = value
				If Me._cmdBack IsNot Nothing Then
					AddHandler Me._cmdBack.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property Line1 As Label
			Get
				Return Me._Line1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Line1 = value
			End Set
		End Property

		Public Overridable Property lblCaption As Label
			Get
				Return Me._lblCaption
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCaption = value
			End Set
		End Property

		Public Overridable Property pnlScreen_4 As Panel
			Get
				Return Me._pnlScreen_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlScreen_4 = value
			End Set
		End Property

		Public Overridable Property lblScreen_4 As Label
			Get
				Return Me._lblScreen_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblScreen_4 = value
			End Set
		End Property

		Public Overridable Property pnlScreen_5 As Panel
			Get
				Return Me._pnlScreen_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlScreen_5 = value
			End Set
		End Property

		Public Overridable Property lblScreen_5 As Label
			Get
				Return Me._lblScreen_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblScreen_5 = value
			End Set
		End Property

		Public Overridable Property pnlScreen_6 As Panel
			Get
				Return Me._pnlScreen_6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlScreen_6 = value
			End Set
		End Property

		Public Overridable Property pnlScreen_0 As Panel
			Get
				Return Me._pnlScreen_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlScreen_0 = value
			End Set
		End Property

		Public Overridable Property lblScreen_0 As Label
			Get
				Return Me._lblScreen_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblScreen_0 = value
			End Set
		End Property

		Friend Overridable Property grpScreen_4 As GroupBox
			Get
				Return Me._grpScreen_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpScreen_4 = value
			End Set
		End Property

		Friend Overridable Property rtbScreen_4 As RichTextBox
			Get
				Return Me._rtbScreen_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._rtbScreen_4 = value
			End Set
		End Property

		Friend Overridable Property grpScreen_5 As GroupBox
			Get
				Return Me._grpScreen_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpScreen_5 = value
			End Set
		End Property

		Friend Overridable Property rtbScreen_5 As RichTextBox
			Get
				Return Me._rtbScreen_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._rtbScreen_5 = value
			End Set
		End Property

		Friend Overridable Property grpScreen_0 As GroupBox
			Get
				Return Me._grpScreen_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpScreen_0 = value
			End Set
		End Property

		Friend Overridable Property rtbScreen_0 As RichTextBox
			Get
				Return Me._rtbScreen_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._rtbScreen_0 = value
			End Set
		End Property

		Friend Overridable Property GroupBox1 As GroupBox
			Get
				Return Me._GroupBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		Public Overridable Property lblWait As Label
			Get
				Return Me._lblWait
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblWait = value
			End Set
		End Property

		Public Overridable Property Picture1 As PictureBox
			Get
				Return Me._Picture1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._Picture1 = value
			End Set
		End Property

		Friend Overridable Property txtExcel As TextBox
			Get
				Return Me._txtExcel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtExcel_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtExcel_Resize
				Dim value4 As EventHandler = AddressOf Me.txtExcel_Leave
				Dim value5 As EventHandler = AddressOf Me.txtExcel_Enter
				If Me._txtExcel IsNot Nothing Then
					RemoveHandler Me._txtExcel.TextChanged, value2
					RemoveHandler Me._txtExcel.Resize, value3
					RemoveHandler Me._txtExcel.Leave, value4
					RemoveHandler Me._txtExcel.Enter, value5
				End If
				Me._txtExcel = value
				If Me._txtExcel IsNot Nothing Then
					AddHandler Me._txtExcel.TextChanged, value2
					AddHandler Me._txtExcel.Resize, value3
					AddHandler Me._txtExcel.Leave, value4
					AddHandler Me._txtExcel.Enter, value5
				End If
			End Set
		End Property

		Friend Overridable Property cmdBrowse_0 As Button
			Get
				Return Me._cmdBrowse_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdBrowse_0_Click
				If Me._cmdBrowse_0 IsNot Nothing Then
					RemoveHandler Me._cmdBrowse_0.Click, value2
				End If
				Me._cmdBrowse_0 = value
				If Me._cmdBrowse_0 IsNot Nothing Then
					AddHandler Me._cmdBrowse_0.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblExcel As Label
			Get
				Return Me._lblExcel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblExcel = value
			End Set
		End Property

		Friend Overridable Property grpScreen_1 As GroupBox
			Get
				Return Me._grpScreen_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpScreen_1 = value
			End Set
		End Property

		Friend Overridable Property rtbScreen_1 As RichTextBox
			Get
				Return Me._rtbScreen_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Dim value2 As EventHandler = AddressOf Me.rtbScreen_1_TextChanged
				Dim value3 As EventHandler = AddressOf Me.rtbScreen_1_Leave
				Dim value4 As EventHandler = AddressOf Me.rtbScreen_1_Enter
				If Me._rtbScreen_1 IsNot Nothing Then
					RemoveHandler Me._rtbScreen_1.TextChanged, value2
					RemoveHandler Me._rtbScreen_1.Leave, value3
					RemoveHandler Me._rtbScreen_1.Enter, value4
				End If
				Me._rtbScreen_1 = value
				If Me._rtbScreen_1 IsNot Nothing Then
					AddHandler Me._rtbScreen_1.TextChanged, value2
					AddHandler Me._rtbScreen_1.Leave, value3
					AddHandler Me._rtbScreen_1.Enter, value4
				End If
			End Set
		End Property

		Friend Overridable Property lblMDCol As Label
			Get
				Return Me._lblMDCol
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMDCol = value
			End Set
		End Property

		Friend Overridable Property lblINCol As Label
			Get
				Return Me._lblINCol
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblINCol = value
			End Set
		End Property

		Friend Overridable Property lblAZCol As Label
			Get
				Return Me._lblAZCol
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblAZCol = value
			End Set
		End Property

		Friend Overridable Property lblRange As Label
			Get
				Return Me._lblRange
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRange = value
			End Set
		End Property

		Friend Overridable Property lblNumPoints As Label
			Get
				Return Me._lblNumPoints
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumPoints = value
			End Set
		End Property

		Friend Overridable Property txtMDCol As TextBox
			Get
				Return Me._txtMDCol
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMDCol_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtMDCol_Leave
				Dim value4 As EventHandler = AddressOf Me.txtMDCol_Enter
				If Me._txtMDCol IsNot Nothing Then
					RemoveHandler Me._txtMDCol.TextChanged, value2
					RemoveHandler Me._txtMDCol.Leave, value3
					RemoveHandler Me._txtMDCol.Enter, value4
				End If
				Me._txtMDCol = value
				If Me._txtMDCol IsNot Nothing Then
					AddHandler Me._txtMDCol.TextChanged, value2
					AddHandler Me._txtMDCol.Leave, value3
					AddHandler Me._txtMDCol.Enter, value4
				End If
			End Set
		End Property

		Friend Overridable Property txtINCol As TextBox
			Get
				Return Me._txtINCol
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtINCol_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtINCol_Leave
				Dim value4 As EventHandler = AddressOf Me.txtINCol_Enter
				If Me._txtINCol IsNot Nothing Then
					RemoveHandler Me._txtINCol.TextChanged, value2
					RemoveHandler Me._txtINCol.Leave, value3
					RemoveHandler Me._txtINCol.Enter, value4
				End If
				Me._txtINCol = value
				If Me._txtINCol IsNot Nothing Then
					AddHandler Me._txtINCol.TextChanged, value2
					AddHandler Me._txtINCol.Leave, value3
					AddHandler Me._txtINCol.Enter, value4
				End If
			End Set
		End Property

		Friend Overridable Property txtAZCol As TextBox
			Get
				Return Me._txtAZCol
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtAZCol_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtAZCol_Leave
				Dim value4 As EventHandler = AddressOf Me.txtAZCol_Enter
				If Me._txtAZCol IsNot Nothing Then
					RemoveHandler Me._txtAZCol.TextChanged, value2
					RemoveHandler Me._txtAZCol.Leave, value3
					RemoveHandler Me._txtAZCol.Enter, value4
				End If
				Me._txtAZCol = value
				If Me._txtAZCol IsNot Nothing Then
					AddHandler Me._txtAZCol.TextChanged, value2
					AddHandler Me._txtAZCol.Leave, value3
					AddHandler Me._txtAZCol.Enter, value4
				End If
			End Set
		End Property

		Friend Overridable Property txtNumPoints As TextBox
			Get
				Return Me._txtNumPoints
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtNumPoints = value
			End Set
		End Property

		Friend Overridable Property lblUnits As Label
			Get
				Return Me._lblUnits
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblUnits = value
			End Set
		End Property

		Friend Overridable Property rbtEnglish As RadioButton
			Get
				Return Me._rbtEnglish
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbtEnglish = value
			End Set
		End Property

		Friend Overridable Property rbtMetric As RadioButton
			Get
				Return Me._rbtMetric
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbtMetric = value
			End Set
		End Property

		Public Overridable Property lblScreen_6 As Label
			Get
				Return Me._lblScreen_6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblScreen_6 = value
			End Set
		End Property

		Friend Overridable Property lblColumn As Label
			Get
				Return Me._lblColumn
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblColumn = value
			End Set
		End Property

		Friend Overridable Property lblName As Label
			Get
				Return Me._lblName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblName = value
			End Set
		End Property

		Friend Overridable Property txtMDRange As TextBox
			Get
				Return Me._txtMDRange
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMDRange = value
			End Set
		End Property

		Friend Overridable Property lblPosition As Label
			Get
				Return Me._lblPosition
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPosition = value
			End Set
		End Property

		Friend Overridable Property txtAZPos As TextBox
			Get
				Return Me._txtAZPos
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtAZPos = value
			End Set
		End Property

		Friend Overridable Property txtINPos As TextBox
			Get
				Return Me._txtINPos
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtINPos = value
			End Set
		End Property

		Friend Overridable Property txtMDPos As TextBox
			Get
				Return Me._txtMDPos
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMDPos = value
			End Set
		End Property

		Friend Overridable Property txtINRange As TextBox
			Get
				Return Me._txtINRange
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtINRange = value
			End Set
		End Property

		Friend Overridable Property txtAZRange As TextBox
			Get
				Return Me._txtAZRange
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtAZRange = value
			End Set
		End Property

		Friend Overridable Property lblSurveyType As Label
			Get
				Return Me._lblSurveyType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSurveyType = value
			End Set
		End Property

		Friend Overridable Property lblSpreadSheet As Label
			Get
				Return Me._lblSpreadSheet
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSpreadSheet = value
			End Set
		End Property

		Friend Overridable Property lblWorkbook As Label
			Get
				Return Me._lblWorkbook
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblWorkbook = value
			End Set
		End Property

		Public Overridable Property pnlScreen_3 As Panel
			Get
				Return Me._pnlScreen_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As PaintEventHandler = AddressOf Me.pnlScreen_2_Paint
				If Me._pnlScreen_3 IsNot Nothing Then
					RemoveHandler Me._pnlScreen_3.Paint, value2
				End If
				Me._pnlScreen_3 = value
				If Me._pnlScreen_3 IsNot Nothing Then
					AddHandler Me._pnlScreen_3.Paint, value2
				End If
			End Set
		End Property

		Friend Overridable Property grpScreen_3 As GroupBox
			Get
				Return Me._grpScreen_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpScreen_3 = value
			End Set
		End Property

		Friend Overridable Property rtbScreen_3 As RichTextBox
			Get
				Return Me._rtbScreen_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._rtbScreen_3 = value
			End Set
		End Property

		Public Overridable Property lblScreen_3 As Label
			Get
				Return Me._lblScreen_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblScreen_3 = value
			End Set
		End Property

		Public Overridable Property pnlScreen_2 As Panel
			Get
				Return Me._pnlScreen_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As PaintEventHandler = AddressOf Me.pnlScreen_33_Paint
				If Me._pnlScreen_2 IsNot Nothing Then
					RemoveHandler Me._pnlScreen_2.Paint, value2
				End If
				Me._pnlScreen_2 = value
				If Me._pnlScreen_2 IsNot Nothing Then
					AddHandler Me._pnlScreen_2.Paint, value2
				End If
			End Set
		End Property

		Public Overridable Property lblScreen_2 As Label
			Get
				Return Me._lblScreen_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblScreen_2 = value
			End Set
		End Property

		Friend Overridable Property grpScreen_2 As GroupBox
			Get
				Return Me._grpScreen_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpScreen_2 = value
			End Set
		End Property

		Friend Overridable Property rtbScreen_2 As RichTextBox
			Get
				Return Me._rtbScreen_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._rtbScreen_2 = value
			End Set
		End Property

		Friend Overridable Property cboSpreadSheets As ComboBox
			Get
				Return Me._cboSpreadSheets
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboSpreadSheets_SelectedIndexChanged
				If Me._cboSpreadSheets IsNot Nothing Then
					RemoveHandler Me._cboSpreadSheets.SelectedIndexChanged, value2
				End If
				Me._cboSpreadSheets = value
				If Me._cboSpreadSheets IsNot Nothing Then
					AddHandler Me._cboSpreadSheets.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblSS_Step2 As Label
			Get
				Return Me._lblSS_Step2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSS_Step2 = value
			End Set
		End Property

		Friend Overridable Property cboWB As ComboBox
			Get
				Return Me._cboWB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboWB_SelectedIndexChanged
				If Me._cboWB IsNot Nothing Then
					RemoveHandler Me._cboWB.SelectedIndexChanged, value2
				End If
				Me._cboWB = value
				If Me._cboWB IsNot Nothing Then
					AddHandler Me._cboWB.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property tmrClock As System.Windows.Forms.Timer
			Get
				Return Me._tmrClock
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Me._tmrClock = value
			End Set
		End Property

		Friend Overridable Property lblWB_Step2 As Label
			Get
				Return Me._lblWB_Step2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblWB_Step2 = value
			End Set
		End Property

		Public Shared Property DefInstance As frmWizard
			Get
				If frmWizard.m_vb6FormDefInstance Is Nothing OrElse frmWizard.m_vb6FormDefInstance.IsDisposed Then
					frmWizard.m_InitializingDefInstance = True
					frmWizard.m_vb6FormDefInstance = New frmWizard()
					frmWizard.m_InitializingDefInstance = False
				End If
				Return frmWizard.m_vb6FormDefInstance
			End Get
			Set(value As frmWizard)
				frmWizard.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property bEnglish As Boolean
			Get
				Return Me.m_bEnglish
			End Get
			Set(value As Boolean)
				Me.m_bEnglish = value
			End Set
		End Property

		Public Property bSuccess As Boolean
			Get
				Return Me.m_bSuccess
			End Get
			Set(value As Boolean)
				Me.m_bSuccess = value
			End Set
		End Property

		Public Property sType As String
			Get
				Return Me.m_sType
			End Get
			Set(value As String)
				Me.m_sType = value
			End Set
		End Property

		Private Sub ResizeMe()
			' The following expression was wrapped in a checked-statement
			Try
				Me.lblCaption.Top = 8
				Me.lblCaption.Left = 8
				Me.Line1.Left = 8
				Me.Line1.Top = 40
				Me.Picture1.Top = Me.Line1.Top + 20
				Me.Picture1.Left = Me.Line1.Left
				Select Case Me.intScreen
					Case 1S
						Me.BusyCursor()
						Me.pnlScreen_1.Top = Me.Picture1.Top
						Me.pnlScreen_1.Left = Me.Picture1.Left + 50
						If Operators.CompareString(Me.txtExcel.Text, "", False) = 0 Then
							Me.cmdNext.Enabled = False
						Else
							Me.cmdNext.Enabled = True
						End If
						Me.pnlScreen_1.Visible = True
						Me.UnbusyCursor()
					Case 2S
						Me.BusyCursor()
						Me.pnlScreen_2.Top = Me.Picture1.Top
						Me.pnlScreen_2.Left = Me.Picture1.Left + 50
						Me.pnlScreen_2.Visible = True
						Me.UnbusyCursor()
					Case 3S
						Me.BusyCursor()
						Me.pnlScreen_3.Top = Me.Picture1.Top
						Me.pnlScreen_3.Left = Me.Picture1.Left + 50
						Me.pnlScreen_3.Visible = True
						Me.UnbusyCursor()
					Case 5S
						Me.cmdCancel.PerformClick()
				End Select
			Catch ex As Exception
				MessageBox.Show("Error in ResizeMe: " + ex.Message)
			End Try
		End Sub

		Private Sub cmdBack_Click(eventSender As Object, eventArgs As EventArgs)
			Me.BusyCursor()
			Me.cmdNext.Enabled = False
			Me.cmdBack.Enabled = False
			Me.intScreen -= 1S
			Me.lblCaption.Text = RSWIN_DESC.sPleaseWait
			Application.DoEvents()
			Me.SetupScreen()
			Me.ResetClock()
			Me.UnbusyCursor()
		End Sub

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			Me.BusyCursor()
			If Operators.CompareString(Me.cmdCancel.Text, "&Cancel", False) = 0 Then
				Me.m_bSuccess = False
			End If
			Try
				Me.NAR(RuntimeHelpers.GetObjectValue(Me.oSheet), False)
				Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWB), False)
				Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWBs), False)
				NewLateBinding.LateCall(Me.oXLApp, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
				Me.NAR(RuntimeHelpers.GetObjectValue(Me.oXLApp), False)
				Thread.Sleep(1000)
			Catch ex As Exception
			End Try
			Me.Hide()
			Me.UnbusyCursor()
			Me.ResetClock()
			Me.Close()
			Me.UnbusyCursor()
		End Sub

		Private Sub cmdNext_Click(eventSender As Object, eventArgs As EventArgs)
			Me.BusyCursor()
			Me.cmdNext.Enabled = False
			Me.cmdBack.Enabled = False
			Me.cmdCancel.Enabled = False
			If Me.intScreen = 1S Then
				If Operators.CompareString(Me.sExcelFile, "", False) = 0 Then
					Return
				End If
				Me.lblScreen_1.Text = RSWIN_DESC.sPleaseWait
				Me.lblCaption.Text = RSWIN_DESC.sPleaseWait
				Me.iSS = 0
				Me.iWB = 0
				Me.sSelectedWB = ""
				Me.sSelectedSS = ""
				Me.sSS = New String(1) {}
				Me.sWB = New String(1) {}
				Me.sSS(1) = ""
				Me.sWB(1) = ""
				Application.DoEvents()
			ElseIf Me.intScreen = 2S Then
				Me.lblScreen_2.Text = RSWIN_DESC.sPleaseWait
				Me.lblCaption.Text = RSWIN_DESC.sPleaseWait
				Application.DoEvents()
			ElseIf Me.intScreen = 3S Then
				Me.lblScreen_3.Text = RSWIN_DESC.sPleaseWait
				Me.lblCaption.Text = RSWIN_DESC.sPleaseWait
				Application.DoEvents()
			End If
			Me.intScreen += 1S
			If Me.intScreen = 2S Then
				Me.iSS = 0
				If Not Me.XLWorkSheetOpenReadClose_Find_WB_Names() Then
					Me.m_bSuccess = False
					Me.Close()
				End If
				If Me.iSS < 2 Then
					Me.intScreen += 1S
				Else
					Me.lblSS_Step2.Text = "Speadsheets in Workbook: "
				End If
			End If
			Me.lblCaption.Text = RSWIN_DESC.sPleaseWait
			Me.SetupScreen()
			Me.ResetClock()
			Me.UnbusyCursor()
		End Sub

		Private Sub frmWizard_Leave(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub frmWizard_Load(eventSender As Object, eventArgs As EventArgs)
			If RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
				Me.tmrClock.Enabled = True
			Else
				Me.tmrClock.Enabled = False
			End If
			Me.ResetClock()
			RSWIN.GetMeasurementUnit()
			Me.m_bSuccess = False
			Me.intScreen = 1S
			Me.SetupScreen()
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private Sub SetupScreen()
			Dim flag As Boolean = False
			Try
				Me.pnlScreen_0.Left = -1333
				Me.pnlScreen_1.Left = -1333
				Me.pnlScreen_2.Left = -1333
				Me.pnlScreen_3.Left = -1333
				Me.pnlScreen_4.Left = -1333
				Me.pnlScreen_5.Left = -1333
				Me.pnlScreen_6.Left = -1333
				Select Case Me.intScreen
					Case 1S
						Me.lblCaption.Text = "Step 1: "
						Dim text As String = "Carefully follow the instructions below and then click 'Next' to continue..."
						Me.lblScreen_1.Text = text
						text = "     Select an Excel file (xls) which contains the deviatation survey for this well." & vbCrLf
						text += " The program will open the file and then determine where the column headers are" & vbCrLf
						text += " for Measured Depth, Inclination, and Azimuth. It will also try to determine the" & vbCrLf
						text += " measurement units, the range of data cells, and the number of rows (including blank lines)." & vbCrLf
						text = String.Concat(New String() { text, "     For manually entered surveys, recommended column headings are ", RSWIN_DESC.sDblQuote, "MD (ft)", RSWIN_DESC.sDblQuote, " or ", RSWIN_DESC.sDblQuote, "MD (m)", RSWIN_DESC.sDblQuote, ", ", RSWIN_DESC.sDblQuote, "Inclination", RSWIN_DESC.sDblQuote, ", and  ", RSWIN_DESC.sDblQuote, "Azimuth", RSWIN_DESC.sDblQuote, ". Also, please avoid entering any blank lines." & vbCrLf })
						Me.rtbScreen_1.Text = text
						Me.cmdCancel.Text = "&Cancel"
						Me.cmdCancel.Enabled = True
					Case 2S
						Me.lblCaption.Text = "Step: 2 "
						Me.lblScreen_2.Text = Me.lblCaption.Text
						Dim text As String = "This is a manual step." & vbCrLf
						text += "Carefully follow the instructions below and then click 'Next' to continue..."
						Me.cmdNext.Enabled = True
						Me.cmdBack.Enabled = True
						Me.cmdCancel.Text = "&Cancel"
						Me.cmdCancel.Enabled = True
						text = "The Workbook (" + Me.sSelectedWB + ") contains more than one Spreadsheet. Please select a spreadsheet."
						Me.rtbScreen_2.Text = text
					Case 3S
						Me.BusyCursor()
						If Not Me.XLWorkSheetOpenReadClose_Find() Then
							Try
								MessageBox.Show(Me.sExcelFormatError)
								Me.NAR(RuntimeHelpers.GetObjectValue(Me.oSheet), True)
								Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWB), True)
								Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWBs), True)
								NewLateBinding.LateCall(Me.oXLApp, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
								Me.NAR(RuntimeHelpers.GetObjectValue(Me.oXLApp), True)
								Thread.Sleep(1000)
							Catch ex As Exception
							End Try
							Me.m_bSuccess = False
							Me.Close()
						End If
						Me.UnbusyCursor()
						If Me.iSS > 1 Then
							Me.lblCaption.Text = "Step " + Convert.ToString(Me.intScreen) + ":"
						Else
							' The following expression was wrapped in a checked-expression
							Me.lblCaption.Text = "Step " + Convert.ToString(CInt((Me.intScreen - 1S))) + ":"
						End If
						Dim text As String = "This is a manual step." & vbCrLf
						text += "Carefully follow the instructions below and then click 'Next' to continue..."
						Me.lblScreen_3.Text = text
						Me.cmdNext.Enabled = True
						Me.cmdCancel.Text = "&Cancel"
						Me.cmdCancel.Enabled = True
						text = " Please verify the items above. " & vbCrLf
						text += "  If the program did not determine an item correctly, please contact Theta technical support." & vbCrLf
						Me.rtbScreen_3.Text = text
					Case 4S
						Me.cmdNext.Enabled = False
						Me.cmdBack.Enabled = False
						Me.cmdCancel.Enabled = False
						Me.lblCaption.Text = "Please wait! Now loading data from file!"
						Me.lblScreen_3.Text = Me.lblCaption.Text
						Me.lblScreen_6.Text = "Now loading data from file!"
						Me.BusyCursor()
						Application.DoEvents()
						If Not Me.XLWorkSheetOpenReadClose() Then
							Me.m_bSuccess = False
							Me.Close()
						End If
						Me.UnbusyCursor()
						If Me.m_bSuccess Then
							Me.lblCaption.Text = "Read completed successfully !"
							flag = True
						Else
							Me.lblCaption.Text = "Read did not complete successfully !"
						End If
						Application.DoEvents()
						Dim text As String = "Click 'Done' to finish..."
						Me.lblScreen_6.Text = text
						Me.cmdNext.Enabled = False
						Me.cmdCancel.Enabled = True
						Me.cmdCancel.Text = "&Done"
						text += vbCrLf
						text += vbCrLf
						text += vbCrLf
						Me.UnbusyCursor()
						If flag Then
							Dim flag2 As Boolean = True
							Dim now As DateTime = DateAndTime.Now
							Do
								Application.DoEvents()
								Application.DoEvents()
								Dim seconds As Integer = DateAndTime.Now.Subtract(now).Seconds
								If seconds > 2 Then
									flag2 = False
								End If
							Loop While flag2
							Me.cmdCancel.PerformClick()
						End If
				End Select
				Me.ResizeMe()
			Catch ex2 As Exception
				MessageBox.Show("Error in SetupScreen: " + ex2.Message)
			End Try
		End Sub

		Protected Overrides Sub Finalize()
			Me.Hide()
			MyBase.Finalize()
		End Sub

		Private Sub pnlScreen_1_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Public Function GetSpreadSheetValue(Row As Integer, Column As Integer) As Object
			Dim result As Object
			Try
				Dim obj As Object = Me.oSheet
				Dim type As Type = Nothing
				Dim text As String = "Cells"
				Dim array As Object() = New Object() { Row, Column }
				Dim array2 As Object() = array
				Dim array3 As String() = Nothing
				Dim array4 As Type() = Nothing
				Dim array5 As Boolean() = New Boolean() { True, True }
				Dim obj2 As Object = NewLateBinding.LateGet(obj, type, text, array2, array3, array4, array5)
				If array5(0) Then
					Row = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Integer)))
				End If
				If array5(1) Then
					Column = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(1)), GetType(Integer)))
				End If
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, Nothing, "Value", New Object(-1) {}, Nothing, Nothing, Nothing))
				If objectValue IsNot Nothing Then
					Try
						If Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.sCheck)).Trim(), "", False) = 0 Then
						End If
					Catch ex As Exception
					End Try
				End If
				result = objectValue
			Catch ex2 As Exception
				result = Nothing
			End Try
			Return result
		End Function

		Public Function XLWorkSheetOpenReadClose_Find() As Boolean
			Me.FirstCol = 0
			Me.LastCol = 0
			Me.ColumnRow = 0
			Me.FirstDataRow = 0
			Me.LastDataRow = 0
			Me.MDCol = 0
			Me.INCol = 0
			Me.AZCol = 0
			Me.sMeasured = "Measured"
			Me.sInclination = "Inclination"
			Me.sAzimuth = "Azimuth"
			Me.m_sType = ""
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = False
			Dim flag5 As Boolean = False
			Me.m_bEnglish = True
			Dim result As Boolean
			Try
				Try
					Me.oXLApp = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application", ""))
				Catch ex As Exception
					MessageBox.Show(Me.sCouldNotCreateExcelApp + ex.Message + ").")
					Return False
				End Try
				Try
					NewLateBinding.LateSet(Me.oXLApp, Nothing, "Visible", New Object() { False }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.oXLApp, Nothing, "UserControl", New Object() { False }, Nothing, Nothing)
				Catch ex2 As Exception
				End Try
				Try
					Dim obj As Object = NewLateBinding.LateGet(Me.oXLApp, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing)
					Dim type As Type = Nothing
					Dim text As String = "Open"
					Dim array As Object() = New Object() { Me.sExcelFile, False, True }
					Dim array2 As Object() = array
					Dim array3 As String() = New String() { "FileName", "UpdateLinks", "ReadOnly" }
					Dim array4 As Type() = Nothing
					Dim array5 As Boolean() = New Boolean() { True, False, False }
					Dim obj2 As Object = NewLateBinding.LateGet(obj, type, text, array2, array3, array4, array5)
					If array5(0) Then
						Me.sExcelFile = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(String)))
					End If
					Me.oWBs = RuntimeHelpers.GetObjectValue(obj2)
				Catch ex3 As Exception
					MessageBox.Show(String.Concat(New String() { Me.sCouldNotOpenExcelFile, Me.sExcelFile, ", (", ex3.Message, ")." }))
					Return False
				End Try
				Try
					Try
						For Each obj3 As Object In CType(NewLateBinding.LateGet(Me.oXLApp, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable)
							Me.oWB = RuntimeHelpers.GetObjectValue(obj3)
							Me.Column = 1L
							Me.Row = 1L
							Me.FirstCol = 0
							Me.LastCol = 0
							If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.oWB, Nothing, "Name", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), Me.sSelectedWB.Trim(), False) Then
								Me.lblWorkbook.Text = "Workbork: " + Me.sSelectedWB.Trim()
								Try
									For Each obj4 As Object In CType(NewLateBinding.LateGet(Me.oWB, Nothing, "Worksheets", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable)
										Me.oSheet = RuntimeHelpers.GetObjectValue(obj4)
										If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.oSheet, Nothing, "Name", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), Me.sSelectedSS.Trim(), False) Then
											Me.lblSpreadSheet.Text = "Spreadsheet: " + Me.sSelectedSS.Trim()
											Me.bContinueRow = True
											Me.bContinueCol = True
											While Me.bContinueRow And Me.Row < 30L
												Try
													Dim num As Integer = 0
													Dim num2 As Integer = 0
													While Me.bContinueCol And Me.Column < 30L
														Try
															Try
																Me.sCheck = RuntimeHelpers.GetObjectValue(Me.GetSpreadSheetValue(CInt(Me.Row), CInt(Me.Column)))
																If Me.sCheck IsNot Nothing Then
																End If
															Catch ex4 As Exception
															End Try
															If Me.sCheck Is Nothing Then
																num += 1
															ElseIf Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.sCheck)).Trim(), "", False) = 0 Then
																num += 1
															Else
																num2 += 1
															End If
															If Me.sCheck IsNot Nothing Then
																Dim flag6 As Boolean = True
																If flag6 = Strings.InStr(Conversions.ToString(Me.sCheck), vbCrLf, CompareMethod.Binary) > 0 Then
																	Me.sCheck = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.sCheck, Nothing, "Replace", New Object() { vbCrLf, " " }, Nothing, Nothing, Nothing))
																ElseIf flag6 = Strings.InStr(Conversions.ToString(Me.sCheck), vbLf, CompareMethod.Binary) > 0 Then
																	Me.sCheck = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.sCheck, Nothing, "Replace", New Object() { vbLf, " " }, Nothing, Nothing, Nothing))
																ElseIf flag6 = Strings.InStr(Conversions.ToString(Me.sCheck), vbVerticalTab, CompareMethod.Binary) > 0 Then
																	Me.sCheck = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.sCheck, Nothing, "Replace", New Object() { vbVerticalTab, " " }, Nothing, Nothing, Nothing))
																ElseIf flag6 = Strings.InStr(Conversions.ToString(Me.sCheck), vbTab, CompareMethod.Binary) > 0 Then
																	Me.sCheck = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.sCheck, Nothing, "Replace", New Object() { vbTab, " " }, Nothing, Nothing, Nothing))
																ElseIf flag6 = Strings.InStr(Conversions.ToString(Me.sCheck), vbCr, CompareMethod.Binary) > 0 Then
																	Me.sCheck = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.sCheck, Nothing, "Replace", New Object() { vbCr, " " }, Nothing, Nothing, Nothing))
																End If
																Dim flag7 As Boolean = True
																Dim flag8 As Boolean = flag7
																Dim obj5 As Object = Nothing
																Dim typeFromHandle As Type = GetType(Strings)
																Dim text2 As String = "UCase"
																Dim array6 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																Dim array7 As Object() = array6
																Dim array8 As String() = Nothing
																Dim array9 As Type() = Nothing
																Dim array5 As Boolean() = New Boolean() { True }
																Dim obj6 As Object = NewLateBinding.LateGet(obj5, typeFromHandle, text2, array7, array8, array9, array5)
																If array5(0) Then
																	Me.sCheck = RuntimeHelpers.GetObjectValue(array6(0))
																End If
																If flag8 = Strings.InStr(Conversions.ToString(obj6), "SCHLUMBERGER", CompareMethod.Binary) > 0 Then
																	Me.m_sType = Conversions.ToString(Me.sCheck)
																	Me.sMeasured = "Measured"
																	Me.sInclination = "Inclination"
																	Me.sAzimuth = "Azimuth"
																	Me.MDCol = 0
																	Me.INCol = 0
																	Me.AZCol = 0
																	flag2 = True
																Else
																	Dim flag9 As Boolean = flag7
																	Dim obj7 As Object = Nothing
																	Dim typeFromHandle2 As Type = GetType(Strings)
																	Dim text3 As String = "UCase"
																	array6 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																	Dim array10 As Object() = array6
																	Dim array11 As String() = Nothing
																	Dim array12 As Type() = Nothing
																	array5 = New Boolean() { True }
																	Dim obj8 As Object = NewLateBinding.LateGet(obj7, typeFromHandle2, text3, array10, array11, array12, array5)
																	If array5(0) Then
																		Me.sCheck = RuntimeHelpers.GetObjectValue(array6(0))
																	End If
																	If flag9 = Strings.InStr(Conversions.ToString(obj8), "SPERRY", CompareMethod.Binary) > 0 Then
																		Me.m_sType = Conversions.ToString(Me.sCheck)
																		Me.sMeasured = "Measured"
																		Me.sInclination = "Angle"
																		Me.sAzimuth = "Direction"
																		Me.MDCol = 0
																		Me.INCol = 0
																		Me.AZCol = 0
																		flag2 = True
																	Else
																		Dim flag10 As Boolean = flag7
																		Dim obj9 As Object = Nothing
																		Dim typeFromHandle3 As Type = GetType(Strings)
																		Dim text4 As String = "UCase"
																		array6 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																		Dim array13 As Object() = array6
																		Dim array14 As String() = Nothing
																		Dim array15 As Type() = Nothing
																		array5 = New Boolean() { True }
																		Dim obj10 As Object = NewLateBinding.LateGet(obj9, typeFromHandle3, text4, array13, array14, array15, array5)
																		If array5(0) Then
																			Me.sCheck = RuntimeHelpers.GetObjectValue(array6(0))
																		End If
																		If flag10 = Strings.InStr(Conversions.ToString(obj10), "ANADRILL", CompareMethod.Binary) > 0 Then
																			Me.m_sType = Conversions.ToString(Me.sCheck)
																			Me.sMeasured = "Measured"
																			Me.sInclination = "Station"
																			Me.sAzimuth = "Azimuth"
																			Me.MDCol = 0
																			Me.INCol = 0
																			Me.AZCol = 0
																			flag2 = True
																		Else
																			Dim flag11 As Boolean = flag7
																			Dim obj11 As Object = Nothing
																			Dim typeFromHandle4 As Type = GetType(Strings)
																			Dim text5 As String = "UCase"
																			array6 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																			Dim array16 As Object() = array6
																			Dim array17 As String() = Nothing
																			Dim array18 As Type() = Nothing
																			array5 = New Boolean() { True }
																			Dim obj12 As Object = NewLateBinding.LateGet(obj11, typeFromHandle4, text5, array16, array17, array18, array5)
																			If array5(0) Then
																				Me.sCheck = RuntimeHelpers.GetObjectValue(array6(0))
																			End If
																			Dim flag12 As Boolean = Strings.InStr(Conversions.ToString(obj12), Me.sMD, CompareMethod.Binary) > 0
																			Dim obj13 As Object = Nothing
																			Dim typeFromHandle5 As Type = GetType(Strings)
																			Dim text6 As String = "LCase"
																			Dim array19 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																			Dim array20 As Object() = array19
																			Dim array21 As String() = Nothing
																			Dim array22 As Type() = Nothing
																			Dim array23 As Boolean() = New Boolean() { True }
																			Dim obj14 As Object = NewLateBinding.LateGet(obj13, typeFromHandle5, text6, array20, array21, array22, array23)
																			If array23(0) Then
																				Me.sCheck = RuntimeHelpers.GetObjectValue(array19(0))
																			End If
																			Dim flag13 As Boolean = Strings.InStr(Conversions.ToString(obj14), "(" + RSWIN_DESC.ft + ")", CompareMethod.Binary) > 0
																			Dim obj15 As Object = Nothing
																			Dim typeFromHandle6 As Type = GetType(Strings)
																			Dim text7 As String = "LCase"
																			Dim array24 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																			Dim array25 As Object() = array24
																			Dim array26 As String() = Nothing
																			Dim array27 As Type() = Nothing
																			Dim array28 As Boolean() = New Boolean() { True }
																			Dim obj16 As Object = NewLateBinding.LateGet(obj15, typeFromHandle6, text7, array25, array26, array27, array28)
																			If array28(0) Then
																				Me.sCheck = RuntimeHelpers.GetObjectValue(array24(0))
																			End If
																			Dim flag14 As Boolean = flag13 Or Strings.InStr(Conversions.ToString(obj16), "(" + RSWIN_DESC.m + ")", CompareMethod.Binary) > 0
																			Dim obj17 As Object = Nothing
																			Dim typeFromHandle7 As Type = GetType(Strings)
																			Dim text8 As String = "LCase"
																			Dim array29 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																			Dim array30 As Object() = array29
																			Dim array31 As String() = Nothing
																			Dim array32 As Type() = Nothing
																			Dim array33 As Boolean() = New Boolean() { True }
																			Dim obj18 As Object = NewLateBinding.LateGet(obj17, typeFromHandle7, text8, array30, array31, array32, array33)
																			If array33(0) Then
																				Me.sCheck = RuntimeHelpers.GetObjectValue(array29(0))
																			End If
																			If flag11 = (flag12 And (flag14 Or Strings.InStr(Conversions.ToString(obj18), "(" + Strings.LCase(Me.smKB) + ")", CompareMethod.Binary) > 0)) Then
																				Dim obj19 As Object = Nothing
																				Dim typeFromHandle8 As Type = GetType(Strings)
																				Dim text9 As String = "LCase"
																				Dim array34 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																				Dim array35 As Object() = array34
																				Dim array36 As String() = Nothing
																				Dim array37 As Type() = Nothing
																				Dim array38 As Boolean() = New Boolean() { True }
																				Dim obj20 As Object = NewLateBinding.LateGet(obj19, typeFromHandle8, text9, array35, array36, array37, array38)
																				If array38(0) Then
																					Me.sCheck = RuntimeHelpers.GetObjectValue(array34(0))
																				End If
																				Dim flag15 As Boolean = Strings.InStr(Conversions.ToString(obj20), Strings.LCase(Me.sKOMD), CompareMethod.Binary) <= 0
																				Dim obj21 As Object = Nothing
																				Dim typeFromHandle9 As Type = GetType(Strings)
																				Dim text10 As String = "LCase"
																				Dim array39 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																				Dim array40 As Object() = array39
																				Dim array41 As String() = Nothing
																				Dim array42 As Type() = Nothing
																				Dim array43 As Boolean() = New Boolean() { True }
																				Dim obj22 As Object = NewLateBinding.LateGet(obj21, typeFromHandle9, text10, array40, array41, array42, array43)
																				If array43(0) Then
																					Me.sCheck = RuntimeHelpers.GetObjectValue(array39(0))
																				End If
																				If flag15 And Strings.InStr(Conversions.ToString(obj22), Strings.LCase(Me.sMDTie), CompareMethod.Binary) <= 0 Then
																					Dim obj23 As Object = Nothing
																					Dim typeFromHandle10 As Type = GetType(Strings)
																					Dim text11 As String = "UCase"
																					Dim array44 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																					Dim array45 As Object() = array44
																					Dim array46 As String() = Nothing
																					Dim array47 As Type() = Nothing
																					Dim array48 As Boolean() = New Boolean() { True }
																					Dim obj24 As Object = NewLateBinding.LateGet(obj23, typeFromHandle10, text11, array45, array46, array47, array48)
																					If array48(0) Then
																						Me.sCheck = RuntimeHelpers.GetObjectValue(array44(0))
																					End If
																					If Strings.InStr(Conversions.ToString(obj24), Me.sMD, CompareMethod.Binary) > 0 Then
																						flag3 = True
																					End If
																					If Me.MDCol = 0 Then
																						Me.sCheck2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.sCheck, Nothing, "Replace", New Object() { " ", "" }, Nothing, Nothing, Nothing))
																						Dim obj25 As Object = Nothing
																						Dim typeFromHandle11 As Type = GetType(Strings)
																						Dim text12 As String = "LCase"
																						Dim array49 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																						Dim array50 As Object() = array49
																						Dim array51 As String() = Nothing
																						Dim array52 As Type() = Nothing
																						array48 = New Boolean() { True }
																						Dim obj26 As Object = NewLateBinding.LateGet(obj25, typeFromHandle11, text12, array50, array51, array52, array48)
																						If array48(0) Then
																							Me.sCheck2 = RuntimeHelpers.GetObjectValue(array49(0))
																						End If
																						If Strings.InStr(Conversions.ToString(obj26), "(" + RSWIN_DESC.ft + ")", CompareMethod.Binary) > 0 Then
																							flag = True
																							Me.bEnglish = True
																						Else
																							Dim obj27 As Object = Nothing
																							Dim typeFromHandle12 As Type = GetType(Strings)
																							Dim text13 As String = "LCase"
																							array49 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																							Dim array53 As Object() = array49
																							Dim array54 As String() = Nothing
																							Dim array55 As Type() = Nothing
																							array48 = New Boolean() { True }
																							Dim obj28 As Object = NewLateBinding.LateGet(obj27, typeFromHandle12, text13, array53, array54, array55, array48)
																							If array48(0) Then
																								Me.sCheck2 = RuntimeHelpers.GetObjectValue(array49(0))
																							End If
																							Dim flag16 As Boolean = Strings.InStr(Conversions.ToString(obj28), "(" + RSWIN_DESC.m + ")", CompareMethod.Binary) > 0
																							Dim obj29 As Object = Nothing
																							Dim typeFromHandle13 As Type = GetType(Strings)
																							Dim text14 As String = "LCase"
																							Dim array56 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																							Dim array57 As Object() = array56
																							Dim array58 As String() = Nothing
																							Dim array59 As Type() = Nothing
																							array43 = New Boolean() { True }
																							Dim obj30 As Object = NewLateBinding.LateGet(obj29, typeFromHandle13, text14, array57, array58, array59, array43)
																							If array43(0) Then
																								Me.sCheck2 = RuntimeHelpers.GetObjectValue(array56(0))
																							End If
																							If flag16 Or Strings.InStr(Conversions.ToString(obj30), "(" + Strings.LCase(Me.smKB) + ")", CompareMethod.Binary) > 0 Then
																								flag = True
																								Me.bEnglish = False
																							End If
																						End If
																						Me.MDCol = CInt(Me.Column)
																						Me.txtMDCol.Text = Conversions.ToString(Me.sCheck)
																						Me.ColumnRow = CInt(Me.Row)
																					End If
																				End If
																			Else
																				Dim flag17 As Boolean = flag7
																				Dim obj31 As Object = Nothing
																				Dim typeFromHandle14 As Type = GetType(Strings)
																				Dim text15 As String = "LCase"
																				Dim array49 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																				Dim array60 As Object() = array49
																				Dim array61 As String() = Nothing
																				Dim array62 As Type() = Nothing
																				Dim array48 As Boolean() = New Boolean() { True }
																				Dim obj32 As Object = NewLateBinding.LateGet(obj31, typeFromHandle14, text15, array60, array61, array62, array48)
																				If array48(0) Then
																					Me.sCheck = RuntimeHelpers.GetObjectValue(array49(0))
																				End If
																				If flag17 <> Strings.InStr(Conversions.ToString(obj32), Strings.LCase(Me.sMeasured), CompareMethod.Binary) > 0 Then
																					Dim flag18 As Boolean = flag7
																					Dim obj33 As Object = Nothing
																					Dim typeFromHandle15 As Type = GetType(Strings)
																					Dim text16 As String = "LCase"
																					Dim array56 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																					Dim array63 As Object() = array56
																					Dim array64 As String() = Nothing
																					Dim array65 As Type() = Nothing
																					Dim array43 As Boolean() = New Boolean() { True }
																					Dim obj34 As Object = NewLateBinding.LateGet(obj33, typeFromHandle15, text16, array63, array64, array65, array43)
																					If array43(0) Then
																						Me.sCheck = RuntimeHelpers.GetObjectValue(array56(0))
																					End If
																					If flag18 <> Strings.InStr(Conversions.ToString(obj34), Strings.LCase(Me.sMeasured2), CompareMethod.Binary) > 0 Then
																						Dim flag19 As Boolean = flag7
																						Dim obj35 As Object = Nothing
																						Dim typeFromHandle16 As Type = GetType(Strings)
																						Dim text17 As String = "LCase"
																						Dim array66 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																						Dim array67 As Object() = array66
																						Dim array68 As String() = Nothing
																						Dim array69 As Type() = Nothing
																						Dim array38 As Boolean() = New Boolean() { True }
																						Dim obj36 As Object = NewLateBinding.LateGet(obj35, typeFromHandle16, text17, array67, array68, array69, array38)
																						If array38(0) Then
																							Me.sCheck = RuntimeHelpers.GetObjectValue(array66(0))
																						End If
																						If flag19 <> Strings.InStr(Conversions.ToString(obj36), Strings.LCase(Me.sMeasured3), CompareMethod.Binary) > 0 Then
																							Dim flag20 As Boolean = flag7
																							Dim obj37 As Object = Nothing
																							Dim typeFromHandle17 As Type = GetType(Strings)
																							Dim text18 As String = "LCase"
																							Dim array70 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																							Dim array71 As Object() = array70
																							Dim array72 As String() = Nothing
																							Dim array73 As Type() = Nothing
																							Dim array74 As Boolean() = New Boolean() { True }
																							Dim obj38 As Object = NewLateBinding.LateGet(obj37, typeFromHandle17, text18, array71, array72, array73, array74)
																							If array74(0) Then
																								Me.sCheck = RuntimeHelpers.GetObjectValue(array70(0))
																							End If
																							If flag20 = Strings.InStr(Conversions.ToString(obj38), Strings.LCase(Me.sInclination), CompareMethod.Binary) > 0 Then
																								Dim obj39 As Object = Nothing
																								Dim typeFromHandle18 As Type = GetType(Strings)
																								Dim text19 As String = "LCase"
																								array49 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																								Dim array75 As Object() = array49
																								Dim array76 As String() = Nothing
																								Dim array77 As Type() = Nothing
																								array48 = New Boolean() { True }
																								Dim obj40 As Object = NewLateBinding.LateGet(obj39, typeFromHandle18, text19, array75, array76, array77, array48)
																								If array48(0) Then
																									Me.sCheck = RuntimeHelpers.GetObjectValue(array49(0))
																								End If
																								If Strings.InStr(Conversions.ToString(obj40), Strings.LCase(Me.sInclination), CompareMethod.Binary) > 0 Then
																									flag4 = True
																								End If
																								If Me.MDCol > 0 And Me.INCol = 0 Then
																									Me.INCol = CInt(Me.Column)
																									Me.txtINCol.Text = Conversions.ToString(Me.sCheck)
																									Me.ColumnRow = CInt(Me.Row)
																									GoTo IL_1E3D
																								End If
																								GoTo IL_1E3D
																							Else
																								Dim flag21 As Boolean = flag7
																								Dim obj41 As Object = Nothing
																								Dim typeFromHandle19 As Type = GetType(Strings)
																								Dim text20 As String = "LCase"
																								array70 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																								Dim array78 As Object() = array70
																								Dim array79 As String() = Nothing
																								Dim array80 As Type() = Nothing
																								array74 = New Boolean() { True }
																								Dim obj42 As Object = NewLateBinding.LateGet(obj41, typeFromHandle19, text20, array78, array79, array80, array74)
																								If array74(0) Then
																									Me.sCheck = RuntimeHelpers.GetObjectValue(array70(0))
																								End If
																								If flag21 = Strings.InStr(Conversions.ToString(obj42), Strings.LCase(Me.sAzimuth), CompareMethod.Binary) > 0 Then
																									Dim obj43 As Object = Nothing
																									Dim typeFromHandle20 As Type = GetType(Strings)
																									Dim text21 As String = "LCase"
																									array49 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																									Dim array81 As Object() = array49
																									Dim array82 As String() = Nothing
																									Dim array83 As Type() = Nothing
																									array48 = New Boolean() { True }
																									Dim obj44 As Object = NewLateBinding.LateGet(obj43, typeFromHandle20, text21, array81, array82, array83, array48)
																									If array48(0) Then
																										Me.sCheck = RuntimeHelpers.GetObjectValue(array49(0))
																									End If
																									If Strings.InStr(Conversions.ToString(obj44), Strings.LCase(Me.sAzimuth), CompareMethod.Binary) > 0 Then
																										flag5 = True
																									End If
																									If Me.INCol > 0 And Me.AZCol = 0 Then
																										Me.AZCol = CInt(Me.Column)
																										Me.txtAZCol.Text = Conversions.ToString(Me.sCheck)
																										Me.ColumnRow = CInt(Me.Row)
																										GoTo IL_1E3D
																									End If
																									GoTo IL_1E3D
																								Else
																									Dim flag22 As Boolean = flag7
																									Dim obj45 As Object = Nothing
																									Dim typeFromHandle21 As Type = GetType(Strings)
																									Dim text22 As String = "LCase"
																									array70 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																									Dim array84 As Object() = array70
																									Dim array85 As String() = Nothing
																									Dim array86 As Type() = Nothing
																									array74 = New Boolean() { True }
																									Dim obj46 As Object = NewLateBinding.LateGet(obj45, typeFromHandle21, text22, array84, array85, array86, array74)
																									If array74(0) Then
																										Me.sCheck = RuntimeHelpers.GetObjectValue(array70(0))
																									End If
																									If flag22 = Strings.InStr(Conversions.ToString(obj46), Strings.LCase(Me.sMD), CompareMethod.Binary) > 0 Then
																										Dim obj47 As Object = Nothing
																										Dim typeFromHandle22 As Type = GetType(Strings)
																										Dim text23 As String = "LCase"
																										array49 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																										Dim array87 As Object() = array49
																										Dim array88 As String() = Nothing
																										Dim array89 As Type() = Nothing
																										array48 = New Boolean() { True }
																										Dim obj48 As Object = NewLateBinding.LateGet(obj47, typeFromHandle22, text23, array87, array88, array89, array48)
																										If array48(0) Then
																											Me.sCheck = RuntimeHelpers.GetObjectValue(array49(0))
																										End If
																										Dim flag23 As Boolean = Strings.InStr(Conversions.ToString(obj48), Strings.LCase(Me.sKOMD), CompareMethod.Binary) <= 0
																										Dim obj49 As Object = Nothing
																										Dim typeFromHandle23 As Type = GetType(Strings)
																										Dim text24 As String = "LCase"
																										array56 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																										Dim array90 As Object() = array56
																										Dim array91 As String() = Nothing
																										Dim array92 As Type() = Nothing
																										array43 = New Boolean() { True }
																										Dim obj50 As Object = NewLateBinding.LateGet(obj49, typeFromHandle23, text24, array90, array91, array92, array43)
																										If array43(0) Then
																											Me.sCheck = RuntimeHelpers.GetObjectValue(array56(0))
																										End If
																										If flag23 And Strings.InStr(Conversions.ToString(obj50), Strings.LCase(Me.sMDTie), CompareMethod.Binary) <= 0 Then
																											Dim obj51 As Object = Nothing
																											Dim typeFromHandle24 As Type = GetType(Strings)
																											Dim text25 As String = "LCase"
																											array66 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																											Dim array93 As Object() = array66
																											Dim array94 As String() = Nothing
																											Dim array95 As Type() = Nothing
																											array38 = New Boolean() { True }
																											Dim obj52 As Object = NewLateBinding.LateGet(obj51, typeFromHandle24, text25, array93, array94, array95, array38)
																											If array38(0) Then
																												Me.sCheck = RuntimeHelpers.GetObjectValue(array66(0))
																											End If
																											If Strings.InStr(Conversions.ToString(obj52), Strings.LCase(Me.sMD), CompareMethod.Binary) > 0 Then
																												flag3 = True
																											End If
																											If Me.MDCol = 0 Then
																												Me.MDCol = CInt(Me.Column)
																												Me.txtMDCol.Text = Conversions.ToString(Me.sCheck)
																												Me.ColumnRow = CInt(Me.Row)
																												Me.sCheck2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.sCheck, Nothing, "Replace", New Object() { " ", "" }, Nothing, Nothing, Nothing))
																												Dim obj53 As Object = Nothing
																												Dim typeFromHandle25 As Type = GetType(Strings)
																												Dim text26 As String = "LCase"
																												array70 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																												Dim array96 As Object() = array70
																												Dim array97 As String() = Nothing
																												Dim array98 As Type() = Nothing
																												array74 = New Boolean() { True }
																												Dim obj54 As Object = NewLateBinding.LateGet(obj53, typeFromHandle25, text26, array96, array97, array98, array74)
																												If array74(0) Then
																													Me.sCheck2 = RuntimeHelpers.GetObjectValue(array70(0))
																												End If
																												If Strings.InStr(Conversions.ToString(obj54), "(" + RSWIN_DESC.ft + ")", CompareMethod.Binary) > 0 Then
																													flag = True
																													Me.bEnglish = True
																												Else
																													Dim obj55 As Object = Nothing
																													Dim typeFromHandle26 As Type = GetType(Strings)
																													Dim text27 As String = "LCase"
																													array70 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																													Dim array99 As Object() = array70
																													Dim array100 As String() = Nothing
																													Dim array101 As Type() = Nothing
																													array74 = New Boolean() { True }
																													Dim obj56 As Object = NewLateBinding.LateGet(obj55, typeFromHandle26, text27, array99, array100, array101, array74)
																													If array74(0) Then
																														Me.sCheck2 = RuntimeHelpers.GetObjectValue(array70(0))
																													End If
																													Dim flag24 As Boolean = Strings.InStr(Conversions.ToString(obj56), "(" + RSWIN_DESC.m + ")", CompareMethod.Binary) > 0
																													Dim obj57 As Object = Nothing
																													Dim typeFromHandle27 As Type = GetType(Strings)
																													Dim text28 As String = "LCase"
																													array49 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																													Dim array102 As Object() = array49
																													Dim array103 As String() = Nothing
																													Dim array104 As Type() = Nothing
																													array48 = New Boolean() { True }
																													Dim obj58 As Object = NewLateBinding.LateGet(obj57, typeFromHandle27, text28, array102, array103, array104, array48)
																													If array48(0) Then
																														Me.sCheck2 = RuntimeHelpers.GetObjectValue(array49(0))
																													End If
																													If flag24 Or Strings.InStr(Conversions.ToString(obj58), "(" + Strings.LCase(Me.smKB) + ")", CompareMethod.Binary) > 0 Then
																														flag = True
																														Me.bEnglish = False
																													End If
																												End If
																											End If
																											GoTo IL_1E3D
																										End If
																										GoTo IL_1E3D
																									Else
																										Dim flag25 As Boolean = flag7
																										Dim obj59 As Object = Nothing
																										Dim typeFromHandle28 As Type = GetType(Strings)
																										Dim text29 As String = "LCase"
																										array70 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																										Dim array105 As Object() = array70
																										Dim array106 As String() = Nothing
																										Dim array107 As Type() = Nothing
																										array74 = New Boolean() { True }
																										Dim obj60 As Object = NewLateBinding.LateGet(obj59, typeFromHandle28, text29, array105, array106, array107, array74)
																										If array74(0) Then
																											Me.sCheck = RuntimeHelpers.GetObjectValue(array70(0))
																										End If
																										If flag25 = Strings.InStr(Conversions.ToString(obj60), Strings.LCase(Me.sIncl), CompareMethod.Binary) > 0 Then
																											Dim obj61 As Object = Nothing
																											Dim typeFromHandle29 As Type = GetType(Strings)
																											Dim text30 As String = "LCase"
																											array49 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																											Dim array108 As Object() = array49
																											Dim array109 As String() = Nothing
																											Dim array110 As Type() = Nothing
																											array48 = New Boolean() { True }
																											Dim obj62 As Object = NewLateBinding.LateGet(obj61, typeFromHandle29, text30, array108, array109, array110, array48)
																											If array48(0) Then
																												Me.sCheck = RuntimeHelpers.GetObjectValue(array49(0))
																											End If
																											If Strings.InStr(Conversions.ToString(obj62), Strings.LCase(Me.sIncl), CompareMethod.Binary) > 0 Then
																												flag4 = True
																											End If
																											If Me.MDCol > 0 And Me.INCol = 0 Then
																												Me.INCol = CInt(Me.Column)
																												Me.txtINCol.Text = Conversions.ToString(Me.sCheck)
																												Me.ColumnRow = CInt(Me.Row)
																												GoTo IL_1E3D
																											End If
																											GoTo IL_1E3D
																										Else
																											Dim flag26 As Boolean = flag7
																											Dim obj63 As Object = Nothing
																											Dim typeFromHandle30 As Type = GetType(Strings)
																											Dim text31 As String = "LCase"
																											array70 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																											Dim array111 As Object() = array70
																											Dim array112 As String() = Nothing
																											Dim array113 As Type() = Nothing
																											array74 = New Boolean() { True }
																											Dim obj64 As Object = NewLateBinding.LateGet(obj63, typeFromHandle30, text31, array111, array112, array113, array74)
																											If array74(0) Then
																												Me.sCheck = RuntimeHelpers.GetObjectValue(array70(0))
																											End If
																											If flag26 = Strings.InStr(Conversions.ToString(obj64), Strings.LCase(Me.sInc), CompareMethod.Binary) > 0 Then
																												Dim obj65 As Object = Nothing
																												Dim typeFromHandle31 As Type = GetType(Strings)
																												Dim text32 As String = "LCase"
																												array49 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																												Dim array114 As Object() = array49
																												Dim array115 As String() = Nothing
																												Dim array116 As Type() = Nothing
																												array48 = New Boolean() { True }
																												Dim obj66 As Object = NewLateBinding.LateGet(obj65, typeFromHandle31, text32, array114, array115, array116, array48)
																												If array48(0) Then
																													Me.sCheck = RuntimeHelpers.GetObjectValue(array49(0))
																												End If
																												If Strings.InStr(Conversions.ToString(obj66), Strings.LCase(Me.sInc), CompareMethod.Binary) > 0 Then
																													flag4 = True
																												End If
																												If Me.MDCol > 0 And Me.INCol = 0 Then
																													Me.INCol = CInt(Me.Column)
																													Me.txtINCol.Text = Conversions.ToString(Me.sCheck)
																													Me.ColumnRow = CInt(Me.Row)
																													GoTo IL_1E3D
																												End If
																												GoTo IL_1E3D
																											Else
																												Dim flag27 As Boolean = flag7
																												Dim obj67 As Object = Nothing
																												Dim typeFromHandle32 As Type = GetType(Strings)
																												Dim text33 As String = "LCase"
																												array70 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																												Dim array117 As Object() = array70
																												Dim array118 As String() = Nothing
																												Dim array119 As Type() = Nothing
																												array74 = New Boolean() { True }
																												Dim obj68 As Object = NewLateBinding.LateGet(obj67, typeFromHandle32, text33, array117, array118, array119, array74)
																												If array74(0) Then
																													Me.sCheck = RuntimeHelpers.GetObjectValue(array70(0))
																												End If
																												Dim flag28 As Boolean = Strings.InStr(Conversions.ToString(obj68), Strings.LCase(Me.sAz), CompareMethod.Binary) > 0
																												Dim obj69 As Object = Nothing
																												Dim typeFromHandle33 As Type = GetType(Strings)
																												Dim text34 As String = "LCase"
																												array49 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																												Dim array120 As Object() = array49
																												Dim array121 As String() = Nothing
																												Dim array122 As Type() = Nothing
																												array48 = New Boolean() { True }
																												Dim obj70 As Object = NewLateBinding.LateGet(obj69, typeFromHandle33, text34, array120, array121, array122, array48)
																												If array48(0) Then
																													Me.sCheck = RuntimeHelpers.GetObjectValue(array49(0))
																												End If
																												If flag27 <> (flag28 Or Strings.InStr(Conversions.ToString(obj70), Strings.LCase(Me.sAzm), CompareMethod.Binary) > 0) Then
																													GoTo IL_1E3D
																												End If
																												Dim obj71 As Object = Nothing
																												Dim typeFromHandle34 As Type = GetType(Strings)
																												Dim text35 As String = "LCase"
																												array56 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																												Dim array123 As Object() = array56
																												Dim array124 As String() = Nothing
																												Dim array125 As Type() = Nothing
																												array43 = New Boolean() { True }
																												Dim obj72 As Object = NewLateBinding.LateGet(obj71, typeFromHandle34, text35, array123, array124, array125, array43)
																												If array43(0) Then
																													Me.sCheck = RuntimeHelpers.GetObjectValue(array56(0))
																												End If
																												Dim flag29 As Boolean = Strings.InStr(Conversions.ToString(obj72), Strings.LCase(Me.sAz), CompareMethod.Binary) > 0
																												Dim obj73 As Object = Nothing
																												Dim typeFromHandle35 As Type = GetType(Strings)
																												Dim text36 As String = "LCase"
																												array66 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																												Dim array126 As Object() = array66
																												Dim array127 As String() = Nothing
																												Dim array128 As Type() = Nothing
																												array38 = New Boolean() { True }
																												Dim obj74 As Object = NewLateBinding.LateGet(obj73, typeFromHandle35, text36, array126, array127, array128, array38)
																												If array38(0) Then
																													Me.sCheck = RuntimeHelpers.GetObjectValue(array66(0))
																												End If
																												If flag29 Or Strings.InStr(Conversions.ToString(obj74), Strings.LCase(Me.sAzm), CompareMethod.Binary) > 0 Then
																													flag5 = True
																												End If
																												If Me.INCol > 0 And Me.AZCol = 0 Then
																													Me.AZCol = CInt(Me.Column)
																													Me.txtAZCol.Text = Conversions.ToString(Me.sCheck)
																													Me.ColumnRow = CInt(Me.Row)
																													GoTo IL_1E3D
																												End If
																												GoTo IL_1E3D
																											End If
																										End If
																									End If
																								End If
																							End If
																						End If
																					End If
																				End If
																				Dim obj75 As Object = Nothing
																				Dim typeFromHandle36 As Type = GetType(Strings)
																				Dim text37 As String = "LCase"
																				Dim array129 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																				Dim array130 As Object() = array129
																				Dim array131 As String() = Nothing
																				Dim array132 As Type() = Nothing
																				array33 = New Boolean() { True }
																				Dim obj76 As Object = NewLateBinding.LateGet(obj75, typeFromHandle36, text37, array130, array131, array132, array33)
																				If array33(0) Then
																					Me.sCheck = RuntimeHelpers.GetObjectValue(array129(0))
																				End If
																				Dim flag30 As Boolean = Strings.InStr(Conversions.ToString(obj76), Strings.LCase(Me.sKOMD), CompareMethod.Binary) <= 0
																				Dim obj77 As Object = Nothing
																				Dim typeFromHandle37 As Type = GetType(Strings)
																				Dim text38 As String = "LCase"
																				Dim array133 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																				Dim array134 As Object() = array133
																				Dim array135 As String() = Nothing
																				Dim array136 As Type() = Nothing
																				array28 = New Boolean() { True }
																				Dim obj78 As Object = NewLateBinding.LateGet(obj77, typeFromHandle37, text38, array134, array135, array136, array28)
																				If array28(0) Then
																					Me.sCheck = RuntimeHelpers.GetObjectValue(array133(0))
																				End If
																				If flag30 And Strings.InStr(Conversions.ToString(obj78), Strings.LCase(Me.sMDTie), CompareMethod.Binary) <= 0 Then
																					Dim obj79 As Object = Nothing
																					Dim typeFromHandle38 As Type = GetType(Strings)
																					Dim text39 As String = "LCase"
																					Dim array137 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																					Dim array138 As Object() = array137
																					Dim array139 As String() = Nothing
																					Dim array140 As Type() = Nothing
																					array23 = New Boolean() { True }
																					Dim obj80 As Object = NewLateBinding.LateGet(obj79, typeFromHandle38, text39, array138, array139, array140, array23)
																					If array23(0) Then
																						Me.sCheck = RuntimeHelpers.GetObjectValue(array137(0))
																					End If
																					Dim flag31 As Boolean = Strings.InStr(Conversions.ToString(obj80), Strings.LCase(Me.sMeasured), CompareMethod.Binary) > 0
																					Dim obj81 As Object = Nothing
																					Dim typeFromHandle39 As Type = GetType(Strings)
																					Dim text40 As String = "LCase"
																					array6 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																					Dim array141 As Object() = array6
																					Dim array142 As String() = Nothing
																					Dim array143 As Type() = Nothing
																					array5 = New Boolean() { True }
																					Dim obj82 As Object = NewLateBinding.LateGet(obj81, typeFromHandle39, text40, array141, array142, array143, array5)
																					If array5(0) Then
																						Me.sCheck = RuntimeHelpers.GetObjectValue(array6(0))
																					End If
																					Dim flag32 As Boolean = flag31 Or Strings.InStr(Conversions.ToString(obj82), Strings.LCase(Me.sMeasured2), CompareMethod.Binary) > 0
																					Dim obj83 As Object = Nothing
																					Dim typeFromHandle40 As Type = GetType(Strings)
																					Dim text41 As String = "LCase"
																					Dim array144 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																					Dim array145 As Object() = array144
																					Dim array146 As String() = Nothing
																					Dim array147 As Type() = Nothing
																					Dim array74 As Boolean() = New Boolean() { True }
																					Dim obj84 As Object = NewLateBinding.LateGet(obj83, typeFromHandle40, text41, array145, array146, array147, array74)
																					If array74(0) Then
																						Me.sCheck = RuntimeHelpers.GetObjectValue(array144(0))
																					End If
																					If flag32 Or Strings.InStr(Conversions.ToString(obj84), Strings.LCase(Me.sMeasured3), CompareMethod.Binary) > 0 Then
																						flag3 = True
																					End If
																					If Me.MDCol = 0 Then
																						Me.MDCol = CInt(Me.Column)
																						Me.txtMDCol.Text = Conversions.ToString(Me.sCheck)
																						Me.ColumnRow = CInt(Me.Row)
																						Me.sCheck2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.sCheck, Nothing, "Replace", New Object() { " ", "" }, Nothing, Nothing, Nothing))
																						Dim obj85 As Object = Nothing
																						Dim typeFromHandle41 As Type = GetType(Strings)
																						Dim text42 As String = "LCase"
																						Dim array70 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																						Dim array148 As Object() = array70
																						Dim array149 As String() = Nothing
																						Dim array150 As Type() = Nothing
																						array74 = New Boolean() { True }
																						Dim obj86 As Object = NewLateBinding.LateGet(obj85, typeFromHandle41, text42, array148, array149, array150, array74)
																						If array74(0) Then
																							Me.sCheck2 = RuntimeHelpers.GetObjectValue(array70(0))
																						End If
																						If Strings.InStr(Conversions.ToString(obj86), "(" + RSWIN_DESC.ft + ")", CompareMethod.Binary) > 0 Then
																							flag = True
																							Me.bEnglish = True
																						Else
																							Dim obj87 As Object = Nothing
																							Dim typeFromHandle42 As Type = GetType(Strings)
																							Dim text43 As String = "LCase"
																							array70 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																							Dim array151 As Object() = array70
																							Dim array152 As String() = Nothing
																							Dim array153 As Type() = Nothing
																							array74 = New Boolean() { True }
																							Dim obj88 As Object = NewLateBinding.LateGet(obj87, typeFromHandle42, text43, array151, array152, array153, array74)
																							If array74(0) Then
																								Me.sCheck2 = RuntimeHelpers.GetObjectValue(array70(0))
																							End If
																							Dim flag33 As Boolean = Strings.InStr(Conversions.ToString(obj88), "(" + RSWIN_DESC.m + ")", CompareMethod.Binary) > 0
																							Dim obj89 As Object = Nothing
																							Dim typeFromHandle43 As Type = GetType(Strings)
																							Dim text44 As String = "LCase"
																							array49 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																							Dim array154 As Object() = array49
																							Dim array155 As String() = Nothing
																							Dim array156 As Type() = Nothing
																							array48 = New Boolean() { True }
																							Dim obj90 As Object = NewLateBinding.LateGet(obj89, typeFromHandle43, text44, array154, array155, array156, array48)
																							If array48(0) Then
																								Me.sCheck2 = RuntimeHelpers.GetObjectValue(array49(0))
																							End If
																							If flag33 Or Strings.InStr(Conversions.ToString(obj90), "(" + Strings.LCase(Me.smKB) + ")", CompareMethod.Binary) > 0 Then
																								flag = True
																								Me.bEnglish = False
																							End If
																						End If
																					End If
																				End If
																			End If
																		End If
																	End If
																End If
															End If
															IL_1E3D:
															Me.Column += 1L
														Catch ex5 As Exception
															Me.bContinueCol = False
														End Try
													End While
													Me.Column = 1L
													Me.Row += 1L
												Catch ex6 As Exception
													Me.bContinueRow = False
													Me.Row = 1L
												End Try
											End While
											If Not flag2 And Not flag3 And Not flag4 And Not flag5 Then
												Return False
											End If

												Me.Row = CLng(Me.ColumnRow)
												Me.Column = CLng(Me.MDCol)
												Me.bContinue = True

											If Not flag Then
												While Me.bContinue And Me.Row < 250000L
													Me.Row += 1L
													Dim num As Integer = 0
													Dim num2 As Integer = 0
													While Me.Column < 10L
														Try
															Try
																Me.sCheck = RuntimeHelpers.GetObjectValue(Me.GetSpreadSheetValue(CInt(Me.Row), CInt(Me.Column)))
																If Me.sCheck IsNot Nothing Then
																End If
															Catch ex7 As Exception
															End Try
															If Me.sCheck Is Nothing Then
																num += 1
															ElseIf Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.sCheck)).Trim(), "", False) = 0 Then
																num += 1
															Else
																num2 += 1
															End If
														Catch ex8 As Exception
														End Try
														Try
															If Me.sCheck IsNot Nothing Then
																If Not Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.sCheck)) Then
																	Me.sCheck2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.sCheck, Nothing, "Replace", New Object() { " ", "" }, Nothing, Nothing, Nothing))
																	Dim obj91 As Object = Nothing
																	Dim typeFromHandle44 As Type = GetType(Strings)
																	Dim text45 As String = "LCase"
																	Dim array70 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																	Dim array157 As Object() = array70
																	Dim array158 As String() = Nothing
																	Dim array159 As Type() = Nothing
																	Dim array74 As Boolean() = New Boolean() { True }
																	Dim obj92 As Object = NewLateBinding.LateGet(obj91, typeFromHandle44, text45, array157, array158, array159, array74)
																	If array74(0) Then
																		Me.sCheck2 = RuntimeHelpers.GetObjectValue(array70(0))
																	End If
																	Dim flag34 As Boolean = Strings.InStr(Conversions.ToString(obj92), Strings.LCase(Me.sKOMD), CompareMethod.Binary) <= 0
																	Dim obj93 As Object = Nothing
																	Dim typeFromHandle45 As Type = GetType(Strings)
																	Dim text46 As String = "LCase"
																	Dim array49 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																	Dim array160 As Object() = array49
																	Dim array161 As String() = Nothing
																	Dim array162 As Type() = Nothing
																	Dim array48 As Boolean() = New Boolean() { True }
																	Dim obj94 As Object = NewLateBinding.LateGet(obj93, typeFromHandle45, text46, array160, array161, array162, array48)
																	If array48(0) Then
																		Me.sCheck2 = RuntimeHelpers.GetObjectValue(array49(0))
																	End If
																	If flag34 And Strings.InStr(Conversions.ToString(obj94), Strings.LCase(Me.sMDTie), CompareMethod.Binary) <= 0 Then
																		Dim flag35 As Boolean = True
																		Dim flag36 As Boolean = flag35
																		Dim obj95 As Object = Nothing
																		Dim typeFromHandle46 As Type = GetType(Strings)
																		Dim text47 As String = "LCase"
																		Dim array56 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																		Dim array163 As Object() = array56
																		Dim array164 As String() = Nothing
																		Dim array165 As Type() = Nothing
																		Dim array43 As Boolean() = New Boolean() { True }
																		Dim obj96 As Object = NewLateBinding.LateGet(obj95, typeFromHandle46, text47, array163, array164, array165, array43)
																		If array43(0) Then
																			Me.sCheck2 = RuntimeHelpers.GetObjectValue(array56(0))
																		End If
																		If flag36 <> Strings.InStr(Conversions.ToString(obj96), "(" + RSWIN_DESC.ft + ")", CompareMethod.Binary) > 0 Then
																			Dim flag37 As Boolean = flag35
																			Dim obj97 As Object = Nothing
																			Dim typeFromHandle47 As Type = GetType(Strings)
																			Dim text48 As String = "LCase"
																			Dim array66 As Object() = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																			Dim array166 As Object() = array66
																			Dim array167 As String() = Nothing
																			Dim array168 As Type() = Nothing
																			Dim array38 As Boolean() = New Boolean() { True }
																			Dim obj98 As Object = NewLateBinding.LateGet(obj97, typeFromHandle47, text48, array166, array167, array168, array38)
																			If array38(0) Then
																				Me.sCheck = RuntimeHelpers.GetObjectValue(array66(0))
																			End If
																			If flag37 <> Strings.InStr(Conversions.ToString(obj98), "feet", CompareMethod.Binary) > 0 Then
																				Dim flag38 As Boolean = flag35
																				Dim obj99 As Object = Nothing
																				Dim typeFromHandle48 As Type = GetType(Strings)
																				Dim text49 As String = "LCase"
																				array70 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																				Dim array169 As Object() = array70
																				Dim array170 As String() = Nothing
																				Dim array171 As Type() = Nothing
																				array74 = New Boolean() { True }
																				Dim obj100 As Object = NewLateBinding.LateGet(obj99, typeFromHandle48, text49, array169, array170, array171, array74)
																				If array74(0) Then
																					Me.sCheck2 = RuntimeHelpers.GetObjectValue(array70(0))
																				End If
																				If flag38 <> Strings.InStr(Conversions.ToString(obj100), "(" + RSWIN_DESC.m + ")", CompareMethod.Binary) > 0 Then
																					Dim flag39 As Boolean = flag35
																					Dim obj101 As Object = Nothing
																					Dim typeFromHandle49 As Type = GetType(Strings)
																					Dim text50 As String = "LCase"
																					array49 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																					Dim array172 As Object() = array49
																					Dim array173 As String() = Nothing
																					Dim array174 As Type() = Nothing
																					array48 = New Boolean() { True }
																					Dim obj102 As Object = NewLateBinding.LateGet(obj101, typeFromHandle49, text50, array172, array173, array174, array48)
																					If array48(0) Then
																						Me.sCheck = RuntimeHelpers.GetObjectValue(array49(0))
																					End If
																					If flag39 <> Strings.InStr(Conversions.ToString(obj102), "( m )", CompareMethod.Binary) > 0 Then
																						Dim flag40 As Boolean = flag35
																						Dim obj103 As Object = Nothing
																						Dim typeFromHandle50 As Type = GetType(Strings)
																						Dim text51 As String = "LCase"
																						array56 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck) }
																						Dim array175 As Object() = array56
																						Dim array176 As String() = Nothing
																						Dim array177 As Type() = Nothing
																						array43 = New Boolean() { True }
																						Dim obj104 As Object = NewLateBinding.LateGet(obj103, typeFromHandle50, text51, array175, array176, array177, array43)
																						If array43(0) Then
																							Me.sCheck = RuntimeHelpers.GetObjectValue(array56(0))
																						End If
																						If flag40 <> Strings.InStr(Conversions.ToString(obj104), "meter", CompareMethod.Binary) > 0 Then
																							Dim flag41 As Boolean = flag35
																							Dim obj105 As Object = Nothing
																							Dim typeFromHandle51 As Type = GetType(Strings)
																							Dim text52 As String = "LCase"
																							array66 = New Object() { RuntimeHelpers.GetObjectValue(Me.sCheck2) }
																							Dim array178 As Object() = array66
																							Dim array179 As String() = Nothing
																							Dim array180 As Type() = Nothing
																							array38 = New Boolean() { True }
																							Dim obj106 As Object = NewLateBinding.LateGet(obj105, typeFromHandle51, text52, array178, array179, array180, array38)
																							If array38(0) Then
																								Me.sCheck2 = RuntimeHelpers.GetObjectValue(array66(0))
																							End If
																							If flag41 <> Strings.InStr(Conversions.ToString(obj106), "(" + Strings.LCase(Me.smKB) + ")", CompareMethod.Binary) > 0 Then
																								GoTo IL_240B
																							End If
																						End If
																					End If
																				End If
																				Me.m_bEnglish = False
																				Me.bContinue = False
																				Exit Try
																			End If
																		End If
																		Me.m_bEnglish = True
																		Me.bContinue = False
																		Exit Try
																	End If
																Else
																	Me.bContinue = False
																End If
															End If
															IL_240B:
															Me.Column += 1L
														Catch ex9 As Exception
															Me.bContinue = False
														End Try
													End While
												End While
											End If
											If Me.Row >= 250000L Then
												Me.bContinue = False
												Return False
											End If
											Me.Column = CLng(Me.MDCol)
											Me.iNullCount = 0
											Me.FirstDataRow = 0
											Me.LastDataRow = 0
											Me.bContinue = True
											While Me.bContinue And Me.Row < 250000L
												Try
													Me.Row += 1L
													Try
														Me.sCheck = RuntimeHelpers.GetObjectValue(Me.GetSpreadSheetValue(CInt(Me.Row), CInt(Me.Column)))
														If Me.sCheck IsNot Nothing Then
														End If
													Catch ex10 As Exception
													End Try
													If Me.sCheck IsNot Nothing Then
														If Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.sCheck)).Trim(), "", False) = 0 Then
															Me.iNullCount += 1
															If Me.iNullCount > 5 Then
																Me.bContinue = False
															End If
														ElseIf Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.sCheck)) And Me.FirstDataRow = 0 Then
															Me.FirstDataRow = CInt(Me.Row)
															Me.iNullCount = 0
														ElseIf Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.sCheck)) Then
															Me.LastDataRow = CInt(Me.Row)
															Me.iNullCount = 0
														ElseIf Not Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.sCheck)) Then
															If Me.sCheck IsNot Nothing Then
																Me.iNullCount = 0
																Me.sCheck = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.sCheck, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing))
																If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.sCheck, "", False))) Then
																	Me.bContinue = False
																End If
															End If
														End If
													Else
														Me.iNullCount += 1
														If Me.iNullCount > 5 Then
															Me.bContinue = False
														End If
													End If
												Catch ex11 As Exception
													Me.bContinue = False
												End Try
											End While
											If Me.Row >= 250000L Then
												Me.bContinue = False
												Return False
											End If
											Me.txtMDRange.Text = String.Concat(New String() { Conversions.ToString(Strings.Chr(64 + Me.MDCol)), Me.FirstDataRow.ToString(), ":", Conversions.ToString(Strings.Chr(64 + Me.MDCol)), Me.LastDataRow.ToString() })
											Me.txtINRange.Text = String.Concat(New String() { Conversions.ToString(Strings.Chr(64 + Me.INCol)), Me.FirstDataRow.ToString(), ":", Conversions.ToString(Strings.Chr(64 + Me.INCol)), Me.LastDataRow.ToString() })
											Me.txtAZRange.Text = String.Concat(New String() { Conversions.ToString(Strings.Chr(64 + Me.AZCol)), Me.FirstDataRow.ToString(), ":", Conversions.ToString(Strings.Chr(64 + Me.AZCol)), Me.LastDataRow.ToString() })
											Me.txtMDPos.Text = Me.MDCol.ToString()
											Me.txtINPos.Text = Me.INCol.ToString()
											Me.txtAZPos.Text = Me.AZCol.ToString()
											Me.lblSurveyType.Text = Me.sType
											Me.NumRows = Me.LastDataRow - Me.FirstDataRow + 1
											Me.txtNumPoints.Text = Conversions.ToString(Me.LastDataRow - Me.FirstDataRow + 1)
											If Me.m_bEnglish Then
												Me.rbtEnglish.Checked = True
											Else
												Me.rbtMetric.Checked = True
											End If
											Dim flag42 As Boolean = True
											If flag42 = Strings.InStr(Strings.UCase(Me.sType), "SPERRY", CompareMethod.Binary) > 0 Then
												Me.lblSurveyType.Text = "Survey Type: Sperry-Sun"
												If Operators.CompareString(Me.txtMDCol.Text.Trim(), "MEASURED", False) = 0 Then
													Me.txtMDCol.Text = "MEASURED DEPTH"
												End If
											ElseIf flag42 = Strings.InStr(Strings.UCase(Me.sType), "SCHLUMBERGER", CompareMethod.Binary) > 0 Then
												Me.lblSurveyType.Text = "Survey Type: Schlumberger"
												If Operators.CompareString(Me.txtMDCol.Text.Trim(), "Measured", False) = 0 Then
													Me.txtMDCol.Text = "Measured Depth"
												End If
											ElseIf flag42 = Strings.InStr(Strings.UCase(Me.sType), "ANADRILL", CompareMethod.Binary) > 0 Then
												Me.lblSurveyType.Text = "Survey Type: Anadrill"
											Else
												Me.lblSurveyType.Text = ""
											End If
										End If
									Next
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
							End If
							NewLateBinding.LateCall(Me.oWB, Nothing, "Close", New Object() { False }, New String() { "SaveChanges" }, Nothing, Nothing, True)
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				Catch ex12 As Exception
					MessageBox.Show(String.Concat(New String() { Me.sCouldNotReadData, Me.sExcelFile, ", (", ex12.Message, ")." }))
					Return False
				End Try
				Try
					Me.NAR(RuntimeHelpers.GetObjectValue(Me.oSheet), True)
					Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWB), True)
					Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWBs), True)
					NewLateBinding.LateCall(Me.oXLApp, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
					Me.NAR(RuntimeHelpers.GetObjectValue(Me.oXLApp), True)
					Thread.Sleep(1000)
				Catch ex13 As Exception
				End Try
				result = True
			Catch ex14 As Exception
				MessageBox.Show("Error in Sub XLWorkSheetOpenReadClose_Find: " + ex14.Message)
				NewLateBinding.LateCall(Me.oXLApp, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
			End Try
			Return result
		End Function

		Public Function XLWorkSheetOpenReadClose_Find_WB_Names() As Boolean
			Try
				Me.oXLApp = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application", ""))
			Catch ex As Exception
				MessageBox.Show(Me.sCouldNotCreateExcelApp + ex.Message + ").")
				Return False
			End Try
			Try
				NewLateBinding.LateSet(Me.oXLApp, Nothing, "Visible", New Object() { False }, Nothing, Nothing)
				NewLateBinding.LateSet(Me.oXLApp, Nothing, "UserControl", New Object() { False }, Nothing, Nothing)
			Catch ex2 As Exception
			End Try
			Try
				Dim obj As Object = NewLateBinding.LateGet(Me.oXLApp, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing)
				Dim type As Type = Nothing
				Dim text As String = "Open"
				Dim array As Object() = New Object() { Me.sExcelFile, False, True }
				Dim array2 As Object() = array
				Dim array3 As String() = New String() { "FileName", "UpdateLinks", "ReadOnly" }
				Dim array4 As Type() = Nothing
				Dim array5 As Boolean() = New Boolean() { True, False, False }
				Dim obj2 As Object = NewLateBinding.LateGet(obj, type, text, array2, array3, array4, array5)
				If array5(0) Then
					Me.sExcelFile = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(String)))
				End If
				Me.oWBs = RuntimeHelpers.GetObjectValue(obj2)
			Catch ex3 As Exception
				MessageBox.Show(String.Concat(New String() { Me.sCouldNotOpenExcelFile, Me.sExcelFile, ", (", ex3.Message, ")." }))
				Return False
			End Try
			Try
				Dim num As Integer = 0
				Me.iSS = 0
				Me.iWB = 0
				Me.cboWB.Items.Clear()
				Try
					For Each obj3 As Object In CType(NewLateBinding.LateGet(Me.oXLApp, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable)
						Me.oWB = RuntimeHelpers.GetObjectValue(obj3)
						Me.iWB += 1
						Me.sWB(Me.iWB) = Conversions.ToString(NewLateBinding.LateGet(Me.oWB, Nothing, "Name", New Object(-1) {}, Nothing, Nothing, Nothing))
						Me.cboWB.Items.Add(Me.sWB(Me.iWB))
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If Me.iWB > 1 Then
					Me.cboSpreadSheets.Items.Clear()
					Me.cboSpreadSheets.Enabled = False
					Me.cboWB.Enabled = True
					Me.cboWB.SelectedIndex = 0
					Me.sSelectedWB = Me.sWB(1)
				Else
					Me.cboSpreadSheets.Items.Clear()
					Me.cboSpreadSheets.Enabled = True
					Me.cboWB.SelectedIndex = 0
					Me.cboWB.Enabled = False
					Me.sSelectedWB = Me.sWB(1)
				End If
				Try
					For Each obj4 As Object In CType(NewLateBinding.LateGet(Me.oXLApp, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable)
						Me.oWB = RuntimeHelpers.GetObjectValue(obj4)
						If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.oWB, Nothing, "Name", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), Me.sSelectedWB.Trim(), False) Then
							Try
								For Each obj5 As Object In CType(NewLateBinding.LateGet(Me.oWB, Nothing, "Worksheets", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable)
									Me.oSheet = RuntimeHelpers.GetObjectValue(obj5)
									num += 1
									Me.sSS = CType(Utils.CopyArray(CType(Me.sSS, Array), New String(num + 1 - 1) {}), String())
									Me.sSS(num) = Conversions.ToString(NewLateBinding.LateGet(Me.oSheet, Nothing, "Name", New Object(-1) {}, Nothing, Nothing, Nothing))
									Me.iSS += 1
								Next
							Finally
								Dim enumerator3 As IEnumerator
								If TypeOf enumerator3 Is IDisposable Then
									TryCast(enumerator3, IDisposable).Dispose()
								End If
							End Try
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
				Me.cboSpreadSheets.Items.Clear()
				Dim num2 As Integer = 1
				Dim num3 As Integer = Information.UBound(Me.sSS, 1)
				For i As Integer = num2 To num3
					Me.cboSpreadSheets.Items.Add(Me.sSS(i))
				Next
				Me.cboSpreadSheets.SelectedIndex = 0
				Me.sSelectedSS = Me.sSS(1)
			Catch ex4 As Exception
				MessageBox.Show(Me.sErrorSearchingWorkbooks + " (" + ex4.Message + ").")
				Return False
			End Try
			Try
				Me.NAR(RuntimeHelpers.GetObjectValue(Me.oSheet), True)
				Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWB), True)
				Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWBs), True)
				NewLateBinding.LateCall(Me.oXLApp, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
				Me.NAR(RuntimeHelpers.GetObjectValue(Me.oXLApp), True)
				Thread.Sleep(1000)
			Catch ex5 As Exception
			End Try
			Return True
		End Function

		Public Function XLWorkSheetOpenReadClose_Find_SS_Names() As Boolean
			Try
				Me.oXLApp = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application", ""))
			Catch ex As Exception
				MessageBox.Show(Me.sCouldNotCreateExcelApp + ex.Message + ").")
				Return False
			End Try
			Try
				NewLateBinding.LateSet(Me.oXLApp, Nothing, "Visible", New Object() { False }, Nothing, Nothing)
				NewLateBinding.LateSet(Me.oXLApp, Nothing, "UserControl", New Object() { False }, Nothing, Nothing)
			Catch ex2 As Exception
			End Try
			Try
				Dim obj As Object = NewLateBinding.LateGet(Me.oXLApp, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing)
				Dim type As Type = Nothing
				Dim text As String = "Open"
				Dim array As Object() = New Object() { Me.sExcelFile, False, True }
				Dim array2 As Object() = array
				Dim array3 As String() = New String() { "FileName", "UpdateLinks", "ReadOnly" }
				Dim array4 As Type() = Nothing
				Dim array5 As Boolean() = New Boolean() { True, False, False }
				Dim obj2 As Object = NewLateBinding.LateGet(obj, type, text, array2, array3, array4, array5)
				If array5(0) Then
					Me.sExcelFile = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(String)))
				End If
				Me.oWBs = RuntimeHelpers.GetObjectValue(obj2)
			Catch ex3 As Exception
				MessageBox.Show(Me.sCouldNotCreateExcelApp + ex3.Message + ").")
				Return False
			End Try
			Dim num As Integer = 0
			Me.iSS = 0
			Try
				Try
					For Each obj3 As Object In CType(NewLateBinding.LateGet(Me.oXLApp, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable)
						Me.oWB = RuntimeHelpers.GetObjectValue(obj3)
						If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.oWB, Nothing, "Name", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), Me.sSelectedWB.Trim(), False) Then
							Try
								For Each obj4 As Object In CType(NewLateBinding.LateGet(Me.oWB, Nothing, "Worksheets", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable)
									Me.oSheet = RuntimeHelpers.GetObjectValue(obj4)
									num += 1
									Me.sSS = CType(Utils.CopyArray(CType(Me.sSS, Array), New String(num + 1 - 1) {}), String())
									Me.sSS(num) = Conversions.ToString(NewLateBinding.LateGet(Me.oSheet, Nothing, "Name", New Object(-1) {}, Nothing, Nothing, Nothing))
									Me.iSS += 1
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex4 As Exception
				MessageBox.Show(Me.sCouldReadSS + " (" + ex4.Message + ").")
				Return False
			End Try
			Try
				Me.NAR(RuntimeHelpers.GetObjectValue(Me.oSheet), True)
				Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWB), True)
				Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWBs), True)
				NewLateBinding.LateCall(Me.oXLApp, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
				Me.NAR(RuntimeHelpers.GetObjectValue(Me.oXLApp), True)
				Thread.Sleep(1000)
			Catch ex5 As Exception
			End Try
			Return True
		End Function

		Private Sub NAR(o As Object, Optional bShowError As Boolean = True)
			Try
				Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(o))
			Catch ex As Exception
				If bShowError Then
					MessageBox.Show("Error in NAR: " + ex.Message)
				End If
			Finally
				o = Nothing
			End Try
		End Sub

		Public Sub SelectInputFile(ByRef sFileName As String, ByRef sInitialDir As String, sDescList As String, iIndex As Integer, sInitFileName As String, sDialogTitle As String)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			Dim openFileDialog2 As OpenFileDialog = openFileDialog
			openFileDialog2.Multiselect = False
			openFileDialog2.Title = sDialogTitle
			openFileDialog2.FileName = sInitFileName
			openFileDialog2.InitialDirectory = ""
			openFileDialog2.RestoreDirectory = False
			openFileDialog2.Filter = sDescList
			openFileDialog2.FilterIndex = iIndex
			openFileDialog2.ShowDialog()
			Try
				sFileName = openFileDialog2.FileNames(0)
			Catch ex As Exception
				sFileName = ""
			End Try
		End Sub

		Private Sub cmdBrowse_0_Click(sender As Object, e As EventArgs)
			Me.sExcelFile = ""
			Dim text As String = ""
			Me.SelectInputFile(Me.sExcelFile, text, "Excel Files (*.XLS,*.XLSX)|*.xls;*.xlsx", 1, "", "Import File")
			Me.txtExcel.Text = Me.sExcelFile
			Me.ResetClock()
		End Sub

		Public Sub UnbusyCursor()
			Cursor.Current = Cursors.[Default]
		End Sub

		Public Sub BusyCursor()
			Cursor.Current = Cursors.WaitCursor
		End Sub

		Private Sub txtExcel_Enter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub txtExcel_Leave(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub txtExcel_Resize(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtExcel_TextChanged(sender As Object, e As EventArgs)
			Me.sExcelFile = Me.txtExcel.Text
			If Operators.CompareString(Me.txtExcel.Text, "", False) = 0 Then
				Me.cmdNext.Enabled = False
			Else
				Me.cmdNext.Enabled = True
			End If
			Me.ResetClock()
		End Sub

		Public Function XLWorkSheetOpenReadClose() As Boolean
			' The following expression was wrapped in a checked-statement
			Me.rgAzimuth = New String(Me.NumRows + 1 - 1) {}
			Me.rgDepth = New Double(Me.NumRows + 1 - 1) {}
			Me.rgIncl = New String(Me.NumRows + 1 - 1) {}
			Dim result As Boolean
			Try
				Try
					Me.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
				Catch ex As Exception
				End Try
				Try
					Me.oXLApp = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application", ""))
				Catch ex2 As Exception
					MessageBox.Show(Me.sCouldNotCreateExcelApp + ex2.Message + ").")
					Return False
				End Try
				Try
					NewLateBinding.LateSet(Me.oXLApp, Nothing, "Visible", New Object() { False }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.oXLApp, Nothing, "UserControl", New Object() { False }, Nothing, Nothing)
				Catch ex3 As Exception
				End Try
				Try
					Dim obj As Object = NewLateBinding.LateGet(Me.oXLApp, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing)
					Dim type As Type = Nothing
					Dim text As String = "Open"
					Dim array As Object() = New Object() { Me.sExcelFile, False, True }
					Dim array2 As Object() = array
					Dim array3 As String() = New String() { "FileName", "UpdateLinks", "ReadOnly" }
					Dim array4 As Type() = Nothing
					Dim array5 As Boolean() = New Boolean() { True, False, False }
					Dim obj2 As Object = NewLateBinding.LateGet(obj, type, text, array2, array3, array4, array5)
					If array5(0) Then
						Me.sExcelFile = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(String)))
					End If
					Me.oWBs = RuntimeHelpers.GetObjectValue(obj2)
				Catch ex4 As Exception
					MessageBox.Show(String.Concat(New String() { Me.sCouldNotOpenExcelFile, Me.sExcelFile, ", (", ex4.Message, ")." }))
					Return False
				End Try
				Try
					Try
						For Each obj3 As Object In CType(NewLateBinding.LateGet(Me.oXLApp, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable)
							Me.oWB = RuntimeHelpers.GetObjectValue(obj3)
							If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.oWB, Nothing, "Name", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), Me.sSelectedWB.Trim(), False) Then
								Try
									For Each obj4 As Object In CType(NewLateBinding.LateGet(Me.oWB, Nothing, "Worksheets", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable)
										Me.oSheet = RuntimeHelpers.GetObjectValue(obj4)
										If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.oSheet, Nothing, "Name", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), Me.sSelectedSS.Trim(), False) Then
											Dim num As Long

												Dim column As Long = CLng(Me.MDCol)
												num = CLng(Me.AZCol)
												Me.Column = column

											While Me.Column <= num
												Try
													Me.sCheck = RuntimeHelpers.GetObjectValue(Me.GetSpreadSheetValue(CInt(Me.Row), CInt(Me.Column)))
													Dim obj5 As Object = Me.sCheck
												Catch ex5 As Exception
												End Try
												Dim num2 As Long

													Dim row As Long = CLng(Me.FirstDataRow)
													num2 = CLng(Me.LastDataRow)
													Me.Row = row

												While Me.Row <= num2
													Try
														Me.sCheck = RuntimeHelpers.GetObjectValue(Me.GetSpreadSheetValue(CInt(Me.Row), CInt(Me.Column)))
														Dim obj6 As Object = Me.sCheck
													Catch ex6 As Exception
													End Try
													If Me.sCheck IsNot Nothing Then
														If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.sCheck)) Then
															Dim column2 As Long = Me.Column
															If column2 = CLng(Me.MDCol) Then
																Try
																	' The following expression was wrapped in a unchecked-expression
																	Me.rgDepth(CInt((Me.Row - CLng(Me.FirstDataRow)))) = Conversions.ToDouble(Me.sCheck)
																	GoTo IL_571
																Catch ex7 As Exception
																	GoTo IL_571
																End Try
															End If
															If column2 = CLng(Me.INCol) Then
																Try
																	' The following expression was wrapped in a unchecked-expression
																	Me.rgIncl(CInt((Me.Row - CLng(Me.FirstDataRow)))) = Conversions.ToString(Me.sCheck)
																	GoTo IL_571
																Catch ex8 As Exception
																	GoTo IL_571
																End Try
															End If
															If column2 = CLng(Me.AZCol) Then
																Try
																	' The following expression was wrapped in a unchecked-expression
																	Me.rgAzimuth(CInt((Me.Row - CLng(Me.FirstDataRow)))) = Conversions.ToString(Me.sCheck)
																Catch ex9 As Exception
																End Try
															End If
														ElseIf Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(Me.sCheck, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), "", False))) Then
															Dim column3 As Long = Me.Column
															If column3 = CLng(Me.INCol) Then
																Try
																	' The following expression was wrapped in a unchecked-expression
																	Me.rgIncl(CInt((Me.Row - CLng(Me.FirstDataRow)))) = Conversions.ToString(Me.sCheck)
																	GoTo IL_571
																Catch ex10 As Exception
																	GoTo IL_571
																End Try
															End If
															If column3 = CLng(Me.AZCol) Then
																Try
																	' The following expression was wrapped in a unchecked-expression
																	Me.rgAzimuth(CInt((Me.Row - CLng(Me.FirstDataRow)))) = Conversions.ToString(Me.sCheck)
																Catch ex11 As Exception
																End Try
															End If
														End If
													End If
													IL_571:
													Me.Row += 1L
												End While
												Me.Column += 1L
											End While
										End If
									Next
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
							End If
							NewLateBinding.LateCall(Me.oWB, Nothing, "Close", New Object() { False }, New String() { "SaveChanges" }, Nothing, Nothing, True)
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				Catch ex12 As Exception
					MessageBox.Show(String.Concat(New String() { Me.sCouldNotReadData, Me.sExcelFile, ", (", ex12.Message, ")." }))
					Return False
				End Try
				Try
					Me.NAR(RuntimeHelpers.GetObjectValue(Me.oSheet), True)
					Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWB), True)
					Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWBs), True)
					NewLateBinding.LateCall(Me.oXLApp, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
					Me.NAR(RuntimeHelpers.GetObjectValue(Me.oXLApp), True)
					Thread.Sleep(1000)
				Catch ex13 As Exception
				End Try
				Dim num3 As Single = Conversions.ToSingle(Interaction.IIf(Me.bEnglish, 1, 1F / RSWIN_DESC.FT__M))
				Try
					If Me.NumRows > 2 AndAlso Me.rgDepth(0) <> 0.0 Then
						Me.NumRows += 1
						Me.rgAzimuth = CType(Utils.CopyArray(CType(Me.rgAzimuth, Array), New String(Me.NumRows + 1 - 1) {}), String())
						Me.rgDepth = CType(Utils.CopyArray(CType(Me.rgDepth, Array), New Double(Me.NumRows + 1 - 1) {}), Double())
						Me.rgIncl = CType(Utils.CopyArray(CType(Me.rgIncl, Array), New String(Me.NumRows + 1 - 1) {}), String())
						For i As Integer = Me.NumRows - 1 To 1 Step -1
							Me.rgAzimuth(i) = Me.rgAzimuth(i - 1)
							Me.rgDepth(i) = Me.rgDepth(i - 1)
							Me.rgIncl(i) = Me.rgIncl(i - 1)
						Next
						Me.rgAzimuth(0) = Conversions.ToString(0)
						Me.rgDepth(0) = 0.0
						Me.rgIncl(0) = Conversions.ToString(0)
					End If
				Catch ex14 As Exception
				End Try
				Dim flag As Boolean = False
				Dim mdsDeviationProfile As DataSet = RSWIN_DESC.mdsDeviationProfile
				Dim num4 As Integer = 0
				Dim num5 As Integer = Me.NumRows - 1
				For i As Integer = num4 To num5
					If(Not flag And Me.rgDepth(i) = 0.0) Or Me.rgDepth(i) <> 0.0 Then
						Me.r = RSWIN_DESC.mdsDeviationProfile.Tables(0).NewRow()
						Me.r("EntryNumber") = i + 1
						Me.r("Depth") = Me.rgDepth(i) * CDbl(num3)
						If Not flag And Me.rgDepth(i) = 0.0 Then
							flag = True
						End If
						Me.r("Inclination") = Me.rgIncl(i)
						Me.r("Azimuth") = Me.rgAzimuth(i)
						Me.r("Dogleg") = DBNull.Value
						Me.r("TVDepth") = DBNull.Value
						Me.r("NorthSouth") = DBNull.Value
						Me.r("EastWest") = DBNull.Value
						mdsDeviationProfile.Tables(0).Rows.Add(Me.r)
					End If
				Next
				Me.m_bSuccess = True
				result = True
			Catch ex15 As Exception
				MessageBox.Show("Error in Sub XLWorkSheetOpenReadClose: " + ex15.Message)
				NewLateBinding.LateCall(Me.oXLApp, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
			End Try
			Return result
		End Function

		Private Sub pnlScreen_2_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Private Sub txtMDCol_Enter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub txtMDCol_Leave(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub txtMDCol_TextChanged(sender As Object, e As EventArgs)
			If Me.txtMDCol Is Me.ActiveControl And Me.txtMDCol.Text.Length > 0 Then
				Me.sMeasured = Me.txtMDCol.Text
			End If
			Me.ResetClock()
		End Sub

		Private Sub txtINCol_Enter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub txtINCol_Leave(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub txtINCol_TextChanged(sender As Object, e As EventArgs)
			If Me.txtINCol Is Me.ActiveControl And Me.txtINCol.Text.Length > 0 Then
				Me.sInclination = Me.txtINCol.Text
			End If
			Me.ResetClock()
		End Sub

		Private Sub txtAZCol_Enter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub txtAZCol_Leave(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub txtAZCol_TextChanged(sender As Object, e As EventArgs)
			If Me.txtAZCol Is Me.ActiveControl And Me.txtAZCol.Text.Length > 0 Then
				Me.sAzimuth = Me.txtAZCol.Text
			End If
			Me.ResetClock()
		End Sub

		Private Sub InitSurveyDataset(ByRef mdsDeviationProfile As DataSet, Optional sSurveyFile As String = Nothing)
			Try
				mdsDeviationProfile = Nothing
				mdsDeviationProfile = New DataSet("DeviationProfile")
				Dim dataTable As DataTable = New DataTable("DeviationSurvey")
				Dim dataColumn As DataColumn = New DataColumn("EntryNumber", GetType(Integer))
				dataColumn.Unique = False
				dataColumn.AllowDBNull = True
				dataTable.Columns.Add(dataColumn)
				Dim dataColumn2 As DataColumn = New DataColumn("Depth", GetType(Single))
				dataColumn2.AllowDBNull = True
				dataTable.Columns.Add(dataColumn2)
				Dim dataColumn3 As DataColumn = New DataColumn("Inclination", GetType(String))
				dataColumn3.AllowDBNull = True
				dataTable.Columns.Add(dataColumn3)
				Dim dataColumn4 As DataColumn = New DataColumn("Azimuth", GetType(String))
				dataColumn4.AllowDBNull = True
				dataTable.Columns.Add(dataColumn4)
				Dim dataColumn5 As DataColumn = New DataColumn("Dogleg", GetType(Single))
				dataColumn5.AllowDBNull = True
				dataTable.Columns.Add(dataColumn5)
				Dim dataColumn6 As DataColumn = New DataColumn("TVDepth", GetType(Single))
				dataColumn6.AllowDBNull = True
				dataTable.Columns.Add(dataColumn6)
				Dim dataColumn7 As DataColumn = New DataColumn("NorthSouth", GetType(Single))
				dataColumn7.AllowDBNull = True
				dataTable.Columns.Add(dataColumn7)
				Dim dataColumn8 As DataColumn = New DataColumn("EastWest", GetType(Single))
				dataColumn8.AllowDBNull = True
				dataTable.Columns.Add(dataColumn8)
				mdsDeviationProfile.Tables.Add(dataTable)
				mdsDeviationProfile.Tables(0).Clear()
			Catch ex As Exception
				MessageBox.Show("Error in InitSurveyDataset: " + ex.Message)
			End Try
		End Sub

		Private Sub pnlScreen_33_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Private Sub cboSpreadSheets_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.cboSpreadSheets Then
				Me.sSelectedSS = Conversions.ToString(Me.cboSpreadSheets.SelectedItem)
				Return
			End If
		End Sub

		Private Sub cboWB_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.cboWB Then
				Me.sSelectedWB = Conversions.ToString(Me.cboWB.SelectedItem)
				If Not Me.XLWorkSheetOpenReadClose_Find_SS_Names() Then
					Me.m_bSuccess = False
					Me.Close()
				End If
				Return
			End If
		End Sub

		Private Sub rtbScreen_1_Enter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub rtbScreen_1_Leave(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub rtbScreen_1_TextChanged(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Public Sub ResetClock()
			Try
				If RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
					If Me.MyParentFrm Is Nothing Then
						Try
							Me.MyParentFrm = RSWIN_DESC.frmMain
						Catch ex As Exception
						End Try
					End If
					Me.MyParentFrm.ResetClock()
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private IsInitializing As Boolean

		Private MyParentFrm As RODSTAR

		<AccessedThroughProperty("txtCode")>
		Private _txtCode As TextBox

		<AccessedThroughProperty("lblCode")>
		Private _lblCode As Label

		<AccessedThroughProperty("lblScreen_1")>
		Private _lblScreen_1 As Label

		<AccessedThroughProperty("pnlScreen_1")>
		Private _pnlScreen_1 As Panel

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("cmdNext")>
		Private _cmdNext As Button

		<AccessedThroughProperty("cmdBack")>
		Private _cmdBack As Button

		<AccessedThroughProperty("Line1")>
		Private _Line1 As Label

		<AccessedThroughProperty("lblCaption")>
		Private _lblCaption As Label

		<AccessedThroughProperty("pnlScreen_4")>
		Private _pnlScreen_4 As Panel

		<AccessedThroughProperty("lblScreen_4")>
		Private _lblScreen_4 As Label

		<AccessedThroughProperty("pnlScreen_5")>
		Private _pnlScreen_5 As Panel

		<AccessedThroughProperty("lblScreen_5")>
		Private _lblScreen_5 As Label

		<AccessedThroughProperty("pnlScreen_6")>
		Private _pnlScreen_6 As Panel

		<AccessedThroughProperty("pnlScreen_0")>
		Private _pnlScreen_0 As Panel

		<AccessedThroughProperty("lblScreen_0")>
		Private _lblScreen_0 As Label

		<AccessedThroughProperty("grpScreen_4")>
		Private _grpScreen_4 As GroupBox

		<AccessedThroughProperty("rtbScreen_4")>
		Private _rtbScreen_4 As RichTextBox

		<AccessedThroughProperty("grpScreen_5")>
		Private _grpScreen_5 As GroupBox

		<AccessedThroughProperty("rtbScreen_5")>
		Private _rtbScreen_5 As RichTextBox

		<AccessedThroughProperty("grpScreen_0")>
		Private _grpScreen_0 As GroupBox

		<AccessedThroughProperty("rtbScreen_0")>
		Private _rtbScreen_0 As RichTextBox

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("lblWait")>
		Private _lblWait As Label

		<AccessedThroughProperty("Picture1")>
		Private _Picture1 As PictureBox

		<AccessedThroughProperty("txtExcel")>
		Private _txtExcel As TextBox

		<AccessedThroughProperty("cmdBrowse_0")>
		Private _cmdBrowse_0 As Button

		<AccessedThroughProperty("lblExcel")>
		Private _lblExcel As Label

		<AccessedThroughProperty("grpScreen_1")>
		Private _grpScreen_1 As GroupBox

		<AccessedThroughProperty("rtbScreen_1")>
		Private _rtbScreen_1 As RichTextBox

		<AccessedThroughProperty("lblMDCol")>
		Private _lblMDCol As Label

		<AccessedThroughProperty("lblINCol")>
		Private _lblINCol As Label

		<AccessedThroughProperty("lblAZCol")>
		Private _lblAZCol As Label

		<AccessedThroughProperty("lblRange")>
		Private _lblRange As Label

		<AccessedThroughProperty("lblNumPoints")>
		Private _lblNumPoints As Label

		<AccessedThroughProperty("txtMDCol")>
		Private _txtMDCol As TextBox

		<AccessedThroughProperty("txtINCol")>
		Private _txtINCol As TextBox

		<AccessedThroughProperty("txtAZCol")>
		Private _txtAZCol As TextBox

		<AccessedThroughProperty("txtNumPoints")>
		Private _txtNumPoints As TextBox

		<AccessedThroughProperty("lblUnits")>
		Private _lblUnits As Label

		<AccessedThroughProperty("rbtEnglish")>
		Private _rbtEnglish As RadioButton

		<AccessedThroughProperty("rbtMetric")>
		Private _rbtMetric As RadioButton

		<AccessedThroughProperty("lblScreen_6")>
		Private _lblScreen_6 As Label

		<AccessedThroughProperty("lblColumn")>
		Private _lblColumn As Label

		<AccessedThroughProperty("lblName")>
		Private _lblName As Label

		<AccessedThroughProperty("txtMDRange")>
		Private _txtMDRange As TextBox

		<AccessedThroughProperty("lblPosition")>
		Private _lblPosition As Label

		<AccessedThroughProperty("txtAZPos")>
		Private _txtAZPos As TextBox

		<AccessedThroughProperty("txtINPos")>
		Private _txtINPos As TextBox

		<AccessedThroughProperty("txtMDPos")>
		Private _txtMDPos As TextBox

		<AccessedThroughProperty("txtINRange")>
		Private _txtINRange As TextBox

		<AccessedThroughProperty("txtAZRange")>
		Private _txtAZRange As TextBox

		<AccessedThroughProperty("lblSurveyType")>
		Private _lblSurveyType As Label

		<AccessedThroughProperty("lblSpreadSheet")>
		Private _lblSpreadSheet As Label

		<AccessedThroughProperty("lblWorkbook")>
		Private _lblWorkbook As Label

		<AccessedThroughProperty("pnlScreen_3")>
		Private _pnlScreen_3 As Panel

		<AccessedThroughProperty("grpScreen_3")>
		Private _grpScreen_3 As GroupBox

		<AccessedThroughProperty("rtbScreen_3")>
		Private _rtbScreen_3 As RichTextBox

		<AccessedThroughProperty("lblScreen_3")>
		Private _lblScreen_3 As Label

		<AccessedThroughProperty("pnlScreen_2")>
		Private _pnlScreen_2 As Panel

		<AccessedThroughProperty("lblScreen_2")>
		Private _lblScreen_2 As Label

		<AccessedThroughProperty("grpScreen_2")>
		Private _grpScreen_2 As GroupBox

		<AccessedThroughProperty("rtbScreen_2")>
		Private _rtbScreen_2 As RichTextBox

		<AccessedThroughProperty("cboSpreadSheets")>
		Private _cboSpreadSheets As ComboBox

		<AccessedThroughProperty("lblSS_Step2")>
		Private _lblSS_Step2 As Label

		<AccessedThroughProperty("cboWB")>
		Private _cboWB As ComboBox

		<AccessedThroughProperty("tmrClock")>
		Private _tmrClock As System.Windows.Forms.Timer

		<AccessedThroughProperty("lblWB_Step2")>
		Private _lblWB_Step2 As Label

		Private Shared m_vb6FormDefInstance As frmWizard

		Private Shared m_InitializingDefInstance As Boolean

		Private Const csKEY_ENTRYNUMBER As String = "EntryNumber"

		Private Const csKEY_AZIMUTH As String = "Azimuth"

		Private Const csKEY_DEPTH As String = "Depth"

		Private Const csKEY_DOGLEG As String = "Dogleg"

		Private Const csKEY_INCLINATION As String = "Inclination"

		Private Const csKEY_TVDEPTH As String = "TVDepth"

		Private Const csKEY_NORTHSOUTH As String = "NorthSouth"

		Private Const csKEY_EASTWEST As String = "EastWest"

		Private sExcelFormatError As String

		Private sCouldNotCreateExcelApp As String

		Private sCouldNotOpenExcelFile As String

		Private sCouldNotReadData As String

		Private sErrorSearchingWorkbooks As String

		Private sCouldReadSS As String

		Private intScreen As Short

		Private FirstCol As Integer

		Private LastCol As Integer

		Private FirstDataRow As Integer

		Private LastDataRow As Integer

		Private NumRows As Integer

		Private ColumnRow As Integer

		Private MDCol As Integer

		Private INCol As Integer

		Private AZCol As Integer

		Private rgAzimuth As String()

		Private rgDepth As Double()

		Private rgIncl As String()

		Private Const iMaxRowCount As Integer = 250000

		Private m_bEnglish As Boolean

		Private sExcelFile As String

		Private m_bSuccess As Boolean

		Private m_sType As String

		Private sSS As String()

		Private sWB As String()

		Private sSelectedSS As String

		Private sSelectedWB As String

		Private iSS As Integer

		Private iWB As Integer

		Private oXLApp As Object

		Private oWBs As Object

		Private oWB As Object

		Private oSheet As Object

		Private oRng As Object

		Private sMeasured As String

		Private sMeasured2 As String

		Private sMeasured3 As String

		Private sInclination As String

		Private sAzimuth As String

		Private sMD As String

		Private sIncl As String

		Private sInc As String

		Private sAz As String

		Private sAzm As String

		Private smKB As String

		Private sKOMD As String

		Private sMDTie As String

		Private Row As Long

		Private Column As Long

		Private sCheck As Object

		Private sCheck2 As Object

		Private bDataOK As Boolean

		Private bContinueRow As Boolean

		Private bContinueCol As Boolean

		Private bContinue As Boolean

		Private iNullCount As Integer

		Private r As DataRow

		Private PrevDepth As Integer

		Private objConn As OleDbConnection
	End Class
End Namespace
