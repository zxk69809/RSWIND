Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports DataDynamics.ActiveReports
Imports DDCssLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports ThetaStdInfo

Namespace RSWINV3
	<DesignerGenerated()>
	Public Class rptDevSurvey3DPlot
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.rptDevSurvey3DPlot_ReportStart
			Me.slbl = "lbl"
			Me.sCompany = Util.AssignValueToConstant("rptCalcResults", "sCompany", "Company: ")
			Me.sWell = Util.AssignValueToConstant("rptCalcResults", "sWell", "Well: ")
			Me.sUser = Util.AssignValueToConstant("rptCalcResults", "sUser", "User: ")
			Me.sDiskFile = Util.AssignValueToConstant("rptCalcResults", "sDiskFile", "Disk file: ")
			Me.sDate = Util.AssignValueToConstant("rptCalcResults", "sDate", "Date: ")
			Me.sPage = Util.AssignValueToConstant("rptCalcResults", "sPage", "Page")
			Me.sOf = Util.AssignValueToConstant("rptCalcResults", "sOf", "of")
			Me.sComment = Util.AssignValueToConstant("rptCalcResults", "sComment", "Comment: ")
			Me.sThetaEnterprises = Util.AssignValueToConstant("rptCalcResults", "sThetaEnterprises", "(c) Theta Oilfield Services, Inc.")
			Me.sLicenseTo = Util.AssignValueToConstant("rptCalcResults", "sLicenseTo", " - Licensed to ")
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
				Me._Detail1 = value
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
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptDevSurvey3DPlot))
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
			Me.picDevPlot = New Picture()
			Me.Picture_AB = New Picture()
			Me.Picture_MarkII = New Picture()
			Me.Picture_Hydraulic = New Picture()
			Me.Picture_rotaflex = New Picture()
			Me.Picture_Conv = New Picture()
			Me.Picture_BB = New Picture()
			Me.Picture_RM = New Picture()
			Me.Picture_blp = New Picture()
			Me.lblDiameters = New Label()
			Me.T1 = New Label()
			Me.T2 = New Label()
			Me.T3 = New Label()
			Me.T4 = New Label()
			Me.T5 = New Label()
			Me.T6 = New Label()
			Me.T7 = New Label()
			Me.T8 = New Label()
			Me.T9 = New Label()
			Me.T10 = New Label()
			Me.lblNumGuidesPerRod = New Label()
			Me.G1 = New Label()
			Me.G2 = New Label()
			Me.G3 = New Label()
			Me.G4 = New Label()
			Me.G5 = New Label()
			Me.G6 = New Label()
			Me.G7 = New Label()
			Me.G8 = New Label()
			Me.G9 = New Label()
			Me.G10 = New Label()
			Me.G11 = New Label()
			Me.G12 = New Label()
			Me.G13 = New Label()
			Me.G14 = New Label()
			Me.G15 = New Label()
			Me.G16 = New Label()
			Me.G17 = New Label()
			Me.G18 = New Label()
			Me.G19 = New Label()
			Me.G20 = New Label()
			Me.T11 = New Label()
			Me.T12 = New Label()
			Me.T13 = New Label()
			Me.T14 = New Label()
			Me.T15 = New Label()
			Me.T16 = New Label()
			Me.T17 = New Label()
			Me.T18 = New Label()
			Me.T19 = New Label()
			Me.T20 = New Label()
			Me.PageFooter1 = New PageFooter()
			Me.lblDiameters2 = New Label()
			Me.lblNumGuidesPerRod2 = New Label()
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
			CType(Me.picDevPlot, ISupportInitialize).BeginInit()
			CType(Me.Picture_AB, ISupportInitialize).BeginInit()
			CType(Me.Picture_MarkII, ISupportInitialize).BeginInit()
			CType(Me.Picture_Hydraulic, ISupportInitialize).BeginInit()
			CType(Me.Picture_rotaflex, ISupportInitialize).BeginInit()
			CType(Me.Picture_Conv, ISupportInitialize).BeginInit()
			CType(Me.Picture_BB, ISupportInitialize).BeginInit()
			CType(Me.Picture_RM, ISupportInitialize).BeginInit()
			CType(Me.Picture_blp, ISupportInitialize).BeginInit()
			CType(Me.lblDiameters, ISupportInitialize).BeginInit()
			CType(Me.T1, ISupportInitialize).BeginInit()
			CType(Me.T2, ISupportInitialize).BeginInit()
			CType(Me.T3, ISupportInitialize).BeginInit()
			CType(Me.T4, ISupportInitialize).BeginInit()
			CType(Me.T5, ISupportInitialize).BeginInit()
			CType(Me.T6, ISupportInitialize).BeginInit()
			CType(Me.T7, ISupportInitialize).BeginInit()
			CType(Me.T8, ISupportInitialize).BeginInit()
			CType(Me.T9, ISupportInitialize).BeginInit()
			CType(Me.T10, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuidesPerRod, ISupportInitialize).BeginInit()
			CType(Me.G1, ISupportInitialize).BeginInit()
			CType(Me.G2, ISupportInitialize).BeginInit()
			CType(Me.G3, ISupportInitialize).BeginInit()
			CType(Me.G4, ISupportInitialize).BeginInit()
			CType(Me.G5, ISupportInitialize).BeginInit()
			CType(Me.G6, ISupportInitialize).BeginInit()
			CType(Me.G7, ISupportInitialize).BeginInit()
			CType(Me.G8, ISupportInitialize).BeginInit()
			CType(Me.G9, ISupportInitialize).BeginInit()
			CType(Me.G10, ISupportInitialize).BeginInit()
			CType(Me.G11, ISupportInitialize).BeginInit()
			CType(Me.G12, ISupportInitialize).BeginInit()
			CType(Me.G13, ISupportInitialize).BeginInit()
			CType(Me.G14, ISupportInitialize).BeginInit()
			CType(Me.G15, ISupportInitialize).BeginInit()
			CType(Me.G16, ISupportInitialize).BeginInit()
			CType(Me.G17, ISupportInitialize).BeginInit()
			CType(Me.G18, ISupportInitialize).BeginInit()
			CType(Me.G19, ISupportInitialize).BeginInit()
			CType(Me.G20, ISupportInitialize).BeginInit()
			CType(Me.T11, ISupportInitialize).BeginInit()
			CType(Me.T12, ISupportInitialize).BeginInit()
			CType(Me.T13, ISupportInitialize).BeginInit()
			CType(Me.T14, ISupportInitialize).BeginInit()
			CType(Me.T15, ISupportInitialize).BeginInit()
			CType(Me.T16, ISupportInitialize).BeginInit()
			CType(Me.T17, ISupportInitialize).BeginInit()
			CType(Me.T18, ISupportInitialize).BeginInit()
			CType(Me.T19, ISupportInitialize).BeginInit()
			CType(Me.T20, ISupportInitialize).BeginInit()
			CType(Me.lblDiameters2, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuidesPerRod2, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.PageHeader1.Controls.AddRange(New ARControl() { Me.lblComment, Me.lblTitle1, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserName, Me.lblUserDate, Me.lblLabel2, Me.lblCompany, Me.lblWellName, Me.lblDiskFile, Me.lblSecondCompanyName, Me.lblSecondCompanyPhonenumber, Me.lblGoTheta })
			Me.PageHeader1.Height = 0.96875F
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
			Me.lblTitle1.Text = "RODSTAR 1.0"
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
			Me.Detail1.Controls.AddRange(New ARControl() { Me.picDevPlot, Me.Picture_AB, Me.Picture_MarkII, Me.Picture_Hydraulic, Me.Picture_rotaflex, Me.Picture_Conv, Me.Picture_BB, Me.Picture_RM, Me.Picture_blp, Me.lblDiameters, Me.T1, Me.T2, Me.T3, Me.T4, Me.T5, Me.T6, Me.T7, Me.T8, Me.T9, Me.T10, Me.lblNumGuidesPerRod, Me.G1, Me.G2, Me.G3, Me.G4, Me.G5, Me.G6, Me.G7, Me.G8, Me.G9, Me.G10, Me.G11, Me.G12, Me.G13, Me.G14, Me.G15, Me.G16, Me.G17, Me.G18, Me.G19, Me.G20, Me.T11, Me.T12, Me.T13, Me.T14, Me.T15, Me.T16, Me.T17, Me.T18, Me.T19, Me.T20, Me.lblDiameters2, Me.lblNumGuidesPerRod2 })
			Me.Detail1.Height = 7.573417F
			Me.Detail1.Name = "Detail1"
			Me.picDevPlot.BackColor = Color.FromArgb(255, 255, 255)
			Me.picDevPlot.Height = 6.829F
			Me.picDevPlot.HyperLink = Nothing
			Me.picDevPlot.ImageData = Nothing
			Me.picDevPlot.Left = 0.3F
			Me.picDevPlot.LineColor = Color.FromArgb(255, 255, 255)
			Me.picDevPlot.Name = "picDevPlot"
			Me.picDevPlot.SizeMode = SizeModes.Stretch
			Me.picDevPlot.Top = 0F
			Me.picDevPlot.Width = 7.5F
			Me.Picture_AB.Height = 0.738F
			Me.Picture_AB.ImageData = CType(componentResourceManager.GetObject("Picture_AB.ImageData"), Stream)
			Me.Picture_AB.Left = 3.7825F
			Me.Picture_AB.Name = "Picture_AB"
			Me.Picture_AB.Top = 0.5F
			Me.Picture_AB.Visible = False
			Me.Picture_AB.Width = 0.9040002F
			Me.Picture_MarkII.Height = 0.738F
			Me.Picture_MarkII.HyperLink = Nothing
			Me.Picture_MarkII.ImageData = CType(componentResourceManager.GetObject("Picture_MarkII.ImageData"), Stream)
			Me.Picture_MarkII.Left = 3.306F
			Me.Picture_MarkII.Name = "Picture_MarkII"
			Me.Picture_MarkII.Top = 0.59F
			Me.Picture_MarkII.Width = 1.75F
			Me.Picture_Hydraulic.Height = 0.738F
			Me.Picture_Hydraulic.HyperLink = Nothing
			Me.Picture_Hydraulic.ImageData = CType(componentResourceManager.GetObject("Picture_Hydraulic.ImageData"), Stream)
			Me.Picture_Hydraulic.Left = 3.572F
			Me.Picture_Hydraulic.Name = "Picture_Hydraulic"
			Me.Picture_Hydraulic.Top = 0.56F
			Me.Picture_Hydraulic.Width = 1.128F
			Me.Picture_rotaflex.Height = 0.738F
			Me.Picture_rotaflex.ImageData = CType(componentResourceManager.GetObject("Picture_rotaflex.ImageData"), Stream)
			Me.Picture_rotaflex.Left = 3.2F
			Me.Picture_rotaflex.Name = "Picture_rotaflex"
			Me.Picture_rotaflex.Top = 0.45F
			Me.Picture_rotaflex.Width = 1.845F
			Me.Picture_Conv.Height = 0.738F
			Me.Picture_Conv.HyperLink = Nothing
			Me.Picture_Conv.ImageData = CType(componentResourceManager.GetObject("Picture_Conv.ImageData"), Stream)
			Me.Picture_Conv.Left = 3.316F
			Me.Picture_Conv.Name = "Picture_Conv"
			Me.Picture_Conv.Top = 0.6F
			Me.Picture_Conv.Width = 1.678F
			Me.Picture_BB.Height = 0.738F
			Me.Picture_BB.HyperLink = Nothing
			Me.Picture_BB.ImageData = CType(componentResourceManager.GetObject("Picture_BB.ImageData"), Stream)
			Me.Picture_BB.Left = 3.296F
			Me.Picture_BB.Name = "Picture_BB"
			Me.Picture_BB.Top = 0.59F
			Me.Picture_BB.Visible = False
			Me.Picture_BB.Width = 1.843F
			Me.Picture_RM.Height = 0.738F
			Me.Picture_RM.HyperLink = Nothing
			Me.Picture_RM.ImageData = CType(componentResourceManager.GetObject("Picture_RM.ImageData"), Stream)
			Me.Picture_RM.Left = 3.253F
			Me.Picture_RM.Name = "Picture_RM"
			Me.Picture_RM.Top = 0.59F
			Me.Picture_RM.Width = 1.741F
			Me.Picture_blp.Height = 0.738F
			Me.Picture_blp.HyperLink = Nothing
			Me.Picture_blp.ImageData = CType(componentResourceManager.GetObject("Picture_blp.ImageData"), Stream)
			Me.Picture_blp.Left = 3.253F
			Me.Picture_blp.Name = "Picture_blp"
			Me.Picture_blp.Top = 0.54F
			Me.Picture_blp.Width = 1.813F
			Me.lblDiameters.Height = 0.1499996F
			Me.lblDiameters.HyperLink = Nothing
			Me.lblDiameters.Left = 0.02F
			Me.lblDiameters.Name = "lblDiameters"
			Me.lblDiameters.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: center"
			Me.lblDiameters.Text = "Rod Diameters:"
			Me.lblDiameters.Top = 6.898F
			Me.lblDiameters.Width = 0.82F
			Me.T1.Height = 0.1500001F
			Me.T1.HyperLink = Nothing
			Me.T1.Left = 0.862F
			Me.T1.Name = "T1"
			Me.T1.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T1.Text = ""
			Me.T1.Top = 6.898F
			Me.T1.Width = 0.675F
			Me.T2.Height = 0.1500001F
			Me.T2.HyperLink = Nothing
			Me.T2.Left = 1.551F
			Me.T2.Name = "T2"
			Me.T2.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T2.Text = ""
			Me.T2.Top = 6.898F
			Me.T2.Width = 0.675F
			Me.T3.Height = 0.15F
			Me.T3.HyperLink = Nothing
			Me.T3.Left = 2.245F
			Me.T3.Name = "T3"
			Me.T3.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T3.Text = ""
			Me.T3.Top = 6.898F
			Me.T3.Width = 0.675F
			Me.T4.Height = 0.15F
			Me.T4.HyperLink = Nothing
			Me.T4.Left = 2.943F
			Me.T4.Name = "T4"
			Me.T4.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T4.Text = ""
			Me.T4.Top = 6.898F
			Me.T4.Width = 0.675F
			Me.T5.Height = 0.15F
			Me.T5.HyperLink = Nothing
			Me.T5.Left = 3.646F
			Me.T5.Name = "T5"
			Me.T5.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T5.Text = ""
			Me.T5.Top = 6.898F
			Me.T5.Width = 0.675F
			Me.T6.Height = 0.15F
			Me.T6.HyperLink = Nothing
			Me.T6.Left = 4.346999F
			Me.T6.Name = "T6"
			Me.T6.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T6.Text = ""
			Me.T6.Top = 6.898F
			Me.T6.Width = 0.675F
			Me.T7.Height = 0.15F
			Me.T7.HyperLink = Nothing
			Me.T7.Left = 5.052999F
			Me.T7.Name = "T7"
			Me.T7.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T7.Text = ""
			Me.T7.Top = 6.898F
			Me.T7.Width = 0.675F
			Me.T8.Height = 0.15F
			Me.T8.HyperLink = Nothing
			Me.T8.Left = 5.765998F
			Me.T8.Name = "T8"
			Me.T8.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T8.Text = ""
			Me.T8.Top = 6.898F
			Me.T8.Width = 0.675F
			Me.T9.Height = 0.15F
			Me.T9.HyperLink = Nothing
			Me.T9.Left = 6.472998F
			Me.T9.Name = "T9"
			Me.T9.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T9.Text = ""
			Me.T9.Top = 6.898F
			Me.T9.Width = 0.675F
			Me.T10.Height = 0.15F
			Me.T10.HyperLink = Nothing
			Me.T10.Left = 7.178999F
			Me.T10.Name = "T10"
			Me.T10.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T10.Text = ""
			Me.T10.Top = 6.898F
			Me.T10.Width = 0.675F
			Me.lblNumGuidesPerRod.Height = 0.1499996F
			Me.lblNumGuidesPerRod.HyperLink = Nothing
			Me.lblNumGuidesPerRod.Left = 0.02F
			Me.lblNumGuidesPerRod.Name = "lblNumGuidesPerRod"
			Me.lblNumGuidesPerRod.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: center"
			Me.lblNumGuidesPerRod.Text = "# Guides/Rod:"
			Me.lblNumGuidesPerRod.Top = 7.05F
			Me.lblNumGuidesPerRod.Visible = False
			Me.lblNumGuidesPerRod.Width = 0.82F
			Me.G1.Height = 0.1500001F
			Me.G1.HyperLink = Nothing
			Me.G1.Left = 0.862F
			Me.G1.Name = "G1"
			Me.G1.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G1.Text = ""
			Me.G1.Top = 7.050004F
			Me.G1.Visible = False
			Me.G1.Width = 0.675F
			Me.G2.Height = 0.1500001F
			Me.G2.HyperLink = Nothing
			Me.G2.Left = 1.551F
			Me.G2.Name = "G2"
			Me.G2.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G2.Text = ""
			Me.G2.Top = 7.050004F
			Me.G2.Visible = False
			Me.G2.Width = 0.675F
			Me.G3.Height = 0.15F
			Me.G3.HyperLink = Nothing
			Me.G3.Left = 2.245F
			Me.G3.Name = "G3"
			Me.G3.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G3.Text = ""
			Me.G3.Top = 7.050009F
			Me.G3.Visible = False
			Me.G3.Width = 0.675F
			Me.G4.Height = 0.15F
			Me.G4.HyperLink = Nothing
			Me.G4.Left = 2.943F
			Me.G4.Name = "G4"
			Me.G4.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G4.Text = ""
			Me.G4.Top = 7.050009F
			Me.G4.Visible = False
			Me.G4.Width = 0.675F
			Me.G5.Height = 0.15F
			Me.G5.HyperLink = Nothing
			Me.G5.Left = 3.646F
			Me.G5.Name = "G5"
			Me.G5.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G5.Text = ""
			Me.G5.Top = 7.050009F
			Me.G5.Visible = False
			Me.G5.Width = 0.675F
			Me.G6.Height = 0.15F
			Me.G6.HyperLink = Nothing
			Me.G6.Left = 4.346999F
			Me.G6.Name = "G6"
			Me.G6.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G6.Text = ""
			Me.G6.Top = 7.050009F
			Me.G6.Visible = False
			Me.G6.Width = 0.675F
			Me.G7.Height = 0.15F
			Me.G7.HyperLink = Nothing
			Me.G7.Left = 5.052999F
			Me.G7.Name = "G7"
			Me.G7.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G7.Text = ""
			Me.G7.Top = 7.050009F
			Me.G7.Visible = False
			Me.G7.Width = 0.675F
			Me.G8.Height = 0.15F
			Me.G8.HyperLink = Nothing
			Me.G8.Left = 5.765998F
			Me.G8.Name = "G8"
			Me.G8.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G8.Text = ""
			Me.G8.Top = 7.050009F
			Me.G8.Visible = False
			Me.G8.Width = 0.675F
			Me.G9.Height = 0.15F
			Me.G9.HyperLink = Nothing
			Me.G9.Left = 6.472998F
			Me.G9.Name = "G9"
			Me.G9.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G9.Text = ""
			Me.G9.Top = 7.050009F
			Me.G9.Visible = False
			Me.G9.Width = 0.675F
			Me.G10.Height = 0.15F
			Me.G10.HyperLink = Nothing
			Me.G10.Left = 7.178999F
			Me.G10.Name = "G10"
			Me.G10.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G10.Text = ""
			Me.G10.Top = 7.050009F
			Me.G10.Visible = False
			Me.G10.Width = 0.675F
			Me.G11.Height = 0.1500001F
			Me.G11.HyperLink = Nothing
			Me.G11.Left = 0.858F
			Me.G11.Name = "G11"
			Me.G11.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G11.Text = ""
			Me.G11.Top = 7.400001F
			Me.G11.Visible = False
			Me.G11.Width = 0.675F
			Me.G12.Height = 0.1500001F
			Me.G12.HyperLink = Nothing
			Me.G12.Left = 1.547F
			Me.G12.Name = "G12"
			Me.G12.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G12.Text = ""
			Me.G12.Top = 7.400001F
			Me.G12.Visible = False
			Me.G12.Width = 0.675F
			Me.G13.Height = 0.15F
			Me.G13.HyperLink = Nothing
			Me.G13.Left = 2.241F
			Me.G13.Name = "G13"
			Me.G13.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G13.Text = ""
			Me.G13.Top = 7.400001F
			Me.G13.Visible = False
			Me.G13.Width = 0.675F
			Me.G14.Height = 0.15F
			Me.G14.HyperLink = Nothing
			Me.G14.Left = 2.939F
			Me.G14.Name = "G14"
			Me.G14.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G14.Text = ""
			Me.G14.Top = 7.400001F
			Me.G14.Visible = False
			Me.G14.Width = 0.675F
			Me.G15.Height = 0.15F
			Me.G15.HyperLink = Nothing
			Me.G15.Left = 3.642F
			Me.G15.Name = "G15"
			Me.G15.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G15.Text = ""
			Me.G15.Top = 7.400001F
			Me.G15.Visible = False
			Me.G15.Width = 0.675F
			Me.G16.Height = 0.15F
			Me.G16.HyperLink = Nothing
			Me.G16.Left = 4.342999F
			Me.G16.Name = "G16"
			Me.G16.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G16.Text = ""
			Me.G16.Top = 7.400001F
			Me.G16.Visible = False
			Me.G16.Width = 0.675F
			Me.G17.Height = 0.15F
			Me.G17.HyperLink = Nothing
			Me.G17.Left = 5.048999F
			Me.G17.Name = "G17"
			Me.G17.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G17.Text = ""
			Me.G17.Top = 7.400001F
			Me.G17.Visible = False
			Me.G17.Width = 0.675F
			Me.G18.Height = 0.15F
			Me.G18.HyperLink = Nothing
			Me.G18.Left = 5.761998F
			Me.G18.Name = "G18"
			Me.G18.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G18.Text = ""
			Me.G18.Top = 7.400001F
			Me.G18.Visible = False
			Me.G18.Width = 0.675F
			Me.G19.Height = 0.15F
			Me.G19.HyperLink = Nothing
			Me.G19.Left = 6.468998F
			Me.G19.Name = "G19"
			Me.G19.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G19.Text = ""
			Me.G19.Top = 7.400001F
			Me.G19.Visible = False
			Me.G19.Width = 0.675F
			Me.G20.Height = 0.15F
			Me.G20.HyperLink = Nothing
			Me.G20.Left = 7.175F
			Me.G20.Name = "G20"
			Me.G20.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.G20.Text = ""
			Me.G20.Top = 7.400001F
			Me.G20.Visible = False
			Me.G20.Width = 0.675F
			Me.T11.Height = 0.1500001F
			Me.T11.HyperLink = Nothing
			Me.T11.Left = 0.864F
			Me.T11.Name = "T11"
			Me.T11.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T11.Text = ""
			Me.T11.Top = 7.248F
			Me.T11.Width = 0.675F
			Me.T12.Height = 0.1500001F
			Me.T12.HyperLink = Nothing
			Me.T12.Left = 1.553F
			Me.T12.Name = "T12"
			Me.T12.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T12.Text = ""
			Me.T12.Top = 7.248F
			Me.T12.Width = 0.675F
			Me.T13.Height = 0.15F
			Me.T13.HyperLink = Nothing
			Me.T13.Left = 2.247F
			Me.T13.Name = "T13"
			Me.T13.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T13.Text = ""
			Me.T13.Top = 7.248F
			Me.T13.Width = 0.675F
			Me.T14.Height = 0.15F
			Me.T14.HyperLink = Nothing
			Me.T14.Left = 2.945F
			Me.T14.Name = "T14"
			Me.T14.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T14.Text = ""
			Me.T14.Top = 7.248F
			Me.T14.Width = 0.675F
			Me.T15.Height = 0.15F
			Me.T15.HyperLink = Nothing
			Me.T15.Left = 3.648F
			Me.T15.Name = "T15"
			Me.T15.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T15.Text = ""
			Me.T15.Top = 7.248F
			Me.T15.Width = 0.675F
			Me.T16.Height = 0.15F
			Me.T16.HyperLink = Nothing
			Me.T16.Left = 4.349F
			Me.T16.Name = "T16"
			Me.T16.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T16.Text = ""
			Me.T16.Top = 7.248F
			Me.T16.Width = 0.675F
			Me.T17.Height = 0.15F
			Me.T17.HyperLink = Nothing
			Me.T17.Left = 5.054998F
			Me.T17.Name = "T17"
			Me.T17.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T17.Text = ""
			Me.T17.Top = 7.248F
			Me.T17.Width = 0.675F
			Me.T18.Height = 0.15F
			Me.T18.HyperLink = Nothing
			Me.T18.Left = 5.767998F
			Me.T18.Name = "T18"
			Me.T18.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T18.Text = ""
			Me.T18.Top = 7.248F
			Me.T18.Width = 0.675F
			Me.T19.Height = 0.15F
			Me.T19.HyperLink = Nothing
			Me.T19.Left = 6.474998F
			Me.T19.Name = "T19"
			Me.T19.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T19.Text = ""
			Me.T19.Top = 7.248F
			Me.T19.Width = 0.675F
			Me.T20.Height = 0.15F
			Me.T20.HyperLink = Nothing
			Me.T20.Left = 7.181F
			Me.T20.Name = "T20"
			Me.T20.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: left"
			Me.T20.Text = ""
			Me.T20.Top = 7.248F
			Me.T20.Width = 0.675F
			Me.PageFooter1.Height = 0.1F
			Me.PageFooter1.Name = "PageFooter1"
			Me.lblDiameters2.Height = 0.1499996F
			Me.lblDiameters2.HyperLink = Nothing
			Me.lblDiameters2.Left = 0.02F
			Me.lblDiameters2.Name = "lblDiameters2"
			Me.lblDiameters2.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: center"
			Me.lblDiameters2.Text = "Rod Diameters:"
			Me.lblDiameters2.Top = 7.248F
			Me.lblDiameters2.Width = 0.8200001F
			Me.lblNumGuidesPerRod2.Height = 0.1499996F
			Me.lblNumGuidesPerRod2.HyperLink = Nothing
			Me.lblNumGuidesPerRod2.Left = 0.02F
			Me.lblNumGuidesPerRod2.Name = "lblNumGuidesPerRod2"
			Me.lblNumGuidesPerRod2.Style = "font-family: Microsoft Sans Serif; font-size: 6pt; text-align: center"
			Me.lblNumGuidesPerRod2.Text = "# Guides/Rod:"
			Me.lblNumGuidesPerRod2.Top = 7.400001F
			Me.lblNumGuidesPerRod2.Visible = False
			Me.lblNumGuidesPerRod2.Width = 0.8200001F
			Me.MasterReport = False
			Me.PageSettings.Margins.Bottom = 0.9F
			Me.PageSettings.Margins.Left = 0F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0.9F
			Me.PageSettings.PaperHeight = 11F
			Me.PageSettings.PaperWidth = 8.5F
			Me.PrintWidth = 7.958333F
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
			CType(Me.picDevPlot, ISupportInitialize).EndInit()
			CType(Me.Picture_AB, ISupportInitialize).EndInit()
			CType(Me.Picture_MarkII, ISupportInitialize).EndInit()
			CType(Me.Picture_Hydraulic, ISupportInitialize).EndInit()
			CType(Me.Picture_rotaflex, ISupportInitialize).EndInit()
			CType(Me.Picture_Conv, ISupportInitialize).EndInit()
			CType(Me.Picture_BB, ISupportInitialize).EndInit()
			CType(Me.Picture_RM, ISupportInitialize).EndInit()
			CType(Me.Picture_blp, ISupportInitialize).EndInit()
			CType(Me.lblDiameters, ISupportInitialize).EndInit()
			CType(Me.T1, ISupportInitialize).EndInit()
			CType(Me.T2, ISupportInitialize).EndInit()
			CType(Me.T3, ISupportInitialize).EndInit()
			CType(Me.T4, ISupportInitialize).EndInit()
			CType(Me.T5, ISupportInitialize).EndInit()
			CType(Me.T6, ISupportInitialize).EndInit()
			CType(Me.T7, ISupportInitialize).EndInit()
			CType(Me.T8, ISupportInitialize).EndInit()
			CType(Me.T9, ISupportInitialize).EndInit()
			CType(Me.T10, ISupportInitialize).EndInit()
			CType(Me.lblNumGuidesPerRod, ISupportInitialize).EndInit()
			CType(Me.G1, ISupportInitialize).EndInit()
			CType(Me.G2, ISupportInitialize).EndInit()
			CType(Me.G3, ISupportInitialize).EndInit()
			CType(Me.G4, ISupportInitialize).EndInit()
			CType(Me.G5, ISupportInitialize).EndInit()
			CType(Me.G6, ISupportInitialize).EndInit()
			CType(Me.G7, ISupportInitialize).EndInit()
			CType(Me.G8, ISupportInitialize).EndInit()
			CType(Me.G9, ISupportInitialize).EndInit()
			CType(Me.G10, ISupportInitialize).EndInit()
			CType(Me.G11, ISupportInitialize).EndInit()
			CType(Me.G12, ISupportInitialize).EndInit()
			CType(Me.G13, ISupportInitialize).EndInit()
			CType(Me.G14, ISupportInitialize).EndInit()
			CType(Me.G15, ISupportInitialize).EndInit()
			CType(Me.G16, ISupportInitialize).EndInit()
			CType(Me.G17, ISupportInitialize).EndInit()
			CType(Me.G18, ISupportInitialize).EndInit()
			CType(Me.G19, ISupportInitialize).EndInit()
			CType(Me.G20, ISupportInitialize).EndInit()
			CType(Me.T11, ISupportInitialize).EndInit()
			CType(Me.T12, ISupportInitialize).EndInit()
			CType(Me.T13, ISupportInitialize).EndInit()
			CType(Me.T14, ISupportInitialize).EndInit()
			CType(Me.T15, ISupportInitialize).EndInit()
			CType(Me.T16, ISupportInitialize).EndInit()
			CType(Me.T17, ISupportInitialize).EndInit()
			CType(Me.T18, ISupportInitialize).EndInit()
			CType(Me.T19, ISupportInitialize).EndInit()
			CType(Me.T20, ISupportInitialize).EndInit()
			CType(Me.lblDiameters2, ISupportInitialize).EndInit()
			CType(Me.lblNumGuidesPerRod2, ISupportInitialize).EndInit()
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		Private Overridable Property picDevPlot As Picture
			Get
				Return Me._picDevPlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Picture)
				Me._picDevPlot = value
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

		Private Overridable Property lblDiameters As Label
			Get
				Return Me._lblDiameters
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDiameters = value
			End Set
		End Property

		Private Overridable Property T1 As Label
			Get
				Return Me._T1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T1 = value
			End Set
		End Property

		Private Overridable Property T2 As Label
			Get
				Return Me._T2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T2 = value
			End Set
		End Property

		Private Overridable Property T3 As Label
			Get
				Return Me._T3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T3 = value
			End Set
		End Property

		Private Overridable Property T4 As Label
			Get
				Return Me._T4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T4 = value
			End Set
		End Property

		Private Overridable Property T5 As Label
			Get
				Return Me._T5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T5 = value
			End Set
		End Property

		Private Overridable Property T6 As Label
			Get
				Return Me._T6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T6 = value
			End Set
		End Property

		Private Overridable Property T7 As Label
			Get
				Return Me._T7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T7 = value
			End Set
		End Property

		Private Overridable Property T8 As Label
			Get
				Return Me._T8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T8 = value
			End Set
		End Property

		Private Overridable Property T9 As Label
			Get
				Return Me._T9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T9 = value
			End Set
		End Property

		Private Overridable Property T10 As Label
			Get
				Return Me._T10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T10 = value
			End Set
		End Property

		Private Overridable Property Picture_AB As Picture
			Get
				Return Me._Picture_AB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Picture)
				Me._Picture_AB = value
			End Set
		End Property

		Private Overridable Property Picture_BB As Picture
			Get
				Return Me._Picture_BB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Picture)
				Me._Picture_BB = value
			End Set
		End Property

		Private Overridable Property Picture_rotaflex As Picture
			Get
				Return Me._Picture_rotaflex
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Picture)
				Me._Picture_rotaflex = value
			End Set
		End Property

		Private Overridable Property Picture_blp As Picture
			Get
				Return Me._Picture_blp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Picture)
				Me._Picture_blp = value
			End Set
		End Property

		Private Overridable Property Picture_MarkII As Picture
			Get
				Return Me._Picture_MarkII
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Picture)
				Me._Picture_MarkII = value
			End Set
		End Property

		Private Overridable Property Picture_RM As Picture
			Get
				Return Me._Picture_RM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Picture)
				Me._Picture_RM = value
			End Set
		End Property

		Private Overridable Property Picture_Conv As Picture
			Get
				Return Me._Picture_Conv
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Picture)
				Me._Picture_Conv = value
			End Set
		End Property

		Private Overridable Property Picture_Hydraulic As Picture
			Get
				Return Me._Picture_Hydraulic
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Picture)
				Me._Picture_Hydraulic = value
			End Set
		End Property

		Private Overridable Property lblNumGuidesPerRod As Label
			Get
				Return Me._lblNumGuidesPerRod
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuidesPerRod = value
			End Set
		End Property

		Private Overridable Property G1 As Label
			Get
				Return Me._G1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G1 = value
			End Set
		End Property

		Private Overridable Property G2 As Label
			Get
				Return Me._G2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G2 = value
			End Set
		End Property

		Private Overridable Property G3 As Label
			Get
				Return Me._G3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G3 = value
			End Set
		End Property

		Private Overridable Property G4 As Label
			Get
				Return Me._G4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G4 = value
			End Set
		End Property

		Private Overridable Property G5 As Label
			Get
				Return Me._G5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G5 = value
			End Set
		End Property

		Private Overridable Property G6 As Label
			Get
				Return Me._G6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G6 = value
			End Set
		End Property

		Private Overridable Property G7 As Label
			Get
				Return Me._G7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G7 = value
			End Set
		End Property

		Private Overridable Property G8 As Label
			Get
				Return Me._G8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G8 = value
			End Set
		End Property

		Private Overridable Property G9 As Label
			Get
				Return Me._G9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G9 = value
			End Set
		End Property

		Private Overridable Property G10 As Label
			Get
				Return Me._G10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G10 = value
			End Set
		End Property

		Private Overridable Property G11 As Label
			Get
				Return Me._G11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G11 = value
			End Set
		End Property

		Private Overridable Property G12 As Label
			Get
				Return Me._G12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G12 = value
			End Set
		End Property

		Private Overridable Property G13 As Label
			Get
				Return Me._G13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G13 = value
			End Set
		End Property

		Private Overridable Property G14 As Label
			Get
				Return Me._G14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G14 = value
			End Set
		End Property

		Private Overridable Property G15 As Label
			Get
				Return Me._G15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G15 = value
			End Set
		End Property

		Private Overridable Property G16 As Label
			Get
				Return Me._G16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G16 = value
			End Set
		End Property

		Private Overridable Property G17 As Label
			Get
				Return Me._G17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G17 = value
			End Set
		End Property

		Private Overridable Property G18 As Label
			Get
				Return Me._G18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G18 = value
			End Set
		End Property

		Private Overridable Property G19 As Label
			Get
				Return Me._G19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G19 = value
			End Set
		End Property

		Private Overridable Property G20 As Label
			Get
				Return Me._G20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._G20 = value
			End Set
		End Property

		Private Overridable Property T11 As Label
			Get
				Return Me._T11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T11 = value
			End Set
		End Property

		Private Overridable Property T12 As Label
			Get
				Return Me._T12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T12 = value
			End Set
		End Property

		Private Overridable Property T13 As Label
			Get
				Return Me._T13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T13 = value
			End Set
		End Property

		Private Overridable Property T14 As Label
			Get
				Return Me._T14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T14 = value
			End Set
		End Property

		Private Overridable Property T15 As Label
			Get
				Return Me._T15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T15 = value
			End Set
		End Property

		Private Overridable Property T16 As Label
			Get
				Return Me._T16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T16 = value
			End Set
		End Property

		Private Overridable Property T17 As Label
			Get
				Return Me._T17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T17 = value
			End Set
		End Property

		Private Overridable Property T18 As Label
			Get
				Return Me._T18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T18 = value
			End Set
		End Property

		Private Overridable Property T19 As Label
			Get
				Return Me._T19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T19 = value
			End Set
		End Property

		Private Overridable Property T20 As Label
			Get
				Return Me._T20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T20 = value
			End Set
		End Property

		Private Overridable Property lblDiameters2 As Label
			Get
				Return Me._lblDiameters2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDiameters2 = value
			End Set
		End Property

		Private Overridable Property lblNumGuidesPerRod2 As Label
			Get
				Return Me._lblNumGuidesPerRod2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuidesPerRod2 = value
			End Set
		End Property

		Public Sub ImportDevPlotChart()
			Try
				Dim sDevPlotFileName As String = RSWIN_DESC.sDevPlotFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sDevPlotFileName)
				RSWIN_DESC.sDevPlotFileName = sDevPlotFileName
				If flag Then
					Try
						Dim bitmap As Bitmap = New Bitmap(RSWIN_DESC.sDevPlotFileName)
						Dim bitmap2 As Bitmap = New Bitmap(bitmap)
						bitmap.Dispose()
						Me.picDevPlot.Image = CType(bitmap2.Clone(), Image)
						bitmap2.Dispose()
					Catch ex As Exception
					Finally
						Dim bitmap2 As Bitmap
						bitmap2.Dispose()
					End Try
					Try
						sDevPlotFileName = RSWIN_DESC.sDevPlotFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(sDevPlotFileName)
						RSWIN_DESC.sDevPlotFileName = sDevPlotFileName
						If flag2 Then
							FileSystem.Kill(RSWIN_DESC.sDevPlotFileName)
						End If
					Catch ex2 As Exception
					End Try
				End If
				Me.Picture_AB.Visible = False
				Me.Picture_BB.Visible = False
				Me.Picture_blp.Visible = False
				Me.Picture_Conv.Visible = False
				Me.Picture_MarkII.Visible = False
				Me.Picture_RM.Visible = False
				Me.Picture_rotaflex.Visible = False
				Me.Picture_Hydraulic.Visible = False
				If RSWIN_DESC.rst.PU.UnitType = 6S Then
					Me.Picture_AB.Visible = True
				ElseIf RSWIN_DESC.rst.PU.UnitType = 8S Then
					Me.Picture_BB.Visible = True
				ElseIf RSWIN_DESC.rst.PU.UnitType = 1S Then
					Me.Picture_Conv.Visible = True
				ElseIf RSWIN_DESC.rst.PU.UnitType = 5S Then
					Me.Picture_MarkII.Visible = True
				ElseIf RSWIN_DESC.rst.PU.UnitType = 2S Or Strings.InStr(RSWIN_DESC.rst.PU.Manuf, "Reverse Mark", CompareMethod.Binary) > 0 Then
					Me.Picture_RM.Visible = True
				ElseIf RSWIN_DESC.rst.PU.UnitType = 7S Then
					Me.Picture_rotaflex.Visible = True
				ElseIf RSWIN_DESC.rst.PU.UnitType = 8S Then
					Me.Picture_BB.Visible = True
				ElseIf RSWIN_DESC.rst.PU.UnitType = 10S Then
					Me.Picture_Hydraulic.Visible = True
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

		Public Property bPrint As Boolean
			Get
				Return Me.m_bPrint
			End Get
			Set(value As Boolean)
				Me.m_bPrint = value
			End Set
		End Property

		Public Sub rptDevSurvey3DPlot_ReportStart(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = False
				If Not Me.m_bPrint Then
					Me.PageSettings.Margins.Left = 0.25F
					Me.PageSettings.Margins.Right = 0F
					Me.PageSettings.Margins.Top = 0.25F
					Me.PageSettings.Margins.Bottom = 0F
				Else
					Me.PageSettings.Margins.Left = 0.25F
					Me.PageSettings.Margins.Right = 0F
					Me.PageSettings.Margins.Top = 0.1F
					Me.PageSettings.Margins.Bottom = 0F
				End If
				Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
				If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
					Me.lblNumGuidesPerRod.Visible = True
				End If
				Dim flag2 As Boolean = True
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If Not RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(i).Grade) Then
						flag2 = False
						Exit For
					End If
				Next
				flag2 = True
				Dim num2 As Integer = 1
				Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num2 To numRods2
					If Not RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(i).Grade) Then
						flag2 = False
						Exit For
					End If
				Next
				Dim num3 As Integer = 1
				Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For j As Integer = num3 To numRods3
					Dim teRodSizeList As teRodSizeList
					Try
						teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(RSWIN_DESC.rst.Sections(j).Grade, StdInfoConstants.RodGradeConstants)).RodSizeList
					Catch ex As Exception
						teRodSizeList = Nothing
					End Try
					Dim text As String
					If teRodSizeList IsNot Nothing Then
						Try
							For Each obj As Object In teRodSizeList
								Dim dictionaryEntry As DictionaryEntry
								Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
								Try
									If teRodSize.Diameter = RSWIN_DESC.rst.Sections(j).Diameter Then
										If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
											text = teRodSize.MetricDisplayName
										Else
											text = teRodSize.DisplayName
										End If
										flag = True
									End If
								Catch ex2 As Exception
								End Try
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If

						If Not flag Then
							If RODUTIL.IsCorodH(RSWIN_DESC.rst.Sections(j).Grade) Then
								text = "N/A"
							ElseIf RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(j).Grade) Then
								If RSWIN_DESC.rst.Sections(j).Diameter > 1F Then
									Dim num4 As Single = RSWIN_DESC.rst.Sections(j).Diameter * 16F
									Dim text2 As String = "0.0"
									text = Util.Format(num4, text2) + "/16"
								Else
									Dim num4 As Single = RSWIN_DESC.rst.Sections(j).Diameter * 16F
									Dim text2 As String = "0"
									text = Util.Format(num4, text2) + "/16"
								End If
								If Not flag2 And RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									text += """"
								End If
							ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
								Dim num5 As Integer = j
								Dim text3 As String = "0.0###"
								Dim str As String = Util.Format(sections(num5).Diameter, text3)
								Dim str2 As String = " ("
								Dim num4 As Single = RSWIN_DESC.rst.Sections(j).Diameter * RSWIN_DESC.IN__MM
								Dim text2 As String = "0.0"
								text = str + str2 + Util.Format(num4, text2) + " mm)"
							Else
								Dim sections2 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
								Dim num6 As Integer = j
								Dim text3 As String = "0.0###"
								text = Util.Format(sections2(num6).Diameter, text3)
							End If
						End If
						Select Case j
							Case 1
								text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T1.Text = text.PadRight(10, " "c)
								Me.T1.ForeColor = Color.Red
								Me.T1.Visible = True
							Case 2
								text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T2.Text = text.PadRight(10, " "c)
								Me.T2.ForeColor = Color.Green
								Me.T2.Left = CSng((CDbl((Me.T1.Left + Me.T1.Width)) + 0.01))
								Me.T2.Visible = True
							Case 3
								text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T3.Text = text.PadRight(10, " "c)
								Me.T3.ForeColor = Color.Blue
								Me.T3.Visible = True
								Me.T3.Left = CSng((CDbl((Me.T2.Left + Me.T2.Width)) + 0.01))
							Case 4
								text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T4.Text = text.PadRight(10, " "c)
								Me.T4.ForeColor = Color.Magenta
								Me.T4.Visible = True
								Me.T4.Left = CSng((CDbl((Me.T3.Left + Me.T3.Width)) + 0.01))
							Case 5
								text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T5.Text = text.PadRight(10, " "c)
								Me.T5.ForeColor = Color.MediumTurquoise
								Me.T5.Visible = True
								Me.T5.Left = CSng((CDbl((Me.T4.Left + Me.T4.Width)) + 0.01))
							Case 6
								text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T6.Text = text.PadRight(10, " "c)
								Me.T6.ForeColor = Color.Orange
								Me.T6.Visible = True
								Me.T6.Left = CSng((CDbl((Me.T5.Left + Me.T5.Width)) + 0.01))
							Case 7
								text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T7.Text = text.PadRight(10, " "c)
								Me.T7.ForeColor = Color.Purple
								Me.T7.Visible = True
								Me.T7.Left = CSng((CDbl((Me.T6.Left + Me.T6.Width)) + 0.01))
							Case 8
								text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T8.Text = text.PadRight(10, " "c)
								Me.T8.ForeColor = Color.Tan
								Me.T8.Visible = True
								Me.T8.Left = CSng((CDbl((Me.T7.Left + Me.T7.Width)) + 0.01))
							Case 9
								text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T9.Text = text.PadRight(10, " "c)
								Me.T9.ForeColor = Color.DarkRed
								Me.T9.Visible = True
								Me.T9.Left = CSng((CDbl((Me.T8.Left + Me.T8.Width)) + 0.01))
							Case 10
								Me.T10.Text = text.PadRight(10, " "c)
								Me.T10.ForeColor = Color.Gray
								Me.T10.Visible = True
								Me.T10.Left = CSng((CDbl((Me.T9.Left + Me.T9.Width)) + 0.01))
							Case 11
								Me.T11.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T11.ForeColor = Color.Red
								Me.T11.Left = Me.T1.Left
								Me.T11.Visible = True
							Case 12
								Me.T12.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T12.ForeColor = Color.Green
								Me.T12.Left = Me.T2.Left
								Me.T12.Visible = True
							Case 13
								Me.T13.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T13.ForeColor = Color.Blue
								Me.T13.Visible = True
								Me.T13.Left = Me.T3.Left
							Case 14
								Me.T14.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T14.ForeColor = Color.Magenta
								Me.T14.Visible = True
								Me.T14.Left = Me.T4.Left
							Case 15
								Me.T15.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T15.ForeColor = Color.MediumTurquoise
								Me.T15.Visible = True
								Me.T15.Left = Me.T5.Left
							Case 16
								Me.T16.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T16.ForeColor = Color.Orange
								Me.T16.Visible = True
								Me.T16.Left = Me.T6.Left
							Case 17
								Me.T17.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T17.ForeColor = Color.Purple
								Me.T17.Visible = True
								Me.T17.Left = Me.T7.Left
							Case 18
								Me.T18.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T18.ForeColor = Color.Tan
								Me.T18.Visible = True
								Me.T18.Left = Me.T8.Left
							Case 19
								Me.T19.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
								Me.T19.ForeColor = Color.DarkRed
								Me.T19.Visible = True
								Me.T19.Left = Me.T9.Left
							Case 20
								Me.T20.Text = text
								Me.T20.ForeColor = Color.Gray
								Me.T20.Left = Me.T10.Left
								Me.T20.Visible = True
						End Select
						If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
							text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(j).NumGuides))
							text = text.PadRight(10, " "c)
							Select Case j
								Case 1
									Me.G1.Text = text
									Me.G1.ForeColor = Color.Red
									Me.G1.Visible = True
									Me.G1.Left = Me.T1.Left
								Case 2
									Me.G2.Text = text
									Me.G2.ForeColor = Color.Green
									Me.G2.Visible = True
									Me.G2.Left = Me.T2.Left
								Case 3
									Me.G3.Text = text
									Me.G3.ForeColor = Color.Blue
									Me.G3.Visible = True
									Me.G3.Left = Me.T3.Left
								Case 4
									Me.G4.Text = text
									Me.G4.ForeColor = Color.Magenta
									Me.G4.Visible = True
									Me.G4.Left = Me.T4.Left
								Case 5
									Me.G5.Text = text
									Me.G5.ForeColor = Color.MediumTurquoise
									Me.G5.Visible = True
									Me.G5.Left = Me.T5.Left
								Case 6
									Me.G6.Text = text
									Me.G6.ForeColor = Color.Orange
									Me.G6.Visible = True
									Me.G6.Left = Me.T6.Left
								Case 7
									Me.G7.Text = text
									Me.G7.ForeColor = Color.Purple
									Me.G7.Visible = True
									Me.G7.Left = Me.T7.Left
								Case 8
									Me.G8.Text = text
									Me.G8.ForeColor = Color.Tan
									Me.G8.Visible = True
									Me.G8.Left = Me.T8.Left
								Case 9
									Me.G9.Text = text
									Me.G9.ForeColor = Color.DarkRed
									Me.G9.Visible = True
									Me.G9.Left = Me.T9.Left
								Case 10
									Me.G10.Text = text
									Me.G10.ForeColor = Color.Gray
									Me.G10.Visible = True
									Me.G10.Left = Me.T10.Left
								Case 11
									Me.G11.Text = text
									Me.G11.ForeColor = Color.Red
									Me.G11.Visible = True
									Me.G11.Left = Me.T11.Left
								Case 12
									Me.G12.Text = text
									Me.G12.ForeColor = Color.Green
									Me.G12.Visible = True
									Me.G12.Left = Me.T12.Left
								Case 13
									Me.G13.Text = text
									Me.G13.ForeColor = Color.Blue
									Me.G13.Visible = True
									Me.G13.Left = Me.T13.Left
								Case 14
									Me.G14.Text = text
									Me.G14.ForeColor = Color.Magenta
									Me.G14.Visible = True
									Me.G14.Left = Me.T14.Left
								Case 15
									Me.G15.Text = text
									Me.G15.ForeColor = Color.MediumTurquoise
									Me.G15.Visible = True
									Me.G15.Left = Me.T15.Left
								Case 16
									Me.G16.Text = text
									Me.G16.ForeColor = Color.Orange
									Me.G16.Visible = True
									Me.G16.Left = Me.T16.Left
								Case 17
									Me.G17.Text = text
									Me.G17.ForeColor = Color.Purple
									Me.G17.Visible = True
									Me.G17.Left = Me.T17.Left
								Case 18
									Me.G18.Text = text
									Me.G18.ForeColor = Color.Tan
									Me.G18.Visible = True
									Me.G18.Left = Me.T18.Left
								Case 19
									Me.G19.Text = text
									Me.G19.ForeColor = Color.DarkRed
									Me.G19.Visible = True
									Me.G19.Left = Me.T19.Left
								Case 20
									Me.G20.Text = text
									Me.G20.ForeColor = Color.Gray
									Me.G20.Visible = True
									Me.G20.Left = Me.T20.Left
							End Select
						End If

				Next
				If RSWIN_DESC.rst.NumRods > 10S Then
					Me.lblDiameters2.Visible = True
					Me.lblNumGuidesPerRod2.Visible = True
				Else
					Me.lblDiameters2.Visible = False
					Me.lblNumGuidesPerRod2.Visible = False
				End If
				Me.ImportDevPlotChart()
				Try
					If RSWIN_DESC.bIntVersion Then
						If RSWIN_DESC.bWriteResXFile Then
							Util.OpenResourceWriter("rptDevSurvey3DPlot")
							Me.WriteControlStrings()
							Util.CloseResourceWriter()
						End If
						If RSWIN_DESC.bReadResXFile Then
							Me.ReadReportControlStrings()
						End If
					End If
				Catch ex3 As Exception
				End Try
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub SummHeader(iPage As Integer, nPages As Integer)
			Dim text As String = New String(" "c, 112)
			RSWIN_DESC.sNull = ""
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim text2 As String = RSWIN_DESC.sProgramLongName
			Dim text3 As String = ""
			If Strings.Len(text3) > 0 Then
				text2 = text2 + " (SN#" + text3 + ")"
			End If
			If Strings.Len(Util.Licensee()) > 0 Then
				text2 = text2 + Me.sLicenseTo + Util.Licensee()
			End If
			If(If((-If((Not RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) Or Not RSWIN_DESC.SETUP_UseImpred) <> 0S Then
				text2 = text2.Replace("-D", "")
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
			If Information.IsDate(rst.UserDate) Then
				Me.lblUserDate.Text = Me.sDate + Convert.ToDateTime(rst.UserDate).ToShortDateString()
			Else
				Me.lblUserDate.Text = Me.sDate + rst.UserDate
			End If
			Me.lblComment.Text = Me.sComment + rst.FileComment
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
			Me.SetPumpingUnitTop()
		End Sub

		Private Sub SetPumpingUnitTop()
			Try
				If Not RSWIN_DESC.bHasGuides Then
					Me.Picture_AB.Top = CSng((CDbl(Me.Picture_AB.Top) + 0.08))
					Me.Picture_BB.Top = CSng((CDbl(Me.Picture_BB.Top) + 0.08))
					Me.Picture_blp.Top = CSng((CDbl(Me.Picture_blp.Top) + 0.08))
					Me.Picture_Conv.Top = CSng((CDbl(Me.Picture_Conv.Top) + 0.08))
					Me.Picture_Hydraulic.Top = CSng((CDbl(Me.Picture_Hydraulic.Top) + 0.08))
					Me.Picture_MarkII.Top = CSng((CDbl(Me.Picture_MarkII.Top) + 0.08))
					Me.Picture_RM.Top = CSng((CDbl(Me.Picture_RM.Top) + 0.08))
					Me.Picture_rotaflex.Top = CSng((CDbl(Me.Picture_rotaflex.Top) + 0.08))
					Me.Picture_AB.Left = CSng((CDbl(Me.Picture_AB.Left) + 0.08))
					Me.Picture_BB.Left = CSng((CDbl(Me.Picture_BB.Left) + 0.08))
					Me.Picture_blp.Left = CSng((CDbl(Me.Picture_blp.Left) + 0.08))
					Me.Picture_Conv.Left = CSng((CDbl(Me.Picture_Conv.Left) + 0.08))
					Me.Picture_Hydraulic.Left = CSng((CDbl(Me.Picture_Hydraulic.Left) + 0.08))
					Me.Picture_MarkII.Left = CSng((CDbl(Me.Picture_MarkII.Left) + 0.08))
					Me.Picture_RM.Left = CSng((CDbl(Me.Picture_RM.Left) + 0.08))
					Me.Picture_rotaflex.Left = CSng((CDbl(Me.Picture_rotaflex.Left) + 0.08))
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub WriteControlStrings()
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = Me.Detail1.Controls.Count - 1
				For i As Integer = num To num2
					Try
						If Me.Detail1.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.Detail1.Controls(i), Label)
							If Operators.CompareString(label.Name.Substring(0, Me.slbl.Length), Me.slbl, False) = 0 Then
								Me.AddRexResource(label.Name, label.Text)
							End If
						End If
					Catch ex As Exception
						Debug.WriteLine(ex.Message)
					End Try
				Next
				Dim num3 As Integer = 0
				Dim num4 As Integer = Me.PageHeader1.Controls.Count - 1
				For i As Integer = num3 To num4
					Try
						If Me.PageHeader1.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.PageHeader1.Controls(i), Label)
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

		Private Sub ReadReportControlStrings()
			Dim sPrefix As String = "rptDevSurvey3DPlot-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = Me.PageHeader1.Controls.Count - 1
				For i As Integer = num To num2
					Try
						If Me.PageHeader1.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.PageHeader1.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex As Exception
					End Try
				Next
				Dim num3 As Integer = 0
				Dim num4 As Integer = Me.PageFooter1.Controls.Count - 1
				For i As Integer = num3 To num4
					Try
						If Me.PageFooter1.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.PageFooter1.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex2 As Exception
					End Try
				Next
				Dim num5 As Integer = 0
				Dim num6 As Integer = Me.Detail1.Controls.Count - 1
				For i As Integer = num5 To num6
					Try
						If Me.Detail1.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.Detail1.Controls(i), Label)
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

		<AccessedThroughProperty("PageHeader1")>
		Private _PageHeader1 As PageHeader

		<AccessedThroughProperty("Detail1")>
		Private _Detail1 As Detail

		<AccessedThroughProperty("PageFooter1")>
		Private _PageFooter1 As PageFooter

		<AccessedThroughProperty("picDevPlot")>
		Private _picDevPlot As Picture

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

		<AccessedThroughProperty("lblDiameters")>
		Private _lblDiameters As Label

		<AccessedThroughProperty("T1")>
		Private _T1 As Label

		<AccessedThroughProperty("T2")>
		Private _T2 As Label

		<AccessedThroughProperty("T3")>
		Private _T3 As Label

		<AccessedThroughProperty("T4")>
		Private _T4 As Label

		<AccessedThroughProperty("T5")>
		Private _T5 As Label

		<AccessedThroughProperty("T6")>
		Private _T6 As Label

		<AccessedThroughProperty("T7")>
		Private _T7 As Label

		<AccessedThroughProperty("T8")>
		Private _T8 As Label

		<AccessedThroughProperty("T9")>
		Private _T9 As Label

		<AccessedThroughProperty("T10")>
		Private _T10 As Label

		<AccessedThroughProperty("Picture_AB")>
		Private _Picture_AB As Picture

		<AccessedThroughProperty("Picture_BB")>
		Private _Picture_BB As Picture

		<AccessedThroughProperty("Picture_rotaflex")>
		Private _Picture_rotaflex As Picture

		<AccessedThroughProperty("Picture_blp")>
		Private _Picture_blp As Picture

		<AccessedThroughProperty("Picture_MarkII")>
		Private _Picture_MarkII As Picture

		<AccessedThroughProperty("Picture_RM")>
		Private _Picture_RM As Picture

		<AccessedThroughProperty("Picture_Conv")>
		Private _Picture_Conv As Picture

		<AccessedThroughProperty("Picture_Hydraulic")>
		Private _Picture_Hydraulic As Picture

		<AccessedThroughProperty("lblNumGuidesPerRod")>
		Private _lblNumGuidesPerRod As Label

		<AccessedThroughProperty("G1")>
		Private _G1 As Label

		<AccessedThroughProperty("G2")>
		Private _G2 As Label

		<AccessedThroughProperty("G3")>
		Private _G3 As Label

		<AccessedThroughProperty("G4")>
		Private _G4 As Label

		<AccessedThroughProperty("G5")>
		Private _G5 As Label

		<AccessedThroughProperty("G6")>
		Private _G6 As Label

		<AccessedThroughProperty("G7")>
		Private _G7 As Label

		<AccessedThroughProperty("G8")>
		Private _G8 As Label

		<AccessedThroughProperty("G9")>
		Private _G9 As Label

		<AccessedThroughProperty("G10")>
		Private _G10 As Label

		<AccessedThroughProperty("G11")>
		Private _G11 As Label

		<AccessedThroughProperty("G12")>
		Private _G12 As Label

		<AccessedThroughProperty("G13")>
		Private _G13 As Label

		<AccessedThroughProperty("G14")>
		Private _G14 As Label

		<AccessedThroughProperty("G15")>
		Private _G15 As Label

		<AccessedThroughProperty("G16")>
		Private _G16 As Label

		<AccessedThroughProperty("G17")>
		Private _G17 As Label

		<AccessedThroughProperty("G18")>
		Private _G18 As Label

		<AccessedThroughProperty("G19")>
		Private _G19 As Label

		<AccessedThroughProperty("G20")>
		Private _G20 As Label

		<AccessedThroughProperty("T11")>
		Private _T11 As Label

		<AccessedThroughProperty("T12")>
		Private _T12 As Label

		<AccessedThroughProperty("T13")>
		Private _T13 As Label

		<AccessedThroughProperty("T14")>
		Private _T14 As Label

		<AccessedThroughProperty("T15")>
		Private _T15 As Label

		<AccessedThroughProperty("T16")>
		Private _T16 As Label

		<AccessedThroughProperty("T17")>
		Private _T17 As Label

		<AccessedThroughProperty("T18")>
		Private _T18 As Label

		<AccessedThroughProperty("T19")>
		Private _T19 As Label

		<AccessedThroughProperty("T20")>
		Private _T20 As Label

		<AccessedThroughProperty("lblDiameters2")>
		Private _lblDiameters2 As Label

		<AccessedThroughProperty("lblNumGuidesPerRod2")>
		Private _lblNumGuidesPerRod2 As Label

		Private slbl As String

		Private sCompany As String

		Private sWell As String

		Private sUser As String

		Private sDiskFile As String

		Private sDate As String

		Private sPage As String

		Private sOf As String

		Private sComment As String

		Private sThetaEnterprises As String

		Private sLicenseTo As String

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer

		Private m_bPrint As Boolean
	End Class
End Namespace
