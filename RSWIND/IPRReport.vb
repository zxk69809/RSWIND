Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports DDCssLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class IPRReport
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.rptIPR_ReportStart
			Me.PageHeader = Nothing
			Me.GroupHeader1 = Nothing
			Me.Detail = Nothing
			Me.GroupFooter1 = Nothing
			Me.PageFooter = Nothing
			Me.lblLabel2 = Nothing
			Me.lblCompany = Nothing
			Me.lblWellName = Nothing
			Me.lblDiskFile = Nothing
			Me.lblComment = Nothing
			Me.lblTitle1 = Nothing
			Me.lblPage = Nothing
			Me.txtPage1 = Nothing
			Me.lblOf = Nothing
			Me.txtPage2 = Nothing
			Me.lblUserName = Nothing
			Me.lblUserDate = Nothing
			Me.lblSecondCompanyName = Nothing
			Me.lblSecondCompanyPhonenumber = Nothing
			Me.lblGoTheta = Nothing
			Me.picIPR = Nothing
			Me.lblHeader1 = Nothing
			Me.lblHeader2 = Nothing
			Me.lblInflowPerformanceData = Nothing
			Me.lblMidPerfDepth = Nothing
			Me.lblStaticBottomholePressure = Nothing
			Me.lblBubblePointPressure = Nothing
			Me.lblPressureTestPoints = Nothing
			Me.lblPumpIntakePressure = Nothing
			Me.lblFlowingBHPressure = Nothing
			Me.lblProduction = Nothing
			Me.Line2 = Nothing
			Me.Line3 = Nothing
			Me.Label1 = Nothing
			Me.lblFluidLevelOverPump = Nothing
			Me.lblProdPIP = Nothing
			Me.lblProdBH = Nothing
			Me.Line4 = Nothing
			Me.Line5 = Nothing
			Me.Line6 = Nothing
			Me.lblTotalOil = Nothing
			Me.lblTotalWater = Nothing
			Me.lblTotalFluid = Nothing
			Me.Line7 = Nothing
			Me.Line8 = Nothing
			Me.Line9 = Nothing
			Me.Line10 = Nothing
			Me.lblPerfNote = Nothing
			Me.lblTestPIP_1 = Nothing
			Me.lblTestPIP_2 = Nothing
			Me.lblTestPIP_3 = Nothing
			Me.lblTestPIP_4 = Nothing
			Me.lblTestPIP_5 = Nothing
			Me.lblTestPIP_6 = Nothing
			Me.lblTestPIP_7 = Nothing
			Me.lblTestPIP_8 = Nothing
			Me.lblTestPIP_9 = Nothing
			Me.lblTestPIP_10 = Nothing
			Me.lblTestBH_1 = Nothing
			Me.lblTestBH_2 = Nothing
			Me.lblTestBH_3 = Nothing
			Me.lblTestBH_4 = Nothing
			Me.lblTestBH_5 = Nothing
			Me.lblTestBH_6 = Nothing
			Me.lblTestBH_7 = Nothing
			Me.lblTestBH_8 = Nothing
			Me.lblTestBH_9 = Nothing
			Me.lblTestBH_10 = Nothing
			Me.Line1 = Nothing
			Me.lblTestProd_1 = Nothing
			Me.lblTestProd_2 = Nothing
			Me.lblTestProd_3 = Nothing
			Me.lblTestProd_4 = Nothing
			Me.lblTestProd_5 = Nothing
			Me.lblTestProd_6 = Nothing
			Me.lblTestProd_7 = Nothing
			Me.lblTestProd_8 = Nothing
			Me.lblTestProd_9 = Nothing
			Me.lblTestProd_10 = Nothing
			Me.lblProdPIP_1 = Nothing
			Me.lblProdPIP_2 = Nothing
			Me.lblProdPIP_3 = Nothing
			Me.lblProdPIP_4 = Nothing
			Me.lblProdPIP_5 = Nothing
			Me.lblProdPIP_6 = Nothing
			Me.lblProdPIP_7 = Nothing
			Me.lblProdPIP_8 = Nothing
			Me.lblProdPIP_9 = Nothing
			Me.lblProdPIP_10 = Nothing
			Me.lblProdFL_1 = Nothing
			Me.lblProdFL_2 = Nothing
			Me.lblProdFL_3 = Nothing
			Me.lblProdFL_4 = Nothing
			Me.lblProdFL_5 = Nothing
			Me.lblProdFL_6 = Nothing
			Me.lblProdFL_7 = Nothing
			Me.lblProdFL_8 = Nothing
			Me.lblProdFL_9 = Nothing
			Me.lblProdFL_10 = Nothing
			Me.lblProdBH_1 = Nothing
			Me.lblProdBH_2 = Nothing
			Me.lblProdBH_3 = Nothing
			Me.lblProdBH_4 = Nothing
			Me.lblProdBH_5 = Nothing
			Me.lblProdBH_6 = Nothing
			Me.lblProdBH_7 = Nothing
			Me.lblProdBH_8 = Nothing
			Me.lblProdBH_9 = Nothing
			Me.lblProdBH_10 = Nothing
			Me.lblTotalOil_1 = Nothing
			Me.lblTotalOil_2 = Nothing
			Me.lblTotalOil_3 = Nothing
			Me.lblTotalOil_4 = Nothing
			Me.lblTotalOil_5 = Nothing
			Me.lblTotalOil_6 = Nothing
			Me.lblTotalOil_7 = Nothing
			Me.lblTotalOil_8 = Nothing
			Me.lblTotalOil_9 = Nothing
			Me.lblTotalOil_10 = Nothing
			Me.lblTotalWater_1 = Nothing
			Me.lblTotalWater_2 = Nothing
			Me.lblTotalWater_3 = Nothing
			Me.lblTotalWater_4 = Nothing
			Me.lblTotalWater_5 = Nothing
			Me.lblTotalWater_6 = Nothing
			Me.lblTotalWater_7 = Nothing
			Me.lblTotalWater_8 = Nothing
			Me.lblTotalWater_9 = Nothing
			Me.lblTotalWater_10 = Nothing
			Me.lblTotalFluid_1 = Nothing
			Me.lblTotalFluid_2 = Nothing
			Me.lblTotalFluid_3 = Nothing
			Me.lblTotalFluid_4 = Nothing
			Me.lblTotalFluid_5 = Nothing
			Me.lblTotalFluid_6 = Nothing
			Me.lblTotalFluid_7 = Nothing
			Me.lblTotalFluid_8 = Nothing
			Me.lblTotalFluid_9 = Nothing
			Me.lblTotalFluid_10 = Nothing
			Me.lblProdNote = Nothing
			Me.lblProdFL_11 = Nothing
			Me.lblProdFL_14 = Nothing
			Me.lblProdFL_13 = Nothing
			Me.lblProdFL_12 = Nothing
			Me.lblProdPIP_11 = Nothing
			Me.lblProdPIP_12 = Nothing
			Me.lblProdPIP_13 = Nothing
			Me.lblProdPIP_14 = Nothing
			Me.lblProdBH_14 = Nothing
			Me.lblProdBH_13 = Nothing
			Me.lblProdBH_12 = Nothing
			Me.lblProdBH_11 = Nothing
			Me.lblTotalOil_11 = Nothing
			Me.lblTotalOil_12 = Nothing
			Me.lblTotalOil_13 = Nothing
			Me.lblTotalOil_14 = Nothing
			Me.lblTotalWater_14 = Nothing
			Me.lblTotalWater_13 = Nothing
			Me.lblTotalWater_12 = Nothing
			Me.lblTotalWater_11 = Nothing
			Me.lblTotalFluid_11 = Nothing
			Me.lblTotalFluid_12 = Nothing
			Me.lblTotalFluid_13 = Nothing
			Me.lblTotalFluid_14 = Nothing
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

		Private Overridable Property PageHeader As PageHeader
			Get
				Return Me._PageHeader
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PageHeader)
				Dim value2 As EventHandler = AddressOf Me.PageHeader_Format
				If Me._PageHeader IsNot Nothing Then
					RemoveHandler Me._PageHeader.Format, value2
				End If
				Me._PageHeader = value
				If Me._PageHeader IsNot Nothing Then
					AddHandler Me._PageHeader.Format, value2
				End If
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
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(IPRReport))
			Me.Detail = New Detail()
			Me.PageHeader = New PageHeader()
			Me.PageFooter = New PageFooter()
			Me.GroupHeader1 = New GroupHeader()
			Me.GroupFooter1 = New GroupFooter()
			Me.lblLabel2 = New DataDynamics.ActiveReports.Label()
			Me.lblCompany = New DataDynamics.ActiveReports.Label()
			Me.lblWellName = New DataDynamics.ActiveReports.Label()
			Me.lblDiskFile = New DataDynamics.ActiveReports.Label()
			Me.lblComment = New DataDynamics.ActiveReports.Label()
			Me.lblTitle1 = New DataDynamics.ActiveReports.Label()
			Me.lblPage = New DataDynamics.ActiveReports.Label()
			Me.txtPage1 = New DataDynamics.ActiveReports.TextBox()
			Me.lblOf = New DataDynamics.ActiveReports.Label()
			Me.txtPage2 = New DataDynamics.ActiveReports.TextBox()
			Me.lblUserName = New DataDynamics.ActiveReports.Label()
			Me.lblUserDate = New DataDynamics.ActiveReports.Label()
			Me.lblSecondCompanyName = New DataDynamics.ActiveReports.Label()
			Me.lblSecondCompanyPhonenumber = New DataDynamics.ActiveReports.Label()
			Me.lblGoTheta = New DataDynamics.ActiveReports.Label()
			Me.picIPR = New Picture()
			Me.lblHeader1 = New DataDynamics.ActiveReports.Label()
			Me.lblHeader2 = New DataDynamics.ActiveReports.Label()
			Me.lblInflowPerformanceData = New DataDynamics.ActiveReports.Label()
			Me.lblMidPerfDepth = New DataDynamics.ActiveReports.Label()
			Me.lblStaticBottomholePressure = New DataDynamics.ActiveReports.Label()
			Me.lblBubblePointPressure = New DataDynamics.ActiveReports.Label()
			Me.lblPressureTestPoints = New DataDynamics.ActiveReports.Label()
			Me.lblPumpIntakePressure = New DataDynamics.ActiveReports.Label()
			Me.lblFlowingBHPressure = New DataDynamics.ActiveReports.Label()
			Me.lblProduction = New DataDynamics.ActiveReports.Label()
			Me.Line2 = New Line()
			Me.Line3 = New Line()
			Me.Label1 = New DataDynamics.ActiveReports.Label()
			Me.lblFluidLevelOverPump = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH = New DataDynamics.ActiveReports.Label()
			Me.Line4 = New Line()
			Me.Line5 = New Line()
			Me.Line6 = New Line()
			Me.lblTotalOil = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid = New DataDynamics.ActiveReports.Label()
			Me.Line7 = New Line()
			Me.Line8 = New Line()
			Me.Line9 = New Line()
			Me.Line10 = New Line()
			Me.lblPerfNote = New DataDynamics.ActiveReports.Label()
			Me.lblTestPIP_1 = New DataDynamics.ActiveReports.Label()
			Me.lblTestPIP_2 = New DataDynamics.ActiveReports.Label()
			Me.lblTestPIP_3 = New DataDynamics.ActiveReports.Label()
			Me.lblTestPIP_4 = New DataDynamics.ActiveReports.Label()
			Me.lblTestPIP_5 = New DataDynamics.ActiveReports.Label()
			Me.lblTestPIP_6 = New DataDynamics.ActiveReports.Label()
			Me.lblTestPIP_7 = New DataDynamics.ActiveReports.Label()
			Me.lblTestPIP_8 = New DataDynamics.ActiveReports.Label()
			Me.lblTestPIP_9 = New DataDynamics.ActiveReports.Label()
			Me.lblTestPIP_10 = New DataDynamics.ActiveReports.Label()
			Me.lblTestBH_1 = New DataDynamics.ActiveReports.Label()
			Me.lblTestBH_2 = New DataDynamics.ActiveReports.Label()
			Me.lblTestBH_3 = New DataDynamics.ActiveReports.Label()
			Me.lblTestBH_4 = New DataDynamics.ActiveReports.Label()
			Me.lblTestBH_5 = New DataDynamics.ActiveReports.Label()
			Me.lblTestBH_6 = New DataDynamics.ActiveReports.Label()
			Me.lblTestBH_7 = New DataDynamics.ActiveReports.Label()
			Me.lblTestBH_8 = New DataDynamics.ActiveReports.Label()
			Me.lblTestBH_9 = New DataDynamics.ActiveReports.Label()
			Me.lblTestBH_10 = New DataDynamics.ActiveReports.Label()
			Me.Line1 = New Line()
			Me.lblTestProd_1 = New DataDynamics.ActiveReports.Label()
			Me.lblTestProd_2 = New DataDynamics.ActiveReports.Label()
			Me.lblTestProd_3 = New DataDynamics.ActiveReports.Label()
			Me.lblTestProd_4 = New DataDynamics.ActiveReports.Label()
			Me.lblTestProd_5 = New DataDynamics.ActiveReports.Label()
			Me.lblTestProd_6 = New DataDynamics.ActiveReports.Label()
			Me.lblTestProd_7 = New DataDynamics.ActiveReports.Label()
			Me.lblTestProd_8 = New DataDynamics.ActiveReports.Label()
			Me.lblTestProd_9 = New DataDynamics.ActiveReports.Label()
			Me.lblTestProd_10 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_1 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_2 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_3 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_4 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_5 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_6 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_7 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_8 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_9 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_10 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_1 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_2 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_3 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_4 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_5 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_6 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_7 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_8 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_9 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_10 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_1 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_2 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_3 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_4 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_5 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_6 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_7 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_8 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_9 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_10 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_1 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_2 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_3 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_4 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_5 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_6 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_7 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_8 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_9 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_10 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_1 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_2 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_3 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_4 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_5 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_6 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_7 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_8 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_9 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_10 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_1 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_2 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_3 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_4 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_5 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_6 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_7 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_8 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_9 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_10 = New DataDynamics.ActiveReports.Label()
			Me.lblProdNote = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_11 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_14 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_13 = New DataDynamics.ActiveReports.Label()
			Me.lblProdFL_12 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_11 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_12 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_13 = New DataDynamics.ActiveReports.Label()
			Me.lblProdPIP_14 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_14 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_13 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_12 = New DataDynamics.ActiveReports.Label()
			Me.lblProdBH_11 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_11 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_12 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_13 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalOil_14 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_14 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_13 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_12 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalWater_11 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_11 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_12 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_13 = New DataDynamics.ActiveReports.Label()
			Me.lblTotalFluid_14 = New DataDynamics.ActiveReports.Label()
			CType(Me.lblLabel2, ISupportInitialize).BeginInit()
			CType(Me.lblCompany, ISupportInitialize).BeginInit()
			CType(Me.lblWellName, ISupportInitialize).BeginInit()
			CType(Me.lblDiskFile, ISupportInitialize).BeginInit()
			CType(Me.lblComment, ISupportInitialize).BeginInit()
			CType(Me.lblTitle1, ISupportInitialize).BeginInit()
			CType(Me.lblPage, ISupportInitialize).BeginInit()
			CType(Me.txtPage1, ISupportInitialize).BeginInit()
			CType(Me.lblOf, ISupportInitialize).BeginInit()
			CType(Me.txtPage2, ISupportInitialize).BeginInit()
			CType(Me.lblUserName, ISupportInitialize).BeginInit()
			CType(Me.lblUserDate, ISupportInitialize).BeginInit()
			CType(Me.lblSecondCompanyName, ISupportInitialize).BeginInit()
			CType(Me.lblSecondCompanyPhonenumber, ISupportInitialize).BeginInit()
			CType(Me.lblGoTheta, ISupportInitialize).BeginInit()
			CType(Me.picIPR, ISupportInitialize).BeginInit()
			CType(Me.lblHeader1, ISupportInitialize).BeginInit()
			CType(Me.lblHeader2, ISupportInitialize).BeginInit()
			CType(Me.lblInflowPerformanceData, ISupportInitialize).BeginInit()
			CType(Me.lblMidPerfDepth, ISupportInitialize).BeginInit()
			CType(Me.lblStaticBottomholePressure, ISupportInitialize).BeginInit()
			CType(Me.lblBubblePointPressure, ISupportInitialize).BeginInit()
			CType(Me.lblPressureTestPoints, ISupportInitialize).BeginInit()
			CType(Me.lblPumpIntakePressure, ISupportInitialize).BeginInit()
			CType(Me.lblFlowingBHPressure, ISupportInitialize).BeginInit()
			CType(Me.lblProduction, ISupportInitialize).BeginInit()
			CType(Me.Label1, ISupportInitialize).BeginInit()
			CType(Me.lblFluidLevelOverPump, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid, ISupportInitialize).BeginInit()
			CType(Me.lblPerfNote, ISupportInitialize).BeginInit()
			CType(Me.lblTestPIP_1, ISupportInitialize).BeginInit()
			CType(Me.lblTestPIP_2, ISupportInitialize).BeginInit()
			CType(Me.lblTestPIP_3, ISupportInitialize).BeginInit()
			CType(Me.lblTestPIP_4, ISupportInitialize).BeginInit()
			CType(Me.lblTestPIP_5, ISupportInitialize).BeginInit()
			CType(Me.lblTestPIP_6, ISupportInitialize).BeginInit()
			CType(Me.lblTestPIP_7, ISupportInitialize).BeginInit()
			CType(Me.lblTestPIP_8, ISupportInitialize).BeginInit()
			CType(Me.lblTestPIP_9, ISupportInitialize).BeginInit()
			CType(Me.lblTestPIP_10, ISupportInitialize).BeginInit()
			CType(Me.lblTestBH_1, ISupportInitialize).BeginInit()
			CType(Me.lblTestBH_2, ISupportInitialize).BeginInit()
			CType(Me.lblTestBH_3, ISupportInitialize).BeginInit()
			CType(Me.lblTestBH_4, ISupportInitialize).BeginInit()
			CType(Me.lblTestBH_5, ISupportInitialize).BeginInit()
			CType(Me.lblTestBH_6, ISupportInitialize).BeginInit()
			CType(Me.lblTestBH_7, ISupportInitialize).BeginInit()
			CType(Me.lblTestBH_8, ISupportInitialize).BeginInit()
			CType(Me.lblTestBH_9, ISupportInitialize).BeginInit()
			CType(Me.lblTestBH_10, ISupportInitialize).BeginInit()
			CType(Me.lblTestProd_1, ISupportInitialize).BeginInit()
			CType(Me.lblTestProd_2, ISupportInitialize).BeginInit()
			CType(Me.lblTestProd_3, ISupportInitialize).BeginInit()
			CType(Me.lblTestProd_4, ISupportInitialize).BeginInit()
			CType(Me.lblTestProd_5, ISupportInitialize).BeginInit()
			CType(Me.lblTestProd_6, ISupportInitialize).BeginInit()
			CType(Me.lblTestProd_7, ISupportInitialize).BeginInit()
			CType(Me.lblTestProd_8, ISupportInitialize).BeginInit()
			CType(Me.lblTestProd_9, ISupportInitialize).BeginInit()
			CType(Me.lblTestProd_10, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_1, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_2, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_3, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_4, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_5, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_6, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_7, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_8, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_9, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_10, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_1, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_2, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_3, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_4, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_5, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_6, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_7, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_8, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_9, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_10, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_1, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_2, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_3, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_4, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_5, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_6, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_7, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_8, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_9, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_10, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_1, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_2, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_3, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_4, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_5, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_6, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_7, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_8, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_9, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_10, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_1, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_2, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_3, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_4, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_5, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_6, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_7, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_8, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_9, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_10, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_1, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_2, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_3, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_4, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_5, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_6, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_7, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_8, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_9, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_10, ISupportInitialize).BeginInit()
			CType(Me.lblProdNote, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_11, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_14, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_13, ISupportInitialize).BeginInit()
			CType(Me.lblProdFL_12, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_11, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_12, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_13, ISupportInitialize).BeginInit()
			CType(Me.lblProdPIP_14, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_14, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_13, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_12, ISupportInitialize).BeginInit()
			CType(Me.lblProdBH_11, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_11, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_12, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_13, ISupportInitialize).BeginInit()
			CType(Me.lblTotalOil_14, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_14, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_13, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_12, ISupportInitialize).BeginInit()
			CType(Me.lblTotalWater_11, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_11, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_12, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_13, ISupportInitialize).BeginInit()
			CType(Me.lblTotalFluid_14, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Height = 0.02083333F
			Me.Detail.Name = "Detail"
			Me.PageHeader.Controls.AddRange(New ARControl() { Me.lblLabel2, Me.lblCompany, Me.lblWellName, Me.lblDiskFile, Me.lblComment, Me.lblTitle1, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserName, Me.lblUserDate, Me.lblSecondCompanyName, Me.lblSecondCompanyPhonenumber, Me.lblGoTheta })
			Me.PageHeader.Height = 0.9791667F
			Me.PageHeader.Name = "PageHeader"
			Me.PageFooter.Height = 0.08333334F
			Me.PageFooter.Name = "PageFooter"
			Me.GroupHeader1.Controls.AddRange(New ARControl() { Me.picIPR, Me.lblHeader1, Me.lblHeader2, Me.lblInflowPerformanceData, Me.lblMidPerfDepth, Me.lblStaticBottomholePressure, Me.lblBubblePointPressure, Me.lblPressureTestPoints, Me.lblPumpIntakePressure, Me.lblFlowingBHPressure, Me.lblProduction, Me.Line2, Me.Line3, Me.Label1, Me.lblFluidLevelOverPump, Me.lblProdPIP, Me.lblProdBH, Me.Line4, Me.Line5, Me.Line6, Me.lblTotalOil, Me.lblTotalWater, Me.lblTotalFluid, Me.Line7, Me.Line8, Me.Line9, Me.Line10, Me.lblPerfNote, Me.lblTestPIP_1, Me.lblTestPIP_2, Me.lblTestPIP_3, Me.lblTestPIP_4, Me.lblTestPIP_5, Me.lblTestPIP_6, Me.lblTestPIP_7, Me.lblTestPIP_8, Me.lblTestPIP_9, Me.lblTestPIP_10, Me.lblTestBH_1, Me.lblTestBH_2, Me.lblTestBH_3, Me.lblTestBH_4, Me.lblTestBH_5, Me.lblTestBH_6, Me.lblTestBH_7, Me.lblTestBH_8, Me.lblTestBH_9, Me.lblTestBH_10, Me.Line1, Me.lblTestProd_1, Me.lblTestProd_2, Me.lblTestProd_3, Me.lblTestProd_4, Me.lblTestProd_5, Me.lblTestProd_6, Me.lblTestProd_7, Me.lblTestProd_8, Me.lblTestProd_9, Me.lblTestProd_10, Me.lblProdPIP_1, Me.lblProdPIP_2, Me.lblProdPIP_3, Me.lblProdPIP_4, Me.lblProdPIP_5, Me.lblProdPIP_6, Me.lblProdPIP_7, Me.lblProdPIP_8, Me.lblProdPIP_9, Me.lblProdPIP_10, Me.lblProdFL_1, Me.lblProdFL_2, Me.lblProdFL_3, Me.lblProdFL_4, Me.lblProdFL_5, Me.lblProdFL_6, Me.lblProdFL_7, Me.lblProdFL_8, Me.lblProdFL_9, Me.lblProdFL_10, Me.lblProdBH_1, Me.lblProdBH_2, Me.lblProdBH_3, Me.lblProdBH_4, Me.lblProdBH_5, Me.lblProdBH_6, Me.lblProdBH_7, Me.lblProdBH_8, Me.lblProdBH_9, Me.lblProdBH_10, Me.lblTotalOil_1, Me.lblTotalOil_2, Me.lblTotalOil_3, Me.lblTotalOil_4, Me.lblTotalOil_5, Me.lblTotalOil_6, Me.lblTotalOil_7, Me.lblTotalOil_8, Me.lblTotalOil_9, Me.lblTotalOil_10, Me.lblTotalWater_1, Me.lblTotalWater_2, Me.lblTotalWater_3, Me.lblTotalWater_4, Me.lblTotalWater_5, Me.lblTotalWater_6, Me.lblTotalWater_7, Me.lblTotalWater_8, Me.lblTotalWater_9, Me.lblTotalWater_10, Me.lblTotalFluid_1, Me.lblTotalFluid_2, Me.lblTotalFluid_3, Me.lblTotalFluid_4, Me.lblTotalFluid_5, Me.lblTotalFluid_6, Me.lblTotalFluid_7, Me.lblTotalFluid_8, Me.lblTotalFluid_9, Me.lblTotalFluid_10, Me.lblProdNote, Me.lblProdFL_11, Me.lblProdFL_14, Me.lblProdFL_13, Me.lblProdFL_12, Me.lblProdPIP_11, Me.lblProdPIP_12, Me.lblProdPIP_13, Me.lblProdPIP_14, Me.lblProdBH_14, Me.lblProdBH_13, Me.lblProdBH_12, Me.lblProdBH_11, Me.lblTotalOil_11, Me.lblTotalOil_12, Me.lblTotalOil_13, Me.lblTotalOil_14, Me.lblTotalWater_14, Me.lblTotalWater_13, Me.lblTotalWater_12, Me.lblTotalWater_11, Me.lblTotalFluid_11, Me.lblTotalFluid_12, Me.lblTotalFluid_13, Me.lblTotalFluid_14 })
			Me.GroupHeader1.Height = 9.625F
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.GroupFooter1.Height = 0.02083333F
			Me.GroupFooter1.Name = "GroupFooter1"
			Me.lblLabel2.Height = 0.17F
			Me.lblLabel2.HyperLink = Nothing
			Me.lblLabel2.Left = 3F
			Me.lblLabel2.Name = "lblLabel2"
			Me.lblLabel2.Style = "text-align: center; font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblLabel2.Text = "© Theta Oilfield Services, Inc."
			Me.lblLabel2.Top = 0.18F
			Me.lblLabel2.Width = 2F
			Me.lblCompany.Height = 0.17F
			Me.lblCompany.HyperLink = Nothing
			Me.lblCompany.Left = 0.0625F
			Me.lblCompany.Name = "lblCompany"
			Me.lblCompany.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblCompany.Text = "Company: "
			Me.lblCompany.Top = 0.18F
			Me.lblCompany.Width = 2.9375F
			Me.lblWellName.Height = 0.17F
			Me.lblWellName.HyperLink = Nothing
			Me.lblWellName.Left = 0.0625F
			Me.lblWellName.Name = "lblWellName"
			Me.lblWellName.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblWellName.Text = "Well: "
			Me.lblWellName.Top = 0.34F
			Me.lblWellName.Width = 2.9375F
			Me.lblDiskFile.Height = 0.17F
			Me.lblDiskFile.HyperLink = Nothing
			Me.lblDiskFile.Left = 0.0625F
			Me.lblDiskFile.Name = "lblDiskFile"
			Me.lblDiskFile.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif; white-space: nowrap"
			Me.lblDiskFile.Text = "Disk file: "
			Me.lblDiskFile.Top = 0.51F
			Me.lblDiskFile.Width = 2.9375F
			Me.lblComment.Height = 0.25F
			Me.lblComment.HyperLink = Nothing
			Me.lblComment.Left = 0.0625F
			Me.lblComment.Name = "lblComment"
			Me.lblComment.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblComment.Text = "Comment: "
			Me.lblComment.Top = 0.69F
			Me.lblComment.Width = 7.875F
			Me.lblTitle1.Height = 0.17F
			Me.lblTitle1.HyperLink = Nothing
			Me.lblTitle1.Left = 0.0625F
			Me.lblTitle1.Name = "lblTitle1"
			Me.lblTitle1.Style = "text-align: center; font-weight: bold; font-size: 9pt; font-family: Microsoft Sans Serif"
			Me.lblTitle1.Text = "RODSTAR-D 1.0"
			Me.lblTitle1.Top = 0F
			Me.lblTitle1.Width = 7.875F
			Me.lblPage.Height = 0.17F
			Me.lblPage.HyperLink = Nothing
			Me.lblPage.Left = 6.1875F
			Me.lblPage.Name = "lblPage"
			Me.lblPage.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblPage.Text = "Page"
			Me.lblPage.Top = 0.18F
			Me.lblPage.Width = 0.4375F
			Me.txtPage1.Height = 0.17F
			Me.txtPage1.Left = 6.625F
			Me.txtPage1.Name = "txtPage1"
			Me.txtPage1.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.txtPage1.Top = 0.18F
			Me.txtPage1.Width = 0.1875F
			Me.lblOf.Height = 0.17F
			Me.lblOf.HyperLink = Nothing
			Me.lblOf.Left = 6.8125F
			Me.lblOf.Name = "lblOf"
			Me.lblOf.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblOf.Text = "of"
			Me.lblOf.Top = 0.18F
			Me.lblOf.Width = 0.1875F
			Me.txtPage2.Height = 0.17F
			Me.txtPage2.Left = 7F
			Me.txtPage2.Name = "txtPage2"
			Me.txtPage2.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.txtPage2.Top = 0.18F
			Me.txtPage2.Width = 0.1875F
			Me.lblUserName.Height = 0.17F
			Me.lblUserName.HyperLink = Nothing
			Me.lblUserName.Left = 6.1875F
			Me.lblUserName.Name = "lblUserName"
			Me.lblUserName.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblUserName.Text = "User: "
			Me.lblUserName.Top = 0.34F
			Me.lblUserName.Width = 1.75F
			Me.lblUserDate.Height = 0.17F
			Me.lblUserDate.HyperLink = Nothing
			Me.lblUserDate.Left = 6.1875F
			Me.lblUserDate.Name = "lblUserDate"
			Me.lblUserDate.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblUserDate.Text = "Date: "
			Me.lblUserDate.Top = 0.51F
			Me.lblUserDate.Width = 1.75F
			Me.lblSecondCompanyName.Height = 0.17F
			Me.lblSecondCompanyName.HyperLink = Nothing
			Me.lblSecondCompanyName.Left = 3F
			Me.lblSecondCompanyName.Name = "lblSecondCompanyName"
			Me.lblSecondCompanyName.Style = "text-align: center; font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblSecondCompanyName.Text = ""
			Me.lblSecondCompanyName.Top = 0.34F
			Me.lblSecondCompanyName.Width = 2F
			Me.lblSecondCompanyPhonenumber.Height = 0.17F
			Me.lblSecondCompanyPhonenumber.HyperLink = Nothing
			Me.lblSecondCompanyPhonenumber.Left = 3F
			Me.lblSecondCompanyPhonenumber.Name = "lblSecondCompanyPhonenumber"
			Me.lblSecondCompanyPhonenumber.Style = "text-align: center; font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblSecondCompanyPhonenumber.Text = ""
			Me.lblSecondCompanyPhonenumber.Top = 0.51F
			Me.lblSecondCompanyPhonenumber.Width = 2F
			Me.lblGoTheta.Height = 0.17F
			Me.lblGoTheta.HyperLink = Nothing
			Me.lblGoTheta.Left = 4.8125F
			Me.lblGoTheta.Name = "lblGoTheta"
			Me.lblGoTheta.Style = "text-align: center; font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblGoTheta.Text = "(www.gotheta.com)"
			Me.lblGoTheta.Top = 0.18F
			Me.lblGoTheta.Width = 1.0625F
			Me.picIPR.BackColor = Color.FromArgb(255, 255, 255)
			Me.picIPR.Height = 4.125F
			Me.picIPR.ImageData = Nothing
			Me.picIPR.Left = 0.25F
			Me.picIPR.LineColor = Color.FromArgb(255, 255, 255)
			Me.picIPR.LineWeight = 0F
			Me.picIPR.Name = "picIPR"
			Me.picIPR.SizeMode = SizeModes.Stretch
			Me.picIPR.Top = 0.5F
			Me.picIPR.Width = 7.25F
			Me.lblHeader1.Height = 0.1875F
			Me.lblHeader1.HyperLink = Nothing
			Me.lblHeader1.Left = 1F
			Me.lblHeader1.Name = "lblHeader1"
			Me.lblHeader1.Style = "text-align: center; vertical-align: middle"
			Me.lblHeader1.Text = ""
			Me.lblHeader1.Top = 0.0625F
			Me.lblHeader1.Width = 5.875F
			Me.lblHeader2.Height = 0.1875F
			Me.lblHeader2.HyperLink = Nothing
			Me.lblHeader2.Left = 1F
			Me.lblHeader2.Name = "lblHeader2"
			Me.lblHeader2.Style = "text-align: center; vertical-align: middle"
			Me.lblHeader2.Text = ""
			Me.lblHeader2.Top = 0.25F
			Me.lblHeader2.Width = 5.875F
			Me.lblInflowPerformanceData.Height = 0.1875F
			Me.lblInflowPerformanceData.HyperLink = Nothing
			Me.lblInflowPerformanceData.Left = 0.0625F
			Me.lblInflowPerformanceData.Name = "lblInflowPerformanceData"
			Me.lblInflowPerformanceData.Style = "font-weight: bold"
			Me.lblInflowPerformanceData.Text = "Inflow Performance Data: "
			Me.lblInflowPerformanceData.Top = 4.875F
			Me.lblInflowPerformanceData.Width = 1.9375F
			Me.lblMidPerfDepth.Height = 0.1875F
			Me.lblMidPerfDepth.HyperLink = Nothing
			Me.lblMidPerfDepth.Left = 2.0625F
			Me.lblMidPerfDepth.Name = "lblMidPerfDepth"
			Me.lblMidPerfDepth.Style = "font-size: 8pt"
			Me.lblMidPerfDepth.Text = "Mid-perf depth (ft):"
			Me.lblMidPerfDepth.Top = 4.875F
			Me.lblMidPerfDepth.Width = 2.5625F
			Me.lblStaticBottomholePressure.Height = 0.1875F
			Me.lblStaticBottomholePressure.HyperLink = Nothing
			Me.lblStaticBottomholePressure.Left = 2.0625F
			Me.lblStaticBottomholePressure.Name = "lblStaticBottomholePressure"
			Me.lblStaticBottomholePressure.Style = "font-size: 8pt"
			Me.lblStaticBottomholePressure.Text = "Static Bottomhole Pressure (psi):"
			Me.lblStaticBottomholePressure.Top = 5.0625F
			Me.lblStaticBottomholePressure.Width = 2.5625F
			Me.lblBubblePointPressure.Height = 0.1875F
			Me.lblBubblePointPressure.HyperLink = Nothing
			Me.lblBubblePointPressure.Left = 2.0625F
			Me.lblBubblePointPressure.Name = "lblBubblePointPressure"
			Me.lblBubblePointPressure.Style = "font-size: 8pt"
			Me.lblBubblePointPressure.Text = "Bubble Point Pressure (psi):"
			Me.lblBubblePointPressure.Top = 5.25F
			Me.lblBubblePointPressure.Width = 2.5625F
			Me.lblPressureTestPoints.Height = 0.1875F
			Me.lblPressureTestPoints.HyperLink = Nothing
			Me.lblPressureTestPoints.Left = 0.0625F
			Me.lblPressureTestPoints.Name = "lblPressureTestPoints"
			Me.lblPressureTestPoints.Style = "font-weight: bold"
			Me.lblPressureTestPoints.Text = "Pressure Test Points:"
			Me.lblPressureTestPoints.Top = 5.875F
			Me.lblPressureTestPoints.Width = 2.0625F
			Me.lblPumpIntakePressure.Height = 0.375F
			Me.lblPumpIntakePressure.HyperLink = Nothing
			Me.lblPumpIntakePressure.Left = 0.0625F
			Me.lblPumpIntakePressure.Name = "lblPumpIntakePressure"
			Me.lblPumpIntakePressure.Style = "text-align: center; font-size: 8pt; vertical-align: middle"
			Me.lblPumpIntakePressure.Text = "Pump Intake Pressure (psi)"
			Me.lblPumpIntakePressure.Top = 6.125F
			Me.lblPumpIntakePressure.Width = 0.9375F
			Me.lblFlowingBHPressure.Height = 0.375F
			Me.lblFlowingBHPressure.HyperLink = Nothing
			Me.lblFlowingBHPressure.Left = 1F
			Me.lblFlowingBHPressure.Name = "lblFlowingBHPressure"
			Me.lblFlowingBHPressure.Style = "text-align: center; font-size: 8pt; vertical-align: middle"
			Me.lblFlowingBHPressure.Text = "Flowing b.h. pressure (psi)"
			Me.lblFlowingBHPressure.Top = 6.125F
			Me.lblFlowingBHPressure.Width = 0.9375F
			Me.lblProduction.Height = 0.375F
			Me.lblProduction.HyperLink = Nothing
			Me.lblProduction.Left = 1.9375F
			Me.lblProduction.Name = "lblProduction"
			Me.lblProduction.Style = "text-align: center; font-size: 8pt; vertical-align: middle"
			Me.lblProduction.Text = "Production (BPD)"
			Me.lblProduction.Top = 6.125F
			Me.lblProduction.Width = 0.75F
			Me.Line2.Height = 0F
			Me.Line2.Left = 0.0625F
			Me.Line2.LineWeight = 1F
			Me.Line2.Name = "Line2"
			Me.Line2.Top = 6.5F
			Me.Line2.Width = 2.6375F
			Me.Line2.X1 = 0.0625F
			Me.Line2.X2 = 2.7F
			Me.Line2.Y1 = 6.5F
			Me.Line2.Y2 = 6.5F
			Me.Line3.Height = 2.2875F
			Me.Line3.Left = 1.9375F
			Me.Line3.LineWeight = 1F
			Me.Line3.Name = "Line3"
			Me.Line3.Top = 6.125F
			Me.Line3.Width = 0F
			Me.Line3.X1 = 1.9375F
			Me.Line3.X2 = 1.9375F
			Me.Line3.Y1 = 6.125F
			Me.Line3.Y2 = 8.4125F
			Me.Label1.Height = 0.1875F
			Me.Label1.HyperLink = Nothing
			Me.Label1.Left = 2.8125F
			Me.Label1.Name = "Label1"
			Me.Label1.Style = "font-weight: bold"
			Me.Label1.Text = "Pressure vs. Production:"
			Me.Label1.Top = 5.875F
			Me.Label1.Width = 4.25F
			Me.lblFluidLevelOverPump.Height = 0.375F
			Me.lblFluidLevelOverPump.HyperLink = Nothing
			Me.lblFluidLevelOverPump.Left = 2.8125F
			Me.lblFluidLevelOverPump.Name = "lblFluidLevelOverPump"
			Me.lblFluidLevelOverPump.Style = "text-align: center; font-size: 8pt; vertical-align: middle"
			Me.lblFluidLevelOverPump.Text = "Fluid level over pump (ft)"
			Me.lblFluidLevelOverPump.Top = 6.125F
			Me.lblFluidLevelOverPump.Width = 0.9375F
			Me.lblProdPIP.Height = 0.375F
			Me.lblProdPIP.HyperLink = Nothing
			Me.lblProdPIP.Left = 3.75F
			Me.lblProdPIP.Name = "lblProdPIP"
			Me.lblProdPIP.Style = "text-align: center; font-size: 8pt; vertical-align: middle"
			Me.lblProdPIP.Text = "Pump intake pressure (psi)"
			Me.lblProdPIP.Top = 6.125F
			Me.lblProdPIP.Width = 0.9375F
			Me.lblProdBH.Height = 0.375F
			Me.lblProdBH.HyperLink = Nothing
			Me.lblProdBH.Left = 4.6875F
			Me.lblProdBH.Name = "lblProdBH"
			Me.lblProdBH.Style = "text-align: center; font-size: 8pt; vertical-align: middle"
			Me.lblProdBH.Text = "Flowing b.h. pressure (psi)"
			Me.lblProdBH.Top = 6.125F
			Me.lblProdBH.Width = 0.9375F
			Me.Line4.Height = 0F
			Me.Line4.Left = 2.8125F
			Me.Line4.LineWeight = 1F
			Me.Line4.Name = "Line4"
			Me.Line4.Top = 6.5F
			Me.Line4.Width = 2.8125F
			Me.Line4.X1 = 2.8125F
			Me.Line4.X2 = 5.625F
			Me.Line4.Y1 = 6.5F
			Me.Line4.Y2 = 6.5F
			Me.Line5.Height = 3.075F
			Me.Line5.Left = 3.75F
			Me.Line5.LineWeight = 1F
			Me.Line5.Name = "Line5"
			Me.Line5.Top = 6.125F
			Me.Line5.Width = 0F
			Me.Line5.X1 = 3.75F
			Me.Line5.X2 = 3.75F
			Me.Line5.Y1 = 6.125F
			Me.Line5.Y2 = 9.2F
			Me.Line6.Height = 3.075F
			Me.Line6.Left = 4.6875F
			Me.Line6.LineWeight = 1F
			Me.Line6.Name = "Line6"
			Me.Line6.Top = 6.125F
			Me.Line6.Width = 0F
			Me.Line6.X1 = 4.6875F
			Me.Line6.X2 = 4.6875F
			Me.Line6.Y1 = 6.125F
			Me.Line6.Y2 = 9.2F
			Me.lblTotalOil.Height = 0.375F
			Me.lblTotalOil.HyperLink = Nothing
			Me.lblTotalOil.Left = 5.625F
			Me.lblTotalOil.Name = "lblTotalOil"
			Me.lblTotalOil.Style = "text-align: center; font-size: 8pt; vertical-align: middle"
			Me.lblTotalOil.Text = "Total oil (BOPD)"
			Me.lblTotalOil.Top = 6.125F
			Me.lblTotalOil.Width = 0.8125F
			Me.lblTotalWater.Height = 0.375F
			Me.lblTotalWater.HyperLink = Nothing
			Me.lblTotalWater.Left = 6.4375F
			Me.lblTotalWater.Name = "lblTotalWater"
			Me.lblTotalWater.Style = "text-align: center; font-size: 8pt; vertical-align: middle"
			Me.lblTotalWater.Text = "Total water (BWPD)"
			Me.lblTotalWater.Top = 6.125F
			Me.lblTotalWater.Width = 0.8125F
			Me.lblTotalFluid.Height = 0.375F
			Me.lblTotalFluid.HyperLink = Nothing
			Me.lblTotalFluid.Left = 7.25F
			Me.lblTotalFluid.Name = "lblTotalFluid"
			Me.lblTotalFluid.Style = "text-align: center; font-size: 8pt; vertical-align: middle"
			Me.lblTotalFluid.Text = "Total fluid (BFPD)"
			Me.lblTotalFluid.Top = 6.125F
			Me.lblTotalFluid.Width = 0.6875F
			Me.Line7.Height = 0F
			Me.Line7.Left = 5.625F
			Me.Line7.LineWeight = 1F
			Me.Line7.Name = "Line7"
			Me.Line7.Top = 6.5F
			Me.Line7.Width = 2.2875F
			Me.Line7.X1 = 5.625F
			Me.Line7.X2 = 7.9125F
			Me.Line7.Y1 = 6.5F
			Me.Line7.Y2 = 6.5F
			Me.Line8.Height = 3.075F
			Me.Line8.Left = 6.4375F
			Me.Line8.LineWeight = 1F
			Me.Line8.Name = "Line8"
			Me.Line8.Top = 6.125F
			Me.Line8.Width = 0F
			Me.Line8.X1 = 6.4375F
			Me.Line8.X2 = 6.4375F
			Me.Line8.Y1 = 6.125F
			Me.Line8.Y2 = 9.2F
			Me.Line9.Height = 3.075F
			Me.Line9.Left = 7.25F
			Me.Line9.LineWeight = 1F
			Me.Line9.Name = "Line9"
			Me.Line9.Top = 6.125F
			Me.Line9.Width = 0F
			Me.Line9.X1 = 7.25F
			Me.Line9.X2 = 7.25F
			Me.Line9.Y1 = 6.125F
			Me.Line9.Y2 = 9.2F
			Me.Line10.Height = 3.075F
			Me.Line10.Left = 5.625F
			Me.Line10.LineWeight = 1F
			Me.Line10.Name = "Line10"
			Me.Line10.Top = 6.125F
			Me.Line10.Width = 0F
			Me.Line10.X1 = 5.625F
			Me.Line10.X2 = 5.625F
			Me.Line10.Y1 = 6.125F
			Me.Line10.Y2 = 9.2F
			Me.lblPerfNote.Height = 0.1875F
			Me.lblPerfNote.HyperLink = Nothing
			Me.lblPerfNote.Left = 0.125F
			Me.lblPerfNote.Name = "lblPerfNote"
			Me.lblPerfNote.Style = "font-size: 8pt"
			Me.lblPerfNote.Text = ""
			Me.lblPerfNote.Top = 5.5F
			Me.lblPerfNote.Width = 4.6875F
			Me.lblTestPIP_1.Height = 0.1875F
			Me.lblTestPIP_1.HyperLink = Nothing
			Me.lblTestPIP_1.Left = 0.125F
			Me.lblTestPIP_1.Name = "lblTestPIP_1"
			Me.lblTestPIP_1.Style = "text-align: center; font-size: 8pt"
			Me.lblTestPIP_1.Text = ""
			Me.lblTestPIP_1.Top = 6.5625F
			Me.lblTestPIP_1.Width = 0.8125F
			Me.lblTestPIP_2.Height = 0.1875F
			Me.lblTestPIP_2.HyperLink = Nothing
			Me.lblTestPIP_2.Left = 0.125F
			Me.lblTestPIP_2.Name = "lblTestPIP_2"
			Me.lblTestPIP_2.Style = "text-align: center; font-size: 8pt"
			Me.lblTestPIP_2.Text = ""
			Me.lblTestPIP_2.Top = 6.75F
			Me.lblTestPIP_2.Width = 0.8125F
			Me.lblTestPIP_3.Height = 0.1875F
			Me.lblTestPIP_3.HyperLink = Nothing
			Me.lblTestPIP_3.Left = 0.125F
			Me.lblTestPIP_3.Name = "lblTestPIP_3"
			Me.lblTestPIP_3.Style = "text-align: center; font-size: 8pt"
			Me.lblTestPIP_3.Text = ""
			Me.lblTestPIP_3.Top = 6.9375F
			Me.lblTestPIP_3.Width = 0.8125F
			Me.lblTestPIP_4.Height = 0.1875F
			Me.lblTestPIP_4.HyperLink = Nothing
			Me.lblTestPIP_4.Left = 0.125F
			Me.lblTestPIP_4.Name = "lblTestPIP_4"
			Me.lblTestPIP_4.Style = "text-align: center; font-size: 8pt"
			Me.lblTestPIP_4.Text = ""
			Me.lblTestPIP_4.Top = 7.125F
			Me.lblTestPIP_4.Width = 0.8125F
			Me.lblTestPIP_5.Height = 0.1875F
			Me.lblTestPIP_5.HyperLink = Nothing
			Me.lblTestPIP_5.Left = 0.125F
			Me.lblTestPIP_5.Name = "lblTestPIP_5"
			Me.lblTestPIP_5.Style = "text-align: center; font-size: 8pt"
			Me.lblTestPIP_5.Text = ""
			Me.lblTestPIP_5.Top = 7.3125F
			Me.lblTestPIP_5.Width = 0.8125F
			Me.lblTestPIP_6.Height = 0.1875F
			Me.lblTestPIP_6.HyperLink = Nothing
			Me.lblTestPIP_6.Left = 0.125F
			Me.lblTestPIP_6.Name = "lblTestPIP_6"
			Me.lblTestPIP_6.Style = "text-align: center; font-size: 8pt"
			Me.lblTestPIP_6.Text = ""
			Me.lblTestPIP_6.Top = 7.5F
			Me.lblTestPIP_6.Width = 0.8125F
			Me.lblTestPIP_7.Height = 0.1875F
			Me.lblTestPIP_7.HyperLink = Nothing
			Me.lblTestPIP_7.Left = 0.125F
			Me.lblTestPIP_7.Name = "lblTestPIP_7"
			Me.lblTestPIP_7.Style = "text-align: center; font-size: 8pt"
			Me.lblTestPIP_7.Text = ""
			Me.lblTestPIP_7.Top = 7.6875F
			Me.lblTestPIP_7.Width = 0.8125F
			Me.lblTestPIP_8.Height = 0.1875F
			Me.lblTestPIP_8.HyperLink = Nothing
			Me.lblTestPIP_8.Left = 0.125F
			Me.lblTestPIP_8.Name = "lblTestPIP_8"
			Me.lblTestPIP_8.Style = "text-align: center; font-size: 8pt"
			Me.lblTestPIP_8.Text = ""
			Me.lblTestPIP_8.Top = 7.875F
			Me.lblTestPIP_8.Width = 0.8125F
			Me.lblTestPIP_9.Height = 0.1875F
			Me.lblTestPIP_9.HyperLink = Nothing
			Me.lblTestPIP_9.Left = 0.125F
			Me.lblTestPIP_9.Name = "lblTestPIP_9"
			Me.lblTestPIP_9.Style = "text-align: center; font-size: 8pt"
			Me.lblTestPIP_9.Text = ""
			Me.lblTestPIP_9.Top = 8.0625F
			Me.lblTestPIP_9.Width = 0.8125F
			Me.lblTestPIP_10.Height = 0.1875F
			Me.lblTestPIP_10.HyperLink = Nothing
			Me.lblTestPIP_10.Left = 0.125F
			Me.lblTestPIP_10.Name = "lblTestPIP_10"
			Me.lblTestPIP_10.Style = "text-align: center; font-size: 8pt"
			Me.lblTestPIP_10.Text = ""
			Me.lblTestPIP_10.Top = 8.25F
			Me.lblTestPIP_10.Width = 0.8125F
			Me.lblTestBH_1.Height = 0.1875F
			Me.lblTestBH_1.HyperLink = Nothing
			Me.lblTestBH_1.Left = 1.0625F
			Me.lblTestBH_1.Name = "lblTestBH_1"
			Me.lblTestBH_1.Style = "text-align: center; font-size: 8pt"
			Me.lblTestBH_1.Text = " "
			Me.lblTestBH_1.Top = 6.5625F
			Me.lblTestBH_1.Width = 0.8125F
			Me.lblTestBH_2.Height = 0.1875F
			Me.lblTestBH_2.HyperLink = Nothing
			Me.lblTestBH_2.Left = 1.0625F
			Me.lblTestBH_2.Name = "lblTestBH_2"
			Me.lblTestBH_2.Style = "text-align: center; font-size: 8pt"
			Me.lblTestBH_2.Text = " "
			Me.lblTestBH_2.Top = 6.75F
			Me.lblTestBH_2.Width = 0.8125F
			Me.lblTestBH_3.Height = 0.1875F
			Me.lblTestBH_3.HyperLink = Nothing
			Me.lblTestBH_3.Left = 1.0625F
			Me.lblTestBH_3.Name = "lblTestBH_3"
			Me.lblTestBH_3.Style = "text-align: center; font-size: 8pt"
			Me.lblTestBH_3.Text = " "
			Me.lblTestBH_3.Top = 6.9375F
			Me.lblTestBH_3.Width = 0.8125F
			Me.lblTestBH_4.Height = 0.1875F
			Me.lblTestBH_4.HyperLink = Nothing
			Me.lblTestBH_4.Left = 1.0625F
			Me.lblTestBH_4.Name = "lblTestBH_4"
			Me.lblTestBH_4.Style = "text-align: center; font-size: 8pt"
			Me.lblTestBH_4.Text = " "
			Me.lblTestBH_4.Top = 7.125F
			Me.lblTestBH_4.Width = 0.8125F
			Me.lblTestBH_5.Height = 0.1875F
			Me.lblTestBH_5.HyperLink = Nothing
			Me.lblTestBH_5.Left = 1.0625F
			Me.lblTestBH_5.Name = "lblTestBH_5"
			Me.lblTestBH_5.Style = "text-align: center; font-size: 8pt"
			Me.lblTestBH_5.Text = " "
			Me.lblTestBH_5.Top = 7.3125F
			Me.lblTestBH_5.Width = 0.8125F
			Me.lblTestBH_6.Height = 0.1875F
			Me.lblTestBH_6.HyperLink = Nothing
			Me.lblTestBH_6.Left = 1.0625F
			Me.lblTestBH_6.Name = "lblTestBH_6"
			Me.lblTestBH_6.Style = "text-align: center; font-size: 8pt"
			Me.lblTestBH_6.Text = " "
			Me.lblTestBH_6.Top = 7.5F
			Me.lblTestBH_6.Width = 0.8125F
			Me.lblTestBH_7.Height = 0.1875F
			Me.lblTestBH_7.HyperLink = Nothing
			Me.lblTestBH_7.Left = 1.0625F
			Me.lblTestBH_7.Name = "lblTestBH_7"
			Me.lblTestBH_7.Style = "text-align: center; font-size: 8pt"
			Me.lblTestBH_7.Text = " "
			Me.lblTestBH_7.Top = 7.6875F
			Me.lblTestBH_7.Width = 0.8125F
			Me.lblTestBH_8.Height = 0.1875F
			Me.lblTestBH_8.HyperLink = Nothing
			Me.lblTestBH_8.Left = 1.0625F
			Me.lblTestBH_8.Name = "lblTestBH_8"
			Me.lblTestBH_8.Style = "text-align: center; font-size: 8pt"
			Me.lblTestBH_8.Text = " "
			Me.lblTestBH_8.Top = 7.875F
			Me.lblTestBH_8.Width = 0.8125F
			Me.lblTestBH_9.Height = 0.1875F
			Me.lblTestBH_9.HyperLink = Nothing
			Me.lblTestBH_9.Left = 1.0625F
			Me.lblTestBH_9.Name = "lblTestBH_9"
			Me.lblTestBH_9.Style = "text-align: center; font-size: 8pt"
			Me.lblTestBH_9.Text = " "
			Me.lblTestBH_9.Top = 8.0625F
			Me.lblTestBH_9.Width = 0.8125F
			Me.lblTestBH_10.Height = 0.1875F
			Me.lblTestBH_10.HyperLink = Nothing
			Me.lblTestBH_10.Left = 1.0625F
			Me.lblTestBH_10.Name = "lblTestBH_10"
			Me.lblTestBH_10.Style = "text-align: center; font-size: 8pt"
			Me.lblTestBH_10.Text = " "
			Me.lblTestBH_10.Top = 8.25F
			Me.lblTestBH_10.Width = 0.8125F
			Me.Line1.Height = 2.2875F
			Me.Line1.Left = 1F
			Me.Line1.LineWeight = 1F
			Me.Line1.Name = "Line1"
			Me.Line1.Top = 6.125F
			Me.Line1.Width = 0F
			Me.Line1.X1 = 1F
			Me.Line1.X2 = 1F
			Me.Line1.Y1 = 6.125F
			Me.Line1.Y2 = 8.4125F
			Me.lblTestProd_1.Height = 0.1875F
			Me.lblTestProd_1.HyperLink = Nothing
			Me.lblTestProd_1.Left = 2F
			Me.lblTestProd_1.Name = "lblTestProd_1"
			Me.lblTestProd_1.Style = "text-align: center; font-size: 8pt"
			Me.lblTestProd_1.Text = ""
			Me.lblTestProd_1.Top = 6.5625F
			Me.lblTestProd_1.Width = 0.6875F
			Me.lblTestProd_2.Height = 0.1875F
			Me.lblTestProd_2.HyperLink = Nothing
			Me.lblTestProd_2.Left = 2F
			Me.lblTestProd_2.Name = "lblTestProd_2"
			Me.lblTestProd_2.Style = "text-align: center; font-size: 8pt"
			Me.lblTestProd_2.Text = ""
			Me.lblTestProd_2.Top = 6.75F
			Me.lblTestProd_2.Width = 0.6875F
			Me.lblTestProd_3.Height = 0.1875F
			Me.lblTestProd_3.HyperLink = Nothing
			Me.lblTestProd_3.Left = 2F
			Me.lblTestProd_3.Name = "lblTestProd_3"
			Me.lblTestProd_3.Style = "text-align: center; font-size: 8pt"
			Me.lblTestProd_3.Text = ""
			Me.lblTestProd_3.Top = 6.9375F
			Me.lblTestProd_3.Width = 0.6875F
			Me.lblTestProd_4.Height = 0.1875F
			Me.lblTestProd_4.HyperLink = Nothing
			Me.lblTestProd_4.Left = 2F
			Me.lblTestProd_4.Name = "lblTestProd_4"
			Me.lblTestProd_4.Style = "text-align: center; font-size: 8pt"
			Me.lblTestProd_4.Text = ""
			Me.lblTestProd_4.Top = 7.125F
			Me.lblTestProd_4.Width = 0.6875F
			Me.lblTestProd_5.Height = 0.1875F
			Me.lblTestProd_5.HyperLink = Nothing
			Me.lblTestProd_5.Left = 2F
			Me.lblTestProd_5.Name = "lblTestProd_5"
			Me.lblTestProd_5.Style = "text-align: center; font-size: 8pt"
			Me.lblTestProd_5.Text = ""
			Me.lblTestProd_5.Top = 7.3125F
			Me.lblTestProd_5.Width = 0.6875F
			Me.lblTestProd_6.Height = 0.1875F
			Me.lblTestProd_6.HyperLink = Nothing
			Me.lblTestProd_6.Left = 2F
			Me.lblTestProd_6.Name = "lblTestProd_6"
			Me.lblTestProd_6.Style = "text-align: center; font-size: 8pt"
			Me.lblTestProd_6.Text = ""
			Me.lblTestProd_6.Top = 7.5F
			Me.lblTestProd_6.Width = 0.6875F
			Me.lblTestProd_7.Height = 0.1875F
			Me.lblTestProd_7.HyperLink = Nothing
			Me.lblTestProd_7.Left = 2F
			Me.lblTestProd_7.Name = "lblTestProd_7"
			Me.lblTestProd_7.Style = "text-align: center; font-size: 8pt"
			Me.lblTestProd_7.Text = ""
			Me.lblTestProd_7.Top = 7.6875F
			Me.lblTestProd_7.Width = 0.6875F
			Me.lblTestProd_8.Height = 0.1875F
			Me.lblTestProd_8.HyperLink = Nothing
			Me.lblTestProd_8.Left = 2F
			Me.lblTestProd_8.Name = "lblTestProd_8"
			Me.lblTestProd_8.Style = "text-align: center; font-size: 8pt"
			Me.lblTestProd_8.Text = ""
			Me.lblTestProd_8.Top = 7.875F
			Me.lblTestProd_8.Width = 0.6875F
			Me.lblTestProd_9.Height = 0.1875F
			Me.lblTestProd_9.HyperLink = Nothing
			Me.lblTestProd_9.Left = 2F
			Me.lblTestProd_9.Name = "lblTestProd_9"
			Me.lblTestProd_9.Style = "text-align: center; font-size: 8pt"
			Me.lblTestProd_9.Text = ""
			Me.lblTestProd_9.Top = 8.0625F
			Me.lblTestProd_9.Width = 0.6875F
			Me.lblTestProd_10.Height = 0.1875F
			Me.lblTestProd_10.HyperLink = Nothing
			Me.lblTestProd_10.Left = 2F
			Me.lblTestProd_10.Name = "lblTestProd_10"
			Me.lblTestProd_10.Style = "text-align: center; font-size: 8pt"
			Me.lblTestProd_10.Text = ""
			Me.lblTestProd_10.Top = 8.25F
			Me.lblTestProd_10.Width = 0.6875F
			Me.lblProdPIP_1.Height = 0.1875F
			Me.lblProdPIP_1.HyperLink = Nothing
			Me.lblProdPIP_1.Left = 3.875F
			Me.lblProdPIP_1.Name = "lblProdPIP_1"
			Me.lblProdPIP_1.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_1.Text = "   "
			Me.lblProdPIP_1.Top = 6.5625F
			Me.lblProdPIP_1.Width = 0.75F
			Me.lblProdPIP_2.Height = 0.1875F
			Me.lblProdPIP_2.HyperLink = Nothing
			Me.lblProdPIP_2.Left = 3.875F
			Me.lblProdPIP_2.Name = "lblProdPIP_2"
			Me.lblProdPIP_2.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_2.Text = "   "
			Me.lblProdPIP_2.Top = 6.75F
			Me.lblProdPIP_2.Width = 0.75F
			Me.lblProdPIP_3.Height = 0.1875F
			Me.lblProdPIP_3.HyperLink = Nothing
			Me.lblProdPIP_3.Left = 3.875F
			Me.lblProdPIP_3.Name = "lblProdPIP_3"
			Me.lblProdPIP_3.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_3.Text = "   "
			Me.lblProdPIP_3.Top = 6.9375F
			Me.lblProdPIP_3.Width = 0.75F
			Me.lblProdPIP_4.Height = 0.1875F
			Me.lblProdPIP_4.HyperLink = Nothing
			Me.lblProdPIP_4.Left = 3.875F
			Me.lblProdPIP_4.Name = "lblProdPIP_4"
			Me.lblProdPIP_4.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_4.Text = "   "
			Me.lblProdPIP_4.Top = 7.125F
			Me.lblProdPIP_4.Width = 0.75F
			Me.lblProdPIP_5.Height = 0.1875F
			Me.lblProdPIP_5.HyperLink = Nothing
			Me.lblProdPIP_5.Left = 3.875F
			Me.lblProdPIP_5.Name = "lblProdPIP_5"
			Me.lblProdPIP_5.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_5.Text = "   "
			Me.lblProdPIP_5.Top = 7.3125F
			Me.lblProdPIP_5.Width = 0.75F
			Me.lblProdPIP_6.Height = 0.1875F
			Me.lblProdPIP_6.HyperLink = Nothing
			Me.lblProdPIP_6.Left = 3.875F
			Me.lblProdPIP_6.Name = "lblProdPIP_6"
			Me.lblProdPIP_6.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_6.Text = "   "
			Me.lblProdPIP_6.Top = 7.5F
			Me.lblProdPIP_6.Width = 0.75F
			Me.lblProdPIP_7.Height = 0.1875F
			Me.lblProdPIP_7.HyperLink = Nothing
			Me.lblProdPIP_7.Left = 3.875F
			Me.lblProdPIP_7.Name = "lblProdPIP_7"
			Me.lblProdPIP_7.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_7.Text = "   "
			Me.lblProdPIP_7.Top = 7.6875F
			Me.lblProdPIP_7.Width = 0.75F
			Me.lblProdPIP_8.Height = 0.1875F
			Me.lblProdPIP_8.HyperLink = Nothing
			Me.lblProdPIP_8.Left = 3.875F
			Me.lblProdPIP_8.Name = "lblProdPIP_8"
			Me.lblProdPIP_8.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_8.Text = "   "
			Me.lblProdPIP_8.Top = 7.875F
			Me.lblProdPIP_8.Width = 0.75F
			Me.lblProdPIP_9.Height = 0.1875F
			Me.lblProdPIP_9.HyperLink = Nothing
			Me.lblProdPIP_9.Left = 3.875F
			Me.lblProdPIP_9.Name = "lblProdPIP_9"
			Me.lblProdPIP_9.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_9.Text = "   "
			Me.lblProdPIP_9.Top = 8.0625F
			Me.lblProdPIP_9.Width = 0.75F
			Me.lblProdPIP_10.Height = 0.1875F
			Me.lblProdPIP_10.HyperLink = Nothing
			Me.lblProdPIP_10.Left = 3.875F
			Me.lblProdPIP_10.Name = "lblProdPIP_10"
			Me.lblProdPIP_10.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_10.Text = "   "
			Me.lblProdPIP_10.Top = 8.25F
			Me.lblProdPIP_10.Width = 0.75F
			Me.lblProdFL_1.Height = 0.1875F
			Me.lblProdFL_1.HyperLink = Nothing
			Me.lblProdFL_1.Left = 2.875F
			Me.lblProdFL_1.Name = "lblProdFL_1"
			Me.lblProdFL_1.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_1.Text = " "
			Me.lblProdFL_1.Top = 6.5625F
			Me.lblProdFL_1.Width = 0.75F
			Me.lblProdFL_2.Height = 0.1875F
			Me.lblProdFL_2.HyperLink = Nothing
			Me.lblProdFL_2.Left = 2.875F
			Me.lblProdFL_2.Name = "lblProdFL_2"
			Me.lblProdFL_2.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_2.Text = " "
			Me.lblProdFL_2.Top = 6.75F
			Me.lblProdFL_2.Width = 0.75F
			Me.lblProdFL_3.Height = 0.1875F
			Me.lblProdFL_3.HyperLink = Nothing
			Me.lblProdFL_3.Left = 2.875F
			Me.lblProdFL_3.Name = "lblProdFL_3"
			Me.lblProdFL_3.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_3.Text = " "
			Me.lblProdFL_3.Top = 6.9375F
			Me.lblProdFL_3.Width = 0.75F
			Me.lblProdFL_4.Height = 0.1875F
			Me.lblProdFL_4.HyperLink = Nothing
			Me.lblProdFL_4.Left = 2.875F
			Me.lblProdFL_4.Name = "lblProdFL_4"
			Me.lblProdFL_4.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_4.Text = " "
			Me.lblProdFL_4.Top = 7.125F
			Me.lblProdFL_4.Width = 0.75F
			Me.lblProdFL_5.Height = 0.1875F
			Me.lblProdFL_5.HyperLink = Nothing
			Me.lblProdFL_5.Left = 2.875F
			Me.lblProdFL_5.Name = "lblProdFL_5"
			Me.lblProdFL_5.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_5.Text = " "
			Me.lblProdFL_5.Top = 7.3125F
			Me.lblProdFL_5.Width = 0.75F
			Me.lblProdFL_6.Height = 0.1875F
			Me.lblProdFL_6.HyperLink = Nothing
			Me.lblProdFL_6.Left = 2.875F
			Me.lblProdFL_6.Name = "lblProdFL_6"
			Me.lblProdFL_6.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_6.Text = " "
			Me.lblProdFL_6.Top = 7.5F
			Me.lblProdFL_6.Width = 0.75F
			Me.lblProdFL_7.Height = 0.1875F
			Me.lblProdFL_7.HyperLink = Nothing
			Me.lblProdFL_7.Left = 2.875F
			Me.lblProdFL_7.Name = "lblProdFL_7"
			Me.lblProdFL_7.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_7.Text = " "
			Me.lblProdFL_7.Top = 7.6875F
			Me.lblProdFL_7.Width = 0.75F
			Me.lblProdFL_8.Height = 0.1875F
			Me.lblProdFL_8.HyperLink = Nothing
			Me.lblProdFL_8.Left = 2.875F
			Me.lblProdFL_8.Name = "lblProdFL_8"
			Me.lblProdFL_8.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_8.Text = " "
			Me.lblProdFL_8.Top = 7.875F
			Me.lblProdFL_8.Width = 0.75F
			Me.lblProdFL_9.Height = 0.1875F
			Me.lblProdFL_9.HyperLink = Nothing
			Me.lblProdFL_9.Left = 2.875F
			Me.lblProdFL_9.Name = "lblProdFL_9"
			Me.lblProdFL_9.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_9.Text = " "
			Me.lblProdFL_9.Top = 8.0625F
			Me.lblProdFL_9.Width = 0.75F
			Me.lblProdFL_10.Height = 0.1875F
			Me.lblProdFL_10.HyperLink = Nothing
			Me.lblProdFL_10.Left = 2.875F
			Me.lblProdFL_10.Name = "lblProdFL_10"
			Me.lblProdFL_10.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_10.Text = " "
			Me.lblProdFL_10.Top = 8.25F
			Me.lblProdFL_10.Width = 0.75F
			Me.lblProdBH_1.Height = 0.1875F
			Me.lblProdBH_1.HyperLink = Nothing
			Me.lblProdBH_1.Left = 4.75F
			Me.lblProdBH_1.Name = "lblProdBH_1"
			Me.lblProdBH_1.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_1.Text = " "
			Me.lblProdBH_1.Top = 6.5625F
			Me.lblProdBH_1.Width = 0.75F
			Me.lblProdBH_2.Height = 0.1875F
			Me.lblProdBH_2.HyperLink = Nothing
			Me.lblProdBH_2.Left = 4.75F
			Me.lblProdBH_2.Name = "lblProdBH_2"
			Me.lblProdBH_2.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_2.Text = " "
			Me.lblProdBH_2.Top = 6.75F
			Me.lblProdBH_2.Width = 0.75F
			Me.lblProdBH_3.Height = 0.1875F
			Me.lblProdBH_3.HyperLink = Nothing
			Me.lblProdBH_3.Left = 4.75F
			Me.lblProdBH_3.Name = "lblProdBH_3"
			Me.lblProdBH_3.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_3.Text = " "
			Me.lblProdBH_3.Top = 6.9375F
			Me.lblProdBH_3.Width = 0.75F
			Me.lblProdBH_4.Height = 0.1875F
			Me.lblProdBH_4.HyperLink = Nothing
			Me.lblProdBH_4.Left = 4.75F
			Me.lblProdBH_4.Name = "lblProdBH_4"
			Me.lblProdBH_4.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_4.Text = " "
			Me.lblProdBH_4.Top = 7.125F
			Me.lblProdBH_4.Width = 0.75F
			Me.lblProdBH_5.Height = 0.1875F
			Me.lblProdBH_5.HyperLink = Nothing
			Me.lblProdBH_5.Left = 4.75F
			Me.lblProdBH_5.Name = "lblProdBH_5"
			Me.lblProdBH_5.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_5.Text = " "
			Me.lblProdBH_5.Top = 7.3125F
			Me.lblProdBH_5.Width = 0.75F
			Me.lblProdBH_6.Height = 0.1875F
			Me.lblProdBH_6.HyperLink = Nothing
			Me.lblProdBH_6.Left = 4.75F
			Me.lblProdBH_6.Name = "lblProdBH_6"
			Me.lblProdBH_6.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_6.Text = " "
			Me.lblProdBH_6.Top = 7.5F
			Me.lblProdBH_6.Width = 0.75F
			Me.lblProdBH_7.Height = 0.1875F
			Me.lblProdBH_7.HyperLink = Nothing
			Me.lblProdBH_7.Left = 4.75F
			Me.lblProdBH_7.Name = "lblProdBH_7"
			Me.lblProdBH_7.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_7.Text = " "
			Me.lblProdBH_7.Top = 7.6875F
			Me.lblProdBH_7.Width = 0.75F
			Me.lblProdBH_8.Height = 0.1875F
			Me.lblProdBH_8.HyperLink = Nothing
			Me.lblProdBH_8.Left = 4.75F
			Me.lblProdBH_8.Name = "lblProdBH_8"
			Me.lblProdBH_8.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_8.Text = " "
			Me.lblProdBH_8.Top = 7.875F
			Me.lblProdBH_8.Width = 0.75F
			Me.lblProdBH_9.Height = 0.1875F
			Me.lblProdBH_9.HyperLink = Nothing
			Me.lblProdBH_9.Left = 4.75F
			Me.lblProdBH_9.Name = "lblProdBH_9"
			Me.lblProdBH_9.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_9.Text = " "
			Me.lblProdBH_9.Top = 8.0625F
			Me.lblProdBH_9.Width = 0.75F
			Me.lblProdBH_10.Height = 0.1875F
			Me.lblProdBH_10.HyperLink = Nothing
			Me.lblProdBH_10.Left = 4.75F
			Me.lblProdBH_10.Name = "lblProdBH_10"
			Me.lblProdBH_10.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_10.Text = " "
			Me.lblProdBH_10.Top = 8.25F
			Me.lblProdBH_10.Width = 0.75F
			Me.lblTotalOil_1.Height = 0.1875F
			Me.lblTotalOil_1.HyperLink = Nothing
			Me.lblTotalOil_1.Left = 5.6875F
			Me.lblTotalOil_1.Name = "lblTotalOil_1"
			Me.lblTotalOil_1.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_1.Text = " "
			Me.lblTotalOil_1.Top = 6.5625F
			Me.lblTotalOil_1.Width = 0.6875F
			Me.lblTotalOil_2.Height = 0.1875F
			Me.lblTotalOil_2.HyperLink = Nothing
			Me.lblTotalOil_2.Left = 5.6875F
			Me.lblTotalOil_2.Name = "lblTotalOil_2"
			Me.lblTotalOil_2.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_2.Text = " "
			Me.lblTotalOil_2.Top = 6.75F
			Me.lblTotalOil_2.Width = 0.6875F
			Me.lblTotalOil_3.Height = 0.1875F
			Me.lblTotalOil_3.HyperLink = Nothing
			Me.lblTotalOil_3.Left = 5.6875F
			Me.lblTotalOil_3.Name = "lblTotalOil_3"
			Me.lblTotalOil_3.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_3.Text = " "
			Me.lblTotalOil_3.Top = 6.9375F
			Me.lblTotalOil_3.Width = 0.6875F
			Me.lblTotalOil_4.Height = 0.1875F
			Me.lblTotalOil_4.HyperLink = Nothing
			Me.lblTotalOil_4.Left = 5.6875F
			Me.lblTotalOil_4.Name = "lblTotalOil_4"
			Me.lblTotalOil_4.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_4.Text = " "
			Me.lblTotalOil_4.Top = 7.125F
			Me.lblTotalOil_4.Width = 0.6875F
			Me.lblTotalOil_5.Height = 0.1875F
			Me.lblTotalOil_5.HyperLink = Nothing
			Me.lblTotalOil_5.Left = 5.6875F
			Me.lblTotalOil_5.Name = "lblTotalOil_5"
			Me.lblTotalOil_5.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_5.Text = " "
			Me.lblTotalOil_5.Top = 7.3125F
			Me.lblTotalOil_5.Width = 0.6875F
			Me.lblTotalOil_6.Height = 0.1875F
			Me.lblTotalOil_6.HyperLink = Nothing
			Me.lblTotalOil_6.Left = 5.6875F
			Me.lblTotalOil_6.Name = "lblTotalOil_6"
			Me.lblTotalOil_6.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_6.Text = " "
			Me.lblTotalOil_6.Top = 7.5F
			Me.lblTotalOil_6.Width = 0.6875F
			Me.lblTotalOil_7.Height = 0.1875F
			Me.lblTotalOil_7.HyperLink = Nothing
			Me.lblTotalOil_7.Left = 5.6875F
			Me.lblTotalOil_7.Name = "lblTotalOil_7"
			Me.lblTotalOil_7.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_7.Text = " "
			Me.lblTotalOil_7.Top = 7.6875F
			Me.lblTotalOil_7.Width = 0.6875F
			Me.lblTotalOil_8.Height = 0.1875F
			Me.lblTotalOil_8.HyperLink = Nothing
			Me.lblTotalOil_8.Left = 5.6875F
			Me.lblTotalOil_8.Name = "lblTotalOil_8"
			Me.lblTotalOil_8.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_8.Text = " "
			Me.lblTotalOil_8.Top = 7.875F
			Me.lblTotalOil_8.Width = 0.6875F
			Me.lblTotalOil_9.Height = 0.1875F
			Me.lblTotalOil_9.HyperLink = Nothing
			Me.lblTotalOil_9.Left = 5.6875F
			Me.lblTotalOil_9.Name = "lblTotalOil_9"
			Me.lblTotalOil_9.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_9.Text = " "
			Me.lblTotalOil_9.Top = 8.0625F
			Me.lblTotalOil_9.Width = 0.6875F
			Me.lblTotalOil_10.Height = 0.1875F
			Me.lblTotalOil_10.HyperLink = Nothing
			Me.lblTotalOil_10.Left = 5.6875F
			Me.lblTotalOil_10.Name = "lblTotalOil_10"
			Me.lblTotalOil_10.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_10.Text = " "
			Me.lblTotalOil_10.Top = 8.25F
			Me.lblTotalOil_10.Width = 0.6875F
			Me.lblTotalWater_1.Height = 0.1875F
			Me.lblTotalWater_1.HyperLink = Nothing
			Me.lblTotalWater_1.Left = 6.5F
			Me.lblTotalWater_1.Name = "lblTotalWater_1"
			Me.lblTotalWater_1.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_1.Text = " "
			Me.lblTotalWater_1.Top = 6.5625F
			Me.lblTotalWater_1.Width = 0.6875F
			Me.lblTotalWater_2.Height = 0.1875F
			Me.lblTotalWater_2.HyperLink = Nothing
			Me.lblTotalWater_2.Left = 6.5F
			Me.lblTotalWater_2.Name = "lblTotalWater_2"
			Me.lblTotalWater_2.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_2.Text = " "
			Me.lblTotalWater_2.Top = 6.75F
			Me.lblTotalWater_2.Width = 0.6875F
			Me.lblTotalWater_3.Height = 0.1875F
			Me.lblTotalWater_3.HyperLink = Nothing
			Me.lblTotalWater_3.Left = 6.5F
			Me.lblTotalWater_3.Name = "lblTotalWater_3"
			Me.lblTotalWater_3.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_3.Text = " "
			Me.lblTotalWater_3.Top = 6.9375F
			Me.lblTotalWater_3.Width = 0.6875F
			Me.lblTotalWater_4.Height = 0.1875F
			Me.lblTotalWater_4.HyperLink = Nothing
			Me.lblTotalWater_4.Left = 6.5F
			Me.lblTotalWater_4.Name = "lblTotalWater_4"
			Me.lblTotalWater_4.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_4.Text = " "
			Me.lblTotalWater_4.Top = 7.125F
			Me.lblTotalWater_4.Width = 0.6875F
			Me.lblTotalWater_5.Height = 0.1875F
			Me.lblTotalWater_5.HyperLink = Nothing
			Me.lblTotalWater_5.Left = 6.5F
			Me.lblTotalWater_5.Name = "lblTotalWater_5"
			Me.lblTotalWater_5.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_5.Text = " "
			Me.lblTotalWater_5.Top = 7.3125F
			Me.lblTotalWater_5.Width = 0.6875F
			Me.lblTotalWater_6.Height = 0.1875F
			Me.lblTotalWater_6.HyperLink = Nothing
			Me.lblTotalWater_6.Left = 6.5F
			Me.lblTotalWater_6.Name = "lblTotalWater_6"
			Me.lblTotalWater_6.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_6.Text = " "
			Me.lblTotalWater_6.Top = 7.5F
			Me.lblTotalWater_6.Width = 0.6875F
			Me.lblTotalWater_7.Height = 0.1875F
			Me.lblTotalWater_7.HyperLink = Nothing
			Me.lblTotalWater_7.Left = 6.5F
			Me.lblTotalWater_7.Name = "lblTotalWater_7"
			Me.lblTotalWater_7.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_7.Text = " "
			Me.lblTotalWater_7.Top = 7.6875F
			Me.lblTotalWater_7.Width = 0.6875F
			Me.lblTotalWater_8.Height = 0.1875F
			Me.lblTotalWater_8.HyperLink = Nothing
			Me.lblTotalWater_8.Left = 6.5F
			Me.lblTotalWater_8.Name = "lblTotalWater_8"
			Me.lblTotalWater_8.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_8.Text = " "
			Me.lblTotalWater_8.Top = 7.875F
			Me.lblTotalWater_8.Width = 0.6875F
			Me.lblTotalWater_9.Height = 0.1875F
			Me.lblTotalWater_9.HyperLink = Nothing
			Me.lblTotalWater_9.Left = 6.5F
			Me.lblTotalWater_9.Name = "lblTotalWater_9"
			Me.lblTotalWater_9.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_9.Text = " "
			Me.lblTotalWater_9.Top = 8.0625F
			Me.lblTotalWater_9.Width = 0.6875F
			Me.lblTotalWater_10.Height = 0.1875F
			Me.lblTotalWater_10.HyperLink = Nothing
			Me.lblTotalWater_10.Left = 6.5F
			Me.lblTotalWater_10.Name = "lblTotalWater_10"
			Me.lblTotalWater_10.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_10.Text = " "
			Me.lblTotalWater_10.Top = 8.25F
			Me.lblTotalWater_10.Width = 0.6875F
			Me.lblTotalFluid_1.Height = 0.1875F
			Me.lblTotalFluid_1.HyperLink = Nothing
			Me.lblTotalFluid_1.Left = 7.3125F
			Me.lblTotalFluid_1.Name = "lblTotalFluid_1"
			Me.lblTotalFluid_1.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_1.Text = " "
			Me.lblTotalFluid_1.Top = 6.5625F
			Me.lblTotalFluid_1.Width = 0.5625F
			Me.lblTotalFluid_2.Height = 0.1875F
			Me.lblTotalFluid_2.HyperLink = Nothing
			Me.lblTotalFluid_2.Left = 7.3125F
			Me.lblTotalFluid_2.Name = "lblTotalFluid_2"
			Me.lblTotalFluid_2.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_2.Text = " "
			Me.lblTotalFluid_2.Top = 6.75F
			Me.lblTotalFluid_2.Width = 0.5625F
			Me.lblTotalFluid_3.Height = 0.1875F
			Me.lblTotalFluid_3.HyperLink = Nothing
			Me.lblTotalFluid_3.Left = 7.3125F
			Me.lblTotalFluid_3.Name = "lblTotalFluid_3"
			Me.lblTotalFluid_3.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_3.Text = " "
			Me.lblTotalFluid_3.Top = 6.9375F
			Me.lblTotalFluid_3.Width = 0.5625F
			Me.lblTotalFluid_4.Height = 0.1875F
			Me.lblTotalFluid_4.HyperLink = Nothing
			Me.lblTotalFluid_4.Left = 7.3125F
			Me.lblTotalFluid_4.Name = "lblTotalFluid_4"
			Me.lblTotalFluid_4.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_4.Text = " "
			Me.lblTotalFluid_4.Top = 7.125F
			Me.lblTotalFluid_4.Width = 0.5625F
			Me.lblTotalFluid_5.Height = 0.1875F
			Me.lblTotalFluid_5.HyperLink = Nothing
			Me.lblTotalFluid_5.Left = 7.3125F
			Me.lblTotalFluid_5.Name = "lblTotalFluid_5"
			Me.lblTotalFluid_5.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_5.Text = " "
			Me.lblTotalFluid_5.Top = 7.3125F
			Me.lblTotalFluid_5.Width = 0.5625F
			Me.lblTotalFluid_6.Height = 0.1875F
			Me.lblTotalFluid_6.HyperLink = Nothing
			Me.lblTotalFluid_6.Left = 7.3125F
			Me.lblTotalFluid_6.Name = "lblTotalFluid_6"
			Me.lblTotalFluid_6.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_6.Text = " "
			Me.lblTotalFluid_6.Top = 7.5F
			Me.lblTotalFluid_6.Width = 0.5625F
			Me.lblTotalFluid_7.Height = 0.1875F
			Me.lblTotalFluid_7.HyperLink = Nothing
			Me.lblTotalFluid_7.Left = 7.3125F
			Me.lblTotalFluid_7.Name = "lblTotalFluid_7"
			Me.lblTotalFluid_7.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_7.Text = " "
			Me.lblTotalFluid_7.Top = 7.6875F
			Me.lblTotalFluid_7.Width = 0.5625F
			Me.lblTotalFluid_8.Height = 0.1875F
			Me.lblTotalFluid_8.HyperLink = Nothing
			Me.lblTotalFluid_8.Left = 7.3125F
			Me.lblTotalFluid_8.Name = "lblTotalFluid_8"
			Me.lblTotalFluid_8.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_8.Text = " "
			Me.lblTotalFluid_8.Top = 7.875F
			Me.lblTotalFluid_8.Width = 0.5625F
			Me.lblTotalFluid_9.Height = 0.1875F
			Me.lblTotalFluid_9.HyperLink = Nothing
			Me.lblTotalFluid_9.Left = 7.3125F
			Me.lblTotalFluid_9.Name = "lblTotalFluid_9"
			Me.lblTotalFluid_9.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_9.Text = " "
			Me.lblTotalFluid_9.Top = 8.0625F
			Me.lblTotalFluid_9.Width = 0.5625F
			Me.lblTotalFluid_10.Height = 0.1875F
			Me.lblTotalFluid_10.HyperLink = Nothing
			Me.lblTotalFluid_10.Left = 7.3125F
			Me.lblTotalFluid_10.Name = "lblTotalFluid_10"
			Me.lblTotalFluid_10.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_10.Text = " "
			Me.lblTotalFluid_10.Top = 8.25F
			Me.lblTotalFluid_10.Width = 0.5625F
			Me.lblProdNote.Height = 0.1875F
			Me.lblProdNote.HyperLink = Nothing
			Me.lblProdNote.Left = 2.875F
			Me.lblProdNote.Name = "lblProdNote"
			Me.lblProdNote.Style = "font-size: 8pt"
			Me.lblProdNote.Text = ""
			Me.lblProdNote.Top = 9.3125F
			Me.lblProdNote.Width = 5F
			Me.lblProdFL_11.Height = 0.1875F
			Me.lblProdFL_11.HyperLink = Nothing
			Me.lblProdFL_11.Left = 2.875F
			Me.lblProdFL_11.Name = "lblProdFL_11"
			Me.lblProdFL_11.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_11.Text = " "
			Me.lblProdFL_11.Top = 8.4375F
			Me.lblProdFL_11.Width = 0.75F
			Me.lblProdFL_14.Height = 0.1875F
			Me.lblProdFL_14.HyperLink = Nothing
			Me.lblProdFL_14.Left = 2.875F
			Me.lblProdFL_14.Name = "lblProdFL_14"
			Me.lblProdFL_14.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_14.Text = " "
			Me.lblProdFL_14.Top = 9F
			Me.lblProdFL_14.Width = 0.75F
			Me.lblProdFL_13.Height = 0.1875F
			Me.lblProdFL_13.HyperLink = Nothing
			Me.lblProdFL_13.Left = 2.875F
			Me.lblProdFL_13.Name = "lblProdFL_13"
			Me.lblProdFL_13.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_13.Text = " "
			Me.lblProdFL_13.Top = 8.8125F
			Me.lblProdFL_13.Width = 0.75F
			Me.lblProdFL_12.Height = 0.1875F
			Me.lblProdFL_12.HyperLink = Nothing
			Me.lblProdFL_12.Left = 2.875F
			Me.lblProdFL_12.Name = "lblProdFL_12"
			Me.lblProdFL_12.Style = "text-align: center; font-size: 8pt"
			Me.lblProdFL_12.Text = " "
			Me.lblProdFL_12.Top = 8.625F
			Me.lblProdFL_12.Width = 0.75F
			Me.lblProdPIP_11.Height = 0.1875F
			Me.lblProdPIP_11.HyperLink = Nothing
			Me.lblProdPIP_11.Left = 3.875F
			Me.lblProdPIP_11.Name = "lblProdPIP_11"
			Me.lblProdPIP_11.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_11.Text = "   "
			Me.lblProdPIP_11.Top = 8.4375F
			Me.lblProdPIP_11.Width = 0.75F
			Me.lblProdPIP_12.Height = 0.1875F
			Me.lblProdPIP_12.HyperLink = Nothing
			Me.lblProdPIP_12.Left = 3.875F
			Me.lblProdPIP_12.Name = "lblProdPIP_12"
			Me.lblProdPIP_12.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_12.Text = "   "
			Me.lblProdPIP_12.Top = 8.625F
			Me.lblProdPIP_12.Width = 0.75F
			Me.lblProdPIP_13.Height = 0.1875F
			Me.lblProdPIP_13.HyperLink = Nothing
			Me.lblProdPIP_13.Left = 3.875F
			Me.lblProdPIP_13.Name = "lblProdPIP_13"
			Me.lblProdPIP_13.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_13.Text = "   "
			Me.lblProdPIP_13.Top = 8.8125F
			Me.lblProdPIP_13.Width = 0.75F
			Me.lblProdPIP_14.Height = 0.1875F
			Me.lblProdPIP_14.HyperLink = Nothing
			Me.lblProdPIP_14.Left = 3.875F
			Me.lblProdPIP_14.Name = "lblProdPIP_14"
			Me.lblProdPIP_14.Style = "text-align: center; font-size: 8pt"
			Me.lblProdPIP_14.Text = "   "
			Me.lblProdPIP_14.Top = 9F
			Me.lblProdPIP_14.Width = 0.75F
			Me.lblProdBH_14.Height = 0.1875F
			Me.lblProdBH_14.HyperLink = Nothing
			Me.lblProdBH_14.Left = 4.75F
			Me.lblProdBH_14.Name = "lblProdBH_14"
			Me.lblProdBH_14.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_14.Text = " "
			Me.lblProdBH_14.Top = 9F
			Me.lblProdBH_14.Width = 0.75F
			Me.lblProdBH_13.Height = 0.1875F
			Me.lblProdBH_13.HyperLink = Nothing
			Me.lblProdBH_13.Left = 4.75F
			Me.lblProdBH_13.Name = "lblProdBH_13"
			Me.lblProdBH_13.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_13.Text = " "
			Me.lblProdBH_13.Top = 8.8125F
			Me.lblProdBH_13.Width = 0.75F
			Me.lblProdBH_12.Height = 0.1875F
			Me.lblProdBH_12.HyperLink = Nothing
			Me.lblProdBH_12.Left = 4.75F
			Me.lblProdBH_12.Name = "lblProdBH_12"
			Me.lblProdBH_12.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_12.Text = " "
			Me.lblProdBH_12.Top = 8.625F
			Me.lblProdBH_12.Width = 0.75F
			Me.lblProdBH_11.Height = 0.1875F
			Me.lblProdBH_11.HyperLink = Nothing
			Me.lblProdBH_11.Left = 4.75F
			Me.lblProdBH_11.Name = "lblProdBH_11"
			Me.lblProdBH_11.Style = "text-align: center; font-size: 8pt"
			Me.lblProdBH_11.Text = " "
			Me.lblProdBH_11.Top = 8.4375F
			Me.lblProdBH_11.Width = 0.75F
			Me.lblTotalOil_11.Height = 0.1875F
			Me.lblTotalOil_11.HyperLink = Nothing
			Me.lblTotalOil_11.Left = 5.6875F
			Me.lblTotalOil_11.Name = "lblTotalOil_11"
			Me.lblTotalOil_11.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_11.Text = " "
			Me.lblTotalOil_11.Top = 8.4375F
			Me.lblTotalOil_11.Width = 0.6875F
			Me.lblTotalOil_12.Height = 0.1875F
			Me.lblTotalOil_12.HyperLink = Nothing
			Me.lblTotalOil_12.Left = 5.6875F
			Me.lblTotalOil_12.Name = "lblTotalOil_12"
			Me.lblTotalOil_12.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_12.Text = " "
			Me.lblTotalOil_12.Top = 8.625F
			Me.lblTotalOil_12.Width = 0.6875F
			Me.lblTotalOil_13.Height = 0.1875F
			Me.lblTotalOil_13.HyperLink = Nothing
			Me.lblTotalOil_13.Left = 5.6875F
			Me.lblTotalOil_13.Name = "lblTotalOil_13"
			Me.lblTotalOil_13.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_13.Text = " "
			Me.lblTotalOil_13.Top = 8.8125F
			Me.lblTotalOil_13.Width = 0.6875F
			Me.lblTotalOil_14.Height = 0.1875F
			Me.lblTotalOil_14.HyperLink = Nothing
			Me.lblTotalOil_14.Left = 5.6875F
			Me.lblTotalOil_14.Name = "lblTotalOil_14"
			Me.lblTotalOil_14.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalOil_14.Text = " "
			Me.lblTotalOil_14.Top = 9F
			Me.lblTotalOil_14.Width = 0.6875F
			Me.lblTotalWater_14.Height = 0.1875F
			Me.lblTotalWater_14.HyperLink = Nothing
			Me.lblTotalWater_14.Left = 6.5F
			Me.lblTotalWater_14.Name = "lblTotalWater_14"
			Me.lblTotalWater_14.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_14.Text = " "
			Me.lblTotalWater_14.Top = 9F
			Me.lblTotalWater_14.Width = 0.6875F
			Me.lblTotalWater_13.Height = 0.1875F
			Me.lblTotalWater_13.HyperLink = Nothing
			Me.lblTotalWater_13.Left = 6.5F
			Me.lblTotalWater_13.Name = "lblTotalWater_13"
			Me.lblTotalWater_13.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_13.Text = " "
			Me.lblTotalWater_13.Top = 8.8125F
			Me.lblTotalWater_13.Width = 0.6875F
			Me.lblTotalWater_12.Height = 0.1875F
			Me.lblTotalWater_12.HyperLink = Nothing
			Me.lblTotalWater_12.Left = 6.5F
			Me.lblTotalWater_12.Name = "lblTotalWater_12"
			Me.lblTotalWater_12.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_12.Text = " "
			Me.lblTotalWater_12.Top = 8.625F
			Me.lblTotalWater_12.Width = 0.6875F
			Me.lblTotalWater_11.Height = 0.1875F
			Me.lblTotalWater_11.HyperLink = Nothing
			Me.lblTotalWater_11.Left = 6.5F
			Me.lblTotalWater_11.Name = "lblTotalWater_11"
			Me.lblTotalWater_11.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalWater_11.Text = " "
			Me.lblTotalWater_11.Top = 8.4375F
			Me.lblTotalWater_11.Width = 0.6875F
			Me.lblTotalFluid_11.Height = 0.1875F
			Me.lblTotalFluid_11.HyperLink = Nothing
			Me.lblTotalFluid_11.Left = 7.3125F
			Me.lblTotalFluid_11.Name = "lblTotalFluid_11"
			Me.lblTotalFluid_11.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_11.Text = " "
			Me.lblTotalFluid_11.Top = 8.4375F
			Me.lblTotalFluid_11.Width = 0.5625F
			Me.lblTotalFluid_12.Height = 0.1875F
			Me.lblTotalFluid_12.HyperLink = Nothing
			Me.lblTotalFluid_12.Left = 7.3125F
			Me.lblTotalFluid_12.Name = "lblTotalFluid_12"
			Me.lblTotalFluid_12.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_12.Text = " "
			Me.lblTotalFluid_12.Top = 8.625F
			Me.lblTotalFluid_12.Width = 0.5625F
			Me.lblTotalFluid_13.Height = 0.1875F
			Me.lblTotalFluid_13.HyperLink = Nothing
			Me.lblTotalFluid_13.Left = 7.3125F
			Me.lblTotalFluid_13.Name = "lblTotalFluid_13"
			Me.lblTotalFluid_13.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_13.Text = " "
			Me.lblTotalFluid_13.Top = 8.8125F
			Me.lblTotalFluid_13.Width = 0.5625F
			Me.lblTotalFluid_14.Height = 0.1875F
			Me.lblTotalFluid_14.HyperLink = Nothing
			Me.lblTotalFluid_14.Left = 7.3125F
			Me.lblTotalFluid_14.Name = "lblTotalFluid_14"
			Me.lblTotalFluid_14.Style = "text-align: center; font-size: 8pt"
			Me.lblTotalFluid_14.Text = " "
			Me.lblTotalFluid_14.Top = 9F
			Me.lblTotalFluid_14.Width = 0.5625F
			Me.MasterReport = False
			Me.PageSettings.Margins.Bottom = 0F
			Me.PageSettings.Margins.Left = 0.5F
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
			CType(Me.lblLabel2, ISupportInitialize).EndInit()
			CType(Me.lblCompany, ISupportInitialize).EndInit()
			CType(Me.lblWellName, ISupportInitialize).EndInit()
			CType(Me.lblDiskFile, ISupportInitialize).EndInit()
			CType(Me.lblComment, ISupportInitialize).EndInit()
			CType(Me.lblTitle1, ISupportInitialize).EndInit()
			CType(Me.lblPage, ISupportInitialize).EndInit()
			CType(Me.txtPage1, ISupportInitialize).EndInit()
			CType(Me.lblOf, ISupportInitialize).EndInit()
			CType(Me.txtPage2, ISupportInitialize).EndInit()
			CType(Me.lblUserName, ISupportInitialize).EndInit()
			CType(Me.lblUserDate, ISupportInitialize).EndInit()
			CType(Me.lblSecondCompanyName, ISupportInitialize).EndInit()
			CType(Me.lblSecondCompanyPhonenumber, ISupportInitialize).EndInit()
			CType(Me.lblGoTheta, ISupportInitialize).EndInit()
			CType(Me.picIPR, ISupportInitialize).EndInit()
			CType(Me.lblHeader1, ISupportInitialize).EndInit()
			CType(Me.lblHeader2, ISupportInitialize).EndInit()
			CType(Me.lblInflowPerformanceData, ISupportInitialize).EndInit()
			CType(Me.lblMidPerfDepth, ISupportInitialize).EndInit()
			CType(Me.lblStaticBottomholePressure, ISupportInitialize).EndInit()
			CType(Me.lblBubblePointPressure, ISupportInitialize).EndInit()
			CType(Me.lblPressureTestPoints, ISupportInitialize).EndInit()
			CType(Me.lblPumpIntakePressure, ISupportInitialize).EndInit()
			CType(Me.lblFlowingBHPressure, ISupportInitialize).EndInit()
			CType(Me.lblProduction, ISupportInitialize).EndInit()
			CType(Me.Label1, ISupportInitialize).EndInit()
			CType(Me.lblFluidLevelOverPump, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP, ISupportInitialize).EndInit()
			CType(Me.lblProdBH, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid, ISupportInitialize).EndInit()
			CType(Me.lblPerfNote, ISupportInitialize).EndInit()
			CType(Me.lblTestPIP_1, ISupportInitialize).EndInit()
			CType(Me.lblTestPIP_2, ISupportInitialize).EndInit()
			CType(Me.lblTestPIP_3, ISupportInitialize).EndInit()
			CType(Me.lblTestPIP_4, ISupportInitialize).EndInit()
			CType(Me.lblTestPIP_5, ISupportInitialize).EndInit()
			CType(Me.lblTestPIP_6, ISupportInitialize).EndInit()
			CType(Me.lblTestPIP_7, ISupportInitialize).EndInit()
			CType(Me.lblTestPIP_8, ISupportInitialize).EndInit()
			CType(Me.lblTestPIP_9, ISupportInitialize).EndInit()
			CType(Me.lblTestPIP_10, ISupportInitialize).EndInit()
			CType(Me.lblTestBH_1, ISupportInitialize).EndInit()
			CType(Me.lblTestBH_2, ISupportInitialize).EndInit()
			CType(Me.lblTestBH_3, ISupportInitialize).EndInit()
			CType(Me.lblTestBH_4, ISupportInitialize).EndInit()
			CType(Me.lblTestBH_5, ISupportInitialize).EndInit()
			CType(Me.lblTestBH_6, ISupportInitialize).EndInit()
			CType(Me.lblTestBH_7, ISupportInitialize).EndInit()
			CType(Me.lblTestBH_8, ISupportInitialize).EndInit()
			CType(Me.lblTestBH_9, ISupportInitialize).EndInit()
			CType(Me.lblTestBH_10, ISupportInitialize).EndInit()
			CType(Me.lblTestProd_1, ISupportInitialize).EndInit()
			CType(Me.lblTestProd_2, ISupportInitialize).EndInit()
			CType(Me.lblTestProd_3, ISupportInitialize).EndInit()
			CType(Me.lblTestProd_4, ISupportInitialize).EndInit()
			CType(Me.lblTestProd_5, ISupportInitialize).EndInit()
			CType(Me.lblTestProd_6, ISupportInitialize).EndInit()
			CType(Me.lblTestProd_7, ISupportInitialize).EndInit()
			CType(Me.lblTestProd_8, ISupportInitialize).EndInit()
			CType(Me.lblTestProd_9, ISupportInitialize).EndInit()
			CType(Me.lblTestProd_10, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_1, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_2, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_3, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_4, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_5, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_6, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_7, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_8, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_9, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_10, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_1, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_2, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_3, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_4, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_5, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_6, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_7, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_8, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_9, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_10, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_1, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_2, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_3, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_4, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_5, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_6, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_7, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_8, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_9, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_10, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_1, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_2, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_3, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_4, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_5, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_6, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_7, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_8, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_9, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_10, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_1, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_2, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_3, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_4, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_5, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_6, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_7, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_8, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_9, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_10, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_1, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_2, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_3, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_4, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_5, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_6, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_7, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_8, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_9, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_10, ISupportInitialize).EndInit()
			CType(Me.lblProdNote, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_11, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_14, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_13, ISupportInitialize).EndInit()
			CType(Me.lblProdFL_12, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_11, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_12, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_13, ISupportInitialize).EndInit()
			CType(Me.lblProdPIP_14, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_14, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_13, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_12, ISupportInitialize).EndInit()
			CType(Me.lblProdBH_11, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_11, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_12, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_13, ISupportInitialize).EndInit()
			CType(Me.lblTotalOil_14, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_14, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_13, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_12, ISupportInitialize).EndInit()
			CType(Me.lblTotalWater_11, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_11, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_12, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_13, ISupportInitialize).EndInit()
			CType(Me.lblTotalFluid_14, ISupportInitialize).EndInit()
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		Public Property Header1 As String
			Get
				Return Me.m_Header1
			End Get
			Set(value As String)
				Me.m_Header1 = value
			End Set
		End Property

		Public Property Header2 As String
			Get
				Return Me.m_Header2
			End Get
			Set(value As String)
				Me.m_Header2 = value
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

		Public Property bPrint As Boolean
			Get
				Return Me.m_bPrint
			End Get
			Set(value As Boolean)
				Me.m_bPrint = value
				Me.PageSettings.Orientation = PageOrientation.Portrait
			End Set
		End Property

		Public Property PBP As String
			Get
				Return Me.m_PBP
			End Get
			Set(value As String)
				Me.m_PBP = value
			End Set
		End Property

		Public Property PIP As String
			Get
				Return Me.m_PIP
			End Get
			Set(value As String)
				Me.m_PIP = value
			End Set
		End Property

		Public Property OBPD As String
			Get
				Return Me.m_OBPD
			End Get
			Set(value As String)
				Me.m_OBPD = value
			End Set
		End Property

		Public Property WBPD As String
			Get
				Return Me.m_WBPD
			End Get
			Set(value As String)
				Me.m_WBPD = value
			End Set
		End Property

		Public Property FBPD As String
			Get
				Return Me.m_FBPD
			End Get
			Set(value As String)
				Me.m_FBPD = value
			End Set
		End Property

		Public Sub rptIPR_ReportStart(sender As Object, e As EventArgs)
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bChangeCultures Then
				Dim setup_Language As String = RSWIN_DESC.SETUP_Language
				If Operators.CompareString(setup_Language, RSWIN_DESC.sEnglish, False) = 0 Then
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
				ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sSpanish, False) = 0 Then
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
				ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sChinese, False) = 0 Then
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
				Else
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
				End If
				Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
				If RSWIN_DESC.bReadResXFile Then
					Me.ReadReportControlStrings()
				End If
			End If
			Me.printFont = New Font("Arial", 10F)
			If Not Me.m_bPrint Then
				Me.PageSettings.Margins.Left = 0.25F
				Me.PageSettings.Margins.Right = 0F
				Me.PageSettings.Margins.Top = 0.25F
				Me.PageSettings.Margins.Bottom = 0F
			Else
				Me.PageSettings.Margins.Left = 0.25F
				Me.PageSettings.Margins.Right = 0F
				Me.PageSettings.Margins.Top = 0.25F
				Me.PageSettings.Margins.Bottom = 0F
			End If
			Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
			Me.lblHeader1.Text = Me.m_Header1
			Me.lblHeader2.Text = Me.m_Header2
			Me.ShowIPRData(RSWIN_DESC.rst.gbUseIPR)
			Try
				If RSWIN_DESC.bIntVersion Then
					If RSWIN_DESC.bWriteResXFile Then
						Util.OpenResourceWriter("IPRReport")
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
					Me.lblPage.Visible = True
					Me.txtPage1.Visible = True
					Me.lblOf.Visible = True
					Me.txtPage2.Visible = True
				Else
					Me.lblPage.Visible = False
					Me.txtPage1.Visible = False
					Me.lblOf.Visible = False
					Me.txtPage2.Visible = False
				End If
				Me.lblWellName.Text = Me.sWell + ": " + Strings.Trim(rst.WellName)
				Dim text4 As String = Me.sThetaEnterprises
				Me.lblUserName.Text = Me.sUser + ": " + Strings.Trim(rst.UserName)
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

		Public Sub ImportIPRChart()
			Try
				Dim dataObject As IDataObject = Clipboard.GetDataObject()
				If dataObject.GetDataPresent(DataFormats.Bitmap) Then
					Me.picIPR.Image = CType(dataObject.GetData(DataFormats.Bitmap), Image)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PageHeader_Format(sender As Object, e As EventArgs)
		End Sub

		Private Sub GroupHeader1_Format(sender As Object, e As EventArgs)
		End Sub

		Private Sub ShowIPRData(bShowProd As Boolean)
			Me.lblInflowPerformanceData.Text = "Inflow Performance Data:"
			Dim text As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				text = "ft"
			Else
				text = "m"
			End If
			Dim label As DataDynamics.ActiveReports.Label = Me.lblMidPerfDepth
			Dim str As String = "Mid-perf depth ("
			Dim str2 As String = text
			Dim str3 As String = "):  "
			Dim num As Single = CtrlUI.ConvertUnits(RSWIN_DESC.rst.MidPerfDepth, 1)
			Dim text2 As String = "0"
			label.Text = str + str2 + str3 + Util.Format(num, text2)
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				text = "psi"
			Else
				text = "kPa"
			End If
			Dim label2 As DataDynamics.ActiveReports.Label = Me.lblStaticBottomholePressure
			Dim str4 As String = "Static bottomhole pressure ("
			Dim str5 As String = text
			Dim str6 As String = "):  "
			num = CtrlUI.ConvertUnits(RSWIN_DESC.rst.StaticBHPressure, 7)
			text2 = "0"
			label2.Text = str4 + str5 + str6 + Util.Format(num, text2)
			If RSWIN_DESC.rst.gbProducingBelowBPP Then
				Me.lblPerfNote.Text = "Well is producing below the bubble point"
			Else
				Me.lblPerfNote.Text = ""
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					text = "psi"
				Else
					text = "kPa"
				End If
				Dim label3 As DataDynamics.ActiveReports.Label = Me.lblBubblePointPressure
				Dim str7 As String = "Bubble point pressure ("
				Dim str8 As String = text
				Dim str9 As String = "):  "
				num = CtrlUI.ConvertUnits(RSWIN_DESC.rst.BubblePoint, 7)
				text2 = "0"
				label3.Text = str7 + str8 + str9 + Util.Format(num, text2)
			End If
			Me.SetTargetLineDefaultHeights()
			Me.SetProdLineDefaultHeights()
			Me.ShowIPRTestPoints()
			If bShowProd Then
				Me.ShowIPRProduction()
				Return
			End If
		End Sub

		Private Sub SetTargetLineDefaultHeights()
			Me.Line1.Y2 = CSng((CDbl(Me.Line1.Y1) + 0.4))
			Me.Line3.Y2 = CSng((CDbl(Me.Line3.Y1) + 0.4))
			Me.lblTestPIP_1.Text = ""
			Me.lblTestBH_1.Text = ""
			Me.lblTestProd_1.Text = ""
			Me.lblTestPIP_2.Text = ""
			Me.lblTestBH_2.Text = ""
			Me.lblTestProd_2.Text = ""
			Me.lblTestPIP_3.Text = ""
			Me.lblTestBH_3.Text = ""
			Me.lblTestProd_3.Text = ""
			Me.lblTestPIP_4.Text = ""
			Me.lblTestBH_4.Text = ""
			Me.lblTestProd_4.Text = ""
			Me.lblTestPIP_5.Text = ""
			Me.lblTestBH_5.Text = ""
			Me.lblTestProd_5.Text = ""
			Me.lblTestPIP_6.Text = ""
			Me.lblTestBH_6.Text = ""
			Me.lblTestProd_6.Text = ""
			Me.lblTestPIP_7.Text = ""
			Me.lblTestBH_7.Text = ""
			Me.lblTestProd_7.Text = ""
			Me.lblTestPIP_8.Text = ""
			Me.lblTestBH_8.Text = ""
			Me.lblTestProd_8.Text = ""
			Me.lblTestPIP_9.Text = ""
			Me.lblTestBH_9.Text = ""
			Me.lblTestProd_9.Text = ""
			Me.lblTestPIP_10.Text = ""
			Me.lblTestBH_10.Text = ""
			Me.lblTestProd_10.Text = ""
		End Sub

		Private Sub SetProdLineDefaultHeights()
			Me.Line5.Y2 = CSng((CDbl(Me.Line5.Y1) + 0.4))
			Me.Line6.Y2 = CSng((CDbl(Me.Line6.Y1) + 0.4))
			Me.Line8.Y2 = CSng((CDbl(Me.Line8.Y1) + 0.4))
			Me.Line9.Y2 = CSng((CDbl(Me.Line9.Y1) + 0.4))
			Me.Line10.Y2 = CSng((CDbl(Me.Line10.Y1) + 0.4))
			Me.lblProdFL_1.Text = ""
			Me.lblProdPIP_1.Text = ""
			Me.lblProdBH_1.Text = ""
			Me.lblTotalOil_1.Text = ""
			Me.lblTotalWater_1.Text = ""
			Me.lblTotalFluid_1.Text = ""
			Me.lblProdFL_2.Text = ""
			Me.lblProdPIP_2.Text = ""
			Me.lblProdBH_2.Text = ""
			Me.lblTotalOil_2.Text = ""
			Me.lblTotalWater_2.Text = ""
			Me.lblTotalFluid_2.Text = ""
			Me.lblProdFL_3.Text = ""
			Me.lblProdPIP_3.Text = ""
			Me.lblProdBH_3.Text = ""
			Me.lblTotalOil_3.Text = ""
			Me.lblTotalWater_3.Text = ""
			Me.lblTotalFluid_3.Text = ""
			Me.lblProdFL_4.Text = ""
			Me.lblProdPIP_4.Text = ""
			Me.lblProdBH_4.Text = ""
			Me.lblTotalOil_4.Text = ""
			Me.lblTotalWater_4.Text = ""
			Me.lblTotalFluid_4.Text = ""
			Me.lblProdFL_5.Text = ""
			Me.lblProdPIP_5.Text = ""
			Me.lblProdBH_5.Text = ""
			Me.lblTotalOil_5.Text = ""
			Me.lblTotalWater_5.Text = ""
			Me.lblTotalFluid_5.Text = ""
			Me.lblProdFL_6.Text = ""
			Me.lblProdPIP_6.Text = ""
			Me.lblProdBH_6.Text = ""
			Me.lblTotalOil_6.Text = ""
			Me.lblTotalWater_6.Text = ""
			Me.lblTotalFluid_6.Text = ""
			Me.lblProdFL_7.Text = ""
			Me.lblProdPIP_7.Text = ""
			Me.lblProdBH_7.Text = ""
			Me.lblTotalOil_7.Text = ""
			Me.lblTotalWater_7.Text = ""
			Me.lblTotalFluid_7.Text = ""
			Me.lblProdFL_8.Text = ""
			Me.lblProdPIP_8.Text = ""
			Me.lblProdBH_8.Text = ""
			Me.lblTotalOil_8.Text = ""
			Me.lblTotalWater_8.Text = ""
			Me.lblTotalFluid_8.Text = ""
			Me.lblProdFL_9.Text = ""
			Me.lblProdPIP_9.Text = ""
			Me.lblProdBH_9.Text = ""
			Me.lblTotalOil_9.Text = ""
			Me.lblTotalWater_9.Text = ""
			Me.lblTotalFluid_9.Text = ""
			Me.lblProdFL_10.Text = ""
			Me.lblProdPIP_10.Text = ""
			Me.lblProdBH_10.Text = ""
			Me.lblTotalOil_10.Text = ""
			Me.lblTotalWater_10.Text = ""
			Me.lblTotalFluid_10.Text = ""
			Me.lblProdFL_11.Text = ""
			Me.lblProdPIP_11.Text = ""
			Me.lblProdBH_11.Text = ""
			Me.lblTotalOil_11.Text = ""
			Me.lblTotalWater_11.Text = ""
			Me.lblTotalFluid_11.Text = ""
			Me.lblProdFL_12.Text = ""
			Me.lblProdPIP_12.Text = ""
			Me.lblProdBH_12.Text = ""
			Me.lblTotalOil_12.Text = ""
			Me.lblTotalWater_12.Text = ""
			Me.lblTotalFluid_12.Text = ""
			Me.lblProdFL_13.Text = ""
			Me.lblProdPIP_13.Text = ""
			Me.lblProdBH_13.Text = ""
			Me.lblTotalOil_13.Text = ""
			Me.lblTotalWater_13.Text = ""
			Me.lblTotalFluid_13.Text = ""
			Me.lblProdFL_14.Text = ""
			Me.lblProdPIP_14.Text = ""
			Me.lblProdBH_14.Text = ""
			Me.lblTotalOil_14.Text = ""
			Me.lblTotalWater_14.Text = ""
			Me.lblTotalFluid_14.Text = ""
			Me.lblProdNote.Text = ""
		End Sub

		Private Sub IncrProdLineHeights(fIncr As Single)
			Me.Line5.Y2 = Me.Line5.Y2 + fIncr
			Me.Line6.Y2 = Me.Line6.Y2 + fIncr
			Me.Line8.Y2 = Me.Line8.Y2 + fIncr
			Me.Line9.Y2 = Me.Line9.Y2 + fIncr
			Me.Line10.Y2 = Me.Line10.Y2 + fIncr
		End Sub

		Private Sub IncrTargetLineHeights(fIncr As Single)
			Me.Line1.Y2 = Me.Line1.Y2 + fIncr
			Me.Line3.Y2 = Me.Line3.Y2 + fIncr
		End Sub

		Private Sub ShowIPRProduction()
			Dim array As Single() = New Single(5) {}
			Dim array2 As String(,) = New String(2, 1) {}
			Dim array3 As String(,) = New String(2, 1) {}
			Dim flag As Boolean = False
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Single
			Dim num2 As Single
			If rst.SPMEntered <> 0S Then
				num = 0F
				num2 = 0F
			Else
				Dim pwf As Single = IPR.iprPwfFromFluidProduction(rst.TargetBFPD)
				num = IPR.iprPipFromPwf(pwf)
				num2 = CSng((Conversion.Int(CDbl((CtrlUI.ConvertUnits(num, 7) * 10F)) + 0.5) / 10.0))
			End If
			Me.lblFluidLevelOverPump.Text = Conversions.ToString(Operators.ConcatenateObject("Fluid level over pump ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " (ft)", " (m)")))
			Me.lblProdPIP.Text = Conversions.ToString(Operators.ConcatenateObject("Pump intake pressure ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " (psi)", " (kPa)")))
			Me.lblProdBH.Text = Conversions.ToString(Operators.ConcatenateObject("Flowing b.h. pressure ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " (psi)", " (kPa)")))
			Me.lblTotalOil.Text = Conversions.ToString(Operators.ConcatenateObject("Total oil ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " (BOPD)", " (m³/D)")))
			Me.lblTotalWater.Text = Conversions.ToString(Operators.ConcatenateObject("Total water ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " (BWPD)", " (m³/D)")))
			Me.lblTotalFluid.Text = Conversions.ToString(Operators.ConcatenateObject("Total fluid ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " (BFPD)", " (m³/D)")))
			Dim num3 As Single = CSng((CDbl(rst.CasingPressure) + 14.7))
			Dim num4 As Single = rst.StaticBHPressure
			Dim num5 As Integer
			Dim num6 As Single
			Dim i As Integer
			If rst.PumpIntakePressure - num3 <= 10F Then
				num5 = 1
				num6 = 1F
			Else
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					num3 *= RSWIN_DESC.PSI__KPA
					num4 *= RSWIN_DESC.PSI__KPA
				End If
				Dim num7 As Single = CSng((Conversion.Int(CDbl((num3 / 10F)) + 0.5) * 10.0))
				If(CDbl((num7 - rst.CasingPressure)) - 14.7) / (CDbl(rst.OilSPGR) * 0.433) >= 0.0 Then
					num3 = num7
				Else
					num3 = CSng((Conversion.Int(CDbl((num3 / 10F)) + 1.5) * 10.0))
				End If
				num4 = Conversion.Int(num4 / 10F) * 10F
				If num4 - num3 < 80F Then
					num6 = 10F
					num5 = CInt(Math.Round(CDbl(Conversion.Int(num4 - num3 / num6))))
				Else
					num5 = 0
					i = 1
					Dim num8 As Single
					While True
						num6 = Conversions.ToSingle(Operators.MultiplyObject(i, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 25, 100)))
						num7 = CSng((Conversion.Int(CDbl((num3 / num6)) + 0.5) * CDbl(num6)))
						If(CDbl((num7 - rst.CasingPressure)) - 14.7) / (CDbl(rst.OilSPGR) * 0.433) < 0.0 Then
							num7 = CSng((Conversion.Int(CDbl((num3 / num6)) + 1.5) * CDbl(num6)))
						End If
						num8 = Conversion.Int(CtrlUI.ConvertUnits(rst.PumpIntakePressure, 7) / num6) * num6
						If Conversion.Int((num8 - num7) / num6) <= 8F Then
							Exit For
						End If
						i += 1
						If i > 4 Then
							GoTo IL_3A9
						End If
					End While
					num4 = num8
					num3 = num7
					IL_3A9:
					If num5 = 0 Then
						num4 = 7F * num6 + num3
					End If
					num5 = CInt(Math.Round(CDbl((Conversion.Int((num4 - num3) / num6) + 1F))))
				End If
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					num3 /= RSWIN_DESC.PSI__KPA
					num4 /= RSWIN_DESC.PSI__KPA
					num6 /= RSWIN_DESC.PSI__KPA
				End If
			End If
			flag = False
			i = num5 - 1
			While i >= 0

					Dim num9 As Single = CSng((Conversion.Int(CDbl((CtrlUI.ConvertUnits(num3 + CSng(i) * num6, 7) * 10F)) + 0.5) / 10.0))
					If num > 0F And num2 >= num9 Then
						Dim num10 As Single = num
						Dim num11 As Single = IPR.iprPwfFromPip(num10)
						Dim num12 As Single = CtrlUI.ConvertUnits(CSng(((CDbl((num10 - rst.CasingPressure)) - 14.7) / (CDbl(rst.OilSPGR) * 0.433))), 1)
						Dim num13 As Single = CtrlUI.ConvertUnits(IPR.iprProductionFromPwf(num11), 0)
						Dim num14 As Single = CtrlUI.ConvertUnits((rst.StaticBHPressure - num11) * rst.WaterPI, 0)
						Dim text As String = "0.0"
						Dim sLabel As String = Util.Format(num12, text)
						Dim num15 As Single = CtrlUI.ConvertUnits(num10, 7)
						text = "0.0"
						Dim sLabel2 As String = Util.Format(num15, text)
						num15 = CtrlUI.ConvertUnits(num11, 7)
						text = "0.0"
						Dim sLabel3 As String = Util.Format(num15, text)
						text = "0.0"
						Dim sLabel4 As String = Util.Format(num13, text)
						text = "0.0"
						Dim sLabel5 As String = Util.Format(num14, text)
						num15 = num13 + num14
						text = "0.0"
						Dim sLabel6 As String = Util.Format(num15, text)
						Me.SetProdLabelArrayElement(i, sLabel, sLabel2, sLabel3, sLabel4, sLabel5, sLabel6, flag)
						num = 0F
					End If
					If num2 <> num9 Then
						Dim num10 As Single = num3 + CSng(i) * num6
						Dim num11 As Single = IPR.iprPwfFromPip(num10)
						Dim num12 As Single = CtrlUI.ConvertUnits(CSng(((CDbl((num10 - rst.CasingPressure)) - 14.7) / (CDbl(rst.OilSPGR) * 0.433))), 1)
						Dim num13 As Single = CtrlUI.ConvertUnits(IPR.iprProductionFromPwf(num11), 0)
						Dim num14 As Single = CtrlUI.ConvertUnits((rst.StaticBHPressure - num11) * rst.WaterPI, 0)
						Dim text As String = "0.0"
						Dim sLabel As String = Util.Format(num12, text)
						Dim num15 As Single = CtrlUI.ConvertUnits(num10, 7)
						text = "0.0"
						Dim sLabel2 As String = Util.Format(num15, text)
						num15 = CtrlUI.ConvertUnits(num11, 7)
						text = "0.0"
						Dim sLabel3 As String = Util.Format(num15, text)
						text = "0.0"
						Dim sLabel4 As String = Util.Format(num13, text)
						text = "0.0"
						Dim sLabel5 As String = Util.Format(num14, text)
						num15 = num13 + num14
						text = "0.0"
						Dim sLabel6 As String = Util.Format(num15, text)
						Me.SetProdLabelArrayElement(i, sLabel, sLabel2, sLabel3, sLabel4, sLabel5, sLabel6, flag)
					End If

				i += -1
			End While
			If num > 0F Then
				Dim num10 As Single = num
				Dim num11 As Single = IPR.iprPwfFromPip(num10)
				Dim num12 As Single = CtrlUI.ConvertUnits(CSng(((CDbl((num10 - rst.CasingPressure)) - 14.7) / (CDbl(rst.OilSPGR) * 0.433))), 1)
				Dim num13 As Single = CtrlUI.ConvertUnits(IPR.iprProductionFromPwf(num11), 0)
				Dim num14 As Single = CtrlUI.ConvertUnits((rst.StaticBHPressure - num11) * rst.WaterPI, 0)
				Dim text As String = "0.0"
				Dim sLabel As String = Util.Format(num12, text)
				Dim num15 As Single = CtrlUI.ConvertUnits(num10, 7)
				text = "0.0"
				Dim sLabel2 As String = Util.Format(num15, text)
				num15 = CtrlUI.ConvertUnits(num11, 7)
				text = "0.0"
				Dim sLabel3 As String = Util.Format(num15, text)
				text = "0.0"
				Dim sLabel4 As String = Util.Format(num13, text)
				text = "0.0"
				Dim sLabel5 As String = Util.Format(num14, text)
				num15 = num13 + num14
				text = "0.0"
				Dim sLabel6 As String = Util.Format(num15, text)
				Me.SetProdLabelArrayElement(i, sLabel, sLabel2, sLabel3, sLabel4, sLabel5, sLabel6, flag)
			End If
			If num2 > 0F Then
			End If
			Me.lblProdNote.Text = "Fluid level assumes 100% oil in the annulus."
		End Sub

		Private Sub SetProdLabelArrayElement(I As Integer, sLabel1 As String, sLabel2 As String, sLabel3 As String, sLabel4 As String, sLabel5 As String, sLabel6 As String, ByRef bTopSet As Boolean)
			' The following expression was wrapped in a checked-expression
			Select Case I + 1
				Case 1
					Me.lblProdFL_1.Text = sLabel1
					Me.lblProdPIP_1.Text = sLabel2
					Me.lblProdBH_1.Text = sLabel3
					Me.lblTotalOil_1.Text = sLabel4
					Me.lblTotalWater_1.Text = sLabel5
					Me.lblTotalFluid_1.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_1.Top + Me.lblTotalFluid_1.Height)) + 0.2))
					End If
				Case 2
					Me.lblProdFL_2.Text = sLabel1
					Me.lblProdPIP_2.Text = sLabel2
					Me.lblProdBH_2.Text = sLabel3
					Me.lblTotalOil_2.Text = sLabel4
					Me.lblTotalWater_2.Text = sLabel5
					Me.lblTotalFluid_2.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_2.Top + Me.lblTotalFluid_2.Height)) + 0.2))
					End If
				Case 3
					Me.lblProdFL_3.Text = sLabel1
					Me.lblProdPIP_3.Text = sLabel2
					Me.lblProdBH_3.Text = sLabel3
					Me.lblTotalOil_3.Text = sLabel4
					Me.lblTotalWater_3.Text = sLabel5
					Me.lblTotalFluid_3.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_3.Top + Me.lblTotalFluid_3.Height)) + 0.2))
					End If
				Case 4
					Me.lblProdFL_4.Text = sLabel1
					Me.lblProdPIP_4.Text = sLabel2
					Me.lblProdBH_4.Text = sLabel3
					Me.lblTotalOil_4.Text = sLabel4
					Me.lblTotalWater_4.Text = sLabel5
					Me.lblTotalFluid_4.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_4.Top + Me.lblTotalFluid_4.Height)) + 0.2))
					End If
				Case 5
					Me.lblProdFL_5.Text = sLabel1
					Me.lblProdPIP_5.Text = sLabel2
					Me.lblProdBH_5.Text = sLabel3
					Me.lblTotalOil_5.Text = sLabel4
					Me.lblTotalWater_5.Text = sLabel5
					Me.lblTotalFluid_5.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_5.Top + Me.lblTotalFluid_5.Height)) + 0.2))
					End If
				Case 6
					Me.lblProdFL_6.Text = sLabel1
					Me.lblProdPIP_6.Text = sLabel2
					Me.lblProdBH_6.Text = sLabel3
					Me.lblTotalOil_6.Text = sLabel4
					Me.lblTotalWater_6.Text = sLabel5
					Me.lblTotalFluid_6.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_6.Top + Me.lblTotalFluid_6.Height)) + 0.2))
					End If
				Case 7
					Me.lblProdFL_7.Text = sLabel1
					Me.lblProdPIP_7.Text = sLabel2
					Me.lblProdBH_7.Text = sLabel3
					Me.lblTotalOil_7.Text = sLabel4
					Me.lblTotalWater_7.Text = sLabel5
					Me.lblTotalFluid_7.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_7.Top + Me.lblTotalFluid_7.Height)) + 0.2))
					End If
				Case 8
					Me.lblProdFL_8.Text = sLabel1
					Me.lblProdPIP_8.Text = sLabel2
					Me.lblProdBH_8.Text = sLabel3
					Me.lblTotalOil_8.Text = sLabel4
					Me.lblTotalWater_8.Text = sLabel5
					Me.lblTotalFluid_8.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_8.Top + Me.lblTotalFluid_8.Height)) + 0.2))
					End If
				Case 9
					Me.lblProdFL_9.Text = sLabel1
					Me.lblProdPIP_9.Text = sLabel2
					Me.lblProdBH_9.Text = sLabel3
					Me.lblTotalOil_9.Text = sLabel4
					Me.lblTotalWater_9.Text = sLabel5
					Me.lblTotalFluid_9.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_9.Top + Me.lblTotalFluid_9.Height)) + 0.2))
					End If
				Case 10
					Me.lblProdFL_10.Text = sLabel1
					Me.lblProdPIP_10.Text = sLabel2
					Me.lblProdBH_10.Text = sLabel3
					Me.lblTotalOil_10.Text = sLabel4
					Me.lblTotalWater_10.Text = sLabel5
					Me.lblTotalFluid_10.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_10.Top + Me.lblTotalFluid_10.Height)) + 0.2))
					End If
				Case 11
					Me.lblProdFL_11.Text = sLabel1
					Me.lblProdPIP_11.Text = sLabel2
					Me.lblProdBH_11.Text = sLabel3
					Me.lblTotalOil_11.Text = sLabel4
					Me.lblTotalWater_11.Text = sLabel5
					Me.lblTotalFluid_11.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_11.Top + Me.lblTotalFluid_11.Height)) + 0.2))
					End If
				Case 12
					Me.lblProdFL_12.Text = sLabel1
					Me.lblProdPIP_12.Text = sLabel2
					Me.lblProdBH_12.Text = sLabel3
					Me.lblTotalOil_12.Text = sLabel4
					Me.lblTotalWater_12.Text = sLabel5
					Me.lblTotalFluid_12.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_12.Top + Me.lblTotalFluid_12.Height)) + 0.2))
					End If
				Case 13
					Me.lblProdFL_13.Text = sLabel1
					Me.lblProdPIP_13.Text = sLabel2
					Me.lblProdBH_13.Text = sLabel3
					Me.lblTotalOil_13.Text = sLabel4
					Me.lblTotalWater_13.Text = sLabel5
					Me.lblTotalFluid_13.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_13.Top + Me.lblTotalFluid_13.Height)) + 0.2))
					End If
				Case 14
					Me.lblProdFL_14.Text = sLabel1
					Me.lblProdPIP_14.Text = sLabel2
					Me.lblProdBH_14.Text = sLabel3
					Me.lblTotalOil_14.Text = sLabel4
					Me.lblTotalWater_14.Text = sLabel5
					Me.lblTotalFluid_14.Text = sLabel6
					If Not bTopSet Then
						Me.lblProdNote.Top = CSng((CDbl((Me.lblTotalFluid_14.Top + Me.lblTotalFluid_14.Height)) + 0.2))
					End If
			End Select
			bTopSet = True
			Me.IncrProdLineHeights(Me.lblTestPIP_1.Height)
		End Sub

		Private Sub SetTargetLabelArrayElement(I As Integer, sLabel1 As String, sLabel2 As String, sLabel3 As String)
			Select Case I
				Case 1
					Me.lblTestPIP_1.Text = sLabel1
					Me.lblTestBH_1.Text = sLabel2
					Me.lblTestProd_1.Text = sLabel3
				Case 2
					Me.lblTestPIP_2.Text = sLabel1
					Me.lblTestBH_2.Text = sLabel2
					Me.lblTestProd_2.Text = sLabel3
				Case 3
					Me.lblTestPIP_3.Text = sLabel1
					Me.lblTestBH_3.Text = sLabel2
					Me.lblTestProd_3.Text = sLabel3
				Case 4
					Me.lblTestPIP_4.Text = sLabel1
					Me.lblTestBH_4.Text = sLabel2
					Me.lblTestProd_4.Text = sLabel3
				Case 5
					Me.lblTestPIP_5.Text = sLabel1
					Me.lblTestBH_5.Text = sLabel2
					Me.lblTestProd_5.Text = sLabel3
				Case 6
					Me.lblTestPIP_6.Text = sLabel1
					Me.lblTestBH_6.Text = sLabel2
					Me.lblTestProd_6.Text = sLabel3
				Case 7
					Me.lblTestPIP_7.Text = sLabel1
					Me.lblTestBH_7.Text = sLabel2
					Me.lblTestProd_7.Text = sLabel3
				Case 8
					Me.lblTestPIP_8.Text = sLabel1
					Me.lblTestBH_8.Text = sLabel2
					Me.lblTestProd_8.Text = sLabel3
				Case 9
					Me.lblTestPIP_9.Text = sLabel1
					Me.lblTestBH_9.Text = sLabel2
					Me.lblTestProd_9.Text = sLabel3
				Case 10
					Me.lblTestPIP_10.Text = sLabel1
					Me.lblTestBH_10.Text = sLabel2
					Me.lblTestProd_10.Text = sLabel3
			End Select
			Me.IncrTargetLineHeights(Me.lblTestPIP_1.Height)
		End Sub

		Private Sub ShowIPRTestPoints()
			Me.lblPumpIntakePressure.Text = Conversions.ToString(Operators.AddObject("Pump intake pressure ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " (psi)", " (kPa)")))
			Me.lblFlowingBHPressure.Text = Conversions.ToString(Operators.AddObject("Flowing b.h. pressure ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " (psi)", " (kPa)")))
			Me.lblProduction.Text = Conversions.ToString(Operators.ConcatenateObject("Production ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " (BPD)", " (m³/D)")))
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Integer = 1
			Dim gnTestPoints As Integer = CInt(rst.gnTestPoints)
			For i As Integer = num To gnTestPoints
				Dim num2 As Single = CtrlUI.ConvertUnits(rst.TestPoints(i).Pintake, 7)
				Dim text As String = "0"
				Dim sLabel As String = Util.Format(num2, text)
				num2 = CtrlUI.ConvertUnits(rst.TestPoints(i).Pwf, 7)
				text = "0"
				Dim sLabel2 As String = Util.Format(num2, text)
				num2 = CtrlUI.ConvertUnits(rst.TestPoints(i).Production, 0)
				text = "0.0"
				Dim sLabel3 As String = Util.Format(num2, text)
				Me.SetTargetLabelArrayElement(i, sLabel, sLabel2, sLabel3)
			Next
		End Sub

		Private Sub ReadReportControlStrings()
			Dim sPrefix As String = "IPRReport-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
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
							Me.AddRexResource(label.Name, label.Text)
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
							Me.AddRexResource(label.Name, label.Text)
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

		Private lblLabel2 As DataDynamics.ActiveReports.Label

		Private lblCompany As DataDynamics.ActiveReports.Label

		Private lblWellName As DataDynamics.ActiveReports.Label

		Private lblDiskFile As DataDynamics.ActiveReports.Label

		Private lblComment As DataDynamics.ActiveReports.Label

		Private lblTitle1 As DataDynamics.ActiveReports.Label

		Private lblPage As DataDynamics.ActiveReports.Label

		Private txtPage1 As DataDynamics.ActiveReports.TextBox

		Private lblOf As DataDynamics.ActiveReports.Label

		Private txtPage2 As DataDynamics.ActiveReports.TextBox

		Private lblUserName As DataDynamics.ActiveReports.Label

		Private lblUserDate As DataDynamics.ActiveReports.Label

		Private lblSecondCompanyName As DataDynamics.ActiveReports.Label

		Private lblSecondCompanyPhonenumber As DataDynamics.ActiveReports.Label

		Private lblGoTheta As DataDynamics.ActiveReports.Label

		Private picIPR As Picture

		Private lblHeader1 As DataDynamics.ActiveReports.Label

		Private lblHeader2 As DataDynamics.ActiveReports.Label

		Private lblInflowPerformanceData As DataDynamics.ActiveReports.Label

		Private lblMidPerfDepth As DataDynamics.ActiveReports.Label

		Private lblStaticBottomholePressure As DataDynamics.ActiveReports.Label

		Private lblBubblePointPressure As DataDynamics.ActiveReports.Label

		Private lblPressureTestPoints As DataDynamics.ActiveReports.Label

		Private lblPumpIntakePressure As DataDynamics.ActiveReports.Label

		Private lblFlowingBHPressure As DataDynamics.ActiveReports.Label

		Private lblProduction As DataDynamics.ActiveReports.Label

		Private Line2 As Line

		Private Line3 As Line

		Private Label1 As DataDynamics.ActiveReports.Label

		Private lblFluidLevelOverPump As DataDynamics.ActiveReports.Label

		Private lblProdPIP As DataDynamics.ActiveReports.Label

		Private lblProdBH As DataDynamics.ActiveReports.Label

		Private Line4 As Line

		Private Line5 As Line

		Private Line6 As Line

		Private lblTotalOil As DataDynamics.ActiveReports.Label

		Private lblTotalWater As DataDynamics.ActiveReports.Label

		Private lblTotalFluid As DataDynamics.ActiveReports.Label

		Private Line7 As Line

		Private Line8 As Line

		Private Line9 As Line

		Private Line10 As Line

		Private lblPerfNote As DataDynamics.ActiveReports.Label

		Private lblTestPIP_1 As DataDynamics.ActiveReports.Label

		Private lblTestPIP_2 As DataDynamics.ActiveReports.Label

		Private lblTestPIP_3 As DataDynamics.ActiveReports.Label

		Private lblTestPIP_4 As DataDynamics.ActiveReports.Label

		Private lblTestPIP_5 As DataDynamics.ActiveReports.Label

		Private lblTestPIP_6 As DataDynamics.ActiveReports.Label

		Private lblTestPIP_7 As DataDynamics.ActiveReports.Label

		Private lblTestPIP_8 As DataDynamics.ActiveReports.Label

		Private lblTestPIP_9 As DataDynamics.ActiveReports.Label

		Private lblTestPIP_10 As DataDynamics.ActiveReports.Label

		Private lblTestBH_1 As DataDynamics.ActiveReports.Label

		Private lblTestBH_2 As DataDynamics.ActiveReports.Label

		Private lblTestBH_3 As DataDynamics.ActiveReports.Label

		Private lblTestBH_4 As DataDynamics.ActiveReports.Label

		Private lblTestBH_5 As DataDynamics.ActiveReports.Label

		Private lblTestBH_6 As DataDynamics.ActiveReports.Label

		Private lblTestBH_7 As DataDynamics.ActiveReports.Label

		Private lblTestBH_8 As DataDynamics.ActiveReports.Label

		Private lblTestBH_9 As DataDynamics.ActiveReports.Label

		Private lblTestBH_10 As DataDynamics.ActiveReports.Label

		Private Line1 As Line

		Private lblTestProd_1 As DataDynamics.ActiveReports.Label

		Private lblTestProd_2 As DataDynamics.ActiveReports.Label

		Private lblTestProd_3 As DataDynamics.ActiveReports.Label

		Private lblTestProd_4 As DataDynamics.ActiveReports.Label

		Private lblTestProd_5 As DataDynamics.ActiveReports.Label

		Private lblTestProd_6 As DataDynamics.ActiveReports.Label

		Private lblTestProd_7 As DataDynamics.ActiveReports.Label

		Private lblTestProd_8 As DataDynamics.ActiveReports.Label

		Private lblTestProd_9 As DataDynamics.ActiveReports.Label

		Private lblTestProd_10 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_1 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_2 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_3 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_4 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_5 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_6 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_7 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_8 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_9 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_10 As DataDynamics.ActiveReports.Label

		Private lblProdFL_1 As DataDynamics.ActiveReports.Label

		Private lblProdFL_2 As DataDynamics.ActiveReports.Label

		Private lblProdFL_3 As DataDynamics.ActiveReports.Label

		Private lblProdFL_4 As DataDynamics.ActiveReports.Label

		Private lblProdFL_5 As DataDynamics.ActiveReports.Label

		Private lblProdFL_6 As DataDynamics.ActiveReports.Label

		Private lblProdFL_7 As DataDynamics.ActiveReports.Label

		Private lblProdFL_8 As DataDynamics.ActiveReports.Label

		Private lblProdFL_9 As DataDynamics.ActiveReports.Label

		Private lblProdFL_10 As DataDynamics.ActiveReports.Label

		Private lblProdBH_1 As DataDynamics.ActiveReports.Label

		Private lblProdBH_2 As DataDynamics.ActiveReports.Label

		Private lblProdBH_3 As DataDynamics.ActiveReports.Label

		Private lblProdBH_4 As DataDynamics.ActiveReports.Label

		Private lblProdBH_5 As DataDynamics.ActiveReports.Label

		Private lblProdBH_6 As DataDynamics.ActiveReports.Label

		Private lblProdBH_7 As DataDynamics.ActiveReports.Label

		Private lblProdBH_8 As DataDynamics.ActiveReports.Label

		Private lblProdBH_9 As DataDynamics.ActiveReports.Label

		Private lblProdBH_10 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_1 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_2 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_3 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_4 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_5 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_6 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_7 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_8 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_9 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_10 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_1 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_2 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_3 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_4 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_5 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_6 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_7 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_8 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_9 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_10 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_1 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_2 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_3 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_4 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_5 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_6 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_7 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_8 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_9 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_10 As DataDynamics.ActiveReports.Label

		Private lblProdNote As DataDynamics.ActiveReports.Label

		Private lblProdFL_11 As DataDynamics.ActiveReports.Label

		Private lblProdFL_14 As DataDynamics.ActiveReports.Label

		Private lblProdFL_13 As DataDynamics.ActiveReports.Label

		Private lblProdFL_12 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_11 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_12 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_13 As DataDynamics.ActiveReports.Label

		Private lblProdPIP_14 As DataDynamics.ActiveReports.Label

		Private lblProdBH_14 As DataDynamics.ActiveReports.Label

		Private lblProdBH_13 As DataDynamics.ActiveReports.Label

		Private lblProdBH_12 As DataDynamics.ActiveReports.Label

		Private lblProdBH_11 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_11 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_12 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_13 As DataDynamics.ActiveReports.Label

		Private lblTotalOil_14 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_14 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_13 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_12 As DataDynamics.ActiveReports.Label

		Private lblTotalWater_11 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_11 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_12 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_13 As DataDynamics.ActiveReports.Label

		Private lblTotalFluid_14 As DataDynamics.ActiveReports.Label

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

		Private m_Header1 As String

		Private m_Header2 As String

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer

		Private m_bPrint As Boolean

		Private m_PBP As String

		Private m_PIP As String

		Private m_OBPD As String

		Private m_WBPD As String

		Private m_FBPD As String

		Private printFont As Font
	End Class
End Namespace
