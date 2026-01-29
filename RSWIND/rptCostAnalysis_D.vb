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
	Public Class rptCostAnalysis_D
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.rptCostAnalysis_D_ReportStart
			Me.sCompany = Util.AssignValueToConstant("rptCalcResults", "sCompany", "Company: ")
			Me.sWell = Util.AssignValueToConstant("rptCalcResults", "sWell", "Well: ")
			Me.sUser = Util.AssignValueToConstant("rptCalcResults", "sUser", "User: ")
			Me.sDiskFile = Util.AssignValueToConstant("rptCalcResults", "sDiskFile", "Disk file: ")
			Me.sDate = Util.AssignValueToConstant("rptCalcResults", "sDate", "Date: ")
			Me.sPage = Util.AssignValueToConstant("rptCalcResults", "sPage", "Page")
			Me.sOf = Util.AssignValueToConstant("rptCalcResults", "sOf", "of")
			Me.sComment = Util.AssignValueToConstant("rptCalcResults", "sComment", "Comment: ")
			Me.sAirAtTankAt = Util.AssignValueToConstant("rptCalcResults", "sAirAtTankAt", "Air tank pressure at")
			Me.sLicenseTo = Util.AssignValueToConstant("rptCalcResults", "sLicenseTo", " - Licensed to ")
			Me.sThetaEnterprises = Util.AssignValueToConstant("rptCalcResults", "sThetaEnterprises", "(c) Theta Oilfield Services, Inc.")
			Me.sNA = Util.AssignValueToConstant("rptCalcResults", "sNA", "N/A")
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

		Private Overridable Property lblGuide9 As Label
			Get
				Return Me._lblGuide9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide9 = value
			End Set
		End Property

		Private Overridable Property lblGuide10 As Label
			Get
				Return Me._lblGuide10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide10 = value
			End Set
		End Property

		Private Overridable Property Label13 As Label
			Get
				Return Me._Label13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label13 = value
			End Set
		End Property

		Private Overridable Property Label14 As Label
			Get
				Return Me._Label14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label14 = value
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

		Private Overridable Property lblCostPerGuide9 As Label
			Get
				Return Me._lblCostPerGuide9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide9 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide10 As Label
			Get
				Return Me._lblCostPerGuide10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide10 = value
			End Set
		End Property

		Private Overridable Property Label26 As Label
			Get
				Return Me._Label26
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label26 = value
			End Set
		End Property

		Private Overridable Property Label27 As Label
			Get
				Return Me._Label27
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label27 = value
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

		Private Overridable Property lblGuidePerRod9 As Label
			Get
				Return Me._lblGuidePerRod9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod9 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod10 As Label
			Get
				Return Me._lblGuidePerRod10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod10 = value
			End Set
		End Property

		Private Overridable Property Label38 As Label
			Get
				Return Me._Label38
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label38 = value
			End Set
		End Property

		Private Overridable Property Label39 As Label
			Get
				Return Me._Label39
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label39 = value
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

		Private Overridable Property Line2 As Line
			Get
				Return Me._Line2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line2 = value
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

		Private Overridable Property lblGuide11 As Label
			Get
				Return Me._lblGuide11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide11 = value
			End Set
		End Property

		Private Overridable Property lblGuide12 As Label
			Get
				Return Me._lblGuide12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide12 = value
			End Set
		End Property

		Private Overridable Property lblGuide13 As Label
			Get
				Return Me._lblGuide13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide13 = value
			End Set
		End Property

		Private Overridable Property lblGuide14 As Label
			Get
				Return Me._lblGuide14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide14 = value
			End Set
		End Property

		Private Overridable Property lblGuide15 As Label
			Get
				Return Me._lblGuide15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide15 = value
			End Set
		End Property

		Private Overridable Property lblGuide16 As Label
			Get
				Return Me._lblGuide16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide16 = value
			End Set
		End Property

		Private Overridable Property lblGuide17 As Label
			Get
				Return Me._lblGuide17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide17 = value
			End Set
		End Property

		Private Overridable Property lblGuide18 As Label
			Get
				Return Me._lblGuide18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide18 = value
			End Set
		End Property

		Private Overridable Property lblGuide19 As Label
			Get
				Return Me._lblGuide19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide19 = value
			End Set
		End Property

		Private Overridable Property lblGuide20 As Label
			Get
				Return Me._lblGuide20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuide20 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide11 As Label
			Get
				Return Me._lblCostPerGuide11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide11 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide12 As Label
			Get
				Return Me._lblCostPerGuide12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide12 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide13 As Label
			Get
				Return Me._lblCostPerGuide13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide13 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide14 As Label
			Get
				Return Me._lblCostPerGuide14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide14 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide15 As Label
			Get
				Return Me._lblCostPerGuide15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide15 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide16 As Label
			Get
				Return Me._lblCostPerGuide16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide16 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide17 As Label
			Get
				Return Me._lblCostPerGuide17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide17 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide18 As Label
			Get
				Return Me._lblCostPerGuide18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide18 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide19 As Label
			Get
				Return Me._lblCostPerGuide19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide19 = value
			End Set
		End Property

		Private Overridable Property lblCostPerGuide20 As Label
			Get
				Return Me._lblCostPerGuide20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCostPerGuide20 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod11 As Label
			Get
				Return Me._lblGuidePerRod11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod11 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod12 As Label
			Get
				Return Me._lblGuidePerRod12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod12 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod13 As Label
			Get
				Return Me._lblGuidePerRod13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod13 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod14 As Label
			Get
				Return Me._lblGuidePerRod14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod14 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod15 As Label
			Get
				Return Me._lblGuidePerRod15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod15 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod16 As Label
			Get
				Return Me._lblGuidePerRod16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod16 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod17 As Label
			Get
				Return Me._lblGuidePerRod17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod17 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod18 As Label
			Get
				Return Me._lblGuidePerRod18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod18 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod19 As Label
			Get
				Return Me._lblGuidePerRod19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod19 = value
			End Set
		End Property

		Private Overridable Property lblGuidePerRod20 As Label
			Get
				Return Me._lblGuidePerRod20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuidePerRod20 = value
			End Set
		End Property

		Private Overridable Property Line4 As Line
			Get
				Return Me._Line4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Line)
				Me._Line4 = value
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

		Private Overridable Property lblNumRodsHdrBot As Label
			Get
				Return Me._lblNumRodsHdrBot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRodsHdrBot = value
			End Set
		End Property

		Private Overridable Property lblNumRods1 As Label
			Get
				Return Me._lblNumRods1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods1 = value
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

		Private Overridable Property lblNumRods9 As Label
			Get
				Return Me._lblNumRods9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods9 = value
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

		Private Overridable Property lblNumRods11 As Label
			Get
				Return Me._lblNumRods11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods11 = value
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

		Private Overridable Property lblNumRods17 As Label
			Get
				Return Me._lblNumRods17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods17 = value
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

		Private Overridable Property lblNumRods18 As Label
			Get
				Return Me._lblNumRods18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods18 = value
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

		Private Overridable Property lblNumRods20 As Label
			Get
				Return Me._lblNumRods20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRods20 = value
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

		Private Sub SummHeader(iPage As Integer, nPages As Integer)
			Dim text As String = New String(" "c, 112)
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

		Private Sub SummHeader_old(iPage As Integer, nPages As Integer)
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

		Public Property bPrint As Boolean
			Get
				Return Me.m_bPrint
			End Get
			Set(value As Boolean)
				Me.m_bPrint = value
				Me.PageSettings.Orientation = PageOrientation.Portrait
			End Set
		End Property

		Public Sub rptCostAnalysis_D_ReportStart(sender As Object, e As EventArgs)
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
			If RSWIN_DESC.bReadResXFile Then
				Me.ReadReportControlStrings()
			End If
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
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Dim num As Short = -1S
				Dim num2 As Short = 1S
				Dim numRods As Short = cRODSTAR.NumRods
				For num3 As Short = num2 To numRods
					If Not RODUTIL.IsCorod(cRODSTAR.Sections(CInt(num3)).Grade) Then
						num = 0S
						Exit For
					End If
				Next
				Dim num4 As Single = 0F
				Dim num5 As Single = 0F
				Dim sDBKey As String
				Try
					Dim num6 As Short = 1S
					Dim numRods2 As Short = cRODSTAR.NumRods
					For num3 As Short = num6 To numRods2
						Me.MakeRGKey(CInt(cRODSTAR.Sections(CInt(num3)).Grade), Strings.Trim(cRODSTAR.Sections(CInt(num3)).RodType), cRODSTAR.Sections(CInt(num3)).Diameter, sDBKey)
						Dim num7 As Single
						COSTDB.DBLookup(sDBKey, num7)
						Dim text As String
						Dim text2 As String
						If num7 = 0F Then
							num4 = -1F
							text = "  N/A"
							text2 = "     N/A"
						Else
							num4 = 0F
							Dim num8 As Single
							If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
								num8 = num7 * cRODSTAR.Sections(CInt(num3)).length
							Else
								num8 = num7 * (cRODSTAR.Sections(CInt(num3)).length * RSWIN_DESC.FT__M)
							End If
							text = Util.RFormat(num7, "#0.00")
							text2 = Util.RFormat(num8, "####0.00")
							If num4 >= 0F Then
								num4 = CSng((CDbl(num4) + Convert.ToDouble(text2)))
							End If
						End If
						text = Strings.Left(text + Strings.Space(5), 5)
						text2 = Strings.Left(text2 + Strings.Space(8), 8)
						Dim text3 As String
						If cRODSTAR.Sections(CInt(num3)).Grade = 4096S Then
							text3 = Strings.Left(Strings.Trim(cRODSTAR.Sections(CInt(num3)).RodType), 19)
						Else
							text3 = RODUTIL.RodGrade(cRODSTAR.Sections(CInt(num3)).Grade)
							If RODUTIL.IsCorodH(cRODSTAR.Sections(CInt(num3)).Grade) Then
								If CDbl(cRODSTAR.Sections(CInt(num3)).Area) < 0.7 Then
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
							l = Util.RFormat(cRODSTAR.Sections(CInt(num3)).length, "####0")
						Else
							l = Util.RFormat(cRODSTAR.Sections(CInt(num3)).length * RSWIN_DESC.FT__M, "####0")
						End If
						Dim text4 As String
						If RODUTIL.IsCorodH(cRODSTAR.Sections(CInt(num3)).Grade) Then
							text4 = "N/A"
						ElseIf RODUTIL.IsCorod(cRODSTAR.Sections(CInt(num3)).Grade) Then
							Dim num9 As Single = cRODSTAR.Sections(CInt(num3)).Diameter * 16F
							Dim text5 As String = "0"
							text4 = Util.Format(num9, text5) + "/16"
							If(Not num And If((-If(((RSWIN_DESC.SETUP_MeasurementSystem = 3) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
								text4 += """"
							End If
							Dim str As String = text4
							Dim str2 As String = " (#"
							Dim obj As Object = Conversion.Int(cRODSTAR.Sections(CInt(num3)).Diameter * 16F) - 10F
							text4 = str + str2 + Util.Format(obj) + ")"
						ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							text4 = Util.RFormat(cRODSTAR.Sections(CInt(num3)).Diameter * RSWIN_DESC.IN__MM, "##0.0")
						Else
							text4 = Util.RFormat(cRODSTAR.Sections(CInt(num3)).Diameter, "0.0##")
						End If
						Dim sDBKey2 As String = Me.MakeGuideKey(CInt(cRODSTAR.Sections(CInt(num3)).Guide))
						Dim num10 As Single
						COSTDB.DBLookup(sDBKey2, num10)
						Dim guideName As String = Me.GetGuideName(CInt(cRODSTAR.Sections(CInt(num3)).Guide))
						Dim sGuidePerRod As String = Convert.ToString(cRODSTAR.Sections(CInt(num3)).NumGuides)
						Dim num11 As Single
						If RODUTIL.IsFG(cRODSTAR.Sections(CInt(num3)).Grade) Or CUSTOMRG.IsOtherFG(CInt(cRODSTAR.Sections(CInt(num3)).Grade)) Then
							num11 = 37.5F
						Else
							num11 = RSWIN_DESC.SETUP_SteelSuckerRodLength
						End If
						Dim num12 As Integer = CInt(Math.Round(CDbl((cRODSTAR.Sections(CInt(num3)).length / num11)) + 0.5))
						Dim num13 As Single = num10 * CSng(cRODSTAR.Sections(CInt(num3)).NumGuides) * CSng(num12)
						If num13 > 0F Then
							If num4 = -1F Then
								num4 = num13
								text2 = num4.ToString()
							Else
								num4 += num13
								text2 = num4.ToString()
							End If
							num5 += num4
						ElseIf num4 <> -1F Then
							num5 += num4
						End If
						Me.SetRSLabels(num3, text4, text3, l, text, text2, guideName, sGuidePerRod, num10, num12)
					Next
				Catch ex As Exception
				End Try
				If cRODSTAR.RSExtraCost > 0F Then
					If num4 >= 0F Then
						num4 += cRODSTAR.RSExtraCost
						num5 += num4
					End If
					If Strings.Len(cRODSTAR.RSExtraCostLabel) = 0 Then
						Me.lblAddCosts.Text = "Additional rod costs"
					Else
						Me.lblAddCosts.Text = Util.RFormat(cRODSTAR.RSExtraCostLabel, "$#####0.00")
					End If
					Me.lblAddCosts.Text = Me.lblAddCosts.Text + ":"
					Me.lblAddCosts2.Text = Util.RFormat(cRODSTAR.RSExtraCost, "$#####0.00")
					If cRODSTAR.RSExtraCost > 0F Then
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
				If num5 = 0F Then
					Me.lblTotalRSCost2.Text = "N/A"
				ElseIf num5 > 0F Then
					Me.lblTotalRSCost2.Text = Util.RFormat(num5, "$#####0.00")
				End If
				Dim str3 As String = RSWIN_DESC.rst.UnitID.Trim()
				sDBKey = "PU/" + str3
				COSTDB.DBLookup(sDBKey, num4)
				If num4 <= 0F Then
					Me.lblTotalPUCost2.Text = "N/A"
				Else
					Me.lblTotalPUCost2.Text = Util.RFormat(num4, "$#####0.00")
				End If
				Me.lblManufacturer.Text = RESULTS1.VTrim(cRODSTAR.PU.Manuf)
				Me.lblAPISize.Text = RESULTS1.VTrim(cRODSTAR.PU.APIDesignation)
				If Strings.Len(RESULTS1.VTrim(cRODSTAR.PU.UnitName)) > 0 Then
					Me.lblUnitName.Text = RESULTS1.VTrim(cRODSTAR.PU.UnitName)
				End If
				cRODSTAR = Nothing
			Catch ex2 As Exception
			End Try
		End Sub

		Private Function SetRSLabels(I As Short, d As String, Rgrade As String, L As String, C As String, T As String, sGuide As String, sGuidePerRod As String, fCostPerGuide As Single, iReportNumRods As Integer) As Object
			Select Case I
				Case 1S
					Me.lblRodDiam1.Text = d.ToString()
					Me.lblRodGrade1.Text = Rgrade.ToString()
					Me.lblRodLength1.Text = L.ToString()
					Me.lblCost1.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost1.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods1.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam1.Visible = True
					Me.lblRodGrade1.Visible = True
					Me.lblRodLength1.Visible = True
					Me.lblCost1.Visible = True
					Me.lblTotalCost1.Visible = True
					Me.lblNumRods1.Visible = True
					Me.lblGuide1.Text = sGuide
					Me.lblGuidePerRod1.Text = sGuidePerRod
					Me.lblCostPerGuide1.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide1.Visible = True
					Me.lblGuidePerRod1.Visible = True
					Me.lblCostPerGuide1.Visible = True
				Case 2S
					Me.lblRodDiam2.Text = d.ToString()
					Me.lblRodGrade2.Text = Rgrade.ToString()
					Me.lblRodLength2.Text = L.ToString()
					Me.lblCost2.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost2.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods2.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam2.Visible = True
					Me.lblRodGrade2.Visible = True
					Me.lblRodLength2.Visible = True
					Me.lblCost2.Visible = True
					Me.lblTotalCost2.Visible = True
					Me.lblNumRods2.Visible = True
					Me.lblGuide2.Text = sGuide
					Me.lblGuidePerRod2.Text = sGuidePerRod
					Me.lblCostPerGuide2.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide2.Visible = True
					Me.lblGuidePerRod2.Visible = True
					Me.lblCostPerGuide2.Visible = True
				Case 3S
					Me.lblRodDiam3.Text = d.ToString()
					Me.lblRodGrade3.Text = Rgrade.ToString()
					Me.lblRodLength3.Text = L.ToString()
					Me.lblCost3.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost3.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods3.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam3.Visible = True
					Me.lblRodGrade3.Visible = True
					Me.lblRodLength3.Visible = True
					Me.lblCost3.Visible = True
					Me.lblTotalCost3.Visible = True
					Me.lblNumRods3.Visible = True
					Me.lblGuide3.Text = sGuide
					Me.lblGuidePerRod3.Text = sGuidePerRod
					Me.lblCostPerGuide3.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide3.Visible = True
					Me.lblGuidePerRod3.Visible = True
					Me.lblCostPerGuide3.Visible = True
				Case 4S
					Me.lblRodDiam4.Text = d.ToString()
					Me.lblRodGrade4.Text = Rgrade.ToString()
					Me.lblRodLength4.Text = L.ToString()
					Me.lblCost4.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost4.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods4.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam4.Visible = True
					Me.lblRodGrade4.Visible = True
					Me.lblRodLength4.Visible = True
					Me.lblCost4.Visible = True
					Me.lblTotalCost4.Visible = True
					Me.lblNumRods4.Visible = True
					Me.lblGuide4.Text = sGuide
					Me.lblGuidePerRod4.Text = sGuidePerRod
					Me.lblCostPerGuide4.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide4.Visible = True
					Me.lblGuidePerRod4.Visible = True
					Me.lblCostPerGuide4.Visible = True
				Case 5S
					Me.lblRodDiam5.Text = d.ToString()
					Me.lblRodGrade5.Text = Rgrade.ToString()
					Me.lblRodLength5.Text = L.ToString()
					Me.lblCost5.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost5.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods5.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam5.Visible = True
					Me.lblRodGrade5.Visible = True
					Me.lblRodLength5.Visible = True
					Me.lblCost5.Visible = True
					Me.lblTotalCost5.Visible = True
					Me.lblNumRods5.Visible = True
					Me.lblGuide5.Text = sGuide
					Me.lblGuidePerRod5.Text = sGuidePerRod
					Me.lblCostPerGuide5.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide5.Visible = True
					Me.lblGuidePerRod5.Visible = True
					Me.lblCostPerGuide5.Visible = True
				Case 6S
					Me.lblRodDiam6.Text = d.ToString()
					Me.lblRodGrade6.Text = Rgrade.ToString()
					Me.lblRodLength6.Text = L.ToString()
					Me.lblCost6.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost6.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods6.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam6.Visible = True
					Me.lblRodGrade6.Visible = True
					Me.lblRodLength6.Visible = True
					Me.lblCost6.Visible = True
					Me.lblTotalCost6.Visible = True
					Me.lblNumRods6.Visible = True
					Me.lblGuide6.Text = sGuide
					Me.lblGuidePerRod6.Text = sGuidePerRod
					Me.lblCostPerGuide6.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide6.Visible = True
					Me.lblGuidePerRod6.Visible = True
					Me.lblCostPerGuide6.Visible = True
				Case 7S
					Me.lblRodDiam7.Text = d.ToString()
					Me.lblRodGrade7.Text = Rgrade.ToString()
					Me.lblRodLength7.Text = L.ToString()
					Me.lblCost7.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost7.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods7.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam7.Visible = True
					Me.lblRodGrade7.Visible = True
					Me.lblRodLength7.Visible = True
					Me.lblCost7.Visible = True
					Me.lblTotalCost7.Visible = True
					Me.lblNumRods7.Visible = True
					Me.lblGuide7.Text = sGuide
					Me.lblGuidePerRod7.Text = sGuidePerRod
					Me.lblCostPerGuide7.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide7.Visible = True
					Me.lblGuidePerRod7.Visible = True
					Me.lblCostPerGuide7.Visible = True
				Case 8S
					Me.lblRodDiam8.Text = d.ToString()
					Me.lblRodGrade8.Text = Rgrade.ToString()
					Me.lblRodLength8.Text = L.ToString()
					Me.lblCost8.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost8.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods8.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam8.Visible = True
					Me.lblRodGrade8.Visible = True
					Me.lblRodLength8.Visible = True
					Me.lblCost8.Visible = True
					Me.lblTotalCost8.Visible = True
					Me.lblNumRods8.Visible = True
					Me.lblGuide8.Text = sGuide
					Me.lblGuidePerRod8.Text = sGuidePerRod
					Me.lblCostPerGuide8.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide8.Visible = True
					Me.lblGuidePerRod8.Visible = True
					Me.lblCostPerGuide8.Visible = True
				Case 9S
					Me.lblRodDiam9.Text = d.ToString()
					Me.lblRodGrade9.Text = Rgrade.ToString()
					Me.lblRodLength9.Text = L.ToString()
					Me.lblCost9.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost9.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods9.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam9.Visible = True
					Me.lblRodGrade9.Visible = True
					Me.lblRodLength9.Visible = True
					Me.lblCost9.Visible = True
					Me.lblTotalCost9.Visible = True
					Me.lblNumRods9.Visible = True
					Me.lblGuide9.Text = sGuide
					Me.lblGuidePerRod9.Text = sGuidePerRod
					Me.lblCostPerGuide9.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide9.Visible = True
					Me.lblGuidePerRod9.Visible = True
					Me.lblCostPerGuide9.Visible = True
				Case 10S
					Me.lblRodDiam10.Text = d.ToString()
					Me.lblRodGrade10.Text = Rgrade.ToString()
					Me.lblRodLength10.Text = L.ToString()
					Me.lblCost10.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost10.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods10.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam10.Visible = True
					Me.lblRodGrade10.Visible = True
					Me.lblRodLength10.Visible = True
					Me.lblCost10.Visible = True
					Me.lblTotalCost10.Visible = True
					Me.lblNumRods10.Visible = True
					Me.lblGuide10.Text = sGuide
					Me.lblGuidePerRod10.Text = sGuidePerRod
					Me.lblCostPerGuide10.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide10.Visible = True
					Me.lblGuidePerRod10.Visible = True
					Me.lblCostPerGuide10.Visible = True
				Case 11S
					Me.lblRodDiam11.Text = d.ToString()
					Me.lblRodGrade11.Text = Rgrade.ToString()
					Me.lblRodLength11.Text = L.ToString()
					Me.lblCost11.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost11.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods11.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam11.Visible = True
					Me.lblRodGrade11.Visible = True
					Me.lblRodLength11.Visible = True
					Me.lblCost11.Visible = True
					Me.lblTotalCost11.Visible = True
					Me.lblNumRods11.Visible = True
					Me.lblGuide11.Text = sGuide
					Me.lblGuidePerRod11.Text = sGuidePerRod
					Me.lblCostPerGuide11.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide11.Visible = True
					Me.lblGuidePerRod11.Visible = True
					Me.lblCostPerGuide11.Visible = True
				Case 12S
					Me.lblRodDiam12.Text = d.ToString()
					Me.lblRodGrade12.Text = Rgrade.ToString()
					Me.lblRodLength12.Text = L.ToString()
					Me.lblCost12.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost12.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods12.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam12.Visible = True
					Me.lblRodGrade12.Visible = True
					Me.lblRodLength12.Visible = True
					Me.lblCost12.Visible = True
					Me.lblTotalCost12.Visible = True
					Me.lblNumRods12.Visible = True
					Me.lblGuide12.Text = sGuide
					Me.lblGuidePerRod12.Text = sGuidePerRod
					Me.lblCostPerGuide12.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide12.Visible = True
					Me.lblGuidePerRod12.Visible = True
					Me.lblCostPerGuide12.Visible = True
				Case 13S
					Me.lblRodDiam13.Text = d.ToString()
					Me.lblRodGrade13.Text = Rgrade.ToString()
					Me.lblRodLength13.Text = L.ToString()
					Me.lblCost13.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost13.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods13.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam13.Visible = True
					Me.lblRodGrade13.Visible = True
					Me.lblRodLength13.Visible = True
					Me.lblCost13.Visible = True
					Me.lblTotalCost13.Visible = True
					Me.lblNumRods13.Visible = True
					Me.lblGuide13.Text = sGuide
					Me.lblGuidePerRod13.Text = sGuidePerRod
					Me.lblCostPerGuide13.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide13.Visible = True
					Me.lblGuidePerRod13.Visible = True
					Me.lblCostPerGuide13.Visible = True
				Case 14S
					Me.lblRodDiam14.Text = d.ToString()
					Me.lblRodGrade14.Text = Rgrade.ToString()
					Me.lblRodLength14.Text = L.ToString()
					Me.lblCost14.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost14.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods14.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam14.Visible = True
					Me.lblRodGrade14.Visible = True
					Me.lblRodLength14.Visible = True
					Me.lblCost14.Visible = True
					Me.lblTotalCost14.Visible = True
					Me.lblNumRods14.Visible = True
					Me.lblGuide14.Text = sGuide
					Me.lblGuidePerRod14.Text = sGuidePerRod
					Me.lblCostPerGuide14.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide14.Visible = True
					Me.lblGuidePerRod14.Visible = True
					Me.lblCostPerGuide14.Visible = True
				Case 15S
					Me.lblRodDiam15.Text = d.ToString()
					Me.lblRodGrade15.Text = Rgrade.ToString()
					Me.lblRodLength15.Text = L.ToString()
					Me.lblCost15.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost15.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods13.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam15.Visible = True
					Me.lblRodGrade15.Visible = True
					Me.lblRodLength15.Visible = True
					Me.lblCost15.Visible = True
					Me.lblTotalCost15.Visible = True
					Me.lblNumRods15.Visible = True
					Me.lblGuide15.Text = sGuide
					Me.lblGuidePerRod15.Text = sGuidePerRod
					Me.lblCostPerGuide15.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide15.Visible = True
					Me.lblGuidePerRod15.Visible = True
					Me.lblCostPerGuide15.Visible = True
				Case 16S
					Me.lblRodDiam16.Text = d.ToString()
					Me.lblRodGrade16.Text = Rgrade.ToString()
					Me.lblRodLength16.Text = L.ToString()
					Me.lblCost16.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost16.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods16.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam16.Visible = True
					Me.lblRodGrade16.Visible = True
					Me.lblRodLength16.Visible = True
					Me.lblCost16.Visible = True
					Me.lblTotalCost16.Visible = True
					Me.lblNumRods16.Visible = True
					Me.lblGuide16.Text = sGuide
					Me.lblGuidePerRod16.Text = sGuidePerRod
					Me.lblCostPerGuide16.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide16.Visible = True
					Me.lblGuidePerRod16.Visible = True
					Me.lblCostPerGuide16.Visible = True
				Case 17S
					Me.lblRodDiam17.Text = d.ToString()
					Me.lblRodGrade17.Text = Rgrade.ToString()
					Me.lblRodLength17.Text = L.ToString()
					Me.lblCost17.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost17.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods17.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam17.Visible = True
					Me.lblRodGrade17.Visible = True
					Me.lblRodLength17.Visible = True
					Me.lblCost17.Visible = True
					Me.lblTotalCost17.Visible = True
					Me.lblNumRods17.Visible = True
					Me.lblGuide17.Text = sGuide
					Me.lblGuidePerRod17.Text = sGuidePerRod
					Me.lblCostPerGuide17.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide17.Visible = True
					Me.lblGuidePerRod17.Visible = True
					Me.lblCostPerGuide17.Visible = True
				Case 18S
					Me.lblRodDiam18.Text = d.ToString()
					Me.lblRodGrade18.Text = Rgrade.ToString()
					Me.lblRodLength18.Text = L.ToString()
					Me.lblCost18.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost18.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods18.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam18.Visible = True
					Me.lblRodGrade18.Visible = True
					Me.lblRodLength18.Visible = True
					Me.lblCost18.Visible = True
					Me.lblTotalCost18.Visible = True
					Me.lblNumRods18.Visible = True
					Me.lblGuide18.Text = sGuide
					Me.lblGuidePerRod18.Text = sGuidePerRod
					Me.lblCostPerGuide18.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide18.Visible = True
					Me.lblGuidePerRod18.Visible = True
					Me.lblCostPerGuide18.Visible = True
				Case 19S
					Me.lblRodDiam19.Text = d.ToString()
					Me.lblRodGrade19.Text = Rgrade.ToString()
					Me.lblRodLength19.Text = L.ToString()
					Me.lblCost19.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost19.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods19.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam19.Visible = True
					Me.lblRodGrade19.Visible = True
					Me.lblRodLength19.Visible = True
					Me.lblCost19.Visible = True
					Me.lblTotalCost19.Visible = True
					Me.lblNumRods19.Visible = True
					Me.lblGuide19.Text = sGuide
					Me.lblGuidePerRod19.Text = sGuidePerRod
					Me.lblCostPerGuide19.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide19.Visible = True
					Me.lblGuidePerRod19.Visible = True
					Me.lblCostPerGuide19.Visible = True
				Case 20S
					Me.lblRodDiam20.Text = d.ToString()
					Me.lblRodGrade20.Text = Rgrade.ToString()
					Me.lblRodLength20.Text = L.ToString()
					Me.lblCost20.Text = Util.RFormat(C, "$#####0.00")
					Me.lblTotalCost20.Text = Util.RFormat(T, "$#####0.00")
					Me.lblNumRods20.Text = Conversions.ToString(iReportNumRods)
					Me.lblRodDiam20.Visible = True
					Me.lblRodGrade20.Visible = True
					Me.lblRodLength20.Visible = True
					Me.lblCost20.Visible = True
					Me.lblTotalCost20.Visible = True
					Me.lblNumRods20.Visible = True
					Me.lblGuide20.Text = sGuide
					Me.lblGuidePerRod20.Text = sGuidePerRod
					Me.lblCostPerGuide20.Text = Util.RFormat(fCostPerGuide, "$#####0.00")
					Me.lblGuide20.Visible = True
					Me.lblGuidePerRod20.Visible = True
					Me.lblCostPerGuide20.Visible = True
			End Select
			Dim result As Object
			Return result
		End Function

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
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptCostAnalysis_D))
			Me.Detail = New Detail()
			Me.PageHeader = New PageHeader()
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
			Me.lblTitle1 = New Label()
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
			Me.lblGuide1 = New Label()
			Me.lblGuide2 = New Label()
			Me.lblGuide3 = New Label()
			Me.lblGuide4 = New Label()
			Me.lblGuide5 = New Label()
			Me.lblGuide6 = New Label()
			Me.lblGuide7 = New Label()
			Me.lblGuide8 = New Label()
			Me.lblGuide9 = New Label()
			Me.lblGuide10 = New Label()
			Me.Label13 = New Label()
			Me.Label14 = New Label()
			Me.lblCostPerGuide1 = New Label()
			Me.lblCostPerGuide2 = New Label()
			Me.lblCostPerGuide3 = New Label()
			Me.lblCostPerGuide4 = New Label()
			Me.lblCostPerGuide5 = New Label()
			Me.lblCostPerGuide6 = New Label()
			Me.lblCostPerGuide7 = New Label()
			Me.lblCostPerGuide8 = New Label()
			Me.lblCostPerGuide9 = New Label()
			Me.lblCostPerGuide10 = New Label()
			Me.Label26 = New Label()
			Me.Label27 = New Label()
			Me.lblGuidePerRod1 = New Label()
			Me.lblGuidePerRod2 = New Label()
			Me.lblGuidePerRod3 = New Label()
			Me.lblGuidePerRod4 = New Label()
			Me.lblGuidePerRod5 = New Label()
			Me.lblGuidePerRod6 = New Label()
			Me.lblGuidePerRod7 = New Label()
			Me.lblGuidePerRod8 = New Label()
			Me.lblGuidePerRod9 = New Label()
			Me.lblGuidePerRod10 = New Label()
			Me.Label38 = New Label()
			Me.Label39 = New Label()
			Me.Line1 = New Line()
			Me.Line2 = New Line()
			Me.Line3 = New Line()
			Me.PageFooter = New PageFooter()
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
			Me.lblGuide11 = New Label()
			Me.lblGuide12 = New Label()
			Me.lblGuide13 = New Label()
			Me.lblGuide14 = New Label()
			Me.lblGuide15 = New Label()
			Me.lblGuide16 = New Label()
			Me.lblGuide17 = New Label()
			Me.lblGuide18 = New Label()
			Me.lblGuide19 = New Label()
			Me.lblGuide20 = New Label()
			Me.lblCostPerGuide11 = New Label()
			Me.lblCostPerGuide12 = New Label()
			Me.lblCostPerGuide13 = New Label()
			Me.lblCostPerGuide14 = New Label()
			Me.lblCostPerGuide15 = New Label()
			Me.lblCostPerGuide16 = New Label()
			Me.lblCostPerGuide17 = New Label()
			Me.lblCostPerGuide18 = New Label()
			Me.lblCostPerGuide19 = New Label()
			Me.lblCostPerGuide20 = New Label()
			Me.lblGuidePerRod11 = New Label()
			Me.lblGuidePerRod12 = New Label()
			Me.lblGuidePerRod13 = New Label()
			Me.lblGuidePerRod14 = New Label()
			Me.lblGuidePerRod15 = New Label()
			Me.lblGuidePerRod16 = New Label()
			Me.lblGuidePerRod17 = New Label()
			Me.lblGuidePerRod18 = New Label()
			Me.lblGuidePerRod19 = New Label()
			Me.lblGuidePerRod20 = New Label()
			Me.Line4 = New Line()
			Me.lblNumRodsHdrTop = New Label()
			Me.lblNumRodsHdrBot = New Label()
			Me.lblNumRods1 = New Label()
			Me.lblNumRods2 = New Label()
			Me.lblNumRods3 = New Label()
			Me.lblNumRods4 = New Label()
			Me.lblNumRods5 = New Label()
			Me.lblNumRods6 = New Label()
			Me.lblNumRods7 = New Label()
			Me.lblNumRods8 = New Label()
			Me.lblNumRods9 = New Label()
			Me.lblNumRods10 = New Label()
			Me.lblNumRods11 = New Label()
			Me.lblNumRods12 = New Label()
			Me.lblNumRods13 = New Label()
			Me.lblNumRods14 = New Label()
			Me.lblNumRods15 = New Label()
			Me.lblNumRods17 = New Label()
			Me.lblNumRods16 = New Label()
			Me.lblNumRods18 = New Label()
			Me.lblNumRods19 = New Label()
			Me.lblNumRods20 = New Label()
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
			CType(Me.lblTitle1, ISupportInitialize).BeginInit()
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
			CType(Me.lblGuide1, ISupportInitialize).BeginInit()
			CType(Me.lblGuide2, ISupportInitialize).BeginInit()
			CType(Me.lblGuide3, ISupportInitialize).BeginInit()
			CType(Me.lblGuide4, ISupportInitialize).BeginInit()
			CType(Me.lblGuide5, ISupportInitialize).BeginInit()
			CType(Me.lblGuide6, ISupportInitialize).BeginInit()
			CType(Me.lblGuide7, ISupportInitialize).BeginInit()
			CType(Me.lblGuide8, ISupportInitialize).BeginInit()
			CType(Me.lblGuide9, ISupportInitialize).BeginInit()
			CType(Me.lblGuide10, ISupportInitialize).BeginInit()
			CType(Me.Label13, ISupportInitialize).BeginInit()
			CType(Me.Label14, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide1, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide2, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide3, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide4, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide5, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide6, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide7, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide8, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide9, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide10, ISupportInitialize).BeginInit()
			CType(Me.Label26, ISupportInitialize).BeginInit()
			CType(Me.Label27, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod1, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod2, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod3, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod4, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod5, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod6, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod7, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod8, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod9, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod10, ISupportInitialize).BeginInit()
			CType(Me.Label38, ISupportInitialize).BeginInit()
			CType(Me.Label39, ISupportInitialize).BeginInit()
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
			CType(Me.lblGuide11, ISupportInitialize).BeginInit()
			CType(Me.lblGuide12, ISupportInitialize).BeginInit()
			CType(Me.lblGuide13, ISupportInitialize).BeginInit()
			CType(Me.lblGuide14, ISupportInitialize).BeginInit()
			CType(Me.lblGuide15, ISupportInitialize).BeginInit()
			CType(Me.lblGuide16, ISupportInitialize).BeginInit()
			CType(Me.lblGuide17, ISupportInitialize).BeginInit()
			CType(Me.lblGuide18, ISupportInitialize).BeginInit()
			CType(Me.lblGuide19, ISupportInitialize).BeginInit()
			CType(Me.lblGuide20, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide11, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide12, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide13, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide14, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide15, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide16, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide17, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide18, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide19, ISupportInitialize).BeginInit()
			CType(Me.lblCostPerGuide20, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod11, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod12, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod13, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod14, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod15, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod16, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod17, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod18, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod19, ISupportInitialize).BeginInit()
			CType(Me.lblGuidePerRod20, ISupportInitialize).BeginInit()
			CType(Me.lblNumRodsHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblNumRodsHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods1, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods2, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods3, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods4, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods5, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods6, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods7, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods8, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods9, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods10, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods11, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods12, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods13, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods14, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods15, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods17, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods16, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods18, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods19, ISupportInitialize).BeginInit()
			CType(Me.lblNumRods20, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Height = 0.2076389F
			Me.Detail.Name = "Detail"
			Me.PageHeader.Controls.AddRange(New ARControl() { Me.lblCost8, Me.lblCost10, Me.lblCost9, Me.lblCost7, Me.lblRodStringDesign, Me.Line11, Me.lblRodDiamHdrTop, Me.lblRodDiamHdrBot, Me.lblRodDiam1, Me.lblRodGradeHdrTop, Me.lblRodGradeHdrBot, Me.lblRodLengthHdrTop, Me.lblRodLengthHdrBot, Me.Line12, Me.lblRodDiam2, Me.lblRodDiam3, Me.lblRodDiam4, Me.lblRodDiam5, Me.lblRodDiam6, Me.lblRodDiam7, Me.lblRodDiam8, Me.lblRodGrade1, Me.lblRodGrade2, Me.lblRodGrade3, Me.lblRodGrade4, Me.lblRodGrade5, Me.lblRodGrade6, Me.lblRodGrade7, Me.lblRodGrade8, Me.lblRodLength1, Me.lblRodLength2, Me.lblRodLength3, Me.lblRodLength4, Me.lblRodLength5, Me.lblRodLength6, Me.lblRodLength7, Me.lblRodLength8, Me.linRSInputSep1, Me.linRSInputSep2, Me.linRSInputSep3, Me.lblTotalCost1, Me.lblTotalCost2, Me.lblTotalCost3, Me.lblTotalCost4, Me.lblTotalCost5, Me.lblTotalCost6, Me.lblTotalCost7, Me.lblTotalCost8, Me.Line13, Me.Label9, Me.Label10, Me.lblTotalRSCost2, Me.lblPumpingUnitDesign, Me.lblTotalPUCost2, Me.lblTotalPUCost, Me.lblManufacturer, Me.lblAPISize, Me.lblUnitName, Me.lblCost1, Me.lblCost2, Me.lblCost3, Me.lblCost4, Me.lblCost5, Me.lblCost6, Me.Line15, Me.Label23, Me.lblCostHdrBot, Me.lblTotalRSCost, Me.lblAddCosts, Me.lblAddCosts2, Me.Line16, Me.lblComment, Me.lblTitle1, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserName, Me.lblUserDate, Me.lblRodDiam9, Me.lblRodGrade9, Me.lblRodLength9, Me.lblTotalCost9, Me.lblRodDiam10, Me.lblRodGrade10, Me.lblRodLength10, Me.lblTotalCost10, Me.Line14, Me.lblLabel2, Me.lblCompany, Me.lblWellName, Me.lblDiskFile, Me.lblSecondCompanyName, Me.lblSecondCompanyPhonenumber, Me.lblGoTheta, Me.lblGuide1, Me.lblGuide2, Me.lblGuide3, Me.lblGuide4, Me.lblGuide5, Me.lblGuide6, Me.lblGuide7, Me.lblGuide8, Me.lblGuide9, Me.lblGuide10, Me.Label13, Me.Label14, Me.lblCostPerGuide1, Me.lblCostPerGuide2, Me.lblCostPerGuide3, Me.lblCostPerGuide4, Me.lblCostPerGuide5, Me.lblCostPerGuide6, Me.lblCostPerGuide7, Me.lblCostPerGuide8, Me.lblCostPerGuide9, Me.lblCostPerGuide10, Me.Label26, Me.Label27, Me.lblGuidePerRod1, Me.lblGuidePerRod2, Me.lblGuidePerRod3, Me.lblGuidePerRod4, Me.lblGuidePerRod5, Me.lblGuidePerRod6, Me.lblGuidePerRod7, Me.lblGuidePerRod8, Me.lblGuidePerRod9, Me.lblGuidePerRod10, Me.Label38, Me.Label39, Me.Line1, Me.Line2, Me.Line3, Me.lblCost18, Me.lblCost20, Me.lblCost19, Me.lblCost17, Me.lblRodDiam11, Me.lblRodDiam12, Me.lblRodDiam13, Me.lblRodDiam14, Me.lblRodDiam15, Me.lblRodDiam16, Me.lblRodDiam17, Me.lblRodDiam18, Me.lblRodGrade11, Me.lblRodGrade12, Me.lblRodGrade13, Me.lblRodGrade14, Me.lblRodGrade15, Me.lblRodGrade16, Me.lblRodGrade17, Me.lblRodGrade18, Me.lblRodLength11, Me.lblRodLength12, Me.lblRodLength13, Me.lblRodLength14, Me.lblRodLength15, Me.lblRodLength16, Me.lblRodLength17, Me.lblRodLength18, Me.lblTotalCost11, Me.lblTotalCost12, Me.lblTotalCost13, Me.lblTotalCost14, Me.lblTotalCost15, Me.lblTotalCost16, Me.lblTotalCost17, Me.lblTotalCost18, Me.lblCost11, Me.lblCost12, Me.lblCost13, Me.lblCost14, Me.lblCost15, Me.lblCost16, Me.lblRodDiam19, Me.lblRodGrade19, Me.lblRodLength19, Me.lblTotalCost19, Me.lblRodDiam20, Me.lblRodGrade20, Me.lblRodLength20, Me.lblTotalCost20, Me.lblGuide11, Me.lblGuide12, Me.lblGuide13, Me.lblGuide14, Me.lblGuide15, Me.lblGuide16, Me.lblGuide17, Me.lblGuide18, Me.lblGuide19, Me.lblGuide20, Me.lblCostPerGuide11, Me.lblCostPerGuide12, Me.lblCostPerGuide13, Me.lblCostPerGuide14, Me.lblCostPerGuide15, Me.lblCostPerGuide16, Me.lblCostPerGuide17, Me.lblCostPerGuide18, Me.lblCostPerGuide19, Me.lblCostPerGuide20, Me.lblGuidePerRod11, Me.lblGuidePerRod12, Me.lblGuidePerRod13, Me.lblGuidePerRod14, Me.lblGuidePerRod15, Me.lblGuidePerRod16, Me.lblGuidePerRod17, Me.lblGuidePerRod18, Me.lblGuidePerRod19, Me.lblGuidePerRod20, Me.Line4, Me.lblNumRodsHdrTop, Me.lblNumRodsHdrBot, Me.lblNumRods1, Me.lblNumRods2, Me.lblNumRods3, Me.lblNumRods4, Me.lblNumRods5, Me.lblNumRods6, Me.lblNumRods7, Me.lblNumRods8, Me.lblNumRods9, Me.lblNumRods10, Me.lblNumRods11, Me.lblNumRods12, Me.lblNumRods13, Me.lblNumRods14, Me.lblNumRods15, Me.lblNumRods17, Me.lblNumRods16, Me.lblNumRods18, Me.lblNumRods19, Me.lblNumRods20 })
			Me.PageHeader.Height = 6.489584F
			Me.PageHeader.Name = "PageHeader"
			Me.lblCost8.Height = 0.145F
			Me.lblCost8.HyperLink = Nothing
			Me.lblCost8.Left = 3.319F
			Me.lblCost8.Name = "lblCost8"
			Me.lblCost8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost8.Text = "N/A"
			Me.lblCost8.Top = 2.97F
			Me.lblCost8.Visible = False
			Me.lblCost8.Width = 0.5F
			Me.lblCost10.Height = 0.145F
			Me.lblCost10.HyperLink = Nothing
			Me.lblCost10.Left = 3.319F
			Me.lblCost10.Name = "lblCost10"
			Me.lblCost10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost10.Text = "N/A"
			Me.lblCost10.Top = 3.28F
			Me.lblCost10.Visible = False
			Me.lblCost10.Width = 0.5F
			Me.lblCost9.Height = 0.145F
			Me.lblCost9.HyperLink = Nothing
			Me.lblCost9.Left = 3.319F
			Me.lblCost9.Name = "lblCost9"
			Me.lblCost9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost9.Text = "N/A"
			Me.lblCost9.Top = 3.125F
			Me.lblCost9.Visible = False
			Me.lblCost9.Width = 0.5F
			Me.lblCost7.Height = 0.145F
			Me.lblCost7.HyperLink = Nothing
			Me.lblCost7.Left = 3.319F
			Me.lblCost7.Name = "lblCost7"
			Me.lblCost7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost7.Text = "N/A"
			Me.lblCost7.Top = 2.815F
			Me.lblCost7.Visible = False
			Me.lblCost7.Width = 0.5F
			Me.lblRodStringDesign.Height = 0.145F
			Me.lblRodStringDesign.HyperLink = Nothing
			Me.lblRodStringDesign.Left = 0.312F
			Me.lblRodStringDesign.Name = "lblRodStringDesign"
			Me.lblRodStringDesign.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodStringDesign.Text = "ROD STRING COST ANALYSIS"
			Me.lblRodStringDesign.Top = 1.22F
			Me.lblRodStringDesign.Width = 7.5655F
			Me.Line11.Height = 0F
			Me.Line11.Left = 0.313F
			Me.Line11.LineWeight = 1F
			Me.Line11.Name = "Line11"
			Me.Line11.Top = 1.388F
			Me.Line11.Width = 7.557F
			Me.Line11.X1 = 0.313F
			Me.Line11.X2 = 7.87F
			Me.Line11.Y1 = 1.388F
			Me.Line11.Y2 = 1.388F
			Me.lblRodDiamHdrTop.Height = 0.1569999F
			Me.lblRodDiamHdrTop.HyperLink = Nothing
			Me.lblRodDiamHdrTop.Left = 0.382F
			Me.lblRodDiamHdrTop.Name = "lblRodDiamHdrTop"
			Me.lblRodDiamHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiamHdrTop.Text = "Diameter"
			Me.lblRodDiamHdrTop.Top = 1.438F
			Me.lblRodDiamHdrTop.Width = 0.6874999F
			Me.lblRodDiamHdrBot.Height = 0.1569999F
			Me.lblRodDiamHdrBot.HyperLink = Nothing
			Me.lblRodDiamHdrBot.Left = 0.382F
			Me.lblRodDiamHdrBot.Name = "lblRodDiamHdrBot"
			Me.lblRodDiamHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiamHdrBot.Text = "(inches)"
			Me.lblRodDiamHdrBot.Top = 1.605F
			Me.lblRodDiamHdrBot.Width = 0.6875F
			Me.lblRodDiam1.Height = 0.145F
			Me.lblRodDiam1.HyperLink = Nothing
			Me.lblRodDiam1.Left = 0.382F
			Me.lblRodDiam1.Name = "lblRodDiam1"
			Me.lblRodDiam1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam1.Text = "Diam"
			Me.lblRodDiam1.Top = 1.875F
			Me.lblRodDiam1.Visible = False
			Me.lblRodDiam1.Width = 0.6875F
			Me.lblRodGradeHdrTop.Height = 0.1569999F
			Me.lblRodGradeHdrTop.HyperLink = Nothing
			Me.lblRodGradeHdrTop.Left = 1.194444F
			Me.lblRodGradeHdrTop.Name = "lblRodGradeHdrTop"
			Me.lblRodGradeHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGradeHdrTop.Text = "Rod"
			Me.lblRodGradeHdrTop.Top = 1.438F
			Me.lblRodGradeHdrTop.Width = 0.875F
			Me.lblRodGradeHdrBot.Height = 0.1569999F
			Me.lblRodGradeHdrBot.HyperLink = Nothing
			Me.lblRodGradeHdrBot.Left = 1.194444F
			Me.lblRodGradeHdrBot.Name = "lblRodGradeHdrBot"
			Me.lblRodGradeHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGradeHdrBot.Text = "Grade"
			Me.lblRodGradeHdrBot.Top = 1.605F
			Me.lblRodGradeHdrBot.Width = 0.875F
			Me.lblRodLengthHdrTop.Height = 0.1569999F
			Me.lblRodLengthHdrTop.HyperLink = Nothing
			Me.lblRodLengthHdrTop.Left = 2.194444F
			Me.lblRodLengthHdrTop.Name = "lblRodLengthHdrTop"
			Me.lblRodLengthHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodLengthHdrTop.Text = "Length"
			Me.lblRodLengthHdrTop.Top = 1.438F
			Me.lblRodLengthHdrTop.Width = 0.5F
			Me.lblRodLengthHdrBot.Height = 0.1569999F
			Me.lblRodLengthHdrBot.HyperLink = Nothing
			Me.lblRodLengthHdrBot.Left = 2.194444F
			Me.lblRodLengthHdrBot.Name = "lblRodLengthHdrBot"
			Me.lblRodLengthHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodLengthHdrBot.Text = "(ft)"
			Me.lblRodLengthHdrBot.Top = 1.605F
			Me.lblRodLengthHdrBot.Width = 0.5F
			Me.Line12.Height = 0F
			Me.Line12.Left = 0.313F
			Me.Line12.LineWeight = 1F
			Me.Line12.Name = "Line12"
			Me.Line12.Top = 1.8125F
			Me.Line12.Width = 7.557F
			Me.Line12.X1 = 0.313F
			Me.Line12.X2 = 7.87F
			Me.Line12.Y1 = 1.8125F
			Me.Line12.Y2 = 1.8125F
			Me.lblRodDiam2.Height = 0.145F
			Me.lblRodDiam2.HyperLink = Nothing
			Me.lblRodDiam2.Left = 0.3814447F
			Me.lblRodDiam2.Name = "lblRodDiam2"
			Me.lblRodDiam2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam2.Text = "Diam"
			Me.lblRodDiam2.Top = 2.03F
			Me.lblRodDiam2.Visible = False
			Me.lblRodDiam2.Width = 0.6875F
			Me.lblRodDiam3.Height = 0.145F
			Me.lblRodDiam3.HyperLink = Nothing
			Me.lblRodDiam3.Left = 0.3814447F
			Me.lblRodDiam3.Name = "lblRodDiam3"
			Me.lblRodDiam3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam3.Text = "Diam"
			Me.lblRodDiam3.Top = 2.185F
			Me.lblRodDiam3.Visible = False
			Me.lblRodDiam3.Width = 0.6875F
			Me.lblRodDiam4.Height = 0.145F
			Me.lblRodDiam4.HyperLink = Nothing
			Me.lblRodDiam4.Left = 0.3814447F
			Me.lblRodDiam4.Name = "lblRodDiam4"
			Me.lblRodDiam4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam4.Text = "Diam"
			Me.lblRodDiam4.Top = 2.34F
			Me.lblRodDiam4.Visible = False
			Me.lblRodDiam4.Width = 0.6875F
			Me.lblRodDiam5.Height = 0.145F
			Me.lblRodDiam5.HyperLink = Nothing
			Me.lblRodDiam5.Left = 0.3814447F
			Me.lblRodDiam5.Name = "lblRodDiam5"
			Me.lblRodDiam5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam5.Text = "Diam"
			Me.lblRodDiam5.Top = 2.495F
			Me.lblRodDiam5.Visible = False
			Me.lblRodDiam5.Width = 0.6875F
			Me.lblRodDiam6.Height = 0.145F
			Me.lblRodDiam6.HyperLink = Nothing
			Me.lblRodDiam6.Left = 0.381F
			Me.lblRodDiam6.Name = "lblRodDiam6"
			Me.lblRodDiam6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam6.Text = "Diam"
			Me.lblRodDiam6.Top = 2.66F
			Me.lblRodDiam6.Visible = False
			Me.lblRodDiam6.Width = 0.6875F
			Me.lblRodDiam7.Height = 0.145F
			Me.lblRodDiam7.HyperLink = Nothing
			Me.lblRodDiam7.Left = 0.3814447F
			Me.lblRodDiam7.Name = "lblRodDiam7"
			Me.lblRodDiam7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam7.Text = "Diam"
			Me.lblRodDiam7.Top = 2.815F
			Me.lblRodDiam7.Visible = False
			Me.lblRodDiam7.Width = 0.6875F
			Me.lblRodDiam8.Height = 0.145F
			Me.lblRodDiam8.HyperLink = Nothing
			Me.lblRodDiam8.Left = 0.3814447F
			Me.lblRodDiam8.Name = "lblRodDiam8"
			Me.lblRodDiam8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam8.Text = "Diam"
			Me.lblRodDiam8.Top = 2.97F
			Me.lblRodDiam8.Visible = False
			Me.lblRodDiam8.Width = 0.6875F
			Me.lblRodGrade1.Height = 0.145F
			Me.lblRodGrade1.HyperLink = Nothing
			Me.lblRodGrade1.Left = 1.194444F
			Me.lblRodGrade1.Name = "lblRodGrade1"
			Me.lblRodGrade1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade1.Text = "Grade"
			Me.lblRodGrade1.Top = 1.875F
			Me.lblRodGrade1.Visible = False
			Me.lblRodGrade1.Width = 0.875F
			Me.lblRodGrade2.Height = 0.145F
			Me.lblRodGrade2.HyperLink = Nothing
			Me.lblRodGrade2.Left = 1.193944F
			Me.lblRodGrade2.Name = "lblRodGrade2"
			Me.lblRodGrade2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade2.Text = "Grade"
			Me.lblRodGrade2.Top = 2.03F
			Me.lblRodGrade2.Visible = False
			Me.lblRodGrade2.Width = 0.875F
			Me.lblRodGrade3.Height = 0.145F
			Me.lblRodGrade3.HyperLink = Nothing
			Me.lblRodGrade3.Left = 1.193944F
			Me.lblRodGrade3.Name = "lblRodGrade3"
			Me.lblRodGrade3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade3.Text = "Grade"
			Me.lblRodGrade3.Top = 2.185F
			Me.lblRodGrade3.Visible = False
			Me.lblRodGrade3.Width = 0.875F
			Me.lblRodGrade4.Height = 0.145F
			Me.lblRodGrade4.HyperLink = Nothing
			Me.lblRodGrade4.Left = 1.193944F
			Me.lblRodGrade4.Name = "lblRodGrade4"
			Me.lblRodGrade4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade4.Text = "Grade"
			Me.lblRodGrade4.Top = 2.34F
			Me.lblRodGrade4.Visible = False
			Me.lblRodGrade4.Width = 0.875F
			Me.lblRodGrade5.Height = 0.145F
			Me.lblRodGrade5.HyperLink = Nothing
			Me.lblRodGrade5.Left = 1.193944F
			Me.lblRodGrade5.Name = "lblRodGrade5"
			Me.lblRodGrade5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade5.Text = "Grade"
			Me.lblRodGrade5.Top = 2.495F
			Me.lblRodGrade5.Visible = False
			Me.lblRodGrade5.Width = 0.875F
			Me.lblRodGrade6.Height = 0.145F
			Me.lblRodGrade6.HyperLink = Nothing
			Me.lblRodGrade6.Left = 1.194F
			Me.lblRodGrade6.Name = "lblRodGrade6"
			Me.lblRodGrade6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade6.Text = "Grade"
			Me.lblRodGrade6.Top = 2.66F
			Me.lblRodGrade6.Visible = False
			Me.lblRodGrade6.Width = 0.875F
			Me.lblRodGrade7.Height = 0.145F
			Me.lblRodGrade7.HyperLink = Nothing
			Me.lblRodGrade7.Left = 1.193944F
			Me.lblRodGrade7.Name = "lblRodGrade7"
			Me.lblRodGrade7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade7.Text = "Grade"
			Me.lblRodGrade7.Top = 2.815F
			Me.lblRodGrade7.Visible = False
			Me.lblRodGrade7.Width = 0.875F
			Me.lblRodGrade8.Height = 0.145F
			Me.lblRodGrade8.HyperLink = Nothing
			Me.lblRodGrade8.Left = 1.193944F
			Me.lblRodGrade8.Name = "lblRodGrade8"
			Me.lblRodGrade8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade8.Text = "Grade"
			Me.lblRodGrade8.Top = 2.97F
			Me.lblRodGrade8.Visible = False
			Me.lblRodGrade8.Width = 0.875F
			Me.lblRodLength1.Height = 0.145F
			Me.lblRodLength1.HyperLink = Nothing
			Me.lblRodLength1.Left = 2.194444F
			Me.lblRodLength1.Name = "lblRodLength1"
			Me.lblRodLength1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength1.Text = "Len"
			Me.lblRodLength1.Top = 1.875F
			Me.lblRodLength1.Visible = False
			Me.lblRodLength1.Width = 0.4930553F
			Me.lblRodLength2.Height = 0.145F
			Me.lblRodLength2.HyperLink = Nothing
			Me.lblRodLength2.Left = 2.193944F
			Me.lblRodLength2.Name = "lblRodLength2"
			Me.lblRodLength2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength2.Text = "Len"
			Me.lblRodLength2.Top = 2.03F
			Me.lblRodLength2.Visible = False
			Me.lblRodLength2.Width = 0.4930553F
			Me.lblRodLength3.Height = 0.145F
			Me.lblRodLength3.HyperLink = Nothing
			Me.lblRodLength3.Left = 2.193944F
			Me.lblRodLength3.Name = "lblRodLength3"
			Me.lblRodLength3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength3.Text = "Len"
			Me.lblRodLength3.Top = 2.185F
			Me.lblRodLength3.Visible = False
			Me.lblRodLength3.Width = 0.4930553F
			Me.lblRodLength4.Height = 0.145F
			Me.lblRodLength4.HyperLink = Nothing
			Me.lblRodLength4.Left = 2.193944F
			Me.lblRodLength4.Name = "lblRodLength4"
			Me.lblRodLength4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength4.Text = "Len"
			Me.lblRodLength4.Top = 2.34F
			Me.lblRodLength4.Visible = False
			Me.lblRodLength4.Width = 0.4930553F
			Me.lblRodLength5.Height = 0.145F
			Me.lblRodLength5.HyperLink = Nothing
			Me.lblRodLength5.Left = 2.193944F
			Me.lblRodLength5.Name = "lblRodLength5"
			Me.lblRodLength5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength5.Text = "Len"
			Me.lblRodLength5.Top = 2.495F
			Me.lblRodLength5.Visible = False
			Me.lblRodLength5.Width = 0.4930553F
			Me.lblRodLength6.Height = 0.145F
			Me.lblRodLength6.HyperLink = Nothing
			Me.lblRodLength6.Left = 2.194F
			Me.lblRodLength6.Name = "lblRodLength6"
			Me.lblRodLength6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength6.Text = "Len"
			Me.lblRodLength6.Top = 2.66F
			Me.lblRodLength6.Visible = False
			Me.lblRodLength6.Width = 0.4930553F
			Me.lblRodLength7.Height = 0.145F
			Me.lblRodLength7.HyperLink = Nothing
			Me.lblRodLength7.Left = 2.193944F
			Me.lblRodLength7.Name = "lblRodLength7"
			Me.lblRodLength7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength7.Text = "Len"
			Me.lblRodLength7.Top = 2.815F
			Me.lblRodLength7.Visible = False
			Me.lblRodLength7.Width = 0.4930553F
			Me.lblRodLength8.Height = 0.145F
			Me.lblRodLength8.HyperLink = Nothing
			Me.lblRodLength8.Left = 2.193944F
			Me.lblRodLength8.Name = "lblRodLength8"
			Me.lblRodLength8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength8.Text = "Len"
			Me.lblRodLength8.Top = 2.97F
			Me.lblRodLength8.Visible = False
			Me.lblRodLength8.Width = 0.4930553F
			Me.linRSInputSep1.Height = 3.682F
			Me.linRSInputSep1.Left = 1.131F
			Me.linRSInputSep1.LineWeight = 1F
			Me.linRSInputSep1.Name = "linRSInputSep1"
			Me.linRSInputSep1.Top = 1.398F
			Me.linRSInputSep1.Width = 0F
			Me.linRSInputSep1.X1 = 1.131F
			Me.linRSInputSep1.X2 = 1.131F
			Me.linRSInputSep1.Y1 = 1.398F
			Me.linRSInputSep1.Y2 = 5.08F
			Me.linRSInputSep2.Height = 3.682F
			Me.linRSInputSep2.Left = 2.131F
			Me.linRSInputSep2.LineWeight = 1F
			Me.linRSInputSep2.Name = "linRSInputSep2"
			Me.linRSInputSep2.Top = 1.398F
			Me.linRSInputSep2.Width = 0F
			Me.linRSInputSep2.X1 = 2.131F
			Me.linRSInputSep2.X2 = 2.131F
			Me.linRSInputSep2.Y1 = 1.398F
			Me.linRSInputSep2.Y2 = 5.08F
			Me.linRSInputSep3.Height = 3.682F
			Me.linRSInputSep3.Left = 2.756F
			Me.linRSInputSep3.LineWeight = 1F
			Me.linRSInputSep3.Name = "linRSInputSep3"
			Me.linRSInputSep3.Top = 1.398F
			Me.linRSInputSep3.Width = 0F
			Me.linRSInputSep3.X1 = 2.756F
			Me.linRSInputSep3.X2 = 2.756F
			Me.linRSInputSep3.Y1 = 1.398F
			Me.linRSInputSep3.Y2 = 5.08F
			Me.lblTotalCost1.Height = 0.145F
			Me.lblTotalCost1.HyperLink = Nothing
			Me.lblTotalCost1.Left = 6.788F
			Me.lblTotalCost1.Name = "lblTotalCost1"
			Me.lblTotalCost1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost1.Text = "N/A"
			Me.lblTotalCost1.Top = 1.885F
			Me.lblTotalCost1.Visible = False
			Me.lblTotalCost1.Width = 1F
			Me.lblTotalCost2.Height = 0.145F
			Me.lblTotalCost2.HyperLink = Nothing
			Me.lblTotalCost2.Left = 6.788F
			Me.lblTotalCost2.Name = "lblTotalCost2"
			Me.lblTotalCost2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost2.Text = "N/A"
			Me.lblTotalCost2.Top = 2.04F
			Me.lblTotalCost2.Visible = False
			Me.lblTotalCost2.Width = 1F
			Me.lblTotalCost3.Height = 0.145F
			Me.lblTotalCost3.HyperLink = Nothing
			Me.lblTotalCost3.Left = 6.788F
			Me.lblTotalCost3.Name = "lblTotalCost3"
			Me.lblTotalCost3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost3.Text = "N/A"
			Me.lblTotalCost3.Top = 2.195F
			Me.lblTotalCost3.Visible = False
			Me.lblTotalCost3.Width = 1F
			Me.lblTotalCost4.Height = 0.145F
			Me.lblTotalCost4.HyperLink = Nothing
			Me.lblTotalCost4.Left = 6.788F
			Me.lblTotalCost4.Name = "lblTotalCost4"
			Me.lblTotalCost4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost4.Text = "N/A"
			Me.lblTotalCost4.Top = 2.35F
			Me.lblTotalCost4.Visible = False
			Me.lblTotalCost4.Width = 1F
			Me.lblTotalCost5.Height = 0.145F
			Me.lblTotalCost5.HyperLink = Nothing
			Me.lblTotalCost5.Left = 6.788F
			Me.lblTotalCost5.Name = "lblTotalCost5"
			Me.lblTotalCost5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost5.Text = "N/A"
			Me.lblTotalCost5.Top = 2.505F
			Me.lblTotalCost5.Visible = False
			Me.lblTotalCost5.Width = 1F
			Me.lblTotalCost6.Height = 0.145F
			Me.lblTotalCost6.HyperLink = Nothing
			Me.lblTotalCost6.Left = 6.788F
			Me.lblTotalCost6.Name = "lblTotalCost6"
			Me.lblTotalCost6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost6.Text = "N/A"
			Me.lblTotalCost6.Top = 2.659999F
			Me.lblTotalCost6.Visible = False
			Me.lblTotalCost6.Width = 1F
			Me.lblTotalCost7.Height = 0.145F
			Me.lblTotalCost7.HyperLink = Nothing
			Me.lblTotalCost7.Left = 6.788F
			Me.lblTotalCost7.Name = "lblTotalCost7"
			Me.lblTotalCost7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost7.Text = "N/A"
			Me.lblTotalCost7.Top = 2.824999F
			Me.lblTotalCost7.Visible = False
			Me.lblTotalCost7.Width = 1F
			Me.lblTotalCost8.Height = 0.145F
			Me.lblTotalCost8.HyperLink = Nothing
			Me.lblTotalCost8.Left = 6.788F
			Me.lblTotalCost8.Name = "lblTotalCost8"
			Me.lblTotalCost8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost8.Text = "N/A"
			Me.lblTotalCost8.Top = 2.979999F
			Me.lblTotalCost8.Visible = False
			Me.lblTotalCost8.Width = 1F
			Me.Line13.Height = 3.682F
			Me.Line13.Left = 3.881F
			Me.Line13.LineWeight = 1F
			Me.Line13.Name = "Line13"
			Me.Line13.Top = 1.398F
			Me.Line13.Width = 0F
			Me.Line13.X1 = 3.881F
			Me.Line13.X2 = 3.881F
			Me.Line13.Y1 = 1.398F
			Me.Line13.Y2 = 5.08F
			Me.Label9.Height = 0.1569999F
			Me.Label9.HyperLink = Nothing
			Me.Label9.Left = 6.788F
			Me.Label9.Name = "Label9"
			Me.Label9.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.Label9.Text = "Total Cost"
			Me.Label9.Top = 1.438F
			Me.Label9.Width = 1F
			Me.Label10.Height = 0.1569999F
			Me.Label10.HyperLink = Nothing
			Me.Label10.Left = 6.788F
			Me.Label10.Name = "Label10"
			Me.Label10.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.Label10.Text = "($)"
			Me.Label10.Top = 1.605F
			Me.Label10.Width = 1F
			Me.lblTotalRSCost2.Height = 0.15F
			Me.lblTotalRSCost2.HyperLink = Nothing
			Me.lblTotalRSCost2.Left = 6.788F
			Me.lblTotalRSCost2.Name = "lblTotalRSCost2"
			Me.lblTotalRSCost2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalRSCost2.Text = "N/A"
			Me.lblTotalRSCost2.Top = 5.268F
			Me.lblTotalRSCost2.Width = 1F
			Me.lblPumpingUnitDesign.Height = 0.145F
			Me.lblPumpingUnitDesign.HyperLink = Nothing
			Me.lblPumpingUnitDesign.Left = 0.312F
			Me.lblPumpingUnitDesign.Name = "lblPumpingUnitDesign"
			Me.lblPumpingUnitDesign.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPumpingUnitDesign.Text = "PUMPING UNIT COST ANALYSIS"
			Me.lblPumpingUnitDesign.Top = 5.58F
			Me.lblPumpingUnitDesign.Width = 7.5655F
			Me.lblTotalPUCost2.Height = 0.15F
			Me.lblTotalPUCost2.HyperLink = Nothing
			Me.lblTotalPUCost2.Left = 3.97F
			Me.lblTotalPUCost2.Name = "lblTotalPUCost2"
			Me.lblTotalPUCost2.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblTotalPUCost2.Text = "N/A"
			Me.lblTotalPUCost2.Top = 6.108F
			Me.lblTotalPUCost2.Width = 1F
			Me.lblTotalPUCost.Height = 0.15F
			Me.lblTotalPUCost.HyperLink = Nothing
			Me.lblTotalPUCost.Left = 2.875F
			Me.lblTotalPUCost.Name = "lblTotalPUCost"
			Me.lblTotalPUCost.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblTotalPUCost.Text = "Total ($):"
			Me.lblTotalPUCost.Top = 6.108F
			Me.lblTotalPUCost.Width = 1F
			Me.lblManufacturer.Height = 0.15F
			Me.lblManufacturer.HyperLink = Nothing
			Me.lblManufacturer.Left = 0.375F
			Me.lblManufacturer.Name = "lblManufacturer"
			Me.lblManufacturer.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblManufacturer.Text = "Manufacturer:"
			Me.lblManufacturer.Top = 5.797998F
			Me.lblManufacturer.Width = 2.375F
			Me.lblAPISize.Height = 0.15F
			Me.lblAPISize.HyperLink = Nothing
			Me.lblAPISize.Left = 0.375F
			Me.lblAPISize.Name = "lblAPISize"
			Me.lblAPISize.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblAPISize.Text = "API Size :"
			Me.lblAPISize.Top = 5.953001F
			Me.lblAPISize.Width = 2.375F
			Me.lblUnitName.Height = 0.15F
			Me.lblUnitName.HyperLink = Nothing
			Me.lblUnitName.Left = 0.375F
			Me.lblUnitName.Name = "lblUnitName"
			Me.lblUnitName.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblUnitName.Text = "Unit name:"
			Me.lblUnitName.Top = 6.108F
			Me.lblUnitName.Width = 2.375F
			Me.lblCost1.Height = 0.145F
			Me.lblCost1.HyperLink = Nothing
			Me.lblCost1.Left = 3.319F
			Me.lblCost1.Name = "lblCost1"
			Me.lblCost1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost1.Text = "N/A"
			Me.lblCost1.Top = 1.875F
			Me.lblCost1.Visible = False
			Me.lblCost1.Width = 0.5F
			Me.lblCost2.Height = 0.145F
			Me.lblCost2.HyperLink = Nothing
			Me.lblCost2.Left = 3.319F
			Me.lblCost2.Name = "lblCost2"
			Me.lblCost2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost2.Text = "N/A"
			Me.lblCost2.Top = 2.03F
			Me.lblCost2.Visible = False
			Me.lblCost2.Width = 0.5F
			Me.lblCost3.Height = 0.145F
			Me.lblCost3.HyperLink = Nothing
			Me.lblCost3.Left = 3.319F
			Me.lblCost3.Name = "lblCost3"
			Me.lblCost3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost3.Text = "N/A"
			Me.lblCost3.Top = 2.185F
			Me.lblCost3.Visible = False
			Me.lblCost3.Width = 0.5F
			Me.lblCost4.Height = 0.145F
			Me.lblCost4.HyperLink = Nothing
			Me.lblCost4.Left = 3.319F
			Me.lblCost4.Name = "lblCost4"
			Me.lblCost4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost4.Text = "N/A"
			Me.lblCost4.Top = 2.34F
			Me.lblCost4.Visible = False
			Me.lblCost4.Width = 0.5F
			Me.lblCost5.Height = 0.145F
			Me.lblCost5.HyperLink = Nothing
			Me.lblCost5.Left = 3.319F
			Me.lblCost5.Name = "lblCost5"
			Me.lblCost5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost5.Text = "N/A"
			Me.lblCost5.Top = 2.495F
			Me.lblCost5.Visible = False
			Me.lblCost5.Width = 0.5F
			Me.lblCost6.Height = 0.145F
			Me.lblCost6.HyperLink = Nothing
			Me.lblCost6.Left = 3.319F
			Me.lblCost6.Name = "lblCost6"
			Me.lblCost6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost6.Text = "N/A"
			Me.lblCost6.Top = 2.66F
			Me.lblCost6.Visible = False
			Me.lblCost6.Width = 0.5F
			Me.Line15.Height = 3.687F
			Me.Line15.Left = 7.87F
			Me.Line15.LineWeight = 1F
			Me.Line15.Name = "Line15"
			Me.Line15.Top = 1.398F
			Me.Line15.Width = 0.006999969F
			Me.Line15.X1 = 7.87F
			Me.Line15.X2 = 7.877F
			Me.Line15.Y1 = 1.398F
			Me.Line15.Y2 = 5.085F
			Me.Label23.Height = 0.1569999F
			Me.Label23.HyperLink = Nothing
			Me.Label23.Left = 3.319F
			Me.Label23.Name = "Label23"
			Me.Label23.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.Label23.Text = "Cost"
			Me.Label23.Top = 1.438F
			Me.Label23.Width = 0.5F
			Me.lblCostHdrBot.Height = 0.1569999F
			Me.lblCostHdrBot.HyperLink = Nothing
			Me.lblCostHdrBot.Left = 3.319F
			Me.lblCostHdrBot.Name = "lblCostHdrBot"
			Me.lblCostHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblCostHdrBot.Text = "($/ft)"
			Me.lblCostHdrBot.Top = 1.605F
			Me.lblCostHdrBot.Width = 0.5F
			Me.lblTotalRSCost.Height = 0.15F
			Me.lblTotalRSCost.HyperLink = Nothing
			Me.lblTotalRSCost.Left = 5.7255F
			Me.lblTotalRSCost.Name = "lblTotalRSCost"
			Me.lblTotalRSCost.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblTotalRSCost.Text = "Total ($):"
			Me.lblTotalRSCost.Top = 5.268F
			Me.lblTotalRSCost.Width = 1F
			Me.lblAddCosts.Height = 0.15F
			Me.lblAddCosts.HyperLink = Nothing
			Me.lblAddCosts.Left = 5.413F
			Me.lblAddCosts.Name = "lblAddCosts"
			Me.lblAddCosts.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblAddCosts.Text = "Additional rod costs ($):"
			Me.lblAddCosts.Top = 5.113F
			Me.lblAddCosts.Visible = False
			Me.lblAddCosts.Width = 1.3125F
			Me.lblAddCosts2.Height = 0.15F
			Me.lblAddCosts2.HyperLink = Nothing
			Me.lblAddCosts2.Left = 6.788F
			Me.lblAddCosts2.Name = "lblAddCosts2"
			Me.lblAddCosts2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblAddCosts2.Text = "N/A"
			Me.lblAddCosts2.Top = 5.113F
			Me.lblAddCosts2.Visible = False
			Me.lblAddCosts2.Width = 1F
			Me.Line16.Height = 3.682F
			Me.Line16.Left = 0.3124998F
			Me.Line16.LineWeight = 1F
			Me.Line16.Name = "Line16"
			Me.Line16.Top = 1.398F
			Me.Line16.Width = 0.0005002022F
			Me.Line16.X1 = 0.313F
			Me.Line16.X2 = 0.3124998F
			Me.Line16.Y1 = 1.398F
			Me.Line16.Y2 = 5.08F
			Me.lblComment.Height = 0.2920001F
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
			Me.lblRodDiam9.Height = 0.145F
			Me.lblRodDiam9.HyperLink = Nothing
			Me.lblRodDiam9.Left = 0.3814447F
			Me.lblRodDiam9.Name = "lblRodDiam9"
			Me.lblRodDiam9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam9.Text = "Diam"
			Me.lblRodDiam9.Top = 3.125F
			Me.lblRodDiam9.Visible = False
			Me.lblRodDiam9.Width = 0.6875F
			Me.lblRodGrade9.Height = 0.145F
			Me.lblRodGrade9.HyperLink = Nothing
			Me.lblRodGrade9.Left = 1.193944F
			Me.lblRodGrade9.Name = "lblRodGrade9"
			Me.lblRodGrade9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade9.Text = "Grade"
			Me.lblRodGrade9.Top = 3.125F
			Me.lblRodGrade9.Visible = False
			Me.lblRodGrade9.Width = 0.875F
			Me.lblRodLength9.Height = 0.145F
			Me.lblRodLength9.HyperLink = Nothing
			Me.lblRodLength9.Left = 2.193944F
			Me.lblRodLength9.Name = "lblRodLength9"
			Me.lblRodLength9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength9.Text = "Len"
			Me.lblRodLength9.Top = 3.125F
			Me.lblRodLength9.Visible = False
			Me.lblRodLength9.Width = 0.4930553F
			Me.lblTotalCost9.Height = 0.145F
			Me.lblTotalCost9.HyperLink = Nothing
			Me.lblTotalCost9.Left = 6.788F
			Me.lblTotalCost9.Name = "lblTotalCost9"
			Me.lblTotalCost9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost9.Text = "N/A"
			Me.lblTotalCost9.Top = 3.134999F
			Me.lblTotalCost9.Visible = False
			Me.lblTotalCost9.Width = 1F
			Me.lblRodDiam10.Height = 0.145F
			Me.lblRodDiam10.HyperLink = Nothing
			Me.lblRodDiam10.Left = 0.3814447F
			Me.lblRodDiam10.Name = "lblRodDiam10"
			Me.lblRodDiam10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam10.Text = "Diam"
			Me.lblRodDiam10.Top = 3.28F
			Me.lblRodDiam10.Visible = False
			Me.lblRodDiam10.Width = 0.6875F
			Me.lblRodGrade10.Height = 0.145F
			Me.lblRodGrade10.HyperLink = Nothing
			Me.lblRodGrade10.Left = 1.193944F
			Me.lblRodGrade10.Name = "lblRodGrade10"
			Me.lblRodGrade10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade10.Text = "Grade"
			Me.lblRodGrade10.Top = 3.28F
			Me.lblRodGrade10.Visible = False
			Me.lblRodGrade10.Width = 0.875F
			Me.lblRodLength10.Height = 0.145F
			Me.lblRodLength10.HyperLink = Nothing
			Me.lblRodLength10.Left = 2.193944F
			Me.lblRodLength10.Name = "lblRodLength10"
			Me.lblRodLength10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength10.Text = "Len"
			Me.lblRodLength10.Top = 3.28F
			Me.lblRodLength10.Visible = False
			Me.lblRodLength10.Width = 0.4930553F
			Me.lblTotalCost10.Height = 0.145F
			Me.lblTotalCost10.HyperLink = Nothing
			Me.lblTotalCost10.Left = 6.788F
			Me.lblTotalCost10.Name = "lblTotalCost10"
			Me.lblTotalCost10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost10.Text = "N/A"
			Me.lblTotalCost10.Top = 3.289999F
			Me.lblTotalCost10.Visible = False
			Me.lblTotalCost10.Width = 1F
			Me.Line14.Height = 0F
			Me.Line14.Left = 0.312F
			Me.Line14.LineWeight = 1F
			Me.Line14.Name = "Line14"
			Me.Line14.Top = 5.08F
			Me.Line14.Width = 7.557F
			Me.Line14.X1 = 0.312F
			Me.Line14.X2 = 7.869F
			Me.Line14.Y1 = 5.08F
			Me.Line14.Y2 = 5.08F
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
			Me.lblGuide1.Height = 0.15F
			Me.lblGuide1.HyperLink = Nothing
			Me.lblGuide1.Left = 3.97F
			Me.lblGuide1.Name = "lblGuide1"
			Me.lblGuide1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide1.Text = "N/A"
			Me.lblGuide1.Top = 1.875F
			Me.lblGuide1.Visible = False
			Me.lblGuide1.Width = 1F
			Me.lblGuide2.Height = 0.15F
			Me.lblGuide2.HyperLink = Nothing
			Me.lblGuide2.Left = 3.9695F
			Me.lblGuide2.Name = "lblGuide2"
			Me.lblGuide2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide2.Text = "N/A"
			Me.lblGuide2.Top = 2.03F
			Me.lblGuide2.Visible = False
			Me.lblGuide2.Width = 1F
			Me.lblGuide3.Height = 0.15F
			Me.lblGuide3.HyperLink = Nothing
			Me.lblGuide3.Left = 3.9695F
			Me.lblGuide3.Name = "lblGuide3"
			Me.lblGuide3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide3.Text = "N/A"
			Me.lblGuide3.Top = 2.185F
			Me.lblGuide3.Visible = False
			Me.lblGuide3.Width = 1F
			Me.lblGuide4.Height = 0.14F
			Me.lblGuide4.HyperLink = Nothing
			Me.lblGuide4.Left = 3.9695F
			Me.lblGuide4.Name = "lblGuide4"
			Me.lblGuide4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide4.Text = "N/A"
			Me.lblGuide4.Top = 2.34F
			Me.lblGuide4.Visible = False
			Me.lblGuide4.Width = 1F
			Me.lblGuide5.Height = 0.14F
			Me.lblGuide5.HyperLink = Nothing
			Me.lblGuide5.Left = 3.9695F
			Me.lblGuide5.Name = "lblGuide5"
			Me.lblGuide5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide5.Text = "N/A"
			Me.lblGuide5.Top = 2.495F
			Me.lblGuide5.Visible = False
			Me.lblGuide5.Width = 1F
			Me.lblGuide6.Height = 0.14F
			Me.lblGuide6.HyperLink = Nothing
			Me.lblGuide6.Left = 3.97F
			Me.lblGuide6.Name = "lblGuide6"
			Me.lblGuide6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide6.Text = "N/A"
			Me.lblGuide6.Top = 2.66F
			Me.lblGuide6.Visible = False
			Me.lblGuide6.Width = 1F
			Me.lblGuide7.Height = 0.14F
			Me.lblGuide7.HyperLink = Nothing
			Me.lblGuide7.Left = 3.9695F
			Me.lblGuide7.Name = "lblGuide7"
			Me.lblGuide7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide7.Text = "N/A"
			Me.lblGuide7.Top = 2.814999F
			Me.lblGuide7.Visible = False
			Me.lblGuide7.Width = 1F
			Me.lblGuide8.Height = 0.14F
			Me.lblGuide8.HyperLink = Nothing
			Me.lblGuide8.Left = 3.9695F
			Me.lblGuide8.Name = "lblGuide8"
			Me.lblGuide8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide8.Text = "N/A"
			Me.lblGuide8.Top = 2.969999F
			Me.lblGuide8.Visible = False
			Me.lblGuide8.Width = 1F
			Me.lblGuide9.Height = 0.14F
			Me.lblGuide9.HyperLink = Nothing
			Me.lblGuide9.Left = 3.9695F
			Me.lblGuide9.Name = "lblGuide9"
			Me.lblGuide9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide9.Text = "N/A"
			Me.lblGuide9.Top = 3.124999F
			Me.lblGuide9.Visible = False
			Me.lblGuide9.Width = 1F
			Me.lblGuide10.Height = 0.14F
			Me.lblGuide10.HyperLink = Nothing
			Me.lblGuide10.Left = 3.9695F
			Me.lblGuide10.Name = "lblGuide10"
			Me.lblGuide10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide10.Text = "N/A"
			Me.lblGuide10.Top = 3.279999F
			Me.lblGuide10.Visible = False
			Me.lblGuide10.Width = 1F
			Me.Label13.Height = 0.1569999F
			Me.Label13.HyperLink = Nothing
			Me.Label13.Left = 3.97F
			Me.Label13.Name = "Label13"
			Me.Label13.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.Label13.Text = "Type"
			Me.Label13.Top = 1.605F
			Me.Label13.Width = 1F
			Me.Label14.Height = 0.1569999F
			Me.Label14.HyperLink = Nothing
			Me.Label14.Left = 3.97F
			Me.Label14.Name = "Label14"
			Me.Label14.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.Label14.Text = "Guide"
			Me.Label14.Top = 1.438F
			Me.Label14.Width = 1F
			Me.lblCostPerGuide1.Height = 0.145F
			Me.lblCostPerGuide1.HyperLink = Nothing
			Me.lblCostPerGuide1.Left = 5.99F
			Me.lblCostPerGuide1.Name = "lblCostPerGuide1"
			Me.lblCostPerGuide1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide1.Text = "N/A"
			Me.lblCostPerGuide1.Top = 1.885F
			Me.lblCostPerGuide1.Visible = False
			Me.lblCostPerGuide1.Width = 0.671F
			Me.lblCostPerGuide2.Height = 0.145F
			Me.lblCostPerGuide2.HyperLink = Nothing
			Me.lblCostPerGuide2.Left = 5.9895F
			Me.lblCostPerGuide2.Name = "lblCostPerGuide2"
			Me.lblCostPerGuide2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide2.Text = "N/A"
			Me.lblCostPerGuide2.Top = 2.04F
			Me.lblCostPerGuide2.Visible = False
			Me.lblCostPerGuide2.Width = 0.671F
			Me.lblCostPerGuide3.Height = 0.145F
			Me.lblCostPerGuide3.HyperLink = Nothing
			Me.lblCostPerGuide3.Left = 5.9895F
			Me.lblCostPerGuide3.Name = "lblCostPerGuide3"
			Me.lblCostPerGuide3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide3.Text = "N/A"
			Me.lblCostPerGuide3.Top = 2.195F
			Me.lblCostPerGuide3.Visible = False
			Me.lblCostPerGuide3.Width = 0.671F
			Me.lblCostPerGuide4.Height = 0.145F
			Me.lblCostPerGuide4.HyperLink = Nothing
			Me.lblCostPerGuide4.Left = 5.9895F
			Me.lblCostPerGuide4.Name = "lblCostPerGuide4"
			Me.lblCostPerGuide4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide4.Text = "N/A"
			Me.lblCostPerGuide4.Top = 2.35F
			Me.lblCostPerGuide4.Visible = False
			Me.lblCostPerGuide4.Width = 0.671F
			Me.lblCostPerGuide5.Height = 0.145F
			Me.lblCostPerGuide5.HyperLink = Nothing
			Me.lblCostPerGuide5.Left = 5.9895F
			Me.lblCostPerGuide5.Name = "lblCostPerGuide5"
			Me.lblCostPerGuide5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide5.Text = "N/A"
			Me.lblCostPerGuide5.Top = 2.505F
			Me.lblCostPerGuide5.Visible = False
			Me.lblCostPerGuide5.Width = 0.671F
			Me.lblCostPerGuide6.Height = 0.145F
			Me.lblCostPerGuide6.HyperLink = Nothing
			Me.lblCostPerGuide6.Left = 5.9895F
			Me.lblCostPerGuide6.Name = "lblCostPerGuide6"
			Me.lblCostPerGuide6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide6.Text = "N/A"
			Me.lblCostPerGuide6.Top = 2.659999F
			Me.lblCostPerGuide6.Visible = False
			Me.lblCostPerGuide6.Width = 0.671F
			Me.lblCostPerGuide7.Height = 0.145F
			Me.lblCostPerGuide7.HyperLink = Nothing
			Me.lblCostPerGuide7.Left = 5.9895F
			Me.lblCostPerGuide7.Name = "lblCostPerGuide7"
			Me.lblCostPerGuide7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide7.Text = "N/A"
			Me.lblCostPerGuide7.Top = 2.824999F
			Me.lblCostPerGuide7.Visible = False
			Me.lblCostPerGuide7.Width = 0.671F
			Me.lblCostPerGuide8.Height = 0.145F
			Me.lblCostPerGuide8.HyperLink = Nothing
			Me.lblCostPerGuide8.Left = 5.9895F
			Me.lblCostPerGuide8.Name = "lblCostPerGuide8"
			Me.lblCostPerGuide8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide8.Text = "N/A"
			Me.lblCostPerGuide8.Top = 2.979999F
			Me.lblCostPerGuide8.Visible = False
			Me.lblCostPerGuide8.Width = 0.671F
			Me.lblCostPerGuide9.Height = 0.145F
			Me.lblCostPerGuide9.HyperLink = Nothing
			Me.lblCostPerGuide9.Left = 5.9895F
			Me.lblCostPerGuide9.Name = "lblCostPerGuide9"
			Me.lblCostPerGuide9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide9.Text = "N/A"
			Me.lblCostPerGuide9.Top = 3.134999F
			Me.lblCostPerGuide9.Visible = False
			Me.lblCostPerGuide9.Width = 0.671F
			Me.lblCostPerGuide10.Height = 0.145F
			Me.lblCostPerGuide10.HyperLink = Nothing
			Me.lblCostPerGuide10.Left = 5.9895F
			Me.lblCostPerGuide10.Name = "lblCostPerGuide10"
			Me.lblCostPerGuide10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide10.Text = "N/A"
			Me.lblCostPerGuide10.Top = 3.289999F
			Me.lblCostPerGuide10.Visible = False
			Me.lblCostPerGuide10.Width = 0.671F
			Me.Label26.Height = 0.1569999F
			Me.Label26.HyperLink = Nothing
			Me.Label26.Left = 5.99F
			Me.Label26.Name = "Label26"
			Me.Label26.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.Label26.Text = "($/guide)"
			Me.Label26.Top = 1.605F
			Me.Label26.Width = 0.671F
			Me.Label27.Height = 0.1569999F
			Me.Label27.HyperLink = Nothing
			Me.Label27.Left = 5.99F
			Me.Label27.Name = "Label27"
			Me.Label27.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.Label27.Text = "Cost"
			Me.Label27.Top = 1.438F
			Me.Label27.Width = 0.671F
			Me.lblGuidePerRod1.Height = 0.145F
			Me.lblGuidePerRod1.HyperLink = Nothing
			Me.lblGuidePerRod1.Left = 5.13F
			Me.lblGuidePerRod1.Name = "lblGuidePerRod1"
			Me.lblGuidePerRod1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod1.Text = "N/A"
			Me.lblGuidePerRod1.Top = 1.877F
			Me.lblGuidePerRod1.Visible = False
			Me.lblGuidePerRod1.Width = 0.7130001F
			Me.lblGuidePerRod2.Height = 0.145F
			Me.lblGuidePerRod2.HyperLink = Nothing
			Me.lblGuidePerRod2.Left = 5.1295F
			Me.lblGuidePerRod2.Name = "lblGuidePerRod2"
			Me.lblGuidePerRod2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod2.Text = "N/A"
			Me.lblGuidePerRod2.Top = 2.032F
			Me.lblGuidePerRod2.Visible = False
			Me.lblGuidePerRod2.Width = 0.7130001F
			Me.lblGuidePerRod3.Height = 0.145F
			Me.lblGuidePerRod3.HyperLink = Nothing
			Me.lblGuidePerRod3.Left = 5.1295F
			Me.lblGuidePerRod3.Name = "lblGuidePerRod3"
			Me.lblGuidePerRod3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod3.Text = "N/A"
			Me.lblGuidePerRod3.Top = 2.186999F
			Me.lblGuidePerRod3.Visible = False
			Me.lblGuidePerRod3.Width = 0.7130001F
			Me.lblGuidePerRod4.Height = 0.145F
			Me.lblGuidePerRod4.HyperLink = Nothing
			Me.lblGuidePerRod4.Left = 5.1295F
			Me.lblGuidePerRod4.Name = "lblGuidePerRod4"
			Me.lblGuidePerRod4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod4.Text = "N/A"
			Me.lblGuidePerRod4.Top = 2.341999F
			Me.lblGuidePerRod4.Visible = False
			Me.lblGuidePerRod4.Width = 0.7130001F
			Me.lblGuidePerRod5.Height = 0.145F
			Me.lblGuidePerRod5.HyperLink = Nothing
			Me.lblGuidePerRod5.Left = 5.1295F
			Me.lblGuidePerRod5.Name = "lblGuidePerRod5"
			Me.lblGuidePerRod5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod5.Text = "N/A"
			Me.lblGuidePerRod5.Top = 2.496999F
			Me.lblGuidePerRod5.Visible = False
			Me.lblGuidePerRod5.Width = 0.7130001F
			Me.lblGuidePerRod6.Height = 0.145F
			Me.lblGuidePerRod6.HyperLink = Nothing
			Me.lblGuidePerRod6.Left = 5.1295F
			Me.lblGuidePerRod6.Name = "lblGuidePerRod6"
			Me.lblGuidePerRod6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod6.Text = "N/A"
			Me.lblGuidePerRod6.Top = 2.651999F
			Me.lblGuidePerRod6.Visible = False
			Me.lblGuidePerRod6.Width = 0.7130001F
			Me.lblGuidePerRod7.Height = 0.145F
			Me.lblGuidePerRod7.HyperLink = Nothing
			Me.lblGuidePerRod7.Left = 5.1295F
			Me.lblGuidePerRod7.Name = "lblGuidePerRod7"
			Me.lblGuidePerRod7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod7.Text = "N/A"
			Me.lblGuidePerRod7.Top = 2.816998F
			Me.lblGuidePerRod7.Visible = False
			Me.lblGuidePerRod7.Width = 0.7130001F
			Me.lblGuidePerRod8.Height = 0.145F
			Me.lblGuidePerRod8.HyperLink = Nothing
			Me.lblGuidePerRod8.Left = 5.1295F
			Me.lblGuidePerRod8.Name = "lblGuidePerRod8"
			Me.lblGuidePerRod8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod8.Text = "N/A"
			Me.lblGuidePerRod8.Top = 2.971998F
			Me.lblGuidePerRod8.Visible = False
			Me.lblGuidePerRod8.Width = 0.7130001F
			Me.lblGuidePerRod9.Height = 0.145F
			Me.lblGuidePerRod9.HyperLink = Nothing
			Me.lblGuidePerRod9.Left = 5.1295F
			Me.lblGuidePerRod9.Name = "lblGuidePerRod9"
			Me.lblGuidePerRod9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod9.Text = "N/A"
			Me.lblGuidePerRod9.Top = 3.126998F
			Me.lblGuidePerRod9.Visible = False
			Me.lblGuidePerRod9.Width = 0.7130001F
			Me.lblGuidePerRod10.Height = 0.145F
			Me.lblGuidePerRod10.HyperLink = Nothing
			Me.lblGuidePerRod10.Left = 5.1295F
			Me.lblGuidePerRod10.Name = "lblGuidePerRod10"
			Me.lblGuidePerRod10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod10.Text = "N/A"
			Me.lblGuidePerRod10.Top = 3.281998F
			Me.lblGuidePerRod10.Visible = False
			Me.lblGuidePerRod10.Width = 0.7130001F
			Me.Label38.Height = 0.1569999F
			Me.Label38.HyperLink = Nothing
			Me.Label38.Left = 5.13F
			Me.Label38.Name = "Label38"
			Me.Label38.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.Label38.Text = "per Rod"
			Me.Label38.Top = 1.597F
			Me.Label38.Width = 0.7130001F
			Me.Label39.Height = 0.1569999F
			Me.Label39.HyperLink = Nothing
			Me.Label39.Left = 5.13F
			Me.Label39.Name = "Label39"
			Me.Label39.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.Label39.Text = "# Guides"
			Me.Label39.Top = 1.43F
			Me.Label39.Width = 0.7130001F
			Me.Line1.Height = 3.682F
			Me.Line1.Left = 5.039056F
			Me.Line1.LineWeight = 1F
			Me.Line1.Name = "Line1"
			Me.Line1.Top = 1.398F
			Me.Line1.Width = 0F
			Me.Line1.X1 = 5.039056F
			Me.Line1.X2 = 5.039056F
			Me.Line1.Y1 = 1.398F
			Me.Line1.Y2 = 5.08F
			Me.Line2.Height = 3.682F
			Me.Line2.Left = 5.909F
			Me.Line2.LineWeight = 1F
			Me.Line2.Name = "Line2"
			Me.Line2.Top = 1.398F
			Me.Line2.Width = 0F
			Me.Line2.X1 = 5.909F
			Me.Line2.X2 = 5.909F
			Me.Line2.Y1 = 1.398F
			Me.Line2.Y2 = 5.08F
			Me.Line3.Height = 3.682F
			Me.Line3.Left = 6.72F
			Me.Line3.LineWeight = 1F
			Me.Line3.Name = "Line3"
			Me.Line3.Top = 1.398F
			Me.Line3.Width = 0F
			Me.Line3.X1 = 6.72F
			Me.Line3.X2 = 6.72F
			Me.Line3.Y1 = 1.398F
			Me.Line3.Y2 = 5.08F
			Me.PageFooter.Height = 0.25F
			Me.PageFooter.Name = "PageFooter"
			Me.lblCost18.Height = 0.145F
			Me.lblCost18.HyperLink = Nothing
			Me.lblCost18.Left = 3.319F
			Me.lblCost18.Name = "lblCost18"
			Me.lblCost18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost18.Text = "N/A"
			Me.lblCost18.Top = 4.541F
			Me.lblCost18.Visible = False
			Me.lblCost18.Width = 0.5F
			Me.lblCost20.Height = 0.145F
			Me.lblCost20.HyperLink = Nothing
			Me.lblCost20.Left = 3.319F
			Me.lblCost20.Name = "lblCost20"
			Me.lblCost20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost20.Text = "N/A"
			Me.lblCost20.Top = 4.851001F
			Me.lblCost20.Visible = False
			Me.lblCost20.Width = 0.5F
			Me.lblCost19.Height = 0.145F
			Me.lblCost19.HyperLink = Nothing
			Me.lblCost19.Left = 3.319F
			Me.lblCost19.Name = "lblCost19"
			Me.lblCost19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost19.Text = "N/A"
			Me.lblCost19.Top = 4.696001F
			Me.lblCost19.Visible = False
			Me.lblCost19.Width = 0.5F
			Me.lblCost17.Height = 0.145F
			Me.lblCost17.HyperLink = Nothing
			Me.lblCost17.Left = 3.319F
			Me.lblCost17.Name = "lblCost17"
			Me.lblCost17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost17.Text = "N/A"
			Me.lblCost17.Top = 4.386001F
			Me.lblCost17.Visible = False
			Me.lblCost17.Width = 0.5F
			Me.lblRodDiam11.Height = 0.145F
			Me.lblRodDiam11.HyperLink = Nothing
			Me.lblRodDiam11.Left = 0.384F
			Me.lblRodDiam11.Name = "lblRodDiam11"
			Me.lblRodDiam11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam11.Text = "Diam"
			Me.lblRodDiam11.Top = 3.446F
			Me.lblRodDiam11.Visible = False
			Me.lblRodDiam11.Width = 0.6875F
			Me.lblRodDiam12.Height = 0.145F
			Me.lblRodDiam12.HyperLink = Nothing
			Me.lblRodDiam12.Left = 0.3829999F
			Me.lblRodDiam12.Name = "lblRodDiam12"
			Me.lblRodDiam12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam12.Text = "Diam"
			Me.lblRodDiam12.Top = 3.601F
			Me.lblRodDiam12.Visible = False
			Me.lblRodDiam12.Width = 0.6875F
			Me.lblRodDiam13.Height = 0.145F
			Me.lblRodDiam13.HyperLink = Nothing
			Me.lblRodDiam13.Left = 0.3834446F
			Me.lblRodDiam13.Name = "lblRodDiam13"
			Me.lblRodDiam13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam13.Text = "Diam"
			Me.lblRodDiam13.Top = 3.756F
			Me.lblRodDiam13.Visible = False
			Me.lblRodDiam13.Width = 0.6875F
			Me.lblRodDiam14.Height = 0.145F
			Me.lblRodDiam14.HyperLink = Nothing
			Me.lblRodDiam14.Left = 0.3834446F
			Me.lblRodDiam14.Name = "lblRodDiam14"
			Me.lblRodDiam14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam14.Text = "Diam"
			Me.lblRodDiam14.Top = 3.911F
			Me.lblRodDiam14.Visible = False
			Me.lblRodDiam14.Width = 0.6875F
			Me.lblRodDiam15.Height = 0.145F
			Me.lblRodDiam15.HyperLink = Nothing
			Me.lblRodDiam15.Left = 0.3834446F
			Me.lblRodDiam15.Name = "lblRodDiam15"
			Me.lblRodDiam15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam15.Text = "Diam"
			Me.lblRodDiam15.Top = 4.065999F
			Me.lblRodDiam15.Visible = False
			Me.lblRodDiam15.Width = 0.6875F
			Me.lblRodDiam16.Height = 0.145F
			Me.lblRodDiam16.HyperLink = Nothing
			Me.lblRodDiam16.Left = 0.383F
			Me.lblRodDiam16.Name = "lblRodDiam16"
			Me.lblRodDiam16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam16.Text = "Diam"
			Me.lblRodDiam16.Top = 4.230999F
			Me.lblRodDiam16.Visible = False
			Me.lblRodDiam16.Width = 0.6875F
			Me.lblRodDiam17.Height = 0.145F
			Me.lblRodDiam17.HyperLink = Nothing
			Me.lblRodDiam17.Left = 0.3834446F
			Me.lblRodDiam17.Name = "lblRodDiam17"
			Me.lblRodDiam17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam17.Text = "Diam"
			Me.lblRodDiam17.Top = 4.386F
			Me.lblRodDiam17.Visible = False
			Me.lblRodDiam17.Width = 0.6875F
			Me.lblRodDiam18.Height = 0.145F
			Me.lblRodDiam18.HyperLink = Nothing
			Me.lblRodDiam18.Left = 0.3834446F
			Me.lblRodDiam18.Name = "lblRodDiam18"
			Me.lblRodDiam18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam18.Text = "Diam"
			Me.lblRodDiam18.Top = 4.540999F
			Me.lblRodDiam18.Visible = False
			Me.lblRodDiam18.Width = 0.6875F
			Me.lblRodGrade11.Height = 0.145F
			Me.lblRodGrade11.HyperLink = Nothing
			Me.lblRodGrade11.Left = 1.196F
			Me.lblRodGrade11.Name = "lblRodGrade11"
			Me.lblRodGrade11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade11.Text = "Grade"
			Me.lblRodGrade11.Top = 3.446F
			Me.lblRodGrade11.Visible = False
			Me.lblRodGrade11.Width = 0.875F
			Me.lblRodGrade12.Height = 0.145F
			Me.lblRodGrade12.HyperLink = Nothing
			Me.lblRodGrade12.Left = 1.1955F
			Me.lblRodGrade12.Name = "lblRodGrade12"
			Me.lblRodGrade12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade12.Text = "Grade"
			Me.lblRodGrade12.Top = 3.601F
			Me.lblRodGrade12.Visible = False
			Me.lblRodGrade12.Width = 0.875F
			Me.lblRodGrade13.Height = 0.145F
			Me.lblRodGrade13.HyperLink = Nothing
			Me.lblRodGrade13.Left = 1.1955F
			Me.lblRodGrade13.Name = "lblRodGrade13"
			Me.lblRodGrade13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade13.Text = "Grade"
			Me.lblRodGrade13.Top = 3.756F
			Me.lblRodGrade13.Visible = False
			Me.lblRodGrade13.Width = 0.875F
			Me.lblRodGrade14.Height = 0.145F
			Me.lblRodGrade14.HyperLink = Nothing
			Me.lblRodGrade14.Left = 1.1955F
			Me.lblRodGrade14.Name = "lblRodGrade14"
			Me.lblRodGrade14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade14.Text = "Grade"
			Me.lblRodGrade14.Top = 3.911F
			Me.lblRodGrade14.Visible = False
			Me.lblRodGrade14.Width = 0.875F
			Me.lblRodGrade15.Height = 0.145F
			Me.lblRodGrade15.HyperLink = Nothing
			Me.lblRodGrade15.Left = 1.1955F
			Me.lblRodGrade15.Name = "lblRodGrade15"
			Me.lblRodGrade15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade15.Text = "Grade"
			Me.lblRodGrade15.Top = 4.065999F
			Me.lblRodGrade15.Visible = False
			Me.lblRodGrade15.Width = 0.875F
			Me.lblRodGrade16.Height = 0.145F
			Me.lblRodGrade16.HyperLink = Nothing
			Me.lblRodGrade16.Left = 1.195556F
			Me.lblRodGrade16.Name = "lblRodGrade16"
			Me.lblRodGrade16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade16.Text = "Grade"
			Me.lblRodGrade16.Top = 4.230999F
			Me.lblRodGrade16.Visible = False
			Me.lblRodGrade16.Width = 0.875F
			Me.lblRodGrade17.Height = 0.145F
			Me.lblRodGrade17.HyperLink = Nothing
			Me.lblRodGrade17.Left = 1.1955F
			Me.lblRodGrade17.Name = "lblRodGrade17"
			Me.lblRodGrade17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade17.Text = "Grade"
			Me.lblRodGrade17.Top = 4.386F
			Me.lblRodGrade17.Visible = False
			Me.lblRodGrade17.Width = 0.875F
			Me.lblRodGrade18.Height = 0.145F
			Me.lblRodGrade18.HyperLink = Nothing
			Me.lblRodGrade18.Left = 1.1955F
			Me.lblRodGrade18.Name = "lblRodGrade18"
			Me.lblRodGrade18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade18.Text = "Grade"
			Me.lblRodGrade18.Top = 4.540999F
			Me.lblRodGrade18.Visible = False
			Me.lblRodGrade18.Width = 0.875F
			Me.lblRodLength11.Height = 0.145F
			Me.lblRodLength11.HyperLink = Nothing
			Me.lblRodLength11.Left = 2.196F
			Me.lblRodLength11.Name = "lblRodLength11"
			Me.lblRodLength11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength11.Text = "Len"
			Me.lblRodLength11.Top = 3.446F
			Me.lblRodLength11.Visible = False
			Me.lblRodLength11.Width = 0.4930553F
			Me.lblRodLength12.Height = 0.145F
			Me.lblRodLength12.HyperLink = Nothing
			Me.lblRodLength12.Left = 2.1955F
			Me.lblRodLength12.Name = "lblRodLength12"
			Me.lblRodLength12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength12.Text = "Len"
			Me.lblRodLength12.Top = 3.601F
			Me.lblRodLength12.Visible = False
			Me.lblRodLength12.Width = 0.4930553F
			Me.lblRodLength13.Height = 0.145F
			Me.lblRodLength13.HyperLink = Nothing
			Me.lblRodLength13.Left = 2.1955F
			Me.lblRodLength13.Name = "lblRodLength13"
			Me.lblRodLength13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength13.Text = "Len"
			Me.lblRodLength13.Top = 3.756F
			Me.lblRodLength13.Visible = False
			Me.lblRodLength13.Width = 0.4930553F
			Me.lblRodLength14.Height = 0.145F
			Me.lblRodLength14.HyperLink = Nothing
			Me.lblRodLength14.Left = 2.1955F
			Me.lblRodLength14.Name = "lblRodLength14"
			Me.lblRodLength14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength14.Text = "Len"
			Me.lblRodLength14.Top = 3.911F
			Me.lblRodLength14.Visible = False
			Me.lblRodLength14.Width = 0.4930553F
			Me.lblRodLength15.Height = 0.145F
			Me.lblRodLength15.HyperLink = Nothing
			Me.lblRodLength15.Left = 2.1955F
			Me.lblRodLength15.Name = "lblRodLength15"
			Me.lblRodLength15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength15.Text = "Len"
			Me.lblRodLength15.Top = 4.065999F
			Me.lblRodLength15.Visible = False
			Me.lblRodLength15.Width = 0.4930553F
			Me.lblRodLength16.Height = 0.145F
			Me.lblRodLength16.HyperLink = Nothing
			Me.lblRodLength16.Left = 2.195556F
			Me.lblRodLength16.Name = "lblRodLength16"
			Me.lblRodLength16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength16.Text = "Len"
			Me.lblRodLength16.Top = 4.230999F
			Me.lblRodLength16.Visible = False
			Me.lblRodLength16.Width = 0.4930553F
			Me.lblRodLength17.Height = 0.145F
			Me.lblRodLength17.HyperLink = Nothing
			Me.lblRodLength17.Left = 2.195556F
			Me.lblRodLength17.Name = "lblRodLength17"
			Me.lblRodLength17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength17.Text = "Len"
			Me.lblRodLength17.Top = 4.385999F
			Me.lblRodLength17.Visible = False
			Me.lblRodLength17.Width = 0.4930553F
			Me.lblRodLength18.Height = 0.145F
			Me.lblRodLength18.HyperLink = Nothing
			Me.lblRodLength18.Left = 2.1955F
			Me.lblRodLength18.Name = "lblRodLength18"
			Me.lblRodLength18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength18.Text = "Len"
			Me.lblRodLength18.Top = 4.540999F
			Me.lblRodLength18.Visible = False
			Me.lblRodLength18.Width = 0.4930553F
			Me.lblTotalCost11.Height = 0.145F
			Me.lblTotalCost11.HyperLink = Nothing
			Me.lblTotalCost11.Left = 6.79F
			Me.lblTotalCost11.Name = "lblTotalCost11"
			Me.lblTotalCost11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost11.Text = "N/A"
			Me.lblTotalCost11.Top = 3.456F
			Me.lblTotalCost11.Visible = False
			Me.lblTotalCost11.Width = 1F
			Me.lblTotalCost12.Height = 0.145F
			Me.lblTotalCost12.HyperLink = Nothing
			Me.lblTotalCost12.Left = 6.79F
			Me.lblTotalCost12.Name = "lblTotalCost12"
			Me.lblTotalCost12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost12.Text = "N/A"
			Me.lblTotalCost12.Top = 3.611F
			Me.lblTotalCost12.Visible = False
			Me.lblTotalCost12.Width = 1F
			Me.lblTotalCost13.Height = 0.145F
			Me.lblTotalCost13.HyperLink = Nothing
			Me.lblTotalCost13.Left = 6.79F
			Me.lblTotalCost13.Name = "lblTotalCost13"
			Me.lblTotalCost13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost13.Text = "N/A"
			Me.lblTotalCost13.Top = 3.766F
			Me.lblTotalCost13.Visible = False
			Me.lblTotalCost13.Width = 1F
			Me.lblTotalCost14.Height = 0.145F
			Me.lblTotalCost14.HyperLink = Nothing
			Me.lblTotalCost14.Left = 6.79F
			Me.lblTotalCost14.Name = "lblTotalCost14"
			Me.lblTotalCost14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost14.Text = "N/A"
			Me.lblTotalCost14.Top = 3.921F
			Me.lblTotalCost14.Visible = False
			Me.lblTotalCost14.Width = 1F
			Me.lblTotalCost15.Height = 0.145F
			Me.lblTotalCost15.HyperLink = Nothing
			Me.lblTotalCost15.Left = 6.79F
			Me.lblTotalCost15.Name = "lblTotalCost15"
			Me.lblTotalCost15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost15.Text = "N/A"
			Me.lblTotalCost15.Top = 4.075999F
			Me.lblTotalCost15.Visible = False
			Me.lblTotalCost15.Width = 1F
			Me.lblTotalCost16.Height = 0.145F
			Me.lblTotalCost16.HyperLink = Nothing
			Me.lblTotalCost16.Left = 6.79F
			Me.lblTotalCost16.Name = "lblTotalCost16"
			Me.lblTotalCost16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost16.Text = "N/A"
			Me.lblTotalCost16.Top = 4.230998F
			Me.lblTotalCost16.Visible = False
			Me.lblTotalCost16.Width = 1F
			Me.lblTotalCost17.Height = 0.145F
			Me.lblTotalCost17.HyperLink = Nothing
			Me.lblTotalCost17.Left = 6.79F
			Me.lblTotalCost17.Name = "lblTotalCost17"
			Me.lblTotalCost17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost17.Text = "N/A"
			Me.lblTotalCost17.Top = 4.395999F
			Me.lblTotalCost17.Visible = False
			Me.lblTotalCost17.Width = 1F
			Me.lblTotalCost18.Height = 0.145F
			Me.lblTotalCost18.HyperLink = Nothing
			Me.lblTotalCost18.Left = 6.79F
			Me.lblTotalCost18.Name = "lblTotalCost18"
			Me.lblTotalCost18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost18.Text = "N/A"
			Me.lblTotalCost18.Top = 4.550999F
			Me.lblTotalCost18.Visible = False
			Me.lblTotalCost18.Width = 1F
			Me.lblCost11.Height = 0.145F
			Me.lblCost11.HyperLink = Nothing
			Me.lblCost11.Left = 3.319F
			Me.lblCost11.Name = "lblCost11"
			Me.lblCost11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost11.Text = "N/A"
			Me.lblCost11.Top = 3.446001F
			Me.lblCost11.Visible = False
			Me.lblCost11.Width = 0.5F
			Me.lblCost12.Height = 0.145F
			Me.lblCost12.HyperLink = Nothing
			Me.lblCost12.Left = 3.319F
			Me.lblCost12.Name = "lblCost12"
			Me.lblCost12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost12.Text = "N/A"
			Me.lblCost12.Top = 3.601001F
			Me.lblCost12.Visible = False
			Me.lblCost12.Width = 0.5F
			Me.lblCost13.Height = 0.145F
			Me.lblCost13.HyperLink = Nothing
			Me.lblCost13.Left = 3.319F
			Me.lblCost13.Name = "lblCost13"
			Me.lblCost13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost13.Text = "N/A"
			Me.lblCost13.Top = 3.756001F
			Me.lblCost13.Visible = False
			Me.lblCost13.Width = 0.5F
			Me.lblCost14.Height = 0.145F
			Me.lblCost14.HyperLink = Nothing
			Me.lblCost14.Left = 3.319F
			Me.lblCost14.Name = "lblCost14"
			Me.lblCost14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost14.Text = "N/A"
			Me.lblCost14.Top = 3.911001F
			Me.lblCost14.Visible = False
			Me.lblCost14.Width = 0.5F
			Me.lblCost15.Height = 0.145F
			Me.lblCost15.HyperLink = Nothing
			Me.lblCost15.Left = 3.319F
			Me.lblCost15.Name = "lblCost15"
			Me.lblCost15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost15.Text = "N/A"
			Me.lblCost15.Top = 4.066F
			Me.lblCost15.Visible = False
			Me.lblCost15.Width = 0.5F
			Me.lblCost16.Height = 0.145F
			Me.lblCost16.HyperLink = Nothing
			Me.lblCost16.Left = 3.319F
			Me.lblCost16.Name = "lblCost16"
			Me.lblCost16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCost16.Text = "N/A"
			Me.lblCost16.Top = 4.231F
			Me.lblCost16.Visible = False
			Me.lblCost16.Width = 0.5F
			Me.lblRodDiam19.Height = 0.145F
			Me.lblRodDiam19.HyperLink = Nothing
			Me.lblRodDiam19.Left = 0.3834446F
			Me.lblRodDiam19.Name = "lblRodDiam19"
			Me.lblRodDiam19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam19.Text = "Diam"
			Me.lblRodDiam19.Top = 4.695999F
			Me.lblRodDiam19.Visible = False
			Me.lblRodDiam19.Width = 0.6875F
			Me.lblRodGrade19.Height = 0.145F
			Me.lblRodGrade19.HyperLink = Nothing
			Me.lblRodGrade19.Left = 1.1955F
			Me.lblRodGrade19.Name = "lblRodGrade19"
			Me.lblRodGrade19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade19.Text = "Grade"
			Me.lblRodGrade19.Top = 4.695999F
			Me.lblRodGrade19.Visible = False
			Me.lblRodGrade19.Width = 0.875F
			Me.lblRodLength19.Height = 0.145F
			Me.lblRodLength19.HyperLink = Nothing
			Me.lblRodLength19.Left = 2.1955F
			Me.lblRodLength19.Name = "lblRodLength19"
			Me.lblRodLength19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength19.Text = "Len"
			Me.lblRodLength19.Top = 4.695999F
			Me.lblRodLength19.Visible = False
			Me.lblRodLength19.Width = 0.4930553F
			Me.lblTotalCost19.Height = 0.145F
			Me.lblTotalCost19.HyperLink = Nothing
			Me.lblTotalCost19.Left = 6.79F
			Me.lblTotalCost19.Name = "lblTotalCost19"
			Me.lblTotalCost19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost19.Text = "N/A"
			Me.lblTotalCost19.Top = 4.705997F
			Me.lblTotalCost19.Visible = False
			Me.lblTotalCost19.Width = 1F
			Me.lblRodDiam20.Height = 0.145F
			Me.lblRodDiam20.HyperLink = Nothing
			Me.lblRodDiam20.Left = 0.3834446F
			Me.lblRodDiam20.Name = "lblRodDiam20"
			Me.lblRodDiam20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam20.Text = "Diam"
			Me.lblRodDiam20.Top = 4.851F
			Me.lblRodDiam20.Visible = False
			Me.lblRodDiam20.Width = 0.6875F
			Me.lblRodGrade20.Height = 0.145F
			Me.lblRodGrade20.HyperLink = Nothing
			Me.lblRodGrade20.Left = 1.1955F
			Me.lblRodGrade20.Name = "lblRodGrade20"
			Me.lblRodGrade20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade20.Text = "Grade"
			Me.lblRodGrade20.Top = 4.851F
			Me.lblRodGrade20.Visible = False
			Me.lblRodGrade20.Width = 0.875F
			Me.lblRodLength20.Height = 0.145F
			Me.lblRodLength20.HyperLink = Nothing
			Me.lblRodLength20.Left = 2.1955F
			Me.lblRodLength20.Name = "lblRodLength20"
			Me.lblRodLength20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength20.Text = "Len"
			Me.lblRodLength20.Top = 4.851F
			Me.lblRodLength20.Visible = False
			Me.lblRodLength20.Width = 0.4930553F
			Me.lblTotalCost20.Height = 0.145F
			Me.lblTotalCost20.HyperLink = Nothing
			Me.lblTotalCost20.Left = 6.79F
			Me.lblTotalCost20.Name = "lblTotalCost20"
			Me.lblTotalCost20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblTotalCost20.Text = "N/A"
			Me.lblTotalCost20.Top = 4.860999F
			Me.lblTotalCost20.Visible = False
			Me.lblTotalCost20.Width = 1F
			Me.lblGuide11.Height = 0.15F
			Me.lblGuide11.HyperLink = Nothing
			Me.lblGuide11.Left = 3.972F
			Me.lblGuide11.Name = "lblGuide11"
			Me.lblGuide11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide11.Text = "N/A"
			Me.lblGuide11.Top = 3.436F
			Me.lblGuide11.Visible = False
			Me.lblGuide11.Width = 1F
			Me.lblGuide12.Height = 0.15F
			Me.lblGuide12.HyperLink = Nothing
			Me.lblGuide12.Left = 3.9715F
			Me.lblGuide12.Name = "lblGuide12"
			Me.lblGuide12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide12.Text = "N/A"
			Me.lblGuide12.Top = 3.591F
			Me.lblGuide12.Visible = False
			Me.lblGuide12.Width = 1F
			Me.lblGuide13.Height = 0.15F
			Me.lblGuide13.HyperLink = Nothing
			Me.lblGuide13.Left = 3.9715F
			Me.lblGuide13.Name = "lblGuide13"
			Me.lblGuide13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide13.Text = "N/A"
			Me.lblGuide13.Top = 3.746F
			Me.lblGuide13.Visible = False
			Me.lblGuide13.Width = 1F
			Me.lblGuide14.Height = 0.14F
			Me.lblGuide14.HyperLink = Nothing
			Me.lblGuide14.Left = 3.9715F
			Me.lblGuide14.Name = "lblGuide14"
			Me.lblGuide14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide14.Text = "N/A"
			Me.lblGuide14.Top = 3.901F
			Me.lblGuide14.Visible = False
			Me.lblGuide14.Width = 1F
			Me.lblGuide15.Height = 0.14F
			Me.lblGuide15.HyperLink = Nothing
			Me.lblGuide15.Left = 3.9715F
			Me.lblGuide15.Name = "lblGuide15"
			Me.lblGuide15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide15.Text = "N/A"
			Me.lblGuide15.Top = 4.055999F
			Me.lblGuide15.Visible = False
			Me.lblGuide15.Width = 1F
			Me.lblGuide16.Height = 0.14F
			Me.lblGuide16.HyperLink = Nothing
			Me.lblGuide16.Left = 3.972F
			Me.lblGuide16.Name = "lblGuide16"
			Me.lblGuide16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide16.Text = "N/A"
			Me.lblGuide16.Top = 4.220999F
			Me.lblGuide16.Visible = False
			Me.lblGuide16.Width = 1F
			Me.lblGuide17.Height = 0.14F
			Me.lblGuide17.HyperLink = Nothing
			Me.lblGuide17.Left = 3.9715F
			Me.lblGuide17.Name = "lblGuide17"
			Me.lblGuide17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide17.Text = "N/A"
			Me.lblGuide17.Top = 4.375998F
			Me.lblGuide17.Visible = False
			Me.lblGuide17.Width = 1F
			Me.lblGuide18.Height = 0.14F
			Me.lblGuide18.HyperLink = Nothing
			Me.lblGuide18.Left = 3.9715F
			Me.lblGuide18.Name = "lblGuide18"
			Me.lblGuide18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide18.Text = "N/A"
			Me.lblGuide18.Top = 4.530997F
			Me.lblGuide18.Visible = False
			Me.lblGuide18.Width = 1F
			Me.lblGuide19.Height = 0.14F
			Me.lblGuide19.HyperLink = Nothing
			Me.lblGuide19.Left = 3.9715F
			Me.lblGuide19.Name = "lblGuide19"
			Me.lblGuide19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide19.Text = "N/A"
			Me.lblGuide19.Top = 4.685998F
			Me.lblGuide19.Visible = False
			Me.lblGuide19.Width = 1F
			Me.lblGuide20.Height = 0.14F
			Me.lblGuide20.HyperLink = Nothing
			Me.lblGuide20.Left = 3.9715F
			Me.lblGuide20.Name = "lblGuide20"
			Me.lblGuide20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuide20.Text = "N/A"
			Me.lblGuide20.Top = 4.840998F
			Me.lblGuide20.Visible = False
			Me.lblGuide20.Width = 1F
			Me.lblCostPerGuide11.Height = 0.145F
			Me.lblCostPerGuide11.HyperLink = Nothing
			Me.lblCostPerGuide11.Left = 5.992F
			Me.lblCostPerGuide11.Name = "lblCostPerGuide11"
			Me.lblCostPerGuide11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide11.Text = "N/A"
			Me.lblCostPerGuide11.Top = 3.456F
			Me.lblCostPerGuide11.Visible = False
			Me.lblCostPerGuide11.Width = 0.671F
			Me.lblCostPerGuide12.Height = 0.145F
			Me.lblCostPerGuide12.HyperLink = Nothing
			Me.lblCostPerGuide12.Left = 5.9915F
			Me.lblCostPerGuide12.Name = "lblCostPerGuide12"
			Me.lblCostPerGuide12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide12.Text = "N/A"
			Me.lblCostPerGuide12.Top = 3.611F
			Me.lblCostPerGuide12.Visible = False
			Me.lblCostPerGuide12.Width = 0.671F
			Me.lblCostPerGuide13.Height = 0.145F
			Me.lblCostPerGuide13.HyperLink = Nothing
			Me.lblCostPerGuide13.Left = 5.9915F
			Me.lblCostPerGuide13.Name = "lblCostPerGuide13"
			Me.lblCostPerGuide13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide13.Text = "N/A"
			Me.lblCostPerGuide13.Top = 3.766F
			Me.lblCostPerGuide13.Visible = False
			Me.lblCostPerGuide13.Width = 0.671F
			Me.lblCostPerGuide14.Height = 0.145F
			Me.lblCostPerGuide14.HyperLink = Nothing
			Me.lblCostPerGuide14.Left = 5.9915F
			Me.lblCostPerGuide14.Name = "lblCostPerGuide14"
			Me.lblCostPerGuide14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide14.Text = "N/A"
			Me.lblCostPerGuide14.Top = 3.921F
			Me.lblCostPerGuide14.Visible = False
			Me.lblCostPerGuide14.Width = 0.671F
			Me.lblCostPerGuide15.Height = 0.145F
			Me.lblCostPerGuide15.HyperLink = Nothing
			Me.lblCostPerGuide15.Left = 5.9915F
			Me.lblCostPerGuide15.Name = "lblCostPerGuide15"
			Me.lblCostPerGuide15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide15.Text = "N/A"
			Me.lblCostPerGuide15.Top = 4.075999F
			Me.lblCostPerGuide15.Visible = False
			Me.lblCostPerGuide15.Width = 0.671F
			Me.lblCostPerGuide16.Height = 0.145F
			Me.lblCostPerGuide16.HyperLink = Nothing
			Me.lblCostPerGuide16.Left = 5.9915F
			Me.lblCostPerGuide16.Name = "lblCostPerGuide16"
			Me.lblCostPerGuide16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide16.Text = "N/A"
			Me.lblCostPerGuide16.Top = 4.230998F
			Me.lblCostPerGuide16.Visible = False
			Me.lblCostPerGuide16.Width = 0.671F
			Me.lblCostPerGuide17.Height = 0.145F
			Me.lblCostPerGuide17.HyperLink = Nothing
			Me.lblCostPerGuide17.Left = 5.9915F
			Me.lblCostPerGuide17.Name = "lblCostPerGuide17"
			Me.lblCostPerGuide17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide17.Text = "N/A"
			Me.lblCostPerGuide17.Top = 4.395999F
			Me.lblCostPerGuide17.Visible = False
			Me.lblCostPerGuide17.Width = 0.671F
			Me.lblCostPerGuide18.Height = 0.145F
			Me.lblCostPerGuide18.HyperLink = Nothing
			Me.lblCostPerGuide18.Left = 5.9915F
			Me.lblCostPerGuide18.Name = "lblCostPerGuide18"
			Me.lblCostPerGuide18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide18.Text = "N/A"
			Me.lblCostPerGuide18.Top = 4.550999F
			Me.lblCostPerGuide18.Visible = False
			Me.lblCostPerGuide18.Width = 0.671F
			Me.lblCostPerGuide19.Height = 0.145F
			Me.lblCostPerGuide19.HyperLink = Nothing
			Me.lblCostPerGuide19.Left = 5.9915F
			Me.lblCostPerGuide19.Name = "lblCostPerGuide19"
			Me.lblCostPerGuide19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide19.Text = "N/A"
			Me.lblCostPerGuide19.Top = 4.705997F
			Me.lblCostPerGuide19.Visible = False
			Me.lblCostPerGuide19.Width = 0.671F
			Me.lblCostPerGuide20.Height = 0.145F
			Me.lblCostPerGuide20.HyperLink = Nothing
			Me.lblCostPerGuide20.Left = 5.9915F
			Me.lblCostPerGuide20.Name = "lblCostPerGuide20"
			Me.lblCostPerGuide20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblCostPerGuide20.Text = "N/A"
			Me.lblCostPerGuide20.Top = 4.860999F
			Me.lblCostPerGuide20.Visible = False
			Me.lblCostPerGuide20.Width = 0.671F
			Me.lblGuidePerRod11.Height = 0.145F
			Me.lblGuidePerRod11.HyperLink = Nothing
			Me.lblGuidePerRod11.Left = 5.132F
			Me.lblGuidePerRod11.Name = "lblGuidePerRod11"
			Me.lblGuidePerRod11.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod11.Text = "N/A"
			Me.lblGuidePerRod11.Top = 3.448F
			Me.lblGuidePerRod11.Visible = False
			Me.lblGuidePerRod11.Width = 0.713F
			Me.lblGuidePerRod12.Height = 0.145F
			Me.lblGuidePerRod12.HyperLink = Nothing
			Me.lblGuidePerRod12.Left = 5.131501F
			Me.lblGuidePerRod12.Name = "lblGuidePerRod12"
			Me.lblGuidePerRod12.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod12.Text = "N/A"
			Me.lblGuidePerRod12.Top = 3.603F
			Me.lblGuidePerRod12.Visible = False
			Me.lblGuidePerRod12.Width = 0.713F
			Me.lblGuidePerRod13.Height = 0.145F
			Me.lblGuidePerRod13.HyperLink = Nothing
			Me.lblGuidePerRod13.Left = 5.131501F
			Me.lblGuidePerRod13.Name = "lblGuidePerRod13"
			Me.lblGuidePerRod13.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod13.Text = "N/A"
			Me.lblGuidePerRod13.Top = 3.758F
			Me.lblGuidePerRod13.Visible = False
			Me.lblGuidePerRod13.Width = 0.713F
			Me.lblGuidePerRod14.Height = 0.145F
			Me.lblGuidePerRod14.HyperLink = Nothing
			Me.lblGuidePerRod14.Left = 5.131501F
			Me.lblGuidePerRod14.Name = "lblGuidePerRod14"
			Me.lblGuidePerRod14.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod14.Text = "N/A"
			Me.lblGuidePerRod14.Top = 3.912999F
			Me.lblGuidePerRod14.Visible = False
			Me.lblGuidePerRod14.Width = 0.713F
			Me.lblGuidePerRod15.Height = 0.145F
			Me.lblGuidePerRod15.HyperLink = Nothing
			Me.lblGuidePerRod15.Left = 5.131501F
			Me.lblGuidePerRod15.Name = "lblGuidePerRod15"
			Me.lblGuidePerRod15.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod15.Text = "N/A"
			Me.lblGuidePerRod15.Top = 4.067998F
			Me.lblGuidePerRod15.Visible = False
			Me.lblGuidePerRod15.Width = 0.713F
			Me.lblGuidePerRod16.Height = 0.145F
			Me.lblGuidePerRod16.HyperLink = Nothing
			Me.lblGuidePerRod16.Left = 5.131501F
			Me.lblGuidePerRod16.Name = "lblGuidePerRod16"
			Me.lblGuidePerRod16.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod16.Text = "N/A"
			Me.lblGuidePerRod16.Top = 4.222998F
			Me.lblGuidePerRod16.Visible = False
			Me.lblGuidePerRod16.Width = 0.713F
			Me.lblGuidePerRod17.Height = 0.145F
			Me.lblGuidePerRod17.HyperLink = Nothing
			Me.lblGuidePerRod17.Left = 5.131501F
			Me.lblGuidePerRod17.Name = "lblGuidePerRod17"
			Me.lblGuidePerRod17.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod17.Text = "N/A"
			Me.lblGuidePerRod17.Top = 4.387997F
			Me.lblGuidePerRod17.Visible = False
			Me.lblGuidePerRod17.Width = 0.713F
			Me.lblGuidePerRod18.Height = 0.145F
			Me.lblGuidePerRod18.HyperLink = Nothing
			Me.lblGuidePerRod18.Left = 5.131501F
			Me.lblGuidePerRod18.Name = "lblGuidePerRod18"
			Me.lblGuidePerRod18.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod18.Text = "N/A"
			Me.lblGuidePerRod18.Top = 4.542996F
			Me.lblGuidePerRod18.Visible = False
			Me.lblGuidePerRod18.Width = 0.713F
			Me.lblGuidePerRod19.Height = 0.145F
			Me.lblGuidePerRod19.HyperLink = Nothing
			Me.lblGuidePerRod19.Left = 5.131501F
			Me.lblGuidePerRod19.Name = "lblGuidePerRod19"
			Me.lblGuidePerRod19.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod19.Text = "N/A"
			Me.lblGuidePerRod19.Top = 4.697997F
			Me.lblGuidePerRod19.Visible = False
			Me.lblGuidePerRod19.Width = 0.713F
			Me.lblGuidePerRod20.Height = 0.145F
			Me.lblGuidePerRod20.HyperLink = Nothing
			Me.lblGuidePerRod20.Left = 5.131501F
			Me.lblGuidePerRod20.Name = "lblGuidePerRod20"
			Me.lblGuidePerRod20.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblGuidePerRod20.Text = "N/A"
			Me.lblGuidePerRod20.Top = 4.852997F
			Me.lblGuidePerRod20.Visible = False
			Me.lblGuidePerRod20.Width = 0.713F
			Me.Line4.Height = 3.682F
			Me.Line4.Left = 3.27F
			Me.Line4.LineWeight = 1F
			Me.Line4.Name = "Line4"
			Me.Line4.Top = 1.398F
			Me.Line4.Width = 0F
			Me.Line4.X1 = 3.27F
			Me.Line4.X2 = 3.27F
			Me.Line4.Y1 = 1.398F
			Me.Line4.Y2 = 5.08F
			Me.lblNumRodsHdrTop.Height = 0.145F
			Me.lblNumRodsHdrTop.HyperLink = Nothing
			Me.lblNumRodsHdrTop.Left = 2.79F
			Me.lblNumRodsHdrTop.Name = "lblNumRodsHdrTop"
			Me.lblNumRodsHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblNumRodsHdrTop.Text = "# of"
			Me.lblNumRodsHdrTop.Top = 1.438F
			Me.lblNumRodsHdrTop.Width = 0.4480002F
			Me.lblNumRodsHdrBot.Height = 0.145F
			Me.lblNumRodsHdrBot.HyperLink = Nothing
			Me.lblNumRodsHdrBot.Left = 2.79F
			Me.lblNumRodsHdrBot.Name = "lblNumRodsHdrBot"
			Me.lblNumRodsHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblNumRodsHdrBot.Text = "Rods"
			Me.lblNumRodsHdrBot.Top = 1.605F
			Me.lblNumRodsHdrBot.Width = 0.4480002F
			Me.lblNumRods1.Height = 0.145F
			Me.lblNumRods1.HyperLink = Nothing
			Me.lblNumRods1.Left = 2.79F
			Me.lblNumRods1.Name = "lblNumRods1"
			Me.lblNumRods1.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods1.Text = " "
			Me.lblNumRods1.Top = 1.875F
			Me.lblNumRods1.Width = 0.4480002F
			Me.lblNumRods2.Height = 0.145F
			Me.lblNumRods2.HyperLink = Nothing
			Me.lblNumRods2.Left = 2.79F
			Me.lblNumRods2.Name = "lblNumRods2"
			Me.lblNumRods2.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods2.Text = " "
			Me.lblNumRods2.Top = 2.03F
			Me.lblNumRods2.Width = 0.4480002F
			Me.lblNumRods3.Height = 0.145F
			Me.lblNumRods3.HyperLink = Nothing
			Me.lblNumRods3.Left = 2.79F
			Me.lblNumRods3.Name = "lblNumRods3"
			Me.lblNumRods3.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods3.Text = " "
			Me.lblNumRods3.Top = 2.185F
			Me.lblNumRods3.Width = 0.4480002F
			Me.lblNumRods4.Height = 0.145F
			Me.lblNumRods4.HyperLink = Nothing
			Me.lblNumRods4.Left = 2.79F
			Me.lblNumRods4.Name = "lblNumRods4"
			Me.lblNumRods4.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods4.Text = " "
			Me.lblNumRods4.Top = 2.34F
			Me.lblNumRods4.Width = 0.4480002F
			Me.lblNumRods5.Height = 0.145F
			Me.lblNumRods5.HyperLink = Nothing
			Me.lblNumRods5.Left = 2.79F
			Me.lblNumRods5.Name = "lblNumRods5"
			Me.lblNumRods5.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods5.Text = " "
			Me.lblNumRods5.Top = 2.495F
			Me.lblNumRods5.Width = 0.4480002F
			Me.lblNumRods6.Height = 0.145F
			Me.lblNumRods6.HyperLink = Nothing
			Me.lblNumRods6.Left = 2.79F
			Me.lblNumRods6.Name = "lblNumRods6"
			Me.lblNumRods6.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods6.Text = " "
			Me.lblNumRods6.Top = 2.66F
			Me.lblNumRods6.Width = 0.4480002F
			Me.lblNumRods7.Height = 0.145F
			Me.lblNumRods7.HyperLink = Nothing
			Me.lblNumRods7.Left = 2.79F
			Me.lblNumRods7.Name = "lblNumRods7"
			Me.lblNumRods7.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods7.Text = " "
			Me.lblNumRods7.Top = 2.815F
			Me.lblNumRods7.Width = 0.4480002F
			Me.lblNumRods8.Height = 0.145F
			Me.lblNumRods8.HyperLink = Nothing
			Me.lblNumRods8.Left = 2.79F
			Me.lblNumRods8.Name = "lblNumRods8"
			Me.lblNumRods8.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods8.Text = " "
			Me.lblNumRods8.Top = 2.97F
			Me.lblNumRods8.Width = 0.4480002F
			Me.lblNumRods9.Height = 0.145F
			Me.lblNumRods9.HyperLink = Nothing
			Me.lblNumRods9.Left = 2.79F
			Me.lblNumRods9.Name = "lblNumRods9"
			Me.lblNumRods9.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods9.Text = " "
			Me.lblNumRods9.Top = 3.125F
			Me.lblNumRods9.Width = 0.4480002F
			Me.lblNumRods10.Height = 0.145F
			Me.lblNumRods10.HyperLink = Nothing
			Me.lblNumRods10.Left = 2.79F
			Me.lblNumRods10.Name = "lblNumRods10"
			Me.lblNumRods10.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods10.Text = " "
			Me.lblNumRods10.Top = 3.28F
			Me.lblNumRods10.Width = 0.4480002F
			Me.lblNumRods11.Height = 0.145F
			Me.lblNumRods11.HyperLink = Nothing
			Me.lblNumRods11.Left = 2.79F
			Me.lblNumRods11.Name = "lblNumRods11"
			Me.lblNumRods11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods11.Text = " "
			Me.lblNumRods11.Top = 3.446F
			Me.lblNumRods11.Width = 0.4480002F
			Me.lblNumRods12.Height = 0.145F
			Me.lblNumRods12.HyperLink = Nothing
			Me.lblNumRods12.Left = 2.79F
			Me.lblNumRods12.Name = "lblNumRods12"
			Me.lblNumRods12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods12.Text = " "
			Me.lblNumRods12.Top = 3.601F
			Me.lblNumRods12.Width = 0.4480002F
			Me.lblNumRods13.Height = 0.145F
			Me.lblNumRods13.HyperLink = Nothing
			Me.lblNumRods13.Left = 2.79F
			Me.lblNumRods13.Name = "lblNumRods13"
			Me.lblNumRods13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods13.Text = " "
			Me.lblNumRods13.Top = 3.756F
			Me.lblNumRods13.Width = 0.4480002F
			Me.lblNumRods14.Height = 0.145F
			Me.lblNumRods14.HyperLink = Nothing
			Me.lblNumRods14.Left = 2.79F
			Me.lblNumRods14.Name = "lblNumRods14"
			Me.lblNumRods14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods14.Text = " "
			Me.lblNumRods14.Top = 3.911F
			Me.lblNumRods14.Width = 0.4480002F
			Me.lblNumRods15.Height = 0.145F
			Me.lblNumRods15.HyperLink = Nothing
			Me.lblNumRods15.Left = 2.79F
			Me.lblNumRods15.Name = "lblNumRods15"
			Me.lblNumRods15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods15.Text = " "
			Me.lblNumRods15.Top = 4.065999F
			Me.lblNumRods15.Width = 0.4480002F
			Me.lblNumRods17.Height = 0.145F
			Me.lblNumRods17.HyperLink = Nothing
			Me.lblNumRods17.Left = 2.79F
			Me.lblNumRods17.Name = "lblNumRods17"
			Me.lblNumRods17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods17.Text = " "
			Me.lblNumRods17.Top = 4.385999F
			Me.lblNumRods17.Width = 0.4480002F
			Me.lblNumRods16.Height = 0.145F
			Me.lblNumRods16.HyperLink = Nothing
			Me.lblNumRods16.Left = 2.79F
			Me.lblNumRods16.Name = "lblNumRods16"
			Me.lblNumRods16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods16.Text = " "
			Me.lblNumRods16.Top = 4.230999F
			Me.lblNumRods16.Width = 0.4480002F
			Me.lblNumRods18.Height = 0.145F
			Me.lblNumRods18.HyperLink = Nothing
			Me.lblNumRods18.Left = 2.79F
			Me.lblNumRods18.Name = "lblNumRods18"
			Me.lblNumRods18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods18.Text = " "
			Me.lblNumRods18.Top = 4.540999F
			Me.lblNumRods18.Width = 0.4480002F
			Me.lblNumRods19.Height = 0.145F
			Me.lblNumRods19.HyperLink = Nothing
			Me.lblNumRods19.Left = 2.79F
			Me.lblNumRods19.Name = "lblNumRods19"
			Me.lblNumRods19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods19.Text = " "
			Me.lblNumRods19.Top = 4.695999F
			Me.lblNumRods19.Width = 0.4480002F
			Me.lblNumRods20.Height = 0.145F
			Me.lblNumRods20.HyperLink = Nothing
			Me.lblNumRods20.Left = 2.79F
			Me.lblNumRods20.Name = "lblNumRods20"
			Me.lblNumRods20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblNumRods20.Text = " "
			Me.lblNumRods20.Top = 4.851F
			Me.lblNumRods20.Width = 0.4480002F
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
			CType(Me.lblTitle1, ISupportInitialize).EndInit()
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
			CType(Me.lblGuide1, ISupportInitialize).EndInit()
			CType(Me.lblGuide2, ISupportInitialize).EndInit()
			CType(Me.lblGuide3, ISupportInitialize).EndInit()
			CType(Me.lblGuide4, ISupportInitialize).EndInit()
			CType(Me.lblGuide5, ISupportInitialize).EndInit()
			CType(Me.lblGuide6, ISupportInitialize).EndInit()
			CType(Me.lblGuide7, ISupportInitialize).EndInit()
			CType(Me.lblGuide8, ISupportInitialize).EndInit()
			CType(Me.lblGuide9, ISupportInitialize).EndInit()
			CType(Me.lblGuide10, ISupportInitialize).EndInit()
			CType(Me.Label13, ISupportInitialize).EndInit()
			CType(Me.Label14, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide1, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide2, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide3, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide4, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide5, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide6, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide7, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide8, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide9, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide10, ISupportInitialize).EndInit()
			CType(Me.Label26, ISupportInitialize).EndInit()
			CType(Me.Label27, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod1, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod2, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod3, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod4, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod5, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod6, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod7, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod8, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod9, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod10, ISupportInitialize).EndInit()
			CType(Me.Label38, ISupportInitialize).EndInit()
			CType(Me.Label39, ISupportInitialize).EndInit()
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
			CType(Me.lblGuide11, ISupportInitialize).EndInit()
			CType(Me.lblGuide12, ISupportInitialize).EndInit()
			CType(Me.lblGuide13, ISupportInitialize).EndInit()
			CType(Me.lblGuide14, ISupportInitialize).EndInit()
			CType(Me.lblGuide15, ISupportInitialize).EndInit()
			CType(Me.lblGuide16, ISupportInitialize).EndInit()
			CType(Me.lblGuide17, ISupportInitialize).EndInit()
			CType(Me.lblGuide18, ISupportInitialize).EndInit()
			CType(Me.lblGuide19, ISupportInitialize).EndInit()
			CType(Me.lblGuide20, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide11, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide12, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide13, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide14, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide15, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide16, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide17, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide18, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide19, ISupportInitialize).EndInit()
			CType(Me.lblCostPerGuide20, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod11, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod12, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod13, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod14, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod15, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod16, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod17, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod18, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod19, ISupportInitialize).EndInit()
			CType(Me.lblGuidePerRod20, ISupportInitialize).EndInit()
			CType(Me.lblNumRodsHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblNumRodsHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblNumRods1, ISupportInitialize).EndInit()
			CType(Me.lblNumRods2, ISupportInitialize).EndInit()
			CType(Me.lblNumRods3, ISupportInitialize).EndInit()
			CType(Me.lblNumRods4, ISupportInitialize).EndInit()
			CType(Me.lblNumRods5, ISupportInitialize).EndInit()
			CType(Me.lblNumRods6, ISupportInitialize).EndInit()
			CType(Me.lblNumRods7, ISupportInitialize).EndInit()
			CType(Me.lblNumRods8, ISupportInitialize).EndInit()
			CType(Me.lblNumRods9, ISupportInitialize).EndInit()
			CType(Me.lblNumRods10, ISupportInitialize).EndInit()
			CType(Me.lblNumRods11, ISupportInitialize).EndInit()
			CType(Me.lblNumRods12, ISupportInitialize).EndInit()
			CType(Me.lblNumRods13, ISupportInitialize).EndInit()
			CType(Me.lblNumRods14, ISupportInitialize).EndInit()
			CType(Me.lblNumRods15, ISupportInitialize).EndInit()
			CType(Me.lblNumRods17, ISupportInitialize).EndInit()
			CType(Me.lblNumRods16, ISupportInitialize).EndInit()
			CType(Me.lblNumRods18, ISupportInitialize).EndInit()
			CType(Me.lblNumRods19, ISupportInitialize).EndInit()
			CType(Me.lblNumRods20, ISupportInitialize).EndInit()
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		Private Sub ReadReportControlStrings()
			Dim sPrefix As String = "rptCostAnalysis_D-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
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

		Private Sub PageHeader_Format(sender As Object, e As EventArgs)
		End Sub

		Private sCompany As String

		Private sWell As String

		Private sUser As String

		Private sDiskFile As String

		Private sDate As String

		Private sPage As String

		Private sOf As String

		Private sComment As String

		Private sAirAtTankAt As String

		Private sLicenseTo As String

		Private sThetaEnterprises As String

		Private sNA As String

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

		<AccessedThroughProperty("lblGuide9")>
		Private _lblGuide9 As Label

		<AccessedThroughProperty("lblGuide10")>
		Private _lblGuide10 As Label

		<AccessedThroughProperty("Label13")>
		Private _Label13 As Label

		<AccessedThroughProperty("Label14")>
		Private _Label14 As Label

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

		<AccessedThroughProperty("lblCostPerGuide9")>
		Private _lblCostPerGuide9 As Label

		<AccessedThroughProperty("lblCostPerGuide10")>
		Private _lblCostPerGuide10 As Label

		<AccessedThroughProperty("Label26")>
		Private _Label26 As Label

		<AccessedThroughProperty("Label27")>
		Private _Label27 As Label

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

		<AccessedThroughProperty("lblGuidePerRod9")>
		Private _lblGuidePerRod9 As Label

		<AccessedThroughProperty("lblGuidePerRod10")>
		Private _lblGuidePerRod10 As Label

		<AccessedThroughProperty("Label38")>
		Private _Label38 As Label

		<AccessedThroughProperty("Label39")>
		Private _Label39 As Label

		<AccessedThroughProperty("Line1")>
		Private _Line1 As Line

		<AccessedThroughProperty("Line2")>
		Private _Line2 As Line

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

		<AccessedThroughProperty("lblGuide11")>
		Private _lblGuide11 As Label

		<AccessedThroughProperty("lblGuide12")>
		Private _lblGuide12 As Label

		<AccessedThroughProperty("lblGuide13")>
		Private _lblGuide13 As Label

		<AccessedThroughProperty("lblGuide14")>
		Private _lblGuide14 As Label

		<AccessedThroughProperty("lblGuide15")>
		Private _lblGuide15 As Label

		<AccessedThroughProperty("lblGuide16")>
		Private _lblGuide16 As Label

		<AccessedThroughProperty("lblGuide17")>
		Private _lblGuide17 As Label

		<AccessedThroughProperty("lblGuide18")>
		Private _lblGuide18 As Label

		<AccessedThroughProperty("lblGuide19")>
		Private _lblGuide19 As Label

		<AccessedThroughProperty("lblGuide20")>
		Private _lblGuide20 As Label

		<AccessedThroughProperty("lblCostPerGuide11")>
		Private _lblCostPerGuide11 As Label

		<AccessedThroughProperty("lblCostPerGuide12")>
		Private _lblCostPerGuide12 As Label

		<AccessedThroughProperty("lblCostPerGuide13")>
		Private _lblCostPerGuide13 As Label

		<AccessedThroughProperty("lblCostPerGuide14")>
		Private _lblCostPerGuide14 As Label

		<AccessedThroughProperty("lblCostPerGuide15")>
		Private _lblCostPerGuide15 As Label

		<AccessedThroughProperty("lblCostPerGuide16")>
		Private _lblCostPerGuide16 As Label

		<AccessedThroughProperty("lblCostPerGuide17")>
		Private _lblCostPerGuide17 As Label

		<AccessedThroughProperty("lblCostPerGuide18")>
		Private _lblCostPerGuide18 As Label

		<AccessedThroughProperty("lblCostPerGuide19")>
		Private _lblCostPerGuide19 As Label

		<AccessedThroughProperty("lblCostPerGuide20")>
		Private _lblCostPerGuide20 As Label

		<AccessedThroughProperty("lblGuidePerRod11")>
		Private _lblGuidePerRod11 As Label

		<AccessedThroughProperty("lblGuidePerRod12")>
		Private _lblGuidePerRod12 As Label

		<AccessedThroughProperty("lblGuidePerRod13")>
		Private _lblGuidePerRod13 As Label

		<AccessedThroughProperty("lblGuidePerRod14")>
		Private _lblGuidePerRod14 As Label

		<AccessedThroughProperty("lblGuidePerRod15")>
		Private _lblGuidePerRod15 As Label

		<AccessedThroughProperty("lblGuidePerRod16")>
		Private _lblGuidePerRod16 As Label

		<AccessedThroughProperty("lblGuidePerRod17")>
		Private _lblGuidePerRod17 As Label

		<AccessedThroughProperty("lblGuidePerRod18")>
		Private _lblGuidePerRod18 As Label

		<AccessedThroughProperty("lblGuidePerRod19")>
		Private _lblGuidePerRod19 As Label

		<AccessedThroughProperty("lblGuidePerRod20")>
		Private _lblGuidePerRod20 As Label

		<AccessedThroughProperty("Line4")>
		Private _Line4 As Line

		<AccessedThroughProperty("lblNumRodsHdrTop")>
		Private _lblNumRodsHdrTop As Label

		<AccessedThroughProperty("lblNumRodsHdrBot")>
		Private _lblNumRodsHdrBot As Label

		<AccessedThroughProperty("lblNumRods1")>
		Private _lblNumRods1 As Label

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

		<AccessedThroughProperty("lblNumRods9")>
		Private _lblNumRods9 As Label

		<AccessedThroughProperty("lblNumRods10")>
		Private _lblNumRods10 As Label

		<AccessedThroughProperty("lblNumRods11")>
		Private _lblNumRods11 As Label

		<AccessedThroughProperty("lblNumRods12")>
		Private _lblNumRods12 As Label

		<AccessedThroughProperty("lblNumRods13")>
		Private _lblNumRods13 As Label

		<AccessedThroughProperty("lblNumRods14")>
		Private _lblNumRods14 As Label

		<AccessedThroughProperty("lblNumRods15")>
		Private _lblNumRods15 As Label

		<AccessedThroughProperty("lblNumRods17")>
		Private _lblNumRods17 As Label

		<AccessedThroughProperty("lblNumRods16")>
		Private _lblNumRods16 As Label

		<AccessedThroughProperty("lblNumRods18")>
		Private _lblNumRods18 As Label

		<AccessedThroughProperty("lblNumRods19")>
		Private _lblNumRods19 As Label

		<AccessedThroughProperty("lblNumRods20")>
		Private _lblNumRods20 As Label

		<AccessedThroughProperty("Line3")>
		Private _Line3 As Line

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
