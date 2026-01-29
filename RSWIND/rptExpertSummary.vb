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
	Public Class rptExpertSummary
		Inherits ActiveReport

		Private Overridable Property lblSBFootnote As Label
			Get
				Return Me._lblSBFootnote
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSBFootnote = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.FetchData, AddressOf Me.rptExpertSummary_FetchData
			AddHandler MyBase.ReportStart, AddressOf Me.rptExpertSummary_ReportStart
			Me.ReportLines = New rptExpertSummary.ReportLine_Struct(100) {}
			Me.sNull = ""
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
			Me.lblTOTALSCORE = Nothing
			Me.lblGEARBOXSCORE = Nothing
			Me.lblRODLOADINGSCORE = Nothing
			Me.lblSTRUCTURELOADINGSCORE = Nothing
			Me.lblSYSTEMEFFICIENCYSCORE = Nothing
			Me.lblRL_Summary = Nothing
			Me.lblSysEff_Summary = Nothing
			Me.lblSL_Summary = Nothing
			Me.lblBottomMinStressSCORE = Nothing
			Me.lblBotMin_Summary = Nothing
			Me.lblGB_Summary = Nothing
			Me.lblMPRL = Nothing
			Me.lblMPRL_Summary = Nothing
			Me.lblTOTALSCORE_NoRec = Nothing
			Me.sMaxRodGuidesExceeded_s = "(Note: Due to severe side loading, taper requires more guides than the maximum guides per rod entered in setup.)"
			Me.sMaxRodGuidesExceeded_p = "(Note: Due to severe side loading, tapers require more guides than the maximum guides per rod entered in setup.)"
			Me.m_sTapersOverMax = ""
			Me.slbl = "lbl"
			Me.sSystemDesignScore = Util.AssignValueToConstant("rptExpertSummary", "sSystemDesignScore", "System Design Score : ")
			Me.sTOTALSCORE = Util.AssignValueToConstant("rptExpertSummary", "sTOTALSCORE", "TOTAL SCORE: ")
			Me.sGrade = Util.AssignValueToConstant("rptExpertSummary", "sGrade", "  Grade: ")
			Me.sNoRecommendationsNecessary = Util.AssignValueToConstant("rptExpertSummary", "sNoRecommendationsNecessary", "No recommendations for improvements are necessary")
			Me.sGBLoad_6_7 = Util.AssignValueToConstant("rptExpertSummary", "sGBLoad_6_7", "The gearbox is lightly loaded (X%). The ideal range for gearbox loading is between 70% and 95%. If possible, please use a pumping unit with a smaller gearbox size to reduce pumping unit cost.")
			Me.sGBLoad_5_6 = Util.AssignValueToConstant("rptExpertSummary", "sGBLoad_5_6", "The gearbox is much bigger than needed because the gearbox loading is only X%. The ideal range for gearbox loading is between 70% and 95%. If possible, please use a pumping unit with a smaller gearbox size to reduce pumping unit cost.")
			Me.sGBLoad_0_5 = Util.AssignValueToConstant("rptExpertSummary", "sGBLoad_0_5", "The gearbox is much bigger than needed because the gearbox loading is only X%. The ideal range for gearbox loading is between 70% and 95%. If possible, please use a pumping unit with a smaller gearbox size to reduce pumping unit cost.")
			Me.sGBLoad_5 = Util.AssignValueToConstant("rptExpertSummary", "sGBLoad_5", "The gearbox is much bigger than needed because the gearbox loading is only X%. The ideal range for gearbox loading is between 70% and 95%. If possible, please use a pumping unit with a smaller gearbox size to reduce pumping unit cost.")
			Me.sGBLoad_95_1 = Util.AssignValueToConstant("rptExpertSummary", "sGBLoad_95_1", "The gearbox is fully loaded (X%). The ideal range for gearbox loading is between 70% and 95%. If possible, please use a pumping unit with a larger gearbox size.")
			Me.sGBLoad_1_12 = Util.AssignValueToConstant("rptExpertSummary", "SGBLoad_1_12", "The gearbox is overloaded (X%). The ideal range for gearbox loading is between 70% and 95%. Please use a pumping unit with a larger gearbox size.")
			Me.sGBLoad_12_135 = Util.AssignValueToConstant("rptExpertSummary", "sGBLoad_12_135", "The gearbox is severely overloaded (X%). The ideal range for gearbox loading is between 70% and 95%. Please use a pumping unit with a larger gearbox size.")
			Me.sGBLoad_135 = Util.AssignValueToConstant("rptExpertSummary", "sGBLoad_135", "The gearbox is severely overloaded (X%). The ideal range for gearbox loading is between 70% and 95%. Please use a pumping unit with a larger gearbox size.")
			Me.sGBLoad_1_12_b = Util.AssignValueToConstant("rptExpertSummary", "SGBLoad_1_12", "The gearbox is overloaded (X%). The ideal range for gearbox loading is between 70% and 95%. Please use a smaller stroke length or use a pumping unit with a larger gearbox size.")
			Me.sGBLoad_12_135_b = Util.AssignValueToConstant("rptExpertSummary", "sGBLoad_12_135", "The gearbox is severely overloaded (X%). The ideal range for gearbox loading is between 70% and 95%. Please use a smaller stroke length or use a pumping unit with a larger gearbox size.")
			Me.sGBLoad_135_b = Util.AssignValueToConstant("rptExpertSummary", "sGBLoad_135", "The gearbox is severely overloaded (X%). The ideal range for gearbox loading is between 70% and 95%. Please use a smaller stroke length or use a pumping unit with a larger gearbox size.")
			Me.sGEARBOXSCORE = Util.AssignValueToConstant("rptExpertSummary", "sGEARBOXSCORE", "BALANCED GEARBOX LOADING SCORE: ")
			Me.sSLoad_6_7 = Util.AssignValueToConstant("rptExpertSummary", "sSLoad_6_7", "Structural loading at (X)% is a little low. Please use a pumping unit with a lower structural rating so that the loading is between 70% and 95%.")
			Me.sSLoad_5_6 = Util.AssignValueToConstant("rptExpertSummary", "sSLoad_5_6", "Structural loading at (X)% is very low. Please use a pumping unit with a lower structural rating so that the loading is between 70% and 95%.")
			Me.sSLoad_5 = Util.AssignValueToConstant("rptExpertSummary", "sSLoad_5", "Structural loading at (X)% is very low. Please use a smaller pumping unit is possible or a pumping unit with a lower structural rating so that the loading is between 70% and 95%.")
			Me.sSLoad_95_1 = Util.AssignValueToConstant("rptExpertSummary", "sSLoad_95_1", "The pumping unit structure is close to being overloaded at (X)%. Please use a pumping unit with a larger structural rating or use a smaller pump plunger so that the loading is between 70% and 95%.")
			Me.sSLoad_1_11 = Util.AssignValueToConstant("rptExpertSummary", "sSLoad_1_11", "The pumping unit structure is overloaded at (X)%. Please use a pumping unit with a larger structural rating or a smaller pump plunger so that the structure loading is between 70% and 95%.")
			Me.sSLoad_11_12 = Util.AssignValueToConstant("rptExpertSummary", "sSLoad_11_12", "Structural loading at (X)% is extremely high. Please use a pumping unit with a larger structural rating so that the loading is between 70% and 95%.")
			Me.sSLoad_120 = Util.AssignValueToConstant("rptExpertSummary", "sSLoad_135", "The pumping unit structure is severely overloaded at (X)%. Please use a pumping unit with a larger structural rating so that the loading is between 70% and 95%.")
			Me.sSLoad_95_105 = " Also, try using high strength rods. This will reduce rod string weight and structure loading."
			Me.sSTRUCTURELOADINGSCORE = Util.AssignValueToConstant("rptExpertSummary", "sSTRUCTURELOADINGSCORE", "STRUCTURE LOADING SCORE: ")
			Me.sMaxRodLoad_6_7 = Util.AssignValueToConstant("rptExpertSummary", "sMaxRodLoad_6_7", "The rods are lightly loaded (X%). The ideal range for rod loading is between 70% and 95%. If possible, please use lower grade rods to reduce rod string cost.")
			Me.sMaxRodLoad_5_6 = Util.AssignValueToConstant("rptExpertSummary", "sMaxRodLoad_5_6", "The rod loading is very low (X%). The ideal range for rod loading is between 70% and 95%. If possible, please use lower grade rods to reduce rod string cost.")
			Me.sMaxRodLoad_4_5 = Util.AssignValueToConstant("rptExpertSummary", "sMaxRodLoad_4_5", "The rod loading is very low (X%). The ideal range for rod loading is between 70% and 95%. If possible, please use lower grade rods to reduce rod string cost.")
			Me.sMaxRodLoad_4 = Util.AssignValueToConstant("rptExpertSummary", "sMaxRodLoad_4", "The rod loading is very low (X%). The ideal range for rod loading is between 70% and 95%. If possible, please use lower grade rods to reduce rod string cost.")
			Me.sMaxRodLoad_95_1 = Util.AssignValueToConstant("rptExpertSummary", "sMaxRodLoad_95_1", "The rods are loaded close to their maximum capacity (X%). The ideal range for rod loading is between 70% and 95%. If possible, please use stronger rods to reduce rod loading.")
			Me.sMaxRodLoad_1_11 = Util.AssignValueToConstant("rptExpertSummary", "sMaxRodLoad_105_11", "The rods are overloaded (X%). The ideal range for rod loading is between 70% and 95%. If possible, please use stronger rods to reduce rod loading.")
			Me.sMaxRodLoad_11_12 = Util.AssignValueToConstant("rptExpertSummary", "sMaxRodLoad_11_12", "The rods are severely overloaded (X%). The ideal range for rod loading is between 70% and 95%. If possible, please use stronger rods to reduce rod loading.")
			Me.sMaxRodLoad_12 = Util.AssignValueToConstant("rptExpertSummary", "sMaxRodLoad_12", "The rods are severely overloaded (X%). The ideal range for rod loading is between 70% and 95%. If possible, please use stronger rods to reduce rod loading.")
			Me.sMaxRodLoad_1_11_sb = Util.AssignValueToConstant("rptExpertSummary", "sMaxRodLoad_1_11_sb", "The sinker bars are overloaded (X%). If possible, please use stronger sinker bars or use no-neck bars to reduce sinker bars loading.")
			Me.sMaxRodLoad_11_12_sb = Util.AssignValueToConstant("rptExpertSummary", "sMaxRodLoad_11_12_sb", "The sinker bars are severely overloaded (X%). If possible, please use stronger sinker bars or use no-neck bars to reduce sinker bars loading.")
			Me.sMaxRodLoad_12_sb = Util.AssignValueToConstant("rptExpertSummary", "sMaxRodLoad_12_sb", "The sinker bars are severely overloaded (X%). If possible, please use stronger sinker bars or use no-neck bars to reduce sinker bars loading.")
			Me.sRODLOADINGSCORE = Util.AssignValueToConstant("rptExpertSummary", "sRODLOADINGSCORE", "MAXIMUM ROD LOADING SCORE: ")
			Me.sTryChangingDirection = Util.AssignValueToConstant("rptExpertSummary", "sTryChangingDirection", "- Try changing the pumping unit direction of rotation.")
			Me.sSysEff_45_5_a = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_45_5_a", "System efficiency at (X) % is excellent. To increase efficiency even more: ")
			Me.sSysEff_45_5_b = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_45_5_b", "- Use a bigger pump and slower pumping speed")
			Me.sSysEff_45_5_c = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_45_5_c", "- Use longer stroke length.")
			Me.sSysEff_45_5_d = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_45_5_d", "- Use more efficient pumping unit.")
			Me.sSysEff_45_5_e = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_45_5_e", "- Use a more efficient motor (or different motor type).")
			Me.sSysEff_42_45_a = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_4_45_a", "System efficiency at (X)% is excellent. To increase efficiency: ")
			Me.sSysEff_42_45_b = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_4_45_b", "- Use a bigger pump and slower pumping speed")
			Me.sSysEff_42_45_c = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_4_45_c", "- Use longer stroke length.")
			Me.sSysEff_42_45_d = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_4_45_d", "- Use more efficient pumping unit.")
			Me.sSysEff_42_45_e = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_4_45_e", "- Use a more efficient motor (or different motor type).")
			Me.sSysEff_4_42_a = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_4_45_a", "System efficiency at (X)% is good. To increase efficiency: ")
			Me.sSysEff_4_42_b = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_4_45_b", "- Use a bigger pump and slower pumping speed")
			Me.sSysEff_4_42_c = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_4_45_c", "- Use longer stroke length.")
			Me.sSysEff_4_42_d = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_4_45_d", "- Use more efficient pumping unit.")
			Me.sSysEff_4_42_e = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_4_45_e", "- Use a more efficient motor (or different motor type).")
			Me.sSysEff_35_4_a = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_35_4_a", "System efficiency at (X)% is lower than it can be. To increase efficiency: ")
			Me.sSysEff_35_4_b = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_35_4_b", "- Use a bigger pump and slower pumping speed")
			Me.sSysEff_35_4_c = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_35_4_c", "- Use longer stroke length.")
			Me.sSysEff_35_4_d = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_35_4_d", "- Use more efficient pumping unit.")
			Me.sSysEff_35_4_e = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_35_4_e", "- Use a more efficient motor (or different motor type).")
			Me.sSysEff_3_35_a = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_3_35_a", "System efficiency at (X)% is poor. To increase efficiency:")
			Me.sSysEff_3_35_b = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_3_35_b", "- Use a bigger pump and slower pumping speed")
			Me.sSysEff_3_35_c = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_3_35_c", "- Use longer stroke length.")
			Me.sSysEff_3_35_d = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_3_35_d", "- Use more efficient pumping unit.")
			Me.sSysEff_3_35_e = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_3_35_e", "- Use a more efficient motor (or different motor type).")
			Me.sSysEff_25_3_a = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_25_3_a", "System efficiency at (X)% is very poor: To increase efficiency:")
			Me.sSysEff_25_3_b = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_25_3_b", "- Use a bigger pump and slower pumping speed")
			Me.sSysEff_25_3_c = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_25_3_c", "- Use longer stroke length.")
			Me.sSysEff_25_3_d = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_25_3_d", "- Use more efficient pumping unit.")
			Me.sSysEff_25_3_e = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_25_3_e", "- Use a more efficient motor (or different motor type).")
			Me.sSysEff_25_a = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_25_a", "System efficiency at (X)% is very poor: To increase efficiency:")
			Me.sSysEff_25_b = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_25_b", "- Use a bigger pump and slower pumping speed")
			Me.sSysEff_25_c = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_25_c", "- Use longer stroke length.")
			Me.sSysEff_25_d = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_25_d", "- Use more efficient pumping unit.")
			Me.sSysEff_25_e = Util.AssignValueToConstant("rptExpertSummary", "sSysEff_25_e", "- Use a more efficient motor (or different motor type).")
			Me.sSysEffScore = Util.AssignValueToConstant("rptExpertSummary", "sSysEffScore", "SYSTEM EFFICIENCY SCORE: ")
			Me.sBotMinStressScore = Util.AssignValueToConstant("rptExpertSummary", "sBotMinStressScore", "BOTTOM MINIMUM STRESS SCORE: ")
			Me.sStress_300_0_sb = Util.AssignValueToConstant("rptExpertSummary", "sStress_300_0_sb", "The bottom min. stress of the section just above the sinker bar section is too negative which can result in rod buckling. Add more sinker bars and if necessary use a lower pumping speed to bring the bottom min. stress between 300 and 650 psi.")
			Me.sStress_300_0_no_sb = Util.AssignValueToConstant("rptExpertSummary", "sStress_300_0_no_sb", "The bottom min. stress of the last section is too negative which can result in rod buckling. Add sinker bars and if necessary use a lower pumping speed to bring the bottom min. stress between 300 and 650 psi.")
			Me.sStress_650_1000_sb = Util.AssignValueToConstant("rptExpertSummary", "sStress_650_1000_sb", "The sinker bar section may be longer than it needs to be. Reduce the length of the sinker bar section until the bottom min. stress at the bottom of the rod string just above the sinker bar section is between 300 and 650 psi.")
			Me.sStress_25_sb = Util.AssignValueToConstant("rptExpertSummary", "sStress_25_sb", "The bottom of the last rod section is in compression. Add sinker bars until the bottom min. stress at the bottom of the rod string, just above the sinker bar section, is between 300 and 650 psi.")
			Me.sStress_25_no_sb = Util.AssignValueToConstant("rptExpertSummary", "sStress_25_no_sb", "Add sinker bars until the bottom min. stress at the bottom of the rod string just above the sinker bar section is between 300 and 650 psi.")
			Me.sStress_1000_sb = Util.AssignValueToConstant("rptExpertSummary", "sStress_1000_sb", "The sinker bar section may be  longer than it needs to be. Reduce the length of the sinker bar section until the bottom min. stress at the bottom of the rod string just above the sinker bar section is between 300 and 650 psi.")
			Me.sStress_300_0_sr = Util.AssignValueToConstant("rptExpertSummary", "sStress_300_0_sr", "The bottom min. stress of the section just above the sinker rod section is too negative which can result in rod buckling. Add more sinker rods and if necessary use a lower pumping speed to bring the bottom min. stress between 300 and 650 psi.")
			Me.sStress_650_1000_sr = Util.AssignValueToConstant("rptExpertSummary", "sStress_650_1000_sr", "The sinker rod section may be  longer than it needs to be. Reduce the length of the sinker rod section until the bottom min. stress at the bottom of the rod string just above the sinker rod section is between 300 and 650 psi.")
			Me.sStress_100_300_sb_tp = Util.AssignValueToConstant("rptExpertSummary", "sStress_100_300_sb", "The sinker bar section is shorter than it needs to be. Increase the length of the sinker bar section, use a larger sinker bar diameter, or use a larger pump plunger diameter until the bottom minimum stress at the bottom of the rod string just above the sinker bar section is between 300 and 650 psi.")
			Me.sStress_25_100_sb_tp = Util.AssignValueToConstant("rptExpertSummary", "sStress_25_100_sb", "Increase the length of the sinker bar section, use a larger sinker bar diameter, or use a larger pump plunger diameter until the bottom minimum stress at the bottom of the rod string just above the sinker bar section is between 300 and 650 psi.")
			Me.sStress_0_25_sb_tp = Util.AssignValueToConstant("rptExpertSummary", "sStress_0_25_sb", "The rods above the sinker bar section are almost in compression. Increase the length of the sinker bar section, use a larger sinker bar diameter, or use a larger pump plunger diameter until the bottom minimum stress at the bottom of the rod string just above the sinker bar section is between 300 and 650 psi.")
			Me.sStress_100_300_sb_spm = Util.AssignValueToConstant("rptExpertSummary", "sStress_100_300_sb", "The sinker bar section is shorter than it needs to be. Increase the length of the sinker bar section, use a larger sinker bar diameter, use a larger pump plunger diameter, or reduce the pumping speed until the bottom minimum stress at the bottom of the rod string just above the sinker bar section is between 300 and 650 psi.")
			Me.sStress_25_100_sb_spm = Util.AssignValueToConstant("rptExpertSummary", "sStress_25_100_sb", "Increase the length of the sinker bar section, use a larger sinker bar diameter, use a larger pump plunger diameter, or reduce the pumping speed until the bottom minimum stress at the bottom of the rod string just above the sinker bar section is between 300 and 650 psi.")
			Me.sStress_0_25_sb_spm = Util.AssignValueToConstant("rptExpertSummary", "sStress_0_25_sb", "The rods above the sinker bar section are almost in compression. Increase the length of the sinker bar section, use a larger sinker bar diameter, use a larger pump plunger diameter, or reduce the pumping speed until the bottom minimum stress at the bottom of the rod string just above the sinker bar section is between 300 and 650 psi.")
			Me.sStress_100_300_sr_tp = Util.AssignValueToConstant("rptExpertSummary", "sStress_100_300_sb", "The sinker rod section is shorter than it needs to be. Increase the length of the sinker rod section, use a larger sinker rod diameter, or use a larger pump plunger diameter until the bottom minimum stress at the bottom of the rod string just above the sinker rod section is between 300 and 650 psi.")
			Me.sStress_25_100_sr_tp = Util.AssignValueToConstant("rptExpertSummary", "sStress_25_100_sb", "Increase the length of the sinker rod section, use a larger sinker rod diameter, or use a larger pump plunger diameter until the bottom minimum stress at the bottom of the rod string just above the sinker rod section is between 300 and 650 psi.")
			Me.sStress_0_25_sr_tp = Util.AssignValueToConstant("rptExpertSummary", "sStress_0_25_sb", "The rods above the sinker rod section are almost in compression. Increase the length of the sinker rod section, use a larger sinker rod diameter, or use a larger pump plunger diameter until the bottom minimum stress at the bottom of the rod string just above the sinker rod section is between 300 and 650 psi.")
			Me.sStress_100_300_sr_spm = Util.AssignValueToConstant("rptExpertSummary", "sStress_100_300_sb", "The sinker rod section is shorter than it needs to be. Increase the length of the sinker rod section, use a larger sinker rod diameter, use a larger pump plunger diameter, or reduce the pumping speed until the bottom minimum stress at the bottom of the rod string just above the sinker rod section is between 300 and 650 psi.")
			Me.sStress_25_100_sr_spm = Util.AssignValueToConstant("rptExpertSummary", "sStress_25_100_sb", "Increase the length of the sinker rod section, use a larger sinker rod diameter, use a larger pump plunger diameter, or reduce the pumping speed until the bottom minimum stress at the bottom of the rod string just above the sinker rod section is between 300 and 650 psi.")
			Me.sStress_0_25_sr_spm = Util.AssignValueToConstant("rptExpertSummary", "sStress_0_25_sb", "The rods above the sinker rod section are almost in compression. Increase the length of the sinker rod section, use a larger sinker rod diameter, use a larger pump plunger diameter, or reduce the pumping speed until the bottom minimum stress at the bottom of the rod string just above the sinker rod section is between 300 and 650 psi.")
			Me.sStress_25_sr = Util.AssignValueToConstant("rptExpertSummary", "sStress_25_sr", "The bottom of the last rod section is in compression. Add sinker rods until the bottom min. stress at the bottom of the rod string, just above the sinker rod section, is between 300 and 650 psi.")
			Me.sStress_1000_sr = Util.AssignValueToConstant("rptExpertSummary", "sStress_1000_sr", "The sinker rod section may be  longer than it needs to be. Reduce the length of the sinker rod section until the bottom min. stress at the bottom of the rod string just above the sinker rod section is between 300 and 650 psi.")
			Me.sStress_negative_r = Util.AssignValueToConstant("rptExpertSummary", "sStress_negative_r", "The bottom min. stress at the bottom of the rod string is negative which can result in rod buckling. Add sinker bars and if necessary use a lower pumping speed to bring the bottom min. stress between 300 and 650 psi.")
			Me.sStress_0_300_r = Util.AssignValueToConstant("rptExpertSummary", "sStress_0_300_r", "The bottom rod section is almost in compression. Add sinker bars and if necessary use a lower pumping speed to bring the bottom min. stress between 300 and 650 psi.")
			Me.sStress_800_sb_buoy_non_AI = "The sinker bar section is longer than it needs to be. Reduce the sinker bar section length until the bottom min. stress at the bottom of rod string just above the sinker bars is between 300 and 650 psi when buoyancy effects are included."
			Me.sStress_800_sb_unbuoy_non_AI = "The sinker bar section is longer than it needs to be. Reduce the sinker bar section length until the bottom min. stress at the bottom of rod string just above the sinker bars is between 300 and 650 psi when buoyancy effects are not included."
			Me.sStress_0_sb_buoy_non_AI = "The bottom of the rod section just above the sinker bars is in compression. Increase the length of the sinker bar section until the bottom min. stress is between 300 and 650 psi when buoyancy effects are included."
			Me.sStress_0_sb_unbuoy_non_AI = "The bottom of the rod section just above the sinker bars is in compression. Increase the length of the sinker bar section until the bottom min. stress is between 300 and 650 psi when buoyancy effects are not included."
			Me.sStress_1000_sf_st_buoy_non_AI = "Increase the length of the steel section below the fiberglass section until the bottom min. stress of fiberglass section is greater than 1000 psi when buoyancy effects are included."
			Me.sStress_3000_non_AI = "Sinker bar section is longer than it needs to be with buoyancy."
			Me.sStress_300_0_sb_relocate = Util.AssignValueToConstant("rptExpertSummary", "sStress_300_0_sb", "The bottom min. stress of the section just above the sinker bar section is too negative which can result in rod buckling. Add more sinker bars and if necessary use a lower pumping speed to bring the bottom min. stress just above the sinker bars between 300 and 650 psi. The sucker rod section below the sinker bars will be in compression because the sinker bars are placed above the kickoff point.")
			Me.sStress_300_0_no_sb_relocate = Util.AssignValueToConstant("rptExpertSummary", "sStress_300_0_no_sb", "The bottom min. stress of the last section is too negative which can result in rod buckling. Add sinker bars and if necessary use a lower pumping speed to bring the bottom min. stress just above the sinker bar section between 300 and 650 psi. The sinker bars should be placed closest to the pump where the inclination is 4 degrees or less. If the sinker bars cannot be placed at the pump, place the sinker bars above the kickoff point. The sucker rod section below the sinker bars will be in compression if the sinker bars are placed above the kickoff point.")
			Me.sStress_650_1000_sb_relocate = Util.AssignValueToConstant("rptExpertSummary", "sStress_650_1000_sb", "The sinker bar section may be longer than it needs to be. Reduce the length of the sinker bar section until the bottom min. stress just above the sinker bars is between 300 and 650 psi. The sucker rod section below the sinker bars will be in compression because the sinker bars are placed above the kickoff point.")
			Me.sStress_25_sb_relocate = Util.AssignValueToConstant("rptExpertSummary", "sStress_25_sb", "The bottom of the sucker rod section just above the sinker bars is in compression. Add sinker bars until the bottom min. stress just above the sinker bar section, is between 300 and 650 psi. The sucker rod section below the sinker bars will be in compression because the sinker bars are placed above the kickoff point.")
			Me.sStress_25_no_sb_relocate = Util.AssignValueToConstant("rptExpertSummary", "sStress_25_no_sb", "Add sinker bars until the bottom min. stress just above the sinker bar section is between 300 and 650 psi. The sinker bars should be placed closest to the pump where the inclination is 4 degrees or less. If the sinker bars cannot be placed at the pump, place the sinker bars above the kickoff point. The sucker rod section below the sinker bars will be in compression if the sinker bars are placed above the kickoff point.")
			Me.sStress_1000_sb_relocate = Util.AssignValueToConstant("rptExpertSummary", "sStress_1000_sb", "The sinker bar section may be longer than it needs to be. Reduce the length of the sinker bar section until the bottom min. stress just above the sinker bars is between 300 and 650 psi. The sucker rod section below the sinker bars will be in compression because the sinker bars are placed above the kickoff point.")
			Me.sStress_100_300_sb_tp_relocate = Util.AssignValueToConstant("rptExpertSummary", "sStress_100_300_sb_tp", "The sinker bar section is shorter than it needs to be. Increase the length of the sinker bar section, use a larger sinker bar diameter, or use a larger pump plunger diameter until the bottom minimum stress just above the sinker bar section is between 300 and 650 psi. The sucker rod section below the sinker bars will be in compression because the sinker bars are placed above the kickoff point.")
			Me.sStress_25_100_sb_tp_relocate = Util.AssignValueToConstant("rptExpertSummary", "sStress_25_100_sb_tp", "Increase the length of the sinker bar section, use a larger sinker bar diameter, or use a larger pump plunger diameter until the bottom minimum stress just above the sinker bar section is between 300 and 650 psi. The sucker rod section below the sinker bars will be in compression because the sinker bars are placed above the kickoff point.")
			Me.sStress_0_25_sb_tp_relocate = Util.AssignValueToConstant("rptExpertSummary", "sStress_0_25_sb_tp", "The rods above the sinker bar section are almost in compression. Increase the length of the sinker bar section, use a larger sinker bar diameter, or use a larger pump plunger diameter until the bottom minimum stress just above the sinker bar section is between 300 and 650 psi. The sucker rod section below the sinker bars will be in compression because the sinker bars are placed above the kickoff point.")
			Me.sStress_100_300_sb_spm_relocate = Util.AssignValueToConstant("rptExpertSummary", "sStress_100_300_sb_spm", "The sinker bar section is shorter than it needs to be. Increase the length of the sinker bar section, use a larger sinker bar diameter, use a larger pump plunger diameter, or reduce the pumping speed until the bottom minimum stress just above the sinker bar section is between 300 and 650 psi. The sucker rod section below the sinker bars will be in compression because the sinker bars are placed above the kickoff point.")
			Me.sStress_25_100_sb_spm_relocate = Util.AssignValueToConstant("rptExpertSummary", "sStress_25_100_sb_spm", "Increase the length of the sinker bar section, use a larger sinker bar diameter, use a larger pump plunger diameter, or reduce the pumping speed until the bottom minimum stress just above the sinker bar section is between 300 and 650 psi. The sucker rod section below the sinker bars will be in compression because the sinker bars are placed above the kickoff point.")
			Me.sStress_0_25_sb_spm_relocate = Util.AssignValueToConstant("rptExpertSummary", "sStress_0_25_sb_spm", "The rods above the sinker bar section are almost in compression. Increase the length of the sinker bar section, use a larger sinker bar diameter, use a larger pump plunger diameter, or reduce the pumping speed until the bottom minimum stress just above the sinker bar section is between 300 and 650 psi. The sucker rod section below the sinker bars will be in compression because the sinker bars are placed above the kickoff point.")
			Me.sMPRL_100_200 = Util.AssignValueToConstant("rptExpertSummary", "sMPRL_100_200", "The minimum polished rod load is low. This may result in separation between the carrier bar and polished rod on the downstroke. Try reducing the pumping speed, or use a longer stroke to reduce polished rod velocity.")
			Me.sMPRL_50_100 = Util.AssignValueToConstant("rptExpertSummary", "sMPRL_50_100", "The minimum polished rod load is very low. This may result in separation between the carrier bar and polished rod on the downstroke. Try reducing the pumping speed, or use a longer stroke to reduce polished rod velocity.")
			Me.sMPRL_20_50 = Util.AssignValueToConstant("rptExpertSummary", "sMPRL_20_50", "The minimum polished rod load is very low and there is a very high probability that there will be separation between the carrier bar and polished rod on the downstroke. Try reducing the pumping speed, or use a longer stroke to reduce polished rod velocity.")
			Me.sMPRL_0_20 = Util.AssignValueToConstant("rptExpertSummary", "sMPRL_0_20", "The minimum polished rod load is close to zero. This will cause separation between the carrier bar and polished rod on the downstroke. Try reducing the pumping speed, or use a longer stroke to reduce polished rod velocity.")
			Me.sMPRL_0 = Util.AssignValueToConstant("rptExpertSummary", "sMPRL_0", "The minimum polished rod load is negative. This will cause separation between the carrier bar and polished rod on the downstroke. Try reducing the pumping speed, or use a longer stroke to reduce polished rod velocity.")
			Me.sMinPRLScore = Util.AssignValueToConstant("rptExpertSummary", "sMinPRLScore", "MINIMUM POLISHED ROD LOADING SCORE: ")
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
				Me._GroupHeader1 = value
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
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptExpertSummary))
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
			Me.lblTOTALSCORE = New Label()
			Me.lblGEARBOXSCORE = New Label()
			Me.lblRODLOADINGSCORE = New Label()
			Me.lblSTRUCTURELOADINGSCORE = New Label()
			Me.lblSYSTEMEFFICIENCYSCORE = New Label()
			Me.lblRL_Summary = New Label()
			Me.lblSysEff_Summary = New Label()
			Me.lblSL_Summary = New Label()
			Me.lblBottomMinStressSCORE = New Label()
			Me.lblBotMin_Summary = New Label()
			Me.lblGB_Summary = New Label()
			Me.lblMPRL = New Label()
			Me.lblMPRL_Summary = New Label()
			Me.lblTOTALSCORE_NoRec = New Label()
			Me.GroupFooter1 = New GroupFooter()
			Me.lblSBFootnote = New Label()
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
			CType(Me.lblTOTALSCORE, ISupportInitialize).BeginInit()
			CType(Me.lblGEARBOXSCORE, ISupportInitialize).BeginInit()
			CType(Me.lblRODLOADINGSCORE, ISupportInitialize).BeginInit()
			CType(Me.lblSTRUCTURELOADINGSCORE, ISupportInitialize).BeginInit()
			CType(Me.lblSYSTEMEFFICIENCYSCORE, ISupportInitialize).BeginInit()
			CType(Me.lblRL_Summary, ISupportInitialize).BeginInit()
			CType(Me.lblSysEff_Summary, ISupportInitialize).BeginInit()
			CType(Me.lblSL_Summary, ISupportInitialize).BeginInit()
			CType(Me.lblBottomMinStressSCORE, ISupportInitialize).BeginInit()
			CType(Me.lblBotMin_Summary, ISupportInitialize).BeginInit()
			CType(Me.lblGB_Summary, ISupportInitialize).BeginInit()
			CType(Me.lblMPRL, ISupportInitialize).BeginInit()
			CType(Me.lblMPRL_Summary, ISupportInitialize).BeginInit()
			CType(Me.lblTOTALSCORE_NoRec, ISupportInitialize).BeginInit()
			CType(Me.lblSBFootnote, ISupportInitialize).BeginInit()
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
			Me.GroupHeader1.Controls.AddRange(New ARControl() { Me.lblTOTALSCORE, Me.lblGEARBOXSCORE, Me.lblRODLOADINGSCORE, Me.lblSTRUCTURELOADINGSCORE, Me.lblSYSTEMEFFICIENCYSCORE, Me.lblRL_Summary, Me.lblSysEff_Summary, Me.lblSL_Summary, Me.lblBottomMinStressSCORE, Me.lblBotMin_Summary, Me.lblGB_Summary, Me.lblMPRL, Me.lblMPRL_Summary, Me.lblTOTALSCORE_NoRec, Me.lblSBFootnote })
			Me.GroupHeader1.Height = 5.895833F
			Me.GroupHeader1.Name = "GroupHeader1"
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
			Me.lblRODLOADINGSCORE.Top = 1F
			Me.lblRODLOADINGSCORE.Width = 7.5F
			Me.lblSTRUCTURELOADINGSCORE.Height = 0.1875F
			Me.lblSTRUCTURELOADINGSCORE.HyperLink = Nothing
			Me.lblSTRUCTURELOADINGSCORE.Left = 0.0625F
			Me.lblSTRUCTURELOADINGSCORE.Name = "lblSTRUCTURELOADINGSCORE"
			Me.lblSTRUCTURELOADINGSCORE.Style = "background-color: Gainsboro; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblSTRUCTURELOADINGSCORE.Text = "STRUCTURE LOADING SCORE:"
			Me.lblSTRUCTURELOADINGSCORE.Top = 1.75F
			Me.lblSTRUCTURELOADINGSCORE.Width = 7.5F
			Me.lblSYSTEMEFFICIENCYSCORE.Height = 0.1875F
			Me.lblSYSTEMEFFICIENCYSCORE.HyperLink = Nothing
			Me.lblSYSTEMEFFICIENCYSCORE.Left = 0.0625F
			Me.lblSYSTEMEFFICIENCYSCORE.Name = "lblSYSTEMEFFICIENCYSCORE"
			Me.lblSYSTEMEFFICIENCYSCORE.Style = "background-color: Gainsboro; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblSYSTEMEFFICIENCYSCORE.Text = "SYSTEM EFFICIENCY SCORE: "
			Me.lblSYSTEMEFFICIENCYSCORE.Top = 2.5F
			Me.lblSYSTEMEFFICIENCYSCORE.Width = 7.5F
			Me.lblRL_Summary.Height = 0.5625F
			Me.lblRL_Summary.HyperLink = Nothing
			Me.lblRL_Summary.Left = 0.0625F
			Me.lblRL_Summary.Name = "lblRL_Summary"
			Me.lblRL_Summary.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblRL_Summary.Text = "Score 100 - No recommendations for improvements are necessary"
			Me.lblRL_Summary.Top = 1.1875F
			Me.lblRL_Summary.Width = 7.5F
			Me.lblSysEff_Summary.Height = 0.9375F
			Me.lblSysEff_Summary.HyperLink = Nothing
			Me.lblSysEff_Summary.Left = 0.0625F
			Me.lblSysEff_Summary.Name = "lblSysEff_Summary"
			Me.lblSysEff_Summary.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSysEff_Summary.Text = "Score 100 - No recommendations for improvements are necessary"
			Me.lblSysEff_Summary.Top = 2.6875F
			Me.lblSysEff_Summary.Width = 7.5F
			Me.lblSL_Summary.Height = 0.5625F
			Me.lblSL_Summary.HyperLink = Nothing
			Me.lblSL_Summary.Left = 0.0625F
			Me.lblSL_Summary.Name = "lblSL_Summary"
			Me.lblSL_Summary.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblSL_Summary.Text = "Score 100 - No recommendations for improvements are necessary"
			Me.lblSL_Summary.Top = 1.9375F
			Me.lblSL_Summary.Width = 7.5F
			Me.lblBottomMinStressSCORE.Height = 0.1875F
			Me.lblBottomMinStressSCORE.HyperLink = Nothing
			Me.lblBottomMinStressSCORE.Left = 0.0625F
			Me.lblBottomMinStressSCORE.Name = "lblBottomMinStressSCORE"
			Me.lblBottomMinStressSCORE.Style = "background-color: Gainsboro; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblBottomMinStressSCORE.Text = "BOTTOM MINIMUM STRESS SCORE: "
			Me.lblBottomMinStressSCORE.Top = 3.625F
			Me.lblBottomMinStressSCORE.Width = 7.5F
			Me.lblBotMin_Summary.Height = 0.5625F
			Me.lblBotMin_Summary.HyperLink = Nothing
			Me.lblBotMin_Summary.Left = 0.0625F
			Me.lblBotMin_Summary.Name = "lblBotMin_Summary"
			Me.lblBotMin_Summary.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblBotMin_Summary.Text = "Score 100 - No recommendations for improvements are necessary"
			Me.lblBotMin_Summary.Top = 3.8125F
			Me.lblBotMin_Summary.Width = 7.5F
			Me.lblGB_Summary.Height = 0.5625F
			Me.lblGB_Summary.HyperLink = Nothing
			Me.lblGB_Summary.Left = 0.0625F
			Me.lblGB_Summary.Name = "lblGB_Summary"
			Me.lblGB_Summary.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblGB_Summary.Text = "Score 100 - No recommendations for improvements are necessary"
			Me.lblGB_Summary.Top = 0.4375F
			Me.lblGB_Summary.Width = 7.5F
			Me.lblMPRL.Height = 0.1875F
			Me.lblMPRL.HyperLink = Nothing
			Me.lblMPRL.Left = 0.0625F
			Me.lblMPRL.Name = "lblMPRL"
			Me.lblMPRL.Style = "background-color: Gainsboro; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblMPRL.Text = "MINIMUM POLISHED ROD LOAD SCORE: "
			Me.lblMPRL.Top = 4.375F
			Me.lblMPRL.Width = 7.5F
			Me.lblMPRL_Summary.Height = 0.5625F
			Me.lblMPRL_Summary.HyperLink = Nothing
			Me.lblMPRL_Summary.Left = 0.0625F
			Me.lblMPRL_Summary.Name = "lblMPRL_Summary"
			Me.lblMPRL_Summary.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblMPRL_Summary.Text = "Score 100 - No recommendations for improvements are necessary"
			Me.lblMPRL_Summary.Top = 4.5625F
			Me.lblMPRL_Summary.Width = 7.5F
			Me.lblTOTALSCORE_NoRec.Height = 0.1875F
			Me.lblTOTALSCORE_NoRec.HyperLink = Nothing
			Me.lblTOTALSCORE_NoRec.Left = 0.0625F
			Me.lblTOTALSCORE_NoRec.Name = "lblTOTALSCORE_NoRec"
			Me.lblTOTALSCORE_NoRec.Style = "font-family: Microsoft Sans Serif; font-size: 9.75pt; text-align: left; white-space: inherit"
			Me.lblTOTALSCORE_NoRec.Text = "No recommendations for improvements are necessary"
			Me.lblTOTALSCORE_NoRec.Top = 0.25F
			Me.lblTOTALSCORE_NoRec.Visible = False
			Me.lblTOTALSCORE_NoRec.Width = 7.5F
			Me.GroupFooter1.Height = 0.02083333F
			Me.GroupFooter1.Name = "GroupFooter1"
			Me.lblSBFootnote.Height = 0.1875F
			Me.lblSBFootnote.HyperLink = Nothing
			Me.lblSBFootnote.Left = 0.0625F
			Me.lblSBFootnote.Name = "lblSBFootnote"
			Me.lblSBFootnote.Style = "background-color: White; font-family: Microsoft Sans Serif; font-size: 9.75pt"
			Me.lblSBFootnote.Text = "NOTE: "
			Me.lblSBFootnote.Top = 5.44F
			Me.lblSBFootnote.Visible = False
			Me.lblSBFootnote.Width = 7.5F
			Me.MasterReport = False
			Me.MaxPages = 1L
			Me.PageSettings.Margins.Bottom = 0F
			Me.PageSettings.Margins.Left = 0.3F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0.5F
			Me.PageSettings.PaperHeight = 11F
			Me.PageSettings.PaperWidth = 8.5F
			Me.PrintWidth = 8F
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
			CType(Me.lblTOTALSCORE, ISupportInitialize).EndInit()
			CType(Me.lblGEARBOXSCORE, ISupportInitialize).EndInit()
			CType(Me.lblRODLOADINGSCORE, ISupportInitialize).EndInit()
			CType(Me.lblSTRUCTURELOADINGSCORE, ISupportInitialize).EndInit()
			CType(Me.lblSYSTEMEFFICIENCYSCORE, ISupportInitialize).EndInit()
			CType(Me.lblRL_Summary, ISupportInitialize).EndInit()
			CType(Me.lblSysEff_Summary, ISupportInitialize).EndInit()
			CType(Me.lblSL_Summary, ISupportInitialize).EndInit()
			CType(Me.lblBottomMinStressSCORE, ISupportInitialize).EndInit()
			CType(Me.lblBotMin_Summary, ISupportInitialize).EndInit()
			CType(Me.lblGB_Summary, ISupportInitialize).EndInit()
			CType(Me.lblMPRL, ISupportInitialize).EndInit()
			CType(Me.lblMPRL_Summary, ISupportInitialize).EndInit()
			CType(Me.lblTOTALSCORE_NoRec, ISupportInitialize).EndInit()
			CType(Me.lblSBFootnote, ISupportInitialize).EndInit()
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		Public Property sTapersOverMax As String
			Get
				Return Me.m_sTapersOverMax
			End Get
			Set(value As String)
				Me.m_sTapersOverMax = value
			End Set
		End Property

		Public Property bForceDisplay As Boolean
			Get
				Return Me.m_bForceDisplay
			End Get
			Set(value As Boolean)
				Me.m_bForceDisplay = value
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

		Public Sub rptExpertSummary_FetchData(sender As Object, eArgs As ActiveReport.FetchEventArgs)
			If Me.I < 1 Then
				eArgs.EOF = False
			Else
				eArgs.EOF = True
			End If
			Me.I += 1
		End Sub

		Public Sub rptExpertSummary_ReportStart(sender As Object, e As EventArgs)
			Dim num As Single = 0F
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
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
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bReadResXFile Then
				Me.ReadReportControlStrings()
			End If
			Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
			Dim num2 As Integer = Me.SetGearboxLoadingScore()
			Dim flag3 As Boolean
			Dim num3 As Integer = Me.SetMaxRodLoadingScore(flag3)
			Dim num4 As Integer = Me.SetStructureLoadingScore(False)
			Dim num5 As Integer = Me.SetSYSTEMEFFICIENCYScore()
			Dim num6 As Integer = Me.SetBotMinStressScore(flag, flag2)
			Dim num7 As Integer = Me.SetMPRLScore()
			If num2 = 0 Or num3 = 0 Or num4 = 0 Or num5 = 0 Or num7 = 0 Then
				num = 0.35F
				Dim label As Label = Me.lblTOTALSCORE
				Dim array As String() = New String(5) {}
				array(0) = Me.sTOTALSCORE
				Dim array2 As String() = array
				Dim num8 As Integer = 1
				Dim text As String = "###%"
				array2(num8) = Util.Format(num, text)
				array(2) = "  "
				array(3) = Me.sGrade
				array(4) = ": "
				array(5) = RSWIN.GetScoreGrade(num)
				label.Text = String.Concat(array)
			ElseIf flag Then
				num = CSng((CDbl((num2 + num3 + num4 + num5 + num6 + num7)) / 100.0 / 6.0))
				Dim label2 As Label = Me.lblTOTALSCORE
				Dim obj As Object = Me.sSystemDesignScore
				Dim text As String = "###%"
				label2.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj, Util.Format(num, text)), Me.sGrade), " "), RSWIN.GetScoreGrade(num)))
			Else
				num = CSng((CDbl((num2 + num3 + num4 + num5 + num7)) / 100.0 / 5.0))
				Dim label3 As Label = Me.lblTOTALSCORE
				Dim obj2 As Object = Me.sSystemDesignScore
				Dim text As String = "###%"
				label3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj2, Util.Format(num, text)), Me.sGrade), " "), RSWIN.GetScoreGrade(num)))
			End If
			If CDbl(num) >= 0.99 And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.95 And CDbl(RSWIN_DESC.rst.StructL) <= 0.95 And Not Me.bForceDisplay Then
				Me.lblTOTALSCORE_NoRec.Visible = True
				Me.lblGEARBOXSCORE.Visible = False
				Me.lblGB_Summary.Visible = False
				Me.lblRL_Summary.Visible = False
				Me.lblRODLOADINGSCORE.Visible = False
				Me.lblSL_Summary.Visible = False
				Me.lblSTRUCTURELOADINGSCORE.Visible = False
				Me.lblSysEff_Summary.Visible = False
				Me.lblSYSTEMEFFICIENCYSCORE.Visible = False
				Me.lblBottomMinStressSCORE.Visible = False
				Me.lblBotMin_Summary.Visible = False
				Me.lblMPRL.Visible = False
				Me.lblMPRL_Summary.Visible = False
			Else
				Me.lblTOTALSCORE_NoRec.Visible = False
				Me.lblGEARBOXSCORE.Visible = True
				Me.lblGB_Summary.Visible = True
				Me.lblRL_Summary.Visible = True
				Me.lblRODLOADINGSCORE.Visible = True
				Me.lblSL_Summary.Visible = True
				Me.lblSTRUCTURELOADINGSCORE.Visible = True
				Me.lblSysEff_Summary.Visible = True
				Me.lblSYSTEMEFFICIENCYSCORE.Visible = True
				Me.lblBottomMinStressSCORE.Visible = True
				Me.lblBotMin_Summary.Visible = True
				Me.lblMPRL.Visible = True
				Me.lblMPRL_Summary.Visible = True
			End If
			If RSWIN_DESC.rst.PU.UnitType = 10S Then
				Dim num9 As Single = Me.lblGB_Summary.Top + Me.lblGEARBOXSCORE.Top
				Me.lblGB_Summary.Visible = False
				Me.lblGEARBOXSCORE.Visible = False
				Me.lblRODLOADINGSCORE.Top = Me.lblRODLOADINGSCORE.Top - num9
				Me.lblRL_Summary.Top = Me.lblRL_Summary.Top - num9
				Me.lblSTRUCTURELOADINGSCORE.Top = Me.lblSTRUCTURELOADINGSCORE.Top - num9
				Me.lblSL_Summary.Top = Me.lblSL_Summary.Top - num9
				Me.lblSYSTEMEFFICIENCYSCORE.Top = Me.lblSYSTEMEFFICIENCYSCORE.Top - num9
				Me.lblSysEff_Summary.Top = Me.lblSysEff_Summary.Top - num9
				Me.lblBottomMinStressSCORE.Top = Me.lblBottomMinStressSCORE.Top - num9
				Me.lblBotMin_Summary.Top = Me.lblBotMin_Summary.Top - num9
				Me.lblMPRL.Top = Me.lblMPRL.Top - num9
				Me.lblMPRL_Summary.Top = Me.lblMPRL_Summary.Top - num9
			Else
				Me.lblGB_Summary.Visible = True
				Me.lblGEARBOXSCORE.Visible = True
			End If
			Try
				Dim num10 As Integer
				If Me.bHasRelocatedSB(num10) Then
					Me.lblSBFootnote.Text = RSWIN_DESC.sSBRelocateFootnote
					Me.lblSBFootnote.Top = CSng((CDbl((Me.lblMPRL_Summary.Top + Me.lblMPRL_Summary.Height)) + 0.125))
					Me.lblSBFootnote.Visible = True
				Else
					Me.lblSBFootnote.Text = ""
					Me.lblSBFootnote.Visible = False
				End If
			Catch ex As Exception
			End Try
			If RSWIN_DESC.bIntVersion Then
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter("rptExpertSummary")
					Me.WriteControlStrings()
					Util.CloseResourceWriter()
				End If
				Return
			End If
		End Sub

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
			cRODSTAR = Nothing
		End Sub

		Public Function SetGearboxLoadingScore() As Integer
			Dim result As Integer
			Try
				Dim num As Integer = 0
				Dim text As String = ""
				Dim flag As Boolean = False
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					num = 100
				Else
					Try
						If Operators.CompareString(RSWIN_DESC.SmallestUnitID.Trim(), "", False) = 0 Then
							PUDATA1.FindSmallestUnitID()
						Else
							Dim text2 As String
							Dim num2 As Integer
							PUDATA1.ParseUnitID(RSWIN_DESC.SmallestUnitID, text2, num2)
							Dim text3 As String
							Dim num3 As Integer
							PUDATA1.ParseUnitID(RSWIN_DESC.rst.UnitID, text3, num3)
							If Operators.CompareString(text3, text2, False) <> 0 Then
								PUDATA1.FindSmallestUnitID()
							End If
						End If
					Catch ex As Exception
					End Try
					Try
						If Operators.CompareString(RSWIN_DESC.rst.UnitID, RSWIN_DESC.SmallestUnitID, False) = 0 And Operators.CompareString(RSWIN_DESC.SmallestUnitID.Trim(), "", False) <> 0 Then
							flag = True
						ElseIf Operators.CompareString(RSWIN_DESC.SmallestUnitID.Trim(), "", False) = 0 Then
							RSWIN_DESC.bSmallestUnitGearbox = False
						End If
					Catch ex2 As Exception
						flag = False
					End Try
					Me.lblGB_Summary.ForeColor = Color.Black
					Dim num4 As Single = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)
					If RSWIN_DESC.bCheckSmallestUnit AndAlso flag Then
						If CDbl(num4) < 0.7 Then
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
						text = Me.sNoRecommendationsNecessary
					ElseIf flag2 = (CDbl(num4) >= 0.7 And CDbl(num4) <= 0.95) Then
						num = 100
						text = Me.sNoRecommendationsNecessary
					ElseIf flag2 = (num4 >= 0F And CDbl(num4) < 0.5) Then
						Dim text4 As String = Me.sGBLoad_0_5
						Dim oldValue As String = "X%"
						Dim text5 As String = "0%"
						text = text4.Replace(oldValue, Util.Format(num4, text5))
						num = 60
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num4) >= 0.7 And CDbl(num4) < 0.75) Then
						text = Me.sNoRecommendationsNecessary
						num = 98
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num4) >= 0.75 And CDbl(num4) < 0.8) Then
						text = Me.sNoRecommendationsNecessary
						num = 99
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num4) >= 0.8 And CDbl(num4) < 0.85) Then
						text = Me.sNoRecommendationsNecessary
						num = 100
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num4) >= 0.85 And CDbl(num4) < 0.9) Then
						text = Me.sNoRecommendationsNecessary
						num = 99
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num4) >= 0.9 And CDbl(num4) < 0.95) Then
						text = Me.sNoRecommendationsNecessary
						num = 97
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num4) >= 0.6 And CDbl(num4) < 0.7) Then
						Dim text6 As String = Me.sGBLoad_6_7
						Dim oldValue2 As String = "X%"
						Dim text5 As String = "0%"
						text = text6.Replace(oldValue2, Util.Format(num4, text5))
						num = 85
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num4) >= 0.5 And CDbl(num4) < 0.6) Then
						num = 70
						Dim text7 As String = Me.sGBLoad_5_6
						Dim oldValue3 As String = "X%"
						Dim text5 As String = "0%"
						text = text7.Replace(oldValue3, Util.Format(num4, text5))
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = CDbl(num4) < 0.5 Then
						num = 60
						Dim text8 As String = Me.sGBLoad_5
						Dim oldValue4 As String = "X%"
						Dim text5 As String = "0%"
						text = text8.Replace(oldValue4, Util.Format(num4, text5))
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num4) > 0.95 And num4 <= 1F) Then
						num = 75
						Dim text9 As String = Me.sGBLoad_95_1
						Dim oldValue5 As String = "X%"
						Dim text5 As String = "0%"
						text = text9.Replace(oldValue5, Util.Format(num4, text5))
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = (num4 > 1F And CDbl(num4) <= 1.1) Then
						num = 35
						If Not Me.SmallerStrokeLengthAvailable() Then
							Dim text10 As String = Me.sGBLoad_1_12
							Dim oldValue6 As String = "X%"
							Dim text5 As String = "0%"
							text = text10.Replace(oldValue6, Util.Format(num4, text5))
						Else
							Dim text11 As String = Me.sGBLoad_1_12_b
							Dim oldValue7 As String = "X%"
							Dim text5 As String = "0%"
							text = text11.Replace(oldValue7, Util.Format(num4, text5))
						End If
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num4) > 1.1 And CDbl(num4) <= 1.2) Then
						If Not Me.SmallerStrokeLengthAvailable() Then
							Dim text12 As String = Me.sGBLoad_1_12
							Dim oldValue8 As String = "X%"
							Dim text5 As String = "0%"
							text = text12.Replace(oldValue8, Util.Format(num4, text5))
						Else
							Dim text13 As String = Me.sGBLoad_1_12_b
							Dim oldValue9 As String = "X%"
							Dim text5 As String = "0%"
							text = text13.Replace(oldValue9, Util.Format(num4, text5))
						End If
						num = 20
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = (CDbl(num4) > 1.2 And CDbl(num4) <= 1.35) Then
						num = 10
						If Not Me.SmallerStrokeLengthAvailable() Then
							Dim text14 As String = Me.sGBLoad_12_135
							Dim oldValue10 As String = "X%"
							Dim text5 As String = "0%"
							text = text14.Replace(oldValue10, Util.Format(num4, text5))
						Else
							Dim text15 As String = Me.sGBLoad_12_135_b
							Dim oldValue11 As String = "X%"
							Dim text5 As String = "0%"
							text = text15.Replace(oldValue11, Util.Format(num4, text5))
						End If
						Me.lblGB_Summary.ForeColor = Color.Red
					ElseIf flag2 = CDbl(num4) > 1.35 Then
						num = 0
						If Not Me.SmallerStrokeLengthAvailable() Then
							Dim text16 As String = Me.sGBLoad_135
							Dim oldValue12 As String = "X%"
							Dim text5 As String = "0%"
							text = text16.Replace(oldValue12, Util.Format(num4, text5))
						Else
							Dim text17 As String = Me.sGBLoad_135_b
							Dim oldValue13 As String = "X%"
							Dim text5 As String = "0%"
							text = text17.Replace(oldValue13, Util.Format(num4, text5))
						End If
						Me.lblGB_Summary.ForeColor = Color.Red
					End If
					Me.lblGEARBOXSCORE.Text = Me.sGEARBOXSCORE + num.ToString()
					Me.lblGB_Summary.Text = text
				End If
				result = num
			Catch ex3 As Exception
			End Try
			Return result
		End Function

		Public Function SetStructureLoadingScore(Optional bCheckSmallerSL As Boolean = False) As Integer
			Dim text As String = ""
			Dim result As Integer
			Try
				Dim flag As Boolean = False
				Try
					If Operators.CompareString(RSWIN_DESC.rst.UnitID, RSWIN_DESC.SmallestUnitID, False) = 0 And Operators.CompareString(RSWIN_DESC.SmallestUnitID.Trim(), "", False) <> 0 Then
						flag = True
					End If
				Catch ex As Exception
					flag = False
				End Try
				Me.lblSL_Summary.ForeColor = Color.Black
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
				Try
					Dim text2 As String
					If(bCheckSmallerSL And CDbl(structL) < 0.7 And Not RSWIN_DESC.bSmallestUnitStructL) AndAlso Not PUDATA1.CheckForSmallerStructure(RSWIN_DESC.rst.PU.GearboxRating, RSWIN_DESC.rst.PU.StructRating, RSWIN_DESC.rst.PU.MaxStroke, True, text2) Then
						RSWIN_DESC.bSmallestUnitStructL = True
					End If
				Catch ex2 As Exception
				End Try
				Dim flag2 As Boolean = True
				Dim num As Integer
				If flag2 = (RSWIN_DESC.bCheckSmallestUnit And RSWIN_DESC.bSmallestUnitStructL) Then
					num = 100
					text = Me.sNoRecommendationsNecessary
				ElseIf flag2 = (CDbl(structL) >= 0.7 And CDbl(structL) <= 0.95) Then
					num = 100
					text = Me.sNoRecommendationsNecessary
				ElseIf flag2 = (CDbl(structL) >= 0.6 And CDbl(structL) < 0.7) Then
					num = 90
					Dim text3 As String = Me.sSLoad_6_7
					Dim oldValue As String = "(X)"
					Dim num2 As Single = structL * 100F
					Dim text4 As String = "###"
					text = text3.Replace(oldValue, Util.Format(num2, text4))
					Me.lblSL_Summary.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(structL) >= 0.5 And CDbl(structL) < 0.6) Then
					num = 70
					Dim text5 As String = Me.sSLoad_5_6
					Dim oldValue2 As String = "(X)"
					Dim num2 As Single = structL * 100F
					Dim text4 As String = "###"
					text = text5.Replace(oldValue2, Util.Format(num2, text4))
					Me.lblSL_Summary.ForeColor = Color.Red
				ElseIf flag2 = CDbl(structL) < 0.5 Then
					num = 60
					Dim text6 As String = Me.sSLoad_5
					Dim oldValue3 As String = "(X)"
					Dim num2 As Single = structL * 100F
					Dim text4 As String = "###"
					text = text6.Replace(oldValue3, Util.Format(num2, text4))
					Me.lblSL_Summary.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(structL) > 0.95 And CDbl(structL) <= 0.98) Then
					num = 98
					text = Me.sNoRecommendationsNecessary
					Me.lblSL_Summary.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(structL) > 0.98 And structL <= 1F) Then
					num = 80
					Dim text7 As String = Me.sSLoad_95_1
					Dim oldValue4 As String = "(X)"
					Dim num2 As Single = structL * 100F
					Dim text4 As String = "###"
					text = text7.Replace(oldValue4, Util.Format(num2, text4))
					Me.lblSL_Summary.ForeColor = Color.Red
				ElseIf flag2 = (structL > 1F And CDbl(structL) <= 1.05) Then
					num = 50
					Dim text8 As String = Me.sSLoad_1_11
					Dim oldValue5 As String = "(X)"
					Dim num2 As Single = structL * 100F
					Dim text4 As String = "###"
					text = text8.Replace(oldValue5, Util.Format(num2, text4))
					Me.lblSL_Summary.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(structL) > 1.05 And CDbl(structL) <= 1.1) Then
					num = 30
					Dim text9 As String = Me.sSLoad_1_11
					Dim oldValue6 As String = "(X)"
					Dim num2 As Single = structL * 100F
					Dim text4 As String = "###"
					text = text9.Replace(oldValue6, Util.Format(num2, text4))
					Me.lblSL_Summary.ForeColor = Color.Red
				ElseIf flag2 = (CDbl(structL) > 1.1 And CDbl(structL) <= 1.2) Then
					num = 10
					Dim text10 As String = Me.sSLoad_11_12
					Dim oldValue7 As String = "(X)"
					Dim num2 As Single = structL * 100F
					Dim text4 As String = "###"
					text = text10.Replace(oldValue7, Util.Format(num2, text4))
					Me.lblSL_Summary.ForeColor = Color.Red
				ElseIf flag2 = CDbl(structL) > 1.2 Then
					num = 0
					Dim text11 As String = Me.sSLoad_120
					Dim oldValue8 As String = "(X)"
					Dim num2 As Single = structL * 100F
					Dim text4 As String = "###"
					text = text11.Replace(oldValue8, Util.Format(num2, text4))
					Me.lblSL_Summary.ForeColor = Color.Red
				End If
				Dim num3 As Short
				Dim num4 As Short
				If RODUTIL.IsCorod(RSWIN_DESC.HSGradeRod) Then
					Dim hsgradeRod As Short = RSWIN_DESC.HSGradeRod
					If hsgradeRod = 12547S OrElse hsgradeRod = 12549S OrElse hsgradeRod = 12550S OrElse hsgradeRod = 12548S Then
						num3 = 12546S
						num4 = 12545S
					ElseIf hsgradeRod = 12802S OrElse hsgradeRod = 12803S OrElse hsgradeRod = 12805S OrElse hsgradeRod = 12806S OrElse hsgradeRod = 13057S OrElse hsgradeRod = 12808S OrElse hsgradeRod = 12807S Then
						num3 = 12801S
						num4 = 12804S
					End If
				ElseIf RODUTIL.IsProRod(CInt(RSWIN_DESC.HSGradeRod)) <> 0 Then
					num3 = 24580S
					num4 = 24579S
				Else
					num3 = 4099S
					num4 = 4098S
				End If
				If(CDbl(structL) > 0.95 And CDbl(structL) <= 1.05 And Me.bIsSB(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade))) AndAlso RSWIN_DESC.rst.NumRods > 1S AndAlso (RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade = 4098S Or RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade = num4 Or (RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade = 4099S Or RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade = num3) Or RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade = 4097S) AndAlso CDbl(RSWIN_DESC.rst.StressL(CInt((RSWIN_DESC.rst.NumRods - 1S)))) >= 0.9 Then
					text += Me.sSLoad_95_105
				End If
				Me.lblSTRUCTURELOADINGSCORE.Text = Me.sSTRUCTURELOADINGSCORE + num.ToString()
				Me.lblSL_Summary.Text = text
				result = num
			Catch ex3 As Exception
			End Try
			Return result
		End Function

		Public Function SetMaxRodLoadingScore(ByRef bCheckForFGSteelUnderloading As Boolean) As Integer
			Dim result As Integer
			Try
				Dim flag As Boolean = False
				Dim num As Single = 0F
				Dim text As String = ""
				Dim num2 As Single = 0F
				bCheckForFGSteelUnderloading = False
				Me.lblRL_Summary.ForeColor = Color.Black
				Dim num3 As Single = -(flag > False)
				Dim flag2 As Boolean
				Dim maxRodLoad As Single = Me.GetMaxRodLoad(num3, num, flag2, num2)
				flag = (num3 <> 0F)
				Dim num4 As Single = maxRodLoad
				Dim flag3 As Boolean = True
				Dim num5 As Integer
				If flag3 = (flag And CDbl(num) < 0.7) Then
					num5 = 100
					text = Me.sNoRecommendationsNecessary
				ElseIf flag3 = (CDbl(num4) >= 0.7 And CDbl(num4) <= 0.95) Then
					num5 = 100
					text = Me.sNoRecommendationsNecessary
				ElseIf flag3 = (CDbl(num4) >= 0.6 And CDbl(num4) < 0.7) Then
					Dim text2 As String = Me.sMaxRodLoad_6_7
					Dim oldValue As String = "X%"
					Dim text3 As String = "0%"
					text = text2.Replace(oldValue, Util.Format(num4, text3))
					num5 = 90
					Me.lblRL_Summary.ForeColor = Color.Red
				ElseIf flag3 = (CDbl(num4) >= 0.7 And CDbl(num4) < 0.75) Then
					text = Me.sNoRecommendationsNecessary
					num5 = 98
					Me.lblRL_Summary.ForeColor = Color.Red
				ElseIf flag3 = (CDbl(num4) >= 0.75 And CDbl(num4) < 0.85) Then
					text = Me.sNoRecommendationsNecessary
					num5 = 100
					Me.lblRL_Summary.ForeColor = Color.Red
				ElseIf flag3 = (CDbl(num4) >= 0.85 And CDbl(num4) < 0.9) Then
					text = Me.sNoRecommendationsNecessary
					num5 = 98
					Me.lblRL_Summary.ForeColor = Color.Red
				ElseIf flag3 = (CDbl(num4) >= 0.9 And CDbl(num4) < 0.95) Then
					text = Me.sNoRecommendationsNecessary
					num5 = 97
					Me.lblRL_Summary.ForeColor = Color.Red
				ElseIf flag3 = (CDbl(num4) >= 0.5 And CDbl(num4) < 0.6) Then
					num5 = 75
					Dim text4 As String = Me.sMaxRodLoad_5_6
					Dim oldValue2 As String = "X%"
					Dim text3 As String = "0%"
					text = text4.Replace(oldValue2, Util.Format(num4, text3))
					Me.lblRL_Summary.ForeColor = Color.Red
				ElseIf flag3 = (CDbl(num4) >= 0.4 And CDbl(num4) < 0.5) Then
					num5 = 60
					Dim text5 As String = Me.sMaxRodLoad_4_5
					Dim oldValue3 As String = "X%"
					Dim text3 As String = "0%"
					text = text5.Replace(oldValue3, Util.Format(num4, text3))
					Me.lblRL_Summary.ForeColor = Color.Red
				ElseIf flag3 = CDbl(num4) < 0.4 Then
					num5 = 50
					Dim text6 As String = Me.sMaxRodLoad_4
					Dim oldValue4 As String = "X%"
					Dim text3 As String = "0%"
					text = text6.Replace(oldValue4, Util.Format(num4, text3))
					Me.lblRL_Summary.ForeColor = Color.Red
				ElseIf flag3 = (CDbl(num4) >= 0.95 And num4 < 1F) Then
					num5 = 45
					Dim text7 As String = Me.sMaxRodLoad_95_1
					Dim oldValue5 As String = "X%"
					Dim text3 As String = "0%"
					text = text7.Replace(oldValue5, Util.Format(num4, text3))
					Me.lblRL_Summary.ForeColor = Color.Red
				ElseIf flag3 = (num4 >= 1F And CDbl(num4) < 1.1) Then
					num5 = 25
					If Not flag2 Then
						Dim text8 As String = Me.sMaxRodLoad_1_11
						Dim oldValue6 As String = "X%"
						Dim text3 As String = "0%"
						text = text8.Replace(oldValue6, Util.Format(num4, text3))
					Else
						Dim text9 As String = Me.sMaxRodLoad_1_11_sb
						Dim oldValue7 As String = "X%"
						Dim text3 As String = "0%"
						text = text9.Replace(oldValue7, Util.Format(num4, text3))
					End If
					Me.lblRL_Summary.ForeColor = Color.Red
				ElseIf flag3 = (CDbl(num4) >= 1.1 And CDbl(num4) < 1.2) Then
					num5 = 5
					If Not flag2 Then
						Dim text10 As String = Me.sMaxRodLoad_11_12
						Dim oldValue8 As String = "X%"
						Dim text3 As String = "0%"
						text = text10.Replace(oldValue8, Util.Format(num4, text3))
					Else
						Dim text11 As String = Me.sMaxRodLoad_11_12_sb
						Dim oldValue9 As String = "X%"
						Dim text3 As String = "0%"
						text = text11.Replace(oldValue9, Util.Format(num4, text3))
					End If
					Me.lblRL_Summary.ForeColor = Color.Red
				ElseIf flag3 = CDbl(num4) > 1.2 Then
					num5 = 0
					If Not flag2 Then
						Dim text12 As String = Me.sMaxRodLoad_12
						Dim oldValue10 As String = "X%"
						Dim text3 As String = "0%"
						text = text12.Replace(oldValue10, Util.Format(num4, text3))
					Else
						Dim text13 As String = Me.sMaxRodLoad_12_sb
						Dim oldValue11 As String = "X%"
						Dim text3 As String = "0%"
						text = text13.Replace(oldValue11, Util.Format(num4, text3))
					End If
					Me.lblRL_Summary.ForeColor = Color.Red
				End If
				Me.lblRODLOADINGSCORE.Text = Me.sRODLOADINGSCORE + num5.ToString()
				If Operators.CompareString(Me.m_sTapersOverMax.Trim(), "", False) <> 0 Then
					If Strings.InStr(Me.m_sTapersOverMax, ",", CompareMethod.Binary) = 0 And Strings.InStr(Me.m_sTapersOverMax, "and", CompareMethod.Binary) = 0 Then
						text = Conversions.ToString(Operators.ConcatenateObject(text + vbCrLf, NewLateBinding.LateGet(Me.sMaxRodGuidesExceeded_s, Nothing, "Replace", New Object() { "taper", "taper " + Me.m_sTapersOverMax + " " }, Nothing, Nothing, Nothing)))
					Else
						text = Conversions.ToString(Operators.ConcatenateObject(text + vbCrLf, NewLateBinding.LateGet(Me.sMaxRodGuidesExceeded_p, Nothing, "Replace", New Object() { "tapers", "tapers " + Me.m_sTapersOverMax + " " }, Nothing, Nothing, Nothing)))
					End If
				End If
				Me.lblRL_Summary.Text = text
				If RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And CDbl(num2) < 0.75 Then
					bCheckForFGSteelUnderloading = True
				End If
				result = num5
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetMaxRodLoad(ByRef bRodGradeC As Single, ByRef fCStressL As Single, ByRef bSB As Boolean, ByRef fSteelLoading As Single) As Single
			' The following expression was wrapped in a checked-statement
			Dim result As Single
			Try
				Dim num As Short
				If RODUTIL.IsCorod(RSWIN_DESC.HSGradeRod) Then
					Dim hsgradeRod As Short = RSWIN_DESC.HSGradeRod
					If hsgradeRod = 12547S OrElse hsgradeRod = 12549S OrElse hsgradeRod = 12550S OrElse hsgradeRod = 12548S Then
						num = 12545S
					ElseIf hsgradeRod = 12802S OrElse hsgradeRod = 12803S OrElse hsgradeRod = 12805S OrElse hsgradeRod = 12806S OrElse hsgradeRod = 13057S OrElse hsgradeRod = 12808S OrElse hsgradeRod = 12807S Then
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
				Dim num4 As Integer
				For i As Integer = num3 To numRods
					If RSWIN_DESC.rst.StressL(i) > num2 Then
						num2 = RSWIN_DESC.rst.StressL(i)
						num4 = i
					End If
					If RSWIN_DESC.rst.Sections(i).Grade = 4098S Or RSWIN_DESC.rst.Sections(i).Grade = num Then
						bRodGradeC = -1F
						If RSWIN_DESC.rst.StressL(i) > fCStressL Then
							fCStressL = RSWIN_DESC.rst.StressL(i)
						End If
					End If
				Next
				Try
					If num4 = CInt(RSWIN_DESC.rst.NumRods) And Me.bIsSB(CInt(RSWIN_DESC.rst.Sections(num4).Grade)) Then
						bSB = True
					Else
						bSB = False
					End If
				Catch ex As Exception
				End Try
				If RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					fSteelLoading = 100000F
					Dim num5 As Integer = 1
					Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num5 To numRods2
						' The following expression was wrapped in a unchecked-expression
						If(RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Or If((-If((CUSTOMRG.IsOtherSteel(CInt(RSWIN_DESC.rst.Sections(i).Grade)) > False), 1, 0)), 1, 0)) And If((-If((Not Me.bIsSB(CInt(RSWIN_DESC.rst.Sections(i).Grade)) > False), 1, 0)), 1, 0) <> 0 AndAlso RSWIN_DESC.rst.StressL(i) <= fSteelLoading Then
							fSteelLoading = RSWIN_DESC.rst.StressL(i)
						End If
					Next
				End If
				result = num2
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Public Function SetSYSTEMEFFICIENCYScore() As Integer
			Dim result As Integer
			Try
				Dim text As String = ""
				Dim str As String = vbTab & vbTab & vbTab & vbTab & vbTab
				Me.lblSysEff_Summary.ForeColor = Color.Black
				Dim num As Double = CDbl(RSWIN_DESC.rst.SystemEff)
				Dim flag As Boolean = True
				Dim num2 As Integer
				If flag = num >= 0.5 Then
					num2 = 100
					text = Me.sNoRecommendationsNecessary
				ElseIf flag = (num >= 0.45 And num < 0.5) Then
					Dim text2 As String = Me.sSysEff_45_5_a
					Dim oldValue As String = "(X)"
					Dim num3 As Double = num * 100.0
					Dim text3 As String = "###.#"
					text = text2.Replace(oldValue, Util.Format(num3, text3)) + vbCrLf
					text = text + str + Me.sSysEff_45_5_b + vbCrLf
					text = text + str + Me.sSysEff_45_5_c + vbCrLf
					text = text + str + Me.sSysEff_45_5_d + vbCrLf
					text = text + str + Me.sSysEff_45_5_e
					num2 = 100
					Me.lblSysEff_Summary.ForeColor = Color.Black
				ElseIf flag = (num >= 0.42 And num < 0.45) Then
					Dim text4 As String = Me.sSysEff_42_45_a
					Dim oldValue2 As String = "(X)"
					Dim num3 As Double = num * 100.0
					Dim text3 As String = "###.#"
					text = text4.Replace(oldValue2, Util.Format(num3, text3)) + vbCrLf
					text = text + str + Me.sSysEff_42_45_b + vbCrLf
					text = text + str + Me.sSysEff_42_45_c + vbCrLf
					text = text + str + Me.sSysEff_42_45_d + vbCrLf
					text = text + str + Me.sSysEff_42_45_e
					num2 = 95
					Me.lblSysEff_Summary.ForeColor = Color.Black
				ElseIf flag = (num >= 0.4 And num < 0.42) Then
					num2 = 90
					Dim text5 As String = Me.sSysEff_4_42_a
					Dim oldValue3 As String = "(X)"
					Dim num3 As Double = num * 100.0
					Dim text3 As String = "###.#"
					text = text5.Replace(oldValue3, Util.Format(num3, text3)) + vbCrLf
					text = text + str + Me.sSysEff_4_42_b + vbCrLf
					text = text + str + Me.sSysEff_4_42_c + vbCrLf
					text = text + str + Me.sSysEff_4_42_d + vbCrLf
					text = text + str + Me.sSysEff_4_42_e
					Me.lblSysEff_Summary.ForeColor = Color.Red
				ElseIf flag = (num >= 0.35 And num < 0.4) Then
					num2 = 80
					Dim text6 As String = Me.sSysEff_35_4_a
					Dim oldValue4 As String = "(X)"
					Dim num3 As Double = num * 100.0
					Dim text3 As String = "###.#"
					text = text6.Replace(oldValue4, Util.Format(num3, text3)) + vbCrLf
					text = text + str + Me.sSysEff_35_4_b + vbCrLf
					text = text + str + Me.sSysEff_35_4_c + vbCrLf
					text = text + str + Me.sSysEff_35_4_d + vbCrLf
					If Not RSWIN_DESC.rst.PU.RequiredRotation <> 0S Then
						text = text + str + Me.sSysEff_35_4_e + vbCrLf
						text = text + str + Me.sTryChangingDirection
					Else
						text = text + str + Me.sSysEff_35_4_e
					End If
					Me.lblSysEff_Summary.ForeColor = Color.Red
				ElseIf flag = (num >= 0.3 And num <= 0.35) Then
					num2 = 65
					Dim text7 As String = Me.sSysEff_3_35_a
					Dim oldValue5 As String = "(X)"
					Dim num3 As Double = num * 100.0
					Dim text3 As String = "###.#"
					text = text7.Replace(oldValue5, Util.Format(num3, text3)) + vbCrLf
					text = text + str + Me.sSysEff_3_35_b + vbCrLf
					text = text + str + Me.sSysEff_3_35_c + vbCrLf
					text = text + str + Me.sSysEff_3_35_d + vbCrLf
					If Not RSWIN_DESC.rst.PU.RequiredRotation <> 0S Then
						text = text + str + Me.sSysEff_3_35_e + vbCrLf
						text = text + str + Me.sTryChangingDirection
					Else
						text = text + str + Me.sSysEff_3_35_e
					End If
					Me.lblSysEff_Summary.ForeColor = Color.Red
				ElseIf flag = (num >= 0.25 And num <= 0.3) Then
					num2 = 50
					Dim text8 As String = Me.sSysEff_25_3_a
					Dim oldValue6 As String = "(X)"
					Dim num3 As Double = num * 100.0
					Dim text3 As String = "###.#"
					text = text8.Replace(oldValue6, Util.Format(num3, text3)) + vbCrLf
					text = text + str + Me.sSysEff_25_3_b + vbCrLf
					text = text + str + Me.sSysEff_25_3_c + vbCrLf
					text = text + str + Me.sSysEff_25_3_d + vbCrLf
					If Not RSWIN_DESC.rst.PU.RequiredRotation <> 0S Then
						text = text + str + Me.sSysEff_25_3_e + vbCrLf
						text = text + str + Me.sTryChangingDirection
					Else
						text = text + str + Me.sSysEff_25_3_e
					End If
					Me.lblSysEff_Summary.ForeColor = Color.Red
				ElseIf flag = num < 0.25 Then
					num2 = 20
					If num <= 0.0 Then
						Dim text9 As String = Me.sSysEff_25_a
						Dim oldValue7 As String = "(X)"
						Dim num3 As Double = num * 100.0
						Dim text3 As String = "###.#"
						text = text9.Replace(oldValue7, Util.Format(num3, text3)) + vbCrLf
					ElseIf num = 0.0 Then
						text = Me.sSysEff_25_a.Replace("(X)", "0") + vbCrLf
					ElseIf num * 100.0 < 1.0 Then
						Dim text10 As String = Me.sSysEff_25_a
						Dim oldValue8 As String = "(X)"
						Dim num3 As Double = num * 100.0
						Dim text3 As String = "0.##"
						text = text10.Replace(oldValue8, Util.Format(num3, text3)) + vbCrLf
					Else
						Dim text11 As String = Me.sSysEff_25_a
						Dim oldValue9 As String = "(X)"
						Dim num3 As Double = num * 100.0
						Dim text3 As String = "###.#"
						text = text11.Replace(oldValue9, Util.Format(num3, text3)) + vbCrLf
					End If
					text = text + str + Me.sSysEff_25_b + vbCrLf
					text = text + str + Me.sSysEff_25_c + vbCrLf
					text = text + str + Me.sSysEff_25_d + vbCrLf
					If Not RSWIN_DESC.rst.PU.RequiredRotation <> 0S Then
						text = text + str + Me.sSysEff_25_e + vbCrLf
						text = text + str + Me.sTryChangingDirection
					Else
						text = text + str + Me.sSysEff_25_e
					End If
					Me.lblSysEff_Summary.ForeColor = Color.Red
				End If
				Me.lblSYSTEMEFFICIENCYSCORE.Text = Me.sSysEffScore + num2.ToString()
				If num2 >= 99 Then
					Me.lblSysEff_Summary.Text = Me.sNoRecommendationsNecessary
					Me.lblSysEff_Summary.ForeColor = Color.Black
				Else
					Me.lblSysEff_Summary.Text = text
				End If
				result = num2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function SetBotMinStressScore(ByRef bContinue As Boolean, ByRef bNoRec As Boolean) As Integer
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Dim num4 As Integer = 0
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim text As String = ""
			Dim result As Integer
			Try
				bContinue = False
				Dim flag4 As Boolean = Me.HasFG(num4)
				Dim num5 As Integer
				Dim flag5 As Boolean = Me.bIsSB(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) Or Me.bHasRelocatedSB(num5)
				If If((-If(((Not flag5 And RSWIN_DESC.rst.NumRods > 1S) > False), 1, 0)), 1, 0) And (RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) Or If((-If((CUSTOMRG.IsOtherSteel(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) > False), 1, 0)), 1, 0)) <> 0 AndAlso RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Diameter > RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Diameter Then
					flag = True
				End If
				If RSWIN_DESC.rst.NumRods = 1S Then
					Dim num6 As Single = RSWIN_DESC.rst.minStressBot(1)
					If flag4 Then
						flag3 = Me.GetFGBotMinStressScore(num6, num2)
					Else
						flag2 = Me.GetSTLBotMinStressScore(num6, num3)
					End If
					text = Me.SetBotMinStressScoreText(num6, flag5, flag, flag4, 1, 1, 0)
				ElseIf flag5 OrElse flag Then
					' The following expression was wrapped in a unchecked-expression
					If flag4 And num4 = 1 And RSWIN_DESC.rst.NumRods > 2S Then
						Dim num6 As Single = RSWIN_DESC.rst.minStressBot(num4)
						flag3 = Me.GetFGBotMinStressScore(num6, num2)
						flag2 = False
						If num6 < 1000F Then
							text = Conversions.ToString(Me.sStress_1000_sf_st_buoy_non_AI)
						End If
						If(If(-If((Me.bIsSB(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) And Not Me.bIsSB(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) And num4 <> CInt((RSWIN_DESC.rst.NumRods - 1S)) > False), 1, 0), 1, 0) And (RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) Or If(-If((CUSTOMRG.IsOtherSteel(CInt(RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).Grade)) > False), 1, 0), 1, 0))) <> 0 Then
							num6 = RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
							flag2 = Me.GetSTLBotMinStressScore(num6, num3)
							If Operators.CompareString(text.Trim(), "", False) = 0 Then
								text = Me.SetBotMinStressScoreText(num6, flag5, flag, False, CInt((RSWIN_DESC.rst.NumRods - 1S)), CInt(RSWIN_DESC.rst.NumRods), 0)
							End If
						ElseIf(If(-If((Me.bIsSB(CInt(RSWIN_DESC.rst.Sections(num5).Grade)) And Not Me.bIsSB(CInt(RSWIN_DESC.rst.Sections(num5 - 1).Grade)) And num4 <> num5 - 1 > False), 1, 0), 1, 0) And (RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(num5 - 1).Grade)) Or If(-If((CUSTOMRG.IsOtherSteel(CInt(RSWIN_DESC.rst.Sections(num5 - 1).Grade)) > False), 1, 0), 1, 0))) <> 0 Then
							num6 = RSWIN_DESC.rst.minStressBot(num5 - 1)
							flag2 = Me.GetSTLBotMinStressScore(num6, num3)
							If Operators.CompareString(text.Trim(), "", False) = 0 Then
								text = Me.SetBotMinStressScoreText(num6, flag5, flag, False, num5 - 1, num5, 0)
							End If
						End If
					ElseIf If((-If(((((RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru) AndAlso flag4) And num4 = 1) > False), 1, 0)), 1, 0) And RODUTIL.IsSinkerBar(CInt(RSWIN_DESC.rst.NumRods)) And If((-If((CDbl(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Diameter) > 1.25 > False), 1, 0)), 1, 0) And If((-If((RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).length > 1000F > False), 1, 0)), 1, 0) And If((-If((RSWIN_DESC.rst.minStressBot(CInt(RSWIN_DESC.rst.NumRods)) > 3000F > False), 1, 0)), 1, 0) <> 0 Then
						Dim num6 As Single = RSWIN_DESC.rst.minStressBot(num4)
						flag3 = Me.GetFGBotMinStressScore(num6, num2)
						flag2 = False
						text = Conversions.ToString(Me.sStress_3000_non_AI)
					ElseIf Not flag4 Then
						If flag5 And num5 <> CInt(RSWIN_DESC.rst.NumRods) Then
							Dim num6 As Single = RSWIN_DESC.rst.minStressBot(num5 - 1)
							flag2 = Me.GetSTLBotMinStressScore(num6, num3)
							text = Me.SetBotMinStressScoreText(num6, flag5, flag, flag4, num5 - 1, num5, 0)
						Else
							Dim num6 As Single = RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
							flag2 = Me.GetSTLBotMinStressScore(num6, num3)
							text = Me.SetBotMinStressScoreText(num6, flag5, flag, flag4, CInt((RSWIN_DESC.rst.NumRods - 1S)), CInt(RSWIN_DESC.rst.NumRods), 0)
						End If
					ElseIf num4 = CInt((RSWIN_DESC.rst.NumRods - 1S)) Then
						If flag5 And num5 <> CInt(RSWIN_DESC.rst.NumRods) Then
							Dim num6 As Single = RSWIN_DESC.rst.minStressBot(num5 - 1)
							flag3 = Me.GetFGBotMinStressScore(num6, num2)
							text = Me.SetBotMinStressScoreText(num6, flag5, flag, flag4, num5 - 1, num5, 0)
						Else
							Dim num6 As Single = RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
							flag3 = Me.GetFGBotMinStressScore(num6, num2)
							text = Me.SetBotMinStressScoreText(num6, flag5, flag, flag4, CInt((RSWIN_DESC.rst.NumRods - 1S)), CInt(RSWIN_DESC.rst.NumRods), 0)
						End If
					Else
						If flag5 And num5 <> CInt(RSWIN_DESC.rst.NumRods) Then
							Dim num6 As Single = RSWIN_DESC.rst.minStressBot(num5 - 1)
							flag2 = Me.GetSTLBotMinStressScore(num6, num3)
							text = Me.SetBotMinStressScoreText(num6, flag5, flag, False, num5 - 1, num5, 0)
						Else
							Dim num6 As Single = RSWIN_DESC.rst.minStressBot(CInt((RSWIN_DESC.rst.NumRods - 1S)))
							flag2 = Me.GetSTLBotMinStressScore(num6, num3)
							text = Me.SetBotMinStressScoreText(num6, flag5, flag, False, CInt((RSWIN_DESC.rst.NumRods - 1S)), CInt(RSWIN_DESC.rst.NumRods), 0)
						End If
						If RSWIN_DESC.rst.NumRods > 2S And num4 = CInt((RSWIN_DESC.rst.NumRods - 2S)) Then
							Dim num6 As Single = RSWIN_DESC.rst.minStressBot(num4)
							flag3 = Me.GetFGBotMinStressScore(num6, num2)
						End If
					End If
				ElseIf flag4 And CInt(RSWIN_DESC.rst.NumRods) = num4 Then
					Dim num6 As Single = RSWIN_DESC.rst.minStressBot(num4)
					flag3 = Me.GetFGBotMinStressScore(RSWIN_DESC.rst.minStressBot(num4), num2)
					text = Me.SetBotMinStressScoreText(num6, flag5, flag, flag4, CInt(RSWIN_DESC.rst.NumRods), CInt(RSWIN_DESC.rst.NumRods), 0)
				Else
					Dim num6 As Single = RSWIN_DESC.rst.minStressBot(CInt(RSWIN_DESC.rst.NumRods))
					flag2 = Me.GetSTLBotMinStressScore(num6, num3)
					text = Me.SetBotMinStressScoreText(num6, flag5, flag, flag4, CInt(RSWIN_DESC.rst.NumRods), CInt(RSWIN_DESC.rst.NumRods), 0)
					If flag4 And num4 = CInt((RSWIN_DESC.rst.NumRods - 1S)) Then
						num6 = RSWIN_DESC.rst.minStressBot(num4)
						flag3 = Me.GetFGBotMinStressScore(num6, num2)
					End If
				End If
				bContinue = (flag2 OrElse flag3)
				If flag2 AndAlso flag3 Then
					num = CInt(Math.Round(CDbl((num3 + num2)) / 2.0))
				ElseIf flag2 Then
					num = num3
				ElseIf flag3 Then
					num = num2
				End If
				If bContinue Then
					Me.lblBottomMinStressSCORE.Text = Me.sBotMinStressScore + num.ToString()
				Else
					Me.lblBottomMinStressSCORE.Text = Me.sBotMinStressScore + " N/A"
				End If
				If num = 100 Then
					Me.lblBotMin_Summary.Text = Me.sNoRecommendationsNecessary
					Me.lblBotMin_Summary.ForeColor = Color.Black
				Else
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						text = text.Replace("300 and 650 psi", "2086 and 4482 kPa")
					End If
					Me.lblBotMin_Summary.Text = text
				End If
				If Operators.CompareString(Me.lblBotMin_Summary.Text, Me.sNoRecommendationsNecessary, False) = 0 Then
					bNoRec = True
					Me.lblBotMin_Summary.ForeColor = Color.Black
				Else
					bNoRec = False
				End If
				result = num
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Function bHasRelocatedSB(ByRef iSB As Integer) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				If RSWIN_DESC.bRodStarD Then
					iSB = 0
					If Not Me.bIsSB(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) Then
						Dim num As Integer = 1
						Dim num2 As Integer = CInt((RSWIN_DESC.rst.NumRods - 1S))
						For i As Integer = num To num2
							If Me.bIsSB(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Then
								iSB = i
								flag = True
							End If
						Next
					Else
						iSB = CInt(RSWIN_DESC.rst.NumRods)
					End If
				ElseIf Me.bIsSB(CInt(RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Grade)) Then
					iSB = CInt(RSWIN_DESC.rst.NumRods)
				End If
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function SetBotMinStressScoreText(fStress As Single, bSB As Boolean, bSR As Boolean, bFG As Boolean, iNextLast As Integer, iLast As Integer, Optional iFG As Integer = 0) As String
			Dim result As String
			Try
				Dim text As String = ""
				Dim flag As Boolean
				Try
					Dim num As Integer
					flag = Me.bHasRelocatedSB(num)
				Catch ex As Exception
					flag = False
				End Try
				bFG = Me.HasFG(iFG)
				If bSB OrElse bSR Then
					If bSB Then
						If RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru And fStress >= 800F Then
							If Not RSWIN_DESC.rst.gbIncludeBuoyancy And Not bFG Then
								text = Conversions.ToString(Me.sStress_800_sb_unbuoy_non_AI)
							End If
						ElseIf RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru And fStress < 0F Then
							If Not RSWIN_DESC.rst.gbIncludeBuoyancy And Not bFG Then
								text = Conversions.ToString(Me.sStress_0_sb_unbuoy_non_AI)
							ElseIf(RSWIN_DESC.rst.gbIncludeBuoyancy AndAlso bFG) And RSWIN_DESC.rst.NumRods = 2S Then
								text = Conversions.ToString(Me.sStress_0_sb_buoy_non_AI)
							End If
						ElseIf fStress >= -300F And fStress < 0F Then
							If flag Then
								text = Me.sStress_300_0_sb_relocate
							Else
								text = Me.sStress_300_0_sb
							End If
						ElseIf fStress >= 800F And fStress < 1000F Then
							If flag Then
								text = Me.sStress_650_1000_sb_relocate
							Else
								text = Me.sStress_650_1000_sb
							End If
						ElseIf fStress >= 100F And fStress < 300F Then
							If RSWIN_DESC.rst.SPMEntered <> 0S Then
								If flag Then
									text = Me.sStress_100_300_sb_spm_relocate
								Else
									text = Me.sStress_100_300_sb_spm
								End If
							ElseIf flag Then
								text = Me.sStress_100_300_sb_tp_relocate
							Else
								text = Me.sStress_100_300_sb_tp
							End If
						ElseIf fStress >= 25F And fStress < 100F Then
							If RSWIN_DESC.rst.SPMEntered <> 0S Then
								If flag Then
									text = Me.sStress_25_100_sb_spm_relocate
								Else
									text = Me.sStress_25_100_sb_spm
								End If
							ElseIf flag Then
								text = Me.sStress_25_100_sb_tp_relocate
							Else
								text = Me.sStress_25_100_sb_tp
							End If
						ElseIf fStress >= 0F And fStress < 25F Then
							If RSWIN_DESC.rst.SPMEntered <> 0S Then
								If flag Then
									text = Me.sStress_0_25_sb_spm_relocate
								Else
									text = Me.sStress_0_25_sb_spm
								End If
							ElseIf flag Then
								text = Me.sStress_0_25_sb_tp_relocate
							Else
								text = Me.sStress_0_25_sb_tp
							End If
						ElseIf fStress < 25F Then
							If flag Then
								text = Me.sStress_25_sb_relocate
							Else
								text = Me.sStress_25_sb
							End If
						ElseIf fStress >= 1000F Then
							If flag Then
								text = Me.sStress_1000_sb_relocate
							Else
								text = Me.sStress_1000_sb
							End If
						ElseIf fStress >= 300F And fStress < 800F Then
							text = Me.sNoRecommendationsNecessary
						End If
					ElseIf RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru And fStress >= 800F Then
						If Not RSWIN_DESC.rst.gbIncludeBuoyancy And Not bFG Then
							text = Conversions.ToString(NewLateBinding.LateGet(Me.sStress_800_sb_unbuoy_non_AI, Nothing, "replace", New Object() { "sinker bar", "sinker rod" }, Nothing, Nothing, Nothing))
						End If
					ElseIf RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru And fStress < 0F Then
						If Not RSWIN_DESC.rst.gbIncludeBuoyancy And Not bFG Then
							text = Conversions.ToString(NewLateBinding.LateGet(Me.sStress_0_sb_unbuoy_non_AI, Nothing, "replace", New Object() { "sinker bar", "sinker rod" }, Nothing, Nothing, Nothing))
						ElseIf(RSWIN_DESC.rst.gbIncludeBuoyancy AndAlso bFG) And RSWIN_DESC.rst.NumRods = 2S Then
							text = Conversions.ToString(NewLateBinding.LateGet(Me.sStress_0_sb_buoy_non_AI, Nothing, "replace", New Object() { "sinker bar", "sinker rod" }, Nothing, Nothing, Nothing))
						End If
					ElseIf fStress >= -300F And fStress < 0F Then
						text = Me.sStress_300_0_sr
					ElseIf fStress >= 800F And fStress < 1000F Then
						text = Me.sStress_650_1000_sr
					ElseIf fStress >= 100F And fStress < 300F Then
						If RSWIN_DESC.rst.SPMEntered <> 0S Then
							text = Me.sStress_100_300_sr_spm
						Else
							text = Me.sStress_100_300_sr_tp
						End If
					ElseIf fStress >= 25F And fStress < 100F Then
						If RSWIN_DESC.rst.SPMEntered <> 0S Then
							text = Me.sStress_25_100_sr_spm
						Else
							text = Me.sStress_25_100_sr_tp
						End If
					ElseIf fStress >= 0F And fStress < 25F Then
						If RSWIN_DESC.rst.SPMEntered <> 0S Then
							text = Me.sStress_0_25_sr_spm
						Else
							text = Me.sStress_0_25_sr_tp
						End If
					ElseIf fStress < 25F Then
						text = Me.sStress_25_sr
					ElseIf fStress >= 1000F Then
						text = Me.sStress_1000_sr
					ElseIf fStress >= 300F And fStress < 800F Then
						text = Me.sNoRecommendationsNecessary
					End If
				ElseIf fStress < 0F Then
					text = Me.sStress_negative_r
				ElseIf fStress < 300F Then
					text = Me.sStress_0_300_r
				Else
					text = Me.sNoRecommendationsNecessary
				End If
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					text = text.Replace("300 and 650 psi", "2086 and 4482 kPa")
				End If
				result = text
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Public Function SetMPRLScore() As Integer
			Dim result As Integer
			Try
				Dim text As String = ""
				Me.lblMPRL_Summary.ForeColor = Color.Black
				Dim mprload As Single = RSWIN_DESC.rst.Mprload
				Dim flag As Boolean = True
				Dim num As Integer
				If flag = mprload >= 200F Then
					num = 100
					text = Me.sNoRecommendationsNecessary
				ElseIf flag = (mprload >= 100F And mprload < 200F) Then
					num = 90
					text = Me.sMPRL_100_200
					Me.lblMPRL_Summary.ForeColor = Color.Red
				ElseIf flag = (mprload >= 50F And mprload < 100F) Then
					num = 80
					text = Me.sMPRL_50_100
					Me.lblMPRL_Summary.ForeColor = Color.Red
				ElseIf flag = (mprload >= 20F And mprload < 50F) Then
					num = 50
					text = Me.sMPRL_20_50
					Me.lblMPRL_Summary.ForeColor = Color.Red
				ElseIf flag = (mprload >= 0F And mprload < 20F) Then
					num = 30
					text = Me.sMPRL_0_20
					Me.lblMPRL_Summary.ForeColor = Color.Red
				ElseIf flag = mprload < 0F Then
					num = 0
					text = Me.sMPRL_0
					Me.lblMPRL_Summary.ForeColor = Color.Red
				End If
				Me.lblMPRL.Text = Me.sMinPRLScore + num.ToString()
				Me.lblMPRL_Summary.Text = text
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
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = (fStress > 50F And fStress <= 400F) Then
				iScore = 30
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = (fStress > 400F And fStress <= 700F) Then
				iScore = 60
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = (fStress > 700F And fStress <= 1000F) Then
				iScore = 80
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = fStress > 1000F Then
				iScore = 100
				result = True
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
			ElseIf flag = (fStress < 0F And fStress > -300F) Then
				iScore = 50
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = fStress > 3000F Then
				iScore = 50
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = (fStress > 2000F And fStress <= 3000F) Then
				iScore = 60
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = (fStress > 1200F And fStress <= 2000F) Then
				iScore = 80
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = (fStress > 800F And fStress <= 1200F) Then
				iScore = 90
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = (fStress > 650F And fStress <= 800F) Then
				iScore = 95
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = (fStress > 300F And fStress <= 650F) Then
				iScore = 100
				result = True
			ElseIf flag = (fStress > 200F And fStress <= 300F) Then
				iScore = 95
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = (fStress > 100F And fStress <= 200F) Then
				iScore = 90
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = (fStress > 50F And fStress <= 100F) Then
				iScore = 80
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = (fStress > 25F And fStress <= 50F) Then
				iScore = 70
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = (fStress > 0F And fStress <= 25F) Then
				iScore = 60
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
			ElseIf flag = fStress <= -300F Then
				iScore = 30
				result = True
				Me.lblBotMin_Summary.ForeColor = Color.Red
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
			Dim sPrefix As String = "rptExpertSummary-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
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

		Private Function SmallerStrokeLengthAvailable() As Boolean
			Dim result As Boolean
			Try
				If RSWIN_DESC.rst.PU.CrankHole <> RSWIN_DESC.rst.PU.CrankHoles Then
					result = True
				Else
					result = False
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private nLFCount As Integer

		Private ReportLines As rptExpertSummary.ReportLine_Struct()

		Private sExpert As String

		Private Const LD_VBAR As Integer = 1

		Private Const LD_TEEDOWN As Integer = 2

		Private Const LD_HBAR As Integer = 3

		Private Const LD_CROSS As Integer = 4

		Private Const MARGIN As Integer = 700

		Private Const HDRSIZE As Integer = 12

		Private Const TXTSIZE As Integer = 11

		<AccessedThroughProperty("lblSBFootnote")>
		Private _lblSBFootnote As Label

		Private sNull As String

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

		Private lblTOTALSCORE As Label

		Private lblGEARBOXSCORE As Label

		Private lblRODLOADINGSCORE As Label

		Private lblSTRUCTURELOADINGSCORE As Label

		Private lblSYSTEMEFFICIENCYSCORE As Label

		Private lblRL_Summary As Label

		Private lblSysEff_Summary As Label

		Private lblSL_Summary As Label

		Private lblBottomMinStressSCORE As Label

		Private lblBotMin_Summary As Label

		Private lblGB_Summary As Label

		Private lblMPRL As Label

		Private lblMPRL_Summary As Label

		Private lblTOTALSCORE_NoRec As Label

		Private sMaxRodGuidesExceeded_s As Object

		Private sMaxRodGuidesExceeded_p As Object

		Private m_sTapersOverMax As String

		Private m_bForceDisplay As Boolean

		Private m_bPrint As Boolean

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer

		Private I As Integer

		Private slbl As String

		Private sSystemDesignScore As Object

		Private sTOTALSCORE As String

		Private sGrade As String

		Private sNoRecommendationsNecessary As String

		Private sGBLoad_6_7 As String

		Private sGBLoad_5_6 As String

		Private sGBLoad_0_5 As String

		Private sGBLoad_5 As String

		Private sGBLoad_95_1 As String

		Private sGBLoad_1_12 As String

		Private sGBLoad_12_135 As String

		Private sGBLoad_135 As String

		Private sGBLoad_1_12_b As String

		Private sGBLoad_12_135_b As String

		Private sGBLoad_135_b As String

		Private sGEARBOXSCORE As String

		Private sSLoad_6_7 As String

		Private sSLoad_5_6 As String

		Private sSLoad_5 As String

		Private sSLoad_95_1 As String

		Private sSLoad_1_11 As String

		Private sSLoad_11_12 As String

		Private sSLoad_120 As String

		Private sSLoad_95_105 As String

		Private sSTRUCTURELOADINGSCORE As String

		Private sMaxRodLoad_6_7 As String

		Private sMaxRodLoad_5_6 As String

		Private sMaxRodLoad_4_5 As String

		Private sMaxRodLoad_4 As String

		Private sMaxRodLoad_95_1 As String

		Private sMaxRodLoad_1_11 As String

		Private sMaxRodLoad_11_12 As String

		Private sMaxRodLoad_12 As String

		Private sMaxRodLoad_1_11_sb As String

		Private sMaxRodLoad_11_12_sb As String

		Private sMaxRodLoad_12_sb As String

		Private sRODLOADINGSCORE As String

		Private sTryChangingDirection As String

		Private sSysEff_45_5_a As String

		Private sSysEff_45_5_b As String

		Private sSysEff_45_5_c As String

		Private sSysEff_45_5_d As String

		Private sSysEff_45_5_e As String

		Private sSysEff_42_45_a As String

		Private sSysEff_42_45_b As String

		Private sSysEff_42_45_c As String

		Private sSysEff_42_45_d As String

		Private sSysEff_42_45_e As String

		Private sSysEff_4_42_a As String

		Private sSysEff_4_42_b As String

		Private sSysEff_4_42_c As String

		Private sSysEff_4_42_d As String

		Private sSysEff_4_42_e As String

		Private sSysEff_35_4_a As String

		Private sSysEff_35_4_b As String

		Private sSysEff_35_4_c As String

		Private sSysEff_35_4_d As String

		Private sSysEff_35_4_e As String

		Private sSysEff_3_35_a As String

		Private sSysEff_3_35_b As String

		Private sSysEff_3_35_c As String

		Private sSysEff_3_35_d As String

		Private sSysEff_3_35_e As String

		Private sSysEff_25_3_a As String

		Private sSysEff_25_3_b As String

		Private sSysEff_25_3_c As String

		Private sSysEff_25_3_d As String

		Private sSysEff_25_3_e As String

		Private sSysEff_25_a As String

		Private sSysEff_25_b As String

		Private sSysEff_25_c As String

		Private sSysEff_25_d As String

		Private sSysEff_25_e As String

		Private sSysEffScore As String

		Private sBotMinStressScore As String

		Private sStress_300_0_sb As String

		Private sStress_300_0_no_sb As String

		Private sStress_650_1000_sb As String

		Private sStress_25_sb As String

		Private sStress_25_no_sb As String

		Private sStress_1000_sb As String

		Private sStress_300_0_sr As String

		Private sStress_650_1000_sr As String

		Private sStress_100_300_sb_tp As String

		Private sStress_25_100_sb_tp As String

		Private sStress_0_25_sb_tp As String

		Private sStress_100_300_sb_spm As String

		Private sStress_25_100_sb_spm As String

		Private sStress_0_25_sb_spm As String

		Private sStress_100_300_sr_tp As String

		Private sStress_25_100_sr_tp As String

		Private sStress_0_25_sr_tp As String

		Private sStress_100_300_sr_spm As String

		Private sStress_25_100_sr_spm As String

		Private sStress_0_25_sr_spm As String

		Private sStress_25_sr As String

		Private sStress_1000_sr As String

		Private sStress_negative_r As String

		Private sStress_0_300_r As String

		Private sStress_800_sb_buoy_non_AI As Object

		Private sStress_800_sb_unbuoy_non_AI As Object

		Private sStress_0_sb_buoy_non_AI As Object

		Private sStress_0_sb_unbuoy_non_AI As Object

		Private sStress_1000_sf_st_buoy_non_AI As Object

		Private sStress_3000_non_AI As Object

		Private sStress_300_0_sb_relocate As String

		Private sStress_300_0_no_sb_relocate As String

		Private sStress_650_1000_sb_relocate As String

		Private sStress_25_sb_relocate As String

		Private sStress_25_no_sb_relocate As String

		Private sStress_1000_sb_relocate As String

		Private sStress_100_300_sb_tp_relocate As String

		Private sStress_25_100_sb_tp_relocate As String

		Private sStress_0_25_sb_tp_relocate As String

		Private sStress_100_300_sb_spm_relocate As String

		Private sStress_25_100_sb_spm_relocate As String

		Private sStress_0_25_sb_spm_relocate As String

		Private sMPRL_100_200 As String

		Private sMPRL_50_100 As String

		Private sMPRL_20_50 As String

		Private sMPRL_0_20 As String

		Private sMPRL_0 As String

		Private sMinPRLScore As String

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

		Private Structure ReportLine_Struct
			Public nLineNum As Integer

			Public sLineValue As String

			Public bMakeBold As Boolean
		End Structure
	End Class
End Namespace
