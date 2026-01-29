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
	Public Class rptExpertAnalysis
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.FetchData, AddressOf Me.rptExpertAnalysis_FetchData
			AddHandler MyBase.ReportStart, AddressOf Me.rptExpertAnalysis_ReportStart
			Me.ReportLines = New rptExpertAnalysis.ReportLine_Struct(100) {}
			Me.sNull = ""
			Me.slbl = Util.AssignValueToConstant("rptExpertAnalysis", "slbl", "lbl")
			Me.sScoreAPlus = Util.AssignValueToConstant("rptExpertSummary", "sScoreAPlus", "A+")
			Me.sScoreA = Util.AssignValueToConstant("rptExpertSummary", "sScoreA", "A")
			Me.sScoreAMinus = Util.AssignValueToConstant("rptExpertSummary", "sScoreAMinus", "A-")
			Me.sScoreBPlus = Util.AssignValueToConstant("rptExpertSummary", "sScoreBPlus", "B+")
			Me.sScoreB = Util.AssignValueToConstant("rptExpertSummary", "sScoreB", "B")
			Me.sScoreBMinus = Util.AssignValueToConstant("rptExpertSummary", "sScoreBMinus", "B-")
			Me.sScoreC = Util.AssignValueToConstant("rptExpertSummary", "sScoreC", "C")
			Me.sScoreD = Util.AssignValueToConstant("rptExpertSummary", "sScoreD", "D")
			Me.sScoreF = Util.AssignValueToConstant("rptExpertSummary", "sScoreF", "F")
			Me.PageHeader = Nothing
			Me.GroupHeader1 = Nothing
			Me.Detail = Nothing
			Me.GroupFooter1 = Nothing
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
			Me.lblOtherRLS = Nothing
			Me.lblTOTALSCORE = Nothing
			Me.lblGEARBOXSCORE = Nothing
			Me.lblRODLOADINGSCORE = Nothing
			Me.lblSTRUCTURELOADINGSCORE = Nothing
			Me.lblSYSTEMEFFICIENCYSCORE = Nothing
			Me.lblGB_70_95 = Nothing
			Me.lblGB_60_70 = Nothing
			Me.lblGB_50_60 = Nothing
			Me.lblGB_95_100 = Nothing
			Me.lblGB_100_110 = Nothing
			Me.lblGB_110_120 = Nothing
			Me.lblGB_120_135 = Nothing
			Me.lblRL_70_95 = Nothing
			Me.lblRL_60_70 = Nothing
			Me.lblRL_50_60 = Nothing
			Me.lblRL_40_50 = Nothing
			Me.lblRL_40 = Nothing
			Me.lblSL_70_95 = Nothing
			Me.lblSL_60_70 = Nothing
			Me.lblSL_50_60 = Nothing
			Me.lblSL_50 = Nothing
			Me.lblSL_95_100 = Nothing
			Me.lblSL_100_110 = Nothing
			Me.lblSL_110_120 = Nothing
			Me.lblSEF_45 = Nothing
			Me.lblSEF_42_45 = Nothing
			Me.lblSEF_35_40 = Nothing
			Me.lblSEF_30_35 = Nothing
			Me.lblSEF_25 = Nothing
			Me.lblGB_50 = Nothing
			Me.lblSL_SmallUnit = Nothing
			Me.lblBottomMinStressSCORE = Nothing
			Me.lblBotMin_1000 = Nothing
			Me.lblFootNote = Nothing
			Me.lblGB_135 = Nothing
			Me.lblRL_70_C = Nothing
			Me.lblRL_95_100 = Nothing
			Me.lblRL_100_110 = Nothing
			Me.lblRL_110_120 = Nothing
			Me.lblRL_120 = Nothing
			Me.lblSL_120 = Nothing
			Me.lblGB_SmallUnit = Nothing
			Me.lblSEF_25_30 = Nothing
			Me.lblBotMin_100_200 = Nothing
			Me.lblBotMin_50_100 = Nothing
			Me.lblBotMin_25_50 = Nothing
			Me.lblBotMin_0_25 = Nothing
			Me.lblBotMin_300_0 = Nothing
			Me.lblBotMin_300 = Nothing
			Me.lblBotMin_2000_3000 = Nothing
			Me.lblSteel = Nothing
			Me.lblBotMin_FG_400_1000 = Nothing
			Me.lblBotMin_FG_50_400 = Nothing
			Me.lblBotMin_FG_1000 = Nothing
			Me.lblFGlassSteel = Nothing
			Me.lblBotMin_200_300 = Nothing
			Me.lblBotMin_300_650 = Nothing
			Me.lblBotMin_3000 = Nothing
			Me.lblBotMin_FG_0 = Nothing
			Me.lblMPRL = Nothing
			Me.lblMPRL_200 = Nothing
			Me.lblMPRL_100_200 = Nothing
			Me.lblMPRL_50_100 = Nothing
			Me.lblMPRL_20_50 = Nothing
			Me.lblMPRL_0_20 = Nothing
			Me.lblMPRL_0 = Nothing
			Me.lblBotMin_650_800 = Nothing
			Me.lblBotMin_800_1200 = Nothing
			Me.lblBotMin_1200_2000 = Nothing
			Me.lblFootNote2 = Nothing
			Me.lblSEF_40_42 = Nothing
			Me.lblOtherGB = Nothing
			Me.lblOtherSL = Nothing
			Me.sAirAtTankAt = Util.AssignValueToConstant("rptCalcResults", "sAirAtTankAt", "Air tank pressure at")
			Me.sLicenseTo = Util.AssignValueToConstant("rptCalcResults", "sLicenseTo", " - Licensed to ")
			Me.sCompany = Util.AssignValueToConstant("rptCalcResults", "sCompany", "Company: ")
			Me.sWell = Util.AssignValueToConstant("rptCalcResults", "sWell", "Well: ")
			Me.sUser = Util.AssignValueToConstant("rptCalcResults", "sUser", "User: ")
			Me.sDiskFile = Util.AssignValueToConstant("rptCalcResults", "sDiskFile", "Disk file: ")
			Me.sDate = Util.AssignValueToConstant("rptCalcResults", "sDate", "Date: ")
			Me.sPage = Util.AssignValueToConstant("rptCalcResults", "sPage", "Page")
			Me.sOf = Util.AssignValueToConstant("rptCalcResults", "sOf", "of")
			Me.sComment = Util.AssignValueToConstant("rptCalcResults", "sComment", "Comment: ")
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

		Private Overridable Property GroupHeader1 As GroupHeader
			Get
				Return Me._GroupHeader1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupHeader)
				Dim value2 As EventHandler = AddressOf Me.GroupHeader1_Format
				If Me._GroupHeader1 IsNot Nothing Then
					RemoveHandler Me._GroupHeader1.Format, value2
				End If
				Me._GroupHeader1 = value
				If Me._GroupHeader1 IsNot Nothing Then
					AddHandler Me._GroupHeader1.Format, value2
				End If
			End Set
		End Property

		Private Overridable Property Detail As Detail
			Get
				Return Me._Detail
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Detail)
				Me._Detail = value
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
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptExpertAnalysis))
			Me.Detail = New Detail()
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
			Me.GroupHeader1 = New GroupHeader()
			Me.lblOtherRLS = New Label()
			Me.lblTOTALSCORE = New Label()
			Me.lblGEARBOXSCORE = New Label()
			Me.lblRODLOADINGSCORE = New Label()
			Me.lblSTRUCTURELOADINGSCORE = New Label()
			Me.lblSYSTEMEFFICIENCYSCORE = New Label()
			Me.lblGB_70_95 = New Label()
			Me.lblGB_60_70 = New Label()
			Me.lblGB_50_60 = New Label()
			Me.lblGB_95_100 = New Label()
			Me.lblGB_100_110 = New Label()
			Me.lblGB_110_120 = New Label()
			Me.lblGB_120_135 = New Label()
			Me.lblRL_70_95 = New Label()
			Me.lblRL_60_70 = New Label()
			Me.lblRL_50_60 = New Label()
			Me.lblRL_40_50 = New Label()
			Me.lblRL_40 = New Label()
			Me.lblSL_70_95 = New Label()
			Me.lblSL_60_70 = New Label()
			Me.lblSL_50_60 = New Label()
			Me.lblSL_50 = New Label()
			Me.lblSL_95_100 = New Label()
			Me.lblSL_100_110 = New Label()
			Me.lblSL_110_120 = New Label()
			Me.lblSEF_45 = New Label()
			Me.lblSEF_42_45 = New Label()
			Me.lblSEF_35_40 = New Label()
			Me.lblSEF_30_35 = New Label()
			Me.lblSEF_25 = New Label()
			Me.lblGB_50 = New Label()
			Me.lblSL_SmallUnit = New Label()
			Me.lblBottomMinStressSCORE = New Label()
			Me.lblBotMin_1000 = New Label()
			Me.lblFootNote = New Label()
			Me.lblGB_135 = New Label()
			Me.lblRL_70_C = New Label()
			Me.lblRL_95_100 = New Label()
			Me.lblRL_100_110 = New Label()
			Me.lblRL_110_120 = New Label()
			Me.lblRL_120 = New Label()
			Me.lblSL_120 = New Label()
			Me.lblGB_SmallUnit = New Label()
			Me.lblSEF_25_30 = New Label()
			Me.lblBotMin_100_200 = New Label()
			Me.lblBotMin_50_100 = New Label()
			Me.lblBotMin_25_50 = New Label()
			Me.lblBotMin_0_25 = New Label()
			Me.lblBotMin_300_0 = New Label()
			Me.lblBotMin_300 = New Label()
			Me.lblBotMin_2000_3000 = New Label()
			Me.lblSteel = New Label()
			Me.lblBotMin_FG_400_1000 = New Label()
			Me.lblBotMin_FG_50_400 = New Label()
			Me.lblBotMin_FG_1000 = New Label()
			Me.lblFGlassSteel = New Label()
			Me.lblBotMin_200_300 = New Label()
			Me.lblBotMin_300_650 = New Label()
			Me.lblBotMin_3000 = New Label()
			Me.lblBotMin_FG_0 = New Label()
			Me.lblMPRL = New Label()
			Me.lblMPRL_200 = New Label()
			Me.lblMPRL_100_200 = New Label()
			Me.lblMPRL_50_100 = New Label()
			Me.lblMPRL_20_50 = New Label()
			Me.lblMPRL_0_20 = New Label()
			Me.lblMPRL_0 = New Label()
			Me.lblBotMin_650_800 = New Label()
			Me.lblBotMin_800_1200 = New Label()
			Me.lblBotMin_1200_2000 = New Label()
			Me.lblFootNote2 = New Label()
			Me.lblSEF_40_42 = New Label()
			Me.lblOtherGB = New Label()
			Me.lblOtherSL = New Label()
			Me.GroupFooter1 = New GroupFooter()
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
			CType(Me.lblOtherRLS, ISupportInitialize).BeginInit()
			CType(Me.lblTOTALSCORE, ISupportInitialize).BeginInit()
			CType(Me.lblGEARBOXSCORE, ISupportInitialize).BeginInit()
			CType(Me.lblRODLOADINGSCORE, ISupportInitialize).BeginInit()
			CType(Me.lblSTRUCTURELOADINGSCORE, ISupportInitialize).BeginInit()
			CType(Me.lblSYSTEMEFFICIENCYSCORE, ISupportInitialize).BeginInit()
			CType(Me.lblGB_70_95, ISupportInitialize).BeginInit()
			CType(Me.lblGB_60_70, ISupportInitialize).BeginInit()
			CType(Me.lblGB_50_60, ISupportInitialize).BeginInit()
			CType(Me.lblGB_95_100, ISupportInitialize).BeginInit()
			CType(Me.lblGB_100_110, ISupportInitialize).BeginInit()
			CType(Me.lblGB_110_120, ISupportInitialize).BeginInit()
			CType(Me.lblGB_120_135, ISupportInitialize).BeginInit()
			CType(Me.lblRL_70_95, ISupportInitialize).BeginInit()
			CType(Me.lblRL_60_70, ISupportInitialize).BeginInit()
			CType(Me.lblRL_50_60, ISupportInitialize).BeginInit()
			CType(Me.lblRL_40_50, ISupportInitialize).BeginInit()
			CType(Me.lblRL_40, ISupportInitialize).BeginInit()
			CType(Me.lblSL_70_95, ISupportInitialize).BeginInit()
			CType(Me.lblSL_60_70, ISupportInitialize).BeginInit()
			CType(Me.lblSL_50_60, ISupportInitialize).BeginInit()
			CType(Me.lblSL_50, ISupportInitialize).BeginInit()
			CType(Me.lblSL_95_100, ISupportInitialize).BeginInit()
			CType(Me.lblSL_100_110, ISupportInitialize).BeginInit()
			CType(Me.lblSL_110_120, ISupportInitialize).BeginInit()
			CType(Me.lblSEF_45, ISupportInitialize).BeginInit()
			CType(Me.lblSEF_42_45, ISupportInitialize).BeginInit()
			CType(Me.lblSEF_35_40, ISupportInitialize).BeginInit()
			CType(Me.lblSEF_30_35, ISupportInitialize).BeginInit()
			CType(Me.lblSEF_25, ISupportInitialize).BeginInit()
			CType(Me.lblGB_50, ISupportInitialize).BeginInit()
			CType(Me.lblSL_SmallUnit, ISupportInitialize).BeginInit()
			CType(Me.lblBottomMinStressSCORE, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_1000, ISupportInitialize).BeginInit()
			CType(Me.lblFootNote, ISupportInitialize).BeginInit()
			CType(Me.lblGB_135, ISupportInitialize).BeginInit()
			CType(Me.lblRL_70_C, ISupportInitialize).BeginInit()
			CType(Me.lblRL_95_100, ISupportInitialize).BeginInit()
			CType(Me.lblRL_100_110, ISupportInitialize).BeginInit()
			CType(Me.lblRL_110_120, ISupportInitialize).BeginInit()
			CType(Me.lblRL_120, ISupportInitialize).BeginInit()
			CType(Me.lblSL_120, ISupportInitialize).BeginInit()
			CType(Me.lblGB_SmallUnit, ISupportInitialize).BeginInit()
			CType(Me.lblSEF_25_30, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_100_200, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_50_100, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_25_50, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_0_25, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_300_0, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_300, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_2000_3000, ISupportInitialize).BeginInit()
			CType(Me.lblSteel, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_FG_400_1000, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_FG_50_400, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_FG_1000, ISupportInitialize).BeginInit()
			CType(Me.lblFGlassSteel, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_200_300, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_300_650, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_3000, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_FG_0, ISupportInitialize).BeginInit()
			CType(Me.lblMPRL, ISupportInitialize).BeginInit()
			CType(Me.lblMPRL_200, ISupportInitialize).BeginInit()
			CType(Me.lblMPRL_100_200, ISupportInitialize).BeginInit()
			CType(Me.lblMPRL_50_100, ISupportInitialize).BeginInit()
			CType(Me.lblMPRL_20_50, ISupportInitialize).BeginInit()
			CType(Me.lblMPRL_0_20, ISupportInitialize).BeginInit()
			CType(Me.lblMPRL_0, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_650_800, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_800_1200, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_1200_2000, ISupportInitialize).BeginInit()
			CType(Me.lblFootNote2, ISupportInitialize).BeginInit()
			CType(Me.lblSEF_40_42, ISupportInitialize).BeginInit()
			CType(Me.lblOtherGB, ISupportInitialize).BeginInit()
			CType(Me.lblOtherSL, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Height = 0.01041667F
			Me.Detail.Name = "Detail"
			Me.PageHeader.Controls.AddRange(New ARControl() { Me.lblComment, Me.lblTitle1, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserName, Me.lblUserDate, Me.lblLabel2, Me.lblCompany, Me.lblWellName, Me.lblDiskFile, Me.lblSecondCompanyName, Me.lblSecondCompanyPhonenumber, Me.lblGoTheta })
			Me.PageHeader.Height = 0.9791667F
			Me.PageHeader.Name = "PageHeader"
			Me.lblComment.Height = 0.25F
			Me.lblComment.HyperLink = Nothing
			Me.lblComment.Left = 0.0625F
			Me.lblComment.Name = "lblComment"
			Me.lblComment.Style = "font-family: Microsoft Sans Serif; font-size: 8pt"
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
			Me.PageFooter.Height = 0F
			Me.PageFooter.Name = "PageFooter"
			Me.GroupHeader1.Controls.AddRange(New ARControl() { Me.lblOtherRLS, Me.lblTOTALSCORE, Me.lblGEARBOXSCORE, Me.lblRODLOADINGSCORE, Me.lblSTRUCTURELOADINGSCORE, Me.lblSYSTEMEFFICIENCYSCORE, Me.lblGB_70_95, Me.lblGB_60_70, Me.lblGB_50_60, Me.lblGB_95_100, Me.lblGB_100_110, Me.lblGB_110_120, Me.lblGB_120_135, Me.lblRL_70_95, Me.lblRL_60_70, Me.lblRL_50_60, Me.lblRL_40_50, Me.lblRL_40, Me.lblSL_70_95, Me.lblSL_60_70, Me.lblSL_50_60, Me.lblSL_50, Me.lblSL_95_100, Me.lblSL_100_110, Me.lblSL_110_120, Me.lblSEF_45, Me.lblSEF_42_45, Me.lblSEF_35_40, Me.lblSEF_30_35, Me.lblSEF_25, Me.lblGB_50, Me.lblSL_SmallUnit, Me.lblBottomMinStressSCORE, Me.lblBotMin_1000, Me.lblFootNote, Me.lblGB_135, Me.lblRL_70_C, Me.lblRL_95_100, Me.lblRL_100_110, Me.lblRL_110_120, Me.lblRL_120, Me.lblSL_120, Me.lblGB_SmallUnit, Me.lblSEF_25_30, Me.lblBotMin_100_200, Me.lblBotMin_50_100, Me.lblBotMin_25_50, Me.lblBotMin_0_25, Me.lblBotMin_300_0, Me.lblBotMin_300, Me.lblBotMin_2000_3000, Me.lblSteel, Me.lblBotMin_FG_400_1000, Me.lblBotMin_FG_50_400, Me.lblBotMin_FG_1000, Me.lblFGlassSteel, Me.lblBotMin_200_300, Me.lblBotMin_300_650, Me.lblBotMin_3000, Me.lblBotMin_FG_0, Me.lblMPRL, Me.lblMPRL_200, Me.lblMPRL_100_200, Me.lblMPRL_50_100, Me.lblMPRL_20_50, Me.lblMPRL_0_20, Me.lblMPRL_0, Me.lblBotMin_650_800, Me.lblBotMin_800_1200, Me.lblBotMin_1200_2000, Me.lblFootNote2, Me.lblSEF_40_42, Me.lblOtherGB, Me.lblOtherSL })
			Me.GroupHeader1.Height = 9.510417F
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.lblOtherRLS.Height = 0.1875F
			Me.lblOtherRLS.HyperLink = Nothing
			Me.lblOtherRLS.Left = 0.0625F
			Me.lblOtherRLS.Name = "lblOtherRLS"
			Me.lblOtherRLS.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblOtherRLS.Text = "Score   60 - 40% <= Rod loading <= 50%"
			Me.lblOtherRLS.Top = 2.5625F
			Me.lblOtherRLS.Width = 3.75F
			Me.lblTOTALSCORE.Height = 0.195F
			Me.lblTOTALSCORE.HyperLink = Nothing
			Me.lblTOTALSCORE.Left = 0.0625F
			Me.lblTOTALSCORE.Name = "lblTOTALSCORE"
			Me.lblTOTALSCORE.Style = "background-color: LightGrey; font-size: 12pt; font-weight: normal; text-align: center"
			Me.lblTOTALSCORE.Text = "TOTAL SCORE: "
			Me.lblTOTALSCORE.Top = 0F
			Me.lblTOTALSCORE.Width = 7.5F
			Me.lblGEARBOXSCORE.Height = 0.1875F
			Me.lblGEARBOXSCORE.HyperLink = Nothing
			Me.lblGEARBOXSCORE.Left = 0.0625F
			Me.lblGEARBOXSCORE.Name = "lblGEARBOXSCORE"
			Me.lblGEARBOXSCORE.Style = "background-color: Gainsboro; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblGEARBOXSCORE.Text = "BALANCED GEARBOX  LOADING SCORE:"
			Me.lblGEARBOXSCORE.Top = 0.25F
			Me.lblGEARBOXSCORE.Width = 7.5F
			Me.lblRODLOADINGSCORE.Height = 0.1875F
			Me.lblRODLOADINGSCORE.HyperLink = Nothing
			Me.lblRODLOADINGSCORE.Left = 0.0625F
			Me.lblRODLOADINGSCORE.Name = "lblRODLOADINGSCORE"
			Me.lblRODLOADINGSCORE.Style = "background-color: Gainsboro; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblRODLOADINGSCORE.Text = "MAXIMUM ROD LOADING SCORE:"
			Me.lblRODLOADINGSCORE.Top = 1.625F
			Me.lblRODLOADINGSCORE.Width = 7.5F
			Me.lblSTRUCTURELOADINGSCORE.Height = 0.1875F
			Me.lblSTRUCTURELOADINGSCORE.HyperLink = Nothing
			Me.lblSTRUCTURELOADINGSCORE.Left = 0.0625F
			Me.lblSTRUCTURELOADINGSCORE.Name = "lblSTRUCTURELOADINGSCORE"
			Me.lblSTRUCTURELOADINGSCORE.Style = "background-color: Gainsboro; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblSTRUCTURELOADINGSCORE.Text = "STRUCTURE LOADING SCORE:"
			Me.lblSTRUCTURELOADINGSCORE.Top = 2.875F
			Me.lblSTRUCTURELOADINGSCORE.Width = 7.5F
			Me.lblSYSTEMEFFICIENCYSCORE.Height = 0.1875F
			Me.lblSYSTEMEFFICIENCYSCORE.HyperLink = Nothing
			Me.lblSYSTEMEFFICIENCYSCORE.Left = 0.0625F
			Me.lblSYSTEMEFFICIENCYSCORE.Name = "lblSYSTEMEFFICIENCYSCORE"
			Me.lblSYSTEMEFFICIENCYSCORE.Style = "background-color: Gainsboro; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblSYSTEMEFFICIENCYSCORE.Text = "SYSTEM EFFICIENCY SCORE: "
			Me.lblSYSTEMEFFICIENCYSCORE.Top = 4.3125F
			Me.lblSYSTEMEFFICIENCYSCORE.Width = 7.5F
			Me.lblGB_70_95.Height = 0.1875F
			Me.lblGB_70_95.HyperLink = Nothing
			Me.lblGB_70_95.Left = 0.0625F
			Me.lblGB_70_95.Name = "lblGB_70_95"
			Me.lblGB_70_95.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblGB_70_95.Text = "Score 100 - 70% <= Gearbox loading <= 95%"
			Me.lblGB_70_95.Top = 0.4375F
			Me.lblGB_70_95.Width = 3.75F
			Me.lblGB_60_70.Height = 0.1875F
			Me.lblGB_60_70.HyperLink = Nothing
			Me.lblGB_60_70.Left = 0.0625F
			Me.lblGB_60_70.Name = "lblGB_60_70"
			Me.lblGB_60_70.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblGB_60_70.Text = "Score   85 - 60% <= Gearbox loading < 70%"
			Me.lblGB_60_70.Top = 0.625F
			Me.lblGB_60_70.Width = 3.75F
			Me.lblGB_50_60.Height = 0.1875F
			Me.lblGB_50_60.HyperLink = Nothing
			Me.lblGB_50_60.Left = 0.0625F
			Me.lblGB_50_60.Name = "lblGB_50_60"
			Me.lblGB_50_60.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblGB_50_60.Text = "Score   70 - 50% <= Gearbox loading < 60%"
			Me.lblGB_50_60.Top = 0.8125F
			Me.lblGB_50_60.Width = 3.75F
			Me.lblGB_95_100.Height = 0.1875F
			Me.lblGB_95_100.HyperLink = Nothing
			Me.lblGB_95_100.Left = 3.8125F
			Me.lblGB_95_100.Name = "lblGB_95_100"
			Me.lblGB_95_100.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblGB_95_100.Text = "Score 75 -   95% < Gearbox loading <= 100%"
			Me.lblGB_95_100.Top = 0.4375F
			Me.lblGB_95_100.Width = 3.75F
			Me.lblGB_100_110.Height = 0.1875F
			Me.lblGB_100_110.HyperLink = Nothing
			Me.lblGB_100_110.Left = 3.8125F
			Me.lblGB_100_110.Name = "lblGB_100_110"
			Me.lblGB_100_110.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblGB_100_110.Text = "Score 35 - 100% < Gearbox loading <= 110%"
			Me.lblGB_100_110.Top = 0.625F
			Me.lblGB_100_110.Width = 3.75F
			Me.lblGB_110_120.Height = 0.1875F
			Me.lblGB_110_120.HyperLink = Nothing
			Me.lblGB_110_120.Left = 3.8125F
			Me.lblGB_110_120.Name = "lblGB_110_120"
			Me.lblGB_110_120.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblGB_110_120.Text = "Score 20 - 110% < Gearbox loading <= 120%"
			Me.lblGB_110_120.Top = 0.8125F
			Me.lblGB_110_120.Width = 3.75F
			Me.lblGB_120_135.Height = 0.1875F
			Me.lblGB_120_135.HyperLink = Nothing
			Me.lblGB_120_135.Left = 3.8125F
			Me.lblGB_120_135.Name = "lblGB_120_135"
			Me.lblGB_120_135.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblGB_120_135.Text = "Score 10 - 120% < Gearbox loading <= 135%"
			Me.lblGB_120_135.Top = 1F
			Me.lblGB_120_135.Width = 3.75F
			Me.lblRL_70_95.Height = 0.1875F
			Me.lblRL_70_95.HyperLink = Nothing
			Me.lblRL_70_95.Left = 0.0625F
			Me.lblRL_70_95.Name = "lblRL_70_95"
			Me.lblRL_70_95.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblRL_70_95.Text = "Score 100 - 70% < Rod loading <= 95%"
			Me.lblRL_70_95.Top = 1.8125F
			Me.lblRL_70_95.Width = 3.75F
			Me.lblRL_60_70.Height = 0.1875F
			Me.lblRL_60_70.HyperLink = Nothing
			Me.lblRL_60_70.Left = 0.0625F
			Me.lblRL_60_70.Name = "lblRL_60_70"
			Me.lblRL_60_70.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblRL_60_70.Text = "Score   90 - 60% < Rod loading <= 70%"
			Me.lblRL_60_70.Top = 2F
			Me.lblRL_60_70.Width = 3.75F
			Me.lblRL_50_60.Height = 0.1875F
			Me.lblRL_50_60.HyperLink = Nothing
			Me.lblRL_50_60.Left = 0.0625F
			Me.lblRL_50_60.Name = "lblRL_50_60"
			Me.lblRL_50_60.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblRL_50_60.Text = "Score   75 - 50% < Rod loading <= 60%"
			Me.lblRL_50_60.Top = 2.1875F
			Me.lblRL_50_60.Width = 3.75F
			Me.lblRL_40_50.Height = 0.1875F
			Me.lblRL_40_50.HyperLink = Nothing
			Me.lblRL_40_50.Left = 0.0625F
			Me.lblRL_40_50.Name = "lblRL_40_50"
			Me.lblRL_40_50.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblRL_40_50.Text = "Score   60 - 40% <= Rod loading <= 50%"
			Me.lblRL_40_50.Top = 2.375F
			Me.lblRL_40_50.Width = 3.75F
			Me.lblRL_40.Height = 0.1875F
			Me.lblRL_40.HyperLink = Nothing
			Me.lblRL_40.Left = 0.0625F
			Me.lblRL_40.Name = "lblRL_40"
			Me.lblRL_40.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblRL_40.Text = "Score   50 - Rod loading  < 40%"
			Me.lblRL_40.Top = 2.715F
			Me.lblRL_40.Width = 3.75F
			Me.lblSL_70_95.Height = 0.1875F
			Me.lblSL_70_95.HyperLink = Nothing
			Me.lblSL_70_95.Left = 0.0625F
			Me.lblSL_70_95.Name = "lblSL_70_95"
			Me.lblSL_70_95.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSL_70_95.Text = "Score 100 - 70% < Structure loading <= 95%"
			Me.lblSL_70_95.Top = 3.0625F
			Me.lblSL_70_95.Width = 3.75F
			Me.lblSL_60_70.Height = 0.1875F
			Me.lblSL_60_70.HyperLink = Nothing
			Me.lblSL_60_70.Left = 0.0625F
			Me.lblSL_60_70.Name = "lblSL_60_70"
			Me.lblSL_60_70.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSL_60_70.Text = "Score   90 - 60% < Structure loading <= 70%"
			Me.lblSL_60_70.Top = 3.25F
			Me.lblSL_60_70.Width = 3.75F
			Me.lblSL_50_60.Height = 0.1875F
			Me.lblSL_50_60.HyperLink = Nothing
			Me.lblSL_50_60.Left = 0.0625F
			Me.lblSL_50_60.Name = "lblSL_50_60"
			Me.lblSL_50_60.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSL_50_60.Text = "Score   70 - 50% < Structure loading <= 60%"
			Me.lblSL_50_60.Top = 3.4375F
			Me.lblSL_50_60.Width = 3.75F
			Me.lblSL_50.Height = 0.1875F
			Me.lblSL_50.HyperLink = Nothing
			Me.lblSL_50.Left = 0.0625F
			Me.lblSL_50.Name = "lblSL_50"
			Me.lblSL_50.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSL_50.Text = "Score   60 - Structure loading <=50%"
			Me.lblSL_50.Top = 3.8125F
			Me.lblSL_50.Width = 3.75F
			Me.lblSL_95_100.Height = 0.1875F
			Me.lblSL_95_100.HyperLink = Nothing
			Me.lblSL_95_100.Left = 3.8125F
			Me.lblSL_95_100.Name = "lblSL_95_100"
			Me.lblSL_95_100.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSL_95_100.Text = "Score 95 - 95% < Structure loading <= 100%"
			Me.lblSL_95_100.Top = 3.0625F
			Me.lblSL_95_100.Width = 3.75F
			Me.lblSL_100_110.Height = 0.1875F
			Me.lblSL_100_110.HyperLink = Nothing
			Me.lblSL_100_110.Left = 3.8125F
			Me.lblSL_100_110.Name = "lblSL_100_110"
			Me.lblSL_100_110.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSL_100_110.Text = "Score 30 - 100% < Structure loading <= 110%"
			Me.lblSL_100_110.Top = 3.25F
			Me.lblSL_100_110.Width = 3.75F
			Me.lblSL_110_120.Height = 0.1875F
			Me.lblSL_110_120.HyperLink = Nothing
			Me.lblSL_110_120.Left = 3.8125F
			Me.lblSL_110_120.Name = "lblSL_110_120"
			Me.lblSL_110_120.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSL_110_120.Text = "Score 10 - 110% < Structure loading <= 120%"
			Me.lblSL_110_120.Top = 3.4375F
			Me.lblSL_110_120.Width = 3.75F
			Me.lblSEF_45.Height = 0.1875F
			Me.lblSEF_45.HyperLink = Nothing
			Me.lblSEF_45.Left = 0.0625F
			Me.lblSEF_45.Name = "lblSEF_45"
			Me.lblSEF_45.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSEF_45.Text = "Score 100 - 45% <= System Efficiency"
			Me.lblSEF_45.Top = 4.5F
			Me.lblSEF_45.Width = 3.75F
			Me.lblSEF_42_45.Height = 0.1875F
			Me.lblSEF_42_45.HyperLink = Nothing
			Me.lblSEF_42_45.Left = 0.0625F
			Me.lblSEF_42_45.Name = "lblSEF_42_45"
			Me.lblSEF_42_45.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSEF_42_45.Text = "Score   95 - 42% <= System Efficiency <= 45%"
			Me.lblSEF_42_45.Top = 4.6875F
			Me.lblSEF_42_45.Width = 3.75F
			Me.lblSEF_35_40.Height = 0.1875F
			Me.lblSEF_35_40.HyperLink = Nothing
			Me.lblSEF_35_40.Left = 0.0625F
			Me.lblSEF_35_40.Name = "lblSEF_35_40"
			Me.lblSEF_35_40.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSEF_35_40.Text = "Score   80 - 35% <= System Efficiency <= 40%"
			Me.lblSEF_35_40.Top = 5.0625F
			Me.lblSEF_35_40.Width = 3.75F
			Me.lblSEF_30_35.Height = 0.1875F
			Me.lblSEF_30_35.HyperLink = Nothing
			Me.lblSEF_30_35.Left = 3.8125F
			Me.lblSEF_30_35.Name = "lblSEF_30_35"
			Me.lblSEF_30_35.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSEF_30_35.Text = "Score 65 - 30% <= System Efficiency <= 35%"
			Me.lblSEF_30_35.Top = 4.5F
			Me.lblSEF_30_35.Width = 3.75F
			Me.lblSEF_25.Height = 0.1875F
			Me.lblSEF_25.HyperLink = Nothing
			Me.lblSEF_25.Left = 3.8125F
			Me.lblSEF_25.Name = "lblSEF_25"
			Me.lblSEF_25.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSEF_25.Text = "Score 20 - System Efficiency < 25%"
			Me.lblSEF_25.Top = 4.875F
			Me.lblSEF_25.Width = 3.75F
			Me.lblGB_50.Height = 0.1875F
			Me.lblGB_50.HyperLink = Nothing
			Me.lblGB_50.Left = 0.0625F
			Me.lblGB_50.Name = "lblGB_50"
			Me.lblGB_50.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblGB_50.Text = "Score   60 - Gearbox loading < 50% "
			Me.lblGB_50.Top = 1F
			Me.lblGB_50.Width = 3.75F
			Me.lblSL_SmallUnit.Height = 0.1875F
			Me.lblSL_SmallUnit.HyperLink = Nothing
			Me.lblSL_SmallUnit.Left = 0.0625F
			Me.lblSL_SmallUnit.Name = "lblSL_SmallUnit"
			Me.lblSL_SmallUnit.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSL_SmallUnit.Text = "Score 100 - Str. Loading of smallest structure size pumping unit of same stroke length and gearbox size is less than 70% "
			Me.lblSL_SmallUnit.Top = 4F
			Me.lblSL_SmallUnit.Width = 7.5F
			Me.lblBottomMinStressSCORE.Height = 0.1875F
			Me.lblBottomMinStressSCORE.HyperLink = Nothing
			Me.lblBottomMinStressSCORE.Left = 0.0625F
			Me.lblBottomMinStressSCORE.Name = "lblBottomMinStressSCORE"
			Me.lblBottomMinStressSCORE.Style = "background-color: Gainsboro; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblBottomMinStressSCORE.Text = "BOTTOM MINIMUM STRESS SCORE: "
			Me.lblBottomMinStressSCORE.Top = 5.375F
			Me.lblBottomMinStressSCORE.Width = 7.5F
			Me.lblBotMin_1000.Height = 0.1875F
			Me.lblBotMin_1000.HyperLink = Nothing
			Me.lblBotMin_1000.Left = 0.25F
			Me.lblBotMin_1000.Name = "lblBotMin_1000"
			Me.lblBotMin_1000.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_1000.Text = "Score 100 - Pump Depth < 1000 feet"
			Me.lblBotMin_1000.Top = 5.8125F
			Me.lblBotMin_1000.Width = 3.5625F
			Me.lblFootNote.Height = 0.1875F
			Me.lblFootNote.HyperLink = Nothing
			Me.lblFootNote.Left = 0.0625F
			Me.lblFootNote.Name = "lblFootNote"
			Me.lblFootNote.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblFootNote.Text = "* -  stress on last rod string section above the sinker bars (with buoyancy effects not included) "
			Me.lblFootNote.Top = 8.3125F
			Me.lblFootNote.Width = 7.4375F
			Me.lblGB_135.Height = 0.1875F
			Me.lblGB_135.HyperLink = Nothing
			Me.lblGB_135.Left = 3.8125F
			Me.lblGB_135.Name = "lblGB_135"
			Me.lblGB_135.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblGB_135.Text = "Score   0 - Gearbox loading > 135%"
			Me.lblGB_135.Top = 1.1875F
			Me.lblGB_135.Width = 3.75F
			Me.lblRL_70_C.Height = 0.1875F
			Me.lblRL_70_C.HyperLink = Nothing
			Me.lblRL_70_C.Left = 3.8125F
			Me.lblRL_70_C.Name = "lblRL_70_C"
			Me.lblRL_70_C.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblRL_70_C.Text = "Score 100 - 70% > Rod loading (grade C rods)"
			Me.lblRL_70_C.Top = 1.875F
			Me.lblRL_70_C.Width = 3.75F
			Me.lblRL_95_100.Height = 0.1875F
			Me.lblRL_95_100.HyperLink = Nothing
			Me.lblRL_95_100.Left = 3.8125F
			Me.lblRL_95_100.Name = "lblRL_95_100"
			Me.lblRL_95_100.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblRL_95_100.Text = "Score   45 - 95% < Rod loading <= 100%"
			Me.lblRL_95_100.Top = 2.0625F
			Me.lblRL_95_100.Width = 3.75F
			Me.lblRL_100_110.Height = 0.1875F
			Me.lblRL_100_110.HyperLink = Nothing
			Me.lblRL_100_110.Left = 3.8125F
			Me.lblRL_100_110.Name = "lblRL_100_110"
			Me.lblRL_100_110.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblRL_100_110.Text = "Score   25 - 100% < Rod loading <= 110%"
			Me.lblRL_100_110.Top = 2.25F
			Me.lblRL_100_110.Width = 3.75F
			Me.lblRL_110_120.Height = 0.1875F
			Me.lblRL_110_120.HyperLink = Nothing
			Me.lblRL_110_120.Left = 3.8125F
			Me.lblRL_110_120.Name = "lblRL_110_120"
			Me.lblRL_110_120.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblRL_110_120.Text = "Score     5 - 110% <= Rod loading <= 120%"
			Me.lblRL_110_120.Top = 2.4375F
			Me.lblRL_110_120.Width = 3.75F
			Me.lblRL_120.Height = 0.1875F
			Me.lblRL_120.HyperLink = Nothing
			Me.lblRL_120.Left = 3.8125F
			Me.lblRL_120.Name = "lblRL_120"
			Me.lblRL_120.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblRL_120.Text = "Score     0 - Rod loading  > 120%"
			Me.lblRL_120.Top = 2.625F
			Me.lblRL_120.Width = 3.75F
			Me.lblSL_120.Height = 0.1875F
			Me.lblSL_120.HyperLink = Nothing
			Me.lblSL_120.Left = 3.8125F
			Me.lblSL_120.Name = "lblSL_120"
			Me.lblSL_120.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSL_120.Text = "Score   0 - Structure loading > 120%"
			Me.lblSL_120.Top = 3.625F
			Me.lblSL_120.Width = 3.75F
			Me.lblGB_SmallUnit.Height = 0.1875F
			Me.lblGB_SmallUnit.HyperLink = Nothing
			Me.lblGB_SmallUnit.Left = 0.0625F
			Me.lblGB_SmallUnit.Name = "lblGB_SmallUnit"
			Me.lblGB_SmallUnit.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblGB_SmallUnit.Text = "Score 100 - Gearbox Loading of smallest structure size pumping unit of same stroke length and gearbox size is less than 70% "
			Me.lblGB_SmallUnit.Top = 1.375F
			Me.lblGB_SmallUnit.Width = 7.6875F
			Me.lblSEF_25_30.Height = 0.1875F
			Me.lblSEF_25_30.HyperLink = Nothing
			Me.lblSEF_25_30.Left = 3.8125F
			Me.lblSEF_25_30.Name = "lblSEF_25_30"
			Me.lblSEF_25_30.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSEF_25_30.Text = "Score 50 - 25% <= System Efficiency <= 30%"
			Me.lblSEF_25_30.Top = 4.6875F
			Me.lblSEF_25_30.Width = 3.75F
			Me.lblBotMin_100_200.Height = 0.1875F
			Me.lblBotMin_100_200.HyperLink = Nothing
			Me.lblBotMin_100_200.Left = 0.25F
			Me.lblBotMin_100_200.Name = "lblBotMin_100_200"
			Me.lblBotMin_100_200.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_100_200.Text = "Score   90 - 100 (psi) <= Bot. Min. Stress < 200 (psi)"
			Me.lblBotMin_100_200.Top = 6.1875F
			Me.lblBotMin_100_200.Width = 3.5625F
			Me.lblBotMin_50_100.Height = 0.1875F
			Me.lblBotMin_50_100.HyperLink = Nothing
			Me.lblBotMin_50_100.Left = 0.25F
			Me.lblBotMin_50_100.Name = "lblBotMin_50_100"
			Me.lblBotMin_50_100.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_50_100.Text = "Score   80 - 50 (psi) <= Bot. Min. Stress < 100 (psi)"
			Me.lblBotMin_50_100.Top = 6.375F
			Me.lblBotMin_50_100.Width = 3.5625F
			Me.lblBotMin_25_50.Height = 0.1875F
			Me.lblBotMin_25_50.HyperLink = Nothing
			Me.lblBotMin_25_50.Left = 0.25F
			Me.lblBotMin_25_50.Name = "lblBotMin_25_50"
			Me.lblBotMin_25_50.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_25_50.Text = "Score   70 - 25 (psi) <= Bot. Min. Stress < 50 (psi)"
			Me.lblBotMin_25_50.Top = 6.5625F
			Me.lblBotMin_25_50.Width = 3.5625F
			Me.lblBotMin_0_25.Height = 0.1875F
			Me.lblBotMin_0_25.HyperLink = Nothing
			Me.lblBotMin_0_25.Left = 0.25F
			Me.lblBotMin_0_25.Name = "lblBotMin_0_25"
			Me.lblBotMin_0_25.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_0_25.Text = "Score   60 -    0 (psi) <= Bot. Min. Stress < 25 (psi)"
			Me.lblBotMin_0_25.Top = 6.75F
			Me.lblBotMin_0_25.Width = 3.5625F
			Me.lblBotMin_300_0.Height = 0.1875F
			Me.lblBotMin_300_0.HyperLink = Nothing
			Me.lblBotMin_300_0.Left = 0.25F
			Me.lblBotMin_300_0.Name = "lblBotMin_300_0"
			Me.lblBotMin_300_0.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_300_0.Text = "Score   50   -300 (psi)  <= Bot. Min. Stress < 0 (psi)"
			Me.lblBotMin_300_0.Top = 6.9375F
			Me.lblBotMin_300_0.Width = 3.5625F
			Me.lblBotMin_300.Height = 0.1875F
			Me.lblBotMin_300.HyperLink = Nothing
			Me.lblBotMin_300.Left = 0.25F
			Me.lblBotMin_300.Name = "lblBotMin_300"
			Me.lblBotMin_300.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_300.Text = "Score   30 -  Bot. Min. Stress <=  - 300 (psi)"
			Me.lblBotMin_300.Top = 7.125F
			Me.lblBotMin_300.Width = 3.5625F
			Me.lblBotMin_2000_3000.Height = 0.1875F
			Me.lblBotMin_2000_3000.HyperLink = Nothing
			Me.lblBotMin_2000_3000.Left = 3.8125F
			Me.lblBotMin_2000_3000.Name = "lblBotMin_2000_3000"
			Me.lblBotMin_2000_3000.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_2000_3000.Text = "Score   60 - 2000 (psi) <= Bot. Min. Stress < 3000 (psi)"
			Me.lblBotMin_2000_3000.Top = 6.5625F
			Me.lblBotMin_2000_3000.Width = 3.5625F
			Me.lblSteel.Height = 0.1875F
			Me.lblSteel.HyperLink = Nothing
			Me.lblSteel.Left = 0.25F
			Me.lblSteel.Name = "lblSteel"
			Me.lblSteel.Style = "background-color: WhiteSmoke; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblSteel.Text = "Steel:"
			Me.lblSteel.Top = 5.625F
			Me.lblSteel.Width = 7.3125F
			Me.lblBotMin_FG_400_1000.Height = 0.1875F
			Me.lblBotMin_FG_400_1000.HyperLink = Nothing
			Me.lblBotMin_FG_400_1000.Left = 0.25F
			Me.lblBotMin_FG_400_1000.Name = "lblBotMin_FG_400_1000"
			Me.lblBotMin_FG_400_1000.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_FG_400_1000.Text = "Score   95 - 400 (psi) > Bot. Min. Stress <= 1000 (psi)"
			Me.lblBotMin_FG_400_1000.Top = 7.75F
			Me.lblBotMin_FG_400_1000.Width = 3.5625F
			Me.lblBotMin_FG_50_400.Height = 0.1875F
			Me.lblBotMin_FG_50_400.HyperLink = Nothing
			Me.lblBotMin_FG_50_400.Left = 0.25F
			Me.lblBotMin_FG_50_400.Name = "lblBotMin_FG_50_400"
			Me.lblBotMin_FG_50_400.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_FG_50_400.Text = "Score   70 - 50 (psi) >= Bot. Min. Stress <= 400 (psi)"
			Me.lblBotMin_FG_50_400.Top = 7.9375F
			Me.lblBotMin_FG_50_400.Width = 3.5625F
			Me.lblBotMin_FG_1000.Height = 0.1875F
			Me.lblBotMin_FG_1000.HyperLink = Nothing
			Me.lblBotMin_FG_1000.Left = 0.25F
			Me.lblBotMin_FG_1000.Name = "lblBotMin_FG_1000"
			Me.lblBotMin_FG_1000.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_FG_1000.Text = "Score 100 - Bot. Min. Stress >= 1000 (psi)"
			Me.lblBotMin_FG_1000.Top = 7.5625F
			Me.lblBotMin_FG_1000.Width = 3.5625F
			Me.lblFGlassSteel.Height = 0.1875F
			Me.lblFGlassSteel.HyperLink = Nothing
			Me.lblFGlassSteel.Left = 0.25F
			Me.lblFGlassSteel.Name = "lblFGlassSteel"
			Me.lblFGlassSteel.Style = "background-color: WhiteSmoke; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblFGlassSteel.Text = "Fiberglass/Steel: "
			Me.lblFGlassSteel.Top = 7.375F
			Me.lblFGlassSteel.Width = 7.3125F
			Me.lblBotMin_200_300.Height = 0.1875F
			Me.lblBotMin_200_300.HyperLink = Nothing
			Me.lblBotMin_200_300.Left = 0.25F
			Me.lblBotMin_200_300.Name = "lblBotMin_200_300"
			Me.lblBotMin_200_300.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_200_300.Text = "Score   95 - 200 (psi) <= Bot. Min. Stress < 300 (psi)"
			Me.lblBotMin_200_300.Top = 6F
			Me.lblBotMin_200_300.Width = 3.5625F
			Me.lblBotMin_300_650.Height = 0.1875F
			Me.lblBotMin_300_650.HyperLink = Nothing
			Me.lblBotMin_300_650.Left = 3.8125F
			Me.lblBotMin_300_650.Name = "lblBotMin_300_650"
			Me.lblBotMin_300_650.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_300_650.Text = "Score 100 - 300 (psi) <= Bot. Min. Stress < 650 (psi)"
			Me.lblBotMin_300_650.Top = 5.8125F
			Me.lblBotMin_300_650.Width = 3.5625F
			Me.lblBotMin_3000.Height = 0.1875F
			Me.lblBotMin_3000.HyperLink = Nothing
			Me.lblBotMin_3000.Left = 3.8125F
			Me.lblBotMin_3000.Name = "lblBotMin_3000"
			Me.lblBotMin_3000.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_3000.Text = "Score   50 -  Bot. Min. Stress  >= 3000 (psi) "
			Me.lblBotMin_3000.Top = 6.75F
			Me.lblBotMin_3000.Width = 3.5625F
			Me.lblBotMin_FG_0.Height = 0.1875F
			Me.lblBotMin_FG_0.HyperLink = Nothing
			Me.lblBotMin_FG_0.Left = 0.25F
			Me.lblBotMin_FG_0.Name = "lblBotMin_FG_0"
			Me.lblBotMin_FG_0.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_FG_0.Text = "Score     0 - Bot. Min. Stress < 0 (psi)"
			Me.lblBotMin_FG_0.Top = 8.125F
			Me.lblBotMin_FG_0.Width = 3.5625F
			Me.lblMPRL.Height = 0.1875F
			Me.lblMPRL.HyperLink = Nothing
			Me.lblMPRL.Left = 0.0625F
			Me.lblMPRL.Name = "lblMPRL"
			Me.lblMPRL.Style = "background-color: Gainsboro; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblMPRL.Text = "MINIMUM POLISHED ROD LOAD SCORE: "
			Me.lblMPRL.Top = 8.6875F
			Me.lblMPRL.Width = 7.5F
			Me.lblMPRL_200.Height = 0.1875F
			Me.lblMPRL_200.HyperLink = Nothing
			Me.lblMPRL_200.Left = 0.0625F
			Me.lblMPRL_200.Name = "lblMPRL_200"
			Me.lblMPRL_200.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblMPRL_200.Text = "Score 100 - Minimum Polished Rod Load >= 200 lbs"
			Me.lblMPRL_200.Top = 8.875F
			Me.lblMPRL_200.Width = 3.8125F
			Me.lblMPRL_100_200.Height = 0.1875F
			Me.lblMPRL_100_200.HyperLink = Nothing
			Me.lblMPRL_100_200.Left = 0.0625F
			Me.lblMPRL_100_200.Name = "lblMPRL_100_200"
			Me.lblMPRL_100_200.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblMPRL_100_200.Text = "Score   90 - 100 lbs <= Minimum Polished Rod Load < 200 lbs"
			Me.lblMPRL_100_200.Top = 9.0625F
			Me.lblMPRL_100_200.Width = 3.8125F
			Me.lblMPRL_50_100.Height = 0.1875F
			Me.lblMPRL_50_100.HyperLink = Nothing
			Me.lblMPRL_50_100.Left = 0.0625F
			Me.lblMPRL_50_100.Name = "lblMPRL_50_100"
			Me.lblMPRL_50_100.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblMPRL_50_100.Text = "Score   80 - 50 lbs <= Minimum Polished Rod Load < 100 lbs"
			Me.lblMPRL_50_100.Top = 9.25F
			Me.lblMPRL_50_100.Width = 3.8125F
			Me.lblMPRL_20_50.Height = 0.1875F
			Me.lblMPRL_20_50.HyperLink = Nothing
			Me.lblMPRL_20_50.Left = 3.85F
			Me.lblMPRL_20_50.Name = "lblMPRL_20_50"
			Me.lblMPRL_20_50.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblMPRL_20_50.Text = "Score   50 - 20 lbs <= Minimum Polished Rod Load < 50 lbs"
			Me.lblMPRL_20_50.Top = 8.875F
			Me.lblMPRL_20_50.Width = 3.75F
			Me.lblMPRL_0_20.Height = 0.1875F
			Me.lblMPRL_0_20.HyperLink = Nothing
			Me.lblMPRL_0_20.Left = 3.85F
			Me.lblMPRL_0_20.Name = "lblMPRL_0_20"
			Me.lblMPRL_0_20.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblMPRL_0_20.Text = "Score   30 - 0 lbs <= Minimum Polished Rod Load < 20 lbs"
			Me.lblMPRL_0_20.Top = 9.0625F
			Me.lblMPRL_0_20.Width = 3.75F
			Me.lblMPRL_0.Height = 0.1875F
			Me.lblMPRL_0.HyperLink = Nothing
			Me.lblMPRL_0.Left = 3.85F
			Me.lblMPRL_0.Name = "lblMPRL_0"
			Me.lblMPRL_0.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblMPRL_0.Text = "Score     0 - Minimum Polished Rod Load < 0 lbs"
			Me.lblMPRL_0.Top = 9.25F
			Me.lblMPRL_0.Width = 3.75F
			Me.lblBotMin_650_800.Height = 0.1875F
			Me.lblBotMin_650_800.HyperLink = Nothing
			Me.lblBotMin_650_800.Left = 3.8125F
			Me.lblBotMin_650_800.Name = "lblBotMin_650_800"
			Me.lblBotMin_650_800.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_650_800.Text = "Score   95 - 650 (psi) <= Bot. Min. Stress < 800 (psi)"
			Me.lblBotMin_650_800.Top = 6F
			Me.lblBotMin_650_800.Width = 3.5625F
			Me.lblBotMin_800_1200.Height = 0.1875F
			Me.lblBotMin_800_1200.HyperLink = Nothing
			Me.lblBotMin_800_1200.Left = 3.8125F
			Me.lblBotMin_800_1200.Name = "lblBotMin_800_1200"
			Me.lblBotMin_800_1200.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_800_1200.Text = "Score   90 - 800 (psi) <= Bot. Min. Stress < 1200 (psi)"
			Me.lblBotMin_800_1200.Top = 6.1875F
			Me.lblBotMin_800_1200.Width = 3.5625F
			Me.lblBotMin_1200_2000.Height = 0.1875F
			Me.lblBotMin_1200_2000.HyperLink = Nothing
			Me.lblBotMin_1200_2000.Left = 3.8125F
			Me.lblBotMin_1200_2000.Name = "lblBotMin_1200_2000"
			Me.lblBotMin_1200_2000.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_1200_2000.Text = "Score   80 - 1200 (psi) <= Bot. Min. Stress < 2000 (psi)"
			Me.lblBotMin_1200_2000.Top = 6.375F
			Me.lblBotMin_1200_2000.Width = 3.5625F
			Me.lblFootNote2.Height = 0.1875F
			Me.lblFootNote2.HyperLink = Nothing
			Me.lblFootNote2.Left = 0.0625F
			Me.lblFootNote2.Name = "lblFootNote2"
			Me.lblFootNote2.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblFootNote2.Text = "* -  buoyancy effects must not be included to check the sinker bar effectiveness or the need to use sinker bars."
			Me.lblFootNote2.Top = 8.5F
			Me.lblFootNote2.Visible = False
			Me.lblFootNote2.Width = 7.4375F
			Me.lblSEF_40_42.Height = 0.1875F
			Me.lblSEF_40_42.HyperLink = Nothing
			Me.lblSEF_40_42.Left = 0.0625F
			Me.lblSEF_40_42.Name = "lblSEF_40_42"
			Me.lblSEF_40_42.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSEF_40_42.Text = "Score   90 - 40% <= System Efficiency <= 42%"
			Me.lblSEF_40_42.Top = 4.875F
			Me.lblSEF_40_42.Width = 3.75F
			Me.lblOtherGB.Height = 0.1875F
			Me.lblOtherGB.HyperLink = Nothing
			Me.lblOtherGB.Left = 0.0625F
			Me.lblOtherGB.Name = "lblOtherGB"
			Me.lblOtherGB.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblOtherGB.Text = ""
			Me.lblOtherGB.Top = 1.1875F
			Me.lblOtherGB.Width = 3.75F
			Me.lblOtherSL.Height = 0.1875F
			Me.lblOtherSL.HyperLink = Nothing
			Me.lblOtherSL.Left = 0.0625F
			Me.lblOtherSL.Name = "lblOtherSL"
			Me.lblOtherSL.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblOtherSL.Text = "Score   70 - 50% < Structure loading <= 60%"
			Me.lblOtherSL.Top = 3.625F
			Me.lblOtherSL.Width = 3.75F
			Me.GroupFooter1.Height = 0.02083333F
			Me.GroupFooter1.Name = "GroupFooter1"
			Me.MasterReport = False
			Me.MaxPages = 1L
			Me.PageSettings.Margins.Bottom = 0F
			Me.PageSettings.Margins.Left = 0.3F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0.5F
			Me.PageSettings.PaperHeight = 11F
			Me.PageSettings.PaperWidth = 8.5F
			Me.PrintWidth = 7.989583F
			Me.Sections.Add(Me.PageHeader)
			Me.Sections.Add(Me.GroupHeader1)
			Me.Sections.Add(Me.Detail)
			Me.Sections.Add(Me.GroupFooter1)
			Me.Sections.Add(Me.PageFooter)
			Me.StyleSheet.Add(New StyleSheetRule(componentResourceManager.GetString("$this.StyleSheet"), "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-weight: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
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
			CType(Me.lblOtherRLS, ISupportInitialize).EndInit()
			CType(Me.lblTOTALSCORE, ISupportInitialize).EndInit()
			CType(Me.lblGEARBOXSCORE, ISupportInitialize).EndInit()
			CType(Me.lblRODLOADINGSCORE, ISupportInitialize).EndInit()
			CType(Me.lblSTRUCTURELOADINGSCORE, ISupportInitialize).EndInit()
			CType(Me.lblSYSTEMEFFICIENCYSCORE, ISupportInitialize).EndInit()
			CType(Me.lblGB_70_95, ISupportInitialize).EndInit()
			CType(Me.lblGB_60_70, ISupportInitialize).EndInit()
			CType(Me.lblGB_50_60, ISupportInitialize).EndInit()
			CType(Me.lblGB_95_100, ISupportInitialize).EndInit()
			CType(Me.lblGB_100_110, ISupportInitialize).EndInit()
			CType(Me.lblGB_110_120, ISupportInitialize).EndInit()
			CType(Me.lblGB_120_135, ISupportInitialize).EndInit()
			CType(Me.lblRL_70_95, ISupportInitialize).EndInit()
			CType(Me.lblRL_60_70, ISupportInitialize).EndInit()
			CType(Me.lblRL_50_60, ISupportInitialize).EndInit()
			CType(Me.lblRL_40_50, ISupportInitialize).EndInit()
			CType(Me.lblRL_40, ISupportInitialize).EndInit()
			CType(Me.lblSL_70_95, ISupportInitialize).EndInit()
			CType(Me.lblSL_60_70, ISupportInitialize).EndInit()
			CType(Me.lblSL_50_60, ISupportInitialize).EndInit()
			CType(Me.lblSL_50, ISupportInitialize).EndInit()
			CType(Me.lblSL_95_100, ISupportInitialize).EndInit()
			CType(Me.lblSL_100_110, ISupportInitialize).EndInit()
			CType(Me.lblSL_110_120, ISupportInitialize).EndInit()
			CType(Me.lblSEF_45, ISupportInitialize).EndInit()
			CType(Me.lblSEF_42_45, ISupportInitialize).EndInit()
			CType(Me.lblSEF_35_40, ISupportInitialize).EndInit()
			CType(Me.lblSEF_30_35, ISupportInitialize).EndInit()
			CType(Me.lblSEF_25, ISupportInitialize).EndInit()
			CType(Me.lblGB_50, ISupportInitialize).EndInit()
			CType(Me.lblSL_SmallUnit, ISupportInitialize).EndInit()
			CType(Me.lblBottomMinStressSCORE, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_1000, ISupportInitialize).EndInit()
			CType(Me.lblFootNote, ISupportInitialize).EndInit()
			CType(Me.lblGB_135, ISupportInitialize).EndInit()
			CType(Me.lblRL_70_C, ISupportInitialize).EndInit()
			CType(Me.lblRL_95_100, ISupportInitialize).EndInit()
			CType(Me.lblRL_100_110, ISupportInitialize).EndInit()
			CType(Me.lblRL_110_120, ISupportInitialize).EndInit()
			CType(Me.lblRL_120, ISupportInitialize).EndInit()
			CType(Me.lblSL_120, ISupportInitialize).EndInit()
			CType(Me.lblGB_SmallUnit, ISupportInitialize).EndInit()
			CType(Me.lblSEF_25_30, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_100_200, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_50_100, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_25_50, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_0_25, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_300_0, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_300, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_2000_3000, ISupportInitialize).EndInit()
			CType(Me.lblSteel, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_FG_400_1000, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_FG_50_400, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_FG_1000, ISupportInitialize).EndInit()
			CType(Me.lblFGlassSteel, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_200_300, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_300_650, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_3000, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_FG_0, ISupportInitialize).EndInit()
			CType(Me.lblMPRL, ISupportInitialize).EndInit()
			CType(Me.lblMPRL_200, ISupportInitialize).EndInit()
			CType(Me.lblMPRL_100_200, ISupportInitialize).EndInit()
			CType(Me.lblMPRL_50_100, ISupportInitialize).EndInit()
			CType(Me.lblMPRL_20_50, ISupportInitialize).EndInit()
			CType(Me.lblMPRL_0_20, ISupportInitialize).EndInit()
			CType(Me.lblMPRL_0, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_650_800, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_800_1200, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_1200_2000, ISupportInitialize).EndInit()
			CType(Me.lblFootNote2, ISupportInitialize).EndInit()
			CType(Me.lblSEF_40_42, ISupportInitialize).EndInit()
			CType(Me.lblOtherGB, ISupportInitialize).EndInit()
			CType(Me.lblOtherSL, ISupportInitialize).EndInit()
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

		Public Sub rptExpertAnalysis_FetchData(sender As Object, eArgs As ActiveReport.FetchEventArgs)
			If Me.I < 1 Then
				eArgs.EOF = False
			Else
				eArgs.EOF = True
			End If
			Me.I += 1
		End Sub

		Public Sub rptExpertAnalysis_ReportStart(sender As Object, e As EventArgs)
			Dim fScore As Single = 0F
			Dim flag As Boolean = False
			If Not Me.m_bPrint Then
				Me.PageSettings.Margins.Left = 0.5F
				Me.PageSettings.Margins.Right = 0F
				Me.PageSettings.Margins.Top = 0.25F
				Me.PageSettings.Margins.Bottom = 0F
			Else
				Me.PageSettings.Margins.Left = 0.5F
				Me.PageSettings.Margins.Right = 0F
				Me.PageSettings.Margins.Top = 0.5F
				Me.PageSettings.Margins.Bottom = 0F
			End If
			Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
			Dim num As Integer = Me.SetGearboxLoadingScore()
			Dim num2 As Integer = Me.SetMaxRodLoadingScore()
			Dim num3 As Integer = Me.SetStructureLoadingScore()
			Dim num4 As Integer = Me.SetSYSTEMEFFICIENCYScore()
			Dim num5 As Integer = Me.SetBotMinStressScore(flag)
			Dim num6 As Integer = Me.SetMPRLScore()
			If num = 0 Or num2 = 0 Or num3 = 0 Or num4 = 0 Or num6 = 0 Then
				fScore = 0.35F
				Dim label As Label = Me.lblTOTALSCORE
				Dim str As String = "TOTAL SCORE: "
				Dim text As String = "###%"
				label.Text = str + Util.Format(fScore, text) + "  Grade: " + RSWIN.GetScoreGrade(fScore)
				Me.lblFootNote.Visible = True
			ElseIf flag Then
				fScore = CSng((CDbl((num + num2 + num3 + num4 + num5 + num6)) / 100.0 / 6.0))
				Dim label2 As Label = Me.lblTOTALSCORE
				Dim str2 As String = "TOTAL AI SCORE: "
				Dim text As String = "###%"
				label2.Text = str2 + Util.Format(fScore, text) + "  Grade: " + RSWIN.GetScoreGrade(fScore)
				Me.lblFootNote.Visible = True
			Else
				fScore = CSng((CDbl((num + num2 + num3 + num4 + num6)) / 100.0 / 5.0))
				Dim label3 As Label = Me.lblTOTALSCORE
				Dim str3 As String = "TOTAL AI SCORE: "
				Dim text As String = "###%"
				label3.Text = str3 + Util.Format(fScore, text) + "  Grade: " + RSWIN.GetScoreGrade(fScore)
				Me.lblFootNote.Visible = False
			End If
			If RSWIN_DESC.bIntVersion Then
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter("rptExpertAnalysis")
					Me.WriteControlStrings()
					Util.CloseResourceWriter()
				End If
				If RSWIN_DESC.bReadResXFile Then
					Me.ReadReportControlStrings()
				End If
				Return
			End If
		End Sub

		Private Sub SummHeader(iPage As Integer, nPages As Integer)
			Dim text As String = New String(" "c, 112)
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
		End Sub

		Private Function SetGearboxLoadingScore() As Integer
			Dim result As Integer
			Try
				Dim flag As Boolean = False
				Dim num As Integer
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					num = 100
				Else
					Try
						If Operators.CompareString(RSWIN_DESC.rst.UnitID, RSWIN_DESC.SmallestUnitID, False) = 0 And Operators.CompareString(RSWIN_DESC.SmallestUnitID.Trim(), "", False) <> 0 Then
							flag = True
						End If
					Catch ex As Exception
						flag = False
					End Try
					Me.lblGB_SmallUnit.ForeColor = Color.Black
					Me.lblGB_70_95.ForeColor = Color.Black
					Me.lblGB_60_70.ForeColor = Color.Black
					Me.lblGB_50_60.ForeColor = Color.Black
					Me.lblGB_50.ForeColor = Color.Black
					Me.lblGB_95_100.ForeColor = Color.Black
					Me.lblGB_100_110.ForeColor = Color.Black
					Me.lblGB_110_120.ForeColor = Color.Black
					Me.lblGB_120_135.ForeColor = Color.Black
					Me.lblGB_135.ForeColor = Color.Black
					Dim num2 As Single = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)
					If RSWIN_DESC.bCheckSmallestUnit AndAlso flag Then
						If CDbl(num2) < 0.7 Then
							RSWIN_DESC.bSmallestUnitGearbox = True
						Else
							RSWIN_DESC.bSmallestUnitGearbox = False
						End If
					Else
						RSWIN_DESC.bSmallestUnitGearbox = False
					End If
					Dim flag2 As Boolean = True
					If flag2 = (RSWIN_DESC.bCheckSmallestUnit And RSWIN_DESC.bSmallestUnitGearbox) Then
						num = 100
						Me.lblGB_SmallUnit.ForeColor = Color.Red
					ElseIf flag2 = (num2 >= 0F And CDbl(num2) < 0.5) Then
						num = 60
						Me.lblOtherGB.Text = "Score 60 - 0% <= Gearbox loading <= 50%"
						Me.lblOtherGB.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num2) >= 0.7 And CDbl(num2) < 0.75) Then
						num = 98
						Me.lblOtherGB.Text = "Score 98 - 70% <= Gearbox loading <= 75%"
						Me.lblOtherGB.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num2) >= 0.75 And CDbl(num2) < 0.8) Then
						num = 99
						Me.lblOtherGB.Text = "Score 99 - 75% <= Gearbox loading <= 80%"
						Me.lblOtherGB.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num2) >= 0.8 And CDbl(num2) < 0.85) Then
						num = 100
						Me.lblOtherGB.Text = "Score 100 - 80% <= Gearbox loading <= 85%"
						Me.lblOtherGB.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num2) >= 0.85 And CDbl(num2) < 0.9) Then
						num = 99
						Me.lblOtherGB.Text = "Score 99 - 85% <= Gearbox loading <= 90%"
						Me.lblOtherGB.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num2) >= 0.9 And CDbl(num2) < 0.95) Then
						num = 97
						Me.lblOtherGB.Text = "Score 97 - 90% <= Gearbox loading <= 95%"
						Me.lblOtherGB.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num2) >= 0.7 And CDbl(num2) <= 0.95) Then
						num = 100
						Me.lblGB_70_95.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num2) >= 0.6 And CDbl(num2) < 0.7) Then
						num = 85
						Me.lblGB_60_70.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num2) >= 0.5 And CDbl(num2) < 0.6) Then
						num = 70
						Me.lblGB_50_60.ForeColor = Color.Red
					ElseIf flag2 = CDbl(num2) < 0.5 Then
						num = 60
						Me.lblGB_50.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num2) > 0.95 And num2 <= 1F) Then
						num = 75
						Me.lblGB_95_100.ForeColor = Color.Red
					ElseIf flag2 = (num2 > 1F And CDbl(num2) <= 1.1) Then
						num = 35
						Me.lblGB_100_110.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num2) > 1.1 And CDbl(num2) <= 1.2) Then
						num = 20
						Me.lblGB_110_120.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num2) > 1.2 And CDbl(num2) <= 1.35) Then
						num = 10
						Me.lblGB_120_135.ForeColor = Color.Red
					ElseIf flag2 = CDbl(num2) > 1.35 Then
						num = 0
						Me.lblGB_135.ForeColor = Color.Red
					End If
					Me.lblGEARBOXSCORE.Text = "BALANCED GEARBOX LOADING SCORE: " + num.ToString()
				End If
				result = num
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Private Function SetStructureLoadingScore() As Integer
			Dim flag As Boolean = False
			Try
				If Operators.CompareString(RSWIN_DESC.rst.UnitID, RSWIN_DESC.SmallestUnitID, False) = 0 And Operators.CompareString(RSWIN_DESC.SmallestUnitID.Trim(), "", False) <> 0 Then
					flag = True
				End If
			Catch ex As Exception
				flag = False
			End Try
			Dim result As Integer
			Try
				Me.lblSL_SmallUnit.ForeColor = Color.Black
				Me.lblSL_70_95.ForeColor = Color.Black
				Me.lblSL_60_70.ForeColor = Color.Black
				Me.lblSL_50_60.ForeColor = Color.Black
				Me.lblSL_50.ForeColor = Color.Black
				Me.lblSL_95_100.ForeColor = Color.Black
				Me.lblSL_100_110.ForeColor = Color.Black
				Me.lblSL_110_120.ForeColor = Color.Black
				Me.lblSL_120.ForeColor = Color.Black
				Dim structL As Single = RSWIN_DESC.rst.StructL
				If RSWIN_DESC.bCheckSmallestUnit AndAlso flag Then
					If CDbl(structL) < 0.7 Then
						RSWIN_DESC.bSmallestUnitStructL = True
					Else
						RSWIN_DESC.bSmallestUnitStructL = False
					End If
				Else
					RSWIN_DESC.bSmallestUnitStructL = False
				End If
				Dim flag2 As Boolean = True
				Dim num As Integer
				If flag2 = (RSWIN_DESC.bCheckSmallestUnit And RSWIN_DESC.bSmallestUnitStructL) Then
					num = 100
					Me.lblSL_SmallUnit.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(structL) >= 0.7 And CDbl(structL) <= 0.95) Then
					num = 100
					Me.lblSL_70_95.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(structL) >= 0.6 And CDbl(structL) < 0.7) Then
					num = 90
					Me.lblSL_60_70.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(structL) >= 0.5 And CDbl(structL) < 0.6) Then
					num = 70
					Me.lblSL_50_60.ForeColor = Color.Red
				ElseIf flag2 = CDbl(structL) < 0.5 Then
					num = 60
					Me.lblSL_50.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(structL) > 0.95 And CDbl(structL) <= 0.98) Then
					num = 98
					Me.lblOtherSL.Text = "Score   98 - 95% < Structure loading <= 98%"
					Me.lblOtherSL.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(structL) > 0.98 And structL <= 1F) Then
					num = 80
					Me.lblOtherSL.Text = "Score   80 - 98% < Structure loading <= 100%"
					Me.lblOtherSL.ForeColor = Color.Red
				ElseIf flag2 = (structL > 1F And CDbl(structL) <= 1.05) Then
					num = 50
					Me.lblOtherSL.Text = "Score   50 - 100% < Structure loading <= 105%"
					Me.lblOtherSL.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(structL) > 1.05 And CDbl(structL) <= 1.1) Then
					num = 30
					Me.lblOtherSL.Text = "Score   30 - 105% < Structure loading <= 101%"
					Me.lblOtherSL.ForeColor = Color.Red
				ElseIf flag2 = (structL > 1F And CDbl(structL) <= 1.1) Then
					num = 30
					Me.lblSL_100_110.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(structL) > 1.1 And CDbl(structL) <= 1.2) Then
					num = 10
					Me.lblSL_110_120.ForeColor = Color.Red
				ElseIf flag2 = CDbl(structL) > 1.2 Then
					num = 0
					Me.lblSL_120.ForeColor = Color.Red
				End If
				Me.lblSTRUCTURELOADINGSCORE.Text = "STRUCTURE LOADING SCORE: " + num.ToString()
				result = num
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Private Function SetMaxRodLoadingScore() As Integer
			Dim result As Integer
			Try
				Dim flag As Boolean = False
				Dim num As Single = 0F
				Me.lblRL_70_C.ForeColor = Color.Black
				Me.lblRL_70_95.ForeColor = Color.Black
				Me.lblRL_60_70.ForeColor = Color.Black
				Me.lblRL_50_60.ForeColor = Color.Black
				Me.lblRL_40_50.ForeColor = Color.Black
				Me.lblRL_40.ForeColor = Color.Black
				Me.lblRL_95_100.ForeColor = Color.Black
				Me.lblRL_100_110.ForeColor = Color.Black
				Me.lblRL_110_120.ForeColor = Color.Black
				Me.lblRL_120.ForeColor = Color.Black
				Dim num2 As Single = -(flag > False)
				Dim maxRodLoad As Single = Me.GetMaxRodLoad(num2, num)
				flag = (num2 <> 0F)
				Dim num3 As Single = maxRodLoad
				Dim flag2 As Boolean = True
				Dim num4 As Integer
				If flag2 = (flag And CDbl(num) < 0.7) Then
					num4 = 100
					Me.lblRL_70_C.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(num3) >= 0.7 And CDbl(num3) <= 0.95) Then
					num4 = 100
					Me.lblRL_70_95.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(num3) >= 0.7 And CDbl(num3) < 0.75) Then
					num4 = 98
					Me.lblOtherRLS.Text = "Score   98 - 70% <= Rod loading <= 75%"
					Me.lblOtherRLS.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(num3) >= 0.75 And CDbl(num3) < 0.85) Then
					num4 = 100
					Me.lblOtherRLS.Text = "Score   100 - 75% <= Rod loading <= 85%"
					Me.lblOtherRLS.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(num3) >= 0.85 And CDbl(num3) < 0.9) Then
					num4 = 98
					Me.lblOtherRLS.Text = "Score   98 - 85% <= Rod loading <= 90%"
					Me.lblOtherRLS.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(num3) >= 0.9 And CDbl(num3) < 0.95) Then
					num4 = 97
					Me.lblOtherRLS.Text = "Score   97 - 90% <= Rod loading <= 95%"
					Me.lblOtherRLS.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(num3) >= 0.6 And CDbl(num3) < 0.7) Then
					num4 = 90
					Me.lblRL_60_70.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(num3) >= 0.5 And CDbl(num3) < 0.6) Then
					num4 = 75
					Me.lblRL_50_60.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(num3) >= 0.4 And CDbl(num3) < 0.5) Then
					num4 = 60
					Me.lblRL_40_50.ForeColor = Color.Red
				ElseIf flag2 = CDbl(num3) < 0.4 Then
					num4 = 50
					Me.lblRL_40.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(num3) >= 0.95 And num3 < 1F) Then
					num4 = 45
					Me.lblRL_95_100.ForeColor = Color.Red
				ElseIf flag2 = (num3 >= 1F And CDbl(num3) < 1.1) Then
					num4 = 25
					Me.lblRL_100_110.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(num3) >= 1.1 And CDbl(num3) < 1.2) Then
					num4 = 5
					Me.lblRL_110_120.ForeColor = Color.Red
				ElseIf flag2 = CDbl(num3) > 1.2 Then
					num4 = 0
					Me.lblRL_120.ForeColor = Color.Red
				End If
				Me.lblRODLOADINGSCORE.Text = "MAXIMUM ROD LOADING SCORE: " + num4.ToString()
				result = num4
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetMaxRodLoad(ByRef bRodGradeC As Single, ByRef fCStressL As Single) As Single
			' The following expression was wrapped in a checked-statement
			Dim result As Single
			Try
				Dim num As Short
				If RODUTIL.IsCorod(RSWIN_DESC.HSGradeRod) Then
					Dim hsgradeRod As Short = RSWIN_DESC.HSGradeRod
					If hsgradeRod = 12547S OrElse hsgradeRod = 12549S OrElse hsgradeRod = 12550S OrElse hsgradeRod = 12548S Then
						num = 12545S
					ElseIf hsgradeRod = 12802S OrElse hsgradeRod = 12803S OrElse hsgradeRod = 12805S OrElse hsgradeRod = 12806S OrElse hsgradeRod = 13057S OrElse hsgradeRod = 12807S OrElse hsgradeRod = 12808S Then
						num = 12804S
					End If
				ElseIf RODUTIL.IsProRod(CInt(RSWIN_DESC.HSGradeRod)) <> 0 Then
					num = 24579S
				Else
					num = 4098S
				End If
				Dim num2 As Single = 0F
				fCStressL = 0F
				Dim num3 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num3 To numRods
					If RSWIN_DESC.rst.StressL(i) > num2 Then
						num2 = RSWIN_DESC.rst.StressL(i)
					End If
					If RSWIN_DESC.rst.Sections(i).Grade = 4098S Or RSWIN_DESC.rst.Sections(i).Grade = num Then
						bRodGradeC = -1F
						If RSWIN_DESC.rst.StressL(i) > fCStressL Then
							fCStressL = RSWIN_DESC.rst.StressL(i)
						End If
					End If
				Next
				result = num2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Function SetSYSTEMEFFICIENCYScore() As Integer
			Dim result As Integer
			Try
				Me.lblSEF_45.ForeColor = Color.Black
				Me.lblSEF_42_45.ForeColor = Color.Black
				Me.lblSEF_40_42.ForeColor = Color.Black
				Me.lblSEF_35_40.ForeColor = Color.Black
				Me.lblSEF_30_35.ForeColor = Color.Black
				Me.lblSEF_25_30.ForeColor = Color.Black
				Me.lblSEF_25.ForeColor = Color.Black
				Dim num As Double = CDbl(RSWIN_DESC.rst.SystemEff)
				Dim flag As Boolean = True
				Dim num2 As Integer
				If flag = num >= 0.45 Then
					num2 = 100
					Me.lblSEF_45.ForeColor = Color.Red
				ElseIf flag = (num >= 0.42 And num < 0.45) Then
					num2 = 95
					Me.lblSEF_42_45.ForeColor = Color.Red
				ElseIf flag = (num >= 0.4 And num < 0.42) Then
					num2 = 90
					Me.lblSEF_40_42.ForeColor = Color.Red
				ElseIf flag = (num >= 0.35 And num < 0.4) Then
					num2 = 80
					Me.lblSEF_35_40.ForeColor = Color.Red
				ElseIf flag = (num >= 0.3 And num <= 0.35) Then
					num2 = 65
					Me.lblSEF_30_35.ForeColor = Color.Red
				ElseIf flag = (num >= 0.25 And num <= 0.3) Then
					num2 = 50
					Me.lblSEF_25_30.ForeColor = Color.Red
				ElseIf flag = num < 0.25 Then
					num2 = 20
					Me.lblSEF_25.ForeColor = Color.Red
				End If
				Me.lblSYSTEMEFFICIENCYSCORE.Text = "SYSTEM EFFICIENCY SCORE: " + num2.ToString()
				result = num2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function SetBotMinStressScore(ByRef bContinue As Boolean) As Integer
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Dim num4 As Integer = 0
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = False
			Dim result As Integer
			Try
				Me.lblBotMin_FG_0.ForeColor = Color.Black
				Me.lblBotMin_FG_50_400.ForeColor = Color.Black
				Me.lblBotMin_FG_400_1000.ForeColor = Color.Black
				Me.lblBotMin_FG_50_400.ForeColor = Color.Black
				Me.lblBotMin_FG_1000.ForeColor = Color.Black
				Me.lblBotMin_1000.ForeColor = Color.Black
				Me.lblBotMin_300.ForeColor = Color.Black
				Me.lblBotMin_300_0.ForeColor = Color.Black
				Me.lblBotMin_3000.ForeColor = Color.Black
				Me.lblBotMin_2000_3000.ForeColor = Color.Black
				Me.lblBotMin_1200_2000.ForeColor = Color.Black
				Me.lblBotMin_800_1200.ForeColor = Color.Black
				Me.lblBotMin_650_800.ForeColor = Color.Black
				Me.lblBotMin_300_650.ForeColor = Color.Black
				Me.lblBotMin_200_300.ForeColor = Color.Black
				Me.lblBotMin_100_200.ForeColor = Color.Black
				Me.lblBotMin_50_100.ForeColor = Color.Black
				Me.lblBotMin_25_50.ForeColor = Color.Black
				Me.lblBotMin_0_25.ForeColor = Color.Black
				bContinue = False
				If RSWIN_DESC.rst.gbIncludeBuoyancy Then
					bContinue = False
					Me.lblFootNote2.Visible = True
				Else
					Me.lblFootNote2.Visible = False
					flag = Me.bIsSB(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade))
					flag2 = Me.HasFG(num4)
					If RSWIN_DESC.rst.NumRods = 1S Then
						Dim fStress As Single = RSWIN_DESC.rst.minStressBot(1)
						If flag2 Then
							flag4 = Me.GetFGBotMinStressScore(fStress, num2)
						Else
							flag3 = Me.GetSTLBotMinStressScore(fStress, num3)
						End If
					ElseIf flag Then
						If Not flag2 Then
							Dim fStress As Single = RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
							flag3 = Me.GetSTLBotMinStressScore(fStress, num3)
						ElseIf num4 = CInt((RSWIN_DESC.rst.NumRods - 1S)) Then
							Dim fStress As Single = RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
							flag4 = Me.GetFGBotMinStressScore(fStress, num2)
						Else
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							If(CInt(RSWIN_DESC.rst.RSFGIncludeSteel) Or (RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) Or If(-If((CUSTOMRG.IsOtherSteel(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) > False), 1, 0), 1, 0))) <> 0 Then
								Dim fStress As Single = RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
								flag3 = Me.GetSTLBotMinStressScore(fStress, num3)
							End If
							If RSWIN_DESC.rst.NumRods > 2S AndAlso (num4 = CInt((RSWIN_DESC.rst.NumRods - 2S)) Or num4 = 1) Then
								Dim fStress As Single = RSWIN_DESC.rst.minStressBot(num4)
								flag4 = Me.GetFGBotMinStressScore(fStress, num2)
							End If
						End If
					ElseIf flag2 And CInt(RSWIN_DESC.rst.NumRods) = num4 Then
						Dim fStress As Single = RSWIN_DESC.rst.minStressBot(num4)
						flag4 = Me.GetFGBotMinStressScore(RSWIN_DESC.rst.minStressBot(num4), num2)
					Else
						' The following expression was wrapped in a unchecked-expression
						If(RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) Or If(-If((CUSTOMRG.IsOtherSteel(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) > False), 1, 0), 1, 0)) <> 0 Then
							Dim fStress As Single = RSWIN_DESC.rst.minStressBot(CInt(RSWIN_DESC.rst.NumRods))
							flag3 = Me.GetSTLBotMinStressScore(fStress, num3)
						End If
						If flag2 AndAlso (num4 = CInt((RSWIN_DESC.rst.NumRods - 1S)) Or num4 = 1) Then
							Dim fStress As Single = RSWIN_DESC.rst.minStressBot(num4)
							flag4 = Me.GetFGBotMinStressScore(fStress, num2)
						End If
					End If
				End If
				bContinue = (flag3 OrElse flag4)
				If flag3 AndAlso flag4 Then
					num = CInt(Math.Round(CDbl((num3 + num2)) / 2.0))
				ElseIf flag3 Then
					num = num3
				ElseIf flag4 Then
					num = num2
				End If
				If bContinue Then
					Me.lblBottomMinStressSCORE.Text = "BOTTOM MINIMUM STRESS SCORE: " + num.ToString()
				Else
					Me.lblBottomMinStressSCORE.Text = "BOTTOM MINIMUM STRESS SCORE: N/A"
				End If
				If RSWIN_DESC.rst.RodStringType = 3S Then
					If RSWIN_DESC.rst.giRodDesignStyle = 1S Then
						If Not RSWIN_DESC.rst.RSFGIncludeSteel <> 0S Then
							Me.lblSteel.Text = "Steel: "
							Me.lblFGlassSteel.Text = "Fiberglass: "
						Else
							Me.lblSteel.Text = "Steel beneath Fiberglass "
							Me.lblFGlassSteel.Text = "Fiberglass: "
						End If
					ElseIf RSWIN_DESC.rst.giRodDesignStyle = 0S Then
						Me.lblSteel.Text = "Steel: "
						Me.lblFGlassSteel.Text = "Fiberglass: "
					End If
				ElseIf((flag AndAlso flag2) And num4 = CInt((RSWIN_DESC.rst.NumRods - 1S))) Or Not flag2 Then
					Me.lblSteel.Text = "Steel: "
					Me.lblFGlassSteel.Text = "Fiberglass: "
				ElseIf flag2 Then
					If(flag And RSWIN_DESC.rst.NumRods > 2S And num4 < CInt((RSWIN_DESC.rst.NumRods - 1S))) Or (Not flag And num4 < CInt(RSWIN_DESC.rst.NumRods)) Then
						Me.lblSteel.Text = "Steel beneath Fiberglass "
						Me.lblFGlassSteel.Text = "Fiberglass: "
					Else
						Me.lblSteel.Text = "Steel: "
						Me.lblFGlassSteel.Text = "Fiberglass: "
					End If
				Else
					Me.lblSteel.Text = "Steel: "
					Me.lblFGlassSteel.Text = "Fiberglass: "
				End If
				result = num
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Function SetMPRLScore() As Integer
			Dim result As Integer
			Try
				Me.lblMPRL_0.ForeColor = Color.Black
				Me.lblMPRL_0_20.ForeColor = Color.Black
				Me.lblMPRL_20_50.ForeColor = Color.Black
				Me.lblMPRL_50_100.ForeColor = Color.Black
				Me.lblMPRL_100_200.ForeColor = Color.Black
				Me.lblMPRL_200.ForeColor = Color.Black
				Dim mprload As Single = RSWIN_DESC.rst.Mprload
				Dim flag As Boolean = True
				Dim num As Integer
				If flag = mprload >= 200F Then
					num = 100
					Me.lblMPRL_200.ForeColor = Color.Red
				ElseIf flag = (mprload >= 100F And mprload < 200F) Then
					num = 90
					Me.lblMPRL_100_200.ForeColor = Color.Red
				ElseIf flag = (mprload >= 50F And mprload < 100F) Then
					num = 80
					Me.lblMPRL_50_100.ForeColor = Color.Red
				ElseIf flag = (mprload >= 20F And mprload < 50F) Then
					num = 50
					Me.lblMPRL_20_50.ForeColor = Color.Red
				ElseIf flag = (mprload >= 0F And mprload < 20F) Then
					num = 30
					Me.lblMPRL_0_20.ForeColor = Color.Red
				ElseIf flag = mprload < 0F Then
					num = 0
					Me.lblMPRL_0.ForeColor = Color.Red
				End If
				Me.lblMPRL.Text = "MINIMUM POLISHED ROD LOADING SCORE: " + num.ToString()
				result = num
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Function bIsSB(iGrade As Integer) As Boolean
			Dim result As Boolean = False
			If RODUTIL.IsSinkerBarGrade(iGrade) Then
				result = True
			ElseIf RODUTIL.IsSinkerBar(iGrade) <> 0 Then
				result = True
			ElseIf CUSTOMRG.IsOtherSinkerBar(iGrade) Then
				result = True
			End If
			Return result
		End Function

		Private Function HasFG(ByRef iFG As Integer) As Boolean
			Dim flag As Boolean = False
			Dim result As Boolean
			Try
				iFG = 0
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Then
						flag = True
						iFG = i
					End If
				Next
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetFGBotMinStressScore(fStress As Single, ByRef iScore As Integer) As Boolean
			Dim flag As Boolean = True
			Dim result As Boolean
			If flag = fStress < 0F Then
				iScore = 0
				result = True
				Me.lblBotMin_FG_0.ForeColor = Color.Red
			ElseIf flag = (fStress > 50F And fStress <= 400F) Then
				iScore = 70
				result = True
				Me.lblBotMin_FG_50_400.ForeColor = Color.Red
			ElseIf flag = (fStress > 400F And fStress <= 1000F) Then
				iScore = 95
				result = True
				Me.lblBotMin_FG_400_1000.ForeColor = Color.Red
			ElseIf flag = fStress > 1000F Then
				iScore = 100
				result = True
				Me.lblBotMin_FG_1000.ForeColor = Color.Red
			Else
				result = False
			End If
			Return result
		End Function

		Public Function GetSTLBotMinStressScore(fStress As Single, ByRef iScore As Integer) As Boolean
			Dim flag As Boolean = True
			Dim result As Boolean
			If flag = RSWIN_DESC.rst.PumpDepth < 1000F Then
				iScore = 100
				result = True
				Me.lblBotMin_1000.ForeColor = Color.Red
			ElseIf flag = (fStress < 0F And fStress > -300F) Then
				iScore = 50
				result = True
				Me.lblBotMin_300_0.ForeColor = Color.Red
			ElseIf flag = fStress > 3000F Then
				iScore = 50
				result = True
				Me.lblBotMin_3000.ForeColor = Color.Red
			ElseIf flag = (fStress > 2000F And fStress <= 3000F) Then
				iScore = 60
				result = True
				Me.lblBotMin_2000_3000.ForeColor = Color.Red
			ElseIf flag = (fStress > 1200F And fStress <= 2000F) Then
				iScore = 80
				result = True
				Me.lblBotMin_1200_2000.ForeColor = Color.Red
			ElseIf flag = (fStress > 800F And fStress <= 1200F) Then
				iScore = 90
				result = True
				Me.lblBotMin_800_1200.ForeColor = Color.Red
			ElseIf flag = (fStress > 650F And fStress <= 800F) Then
				iScore = 95
				result = True
				Me.lblBotMin_650_800.ForeColor = Color.Red
			ElseIf flag = (fStress > 300F And fStress <= 650F) Then
				iScore = 100
				result = True
				Me.lblBotMin_300_650.ForeColor = Color.Red
			ElseIf flag = (fStress > 200F And fStress <= 300F) Then
				iScore = 95
				result = True
				Me.lblBotMin_200_300.ForeColor = Color.Red
			ElseIf flag = (fStress > 100F And fStress <= 200F) Then
				iScore = 90
				result = True
				Me.lblBotMin_100_200.ForeColor = Color.Red
			ElseIf flag = (fStress > 50F And fStress <= 100F) Then
				iScore = 80
				result = True
				Me.lblBotMin_50_100.ForeColor = Color.Red
			ElseIf flag = (fStress > 25F And fStress <= 50F) Then
				iScore = 70
				result = True
				Me.lblBotMin_25_50.ForeColor = Color.Red
			ElseIf flag = (fStress > 0F And fStress <= 25F) Then
				iScore = 60
				result = True
				Me.lblBotMin_0_25.ForeColor = Color.Red
			ElseIf flag = fStress <= -300F Then
				iScore = 30
				result = True
				Me.lblBotMin_300.ForeColor = Color.Red
			Else
				result = False
			End If
			Return result
		End Function

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
				Dim num5 As Integer = 0
				Dim num6 As Integer = Me.GroupHeader1.Controls.Count - 1
				For i As Integer = num5 To num6
					Try
						If Me.GroupHeader1.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.GroupHeader1.Controls(i), Label)
							If Operators.CompareString(label.Name.Substring(0, Me.slbl.Length), Me.slbl, False) = 0 Then
								Me.AddRexResource(label.Name, label.Text)
							End If
						End If
					Catch ex3 As Exception
						Debug.WriteLine(ex3.Message)
					End Try
				Next
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub AddRexResource(sKey As String, sVal As String)
			RSWIN_DESC.RwX.AddResource(sKey, sVal)
		End Sub

		Private Sub ReadReportControlStrings()
			Dim sPrefix As String = "rptExpertAnalysis-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
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
				Dim num6 As Integer = Me.GroupHeader1.Controls.Count - 1
				For i As Integer = num5 To num6
					Try
						If Me.GroupHeader1.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.GroupHeader1.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex3 As Exception
					End Try
				Next
				Dim num7 As Integer = 0
				Dim num8 As Integer = Me.GroupFooter1.Controls.Count - 1
				For i As Integer = num7 To num8
					Try
						If Me.GroupFooter1.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.GroupFooter1.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex4 As Exception
					End Try
				Next
				Dim num9 As Integer = 0
				Dim num10 As Integer = Me.Detail.Controls.Count - 1
				For i As Integer = num9 To num10
					Try
						If Me.Detail.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.Detail.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex5 As Exception
					End Try
				Next
			Catch ex6 As Exception
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

		Private Sub GroupHeader1_Format(sender As Object, e As EventArgs)
		End Sub

		Private nLFCount As Integer

		Private ReportLines As rptExpertAnalysis.ReportLine_Struct()

		Private sExpert As String

		Private Const LD_VBAR As Integer = 1

		Private Const LD_TEEDOWN As Integer = 2

		Private Const LD_HBAR As Integer = 3

		Private Const LD_CROSS As Integer = 4

		Private Const MARGIN As Integer = 700

		Private Const HDRSIZE As Integer = 12

		Private Const TXTSIZE As Integer = 11

		Private sNull As String

		Private slbl As String

		Private sScoreAPlus As String

		Private sScoreA As String

		Private sScoreAMinus As String

		Private sScoreBPlus As String

		Private sScoreB As String

		Private sScoreBMinus As String

		Private sScoreC As String

		Private sScoreD As String

		Private sScoreF As String

		<AccessedThroughProperty("PageHeader")>
		Private _PageHeader As PageHeader

		<AccessedThroughProperty("GroupHeader1")>
		Private _GroupHeader1 As GroupHeader

		<AccessedThroughProperty("Detail")>
		Private _Detail As Detail

		<AccessedThroughProperty("GroupFooter1")>
		Private _GroupFooter1 As GroupFooter

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

		Private lblOtherRLS As Label

		Private lblTOTALSCORE As Label

		Private lblGEARBOXSCORE As Label

		Private lblRODLOADINGSCORE As Label

		Private lblSTRUCTURELOADINGSCORE As Label

		Private lblSYSTEMEFFICIENCYSCORE As Label

		Private lblGB_70_95 As Label

		Private lblGB_60_70 As Label

		Private lblGB_50_60 As Label

		Private lblGB_95_100 As Label

		Private lblGB_100_110 As Label

		Private lblGB_110_120 As Label

		Private lblGB_120_135 As Label

		Private lblRL_70_95 As Label

		Private lblRL_60_70 As Label

		Private lblRL_50_60 As Label

		Private lblRL_40_50 As Label

		Private lblRL_40 As Label

		Private lblSL_70_95 As Label

		Private lblSL_60_70 As Label

		Private lblSL_50_60 As Label

		Private lblSL_50 As Label

		Private lblSL_95_100 As Label

		Private lblSL_100_110 As Label

		Private lblSL_110_120 As Label

		Private lblSEF_45 As Label

		Private lblSEF_42_45 As Label

		Private lblSEF_35_40 As Label

		Private lblSEF_30_35 As Label

		Private lblSEF_25 As Label

		Private lblGB_50 As Label

		Private lblSL_SmallUnit As Label

		Private lblBottomMinStressSCORE As Label

		Private lblBotMin_1000 As Label

		Private lblFootNote As Label

		Private lblGB_135 As Label

		Private lblRL_70_C As Label

		Private lblRL_95_100 As Label

		Private lblRL_100_110 As Label

		Private lblRL_110_120 As Label

		Private lblRL_120 As Label

		Private lblSL_120 As Label

		Private lblGB_SmallUnit As Label

		Private lblSEF_25_30 As Label

		Private lblBotMin_100_200 As Label

		Private lblBotMin_50_100 As Label

		Private lblBotMin_25_50 As Label

		Private lblBotMin_0_25 As Label

		Private lblBotMin_300_0 As Label

		Private lblBotMin_300 As Label

		Private lblBotMin_2000_3000 As Label

		Private lblSteel As Label

		Private lblBotMin_FG_400_1000 As Label

		Private lblBotMin_FG_50_400 As Label

		Private lblBotMin_FG_1000 As Label

		Private lblFGlassSteel As Label

		Private lblBotMin_200_300 As Label

		Private lblBotMin_300_650 As Label

		Private lblBotMin_3000 As Label

		Private lblBotMin_FG_0 As Label

		Private lblMPRL As Label

		Private lblMPRL_200 As Label

		Private lblMPRL_100_200 As Label

		Private lblMPRL_50_100 As Label

		Private lblMPRL_20_50 As Label

		Private lblMPRL_0_20 As Label

		Private lblMPRL_0 As Label

		Private lblBotMin_650_800 As Label

		Private lblBotMin_800_1200 As Label

		Private lblBotMin_1200_2000 As Label

		Private lblFootNote2 As Label

		Private lblSEF_40_42 As Label

		Private lblOtherGB As Label

		Private lblOtherSL As Label

		Private sAirAtTankAt As String

		Private sLicenseTo As String

		Private sCompany As String

		Private sWell As String

		Private sUser As String

		Private sDiskFile As String

		Private sDate As String

		Private sPage As String

		Private sOf As String

		Private sComment As String

		Private sThetaEnterprises As String

		Private m_bPrint As Boolean

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer

		Private I As Integer

		Private Structure ReportLine_Struct
			Public nLineNum As Integer

			Public sLineValue As String

			Public bMakeBold As Boolean
		End Structure
	End Class
End Namespace
