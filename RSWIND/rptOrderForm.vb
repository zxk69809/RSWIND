Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports DDCssLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports ThetaStdInfo

Namespace RSWINV3
	<DesignerGenerated()>
	Public Class rptOrderForm
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.myReportStart
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
			Me.NewSections = New RSWIN_DESC.RodSection(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Me.iNumRods = 0
			Me.InitializeComponent()
		End Sub

		Protected Overrides Sub Dispose(disposing As Boolean)
			MyBase.Dispose(disposing)
		End Sub

		Private Overridable Property PageHeader1 As PageHeader
			Get
				Return Me._PageHeader1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PageHeader)
				Me._PageHeader1 = value
			End Set
		End Property

		Private Overridable Property Detail1 As Detail
			Get
				Return Me._Detail1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Detail)
				Dim value2 As EventHandler = AddressOf Me.Detail1_Format
				If Me._Detail1 IsNot Nothing Then
					RemoveHandler Me._Detail1.Format, value2
				End If
				Me._Detail1 = value
				If Me._Detail1 IsNot Nothing Then
					AddHandler Me._Detail1.Format, value2
				End If
			End Set
		End Property

		Private Overridable Property PageFooter1 As PageFooter
			Get
				Return Me._PageFooter1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PageFooter)
				Me._PageFooter1 = value
			End Set
		End Property

		<DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim resourceManager As ResourceManager = New ResourceManager(GetType(rptOrderForm))
			Me.PageHeader1 = New PageHeader()
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
			Me.Detail1 = New Detail()
			Me.rod_box = New Shape()
			Me.guide_box = New Shape()
			Me.lblNumRods1 = New Label()
			Me.lblRodGrade1 = New Label()
			Me.lblRodDiam1 = New Label()
			Me.linSep1 = New Line()
			Me.lblRodDiamHdrTop = New Label()
			Me.lblRodDiamHdrBot = New Label()
			Me.lblRodGradeHdrBot = New Label()
			Me.lblNumRodsHdrBot = New Label()
			Me.Line12 = New Line()
			Me.lblRodDiam2 = New Label()
			Me.lblRodDiam3 = New Label()
			Me.lblRodDiam4 = New Label()
			Me.lblRodDiam5 = New Label()
			Me.lblRodDiam6 = New Label()
			Me.lblRodDiam7 = New Label()
			Me.lblRodDiam8 = New Label()
			Me.lblRodGrade2 = New Label()
			Me.lblRodGrade3 = New Label()
			Me.lblRodGrade4 = New Label()
			Me.lblRodGrade5 = New Label()
			Me.lblRodGrade6 = New Label()
			Me.lblRodGrade7 = New Label()
			Me.lblRodGrade8 = New Label()
			Me.lblNumRods2 = New Label()
			Me.lblNumRods3 = New Label()
			Me.lblNumRods4 = New Label()
			Me.lblNumRods5 = New Label()
			Me.lblNumRods6 = New Label()
			Me.lblNumRods7 = New Label()
			Me.lblNumRods8 = New Label()
			Me.lblGuideTypeHdrBot = New Label()
			Me.Line14 = New Line()
			Me.lblGuideType1 = New Label()
			Me.lblGuideType2 = New Label()
			Me.lblGuideType3 = New Label()
			Me.lblGuideType4 = New Label()
			Me.lblGuideType5 = New Label()
			Me.lblGuideType6 = New Label()
			Me.lblGuideType7 = New Label()
			Me.lblGuideType8 = New Label()
			Me.lblNumGuidesHdrBot = New Label()
			Me.lblNumGuides1 = New Label()
			Me.lblNumGuides2 = New Label()
			Me.lblNumGuides3 = New Label()
			Me.lblNumGuides4 = New Label()
			Me.lblNumGuides5 = New Label()
			Me.lblNumGuides6 = New Label()
			Me.lblNumGuides7 = New Label()
			Me.lblNumGuides8 = New Label()
			Me.lblRodGradeHdrTop = New Label()
			Me.lblGuideTypeHdrTop = New Label()
			Me.lblNumGuidesHdrTop = New Label()
			Me.lblNumRodsHdrTop = New Label()
			Me.linSep3 = New Line()
			Me.lblRodDiam9 = New Label()
			Me.lblRodGrade9 = New Label()
			Me.lblNumRods9 = New Label()
			Me.lblGuideType9 = New Label()
			Me.lblNumGuides9 = New Label()
			Me.lblRodDiam10 = New Label()
			Me.lblRodGrade10 = New Label()
			Me.lblNumRods10 = New Label()
			Me.lblGuideType10 = New Label()
			Me.lblNumGuides10 = New Label()
			Me.linSep2 = New Line()
			Me.lblNumRods11 = New Label()
			Me.lblRodGrade11 = New Label()
			Me.lblRodDiam11 = New Label()
			Me.lblRodDiam12 = New Label()
			Me.lblRodDiam13 = New Label()
			Me.lblRodDiam14 = New Label()
			Me.lblRodDiam15 = New Label()
			Me.lblRodDiam16 = New Label()
			Me.lblRodDiam17 = New Label()
			Me.lblRodDiam18 = New Label()
			Me.lblRodGrade12 = New Label()
			Me.lblRodGrade13 = New Label()
			Me.lblRodGrade14 = New Label()
			Me.lblRodGrade15 = New Label()
			Me.lblRodGrade16 = New Label()
			Me.lblRodGrade17 = New Label()
			Me.lblRodGrade18 = New Label()
			Me.lblNumRods12 = New Label()
			Me.lblNumRods13 = New Label()
			Me.lblNumRods14 = New Label()
			Me.lblNumRods15 = New Label()
			Me.lblNumRods16 = New Label()
			Me.lblNumRods17 = New Label()
			Me.lblNumRods18 = New Label()
			Me.lblGuideType11 = New Label()
			Me.lblGuideType12 = New Label()
			Me.lblGuideType13 = New Label()
			Me.lblGuideType14 = New Label()
			Me.lblGuideType15 = New Label()
			Me.lblGuideType16 = New Label()
			Me.lblGuideType17 = New Label()
			Me.lblGuideType18 = New Label()
			Me.lblNumGuides11 = New Label()
			Me.lblNumGuides12 = New Label()
			Me.lblNumGuides13 = New Label()
			Me.lblNumGuides14 = New Label()
			Me.lblNumGuides15 = New Label()
			Me.lblNumGuides16 = New Label()
			Me.lblNumGuides17 = New Label()
			Me.lblNumGuides18 = New Label()
			Me.lblRodDiam19 = New Label()
			Me.lblRodGrade19 = New Label()
			Me.lblNumRods19 = New Label()
			Me.lblGuideType19 = New Label()
			Me.lblNumGuides19 = New Label()
			Me.lblRodDiam20 = New Label()
			Me.lblRodGrade20 = New Label()
			Me.lblNumRods20 = New Label()
			Me.lblGuideType20 = New Label()
			Me.lblNumGuides20 = New Label()
			Me.lblTotalLengthLabel = New Label()
			Me.lblTotalLength = New Label()
			Me.lblPumpDepthLabel = New Label()
			Me.lblReportTitle = New Label()
			Me.lblPumpDepth = New Label()
			Me.PageFooter1 = New PageFooter()
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
			CType(Me.lblNumRods1, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade1, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam1, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiamHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiamHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodGradeHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblNumRodsHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam2, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam3, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam4, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam5, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam6, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam7, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam8, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade2, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade3, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade4, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade5, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade6, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade7, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade8, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods2, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods3, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods4, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods5, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods6, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods7, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods8, ISupportInitialize).BeginInit()
			CType(Me.lblGuideTypeHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType1, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType2, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType3, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType4, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType5, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType6, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType7, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType8, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuidesHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides1, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides2, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides3, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides4, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides5, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides6, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides7, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides8, ISupportInitialize).BeginInit()
			CType(Me.lblRodGradeHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblGuideTypeHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuidesHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblNumRodsHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam9, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade9, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods9, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType9, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides9, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam10, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade10, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods10, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType10, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides10, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods11, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade11, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam11, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam12, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam13, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam14, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam15, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam16, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam17, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam18, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade12, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade13, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade14, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade15, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade16, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade17, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade18, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods12, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods13, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods14, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods15, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods16, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods17, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods18, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType11, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType12, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType13, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType14, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType15, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType16, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType17, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType18, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides11, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides12, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides13, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides14, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides15, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides16, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides17, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides18, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam19, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade19, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods19, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType19, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides19, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam20, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade20, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods20, ISupportInitialize).BeginInit()
			CType(Me.lblGuideType20, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides20, ISupportInitialize).BeginInit()
			CType(Me.lblTotalLengthLabel, ISupportInitialize).BeginInit()
			CType(Me.lblTotalLength, ISupportInitialize).BeginInit()
			CType(Me.lblPumpDepthLabel, ISupportInitialize).BeginInit()
			CType(Me.lblReportTitle, ISupportInitialize).BeginInit()
			CType(Me.lblPumpDepth, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.PageHeader1.Controls.AddRange(New ARControl() { Me.lblComment, Me.lblTitle1, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserName, Me.lblUserDate, Me.lblLabel2, Me.lblCompany, Me.lblWellName, Me.lblDiskFile, Me.lblSecondCompanyName, Me.lblSecondCompanyPhonenumber, Me.lblGoTheta })
			Me.PageHeader1.Height = 0.97125F
			Me.PageHeader1.Name = "PageHeader1"
			Me.lblComment.Height = 0.25F
			Me.lblComment.HyperLink = Nothing
			Me.lblComment.Left = 0F
			Me.lblComment.Name = "lblComment"
			Me.lblComment.Style = "font-family: Microsoft Sans Serif; font-size: 8pt"
			Me.lblComment.Text = "Comment: "
			Me.lblComment.Top = 0.69F
			Me.lblComment.Width = 7.875F
			Me.lblTitle1.Height = 0.17F
			Me.lblTitle1.HyperLink = Nothing
			Me.lblTitle1.Left = 0F
			Me.lblTitle1.Name = "lblTitle1"
			Me.lblTitle1.Style = "font-family: Microsoft Sans Serif; font-size: 9pt; font-weight: bold; text-align: center"
			Me.lblTitle1.Text = "RODSTAR-D 1.0"
			Me.lblTitle1.Top = 0F
			Me.lblTitle1.Width = 7.875F
			Me.lblPage.Height = 0.17F
			Me.lblPage.HyperLink = Nothing
			Me.lblPage.Left = 6F
			Me.lblPage.Name = "lblPage"
			Me.lblPage.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblPage.Text = "Page"
			Me.lblPage.Top = 0.18F
			Me.lblPage.Width = 0.4375F
			Me.txtPage1.Height = 0.17F
			Me.txtPage1.Left = 6.4375F
			Me.txtPage1.Name = "txtPage1"
			Me.txtPage1.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.txtPage1.Text = Nothing
			Me.txtPage1.Top = 0.18F
			Me.txtPage1.Width = 0.1875F
			Me.lblOf.Height = 0.17F
			Me.lblOf.HyperLink = Nothing
			Me.lblOf.Left = 6.625F
			Me.lblOf.Name = "lblOf"
			Me.lblOf.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblOf.Text = "of"
			Me.lblOf.Top = 0.18F
			Me.lblOf.Width = 0.1875F
			Me.txtPage2.Height = 0.17F
			Me.txtPage2.Left = 6.8125F
			Me.txtPage2.Name = "txtPage2"
			Me.txtPage2.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.txtPage2.Text = Nothing
			Me.txtPage2.Top = 0.18F
			Me.txtPage2.Width = 0.1875F
			Me.lblUserName.Height = 0.17F
			Me.lblUserName.HyperLink = Nothing
			Me.lblUserName.Left = 6F
			Me.lblUserName.Name = "lblUserName"
			Me.lblUserName.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblUserName.Text = "User: "
			Me.lblUserName.Top = 0.34F
			Me.lblUserName.Width = 1.875F
			Me.lblUserDate.Height = 0.17F
			Me.lblUserDate.HyperLink = Nothing
			Me.lblUserDate.Left = 6F
			Me.lblUserDate.Name = "lblUserDate"
			Me.lblUserDate.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblUserDate.Text = "Date: "
			Me.lblUserDate.Top = 0.51F
			Me.lblUserDate.Width = 1.875F
			Me.lblLabel2.Height = 0.17F
			Me.lblLabel2.HyperLink = Nothing
			Me.lblLabel2.Left = 2.9375F
			Me.lblLabel2.Name = "lblLabel2"
			Me.lblLabel2.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center"
			Me.lblLabel2.Text = "© Theta Oilfield Services, Inc."
			Me.lblLabel2.Top = 0.18F
			Me.lblLabel2.Width = 2F
			Me.lblCompany.Height = 0.17F
			Me.lblCompany.HyperLink = Nothing
			Me.lblCompany.Left = 0F
			Me.lblCompany.Name = "lblCompany"
			Me.lblCompany.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblCompany.Text = "Company: "
			Me.lblCompany.Top = 0.18F
			Me.lblCompany.Width = 2.9375F
			Me.lblWellName.Height = 0.17F
			Me.lblWellName.HyperLink = Nothing
			Me.lblWellName.Left = 0F
			Me.lblWellName.Name = "lblWellName"
			Me.lblWellName.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt"
			Me.lblWellName.Text = "Well: "
			Me.lblWellName.Top = 0.34F
			Me.lblWellName.Width = 2.9375F
			Me.lblDiskFile.Height = 0.17F
			Me.lblDiskFile.HyperLink = Nothing
			Me.lblDiskFile.Left = 0F
			Me.lblDiskFile.Name = "lblDiskFile"
			Me.lblDiskFile.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; white-space: nowrap"
			Me.lblDiskFile.Text = "Disk file: "
			Me.lblDiskFile.Top = 0.51F
			Me.lblDiskFile.Width = 2.9375F
			Me.lblSecondCompanyName.Height = 0.17F
			Me.lblSecondCompanyName.HyperLink = Nothing
			Me.lblSecondCompanyName.Left = 2.9375F
			Me.lblSecondCompanyName.Name = "lblSecondCompanyName"
			Me.lblSecondCompanyName.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center"
			Me.lblSecondCompanyName.Text = ""
			Me.lblSecondCompanyName.Top = 0.34F
			Me.lblSecondCompanyName.Width = 2F
			Me.lblSecondCompanyPhonenumber.Height = 0.17F
			Me.lblSecondCompanyPhonenumber.HyperLink = Nothing
			Me.lblSecondCompanyPhonenumber.Left = 2.9375F
			Me.lblSecondCompanyPhonenumber.Name = "lblSecondCompanyPhonenumber"
			Me.lblSecondCompanyPhonenumber.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center"
			Me.lblSecondCompanyPhonenumber.Text = ""
			Me.lblSecondCompanyPhonenumber.Top = 0.51F
			Me.lblSecondCompanyPhonenumber.Width = 2F
			Me.lblGoTheta.Height = 0.17F
			Me.lblGoTheta.HyperLink = Nothing
			Me.lblGoTheta.Left = 4.75F
			Me.lblGoTheta.Name = "lblGoTheta"
			Me.lblGoTheta.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center"
			Me.lblGoTheta.Text = "(www.gotheta.com)"
			Me.lblGoTheta.Top = 0.18F
			Me.lblGoTheta.Width = 1.0625F
			Me.Detail1.ColumnSpacing = 0F
			Me.Detail1.Controls.AddRange(New ARControl() { Me.rod_box, Me.guide_box, Me.lblNumRods1, Me.lblRodGrade1, Me.lblRodDiam1, Me.linSep1, Me.lblRodDiamHdrTop, Me.lblRodDiamHdrBot, Me.lblRodGradeHdrBot, Me.lblNumRodsHdrBot, Me.Line12, Me.lblRodDiam2, Me.lblRodDiam3, Me.lblRodDiam4, Me.lblRodDiam5, Me.lblRodDiam6, Me.lblRodDiam7, Me.lblRodDiam8, Me.lblRodGrade2, Me.lblRodGrade3, Me.lblRodGrade4, Me.lblRodGrade5, Me.lblRodGrade6, Me.lblRodGrade7, Me.lblRodGrade8, Me.lblNumRods2, Me.lblNumRods3, Me.lblNumRods4, Me.lblNumRods5, Me.lblNumRods6, Me.lblNumRods7, Me.lblNumRods8, Me.lblGuideTypeHdrBot, Me.Line14, Me.lblGuideType1, Me.lblGuideType2, Me.lblGuideType3, Me.lblGuideType4, Me.lblGuideType5, Me.lblGuideType6, Me.lblGuideType7, Me.lblGuideType8, Me.lblNumGuidesHdrBot, Me.lblNumGuides1, Me.lblNumGuides2, Me.lblNumGuides3, Me.lblNumGuides4, Me.lblNumGuides5, Me.lblNumGuides6, Me.lblNumGuides7, Me.lblNumGuides8, Me.lblRodGradeHdrTop, Me.lblGuideTypeHdrTop, Me.lblNumGuidesHdrTop, Me.lblNumRodsHdrTop, Me.linSep3, Me.lblRodDiam9, Me.lblRodGrade9, Me.lblNumRods9, Me.lblGuideType9, Me.lblNumGuides9, Me.lblRodDiam10, Me.lblRodGrade10, Me.lblNumRods10, Me.lblGuideType10, Me.lblNumGuides10, Me.linSep2, Me.lblNumRods11, Me.lblRodGrade11, Me.lblRodDiam11, Me.lblRodDiam12, Me.lblRodDiam13, Me.lblRodDiam14, Me.lblRodDiam15, Me.lblRodDiam16, Me.lblRodDiam17, Me.lblRodDiam18, Me.lblRodGrade12, Me.lblRodGrade13, Me.lblRodGrade14, Me.lblRodGrade15, Me.lblRodGrade16, Me.lblRodGrade17, Me.lblRodGrade18, Me.lblNumRods12, Me.lblNumRods13, Me.lblNumRods14, Me.lblNumRods15, Me.lblNumRods16, Me.lblNumRods17, Me.lblNumRods18, Me.lblGuideType11, Me.lblGuideType12, Me.lblGuideType13, Me.lblGuideType14, Me.lblGuideType15, Me.lblGuideType16, Me.lblGuideType17, Me.lblGuideType18, Me.lblNumGuides11, Me.lblNumGuides12, Me.lblNumGuides13, Me.lblNumGuides14, Me.lblNumGuides15, Me.lblNumGuides16, Me.lblNumGuides17, Me.lblNumGuides18, Me.lblRodDiam19, Me.lblRodGrade19, Me.lblNumRods19, Me.lblGuideType19, Me.lblNumGuides19, Me.lblRodDiam20, Me.lblRodGrade20, Me.lblNumRods20, Me.lblGuideType20, Me.lblNumGuides20, Me.lblTotalLengthLabel, Me.lblTotalLength, Me.lblPumpDepthLabel, Me.lblReportTitle, Me.lblPumpDepth })
			Me.Detail1.Height = 8.25F
			Me.Detail1.Name = "Detail1"
			Me.rod_box.Height = 3.446F
			Me.rod_box.Left = 0.241F
			Me.rod_box.Name = "rod_box"
			Me.rod_box.RoundingRadius = 9.999999F
			Me.rod_box.Tag = ""
			Me.rod_box.Top = 0.742F
			Me.rod_box.Width = 3.753F
			Me.guide_box.Height = 3.446F
			Me.guide_box.Left = 4.064F
			Me.guide_box.Name = "guide_box"
			Me.guide_box.RoundingRadius = 9.999999F
			Me.guide_box.Tag = ""
			Me.guide_box.Top = 0.742F
			Me.guide_box.Width = 2.671F
			Me.lblNumRods1.Height = 0.125F
			Me.lblNumRods1.HyperLink = Nothing
			Me.lblNumRods1.Left = 3.09F
			Me.lblNumRods1.Name = "lblNumRods1"
			Me.lblNumRods1.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods1.Text = " "
			Me.lblNumRods1.Top = 1.167F
			Me.lblNumRods1.Width = 0.81F
			Me.lblRodGrade1.Height = 0.14F
			Me.lblRodGrade1.HyperLink = Nothing
			Me.lblRodGrade1.Left = 0.291F
			Me.lblRodGrade1.Name = "lblRodGrade1"
			Me.lblRodGrade1.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade1.Text = " "
			Me.lblRodGrade1.Top = 1.167F
			Me.lblRodGrade1.Width = 1.56F
			Me.lblRodDiam1.Height = 0.125F
			Me.lblRodDiam1.HyperLink = Nothing
			Me.lblRodDiam1.Left = 1.978F
			Me.lblRodDiam1.Name = "lblRodDiam1"
			Me.lblRodDiam1.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam1.Text = " "
			Me.lblRodDiam1.Top = 1.167F
			Me.lblRodDiam1.Width = 1F
			Me.linSep1.Height = 3.342999F
			Me.linSep1.Left = 1.915F
			Me.linSep1.LineWeight = 1F
			Me.linSep1.Name = "linSep1"
			Me.linSep1.Top = 0.752F
			Me.linSep1.Width = 0F
			Me.linSep1.X1 = 1.915F
			Me.linSep1.X2 = 1.915F
			Me.linSep1.Y1 = 0.752F
			Me.linSep1.Y2 = 4.094999F
			Me.lblRodDiamHdrTop.Height = 0.145F
			Me.lblRodDiamHdrTop.HyperLink = Nothing
			Me.lblRodDiamHdrTop.Left = 1.988F
			Me.lblRodDiamHdrTop.Name = "lblRodDiamHdrTop"
			Me.lblRodDiamHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodDiamHdrTop.Text = "Diameter"
			Me.lblRodDiamHdrTop.Top = 0.7820001F
			Me.lblRodDiamHdrTop.Width = 1F
			Me.lblRodDiamHdrBot.Height = 0.145F
			Me.lblRodDiamHdrBot.HyperLink = Nothing
			Me.lblRodDiamHdrBot.Left = 1.988F
			Me.lblRodDiamHdrBot.Name = "lblRodDiamHdrBot"
			Me.lblRodDiamHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodDiamHdrBot.Text = "(inches)"
			Me.lblRodDiamHdrBot.Top = 0.9070001F
			Me.lblRodDiamHdrBot.Width = 1F
			Me.lblRodGradeHdrBot.Height = 0.145F
			Me.lblRodGradeHdrBot.HyperLink = Nothing
			Me.lblRodGradeHdrBot.Left = 0.29F
			Me.lblRodGradeHdrBot.Name = "lblRodGradeHdrBot"
			Me.lblRodGradeHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGradeHdrBot.Text = " Grade"
			Me.lblRodGradeHdrBot.Top = 0.9070001F
			Me.lblRodGradeHdrBot.Width = 1.556F
			Me.lblNumRodsHdrBot.Height = 0.145F
			Me.lblNumRodsHdrBot.HyperLink = Nothing
			Me.lblNumRodsHdrBot.Left = 3.09F
			Me.lblNumRodsHdrBot.Name = "lblNumRodsHdrBot"
			Me.lblNumRodsHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblNumRodsHdrBot.Text = "Rods"
			Me.lblNumRodsHdrBot.Top = 0.9070002F
			Me.lblNumRodsHdrBot.Width = 0.81F
			Me.Line12.Height = 0.004499912F
			Me.Line12.Left = 0.2905002F
			Me.Line12.LineWeight = 1F
			Me.Line12.Name = "Line12"
			Me.Line12.Top = 1.09F
			Me.Line12.Width = 3.6895F
			Me.Line12.X1 = 0.2905002F
			Me.Line12.X2 = 3.98F
			Me.Line12.Y1 = 1.0945F
			Me.Line12.Y2 = 1.09F
			Me.lblRodDiam2.Height = 0.125F
			Me.lblRodDiam2.HyperLink = Nothing
			Me.lblRodDiam2.Left = 1.978F
			Me.lblRodDiam2.Name = "lblRodDiam2"
			Me.lblRodDiam2.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam2.Text = " "
			Me.lblRodDiam2.Top = 1.312F
			Me.lblRodDiam2.Width = 1F
			Me.lblRodDiam3.Height = 0.125F
			Me.lblRodDiam3.HyperLink = Nothing
			Me.lblRodDiam3.Left = 1.978F
			Me.lblRodDiam3.Name = "lblRodDiam3"
			Me.lblRodDiam3.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam3.Text = " "
			Me.lblRodDiam3.Top = 1.457F
			Me.lblRodDiam3.Width = 1F
			Me.lblRodDiam4.Height = 0.125F
			Me.lblRodDiam4.HyperLink = Nothing
			Me.lblRodDiam4.Left = 1.978F
			Me.lblRodDiam4.Name = "lblRodDiam4"
			Me.lblRodDiam4.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam4.Text = " "
			Me.lblRodDiam4.Top = 1.602F
			Me.lblRodDiam4.Width = 1F
			Me.lblRodDiam5.Height = 0.125F
			Me.lblRodDiam5.HyperLink = Nothing
			Me.lblRodDiam5.Left = 1.978F
			Me.lblRodDiam5.Name = "lblRodDiam5"
			Me.lblRodDiam5.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam5.Text = " "
			Me.lblRodDiam5.Top = 1.747F
			Me.lblRodDiam5.Width = 1F
			Me.lblRodDiam6.Height = 0.125F
			Me.lblRodDiam6.HyperLink = Nothing
			Me.lblRodDiam6.Left = 1.978F
			Me.lblRodDiam6.Name = "lblRodDiam6"
			Me.lblRodDiam6.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam6.Text = " "
			Me.lblRodDiam6.Top = 1.892F
			Me.lblRodDiam6.Width = 1F
			Me.lblRodDiam7.Height = 0.125F
			Me.lblRodDiam7.HyperLink = Nothing
			Me.lblRodDiam7.Left = 1.978F
			Me.lblRodDiam7.Name = "lblRodDiam7"
			Me.lblRodDiam7.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam7.Text = " "
			Me.lblRodDiam7.Top = 2.037F
			Me.lblRodDiam7.Width = 1F
			Me.lblRodDiam8.Height = 0.125F
			Me.lblRodDiam8.HyperLink = Nothing
			Me.lblRodDiam8.Left = 1.978F
			Me.lblRodDiam8.Name = "lblRodDiam8"
			Me.lblRodDiam8.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam8.Text = " "
			Me.lblRodDiam8.Top = 2.202F
			Me.lblRodDiam8.Width = 1F
			Me.lblRodGrade2.Height = 0.14F
			Me.lblRodGrade2.HyperLink = Nothing
			Me.lblRodGrade2.Left = 0.291F
			Me.lblRodGrade2.Name = "lblRodGrade2"
			Me.lblRodGrade2.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade2.Text = " "
			Me.lblRodGrade2.Top = 1.312F
			Me.lblRodGrade2.Width = 1.56F
			Me.lblRodGrade3.Height = 0.14F
			Me.lblRodGrade3.HyperLink = Nothing
			Me.lblRodGrade3.Left = 0.291F
			Me.lblRodGrade3.Name = "lblRodGrade3"
			Me.lblRodGrade3.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade3.Text = " "
			Me.lblRodGrade3.Top = 1.457F
			Me.lblRodGrade3.Width = 1.56F
			Me.lblRodGrade4.Height = 0.14F
			Me.lblRodGrade4.HyperLink = Nothing
			Me.lblRodGrade4.Left = 0.291F
			Me.lblRodGrade4.Name = "lblRodGrade4"
			Me.lblRodGrade4.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade4.Text = " "
			Me.lblRodGrade4.Top = 1.602F
			Me.lblRodGrade4.Width = 1.56F
			Me.lblRodGrade5.Height = 0.14F
			Me.lblRodGrade5.HyperLink = Nothing
			Me.lblRodGrade5.Left = 0.291F
			Me.lblRodGrade5.Name = "lblRodGrade5"
			Me.lblRodGrade5.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade5.Text = " "
			Me.lblRodGrade5.Top = 1.747F
			Me.lblRodGrade5.Width = 1.56F
			Me.lblRodGrade6.Height = 0.14F
			Me.lblRodGrade6.HyperLink = Nothing
			Me.lblRodGrade6.Left = 0.291F
			Me.lblRodGrade6.Name = "lblRodGrade6"
			Me.lblRodGrade6.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade6.Text = " "
			Me.lblRodGrade6.Top = 1.892F
			Me.lblRodGrade6.Width = 1.56F
			Me.lblRodGrade7.Height = 0.14F
			Me.lblRodGrade7.HyperLink = Nothing
			Me.lblRodGrade7.Left = 0.291F
			Me.lblRodGrade7.Name = "lblRodGrade7"
			Me.lblRodGrade7.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade7.Text = " "
			Me.lblRodGrade7.Top = 2.037F
			Me.lblRodGrade7.Width = 1.56F
			Me.lblRodGrade8.Height = 0.14F
			Me.lblRodGrade8.HyperLink = Nothing
			Me.lblRodGrade8.Left = 0.291F
			Me.lblRodGrade8.Name = "lblRodGrade8"
			Me.lblRodGrade8.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade8.Text = " "
			Me.lblRodGrade8.Top = 2.202F
			Me.lblRodGrade8.Width = 1.56F
			Me.lblNumRods2.Height = 0.125F
			Me.lblNumRods2.HyperLink = Nothing
			Me.lblNumRods2.Left = 3.09F
			Me.lblNumRods2.Name = "lblNumRods2"
			Me.lblNumRods2.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods2.Text = " "
			Me.lblNumRods2.Top = 1.312F
			Me.lblNumRods2.Width = 0.81F
			Me.lblNumRods3.Height = 0.125F
			Me.lblNumRods3.HyperLink = Nothing
			Me.lblNumRods3.Left = 3.09F
			Me.lblNumRods3.Name = "lblNumRods3"
			Me.lblNumRods3.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods3.Text = " "
			Me.lblNumRods3.Top = 1.457F
			Me.lblNumRods3.Width = 0.81F
			Me.lblNumRods4.Height = 0.125F
			Me.lblNumRods4.HyperLink = Nothing
			Me.lblNumRods4.Left = 3.09F
			Me.lblNumRods4.Name = "lblNumRods4"
			Me.lblNumRods4.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods4.Text = " "
			Me.lblNumRods4.Top = 1.602F
			Me.lblNumRods4.Width = 0.81F
			Me.lblNumRods5.Height = 0.125F
			Me.lblNumRods5.HyperLink = Nothing
			Me.lblNumRods5.Left = 3.09F
			Me.lblNumRods5.Name = "lblNumRods5"
			Me.lblNumRods5.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods5.Text = " "
			Me.lblNumRods5.Top = 1.747F
			Me.lblNumRods5.Width = 0.81F
			Me.lblNumRods6.Height = 0.125F
			Me.lblNumRods6.HyperLink = Nothing
			Me.lblNumRods6.Left = 3.09F
			Me.lblNumRods6.Name = "lblNumRods6"
			Me.lblNumRods6.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods6.Text = " "
			Me.lblNumRods6.Top = 1.892F
			Me.lblNumRods6.Width = 0.81F
			Me.lblNumRods7.Height = 0.125F
			Me.lblNumRods7.HyperLink = Nothing
			Me.lblNumRods7.Left = 3.09F
			Me.lblNumRods7.Name = "lblNumRods7"
			Me.lblNumRods7.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods7.Text = " "
			Me.lblNumRods7.Top = 2.037F
			Me.lblNumRods7.Width = 0.81F
			Me.lblNumRods8.Height = 0.125F
			Me.lblNumRods8.HyperLink = Nothing
			Me.lblNumRods8.Left = 3.09F
			Me.lblNumRods8.Name = "lblNumRods8"
			Me.lblNumRods8.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods8.Text = " "
			Me.lblNumRods8.Top = 2.202F
			Me.lblNumRods8.Width = 0.81F
			Me.lblGuideTypeHdrBot.Height = 0.145F
			Me.lblGuideTypeHdrBot.HyperLink = Nothing
			Me.lblGuideTypeHdrBot.Left = 4.139001F
			Me.lblGuideTypeHdrBot.Name = "lblGuideTypeHdrBot"
			Me.lblGuideTypeHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblGuideTypeHdrBot.Text = "Type"
			Me.lblGuideTypeHdrBot.Top = 0.9070001F
			Me.lblGuideTypeHdrBot.Width = 1.56F
			Me.Line14.Height = 0F
			Me.Line14.Left = 4.07F
			Me.Line14.LineWeight = 1F
			Me.Line14.Name = "Line14"
			Me.Line14.Top = 1.0945F
			Me.Line14.Width = 2.66F
			Me.Line14.X1 = 4.07F
			Me.Line14.X2 = 6.73F
			Me.Line14.Y1 = 1.0945F
			Me.Line14.Y2 = 1.0945F
			Me.lblGuideType1.Height = 0.14F
			Me.lblGuideType1.HyperLink = Nothing
			Me.lblGuideType1.Left = 4.139001F
			Me.lblGuideType1.Name = "lblGuideType1"
			Me.lblGuideType1.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType1.Text = " "
			Me.lblGuideType1.Top = 1.167F
			Me.lblGuideType1.Width = 1.56F
			Me.lblGuideType2.Height = 0.14F
			Me.lblGuideType2.HyperLink = Nothing
			Me.lblGuideType2.Left = 4.139001F
			Me.lblGuideType2.Name = "lblGuideType2"
			Me.lblGuideType2.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType2.Text = " "
			Me.lblGuideType2.Top = 1.312F
			Me.lblGuideType2.Width = 1.56F
			Me.lblGuideType3.Height = 0.14F
			Me.lblGuideType3.HyperLink = Nothing
			Me.lblGuideType3.Left = 4.139001F
			Me.lblGuideType3.Name = "lblGuideType3"
			Me.lblGuideType3.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType3.Text = " "
			Me.lblGuideType3.Top = 1.457F
			Me.lblGuideType3.Width = 1.56F
			Me.lblGuideType4.Height = 0.14F
			Me.lblGuideType4.HyperLink = Nothing
			Me.lblGuideType4.Left = 4.139001F
			Me.lblGuideType4.Name = "lblGuideType4"
			Me.lblGuideType4.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType4.Text = " "
			Me.lblGuideType4.Top = 1.602F
			Me.lblGuideType4.Width = 1.56F
			Me.lblGuideType5.Height = 0.14F
			Me.lblGuideType5.HyperLink = Nothing
			Me.lblGuideType5.Left = 4.139001F
			Me.lblGuideType5.Name = "lblGuideType5"
			Me.lblGuideType5.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType5.Text = " "
			Me.lblGuideType5.Top = 1.747F
			Me.lblGuideType5.Width = 1.56F
			Me.lblGuideType6.Height = 0.14F
			Me.lblGuideType6.HyperLink = Nothing
			Me.lblGuideType6.Left = 4.139001F
			Me.lblGuideType6.Name = "lblGuideType6"
			Me.lblGuideType6.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType6.Text = " "
			Me.lblGuideType6.Top = 1.892F
			Me.lblGuideType6.Width = 1.56F
			Me.lblGuideType7.Height = 0.14F
			Me.lblGuideType7.HyperLink = Nothing
			Me.lblGuideType7.Left = 4.139001F
			Me.lblGuideType7.Name = "lblGuideType7"
			Me.lblGuideType7.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType7.Text = " "
			Me.lblGuideType7.Top = 2.037F
			Me.lblGuideType7.Width = 1.56F
			Me.lblGuideType8.Height = 0.14F
			Me.lblGuideType8.HyperLink = Nothing
			Me.lblGuideType8.Left = 4.139001F
			Me.lblGuideType8.Name = "lblGuideType8"
			Me.lblGuideType8.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType8.Text = " "
			Me.lblGuideType8.Top = 2.202F
			Me.lblGuideType8.Width = 1.56F
			Me.lblNumGuidesHdrBot.Height = 0.145F
			Me.lblNumGuidesHdrBot.HyperLink = Nothing
			Me.lblNumGuidesHdrBot.Left = 5.866001F
			Me.lblNumGuidesHdrBot.Name = "lblNumGuidesHdrBot"
			Me.lblNumGuidesHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblNumGuidesHdrBot.Text = "per Rod"
			Me.lblNumGuidesHdrBot.Top = 0.9070001F
			Me.lblNumGuidesHdrBot.Width = 0.8125F
			Me.lblNumGuides1.Height = 0.125F
			Me.lblNumGuides1.HyperLink = Nothing
			Me.lblNumGuides1.Left = 5.866002F
			Me.lblNumGuides1.Name = "lblNumGuides1"
			Me.lblNumGuides1.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides1.Text = " "
			Me.lblNumGuides1.Top = 1.167F
			Me.lblNumGuides1.Width = 0.8125F
			Me.lblNumGuides2.Height = 0.125F
			Me.lblNumGuides2.HyperLink = Nothing
			Me.lblNumGuides2.Left = 5.866002F
			Me.lblNumGuides2.Name = "lblNumGuides2"
			Me.lblNumGuides2.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides2.Text = " "
			Me.lblNumGuides2.Top = 1.312F
			Me.lblNumGuides2.Width = 0.8125F
			Me.lblNumGuides3.Height = 0.125F
			Me.lblNumGuides3.HyperLink = Nothing
			Me.lblNumGuides3.Left = 5.866002F
			Me.lblNumGuides3.Name = "lblNumGuides3"
			Me.lblNumGuides3.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides3.Text = " "
			Me.lblNumGuides3.Top = 1.457F
			Me.lblNumGuides3.Width = 0.8125F
			Me.lblNumGuides4.Height = 0.125F
			Me.lblNumGuides4.HyperLink = Nothing
			Me.lblNumGuides4.Left = 5.866002F
			Me.lblNumGuides4.Name = "lblNumGuides4"
			Me.lblNumGuides4.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides4.Text = " "
			Me.lblNumGuides4.Top = 1.602F
			Me.lblNumGuides4.Width = 0.8125F
			Me.lblNumGuides5.Height = 0.125F
			Me.lblNumGuides5.HyperLink = Nothing
			Me.lblNumGuides5.Left = 5.866002F
			Me.lblNumGuides5.Name = "lblNumGuides5"
			Me.lblNumGuides5.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides5.Text = " "
			Me.lblNumGuides5.Top = 1.747F
			Me.lblNumGuides5.Width = 0.8125F
			Me.lblNumGuides6.Height = 0.125F
			Me.lblNumGuides6.HyperLink = Nothing
			Me.lblNumGuides6.Left = 5.866002F
			Me.lblNumGuides6.Name = "lblNumGuides6"
			Me.lblNumGuides6.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides6.Text = " "
			Me.lblNumGuides6.Top = 1.892F
			Me.lblNumGuides6.Width = 0.8125F
			Me.lblNumGuides7.Height = 0.125F
			Me.lblNumGuides7.HyperLink = Nothing
			Me.lblNumGuides7.Left = 5.866002F
			Me.lblNumGuides7.Name = "lblNumGuides7"
			Me.lblNumGuides7.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides7.Text = " "
			Me.lblNumGuides7.Top = 2.037F
			Me.lblNumGuides7.Width = 0.8125F
			Me.lblNumGuides8.Height = 0.125F
			Me.lblNumGuides8.HyperLink = Nothing
			Me.lblNumGuides8.Left = 5.866002F
			Me.lblNumGuides8.Name = "lblNumGuides8"
			Me.lblNumGuides8.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides8.Text = " "
			Me.lblNumGuides8.Top = 2.202F
			Me.lblNumGuides8.Width = 0.8125F
			Me.lblRodGradeHdrTop.Height = 0.145F
			Me.lblRodGradeHdrTop.HyperLink = Nothing
			Me.lblRodGradeHdrTop.Left = 0.291F
			Me.lblRodGradeHdrTop.Name = "lblRodGradeHdrTop"
			Me.lblRodGradeHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGradeHdrTop.Text = "Rod"
			Me.lblRodGradeHdrTop.Top = 0.7820001F
			Me.lblRodGradeHdrTop.Width = 1.555F
			Me.lblGuideTypeHdrTop.Height = 0.145F
			Me.lblGuideTypeHdrTop.HyperLink = Nothing
			Me.lblGuideTypeHdrTop.Left = 4.139001F
			Me.lblGuideTypeHdrTop.Name = "lblGuideTypeHdrTop"
			Me.lblGuideTypeHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblGuideTypeHdrTop.Text = " Guide"
			Me.lblGuideTypeHdrTop.Top = 0.7820001F
			Me.lblGuideTypeHdrTop.Width = 1.56F
			Me.lblNumGuidesHdrTop.Height = 0.145F
			Me.lblNumGuidesHdrTop.HyperLink = Nothing
			Me.lblNumGuidesHdrTop.Left = 5.866001F
			Me.lblNumGuidesHdrTop.Name = "lblNumGuidesHdrTop"
			Me.lblNumGuidesHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblNumGuidesHdrTop.Text = "Rod Guides "
			Me.lblNumGuidesHdrTop.Top = 0.7820001F
			Me.lblNumGuidesHdrTop.Width = 0.8125F
			Me.lblNumRodsHdrTop.Height = 0.145F
			Me.lblNumRodsHdrTop.HyperLink = Nothing
			Me.lblNumRodsHdrTop.Left = 3.09F
			Me.lblNumRodsHdrTop.Name = "lblNumRodsHdrTop"
			Me.lblNumRodsHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblNumRodsHdrTop.Text = "Number of"
			Me.lblNumRodsHdrTop.Top = 0.7820001F
			Me.lblNumRodsHdrTop.Width = 0.81F
			Me.linSep3.Height = 3.342999F
			Me.linSep3.Left = 5.794009F
			Me.linSep3.LineWeight = 1F
			Me.linSep3.Name = "linSep3"
			Me.linSep3.Top = 0.752F
			Me.linSep3.Width = 0F
			Me.linSep3.X1 = 5.794009F
			Me.linSep3.X2 = 5.794009F
			Me.linSep3.Y1 = 0.752F
			Me.linSep3.Y2 = 4.094999F
			Me.lblRodDiam9.Height = 0.125F
			Me.lblRodDiam9.HyperLink = Nothing
			Me.lblRodDiam9.Left = 1.978F
			Me.lblRodDiam9.Name = "lblRodDiam9"
			Me.lblRodDiam9.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam9.Text = " "
			Me.lblRodDiam9.Top = 2.357F
			Me.lblRodDiam9.Width = 1F
			Me.lblRodGrade9.Height = 0.14F
			Me.lblRodGrade9.HyperLink = Nothing
			Me.lblRodGrade9.Left = 0.291F
			Me.lblRodGrade9.Name = "lblRodGrade9"
			Me.lblRodGrade9.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade9.Text = " "
			Me.lblRodGrade9.Top = 2.357F
			Me.lblRodGrade9.Width = 1.56F
			Me.lblNumRods9.Height = 0.125F
			Me.lblNumRods9.HyperLink = Nothing
			Me.lblNumRods9.Left = 3.09F
			Me.lblNumRods9.Name = "lblNumRods9"
			Me.lblNumRods9.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods9.Text = " "
			Me.lblNumRods9.Top = 2.357F
			Me.lblNumRods9.Width = 0.81F
			Me.lblGuideType9.Height = 0.14F
			Me.lblGuideType9.HyperLink = Nothing
			Me.lblGuideType9.Left = 4.139001F
			Me.lblGuideType9.Name = "lblGuideType9"
			Me.lblGuideType9.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType9.Text = " "
			Me.lblGuideType9.Top = 2.357F
			Me.lblGuideType9.Width = 1.56F
			Me.lblNumGuides9.Height = 0.125F
			Me.lblNumGuides9.HyperLink = Nothing
			Me.lblNumGuides9.Left = 5.866002F
			Me.lblNumGuides9.Name = "lblNumGuides9"
			Me.lblNumGuides9.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides9.Text = " "
			Me.lblNumGuides9.Top = 2.357F
			Me.lblNumGuides9.Width = 0.8125F
			Me.lblRodDiam10.Height = 0.125F
			Me.lblRodDiam10.HyperLink = Nothing
			Me.lblRodDiam10.Left = 1.978F
			Me.lblRodDiam10.Name = "lblRodDiam10"
			Me.lblRodDiam10.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam10.Text = " "
			Me.lblRodDiam10.Top = 2.512001F
			Me.lblRodDiam10.Width = 1F
			Me.lblRodGrade10.Height = 0.14F
			Me.lblRodGrade10.HyperLink = Nothing
			Me.lblRodGrade10.Left = 0.291F
			Me.lblRodGrade10.Name = "lblRodGrade10"
			Me.lblRodGrade10.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade10.Text = " "
			Me.lblRodGrade10.Top = 2.512001F
			Me.lblRodGrade10.Width = 1.56F
			Me.lblNumRods10.Height = 0.125F
			Me.lblNumRods10.HyperLink = Nothing
			Me.lblNumRods10.Left = 3.09F
			Me.lblNumRods10.Name = "lblNumRods10"
			Me.lblNumRods10.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods10.Text = " "
			Me.lblNumRods10.Top = 2.512001F
			Me.lblNumRods10.Width = 0.81F
			Me.lblGuideType10.Height = 0.14F
			Me.lblGuideType10.HyperLink = Nothing
			Me.lblGuideType10.Left = 4.139001F
			Me.lblGuideType10.Name = "lblGuideType10"
			Me.lblGuideType10.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType10.Text = " "
			Me.lblGuideType10.Top = 2.512001F
			Me.lblGuideType10.Width = 1.56F
			Me.lblNumGuides10.Height = 0.125F
			Me.lblNumGuides10.HyperLink = Nothing
			Me.lblNumGuides10.Left = 5.866002F
			Me.lblNumGuides10.Name = "lblNumGuides10"
			Me.lblNumGuides10.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides10.Text = " "
			Me.lblNumGuides10.Top = 2.512001F
			Me.lblNumGuides10.Width = 0.8125F
			Me.linSep2.Height = 3.342999F
			Me.linSep2.Left = 3.038F
			Me.linSep2.LineWeight = 1F
			Me.linSep2.Name = "linSep2"
			Me.linSep2.Top = 0.742F
			Me.linSep2.Width = 0F
			Me.linSep2.X1 = 3.038F
			Me.linSep2.X2 = 3.038F
			Me.linSep2.Y1 = 0.742F
			Me.linSep2.Y2 = 4.084999F
			Me.lblNumRods11.Height = 0.125F
			Me.lblNumRods11.HyperLink = Nothing
			Me.lblNumRods11.Left = 3.086F
			Me.lblNumRods11.Name = "lblNumRods11"
			Me.lblNumRods11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods11.Text = " "
			Me.lblNumRods11.Top = 2.667F
			Me.lblNumRods11.Width = 0.81F
			Me.lblRodGrade11.Height = 0.14F
			Me.lblRodGrade11.HyperLink = Nothing
			Me.lblRodGrade11.Left = 0.291F
			Me.lblRodGrade11.Name = "lblRodGrade11"
			Me.lblRodGrade11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade11.Text = " "
			Me.lblRodGrade11.Top = 2.667F
			Me.lblRodGrade11.Width = 1.56F
			Me.lblRodDiam11.Height = 0.125F
			Me.lblRodDiam11.HyperLink = Nothing
			Me.lblRodDiam11.Left = 1.978F
			Me.lblRodDiam11.Name = "lblRodDiam11"
			Me.lblRodDiam11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam11.Text = " "
			Me.lblRodDiam11.Top = 2.667F
			Me.lblRodDiam11.Width = 1F
			Me.lblRodDiam12.Height = 0.125F
			Me.lblRodDiam12.HyperLink = Nothing
			Me.lblRodDiam12.Left = 1.983F
			Me.lblRodDiam12.Name = "lblRodDiam12"
			Me.lblRodDiam12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam12.Text = " "
			Me.lblRodDiam12.Top = 2.812F
			Me.lblRodDiam12.Width = 1F
			Me.lblRodDiam13.Height = 0.125F
			Me.lblRodDiam13.HyperLink = Nothing
			Me.lblRodDiam13.Left = 1.978F
			Me.lblRodDiam13.Name = "lblRodDiam13"
			Me.lblRodDiam13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam13.Text = " "
			Me.lblRodDiam13.Top = 2.957F
			Me.lblRodDiam13.Width = 1F
			Me.lblRodDiam14.Height = 0.125F
			Me.lblRodDiam14.HyperLink = Nothing
			Me.lblRodDiam14.Left = 1.978F
			Me.lblRodDiam14.Name = "lblRodDiam14"
			Me.lblRodDiam14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam14.Text = " "
			Me.lblRodDiam14.Top = 3.102F
			Me.lblRodDiam14.Width = 1F
			Me.lblRodDiam15.Height = 0.125F
			Me.lblRodDiam15.HyperLink = Nothing
			Me.lblRodDiam15.Left = 1.978F
			Me.lblRodDiam15.Name = "lblRodDiam15"
			Me.lblRodDiam15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam15.Text = " "
			Me.lblRodDiam15.Top = 3.247F
			Me.lblRodDiam15.Width = 1F
			Me.lblRodDiam16.Height = 0.125F
			Me.lblRodDiam16.HyperLink = Nothing
			Me.lblRodDiam16.Left = 1.978F
			Me.lblRodDiam16.Name = "lblRodDiam16"
			Me.lblRodDiam16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam16.Text = " "
			Me.lblRodDiam16.Top = 3.392F
			Me.lblRodDiam16.Width = 1F
			Me.lblRodDiam17.Height = 0.125F
			Me.lblRodDiam17.HyperLink = Nothing
			Me.lblRodDiam17.Left = 1.978F
			Me.lblRodDiam17.Name = "lblRodDiam17"
			Me.lblRodDiam17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam17.Text = " "
			Me.lblRodDiam17.Top = 3.537F
			Me.lblRodDiam17.Width = 1F
			Me.lblRodDiam18.Height = 0.125F
			Me.lblRodDiam18.HyperLink = Nothing
			Me.lblRodDiam18.Left = 1.978F
			Me.lblRodDiam18.Name = "lblRodDiam18"
			Me.lblRodDiam18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam18.Text = " "
			Me.lblRodDiam18.Top = 3.692001F
			Me.lblRodDiam18.Width = 1F
			Me.lblRodGrade12.Height = 0.14F
			Me.lblRodGrade12.HyperLink = Nothing
			Me.lblRodGrade12.Left = 0.296F
			Me.lblRodGrade12.Name = "lblRodGrade12"
			Me.lblRodGrade12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade12.Text = " "
			Me.lblRodGrade12.Top = 2.812F
			Me.lblRodGrade12.Width = 1.56F
			Me.lblRodGrade13.Height = 0.14F
			Me.lblRodGrade13.HyperLink = Nothing
			Me.lblRodGrade13.Left = 0.291F
			Me.lblRodGrade13.Name = "lblRodGrade13"
			Me.lblRodGrade13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade13.Text = " "
			Me.lblRodGrade13.Top = 2.957F
			Me.lblRodGrade13.Width = 1.56F
			Me.lblRodGrade14.Height = 0.14F
			Me.lblRodGrade14.HyperLink = Nothing
			Me.lblRodGrade14.Left = 0.291F
			Me.lblRodGrade14.Name = "lblRodGrade14"
			Me.lblRodGrade14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade14.Text = " "
			Me.lblRodGrade14.Top = 3.102F
			Me.lblRodGrade14.Width = 1.56F
			Me.lblRodGrade15.Height = 0.14F
			Me.lblRodGrade15.HyperLink = Nothing
			Me.lblRodGrade15.Left = 0.291F
			Me.lblRodGrade15.Name = "lblRodGrade15"
			Me.lblRodGrade15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade15.Text = " "
			Me.lblRodGrade15.Top = 3.247F
			Me.lblRodGrade15.Width = 1.56F
			Me.lblRodGrade16.Height = 0.14F
			Me.lblRodGrade16.HyperLink = Nothing
			Me.lblRodGrade16.Left = 0.291F
			Me.lblRodGrade16.Name = "lblRodGrade16"
			Me.lblRodGrade16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade16.Text = " "
			Me.lblRodGrade16.Top = 3.392F
			Me.lblRodGrade16.Width = 1.56F
			Me.lblRodGrade17.Height = 0.14F
			Me.lblRodGrade17.HyperLink = Nothing
			Me.lblRodGrade17.Left = 0.291F
			Me.lblRodGrade17.Name = "lblRodGrade17"
			Me.lblRodGrade17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade17.Text = " "
			Me.lblRodGrade17.Top = 3.537F
			Me.lblRodGrade17.Width = 1.56F
			Me.lblRodGrade18.Height = 0.14F
			Me.lblRodGrade18.HyperLink = Nothing
			Me.lblRodGrade18.Left = 0.291F
			Me.lblRodGrade18.Name = "lblRodGrade18"
			Me.lblRodGrade18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade18.Text = " "
			Me.lblRodGrade18.Top = 3.692001F
			Me.lblRodGrade18.Width = 1.56F
			Me.lblNumRods12.Height = 0.125F
			Me.lblNumRods12.HyperLink = Nothing
			Me.lblNumRods12.Left = 3.086F
			Me.lblNumRods12.Name = "lblNumRods12"
			Me.lblNumRods12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods12.Text = " "
			Me.lblNumRods12.Top = 2.812F
			Me.lblNumRods12.Width = 0.81F
			Me.lblNumRods13.Height = 0.125F
			Me.lblNumRods13.HyperLink = Nothing
			Me.lblNumRods13.Left = 3.086F
			Me.lblNumRods13.Name = "lblNumRods13"
			Me.lblNumRods13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods13.Text = " "
			Me.lblNumRods13.Top = 2.957F
			Me.lblNumRods13.Width = 0.81F
			Me.lblNumRods14.Height = 0.125F
			Me.lblNumRods14.HyperLink = Nothing
			Me.lblNumRods14.Left = 3.086F
			Me.lblNumRods14.Name = "lblNumRods14"
			Me.lblNumRods14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods14.Text = " "
			Me.lblNumRods14.Top = 3.102F
			Me.lblNumRods14.Width = 0.81F
			Me.lblNumRods15.Height = 0.125F
			Me.lblNumRods15.HyperLink = Nothing
			Me.lblNumRods15.Left = 3.086F
			Me.lblNumRods15.Name = "lblNumRods15"
			Me.lblNumRods15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods15.Text = " "
			Me.lblNumRods15.Top = 3.247F
			Me.lblNumRods15.Width = 0.81F
			Me.lblNumRods16.Height = 0.125F
			Me.lblNumRods16.HyperLink = Nothing
			Me.lblNumRods16.Left = 3.0855F
			Me.lblNumRods16.Name = "lblNumRods16"
			Me.lblNumRods16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods16.Text = " "
			Me.lblNumRods16.Top = 3.392F
			Me.lblNumRods16.Width = 0.81F
			Me.lblNumRods17.Height = 0.125F
			Me.lblNumRods17.HyperLink = Nothing
			Me.lblNumRods17.Left = 3.086F
			Me.lblNumRods17.Name = "lblNumRods17"
			Me.lblNumRods17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods17.Text = " "
			Me.lblNumRods17.Top = 3.537F
			Me.lblNumRods17.Width = 0.81F
			Me.lblNumRods18.Height = 0.125F
			Me.lblNumRods18.HyperLink = Nothing
			Me.lblNumRods18.Left = 3.086F
			Me.lblNumRods18.Name = "lblNumRods18"
			Me.lblNumRods18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods18.Text = " "
			Me.lblNumRods18.Top = 3.692001F
			Me.lblNumRods18.Width = 0.81F
			Me.lblGuideType11.Height = 0.14F
			Me.lblGuideType11.HyperLink = Nothing
			Me.lblGuideType11.Left = 4.135001F
			Me.lblGuideType11.Name = "lblGuideType11"
			Me.lblGuideType11.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType11.Text = " "
			Me.lblGuideType11.Top = 2.667F
			Me.lblGuideType11.Width = 1.56F
			Me.lblGuideType12.Height = 0.14F
			Me.lblGuideType12.HyperLink = Nothing
			Me.lblGuideType12.Left = 4.135001F
			Me.lblGuideType12.Name = "lblGuideType12"
			Me.lblGuideType12.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType12.Text = " "
			Me.lblGuideType12.Top = 2.812F
			Me.lblGuideType12.Width = 1.56F
			Me.lblGuideType13.Height = 0.14F
			Me.lblGuideType13.HyperLink = Nothing
			Me.lblGuideType13.Left = 4.135001F
			Me.lblGuideType13.Name = "lblGuideType13"
			Me.lblGuideType13.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType13.Text = " "
			Me.lblGuideType13.Top = 2.957F
			Me.lblGuideType13.Width = 1.56F
			Me.lblGuideType14.Height = 0.14F
			Me.lblGuideType14.HyperLink = Nothing
			Me.lblGuideType14.Left = 4.135001F
			Me.lblGuideType14.Name = "lblGuideType14"
			Me.lblGuideType14.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType14.Text = " "
			Me.lblGuideType14.Top = 3.102F
			Me.lblGuideType14.Width = 1.56F
			Me.lblGuideType15.Height = 0.14F
			Me.lblGuideType15.HyperLink = Nothing
			Me.lblGuideType15.Left = 4.135001F
			Me.lblGuideType15.Name = "lblGuideType15"
			Me.lblGuideType15.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType15.Text = " "
			Me.lblGuideType15.Top = 3.247F
			Me.lblGuideType15.Width = 1.56F
			Me.lblGuideType16.Height = 0.14F
			Me.lblGuideType16.HyperLink = Nothing
			Me.lblGuideType16.Left = 4.135001F
			Me.lblGuideType16.Name = "lblGuideType16"
			Me.lblGuideType16.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType16.Text = " "
			Me.lblGuideType16.Top = 3.392F
			Me.lblGuideType16.Width = 1.56F
			Me.lblGuideType17.Height = 0.14F
			Me.lblGuideType17.HyperLink = Nothing
			Me.lblGuideType17.Left = 4.135001F
			Me.lblGuideType17.Name = "lblGuideType17"
			Me.lblGuideType17.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType17.Text = " "
			Me.lblGuideType17.Top = 3.537F
			Me.lblGuideType17.Width = 1.56F
			Me.lblGuideType18.Height = 0.14F
			Me.lblGuideType18.HyperLink = Nothing
			Me.lblGuideType18.Left = 4.135001F
			Me.lblGuideType18.Name = "lblGuideType18"
			Me.lblGuideType18.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType18.Text = " "
			Me.lblGuideType18.Top = 3.692001F
			Me.lblGuideType18.Width = 1.56F
			Me.lblNumGuides11.Height = 0.125F
			Me.lblNumGuides11.HyperLink = Nothing
			Me.lblNumGuides11.Left = 5.862502F
			Me.lblNumGuides11.Name = "lblNumGuides11"
			Me.lblNumGuides11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides11.Text = " "
			Me.lblNumGuides11.Top = 2.667F
			Me.lblNumGuides11.Width = 0.8125F
			Me.lblNumGuides12.Height = 0.125F
			Me.lblNumGuides12.HyperLink = Nothing
			Me.lblNumGuides12.Left = 5.862002F
			Me.lblNumGuides12.Name = "lblNumGuides12"
			Me.lblNumGuides12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides12.Text = " "
			Me.lblNumGuides12.Top = 2.812F
			Me.lblNumGuides12.Width = 0.8125F
			Me.lblNumGuides13.Height = 0.125F
			Me.lblNumGuides13.HyperLink = Nothing
			Me.lblNumGuides13.Left = 5.863F
			Me.lblNumGuides13.Name = "lblNumGuides13"
			Me.lblNumGuides13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides13.Text = " "
			Me.lblNumGuides13.Top = 2.957F
			Me.lblNumGuides13.Width = 0.8125F
			Me.lblNumGuides14.Height = 0.125F
			Me.lblNumGuides14.HyperLink = Nothing
			Me.lblNumGuides14.Left = 5.863F
			Me.lblNumGuides14.Name = "lblNumGuides14"
			Me.lblNumGuides14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides14.Text = " "
			Me.lblNumGuides14.Top = 3.102F
			Me.lblNumGuides14.Width = 0.8125F
			Me.lblNumGuides15.Height = 0.125F
			Me.lblNumGuides15.HyperLink = Nothing
			Me.lblNumGuides15.Left = 5.863F
			Me.lblNumGuides15.Name = "lblNumGuides15"
			Me.lblNumGuides15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides15.Text = " "
			Me.lblNumGuides15.Top = 3.247F
			Me.lblNumGuides15.Width = 0.8125F
			Me.lblNumGuides16.Height = 0.125F
			Me.lblNumGuides16.HyperLink = Nothing
			Me.lblNumGuides16.Left = 5.863F
			Me.lblNumGuides16.Name = "lblNumGuides16"
			Me.lblNumGuides16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides16.Text = " "
			Me.lblNumGuides16.Top = 3.392F
			Me.lblNumGuides16.Width = 0.8125F
			Me.lblNumGuides17.Height = 0.125F
			Me.lblNumGuides17.HyperLink = Nothing
			Me.lblNumGuides17.Left = 5.864001F
			Me.lblNumGuides17.Name = "lblNumGuides17"
			Me.lblNumGuides17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides17.Text = " "
			Me.lblNumGuides17.Top = 3.537F
			Me.lblNumGuides17.Width = 0.8125F
			Me.lblNumGuides18.Height = 0.125F
			Me.lblNumGuides18.HyperLink = Nothing
			Me.lblNumGuides18.Left = 5.866002F
			Me.lblNumGuides18.Name = "lblNumGuides18"
			Me.lblNumGuides18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides18.Text = " "
			Me.lblNumGuides18.Top = 3.692F
			Me.lblNumGuides18.Width = 0.8125F
			Me.lblRodDiam19.Height = 0.125F
			Me.lblRodDiam19.HyperLink = Nothing
			Me.lblRodDiam19.Left = 1.978F
			Me.lblRodDiam19.Name = "lblRodDiam19"
			Me.lblRodDiam19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam19.Text = " "
			Me.lblRodDiam19.Top = 3.837001F
			Me.lblRodDiam19.Width = 1F
			Me.lblRodGrade19.Height = 0.14F
			Me.lblRodGrade19.HyperLink = Nothing
			Me.lblRodGrade19.Left = 0.291F
			Me.lblRodGrade19.Name = "lblRodGrade19"
			Me.lblRodGrade19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade19.Text = " "
			Me.lblRodGrade19.Top = 3.837001F
			Me.lblRodGrade19.Width = 1.56F
			Me.lblNumRods19.Height = 0.125F
			Me.lblNumRods19.HyperLink = Nothing
			Me.lblNumRods19.Left = 3.086F
			Me.lblNumRods19.Name = "lblNumRods19"
			Me.lblNumRods19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods19.Text = " "
			Me.lblNumRods19.Top = 3.837001F
			Me.lblNumRods19.Width = 0.81F
			Me.lblGuideType19.Height = 0.14F
			Me.lblGuideType19.HyperLink = Nothing
			Me.lblGuideType19.Left = 4.135001F
			Me.lblGuideType19.Name = "lblGuideType19"
			Me.lblGuideType19.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType19.Text = " "
			Me.lblGuideType19.Top = 3.837001F
			Me.lblGuideType19.Width = 1.56F
			Me.lblNumGuides19.Height = 0.125F
			Me.lblNumGuides19.HyperLink = Nothing
			Me.lblNumGuides19.Left = 5.863501F
			Me.lblNumGuides19.Name = "lblNumGuides19"
			Me.lblNumGuides19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides19.Text = " "
			Me.lblNumGuides19.Top = 3.837001F
			Me.lblNumGuides19.Width = 0.8125F
			Me.lblRodDiam20.Height = 0.125F
			Me.lblRodDiam20.HyperLink = Nothing
			Me.lblRodDiam20.Left = 1.978F
			Me.lblRodDiam20.Name = "lblRodDiam20"
			Me.lblRodDiam20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiam20.Text = " "
			Me.lblRodDiam20.Top = 3.982001F
			Me.lblRodDiam20.Width = 1F
			Me.lblRodGrade20.Height = 0.14F
			Me.lblRodGrade20.HyperLink = Nothing
			Me.lblRodGrade20.Left = 0.291F
			Me.lblRodGrade20.Name = "lblRodGrade20"
			Me.lblRodGrade20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade20.Text = " "
			Me.lblRodGrade20.Top = 3.982001F
			Me.lblRodGrade20.Width = 1.56F
			Me.lblNumRods20.Height = 0.125F
			Me.lblNumRods20.HyperLink = Nothing
			Me.lblNumRods20.Left = 3.086F
			Me.lblNumRods20.Name = "lblNumRods20"
			Me.lblNumRods20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods20.Text = " "
			Me.lblNumRods20.Top = 3.982001F
			Me.lblNumRods20.Width = 0.81F
			Me.lblGuideType20.Height = 0.14F
			Me.lblGuideType20.HyperLink = Nothing
			Me.lblGuideType20.Left = 4.135001F
			Me.lblGuideType20.Name = "lblGuideType20"
			Me.lblGuideType20.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblGuideType20.Text = " "
			Me.lblGuideType20.Top = 3.982001F
			Me.lblGuideType20.Width = 1.56F
			Me.lblNumGuides20.Height = 0.125F
			Me.lblNumGuides20.HyperLink = Nothing
			Me.lblNumGuides20.Left = 5.863501F
			Me.lblNumGuides20.Name = "lblNumGuides20"
			Me.lblNumGuides20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides20.Text = " "
			Me.lblNumGuides20.Top = 3.982001F
			Me.lblNumGuides20.Width = 0.8125F
			Me.lblTotalLengthLabel.Height = 0.145F
			Me.lblTotalLengthLabel.HyperLink = Nothing
			Me.lblTotalLengthLabel.Left = 1.836F
			Me.lblTotalLengthLabel.Name = "lblTotalLengthLabel"
			Me.lblTotalLengthLabel.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblTotalLengthLabel.Text = "Total Length (ft):"
			Me.lblTotalLengthLabel.Top = 4.24F
			Me.lblTotalLengthLabel.Width = 0.9020001F
			Me.lblTotalLength.Height = 0.145F
			Me.lblTotalLength.HyperLink = Nothing
			Me.lblTotalLength.Left = 2.829F
			Me.lblTotalLength.Name = "lblTotalLength"
			Me.lblTotalLength.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblTotalLength.Text = " "
			Me.lblTotalLength.Top = 4.24F
			Me.lblTotalLength.Width = 0.7409999F
			Me.lblPumpDepthLabel.Height = 0.145F
			Me.lblPumpDepthLabel.HyperLink = Nothing
			Me.lblPumpDepthLabel.Left = 0.201F
			Me.lblPumpDepthLabel.Name = "lblPumpDepthLabel"
			Me.lblPumpDepthLabel.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPumpDepthLabel.Text = "Pump Depth (ft): "
			Me.lblPumpDepthLabel.Top = 4.24F
			Me.lblPumpDepthLabel.Width = 0.9190001F
			Me.lblReportTitle.Height = 0.195F
			Me.lblReportTitle.HyperLink = Nothing
			Me.lblReportTitle.Left = 0F
			Me.lblReportTitle.Name = "lblReportTitle"
			Me.lblReportTitle.Style = "background-color: LightGrey; font-size: 12pt; font-weight: normal; text-align: center"
			Me.lblReportTitle.Text = "Rod String Order Summary"
			Me.lblReportTitle.Top = 0F
			Me.lblReportTitle.Width = 7.875F
			Me.lblPumpDepth.Height = 0.145F
			Me.lblPumpDepth.HyperLink = Nothing
			Me.lblPumpDepth.Left = 1.245F
			Me.lblPumpDepth.Name = "lblPumpDepth"
			Me.lblPumpDepth.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPumpDepth.Text = " "
			Me.lblPumpDepth.Top = 4.24F
			Me.lblPumpDepth.Width = 0.571F
			Me.PageFooter1.Height = 0.25F
			Me.PageFooter1.Name = "PageFooter1"
			Me.MasterReport = False
			Me.PageSettings.Margins.Bottom = 0F
			Me.PageSettings.Margins.Left = 0.5F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0.25F
			Me.PageSettings.PaperHeight = 11F
			Me.PageSettings.PaperWidth = 8.5F
			Me.PrintWidth = 7.895833F
			Me.Sections.Add(Me.PageHeader1)
			Me.Sections.Add(Me.Detail1)
			Me.Sections.Add(Me.PageFooter1)
			Me.StyleSheet.Add(New StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
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
			CType(Me.lblNumRods1, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade1, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam1, ISupportInitialize).EndInit()
			CType(Me.lblRodDiamHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodDiamHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodGradeHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblNumRodsHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam2, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam3, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam4, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam5, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam6, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam7, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam8, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade2, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade3, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade4, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade5, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade6, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade7, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade8, ISupportInitialize).EndInit()
			CType(Me.lblNumRods2, ISupportInitialize).EndInit()
			CType(Me.lblNumRods3, ISupportInitialize).EndInit()
			CType(Me.lblNumRods4, ISupportInitialize).EndInit()
			CType(Me.lblNumRods5, ISupportInitialize).EndInit()
			CType(Me.lblNumRods6, ISupportInitialize).EndInit()
			CType(Me.lblNumRods7, ISupportInitialize).EndInit()
			CType(Me.lblNumRods8, ISupportInitialize).EndInit()
			CType(Me.lblGuideTypeHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblGuideType1, ISupportInitialize).EndInit()
			CType(Me.lblGuideType2, ISupportInitialize).EndInit()
			CType(Me.lblGuideType3, ISupportInitialize).EndInit()
			CType(Me.lblGuideType4, ISupportInitialize).EndInit()
			CType(Me.lblGuideType5, ISupportInitialize).EndInit()
			CType(Me.lblGuideType6, ISupportInitialize).EndInit()
			CType(Me.lblGuideType7, ISupportInitialize).EndInit()
			CType(Me.lblGuideType8, ISupportInitialize).EndInit()
			CType(Me.lblNumGuidesHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides1, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides2, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides3, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides4, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides5, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides6, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides7, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides8, ISupportInitialize).EndInit()
			CType(Me.lblRodGradeHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblGuideTypeHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblNumGuidesHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblNumRodsHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam9, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade9, ISupportInitialize).EndInit()
			CType(Me.lblNumRods9, ISupportInitialize).EndInit()
			CType(Me.lblGuideType9, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides9, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam10, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade10, ISupportInitialize).EndInit()
			CType(Me.lblNumRods10, ISupportInitialize).EndInit()
			CType(Me.lblGuideType10, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides10, ISupportInitialize).EndInit()
			CType(Me.lblNumRods11, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade11, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam11, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam12, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam13, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam14, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam15, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam16, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam17, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam18, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade12, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade13, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade14, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade15, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade16, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade17, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade18, ISupportInitialize).EndInit()
			CType(Me.lblNumRods12, ISupportInitialize).EndInit()
			CType(Me.lblNumRods13, ISupportInitialize).EndInit()
			CType(Me.lblNumRods14, ISupportInitialize).EndInit()
			CType(Me.lblNumRods15, ISupportInitialize).EndInit()
			CType(Me.lblNumRods16, ISupportInitialize).EndInit()
			CType(Me.lblNumRods17, ISupportInitialize).EndInit()
			CType(Me.lblNumRods18, ISupportInitialize).EndInit()
			CType(Me.lblGuideType11, ISupportInitialize).EndInit()
			CType(Me.lblGuideType12, ISupportInitialize).EndInit()
			CType(Me.lblGuideType13, ISupportInitialize).EndInit()
			CType(Me.lblGuideType14, ISupportInitialize).EndInit()
			CType(Me.lblGuideType15, ISupportInitialize).EndInit()
			CType(Me.lblGuideType16, ISupportInitialize).EndInit()
			CType(Me.lblGuideType17, ISupportInitialize).EndInit()
			CType(Me.lblGuideType18, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides11, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides12, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides13, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides14, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides15, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides16, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides17, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides18, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam19, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade19, ISupportInitialize).EndInit()
			CType(Me.lblNumRods19, ISupportInitialize).EndInit()
			CType(Me.lblGuideType19, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides19, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam20, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade20, ISupportInitialize).EndInit()
			CType(Me.lblNumRods20, ISupportInitialize).EndInit()
			CType(Me.lblGuideType20, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides20, ISupportInitialize).EndInit()
			CType(Me.lblTotalLengthLabel, ISupportInitialize).EndInit()
			CType(Me.lblTotalLength, ISupportInitialize).EndInit()
			CType(Me.lblPumpDepthLabel, ISupportInitialize).EndInit()
			CType(Me.lblReportTitle, ISupportInitialize).EndInit()
			CType(Me.lblPumpDepth, ISupportInitialize).EndInit()
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		Private Overridable Property lblNumRods1 As Label
			Get
				Return Me._lblNumRods1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods1 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade1 As Label
			Get
				Return Me._lblRodGrade1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade1 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam1 As Label
			Get
				Return Me._lblRodDiam1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam1 = value
			End Set
		End Property

		Private Overridable Property linSep1 As Line
			Get
				Return Me._linSep1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._linSep1 = value
			End Set
		End Property

		Private Overridable Property lblRodDiamHdrTop As Label
			Get
				Return Me._lblRodDiamHdrTop
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiamHdrTop = value
			End Set
		End Property

		Private Overridable Property lblRodDiamHdrBot As Label
			Get
				Return Me._lblRodDiamHdrBot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiamHdrBot = value
			End Set
		End Property

		Private Overridable Property lblRodGradeHdrBot As Label
			Get
				Return Me._lblRodGradeHdrBot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGradeHdrBot = value
			End Set
		End Property

		Private Overridable Property lblNumRodsHdrBot As Label
			Get
				Return Me._lblNumRodsHdrBot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRodsHdrBot = value
			End Set
		End Property

		Private Overridable Property Line12 As Line
			Get
				Return Me._Line12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line12 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam2 As Label
			Get
				Return Me._lblRodDiam2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam2 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam3 As Label
			Get
				Return Me._lblRodDiam3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam3 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam4 As Label
			Get
				Return Me._lblRodDiam4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam4 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam5 As Label
			Get
				Return Me._lblRodDiam5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam5 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam6 As Label
			Get
				Return Me._lblRodDiam6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam6 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam7 As Label
			Get
				Return Me._lblRodDiam7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam7 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam8 As Label
			Get
				Return Me._lblRodDiam8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam8 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade2 As Label
			Get
				Return Me._lblRodGrade2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade2 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade3 As Label
			Get
				Return Me._lblRodGrade3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade3 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade4 As Label
			Get
				Return Me._lblRodGrade4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade4 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade5 As Label
			Get
				Return Me._lblRodGrade5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade5 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade6 As Label
			Get
				Return Me._lblRodGrade6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade6 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade7 As Label
			Get
				Return Me._lblRodGrade7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade7 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade8 As Label
			Get
				Return Me._lblRodGrade8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade8 = value
			End Set
		End Property

		Private Overridable Property lblNumRods2 As Label
			Get
				Return Me._lblNumRods2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods2 = value
			End Set
		End Property

		Private Overridable Property lblNumRods3 As Label
			Get
				Return Me._lblNumRods3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods3 = value
			End Set
		End Property

		Private Overridable Property lblNumRods4 As Label
			Get
				Return Me._lblNumRods4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods4 = value
			End Set
		End Property

		Private Overridable Property lblNumRods5 As Label
			Get
				Return Me._lblNumRods5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods5 = value
			End Set
		End Property

		Private Overridable Property lblNumRods6 As Label
			Get
				Return Me._lblNumRods6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods6 = value
			End Set
		End Property

		Private Overridable Property lblNumRods7 As Label
			Get
				Return Me._lblNumRods7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods7 = value
			End Set
		End Property

		Private Overridable Property lblNumRods8 As Label
			Get
				Return Me._lblNumRods8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods8 = value
			End Set
		End Property

		Private Overridable Property lblGuideTypeHdrBot As Label
			Get
				Return Me._lblGuideTypeHdrBot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideTypeHdrBot = value
			End Set
		End Property

		Private Overridable Property Line14 As Line
			Get
				Return Me._Line14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line14 = value
			End Set
		End Property

		Private Overridable Property lblGuideType1 As Label
			Get
				Return Me._lblGuideType1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType1 = value
			End Set
		End Property

		Private Overridable Property lblGuideType2 As Label
			Get
				Return Me._lblGuideType2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType2 = value
			End Set
		End Property

		Private Overridable Property lblGuideType3 As Label
			Get
				Return Me._lblGuideType3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType3 = value
			End Set
		End Property

		Private Overridable Property lblGuideType4 As Label
			Get
				Return Me._lblGuideType4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType4 = value
			End Set
		End Property

		Private Overridable Property lblGuideType5 As Label
			Get
				Return Me._lblGuideType5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType5 = value
			End Set
		End Property

		Private Overridable Property lblGuideType6 As Label
			Get
				Return Me._lblGuideType6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType6 = value
			End Set
		End Property

		Private Overridable Property lblGuideType7 As Label
			Get
				Return Me._lblGuideType7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType7 = value
			End Set
		End Property

		Private Overridable Property lblGuideType8 As Label
			Get
				Return Me._lblGuideType8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType8 = value
			End Set
		End Property

		Private Overridable Property lblNumGuidesHdrBot As Label
			Get
				Return Me._lblNumGuidesHdrBot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuidesHdrBot = value
			End Set
		End Property

		Private Overridable Property lblNumGuides1 As Label
			Get
				Return Me._lblNumGuides1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides1 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides2 As Label
			Get
				Return Me._lblNumGuides2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides2 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides3 As Label
			Get
				Return Me._lblNumGuides3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides3 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides4 As Label
			Get
				Return Me._lblNumGuides4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides4 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides5 As Label
			Get
				Return Me._lblNumGuides5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides5 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides6 As Label
			Get
				Return Me._lblNumGuides6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides6 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides7 As Label
			Get
				Return Me._lblNumGuides7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides7 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides8 As Label
			Get
				Return Me._lblNumGuides8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides8 = value
			End Set
		End Property

		Private Overridable Property lblRodGradeHdrTop As Label
			Get
				Return Me._lblRodGradeHdrTop
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGradeHdrTop = value
			End Set
		End Property

		Private Overridable Property lblGuideTypeHdrTop As Label
			Get
				Return Me._lblGuideTypeHdrTop
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideTypeHdrTop = value
			End Set
		End Property

		Private Overridable Property lblNumGuidesHdrTop As Label
			Get
				Return Me._lblNumGuidesHdrTop
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuidesHdrTop = value
			End Set
		End Property

		Private Overridable Property lblNumRodsHdrTop As Label
			Get
				Return Me._lblNumRodsHdrTop
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRodsHdrTop = value
			End Set
		End Property

		Private Overridable Property linSep3 As Line
			Get
				Return Me._linSep3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._linSep3 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam9 As Label
			Get
				Return Me._lblRodDiam9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam9 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade9 As Label
			Get
				Return Me._lblRodGrade9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade9 = value
			End Set
		End Property

		Private Overridable Property lblNumRods9 As Label
			Get
				Return Me._lblNumRods9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods9 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides9 As Label
			Get
				Return Me._lblNumGuides9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides9 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam10 As Label
			Get
				Return Me._lblRodDiam10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam10 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade10 As Label
			Get
				Return Me._lblRodGrade10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade10 = value
			End Set
		End Property

		Private Overridable Property lblNumRods10 As Label
			Get
				Return Me._lblNumRods10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods10 = value
			End Set
		End Property

		Private Overridable Property lblGuideType10 As Label
			Get
				Return Me._lblGuideType10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType10 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides10 As Label
			Get
				Return Me._lblNumGuides10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides10 = value
			End Set
		End Property

		Private Overridable Property linSep2 As Line
			Get
				Return Me._linSep2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._linSep2 = value
			End Set
		End Property

		Private Overridable Property lblNumRods11 As Label
			Get
				Return Me._lblNumRods11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods11 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade11 As Label
			Get
				Return Me._lblRodGrade11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade11 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam11 As Label
			Get
				Return Me._lblRodDiam11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam11 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam12 As Label
			Get
				Return Me._lblRodDiam12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam12 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam13 As Label
			Get
				Return Me._lblRodDiam13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam13 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam14 As Label
			Get
				Return Me._lblRodDiam14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam14 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam15 As Label
			Get
				Return Me._lblRodDiam15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam15 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam16 As Label
			Get
				Return Me._lblRodDiam16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam16 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam17 As Label
			Get
				Return Me._lblRodDiam17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam17 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam18 As Label
			Get
				Return Me._lblRodDiam18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam18 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade12 As Label
			Get
				Return Me._lblRodGrade12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade12 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade13 As Label
			Get
				Return Me._lblRodGrade13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade13 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade14 As Label
			Get
				Return Me._lblRodGrade14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade14 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade15 As Label
			Get
				Return Me._lblRodGrade15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade15 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade16 As Label
			Get
				Return Me._lblRodGrade16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade16 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade17 As Label
			Get
				Return Me._lblRodGrade17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade17 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade18 As Label
			Get
				Return Me._lblRodGrade18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade18 = value
			End Set
		End Property

		Private Overridable Property lblNumRods12 As Label
			Get
				Return Me._lblNumRods12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods12 = value
			End Set
		End Property

		Private Overridable Property lblNumRods13 As Label
			Get
				Return Me._lblNumRods13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods13 = value
			End Set
		End Property

		Private Overridable Property lblNumRods14 As Label
			Get
				Return Me._lblNumRods14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods14 = value
			End Set
		End Property

		Private Overridable Property lblNumRods15 As Label
			Get
				Return Me._lblNumRods15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods15 = value
			End Set
		End Property

		Private Overridable Property lblNumRods16 As Label
			Get
				Return Me._lblNumRods16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods16 = value
			End Set
		End Property

		Private Overridable Property lblNumRods17 As Label
			Get
				Return Me._lblNumRods17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods17 = value
			End Set
		End Property

		Private Overridable Property lblNumRods18 As Label
			Get
				Return Me._lblNumRods18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods18 = value
			End Set
		End Property

		Private Overridable Property lblGuideType11 As Label
			Get
				Return Me._lblGuideType11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType11 = value
			End Set
		End Property

		Private Overridable Property lblGuideType12 As Label
			Get
				Return Me._lblGuideType12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType12 = value
			End Set
		End Property

		Private Overridable Property lblGuideType13 As Label
			Get
				Return Me._lblGuideType13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType13 = value
			End Set
		End Property

		Private Overridable Property lblGuideType14 As Label
			Get
				Return Me._lblGuideType14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType14 = value
			End Set
		End Property

		Private Overridable Property lblGuideType15 As Label
			Get
				Return Me._lblGuideType15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType15 = value
			End Set
		End Property

		Private Overridable Property lblGuideType16 As Label
			Get
				Return Me._lblGuideType16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType16 = value
			End Set
		End Property

		Private Overridable Property lblGuideType17 As Label
			Get
				Return Me._lblGuideType17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType17 = value
			End Set
		End Property

		Private Overridable Property lblGuideType18 As Label
			Get
				Return Me._lblGuideType18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType18 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides11 As Label
			Get
				Return Me._lblNumGuides11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides11 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides12 As Label
			Get
				Return Me._lblNumGuides12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides12 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides13 As Label
			Get
				Return Me._lblNumGuides13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides13 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides14 As Label
			Get
				Return Me._lblNumGuides14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides14 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides15 As Label
			Get
				Return Me._lblNumGuides15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides15 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides16 As Label
			Get
				Return Me._lblNumGuides16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides16 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides17 As Label
			Get
				Return Me._lblNumGuides17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides17 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides18 As Label
			Get
				Return Me._lblNumGuides18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides18 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam19 As Label
			Get
				Return Me._lblRodDiam19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam19 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade19 As Label
			Get
				Return Me._lblRodGrade19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade19 = value
			End Set
		End Property

		Private Overridable Property lblNumRods19 As Label
			Get
				Return Me._lblNumRods19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods19 = value
			End Set
		End Property

		Private Overridable Property lblGuideType19 As Label
			Get
				Return Me._lblGuideType19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType19 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides19 As Label
			Get
				Return Me._lblNumGuides19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides19 = value
			End Set
		End Property

		Private Overridable Property lblRodDiam20 As Label
			Get
				Return Me._lblRodDiam20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodDiam20 = value
			End Set
		End Property

		Private Overridable Property lblRodGrade20 As Label
			Get
				Return Me._lblRodGrade20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade20 = value
			End Set
		End Property

		Private Overridable Property lblNumRods20 As Label
			Get
				Return Me._lblNumRods20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods20 = value
			End Set
		End Property

		Private Overridable Property lblGuideType20 As Label
			Get
				Return Me._lblGuideType20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType20 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides20 As Label
			Get
				Return Me._lblNumGuides20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides20 = value
			End Set
		End Property

		Private Overridable Property rod_box As Shape
			Get
				Return Me._rod_box
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Shape)
				Me._rod_box = value
			End Set
		End Property

		Private Overridable Property guide_box As Shape
			Get
				Return Me._guide_box
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Shape)
				Me._guide_box = value
			End Set
		End Property

		Private Overridable Property lblGuideType9 As Label
			Get
				Return Me._lblGuideType9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideType9 = value
			End Set
		End Property

		Private Overridable Property lblTotalLengthLabel As Label
			Get
				Return Me._lblTotalLengthLabel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalLengthLabel = value
			End Set
		End Property

		Private Overridable Property lblTotalLength As Label
			Get
				Return Me._lblTotalLength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalLength = value
			End Set
		End Property

		Private Overridable Property lblPumpDepthLabel As Label
			Get
				Return Me._lblPumpDepthLabel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPumpDepthLabel = value
			End Set
		End Property

		Private Overridable Property lblComment As Label
			Get
				Return Me._lblComment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblComment = value
			End Set
		End Property

		Private Overridable Property lblTitle1 As Label
			Get
				Return Me._lblTitle1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTitle1 = value
			End Set
		End Property

		Private Overridable Property lblPage As Label
			Get
				Return Me._lblPage
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPage = value
			End Set
		End Property

		Private Overridable Property txtPage1 As TextBox
			Get
				Return Me._txtPage1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtPage1 = value
			End Set
		End Property

		Private Overridable Property lblOf As Label
			Get
				Return Me._lblOf
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblOf = value
			End Set
		End Property

		Private Overridable Property txtPage2 As TextBox
			Get
				Return Me._txtPage2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtPage2 = value
			End Set
		End Property

		Private Overridable Property lblUserName As Label
			Get
				Return Me._lblUserName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblUserName = value
			End Set
		End Property

		Private Overridable Property lblUserDate As Label
			Get
				Return Me._lblUserDate
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblUserDate = value
			End Set
		End Property

		Private Overridable Property lblLabel2 As Label
			Get
				Return Me._lblLabel2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblLabel2 = value
			End Set
		End Property

		Private Overridable Property lblCompany As Label
			Get
				Return Me._lblCompany
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCompany = value
			End Set
		End Property

		Private Overridable Property lblWellName As Label
			Get
				Return Me._lblWellName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblWellName = value
			End Set
		End Property

		Private Overridable Property lblDiskFile As Label
			Get
				Return Me._lblDiskFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDiskFile = value
			End Set
		End Property

		Private Overridable Property lblSecondCompanyName As Label
			Get
				Return Me._lblSecondCompanyName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSecondCompanyName = value
			End Set
		End Property

		Private Overridable Property lblSecondCompanyPhonenumber As Label
			Get
				Return Me._lblSecondCompanyPhonenumber
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSecondCompanyPhonenumber = value
			End Set
		End Property

		Private Overridable Property lblGoTheta As Label
			Get
				Return Me._lblGoTheta
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGoTheta = value
			End Set
		End Property

		Private Overridable Property lblReportTitle As Label
			Get
				Return Me._lblReportTitle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblReportTitle = value
			End Set
		End Property

		Private Overridable Property lblPumpDepth As Label
			Get
				Return Me._lblPumpDepth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPumpDepth = value
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
			Dim array As Boolean() = New Boolean(20) {}
			Me.NewSections = New RSWIN_DESC.RodSection(20) {}
			Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
			Dim i As Integer = 1
			Dim num4 As Single
			Dim num9 As Single
			Do
				array(i) = False
				i += 1
			Loop While i <= 20
			Me.iNumRods = 0
			Dim num As Integer = 1
			Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
			i = num
			While i <= numRods
				If Not array(i) Then
					Me.iNumRods += 1
					Me.NewSections(Me.iNumRods).Initialize()
					Me.NewSections(Me.iNumRods) = RSWIN_DESC.rst.Sections(i)
					Dim num2 As Integer = i + 1
					Dim num3 As Integer = num2
					Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For j As Integer = num3 To numRods2

							If RSWIN_DESC.bRodStarD Then
								If Me.NewSections(Me.iNumRods).Grade = RSWIN_DESC.rst.Sections(j).Grade And Me.NewSections(Me.iNumRods).Diameter = RSWIN_DESC.rst.Sections(j).Diameter And Me.NewSections(Me.iNumRods).Guide = RSWIN_DESC.rst.Sections(j).Guide And Me.NewSections(Me.iNumRods).NumGuides = RSWIN_DESC.rst.Sections(j).NumGuides Then
									Me.NewSections(Me.iNumRods).length = Me.NewSections(Me.iNumRods).length + RSWIN_DESC.rst.Sections(j).length
									array(j) = True
								End If
							ElseIf Me.NewSections(Me.iNumRods).Grade = RSWIN_DESC.rst.Sections(j).Grade And Me.NewSections(Me.iNumRods).Diameter = RSWIN_DESC.rst.Sections(j).Diameter Then
								Me.NewSections(Me.iNumRods).length = Me.NewSections(Me.iNumRods).length + RSWIN_DESC.rst.Sections(j).length
								array(j) = True
							End If

					Next
				End If
				i += 1
			End While
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				Me.lblRodDiamHdrBot.Text = "(" + RSWIN_DESC.mm + ")"
			Else
				Me.lblRodDiamHdrBot.Text = "(" + RSWIN_DESC.inches + ")"
			End If
			Dim lblRodDiam As Label = Me.lblRodDiam1
			Dim lblRodDiam2 As Label = Me.lblRodDiam2
			Dim lblRodDiam3 As Label = Me.lblRodDiam3
			Dim lblRodDiam4 As Label = Me.lblRodDiam4
			Dim lblRodDiam5 As Label = Me.lblRodDiam5
			Dim lblRodDiam6 As Label = Me.lblRodDiam6
			Dim lblRodDiam7 As Label = Me.lblRodDiam7
			Dim lblRodDiam8 As Label = Me.lblRodDiam8
			Dim lblRodDiam9 As Label = Me.lblRodDiam9
			Dim lblRodDiam10 As Label = Me.lblRodDiam10
			Dim lblRodDiam11 As Label = Me.lblRodDiam11
			Dim lblRodDiam12 As Label = Me.lblRodDiam12
			Dim lblRodDiam13 As Label = Me.lblRodDiam13
			Dim lblRodDiam14 As Label = Me.lblRodDiam14
			Dim lblRodDiam15 As Label = Me.lblRodDiam15
			Dim lblRodDiam16 As Label = Me.lblRodDiam16
			Dim lblRodDiam17 As Label = Me.lblRodDiam17
			Dim lblRodDiam18 As Label = Me.lblRodDiam18
			Dim lblRodDiam19 As Label = Me.lblRodDiam19
			Dim lblRodDiam20 As Label = Me.lblRodDiam20
			Me.ShowRodDiameterList(lblRodDiam, lblRodDiam2, lblRodDiam3, lblRodDiam4, lblRodDiam5, lblRodDiam6, lblRodDiam7, lblRodDiam8, lblRodDiam9, lblRodDiam10, lblRodDiam11, lblRodDiam12, lblRodDiam13, lblRodDiam14, lblRodDiam15, lblRodDiam16, lblRodDiam17, lblRodDiam18, lblRodDiam19, lblRodDiam20)
			Me.lblRodDiam20 = lblRodDiam20
			Me.lblRodDiam19 = lblRodDiam19
			Me.lblRodDiam18 = lblRodDiam18
			Me.lblRodDiam17 = lblRodDiam17
			Me.lblRodDiam16 = lblRodDiam16
			Me.lblRodDiam15 = lblRodDiam15
			Me.lblRodDiam14 = lblRodDiam14
			Me.lblRodDiam13 = lblRodDiam13
			Me.lblRodDiam12 = lblRodDiam12
			Me.lblRodDiam11 = lblRodDiam11
			Me.lblRodDiam10 = lblRodDiam10
			Me.lblRodDiam9 = lblRodDiam9
			Me.lblRodDiam8 = lblRodDiam8
			Me.lblRodDiam7 = lblRodDiam7
			Me.lblRodDiam6 = lblRodDiam6
			Me.lblRodDiam5 = lblRodDiam5
			Me.lblRodDiam4 = lblRodDiam4
			Me.lblRodDiam3 = lblRodDiam3
			Me.lblRodDiam2 = lblRodDiam2
			Me.lblRodDiam1 = lblRodDiam
			Me.guide_box.Visible = RSWIN_DESC.bRodStarD
			Me.lblGuideTypeHdrTop.Visible = RSWIN_DESC.bRodStarD
			Me.lblGuideTypeHdrBot.Visible = RSWIN_DESC.bRodStarD
			Me.lblNumGuidesHdrTop.Visible = RSWIN_DESC.bRodStarD
			Me.lblNumGuidesHdrBot.Visible = RSWIN_DESC.bRodStarD
			Me.linSep3.Visible = RSWIN_DESC.bRodStarD
			Me.Line14.Visible = RSWIN_DESC.bRodStarD
			num4 = 0F
			Dim num5 As Integer = 1
			Dim num6 As Integer = Me.iNumRods
			i = num5
			While i <= num6
				Dim num7 As Single
				If RODUTIL.IsFG(Me.NewSections(i).Grade) Or CUSTOMRG.IsOtherFG(CInt(Me.NewSections(i).Grade)) Then
					num7 = 37.5F
				Else
					num7 = RSWIN_DESC.SETUP_SteelSuckerRodLength
				End If
				Dim num8 As Integer = CInt(Math.Round(CDbl((Me.NewSections(i).length / num7)) + 0.5))
				num9 = Me.SetReportGridLine(i, Me.NewSections(i), num8)

					num4 += CSng(num8) * num7

				i += 1
			End While
			Me.rod_box.Height = CSng((CDbl(num9) + 0.1))
			Me.guide_box.Height = CSng((CDbl(num9) + 0.1))
			Me.linSep1.Y2 = Me.linSep1.Y1 + Me.rod_box.Height
			Me.linSep2.Y2 = Me.linSep1.Y2
			Me.linSep3.Y2 = Me.linSep1.Y2
			i = Me.iNumRods + 1
			While i <= 20
				Me.SetGridLineVisible(i, False)
				i += 1
			End While
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				Me.lblPumpDepthLabel.Text = "Pump Depth (ft):"
				Me.lblTotalLengthLabel.Text = "Total Length (ft):"
				Dim lblPumpDepth As Label = Me.lblPumpDepth
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim pumpDepth As Single = rst.PumpDepth
				Dim text As String = "#####.##"
				Dim text2 As String = Util.Format(pumpDepth, text)
				rst.PumpDepth = pumpDepth
				lblPumpDepth.Text = text2
				Dim lblTotalLength As Label = Me.lblTotalLength
				text = "#####.##"
				lblTotalLength.Text = Util.Format(num4, text)
			Else
				Me.lblPumpDepthLabel.Text = "Pump Depth (m):"
				Me.lblTotalLengthLabel.Text = "Total Length (m):"
				Dim lblPumpDepth2 As Label = Me.lblPumpDepth
				Dim pumpDepth As Single = RSWIN_DESC.rst.PumpDepth * RSWIN_DESC.FT__M
				Dim text As String = "#####.##"
				lblPumpDepth2.Text = Util.Format(pumpDepth, text)
				Dim lblTotalLength2 As Label = Me.lblTotalLength
				pumpDepth = num4 * RSWIN_DESC.FT__M
				text = "#####.##"
				lblTotalLength2.Text = Util.Format(pumpDepth, text)
			End If
			Me.lblTotalLength.Top = Me.linSep1.Y2 + Me.lblTotalLength.Height
			Me.lblTotalLengthLabel.Top = Me.lblTotalLength.Top
			Me.lblPumpDepthLabel.Top = Me.lblTotalLength.Top
			Me.lblPumpDepth.Top = Me.lblTotalLength.Top
		End Sub

		Private Sub Detail1_Format(sender As Object, e As EventArgs)
		End Sub

		Public Function SetReportGridLine(I As Integer, Section As RSWIN_DESC.RodSection, iReportNumRods As Integer) As Single
			Dim result As Single
			Try
				Me.SetGridLineVisible(I, True)
				Dim num As Single
				Select Case I
					Case 1
						Me.lblRodGrade1.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods1.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType1.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides1.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade1.Top + Me.lblRodGrade1.Height
					Case 2
						Me.lblRodGrade2.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods2.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType2.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides2.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade2.Top + Me.lblRodGrade2.Height
					Case 3
						Me.lblRodGrade3.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods3.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType3.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides3.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade3.Top + Me.lblRodGrade3.Height
					Case 4
						Me.lblRodGrade4.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods4.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType4.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides4.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade4.Top + Me.lblRodGrade4.Height
					Case 5
						Me.lblRodGrade5.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods5.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType5.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides5.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade5.Top + Me.lblRodGrade5.Height
					Case 6
						Me.lblRodGrade6.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods6.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType6.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides6.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade6.Top + Me.lblRodGrade6.Height
					Case 7
						Me.lblRodGrade7.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods7.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType7.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides7.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade7.Top + Me.lblRodGrade7.Height
					Case 8
						Me.lblRodGrade8.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods8.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType8.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides8.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade8.Top + Me.lblRodGrade8.Height
					Case 9
						Me.lblRodGrade9.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods9.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType9.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides9.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade9.Top + Me.lblRodGrade9.Height
					Case 10
						Me.lblRodGrade10.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods10.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType10.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides10.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade10.Top + Me.lblRodGrade10.Height
					Case 11
						Me.lblRodGrade11.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods11.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType11.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides11.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade11.Top + Me.lblRodGrade11.Height
					Case 12
						Me.lblRodGrade12.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods12.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType12.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides12.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade12.Top + Me.lblRodGrade12.Height
					Case 13
						Me.lblRodGrade13.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods13.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType13.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides13.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade13.Top + Me.lblRodGrade13.Height
					Case 14
						Me.lblRodGrade14.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods14.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType14.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides14.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade14.Top + Me.lblRodGrade14.Height
					Case 15
						Me.lblRodGrade15.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods15.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType15.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides15.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade15.Top + Me.lblRodGrade15.Height
					Case 16
						Me.lblRodGrade16.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods16.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType16.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides16.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade16.Top + Me.lblRodGrade16.Height
					Case 17
						Me.lblRodGrade17.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods17.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType17.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides17.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade17.Top + Me.lblRodGrade17.Height
					Case 18
						Me.lblRodGrade18.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods18.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType18.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides18.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade18.Top + Me.lblRodGrade18.Height
					Case 19
						Me.lblRodGrade19.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods19.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType19.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides19.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade19.Top + Me.lblRodGrade19.Height
					Case 20
						Me.lblRodGrade20.Text = RODUTIL.FullRodGrade(Section.Grade)
						Me.lblNumRods20.Text = Conversions.ToString(iReportNumRods)
						If RSWIN_DESC.bRodStarD Then
							Me.lblGuideType20.Text = Me.GetRodGuideName(Section.Guide)
							Me.lblNumGuides20.Text = Conversions.ToString(CInt(Section.NumGuides))
						End If
						num = Me.lblRodGrade20.Top + Me.lblRodGrade20.Height
				End Select
				result = num
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub SetGridLineVisible(I As Integer, bVisible As Boolean)
			Try
				Select Case I
					Case 1
						Me.lblRodGrade1.Visible = bVisible
						Me.lblRodDiam1.Visible = bVisible
						Me.lblNumRods1.Visible = bVisible
						Me.lblGuideType1.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides1.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 2
						Me.lblRodGrade2.Visible = bVisible
						Me.lblRodDiam2.Visible = bVisible
						Me.lblNumRods2.Visible = bVisible
						Me.lblGuideType2.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides2.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 3
						Me.lblRodGrade3.Visible = bVisible
						Me.lblRodDiam3.Visible = bVisible
						Me.lblNumRods3.Visible = bVisible
						Me.lblGuideType3.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides3.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 4
						Me.lblRodGrade4.Visible = bVisible
						Me.lblRodDiam4.Visible = bVisible
						Me.lblNumRods4.Visible = bVisible
						Me.lblGuideType4.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides4.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 5
						Me.lblRodGrade5.Visible = bVisible
						Me.lblRodDiam5.Visible = bVisible
						Me.lblNumRods5.Visible = bVisible
						Me.lblGuideType5.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides5.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 6
						Me.lblRodGrade6.Visible = bVisible
						Me.lblRodDiam6.Visible = bVisible
						Me.lblNumRods6.Visible = bVisible
						Me.lblGuideType6.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides6.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 7
						Me.lblRodGrade7.Visible = bVisible
						Me.lblRodDiam7.Visible = bVisible
						Me.lblNumRods7.Visible = bVisible
						Me.lblGuideType7.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides7.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 8
						Me.lblRodGrade8.Visible = bVisible
						Me.lblRodDiam8.Visible = bVisible
						Me.lblNumRods8.Visible = bVisible
						Me.lblGuideType8.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides8.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 9
						Me.lblRodGrade9.Visible = bVisible
						Me.lblRodDiam9.Visible = bVisible
						Me.lblNumRods9.Visible = bVisible
						Me.lblGuideType9.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides9.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 10
						Me.lblRodGrade10.Visible = bVisible
						Me.lblRodDiam10.Visible = bVisible
						Me.lblNumRods10.Visible = bVisible
						Me.lblGuideType10.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides10.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 11
						Me.lblRodGrade11.Visible = bVisible
						Me.lblRodDiam11.Visible = bVisible
						Me.lblNumRods11.Visible = bVisible
						Me.lblGuideType11.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides11.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 12
						Me.lblRodGrade12.Visible = bVisible
						Me.lblRodDiam12.Visible = bVisible
						Me.lblNumRods12.Visible = bVisible
						Me.lblGuideType12.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides12.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 13
						Me.lblRodGrade13.Visible = bVisible
						Me.lblRodDiam13.Visible = bVisible
						Me.lblNumRods13.Visible = bVisible
						Me.lblGuideType13.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides13.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 14
						Me.lblRodGrade14.Visible = bVisible
						Me.lblRodDiam14.Visible = bVisible
						Me.lblNumRods14.Visible = bVisible
						Me.lblGuideType14.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides14.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 15
						Me.lblRodGrade15.Visible = bVisible
						Me.lblRodDiam15.Visible = bVisible
						Me.lblNumRods15.Visible = bVisible
						Me.lblGuideType15.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides15.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 16
						Me.lblRodGrade16.Visible = bVisible
						Me.lblRodDiam16.Visible = bVisible
						Me.lblNumRods16.Visible = bVisible
						Me.lblGuideType16.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides16.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 17
						Me.lblRodGrade17.Visible = bVisible
						Me.lblRodDiam17.Visible = bVisible
						Me.lblNumRods17.Visible = bVisible
						Me.lblGuideType17.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides17.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 18
						Me.lblRodGrade18.Visible = bVisible
						Me.lblRodDiam18.Visible = bVisible
						Me.lblNumRods18.Visible = bVisible
						Me.lblGuideType18.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides18.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 19
						Me.lblRodGrade19.Visible = bVisible
						Me.lblRodDiam19.Visible = bVisible
						Me.lblNumRods19.Visible = bVisible
						Me.lblGuideType19.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides19.Visible = (bVisible And RSWIN_DESC.bRodStarD)
					Case 20
						Me.lblRodGrade20.Visible = bVisible
						Me.lblRodDiam20.Visible = bVisible
						Me.lblNumRods20.Visible = bVisible
						Me.lblGuideType20.Visible = (bVisible And RSWIN_DESC.bRodStarD)
						Me.lblNumGuides20.Visible = (bVisible And RSWIN_DESC.bRodStarD)
				End Select
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetRodGuideName(RodGuide As Short) As String
			Dim text As String = New String(" "c, 8192)
			Dim result As String
			Try
				If RodGuide = 0S Then
					result = "Bare Rod (no rod guides)"
				ElseIf RodGuide = RSWIN_DESC.MOLDED Then
					result = "Molded"
				ElseIf RodGuide = 2S Then
					result = "Wheeled"
				ElseIf RodGuide = 3S Then
					Dim text2 As String = "OtherGuide"
					Dim text3 As String = "Other"
					Dim length As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, text, True))
					RSWIN_DESC.sOtherGuided = text.Substring(0, CInt(length))
					result = RSWIN_DESC.sOtherGuided
				ElseIf RodGuide = 4S Then
					result = "Norris Standard"
				ElseIf RodGuide = RSWIN_DESC.NorrisSidewinderGuide Then
					result = "Norris Sidewinder"
				ElseIf RodGuide = 6S Then
					result = "RGI Jake Coupling"
				ElseIf RodGuide = 7S Then
					result = "RGI SVT"
				ElseIf RodGuide = 8S Then
					result = "RGI Tomahawk"
				ElseIf RodGuide = 9S Then
					result = "RGI Tornado"
				ElseIf RodGuide = 10S Then
					result = "RGI Twister"
				ElseIf RodGuide = 11S Then
					result = "RGI WVT"
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub ShowRodDiameterList(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label, ByRef avLabels11 As Label, ByRef avLabels12 As Label, ByRef avLabels13 As Label, ByRef avLabels14 As Label, ByRef avLabels15 As Label, ByRef avLabels16 As Label, ByRef avLabels17 As Label, ByRef avLabels18 As Label, ByRef avLabels19 As Label, ByRef avLabels20 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 20L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(Me.iNumRods) Then
								avLabels1.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels1)
							End If
						Case 1
							If num > CLng(Me.iNumRods) Then
								avLabels2.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels2)
							End If
						Case 2
							If num > CLng(Me.iNumRods) Then
								avLabels3.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels3)
							End If
						Case 3
							If num > CLng(Me.iNumRods) Then
								avLabels4.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels4)
							End If
						Case 4
							If num > CLng(Me.iNumRods) Then
								avLabels5.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels5)
							End If
						Case 5
							If num > CLng(Me.iNumRods) Then
								avLabels6.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels6)
							End If
						Case 6
							If num > CLng(Me.iNumRods) Then
								avLabels7.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels7)
							End If
						Case 7
							If num > CLng(Me.iNumRods) Then
								avLabels8.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels8)
							End If
						Case 8
							If num > CLng(Me.iNumRods) Then
								avLabels9.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels9)
							End If
						Case 9
							If num > CLng(Me.iNumRods) Then
								avLabels10.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels10)
							End If
						Case 10
							If num > CLng(Me.iNumRods) Then
								avLabels11.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels11)
							End If
						Case 11
							If num > CLng(Me.iNumRods) Then
								avLabels12.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels12)
							End If
						Case 12
							If num > CLng(Me.iNumRods) Then
								avLabels13.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels13)
							End If
						Case 13
							If num > CLng(Me.iNumRods) Then
								avLabels14.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels14)
							End If
						Case 14
							If num > CLng(Me.iNumRods) Then
								avLabels15.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels15)
							End If
						Case 15
							If num > CLng(Me.iNumRods) Then
								avLabels16.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels16)
							End If
						Case 16
							If num > CLng(Me.iNumRods) Then
								avLabels17.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels17)
							End If
						Case 17
							If num > CLng(Me.iNumRods) Then
								avLabels18.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels18)
							End If
						Case 18
							If num > CLng(Me.iNumRods) Then
								avLabels19.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels19)
							End If
						Case 19
							If num > CLng(Me.iNumRods) Then
								avLabels20.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels20)
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub SetRodGradeList(I As Integer, ByRef avLabel As Label)
			Dim text As String
			If RODUTIL.IsCorodH(Me.NewSections(I).Grade) Then
				text = RSWIN_DESC.sNA
			ElseIf RODUTIL.IsCorod(Me.NewSections(I).Grade) Then
				If CDbl(Me.NewSections(I).Diameter) = 1.15625 Then
					Dim num As Single = Me.NewSections(I).Diameter * 16F
					Dim text2 As String = "0.0"
					text = Util.Format(num, text2) + "/16"
				Else
					Dim num As Single = Me.NewSections(I).Diameter * 16F
					Dim text2 As String = "0"
					text = Util.Format(num, text2) + "/16"
				End If
			ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				Dim num As Single = Me.NewSections(I).Diameter * RSWIN_DESC.IN__MM
				Dim text2 As String = "0.0"
				text = Util.Format(num, text2)
			Else
				Dim newSections As RSWIN_DESC.RodSection() = Me.NewSections
				Dim text2 As String = "0.####"
				text = Util.Format(newSections(I).Diameter, text2)
			End If
			If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				Dim canadianDiameter As String = Me.GetCanadianDiameter(Me.NewSections(I).Grade, Me.NewSections(I).RodType, Me.NewSections(I).Diameter)
				If Operators.CompareString(canadianDiameter.Trim(), "", False) <> 0 Then
					text = canadianDiameter
				End If
			End If
			avLabel.Text = text
		End Sub

		Public Function GetCanadianDiameter(iRodGrade As Short, ByRef sRodType As String, fRodSize As Single) As String
			Dim result As String
			Try
				Dim teRodSizeList As teRodSizeList
				If CUSTOMRG.IsOtherSteel(CInt(iRodGrade)) Or CUSTOMRG.IsOtherFG(CInt(iRodGrade)) Or CUSTOMRG.IsOtherSinkerBar(CInt(iRodGrade)) Then
					If Not RODUTIL.IsAPI(CInt(iRodGrade), sRodType) Then
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(14)
					ElseIf RODUTIL.IsSinkerBar1(CInt(iRodGrade), sRodType) <> 0 Then
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(13)
					Else
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(1)
					End If
				Else
					teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(iRodGrade, StdInfoConstants.RodGradeConstants)).RodSizeList
				End If
				RSWIN_DESC.nItems = 0S
				Try
					For Each obj As Object In teRodSizeList
						Dim dictionaryEntry As DictionaryEntry
						Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
						Dim metricDisplayName As String
						RSWIN_DESC.nItems += 1S
						Dim displayName As String = teRodSize.DisplayName
						metricDisplayName = teRodSize.MetricDisplayName
						Try
							If CDbl(Math.Abs(teRodSize.Diameter - fRodSize)) < 1E-06 Then
								result = metricDisplayName
								Exit Try
							End If
						Catch ex As Exception
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex2 As Exception
				result = ""
			End Try
			Return result
		End Function

		<AccessedThroughProperty("PageHeader1")>
		Private _PageHeader1 As PageHeader

		<AccessedThroughProperty("Detail1")>
		Private _Detail1 As Detail

		<AccessedThroughProperty("PageFooter1")>
		Private _PageFooter1 As PageFooter

		<AccessedThroughProperty("lblNumRods1")>
		Private _lblNumRods1 As Label

		<AccessedThroughProperty("lblRodGrade1")>
		Private _lblRodGrade1 As Label

		<AccessedThroughProperty("lblRodDiam1")>
		Private _lblRodDiam1 As Label

		<AccessedThroughProperty("linSep1")>
		Private _linSep1 As Line

		<AccessedThroughProperty("lblRodDiamHdrTop")>
		Private _lblRodDiamHdrTop As Label

		<AccessedThroughProperty("lblRodDiamHdrBot")>
		Private _lblRodDiamHdrBot As Label

		<AccessedThroughProperty("lblRodGradeHdrBot")>
		Private _lblRodGradeHdrBot As Label

		<AccessedThroughProperty("lblNumRodsHdrBot")>
		Private _lblNumRodsHdrBot As Label

		<AccessedThroughProperty("Line12")>
		Private _Line12 As Line

		<AccessedThroughProperty("lblRodDiam2")>
		Private _lblRodDiam2 As Label

		<AccessedThroughProperty("lblRodDiam3")>
		Private _lblRodDiam3 As Label

		<AccessedThroughProperty("lblRodDiam4")>
		Private _lblRodDiam4 As Label

		<AccessedThroughProperty("lblRodDiam5")>
		Private _lblRodDiam5 As Label

		<AccessedThroughProperty("lblRodDiam6")>
		Private _lblRodDiam6 As Label

		<AccessedThroughProperty("lblRodDiam7")>
		Private _lblRodDiam7 As Label

		<AccessedThroughProperty("lblRodDiam8")>
		Private _lblRodDiam8 As Label

		<AccessedThroughProperty("lblRodGrade2")>
		Private _lblRodGrade2 As Label

		<AccessedThroughProperty("lblRodGrade3")>
		Private _lblRodGrade3 As Label

		<AccessedThroughProperty("lblRodGrade4")>
		Private _lblRodGrade4 As Label

		<AccessedThroughProperty("lblRodGrade5")>
		Private _lblRodGrade5 As Label

		<AccessedThroughProperty("lblRodGrade6")>
		Private _lblRodGrade6 As Label

		<AccessedThroughProperty("lblRodGrade7")>
		Private _lblRodGrade7 As Label

		<AccessedThroughProperty("lblRodGrade8")>
		Private _lblRodGrade8 As Label

		<AccessedThroughProperty("lblNumRods2")>
		Private _lblNumRods2 As Label

		<AccessedThroughProperty("lblNumRods3")>
		Private _lblNumRods3 As Label

		<AccessedThroughProperty("lblNumRods4")>
		Private _lblNumRods4 As Label

		<AccessedThroughProperty("lblNumRods5")>
		Private _lblNumRods5 As Label

		<AccessedThroughProperty("lblNumRods6")>
		Private _lblNumRods6 As Label

		<AccessedThroughProperty("lblNumRods7")>
		Private _lblNumRods7 As Label

		<AccessedThroughProperty("lblNumRods8")>
		Private _lblNumRods8 As Label

		<AccessedThroughProperty("lblGuideTypeHdrBot")>
		Private _lblGuideTypeHdrBot As Label

		<AccessedThroughProperty("Line14")>
		Private _Line14 As Line

		<AccessedThroughProperty("lblGuideType1")>
		Private _lblGuideType1 As Label

		<AccessedThroughProperty("lblGuideType2")>
		Private _lblGuideType2 As Label

		<AccessedThroughProperty("lblGuideType3")>
		Private _lblGuideType3 As Label

		<AccessedThroughProperty("lblGuideType4")>
		Private _lblGuideType4 As Label

		<AccessedThroughProperty("lblGuideType5")>
		Private _lblGuideType5 As Label

		<AccessedThroughProperty("lblGuideType6")>
		Private _lblGuideType6 As Label

		<AccessedThroughProperty("lblGuideType7")>
		Private _lblGuideType7 As Label

		<AccessedThroughProperty("lblGuideType8")>
		Private _lblGuideType8 As Label

		<AccessedThroughProperty("lblNumGuidesHdrBot")>
		Private _lblNumGuidesHdrBot As Label

		<AccessedThroughProperty("lblNumGuides1")>
		Private _lblNumGuides1 As Label

		<AccessedThroughProperty("lblNumGuides2")>
		Private _lblNumGuides2 As Label

		<AccessedThroughProperty("lblNumGuides3")>
		Private _lblNumGuides3 As Label

		<AccessedThroughProperty("lblNumGuides4")>
		Private _lblNumGuides4 As Label

		<AccessedThroughProperty("lblNumGuides5")>
		Private _lblNumGuides5 As Label

		<AccessedThroughProperty("lblNumGuides6")>
		Private _lblNumGuides6 As Label

		<AccessedThroughProperty("lblNumGuides7")>
		Private _lblNumGuides7 As Label

		<AccessedThroughProperty("lblNumGuides8")>
		Private _lblNumGuides8 As Label

		<AccessedThroughProperty("lblRodGradeHdrTop")>
		Private _lblRodGradeHdrTop As Label

		<AccessedThroughProperty("lblGuideTypeHdrTop")>
		Private _lblGuideTypeHdrTop As Label

		<AccessedThroughProperty("lblNumGuidesHdrTop")>
		Private _lblNumGuidesHdrTop As Label

		<AccessedThroughProperty("lblNumRodsHdrTop")>
		Private _lblNumRodsHdrTop As Label

		<AccessedThroughProperty("linSep3")>
		Private _linSep3 As Line

		<AccessedThroughProperty("lblRodDiam9")>
		Private _lblRodDiam9 As Label

		<AccessedThroughProperty("lblRodGrade9")>
		Private _lblRodGrade9 As Label

		<AccessedThroughProperty("lblNumRods9")>
		Private _lblNumRods9 As Label

		<AccessedThroughProperty("lblNumGuides9")>
		Private _lblNumGuides9 As Label

		<AccessedThroughProperty("lblRodDiam10")>
		Private _lblRodDiam10 As Label

		<AccessedThroughProperty("lblRodGrade10")>
		Private _lblRodGrade10 As Label

		<AccessedThroughProperty("lblNumRods10")>
		Private _lblNumRods10 As Label

		<AccessedThroughProperty("lblGuideType10")>
		Private _lblGuideType10 As Label

		<AccessedThroughProperty("lblNumGuides10")>
		Private _lblNumGuides10 As Label

		<AccessedThroughProperty("linSep2")>
		Private _linSep2 As Line

		<AccessedThroughProperty("lblNumRods11")>
		Private _lblNumRods11 As Label

		<AccessedThroughProperty("lblRodGrade11")>
		Private _lblRodGrade11 As Label

		<AccessedThroughProperty("lblRodDiam11")>
		Private _lblRodDiam11 As Label

		<AccessedThroughProperty("lblRodDiam12")>
		Private _lblRodDiam12 As Label

		<AccessedThroughProperty("lblRodDiam13")>
		Private _lblRodDiam13 As Label

		<AccessedThroughProperty("lblRodDiam14")>
		Private _lblRodDiam14 As Label

		<AccessedThroughProperty("lblRodDiam15")>
		Private _lblRodDiam15 As Label

		<AccessedThroughProperty("lblRodDiam16")>
		Private _lblRodDiam16 As Label

		<AccessedThroughProperty("lblRodDiam17")>
		Private _lblRodDiam17 As Label

		<AccessedThroughProperty("lblRodDiam18")>
		Private _lblRodDiam18 As Label

		<AccessedThroughProperty("lblRodGrade12")>
		Private _lblRodGrade12 As Label

		<AccessedThroughProperty("lblRodGrade13")>
		Private _lblRodGrade13 As Label

		<AccessedThroughProperty("lblRodGrade14")>
		Private _lblRodGrade14 As Label

		<AccessedThroughProperty("lblRodGrade15")>
		Private _lblRodGrade15 As Label

		<AccessedThroughProperty("lblRodGrade16")>
		Private _lblRodGrade16 As Label

		<AccessedThroughProperty("lblRodGrade17")>
		Private _lblRodGrade17 As Label

		<AccessedThroughProperty("lblRodGrade18")>
		Private _lblRodGrade18 As Label

		<AccessedThroughProperty("lblNumRods12")>
		Private _lblNumRods12 As Label

		<AccessedThroughProperty("lblNumRods13")>
		Private _lblNumRods13 As Label

		<AccessedThroughProperty("lblNumRods14")>
		Private _lblNumRods14 As Label

		<AccessedThroughProperty("lblNumRods15")>
		Private _lblNumRods15 As Label

		<AccessedThroughProperty("lblNumRods16")>
		Private _lblNumRods16 As Label

		<AccessedThroughProperty("lblNumRods17")>
		Private _lblNumRods17 As Label

		<AccessedThroughProperty("lblNumRods18")>
		Private _lblNumRods18 As Label

		<AccessedThroughProperty("lblGuideType11")>
		Private _lblGuideType11 As Label

		<AccessedThroughProperty("lblGuideType12")>
		Private _lblGuideType12 As Label

		<AccessedThroughProperty("lblGuideType13")>
		Private _lblGuideType13 As Label

		<AccessedThroughProperty("lblGuideType14")>
		Private _lblGuideType14 As Label

		<AccessedThroughProperty("lblGuideType15")>
		Private _lblGuideType15 As Label

		<AccessedThroughProperty("lblGuideType16")>
		Private _lblGuideType16 As Label

		<AccessedThroughProperty("lblGuideType17")>
		Private _lblGuideType17 As Label

		<AccessedThroughProperty("lblGuideType18")>
		Private _lblGuideType18 As Label

		<AccessedThroughProperty("lblNumGuides11")>
		Private _lblNumGuides11 As Label

		<AccessedThroughProperty("lblNumGuides12")>
		Private _lblNumGuides12 As Label

		<AccessedThroughProperty("lblNumGuides13")>
		Private _lblNumGuides13 As Label

		<AccessedThroughProperty("lblNumGuides14")>
		Private _lblNumGuides14 As Label

		<AccessedThroughProperty("lblNumGuides15")>
		Private _lblNumGuides15 As Label

		<AccessedThroughProperty("lblNumGuides16")>
		Private _lblNumGuides16 As Label

		<AccessedThroughProperty("lblNumGuides17")>
		Private _lblNumGuides17 As Label

		<AccessedThroughProperty("lblNumGuides18")>
		Private _lblNumGuides18 As Label

		<AccessedThroughProperty("lblRodDiam19")>
		Private _lblRodDiam19 As Label

		<AccessedThroughProperty("lblRodGrade19")>
		Private _lblRodGrade19 As Label

		<AccessedThroughProperty("lblNumRods19")>
		Private _lblNumRods19 As Label

		<AccessedThroughProperty("lblGuideType19")>
		Private _lblGuideType19 As Label

		<AccessedThroughProperty("lblNumGuides19")>
		Private _lblNumGuides19 As Label

		<AccessedThroughProperty("lblRodDiam20")>
		Private _lblRodDiam20 As Label

		<AccessedThroughProperty("lblRodGrade20")>
		Private _lblRodGrade20 As Label

		<AccessedThroughProperty("lblNumRods20")>
		Private _lblNumRods20 As Label

		<AccessedThroughProperty("lblGuideType20")>
		Private _lblGuideType20 As Label

		<AccessedThroughProperty("lblNumGuides20")>
		Private _lblNumGuides20 As Label

		<AccessedThroughProperty("rod_box")>
		Private _rod_box As Shape

		<AccessedThroughProperty("guide_box")>
		Private _guide_box As Shape

		<AccessedThroughProperty("lblGuideType9")>
		Private _lblGuideType9 As Label

		<AccessedThroughProperty("lblTotalLengthLabel")>
		Private _lblTotalLengthLabel As Label

		<AccessedThroughProperty("lblTotalLength")>
		Private _lblTotalLength As Label

		<AccessedThroughProperty("lblPumpDepthLabel")>
		Private _lblPumpDepthLabel As Label

		<AccessedThroughProperty("lblComment")>
		Private _lblComment As Label

		<AccessedThroughProperty("lblTitle1")>
		Private _lblTitle1 As Label

		<AccessedThroughProperty("lblPage")>
		Private _lblPage As Label

		<AccessedThroughProperty("txtPage1")>
		Private _txtPage1 As TextBox

		<AccessedThroughProperty("lblOf")>
		Private _lblOf As Label

		<AccessedThroughProperty("txtPage2")>
		Private _txtPage2 As TextBox

		<AccessedThroughProperty("lblUserName")>
		Private _lblUserName As Label

		<AccessedThroughProperty("lblUserDate")>
		Private _lblUserDate As Label

		<AccessedThroughProperty("lblLabel2")>
		Private _lblLabel2 As Label

		<AccessedThroughProperty("lblCompany")>
		Private _lblCompany As Label

		<AccessedThroughProperty("lblWellName")>
		Private _lblWellName As Label

		<AccessedThroughProperty("lblDiskFile")>
		Private _lblDiskFile As Label

		<AccessedThroughProperty("lblSecondCompanyName")>
		Private _lblSecondCompanyName As Label

		<AccessedThroughProperty("lblSecondCompanyPhonenumber")>
		Private _lblSecondCompanyPhonenumber As Label

		<AccessedThroughProperty("lblGoTheta")>
		Private _lblGoTheta As Label

		<AccessedThroughProperty("lblReportTitle")>
		Private _lblReportTitle As Label

		<AccessedThroughProperty("lblPumpDepth")>
		Private _lblPumpDepth As Label

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

		Private NewSections As RSWIN_DESC.RodSection()

		Private iNumRods As Integer

		Private m_bPrint As Boolean

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer
	End Class
End Namespace
