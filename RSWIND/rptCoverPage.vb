Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports DDCssLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class rptCoverPage
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.rptCustomerCoverPage_ReportStart
			Me.sThetaEnterprises = Util.AssignValueToConstant("rptCalcResults", "sThetaEnterprises", "(c) Theta Oilfield Services, Inc.")
			Me.sElevatorNeck = Util.AssignValueToConstant("rptCalcResults", "sElevatorNeck", "elevator neck diameter of ")
			Me.sAsterickMsg = Util.AssignValueToConstant("rptCalcResults", "sAsterickMsg", "* May be too big for tubing.")
			Me.sPlusMsg = Util.AssignValueToConstant("rptCalcResults", "sPlusMsg", "+ Requires slimhole couplings.")
			Me.sAtSignMsg = Util.AssignValueToConstant("rptCalcResults", "sAtSignMsg", "@ Stress calculations based on elevator neck of 7/8"" (for 1.25"" sinker bars) or 1"" (for other sinker bars).")
			Me.sAtSignMsg_M = Util.AssignValueToConstant("rptCalcResults", "sAtSignMsg_M", "@ Stress calculations based on elevator neck of 22.2mm (for 31.8mm sinker bars) or 25.4mm (for other sinker bars).")
			Me.sPoundSignMsg = Util.AssignValueToConstant("rptCalcResults", "sPoundSignMsg", "# Sinker bar has no elevator neck.")
			Me.sNOTE1 = Util.AssignValueToConstant("rptCalcResults", "sNOTE1", "NOTE Stress calculations include buoyancy effects.")
			Me.sNOTE2 = Util.AssignValueToConstant("rptCalcResults", "sNOTE2", "NOTE Stress calculations do not include buoyancy effects.")
			Me.sNumGuides = Util.AssignValueToConstant("RSInput", "sNumGuides", "# Guides/Rod")
			Me.sStressCalc = Util.AssignValueToConstant("RSInput", "sStressCalc", "   Stress Calc.")
			Me.sMethod = Util.AssignValueToConstant("RSInput", "sMethod", "Method")
			Me.sNA = Util.AssignValueToConstant("rptCalcResults", "sNA", "N/A")
			Me.slbl = "lbl"
			Me.PageHeader = Nothing
			Me.Detail = Nothing
			Me.PageFooter = Nothing
			Me.lblAddr1 = Nothing
			Me.lblAddr2 = Nothing
			Me.imgLogo = Nothing
			Me.lblSecondCompanyContactName = Nothing
			Me.lblSecondCompanyPhone = Nothing
			Me.lblPage = Nothing
			Me.txtPage1 = Nothing
			Me.lblOf = Nothing
			Me.txtPage2 = Nothing
			Me.lblUserDate = Nothing
			Me.Line1 = Nothing
			Me.Line3 = Nothing
			Me.lblAddress = Nothing
			Me.Line4 = Nothing
			Me.Line5 = Nothing
			Me.rtbSecondCompanyComments = Nothing
			Me.txtCustomerCompany = Nothing
			Me.txtCustomerName = Nothing
			Me.lblComments = Nothing
			Me.lblRSFootnote5 = Nothing
			Me.lblRSFootnote4 = Nothing
			Me.lblRSFootnote3 = Nothing
			Me.lblRSFootnote2 = Nothing
			Me.lblRSFootnote1 = Nothing
			Me.linRSInputSep4 = Nothing
			Me.linRSInputSep1 = Nothing
			Me.linDivider = Nothing
			Me.linRSInputSep3 = Nothing
			Me.lblRodStringDesign = Nothing
			Me.Line11 = Nothing
			Me.lblRodDiamHdrTop = Nothing
			Me.lblRodDiamHdrBot = Nothing
			Me.lblRodDiam1 = Nothing
			Me.lblRodGradeHdrBot = Nothing
			Me.lblRodLengthHdrBot = Nothing
			Me.lblRodTensileStrengthHdrBot = Nothing
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
			Me.lblRodTensileStrength1 = Nothing
			Me.lblRodTensileStrength2 = Nothing
			Me.lblRodTensileStrength3 = Nothing
			Me.lblRodTensileStrength4 = Nothing
			Me.lblRodTensileStrength5 = Nothing
			Me.lblRodTensileStrength6 = Nothing
			Me.lblRodTensileStrength7 = Nothing
			Me.lblRodTensileStrength8 = Nothing
			Me.lblRodStringResults = Nothing
			Me.Line13 = Nothing
			Me.lblRodStressHdrBot = Nothing
			Me.lblRodStress1 = Nothing
			Me.lblRodTopMaxStressHdrBot = Nothing
			Me.lblRodTopMinStressHdrBot = Nothing
			Me.lblRodBotMinStressHdrBot = Nothing
			Me.Line14 = Nothing
			Me.lblRodStress2 = Nothing
			Me.lblRodStress3 = Nothing
			Me.lblRodStress4 = Nothing
			Me.lblRodStress5 = Nothing
			Me.lblRodStress6 = Nothing
			Me.lblRodStress7 = Nothing
			Me.lblRodStress8 = Nothing
			Me.lblRodTopMaxStress1 = Nothing
			Me.lblRodTopMaxStress2 = Nothing
			Me.lblRodTopMaxStress3 = Nothing
			Me.lblRodTopMaxStress4 = Nothing
			Me.lblRodTopMaxStress5 = Nothing
			Me.lblRodTopMaxStress6 = Nothing
			Me.lblRodTopMaxStress7 = Nothing
			Me.lblRodTopMaxStress8 = Nothing
			Me.lblRodTopMinStress1 = Nothing
			Me.lblRodTopMinStress2 = Nothing
			Me.lblRodTopMinStress3 = Nothing
			Me.lblRodTopMinStress4 = Nothing
			Me.lblRodTopMinStress5 = Nothing
			Me.lblRodTopMinStress6 = Nothing
			Me.lblRodTopMinStress7 = Nothing
			Me.lblRodTopMinStress8 = Nothing
			Me.lblRodBotMinStress1 = Nothing
			Me.lblRodBotMinStress2 = Nothing
			Me.lblRodBotMinStress3 = Nothing
			Me.lblRodBotMinStress4 = Nothing
			Me.lblRodBotMinStress5 = Nothing
			Me.lblRodBotMinStress6 = Nothing
			Me.lblRodBotMinStress7 = Nothing
			Me.lblRodBotMinStress8 = Nothing
			Me.lblRodStressMethodHdrBot = Nothing
			Me.lblRodStressMethod1 = Nothing
			Me.lblRodStressMethod2 = Nothing
			Me.lblRodStressMethod3 = Nothing
			Me.lblRodStressMethod4 = Nothing
			Me.lblRodStressMethod5 = Nothing
			Me.lblRodStressMethod6 = Nothing
			Me.lblRodStressMethod7 = Nothing
			Me.lblRodStressMethod8 = Nothing
			Me.lblRodGradeHdrTop = Nothing
			Me.lblRodTopMinStressHdrTop = Nothing
			Me.lblRodBotMinStressHdrTop = Nothing
			Me.lblRodStressMethodHdrTop = Nothing
			Me.lblRodTopMaxStressHdrTop = Nothing
			Me.lblRodStressHdrTop = Nothing
			Me.lblRodTensileStrengthHdrTop = Nothing
			Me.lblRodLengthHdrTop = Nothing
			Me.linRSCalcSep3 = Nothing
			Me.linRSCalcSep1 = Nothing
			Me.linRSCalcSep2 = Nothing
			Me.linRSCalcSep4 = Nothing
			Me.lblFricCoef1 = Nothing
			Me.lblFricCoef2 = Nothing
			Me.lblFricCoef3 = Nothing
			Me.lblFricCoef4 = Nothing
			Me.lblFricCoef5 = Nothing
			Me.lblFricCoef6 = Nothing
			Me.lblFricCoef7 = Nothing
			Me.lblFricCoef8 = Nothing
			Me.lblFric = Nothing
			Me.lblCoeff = Nothing
			Me.lblRodDiam9 = Nothing
			Me.lblRodGrade9 = Nothing
			Me.lblRodLength9 = Nothing
			Me.lblRodTensileStrength9 = Nothing
			Me.lblFricCoef9 = Nothing
			Me.lblRodStress9 = Nothing
			Me.lblRodTopMaxStress9 = Nothing
			Me.lblRodTopMinStress9 = Nothing
			Me.lblRodBotMinStress9 = Nothing
			Me.lblRodStressMethod9 = Nothing
			Me.lblRodDiam10 = Nothing
			Me.lblRodGrade10 = Nothing
			Me.lblRodLength10 = Nothing
			Me.lblRodTensileStrength10 = Nothing
			Me.lblFricCoef10 = Nothing
			Me.lblRodStress10 = Nothing
			Me.lblRodTopMaxStress10 = Nothing
			Me.lblRodTopMinStress10 = Nothing
			Me.lblRodBotMinStress10 = Nothing
			Me.lblRodStressMethod10 = Nothing
			Me.linRSInputSep2 = Nothing
			Me.rtbSecondCompanyComments2 = Nothing
			Me.lblFootnote = Nothing
			Me.Line2 = Nothing
			Me.sDate = Util.AssignValueToConstant("rptCalcResults", "sDate", "Date: ")
			Me.sPage = Util.AssignValueToConstant("rptCalcResults", "sPage", "Page")
			Me.sOf = Util.AssignValueToConstant("rptCalcResults", "sOf", "of")
			Me.InitializeComponent()
		End Sub

		Public Property LastTop As Single
			Get
				Return Me.m_LastTop
			End Get
			Set(value As Single)
				Me.m_LastTop = value
			End Set
		End Property

		Public Property LastHeight As Single
			Get
				Return Me.m_LastHeight
			End Get
			Set(value As Single)
				Me.m_LastHeight = value
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

		Private Overridable Property lblSecondCompanyName As Label
			Get
				Return Me._lblSecondCompanyName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSecondCompanyName = value
			End Set
		End Property

		Private Overridable Property lblSecondCompanyWebsite As Label
			Get
				Return Me._lblSecondCompanyWebsite
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSecondCompanyWebsite = value
			End Set
		End Property

		Private Overridable Property lblRodTensileStrength11 As Label
			Get
				Return Me._lblRodTensileStrength11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTensileStrength11 = value
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

		Private Overridable Property lblRodTensileStrength12 As Label
			Get
				Return Me._lblRodTensileStrength12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTensileStrength12 = value
			End Set
		End Property

		Private Overridable Property lblRodTensileStrength13 As Label
			Get
				Return Me._lblRodTensileStrength13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTensileStrength13 = value
			End Set
		End Property

		Private Overridable Property lblRodTensileStrength14 As Label
			Get
				Return Me._lblRodTensileStrength14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTensileStrength14 = value
			End Set
		End Property

		Private Overridable Property lblRodTensileStrength15 As Label
			Get
				Return Me._lblRodTensileStrength15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTensileStrength15 = value
			End Set
		End Property

		Private Overridable Property lblRodTensileStrength16 As Label
			Get
				Return Me._lblRodTensileStrength16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTensileStrength16 = value
			End Set
		End Property

		Private Overridable Property lblRodTensileStrength17 As Label
			Get
				Return Me._lblRodTensileStrength17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTensileStrength17 = value
			End Set
		End Property

		Private Overridable Property lblRodTensileStrength18 As Label
			Get
				Return Me._lblRodTensileStrength18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTensileStrength18 = value
			End Set
		End Property

		Private Overridable Property lblRodStress11 As Label
			Get
				Return Me._lblRodStress11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStress11 = value
			End Set
		End Property

		Private Overridable Property lblRodStress12 As Label
			Get
				Return Me._lblRodStress12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStress12 = value
			End Set
		End Property

		Private Overridable Property lblRodStress13 As Label
			Get
				Return Me._lblRodStress13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStress13 = value
			End Set
		End Property

		Private Overridable Property lblRodStress14 As Label
			Get
				Return Me._lblRodStress14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStress14 = value
			End Set
		End Property

		Private Overridable Property lblRodStress15 As Label
			Get
				Return Me._lblRodStress15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStress15 = value
			End Set
		End Property

		Private Overridable Property lblRodStress16 As Label
			Get
				Return Me._lblRodStress16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStress16 = value
			End Set
		End Property

		Private Overridable Property lblRodStress17 As Label
			Get
				Return Me._lblRodStress17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStress17 = value
			End Set
		End Property

		Private Overridable Property lblRodStress18 As Label
			Get
				Return Me._lblRodStress18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStress18 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMaxStress11 As Label
			Get
				Return Me._lblRodTopMaxStress11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMaxStress11 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMaxStress12 As Label
			Get
				Return Me._lblRodTopMaxStress12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMaxStress12 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMaxStress13 As Label
			Get
				Return Me._lblRodTopMaxStress13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMaxStress13 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMaxStress14 As Label
			Get
				Return Me._lblRodTopMaxStress14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMaxStress14 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMaxStress15 As Label
			Get
				Return Me._lblRodTopMaxStress15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMaxStress15 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMaxStress16 As Label
			Get
				Return Me._lblRodTopMaxStress16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMaxStress16 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMaxStress17 As Label
			Get
				Return Me._lblRodTopMaxStress17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMaxStress17 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMaxStress18 As Label
			Get
				Return Me._lblRodTopMaxStress18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMaxStress18 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMinStress11 As Label
			Get
				Return Me._lblRodTopMinStress11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMinStress11 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMinStress12 As Label
			Get
				Return Me._lblRodTopMinStress12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMinStress12 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMinStress13 As Label
			Get
				Return Me._lblRodTopMinStress13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMinStress13 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMinStress14 As Label
			Get
				Return Me._lblRodTopMinStress14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMinStress14 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMinStress15 As Label
			Get
				Return Me._lblRodTopMinStress15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMinStress15 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMinStress16 As Label
			Get
				Return Me._lblRodTopMinStress16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMinStress16 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMinStress17 As Label
			Get
				Return Me._lblRodTopMinStress17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMinStress17 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMinStress18 As Label
			Get
				Return Me._lblRodTopMinStress18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMinStress18 = value
			End Set
		End Property

		Private Overridable Property lblRodBotMinStress11 As Label
			Get
				Return Me._lblRodBotMinStress11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodBotMinStress11 = value
			End Set
		End Property

		Private Overridable Property lblRodBotMinStress12 As Label
			Get
				Return Me._lblRodBotMinStress12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodBotMinStress12 = value
			End Set
		End Property

		Private Overridable Property lblRodBotMinStress13 As Label
			Get
				Return Me._lblRodBotMinStress13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodBotMinStress13 = value
			End Set
		End Property

		Private Overridable Property lblRodBotMinStress14 As Label
			Get
				Return Me._lblRodBotMinStress14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodBotMinStress14 = value
			End Set
		End Property

		Private Overridable Property lblRodBotMinStress15 As Label
			Get
				Return Me._lblRodBotMinStress15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodBotMinStress15 = value
			End Set
		End Property

		Private Overridable Property lblRodBotMinStress16 As Label
			Get
				Return Me._lblRodBotMinStress16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodBotMinStress16 = value
			End Set
		End Property

		Private Overridable Property lblRodBotMinStress17 As Label
			Get
				Return Me._lblRodBotMinStress17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodBotMinStress17 = value
			End Set
		End Property

		Private Overridable Property lblRodBotMinStress18 As Label
			Get
				Return Me._lblRodBotMinStress18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodBotMinStress18 = value
			End Set
		End Property

		Private Overridable Property lblRodStressMethod11 As Label
			Get
				Return Me._lblRodStressMethod11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStressMethod11 = value
			End Set
		End Property

		Private Overridable Property lblRodStressMethod12 As Label
			Get
				Return Me._lblRodStressMethod12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStressMethod12 = value
			End Set
		End Property

		Private Overridable Property lblRodStressMethod13 As Label
			Get
				Return Me._lblRodStressMethod13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStressMethod13 = value
			End Set
		End Property

		Private Overridable Property lblRodStressMethod14 As Label
			Get
				Return Me._lblRodStressMethod14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStressMethod14 = value
			End Set
		End Property

		Private Overridable Property lblRodStressMethod15 As Label
			Get
				Return Me._lblRodStressMethod15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStressMethod15 = value
			End Set
		End Property

		Private Overridable Property lblRodStressMethod16 As Label
			Get
				Return Me._lblRodStressMethod16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStressMethod16 = value
			End Set
		End Property

		Private Overridable Property lblRodStressMethod17 As Label
			Get
				Return Me._lblRodStressMethod17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStressMethod17 = value
			End Set
		End Property

		Private Overridable Property lblRodStressMethod18 As Label
			Get
				Return Me._lblRodStressMethod18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStressMethod18 = value
			End Set
		End Property

		Private Overridable Property lblFricCoef11 As Label
			Get
				Return Me._lblFricCoef11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFricCoef11 = value
			End Set
		End Property

		Private Overridable Property lblFricCoef12 As Label
			Get
				Return Me._lblFricCoef12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFricCoef12 = value
			End Set
		End Property

		Private Overridable Property lblFricCoef13 As Label
			Get
				Return Me._lblFricCoef13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFricCoef13 = value
			End Set
		End Property

		Private Overridable Property lblFricCoef14 As Label
			Get
				Return Me._lblFricCoef14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFricCoef14 = value
			End Set
		End Property

		Private Overridable Property lblFricCoef15 As Label
			Get
				Return Me._lblFricCoef15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFricCoef15 = value
			End Set
		End Property

		Private Overridable Property lblFricCoef16 As Label
			Get
				Return Me._lblFricCoef16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFricCoef16 = value
			End Set
		End Property

		Private Overridable Property lblFricCoef17 As Label
			Get
				Return Me._lblFricCoef17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFricCoef17 = value
			End Set
		End Property

		Private Overridable Property lblFricCoef18 As Label
			Get
				Return Me._lblFricCoef18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFricCoef18 = value
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

		Private Overridable Property lblRodTensileStrength19 As Label
			Get
				Return Me._lblRodTensileStrength19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTensileStrength19 = value
			End Set
		End Property

		Private Overridable Property lblFricCoef19 As Label
			Get
				Return Me._lblFricCoef19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFricCoef19 = value
			End Set
		End Property

		Private Overridable Property lblRodStress19 As Label
			Get
				Return Me._lblRodStress19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStress19 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMaxStress19 As Label
			Get
				Return Me._lblRodTopMaxStress19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMaxStress19 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMinStress19 As Label
			Get
				Return Me._lblRodTopMinStress19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMinStress19 = value
			End Set
		End Property

		Private Overridable Property lblRodBotMinStress19 As Label
			Get
				Return Me._lblRodBotMinStress19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodBotMinStress19 = value
			End Set
		End Property

		Private Overridable Property lblRodStressMethod19 As Label
			Get
				Return Me._lblRodStressMethod19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStressMethod19 = value
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

		Private Overridable Property lblRodTensileStrength20 As Label
			Get
				Return Me._lblRodTensileStrength20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTensileStrength20 = value
			End Set
		End Property

		Private Overridable Property lblFricCoef20 As Label
			Get
				Return Me._lblFricCoef20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFricCoef20 = value
			End Set
		End Property

		Private Overridable Property lblRodStress20 As Label
			Get
				Return Me._lblRodStress20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStress20 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMaxStress20 As Label
			Get
				Return Me._lblRodTopMaxStress20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMaxStress20 = value
			End Set
		End Property

		Private Overridable Property lblRodTopMinStress20 As Label
			Get
				Return Me._lblRodTopMinStress20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodTopMinStress20 = value
			End Set
		End Property

		Private Overridable Property lblRodBotMinStress20 As Label
			Get
				Return Me._lblRodBotMinStress20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodBotMinStress20 = value
			End Set
		End Property

		Private Overridable Property lblRodStressMethod20 As Label
			Get
				Return Me._lblRodStressMethod20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodStressMethod20 = value
			End Set
		End Property

		Private Sub InitializeComponent()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptCoverPage))
			Me.Detail = New Detail()
			Me.rtbSecondCompanyComments = New RichTextBox()
			Me.txtCustomerCompany = New TextBox()
			Me.txtCustomerName = New TextBox()
			Me.lblComments = New TextBox()
			Me.lblRSFootnote5 = New Label()
			Me.lblRSFootnote4 = New Label()
			Me.lblRSFootnote3 = New Label()
			Me.lblRSFootnote2 = New Label()
			Me.lblRSFootnote1 = New Label()
			Me.linRSInputSep4 = New Line()
			Me.linRSInputSep1 = New Line()
			Me.linDivider = New Line()
			Me.linRSInputSep3 = New Line()
			Me.lblRodStringDesign = New Label()
			Me.Line11 = New Line()
			Me.lblRodDiamHdrTop = New Label()
			Me.lblRodDiamHdrBot = New Label()
			Me.lblRodDiam1 = New Label()
			Me.lblRodGradeHdrBot = New Label()
			Me.lblRodLengthHdrBot = New Label()
			Me.lblRodTensileStrengthHdrBot = New Label()
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
			Me.lblRodTensileStrength1 = New Label()
			Me.lblRodTensileStrength2 = New Label()
			Me.lblRodTensileStrength3 = New Label()
			Me.lblRodTensileStrength4 = New Label()
			Me.lblRodTensileStrength5 = New Label()
			Me.lblRodTensileStrength6 = New Label()
			Me.lblRodTensileStrength7 = New Label()
			Me.lblRodTensileStrength8 = New Label()
			Me.lblRodStringResults = New Label()
			Me.Line13 = New Line()
			Me.lblRodStressHdrBot = New Label()
			Me.lblRodStress1 = New Label()
			Me.lblRodTopMaxStressHdrBot = New Label()
			Me.lblRodTopMinStressHdrBot = New Label()
			Me.lblRodBotMinStressHdrBot = New Label()
			Me.Line14 = New Line()
			Me.lblRodStress2 = New Label()
			Me.lblRodStress3 = New Label()
			Me.lblRodStress4 = New Label()
			Me.lblRodStress5 = New Label()
			Me.lblRodStress6 = New Label()
			Me.lblRodStress7 = New Label()
			Me.lblRodStress8 = New Label()
			Me.lblRodTopMaxStress1 = New Label()
			Me.lblRodTopMaxStress2 = New Label()
			Me.lblRodTopMaxStress3 = New Label()
			Me.lblRodTopMaxStress4 = New Label()
			Me.lblRodTopMaxStress5 = New Label()
			Me.lblRodTopMaxStress6 = New Label()
			Me.lblRodTopMaxStress7 = New Label()
			Me.lblRodTopMaxStress8 = New Label()
			Me.lblRodTopMinStress1 = New Label()
			Me.lblRodTopMinStress2 = New Label()
			Me.lblRodTopMinStress3 = New Label()
			Me.lblRodTopMinStress4 = New Label()
			Me.lblRodTopMinStress5 = New Label()
			Me.lblRodTopMinStress6 = New Label()
			Me.lblRodTopMinStress7 = New Label()
			Me.lblRodTopMinStress8 = New Label()
			Me.lblRodBotMinStress1 = New Label()
			Me.lblRodBotMinStress2 = New Label()
			Me.lblRodBotMinStress3 = New Label()
			Me.lblRodBotMinStress4 = New Label()
			Me.lblRodBotMinStress5 = New Label()
			Me.lblRodBotMinStress6 = New Label()
			Me.lblRodBotMinStress7 = New Label()
			Me.lblRodBotMinStress8 = New Label()
			Me.lblRodStressMethodHdrBot = New Label()
			Me.lblRodStressMethod1 = New Label()
			Me.lblRodStressMethod2 = New Label()
			Me.lblRodStressMethod3 = New Label()
			Me.lblRodStressMethod4 = New Label()
			Me.lblRodStressMethod5 = New Label()
			Me.lblRodStressMethod6 = New Label()
			Me.lblRodStressMethod7 = New Label()
			Me.lblRodStressMethod8 = New Label()
			Me.lblRodGradeHdrTop = New Label()
			Me.lblRodTopMinStressHdrTop = New Label()
			Me.lblRodBotMinStressHdrTop = New Label()
			Me.lblRodStressMethodHdrTop = New Label()
			Me.lblRodTopMaxStressHdrTop = New Label()
			Me.lblRodStressHdrTop = New Label()
			Me.lblRodTensileStrengthHdrTop = New Label()
			Me.lblRodLengthHdrTop = New Label()
			Me.linRSCalcSep3 = New Line()
			Me.linRSCalcSep1 = New Line()
			Me.linRSCalcSep2 = New Line()
			Me.linRSCalcSep4 = New Line()
			Me.lblFricCoef1 = New Label()
			Me.lblFricCoef2 = New Label()
			Me.lblFricCoef3 = New Label()
			Me.lblFricCoef4 = New Label()
			Me.lblFricCoef5 = New Label()
			Me.lblFricCoef6 = New Label()
			Me.lblFricCoef7 = New Label()
			Me.lblFricCoef8 = New Label()
			Me.lblFric = New Label()
			Me.lblCoeff = New Label()
			Me.lblRodDiam9 = New Label()
			Me.lblRodGrade9 = New Label()
			Me.lblRodLength9 = New Label()
			Me.lblRodTensileStrength9 = New Label()
			Me.lblFricCoef9 = New Label()
			Me.lblRodStress9 = New Label()
			Me.lblRodTopMaxStress9 = New Label()
			Me.lblRodTopMinStress9 = New Label()
			Me.lblRodBotMinStress9 = New Label()
			Me.lblRodStressMethod9 = New Label()
			Me.lblRodDiam10 = New Label()
			Me.lblRodGrade10 = New Label()
			Me.lblRodLength10 = New Label()
			Me.lblRodTensileStrength10 = New Label()
			Me.lblFricCoef10 = New Label()
			Me.lblRodStress10 = New Label()
			Me.lblRodTopMaxStress10 = New Label()
			Me.lblRodTopMinStress10 = New Label()
			Me.lblRodBotMinStress10 = New Label()
			Me.lblRodStressMethod10 = New Label()
			Me.linRSInputSep2 = New Line()
			Me.rtbSecondCompanyComments2 = New RichTextBox()
			Me.lblRodTensileStrength11 = New Label()
			Me.lblRodLength11 = New Label()
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
			Me.lblRodLength12 = New Label()
			Me.lblRodLength13 = New Label()
			Me.lblRodLength14 = New Label()
			Me.lblRodLength15 = New Label()
			Me.lblRodLength16 = New Label()
			Me.lblRodLength17 = New Label()
			Me.lblRodLength18 = New Label()
			Me.lblRodTensileStrength12 = New Label()
			Me.lblRodTensileStrength13 = New Label()
			Me.lblRodTensileStrength14 = New Label()
			Me.lblRodTensileStrength15 = New Label()
			Me.lblRodTensileStrength16 = New Label()
			Me.lblRodTensileStrength17 = New Label()
			Me.lblRodTensileStrength18 = New Label()
			Me.lblRodStress11 = New Label()
			Me.lblRodStress12 = New Label()
			Me.lblRodStress13 = New Label()
			Me.lblRodStress14 = New Label()
			Me.lblRodStress15 = New Label()
			Me.lblRodStress16 = New Label()
			Me.lblRodStress17 = New Label()
			Me.lblRodStress18 = New Label()
			Me.lblRodTopMaxStress11 = New Label()
			Me.lblRodTopMaxStress12 = New Label()
			Me.lblRodTopMaxStress13 = New Label()
			Me.lblRodTopMaxStress14 = New Label()
			Me.lblRodTopMaxStress15 = New Label()
			Me.lblRodTopMaxStress16 = New Label()
			Me.lblRodTopMaxStress17 = New Label()
			Me.lblRodTopMaxStress18 = New Label()
			Me.lblRodTopMinStress11 = New Label()
			Me.lblRodTopMinStress12 = New Label()
			Me.lblRodTopMinStress13 = New Label()
			Me.lblRodTopMinStress14 = New Label()
			Me.lblRodTopMinStress15 = New Label()
			Me.lblRodTopMinStress16 = New Label()
			Me.lblRodTopMinStress17 = New Label()
			Me.lblRodTopMinStress18 = New Label()
			Me.lblRodBotMinStress11 = New Label()
			Me.lblRodBotMinStress12 = New Label()
			Me.lblRodBotMinStress13 = New Label()
			Me.lblRodBotMinStress14 = New Label()
			Me.lblRodBotMinStress15 = New Label()
			Me.lblRodBotMinStress16 = New Label()
			Me.lblRodBotMinStress17 = New Label()
			Me.lblRodBotMinStress18 = New Label()
			Me.lblRodStressMethod11 = New Label()
			Me.lblRodStressMethod12 = New Label()
			Me.lblRodStressMethod13 = New Label()
			Me.lblRodStressMethod14 = New Label()
			Me.lblRodStressMethod15 = New Label()
			Me.lblRodStressMethod16 = New Label()
			Me.lblRodStressMethod17 = New Label()
			Me.lblRodStressMethod18 = New Label()
			Me.lblFricCoef11 = New Label()
			Me.lblFricCoef12 = New Label()
			Me.lblFricCoef13 = New Label()
			Me.lblFricCoef14 = New Label()
			Me.lblFricCoef15 = New Label()
			Me.lblFricCoef16 = New Label()
			Me.lblFricCoef17 = New Label()
			Me.lblFricCoef18 = New Label()
			Me.lblRodDiam19 = New Label()
			Me.lblRodGrade19 = New Label()
			Me.lblRodLength19 = New Label()
			Me.lblRodTensileStrength19 = New Label()
			Me.lblFricCoef19 = New Label()
			Me.lblRodStress19 = New Label()
			Me.lblRodTopMaxStress19 = New Label()
			Me.lblRodTopMinStress19 = New Label()
			Me.lblRodBotMinStress19 = New Label()
			Me.lblRodStressMethod19 = New Label()
			Me.lblRodDiam20 = New Label()
			Me.lblRodGrade20 = New Label()
			Me.lblRodLength20 = New Label()
			Me.lblRodTensileStrength20 = New Label()
			Me.lblFricCoef20 = New Label()
			Me.lblRodStress20 = New Label()
			Me.lblRodTopMaxStress20 = New Label()
			Me.lblRodTopMinStress20 = New Label()
			Me.lblRodBotMinStress20 = New Label()
			Me.lblRodStressMethod20 = New Label()
			Me.PageHeader = New PageHeader()
			Me.lblAddr1 = New Label()
			Me.lblAddr2 = New Label()
			Me.imgLogo = New Picture()
			Me.lblSecondCompanyContactName = New Label()
			Me.lblSecondCompanyPhone = New Label()
			Me.lblPage = New Label()
			Me.txtPage1 = New TextBox()
			Me.lblOf = New Label()
			Me.txtPage2 = New TextBox()
			Me.lblUserDate = New Label()
			Me.Line1 = New Line()
			Me.Line3 = New Line()
			Me.lblAddress = New Label()
			Me.Line4 = New Line()
			Me.Line5 = New Line()
			Me.lblSecondCompanyName = New Label()
			Me.lblSecondCompanyWebsite = New Label()
			Me.PageFooter = New PageFooter()
			Me.lblFootnote = New Label()
			Me.Line2 = New Line()
			CType(Me.txtCustomerCompany, ISupportInitialize).BeginInit()
			CType(Me.txtCustomerName, ISupportInitialize).BeginInit()
			CType(Me.lblComments, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote5, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote4, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote3, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote2, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote1, ISupportInitialize).BeginInit()
			CType(Me.lblRodStringDesign, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiamHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiamHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam1, ISupportInitialize).BeginInit()
			CType(Me.lblRodGradeHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodLengthHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrengthHdrBot, ISupportInitialize).BeginInit()
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
			CType(Me.lblRodTensileStrength1, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength2, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength3, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength4, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength5, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength6, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength7, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength8, ISupportInitialize).BeginInit()
			CType(Me.lblRodStringResults, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress1, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStressHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStressHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStressHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress2, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress3, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress4, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress5, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress6, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress7, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress8, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress1, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress2, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress3, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress4, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress5, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress6, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress7, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress8, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress1, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress2, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress3, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress4, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress5, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress6, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress7, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress8, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress1, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress2, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress3, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress4, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress5, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress6, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress7, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress8, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethodHdrBot, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod1, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod2, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod3, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod4, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod5, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod6, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod7, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod8, ISupportInitialize).BeginInit()
			CType(Me.lblRodGradeHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStressHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStressHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethodHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStressHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrengthHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodLengthHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef1, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef2, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef3, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef4, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef5, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef6, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef7, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef8, ISupportInitialize).BeginInit()
			CType(Me.lblFric, ISupportInitialize).BeginInit()
			CType(Me.lblCoeff, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam9, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade9, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength9, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength9, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef9, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress9, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress9, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress9, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress9, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod9, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam10, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade10, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength10, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength10, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef10, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress10, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress10, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress10, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress10, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod10, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength11, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength11, ISupportInitialize).BeginInit()
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
			CType(Me.lblRodLength12, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength13, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength14, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength15, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength16, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength17, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength18, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength12, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength13, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength14, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength15, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength16, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength17, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength18, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress11, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress12, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress13, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress14, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress15, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress16, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress17, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress18, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress11, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress12, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress13, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress14, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress15, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress16, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress17, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress18, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress11, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress12, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress13, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress14, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress15, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress16, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress17, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress18, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress11, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress12, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress13, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress14, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress15, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress16, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress17, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress18, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod11, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod12, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod13, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod14, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod15, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod16, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod17, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod18, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef11, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef12, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef13, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef14, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef15, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef16, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef17, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef18, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam19, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade19, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength19, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength19, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef19, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress19, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress19, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress19, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress19, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod19, ISupportInitialize).BeginInit()
			CType(Me.lblRodDiam20, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade20, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength20, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength20, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef20, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress20, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress20, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress20, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress20, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod20, ISupportInitialize).BeginInit()
			CType(Me.lblAddr1, ISupportInitialize).BeginInit()
			CType(Me.lblAddr2, ISupportInitialize).BeginInit()
			CType(Me.imgLogo, ISupportInitialize).BeginInit()
			CType(Me.lblSecondCompanyContactName, ISupportInitialize).BeginInit()
			CType(Me.lblSecondCompanyPhone, ISupportInitialize).BeginInit()
			CType(Me.lblPage, ISupportInitialize).BeginInit()
			CType(Me.txtPage1, ISupportInitialize).BeginInit()
			CType(Me.lblOf, ISupportInitialize).BeginInit()
			CType(Me.txtPage2, ISupportInitialize).BeginInit()
			CType(Me.lblUserDate, ISupportInitialize).BeginInit()
			CType(Me.lblAddress, ISupportInitialize).BeginInit()
			CType(Me.lblSecondCompanyName, ISupportInitialize).BeginInit()
			CType(Me.lblSecondCompanyWebsite, ISupportInitialize).BeginInit()
			CType(Me.lblFootnote, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Controls.AddRange(New ARControl() { Me.rtbSecondCompanyComments, Me.txtCustomerCompany, Me.txtCustomerName, Me.lblComments, Me.lblRSFootnote5, Me.lblRSFootnote4, Me.lblRSFootnote3, Me.lblRSFootnote2, Me.lblRSFootnote1, Me.linRSInputSep4, Me.linRSInputSep1, Me.linDivider, Me.linRSInputSep3, Me.lblRodStringDesign, Me.Line11, Me.lblRodDiamHdrTop, Me.lblRodDiamHdrBot, Me.lblRodDiam1, Me.lblRodGradeHdrBot, Me.lblRodLengthHdrBot, Me.lblRodTensileStrengthHdrBot, Me.Line12, Me.lblRodDiam2, Me.lblRodDiam3, Me.lblRodDiam4, Me.lblRodDiam5, Me.lblRodDiam6, Me.lblRodDiam7, Me.lblRodDiam8, Me.lblRodGrade1, Me.lblRodGrade2, Me.lblRodGrade3, Me.lblRodGrade4, Me.lblRodGrade5, Me.lblRodGrade6, Me.lblRodGrade7, Me.lblRodGrade8, Me.lblRodLength1, Me.lblRodLength2, Me.lblRodLength3, Me.lblRodLength4, Me.lblRodLength5, Me.lblRodLength6, Me.lblRodLength7, Me.lblRodLength8, Me.lblRodTensileStrength1, Me.lblRodTensileStrength2, Me.lblRodTensileStrength3, Me.lblRodTensileStrength4, Me.lblRodTensileStrength5, Me.lblRodTensileStrength6, Me.lblRodTensileStrength7, Me.lblRodTensileStrength8, Me.lblRodStringResults, Me.Line13, Me.lblRodStressHdrBot, Me.lblRodStress1, Me.lblRodTopMaxStressHdrBot, Me.lblRodTopMinStressHdrBot, Me.lblRodBotMinStressHdrBot, Me.Line14, Me.lblRodStress2, Me.lblRodStress3, Me.lblRodStress4, Me.lblRodStress5, Me.lblRodStress6, Me.lblRodStress7, Me.lblRodStress8, Me.lblRodTopMaxStress1, Me.lblRodTopMaxStress2, Me.lblRodTopMaxStress3, Me.lblRodTopMaxStress4, Me.lblRodTopMaxStress5, Me.lblRodTopMaxStress6, Me.lblRodTopMaxStress7, Me.lblRodTopMaxStress8, Me.lblRodTopMinStress1, Me.lblRodTopMinStress2, Me.lblRodTopMinStress3, Me.lblRodTopMinStress4, Me.lblRodTopMinStress5, Me.lblRodTopMinStress6, Me.lblRodTopMinStress7, Me.lblRodTopMinStress8, Me.lblRodBotMinStress1, Me.lblRodBotMinStress2, Me.lblRodBotMinStress3, Me.lblRodBotMinStress4, Me.lblRodBotMinStress5, Me.lblRodBotMinStress6, Me.lblRodBotMinStress7, Me.lblRodBotMinStress8, Me.lblRodStressMethodHdrBot, Me.lblRodStressMethod1, Me.lblRodStressMethod2, Me.lblRodStressMethod3, Me.lblRodStressMethod4, Me.lblRodStressMethod5, Me.lblRodStressMethod6, Me.lblRodStressMethod7, Me.lblRodStressMethod8, Me.lblRodGradeHdrTop, Me.lblRodTopMinStressHdrTop, Me.lblRodBotMinStressHdrTop, Me.lblRodStressMethodHdrTop, Me.lblRodTopMaxStressHdrTop, Me.lblRodStressHdrTop, Me.lblRodTensileStrengthHdrTop, Me.lblRodLengthHdrTop, Me.linRSCalcSep3, Me.linRSCalcSep1, Me.linRSCalcSep2, Me.linRSCalcSep4, Me.lblFricCoef1, Me.lblFricCoef2, Me.lblFricCoef3, Me.lblFricCoef4, Me.lblFricCoef5, Me.lblFricCoef6, Me.lblFricCoef7, Me.lblFricCoef8, Me.lblFric, Me.lblCoeff, Me.lblRodDiam9, Me.lblRodGrade9, Me.lblRodLength9, Me.lblRodTensileStrength9, Me.lblFricCoef9, Me.lblRodStress9, Me.lblRodTopMaxStress9, Me.lblRodTopMinStress9, Me.lblRodBotMinStress9, Me.lblRodStressMethod9, Me.lblRodDiam10, Me.lblRodGrade10, Me.lblRodLength10, Me.lblRodTensileStrength10, Me.lblFricCoef10, Me.lblRodStress10, Me.lblRodTopMaxStress10, Me.lblRodTopMinStress10, Me.lblRodBotMinStress10, Me.lblRodStressMethod10, Me.linRSInputSep2, Me.rtbSecondCompanyComments2, Me.lblRodTensileStrength11, Me.lblRodLength11, Me.lblRodGrade11, Me.lblRodDiam11, Me.lblRodDiam12, Me.lblRodDiam13, Me.lblRodDiam14, Me.lblRodDiam15, Me.lblRodDiam16, Me.lblRodDiam17, Me.lblRodDiam18, Me.lblRodGrade12, Me.lblRodGrade13, Me.lblRodGrade14, Me.lblRodGrade15, Me.lblRodGrade16, Me.lblRodGrade17, Me.lblRodGrade18, Me.lblRodLength12, Me.lblRodLength13, Me.lblRodLength14, Me.lblRodLength15, Me.lblRodLength16, Me.lblRodLength17, Me.lblRodLength18, Me.lblRodTensileStrength12, Me.lblRodTensileStrength13, Me.lblRodTensileStrength14, Me.lblRodTensileStrength15, Me.lblRodTensileStrength16, Me.lblRodTensileStrength17, Me.lblRodTensileStrength18, Me.lblRodStress11, Me.lblRodStress12, Me.lblRodStress13, Me.lblRodStress14, Me.lblRodStress15, Me.lblRodStress16, Me.lblRodStress17, Me.lblRodStress18, Me.lblRodTopMaxStress11, Me.lblRodTopMaxStress12, Me.lblRodTopMaxStress13, Me.lblRodTopMaxStress14, Me.lblRodTopMaxStress15, Me.lblRodTopMaxStress16, Me.lblRodTopMaxStress17, Me.lblRodTopMaxStress18, Me.lblRodTopMinStress11, Me.lblRodTopMinStress12, Me.lblRodTopMinStress13, Me.lblRodTopMinStress14, Me.lblRodTopMinStress15, Me.lblRodTopMinStress16, Me.lblRodTopMinStress17, Me.lblRodTopMinStress18, Me.lblRodBotMinStress11, Me.lblRodBotMinStress12, Me.lblRodBotMinStress13, Me.lblRodBotMinStress14, Me.lblRodBotMinStress15, Me.lblRodBotMinStress16, Me.lblRodBotMinStress17, Me.lblRodBotMinStress18, Me.lblRodStressMethod11, Me.lblRodStressMethod12, Me.lblRodStressMethod13, Me.lblRodStressMethod14, Me.lblRodStressMethod15, Me.lblRodStressMethod16, Me.lblRodStressMethod17, Me.lblRodStressMethod18, Me.lblFricCoef11, Me.lblFricCoef12, Me.lblFricCoef13, Me.lblFricCoef14, Me.lblFricCoef15, Me.lblFricCoef16, Me.lblFricCoef17, Me.lblFricCoef18, Me.lblRodDiam19, Me.lblRodGrade19, Me.lblRodLength19, Me.lblRodTensileStrength19, Me.lblFricCoef19, Me.lblRodStress19, Me.lblRodTopMaxStress19, Me.lblRodTopMinStress19, Me.lblRodBotMinStress19, Me.lblRodStressMethod19, Me.lblRodDiam20, Me.lblRodGrade20, Me.lblRodLength20, Me.lblRodTensileStrength20, Me.lblFricCoef20, Me.lblRodStress20, Me.lblRodTopMaxStress20, Me.lblRodTopMinStress20, Me.lblRodBotMinStress20, Me.lblRodStressMethod20 })
			Me.Detail.Height = 8.229167F
			Me.Detail.Name = "Detail"
			Me.rtbSecondCompanyComments.AutoReplaceFields = True
			Me.rtbSecondCompanyComments.CanShrink = True
			Me.rtbSecondCompanyComments.Font = New Font("Arial", 10F)
			Me.rtbSecondCompanyComments.Height = 2.1145F
			Me.rtbSecondCompanyComments.Left = 0.0625F
			Me.rtbSecondCompanyComments.Name = "rtbSecondCompanyComments"
			Me.rtbSecondCompanyComments.RTF = componentResourceManager.GetString("rtbSecondCompanyComments.RTF")
			Me.rtbSecondCompanyComments.Top = 0.5625F
			Me.rtbSecondCompanyComments.Width = 7.8125F
			Me.txtCustomerCompany.CanGrow = False
			Me.txtCustomerCompany.DataField = "Customers.CompanyName"
			Me.txtCustomerCompany.Height = 0.1875F
			Me.txtCustomerCompany.Left = 0.0625F
			Me.txtCustomerCompany.Name = "txtCustomerCompany"
			Me.txtCustomerCompany.Style = "background-color: Transparent; font-size: 9pt"
			Me.txtCustomerCompany.Text = """Second Company Customer Company"" goes here"
			Me.txtCustomerCompany.Top = 0.0625F
			Me.txtCustomerCompany.Width = 3.1875F
			Me.txtCustomerName.CanGrow = False
			Me.txtCustomerName.DataField = "ShipName"
			Me.txtCustomerName.Height = 0.1875F
			Me.txtCustomerName.Left = 3.34375F
			Me.txtCustomerName.Name = "txtCustomerName"
			Me.txtCustomerName.Style = "background-color: Transparent; font-size: 9pt"
			Me.txtCustomerName.Text = """Second Company Customer Name"" goes here"
			Me.txtCustomerName.Top = 0.0625F
			Me.txtCustomerName.Width = 3.09375F
			Me.lblComments.CanGrow = False
			Me.lblComments.DataField = "Customers.CompanyName"
			Me.lblComments.Height = 0.1875F
			Me.lblComments.Left = 0.0625F
			Me.lblComments.Name = "lblComments"
			Me.lblComments.Style = "background-color: Transparent; font-size: 9pt"
			Me.lblComments.Text = "Comments:"
			Me.lblComments.Top = 0.3125F
			Me.lblComments.Width = 3F
			Me.lblRSFootnote5.Height = 0.115F
			Me.lblRSFootnote5.HyperLink = Nothing
			Me.lblRSFootnote5.Left = 0.062F
			Me.lblRSFootnote5.Name = "lblRSFootnote5"
			Me.lblRSFootnote5.Style = "font-size: 7pt"
			Me.lblRSFootnote5.Text = ""
			Me.lblRSFootnote5.Top = 6.441F
			Me.lblRSFootnote5.Width = 7.75F
			Me.lblRSFootnote4.Height = 0.115F
			Me.lblRSFootnote4.HyperLink = Nothing
			Me.lblRSFootnote4.Left = 0.062F
			Me.lblRSFootnote4.Name = "lblRSFootnote4"
			Me.lblRSFootnote4.Style = "font-size: 7pt"
			Me.lblRSFootnote4.Text = ""
			Me.lblRSFootnote4.Top = 6.336F
			Me.lblRSFootnote4.Width = 7.75F
			Me.lblRSFootnote3.Height = 0.115F
			Me.lblRSFootnote3.HyperLink = Nothing
			Me.lblRSFootnote3.Left = 0.062F
			Me.lblRSFootnote3.Name = "lblRSFootnote3"
			Me.lblRSFootnote3.Style = "font-size: 7pt"
			Me.lblRSFootnote3.Text = ""
			Me.lblRSFootnote3.Top = 6.221001F
			Me.lblRSFootnote3.Width = 7.75F
			Me.lblRSFootnote2.Height = 0.115F
			Me.lblRSFootnote2.HyperLink = Nothing
			Me.lblRSFootnote2.Left = 0.062F
			Me.lblRSFootnote2.Name = "lblRSFootnote2"
			Me.lblRSFootnote2.Style = "font-size: 7pt"
			Me.lblRSFootnote2.Text = ""
			Me.lblRSFootnote2.Top = 6.104001F
			Me.lblRSFootnote2.Width = 7.75F
			Me.lblRSFootnote1.Height = 0.115F
			Me.lblRSFootnote1.HyperLink = Nothing
			Me.lblRSFootnote1.Left = 0.062F
			Me.lblRSFootnote1.Name = "lblRSFootnote1"
			Me.lblRSFootnote1.Style = "font-size: 7pt"
			Me.lblRSFootnote1.Text = ""
			Me.lblRSFootnote1.Top = 5.985001F
			Me.lblRSFootnote1.Width = 7.75F
			Me.linRSInputSep4.Height = 1.6F
			Me.linRSInputSep4.Left = 3.25F
			Me.linRSInputSep4.LineWeight = 1F
			Me.linRSInputSep4.Name = "linRSInputSep4"
			Me.linRSInputSep4.Top = 3F
			Me.linRSInputSep4.Width = 0F
			Me.linRSInputSep4.X1 = 3.25F
			Me.linRSInputSep4.X2 = 3.25F
			Me.linRSInputSep4.Y1 = 3F
			Me.linRSInputSep4.Y2 = 4.6F
			Me.linRSInputSep1.Height = 1.6F
			Me.linRSInputSep1.Left = 0.75F
			Me.linRSInputSep1.LineWeight = 1F
			Me.linRSInputSep1.Name = "linRSInputSep1"
			Me.linRSInputSep1.Top = 3F
			Me.linRSInputSep1.Width = 0F
			Me.linRSInputSep1.X1 = 0.75F
			Me.linRSInputSep1.X2 = 0.75F
			Me.linRSInputSep1.Y1 = 3F
			Me.linRSInputSep1.Y2 = 4.6F
			Me.linDivider.Height = 1.85F
			Me.linDivider.Left = 3.6875F
			Me.linDivider.LineWeight = 1F
			Me.linDivider.Name = "linDivider"
			Me.linDivider.Top = 2.75F
			Me.linDivider.Width = 0F
			Me.linDivider.X1 = 3.6875F
			Me.linDivider.X2 = 3.6875F
			Me.linDivider.Y1 = 2.75F
			Me.linDivider.Y2 = 4.6F
			Me.linRSInputSep3.Height = 1.6F
			Me.linRSInputSep3.Left = 2.375F
			Me.linRSInputSep3.LineWeight = 1F
			Me.linRSInputSep3.Name = "linRSInputSep3"
			Me.linRSInputSep3.Top = 3F
			Me.linRSInputSep3.Width = 0F
			Me.linRSInputSep3.X1 = 2.375F
			Me.linRSInputSep3.X2 = 2.375F
			Me.linRSInputSep3.Y1 = 3F
			Me.linRSInputSep3.Y2 = 4.6F
			Me.lblRodStringDesign.Height = 0.15F
			Me.lblRodStringDesign.HyperLink = Nothing
			Me.lblRodStringDesign.Left = 0.0625F
			Me.lblRodStringDesign.Name = "lblRodStringDesign"
			Me.lblRodStringDesign.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodStringDesign.Text = "Rod string design"
			Me.lblRodStringDesign.Top = 2.75F
			Me.lblRodStringDesign.Width = 3.5625F
			Me.Line11.Height = 0F
			Me.Line11.Left = 0.0625F
			Me.Line11.LineWeight = 1F
			Me.Line11.Name = "Line11"
			Me.Line11.Top = 2.9375F
			Me.Line11.Width = 3.5625F
			Me.Line11.X1 = 0.0625F
			Me.Line11.X2 = 3.625F
			Me.Line11.Y1 = 2.9375F
			Me.Line11.Y2 = 2.9375F
			Me.lblRodDiamHdrTop.Height = 0.145F
			Me.lblRodDiamHdrTop.HyperLink = Nothing
			Me.lblRodDiamHdrTop.Left = 0.0625F
			Me.lblRodDiamHdrTop.Name = "lblRodDiamHdrTop"
			Me.lblRodDiamHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodDiamHdrTop.Text = "Diameter"
			Me.lblRodDiamHdrTop.Top = 3F
			Me.lblRodDiamHdrTop.Width = 0.625F
			Me.lblRodDiamHdrBot.Height = 0.145F
			Me.lblRodDiamHdrBot.HyperLink = Nothing
			Me.lblRodDiamHdrBot.Left = 0.0625F
			Me.lblRodDiamHdrBot.Name = "lblRodDiamHdrBot"
			Me.lblRodDiamHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodDiamHdrBot.Text = "(inches)"
			Me.lblRodDiamHdrBot.Top = 3.125F
			Me.lblRodDiamHdrBot.Width = 0.625F
			Me.lblRodDiam1.Height = 0.125F
			Me.lblRodDiam1.HyperLink = Nothing
			Me.lblRodDiam1.Left = 0.0625F
			Me.lblRodDiam1.Name = "lblRodDiam1"
			Me.lblRodDiam1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam1.Text = "Diam"
			Me.lblRodDiam1.Top = 3.375F
			Me.lblRodDiam1.Width = 0.625F
			Me.lblRodGradeHdrBot.Height = 0.145F
			Me.lblRodGradeHdrBot.HyperLink = Nothing
			Me.lblRodGradeHdrBot.Left = 0.8125F
			Me.lblRodGradeHdrBot.Name = "lblRodGradeHdrBot"
			Me.lblRodGradeHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGradeHdrBot.Text = "Grade"
			Me.lblRodGradeHdrBot.Top = 3.125F
			Me.lblRodGradeHdrBot.Width = 0.9375F
			Me.lblRodLengthHdrBot.Height = 0.145F
			Me.lblRodLengthHdrBot.HyperLink = Nothing
			Me.lblRodLengthHdrBot.Left = 1.875F
			Me.lblRodLengthHdrBot.Name = "lblRodLengthHdrBot"
			Me.lblRodLengthHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodLengthHdrBot.Text = "(ft)"
			Me.lblRodLengthHdrBot.Top = 3.125F
			Me.lblRodLengthHdrBot.Width = 0.4375F
			Me.lblRodTensileStrengthHdrBot.Height = 0.145F
			Me.lblRodTensileStrengthHdrBot.HyperLink = Nothing
			Me.lblRodTensileStrengthHdrBot.Left = 2.4375F
			Me.lblRodTensileStrengthHdrBot.Name = "lblRodTensileStrengthHdrBot"
			Me.lblRodTensileStrengthHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrengthHdrBot.Text = "Strength (psi)"
			Me.lblRodTensileStrengthHdrBot.Top = 3.125F
			Me.lblRodTensileStrengthHdrBot.Width = 0.75F
			Me.Line12.Height = 0F
			Me.Line12.Left = 0.0625F
			Me.Line12.LineWeight = 1F
			Me.Line12.Name = "Line12"
			Me.Line12.Top = 3.3125F
			Me.Line12.Width = 3.5625F
			Me.Line12.X1 = 0.0625F
			Me.Line12.X2 = 3.625F
			Me.Line12.Y1 = 3.3125F
			Me.Line12.Y2 = 3.3125F
			Me.lblRodDiam2.Height = 0.125F
			Me.lblRodDiam2.HyperLink = Nothing
			Me.lblRodDiam2.Left = 0.0625F
			Me.lblRodDiam2.Name = "lblRodDiam2"
			Me.lblRodDiam2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam2.Text = "Diam"
			Me.lblRodDiam2.Top = 3.5F
			Me.lblRodDiam2.Width = 0.625F
			Me.lblRodDiam3.Height = 0.125F
			Me.lblRodDiam3.HyperLink = Nothing
			Me.lblRodDiam3.Left = 0.0625F
			Me.lblRodDiam3.Name = "lblRodDiam3"
			Me.lblRodDiam3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam3.Text = "Diam"
			Me.lblRodDiam3.Top = 3.625F
			Me.lblRodDiam3.Width = 0.625F
			Me.lblRodDiam4.Height = 0.125F
			Me.lblRodDiam4.HyperLink = Nothing
			Me.lblRodDiam4.Left = 0.0625F
			Me.lblRodDiam4.Name = "lblRodDiam4"
			Me.lblRodDiam4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam4.Text = "Diam"
			Me.lblRodDiam4.Top = 3.75F
			Me.lblRodDiam4.Width = 0.625F
			Me.lblRodDiam5.Height = 0.125F
			Me.lblRodDiam5.HyperLink = Nothing
			Me.lblRodDiam5.Left = 0.0625F
			Me.lblRodDiam5.Name = "lblRodDiam5"
			Me.lblRodDiam5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam5.Text = "Diam"
			Me.lblRodDiam5.Top = 3.875F
			Me.lblRodDiam5.Width = 0.625F
			Me.lblRodDiam6.Height = 0.125F
			Me.lblRodDiam6.HyperLink = Nothing
			Me.lblRodDiam6.Left = 0.0625F
			Me.lblRodDiam6.Name = "lblRodDiam6"
			Me.lblRodDiam6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam6.Text = "Diam"
			Me.lblRodDiam6.Top = 4F
			Me.lblRodDiam6.Width = 0.625F
			Me.lblRodDiam7.Height = 0.125F
			Me.lblRodDiam7.HyperLink = Nothing
			Me.lblRodDiam7.Left = 0.0625F
			Me.lblRodDiam7.Name = "lblRodDiam7"
			Me.lblRodDiam7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam7.Text = "Diam"
			Me.lblRodDiam7.Top = 4.125F
			Me.lblRodDiam7.Width = 0.625F
			Me.lblRodDiam8.Height = 0.125F
			Me.lblRodDiam8.HyperLink = Nothing
			Me.lblRodDiam8.Left = 0.0625F
			Me.lblRodDiam8.Name = "lblRodDiam8"
			Me.lblRodDiam8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam8.Text = "Diam"
			Me.lblRodDiam8.Top = 4.25F
			Me.lblRodDiam8.Width = 0.625F
			Me.lblRodGrade1.Height = 0.125F
			Me.lblRodGrade1.HyperLink = Nothing
			Me.lblRodGrade1.Left = 0.8125F
			Me.lblRodGrade1.Name = "lblRodGrade1"
			Me.lblRodGrade1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade1.Text = "Grade"
			Me.lblRodGrade1.Top = 3.375F
			Me.lblRodGrade1.Width = 0.98F
			Me.lblRodGrade2.Height = 0.125F
			Me.lblRodGrade2.HyperLink = Nothing
			Me.lblRodGrade2.Left = 0.8125F
			Me.lblRodGrade2.Name = "lblRodGrade2"
			Me.lblRodGrade2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade2.Text = "Grade"
			Me.lblRodGrade2.Top = 3.5F
			Me.lblRodGrade2.Width = 0.98F
			Me.lblRodGrade3.Height = 0.125F
			Me.lblRodGrade3.HyperLink = Nothing
			Me.lblRodGrade3.Left = 0.8125F
			Me.lblRodGrade3.Name = "lblRodGrade3"
			Me.lblRodGrade3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade3.Text = "Grade"
			Me.lblRodGrade3.Top = 3.625F
			Me.lblRodGrade3.Width = 0.98F
			Me.lblRodGrade4.Height = 0.125F
			Me.lblRodGrade4.HyperLink = Nothing
			Me.lblRodGrade4.Left = 0.8125F
			Me.lblRodGrade4.Name = "lblRodGrade4"
			Me.lblRodGrade4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade4.Text = "Grade"
			Me.lblRodGrade4.Top = 3.75F
			Me.lblRodGrade4.Width = 0.98F
			Me.lblRodGrade5.Height = 0.125F
			Me.lblRodGrade5.HyperLink = Nothing
			Me.lblRodGrade5.Left = 0.8125F
			Me.lblRodGrade5.Name = "lblRodGrade5"
			Me.lblRodGrade5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade5.Text = "Grade"
			Me.lblRodGrade5.Top = 3.875F
			Me.lblRodGrade5.Width = 0.98F
			Me.lblRodGrade6.Height = 0.125F
			Me.lblRodGrade6.HyperLink = Nothing
			Me.lblRodGrade6.Left = 0.8125F
			Me.lblRodGrade6.Name = "lblRodGrade6"
			Me.lblRodGrade6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade6.Text = "Grade"
			Me.lblRodGrade6.Top = 4F
			Me.lblRodGrade6.Width = 0.98F
			Me.lblRodGrade7.Height = 0.125F
			Me.lblRodGrade7.HyperLink = Nothing
			Me.lblRodGrade7.Left = 0.8125F
			Me.lblRodGrade7.Name = "lblRodGrade7"
			Me.lblRodGrade7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade7.Text = "Grade"
			Me.lblRodGrade7.Top = 4.125F
			Me.lblRodGrade7.Width = 0.98F
			Me.lblRodGrade8.Height = 0.125F
			Me.lblRodGrade8.HyperLink = Nothing
			Me.lblRodGrade8.Left = 0.8125F
			Me.lblRodGrade8.Name = "lblRodGrade8"
			Me.lblRodGrade8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade8.Text = "Grade"
			Me.lblRodGrade8.Top = 4.25F
			Me.lblRodGrade8.Width = 0.98F
			Me.lblRodLength1.Height = 0.125F
			Me.lblRodLength1.HyperLink = Nothing
			Me.lblRodLength1.Left = 1.875F
			Me.lblRodLength1.Name = "lblRodLength1"
			Me.lblRodLength1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength1.Text = "Len"
			Me.lblRodLength1.Top = 3.375F
			Me.lblRodLength1.Width = 0.4375F
			Me.lblRodLength2.Height = 0.125F
			Me.lblRodLength2.HyperLink = Nothing
			Me.lblRodLength2.Left = 1.875F
			Me.lblRodLength2.Name = "lblRodLength2"
			Me.lblRodLength2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength2.Text = "Len"
			Me.lblRodLength2.Top = 3.5F
			Me.lblRodLength2.Width = 0.4375F
			Me.lblRodLength3.Height = 0.125F
			Me.lblRodLength3.HyperLink = Nothing
			Me.lblRodLength3.Left = 1.875F
			Me.lblRodLength3.Name = "lblRodLength3"
			Me.lblRodLength3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength3.Text = "Len"
			Me.lblRodLength3.Top = 3.625F
			Me.lblRodLength3.Width = 0.4375F
			Me.lblRodLength4.Height = 0.125F
			Me.lblRodLength4.HyperLink = Nothing
			Me.lblRodLength4.Left = 1.875F
			Me.lblRodLength4.Name = "lblRodLength4"
			Me.lblRodLength4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength4.Text = "Len"
			Me.lblRodLength4.Top = 3.75F
			Me.lblRodLength4.Width = 0.4375F
			Me.lblRodLength5.Height = 0.125F
			Me.lblRodLength5.HyperLink = Nothing
			Me.lblRodLength5.Left = 1.875F
			Me.lblRodLength5.Name = "lblRodLength5"
			Me.lblRodLength5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength5.Text = "Len"
			Me.lblRodLength5.Top = 3.875F
			Me.lblRodLength5.Width = 0.4375F
			Me.lblRodLength6.Height = 0.125F
			Me.lblRodLength6.HyperLink = Nothing
			Me.lblRodLength6.Left = 1.875F
			Me.lblRodLength6.Name = "lblRodLength6"
			Me.lblRodLength6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength6.Text = "Len"
			Me.lblRodLength6.Top = 4F
			Me.lblRodLength6.Width = 0.4375F
			Me.lblRodLength7.Height = 0.125F
			Me.lblRodLength7.HyperLink = Nothing
			Me.lblRodLength7.Left = 1.875F
			Me.lblRodLength7.Name = "lblRodLength7"
			Me.lblRodLength7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength7.Text = "Len"
			Me.lblRodLength7.Top = 4.125F
			Me.lblRodLength7.Width = 0.4375F
			Me.lblRodLength8.Height = 0.125F
			Me.lblRodLength8.HyperLink = Nothing
			Me.lblRodLength8.Left = 1.875F
			Me.lblRodLength8.Name = "lblRodLength8"
			Me.lblRodLength8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength8.Text = "Len"
			Me.lblRodLength8.Top = 4.25F
			Me.lblRodLength8.Width = 0.4375F
			Me.lblRodTensileStrength1.Height = 0.125F
			Me.lblRodTensileStrength1.HyperLink = Nothing
			Me.lblRodTensileStrength1.Left = 2.4375F
			Me.lblRodTensileStrength1.Name = "lblRodTensileStrength1"
			Me.lblRodTensileStrength1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength1.Text = "TS"
			Me.lblRodTensileStrength1.Top = 3.375F
			Me.lblRodTensileStrength1.Width = 0.75F
			Me.lblRodTensileStrength2.Height = 0.125F
			Me.lblRodTensileStrength2.HyperLink = Nothing
			Me.lblRodTensileStrength2.Left = 2.4375F
			Me.lblRodTensileStrength2.Name = "lblRodTensileStrength2"
			Me.lblRodTensileStrength2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength2.Text = "TS"
			Me.lblRodTensileStrength2.Top = 3.5F
			Me.lblRodTensileStrength2.Width = 0.75F
			Me.lblRodTensileStrength3.Height = 0.125F
			Me.lblRodTensileStrength3.HyperLink = Nothing
			Me.lblRodTensileStrength3.Left = 2.4375F
			Me.lblRodTensileStrength3.Name = "lblRodTensileStrength3"
			Me.lblRodTensileStrength3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength3.Text = "TS"
			Me.lblRodTensileStrength3.Top = 3.625F
			Me.lblRodTensileStrength3.Width = 0.75F
			Me.lblRodTensileStrength4.Height = 0.125F
			Me.lblRodTensileStrength4.HyperLink = Nothing
			Me.lblRodTensileStrength4.Left = 2.4375F
			Me.lblRodTensileStrength4.Name = "lblRodTensileStrength4"
			Me.lblRodTensileStrength4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength4.Text = "TS"
			Me.lblRodTensileStrength4.Top = 3.75F
			Me.lblRodTensileStrength4.Width = 0.75F
			Me.lblRodTensileStrength5.Height = 0.125F
			Me.lblRodTensileStrength5.HyperLink = Nothing
			Me.lblRodTensileStrength5.Left = 2.4375F
			Me.lblRodTensileStrength5.Name = "lblRodTensileStrength5"
			Me.lblRodTensileStrength5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength5.Text = "TS"
			Me.lblRodTensileStrength5.Top = 3.875F
			Me.lblRodTensileStrength5.Width = 0.75F
			Me.lblRodTensileStrength6.Height = 0.125F
			Me.lblRodTensileStrength6.HyperLink = Nothing
			Me.lblRodTensileStrength6.Left = 2.4375F
			Me.lblRodTensileStrength6.Name = "lblRodTensileStrength6"
			Me.lblRodTensileStrength6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength6.Text = "TS"
			Me.lblRodTensileStrength6.Top = 4F
			Me.lblRodTensileStrength6.Width = 0.75F
			Me.lblRodTensileStrength7.Height = 0.125F
			Me.lblRodTensileStrength7.HyperLink = Nothing
			Me.lblRodTensileStrength7.Left = 2.4375F
			Me.lblRodTensileStrength7.Name = "lblRodTensileStrength7"
			Me.lblRodTensileStrength7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength7.Text = "TS"
			Me.lblRodTensileStrength7.Top = 4.125F
			Me.lblRodTensileStrength7.Width = 0.75F
			Me.lblRodTensileStrength8.Height = 0.125F
			Me.lblRodTensileStrength8.HyperLink = Nothing
			Me.lblRodTensileStrength8.Left = 2.4375F
			Me.lblRodTensileStrength8.Name = "lblRodTensileStrength8"
			Me.lblRodTensileStrength8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength8.Text = "TS"
			Me.lblRodTensileStrength8.Top = 4.25F
			Me.lblRodTensileStrength8.Width = 0.75F
			Me.lblRodStringResults.Height = 0.15F
			Me.lblRodStringResults.HyperLink = Nothing
			Me.lblRodStringResults.Left = 3.75F
			Me.lblRodStringResults.Name = "lblRodStringResults"
			Me.lblRodStringResults.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodStringResults.Text = "Rod string design"
			Me.lblRodStringResults.Top = 2.75F
			Me.lblRodStringResults.Width = 4.125F
			Me.Line13.Height = 0F
			Me.Line13.Left = 3.75F
			Me.Line13.LineWeight = 1F
			Me.Line13.Name = "Line13"
			Me.Line13.Top = 2.9375F
			Me.Line13.Width = 4.125F
			Me.Line13.X1 = 3.75F
			Me.Line13.X2 = 7.875F
			Me.Line13.Y1 = 2.9375F
			Me.Line13.Y2 = 2.9375F
			Me.lblRodStressHdrBot.Height = 0.145F
			Me.lblRodStressHdrBot.HyperLink = Nothing
			Me.lblRodStressHdrBot.Left = 3.75F
			Me.lblRodStressHdrBot.Name = "lblRodStressHdrBot"
			Me.lblRodStressHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressHdrBot.Text = " Load %"
			Me.lblRodStressHdrBot.Top = 3.125F
			Me.lblRodStressHdrBot.Width = 0.5F
			Me.lblRodStress1.Height = 0.125F
			Me.lblRodStress1.HyperLink = Nothing
			Me.lblRodStress1.Left = 3.75F
			Me.lblRodStress1.Name = "lblRodStress1"
			Me.lblRodStress1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress1.Text = "Stress"
			Me.lblRodStress1.Top = 3.375F
			Me.lblRodStress1.Width = 0.5F
			Me.lblRodTopMaxStressHdrBot.Height = 0.145F
			Me.lblRodTopMaxStressHdrBot.HyperLink = Nothing
			Me.lblRodTopMaxStressHdrBot.Left = 4.375F
			Me.lblRodTopMaxStressHdrBot.Name = "lblRodTopMaxStressHdrBot"
			Me.lblRodTopMaxStressHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodTopMaxStressHdrBot.Text = "   Stress (psi)"
			Me.lblRodTopMaxStressHdrBot.Top = 3.125F
			Me.lblRodTopMaxStressHdrBot.Width = 0.75F
			Me.lblRodTopMinStressHdrBot.Height = 0.145F
			Me.lblRodTopMinStressHdrBot.HyperLink = Nothing
			Me.lblRodTopMinStressHdrBot.Left = 5.25F
			Me.lblRodTopMinStressHdrBot.Name = "lblRodTopMinStressHdrBot"
			Me.lblRodTopMinStressHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodTopMinStressHdrBot.Text = "  Stress (psi)"
			Me.lblRodTopMinStressHdrBot.Top = 3.125F
			Me.lblRodTopMinStressHdrBot.Width = 0.75F
			Me.lblRodBotMinStressHdrBot.Height = 0.145F
			Me.lblRodBotMinStressHdrBot.HyperLink = Nothing
			Me.lblRodBotMinStressHdrBot.Left = 6.125F
			Me.lblRodBotMinStressHdrBot.Name = "lblRodBotMinStressHdrBot"
			Me.lblRodBotMinStressHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStressHdrBot.Text = " Stress (psi)"
			Me.lblRodBotMinStressHdrBot.Top = 3.125F
			Me.lblRodBotMinStressHdrBot.Width = 0.8125F
			Me.Line14.Height = 0F
			Me.Line14.Left = 3.75F
			Me.Line14.LineWeight = 1F
			Me.Line14.Name = "Line14"
			Me.Line14.Top = 3.3125F
			Me.Line14.Width = 4.125F
			Me.Line14.X1 = 3.75F
			Me.Line14.X2 = 7.875F
			Me.Line14.Y1 = 3.3125F
			Me.Line14.Y2 = 3.3125F
			Me.lblRodStress2.Height = 0.125F
			Me.lblRodStress2.HyperLink = Nothing
			Me.lblRodStress2.Left = 3.75F
			Me.lblRodStress2.Name = "lblRodStress2"
			Me.lblRodStress2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress2.Text = "Stress"
			Me.lblRodStress2.Top = 3.5F
			Me.lblRodStress2.Width = 0.5F
			Me.lblRodStress3.Height = 0.125F
			Me.lblRodStress3.HyperLink = Nothing
			Me.lblRodStress3.Left = 3.75F
			Me.lblRodStress3.Name = "lblRodStress3"
			Me.lblRodStress3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress3.Text = "Stress"
			Me.lblRodStress3.Top = 3.625F
			Me.lblRodStress3.Width = 0.5F
			Me.lblRodStress4.Height = 0.125F
			Me.lblRodStress4.HyperLink = Nothing
			Me.lblRodStress4.Left = 3.75F
			Me.lblRodStress4.Name = "lblRodStress4"
			Me.lblRodStress4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress4.Text = "Stress"
			Me.lblRodStress4.Top = 3.75F
			Me.lblRodStress4.Width = 0.5F
			Me.lblRodStress5.Height = 0.125F
			Me.lblRodStress5.HyperLink = Nothing
			Me.lblRodStress5.Left = 3.75F
			Me.lblRodStress5.Name = "lblRodStress5"
			Me.lblRodStress5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress5.Text = "Stress"
			Me.lblRodStress5.Top = 3.875F
			Me.lblRodStress5.Width = 0.5F
			Me.lblRodStress6.Height = 0.125F
			Me.lblRodStress6.HyperLink = Nothing
			Me.lblRodStress6.Left = 3.75F
			Me.lblRodStress6.Name = "lblRodStress6"
			Me.lblRodStress6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress6.Text = "Stress"
			Me.lblRodStress6.Top = 4F
			Me.lblRodStress6.Width = 0.5F
			Me.lblRodStress7.Height = 0.125F
			Me.lblRodStress7.HyperLink = Nothing
			Me.lblRodStress7.Left = 3.75F
			Me.lblRodStress7.Name = "lblRodStress7"
			Me.lblRodStress7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress7.Text = "Stress"
			Me.lblRodStress7.Top = 4.125F
			Me.lblRodStress7.Width = 0.5F
			Me.lblRodStress8.Height = 0.125F
			Me.lblRodStress8.HyperLink = Nothing
			Me.lblRodStress8.Left = 3.75F
			Me.lblRodStress8.Name = "lblRodStress8"
			Me.lblRodStress8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress8.Text = "Stress"
			Me.lblRodStress8.Top = 4.25F
			Me.lblRodStress8.Width = 0.5F
			Me.lblRodTopMaxStress1.Height = 0.125F
			Me.lblRodTopMaxStress1.HyperLink = Nothing
			Me.lblRodTopMaxStress1.Left = 4.375F
			Me.lblRodTopMaxStress1.Name = "lblRodTopMaxStress1"
			Me.lblRodTopMaxStress1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress1.Text = "Top Max"
			Me.lblRodTopMaxStress1.Top = 3.375F
			Me.lblRodTopMaxStress1.Width = 0.75F
			Me.lblRodTopMaxStress2.Height = 0.125F
			Me.lblRodTopMaxStress2.HyperLink = Nothing
			Me.lblRodTopMaxStress2.Left = 4.375F
			Me.lblRodTopMaxStress2.Name = "lblRodTopMaxStress2"
			Me.lblRodTopMaxStress2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress2.Text = "Top Max"
			Me.lblRodTopMaxStress2.Top = 3.5F
			Me.lblRodTopMaxStress2.Width = 0.75F
			Me.lblRodTopMaxStress3.Height = 0.125F
			Me.lblRodTopMaxStress3.HyperLink = Nothing
			Me.lblRodTopMaxStress3.Left = 4.375F
			Me.lblRodTopMaxStress3.Name = "lblRodTopMaxStress3"
			Me.lblRodTopMaxStress3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress3.Text = "Top Max"
			Me.lblRodTopMaxStress3.Top = 3.625F
			Me.lblRodTopMaxStress3.Width = 0.75F
			Me.lblRodTopMaxStress4.Height = 0.125F
			Me.lblRodTopMaxStress4.HyperLink = Nothing
			Me.lblRodTopMaxStress4.Left = 4.375F
			Me.lblRodTopMaxStress4.Name = "lblRodTopMaxStress4"
			Me.lblRodTopMaxStress4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress4.Text = "Top Max"
			Me.lblRodTopMaxStress4.Top = 3.75F
			Me.lblRodTopMaxStress4.Width = 0.75F
			Me.lblRodTopMaxStress5.Height = 0.125F
			Me.lblRodTopMaxStress5.HyperLink = Nothing
			Me.lblRodTopMaxStress5.Left = 4.375F
			Me.lblRodTopMaxStress5.Name = "lblRodTopMaxStress5"
			Me.lblRodTopMaxStress5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress5.Text = "Top Max"
			Me.lblRodTopMaxStress5.Top = 3.875F
			Me.lblRodTopMaxStress5.Width = 0.75F
			Me.lblRodTopMaxStress6.Height = 0.125F
			Me.lblRodTopMaxStress6.HyperLink = Nothing
			Me.lblRodTopMaxStress6.Left = 4.375F
			Me.lblRodTopMaxStress6.Name = "lblRodTopMaxStress6"
			Me.lblRodTopMaxStress6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress6.Text = "Top Max"
			Me.lblRodTopMaxStress6.Top = 4F
			Me.lblRodTopMaxStress6.Width = 0.75F
			Me.lblRodTopMaxStress7.Height = 0.125F
			Me.lblRodTopMaxStress7.HyperLink = Nothing
			Me.lblRodTopMaxStress7.Left = 4.375F
			Me.lblRodTopMaxStress7.Name = "lblRodTopMaxStress7"
			Me.lblRodTopMaxStress7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress7.Text = "Top Max"
			Me.lblRodTopMaxStress7.Top = 4.125F
			Me.lblRodTopMaxStress7.Width = 0.75F
			Me.lblRodTopMaxStress8.Height = 0.125F
			Me.lblRodTopMaxStress8.HyperLink = Nothing
			Me.lblRodTopMaxStress8.Left = 4.375F
			Me.lblRodTopMaxStress8.Name = "lblRodTopMaxStress8"
			Me.lblRodTopMaxStress8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress8.Text = "Top Max"
			Me.lblRodTopMaxStress8.Top = 4.25F
			Me.lblRodTopMaxStress8.Width = 0.75F
			Me.lblRodTopMinStress1.Height = 0.125F
			Me.lblRodTopMinStress1.HyperLink = Nothing
			Me.lblRodTopMinStress1.Left = 5.25F
			Me.lblRodTopMinStress1.Name = "lblRodTopMinStress1"
			Me.lblRodTopMinStress1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress1.Text = "Top Min"
			Me.lblRodTopMinStress1.Top = 3.375F
			Me.lblRodTopMinStress1.Width = 0.75F
			Me.lblRodTopMinStress2.Height = 0.125F
			Me.lblRodTopMinStress2.HyperLink = Nothing
			Me.lblRodTopMinStress2.Left = 5.25F
			Me.lblRodTopMinStress2.Name = "lblRodTopMinStress2"
			Me.lblRodTopMinStress2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress2.Text = "Top Min"
			Me.lblRodTopMinStress2.Top = 3.5F
			Me.lblRodTopMinStress2.Width = 0.75F
			Me.lblRodTopMinStress3.Height = 0.125F
			Me.lblRodTopMinStress3.HyperLink = Nothing
			Me.lblRodTopMinStress3.Left = 5.25F
			Me.lblRodTopMinStress3.Name = "lblRodTopMinStress3"
			Me.lblRodTopMinStress3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress3.Text = "Top Min"
			Me.lblRodTopMinStress3.Top = 3.625F
			Me.lblRodTopMinStress3.Width = 0.75F
			Me.lblRodTopMinStress4.Height = 0.125F
			Me.lblRodTopMinStress4.HyperLink = Nothing
			Me.lblRodTopMinStress4.Left = 5.25F
			Me.lblRodTopMinStress4.Name = "lblRodTopMinStress4"
			Me.lblRodTopMinStress4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress4.Text = "Top Min"
			Me.lblRodTopMinStress4.Top = 3.75F
			Me.lblRodTopMinStress4.Width = 0.75F
			Me.lblRodTopMinStress5.Height = 0.125F
			Me.lblRodTopMinStress5.HyperLink = Nothing
			Me.lblRodTopMinStress5.Left = 5.25F
			Me.lblRodTopMinStress5.Name = "lblRodTopMinStress5"
			Me.lblRodTopMinStress5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress5.Text = "Top Min"
			Me.lblRodTopMinStress5.Top = 3.875F
			Me.lblRodTopMinStress5.Width = 0.75F
			Me.lblRodTopMinStress6.Height = 0.125F
			Me.lblRodTopMinStress6.HyperLink = Nothing
			Me.lblRodTopMinStress6.Left = 5.25F
			Me.lblRodTopMinStress6.Name = "lblRodTopMinStress6"
			Me.lblRodTopMinStress6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress6.Text = "Top Min"
			Me.lblRodTopMinStress6.Top = 4F
			Me.lblRodTopMinStress6.Width = 0.75F
			Me.lblRodTopMinStress7.Height = 0.125F
			Me.lblRodTopMinStress7.HyperLink = Nothing
			Me.lblRodTopMinStress7.Left = 5.25F
			Me.lblRodTopMinStress7.Name = "lblRodTopMinStress7"
			Me.lblRodTopMinStress7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress7.Text = "Top Min"
			Me.lblRodTopMinStress7.Top = 4.125F
			Me.lblRodTopMinStress7.Width = 0.75F
			Me.lblRodTopMinStress8.Height = 0.125F
			Me.lblRodTopMinStress8.HyperLink = Nothing
			Me.lblRodTopMinStress8.Left = 5.25F
			Me.lblRodTopMinStress8.Name = "lblRodTopMinStress8"
			Me.lblRodTopMinStress8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress8.Text = "Top Min"
			Me.lblRodTopMinStress8.Top = 4.25F
			Me.lblRodTopMinStress8.Width = 0.75F
			Me.lblRodBotMinStress1.Height = 0.125F
			Me.lblRodBotMinStress1.HyperLink = Nothing
			Me.lblRodBotMinStress1.Left = 6.125F
			Me.lblRodBotMinStress1.Name = "lblRodBotMinStress1"
			Me.lblRodBotMinStress1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress1.Text = "Bot Min"
			Me.lblRodBotMinStress1.Top = 3.375F
			Me.lblRodBotMinStress1.Width = 0.8125F
			Me.lblRodBotMinStress2.Height = 0.125F
			Me.lblRodBotMinStress2.HyperLink = Nothing
			Me.lblRodBotMinStress2.Left = 6.125F
			Me.lblRodBotMinStress2.Name = "lblRodBotMinStress2"
			Me.lblRodBotMinStress2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress2.Text = "Bot Min"
			Me.lblRodBotMinStress2.Top = 3.5F
			Me.lblRodBotMinStress2.Width = 0.8125F
			Me.lblRodBotMinStress3.Height = 0.125F
			Me.lblRodBotMinStress3.HyperLink = Nothing
			Me.lblRodBotMinStress3.Left = 6.125F
			Me.lblRodBotMinStress3.Name = "lblRodBotMinStress3"
			Me.lblRodBotMinStress3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress3.Text = "Bot Min"
			Me.lblRodBotMinStress3.Top = 3.625F
			Me.lblRodBotMinStress3.Width = 0.8125F
			Me.lblRodBotMinStress4.Height = 0.125F
			Me.lblRodBotMinStress4.HyperLink = Nothing
			Me.lblRodBotMinStress4.Left = 6.125F
			Me.lblRodBotMinStress4.Name = "lblRodBotMinStress4"
			Me.lblRodBotMinStress4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress4.Text = "Bot Min"
			Me.lblRodBotMinStress4.Top = 3.75F
			Me.lblRodBotMinStress4.Width = 0.8125F
			Me.lblRodBotMinStress5.Height = 0.125F
			Me.lblRodBotMinStress5.HyperLink = Nothing
			Me.lblRodBotMinStress5.Left = 6.125F
			Me.lblRodBotMinStress5.Name = "lblRodBotMinStress5"
			Me.lblRodBotMinStress5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress5.Text = "Bot Min"
			Me.lblRodBotMinStress5.Top = 3.875F
			Me.lblRodBotMinStress5.Width = 0.8125F
			Me.lblRodBotMinStress6.Height = 0.125F
			Me.lblRodBotMinStress6.HyperLink = Nothing
			Me.lblRodBotMinStress6.Left = 6.125F
			Me.lblRodBotMinStress6.Name = "lblRodBotMinStress6"
			Me.lblRodBotMinStress6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress6.Text = "Bot Min"
			Me.lblRodBotMinStress6.Top = 4F
			Me.lblRodBotMinStress6.Width = 0.8125F
			Me.lblRodBotMinStress7.Height = 0.125F
			Me.lblRodBotMinStress7.HyperLink = Nothing
			Me.lblRodBotMinStress7.Left = 6.125F
			Me.lblRodBotMinStress7.Name = "lblRodBotMinStress7"
			Me.lblRodBotMinStress7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress7.Text = "Bot Min"
			Me.lblRodBotMinStress7.Top = 4.125F
			Me.lblRodBotMinStress7.Width = 0.8125F
			Me.lblRodBotMinStress8.Height = 0.125F
			Me.lblRodBotMinStress8.HyperLink = Nothing
			Me.lblRodBotMinStress8.Left = 6.125F
			Me.lblRodBotMinStress8.Name = "lblRodBotMinStress8"
			Me.lblRodBotMinStress8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress8.Text = "Bot Min"
			Me.lblRodBotMinStress8.Top = 4.25F
			Me.lblRodBotMinStress8.Width = 0.8125F
			Me.lblRodStressMethodHdrBot.Height = 0.145F
			Me.lblRodStressMethodHdrBot.HyperLink = Nothing
			Me.lblRodStressMethodHdrBot.Left = 7.0625F
			Me.lblRodStressMethodHdrBot.Name = "lblRodStressMethodHdrBot"
			Me.lblRodStressMethodHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethodHdrBot.Text = "Method"
			Me.lblRodStressMethodHdrBot.Top = 3.125F
			Me.lblRodStressMethodHdrBot.Width = 0.8125F
			Me.lblRodStressMethod1.Height = 0.125F
			Me.lblRodStressMethod1.HyperLink = Nothing
			Me.lblRodStressMethod1.Left = 7.0625F
			Me.lblRodStressMethod1.Name = "lblRodStressMethod1"
			Me.lblRodStressMethod1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod1.Text = "Stress Meth"
			Me.lblRodStressMethod1.Top = 3.375F
			Me.lblRodStressMethod1.Width = 0.8125F
			Me.lblRodStressMethod2.Height = 0.125F
			Me.lblRodStressMethod2.HyperLink = Nothing
			Me.lblRodStressMethod2.Left = 7.0625F
			Me.lblRodStressMethod2.Name = "lblRodStressMethod2"
			Me.lblRodStressMethod2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod2.Text = "Stress Meth"
			Me.lblRodStressMethod2.Top = 3.5F
			Me.lblRodStressMethod2.Width = 0.8125F
			Me.lblRodStressMethod3.Height = 0.125F
			Me.lblRodStressMethod3.HyperLink = Nothing
			Me.lblRodStressMethod3.Left = 7.0625F
			Me.lblRodStressMethod3.Name = "lblRodStressMethod3"
			Me.lblRodStressMethod3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod3.Text = "Stress Meth"
			Me.lblRodStressMethod3.Top = 3.625F
			Me.lblRodStressMethod3.Width = 0.8125F
			Me.lblRodStressMethod4.Height = 0.125F
			Me.lblRodStressMethod4.HyperLink = Nothing
			Me.lblRodStressMethod4.Left = 7.0625F
			Me.lblRodStressMethod4.Name = "lblRodStressMethod4"
			Me.lblRodStressMethod4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod4.Text = "Stress Meth"
			Me.lblRodStressMethod4.Top = 3.75F
			Me.lblRodStressMethod4.Width = 0.8125F
			Me.lblRodStressMethod5.Height = 0.125F
			Me.lblRodStressMethod5.HyperLink = Nothing
			Me.lblRodStressMethod5.Left = 7.0625F
			Me.lblRodStressMethod5.Name = "lblRodStressMethod5"
			Me.lblRodStressMethod5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod5.Text = "Stress Meth"
			Me.lblRodStressMethod5.Top = 3.875F
			Me.lblRodStressMethod5.Width = 0.8125F
			Me.lblRodStressMethod6.Height = 0.125F
			Me.lblRodStressMethod6.HyperLink = Nothing
			Me.lblRodStressMethod6.Left = 7.0625F
			Me.lblRodStressMethod6.Name = "lblRodStressMethod6"
			Me.lblRodStressMethod6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod6.Text = "Stress Meth"
			Me.lblRodStressMethod6.Top = 4F
			Me.lblRodStressMethod6.Width = 0.8125F
			Me.lblRodStressMethod7.Height = 0.125F
			Me.lblRodStressMethod7.HyperLink = Nothing
			Me.lblRodStressMethod7.Left = 7.0625F
			Me.lblRodStressMethod7.Name = "lblRodStressMethod7"
			Me.lblRodStressMethod7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod7.Text = "Stress Meth"
			Me.lblRodStressMethod7.Top = 4.125F
			Me.lblRodStressMethod7.Width = 0.8125F
			Me.lblRodStressMethod8.Height = 0.125F
			Me.lblRodStressMethod8.HyperLink = Nothing
			Me.lblRodStressMethod8.Left = 7.0625F
			Me.lblRodStressMethod8.Name = "lblRodStressMethod8"
			Me.lblRodStressMethod8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod8.Text = "Stress Meth"
			Me.lblRodStressMethod8.Top = 4.25F
			Me.lblRodStressMethod8.Width = 0.8125F
			Me.lblRodGradeHdrTop.Height = 0.145F
			Me.lblRodGradeHdrTop.HyperLink = Nothing
			Me.lblRodGradeHdrTop.Left = 0.8125F
			Me.lblRodGradeHdrTop.Name = "lblRodGradeHdrTop"
			Me.lblRodGradeHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGradeHdrTop.Text = "Rod"
			Me.lblRodGradeHdrTop.Top = 3F
			Me.lblRodGradeHdrTop.Width = 0.9375F
			Me.lblRodTopMinStressHdrTop.Height = 0.145F
			Me.lblRodTopMinStressHdrTop.HyperLink = Nothing
			Me.lblRodTopMinStressHdrTop.Left = 5.25F
			Me.lblRodTopMinStressHdrTop.Name = "lblRodTopMinStressHdrTop"
			Me.lblRodTopMinStressHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodTopMinStressHdrTop.Text = "Top Minimum"
			Me.lblRodTopMinStressHdrTop.Top = 3F
			Me.lblRodTopMinStressHdrTop.Width = 0.75F
			Me.lblRodBotMinStressHdrTop.Height = 0.145F
			Me.lblRodBotMinStressHdrTop.HyperLink = Nothing
			Me.lblRodBotMinStressHdrTop.Left = 6.125F
			Me.lblRodBotMinStressHdrTop.Name = "lblRodBotMinStressHdrTop"
			Me.lblRodBotMinStressHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodBotMinStressHdrTop.Text = "  Bot. Minimum"
			Me.lblRodBotMinStressHdrTop.Top = 3F
			Me.lblRodBotMinStressHdrTop.Width = 0.8125F
			Me.lblRodStressMethodHdrTop.Height = 0.145F
			Me.lblRodStressMethodHdrTop.HyperLink = Nothing
			Me.lblRodStressMethodHdrTop.Left = 7.0625F
			Me.lblRodStressMethodHdrTop.Name = "lblRodStressMethodHdrTop"
			Me.lblRodStressMethodHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodStressMethodHdrTop.Text = "   Stress Calc."
			Me.lblRodStressMethodHdrTop.Top = 3F
			Me.lblRodStressMethodHdrTop.Width = 0.8125F
			Me.lblRodTopMaxStressHdrTop.Height = 0.145F
			Me.lblRodTopMaxStressHdrTop.HyperLink = Nothing
			Me.lblRodTopMaxStressHdrTop.Left = 4.375F
			Me.lblRodTopMaxStressHdrTop.Name = "lblRodTopMaxStressHdrTop"
			Me.lblRodTopMaxStressHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodTopMaxStressHdrTop.Text = "Top Maximum"
			Me.lblRodTopMaxStressHdrTop.Top = 3F
			Me.lblRodTopMaxStressHdrTop.Width = 0.75F
			Me.lblRodStressHdrTop.Height = 0.145F
			Me.lblRodStressHdrTop.HyperLink = Nothing
			Me.lblRodStressHdrTop.Left = 3.75F
			Me.lblRodStressHdrTop.Name = "lblRodStressHdrTop"
			Me.lblRodStressHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodStressHdrTop.Text = "  Stress"
			Me.lblRodStressHdrTop.Top = 3F
			Me.lblRodStressHdrTop.Width = 0.5F
			Me.lblRodTensileStrengthHdrTop.Height = 0.145F
			Me.lblRodTensileStrengthHdrTop.HyperLink = Nothing
			Me.lblRodTensileStrengthHdrTop.Left = 2.4375F
			Me.lblRodTensileStrengthHdrTop.Name = "lblRodTensileStrengthHdrTop"
			Me.lblRodTensileStrengthHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrengthHdrTop.Text = "Min. Tensile"
			Me.lblRodTensileStrengthHdrTop.Top = 3F
			Me.lblRodTensileStrengthHdrTop.Width = 0.75F
			Me.lblRodLengthHdrTop.Height = 0.145F
			Me.lblRodLengthHdrTop.HyperLink = Nothing
			Me.lblRodLengthHdrTop.Left = 1.875F
			Me.lblRodLengthHdrTop.Name = "lblRodLengthHdrTop"
			Me.lblRodLengthHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodLengthHdrTop.Text = "Length"
			Me.lblRodLengthHdrTop.Top = 3F
			Me.lblRodLengthHdrTop.Width = 0.4375F
			Me.linRSCalcSep3.Height = 1.6F
			Me.linRSCalcSep3.Left = 6.0625F
			Me.linRSCalcSep3.LineWeight = 1F
			Me.linRSCalcSep3.Name = "linRSCalcSep3"
			Me.linRSCalcSep3.Top = 3F
			Me.linRSCalcSep3.Width = 0F
			Me.linRSCalcSep3.X1 = 6.0625F
			Me.linRSCalcSep3.X2 = 6.0625F
			Me.linRSCalcSep3.Y1 = 3F
			Me.linRSCalcSep3.Y2 = 4.6F
			Me.linRSCalcSep1.Height = 1.6F
			Me.linRSCalcSep1.Left = 4.3125F
			Me.linRSCalcSep1.LineWeight = 1F
			Me.linRSCalcSep1.Name = "linRSCalcSep1"
			Me.linRSCalcSep1.Top = 3F
			Me.linRSCalcSep1.Width = 0F
			Me.linRSCalcSep1.X1 = 4.3125F
			Me.linRSCalcSep1.X2 = 4.3125F
			Me.linRSCalcSep1.Y1 = 3F
			Me.linRSCalcSep1.Y2 = 4.6F
			Me.linRSCalcSep2.Height = 1.6F
			Me.linRSCalcSep2.Left = 5.1875F
			Me.linRSCalcSep2.LineWeight = 1F
			Me.linRSCalcSep2.Name = "linRSCalcSep2"
			Me.linRSCalcSep2.Top = 3F
			Me.linRSCalcSep2.Width = 0F
			Me.linRSCalcSep2.X1 = 5.1875F
			Me.linRSCalcSep2.X2 = 5.1875F
			Me.linRSCalcSep2.Y1 = 3F
			Me.linRSCalcSep2.Y2 = 4.6F
			Me.linRSCalcSep4.Height = 1.6F
			Me.linRSCalcSep4.Left = 7F
			Me.linRSCalcSep4.LineWeight = 1F
			Me.linRSCalcSep4.Name = "linRSCalcSep4"
			Me.linRSCalcSep4.Top = 3F
			Me.linRSCalcSep4.Width = 0F
			Me.linRSCalcSep4.X1 = 7F
			Me.linRSCalcSep4.X2 = 7F
			Me.linRSCalcSep4.Y1 = 3F
			Me.linRSCalcSep4.Y2 = 4.6F
			Me.lblFricCoef1.Height = 0.125F
			Me.lblFricCoef1.HyperLink = Nothing
			Me.lblFricCoef1.Left = 3.3125F
			Me.lblFricCoef1.Name = "lblFricCoef1"
			Me.lblFricCoef1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef1.Text = ""
			Me.lblFricCoef1.Top = 3.375F
			Me.lblFricCoef1.Width = 0.3125F
			Me.lblFricCoef2.Height = 0.125F
			Me.lblFricCoef2.HyperLink = Nothing
			Me.lblFricCoef2.Left = 3.3125F
			Me.lblFricCoef2.Name = "lblFricCoef2"
			Me.lblFricCoef2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef2.Text = ""
			Me.lblFricCoef2.Top = 3.5F
			Me.lblFricCoef2.Width = 0.3125F
			Me.lblFricCoef3.Height = 0.125F
			Me.lblFricCoef3.HyperLink = Nothing
			Me.lblFricCoef3.Left = 3.3125F
			Me.lblFricCoef3.Name = "lblFricCoef3"
			Me.lblFricCoef3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef3.Text = ""
			Me.lblFricCoef3.Top = 3.625F
			Me.lblFricCoef3.Width = 0.3125F
			Me.lblFricCoef4.Height = 0.125F
			Me.lblFricCoef4.HyperLink = Nothing
			Me.lblFricCoef4.Left = 3.3125F
			Me.lblFricCoef4.Name = "lblFricCoef4"
			Me.lblFricCoef4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef4.Text = ""
			Me.lblFricCoef4.Top = 3.75F
			Me.lblFricCoef4.Width = 0.3125F
			Me.lblFricCoef5.Height = 0.125F
			Me.lblFricCoef5.HyperLink = Nothing
			Me.lblFricCoef5.Left = 3.3125F
			Me.lblFricCoef5.Name = "lblFricCoef5"
			Me.lblFricCoef5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef5.Text = ""
			Me.lblFricCoef5.Top = 3.875F
			Me.lblFricCoef5.Width = 0.3125F
			Me.lblFricCoef6.Height = 0.125F
			Me.lblFricCoef6.HyperLink = Nothing
			Me.lblFricCoef6.Left = 3.3125F
			Me.lblFricCoef6.Name = "lblFricCoef6"
			Me.lblFricCoef6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef6.Text = ""
			Me.lblFricCoef6.Top = 4F
			Me.lblFricCoef6.Width = 0.3125F
			Me.lblFricCoef7.Height = 0.125F
			Me.lblFricCoef7.HyperLink = Nothing
			Me.lblFricCoef7.Left = 3.3125F
			Me.lblFricCoef7.Name = "lblFricCoef7"
			Me.lblFricCoef7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef7.Text = ""
			Me.lblFricCoef7.Top = 4.125F
			Me.lblFricCoef7.Width = 0.3125F
			Me.lblFricCoef8.Height = 0.125F
			Me.lblFricCoef8.HyperLink = Nothing
			Me.lblFricCoef8.Left = 3.3125F
			Me.lblFricCoef8.Name = "lblFricCoef8"
			Me.lblFricCoef8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef8.Text = ""
			Me.lblFricCoef8.Top = 4.25F
			Me.lblFricCoef8.Width = 0.3125F
			Me.lblFric.Height = 0.145F
			Me.lblFric.HyperLink = Nothing
			Me.lblFric.Left = 3.3125F
			Me.lblFric.Name = "lblFric"
			Me.lblFric.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblFric.Text = " Fric."
			Me.lblFric.Top = 3F
			Me.lblFric.Width = 0.3125F
			Me.lblCoeff.Height = 0.145F
			Me.lblCoeff.HyperLink = Nothing
			Me.lblCoeff.Left = 3.3125F
			Me.lblCoeff.Name = "lblCoeff"
			Me.lblCoeff.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblCoeff.Text = "Coeff"
			Me.lblCoeff.Top = 3.125F
			Me.lblCoeff.Width = 0.3125F
			Me.lblRodDiam9.Height = 0.125F
			Me.lblRodDiam9.HyperLink = Nothing
			Me.lblRodDiam9.Left = 0.0625F
			Me.lblRodDiam9.Name = "lblRodDiam9"
			Me.lblRodDiam9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam9.Text = "Diam"
			Me.lblRodDiam9.Top = 4.375F
			Me.lblRodDiam9.Width = 0.625F
			Me.lblRodGrade9.Height = 0.125F
			Me.lblRodGrade9.HyperLink = Nothing
			Me.lblRodGrade9.Left = 0.8125F
			Me.lblRodGrade9.Name = "lblRodGrade9"
			Me.lblRodGrade9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade9.Text = "Grade"
			Me.lblRodGrade9.Top = 4.375F
			Me.lblRodGrade9.Width = 0.98F
			Me.lblRodLength9.Height = 0.125F
			Me.lblRodLength9.HyperLink = Nothing
			Me.lblRodLength9.Left = 1.875F
			Me.lblRodLength9.Name = "lblRodLength9"
			Me.lblRodLength9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength9.Text = "Len"
			Me.lblRodLength9.Top = 4.375F
			Me.lblRodLength9.Width = 0.4375F
			Me.lblRodTensileStrength9.Height = 0.125F
			Me.lblRodTensileStrength9.HyperLink = Nothing
			Me.lblRodTensileStrength9.Left = 2.4375F
			Me.lblRodTensileStrength9.Name = "lblRodTensileStrength9"
			Me.lblRodTensileStrength9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength9.Text = "TS"
			Me.lblRodTensileStrength9.Top = 4.375F
			Me.lblRodTensileStrength9.Width = 0.75F
			Me.lblFricCoef9.Height = 0.125F
			Me.lblFricCoef9.HyperLink = Nothing
			Me.lblFricCoef9.Left = 3.3125F
			Me.lblFricCoef9.Name = "lblFricCoef9"
			Me.lblFricCoef9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef9.Text = ""
			Me.lblFricCoef9.Top = 4.375F
			Me.lblFricCoef9.Width = 0.3125F
			Me.lblRodStress9.Height = 0.125F
			Me.lblRodStress9.HyperLink = Nothing
			Me.lblRodStress9.Left = 3.75F
			Me.lblRodStress9.Name = "lblRodStress9"
			Me.lblRodStress9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress9.Text = "Stress"
			Me.lblRodStress9.Top = 4.375F
			Me.lblRodStress9.Width = 0.5F
			Me.lblRodTopMaxStress9.Height = 0.125F
			Me.lblRodTopMaxStress9.HyperLink = Nothing
			Me.lblRodTopMaxStress9.Left = 4.375F
			Me.lblRodTopMaxStress9.Name = "lblRodTopMaxStress9"
			Me.lblRodTopMaxStress9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress9.Text = "Top Max"
			Me.lblRodTopMaxStress9.Top = 4.375F
			Me.lblRodTopMaxStress9.Width = 0.75F
			Me.lblRodTopMinStress9.Height = 0.125F
			Me.lblRodTopMinStress9.HyperLink = Nothing
			Me.lblRodTopMinStress9.Left = 5.25F
			Me.lblRodTopMinStress9.Name = "lblRodTopMinStress9"
			Me.lblRodTopMinStress9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress9.Text = "Top Min"
			Me.lblRodTopMinStress9.Top = 4.375F
			Me.lblRodTopMinStress9.Width = 0.75F
			Me.lblRodBotMinStress9.Height = 0.125F
			Me.lblRodBotMinStress9.HyperLink = Nothing
			Me.lblRodBotMinStress9.Left = 6.125F
			Me.lblRodBotMinStress9.Name = "lblRodBotMinStress9"
			Me.lblRodBotMinStress9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress9.Text = "Bot Min"
			Me.lblRodBotMinStress9.Top = 4.375F
			Me.lblRodBotMinStress9.Width = 0.8125F
			Me.lblRodStressMethod9.Height = 0.125F
			Me.lblRodStressMethod9.HyperLink = Nothing
			Me.lblRodStressMethod9.Left = 7.0625F
			Me.lblRodStressMethod9.Name = "lblRodStressMethod9"
			Me.lblRodStressMethod9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod9.Text = "Stress Meth"
			Me.lblRodStressMethod9.Top = 4.375F
			Me.lblRodStressMethod9.Width = 0.8125F
			Me.lblRodDiam10.Height = 0.125F
			Me.lblRodDiam10.HyperLink = Nothing
			Me.lblRodDiam10.Left = 0.0625F
			Me.lblRodDiam10.Name = "lblRodDiam10"
			Me.lblRodDiam10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam10.Text = "Diam"
			Me.lblRodDiam10.Top = 4.5F
			Me.lblRodDiam10.Width = 0.625F
			Me.lblRodGrade10.Height = 0.125F
			Me.lblRodGrade10.HyperLink = Nothing
			Me.lblRodGrade10.Left = 0.8125F
			Me.lblRodGrade10.Name = "lblRodGrade10"
			Me.lblRodGrade10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade10.Text = "Grade"
			Me.lblRodGrade10.Top = 4.5F
			Me.lblRodGrade10.Width = 0.98F
			Me.lblRodLength10.Height = 0.125F
			Me.lblRodLength10.HyperLink = Nothing
			Me.lblRodLength10.Left = 1.875F
			Me.lblRodLength10.Name = "lblRodLength10"
			Me.lblRodLength10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength10.Text = "Len"
			Me.lblRodLength10.Top = 4.5F
			Me.lblRodLength10.Width = 0.4375F
			Me.lblRodTensileStrength10.Height = 0.125F
			Me.lblRodTensileStrength10.HyperLink = Nothing
			Me.lblRodTensileStrength10.Left = 2.4375F
			Me.lblRodTensileStrength10.Name = "lblRodTensileStrength10"
			Me.lblRodTensileStrength10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength10.Text = "TS"
			Me.lblRodTensileStrength10.Top = 4.5F
			Me.lblRodTensileStrength10.Width = 0.75F
			Me.lblFricCoef10.Height = 0.125F
			Me.lblFricCoef10.HyperLink = Nothing
			Me.lblFricCoef10.Left = 3.3125F
			Me.lblFricCoef10.Name = "lblFricCoef10"
			Me.lblFricCoef10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef10.Text = ""
			Me.lblFricCoef10.Top = 4.5F
			Me.lblFricCoef10.Width = 0.3125F
			Me.lblRodStress10.Height = 0.125F
			Me.lblRodStress10.HyperLink = Nothing
			Me.lblRodStress10.Left = 3.75F
			Me.lblRodStress10.Name = "lblRodStress10"
			Me.lblRodStress10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress10.Text = "Stress"
			Me.lblRodStress10.Top = 4.5F
			Me.lblRodStress10.Width = 0.5F
			Me.lblRodTopMaxStress10.Height = 0.125F
			Me.lblRodTopMaxStress10.HyperLink = Nothing
			Me.lblRodTopMaxStress10.Left = 4.375F
			Me.lblRodTopMaxStress10.Name = "lblRodTopMaxStress10"
			Me.lblRodTopMaxStress10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress10.Text = "Top Max"
			Me.lblRodTopMaxStress10.Top = 4.5F
			Me.lblRodTopMaxStress10.Width = 0.75F
			Me.lblRodTopMinStress10.Height = 0.125F
			Me.lblRodTopMinStress10.HyperLink = Nothing
			Me.lblRodTopMinStress10.Left = 5.25F
			Me.lblRodTopMinStress10.Name = "lblRodTopMinStress10"
			Me.lblRodTopMinStress10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress10.Text = "Top Min"
			Me.lblRodTopMinStress10.Top = 4.5F
			Me.lblRodTopMinStress10.Width = 0.75F
			Me.lblRodBotMinStress10.Height = 0.125F
			Me.lblRodBotMinStress10.HyperLink = Nothing
			Me.lblRodBotMinStress10.Left = 6.125F
			Me.lblRodBotMinStress10.Name = "lblRodBotMinStress10"
			Me.lblRodBotMinStress10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress10.Text = "Bot Min"
			Me.lblRodBotMinStress10.Top = 4.5F
			Me.lblRodBotMinStress10.Width = 0.8125F
			Me.lblRodStressMethod10.Height = 0.125F
			Me.lblRodStressMethod10.HyperLink = Nothing
			Me.lblRodStressMethod10.Left = 7.0625F
			Me.lblRodStressMethod10.Name = "lblRodStressMethod10"
			Me.lblRodStressMethod10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod10.Text = "Stress Meth"
			Me.lblRodStressMethod10.Top = 4.5F
			Me.lblRodStressMethod10.Width = 0.8125F
			Me.linRSInputSep2.Height = 1.6F
			Me.linRSInputSep2.Left = 1.8125F
			Me.linRSInputSep2.LineWeight = 1F
			Me.linRSInputSep2.Name = "linRSInputSep2"
			Me.linRSInputSep2.Top = 3F
			Me.linRSInputSep2.Width = 0F
			Me.linRSInputSep2.X1 = 1.8125F
			Me.linRSInputSep2.X2 = 1.8125F
			Me.linRSInputSep2.Y1 = 3F
			Me.linRSInputSep2.Y2 = 4.6F
			Me.rtbSecondCompanyComments2.AutoReplaceFields = True
			Me.rtbSecondCompanyComments2.CanShrink = True
			Me.rtbSecondCompanyComments2.Font = New Font("Arial", 10F)
			Me.rtbSecondCompanyComments2.Height = 1.457999F
			Me.rtbSecondCompanyComments2.Left = 0.062F
			Me.rtbSecondCompanyComments2.Name = "rtbSecondCompanyComments2"
			Me.rtbSecondCompanyComments2.RTF = componentResourceManager.GetString("rtbSecondCompanyComments2.RTF")
			Me.rtbSecondCompanyComments2.Top = 6.675001F
			Me.rtbSecondCompanyComments2.Width = 7.8125F
			Me.lblRodTensileStrength11.Height = 0.125F
			Me.lblRodTensileStrength11.HyperLink = Nothing
			Me.lblRodTensileStrength11.Left = 2.442F
			Me.lblRodTensileStrength11.Name = "lblRodTensileStrength11"
			Me.lblRodTensileStrength11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength11.Text = "TS"
			Me.lblRodTensileStrength11.Top = 4.625F
			Me.lblRodTensileStrength11.Width = 0.75F
			Me.lblRodLength11.Height = 0.125F
			Me.lblRodLength11.HyperLink = Nothing
			Me.lblRodLength11.Left = 1.879F
			Me.lblRodLength11.Name = "lblRodLength11"
			Me.lblRodLength11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblRodLength11.Text = "Len"
			Me.lblRodLength11.Top = 4.625F
			Me.lblRodLength11.Width = 0.4375F
			Me.lblRodGrade11.Height = 0.125F
			Me.lblRodGrade11.HyperLink = Nothing
			Me.lblRodGrade11.Left = 0.8170001F
			Me.lblRodGrade11.Name = "lblRodGrade11"
			Me.lblRodGrade11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade11.Text = "Grade"
			Me.lblRodGrade11.Top = 4.625F
			Me.lblRodGrade11.Width = 0.98F
			Me.lblRodDiam11.Height = 0.125F
			Me.lblRodDiam11.HyperLink = Nothing
			Me.lblRodDiam11.Left = 0.061F
			Me.lblRodDiam11.Name = "lblRodDiam11"
			Me.lblRodDiam11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam11.Text = "Diam"
			Me.lblRodDiam11.Top = 4.625F
			Me.lblRodDiam11.Width = 0.625F
			Me.lblRodDiam12.Height = 0.125F
			Me.lblRodDiam12.HyperLink = Nothing
			Me.lblRodDiam12.Left = 0.061F
			Me.lblRodDiam12.Name = "lblRodDiam12"
			Me.lblRodDiam12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam12.Text = "Diam"
			Me.lblRodDiam12.Top = 4.75F
			Me.lblRodDiam12.Width = 0.625F
			Me.lblRodDiam13.Height = 0.125F
			Me.lblRodDiam13.HyperLink = Nothing
			Me.lblRodDiam13.Left = 0.061F
			Me.lblRodDiam13.Name = "lblRodDiam13"
			Me.lblRodDiam13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam13.Text = "Diam"
			Me.lblRodDiam13.Top = 4.875F
			Me.lblRodDiam13.Width = 0.625F
			Me.lblRodDiam14.Height = 0.125F
			Me.lblRodDiam14.HyperLink = Nothing
			Me.lblRodDiam14.Left = 0.061F
			Me.lblRodDiam14.Name = "lblRodDiam14"
			Me.lblRodDiam14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam14.Text = "Diam"
			Me.lblRodDiam14.Top = 5F
			Me.lblRodDiam14.Width = 0.625F
			Me.lblRodDiam15.Height = 0.125F
			Me.lblRodDiam15.HyperLink = Nothing
			Me.lblRodDiam15.Left = 0.061F
			Me.lblRodDiam15.Name = "lblRodDiam15"
			Me.lblRodDiam15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam15.Text = "Diam"
			Me.lblRodDiam15.Top = 5.124999F
			Me.lblRodDiam15.Width = 0.625F
			Me.lblRodDiam16.Height = 0.125F
			Me.lblRodDiam16.HyperLink = Nothing
			Me.lblRodDiam16.Left = 0.061F
			Me.lblRodDiam16.Name = "lblRodDiam16"
			Me.lblRodDiam16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam16.Text = "Diam"
			Me.lblRodDiam16.Top = 5.249999F
			Me.lblRodDiam16.Width = 0.625F
			Me.lblRodDiam17.Height = 0.125F
			Me.lblRodDiam17.HyperLink = Nothing
			Me.lblRodDiam17.Left = 0.061F
			Me.lblRodDiam17.Name = "lblRodDiam17"
			Me.lblRodDiam17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam17.Text = "Diam"
			Me.lblRodDiam17.Top = 5.374999F
			Me.lblRodDiam17.Width = 0.625F
			Me.lblRodDiam18.Height = 0.125F
			Me.lblRodDiam18.HyperLink = Nothing
			Me.lblRodDiam18.Left = 0.061F
			Me.lblRodDiam18.Name = "lblRodDiam18"
			Me.lblRodDiam18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam18.Text = "Diam"
			Me.lblRodDiam18.Top = 5.499999F
			Me.lblRodDiam18.Width = 0.625F
			Me.lblRodGrade12.Height = 0.125F
			Me.lblRodGrade12.HyperLink = Nothing
			Me.lblRodGrade12.Left = 0.8170001F
			Me.lblRodGrade12.Name = "lblRodGrade12"
			Me.lblRodGrade12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade12.Text = "Grade"
			Me.lblRodGrade12.Top = 4.75F
			Me.lblRodGrade12.Width = 0.98F
			Me.lblRodGrade13.Height = 0.125F
			Me.lblRodGrade13.HyperLink = Nothing
			Me.lblRodGrade13.Left = 0.8170001F
			Me.lblRodGrade13.Name = "lblRodGrade13"
			Me.lblRodGrade13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade13.Text = "Grade"
			Me.lblRodGrade13.Top = 4.875F
			Me.lblRodGrade13.Width = 0.98F
			Me.lblRodGrade14.Height = 0.125F
			Me.lblRodGrade14.HyperLink = Nothing
			Me.lblRodGrade14.Left = 0.8170001F
			Me.lblRodGrade14.Name = "lblRodGrade14"
			Me.lblRodGrade14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade14.Text = "Grade"
			Me.lblRodGrade14.Top = 5F
			Me.lblRodGrade14.Width = 0.98F
			Me.lblRodGrade15.Height = 0.125F
			Me.lblRodGrade15.HyperLink = Nothing
			Me.lblRodGrade15.Left = 0.8170001F
			Me.lblRodGrade15.Name = "lblRodGrade15"
			Me.lblRodGrade15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade15.Text = "Grade"
			Me.lblRodGrade15.Top = 5.124999F
			Me.lblRodGrade15.Width = 0.98F
			Me.lblRodGrade16.Height = 0.125F
			Me.lblRodGrade16.HyperLink = Nothing
			Me.lblRodGrade16.Left = 0.8170001F
			Me.lblRodGrade16.Name = "lblRodGrade16"
			Me.lblRodGrade16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade16.Text = "Grade"
			Me.lblRodGrade16.Top = 5.249999F
			Me.lblRodGrade16.Width = 0.98F
			Me.lblRodGrade17.Height = 0.125F
			Me.lblRodGrade17.HyperLink = Nothing
			Me.lblRodGrade17.Left = 0.8170001F
			Me.lblRodGrade17.Name = "lblRodGrade17"
			Me.lblRodGrade17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade17.Text = "Grade"
			Me.lblRodGrade17.Top = 5.374999F
			Me.lblRodGrade17.Width = 0.98F
			Me.lblRodGrade18.Height = 0.125F
			Me.lblRodGrade18.HyperLink = Nothing
			Me.lblRodGrade18.Left = 0.8170001F
			Me.lblRodGrade18.Name = "lblRodGrade18"
			Me.lblRodGrade18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade18.Text = "Grade"
			Me.lblRodGrade18.Top = 5.499999F
			Me.lblRodGrade18.Width = 0.98F
			Me.lblRodLength12.Height = 0.125F
			Me.lblRodLength12.HyperLink = Nothing
			Me.lblRodLength12.Left = 1.879F
			Me.lblRodLength12.Name = "lblRodLength12"
			Me.lblRodLength12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblRodLength12.Text = "Len"
			Me.lblRodLength12.Top = 4.75F
			Me.lblRodLength12.Width = 0.4375F
			Me.lblRodLength13.Height = 0.125F
			Me.lblRodLength13.HyperLink = Nothing
			Me.lblRodLength13.Left = 1.879F
			Me.lblRodLength13.Name = "lblRodLength13"
			Me.lblRodLength13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblRodLength13.Text = "Len"
			Me.lblRodLength13.Top = 4.875F
			Me.lblRodLength13.Width = 0.4375F
			Me.lblRodLength14.Height = 0.125F
			Me.lblRodLength14.HyperLink = Nothing
			Me.lblRodLength14.Left = 1.879F
			Me.lblRodLength14.Name = "lblRodLength14"
			Me.lblRodLength14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblRodLength14.Text = "Len"
			Me.lblRodLength14.Top = 5F
			Me.lblRodLength14.Width = 0.4375F
			Me.lblRodLength15.Height = 0.125F
			Me.lblRodLength15.HyperLink = Nothing
			Me.lblRodLength15.Left = 1.879F
			Me.lblRodLength15.Name = "lblRodLength15"
			Me.lblRodLength15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblRodLength15.Text = "Len"
			Me.lblRodLength15.Top = 5.124999F
			Me.lblRodLength15.Width = 0.4375F
			Me.lblRodLength16.Height = 0.125F
			Me.lblRodLength16.HyperLink = Nothing
			Me.lblRodLength16.Left = 1.8785F
			Me.lblRodLength16.Name = "lblRodLength16"
			Me.lblRodLength16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblRodLength16.Text = "Len"
			Me.lblRodLength16.Top = 5.249999F
			Me.lblRodLength16.Width = 0.4375F
			Me.lblRodLength17.Height = 0.125F
			Me.lblRodLength17.HyperLink = Nothing
			Me.lblRodLength17.Left = 1.879F
			Me.lblRodLength17.Name = "lblRodLength17"
			Me.lblRodLength17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblRodLength17.Text = "Len"
			Me.lblRodLength17.Top = 5.374999F
			Me.lblRodLength17.Width = 0.4375F
			Me.lblRodLength18.Height = 0.125F
			Me.lblRodLength18.HyperLink = Nothing
			Me.lblRodLength18.Left = 1.879F
			Me.lblRodLength18.Name = "lblRodLength18"
			Me.lblRodLength18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblRodLength18.Text = "Len"
			Me.lblRodLength18.Top = 5.499999F
			Me.lblRodLength18.Width = 0.4375F
			Me.lblRodTensileStrength12.Height = 0.125F
			Me.lblRodTensileStrength12.HyperLink = Nothing
			Me.lblRodTensileStrength12.Left = 2.442F
			Me.lblRodTensileStrength12.Name = "lblRodTensileStrength12"
			Me.lblRodTensileStrength12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength12.Text = "TS"
			Me.lblRodTensileStrength12.Top = 4.75F
			Me.lblRodTensileStrength12.Width = 0.75F
			Me.lblRodTensileStrength13.Height = 0.125F
			Me.lblRodTensileStrength13.HyperLink = Nothing
			Me.lblRodTensileStrength13.Left = 2.442F
			Me.lblRodTensileStrength13.Name = "lblRodTensileStrength13"
			Me.lblRodTensileStrength13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength13.Text = "TS"
			Me.lblRodTensileStrength13.Top = 4.875F
			Me.lblRodTensileStrength13.Width = 0.75F
			Me.lblRodTensileStrength14.Height = 0.125F
			Me.lblRodTensileStrength14.HyperLink = Nothing
			Me.lblRodTensileStrength14.Left = 2.442F
			Me.lblRodTensileStrength14.Name = "lblRodTensileStrength14"
			Me.lblRodTensileStrength14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength14.Text = "TS"
			Me.lblRodTensileStrength14.Top = 5F
			Me.lblRodTensileStrength14.Width = 0.75F
			Me.lblRodTensileStrength15.Height = 0.125F
			Me.lblRodTensileStrength15.HyperLink = Nothing
			Me.lblRodTensileStrength15.Left = 2.442F
			Me.lblRodTensileStrength15.Name = "lblRodTensileStrength15"
			Me.lblRodTensileStrength15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength15.Text = "TS"
			Me.lblRodTensileStrength15.Top = 5.124999F
			Me.lblRodTensileStrength15.Width = 0.75F
			Me.lblRodTensileStrength16.Height = 0.125F
			Me.lblRodTensileStrength16.HyperLink = Nothing
			Me.lblRodTensileStrength16.Left = 2.442F
			Me.lblRodTensileStrength16.Name = "lblRodTensileStrength16"
			Me.lblRodTensileStrength16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength16.Text = "TS"
			Me.lblRodTensileStrength16.Top = 5.249999F
			Me.lblRodTensileStrength16.Width = 0.75F
			Me.lblRodTensileStrength17.Height = 0.125F
			Me.lblRodTensileStrength17.HyperLink = Nothing
			Me.lblRodTensileStrength17.Left = 2.442F
			Me.lblRodTensileStrength17.Name = "lblRodTensileStrength17"
			Me.lblRodTensileStrength17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength17.Text = "TS"
			Me.lblRodTensileStrength17.Top = 5.374999F
			Me.lblRodTensileStrength17.Width = 0.75F
			Me.lblRodTensileStrength18.Height = 0.125F
			Me.lblRodTensileStrength18.HyperLink = Nothing
			Me.lblRodTensileStrength18.Left = 2.442F
			Me.lblRodTensileStrength18.Name = "lblRodTensileStrength18"
			Me.lblRodTensileStrength18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength18.Text = "TS"
			Me.lblRodTensileStrength18.Top = 5.499999F
			Me.lblRodTensileStrength18.Width = 0.75F
			Me.lblRodStress11.Height = 0.125F
			Me.lblRodStress11.HyperLink = Nothing
			Me.lblRodStress11.Left = 3.754F
			Me.lblRodStress11.Name = "lblRodStress11"
			Me.lblRodStress11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress11.Text = "Stress"
			Me.lblRodStress11.Top = 4.625F
			Me.lblRodStress11.Width = 0.5F
			Me.lblRodStress12.Height = 0.125F
			Me.lblRodStress12.HyperLink = Nothing
			Me.lblRodStress12.Left = 3.754F
			Me.lblRodStress12.Name = "lblRodStress12"
			Me.lblRodStress12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress12.Text = "Stress"
			Me.lblRodStress12.Top = 4.75F
			Me.lblRodStress12.Width = 0.5F
			Me.lblRodStress13.Height = 0.125F
			Me.lblRodStress13.HyperLink = Nothing
			Me.lblRodStress13.Left = 3.754F
			Me.lblRodStress13.Name = "lblRodStress13"
			Me.lblRodStress13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress13.Text = "Stress"
			Me.lblRodStress13.Top = 4.875F
			Me.lblRodStress13.Width = 0.5F
			Me.lblRodStress14.Height = 0.125F
			Me.lblRodStress14.HyperLink = Nothing
			Me.lblRodStress14.Left = 3.7535F
			Me.lblRodStress14.Name = "lblRodStress14"
			Me.lblRodStress14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress14.Text = "Stress"
			Me.lblRodStress14.Top = 5F
			Me.lblRodStress14.Width = 0.5F
			Me.lblRodStress15.Height = 0.125F
			Me.lblRodStress15.HyperLink = Nothing
			Me.lblRodStress15.Left = 3.754F
			Me.lblRodStress15.Name = "lblRodStress15"
			Me.lblRodStress15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress15.Text = "Stress"
			Me.lblRodStress15.Top = 5.124999F
			Me.lblRodStress15.Width = 0.5F
			Me.lblRodStress16.Height = 0.125F
			Me.lblRodStress16.HyperLink = Nothing
			Me.lblRodStress16.Left = 3.754F
			Me.lblRodStress16.Name = "lblRodStress16"
			Me.lblRodStress16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress16.Text = "Stress"
			Me.lblRodStress16.Top = 5.249999F
			Me.lblRodStress16.Width = 0.5F
			Me.lblRodStress17.Height = 0.125F
			Me.lblRodStress17.HyperLink = Nothing
			Me.lblRodStress17.Left = 3.754F
			Me.lblRodStress17.Name = "lblRodStress17"
			Me.lblRodStress17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress17.Text = "Stress"
			Me.lblRodStress17.Top = 5.374999F
			Me.lblRodStress17.Width = 0.5F
			Me.lblRodStress18.Height = 0.125F
			Me.lblRodStress18.HyperLink = Nothing
			Me.lblRodStress18.Left = 3.754F
			Me.lblRodStress18.Name = "lblRodStress18"
			Me.lblRodStress18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress18.Text = "Stress"
			Me.lblRodStress18.Top = 5.499999F
			Me.lblRodStress18.Width = 0.5F
			Me.lblRodTopMaxStress11.Height = 0.125F
			Me.lblRodTopMaxStress11.HyperLink = Nothing
			Me.lblRodTopMaxStress11.Left = 4.379002F
			Me.lblRodTopMaxStress11.Name = "lblRodTopMaxStress11"
			Me.lblRodTopMaxStress11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress11.Text = "Top Max"
			Me.lblRodTopMaxStress11.Top = 4.625F
			Me.lblRodTopMaxStress11.Width = 0.75F
			Me.lblRodTopMaxStress12.Height = 0.125F
			Me.lblRodTopMaxStress12.HyperLink = Nothing
			Me.lblRodTopMaxStress12.Left = 4.379002F
			Me.lblRodTopMaxStress12.Name = "lblRodTopMaxStress12"
			Me.lblRodTopMaxStress12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress12.Text = "Top Max"
			Me.lblRodTopMaxStress12.Top = 4.75F
			Me.lblRodTopMaxStress12.Width = 0.75F
			Me.lblRodTopMaxStress13.Height = 0.125F
			Me.lblRodTopMaxStress13.HyperLink = Nothing
			Me.lblRodTopMaxStress13.Left = 4.379002F
			Me.lblRodTopMaxStress13.Name = "lblRodTopMaxStress13"
			Me.lblRodTopMaxStress13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress13.Text = "Top Max"
			Me.lblRodTopMaxStress13.Top = 4.875F
			Me.lblRodTopMaxStress13.Width = 0.75F
			Me.lblRodTopMaxStress14.Height = 0.125F
			Me.lblRodTopMaxStress14.HyperLink = Nothing
			Me.lblRodTopMaxStress14.Left = 4.379501F
			Me.lblRodTopMaxStress14.Name = "lblRodTopMaxStress14"
			Me.lblRodTopMaxStress14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress14.Text = "Top Max"
			Me.lblRodTopMaxStress14.Top = 5F
			Me.lblRodTopMaxStress14.Width = 0.75F
			Me.lblRodTopMaxStress15.Height = 0.125F
			Me.lblRodTopMaxStress15.HyperLink = Nothing
			Me.lblRodTopMaxStress15.Left = 4.379002F
			Me.lblRodTopMaxStress15.Name = "lblRodTopMaxStress15"
			Me.lblRodTopMaxStress15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress15.Text = "Top Max"
			Me.lblRodTopMaxStress15.Top = 5.124999F
			Me.lblRodTopMaxStress15.Width = 0.75F
			Me.lblRodTopMaxStress16.Height = 0.125F
			Me.lblRodTopMaxStress16.HyperLink = Nothing
			Me.lblRodTopMaxStress16.Left = 4.379002F
			Me.lblRodTopMaxStress16.Name = "lblRodTopMaxStress16"
			Me.lblRodTopMaxStress16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress16.Text = "Top Max"
			Me.lblRodTopMaxStress16.Top = 5.249999F
			Me.lblRodTopMaxStress16.Width = 0.75F
			Me.lblRodTopMaxStress17.Height = 0.125F
			Me.lblRodTopMaxStress17.HyperLink = Nothing
			Me.lblRodTopMaxStress17.Left = 4.379002F
			Me.lblRodTopMaxStress17.Name = "lblRodTopMaxStress17"
			Me.lblRodTopMaxStress17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress17.Text = "Top Max"
			Me.lblRodTopMaxStress17.Top = 5.374999F
			Me.lblRodTopMaxStress17.Width = 0.75F
			Me.lblRodTopMaxStress18.Height = 0.125F
			Me.lblRodTopMaxStress18.HyperLink = Nothing
			Me.lblRodTopMaxStress18.Left = 4.379002F
			Me.lblRodTopMaxStress18.Name = "lblRodTopMaxStress18"
			Me.lblRodTopMaxStress18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress18.Text = "Top Max"
			Me.lblRodTopMaxStress18.Top = 5.499999F
			Me.lblRodTopMaxStress18.Width = 0.75F
			Me.lblRodTopMinStress11.Height = 0.125F
			Me.lblRodTopMinStress11.HyperLink = Nothing
			Me.lblRodTopMinStress11.Left = 5.254002F
			Me.lblRodTopMinStress11.Name = "lblRodTopMinStress11"
			Me.lblRodTopMinStress11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress11.Text = "Top Min"
			Me.lblRodTopMinStress11.Top = 4.625F
			Me.lblRodTopMinStress11.Width = 0.75F
			Me.lblRodTopMinStress12.Height = 0.125F
			Me.lblRodTopMinStress12.HyperLink = Nothing
			Me.lblRodTopMinStress12.Left = 5.254002F
			Me.lblRodTopMinStress12.Name = "lblRodTopMinStress12"
			Me.lblRodTopMinStress12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress12.Text = "Top Min"
			Me.lblRodTopMinStress12.Top = 4.75F
			Me.lblRodTopMinStress12.Width = 0.75F
			Me.lblRodTopMinStress13.Height = 0.125F
			Me.lblRodTopMinStress13.HyperLink = Nothing
			Me.lblRodTopMinStress13.Left = 5.254002F
			Me.lblRodTopMinStress13.Name = "lblRodTopMinStress13"
			Me.lblRodTopMinStress13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress13.Text = "Top Min"
			Me.lblRodTopMinStress13.Top = 4.875F
			Me.lblRodTopMinStress13.Width = 0.75F
			Me.lblRodTopMinStress14.Height = 0.125F
			Me.lblRodTopMinStress14.HyperLink = Nothing
			Me.lblRodTopMinStress14.Left = 5.254002F
			Me.lblRodTopMinStress14.Name = "lblRodTopMinStress14"
			Me.lblRodTopMinStress14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress14.Text = "Top Min"
			Me.lblRodTopMinStress14.Top = 5F
			Me.lblRodTopMinStress14.Width = 0.75F
			Me.lblRodTopMinStress15.Height = 0.125F
			Me.lblRodTopMinStress15.HyperLink = Nothing
			Me.lblRodTopMinStress15.Left = 5.254002F
			Me.lblRodTopMinStress15.Name = "lblRodTopMinStress15"
			Me.lblRodTopMinStress15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress15.Text = "Top Min"
			Me.lblRodTopMinStress15.Top = 5.124999F
			Me.lblRodTopMinStress15.Width = 0.75F
			Me.lblRodTopMinStress16.Height = 0.125F
			Me.lblRodTopMinStress16.HyperLink = Nothing
			Me.lblRodTopMinStress16.Left = 5.254002F
			Me.lblRodTopMinStress16.Name = "lblRodTopMinStress16"
			Me.lblRodTopMinStress16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress16.Text = "Top Min"
			Me.lblRodTopMinStress16.Top = 5.249999F
			Me.lblRodTopMinStress16.Width = 0.75F
			Me.lblRodTopMinStress17.Height = 0.125F
			Me.lblRodTopMinStress17.HyperLink = Nothing
			Me.lblRodTopMinStress17.Left = 5.254002F
			Me.lblRodTopMinStress17.Name = "lblRodTopMinStress17"
			Me.lblRodTopMinStress17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress17.Text = "Top Min"
			Me.lblRodTopMinStress17.Top = 5.374999F
			Me.lblRodTopMinStress17.Width = 0.75F
			Me.lblRodTopMinStress18.Height = 0.125F
			Me.lblRodTopMinStress18.HyperLink = Nothing
			Me.lblRodTopMinStress18.Left = 5.254002F
			Me.lblRodTopMinStress18.Name = "lblRodTopMinStress18"
			Me.lblRodTopMinStress18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress18.Text = "Top Min"
			Me.lblRodTopMinStress18.Top = 5.499999F
			Me.lblRodTopMinStress18.Width = 0.75F
			Me.lblRodBotMinStress11.Height = 0.125F
			Me.lblRodBotMinStress11.HyperLink = Nothing
			Me.lblRodBotMinStress11.Left = 6.129001F
			Me.lblRodBotMinStress11.Name = "lblRodBotMinStress11"
			Me.lblRodBotMinStress11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress11.Text = "Bot Min"
			Me.lblRodBotMinStress11.Top = 4.625F
			Me.lblRodBotMinStress11.Width = 0.8125F
			Me.lblRodBotMinStress12.Height = 0.125F
			Me.lblRodBotMinStress12.HyperLink = Nothing
			Me.lblRodBotMinStress12.Left = 6.129001F
			Me.lblRodBotMinStress12.Name = "lblRodBotMinStress12"
			Me.lblRodBotMinStress12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress12.Text = "Bot Min"
			Me.lblRodBotMinStress12.Top = 4.75F
			Me.lblRodBotMinStress12.Width = 0.8125F
			Me.lblRodBotMinStress13.Height = 0.125F
			Me.lblRodBotMinStress13.HyperLink = Nothing
			Me.lblRodBotMinStress13.Left = 6.129001F
			Me.lblRodBotMinStress13.Name = "lblRodBotMinStress13"
			Me.lblRodBotMinStress13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress13.Text = "Bot Min"
			Me.lblRodBotMinStress13.Top = 4.875F
			Me.lblRodBotMinStress13.Width = 0.8125F
			Me.lblRodBotMinStress14.Height = 0.125F
			Me.lblRodBotMinStress14.HyperLink = Nothing
			Me.lblRodBotMinStress14.Left = 6.129001F
			Me.lblRodBotMinStress14.Name = "lblRodBotMinStress14"
			Me.lblRodBotMinStress14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress14.Text = "Bot Min"
			Me.lblRodBotMinStress14.Top = 5F
			Me.lblRodBotMinStress14.Width = 0.8125F
			Me.lblRodBotMinStress15.Height = 0.125F
			Me.lblRodBotMinStress15.HyperLink = Nothing
			Me.lblRodBotMinStress15.Left = 6.129001F
			Me.lblRodBotMinStress15.Name = "lblRodBotMinStress15"
			Me.lblRodBotMinStress15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress15.Text = "Bot Min"
			Me.lblRodBotMinStress15.Top = 5.124999F
			Me.lblRodBotMinStress15.Width = 0.8125F
			Me.lblRodBotMinStress16.Height = 0.125F
			Me.lblRodBotMinStress16.HyperLink = Nothing
			Me.lblRodBotMinStress16.Left = 6.129001F
			Me.lblRodBotMinStress16.Name = "lblRodBotMinStress16"
			Me.lblRodBotMinStress16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress16.Text = "Bot Min"
			Me.lblRodBotMinStress16.Top = 5.249999F
			Me.lblRodBotMinStress16.Width = 0.8125F
			Me.lblRodBotMinStress17.Height = 0.125F
			Me.lblRodBotMinStress17.HyperLink = Nothing
			Me.lblRodBotMinStress17.Left = 6.129001F
			Me.lblRodBotMinStress17.Name = "lblRodBotMinStress17"
			Me.lblRodBotMinStress17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress17.Text = "Bot Min"
			Me.lblRodBotMinStress17.Top = 5.374999F
			Me.lblRodBotMinStress17.Width = 0.8125F
			Me.lblRodBotMinStress18.Height = 0.125F
			Me.lblRodBotMinStress18.HyperLink = Nothing
			Me.lblRodBotMinStress18.Left = 6.129001F
			Me.lblRodBotMinStress18.Name = "lblRodBotMinStress18"
			Me.lblRodBotMinStress18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress18.Text = "Bot Min"
			Me.lblRodBotMinStress18.Top = 5.499999F
			Me.lblRodBotMinStress18.Width = 0.8125F
			Me.lblRodStressMethod11.Height = 0.125F
			Me.lblRodStressMethod11.HyperLink = Nothing
			Me.lblRodStressMethod11.Left = 7.067001F
			Me.lblRodStressMethod11.Name = "lblRodStressMethod11"
			Me.lblRodStressMethod11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod11.Text = "Stress Meth"
			Me.lblRodStressMethod11.Top = 4.625F
			Me.lblRodStressMethod11.Width = 0.8125F
			Me.lblRodStressMethod12.Height = 0.125F
			Me.lblRodStressMethod12.HyperLink = Nothing
			Me.lblRodStressMethod12.Left = 7.067001F
			Me.lblRodStressMethod12.Name = "lblRodStressMethod12"
			Me.lblRodStressMethod12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod12.Text = "Stress Meth"
			Me.lblRodStressMethod12.Top = 4.75F
			Me.lblRodStressMethod12.Width = 0.8125F
			Me.lblRodStressMethod13.Height = 0.125F
			Me.lblRodStressMethod13.HyperLink = Nothing
			Me.lblRodStressMethod13.Left = 7.067001F
			Me.lblRodStressMethod13.Name = "lblRodStressMethod13"
			Me.lblRodStressMethod13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod13.Text = "Stress Meth"
			Me.lblRodStressMethod13.Top = 4.875F
			Me.lblRodStressMethod13.Width = 0.8125F
			Me.lblRodStressMethod14.Height = 0.125F
			Me.lblRodStressMethod14.HyperLink = Nothing
			Me.lblRodStressMethod14.Left = 7.067001F
			Me.lblRodStressMethod14.Name = "lblRodStressMethod14"
			Me.lblRodStressMethod14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod14.Text = "Stress Meth"
			Me.lblRodStressMethod14.Top = 5F
			Me.lblRodStressMethod14.Width = 0.8125F
			Me.lblRodStressMethod15.Height = 0.125F
			Me.lblRodStressMethod15.HyperLink = Nothing
			Me.lblRodStressMethod15.Left = 7.067001F
			Me.lblRodStressMethod15.Name = "lblRodStressMethod15"
			Me.lblRodStressMethod15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod15.Text = "Stress Meth"
			Me.lblRodStressMethod15.Top = 5.124999F
			Me.lblRodStressMethod15.Width = 0.8125F
			Me.lblRodStressMethod16.Height = 0.125F
			Me.lblRodStressMethod16.HyperLink = Nothing
			Me.lblRodStressMethod16.Left = 7.067001F
			Me.lblRodStressMethod16.Name = "lblRodStressMethod16"
			Me.lblRodStressMethod16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod16.Text = "Stress Meth"
			Me.lblRodStressMethod16.Top = 5.249999F
			Me.lblRodStressMethod16.Width = 0.8125F
			Me.lblRodStressMethod17.Height = 0.125F
			Me.lblRodStressMethod17.HyperLink = Nothing
			Me.lblRodStressMethod17.Left = 7.067001F
			Me.lblRodStressMethod17.Name = "lblRodStressMethod17"
			Me.lblRodStressMethod17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod17.Text = "Stress Meth"
			Me.lblRodStressMethod17.Top = 5.374999F
			Me.lblRodStressMethod17.Width = 0.8125F
			Me.lblRodStressMethod18.Height = 0.125F
			Me.lblRodStressMethod18.HyperLink = Nothing
			Me.lblRodStressMethod18.Left = 7.067001F
			Me.lblRodStressMethod18.Name = "lblRodStressMethod18"
			Me.lblRodStressMethod18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod18.Text = "Stress Meth"
			Me.lblRodStressMethod18.Top = 5.499999F
			Me.lblRodStressMethod18.Width = 0.8125F
			Me.lblFricCoef11.Height = 0.125F
			Me.lblFricCoef11.HyperLink = Nothing
			Me.lblFricCoef11.Left = 3.317F
			Me.lblFricCoef11.Name = "lblFricCoef11"
			Me.lblFricCoef11.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef11.Text = ""
			Me.lblFricCoef11.Top = 4.625F
			Me.lblFricCoef11.Width = 0.3125F
			Me.lblFricCoef12.Height = 0.125F
			Me.lblFricCoef12.HyperLink = Nothing
			Me.lblFricCoef12.Left = 3.317F
			Me.lblFricCoef12.Name = "lblFricCoef12"
			Me.lblFricCoef12.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef12.Text = ""
			Me.lblFricCoef12.Top = 4.75F
			Me.lblFricCoef12.Width = 0.3125F
			Me.lblFricCoef13.Height = 0.125F
			Me.lblFricCoef13.HyperLink = Nothing
			Me.lblFricCoef13.Left = 3.317F
			Me.lblFricCoef13.Name = "lblFricCoef13"
			Me.lblFricCoef13.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef13.Text = ""
			Me.lblFricCoef13.Top = 4.875F
			Me.lblFricCoef13.Width = 0.3125F
			Me.lblFricCoef14.Height = 0.125F
			Me.lblFricCoef14.HyperLink = Nothing
			Me.lblFricCoef14.Left = 3.317F
			Me.lblFricCoef14.Name = "lblFricCoef14"
			Me.lblFricCoef14.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef14.Text = ""
			Me.lblFricCoef14.Top = 5F
			Me.lblFricCoef14.Width = 0.3125F
			Me.lblFricCoef15.Height = 0.125F
			Me.lblFricCoef15.HyperLink = Nothing
			Me.lblFricCoef15.Left = 3.317F
			Me.lblFricCoef15.Name = "lblFricCoef15"
			Me.lblFricCoef15.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef15.Text = ""
			Me.lblFricCoef15.Top = 5.124999F
			Me.lblFricCoef15.Width = 0.3125F
			Me.lblFricCoef16.Height = 0.125F
			Me.lblFricCoef16.HyperLink = Nothing
			Me.lblFricCoef16.Left = 3.317F
			Me.lblFricCoef16.Name = "lblFricCoef16"
			Me.lblFricCoef16.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef16.Text = ""
			Me.lblFricCoef16.Top = 5.249999F
			Me.lblFricCoef16.Width = 0.3125F
			Me.lblFricCoef17.Height = 0.125F
			Me.lblFricCoef17.HyperLink = Nothing
			Me.lblFricCoef17.Left = 3.317F
			Me.lblFricCoef17.Name = "lblFricCoef17"
			Me.lblFricCoef17.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef17.Text = ""
			Me.lblFricCoef17.Top = 5.374999F
			Me.lblFricCoef17.Width = 0.3125F
			Me.lblFricCoef18.Height = 0.125F
			Me.lblFricCoef18.HyperLink = Nothing
			Me.lblFricCoef18.Left = 3.317F
			Me.lblFricCoef18.Name = "lblFricCoef18"
			Me.lblFricCoef18.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef18.Text = ""
			Me.lblFricCoef18.Top = 5.499999F
			Me.lblFricCoef18.Width = 0.3125F
			Me.lblRodDiam19.Height = 0.125F
			Me.lblRodDiam19.HyperLink = Nothing
			Me.lblRodDiam19.Left = 0.061F
			Me.lblRodDiam19.Name = "lblRodDiam19"
			Me.lblRodDiam19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam19.Text = "Diam"
			Me.lblRodDiam19.Top = 5.624999F
			Me.lblRodDiam19.Width = 0.625F
			Me.lblRodGrade19.Height = 0.125F
			Me.lblRodGrade19.HyperLink = Nothing
			Me.lblRodGrade19.Left = 0.8170001F
			Me.lblRodGrade19.Name = "lblRodGrade19"
			Me.lblRodGrade19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade19.Text = "Grade"
			Me.lblRodGrade19.Top = 5.624999F
			Me.lblRodGrade19.Width = 0.98F
			Me.lblRodLength19.Height = 0.125F
			Me.lblRodLength19.HyperLink = Nothing
			Me.lblRodLength19.Left = 1.879F
			Me.lblRodLength19.Name = "lblRodLength19"
			Me.lblRodLength19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblRodLength19.Text = "Len"
			Me.lblRodLength19.Top = 5.624999F
			Me.lblRodLength19.Width = 0.4375F
			Me.lblRodTensileStrength19.Height = 0.125F
			Me.lblRodTensileStrength19.HyperLink = Nothing
			Me.lblRodTensileStrength19.Left = 2.442F
			Me.lblRodTensileStrength19.Name = "lblRodTensileStrength19"
			Me.lblRodTensileStrength19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength19.Text = "TS"
			Me.lblRodTensileStrength19.Top = 5.624999F
			Me.lblRodTensileStrength19.Width = 0.75F
			Me.lblFricCoef19.Height = 0.125F
			Me.lblFricCoef19.HyperLink = Nothing
			Me.lblFricCoef19.Left = 3.317F
			Me.lblFricCoef19.Name = "lblFricCoef19"
			Me.lblFricCoef19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef19.Text = ""
			Me.lblFricCoef19.Top = 5.624999F
			Me.lblFricCoef19.Width = 0.3125F
			Me.lblRodStress19.Height = 0.125F
			Me.lblRodStress19.HyperLink = Nothing
			Me.lblRodStress19.Left = 3.754F
			Me.lblRodStress19.Name = "lblRodStress19"
			Me.lblRodStress19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress19.Text = "Stress"
			Me.lblRodStress19.Top = 5.624999F
			Me.lblRodStress19.Width = 0.5F
			Me.lblRodTopMaxStress19.Height = 0.125F
			Me.lblRodTopMaxStress19.HyperLink = Nothing
			Me.lblRodTopMaxStress19.Left = 4.379002F
			Me.lblRodTopMaxStress19.Name = "lblRodTopMaxStress19"
			Me.lblRodTopMaxStress19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress19.Text = "Top Max"
			Me.lblRodTopMaxStress19.Top = 5.624999F
			Me.lblRodTopMaxStress19.Width = 0.75F
			Me.lblRodTopMinStress19.Height = 0.125F
			Me.lblRodTopMinStress19.HyperLink = Nothing
			Me.lblRodTopMinStress19.Left = 5.254002F
			Me.lblRodTopMinStress19.Name = "lblRodTopMinStress19"
			Me.lblRodTopMinStress19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress19.Text = "Top Min"
			Me.lblRodTopMinStress19.Top = 5.624999F
			Me.lblRodTopMinStress19.Width = 0.75F
			Me.lblRodBotMinStress19.Height = 0.125F
			Me.lblRodBotMinStress19.HyperLink = Nothing
			Me.lblRodBotMinStress19.Left = 6.129001F
			Me.lblRodBotMinStress19.Name = "lblRodBotMinStress19"
			Me.lblRodBotMinStress19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress19.Text = "Bot Min"
			Me.lblRodBotMinStress19.Top = 5.624999F
			Me.lblRodBotMinStress19.Width = 0.8125F
			Me.lblRodStressMethod19.Height = 0.125F
			Me.lblRodStressMethod19.HyperLink = Nothing
			Me.lblRodStressMethod19.Left = 7.067001F
			Me.lblRodStressMethod19.Name = "lblRodStressMethod19"
			Me.lblRodStressMethod19.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod19.Text = "Stress Meth"
			Me.lblRodStressMethod19.Top = 5.624999F
			Me.lblRodStressMethod19.Width = 0.8125F
			Me.lblRodDiam20.Height = 0.125F
			Me.lblRodDiam20.HyperLink = Nothing
			Me.lblRodDiam20.Left = 0.061F
			Me.lblRodDiam20.Name = "lblRodDiam20"
			Me.lblRodDiam20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam20.Text = "Diam"
			Me.lblRodDiam20.Top = 5.749999F
			Me.lblRodDiam20.Width = 0.625F
			Me.lblRodGrade20.Height = 0.125F
			Me.lblRodGrade20.HyperLink = Nothing
			Me.lblRodGrade20.Left = 0.8170001F
			Me.lblRodGrade20.Name = "lblRodGrade20"
			Me.lblRodGrade20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade20.Text = "Grade"
			Me.lblRodGrade20.Top = 5.749999F
			Me.lblRodGrade20.Width = 0.98F
			Me.lblRodLength20.Height = 0.125F
			Me.lblRodLength20.HyperLink = Nothing
			Me.lblRodLength20.Left = 1.879F
			Me.lblRodLength20.Name = "lblRodLength20"
			Me.lblRodLength20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: right; white-space: nowrap"
			Me.lblRodLength20.Text = "Len"
			Me.lblRodLength20.Top = 5.749999F
			Me.lblRodLength20.Width = 0.4375F
			Me.lblRodTensileStrength20.Height = 0.125F
			Me.lblRodTensileStrength20.HyperLink = Nothing
			Me.lblRodTensileStrength20.Left = 2.442F
			Me.lblRodTensileStrength20.Name = "lblRodTensileStrength20"
			Me.lblRodTensileStrength20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength20.Text = "TS"
			Me.lblRodTensileStrength20.Top = 5.749999F
			Me.lblRodTensileStrength20.Width = 0.75F
			Me.lblFricCoef20.Height = 0.125F
			Me.lblFricCoef20.HyperLink = Nothing
			Me.lblFricCoef20.Left = 3.317F
			Me.lblFricCoef20.Name = "lblFricCoef20"
			Me.lblFricCoef20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef20.Text = ""
			Me.lblFricCoef20.Top = 5.749999F
			Me.lblFricCoef20.Width = 0.3125F
			Me.lblRodStress20.Height = 0.125F
			Me.lblRodStress20.HyperLink = Nothing
			Me.lblRodStress20.Left = 3.754F
			Me.lblRodStress20.Name = "lblRodStress20"
			Me.lblRodStress20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress20.Text = "Stress"
			Me.lblRodStress20.Top = 5.749999F
			Me.lblRodStress20.Width = 0.5F
			Me.lblRodTopMaxStress20.Height = 0.125F
			Me.lblRodTopMaxStress20.HyperLink = Nothing
			Me.lblRodTopMaxStress20.Left = 4.379002F
			Me.lblRodTopMaxStress20.Name = "lblRodTopMaxStress20"
			Me.lblRodTopMaxStress20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress20.Text = "Top Max"
			Me.lblRodTopMaxStress20.Top = 5.749999F
			Me.lblRodTopMaxStress20.Width = 0.75F
			Me.lblRodTopMinStress20.Height = 0.125F
			Me.lblRodTopMinStress20.HyperLink = Nothing
			Me.lblRodTopMinStress20.Left = 5.254002F
			Me.lblRodTopMinStress20.Name = "lblRodTopMinStress20"
			Me.lblRodTopMinStress20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress20.Text = "Top Min"
			Me.lblRodTopMinStress20.Top = 5.749999F
			Me.lblRodTopMinStress20.Width = 0.75F
			Me.lblRodBotMinStress20.Height = 0.125F
			Me.lblRodBotMinStress20.HyperLink = Nothing
			Me.lblRodBotMinStress20.Left = 6.129001F
			Me.lblRodBotMinStress20.Name = "lblRodBotMinStress20"
			Me.lblRodBotMinStress20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress20.Text = "Bot Min"
			Me.lblRodBotMinStress20.Top = 5.749999F
			Me.lblRodBotMinStress20.Width = 0.8125F
			Me.lblRodStressMethod20.Height = 0.125F
			Me.lblRodStressMethod20.HyperLink = Nothing
			Me.lblRodStressMethod20.Left = 7.067001F
			Me.lblRodStressMethod20.Name = "lblRodStressMethod20"
			Me.lblRodStressMethod20.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod20.Text = "Stress Meth"
			Me.lblRodStressMethod20.Top = 5.749999F
			Me.lblRodStressMethod20.Width = 0.8125F
			Me.PageHeader.Controls.AddRange(New ARControl() { Me.lblAddr1, Me.lblAddr2, Me.imgLogo, Me.lblSecondCompanyContactName, Me.lblSecondCompanyPhone, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserDate, Me.Line1, Me.Line3, Me.lblAddress, Me.Line4, Me.Line5, Me.lblSecondCompanyName, Me.lblSecondCompanyWebsite })
			Me.PageHeader.Height = 1.728472F
			Me.PageHeader.Name = "PageHeader"
			Me.lblAddr1.Height = 0.1875F
			Me.lblAddr1.HyperLink = Nothing
			Me.lblAddr1.Left = 0.5F
			Me.lblAddr1.Name = "lblAddr1"
			Me.lblAddr1.Style = "font-size: 9pt; font-style: italic"
			Me.lblAddr1.Text = """Second Company Address 1"" goes here"
			Me.lblAddr1.Top = 1.1875F
			Me.lblAddr1.Width = 2.375F
			Me.lblAddr2.Height = 0.1875F
			Me.lblAddr2.HyperLink = Nothing
			Me.lblAddr2.Left = 0.5F
			Me.lblAddr2.Name = "lblAddr2"
			Me.lblAddr2.Style = "font-size: 9pt; font-style: italic"
			Me.lblAddr2.Text = """Second Company Address 2"" goes here"
			Me.lblAddr2.Top = 1.375F
			Me.lblAddr2.Width = 2.375F
			Me.imgLogo.BackColor = Color.FromArgb(255, 255, 255)
			Me.imgLogo.Height = 0.75F
			Me.imgLogo.HyperLink = Nothing
			Me.imgLogo.ImageData = CType(componentResourceManager.GetObject("imgLogo.ImageData"), Stream)
			Me.imgLogo.Left = 0.75F
			Me.imgLogo.LineColor = Color.Black
			Me.imgLogo.LineWeight = 1F
			Me.imgLogo.Name = "imgLogo"
			Me.imgLogo.SizeMode = SizeModes.Zoom
			Me.imgLogo.Top = 0.125F
			Me.imgLogo.Width = 0.9375F
			Me.lblSecondCompanyContactName.Height = 0.1875F
			Me.lblSecondCompanyContactName.HyperLink = Nothing
			Me.lblSecondCompanyContactName.Left = 2.9375F
			Me.lblSecondCompanyContactName.Name = "lblSecondCompanyContactName"
			Me.lblSecondCompanyContactName.Style = "font-size: 9pt; font-weight: normal"
			Me.lblSecondCompanyContactName.Text = """Second Company Contact Name"" goes here"
			Me.lblSecondCompanyContactName.Top = 1.1875F
			Me.lblSecondCompanyContactName.Width = 2.6875F
			Me.lblSecondCompanyPhone.Height = 0.1875F
			Me.lblSecondCompanyPhone.HyperLink = Nothing
			Me.lblSecondCompanyPhone.Left = 2.9375F
			Me.lblSecondCompanyPhone.Name = "lblSecondCompanyPhone"
			Me.lblSecondCompanyPhone.Style = "font-size: 9pt; font-weight: normal"
			Me.lblSecondCompanyPhone.Text = """Second Company Telephone No."" goes here"
			Me.lblSecondCompanyPhone.Top = 1.375F
			Me.lblSecondCompanyPhone.Width = 2.6875F
			Me.lblPage.Height = 0.17F
			Me.lblPage.HyperLink = Nothing
			Me.lblPage.Left = 5.6875F
			Me.lblPage.Name = "lblPage"
			Me.lblPage.Style = "font-family: Microsoft Sans Serif; font-size: 9pt"
			Me.lblPage.Text = "Page"
			Me.lblPage.Top = 1.1875F
			Me.lblPage.Width = 0.4375F
			Me.txtPage1.Height = 0.17F
			Me.txtPage1.Left = 6.125F
			Me.txtPage1.Name = "txtPage1"
			Me.txtPage1.Style = "font-family: Microsoft Sans Serif; font-size: 9pt"
			Me.txtPage1.Text = Nothing
			Me.txtPage1.Top = 1.1875F
			Me.txtPage1.Width = 0.1875F
			Me.lblOf.Height = 0.17F
			Me.lblOf.HyperLink = Nothing
			Me.lblOf.Left = 6.3125F
			Me.lblOf.Name = "lblOf"
			Me.lblOf.Style = "font-family: Microsoft Sans Serif; font-size: 9pt"
			Me.lblOf.Text = "of"
			Me.lblOf.Top = 1.1875F
			Me.lblOf.Width = 0.1875F
			Me.txtPage2.Height = 0.17F
			Me.txtPage2.Left = 6.5F
			Me.txtPage2.Name = "txtPage2"
			Me.txtPage2.Style = "font-family: Microsoft Sans Serif; font-size: 9pt"
			Me.txtPage2.Text = Nothing
			Me.txtPage2.Top = 1.1875F
			Me.txtPage2.Width = 0.1875F
			Me.lblUserDate.Height = 0.17F
			Me.lblUserDate.HyperLink = Nothing
			Me.lblUserDate.Left = 5.6875F
			Me.lblUserDate.Name = "lblUserDate"
			Me.lblUserDate.Style = "font-family: Microsoft Sans Serif; font-size: 9pt"
			Me.lblUserDate.Text = "Date: "
			Me.lblUserDate.Top = 1.375F
			Me.lblUserDate.Width = 1.5F
			Me.Line1.Height = 0F
			Me.Line1.Left = 0.6875F
			Me.Line1.LineColor = Color.FromArgb(128, 128, 128)
			Me.Line1.LineWeight = 1F
			Me.Line1.Name = "Line1"
			Me.Line1.Top = 1.6875F
			Me.Line1.Width = 6.6125F
			Me.Line1.X1 = 0.6875F
			Me.Line1.X2 = 7.3F
			Me.Line1.Y1 = 1.6875F
			Me.Line1.Y2 = 1.6875F
			Me.Line3.Height = 0F
			Me.Line3.Left = 0.6875F
			Me.Line3.LineColor = Color.FromArgb(128, 128, 128)
			Me.Line3.LineWeight = 1F
			Me.Line3.Name = "Line3"
			Me.Line3.Top = 0.0625F
			Me.Line3.Width = 6.6125F
			Me.Line3.X1 = 0.6875F
			Me.Line3.X2 = 7.3F
			Me.Line3.Y1 = 0.0625F
			Me.Line3.Y2 = 0.0625F
			Me.lblAddress.Height = 0.1875F
			Me.lblAddress.HyperLink = Nothing
			Me.lblAddress.Left = 0.5F
			Me.lblAddress.Name = "lblAddress"
			Me.lblAddress.Style = "font-size: 9pt"
			Me.lblAddress.Text = "Address:"
			Me.lblAddress.Top = 1F
			Me.lblAddress.Width = 2.375F
			Me.Line4.Height = 0F
			Me.Line4.Left = 1.75F
			Me.Line4.LineColor = Color.FromArgb(128, 128, 128)
			Me.Line4.LineWeight = 1F
			Me.Line4.Name = "Line4"
			Me.Line4.Top = 0.5F
			Me.Line4.Width = 5.55F
			Me.Line4.X1 = 1.75F
			Me.Line4.X2 = 7.3F
			Me.Line4.Y1 = 0.5F
			Me.Line4.Y2 = 0.5F
			Me.Line5.Height = 0F
			Me.Line5.Left = 0.6875F
			Me.Line5.LineColor = Color.FromArgb(128, 128, 128)
			Me.Line5.LineWeight = 1F
			Me.Line5.Name = "Line5"
			Me.Line5.Top = 0.9375F
			Me.Line5.Width = 6.6125F
			Me.Line5.X1 = 0.6875F
			Me.Line5.X2 = 7.3F
			Me.Line5.Y1 = 0.9375F
			Me.Line5.Y2 = 0.9375F
			Me.lblSecondCompanyName.Height = 0.375F
			Me.lblSecondCompanyName.HyperLink = Nothing
			Me.lblSecondCompanyName.Left = 1.7F
			Me.lblSecondCompanyName.Name = "lblSecondCompanyName"
			Me.lblSecondCompanyName.Style = "background-color: rgb(255,255,192); font-size: 12pt; font-weight: bold; text-align: center; vertical-align: middle"
			Me.lblSecondCompanyName.Text = "Setup/Defaults ""Second Company Name"" goes here"
			Me.lblSecondCompanyName.Top = 0.1F
			Me.lblSecondCompanyName.Width = 5.5625F
			Me.lblSecondCompanyWebsite.Height = 0.375F
			Me.lblSecondCompanyWebsite.HyperLink = Nothing
			Me.lblSecondCompanyWebsite.Left = 1.7F
			Me.lblSecondCompanyWebsite.Name = "lblSecondCompanyWebsite"
			Me.lblSecondCompanyWebsite.Style = "background-color: rgb(255,255,192); font-size: 10pt; font-weight: bold; text-align: center; vertical-align: middle"
			Me.lblSecondCompanyWebsite.Text = """Second Company Website"" goes here"
			Me.lblSecondCompanyWebsite.Top = 0.525F
			Me.lblSecondCompanyWebsite.Width = 5.5625F
			Me.PageFooter.Controls.AddRange(New ARControl() { Me.lblFootnote, Me.Line2 })
			Me.PageFooter.Height = 0.3333333F
			Me.PageFooter.Name = "PageFooter"
			Me.lblFootnote.Height = 0.25F
			Me.lblFootnote.HyperLink = Nothing
			Me.lblFootnote.Left = 0.625F
			Me.lblFootnote.Name = "lblFootnote"
			Me.lblFootnote.Style = "background-color: #FFFFC0; font-size: 12pt; font-weight: bold; text-align: center; vertical-align: middle"
			Me.lblFootnote.Text = "Setup/Defaults ""Second Company Cover Page Footnote"" goes here"
			Me.lblFootnote.Top = 0.0625F
			Me.lblFootnote.Width = 6.8125F
			Me.Line2.Height = 0F
			Me.Line2.Left = 0.625F
			Me.Line2.LineColor = Color.FromArgb(128, 128, 128)
			Me.Line2.LineWeight = 1F
			Me.Line2.Name = "Line2"
			Me.Line2.Top = 0F
			Me.Line2.Width = 6.825F
			Me.Line2.X1 = 0.625F
			Me.Line2.X2 = 7.45F
			Me.Line2.Y1 = 0F
			Me.Line2.Y2 = 0F
			Me.MasterReport = False
			Me.PageSettings.Margins.Bottom = 0.2F
			Me.PageSettings.Margins.Left = 0.25F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0.3F
			Me.PageSettings.PaperHeight = 11F
			Me.PageSettings.PaperWidth = 8.5F
			Me.PrintWidth = 7.947917F
			Me.Sections.Add(Me.PageHeader)
			Me.Sections.Add(Me.Detail)
			Me.Sections.Add(Me.PageFooter)
			Me.StyleSheet.Add(New StyleSheetRule(componentResourceManager.GetString("$this.StyleSheet"), "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-weight: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
			CType(Me.txtCustomerCompany, ISupportInitialize).EndInit()
			CType(Me.txtCustomerName, ISupportInitialize).EndInit()
			CType(Me.lblComments, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote5, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote4, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote3, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote2, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote1, ISupportInitialize).EndInit()
			CType(Me.lblRodStringDesign, ISupportInitialize).EndInit()
			CType(Me.lblRodDiamHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodDiamHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam1, ISupportInitialize).EndInit()
			CType(Me.lblRodGradeHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodLengthHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrengthHdrBot, ISupportInitialize).EndInit()
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
			CType(Me.lblRodTensileStrength1, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength2, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength3, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength4, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength5, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength6, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength7, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength8, ISupportInitialize).EndInit()
			CType(Me.lblRodStringResults, ISupportInitialize).EndInit()
			CType(Me.lblRodStressHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodStress1, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStressHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStressHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStressHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodStress2, ISupportInitialize).EndInit()
			CType(Me.lblRodStress3, ISupportInitialize).EndInit()
			CType(Me.lblRodStress4, ISupportInitialize).EndInit()
			CType(Me.lblRodStress5, ISupportInitialize).EndInit()
			CType(Me.lblRodStress6, ISupportInitialize).EndInit()
			CType(Me.lblRodStress7, ISupportInitialize).EndInit()
			CType(Me.lblRodStress8, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress1, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress2, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress3, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress4, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress5, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress6, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress7, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress8, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress1, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress2, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress3, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress4, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress5, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress6, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress7, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress8, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress1, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress2, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress3, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress4, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress5, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress6, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress7, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress8, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethodHdrBot, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod1, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod2, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod3, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod4, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod5, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod6, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod7, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod8, ISupportInitialize).EndInit()
			CType(Me.lblRodGradeHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStressHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStressHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethodHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStressHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodStressHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrengthHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodLengthHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef1, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef2, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef3, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef4, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef5, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef6, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef7, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef8, ISupportInitialize).EndInit()
			CType(Me.lblFric, ISupportInitialize).EndInit()
			CType(Me.lblCoeff, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam9, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade9, ISupportInitialize).EndInit()
			CType(Me.lblRodLength9, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength9, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef9, ISupportInitialize).EndInit()
			CType(Me.lblRodStress9, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress9, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress9, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress9, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod9, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam10, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade10, ISupportInitialize).EndInit()
			CType(Me.lblRodLength10, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength10, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef10, ISupportInitialize).EndInit()
			CType(Me.lblRodStress10, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress10, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress10, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress10, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod10, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength11, ISupportInitialize).EndInit()
			CType(Me.lblRodLength11, ISupportInitialize).EndInit()
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
			CType(Me.lblRodLength12, ISupportInitialize).EndInit()
			CType(Me.lblRodLength13, ISupportInitialize).EndInit()
			CType(Me.lblRodLength14, ISupportInitialize).EndInit()
			CType(Me.lblRodLength15, ISupportInitialize).EndInit()
			CType(Me.lblRodLength16, ISupportInitialize).EndInit()
			CType(Me.lblRodLength17, ISupportInitialize).EndInit()
			CType(Me.lblRodLength18, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength12, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength13, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength14, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength15, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength16, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength17, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength18, ISupportInitialize).EndInit()
			CType(Me.lblRodStress11, ISupportInitialize).EndInit()
			CType(Me.lblRodStress12, ISupportInitialize).EndInit()
			CType(Me.lblRodStress13, ISupportInitialize).EndInit()
			CType(Me.lblRodStress14, ISupportInitialize).EndInit()
			CType(Me.lblRodStress15, ISupportInitialize).EndInit()
			CType(Me.lblRodStress16, ISupportInitialize).EndInit()
			CType(Me.lblRodStress17, ISupportInitialize).EndInit()
			CType(Me.lblRodStress18, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress11, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress12, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress13, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress14, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress15, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress16, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress17, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress18, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress11, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress12, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress13, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress14, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress15, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress16, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress17, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress18, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress11, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress12, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress13, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress14, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress15, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress16, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress17, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress18, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod11, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod12, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod13, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod14, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod15, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod16, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod17, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod18, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef11, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef12, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef13, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef14, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef15, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef16, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef17, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef18, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam19, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade19, ISupportInitialize).EndInit()
			CType(Me.lblRodLength19, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength19, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef19, ISupportInitialize).EndInit()
			CType(Me.lblRodStress19, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress19, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress19, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress19, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod19, ISupportInitialize).EndInit()
			CType(Me.lblRodDiam20, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade20, ISupportInitialize).EndInit()
			CType(Me.lblRodLength20, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength20, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef20, ISupportInitialize).EndInit()
			CType(Me.lblRodStress20, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress20, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress20, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress20, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod20, ISupportInitialize).EndInit()
			CType(Me.lblAddr1, ISupportInitialize).EndInit()
			CType(Me.lblAddr2, ISupportInitialize).EndInit()
			CType(Me.imgLogo, ISupportInitialize).EndInit()
			CType(Me.lblSecondCompanyContactName, ISupportInitialize).EndInit()
			CType(Me.lblSecondCompanyPhone, ISupportInitialize).EndInit()
			CType(Me.lblPage, ISupportInitialize).EndInit()
			CType(Me.txtPage1, ISupportInitialize).EndInit()
			CType(Me.lblOf, ISupportInitialize).EndInit()
			CType(Me.txtPage2, ISupportInitialize).EndInit()
			CType(Me.lblUserDate, ISupportInitialize).EndInit()
			CType(Me.lblAddress, ISupportInitialize).EndInit()
			CType(Me.lblSecondCompanyName, ISupportInitialize).EndInit()
			CType(Me.lblSecondCompanyWebsite, ISupportInitialize).EndInit()
			CType(Me.lblFootnote, ISupportInitialize).EndInit()
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

		Private Sub rptCustomerCoverPage_ReportStart(sender As Object, e As EventArgs)
			Dim text As String = ""
			Try
				Me.rtbSecondCompanyComments.Text = ""
				Me.rtbSecondCompanyComments2.Text = ""
				Dim sDefaultName As String = "SecondCompanyName"
				Dim vNotPresentDefault As Object = ""
				Dim flag As Boolean = False
				Dim text2 As String = Conversions.ToString(ini.GetDefault(sDefaultName, vNotPresentDefault, flag))
				If text2 IsNot Nothing Then
					Me.lblSecondCompanyName.Text = text2
				End If
			Catch ex As Exception
			End Try
			Try
				Dim sDefaultName2 As String = "SecondCompanyContactName"
				Dim vNotPresentDefault2 As Object = ""
				Dim flag As Boolean = False
				Dim text3 As String = Conversions.ToString(ini.GetDefault(sDefaultName2, vNotPresentDefault2, flag))
				If text3 IsNot Nothing Then
					Me.lblSecondCompanyContactName.Text = text3
				End If
			Catch ex2 As Exception
			End Try
			Try
				Dim sDefaultName3 As String = "SecondCompanyPhone"
				Dim vNotPresentDefault3 As Object = ""
				Dim flag As Boolean = False
				Dim text4 As String = Conversions.ToString(ini.GetDefault(sDefaultName3, vNotPresentDefault3, flag))
				If text4 IsNot Nothing Then
					Me.lblSecondCompanyPhone.Text = text4
				End If
			Catch ex3 As Exception
			End Try
			Try
				Dim sDefaultName4 As String = "SecondCompanyAddress1"
				Dim vNotPresentDefault4 As Object = ""
				Dim flag As Boolean = False
				Dim text5 As String = Conversions.ToString(ini.GetDefault(sDefaultName4, vNotPresentDefault4, flag))
				If text5 IsNot Nothing Then
					Me.lblAddr1.Text = text5
				End If
			Catch ex4 As Exception
			End Try
			Try
				Dim sDefaultName5 As String = "SecondCompanyAddress2"
				Dim vNotPresentDefault5 As Object = ""
				Dim flag As Boolean = False
				Dim text6 As String = Conversions.ToString(ini.GetDefault(sDefaultName5, vNotPresentDefault5, flag))
				If text6 IsNot Nothing Then
					Me.lblAddr2.Text = text6
				End If
			Catch ex5 As Exception
			End Try
			Try
				Dim sDefaultName6 As String = "SecondCompanyWebsite"
				Dim vNotPresentDefault6 As Object = ""
				Dim flag As Boolean = False
				Dim text7 As String = Conversions.ToString(ini.GetDefault(sDefaultName6, vNotPresentDefault6, flag))
				If text7 IsNot Nothing Then
					Me.lblSecondCompanyWebsite.Text = text7
				End If
			Catch ex6 As Exception
			End Try
			Try
				Dim sDefaultName7 As String = "SecondCompanyFootnote"
				Dim vNotPresentDefault7 As Object = ""
				Dim flag As Boolean = False
				Dim text8 As String = Conversions.ToString(ini.GetDefault(sDefaultName7, vNotPresentDefault7, flag))
				If text8 IsNot Nothing Then
					Me.lblFootnote.Text = text8
				End If
			Catch ex7 As Exception
			End Try
			Try
				If Operators.CompareString(RSWIN_DESC.rst.CoverPageComment.Trim(), "", False) <> 0 Then
					Me.PopulateCoverPageComment()
				Else
					Me.SetRodStringGridVisible(False)
					Me.rtbSecondCompanyComments2.Visible = False
					Me.rtbSecondCompanyComments.Height = 6.8F
					Dim text9 As String = "SecondCompanyComments"
					Dim text10 As String = ""
					Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text9, text10, text, False)
					Dim text11 As String = text.Substring(0, regProfileString)
					If text11 IsNot Nothing Then
						If Operators.CompareString(text11, "", False) <> 0 Then
							Me.rtbSecondCompanyComments.Text = text11
						ElseIf RSWIN_DESC.rst.FileComment IsNot Nothing Then
							If Operators.CompareString(RSWIN_DESC.rst.FileComment.Trim(), "", False) <> 0 Then
								Me.rtbSecondCompanyComments.Text = RSWIN_DESC.rst.FileComment
							End If
						End If
					ElseIf RSWIN_DESC.rst.FileComment IsNot Nothing Then
						Me.rtbSecondCompanyComments.Text = RSWIN_DESC.rst.FileComment
					End If
				End If
			Catch ex8 As Exception
			End Try
			Try
				Dim sDefaultName8 As String = "SecondCompanyCustomerCompany"
				Dim vNotPresentDefault8 As Object = ""
				Dim flag As Boolean = False
				Dim text12 As String = Conversions.ToString(ini.GetDefault(sDefaultName8, vNotPresentDefault8, flag))
				If text12 IsNot Nothing Then
					Me.txtCustomerCompany.Text = "Customer Company: " + text12
				End If
			Catch ex9 As Exception
			End Try
			Try
				Dim sDefaultName9 As String = "SecondCompanyCustomerName"
				Dim vNotPresentDefault9 As Object = ""
				Dim flag As Boolean = False
				Dim text13 As String = Conversions.ToString(ini.GetDefault(sDefaultName9, vNotPresentDefault9, flag))
				If text13 IsNot Nothing Then
					Me.txtCustomerName.Text = "Customer: " + text13
				End If
			Catch ex10 As Exception
			End Try
			Try
				text = ""
				Dim text10 As String = "SecondCompanyIconFilename"
				Dim text9 As String = ""
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text10, text9, text, False)
				Dim text14 As String = text.Substring(0, regProfileString)
				If text14 IsNot Nothing AndAlso Operators.CompareString(text14.Trim(), "", False) <> 0 AndAlso FILEUTIL.FileExists(text14) Then
					Dim image As Bitmap = New Bitmap(text14)
					Me.imgLogo.Image = image
				End If
			Catch ex11 As Exception
			End Try
			Try
				If Me.m_ThisPageNumber >= 1 Then
					Me.txtPage1.Text = Me.m_ThisPageNumber.ToString()
					Me.txtPage2.Text = Me.m_TotalPageNumber.ToString()
				End If
				If Information.IsDate(RSWIN_DESC.rst.UserDate) Then
					Me.lblUserDate.Text = Me.sDate + Convert.ToDateTime(RSWIN_DESC.rst.UserDate).ToShortDateString()
				Else
					Me.lblUserDate.Text = Me.sDate + RSWIN_DESC.rst.UserDate
				End If
			Catch ex12 As Exception
			End Try
			Try
				If RSWIN_DESC.bIntVersion Then
					If RSWIN_DESC.bWriteResXFile Then
						Util.OpenResourceWriter("rptCoverPage")
						Me.WriteControlStrings()
						Util.CloseResourceWriter()
					End If
					If RSWIN_DESC.bReadResXFile Then
						Me.ReadReportControlStrings()
					End If
				End If
			Catch ex13 As Exception
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

		Private Sub ReadReportControlStrings()
			Dim sPrefix As String = "rptcalcresults-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
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
						Debug.WriteLine(ex.Message)
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
			sPrefix = "rptcoverpage-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
			Try
				Dim num7 As Integer = 0
				Dim num8 As Integer = Me.PageHeader.Controls.Count - 1
				For i As Integer = num7 To num8
					Try
						Debug.WriteLine(Me.PageHeader.Controls(i).Name)
						If Me.PageHeader.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.PageHeader.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						ElseIf Me.PageHeader.Controls(i).[GetType]() Is GetType(TextBox) Then
							Dim textBox As TextBox = CType(Me.PageHeader.Controls(i), TextBox)
							Me.AssignValueToReportControl(sPrefix, textBox)
						End If
					Catch ex5 As Exception
					End Try
				Next
				Dim num9 As Integer = 0
				Dim num10 As Integer = Me.PageFooter.Controls.Count - 1
				For i As Integer = num9 To num10
					Try
						Debug.WriteLine(Me.PageFooter.Controls(i).Name)
						If Me.PageFooter.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.PageFooter.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						ElseIf Me.PageHeader.Controls(i).[GetType]() Is GetType(TextBox) Then
							Dim textBox As TextBox = CType(Me.PageHeader.Controls(i), TextBox)
							Me.AssignValueToReportControl(sPrefix, textBox)
						End If
					Catch ex6 As Exception
					End Try
				Next
				Dim num11 As Integer = 0
				Dim num12 As Integer = Me.Detail.Controls.Count - 1
				For i As Integer = num11 To num12
					Try
						Debug.WriteLine(Me.Detail.Controls(i).Name)
						If Me.Detail.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.Detail.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						ElseIf Me.Detail.Controls(i).[GetType]() Is GetType(TextBox) Then
							Dim textBox As TextBox = CType(Me.Detail.Controls(i), TextBox)
							Me.AssignValueToReportControl(sPrefix, textBox)
						End If
					Catch ex7 As Exception
					End Try
				Next
			Catch ex8 As Exception
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

		Public Sub AssignValueToReportControl(sPrefix As String, ByRef objControl As TextBox)
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

		Private Function GetRodStringDesign() As String
			' The following expression was wrapped in a checked-statement
			Dim result As String
			Try
				Dim text As String = ""
				Dim text2 As String = ""
				Dim str As String = "Rod String Design:"
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("(", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, RSWIN_DESC.inch.Trim(), RSWIN_DESC.mm.Trim())), ")"))
				Dim text4 As String = "Diam "
				Dim text5 As String = "Rod Grade"
				Dim text6 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("(", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, RSWIN_DESC.ft.Trim(), RSWIN_DESC.m.Trim())), ")"))
				Dim text7 As String = "Length "
				Dim text8 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("(", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, RSWIN_DESC.psi.Trim(), RSWIN_DESC.kPa.Trim())), ")"))
				Dim text9 As String = "Stress"
				Dim text10 As String = "Load %"
				Dim text11 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Stress (", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, RSWIN_DESC.psi.Trim(), RSWIN_DESC.kPa.Trim())), ")"))
				Dim text12 As String = "Top Max "
				Dim text13 As String = "Top Min "
				Dim text14 As String = "Bot Min "
				Dim text15 As String = "Stress"
				Dim text16 As String = "Method"
				Dim text17 As String = "           "
				Try
					Dim flag As Boolean = True
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						If Not RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(i).Grade) Then
							flag = False
							Exit For
						End If
					Next
					text = " " & vbCrLf
					text = text + str + vbCrLf & vbCrLf
					text = String.Concat(New String() { text, text4.PadRight(8), vbTab, text5.PadRight(12), vbTab, text7.PadRight(10), vbTab, text9.PadRight(12), vbTab, text12.PadRight(12), vbTab, text13.PadRight(12), vbTab, text14.PadRight(12), vbTab, text15.PadRight(12), vbCrLf })
					text = String.Concat(New String() { text, text3.PadRight(8), vbTab, text17.PadRight(12), vbTab, text6.PadRight(10), vbTab, text10.PadRight(12), vbTab, text11.PadRight(12), vbTab, text11.PadRight(12), vbTab, text11.PadRight(12), vbTab, text16.PadRight(12), vbCrLf })
					Dim num2 As Integer = 1
					Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num2 To numRods2

							Dim text18 As String
							Dim text19 As String
							If RODUTIL.IsCorodH(RSWIN_DESC.rst.Sections(i).Grade) Then
								text18 = "N/A"
							ElseIf RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(i).Grade) Then
								Dim num3 As Single = RSWIN_DESC.rst.Sections(i).Diameter * 16F
								text19 = "0"
								text18 = Util.Format(num3, text19) + "/16"
								If Not flag And RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									text18 += """"
								End If
							ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Dim num3 As Single = RSWIN_DESC.rst.Sections(i).Diameter * RSWIN_DESC.IN__MM
								text19 = "0.0"
								text18 = Util.Format(num3, text19)
							Else
								Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
								Dim num4 As Integer = i
								text19 = "0.####"
								text18 = Util.Format(sections(num4).Diameter, text19)
							End If
							Dim grade As Short = RSWIN_DESC.rst.Sections(i).Grade
							If CUSTOMRG.IsOtherSteel(CInt(grade)) Or CUSTOMRG.IsOtherFG(CInt(grade)) Or CUSTOMRG.IsOtherSinkerBar(CInt(grade)) Then
								If CUSTOMRG.IsOtherFG(CInt(grade)) Then
									Dim iRodGrade As Integer = CInt(grade)
									Dim num3 As Single = 0F
									text2 = RODUTIL.GetOtherFG(iRodGrade, num3)
								ElseIf CUSTOMRG.IsOtherSinkerBar(CInt(grade)) Then
									Dim iRodGrade2 As Integer = CInt(grade)
									Dim num3 As Single = 0F
									text2 = RODUTIL.GetOtherSinkerbar(iRodGrade2, num3)
								ElseIf CUSTOMRG.IsOtherSteel(CInt(grade)) Then
									Dim iRodGrade3 As Integer = CInt(grade)
									Dim num3 As Single = 0F
									text2 = RODUTIL.GetOtherSteel(iRodGrade3, num3)
								End If
							ElseIf RODUTIL.IsCorodH(grade) Then
								If CDbl(RSWIN_DESC.rst.Sections(i).Area) < 0.7 Then
									text2 += " 682"
								Else
									text2 += " 757"
								End If
							ElseIf RODUTIL.IsNoNeck(grade) Then
								Select Case grade
									Case 8197S
										text2 = RODUTIL.RodGrade(8193)
									Case 8198S
										text2 = RODUTIL.RodGrade(8194)
									Case 8199S
										text2 = RODUTIL.RodGrade(8195)
									Case 8200S
										text2 = RODUTIL.RodGrade(8196)
								End Select
							Else
								text2 = RODUTIL.RodGrade(grade)
							End If
							Dim text20 As String
							If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
								Dim sections2 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
								Dim num5 As Integer = i
								text19 = "0"
								text20 = Util.Format(sections2(num5).length, text19)
							Else
								Dim num3 As Single = RSWIN_DESC.rst.Sections(i).length * RSWIN_DESC.FT__M
								text19 = "0"
								text20 = Util.Format(num3, text19)
							End If
							Dim tensileStrength As String = Me.GetTensileStrength(i)
							Dim stressL As Single() = RSWIN_DESC.rst.StressL
							Dim num6 As Integer = i
							text19 = "###%"
							Dim text21 As String = Util.Format(stressL(num6), text19)
							Dim text22 As String
							If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(i) * RSWIN_DESC.PSI__KPA
								text19 = "0"
								text22 = Util.Format(num3, text19)
							Else
								Dim maxStressTop As Single() = RSWIN_DESC.rst.maxStressTop
								Dim num7 As Integer = i
								text19 = "0"
								text22 = Util.Format(maxStressTop(num7), text19)
							End If
							Dim text23 As String
							If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Dim num3 As Single = RSWIN_DESC.rst.minStressTop(i) * RSWIN_DESC.PSI__KPA
								text19 = "0"
								text23 = Util.Format(num3, text19)
							Else
								Dim minStressTop As Single() = RSWIN_DESC.rst.minStressTop
								Dim num8 As Integer = i
								text19 = "0"
								text23 = Util.Format(minStressTop(num8), text19)
							End If
							Dim text24 As String
							If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Dim num3 As Single = RSWIN_DESC.rst.minStressBot(i) * RSWIN_DESC.PSI__KPA
								text19 = "0"
								text24 = Util.Format(num3, text19)
							Else
								Dim minStressBot As Single() = RSWIN_DESC.rst.minStressBot
								Dim num9 As Integer = i
								text19 = "0"
								text24 = Util.Format(minStressBot(num9), text19)
							End If
							Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(i))
								Case 0
									text16 = "API MG"
								Case 1
									text16 = "API MG T/2.8"
								Case 2
									text16 = "API MG T/3"
								Case 3
									text16 = "WFT EL"
								Case 4
									text16 = "MGS"
								Case 5
									text16 = "Fiberflex"
								Case 6
									text16 = "Norris FG"
								Case 7
									text16 = "Durarod"
								Case 8
									text16 = "RR Amoco"
								Case 9
									text16 = "Fiberod"
								Case 10
									text16 = "Tenaris"
								Case 11
									text16 = "Fiberod CCR"
								Case 12
									text16 = "Tenaris PC"
								Case 13
									text16 = "FlexRod"
								Case 16
									text16 = "Tenaris PC"
							End Select
							text = String.Concat(New String() { text, text18.PadRight(8), vbTab, text2.PadRight(12), vbTab, text20.PadRight(10), vbTab, text21.PadRight(12), vbTab, text22.PadRight(12), vbTab, text23.PadRight(12), vbTab, text24.PadRight(12), vbTab, text16, vbCrLf })

					Next
					text += " " & vbCrLf
				Catch ex As Exception
				End Try
				result = text
			Catch ex2 As Exception
				result = ""
			End Try
			Return result
		End Function

		Private Sub ShowRodBotMinStressList(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 10L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels1.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot As Single() = RSWIN_DESC.rst.minStressBot
									Dim num4 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot(num4), text)
								End If
								avLabels1.Text = text2
								avLabels1.ForeColor = Color.Black
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels2.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot2 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num5 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot2(num5), text)
								End If
								avLabels2.Text = text2
								avLabels2.ForeColor = Color.Black
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels3.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot3 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num6 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot3(num6), text)
								End If
								avLabels3.Text = text2
								avLabels3.ForeColor = Color.Black
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels4.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot4 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num7 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot4(num7), text)
								End If
								avLabels4.Text = text2
								avLabels4.ForeColor = Color.Black
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels5.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot5 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num8 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot5(num8), text)
								End If
								avLabels5.Text = text2
								avLabels5.ForeColor = Color.Black
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels6.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot6 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num9 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot6(num9), text)
								End If
								avLabels6.Text = text2
								avLabels6.ForeColor = Color.Black
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels7.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot7 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num10 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot7(num10), text)
								End If
								avLabels7.Text = text2
								avLabels7.ForeColor = Color.Black
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels8.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot8 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num11 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot8(num11), text)
								End If
								avLabels8.Text = text2
								avLabels8.ForeColor = Color.Black
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels9.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot9 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num12 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot9(num12), text)
								End If
								avLabels9.Text = text2
								avLabels9.ForeColor = Color.Black
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels10.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot10 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num13 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot10(num13), text)
								End If
								avLabels10.Text = text2
								avLabels10.ForeColor = Color.Black
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
			If Not RSWIN_DESC.rst.gbIncludeBuoyancy Then
				If(RODUTIL.IsSinkerBar(CInt(RSWIN_DESC.rst.NumRods)) Or If((-If((CUSTOMRG.IsOtherSinkerBar(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) > False), 1, 0)), 1, 0)) <> 0 Then
					' The following expression was wrapped in a checked-statement
					If RSWIN_DESC.rst.NumRods > 1S Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 And RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S))) * RSWIN_DESC.PSI__KPA < 0F Then
							Me.SetLabelColorMinStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
						ElseIf RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S))) < 0F Then
							Me.SetLabelColorMinStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
						End If
					End If
				ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					If RSWIN_DESC.rst.minStressBot(CInt(RSWIN_DESC.rst.NumRods)) * RSWIN_DESC.PSI__KPA < 0F Then
						Me.SetLabelColorMinStressBot(CInt(RSWIN_DESC.rst.NumRods))
					End If
				ElseIf RSWIN_DESC.rst.minStressBot(CInt(RSWIN_DESC.rst.NumRods)) <> 0F Then
					Me.SetLabelColorMinStressBot(CInt(RSWIN_DESC.rst.NumRods))
				End If
				Return
			End If
		End Sub

		Private Sub ShowRodDiameterList2(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label, ByRef avLabels11 As Label, ByRef avLabels12 As Label, ByRef avLabels13 As Label, ByRef avLabels14 As Label, ByRef avLabels15 As Label, ByRef avLabels16 As Label, ByRef avLabels17 As Label, ByRef avLabels18 As Label, ByRef avLabels19 As Label, ByRef avLabels20 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 20L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels1.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels1)
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels2)
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels3)
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels4)
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels5)
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels6)
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels7)
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels8)
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels9)
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels10)
							End If
						Case 10
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels11.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels11)
							End If
						Case 11
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels12.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels12)
							End If
						Case 12
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels13.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels13)
							End If
						Case 13
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels14.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels14)
							End If
						Case 14
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels15.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels15)
							End If
						Case 15
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels16.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels16)
							End If
						Case 16
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels17.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels17)
							End If
						Case 17
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels18.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels18)
							End If
						Case 18
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels19.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels19)
							End If
						Case 19
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
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

		Private Sub ShowRodDiameterList(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 10L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels1.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels1)
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels2)
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels3)
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels4)
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels5)
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels6)
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels7)
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels8)
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels9)
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								Me.SetRodGradeList(CInt(num), avLabels10)
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub SetRodGradeList(I As Integer, ByRef avLabel As Label)
			Dim quiet As Object = True
			Dim grade As Object = RSWIN_DESC.rst.Sections(I).Grade
			Dim diameter As Object = RSWIN_DESC.rst.Sections(I).Diameter
			Dim flag As Boolean
			Dim obj As Object = flag
			Dim flag2 As Boolean
			Dim obj2 As Object = flag2
			Dim obj3 As Object = Nothing
			Dim flag3 As Boolean
			Dim obj4 As Object = flag3
			RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj, obj2, obj3, obj4, I)
			flag3 = Conversions.ToBoolean(obj4)
			flag2 = Conversions.ToBoolean(obj2)
			flag = Conversions.ToBoolean(obj)
			Dim str As String
			If Not flag Then
				str = "*"
				Me.mbMsgFullOKNeeded = True
			ElseIf flag2 Then
				str = "+"
				Me.mbMsgSlimNeededNeeded = True
			Else
				str = " "
			End If
			If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(I).Grade) Then
				str += " "
			ElseIf RODUTIL.IsNoNeck(RSWIN_DESC.rst.Sections(I).Grade) Then
				str += "#"
				Me.mbMsgNoNeckNeeded = True
			Else
				Dim diameter2 As Single = RSWIN_DESC.rst.Sections(I).Diameter
				If diameter2 >= 1.374F Then
					str += "@"
					Me.mbMsgElevatorNeck1_0Needed = True
				ElseIf RODUTIL.IsSinkerBar(I) <> 0 Then
					str += "@"
					Me.mbMsgElevatorNeck1_0Needed = True
				Else
					str += " "
				End If
			End If
			Dim text As String
			If RODUTIL.IsCorodH(RSWIN_DESC.rst.Sections(I).Grade) Then
				text = Me.sNA
			ElseIf RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(I).Grade) Then
				Dim num As Single = RSWIN_DESC.rst.Sections(I).Diameter * 16F
				Dim text2 As String = "0"
				text = Util.Format(num, text2) + "/16"
				If Not Me.mbCorodSEString And RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					text += """"
				End If
			ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				Dim num As Single = RSWIN_DESC.rst.Sections(I).Diameter * RSWIN_DESC.IN__MM
				Dim text2 As String = "0.0"
				text = Util.Format(num, text2)
			Else
				Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
				Dim text2 As String = "0.####"
				text = Util.Format(sections(I).Diameter, text2)
			End If
			avLabel.Text = str + " " + text
		End Sub

		Private Sub ShowRodGradeList2(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label, ByRef avLabels11 As Label, ByRef avLabels12 As Label, ByRef avLabels13 As Label, ByRef avLabels14 As Label, ByRef avLabels15 As Label, ByRef avLabels16 As Label, ByRef avLabels17 As Label, ByRef avLabels18 As Label, ByRef avLabels19 As Label, ByRef avLabels20 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 20L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels1.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels1.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels1.Top
								Me.m_LastHeight = avLabels1.Height
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels2.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels2.Top
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels3.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels3.Top
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels4.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels4.Top
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels5.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels5.Top
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels6.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels6.Top
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels7.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels7.Top
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels8.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels8.Top
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels9.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels9.Top
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels10.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels10.Top
							End If
						Case 10
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels11.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels11.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels11.Top
								Me.m_LastHeight = avLabels11.Height
							End If
						Case 11
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels12.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels12.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels12.Top
							End If
						Case 12
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels13.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels13.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels13.Top
							End If
						Case 13
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels14.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels14.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels14.Top
							End If
						Case 14
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels15.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels15.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels15.Top
							End If
						Case 15
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels16.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels16.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels16.Top
							End If
						Case 16
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels17.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels17.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels17.Top
							End If
						Case 17
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels18.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels18.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels18.Top
							End If
						Case 18
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels19.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels19.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels19.Top
							End If
						Case 19
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels20.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels20.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels20.Top
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodGradeList(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 10L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels1.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels1.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels1.Top
								Me.m_LastHeight = avLabels1.Height
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels2.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels2.Top
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels3.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels3.Top
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels4.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels4.Top
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels5.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels5.Top
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels6.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels6.Top
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels7.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels7.Top
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels8.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels8.Top
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels9.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels9.Top
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels10.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels10.Top
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodLengthList2(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label, ByRef avLabels11 As Label, ByRef avLabels12 As Label, ByRef avLabels13 As Label, ByRef avLabels14 As Label, ByRef avLabels15 As Label, ByRef avLabels16 As Label, ByRef avLabels17 As Label, ByRef avLabels18 As Label, ByRef avLabels19 As Label, ByRef avLabels20 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 20L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels1.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num3 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections(num3).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels1.Text = text2
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections2 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num5 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections2(num5).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels2.Text = text2
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections3 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num6 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections3(num6).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels3.Text = text2
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections4 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num7 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections4(num7).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels4.Text = text2
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections5 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num8 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections5(num8).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels5.Text = text2
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections6 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num9 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections6(num9).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels6.Text = text2
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections7 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num10 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections7(num10).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels7.Text = text2
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections8 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num11 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections8(num11).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels8.Text = text2
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections9 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num12 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections9(num12).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels9.Text = text2
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections10 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num13 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections10(num13).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels10.Text = text2
							End If
						Case 10
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels11.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections11 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num14 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections11(num14).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels11.Text = text2
							End If
						Case 11
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels12.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections12 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num15 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections12(num15).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels12.Text = text2
							End If
						Case 12
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels13.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections13 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num16 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections13(num16).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels13.Text = text2
							End If
						Case 13
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels14.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections14 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num17 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections14(num17).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels14.Text = text2
							End If
						Case 14
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels15.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections15 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num18 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections15(num18).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels15.Text = text2
							End If
						Case 15
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels16.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections16 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num19 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections16(num19).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels16.Text = text2
							End If
						Case 16
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels17.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections17 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num20 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections17(num20).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels17.Text = text2
							End If
						Case 17
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels18.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections18 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num21 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections18(num21).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels18.Text = text2
							End If
						Case 18
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels19.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections19 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num22 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections19(num22).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels19.Text = text2
							End If
						Case 19
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels20.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections20 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num23 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections20(num23).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels20.Text = text2
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodLengthList(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 10L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels1.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num3 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections(num3).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels1.Text = text2
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections2 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num5 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections2(num5).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels2.Text = text2
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections3 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num6 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections3(num6).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels3.Text = text2
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections4 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num7 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections4(num7).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels4.Text = text2
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections5 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num8 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections5(num8).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels5.Text = text2
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections6 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num9 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections6(num9).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels6.Text = text2
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections7 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num10 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections7(num10).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels7.Text = text2
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections8 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num11 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections8(num11).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels8.Text = text2
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections9 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num12 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections9(num12).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels9.Text = text2
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim sections10 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num13 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(sections10(num13).length, text)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num4 As Single = RSWIN_DESC.rst.Sections(CInt(num)).length * RSWIN_DESC.FT__M
									Dim text As String = "0"
									text2 = Util.Format(num4, text)
								End If
								avLabels10.Text = text2
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Function GetTensileStrength(I As Integer) As String
			Dim result As String
			Try
				If RSWIN_DESC.rst.Sections(I).TensileStrength = 0F Then
					RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(I))
				End If
				Dim text2 As String
				If RODUTIL.IsAPI(CInt(RSWIN_DESC.rst.Sections(I).Grade), RSWIN_DESC.rst.Sections(I).RodType) Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						Dim num As Single = RSWIN_DESC.rst.Sections(I).TensileStrength * RSWIN_DESC.PSI__KPA
						Dim text As String = "0"
						text2 = Util.Format(num, text)
					Else
						Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
						Dim text As String = "0"
						text2 = Util.Format(sections(I).TensileStrength, text)
					End If
				ElseIf RSWIN_DESC.rst.Sections(I).TensileStrength = 0F Then
					text2 = Me.sNA
				ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					Dim num As Single = RSWIN_DESC.rst.Sections(I).TensileStrength * RSWIN_DESC.PSI__KPA
					Dim text As String = "0"
					text2 = Util.Format(num, text)
				Else
					Dim sections2 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
					Dim text As String = "0"
					text2 = Util.Format(sections2(I).TensileStrength, text)
				End If
				If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(I).Grade) Or RSWIN_DESC.rst.Sections(I).Grade = 4100S Then
					text2 = Me.sNA
				End If
				result = text2
			Catch ex As Exception
				result = Me.sNA
			End Try
			Return result
		End Function

		Private Sub ShowRodTensileStrengthList(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 10L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels1.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels1.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels2.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels3.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels4.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels5.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels6.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels7.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels8.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels9.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels10.Text = Me.GetTensileStrength(CInt(num))
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodStressList2(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label, ByRef avLabels11 As Label, ByRef avLabels12 As Label, ByRef avLabels13 As Label, ByRef avLabels14 As Label, ByRef avLabels15 As Label, ByRef avLabels16 As Label, ByRef avLabels17 As Label, ByRef avLabels18 As Label, ByRef avLabels19 As Label, ByRef avLabels20 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 20L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels1.Visible = False
							Else
								Dim label As Label = avLabels1
								Dim stressL As Single() = RSWIN_DESC.rst.StressL
								Dim num3 As Integer = CInt(num)
								Dim text As String = "###%"
								label.Text = Util.Format(stressL(num3), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels1, "###%")
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels2.Visible = False
							Else
								Dim label2 As Label = avLabels2
								Dim stressL2 As Single() = RSWIN_DESC.rst.StressL
								Dim num4 As Integer = CInt(num)
								Dim text As String = "###%"
								label2.Text = Util.Format(stressL2(num4), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels2, "###%")
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels3.Visible = False
							Else
								Dim label3 As Label = avLabels3
								Dim stressL3 As Single() = RSWIN_DESC.rst.StressL
								Dim num5 As Integer = CInt(num)
								Dim text As String = "###%"
								label3.Text = Util.Format(stressL3(num5), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels3, "###%")
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels4.Visible = False
							Else
								Dim label4 As Label = avLabels4
								Dim stressL4 As Single() = RSWIN_DESC.rst.StressL
								Dim num6 As Integer = CInt(num)
								Dim text As String = "###%"
								label4.Text = Util.Format(stressL4(num6), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels4, "###%")
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels5.Visible = False
							Else
								Dim label5 As Label = avLabels5
								Dim stressL5 As Single() = RSWIN_DESC.rst.StressL
								Dim num7 As Integer = CInt(num)
								Dim text As String = "###%"
								label5.Text = Util.Format(stressL5(num7), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels5, "###%")
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels6.Visible = False
							Else
								Dim label6 As Label = avLabels6
								Dim stressL6 As Single() = RSWIN_DESC.rst.StressL
								Dim num8 As Integer = CInt(num)
								Dim text As String = "###%"
								label6.Text = Util.Format(stressL6(num8), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels6, "###%")
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels7.Visible = False
							Else
								Dim label7 As Label = avLabels7
								Dim stressL7 As Single() = RSWIN_DESC.rst.StressL
								Dim num9 As Integer = CInt(num)
								Dim text As String = "###%"
								label7.Text = Util.Format(stressL7(num9), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels7, "###%")
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels8.Visible = False
							Else
								Dim label8 As Label = avLabels8
								Dim stressL8 As Single() = RSWIN_DESC.rst.StressL
								Dim num10 As Integer = CInt(num)
								Dim text As String = "###%"
								label8.Text = Util.Format(stressL8(num10), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels8, "###%")
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels9.Visible = False
							Else
								Dim label9 As Label = avLabels9
								Dim stressL9 As Single() = RSWIN_DESC.rst.StressL
								Dim num11 As Integer = CInt(num)
								Dim text As String = "###%"
								label9.Text = Util.Format(stressL9(num11), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels9, "###%")
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels10.Visible = False
							Else
								Dim label10 As Label = avLabels10
								Dim stressL10 As Single() = RSWIN_DESC.rst.StressL
								Dim num12 As Integer = CInt(num)
								Dim text As String = "###%"
								label10.Text = Util.Format(stressL10(num12), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels10, "###%")
							End If
						Case 10
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels11.Visible = False
							Else
								Dim label11 As Label = avLabels11
								Dim stressL11 As Single() = RSWIN_DESC.rst.StressL
								Dim num13 As Integer = CInt(num)
								Dim text As String = "###%"
								label11.Text = Util.Format(stressL11(num13), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels11, "###%")
							End If
						Case 11
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels12.Visible = False
							Else
								Dim label12 As Label = avLabels12
								Dim stressL12 As Single() = RSWIN_DESC.rst.StressL
								Dim num14 As Integer = CInt(num)
								Dim text As String = "###%"
								label12.Text = Util.Format(stressL12(num14), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels12, "###%")
							End If
						Case 12
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels13.Visible = False
							Else
								Dim label13 As Label = avLabels13
								Dim stressL13 As Single() = RSWIN_DESC.rst.StressL
								Dim num15 As Integer = CInt(num)
								Dim text As String = "###%"
								label13.Text = Util.Format(stressL13(num15), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels13, "###%")
							End If
						Case 13
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels14.Visible = False
							Else
								Dim label14 As Label = avLabels14
								Dim stressL14 As Single() = RSWIN_DESC.rst.StressL
								Dim num16 As Integer = CInt(num)
								Dim text As String = "###%"
								label14.Text = Util.Format(stressL14(num16), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels14, "###%")
							End If
						Case 14
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels15.Visible = False
							Else
								Dim label15 As Label = avLabels15
								Dim stressL15 As Single() = RSWIN_DESC.rst.StressL
								Dim num17 As Integer = CInt(num)
								Dim text As String = "###%"
								label15.Text = Util.Format(stressL15(num17), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels15, "###%")
							End If
						Case 15
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels16.Visible = False
							Else
								Dim label16 As Label = avLabels16
								Dim stressL16 As Single() = RSWIN_DESC.rst.StressL
								Dim num18 As Integer = CInt(num)
								Dim text As String = "###%"
								label16.Text = Util.Format(stressL16(num18), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels16, "###%")
							End If
						Case 16
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels17.Visible = False
							Else
								Dim label17 As Label = avLabels17
								Dim stressL17 As Single() = RSWIN_DESC.rst.StressL
								Dim num19 As Integer = CInt(num)
								Dim text As String = "###%"
								label17.Text = Util.Format(stressL17(num19), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels17, "###%")
							End If
						Case 17
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels18.Visible = False
							Else
								Dim label18 As Label = avLabels18
								Dim stressL18 As Single() = RSWIN_DESC.rst.StressL
								Dim num20 As Integer = CInt(num)
								Dim text As String = "###%"
								label18.Text = Util.Format(stressL18(num20), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels18, "###%")
							End If
						Case 18
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels19.Visible = False
							Else
								Dim label19 As Label = avLabels19
								Dim stressL19 As Single() = RSWIN_DESC.rst.StressL
								Dim num21 As Integer = CInt(num)
								Dim text As String = "###%"
								label19.Text = Util.Format(stressL19(num21), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels19, "###%")
							End If
						Case 19
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels20.Visible = False
							Else
								Dim label20 As Label = avLabels20
								Dim stressL20 As Single() = RSWIN_DESC.rst.StressL
								Dim num22 As Integer = CInt(num)
								Dim text As String = "###%"
								label20.Text = Util.Format(stressL20(num22), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels20, "###%")
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodStressList(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 10L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels1.Visible = False
							Else
								Dim label As Label = avLabels1
								Dim stressL As Single() = RSWIN_DESC.rst.StressL
								Dim num3 As Integer = CInt(num)
								Dim text As String = "###%"
								label.Text = Util.Format(stressL(num3), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels1, "###%")
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels2.Visible = False
							Else
								Dim label2 As Label = avLabels2
								Dim stressL2 As Single() = RSWIN_DESC.rst.StressL
								Dim num4 As Integer = CInt(num)
								Dim text As String = "###%"
								label2.Text = Util.Format(stressL2(num4), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels2, "###%")
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels3.Visible = False
							Else
								Dim label3 As Label = avLabels3
								Dim stressL3 As Single() = RSWIN_DESC.rst.StressL
								Dim num5 As Integer = CInt(num)
								Dim text As String = "###%"
								label3.Text = Util.Format(stressL3(num5), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels3, "###%")
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels4.Visible = False
							Else
								Dim label4 As Label = avLabels4
								Dim stressL4 As Single() = RSWIN_DESC.rst.StressL
								Dim num6 As Integer = CInt(num)
								Dim text As String = "###%"
								label4.Text = Util.Format(stressL4(num6), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels4, "###%")
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels5.Visible = False
							Else
								Dim label5 As Label = avLabels5
								Dim stressL5 As Single() = RSWIN_DESC.rst.StressL
								Dim num7 As Integer = CInt(num)
								Dim text As String = "###%"
								label5.Text = Util.Format(stressL5(num7), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels5, "###%")
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels6.Visible = False
							Else
								Dim label6 As Label = avLabels6
								Dim stressL6 As Single() = RSWIN_DESC.rst.StressL
								Dim num8 As Integer = CInt(num)
								Dim text As String = "###%"
								label6.Text = Util.Format(stressL6(num8), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels6, "###%")
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels7.Visible = False
							Else
								Dim label7 As Label = avLabels7
								Dim stressL7 As Single() = RSWIN_DESC.rst.StressL
								Dim num9 As Integer = CInt(num)
								Dim text As String = "###%"
								label7.Text = Util.Format(stressL7(num9), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels7, "###%")
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels8.Visible = False
							Else
								Dim label8 As Label = avLabels8
								Dim stressL8 As Single() = RSWIN_DESC.rst.StressL
								Dim num10 As Integer = CInt(num)
								Dim text As String = "###%"
								label8.Text = Util.Format(stressL8(num10), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels8, "###%")
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels9.Visible = False
							Else
								Dim label9 As Label = avLabels9
								Dim stressL9 As Single() = RSWIN_DESC.rst.StressL
								Dim num11 As Integer = CInt(num)
								Dim text As String = "###%"
								label9.Text = Util.Format(stressL9(num11), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels9, "###%")
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels10.Visible = False
							Else
								Dim label10 As Label = avLabels10
								Dim stressL10 As Single() = RSWIN_DESC.rst.StressL
								Dim num12 As Integer = CInt(num)
								Dim text As String = "###%"
								label10.Text = Util.Format(stressL10(num12), text)
								Util.SetLabelColor(RSWIN_DESC.rst.StressL(CInt(num)), avLabels10, "###%")
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodTensileStrengthList2(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label, ByRef avLabels11 As Label, ByRef avLabels12 As Label, ByRef avLabels13 As Label, ByRef avLabels14 As Label, ByRef avLabels15 As Label, ByRef avLabels16 As Label, ByRef avLabels17 As Label, ByRef avLabels18 As Label, ByRef avLabels19 As Label, ByRef avLabels20 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 20L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels1.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels1.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels2.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels3.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels4.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels5.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels6.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels7.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels8.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels9.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels10.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 10
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels11.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels11.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 11
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels12.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels12.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 12
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels13.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels13.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 13
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels14.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels14.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 14
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels15.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels15.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 15
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels16.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels16.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 16
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels17.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels17.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 17
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels18.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels18.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 18
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels19.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels19.Text = Me.GetTensileStrength(CInt(num))
							End If
						Case 19
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels20.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels20.Text = Me.GetTensileStrength(CInt(num))
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodStressMethodList2(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label, ByRef avLabels11 As Label, ByRef avLabels12 As Label, ByRef avLabels13 As Label, ByRef avLabels14 As Label, ByRef avLabels15 As Label, ByRef avLabels16 As Label, ByRef avLabels17 As Label, ByRef avLabels18 As Label, ByRef avLabels19 As Label, ByRef avLabels20 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 20L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels1.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels1.Text = text
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels2.Text = text
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels3.Text = text
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels4.Text = text
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels5.Text = text
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels6.Text = text
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels7.Text = text
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels8.Text = text
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels9.Text = text
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels10.Text = text
							End If
						Case 10
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels11.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels11.Text = text
							End If
						Case 11
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels12.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels12.Text = text
							End If
						Case 12
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels13.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels13.Text = text
							End If
						Case 13
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels14.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels14.Text = text
							End If
						Case 14
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels15.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels15.Text = text
							End If
						Case 15
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels16.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels16.Text = text
							End If
						Case 16
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels17.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels17.Text = text
							End If
						Case 17
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels18.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels18.Text = text
							End If
						Case 18
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels19.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels19.Text = text
							End If
						Case 19
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels20.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels20.Text = text
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodStressMethodList(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 10L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels1.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels1.Text = text
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels2.Text = text
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels3.Text = text
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels4.Text = text
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels5.Text = text
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels6.Text = text
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels7.Text = text
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels8.Text = text
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels9.Text = text
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								Dim text As String
								Select Case RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(CInt(num)))
									Case 0
										text = "API MG"
									Case 1
										text = "API MG T/2.8"
									Case 2
										text = "API MG T/3"
									Case 3
										text = "WFT EL"
									Case 4
										text = "MGS"
									Case 5
										text = "Fiberflex"
									Case 6
										text = "Norris FG"
									Case 7
										text = "Durarod"
									Case 8
										text = "RR Amoco"
									Case 9
										text = "Fiberod"
									Case 10
										text = "Tenaris"
									Case 11
										text = "Fiberod CCR"
									Case 12
										text = "Tenaris PC"
									Case 13
										text = "FlexRod"
									Case 14
										text = "Superod"
									Case 16
										text = "Tenaris PC"
								End Select
								avLabels10.Text = text
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowNumberRodGuides(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 10L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels1.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels1.Text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(CInt(num)).NumGuides))
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels2.Text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(CInt(num)).NumGuides))
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels3.Text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(CInt(num)).NumGuides))
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels4.Text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(CInt(num)).NumGuides))
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels5.Text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(CInt(num)).NumGuides))
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels6.Text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(CInt(num)).NumGuides))
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels7.Text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(CInt(num)).NumGuides))
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels8.Text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(CInt(num)).NumGuides))
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels9.Text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(CInt(num)).NumGuides))
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels10.Text = Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(CInt(num)).NumGuides))
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodTopMaxStressList(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 10L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels1.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num4 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop(num4), text)
								End If
								avLabels1.Text = text2
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels2.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop2 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num5 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop2(num5), text)
								End If
								avLabels2.Text = text2
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels3.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop3 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num6 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop3(num6), text)
								End If
								avLabels3.Text = text2
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels4.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop4 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num7 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop4(num7), text)
								End If
								avLabels4.Text = text2
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels5.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop5 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num8 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop5(num8), text)
								End If
								avLabels5.Text = text2
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels6.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop6 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num9 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop6(num9), text)
								End If
								avLabels6.Text = text2
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels7.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop7 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num10 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop7(num10), text)
								End If
								avLabels7.Text = text2
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels8.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop8 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num11 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop8(num11), text)
								End If
								avLabels8.Text = text2
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels9.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop9 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num12 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop9(num12), text)
								End If
								avLabels9.Text = text2
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels10.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop10 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num13 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop10(num13), text)
								End If
								avLabels10.Text = text2
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodTopMaxStressList2(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label, ByRef avLabels11 As Label, ByRef avLabels12 As Label, ByRef avLabels13 As Label, ByRef avLabels14 As Label, ByRef avLabels15 As Label, ByRef avLabels16 As Label, ByRef avLabels17 As Label, ByRef avLabels18 As Label, ByRef avLabels19 As Label, ByRef avLabels20 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 20L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels1.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num4 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop(num4), text)
								End If
								avLabels1.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels1, CInt(num))
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels2.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop2 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num5 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop2(num5), text)
								End If
								avLabels2.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels2, CInt(num))
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels3.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop3 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num6 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop3(num6), text)
								End If
								avLabels3.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels3, CInt(num))
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels4.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop4 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num7 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop4(num7), text)
								End If
								avLabels4.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels4, CInt(num))
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels5.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop5 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num8 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop5(num8), text)
								End If
								avLabels5.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels5, CInt(num))
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels6.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop6 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num9 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop6(num9), text)
								End If
								avLabels6.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels6, CInt(num))
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels7.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop7 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num10 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop7(num10), text)
								End If
								avLabels7.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels7, CInt(num))
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels8.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop8 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num11 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop8(num11), text)
								End If
								avLabels8.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels8, CInt(num))
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels9.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop9 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num12 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop9(num12), text)
								End If
								avLabels9.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels9, CInt(num))
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels10.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop10 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num13 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop10(num13), text)
								End If
								avLabels10.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels10, CInt(num))
							End If
						Case 10
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels11.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop11 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num14 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop11(num14), text)
								End If
								avLabels11.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels11, CInt(num))
							End If
						Case 11
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels12.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop12 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num15 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop12(num15), text)
								End If
								avLabels12.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels12, CInt(num))
							End If
						Case 12
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels13.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop13 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num16 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop13(num16), text)
								End If
								avLabels13.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels13, CInt(num))
							End If
						Case 13
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels14.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop14 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num17 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop14(num17), text)
								End If
								avLabels14.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels14, CInt(num))
							End If
						Case 14
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels15.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop15 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num18 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop15(num18), text)
								End If
								avLabels15.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels15, CInt(num))
							End If
						Case 15
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels16.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop16 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num19 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop16(num19), text)
								End If
								avLabels16.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels16, CInt(num))
							End If
						Case 16
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels17.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop17 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num20 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop17(num20), text)
								End If
								avLabels17.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels17, CInt(num))
							End If
						Case 17
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels18.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop18 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num21 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop18(num21), text)
								End If
								avLabels18.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels18, CInt(num))
							End If
						Case 18
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels19.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop19 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num22 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop19(num22), text)
								End If
								avLabels19.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels19, CInt(num))
							End If
						Case 19
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels20.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.maxStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim maxStressTop20 As Single() = RSWIN_DESC.rst.maxStressTop
									Dim num23 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(maxStressTop20(num23), text)
								End If
								avLabels20.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.maxStressTop(CInt(num)), avLabels20, CInt(num))
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodBotMinStressList2(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label, ByRef avLabels11 As Label, ByRef avLabels12 As Label, ByRef avLabels13 As Label, ByRef avLabels14 As Label, ByRef avLabels15 As Label, ByRef avLabels16 As Label, ByRef avLabels17 As Label, ByRef avLabels18 As Label, ByRef avLabels19 As Label, ByRef avLabels20 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 20L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels1.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot As Single() = RSWIN_DESC.rst.minStressBot
									Dim num4 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot(num4), text)
								End If
								avLabels1.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels1, CInt(num))
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels2.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot2 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num5 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot2(num5), text)
								End If
								avLabels2.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels2, CInt(num))
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels3.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot3 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num6 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot3(num6), text)
								End If
								avLabels3.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels3, CInt(num))
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels4.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot4 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num7 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot4(num7), text)
								End If
								avLabels4.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels4, CInt(num))
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels5.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot5 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num8 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot5(num8), text)
								End If
								avLabels5.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels5, CInt(num))
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels6.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot6 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num9 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot6(num9), text)
								End If
								avLabels6.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels6, CInt(num))
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels7.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot7 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num10 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot7(num10), text)
								End If
								avLabels7.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels7, CInt(num))
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels8.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot8 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num11 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot8(num11), text)
								End If
								avLabels8.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels8, CInt(num))
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels9.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot9 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num12 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot9(num12), text)
								End If
								avLabels9.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels9, CInt(num))
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels10.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot10 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num13 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot10(num13), text)
								End If
								avLabels10.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels10, CInt(num))
							End If
						Case 10
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels11.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot11 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num14 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot11(num14), text)
								End If
								avLabels11.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels11, CInt(num))
							End If
						Case 11
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels12.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot12 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num15 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot12(num15), text)
								End If
								avLabels12.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels12, CInt(num))
							End If
						Case 12
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels13.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot13 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num16 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot13(num16), text)
								End If
								avLabels13.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels13, CInt(num))
							End If
						Case 13
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels14.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot14 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num17 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot14(num17), text)
								End If
								avLabels14.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels14, CInt(num))
							End If
						Case 14
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels15.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot15 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num18 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot15(num18), text)
								End If
								avLabels15.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels15, CInt(num))
							End If
						Case 15
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels16.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot16 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num19 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot16(num19), text)
								End If
								avLabels16.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels16, CInt(num))
							End If
						Case 16
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels17.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot17 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num20 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot17(num20), text)
								End If
								avLabels17.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels17, CInt(num))
							End If
						Case 17
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels18.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot18 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num21 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot18(num21), text)
								End If
								avLabels18.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels18, CInt(num))
							End If
						Case 18
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels19.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot19 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num22 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot19(num22), text)
								End If
								avLabels19.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels19, CInt(num))
							End If
						Case 19
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels20.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressBot(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressBot20 As Single() = RSWIN_DESC.rst.minStressBot
									Dim num23 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressBot20(num23), text)
								End If
								avLabels20.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressBot(CInt(num)), avLabels20, CInt(num))
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
			If Not RSWIN_DESC.rst.gbIncludeBuoyancy Then
				If(RODUTIL.IsSinkerBar(CInt(RSWIN_DESC.rst.NumRods)) Or If((-If((CUSTOMRG.IsOtherSinkerBar(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) > False), 1, 0)), 1, 0)) <> 0 Then
					' The following expression was wrapped in a checked-statement
					If RSWIN_DESC.rst.NumRods > 1S Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 And RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S))) * RSWIN_DESC.PSI__KPA < 0F Then
							Me.SetLabelColorMinStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
						ElseIf RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S))) < 0F Then
							Me.SetLabelColorMinStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
						End If
					End If
				ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					If RSWIN_DESC.rst.minStressBot(CInt(RSWIN_DESC.rst.NumRods)) * RSWIN_DESC.PSI__KPA < 0F Then
						Me.SetLabelColorMinStressBot(CInt(RSWIN_DESC.rst.NumRods))
					End If
				ElseIf RSWIN_DESC.rst.minStressBot(CInt(RSWIN_DESC.rst.NumRods)) <> 0F Then
					Me.SetLabelColorMinStressBot(CInt(RSWIN_DESC.rst.NumRods))
				End If
				Return
			End If
		End Sub

		Private Sub ShowRodTopMinStressList2(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label, ByRef avLabels11 As Label, ByRef avLabels12 As Label, ByRef avLabels13 As Label, ByRef avLabels14 As Label, ByRef avLabels15 As Label, ByRef avLabels16 As Label, ByRef avLabels17 As Label, ByRef avLabels18 As Label, ByRef avLabels19 As Label, ByRef avLabels20 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 20L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels1.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop As Single() = RSWIN_DESC.rst.minStressTop
									Dim num4 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop(num4), text)
								End If
								avLabels1.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels1, CInt(num))
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels2.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop2 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num5 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop2(num5), text)
								End If
								avLabels2.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels2, CInt(num))
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels3.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop3 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num6 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop3(num6), text)
								End If
								avLabels3.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels3, CInt(num))
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels4.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop4 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num7 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop4(num7), text)
								End If
								avLabels4.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels4, CInt(num))
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels5.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop5 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num8 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop5(num8), text)
								End If
								avLabels5.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels5, CInt(num))
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels6.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop6 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num9 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop6(num9), text)
								End If
								avLabels6.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels6, CInt(num))
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels7.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop7 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num10 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop7(num10), text)
								End If
								avLabels7.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels7, CInt(num))
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels8.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop8 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num11 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop8(num11), text)
								End If
								avLabels8.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels8, CInt(num))
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels9.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop9 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num12 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop9(num12), text)
								End If
								avLabels9.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels9, CInt(num))
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels10.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop10 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num13 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop10(num13), text)
								End If
								avLabels10.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels10, CInt(num))
							End If
						Case 10
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels11.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop11 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num14 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop11(num14), text)
								End If
								avLabels11.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels11, CInt(num))
							End If
						Case 11
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels12.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop12 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num15 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop12(num15), text)
								End If
								avLabels12.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels12, CInt(num))
							End If
						Case 12
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels13.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop13 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num16 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop13(num16), text)
								End If
								avLabels13.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels13, CInt(num))
							End If
						Case 13
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels14.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop14 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num17 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop14(num17), text)
								End If
								avLabels14.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels14, CInt(num))
							End If
						Case 14
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels15.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop15 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num18 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop15(num18), text)
								End If
								avLabels15.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels15, CInt(num))
							End If
						Case 15
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels16.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop16 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num19 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop16(num19), text)
								End If
								avLabels16.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels16, CInt(num))
							End If
						Case 16
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels17.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop17 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num20 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop17(num20), text)
								End If
								avLabels17.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels17, CInt(num))
							End If
						Case 17
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels18.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop18 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num21 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop18(num21), text)
								End If
								avLabels18.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels18, CInt(num))
							End If
						Case 18
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels19.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop19 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num22 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop19(num22), text)
								End If
								avLabels19.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels19, CInt(num))
							End If
						Case 19
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels20.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop20 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num23 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop20(num23), text)
								End If
								avLabels20.Text = text2
								Me.SetStressLabelColor(RSWIN_DESC.rst.minStressTop(CInt(num)), avLabels20, CInt(num))
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodTopMinStressList(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 10L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels1.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop As Single() = RSWIN_DESC.rst.minStressTop
									Dim num4 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop(num4), text)
								End If
								avLabels1.Text = text2
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels2.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop2 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num5 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop2(num5), text)
								End If
								avLabels2.Text = text2
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels3.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop3 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num6 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop3(num6), text)
								End If
								avLabels3.Text = text2
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels4.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop4 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num7 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop4(num7), text)
								End If
								avLabels4.Text = text2
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels5.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop5 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num8 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop5(num8), text)
								End If
								avLabels5.Text = text2
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels6.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop6 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num9 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop6(num9), text)
								End If
								avLabels6.Text = text2
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels7.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop7 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num10 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop7(num10), text)
								End If
								avLabels7.Text = text2
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels8.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop8 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num11 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop8(num11), text)
								End If
								avLabels8.Text = text2
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels9.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop9 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num12 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop9(num12), text)
								End If
								avLabels9.Text = text2
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels10.Visible = False
							Else
								Dim text2 As String
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									' The following expression was wrapped in a checked-expression
									Dim num3 As Single = RSWIN_DESC.rst.minStressTop(CInt(num)) * RSWIN_DESC.PSI__KPA
									Dim text As String = "0"
									text2 = Util.Format(num3, text)
								Else
									Dim minStressTop10 As Single() = RSWIN_DESC.rst.minStressTop
									Dim num13 As Integer = CInt(num)
									Dim text As String = "0"
									text2 = Util.Format(minStressTop10(num13), text)
								End If
								avLabels10.Text = text2
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowFricCoefList2(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label, ByRef avLabels11 As Label, ByRef avLabels12 As Label, ByRef avLabels13 As Label, ByRef avLabels14 As Label, ByRef avLabels15 As Label, ByRef avLabels16 As Label, ByRef avLabels17 As Label, ByRef avLabels18 As Label, ByRef avLabels19 As Label, ByRef avLabels20 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 20L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels1.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels1.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels2.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels2.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels3.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels3.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels4.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels4.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels5.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels5.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels6.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels6.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels7.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels7.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels8.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels8.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels9.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels9.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels10.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels10.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 10
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels11.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels11.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 11
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels12.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels12.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 12
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels13.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels13.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 13
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels14.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels14.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 14
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels15.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels15.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 15
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels16.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels16.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 16
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels17.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels17.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 17
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels18.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels18.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 18
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels19.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels19.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 19
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels20.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels20.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowFricCoefList(ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label, ByRef avLabels6 As Label, ByRef avLabels7 As Label, ByRef avLabels8 As Label, ByRef avLabels9 As Label, ByRef avLabels10 As Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 10L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels1.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels1.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels2.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels2.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels3.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels3.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels4.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels4.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels5.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels5.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels6.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels6.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels7.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels7.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels8.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels8.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels9.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels9.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels10.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels10.Text = Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num)).friction_coef)
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRSCalc()
			Me.lblRodStringResults.Text = Util.FormatMessage("Rod string stress analysis (service factor: {00.0})", New Object() { RSWIN_DESC.rst.ServiceFactor })
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				Me.lblRodTopMaxStressHdrBot.Text = "Stress (kPa)"
				Me.lblRodTopMinStressHdrBot.Text = "Stress (kPa)"
				Me.lblRodBotMinStressHdrBot.Text = "Stress (kPa)"
			End If
			If RSWIN_DESC.rst.NumRods <= 10S Then
				Me.ShowRodStressList(Me.lblRodStress1, Me.lblRodStress2, Me.lblRodStress3, Me.lblRodStress4, Me.lblRodStress5, Me.lblRodStress6, Me.lblRodStress7, Me.lblRodStress8, Me.lblRodStress9, Me.lblRodStress10)
				Me.ShowRodTopMaxStressList(Me.lblRodTopMaxStress1, Me.lblRodTopMaxStress2, Me.lblRodTopMaxStress3, Me.lblRodTopMaxStress4, Me.lblRodTopMaxStress5, Me.lblRodTopMaxStress6, Me.lblRodTopMaxStress7, Me.lblRodTopMaxStress8, Me.lblRodTopMaxStress9, Me.lblRodTopMaxStress10)
				Me.ShowRodTopMinStressList(Me.lblRodTopMinStress1, Me.lblRodTopMinStress2, Me.lblRodTopMinStress3, Me.lblRodTopMinStress4, Me.lblRodTopMinStress5, Me.lblRodTopMinStress6, Me.lblRodTopMinStress7, Me.lblRodTopMinStress8, Me.lblRodTopMinStress9, Me.lblRodTopMinStress10)
				Me.ShowRodBotMinStressList(Me.lblRodBotMinStress1, Me.lblRodBotMinStress2, Me.lblRodBotMinStress3, Me.lblRodBotMinStress4, Me.lblRodBotMinStress5, Me.lblRodBotMinStress6, Me.lblRodBotMinStress7, Me.lblRodBotMinStress8, Me.lblRodBotMinStress9, Me.lblRodBotMinStress10)
				Me.ShowRodStressMethodList(Me.lblRodStressMethod1, Me.lblRodStressMethod2, Me.lblRodStressMethod3, Me.lblRodStressMethod4, Me.lblRodStressMethod5, Me.lblRodStressMethod6, Me.lblRodStressMethod7, Me.lblRodStressMethod8, Me.lblRodStressMethod9, Me.lblRodStressMethod10)
				Me.lblRodStress11.Visible = False
				Me.lblRodStress12.Visible = False
				Me.lblRodStress13.Visible = False
				Me.lblRodStress14.Visible = False
				Me.lblRodStress15.Visible = False
				Me.lblRodStress16.Visible = False
				Me.lblRodStress17.Visible = False
				Me.lblRodStress18.Visible = False
				Me.lblRodStress19.Visible = False
				Me.lblRodStress20.Visible = False
				Me.lblRodTopMaxStress11.Visible = False
				Me.lblRodTopMaxStress12.Visible = False
				Me.lblRodTopMaxStress13.Visible = False
				Me.lblRodTopMaxStress14.Visible = False
				Me.lblRodTopMaxStress15.Visible = False
				Me.lblRodTopMaxStress16.Visible = False
				Me.lblRodTopMaxStress17.Visible = False
				Me.lblRodTopMaxStress18.Visible = False
				Me.lblRodTopMaxStress19.Visible = False
				Me.lblRodTopMaxStress20.Visible = False
				Me.lblRodTopMinStress11.Visible = False
				Me.lblRodTopMinStress12.Visible = False
				Me.lblRodTopMinStress13.Visible = False
				Me.lblRodTopMinStress14.Visible = False
				Me.lblRodTopMinStress15.Visible = False
				Me.lblRodTopMinStress16.Visible = False
				Me.lblRodTopMinStress17.Visible = False
				Me.lblRodTopMinStress18.Visible = False
				Me.lblRodTopMinStress19.Visible = False
				Me.lblRodTopMinStress20.Visible = False
				Me.lblRodBotMinStress11.Visible = False
				Me.lblRodBotMinStress12.Visible = False
				Me.lblRodBotMinStress13.Visible = False
				Me.lblRodBotMinStress14.Visible = False
				Me.lblRodBotMinStress15.Visible = False
				Me.lblRodBotMinStress16.Visible = False
				Me.lblRodBotMinStress17.Visible = False
				Me.lblRodBotMinStress18.Visible = False
				Me.lblRodBotMinStress19.Visible = False
				Me.lblRodBotMinStress20.Visible = False
				Me.lblRodStressMethod11.Visible = False
				Me.lblRodStressMethod12.Visible = False
				Me.lblRodStressMethod13.Visible = False
				Me.lblRodStressMethod14.Visible = False
				Me.lblRodStressMethod15.Visible = False
				Me.lblRodStressMethod16.Visible = False
				Me.lblRodStressMethod17.Visible = False
				Me.lblRodStressMethod18.Visible = False
				Me.lblRodStressMethod19.Visible = False
				Me.lblRodStressMethod20.Visible = False
			Else
				Dim label As Label = Me.lblRodStress11
				Dim label2 As Label = Me.lblRodStress12
				Dim label3 As Label = Me.lblRodStress13
				Dim label4 As Label = Me.lblRodStress14
				Dim label5 As Label = Me.lblRodStress15
				Dim label6 As Label = Me.lblRodStress16
				Dim label7 As Label = Me.lblRodStress17
				Dim label8 As Label = Me.lblRodStress18
				Dim label9 As Label = Me.lblRodStress19
				Dim label10 As Label = Me.lblRodStress20
				Me.ShowRodStressList2(Me.lblRodStress1, Me.lblRodStress2, Me.lblRodStress3, Me.lblRodStress4, Me.lblRodStress5, Me.lblRodStress6, Me.lblRodStress7, Me.lblRodStress8, Me.lblRodStress9, Me.lblRodStress10, label, label2, label3, label4, label5, label6, label7, label8, label9, label10)
				Me.lblRodStress20 = label10
				Me.lblRodStress19 = label9
				Me.lblRodStress18 = label8
				Me.lblRodStress17 = label7
				Me.lblRodStress16 = label6
				Me.lblRodStress15 = label5
				Me.lblRodStress14 = label4
				Me.lblRodStress13 = label3
				Me.lblRodStress12 = label2
				Me.lblRodStress11 = label
				label10 = Me.lblRodTopMaxStress11
				label9 = Me.lblRodTopMaxStress12
				label8 = Me.lblRodTopMaxStress13
				label7 = Me.lblRodTopMaxStress14
				label6 = Me.lblRodTopMaxStress15
				label5 = Me.lblRodTopMaxStress16
				label4 = Me.lblRodTopMaxStress17
				label3 = Me.lblRodTopMaxStress18
				label2 = Me.lblRodTopMaxStress19
				label = Me.lblRodTopMaxStress20
				Me.ShowRodTopMaxStressList2(Me.lblRodTopMaxStress1, Me.lblRodTopMaxStress2, Me.lblRodTopMaxStress3, Me.lblRodTopMaxStress4, Me.lblRodTopMaxStress5, Me.lblRodTopMaxStress6, Me.lblRodTopMaxStress7, Me.lblRodTopMaxStress8, Me.lblRodTopMaxStress9, Me.lblRodTopMaxStress10, label10, label9, label8, label7, label6, label5, label4, label3, label2, label)
				Me.lblRodTopMaxStress20 = label
				Me.lblRodTopMaxStress19 = label2
				Me.lblRodTopMaxStress18 = label3
				Me.lblRodTopMaxStress17 = label4
				Me.lblRodTopMaxStress16 = label5
				Me.lblRodTopMaxStress15 = label6
				Me.lblRodTopMaxStress14 = label7
				Me.lblRodTopMaxStress13 = label8
				Me.lblRodTopMaxStress12 = label9
				Me.lblRodTopMaxStress11 = label10
				label10 = Me.lblRodTopMinStress11
				label9 = Me.lblRodTopMinStress12
				label8 = Me.lblRodTopMinStress13
				label7 = Me.lblRodTopMinStress14
				label6 = Me.lblRodTopMinStress15
				label5 = Me.lblRodTopMinStress16
				label4 = Me.lblRodTopMinStress17
				label3 = Me.lblRodTopMinStress18
				label2 = Me.lblRodTopMinStress19
				label = Me.lblRodTopMinStress20
				Me.ShowRodTopMinStressList2(Me.lblRodTopMinStress1, Me.lblRodTopMinStress2, Me.lblRodTopMinStress3, Me.lblRodTopMinStress4, Me.lblRodTopMinStress5, Me.lblRodTopMinStress6, Me.lblRodTopMinStress7, Me.lblRodTopMinStress8, Me.lblRodTopMinStress9, Me.lblRodTopMinStress10, label10, label9, label8, label7, label6, label5, label4, label3, label2, label)
				Me.lblRodTopMinStress20 = label
				Me.lblRodTopMinStress19 = label2
				Me.lblRodTopMinStress18 = label3
				Me.lblRodTopMinStress17 = label4
				Me.lblRodTopMinStress16 = label5
				Me.lblRodTopMinStress15 = label6
				Me.lblRodTopMinStress14 = label7
				Me.lblRodTopMinStress13 = label8
				Me.lblRodTopMinStress12 = label9
				Me.lblRodTopMinStress11 = label10
				label10 = Me.lblRodBotMinStress11
				label9 = Me.lblRodBotMinStress12
				label8 = Me.lblRodBotMinStress13
				label7 = Me.lblRodBotMinStress14
				label6 = Me.lblRodBotMinStress15
				label5 = Me.lblRodBotMinStress16
				label4 = Me.lblRodBotMinStress17
				label3 = Me.lblRodBotMinStress18
				label2 = Me.lblRodBotMinStress19
				label = Me.lblRodBotMinStress20
				Me.ShowRodBotMinStressList2(Me.lblRodBotMinStress1, Me.lblRodBotMinStress2, Me.lblRodBotMinStress3, Me.lblRodBotMinStress4, Me.lblRodBotMinStress5, Me.lblRodBotMinStress6, Me.lblRodBotMinStress7, Me.lblRodBotMinStress8, Me.lblRodBotMinStress9, Me.lblRodBotMinStress10, label10, label9, label8, label7, label6, label5, label4, label3, label2, label)
				Me.lblRodBotMinStress20 = label
				Me.lblRodBotMinStress19 = label2
				Me.lblRodBotMinStress18 = label3
				Me.lblRodBotMinStress17 = label4
				Me.lblRodBotMinStress16 = label5
				Me.lblRodBotMinStress15 = label6
				Me.lblRodBotMinStress14 = label7
				Me.lblRodBotMinStress13 = label8
				Me.lblRodBotMinStress12 = label9
				Me.lblRodBotMinStress11 = label10
				label10 = Me.lblRodStressMethod11
				label9 = Me.lblRodStressMethod12
				label8 = Me.lblRodStressMethod13
				label7 = Me.lblRodStressMethod14
				label6 = Me.lblRodStressMethod15
				label5 = Me.lblRodStressMethod16
				label4 = Me.lblRodStressMethod17
				label3 = Me.lblRodStressMethod18
				label2 = Me.lblRodStressMethod19
				label = Me.lblRodStressMethod20
				Me.ShowRodStressMethodList2(Me.lblRodStressMethod1, Me.lblRodStressMethod2, Me.lblRodStressMethod3, Me.lblRodStressMethod4, Me.lblRodStressMethod5, Me.lblRodStressMethod6, Me.lblRodStressMethod7, Me.lblRodStressMethod8, Me.lblRodStressMethod9, Me.lblRodStressMethod10, label10, label9, label8, label7, label6, label5, label4, label3, label2, label)
				Me.lblRodStressMethod20 = label
				Me.lblRodStressMethod19 = label2
				Me.lblRodStressMethod18 = label3
				Me.lblRodStressMethod17 = label4
				Me.lblRodStressMethod16 = label5
				Me.lblRodStressMethod15 = label6
				Me.lblRodStressMethod14 = label7
				Me.lblRodStressMethod13 = label8
				Me.lblRodStressMethod12 = label9
				Me.lblRodStressMethod11 = label10
			End If
		End Sub

		Private Sub ShowRSInput()
			Me.mbCorodSEString = True
			Dim num As Long = 1L
			Dim num2 As Long = CLng(RSWIN_DESC.rst.NumRods)
			For num3 As Long = num To num2
				If Not RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(CInt(num3)).Grade) Then
					Me.mbCorodSEString = False
					Exit For
				End If
			Next
			Select Case RSWIN_DESC.rst.RodStringType
				Case 1S
					Me.lblRodStringDesign.Text = Util.FormatMessage("Rod string design (API rod number: {0})", New Object() { RSWIN_DESC.rst.APIRod })
					GoTo IL_BE
				Case 3S
					Me.lblRodStringDesign.Text = "Rod string design (rod tapers calculated)"
					GoTo IL_BE
			End Select
			Me.lblRodStringDesign.Text = "Rod string design"
			IL_BE:
			If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				Me.lblRodLengthHdrBot.Text = "(" + RSWIN_DESC.m + ")"
			ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				If Not Me.mbCorodSEString Then
					Me.lblRodDiamHdrBot.Text = "(" + RSWIN_DESC.mm + ")"
				End If
				Me.lblRodLengthHdrBot.Text = "(" + RSWIN_DESC.m + ")"
				Me.lblRodTensileStrengthHdrBot.Text = "Strength " + RSWIN_DESC.kPa
			End If
			Me.mbMsgFullOKNeeded = False
			Me.mbMsgSlimNeededNeeded = False
			Me.mbMsgElevatorNeck1_0Needed = False
			Me.mbMsgNoNeckNeeded = False
			If RSWIN_DESC.rst.NumRods <= 10S Then
				Me.ShowRodDiameterList(Me.lblRodDiam1, Me.lblRodDiam2, Me.lblRodDiam3, Me.lblRodDiam4, Me.lblRodDiam5, Me.lblRodDiam6, Me.lblRodDiam7, Me.lblRodDiam8, Me.lblRodDiam9, Me.lblRodDiam10)
				Me.ShowRodGradeList(Me.lblRodGrade1, Me.lblRodGrade2, Me.lblRodGrade3, Me.lblRodGrade4, Me.lblRodGrade5, Me.lblRodGrade6, Me.lblRodGrade7, Me.lblRodGrade8, Me.lblRodGrade9, Me.lblRodGrade10)
				Me.ShowRodLengthList(Me.lblRodLength1, Me.lblRodLength2, Me.lblRodLength3, Me.lblRodLength4, Me.lblRodLength5, Me.lblRodLength6, Me.lblRodLength7, Me.lblRodLength8, Me.lblRodLength9, Me.lblRodLength10)
				Me.ShowRodTensileStrengthList(Me.lblRodTensileStrength1, Me.lblRodTensileStrength2, Me.lblRodTensileStrength3, Me.lblRodTensileStrength4, Me.lblRodTensileStrength5, Me.lblRodTensileStrength6, Me.lblRodTensileStrength7, Me.lblRodTensileStrength8, Me.lblRodTensileStrength9, Me.lblRodTensileStrength10)
				Me.ShowFricCoefList(Me.lblFricCoef1, Me.lblFricCoef2, Me.lblFricCoef3, Me.lblFricCoef4, Me.lblFricCoef5, Me.lblFricCoef6, Me.lblFricCoef7, Me.lblFricCoef8, Me.lblFricCoef9, Me.lblFricCoef10)
				Me.lblRodDiam11.Visible = False
				Me.lblRodDiam12.Visible = False
				Me.lblRodDiam13.Visible = False
				Me.lblRodDiam14.Visible = False
				Me.lblRodDiam15.Visible = False
				Me.lblRodDiam16.Visible = False
				Me.lblRodDiam17.Visible = False
				Me.lblRodDiam18.Visible = False
				Me.lblRodDiam19.Visible = False
				Me.lblRodDiam20.Visible = False
				Me.lblRodGrade11.Visible = False
				Me.lblRodGrade12.Visible = False
				Me.lblRodGrade13.Visible = False
				Me.lblRodGrade14.Visible = False
				Me.lblRodGrade15.Visible = False
				Me.lblRodGrade16.Visible = False
				Me.lblRodGrade17.Visible = False
				Me.lblRodGrade18.Visible = False
				Me.lblRodGrade19.Visible = False
				Me.lblRodGrade20.Visible = False
				Me.lblRodLength11.Visible = False
				Me.lblRodLength12.Visible = False
				Me.lblRodLength13.Visible = False
				Me.lblRodLength14.Visible = False
				Me.lblRodLength15.Visible = False
				Me.lblRodLength16.Visible = False
				Me.lblRodLength17.Visible = False
				Me.lblRodLength18.Visible = False
				Me.lblRodLength19.Visible = False
				Me.lblRodLength20.Visible = False
				Me.lblRodTensileStrength11.Visible = False
				Me.lblRodTensileStrength12.Visible = False
				Me.lblRodTensileStrength13.Visible = False
				Me.lblRodTensileStrength14.Visible = False
				Me.lblRodTensileStrength15.Visible = False
				Me.lblRodTensileStrength16.Visible = False
				Me.lblRodTensileStrength17.Visible = False
				Me.lblRodTensileStrength18.Visible = False
				Me.lblRodTensileStrength19.Visible = False
				Me.lblRodTensileStrength20.Visible = False
				Me.lblFricCoef11.Visible = False
				Me.lblFricCoef12.Visible = False
				Me.lblFricCoef13.Visible = False
				Me.lblFricCoef14.Visible = False
				Me.lblFricCoef15.Visible = False
				Me.lblFricCoef16.Visible = False
				Me.lblFricCoef17.Visible = False
				Me.lblFricCoef18.Visible = False
				Me.lblFricCoef19.Visible = False
				Me.lblFricCoef20.Visible = False
			Else
				Dim label As Label = Me.lblRodDiam11
				Dim label2 As Label = Me.lblRodDiam12
				Dim label3 As Label = Me.lblRodDiam13
				Dim label4 As Label = Me.lblRodDiam14
				Dim label5 As Label = Me.lblRodDiam15
				Dim label6 As Label = Me.lblRodDiam16
				Dim label7 As Label = Me.lblRodDiam17
				Dim label8 As Label = Me.lblRodDiam18
				Dim label9 As Label = Me.lblRodDiam19
				Dim label10 As Label = Me.lblRodDiam20
				Me.ShowRodDiameterList2(Me.lblRodDiam1, Me.lblRodDiam2, Me.lblRodDiam3, Me.lblRodDiam4, Me.lblRodDiam5, Me.lblRodDiam6, Me.lblRodDiam7, Me.lblRodDiam8, Me.lblRodDiam9, Me.lblRodDiam10, label, label2, label3, label4, label5, label6, label7, label8, label9, label10)
				Me.lblRodDiam20 = label10
				Me.lblRodDiam19 = label9
				Me.lblRodDiam18 = label8
				Me.lblRodDiam17 = label7
				Me.lblRodDiam16 = label6
				Me.lblRodDiam15 = label5
				Me.lblRodDiam14 = label4
				Me.lblRodDiam13 = label3
				Me.lblRodDiam12 = label2
				Me.lblRodDiam11 = label
				label10 = Me.lblRodGrade11
				label9 = Me.lblRodGrade12
				label8 = Me.lblRodGrade13
				label7 = Me.lblRodGrade14
				label6 = Me.lblRodGrade15
				label5 = Me.lblRodGrade16
				label4 = Me.lblRodGrade17
				label3 = Me.lblRodGrade18
				label2 = Me.lblRodGrade19
				label = Me.lblRodGrade20
				Me.ShowRodGradeList2(Me.lblRodGrade1, Me.lblRodGrade2, Me.lblRodGrade3, Me.lblRodGrade4, Me.lblRodGrade5, Me.lblRodGrade6, Me.lblRodGrade7, Me.lblRodGrade8, Me.lblRodGrade9, Me.lblRodGrade10, label10, label9, label8, label7, label6, label5, label4, label3, label2, label)
				Me.lblRodGrade20 = label
				Me.lblRodGrade19 = label2
				Me.lblRodGrade18 = label3
				Me.lblRodGrade17 = label4
				Me.lblRodGrade16 = label5
				Me.lblRodGrade15 = label6
				Me.lblRodGrade14 = label7
				Me.lblRodGrade13 = label8
				Me.lblRodGrade12 = label9
				Me.lblRodGrade11 = label10
				label10 = Me.lblRodLength11
				label9 = Me.lblRodLength12
				label8 = Me.lblRodLength13
				label7 = Me.lblRodLength14
				label6 = Me.lblRodLength15
				label5 = Me.lblRodLength16
				label4 = Me.lblRodLength17
				label3 = Me.lblRodLength18
				label2 = Me.lblRodLength19
				label = Me.lblRodLength20
				Me.ShowRodLengthList2(Me.lblRodLength1, Me.lblRodLength2, Me.lblRodLength3, Me.lblRodLength4, Me.lblRodLength5, Me.lblRodLength6, Me.lblRodLength7, Me.lblRodLength8, Me.lblRodLength9, Me.lblRodLength10, label10, label9, label8, label7, label6, label5, label4, label3, label2, label)
				Me.lblRodLength20 = label
				Me.lblRodLength19 = label2
				Me.lblRodLength18 = label3
				Me.lblRodLength17 = label4
				Me.lblRodLength16 = label5
				Me.lblRodLength15 = label6
				Me.lblRodLength14 = label7
				Me.lblRodLength13 = label8
				Me.lblRodLength12 = label9
				Me.lblRodLength11 = label10
				label10 = Me.lblRodTensileStrength11
				label9 = Me.lblRodTensileStrength12
				label8 = Me.lblRodTensileStrength13
				label7 = Me.lblRodTensileStrength14
				label6 = Me.lblRodTensileStrength15
				label5 = Me.lblRodTensileStrength16
				label4 = Me.lblRodTensileStrength17
				label3 = Me.lblRodTensileStrength18
				label2 = Me.lblRodTensileStrength19
				label = Me.lblRodTensileStrength20
				Me.ShowRodTensileStrengthList2(Me.lblRodTensileStrength1, Me.lblRodTensileStrength2, Me.lblRodTensileStrength3, Me.lblRodTensileStrength4, Me.lblRodTensileStrength5, Me.lblRodTensileStrength6, Me.lblRodTensileStrength7, Me.lblRodTensileStrength8, Me.lblRodTensileStrength9, Me.lblRodTensileStrength10, label10, label9, label8, label7, label6, label5, label4, label3, label2, label)
				Me.lblRodTensileStrength20 = label
				Me.lblRodTensileStrength19 = label2
				Me.lblRodTensileStrength18 = label3
				Me.lblRodTensileStrength17 = label4
				Me.lblRodTensileStrength16 = label5
				Me.lblRodTensileStrength15 = label6
				Me.lblRodTensileStrength14 = label7
				Me.lblRodTensileStrength13 = label8
				Me.lblRodTensileStrength12 = label9
				Me.lblRodTensileStrength11 = label10
				label10 = Me.lblFricCoef11
				label9 = Me.lblFricCoef12
				label8 = Me.lblFricCoef13
				label7 = Me.lblFricCoef14
				label6 = Me.lblFricCoef15
				label5 = Me.lblFricCoef16
				label4 = Me.lblFricCoef17
				label3 = Me.lblFricCoef18
				label2 = Me.lblFricCoef19
				label = Me.lblFricCoef20
				Me.ShowFricCoefList2(Me.lblFricCoef1, Me.lblFricCoef2, Me.lblFricCoef3, Me.lblFricCoef4, Me.lblFricCoef5, Me.lblFricCoef6, Me.lblFricCoef7, Me.lblFricCoef8, Me.lblFricCoef9, Me.lblFricCoef10, label10, label9, label8, label7, label6, label5, label4, label3, label2, label)
				Me.lblFricCoef20 = label
				Me.lblFricCoef19 = label2
				Me.lblFricCoef18 = label3
				Me.lblFricCoef17 = label4
				Me.lblFricCoef16 = label5
				Me.lblFricCoef15 = label6
				Me.lblFricCoef14 = label7
				Me.lblFricCoef13 = label8
				Me.lblFricCoef12 = label9
				Me.lblFricCoef11 = label10
			End If
			Dim lastTop As Single = CSng((CDbl(Me.m_LastTop) + 1.5 * CDbl(Me.lblRSFootnote1.Height)))
			Me.ShowTrailer(lastTop, Me.lblRSFootnote1, Me.lblRSFootnote2, Me.lblRSFootnote3, Me.lblRSFootnote4, Me.lblRSFootnote5)
			Me.m_LastTop = lastTop
			Select Case RSWIN_DESC.rst.NumRods
				Case 1S
					Me.linRSInputSep1.Y2 = Me.lblRodDiam1.Top + Me.lblRodDiam1.Height
				Case 2S
					Me.linRSInputSep1.Y2 = Me.lblRodDiam2.Top + Me.lblRodDiam2.Height
				Case 3S
					Me.linRSInputSep1.Y2 = Me.lblRodDiam3.Top + Me.lblRodDiam3.Height
				Case 4S
					Me.linRSInputSep1.Y2 = Me.lblRodDiam4.Top + Me.lblRodDiam4.Height
				Case 5S
					Me.linRSInputSep1.Y2 = Me.lblRodDiam5.Top + Me.lblRodDiam5.Height
				Case 6S
					Me.linRSInputSep1.Y2 = Me.lblRodDiam6.Top + Me.lblRodDiam6.Height
				Case 7S
					Me.linRSInputSep1.Y2 = Me.lblRodDiam7.Top + Me.lblRodDiam7.Height
				Case 8S
					Me.linRSInputSep1.Y2 = Me.lblRodDiam8.Top + Me.lblRodDiam8.Height
				Case 9S
					Me.linRSInputSep1.Y2 = Me.lblRodDiam9.Top + Me.lblRodDiam9.Height
				Case 10S
					Me.linRSInputSep1.Y2 = Me.lblRodDiam10.Top + Me.lblRodDiam10.Height
			End Select
			Me.linRSInputSep1.Y2 = Me.linRSInputSep1.Y2
			Me.linRSInputSep2.Y2 = Me.linRSInputSep1.Y2
			Me.linRSInputSep3.Y2 = Me.linRSInputSep1.Y2
			Me.linRSInputSep4.Y2 = Me.linRSInputSep1.Y2
			Me.linRSCalcSep1.Y2 = Me.linRSInputSep1.Y2
			Me.linRSCalcSep2.Y2 = Me.linRSInputSep1.Y2
			Me.linRSCalcSep3.Y2 = Me.linRSInputSep1.Y2
			Me.linRSCalcSep4.Y2 = Me.linRSInputSep1.Y2
			Me.linDivider.Y2 = Me.linRSInputSep1.Y2
		End Sub

		Private Sub SummTrailer(ByRef LastTop As Single, LastHeight As Single)
			Dim array As String() = New String(10) {}
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				Dim text As String = Me.sElevatorNeck + "25.4 mm"
			Else
				Dim text As String = Me.sElevatorNeck + "1"""
			End If
			Dim num As Integer = 0
			If Me.mbMsgFullOKNeeded Then
				num += 1
				array(num) = Me.sAsterickMsg
			End If
			If Me.mbMsgSlimNeededNeeded Then
				num += 1
				array(num) = Me.sPlusMsg
			End If
			If Me.mbMsgElevatorNeck1_0Needed Then
				num += 1
				array(num) = Me.sAtSignMsg
			End If
			If Me.mbMsgNoNeckNeeded Then
				num += 1
				array(num) = Me.sPoundSignMsg
			End If
			num += 1
			If rst.gbIncludeBuoyancy Then
				array(num) = Me.sNOTE1
			Else
				array(num) = Me.sNOTE2
			End If
			If Me.FiberodOverloaded() And num < 5 Then
				num += 1
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					array(num) = RSWIN_DESC.sMaxFiberodStressWarning_Meter
				Else
					array(num) = RSWIN_DESC.sMaxFiberodStressWarning_English
				End If
			ElseIf Me.FibercoOverloaded() And num < 5 Then
				num += 1
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					array(num) = RSWIN_DESC.sMaxFibercoStressWarning_Meter
				Else
					array(num) = RSWIN_DESC.sMaxFibercoStressWarning_English
				End If
			End If
			If Me.FiberodUnderloaded() And num < 5 Then
				num += 1
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					array(num) = RSWIN_DESC.sMinFiberodStressWarning_Meter
				Else
					array(num) = RSWIN_DESC.sMinFiberodStressWarning_English
				End If
			ElseIf Me.FibercoUnderloaded() And num < 5 Then
				num += 1
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					array(num) = RSWIN_DESC.sMinFibercoStressWarning_Meter
				Else
					array(num) = RSWIN_DESC.sMinFibercoStressWarning_English
				End If
			End If
			If num >= 1 Then
				Dim num2 As Integer = 1
				Dim num3 As Integer = num
				For i As Integer = num2 To num3
					Me.SendLine(i, array(i), LastTop, LastHeight)
				Next
			End If
		End Sub

		Private Sub SendLine(nLine As Integer, sLine As String, ByRef LastTop As Single, ByRef LastHeight As Single)
			If Operators.CompareString(sLine, "", False) = 0 Then
				Return
			End If
			Select Case nLine
				Case 1
					Me.lblRSFootnote1.Text = sLine
					Me.lblRSFootnote1.Top = CSng((CDbl(LastTop) + CDbl(LastHeight) * 1.25))
					LastTop = Me.lblRSFootnote1.Top
				Case 2
					Me.lblRSFootnote2.Text = sLine
					Me.lblRSFootnote2.Top = LastTop + LastHeight
					LastTop = Me.lblRSFootnote2.Top
				Case 3
					Me.lblRSFootnote3.Text = sLine
					Me.lblRSFootnote3.Top = LastTop + LastHeight
					LastTop = Me.lblRSFootnote3.Top
				Case 4
					Me.lblRSFootnote4.Text = sLine
					Me.lblRSFootnote4.Top = LastTop + LastHeight
					LastTop = Me.lblRSFootnote4.Top
				Case 5
					Me.lblRSFootnote5.Text = sLine
					Me.lblRSFootnote5.Top = LastTop + LastHeight
					LastTop = Me.lblRSFootnote5.Top
			End Select
		End Sub

		Private Sub SummRSInput(ByRef LastTop As Single, ByRef LastHeight As Single)
			Dim text As String = ""
			Dim text2 As String = ""
			Dim text3 As String = ""
			Dim text4 As String = ""
			Dim text5 As String = ""
			Dim text6 As String = ""
			Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
			Me.mbCorodSEString = True
			Dim num As Integer = 1
			Dim numRods As Integer = CInt(cRODSTAR.NumRods)
			For i As Integer = num To numRods
				If Not RODUTIL.IsCorod(cRODSTAR.Sections(i).Grade) Then
					Me.mbCorodSEString = False
					Exit For
				End If
			Next
			Me.mbMsgFullOKNeeded = False
			Me.mbMsgSlimNeededNeeded = False
			Me.mbMsgElevatorNeck1_0Needed = False
			Me.mbMsgNoNeckNeeded = False
			Dim num2 As Integer = 1
			Dim numRods2 As Integer = CInt(cRODSTAR.NumRods)
			For i As Integer = num2 To numRods2
				Dim quiet As Object = True
				Dim grade As Object = cRODSTAR.Sections(i).Grade
				Dim diameter As Object = cRODSTAR.Sections(i).Diameter
				Dim sNull As Object = RSWIN_DESC.sNull
				Dim flag As Boolean
				Dim obj As Object = flag
				Dim obj2 As Object
				Dim obj3 As Object
				RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj2, obj3, sNull, obj, i)
				flag = Conversions.ToBoolean(obj)
				RSWIN_DESC.sNull = Conversions.ToString(sNull)
				If Conversions.ToBoolean(Operators.NotObject(obj2)) Then
					text6 = "*"
					Me.mbMsgFullOKNeeded = True
				ElseIf Conversions.ToBoolean(obj3) Then
					text6 = "+"
					Me.mbMsgSlimNeededNeeded = True
				Else
					text6 = " "
				End If
				If RODUTIL.IsFG(cRODSTAR.Sections(i).Grade) Then
					text6 += " "
				ElseIf RODUTIL.IsNoNeck(cRODSTAR.Sections(i).Grade) Then
					text6 += "#"
					Me.mbMsgNoNeckNeeded = True
				Else
					Dim diameter2 As Single = cRODSTAR.Sections(i).Diameter
					If diameter2 >= 1.374F Then
						text6 += "@"
						Me.mbMsgElevatorNeck1_0Needed = True
					ElseIf RODUTIL.IsSinkerBar(i) <> 0 Then
						text6 += "@"
						Me.mbMsgElevatorNeck1_0Needed = True
					Else
						text6 += " "
					End If
				End If

					If RODUTIL.IsCorodH(cRODSTAR.Sections(i).Grade) Then
						text = Me.sNA
					ElseIf RODUTIL.IsCorod(cRODSTAR.Sections(i).Grade) Then
						If cRODSTAR.Sections(i).Diameter > 1F Then
							Dim num3 As Single = cRODSTAR.Sections(i).Diameter * 16F
							Dim text7 As String = "0.0"
							text = Util.Format(num3, text7) + "/16"
						Else
							Dim num3 As Single = cRODSTAR.Sections(i).Diameter * 16F
							Dim text7 As String = "0"
							text = Util.Format(num3, text7) + "/16"
						End If
						If Not Me.mbCorodSEString And RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							text += """"
						End If
					ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						Dim num3 As Single = cRODSTAR.Sections(i).Diameter * RSWIN_DESC.IN__MM
						Dim text7 As String = "0.0"
						text = Util.Format(num3, text7)
					Else
						Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
						Dim num4 As Integer = i
						Dim text7 As String = "0.0###"
						text = Util.Format(sections(num4).Diameter, text7)
					End If
					If CUSTOMRG.IsOtherFG(CInt(cRODSTAR.Sections(i).Grade)) Then
						Dim grade2 As Integer = CInt(cRODSTAR.Sections(i).Grade)
						Dim num3 As Single = 0F
						text2 = RODUTIL.GetOtherFG(grade2, num3)
					ElseIf CUSTOMRG.IsOtherSinkerBar(CInt(cRODSTAR.Sections(i).Grade)) Then
						Dim grade3 As Integer = CInt(cRODSTAR.Sections(i).Grade)
						Dim num3 As Single = 0F
						text2 = RODUTIL.GetOtherSinkerbar(grade3, num3)
					ElseIf CUSTOMRG.IsOtherSteel(CInt(cRODSTAR.Sections(i).Grade)) Then
						Dim grade4 As Integer = CInt(cRODSTAR.Sections(i).Grade)
						Dim num3 As Single = 0F
						text2 = RODUTIL.GetOtherSteel(grade4, num3)
					ElseIf RODUTIL.IsCorodH(cRODSTAR.Sections(i).Grade) Then
						If CDbl(cRODSTAR.Sections(i).Area) < 0.7 Then
							text2 += " 682"
						Else
							text2 += " 757"
						End If
					ElseIf RODUTIL.IsProRod(CInt(cRODSTAR.Sections(i).Grade)) <> 0 Then
						If cRODSTAR.Sections(i).Grade = 24577S Then
							text2 = "Pro Rod 620"
						Else
							text2 = "Pro Rod 790"
						End If
					Else
						text2 = RODUTIL.RodGrade(cRODSTAR.Sections(i).Grade)
					End If
					text2 = Strings.Left(text2, 13)
					text2 = Strings.Space(13 - Strings.Len(text2) / 2) + text2
					If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
						Dim sections2 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
						Dim num5 As Integer = i
						Dim text7 As String = "0"
						text3 = Util.Format(sections2(num5).length, text7)
					Else
						Dim num3 As Single = cRODSTAR.Sections(i).length * RSWIN_DESC.FT__M
						Dim text7 As String = "0"
						text3 = Util.Format(num3, text7)
					End If
					If RODUTIL.IsAPI(CInt(cRODSTAR.Sections(i).Grade), cRODSTAR.Sections(i).RodType) Then
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							Dim num3 As Single = cRODSTAR.Sections(i).TensileStrength * RSWIN_DESC.PSI__KPA
							Dim text7 As String = "0"
							text5 = Util.Format(num3, text7)
						Else
							Dim sections3 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
							Dim num6 As Integer = i
							Dim text7 As String = "0"
							text5 = Util.Format(sections3(num6).TensileStrength, text7)
						End If
					Else
						Try
							If cRODSTAR.Sections(i).TensileStrength = 0F Then
								RODUTIL.LookupTensileStrength(cRODSTAR.Sections(i))
							End If
							If cRODSTAR.Sections(i).TensileStrength <> 0F Then
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									Dim num3 As Single = cRODSTAR.Sections(i).TensileStrength * RSWIN_DESC.PSI__KPA
									Dim text7 As String = "0"
									text5 = Util.Format(num3, text7)
								Else
									Dim sections4 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
									Dim num7 As Integer = i
									Dim text7 As String = "0"
									text5 = Util.Format(sections4(num7).TensileStrength, text7)
								End If
							Else
								text5 = Me.sNA
							End If
						Catch ex As Exception
							text5 = Me.sNA
						End Try
					End If
					LastHeight = Me.lblRodDiam1.Height
					Select Case i
						Case 1
							Me.lblRodDiam1.Text = text6 + text
							Me.lblRodGrade1.Text = text2
							Me.lblRodLength1.Text = text3
							Me.lblRodTensileStrength1.Text = text5
							LastTop = Me.lblRodDiam1.Top
						Case 2
							Me.lblRodDiam2.Text = text6 + text
							Me.lblRodGrade2.Text = text2
							Me.lblRodLength2.Text = text3
							Me.lblRodTensileStrength2.Text = text5
							LastTop = Me.lblRodDiam2.Top
						Case 3
							Me.lblRodDiam3.Text = text6 + text
							Me.lblRodGrade3.Text = text2
							Me.lblRodLength3.Text = text3
							Me.lblRodTensileStrength3.Text = text5
							LastTop = Me.lblRodDiam3.Top
						Case 4
							Me.lblRodDiam4.Text = text6 + text
							Me.lblRodGrade4.Text = text2
							Me.lblRodLength4.Text = text3
							Me.lblRodTensileStrength4.Text = text5
							LastTop = Me.lblRodDiam4.Top
						Case 5
							Me.lblRodDiam5.Text = text6 + text
							Me.lblRodGrade5.Text = text2
							Me.lblRodLength5.Text = text3
							Me.lblRodTensileStrength5.Text = text5
							LastTop = Me.lblRodDiam5.Top
						Case 6
							Me.lblRodDiam6.Text = text6 + text
							Me.lblRodGrade6.Text = text2
							Me.lblRodLength6.Text = text3
							Me.lblRodTensileStrength6.Text = text5
							LastTop = Me.lblRodDiam6.Top
						Case 7
							Me.lblRodDiam7.Text = text6 + text
							Me.lblRodGrade7.Text = text2
							Me.lblRodLength7.Text = text3
							Me.lblRodTensileStrength7.Text = text5
							LastTop = Me.lblRodDiam7.Top
						Case 8
							Me.lblRodDiam8.Text = text6 + text
							Me.lblRodGrade8.Text = text2
							Me.lblRodLength8.Text = text3
							Me.lblRodTensileStrength8.Text = text5
							LastTop = Me.lblRodDiam8.Top
						Case 9
							Me.lblRodDiam9.Text = text6 + text
							Me.lblRodGrade9.Text = text2
							Me.lblRodLength9.Text = text3
							Me.lblRodTensileStrength9.Text = text5
							LastTop = Me.lblRodDiam9.Top
						Case 10
							Me.lblRodDiam10.Text = text6 + text
							Me.lblRodGrade10.Text = text2
							Me.lblRodLength10.Text = text3
							Me.lblRodTensileStrength10.Text = text5
							LastTop = Me.lblRodDiam10.Top
					End Select

				text4 = String.Concat(New String() { text6, " ", text, Strings.Space(7 - Strings.Len(text)), "|", text2, Strings.Space(13 - Strings.Len(text2)), "|  ", text3, Strings.Space(6 - Strings.Len(text3)), "|     ", text5 })
				RESULTS1.Trx(text4, "|", ChrW(1))
			Next
			cRODSTAR = Nothing
		End Sub

		Private Sub MakeArray(iNum As Integer, ByRef myArray As Label(), lbl1 As Label, lbl2 As Label, Optional lbl3 As Label = Nothing, Optional lbl4 As Label = Nothing, Optional lbl5 As Label = Nothing, Optional lbl6 As Label = Nothing)
			' The following expression was wrapped in a checked-statement
			myArray = New Label(iNum - 1 + 1 - 1) {}
			Try
				myArray(0) = lbl1
				myArray(1) = lbl2
				For i As Integer = 3 To iNum
					Select Case i
						Case 3
							myArray(2) = lbl3
						Case 4
							myArray(3) = lbl4
						Case 5
							myArray(4) = lbl5
						Case 6
							myArray(5) = lbl6
					End Select
				Next
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowTrailer(ByRef cyTop As Single, ByRef avLabels1 As Label, ByRef avLabels2 As Label, ByRef avLabels3 As Label, ByRef avLabels4 As Label, ByRef avLabels5 As Label)
			Dim label As Label = New Label()
			Dim array As String() = New String(4) {}
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = False
			Try
				Dim text As String
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					text = Me.sAtSignMsg_M
				Else
					text = Me.sAtSignMsg
				End If
				Dim num As Long = 0L
				If Me.mbMsgFullOKNeeded And Me.mbMsgSlimNeededNeeded And Me.mbMsgNoNeckNeeded Then
					array(CInt(num)) = String.Concat(New String() { Me.sAsterickMsg, "      ", Me.sPlusMsg, "      ", Me.sPoundSignMsg })
					num += 1L
					flag = True
					flag2 = True
					flag4 = True
				ElseIf Me.mbMsgFullOKNeeded And Me.mbMsgSlimNeededNeeded Then
					array(CInt(num)) = Me.sAsterickMsg + "      " + Me.sPlusMsg
					num += 1L
					flag = True
					flag2 = True
				ElseIf Me.mbMsgFullOKNeeded And Me.mbMsgNoNeckNeeded Then
					array(CInt(num)) = Me.sAsterickMsg + "      " + Me.sPoundSignMsg
					num += 1L
					flag = True
					flag4 = True
				ElseIf Me.mbMsgSlimNeededNeeded And Me.mbMsgNoNeckNeeded Then
					array(CInt(num)) = Me.sPlusMsg + "      " + Me.sPoundSignMsg
					num += 1L
					flag2 = True
					flag4 = True
				ElseIf Me.mbMsgFullOKNeeded And Me.mbMsgElevatorNeck1_0Needed Then
					array(CInt(num)) = Me.sAsterickMsg + "      " + text
					num += 1L
					flag = True
					flag3 = True
				ElseIf Me.mbMsgSlimNeededNeeded And Me.mbMsgElevatorNeck1_0Needed Then
					array(CInt(num)) = Me.sPlusMsg + "      " + text
					num += 1L
					flag2 = True
					flag3 = True
				ElseIf Me.mbMsgNoNeckNeeded And Me.mbMsgElevatorNeck1_0Needed Then
					array(CInt(num)) = Me.sPoundSignMsg + "      " + text
					num += 1L
					flag4 = True
					flag3 = True
				End If
				If Me.mbMsgFullOKNeeded And Not flag Then
					array(CInt(num)) = Me.sAsterickMsg
					num += 1L
				End If
				If Me.mbMsgSlimNeededNeeded And Not flag2 Then
					array(CInt(num)) = Me.sPlusMsg
					num += 1L
				End If
				If Me.mbMsgElevatorNeck1_0Needed And Not flag3 Then
					array(CInt(num)) = text
					num += 1L
				End If
				If Me.mbMsgNoNeckNeeded And Not flag4 Then
					array(CInt(num)) = Me.sPoundSignMsg
					num += 1L
				End If
				If RSWIN_DESC.rst.gbIncludeBuoyancy Then
					array(CInt(num)) = Me.sNOTE1
				Else
					array(CInt(num)) = Me.sNOTE2
				End If
				num += 1L
				If Me.FiberodOverloaded() And num < 5L Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						array(CInt(num)) = RSWIN_DESC.sMaxFiberodStressWarning_Meter
					Else
						array(CInt(num)) = RSWIN_DESC.sMaxFiberodStressWarning_English
					End If
					num += 1L
				ElseIf Me.FibercoOverloaded() And num < 5L Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						array(CInt(num)) = RSWIN_DESC.sMaxFibercoStressWarning_Meter
					Else
						array(CInt(num)) = RSWIN_DESC.sMaxFibercoStressWarning_English
					End If
					num += 1L
				End If
				If Me.FiberodUnderloaded() And num < 5L Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						array(CInt(num)) = RSWIN_DESC.sMinFiberodStressWarning_Meter
					Else
						array(CInt(num)) = RSWIN_DESC.sMinFiberodStressWarning_English
					End If
					num += 1L
				ElseIf Me.FibercoUnderloaded() And num < 5L Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						array(CInt(num)) = RSWIN_DESC.sMinFibercoStressWarning_Meter
					Else
						array(CInt(num)) = RSWIN_DESC.sMinFibercoStressWarning_English
					End If
					num += 1L
				End If
				Dim num2 As Long = 1L
				Dim num3 As Long = num
				For num4 As Long = num2 To num3
					Dim num5 As Long = num4
					If num5 <= 5L AndAlso num5 >= 1L Then
						' The following expression was wrapped in a unchecked-expression
						Select Case CInt((num5 - 1L))
							Case 0
								label = avLabels1
							Case 1
								label = avLabels2
							Case 2
								label = avLabels3
							Case 3
								label = avLabels4
							Case 4
								label = avLabels5
						End Select
					End If
					Dim label2 As Label = label
					label2.Text = array(CInt((num4 - 1L)))
					label2.Top = cyTop
					label2.Visible = True

						cyTop += label2.Height

					If Strings.InStr(array(CInt((num4 - 1L))), "Fiberod", CompareMethod.Binary) > 0 Then
						label2.ForeColor = Color.Red
					Else
						label2.ForeColor = Color.Black
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Sub SetLabelColorMinStressBot(Index As Integer)
			Try
				Dim foreColor As Color = Color.Red
				If(Index = CInt(RSWIN_DESC.rst.NumRods) And RSWIN_DESC.rst.NumRods > 1S) AndAlso RSWIN_DESC.rst.Sections(Index).Diameter > RSWIN_DESC.rst.Sections(Index - 1).Diameter Then
					foreColor = Color.Black
				End If
				Select Case Index
					Case 1
						Me.lblRodBotMinStress1.ForeColor = foreColor
					Case 2
						Me.lblRodBotMinStress2.ForeColor = foreColor
					Case 3
						Me.lblRodBotMinStress3.ForeColor = foreColor
					Case 4
						Me.lblRodBotMinStress4.ForeColor = foreColor
					Case 5
						Me.lblRodBotMinStress5.ForeColor = foreColor
					Case 6
						Me.lblRodBotMinStress6.ForeColor = foreColor
					Case 7
						Me.lblRodBotMinStress7.ForeColor = foreColor
					Case 8
						Me.lblRodBotMinStress8.ForeColor = foreColor
					Case 9
						Me.lblRodBotMinStress9.ForeColor = foreColor
					Case 10
						Me.lblRodBotMinStress10.ForeColor = foreColor
				End Select
			Catch ex As Exception
			End Try
		End Sub

		Public Sub SetRodStringGridVisible(bValue As Boolean)
			Me.lblRodDiamHdrTop.Visible = bValue
			Me.lblRodDiamHdrBot.Visible = bValue
			Me.lblRodDiam1.Visible = bValue
			Me.lblRodGradeHdrBot.Visible = bValue
			Me.lblRodLengthHdrBot.Visible = bValue
			Me.lblRodTensileStrengthHdrBot.Visible = bValue
			Me.lblRodStringDesign.Visible = bValue
			Me.lblRodLengthHdrTop.Visible = bValue
			Me.lblRodTensileStrengthHdrTop.Visible = bValue
			Me.lblFric.Visible = bValue
			Me.lblRodStressHdrTop.Visible = bValue
			Me.lblRodTopMaxStressHdrTop.Visible = bValue
			Me.lblRodTopMinStressHdrTop.Visible = bValue
			Me.lblRodBotMinStressHdrTop.Visible = bValue
			Me.lblRodStressMethodHdrTop.Visible = bValue
			Me.lblRodGradeHdrTop.Visible = bValue
			Me.lblCoeff.Visible = bValue
			Me.lblRodDiam1.Visible = bValue
			Me.lblRodDiam2.Visible = bValue
			Me.lblRodDiam3.Visible = bValue
			Me.lblRodDiam4.Visible = bValue
			Me.lblRodDiam5.Visible = bValue
			Me.lblRodDiam6.Visible = bValue
			Me.lblRodDiam7.Visible = bValue
			Me.lblRodDiam8.Visible = bValue
			Me.lblRodDiam9.Visible = bValue
			Me.lblRodDiam10.Visible = bValue
			Me.lblRodGrade1.Visible = bValue
			Me.lblRodGrade2.Visible = bValue
			Me.lblRodGrade3.Visible = bValue
			Me.lblRodGrade4.Visible = bValue
			Me.lblRodGrade5.Visible = bValue
			Me.lblRodGrade6.Visible = bValue
			Me.lblRodGrade7.Visible = bValue
			Me.lblRodGrade8.Visible = bValue
			Me.lblRodGrade9.Visible = bValue
			Me.lblRodGrade10.Visible = bValue
			Me.lblRodLength1.Visible = bValue
			Me.lblRodLength2.Visible = bValue
			Me.lblRodLength3.Visible = bValue
			Me.lblRodLength4.Visible = bValue
			Me.lblRodLength5.Visible = bValue
			Me.lblRodLength6.Visible = bValue
			Me.lblRodLength7.Visible = bValue
			Me.lblRodLength8.Visible = bValue
			Me.lblRodLength9.Visible = bValue
			Me.lblRodLength10.Visible = bValue
			Me.lblRodTensileStrength1.Visible = bValue
			Me.lblRodTensileStrength2.Visible = bValue
			Me.lblRodTensileStrength3.Visible = bValue
			Me.lblRodTensileStrength4.Visible = bValue
			Me.lblRodTensileStrength5.Visible = bValue
			Me.lblRodTensileStrength6.Visible = bValue
			Me.lblRodTensileStrength7.Visible = bValue
			Me.lblRodTensileStrength8.Visible = bValue
			Me.lblRodTensileStrength9.Visible = bValue
			Me.lblRodTensileStrength10.Visible = bValue
			Me.lblRodStringResults.Visible = bValue
			Me.lblRodStressHdrBot.Visible = bValue
			Me.lblRodStress1.Visible = bValue
			Me.lblRodTopMaxStressHdrBot.Visible = bValue
			Me.lblRodTopMinStressHdrBot.Visible = bValue
			Me.lblRodBotMinStressHdrBot.Visible = bValue
			Me.lblRodStress2.Visible = bValue
			Me.lblRodStress3.Visible = bValue
			Me.lblRodStress4.Visible = bValue
			Me.lblRodStress5.Visible = bValue
			Me.lblRodStress6.Visible = bValue
			Me.lblRodStress7.Visible = bValue
			Me.lblRodStress8.Visible = bValue
			Me.lblRodStress9.Visible = bValue
			Me.lblRodStress10.Visible = bValue
			Me.lblRodTopMaxStress1.Visible = bValue
			Me.lblRodTopMaxStress2.Visible = bValue
			Me.lblRodTopMaxStress3.Visible = bValue
			Me.lblRodTopMaxStress4.Visible = bValue
			Me.lblRodTopMaxStress5.Visible = bValue
			Me.lblRodTopMaxStress6.Visible = bValue
			Me.lblRodTopMaxStress7.Visible = bValue
			Me.lblRodTopMaxStress8.Visible = bValue
			Me.lblRodTopMaxStress9.Visible = bValue
			Me.lblRodTopMaxStress10.Visible = bValue
			Me.lblRodTopMinStress1.Visible = bValue
			Me.lblRodTopMinStress2.Visible = bValue
			Me.lblRodTopMinStress3.Visible = bValue
			Me.lblRodTopMinStress4.Visible = bValue
			Me.lblRodTopMinStress5.Visible = bValue
			Me.lblRodTopMinStress6.Visible = bValue
			Me.lblRodTopMinStress7.Visible = bValue
			Me.lblRodTopMinStress8.Visible = bValue
			Me.lblRodTopMinStress9.Visible = bValue
			Me.lblRodTopMinStress10.Visible = bValue
			Me.lblRodBotMinStress1.Visible = bValue
			Me.lblRodBotMinStress2.Visible = bValue
			Me.lblRodBotMinStress3.Visible = bValue
			Me.lblRodBotMinStress4.Visible = bValue
			Me.lblRodBotMinStress5.Visible = bValue
			Me.lblRodBotMinStress6.Visible = bValue
			Me.lblRodBotMinStress7.Visible = bValue
			Me.lblRodBotMinStress8.Visible = bValue
			Me.lblRodBotMinStress9.Visible = bValue
			Me.lblRodBotMinStress10.Visible = bValue
			Me.lblRodStressMethodHdrBot.Visible = bValue
			Me.lblRodStressMethod1.Visible = bValue
			Me.lblRodStressMethod2.Visible = bValue
			Me.lblRodStressMethod3.Visible = bValue
			Me.lblRodStressMethod4.Visible = bValue
			Me.lblRodStressMethod5.Visible = bValue
			Me.lblRodStressMethod6.Visible = bValue
			Me.lblRodStressMethod7.Visible = bValue
			Me.lblRodStressMethod8.Visible = bValue
			Me.lblRodStressMethod9.Visible = bValue
			Me.lblRodStressMethod10.Visible = bValue
			Me.linRSInputSep1.Visible = bValue
			Me.linRSInputSep2.Visible = bValue
			Me.linRSInputSep3.Visible = bValue
			Me.linRSInputSep4.Visible = bValue
			Me.linDivider.Visible = bValue
			Me.linRSCalcSep1.Visible = bValue
			Me.linRSCalcSep2.Visible = bValue
			Me.linRSCalcSep3.Visible = bValue
			Me.linRSCalcSep4.Visible = bValue
			Me.Line11.Visible = bValue
			Me.Line13.Visible = bValue
			Me.Line12.Visible = bValue
			Me.Line14.Visible = bValue
			Me.lblRodDiam11.Visible = bValue
			Me.lblRodDiam12.Visible = bValue
			Me.lblRodDiam13.Visible = bValue
			Me.lblRodDiam14.Visible = bValue
			Me.lblRodDiam15.Visible = bValue
			Me.lblRodDiam16.Visible = bValue
			Me.lblRodDiam17.Visible = bValue
			Me.lblRodDiam18.Visible = bValue
			Me.lblRodDiam19.Visible = bValue
			Me.lblRodDiam20.Visible = bValue
			Me.lblRodGrade11.Visible = bValue
			Me.lblRodGrade12.Visible = bValue
			Me.lblRodGrade13.Visible = bValue
			Me.lblRodGrade14.Visible = bValue
			Me.lblRodGrade15.Visible = bValue
			Me.lblRodGrade16.Visible = bValue
			Me.lblRodGrade17.Visible = bValue
			Me.lblRodGrade18.Visible = bValue
			Me.lblRodGrade19.Visible = bValue
			Me.lblRodGrade20.Visible = bValue
			Me.lblRodLength11.Visible = bValue
			Me.lblRodLength12.Visible = bValue
			Me.lblRodLength13.Visible = bValue
			Me.lblRodLength14.Visible = bValue
			Me.lblRodLength15.Visible = bValue
			Me.lblRodLength16.Visible = bValue
			Me.lblRodLength17.Visible = bValue
			Me.lblRodLength18.Visible = bValue
			Me.lblRodLength19.Visible = bValue
			Me.lblRodLength20.Visible = bValue
			Me.lblRodTensileStrength11.Visible = bValue
			Me.lblRodTensileStrength12.Visible = bValue
			Me.lblRodTensileStrength13.Visible = bValue
			Me.lblRodTensileStrength14.Visible = bValue
			Me.lblRodTensileStrength15.Visible = bValue
			Me.lblRodTensileStrength16.Visible = bValue
			Me.lblRodTensileStrength17.Visible = bValue
			Me.lblRodTensileStrength18.Visible = bValue
			Me.lblRodTensileStrength19.Visible = bValue
			Me.lblRodTensileStrength20.Visible = bValue
			Me.lblRodStress11.Visible = bValue
			Me.lblRodStress12.Visible = bValue
			Me.lblRodStress13.Visible = bValue
			Me.lblRodStress14.Visible = bValue
			Me.lblRodStress15.Visible = bValue
			Me.lblRodStress16.Visible = bValue
			Me.lblRodStress17.Visible = bValue
			Me.lblRodStress18.Visible = bValue
			Me.lblRodStress19.Visible = bValue
			Me.lblRodStress20.Visible = bValue
			Me.lblRodTopMaxStress11.Visible = bValue
			Me.lblRodTopMaxStress12.Visible = bValue
			Me.lblRodTopMaxStress13.Visible = bValue
			Me.lblRodTopMaxStress14.Visible = bValue
			Me.lblRodTopMaxStress15.Visible = bValue
			Me.lblRodTopMaxStress16.Visible = bValue
			Me.lblRodTopMaxStress17.Visible = bValue
			Me.lblRodTopMaxStress18.Visible = bValue
			Me.lblRodTopMaxStress19.Visible = bValue
			Me.lblRodTopMaxStress20.Visible = bValue
			Me.lblRodTopMinStress11.Visible = bValue
			Me.lblRodTopMinStress12.Visible = bValue
			Me.lblRodTopMinStress13.Visible = bValue
			Me.lblRodTopMinStress14.Visible = bValue
			Me.lblRodTopMinStress15.Visible = bValue
			Me.lblRodTopMinStress16.Visible = bValue
			Me.lblRodTopMinStress17.Visible = bValue
			Me.lblRodTopMinStress18.Visible = bValue
			Me.lblRodTopMinStress19.Visible = bValue
			Me.lblRodTopMinStress20.Visible = bValue
			Me.lblRodBotMinStress11.Visible = bValue
			Me.lblRodBotMinStress12.Visible = bValue
			Me.lblRodBotMinStress13.Visible = bValue
			Me.lblRodBotMinStress14.Visible = bValue
			Me.lblRodBotMinStress15.Visible = bValue
			Me.lblRodBotMinStress16.Visible = bValue
			Me.lblRodBotMinStress17.Visible = bValue
			Me.lblRodBotMinStress18.Visible = bValue
			Me.lblRodBotMinStress19.Visible = bValue
			Me.lblRodBotMinStress20.Visible = bValue
			Me.lblRodStressMethod11.Visible = bValue
			Me.lblRodStressMethod12.Visible = bValue
			Me.lblRodStressMethod13.Visible = bValue
			Me.lblRodStressMethod14.Visible = bValue
			Me.lblRodStressMethod15.Visible = bValue
			Me.lblRodStressMethod16.Visible = bValue
			Me.lblRodStressMethod17.Visible = bValue
			Me.lblRodStressMethod18.Visible = bValue
			Me.lblRodStressMethod19.Visible = bValue
			Me.lblRodStressMethod20.Visible = bValue
		End Sub

		Private Sub CheckForWellInfoComment(ByRef sCoverPageComment As String)
			Try
				Dim num As Integer = Strings.InStr(sCoverPageComment, "< Insert Well Information Comment Here >", CompareMethod.Binary)
				If num > 0 Then
					If Operators.CompareString(RSWIN_DESC.rst.FileComment.Trim(), "", False) <> 0 Then
						Dim text As String = sCoverPageComment.Replace("< Insert Well Information Comment Here >", " ")
						text = text.Substring(0, num - 1) + RSWIN_DESC.rst.FileComment + text.Substring(num)
						sCoverPageComment = text
					Else
						sCoverPageComment = sCoverPageComment.Replace("< Insert Well Information Comment Here >", " ")
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub CheckForSetupComment(ByRef sCoverPageComment As String)
			Try
				Dim text As String = ""
				Dim flag As Boolean = False
				Dim num As Integer = Strings.InStr(sCoverPageComment, "< Insert Setup / Defaults Comment Here >", CompareMethod.Binary)
				If num > 0 Then
					Dim text2 As String = "SecondCompanyComments"
					Dim text3 As String = ""
					Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, text3, text, False)
					Dim text4 As String = text.Substring(0, regProfileString)
					If text4 IsNot Nothing AndAlso Operators.CompareString(text4.Trim(), "", False) <> 0 Then
						num = Strings.InStr(sCoverPageComment, "< Insert Setup / Defaults Comment Here >", CompareMethod.Binary)
						Dim text5 As String = sCoverPageComment.Replace("< Insert Setup / Defaults Comment Here >", " ")
						text5 = text5.Substring(0, num - 1) + text4 + text5.Substring(num)
						sCoverPageComment = text5
						flag = True
					End If
				End If
				If num > 0 And Not flag Then
					sCoverPageComment = sCoverPageComment.Replace("< Insert Setup / Defaults Comment Here >", " ")
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Function CheckForRodStringDesign(ByRef sCoverPageComment As String, ByRef sBeforeComment As String, ByRef sAfterComment As String) As Boolean
			Dim result As Boolean
			Try
				Dim text As String = "< Insert Rod String Information Here >"
				Dim text2 As String = sCoverPageComment
				Dim num As Integer = Strings.InStr(text2, text, CompareMethod.Binary)
				If num > 0 Then
					sBeforeComment = text2.Replace(text, " ")
					text2 = sBeforeComment
					sBeforeComment = text2.Substring(0, num - 1)
					sAfterComment = text2.Substring(num)
					If Operators.CompareString(sAfterComment.Trim(), "", False) = 0 Then
						sAfterComment = ""
					End If
					Me.m_LastTop = Me.rtbSecondCompanyComments.Top + Me.rtbSecondCompanyComments.Height
					Me.ShowRSInput()
					Me.ShowRSCalc()
					Try
						num = Strings.InStr(sCoverPageComment, text, CompareMethod.Binary)
						If num > 0 Then
							sCoverPageComment = sCoverPageComment.Replace(text, " ")
						End If
					Catch ex As Exception
					End Try
					result = True
				Else
					sBeforeComment = ""
					sAfterComment = ""
					Me.SetRodStringGridVisible(False)
					result = False
				End If
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Private Sub PopulateCoverPageComment()
			Try
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				Dim text As String = ""
				Dim text2 As String = ""
				Dim text3 As String = ""
				text = RSWIN_DESC.rst.CoverPageComment
				Dim num As Integer = Strings.InStr(text, "< Insert Well Information Comment Here >", CompareMethod.Binary)
				Dim num2 As Integer = Strings.InStr(text, "< Insert Rod String Information Here >", CompareMethod.Binary)
				Dim num3 As Integer = Strings.InStr(text, "< Insert Setup / Defaults Comment Here >", CompareMethod.Binary)
				Me.rtbSecondCompanyComments.Text = ""
				Me.rtbSecondCompanyComments2.Text = ""
				Me.rtbSecondCompanyComments2.Visible = False
				If num = 0 And num2 = 0 And num3 = 0 Then
					Me.CheckEndOfString(text)
					If Strings.Asc(text.Substring(0, 1)) = 10 Then
						Me.rtbSecondCompanyComments.Text = " " + text + " "
					Else
						Me.rtbSecondCompanyComments.Text = text + " "
					End If
					Me.SetRodStringGridVisible(False)
				ElseIf num2 = 0 Then
					Me.SetRodStringGridVisible(False)
					If num <> 0 And num3 = 0 Then
						Me.CheckForWellInfoComment(text)
					ElseIf num3 <> 0 And num = 0 Then
						Me.CheckForSetupComment(text)
					ElseIf num < num3 Then
						Me.CheckForWellInfoComment(text)
						Me.CheckForSetupComment(text)
					Else
						Me.CheckForSetupComment(text)
						Me.CheckForWellInfoComment(text)
					End If
					If Operators.CompareString(text.Trim(), "", False) <> 0 Then
						Me.CheckEndOfString(text)
						If Strings.Asc(text.Substring(0, 1)) = 10 Then
							Me.rtbSecondCompanyComments.Text = " " + text + " "
						Else
							Me.rtbSecondCompanyComments.Text = text + " "
						End If
					End If
				Else
					If(num <> 0 And num3 <> 0 And (num2 < num And num2 < num3)) Or (num <> 0 And num3 = 0 And num2 < num) Or (num3 <> 0 And num = 0 And num2 < num3) Then
						flag = True
					ElseIf(num <> 0 And num3 <> 0 And (num2 > num And num2 > num3)) Or (num <> 0 And num3 = 0 And num2 > num) Or (num3 <> 0 And num = 0 And num2 > num3) Then
						flag3 = True
					Else
						flag2 = True
					End If
					If flag Then
						Dim flag4 As Boolean = Me.CheckForRodStringDesign(text, text2, text3)
						If flag4 Then
							If Operators.CompareString(text2.Trim(), "", False) <> 0 Then
								Me.CheckEndOfString(text2)
								If Strings.Asc(text2.Substring(0, 1)) = 10 Then
									Me.rtbSecondCompanyComments.Text = " " + text2 + " "
								Else
									Me.rtbSecondCompanyComments.Text = text2 + " "
								End If
							End If
							If Operators.CompareString(text3.Trim(), "", False) <> 0 Then
								text = text3
							End If
						End If
						If num < num3 Then
							Me.CheckForWellInfoComment(text)
							Me.CheckForSetupComment(text)
						Else
							Me.CheckForSetupComment(text)
							Me.CheckForWellInfoComment(text)
						End If
						If Operators.CompareString(text.Trim(), "", False) <> 0 Then
							Me.CheckEndOfString(text)
							If Strings.Asc(text.Substring(0, 1)) = 10 Then
								Me.rtbSecondCompanyComments2.Text = " " + text + " "
							Else
								Me.rtbSecondCompanyComments2.Text = text + " "
							End If
							Me.rtbSecondCompanyComments2.Top = Me.m_LastTop
							Me.rtbSecondCompanyComments2.Visible = True
						End If
					ElseIf flag3 Then
						If num < num3 Then
							Me.CheckForWellInfoComment(text)
							Me.CheckForSetupComment(text)
						Else
							Me.CheckForSetupComment(text)
							Me.CheckForWellInfoComment(text)
						End If
						Dim flag4 As Boolean = Me.CheckForRodStringDesign(text, text2, text3)
						If flag4 Then
							If Operators.CompareString(text2.Trim(), "", False) <> 0 Then
								Me.CheckEndOfString(text2)
								If Strings.Asc(text2.Substring(0, 1)) = 10 Then
									Me.rtbSecondCompanyComments.Text = " " + text2 + " "
								Else
									Me.rtbSecondCompanyComments.Text = text2 + " "
								End If
							End If
							If Operators.CompareString(text3.Trim(), "", False) <> 0 Then
								Me.CheckEndOfString(text3)
								If Strings.Asc(text3.Substring(0, 1)) = 10 Then
									Me.rtbSecondCompanyComments2.Text = " " + text3 + " "
								Else
									Me.rtbSecondCompanyComments2.Text = text3 + " "
								End If
								Me.rtbSecondCompanyComments2.Top = Me.m_LastTop
								Me.rtbSecondCompanyComments2.Visible = True
							End If
						ElseIf Operators.CompareString(text.Trim(), "", False) <> 0 Then
							Me.CheckEndOfString(text)
							If Strings.Asc(text.Substring(0, 1)) = 10 Then
								Me.rtbSecondCompanyComments.Text = " " + text + " "
							Else
								Me.rtbSecondCompanyComments.Text = text + " "
							End If
						End If
					ElseIf flag2 Then
						If num < num3 Then
							Me.CheckForWellInfoComment(text)
							Dim flag4 As Boolean = Me.CheckForRodStringDesign(text, text2, text3)
							If Operators.CompareString(text2.Trim(), "", False) <> 0 Then
								Me.CheckEndOfString(text2)
								If Strings.Asc(text2.Substring(0, 1)) = 10 Then
									Me.rtbSecondCompanyComments.Text = " " + text2 + " "
								Else
									Me.rtbSecondCompanyComments.Text = text2 + " "
								End If
								If Operators.CompareString(text3.Trim(), "", False) <> 0 Then
									text = text3
								End If
							End If
							Me.CheckForSetupComment(text)
							If Operators.CompareString(text.Trim(), "", False) <> 0 Then
								Me.CheckEndOfString(text)
								If Strings.Asc(text.Substring(0, 1)) = 10 Then
									Me.rtbSecondCompanyComments2.Text = " " + text + " "
								Else
									Me.rtbSecondCompanyComments2.Text = text + " "
								End If
								Me.rtbSecondCompanyComments2.Top = Me.m_LastTop
								Me.rtbSecondCompanyComments2.Visible = True
							End If
						Else
							Me.CheckForSetupComment(text)
							Dim flag4 As Boolean = Me.CheckForRodStringDesign(text, text2, text3)
							If Operators.CompareString(text2.Trim(), "", False) <> 0 Then
								Me.CheckEndOfString(text2)
								If Strings.Asc(text2.Substring(0, 1)) = 10 Then
									Me.rtbSecondCompanyComments.Text = " " + text2 + " "
								Else
									Me.rtbSecondCompanyComments.Text = text2 + " "
								End If
								text = text3
							End If
							Me.CheckForWellInfoComment(text)
							If Operators.CompareString(text.Trim(), "", False) <> 0 Then
								Me.CheckEndOfString(text)
								If Strings.Asc(text.Substring(0, 1)) = 10 Then
									Me.rtbSecondCompanyComments2.Text = " " + text + " "
								Else
									Me.rtbSecondCompanyComments2.Text = text + " "
								End If
								Me.rtbSecondCompanyComments2.Top = Me.m_LastTop
								Me.rtbSecondCompanyComments2.Visible = True
							End If
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub CheckEndOfString(ByRef sCoverPageComment As String)
			' The following expression was wrapped in a checked-statement
			Try
				If sCoverPageComment.Length > 2 AndAlso Strings.Asc(sCoverPageComment.Substring(sCoverPageComment.Length - 1, 1)) = 10 Then
					sCoverPageComment = sCoverPageComment.Substring(0, sCoverPageComment.Length - 1)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function FibercoOverloaded() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If RSWIN_DESC.rst.Sections(i).Grade = 16396S Then
						Dim num2 As Single = RSWIN_DESC.rst.minStressBot(i)
						If RSWIN_DESC.rst.Sections(i).Grade = 16396S And num2 >= 35000F Then
							flag = True
							Exit For
						End If
						num2 = RSWIN_DESC.rst.maxStressTop(i)
						If RSWIN_DESC.rst.Sections(i).Grade = 16396S And num2 >= 35000F Then
							flag = True
							Exit For
						End If
						num2 = RSWIN_DESC.rst.minStressTop(i)
						If RSWIN_DESC.rst.Sections(i).Grade = 16396S And num2 >= 35000F Then
							flag = True
							Exit For
						End If
					End If
				Next
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function FiberodOverloaded() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If RSWIN_DESC.rst.Sections(i).Grade = 16391S Then
						Dim num2 As Single = RSWIN_DESC.rst.minStressBot(i)
						If RSWIN_DESC.rst.Sections(i).Grade = 16391S And num2 > 27500F Then
							flag = True
							Exit For
						End If
						num2 = RSWIN_DESC.rst.maxStressTop(i)
						If RSWIN_DESC.rst.Sections(i).Grade = 16391S And num2 > 27500F Then
							flag = True
							Exit For
						End If
						num2 = RSWIN_DESC.rst.minStressTop(i)
						If RSWIN_DESC.rst.Sections(i).Grade = 16391S And num2 > 27500F Then
							flag = True
							Exit For
						End If
					End If
				Next
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function FiberodUnderloaded() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If RSWIN_DESC.rst.Sections(i).Grade = 16393S Then
						Dim num2 As Single = RSWIN_DESC.rst.minStressBot(i)
						If RSWIN_DESC.rst.Sections(i).Grade = 16393S And num2 < 1250F Then
							flag = True
							Exit For
						End If
						num2 = RSWIN_DESC.rst.maxStressTop(i)
						If RSWIN_DESC.rst.Sections(i).Grade = 16393S And num2 < 1250F Then
							flag = True
							Exit For
						End If
						num2 = RSWIN_DESC.rst.minStressTop(i)
						If RSWIN_DESC.rst.Sections(i).Grade = 16393S And num2 < 1250F Then
							flag = True
							Exit For
						End If
					End If
				Next
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Sub SetStressLabelColor(fVal As Single, ByRef Label1 As Label, Indx As Integer)
			Try
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 And fVal * RSWIN_DESC.PSI__KPA < 0F Then
					Label1.ForeColor = Color.Red
				ElseIf fVal < 0F Then
					Label1.ForeColor = Color.Red
				ElseIf RSWIN_DESC.rst.Sections(Indx).Grade = 16391S And ((RSWIN_DESC.SETUP_MeasurementSystem <> 3 And fVal > 27500F) Or (RSWIN_DESC.SETUP_MeasurementSystem = 3 And fVal > 27500F * RSWIN_DESC.PSI__KPA)) Then
					Label1.ForeColor = Color.Red
				Else
					Label1.ForeColor = Color.Black
				End If
				Try
					' The following expression was wrapped in a checked-expression
					If(Indx = CInt(RSWIN_DESC.rst.NumRods) And RSWIN_DESC.rst.NumRods > 1S And Strings.InStr(Label1.Name, "lblRodBotMinStress", CompareMethod.Binary) > 0) AndAlso RSWIN_DESC.rst.Sections(Indx).Diameter > RSWIN_DESC.rst.Sections(Indx - 1).Diameter Then
						Label1.ForeColor = Color.Black
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Public Function FibercoUnderloaded() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If RSWIN_DESC.rst.Sections(i).Grade = 16396S Then
						Dim num2 As Single = RSWIN_DESC.rst.minStressBot(i)
						If RSWIN_DESC.rst.Sections(i).Grade = 16396S And num2 < 1000F Then
							flag = True
							Exit For
						End If
						num2 = RSWIN_DESC.rst.maxStressTop(i)
						If RSWIN_DESC.rst.Sections(i).Grade = 16396S And num2 < 1000F Then
							flag = True
							Exit For
						End If
						num2 = RSWIN_DESC.rst.minStressTop(i)
						If RSWIN_DESC.rst.Sections(i).Grade = 16396S And num2 < 1000F Then
							flag = True
							Exit For
						End If
					End If
				Next
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private mbCorodSEString As Boolean

		Private mbMsgElevatorNeck1_0Needed As Boolean

		Private mbMsgFullOKNeeded As Boolean

		Private mbMsgNoNeckNeeded As Boolean

		Private mbMsgSlimNeededNeeded As Boolean

		Private sThetaEnterprises As String

		Private sElevatorNeck As String

		Private sAsterickMsg As String

		Private sPlusMsg As String

		Private sAtSignMsg As String

		Private sAtSignMsg_M As String

		Private sPoundSignMsg As String

		Private sNOTE1 As String

		Private sNOTE2 As String

		Public sNumGuides As String

		Public sStressCalc As String

		Public sMethod As String

		Private sNA As String

		Private slbl As String

		Private Const LD_VBAR As Integer = 1

		Private m_LastTop As Single

		Private m_LastHeight As Single

		<AccessedThroughProperty("PageHeader")>
		Private _PageHeader As PageHeader

		<AccessedThroughProperty("Detail")>
		Private _Detail As Detail

		<AccessedThroughProperty("PageFooter")>
		Private _PageFooter As PageFooter

		Private lblAddr1 As Label

		Private lblAddr2 As Label

		Private imgLogo As Picture

		Private lblSecondCompanyContactName As Label

		Private lblSecondCompanyPhone As Label

		Private lblPage As Label

		Private txtPage1 As TextBox

		Private lblOf As Label

		Private txtPage2 As TextBox

		Private lblUserDate As Label

		Private Line1 As Line

		Private Line3 As Line

		Private lblAddress As Label

		Private Line4 As Line

		Private Line5 As Line

		Private rtbSecondCompanyComments As RichTextBox

		Private txtCustomerCompany As TextBox

		Private txtCustomerName As TextBox

		Private lblComments As TextBox

		Private lblRSFootnote5 As Label

		Private lblRSFootnote4 As Label

		Private lblRSFootnote3 As Label

		Private lblRSFootnote2 As Label

		Private lblRSFootnote1 As Label

		Private linRSInputSep4 As Line

		Private linRSInputSep1 As Line

		Private linDivider As Line

		Private linRSInputSep3 As Line

		Private lblRodStringDesign As Label

		Private Line11 As Line

		Private lblRodDiamHdrTop As Label

		Private lblRodDiamHdrBot As Label

		Private lblRodDiam1 As Label

		Private lblRodGradeHdrBot As Label

		Private lblRodLengthHdrBot As Label

		Private lblRodTensileStrengthHdrBot As Label

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

		Private lblRodTensileStrength1 As Label

		Private lblRodTensileStrength2 As Label

		Private lblRodTensileStrength3 As Label

		Private lblRodTensileStrength4 As Label

		Private lblRodTensileStrength5 As Label

		Private lblRodTensileStrength6 As Label

		Private lblRodTensileStrength7 As Label

		Private lblRodTensileStrength8 As Label

		Private lblRodStringResults As Label

		Private Line13 As Line

		Private lblRodStressHdrBot As Label

		Private lblRodStress1 As Label

		Private lblRodTopMaxStressHdrBot As Label

		Private lblRodTopMinStressHdrBot As Label

		Private lblRodBotMinStressHdrBot As Label

		Private Line14 As Line

		Private lblRodStress2 As Label

		Private lblRodStress3 As Label

		Private lblRodStress4 As Label

		Private lblRodStress5 As Label

		Private lblRodStress6 As Label

		Private lblRodStress7 As Label

		Private lblRodStress8 As Label

		Private lblRodTopMaxStress1 As Label

		Private lblRodTopMaxStress2 As Label

		Private lblRodTopMaxStress3 As Label

		Private lblRodTopMaxStress4 As Label

		Private lblRodTopMaxStress5 As Label

		Private lblRodTopMaxStress6 As Label

		Private lblRodTopMaxStress7 As Label

		Private lblRodTopMaxStress8 As Label

		Private lblRodTopMinStress1 As Label

		Private lblRodTopMinStress2 As Label

		Private lblRodTopMinStress3 As Label

		Private lblRodTopMinStress4 As Label

		Private lblRodTopMinStress5 As Label

		Private lblRodTopMinStress6 As Label

		Private lblRodTopMinStress7 As Label

		Private lblRodTopMinStress8 As Label

		Private lblRodBotMinStress1 As Label

		Private lblRodBotMinStress2 As Label

		Private lblRodBotMinStress3 As Label

		Private lblRodBotMinStress4 As Label

		Private lblRodBotMinStress5 As Label

		Private lblRodBotMinStress6 As Label

		Private lblRodBotMinStress7 As Label

		Private lblRodBotMinStress8 As Label

		Private lblRodStressMethodHdrBot As Label

		Private lblRodStressMethod1 As Label

		Private lblRodStressMethod2 As Label

		Private lblRodStressMethod3 As Label

		Private lblRodStressMethod4 As Label

		Private lblRodStressMethod5 As Label

		Private lblRodStressMethod6 As Label

		Private lblRodStressMethod7 As Label

		Private lblRodStressMethod8 As Label

		Private lblRodGradeHdrTop As Label

		Private lblRodTopMinStressHdrTop As Label

		Private lblRodBotMinStressHdrTop As Label

		Private lblRodStressMethodHdrTop As Label

		Private lblRodTopMaxStressHdrTop As Label

		Private lblRodStressHdrTop As Label

		Private lblRodTensileStrengthHdrTop As Label

		Private lblRodLengthHdrTop As Label

		Private linRSCalcSep3 As Line

		Private linRSCalcSep1 As Line

		Private linRSCalcSep2 As Line

		Private linRSCalcSep4 As Line

		Private lblFricCoef1 As Label

		Private lblFricCoef2 As Label

		Private lblFricCoef3 As Label

		Private lblFricCoef4 As Label

		Private lblFricCoef5 As Label

		Private lblFricCoef6 As Label

		Private lblFricCoef7 As Label

		Private lblFricCoef8 As Label

		Private lblFric As Label

		Private lblCoeff As Label

		Private lblRodDiam9 As Label

		Private lblRodGrade9 As Label

		Private lblRodLength9 As Label

		Private lblRodTensileStrength9 As Label

		Private lblFricCoef9 As Label

		Private lblRodStress9 As Label

		Private lblRodTopMaxStress9 As Label

		Private lblRodTopMinStress9 As Label

		Private lblRodBotMinStress9 As Label

		Private lblRodStressMethod9 As Label

		Private lblRodDiam10 As Label

		Private lblRodGrade10 As Label

		Private lblRodLength10 As Label

		Private lblRodTensileStrength10 As Label

		Private lblFricCoef10 As Label

		Private lblRodStress10 As Label

		Private lblRodTopMaxStress10 As Label

		Private lblRodTopMinStress10 As Label

		Private lblRodBotMinStress10 As Label

		Private lblRodStressMethod10 As Label

		Private linRSInputSep2 As Line

		Private rtbSecondCompanyComments2 As RichTextBox

		Private lblFootnote As Label

		<AccessedThroughProperty("lblSecondCompanyName")>
		Private _lblSecondCompanyName As Label

		<AccessedThroughProperty("lblSecondCompanyWebsite")>
		Private _lblSecondCompanyWebsite As Label

		<AccessedThroughProperty("lblRodTensileStrength11")>
		Private _lblRodTensileStrength11 As Label

		<AccessedThroughProperty("lblRodLength11")>
		Private _lblRodLength11 As Label

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

		<AccessedThroughProperty("lblRodTensileStrength12")>
		Private _lblRodTensileStrength12 As Label

		<AccessedThroughProperty("lblRodTensileStrength13")>
		Private _lblRodTensileStrength13 As Label

		<AccessedThroughProperty("lblRodTensileStrength14")>
		Private _lblRodTensileStrength14 As Label

		<AccessedThroughProperty("lblRodTensileStrength15")>
		Private _lblRodTensileStrength15 As Label

		<AccessedThroughProperty("lblRodTensileStrength16")>
		Private _lblRodTensileStrength16 As Label

		<AccessedThroughProperty("lblRodTensileStrength17")>
		Private _lblRodTensileStrength17 As Label

		<AccessedThroughProperty("lblRodTensileStrength18")>
		Private _lblRodTensileStrength18 As Label

		<AccessedThroughProperty("lblRodStress11")>
		Private _lblRodStress11 As Label

		<AccessedThroughProperty("lblRodStress12")>
		Private _lblRodStress12 As Label

		<AccessedThroughProperty("lblRodStress13")>
		Private _lblRodStress13 As Label

		<AccessedThroughProperty("lblRodStress14")>
		Private _lblRodStress14 As Label

		<AccessedThroughProperty("lblRodStress15")>
		Private _lblRodStress15 As Label

		<AccessedThroughProperty("lblRodStress16")>
		Private _lblRodStress16 As Label

		<AccessedThroughProperty("lblRodStress17")>
		Private _lblRodStress17 As Label

		<AccessedThroughProperty("lblRodStress18")>
		Private _lblRodStress18 As Label

		<AccessedThroughProperty("lblRodTopMaxStress11")>
		Private _lblRodTopMaxStress11 As Label

		<AccessedThroughProperty("lblRodTopMaxStress12")>
		Private _lblRodTopMaxStress12 As Label

		<AccessedThroughProperty("lblRodTopMaxStress13")>
		Private _lblRodTopMaxStress13 As Label

		<AccessedThroughProperty("lblRodTopMaxStress14")>
		Private _lblRodTopMaxStress14 As Label

		<AccessedThroughProperty("lblRodTopMaxStress15")>
		Private _lblRodTopMaxStress15 As Label

		<AccessedThroughProperty("lblRodTopMaxStress16")>
		Private _lblRodTopMaxStress16 As Label

		<AccessedThroughProperty("lblRodTopMaxStress17")>
		Private _lblRodTopMaxStress17 As Label

		<AccessedThroughProperty("lblRodTopMaxStress18")>
		Private _lblRodTopMaxStress18 As Label

		<AccessedThroughProperty("lblRodTopMinStress11")>
		Private _lblRodTopMinStress11 As Label

		<AccessedThroughProperty("lblRodTopMinStress12")>
		Private _lblRodTopMinStress12 As Label

		<AccessedThroughProperty("lblRodTopMinStress13")>
		Private _lblRodTopMinStress13 As Label

		<AccessedThroughProperty("lblRodTopMinStress14")>
		Private _lblRodTopMinStress14 As Label

		<AccessedThroughProperty("lblRodTopMinStress15")>
		Private _lblRodTopMinStress15 As Label

		<AccessedThroughProperty("lblRodTopMinStress16")>
		Private _lblRodTopMinStress16 As Label

		<AccessedThroughProperty("lblRodTopMinStress17")>
		Private _lblRodTopMinStress17 As Label

		<AccessedThroughProperty("lblRodTopMinStress18")>
		Private _lblRodTopMinStress18 As Label

		<AccessedThroughProperty("lblRodBotMinStress11")>
		Private _lblRodBotMinStress11 As Label

		<AccessedThroughProperty("lblRodBotMinStress12")>
		Private _lblRodBotMinStress12 As Label

		<AccessedThroughProperty("lblRodBotMinStress13")>
		Private _lblRodBotMinStress13 As Label

		<AccessedThroughProperty("lblRodBotMinStress14")>
		Private _lblRodBotMinStress14 As Label

		<AccessedThroughProperty("lblRodBotMinStress15")>
		Private _lblRodBotMinStress15 As Label

		<AccessedThroughProperty("lblRodBotMinStress16")>
		Private _lblRodBotMinStress16 As Label

		<AccessedThroughProperty("lblRodBotMinStress17")>
		Private _lblRodBotMinStress17 As Label

		<AccessedThroughProperty("lblRodBotMinStress18")>
		Private _lblRodBotMinStress18 As Label

		<AccessedThroughProperty("lblRodStressMethod11")>
		Private _lblRodStressMethod11 As Label

		<AccessedThroughProperty("lblRodStressMethod12")>
		Private _lblRodStressMethod12 As Label

		<AccessedThroughProperty("lblRodStressMethod13")>
		Private _lblRodStressMethod13 As Label

		<AccessedThroughProperty("lblRodStressMethod14")>
		Private _lblRodStressMethod14 As Label

		<AccessedThroughProperty("lblRodStressMethod15")>
		Private _lblRodStressMethod15 As Label

		<AccessedThroughProperty("lblRodStressMethod16")>
		Private _lblRodStressMethod16 As Label

		<AccessedThroughProperty("lblRodStressMethod17")>
		Private _lblRodStressMethod17 As Label

		<AccessedThroughProperty("lblRodStressMethod18")>
		Private _lblRodStressMethod18 As Label

		<AccessedThroughProperty("lblFricCoef11")>
		Private _lblFricCoef11 As Label

		<AccessedThroughProperty("lblFricCoef12")>
		Private _lblFricCoef12 As Label

		<AccessedThroughProperty("lblFricCoef13")>
		Private _lblFricCoef13 As Label

		<AccessedThroughProperty("lblFricCoef14")>
		Private _lblFricCoef14 As Label

		<AccessedThroughProperty("lblFricCoef15")>
		Private _lblFricCoef15 As Label

		<AccessedThroughProperty("lblFricCoef16")>
		Private _lblFricCoef16 As Label

		<AccessedThroughProperty("lblFricCoef17")>
		Private _lblFricCoef17 As Label

		<AccessedThroughProperty("lblFricCoef18")>
		Private _lblFricCoef18 As Label

		<AccessedThroughProperty("lblRodDiam19")>
		Private _lblRodDiam19 As Label

		<AccessedThroughProperty("lblRodGrade19")>
		Private _lblRodGrade19 As Label

		<AccessedThroughProperty("lblRodLength19")>
		Private _lblRodLength19 As Label

		<AccessedThroughProperty("lblRodTensileStrength19")>
		Private _lblRodTensileStrength19 As Label

		<AccessedThroughProperty("lblFricCoef19")>
		Private _lblFricCoef19 As Label

		<AccessedThroughProperty("lblRodStress19")>
		Private _lblRodStress19 As Label

		<AccessedThroughProperty("lblRodTopMaxStress19")>
		Private _lblRodTopMaxStress19 As Label

		<AccessedThroughProperty("lblRodTopMinStress19")>
		Private _lblRodTopMinStress19 As Label

		<AccessedThroughProperty("lblRodBotMinStress19")>
		Private _lblRodBotMinStress19 As Label

		<AccessedThroughProperty("lblRodStressMethod19")>
		Private _lblRodStressMethod19 As Label

		<AccessedThroughProperty("lblRodDiam20")>
		Private _lblRodDiam20 As Label

		<AccessedThroughProperty("lblRodGrade20")>
		Private _lblRodGrade20 As Label

		<AccessedThroughProperty("lblRodLength20")>
		Private _lblRodLength20 As Label

		<AccessedThroughProperty("lblRodTensileStrength20")>
		Private _lblRodTensileStrength20 As Label

		<AccessedThroughProperty("lblFricCoef20")>
		Private _lblFricCoef20 As Label

		<AccessedThroughProperty("lblRodStress20")>
		Private _lblRodStress20 As Label

		<AccessedThroughProperty("lblRodTopMaxStress20")>
		Private _lblRodTopMaxStress20 As Label

		<AccessedThroughProperty("lblRodTopMinStress20")>
		Private _lblRodTopMinStress20 As Label

		<AccessedThroughProperty("lblRodBotMinStress20")>
		Private _lblRodBotMinStress20 As Label

		<AccessedThroughProperty("lblRodStressMethod20")>
		Private _lblRodStressMethod20 As Label

		Private Line2 As Line

		Private printFont As Font

		Private sDate As String

		Private sPage As String

		Private sOf As String

		Private m_bPrint As Boolean

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer
	End Class
End Namespace
