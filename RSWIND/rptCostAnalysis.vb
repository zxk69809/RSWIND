Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports DDCssLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class rptCostAnalysis
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.rptCostAnalysis_ReportStart
			Me.sCompany = Util.AssignValueToConstant("rptCalcResults", "sCompany", "Company: ")
			Me.sWell = Util.AssignValueToConstant("rptCalcResults", "sWell", "Well: ")
			Me.sUser = Util.AssignValueToConstant("rptCalcResults", "sUser", "User: ")
			Me.sDiskFile = Util.AssignValueToConstant("rptCalcResults", "sDiskFile", "Disk file: ")
			Me.sDate = Util.AssignValueToConstant("rptCalcResults", "sDate", "Date: ")
			Me.sPage = Util.AssignValueToConstant("rptCalcResults", "sPage", "Page")
			Me.sOf = Util.AssignValueToConstant("rptCalcResults", "sOf", "of")
			Me.sComment = Util.AssignValueToConstant("rptCalcResults", "sComment", "Comment: ")
			Me.sNA = Util.AssignValueToConstant("rptCalcResults", "sNA", "N/A")
			Me.sAirAtTankAt = Util.AssignValueToConstant("rptCalcResults", "sAirAtTankAt", "Air tank pressure at")
			Me.sLicenseTo = Util.AssignValueToConstant("rptCalcResults", "sLicenseTo", " - Licensed to ")
			Me.sThetaEnterprises = Util.AssignValueToConstant("rptCalcResults", "sThetaEnterprises", "(c) Theta Oilfield Services, Inc.")
			Me.PageHeader = Nothing
			Me.Detail = Nothing
			Me.PageFooter = Nothing
			Me.lblCost8 = Nothing
			Me.lblCost10 = Nothing
			Me.lblCost9 = Nothing
			Me.lblCost7 = Nothing
			Me.lblRodStringDesign = Nothing
			Me.Line11 = Nothing
			Me.lblRodDiamHdrTop = Nothing
			Me.lblRodDiamHdrBot = Nothing
			Me.lblRodDiam1 = Nothing
			Me.lblRodGradeHdrTop = Nothing
			Me.lblRodGradeHdrBot = Nothing
			Me.lblRodLengthHdrTop = Nothing
			Me.lblRodLengthHdrBot = Nothing
			Me.Line12 = Nothing
			Me.lblRodDiam2 = Nothing
			Me.lblRodDiam3 = Nothing
			Me.lblRodDiam4 = Nothing
			Me.lblRodDiam5 = Nothing
			Me.lblRodDiam6 = Nothing
			Me.lblRodDiam7 = Nothing
			Me.lblRodDiam8 = Nothing
			Me.lblRodGrade1 = Nothing
			Me.lblRodGrade2 = Nothing
			Me.lblRodGrade3 = Nothing
			Me.lblRodGrade4 = Nothing
			Me.lblRodGrade5 = Nothing
			Me.lblRodGrade6 = Nothing
			Me.lblRodGrade7 = Nothing
			Me.lblRodGrade8 = Nothing
			Me.lblRodLength1 = Nothing
			Me.lblRodLength2 = Nothing
			Me.lblRodLength3 = Nothing
			Me.lblRodLength4 = Nothing
			Me.lblRodLength5 = Nothing
			Me.lblRodLength6 = Nothing
			Me.lblRodLength7 = Nothing
			Me.lblRodLength8 = Nothing
			Me.linRSInputSep1 = Nothing
			Me.linRSInputSep2 = Nothing
			Me.linRSInputSep3 = Nothing
			Me.lblTotalCost1 = Nothing
			Me.lblTotalCost2 = Nothing
			Me.lblTotalCost3 = Nothing
			Me.lblTotalCost4 = Nothing
			Me.lblTotalCost5 = Nothing
			Me.lblTotalCost6 = Nothing
			Me.lblTotalCost7 = Nothing
			Me.lblTotalCost8 = Nothing
			Me.Line13 = Nothing
			Me.Label9 = Nothing
			Me.Label10 = Nothing
			Me.lblTotalRSCost2 = Nothing
			Me.lblPumpingUnitDesign = Nothing
			Me.lblTotalPUCost2 = Nothing
			Me.lblTotalPUCost = Nothing
			Me.lblManufacturer = Nothing
			Me.lblAPISize = Nothing
			Me.lblUnitName = Nothing
			Me.lblCost1 = Nothing
			Me.lblCost2 = Nothing
			Me.lblCost3 = Nothing
			Me.lblCost4 = Nothing
			Me.lblCost5 = Nothing
			Me.lblCost6 = Nothing
			Me.Line15 = Nothing
			Me.Label23 = Nothing
			Me.lblCostHdrBot = Nothing
			Me.lblTotalRSCost = Nothing
			Me.lblAddCosts = Nothing
			Me.lblAddCosts2 = Nothing
			Me.Line16 = Nothing
			Me.lblComment = Nothing
			Me.lblTitle1 = Nothing
			Me.lblPage = Nothing
			Me.txtPage1 = Nothing
			Me.lblOf = Nothing
			Me.txtPage2 = Nothing
			Me.lblUserName = Nothing
			Me.lblUserDate = Nothing
			Me.lblRodDiam9 = Nothing
			Me.lblRodGrade9 = Nothing
			Me.lblRodLength9 = Nothing
			Me.lblTotalCost9 = Nothing
			Me.lblRodDiam10 = Nothing
			Me.lblRodGrade10 = Nothing
			Me.lblRodLength10 = Nothing
			Me.lblTotalCost10 = Nothing
			Me.Line14 = Nothing
			Me.lblLabel2 = Nothing
			Me.lblCompany = Nothing
			Me.lblWellName = Nothing
			Me.lblDiskFile = Nothing
			Me.lblSecondCompanyName = Nothing
			Me.lblSecondCompanyPhonenumber = Nothing
			Me.lblGoTheta = Nothing
			Me.InitializeComponent()
		End Sub

		Private Overridable Property lblGuideCostAnalysis As Label
			Get
				Return Me._lblGuideCostAnalysis
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideCostAnalysis = value
			End Set
		End Property

		Private Overridable Property Line1 As Line
			Get
				Return Me._Line1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line1 = value
			End Set
		End Property

		Private Overridable Property lblGuideTotalCost1 As Label
			Get
				Return Me._lblGuideTotalCost1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideTotalCost1 = value
			End Set
		End Property

		Private Overridable Property lblGuideTotalCost2 As Label
			Get
				Return Me._lblGuideTotalCost2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideTotalCost2 = value
			End Set
		End Property

		Private Overridable Property lblGuideTotalCost3 As Label
			Get
				Return Me._lblGuideTotalCost3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideTotalCost3 = value
			End Set
		End Property

		Private Overridable Property lblGuideTotalCost4 As Label
			Get
				Return Me._lblGuideTotalCost4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideTotalCost4 = value
			End Set
		End Property

		Private Overridable Property lblGuideTotalCost5 As Label
			Get
				Return Me._lblGuideTotalCost5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideTotalCost5 = value
			End Set
		End Property

		Private Overridable Property lblGuideTotalCost6 As Label
			Get
				Return Me._lblGuideTotalCost6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideTotalCost6 = value
			End Set
		End Property

		Private Overridable Property lblGuideTotalCost7 As Label
			Get
				Return Me._lblGuideTotalCost7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideTotalCost7 = value
			End Set
		End Property

		Private Overridable Property lblGuideTotalCost8 As Label
			Get
				Return Me._lblGuideTotalCost8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideTotalCost8 = value
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

		Private Overridable Property lblTotalCostGuide As Label
			Get
				Return Me._lblTotalCostGuide
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalCostGuide = value
			End Set
		End Property

		Private Overridable Property lblTotalGuideCostDollar As Label
			Get
				Return Me._lblTotalGuideCostDollar
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalGuideCostDollar = value
			End Set
		End Property

		Private Overridable Property lblGuideTotalCost As Label
			Get
				Return Me._lblGuideTotalCost
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideTotalCost = value
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

		Private Overridable Property lblTotalGuide As Label
			Get
				Return Me._lblTotalGuide
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalGuide = value
			End Set
		End Property

		Private Overridable Property Line8 As Line
			Get
				Return Me._Line8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line8 = value
			End Set
		End Property

		Private Overridable Property lblGuide1 As Label
			Get
				Return Me._lblGuide1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide1 = value
			End Set
		End Property

		Private Overridable Property lblGuide2 As Label
			Get
				Return Me._lblGuide2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide2 = value
			End Set
		End Property

		Private Overridable Property lblGuide3 As Label
			Get
				Return Me._lblGuide3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide3 = value
			End Set
		End Property

		Private Overridable Property lblGuide4 As Label
			Get
				Return Me._lblGuide4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide4 = value
			End Set
		End Property

		Private Overridable Property lblGuide5 As Label
			Get
				Return Me._lblGuide5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide5 = value
			End Set
		End Property

		Private Overridable Property lblGuide6 As Label
			Get
				Return Me._lblGuide6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide6 = value
			End Set
		End Property

		Private Overridable Property lblGuide7 As Label
			Get
				Return Me._lblGuide7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide7 = value
			End Set
		End Property

		Private Overridable Property lblGuide8 As Label
			Get
				Return Me._lblGuide8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide8 = value
			End Set
		End Property

		Private Overridable Property lblType As Label
			Get
				Return Me._lblType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblType = value
			End Set
		End Property

		Private Overridable Property lblGuide As Label
			Get
				Return Me._lblGuide
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide1 As Label
			Get
				Return Me._lblCostPerGuide1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide1 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide2 As Label
			Get
				Return Me._lblCostPerGuide2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide2 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide3 As Label
			Get
				Return Me._lblCostPerGuide3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide3 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide4 As Label
			Get
				Return Me._lblCostPerGuide4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide4 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide5 As Label
			Get
				Return Me._lblCostPerGuide5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide5 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide6 As Label
			Get
				Return Me._lblCostPerGuide6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide6 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide7 As Label
			Get
				Return Me._lblCostPerGuide7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide7 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide8 As Label
			Get
				Return Me._lblCostPerGuide8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide8 = value
			End Set
		End Property

		Private Overridable Property lblGuideDollar As Label
			Get
				Return Me._lblGuideDollar
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideDollar = value
			End Set
		End Property

		Private Overridable Property lblGuideCost As Label
			Get
				Return Me._lblGuideCost
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuideCost = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod1 As Label
			Get
				Return Me._lblGuidePerRod1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod1 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod2 As Label
			Get
				Return Me._lblGuidePerRod2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod2 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod3 As Label
			Get
				Return Me._lblGuidePerRod3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod3 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod4 As Label
			Get
				Return Me._lblGuidePerRod4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod4 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod5 As Label
			Get
				Return Me._lblGuidePerRod5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod5 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod6 As Label
			Get
				Return Me._lblGuidePerRod6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod6 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod7 As Label
			Get
				Return Me._lblGuidePerRod7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod7 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod8 As Label
			Get
				Return Me._lblGuidePerRod8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod8 = value
			End Set
		End Property

		Private Overridable Property Label73 As Label
			Get
				Return Me._Label73
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label73 = value
			End Set
		End Property

		Private Overridable Property lblNumGuides As Label
			Get
				Return Me._lblNumGuides
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumGuides = value
			End Set
		End Property

		Private Overridable Property Line9 As Line
			Get
				Return Me._Line9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line9 = value
			End Set
		End Property

		Private Overridable Property Line10 As Line
			Get
				Return Me._Line10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line10 = value
			End Set
		End Property

		Private Overridable Property lblCost18 As Label
			Get
				Return Me._lblCost18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCost18 = value
			End Set
		End Property

		Private Overridable Property lblCost20 As Label
			Get
				Return Me._lblCost20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCost20 = value
			End Set
		End Property

		Private Overridable Property lblCost19 As Label
			Get
				Return Me._lblCost19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCost19 = value
			End Set
		End Property

		Private Overridable Property lblCost17 As Label
			Get
				Return Me._lblCost17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCost17 = value
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

		Private Overridable Property lblRodGrade11 As Label
			Get
				Return Me._lblRodGrade11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGrade11 = value
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

		Private Overridable Property lblRodLength11 As Label
			Get
				Return Me._lblRodLength11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodLength11 = value
			End Set
		End Property

		Private Overridable Property lblRodLength12 As Label
			Get
				Return Me._lblRodLength12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodLength12 = value
			End Set
		End Property

		Private Overridable Property lblRodLength13 As Label
			Get
				Return Me._lblRodLength13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodLength13 = value
			End Set
		End Property

		Private Overridable Property lblRodLength14 As Label
			Get
				Return Me._lblRodLength14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodLength14 = value
			End Set
		End Property

		Private Overridable Property lblRodLength15 As Label
			Get
				Return Me._lblRodLength15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodLength15 = value
			End Set
		End Property

		Private Overridable Property lblRodLength16 As Label
			Get
				Return Me._lblRodLength16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodLength16 = value
			End Set
		End Property

		Private Overridable Property lblRodLength17 As Label
			Get
				Return Me._lblRodLength17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodLength17 = value
			End Set
		End Property

		Private Overridable Property lblRodLength18 As Label
			Get
				Return Me._lblRodLength18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodLength18 = value
			End Set
		End Property

		Private Overridable Property lblTotalCost11 As Label
			Get
				Return Me._lblTotalCost11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalCost11 = value
			End Set
		End Property

		Private Overridable Property lblTotalCost12 As Label
			Get
				Return Me._lblTotalCost12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalCost12 = value
			End Set
		End Property

		Private Overridable Property lblTotalCost13 As Label
			Get
				Return Me._lblTotalCost13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalCost13 = value
			End Set
		End Property

		Private Overridable Property lblTotalCost14 As Label
			Get
				Return Me._lblTotalCost14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalCost14 = value
			End Set
		End Property

		Private Overridable Property lblTotalCost15 As Label
			Get
				Return Me._lblTotalCost15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalCost15 = value
			End Set
		End Property

		Private Overridable Property lblTotalCost16 As Label
			Get
				Return Me._lblTotalCost16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalCost16 = value
			End Set
		End Property

		Private Overridable Property lblTotalCost17 As Label
			Get
				Return Me._lblTotalCost17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalCost17 = value
			End Set
		End Property

		Private Overridable Property lblTotalCost18 As Label
			Get
				Return Me._lblTotalCost18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalCost18 = value
			End Set
		End Property

		Private Overridable Property lblCost11 As Label
			Get
				Return Me._lblCost11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCost11 = value
			End Set
		End Property

		Private Overridable Property lblCost12 As Label
			Get
				Return Me._lblCost12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCost12 = value
			End Set
		End Property

		Private Overridable Property lblCost13 As Label
			Get
				Return Me._lblCost13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCost13 = value
			End Set
		End Property

		Private Overridable Property lblCost14 As Label
			Get
				Return Me._lblCost14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCost14 = value
			End Set
		End Property

		Private Overridable Property lblCost15 As Label
			Get
				Return Me._lblCost15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCost15 = value
			End Set
		End Property

		Private Overridable Property lblCost16 As Label
			Get
				Return Me._lblCost16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCost16 = value
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

		Private Overridable Property lblRodLength19 As Label
			Get
				Return Me._lblRodLength19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodLength19 = value
			End Set
		End Property

		Private Overridable Property lblTotalCost19 As Label
			Get
				Return Me._lblTotalCost19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalCost19 = value
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

		Private Overridable Property lblRodLength20 As Label
			Get
				Return Me._lblRodLength20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodLength20 = value
			End Set
		End Property

		Private Overridable Property lblTotalCost20 As Label
			Get
				Return Me._lblTotalCost20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTotalCost20 = value
			End Set
		End Property

		Private Overridable Property Line17 As Line
			Get
				Return Me._Line17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line17 = value
			End Set
		End Property

		Private Sub SummHeader(iPage As Integer, nPages As Integer)
			Dim text As String = New String(" "c, 112)
			If Not RSWIN_DESC.bRodStarD Then
				Me.lblGuideCostAnalysis.Visible = False
				Me.Line1.Visible = False
				Me.lblGuideTotalCost1.Visible = False
				Me.lblGuideTotalCost2.Visible = False
				Me.lblGuideTotalCost3.Visible = False
				Me.lblGuideTotalCost4.Visible = False
				Me.lblGuideTotalCost5.Visible = False
				Me.lblGuideTotalCost6.Visible = False
				Me.lblGuideTotalCost7.Visible = False
				Me.lblGuideTotalCost8.Visible = False
				Me.Line6.Visible = False
				Me.lblTotalCostGuide.Visible = False
				Me.lblTotalGuideCostDollar.Visible = False
				Me.lblGuideTotalCost.Visible = False
				Me.Line7.Visible = False
				Me.lblTotalGuide.Visible = False
				Me.Line8.Visible = False
				Me.lblGuide1.Visible = False
				Me.lblGuide2.Visible = False
				Me.lblGuide3.Visible = False
				Me.lblGuide4.Visible = False
				Me.lblGuide5.Visible = False
				Me.lblGuide6.Visible = False
				Me.lblGuide7.Visible = False
				Me.lblGuide8.Visible = False
				Me.lblType.Visible = False
				Me.lblGuide.Visible = False
				Me.lblCostPerGuide1.Visible = False
				Me.lblCostPerGuide2.Visible = False
				Me.lblCostPerGuide3.Visible = False
				Me.lblCostPerGuide4.Visible = False
				Me.lblCostPerGuide5.Visible = False
				Me.lblCostPerGuide6.Visible = False
				Me.lblCostPerGuide7.Visible = False
				Me.lblCostPerGuide8.Visible = False
				Me.lblGuideDollar.Visible = False
				Me.lblGuideCost.Visible = False
				Me.lblGuidePerRod1.Visible = False
				Me.lblGuidePerRod2.Visible = False
				Me.lblGuidePerRod3.Visible = False
				Me.lblGuidePerRod4.Visible = False
				Me.lblGuidePerRod5.Visible = False
				Me.lblGuidePerRod6.Visible = False
				Me.lblGuidePerRod7.Visible = False
				Me.lblGuidePerRod8.Visible = False
				Me.Label73.Visible = False
				Me.lblNumGuides.Visible = False
				Me.Line9.Visible = False
				Me.Line10.Visible = False
				Me.Line17.Visible = False
			End If
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			If cRODSTAR.PU.UnitType = 8S Or (cRODSTAR.PU.UnitType = 11S And Not cRODSTAR.bUseCrankBalancedCalcs) Then
				RSWIN_DESC.bBeamBalanced = True
			Else
				RSWIN_DESC.bBeamBalanced = False
			End If
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
			Me.lblCompany.Text = Me.sCompany + Strings.Trim(cRODSTAR.ACompanyName)
			If iPage >= 1 Then
				Me.txtPage1.Text = iPage.ToString()
				Me.txtPage2.Text = nPages.ToString()
			End If
			Me.lblWellName.Text = Me.sWell + Strings.Trim(cRODSTAR.WellName)
			Dim text4 As String = Me.sThetaEnterprises
			Me.lblUserName.Text = Me.sUser + Strings.Trim(cRODSTAR.UserName)
			Me.lblDiskFile.Text = Me.sDiskFile + Util.FileName(cRODSTAR.Inputfile)
			Try
				Me.lblUserDate.Text = Me.sDate + Convert.ToDateTime(cRODSTAR.UserDate).ToShortDateString()
			Catch ex As Exception
				Me.lblUserDate.Text = Me.sDate + cRODSTAR.UserDate
			End Try
			If cRODSTAR.FileComment Is Nothing Then
				cRODSTAR.FileComment = ""
			End If
			Me.lblComment.Text = Me.sComment + cRODSTAR.FileComment
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
			Me.lblTitle1.Text = Me.lblTitle1.Text.Replace("1.0", RSWIN_DESC.VersionMajor.ToString() + "." + RSWIN_DESC.VersionMinor.ToString())
			cRODSTAR = Nothing
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
				Me.PageSettings.Orientation = PageOrientation.Portrait
			End Set
		End Property

		Public Sub rptCostAnalysis_ReportStart(sender As Object, e As EventArgs)
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
			Try
				If RSWIN_DESC.bIntVersion Then
					If RSWIN_DESC.bWriteResXFile Then
						Me.OpenResourceWriter("rptCostAnalysis")
						Me.WriteControlStrings()
						Me.CloseResourceWriter()
					End If
					If RSWIN_DESC.bReadResXFile Then
						Me.ReadReportControlStrings()
					End If
				End If
			Catch ex As Exception
			End Try
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				Me.lblRodLengthHdrBot.Text = "(" + RSWIN_DESC.ft + ")"
				Me.lblCostHdrBot.Text = "($/" + RSWIN_DESC.ft + ")"
				Me.lblRodDiamHdrBot.Text = "(" + RSWIN_DESC.inches + ")"
			ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				Me.lblRodLengthHdrBot.Text = "(" + RSWIN_DESC.m + ")"
				Me.lblCostHdrBot.Text = "($/" + RSWIN_DESC.m + ")"
				Me.lblRodDiamHdrBot.Text = "(" + RSWIN_DESC.mm + ")"
			Else
				Me.lblRodLengthHdrBot.Text = "(" + RSWIN_DESC.m + ")"
				Me.lblCostHdrBot.Text = "($/" + RSWIN_DESC.m + ")"
				Me.lblRodDiamHdrBot.Text = "(" + RSWIN_DESC.inches + ")"
			End If
			Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
			Me.ShowRodStringCost()
		End Sub

		Public Sub ShowRodStringCost()
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num As Short = -1S
				Dim num2 As Short = 1S
				Dim numRods As Short = rst.NumRods
				For num3 As Short = num2 To numRods
					If Not RODUTIL.IsCorod(rst.Sections(CInt(num3)).Grade) Then
						num = 0S
						Exit For
					End If
				Next
				Dim num4 As Single = 0F
				Dim num5 As Short = 1S
				Dim numRods2 As Short = rst.NumRods
				Dim sDBKey As String
				For num3 As Short = num5 To numRods2
					Me.MakeRGKey(CInt(rst.Sections(CInt(num3)).Grade), Strings.Trim(rst.Sections(CInt(num3)).RodType), rst.Sections(CInt(num3)).Diameter, sDBKey)
					Dim num6 As Single
					COSTDB.DBLookup(sDBKey, num6)
					Dim text As String
					Dim text2 As String
					If num6 = 0F Then
						num4 = -1F
						text = "  " + Me.sNA
						text2 = "     " + Me.sNA
					Else
						Dim num7 As Single
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							num7 = num6 * rst.Sections(CInt(num3)).length
						Else
							num7 = num6 * (rst.Sections(CInt(num3)).length * RSWIN_DESC.FT__M)
						End If
						text = Util.RFormat(num6, "#0.00")
						text2 = Util.RFormat(num7, "####0.00")
						If num4 >= 0F Then
							num4 = CSng((CDbl(num4) + Convert.ToDouble(text2)))
						End If
					End If
					text = Strings.Left(text + Strings.Space(5), 5)
					text2 = Strings.Left(text2 + Strings.Space(8), 8)
					Dim text3 As String
					If rst.Sections(CInt(num3)).Grade = 4096S Then
						text3 = Strings.Left(Strings.Trim(rst.Sections(CInt(num3)).RodType), 19)
					Else
						text3 = RODUTIL.RodGrade(rst.Sections(CInt(num3)).Grade)
						If RODUTIL.IsCorodH(rst.Sections(CInt(num3)).Grade) Then
							If CDbl(rst.Sections(CInt(num3)).Area) < 0.7 Then
								text3 += " 682"
							Else
								text3 += " 757"
							End If
						End If
					End If
					text3 = Strings.Left(text3, 19)
					text3 = Strings.Space(19 - Strings.Len(text3) / 2) + text3
					Dim l As String
					If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
						l = Util.RFormat(rst.Sections(CInt(num3)).length, "####0")
					Else
						l = Util.RFormat(rst.Sections(CInt(num3)).length * RSWIN_DESC.FT__M, "####0")
					End If
					Dim text4 As String
					If RODUTIL.IsCorodH(rst.Sections(CInt(num3)).Grade) Then
						text4 = Me.sNA
					ElseIf RODUTIL.IsCorod(rst.Sections(CInt(num3)).Grade) Then
						Dim num8 As Single = rst.Sections(CInt(num3)).Diameter * 16F
						Dim text5 As String = "0"
						text4 = Util.Format(num8, text5) + "/16"
						If(Not num And If((-If(((RSWIN_DESC.SETUP_MeasurementSystem = 3) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							text4 += """"
						End If
						Dim str As String = text4
						Dim str2 As String = " (#"
						Dim obj As Object = Conversion.Int(rst.Sections(CInt(num3)).Diameter * 16F) - 10F
						text4 = str + str2 + Util.Format(obj) + ")"
					ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						text4 = Util.RFormat(rst.Sections(CInt(num3)).Diameter * RSWIN_DESC.IN__MM, "##0.0")
					Else
						text4 = Util.RFormat(rst.Sections(CInt(num3)).Diameter, "0.0##")
					End If
					Me.SetRSLabels(num3, text4, text3, l, text, text2)
				Next
				If rst.RSExtraCost > 0F Then
					If num4 >= 0F Then
						num4 += rst.RSExtraCost
					End If
					If Strings.Len(rst.RSExtraCostLabel) = 0 Then
						Me.lblAddCosts.Text = "Additional rod costs"
					Else
						Me.lblAddCosts.Text = Util.RFormat(rst.RSExtraCostLabel, "$#####0.00")
					End If
					Me.lblAddCosts.Text = Me.lblAddCosts.Text + ":"
					Me.lblAddCosts2.Text = Util.RFormat(rst.RSExtraCost, "$#####0.00")
					If rst.RSExtraCost > 0F Then
						Me.lblAddCosts.Visible = True
						Me.lblAddCosts2.Visible = True
					Else
						Me.lblAddCosts.Visible = False
						Me.lblAddCosts2.Visible = False
					End If
				Else
					Me.lblAddCosts.Visible = False
					Me.lblAddCosts2.Visible = False
				End If
				If num4 < 0F Then
					Me.lblTotalRSCost2.Text = Me.sNA
				Else
					Me.lblTotalRSCost2.Text = Util.RFormat(num4, "$#####0.00")
				End If
				Dim str3 As String = RSWIN_DESC.rst.UnitID.Trim()
				sDBKey = "PU/" + str3
				COSTDB.DBLookup(sDBKey, num4)
				If num4 <= 0F Then
					Me.lblTotalPUCost2.Text = Me.sNA
				Else
					Me.lblTotalPUCost2.Text = Util.RFormat(num4, "$#####0.00")
				End If
				Me.lblManufacturer.Text = RESULTS1.VTrim(rst.PU.Manuf)
				Me.lblAPISize.Text = RESULTS1.VTrim(rst.PU.APIDesignation)
				If Strings.Len(RESULTS1.VTrim(rst.PU.UnitName)) > 0 Then
					Me.lblUnitName.Text = RESULTS1.VTrim(rst.PU.UnitName)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Function SetRSLabels(I As Object, d As Object, Rgrade As Object, L As Object, C As Object, T As Object) As Object
			If Operators.ConditionalCompareObjectEqual(I, 1, False) Then
				Me.lblRodDiam1.Text = d.ToString()
				Me.lblRodGrade1.Text = Rgrade.ToString()
				Me.lblRodLength1.Text = L.ToString()
				Me.lblCost1.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost1.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam1.Visible = True
				Me.lblRodGrade1.Visible = True
				Me.lblRodLength1.Visible = True
				Me.lblCost1.Visible = True
				Me.lblTotalCost1.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 2, False) Then
				Me.lblRodDiam2.Text = d.ToString()
				Me.lblRodGrade2.Text = Rgrade.ToString()
				Me.lblRodLength2.Text = L.ToString()
				Me.lblCost2.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost2.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam2.Visible = True
				Me.lblRodGrade2.Visible = True
				Me.lblRodLength2.Visible = True
				Me.lblCost2.Visible = True
				Me.lblTotalCost2.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 3, False) Then
				Me.lblRodDiam3.Text = d.ToString()
				Me.lblRodGrade3.Text = Rgrade.ToString()
				Me.lblRodLength3.Text = L.ToString()
				Me.lblCost3.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost3.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam3.Visible = True
				Me.lblRodGrade3.Visible = True
				Me.lblRodLength3.Visible = True
				Me.lblCost3.Visible = True
				Me.lblTotalCost3.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 4, False) Then
				Me.lblRodDiam4.Text = d.ToString()
				Me.lblRodGrade4.Text = Rgrade.ToString()
				Me.lblRodLength4.Text = L.ToString()
				Me.lblCost4.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost4.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam4.Visible = True
				Me.lblRodGrade4.Visible = True
				Me.lblRodLength4.Visible = True
				Me.lblCost4.Visible = True
				Me.lblTotalCost4.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 5, False) Then
				Me.lblRodDiam5.Text = d.ToString()
				Me.lblRodGrade5.Text = Rgrade.ToString()
				Me.lblRodLength5.Text = L.ToString()
				Me.lblCost5.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost5.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam5.Visible = True
				Me.lblRodGrade5.Visible = True
				Me.lblRodLength5.Visible = True
				Me.lblCost5.Visible = True
				Me.lblTotalCost5.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 6, False) Then
				Me.lblRodDiam6.Text = d.ToString()
				Me.lblRodGrade6.Text = Rgrade.ToString()
				Me.lblRodLength6.Text = L.ToString()
				Me.lblCost6.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost6.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam6.Visible = True
				Me.lblRodGrade6.Visible = True
				Me.lblRodLength6.Visible = True
				Me.lblCost6.Visible = True
				Me.lblTotalCost6.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 7, False) Then
				Me.lblRodDiam7.Text = d.ToString()
				Me.lblRodGrade7.Text = Rgrade.ToString()
				Me.lblRodLength7.Text = L.ToString()
				Me.lblCost7.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost7.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam7.Visible = True
				Me.lblRodGrade7.Visible = True
				Me.lblRodLength7.Visible = True
				Me.lblCost7.Visible = True
				Me.lblTotalCost7.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 8, False) Then
				Me.lblRodDiam8.Text = d.ToString()
				Me.lblRodGrade8.Text = Rgrade.ToString()
				Me.lblRodLength8.Text = L.ToString()
				Me.lblCost8.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost8.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam8.Visible = True
				Me.lblRodGrade8.Visible = True
				Me.lblRodLength8.Visible = True
				Me.lblCost8.Visible = True
				Me.lblTotalCost8.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 9, False) Then
				Me.lblRodDiam9.Text = d.ToString()
				Me.lblRodGrade9.Text = Rgrade.ToString()
				Me.lblRodLength9.Text = L.ToString()
				Me.lblCost9.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost9.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam9.Visible = True
				Me.lblRodGrade9.Visible = True
				Me.lblRodLength9.Visible = True
				Me.lblCost9.Visible = True
				Me.lblTotalCost9.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 10, False) Then
				Me.lblRodDiam10.Text = d.ToString()
				Me.lblRodGrade10.Text = Rgrade.ToString()
				Me.lblRodLength10.Text = L.ToString()
				Me.lblCost10.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost10.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam10.Visible = True
				Me.lblRodGrade10.Visible = True
				Me.lblRodLength10.Visible = True
				Me.lblCost10.Visible = True
				Me.lblTotalCost10.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 11, False) Then
				Me.lblRodDiam11.Text = d.ToString()
				Me.lblRodGrade11.Text = Rgrade.ToString()
				Me.lblRodLength11.Text = L.ToString()
				Me.lblCost11.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost11.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam11.Visible = True
				Me.lblRodGrade11.Visible = True
				Me.lblRodLength11.Visible = True
				Me.lblCost11.Visible = True
				Me.lblTotalCost11.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 12, False) Then
				Me.lblRodDiam12.Text = d.ToString()
				Me.lblRodGrade12.Text = Rgrade.ToString()
				Me.lblRodLength12.Text = L.ToString()
				Me.lblCost12.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost12.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam12.Visible = True
				Me.lblRodGrade12.Visible = True
				Me.lblRodLength12.Visible = True
				Me.lblCost12.Visible = True
				Me.lblTotalCost12.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 13, False) Then
				Me.lblRodDiam13.Text = d.ToString()
				Me.lblRodGrade13.Text = Rgrade.ToString()
				Me.lblRodLength13.Text = L.ToString()
				Me.lblCost13.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost13.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam13.Visible = True
				Me.lblRodGrade13.Visible = True
				Me.lblRodLength13.Visible = True
				Me.lblCost13.Visible = True
				Me.lblTotalCost13.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 14, False) Then
				Me.lblRodDiam14.Text = d.ToString()
				Me.lblRodGrade14.Text = Rgrade.ToString()
				Me.lblRodLength14.Text = L.ToString()
				Me.lblCost14.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost14.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam14.Visible = True
				Me.lblRodGrade14.Visible = True
				Me.lblRodLength14.Visible = True
				Me.lblCost14.Visible = True
				Me.lblTotalCost14.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 15, False) Then
				Me.lblRodDiam15.Text = d.ToString()
				Me.lblRodGrade15.Text = Rgrade.ToString()
				Me.lblRodLength15.Text = L.ToString()
				Me.lblCost15.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost15.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam15.Visible = True
				Me.lblRodGrade15.Visible = True
				Me.lblRodLength15.Visible = True
				Me.lblCost15.Visible = True
				Me.lblTotalCost15.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 16, False) Then
				Me.lblRodDiam16.Text = d.ToString()
				Me.lblRodGrade16.Text = Rgrade.ToString()
				Me.lblRodLength16.Text = L.ToString()
				Me.lblCost16.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost16.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam16.Visible = True
				Me.lblRodGrade16.Visible = True
				Me.lblRodLength16.Visible = True
				Me.lblCost16.Visible = True
				Me.lblTotalCost16.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 17, False) Then
				Me.lblRodDiam17.Text = d.ToString()
				Me.lblRodGrade17.Text = Rgrade.ToString()
				Me.lblRodLength17.Text = L.ToString()
				Me.lblCost17.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost17.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam17.Visible = True
				Me.lblRodGrade17.Visible = True
				Me.lblRodLength17.Visible = True
				Me.lblCost17.Visible = True
				Me.lblTotalCost17.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 18, False) Then
				Me.lblRodDiam18.Text = d.ToString()
				Me.lblRodGrade18.Text = Rgrade.ToString()
				Me.lblRodLength18.Text = L.ToString()
				Me.lblCost18.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost18.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam18.Visible = True
				Me.lblRodGrade18.Visible = True
				Me.lblRodLength18.Visible = True
				Me.lblCost18.Visible = True
				Me.lblTotalCost18.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 19, False) Then
				Me.lblRodDiam19.Text = d.ToString()
				Me.lblRodGrade19.Text = Rgrade.ToString()
				Me.lblRodLength19.Text = L.ToString()
				Me.lblCost19.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost19.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam19.Visible = True
				Me.lblRodGrade19.Visible = True
				Me.lblRodLength19.Visible = True
				Me.lblCost19.Visible = True
				Me.lblTotalCost19.Visible = True
			ElseIf Operators.ConditionalCompareObjectEqual(I, 20, False) Then
				Me.lblRodDiam20.Text = d.ToString()
				Me.lblRodGrade20.Text = Rgrade.ToString()
				Me.lblRodLength20.Text = L.ToString()
				Me.lblCost20.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(C), "$#####0.00")
				Me.lblTotalCost20.Text = Util.RFormat(RuntimeHelpers.GetObjectValue(T), "$#####0.00")
				Me.lblRodDiam20.Visible = True
				Me.lblRodGrade20.Visible = True
				Me.lblRodLength20.Visible = True
				Me.lblCost20.Visible = True
				Me.lblTotalCost20.Visible = True
			End If
			Dim result As Object
			Return result
		End Function

		Public Sub MakeRGKey(iGrade As Integer, sRodType As String, diam As Single, ByRef sKey As String)
			If iGrade = 4096 Then
				sKey = "RG/" + sRodType
			Else
				Dim str As String = "RG/"
				Dim obj As Object = iGrade
				Dim str2 As String = Util.Format(obj)
				iGrade = Conversions.ToInteger(obj)
				sKey = str + str2
			End If
			Dim flag As Boolean = True
			If flag = RODUTIL.IsRibbonRod(CShort(iGrade)) Then
				sKey += "/212"
				Return
			End If
			If flag = (RODUTIL.IsCorodH(iGrade) <> 0) Then
				Dim num As Double = 3.141592653589793 * Math.Pow(CDbl(diam), 2.0) / 4.0
				If num < 0.7 Then
					sKey += "/682"
					Return
				End If
				sKey += "/757"
				Return
			Else
				If flag = (RODUTIL.IsCorodSE(iGrade) <> 0) Then
					sKey = sKey + "/" + Strings.Trim(Conversion.Str(Conversion.Int(diam * 16F) - 10F))
					Return
				End If
				sKey = sKey + "/" + Strings.Trim(Conversion.Str(diam))
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

		Private Overridable Property Detail As Detail
			Get
				Return Me._Detail
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Detail)
				Me._Detail = value
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
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptCostAnalysis))
			Me.Detail = New Detail()
			Me.PageHeader = New PageHeader()
			Me.lblTitle1 = New Label()
			Me.lblCost8 = New Label()
			Me.lblCost10 = New Label()
			Me.lblCost9 = New Label()
			Me.lblCost7 = New Label()
			Me.lblRodStringDesign = New Label()
			Me.Line11 = New Line()
			Me.lblRodDiamHdrTop = New Label()
			Me.lblRodDiamHdrBot = New Label()
			Me.lblRodDiam1 = New Label()
			Me.lblRodGradeHdrTop = New Label()
			Me.lblRodGradeHdrBot = New Label()
			Me.lblRodLengthHdrTop = New Label()
			Me.lblRodLengthHdrBot = New Label()
			Me.Line12 = New Line()
			Me.lblRodDiam2 = New Label()
			Me.lblRodDiam3 = New Label()
			Me.lblRodDiam4 = New Label()
			Me.lblRodDiam5 = New Label()
			Me.lblRodDiam6 = New Label()
			Me.lblRodDiam7 = New Label()
			Me.lblRodDiam8 = New Label()
			Me.lblRodGrade1 = New Label()
			Me.lblRodGrade2 = New Label()
			Me.lblRodGrade3 = New Label()
			Me.lblRodGrade4 = New Label()
			Me.lblRodGrade5 = New Label()
			Me.lblRodGrade6 = New Label()
			Me.lblRodGrade7 = New Label()
			Me.lblRodGrade8 = New Label()
			Me.lblRodLength1 = New Label()
			Me.lblRodLength2 = New Label()
			Me.lblRodLength3 = New Label()
			Me.lblRodLength4 = New Label()
			Me.lblRodLength5 = New Label()
			Me.lblRodLength6 = New Label()
			Me.lblRodLength7 = New Label()
			Me.lblRodLength8 = New Label()
			Me.linRSInputSep1 = New Line()
			Me.linRSInputSep2 = New Line()
			Me.linRSInputSep3 = New Line()
			Me.lblTotalCost1 = New Label()
			Me.lblTotalCost2 = New Label()
			Me.lblTotalCost3 = New Label()
			Me.lblTotalCost4 = New Label()
			Me.lblTotalCost5 = New Label()
			Me.lblTotalCost6 = New Label()
			Me.lblTotalCost7 = New Label()
			Me.lblTotalCost8 = New Label()
			Me.Line13 = New Line()
			Me.Label9 = New Label()
			Me.Label10 = New Label()
			Me.lblTotalRSCost2 = New Label()
			Me.lblPumpingUnitDesign = New Label()
			Me.lblTotalPUCost2 = New Label()
			Me.lblTotalPUCost = New Label()
			Me.lblManufacturer = New Label()
			Me.lblAPISize = New Label()
			Me.lblUnitName = New Label()
			Me.lblCost1 = New Label()
			Me.lblCost2 = New Label()
			Me.lblCost3 = New Label()
			Me.lblCost4 = New Label()
			Me.lblCost5 = New Label()
			Me.lblCost6 = New Label()
			Me.Line15 = New Line()
			Me.Label23 = New Label()
			Me.lblCostHdrBot = New Label()
			Me.lblTotalRSCost = New Label()
			Me.lblAddCosts = New Label()
			Me.lblAddCosts2 = New Label()
			Me.Line16 = New Line()
			Me.lblComment = New Label()
			Me.lblPage = New Label()
			Me.txtPage1 = New TextBox()
			Me.lblOf = New Label()
			Me.txtPage2 = New TextBox()
			Me.lblUserName = New Label()
			Me.lblUserDate = New Label()
			Me.lblRodDiam9 = New Label()
			Me.lblRodGrade9 = New Label()
			Me.lblRodLength9 = New Label()
			Me.lblTotalCost9 = New Label()
			Me.lblRodDiam10 = New Label()
			Me.lblRodGrade10 = New Label()
			Me.lblRodLength10 = New Label()
			Me.lblTotalCost10 = New Label()
			Me.Line14 = New Line()
			Me.lblLabel2 = New Label()
			Me.lblCompany = New Label()
			Me.lblWellName = New Label()
			Me.lblDiskFile = New Label()
			Me.lblSecondCompanyName = New Label()
			Me.lblSecondCompanyPhonenumber = New Label()
			Me.lblGoTheta = New Label()
			Me.lblGuideCostAnalysis = New Label()
			Me.Line1 = New Line()
			Me.lblGuideTotalCost1 = New Label()
			Me.lblGuideTotalCost2 = New Label()
			Me.lblGuideTotalCost3 = New Label()
			Me.lblGuideTotalCost4 = New Label()
			Me.lblGuideTotalCost5 = New Label()
			Me.lblGuideTotalCost6 = New Label()
			Me.lblGuideTotalCost7 = New Label()
			Me.lblGuideTotalCost8 = New Label()
			Me.Line6 = New Line()
			Me.lblTotalCostGuide = New Label()
			Me.lblTotalGuideCostDollar = New Label()
			Me.lblGuideTotalCost = New Label()
			Me.Line7 = New Line()
			Me.lblTotalGuide = New Label()
			Me.Line8 = New Line()
			Me.lblGuide1 = New Label()
			Me.lblGuide2 = New Label()
			Me.lblGuide3 = New Label()
			Me.lblGuide4 = New Label()
			Me.lblGuide5 = New Label()
			Me.lblGuide6 = New Label()
			Me.lblGuide7 = New Label()
			Me.lblGuide8 = New Label()
			Me.lblType = New Label()
			Me.lblGuide = New Label()
			Me.lblCostPerGuide1 = New Label()
			Me.lblCostPerGuide2 = New Label()
			Me.lblCostPerGuide3 = New Label()
			Me.lblCostPerGuide4 = New Label()
			Me.lblCostPerGuide5 = New Label()
			Me.lblCostPerGuide6 = New Label()
			Me.lblCostPerGuide7 = New Label()
			Me.lblCostPerGuide8 = New Label()
			Me.lblGuideDollar = New Label()
			Me.lblGuideCost = New Label()
			Me.lblGuidePerRod1 = New Label()
			Me.lblGuidePerRod2 = New Label()
			Me.lblGuidePerRod3 = New Label()
			Me.lblGuidePerRod4 = New Label()
			Me.lblGuidePerRod5 = New Label()
			Me.lblGuidePerRod6 = New Label()
			Me.lblGuidePerRod7 = New Label()
			Me.lblGuidePerRod8 = New Label()
			Me.Label73 = New Label()
			Me.lblNumGuides = New Label()
			Me.Line9 = New Line()
			Me.Line10 = New Line()
			Me.Line17 = New Line()
			Me.lblCost18 = New Label()
			Me.lblCost20 = New Label()
			Me.lblCost19 = New Label()
			Me.lblCost17 = New Label()
			Me.lblRodDiam11 = New Label()
			Me.lblRodDiam12 = New Label()
			Me.lblRodDiam13 = New Label()
			Me.lblRodDiam14 = New Label()
			Me.lblRodDiam15 = New Label()
			Me.lblRodDiam16 = New Label()
			Me.lblRodDiam17 = New Label()
			Me.lblRodDiam18 = New Label()
			Me.lblRodGrade11 = New Label()
			Me.lblRodGrade12 = New Label()
			Me.lblRodGrade13 = New Label()
			Me.lblRodGrade14 = New Label()
			Me.lblRodGrade15 = New Label()
			Me.lblRodGrade16 = New Label()
			Me.lblRodGrade17 = New Label()
			Me.lblRodGrade18 = New Label()
			Me.lblRodLength11 = New Label()
			Me.lblRodLength12 = New Label()
			Me.lblRodLength13 = New Label()
			Me.lblRodLength14 = New Label()
			Me.lblRodLength15 = New Label()
			Me.lblRodLength16 = New Label()
			Me.lblRodLength17 = New Label()
			Me.lblRodLength18 = New Label()
			Me.lblTotalCost11 = New Label()
			Me.lblTotalCost12 = New Label()
			Me.lblTotalCost13 = New Label()
			Me.lblTotalCost14 = New Label()
			Me.lblTotalCost15 = New Label()
			Me.lblTotalCost16 = New Label()
			Me.lblTotalCost17 = New Label()
			Me.lblTotalCost18 = New Label()
			Me.lblCost11 = New Label()
			Me.lblCost12 = New Label()
			Me.lblCost13 = New Label()
			Me.lblCost14 = New Label()
			Me.lblCost15 = New Label()
			Me.lblCost16 = New Label()
			Me.lblRodDiam19 = New Label()
			Me.lblRodGrade19 = New Label()
			Me.lblRodLength19 = New Label()
			Me.lblTotalCost19 = New Label()
			Me.lblRodDiam20 = New Label()
			Me.lblRodGrade20 = New Label()
			Me.lblRodLength20 = New Label()
			Me.lblTotalCost20 = New Label()
			Me.PageFooter = New PageFooter()
			CType(Me.lblTitle1, ISupportInitialize).BeginInit()
			CType(Me.lblCost8, ISupportInitialize).BeginInit()
			CType(Me.lblCost10, ISupportInitialize).BeginInit()
			CType(Me.lblCost9, ISupportInitialize).BeginInit()
			CType(Me.lblCost7, ISupportInitialize).BeginInit()
			CType(Me.lblRodStringDesign, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiamHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiamHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam1, ISupportInitialize).BeginInit()
			CType(Me.lblRodGradeHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodGradeHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodLengthHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodLengthHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam2, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam3, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam4, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam5, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam6, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam7, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam8, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade1, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade2, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade3, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade4, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade5, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade6, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade7, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade8, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength1, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength2, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength3, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength4, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength5, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength6, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength7, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength8, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost1, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost2, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost3, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost4, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost5, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost6, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost7, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost8, ISupportInitialize).BeginInit()
			CType(Me.Label9, ISupportInitialize).BeginInit()
			CType(Me.Label10, ISupportInitialize).BeginInit()
			CType(Me.lblTotalRSCost2, ISupportInitialize).BeginInit()
			CType(Me.lblPumpingUnitDesign, ISupportInitialize).BeginInit()
			CType(Me.lblTotalPUCost2, ISupportInitialize).BeginInit()
			CType(Me.lblTotalPUCost, ISupportInitialize).BeginInit()
			CType(Me.lblManufacturer, ISupportInitialize).BeginInit()
			CType(Me.lblAPISize, ISupportInitialize).BeginInit()
			CType(Me.lblUnitName, ISupportInitialize).BeginInit()
			CType(Me.lblCost1, ISupportInitialize).BeginInit()
			CType(Me.lblCost2, ISupportInitialize).BeginInit()
			CType(Me.lblCost3, ISupportInitialize).BeginInit()
			CType(Me.lblCost4, ISupportInitialize).BeginInit()
			CType(Me.lblCost5, ISupportInitialize).BeginInit()
			CType(Me.lblCost6, ISupportInitialize).BeginInit()
			CType(Me.Label23, ISupportInitialize).BeginInit()
			CType(Me.lblCostHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblTotalRSCost, ISupportInitialize).BeginInit()
			CType(Me.lblAddCosts, ISupportInitialize).BeginInit()
			CType(Me.lblAddCosts2, ISupportInitialize).BeginInit()
			CType(Me.lblComment, ISupportInitialize).BeginInit()
			CType(Me.lblPage, ISupportInitialize).BeginInit()
			CType(Me.txtPage1, ISupportInitialize).BeginInit()
			CType(Me.lblOf, ISupportInitialize).BeginInit()
			CType(Me.txtPage2, ISupportInitialize).BeginInit()
			CType(Me.lblUserName, ISupportInitialize).BeginInit()
			CType(Me.lblUserDate, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam9, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade9, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength9, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost9, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam10, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade10, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength10, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost10, ISupportInitialize).BeginInit()
			CType(Me.lblLabel2, ISupportInitialize).BeginInit()
			CType(Me.lblCompany, ISupportInitialize).BeginInit()
			CType(Me.lblWellName, ISupportInitialize).BeginInit()
			CType(Me.lblDiskFile, ISupportInitialize).BeginInit()
			CType(Me.lblSecondCompanyName, ISupportInitialize).BeginInit()
			CType(Me.lblSecondCompanyPhonenumber, ISupportInitialize).BeginInit()
			CType(Me.lblGoTheta, ISupportInitialize).BeginInit()
			CType(Me.lblGuideCostAnalysis, ISupportInitialize).BeginInit()
			CType(Me.lblGuideTotalCost1, ISupportInitialize).BeginInit()
			CType(Me.lblGuideTotalCost2, ISupportInitialize).BeginInit()
			CType(Me.lblGuideTotalCost3, ISupportInitialize).BeginInit()
			CType(Me.lblGuideTotalCost4, ISupportInitialize).BeginInit()
			CType(Me.lblGuideTotalCost5, ISupportInitialize).BeginInit()
			CType(Me.lblGuideTotalCost6, ISupportInitialize).BeginInit()
			CType(Me.lblGuideTotalCost7, ISupportInitialize).BeginInit()
			CType(Me.lblGuideTotalCost8, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCostGuide, ISupportInitialize).BeginInit()
			CType(Me.lblTotalGuideCostDollar, ISupportInitialize).BeginInit()
			CType(Me.lblGuideTotalCost, ISupportInitialize).BeginInit()
			CType(Me.lblTotalGuide, ISupportInitialize).BeginInit()
			CType(Me.lblGuide1, ISupportInitialize).BeginInit()
			CType(Me.lblGuide2, ISupportInitialize).BeginInit()
			CType(Me.lblGuide3, ISupportInitialize).BeginInit()
			CType(Me.lblGuide4, ISupportInitialize).BeginInit()
			CType(Me.lblGuide5, ISupportInitialize).BeginInit()
			CType(Me.lblGuide6, ISupportInitialize).BeginInit()
			CType(Me.lblGuide7, ISupportInitialize).BeginInit()
			CType(Me.lblGuide8, ISupportInitialize).BeginInit()
			CType(Me.lblType, ISupportInitialize).BeginInit()
			CType(Me.lblGuide, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide1, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide2, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide3, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide4, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide5, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide6, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide7, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide8, ISupportInitialize).BeginInit()
			CType(Me.lblGuideDollar, ISupportInitialize).BeginInit()
			CType(Me.lblGuideCost, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod1, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod2, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod3, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod4, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod5, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod6, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod7, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod8, ISupportInitialize).BeginInit()
			CType(Me.Label73, ISupportInitialize).BeginInit()
			CType(Me.lblNumGuides, ISupportInitialize).BeginInit()
			CType(Me.lblCost18, ISupportInitialize).BeginInit()
			CType(Me.lblCost20, ISupportInitialize).BeginInit()
			CType(Me.lblCost19, ISupportInitialize).BeginInit()
			CType(Me.lblCost17, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam11, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam12, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam13, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam14, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam15, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam16, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam17, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam18, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade11, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade12, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade13, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade14, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade15, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade16, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade17, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade18, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength11, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength12, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength13, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength14, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength15, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength16, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength17, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength18, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost11, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost12, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost13, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost14, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost15, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost16, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost17, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost18, ISupportInitialize).BeginInit()
			CType(Me.lblCost11, ISupportInitialize).BeginInit()
			CType(Me.lblCost12, ISupportInitialize).BeginInit()
			CType(Me.lblCost13, ISupportInitialize).BeginInit()
			CType(Me.lblCost14, ISupportInitialize).BeginInit()
			CType(Me.lblCost15, ISupportInitialize).BeginInit()
			CType(Me.lblCost16, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam19, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade19, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength19, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost19, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam20, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade20, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength20, ISupportInitialize).BeginInit()
			CType(Me.lblTotalCost20, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Height = 0.03055558F
			Me.Detail.Name = "Detail"
			Me.PageHeader.Controls.AddRange(New ARControl() { Me.lblTitle1, Me.lblCost8, Me.lblCost10, Me.lblCost9, Me.lblCost7, Me.lblRodStringDesign, Me.Line11, Me.lblRodDiamHdrTop, Me.lblRodDiamHdrBot, Me.lblRodDiam1, Me.lblRodGradeHdrTop, Me.lblRodGradeHdrBot, Me.lblRodLengthHdrTop, Me.lblRodLengthHdrBot, Me.Line12, Me.lblRodDiam2, Me.lblRodDiam3, Me.lblRodDiam4, Me.lblRodDiam5, Me.lblRodDiam6, Me.lblRodDiam7, Me.lblRodDiam8, Me.lblRodGrade1, Me.lblRodGrade2, Me.lblRodGrade3, Me.lblRodGrade4, Me.lblRodGrade5, Me.lblRodGrade6, Me.lblRodGrade7, Me.lblRodGrade8, Me.lblRodLength1, Me.lblRodLength2, Me.lblRodLength3, Me.lblRodLength4, Me.lblRodLength5, Me.lblRodLength6, Me.lblRodLength7, Me.lblRodLength8, Me.linRSInputSep1, Me.linRSInputSep2, Me.linRSInputSep3, Me.lblTotalCost1, Me.lblTotalCost2, Me.lblTotalCost3, Me.lblTotalCost4, Me.lblTotalCost5, Me.lblTotalCost6, Me.lblTotalCost7, Me.lblTotalCost8, Me.Line13, Me.Label9, Me.Label10, Me.lblTotalRSCost2, Me.lblPumpingUnitDesign, Me.lblTotalPUCost2, Me.lblTotalPUCost, Me.lblManufacturer, Me.lblAPISize, Me.lblUnitName, Me.lblCost1, Me.lblCost2, Me.lblCost3, Me.lblCost4, Me.lblCost5, Me.lblCost6, Me.Line15, Me.Label23, Me.lblCostHdrBot, Me.lblTotalRSCost, Me.lblAddCosts, Me.lblAddCosts2, Me.Line16, Me.lblComment, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserName, Me.lblUserDate, Me.lblRodDiam9, Me.lblRodGrade9, Me.lblRodLength9, Me.lblTotalCost9, Me.lblRodDiam10, Me.lblRodGrade10, Me.lblRodLength10, Me.lblTotalCost10, Me.Line14, Me.lblLabel2, Me.lblCompany, Me.lblWellName, Me.lblDiskFile, Me.lblSecondCompanyName, Me.lblSecondCompanyPhonenumber, Me.lblGoTheta, Me.lblGuideCostAnalysis, Me.Line1, Me.lblGuideTotalCost1, Me.lblGuideTotalCost2, Me.lblGuideTotalCost3, Me.lblGuideTotalCost4, Me.lblGuideTotalCost5, Me.lblGuideTotalCost6, Me.lblGuideTotalCost7, Me.lblGuideTotalCost8, Me.Line6, Me.lblTotalCostGuide, Me.lblTotalGuideCostDollar, Me.lblGuideTotalCost, Me.Line7, Me.lblTotalGuide, Me.Line8, Me.lblGuide1, Me.lblGuide2, Me.lblGuide3, Me.lblGuide4, Me.lblGuide5, Me.lblGuide6, Me.lblGuide7, Me.lblGuide8, Me.lblType, Me.lblGuide, Me.lblCostPerGuide1, Me.lblCostPerGuide2, Me.lblCostPerGuide3, Me.lblCostPerGuide4, Me.lblCostPerGuide5, Me.lblCostPerGuide6, Me.lblCostPerGuide7, Me.lblCostPerGuide8, Me.lblGuideDollar, Me.lblGuideCost, Me.lblGuidePerRod1, Me.lblGuidePerRod2, Me.lblGuidePerRod3, Me.lblGuidePerRod4, Me.lblGuidePerRod5, Me.lblGuidePerRod6, Me.lblGuidePerRod7, Me.lblGuidePerRod8, Me.Label73, Me.lblNumGuides, Me.Line9, Me.Line10, Me.Line17, Me.lblCost18, Me.lblCost20, Me.lblCost19, Me.lblCost17, Me.lblRodDiam11, Me.lblRodDiam12, Me.lblRodDiam13, Me.lblRodDiam14, Me.lblRodDiam15, Me.lblRodDiam16, Me.lblRodDiam17, Me.lblRodDiam18, Me.lblRodGrade11, Me.lblRodGrade12, Me.lblRodGrade13, Me.lblRodGrade14, Me.lblRodGrade15, Me.lblRodGrade16, Me.lblRodGrade17, Me.lblRodGrade18, Me.lblRodLength11, Me.lblRodLength12, Me.lblRodLength13, Me.lblRodLength14, Me.lblRodLength15, Me.lblRodLength16, Me.lblRodLength17, Me.lblRodLength18, Me.lblTotalCost11, Me.lblTotalCost12, Me.lblTotalCost13, Me.lblTotalCost14, Me.lblTotalCost15, Me.lblTotalCost16, Me.lblTotalCost17, Me.lblTotalCost18, Me.lblCost11, Me.lblCost12, Me.lblCost13, Me.lblCost14, Me.lblCost15, Me.lblCost16, Me.lblRodDiam19, Me.lblRodGrade19, Me.lblRodLength19, Me.lblTotalCost19, Me.lblRodDiam20, Me.lblRodGrade20, Me.lblRodLength20, Me.lblTotalCost20 })
			Me.PageHeader.Height = 8.052083F
			Me.PageHeader.Name = "PageHeader"
			Me.lblTitle1.Height = 0.17F
			Me.lblTitle1.HyperLink = Nothing
			Me.lblTitle1.Left = 0.0625F
			Me.lblTitle1.Name = "lblTitle1"
			Me.lblTitle1.Style = "font-family: Microsoft Sans Serif; font-size: 9pt; font-weight: bold; text-align: center"
			Me.lblTitle1.Text = "RODSTAR-D 1.0"
			Me.lblTitle1.Top = 0F
			Me.lblTitle1.Width = 7.9375F
			Me.lblCost8.Height = 0.125F
			Me.lblCost8.HyperLink = Nothing
			Me.lblCost8.Left = 2.8125F
			Me.lblCost8.Name = "lblCost8"
			Me.lblCost8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost8.Text = "N/A"
			Me.lblCost8.Top = 2.75F
			Me.lblCost8.Visible = False
			Me.lblCost8.Width = 1F
			Me.lblCost10.Height = 0.125F
			Me.lblCost10.HyperLink = Nothing
			Me.lblCost10.Left = 2.8125F
			Me.lblCost10.Name = "lblCost10"
			Me.lblCost10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost10.Text = "N/A"
			Me.lblCost10.Top = 3F
			Me.lblCost10.Visible = False
			Me.lblCost10.Width = 1F
			Me.lblCost9.Height = 0.125F
			Me.lblCost9.HyperLink = Nothing
			Me.lblCost9.Left = 2.8125F
			Me.lblCost9.Name = "lblCost9"
			Me.lblCost9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost9.Text = "N/A"
			Me.lblCost9.Top = 2.875F
			Me.lblCost9.Visible = False
			Me.lblCost9.Width = 1F
			Me.lblCost7.Height = 0.125F
			Me.lblCost7.HyperLink = Nothing
			Me.lblCost7.Left = 2.8125F
			Me.lblCost7.Name = "lblCost7"
			Me.lblCost7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost7.Text = "N/A"
			Me.lblCost7.Top = 2.625F
			Me.lblCost7.Visible = False
			Me.lblCost7.Width = 1F
			Me.lblRodStringDesign.Height = 0.125F
			Me.lblRodStringDesign.HyperLink = Nothing
			Me.lblRodStringDesign.Left = 0.3125F
			Me.lblRodStringDesign.Name = "lblRodStringDesign"
			Me.lblRodStringDesign.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodStringDesign.Text = "ROD STRING COST ANALYSIS"
			Me.lblRodStringDesign.Top = 1.25F
			Me.lblRodStringDesign.Width = 5.9375F
			Me.Line11.Height = 0F
			Me.Line11.Left = 0.313F
			Me.Line11.LineWeight = 1F
			Me.Line11.Name = "Line11"
			Me.Line11.Top = 1.4375F
			Me.Line11.Width = 4.75F
			Me.Line11.X1 = 0.313F
			Me.Line11.X2 = 5.063F
			Me.Line11.Y1 = 1.4375F
			Me.Line11.Y2 = 1.4375F
			Me.lblRodDiamHdrTop.Height = 0.125F
			Me.lblRodDiamHdrTop.HyperLink = Nothing
			Me.lblRodDiamHdrTop.Left = 0.3819447F
			Me.lblRodDiamHdrTop.Name = "lblRodDiamHdrTop"
			Me.lblRodDiamHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodDiamHdrTop.Text = "Diameter"
			Me.lblRodDiamHdrTop.Top = 1.5F
			Me.lblRodDiamHdrTop.Width = 0.6875F
			Me.lblRodDiamHdrBot.Height = 0.125F
			Me.lblRodDiamHdrBot.HyperLink = Nothing
			Me.lblRodDiamHdrBot.Left = 0.3819447F
			Me.lblRodDiamHdrBot.Name = "lblRodDiamHdrBot"
			Me.lblRodDiamHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodDiamHdrBot.Text = "(inches)"
			Me.lblRodDiamHdrBot.Top = 1.625F
			Me.lblRodDiamHdrBot.Width = 0.6875F
			Me.lblRodDiam1.Height = 0.125F
			Me.lblRodDiam1.HyperLink = Nothing
			Me.lblRodDiam1.Left = 0.3819447F
			Me.lblRodDiam1.Name = "lblRodDiam1"
			Me.lblRodDiam1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam1.Text = "Diam"
			Me.lblRodDiam1.Top = 1.875F
			Me.lblRodDiam1.Visible = False
			Me.lblRodDiam1.Width = 0.6875F
			Me.lblRodGradeHdrTop.Height = 0.125F
			Me.lblRodGradeHdrTop.HyperLink = Nothing
			Me.lblRodGradeHdrTop.Left = 1.194444F
			Me.lblRodGradeHdrTop.Name = "lblRodGradeHdrTop"
			Me.lblRodGradeHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGradeHdrTop.Text = "Rod"
			Me.lblRodGradeHdrTop.Top = 1.5F
			Me.lblRodGradeHdrTop.Width = 0.875F
			Me.lblRodGradeHdrBot.Height = 0.125F
			Me.lblRodGradeHdrBot.HyperLink = Nothing
			Me.lblRodGradeHdrBot.Left = 1.194444F
			Me.lblRodGradeHdrBot.Name = "lblRodGradeHdrBot"
			Me.lblRodGradeHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGradeHdrBot.Text = "Grade"
			Me.lblRodGradeHdrBot.Top = 1.625F
			Me.lblRodGradeHdrBot.Width = 0.875F
			Me.lblRodLengthHdrTop.Height = 0.125F
			Me.lblRodLengthHdrTop.HyperLink = Nothing
			Me.lblRodLengthHdrTop.Left = 2.194444F
			Me.lblRodLengthHdrTop.Name = "lblRodLengthHdrTop"
			Me.lblRodLengthHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodLengthHdrTop.Text = "Length"
			Me.lblRodLengthHdrTop.Top = 1.5F
			Me.lblRodLengthHdrTop.Width = 0.5F
			Me.lblRodLengthHdrBot.Height = 0.125F
			Me.lblRodLengthHdrBot.HyperLink = Nothing
			Me.lblRodLengthHdrBot.Left = 2.194444F
			Me.lblRodLengthHdrBot.Name = "lblRodLengthHdrBot"
			Me.lblRodLengthHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodLengthHdrBot.Text = "(ft)"
			Me.lblRodLengthHdrBot.Top = 1.625F
			Me.lblRodLengthHdrBot.Width = 0.5F
			Me.Line12.Height = 0F
			Me.Line12.Left = 0.313F
			Me.Line12.LineWeight = 1F
			Me.Line12.Name = "Line12"
			Me.Line12.Top = 1.8125F
			Me.Line12.Width = 4.7495F
			Me.Line12.X1 = 0.313F
			Me.Line12.X2 = 5.0625F
			Me.Line12.Y1 = 1.8125F
			Me.Line12.Y2 = 1.8125F
			Me.lblRodDiam2.Height = 0.125F
			Me.lblRodDiam2.HyperLink = Nothing
			Me.lblRodDiam2.Left = 0.3819447F
			Me.lblRodDiam2.Name = "lblRodDiam2"
			Me.lblRodDiam2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam2.Text = "Diam"
			Me.lblRodDiam2.Top = 2F
			Me.lblRodDiam2.Visible = False
			Me.lblRodDiam2.Width = 0.6875F
			Me.lblRodDiam3.Height = 0.125F
			Me.lblRodDiam3.HyperLink = Nothing
			Me.lblRodDiam3.Left = 0.3819447F
			Me.lblRodDiam3.Name = "lblRodDiam3"
			Me.lblRodDiam3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam3.Text = "Diam"
			Me.lblRodDiam3.Top = 2.125F
			Me.lblRodDiam3.Visible = False
			Me.lblRodDiam3.Width = 0.6875F
			Me.lblRodDiam4.Height = 0.125F
			Me.lblRodDiam4.HyperLink = Nothing
			Me.lblRodDiam4.Left = 0.3819447F
			Me.lblRodDiam4.Name = "lblRodDiam4"
			Me.lblRodDiam4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam4.Text = "Diam"
			Me.lblRodDiam4.Top = 2.25F
			Me.lblRodDiam4.Visible = False
			Me.lblRodDiam4.Width = 0.6875F
			Me.lblRodDiam5.Height = 0.125F
			Me.lblRodDiam5.HyperLink = Nothing
			Me.lblRodDiam5.Left = 0.3819447F
			Me.lblRodDiam5.Name = "lblRodDiam5"
			Me.lblRodDiam5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam5.Text = "Diam"
			Me.lblRodDiam5.Top = 2.375F
			Me.lblRodDiam5.Visible = False
			Me.lblRodDiam5.Width = 0.6875F
			Me.lblRodDiam6.Height = 0.125F
			Me.lblRodDiam6.HyperLink = Nothing
			Me.lblRodDiam6.Left = 0.3819447F
			Me.lblRodDiam6.Name = "lblRodDiam6"
			Me.lblRodDiam6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam6.Text = "Diam"
			Me.lblRodDiam6.Top = 2.5F
			Me.lblRodDiam6.Visible = False
			Me.lblRodDiam6.Width = 0.6875F
			Me.lblRodDiam7.Height = 0.125F
			Me.lblRodDiam7.HyperLink = Nothing
			Me.lblRodDiam7.Left = 0.3819447F
			Me.lblRodDiam7.Name = "lblRodDiam7"
			Me.lblRodDiam7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam7.Text = "Diam"
			Me.lblRodDiam7.Top = 2.625F
			Me.lblRodDiam7.Visible = False
			Me.lblRodDiam7.Width = 0.6875F
			Me.lblRodDiam8.Height = 0.125F
			Me.lblRodDiam8.HyperLink = Nothing
			Me.lblRodDiam8.Left = 0.3819447F
			Me.lblRodDiam8.Name = "lblRodDiam8"
			Me.lblRodDiam8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam8.Text = "Diam"
			Me.lblRodDiam8.Top = 2.75F
			Me.lblRodDiam8.Visible = False
			Me.lblRodDiam8.Width = 0.6875F
			Me.lblRodGrade1.Height = 0.125F
			Me.lblRodGrade1.HyperLink = Nothing
			Me.lblRodGrade1.Left = 1.194444F
			Me.lblRodGrade1.Name = "lblRodGrade1"
			Me.lblRodGrade1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade1.Text = "Grade"
			Me.lblRodGrade1.Top = 1.875F
			Me.lblRodGrade1.Visible = False
			Me.lblRodGrade1.Width = 0.875F
			Me.lblRodGrade2.Height = 0.125F
			Me.lblRodGrade2.HyperLink = Nothing
			Me.lblRodGrade2.Left = 1.194444F
			Me.lblRodGrade2.Name = "lblRodGrade2"
			Me.lblRodGrade2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade2.Text = "Grade"
			Me.lblRodGrade2.Top = 2F
			Me.lblRodGrade2.Visible = False
			Me.lblRodGrade2.Width = 0.875F
			Me.lblRodGrade3.Height = 0.125F
			Me.lblRodGrade3.HyperLink = Nothing
			Me.lblRodGrade3.Left = 1.194444F
			Me.lblRodGrade3.Name = "lblRodGrade3"
			Me.lblRodGrade3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade3.Text = "Grade"
			Me.lblRodGrade3.Top = 2.125F
			Me.lblRodGrade3.Visible = False
			Me.lblRodGrade3.Width = 0.875F
			Me.lblRodGrade4.Height = 0.125F
			Me.lblRodGrade4.HyperLink = Nothing
			Me.lblRodGrade4.Left = 1.194444F
			Me.lblRodGrade4.Name = "lblRodGrade4"
			Me.lblRodGrade4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade4.Text = "Grade"
			Me.lblRodGrade4.Top = 2.25F
			Me.lblRodGrade4.Visible = False
			Me.lblRodGrade4.Width = 0.875F
			Me.lblRodGrade5.Height = 0.125F
			Me.lblRodGrade5.HyperLink = Nothing
			Me.lblRodGrade5.Left = 1.194444F
			Me.lblRodGrade5.Name = "lblRodGrade5"
			Me.lblRodGrade5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade5.Text = "Grade"
			Me.lblRodGrade5.Top = 2.375F
			Me.lblRodGrade5.Visible = False
			Me.lblRodGrade5.Width = 0.875F
			Me.lblRodGrade6.Height = 0.125F
			Me.lblRodGrade6.HyperLink = Nothing
			Me.lblRodGrade6.Left = 1.194444F
			Me.lblRodGrade6.Name = "lblRodGrade6"
			Me.lblRodGrade6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade6.Text = "Grade"
			Me.lblRodGrade6.Top = 2.5F
			Me.lblRodGrade6.Visible = False
			Me.lblRodGrade6.Width = 0.875F
			Me.lblRodGrade7.Height = 0.125F
			Me.lblRodGrade7.HyperLink = Nothing
			Me.lblRodGrade7.Left = 1.194444F
			Me.lblRodGrade7.Name = "lblRodGrade7"
			Me.lblRodGrade7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade7.Text = "Grade"
			Me.lblRodGrade7.Top = 2.625F
			Me.lblRodGrade7.Visible = False
			Me.lblRodGrade7.Width = 0.875F
			Me.lblRodGrade8.Height = 0.125F
			Me.lblRodGrade8.HyperLink = Nothing
			Me.lblRodGrade8.Left = 1.194444F
			Me.lblRodGrade8.Name = "lblRodGrade8"
			Me.lblRodGrade8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade8.Text = "Grade"
			Me.lblRodGrade8.Top = 2.75F
			Me.lblRodGrade8.Visible = False
			Me.lblRodGrade8.Width = 0.875F
			Me.lblRodLength1.Height = 0.125F
			Me.lblRodLength1.HyperLink = Nothing
			Me.lblRodLength1.Left = 2.194444F
			Me.lblRodLength1.Name = "lblRodLength1"
			Me.lblRodLength1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength1.Text = "Len"
			Me.lblRodLength1.Top = 1.875F
			Me.lblRodLength1.Visible = False
			Me.lblRodLength1.Width = 0.4930553F
			Me.lblRodLength2.Height = 0.125F
			Me.lblRodLength2.HyperLink = Nothing
			Me.lblRodLength2.Left = 2.194444F
			Me.lblRodLength2.Name = "lblRodLength2"
			Me.lblRodLength2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength2.Text = "Len"
			Me.lblRodLength2.Top = 2F
			Me.lblRodLength2.Visible = False
			Me.lblRodLength2.Width = 0.4930553F
			Me.lblRodLength3.Height = 0.125F
			Me.lblRodLength3.HyperLink = Nothing
			Me.lblRodLength3.Left = 2.194444F
			Me.lblRodLength3.Name = "lblRodLength3"
			Me.lblRodLength3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength3.Text = "Len"
			Me.lblRodLength3.Top = 2.125F
			Me.lblRodLength3.Visible = False
			Me.lblRodLength3.Width = 0.4930553F
			Me.lblRodLength4.Height = 0.125F
			Me.lblRodLength4.HyperLink = Nothing
			Me.lblRodLength4.Left = 2.194444F
			Me.lblRodLength4.Name = "lblRodLength4"
			Me.lblRodLength4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength4.Text = "Len"
			Me.lblRodLength4.Top = 2.25F
			Me.lblRodLength4.Visible = False
			Me.lblRodLength4.Width = 0.4930553F
			Me.lblRodLength5.Height = 0.125F
			Me.lblRodLength5.HyperLink = Nothing
			Me.lblRodLength5.Left = 2.194444F
			Me.lblRodLength5.Name = "lblRodLength5"
			Me.lblRodLength5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength5.Text = "Len"
			Me.lblRodLength5.Top = 2.375F
			Me.lblRodLength5.Visible = False
			Me.lblRodLength5.Width = 0.4930553F
			Me.lblRodLength6.Height = 0.125F
			Me.lblRodLength6.HyperLink = Nothing
			Me.lblRodLength6.Left = 2.194444F
			Me.lblRodLength6.Name = "lblRodLength6"
			Me.lblRodLength6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength6.Text = "Len"
			Me.lblRodLength6.Top = 2.5F
			Me.lblRodLength6.Visible = False
			Me.lblRodLength6.Width = 0.4930553F
			Me.lblRodLength7.Height = 0.125F
			Me.lblRodLength7.HyperLink = Nothing
			Me.lblRodLength7.Left = 2.194444F
			Me.lblRodLength7.Name = "lblRodLength7"
			Me.lblRodLength7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength7.Text = "Len"
			Me.lblRodLength7.Top = 2.625F
			Me.lblRodLength7.Visible = False
			Me.lblRodLength7.Width = 0.4930553F
			Me.lblRodLength8.Height = 0.125F
			Me.lblRodLength8.HyperLink = Nothing
			Me.lblRodLength8.Left = 2.194444F
			Me.lblRodLength8.Name = "lblRodLength8"
			Me.lblRodLength8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength8.Text = "Len"
			Me.lblRodLength8.Top = 2.75F
			Me.lblRodLength8.Visible = False
			Me.lblRodLength8.Width = 0.4930553F
			Me.linRSInputSep1.Height = 3.092F
			Me.linRSInputSep1.Left = 1.132F
			Me.linRSInputSep1.LineWeight = 1F
			Me.linRSInputSep1.Name = "linRSInputSep1"
			Me.linRSInputSep1.Top = 1.418F
			Me.linRSInputSep1.Width = 0F
			Me.linRSInputSep1.X1 = 1.132F
			Me.linRSInputSep1.X2 = 1.132F
			Me.linRSInputSep1.Y1 = 1.418F
			Me.linRSInputSep1.Y2 = 4.51F
			Me.linRSInputSep2.Height = 3.085556F
			Me.linRSInputSep2.Left = 2.132F
			Me.linRSInputSep2.LineWeight = 1F
			Me.linRSInputSep2.Name = "linRSInputSep2"
			Me.linRSInputSep2.Top = 1.424444F
			Me.linRSInputSep2.Width = 0F
			Me.linRSInputSep2.X1 = 2.132F
			Me.linRSInputSep2.X2 = 2.132F
			Me.linRSInputSep2.Y1 = 1.424444F
			Me.linRSInputSep2.Y2 = 4.51F
			Me.linRSInputSep3.Height = 3.085556F
			Me.linRSInputSep3.Left = 2.757F
			Me.linRSInputSep3.LineWeight = 1F
			Me.linRSInputSep3.Name = "linRSInputSep3"
			Me.linRSInputSep3.Top = 1.424444F
			Me.linRSInputSep3.Width = 0F
			Me.linRSInputSep3.X1 = 2.757F
			Me.linRSInputSep3.X2 = 2.757F
			Me.linRSInputSep3.Y1 = 1.424444F
			Me.linRSInputSep3.Y2 = 4.51F
			Me.lblTotalCost1.Height = 0.125F
			Me.lblTotalCost1.HyperLink = Nothing
			Me.lblTotalCost1.Left = 3.9375F
			Me.lblTotalCost1.Name = "lblTotalCost1"
			Me.lblTotalCost1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost1.Text = "N/A"
			Me.lblTotalCost1.Top = 1.875F
			Me.lblTotalCost1.Visible = False
			Me.lblTotalCost1.Width = 1F
			Me.lblTotalCost2.Height = 0.125F
			Me.lblTotalCost2.HyperLink = Nothing
			Me.lblTotalCost2.Left = 3.9375F
			Me.lblTotalCost2.Name = "lblTotalCost2"
			Me.lblTotalCost2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost2.Text = "N/A"
			Me.lblTotalCost2.Top = 2F
			Me.lblTotalCost2.Visible = False
			Me.lblTotalCost2.Width = 1F
			Me.lblTotalCost3.Height = 0.125F
			Me.lblTotalCost3.HyperLink = Nothing
			Me.lblTotalCost3.Left = 3.9375F
			Me.lblTotalCost3.Name = "lblTotalCost3"
			Me.lblTotalCost3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost3.Text = "N/A"
			Me.lblTotalCost3.Top = 2.125F
			Me.lblTotalCost3.Visible = False
			Me.lblTotalCost3.Width = 1F
			Me.lblTotalCost4.Height = 0.125F
			Me.lblTotalCost4.HyperLink = Nothing
			Me.lblTotalCost4.Left = 3.9375F
			Me.lblTotalCost4.Name = "lblTotalCost4"
			Me.lblTotalCost4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost4.Text = "N/A"
			Me.lblTotalCost4.Top = 2.25F
			Me.lblTotalCost4.Visible = False
			Me.lblTotalCost4.Width = 1F
			Me.lblTotalCost5.Height = 0.125F
			Me.lblTotalCost5.HyperLink = Nothing
			Me.lblTotalCost5.Left = 3.9375F
			Me.lblTotalCost5.Name = "lblTotalCost5"
			Me.lblTotalCost5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost5.Text = "N/A"
			Me.lblTotalCost5.Top = 2.375F
			Me.lblTotalCost5.Visible = False
			Me.lblTotalCost5.Width = 1F
			Me.lblTotalCost6.Height = 0.125F
			Me.lblTotalCost6.HyperLink = Nothing
			Me.lblTotalCost6.Left = 3.9375F
			Me.lblTotalCost6.Name = "lblTotalCost6"
			Me.lblTotalCost6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost6.Text = "N/A"
			Me.lblTotalCost6.Top = 2.5F
			Me.lblTotalCost6.Visible = False
			Me.lblTotalCost6.Width = 1F
			Me.lblTotalCost7.Height = 0.125F
			Me.lblTotalCost7.HyperLink = Nothing
			Me.lblTotalCost7.Left = 3.9375F
			Me.lblTotalCost7.Name = "lblTotalCost7"
			Me.lblTotalCost7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost7.Text = "N/A"
			Me.lblTotalCost7.Top = 2.625F
			Me.lblTotalCost7.Visible = False
			Me.lblTotalCost7.Width = 1F
			Me.lblTotalCost8.Height = 0.125F
			Me.lblTotalCost8.HyperLink = Nothing
			Me.lblTotalCost8.Left = 3.9375F
			Me.lblTotalCost8.Name = "lblTotalCost8"
			Me.lblTotalCost8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost8.Text = "N/A"
			Me.lblTotalCost8.Top = 2.75F
			Me.lblTotalCost8.Visible = False
			Me.lblTotalCost8.Width = 1F
			Me.Line13.Height = 3.085556F
			Me.Line13.Left = 3.882F
			Me.Line13.LineWeight = 1F
			Me.Line13.Name = "Line13"
			Me.Line13.Top = 1.424444F
			Me.Line13.Width = 0F
			Me.Line13.X1 = 3.882F
			Me.Line13.X2 = 3.882F
			Me.Line13.Y1 = 1.424444F
			Me.Line13.Y2 = 4.51F
			Me.Label9.Height = 0.125F
			Me.Label9.HyperLink = Nothing
			Me.Label9.Left = 3.9375F
			Me.Label9.Name = "Label9"
			Me.Label9.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.Label9.Text = "Total Cost"
			Me.Label9.Top = 1.5F
			Me.Label9.Width = 1F
			Me.Label10.Height = 0.125F
			Me.Label10.HyperLink = Nothing
			Me.Label10.Left = 3.9375F
			Me.Label10.Name = "Label10"
			Me.Label10.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.Label10.Text = "($)"
			Me.Label10.Top = 1.625F
			Me.Label10.Width = 1F
			Me.lblTotalRSCost2.Height = 0.16F
			Me.lblTotalRSCost2.HyperLink = Nothing
			Me.lblTotalRSCost2.Left = 3.937F
			Me.lblTotalRSCost2.Name = "lblTotalRSCost2"
			Me.lblTotalRSCost2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalRSCost2.Text = "N/A"
			Me.lblTotalRSCost2.Top = 4.72F
			Me.lblTotalRSCost2.Width = 1F
			Me.lblPumpingUnitDesign.Height = 0.125F
			Me.lblPumpingUnitDesign.HyperLink = Nothing
			Me.lblPumpingUnitDesign.Left = 0.3120002F
			Me.lblPumpingUnitDesign.Name = "lblPumpingUnitDesign"
			Me.lblPumpingUnitDesign.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 7.8pt; text-align: left; white-space: nowrap"
			Me.lblPumpingUnitDesign.Text = "PUMPING UNIT COST ANALYSIS"
			Me.lblPumpingUnitDesign.Top = 4.97F
			Me.lblPumpingUnitDesign.Width = 5.9375F
			Me.lblTotalPUCost2.Height = 0.17F
			Me.lblTotalPUCost2.HyperLink = Nothing
			Me.lblTotalPUCost2.Left = 3.937F
			Me.lblTotalPUCost2.Name = "lblTotalPUCost2"
			Me.lblTotalPUCost2.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblTotalPUCost2.Text = "N/A"
			Me.lblTotalPUCost2.Top = 5.468006F
			Me.lblTotalPUCost2.Width = 1F
			Me.lblTotalPUCost.Height = 0.17F
			Me.lblTotalPUCost.HyperLink = Nothing
			Me.lblTotalPUCost.Left = 2.8745F
			Me.lblTotalPUCost.Name = "lblTotalPUCost"
			Me.lblTotalPUCost.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblTotalPUCost.Text = "Total ($):"
			Me.lblTotalPUCost.Top = 5.468006F
			Me.lblTotalPUCost.Width = 1F
			Me.lblManufacturer.Height = 0.14F
			Me.lblManufacturer.HyperLink = Nothing
			Me.lblManufacturer.Left = 0.3745002F
			Me.lblManufacturer.Name = "lblManufacturer"
			Me.lblManufacturer.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblManufacturer.Text = "Manufacturer:"
			Me.lblManufacturer.Top = 5.157504F
			Me.lblManufacturer.Width = 2.375F
			Me.lblAPISize.Height = 0.14F
			Me.lblAPISize.HyperLink = Nothing
			Me.lblAPISize.Left = 0.3745002F
			Me.lblAPISize.Name = "lblAPISize"
			Me.lblAPISize.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblAPISize.Text = "API Size :"
			Me.lblAPISize.Top = 5.313005F
			Me.lblAPISize.Width = 2.375F
			Me.lblUnitName.Height = 0.14F
			Me.lblUnitName.HyperLink = Nothing
			Me.lblUnitName.Left = 0.3745002F
			Me.lblUnitName.Name = "lblUnitName"
			Me.lblUnitName.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblUnitName.Text = "Unit name:"
			Me.lblUnitName.Top = 5.468006F
			Me.lblUnitName.Width = 2.375F
			Me.lblCost1.Height = 0.125F
			Me.lblCost1.HyperLink = Nothing
			Me.lblCost1.Left = 2.8125F
			Me.lblCost1.Name = "lblCost1"
			Me.lblCost1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost1.Text = "N/A"
			Me.lblCost1.Top = 1.875F
			Me.lblCost1.Visible = False
			Me.lblCost1.Width = 1F
			Me.lblCost2.Height = 0.125F
			Me.lblCost2.HyperLink = Nothing
			Me.lblCost2.Left = 2.8125F
			Me.lblCost2.Name = "lblCost2"
			Me.lblCost2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost2.Text = "N/A"
			Me.lblCost2.Top = 2F
			Me.lblCost2.Visible = False
			Me.lblCost2.Width = 1F
			Me.lblCost3.Height = 0.125F
			Me.lblCost3.HyperLink = Nothing
			Me.lblCost3.Left = 2.8125F
			Me.lblCost3.Name = "lblCost3"
			Me.lblCost3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost3.Text = "N/A"
			Me.lblCost3.Top = 2.125F
			Me.lblCost3.Visible = False
			Me.lblCost3.Width = 1F
			Me.lblCost4.Height = 0.125F
			Me.lblCost4.HyperLink = Nothing
			Me.lblCost4.Left = 2.8125F
			Me.lblCost4.Name = "lblCost4"
			Me.lblCost4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost4.Text = "N/A"
			Me.lblCost4.Top = 2.25F
			Me.lblCost4.Visible = False
			Me.lblCost4.Width = 1F
			Me.lblCost5.Height = 0.125F
			Me.lblCost5.HyperLink = Nothing
			Me.lblCost5.Left = 2.8125F
			Me.lblCost5.Name = "lblCost5"
			Me.lblCost5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost5.Text = "N/A"
			Me.lblCost5.Top = 2.375F
			Me.lblCost5.Visible = False
			Me.lblCost5.Width = 1F
			Me.lblCost6.Height = 0.125F
			Me.lblCost6.HyperLink = Nothing
			Me.lblCost6.Left = 2.8125F
			Me.lblCost6.Name = "lblCost6"
			Me.lblCost6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost6.Text = "N/A"
			Me.lblCost6.Top = 2.5F
			Me.lblCost6.Visible = False
			Me.lblCost6.Width = 1F
			Me.Line15.Height = 3.075556F
			Me.Line15.Left = 5.062556F
			Me.Line15.LineWeight = 1F
			Me.Line15.Name = "Line15"
			Me.Line15.Top = 1.434444F
			Me.Line15.Width = 0.0005002022F
			Me.Line15.X1 = 5.063056F
			Me.Line15.X2 = 5.062556F
			Me.Line15.Y1 = 1.434444F
			Me.Line15.Y2 = 4.51F
			Me.Label23.Height = 0.125F
			Me.Label23.HyperLink = Nothing
			Me.Label23.Left = 2.8125F
			Me.Label23.Name = "Label23"
			Me.Label23.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.Label23.Text = "Cost"
			Me.Label23.Top = 1.5F
			Me.Label23.Width = 1F
			Me.lblCostHdrBot.Height = 0.125F
			Me.lblCostHdrBot.HyperLink = Nothing
			Me.lblCostHdrBot.Left = 2.8125F
			Me.lblCostHdrBot.Name = "lblCostHdrBot"
			Me.lblCostHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblCostHdrBot.Text = "($/ft)"
			Me.lblCostHdrBot.Top = 1.625F
			Me.lblCostHdrBot.Width = 1F
			Me.lblTotalRSCost.Height = 0.16F
			Me.lblTotalRSCost.HyperLink = Nothing
			Me.lblTotalRSCost.Left = 2.8745F
			Me.lblTotalRSCost.Name = "lblTotalRSCost"
			Me.lblTotalRSCost.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblTotalRSCost.Text = "Total ($):"
			Me.lblTotalRSCost.Top = 4.72F
			Me.lblTotalRSCost.Width = 1F
			Me.lblAddCosts.Height = 0.16F
			Me.lblAddCosts.HyperLink = Nothing
			Me.lblAddCosts.Left = 2.562F
			Me.lblAddCosts.Name = "lblAddCosts"
			Me.lblAddCosts.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblAddCosts.Text = "Additional rod costs ($):"
			Me.lblAddCosts.Top = 4.55F
			Me.lblAddCosts.Visible = False
			Me.lblAddCosts.Width = 1.3125F
			Me.lblAddCosts2.Height = 0.16F
			Me.lblAddCosts2.HyperLink = Nothing
			Me.lblAddCosts2.Left = 3.937F
			Me.lblAddCosts2.Name = "lblAddCosts2"
			Me.lblAddCosts2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblAddCosts2.Text = "N/A"
			Me.lblAddCosts2.Top = 4.55F
			Me.lblAddCosts2.Visible = False
			Me.lblAddCosts2.Width = 1F
			Me.Line16.Height = 3.072F
			Me.Line16.Left = 0.3125F
			Me.Line16.LineWeight = 1F
			Me.Line16.Name = "Line16"
			Me.Line16.Top = 1.438F
			Me.Line16.Width = 0.0005002022F
			Me.Line16.X1 = 0.3130002F
			Me.Line16.X2 = 0.3125F
			Me.Line16.Y1 = 1.438F
			Me.Line16.Y2 = 4.51F
			Me.lblComment.Height = 0.302F
			Me.lblComment.HyperLink = Nothing
			Me.lblComment.Left = 0.0625F
			Me.lblComment.Name = "lblComment"
			Me.lblComment.Style = "font-family: Microsoft Sans Serif; font-size: 8pt"
			Me.lblComment.Text = "Comment: "
			Me.lblComment.Top = 0.69F
			Me.lblComment.Width = 7.9375F
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
			Me.lblRodDiam9.Height = 0.125F
			Me.lblRodDiam9.HyperLink = Nothing
			Me.lblRodDiam9.Left = 0.3819447F
			Me.lblRodDiam9.Name = "lblRodDiam9"
			Me.lblRodDiam9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam9.Text = "Diam"
			Me.lblRodDiam9.Top = 2.875F
			Me.lblRodDiam9.Visible = False
			Me.lblRodDiam9.Width = 0.6875F
			Me.lblRodGrade9.Height = 0.125F
			Me.lblRodGrade9.HyperLink = Nothing
			Me.lblRodGrade9.Left = 1.194444F
			Me.lblRodGrade9.Name = "lblRodGrade9"
			Me.lblRodGrade9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade9.Text = "Grade"
			Me.lblRodGrade9.Top = 2.875F
			Me.lblRodGrade9.Visible = False
			Me.lblRodGrade9.Width = 0.875F
			Me.lblRodLength9.Height = 0.125F
			Me.lblRodLength9.HyperLink = Nothing
			Me.lblRodLength9.Left = 2.194444F
			Me.lblRodLength9.Name = "lblRodLength9"
			Me.lblRodLength9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength9.Text = "Len"
			Me.lblRodLength9.Top = 2.875F
			Me.lblRodLength9.Visible = False
			Me.lblRodLength9.Width = 0.4930553F
			Me.lblTotalCost9.Height = 0.125F
			Me.lblTotalCost9.HyperLink = Nothing
			Me.lblTotalCost9.Left = 3.9375F
			Me.lblTotalCost9.Name = "lblTotalCost9"
			Me.lblTotalCost9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost9.Text = "N/A"
			Me.lblTotalCost9.Top = 2.875F
			Me.lblTotalCost9.Visible = False
			Me.lblTotalCost9.Width = 1F
			Me.lblRodDiam10.Height = 0.125F
			Me.lblRodDiam10.HyperLink = Nothing
			Me.lblRodDiam10.Left = 0.3819447F
			Me.lblRodDiam10.Name = "lblRodDiam10"
			Me.lblRodDiam10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam10.Text = "Diam"
			Me.lblRodDiam10.Top = 3F
			Me.lblRodDiam10.Visible = False
			Me.lblRodDiam10.Width = 0.6875F
			Me.lblRodGrade10.Height = 0.125F
			Me.lblRodGrade10.HyperLink = Nothing
			Me.lblRodGrade10.Left = 1.194444F
			Me.lblRodGrade10.Name = "lblRodGrade10"
			Me.lblRodGrade10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade10.Text = "Grade"
			Me.lblRodGrade10.Top = 3F
			Me.lblRodGrade10.Visible = False
			Me.lblRodGrade10.Width = 0.875F
			Me.lblRodLength10.Height = 0.125F
			Me.lblRodLength10.HyperLink = Nothing
			Me.lblRodLength10.Left = 2.194444F
			Me.lblRodLength10.Name = "lblRodLength10"
			Me.lblRodLength10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength10.Text = "Len"
			Me.lblRodLength10.Top = 3F
			Me.lblRodLength10.Visible = False
			Me.lblRodLength10.Width = 0.4930553F
			Me.lblTotalCost10.Height = 0.125F
			Me.lblTotalCost10.HyperLink = Nothing
			Me.lblTotalCost10.Left = 3.9375F
			Me.lblTotalCost10.Name = "lblTotalCost10"
			Me.lblTotalCost10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost10.Text = "N/A"
			Me.lblTotalCost10.Top = 3F
			Me.lblTotalCost10.Visible = False
			Me.lblTotalCost10.Width = 1F
			Me.Line14.Height = 0F
			Me.Line14.Left = 0.3130002F
			Me.Line14.LineWeight = 1F
			Me.Line14.Name = "Line14"
			Me.Line14.Top = 4.523001F
			Me.Line14.Width = 4.75F
			Me.Line14.X1 = 0.3130002F
			Me.Line14.X2 = 5.063001F
			Me.Line14.Y1 = 4.523001F
			Me.Line14.Y2 = 4.523001F
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
			Me.lblGuideCostAnalysis.Height = 0.125F
			Me.lblGuideCostAnalysis.HyperLink = Nothing
			Me.lblGuideCostAnalysis.Left = 0.3120005F
			Me.lblGuideCostAnalysis.Name = "lblGuideCostAnalysis"
			Me.lblGuideCostAnalysis.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblGuideCostAnalysis.Text = "GUIDE COST ANALYSIS"
			Me.lblGuideCostAnalysis.Top = 5.720014F
			Me.lblGuideCostAnalysis.Width = 5.9375F
			Me.Line1.Height = 0F
			Me.Line1.Left = 0.3405005F
			Me.Line1.LineWeight = 1F
			Me.Line1.Name = "Line1"
			Me.Line1.Top = 5.888013F
			Me.Line1.Width = 3.989F
			Me.Line1.X1 = 0.3405005F
			Me.Line1.X2 = 4.3295F
			Me.Line1.Y1 = 5.888013F
			Me.Line1.Y2 = 5.888013F
			Me.lblGuideTotalCost1.Height = 0.125F
			Me.lblGuideTotalCost1.HyperLink = Nothing
			Me.lblGuideTotalCost1.Left = 3.2455F
			Me.lblGuideTotalCost1.Name = "lblGuideTotalCost1"
			Me.lblGuideTotalCost1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuideTotalCost1.Text = "N/A"
			Me.lblGuideTotalCost1.Top = 6.385013F
			Me.lblGuideTotalCost1.Visible = False
			Me.lblGuideTotalCost1.Width = 1F
			Me.lblGuideTotalCost2.Height = 0.125F
			Me.lblGuideTotalCost2.HyperLink = Nothing
			Me.lblGuideTotalCost2.Left = 3.2455F
			Me.lblGuideTotalCost2.Name = "lblGuideTotalCost2"
			Me.lblGuideTotalCost2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuideTotalCost2.Text = "N/A"
			Me.lblGuideTotalCost2.Top = 6.540014F
			Me.lblGuideTotalCost2.Visible = False
			Me.lblGuideTotalCost2.Width = 1F
			Me.lblGuideTotalCost3.Height = 0.125F
			Me.lblGuideTotalCost3.HyperLink = Nothing
			Me.lblGuideTotalCost3.Left = 3.2455F
			Me.lblGuideTotalCost3.Name = "lblGuideTotalCost3"
			Me.lblGuideTotalCost3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuideTotalCost3.Text = "N/A"
			Me.lblGuideTotalCost3.Top = 6.695013F
			Me.lblGuideTotalCost3.Visible = False
			Me.lblGuideTotalCost3.Width = 1F
			Me.lblGuideTotalCost4.Height = 0.125F
			Me.lblGuideTotalCost4.HyperLink = Nothing
			Me.lblGuideTotalCost4.Left = 3.2455F
			Me.lblGuideTotalCost4.Name = "lblGuideTotalCost4"
			Me.lblGuideTotalCost4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuideTotalCost4.Text = "N/A"
			Me.lblGuideTotalCost4.Top = 6.850013F
			Me.lblGuideTotalCost4.Visible = False
			Me.lblGuideTotalCost4.Width = 1F
			Me.lblGuideTotalCost5.Height = 0.125F
			Me.lblGuideTotalCost5.HyperLink = Nothing
			Me.lblGuideTotalCost5.Left = 3.2455F
			Me.lblGuideTotalCost5.Name = "lblGuideTotalCost5"
			Me.lblGuideTotalCost5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuideTotalCost5.Text = "N/A"
			Me.lblGuideTotalCost5.Top = 7.005013F
			Me.lblGuideTotalCost5.Visible = False
			Me.lblGuideTotalCost5.Width = 1F
			Me.lblGuideTotalCost6.Height = 0.125F
			Me.lblGuideTotalCost6.HyperLink = Nothing
			Me.lblGuideTotalCost6.Left = 3.2455F
			Me.lblGuideTotalCost6.Name = "lblGuideTotalCost6"
			Me.lblGuideTotalCost6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuideTotalCost6.Text = "N/A"
			Me.lblGuideTotalCost6.Top = 7.160012F
			Me.lblGuideTotalCost6.Visible = False
			Me.lblGuideTotalCost6.Width = 1F
			Me.lblGuideTotalCost7.Height = 0.125F
			Me.lblGuideTotalCost7.HyperLink = Nothing
			Me.lblGuideTotalCost7.Left = 3.2455F
			Me.lblGuideTotalCost7.Name = "lblGuideTotalCost7"
			Me.lblGuideTotalCost7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuideTotalCost7.Text = "N/A"
			Me.lblGuideTotalCost7.Top = 7.325013F
			Me.lblGuideTotalCost7.Visible = False
			Me.lblGuideTotalCost7.Width = 1F
			Me.lblGuideTotalCost8.Height = 0.125F
			Me.lblGuideTotalCost8.HyperLink = Nothing
			Me.lblGuideTotalCost8.Left = 3.2455F
			Me.lblGuideTotalCost8.Name = "lblGuideTotalCost8"
			Me.lblGuideTotalCost8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuideTotalCost8.Text = "N/A"
			Me.lblGuideTotalCost8.Top = 7.480013F
			Me.lblGuideTotalCost8.Visible = False
			Me.lblGuideTotalCost8.Width = 1F
			Me.Line6.Height = 1.772F
			Me.Line6.Left = 0.3384948F
			Me.Line6.LineWeight = 1F
			Me.Line6.Name = "Line6"
			Me.Line6.Top = 5.898013F
			Me.Line6.Width = 0F
			Me.Line6.X1 = 0.3384948F
			Me.Line6.X2 = 0.3384948F
			Me.Line6.Y1 = 5.898013F
			Me.Line6.Y2 = 7.670013F
			Me.lblTotalCostGuide.Height = 0.1569999F
			Me.lblTotalCostGuide.HyperLink = Nothing
			Me.lblTotalCostGuide.Left = 3.2455F
			Me.lblTotalCostGuide.Name = "lblTotalCostGuide"
			Me.lblTotalCostGuide.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblTotalCostGuide.Text = "Total Cost"
			Me.lblTotalCostGuide.Top = 5.938013F
			Me.lblTotalCostGuide.Width = 1F
			Me.lblTotalGuideCostDollar.Height = 0.1569999F
			Me.lblTotalGuideCostDollar.HyperLink = Nothing
			Me.lblTotalGuideCostDollar.Left = 3.2455F
			Me.lblTotalGuideCostDollar.Name = "lblTotalGuideCostDollar"
			Me.lblTotalGuideCostDollar.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblTotalGuideCostDollar.Text = "($)"
			Me.lblTotalGuideCostDollar.Top = 6.105014F
			Me.lblTotalGuideCostDollar.Width = 1F
			Me.lblGuideTotalCost.Height = 0.17F
			Me.lblGuideTotalCost.HyperLink = Nothing
			Me.lblGuideTotalCost.Left = 3.246F
			Me.lblGuideTotalCost.Name = "lblGuideTotalCost"
			Me.lblGuideTotalCost.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuideTotalCost.Text = "N/A"
			Me.lblGuideTotalCost.Top = 7.758F
			Me.lblGuideTotalCost.Width = 1F
			Me.Line7.Height = 1.772F
			Me.Line7.Left = 4.3295F
			Me.Line7.LineWeight = 1F
			Me.Line7.Name = "Line7"
			Me.Line7.Top = 5.898013F
			Me.Line7.Width = 0F
			Me.Line7.X1 = 4.3295F
			Me.Line7.X2 = 4.3295F
			Me.Line7.Y1 = 5.898013F
			Me.Line7.Y2 = 7.670013F
			Me.lblTotalGuide.Height = 0.17F
			Me.lblTotalGuide.HyperLink = Nothing
			Me.lblTotalGuide.Left = 2.173F
			Me.lblTotalGuide.Name = "lblTotalGuide"
			Me.lblTotalGuide.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblTotalGuide.Text = "Total ($):"
			Me.lblTotalGuide.Top = 7.758F
			Me.lblTotalGuide.Width = 1F
			Me.Line8.Height = 0F
			Me.Line8.Left = 0.3395005F
			Me.Line8.LineWeight = 1F
			Me.Line8.Name = "Line8"
			Me.Line8.Top = 7.670013F
			Me.Line8.Width = 3.99F
			Me.Line8.X1 = 0.3395005F
			Me.Line8.X2 = 4.3295F
			Me.Line8.Y1 = 7.670013F
			Me.Line8.Y2 = 7.670013F
			Me.lblGuide1.Height = 0.15F
			Me.lblGuide1.HyperLink = Nothing
			Me.lblGuide1.Left = 0.4274946F
			Me.lblGuide1.Name = "lblGuide1"
			Me.lblGuide1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide1.Text = "N/A"
			Me.lblGuide1.Top = 6.375014F
			Me.lblGuide1.Visible = False
			Me.lblGuide1.Width = 1F
			Me.lblGuide2.Height = 0.15F
			Me.lblGuide2.HyperLink = Nothing
			Me.lblGuide2.Left = 0.4269948F
			Me.lblGuide2.Name = "lblGuide2"
			Me.lblGuide2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide2.Text = "N/A"
			Me.lblGuide2.Top = 6.530013F
			Me.lblGuide2.Visible = False
			Me.lblGuide2.Width = 1F
			Me.lblGuide3.Height = 0.15F
			Me.lblGuide3.HyperLink = Nothing
			Me.lblGuide3.Left = 0.4269948F
			Me.lblGuide3.Name = "lblGuide3"
			Me.lblGuide3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide3.Text = "N/A"
			Me.lblGuide3.Top = 6.685014F
			Me.lblGuide3.Visible = False
			Me.lblGuide3.Width = 1F
			Me.lblGuide4.Height = 0.14F
			Me.lblGuide4.HyperLink = Nothing
			Me.lblGuide4.Left = 0.4269948F
			Me.lblGuide4.Name = "lblGuide4"
			Me.lblGuide4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide4.Text = "N/A"
			Me.lblGuide4.Top = 6.840014F
			Me.lblGuide4.Visible = False
			Me.lblGuide4.Width = 1F
			Me.lblGuide5.Height = 0.14F
			Me.lblGuide5.HyperLink = Nothing
			Me.lblGuide5.Left = 0.4269948F
			Me.lblGuide5.Name = "lblGuide5"
			Me.lblGuide5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide5.Text = "N/A"
			Me.lblGuide5.Top = 6.995013F
			Me.lblGuide5.Visible = False
			Me.lblGuide5.Width = 1F
			Me.lblGuide6.Height = 0.14F
			Me.lblGuide6.HyperLink = Nothing
			Me.lblGuide6.Left = 0.4274946F
			Me.lblGuide6.Name = "lblGuide6"
			Me.lblGuide6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide6.Text = "N/A"
			Me.lblGuide6.Top = 7.160013F
			Me.lblGuide6.Visible = False
			Me.lblGuide6.Width = 1F
			Me.lblGuide7.Height = 0.14F
			Me.lblGuide7.HyperLink = Nothing
			Me.lblGuide7.Left = 0.4269948F
			Me.lblGuide7.Name = "lblGuide7"
			Me.lblGuide7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide7.Text = "N/A"
			Me.lblGuide7.Top = 7.315013F
			Me.lblGuide7.Visible = False
			Me.lblGuide7.Width = 1F
			Me.lblGuide8.Height = 0.14F
			Me.lblGuide8.HyperLink = Nothing
			Me.lblGuide8.Left = 0.4269948F
			Me.lblGuide8.Name = "lblGuide8"
			Me.lblGuide8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide8.Text = "N/A"
			Me.lblGuide8.Top = 7.470012F
			Me.lblGuide8.Visible = False
			Me.lblGuide8.Width = 1F
			Me.lblType.Height = 0.1569999F
			Me.lblType.HyperLink = Nothing
			Me.lblType.Left = 0.4274946F
			Me.lblType.Name = "lblType"
			Me.lblType.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblType.Text = "Type"
			Me.lblType.Top = 6.105014F
			Me.lblType.Width = 1F
			Me.lblGuide.Height = 0.1569999F
			Me.lblGuide.HyperLink = Nothing
			Me.lblGuide.Left = 0.4274946F
			Me.lblGuide.Name = "lblGuide"
			Me.lblGuide.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblGuide.Text = "Guide"
			Me.lblGuide.Top = 5.938013F
			Me.lblGuide.Width = 1F
			Me.lblCostPerGuide1.Height = 0.125F
			Me.lblCostPerGuide1.HyperLink = Nothing
			Me.lblCostPerGuide1.Left = 2.4475F
			Me.lblCostPerGuide1.Name = "lblCostPerGuide1"
			Me.lblCostPerGuide1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide1.Text = "N/A"
			Me.lblCostPerGuide1.Top = 6.385013F
			Me.lblCostPerGuide1.Visible = False
			Me.lblCostPerGuide1.Width = 0.671F
			Me.lblCostPerGuide2.Height = 0.125F
			Me.lblCostPerGuide2.HyperLink = Nothing
			Me.lblCostPerGuide2.Left = 2.447F
			Me.lblCostPerGuide2.Name = "lblCostPerGuide2"
			Me.lblCostPerGuide2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide2.Text = "N/A"
			Me.lblCostPerGuide2.Top = 6.540014F
			Me.lblCostPerGuide2.Visible = False
			Me.lblCostPerGuide2.Width = 0.671F
			Me.lblCostPerGuide3.Height = 0.125F
			Me.lblCostPerGuide3.HyperLink = Nothing
			Me.lblCostPerGuide3.Left = 2.447F
			Me.lblCostPerGuide3.Name = "lblCostPerGuide3"
			Me.lblCostPerGuide3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide3.Text = "N/A"
			Me.lblCostPerGuide3.Top = 6.695013F
			Me.lblCostPerGuide3.Visible = False
			Me.lblCostPerGuide3.Width = 0.671F
			Me.lblCostPerGuide4.Height = 0.125F
			Me.lblCostPerGuide4.HyperLink = Nothing
			Me.lblCostPerGuide4.Left = 2.447F
			Me.lblCostPerGuide4.Name = "lblCostPerGuide4"
			Me.lblCostPerGuide4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide4.Text = "N/A"
			Me.lblCostPerGuide4.Top = 6.850013F
			Me.lblCostPerGuide4.Visible = False
			Me.lblCostPerGuide4.Width = 0.671F
			Me.lblCostPerGuide5.Height = 0.125F
			Me.lblCostPerGuide5.HyperLink = Nothing
			Me.lblCostPerGuide5.Left = 2.447F
			Me.lblCostPerGuide5.Name = "lblCostPerGuide5"
			Me.lblCostPerGuide5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide5.Text = "N/A"
			Me.lblCostPerGuide5.Top = 7.005013F
			Me.lblCostPerGuide5.Visible = False
			Me.lblCostPerGuide5.Width = 0.671F
			Me.lblCostPerGuide6.Height = 0.125F
			Me.lblCostPerGuide6.HyperLink = Nothing
			Me.lblCostPerGuide6.Left = 2.447F
			Me.lblCostPerGuide6.Name = "lblCostPerGuide6"
			Me.lblCostPerGuide6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide6.Text = "N/A"
			Me.lblCostPerGuide6.Top = 7.160012F
			Me.lblCostPerGuide6.Visible = False
			Me.lblCostPerGuide6.Width = 0.671F
			Me.lblCostPerGuide7.Height = 0.125F
			Me.lblCostPerGuide7.HyperLink = Nothing
			Me.lblCostPerGuide7.Left = 2.447F
			Me.lblCostPerGuide7.Name = "lblCostPerGuide7"
			Me.lblCostPerGuide7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide7.Text = "N/A"
			Me.lblCostPerGuide7.Top = 7.325013F
			Me.lblCostPerGuide7.Visible = False
			Me.lblCostPerGuide7.Width = 0.671F
			Me.lblCostPerGuide8.Height = 0.125F
			Me.lblCostPerGuide8.HyperLink = Nothing
			Me.lblCostPerGuide8.Left = 2.447F
			Me.lblCostPerGuide8.Name = "lblCostPerGuide8"
			Me.lblCostPerGuide8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide8.Text = "N/A"
			Me.lblCostPerGuide8.Top = 7.480013F
			Me.lblCostPerGuide8.Visible = False
			Me.lblCostPerGuide8.Width = 0.671F
			Me.lblGuideDollar.Height = 0.1569999F
			Me.lblGuideDollar.HyperLink = Nothing
			Me.lblGuideDollar.Left = 2.4475F
			Me.lblGuideDollar.Name = "lblGuideDollar"
			Me.lblGuideDollar.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblGuideDollar.Text = "($/guide)"
			Me.lblGuideDollar.Top = 6.105014F
			Me.lblGuideDollar.Width = 0.671F
			Me.lblGuideCost.Height = 0.1569999F
			Me.lblGuideCost.HyperLink = Nothing
			Me.lblGuideCost.Left = 2.4475F
			Me.lblGuideCost.Name = "lblGuideCost"
			Me.lblGuideCost.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblGuideCost.Text = "Cost"
			Me.lblGuideCost.Top = 5.938013F
			Me.lblGuideCost.Width = 0.671F
			Me.lblGuidePerRod1.Height = 0.125F
			Me.lblGuidePerRod1.HyperLink = Nothing
			Me.lblGuidePerRod1.Left = 1.5875F
			Me.lblGuidePerRod1.Name = "lblGuidePerRod1"
			Me.lblGuidePerRod1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod1.Text = "N/A"
			Me.lblGuidePerRod1.Top = 6.377014F
			Me.lblGuidePerRod1.Visible = False
			Me.lblGuidePerRod1.Width = 0.713F
			Me.lblGuidePerRod2.Height = 0.125F
			Me.lblGuidePerRod2.HyperLink = Nothing
			Me.lblGuidePerRod2.Left = 1.587F
			Me.lblGuidePerRod2.Name = "lblGuidePerRod2"
			Me.lblGuidePerRod2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod2.Text = "N/A"
			Me.lblGuidePerRod2.Top = 6.532014F
			Me.lblGuidePerRod2.Visible = False
			Me.lblGuidePerRod2.Width = 0.713F
			Me.lblGuidePerRod3.Height = 0.125F
			Me.lblGuidePerRod3.HyperLink = Nothing
			Me.lblGuidePerRod3.Left = 1.587F
			Me.lblGuidePerRod3.Name = "lblGuidePerRod3"
			Me.lblGuidePerRod3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod3.Text = "N/A"
			Me.lblGuidePerRod3.Top = 6.687013F
			Me.lblGuidePerRod3.Visible = False
			Me.lblGuidePerRod3.Width = 0.713F
			Me.lblGuidePerRod4.Height = 0.125F
			Me.lblGuidePerRod4.HyperLink = Nothing
			Me.lblGuidePerRod4.Left = 1.587F
			Me.lblGuidePerRod4.Name = "lblGuidePerRod4"
			Me.lblGuidePerRod4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod4.Text = "N/A"
			Me.lblGuidePerRod4.Top = 6.842013F
			Me.lblGuidePerRod4.Visible = False
			Me.lblGuidePerRod4.Width = 0.713F
			Me.lblGuidePerRod5.Height = 0.125F
			Me.lblGuidePerRod5.HyperLink = Nothing
			Me.lblGuidePerRod5.Left = 1.587F
			Me.lblGuidePerRod5.Name = "lblGuidePerRod5"
			Me.lblGuidePerRod5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod5.Text = "N/A"
			Me.lblGuidePerRod5.Top = 6.997013F
			Me.lblGuidePerRod5.Visible = False
			Me.lblGuidePerRod5.Width = 0.713F
			Me.lblGuidePerRod6.Height = 0.125F
			Me.lblGuidePerRod6.HyperLink = Nothing
			Me.lblGuidePerRod6.Left = 1.587F
			Me.lblGuidePerRod6.Name = "lblGuidePerRod6"
			Me.lblGuidePerRod6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod6.Text = "N/A"
			Me.lblGuidePerRod6.Top = 7.152013F
			Me.lblGuidePerRod6.Visible = False
			Me.lblGuidePerRod6.Width = 0.713F
			Me.lblGuidePerRod7.Height = 0.125F
			Me.lblGuidePerRod7.HyperLink = Nothing
			Me.lblGuidePerRod7.Left = 1.587F
			Me.lblGuidePerRod7.Name = "lblGuidePerRod7"
			Me.lblGuidePerRod7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod7.Text = "N/A"
			Me.lblGuidePerRod7.Top = 7.317012F
			Me.lblGuidePerRod7.Visible = False
			Me.lblGuidePerRod7.Width = 0.713F
			Me.lblGuidePerRod8.Height = 0.125F
			Me.lblGuidePerRod8.HyperLink = Nothing
			Me.lblGuidePerRod8.Left = 1.587F
			Me.lblGuidePerRod8.Name = "lblGuidePerRod8"
			Me.lblGuidePerRod8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod8.Text = "N/A"
			Me.lblGuidePerRod8.Top = 7.47201F
			Me.lblGuidePerRod8.Visible = False
			Me.lblGuidePerRod8.Width = 0.713F
			Me.Label73.Height = 0.1569999F
			Me.Label73.HyperLink = Nothing
			Me.Label73.Left = 1.5875F
			Me.Label73.Name = "Label73"
			Me.Label73.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.Label73.Text = ""
			Me.Label73.Top = 6.095013F
			Me.Label73.Width = 0.713F
			Me.lblNumGuides.Height = 0.1569999F
			Me.lblNumGuides.HyperLink = Nothing
			Me.lblNumGuides.Left = 1.5875F
			Me.lblNumGuides.Name = "lblNumGuides"
			Me.lblNumGuides.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblNumGuides.Text = "# Guides"
			Me.lblNumGuides.Top = 5.930014F
			Me.lblNumGuides.Width = 0.713F
			Me.Line9.Height = 1.772F
			Me.Line9.Left = 1.496556F
			Me.Line9.LineWeight = 1F
			Me.Line9.Name = "Line9"
			Me.Line9.Top = 5.898013F
			Me.Line9.Width = 0F
			Me.Line9.X1 = 1.496556F
			Me.Line9.X2 = 1.496556F
			Me.Line9.Y1 = 5.898013F
			Me.Line9.Y2 = 7.670013F
			Me.Line10.Height = 1.772F
			Me.Line10.Left = 2.3665F
			Me.Line10.LineWeight = 1F
			Me.Line10.Name = "Line10"
			Me.Line10.Top = 5.898013F
			Me.Line10.Width = 0F
			Me.Line10.X1 = 2.3665F
			Me.Line10.X2 = 2.3665F
			Me.Line10.Y1 = 5.898013F
			Me.Line10.Y2 = 7.670013F
			Me.Line17.Height = 1.772F
			Me.Line17.Left = 3.1775F
			Me.Line17.LineWeight = 1F
			Me.Line17.Name = "Line17"
			Me.Line17.Top = 5.898013F
			Me.Line17.Width = 0F
			Me.Line17.X1 = 3.1775F
			Me.Line17.X2 = 3.1775F
			Me.Line17.Y1 = 5.898013F
			Me.Line17.Y2 = 7.670013F
			Me.lblCost18.Height = 0.1255F
			Me.lblCost18.HyperLink = Nothing
			Me.lblCost18.Left = 2.819F
			Me.lblCost18.Name = "lblCost18"
			Me.lblCost18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost18.Text = "N/A"
			Me.lblCost18.Top = 4.048F
			Me.lblCost18.Visible = False
			Me.lblCost18.Width = 1F
			Me.lblCost20.Height = 0.1255F
			Me.lblCost20.HyperLink = Nothing
			Me.lblCost20.Left = 2.819F
			Me.lblCost20.Name = "lblCost20"
			Me.lblCost20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost20.Text = "N/A"
			Me.lblCost20.Top = 4.307998F
			Me.lblCost20.Visible = False
			Me.lblCost20.Width = 1F
			Me.lblCost19.Height = 0.1255F
			Me.lblCost19.HyperLink = Nothing
			Me.lblCost19.Left = 2.819F
			Me.lblCost19.Name = "lblCost19"
			Me.lblCost19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost19.Text = "N/A"
			Me.lblCost19.Top = 4.172998F
			Me.lblCost19.Visible = False
			Me.lblCost19.Width = 1F
			Me.lblCost17.Height = 0.1255F
			Me.lblCost17.HyperLink = Nothing
			Me.lblCost17.Left = 2.819F
			Me.lblCost17.Name = "lblCost17"
			Me.lblCost17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost17.Text = "N/A"
			Me.lblCost17.Top = 3.913F
			Me.lblCost17.Visible = False
			Me.lblCost17.Width = 1F
			Me.lblRodDiam11.Height = 0.125F
			Me.lblRodDiam11.HyperLink = Nothing
			Me.lblRodDiam11.Left = 0.389057F
			Me.lblRodDiam11.Name = "lblRodDiam11"
			Me.lblRodDiam11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam11.Text = "Diam"
			Me.lblRodDiam11.Top = 3.123F
			Me.lblRodDiam11.Visible = False
			Me.lblRodDiam11.Width = 0.6875F
			Me.lblRodDiam12.Height = 0.125F
			Me.lblRodDiam12.HyperLink = Nothing
			Me.lblRodDiam12.Left = 0.3880006F
			Me.lblRodDiam12.Name = "lblRodDiam12"
			Me.lblRodDiam12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam12.Text = "Diam"
			Me.lblRodDiam12.Top = 3.258001F
			Me.lblRodDiam12.Visible = False
			Me.lblRodDiam12.Width = 0.6875F
			Me.lblRodDiam13.Height = 0.1255F
			Me.lblRodDiam13.HyperLink = Nothing
			Me.lblRodDiam13.Left = 0.3884454F
			Me.lblRodDiam13.Name = "lblRodDiam13"
			Me.lblRodDiam13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam13.Text = "Diam"
			Me.lblRodDiam13.Top = 3.393F
			Me.lblRodDiam13.Visible = False
			Me.lblRodDiam13.Width = 0.6875F
			Me.lblRodDiam14.Height = 0.1255F
			Me.lblRodDiam14.HyperLink = Nothing
			Me.lblRodDiam14.Left = 0.3884454F
			Me.lblRodDiam14.Name = "lblRodDiam14"
			Me.lblRodDiam14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam14.Text = "Diam"
			Me.lblRodDiam14.Top = 3.528001F
			Me.lblRodDiam14.Visible = False
			Me.lblRodDiam14.Width = 0.6875F
			Me.lblRodDiam15.Height = 0.1255F
			Me.lblRodDiam15.HyperLink = Nothing
			Me.lblRodDiam15.Left = 0.3884454F
			Me.lblRodDiam15.Name = "lblRodDiam15"
			Me.lblRodDiam15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam15.Text = "Diam"
			Me.lblRodDiam15.Top = 3.653001F
			Me.lblRodDiam15.Visible = False
			Me.lblRodDiam15.Width = 0.6875F
			Me.lblRodDiam16.Height = 0.1255F
			Me.lblRodDiam16.HyperLink = Nothing
			Me.lblRodDiam16.Left = 0.3880007F
			Me.lblRodDiam16.Name = "lblRodDiam16"
			Me.lblRodDiam16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam16.Text = "Diam"
			Me.lblRodDiam16.Top = 3.788001F
			Me.lblRodDiam16.Visible = False
			Me.lblRodDiam16.Width = 0.6875F
			Me.lblRodDiam17.Height = 0.1255F
			Me.lblRodDiam17.HyperLink = Nothing
			Me.lblRodDiam17.Left = 0.3884454F
			Me.lblRodDiam17.Name = "lblRodDiam17"
			Me.lblRodDiam17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam17.Text = "Diam"
			Me.lblRodDiam17.Top = 3.913001F
			Me.lblRodDiam17.Visible = False
			Me.lblRodDiam17.Width = 0.6875F
			Me.lblRodDiam18.Height = 0.1255F
			Me.lblRodDiam18.HyperLink = Nothing
			Me.lblRodDiam18.Left = 0.3884454F
			Me.lblRodDiam18.Name = "lblRodDiam18"
			Me.lblRodDiam18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam18.Text = "Diam"
			Me.lblRodDiam18.Top = 4.048F
			Me.lblRodDiam18.Visible = False
			Me.lblRodDiam18.Width = 0.6875F
			Me.lblRodGrade11.Height = 0.125F
			Me.lblRodGrade11.HyperLink = Nothing
			Me.lblRodGrade11.Left = 1.2015F
			Me.lblRodGrade11.Name = "lblRodGrade11"
			Me.lblRodGrade11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade11.Text = "Grade"
			Me.lblRodGrade11.Top = 3.123F
			Me.lblRodGrade11.Visible = False
			Me.lblRodGrade11.Width = 0.875F
			Me.lblRodGrade12.Height = 0.125F
			Me.lblRodGrade12.HyperLink = Nothing
			Me.lblRodGrade12.Left = 1.200944F
			Me.lblRodGrade12.Name = "lblRodGrade12"
			Me.lblRodGrade12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade12.Text = "Grade"
			Me.lblRodGrade12.Top = 3.258001F
			Me.lblRodGrade12.Visible = False
			Me.lblRodGrade12.Width = 0.875F
			Me.lblRodGrade13.Height = 0.1255F
			Me.lblRodGrade13.HyperLink = Nothing
			Me.lblRodGrade13.Left = 1.200944F
			Me.lblRodGrade13.Name = "lblRodGrade13"
			Me.lblRodGrade13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade13.Text = "Grade"
			Me.lblRodGrade13.Top = 3.393F
			Me.lblRodGrade13.Visible = False
			Me.lblRodGrade13.Width = 0.875F
			Me.lblRodGrade14.Height = 0.1255F
			Me.lblRodGrade14.HyperLink = Nothing
			Me.lblRodGrade14.Left = 1.200944F
			Me.lblRodGrade14.Name = "lblRodGrade14"
			Me.lblRodGrade14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade14.Text = "Grade"
			Me.lblRodGrade14.Top = 3.528001F
			Me.lblRodGrade14.Visible = False
			Me.lblRodGrade14.Width = 0.875F
			Me.lblRodGrade15.Height = 0.1255F
			Me.lblRodGrade15.HyperLink = Nothing
			Me.lblRodGrade15.Left = 1.200944F
			Me.lblRodGrade15.Name = "lblRodGrade15"
			Me.lblRodGrade15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade15.Text = "Grade"
			Me.lblRodGrade15.Top = 3.653001F
			Me.lblRodGrade15.Visible = False
			Me.lblRodGrade15.Width = 0.875F
			Me.lblRodGrade16.Height = 0.1255F
			Me.lblRodGrade16.HyperLink = Nothing
			Me.lblRodGrade16.Left = 1.201F
			Me.lblRodGrade16.Name = "lblRodGrade16"
			Me.lblRodGrade16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade16.Text = "Grade"
			Me.lblRodGrade16.Top = 3.788001F
			Me.lblRodGrade16.Visible = False
			Me.lblRodGrade16.Width = 0.875F
			Me.lblRodGrade17.Height = 0.1255F
			Me.lblRodGrade17.HyperLink = Nothing
			Me.lblRodGrade17.Left = 1.200944F
			Me.lblRodGrade17.Name = "lblRodGrade17"
			Me.lblRodGrade17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade17.Text = "Grade"
			Me.lblRodGrade17.Top = 3.913001F
			Me.lblRodGrade17.Visible = False
			Me.lblRodGrade17.Width = 0.875F
			Me.lblRodGrade18.Height = 0.1255F
			Me.lblRodGrade18.HyperLink = Nothing
			Me.lblRodGrade18.Left = 1.200944F
			Me.lblRodGrade18.Name = "lblRodGrade18"
			Me.lblRodGrade18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade18.Text = "Grade"
			Me.lblRodGrade18.Top = 4.048F
			Me.lblRodGrade18.Visible = False
			Me.lblRodGrade18.Width = 0.875F
			Me.lblRodLength11.Height = 0.125F
			Me.lblRodLength11.HyperLink = Nothing
			Me.lblRodLength11.Left = 2.2015F
			Me.lblRodLength11.Name = "lblRodLength11"
			Me.lblRodLength11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength11.Text = "Len"
			Me.lblRodLength11.Top = 3.123F
			Me.lblRodLength11.Visible = False
			Me.lblRodLength11.Width = 0.4930553F
			Me.lblRodLength12.Height = 0.125F
			Me.lblRodLength12.HyperLink = Nothing
			Me.lblRodLength12.Left = 2.200944F
			Me.lblRodLength12.Name = "lblRodLength12"
			Me.lblRodLength12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength12.Text = "Len"
			Me.lblRodLength12.Top = 3.258001F
			Me.lblRodLength12.Visible = False
			Me.lblRodLength12.Width = 0.4930553F
			Me.lblRodLength13.Height = 0.1255F
			Me.lblRodLength13.HyperLink = Nothing
			Me.lblRodLength13.Left = 2.200944F
			Me.lblRodLength13.Name = "lblRodLength13"
			Me.lblRodLength13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength13.Text = "Len"
			Me.lblRodLength13.Top = 3.393F
			Me.lblRodLength13.Visible = False
			Me.lblRodLength13.Width = 0.4930553F
			Me.lblRodLength14.Height = 0.1255F
			Me.lblRodLength14.HyperLink = Nothing
			Me.lblRodLength14.Left = 2.200944F
			Me.lblRodLength14.Name = "lblRodLength14"
			Me.lblRodLength14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength14.Text = "Len"
			Me.lblRodLength14.Top = 3.528001F
			Me.lblRodLength14.Visible = False
			Me.lblRodLength14.Width = 0.4930553F
			Me.lblRodLength15.Height = 0.1255F
			Me.lblRodLength15.HyperLink = Nothing
			Me.lblRodLength15.Left = 2.200944F
			Me.lblRodLength15.Name = "lblRodLength15"
			Me.lblRodLength15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength15.Text = "Len"
			Me.lblRodLength15.Top = 3.653001F
			Me.lblRodLength15.Visible = False
			Me.lblRodLength15.Width = 0.4930553F
			Me.lblRodLength16.Height = 0.1255F
			Me.lblRodLength16.HyperLink = Nothing
			Me.lblRodLength16.Left = 2.201001F
			Me.lblRodLength16.Name = "lblRodLength16"
			Me.lblRodLength16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength16.Text = "Len"
			Me.lblRodLength16.Top = 3.788001F
			Me.lblRodLength16.Visible = False
			Me.lblRodLength16.Width = 0.4930553F
			Me.lblRodLength17.Height = 0.1255F
			Me.lblRodLength17.HyperLink = Nothing
			Me.lblRodLength17.Left = 2.201001F
			Me.lblRodLength17.Name = "lblRodLength17"
			Me.lblRodLength17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength17.Text = "Len"
			Me.lblRodLength17.Top = 3.913F
			Me.lblRodLength17.Visible = False
			Me.lblRodLength17.Width = 0.4930553F
			Me.lblRodLength18.Height = 0.1255F
			Me.lblRodLength18.HyperLink = Nothing
			Me.lblRodLength18.Left = 2.200944F
			Me.lblRodLength18.Name = "lblRodLength18"
			Me.lblRodLength18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength18.Text = "Len"
			Me.lblRodLength18.Top = 4.048F
			Me.lblRodLength18.Visible = False
			Me.lblRodLength18.Width = 0.4930553F
			Me.lblTotalCost11.Height = 0.125F
			Me.lblTotalCost11.HyperLink = Nothing
			Me.lblTotalCost11.Left = 3.937556F
			Me.lblTotalCost11.Name = "lblTotalCost11"
			Me.lblTotalCost11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost11.Text = "N/A"
			Me.lblTotalCost11.Top = 3.133F
			Me.lblTotalCost11.Visible = False
			Me.lblTotalCost11.Width = 1F
			Me.lblTotalCost12.Height = 0.125F
			Me.lblTotalCost12.HyperLink = Nothing
			Me.lblTotalCost12.Left = 3.9375F
			Me.lblTotalCost12.Name = "lblTotalCost12"
			Me.lblTotalCost12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost12.Text = "N/A"
			Me.lblTotalCost12.Top = 3.268F
			Me.lblTotalCost12.Visible = False
			Me.lblTotalCost12.Width = 1F
			Me.lblTotalCost13.Height = 0.1255F
			Me.lblTotalCost13.HyperLink = Nothing
			Me.lblTotalCost13.Left = 3.9375F
			Me.lblTotalCost13.Name = "lblTotalCost13"
			Me.lblTotalCost13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost13.Text = "N/A"
			Me.lblTotalCost13.Top = 3.402999F
			Me.lblTotalCost13.Visible = False
			Me.lblTotalCost13.Width = 1F
			Me.lblTotalCost14.Height = 0.1255F
			Me.lblTotalCost14.HyperLink = Nothing
			Me.lblTotalCost14.Left = 3.9375F
			Me.lblTotalCost14.Name = "lblTotalCost14"
			Me.lblTotalCost14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost14.Text = "N/A"
			Me.lblTotalCost14.Top = 3.538F
			Me.lblTotalCost14.Visible = False
			Me.lblTotalCost14.Width = 1F
			Me.lblTotalCost15.Height = 0.1255F
			Me.lblTotalCost15.HyperLink = Nothing
			Me.lblTotalCost15.Left = 3.9375F
			Me.lblTotalCost15.Name = "lblTotalCost15"
			Me.lblTotalCost15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost15.Text = "N/A"
			Me.lblTotalCost15.Top = 3.663F
			Me.lblTotalCost15.Visible = False
			Me.lblTotalCost15.Width = 1F
			Me.lblTotalCost16.Height = 0.1255F
			Me.lblTotalCost16.HyperLink = Nothing
			Me.lblTotalCost16.Left = 3.9375F
			Me.lblTotalCost16.Name = "lblTotalCost16"
			Me.lblTotalCost16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost16.Text = "N/A"
			Me.lblTotalCost16.Top = 3.787999F
			Me.lblTotalCost16.Visible = False
			Me.lblTotalCost16.Width = 1F
			Me.lblTotalCost17.Height = 0.1255F
			Me.lblTotalCost17.HyperLink = Nothing
			Me.lblTotalCost17.Left = 3.9375F
			Me.lblTotalCost17.Name = "lblTotalCost17"
			Me.lblTotalCost17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost17.Text = "N/A"
			Me.lblTotalCost17.Top = 3.923F
			Me.lblTotalCost17.Visible = False
			Me.lblTotalCost17.Width = 1F
			Me.lblTotalCost18.Height = 0.1255F
			Me.lblTotalCost18.HyperLink = Nothing
			Me.lblTotalCost18.Left = 3.9375F
			Me.lblTotalCost18.Name = "lblTotalCost18"
			Me.lblTotalCost18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost18.Text = "N/A"
			Me.lblTotalCost18.Top = 4.048F
			Me.lblTotalCost18.Visible = False
			Me.lblTotalCost18.Width = 1F
			Me.lblCost11.Height = 0.125F
			Me.lblCost11.HyperLink = Nothing
			Me.lblCost11.Left = 2.819556F
			Me.lblCost11.Name = "lblCost11"
			Me.lblCost11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost11.Text = "N/A"
			Me.lblCost11.Top = 3.123F
			Me.lblCost11.Visible = False
			Me.lblCost11.Width = 1F
			Me.lblCost12.Height = 0.125F
			Me.lblCost12.HyperLink = Nothing
			Me.lblCost12.Left = 2.819F
			Me.lblCost12.Name = "lblCost12"
			Me.lblCost12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost12.Text = "N/A"
			Me.lblCost12.Top = 3.258001F
			Me.lblCost12.Visible = False
			Me.lblCost12.Width = 1F
			Me.lblCost13.Height = 0.1255F
			Me.lblCost13.HyperLink = Nothing
			Me.lblCost13.Left = 2.819F
			Me.lblCost13.Name = "lblCost13"
			Me.lblCost13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost13.Text = "N/A"
			Me.lblCost13.Top = 3.392999F
			Me.lblCost13.Visible = False
			Me.lblCost13.Width = 1F
			Me.lblCost14.Height = 0.1255F
			Me.lblCost14.HyperLink = Nothing
			Me.lblCost14.Left = 2.819F
			Me.lblCost14.Name = "lblCost14"
			Me.lblCost14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost14.Text = "N/A"
			Me.lblCost14.Top = 3.528F
			Me.lblCost14.Visible = False
			Me.lblCost14.Width = 1F
			Me.lblCost15.Height = 0.1255F
			Me.lblCost15.HyperLink = Nothing
			Me.lblCost15.Left = 2.819F
			Me.lblCost15.Name = "lblCost15"
			Me.lblCost15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost15.Text = "N/A"
			Me.lblCost15.Top = 3.653F
			Me.lblCost15.Visible = False
			Me.lblCost15.Width = 1F
			Me.lblCost16.Height = 0.1255F
			Me.lblCost16.HyperLink = Nothing
			Me.lblCost16.Left = 2.819F
			Me.lblCost16.Name = "lblCost16"
			Me.lblCost16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost16.Text = "N/A"
			Me.lblCost16.Top = 3.788001F
			Me.lblCost16.Visible = False
			Me.lblCost16.Width = 1F
			Me.lblRodDiam19.Height = 0.1255F
			Me.lblRodDiam19.HyperLink = Nothing
			Me.lblRodDiam19.Left = 0.3884454F
			Me.lblRodDiam19.Name = "lblRodDiam19"
			Me.lblRodDiam19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam19.Text = "Diam"
			Me.lblRodDiam19.Top = 4.172998F
			Me.lblRodDiam19.Visible = False
			Me.lblRodDiam19.Width = 0.6875F
			Me.lblRodGrade19.Height = 0.1255F
			Me.lblRodGrade19.HyperLink = Nothing
			Me.lblRodGrade19.Left = 1.200944F
			Me.lblRodGrade19.Name = "lblRodGrade19"
			Me.lblRodGrade19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade19.Text = "Grade"
			Me.lblRodGrade19.Top = 4.172998F
			Me.lblRodGrade19.Visible = False
			Me.lblRodGrade19.Width = 0.875F
			Me.lblRodLength19.Height = 0.1255F
			Me.lblRodLength19.HyperLink = Nothing
			Me.lblRodLength19.Left = 2.200944F
			Me.lblRodLength19.Name = "lblRodLength19"
			Me.lblRodLength19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength19.Text = "Len"
			Me.lblRodLength19.Top = 4.172998F
			Me.lblRodLength19.Visible = False
			Me.lblRodLength19.Width = 0.4930553F
			Me.lblTotalCost19.Height = 0.1255F
			Me.lblTotalCost19.HyperLink = Nothing
			Me.lblTotalCost19.Left = 3.9375F
			Me.lblTotalCost19.Name = "lblTotalCost19"
			Me.lblTotalCost19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost19.Text = "N/A"
			Me.lblTotalCost19.Top = 4.172998F
			Me.lblTotalCost19.Visible = False
			Me.lblTotalCost19.Width = 1F
			Me.lblRodDiam20.Height = 0.1255F
			Me.lblRodDiam20.HyperLink = Nothing
			Me.lblRodDiam20.Left = 0.3884454F
			Me.lblRodDiam20.Name = "lblRodDiam20"
			Me.lblRodDiam20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam20.Text = "Diam"
			Me.lblRodDiam20.Top = 4.307998F
			Me.lblRodDiam20.Visible = False
			Me.lblRodDiam20.Width = 0.6875F
			Me.lblRodGrade20.Height = 0.1255F
			Me.lblRodGrade20.HyperLink = Nothing
			Me.lblRodGrade20.Left = 1.200944F
			Me.lblRodGrade20.Name = "lblRodGrade20"
			Me.lblRodGrade20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade20.Text = "Grade"
			Me.lblRodGrade20.Top = 4.307998F
			Me.lblRodGrade20.Visible = False
			Me.lblRodGrade20.Width = 0.875F
			Me.lblRodLength20.Height = 0.1255F
			Me.lblRodLength20.HyperLink = Nothing
			Me.lblRodLength20.Left = 2.200944F
			Me.lblRodLength20.Name = "lblRodLength20"
			Me.lblRodLength20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength20.Text = "Len"
			Me.lblRodLength20.Top = 4.307998F
			Me.lblRodLength20.Visible = False
			Me.lblRodLength20.Width = 0.4930553F
			Me.lblTotalCost20.Height = 0.1255F
			Me.lblTotalCost20.HyperLink = Nothing
			Me.lblTotalCost20.Left = 3.9375F
			Me.lblTotalCost20.Name = "lblTotalCost20"
			Me.lblTotalCost20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost20.Text = "N/A"
			Me.lblTotalCost20.Top = 4.307998F
			Me.lblTotalCost20.Visible = False
			Me.lblTotalCost20.Width = 1F
			Me.PageFooter.Height = 0.04166667F
			Me.PageFooter.Name = "PageFooter"
			Me.MasterReport = False
			Me.PageSettings.Margins.Bottom = 0F
			Me.PageSettings.Margins.Right = 0F
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
			CType(Me.lblTitle1, ISupportInitialize).EndInit()
			CType(Me.lblCost8, ISupportInitialize).EndInit()
			CType(Me.lblCost10, ISupportInitialize).EndInit()
			CType(Me.lblCost9, ISupportInitialize).EndInit()
			CType(Me.lblCost7, ISupportInitialize).EndInit()
			CType(Me.lblRodStringDesign, ISupportInitialize).EndInit()
			CType(Me.lblRodDiamHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodDiamHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam1, ISupportInitialize).EndInit()
			CType(Me.lblRodGradeHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodGradeHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodLengthHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodLengthHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam2, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam3, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam4, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam5, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam6, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam7, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam8, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade1, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade2, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade3, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade4, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade5, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade6, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade7, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade8, ISupportInitialize).EndInit()
			CType(Me.lblRodLength1, ISupportInitialize).EndInit()
			CType(Me.lblRodLength2, ISupportInitialize).EndInit()
			CType(Me.lblRodLength3, ISupportInitialize).EndInit()
			CType(Me.lblRodLength4, ISupportInitialize).EndInit()
			CType(Me.lblRodLength5, ISupportInitialize).EndInit()
			CType(Me.lblRodLength6, ISupportInitialize).EndInit()
			CType(Me.lblRodLength7, ISupportInitialize).EndInit()
			CType(Me.lblRodLength8, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost1, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost2, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost3, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost4, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost5, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost6, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost7, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost8, ISupportInitialize).EndInit()
			CType(Me.Label9, ISupportInitialize).EndInit()
			CType(Me.Label10, ISupportInitialize).EndInit()
			CType(Me.lblTotalRSCost2, ISupportInitialize).EndInit()
			CType(Me.lblPumpingUnitDesign, ISupportInitialize).EndInit()
			CType(Me.lblTotalPUCost2, ISupportInitialize).EndInit()
			CType(Me.lblTotalPUCost, ISupportInitialize).EndInit()
			CType(Me.lblManufacturer, ISupportInitialize).EndInit()
			CType(Me.lblAPISize, ISupportInitialize).EndInit()
			CType(Me.lblUnitName, ISupportInitialize).EndInit()
			CType(Me.lblCost1, ISupportInitialize).EndInit()
			CType(Me.lblCost2, ISupportInitialize).EndInit()
			CType(Me.lblCost3, ISupportInitialize).EndInit()
			CType(Me.lblCost4, ISupportInitialize).EndInit()
			CType(Me.lblCost5, ISupportInitialize).EndInit()
			CType(Me.lblCost6, ISupportInitialize).EndInit()
			CType(Me.Label23, ISupportInitialize).EndInit()
			CType(Me.lblCostHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblTotalRSCost, ISupportInitialize).EndInit()
			CType(Me.lblAddCosts, ISupportInitialize).EndInit()
			CType(Me.lblAddCosts2, ISupportInitialize).EndInit()
			CType(Me.lblComment, ISupportInitialize).EndInit()
			CType(Me.lblPage, ISupportInitialize).EndInit()
			CType(Me.txtPage1, ISupportInitialize).EndInit()
			CType(Me.lblOf, ISupportInitialize).EndInit()
			CType(Me.txtPage2, ISupportInitialize).EndInit()
			CType(Me.lblUserName, ISupportInitialize).EndInit()
			CType(Me.lblUserDate, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam9, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade9, ISupportInitialize).EndInit()
			CType(Me.lblRodLength9, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost9, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam10, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade10, ISupportInitialize).EndInit()
			CType(Me.lblRodLength10, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost10, ISupportInitialize).EndInit()
			CType(Me.lblLabel2, ISupportInitialize).EndInit()
			CType(Me.lblCompany, ISupportInitialize).EndInit()
			CType(Me.lblWellName, ISupportInitialize).EndInit()
			CType(Me.lblDiskFile, ISupportInitialize).EndInit()
			CType(Me.lblSecondCompanyName, ISupportInitialize).EndInit()
			CType(Me.lblSecondCompanyPhonenumber, ISupportInitialize).EndInit()
			CType(Me.lblGoTheta, ISupportInitialize).EndInit()
			CType(Me.lblGuideCostAnalysis, ISupportInitialize).EndInit()
			CType(Me.lblGuideTotalCost1, ISupportInitialize).EndInit()
			CType(Me.lblGuideTotalCost2, ISupportInitialize).EndInit()
			CType(Me.lblGuideTotalCost3, ISupportInitialize).EndInit()
			CType(Me.lblGuideTotalCost4, ISupportInitialize).EndInit()
			CType(Me.lblGuideTotalCost5, ISupportInitialize).EndInit()
			CType(Me.lblGuideTotalCost6, ISupportInitialize).EndInit()
			CType(Me.lblGuideTotalCost7, ISupportInitialize).EndInit()
			CType(Me.lblGuideTotalCost8, ISupportInitialize).EndInit()
			CType(Me.lblTotalCostGuide, ISupportInitialize).EndInit()
			CType(Me.lblTotalGuideCostDollar, ISupportInitialize).EndInit()
			CType(Me.lblGuideTotalCost, ISupportInitialize).EndInit()
			CType(Me.lblTotalGuide, ISupportInitialize).EndInit()
			CType(Me.lblGuide1, ISupportInitialize).EndInit()
			CType(Me.lblGuide2, ISupportInitialize).EndInit()
			CType(Me.lblGuide3, ISupportInitialize).EndInit()
			CType(Me.lblGuide4, ISupportInitialize).EndInit()
			CType(Me.lblGuide5, ISupportInitialize).EndInit()
			CType(Me.lblGuide6, ISupportInitialize).EndInit()
			CType(Me.lblGuide7, ISupportInitialize).EndInit()
			CType(Me.lblGuide8, ISupportInitialize).EndInit()
			CType(Me.lblType, ISupportInitialize).EndInit()
			CType(Me.lblGuide, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide1, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide2, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide3, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide4, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide5, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide6, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide7, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide8, ISupportInitialize).EndInit()
			CType(Me.lblGuideDollar, ISupportInitialize).EndInit()
			CType(Me.lblGuideCost, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod1, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod2, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod3, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod4, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod5, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod6, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod7, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod8, ISupportInitialize).EndInit()
			CType(Me.Label73, ISupportInitialize).EndInit()
			CType(Me.lblNumGuides, ISupportInitialize).EndInit()
			CType(Me.lblCost18, ISupportInitialize).EndInit()
			CType(Me.lblCost20, ISupportInitialize).EndInit()
			CType(Me.lblCost19, ISupportInitialize).EndInit()
			CType(Me.lblCost17, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam11, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam12, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam13, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam14, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam15, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam16, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam17, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam18, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade11, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade12, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade13, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade14, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade15, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade16, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade17, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade18, ISupportInitialize).EndInit()
			CType(Me.lblRodLength11, ISupportInitialize).EndInit()
			CType(Me.lblRodLength12, ISupportInitialize).EndInit()
			CType(Me.lblRodLength13, ISupportInitialize).EndInit()
			CType(Me.lblRodLength14, ISupportInitialize).EndInit()
			CType(Me.lblRodLength15, ISupportInitialize).EndInit()
			CType(Me.lblRodLength16, ISupportInitialize).EndInit()
			CType(Me.lblRodLength17, ISupportInitialize).EndInit()
			CType(Me.lblRodLength18, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost11, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost12, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost13, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost14, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost15, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost16, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost17, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost18, ISupportInitialize).EndInit()
			CType(Me.lblCost11, ISupportInitialize).EndInit()
			CType(Me.lblCost12, ISupportInitialize).EndInit()
			CType(Me.lblCost13, ISupportInitialize).EndInit()
			CType(Me.lblCost14, ISupportInitialize).EndInit()
			CType(Me.lblCost15, ISupportInitialize).EndInit()
			CType(Me.lblCost16, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam19, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade19, ISupportInitialize).EndInit()
			CType(Me.lblRodLength19, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost19, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam20, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade20, ISupportInitialize).EndInit()
			CType(Me.lblRodLength20, ISupportInitialize).EndInit()
			CType(Me.lblTotalCost20, ISupportInitialize).EndInit()
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		Private Sub ReadReportControlStrings()
			Dim sPrefix As String = "rptCostAnalysis-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
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
			Me.lblTitle1.Text = Me.lblTitle1.Text.Replace("1.0", RSWIN_DESC.VersionMajor.ToString() + "." + RSWIN_DESC.VersionMinor.ToString())
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

		Private Sub PageHeader_Format(sender As Object, e As EventArgs)
		End Sub

		Public Function HasGuides() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim num As Integer = 1
				Do
					RSWIN_DESC.bGuideSums(num) = False
					RSWIN_DESC.iGuides(num) = 0
					num += 1
				Loop While num <= 11
				If RSWIN_DESC.iSumMOLDED = 0 And RSWIN_DESC.iSumWHEELED = 0 And RSWIN_DESC.iSumOther = 0 And RSWIN_DESC.iSumNorrisStandard = 0 And RSWIN_DESC.iSumNorrisSidewinder = 0 And RSWIN_DESC.iSumRGIJakeCoupling = 0 And RSWIN_DESC.iSumRGISVT = 0 And RSWIN_DESC.iSumRGITomahawk = 0 And RSWIN_DESC.iSumRGITornado = 0 And RSWIN_DESC.iSumRGITwister = 0 And RSWIN_DESC.iSumRGIWVT = 0 Then
					result = False
				Else
					If RSWIN_DESC.iSumMOLDED <> 0 Then
						RSWIN_DESC.bGuideSums(1) = True
						RSWIN_DESC.iGuides(1) = CInt(RSWIN_DESC.MOLDED)
					End If
					If RSWIN_DESC.iSumWHEELED <> 0 Then
						RSWIN_DESC.bGuideSums(2) = True
						RSWIN_DESC.iGuides(2) = 2
					End If
					If RSWIN_DESC.iSumOther <> 0 Then
						RSWIN_DESC.bGuideSums(3) = True
						RSWIN_DESC.iGuides(3) = 3
					End If
					If RSWIN_DESC.iSumNorrisStandard <> 0 Then
						RSWIN_DESC.bGuideSums(4) = True
						RSWIN_DESC.iGuides(4) = 4
					End If
					If RSWIN_DESC.iSumNorrisSidewinder <> 0 Then
						RSWIN_DESC.bGuideSums(5) = True
						RSWIN_DESC.iGuides(5) = CInt(RSWIN_DESC.NorrisSidewinderGuide)
					End If
					If RSWIN_DESC.iSumRGIJakeCoupling <> 0 Then
						RSWIN_DESC.bGuideSums(6) = True
						RSWIN_DESC.iGuides(6) = 6
					End If
					If RSWIN_DESC.iSumRGISVT <> 0 Then
						RSWIN_DESC.bGuideSums(7) = True
						RSWIN_DESC.iGuides(7) = 7
					End If
					If RSWIN_DESC.iSumRGITomahawk <> 0 Then
						RSWIN_DESC.bGuideSums(8) = True
						RSWIN_DESC.iGuides(8) = 8
					End If
					If RSWIN_DESC.iSumRGITornado <> 0 Then
						RSWIN_DESC.bGuideSums(9) = True
						RSWIN_DESC.iGuides(9) = 9
					End If
					If RSWIN_DESC.iSumRGITwister <> 0 Then
						RSWIN_DESC.bGuideSums(10) = True
						RSWIN_DESC.iGuides(10) = 10
					End If
					If RSWIN_DESC.iSumRGIWVT <> 0 Then
						RSWIN_DESC.bGuideSums(11) = True
						RSWIN_DESC.iGuides(11) = 11
					End If
					result = True
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub SetGuideLabels(I As Integer, G As String, N As Integer, C As String, T As String)
			Try
				Select Case I
					Case 1
						Me.lblGuide1.Visible = True
						Me.lblGuidePerRod1.Visible = True
						Me.lblCostPerGuide1.Visible = True
						Me.lblGuideTotalCost1.Visible = True
						Me.lblGuide1.Text = G
						Me.lblGuidePerRod1.Text = Conversions.ToString(N)
						Me.lblCostPerGuide1.Text = C
						Me.lblGuideTotalCost1.Text = T
					Case 2
						Me.lblGuide2.Visible = True
						Me.lblGuidePerRod2.Visible = True
						Me.lblCostPerGuide2.Visible = True
						Me.lblGuideTotalCost2.Visible = True
						Me.lblGuide2.Text = G
						Me.lblGuidePerRod2.Text = Conversions.ToString(N)
						Me.lblCostPerGuide2.Text = C
						Me.lblGuideTotalCost2.Text = T
					Case 3
						Me.lblGuide3.Visible = True
						Me.lblGuidePerRod3.Visible = True
						Me.lblCostPerGuide3.Visible = True
						Me.lblGuideTotalCost3.Visible = True
						Me.lblGuide3.Text = G
						Me.lblGuidePerRod3.Text = Conversions.ToString(N)
						Me.lblCostPerGuide3.Text = C
						Me.lblGuideTotalCost3.Text = T
					Case 4
						Me.lblGuide4.Visible = True
						Me.lblGuidePerRod4.Visible = True
						Me.lblCostPerGuide4.Visible = True
						Me.lblGuideTotalCost4.Visible = True
						Me.lblGuide4.Text = G
						Me.lblGuidePerRod4.Text = Conversions.ToString(N)
						Me.lblCostPerGuide4.Text = C
						Me.lblGuideTotalCost4.Text = T
					Case 5
						Me.lblGuide5.Visible = True
						Me.lblGuidePerRod5.Visible = True
						Me.lblCostPerGuide5.Visible = True
						Me.lblGuideTotalCost5.Visible = True
						Me.lblGuide5.Text = G
						Me.lblGuidePerRod5.Text = Conversions.ToString(N)
						Me.lblCostPerGuide5.Text = C
						Me.lblGuideTotalCost5.Text = T
					Case 6
						Me.lblGuide6.Visible = True
						Me.lblGuidePerRod6.Visible = True
						Me.lblCostPerGuide6.Visible = True
						Me.lblGuideTotalCost6.Visible = True
						Me.lblGuide6.Text = G
						Me.lblGuidePerRod6.Text = Conversions.ToString(N)
						Me.lblCostPerGuide6.Text = C
						Me.lblGuideTotalCost6.Text = T
					Case 7
						Me.lblGuide7.Visible = True
						Me.lblGuidePerRod7.Visible = True
						Me.lblCostPerGuide7.Visible = True
						Me.lblGuideTotalCost7.Visible = True
						Me.lblGuide7.Text = G
						Me.lblGuidePerRod7.Text = Conversions.ToString(N)
						Me.lblCostPerGuide7.Text = C
						Me.lblGuideTotalCost7.Text = T
					Case 8
						Me.lblGuide8.Visible = True
						Me.lblGuidePerRod8.Visible = True
						Me.lblCostPerGuide8.Visible = True
						Me.lblGuideTotalCost8.Visible = True
						Me.lblGuide8.Text = G
						Me.lblGuidePerRod8.Text = Conversions.ToString(N)
						Me.lblCostPerGuide8.Text = C
						Me.lblGuideTotalCost8.Text = T
				End Select
			Catch ex As Exception
			End Try
		End Sub

		Public Function MakeGuideKey(iGuide As Integer) As String
			Dim result As String
			Try
				Dim text As String
				If iGuide = 0 Then
					text = "No Guide"
				ElseIf iGuide = CInt(RSWIN_DESC.MOLDED) Then
					text = "MOLDED"
				ElseIf iGuide = 2 Then
					text = "WHEELED"
				ElseIf iGuide = 3 Then
					text = "OtherGuided"
				ElseIf iGuide = 4 Then
					text = "NorrisStandardGuide"
				ElseIf iGuide = CInt(RSWIN_DESC.NorrisSidewinderGuide) Then
					text = "SidewinderGuide"
				ElseIf iGuide = 6 Then
					text = "RGIJakeCouplingGuide"
				ElseIf iGuide = 7 Then
					text = "RGISVTGuide"
				ElseIf iGuide = 8 Then
					text = "RGITomahawkGuide"
				ElseIf iGuide = 9 Then
					text = "RGI Tornado"
				ElseIf iGuide = 10 Then
					text = "RGITwisterGuide"
				ElseIf iGuide = 11 Then
					text = "RGIWVTGuide"
				End If
				result = text
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetGuideName(iGuide As Integer) As String
			Dim result As String
			Try
				Dim text As String = ""
				If iGuide = 0 Then
					text = "No Guide"
				ElseIf iGuide = CInt(RSWIN_DESC.MOLDED) Then
					text = "MOLDED"
				ElseIf iGuide = 2 Then
					text = "WHEELED"
				ElseIf iGuide = 3 Then
					text = "Other"
				ElseIf iGuide = 4 Then
					text = "Norris Standard"
				ElseIf iGuide = CInt(RSWIN_DESC.NorrisSidewinderGuide) Then
					text = "Sidewinder"
				ElseIf iGuide = 6 Then
					text = "RGI Jake Coupling"
				ElseIf iGuide = 7 Then
					text = "RGI SVT"
				ElseIf iGuide = 8 Then
					text = "RGI Tomahawk"
				ElseIf iGuide = 9 Then
					text = "RGI Tornado"
				ElseIf iGuide = 10 Then
					text = "RGI Twister"
				ElseIf iGuide = 11 Then
					text = "RGI WVT"
				End If
				result = text
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetNumberGuides(iGuide As Integer) As Integer
			Dim result As Integer
			Try
				Dim num As Integer
				If iGuide = CInt(RSWIN_DESC.MOLDED) Then
					num = RSWIN_DESC.iSumMOLDED
				ElseIf iGuide = 2 Then
					num = RSWIN_DESC.iSumWHEELED
				ElseIf iGuide = 3 Then
					num = RSWIN_DESC.iSumOther
				ElseIf iGuide = 4 Then
					num = RSWIN_DESC.iSumNorrisStandard
				ElseIf iGuide = CInt(RSWIN_DESC.NorrisSidewinderGuide) Then
					num = RSWIN_DESC.iSumNorrisSidewinder
				ElseIf iGuide = 6 Then
					num = RSWIN_DESC.iSumRGIJakeCoupling
				ElseIf iGuide = 7 Then
					num = RSWIN_DESC.iSumRGISVT
				ElseIf iGuide = 8 Then
					num = RSWIN_DESC.iSumRGITomahawk
				ElseIf iGuide = 9 Then
					num = RSWIN_DESC.iSumRGITornado
				ElseIf iGuide = 10 Then
					num = RSWIN_DESC.iSumRGITwister
				ElseIf iGuide = 11 Then
					num = RSWIN_DESC.iSumRGIWVT
				End If
				result = num
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub SetAllGuideLabels()
			' The following expression was wrapped in a checked-statement
			Try
				Me.lblGuideCostAnalysis.Visible = True
				Me.lblTotalGuide.Visible = True
				Me.lblGuideTotalCost.Visible = True
				Me.Line7.Visible = True
				Me.Line17.Visible = True
				Me.Line10.Visible = True
				Me.Line9.Visible = True
				Me.Line6.Visible = True
				Me.Line1.Visible = True
				Me.Line8.Visible = True
				Me.lblGuide.Visible = True
				Me.lblType.Visible = True
				Me.lblNumGuides.Visible = True
				Me.Label73.Visible = True
				Me.lblGuideCost.Visible = True
				Me.lblGuideDollar.Visible = True
				Me.lblTotalGuideCostDollar.Visible = True
				Me.lblTotalCostGuide.Visible = True
				Dim num As Single = 0F
				Dim num2 As Integer = 0
				Dim num3 As Integer = 1
				Do
					If RSWIN_DESC.bGuideSums(num3) Then
						Dim text As String = Conversions.ToString(0)
						num2 += 1
						Dim sDBKey As String = Me.MakeGuideKey(RSWIN_DESC.iGuides(num3))
						Dim num4 As Single
						COSTDB.DBLookup(sDBKey, num4)
						Dim guideName As String = Me.GetGuideName(RSWIN_DESC.iGuides(num3))
						Dim numberGuides As Integer = Me.GetNumberGuides(RSWIN_DESC.iGuides(num3))

							Dim num5 As Single = num4 * CSng(numberGuides)
							If num5 > 0F Then
								text = Conversions.ToString(Conversions.ToDouble(text) + CDbl(num5))
								num = CSng((CDbl(num) + Conversions.ToDouble(text)))
							End If
							Me.SetGuideLabels(num2, guideName, numberGuides, Conversions.ToString(num4), Util.RFormat(text, "####0.00"))

					End If
					num3 += 1
				Loop While num3 <= 11
				Me.lblGuideTotalCost.Text = Util.RFormat(num, "####0.00")
			Catch ex As Exception
			End Try
		End Sub

		Private sCompany As String

		Private sWell As String

		Private sUser As String

		Private sDiskFile As String

		Private sDate As String

		Private sPage As String

		Private sOf As String

		Private sComment As String

		Private sNA As String

		Private sAirAtTankAt As String

		Private sLicenseTo As String

		Private sThetaEnterprises As String

		<AccessedThroughProperty("lblGuideCostAnalysis")>
		Private _lblGuideCostAnalysis As Label

		<AccessedThroughProperty("Line1")>
		Private _Line1 As Line

		<AccessedThroughProperty("lblGuideTotalCost1")>
		Private _lblGuideTotalCost1 As Label

		<AccessedThroughProperty("lblGuideTotalCost2")>
		Private _lblGuideTotalCost2 As Label

		<AccessedThroughProperty("lblGuideTotalCost3")>
		Private _lblGuideTotalCost3 As Label

		<AccessedThroughProperty("lblGuideTotalCost4")>
		Private _lblGuideTotalCost4 As Label

		<AccessedThroughProperty("lblGuideTotalCost5")>
		Private _lblGuideTotalCost5 As Label

		<AccessedThroughProperty("lblGuideTotalCost6")>
		Private _lblGuideTotalCost6 As Label

		<AccessedThroughProperty("lblGuideTotalCost7")>
		Private _lblGuideTotalCost7 As Label

		<AccessedThroughProperty("lblGuideTotalCost8")>
		Private _lblGuideTotalCost8 As Label

		<AccessedThroughProperty("Line6")>
		Private _Line6 As Line

		<AccessedThroughProperty("lblTotalCostGuide")>
		Private _lblTotalCostGuide As Label

		<AccessedThroughProperty("lblTotalGuideCostDollar")>
		Private _lblTotalGuideCostDollar As Label

		<AccessedThroughProperty("lblGuideTotalCost")>
		Private _lblGuideTotalCost As Label

		<AccessedThroughProperty("Line7")>
		Private _Line7 As Line

		<AccessedThroughProperty("lblTotalGuide")>
		Private _lblTotalGuide As Label

		<AccessedThroughProperty("Line8")>
		Private _Line8 As Line

		<AccessedThroughProperty("lblGuide1")>
		Private _lblGuide1 As Label

		<AccessedThroughProperty("lblGuide2")>
		Private _lblGuide2 As Label

		<AccessedThroughProperty("lblGuide3")>
		Private _lblGuide3 As Label

		<AccessedThroughProperty("lblGuide4")>
		Private _lblGuide4 As Label

		<AccessedThroughProperty("lblGuide5")>
		Private _lblGuide5 As Label

		<AccessedThroughProperty("lblGuide6")>
		Private _lblGuide6 As Label

		<AccessedThroughProperty("lblGuide7")>
		Private _lblGuide7 As Label

		<AccessedThroughProperty("lblGuide8")>
		Private _lblGuide8 As Label

		<AccessedThroughProperty("lblType")>
		Private _lblType As Label

		<AccessedThroughProperty("lblGuide")>
		Private _lblGuide As Label

		<AccessedThroughProperty("lblCostPerGuide1")>
		Private _lblCostPerGuide1 As Label

		<AccessedThroughProperty("lblCostPerGuide2")>
		Private _lblCostPerGuide2 As Label

		<AccessedThroughProperty("lblCostPerGuide3")>
		Private _lblCostPerGuide3 As Label

		<AccessedThroughProperty("lblCostPerGuide4")>
		Private _lblCostPerGuide4 As Label

		<AccessedThroughProperty("lblCostPerGuide5")>
		Private _lblCostPerGuide5 As Label

		<AccessedThroughProperty("lblCostPerGuide6")>
		Private _lblCostPerGuide6 As Label

		<AccessedThroughProperty("lblCostPerGuide7")>
		Private _lblCostPerGuide7 As Label

		<AccessedThroughProperty("lblCostPerGuide8")>
		Private _lblCostPerGuide8 As Label

		<AccessedThroughProperty("lblGuideDollar")>
		Private _lblGuideDollar As Label

		<AccessedThroughProperty("lblGuideCost")>
		Private _lblGuideCost As Label

		<AccessedThroughProperty("lblGuidePerRod1")>
		Private _lblGuidePerRod1 As Label

		<AccessedThroughProperty("lblGuidePerRod2")>
		Private _lblGuidePerRod2 As Label

		<AccessedThroughProperty("lblGuidePerRod3")>
		Private _lblGuidePerRod3 As Label

		<AccessedThroughProperty("lblGuidePerRod4")>
		Private _lblGuidePerRod4 As Label

		<AccessedThroughProperty("lblGuidePerRod5")>
		Private _lblGuidePerRod5 As Label

		<AccessedThroughProperty("lblGuidePerRod6")>
		Private _lblGuidePerRod6 As Label

		<AccessedThroughProperty("lblGuidePerRod7")>
		Private _lblGuidePerRod7 As Label

		<AccessedThroughProperty("lblGuidePerRod8")>
		Private _lblGuidePerRod8 As Label

		<AccessedThroughProperty("Label73")>
		Private _Label73 As Label

		<AccessedThroughProperty("lblNumGuides")>
		Private _lblNumGuides As Label

		<AccessedThroughProperty("Line9")>
		Private _Line9 As Line

		<AccessedThroughProperty("Line10")>
		Private _Line10 As Line

		<AccessedThroughProperty("lblCost18")>
		Private _lblCost18 As Label

		<AccessedThroughProperty("lblCost20")>
		Private _lblCost20 As Label

		<AccessedThroughProperty("lblCost19")>
		Private _lblCost19 As Label

		<AccessedThroughProperty("lblCost17")>
		Private _lblCost17 As Label

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

		<AccessedThroughProperty("lblRodGrade11")>
		Private _lblRodGrade11 As Label

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

		<AccessedThroughProperty("lblRodLength11")>
		Private _lblRodLength11 As Label

		<AccessedThroughProperty("lblRodLength12")>
		Private _lblRodLength12 As Label

		<AccessedThroughProperty("lblRodLength13")>
		Private _lblRodLength13 As Label

		<AccessedThroughProperty("lblRodLength14")>
		Private _lblRodLength14 As Label

		<AccessedThroughProperty("lblRodLength15")>
		Private _lblRodLength15 As Label

		<AccessedThroughProperty("lblRodLength16")>
		Private _lblRodLength16 As Label

		<AccessedThroughProperty("lblRodLength17")>
		Private _lblRodLength17 As Label

		<AccessedThroughProperty("lblRodLength18")>
		Private _lblRodLength18 As Label

		<AccessedThroughProperty("lblTotalCost11")>
		Private _lblTotalCost11 As Label

		<AccessedThroughProperty("lblTotalCost12")>
		Private _lblTotalCost12 As Label

		<AccessedThroughProperty("lblTotalCost13")>
		Private _lblTotalCost13 As Label

		<AccessedThroughProperty("lblTotalCost14")>
		Private _lblTotalCost14 As Label

		<AccessedThroughProperty("lblTotalCost15")>
		Private _lblTotalCost15 As Label

		<AccessedThroughProperty("lblTotalCost16")>
		Private _lblTotalCost16 As Label

		<AccessedThroughProperty("lblTotalCost17")>
		Private _lblTotalCost17 As Label

		<AccessedThroughProperty("lblTotalCost18")>
		Private _lblTotalCost18 As Label

		<AccessedThroughProperty("lblCost11")>
		Private _lblCost11 As Label

		<AccessedThroughProperty("lblCost12")>
		Private _lblCost12 As Label

		<AccessedThroughProperty("lblCost13")>
		Private _lblCost13 As Label

		<AccessedThroughProperty("lblCost14")>
		Private _lblCost14 As Label

		<AccessedThroughProperty("lblCost15")>
		Private _lblCost15 As Label

		<AccessedThroughProperty("lblCost16")>
		Private _lblCost16 As Label

		<AccessedThroughProperty("lblRodDiam19")>
		Private _lblRodDiam19 As Label

		<AccessedThroughProperty("lblRodGrade19")>
		Private _lblRodGrade19 As Label

		<AccessedThroughProperty("lblRodLength19")>
		Private _lblRodLength19 As Label

		<AccessedThroughProperty("lblTotalCost19")>
		Private _lblTotalCost19 As Label

		<AccessedThroughProperty("lblRodDiam20")>
		Private _lblRodDiam20 As Label

		<AccessedThroughProperty("lblRodGrade20")>
		Private _lblRodGrade20 As Label

		<AccessedThroughProperty("lblRodLength20")>
		Private _lblRodLength20 As Label

		<AccessedThroughProperty("lblTotalCost20")>
		Private _lblTotalCost20 As Label

		<AccessedThroughProperty("Line17")>
		Private _Line17 As Line

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer

		Private m_bPrint As Boolean

		<AccessedThroughProperty("PageHeader")>
		Private _PageHeader As PageHeader

		<AccessedThroughProperty("Detail")>
		Private _Detail As Detail

		<AccessedThroughProperty("PageFooter")>
		Private _PageFooter As PageFooter

		Private lblCost8 As Label

		Private lblCost10 As Label

		Private lblCost9 As Label

		Private lblCost7 As Label

		Private lblRodStringDesign As Label

		Private Line11 As Line

		Private lblRodDiamHdrTop As Label

		Private lblRodDiamHdrBot As Label

		Private lblRodDiam1 As Label

		Private lblRodGradeHdrTop As Label

		Private lblRodGradeHdrBot As Label

		Private lblRodLengthHdrTop As Label

		Private lblRodLengthHdrBot As Label

		Private Line12 As Line

		Private lblRodDiam2 As Label

		Private lblRodDiam3 As Label

		Private lblRodDiam4 As Label

		Private lblRodDiam5 As Label

		Private lblRodDiam6 As Label

		Private lblRodDiam7 As Label

		Private lblRodDiam8 As Label

		Private lblRodGrade1 As Label

		Private lblRodGrade2 As Label

		Private lblRodGrade3 As Label

		Private lblRodGrade4 As Label

		Private lblRodGrade5 As Label

		Private lblRodGrade6 As Label

		Private lblRodGrade7 As Label

		Private lblRodGrade8 As Label

		Private lblRodLength1 As Label

		Private lblRodLength2 As Label

		Private lblRodLength3 As Label

		Private lblRodLength4 As Label

		Private lblRodLength5 As Label

		Private lblRodLength6 As Label

		Private lblRodLength7 As Label

		Private lblRodLength8 As Label

		Private linRSInputSep1 As Line

		Private linRSInputSep2 As Line

		Private linRSInputSep3 As Line

		Private lblTotalCost1 As Label

		Private lblTotalCost2 As Label

		Private lblTotalCost3 As Label

		Private lblTotalCost4 As Label

		Private lblTotalCost5 As Label

		Private lblTotalCost6 As Label

		Private lblTotalCost7 As Label

		Private lblTotalCost8 As Label

		Private Line13 As Line

		Private Label9 As Label

		Private Label10 As Label

		Private lblTotalRSCost2 As Label

		Private lblPumpingUnitDesign As Label

		Private lblTotalPUCost2 As Label

		Private lblTotalPUCost As Label

		Private lblManufacturer As Label

		Private lblAPISize As Label

		Private lblUnitName As Label

		Private lblCost1 As Label

		Private lblCost2 As Label

		Private lblCost3 As Label

		Private lblCost4 As Label

		Private lblCost5 As Label

		Private lblCost6 As Label

		Private Line15 As Line

		Private Label23 As Label

		Private lblCostHdrBot As Label

		Private lblTotalRSCost As Label

		Private lblAddCosts As Label

		Private lblAddCosts2 As Label

		Private Line16 As Line

		Private lblComment As Label

		Private lblTitle1 As Label

		Private lblPage As Label

		Private txtPage1 As TextBox

		Private lblOf As Label

		Private txtPage2 As TextBox

		Private lblUserName As Label

		Private lblUserDate As Label

		Private lblRodDiam9 As Label

		Private lblRodGrade9 As Label

		Private lblRodLength9 As Label

		Private lblTotalCost9 As Label

		Private lblRodDiam10 As Label

		Private lblRodGrade10 As Label

		Private lblRodLength10 As Label

		Private lblTotalCost10 As Label

		Private Line14 As Line

		Private lblLabel2 As Label

		Private lblCompany As Label

		Private lblWellName As Label

		Private lblDiskFile As Label

		Private lblSecondCompanyName As Label

		Private lblSecondCompanyPhonenumber As Label

		Private lblGoTheta As Label
	End Class
End Namespace
