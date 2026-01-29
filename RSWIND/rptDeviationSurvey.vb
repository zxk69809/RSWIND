Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports DDCssLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class rptDeviationSurvey
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.myReportStart
			Me.PageHeader = Nothing
			Me.Detail = Nothing
			Me.PageFooter = Nothing
			Me.lblComment = Nothing
			Me.lblTitle1 = Nothing
			Me.lblPage = Nothing
			Me.txtPage1 = Nothing
			Me.lblOf = Nothing
			Me.txtPage2 = Nothing
			Me.lblUserName = Nothing
			Me.lblUserDate = Nothing
			Me.lblLabel2 = Nothing
			Me.lblCompany = Nothing
			Me.lblWellName = Nothing
			Me.lblDiskFile = Nothing
			Me.lblSecondCompanyName = Nothing
			Me.lblSecondCompanyPhonenumber = Nothing
			Me.lblGoTheta = Nothing
			Me.PageBreak1 = Nothing
			Me.chtSideForces = Nothing
			Me.chtAxialLoads = Nothing
			Me.chtBucklingTendency = Nothing
			Me.chtSurveyEW = Nothing
			Me.chtSurveyNS = Nothing
			Me.chtSurveyPlan = Nothing
			Me.chtDogLeg = Nothing
			Me.sCompany = Util.AssignValueToConstant("rptCalcResults", "sCompany", "Company: ")
			Me.sWell = Util.AssignValueToConstant("rptCalcResults", "sWell", "Well: ")
			Me.sUser = Util.AssignValueToConstant("rptCalcResults", "sUser", "User: ")
			Me.sDiskFile = Util.AssignValueToConstant("rptCalcResults", "sDiskFile", "Disk file: ")
			Me.sDate = Util.AssignValueToConstant("rptCalcResults", "sDate", "Date: ")
			Me.sPage = Util.AssignValueToConstant("rptCalcResults", "sPage", "Page")
			Me.sOf = Util.AssignValueToConstant("rptCalcResults", "sOf", "of")
			Me.sComment = Util.AssignValueToConstant("rptCalcResults", "sComment", "Comment: ")
			Me.sLicenseTo = Util.AssignValueToConstant("rptCalcResults", "sLicenseTo", " - Licensed to ")
			Me.slbl = "lbl"
			Me.sThetaEnterprises = Util.AssignValueToConstant("rptCalcResults", "sThetaEnterprises", "(c) Theta Oilfield Services, Inc.")
			Me.InitializeComponent()
		End Sub

		Private Overridable Property PageHeader As PageHeader
			Get
				Return Me._PageHeader
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PageHeader)
				Me._PageHeader = value
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
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptDeviationSurvey))
			Me.Detail = New Detail()
			Me.PageBreak1 = New PageBreak()
			Me.chtSideForces = New Picture()
			Me.chtAxialLoads = New Picture()
			Me.chtBucklingTendency = New Picture()
			Me.chtSurveyEW = New Picture()
			Me.chtSurveyNS = New Picture()
			Me.chtSurveyPlan = New Picture()
			Me.chtDogLeg = New Picture()
			Me.PageHeader = New PageHeader()
			Me.lblComment = New Label()
			Me.lblTitle1 = New Label()
			Me.lblPage = New Label()
			Me.txtPage1 = New TextBox()
			Me.lblOf = New Label()
			Me.txtPage2 = New TextBox()
			Me.lblUserName = New Label()
			Me.lblUserDate = New Label()
			Me.lblLabel2 = New Label()
			Me.lblCompany = New Label()
			Me.lblWellName = New Label()
			Me.lblDiskFile = New Label()
			Me.lblSecondCompanyName = New Label()
			Me.lblSecondCompanyPhonenumber = New Label()
			Me.lblGoTheta = New Label()
			Me.PageFooter = New PageFooter()
			CType(Me.chtSideForces, ISupportInitialize).BeginInit()
			CType(Me.chtAxialLoads, ISupportInitialize).BeginInit()
			CType(Me.chtBucklingTendency, ISupportInitialize).BeginInit()
			CType(Me.chtSurveyEW, ISupportInitialize).BeginInit()
			CType(Me.chtSurveyNS, ISupportInitialize).BeginInit()
			CType(Me.chtSurveyPlan, ISupportInitialize).BeginInit()
			CType(Me.chtDogLeg, ISupportInitialize).BeginInit()
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
			CType(Me.lblWellName, ISupportInitialize).BeginInit()
			CType(Me.lblDiskFile, ISupportInitialize).BeginInit()
			CType(Me.lblSecondCompanyName, ISupportInitialize).BeginInit()
			CType(Me.lblSecondCompanyPhonenumber, ISupportInitialize).BeginInit()
			CType(Me.lblGoTheta, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Controls.AddRange(New ARControl() { Me.PageBreak1, Me.chtSideForces, Me.chtAxialLoads, Me.chtBucklingTendency, Me.chtSurveyEW, Me.chtSurveyNS, Me.chtSurveyPlan, Me.chtDogLeg })
			Me.Detail.Height = 10.48819F
			Me.Detail.Name = "Detail"
			Me.PageBreak1.Height = 0.05555556F
			Me.PageBreak1.Left = 0F
			Me.PageBreak1.Name = "PageBreak1"
			Dim pageBreak As PageBreak = Me.PageBreak1
			Dim size As SizeF = New SizeF(6.5F, 0.05555556F)
			pageBreak.Size = size
			Me.PageBreak1.Top = 0F
			Me.PageBreak1.Visible = False
			Me.PageBreak1.Width = 6.5F
			Me.chtSideForces.BackColor = Color.FromArgb(255, 255, 255)
			Me.chtSideForces.Height = 0.9375F
			Me.chtSideForces.ImageData = Nothing
			Me.chtSideForces.Left = 0.1875F
			Me.chtSideForces.LineColor = Color.FromArgb(255, 255, 255)
			Me.chtSideForces.Name = "chtSideForces"
			Me.chtSideForces.SizeMode = SizeModes.Stretch
			Me.chtSideForces.Top = 0.25F
			Me.chtSideForces.Width = 3.75F
			Me.chtAxialLoads.BackColor = Color.FromArgb(255, 255, 255)
			Me.chtAxialLoads.Height = 0.9375F
			Me.chtAxialLoads.ImageData = Nothing
			Me.chtAxialLoads.Left = 0.1875F
			Me.chtAxialLoads.LineColor = Color.FromArgb(255, 255, 255)
			Me.chtAxialLoads.Name = "chtAxialLoads"
			Me.chtAxialLoads.SizeMode = SizeModes.Stretch
			Me.chtAxialLoads.Top = 1.3125F
			Me.chtAxialLoads.Width = 3.75F
			Me.chtBucklingTendency.BackColor = Color.FromArgb(255, 255, 255)
			Me.chtBucklingTendency.Height = 0.9375F
			Me.chtBucklingTendency.ImageData = Nothing
			Me.chtBucklingTendency.Left = 0.1875F
			Me.chtBucklingTendency.LineColor = Color.FromArgb(255, 255, 255)
			Me.chtBucklingTendency.Name = "chtBucklingTendency"
			Me.chtBucklingTendency.SizeMode = SizeModes.Stretch
			Me.chtBucklingTendency.Top = 2.3125F
			Me.chtBucklingTendency.Width = 3.75F
			Me.chtSurveyEW.BackColor = Color.FromArgb(255, 255, 255)
			Me.chtSurveyEW.Height = 0.9375F
			Me.chtSurveyEW.ImageData = Nothing
			Me.chtSurveyEW.Left = 4.0625F
			Me.chtSurveyEW.LineColor = Color.FromArgb(255, 255, 255)
			Me.chtSurveyEW.Name = "chtSurveyEW"
			Me.chtSurveyEW.SizeMode = SizeModes.Stretch
			Me.chtSurveyEW.Top = 0.25F
			Me.chtSurveyEW.Width = 3.75F
			Me.chtSurveyNS.BackColor = Color.FromArgb(255, 255, 255)
			Me.chtSurveyNS.Height = 0.9375F
			Me.chtSurveyNS.ImageData = Nothing
			Me.chtSurveyNS.Left = 4.0625F
			Me.chtSurveyNS.LineColor = Color.FromArgb(255, 255, 255)
			Me.chtSurveyNS.Name = "chtSurveyNS"
			Me.chtSurveyNS.SizeMode = SizeModes.Stretch
			Me.chtSurveyNS.Top = 1.3125F
			Me.chtSurveyNS.Width = 3.75F
			Me.chtSurveyPlan.BackColor = Color.FromArgb(255, 255, 255)
			Me.chtSurveyPlan.Height = 0.9375F
			Me.chtSurveyPlan.ImageData = Nothing
			Me.chtSurveyPlan.Left = 4.0625F
			Me.chtSurveyPlan.LineColor = Color.FromArgb(255, 255, 255)
			Me.chtSurveyPlan.Name = "chtSurveyPlan"
			Me.chtSurveyPlan.SizeMode = SizeModes.Stretch
			Me.chtSurveyPlan.Top = 2.375F
			Me.chtSurveyPlan.Width = 3.75F
			Me.chtDogLeg.BackColor = Color.FromArgb(255, 255, 255)
			Me.chtDogLeg.Height = 0.9375F
			Me.chtDogLeg.ImageData = Nothing
			Me.chtDogLeg.Left = 0.1875F
			Me.chtDogLeg.LineColor = Color.FromArgb(255, 255, 255)
			Me.chtDogLeg.Name = "chtDogLeg"
			Me.chtDogLeg.SizeMode = SizeModes.Stretch
			Me.chtDogLeg.Top = 3.3125F
			Me.chtDogLeg.Width = 3.75F
			Me.PageHeader.Controls.AddRange(New ARControl() { Me.lblComment, Me.lblTitle1, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserName, Me.lblUserDate, Me.lblLabel2, Me.lblCompany, Me.lblWellName, Me.lblDiskFile, Me.lblSecondCompanyName, Me.lblSecondCompanyPhonenumber, Me.lblGoTheta })
			Me.PageHeader.Height = 0.96875F
			Me.PageHeader.Name = "PageHeader"
			Me.lblComment.Height = 0.25F
			Me.lblComment.HyperLink = Nothing
			Me.lblComment.Left = 0.0625F
			Me.lblComment.Name = "lblComment"
			Me.lblComment.Style = "font-family: Microsoft Sans Serif; font-size: 8pt"
			Me.lblComment.Text = "Comment: "
			Me.lblComment.Top = 0.69F
			Me.lblComment.Width = 7.9375F
			Me.lblTitle1.Height = 0.17F
			Me.lblTitle1.HyperLink = Nothing
			Me.lblTitle1.Left = 0.0625F
			Me.lblTitle1.Name = "lblTitle1"
			Me.lblTitle1.Style = "font-family: Microsoft Sans Serif; font-size: 9pt; font-weight: bold; text-align: center"
			Me.lblTitle1.Text = "RODSTAR-D 1.0"
			Me.lblTitle1.Top = 0F
			Me.lblTitle1.Width = 7.9375F
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
			Me.lblWellName.Height = 0.17F
			Me.lblWellName.HyperLink = Nothing
			Me.lblWellName.Left = 0.0625F
			Me.lblWellName.Name = "lblWellName"
			Me.lblWellName.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblWellName.Text = "Well: "
			Me.lblWellName.Top = 0.34F
			Me.lblWellName.Width = 2.9375F
			Me.lblDiskFile.Height = 0.17F
			Me.lblDiskFile.HyperLink = Nothing
			Me.lblDiskFile.Left = 0.0625F
			Me.lblDiskFile.Name = "lblDiskFile"
			Me.lblDiskFile.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; white-space: nowrap"
			Me.lblDiskFile.Text = "Disk file: "
			Me.lblDiskFile.Top = 0.51F
			Me.lblDiskFile.Width = 2.9375F
			Me.lblSecondCompanyName.Height = 0.17F
			Me.lblSecondCompanyName.HyperLink = Nothing
			Me.lblSecondCompanyName.Left = 3F
			Me.lblSecondCompanyName.Name = "lblSecondCompanyName"
			Me.lblSecondCompanyName.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center"
			Me.lblSecondCompanyName.Text = ""
			Me.lblSecondCompanyName.Top = 0.34F
			Me.lblSecondCompanyName.Width = 2F
			Me.lblSecondCompanyPhonenumber.Height = 0.17F
			Me.lblSecondCompanyPhonenumber.HyperLink = Nothing
			Me.lblSecondCompanyPhonenumber.Left = 3F
			Me.lblSecondCompanyPhonenumber.Name = "lblSecondCompanyPhonenumber"
			Me.lblSecondCompanyPhonenumber.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center"
			Me.lblSecondCompanyPhonenumber.Text = ""
			Me.lblSecondCompanyPhonenumber.Top = 0.51F
			Me.lblSecondCompanyPhonenumber.Width = 2F
			Me.lblGoTheta.Height = 0.17F
			Me.lblGoTheta.HyperLink = Nothing
			Me.lblGoTheta.Left = 4.8125F
			Me.lblGoTheta.Name = "lblGoTheta"
			Me.lblGoTheta.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center"
			Me.lblGoTheta.Text = "(www.gotheta.com)"
			Me.lblGoTheta.Top = 0.18F
			Me.lblGoTheta.Width = 1.0625F
			Me.PageFooter.Height = 0.21875F
			Me.PageFooter.Name = "PageFooter"
			Me.MasterReport = False
			Me.PageSettings.Margins.Bottom = 0F
			Me.PageSettings.Margins.Left = 0.3F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0.2F
			Me.PageSettings.PaperHeight = 11F
			Me.PageSettings.PaperWidth = 8.5F
			Me.PrintWidth = 8.052083F
			Me.Sections.Add(Me.PageHeader)
			Me.Sections.Add(Me.Detail)
			Me.Sections.Add(Me.PageFooter)
			Me.StyleSheet.Add(New StyleSheetRule(componentResourceManager.GetString("$this.StyleSheet"), "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-weight: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("", "Heading4", "Normal"))
			CType(Me.chtSideForces, ISupportInitialize).EndInit()
			CType(Me.chtAxialLoads, ISupportInitialize).EndInit()
			CType(Me.chtBucklingTendency, ISupportInitialize).EndInit()
			CType(Me.chtSurveyEW, ISupportInitialize).EndInit()
			CType(Me.chtSurveyNS, ISupportInitialize).EndInit()
			CType(Me.chtSurveyPlan, ISupportInitialize).EndInit()
			CType(Me.chtDogLeg, ISupportInitialize).EndInit()
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
			CType(Me.lblWellName, ISupportInitialize).EndInit()
			CType(Me.lblDiskFile, ISupportInitialize).EndInit()
			CType(Me.lblSecondCompanyName, ISupportInitialize).EndInit()
			CType(Me.lblSecondCompanyPhonenumber, ISupportInitialize).EndInit()
			CType(Me.lblGoTheta, ISupportInitialize).EndInit()
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		Public Property bPrint As Boolean
			Get
				Return Me.m_bPrint
			End Get
			Set(value As Boolean)
				Me.m_bPrint = value
				Me.PageSettings.Orientation = PageOrientation.Portrait
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
				Me.lblWellName.Text = Me.sWell + Strings.Trim(rst.WellName)
				Dim text4 As String = Me.sThetaEnterprises
				Me.lblUserName.Text = Me.sUser + Strings.Trim(rst.UserName)
				Me.lblDiskFile.Text = Me.sDiskFile + Util.FileName(rst.Inputfile)
				If rst.FileComment Is Nothing Then
					rst.FileComment = ""
				End If
				Me.lblComment.Text = Me.sComment + rst.FileComment
				If Information.IsDate(rst.UserDate) Then
					Me.lblUserDate.Text = Me.sDate + Convert.ToDateTime(rst.UserDate).ToShortDateString()
				Else
					Me.lblUserDate.Text = Me.sDate + rst.UserDate
				End If
				Dim sDefaultName As String = "SecondCompanyName"
				Dim vNotPresentDefault As Object = ""
				Dim flag As Boolean = False
				Dim text5 As String = Conversions.ToString(ini.GetDefault(sDefaultName, vNotPresentDefault, flag))
				If text5 IsNot Nothing Then
					Me.lblSecondCompanyName.Text = text5
				Else
					Me.lblSecondCompanyName.Text = ""
				End If
				Dim sDefaultName2 As String = "SecondCompanyPhone"
				Dim vNotPresentDefault2 As Object = ""
				flag = False
				Dim text6 As String = Conversions.ToString(ini.GetDefault(sDefaultName2, vNotPresentDefault2, flag))
				If text6 IsNot Nothing Then
					Me.lblSecondCompanyPhonenumber.Text = text6
				Else
					Me.lblSecondCompanyPhonenumber.Text = ""
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub myReportStart(sender As Object, e As EventArgs)
			Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
			Dim picture As Picture = Me.chtSideForces
			picture.Left = 0F
			picture.Top = 0F
			picture.Width = 2.625F
			picture.Height = 3.5F
			Dim picture2 As Picture = Me.chtAxialLoads
			picture2.Left = 2.625F
			picture2.Top = 0F
			picture2.Width = 2.625F
			picture2.Height = 3.5F
			Dim picture3 As Picture = Me.chtBucklingTendency
			picture3.Left = 5.25F
			picture3.Top = 0F
			picture3.Width = 2.625F
			picture3.Height = 3.5F
			Dim picture4 As Picture = Me.chtSurveyNS
			picture4.Left = 3.95F
			picture4.Top = 3.5F
			picture4.Width = 3.9F
			picture4.Height = 2.75F
			Dim picture5 As Picture = Me.chtDogLeg
			picture5.Left = 0.063F
			picture5.Top = 3.5F
			picture5.Width = 3.9F
			picture5.Height = 2.75F
			Dim picture6 As Picture = Me.chtSurveyEW
			picture6.Left = 3.95F
			picture6.Top = 6.25F
			picture6.Width = 3.9F
			picture6.Height = 2.75F
			Dim picture7 As Picture = Me.chtSurveyPlan
			picture7.Left = 0.063F
			picture7.Top = 6.25F
			picture7.Width = 3.9F
			picture7.Height = 2.75F
			Try
				If RSWIN_DESC.bIntVersion Then
					If RSWIN_DESC.bWriteResXFile Then
						Util.OpenResourceWriter("rptDeviationSurvey")
						Me.WriteControlStrings()
						Util.CloseResourceWriter()
					End If
					If RSWIN_DESC.bReadResXFile Then
						Me.ReadReportControlStrings()
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ImportDogLegChart()
			Try
				Dim sDoglegsFileName As String = RSWIN_DESC.sDoglegsFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sDoglegsFileName)
				RSWIN_DESC.sDoglegsFileName = sDoglegsFileName
				If flag Then
					Try
						Dim bitmap As Bitmap = New Bitmap(RSWIN_DESC.sDoglegsFileName)
						Dim bitmap2 As Bitmap = New Bitmap(bitmap)
						bitmap.Dispose()
						Me.chtDogLeg.Image = CType(bitmap2.Clone(), Image)
						bitmap2.Dispose()
					Catch ex As Exception
					Finally
						Dim bitmap2 As Bitmap
						bitmap2.Dispose()
					End Try
					Try
						sDoglegsFileName = RSWIN_DESC.sDoglegsFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(sDoglegsFileName)
						RSWIN_DESC.sDoglegsFileName = sDoglegsFileName
						If flag2 Then
							FileSystem.Kill(RSWIN_DESC.sDoglegsFileName)
						End If
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub ImportSideForcesChart()
			Try
				Dim sSideForcesFileName As String = RSWIN_DESC.sSideForcesFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sSideForcesFileName)
				RSWIN_DESC.sSideForcesFileName = sSideForcesFileName
				If flag Then
					Try
						Dim bitmap As Bitmap = New Bitmap(RSWIN_DESC.sSideForcesFileName)
						Dim bitmap2 As Bitmap = New Bitmap(bitmap)
						bitmap.Dispose()
						Me.chtSideForces.Image = CType(bitmap2.Clone(), Image)
						bitmap2.Dispose()
					Catch ex As Exception
					Finally
						Dim bitmap2 As Bitmap
						bitmap2.Dispose()
					End Try
					Try
						sSideForcesFileName = RSWIN_DESC.sSideForcesFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(sSideForcesFileName)
						RSWIN_DESC.sSideForcesFileName = sSideForcesFileName
						If flag2 Then
							FileSystem.Kill(RSWIN_DESC.sSideForcesFileName)
						End If
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub ImportAxialLoadsChart()
			Try
				Dim sAxialPlotFileName As String = RSWIN_DESC.sAxialPlotFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sAxialPlotFileName)
				RSWIN_DESC.sAxialPlotFileName = sAxialPlotFileName
				If flag Then
					Try
						Dim bitmap As Bitmap = New Bitmap(RSWIN_DESC.sAxialPlotFileName)
						Dim bitmap2 As Bitmap = New Bitmap(bitmap)
						bitmap.Dispose()
						Me.chtAxialLoads.Image = CType(bitmap2.Clone(), Image)
						bitmap2.Dispose()
					Catch ex As Exception
					Finally
						Dim bitmap2 As Bitmap
						bitmap2.Dispose()
					End Try
					Try
						sAxialPlotFileName = RSWIN_DESC.sAxialPlotFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(sAxialPlotFileName)
						RSWIN_DESC.sAxialPlotFileName = sAxialPlotFileName
						If flag2 Then
							FileSystem.Kill(RSWIN_DESC.sAxialPlotFileName)
						End If
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub ImportBucklingTendencyChart()
			Try
				Dim sBucklingTendencyFileName As String = RSWIN_DESC.sBucklingTendencyFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sBucklingTendencyFileName)
				RSWIN_DESC.sBucklingTendencyFileName = sBucklingTendencyFileName
				If flag Then
					Try
						Dim bitmap As Bitmap = New Bitmap(RSWIN_DESC.sBucklingTendencyFileName)
						Dim bitmap2 As Bitmap = New Bitmap(bitmap)
						bitmap.Dispose()
						Me.chtBucklingTendency.Image = CType(bitmap2.Clone(), Image)
						bitmap2.Dispose()
					Catch ex As Exception
					Finally
						Dim bitmap2 As Bitmap
						bitmap2.Dispose()
					End Try
					Try
						sBucklingTendencyFileName = RSWIN_DESC.sBucklingTendencyFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(sBucklingTendencyFileName)
						RSWIN_DESC.sBucklingTendencyFileName = sBucklingTendencyFileName
						If flag2 Then
							FileSystem.Kill(RSWIN_DESC.sBucklingTendencyFileName)
						End If
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub ImportSurveyEWChart()
			Try
				Dim sSurveyEWFileName As String = RSWIN_DESC.sSurveyEWFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sSurveyEWFileName)
				RSWIN_DESC.sSurveyEWFileName = sSurveyEWFileName
				If flag Then
					Try
						Dim bitmap As Bitmap = New Bitmap(RSWIN_DESC.sSurveyEWFileName)
						Dim bitmap2 As Bitmap = New Bitmap(bitmap)
						bitmap.Dispose()
						Me.chtSurveyEW.Image = CType(bitmap2.Clone(), Image)
						bitmap2.Dispose()
					Catch ex As Exception
					Finally
						Dim bitmap2 As Bitmap
						bitmap2.Dispose()
					End Try
					Try
						sSurveyEWFileName = RSWIN_DESC.sSurveyEWFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(sSurveyEWFileName)
						RSWIN_DESC.sSurveyEWFileName = sSurveyEWFileName
						If flag2 Then
							FileSystem.Kill(RSWIN_DESC.sSurveyEWFileName)
						End If
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub ImportSurveyNSChart()
			Try
				Dim sSurveyNSFileName As String = RSWIN_DESC.sSurveyNSFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sSurveyNSFileName)
				RSWIN_DESC.sSurveyNSFileName = sSurveyNSFileName
				If flag Then
					Try
						Dim bitmap As Bitmap = New Bitmap(RSWIN_DESC.sSurveyNSFileName)
						Dim bitmap2 As Bitmap = New Bitmap(bitmap)
						bitmap.Dispose()
						Me.chtSurveyNS.Image = CType(bitmap2.Clone(), Image)
						bitmap2.Dispose()
					Catch ex As Exception
					Finally
						Dim bitmap2 As Bitmap
						bitmap2.Dispose()
					End Try
					Try
						sSurveyNSFileName = RSWIN_DESC.sSurveyNSFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(sSurveyNSFileName)
						RSWIN_DESC.sSurveyNSFileName = sSurveyNSFileName
						If flag2 Then
							FileSystem.Kill(RSWIN_DESC.sSurveyNSFileName)
						End If
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub ImportSurveyPlanPlotChart()
			Try
				Dim sSurveyPlanFileName As String = RSWIN_DESC.sSurveyPlanFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sSurveyPlanFileName)
				RSWIN_DESC.sSurveyPlanFileName = sSurveyPlanFileName
				If flag Then
					Try
						Dim bitmap As Bitmap = New Bitmap(RSWIN_DESC.sSurveyPlanFileName)
						Dim bitmap2 As Bitmap = New Bitmap(bitmap)
						bitmap.Dispose()
						Me.chtSurveyPlan.Image = CType(bitmap2.Clone(), Image)
						bitmap2.Dispose()
					Catch ex As Exception
					Finally
						Dim bitmap2 As Bitmap
						bitmap2.Dispose()
					End Try
					Try
						sSurveyPlanFileName = RSWIN_DESC.sSurveyPlanFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(sSurveyPlanFileName)
						RSWIN_DESC.sSurveyPlanFileName = sSurveyPlanFileName
						If flag2 Then
							FileSystem.Kill(RSWIN_DESC.sSurveyPlanFileName)
						End If
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
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

		Private Sub Detail_Format(sender As Object, e As EventArgs)
		End Sub

		Private Sub ReadReportControlStrings()
			Dim sPrefix As String = "rptDeviationSurvey-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = Me.PageHeader.Controls.Count - 1
				For i As Integer = num To num2
					Try
						If Me.PageHeader.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.PageHeader.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex As Exception
					End Try
				Next
				Dim num3 As Integer = 0
				Dim num4 As Integer = Me.PageFooter.Controls.Count - 1
				For i As Integer = num3 To num4
					Try
						If Me.PageFooter.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.PageFooter.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex2 As Exception
					End Try
				Next
				Dim num5 As Integer = 0
				Dim num6 As Integer = Me.Detail.Controls.Count - 1
				For i As Integer = num5 To num6
					Try
						If Me.Detail.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.Detail.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex3 As Exception
					End Try
				Next
			Catch ex4 As Exception
			End Try
		End Sub

		Public Sub AssignValueToReportControl(sPrefix As String, ByRef objControl As Label)
			Try
				Dim text As String = sPrefix + objControl.Name
				text = text.ToLower()
				If RSWIN_DESC.bRunningChineseVersion Then
					text = text.Replace("-zh-hans-", "-")
					Dim [string] As String = cGlobal.Lang.GetString(text)
					If [string] IsNot Nothing Then
						If Operators.CompareString([string].Trim(), "", False) <> 0 Then
							objControl.Text = [string]
							text = sPrefix + objControl.Name + "-TAG"
							text = text.ToLower()
							[string] = cGlobal.Lang.GetString(text)
							If [string] IsNot Nothing AndAlso Operators.CompareString([string].Trim(), "", False) <> 0 Then
								objControl.Tag = [string]
							End If
						End If
					End If
				ElseIf RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
					objControl.Text = Conversions.ToString(RSWIN_DESC.myALLKeyValueHT(text))
					text = sPrefix + objControl.Name + "-TAG"
					text = text.ToLower()
					If RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
						objControl.Tag = RuntimeHelpers.GetObjectValue(RSWIN_DESC.myALLKeyValueHT(text))
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub WriteControlStrings()
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = Me.Detail.Controls.Count - 1
				For i As Integer = num To num2
					Try
						If Me.Detail.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.Detail.Controls(i), Label)
							If Operators.CompareString(label.Name.Substring(0, Me.slbl.Length), Me.slbl, False) = 0 Then
								Me.AddRexResource(label.Name, label.Text)
							End If
						End If
					Catch ex As Exception
						Debug.WriteLine(ex.Message)
					End Try
				Next
				Dim num3 As Integer = 0
				Dim num4 As Integer = Me.PageHeader.Controls.Count - 1
				For i As Integer = num3 To num4
					Try
						If Me.PageHeader.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.PageHeader.Controls(i), Label)
							If Operators.CompareString(label.Name.Substring(0, Me.slbl.Length), Me.slbl, False) = 0 Then
								Me.AddRexResource(label.Name, label.Text)
							End If
						End If
					Catch ex2 As Exception
						Debug.WriteLine(ex2.Message)
					End Try
				Next
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub AddRexResource(sKey As String, sVal As String)
			RSWIN_DESC.RwX.AddResource(sKey, sVal)
		End Sub

		<AccessedThroughProperty("PageHeader")>
		Private _PageHeader As PageHeader

		<AccessedThroughProperty("Detail")>
		Private _Detail As Detail

		<AccessedThroughProperty("PageFooter")>
		Private _PageFooter As PageFooter

		Private lblComment As Label

		Private lblTitle1 As Label

		Private lblPage As Label

		Private txtPage1 As TextBox

		Private lblOf As Label

		Private txtPage2 As TextBox

		Private lblUserName As Label

		Private lblUserDate As Label

		Private lblLabel2 As Label

		Private lblCompany As Label

		Private lblWellName As Label

		Private lblDiskFile As Label

		Private lblSecondCompanyName As Label

		Private lblSecondCompanyPhonenumber As Label

		Private lblGoTheta As Label

		Private PageBreak1 As PageBreak

		Private chtSideForces As Picture

		Private chtAxialLoads As Picture

		Private chtBucklingTendency As Picture

		Private chtSurveyEW As Picture

		Private chtSurveyNS As Picture

		Private chtSurveyPlan As Picture

		Private chtDogLeg As Picture

		Private sCompany As String

		Private sWell As String

		Private sUser As String

		Private sDiskFile As String

		Private sDate As String

		Private sPage As String

		Private sOf As String

		Private sComment As String

		Private sLicenseTo As String

		Private slbl As String

		Private sThetaEnterprises As String

		Private m_bPrint As Boolean

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer
	End Class
End Namespace
