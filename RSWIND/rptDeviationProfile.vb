Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.DataSources
Imports DataDynamics.ActiveReports.Document
Imports DDCssLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class rptDeviationProfile
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.rptDeviationProfile_ReportStart
			Me.PageHeader = Nothing
			Me.GroupHeader1 = Nothing
			Me.Detail = Nothing
			Me.GroupFooter1 = Nothing
			Me.PageFooter = Nothing
			Me.ds = Nothing
			Me.lblTitle = Nothing
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
			Me.lblDepth = Nothing
			Me.lblInclination = Nothing
			Me.lblAzimuth = Nothing
			Me.lblDogleg = Nothing
			Me.lblTVD = Nothing
			Me.lblNS = Nothing
			Me.lblEW = Nothing
			Me.fldDepth = Nothing
			Me.fldInclination = Nothing
			Me.fldAzimuty = Nothing
			Me.fldDogleg = Nothing
			Me.fldTVD = Nothing
			Me.fldNS = Nothing
			Me.fldEW = Nothing
			Me.sCompany = Util.AssignValueToConstant("rptCalcResults", "sCompany", "Company: ")
			Me.sWell = Util.AssignValueToConstant("rptCalcResults", "sWell", "Well: ")
			Me.sUser = Util.AssignValueToConstant("rptCalcResults", "sUser", "User: ")
			Me.sDiskFile = Util.AssignValueToConstant("rptCalcResults", "sDiskFile", "Disk file: ")
			Me.sDate = Util.AssignValueToConstant("rptCalcResults", "sDate", "Date: ")
			Me.sPage = Util.AssignValueToConstant("rptCalcResults", "sPage", "Page")
			Me.sOf = Util.AssignValueToConstant("rptCalcResults", "sOf", "of")
			Me.sComment = Util.AssignValueToConstant("rptCalcResults", "sComment", "Comment: ")
			Me.sLicenseTo = Util.AssignValueToConstant("rptCalcResults", "sLicenseTo", " - Licensed to ")
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
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptDeviationProfile))
			Me.Detail = New Detail()
			Me.fldDepth = New TextBox()
			Me.fldInclination = New TextBox()
			Me.fldAzimuty = New TextBox()
			Me.fldDogleg = New TextBox()
			Me.fldTVD = New TextBox()
			Me.fldNS = New TextBox()
			Me.fldEW = New TextBox()
			Me.PageHeader = New PageHeader()
			Me.lblTitle = New Label()
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
			Me.lblDepth = New Label()
			Me.lblInclination = New Label()
			Me.lblAzimuth = New Label()
			Me.lblDogleg = New Label()
			Me.lblTVD = New Label()
			Me.lblNS = New Label()
			Me.lblEW = New Label()
			Me.GroupFooter1 = New GroupFooter()
			CType(Me.fldDepth, ISupportInitialize).BeginInit()
			CType(Me.fldInclination, ISupportInitialize).BeginInit()
			CType(Me.fldAzimuty, ISupportInitialize).BeginInit()
			CType(Me.fldDogleg, ISupportInitialize).BeginInit()
			CType(Me.fldTVD, ISupportInitialize).BeginInit()
			CType(Me.fldNS, ISupportInitialize).BeginInit()
			CType(Me.fldEW, ISupportInitialize).BeginInit()
			CType(Me.lblTitle, ISupportInitialize).BeginInit()
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
			CType(Me.lblDepth, ISupportInitialize).BeginInit()
			CType(Me.lblInclination, ISupportInitialize).BeginInit()
			CType(Me.lblAzimuth, ISupportInitialize).BeginInit()
			CType(Me.lblDogleg, ISupportInitialize).BeginInit()
			CType(Me.lblTVD, ISupportInitialize).BeginInit()
			CType(Me.lblNS, ISupportInitialize).BeginInit()
			CType(Me.lblEW, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Controls.AddRange(New ARControl() { Me.fldDepth, Me.fldInclination, Me.fldAzimuty, Me.fldDogleg, Me.fldTVD, Me.fldNS, Me.fldEW })
			Me.Detail.Height = 0.21875F
			Me.Detail.Name = "Detail"
			Me.fldDepth.DataField = "Depth"
			Me.fldDepth.Height = 0.1875F
			Me.fldDepth.Left = 0.0625F
			Me.fldDepth.Name = "fldDepth"
			Me.fldDepth.Style = "text-align: center"
			Me.fldDepth.Text = "Depth"
			Me.fldDepth.Top = 0F
			Me.fldDepth.Width = 1F
			Me.fldInclination.DataField = "Inclination"
			Me.fldInclination.Height = 0.1875F
			Me.fldInclination.Left = 1.125F
			Me.fldInclination.Name = "fldInclination"
			Me.fldInclination.Style = "text-align: center"
			Me.fldInclination.Text = "Inclination"
			Me.fldInclination.Top = 0F
			Me.fldInclination.Width = 1F
			Me.fldAzimuty.DataField = "Azimuth"
			Me.fldAzimuty.Height = 0.1875F
			Me.fldAzimuty.Left = 2.1875F
			Me.fldAzimuty.Name = "fldAzimuty"
			Me.fldAzimuty.Style = "text-align: center"
			Me.fldAzimuty.Text = "Azimuth"
			Me.fldAzimuty.Top = 0F
			Me.fldAzimuty.Width = 1F
			Me.fldDogleg.DataField = "Dogleg"
			Me.fldDogleg.Height = 0.1875F
			Me.fldDogleg.Left = 3.25F
			Me.fldDogleg.Name = "fldDogleg"
			Me.fldDogleg.Style = "text-align: center"
			Me.fldDogleg.Text = "Dogleg"
			Me.fldDogleg.Top = 0F
			Me.fldDogleg.Width = 1.25F
			Me.fldTVD.DataField = "TVDepth"
			Me.fldTVD.Height = 0.1875F
			Me.fldTVD.Left = 4.5625F
			Me.fldTVD.Name = "fldTVD"
			Me.fldTVD.Style = "text-align: center"
			Me.fldTVD.Text = "TVDepth"
			Me.fldTVD.Top = 0F
			Me.fldTVD.Width = 1.0625F
			Me.fldNS.DataField = "NorthSouth"
			Me.fldNS.Height = 0.1875F
			Me.fldNS.Left = 5.6875F
			Me.fldNS.Name = "fldNS"
			Me.fldNS.Style = "text-align: center"
			Me.fldNS.Text = "NorthSouth"
			Me.fldNS.Top = 0F
			Me.fldNS.Width = 1.0625F
			Me.fldEW.DataField = "EastWest"
			Me.fldEW.Height = 0.1875F
			Me.fldEW.Left = 6.8125F
			Me.fldEW.Name = "fldEW"
			Me.fldEW.Style = "text-align: center"
			Me.fldEW.Text = "EastWest"
			Me.fldEW.Top = 0F
			Me.fldEW.Width = 1.0625F
			Me.PageHeader.Controls.AddRange(New ARControl() { Me.lblTitle, Me.lblComment, Me.lblTitle1, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserName, Me.lblUserDate, Me.lblLabel2, Me.lblCompany, Me.lblWellName, Me.lblDiskFile, Me.lblSecondCompanyName, Me.lblSecondCompanyPhonenumber, Me.lblGoTheta })
			Me.PageHeader.Height = 1.21875F
			Me.PageHeader.Name = "PageHeader"
			Me.lblTitle.Height = 0.1875F
			Me.lblTitle.HyperLink = Nothing
			Me.lblTitle.Left = 0F
			Me.lblTitle.Name = "lblTitle"
			Me.lblTitle.Style = "background-color: rgb(128,128,128); color: rgb(255,255,255); text-align: center"
			Me.lblTitle.Text = "Measured Deviation Survey"
			Me.lblTitle.Top = 1F
			Me.lblTitle.Width = 7.95F
			Me.lblComment.Height = 0.275F
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
			Me.PageFooter.Height = 0.0625F
			Me.PageFooter.Name = "PageFooter"
			Me.GroupHeader1.Controls.AddRange(New ARControl() { Me.lblDepth, Me.lblInclination, Me.lblAzimuth, Me.lblDogleg, Me.lblTVD, Me.lblNS, Me.lblEW })
			Me.GroupHeader1.Height = 0.2076389F
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.GroupHeader1.RepeatStyle = RepeatStyle.OnPageIncludeNoDetail
			Me.lblDepth.Height = 0.1875F
			Me.lblDepth.HyperLink = Nothing
			Me.lblDepth.Left = 0.0625F
			Me.lblDepth.Name = "lblDepth"
			Me.lblDepth.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblDepth.Text = "MD (ft)"
			Me.lblDepth.Top = 0F
			Me.lblDepth.Width = 1F
			Me.lblInclination.Height = 0.1875F
			Me.lblInclination.HyperLink = Nothing
			Me.lblInclination.Left = 1.125F
			Me.lblInclination.Name = "lblInclination"
			Me.lblInclination.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblInclination.Text = "Inclination (°)"
			Me.lblInclination.Top = 0F
			Me.lblInclination.Width = 1F
			Me.lblAzimuth.Height = 0.1875F
			Me.lblAzimuth.HyperLink = Nothing
			Me.lblAzimuth.Left = 2.1875F
			Me.lblAzimuth.Name = "lblAzimuth"
			Me.lblAzimuth.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblAzimuth.Text = "Azimuth (°)"
			Me.lblAzimuth.Top = 0F
			Me.lblAzimuth.Width = 1F
			Me.lblDogleg.Height = 0.1875F
			Me.lblDogleg.HyperLink = Nothing
			Me.lblDogleg.Left = 3.25F
			Me.lblDogleg.Name = "lblDogleg"
			Me.lblDogleg.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblDogleg.Text = "Dogleg sev. °/100ft"
			Me.lblDogleg.Top = 0F
			Me.lblDogleg.Width = 1.25F
			Me.lblTVD.Height = 0.1875F
			Me.lblTVD.HyperLink = Nothing
			Me.lblTVD.Left = 4.5625F
			Me.lblTVD.Name = "lblTVD"
			Me.lblTVD.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblTVD.Text = "TVD (ft)"
			Me.lblTVD.Top = 0F
			Me.lblTVD.Width = 1.0625F
			Me.lblNS.Height = 0.1875F
			Me.lblNS.HyperLink = Nothing
			Me.lblNS.Left = 5.6875F
			Me.lblNS.Name = "lblNS"
			Me.lblNS.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblNS.Text = "N-S (ft)"
			Me.lblNS.Top = 0F
			Me.lblNS.Width = 1.0625F
			Me.lblEW.Height = 0.1875F
			Me.lblEW.HyperLink = Nothing
			Me.lblEW.Left = 6.8125F
			Me.lblEW.Name = "lblEW"
			Me.lblEW.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblEW.Text = "E-W (ft)"
			Me.lblEW.Top = 0F
			Me.lblEW.Width = 1.0625F
			Me.GroupFooter1.Height = 0.25F
			Me.GroupFooter1.Name = "GroupFooter1"
			Me.MasterReport = False
			Me.PageSettings.Margins.Bottom = 0.15F
			Me.PageSettings.Margins.Left = 0.25F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0.15F
			Me.PageSettings.PaperHeight = 11F
			Me.PageSettings.PaperWidth = 8.5F
			Me.PrintWidth = 8.052083F
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
			CType(Me.fldDepth, ISupportInitialize).EndInit()
			CType(Me.fldInclination, ISupportInitialize).EndInit()
			CType(Me.fldAzimuty, ISupportInitialize).EndInit()
			CType(Me.fldDogleg, ISupportInitialize).EndInit()
			CType(Me.fldTVD, ISupportInitialize).EndInit()
			CType(Me.fldNS, ISupportInitialize).EndInit()
			CType(Me.fldEW, ISupportInitialize).EndInit()
			CType(Me.lblTitle, ISupportInitialize).EndInit()
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
			CType(Me.lblDepth, ISupportInitialize).EndInit()
			CType(Me.lblInclination, ISupportInitialize).EndInit()
			CType(Me.lblAzimuth, ISupportInitialize).EndInit()
			CType(Me.lblDogleg, ISupportInitialize).EndInit()
			CType(Me.lblTVD, ISupportInitialize).EndInit()
			CType(Me.lblNS, ISupportInitialize).EndInit()
			CType(Me.lblEW, ISupportInitialize).EndInit()
			CType(Me, ISupportInitialize).EndInit()
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

		Private Sub Detail_Format(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Me.$STATIC$Detail_Format$20211C1241$cnt += 1L
			If Me.$STATIC$Detail_Format$20211C1241$cnt = 35L Then
				Me.Detail.NewPage = NewPage.After
				Me.$STATIC$Detail_Format$20211C1241$cnt = 0L
				Me.$STATIC$Detail_Format$20211C1241$bNextPage = True
				Return
			End If
			If Me.$STATIC$Detail_Format$20211C1241$bNextPage Then
				Me.m_ThisPageNumber += 1
				Me.txtPage1.Text = Me.m_ThisPageNumber.ToString()
			End If
			Me.Detail.NewPage = NewPage.None
			Me.$STATIC$Detail_Format$20211C1241$bNextPage = False
		End Sub

		Private Sub rptDeviationProfile_ReportStart(sender As Object, e As EventArgs)
			Me.lblInclination.Text = "Inclination (°)"
			Me.lblAzimuth.Text = "Azimuth (°)"
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				Me.lblDogleg.Text = "Dogleg sev. °/100ft"
				Me.lblDepth.Text = "MD (ft)"
				Me.lblTVD.Text = "TVD (ft)"
				Me.lblNS.Text = "N-S (ft)"
				Me.lblEW.Text = "E-W (ft)"
			Else
				Me.lblDogleg.Text = "Dogleg sev. °/30m"
				Me.lblDepth.Text = "MD (m)"
				Me.lblTVD.Text = "TVD (m)"
				Me.lblNS.Text = "N-S (m)"
				Me.lblEW.Text = "E-W (m)"
			End If
			Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
			If RSWIN_DESC.bWriteResXFile Then
				Me.OpenResourceWriter("rptDeviationProfile")
				Me.WriteControlStrings()
				Me.CloseResourceWriter()
			End If
			If RSWIN_DESC.bReadResXFile Then
				Me.ReadReportControlStrings()
				Return
			End If
		End Sub

		Private Sub OpenResourceWriter(sFrm As String)
			RSWIN_DESC.RwX = New ResXResourceWriter(sFrm.Trim() + "." + RSWIN_DESC.SETUP_Language + ".resx")
		End Sub

		Private Sub CloseResourceWriter()
			RSWIN_DESC.RwX.Generate()
			RSWIN_DESC.RwX.Close()
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
							If Operators.CompareString(label.Name.Substring(0, 3), "lbl", False) = 0 Then
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
							If Operators.CompareString(label.Name.Substring(0, 3), "lbl", False) = 0 Then
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

		Private Sub ReadReportControlStrings()
			Dim sPrefix As String = "rptDeviationProfile-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
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

		Public ds As XMLDataSource

		Private lblTitle As Label

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

		Private lblDepth As Label

		Private lblInclination As Label

		Private lblAzimuth As Label

		Private lblDogleg As Label

		Private lblTVD As Label

		Private lblNS As Label

		Private lblEW As Label

		Private fldDepth As TextBox

		Private fldInclination As TextBox

		Private fldAzimuty As TextBox

		Private fldDogleg As TextBox

		Private fldTVD As TextBox

		Private fldNS As TextBox

		Private fldEW As TextBox

		Private sCompany As String

		Private sWell As String

		Private sUser As String

		Private sDiskFile As String

		Private sDate As String

		Private sPage As String

		Private sOf As String

		Private sComment As String

		Private sLicenseTo As String

		Private sThetaEnterprises As String

		Private Const iLineNumPerPage As Integer = 35

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer

		Private m_NumberOfLines As Integer

		Private m_bPrint As Boolean

		Private $STATIC$Detail_Format$20211C1241$cnt As Long

		Private $STATIC$Detail_Format$20211C1241$bNextPage As Boolean
	End Class
End Namespace
