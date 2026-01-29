Imports System
Imports System.ComponentModel
Imports System.Diagnostics
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
	Public Class rptRecommendedGuideReport2
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.ActiveReport_ReportStart
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
			Me.lblFromTo = Nothing
			Me.lblMaxSideLoadUnits = Nothing
			Me.lblDepth = Nothing
			Me.lblMaxSideLoad = Nothing
			Me.lblGuideNumber = Nothing
			Me.Line1 = Nothing
			Me.Line2 = Nothing
			Me.Line4 = Nothing
			Me.fldDepth = Nothing
			Me.fldMaxSideLoad = Nothing
			Me.fldNumOfGuides = Nothing
			Me.lblMaxGuides = Nothing
			Me.lblMinGuides = Nothing
			Me.lblGuide_Footnote = Nothing
			Me.sNull = ""
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

		Private Overridable Property lblRodDiameter As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblRodDiameter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblRodDiameter = value
			End Set
		End Property

		Private Overridable Property lblRodDiamUnits As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblRodDiamUnits
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblRodDiamUnits = value
			End Set
		End Property

		Private Overridable Property fldRodDiam As DataDynamics.ActiveReports.TextBox
			Get
				Return Me._fldRodDiam
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.TextBox)
				Me._fldRodDiam = value
			End Set
		End Property

		Private Overridable Property Line5 As Line
			Get
				Return Me._Line5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line5 = value
			End Set
		End Property

		Private Overridable Property Label1 As DataDynamics.ActiveReports.Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._Label1 = value
			End Set
		End Property

		Private Overridable Property Label2 As DataDynamics.ActiveReports.Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._Label2 = value
			End Set
		End Property

		Private Overridable Property lblEntered As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblEntered
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblEntered = value
			End Set
		End Property

		Private Overridable Property fldGuideType As DataDynamics.ActiveReports.TextBox
			Get
				Return Me._fldGuideType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.TextBox)
				Me._fldGuideType = value
			End Set
		End Property

		Private Overridable Property fldNumOfGuidesUserEntered As DataDynamics.ActiveReports.TextBox
			Get
				Return Me._fldNumOfGuidesUserEntered
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.TextBox)
				Me._fldNumOfGuidesUserEntered = value
			End Set
		End Property

		Private Overridable Property Line6 As Line
			Get
				Return Me._Line6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line6 = value
			End Set
		End Property

		Private Overridable Property Line7 As Line
			Get
				Return Me._Line7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line7 = value
			End Set
		End Property

		Private Overridable Property fldFootnoteMarker As DataDynamics.ActiveReports.TextBox
			Get
				Return Me._fldFootnoteMarker
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.TextBox)
				Me._fldFootnoteMarker = value
			End Set
		End Property

		Private Overridable Property fldFootnoteMarkerUserEntered As DataDynamics.ActiveReports.TextBox
			Get
				Return Me._fldFootnoteMarkerUserEntered
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.TextBox)
				Me._fldFootnoteMarkerUserEntered = value
			End Set
		End Property

		Private Overridable Property Label4 As DataDynamics.ActiveReports.Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._Label4 = value
			End Set
		End Property

		Private Overridable Property lblTaper As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblTaper
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblTaper = value
			End Set
		End Property

		Private Overridable Property lblTaperNumber As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblTaperNumber
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblTaperNumber = value
			End Set
		End Property

		Private Overridable Property Line3 As Line
			Get
				Return Me._Line3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line3 = value
			End Set
		End Property

		Private Overridable Property fldTaper As DataDynamics.ActiveReports.TextBox
			Get
				Return Me._fldTaper
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.TextBox)
				Me._fldTaper = value
			End Set
		End Property

		Private Sub InitializeComponent()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptRecommendedGuideReport2))
			Me.Detail = New Detail()
			Me.fldDepth = New DataDynamics.ActiveReports.TextBox()
			Me.fldMaxSideLoad = New DataDynamics.ActiveReports.TextBox()
			Me.fldNumOfGuides = New DataDynamics.ActiveReports.TextBox()
			Me.fldRodDiam = New DataDynamics.ActiveReports.TextBox()
			Me.fldGuideType = New DataDynamics.ActiveReports.TextBox()
			Me.fldNumOfGuidesUserEntered = New DataDynamics.ActiveReports.TextBox()
			Me.fldFootnoteMarker = New DataDynamics.ActiveReports.TextBox()
			Me.fldFootnoteMarkerUserEntered = New DataDynamics.ActiveReports.TextBox()
			Me.PageHeader = New PageHeader()
			Me.lblTitle = New DataDynamics.ActiveReports.Label()
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
			Me.lblWellName = New DataDynamics.ActiveReports.Label()
			Me.lblDiskFile = New DataDynamics.ActiveReports.Label()
			Me.lblSecondCompanyName = New DataDynamics.ActiveReports.Label()
			Me.lblSecondCompanyPhonenumber = New DataDynamics.ActiveReports.Label()
			Me.lblGoTheta = New DataDynamics.ActiveReports.Label()
			Me.PageFooter = New PageFooter()
			Me.lblMaxGuides = New DataDynamics.ActiveReports.Label()
			Me.lblMinGuides = New DataDynamics.ActiveReports.Label()
			Me.lblGuide_Footnote = New DataDynamics.ActiveReports.Label()
			Me.GroupHeader1 = New GroupHeader()
			Me.Label2 = New DataDynamics.ActiveReports.Label()
			Me.lblEntered = New DataDynamics.ActiveReports.Label()
			Me.Label1 = New DataDynamics.ActiveReports.Label()
			Me.lblFromTo = New DataDynamics.ActiveReports.Label()
			Me.lblMaxSideLoadUnits = New DataDynamics.ActiveReports.Label()
			Me.lblDepth = New DataDynamics.ActiveReports.Label()
			Me.lblMaxSideLoad = New DataDynamics.ActiveReports.Label()
			Me.lblGuideNumber = New DataDynamics.ActiveReports.Label()
			Me.Line1 = New Line()
			Me.Line2 = New Line()
			Me.Line4 = New Line()
			Me.lblRodDiameter = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiamUnits = New DataDynamics.ActiveReports.Label()
			Me.Line5 = New Line()
			Me.Line6 = New Line()
			Me.Line7 = New Line()
			Me.Label4 = New DataDynamics.ActiveReports.Label()
			Me.GroupFooter1 = New GroupFooter()
			Me.lblTaper = New DataDynamics.ActiveReports.Label()
			Me.lblTaperNumber = New DataDynamics.ActiveReports.Label()
			Me.Line3 = New Line()
			Me.fldTaper = New DataDynamics.ActiveReports.TextBox()
			CType(Me.fldDepth, ISupportInitialize).BeginInit()
			CType(Me.fldMaxSideLoad, ISupportInitialize).BeginInit()
			CType(Me.fldNumOfGuides, ISupportInitialize).BeginInit()
			CType(Me.fldRodDiam, ISupportInitialize).BeginInit()
			CType(Me.fldGuideType, ISupportInitialize).BeginInit()
			CType(Me.fldNumOfGuidesUserEntered, ISupportInitialize).BeginInit()
			CType(Me.fldFootnoteMarker, ISupportInitialize).BeginInit()
			CType(Me.fldFootnoteMarkerUserEntered, ISupportInitialize).BeginInit()
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
			CType(Me.lblMaxGuides, ISupportInitialize).BeginInit()
			CType(Me.lblMinGuides, ISupportInitialize).BeginInit()
			CType(Me.lblGuide_Footnote, ISupportInitialize).BeginInit()
			CType(Me.Label2, ISupportInitialize).BeginInit()
			CType(Me.lblEntered, ISupportInitialize).BeginInit()
			CType(Me.Label1, ISupportInitialize).BeginInit()
			CType(Me.lblFromTo, ISupportInitialize).BeginInit()
			CType(Me.lblMaxSideLoadUnits, ISupportInitialize).BeginInit()
			CType(Me.lblDepth, ISupportInitialize).BeginInit()
			CType(Me.lblMaxSideLoad, ISupportInitialize).BeginInit()
			CType(Me.lblGuideNumber, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiameter, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiamUnits, ISupportInitialize).BeginInit()
			CType(Me.Label4, ISupportInitialize).BeginInit()
			CType(Me.lblTaper, ISupportInitialize).BeginInit()
			CType(Me.lblTaperNumber, ISupportInitialize).BeginInit()
			CType(Me.fldTaper, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Controls.AddRange(New ARControl() { Me.fldDepth, Me.fldMaxSideLoad, Me.fldNumOfGuides, Me.fldRodDiam, Me.fldGuideType, Me.fldNumOfGuidesUserEntered, Me.fldFootnoteMarker, Me.fldFootnoteMarkerUserEntered, Me.fldTaper })
			Me.Detail.Height = 0.21F
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.fldDepth.DataField = "Depth"
			Me.fldDepth.Height = 0.1875F
			Me.fldDepth.Left = 1.03F
			Me.fldDepth.Name = "fldDepth"
			Me.fldDepth.Style = "text-align: center"
			Me.fldDepth.Text = "Depth"
			Me.fldDepth.Top = 0F
			Me.fldDepth.Width = 0.94F
			Me.fldMaxSideLoad.DataField = "MaxSideLoad"
			Me.fldMaxSideLoad.Height = 0.1875F
			Me.fldMaxSideLoad.Left = 3.126F
			Me.fldMaxSideLoad.Name = "fldMaxSideLoad"
			Me.fldMaxSideLoad.Style = "text-align: center"
			Me.fldMaxSideLoad.Text = "MaxSideLoad"
			Me.fldMaxSideLoad.Top = 0F
			Me.fldMaxSideLoad.Width = 0.823F
			Me.fldNumOfGuides.DataField = "NumOfGuides"
			Me.fldNumOfGuides.Height = 0.1875F
			Me.fldNumOfGuides.Left = 6.52F
			Me.fldNumOfGuides.Name = "fldNumOfGuides"
			Me.fldNumOfGuides.Style = "text-align: right"
			Me.fldNumOfGuides.Text = "NumOfGuides"
			Me.fldNumOfGuides.Top = 0F
			Me.fldNumOfGuides.Width = 0.9289998F
			Me.fldRodDiam.DataField = "RodDiam"
			Me.fldRodDiam.Height = 0.1875F
			Me.fldRodDiam.Left = 2.035F
			Me.fldRodDiam.Name = "fldRodDiam"
			Me.fldRodDiam.Style = "text-align: center"
			Me.fldRodDiam.Text = "RodDiam"
			Me.fldRodDiam.Top = 0F
			Me.fldRodDiam.Width = 1.035F
			Me.fldGuideType.DataField = "GuideType"
			Me.fldGuideType.Height = 0.1875F
			Me.fldGuideType.Left = 4.02F
			Me.fldGuideType.Name = "fldGuideType"
			Me.fldGuideType.Style = "text-align: center"
			Me.fldGuideType.Text = "GuideType"
			Me.fldGuideType.Top = 0F
			Me.fldGuideType.Width = 1F
			Me.fldNumOfGuidesUserEntered.DataField = "NumOfGuidesUserEntered"
			Me.fldNumOfGuidesUserEntered.Height = 0.1875F
			Me.fldNumOfGuidesUserEntered.Left = 5.09F
			Me.fldNumOfGuidesUserEntered.Name = "fldNumOfGuidesUserEntered"
			Me.fldNumOfGuidesUserEntered.Style = "text-align: right"
			Me.fldNumOfGuidesUserEntered.Text = "NumOfGuidesUserEntered"
			Me.fldNumOfGuidesUserEntered.Top = 0F
			Me.fldNumOfGuidesUserEntered.Width = 0.8990002F
			Me.fldFootnoteMarker.DataField = "FootnoteMarker"
			Me.fldFootnoteMarker.Height = 0.1875F
			Me.fldFootnoteMarker.Left = 7.59F
			Me.fldFootnoteMarker.Name = "fldFootnoteMarker"
			Me.fldFootnoteMarker.Style = "text-align: center"
			Me.fldFootnoteMarker.Text = "FootnoteMarker"
			Me.fldFootnoteMarker.Top = 0.022F
			Me.fldFootnoteMarker.Width = 0.26F
			Me.fldFootnoteMarkerUserEntered.DataField = "FootnoteMarkerUserEntered"
			Me.fldFootnoteMarkerUserEntered.Height = 0.1875F
			Me.fldFootnoteMarkerUserEntered.Left = 6.12F
			Me.fldFootnoteMarkerUserEntered.Name = "fldFootnoteMarkerUserEntered"
			Me.fldFootnoteMarkerUserEntered.Style = "text-align: center"
			Me.fldFootnoteMarkerUserEntered.Text = "FootnoteMarkerUserEntered"
			Me.fldFootnoteMarkerUserEntered.Top = 0F
			Me.fldFootnoteMarkerUserEntered.Width = 0.26F
			Me.PageHeader.Controls.AddRange(New ARControl() { Me.lblTitle, Me.lblComment, Me.lblTitle1, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserName, Me.lblUserDate, Me.lblLabel2, Me.lblCompany, Me.lblWellName, Me.lblDiskFile, Me.lblSecondCompanyName, Me.lblSecondCompanyPhonenumber, Me.lblGoTheta })
			Me.PageHeader.Height = 1.134722F
			Me.PageHeader.Name = "PageHeader"
			Me.lblTitle.Height = 0.1875F
			Me.lblTitle.HyperLink = Nothing
			Me.lblTitle.Left = 0.125F
			Me.lblTitle.Name = "lblTitle"
			Me.lblTitle.Style = "background-color: rgb(128,128,128); color: rgb(255,255,255); text-align: center"
			Me.lblTitle.Text = "Recommended Guide Report"
			Me.lblTitle.Top = 0.94F
			Me.lblTitle.Width = 7.75F
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
			Me.PageFooter.CanGrow = False
			Me.PageFooter.Controls.AddRange(New ARControl() { Me.lblMaxGuides, Me.lblMinGuides, Me.lblGuide_Footnote })
			Me.PageFooter.Height = 0.5104167F
			Me.PageFooter.Name = "PageFooter"
			Me.lblMaxGuides.Height = 0.15F
			Me.lblMaxGuides.HyperLink = Nothing
			Me.lblMaxGuides.Left = 0.1875F
			Me.lblMaxGuides.Name = "lblMaxGuides"
			Me.lblMaxGuides.Style = "font-family: Microsoft Sans Serif; font-size: 7pt"
			Me.lblMaxGuides.Text = ""
			Me.lblMaxGuides.Top = 0.01F
			Me.lblMaxGuides.Visible = False
			Me.lblMaxGuides.Width = 7.5625F
			Me.lblMinGuides.Height = 0.15F
			Me.lblMinGuides.HyperLink = Nothing
			Me.lblMinGuides.Left = 0.187F
			Me.lblMinGuides.Name = "lblMinGuides"
			Me.lblMinGuides.Style = "font-family: Microsoft Sans Serif; font-size: 7pt"
			Me.lblMinGuides.Text = ""
			Me.lblMinGuides.Top = 0.17F
			Me.lblMinGuides.Visible = False
			Me.lblMinGuides.Width = 7.5625F
			Me.lblGuide_Footnote.Height = 0.15F
			Me.lblGuide_Footnote.HyperLink = Nothing
			Me.lblGuide_Footnote.Left = 0.187F
			Me.lblGuide_Footnote.Name = "lblGuide_Footnote"
			Me.lblGuide_Footnote.Style = "font-family: Microsoft Sans Serif; font-size: 7pt; text-align: left"
			Me.lblGuide_Footnote.Text = ""
			Me.lblGuide_Footnote.Top = 0.328F
			Me.lblGuide_Footnote.Visible = False
			Me.lblGuide_Footnote.Width = 7.5625F
			Me.GroupHeader1.Controls.AddRange(New ARControl() { Me.Label2, Me.lblEntered, Me.Label1, Me.lblFromTo, Me.lblMaxSideLoadUnits, Me.lblDepth, Me.lblMaxSideLoad, Me.lblGuideNumber, Me.Line1, Me.Line2, Me.Line4, Me.lblRodDiameter, Me.lblRodDiamUnits, Me.Line5, Me.Line6, Me.Line7, Me.Label4, Me.lblTaper, Me.lblTaperNumber, Me.Line3 })
			Me.GroupHeader1.Height = 0.4481944F
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.GroupHeader1.RepeatStyle = RepeatStyle.OnPageIncludeNoDetail
			Me.Label2.Height = 0.1875F
			Me.Label2.HyperLink = Nothing
			Me.Label2.Left = 4.02F
			Me.Label2.Name = "Label2"
			Me.Label2.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.Label2.Text = ""
			Me.Label2.Top = 0.2F
			Me.Label2.Width = 1F
			Me.lblEntered.Height = 0.1875F
			Me.lblEntered.HyperLink = Nothing
			Me.lblEntered.Left = 5.09F
			Me.lblEntered.Name = "lblEntered"
			Me.lblEntered.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblEntered.Text = "Entered"
			Me.lblEntered.Top = 0.2F
			Me.lblEntered.Width = 1.37F
			Me.Label1.Height = 0.18F
			Me.Label1.HyperLink = Nothing
			Me.Label1.Left = 5.09F
			Me.Label1.Name = "Label1"
			Me.Label1.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.Label1.Text = "Number of Guides per Rod"
			Me.Label1.Top = 0.012F
			Me.Label1.Width = 2.78F
			Me.lblFromTo.Height = 0.1875F
			Me.lblFromTo.HyperLink = Nothing
			Me.lblFromTo.Left = 1.03F
			Me.lblFromTo.Name = "lblFromTo"
			Me.lblFromTo.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblFromTo.Text = "lblFromTo"
			Me.lblFromTo.Top = 0.2F
			Me.lblFromTo.Width = 0.94F
			Me.lblMaxSideLoadUnits.Height = 0.1875F
			Me.lblMaxSideLoadUnits.HyperLink = Nothing
			Me.lblMaxSideLoadUnits.Left = 3.126F
			Me.lblMaxSideLoadUnits.Name = "lblMaxSideLoadUnits"
			Me.lblMaxSideLoadUnits.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblMaxSideLoadUnits.Text = "lblMaxSideLoadUni"
			Me.lblMaxSideLoadUnits.Top = 0.2F
			Me.lblMaxSideLoadUnits.Width = 0.823F
			Me.lblDepth.Height = 0.1875F
			Me.lblDepth.HyperLink = Nothing
			Me.lblDepth.Left = 1.03F
			Me.lblDepth.Name = "lblDepth"
			Me.lblDepth.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblDepth.Text = "Depth"
			Me.lblDepth.Top = 0.012F
			Me.lblDepth.Width = 0.94F
			Me.lblMaxSideLoad.Height = 0.1875F
			Me.lblMaxSideLoad.HyperLink = Nothing
			Me.lblMaxSideLoad.Left = 3.126F
			Me.lblMaxSideLoad.Name = "lblMaxSideLoad"
			Me.lblMaxSideLoad.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblMaxSideLoad.Text = "Max Side Load"
			Me.lblMaxSideLoad.Top = 0.012F
			Me.lblMaxSideLoad.Width = 0.823F
			Me.lblGuideNumber.Height = 0.1875F
			Me.lblGuideNumber.HyperLink = Nothing
			Me.lblGuideNumber.Left = 6.52F
			Me.lblGuideNumber.Name = "lblGuideNumber"
			Me.lblGuideNumber.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblGuideNumber.Text = "Calculated "
			Me.lblGuideNumber.Top = 0.2F
			Me.lblGuideNumber.Width = 1.35F
			Me.Line1.Height = 0F
			Me.Line1.Left = 1.03F
			Me.Line1.LineWeight = 1F
			Me.Line1.Name = "Line1"
			Me.Line1.Top = 0.41F
			Me.Line1.Visible = False
			Me.Line1.Width = 0.94F
			Me.Line1.X1 = 1.03F
			Me.Line1.X2 = 1.97F
			Me.Line1.Y1 = 0.41F
			Me.Line1.Y2 = 0.41F
			Me.Line2.Height = 0F
			Me.Line2.Left = 3.126F
			Me.Line2.LineWeight = 1F
			Me.Line2.Name = "Line2"
			Me.Line2.Top = 0.41F
			Me.Line2.Visible = False
			Me.Line2.Width = 0.823F
			Me.Line2.X1 = 3.126F
			Me.Line2.X2 = 3.949F
			Me.Line2.Y1 = 0.41F
			Me.Line2.Y2 = 0.41F
			Me.Line4.Height = 0F
			Me.Line4.Left = 6.52F
			Me.Line4.LineWeight = 1F
			Me.Line4.Name = "Line4"
			Me.Line4.Top = 0.41F
			Me.Line4.Visible = False
			Me.Line4.Width = 1.35F
			Me.Line4.X1 = 6.52F
			Me.Line4.X2 = 7.87F
			Me.Line4.Y1 = 0.41F
			Me.Line4.Y2 = 0.41F
			Me.lblRodDiameter.Height = 0.1875F
			Me.lblRodDiameter.HyperLink = Nothing
			Me.lblRodDiameter.Left = 2.035F
			Me.lblRodDiameter.Name = "lblRodDiameter"
			Me.lblRodDiameter.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblRodDiameter.Text = "Rod Diameter"
			Me.lblRodDiameter.Top = 0.012F
			Me.lblRodDiameter.Width = 1.035F
			Me.lblRodDiamUnits.Height = 0.1875F
			Me.lblRodDiamUnits.HyperLink = Nothing
			Me.lblRodDiamUnits.Left = 2.035F
			Me.lblRodDiamUnits.Name = "lblRodDiamUnits"
			Me.lblRodDiamUnits.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblRodDiamUnits.Text = ""
			Me.lblRodDiamUnits.Top = 0.21F
			Me.lblRodDiamUnits.Width = 1.035F
			Me.Line5.Height = 0F
			Me.Line5.Left = 2.035F
			Me.Line5.LineWeight = 1F
			Me.Line5.Name = "Line5"
			Me.Line5.Top = 0.41F
			Me.Line5.Visible = False
			Me.Line5.Width = 1.035F
			Me.Line5.X1 = 2.035F
			Me.Line5.X2 = 3.07F
			Me.Line5.Y1 = 0.41F
			Me.Line5.Y2 = 0.41F
			Me.Line6.Height = 0F
			Me.Line6.Left = 4.02F
			Me.Line6.LineWeight = 1F
			Me.Line6.Name = "Line6"
			Me.Line6.Top = 0.41F
			Me.Line6.Visible = False
			Me.Line6.Width = 1F
			Me.Line6.X1 = 4.02F
			Me.Line6.X2 = 5.02F
			Me.Line6.Y1 = 0.41F
			Me.Line6.Y2 = 0.41F
			Me.Line7.Height = 0F
			Me.Line7.Left = 5.09F
			Me.Line7.LineWeight = 1F
			Me.Line7.Name = "Line7"
			Me.Line7.Top = 0.41F
			Me.Line7.Visible = False
			Me.Line7.Width = 1.37F
			Me.Line7.X1 = 5.09F
			Me.Line7.X2 = 6.46F
			Me.Line7.Y1 = 0.41F
			Me.Line7.Y2 = 0.41F
			Me.Label4.Height = 0.1875F
			Me.Label4.HyperLink = Nothing
			Me.Label4.Left = 4.02F
			Me.Label4.Name = "Label4"
			Me.Label4.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.Label4.Text = "Guide Type"
			Me.Label4.Top = 0.012F
			Me.Label4.Width = 1F
			Me.GroupFooter1.Height = 0F
			Me.GroupFooter1.Name = "GroupFooter1"
			Me.lblTaper.Height = 0.1875F
			Me.lblTaper.HyperLink = Nothing
			Me.lblTaper.Left = 0.13F
			Me.lblTaper.Name = "lblTaper"
			Me.lblTaper.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblTaper.Text = "Taper"
			Me.lblTaper.Top = 0F
			Me.lblTaper.Width = 0.84F
			Me.lblTaperNumber.Height = 0.1875F
			Me.lblTaperNumber.HyperLink = Nothing
			Me.lblTaperNumber.Left = 0.13F
			Me.lblTaperNumber.Name = "lblTaperNumber"
			Me.lblTaperNumber.Style = "background-color: rgb(192,192,192); color: rgb(255,255,255); text-align: center"
			Me.lblTaperNumber.Text = "#"
			Me.lblTaperNumber.Top = 0.2F
			Me.lblTaperNumber.Width = 0.84F
			Me.Line3.Height = 0F
			Me.Line3.Left = 0.13F
			Me.Line3.LineWeight = 1F
			Me.Line3.Name = "Line3"
			Me.Line3.Top = 0.41F
			Me.Line3.Visible = False
			Me.Line3.Width = 0.84F
			Me.Line3.X1 = 0.13F
			Me.Line3.X2 = 0.97F
			Me.Line3.Y1 = 0.41F
			Me.Line3.Y2 = 0.41F
			Me.fldTaper.DataField = "Taper"
			Me.fldTaper.Height = 0.1875F
			Me.fldTaper.Left = 0.13F
			Me.fldTaper.Name = "fldTaper"
			Me.fldTaper.Style = "text-align: center"
			Me.fldTaper.Text = "Taper"
			Me.fldTaper.Top = 0F
			Me.fldTaper.Width = 0.84F
			Me.MasterReport = False
			Me.MaxPages = 100L
			Me.PageSettings.Margins.Bottom = 0F
			Me.PageSettings.Margins.Left = 0.3F
			Me.PageSettings.Margins.Right = 0F
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
			Me.StyleSheet.Add(New StyleSheetRule("", "Heading4", "Normal"))
			CType(Me.fldDepth, ISupportInitialize).EndInit()
			CType(Me.fldMaxSideLoad, ISupportInitialize).EndInit()
			CType(Me.fldNumOfGuides, ISupportInitialize).EndInit()
			CType(Me.fldRodDiam, ISupportInitialize).EndInit()
			CType(Me.fldGuideType, ISupportInitialize).EndInit()
			CType(Me.fldNumOfGuidesUserEntered, ISupportInitialize).EndInit()
			CType(Me.fldFootnoteMarker, ISupportInitialize).EndInit()
			CType(Me.fldFootnoteMarkerUserEntered, ISupportInitialize).EndInit()
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
			CType(Me.lblMaxGuides, ISupportInitialize).EndInit()
			CType(Me.lblMinGuides, ISupportInitialize).EndInit()
			CType(Me.lblGuide_Footnote, ISupportInitialize).EndInit()
			CType(Me.Label2, ISupportInitialize).EndInit()
			CType(Me.lblEntered, ISupportInitialize).EndInit()
			CType(Me.Label1, ISupportInitialize).EndInit()
			CType(Me.lblFromTo, ISupportInitialize).EndInit()
			CType(Me.lblMaxSideLoadUnits, ISupportInitialize).EndInit()
			CType(Me.lblDepth, ISupportInitialize).EndInit()
			CType(Me.lblMaxSideLoad, ISupportInitialize).EndInit()
			CType(Me.lblGuideNumber, ISupportInitialize).EndInit()
			CType(Me.lblRodDiameter, ISupportInitialize).EndInit()
			CType(Me.lblRodDiamUnits, ISupportInitialize).EndInit()
			CType(Me.Label4, ISupportInitialize).EndInit()
			CType(Me.lblTaper, ISupportInitialize).EndInit()
			CType(Me.lblTaperNumber, ISupportInitialize).EndInit()
			CType(Me.fldTaper, ISupportInitialize).EndInit()
			CType(Me, ISupportInitialize).EndInit()
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

		Public Property bMaxFootnote As Boolean
			Get
				Return Me.m_bMaxFootnote
			End Get
			Set(value As Boolean)
				Me.m_bMaxFootnote = value
			End Set
		End Property

		Public Property bMinFootnote As Boolean
			Get
				Return Me.m_bMinFootnote
			End Get
			Set(value As Boolean)
				Me.m_bMinFootnote = value
			End Set
		End Property

		Public Property sMaxFootnote As String
			Get
				Return Me.m_sMaxFootnote
			End Get
			Set(value As String)
				Me.m_sMaxFootnote = value
			End Set
		End Property

		Public Property sMinFootnote As String
			Get
				Return Me.m_sMinFootnote
			End Get
			Set(value As String)
				Me.m_sMinFootnote = value
			End Set
		End Property

		Public Property sGuideMsg As String
			Get
				Return Me.m_sGuideMsg
			End Get
			Set(value As String)
				Me.m_sGuideMsg = value
			End Set
		End Property

		Private Sub ActiveReport_ReportStart(sender As Object, e As EventArgs)
			Dim num As Integer = 0
			If RSWIN_DESC.bReadResXFile Then
				Me.ReadReportControlStrings()
			End If
			Dim text As String = "BareRodLoad"
			Dim num2 As Single = 50F
			RSWIN_DESC.SETUP_BAREROD_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, num2))
			text = "MoldedLoad"
			num2 = 40F
			RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, num2))
			text = "WheelLoad"
			num2 = 25F
			RSWIN_DESC.SETUP_WHEELGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, num2))
			text = "OtherLoad"
			num2 = 32.5F
			RSWIN_DESC.SETUP_OTHERGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, num2))
			Dim sDefaultName As String = "SteelSuckerRodLength"
			Dim value As Object = DBNull.Value
			Dim flag As Boolean = False
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag))
			RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
			text = "MaxNumGuidesPerRod"
			Dim num3 As Integer = 6
			RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, num3))
			text = "MinNumGuidesPerRod"
			num3 = 3
			RSWIN_DESC.SETUP_MinNumGuidesPerRod = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, num3))
			Me.TEMP_SETUP_BAREROD_LOAD = RSWIN_DESC.SETUP_BAREROD_LOAD
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				CtrlUI.ConvertValue(Me.TEMP_SETUP_BAREROD_LOAD, "l", False)
			End If
			Me.TEMP_SETUP_MOLDEDGUIDE_LOAD = RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				CtrlUI.ConvertValue(Me.TEMP_SETUP_MOLDEDGUIDE_LOAD, "l", False)
			End If
			Me.TEMP_SETUP_WHEELGUIDE_LOAD = RSWIN_DESC.SETUP_WHEELGUIDE_LOAD
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				CtrlUI.ConvertValue(Me.TEMP_SETUP_WHEELGUIDE_LOAD, "l", False)
			End If
			Me.TEMP_SETUP_OTHERGUIDE_LOAD = RSWIN_DESC.SETUP_OTHERGUIDE_LOAD
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				CtrlUI.ConvertValue(Me.TEMP_SETUP_OTHERGUIDE_LOAD, "l", False)
			End If
			Me.TEMP_SETUP_NorrisStandardGuide_Load = RSWIN_DESC.SETUP_NorrisStandardGuide_Load
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				CtrlUI.ConvertValue(Me.TEMP_SETUP_NorrisStandardGuide_Load, "l", False)
			End If
			Me.TEMP_SETUP_NorrisSidewinderGuide_Load = RSWIN_DESC.SETUP_NorrisSidewinderGuide_Load
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				CtrlUI.ConvertValue(Me.TEMP_SETUP_NorrisSidewinderGuide_Load, "l", False)
			End If
			Me.TEMP_SETUP_RGIJakeCouplingGuide_Load = RSWIN_DESC.SETUP_RGIJakeCouplingGuide_Load
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				CtrlUI.ConvertValue(Me.TEMP_SETUP_RGIJakeCouplingGuide_Load, "l", False)
			End If
			Me.TEMP_SETUP_RGISVTGuide_LOAD = RSWIN_DESC.SETUP_RGISVTGuide_LOAD
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				CtrlUI.ConvertValue(Me.TEMP_SETUP_RGISVTGuide_LOAD, "l", False)
			End If
			Me.TEMP_SETUP_RGITomahawkGuide_LOAD = RSWIN_DESC.SETUP_RGITomahawkGuide_LOAD
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				CtrlUI.ConvertValue(Me.TEMP_SETUP_RGITomahawkGuide_LOAD, "l", False)
			End If
			Me.TEMP_SETUP_RGITornadoGuide_LOAD = RSWIN_DESC.SETUP_RGITornadoGuide_LOAD
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				CtrlUI.ConvertValue(Me.TEMP_SETUP_RGITornadoGuide_LOAD, "l", False)
			End If
			Me.TEMP_SETUP_RGITwisterGuide_LOAD = RSWIN_DESC.SETUP_RGITwisterGuide_LOAD
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				CtrlUI.ConvertValue(Me.TEMP_SETUP_RGITwisterGuide_LOAD, "l", False)
			End If
			Me.TEMP_SETUP_RGIWVTGuide_LOAD = RSWIN_DESC.SETUP_RGIWVTGuide_LOAD
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				CtrlUI.ConvertValue(Me.TEMP_SETUP_RGIWVTGuide_LOAD, "l", False)
			End If
			Dim setup_SteelSuckerRodLength As Single = RSWIN_DESC.SETUP_SteelSuckerRodLength
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				CtrlUI.ConvertValue(setup_SteelSuckerRodLength, "f", False)
			End If
			Dim flag2 As Boolean = RSWIN.HasFG(num)
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				Me.lblMaxSideLoadUnits.Text = "lbs/" + Conversions.ToString(setup_SteelSuckerRodLength) + " ft"
				If flag2 Then
					Dim num4 As Single
					Me.lblMaxSideLoadUnits.Text = Me.lblMaxSideLoadUnits.Text + " (stl) ," + Conversions.ToString(num4) + " ft (f'glass)"
				End If
				Me.lblFromTo.Text = "ft"
			ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				Me.lblMaxSideLoadUnits.Text = "lbs/" + Conversions.ToString(Math.Round(CDbl(setup_SteelSuckerRodLength), 2)) + " m"
				If flag2 Then
					Me.lblMaxSideLoadUnits.Text = Me.lblMaxSideLoadUnits.Text + " (stl) ," + Conversions.ToString(Math.Round(CDbl(setup_SteelSuckerRodLength), 2)) + " m (f'glass)"
				End If
				Me.lblFromTo.Text = "m"
			ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				Me.lblMaxSideLoadUnits.Text = "N/" + Conversions.ToString(Math.Round(CDbl(setup_SteelSuckerRodLength), 2)) + " m"
				If flag2 Then
					Me.lblMaxSideLoadUnits.Text = Me.lblMaxSideLoadUnits.Text + " (stl) ," + Conversions.ToString(Math.Round(CDbl(setup_SteelSuckerRodLength), 2)) + " m (f'glass)"
				End If
				Me.lblFromTo.Text = "m"
			End If
			Me.printFont = New Font("Arial", 10F)
			Me.PageSettings.Margins.Left = 0.25F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0.3F
			Me.PageSettings.Margins.Bottom = 0F
			Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
			If(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_RunForSpeed And If((-If(((Strings.InStr(Me.lblComment.Text, Conversions.ToString(RSWIN_DESC.sRunForSpeedFootnote), CompareMethod.Binary) = 0) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				Me.lblGuide_Footnote.Text = Conversions.ToString(RSWIN_DESC.sRunForSpeedFootnote)
				Me.lblGuide_Footnote.Visible = True
			Else
				Me.lblGuide_Footnote.Text = ""
				Me.lblGuide_Footnote.Visible = False
			End If
			If Me.m_bMaxFootnote Then
				Me.lblMaxGuides.Visible = True
				Me.lblMaxGuides.Text = Me.m_sMaxFootnote
			Else
				Me.lblMaxGuides.Visible = False
				Me.lblMaxGuides.Text = ""
			End If
			If Me.m_bMinFootnote Then
				Me.lblMinGuides.Visible = True
				Me.lblMinGuides.Text = Me.m_sMinFootnote
			Else
				Me.lblMinGuides.Visible = False
				Me.lblMinGuides.Text = ""
			End If
			If Not Me.lblMaxGuides.Visible And Me.lblMinGuides.Visible Then
				Me.lblMinGuides.Left = Me.lblMaxGuides.Left
			End If
			If Me.m_sGuideMsg Is Nothing Then
				Me.m_sGuideMsg = ""
			End If
			If Operators.CompareString(Me.m_sGuideMsg.Trim(), "", False) <> 0 Then
				Me.lblGuide_Footnote.Visible = True
				Me.lblGuide_Footnote.Text = Me.m_sGuideMsg
			Else
				Me.lblGuide_Footnote.Visible = False
				Me.lblGuide_Footnote.Text = ""
			End If
			If Me.m_NumberOfLines = 0 Then
				If RSWIN.AllNoGuides() Then
					Me.lblTitle.Text = "No Recommended Guide Report for this case. No rod guides chosen."
				Else
					Me.lblTitle.Text = "No Recommended Guide Report for this case. All side loads are below minimum requirements for specified guide."
				End If
				Me.GroupHeader1.Visible = False
			Else
				Me.lblTitle.Text = "Recommended Guide Report"
				Me.GroupHeader1.Visible = True
			End If
			If RSWIN_DESC.bIntVersion Then
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter("rptRecommendedGuideReport2")
					Me.WriteControlStrings()
					Util.CloseResourceWriter()
				End If
				If RSWIN_DESC.bReadResXFile Then
					Me.ReadReportControlStrings()
				End If
			End If
			If RSWIN_DESC.bRodStarD Then
				If RSWIN_DESC.rst.bImplementedDesign Then
					Me.lblEntered.Text = "Recommended"
				Else
					Me.lblEntered.Text = "Entered"
				End If
			End If
			Application.DoEvents()
		End Sub

		Private Sub Detail_Format(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = Me.fldFootnoteMarker.Text
				If text IsNot Nothing Then
					If Strings.InStr(text, "*", CompareMethod.Binary) > 0 And Strings.InStr(text, "**", CompareMethod.Binary) <= 0 Then
						Me.fldFootnoteMarker.BackColor = Color.White
						Me.fldFootnoteMarker.ForeColor = Color.DarkRed
						Me.fldTaper.BackColor = Color.White
						Me.fldTaper.ForeColor = Color.DarkRed
						Me.fldDepth.BackColor = Color.White
						Me.fldDepth.ForeColor = Color.DarkRed
						Me.fldRodDiam.BackColor = Color.White
						Me.fldRodDiam.ForeColor = Color.DarkRed
						Me.fldMaxSideLoad.BackColor = Color.White
						Me.fldMaxSideLoad.ForeColor = Color.DarkRed
						Me.fldGuideType.BackColor = Color.White
						Me.fldGuideType.ForeColor = Color.DarkRed
						Me.fldNumOfGuides.BackColor = Color.White
						Me.fldNumOfGuides.ForeColor = Color.DarkRed
					Else
						Me.fldFootnoteMarker.BackColor = Color.White
						Me.fldFootnoteMarker.ForeColor = Color.Black
						Me.fldTaper.BackColor = Color.White
						Me.fldTaper.ForeColor = Color.Black
						Me.fldDepth.BackColor = Color.White
						Me.fldDepth.ForeColor = Color.Black
						Me.fldRodDiam.BackColor = Color.White
						Me.fldRodDiam.ForeColor = Color.Black
						Me.fldMaxSideLoad.BackColor = Color.White
						Me.fldMaxSideLoad.ForeColor = Color.Black
						Me.fldGuideType.BackColor = Color.White
						Me.fldGuideType.ForeColor = Color.Black
						Me.fldNumOfGuides.BackColor = Color.White
						Me.fldNumOfGuides.ForeColor = Color.Black
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

		Private Sub ReadReportControlStrings()
			Dim sPrefix As String = "rptRecommendedGuideReport2-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = Me.PageHeader.Controls.Count - 1
				For i As Integer = num To num2
					Try
						If Me.PageHeader.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.PageHeader.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex As Exception
					End Try
				Next
				Dim num3 As Integer = 0
				Dim num4 As Integer = Me.PageFooter.Controls.Count - 1
				For i As Integer = num3 To num4
					Try
						If Me.PageFooter.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.PageFooter.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex2 As Exception
					End Try
				Next
				Dim num5 As Integer = 0
				Dim num6 As Integer = Me.GroupHeader1.Controls.Count - 1
				For i As Integer = num5 To num6
					Try
						If Me.GroupHeader1.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.GroupHeader1.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex3 As Exception
					End Try
				Next
				Dim num7 As Integer = 0
				Dim num8 As Integer = Me.GroupFooter1.Controls.Count - 1
				For i As Integer = num7 To num8
					Try
						If Me.GroupFooter1.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.GroupFooter1.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex4 As Exception
					End Try
				Next
				Dim num9 As Integer = 0
				Dim num10 As Integer = Me.Detail.Controls.Count - 1
				For i As Integer = num9 To num10
					Try
						If Me.Detail.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.Detail.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex5 As Exception
					End Try
				Next
			Catch ex6 As Exception
			End Try
		End Sub

		Public Sub AssignValueToReportControl(sPrefix As String, ByRef objControl As DataDynamics.ActiveReports.Label)
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
						If Me.Detail.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.Detail.Controls(i), DataDynamics.ActiveReports.Label)
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
						If Me.PageHeader.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.PageHeader.Controls(i), DataDynamics.ActiveReports.Label)
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

		Private lblTitle As DataDynamics.ActiveReports.Label

		Private lblComment As DataDynamics.ActiveReports.Label

		Private lblTitle1 As DataDynamics.ActiveReports.Label

		Private lblPage As DataDynamics.ActiveReports.Label

		Private txtPage1 As DataDynamics.ActiveReports.TextBox

		Private lblOf As DataDynamics.ActiveReports.Label

		Private txtPage2 As DataDynamics.ActiveReports.TextBox

		Private lblUserName As DataDynamics.ActiveReports.Label

		Private lblUserDate As DataDynamics.ActiveReports.Label

		Private lblLabel2 As DataDynamics.ActiveReports.Label

		Private lblCompany As DataDynamics.ActiveReports.Label

		Private lblWellName As DataDynamics.ActiveReports.Label

		Private lblDiskFile As DataDynamics.ActiveReports.Label

		Private lblSecondCompanyName As DataDynamics.ActiveReports.Label

		Private lblSecondCompanyPhonenumber As DataDynamics.ActiveReports.Label

		Private lblGoTheta As DataDynamics.ActiveReports.Label

		Private lblFromTo As DataDynamics.ActiveReports.Label

		Private lblMaxSideLoadUnits As DataDynamics.ActiveReports.Label

		Private lblDepth As DataDynamics.ActiveReports.Label

		Private lblMaxSideLoad As DataDynamics.ActiveReports.Label

		Private lblGuideNumber As DataDynamics.ActiveReports.Label

		Private Line1 As Line

		Private Line2 As Line

		Private Line4 As Line

		Private fldDepth As DataDynamics.ActiveReports.TextBox

		Private fldMaxSideLoad As DataDynamics.ActiveReports.TextBox

		Private fldNumOfGuides As DataDynamics.ActiveReports.TextBox

		Private lblMaxGuides As DataDynamics.ActiveReports.Label

		Private lblMinGuides As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblRodDiameter")>
		Private _lblRodDiameter As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblRodDiamUnits")>
		Private _lblRodDiamUnits As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("fldRodDiam")>
		Private _fldRodDiam As DataDynamics.ActiveReports.TextBox

		<AccessedThroughProperty("Line5")>
		Private _Line5 As Line

		<AccessedThroughProperty("Label1")>
		Private _Label1 As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblEntered")>
		Private _lblEntered As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("fldGuideType")>
		Private _fldGuideType As DataDynamics.ActiveReports.TextBox

		<AccessedThroughProperty("fldNumOfGuidesUserEntered")>
		Private _fldNumOfGuidesUserEntered As DataDynamics.ActiveReports.TextBox

		<AccessedThroughProperty("Line6")>
		Private _Line6 As Line

		<AccessedThroughProperty("Line7")>
		Private _Line7 As Line

		<AccessedThroughProperty("fldFootnoteMarker")>
		Private _fldFootnoteMarker As DataDynamics.ActiveReports.TextBox

		<AccessedThroughProperty("fldFootnoteMarkerUserEntered")>
		Private _fldFootnoteMarkerUserEntered As DataDynamics.ActiveReports.TextBox

		<AccessedThroughProperty("Label4")>
		Private _Label4 As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblTaper")>
		Private _lblTaper As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblTaperNumber")>
		Private _lblTaperNumber As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("Line3")>
		Private _Line3 As Line

		<AccessedThroughProperty("fldTaper")>
		Private _fldTaper As DataDynamics.ActiveReports.TextBox

		Private lblGuide_Footnote As DataDynamics.ActiveReports.Label

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

		Private m_bMaxFootnote As Boolean

		Private m_bMinFootnote As Boolean

		Private m_sMaxFootnote As String

		Private m_sMinFootnote As String

		Private m_sGuideMsg As String

		Private $STATIC$Detail_Format$20211C1241$cnt As Long

		Private $STATIC$Detail_Format$20211C1241$bNextPage As Boolean
	End Class
End Namespace
