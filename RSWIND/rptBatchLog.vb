Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.DataSources
Imports DataDynamics.ActiveReports.Document
Imports DDCssLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class rptBatchLog
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.ActiveReport_ReportStart
			Me.GroupHeader1 = Nothing
			Me.Detail = Nothing
			Me.GroupFooter1 = Nothing
			Me.ds = Nothing
			Me.sNull = ""
			Me.sBatchRunLog = Util.AssignValueToConstant("rptCalcResults", "sBatchRunLog", "Batch Run Log")
			Me.sAIBatchRunLog = Util.AssignValueToConstant("rptCalcResults", "sAIBatchRunLog", "AI Batch Run Log")
			Me.sLicenseTo = Util.AssignValueToConstant("rptCalcResults", "sLicenseTo", " - Licensed to ")
			Me.sCompany = Util.AssignValueToConstant("rptCalcResults", "sCompany", "Company: ")
			Me.sWell = Util.AssignValueToConstant("rptCalcResults", "sWell", "Well: ")
			Me.sUser = Util.AssignValueToConstant("rptCalcResults", "sUser", "User: ")
			Me.sNumFiles = Util.AssignValueToConstant("rptBatchLog", "sNumFiles", "Number of Files in Batch Run: ")
			Me.sDate = Util.AssignValueToConstant("rptCalcResults", "sDate", "Date: ")
			Me.sPage = Util.AssignValueToConstant("rptCalcResults", "sPage", "Page")
			Me.sOf = Util.AssignValueToConstant("rptCalcResults", "sOf", "of")
			Me.sComment = Util.AssignValueToConstant("rptCalcResults", "sComment", "Comment: ")
			Me.sThetaEnterprises = Util.AssignValueToConstant("rptCalcResults", "sThetaEnterprises", "(c) Theta Oilfield Services, Inc.")
			Me.InitializeComponent()
		End Sub

		Private Overridable Property GroupHeader1 As GroupHeader
			Get
				Return Me._GroupHeader1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupHeader)
				Me._GroupHeader1 = value
			End Set
		End Property

		Private Overridable Property Detail As Detail
			Get
				Return Me._Detail
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Detail)
				Dim value2 As EventHandler = AddressOf Me.Detail_Format
				If Me._Detail IsNot Nothing Then
					RemoveHandler Me._Detail.Format, value2
				End If
				Me._Detail = value
				If Me._Detail IsNot Nothing Then
					AddHandler Me._Detail.Format, value2
				End If
			End Set
		End Property

		Private Overridable Property GroupFooter1 As GroupFooter
			Get
				Return Me._GroupFooter1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupFooter)
				Me._GroupFooter1 = value
			End Set
		End Property

		Private Overridable Property PageHeader As PageHeader
			Get
				Return Me._PageHeader
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PageHeader)
				Me._PageHeader = value
			End Set
		End Property

		Private Overridable Property lblComment As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblComment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblComment = value
			End Set
		End Property

		Private Overridable Property lblTitle1 As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblTitle1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblTitle1 = value
			End Set
		End Property

		Private Overridable Property lblPage As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblPage
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblPage = value
			End Set
		End Property

		Private Overridable Property txtPage1 As DataDynamics.ActiveReports.TextBox
			Get
				Return Me._txtPage1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.TextBox)
				Me._txtPage1 = value
			End Set
		End Property

		Private Overridable Property lblOf As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblOf
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblOf = value
			End Set
		End Property

		Private Overridable Property txtPage2 As DataDynamics.ActiveReports.TextBox
			Get
				Return Me._txtPage2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.TextBox)
				Me._txtPage2 = value
			End Set
		End Property

		Private Overridable Property lblUserName As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblUserName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblUserName = value
			End Set
		End Property

		Private Overridable Property lblUserDate As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblUserDate
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblUserDate = value
			End Set
		End Property

		Private Overridable Property lblLabel2 As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblLabel2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblLabel2 = value
			End Set
		End Property

		Private Overridable Property lblCompany As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblCompany
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblCompany = value
			End Set
		End Property

		Private Overridable Property lblNumFiles As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblNumFiles
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblNumFiles = value
			End Set
		End Property

		Private Overridable Property lblGoTheta As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblGoTheta
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblGoTheta = value
			End Set
		End Property

		Private Overridable Property fldBatchEntry As DataDynamics.ActiveReports.TextBox
			Get
				Return Me._fldBatchEntry
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.TextBox)
				Me._fldBatchEntry = value
			End Set
		End Property

		Private Overridable Property lblTitle As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblTitle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblTitle = value
			End Set
		End Property

		Private Overridable Property PageFooter As PageFooter
			Get
				Return Me._PageFooter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PageFooter)
				Me._PageFooter = value
			End Set
		End Property

		Private Sub InitializeComponent()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptBatchLog))
			Me.Detail = New Detail()
			Me.fldBatchEntry = New DataDynamics.ActiveReports.TextBox()
			Me.GroupHeader1 = New GroupHeader()
			Me.GroupFooter1 = New GroupFooter()
			Me.PageHeader = New PageHeader()
			Me.lblComment = New DataDynamics.ActiveReports.Label()
			Me.lblTitle1 = New DataDynamics.ActiveReports.Label()
			Me.lblPage = New DataDynamics.ActiveReports.Label()
			Me.txtPage1 = New DataDynamics.ActiveReports.TextBox()
			Me.lblOf = New DataDynamics.ActiveReports.Label()
			Me.txtPage2 = New DataDynamics.ActiveReports.TextBox()
			Me.lblUserName = New DataDynamics.ActiveReports.Label()
			Me.lblUserDate = New DataDynamics.ActiveReports.Label()
			Me.lblLabel2 = New DataDynamics.ActiveReports.Label()
			Me.lblCompany = New DataDynamics.ActiveReports.Label()
			Me.lblNumFiles = New DataDynamics.ActiveReports.Label()
			Me.lblGoTheta = New DataDynamics.ActiveReports.Label()
			Me.lblTitle = New DataDynamics.ActiveReports.Label()
			Me.PageFooter = New PageFooter()
			CType(Me.fldBatchEntry, ISupportInitialize).BeginInit()
			CType(Me.lblComment, ISupportInitialize).BeginInit()
			CType(Me.lblTitle1, ISupportInitialize).BeginInit()
			CType(Me.lblPage, ISupportInitialize).BeginInit()
			CType(Me.txtPage1, ISupportInitialize).BeginInit()
			CType(Me.lblOf, ISupportInitialize).BeginInit()
			CType(Me.txtPage2, ISupportInitialize).BeginInit()
			CType(Me.lblUserName, ISupportInitialize).BeginInit()
			CType(Me.lblUserDate, ISupportInitialize).BeginInit()
			CType(Me.lblLabel2, ISupportInitialize).BeginInit()
			CType(Me.lblCompany, ISupportInitialize).BeginInit()
			CType(Me.lblNumFiles, ISupportInitialize).BeginInit()
			CType(Me.lblGoTheta, ISupportInitialize).BeginInit()
			CType(Me.lblTitle, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Controls.AddRange(New ARControl() { Me.fldBatchEntry })
			Me.Detail.Height = 0.2090278F
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.fldBatchEntry.DataField = "BatchEntry"
			Me.fldBatchEntry.Height = 0.1875F
			Me.fldBatchEntry.Left = 0.06200001F
			Me.fldBatchEntry.Name = "fldBatchEntry"
			Me.fldBatchEntry.Style = "text-align: center"
			Me.fldBatchEntry.Text = "BatchEntry"
			Me.fldBatchEntry.Top = 0F
			Me.fldBatchEntry.Width = 7.875F
			Me.GroupHeader1.Height = 0F
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.GroupHeader1.RepeatStyle = RepeatStyle.OnPageIncludeNoDetail
			Me.GroupFooter1.Height = 0F
			Me.GroupFooter1.Name = "GroupFooter1"
			Me.PageHeader.Controls.AddRange(New ARControl() { Me.lblComment, Me.lblTitle1, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserName, Me.lblUserDate, Me.lblLabel2, Me.lblCompany, Me.lblNumFiles, Me.lblGoTheta, Me.lblTitle })
			Me.PageHeader.Height = 1.176389F
			Me.PageHeader.Name = "PageHeader"
			Me.lblComment.Height = 0.25F
			Me.lblComment.HyperLink = Nothing
			Me.lblComment.Left = 0.0625F
			Me.lblComment.Name = "lblComment"
			Me.lblComment.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblComment.Text = "Comment: "
			Me.lblComment.Top = 0.69F
			Me.lblComment.Width = 7.875F
			Me.lblTitle1.Height = 0.17F
			Me.lblTitle1.HyperLink = Nothing
			Me.lblTitle1.Left = 0.0625F
			Me.lblTitle1.Name = "lblTitle1"
			Me.lblTitle1.Style = "font-family: Microsoft Sans Serif; font-size: 9pt; font-weight: bold; text-align: center"
			Me.lblTitle1.Text = "RODSTAR-D 1.0"
			Me.lblTitle1.Top = 0F
			Me.lblTitle1.Width = 7.875F
			Me.lblPage.Height = 0.17F
			Me.lblPage.HyperLink = Nothing
			Me.lblPage.Left = 6.0625F
			Me.lblPage.Name = "lblPage"
			Me.lblPage.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblPage.Text = "Page"
			Me.lblPage.Top = 0.18F
			Me.lblPage.Width = 0.4375F
			Me.txtPage1.Height = 0.17F
			Me.txtPage1.Left = 6.5F
			Me.txtPage1.Name = "txtPage1"
			Me.txtPage1.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.txtPage1.Text = Nothing
			Me.txtPage1.Top = 0.18F
			Me.txtPage1.Width = 0.1875F
			Me.lblOf.Height = 0.17F
			Me.lblOf.HyperLink = Nothing
			Me.lblOf.Left = 6.6875F
			Me.lblOf.Name = "lblOf"
			Me.lblOf.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblOf.Text = "of"
			Me.lblOf.Top = 0.18F
			Me.lblOf.Width = 0.1875F
			Me.txtPage2.Height = 0.17F
			Me.txtPage2.Left = 6.875F
			Me.txtPage2.Name = "txtPage2"
			Me.txtPage2.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.txtPage2.Text = Nothing
			Me.txtPage2.Top = 0.18F
			Me.txtPage2.Width = 0.1875F
			Me.lblUserName.Height = 0.17F
			Me.lblUserName.HyperLink = Nothing
			Me.lblUserName.Left = 6.0625F
			Me.lblUserName.Name = "lblUserName"
			Me.lblUserName.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblUserName.Text = "User: "
			Me.lblUserName.Top = 0.34F
			Me.lblUserName.Width = 1.875F
			Me.lblUserDate.Height = 0.17F
			Me.lblUserDate.HyperLink = Nothing
			Me.lblUserDate.Left = 6.0625F
			Me.lblUserDate.Name = "lblUserDate"
			Me.lblUserDate.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblUserDate.Text = "Date: "
			Me.lblUserDate.Top = 0.51F
			Me.lblUserDate.Width = 1.875F
			Me.lblLabel2.Height = 0.17F
			Me.lblLabel2.HyperLink = Nothing
			Me.lblLabel2.Left = 3F
			Me.lblLabel2.Name = "lblLabel2"
			Me.lblLabel2.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center"
			Me.lblLabel2.Text = "© Theta Oilfield Services, Inc."
			Me.lblLabel2.Top = 0.18F
			Me.lblLabel2.Width = 2F
			Me.lblCompany.Height = 0.17F
			Me.lblCompany.HyperLink = Nothing
			Me.lblCompany.Left = 0.0625F
			Me.lblCompany.Name = "lblCompany"
			Me.lblCompany.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblCompany.Text = "Company: "
			Me.lblCompany.Top = 0.18F
			Me.lblCompany.Width = 2.9375F
			Me.lblNumFiles.Height = 0.17F
			Me.lblNumFiles.HyperLink = Nothing
			Me.lblNumFiles.Left = 0.062F
			Me.lblNumFiles.Name = "lblNumFiles"
			Me.lblNumFiles.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; white-space: nowrap"
			Me.lblNumFiles.Text = "Number of Files in Batch Run: "
			Me.lblNumFiles.Top = 0.51F
			Me.lblNumFiles.Width = 2.9375F
			Me.lblGoTheta.Height = 0.17F
			Me.lblGoTheta.HyperLink = Nothing
			Me.lblGoTheta.Left = 4.8125F
			Me.lblGoTheta.Name = "lblGoTheta"
			Me.lblGoTheta.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center"
			Me.lblGoTheta.Text = "(www.gotheta.com)"
			Me.lblGoTheta.Top = 0.18F
			Me.lblGoTheta.Width = 1.0625F
			Me.lblTitle.Height = 0.1875001F
			Me.lblTitle.HyperLink = Nothing
			Me.lblTitle.Left = 0.062F
			Me.lblTitle.Name = "lblTitle"
			Me.lblTitle.Style = "background-color: rgb(128,128,128); color: rgb(255,255,255); text-align: center"
			Me.lblTitle.Text = "Batch Run Log"
			Me.lblTitle.Top = 0.96F
			Me.lblTitle.Width = 7.875F
			Me.PageFooter.CanGrow = False
			Me.PageFooter.Height = 0F
			Me.PageFooter.Name = "PageFooter"
			Me.MasterReport = False
			Me.MaxPages = 100L
			Me.PageSettings.Margins.Bottom = 0.25F
			Me.PageSettings.Margins.Left = 0.3F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0.2F
			Me.PageSettings.PaperHeight = 11F
			Me.PageSettings.PaperWidth = 8.5F
			Me.PrintWidth = 8F
			Me.Sections.Add(Me.PageHeader)
			Me.Sections.Add(Me.GroupHeader1)
			Me.Sections.Add(Me.Detail)
			Me.Sections.Add(Me.GroupFooter1)
			Me.Sections.Add(Me.PageFooter)
			Me.StyleSheet.Add(New StyleSheetRule(componentResourceManager.GetString("$this.StyleSheet"), "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-weight: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("", "Heading4", "Normal"))
			CType(Me.fldBatchEntry, ISupportInitialize).EndInit()
			CType(Me.lblComment, ISupportInitialize).EndInit()
			CType(Me.lblTitle1, ISupportInitialize).EndInit()
			CType(Me.lblPage, ISupportInitialize).EndInit()
			CType(Me.txtPage1, ISupportInitialize).EndInit()
			CType(Me.lblOf, ISupportInitialize).EndInit()
			CType(Me.txtPage2, ISupportInitialize).EndInit()
			CType(Me.lblUserName, ISupportInitialize).EndInit()
			CType(Me.lblUserDate, ISupportInitialize).EndInit()
			CType(Me.lblLabel2, ISupportInitialize).EndInit()
			CType(Me.lblCompany, ISupportInitialize).EndInit()
			CType(Me.lblNumFiles, ISupportInitialize).EndInit()
			CType(Me.lblGoTheta, ISupportInitialize).EndInit()
			CType(Me.lblTitle, ISupportInitialize).EndInit()
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		Public Property NumFiles As Integer
			Get
				Return Me.m_NumFiles
			End Get
			Set(value As Integer)
				Me.m_NumFiles = value
			End Set
		End Property

		Private Sub SummHeader(iPage As Integer, nPages As Integer)
			Dim text As String = New String(" "c, 112)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim text2 As String = RSWIN_DESC.sProgramLongName
				Dim text3 As String = ""
				If Strings.Len(text3) > 0 Then
					text2 = text2 + " (SN#" + text3 + ")"
				End If
				If Strings.Len(Util.Licensee()) > 0 Then
					text2 = text2 + Me.sLicenseTo + Util.Licensee()
				End If
				Me.lblTitle1.Text = text2
				Me.lblLabel2.Text = Me.sThetaEnterprises
				Me.lblPage.Text = Me.sPage
				Me.lblOf.Text = Me.sOf
				Me.lblCompany.Text = Me.sCompany + Strings.Trim(rst.ACompanyName)
				If iPage >= 1 Then
					Me.txtPage1.Text = iPage.ToString()
					Me.txtPage2.Text = nPages.ToString()
				End If
				Dim text4 As String = Me.sThetaEnterprises
				Me.lblUserName.Text = Me.sUser + Strings.Trim(rst.UserName)
				Me.lblNumFiles.Text = Me.sNumFiles + Me.m_NumFiles.ToString()
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					Me.lblTitle.Text = Me.sAIBatchRunLog
				Else
					Me.lblTitle.Text = Me.sBatchRunLog
				End If
				If rst.FileComment Is Nothing Then
					rst.FileComment = ""
				End If
				Me.lblNumFiles.Text = Conversions.ToString(Conversions.ToDouble(Me.lblNumFiles.Text) + CDbl(Me.m_NumFiles))
				Me.lblComment.Text = Me.sComment + rst.FileComment
				If Information.IsDate(rst.UserDate) Then
					Me.lblUserDate.Text = Me.sDate + Convert.ToDateTime(rst.UserDate).ToShortDateString()
				Else
					Me.lblUserDate.Text = Me.sDate + rst.UserDate
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Property TotalPageNumber As Integer
			Get
				Return Me.m_TotalPageNumber
			End Get
			Set(value As Integer)
				Me.m_TotalPageNumber = value
			End Set
		End Property

		Public Property ThisPageNumber As Integer
			Get
				Return Me.m_ThisPageNumber
			End Get
			Set(value As Integer)
				Me.m_ThisPageNumber = value
			End Set
		End Property

		Public Property NumberOfLines As Integer
			Get
				Return Me.m_NumberOfLines
			End Get
			Set(value As Integer)
				Me.m_NumberOfLines = value
			End Set
		End Property

		Public Property bPrint As Boolean
			Get
				Return Me.m_bPrint
			End Get
			Set(value As Boolean)
				Me.m_bPrint = value
				Me.PageSettings.Orientation = PageOrientation.Portrait
			End Set
		End Property

		Private Sub ActiveReport_ReportStart(sender As Object, e As EventArgs)
			Try
				Me.printFont = New Font("Arial", 10F)
				If Not Me.m_bPrint Then
					Me.PageSettings.Margins.Left = 0.25F
					Me.PageSettings.Margins.Right = 0F
					Me.PageSettings.Margins.Top = 0.11F
					Me.PageSettings.Margins.Bottom = 0F
				Else
					Me.PageSettings.Margins.Left = 0.25F
					Me.PageSettings.Margins.Right = 0F
					Me.PageSettings.Margins.Top = 0.1F
					Me.PageSettings.Margins.Bottom = 0F
				End If
				Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
				Me.GroupHeader1.Visible = True
				Application.DoEvents()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub Detail_Format(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = Me.fldBatchEntry.Text
				If text IsNot Nothing Then
					If Strings.InStr(text, "batch run is complete", CompareMethod.Binary) > 0 Or Strings.InStr(text, "run aborted", CompareMethod.Binary) > 0 Or Strings.InStr(text, "was canceled", CompareMethod.Binary) > 0 Then
						Me.fldBatchEntry.Style = "font-family: Arial Narrow; font-size: 9.75pt; font-style: italic; text-align: left"
						Me.fldBatchEntry.BackColor = Color.LightSlateGray
						Me.fldBatchEntry.ForeColor = Color.White
					ElseIf Strings.InStr(text, "Unit with larger", CompareMethod.Binary) > 0 Then
						Me.fldBatchEntry.Style = "font-family: Arial Narrow; font-size: 9.75pt; font-style: italic; text-align: left"
						Me.fldBatchEntry.BackColor = Color.Yellow
						Me.fldBatchEntry.ForeColor = Color.Black
					ElseIf Strings.InStr(text, "XROD-V AI Batch Run", CompareMethod.Binary) > 0 Then
						Me.fldBatchEntry.Style = "font-family: Arial Narrow; font-size: 9.75pt; font-style: italic; text-align: left"
						Me.fldBatchEntry.BackColor = Color.DarkGreen
						Me.fldBatchEntry.ForeColor = Color.White
					ElseIf Strings.InStr(text, ".rsvx", CompareMethod.Binary) > 0 Or Strings.InStr(text, ".RSVX", CompareMethod.Binary) > 0 Or Strings.InStr(text, ".rsdx", CompareMethod.Binary) > 0 Or Strings.InStr(text, ".RSDX", CompareMethod.Binary) > 0 Then
						Me.fldBatchEntry.Style = "font-family: Arial Narrow; font-size: 9.75pt; font-style: italic; text-align: left"
						Me.fldBatchEntry.BackColor = Color.DarkBlue
						Me.fldBatchEntry.ForeColor = Color.White
					ElseIf Strings.InStr(text, "Using 2 3/8", CompareMethod.Binary) > 0 Then
						Me.fldBatchEntry.Style = "font-family: Arial Narrow; font-size: 9.75pt; font-style: normal; text-align: left"
						Me.fldBatchEntry.BackColor = Color.White
						Me.fldBatchEntry.ForeColor = Color.Blue
					Else
						Me.fldBatchEntry.Style = "font-family: Arial Narrow; font-size: 9.75pt; font-style: normal; text-align: left"
						Me.fldBatchEntry.BackColor = Color.White
						Me.fldBatchEntry.ForeColor = Color.Black
					End If
				End If
				Me.$STATIC$Detail_Format$20211C1241$cnt += 1L
				If Me.$STATIC$Detail_Format$20211C1241$cnt = 35L Then
					Me.Detail.NewPage = NewPage.After
					Me.$STATIC$Detail_Format$20211C1241$cnt = 0L
					Me.$STATIC$Detail_Format$20211C1241$bNextPage = True
				Else
					If Me.$STATIC$Detail_Format$20211C1241$bNextPage Then
						Me.m_ThisPageNumber += 1
						Me.txtPage1.Text = Me.m_ThisPageNumber.ToString()
					End If
					Me.Detail.NewPage = NewPage.None
					Me.$STATIC$Detail_Format$20211C1241$bNextPage = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		<AccessedThroughProperty("GroupHeader1")>
		Private _GroupHeader1 As GroupHeader

		<AccessedThroughProperty("Detail")>
		Private _Detail As Detail

		<AccessedThroughProperty("GroupFooter1")>
		Private _GroupFooter1 As GroupFooter

		Public ds As XMLDataSource

		<AccessedThroughProperty("PageHeader")>
		Private _PageHeader As PageHeader

		<AccessedThroughProperty("lblComment")>
		Private _lblComment As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblTitle1")>
		Private _lblTitle1 As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblPage")>
		Private _lblPage As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("txtPage1")>
		Private _txtPage1 As DataDynamics.ActiveReports.TextBox

		<AccessedThroughProperty("lblOf")>
		Private _lblOf As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("txtPage2")>
		Private _txtPage2 As DataDynamics.ActiveReports.TextBox

		<AccessedThroughProperty("lblUserName")>
		Private _lblUserName As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblUserDate")>
		Private _lblUserDate As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblLabel2")>
		Private _lblLabel2 As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblCompany")>
		Private _lblCompany As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblNumFiles")>
		Private _lblNumFiles As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblGoTheta")>
		Private _lblGoTheta As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("fldBatchEntry")>
		Private _fldBatchEntry As DataDynamics.ActiveReports.TextBox

		<AccessedThroughProperty("lblTitle")>
		Private _lblTitle As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("PageFooter")>
		Private _PageFooter As PageFooter

		Private TEMP_SETUP_BAREROD_LOAD As Single

		Private TEMP_SETUP_MOLDEDGUIDE_LOAD As Single

		Private TEMP_SETUP_WHEELGUIDE_LOAD As Single

		Private TEMP_SETUP_OTHERGUIDE_LOAD As Single

		Private TEMP_SETUP_NorrisStandardGuide_Load As Single

		Private TEMP_SETUP_NorrisSidewinderGuide_Load As Single

		Private TEMP_SETUP_RGIJakeCouplingGuide_Load As Single

		Private TEMP_SETUP_RGISVTGuide_LOAD As Single

		Private TEMP_SETUP_RGITomahawkGuide_LOAD As Single

		Private TEMP_SETUP_RGITornadoGuide_LOAD As Single

		Private TEMP_SETUP_RGITwisterGuide_LOAD As Single

		Private TEMP_SETUP_RGIWVTGuide_LOAD As Single

		Private TEMP_SETUP_MaxNumGuidesPerRod As Single

		Private printFont As Font

		Private sNull As String

		Private sBatchRunLog As String

		Private sAIBatchRunLog As String

		Private sLicenseTo As String

		Private sCompany As String

		Private sWell As String

		Private sUser As String

		Private sNumFiles As String

		Private sDate As String

		Private sPage As String

		Private sOf As String

		Private sComment As String

		Private sThetaEnterprises As String

		Private m_NumFiles As Integer

		Private Const iLineNumPerPage As Integer = 35

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer

		Private m_NumberOfLines As Integer

		Private m_bPrint As Boolean

		Private $STATIC$Detail_Format$20211C1241$cnt As Long

		Private $STATIC$Detail_Format$20211C1241$bNextPage As Boolean
	End Class
End Namespace
