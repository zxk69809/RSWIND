Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports DDCssLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class rptCalcResults
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.rptCalcResults_ReportStart
			Me.PageHeader = Nothing
			Me.Detail = Nothing
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
			Me.txtMPRLPPRL = Nothing
			Me.lblMPRLPPRL = Nothing
			Me.lblRSFootnote5 = Nothing
			Me.lblRSFootnote4 = Nothing
			Me.lblRSFootnote3 = Nothing
			Me.lblRSFootnote2 = Nothing
			Me.lblRSFootnote1 = Nothing
			Me.linRSInputSep4 = Nothing
			Me.lblMotorSPVHdr = Nothing
			Me.linRSInputSep1 = Nothing
			Me.linDivider = Nothing
			Me.linRSInputSep3 = Nothing
			Me.lblMotorSPV = Nothing
			Me.lblNEMAD = Nothing
			Me.Line1 = Nothing
			Me.lblInputData = Nothing
			Me.lblCalculatedResults = Nothing
			Me.Line3 = Nothing
			Me.lblRuntime = Nothing
			Me.lblFLPIP_2 = Nothing
			Me.lblFLPIP_1 = Nothing
			Me.lblCasingPressure = Nothing
			Me.lblStuffingBoxFriction = Nothing
			Me.lblFluidPropertiesHeader = Nothing
			Me.Line4 = Nothing
			Me.lblMotorHeader = Nothing
			Me.Line5 = Nothing
			Me.lblPowerMeter = Nothing
			Me.lblWaterCut = Nothing
			Me.lblWaterSPGR = Nothing
			Me.lblElectricityCost = Nothing
			Me.lblMotorType = Nothing
			Me.lblMotorSize = Nothing
			Me.lblMotorSetting = Nothing
			Me.lblOilSPGR = Nothing
			Me.lblFluidSPGR = Nothing
			Me.lblCompressibilityIndex = Nothing
			Me.lblPumpingUnitHeader = Nothing
			Me.Line6 = Nothing
			Me.lblAPIDesignation = Nothing
			Me.lblCrankHole = Nothing
			Me.lblPUDimR = Nothing
			Me.lblPUDimA = Nothing
			Me.lblPUDimC = Nothing
			Me.lblPUDimI = Nothing
			Me.lblPUDimK = Nothing
			Me.lblPUDimP = Nothing
			Me.lblPUDimM = Nothing
			Me.lblPUDimV0 = Nothing
			Me.lblPUDimS = Nothing
			Me.lblStrokeLength = Nothing
			Me.lblCrankRotation = Nothing
			Me.lblCwtInfo_1 = Nothing
			Me.lblCwtInfo_2 = Nothing
			Me.lblCwtInfo_3 = Nothing
			Me.lblCwtInfo_4 = Nothing
			Me.lblCwtInfo_5 = Nothing
			Me.lblCBDataFile = Nothing
			Me.lblPumpTubingHeader = Nothing
			Me.Line7 = Nothing
			Me.lblTubingOD = Nothing
			Me.lblTubingID = Nothing
			Me.lblPlungerSize = Nothing
			Me.lblRodStringDesign = Nothing
			Me.lblTqMinEner = Nothing
			Me.lblPeakTorque_BE = Nothing
			Me.lblGearboxLoading_BE = Nothing
			Me.lblCLF_BE = Nothing
			Me.lblMCM_BE = Nothing
			Me.lblCBE_BE = Nothing
			Me.lblMotorKWH_BE = Nothing
			Me.lblElectricBillPerMonth_BE = Nothing
			Me.lblDollarsPerBblFluid_BE = Nothing
			Me.lblDollarsPerBblOil_BE = Nothing
			Me.lblTqMinTorq = Nothing
			Me.lblPeakTorque_BT = Nothing
			Me.lblGearboxLoading_BT = Nothing
			Me.lblCLF_BT = Nothing
			Me.lblMCM_BT = Nothing
			Me.lblCBE_BT = Nothing
			Me.lblMotorKWH_BT = Nothing
			Me.lblElectricBillPerMonth_BT = Nothing
			Me.lblDollarsPerBblFluid_BT = Nothing
			Me.lblDollarsPerBblOil_BT = Nothing
			Me.lblTqExisting = Nothing
			Me.lblPeakTorque_E = Nothing
			Me.lblGearboxLoading_E = Nothing
			Me.lblCLF_E = Nothing
			Me.lblMCM_E = Nothing
			Me.lblCBE_E = Nothing
			Me.lblMotorKWH_E = Nothing
			Me.lblElectricBillPerMonth_E = Nothing
			Me.lblDollarsPerBblFluid_E = Nothing
			Me.lblDollarsPerBblOil_E = Nothing
			Me.Line8 = Nothing
			Me.lblPmMinEner = Nothing
			Me.lblNEMAD_BE = Nothing
			Me.lblSingleCyl_BE = Nothing
			Me.lblMultiCyl_BE = Nothing
			Me.lblPmMinTorq = Nothing
			Me.lblNEMAD_BT = Nothing
			Me.lblSingleCyl_BT = Nothing
			Me.lblMultiCyl_BT = Nothing
			Me.lblPmExisting = Nothing
			Me.lblNEMAD_E = Nothing
			Me.lblSingleCyl_E = Nothing
			Me.lblMultiCyl_E = Nothing
			Me.lblMultiCyl = Nothing
			Me.lblElectricityConsumption = Nothing
			Me.Line9 = Nothing
			Me.lblTubingCalculations = Nothing
			Me.Line10 = Nothing
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
			Me.lblFLPIP_3 = Nothing
			Me.lblSPM = Nothing
			Me.lblPlungerLength = Nothing
			Me.lblPumpLength = Nothing
			Me.lblPumpSpacing = Nothing
			Me.lblGrossPumpStroke = Nothing
			Me.lblProductionLoss = Nothing
			Me.lblTubingStretch = Nothing
			Me.lblPumpFriction = Nothing
			Me.lblPumpEfficiency = Nothing
			Me.lblPumpLoadAdj = Nothing
			Me.lblTubingAnchorDepth = Nothing
			Me.lblDownstrokeFriction = Nothing
			Me.lblPumpType = Nothing
			Me.lblPumpCondition = Nothing
			Me.lblPumpDepth = Nothing
			Me.lblDollarsPerBblOil = Nothing
			Me.lblDollarsPerBblFluid = Nothing
			Me.lblElectricBillPerMonth = Nothing
			Me.lblGearboxLoading = Nothing
			Me.lblTorqueAnalysis = Nothing
			Me.lblSingleCyl = Nothing
			Me.lblPeakTorque = Nothing
			Me.lblMotorKWH = Nothing
			Me.lblTubingPressure = Nothing
			Me.lblReqPrimeMoverSize = Nothing
			Me.lblRodGradeHdrTop = Nothing
			Me.lblRodTopMinStressHdrTop = Nothing
			Me.lblRodBotMinStressHdrTop = Nothing
			Me.lblRodStressMethodHdrTop = Nothing
			Me.lblRodTopMaxStressHdrTop = Nothing
			Me.lblRodStressHdrTop = Nothing
			Me.lblRodTensileStrengthHdrTop = Nothing
			Me.lblRodLengthHdrTop = Nothing
			Me.lblPmBalancedT = Nothing
			Me.lblTqBalancedT = Nothing
			Me.lblTqBalancedE = Nothing
			Me.txtPlungerLength = Nothing
			Me.txtPumpLength = Nothing
			Me.txtPumpSpacing = Nothing
			Me.txtGrossPumpStroke = Nothing
			Me.txtProductionLoss = Nothing
			Me.txtTubingStretch = Nothing
			Me.txtTubingOD = Nothing
			Me.txtTubingID = Nothing
			Me.txtPlungerSize = Nothing
			Me.txtPumpType = Nothing
			Me.txtPumpCondition = Nothing
			Me.txtPumpDepth = Nothing
			Me.txtUpstrokeFriction = Nothing
			Me.txtDownstrokeFriction = Nothing
			Me.txtPumpFriction = Nothing
			Me.txtPumpLoadAdj = Nothing
			Me.txtTubingAnchorDepth = Nothing
			Me.txtPumpEfficiency = Nothing
			Me.txtPowerMeter = Nothing
			Me.txtElectricityCost = Nothing
			Me.txtMotorType = Nothing
			Me.txtMotorSize = Nothing
			Me.txtMotorSetting = Nothing
			Me.txtWaterCut = Nothing
			Me.txtWaterSPGR = Nothing
			Me.txtOilSPGR = Nothing
			Me.txtFluidSPGR = Nothing
			Me.txtCompressibilityIndex = Nothing
			Me.txtSPM = Nothing
			Me.txtRuntime = Nothing
			Me.txtTubingPressure = Nothing
			Me.txtCasingPressure = Nothing
			Me.txtFLPIP_1 = Nothing
			Me.txtFLPIP_2 = Nothing
			Me.txtFLPIP_3 = Nothing
			Me.txtStuffingBoxFriction = Nothing
			Me.lnPMSV = Nothing
			Me.txtCrankHole = Nothing
			Me.txtStrokeLength = Nothing
			Me.txtCrankRotation = Nothing
			Me.txtCwtInfo_1 = Nothing
			Me.txtCwtInfo_2 = Nothing
			Me.txtCwtInfo_3 = Nothing
			Me.txtCwtInfo_4 = Nothing
			Me.txtCwtInfo_5 = Nothing
			Me.linRSCalcSep3 = Nothing
			Me.linRSCalcSep1 = Nothing
			Me.linRSCalcSep2 = Nothing
			Me.linRSCalcSep4 = Nothing
			Me.lblUpstrokeFriction = Nothing
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
			Me.lblPmBalancedE = Nothing
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
			Me.picDyno = Nothing
			Me.picTorquePlot = Nothing
			Me.Line15 = Nothing
			Me.Line16 = Nothing
			Me.lblNoResults = Nothing
			Me.lblSystemEff = Nothing
			Me.txtStructLoading = Nothing
			Me.txtBPDSurface = Nothing
			Me.txtPermLoadHP = Nothing
			Me.txtSystemEff = Nothing
			Me.txtFluidLoad = Nothing
			Me.txtCalcSPM = Nothing
			Me.txtOilProduction = Nothing
			Me.lblFluidLoad = Nothing
			Me.lblPermLoadHP = Nothing
			Me.lblCalcSPM = Nothing
			Me.lblOilProduction = Nothing
			Me.lblBPDSurface = Nothing
			Me.lblPrhpPlhp = Nothing
			Me.lblStructLoading = Nothing
			Me.lblPRHP = Nothing
			Me.lblMPRL = Nothing
			Me.lblPPRL = Nothing
			Me.lblNoverNo = Nothing
			Me.txtRodWeight = Nothing
			Me.txtPrhpPlhp = Nothing
			Me.txtMPRL = Nothing
			Me.txtPPRL = Nothing
			Me.linRSInputSep2 = Nothing
			Me.lblRodWeight = Nothing
			Me.lblCBE = Nothing
			Me.lblMCM = Nothing
			Me.lblCLF = Nothing
			Me.lblFluidLevelTVD = Nothing
			Me.txtPRHP = Nothing
			Me.txtFluidLevelTVD = Nothing
			Me.lblPolRodDiam = Nothing
			Me.txtPolRodDiam = Nothing
			Me.sNull = ""
			Me.sThetaEnterprises = Util.AssignValueToConstant("rptCalcResults", "sThetaEnterprises", "(c) Theta Oilfield Services, Inc.")
			Me.sElevatorNeck = Util.AssignValueToConstant("rptCalcResults", "sElevatorNeck", "elevator neck diameter of ")
			Me.sAsterickMsg = Util.AssignValueToConstant("rptCalcResults", "sAsterickMsg", "* May be too big for tubing.")
			Me.sPlusMsg = Util.AssignValueToConstant("rptCalcResults", "sPlusMsg", "+ Requires slimhole couplings.")
			Me.sAtSignMsg = Util.AssignValueToConstant("rptCalcResults", "sAtSignMsg", "@ Stress calculations based on elevator neck of 7/8"" (for 1.25"" sinker bars) or 1"" (for other sinker bars).")
			Me.sAtSignMsg_M = Util.AssignValueToConstant("rptCalcResults", "sAtSignMsg_M", "@ Stress calculations based on elevator neck of 22.2mm (for 31.8mm sinker bars) or 25.4mm (for other sinker bars).")
			Me.sPoundSignMsg = Util.AssignValueToConstant("rptCalcResults", "sPoundSignMsg", "# Sinker bar has no elevator neck.")
			Me.sNOTE1 = Util.AssignValueToConstant("rptCalcResults", "sNOTE1", "NOTE Stress calculations include buoyancy effects.")
			Me.sNOTE2 = Util.AssignValueToConstant("rptCalcResults", "sNOTE2", "NOTE Stress calculations do not include buoyancy effects.")
			Me.sNumGuides1 = Util.AssignValueToConstant("RSInput", "sNumGuides1", "# Guides/")
			Me.sNumGuides2 = Util.AssignValueToConstant("RSInput", "sNumGuides2", "Rod")
			Me.sStressCalc = Util.AssignValueToConstant("RSInput", "sStressCalc", "   Stress Calc.")
			Me.sMethod = Util.AssignValueToConstant("RSInput", "sMethod", "Method")
			Me.sUNKNOWN = Util.AssignValueToConstant("rptCalcResults", "sUNKNOWN", "Unknown")
			Me.c_UNKNOWN = Util.AssignValueToConstant("rptCalcResults", "c_UNKNOWN", "#Unknown")
			Me.sFull = Util.AssignValueToConstant("rptCalcResults", "sFull", "Full")
			Me.sFlpound = Util.AssignValueToConstant("rptCalcResults", "sFlpound", "Fl pound")
			Me.sGasIntf = Util.AssignValueToConstant("rptCalcResults", "sGasIntf", "Gas intf")
			Me.sPumpCondition = Util.AssignValueToConstant("rptCalcResults", "sPumpCondition", "Pump condition:")
			Me.sPlungerSize = Util.AssignValueToConstant("rptCalcResults", "sPlungerSize", "Plunger size")
			Me.sPumpDepth = Util.AssignValueToConstant("rptCalcResults", "sPumpDepth", "Pump depth")
			Me.sParaffinDepth = Util.AssignValueToConstant("rptCalcResults", "sParaffinDepth", "Paraffin acc. depth")
			Me.sPumpFriction = Util.AssignValueToConstant("rptCalcResults", "sPumpFriction", "Pump friction")
			Me.sPumpLoadAdj = Util.AssignValueToConstant("rptCalcResults", "sPumpLoadAdj", "Pump load adj.")
			Me.sPumpType = Util.AssignValueToConstant("rptCalcResults", "sPumpType", "Pump type:")
			Me.sTubAnchDepth = Util.AssignValueToConstant("rptCalcResults", "sTubAnchDepth", "Tub.anch.depth")
			Me.sTubingNotAnchored = Util.AssignValueToConstant("rptCalcResults", "sTubingNotAnchored", "Tubing is not anchored")
			Me.sTubingID = Util.AssignValueToConstant("rptCalcResults", "sTubingID", "Tubing I.D.")
			Me.sTubingOD = Util.AssignValueToConstant("rptCalcResults", "sTubingOD", "Tubing O.D.")
			Me.sCalcPumpFillage = Util.AssignValueToConstant("rptCalcResults", "sCalcPumpFillage", "Calc. pump fillage :")
			Me.sPumpEfficiencyFillage = Util.AssignValueToConstant("rptCalcResults", "sPumpEfficiencyFillage", "Pump efficiency/fillage :")
			Me.sPumpVolEff = Util.AssignValueToConstant("rptCalcResults", "sPumpVolEff", "Pump vol. efficiency :")
			Me.sInsert = Util.AssignValueToConstant("rptCalcResults", "sInsert", "Insert")
			Me.sTubing = Util.AssignValueToConstant("rptCalcResults", "sTubing", "Tubing")
			Me.sLargeBore = Util.AssignValueToConstant("rptCalcResults", "sLargeBore", "Large bore")
			Me.sBottomOfStroke = Util.AssignValueToConstant("rptCalcResults", "sBottomOfStroke", "  bottom-of-stroke")
			Me.sMaxCBweightl = Util.AssignValueToConstant("rptCalcResults", "sMaxCBweightl", "Max. CB weight")
			Me.sPeakGboxTorq = Util.AssignValueToConstant("rptCalcResults", "sPeakGboxTorq", "Peak g'box torq.")
			Me.sPeakGearboxTorque = Util.AssignValueToConstant("rptCalcResults", "sPeakGearboxTorque", "Peak Gearbox Torque")
			Me.sGearboxLoading = Util.AssignValueToConstant("rptCalcResults", "sGearboxLoading", "Gearbox loading:")
			Me.sCyclicLoadFactor = Util.AssignValueToConstant("rptCalcResults", "", "Cyclic load factor:")
			Me.sMaxAirTankPres = Util.AssignValueToConstant("rptCalcResults", "", "Max. air tank pres. ")
			Me.sCounterbalanceWeight = Util.AssignValueToConstant("rptCalcResults", "sCounterbalanceWeight", "Counterbalance weight ")
			Me.sMaxCBMoment = Util.AssignValueToConstant("rptCalcResults", "sMaxCBMoment", "Max. CB moment")
			Me.sReqUnbalance = Util.AssignValueToConstant("rptCalcResults", "sReqUnbalance", "Str. Unbalance")
			Me.sCounterbalanceEffect = Util.AssignValueToConstant("rptCalcResults", "sCounterbalanceEffect", "Counterbalance effect ")
			Me.sDailyElectrUse = Util.AssignValueToConstant("rptCalcResults", "sDailyElectrUse", "Daily electr.use (KWH/day):")
			Me.sMonthlyElectricBill = Util.AssignValueToConstant("rptCalcResults", "sMonthlyElectricBill", "Monthly electric bill:")
			Me.sElectrCostPer = Util.AssignValueToConstant("rptCalcResults", "sElectrCostPer", "Electr.cost per ")
			Me.sElectrCostPerFluid = Util.AssignValueToConstant("rptCalcResults", "sElectrCostPerFluid", "Electr.cost per fluid")
			Me.sElectrCcostPerOil = Util.AssignValueToConstant("rptCalcResults", "sElectrCcostPerOil", "Electr.cost per oil")
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
			Me.sDownstrokeFriction = Util.AssignValueToConstant("rptCalcResults", "sDownstrokeFriction", "Dnstr. rod-tbg fr. coeff: ")
			Me.sUpstrokeFriction = Util.AssignValueToConstant("rptCalcResults", "sUpstrokeFriction", "Upstr. rod-tbg fr. coeff: ")
			Me.sBalanced = Util.AssignValueToConstant("rptCalcResults", "sBalanced", "Balanced")
			Me.sExisting = Util.AssignValueToConstant("rptCalcResults", "sExisting", "Existing")
			Me.sCalculatedResults = Util.AssignValueToConstant("rptCalcResults", "sCalculatedResults", "CALCULATED RESULTS")
			Me.sProductionRate = Util.AssignValueToConstant("rptCalcResults", "sProductionRate", "Production rate")
			Me.sStrokesPerMinute = Util.AssignValueToConstant("rptCalcResults", "sStrokesPerMinute", "Strokes per minute:")
			Me.sFluidLoadOnPump = Util.AssignValueToConstant("rptCalcResults", "sFluidLoadOnPump", "Fluid load on pump")
			Me.sFluidLevelTVD = Util.AssignValueToConstant("rptCalcResults", "sFluidLevelTVD", "Fluid level TVD ")
			Me.sRequiredMotorHP = Util.AssignValueToConstant("rptCalcResults", "sRequiredMotorHP", " required motor HP:")
			Me.sMinPolRodLoad = Util.AssignValueToConstant("rptCalcResults", "sMinPolRodLoad", "Min. pol. rod load")
			Me.sOilProduction = Util.AssignValueToConstant("rptCalcResults", "sOilProduction", "Oil production")
			Me.aPeakPolRodLoad = Util.AssignValueToConstant("rptCalcResults", "aPeakPolRodLoad", "Peak pol. rod load")
			Me.sPolRodPowerKW = Util.AssignValueToConstant("rptCalcResults", "sPolRodPowerKW", "PRP (kW): ")
			Me.sPolishedRodHP = Util.AssignValueToConstant("rptCalcResults", "sPolishedRodHP", "PRHP: ")
			Me.sPermissibleLoadPowerKW = Util.AssignValueToConstant("rptCalcResults", "sPermissibleLoadPowerKW", "Permissible load power (kW): ")
			Me.sPermissibleLoadHP = Util.AssignValueToConstant("rptCalcResults", "sPermissibleLoadHP", "Permissible load HP: ")
			Me.sBuoyantRodWeight = Util.AssignValueToConstant("rptCalcResults", "sBuoyantRodWeight", "Buoyant rod weight")
			Me.sUnitStructLoading = Util.AssignValueToConstant("rptCalcResults", "sUnitStructLoading", "Unit struct. loading:")
			Me.sSystemEffMotorPump = Util.AssignValueToConstant("rptCalcResults", "sSystemEffMotorPump", "System eff. (Motor->Pump):")
			Me.sCompressIndex = Util.AssignValueToConstant("rptCalcResults", "sCompressIndex", "Compress. index:")
			Me.sFluidSpGravity = Util.AssignValueToConstant("rptCalcResults", "sFluidSpGravity", "Fluid sp. gravity:")
			Me.sUCSIZE = Util.AssignValueToConstant("rptCalcResults", "sUCSIZE", "SIZE ")
			Me.sSize = Util.AssignValueToConstant("rptCalcResults", "sSize", "Size: ")
			Me.sMediumLow = Util.AssignValueToConstant("rptCalcResults", "sMediumLow", "Medium/Low")
			Me.sMLow = Util.AssignValueToConstant("rptCalcResults", "sMLow", "M/Low")
			Me.sMode = Util.AssignValueToConstant("rptCalcResults", "sMode", "Mode: ")
			Me.sOilDensityGCM = Util.AssignValueToConstant("rptCalcResults", "sOilDensityGCM", "Oil density (g/cm³): ")
			Me.sOilAPIGravity = Util.AssignValueToConstant("rptCalcResults", "sOilAPIGravity", "Oil API gravity: ")
			Me.sType = Util.AssignValueToConstant("rptCalcResults", "sType", "Type: ")
			Me.sDetent = Util.AssignValueToConstant("rptCalcResults", "sDetent", "Detent")
			Me.sNonDetent = Util.AssignValueToConstant("rptCalcResults", "sNonDetent", "Non-detent")
			Me.sWaterCut = Util.AssignValueToConstant("rptCalcResults", "sWaterCut", "Water cut:")
			Me.sWaterSpGravity = Util.AssignValueToConstant("rptCalcResults", "sWaterSpGravity", "Water sp. gravity:")
			Me.sCasingPres = Util.AssignValueToConstant("rptCalcResults", "sCasingPres", "Casing pres.")
			Me.sFluidLevel = Util.AssignValueToConstant("rptCalcResults", "sFluidLevel", "Fluid level")
			Me.sPumpIntPr = Util.AssignValueToConstant("rptCalcResults", "sPumpIntPr", "Pump int. pr.")
			Me.sRunTime = Util.AssignValueToConstant("rptCalcResults", "sRunTime", "Run time (hrs/day):")
			Me.sTargetProd = Util.AssignValueToConstant("rptCalcResults", "sTargetProd", "Target prod.")
			Me.sStufBoxFr = Util.AssignValueToConstant("rptCalcResults", "sStufBoxFr", "Stuf.box fr.")
			Me.sTubingPres = Util.AssignValueToConstant("rptCalcResults", "sTubingPres", "Tubing pres.")
			Me.sPrimeMoverSpeedVariation = Util.AssignValueToConstant("rptCalcResults", "sPrimeMoverSpeedVariation", "Prime mover speed variation")
			Me.sCalculatedSpeedVariation = Util.AssignValueToConstant("rptCalcResults", "sCalculatedSpeedVariation", "Calculated speed variation:")
			Me.sEnteredSpeedVariation = Util.AssignValueToConstant("rptCalcResults", "sEnteredSpeedVariation", "Entered speed variation:")
			Me.sSpeedVariationNotConsidered = Util.AssignValueToConstant("rptCalcResults", "sSpeedVariationNotConsidered", " Speed variation not considered")
			Me.sPowerMeter = Util.AssignValueToConstant("rptCalcResults", "sPowerMeter", "Power Meter: ")
			Me.sElectricityCost = Util.AssignValueToConstant("rptCalcResults", "sElectricityCost", "Electr. cost: ")
			Me.sUnit = Util.AssignValueToConstant("rptCalcResults", "sUnit", "Pumping Unit: ")
			Me.sAPISize = Util.AssignValueToConstant("rptCalcResults", "sAPISize", "API size: ")
			Me.sUnitSize = Util.AssignValueToConstant("rptCalcResults", "sUnitSize", "Unit size: ")
			Me.sUnitID = Util.AssignValueToConstant("rptCalcResults", "sUnitID", "unit ID: ")
			Me.sXBALFile = Util.AssignValueToConstant("rptCalcResults", "sXBALFile", "XBAL file: ")
			Me.sCBALANCEFile = Util.AssignValueToConstant("rptCalcResults", "sCBALANCEFile", "CBALANCE file: ")
			Me.sRotation = Util.AssignValueToConstant("rptCalcResults", "sRotation", "Crank Rotation:")
			Me.sRotationWithWellToRight = Util.AssignValueToConstant("rptCalcResults", "sRotationWithWellToRight", "Crank Rotation with well to right:")
			Me.sCW = Util.AssignValueToConstant("rptCalcResults", "sCW", "CW")
			Me.sCCW = Util.AssignValueToConstant("rptCalcResults", "sCCW", "CCW")
			Me.sCalculatedStrokeLength = Util.AssignValueToConstant("rptCalcResults", "sCalculatedStrokeLength", "Calculated stroke length")
			Me.sAdjustedStrokeLength = Util.AssignValueToConstant("rptCalcResults", "sAdjustedStrokeLength", "Adjusted stroke length")
			Me.sSprocketRadius = Util.AssignValueToConstant("rptCalcResults", "sSprocketRadius", "Sprocket radius")
			Me.sClineSprocketDistance = Util.AssignValueToConstant("rptCalcResults", "sClineSprocketDistance", "C'line sprocket distance")
			Me.sDrumDiameterRatio = Util.AssignValueToConstant("rptCalcResults", "sDrumDiameterRatio", "Drum diameter ratio:")
			Me.sPitmanArmLength = Util.AssignValueToConstant("rptCalcResults", "sPitmanArmLength", "Pitman arm length")
			Me.sStructuralUnbalance = Util.AssignValueToConstant("rptCalcResults", "sStructuralUnbalance", "Structural unbalance")
			Me.sArtInertia = Util.AssignValueToConstant("rptCalcResults", "sArtInertia", "Art. Moment of Inertia")
			Me.sBalRotInertia = Util.AssignValueToConstant("rptCalcResults", "sBalRotInertia", "Bal. Rot. Moment of Inertia")
			Me.sEnteredRotInertia = Util.AssignValueToConstant("rptCalcResults", "sEnteredRotInertia", "Entered Rot. Moment of Inertia")
			Me.sCrankOffsetAngle = Util.AssignValueToConstant("rptCalcResults", "sCrankOffsetAngle", "Crank offset angle (deg):")
			Me.sNA = Util.AssignValueToConstant("rptCalcResults", "sNA", "N/A")
			Me.sSpeedVarNotIncluded = Util.AssignValueToConstant("rptCalcResults", "sSpeedVarNotIncluded", "(speed var. not included)")
			Me.sNEMADMotor = Util.AssignValueToConstant("rptCalcResults", "sNEMADMotor", "NEMA D motor:")
			Me.sMarathonMotor = Util.AssignValueToConstant("rptCalcResults", "sMarathonMotor", "Marathon NEMA B motor:")
			Me.sTatungMotor = Util.AssignValueToConstant("rptCalcResults", "sTatungMotor", "Tatung NEMA B motor:")
			Me.sSingleDoubleCylEngine = Util.AssignValueToConstant("rptCalcResults", "sSingleDoubleCylEngine", "Single/double cyl. engine:")
			Me.sMulticylinderEngine = Util.AssignValueToConstant("rptCalcResults", "sMulticylinderEngine", "Multicylinder engine:")
			Me.sGrossPumpStroke = Util.AssignValueToConstant("rptCalcResults", "sGrossPumpStroke", "Gross pump stroke")
			Me.sRecommendedPlungerLength = Util.AssignValueToConstant("rptCalcResults", "sRecommendedPlungerLength", "Recommended plunger length")
			Me.sProdLossDueToTubingStretch = Util.AssignValueToConstant("rptCalcResults", "sProdLossDueToTubingStretch", "Prod. loss due to tubing stretch")
			Me.sMinimumPumpLength = Util.AssignValueToConstant("rptCalcResults", "sMinimumPumpLength", "Minimum pump length")
			Me.sPumpSpacing = Util.AssignValueToConstant("rptCalcResults", "sPumpSpacing", "Pump spacing")
			Me.sTubingStretch = Util.AssignValueToConstant("rptCalcResults", "sTubingStretch", "Tubing stretch")
			Me.slbl = "lbl"
			Me.sAPIDesignation = Util.AssignValueToConstant("rptCalcResults", "sAPIDesignation", "API designation")
			Me.sUnitDesignation = Util.AssignValueToConstant("rptCalcResults", "sUnitDesignation", "Unit designation")
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

		Private Overridable Property PageFooter As PageFooter
			Get
				Return Me._PageFooter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PageFooter)
				Me._PageFooter = value
			End Set
		End Property

		Private Overridable Property lblParaffinDepth As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblParaffinDepth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblParaffinDepth = value
			End Set
		End Property

		Private Overridable Property txtParaffinDepth As DataDynamics.ActiveReports.Label
			Get
				Return Me._txtParaffinDepth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._txtParaffinDepth = value
			End Set
		End Property

		Private Sub InitializeComponent()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptCalcResults))
			Me.Detail = New Detail()
			Me.txtMPRLPPRL = New DataDynamics.ActiveReports.Label()
			Me.lblMPRLPPRL = New DataDynamics.ActiveReports.Label()
			Me.linRSInputSep4 = New Line()
			Me.lblMotorSPVHdr = New DataDynamics.ActiveReports.Label()
			Me.linRSInputSep1 = New Line()
			Me.linDivider = New Line()
			Me.linRSInputSep3 = New Line()
			Me.lblMotorSPV = New DataDynamics.ActiveReports.Label()
			Me.lblNEMAD = New DataDynamics.ActiveReports.Label()
			Me.Line1 = New Line()
			Me.lblInputData = New DataDynamics.ActiveReports.Label()
			Me.lblCalculatedResults = New DataDynamics.ActiveReports.Label()
			Me.Line3 = New Line()
			Me.lblRuntime = New DataDynamics.ActiveReports.Label()
			Me.lblFLPIP_2 = New DataDynamics.ActiveReports.Label()
			Me.lblFLPIP_1 = New DataDynamics.ActiveReports.Label()
			Me.lblCasingPressure = New DataDynamics.ActiveReports.Label()
			Me.lblStuffingBoxFriction = New DataDynamics.ActiveReports.Label()
			Me.lblFluidPropertiesHeader = New DataDynamics.ActiveReports.Label()
			Me.Line4 = New Line()
			Me.lblMotorHeader = New DataDynamics.ActiveReports.Label()
			Me.Line5 = New Line()
			Me.lblPowerMeter = New DataDynamics.ActiveReports.Label()
			Me.lblWaterCut = New DataDynamics.ActiveReports.Label()
			Me.lblWaterSPGR = New DataDynamics.ActiveReports.Label()
			Me.lblElectricityCost = New DataDynamics.ActiveReports.Label()
			Me.lblMotorType = New DataDynamics.ActiveReports.Label()
			Me.lblMotorSize = New DataDynamics.ActiveReports.Label()
			Me.lblMotorSetting = New DataDynamics.ActiveReports.Label()
			Me.lblOilSPGR = New DataDynamics.ActiveReports.Label()
			Me.lblFluidSPGR = New DataDynamics.ActiveReports.Label()
			Me.lblCompressibilityIndex = New DataDynamics.ActiveReports.Label()
			Me.lblPumpingUnitHeader = New DataDynamics.ActiveReports.Label()
			Me.Line6 = New Line()
			Me.lblAPIDesignation = New DataDynamics.ActiveReports.Label()
			Me.lblCrankHole = New DataDynamics.ActiveReports.Label()
			Me.lblPUDimR = New DataDynamics.ActiveReports.Label()
			Me.lblPUDimA = New DataDynamics.ActiveReports.Label()
			Me.lblPUDimC = New DataDynamics.ActiveReports.Label()
			Me.lblPUDimI = New DataDynamics.ActiveReports.Label()
			Me.lblPUDimK = New DataDynamics.ActiveReports.Label()
			Me.lblPUDimP = New DataDynamics.ActiveReports.Label()
			Me.lblPUDimM = New DataDynamics.ActiveReports.Label()
			Me.lblPUDimV0 = New DataDynamics.ActiveReports.Label()
			Me.lblPUDimS = New DataDynamics.ActiveReports.Label()
			Me.lblStrokeLength = New DataDynamics.ActiveReports.Label()
			Me.lblCrankRotation = New DataDynamics.ActiveReports.Label()
			Me.lblCwtInfo_1 = New DataDynamics.ActiveReports.Label()
			Me.lblCwtInfo_2 = New DataDynamics.ActiveReports.Label()
			Me.lblCwtInfo_3 = New DataDynamics.ActiveReports.Label()
			Me.lblCwtInfo_4 = New DataDynamics.ActiveReports.Label()
			Me.lblCwtInfo_5 = New DataDynamics.ActiveReports.Label()
			Me.lblCBDataFile = New DataDynamics.ActiveReports.Label()
			Me.lblPumpTubingHeader = New DataDynamics.ActiveReports.Label()
			Me.Line7 = New Line()
			Me.lblTubingOD = New DataDynamics.ActiveReports.Label()
			Me.lblTubingID = New DataDynamics.ActiveReports.Label()
			Me.lblPlungerSize = New DataDynamics.ActiveReports.Label()
			Me.lblRodStringDesign = New DataDynamics.ActiveReports.Label()
			Me.lblTqMinEner = New DataDynamics.ActiveReports.Label()
			Me.lblPeakTorque_BE = New DataDynamics.ActiveReports.Label()
			Me.lblGearboxLoading_BE = New DataDynamics.ActiveReports.Label()
			Me.lblCLF_BE = New DataDynamics.ActiveReports.Label()
			Me.lblMCM_BE = New DataDynamics.ActiveReports.Label()
			Me.lblCBE_BE = New DataDynamics.ActiveReports.Label()
			Me.lblMotorKWH_BE = New DataDynamics.ActiveReports.Label()
			Me.lblElectricBillPerMonth_BE = New DataDynamics.ActiveReports.Label()
			Me.lblDollarsPerBblFluid_BE = New DataDynamics.ActiveReports.Label()
			Me.lblDollarsPerBblOil_BE = New DataDynamics.ActiveReports.Label()
			Me.lblTqMinTorq = New DataDynamics.ActiveReports.Label()
			Me.lblPeakTorque_BT = New DataDynamics.ActiveReports.Label()
			Me.lblGearboxLoading_BT = New DataDynamics.ActiveReports.Label()
			Me.lblCLF_BT = New DataDynamics.ActiveReports.Label()
			Me.lblMCM_BT = New DataDynamics.ActiveReports.Label()
			Me.lblCBE_BT = New DataDynamics.ActiveReports.Label()
			Me.lblMotorKWH_BT = New DataDynamics.ActiveReports.Label()
			Me.lblElectricBillPerMonth_BT = New DataDynamics.ActiveReports.Label()
			Me.lblDollarsPerBblFluid_BT = New DataDynamics.ActiveReports.Label()
			Me.lblDollarsPerBblOil_BT = New DataDynamics.ActiveReports.Label()
			Me.lblTqExisting = New DataDynamics.ActiveReports.Label()
			Me.lblPeakTorque_E = New DataDynamics.ActiveReports.Label()
			Me.lblGearboxLoading_E = New DataDynamics.ActiveReports.Label()
			Me.lblCLF_E = New DataDynamics.ActiveReports.Label()
			Me.lblMCM_E = New DataDynamics.ActiveReports.Label()
			Me.lblCBE_E = New DataDynamics.ActiveReports.Label()
			Me.lblMotorKWH_E = New DataDynamics.ActiveReports.Label()
			Me.lblElectricBillPerMonth_E = New DataDynamics.ActiveReports.Label()
			Me.lblDollarsPerBblFluid_E = New DataDynamics.ActiveReports.Label()
			Me.lblDollarsPerBblOil_E = New DataDynamics.ActiveReports.Label()
			Me.Line8 = New Line()
			Me.lblPmMinEner = New DataDynamics.ActiveReports.Label()
			Me.lblNEMAD_BE = New DataDynamics.ActiveReports.Label()
			Me.lblSingleCyl_BE = New DataDynamics.ActiveReports.Label()
			Me.lblMultiCyl_BE = New DataDynamics.ActiveReports.Label()
			Me.lblPmMinTorq = New DataDynamics.ActiveReports.Label()
			Me.lblNEMAD_BT = New DataDynamics.ActiveReports.Label()
			Me.lblSingleCyl_BT = New DataDynamics.ActiveReports.Label()
			Me.lblMultiCyl_BT = New DataDynamics.ActiveReports.Label()
			Me.lblPmExisting = New DataDynamics.ActiveReports.Label()
			Me.lblNEMAD_E = New DataDynamics.ActiveReports.Label()
			Me.lblSingleCyl_E = New DataDynamics.ActiveReports.Label()
			Me.lblMultiCyl_E = New DataDynamics.ActiveReports.Label()
			Me.lblMultiCyl = New DataDynamics.ActiveReports.Label()
			Me.lblElectricityConsumption = New DataDynamics.ActiveReports.Label()
			Me.Line9 = New Line()
			Me.lblTubingCalculations = New DataDynamics.ActiveReports.Label()
			Me.Line10 = New Line()
			Me.Line11 = New Line()
			Me.lblRodDiamHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiamHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiam1 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGradeHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodLengthHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrengthHdrBot = New DataDynamics.ActiveReports.Label()
			Me.Line12 = New Line()
			Me.lblRodDiam2 = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiam3 = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiam4 = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiam5 = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiam6 = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiam7 = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiam8 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGrade1 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGrade2 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGrade3 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGrade4 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGrade5 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGrade6 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGrade7 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGrade8 = New DataDynamics.ActiveReports.Label()
			Me.lblRodLength1 = New DataDynamics.ActiveReports.Label()
			Me.lblRodLength2 = New DataDynamics.ActiveReports.Label()
			Me.lblRodLength3 = New DataDynamics.ActiveReports.Label()
			Me.lblRodLength4 = New DataDynamics.ActiveReports.Label()
			Me.lblRodLength5 = New DataDynamics.ActiveReports.Label()
			Me.lblRodLength6 = New DataDynamics.ActiveReports.Label()
			Me.lblRodLength7 = New DataDynamics.ActiveReports.Label()
			Me.lblRodLength8 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrength1 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrength2 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrength3 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrength4 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrength5 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrength6 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrength7 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrength8 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStringResults = New DataDynamics.ActiveReports.Label()
			Me.Line13 = New Line()
			Me.lblRodStressHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodStress1 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStressHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStressHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStressHdrBot = New DataDynamics.ActiveReports.Label()
			Me.Line14 = New Line()
			Me.lblRodStress2 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStress3 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStress4 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStress5 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStress6 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStress7 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStress8 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStress1 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStress2 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStress3 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStress4 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStress5 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStress6 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStress7 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStress8 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStress1 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStress2 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStress3 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStress4 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStress5 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStress6 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStress7 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStress8 = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStress1 = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStress2 = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStress3 = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStress4 = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStress5 = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStress6 = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStress7 = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStress8 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethodHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethod1 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethod2 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethod3 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethod4 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethod5 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethod6 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethod7 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethod8 = New DataDynamics.ActiveReports.Label()
			Me.lblFLPIP_3 = New DataDynamics.ActiveReports.Label()
			Me.lblSPM = New DataDynamics.ActiveReports.Label()
			Me.lblPlungerLength = New DataDynamics.ActiveReports.Label()
			Me.lblPumpLength = New DataDynamics.ActiveReports.Label()
			Me.lblPumpSpacing = New DataDynamics.ActiveReports.Label()
			Me.lblGrossPumpStroke = New DataDynamics.ActiveReports.Label()
			Me.lblProductionLoss = New DataDynamics.ActiveReports.Label()
			Me.lblTubingStretch = New DataDynamics.ActiveReports.Label()
			Me.lblPumpFriction = New DataDynamics.ActiveReports.Label()
			Me.lblPumpEfficiency = New DataDynamics.ActiveReports.Label()
			Me.lblPumpLoadAdj = New DataDynamics.ActiveReports.Label()
			Me.lblTubingAnchorDepth = New DataDynamics.ActiveReports.Label()
			Me.lblDownstrokeFriction = New DataDynamics.ActiveReports.Label()
			Me.lblPumpType = New DataDynamics.ActiveReports.Label()
			Me.lblPumpCondition = New DataDynamics.ActiveReports.Label()
			Me.lblPumpDepth = New DataDynamics.ActiveReports.Label()
			Me.lblDollarsPerBblOil = New DataDynamics.ActiveReports.Label()
			Me.lblDollarsPerBblFluid = New DataDynamics.ActiveReports.Label()
			Me.lblElectricBillPerMonth = New DataDynamics.ActiveReports.Label()
			Me.lblTorqueAnalysis = New DataDynamics.ActiveReports.Label()
			Me.lblSingleCyl = New DataDynamics.ActiveReports.Label()
			Me.lblMotorKWH = New DataDynamics.ActiveReports.Label()
			Me.lblTubingPressure = New DataDynamics.ActiveReports.Label()
			Me.lblReqPrimeMoverSize = New DataDynamics.ActiveReports.Label()
			Me.lblRodGradeHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStressHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStressHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethodHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStressHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrengthHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodLengthHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblPmBalancedT = New DataDynamics.ActiveReports.Label()
			Me.lblTqBalancedT = New DataDynamics.ActiveReports.Label()
			Me.lblTqBalancedE = New DataDynamics.ActiveReports.Label()
			Me.txtPlungerLength = New DataDynamics.ActiveReports.Label()
			Me.txtPumpLength = New DataDynamics.ActiveReports.Label()
			Me.txtPumpSpacing = New DataDynamics.ActiveReports.Label()
			Me.txtGrossPumpStroke = New DataDynamics.ActiveReports.Label()
			Me.txtProductionLoss = New DataDynamics.ActiveReports.Label()
			Me.txtTubingStretch = New DataDynamics.ActiveReports.Label()
			Me.txtTubingOD = New DataDynamics.ActiveReports.Label()
			Me.txtTubingID = New DataDynamics.ActiveReports.Label()
			Me.txtPlungerSize = New DataDynamics.ActiveReports.Label()
			Me.txtPumpType = New DataDynamics.ActiveReports.Label()
			Me.txtPumpCondition = New DataDynamics.ActiveReports.Label()
			Me.txtPumpDepth = New DataDynamics.ActiveReports.Label()
			Me.txtUpstrokeFriction = New DataDynamics.ActiveReports.Label()
			Me.txtDownstrokeFriction = New DataDynamics.ActiveReports.Label()
			Me.txtPumpFriction = New DataDynamics.ActiveReports.Label()
			Me.txtPumpLoadAdj = New DataDynamics.ActiveReports.Label()
			Me.txtTubingAnchorDepth = New DataDynamics.ActiveReports.Label()
			Me.txtPumpEfficiency = New DataDynamics.ActiveReports.Label()
			Me.txtPowerMeter = New DataDynamics.ActiveReports.Label()
			Me.txtElectricityCost = New DataDynamics.ActiveReports.Label()
			Me.txtMotorType = New DataDynamics.ActiveReports.Label()
			Me.txtMotorSize = New DataDynamics.ActiveReports.Label()
			Me.txtMotorSetting = New DataDynamics.ActiveReports.Label()
			Me.txtWaterCut = New DataDynamics.ActiveReports.Label()
			Me.txtWaterSPGR = New DataDynamics.ActiveReports.Label()
			Me.txtOilSPGR = New DataDynamics.ActiveReports.Label()
			Me.txtFluidSPGR = New DataDynamics.ActiveReports.Label()
			Me.txtCompressibilityIndex = New DataDynamics.ActiveReports.Label()
			Me.txtSPM = New DataDynamics.ActiveReports.Label()
			Me.txtRuntime = New DataDynamics.ActiveReports.Label()
			Me.txtTubingPressure = New DataDynamics.ActiveReports.Label()
			Me.txtCasingPressure = New DataDynamics.ActiveReports.Label()
			Me.txtFLPIP_1 = New DataDynamics.ActiveReports.Label()
			Me.txtFLPIP_2 = New DataDynamics.ActiveReports.Label()
			Me.txtFLPIP_3 = New DataDynamics.ActiveReports.Label()
			Me.txtStuffingBoxFriction = New DataDynamics.ActiveReports.Label()
			Me.lnPMSV = New Line()
			Me.txtCrankHole = New DataDynamics.ActiveReports.Label()
			Me.txtStrokeLength = New DataDynamics.ActiveReports.Label()
			Me.txtCrankRotation = New DataDynamics.ActiveReports.Label()
			Me.txtCwtInfo_1 = New DataDynamics.ActiveReports.Label()
			Me.txtCwtInfo_2 = New DataDynamics.ActiveReports.Label()
			Me.txtCwtInfo_3 = New DataDynamics.ActiveReports.Label()
			Me.txtCwtInfo_4 = New DataDynamics.ActiveReports.Label()
			Me.txtCwtInfo_5 = New DataDynamics.ActiveReports.Label()
			Me.linRSCalcSep3 = New Line()
			Me.linRSCalcSep1 = New Line()
			Me.linRSCalcSep2 = New Line()
			Me.linRSCalcSep4 = New Line()
			Me.lblUpstrokeFriction = New DataDynamics.ActiveReports.Label()
			Me.lblFricCoef1 = New DataDynamics.ActiveReports.Label()
			Me.lblFricCoef2 = New DataDynamics.ActiveReports.Label()
			Me.lblFricCoef3 = New DataDynamics.ActiveReports.Label()
			Me.lblFricCoef4 = New DataDynamics.ActiveReports.Label()
			Me.lblFricCoef5 = New DataDynamics.ActiveReports.Label()
			Me.lblFricCoef6 = New DataDynamics.ActiveReports.Label()
			Me.lblFricCoef7 = New DataDynamics.ActiveReports.Label()
			Me.lblFricCoef8 = New DataDynamics.ActiveReports.Label()
			Me.lblFric = New DataDynamics.ActiveReports.Label()
			Me.lblCoeff = New DataDynamics.ActiveReports.Label()
			Me.lblPmBalancedE = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiam9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGrade9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodLength9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrength9 = New DataDynamics.ActiveReports.Label()
			Me.lblFricCoef9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStress9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStress9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStress9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStress9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethod9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiam10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGrade10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodLength10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrength10 = New DataDynamics.ActiveReports.Label()
			Me.lblFricCoef10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStress10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStress10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStress10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStress10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethod10 = New DataDynamics.ActiveReports.Label()
			Me.picDyno = New Picture()
			Me.picTorquePlot = New Picture()
			Me.Line15 = New Line()
			Me.Line16 = New Line()
			Me.lblNoResults = New DataDynamics.ActiveReports.Label()
			Me.lblSystemEff = New DataDynamics.ActiveReports.Label()
			Me.txtStructLoading = New DataDynamics.ActiveReports.Label()
			Me.txtBPDSurface = New DataDynamics.ActiveReports.Label()
			Me.txtPermLoadHP = New DataDynamics.ActiveReports.Label()
			Me.txtSystemEff = New DataDynamics.ActiveReports.Label()
			Me.txtFluidLoad = New DataDynamics.ActiveReports.Label()
			Me.txtCalcSPM = New DataDynamics.ActiveReports.Label()
			Me.txtOilProduction = New DataDynamics.ActiveReports.Label()
			Me.lblFluidLoad = New DataDynamics.ActiveReports.Label()
			Me.lblPermLoadHP = New DataDynamics.ActiveReports.Label()
			Me.lblCalcSPM = New DataDynamics.ActiveReports.Label()
			Me.lblOilProduction = New DataDynamics.ActiveReports.Label()
			Me.lblBPDSurface = New DataDynamics.ActiveReports.Label()
			Me.lblPrhpPlhp = New DataDynamics.ActiveReports.Label()
			Me.lblStructLoading = New DataDynamics.ActiveReports.Label()
			Me.lblPRHP = New DataDynamics.ActiveReports.Label()
			Me.lblMPRL = New DataDynamics.ActiveReports.Label()
			Me.lblPPRL = New DataDynamics.ActiveReports.Label()
			Me.lblNoverNo = New DataDynamics.ActiveReports.Label()
			Me.txtRodWeight = New DataDynamics.ActiveReports.Label()
			Me.txtPrhpPlhp = New DataDynamics.ActiveReports.Label()
			Me.txtMPRL = New DataDynamics.ActiveReports.Label()
			Me.txtPPRL = New DataDynamics.ActiveReports.Label()
			Me.linRSInputSep2 = New Line()
			Me.lblRodWeight = New DataDynamics.ActiveReports.Label()
			Me.lblCBE = New DataDynamics.ActiveReports.Label()
			Me.lblMCM = New DataDynamics.ActiveReports.Label()
			Me.lblCLF = New DataDynamics.ActiveReports.Label()
			Me.lblFluidLevelTVD = New DataDynamics.ActiveReports.Label()
			Me.txtPRHP = New DataDynamics.ActiveReports.Label()
			Me.txtFluidLevelTVD = New DataDynamics.ActiveReports.Label()
			Me.lblPolRodDiam = New DataDynamics.ActiveReports.Label()
			Me.txtPolRodDiam = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote5 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote4 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote3 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote2 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote1 = New DataDynamics.ActiveReports.Label()
			Me.lblGearboxLoading = New DataDynamics.ActiveReports.Label()
			Me.lblPeakTorque = New DataDynamics.ActiveReports.Label()
			Me.txtParaffinDepth = New DataDynamics.ActiveReports.Label()
			Me.lblParaffinDepth = New DataDynamics.ActiveReports.Label()
			Me.PageHeader = New PageHeader()
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
			CType(Me.txtMPRLPPRL, ISupportInitialize).BeginInit()
			CType(Me.lblMPRLPPRL, ISupportInitialize).BeginInit()
			CType(Me.lblMotorSPVHdr, ISupportInitialize).BeginInit()
			CType(Me.lblMotorSPV, ISupportInitialize).BeginInit()
			CType(Me.lblNEMAD, ISupportInitialize).BeginInit()
			CType(Me.lblInputData, ISupportInitialize).BeginInit()
			CType(Me.lblCalculatedResults, ISupportInitialize).BeginInit()
			CType(Me.lblRuntime, ISupportInitialize).BeginInit()
			CType(Me.lblFLPIP_2, ISupportInitialize).BeginInit()
			CType(Me.lblFLPIP_1, ISupportInitialize).BeginInit()
			CType(Me.lblCasingPressure, ISupportInitialize).BeginInit()
			CType(Me.lblStuffingBoxFriction, ISupportInitialize).BeginInit()
			CType(Me.lblFluidPropertiesHeader, ISupportInitialize).BeginInit()
			CType(Me.lblMotorHeader, ISupportInitialize).BeginInit()
			CType(Me.lblPowerMeter, ISupportInitialize).BeginInit()
			CType(Me.lblWaterCut, ISupportInitialize).BeginInit()
			CType(Me.lblWaterSPGR, ISupportInitialize).BeginInit()
			CType(Me.lblElectricityCost, ISupportInitialize).BeginInit()
			CType(Me.lblMotorType, ISupportInitialize).BeginInit()
			CType(Me.lblMotorSize, ISupportInitialize).BeginInit()
			CType(Me.lblMotorSetting, ISupportInitialize).BeginInit()
			CType(Me.lblOilSPGR, ISupportInitialize).BeginInit()
			CType(Me.lblFluidSPGR, ISupportInitialize).BeginInit()
			CType(Me.lblCompressibilityIndex, ISupportInitialize).BeginInit()
			CType(Me.lblPumpingUnitHeader, ISupportInitialize).BeginInit()
			CType(Me.lblAPIDesignation, ISupportInitialize).BeginInit()
			CType(Me.lblCrankHole, ISupportInitialize).BeginInit()
			CType(Me.lblPUDimR, ISupportInitialize).BeginInit()
			CType(Me.lblPUDimA, ISupportInitialize).BeginInit()
			CType(Me.lblPUDimC, ISupportInitialize).BeginInit()
			CType(Me.lblPUDimI, ISupportInitialize).BeginInit()
			CType(Me.lblPUDimK, ISupportInitialize).BeginInit()
			CType(Me.lblPUDimP, ISupportInitialize).BeginInit()
			CType(Me.lblPUDimM, ISupportInitialize).BeginInit()
			CType(Me.lblPUDimV0, ISupportInitialize).BeginInit()
			CType(Me.lblPUDimS, ISupportInitialize).BeginInit()
			CType(Me.lblStrokeLength, ISupportInitialize).BeginInit()
			CType(Me.lblCrankRotation, ISupportInitialize).BeginInit()
			CType(Me.lblCwtInfo_1, ISupportInitialize).BeginInit()
			CType(Me.lblCwtInfo_2, ISupportInitialize).BeginInit()
			CType(Me.lblCwtInfo_3, ISupportInitialize).BeginInit()
			CType(Me.lblCwtInfo_4, ISupportInitialize).BeginInit()
			CType(Me.lblCwtInfo_5, ISupportInitialize).BeginInit()
			CType(Me.lblCBDataFile, ISupportInitialize).BeginInit()
			CType(Me.lblPumpTubingHeader, ISupportInitialize).BeginInit()
			CType(Me.lblTubingOD, ISupportInitialize).BeginInit()
			CType(Me.lblTubingID, ISupportInitialize).BeginInit()
			CType(Me.lblPlungerSize, ISupportInitialize).BeginInit()
			CType(Me.lblRodStringDesign, ISupportInitialize).BeginInit()
			CType(Me.lblTqMinEner, ISupportInitialize).BeginInit()
			CType(Me.lblPeakTorque_BE, ISupportInitialize).BeginInit()
			CType(Me.lblGearboxLoading_BE, ISupportInitialize).BeginInit()
			CType(Me.lblCLF_BE, ISupportInitialize).BeginInit()
			CType(Me.lblMCM_BE, ISupportInitialize).BeginInit()
			CType(Me.lblCBE_BE, ISupportInitialize).BeginInit()
			CType(Me.lblMotorKWH_BE, ISupportInitialize).BeginInit()
			CType(Me.lblElectricBillPerMonth_BE, ISupportInitialize).BeginInit()
			CType(Me.lblDollarsPerBblFluid_BE, ISupportInitialize).BeginInit()
			CType(Me.lblDollarsPerBblOil_BE, ISupportInitialize).BeginInit()
			CType(Me.lblTqMinTorq, ISupportInitialize).BeginInit()
			CType(Me.lblPeakTorque_BT, ISupportInitialize).BeginInit()
			CType(Me.lblGearboxLoading_BT, ISupportInitialize).BeginInit()
			CType(Me.lblCLF_BT, ISupportInitialize).BeginInit()
			CType(Me.lblMCM_BT, ISupportInitialize).BeginInit()
			CType(Me.lblCBE_BT, ISupportInitialize).BeginInit()
			CType(Me.lblMotorKWH_BT, ISupportInitialize).BeginInit()
			CType(Me.lblElectricBillPerMonth_BT, ISupportInitialize).BeginInit()
			CType(Me.lblDollarsPerBblFluid_BT, ISupportInitialize).BeginInit()
			CType(Me.lblDollarsPerBblOil_BT, ISupportInitialize).BeginInit()
			CType(Me.lblTqExisting, ISupportInitialize).BeginInit()
			CType(Me.lblPeakTorque_E, ISupportInitialize).BeginInit()
			CType(Me.lblGearboxLoading_E, ISupportInitialize).BeginInit()
			CType(Me.lblCLF_E, ISupportInitialize).BeginInit()
			CType(Me.lblMCM_E, ISupportInitialize).BeginInit()
			CType(Me.lblCBE_E, ISupportInitialize).BeginInit()
			CType(Me.lblMotorKWH_E, ISupportInitialize).BeginInit()
			CType(Me.lblElectricBillPerMonth_E, ISupportInitialize).BeginInit()
			CType(Me.lblDollarsPerBblFluid_E, ISupportInitialize).BeginInit()
			CType(Me.lblDollarsPerBblOil_E, ISupportInitialize).BeginInit()
			CType(Me.lblPmMinEner, ISupportInitialize).BeginInit()
			CType(Me.lblNEMAD_BE, ISupportInitialize).BeginInit()
			CType(Me.lblSingleCyl_BE, ISupportInitialize).BeginInit()
			CType(Me.lblMultiCyl_BE, ISupportInitialize).BeginInit()
			CType(Me.lblPmMinTorq, ISupportInitialize).BeginInit()
			CType(Me.lblNEMAD_BT, ISupportInitialize).BeginInit()
			CType(Me.lblSingleCyl_BT, ISupportInitialize).BeginInit()
			CType(Me.lblMultiCyl_BT, ISupportInitialize).BeginInit()
			CType(Me.lblPmExisting, ISupportInitialize).BeginInit()
			CType(Me.lblNEMAD_E, ISupportInitialize).BeginInit()
			CType(Me.lblSingleCyl_E, ISupportInitialize).BeginInit()
			CType(Me.lblMultiCyl_E, ISupportInitialize).BeginInit()
			CType(Me.lblMultiCyl, ISupportInitialize).BeginInit()
			CType(Me.lblElectricityConsumption, ISupportInitialize).BeginInit()
			CType(Me.lblTubingCalculations, ISupportInitialize).BeginInit()
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
			CType(Me.lblFLPIP_3, ISupportInitialize).BeginInit()
			CType(Me.lblSPM, ISupportInitialize).BeginInit()
			CType(Me.lblPlungerLength, ISupportInitialize).BeginInit()
			CType(Me.lblPumpLength, ISupportInitialize).BeginInit()
			CType(Me.lblPumpSpacing, ISupportInitialize).BeginInit()
			CType(Me.lblGrossPumpStroke, ISupportInitialize).BeginInit()
			CType(Me.lblProductionLoss, ISupportInitialize).BeginInit()
			CType(Me.lblTubingStretch, ISupportInitialize).BeginInit()
			CType(Me.lblPumpFriction, ISupportInitialize).BeginInit()
			CType(Me.lblPumpEfficiency, ISupportInitialize).BeginInit()
			CType(Me.lblPumpLoadAdj, ISupportInitialize).BeginInit()
			CType(Me.lblTubingAnchorDepth, ISupportInitialize).BeginInit()
			CType(Me.lblDownstrokeFriction, ISupportInitialize).BeginInit()
			CType(Me.lblPumpType, ISupportInitialize).BeginInit()
			CType(Me.lblPumpCondition, ISupportInitialize).BeginInit()
			CType(Me.lblPumpDepth, ISupportInitialize).BeginInit()
			CType(Me.lblDollarsPerBblOil, ISupportInitialize).BeginInit()
			CType(Me.lblDollarsPerBblFluid, ISupportInitialize).BeginInit()
			CType(Me.lblElectricBillPerMonth, ISupportInitialize).BeginInit()
			CType(Me.lblTorqueAnalysis, ISupportInitialize).BeginInit()
			CType(Me.lblSingleCyl, ISupportInitialize).BeginInit()
			CType(Me.lblMotorKWH, ISupportInitialize).BeginInit()
			CType(Me.lblTubingPressure, ISupportInitialize).BeginInit()
			CType(Me.lblReqPrimeMoverSize, ISupportInitialize).BeginInit()
			CType(Me.lblRodGradeHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStressHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStressHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethodHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStressHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrengthHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodLengthHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblPmBalancedT, ISupportInitialize).BeginInit()
			CType(Me.lblTqBalancedT, ISupportInitialize).BeginInit()
			CType(Me.lblTqBalancedE, ISupportInitialize).BeginInit()
			CType(Me.txtPlungerLength, ISupportInitialize).BeginInit()
			CType(Me.txtPumpLength, ISupportInitialize).BeginInit()
			CType(Me.txtPumpSpacing, ISupportInitialize).BeginInit()
			CType(Me.txtGrossPumpStroke, ISupportInitialize).BeginInit()
			CType(Me.txtProductionLoss, ISupportInitialize).BeginInit()
			CType(Me.txtTubingStretch, ISupportInitialize).BeginInit()
			CType(Me.txtTubingOD, ISupportInitialize).BeginInit()
			CType(Me.txtTubingID, ISupportInitialize).BeginInit()
			CType(Me.txtPlungerSize, ISupportInitialize).BeginInit()
			CType(Me.txtPumpType, ISupportInitialize).BeginInit()
			CType(Me.txtPumpCondition, ISupportInitialize).BeginInit()
			CType(Me.txtPumpDepth, ISupportInitialize).BeginInit()
			CType(Me.txtUpstrokeFriction, ISupportInitialize).BeginInit()
			CType(Me.txtDownstrokeFriction, ISupportInitialize).BeginInit()
			CType(Me.txtPumpFriction, ISupportInitialize).BeginInit()
			CType(Me.txtPumpLoadAdj, ISupportInitialize).BeginInit()
			CType(Me.txtTubingAnchorDepth, ISupportInitialize).BeginInit()
			CType(Me.txtPumpEfficiency, ISupportInitialize).BeginInit()
			CType(Me.txtPowerMeter, ISupportInitialize).BeginInit()
			CType(Me.txtElectricityCost, ISupportInitialize).BeginInit()
			CType(Me.txtMotorType, ISupportInitialize).BeginInit()
			CType(Me.txtMotorSize, ISupportInitialize).BeginInit()
			CType(Me.txtMotorSetting, ISupportInitialize).BeginInit()
			CType(Me.txtWaterCut, ISupportInitialize).BeginInit()
			CType(Me.txtWaterSPGR, ISupportInitialize).BeginInit()
			CType(Me.txtOilSPGR, ISupportInitialize).BeginInit()
			CType(Me.txtFluidSPGR, ISupportInitialize).BeginInit()
			CType(Me.txtCompressibilityIndex, ISupportInitialize).BeginInit()
			CType(Me.txtSPM, ISupportInitialize).BeginInit()
			CType(Me.txtRuntime, ISupportInitialize).BeginInit()
			CType(Me.txtTubingPressure, ISupportInitialize).BeginInit()
			CType(Me.txtCasingPressure, ISupportInitialize).BeginInit()
			CType(Me.txtFLPIP_1, ISupportInitialize).BeginInit()
			CType(Me.txtFLPIP_2, ISupportInitialize).BeginInit()
			CType(Me.txtFLPIP_3, ISupportInitialize).BeginInit()
			CType(Me.txtStuffingBoxFriction, ISupportInitialize).BeginInit()
			CType(Me.txtCrankHole, ISupportInitialize).BeginInit()
			CType(Me.txtStrokeLength, ISupportInitialize).BeginInit()
			CType(Me.txtCrankRotation, ISupportInitialize).BeginInit()
			CType(Me.txtCwtInfo_1, ISupportInitialize).BeginInit()
			CType(Me.txtCwtInfo_2, ISupportInitialize).BeginInit()
			CType(Me.txtCwtInfo_3, ISupportInitialize).BeginInit()
			CType(Me.txtCwtInfo_4, ISupportInitialize).BeginInit()
			CType(Me.txtCwtInfo_5, ISupportInitialize).BeginInit()
			CType(Me.lblUpstrokeFriction, ISupportInitialize).BeginInit()
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
			CType(Me.lblPmBalancedE, ISupportInitialize).BeginInit()
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
			CType(Me.picDyno, ISupportInitialize).BeginInit()
			CType(Me.picTorquePlot, ISupportInitialize).BeginInit()
			CType(Me.lblNoResults, ISupportInitialize).BeginInit()
			CType(Me.lblSystemEff, ISupportInitialize).BeginInit()
			CType(Me.txtStructLoading, ISupportInitialize).BeginInit()
			CType(Me.txtBPDSurface, ISupportInitialize).BeginInit()
			CType(Me.txtPermLoadHP, ISupportInitialize).BeginInit()
			CType(Me.txtSystemEff, ISupportInitialize).BeginInit()
			CType(Me.txtFluidLoad, ISupportInitialize).BeginInit()
			CType(Me.txtCalcSPM, ISupportInitialize).BeginInit()
			CType(Me.txtOilProduction, ISupportInitialize).BeginInit()
			CType(Me.lblFluidLoad, ISupportInitialize).BeginInit()
			CType(Me.lblPermLoadHP, ISupportInitialize).BeginInit()
			CType(Me.lblCalcSPM, ISupportInitialize).BeginInit()
			CType(Me.lblOilProduction, ISupportInitialize).BeginInit()
			CType(Me.lblBPDSurface, ISupportInitialize).BeginInit()
			CType(Me.lblPrhpPlhp, ISupportInitialize).BeginInit()
			CType(Me.lblStructLoading, ISupportInitialize).BeginInit()
			CType(Me.lblPRHP, ISupportInitialize).BeginInit()
			CType(Me.lblMPRL, ISupportInitialize).BeginInit()
			CType(Me.lblPPRL, ISupportInitialize).BeginInit()
			CType(Me.lblNoverNo, ISupportInitialize).BeginInit()
			CType(Me.txtRodWeight, ISupportInitialize).BeginInit()
			CType(Me.txtPrhpPlhp, ISupportInitialize).BeginInit()
			CType(Me.txtMPRL, ISupportInitialize).BeginInit()
			CType(Me.txtPPRL, ISupportInitialize).BeginInit()
			CType(Me.lblRodWeight, ISupportInitialize).BeginInit()
			CType(Me.lblCBE, ISupportInitialize).BeginInit()
			CType(Me.lblMCM, ISupportInitialize).BeginInit()
			CType(Me.lblCLF, ISupportInitialize).BeginInit()
			CType(Me.lblFluidLevelTVD, ISupportInitialize).BeginInit()
			CType(Me.txtPRHP, ISupportInitialize).BeginInit()
			CType(Me.txtFluidLevelTVD, ISupportInitialize).BeginInit()
			CType(Me.lblPolRodDiam, ISupportInitialize).BeginInit()
			CType(Me.txtPolRodDiam, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote5, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote4, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote3, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote2, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote1, ISupportInitialize).BeginInit()
			CType(Me.lblGearboxLoading, ISupportInitialize).BeginInit()
			CType(Me.lblPeakTorque, ISupportInitialize).BeginInit()
			CType(Me.txtParaffinDepth, ISupportInitialize).BeginInit()
			CType(Me.lblParaffinDepth, ISupportInitialize).BeginInit()
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
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.CanShrink = True
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Controls.AddRange(New ARControl() { Me.txtMPRLPPRL, Me.lblMPRLPPRL, Me.linRSInputSep4, Me.lblMotorSPVHdr, Me.linRSInputSep1, Me.linDivider, Me.linRSInputSep3, Me.lblMotorSPV, Me.lblNEMAD, Me.Line1, Me.lblInputData, Me.lblCalculatedResults, Me.Line3, Me.lblRuntime, Me.lblFLPIP_2, Me.lblFLPIP_1, Me.lblCasingPressure, Me.lblStuffingBoxFriction, Me.lblFluidPropertiesHeader, Me.Line4, Me.lblMotorHeader, Me.Line5, Me.lblPowerMeter, Me.lblWaterCut, Me.lblWaterSPGR, Me.lblElectricityCost, Me.lblMotorType, Me.lblMotorSize, Me.lblMotorSetting, Me.lblOilSPGR, Me.lblFluidSPGR, Me.lblCompressibilityIndex, Me.lblPumpingUnitHeader, Me.Line6, Me.lblAPIDesignation, Me.lblCrankHole, Me.lblPUDimR, Me.lblPUDimA, Me.lblPUDimC, Me.lblPUDimI, Me.lblPUDimK, Me.lblPUDimP, Me.lblPUDimM, Me.lblPUDimV0, Me.lblPUDimS, Me.lblStrokeLength, Me.lblCrankRotation, Me.lblCwtInfo_1, Me.lblCwtInfo_2, Me.lblCwtInfo_3, Me.lblCwtInfo_4, Me.lblCwtInfo_5, Me.lblCBDataFile, Me.lblPumpTubingHeader, Me.Line7, Me.lblTubingOD, Me.lblTubingID, Me.lblPlungerSize, Me.lblRodStringDesign, Me.lblTqMinEner, Me.lblPeakTorque_BE, Me.lblGearboxLoading_BE, Me.lblCLF_BE, Me.lblMCM_BE, Me.lblCBE_BE, Me.lblMotorKWH_BE, Me.lblElectricBillPerMonth_BE, Me.lblDollarsPerBblFluid_BE, Me.lblDollarsPerBblOil_BE, Me.lblTqMinTorq, Me.lblPeakTorque_BT, Me.lblGearboxLoading_BT, Me.lblCLF_BT, Me.lblMCM_BT, Me.lblCBE_BT, Me.lblMotorKWH_BT, Me.lblElectricBillPerMonth_BT, Me.lblDollarsPerBblFluid_BT, Me.lblDollarsPerBblOil_BT, Me.lblTqExisting, Me.lblPeakTorque_E, Me.lblGearboxLoading_E, Me.lblCLF_E, Me.lblMCM_E, Me.lblCBE_E, Me.lblMotorKWH_E, Me.lblElectricBillPerMonth_E, Me.lblDollarsPerBblFluid_E, Me.lblDollarsPerBblOil_E, Me.Line8, Me.lblPmMinEner, Me.lblNEMAD_BE, Me.lblSingleCyl_BE, Me.lblMultiCyl_BE, Me.lblPmMinTorq, Me.lblNEMAD_BT, Me.lblSingleCyl_BT, Me.lblMultiCyl_BT, Me.lblPmExisting, Me.lblNEMAD_E, Me.lblSingleCyl_E, Me.lblMultiCyl_E, Me.lblMultiCyl, Me.lblElectricityConsumption, Me.Line9, Me.lblTubingCalculations, Me.Line10, Me.Line11, Me.lblRodDiamHdrTop, Me.lblRodDiamHdrBot, Me.lblRodDiam1, Me.lblRodGradeHdrBot, Me.lblRodLengthHdrBot, Me.lblRodTensileStrengthHdrBot, Me.Line12, Me.lblRodDiam2, Me.lblRodDiam3, Me.lblRodDiam4, Me.lblRodDiam5, Me.lblRodDiam6, Me.lblRodDiam7, Me.lblRodDiam8, Me.lblRodGrade1, Me.lblRodGrade2, Me.lblRodGrade3, Me.lblRodGrade4, Me.lblRodGrade5, Me.lblRodGrade6, Me.lblRodGrade7, Me.lblRodGrade8, Me.lblRodLength1, Me.lblRodLength2, Me.lblRodLength3, Me.lblRodLength4, Me.lblRodLength5, Me.lblRodLength6, Me.lblRodLength7, Me.lblRodLength8, Me.lblRodTensileStrength1, Me.lblRodTensileStrength2, Me.lblRodTensileStrength3, Me.lblRodTensileStrength4, Me.lblRodTensileStrength5, Me.lblRodTensileStrength6, Me.lblRodTensileStrength7, Me.lblRodTensileStrength8, Me.lblRodStringResults, Me.Line13, Me.lblRodStressHdrBot, Me.lblRodStress1, Me.lblRodTopMaxStressHdrBot, Me.lblRodTopMinStressHdrBot, Me.lblRodBotMinStressHdrBot, Me.Line14, Me.lblRodStress2, Me.lblRodStress3, Me.lblRodStress4, Me.lblRodStress5, Me.lblRodStress6, Me.lblRodStress7, Me.lblRodStress8, Me.lblRodTopMaxStress1, Me.lblRodTopMaxStress2, Me.lblRodTopMaxStress3, Me.lblRodTopMaxStress4, Me.lblRodTopMaxStress5, Me.lblRodTopMaxStress6, Me.lblRodTopMaxStress7, Me.lblRodTopMaxStress8, Me.lblRodTopMinStress1, Me.lblRodTopMinStress2, Me.lblRodTopMinStress3, Me.lblRodTopMinStress4, Me.lblRodTopMinStress5, Me.lblRodTopMinStress6, Me.lblRodTopMinStress7, Me.lblRodTopMinStress8, Me.lblRodBotMinStress1, Me.lblRodBotMinStress2, Me.lblRodBotMinStress3, Me.lblRodBotMinStress4, Me.lblRodBotMinStress5, Me.lblRodBotMinStress6, Me.lblRodBotMinStress7, Me.lblRodBotMinStress8, Me.lblRodStressMethodHdrBot, Me.lblRodStressMethod1, Me.lblRodStressMethod2, Me.lblRodStressMethod3, Me.lblRodStressMethod4, Me.lblRodStressMethod5, Me.lblRodStressMethod6, Me.lblRodStressMethod7, Me.lblRodStressMethod8, Me.lblFLPIP_3, Me.lblSPM, Me.lblPlungerLength, Me.lblPumpLength, Me.lblPumpSpacing, Me.lblGrossPumpStroke, Me.lblProductionLoss, Me.lblTubingStretch, Me.lblPumpFriction, Me.lblPumpEfficiency, Me.lblPumpLoadAdj, Me.lblTubingAnchorDepth, Me.lblDownstrokeFriction, Me.lblPumpType, Me.lblPumpCondition, Me.lblPumpDepth, Me.lblDollarsPerBblOil, Me.lblDollarsPerBblFluid, Me.lblElectricBillPerMonth, Me.lblTorqueAnalysis, Me.lblSingleCyl, Me.lblMotorKWH, Me.lblTubingPressure, Me.lblReqPrimeMoverSize, Me.lblRodGradeHdrTop, Me.lblRodTopMinStressHdrTop, Me.lblRodBotMinStressHdrTop, Me.lblRodStressMethodHdrTop, Me.lblRodTopMaxStressHdrTop, Me.lblRodStressHdrTop, Me.lblRodTensileStrengthHdrTop, Me.lblRodLengthHdrTop, Me.lblPmBalancedT, Me.lblTqBalancedT, Me.lblTqBalancedE, Me.txtPlungerLength, Me.txtPumpLength, Me.txtPumpSpacing, Me.txtGrossPumpStroke, Me.txtProductionLoss, Me.txtTubingStretch, Me.txtTubingOD, Me.txtTubingID, Me.txtPlungerSize, Me.txtPumpType, Me.txtPumpCondition, Me.txtPumpDepth, Me.txtUpstrokeFriction, Me.txtDownstrokeFriction, Me.txtPumpFriction, Me.txtPumpLoadAdj, Me.txtTubingAnchorDepth, Me.txtPumpEfficiency, Me.txtPowerMeter, Me.txtElectricityCost, Me.txtMotorType, Me.txtMotorSize, Me.txtMotorSetting, Me.txtWaterCut, Me.txtWaterSPGR, Me.txtOilSPGR, Me.txtFluidSPGR, Me.txtCompressibilityIndex, Me.txtSPM, Me.txtRuntime, Me.txtTubingPressure, Me.txtCasingPressure, Me.txtFLPIP_1, Me.txtFLPIP_2, Me.txtFLPIP_3, Me.txtStuffingBoxFriction, Me.lnPMSV, Me.txtCrankHole, Me.txtStrokeLength, Me.txtCrankRotation, Me.txtCwtInfo_1, Me.txtCwtInfo_2, Me.txtCwtInfo_3, Me.txtCwtInfo_4, Me.txtCwtInfo_5, Me.linRSCalcSep3, Me.linRSCalcSep1, Me.linRSCalcSep2, Me.linRSCalcSep4, Me.lblUpstrokeFriction, Me.lblFricCoef1, Me.lblFricCoef2, Me.lblFricCoef3, Me.lblFricCoef4, Me.lblFricCoef5, Me.lblFricCoef6, Me.lblFricCoef7, Me.lblFricCoef8, Me.lblFric, Me.lblCoeff, Me.lblPmBalancedE, Me.lblRodDiam9, Me.lblRodGrade9, Me.lblRodLength9, Me.lblRodTensileStrength9, Me.lblFricCoef9, Me.lblRodStress9, Me.lblRodTopMaxStress9, Me.lblRodTopMinStress9, Me.lblRodBotMinStress9, Me.lblRodStressMethod9, Me.lblRodDiam10, Me.lblRodGrade10, Me.lblRodLength10, Me.lblRodTensileStrength10, Me.lblFricCoef10, Me.lblRodStress10, Me.lblRodTopMaxStress10, Me.lblRodTopMinStress10, Me.lblRodBotMinStress10, Me.lblRodStressMethod10, Me.picDyno, Me.picTorquePlot, Me.Line15, Me.Line16, Me.lblNoResults, Me.lblSystemEff, Me.txtStructLoading, Me.txtBPDSurface, Me.txtPermLoadHP, Me.txtSystemEff, Me.txtFluidLoad, Me.txtCalcSPM, Me.txtOilProduction, Me.lblFluidLoad, Me.lblPermLoadHP, Me.lblCalcSPM, Me.lblOilProduction, Me.lblBPDSurface, Me.lblPrhpPlhp, Me.lblStructLoading, Me.lblPRHP, Me.lblMPRL, Me.lblPPRL, Me.lblNoverNo, Me.txtRodWeight, Me.txtPrhpPlhp, Me.txtMPRL, Me.txtPPRL, Me.linRSInputSep2, Me.lblRodWeight, Me.lblCBE, Me.lblMCM, Me.lblCLF, Me.lblFluidLevelTVD, Me.txtPRHP, Me.txtFluidLevelTVD, Me.lblPolRodDiam, Me.txtPolRodDiam, Me.lblRSFootnote5, Me.lblRSFootnote4, Me.lblRSFootnote3, Me.lblRSFootnote2, Me.lblRSFootnote1, Me.lblGearboxLoading, Me.lblPeakTorque, Me.txtParaffinDepth, Me.lblParaffinDepth })
			Me.Detail.Height = 10.1875F
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.txtMPRLPPRL.Height = 0.125F
			Me.txtMPRLPPRL.HyperLink = Nothing
			Me.txtMPRLPPRL.Left = 7.4375F
			Me.txtMPRLPPRL.Name = "txtMPRLPPRL"
			Me.txtMPRLPPRL.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtMPRLPPRL.Text = ""
			Me.txtMPRLPPRL.Top = 0.625F
			Me.txtMPRLPPRL.Width = 0.5625F
			Me.lblMPRLPPRL.Height = 0.125F
			Me.lblMPRLPPRL.HyperLink = Nothing
			Me.lblMPRLPPRL.Left = 6.125F
			Me.lblMPRLPPRL.Name = "lblMPRLPPRL"
			Me.lblMPRLPPRL.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMPRLPPRL.Text = "MPRL/PPRL"
			Me.lblMPRLPPRL.Top = 0.625F
			Me.lblMPRLPPRL.Width = 1.3F
			Me.linRSInputSep4.Height = 1.6F
			Me.linRSInputSep4.Left = 3.25F
			Me.linRSInputSep4.LineWeight = 1F
			Me.linRSInputSep4.Name = "linRSInputSep4"
			Me.linRSInputSep4.Top = 5.25F
			Me.linRSInputSep4.Width = 0F
			Me.linRSInputSep4.X1 = 3.25F
			Me.linRSInputSep4.X2 = 3.25F
			Me.linRSInputSep4.Y1 = 5.25F
			Me.linRSInputSep4.Y2 = 6.85F
			Me.lblMotorSPVHdr.Height = 0.145F
			Me.lblMotorSPVHdr.HyperLink = Nothing
			Me.lblMotorSPVHdr.Left = 3.8125F
			Me.lblMotorSPVHdr.Name = "lblMotorSPVHdr"
			Me.lblMotorSPVHdr.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblMotorSPVHdr.Text = "(speed var. not included)"
			Me.lblMotorSPVHdr.Top = 1.6F
			Me.lblMotorSPVHdr.Width = 3.375F
			Me.linRSInputSep1.Height = 1.6F
			Me.linRSInputSep1.Left = 0.75F
			Me.linRSInputSep1.LineWeight = 1F
			Me.linRSInputSep1.Name = "linRSInputSep1"
			Me.linRSInputSep1.Top = 5.25F
			Me.linRSInputSep1.Width = 0F
			Me.linRSInputSep1.X1 = 0.75F
			Me.linRSInputSep1.X2 = 0.75F
			Me.linRSInputSep1.Y1 = 5.25F
			Me.linRSInputSep1.Y2 = 6.85F
			Me.linDivider.Height = 6.725F
			Me.linDivider.Left = 3.6875F
			Me.linDivider.LineWeight = 1F
			Me.linDivider.Name = "linDivider"
			Me.linDivider.Top = 0.125F
			Me.linDivider.Width = 0F
			Me.linDivider.X1 = 3.6875F
			Me.linDivider.X2 = 3.6875F
			Me.linDivider.Y1 = 0.125F
			Me.linDivider.Y2 = 6.85F
			Me.linRSInputSep3.Height = 1.6F
			Me.linRSInputSep3.Left = 2.375F
			Me.linRSInputSep3.LineWeight = 1F
			Me.linRSInputSep3.Name = "linRSInputSep3"
			Me.linRSInputSep3.Top = 5.25F
			Me.linRSInputSep3.Width = 0F
			Me.linRSInputSep3.X1 = 2.375F
			Me.linRSInputSep3.X2 = 2.375F
			Me.linRSInputSep3.Y1 = 5.25F
			Me.linRSInputSep3.Y2 = 6.85F
			Me.lblMotorSPV.Height = 0.145F
			Me.lblMotorSPV.HyperLink = Nothing
			Me.lblMotorSPV.Left = 3.75F
			Me.lblMotorSPV.Name = "lblMotorSPV"
			Me.lblMotorSPV.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMotorSPV.Text = "(speed var. not included)"
			Me.lblMotorSPV.Top = 1.75F
			Me.lblMotorSPV.Width = 1.875F
			Me.lblNEMAD.Height = 0.145F
			Me.lblNEMAD.HyperLink = Nothing
			Me.lblNEMAD.Left = 3.75F
			Me.lblNEMAD.Name = "lblNEMAD"
			Me.lblNEMAD.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblNEMAD.Text = "NEMA D motor:"
			Me.lblNEMAD.Top = 1.8F
			Me.lblNEMAD.Width = 1.875F
			Me.Line1.Height = 0F
			Me.Line1.Left = 0.0625F
			Me.Line1.LineWeight = 3F
			Me.Line1.Name = "Line1"
			Me.Line1.Top = 0.0625F
			Me.Line1.Width = 7.938F
			Me.Line1.X1 = 0.0625F
			Me.Line1.X2 = 8.0005F
			Me.Line1.Y1 = 0.0625F
			Me.Line1.Y2 = 0.0625F
			Me.lblInputData.Height = 0.1325F
			Me.lblInputData.HyperLink = Nothing
			Me.lblInputData.Left = 0.0625F
			Me.lblInputData.Name = "lblInputData"
			Me.lblInputData.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblInputData.Text = "INPUT DATA"
			Me.lblInputData.Top = 0.125F
			Me.lblInputData.Width = 3.5625F
			Me.lblCalculatedResults.Height = 0.1325F
			Me.lblCalculatedResults.HyperLink = Nothing
			Me.lblCalculatedResults.Left = 3.75F
			Me.lblCalculatedResults.Name = "lblCalculatedResults"
			Me.lblCalculatedResults.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center"
			Me.lblCalculatedResults.Text = "CALCULATED RESULTS"
			Me.lblCalculatedResults.Top = 0.125F
			Me.lblCalculatedResults.Width = 4.25F
			Me.Line3.Height = 0F
			Me.Line3.Left = 0.0625F
			Me.Line3.LineWeight = 1F
			Me.Line3.Name = "Line3"
			Me.Line3.Top = 0.3125F
			Me.Line3.Width = 7.9375F
			Me.Line3.X1 = 0.0625F
			Me.Line3.X2 = 8F
			Me.Line3.Y1 = 0.3125F
			Me.Line3.Y2 = 0.3125F
			Me.lblRuntime.Height = 0.145F
			Me.lblRuntime.HyperLink = Nothing
			Me.lblRuntime.Left = 0.0625F
			Me.lblRuntime.Name = "lblRuntime"
			Me.lblRuntime.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblRuntime.Text = "Run time"
			Me.lblRuntime.Top = 0.5F
			Me.lblRuntime.Width = 1.125F
			Me.lblFLPIP_2.Height = 0.145F
			Me.lblFLPIP_2.HyperLink = Nothing
			Me.lblFLPIP_2.Left = 1.875F
			Me.lblFLPIP_2.Name = "lblFLPIP_2"
			Me.lblFLPIP_2.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblFLPIP_2.Text = "  ft from surface"
			Me.lblFLPIP_2.Top = 0.5F
			Me.lblFLPIP_2.Width = 1.0625F
			Me.lblFLPIP_1.Height = 0.145F
			Me.lblFLPIP_1.HyperLink = Nothing
			Me.lblFLPIP_1.Left = 1.875F
			Me.lblFLPIP_1.Name = "lblFLPIP_1"
			Me.lblFLPIP_1.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblFLPIP_1.Text = "Fluid level"
			Me.lblFLPIP_1.Top = 0.375F
			Me.lblFLPIP_1.Width = 1.0625F
			Me.lblCasingPressure.Height = 0.145F
			Me.lblCasingPressure.HyperLink = Nothing
			Me.lblCasingPressure.Left = 0.0625F
			Me.lblCasingPressure.Name = "lblCasingPressure"
			Me.lblCasingPressure.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblCasingPressure.Text = "Casing pressure"
			Me.lblCasingPressure.Top = 0.75F
			Me.lblCasingPressure.Width = 1.125F
			Me.lblStuffingBoxFriction.Height = 0.145F
			Me.lblStuffingBoxFriction.HyperLink = Nothing
			Me.lblStuffingBoxFriction.Left = 1.875F
			Me.lblStuffingBoxFriction.Name = "lblStuffingBoxFriction"
			Me.lblStuffingBoxFriction.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblStuffingBoxFriction.Text = "Stuffing box friction"
			Me.lblStuffingBoxFriction.Top = 0.75F
			Me.lblStuffingBoxFriction.Width = 1.0625F
			Me.lblFluidPropertiesHeader.Height = 0.15F
			Me.lblFluidPropertiesHeader.HyperLink = Nothing
			Me.lblFluidPropertiesHeader.Left = 0.0625F
			Me.lblFluidPropertiesHeader.Name = "lblFluidPropertiesHeader"
			Me.lblFluidPropertiesHeader.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblFluidPropertiesHeader.Text = "Fluid properties"
			Me.lblFluidPropertiesHeader.Top = 1.125F
			Me.lblFluidPropertiesHeader.Width = 1.75F
			Me.Line4.Height = 0F
			Me.Line4.Left = 0.0625F
			Me.Line4.LineWeight = 1F
			Me.Line4.Name = "Line4"
			Me.Line4.Top = 1.3125F
			Me.Line4.Width = 1.75F
			Me.Line4.X1 = 0.0625F
			Me.Line4.X2 = 1.8125F
			Me.Line4.Y1 = 1.3125F
			Me.Line4.Y2 = 1.3125F
			Me.lblMotorHeader.Height = 0.15F
			Me.lblMotorHeader.HyperLink = Nothing
			Me.lblMotorHeader.Left = 1.875F
			Me.lblMotorHeader.Name = "lblMotorHeader"
			Me.lblMotorHeader.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblMotorHeader.Text = "Motor & power meter"
			Me.lblMotorHeader.Top = 1.125F
			Me.lblMotorHeader.Width = 1.75F
			Me.Line5.Height = 0F
			Me.Line5.Left = 1.88F
			Me.Line5.LineWeight = 1F
			Me.Line5.Name = "Line5"
			Me.Line5.Top = 1.3125F
			Me.Line5.Width = 1.75F
			Me.Line5.X1 = 1.88F
			Me.Line5.X2 = 3.63F
			Me.Line5.Y1 = 1.3125F
			Me.Line5.Y2 = 1.3125F
			Me.lblPowerMeter.Height = 0.145F
			Me.lblPowerMeter.HyperLink = Nothing
			Me.lblPowerMeter.Left = 1.875F
			Me.lblPowerMeter.Name = "lblPowerMeter"
			Me.lblPowerMeter.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblPowerMeter.Text = "Power meter:"
			Me.lblPowerMeter.Top = 1.375F
			Me.lblPowerMeter.Width = 0.675F
			Me.lblWaterCut.Height = 0.145F
			Me.lblWaterCut.HyperLink = Nothing
			Me.lblWaterCut.Left = 0.0625F
			Me.lblWaterCut.Name = "lblWaterCut"
			Me.lblWaterCut.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblWaterCut.Text = "Water cut"
			Me.lblWaterCut.Top = 1.375F
			Me.lblWaterCut.Width = 1.125F
			Me.lblWaterSPGR.Height = 0.145F
			Me.lblWaterSPGR.HyperLink = Nothing
			Me.lblWaterSPGR.Left = 0.0625F
			Me.lblWaterSPGR.Name = "lblWaterSPGR"
			Me.lblWaterSPGR.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblWaterSPGR.Text = "Water sp.gr."
			Me.lblWaterSPGR.Top = 1.5F
			Me.lblWaterSPGR.Width = 1.125F
			Me.lblElectricityCost.Height = 0.145F
			Me.lblElectricityCost.HyperLink = Nothing
			Me.lblElectricityCost.Left = 1.875F
			Me.lblElectricityCost.Name = "lblElectricityCost"
			Me.lblElectricityCost.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblElectricityCost.Text = "Electr. cost:"
			Me.lblElectricityCost.Top = 1.5F
			Me.lblElectricityCost.Width = 0.675F
			Me.lblMotorType.Height = 0.145F
			Me.lblMotorType.HyperLink = Nothing
			Me.lblMotorType.Left = 1.875F
			Me.lblMotorType.Name = "lblMotorType"
			Me.lblMotorType.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMotorType.Text = "Motor type"
			Me.lblMotorType.Top = 1.625F
			Me.lblMotorType.Width = 0.675F
			Me.lblMotorSize.Height = 0.145F
			Me.lblMotorSize.HyperLink = Nothing
			Me.lblMotorSize.Left = 1.875F
			Me.lblMotorSize.Name = "lblMotorSize"
			Me.lblMotorSize.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMotorSize.Text = "Motor size"
			Me.lblMotorSize.Top = 1.75F
			Me.lblMotorSize.Width = 0.675F
			Me.lblMotorSetting.Height = 0.145F
			Me.lblMotorSetting.HyperLink = Nothing
			Me.lblMotorSetting.Left = 1.875F
			Me.lblMotorSetting.Name = "lblMotorSetting"
			Me.lblMotorSetting.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMotorSetting.Text = "Motor setting"
			Me.lblMotorSetting.Top = 1.875F
			Me.lblMotorSetting.Width = 0.7F
			Me.lblOilSPGR.Height = 0.145F
			Me.lblOilSPGR.HyperLink = Nothing
			Me.lblOilSPGR.Left = 0.0625F
			Me.lblOilSPGR.Name = "lblOilSPGR"
			Me.lblOilSPGR.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblOilSPGR.Text = "Oil gravity"
			Me.lblOilSPGR.Top = 1.625F
			Me.lblOilSPGR.Width = 1.125F
			Me.lblFluidSPGR.Height = 0.145F
			Me.lblFluidSPGR.HyperLink = Nothing
			Me.lblFluidSPGR.Left = 0.0625F
			Me.lblFluidSPGR.Name = "lblFluidSPGR"
			Me.lblFluidSPGR.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblFluidSPGR.Text = "Fluid sp.gr."
			Me.lblFluidSPGR.Top = 1.75F
			Me.lblFluidSPGR.Width = 1.125F
			Me.lblCompressibilityIndex.Height = 0.145F
			Me.lblCompressibilityIndex.HyperLink = Nothing
			Me.lblCompressibilityIndex.Left = 0.0625F
			Me.lblCompressibilityIndex.Name = "lblCompressibilityIndex"
			Me.lblCompressibilityIndex.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblCompressibilityIndex.Text = "Compressibility index"
			Me.lblCompressibilityIndex.Top = 1.875F
			Me.lblCompressibilityIndex.Width = 1.125F
			Me.lblPumpingUnitHeader.Height = 0.15F
			Me.lblPumpingUnitHeader.HyperLink = Nothing
			Me.lblPumpingUnitHeader.Left = 0.0625F
			Me.lblPumpingUnitHeader.Name = "lblPumpingUnitHeader"
			Me.lblPumpingUnitHeader.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPumpingUnitHeader.Text = "Pumping unit"
			Me.lblPumpingUnitHeader.Top = 2.25F
			Me.lblPumpingUnitHeader.Width = 3.5625F
			Me.Line6.Height = 0F
			Me.Line6.Left = 0.0625F
			Me.Line6.LineWeight = 1F
			Me.Line6.Name = "Line6"
			Me.Line6.Top = 2.4375F
			Me.Line6.Width = 3.5625F
			Me.Line6.X1 = 0.0625F
			Me.Line6.X2 = 3.625F
			Me.Line6.Y1 = 2.4375F
			Me.Line6.Y2 = 2.4375F
			Me.lblAPIDesignation.Height = 0.145F
			Me.lblAPIDesignation.HyperLink = Nothing
			Me.lblAPIDesignation.Left = 0.0625F
			Me.lblAPIDesignation.Name = "lblAPIDesignation"
			Me.lblAPIDesignation.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblAPIDesignation.Text = "API designation"
			Me.lblAPIDesignation.Top = 2.5F
			Me.lblAPIDesignation.Width = 3.5625F
			Me.lblCrankHole.Height = 0.145F
			Me.lblCrankHole.HyperLink = Nothing
			Me.lblCrankHole.Left = 0.0625F
			Me.lblCrankHole.Name = "lblCrankHole"
			Me.lblCrankHole.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCrankHole.Text = "Crank hole number"
			Me.lblCrankHole.Top = 2.625F
			Me.lblCrankHole.Width = 1.9375F
			Me.lblPUDimR.Height = 0.145F
			Me.lblPUDimR.HyperLink = Nothing
			Me.lblPUDimR.Left = 2.875F
			Me.lblPUDimR.Name = "lblPUDimR"
			Me.lblPUDimR.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPUDimR.Text = "R"
			Me.lblPUDimR.Top = 2.625F
			Me.lblPUDimR.Width = 0.75F
			Me.lblPUDimA.Height = 0.145F
			Me.lblPUDimA.HyperLink = Nothing
			Me.lblPUDimA.Left = 2.875F
			Me.lblPUDimA.Name = "lblPUDimA"
			Me.lblPUDimA.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPUDimA.Text = "A"
			Me.lblPUDimA.Top = 2.75F
			Me.lblPUDimA.Width = 0.75F
			Me.lblPUDimC.Height = 0.145F
			Me.lblPUDimC.HyperLink = Nothing
			Me.lblPUDimC.Left = 2.875F
			Me.lblPUDimC.Name = "lblPUDimC"
			Me.lblPUDimC.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPUDimC.Text = "C"
			Me.lblPUDimC.Top = 2.875F
			Me.lblPUDimC.Width = 0.75F
			Me.lblPUDimI.Height = 0.145F
			Me.lblPUDimI.HyperLink = Nothing
			Me.lblPUDimI.Left = 2.875F
			Me.lblPUDimI.Name = "lblPUDimI"
			Me.lblPUDimI.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPUDimI.Text = "I"
			Me.lblPUDimI.Top = 3F
			Me.lblPUDimI.Width = 0.75F
			Me.lblPUDimK.Height = 0.145F
			Me.lblPUDimK.HyperLink = Nothing
			Me.lblPUDimK.Left = 2.875F
			Me.lblPUDimK.Name = "lblPUDimK"
			Me.lblPUDimK.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPUDimK.Text = "K"
			Me.lblPUDimK.Top = 3.125F
			Me.lblPUDimK.Width = 0.75F
			Me.lblPUDimP.Height = 0.145F
			Me.lblPUDimP.HyperLink = Nothing
			Me.lblPUDimP.Left = 2.875F
			Me.lblPUDimP.Name = "lblPUDimP"
			Me.lblPUDimP.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPUDimP.Text = "P"
			Me.lblPUDimP.Top = 3.25F
			Me.lblPUDimP.Width = 0.75F
			Me.lblPUDimM.Height = 0.145F
			Me.lblPUDimM.HyperLink = Nothing
			Me.lblPUDimM.Left = 2.875F
			Me.lblPUDimM.Name = "lblPUDimM"
			Me.lblPUDimM.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPUDimM.Text = "M"
			Me.lblPUDimM.Top = 3.375F
			Me.lblPUDimM.Width = 0.75F
			Me.lblPUDimV0.Height = 0.145F
			Me.lblPUDimV0.HyperLink = Nothing
			Me.lblPUDimV0.Left = 2.875F
			Me.lblPUDimV0.Name = "lblPUDimV0"
			Me.lblPUDimV0.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPUDimV0.Text = "V0"
			Me.lblPUDimV0.Top = 3.625F
			Me.lblPUDimV0.Width = 0.75F
			Me.lblPUDimS.Height = 0.145F
			Me.lblPUDimS.HyperLink = Nothing
			Me.lblPUDimS.Left = 2.875F
			Me.lblPUDimS.Name = "lblPUDimS"
			Me.lblPUDimS.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPUDimS.Text = "S"
			Me.lblPUDimS.Top = 3.5F
			Me.lblPUDimS.Width = 0.75F
			Me.lblStrokeLength.Height = 0.145F
			Me.lblStrokeLength.HyperLink = Nothing
			Me.lblStrokeLength.Left = 0.0625F
			Me.lblStrokeLength.Name = "lblStrokeLength"
			Me.lblStrokeLength.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblStrokeLength.Text = "Calculated stroke length"
			Me.lblStrokeLength.Top = 2.75F
			Me.lblStrokeLength.Width = 1.9375F
			Me.lblCrankRotation.Height = 0.145F
			Me.lblCrankRotation.HyperLink = Nothing
			Me.lblCrankRotation.Left = 0.0625F
			Me.lblCrankRotation.Name = "lblCrankRotation"
			Me.lblCrankRotation.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCrankRotation.Text = "Crank rotation"
			Me.lblCrankRotation.Top = 2.875F
			Me.lblCrankRotation.Width = 1.9375F
			Me.lblCwtInfo_1.Height = 0.145F
			Me.lblCwtInfo_1.HyperLink = Nothing
			Me.lblCwtInfo_1.Left = 0.0625F
			Me.lblCwtInfo_1.Name = "lblCwtInfo_1"
			Me.lblCwtInfo_1.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCwtInfo_1.Text = "Counterweight info #1"
			Me.lblCwtInfo_1.Top = 3F
			Me.lblCwtInfo_1.Width = 1.9375F
			Me.lblCwtInfo_2.Height = 0.145F
			Me.lblCwtInfo_2.HyperLink = Nothing
			Me.lblCwtInfo_2.Left = 0.0625F
			Me.lblCwtInfo_2.Name = "lblCwtInfo_2"
			Me.lblCwtInfo_2.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCwtInfo_2.Text = "Counterweight info #2"
			Me.lblCwtInfo_2.Top = 3.125F
			Me.lblCwtInfo_2.Width = 1.9375F
			Me.lblCwtInfo_3.Height = 0.145F
			Me.lblCwtInfo_3.HyperLink = Nothing
			Me.lblCwtInfo_3.Left = 0.0625F
			Me.lblCwtInfo_3.Name = "lblCwtInfo_3"
			Me.lblCwtInfo_3.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCwtInfo_3.Text = "Counterweight info #3"
			Me.lblCwtInfo_3.Top = 3.25F
			Me.lblCwtInfo_3.Width = 1.9375F
			Me.lblCwtInfo_4.Height = 0.145F
			Me.lblCwtInfo_4.HyperLink = Nothing
			Me.lblCwtInfo_4.Left = 0.0625F
			Me.lblCwtInfo_4.Name = "lblCwtInfo_4"
			Me.lblCwtInfo_4.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCwtInfo_4.Text = "Counterweight info #4"
			Me.lblCwtInfo_4.Top = 3.375F
			Me.lblCwtInfo_4.Width = 1.9375F
			Me.lblCwtInfo_5.Height = 0.145F
			Me.lblCwtInfo_5.HyperLink = Nothing
			Me.lblCwtInfo_5.Left = 0.0625F
			Me.lblCwtInfo_5.Name = "lblCwtInfo_5"
			Me.lblCwtInfo_5.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCwtInfo_5.Text = "Counterweight info #5"
			Me.lblCwtInfo_5.Top = 3.5F
			Me.lblCwtInfo_5.Width = 1.9375F
			Me.lblCBDataFile.Height = 0.145F
			Me.lblCBDataFile.HyperLink = Nothing
			Me.lblCBDataFile.Left = 0.0625F
			Me.lblCBDataFile.Name = "lblCBDataFile"
			Me.lblCBDataFile.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCBDataFile.Text = "XBAL file"
			Me.lblCBDataFile.Top = 3.625F
			Me.lblCBDataFile.Width = 2.5625F
			Me.lblPumpTubingHeader.Height = 0.15F
			Me.lblPumpTubingHeader.HyperLink = Nothing
			Me.lblPumpTubingHeader.Left = 0.0625F
			Me.lblPumpTubingHeader.Name = "lblPumpTubingHeader"
			Me.lblPumpTubingHeader.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPumpTubingHeader.Text = "Tubing and pump information"
			Me.lblPumpTubingHeader.Top = 3.75F
			Me.lblPumpTubingHeader.Width = 3.5625F
			Me.Line7.Height = 0F
			Me.Line7.Left = 0.0625F
			Me.Line7.LineWeight = 1F
			Me.Line7.Name = "Line7"
			Me.Line7.Top = 3.9375F
			Me.Line7.Width = 3.5625F
			Me.Line7.X1 = 0.0625F
			Me.Line7.X2 = 3.625F
			Me.Line7.Y1 = 3.9375F
			Me.Line7.Y2 = 3.9375F
			Me.lblTubingOD.Height = 0.145F
			Me.lblTubingOD.HyperLink = Nothing
			Me.lblTubingOD.Left = 0.0625F
			Me.lblTubingOD.Name = "lblTubingOD"
			Me.lblTubingOD.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblTubingOD.Text = "Tubing O.D."
			Me.lblTubingOD.Top = 4F
			Me.lblTubingOD.Width = 0.9375F
			Me.lblTubingID.Height = 0.145F
			Me.lblTubingID.HyperLink = Nothing
			Me.lblTubingID.Left = 0.0625F
			Me.lblTubingID.Name = "lblTubingID"
			Me.lblTubingID.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblTubingID.Text = "Tubing I.D."
			Me.lblTubingID.Top = 4.125F
			Me.lblTubingID.Width = 0.9375F
			Me.lblPlungerSize.Height = 0.145F
			Me.lblPlungerSize.HyperLink = Nothing
			Me.lblPlungerSize.Left = 0.0625F
			Me.lblPlungerSize.Name = "lblPlungerSize"
			Me.lblPlungerSize.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPlungerSize.Text = "Plunger size"
			Me.lblPlungerSize.Top = 4.75F
			Me.lblPlungerSize.Width = 0.9375F
			Me.lblRodStringDesign.Height = 0.15F
			Me.lblRodStringDesign.HyperLink = Nothing
			Me.lblRodStringDesign.Left = 0.068F
			Me.lblRodStringDesign.Name = "lblRodStringDesign"
			Me.lblRodStringDesign.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodStringDesign.Text = "Rod string design"
			Me.lblRodStringDesign.Top = 5F
			Me.lblRodStringDesign.Width = 3.5625F
			Me.lblTqMinEner.Height = 0.15F
			Me.lblTqMinEner.HyperLink = Nothing
			Me.lblTqMinEner.Left = 5.6875F
			Me.lblTqMinEner.Name = "lblTqMinEner"
			Me.lblTqMinEner.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblTqMinEner.Text = "(Min Ener)"
			Me.lblTqMinEner.Top = 2.375F
			Me.lblTqMinEner.Width = 0.75F
			Me.lblPeakTorque_BE.Height = 0.145F
			Me.lblPeakTorque_BE.HyperLink = Nothing
			Me.lblPeakTorque_BE.Left = 5.8125F
			Me.lblPeakTorque_BE.Name = "lblPeakTorque_BE"
			Me.lblPeakTorque_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPeakTorque_BE.Text = "Pk torque"
			Me.lblPeakTorque_BE.Top = 2.625F
			Me.lblPeakTorque_BE.Width = 0.625F
			Me.lblGearboxLoading_BE.Height = 0.145F
			Me.lblGearboxLoading_BE.HyperLink = Nothing
			Me.lblGearboxLoading_BE.Left = 5.8125F
			Me.lblGearboxLoading_BE.Name = "lblGearboxLoading_BE"
			Me.lblGearboxLoading_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblGearboxLoading_BE.Text = "Gbx load"
			Me.lblGearboxLoading_BE.Top = 2.75F
			Me.lblGearboxLoading_BE.Width = 0.625F
			Me.lblCLF_BE.Height = 0.145F
			Me.lblCLF_BE.HyperLink = Nothing
			Me.lblCLF_BE.Left = 5.8125F
			Me.lblCLF_BE.Name = "lblCLF_BE"
			Me.lblCLF_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCLF_BE.Text = "CLF"
			Me.lblCLF_BE.Top = 2.875F
			Me.lblCLF_BE.Width = 0.625F
			Me.lblMCM_BE.Height = 0.145F
			Me.lblMCM_BE.HyperLink = Nothing
			Me.lblMCM_BE.Left = 5.8125F
			Me.lblMCM_BE.Name = "lblMCM_BE"
			Me.lblMCM_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblMCM_BE.Text = "MCM"
			Me.lblMCM_BE.Top = 3F
			Me.lblMCM_BE.Width = 0.625F
			Me.lblCBE_BE.Height = 0.145F
			Me.lblCBE_BE.HyperLink = Nothing
			Me.lblCBE_BE.Left = 5.8125F
			Me.lblCBE_BE.Name = "lblCBE_BE"
			Me.lblCBE_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCBE_BE.Text = "CBE"
			Me.lblCBE_BE.Top = 3.125F
			Me.lblCBE_BE.Width = 0.625F
			Me.lblMotorKWH_BE.Height = 0.145F
			Me.lblMotorKWH_BE.HyperLink = Nothing
			Me.lblMotorKWH_BE.Left = 5.8125F
			Me.lblMotorKWH_BE.Name = "lblMotorKWH_BE"
			Me.lblMotorKWH_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblMotorKWH_BE.Text = "Daily elec."
			Me.lblMotorKWH_BE.Top = 3.25F
			Me.lblMotorKWH_BE.Width = 0.625F
			Me.lblElectricBillPerMonth_BE.Height = 0.145F
			Me.lblElectricBillPerMonth_BE.HyperLink = Nothing
			Me.lblElectricBillPerMonth_BE.Left = 5.8125F
			Me.lblElectricBillPerMonth_BE.Name = "lblElectricBillPerMonth_BE"
			Me.lblElectricBillPerMonth_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblElectricBillPerMonth_BE.Text = "Month elec."
			Me.lblElectricBillPerMonth_BE.Top = 3.375F
			Me.lblElectricBillPerMonth_BE.Width = 0.625F
			Me.lblDollarsPerBblFluid_BE.Height = 0.145F
			Me.lblDollarsPerBblFluid_BE.HyperLink = Nothing
			Me.lblDollarsPerBblFluid_BE.Left = 5.8125F
			Me.lblDollarsPerBblFluid_BE.Name = "lblDollarsPerBblFluid_BE"
			Me.lblDollarsPerBblFluid_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblFluid_BE.Text = "$/bbl fluid"
			Me.lblDollarsPerBblFluid_BE.Top = 3.5F
			Me.lblDollarsPerBblFluid_BE.Width = 0.625F
			Me.lblDollarsPerBblOil_BE.Height = 0.145F
			Me.lblDollarsPerBblOil_BE.HyperLink = Nothing
			Me.lblDollarsPerBblOil_BE.Left = 5.8125F
			Me.lblDollarsPerBblOil_BE.Name = "lblDollarsPerBblOil_BE"
			Me.lblDollarsPerBblOil_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblOil_BE.Text = "$/bbl oil"
			Me.lblDollarsPerBblOil_BE.Top = 3.625F
			Me.lblDollarsPerBblOil_BE.Width = 0.625F
			Me.lblTqMinTorq.Height = 0.15F
			Me.lblTqMinTorq.HyperLink = Nothing
			Me.lblTqMinTorq.Left = 6.4375F
			Me.lblTqMinTorq.Name = "lblTqMinTorq"
			Me.lblTqMinTorq.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblTqMinTorq.Text = "(Min Torq)"
			Me.lblTqMinTorq.Top = 2.375F
			Me.lblTqMinTorq.Width = 0.75F
			Me.lblPeakTorque_BT.Height = 0.145F
			Me.lblPeakTorque_BT.HyperLink = Nothing
			Me.lblPeakTorque_BT.Left = 6.5625F
			Me.lblPeakTorque_BT.Name = "lblPeakTorque_BT"
			Me.lblPeakTorque_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPeakTorque_BT.Text = "Pk torque"
			Me.lblPeakTorque_BT.Top = 2.625F
			Me.lblPeakTorque_BT.Width = 0.625F
			Me.lblGearboxLoading_BT.Height = 0.145F
			Me.lblGearboxLoading_BT.HyperLink = Nothing
			Me.lblGearboxLoading_BT.Left = 6.5625F
			Me.lblGearboxLoading_BT.Name = "lblGearboxLoading_BT"
			Me.lblGearboxLoading_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblGearboxLoading_BT.Text = "Gbx load"
			Me.lblGearboxLoading_BT.Top = 2.75F
			Me.lblGearboxLoading_BT.Width = 0.625F
			Me.lblCLF_BT.Height = 0.145F
			Me.lblCLF_BT.HyperLink = Nothing
			Me.lblCLF_BT.Left = 6.5625F
			Me.lblCLF_BT.Name = "lblCLF_BT"
			Me.lblCLF_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCLF_BT.Text = "CLF"
			Me.lblCLF_BT.Top = 2.875F
			Me.lblCLF_BT.Width = 0.625F
			Me.lblMCM_BT.Height = 0.145F
			Me.lblMCM_BT.HyperLink = Nothing
			Me.lblMCM_BT.Left = 6.5625F
			Me.lblMCM_BT.Name = "lblMCM_BT"
			Me.lblMCM_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblMCM_BT.Text = "MCM"
			Me.lblMCM_BT.Top = 3F
			Me.lblMCM_BT.Width = 0.625F
			Me.lblCBE_BT.Height = 0.145F
			Me.lblCBE_BT.HyperLink = Nothing
			Me.lblCBE_BT.Left = 6.5625F
			Me.lblCBE_BT.Name = "lblCBE_BT"
			Me.lblCBE_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCBE_BT.Text = "CBE"
			Me.lblCBE_BT.Top = 3.125F
			Me.lblCBE_BT.Width = 0.625F
			Me.lblMotorKWH_BT.Height = 0.145F
			Me.lblMotorKWH_BT.HyperLink = Nothing
			Me.lblMotorKWH_BT.Left = 6.5625F
			Me.lblMotorKWH_BT.Name = "lblMotorKWH_BT"
			Me.lblMotorKWH_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblMotorKWH_BT.Text = "Daily elec."
			Me.lblMotorKWH_BT.Top = 3.25F
			Me.lblMotorKWH_BT.Width = 0.625F
			Me.lblElectricBillPerMonth_BT.Height = 0.145F
			Me.lblElectricBillPerMonth_BT.HyperLink = Nothing
			Me.lblElectricBillPerMonth_BT.Left = 6.5625F
			Me.lblElectricBillPerMonth_BT.Name = "lblElectricBillPerMonth_BT"
			Me.lblElectricBillPerMonth_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblElectricBillPerMonth_BT.Text = "Month elec."
			Me.lblElectricBillPerMonth_BT.Top = 3.375F
			Me.lblElectricBillPerMonth_BT.Width = 0.625F
			Me.lblDollarsPerBblFluid_BT.Height = 0.145F
			Me.lblDollarsPerBblFluid_BT.HyperLink = Nothing
			Me.lblDollarsPerBblFluid_BT.Left = 6.5625F
			Me.lblDollarsPerBblFluid_BT.Name = "lblDollarsPerBblFluid_BT"
			Me.lblDollarsPerBblFluid_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblFluid_BT.Text = "$/bbl fluid"
			Me.lblDollarsPerBblFluid_BT.Top = 3.5F
			Me.lblDollarsPerBblFluid_BT.Width = 0.625F
			Me.lblDollarsPerBblOil_BT.Height = 0.145F
			Me.lblDollarsPerBblOil_BT.HyperLink = Nothing
			Me.lblDollarsPerBblOil_BT.Left = 6.5625F
			Me.lblDollarsPerBblOil_BT.Name = "lblDollarsPerBblOil_BT"
			Me.lblDollarsPerBblOil_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblOil_BT.Text = "$/bbl oil"
			Me.lblDollarsPerBblOil_BT.Top = 3.625F
			Me.lblDollarsPerBblOil_BT.Width = 0.625F
			Me.lblTqExisting.Height = 0.125F
			Me.lblTqExisting.HyperLink = Nothing
			Me.lblTqExisting.Left = 7.1875F
			Me.lblTqExisting.Name = "lblTqExisting"
			Me.lblTqExisting.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblTqExisting.Text = "EXISTING"
			Me.lblTqExisting.Top = 2.25F
			Me.lblTqExisting.Width = 0.75F
			Me.lblPeakTorque_E.Height = 0.145F
			Me.lblPeakTorque_E.HyperLink = Nothing
			Me.lblPeakTorque_E.Left = 7.3125F
			Me.lblPeakTorque_E.Name = "lblPeakTorque_E"
			Me.lblPeakTorque_E.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPeakTorque_E.Text = "Pk torque"
			Me.lblPeakTorque_E.Top = 2.625F
			Me.lblPeakTorque_E.Width = 0.625F
			Me.lblGearboxLoading_E.Height = 0.145F
			Me.lblGearboxLoading_E.HyperLink = Nothing
			Me.lblGearboxLoading_E.Left = 7.3125F
			Me.lblGearboxLoading_E.Name = "lblGearboxLoading_E"
			Me.lblGearboxLoading_E.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblGearboxLoading_E.Text = "Gbx load"
			Me.lblGearboxLoading_E.Top = 2.75F
			Me.lblGearboxLoading_E.Width = 0.625F
			Me.lblCLF_E.Height = 0.145F
			Me.lblCLF_E.HyperLink = Nothing
			Me.lblCLF_E.Left = 7.3125F
			Me.lblCLF_E.Name = "lblCLF_E"
			Me.lblCLF_E.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCLF_E.Text = "CLF"
			Me.lblCLF_E.Top = 2.875F
			Me.lblCLF_E.Width = 0.625F
			Me.lblMCM_E.Height = 0.145F
			Me.lblMCM_E.HyperLink = Nothing
			Me.lblMCM_E.Left = 7.3125F
			Me.lblMCM_E.Name = "lblMCM_E"
			Me.lblMCM_E.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblMCM_E.Text = "MCM"
			Me.lblMCM_E.Top = 3F
			Me.lblMCM_E.Width = 0.625F
			Me.lblCBE_E.Height = 0.145F
			Me.lblCBE_E.HyperLink = Nothing
			Me.lblCBE_E.Left = 7.3125F
			Me.lblCBE_E.Name = "lblCBE_E"
			Me.lblCBE_E.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCBE_E.Text = "CBE"
			Me.lblCBE_E.Top = 3.125F
			Me.lblCBE_E.Width = 0.625F
			Me.lblMotorKWH_E.Height = 0.145F
			Me.lblMotorKWH_E.HyperLink = Nothing
			Me.lblMotorKWH_E.Left = 7.3125F
			Me.lblMotorKWH_E.Name = "lblMotorKWH_E"
			Me.lblMotorKWH_E.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblMotorKWH_E.Text = "Daily elec."
			Me.lblMotorKWH_E.Top = 3.25F
			Me.lblMotorKWH_E.Width = 0.625F
			Me.lblElectricBillPerMonth_E.Height = 0.145F
			Me.lblElectricBillPerMonth_E.HyperLink = Nothing
			Me.lblElectricBillPerMonth_E.Left = 7.3125F
			Me.lblElectricBillPerMonth_E.Name = "lblElectricBillPerMonth_E"
			Me.lblElectricBillPerMonth_E.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblElectricBillPerMonth_E.Text = "Month elec."
			Me.lblElectricBillPerMonth_E.Top = 3.375F
			Me.lblElectricBillPerMonth_E.Width = 0.625F
			Me.lblDollarsPerBblFluid_E.Height = 0.145F
			Me.lblDollarsPerBblFluid_E.HyperLink = Nothing
			Me.lblDollarsPerBblFluid_E.Left = 7.3125F
			Me.lblDollarsPerBblFluid_E.Name = "lblDollarsPerBblFluid_E"
			Me.lblDollarsPerBblFluid_E.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblFluid_E.Text = "$/bbl fluid"
			Me.lblDollarsPerBblFluid_E.Top = 3.5F
			Me.lblDollarsPerBblFluid_E.Width = 0.625F
			Me.lblDollarsPerBblOil_E.Height = 0.145F
			Me.lblDollarsPerBblOil_E.HyperLink = Nothing
			Me.lblDollarsPerBblOil_E.Left = 7.3125F
			Me.lblDollarsPerBblOil_E.Name = "lblDollarsPerBblOil_E"
			Me.lblDollarsPerBblOil_E.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblOil_E.Text = "$/bbl oil"
			Me.lblDollarsPerBblOil_E.Top = 3.625F
			Me.lblDollarsPerBblOil_E.Width = 0.625F
			Me.Line8.Height = 0F
			Me.Line8.Left = 3.756944F
			Me.Line8.LineWeight = 1F
			Me.Line8.Name = "Line8"
			Me.Line8.Top = 1.775F
			Me.Line8.Width = 4.15F
			Me.Line8.X1 = 3.756944F
			Me.Line8.X2 = 7.906944F
			Me.Line8.Y1 = 1.775F
			Me.Line8.Y2 = 1.775F
			Me.lblPmMinEner.Height = 0.125F
			Me.lblPmMinEner.HyperLink = Nothing
			Me.lblPmMinEner.Left = 5.6875F
			Me.lblPmMinEner.Name = "lblPmMinEner"
			Me.lblPmMinEner.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblPmMinEner.Text = "(Min Ener)"
			Me.lblPmMinEner.Top = 1.6F
			Me.lblPmMinEner.Width = 0.75F
			Me.lblNEMAD_BE.Height = 0.145F
			Me.lblNEMAD_BE.HyperLink = Nothing
			Me.lblNEMAD_BE.Left = 5.6875F
			Me.lblNEMAD_BE.Name = "lblNEMAD_BE"
			Me.lblNEMAD_BE.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblNEMAD_BE.Text = "NEMA D"
			Me.lblNEMAD_BE.Top = 1.8F
			Me.lblNEMAD_BE.Width = 0.75F
			Me.lblSingleCyl_BE.Height = 0.145F
			Me.lblSingleCyl_BE.HyperLink = Nothing
			Me.lblSingleCyl_BE.Left = 5.6875F
			Me.lblSingleCyl_BE.Name = "lblSingleCyl_BE"
			Me.lblSingleCyl_BE.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblSingleCyl_BE.Text = "Single cyl."
			Me.lblSingleCyl_BE.Top = 1.925F
			Me.lblSingleCyl_BE.Width = 0.75F
			Me.lblMultiCyl_BE.Height = 0.145F
			Me.lblMultiCyl_BE.HyperLink = Nothing
			Me.lblMultiCyl_BE.Left = 5.6875F
			Me.lblMultiCyl_BE.Name = "lblMultiCyl_BE"
			Me.lblMultiCyl_BE.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblMultiCyl_BE.Text = "Multicyl."
			Me.lblMultiCyl_BE.Top = 2.05F
			Me.lblMultiCyl_BE.Width = 0.75F
			Me.lblPmMinTorq.Height = 0.15F
			Me.lblPmMinTorq.HyperLink = Nothing
			Me.lblPmMinTorq.Left = 6.4375F
			Me.lblPmMinTorq.Name = "lblPmMinTorq"
			Me.lblPmMinTorq.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblPmMinTorq.Text = "(Min Torq)"
			Me.lblPmMinTorq.Top = 1.6F
			Me.lblPmMinTorq.Width = 0.75F
			Me.lblNEMAD_BT.Height = 0.145F
			Me.lblNEMAD_BT.HyperLink = Nothing
			Me.lblNEMAD_BT.Left = 6.4375F
			Me.lblNEMAD_BT.Name = "lblNEMAD_BT"
			Me.lblNEMAD_BT.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblNEMAD_BT.Text = "NEMA D"
			Me.lblNEMAD_BT.Top = 1.8F
			Me.lblNEMAD_BT.Width = 0.75F
			Me.lblSingleCyl_BT.Height = 0.145F
			Me.lblSingleCyl_BT.HyperLink = Nothing
			Me.lblSingleCyl_BT.Left = 6.4375F
			Me.lblSingleCyl_BT.Name = "lblSingleCyl_BT"
			Me.lblSingleCyl_BT.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblSingleCyl_BT.Text = "Single cyl."
			Me.lblSingleCyl_BT.Top = 1.925F
			Me.lblSingleCyl_BT.Width = 0.75F
			Me.lblMultiCyl_BT.Height = 0.145F
			Me.lblMultiCyl_BT.HyperLink = Nothing
			Me.lblMultiCyl_BT.Left = 6.4375F
			Me.lblMultiCyl_BT.Name = "lblMultiCyl_BT"
			Me.lblMultiCyl_BT.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblMultiCyl_BT.Text = "Multicyl."
			Me.lblMultiCyl_BT.Top = 2.05F
			Me.lblMultiCyl_BT.Width = 0.75F
			Me.lblPmExisting.Height = 0.125F
			Me.lblPmExisting.HyperLink = Nothing
			Me.lblPmExisting.Left = 7.1875F
			Me.lblPmExisting.Name = "lblPmExisting"
			Me.lblPmExisting.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblPmExisting.Text = "EXISTING"
			Me.lblPmExisting.Top = 1.475F
			Me.lblPmExisting.Width = 0.75F
			Me.lblNEMAD_E.Height = 0.145F
			Me.lblNEMAD_E.HyperLink = Nothing
			Me.lblNEMAD_E.Left = 7.1875F
			Me.lblNEMAD_E.Name = "lblNEMAD_E"
			Me.lblNEMAD_E.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblNEMAD_E.Text = "NEMA D"
			Me.lblNEMAD_E.Top = 1.8F
			Me.lblNEMAD_E.Width = 0.75F
			Me.lblSingleCyl_E.Height = 0.145F
			Me.lblSingleCyl_E.HyperLink = Nothing
			Me.lblSingleCyl_E.Left = 7.1875F
			Me.lblSingleCyl_E.Name = "lblSingleCyl_E"
			Me.lblSingleCyl_E.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblSingleCyl_E.Text = "Single cyl."
			Me.lblSingleCyl_E.Top = 1.925F
			Me.lblSingleCyl_E.Width = 0.75F
			Me.lblMultiCyl_E.Height = 0.145F
			Me.lblMultiCyl_E.HyperLink = Nothing
			Me.lblMultiCyl_E.Left = 7.1875F
			Me.lblMultiCyl_E.Name = "lblMultiCyl_E"
			Me.lblMultiCyl_E.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblMultiCyl_E.Text = "Multicyl."
			Me.lblMultiCyl_E.Top = 2.05F
			Me.lblMultiCyl_E.Width = 0.75F
			Me.lblMultiCyl.Height = 0.1875F
			Me.lblMultiCyl.HyperLink = Nothing
			Me.lblMultiCyl.Left = 3.75F
			Me.lblMultiCyl.Name = "lblMultiCyl"
			Me.lblMultiCyl.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMultiCyl.Text = "Multicylinder engine:"
			Me.lblMultiCyl.Top = 2.05F
			Me.lblMultiCyl.Width = 1.875F
			Me.lblElectricityConsumption.Height = 0.15F
			Me.lblElectricityConsumption.HyperLink = Nothing
			Me.lblElectricityConsumption.Left = 3.75F
			Me.lblElectricityConsumption.Name = "lblElectricityConsumption"
			Me.lblElectricityConsumption.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblElectricityConsumption.Text = "  electricity consumption"
			Me.lblElectricityConsumption.Top = 2.375F
			Me.lblElectricityConsumption.Width = 1.875F
			Me.Line9.Height = 0F
			Me.Line9.Left = 3.75F
			Me.Line9.LineWeight = 1F
			Me.Line9.Name = "Line9"
			Me.Line9.Top = 2.5625F
			Me.Line9.Width = 4.15F
			Me.Line9.X1 = 3.75F
			Me.Line9.X2 = 7.9F
			Me.Line9.Y1 = 2.5625F
			Me.Line9.Y2 = 2.5625F
			Me.lblTubingCalculations.Height = 0.15F
			Me.lblTubingCalculations.HyperLink = Nothing
			Me.lblTubingCalculations.Left = 3.75F
			Me.lblTubingCalculations.Name = "lblTubingCalculations"
			Me.lblTubingCalculations.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblTubingCalculations.Text = "Tubing, pump and plunger calculations"
			Me.lblTubingCalculations.Top = 3.875F
			Me.lblTubingCalculations.Width = 4.1875F
			Me.Line10.Height = 0F
			Me.Line10.Left = 3.75F
			Me.Line10.LineWeight = 1F
			Me.Line10.Name = "Line10"
			Me.Line10.Top = 4.0625F
			Me.Line10.Width = 4.1875F
			Me.Line10.X1 = 3.75F
			Me.Line10.X2 = 7.9375F
			Me.Line10.Y1 = 4.0625F
			Me.Line10.Y2 = 4.0625F
			Me.Line11.Height = 0F
			Me.Line11.Left = 0.0625F
			Me.Line11.LineWeight = 1F
			Me.Line11.Name = "Line11"
			Me.Line11.Top = 5.1875F
			Me.Line11.Width = 3.5625F
			Me.Line11.X1 = 0.0625F
			Me.Line11.X2 = 3.625F
			Me.Line11.Y1 = 5.1875F
			Me.Line11.Y2 = 5.1875F
			Me.lblRodDiamHdrTop.Height = 0.145F
			Me.lblRodDiamHdrTop.HyperLink = Nothing
			Me.lblRodDiamHdrTop.Left = 0.0625F
			Me.lblRodDiamHdrTop.Name = "lblRodDiamHdrTop"
			Me.lblRodDiamHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiamHdrTop.Text = "Diameter"
			Me.lblRodDiamHdrTop.Top = 5.25F
			Me.lblRodDiamHdrTop.Width = 0.625F
			Me.lblRodDiamHdrBot.Height = 0.145F
			Me.lblRodDiamHdrBot.HyperLink = Nothing
			Me.lblRodDiamHdrBot.Left = 0.0625F
			Me.lblRodDiamHdrBot.Name = "lblRodDiamHdrBot"
			Me.lblRodDiamHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiamHdrBot.Text = "(inches)"
			Me.lblRodDiamHdrBot.Top = 5.375F
			Me.lblRodDiamHdrBot.Width = 0.625F
			Me.lblRodDiam1.Height = 0.125F
			Me.lblRodDiam1.HyperLink = Nothing
			Me.lblRodDiam1.Left = 0.0625F
			Me.lblRodDiam1.Name = "lblRodDiam1"
			Me.lblRodDiam1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam1.Text = "Diam"
			Me.lblRodDiam1.Top = 5.625F
			Me.lblRodDiam1.Width = 0.625F
			Me.lblRodGradeHdrBot.Height = 0.145F
			Me.lblRodGradeHdrBot.HyperLink = Nothing
			Me.lblRodGradeHdrBot.Left = 0.8125F
			Me.lblRodGradeHdrBot.Name = "lblRodGradeHdrBot"
			Me.lblRodGradeHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGradeHdrBot.Text = "Grade"
			Me.lblRodGradeHdrBot.Top = 5.375F
			Me.lblRodGradeHdrBot.Width = 0.9375F
			Me.lblRodLengthHdrBot.Height = 0.145F
			Me.lblRodLengthHdrBot.HyperLink = Nothing
			Me.lblRodLengthHdrBot.Left = 1.875F
			Me.lblRodLengthHdrBot.Name = "lblRodLengthHdrBot"
			Me.lblRodLengthHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodLengthHdrBot.Text = "(ft)"
			Me.lblRodLengthHdrBot.Top = 5.375F
			Me.lblRodLengthHdrBot.Width = 0.4375F
			Me.lblRodTensileStrengthHdrBot.Height = 0.145F
			Me.lblRodTensileStrengthHdrBot.HyperLink = Nothing
			Me.lblRodTensileStrengthHdrBot.Left = 2.4375F
			Me.lblRodTensileStrengthHdrBot.Name = "lblRodTensileStrengthHdrBot"
			Me.lblRodTensileStrengthHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrengthHdrBot.Text = "Strength (psi)"
			Me.lblRodTensileStrengthHdrBot.Top = 5.375F
			Me.lblRodTensileStrengthHdrBot.Width = 0.75F
			Me.Line12.Height = 0F
			Me.Line12.Left = 0.0625F
			Me.Line12.LineWeight = 1F
			Me.Line12.Name = "Line12"
			Me.Line12.Top = 5.5625F
			Me.Line12.Width = 3.5625F
			Me.Line12.X1 = 0.0625F
			Me.Line12.X2 = 3.625F
			Me.Line12.Y1 = 5.5625F
			Me.Line12.Y2 = 5.5625F
			Me.lblRodDiam2.Height = 0.125F
			Me.lblRodDiam2.HyperLink = Nothing
			Me.lblRodDiam2.Left = 0.0625F
			Me.lblRodDiam2.Name = "lblRodDiam2"
			Me.lblRodDiam2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam2.Text = "Diam"
			Me.lblRodDiam2.Top = 5.75F
			Me.lblRodDiam2.Width = 0.625F
			Me.lblRodDiam3.Height = 0.125F
			Me.lblRodDiam3.HyperLink = Nothing
			Me.lblRodDiam3.Left = 0.0625F
			Me.lblRodDiam3.Name = "lblRodDiam3"
			Me.lblRodDiam3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam3.Text = "Diam"
			Me.lblRodDiam3.Top = 5.875F
			Me.lblRodDiam3.Width = 0.625F
			Me.lblRodDiam4.Height = 0.125F
			Me.lblRodDiam4.HyperLink = Nothing
			Me.lblRodDiam4.Left = 0.0625F
			Me.lblRodDiam4.Name = "lblRodDiam4"
			Me.lblRodDiam4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam4.Text = "Diam"
			Me.lblRodDiam4.Top = 6F
			Me.lblRodDiam4.Width = 0.625F
			Me.lblRodDiam5.Height = 0.125F
			Me.lblRodDiam5.HyperLink = Nothing
			Me.lblRodDiam5.Left = 0.0625F
			Me.lblRodDiam5.Name = "lblRodDiam5"
			Me.lblRodDiam5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam5.Text = "Diam"
			Me.lblRodDiam5.Top = 6.125F
			Me.lblRodDiam5.Width = 0.625F
			Me.lblRodDiam6.Height = 0.125F
			Me.lblRodDiam6.HyperLink = Nothing
			Me.lblRodDiam6.Left = 0.0625F
			Me.lblRodDiam6.Name = "lblRodDiam6"
			Me.lblRodDiam6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam6.Text = "Diam"
			Me.lblRodDiam6.Top = 6.25F
			Me.lblRodDiam6.Width = 0.625F
			Me.lblRodDiam7.Height = 0.125F
			Me.lblRodDiam7.HyperLink = Nothing
			Me.lblRodDiam7.Left = 0.0625F
			Me.lblRodDiam7.Name = "lblRodDiam7"
			Me.lblRodDiam7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam7.Text = "Diam"
			Me.lblRodDiam7.Top = 6.375F
			Me.lblRodDiam7.Width = 0.625F
			Me.lblRodDiam8.Height = 0.125F
			Me.lblRodDiam8.HyperLink = Nothing
			Me.lblRodDiam8.Left = 0.0625F
			Me.lblRodDiam8.Name = "lblRodDiam8"
			Me.lblRodDiam8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam8.Text = "Diam"
			Me.lblRodDiam8.Top = 6.5F
			Me.lblRodDiam8.Width = 0.625F
			Me.lblRodGrade1.Height = 0.125F
			Me.lblRodGrade1.HyperLink = Nothing
			Me.lblRodGrade1.Left = 0.8125F
			Me.lblRodGrade1.Name = "lblRodGrade1"
			Me.lblRodGrade1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade1.Text = "Grade"
			Me.lblRodGrade1.Top = 5.625F
			Me.lblRodGrade1.Width = 0.98F
			Me.lblRodGrade2.Height = 0.125F
			Me.lblRodGrade2.HyperLink = Nothing
			Me.lblRodGrade2.Left = 0.8125F
			Me.lblRodGrade2.Name = "lblRodGrade2"
			Me.lblRodGrade2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade2.Text = "Grade"
			Me.lblRodGrade2.Top = 5.75F
			Me.lblRodGrade2.Width = 0.98F
			Me.lblRodGrade3.Height = 0.125F
			Me.lblRodGrade3.HyperLink = Nothing
			Me.lblRodGrade3.Left = 0.8125F
			Me.lblRodGrade3.Name = "lblRodGrade3"
			Me.lblRodGrade3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade3.Text = "Grade"
			Me.lblRodGrade3.Top = 5.875F
			Me.lblRodGrade3.Width = 0.98F
			Me.lblRodGrade4.Height = 0.125F
			Me.lblRodGrade4.HyperLink = Nothing
			Me.lblRodGrade4.Left = 0.8125F
			Me.lblRodGrade4.Name = "lblRodGrade4"
			Me.lblRodGrade4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade4.Text = "Grade"
			Me.lblRodGrade4.Top = 6F
			Me.lblRodGrade4.Width = 0.98F
			Me.lblRodGrade5.Height = 0.125F
			Me.lblRodGrade5.HyperLink = Nothing
			Me.lblRodGrade5.Left = 0.8125F
			Me.lblRodGrade5.Name = "lblRodGrade5"
			Me.lblRodGrade5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade5.Text = "Grade"
			Me.lblRodGrade5.Top = 6.125F
			Me.lblRodGrade5.Width = 0.98F
			Me.lblRodGrade6.Height = 0.125F
			Me.lblRodGrade6.HyperLink = Nothing
			Me.lblRodGrade6.Left = 0.8125F
			Me.lblRodGrade6.Name = "lblRodGrade6"
			Me.lblRodGrade6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade6.Text = "Grade"
			Me.lblRodGrade6.Top = 6.25F
			Me.lblRodGrade6.Width = 0.98F
			Me.lblRodGrade7.Height = 0.125F
			Me.lblRodGrade7.HyperLink = Nothing
			Me.lblRodGrade7.Left = 0.8125F
			Me.lblRodGrade7.Name = "lblRodGrade7"
			Me.lblRodGrade7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade7.Text = "Grade"
			Me.lblRodGrade7.Top = 6.375F
			Me.lblRodGrade7.Width = 0.98F
			Me.lblRodGrade8.Height = 0.125F
			Me.lblRodGrade8.HyperLink = Nothing
			Me.lblRodGrade8.Left = 0.8125F
			Me.lblRodGrade8.Name = "lblRodGrade8"
			Me.lblRodGrade8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade8.Text = "Grade"
			Me.lblRodGrade8.Top = 6.5F
			Me.lblRodGrade8.Width = 0.98F
			Me.lblRodLength1.Height = 0.125F
			Me.lblRodLength1.HyperLink = Nothing
			Me.lblRodLength1.Left = 1.875F
			Me.lblRodLength1.Name = "lblRodLength1"
			Me.lblRodLength1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength1.Text = "Len"
			Me.lblRodLength1.Top = 5.625F
			Me.lblRodLength1.Width = 0.4375F
			Me.lblRodLength2.Height = 0.125F
			Me.lblRodLength2.HyperLink = Nothing
			Me.lblRodLength2.Left = 1.875F
			Me.lblRodLength2.Name = "lblRodLength2"
			Me.lblRodLength2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength2.Text = "Len"
			Me.lblRodLength2.Top = 5.75F
			Me.lblRodLength2.Width = 0.4375F
			Me.lblRodLength3.Height = 0.125F
			Me.lblRodLength3.HyperLink = Nothing
			Me.lblRodLength3.Left = 1.875F
			Me.lblRodLength3.Name = "lblRodLength3"
			Me.lblRodLength3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength3.Text = "Len"
			Me.lblRodLength3.Top = 5.875F
			Me.lblRodLength3.Width = 0.4375F
			Me.lblRodLength4.Height = 0.125F
			Me.lblRodLength4.HyperLink = Nothing
			Me.lblRodLength4.Left = 1.875F
			Me.lblRodLength4.Name = "lblRodLength4"
			Me.lblRodLength4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength4.Text = "Len"
			Me.lblRodLength4.Top = 6F
			Me.lblRodLength4.Width = 0.4375F
			Me.lblRodLength5.Height = 0.125F
			Me.lblRodLength5.HyperLink = Nothing
			Me.lblRodLength5.Left = 1.875F
			Me.lblRodLength5.Name = "lblRodLength5"
			Me.lblRodLength5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength5.Text = "Len"
			Me.lblRodLength5.Top = 6.125F
			Me.lblRodLength5.Width = 0.4375F
			Me.lblRodLength6.Height = 0.125F
			Me.lblRodLength6.HyperLink = Nothing
			Me.lblRodLength6.Left = 1.875F
			Me.lblRodLength6.Name = "lblRodLength6"
			Me.lblRodLength6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength6.Text = "Len"
			Me.lblRodLength6.Top = 6.25F
			Me.lblRodLength6.Width = 0.4375F
			Me.lblRodLength7.Height = 0.125F
			Me.lblRodLength7.HyperLink = Nothing
			Me.lblRodLength7.Left = 1.875F
			Me.lblRodLength7.Name = "lblRodLength7"
			Me.lblRodLength7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength7.Text = "Len"
			Me.lblRodLength7.Top = 6.375F
			Me.lblRodLength7.Width = 0.4375F
			Me.lblRodLength8.Height = 0.125F
			Me.lblRodLength8.HyperLink = Nothing
			Me.lblRodLength8.Left = 1.875F
			Me.lblRodLength8.Name = "lblRodLength8"
			Me.lblRodLength8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength8.Text = "Len"
			Me.lblRodLength8.Top = 6.5F
			Me.lblRodLength8.Width = 0.4375F
			Me.lblRodTensileStrength1.Height = 0.125F
			Me.lblRodTensileStrength1.HyperLink = Nothing
			Me.lblRodTensileStrength1.Left = 2.4375F
			Me.lblRodTensileStrength1.Name = "lblRodTensileStrength1"
			Me.lblRodTensileStrength1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength1.Text = "TS"
			Me.lblRodTensileStrength1.Top = 5.625F
			Me.lblRodTensileStrength1.Width = 0.75F
			Me.lblRodTensileStrength2.Height = 0.125F
			Me.lblRodTensileStrength2.HyperLink = Nothing
			Me.lblRodTensileStrength2.Left = 2.4375F
			Me.lblRodTensileStrength2.Name = "lblRodTensileStrength2"
			Me.lblRodTensileStrength2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength2.Text = "TS"
			Me.lblRodTensileStrength2.Top = 5.75F
			Me.lblRodTensileStrength2.Width = 0.75F
			Me.lblRodTensileStrength3.Height = 0.125F
			Me.lblRodTensileStrength3.HyperLink = Nothing
			Me.lblRodTensileStrength3.Left = 2.4375F
			Me.lblRodTensileStrength3.Name = "lblRodTensileStrength3"
			Me.lblRodTensileStrength3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength3.Text = "TS"
			Me.lblRodTensileStrength3.Top = 5.875F
			Me.lblRodTensileStrength3.Width = 0.75F
			Me.lblRodTensileStrength4.Height = 0.125F
			Me.lblRodTensileStrength4.HyperLink = Nothing
			Me.lblRodTensileStrength4.Left = 2.4375F
			Me.lblRodTensileStrength4.Name = "lblRodTensileStrength4"
			Me.lblRodTensileStrength4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength4.Text = "TS"
			Me.lblRodTensileStrength4.Top = 6F
			Me.lblRodTensileStrength4.Width = 0.75F
			Me.lblRodTensileStrength5.Height = 0.125F
			Me.lblRodTensileStrength5.HyperLink = Nothing
			Me.lblRodTensileStrength5.Left = 2.4375F
			Me.lblRodTensileStrength5.Name = "lblRodTensileStrength5"
			Me.lblRodTensileStrength5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength5.Text = "TS"
			Me.lblRodTensileStrength5.Top = 6.125F
			Me.lblRodTensileStrength5.Width = 0.75F
			Me.lblRodTensileStrength6.Height = 0.125F
			Me.lblRodTensileStrength6.HyperLink = Nothing
			Me.lblRodTensileStrength6.Left = 2.4375F
			Me.lblRodTensileStrength6.Name = "lblRodTensileStrength6"
			Me.lblRodTensileStrength6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength6.Text = "TS"
			Me.lblRodTensileStrength6.Top = 6.25F
			Me.lblRodTensileStrength6.Width = 0.75F
			Me.lblRodTensileStrength7.Height = 0.125F
			Me.lblRodTensileStrength7.HyperLink = Nothing
			Me.lblRodTensileStrength7.Left = 2.4375F
			Me.lblRodTensileStrength7.Name = "lblRodTensileStrength7"
			Me.lblRodTensileStrength7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength7.Text = "TS"
			Me.lblRodTensileStrength7.Top = 6.375F
			Me.lblRodTensileStrength7.Width = 0.75F
			Me.lblRodTensileStrength8.Height = 0.125F
			Me.lblRodTensileStrength8.HyperLink = Nothing
			Me.lblRodTensileStrength8.Left = 2.4375F
			Me.lblRodTensileStrength8.Name = "lblRodTensileStrength8"
			Me.lblRodTensileStrength8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength8.Text = "TS"
			Me.lblRodTensileStrength8.Top = 6.5F
			Me.lblRodTensileStrength8.Width = 0.75F
			Me.lblRodStringResults.Height = 0.15F
			Me.lblRodStringResults.HyperLink = Nothing
			Me.lblRodStringResults.Left = 3.75F
			Me.lblRodStringResults.Name = "lblRodStringResults"
			Me.lblRodStringResults.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodStringResults.Text = "Rod string design"
			Me.lblRodStringResults.Top = 5F
			Me.lblRodStringResults.Width = 4.125F
			Me.Line13.Height = 0F
			Me.Line13.Left = 3.75F
			Me.Line13.LineWeight = 1F
			Me.Line13.Name = "Line13"
			Me.Line13.Top = 5.1875F
			Me.Line13.Width = 4.125F
			Me.Line13.X1 = 3.75F
			Me.Line13.X2 = 7.875F
			Me.Line13.Y1 = 5.1875F
			Me.Line13.Y2 = 5.1875F
			Me.lblRodStressHdrBot.Height = 0.145F
			Me.lblRodStressHdrBot.HyperLink = Nothing
			Me.lblRodStressHdrBot.Left = 3.75F
			Me.lblRodStressHdrBot.Name = "lblRodStressHdrBot"
			Me.lblRodStressHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressHdrBot.Text = " Load %"
			Me.lblRodStressHdrBot.Top = 5.375F
			Me.lblRodStressHdrBot.Width = 0.5F
			Me.lblRodStress1.Height = 0.125F
			Me.lblRodStress1.HyperLink = Nothing
			Me.lblRodStress1.Left = 3.75F
			Me.lblRodStress1.Name = "lblRodStress1"
			Me.lblRodStress1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress1.Text = "Stress"
			Me.lblRodStress1.Top = 5.625F
			Me.lblRodStress1.Width = 0.5F
			Me.lblRodTopMaxStressHdrBot.Height = 0.145F
			Me.lblRodTopMaxStressHdrBot.HyperLink = Nothing
			Me.lblRodTopMaxStressHdrBot.Left = 4.375F
			Me.lblRodTopMaxStressHdrBot.Name = "lblRodTopMaxStressHdrBot"
			Me.lblRodTopMaxStressHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodTopMaxStressHdrBot.Text = "   Stress (psi)"
			Me.lblRodTopMaxStressHdrBot.Top = 5.375F
			Me.lblRodTopMaxStressHdrBot.Width = 0.75F
			Me.lblRodTopMinStressHdrBot.Height = 0.145F
			Me.lblRodTopMinStressHdrBot.HyperLink = Nothing
			Me.lblRodTopMinStressHdrBot.Left = 5.25F
			Me.lblRodTopMinStressHdrBot.Name = "lblRodTopMinStressHdrBot"
			Me.lblRodTopMinStressHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodTopMinStressHdrBot.Text = "  Stress (psi)"
			Me.lblRodTopMinStressHdrBot.Top = 5.375F
			Me.lblRodTopMinStressHdrBot.Width = 0.75F
			Me.lblRodBotMinStressHdrBot.Height = 0.145F
			Me.lblRodBotMinStressHdrBot.HyperLink = Nothing
			Me.lblRodBotMinStressHdrBot.Left = 6.125F
			Me.lblRodBotMinStressHdrBot.Name = "lblRodBotMinStressHdrBot"
			Me.lblRodBotMinStressHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStressHdrBot.Text = " Stress (psi)"
			Me.lblRodBotMinStressHdrBot.Top = 5.375F
			Me.lblRodBotMinStressHdrBot.Width = 0.8125F
			Me.Line14.Height = 0F
			Me.Line14.Left = 3.75F
			Me.Line14.LineWeight = 1F
			Me.Line14.Name = "Line14"
			Me.Line14.Top = 5.5625F
			Me.Line14.Width = 4.125F
			Me.Line14.X1 = 3.75F
			Me.Line14.X2 = 7.875F
			Me.Line14.Y1 = 5.5625F
			Me.Line14.Y2 = 5.5625F
			Me.lblRodStress2.Height = 0.125F
			Me.lblRodStress2.HyperLink = Nothing
			Me.lblRodStress2.Left = 3.75F
			Me.lblRodStress2.Name = "lblRodStress2"
			Me.lblRodStress2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress2.Text = "Stress"
			Me.lblRodStress2.Top = 5.75F
			Me.lblRodStress2.Width = 0.5F
			Me.lblRodStress3.Height = 0.125F
			Me.lblRodStress3.HyperLink = Nothing
			Me.lblRodStress3.Left = 3.75F
			Me.lblRodStress3.Name = "lblRodStress3"
			Me.lblRodStress3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress3.Text = "Stress"
			Me.lblRodStress3.Top = 5.875F
			Me.lblRodStress3.Width = 0.5F
			Me.lblRodStress4.Height = 0.125F
			Me.lblRodStress4.HyperLink = Nothing
			Me.lblRodStress4.Left = 3.75F
			Me.lblRodStress4.Name = "lblRodStress4"
			Me.lblRodStress4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress4.Text = "Stress"
			Me.lblRodStress4.Top = 6F
			Me.lblRodStress4.Width = 0.5F
			Me.lblRodStress5.Height = 0.125F
			Me.lblRodStress5.HyperLink = Nothing
			Me.lblRodStress5.Left = 3.75F
			Me.lblRodStress5.Name = "lblRodStress5"
			Me.lblRodStress5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress5.Text = "Stress"
			Me.lblRodStress5.Top = 6.125F
			Me.lblRodStress5.Width = 0.5F
			Me.lblRodStress6.Height = 0.125F
			Me.lblRodStress6.HyperLink = Nothing
			Me.lblRodStress6.Left = 3.75F
			Me.lblRodStress6.Name = "lblRodStress6"
			Me.lblRodStress6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress6.Text = "Stress"
			Me.lblRodStress6.Top = 6.25F
			Me.lblRodStress6.Width = 0.5F
			Me.lblRodStress7.Height = 0.125F
			Me.lblRodStress7.HyperLink = Nothing
			Me.lblRodStress7.Left = 3.75F
			Me.lblRodStress7.Name = "lblRodStress7"
			Me.lblRodStress7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress7.Text = "Stress"
			Me.lblRodStress7.Top = 6.375F
			Me.lblRodStress7.Width = 0.5F
			Me.lblRodStress8.Height = 0.125F
			Me.lblRodStress8.HyperLink = Nothing
			Me.lblRodStress8.Left = 3.75F
			Me.lblRodStress8.Name = "lblRodStress8"
			Me.lblRodStress8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress8.Text = "Stress"
			Me.lblRodStress8.Top = 6.5F
			Me.lblRodStress8.Width = 0.5F
			Me.lblRodTopMaxStress1.Height = 0.125F
			Me.lblRodTopMaxStress1.HyperLink = Nothing
			Me.lblRodTopMaxStress1.Left = 4.375F
			Me.lblRodTopMaxStress1.Name = "lblRodTopMaxStress1"
			Me.lblRodTopMaxStress1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress1.Text = "Top Max"
			Me.lblRodTopMaxStress1.Top = 5.625F
			Me.lblRodTopMaxStress1.Width = 0.75F
			Me.lblRodTopMaxStress2.Height = 0.125F
			Me.lblRodTopMaxStress2.HyperLink = Nothing
			Me.lblRodTopMaxStress2.Left = 4.375F
			Me.lblRodTopMaxStress2.Name = "lblRodTopMaxStress2"
			Me.lblRodTopMaxStress2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress2.Text = "Top Max"
			Me.lblRodTopMaxStress2.Top = 5.75F
			Me.lblRodTopMaxStress2.Width = 0.75F
			Me.lblRodTopMaxStress3.Height = 0.125F
			Me.lblRodTopMaxStress3.HyperLink = Nothing
			Me.lblRodTopMaxStress3.Left = 4.375F
			Me.lblRodTopMaxStress3.Name = "lblRodTopMaxStress3"
			Me.lblRodTopMaxStress3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress3.Text = "Top Max"
			Me.lblRodTopMaxStress3.Top = 5.875F
			Me.lblRodTopMaxStress3.Width = 0.75F
			Me.lblRodTopMaxStress4.Height = 0.125F
			Me.lblRodTopMaxStress4.HyperLink = Nothing
			Me.lblRodTopMaxStress4.Left = 4.375F
			Me.lblRodTopMaxStress4.Name = "lblRodTopMaxStress4"
			Me.lblRodTopMaxStress4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress4.Text = "Top Max"
			Me.lblRodTopMaxStress4.Top = 6F
			Me.lblRodTopMaxStress4.Width = 0.75F
			Me.lblRodTopMaxStress5.Height = 0.125F
			Me.lblRodTopMaxStress5.HyperLink = Nothing
			Me.lblRodTopMaxStress5.Left = 4.375F
			Me.lblRodTopMaxStress5.Name = "lblRodTopMaxStress5"
			Me.lblRodTopMaxStress5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress5.Text = "Top Max"
			Me.lblRodTopMaxStress5.Top = 6.125F
			Me.lblRodTopMaxStress5.Width = 0.75F
			Me.lblRodTopMaxStress6.Height = 0.125F
			Me.lblRodTopMaxStress6.HyperLink = Nothing
			Me.lblRodTopMaxStress6.Left = 4.375F
			Me.lblRodTopMaxStress6.Name = "lblRodTopMaxStress6"
			Me.lblRodTopMaxStress6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress6.Text = "Top Max"
			Me.lblRodTopMaxStress6.Top = 6.25F
			Me.lblRodTopMaxStress6.Width = 0.75F
			Me.lblRodTopMaxStress7.Height = 0.125F
			Me.lblRodTopMaxStress7.HyperLink = Nothing
			Me.lblRodTopMaxStress7.Left = 4.375F
			Me.lblRodTopMaxStress7.Name = "lblRodTopMaxStress7"
			Me.lblRodTopMaxStress7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress7.Text = "Top Max"
			Me.lblRodTopMaxStress7.Top = 6.375F
			Me.lblRodTopMaxStress7.Width = 0.75F
			Me.lblRodTopMaxStress8.Height = 0.125F
			Me.lblRodTopMaxStress8.HyperLink = Nothing
			Me.lblRodTopMaxStress8.Left = 4.375F
			Me.lblRodTopMaxStress8.Name = "lblRodTopMaxStress8"
			Me.lblRodTopMaxStress8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress8.Text = "Top Max"
			Me.lblRodTopMaxStress8.Top = 6.5F
			Me.lblRodTopMaxStress8.Width = 0.75F
			Me.lblRodTopMinStress1.Height = 0.125F
			Me.lblRodTopMinStress1.HyperLink = Nothing
			Me.lblRodTopMinStress1.Left = 5.25F
			Me.lblRodTopMinStress1.Name = "lblRodTopMinStress1"
			Me.lblRodTopMinStress1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress1.Text = "Top Min"
			Me.lblRodTopMinStress1.Top = 5.625F
			Me.lblRodTopMinStress1.Width = 0.75F
			Me.lblRodTopMinStress2.Height = 0.125F
			Me.lblRodTopMinStress2.HyperLink = Nothing
			Me.lblRodTopMinStress2.Left = 5.25F
			Me.lblRodTopMinStress2.Name = "lblRodTopMinStress2"
			Me.lblRodTopMinStress2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress2.Text = "Top Min"
			Me.lblRodTopMinStress2.Top = 5.75F
			Me.lblRodTopMinStress2.Width = 0.75F
			Me.lblRodTopMinStress3.Height = 0.125F
			Me.lblRodTopMinStress3.HyperLink = Nothing
			Me.lblRodTopMinStress3.Left = 5.25F
			Me.lblRodTopMinStress3.Name = "lblRodTopMinStress3"
			Me.lblRodTopMinStress3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress3.Text = "Top Min"
			Me.lblRodTopMinStress3.Top = 5.875F
			Me.lblRodTopMinStress3.Width = 0.75F
			Me.lblRodTopMinStress4.Height = 0.125F
			Me.lblRodTopMinStress4.HyperLink = Nothing
			Me.lblRodTopMinStress4.Left = 5.25F
			Me.lblRodTopMinStress4.Name = "lblRodTopMinStress4"
			Me.lblRodTopMinStress4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress4.Text = "Top Min"
			Me.lblRodTopMinStress4.Top = 6F
			Me.lblRodTopMinStress4.Width = 0.75F
			Me.lblRodTopMinStress5.Height = 0.125F
			Me.lblRodTopMinStress5.HyperLink = Nothing
			Me.lblRodTopMinStress5.Left = 5.25F
			Me.lblRodTopMinStress5.Name = "lblRodTopMinStress5"
			Me.lblRodTopMinStress5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress5.Text = "Top Min"
			Me.lblRodTopMinStress5.Top = 6.125F
			Me.lblRodTopMinStress5.Width = 0.75F
			Me.lblRodTopMinStress6.Height = 0.125F
			Me.lblRodTopMinStress6.HyperLink = Nothing
			Me.lblRodTopMinStress6.Left = 5.25F
			Me.lblRodTopMinStress6.Name = "lblRodTopMinStress6"
			Me.lblRodTopMinStress6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress6.Text = "Top Min"
			Me.lblRodTopMinStress6.Top = 6.25F
			Me.lblRodTopMinStress6.Width = 0.75F
			Me.lblRodTopMinStress7.Height = 0.125F
			Me.lblRodTopMinStress7.HyperLink = Nothing
			Me.lblRodTopMinStress7.Left = 5.25F
			Me.lblRodTopMinStress7.Name = "lblRodTopMinStress7"
			Me.lblRodTopMinStress7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress7.Text = "Top Min"
			Me.lblRodTopMinStress7.Top = 6.375F
			Me.lblRodTopMinStress7.Width = 0.75F
			Me.lblRodTopMinStress8.Height = 0.125F
			Me.lblRodTopMinStress8.HyperLink = Nothing
			Me.lblRodTopMinStress8.Left = 5.25F
			Me.lblRodTopMinStress8.Name = "lblRodTopMinStress8"
			Me.lblRodTopMinStress8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress8.Text = "Top Min"
			Me.lblRodTopMinStress8.Top = 6.5F
			Me.lblRodTopMinStress8.Width = 0.75F
			Me.lblRodBotMinStress1.Height = 0.125F
			Me.lblRodBotMinStress1.HyperLink = Nothing
			Me.lblRodBotMinStress1.Left = 6.125F
			Me.lblRodBotMinStress1.Name = "lblRodBotMinStress1"
			Me.lblRodBotMinStress1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress1.Text = "Bot Min"
			Me.lblRodBotMinStress1.Top = 5.625F
			Me.lblRodBotMinStress1.Width = 0.8125F
			Me.lblRodBotMinStress2.Height = 0.125F
			Me.lblRodBotMinStress2.HyperLink = Nothing
			Me.lblRodBotMinStress2.Left = 6.125F
			Me.lblRodBotMinStress2.Name = "lblRodBotMinStress2"
			Me.lblRodBotMinStress2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress2.Text = "Bot Min"
			Me.lblRodBotMinStress2.Top = 5.75F
			Me.lblRodBotMinStress2.Width = 0.8125F
			Me.lblRodBotMinStress3.Height = 0.125F
			Me.lblRodBotMinStress3.HyperLink = Nothing
			Me.lblRodBotMinStress3.Left = 6.125F
			Me.lblRodBotMinStress3.Name = "lblRodBotMinStress3"
			Me.lblRodBotMinStress3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress3.Text = "Bot Min"
			Me.lblRodBotMinStress3.Top = 5.875F
			Me.lblRodBotMinStress3.Width = 0.8125F
			Me.lblRodBotMinStress4.Height = 0.125F
			Me.lblRodBotMinStress4.HyperLink = Nothing
			Me.lblRodBotMinStress4.Left = 6.125F
			Me.lblRodBotMinStress4.Name = "lblRodBotMinStress4"
			Me.lblRodBotMinStress4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress4.Text = "Bot Min"
			Me.lblRodBotMinStress4.Top = 6F
			Me.lblRodBotMinStress4.Width = 0.8125F
			Me.lblRodBotMinStress5.Height = 0.125F
			Me.lblRodBotMinStress5.HyperLink = Nothing
			Me.lblRodBotMinStress5.Left = 6.125F
			Me.lblRodBotMinStress5.Name = "lblRodBotMinStress5"
			Me.lblRodBotMinStress5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress5.Text = "Bot Min"
			Me.lblRodBotMinStress5.Top = 6.125F
			Me.lblRodBotMinStress5.Width = 0.8125F
			Me.lblRodBotMinStress6.Height = 0.125F
			Me.lblRodBotMinStress6.HyperLink = Nothing
			Me.lblRodBotMinStress6.Left = 6.125F
			Me.lblRodBotMinStress6.Name = "lblRodBotMinStress6"
			Me.lblRodBotMinStress6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress6.Text = "Bot Min"
			Me.lblRodBotMinStress6.Top = 6.25F
			Me.lblRodBotMinStress6.Width = 0.8125F
			Me.lblRodBotMinStress7.Height = 0.125F
			Me.lblRodBotMinStress7.HyperLink = Nothing
			Me.lblRodBotMinStress7.Left = 6.125F
			Me.lblRodBotMinStress7.Name = "lblRodBotMinStress7"
			Me.lblRodBotMinStress7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress7.Text = "Bot Min"
			Me.lblRodBotMinStress7.Top = 6.375F
			Me.lblRodBotMinStress7.Width = 0.8125F
			Me.lblRodBotMinStress8.Height = 0.125F
			Me.lblRodBotMinStress8.HyperLink = Nothing
			Me.lblRodBotMinStress8.Left = 6.125F
			Me.lblRodBotMinStress8.Name = "lblRodBotMinStress8"
			Me.lblRodBotMinStress8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress8.Text = "Bot Min"
			Me.lblRodBotMinStress8.Top = 6.5F
			Me.lblRodBotMinStress8.Width = 0.8125F
			Me.lblRodStressMethodHdrBot.Height = 0.145F
			Me.lblRodStressMethodHdrBot.HyperLink = Nothing
			Me.lblRodStressMethodHdrBot.Left = 7.0625F
			Me.lblRodStressMethodHdrBot.Name = "lblRodStressMethodHdrBot"
			Me.lblRodStressMethodHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethodHdrBot.Text = "Method"
			Me.lblRodStressMethodHdrBot.Top = 5.375F
			Me.lblRodStressMethodHdrBot.Width = 0.8125F
			Me.lblRodStressMethod1.Height = 0.125F
			Me.lblRodStressMethod1.HyperLink = Nothing
			Me.lblRodStressMethod1.Left = 7.0625F
			Me.lblRodStressMethod1.Name = "lblRodStressMethod1"
			Me.lblRodStressMethod1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod1.Text = "Stress Meth"
			Me.lblRodStressMethod1.Top = 5.625F
			Me.lblRodStressMethod1.Width = 0.8125F
			Me.lblRodStressMethod2.Height = 0.125F
			Me.lblRodStressMethod2.HyperLink = Nothing
			Me.lblRodStressMethod2.Left = 7.0625F
			Me.lblRodStressMethod2.Name = "lblRodStressMethod2"
			Me.lblRodStressMethod2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod2.Text = "Stress Meth"
			Me.lblRodStressMethod2.Top = 5.75F
			Me.lblRodStressMethod2.Width = 0.8125F
			Me.lblRodStressMethod3.Height = 0.125F
			Me.lblRodStressMethod3.HyperLink = Nothing
			Me.lblRodStressMethod3.Left = 7.0625F
			Me.lblRodStressMethod3.Name = "lblRodStressMethod3"
			Me.lblRodStressMethod3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod3.Text = "Stress Meth"
			Me.lblRodStressMethod3.Top = 5.875F
			Me.lblRodStressMethod3.Width = 0.8125F
			Me.lblRodStressMethod4.Height = 0.125F
			Me.lblRodStressMethod4.HyperLink = Nothing
			Me.lblRodStressMethod4.Left = 7.0625F
			Me.lblRodStressMethod4.Name = "lblRodStressMethod4"
			Me.lblRodStressMethod4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod4.Text = "Stress Meth"
			Me.lblRodStressMethod4.Top = 6F
			Me.lblRodStressMethod4.Width = 0.8125F
			Me.lblRodStressMethod5.Height = 0.125F
			Me.lblRodStressMethod5.HyperLink = Nothing
			Me.lblRodStressMethod5.Left = 7.0625F
			Me.lblRodStressMethod5.Name = "lblRodStressMethod5"
			Me.lblRodStressMethod5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod5.Text = "Stress Meth"
			Me.lblRodStressMethod5.Top = 6.125F
			Me.lblRodStressMethod5.Width = 0.8125F
			Me.lblRodStressMethod6.Height = 0.125F
			Me.lblRodStressMethod6.HyperLink = Nothing
			Me.lblRodStressMethod6.Left = 7.0625F
			Me.lblRodStressMethod6.Name = "lblRodStressMethod6"
			Me.lblRodStressMethod6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod6.Text = "Stress Meth"
			Me.lblRodStressMethod6.Top = 6.25F
			Me.lblRodStressMethod6.Width = 0.8125F
			Me.lblRodStressMethod7.Height = 0.125F
			Me.lblRodStressMethod7.HyperLink = Nothing
			Me.lblRodStressMethod7.Left = 7.0625F
			Me.lblRodStressMethod7.Name = "lblRodStressMethod7"
			Me.lblRodStressMethod7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod7.Text = "Stress Meth"
			Me.lblRodStressMethod7.Top = 6.375F
			Me.lblRodStressMethod7.Width = 0.8125F
			Me.lblRodStressMethod8.Height = 0.125F
			Me.lblRodStressMethod8.HyperLink = Nothing
			Me.lblRodStressMethod8.Left = 7.0625F
			Me.lblRodStressMethod8.Name = "lblRodStressMethod8"
			Me.lblRodStressMethod8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod8.Text = "Stress Meth"
			Me.lblRodStressMethod8.Top = 6.5F
			Me.lblRodStressMethod8.Width = 0.8125F
			Me.lblFLPIP_3.Height = 0.145F
			Me.lblFLPIP_3.HyperLink = Nothing
			Me.lblFLPIP_3.Left = 1.875F
			Me.lblFLPIP_3.Name = "lblFLPIP_3"
			Me.lblFLPIP_3.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblFLPIP_3.Text = "  ft over pump"
			Me.lblFLPIP_3.Top = 0.625F
			Me.lblFLPIP_3.Width = 1.0625F
			Me.lblSPM.Height = 0.145F
			Me.lblSPM.HyperLink = Nothing
			Me.lblSPM.Left = 0.0625F
			Me.lblSPM.Name = "lblSPM"
			Me.lblSPM.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblSPM.Text = "Pumping speed"
			Me.lblSPM.Top = 0.375F
			Me.lblSPM.Width = 1.125F
			Me.lblPlungerLength.Height = 0.145F
			Me.lblPlungerLength.HyperLink = Nothing
			Me.lblPlungerLength.Left = 3.75F
			Me.lblPlungerLength.Name = "lblPlungerLength"
			Me.lblPlungerLength.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPlungerLength.Text = "Recommended plunger length"
			Me.lblPlungerLength.Top = 4.75F
			Me.lblPlungerLength.Width = 2.0625F
			Me.lblPumpLength.Height = 0.145F
			Me.lblPumpLength.HyperLink = Nothing
			Me.lblPumpLength.Left = 3.75F
			Me.lblPumpLength.Name = "lblPumpLength"
			Me.lblPumpLength.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPumpLength.Text = "Minimum pump length"
			Me.lblPumpLength.Top = 4.625F
			Me.lblPumpLength.Width = 2.0625F
			Me.lblPumpSpacing.Height = 0.145F
			Me.lblPumpSpacing.HyperLink = Nothing
			Me.lblPumpSpacing.Left = 3.75F
			Me.lblPumpSpacing.Name = "lblPumpSpacing"
			Me.lblPumpSpacing.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPumpSpacing.Text = "Pump spacing"
			Me.lblPumpSpacing.Top = 4.5F
			Me.lblPumpSpacing.Width = 2.0625F
			Me.lblGrossPumpStroke.Height = 0.145F
			Me.lblGrossPumpStroke.HyperLink = Nothing
			Me.lblGrossPumpStroke.Left = 3.75F
			Me.lblGrossPumpStroke.Name = "lblGrossPumpStroke"
			Me.lblGrossPumpStroke.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblGrossPumpStroke.Text = "Gross pump stroke"
			Me.lblGrossPumpStroke.Top = 4.375F
			Me.lblGrossPumpStroke.Width = 2.0625F
			Me.lblProductionLoss.Height = 0.145F
			Me.lblProductionLoss.HyperLink = Nothing
			Me.lblProductionLoss.Left = 3.75F
			Me.lblProductionLoss.Name = "lblProductionLoss"
			Me.lblProductionLoss.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblProductionLoss.Text = "Production loss"
			Me.lblProductionLoss.Top = 4.25F
			Me.lblProductionLoss.Width = 2.0625F
			Me.lblTubingStretch.Height = 0.145F
			Me.lblTubingStretch.HyperLink = Nothing
			Me.lblTubingStretch.Left = 3.75F
			Me.lblTubingStretch.Name = "lblTubingStretch"
			Me.lblTubingStretch.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblTubingStretch.Text = "Tubing stretch"
			Me.lblTubingStretch.Top = 4.125F
			Me.lblTubingStretch.Width = 2.0625F
			Me.lblPumpFriction.Height = 0.145F
			Me.lblPumpFriction.HyperLink = Nothing
			Me.lblPumpFriction.Left = 1.725F
			Me.lblPumpFriction.Name = "lblPumpFriction"
			Me.lblPumpFriction.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPumpFriction.Text = "Pump friction"
			Me.lblPumpFriction.Top = 4.75F
			Me.lblPumpFriction.Width = 1.25F
			Me.lblPumpEfficiency.Height = 0.145F
			Me.lblPumpEfficiency.HyperLink = Nothing
			Me.lblPumpEfficiency.Left = 1.725F
			Me.lblPumpEfficiency.Name = "lblPumpEfficiency"
			Me.lblPumpEfficiency.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPumpEfficiency.Text = "Pump vol. efficiency "
			Me.lblPumpEfficiency.Top = 4.625F
			Me.lblPumpEfficiency.Width = 1.25F
			Me.lblPumpLoadAdj.Height = 0.145F
			Me.lblPumpLoadAdj.HyperLink = Nothing
			Me.lblPumpLoadAdj.Left = 1.725F
			Me.lblPumpLoadAdj.Name = "lblPumpLoadAdj"
			Me.lblPumpLoadAdj.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPumpLoadAdj.Text = "Pump load adjustment"
			Me.lblPumpLoadAdj.Top = 4.5F
			Me.lblPumpLoadAdj.Width = 1.25F
			Me.lblTubingAnchorDepth.Height = 0.145F
			Me.lblTubingAnchorDepth.HyperLink = Nothing
			Me.lblTubingAnchorDepth.Left = 1.725F
			Me.lblTubingAnchorDepth.Name = "lblTubingAnchorDepth"
			Me.lblTubingAnchorDepth.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblTubingAnchorDepth.Text = "Tubing anchor depth"
			Me.lblTubingAnchorDepth.Top = 4.375F
			Me.lblTubingAnchorDepth.Width = 1.25F
			Me.lblDownstrokeFriction.Height = 0.145F
			Me.lblDownstrokeFriction.HyperLink = Nothing
			Me.lblDownstrokeFriction.Left = 1.75F
			Me.lblDownstrokeFriction.Name = "lblDownstrokeFriction"
			Me.lblDownstrokeFriction.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblDownstrokeFriction.Text = "Dnstr rod-fl. damp. coef."
			Me.lblDownstrokeFriction.Top = 4.125F
			Me.lblDownstrokeFriction.Width = 1.4375F
			Me.lblPumpType.Height = 0.145F
			Me.lblPumpType.HyperLink = Nothing
			Me.lblPumpType.Left = 0.0625F
			Me.lblPumpType.Name = "lblPumpType"
			Me.lblPumpType.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPumpType.Text = "Pump type"
			Me.lblPumpType.Top = 4.625F
			Me.lblPumpType.Width = 0.9375F
			Me.lblPumpCondition.Height = 0.145F
			Me.lblPumpCondition.HyperLink = Nothing
			Me.lblPumpCondition.Left = 0.0625F
			Me.lblPumpCondition.Name = "lblPumpCondition"
			Me.lblPumpCondition.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPumpCondition.Text = "Pump condition"
			Me.lblPumpCondition.Top = 4.5F
			Me.lblPumpCondition.Width = 0.9375F
			Me.lblPumpDepth.Height = 0.145F
			Me.lblPumpDepth.HyperLink = Nothing
			Me.lblPumpDepth.Left = 0.0625F
			Me.lblPumpDepth.Name = "lblPumpDepth"
			Me.lblPumpDepth.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPumpDepth.Text = "Pump depth"
			Me.lblPumpDepth.Top = 4.375F
			Me.lblPumpDepth.Width = 0.9375F
			Me.lblDollarsPerBblOil.Height = 0.145F
			Me.lblDollarsPerBblOil.HyperLink = Nothing
			Me.lblDollarsPerBblOil.Left = 3.75F
			Me.lblDollarsPerBblOil.Name = "lblDollarsPerBblOil"
			Me.lblDollarsPerBblOil.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblOil.Text = "Electr.cost per bbl. oil:"
			Me.lblDollarsPerBblOil.Top = 3.625F
			Me.lblDollarsPerBblOil.Width = 1.875F
			Me.lblDollarsPerBblFluid.Height = 0.145F
			Me.lblDollarsPerBblFluid.HyperLink = Nothing
			Me.lblDollarsPerBblFluid.Left = 3.75F
			Me.lblDollarsPerBblFluid.Name = "lblDollarsPerBblFluid"
			Me.lblDollarsPerBblFluid.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblFluid.Text = "Electr.cost per bbl. fluid:"
			Me.lblDollarsPerBblFluid.Top = 3.5F
			Me.lblDollarsPerBblFluid.Width = 1.875F
			Me.lblElectricBillPerMonth.Height = 0.145F
			Me.lblElectricBillPerMonth.HyperLink = Nothing
			Me.lblElectricBillPerMonth.Left = 3.75F
			Me.lblElectricBillPerMonth.Name = "lblElectricBillPerMonth"
			Me.lblElectricBillPerMonth.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblElectricBillPerMonth.Text = "Monthly electric bill:"
			Me.lblElectricBillPerMonth.Top = 3.375F
			Me.lblElectricBillPerMonth.Width = 1.875F
			Me.lblTorqueAnalysis.Height = 0.15F
			Me.lblTorqueAnalysis.HyperLink = Nothing
			Me.lblTorqueAnalysis.Left = 3.75F
			Me.lblTorqueAnalysis.Name = "lblTorqueAnalysis"
			Me.lblTorqueAnalysis.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblTorqueAnalysis.Text = "Torque analysis and"
			Me.lblTorqueAnalysis.Top = 2.25F
			Me.lblTorqueAnalysis.Width = 1.875F
			Me.lblSingleCyl.Height = 0.145F
			Me.lblSingleCyl.HyperLink = Nothing
			Me.lblSingleCyl.Left = 3.75F
			Me.lblSingleCyl.Name = "lblSingleCyl"
			Me.lblSingleCyl.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblSingleCyl.Text = "Single/double cyl. engine:"
			Me.lblSingleCyl.Top = 1.925F
			Me.lblSingleCyl.Width = 1.875F
			Me.lblMotorKWH.Height = 0.145F
			Me.lblMotorKWH.HyperLink = Nothing
			Me.lblMotorKWH.Left = 3.75F
			Me.lblMotorKWH.Name = "lblMotorKWH"
			Me.lblMotorKWH.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblMotorKWH.Text = "Daily electr.use (KWH/day):"
			Me.lblMotorKWH.Top = 3.25F
			Me.lblMotorKWH.Width = 1.875F
			Me.lblTubingPressure.Height = 0.145F
			Me.lblTubingPressure.HyperLink = Nothing
			Me.lblTubingPressure.Left = 0.0625F
			Me.lblTubingPressure.Name = "lblTubingPressure"
			Me.lblTubingPressure.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblTubingPressure.Text = "Tubing pressure"
			Me.lblTubingPressure.Top = 0.625F
			Me.lblTubingPressure.Width = 1.125F
			Me.lblReqPrimeMoverSize.Height = 0.145F
			Me.lblReqPrimeMoverSize.HyperLink = Nothing
			Me.lblReqPrimeMoverSize.Left = 3.75F
			Me.lblReqPrimeMoverSize.Name = "lblReqPrimeMoverSize"
			Me.lblReqPrimeMoverSize.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblReqPrimeMoverSize.Text = "Required prime mover size"
			Me.lblReqPrimeMoverSize.Top = 1.45F
			Me.lblReqPrimeMoverSize.Width = 1.875F
			Me.lblRodGradeHdrTop.Height = 0.145F
			Me.lblRodGradeHdrTop.HyperLink = Nothing
			Me.lblRodGradeHdrTop.Left = 0.8125F
			Me.lblRodGradeHdrTop.Name = "lblRodGradeHdrTop"
			Me.lblRodGradeHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGradeHdrTop.Text = "Rod"
			Me.lblRodGradeHdrTop.Top = 5.25F
			Me.lblRodGradeHdrTop.Width = 0.9375F
			Me.lblRodTopMinStressHdrTop.Height = 0.145F
			Me.lblRodTopMinStressHdrTop.HyperLink = Nothing
			Me.lblRodTopMinStressHdrTop.Left = 5.25F
			Me.lblRodTopMinStressHdrTop.Name = "lblRodTopMinStressHdrTop"
			Me.lblRodTopMinStressHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodTopMinStressHdrTop.Text = "Top Minimum"
			Me.lblRodTopMinStressHdrTop.Top = 5.25F
			Me.lblRodTopMinStressHdrTop.Width = 0.75F
			Me.lblRodBotMinStressHdrTop.Height = 0.145F
			Me.lblRodBotMinStressHdrTop.HyperLink = Nothing
			Me.lblRodBotMinStressHdrTop.Left = 6.125F
			Me.lblRodBotMinStressHdrTop.Name = "lblRodBotMinStressHdrTop"
			Me.lblRodBotMinStressHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodBotMinStressHdrTop.Text = "  Bot. Minimum"
			Me.lblRodBotMinStressHdrTop.Top = 5.25F
			Me.lblRodBotMinStressHdrTop.Width = 0.8125F
			Me.lblRodStressMethodHdrTop.Height = 0.145F
			Me.lblRodStressMethodHdrTop.HyperLink = Nothing
			Me.lblRodStressMethodHdrTop.Left = 7.0625F
			Me.lblRodStressMethodHdrTop.Name = "lblRodStressMethodHdrTop"
			Me.lblRodStressMethodHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethodHdrTop.Text = "   Stress Calc."
			Me.lblRodStressMethodHdrTop.Top = 5.25F
			Me.lblRodStressMethodHdrTop.Width = 0.8125F
			Me.lblRodTopMaxStressHdrTop.Height = 0.145F
			Me.lblRodTopMaxStressHdrTop.HyperLink = Nothing
			Me.lblRodTopMaxStressHdrTop.Left = 4.375F
			Me.lblRodTopMaxStressHdrTop.Name = "lblRodTopMaxStressHdrTop"
			Me.lblRodTopMaxStressHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodTopMaxStressHdrTop.Text = "Top Maximum"
			Me.lblRodTopMaxStressHdrTop.Top = 5.25F
			Me.lblRodTopMaxStressHdrTop.Width = 0.75F
			Me.lblRodStressHdrTop.Height = 0.145F
			Me.lblRodStressHdrTop.HyperLink = Nothing
			Me.lblRodStressHdrTop.Left = 3.75F
			Me.lblRodStressHdrTop.Name = "lblRodStressHdrTop"
			Me.lblRodStressHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodStressHdrTop.Text = "  Stress"
			Me.lblRodStressHdrTop.Top = 5.25F
			Me.lblRodStressHdrTop.Width = 0.5F
			Me.lblRodTensileStrengthHdrTop.Height = 0.145F
			Me.lblRodTensileStrengthHdrTop.HyperLink = Nothing
			Me.lblRodTensileStrengthHdrTop.Left = 2.4375F
			Me.lblRodTensileStrengthHdrTop.Name = "lblRodTensileStrengthHdrTop"
			Me.lblRodTensileStrengthHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrengthHdrTop.Text = "Min. Tensile"
			Me.lblRodTensileStrengthHdrTop.Top = 5.25F
			Me.lblRodTensileStrengthHdrTop.Width = 0.75F
			Me.lblRodLengthHdrTop.Height = 0.145F
			Me.lblRodLengthHdrTop.HyperLink = Nothing
			Me.lblRodLengthHdrTop.Left = 1.875F
			Me.lblRodLengthHdrTop.Name = "lblRodLengthHdrTop"
			Me.lblRodLengthHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodLengthHdrTop.Text = "Length"
			Me.lblRodLengthHdrTop.Top = 5.25F
			Me.lblRodLengthHdrTop.Width = 0.4375F
			Me.lblPmBalancedT.Height = 0.125F
			Me.lblPmBalancedT.HyperLink = Nothing
			Me.lblPmBalancedT.Left = 6.4375F
			Me.lblPmBalancedT.Name = "lblPmBalancedT"
			Me.lblPmBalancedT.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblPmBalancedT.Text = "BALANCED"
			Me.lblPmBalancedT.Top = 1.475F
			Me.lblPmBalancedT.Width = 0.75F
			Me.lblTqBalancedT.Height = 0.125F
			Me.lblTqBalancedT.HyperLink = Nothing
			Me.lblTqBalancedT.Left = 6.4375F
			Me.lblTqBalancedT.Name = "lblTqBalancedT"
			Me.lblTqBalancedT.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblTqBalancedT.Text = "BALANCED"
			Me.lblTqBalancedT.Top = 2.25F
			Me.lblTqBalancedT.Width = 0.75F
			Me.lblTqBalancedE.Height = 0.125F
			Me.lblTqBalancedE.HyperLink = Nothing
			Me.lblTqBalancedE.Left = 5.6875F
			Me.lblTqBalancedE.Name = "lblTqBalancedE"
			Me.lblTqBalancedE.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblTqBalancedE.Text = "BALANCED"
			Me.lblTqBalancedE.Top = 2.25F
			Me.lblTqBalancedE.Width = 0.75F
			Me.txtPlungerLength.Height = 0.145F
			Me.txtPlungerLength.HyperLink = Nothing
			Me.txtPlungerLength.Left = 5.875F
			Me.txtPlungerLength.Name = "txtPlungerLength"
			Me.txtPlungerLength.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtPlungerLength.Text = " "
			Me.txtPlungerLength.Top = 4.75F
			Me.txtPlungerLength.Width = 0.625F
			Me.txtPumpLength.Height = 0.145F
			Me.txtPumpLength.HyperLink = Nothing
			Me.txtPumpLength.Left = 5.875F
			Me.txtPumpLength.Name = "txtPumpLength"
			Me.txtPumpLength.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtPumpLength.Text = " "
			Me.txtPumpLength.Top = 4.625F
			Me.txtPumpLength.Width = 0.625F
			Me.txtPumpSpacing.Height = 0.145F
			Me.txtPumpSpacing.HyperLink = Nothing
			Me.txtPumpSpacing.Left = 5.875F
			Me.txtPumpSpacing.Name = "txtPumpSpacing"
			Me.txtPumpSpacing.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtPumpSpacing.Text = " "
			Me.txtPumpSpacing.Top = 4.5F
			Me.txtPumpSpacing.Width = 0.625F
			Me.txtGrossPumpStroke.Height = 0.145F
			Me.txtGrossPumpStroke.HyperLink = Nothing
			Me.txtGrossPumpStroke.Left = 5.875F
			Me.txtGrossPumpStroke.Name = "txtGrossPumpStroke"
			Me.txtGrossPumpStroke.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtGrossPumpStroke.Text = " "
			Me.txtGrossPumpStroke.Top = 4.375F
			Me.txtGrossPumpStroke.Width = 0.625F
			Me.txtProductionLoss.Height = 0.145F
			Me.txtProductionLoss.HyperLink = Nothing
			Me.txtProductionLoss.Left = 5.875F
			Me.txtProductionLoss.Name = "txtProductionLoss"
			Me.txtProductionLoss.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtProductionLoss.Text = " "
			Me.txtProductionLoss.Top = 4.25F
			Me.txtProductionLoss.Width = 0.625F
			Me.txtTubingStretch.Height = 0.145F
			Me.txtTubingStretch.HyperLink = Nothing
			Me.txtTubingStretch.Left = 5.875F
			Me.txtTubingStretch.Name = "txtTubingStretch"
			Me.txtTubingStretch.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtTubingStretch.Text = " "
			Me.txtTubingStretch.Top = 4.125F
			Me.txtTubingStretch.Width = 0.625F
			Me.txtTubingOD.Height = 0.145F
			Me.txtTubingOD.HyperLink = Nothing
			Me.txtTubingOD.Left = 1.02F
			Me.txtTubingOD.Name = "txtTubingOD"
			Me.txtTubingOD.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtTubingOD.Text = " "
			Me.txtTubingOD.Top = 4F
			Me.txtTubingOD.Width = 0.649F
			Me.txtTubingID.Height = 0.145F
			Me.txtTubingID.HyperLink = Nothing
			Me.txtTubingID.Left = 1.02F
			Me.txtTubingID.Name = "txtTubingID"
			Me.txtTubingID.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtTubingID.Text = " "
			Me.txtTubingID.Top = 4.125F
			Me.txtTubingID.Width = 0.649F
			Me.txtPlungerSize.Height = 0.145F
			Me.txtPlungerSize.HyperLink = Nothing
			Me.txtPlungerSize.Left = 1.02F
			Me.txtPlungerSize.Name = "txtPlungerSize"
			Me.txtPlungerSize.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtPlungerSize.Text = " "
			Me.txtPlungerSize.Top = 4.75F
			Me.txtPlungerSize.Width = 0.649F
			Me.txtPumpType.Height = 0.145F
			Me.txtPumpType.HyperLink = Nothing
			Me.txtPumpType.Left = 1.02F
			Me.txtPumpType.Name = "txtPumpType"
			Me.txtPumpType.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtPumpType.Text = " "
			Me.txtPumpType.Top = 4.625F
			Me.txtPumpType.Width = 0.649F
			Me.txtPumpCondition.Height = 0.145F
			Me.txtPumpCondition.HyperLink = Nothing
			Me.txtPumpCondition.Left = 1.02F
			Me.txtPumpCondition.Name = "txtPumpCondition"
			Me.txtPumpCondition.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtPumpCondition.Text = " "
			Me.txtPumpCondition.Top = 4.5F
			Me.txtPumpCondition.Width = 0.649F
			Me.txtPumpDepth.Height = 0.145F
			Me.txtPumpDepth.HyperLink = Nothing
			Me.txtPumpDepth.Left = 1.02F
			Me.txtPumpDepth.Name = "txtPumpDepth"
			Me.txtPumpDepth.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtPumpDepth.Text = " "
			Me.txtPumpDepth.Top = 4.375F
			Me.txtPumpDepth.Width = 0.649F
			Me.txtUpstrokeFriction.Height = 0.145F
			Me.txtUpstrokeFriction.HyperLink = Nothing
			Me.txtUpstrokeFriction.Left = 3.1875F
			Me.txtUpstrokeFriction.Name = "txtUpstrokeFriction"
			Me.txtUpstrokeFriction.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtUpstrokeFriction.Text = " "
			Me.txtUpstrokeFriction.Top = 4F
			Me.txtUpstrokeFriction.Width = 0.4125004F
			Me.txtDownstrokeFriction.Height = 0.145F
			Me.txtDownstrokeFriction.HyperLink = Nothing
			Me.txtDownstrokeFriction.Left = 3.1875F
			Me.txtDownstrokeFriction.Name = "txtDownstrokeFriction"
			Me.txtDownstrokeFriction.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtDownstrokeFriction.Text = " "
			Me.txtDownstrokeFriction.Top = 4.125F
			Me.txtDownstrokeFriction.Width = 0.4125004F
			Me.txtPumpFriction.Height = 0.145F
			Me.txtPumpFriction.HyperLink = Nothing
			Me.txtPumpFriction.Left = 3.03F
			Me.txtPumpFriction.Name = "txtPumpFriction"
			Me.txtPumpFriction.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtPumpFriction.Text = " "
			Me.txtPumpFriction.Top = 4.75F
			Me.txtPumpFriction.Width = 0.57F
			Me.txtPumpLoadAdj.Height = 0.145F
			Me.txtPumpLoadAdj.HyperLink = Nothing
			Me.txtPumpLoadAdj.Left = 3.03F
			Me.txtPumpLoadAdj.Name = "txtPumpLoadAdj"
			Me.txtPumpLoadAdj.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtPumpLoadAdj.Text = " "
			Me.txtPumpLoadAdj.Top = 4.5F
			Me.txtPumpLoadAdj.Width = 0.57F
			Me.txtTubingAnchorDepth.Height = 0.145F
			Me.txtTubingAnchorDepth.HyperLink = Nothing
			Me.txtTubingAnchorDepth.Left = 3.03F
			Me.txtTubingAnchorDepth.Name = "txtTubingAnchorDepth"
			Me.txtTubingAnchorDepth.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtTubingAnchorDepth.Text = " "
			Me.txtTubingAnchorDepth.Top = 4.375F
			Me.txtTubingAnchorDepth.Width = 0.57F
			Me.txtPumpEfficiency.Height = 0.145F
			Me.txtPumpEfficiency.HyperLink = Nothing
			Me.txtPumpEfficiency.Left = 3.03F
			Me.txtPumpEfficiency.Name = "txtPumpEfficiency"
			Me.txtPumpEfficiency.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtPumpEfficiency.Text = " "
			Me.txtPumpEfficiency.Top = 4.625F
			Me.txtPumpEfficiency.Width = 0.6F
			Me.txtPowerMeter.Height = 0.145F
			Me.txtPowerMeter.HyperLink = Nothing
			Me.txtPowerMeter.Left = 2.58F
			Me.txtPowerMeter.Name = "txtPowerMeter"
			Me.txtPowerMeter.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtPowerMeter.Text = ""
			Me.txtPowerMeter.Top = 1.375F
			Me.txtPowerMeter.Width = 1.05F
			Me.txtElectricityCost.Height = 0.145F
			Me.txtElectricityCost.HyperLink = Nothing
			Me.txtElectricityCost.Left = 2.58F
			Me.txtElectricityCost.Name = "txtElectricityCost"
			Me.txtElectricityCost.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtElectricityCost.Text = ""
			Me.txtElectricityCost.Top = 1.5F
			Me.txtElectricityCost.Width = 1.05F
			Me.txtMotorType.Height = 0.145F
			Me.txtMotorType.HyperLink = Nothing
			Me.txtMotorType.Left = 2.58F
			Me.txtMotorType.Name = "txtMotorType"
			Me.txtMotorType.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtMotorType.Text = ""
			Me.txtMotorType.Top = 1.625F
			Me.txtMotorType.Width = 1.05F
			Me.txtMotorSize.Height = 0.145F
			Me.txtMotorSize.HyperLink = Nothing
			Me.txtMotorSize.Left = 2.58F
			Me.txtMotorSize.Name = "txtMotorSize"
			Me.txtMotorSize.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtMotorSize.Text = ""
			Me.txtMotorSize.Top = 1.75F
			Me.txtMotorSize.Width = 1.05F
			Me.txtMotorSetting.Height = 0.145F
			Me.txtMotorSetting.HyperLink = Nothing
			Me.txtMotorSetting.Left = 2.58F
			Me.txtMotorSetting.Name = "txtMotorSetting"
			Me.txtMotorSetting.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtMotorSetting.Text = ""
			Me.txtMotorSetting.Top = 1.875F
			Me.txtMotorSetting.Width = 1.05F
			Me.txtWaterCut.Height = 0.145F
			Me.txtWaterCut.HyperLink = Nothing
			Me.txtWaterCut.Left = 1.25F
			Me.txtWaterCut.Name = "txtWaterCut"
			Me.txtWaterCut.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtWaterCut.Text = ""
			Me.txtWaterCut.Top = 1.375F
			Me.txtWaterCut.Width = 0.5625F
			Me.txtWaterSPGR.Height = 0.145F
			Me.txtWaterSPGR.HyperLink = Nothing
			Me.txtWaterSPGR.Left = 1.25F
			Me.txtWaterSPGR.Name = "txtWaterSPGR"
			Me.txtWaterSPGR.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtWaterSPGR.Text = ""
			Me.txtWaterSPGR.Top = 1.5F
			Me.txtWaterSPGR.Width = 0.5625F
			Me.txtOilSPGR.Height = 0.145F
			Me.txtOilSPGR.HyperLink = Nothing
			Me.txtOilSPGR.Left = 1.25F
			Me.txtOilSPGR.Name = "txtOilSPGR"
			Me.txtOilSPGR.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtOilSPGR.Text = ""
			Me.txtOilSPGR.Top = 1.625F
			Me.txtOilSPGR.Width = 0.5625F
			Me.txtFluidSPGR.Height = 0.145F
			Me.txtFluidSPGR.HyperLink = Nothing
			Me.txtFluidSPGR.Left = 1.25F
			Me.txtFluidSPGR.Name = "txtFluidSPGR"
			Me.txtFluidSPGR.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtFluidSPGR.Text = ""
			Me.txtFluidSPGR.Top = 1.75F
			Me.txtFluidSPGR.Width = 0.5625F
			Me.txtCompressibilityIndex.Height = 0.145F
			Me.txtCompressibilityIndex.HyperLink = Nothing
			Me.txtCompressibilityIndex.Left = 1.25F
			Me.txtCompressibilityIndex.Name = "txtCompressibilityIndex"
			Me.txtCompressibilityIndex.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtCompressibilityIndex.Text = ""
			Me.txtCompressibilityIndex.Top = 1.875F
			Me.txtCompressibilityIndex.Width = 0.5625F
			Me.txtSPM.Height = 0.145F
			Me.txtSPM.HyperLink = Nothing
			Me.txtSPM.Left = 1.25F
			Me.txtSPM.Name = "txtSPM"
			Me.txtSPM.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtSPM.Text = ""
			Me.txtSPM.Top = 0.375F
			Me.txtSPM.Width = 0.5625F
			Me.txtRuntime.Height = 0.145F
			Me.txtRuntime.HyperLink = Nothing
			Me.txtRuntime.Left = 1.25F
			Me.txtRuntime.Name = "txtRuntime"
			Me.txtRuntime.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtRuntime.Text = ""
			Me.txtRuntime.Top = 0.5F
			Me.txtRuntime.Width = 0.5625F
			Me.txtTubingPressure.Height = 0.145F
			Me.txtTubingPressure.HyperLink = Nothing
			Me.txtTubingPressure.Left = 1.25F
			Me.txtTubingPressure.Name = "txtTubingPressure"
			Me.txtTubingPressure.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtTubingPressure.Text = ""
			Me.txtTubingPressure.Top = 0.625F
			Me.txtTubingPressure.Width = 0.5625F
			Me.txtCasingPressure.Height = 0.145F
			Me.txtCasingPressure.HyperLink = Nothing
			Me.txtCasingPressure.Left = 1.25F
			Me.txtCasingPressure.Name = "txtCasingPressure"
			Me.txtCasingPressure.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtCasingPressure.Text = ""
			Me.txtCasingPressure.Top = 0.75F
			Me.txtCasingPressure.Width = 0.5625F
			Me.txtFLPIP_1.Height = 0.145F
			Me.txtFLPIP_1.HyperLink = Nothing
			Me.txtFLPIP_1.Left = 3F
			Me.txtFLPIP_1.Name = "txtFLPIP_1"
			Me.txtFLPIP_1.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtFLPIP_1.Text = ""
			Me.txtFLPIP_1.Top = 0.375F
			Me.txtFLPIP_1.Width = 0.625F
			Me.txtFLPIP_2.Height = 0.145F
			Me.txtFLPIP_2.HyperLink = Nothing
			Me.txtFLPIP_2.Left = 3F
			Me.txtFLPIP_2.Name = "txtFLPIP_2"
			Me.txtFLPIP_2.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtFLPIP_2.Text = ""
			Me.txtFLPIP_2.Top = 0.5F
			Me.txtFLPIP_2.Width = 0.625F
			Me.txtFLPIP_3.Height = 0.145F
			Me.txtFLPIP_3.HyperLink = Nothing
			Me.txtFLPIP_3.Left = 3F
			Me.txtFLPIP_3.Name = "txtFLPIP_3"
			Me.txtFLPIP_3.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtFLPIP_3.Text = ""
			Me.txtFLPIP_3.Top = 0.625F
			Me.txtFLPIP_3.Width = 0.625F
			Me.txtStuffingBoxFriction.Height = 0.145F
			Me.txtStuffingBoxFriction.HyperLink = Nothing
			Me.txtStuffingBoxFriction.Left = 3F
			Me.txtStuffingBoxFriction.Name = "txtStuffingBoxFriction"
			Me.txtStuffingBoxFriction.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtStuffingBoxFriction.Text = ""
			Me.txtStuffingBoxFriction.Top = 0.75F
			Me.txtStuffingBoxFriction.Width = 0.625F
			Me.lnPMSV.Height = 0F
			Me.lnPMSV.Left = 3.75F
			Me.lnPMSV.LineWeight = 1F
			Me.lnPMSV.Name = "lnPMSV"
			Me.lnPMSV.Top = 1.6F
			Me.lnPMSV.Visible = False
			Me.lnPMSV.Width = 1.9375F
			Me.lnPMSV.X1 = 3.75F
			Me.lnPMSV.X2 = 5.6875F
			Me.lnPMSV.Y1 = 1.6F
			Me.lnPMSV.Y2 = 1.6F
			Me.txtCrankHole.Height = 0.145F
			Me.txtCrankHole.HyperLink = Nothing
			Me.txtCrankHole.Left = 2F
			Me.txtCrankHole.Name = "txtCrankHole"
			Me.txtCrankHole.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtCrankHole.Text = ""
			Me.txtCrankHole.Top = 2.625F
			Me.txtCrankHole.Width = 0.75F
			Me.txtStrokeLength.Height = 0.145F
			Me.txtStrokeLength.HyperLink = Nothing
			Me.txtStrokeLength.Left = 2F
			Me.txtStrokeLength.Name = "txtStrokeLength"
			Me.txtStrokeLength.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtStrokeLength.Text = ""
			Me.txtStrokeLength.Top = 2.75F
			Me.txtStrokeLength.Width = 0.75F
			Me.txtCrankRotation.Height = 0.145F
			Me.txtCrankRotation.HyperLink = Nothing
			Me.txtCrankRotation.Left = 2F
			Me.txtCrankRotation.Name = "txtCrankRotation"
			Me.txtCrankRotation.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtCrankRotation.Text = ""
			Me.txtCrankRotation.Top = 2.875F
			Me.txtCrankRotation.Width = 0.75F
			Me.txtCwtInfo_1.Height = 0.145F
			Me.txtCwtInfo_1.HyperLink = Nothing
			Me.txtCwtInfo_1.Left = 2F
			Me.txtCwtInfo_1.Name = "txtCwtInfo_1"
			Me.txtCwtInfo_1.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtCwtInfo_1.Text = ""
			Me.txtCwtInfo_1.Top = 3F
			Me.txtCwtInfo_1.Width = 0.75F
			Me.txtCwtInfo_2.Height = 0.145F
			Me.txtCwtInfo_2.HyperLink = Nothing
			Me.txtCwtInfo_2.Left = 2F
			Me.txtCwtInfo_2.Name = "txtCwtInfo_2"
			Me.txtCwtInfo_2.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtCwtInfo_2.Text = ""
			Me.txtCwtInfo_2.Top = 3.125F
			Me.txtCwtInfo_2.Width = 0.75F
			Me.txtCwtInfo_3.Height = 0.145F
			Me.txtCwtInfo_3.HyperLink = Nothing
			Me.txtCwtInfo_3.Left = 2F
			Me.txtCwtInfo_3.Name = "txtCwtInfo_3"
			Me.txtCwtInfo_3.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtCwtInfo_3.Text = ""
			Me.txtCwtInfo_3.Top = 3.25F
			Me.txtCwtInfo_3.Width = 0.75F
			Me.txtCwtInfo_4.Height = 0.145F
			Me.txtCwtInfo_4.HyperLink = Nothing
			Me.txtCwtInfo_4.Left = 2F
			Me.txtCwtInfo_4.Name = "txtCwtInfo_4"
			Me.txtCwtInfo_4.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtCwtInfo_4.Text = ""
			Me.txtCwtInfo_4.Top = 3.375F
			Me.txtCwtInfo_4.Width = 0.75F
			Me.txtCwtInfo_5.Height = 0.145F
			Me.txtCwtInfo_5.HyperLink = Nothing
			Me.txtCwtInfo_5.Left = 2F
			Me.txtCwtInfo_5.Name = "txtCwtInfo_5"
			Me.txtCwtInfo_5.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.txtCwtInfo_5.Text = ""
			Me.txtCwtInfo_5.Top = 3.5F
			Me.txtCwtInfo_5.Width = 0.75F
			Me.linRSCalcSep3.Height = 1.6F
			Me.linRSCalcSep3.Left = 6.0625F
			Me.linRSCalcSep3.LineWeight = 1F
			Me.linRSCalcSep3.Name = "linRSCalcSep3"
			Me.linRSCalcSep3.Top = 5.25F
			Me.linRSCalcSep3.Width = 0F
			Me.linRSCalcSep3.X1 = 6.0625F
			Me.linRSCalcSep3.X2 = 6.0625F
			Me.linRSCalcSep3.Y1 = 5.25F
			Me.linRSCalcSep3.Y2 = 6.85F
			Me.linRSCalcSep1.Height = 1.6F
			Me.linRSCalcSep1.Left = 4.3125F
			Me.linRSCalcSep1.LineWeight = 1F
			Me.linRSCalcSep1.Name = "linRSCalcSep1"
			Me.linRSCalcSep1.Top = 5.25F
			Me.linRSCalcSep1.Width = 0F
			Me.linRSCalcSep1.X1 = 4.3125F
			Me.linRSCalcSep1.X2 = 4.3125F
			Me.linRSCalcSep1.Y1 = 5.25F
			Me.linRSCalcSep1.Y2 = 6.85F
			Me.linRSCalcSep2.Height = 1.6F
			Me.linRSCalcSep2.Left = 5.1875F
			Me.linRSCalcSep2.LineWeight = 1F
			Me.linRSCalcSep2.Name = "linRSCalcSep2"
			Me.linRSCalcSep2.Top = 5.25F
			Me.linRSCalcSep2.Width = 0F
			Me.linRSCalcSep2.X1 = 5.1875F
			Me.linRSCalcSep2.X2 = 5.1875F
			Me.linRSCalcSep2.Y1 = 5.25F
			Me.linRSCalcSep2.Y2 = 6.85F
			Me.linRSCalcSep4.Height = 1.6F
			Me.linRSCalcSep4.Left = 7F
			Me.linRSCalcSep4.LineWeight = 1F
			Me.linRSCalcSep4.Name = "linRSCalcSep4"
			Me.linRSCalcSep4.Top = 5.25F
			Me.linRSCalcSep4.Width = 0F
			Me.linRSCalcSep4.X1 = 7F
			Me.linRSCalcSep4.X2 = 7F
			Me.linRSCalcSep4.Y1 = 5.25F
			Me.linRSCalcSep4.Y2 = 6.85F
			Me.lblUpstrokeFriction.Height = 0.145F
			Me.lblUpstrokeFriction.HyperLink = Nothing
			Me.lblUpstrokeFriction.Left = 1.75F
			Me.lblUpstrokeFriction.Name = "lblUpstrokeFriction"
			Me.lblUpstrokeFriction.Style = "font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblUpstrokeFriction.Text = "Upstr rod-fl. damp. coef."
			Me.lblUpstrokeFriction.Top = 4F
			Me.lblUpstrokeFriction.Width = 1.4375F
			Me.lblFricCoef1.Height = 0.125F
			Me.lblFricCoef1.HyperLink = Nothing
			Me.lblFricCoef1.Left = 3.3125F
			Me.lblFricCoef1.Name = "lblFricCoef1"
			Me.lblFricCoef1.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef1.Text = ""
			Me.lblFricCoef1.Top = 5.625F
			Me.lblFricCoef1.Width = 0.3125F
			Me.lblFricCoef2.Height = 0.125F
			Me.lblFricCoef2.HyperLink = Nothing
			Me.lblFricCoef2.Left = 3.3125F
			Me.lblFricCoef2.Name = "lblFricCoef2"
			Me.lblFricCoef2.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef2.Text = ""
			Me.lblFricCoef2.Top = 5.75F
			Me.lblFricCoef2.Width = 0.3125F
			Me.lblFricCoef3.Height = 0.125F
			Me.lblFricCoef3.HyperLink = Nothing
			Me.lblFricCoef3.Left = 3.3125F
			Me.lblFricCoef3.Name = "lblFricCoef3"
			Me.lblFricCoef3.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef3.Text = ""
			Me.lblFricCoef3.Top = 5.875F
			Me.lblFricCoef3.Width = 0.3125F
			Me.lblFricCoef4.Height = 0.125F
			Me.lblFricCoef4.HyperLink = Nothing
			Me.lblFricCoef4.Left = 3.3125F
			Me.lblFricCoef4.Name = "lblFricCoef4"
			Me.lblFricCoef4.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef4.Text = ""
			Me.lblFricCoef4.Top = 6F
			Me.lblFricCoef4.Width = 0.3125F
			Me.lblFricCoef5.Height = 0.125F
			Me.lblFricCoef5.HyperLink = Nothing
			Me.lblFricCoef5.Left = 3.3125F
			Me.lblFricCoef5.Name = "lblFricCoef5"
			Me.lblFricCoef5.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef5.Text = ""
			Me.lblFricCoef5.Top = 6.125F
			Me.lblFricCoef5.Width = 0.3125F
			Me.lblFricCoef6.Height = 0.125F
			Me.lblFricCoef6.HyperLink = Nothing
			Me.lblFricCoef6.Left = 3.3125F
			Me.lblFricCoef6.Name = "lblFricCoef6"
			Me.lblFricCoef6.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef6.Text = ""
			Me.lblFricCoef6.Top = 6.25F
			Me.lblFricCoef6.Width = 0.3125F
			Me.lblFricCoef7.Height = 0.125F
			Me.lblFricCoef7.HyperLink = Nothing
			Me.lblFricCoef7.Left = 3.3125F
			Me.lblFricCoef7.Name = "lblFricCoef7"
			Me.lblFricCoef7.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef7.Text = ""
			Me.lblFricCoef7.Top = 6.375F
			Me.lblFricCoef7.Width = 0.3125F
			Me.lblFricCoef8.Height = 0.125F
			Me.lblFricCoef8.HyperLink = Nothing
			Me.lblFricCoef8.Left = 3.3125F
			Me.lblFricCoef8.Name = "lblFricCoef8"
			Me.lblFricCoef8.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef8.Text = ""
			Me.lblFricCoef8.Top = 6.5F
			Me.lblFricCoef8.Width = 0.3125F
			Me.lblFric.Height = 0.145F
			Me.lblFric.HyperLink = Nothing
			Me.lblFric.Left = 3.3125F
			Me.lblFric.Name = "lblFric"
			Me.lblFric.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblFric.Text = " Fric."
			Me.lblFric.Top = 5.25F
			Me.lblFric.Width = 0.3125F
			Me.lblCoeff.Height = 0.145F
			Me.lblCoeff.HyperLink = Nothing
			Me.lblCoeff.Left = 3.3125F
			Me.lblCoeff.Name = "lblCoeff"
			Me.lblCoeff.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblCoeff.Text = "Coeff"
			Me.lblCoeff.Top = 5.375F
			Me.lblCoeff.Width = 0.3125F
			Me.lblPmBalancedE.Height = 0.125F
			Me.lblPmBalancedE.HyperLink = Nothing
			Me.lblPmBalancedE.Left = 5.6875F
			Me.lblPmBalancedE.Name = "lblPmBalancedE"
			Me.lblPmBalancedE.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblPmBalancedE.Text = "BALANCED"
			Me.lblPmBalancedE.Top = 1.475F
			Me.lblPmBalancedE.Width = 0.75F
			Me.lblRodDiam9.Height = 0.125F
			Me.lblRodDiam9.HyperLink = Nothing
			Me.lblRodDiam9.Left = 0.0625F
			Me.lblRodDiam9.Name = "lblRodDiam9"
			Me.lblRodDiam9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam9.Text = "Diam"
			Me.lblRodDiam9.Top = 6.625F
			Me.lblRodDiam9.Width = 0.625F
			Me.lblRodGrade9.Height = 0.125F
			Me.lblRodGrade9.HyperLink = Nothing
			Me.lblRodGrade9.Left = 0.8125F
			Me.lblRodGrade9.Name = "lblRodGrade9"
			Me.lblRodGrade9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade9.Text = "Grade"
			Me.lblRodGrade9.Top = 6.625F
			Me.lblRodGrade9.Width = 0.98F
			Me.lblRodLength9.Height = 0.125F
			Me.lblRodLength9.HyperLink = Nothing
			Me.lblRodLength9.Left = 1.875F
			Me.lblRodLength9.Name = "lblRodLength9"
			Me.lblRodLength9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength9.Text = "Len"
			Me.lblRodLength9.Top = 6.625F
			Me.lblRodLength9.Width = 0.4375F
			Me.lblRodTensileStrength9.Height = 0.125F
			Me.lblRodTensileStrength9.HyperLink = Nothing
			Me.lblRodTensileStrength9.Left = 2.4375F
			Me.lblRodTensileStrength9.Name = "lblRodTensileStrength9"
			Me.lblRodTensileStrength9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength9.Text = "TS"
			Me.lblRodTensileStrength9.Top = 6.625F
			Me.lblRodTensileStrength9.Width = 0.75F
			Me.lblFricCoef9.Height = 0.125F
			Me.lblFricCoef9.HyperLink = Nothing
			Me.lblFricCoef9.Left = 3.3125F
			Me.lblFricCoef9.Name = "lblFricCoef9"
			Me.lblFricCoef9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef9.Text = ""
			Me.lblFricCoef9.Top = 6.625F
			Me.lblFricCoef9.Width = 0.3125F
			Me.lblRodStress9.Height = 0.125F
			Me.lblRodStress9.HyperLink = Nothing
			Me.lblRodStress9.Left = 3.75F
			Me.lblRodStress9.Name = "lblRodStress9"
			Me.lblRodStress9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress9.Text = "Stress"
			Me.lblRodStress9.Top = 6.625F
			Me.lblRodStress9.Width = 0.5F
			Me.lblRodTopMaxStress9.Height = 0.125F
			Me.lblRodTopMaxStress9.HyperLink = Nothing
			Me.lblRodTopMaxStress9.Left = 4.375F
			Me.lblRodTopMaxStress9.Name = "lblRodTopMaxStress9"
			Me.lblRodTopMaxStress9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress9.Text = "Top Max"
			Me.lblRodTopMaxStress9.Top = 6.625F
			Me.lblRodTopMaxStress9.Width = 0.75F
			Me.lblRodTopMinStress9.Height = 0.125F
			Me.lblRodTopMinStress9.HyperLink = Nothing
			Me.lblRodTopMinStress9.Left = 5.25F
			Me.lblRodTopMinStress9.Name = "lblRodTopMinStress9"
			Me.lblRodTopMinStress9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress9.Text = "Top Min"
			Me.lblRodTopMinStress9.Top = 6.625F
			Me.lblRodTopMinStress9.Width = 0.75F
			Me.lblRodBotMinStress9.Height = 0.125F
			Me.lblRodBotMinStress9.HyperLink = Nothing
			Me.lblRodBotMinStress9.Left = 6.125F
			Me.lblRodBotMinStress9.Name = "lblRodBotMinStress9"
			Me.lblRodBotMinStress9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress9.Text = "Bot Min"
			Me.lblRodBotMinStress9.Top = 6.625F
			Me.lblRodBotMinStress9.Width = 0.8125F
			Me.lblRodStressMethod9.Height = 0.125F
			Me.lblRodStressMethod9.HyperLink = Nothing
			Me.lblRodStressMethod9.Left = 7.0625F
			Me.lblRodStressMethod9.Name = "lblRodStressMethod9"
			Me.lblRodStressMethod9.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod9.Text = "Stress Meth"
			Me.lblRodStressMethod9.Top = 6.625F
			Me.lblRodStressMethod9.Width = 0.8125F
			Me.lblRodDiam10.Height = 0.125F
			Me.lblRodDiam10.HyperLink = Nothing
			Me.lblRodDiam10.Left = 0.0625F
			Me.lblRodDiam10.Name = "lblRodDiam10"
			Me.lblRodDiam10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam10.Text = "Diam"
			Me.lblRodDiam10.Top = 6.75F
			Me.lblRodDiam10.Width = 0.625F
			Me.lblRodGrade10.Height = 0.125F
			Me.lblRodGrade10.HyperLink = Nothing
			Me.lblRodGrade10.Left = 0.8125F
			Me.lblRodGrade10.Name = "lblRodGrade10"
			Me.lblRodGrade10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade10.Text = "Grade"
			Me.lblRodGrade10.Top = 6.75F
			Me.lblRodGrade10.Width = 0.98F
			Me.lblRodLength10.Height = 0.125F
			Me.lblRodLength10.HyperLink = Nothing
			Me.lblRodLength10.Left = 1.875F
			Me.lblRodLength10.Name = "lblRodLength10"
			Me.lblRodLength10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength10.Text = "Len"
			Me.lblRodLength10.Top = 6.75F
			Me.lblRodLength10.Width = 0.4375F
			Me.lblRodTensileStrength10.Height = 0.125F
			Me.lblRodTensileStrength10.HyperLink = Nothing
			Me.lblRodTensileStrength10.Left = 2.4375F
			Me.lblRodTensileStrength10.Name = "lblRodTensileStrength10"
			Me.lblRodTensileStrength10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength10.Text = "TS"
			Me.lblRodTensileStrength10.Top = 6.75F
			Me.lblRodTensileStrength10.Width = 0.75F
			Me.lblFricCoef10.Height = 0.125F
			Me.lblFricCoef10.HyperLink = Nothing
			Me.lblFricCoef10.Left = 3.3125F
			Me.lblFricCoef10.Name = "lblFricCoef10"
			Me.lblFricCoef10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef10.Text = ""
			Me.lblFricCoef10.Top = 6.75F
			Me.lblFricCoef10.Width = 0.3125F
			Me.lblRodStress10.Height = 0.125F
			Me.lblRodStress10.HyperLink = Nothing
			Me.lblRodStress10.Left = 3.75F
			Me.lblRodStress10.Name = "lblRodStress10"
			Me.lblRodStress10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStress10.Text = "Stress"
			Me.lblRodStress10.Top = 6.75F
			Me.lblRodStress10.Width = 0.5F
			Me.lblRodTopMaxStress10.Height = 0.125F
			Me.lblRodTopMaxStress10.HyperLink = Nothing
			Me.lblRodTopMaxStress10.Left = 4.375F
			Me.lblRodTopMaxStress10.Name = "lblRodTopMaxStress10"
			Me.lblRodTopMaxStress10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress10.Text = "Top Max"
			Me.lblRodTopMaxStress10.Top = 6.75F
			Me.lblRodTopMaxStress10.Width = 0.75F
			Me.lblRodTopMinStress10.Height = 0.125F
			Me.lblRodTopMinStress10.HyperLink = Nothing
			Me.lblRodTopMinStress10.Left = 5.25F
			Me.lblRodTopMinStress10.Name = "lblRodTopMinStress10"
			Me.lblRodTopMinStress10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress10.Text = "Top Min"
			Me.lblRodTopMinStress10.Top = 6.75F
			Me.lblRodTopMinStress10.Width = 0.75F
			Me.lblRodBotMinStress10.Height = 0.125F
			Me.lblRodBotMinStress10.HyperLink = Nothing
			Me.lblRodBotMinStress10.Left = 6.125F
			Me.lblRodBotMinStress10.Name = "lblRodBotMinStress10"
			Me.lblRodBotMinStress10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress10.Text = "Bot Min"
			Me.lblRodBotMinStress10.Top = 6.75F
			Me.lblRodBotMinStress10.Width = 0.8125F
			Me.lblRodStressMethod10.Height = 0.125F
			Me.lblRodStressMethod10.HyperLink = Nothing
			Me.lblRodStressMethod10.Left = 7.0625F
			Me.lblRodStressMethod10.Name = "lblRodStressMethod10"
			Me.lblRodStressMethod10.Style = "font-family: MS Sans Serif; font-size: 7.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod10.Text = "Stress Meth"
			Me.lblRodStressMethod10.Top = 6.75F
			Me.lblRodStressMethod10.Width = 0.8125F
			Me.picDyno.BackColor = Color.FromArgb(255, 255, 255)
			Me.picDyno.Height = 2.5F
			Me.picDyno.ImageData = Nothing
			Me.picDyno.Left = 0.437F
			Me.picDyno.LineColor = Color.FromArgb(255, 255, 255)
			Me.picDyno.Name = "picDyno"
			Me.picDyno.SizeMode = SizeModes.Stretch
			Me.picDyno.Top = 7.565001F
			Me.picDyno.Width = 3.563F
			Me.picTorquePlot.BackColor = Color.FromArgb(255, 255, 255)
			Me.picTorquePlot.Height = 2.5F
			Me.picTorquePlot.ImageData = Nothing
			Me.picTorquePlot.Left = 4.125F
			Me.picTorquePlot.LineColor = Color.FromArgb(255, 255, 255)
			Me.picTorquePlot.Name = "picTorquePlot"
			Me.picTorquePlot.SizeMode = SizeModes.Stretch
			Me.picTorquePlot.Top = 7.565001F
			Me.picTorquePlot.Width = 3.563F
			Me.Line15.Height = 0F
			Me.Line15.Left = 0.4375F
			Me.Line15.LineColor = Color.FromArgb(169, 169, 169)
			Me.Line15.LineWeight = 1F
			Me.Line15.Name = "Line15"
			Me.Line15.Top = 7.5625F
			Me.Line15.Width = 3.563F
			Me.Line15.X1 = 0.4375F
			Me.Line15.X2 = 4.0005F
			Me.Line15.Y1 = 7.5625F
			Me.Line15.Y2 = 7.5625F
			Me.Line16.Height = 0F
			Me.Line16.Left = 4.1255F
			Me.Line16.LineColor = Color.FromArgb(169, 169, 169)
			Me.Line16.LineWeight = 1F
			Me.Line16.Name = "Line16"
			Me.Line16.Top = 7.569445F
			Me.Line16.Width = 3.563F
			Me.Line16.X1 = 4.1255F
			Me.Line16.X2 = 7.6885F
			Me.Line16.Y1 = 7.569445F
			Me.Line16.Y2 = 7.569445F
			Me.lblNoResults.Height = 0.145F
			Me.lblNoResults.HyperLink = Nothing
			Me.lblNoResults.Left = 3.75F
			Me.lblNoResults.Name = "lblNoResults"
			Me.lblNoResults.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblNoResults.Text = "The calculations have not been run for this case."
			Me.lblNoResults.Top = 0.365F
			Me.lblNoResults.Width = 3.625F
			Me.lblSystemEff.Height = 0.145F
			Me.lblSystemEff.HyperLink = Nothing
			Me.lblSystemEff.Left = 3.75F
			Me.lblSystemEff.Name = "lblSystemEff"
			Me.lblSystemEff.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblSystemEff.Text = "System efficiency"
			Me.lblSystemEff.Top = 0.7600001F
			Me.lblSystemEff.Width = 1.75F
			Me.txtStructLoading.Height = 0.145F
			Me.txtStructLoading.HyperLink = Nothing
			Me.txtStructLoading.Left = 7.4375F
			Me.txtStructLoading.Name = "txtStructLoading"
			Me.txtStructLoading.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtStructLoading.Text = ""
			Me.txtStructLoading.Top = 0.7600001F
			Me.txtStructLoading.Width = 0.5625F
			Me.txtBPDSurface.Height = 0.145F
			Me.txtBPDSurface.HyperLink = Nothing
			Me.txtBPDSurface.Left = 5.5F
			Me.txtBPDSurface.Name = "txtBPDSurface"
			Me.txtBPDSurface.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtBPDSurface.Text = " "
			Me.txtBPDSurface.Top = 0.365F
			Me.txtBPDSurface.Width = 0.5625F
			Me.txtPermLoadHP.Height = 0.145F
			Me.txtPermLoadHP.HyperLink = Nothing
			Me.txtPermLoadHP.Left = 5.5F
			Me.txtPermLoadHP.Name = "txtPermLoadHP"
			Me.txtPermLoadHP.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtPermLoadHP.Text = " "
			Me.txtPermLoadHP.Top = 0.8850001F
			Me.txtPermLoadHP.Width = 0.5625F
			Me.txtSystemEff.Height = 0.145F
			Me.txtSystemEff.HyperLink = Nothing
			Me.txtSystemEff.Left = 5.5F
			Me.txtSystemEff.Name = "txtSystemEff"
			Me.txtSystemEff.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtSystemEff.Text = " "
			Me.txtSystemEff.Top = 0.7600001F
			Me.txtSystemEff.Width = 0.5625F
			Me.txtFluidLoad.Height = 0.145F
			Me.txtFluidLoad.HyperLink = Nothing
			Me.txtFluidLoad.Left = 5.5F
			Me.txtFluidLoad.Name = "txtFluidLoad"
			Me.txtFluidLoad.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtFluidLoad.Text = " "
			Me.txtFluidLoad.Top = 1.01F
			Me.txtFluidLoad.Width = 0.5625F
			Me.txtCalcSPM.Height = 0.145F
			Me.txtCalcSPM.HyperLink = Nothing
			Me.txtCalcSPM.Left = 5.5F
			Me.txtCalcSPM.Name = "txtCalcSPM"
			Me.txtCalcSPM.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtCalcSPM.Text = ""
			Me.txtCalcSPM.Top = 0.625F
			Me.txtCalcSPM.Width = 0.5625F
			Me.txtOilProduction.Height = 0.145F
			Me.txtOilProduction.HyperLink = Nothing
			Me.txtOilProduction.Left = 5.5F
			Me.txtOilProduction.Name = "txtOilProduction"
			Me.txtOilProduction.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtOilProduction.Text = ""
			Me.txtOilProduction.Top = 0.49F
			Me.txtOilProduction.Width = 0.5625F
			Me.lblFluidLoad.Height = 0.145F
			Me.lblFluidLoad.HyperLink = Nothing
			Me.lblFluidLoad.Left = 3.75F
			Me.lblFluidLoad.Name = "lblFluidLoad"
			Me.lblFluidLoad.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblFluidLoad.Text = "Fluid load"
			Me.lblFluidLoad.Top = 1.01F
			Me.lblFluidLoad.Width = 1.75F
			Me.lblPermLoadHP.Height = 0.145F
			Me.lblPermLoadHP.HyperLink = Nothing
			Me.lblPermLoadHP.Left = 3.75F
			Me.lblPermLoadHP.Name = "lblPermLoadHP"
			Me.lblPermLoadHP.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblPermLoadHP.Text = "Permissible Load HP"
			Me.lblPermLoadHP.Top = 0.8850001F
			Me.lblPermLoadHP.Width = 1.75F
			Me.lblCalcSPM.Height = 0.145F
			Me.lblCalcSPM.HyperLink = Nothing
			Me.lblCalcSPM.Left = 3.75F
			Me.lblCalcSPM.Name = "lblCalcSPM"
			Me.lblCalcSPM.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblCalcSPM.Text = "Pumping speed"
			Me.lblCalcSPM.Top = 0.625F
			Me.lblCalcSPM.Width = 1.725F
			Me.lblOilProduction.Height = 0.145F
			Me.lblOilProduction.HyperLink = Nothing
			Me.lblOilProduction.Left = 3.75F
			Me.lblOilProduction.Name = "lblOilProduction"
			Me.lblOilProduction.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblOilProduction.Text = "Oil production"
			Me.lblOilProduction.Top = 0.49F
			Me.lblOilProduction.Width = 1.725F
			Me.lblBPDSurface.Height = 0.145F
			Me.lblBPDSurface.HyperLink = Nothing
			Me.lblBPDSurface.Left = 3.75F
			Me.lblBPDSurface.Name = "lblBPDSurface"
			Me.lblBPDSurface.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblBPDSurface.Text = "Production rate"
			Me.lblBPDSurface.Top = 0.365F
			Me.lblBPDSurface.Width = 1.75F
			Me.lblPrhpPlhp.Height = 0.145F
			Me.lblPrhpPlhp.HyperLink = Nothing
			Me.lblPrhpPlhp.Left = 6.125F
			Me.lblPrhpPlhp.Name = "lblPrhpPlhp"
			Me.lblPrhpPlhp.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblPrhpPlhp.Text = "PRHP / PLHP"
			Me.lblPrhpPlhp.Top = 0.8850001F
			Me.lblPrhpPlhp.Width = 1.3F
			Me.lblStructLoading.Height = 0.145F
			Me.lblStructLoading.HyperLink = Nothing
			Me.lblStructLoading.Left = 6.125F
			Me.lblStructLoading.Name = "lblStructLoading"
			Me.lblStructLoading.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblStructLoading.Text = "Structural loading"
			Me.lblStructLoading.Top = 0.7600001F
			Me.lblStructLoading.Width = 1.3F
			Me.lblPRHP.Height = 0.145F
			Me.lblPRHP.HyperLink = Nothing
			Me.lblPRHP.Left = 3.75F
			Me.lblPRHP.Name = "lblPRHP"
			Me.lblPRHP.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblPRHP.Text = "Polished rod HP"
			Me.lblPRHP.Top = 1.26F
			Me.lblPRHP.Width = 1.75F
			Me.lblMPRL.Height = 0.145F
			Me.lblMPRL.HyperLink = Nothing
			Me.lblMPRL.Left = 6.125F
			Me.lblMPRL.Name = "lblMPRL"
			Me.lblMPRL.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMPRL.Text = "Min. polished rod load"
			Me.lblMPRL.Top = 0.49F
			Me.lblMPRL.Width = 1.3F
			Me.lblPPRL.Height = 0.145F
			Me.lblPPRL.HyperLink = Nothing
			Me.lblPPRL.Left = 6.125F
			Me.lblPPRL.Name = "lblPPRL"
			Me.lblPPRL.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblPPRL.Text = "Peak polished rod load"
			Me.lblPPRL.Top = 0.365F
			Me.lblPPRL.Width = 1.3F
			Me.lblNoverNo.Height = 0.145F
			Me.lblNoverNo.HyperLink = Nothing
			Me.lblNoverNo.Left = 6.125F
			Me.lblNoverNo.Name = "lblNoverNo"
			Me.lblNoverNo.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblNoverNo.Text = "N/No', Fo/SKr"
			Me.lblNoverNo.Top = 1.135F
			Me.lblNoverNo.Width = 1.875F
			Me.txtRodWeight.Height = 0.145F
			Me.txtRodWeight.HyperLink = Nothing
			Me.txtRodWeight.Left = 7.4375F
			Me.txtRodWeight.Name = "txtRodWeight"
			Me.txtRodWeight.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtRodWeight.Text = " "
			Me.txtRodWeight.Top = 1.01F
			Me.txtRodWeight.Width = 0.5625F
			Me.txtPrhpPlhp.Height = 0.145F
			Me.txtPrhpPlhp.HyperLink = Nothing
			Me.txtPrhpPlhp.Left = 7.4375F
			Me.txtPrhpPlhp.Name = "txtPrhpPlhp"
			Me.txtPrhpPlhp.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtPrhpPlhp.Text = ""
			Me.txtPrhpPlhp.Top = 0.8850001F
			Me.txtPrhpPlhp.Width = 0.5625F
			Me.txtMPRL.Height = 0.145F
			Me.txtMPRL.HyperLink = Nothing
			Me.txtMPRL.Left = 7.4375F
			Me.txtMPRL.Name = "txtMPRL"
			Me.txtMPRL.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtMPRL.Text = " "
			Me.txtMPRL.Top = 0.49F
			Me.txtMPRL.Width = 0.5625F
			Me.txtPPRL.Height = 0.145F
			Me.txtPPRL.HyperLink = Nothing
			Me.txtPPRL.Left = 7.4375F
			Me.txtPPRL.Name = "txtPPRL"
			Me.txtPPRL.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtPPRL.Text = " "
			Me.txtPPRL.Top = 0.365F
			Me.txtPPRL.Width = 0.5625F
			Me.linRSInputSep2.Height = 1.6F
			Me.linRSInputSep2.Left = 1.8125F
			Me.linRSInputSep2.LineWeight = 1F
			Me.linRSInputSep2.Name = "linRSInputSep2"
			Me.linRSInputSep2.Top = 5.25F
			Me.linRSInputSep2.Width = 0F
			Me.linRSInputSep2.X1 = 1.8125F
			Me.linRSInputSep2.X2 = 1.8125F
			Me.linRSInputSep2.Y1 = 5.25F
			Me.linRSInputSep2.Y2 = 6.85F
			Me.lblRodWeight.Height = 0.145F
			Me.lblRodWeight.HyperLink = Nothing
			Me.lblRodWeight.Left = 6.125F
			Me.lblRodWeight.Name = "lblRodWeight"
			Me.lblRodWeight.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblRodWeight.Text = "Buoyant rod weight"
			Me.lblRodWeight.Top = 1.01F
			Me.lblRodWeight.Width = 1.3F
			Me.lblCBE.Height = 0.145F
			Me.lblCBE.HyperLink = Nothing
			Me.lblCBE.Left = 3.75F
			Me.lblCBE.Name = "lblCBE"
			Me.lblCBE.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCBE.Text = "Counterbalance effect"
			Me.lblCBE.Top = 3.125F
			Me.lblCBE.Width = 1.875F
			Me.lblMCM.Height = 0.145F
			Me.lblMCM.HyperLink = Nothing
			Me.lblMCM.Left = 3.75F
			Me.lblMCM.Name = "lblMCM"
			Me.lblMCM.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblMCM.Text = "Max CB moment"
			Me.lblMCM.Top = 3F
			Me.lblMCM.Width = 1.875F
			Me.lblCLF.Height = 0.145F
			Me.lblCLF.HyperLink = Nothing
			Me.lblCLF.Left = 3.75F
			Me.lblCLF.Name = "lblCLF"
			Me.lblCLF.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblCLF.Text = "Cyclic load factor:"
			Me.lblCLF.Top = 2.875F
			Me.lblCLF.Width = 1.875F
			Me.lblFluidLevelTVD.Height = 0.145F
			Me.lblFluidLevelTVD.HyperLink = Nothing
			Me.lblFluidLevelTVD.Left = 3.75F
			Me.lblFluidLevelTVD.Name = "lblFluidLevelTVD"
			Me.lblFluidLevelTVD.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblFluidLevelTVD.Text = "TVD Fluid level"
			Me.lblFluidLevelTVD.Top = 1.135F
			Me.lblFluidLevelTVD.Width = 1.75F
			Me.txtPRHP.Height = 0.145F
			Me.txtPRHP.HyperLink = Nothing
			Me.txtPRHP.Left = 5.5F
			Me.txtPRHP.Name = "txtPRHP"
			Me.txtPRHP.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtPRHP.Text = ""
			Me.txtPRHP.Top = 1.26F
			Me.txtPRHP.Width = 0.5625F
			Me.txtFluidLevelTVD.Height = 0.145F
			Me.txtFluidLevelTVD.HyperLink = Nothing
			Me.txtFluidLevelTVD.Left = 5.5F
			Me.txtFluidLevelTVD.Name = "txtFluidLevelTVD"
			Me.txtFluidLevelTVD.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtFluidLevelTVD.Text = " "
			Me.txtFluidLevelTVD.Top = 1.135F
			Me.txtFluidLevelTVD.Width = 0.5625F
			Me.lblPolRodDiam.Height = 0.145F
			Me.lblPolRodDiam.HyperLink = Nothing
			Me.lblPolRodDiam.Left = 1.875F
			Me.lblPolRodDiam.Name = "lblPolRodDiam"
			Me.lblPolRodDiam.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblPolRodDiam.Text = "Pol. Rod Diam"
			Me.lblPolRodDiam.Top = 0.9350001F
			Me.lblPolRodDiam.Width = 0.8125F
			Me.txtPolRodDiam.Height = 0.145F
			Me.txtPolRodDiam.HyperLink = Nothing
			Me.txtPolRodDiam.Left = 2.688F
			Me.txtPolRodDiam.Name = "txtPolRodDiam"
			Me.txtPolRodDiam.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtPolRodDiam.Text = ""
			Me.txtPolRodDiam.Top = 0.9350001F
			Me.txtPolRodDiam.Width = 0.9369998F
			Me.lblRSFootnote5.Height = 0.115F
			Me.lblRSFootnote5.HyperLink = Nothing
			Me.lblRSFootnote5.Left = 0.0625F
			Me.lblRSFootnote5.Name = "lblRSFootnote5"
			Me.lblRSFootnote5.Style = "font-size: 6pt"
			Me.lblRSFootnote5.Text = ""
			Me.lblRSFootnote5.Top = 7.391F
			Me.lblRSFootnote5.Width = 7.75F
			Me.lblRSFootnote4.Height = 0.115F
			Me.lblRSFootnote4.HyperLink = Nothing
			Me.lblRSFootnote4.Left = 0.062F
			Me.lblRSFootnote4.Name = "lblRSFootnote4"
			Me.lblRSFootnote4.Style = "font-size: 6pt"
			Me.lblRSFootnote4.Text = ""
			Me.lblRSFootnote4.Top = 7.286F
			Me.lblRSFootnote4.Width = 7.75F
			Me.lblRSFootnote3.Height = 0.115F
			Me.lblRSFootnote3.HyperLink = Nothing
			Me.lblRSFootnote3.Left = 0.0625F
			Me.lblRSFootnote3.Name = "lblRSFootnote3"
			Me.lblRSFootnote3.Style = "font-size: 6pt"
			Me.lblRSFootnote3.Text = ""
			Me.lblRSFootnote3.Top = 7.171F
			Me.lblRSFootnote3.Width = 7.75F
			Me.lblRSFootnote2.Height = 0.115F
			Me.lblRSFootnote2.HyperLink = Nothing
			Me.lblRSFootnote2.Left = 0.0625F
			Me.lblRSFootnote2.Name = "lblRSFootnote2"
			Me.lblRSFootnote2.Style = "font-size: 6pt"
			Me.lblRSFootnote2.Text = ""
			Me.lblRSFootnote2.Top = 7.054F
			Me.lblRSFootnote2.Width = 7.75F
			Me.lblRSFootnote1.Height = 0.115F
			Me.lblRSFootnote1.HyperLink = Nothing
			Me.lblRSFootnote1.Left = 0.0625F
			Me.lblRSFootnote1.Name = "lblRSFootnote1"
			Me.lblRSFootnote1.Style = "font-size: 6pt"
			Me.lblRSFootnote1.Text = ""
			Me.lblRSFootnote1.Top = 6.935F
			Me.lblRSFootnote1.Width = 7.75F
			Me.lblGearboxLoading.Height = 0.145F
			Me.lblGearboxLoading.HyperLink = Nothing
			Me.lblGearboxLoading.Left = 3.75F
			Me.lblGearboxLoading.Name = "lblGearboxLoading"
			Me.lblGearboxLoading.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblGearboxLoading.Text = "Gearbox loading:"
			Me.lblGearboxLoading.Top = 2.75F
			Me.lblGearboxLoading.Width = 1.875F
			Me.lblPeakTorque.Height = 0.145F
			Me.lblPeakTorque.HyperLink = Nothing
			Me.lblPeakTorque.Left = 3.75F
			Me.lblPeakTorque.Name = "lblPeakTorque"
			Me.lblPeakTorque.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblPeakTorque.Text = "Peak torque"
			Me.lblPeakTorque.Top = 2.625F
			Me.lblPeakTorque.Width = 1.875F
			Me.txtParaffinDepth.Height = 0.145F
			Me.txtParaffinDepth.HyperLink = Nothing
			Me.txtParaffinDepth.Left = 1.25F
			Me.txtParaffinDepth.Name = "txtParaffinDepth"
			Me.txtParaffinDepth.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtParaffinDepth.Text = ""
			Me.txtParaffinDepth.Top = 0.9350001F
			Me.txtParaffinDepth.Visible = False
			Me.txtParaffinDepth.Width = 0.5625F
			Me.lblParaffinDepth.Height = 0.145F
			Me.lblParaffinDepth.HyperLink = Nothing
			Me.lblParaffinDepth.Left = 0.0625F
			Me.lblParaffinDepth.Name = "lblParaffinDepth"
			Me.lblParaffinDepth.Style = "font-family: Arial; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblParaffinDepth.Text = "Paraffin acc. depth"
			Me.lblParaffinDepth.Top = 0.9350001F
			Me.lblParaffinDepth.Visible = False
			Me.lblParaffinDepth.Width = 1.1875F
			Me.PageHeader.Controls.AddRange(New ARControl() { Me.lblComment, Me.lblTitle1, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserName, Me.lblUserDate, Me.lblLabel2, Me.lblCompany, Me.lblWellName, Me.lblDiskFile, Me.lblSecondCompanyName, Me.lblSecondCompanyPhonenumber, Me.lblGoTheta })
			Me.PageHeader.Height = 1.0125F
			Me.PageHeader.Name = "PageHeader"
			Me.lblComment.Height = 0.315F
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
			Me.PageFooter.Height = 0F
			Me.PageFooter.Name = "PageFooter"
			Me.MasterReport = False
			Me.PageSettings.Margins.Bottom = 0F
			Me.PageSettings.Margins.Left = 0F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0.05F
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
			Me.StyleSheet.Add(New StyleSheetRule("", "Heading4", "Normal"))
			CType(Me.txtMPRLPPRL, ISupportInitialize).EndInit()
			CType(Me.lblMPRLPPRL, ISupportInitialize).EndInit()
			CType(Me.lblMotorSPVHdr, ISupportInitialize).EndInit()
			CType(Me.lblMotorSPV, ISupportInitialize).EndInit()
			CType(Me.lblNEMAD, ISupportInitialize).EndInit()
			CType(Me.lblInputData, ISupportInitialize).EndInit()
			CType(Me.lblCalculatedResults, ISupportInitialize).EndInit()
			CType(Me.lblRuntime, ISupportInitialize).EndInit()
			CType(Me.lblFLPIP_2, ISupportInitialize).EndInit()
			CType(Me.lblFLPIP_1, ISupportInitialize).EndInit()
			CType(Me.lblCasingPressure, ISupportInitialize).EndInit()
			CType(Me.lblStuffingBoxFriction, ISupportInitialize).EndInit()
			CType(Me.lblFluidPropertiesHeader, ISupportInitialize).EndInit()
			CType(Me.lblMotorHeader, ISupportInitialize).EndInit()
			CType(Me.lblPowerMeter, ISupportInitialize).EndInit()
			CType(Me.lblWaterCut, ISupportInitialize).EndInit()
			CType(Me.lblWaterSPGR, ISupportInitialize).EndInit()
			CType(Me.lblElectricityCost, ISupportInitialize).EndInit()
			CType(Me.lblMotorType, ISupportInitialize).EndInit()
			CType(Me.lblMotorSize, ISupportInitialize).EndInit()
			CType(Me.lblMotorSetting, ISupportInitialize).EndInit()
			CType(Me.lblOilSPGR, ISupportInitialize).EndInit()
			CType(Me.lblFluidSPGR, ISupportInitialize).EndInit()
			CType(Me.lblCompressibilityIndex, ISupportInitialize).EndInit()
			CType(Me.lblPumpingUnitHeader, ISupportInitialize).EndInit()
			CType(Me.lblAPIDesignation, ISupportInitialize).EndInit()
			CType(Me.lblCrankHole, ISupportInitialize).EndInit()
			CType(Me.lblPUDimR, ISupportInitialize).EndInit()
			CType(Me.lblPUDimA, ISupportInitialize).EndInit()
			CType(Me.lblPUDimC, ISupportInitialize).EndInit()
			CType(Me.lblPUDimI, ISupportInitialize).EndInit()
			CType(Me.lblPUDimK, ISupportInitialize).EndInit()
			CType(Me.lblPUDimP, ISupportInitialize).EndInit()
			CType(Me.lblPUDimM, ISupportInitialize).EndInit()
			CType(Me.lblPUDimV0, ISupportInitialize).EndInit()
			CType(Me.lblPUDimS, ISupportInitialize).EndInit()
			CType(Me.lblStrokeLength, ISupportInitialize).EndInit()
			CType(Me.lblCrankRotation, ISupportInitialize).EndInit()
			CType(Me.lblCwtInfo_1, ISupportInitialize).EndInit()
			CType(Me.lblCwtInfo_2, ISupportInitialize).EndInit()
			CType(Me.lblCwtInfo_3, ISupportInitialize).EndInit()
			CType(Me.lblCwtInfo_4, ISupportInitialize).EndInit()
			CType(Me.lblCwtInfo_5, ISupportInitialize).EndInit()
			CType(Me.lblCBDataFile, ISupportInitialize).EndInit()
			CType(Me.lblPumpTubingHeader, ISupportInitialize).EndInit()
			CType(Me.lblTubingOD, ISupportInitialize).EndInit()
			CType(Me.lblTubingID, ISupportInitialize).EndInit()
			CType(Me.lblPlungerSize, ISupportInitialize).EndInit()
			CType(Me.lblRodStringDesign, ISupportInitialize).EndInit()
			CType(Me.lblTqMinEner, ISupportInitialize).EndInit()
			CType(Me.lblPeakTorque_BE, ISupportInitialize).EndInit()
			CType(Me.lblGearboxLoading_BE, ISupportInitialize).EndInit()
			CType(Me.lblCLF_BE, ISupportInitialize).EndInit()
			CType(Me.lblMCM_BE, ISupportInitialize).EndInit()
			CType(Me.lblCBE_BE, ISupportInitialize).EndInit()
			CType(Me.lblMotorKWH_BE, ISupportInitialize).EndInit()
			CType(Me.lblElectricBillPerMonth_BE, ISupportInitialize).EndInit()
			CType(Me.lblDollarsPerBblFluid_BE, ISupportInitialize).EndInit()
			CType(Me.lblDollarsPerBblOil_BE, ISupportInitialize).EndInit()
			CType(Me.lblTqMinTorq, ISupportInitialize).EndInit()
			CType(Me.lblPeakTorque_BT, ISupportInitialize).EndInit()
			CType(Me.lblGearboxLoading_BT, ISupportInitialize).EndInit()
			CType(Me.lblCLF_BT, ISupportInitialize).EndInit()
			CType(Me.lblMCM_BT, ISupportInitialize).EndInit()
			CType(Me.lblCBE_BT, ISupportInitialize).EndInit()
			CType(Me.lblMotorKWH_BT, ISupportInitialize).EndInit()
			CType(Me.lblElectricBillPerMonth_BT, ISupportInitialize).EndInit()
			CType(Me.lblDollarsPerBblFluid_BT, ISupportInitialize).EndInit()
			CType(Me.lblDollarsPerBblOil_BT, ISupportInitialize).EndInit()
			CType(Me.lblTqExisting, ISupportInitialize).EndInit()
			CType(Me.lblPeakTorque_E, ISupportInitialize).EndInit()
			CType(Me.lblGearboxLoading_E, ISupportInitialize).EndInit()
			CType(Me.lblCLF_E, ISupportInitialize).EndInit()
			CType(Me.lblMCM_E, ISupportInitialize).EndInit()
			CType(Me.lblCBE_E, ISupportInitialize).EndInit()
			CType(Me.lblMotorKWH_E, ISupportInitialize).EndInit()
			CType(Me.lblElectricBillPerMonth_E, ISupportInitialize).EndInit()
			CType(Me.lblDollarsPerBblFluid_E, ISupportInitialize).EndInit()
			CType(Me.lblDollarsPerBblOil_E, ISupportInitialize).EndInit()
			CType(Me.lblPmMinEner, ISupportInitialize).EndInit()
			CType(Me.lblNEMAD_BE, ISupportInitialize).EndInit()
			CType(Me.lblSingleCyl_BE, ISupportInitialize).EndInit()
			CType(Me.lblMultiCyl_BE, ISupportInitialize).EndInit()
			CType(Me.lblPmMinTorq, ISupportInitialize).EndInit()
			CType(Me.lblNEMAD_BT, ISupportInitialize).EndInit()
			CType(Me.lblSingleCyl_BT, ISupportInitialize).EndInit()
			CType(Me.lblMultiCyl_BT, ISupportInitialize).EndInit()
			CType(Me.lblPmExisting, ISupportInitialize).EndInit()
			CType(Me.lblNEMAD_E, ISupportInitialize).EndInit()
			CType(Me.lblSingleCyl_E, ISupportInitialize).EndInit()
			CType(Me.lblMultiCyl_E, ISupportInitialize).EndInit()
			CType(Me.lblMultiCyl, ISupportInitialize).EndInit()
			CType(Me.lblElectricityConsumption, ISupportInitialize).EndInit()
			CType(Me.lblTubingCalculations, ISupportInitialize).EndInit()
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
			CType(Me.lblFLPIP_3, ISupportInitialize).EndInit()
			CType(Me.lblSPM, ISupportInitialize).EndInit()
			CType(Me.lblPlungerLength, ISupportInitialize).EndInit()
			CType(Me.lblPumpLength, ISupportInitialize).EndInit()
			CType(Me.lblPumpSpacing, ISupportInitialize).EndInit()
			CType(Me.lblGrossPumpStroke, ISupportInitialize).EndInit()
			CType(Me.lblProductionLoss, ISupportInitialize).EndInit()
			CType(Me.lblTubingStretch, ISupportInitialize).EndInit()
			CType(Me.lblPumpFriction, ISupportInitialize).EndInit()
			CType(Me.lblPumpEfficiency, ISupportInitialize).EndInit()
			CType(Me.lblPumpLoadAdj, ISupportInitialize).EndInit()
			CType(Me.lblTubingAnchorDepth, ISupportInitialize).EndInit()
			CType(Me.lblDownstrokeFriction, ISupportInitialize).EndInit()
			CType(Me.lblPumpType, ISupportInitialize).EndInit()
			CType(Me.lblPumpCondition, ISupportInitialize).EndInit()
			CType(Me.lblPumpDepth, ISupportInitialize).EndInit()
			CType(Me.lblDollarsPerBblOil, ISupportInitialize).EndInit()
			CType(Me.lblDollarsPerBblFluid, ISupportInitialize).EndInit()
			CType(Me.lblElectricBillPerMonth, ISupportInitialize).EndInit()
			CType(Me.lblTorqueAnalysis, ISupportInitialize).EndInit()
			CType(Me.lblSingleCyl, ISupportInitialize).EndInit()
			CType(Me.lblMotorKWH, ISupportInitialize).EndInit()
			CType(Me.lblTubingPressure, ISupportInitialize).EndInit()
			CType(Me.lblReqPrimeMoverSize, ISupportInitialize).EndInit()
			CType(Me.lblRodGradeHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStressHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStressHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethodHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStressHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodStressHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrengthHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodLengthHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblPmBalancedT, ISupportInitialize).EndInit()
			CType(Me.lblTqBalancedT, ISupportInitialize).EndInit()
			CType(Me.lblTqBalancedE, ISupportInitialize).EndInit()
			CType(Me.txtPlungerLength, ISupportInitialize).EndInit()
			CType(Me.txtPumpLength, ISupportInitialize).EndInit()
			CType(Me.txtPumpSpacing, ISupportInitialize).EndInit()
			CType(Me.txtGrossPumpStroke, ISupportInitialize).EndInit()
			CType(Me.txtProductionLoss, ISupportInitialize).EndInit()
			CType(Me.txtTubingStretch, ISupportInitialize).EndInit()
			CType(Me.txtTubingOD, ISupportInitialize).EndInit()
			CType(Me.txtTubingID, ISupportInitialize).EndInit()
			CType(Me.txtPlungerSize, ISupportInitialize).EndInit()
			CType(Me.txtPumpType, ISupportInitialize).EndInit()
			CType(Me.txtPumpCondition, ISupportInitialize).EndInit()
			CType(Me.txtPumpDepth, ISupportInitialize).EndInit()
			CType(Me.txtUpstrokeFriction, ISupportInitialize).EndInit()
			CType(Me.txtDownstrokeFriction, ISupportInitialize).EndInit()
			CType(Me.txtPumpFriction, ISupportInitialize).EndInit()
			CType(Me.txtPumpLoadAdj, ISupportInitialize).EndInit()
			CType(Me.txtTubingAnchorDepth, ISupportInitialize).EndInit()
			CType(Me.txtPumpEfficiency, ISupportInitialize).EndInit()
			CType(Me.txtPowerMeter, ISupportInitialize).EndInit()
			CType(Me.txtElectricityCost, ISupportInitialize).EndInit()
			CType(Me.txtMotorType, ISupportInitialize).EndInit()
			CType(Me.txtMotorSize, ISupportInitialize).EndInit()
			CType(Me.txtMotorSetting, ISupportInitialize).EndInit()
			CType(Me.txtWaterCut, ISupportInitialize).EndInit()
			CType(Me.txtWaterSPGR, ISupportInitialize).EndInit()
			CType(Me.txtOilSPGR, ISupportInitialize).EndInit()
			CType(Me.txtFluidSPGR, ISupportInitialize).EndInit()
			CType(Me.txtCompressibilityIndex, ISupportInitialize).EndInit()
			CType(Me.txtSPM, ISupportInitialize).EndInit()
			CType(Me.txtRuntime, ISupportInitialize).EndInit()
			CType(Me.txtTubingPressure, ISupportInitialize).EndInit()
			CType(Me.txtCasingPressure, ISupportInitialize).EndInit()
			CType(Me.txtFLPIP_1, ISupportInitialize).EndInit()
			CType(Me.txtFLPIP_2, ISupportInitialize).EndInit()
			CType(Me.txtFLPIP_3, ISupportInitialize).EndInit()
			CType(Me.txtStuffingBoxFriction, ISupportInitialize).EndInit()
			CType(Me.txtCrankHole, ISupportInitialize).EndInit()
			CType(Me.txtStrokeLength, ISupportInitialize).EndInit()
			CType(Me.txtCrankRotation, ISupportInitialize).EndInit()
			CType(Me.txtCwtInfo_1, ISupportInitialize).EndInit()
			CType(Me.txtCwtInfo_2, ISupportInitialize).EndInit()
			CType(Me.txtCwtInfo_3, ISupportInitialize).EndInit()
			CType(Me.txtCwtInfo_4, ISupportInitialize).EndInit()
			CType(Me.txtCwtInfo_5, ISupportInitialize).EndInit()
			CType(Me.lblUpstrokeFriction, ISupportInitialize).EndInit()
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
			CType(Me.lblPmBalancedE, ISupportInitialize).EndInit()
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
			CType(Me.picDyno, ISupportInitialize).EndInit()
			CType(Me.picTorquePlot, ISupportInitialize).EndInit()
			CType(Me.lblNoResults, ISupportInitialize).EndInit()
			CType(Me.lblSystemEff, ISupportInitialize).EndInit()
			CType(Me.txtStructLoading, ISupportInitialize).EndInit()
			CType(Me.txtBPDSurface, ISupportInitialize).EndInit()
			CType(Me.txtPermLoadHP, ISupportInitialize).EndInit()
			CType(Me.txtSystemEff, ISupportInitialize).EndInit()
			CType(Me.txtFluidLoad, ISupportInitialize).EndInit()
			CType(Me.txtCalcSPM, ISupportInitialize).EndInit()
			CType(Me.txtOilProduction, ISupportInitialize).EndInit()
			CType(Me.lblFluidLoad, ISupportInitialize).EndInit()
			CType(Me.lblPermLoadHP, ISupportInitialize).EndInit()
			CType(Me.lblCalcSPM, ISupportInitialize).EndInit()
			CType(Me.lblOilProduction, ISupportInitialize).EndInit()
			CType(Me.lblBPDSurface, ISupportInitialize).EndInit()
			CType(Me.lblPrhpPlhp, ISupportInitialize).EndInit()
			CType(Me.lblStructLoading, ISupportInitialize).EndInit()
			CType(Me.lblPRHP, ISupportInitialize).EndInit()
			CType(Me.lblMPRL, ISupportInitialize).EndInit()
			CType(Me.lblPPRL, ISupportInitialize).EndInit()
			CType(Me.lblNoverNo, ISupportInitialize).EndInit()
			CType(Me.txtRodWeight, ISupportInitialize).EndInit()
			CType(Me.txtPrhpPlhp, ISupportInitialize).EndInit()
			CType(Me.txtMPRL, ISupportInitialize).EndInit()
			CType(Me.txtPPRL, ISupportInitialize).EndInit()
			CType(Me.lblRodWeight, ISupportInitialize).EndInit()
			CType(Me.lblCBE, ISupportInitialize).EndInit()
			CType(Me.lblMCM, ISupportInitialize).EndInit()
			CType(Me.lblCLF, ISupportInitialize).EndInit()
			CType(Me.lblFluidLevelTVD, ISupportInitialize).EndInit()
			CType(Me.txtPRHP, ISupportInitialize).EndInit()
			CType(Me.txtFluidLevelTVD, ISupportInitialize).EndInit()
			CType(Me.lblPolRodDiam, ISupportInitialize).EndInit()
			CType(Me.txtPolRodDiam, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote5, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote4, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote3, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote2, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote1, ISupportInitialize).EndInit()
			CType(Me.lblGearboxLoading, ISupportInitialize).EndInit()
			CType(Me.lblPeakTorque, ISupportInitialize).EndInit()
			CType(Me.txtParaffinDepth, ISupportInitialize).EndInit()
			CType(Me.lblParaffinDepth, ISupportInitialize).EndInit()
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
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		Private Sub Detail_Format(sender As Object, e As EventArgs)
		End Sub

		Private Sub SummHeader(iPage As Integer, nPages As Integer)
			Dim text As String = New String(" "c, 112)
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Dim num4 As Integer = 0
			Dim num5 As Integer = 0
			Dim num6 As Integer = 0
			Dim num7 As Single = 0F
			Dim flag As Boolean = False
			Try
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
				If cRODSTAR.FileComment Is Nothing Then
					cRODSTAR.FileComment = ""
				End If
				Me.lblComment.Text = Me.sComment + cRODSTAR.FileComment
				If Information.IsDate(cRODSTAR.UserDate) Then
					Me.lblUserDate.Text = Me.sDate + Convert.ToDateTime(cRODSTAR.UserDate).ToShortDateString()
				Else
					Me.lblUserDate.Text = Me.sDate + cRODSTAR.UserDate
				End If
				Dim sDefaultName As String = "SecondCompanyName"
				Dim vNotPresentDefault As Object = ""
				Dim flag2 As Boolean = False
				Dim text5 As String = Conversions.ToString(ini.GetDefault(sDefaultName, vNotPresentDefault, flag2))
				If text5 IsNot Nothing Then
					Me.lblSecondCompanyName.Text = text5
				Else
					Me.lblSecondCompanyName.Text = ""
				End If
				Dim sDefaultName2 As String = "SecondCompanyPhone"
				Dim vNotPresentDefault2 As Object = ""
				flag2 = False
				Dim text6 As String = Conversions.ToString(ini.GetDefault(sDefaultName2, vNotPresentDefault2, flag2))
				If text6 IsNot Nothing Then
					Me.lblSecondCompanyPhonenumber.Text = text6
				Else
					Me.lblSecondCompanyPhonenumber.Text = ""
				End If
				If(If((-If((RSWIN_DESC.bExpert > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.SETUP_ScoringPage) <> 0S Then
					Try
						Dim bCheckToAdd As Boolean = False
						flag2 = False
						Dim obj As Object = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, bCheckToAdd, flag, flag2, False, True)
						If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(obj, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing), "", False))) Then
							Me.lblCalculatedResults.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.sCalculatedResults + "  (", obj), ")"))
						End If
					Catch ex As Exception
					End Try
				End If
				If Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.bExpert And cRODSTAR.TubingOD = RSWIN_DESC.MaxTubingSizeOD Then
					Me.lblTubingOD.ForeColor = Color.Blue
					Me.lblTubingID.ForeColor = Color.Blue
					Me.txtTubingOD.ForeColor = Color.Blue
					Me.txtTubingID.ForeColor = Color.Blue
				Else
					Me.lblTubingOD.ForeColor = Color.Black
					Me.lblTubingID.ForeColor = Color.Black
					Me.txtTubingOD.ForeColor = Color.Black
					Me.txtTubingID.ForeColor = Color.Black
				End If
				cRODSTAR = Nothing
			Catch ex2 As Exception
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

		Public Sub rptCalcResults_ReportStart(sender As Object, e As EventArgs)
			Me.printFont = New Font("Arial", 10F)
			If Not Me.m_bPrint Then
				Me.PageSettings.Margins.Left = 0.25F
				Me.PageSettings.Margins.Right = 0F
				If RSWIN_DESC.rst.NumRods < 38S Then
					Me.PageSettings.Margins.Top = 0.2F
				Else
					Me.PageSettings.Margins.Top = 0.05F
				End If
				Me.PageSettings.Margins.Bottom = 0F
			Else
				Me.PageSettings.Margins.Left = 0.25F
				Me.PageSettings.Margins.Right = 0F
				If RSWIN_DESC.rst.NumRods < 38S Then
					Me.PageSettings.Margins.Top = 0.25F
				Else
					Me.PageSettings.Margins.Top = 0.05F
				End If
				Me.PageSettings.Margins.Bottom = 0F
			End If
			If RSWIN_DESC.bRodStarD Then
				Me.sDownstrokeFriction = "Dnstr. rod-fl. damp. coeff: "
				Me.sUpstrokeFriction = "Upstr. rod-fl. damp. coeff: "
			End If
			If RSWIN_DESC.rst.PU.UnitType = 10S Then
				Me.lblTqMinTorq.Text = ""
				Me.lblPmMinTorq.Text = ""
				RSWIN_DESC.rst.UnknownM = True
			End If
			Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
			Me.ShowMiscInput()
			Me.ShowFluidAndMotor()
			Me.ShowPumpingUnit()
			Me.ShowTubingAndPump()
			Me.ShowRSInput()
			Me.ShowCalculations()
			Me.ShowPrimeMoverSize()
			Me.ShowTorqueAnalysis()
			Me.ShowTubingCalc()
			Me.ShowRSCalc()
			If Not Me.picDyno.Visible Then
				Me.picDyno.Visible = True
			End If
			If RSWIN_DESC.rst.PU.UnitType <> 10S Then
				Me.picTorquePlot.Visible = True
				Me.Line16.Visible = True
			Else
				Me.picTorquePlot.Visible = False
				Me.Line16.Visible = False
			End If
			Me.picDyno.Top = Me.m_LastTop + Me.m_LastHeight * 1F
			Me.Line15.Y1 = Me.picDyno.Top
			Me.Line15.Y2 = Me.picDyno.Top
			Me.Line16.Y1 = Me.Line15.Y1
			Me.Line16.Y2 = Me.Line15.Y2
			Me.picTorquePlot.Top = Me.picDyno.Top
			If Not RSWIN_DESC.bRodStarD Then
				Me.lblFric.Visible = False
				Me.lblCoeff.Visible = False
				Me.lblFricCoef1.Visible = False
				Me.lblFricCoef2.Visible = False
				Me.lblFricCoef3.Visible = False
				Me.lblFricCoef4.Visible = False
				Me.lblFricCoef5.Visible = False
				Me.lblFricCoef6.Visible = False
				Me.lblFricCoef7.Visible = False
				Me.lblFricCoef8.Visible = False
				Me.lblFricCoef9.Visible = False
				Me.lblFricCoef10.Visible = False
				Me.linRSInputSep4.Visible = False
				Me.lblDownstrokeFriction.Text = Me.sDownstrokeFriction
				Me.lblUpstrokeFriction.Text = Me.sUpstrokeFriction
			End If
			If RSWIN_DESC.rst.PU.UnitType = 10S And Not RSWIN_DESC.rst.UnknownM Then
				RSWIN_DESC.rst.UnknownM = True
			End If
			If(CDbl(RSWIN_DESC.rst.GearboxLoading(0)) >= 0.99 Or RSWIN_DESC.bBalancedEVarsOverwritten) AndAlso Me.lblGearboxLoading_BE.Visible Then
				Dim flag As Boolean = False
				Me.SetfraPmBalancedEVisible(flag)
				Me.SetfraTqBalancedEVisible(False)
				If(Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And RSWIN_DESC.rst.UnknownM) Or ((RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And RSWIN_DESC.rst.bUnknownUnbalance) Then
					Me.SetfraTqBalancedTVisible(True, True, True)
					Me.SetfraTqExistingVisible(False, False, False)
					flag = True
					Me.SetfraPmBalancedTVisible(flag, True, True)
					flag = False
					Me.SetfraPmExistingVisible(flag, False, False)
				Else
					Me.SetfraTqExistingVisible(True, True, True)
					Me.SetfraTqBalancedTVisible(True, True, True)
					flag = True
					Me.SetfraPmExistingVisible(flag, True, True)
					flag = True
					Me.SetfraPmBalancedTVisible(flag, True, True)
				End If
			End If
			If RSWIN_DESC.bIntVersion Then
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter("rptCalcResults")
					Me.WriteControlStrings()
					Util.CloseResourceWriter()
				End If
				If RSWIN_DESC.bReadResXFile Then
					Me.ReadReportControlStrings()
				End If
				Return
			End If
		End Sub

		Private Sub ShowBE(ByRef sLabel As String, ByRef afValues As Single(), fEFactor As Single, fMFactor As Single, fEtoM As Single, ByRef sFormat As String, bCanadianUsesEnglish As Boolean, ByRef arLabels As DataDynamics.ActiveReports.Label(), Optional bVisible As Boolean = True)
			Try
				Dim label As DataDynamics.ActiveReports.Label = arLabels(0)
				label.Text = sLabel
				If Not bVisible Then
					label.Visible = False
				End If
				Dim num As Long
				If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
					If RSWIN_DESC.rst.get_RequiredUnbalance(0) = RSWIN_DESC.rst.get_RequiredUnbalance(1) Or RSWIN_DESC.bBalancedEVarsOverwritten Then
						num = 1L
					Else
						num = 0L
					End If
				ElseIf RSWIN_DESC.rst.get_M(0) = RSWIN_DESC.rst.get_M(1) Or RSWIN_DESC.bBalancedEVarsOverwritten Then
					num = 1L
				Else
					num = 0L
				End If
				Dim num2 As Long = num
				Dim num3 As Long = CLng(RSWIN_DESC.rst.iUnknownM)
				For num4 As Long = num2 To num3
					Dim flag As Boolean
					If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
						flag = Not bCanadianUsesEnglish
					Else
						flag = (RSWIN_DESC.SETUP_MeasurementSystem = 3)
					End If
					label = arLabels(CInt((num4 + 1L)))

						If flag Then
							Dim label2 As DataDynamics.ActiveReports.Label = label
							Dim num5 As Single = afValues(CInt(num4)) * fMFactor * fEtoM
							label2.Text = Util.Format(num5, sFormat)
							If Strings.InStr(sFormat, "%", CompareMethod.Binary) > 0 Then
								' The following expression was wrapped in a checked-expression
								Util.SetLabelColor(afValues(CInt(num4)) * fMFactor * fEtoM, label, sFormat)
							End If
						Else
							Dim label3 As DataDynamics.ActiveReports.Label = label
							Dim num5 As Single = afValues(CInt(num4)) * fEFactor
							label3.Text = Util.Format(num5, sFormat)
							If Strings.InStr(sFormat, "%", CompareMethod.Binary) > 0 Then
								' The following expression was wrapped in a checked-expression
								Util.SetLabelColor(afValues(CInt(num4)) * fEFactor, label, sFormat)
							End If
						End If

					arLabels(CInt((num4 + 1L))).Text = label.Text
					If Not bVisible Then
						arLabels(CInt((num4 + 1L))).Visible = False
					End If
				Next
			Catch ex As Exception
				Dim sMsg As String = "Error In ShowBE: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub SETTORQUELABELS()
			Dim flag As Boolean = False
			If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
				If RSWIN_DESC.rst.get_RequiredUnbalance(0) = RSWIN_DESC.rst.get_RequiredUnbalance(1) Or RSWIN_DESC.bBalancedEVarsOverwritten Then
					flag = True
				End If
			ElseIf RSWIN_DESC.rst.get_M(0) = RSWIN_DESC.rst.get_M(1) Or RSWIN_DESC.bBalancedEVarsOverwritten Then
				flag = True
			End If
			If Not RSWIN_DESC.rst.UnknownM Then
				If flag Then
					Me.SetfraTqBalancedEVisible(False)
					Me.SetfraTqExistingVisible(True, True, True)
					Me.SetfraTqBalancedTVisible(True, True, True)
				Else
					Me.SetfraTqBalancedEVisible(True)
					Me.SetfraTqExistingVisible(True, False, True)
					Me.SetfraTqBalancedTVisible(True, False, True)
				End If
				Return
			End If
			Me.SetfraTqExistingVisible(False, False, True)
			If flag Then
				Me.SetfraTqBalancedEVisible(False)
				Me.SetfraTqBalancedTVisible(True, True, True)
				Return
			End If
			Me.SetfraTqBalancedEVisible(True)
			Me.SetfraTqBalancedTVisible(True, False, True)
		End Sub

		Private Sub SETPMLABELS()
			Dim flag As Boolean = False
			If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
				If RSWIN_DESC.rst.get_RequiredUnbalance(0) = RSWIN_DESC.rst.get_RequiredUnbalance(1) Or RSWIN_DESC.bBalancedEVarsOverwritten Then
					flag = True
				End If
			ElseIf RSWIN_DESC.rst.get_M(0) = RSWIN_DESC.rst.get_M(1) Or RSWIN_DESC.bBalancedEVarsOverwritten Then
				flag = True
			End If
			Dim flag2 As Boolean
			If Not((Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And RSWIN_DESC.rst.UnknownM) Or ((RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And RSWIN_DESC.rst.bUnknownUnbalance)) Then
				If flag Then
					flag2 = False
					Me.SetfraPmBalancedEVisible(flag2)
					flag2 = True
					Me.SetfraPmExistingVisible(flag2, True, True)
					flag2 = True
					Me.SetfraPmBalancedTVisible(flag2, True, True)
				Else
					flag2 = True
					Me.SetfraPmBalancedEVisible(flag2)
					flag2 = True
					Me.SetfraPmExistingVisible(flag2, False, True)
					flag2 = True
					Me.SetfraPmBalancedTVisible(flag2, False, True)
				End If
				Return
			End If
			flag2 = False
			Me.SetfraPmExistingVisible(flag2, False, True)
			If flag Then
				flag2 = False
				Me.SetfraPmBalancedEVisible(flag2)
				flag2 = True
				Me.SetfraPmBalancedTVisible(flag2, True, True)
				Return
			End If
			flag2 = True
			Me.SetfraPmBalancedEVisible(flag2)
			flag2 = True
			Me.SetfraPmBalancedTVisible(flag2, False, True)
		End Sub

		Private Sub ShowBEHeader(ByRef arFrames As Object)
			If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
				If RSWIN_DESC.rst.get_RequiredUnbalance(0) = RSWIN_DESC.rst.get_RequiredUnbalance(1) Or RSWIN_DESC.bBalancedEVarsOverwritten Then
					NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet(arFrames, New Object() { 1 }, Nothing), Nothing, "Left", New Object() { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(arFrames, New Object() { 0 }, Nothing), Nothing, "Left", New Object(-1) {}, Nothing, Nothing, Nothing)) }, Nothing, Nothing, False, True)
					NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet(arFrames, New Object() { 0 }, Nothing), Nothing, "Visible", New Object() { False }, Nothing, Nothing, False, True)
				End If
			ElseIf RSWIN_DESC.rst.get_M(0) = RSWIN_DESC.rst.get_M(1) Or RSWIN_DESC.bBalancedEVarsOverwritten Then
				NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet(arFrames, New Object() { 1 }, Nothing), Nothing, "Left", New Object() { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(arFrames, New Object() { 0 }, Nothing), Nothing, "Left", New Object(-1) {}, Nothing, Nothing, Nothing)) }, Nothing, Nothing, False, True)
				NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet(arFrames, New Object() { 0 }, Nothing), Nothing, "Visible", New Object() { False }, Nothing, Nothing, False, True)
			End If
			If RSWIN_DESC.rst.UnknownM Then
				NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet(arFrames, New Object() { 2 }, Nothing), Nothing, "Visible", New Object() { False }, Nothing, Nothing, False, True)
				Return
			End If
			NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet(arFrames, New Object() { 2 }, Nothing), Nothing, "Left", New Object() { Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(arFrames, New Object() { 1 }, Nothing), Nothing, "Left", New Object(-1) {}, Nothing, Nothing, Nothing), NewLateBinding.LateGet(NewLateBinding.LateIndexGet(arFrames, New Object() { 1 }, Nothing), Nothing, "Width", New Object(-1) {}, Nothing, Nothing, Nothing)) }, Nothing, Nothing, False, True)
		End Sub

		Private Sub ShowCalculations()
			If RSWIN_DESC.rst.UnknownM Then
				Dim text As String = Me.sBalanced
			Else
				Dim text As String = Me.sExisting
			End If
			If Not RSWIN_DESC.rst.gbOutputLoaded Then
				Me.lblBPDSurface.Visible = False
				Me.lblCalcSPM.Visible = False
				Me.lblFluidLoad.Visible = False
				Me.lblMPRL.Visible = False
				Me.lblNoverNo.Visible = False
				Me.lblOilProduction.Visible = False
				Me.lblPPRL.Visible = False
				Me.lblPRHP.Visible = False
				Me.lblRodWeight.Visible = False
				Me.lblStructLoading.Visible = False
				Me.lblSystemEff.Visible = False
				Me.txtBPDSurface.Visible = False
				Me.txtCalcSPM.Visible = False
				Me.txtFluidLoad.Visible = False
				Me.txtMPRL.Visible = False
				Me.txtOilProduction.Visible = False
				Me.txtPPRL.Visible = False
				Me.txtMPRLPPRL.Visible = False
				Me.txtPRHP.Visible = False
				Me.txtPermLoadHP.Visible = False
				Me.txtPrhpPlhp.Visible = False
				Me.txtRodWeight.Visible = False
				Me.txtStructLoading.Visible = False
				Me.txtSystemEff.Visible = False
			Else
				Me.lblNoResults.Visible = False
				Dim label As DataDynamics.ActiveReports.Label = Me.lblBPDSurface
				Dim w As Object = 31
				Dim bpdsurface As Single = RSWIN_DESC.rst.BPDsurface
				Dim bpd__M3D As Single = RSWIN_DESC.BPD__M3D
				Dim text2 As String = "0"
				Dim text3 As String = "#.#"
				label.Text = RESULTS1.MkSummEM(w, Me.sProductionRate, bpdsurface, bpd__M3D, RSWIN_DESC.bfpd, text2, RSWIN_DESC.m3D, text3, 3, True, False)
				Dim label2 As DataDynamics.ActiveReports.Label = Me.txtBPDSurface
				Dim w2 As Object = 0
				text3 = ""
				Dim bpdsurface2 As Single = RSWIN_DESC.rst.BPDsurface
				Dim bpd__M3D2 As Single = RSWIN_DESC.BPD__M3D
				text2 = "0"
				Dim text4 As String = "#.#"
				label2.Text = RESULTS1.MkSummEM(w2, text3, bpdsurface2, bpd__M3D2, RSWIN_DESC.bfpd, text2, RSWIN_DESC.m3D, text4, 3, False, True)
				Dim label3 As DataDynamics.ActiveReports.Label = Me.lblCalcSPM
				Dim w3 As Object = 25
				Dim spm As Single = RSWIN_DESC.rst.SPM
				text4 = "##.##"
				label3.Text = RESULTS1.MkSumm(w3, Me.sStrokesPerMinute, spm, text4, True, False)
				Dim label4 As DataDynamics.ActiveReports.Label = Me.txtCalcSPM
				Dim w4 As Object = 0
				text4 = ""
				Dim spm2 As Single = RSWIN_DESC.rst.SPM
				text3 = "##.##"
				label4.Text = RESULTS1.MkSumm(w4, text4, spm2, text3, False, True)
				Dim label5 As DataDynamics.ActiveReports.Label = Me.lblFluidLoad
				Dim w5 As Object = 31
				Dim fluidLoad As Single = RSWIN_DESC.rst.FluidLoad
				Dim lb__N As Single = RSWIN_DESC.LB__N
				text4 = "0"
				text3 = "0"
				label5.Text = RESULTS1.MkSummEM(w5, Me.sFluidLoadOnPump, fluidLoad, lb__N, RSWIN_DESC.lbs, text4, RSWIN_DESC.N, text3, 1, True, False)
				Dim label6 As DataDynamics.ActiveReports.Label = Me.txtFluidLoad
				Dim w6 As Object = 0
				text4 = ""
				Dim fluidLoad2 As Single = RSWIN_DESC.rst.FluidLoad
				Dim lb__N2 As Single = RSWIN_DESC.LB__N
				text3 = "0"
				text2 = "0"
				label6.Text = RESULTS1.MkSummEM(w6, text4, fluidLoad2, lb__N2, RSWIN_DESC.lbs, text3, RSWIN_DESC.N, text2, 1, False, True)
				Dim text5 As String
				Dim text6 As String
				If RSWIN_DESC.bRodStarD Then
					If RSWIN_DESC.rst.FluidLevelTVD > 0F And RSWIN_DESC.rst.FluidLevelTVD <> RSWIN_DESC.rst.FluidLevel Then
						Dim label7 As DataDynamics.ActiveReports.Label = Me.lblFluidLevelTVD
						Dim w7 As Object = 37
						Dim fluidLevelTVD As Single = RSWIN_DESC.rst.FluidLevelTVD
						Dim ft__M As Single = RSWIN_DESC.FT__M
						text4 = RSWIN_DESC.ft + " from surface"
						text3 = "0"
						text2 = "m from surface"
						text5 = "#.#"
						label7.Text = RESULTS1.MkSummEM(w7, Me.sFluidLevelTVD, fluidLevelTVD, ft__M, text4, text3, text2, text5, 3, True, False)
						Dim label8 As DataDynamics.ActiveReports.Label = Me.txtFluidLevelTVD
						Dim w8 As Object = 0
						text5 = ""
						Dim fluidLevelTVD2 As Single = RSWIN_DESC.rst.FluidLevelTVD
						Dim ft__M2 As Single = RSWIN_DESC.FT__M
						text4 = RSWIN_DESC.ft + " from surface"
						text3 = "0"
						text2 = "m from surface"
						text6 = "#.#"
						label8.Text = RESULTS1.MkSummEM(w8, text5, fluidLevelTVD2, ft__M2, text4, text3, text2, text6, 3, False, True)
					Else
						Dim label9 As DataDynamics.ActiveReports.Label = Me.lblFluidLevelTVD
						Dim w9 As Object = 37
						Dim fluidLevel As Single = RSWIN_DESC.rst.FluidLevel
						Dim ft__M3 As Single = RSWIN_DESC.FT__M
						text6 = RSWIN_DESC.ft + " from surface"
						text5 = "0"
						text4 = "m from surface"
						text3 = "#.#"
						label9.Text = RESULTS1.MkSummEM(w9, Me.sFluidLevelTVD, fluidLevel, ft__M3, text6, text5, text4, text3, 3, True, False)
						Dim label10 As DataDynamics.ActiveReports.Label = Me.txtFluidLevelTVD
						Dim w10 As Object = 0
						text6 = ""
						Dim fluidLevel2 As Single = RSWIN_DESC.rst.FluidLevel
						Dim ft__M4 As Single = RSWIN_DESC.FT__M
						text5 = RSWIN_DESC.ft + " from surface"
						text4 = "0"
						text3 = "m from surface"
						text2 = "#.#"
						label10.Text = RESULTS1.MkSummEM(w10, text6, fluidLevel2, ft__M4, text5, text4, text3, text2, 3, False, True)
					End If
					Me.lblPRHP.Top = CSng((CDbl(Me.lblFluidLevelTVD.Top) + 0.125))
					Me.txtPRHP.Top = CSng((CDbl(Me.txtFluidLevelTVD.Top) + 0.125))
				Else
					Me.lblFluidLevelTVD.Text = ""
					Me.txtFluidLevelTVD.Text = ""
					Me.lblPRHP.Top = Me.lblFluidLevelTVD.Top
					Me.txtPRHP.Top = Me.txtFluidLevelTVD.Top
				End If
				Dim label11 As DataDynamics.ActiveReports.Label = Me.lblMPRL
				Dim w11 As Object = 31
				Dim mprload As Single = RSWIN_DESC.rst.Mprload
				Dim lb__N3 As Single = RSWIN_DESC.LB__N
				text6 = "0"
				text5 = "0"
				label11.Text = RESULTS1.MkSummEM(w11, Me.sMinPolRodLoad, mprload, lb__N3, RSWIN_DESC.lbs, text6, RSWIN_DESC.N, text5, 1, True, False)
				Dim label12 As DataDynamics.ActiveReports.Label = Me.lblNoverNo
				Dim str As String = "N/No:  "
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim noverNoP As Single = rst.NoverNoP
				text5 = "##.###"
				Dim str2 As String = Util.Format(noverNoP, text5)
				rst.NoverNoP = noverNoP
				Dim str3 As String = "  ,    Fo/SKr:  "
				Dim rst2 As cRODSTAR = RSWIN_DESC.rst
				Dim foSkr As Single = rst2.FoSkr
				text6 = "##.###"
				Dim str4 As String = Util.Format(foSkr, text6)
				rst2.FoSkr = foSkr
				label12.Text = str + str2 + str3 + str4
				Dim label13 As DataDynamics.ActiveReports.Label = Me.lblOilProduction
				Dim w12 As Object = 25
				Dim v As Single = RSWIN_DESC.rst.BPDsurface * (1F - RSWIN_DESC.rst.WaterCut / 100F)
				Dim bpd__M3D3 As Single = RSWIN_DESC.BPD__M3D
				text6 = "BOPD"
				text5 = "0"
				text4 = "#.#"
				label13.Text = RESULTS1.MkSummEM(w12, Me.sOilProduction, v, bpd__M3D3, text6, text5, RSWIN_DESC.m3D, text4, 3, True, False)
				Dim label14 As DataDynamics.ActiveReports.Label = Me.lblPPRL
				Dim w13 As Object = 31
				Dim pprload As Single = RSWIN_DESC.rst.Pprload
				Dim lb__N4 As Single = RSWIN_DESC.LB__N
				text6 = "0"
				text5 = "0"
				label14.Text = RESULTS1.MkSummEM(w13, Me.aPeakPolRodLoad, pprload, lb__N4, RSWIN_DESC.lbs, text6, RSWIN_DESC.N, text5, 1, True, False)
				Dim label15 As DataDynamics.ActiveReports.Label = Me.txtMPRL
				Dim w14 As Object = 0
				text6 = ""
				Dim mprload2 As Single = RSWIN_DESC.rst.Mprload
				Dim lb__N5 As Single = RSWIN_DESC.LB__N
				text5 = "0"
				text4 = "0"
				label15.Text = RESULTS1.MkSummEM(w14, text6, mprload2, lb__N5, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text4, 1, False, True)
				Dim label16 As DataDynamics.ActiveReports.Label = Me.txtOilProduction
				Dim w15 As Object = 0
				text6 = ""
				Dim v2 As Single = RSWIN_DESC.rst.BPDsurface * (1F - RSWIN_DESC.rst.WaterCut / 100F)
				Dim bpd__M3D4 As Single = RSWIN_DESC.BPD__M3D
				text5 = "BOPD"
				text4 = "0"
				text3 = "#.#"
				label16.Text = RESULTS1.MkSummEM(w15, text6, v2, bpd__M3D4, text5, text4, RSWIN_DESC.m3D, text3, 3, False, True)
				Dim label17 As DataDynamics.ActiveReports.Label = Me.txtPPRL
				Dim w16 As Object = 0
				text6 = ""
				Dim pprload2 As Single = RSWIN_DESC.rst.Pprload
				Dim lb__N6 As Single = RSWIN_DESC.LB__N
				text5 = "0"
				text4 = "0"
				label17.Text = RESULTS1.MkSummEM(w16, text6, pprload2, lb__N6, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text4, 1, False, True)
				If RSWIN_DESC.rst.Pprload <> 0F Then
					Dim label18 As DataDynamics.ActiveReports.Label = Me.txtMPRLPPRL
					Dim w17 As Object = 0
					text6 = ""
					Dim value As Single = RSWIN_DESC.rst.Mprload / RSWIN_DESC.rst.Pprload
					text5 = "#0.###"
					label18.Text = RESULTS1.MkSumm(w17, text6, value, text5, False, True)
				Else
					Dim label19 As DataDynamics.ActiveReports.Label = Me.txtMPRLPPRL
					Dim w18 As Object = 0
					text6 = ""
					Dim value2 As Single = 0F
					text5 = "0.0"
					label19.Text = RESULTS1.MkSumm(w18, text6, value2, text5, False, True)
				End If
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					Dim label20 As DataDynamics.ActiveReports.Label = Me.lblPRHP
					Dim w19 As Object = 25
					Dim value3 As Single = CSng((CDbl(RSWIN_DESC.rst.Prhp) * 0.746))
					text6 = "#.#"
					label20.Text = RESULTS1.MkSumm(w19, Me.sPolRodPowerKW, value3, text6, True, False)
					Dim label21 As DataDynamics.ActiveReports.Label = Me.txtPRHP
					Dim w20 As Object = 0
					text6 = ""
					Dim value4 As Single = CSng((CDbl(RSWIN_DESC.rst.Prhp) * 0.746))
					text5 = "#.#"
					label21.Text = RESULTS1.MkSumm(w20, text6, value4, text5, False, True)
				Else
					Dim label22 As DataDynamics.ActiveReports.Label = Me.lblPRHP
					Dim w21 As Object = 25
					Dim prhp As Single = RSWIN_DESC.rst.Prhp
					text6 = "#.#"
					label22.Text = RESULTS1.MkSumm(w21, Me.sPolishedRodHP, prhp, text6, True, False)
					Dim label23 As DataDynamics.ActiveReports.Label = Me.txtPRHP
					Dim w22 As Object = 0
					text6 = ""
					Dim prhp2 As Single = RSWIN_DESC.rst.Prhp
					text5 = "#.#"
					label23.Text = RESULTS1.MkSumm(w22, text6, prhp2, text5, False, True)
				End If
				If RSWIN_DESC.rst.Plhp <> 0F Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						Dim label24 As DataDynamics.ActiveReports.Label = Me.lblPermLoadHP
						Dim w23 As Object = 25
						Dim value5 As Single = CSng((CDbl(RSWIN_DESC.rst.Plhp) * 0.746))
						text6 = "#.#"
						label24.Text = RESULTS1.MkSumm(w23, Me.sPermissibleLoadPowerKW, value5, text6, True, False)
						Dim label25 As DataDynamics.ActiveReports.Label = Me.txtPermLoadHP
						Dim w24 As Object = 0
						text6 = ""
						Dim value6 As Single = CSng((CDbl(RSWIN_DESC.rst.Plhp) * 0.746))
						text5 = "#.#"
						label25.Text = RESULTS1.MkSumm(w24, text6, value6, text5, False, True)
					Else
						Dim label26 As DataDynamics.ActiveReports.Label = Me.lblPermLoadHP
						Dim w25 As Object = 25
						Dim plhp As Single = RSWIN_DESC.rst.Plhp
						text6 = "#.#"
						label26.Text = RESULTS1.MkSumm(w25, Me.sPermissibleLoadHP, plhp, text6, True, False)
						Dim label27 As DataDynamics.ActiveReports.Label = Me.txtPermLoadHP
						Dim w26 As Object = 0
						text6 = ""
						Dim plhp2 As Single = RSWIN_DESC.rst.Plhp
						text5 = "#.#"
						label27.Text = RESULTS1.MkSumm(w26, text6, plhp2, text5, False, True)
					End If
					noverNoP = RSWIN_DESC.rst.Prhp / RSWIN_DESC.rst.Plhp
					text6 = "0.00"
					Dim text7 As String = Util.Format(noverNoP, text6)
					Me.txtPrhpPlhp.Text = text7
				Else
					Dim text7 As String
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						Me.lblPermLoadHP.Text = Me.sPermissibleLoadPowerKW
						Me.txtPermLoadHP.Text = "0.00"
						text7 = Me.sNA
					Else
						Me.lblPermLoadHP.Text = Me.sPermissibleLoadHP
						Me.txtPermLoadHP.Text = "0.00"
						text7 = Me.sNA
					End If
					Me.txtPrhpPlhp.Text = text7
				End If
				Dim label28 As DataDynamics.ActiveReports.Label = Me.lblRodWeight
				Dim w27 As Object = 31
				Dim wrodsInFluid As Single = RSWIN_DESC.rst.WrodsInFluid
				Dim lb__N7 As Single = RSWIN_DESC.LB__N
				text6 = "0"
				text5 = "0"
				label28.Text = RESULTS1.MkSummEM(w27, Me.sBuoyantRodWeight, wrodsInFluid, lb__N7, RSWIN_DESC.lbs, text6, RSWIN_DESC.N, text5, 1, True, False)
				Dim label29 As DataDynamics.ActiveReports.Label = Me.lblStructLoading
				Dim w28 As Object = 31
				Dim structL As Single = RSWIN_DESC.rst.StructL
				text6 = "###%"
				label29.Text = RESULTS1.MkSumm(w28, Me.sUnitStructLoading, structL, text6, True, False)
				Dim label30 As DataDynamics.ActiveReports.Label = Me.lblSystemEff
				Dim w29 As Object = 31
				Dim systemEff As Single = RSWIN_DESC.rst.SystemEff
				text6 = "###%"
				label30.Text = RESULTS1.MkSumm(w29, Me.sSystemEffMotorPump, systemEff, text6, True, False)
				Dim label31 As DataDynamics.ActiveReports.Label = Me.txtRodWeight
				Dim w30 As Object = 0
				text6 = ""
				Dim wrodsInFluid2 As Single = RSWIN_DESC.rst.WrodsInFluid
				Dim lb__N8 As Single = RSWIN_DESC.LB__N
				text5 = "0"
				text4 = "0"
				label31.Text = RESULTS1.MkSummEM(w30, text6, wrodsInFluid2, lb__N8, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text4, 1, False, True)
				Dim label32 As DataDynamics.ActiveReports.Label = Me.txtStructLoading
				Dim w31 As Object = 0
				text6 = ""
				Dim structL2 As Single = RSWIN_DESC.rst.StructL
				text5 = "###%"
				label32.Text = RESULTS1.MkSumm(w31, text6, structL2, text5, False, True)
				Dim label33 As DataDynamics.ActiveReports.Label = Me.txtSystemEff
				Dim w32 As Object = 0
				text6 = ""
				Dim systemEff2 As Single = RSWIN_DESC.rst.SystemEff
				text5 = "###%"
				label33.Text = RESULTS1.MkSumm(w32, text6, systemEff2, text5, False, True)
				Util.SetLabelColor(RSWIN_DESC.rst.StructL, Me.txtStructLoading, "###%")
				Util.SetLabelColor(RSWIN_DESC.rst.SystemEff, Me.txtSystemEff, "###%")
			End If
		End Sub

		Private Sub ShowFluidAndMotor()
			Dim text As String
			Dim text2 As String
			If(If((-If((Not MImpred.FluidInertiaPossible() > False), 1S, 0S)), 1S, 0S) Or Not RSWIN_DESC.rst.IncludeFluidInertia) <> 0S Then
				Me.lblCompressibilityIndex.Visible = False
				Me.txtCompressibilityIndex.Visible = False
			Else
				Dim label As DataDynamics.ActiveReports.Label = Me.lblCompressibilityIndex
				Dim w As Object = 24
				Dim compressibilityIndex As Single = RSWIN_DESC.rst.CompressibilityIndex
				text = "0.0#"
				label.Text = RESULTS1.MkSumm(w, Me.sCompressIndex, compressibilityIndex, text, True, False)
				Dim label2 As DataDynamics.ActiveReports.Label = Me.txtCompressibilityIndex
				Dim w2 As Object = 0
				text = ""
				Dim compressibilityIndex2 As Single = RSWIN_DESC.rst.CompressibilityIndex
				text2 = "0.0#"
				label2.Text = RESULTS1.MkSumm(w2, text, compressibilityIndex2, text2, False, True)
			End If
			Me.lblElectricityCost.Text = Me.sElectricityCost
			Dim label3 As DataDynamics.ActiveReports.Label = Me.txtElectricityCost
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim electricityCost As Single = rst.ElectricityCost
			text2 = "$##.##"
			Dim str As String = Util.Format(electricityCost, text2)
			rst.ElectricityCost = electricityCost
			label3.Text = str + "/KWH"
			Dim label4 As DataDynamics.ActiveReports.Label = Me.lblFluidSPGR
			Dim w3 As Object = 24
			Dim fluidSPGR As Single = RSWIN_DESC.rst.FluidSPGR
			text2 = "0.0###"
			label4.Text = RESULTS1.MkSumm(w3, Me.sFluidSpGravity, fluidSPGR, text2, True, False)
			Dim label5 As DataDynamics.ActiveReports.Label = Me.txtFluidSPGR
			Dim w4 As Object = 0
			text2 = ""
			Dim fluidSPGR2 As Single = RSWIN_DESC.rst.FluidSPGR
			text = "0.0###"
			label5.Text = RESULTS1.MkSumm(w4, text2, fluidSPGR2, text, False, True)
			If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), RSWIN_DESC.rst.CalcMotorSize)) Then
				Me.lblMotorSize.Visible = False
				Me.txtMotorSize.Visible = False
			Else
				Dim text3 As String = Conversions.ToString(Motor.GetMotorInfo(3))
				If Strings.InStr(1, text3, Me.sUCSIZE, CompareMethod.Text) = 1 Then
					text3 = Strings.Mid(text3, 6)
				End If
				Me.lblMotorSize.Text = Me.sSize
				Me.txtMotorSize.Text = text3
			End If
			Dim text4 As String = Conversions.ToString(Motor.GetMotorInfo(2))
			If text4.Length = 0 Then
				Me.lblMotorSetting.Visible = False
			Else
				Dim num As Integer = Strings.InStr(1, text4, Me.sMediumLow, CompareMethod.Text)
				If num > 0 Then
					' The following expression was wrapped in a checked-expression
					text4 = Strings.Left(text4, num - 1) + Me.sMLow + Strings.Mid(text4, num + 10)
				End If
				Me.lblMotorSetting.Text = Me.sMode
				Me.txtMotorSetting.Text = text4
			End If
			Dim motorInfo As Object = Motor.GetMotorInfo(4)
			Dim text5 As String
			If Operators.ConditionalCompareObjectEqual(motorInfo, 2, False) Then
				text5 = "Sargent EP-II ODP"
			ElseIf Operators.ConditionalCompareObjectEqual(motorInfo, 4, False) Then
				text5 = "Sargent EP-II TEFC"
			Else
				text5 = Conversions.ToString(Motor.GetMotorInfo(1))
			End If
			Me.lblMotorType.Text = Me.sType
			Me.txtMotorType.Text = text5
			If Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False))) Then
				Me.lblMotorSetting.Visible = False
				Me.txtMotorSetting.Visible = False
			End If
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				Dim label6 As DataDynamics.ActiveReports.Label = Me.lblOilSPGR
				Dim w5 As Object = 24
				Dim value As Single = CSng((141.5 / (131.5 + CDbl(RSWIN_DESC.rst.OilAPI))))
				text2 = "0.0#"
				label6.Text = RESULTS1.MkSumm(w5, Me.sOilDensityGCM, value, text2, True, False)
				Dim label7 As DataDynamics.ActiveReports.Label = Me.txtOilSPGR
				Dim w6 As Object = 0
				text2 = ""
				Dim value2 As Single = CSng((141.5 / (131.5 + CDbl(RSWIN_DESC.rst.OilAPI))))
				text = "0.0#"
				label7.Text = RESULTS1.MkSumm(w6, text2, value2, text, False, True)
			Else
				Dim label8 As DataDynamics.ActiveReports.Label = Me.lblOilSPGR
				Dim w7 As Object = 24
				Dim oilAPI As Single = RSWIN_DESC.rst.OilAPI
				text2 = "0.0#"
				label8.Text = RESULTS1.MkSumm(w7, Me.sOilAPIGravity, oilAPI, text2, True, False)
				Dim label9 As DataDynamics.ActiveReports.Label = Me.txtOilSPGR
				Dim w8 As Object = 0
				text2 = ""
				Dim oilAPI2 As Single = RSWIN_DESC.rst.OilAPI
				text = "0.0#"
				label9.Text = RESULTS1.MkSumm(w8, text2, oilAPI2, text, False, True)
			End If
			Me.lblPowerMeter.Text = Me.sPowerMeter
			Me.txtPowerMeter.Text = Conversions.ToString(Interaction.IIf(RSWIN_DESC.rst.PowerMeterType = 1S, Me.sDetent, Me.sNonDetent))
			Dim label10 As DataDynamics.ActiveReports.Label = Me.lblWaterCut
			Dim w9 As Object = 24
			Dim value3 As Single = RSWIN_DESC.rst.WaterCut / 100F
			text2 = "###.#%"
			label10.Text = RESULTS1.MkSumm(w9, Me.sWaterCut, value3, text2, True, False)
			Dim label11 As DataDynamics.ActiveReports.Label = Me.lblWaterSPGR
			Dim w10 As Object = 24
			Dim waterSPGR As Single = RSWIN_DESC.rst.WaterSPGR
			text2 = "#.###"
			label11.Text = RESULTS1.MkSumm(w10, Me.sWaterSpGravity, waterSPGR, text2, True, False)
			Dim label12 As DataDynamics.ActiveReports.Label = Me.txtWaterCut
			Dim w11 As Object = 0
			text2 = ""
			Dim value4 As Single = RSWIN_DESC.rst.WaterCut / 100F
			text = "###.#%"
			label12.Text = RESULTS1.MkSumm(w11, text2, value4, text, False, True)
			Dim label13 As DataDynamics.ActiveReports.Label = Me.txtWaterSPGR
			Dim w12 As Object = 0
			text2 = ""
			Dim waterSPGR2 As Single = RSWIN_DESC.rst.WaterSPGR
			text = "#.###"
			label13.Text = RESULTS1.MkSumm(w12, text2, waterSPGR2, text, False, True)
		End Sub

		Private Sub ShowHeader()
		End Sub

		Private Sub ShowMiscInput()
			Dim label As DataDynamics.ActiveReports.Label = Me.lblCasingPressure
			Dim w As Object = 24
			Dim casingPressure As Single = RSWIN_DESC.rst.CasingPressure
			Dim psi__KPA As Single = RSWIN_DESC.PSI__KPA
			Dim text As String = "###.#"
			Dim text2 As String = "###.#"
			label.Text = RESULTS1.MkSummEM(w, Me.sCasingPres, casingPressure, psi__KPA, RSWIN_DESC.psi, text, RSWIN_DESC.kPa, text2, 3, True, False)
			Dim label2 As DataDynamics.ActiveReports.Label = Me.txtCasingPressure
			Dim w2 As Object = 0
			text2 = ""
			Dim casingPressure2 As Single = RSWIN_DESC.rst.CasingPressure
			Dim psi__KPA2 As Single = RSWIN_DESC.PSI__KPA
			text = "###.#"
			Dim text3 As String = "###.#"
			label2.Text = RESULTS1.MkSummEM(w2, text2, casingPressure2, psi__KPA2, RSWIN_DESC.psi, text, RSWIN_DESC.kPa, text3, 3, False, True)
			Dim text4 As String
			Dim text5 As String
			If RSWIN_DESC.rst.FluidLevelEntered Then
				Me.lblFLPIP_1.Text = Me.sFluidLevel
				Me.txtFLPIP_1.Text = ""
				Dim label3 As DataDynamics.ActiveReports.Label = Me.lblFLPIP_2
				Dim w3 As Object = 24
				text3 = ""
				Dim fluidLevel As Single = RSWIN_DESC.rst.FluidLevel
				Dim ft__M As Single = RSWIN_DESC.FT__M
				text2 = RSWIN_DESC.ft + " from surface"
				text = "0"
				text4 = "m from surface"
				text5 = "#####.#"
				label3.Text = RESULTS1.MkSummEM(w3, text3, fluidLevel, ft__M, text2, text, text4, text5, 3, True, False)
				Dim label4 As DataDynamics.ActiveReports.Label = Me.txtFLPIP_2
				Dim w4 As Object = 0
				text5 = ""
				Dim fluidLevel2 As Single = RSWIN_DESC.rst.FluidLevel
				Dim ft__M2 As Single = RSWIN_DESC.FT__M
				text4 = RSWIN_DESC.ft + " from surface"
				text3 = "0"
				text2 = "m from surface"
				text = "#####.#"
				label4.Text = RESULTS1.MkSummEM(w4, text5, fluidLevel2, ft__M2, text4, text3, text2, text, 3, False, True)
			Else
				Dim label5 As DataDynamics.ActiveReports.Label = Me.lblFLPIP_1
				Dim w5 As Object = 24
				Dim pumpIntakePressure As Single = RSWIN_DESC.rst.PumpIntakePressure
				Dim psi__KPA3 As Single = RSWIN_DESC.PSI__KPA
				text5 = "0"
				text4 = "0"
				label5.Text = RESULTS1.MkSummEM(w5, Me.sPumpIntPr, pumpIntakePressure, psi__KPA3, RSWIN_DESC.psi, text5, RSWIN_DESC.kPa, text4, 3, True, False)
				Dim label6 As DataDynamics.ActiveReports.Label = Me.txtFLPIP_1
				Dim w6 As Object = 0
				text5 = ""
				Dim pumpIntakePressure2 As Single = RSWIN_DESC.rst.PumpIntakePressure
				Dim psi__KPA4 As Single = RSWIN_DESC.PSI__KPA
				text4 = "0"
				text3 = "0"
				label6.Text = RESULTS1.MkSummEM(w6, text5, pumpIntakePressure2, psi__KPA4, RSWIN_DESC.psi, text4, RSWIN_DESC.kPa, text3, 3, False, True)
				Me.lblFLPIP_2.Text = Me.sFluidLevel
				Me.txtFLPIP_2.Text = ""
			End If
			Dim label7 As DataDynamics.ActiveReports.Label = Me.lblFLPIP_3
			Dim w7 As Object = 24
			text5 = ""
			Dim v As Single = RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.rst.FluidLevel
			Dim ft__M3 As Single = RSWIN_DESC.FT__M
			text4 = RSWIN_DESC.ft + " over pump"
			text3 = "0"
			text2 = "m over pump"
			text = "#####.#"
			label7.Text = RESULTS1.MkSummEM(w7, text5, v, ft__M3, text4, text3, text2, text, 3, True, False)
			Dim label8 As DataDynamics.ActiveReports.Label = Me.txtFLPIP_3
			Dim w8 As Object = 0
			text5 = ""
			Dim v2 As Single = RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.rst.FluidLevel
			Dim ft__M4 As Single = RSWIN_DESC.FT__M
			text4 = RSWIN_DESC.ft + " over pump"
			text3 = "0"
			text2 = "m over pump"
			text = "#####.#"
			label8.Text = RESULTS1.MkSummEM(w8, text5, v2, ft__M4, text4, text3, text2, text, 3, False, True)
			Dim label9 As DataDynamics.ActiveReports.Label = Me.lblRuntime
			Dim w9 As Object = 24
			Dim runtime As Single = RSWIN_DESC.rst.Runtime
			text5 = "000.0"
			label9.Text = RESULTS1.MkSumm(w9, Me.sRunTime, runtime, text5, True, False)
			Dim label10 As DataDynamics.ActiveReports.Label = Me.txtRuntime
			Dim w10 As Object = 0
			text5 = ""
			Dim runtime2 As Single = RSWIN_DESC.rst.Runtime
			text4 = "000.0"
			label10.Text = RESULTS1.MkSumm(w10, text5, runtime2, text4, False, True)
			If RSWIN_DESC.rst.SPMEntered <> 0S Then
				Dim label11 As DataDynamics.ActiveReports.Label = Me.lblSPM
				Dim w11 As Object = 24
				Dim spm As Single = RSWIN_DESC.rst.SPM
				text5 = "##.#"
				label11.Text = RESULTS1.MkSumm(w11, Me.sStrokesPerMinute, spm, text5, True, False)
				Dim label12 As DataDynamics.ActiveReports.Label = Me.txtSPM
				Dim w12 As Object = 0
				text5 = ""
				Dim spm2 As Single = RSWIN_DESC.rst.SPM
				text4 = "##.#"
				label12.Text = RESULTS1.MkSumm(w12, text5, spm2, text4, False, True)
			Else
				Dim label13 As DataDynamics.ActiveReports.Label = Me.lblSPM
				Dim w13 As Object = 24
				Dim targetBFPD As Single = RSWIN_DESC.rst.TargetBFPD
				Dim bpd__M3D As Single = RSWIN_DESC.BPD__M3D
				text5 = "0"
				text4 = "####.#"
				label13.Text = RESULTS1.MkSummEM(w13, Me.sTargetProd, targetBFPD, bpd__M3D, RSWIN_DESC.bfpd, text5, RSWIN_DESC.m3D, text4, 3, True, False)
				Dim label14 As DataDynamics.ActiveReports.Label = Me.txtSPM
				Dim w14 As Object = 0
				Dim targetBFPD2 As Single = RSWIN_DESC.rst.TargetBFPD
				Dim bpd__M3D2 As Single = RSWIN_DESC.BPD__M3D
				text5 = "0"
				text4 = "####.#"
				label14.Text = RESULTS1.MkSummEM(w14, Me.sTargetProd, targetBFPD2, bpd__M3D2, RSWIN_DESC.bfpd, text5, RSWIN_DESC.m3D, text4, 3, False, True)
			End If
			Dim label15 As DataDynamics.ActiveReports.Label = Me.lblStuffingBoxFriction
			Dim w15 As Object = 24
			Dim stuffingBoxFriction As Single = RSWIN_DESC.rst.StuffingBoxFriction
			Dim lb__N As Single = RSWIN_DESC.LB__N
			text5 = "0"
			text4 = "0"
			label15.Text = RESULTS1.MkSummEM(w15, Me.sStufBoxFr, stuffingBoxFriction, lb__N, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text4, 1, True, False)
			Dim label16 As DataDynamics.ActiveReports.Label = Me.lblTubingPressure
			Dim w16 As Object = 24
			Dim tubingPressure As Single = RSWIN_DESC.rst.TubingPressure
			Dim psi__KPA5 As Single = RSWIN_DESC.PSI__KPA
			text5 = "###.#"
			text4 = "###.#"
			label16.Text = RESULTS1.MkSummEM(w16, Me.sTubingPres, tubingPressure, psi__KPA5, RSWIN_DESC.psi, text5, RSWIN_DESC.kPa, text4, 3, True, False)
			Dim label17 As DataDynamics.ActiveReports.Label = Me.txtStuffingBoxFriction
			Dim w17 As Object = 0
			text5 = ""
			Dim stuffingBoxFriction2 As Single = RSWIN_DESC.rst.StuffingBoxFriction
			Dim lb__N2 As Single = RSWIN_DESC.LB__N
			text4 = "0"
			text3 = "0"
			label17.Text = RESULTS1.MkSummEM(w17, text5, stuffingBoxFriction2, lb__N2, RSWIN_DESC.lbs, text4, RSWIN_DESC.N, text3, 1, False, True)
			Dim label18 As DataDynamics.ActiveReports.Label = Me.txtTubingPressure
			Dim w18 As Object = 0
			text5 = ""
			Dim tubingPressure2 As Single = RSWIN_DESC.rst.TubingPressure
			Dim psi__KPA6 As Single = RSWIN_DESC.PSI__KPA
			text4 = "###.#"
			text3 = "###.#"
			label18.Text = RESULTS1.MkSummEM(w18, text5, tubingPressure2, psi__KPA6, RSWIN_DESC.psi, text4, RSWIN_DESC.kPa, text3, 3, False, True)
			Me.lblPolRodDiam.Text = "Pol. Rod Diam: "
			If RSWIN_DESC.rst.PR_Diameter = 1F Then
				Me.txtPolRodDiam.Text = Conversions.ToString(Operators.ConcatenateObject("1" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", "  (25.4 mm)")))
			ElseIf CDbl(RSWIN_DESC.rst.PR_Diameter) = 1.25 Then
				Me.txtPolRodDiam.Text = Conversions.ToString(Operators.ConcatenateObject("1.25" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", " (31.8 mm)")))
			ElseIf CDbl(RSWIN_DESC.rst.PR_Diameter) = 1.5 Then
				Me.txtPolRodDiam.Text = Conversions.ToString(Operators.ConcatenateObject("1.5" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", "  (38.1 mm)")))
			Else
				Dim label19 As DataDynamics.ActiveReports.Label = Me.txtPolRodDiam
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim pr_Diameter As Single = rst.PR_Diameter
				text4 = "#.###"
				Dim str As String = Util.Format(pr_Diameter, text4)
				rst.PR_Diameter = pr_Diameter
				Dim obj As Object = str + RSWIN_DESC.sDblQuote
				Dim expression As Boolean = RSWIN_DESC.SETUP_MeasurementSystem = 1
				Dim truePart As Object = " "
				Dim str2 As String = "  ("
				Dim num As Single = RSWIN_DESC.rst.PR_Diameter * RSWIN_DESC.IN__MM
				text5 = "##.#"
				label19.Text = Conversions.ToString(Operators.ConcatenateObject(obj, Interaction.IIf(expression, truePart, str2 + Util.Format(num, text5) + " mm)")))
			End If
			If RSWIN_DESC.bRodStarD And RSWIN_DESC.rst.gbParaffin Then
				Dim lblParaffinDepth As DataDynamics.ActiveReports.Label = Me.lblParaffinDepth
				Dim w19 As Object = 24
				Dim paraffinDepth As Single = RSWIN_DESC.rst.ParaffinDepth
				Dim ft__M5 As Single = RSWIN_DESC.FT__M
				text5 = RSWIN_DESC.ft + ""
				text4 = "0"
				text3 = "m"
				text2 = "#####.#"
				lblParaffinDepth.Text = RESULTS1.MkSummEM(w19, Me.sParaffinDepth, paraffinDepth, ft__M5, text5, text4, text3, text2, 3, True, False)
				Dim txtParaffinDepth As DataDynamics.ActiveReports.Label = Me.txtParaffinDepth
				Dim w20 As Object = 0
				text5 = ""
				Dim paraffinDepth2 As Single = RSWIN_DESC.rst.ParaffinDepth
				Dim ft__M6 As Single = RSWIN_DESC.FT__M
				text4 = RSWIN_DESC.ft + ""
				text3 = "0"
				text2 = "m"
				text = "#####.#"
				txtParaffinDepth.Text = RESULTS1.MkSummEM(w20, text5, paraffinDepth2, ft__M6, text4, text3, text2, text, 3, False, True)
				Me.lblParaffinDepth.Visible = True
				Me.txtParaffinDepth.Visible = True
			Else
				Me.lblParaffinDepth.Visible = False
				Me.txtParaffinDepth.Visible = False
			End If
		End Sub

		Private Sub ShowPrimeMoverSize()
			If Not RSWIN_DESC.rst.gbOutputLoaded Then
				Me.lblReqPrimeMoverSize.Text = Me.sPrimeMoverSpeedVariation
				Me.lnPMSV.Visible = True
				Me.lblMotorSPVHdr.Visible = False
				Me.lblMotorSPV.Visible = False
				Dim flag As Boolean = False
				Me.SetfraPmBalancedEVisible(flag)
				flag = False
				Me.SetfraPmBalancedTVisible(flag, False, True)
				flag = False
				Me.SetfraPmExistingVisible(flag, False, True)
				Me.lblNEMAD.Visible = False
				Me.lblMultiCyl.Visible = False
				Me.lblSingleCyl.Visible = False
				Me.Line8.Visible = False
			ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), RSWIN_DESC.rst.CalcMotorSize)) Then
				Dim rst As cRODSTAR
				If RSWIN_DESC.rst.MotorSPV = 0F Then
					Me.lblMotorSPVHdr.Text = Me.sSpeedVarNotIncluded
				ElseIf RSWIN_DESC.rst.CalcMotorSPV <> 0S Then
					Dim label As DataDynamics.ActiveReports.Label = Me.lblMotorSPVHdr
					Dim str As String = "(calc. speed var.: "
					rst = RSWIN_DESC.rst
					Dim motorSPV As Single = rst.MotorSPV
					Dim text As String = "##0.##%"
					Dim str2 As String = Util.Format(motorSPV, text)
					rst.MotorSPV = motorSPV
					label.Text = str + str2 + ")"
				Else
					Dim label2 As DataDynamics.ActiveReports.Label = Me.lblMotorSPVHdr
					Dim str3 As String = "(speed var.: "
					rst = RSWIN_DESC.rst
					Dim motorSPV As Single = rst.MotorSPV
					Dim text As String = "##0.##%"
					Dim str4 As String = Util.Format(motorSPV, text)
					rst.MotorSPV = motorSPV
					label2.Text = str3 + str4 + ")"
				End If
				Me.lblMotorSPV.Visible = False
				Me.SETPMLABELS()
				Dim array As DataDynamics.ActiveReports.Label()
				Me.MakeArray(4, array, Me.lblNEMAD, Me.lblNEMAD_BE, Me.lblNEMAD_BT, Me.lblNEMAD_E, Nothing, Nothing)
				Dim array2 As Single()
				Dim text2 As String
				If Operators.ConditionalCompareObjectEqual(Motor.GetMotorInfo(4), 7, False) Then
					rst = RSWIN_DESC.rst
					array2 = rst.HpNemaD
					Dim fEFactor As Single = 1F
					Dim fMFactor As Single = 1F
					Dim fEtoM As Single = 1F
					Dim text As String = "##0 \HP"
					Me.ShowBE(Me.sMarathonMotor, array2, fEFactor, fMFactor, fEtoM, text, True, array, True)
					rst.HpNemaD = array2
				ElseIf Operators.ConditionalCompareObjectEqual(Motor.GetMotorInfo(4), 8, False) Then
					rst = RSWIN_DESC.rst
					array2 = rst.HpNemaD
					Dim fEFactor2 As Single = 1F
					Dim fMFactor2 As Single = 1F
					Dim fEtoM2 As Single = 1F
					Dim text As String = "##0 \HP"
					Me.ShowBE(Me.sTatungMotor, array2, fEFactor2, fMFactor2, fEtoM2, text, True, array, True)
					rst.HpNemaD = array2
				ElseIf Operators.ConditionalCompareObjectGreater(Motor.GetMotorInfo(4), 8, False) Then
					Dim text As String = Me.GetMotorName(Conversions.ToInteger(Motor.GetMotorInfo(4)))
					rst = RSWIN_DESC.rst
					array2 = rst.HpNemaD
					Dim fEFactor3 As Single = 1F
					Dim fMFactor3 As Single = 1F
					Dim fEtoM3 As Single = 1F
					text2 = "##0 \HP"
					Me.ShowBE(text, array2, fEFactor3, fMFactor3, fEtoM3, text2, True, array, True)
					rst.HpNemaD = array2
				Else
					rst = RSWIN_DESC.rst
					array2 = rst.HpNemaD
					Dim fEFactor4 As Single = 1F
					Dim fMFactor4 As Single = 1F
					Dim fEtoM4 As Single = 1F
					text2 = "##0 \HP"
					Me.ShowBE(Me.sNEMADMotor, array2, fEFactor4, fMFactor4, fEtoM4, text2, True, array, True)
					rst.HpNemaD = array2
				End If
				Me.MakeArray(4, array, Me.lblSingleCyl, Me.lblSingleCyl_BE, Me.lblSingleCyl_BT, Me.lblSingleCyl_E, Nothing, Nothing)
				rst = RSWIN_DESC.rst
				array2 = rst.HpUhs
				Dim fEFactor5 As Single = 1F
				Dim fMFactor5 As Single = 1F
				Dim fEtoM5 As Single = 1F
				text2 = "##0 \HP"
				Me.ShowBE(Me.sSingleDoubleCylEngine, array2, fEFactor5, fMFactor5, fEtoM5, text2, True, array, True)
				rst.HpUhs = array2
				Me.MakeArray(4, array, Me.lblMultiCyl, Me.lblMultiCyl_BE, Me.lblMultiCyl_BT, Me.lblMultiCyl_E, Nothing, Nothing)
				rst = RSWIN_DESC.rst
				array2 = rst.HpNemaD
				Dim fEFactor6 As Single = 1F
				Dim fMFactor6 As Single = 1F
				Dim fEtoM6 As Single = 1F
				text2 = "##0 \HP"
				Me.ShowBE(Me.sMulticylinderEngine, array2, fEFactor6, fMFactor6, fEtoM6, text2, True, array, True)
				rst.HpNemaD = array2
			Else
				Me.lblReqPrimeMoverSize.Text = Me.sPrimeMoverSpeedVariation
				Me.lnPMSV.Visible = True
				Me.lblMotorSPVHdr.Visible = False
				If RSWIN_DESC.rst.CalcMotorSPV <> 0S Then
					Dim label3 As DataDynamics.ActiveReports.Label = Me.lblMotorSPVHdr
					Dim w As Object = 38
					Dim motorSPV2 As Single = RSWIN_DESC.rst.MotorSPV
					Dim text2 As String = "###.##%"
					label3.Text = RESULTS1.MkSumm(w, Me.sCalculatedSpeedVariation, motorSPV2, text2, False, False)
					Me.lblMotorSPVHdr.Visible = True
					Me.lblMotorSPV.Visible = False
				ElseIf RSWIN_DESC.rst.MotorSPV > 0F Then
					Dim label4 As DataDynamics.ActiveReports.Label = Me.lblMotorSPVHdr
					Dim w2 As Object = 38
					Dim motorSPV3 As Single = RSWIN_DESC.rst.MotorSPV
					Dim text2 As String = "###.##%"
					label4.Text = RESULTS1.MkSumm(w2, Me.sEnteredSpeedVariation, motorSPV3, text2, False, False)
					Me.lblMotorSPVHdr.Visible = True
					Me.lblMotorSPV.Visible = False
				Else
					Me.lblMotorSPVHdr.Text = Me.sSpeedVariationNotConsidered
					Me.lblMotorSPVHdr.Visible = True
					Me.lblMotorSPV.Visible = False
				End If
				Dim flag As Boolean = False
				Me.SetfraPmBalancedEVisible(flag)
				flag = False
				Me.SetfraPmBalancedTVisible(flag, False, True)
				flag = False
				Me.SetfraPmExistingVisible(flag, False, True)
				Me.lblNEMAD.Visible = False
				Me.lblMultiCyl.Visible = False
				Me.lblSingleCyl.Visible = False
				Me.Line8.Visible = False
			End If
		End Sub

		Private Sub SetfraPmBalancedEVisible(ByRef bVal As Boolean)
			If Not RSWIN_DESC.rst.CalcMotorSize <> 0S Then
				bVal = False
			End If
			Me.lblNEMAD_BE.Visible = bVal
			Me.lblMultiCyl_BE.Visible = bVal
			Me.lblSingleCyl_BE.Visible = bVal
			Me.lblPmMinEner.Visible = bVal
			Me.lblPmBalancedE.Visible = bVal
		End Sub

		Private Sub SetfraPmBalancedTVisible(ByRef bVal As Boolean, Optional bLeft As Boolean = False, Optional bSetVisible As Boolean = True)
			If Not RSWIN_DESC.rst.CalcMotorSize <> 0S Then
				bVal = False
			End If
			If bSetVisible Then
				Me.lblNEMAD_BT.Visible = bVal
				Me.lblMultiCyl_BT.Visible = bVal
				Me.lblSingleCyl_BT.Visible = bVal
				Me.lblPmMinTorq.Visible = bVal
				Me.lblPmBalancedT.Visible = bVal
			End If
			If bLeft Then
				Me.lblNEMAD_BT.Left = Me.lblNEMAD_BE.Left
				Me.lblMultiCyl_BT.Left = Me.lblMultiCyl_BE.Left
				Me.lblSingleCyl_BT.Left = Me.lblSingleCyl_BE.Left
				Me.lblPmMinTorq.Left = Me.lblPmMinEner.Left
				Me.lblPmBalancedT.Left = Me.lblPmBalancedE.Left
				If(Me.lblNEMAD_BT.Visible And Me.lblNEMAD_BE.Visible) Or (Me.lblMultiCyl_BT.Visible And Me.lblMultiCyl_BE.Visible) Or (Me.lblSingleCyl_BT.Visible And Me.lblSingleCyl_BE.Visible) Or (Me.lblPmMinTorq.Visible And Me.lblPmMinEner.Visible) Or (Me.lblPmBalancedT.Visible And Me.lblPmBalancedE.Visible) Then
					Dim flag As Boolean = False
					Me.SetfraPmBalancedEVisible(flag)
				End If
			End If
		End Sub

		Private Sub SetfraPmExistingVisible(ByRef bVal As Boolean, Optional bLeft As Boolean = False, Optional bSetVisible As Boolean = True)
			If Not RSWIN_DESC.rst.CalcMotorSize <> 0S Then
				bVal = False
			End If
			If bSetVisible Then
				Me.lblNEMAD_E.Visible = bVal
				Me.lblMultiCyl_E.Visible = bVal
				Me.lblSingleCyl_E.Visible = bVal
				Me.lblPmExisting.Visible = bVal
			End If
			If bLeft Then
				Me.lblNEMAD_E.Left = Me.lblNEMAD_BT.Left
				Me.lblMultiCyl_E.Left = Me.lblMultiCyl_BT.Left
				Me.lblSingleCyl_E.Left = Me.lblSingleCyl_BT.Left
				Me.lblPmExisting.Left = Me.lblPmBalancedT.Left
			End If
		End Sub

		Private Sub SetfraTqBalancedEVisible(bVal As Boolean)
			Me.lblTqBalancedE.Visible = bVal
			Me.lblTqMinEner.Visible = bVal
			Me.lblPeakTorque_BE.Visible = bVal
			Me.lblGearboxLoading_BE.Visible = bVal
			Me.lblCLF_BE.Visible = bVal
			Me.lblMCM_BE.Visible = bVal
			If RSWIN_DESC.rst.PU.UnitType <> 10S Then
				Me.lblCBE_BE.Visible = bVal
			End If
			Me.lblMotorKWH_BE.Visible = bVal
			Me.lblElectricBillPerMonth_BE.Visible = bVal
			Me.lblDollarsPerBblFluid_BE.Visible = bVal
			Me.lblDollarsPerBblOil_BE.Visible = bVal
		End Sub

		Private Sub SetfraTqBalancedTVisible(bVal As Boolean, Optional bLeft As Boolean = False, Optional bSetVisible As Boolean = True)
			If bSetVisible Then
				Me.lblTqBalancedT.Visible = bVal
				Me.lblTqMinTorq.Visible = bVal
				Me.lblPeakTorque_BT.Visible = bVal
				Me.lblGearboxLoading_BT.Visible = bVal
				Me.lblCLF_BT.Visible = bVal
				Me.lblMCM_BT.Visible = bVal
				If RSWIN_DESC.rst.PU.UnitType <> 10S Then
					Me.lblCBE_BT.Visible = bVal
				End If
				Me.lblMotorKWH_BT.Visible = bVal
				Me.lblElectricBillPerMonth_BT.Visible = bVal
				Me.lblDollarsPerBblFluid_BT.Visible = bVal
				Me.lblDollarsPerBblOil_BT.Visible = bVal
			End If
			If bLeft Then
				Me.lblTqMinTorq.Left = Me.lblTqMinEner.Left
				Me.lblTqBalancedT.Left = Me.lblTqBalancedE.Left
				Me.lblPeakTorque_BT.Left = Me.lblPeakTorque_BE.Left
				Me.lblGearboxLoading_BT.Left = Me.lblGearboxLoading_BE.Left
				Me.lblCLF_BT.Left = Me.lblCLF_BE.Left
				Me.lblMCM_BT.Left = Me.lblMCM_BE.Left
				Me.lblCBE_BT.Left = Me.lblCBE_BE.Left
				Me.lblMotorKWH_BT.Left = Me.lblMotorKWH_BE.Left
				Me.lblElectricBillPerMonth_BT.Left = Me.lblElectricBillPerMonth_BE.Left
				Me.lblDollarsPerBblFluid_BT.Left = Me.lblDollarsPerBblFluid_BE.Left
				Me.lblDollarsPerBblOil_BT.Left = Me.lblDollarsPerBblOil_BE.Left
			End If
		End Sub

		Private Sub SetfraTqExistingVisible(bVal As Boolean, Optional bLeft As Boolean = False, Optional bSetVisible As Boolean = True)
			If bSetVisible Then
				Me.lblTqExisting.Visible = bVal
				Me.lblPeakTorque_E.Visible = bVal
				Me.lblGearboxLoading_E.Visible = bVal
				Me.lblCLF_E.Visible = bVal
				Me.lblMCM_E.Visible = bVal
				If RSWIN_DESC.rst.PU.UnitType <> 10S Then
					Me.lblCBE_E.Visible = bVal
				End If
				Me.lblMotorKWH_E.Visible = bVal
				Me.lblElectricBillPerMonth_E.Visible = bVal
				Me.lblDollarsPerBblFluid_E.Visible = bVal
				Me.lblDollarsPerBblOil_E.Visible = bVal
			End If
			If bLeft Then
				Me.lblTqExisting.Left = Me.lblTqBalancedT.Left
				Me.lblPeakTorque_E.Left = Me.lblPeakTorque_BT.Left
				Me.lblGearboxLoading_E.Left = Me.lblGearboxLoading_BT.Left
				Me.lblCLF_E.Left = Me.lblCLF_BT.Left
				Me.lblMCM_E.Left = Me.lblMCM_BT.Left
				Me.lblCBE_E.Left = Me.lblCBE_BT.Left
				Me.lblMotorKWH_E.Left = Me.lblMotorKWH_BT.Left
				Me.lblElectricBillPerMonth_E.Left = Me.lblElectricBillPerMonth_BT.Left
				Me.lblDollarsPerBblFluid_E.Left = Me.lblDollarsPerBblFluid_BT.Left
				Me.lblDollarsPerBblOil_E.Left = Me.lblDollarsPerBblOil_BT.Left
			End If
		End Sub

		Private Sub ShowPumpingUnit()
			Try
				Dim rptCalcResults As rptCalcResults = Me
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					rptCalcResults.lblAPIDesignation.Text = Me.sUnitDesignation
				Else
					rptCalcResults.lblAPIDesignation.Text = Me.sAPIDesignation
				End If
				Dim text As String = Me.sUnit + RSWIN_DESC.rst.PU.Manuf.Trim()
				Dim text2 As String = RSWIN_DESC.rst.PU.UnitName.Trim()
				Dim text3 As String = RSWIN_DESC.rst.PU.OtherInfo.Trim()
				Try
					text2 = text2.Replace(vbNullChar, " ")
				Catch ex As Exception
				End Try
				If text2.Trim().Length > 0 Then
					Try
						Dim text4 As String = text.Trim()
						rptCalcResults.lblPumpingUnitHeader.Text = text4
						GoTo IL_19D
					Catch ex2 As Exception
						Dim text4 As String = text.Trim()
						If text4.Length >= 60 Then
							rptCalcResults.lblPumpingUnitHeader.Text = text4.Substring(0, 60)
						Else
							rptCalcResults.lblPumpingUnitHeader.Text = text4
						End If
						GoTo IL_19D
					End Try
				End If
				If text3.Length > 0 Then
					Try
						Dim text4 As String = text.Trim()
						rptCalcResults.lblPumpingUnitHeader.Text = text4
						GoTo IL_19D
					Catch ex3 As Exception
						Dim text4 As String = text.Trim()
						If text4.Length >= 60 Then
							rptCalcResults.lblPumpingUnitHeader.Text = text4.Substring(0, 60)
						Else
							rptCalcResults.lblPumpingUnitHeader.Text = text4
						End If
						GoTo IL_19D
					End Try
				End If
				rptCalcResults.lblPumpingUnitHeader.Text = text
				IL_19D:
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					Me.sAPISize = Me.sUnitSize
				End If
				If Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 Then
					rptCalcResults.lblAPIDesignation.Text = Util.FormatMessage(Me.sAPISize + "{0}{1}", New Object() { RESULTS1.VTrim(RSWIN_DESC.rst.PU.APIDesignation), RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.rst.IDEntered <> 0S, Util.FormatMessage(" (" + Me.sUnitID + "{0})", New Object() { "CUSTOM" }), Nothing)) })
				Else
					rptCalcResults.lblAPIDesignation.Text = Util.FormatMessage(Me.sAPISize + "{0}{1}", New Object() { RESULTS1.VTrim(RSWIN_DESC.rst.PU.APIDesignation), RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.rst.IDEntered <> 0S, Util.FormatMessage(" (" + Me.sUnitID + "{0})", New Object() { Strings.Trim(RSWIN_DESC.rst.UnitID) }), Nothing)) })
				End If
				If RSWIN_DESC.rst.CBDataFile IsNot Nothing Then
					If RSWIN_DESC.rst.CBDataFile.Length > 0 Then
						If Strings.InStr(RSWIN_DESC.rst.CBDataFile.ToLower(), ".xblx", CompareMethod.Binary) > 0 Then
							rptCalcResults.lblCBDataFile.Text = Util.FormatMessage(Me.sXBALFile + """{0}""", New Object() { Util.FileName(RSWIN_DESC.rst.CBDataFile) })
						Else
							rptCalcResults.lblCBDataFile.Text = Util.FormatMessage(Me.sCBALANCEFile + """{0}""", New Object() { Util.FileName(RSWIN_DESC.rst.CBDataFile) })
						End If
					Else
						rptCalcResults.lblCBDataFile.Visible = False
					End If
				Else
					rptCalcResults.lblCBDataFile.Visible = False
				End If
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					rptCalcResults.txtCrankHole.Text = Me.sNA
				ElseIf RSWIN_DESC.rst.IDEntered <> 0S Then
					rptCalcResults.txtCrankHole.Text = Util.FormatMessage("#{0} (out of {1})", New Object() { RSWIN_DESC.rst.PU.CrankHole, RSWIN_DESC.rst.PU.CrankHoles })
				Else
					rptCalcResults.lblCrankHole.Visible = False
				End If
				Dim text5 As String
				Dim text6 As String
				If RSWIN_DESC.rst.PU.UnitType <> 10S Then
					Dim label As DataDynamics.ActiveReports.Label = rptCalcResults.lblCrankRotation
					Dim w As Object = 36
					Dim value As Single = 0F
					text5 = Conversions.ToString(Interaction.IIf(RSWIN_DESC.rst.PU.CrankRotation = 1S, "#" + Me.sCW, "#" + Me.sCCW))
					label.Text = RESULTS1.MkSumm(w, Me.sRotationWithWellToRight, value, text5, True, False)
					Dim label2 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCrankRotation
					Dim w2 As Object = 4
					text5 = ""
					Dim value2 As Single = 0F
					text6 = Conversions.ToString(Interaction.IIf(RSWIN_DESC.rst.PU.CrankRotation = 1S, "#""CW""", "#""CCW"))
					label2.Text = RESULTS1.MkSumm(w2, text5, value2, text6, False, True)
				Else
					rptCalcResults.lblCrankRotation.Text = Me.sRotation
					rptCalcResults.txtCrankRotation.Text = Me.sNA
				End If
				Dim label3 As DataDynamics.ActiveReports.Label = rptCalcResults.lblStrokeLength
				Dim w3 As Object = 36
				Dim kinematicStroke As Single = RSWIN_DESC.rst.PU.KinematicStroke
				Dim in__CM As Single = RSWIN_DESC.IN__CM
				text6 = "#.#"
				text5 = "#.#"
				label3.Text = RESULTS1.MkSummEM(w3, Me.sCalculatedStrokeLength, kinematicStroke, in__CM, RSWIN_DESC.inch, text6, RSWIN_DESC.cm, text5, 1, True, False)
				Dim label4 As DataDynamics.ActiveReports.Label = rptCalcResults.txtStrokeLength
				Dim w4 As Object = 0
				text6 = ""
				Dim kinematicStroke2 As Single = RSWIN_DESC.rst.PU.KinematicStroke
				Dim in__CM2 As Single = RSWIN_DESC.IN__CM
				text5 = "#.#"
				Dim text7 As String = "#.#"
				label4.Text = RESULTS1.MkSummEM(w4, text6, kinematicStroke2, in__CM2, RSWIN_DESC.inch, text5, RSWIN_DESC.cm, text7, 1, False, True)
				Select Case RSWIN_DESC.rst.PU.UnitType
					Case 6S
						rptCalcResults.lblCwtInfo_1.Text = Me.sAirAtTankAt
						Dim text8 As String = Me.sBottomOfStroke
						If RSWIN_DESC.rst.UnknownM Then
							Dim label5 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_2
							Dim w5 As Object = 36
							Dim v As Single = 0F
							Dim etoM As Single = 1F
							text7 = "psig"
							label5.Text = RESULTS1.MkSummEM(w5, text8, v, etoM, text7, Me.c_UNKNOWN, RSWIN_DESC.kPa, Me.c_UNKNOWN, 1, True, False)
							Dim label6 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_2
							Dim w6 As Object = Me.c_UNKNOWN.Length
							Dim v2 As Single = 0F
							Dim etoM2 As Single = 1F
							text7 = "psig"
							label6.Text = RESULTS1.MkSummEM(w6, text8, v2, etoM2, text7, Me.c_UNKNOWN, RSWIN_DESC.kPa, Me.c_UNKNOWN, 1, False, True)
						Else
							Dim label7 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_2
							Dim w7 As Object = 36
							Dim v3 As Single = RSWIN_DESC.rst.get_M(2)
							Dim psi__KPA As Single = RSWIN_DESC.PSI__KPA
							text7 = "psig"
							text6 = "0"
							text5 = "0"
							label7.Text = RESULTS1.MkSummEM(w7, text8, v3, psi__KPA, text7, text6, RSWIN_DESC.kPa, text5, 1, True, False)
							Dim label8 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_2
							Dim w8 As Object = 0
							text7 = ""
							Dim v4 As Single = RSWIN_DESC.rst.get_M(2)
							Dim psi__KPA2 As Single = RSWIN_DESC.PSI__KPA
							text6 = "psig"
							text5 = "0"
							Dim text9 As String = "0"
							label8.Text = RESULTS1.MkSummEM(w8, text7, v4, psi__KPA2, text6, text5, RSWIN_DESC.kPa, text9, 1, False, True)
						End If
						rptCalcResults.lblCwtInfo_3.Visible = False
						rptCalcResults.lblCwtInfo_4.Visible = False
						rptCalcResults.lblCwtInfo_5.Visible = False
						rptCalcResults.txtCwtInfo_3.Visible = False
						rptCalcResults.txtCwtInfo_4.Visible = False
						rptCalcResults.txtCwtInfo_5.Visible = False
						GoTo IL_1622
					Case 7S, 10S
						Dim text8 As String = Me.sMaxCBweightl
						If RSWIN_DESC.rst.PU.UnitType = 7S Then
							If RSWIN_DESC.rst.UnknownM Then
								Dim label9 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_1
								Dim w9 As Object = 36
								Dim v5 As Single = 0F
								Dim etoM3 As Single = 1F
								Dim text9 As String = "M lbs"
								label9.Text = RESULTS1.MkSummEM(w9, text8, v5, etoM3, text9, Me.c_UNKNOWN, RSWIN_DESC.N, Me.c_UNKNOWN, 1, True, False)
								Dim label10 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_1
								Dim w10 As Object = Me.c_UNKNOWN.Length
								text9 = ""
								Dim v6 As Single = 0F
								Dim etoM4 As Single = 1F
								text7 = "M lbs"
								label10.Text = RESULTS1.MkSummEM(w10, text9, v6, etoM4, text7, Me.c_UNKNOWN, RSWIN_DESC.N, Me.c_UNKNOWN, 1, False, True)
							Else
								Dim label11 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_1
								Dim w11 As Object = 36
								Dim v7 As Single = RSWIN_DESC.rst.get_M(2) / 1000F
								Dim etoM5 As Single = RSWIN_DESC.LB__N * 1000F
								Dim text9 As String = "M lbs"
								text7 = "#.#"
								text6 = "#.#"
								label11.Text = RESULTS1.MkSummEM(w11, text8, v7, etoM5, text9, text7, RSWIN_DESC.N, text6, 1, True, False)
								Dim label12 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_1
								Dim w12 As Object = 0
								text9 = ""
								Dim v8 As Single = RSWIN_DESC.rst.get_M(2) / 1000F
								Dim etoM6 As Single = RSWIN_DESC.LB__N * 1000F
								text7 = "M lbs"
								text6 = "#.#"
								text5 = "#.#"
								label12.Text = RESULTS1.MkSummEM(w12, text9, v8, etoM6, text7, text6, RSWIN_DESC.N, text5, 1, False, True)
							End If
						Else
							rptCalcResults.lblCwtInfo_1.Text = text8
							rptCalcResults.txtCwtInfo_1.Text = Me.sNA
						End If
						If(Not RSWIN_DESC.rst.IDEntered And If((-If(((RSWIN_DESC.rst.PU.UnitType = 7S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							Dim label13 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_2
							Dim w13 As Object = 36
							Dim sprocketRadius As Single = RSWIN_DESC.rst.PU.SprocketRadius
							Dim in__CM3 As Single = RSWIN_DESC.IN__CM
							Dim text9 As String = "#.#"
							text7 = "#.#"
							label13.Text = RESULTS1.MkSummEM(w13, Me.sSprocketRadius, sprocketRadius, in__CM3, RSWIN_DESC.ins, text9, RSWIN_DESC.cm, text7, 1, True, False)
							Dim label14 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_3
							Dim w14 As Object = 36
							Dim sprocketDistance As Single = RSWIN_DESC.rst.PU.SprocketDistance
							Dim in__CM4 As Single = RSWIN_DESC.IN__CM
							text9 = "#.#"
							text7 = "#.#"
							label14.Text = RESULTS1.MkSummEM(w14, Me.sClineSprocketDistance, sprocketDistance, in__CM4, RSWIN_DESC.ins, text9, RSWIN_DESC.cm, text7, 1, True, False)
							Dim label15 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_4
							Dim w15 As Object = 36
							Dim drumDiamRatio As Single = RSWIN_DESC.rst.PU.DrumDiamRatio
							text9 = "0.0#"
							label15.Text = RESULTS1.MkSumm(w15, Me.sDrumDiameterRatio, drumDiamRatio, text9, True, False)
							Dim label16 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_2
							Dim w16 As Object = 0
							text9 = ""
							Dim sprocketRadius2 As Single = RSWIN_DESC.rst.PU.SprocketRadius
							Dim in__CM5 As Single = RSWIN_DESC.IN__CM
							text7 = "#.#"
							text6 = "#.#"
							label16.Text = RESULTS1.MkSummEM(w16, text9, sprocketRadius2, in__CM5, RSWIN_DESC.ins, text7, RSWIN_DESC.cm, text6, 1, False, True)
							Dim label17 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_3
							Dim w17 As Object = 0
							text9 = ""
							Dim sprocketDistance2 As Single = RSWIN_DESC.rst.PU.SprocketDistance
							Dim in__CM6 As Single = RSWIN_DESC.IN__CM
							text7 = "#.#"
							text6 = "#.#"
							label17.Text = RESULTS1.MkSummEM(w17, text9, sprocketDistance2, in__CM6, RSWIN_DESC.ins, text7, RSWIN_DESC.cm, text6, 1, False, True)
							Dim label18 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_4
							Dim w18 As Object = 0
							text9 = ""
							Dim drumDiamRatio2 As Single = RSWIN_DESC.rst.PU.DrumDiamRatio
							text7 = "0.0#"
							label18.Text = RESULTS1.MkSumm(w18, text9, drumDiamRatio2, text7, False, True)
							If RSWIN_DESC.rst.PU.P > 0F Then
								Dim label19 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_5
								Dim w19 As Object = 36
								Dim p As Single = RSWIN_DESC.rst.PU.P
								Dim in__CM7 As Single = RSWIN_DESC.IN__CM
								text9 = "#.#"
								text7 = "#.#"
								label19.Text = RESULTS1.MkSummEM(w19, Me.sPitmanArmLength, p, in__CM7, RSWIN_DESC.ins, text9, RSWIN_DESC.cm, text7, 1, True, False)
								Dim label20 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_5
								Dim w20 As Object = 0
								text9 = ""
								Dim p2 As Single = RSWIN_DESC.rst.PU.P
								Dim in__CM8 As Single = RSWIN_DESC.IN__CM
								text7 = "#.#"
								text6 = "#.#"
								label20.Text = RESULTS1.MkSummEM(w20, text9, p2, in__CM8, RSWIN_DESC.ins, text7, RSWIN_DESC.cm, text6, 1, False, True)
								GoTo IL_1622
							End If
							rptCalcResults.lblCwtInfo_5.Visible = False
							rptCalcResults.txtCwtInfo_5.Visible = False
							GoTo IL_1622
						Else
							If RSWIN_DESC.rst.PU.UnitType = 10S Then
								Dim label21 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_2
								Dim w21 As Object = 36
								Dim adjustedStrokeLength As Single = RSWIN_DESC.rst.AdjustedStrokeLength
								Dim in__CM9 As Single = RSWIN_DESC.IN__CM
								Dim text9 As String = "#.#"
								text7 = "#.#"
								label21.Text = RESULTS1.MkSummEM(w21, Me.sAdjustedStrokeLength, adjustedStrokeLength, in__CM9, RSWIN_DESC.inch, text9, RSWIN_DESC.cm, text7, 1, True, False)
								Dim label22 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_2
								Dim w22 As Object = 0
								text9 = ""
								Dim adjustedStrokeLength2 As Single = RSWIN_DESC.rst.AdjustedStrokeLength
								Dim in__CM10 As Single = RSWIN_DESC.IN__CM
								text7 = "#.#"
								text6 = "#.#"
								label22.Text = RESULTS1.MkSummEM(w22, text9, adjustedStrokeLength2, in__CM10, RSWIN_DESC.inch, text7, RSWIN_DESC.cm, text6, 1, False, True)
								rptCalcResults.lblCwtInfo_3.Visible = False
								rptCalcResults.txtCwtInfo_3.Visible = False
								rptCalcResults.lblCwtInfo_4.Visible = False
								rptCalcResults.lblCwtInfo_5.Visible = False
								rptCalcResults.txtCwtInfo_4.Visible = False
								rptCalcResults.txtCwtInfo_5.Visible = False
								GoTo IL_1622
							End If
							rptCalcResults.lblCwtInfo_2.Visible = False
							rptCalcResults.lblCwtInfo_3.Visible = False
							rptCalcResults.lblCwtInfo_4.Visible = False
							rptCalcResults.lblCwtInfo_5.Visible = False
							rptCalcResults.txtCwtInfo_2.Visible = False
							rptCalcResults.txtCwtInfo_3.Visible = False
							rptCalcResults.txtCwtInfo_4.Visible = False
							rptCalcResults.txtCwtInfo_5.Visible = False
							GoTo IL_1622
						End If
				End Select
				If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
					If RSWIN_DESC.rst.bUnknownUnbalance Then
						rptCalcResults.lblCwtInfo_1.Text = RESULTS1.MkSummEM(36, Me.sStructuralUnbalance, 0F, 1F, RSWIN_DESC.Minlbs, Me.c_UNKNOWN, RSWIN_DESC.Nm, Me.c_UNKNOWN, 1, True, False)
						Dim label23 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_1
						Dim w23 As Object = Me.c_UNKNOWN.Length
						Dim text9 As String = ""
						label23.Text = RESULTS1.MkSummEM(w23, text9, 0F, 1F, RSWIN_DESC.Minlbs, Me.c_UNKNOWN, RSWIN_DESC.Nm, Me.c_UNKNOWN, 1, False, True)
					Else
						Dim label24 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_1
						Dim w24 As Object = 36
						Dim unbalance As Single = RSWIN_DESC.rst.PU.Unbalance
						Dim lb__N As Single = RSWIN_DESC.LB__N
						Dim text9 As String = "0"
						text7 = "0"
						label24.Text = RESULTS1.MkSummEM(w24, Me.sStructuralUnbalance, unbalance, lb__N, RSWIN_DESC.lbs, text9, RSWIN_DESC.N, text7, 1, True, False)
						Dim label25 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_1
						Dim w25 As Object = 0
						Dim unbalance2 As Single = RSWIN_DESC.rst.PU.Unbalance
						Dim lb__N2 As Single = RSWIN_DESC.LB__N
						text9 = "0"
						text7 = "0"
						label25.Text = RESULTS1.MkSummEM(w25, Me.sStructuralUnbalance, unbalance2, lb__N2, RSWIN_DESC.lbs, text9, RSWIN_DESC.N, text7, 1, False, True)
					End If
					rptCalcResults.lblCwtInfo_2.Text = " "
					rptCalcResults.txtCwtInfo_2.Text = " "
					rptCalcResults.lblCwtInfo_3.Text = " "
					rptCalcResults.txtCwtInfo_3.Text = " "
				Else
					Dim text8 As String = Me.sMaxCBMoment
					If RSWIN_DESC.rst.UnknownM Then
						rptCalcResults.lblCwtInfo_1.Text = RESULTS1.MkSummEM(36, text8, 0F, 1F, RSWIN_DESC.Minlbs, Me.c_UNKNOWN, RSWIN_DESC.Nm, Me.c_UNKNOWN, 1, True, False)
						Dim label26 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_1
						Dim w26 As Object = Me.c_UNKNOWN.Length
						Dim text9 As String = ""
						label26.Text = RESULTS1.MkSummEM(w26, text9, 0F, 1F, RSWIN_DESC.Minlbs, Me.c_UNKNOWN, RSWIN_DESC.Nm, Me.c_UNKNOWN, 1, False, True)
					Else
						Dim label27 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_1
						Dim w27 As Object = 36
						Dim v9 As Single = RSWIN_DESC.rst.get_M(2) / 1000F
						Dim minlb__NM As Single = RSWIN_DESC.MINLB__NM
						Dim text9 As String = "0"
						text7 = "0"
						label27.Text = RESULTS1.MkSummEM(w27, text8, v9, minlb__NM, RSWIN_DESC.Minlbs, text9, RSWIN_DESC.Nm, text7, 1, True, False)
						Dim label28 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_1
						Dim w28 As Object = 0
						text9 = ""
						Dim v10 As Single = RSWIN_DESC.rst.get_M(2) / 1000F
						Dim minlb__NM2 As Single = RSWIN_DESC.MINLB__NM
						text7 = "0"
						text6 = "0"
						label28.Text = RESULTS1.MkSummEM(w28, text9, v10, minlb__NM2, RSWIN_DESC.Minlbs, text7, RSWIN_DESC.Nm, text6, 1, False, True)
					End If
					If RSWIN_DESC.rst.PU.UnitType = 9S Then
						rptCalcResults.lblCwtInfo_2.Text = ""
						rptCalcResults.txtCwtInfo_2.Text = ""
						Dim label29 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_2
						Dim w29 As Object = 36
						Dim value3 As Single = CSng((CDbl((RSWIN_DESC.rst.PU.CrankOffset * 180F)) / 3.141592653589793))
						Dim text9 As String = "0.0"
						label29.Text = RESULTS1.MkSumm(w29, Me.sCrankOffsetAngle, value3, text9, True, False)
						Dim label30 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_2
						Dim w30 As Object = 0
						Dim value4 As Single = CSng((CDbl((RSWIN_DESC.rst.PU.CrankOffset * 180F)) / 3.141592653589793))
						text9 = "0.0"
						label30.Text = RESULTS1.MkSumm(w30, Me.sCrankOffsetAngle, value4, text9, False, True)
						rptCalcResults.lblCwtInfo_3.Text = ""
						rptCalcResults.txtCwtInfo_3.Text = ""
					Else
						Dim label31 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_2
						Dim w31 As Object = 36
						Dim unbalance3 As Single = RSWIN_DESC.rst.PU.Unbalance
						Dim lb__N3 As Single = RSWIN_DESC.LB__N
						Dim text9 As String = "0"
						text7 = "0"
						label31.Text = RESULTS1.MkSummEM(w31, Me.sStructuralUnbalance, unbalance3, lb__N3, RSWIN_DESC.lbs, text9, RSWIN_DESC.N, text7, 1, True, False)
						Dim label32 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_2
						Dim w32 As Object = 0
						Dim unbalance4 As Single = RSWIN_DESC.rst.PU.Unbalance
						Dim lb__N4 As Single = RSWIN_DESC.LB__N
						text9 = "0"
						text7 = "0"
						label32.Text = RESULTS1.MkSummEM(w32, Me.sStructuralUnbalance, unbalance4, lb__N4, RSWIN_DESC.lbs, text9, RSWIN_DESC.N, text7, 1, False, True)
						Dim label33 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_3
						Dim w33 As Object = 36
						Dim value5 As Single = CSng((CDbl((RSWIN_DESC.rst.PU.CrankOffset * 180F)) / 3.141592653589793))
						text9 = "0.0"
						label33.Text = RESULTS1.MkSumm(w33, Me.sCrankOffsetAngle, value5, text9, True, False)
						Dim label34 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_3
						Dim w34 As Object = 0
						Dim value6 As Single = CSng((CDbl((RSWIN_DESC.rst.PU.CrankOffset * 180F)) / 3.141592653589793))
						text9 = "0.0"
						label34.Text = RESULTS1.MkSumm(w34, Me.sCrankOffsetAngle, value6, text9, False, True)
					End If
				End If
				If((If((-If((CDbl(RSWIN_DESC.rst.MotorSPV) > 0.0 > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV) And If((-If((Not Me.SpdVarIncludedNotWritten() > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Dim text9 As String
					If RSWIN_DESC.rst.IrotEntered <> 0S Then
						Dim label35 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_4
						Dim w35 As Object = 36
						Dim irot As Single = RSWIN_DESC.rst.Irot
						Dim lbft2__KGM As Single = RSWIN_DESC.LBFT2__KGM2
						text9 = "lb-ft²"
						text7 = "0"
						text6 = "kg-m²"
						text5 = "0"
						label35.Text = RESULTS1.MkSummEM(w35, Me.sEnteredRotInertia, irot, lbft2__KGM, text9, text7, text6, text5, 1, True, False)
					Else
						Dim label36 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_4
						Dim w36 As Object = 36
						Dim irot2 As Single = RSWIN_DESC.rst.Irot
						Dim lbft2__KGM2 As Single = RSWIN_DESC.LBFT2__KGM2
						text9 = "lb-ft²"
						text7 = "0"
						text6 = "kg-m²"
						text5 = "0"
						label36.Text = RESULTS1.MkSummEM(w36, Me.sBalRotInertia, irot2, lbft2__KGM2, text9, text7, text6, text5, 1, True, False)
					End If
					Dim label37 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_4
					Dim w37 As Object = 0
					text9 = ""
					Dim irot3 As Single = RSWIN_DESC.rst.Irot
					Dim lbft2__KGM3 As Single = RSWIN_DESC.LBFT2__KGM2
					text7 = "lb-ft²"
					text6 = "0"
					text5 = "kg-m²"
					Dim text10 As String = "0"
					label37.Text = RESULTS1.MkSummEM(w37, text9, irot3, lbft2__KGM3, text7, text6, text5, text10, 1, False, True)
					Dim label38 As DataDynamics.ActiveReports.Label = rptCalcResults.lblCwtInfo_5
					Dim w38 As Object = 36
					Dim iart As Single = RSWIN_DESC.rst.Iart
					Dim lbft2__KGM4 As Single = RSWIN_DESC.LBFT2__KGM2
					text10 = "lb-ft²"
					text9 = "0"
					text7 = "kg-m²"
					text6 = "0"
					label38.Text = RESULTS1.MkSummEM(w38, Me.sArtInertia, iart, lbft2__KGM4, text10, text9, text7, text6, 1, True, False)
					Dim label39 As DataDynamics.ActiveReports.Label = rptCalcResults.txtCwtInfo_5
					Dim w39 As Object = 0
					text10 = ""
					Dim iart2 As Single = RSWIN_DESC.rst.Iart
					Dim lbft2__KGM5 As Single = RSWIN_DESC.LBFT2__KGM2
					text9 = "lb-ft²"
					text7 = "0"
					text6 = "kg-m²"
					text5 = "0"
					label39.Text = RESULTS1.MkSummEM(w39, text10, iart2, lbft2__KGM5, text9, text7, text6, text5, 1, False, True)
				Else
					rptCalcResults.lblCwtInfo_4.Visible = False
					rptCalcResults.lblCwtInfo_5.Visible = False
					rptCalcResults.txtCwtInfo_4.Visible = False
					rptCalcResults.txtCwtInfo_5.Visible = False
				End If
				IL_1622:
				If(Not RSWIN_DESC.rst.IDEntered And If((-If((Not(RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Dim label40 As DataDynamics.ActiveReports.Label = rptCalcResults.lblPUDimR
					Dim w40 As Object = 10
					Dim text10 As String = "R"
					Dim r As Single = RSWIN_DESC.rst.PU.R
					Dim in__CM11 As Single = RSWIN_DESC.IN__CM
					Dim text9 As String = "#.###"
					text7 = "#.###"
					label40.Text = RESULTS1.MkSummEM(w40, text10, r, in__CM11, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label41 As DataDynamics.ActiveReports.Label = rptCalcResults.lblPUDimA
					Dim w41 As Object = 10
					text10 = "A"
					Dim a As Single = RSWIN_DESC.rst.PU.A
					Dim in__CM12 As Single = RSWIN_DESC.IN__CM
					text9 = "#.###"
					text7 = "#.###"
					label41.Text = RESULTS1.MkSummEM(w41, text10, a, in__CM12, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label42 As DataDynamics.ActiveReports.Label = rptCalcResults.lblPUDimC
					Dim w42 As Object = 10
					text10 = "C"
					Dim c As Single = RSWIN_DESC.rst.PU.C
					Dim in__CM13 As Single = RSWIN_DESC.IN__CM
					text9 = "#.###"
					text7 = "#.###"
					label42.Text = RESULTS1.MkSummEM(w42, text10, c, in__CM13, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label43 As DataDynamics.ActiveReports.Label = rptCalcResults.lblPUDimI
					Dim w43 As Object = 10
					text10 = "I"
					Dim i As Single = RSWIN_DESC.rst.PU.I
					Dim in__CM14 As Single = RSWIN_DESC.IN__CM
					text9 = "#.###"
					text7 = "#.###"
					label43.Text = RESULTS1.MkSummEM(w43, text10, i, in__CM14, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label44 As DataDynamics.ActiveReports.Label = rptCalcResults.lblPUDimK
					Dim w44 As Object = 10
					text10 = "K"
					Dim k As Single = RSWIN_DESC.rst.PU.K
					Dim in__CM15 As Single = RSWIN_DESC.IN__CM
					text9 = "#.###"
					text7 = "#.###"
					label44.Text = RESULTS1.MkSummEM(w44, text10, k, in__CM15, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label45 As DataDynamics.ActiveReports.Label = rptCalcResults.lblPUDimP
					Dim w45 As Object = 10
					text10 = "P"
					Dim p3 As Single = RSWIN_DESC.rst.PU.P
					Dim in__CM16 As Single = RSWIN_DESC.IN__CM
					text9 = "#.###"
					text7 = "#.###"
					label45.Text = RESULTS1.MkSummEM(w45, text10, p3, in__CM16, Me.sNull, text9, Me.sNull, text7, 1, False, False)
				Else
					rptCalcResults.lblPUDimR.Visible = False
					rptCalcResults.lblPUDimA.Visible = False
					rptCalcResults.lblPUDimC.Visible = False
					rptCalcResults.lblPUDimI.Visible = False
					rptCalcResults.lblPUDimK.Visible = False
					rptCalcResults.lblPUDimP.Visible = False
				End If
				If(Not RSWIN_DESC.rst.IDEntered And If((-If(((RSWIN_DESC.rst.PU.UnitType = 6S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Dim label46 As DataDynamics.ActiveReports.Label = rptCalcResults.lblPUDimM
					Dim w46 As Object = 10
					Dim text10 As String = "M"
					Dim m As Single = RSWIN_DESC.rst.PU.M
					Dim etoM7 As Single = 6.4516F
					Dim text9 As String = "#.###"
					text7 = "#.###"
					label46.Text = RESULTS1.MkSummEM(w46, text10, m, etoM7, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label47 As DataDynamics.ActiveReports.Label = rptCalcResults.lblPUDimS
					Dim w47 As Object = 10
					text10 = "S"
					Dim s As Single = RSWIN_DESC.rst.PU.S
					Dim etoM8 As Single = 6.894757F
					text9 = "#.###"
					text7 = "#.###"
					label47.Text = RESULTS1.MkSummEM(w47, text10, s, etoM8, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label48 As DataDynamics.ActiveReports.Label = rptCalcResults.lblPUDimV0
					Dim w48 As Object = 10
					text10 = "V0"
					Dim v11 As Single = RSWIN_DESC.rst.PU.V0
					Dim etoM9 As Single = 16.38706F
					text9 = "#.###"
					text7 = "#.###"
					label48.Text = RESULTS1.MkSummEM(w48, text10, v11, etoM9, Me.sNull, text9, Me.sNull, text7, 1, False, False)
				Else
					rptCalcResults.lblPUDimM.Visible = False
					rptCalcResults.lblPUDimS.Visible = False
					rptCalcResults.lblPUDimV0.Visible = False
				End If
				rptCalcResults = Nothing
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub ShowRodBotMinStressList(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
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
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodDiameterList(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
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

		Private Sub SetRodGradeList(I As Integer, ByRef avLabel As DataDynamics.ActiveReports.Label)
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
				If CDbl(RSWIN_DESC.rst.Sections(I).Diameter) = 1.15625 Then
					Dim num As Single = RSWIN_DESC.rst.Sections(I).Diameter * 16F
					Dim text2 As String = "0.0"
					text = Util.Format(num, text2) + "/16"
				Else
					Dim num As Single = RSWIN_DESC.rst.Sections(I).Diameter * 16F
					Dim text2 As String = "0"
					text = Util.Format(num, text2) + "/16"
				End If
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

		Private Sub ShowRodGradeList(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
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

		Private Sub ShowRodLengthList(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
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

		Private Sub ShowRodTensileStrengthList(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
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

		Private Sub ShowRodStressList(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
			Dim num As Long = 1L
			Do
				Dim num2 As Long = num
				If num2 <= 10L AndAlso num2 >= 1L Then
					Select Case CInt((num2 - 1L))
						Case 0
							If num > CLng(RSWIN_DESC.rst.NumRods) Or Not RSWIN_DESC.rst.gbOutputLoaded Then
								avLabels1.Visible = False
							Else
								Dim label As DataDynamics.ActiveReports.Label = avLabels1
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
								Dim label2 As DataDynamics.ActiveReports.Label = avLabels2
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
								Dim label3 As DataDynamics.ActiveReports.Label = avLabels3
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
								Dim label4 As DataDynamics.ActiveReports.Label = avLabels4
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
								Dim label5 As DataDynamics.ActiveReports.Label = avLabels5
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
								Dim label6 As DataDynamics.ActiveReports.Label = avLabels6
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
								Dim label7 As DataDynamics.ActiveReports.Label = avLabels7
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
								Dim label8 As DataDynamics.ActiveReports.Label = avLabels8
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
								Dim label9 As DataDynamics.ActiveReports.Label = avLabels9
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
								Dim label10 As DataDynamics.ActiveReports.Label = avLabels10
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

		Private Sub ShowRodStressMethodList(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
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
									Case 15
										text = "Edge FiberCo"
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
									Case 15
										text = "Edge FiberCo"
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
									Case 15
										text = "Edge FiberCo"
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
									Case 15
										text = "Edge FiberCo"
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
									Case 15
										text = "Edge FiberCo"
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
									Case 15
										text = "Edge FiberCo"
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
									Case 15
										text = "Edge FiberCo"
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
									Case 15
										text = "Edge FiberCo"
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
									Case 15
										text = "Edge FiberCo"
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
									Case 15
										text = "Edge FiberCo"
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

		Private Sub ShowNumberRodGuides(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
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

		Private Sub ShowRodTopMaxStressList(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
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
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowRodTopMinStressList(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
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
					End Select
				End If
				num += 1L
			Loop While num <= 20L
		End Sub

		Private Sub ShowFricCoefList(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
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
			Me.ShowRodStressList(Me.lblRodStress1, Me.lblRodStress2, Me.lblRodStress3, Me.lblRodStress4, Me.lblRodStress5, Me.lblRodStress6, Me.lblRodStress7, Me.lblRodStress8, Me.lblRodStress9, Me.lblRodStress10)
			Me.ShowRodTopMaxStressList(Me.lblRodTopMaxStress1, Me.lblRodTopMaxStress2, Me.lblRodTopMaxStress3, Me.lblRodTopMaxStress4, Me.lblRodTopMaxStress5, Me.lblRodTopMaxStress6, Me.lblRodTopMaxStress7, Me.lblRodTopMaxStress8, Me.lblRodTopMaxStress9, Me.lblRodTopMaxStress10)
			Me.ShowRodTopMinStressList(Me.lblRodTopMinStress1, Me.lblRodTopMinStress2, Me.lblRodTopMinStress3, Me.lblRodTopMinStress4, Me.lblRodTopMinStress5, Me.lblRodTopMinStress6, Me.lblRodTopMinStress7, Me.lblRodTopMinStress8, Me.lblRodTopMinStress9, Me.lblRodTopMinStress10)
			Me.ShowRodBotMinStressList(Me.lblRodBotMinStress1, Me.lblRodBotMinStress2, Me.lblRodBotMinStress3, Me.lblRodBotMinStress4, Me.lblRodBotMinStress5, Me.lblRodBotMinStress6, Me.lblRodBotMinStress7, Me.lblRodBotMinStress8, Me.lblRodBotMinStress9, Me.lblRodBotMinStress10)
			If Not RSWIN_DESC.bRodStarD Or RSWIN_DESC.rst.RodStringType = 3S Or (RSWIN_DESC.bRodStarD And RSWIN_DESC.SETUP_RECOMMEND_GUIDES) Then
				Me.ShowRodStressMethodList(Me.lblRodStressMethod1, Me.lblRodStressMethod2, Me.lblRodStressMethod3, Me.lblRodStressMethod4, Me.lblRodStressMethod5, Me.lblRodStressMethod6, Me.lblRodStressMethod7, Me.lblRodStressMethod8, Me.lblRodStressMethod9, Me.lblRodStressMethod10)
			Else
				Me.lblRodStressMethodHdrTop.Text = Me.sNumGuides1
				Me.lblRodStressMethodHdrBot.Text = Me.sNumGuides2
				Me.ShowNumberRodGuides(Me.lblRodStressMethod1, Me.lblRodStressMethod2, Me.lblRodStressMethod3, Me.lblRodStressMethod4, Me.lblRodStressMethod5, Me.lblRodStressMethod6, Me.lblRodStressMethod7, Me.lblRodStressMethod8, Me.lblRodStressMethod9, Me.lblRodStressMethod10)
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
					GoTo IL_C2
				Case 3S
					Me.lblRodStringDesign.Text = "Rod string design (rod tapers calculated)"
					GoTo IL_C2
			End Select
			Me.lblRodStringDesign.Text = "Rod string design"
			IL_C2:
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
			Me.ShowRodDiameterList(Me.lblRodDiam1, Me.lblRodDiam2, Me.lblRodDiam3, Me.lblRodDiam4, Me.lblRodDiam5, Me.lblRodDiam6, Me.lblRodDiam7, Me.lblRodDiam8, Me.lblRodDiam9, Me.lblRodDiam10)
			Me.ShowRodGradeList(Me.lblRodGrade1, Me.lblRodGrade2, Me.lblRodGrade3, Me.lblRodGrade4, Me.lblRodGrade5, Me.lblRodGrade6, Me.lblRodGrade7, Me.lblRodGrade8, Me.lblRodGrade9, Me.lblRodGrade10)
			Me.ShowRodLengthList(Me.lblRodLength1, Me.lblRodLength2, Me.lblRodLength3, Me.lblRodLength4, Me.lblRodLength5, Me.lblRodLength6, Me.lblRodLength7, Me.lblRodLength8, Me.lblRodLength9, Me.lblRodLength10)
			Me.ShowRodTensileStrengthList(Me.lblRodTensileStrength1, Me.lblRodTensileStrength2, Me.lblRodTensileStrength3, Me.lblRodTensileStrength4, Me.lblRodTensileStrength5, Me.lblRodTensileStrength6, Me.lblRodTensileStrength7, Me.lblRodTensileStrength8, Me.lblRodTensileStrength9, Me.lblRodTensileStrength10)
			Me.ShowFricCoefList(Me.lblFricCoef1, Me.lblFricCoef2, Me.lblFricCoef3, Me.lblFricCoef4, Me.lblFricCoef5, Me.lblFricCoef6, Me.lblFricCoef7, Me.lblFricCoef8, Me.lblFricCoef9, Me.lblFricCoef10)
			Dim lastTop As Single = CSng((CDbl(Me.m_LastTop) + 1.125 * CDbl(Me.lblRSFootnote1.Height)))
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
			Try
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
			Catch ex As Exception
			End Try
			Try
				Dim num2 As Integer
				If RSWIN.bHasRelocatedSB(num2) Then
					num += 1
					array(num) = RSWIN_DESC.sSBRelocateFootnote
				End If
			Catch ex2 As Exception
			End Try
			If num >= 1 Then
				Dim num3 As Integer = 1
				Dim num4 As Integer = num
				For i As Integer = num3 To num4
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
					Me.lblRSFootnote1.Top = CSng((CDbl(LastTop) + CDbl(LastHeight) * 1.27))
					LastTop = Me.lblRSFootnote1.Top
					If Strings.InStr(sLine, "Fiberod", CompareMethod.Binary) > 0 Then
						Me.lblRSFootnote1.ForeColor = Color.Red
					Else
						Me.lblRSFootnote1.ForeColor = Color.Black
					End If
				Case 2
					Me.lblRSFootnote2.Text = sLine
					Me.lblRSFootnote2.Top = LastTop + LastHeight
					LastTop = Me.lblRSFootnote2.Top
					If Strings.InStr(sLine, "Fiberod", CompareMethod.Binary) > 0 Then
						Me.lblRSFootnote2.ForeColor = Color.Red
					Else
						Me.lblRSFootnote2.ForeColor = Color.Black
					End If
				Case 3
					Me.lblRSFootnote3.Text = sLine
					Me.lblRSFootnote3.Top = LastTop + LastHeight
					LastTop = Me.lblRSFootnote3.Top
					If Strings.InStr(sLine, "Fiberod", CompareMethod.Binary) > 0 Then
						Me.lblRSFootnote3.ForeColor = Color.Red
					Else
						Me.lblRSFootnote3.ForeColor = Color.Black
					End If
				Case 4
					Me.lblRSFootnote4.Text = sLine
					Me.lblRSFootnote4.Top = LastTop + LastHeight
					LastTop = Me.lblRSFootnote4.Top
					If Strings.InStr(sLine, "Fiberod", CompareMethod.Binary) > 0 Then
						Me.lblRSFootnote4.ForeColor = Color.Red
					Else
						Me.lblRSFootnote4.ForeColor = Color.Black
					End If
				Case 5
					Me.lblRSFootnote5.Text = sLine
					Me.lblRSFootnote5.Top = LastTop + LastHeight
					LastTop = Me.lblRSFootnote5.Top
					If Strings.InStr(sLine, "Fiberod", CompareMethod.Binary) > 0 Then
						Me.lblRSFootnote5.ForeColor = Color.Red
					Else
						Me.lblRSFootnote5.ForeColor = Color.Black
					End If
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
			Dim obj As Object
			Dim obj2 As Object
			If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, cRODSTAR.NumRods, 1, obj2, obj) Then
				While RODUTIL.IsCorod(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade)
					If Not ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj2, obj) Then
						GoTo IL_A5
					End If
				End While
				Me.mbCorodSEString = False
			End If
			IL_A5:
			Me.mbMsgFullOKNeeded = False
			Me.mbMsgSlimNeededNeeded = False
			Me.mbMsgElevatorNeck1_0Needed = False
			Me.mbMsgNoNeckNeeded = False
			Dim obj3 As Object
			If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, cRODSTAR.NumRods, 1, obj3, obj) Then
				Do
					Dim quiet As Object = True
					Dim grade As Object = cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade
					Dim diameter As Object = cRODSTAR.Sections(Conversions.ToInteger(obj)).Diameter
					Dim obj4 As Object = Me.sNull
					Dim flag As Boolean
					Dim obj5 As Object = flag
					Dim obj6 As Object
					Dim obj7 As Object
					RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj6, obj7, obj4, obj5, RuntimeHelpers.GetObjectValue(obj))
					flag = Conversions.ToBoolean(obj5)
					Me.sNull = Conversions.ToString(obj4)
					If Conversions.ToBoolean(Operators.NotObject(obj6)) Then
						text6 = "*"
						Me.mbMsgFullOKNeeded = True
					ElseIf Conversions.ToBoolean(obj7) Then
						text6 = "+"
						Me.mbMsgSlimNeededNeeded = True
					Else
						text6 = " "
					End If
					If RODUTIL.IsFG(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade) Then
						text6 += " "
					ElseIf RODUTIL.IsNoNeck(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade) Then
						text6 += "#"
						Me.mbMsgNoNeckNeeded = True
					Else
						Dim diameter2 As Single = cRODSTAR.Sections(Conversions.ToInteger(obj)).Diameter
						If diameter2 >= 1.374F Then
							text6 += "@"
							Me.mbMsgElevatorNeck1_0Needed = True
						ElseIf RODUTIL.IsSinkerBar(RuntimeHelpers.GetObjectValue(obj)) Then
							text6 += "@"
							Me.mbMsgElevatorNeck1_0Needed = True
						Else
							text6 += " "
						End If
					End If
					If RODUTIL.IsCorodH(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade) Then
						text = Me.sNA
					ElseIf RODUTIL.IsCorod(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade) Then
						If cRODSTAR.Sections(Conversions.ToInteger(obj)).Diameter > 1F Then
							Dim num As Single = cRODSTAR.Sections(Conversions.ToInteger(obj)).Diameter * 16F
							Dim text7 As String = "0.0"
							text = Util.Format(num, text7) + "/16"
						Else
							Dim num As Single = cRODSTAR.Sections(Conversions.ToInteger(obj)).Diameter * 16F
							Dim text7 As String = "0"
							text = Util.Format(num, text7) + "/16"
						End If
						If Not Me.mbCorodSEString And RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							text += """"
						End If
					ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						Dim num As Single = cRODSTAR.Sections(Conversions.ToInteger(obj)).Diameter * RSWIN_DESC.IN__MM
						Dim text7 As String = "0.0"
						text = Util.Format(num, text7)
					Else
						Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
						Dim num2 As Integer = Conversions.ToInteger(obj)
						Dim text7 As String = "0.0###"
						text = Util.Format(sections(num2).Diameter, text7)
					End If
					If CUSTOMRG.IsOtherFG(CInt(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade)) Then
						Dim grade2 As Integer = CInt(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade)
						Dim num As Single = 0F
						text2 = RODUTIL.GetOtherFG(grade2, num)
					ElseIf CUSTOMRG.IsOtherSinkerBar(CInt(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade)) Then
						Dim grade3 As Integer = CInt(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade)
						Dim num As Single = 0F
						text2 = RODUTIL.GetOtherSinkerbar(grade3, num)
					ElseIf CUSTOMRG.IsOtherSteel(CInt(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade)) Then
						Dim grade4 As Integer = CInt(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade)
						Dim num As Single = 0F
						text2 = RODUTIL.GetOtherSteel(grade4, num)
					ElseIf RODUTIL.IsCorodH(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade) Then
						If CDbl(cRODSTAR.Sections(Conversions.ToInteger(obj)).Area) < 0.7 Then
							text2 += " 682"
						Else
							text2 += " 757"
						End If
					ElseIf RODUTIL.IsProRod(CInt(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade)) <> 0 Then
						If cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade = 24577S Then
							text2 = "Pro Rod 620"
						Else
							text2 = "Pro Rod 790"
						End If
					Else
						text2 = RODUTIL.RodGrade(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade)
					End If
					text2 = Strings.Left(text2, 13)
					text2 = Strings.Space(13 - Strings.Len(text2) / 2) + text2
					If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
						Dim sections2 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
						Dim num3 As Integer = Conversions.ToInteger(obj)
						Dim text7 As String = "0"
						text3 = Util.Format(sections2(num3).length, text7)
					Else
						Dim num As Single = cRODSTAR.Sections(Conversions.ToInteger(obj)).length * RSWIN_DESC.FT__M
						Dim text7 As String = "0"
						text3 = Util.Format(num, text7)
					End If
					If RODUTIL.IsAPI(CInt(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade), cRODSTAR.Sections(Conversions.ToInteger(obj)).RodType) Then
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							Dim num As Single = cRODSTAR.Sections(Conversions.ToInteger(obj)).TensileStrength * RSWIN_DESC.PSI__KPA
							Dim text7 As String = "0"
							text5 = Util.Format(num, text7)
						Else
							Dim sections3 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
							Dim num4 As Integer = Conversions.ToInteger(obj)
							Dim text7 As String = "0"
							text5 = Util.Format(sections3(num4).TensileStrength, text7)
						End If
					Else
						Try
							If cRODSTAR.Sections(Conversions.ToInteger(obj)).TensileStrength = 0F Then
								RODUTIL.LookupTensileStrength(cRODSTAR.Sections(Conversions.ToInteger(obj)))
							End If
							If cRODSTAR.Sections(Conversions.ToInteger(obj)).TensileStrength <> 0F Then
								If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									Dim num As Single = cRODSTAR.Sections(Conversions.ToInteger(obj)).TensileStrength * RSWIN_DESC.PSI__KPA
									Dim text7 As String = "0"
									text5 = Util.Format(num, text7)
								Else
									Dim sections4 As RSWIN_DESC.RodSection() = cRODSTAR.Sections
									Dim num5 As Integer = Conversions.ToInteger(obj)
									Dim text7 As String = "0"
									text5 = Util.Format(sections4(num5).TensileStrength, text7)
								End If
							Else
								text5 = Me.sNA
							End If
						Catch ex As Exception
							text5 = Me.sNA
						End Try
					End If
					LastHeight = Me.lblRodDiam1.Height
					Dim obj8 As Object = obj
					If Operators.ConditionalCompareObjectEqual(obj8, 1, False) Then
						Me.lblRodDiam1.Text = text6 + text
						Me.lblRodGrade1.Text = text2
						Me.lblRodLength1.Text = text3
						Me.lblRodTensileStrength1.Text = text5
						LastTop = Me.lblRodDiam1.Top
					ElseIf Operators.ConditionalCompareObjectEqual(obj8, 2, False) Then
						Me.lblRodDiam2.Text = text6 + text
						Me.lblRodGrade2.Text = text2
						Me.lblRodLength2.Text = text3
						Me.lblRodTensileStrength2.Text = text5
						LastTop = Me.lblRodDiam2.Top
					ElseIf Operators.ConditionalCompareObjectEqual(obj8, 3, False) Then
						Me.lblRodDiam3.Text = text6 + text
						Me.lblRodGrade3.Text = text2
						Me.lblRodLength3.Text = text3
						Me.lblRodTensileStrength3.Text = text5
						LastTop = Me.lblRodDiam3.Top
					ElseIf Operators.ConditionalCompareObjectEqual(obj8, 4, False) Then
						Me.lblRodDiam4.Text = text6 + text
						Me.lblRodGrade4.Text = text2
						Me.lblRodLength4.Text = text3
						Me.lblRodTensileStrength4.Text = text5
						LastTop = Me.lblRodDiam4.Top
					ElseIf Operators.ConditionalCompareObjectEqual(obj8, 5, False) Then
						Me.lblRodDiam5.Text = text6 + text
						Me.lblRodGrade5.Text = text2
						Me.lblRodLength5.Text = text3
						Me.lblRodTensileStrength5.Text = text5
						LastTop = Me.lblRodDiam5.Top
					ElseIf Operators.ConditionalCompareObjectEqual(obj8, 6, False) Then
						Me.lblRodDiam6.Text = text6 + text
						Me.lblRodGrade6.Text = text2
						Me.lblRodLength6.Text = text3
						Me.lblRodTensileStrength6.Text = text5
						LastTop = Me.lblRodDiam6.Top
					ElseIf Operators.ConditionalCompareObjectEqual(obj8, 7, False) Then
						Me.lblRodDiam7.Text = text6 + text
						Me.lblRodGrade7.Text = text2
						Me.lblRodLength7.Text = text3
						Me.lblRodTensileStrength7.Text = text5
						LastTop = Me.lblRodDiam7.Top
					ElseIf Operators.ConditionalCompareObjectEqual(obj8, 8, False) Then
						Me.lblRodDiam8.Text = text6 + text
						Me.lblRodGrade8.Text = text2
						Me.lblRodLength8.Text = text3
						Me.lblRodTensileStrength8.Text = text5
						LastTop = Me.lblRodDiam8.Top
					ElseIf Operators.ConditionalCompareObjectEqual(obj8, 9, False) Then
						Me.lblRodDiam9.Text = text6 + text
						Me.lblRodGrade9.Text = text2
						Me.lblRodLength9.Text = text3
						Me.lblRodTensileStrength9.Text = text5
						LastTop = Me.lblRodDiam9.Top
					ElseIf Operators.ConditionalCompareObjectEqual(obj8, 10, False) Then
						Me.lblRodDiam10.Text = text6 + text
						Me.lblRodGrade10.Text = text2
						Me.lblRodLength10.Text = text3
						Me.lblRodTensileStrength10.Text = text5
						LastTop = Me.lblRodDiam10.Top
					End If
					text4 = String.Concat(New String() { text6, " ", text, Strings.Space(7 - Strings.Len(text)), "|", text2, Strings.Space(13 - Strings.Len(text2)), "|  ", text3, Strings.Space(6 - Strings.Len(text3)), "|     ", text5 })
					RESULTS1.Trx(text4, "|", ChrW(1))
				Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj3, obj)
			End If
			cRODSTAR = Nothing
		End Sub

		Private Sub ShowTorqueAnalysis()
			Try
				Dim str As String
				Dim str2 As String
				Dim str3 As String
				Dim str4 As String
				Dim str5 As String
				Dim str6 As String
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					str = "(" + RSWIN_DESC.Nm + "):"
					str2 = "(" + RSWIN_DESC.kPa + "):"
					str3 = "(" + RSWIN_DESC.N + "):"
					str4 = "(" + RSWIN_DESC.Nm + "):"
					str5 = "(" + RSWIN_DESC.N + "):"
					str6 = "(" + RSWIN_DESC.N + "):"
				Else
					str = "(" + RSWIN_DESC.Minlbs + "):"
					str2 = "(" + RSWIN_DESC.psig + "):"
					str3 = "(" + RSWIN_DESC.Mlbs + "):"
					str4 = "(" + RSWIN_DESC.Minlbs + "):"
					str5 = "(" + RSWIN_DESC.lbs + "):"
					str6 = "(" + RSWIN_DESC.lbs + "):"
				End If
				Dim str7 As String
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					str7 = RSWIN_DESC.bbl
				Else
					str7 = RSWIN_DESC.m3
				End If
				If Not RODUTIL.IsCrankBalanced(RSWIN_DESC.rst.PU.UnitType) And Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) Then
					RSWIN_DESC.rst.CBE90(0) = 0F
					RSWIN_DESC.rst.CBE90(1) = 0F
					RSWIN_DESC.rst.CBE90(2) = 0F
				End If
				Me.SETTORQUELABELS()
				If Not RSWIN_DESC.rst.gbOutputLoaded Then
					Dim array As Single() = New Single(2) {}
					Dim array2 As DataDynamics.ActiveReports.Label()
					Me.MakeArray(4, array2, Me.lblPeakTorque, Me.lblPeakTorque_BE, Me.lblPeakTorque_BT, Me.lblPeakTorque_E, Nothing, Nothing)
					Dim text As String = Nothing
					Dim fEFactor As Single = 0F
					Dim fMFactor As Single = 0F
					Dim fEtoM As Single = 0F
					Dim text2 As String = "#"
					Me.ShowBE(text, array, fEFactor, fMFactor, fEtoM, text2, True, array2, True)
					Me.MakeArray(4, array2, Me.lblGearboxLoading, Me.lblGearboxLoading_BE, Me.lblGearboxLoading_BT, Me.lblGearboxLoading_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor2 As Single = 0F
					Dim fMFactor2 As Single = 0F
					Dim fEtoM2 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor2, fMFactor2, fEtoM2, text, True, array2, True)
					Me.MakeArray(4, array2, Me.lblCLF, Me.lblCLF_BE, Me.lblCLF_BT, Me.lblCLF_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor3 As Single = 0F
					Dim fMFactor3 As Single = 0F
					Dim fEtoM3 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor3, fMFactor3, fEtoM3, text, True, array2, True)
					Me.MakeArray(4, array2, Me.lblMCM, Me.lblMCM_BE, Me.lblMCM_BT, Me.lblMCM_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor4 As Single = 0F
					Dim fMFactor4 As Single = 0F
					Dim fEtoM4 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor4, fMFactor4, fEtoM4, text, True, array2, True)
					Me.MakeArray(4, array2, Me.lblCBE, Me.lblCBE_BE, Me.lblCBE_BT, Me.lblCBE_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor5 As Single = 0F
					Dim fMFactor5 As Single = 0F
					Dim fEtoM5 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor5, fMFactor5, fEtoM5, text, True, array2, True)
					Me.MakeArray(4, array2, Me.lblMotorKWH, Me.lblMotorKWH_BE, Me.lblMotorKWH_BT, Me.lblMotorKWH_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor6 As Single = 0F
					Dim fMFactor6 As Single = 0F
					Dim fEtoM6 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor6, fMFactor6, fEtoM6, text, True, array2, True)
					Me.MakeArray(4, array2, Me.lblElectricBillPerMonth, Me.lblElectricBillPerMonth_BE, Me.lblElectricBillPerMonth_BT, Me.lblElectricBillPerMonth_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor7 As Single = 0F
					Dim fMFactor7 As Single = 0F
					Dim fEtoM7 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor7, fMFactor7, fEtoM7, text, True, array2, True)
					Me.MakeArray(4, array2, Me.lblDollarsPerBblFluid, Me.lblDollarsPerBblFluid_BE, Me.lblDollarsPerBblFluid_BT, Me.lblDollarsPerBblFluid_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor8 As Single = 0F
					Dim fMFactor8 As Single = 0F
					Dim fEtoM8 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor8, fMFactor8, fEtoM8, text, True, array2, True)
					Me.MakeArray(4, array2, Me.lblDollarsPerBblOil, Me.lblDollarsPerBblOil_BE, Me.lblDollarsPerBblOil_BT, Me.lblDollarsPerBblOil_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor9 As Single = 0F
					Dim fMFactor9 As Single = 0F
					Dim fEtoM9 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor9, fMFactor9, fEtoM9, text, True, array2, True)
				Else
					Dim array2 As DataDynamics.ActiveReports.Label()
					Dim text As String
					Dim text2 As String
					Dim rst As cRODSTAR
					Dim array3 As Single()
					If RSWIN_DESC.rst.PU.UnitType <> 10S Then
						Me.MakeArray(4, array2, Me.lblPeakTorque, Me.lblPeakTorque_BE, Me.lblPeakTorque_BT, Me.lblPeakTorque_E, Nothing, Nothing)
						text2 = Me.sPeakGboxTorq + str
						rst = RSWIN_DESC.rst
						array3 = rst.PeakTorque
						Dim fEFactor10 As Single = 0.001F
						Dim fMFactor10 As Single = 0.001F
						Dim minlb__NM As Single = RSWIN_DESC.MINLB__NM
						text = "0"
						Me.ShowBE(text2, array3, fEFactor10, fMFactor10, minlb__NM, text, True, array2, True)
						rst.PeakTorque = array3
					Else
						Me.lblPeakTorque.Text = Me.sPeakGboxTorq
						Me.lblPeakTorque_BE.Text = Me.sNA
						Me.lblPeakTorque_BT.Text = Me.sNA
						Me.lblPeakTorque_E.Text = Me.sNA
					End If
					If RSWIN_DESC.rst.PU.UnitType <> 10S Then
						Me.MakeArray(4, array2, Me.lblGearboxLoading, Me.lblGearboxLoading_BE, Me.lblGearboxLoading_BT, Me.lblGearboxLoading_E, Nothing, Nothing)
						rst = RSWIN_DESC.rst
						array3 = rst.GearboxLoading
						Dim fEFactor11 As Single = 1F
						Dim fMFactor11 As Single = 1F
						Dim fEtoM10 As Single = 1F
						text2 = "###.#%"
						Me.ShowBE(Me.sGearboxLoading, array3, fEFactor11, fMFactor11, fEtoM10, text2, True, array2, True)
						rst.GearboxLoading = array3
						Me.MakeArray(4, array2, Me.lblCLF, Me.lblCLF_BE, Me.lblCLF_BT, Me.lblCLF_E, Nothing, Nothing)
						rst = RSWIN_DESC.rst
						array3 = rst.Clf
						Dim fEFactor12 As Single = 1F
						Dim fMFactor12 As Single = 1F
						Dim fEtoM11 As Single = 1F
						text2 = "#.###"
						Me.ShowBE(Me.sCyclicLoadFactor, array3, fEFactor12, fMFactor12, fEtoM11, text2, True, array2, True)
						rst.Clf = array3
					Else
						Me.lblGearboxLoading.Text = Me.sGearboxLoading
						Me.lblGearboxLoading_BE.Text = Me.sNA
						Me.lblGearboxLoading_BT.Text = Me.sNA
						Me.lblGearboxLoading_E.Text = Me.sNA
						Me.lblCLF.Text = Me.sCyclicLoadFactor
						Me.lblCLF_BE.Text = Me.sNA
						Me.lblCLF_BT.Text = Me.sNA
						Me.lblCLF_E.Text = Me.sNA
					End If
					If RSWIN_DESC.rst.PU.UnitType = 6S Then
						Me.MakeArray(4, array2, Me.lblMCM, Me.lblMCM_BE, Me.lblMCM_BT, Me.lblMCM_E, Nothing, Nothing)
						text2 = Me.sMaxAirTankPres + str2
						rst = RSWIN_DESC.rst
						array3 = rst.M
						Dim fEFactor13 As Single = 1F
						Dim fMFactor13 As Single = 1F
						Dim psi__KPA As Single = RSWIN_DESC.PSI__KPA
						text = "0"
						Me.ShowBE(text2, array3, fEFactor13, fMFactor13, psi__KPA, text, True, array2, True)
						rst.M = array3
						Me.MakeArray(4, array2, Me.lblCBE, Me.lblCBE_BE, Me.lblCBE_BT, Me.lblCBE_E, Nothing, Nothing)
						rst = RSWIN_DESC.rst
						array3 = rst.CBE90
						Dim fEFactor14 As Single = 1F
						Dim fMFactor14 As Single = 1F
						Dim lb__N As Single = RSWIN_DESC.LB__N
						text2 = "#"
						Me.ShowBE(Me.sNull, array3, fEFactor14, fMFactor14, lb__N, text2, True, array2, False)
						rst.CBE90 = array3
					ElseIf RSWIN_DESC.rst.PU.UnitType = 7S Then
						Me.MakeArray(4, array2, Me.lblMCM, Me.lblMCM_BE, Me.lblMCM_BT, Me.lblMCM_E, Nothing, Nothing)
						text2 = Me.sCounterbalanceWeight + str3
						rst = RSWIN_DESC.rst
						array3 = rst.M
						Dim fEFactor15 As Single = 0.001F
						Dim fMFactor15 As Single = 1F
						Dim lb__N2 As Single = RSWIN_DESC.LB__N
						text = "0.0#"
						Me.ShowBE(text2, array3, fEFactor15, fMFactor15, lb__N2, text, True, array2, True)
						rst.M = array3
						Me.MakeArray(4, array2, Me.lblCBE, Me.lblCBE_BE, Me.lblCBE_BT, Me.lblCBE_E, Nothing, Nothing)
						rst = RSWIN_DESC.rst
						array3 = rst.CBE90
						Dim fEFactor16 As Single = 1F
						Dim fMFactor16 As Single = 1F
						Dim lb__N3 As Single = RSWIN_DESC.LB__N
						text2 = "#"
						Me.ShowBE(Me.sNull, array3, fEFactor16, fMFactor16, lb__N3, text2, True, array2, False)
						rst.CBE90 = array3
					ElseIf RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
						Me.MakeArray(4, array2, Me.lblMCM, Me.lblMCM_BE, Me.lblMCM_BT, Me.lblMCM_E, Nothing, Nothing)
						text2 = Me.sReqUnbalance + " " + str6
						rst = RSWIN_DESC.rst
						array3 = rst.RequiredUnbalance
						Dim fEFactor17 As Single = 1F
						Dim fMFactor17 As Single = 1F
						Dim lb__N4 As Single = RSWIN_DESC.LB__N
						text = "0.0#"
						Me.ShowBE(text2, array3, fEFactor17, fMFactor17, lb__N4, text, True, array2, True)
						rst.RequiredUnbalance = array3
						Me.MakeArray(4, array2, Me.lblCBE, Me.lblCBE_BE, Me.lblCBE_BT, Me.lblCBE_E, Nothing, Nothing)
						text2 = Me.sCounterbalanceEffect + str5
						rst = RSWIN_DESC.rst
						array3 = rst.CBE90
						Dim fEFactor18 As Single = 1F
						Dim fMFactor18 As Single = 1F
						Dim lb__N5 As Single = RSWIN_DESC.LB__N
						text = "0"
						Me.ShowBE(text2, array3, fEFactor18, fMFactor18, lb__N5, text, True, array2, True)
						rst.CBE90 = array3
					ElseIf RSWIN_DESC.rst.PU.UnitType = 10S Then
						Me.lblMCM.Text = Me.sCounterbalanceWeight
						Me.lblMCM_BE.Text = Me.sNA
						Me.lblMCM_BT.Text = Me.sNA
						Me.lblMCM_E.Text = Me.sNA
						Me.lblCBE.Visible = False
						Me.lblCBE_BE.Visible = False
						Me.lblCBE_BT.Visible = False
						Me.lblCBE_E.Visible = False
					Else
						Me.MakeArray(4, array2, Me.lblMCM, Me.lblMCM_BE, Me.lblMCM_BT, Me.lblMCM_E, Nothing, Nothing)
						text2 = Me.sMaxCBMoment + " " + str4
						rst = RSWIN_DESC.rst
						array3 = rst.M
						Dim fEFactor19 As Single = 0.001F
						Dim fMFactor19 As Single = 0.001F
						Dim minlb__NM2 As Single = RSWIN_DESC.MINLB__NM
						text = "0.0#"
						Me.ShowBE(text2, array3, fEFactor19, fMFactor19, minlb__NM2, text, True, array2, True)
						rst.M = array3
						Me.MakeArray(4, array2, Me.lblCBE, Me.lblCBE_BE, Me.lblCBE_BT, Me.lblCBE_E, Nothing, Nothing)
						text2 = Me.sCounterbalanceEffect + str5
						rst = RSWIN_DESC.rst
						array3 = rst.CBE90
						Dim fEFactor20 As Single = 1F
						Dim fMFactor20 As Single = 1F
						Dim lb__N6 As Single = RSWIN_DESC.LB__N
						text = "0"
						Me.ShowBE(text2, array3, fEFactor20, fMFactor20, lb__N6, text, True, array2, True)
						rst.CBE90 = array3
					End If
					Me.MakeArray(4, array2, Me.lblMotorKWH, Me.lblMotorKWH_BE, Me.lblMotorKWH_BT, Me.lblMotorKWH_E, Nothing, Nothing)
					rst = RSWIN_DESC.rst
					array3 = rst.MotorKWH
					Dim fEFactor21 As Single = 1F
					Dim fMFactor21 As Single = 1F
					Dim fEtoM12 As Single = 1F
					text2 = "###0"
					Me.ShowBE(Me.sDailyElectrUse, array3, fEFactor21, fMFactor21, fEtoM12, text2, True, array2, True)
					rst.MotorKWH = array3
					Me.MakeArray(4, array2, Me.lblElectricBillPerMonth, Me.lblElectricBillPerMonth_BE, Me.lblElectricBillPerMonth_BT, Me.lblElectricBillPerMonth_E, Nothing, Nothing)
					rst = RSWIN_DESC.rst
					array3 = rst.ElectricBillperMonth
					Dim fEFactor22 As Single = 1F
					Dim fMFactor22 As Single = 1F
					Dim fEtoM13 As Single = 1F
					text2 = "$0"
					Me.ShowBE(Me.sMonthlyElectricBill, array3, fEFactor22, fMFactor22, fEtoM13, text2, True, array2, True)
					rst.ElectricBillperMonth = array3
					Me.MakeArray(4, array2, Me.lblDollarsPerBblFluid, Me.lblDollarsPerBblFluid_BE, Me.lblDollarsPerBblFluid_BT, Me.lblDollarsPerBblFluid_E, Nothing, Nothing)
					text2 = Me.sElectrCostPer + str7 + " fluid:"
					rst = RSWIN_DESC.rst
					array3 = rst.DollarsPerBblFluid
					Dim fEFactor23 As Single = 1F
					Dim fMFactor23 As Single = 1F
					Dim fEtoM14 As Single = 1F / RSWIN_DESC.BPD__M3D
					text = "$0.000"
					Me.ShowBE(text2, array3, fEFactor23, fMFactor23, fEtoM14, text, False, array2, True)
					rst.DollarsPerBblFluid = array3
					If RSWIN_DESC.rst.WaterCut < 100F Then
						Me.MakeArray(4, array2, Me.lblDollarsPerBblOil, Me.lblDollarsPerBblOil_BE, Me.lblDollarsPerBblOil_BT, Me.lblDollarsPerBblOil_E, Nothing, Nothing)
						text2 = Me.sElectrCostPer + str7 + " oil:"
						rst = RSWIN_DESC.rst
						array3 = rst.DollarsPerBblOil
						Dim fEFactor24 As Single = 1F
						Dim fMFactor24 As Single = 1F
						Dim fEtoM15 As Single = 1F / RSWIN_DESC.BPD__M3D
						text = "$0.000"
						Me.ShowBE(text2, array3, fEFactor24, fMFactor24, fEtoM15, text, False, array2, True)
						rst.DollarsPerBblOil = array3
					Else
						Me.MakeArray(4, array2, Me.lblDollarsPerBblOil, Me.lblDollarsPerBblOil_BE, Me.lblDollarsPerBblOil_BT, Me.lblDollarsPerBblOil_E, Nothing, Nothing)
						text2 = Nothing
						Dim fEFactor25 As Single = 0F
						Dim fMFactor25 As Single = 0F
						Dim fEtoM16 As Single = 0F
						text = "#"
						Dim array As Single()
						Me.ShowBE(text2, array, fEFactor25, fMFactor25, fEtoM16, text, True, array2, True)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub MakeArray(iNum As Integer, ByRef myArray As DataDynamics.ActiveReports.Label(), lbl1 As DataDynamics.ActiveReports.Label, lbl2 As DataDynamics.ActiveReports.Label, Optional lbl3 As DataDynamics.ActiveReports.Label = Nothing, Optional lbl4 As DataDynamics.ActiveReports.Label = Nothing, Optional lbl5 As DataDynamics.ActiveReports.Label = Nothing, Optional lbl6 As DataDynamics.ActiveReports.Label = Nothing)
			' The following expression was wrapped in a checked-statement
			myArray = New DataDynamics.ActiveReports.Label(iNum - 1 + 1 - 1) {}
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

		Private Sub ShowTrailer(ByRef cyTop As Single, ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label)
			Dim array As String() = New String(6) {}
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
				Try
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
				Catch ex As Exception
				End Try
				Try
					Dim num2 As Integer
					If RSWIN.bHasRelocatedSB(num2) Then
						array(CInt(num)) = RSWIN_DESC.sSBRelocateFootnote
						num += 1L
					End If
				Catch ex2 As Exception
				End Try
				Dim num3 As Long = 1L
				Dim num4 As Long = num
				For num5 As Long = num3 To num4
					Dim num6 As Long = num5
					Dim label As DataDynamics.ActiveReports.Label
					If num6 <= 5L AndAlso num6 >= 1L Then
						' The following expression was wrapped in a unchecked-expression
						Select Case CInt((num6 - 1L))
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
					Dim label2 As DataDynamics.ActiveReports.Label = label
					label2.Text = array(CInt((num5 - 1L)))
					label2.Top = cyTop
					label2.Visible = True

						cyTop += label2.Height

					If Strings.InStr(array(CInt((num5 - 1L))), "Fiberod", CompareMethod.Binary) > 0 Then
						label2.ForeColor = Color.Red
					Else
						label2.ForeColor = Color.Black
					End If
				Next
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub ShowTubingAndPump()
			Try
				Dim label As DataDynamics.ActiveReports.Label = Me.txtDownstrokeFriction
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim downstrokeFriction As Single = rst.DownstrokeFriction
				Dim text As String = "0.0#"
				Dim text2 As String = Util.Format(downstrokeFriction, text)
				rst.DownstrokeFriction = downstrokeFriction
				label.Text = text2
				Dim text3 As String
				Select Case RSWIN_DESC.rst.PumpCondition
					Case 1S
						text3 = Me.sFull
					Case 2S
						text3 = Me.sFlpound
					Case 3S
						text3 = Me.sGasIntf
				End Select
				Dim label2 As DataDynamics.ActiveReports.Label = Me.lblPumpCondition
				Dim w As Object = 23
				Dim value As Single = 0F
				text = "#""" + text3 + """"
				label2.Text = RESULTS1.MkSumm(w, Me.sPumpCondition, value, text, True, False)
				Dim label3 As DataDynamics.ActiveReports.Label = Me.txtPumpCondition
				Dim w2 As Object = text3.Length
				text = ""
				Dim value2 As Single = 0F
				Dim text4 As String = "#""" + text3 + """"
				label3.Text = RESULTS1.MkSumm(w2, text, value2, text4, False, True)
				Dim gbCalcPumpCondition As Boolean = RSWIN_DESC.rst.gbCalcPumpCondition
				Dim label4 As DataDynamics.ActiveReports.Label = Me.lblPlungerSize
				Dim w3 As Object = 23
				Dim plungerSize As Single = RSWIN_DESC.rst.PlungerSize
				Dim in__MM As Single = RSWIN_DESC.IN__MM
				text4 = "#.###"
				text = "#.#"
				label4.Text = RESULTS1.MkSummEM(w3, Me.sPlungerSize, plungerSize, in__MM, RSWIN_DESC.ins, text4, RSWIN_DESC.mm, text, 1, True, False)
				Dim label5 As DataDynamics.ActiveReports.Label = Me.txtPlungerSize
				Dim w4 As Object = 0
				text4 = ""
				Dim plungerSize2 As Single = RSWIN_DESC.rst.PlungerSize
				Dim in__MM2 As Single = RSWIN_DESC.IN__MM
				text = "#.###"
				Dim text5 As String = "#.#"
				label5.Text = RESULTS1.MkSummEM(w4, text4, plungerSize2, in__MM2, RSWIN_DESC.ins, text, RSWIN_DESC.mm, text5, 1, False, True)
				Dim flag As Boolean = RSWIN_DESC.rst.CalcPlungerSize <> 0S
				Dim label6 As DataDynamics.ActiveReports.Label = Me.lblPumpDepth
				Dim w5 As Object = 23
				Dim pumpDepth As Single = RSWIN_DESC.rst.PumpDepth
				Dim ft__M As Single = RSWIN_DESC.FT__M
				text5 = "#.#"
				text4 = "m"
				text = "#.#"
				label6.Text = RESULTS1.MkSummEM(w5, Me.sPumpDepth, pumpDepth, ft__M, RSWIN_DESC.ft, text5, text4, text, 3, True, False)
				Dim label7 As DataDynamics.ActiveReports.Label = Me.txtPumpDepth
				Dim w6 As Object = 0
				text5 = ""
				Dim pumpDepth2 As Single = RSWIN_DESC.rst.PumpDepth
				Dim ft__M2 As Single = RSWIN_DESC.FT__M
				text4 = "#.#"
				text = "m"
				Dim text6 As String = "#.#"
				label7.Text = RESULTS1.MkSummEM(w6, text5, pumpDepth2, ft__M2, RSWIN_DESC.ft, text4, text, text6, 3, False, True)
				If(If((-If((RSWIN_DESC.rst.gbCalcPumpCondition > False), 1S, 0S)), 1S, 0S) Or (RSWIN_DESC.rst.SPMEntered And If((-If((RSWIN_DESC.rst.gbUseIPR > False), 1S, 0S)), 1S, 0S))) <> 0S Then
					text3 = Me.sCalcPumpFillage
				ElseIf RSWIN_DESC.rst.PumpCondition = 2S Or RSWIN_DESC.rst.PumpCondition = 3S Then
					text3 = Me.sPumpEfficiencyFillage
				ElseIf RSWIN_DESC.rst.gbCalcPumpCondition And RSWIN_DESC.rst.PumpCondition = 2S Then
					text3 = Me.sCalcPumpFillage
				Else
					text3 = Me.sPumpVolEff
				End If
				Dim num As Single
				If RSWIN_DESC.rst.PumpCondition = 2S Or RSWIN_DESC.rst.PumpCondition = 3S Then
					Dim label8 As DataDynamics.ActiveReports.Label = Me.lblPumpEfficiency
					Dim w7 As Object = 25
					Dim pfill As Single = RSWIN_DESC.rst.Pfill
					text6 = "0.0#"
					label8.Text = RESULTS1.MkSumm(w7, text3, pfill, text6, True, False)
					num = RSWIN_DESC.rst.PumpEfficiency / 100F
					text5 = "###%"
					Dim str As String = Util.Format(num, text5)
					Dim str2 As String = " / "
					downstrokeFriction = RSWIN_DESC.rst.PumpFillage / 100F
					text6 = "###%"
					Me.fEffFill = str + str2 + Util.Format(downstrokeFriction, text6)
					Me.txtPumpEfficiency.Text = Me.fEffFill.Trim()
				Else
					Dim label9 As DataDynamics.ActiveReports.Label = Me.lblPumpEfficiency
					Dim w8 As Object = 25
					Dim pfill2 As Single = RSWIN_DESC.rst.Pfill
					text6 = "0.0#"
					label9.Text = RESULTS1.MkSumm(w8, text3, pfill2, text6, True, False)
					Dim label10 As DataDynamics.ActiveReports.Label = Me.txtPumpEfficiency
					Dim w9 As Object = 0
					text6 = ""
					Dim pfill3 As Single = RSWIN_DESC.rst.Pfill
					text5 = "###%"
					label10.Text = RESULTS1.MkSumm(w9, text6, pfill3, text5, False, True)
				End If
				Dim label11 As DataDynamics.ActiveReports.Label = Me.lblPumpFriction
				Dim w10 As Object = 25
				Dim pumpFriction As Single = RSWIN_DESC.rst.PumpFriction
				Dim lb__N As Single = RSWIN_DESC.LB__N
				text6 = "0.0#"
				text5 = "0"
				label11.Text = RESULTS1.MkSummEM(w10, Me.sPumpFriction, pumpFriction, lb__N, RSWIN_DESC.lbs, text6, RSWIN_DESC.N, text5, 1, True, False)
				Dim label12 As DataDynamics.ActiveReports.Label = Me.txtPumpFriction
				Dim w11 As Object = 0
				text6 = ""
				Dim pumpFriction2 As Single = RSWIN_DESC.rst.PumpFriction
				Dim lb__N2 As Single = RSWIN_DESC.LB__N
				text5 = "0.0#"
				text4 = "0"
				label12.Text = RESULTS1.MkSummEM(w11, text6, pumpFriction2, lb__N2, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text4, 1, False, True)
				If RSWIN_DESC.bRodStarD Then
					Me.lblPumpLoadAdj.Visible = False
					Me.txtPumpLoadAdj.Visible = False
				Else
					Dim label13 As DataDynamics.ActiveReports.Label = Me.lblPumpLoadAdj
					Dim w12 As Object = 25
					Dim pumpLoadAdj As Single = RSWIN_DESC.rst.PumpLoadAdj
					Dim lb__N3 As Single = RSWIN_DESC.LB__N
					text6 = "0.0#"
					text5 = "0"
					label13.Text = RESULTS1.MkSummEM(w12, Me.sPumpLoadAdj, pumpLoadAdj, lb__N3, RSWIN_DESC.lbs, text6, RSWIN_DESC.N, text5, 1, True, False)
					Dim label14 As DataDynamics.ActiveReports.Label = Me.txtPumpLoadAdj
					Dim w13 As Object = 0
					text6 = ""
					Dim pumpLoadAdj2 As Single = RSWIN_DESC.rst.PumpLoadAdj
					Dim lb__N4 As Single = RSWIN_DESC.LB__N
					text5 = "0.0#"
					text4 = "0"
					label14.Text = RESULTS1.MkSummEM(w13, text6, pumpLoadAdj2, lb__N4, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text4, 1, False, True)
				End If
				Select Case RSWIN_DESC.rst.PumpType
					Case 1S
						text3 = Me.sInsert
					Case 2S
						text3 = Me.sTubing
					Case 3S
						text3 = Me.sLargeBore
				End Select
				Dim label15 As DataDynamics.ActiveReports.Label = Me.lblPumpType
				Dim w14 As Object = 23
				Dim value3 As Single = 0F
				text6 = "#""" + text3 + """"
				label15.Text = RESULTS1.MkSumm(w14, Me.sPumpType, value3, text6, True, False)
				Dim label16 As DataDynamics.ActiveReports.Label = Me.txtPumpType
				Dim w15 As Object = 0
				text6 = ""
				Dim value4 As Single = 0F
				text5 = "#""" + text3 + """"
				label16.Text = RESULTS1.MkSumm(w15, text6, value4, text5, False, True)
				If RSWIN_DESC.rst.TubingAnchored <> 0S Then
					Dim label17 As DataDynamics.ActiveReports.Label = Me.lblTubingAnchorDepth
					Dim w16 As Object = 23
					Dim tubingAnchorDepth As Single = RSWIN_DESC.rst.TubingAnchorDepth
					Dim ft__M3 As Single = RSWIN_DESC.FT__M
					text6 = "#.#"
					text5 = "m"
					text4 = "#.#"
					label17.Text = RESULTS1.MkSummEM(w16, Me.sTubAnchDepth, tubingAnchorDepth, ft__M3, RSWIN_DESC.ft, text6, text5, text4, 3, True, False)
					Dim label18 As DataDynamics.ActiveReports.Label = Me.txtTubingAnchorDepth
					Dim w17 As Object = 0
					text6 = ""
					Dim tubingAnchorDepth2 As Single = RSWIN_DESC.rst.TubingAnchorDepth
					Dim ft__M4 As Single = RSWIN_DESC.FT__M
					text5 = "#.#"
					text4 = "m"
					text = "#.#"
					label18.Text = RESULTS1.MkSummEM(w17, text6, tubingAnchorDepth2, ft__M4, RSWIN_DESC.ft, text5, text4, text, 3, False, True)
				Else
					Me.lblTubingAnchorDepth.Text = Me.sTubingNotAnchored
					Me.txtTubingAnchorDepth.Text = ""
				End If
				Me.lblUpstrokeFriction.Text = Me.sUpstrokeFriction
				Me.lblDownstrokeFriction.Text = Me.sDownstrokeFriction
				Dim label19 As DataDynamics.ActiveReports.Label = Me.lblTubingID
				Dim w18 As Object = 23
				Dim tubingID As Single = RSWIN_DESC.rst.TubingID
				Dim in__MM3 As Single = RSWIN_DESC.IN__MM
				text6 = "0.000"
				text5 = "0.000"
				label19.Text = RESULTS1.MkSummEM(w18, Me.sTubingID, tubingID, in__MM3, RSWIN_DESC.ins, text6, RSWIN_DESC.mm, text5, 3, True, False)
				Dim label20 As DataDynamics.ActiveReports.Label = Me.lblTubingOD
				Dim w19 As Object = 23
				Dim tubingOD As Single = RSWIN_DESC.rst.TubingOD
				Dim in__MM4 As Single = RSWIN_DESC.IN__MM
				text6 = "0.000"
				text5 = "0.000"
				label20.Text = RESULTS1.MkSummEM(w19, Me.sTubingOD, tubingOD, in__MM4, RSWIN_DESC.ins, text6, RSWIN_DESC.mm, text5, 3, True, False)
				Dim label21 As DataDynamics.ActiveReports.Label = Me.txtTubingID
				Dim w20 As Object = 0
				text6 = ""
				Dim tubingID2 As Single = RSWIN_DESC.rst.TubingID
				Dim in__MM5 As Single = RSWIN_DESC.IN__MM
				text5 = "0.000"
				text4 = "0.000"
				label21.Text = RESULTS1.MkSummEM(w20, text6, tubingID2, in__MM5, RSWIN_DESC.ins, text5, RSWIN_DESC.mm, text4, 3, False, True)
				Dim label22 As DataDynamics.ActiveReports.Label = Me.txtTubingOD
				Dim w21 As Object = 0
				text6 = ""
				Dim tubingOD2 As Single = RSWIN_DESC.rst.TubingOD
				Dim in__MM6 As Single = RSWIN_DESC.IN__MM
				text5 = "0.000"
				text4 = "0.000"
				label22.Text = RESULTS1.MkSummEM(w21, text6, tubingOD2, in__MM6, RSWIN_DESC.ins, text5, RSWIN_DESC.mm, text4, 3, False, True)
				Dim label23 As DataDynamics.ActiveReports.Label = Me.txtUpstrokeFriction
				rst = RSWIN_DESC.rst
				num = rst.UpstrokeFriction
				text6 = "0.000#"
				Dim text7 As String = Util.Format(num, text6)
				rst.UpstrokeFriction = num
				label23.Text = text7
				Dim label24 As DataDynamics.ActiveReports.Label = Me.txtDownstrokeFriction
				rst = RSWIN_DESC.rst
				num = rst.DownstrokeFriction
				text6 = "0.000#"
				Dim text8 As String = Util.Format(num, text6)
				rst.DownstrokeFriction = num
				label24.Text = text8
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowTubingCalc()
			If Not RSWIN_DESC.rst.gbOutputLoaded Then
				Me.lblGrossPumpStroke.Visible = False
				Me.lblPlungerLength.Visible = False
				Me.lblProductionLoss.Visible = False
				Me.lblPumpLength.Visible = False
				Me.lblPumpSpacing.Visible = False
				Me.lblTubingStretch.Visible = False
			Else
				Dim label As DataDynamics.ActiveReports.Label = Me.lblGrossPumpStroke
				Dim w As Object = 47
				Dim grossPumpStroke As Single = RSWIN_DESC.rst.GrossPumpStroke
				Dim in__CM As Single = RSWIN_DESC.IN__CM
				Dim text As String = "0"
				Dim text2 As String = "#.0"
				label.Text = RESULTS1.MkSummEM(w, Me.sGrossPumpStroke, grossPumpStroke, in__CM, RSWIN_DESC.ins, text, RSWIN_DESC.cm, text2, 1, True, False)
				Dim label2 As DataDynamics.ActiveReports.Label = Me.lblPlungerLength
				Dim w2 As Object = 47
				Dim plungerLength As Single = RSWIN_DESC.rst.PlungerLength
				Dim ft__M As Single = RSWIN_DESC.FT__M
				text2 = "#.0"
				text = "m"
				Dim text3 As String = "#.0"
				label2.Text = RESULTS1.MkSummEM(w2, Me.sRecommendedPlungerLength, plungerLength, ft__M, RSWIN_DESC.ft, text2, text, text3, 1, True, False)
				Dim label3 As DataDynamics.ActiveReports.Label = Me.lblProductionLoss
				Dim w3 As Object = 47
				Dim productionLoss As Single = RSWIN_DESC.rst.ProductionLoss
				Dim bpd__M3D As Single = RSWIN_DESC.BPD__M3D
				text3 = "0"
				text2 = "#.0"
				label3.Text = RESULTS1.MkSummEM(w3, Me.sProdLossDueToTubingStretch, productionLoss, bpd__M3D, RSWIN_DESC.bfpd, text3, RSWIN_DESC.m3D, text2, 3, True, False)
				Dim label4 As DataDynamics.ActiveReports.Label = Me.lblPumpLength
				Dim w4 As Object = 47
				Dim pumpLength As Single = RSWIN_DESC.rst.PumpLength
				Dim ft__M2 As Single = RSWIN_DESC.FT__M
				text3 = "#.0"
				text2 = "m"
				text = "#.0"
				label4.Text = RESULTS1.MkSummEM(w4, Me.sMinimumPumpLength, pumpLength, ft__M2, RSWIN_DESC.ft, text3, text2, text, 1, True, False)
				Dim label5 As DataDynamics.ActiveReports.Label = Me.lblPumpSpacing
				Dim w5 As Object = 47
				Dim pumpSpacing As Single = RSWIN_DESC.rst.PumpSpacing
				Dim in__CM2 As Single = RSWIN_DESC.IN__CM
				text3 = "in. from bottom"
				text2 = "#.0"
				text = "cm from bottom"
				Dim text4 As String = "0.0"
				label5.Text = RESULTS1.MkSummEM(w5, Me.sPumpSpacing, pumpSpacing, in__CM2, text3, text2, text, text4, 1, True, False)
				Dim label6 As DataDynamics.ActiveReports.Label = Me.lblTubingStretch
				Dim w6 As Object = 47
				Dim tubStretch As Single = RSWIN_DESC.rst.TubStretch
				Dim in__CM3 As Single = RSWIN_DESC.IN__CM
				text4 = "#.0"
				text3 = "#.0"
				label6.Text = RESULTS1.MkSummEM(w6, Me.sTubingStretch, tubStretch, in__CM3, RSWIN_DESC.ins, text4, RSWIN_DESC.cm, text3, 1, True, False)
				Dim label7 As DataDynamics.ActiveReports.Label = Me.txtGrossPumpStroke
				Dim w7 As Object = 0
				text4 = ""
				Dim grossPumpStroke2 As Single = RSWIN_DESC.rst.GrossPumpStroke
				Dim in__CM4 As Single = RSWIN_DESC.IN__CM
				text3 = "0.0"
				text2 = "#.0"
				label7.Text = RESULTS1.MkSummEM(w7, text4, grossPumpStroke2, in__CM4, RSWIN_DESC.ins, text3, RSWIN_DESC.cm, text2, 1, False, True)
				Dim label8 As DataDynamics.ActiveReports.Label = Me.txtPlungerLength
				Dim w8 As Object = 0
				text4 = ""
				Dim plungerLength2 As Single = RSWIN_DESC.rst.PlungerLength
				Dim ft__M3 As Single = RSWIN_DESC.FT__M
				text3 = "#.0"
				text2 = "m"
				text = "#.0"
				label8.Text = RESULTS1.MkSummEM(w8, text4, plungerLength2, ft__M3, RSWIN_DESC.ft, text3, text2, text, 1, False, True)
				Dim label9 As DataDynamics.ActiveReports.Label = Me.txtProductionLoss
				Dim w9 As Object = 0
				text4 = ""
				Dim productionLoss2 As Single = RSWIN_DESC.rst.ProductionLoss
				Dim bpd__M3D2 As Single = RSWIN_DESC.BPD__M3D
				text3 = "0.0"
				text2 = "#.0"
				label9.Text = RESULTS1.MkSummEM(w9, text4, productionLoss2, bpd__M3D2, RSWIN_DESC.bfpd, text3, RSWIN_DESC.m3D, text2, 3, False, True)
				Dim label10 As DataDynamics.ActiveReports.Label = Me.txtPumpLength
				Dim w10 As Object = 0
				text4 = ""
				Dim pumpLength2 As Single = RSWIN_DESC.rst.PumpLength
				Dim ft__M4 As Single = RSWIN_DESC.FT__M
				text3 = "#.0"
				text2 = "m"
				text = "#.0"
				label10.Text = RESULTS1.MkSummEM(w10, text4, pumpLength2, ft__M4, RSWIN_DESC.ft, text3, text2, text, 1, False, True)
				Dim label11 As DataDynamics.ActiveReports.Label = Me.txtPumpSpacing
				Dim w11 As Object = 0
				text4 = ""
				Dim pumpSpacing2 As Single = RSWIN_DESC.rst.PumpSpacing
				Dim in__CM5 As Single = RSWIN_DESC.IN__CM
				text3 = "in. from bottom"
				text2 = "#.0"
				text = "cm from bottom"
				Dim text5 As String = "0.0"
				label11.Text = RESULTS1.MkSummEM(w11, text4, pumpSpacing2, in__CM5, text3, text2, text, text5, 1, False, True)
				Dim label12 As DataDynamics.ActiveReports.Label = Me.txtTubingStretch
				Dim w12 As Object = 0
				text5 = ""
				Dim tubStretch2 As Single = RSWIN_DESC.rst.TubStretch
				Dim in__CM6 As Single = RSWIN_DESC.IN__CM
				text4 = "#.0"
				text3 = "#.0"
				label12.Text = RESULTS1.MkSummEM(w12, text5, tubStretch2, in__CM6, RSWIN_DESC.ins, text4, RSWIN_DESC.cm, text3, 1, False, True)
			End If
		End Sub

		Public Sub ImportDynoChart()
			Try
				Dim sTempDynoPlotFileName As String = RSWIN_DESC.sTempDynoPlotFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sTempDynoPlotFileName)
				RSWIN_DESC.sTempDynoPlotFileName = sTempDynoPlotFileName
				If flag Then
					Try
						Dim bitmap As Bitmap = New Bitmap(RSWIN_DESC.sTempDynoPlotFileName)
						Dim bitmap2 As Bitmap = New Bitmap(bitmap)
						bitmap.Dispose()
						Me.picDyno.Image = CType(bitmap2.Clone(), Image)
						bitmap2.Dispose()
					Catch ex As Exception
					Finally
						Dim bitmap2 As Bitmap
						bitmap2.Dispose()
					End Try
					Try
						sTempDynoPlotFileName = RSWIN_DESC.sTempDynoPlotFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(sTempDynoPlotFileName)
						RSWIN_DESC.sTempDynoPlotFileName = sTempDynoPlotFileName
						If flag2 Then
							FileSystem.Kill(RSWIN_DESC.sTempDynoPlotFileName)
						End If
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub ImportTorquePlotChart()
			Try
				Dim sTempTorquePlotFileName As String = RSWIN_DESC.sTempTorquePlotFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sTempTorquePlotFileName)
				RSWIN_DESC.sTempTorquePlotFileName = sTempTorquePlotFileName
				If flag Then
					Try
						Dim bitmap As Bitmap = New Bitmap(RSWIN_DESC.sTempTorquePlotFileName)
						Dim bitmap2 As Bitmap = New Bitmap(bitmap)
						bitmap.Dispose()
						Me.picTorquePlot.Image = CType(bitmap2.Clone(), Image)
						bitmap2.Dispose()
					Catch ex As Exception
					Finally
						Dim bitmap2 As Bitmap
						bitmap2.Dispose()
					End Try
					Try
						sTempTorquePlotFileName = RSWIN_DESC.sTempTorquePlotFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(sTempTorquePlotFileName)
						RSWIN_DESC.sTempTorquePlotFileName = sTempTorquePlotFileName
						If flag2 Then
							FileSystem.Kill(RSWIN_DESC.sTempTorquePlotFileName)
						End If
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
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
						If Me.PageHeader.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.PageHeader.Controls(i), DataDynamics.ActiveReports.Label)
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

		Public Function SpdVarIncludedNotWritten() As Boolean
			Dim result As Boolean = False
			If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), RSWIN_DESC.rst.CalcMotorSize)) AndAlso RSWIN_DESC.rst.MotorSPV = 0F Then
				result = True
			End If
			Return result
		End Function

		Private Sub ReadReportControlStrings()
			Dim sPrefix As String = "rptCalcResults-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
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
				Dim num6 As Integer = Me.Detail.Controls.Count - 1
				For i As Integer = num5 To num6
					Try
						If Me.Detail.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.Detail.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex3 As Exception
					End Try
				Next
			Catch ex4 As Exception
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

		Public Sub SetLabelColorMinStressBot(Index As Integer)
			Try
				Dim foreColor As Color = Color.Red
				Try
					' The following expression was wrapped in a checked-expression
					If(Index = CInt(RSWIN_DESC.rst.NumRods) And RSWIN_DESC.rst.NumRods > 1S) AndAlso RSWIN_DESC.rst.Sections(Index).Diameter > RSWIN_DESC.rst.Sections(Index - 1).Diameter Then
						foreColor = Color.Black
					End If
				Catch ex As Exception
				End Try
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
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub SetStressLabelColor(fVal As Single, ByRef Label1 As DataDynamics.ActiveReports.Label, Indx As Integer)
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

		Public Function GetMotorName(iMotorType As Integer) As String
			If 9 = iMotorType Then
				Return "Baranchi"
			End If
			If 10 = iMotorType Then
				Return "JSC"
			End If
			If 11 = iMotorType Then
				Return "Vladimir"
			End If
			If 12 = iMotorType Then
				Return "JSC Eldin"
			End If
			If 13 = iMotorType Then
				Return "Bulgaria"
			End If
			Dim result As String
			Return result
		End Function

		<AccessedThroughProperty("PageHeader")>
		Private _PageHeader As PageHeader

		<AccessedThroughProperty("Detail")>
		Private _Detail As Detail

		<AccessedThroughProperty("PageFooter")>
		Private _PageFooter As PageFooter

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

		Private txtMPRLPPRL As DataDynamics.ActiveReports.Label

		Private lblMPRLPPRL As DataDynamics.ActiveReports.Label

		Private lblRSFootnote5 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote4 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote3 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote2 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote1 As DataDynamics.ActiveReports.Label

		Private linRSInputSep4 As Line

		Private lblMotorSPVHdr As DataDynamics.ActiveReports.Label

		Private linRSInputSep1 As Line

		Private linDivider As Line

		Private linRSInputSep3 As Line

		Private lblMotorSPV As DataDynamics.ActiveReports.Label

		Private lblNEMAD As DataDynamics.ActiveReports.Label

		Private Line1 As Line

		Private lblInputData As DataDynamics.ActiveReports.Label

		Private lblCalculatedResults As DataDynamics.ActiveReports.Label

		Private Line3 As Line

		Private lblRuntime As DataDynamics.ActiveReports.Label

		Private lblFLPIP_2 As DataDynamics.ActiveReports.Label

		Private lblFLPIP_1 As DataDynamics.ActiveReports.Label

		Private lblCasingPressure As DataDynamics.ActiveReports.Label

		Private lblStuffingBoxFriction As DataDynamics.ActiveReports.Label

		Private lblFluidPropertiesHeader As DataDynamics.ActiveReports.Label

		Private Line4 As Line

		Private lblMotorHeader As DataDynamics.ActiveReports.Label

		Private Line5 As Line

		Private lblPowerMeter As DataDynamics.ActiveReports.Label

		Private lblWaterCut As DataDynamics.ActiveReports.Label

		Private lblWaterSPGR As DataDynamics.ActiveReports.Label

		Private lblElectricityCost As DataDynamics.ActiveReports.Label

		Private lblMotorType As DataDynamics.ActiveReports.Label

		Private lblMotorSize As DataDynamics.ActiveReports.Label

		Private lblMotorSetting As DataDynamics.ActiveReports.Label

		Private lblOilSPGR As DataDynamics.ActiveReports.Label

		Private lblFluidSPGR As DataDynamics.ActiveReports.Label

		Private lblCompressibilityIndex As DataDynamics.ActiveReports.Label

		Private lblPumpingUnitHeader As DataDynamics.ActiveReports.Label

		Private Line6 As Line

		Private lblAPIDesignation As DataDynamics.ActiveReports.Label

		Private lblCrankHole As DataDynamics.ActiveReports.Label

		Private lblPUDimR As DataDynamics.ActiveReports.Label

		Private lblPUDimA As DataDynamics.ActiveReports.Label

		Private lblPUDimC As DataDynamics.ActiveReports.Label

		Private lblPUDimI As DataDynamics.ActiveReports.Label

		Private lblPUDimK As DataDynamics.ActiveReports.Label

		Private lblPUDimP As DataDynamics.ActiveReports.Label

		Private lblPUDimM As DataDynamics.ActiveReports.Label

		Private lblPUDimV0 As DataDynamics.ActiveReports.Label

		Private lblPUDimS As DataDynamics.ActiveReports.Label

		Private lblStrokeLength As DataDynamics.ActiveReports.Label

		Private lblCrankRotation As DataDynamics.ActiveReports.Label

		Private lblCwtInfo_1 As DataDynamics.ActiveReports.Label

		Private lblCwtInfo_2 As DataDynamics.ActiveReports.Label

		Private lblCwtInfo_3 As DataDynamics.ActiveReports.Label

		Private lblCwtInfo_4 As DataDynamics.ActiveReports.Label

		Private lblCwtInfo_5 As DataDynamics.ActiveReports.Label

		Private lblCBDataFile As DataDynamics.ActiveReports.Label

		Private lblPumpTubingHeader As DataDynamics.ActiveReports.Label

		Private Line7 As Line

		Private lblTubingOD As DataDynamics.ActiveReports.Label

		Private lblTubingID As DataDynamics.ActiveReports.Label

		Private lblPlungerSize As DataDynamics.ActiveReports.Label

		Private lblRodStringDesign As DataDynamics.ActiveReports.Label

		Private lblTqMinEner As DataDynamics.ActiveReports.Label

		Private lblPeakTorque_BE As DataDynamics.ActiveReports.Label

		Private lblGearboxLoading_BE As DataDynamics.ActiveReports.Label

		Private lblCLF_BE As DataDynamics.ActiveReports.Label

		Private lblMCM_BE As DataDynamics.ActiveReports.Label

		Private lblCBE_BE As DataDynamics.ActiveReports.Label

		Private lblMotorKWH_BE As DataDynamics.ActiveReports.Label

		Private lblElectricBillPerMonth_BE As DataDynamics.ActiveReports.Label

		Private lblDollarsPerBblFluid_BE As DataDynamics.ActiveReports.Label

		Private lblDollarsPerBblOil_BE As DataDynamics.ActiveReports.Label

		Private lblTqMinTorq As DataDynamics.ActiveReports.Label

		Private lblPeakTorque_BT As DataDynamics.ActiveReports.Label

		Private lblGearboxLoading_BT As DataDynamics.ActiveReports.Label

		Private lblCLF_BT As DataDynamics.ActiveReports.Label

		Private lblMCM_BT As DataDynamics.ActiveReports.Label

		Private lblCBE_BT As DataDynamics.ActiveReports.Label

		Private lblMotorKWH_BT As DataDynamics.ActiveReports.Label

		Private lblElectricBillPerMonth_BT As DataDynamics.ActiveReports.Label

		Private lblDollarsPerBblFluid_BT As DataDynamics.ActiveReports.Label

		Private lblDollarsPerBblOil_BT As DataDynamics.ActiveReports.Label

		Private lblTqExisting As DataDynamics.ActiveReports.Label

		Private lblPeakTorque_E As DataDynamics.ActiveReports.Label

		Private lblGearboxLoading_E As DataDynamics.ActiveReports.Label

		Private lblCLF_E As DataDynamics.ActiveReports.Label

		Private lblMCM_E As DataDynamics.ActiveReports.Label

		Private lblCBE_E As DataDynamics.ActiveReports.Label

		Private lblMotorKWH_E As DataDynamics.ActiveReports.Label

		Private lblElectricBillPerMonth_E As DataDynamics.ActiveReports.Label

		Private lblDollarsPerBblFluid_E As DataDynamics.ActiveReports.Label

		Private lblDollarsPerBblOil_E As DataDynamics.ActiveReports.Label

		Private Line8 As Line

		Private lblPmMinEner As DataDynamics.ActiveReports.Label

		Private lblNEMAD_BE As DataDynamics.ActiveReports.Label

		Private lblSingleCyl_BE As DataDynamics.ActiveReports.Label

		Private lblMultiCyl_BE As DataDynamics.ActiveReports.Label

		Private lblPmMinTorq As DataDynamics.ActiveReports.Label

		Private lblNEMAD_BT As DataDynamics.ActiveReports.Label

		Private lblSingleCyl_BT As DataDynamics.ActiveReports.Label

		Private lblMultiCyl_BT As DataDynamics.ActiveReports.Label

		Private lblPmExisting As DataDynamics.ActiveReports.Label

		Private lblNEMAD_E As DataDynamics.ActiveReports.Label

		Private lblSingleCyl_E As DataDynamics.ActiveReports.Label

		Private lblMultiCyl_E As DataDynamics.ActiveReports.Label

		Private lblMultiCyl As DataDynamics.ActiveReports.Label

		Private lblElectricityConsumption As DataDynamics.ActiveReports.Label

		Private Line9 As Line

		Private lblTubingCalculations As DataDynamics.ActiveReports.Label

		Private Line10 As Line

		Private Line11 As Line

		Private lblRodDiamHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodDiamHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodDiam1 As DataDynamics.ActiveReports.Label

		Private lblRodGradeHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodLengthHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrengthHdrBot As DataDynamics.ActiveReports.Label

		Private Line12 As Line

		Private lblRodDiam2 As DataDynamics.ActiveReports.Label

		Private lblRodDiam3 As DataDynamics.ActiveReports.Label

		Private lblRodDiam4 As DataDynamics.ActiveReports.Label

		Private lblRodDiam5 As DataDynamics.ActiveReports.Label

		Private lblRodDiam6 As DataDynamics.ActiveReports.Label

		Private lblRodDiam7 As DataDynamics.ActiveReports.Label

		Private lblRodDiam8 As DataDynamics.ActiveReports.Label

		Private lblRodGrade1 As DataDynamics.ActiveReports.Label

		Private lblRodGrade2 As DataDynamics.ActiveReports.Label

		Private lblRodGrade3 As DataDynamics.ActiveReports.Label

		Private lblRodGrade4 As DataDynamics.ActiveReports.Label

		Private lblRodGrade5 As DataDynamics.ActiveReports.Label

		Private lblRodGrade6 As DataDynamics.ActiveReports.Label

		Private lblRodGrade7 As DataDynamics.ActiveReports.Label

		Private lblRodGrade8 As DataDynamics.ActiveReports.Label

		Private lblRodLength1 As DataDynamics.ActiveReports.Label

		Private lblRodLength2 As DataDynamics.ActiveReports.Label

		Private lblRodLength3 As DataDynamics.ActiveReports.Label

		Private lblRodLength4 As DataDynamics.ActiveReports.Label

		Private lblRodLength5 As DataDynamics.ActiveReports.Label

		Private lblRodLength6 As DataDynamics.ActiveReports.Label

		Private lblRodLength7 As DataDynamics.ActiveReports.Label

		Private lblRodLength8 As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrength1 As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrength2 As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrength3 As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrength4 As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrength5 As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrength6 As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrength7 As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrength8 As DataDynamics.ActiveReports.Label

		Private lblRodStringResults As DataDynamics.ActiveReports.Label

		Private Line13 As Line

		Private lblRodStressHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodStress1 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStressHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStressHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStressHdrBot As DataDynamics.ActiveReports.Label

		Private Line14 As Line

		Private lblRodStress2 As DataDynamics.ActiveReports.Label

		Private lblRodStress3 As DataDynamics.ActiveReports.Label

		Private lblRodStress4 As DataDynamics.ActiveReports.Label

		Private lblRodStress5 As DataDynamics.ActiveReports.Label

		Private lblRodStress6 As DataDynamics.ActiveReports.Label

		Private lblRodStress7 As DataDynamics.ActiveReports.Label

		Private lblRodStress8 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStress1 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStress2 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStress3 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStress4 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStress5 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStress6 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStress7 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStress8 As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStress1 As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStress2 As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStress3 As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStress4 As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStress5 As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStress6 As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStress7 As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStress8 As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStress1 As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStress2 As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStress3 As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStress4 As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStress5 As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStress6 As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStress7 As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStress8 As DataDynamics.ActiveReports.Label

		Private lblRodStressMethodHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodStressMethod1 As DataDynamics.ActiveReports.Label

		Private lblRodStressMethod2 As DataDynamics.ActiveReports.Label

		Private lblRodStressMethod3 As DataDynamics.ActiveReports.Label

		Private lblRodStressMethod4 As DataDynamics.ActiveReports.Label

		Private lblRodStressMethod5 As DataDynamics.ActiveReports.Label

		Private lblRodStressMethod6 As DataDynamics.ActiveReports.Label

		Private lblRodStressMethod7 As DataDynamics.ActiveReports.Label

		Private lblRodStressMethod8 As DataDynamics.ActiveReports.Label

		Private lblFLPIP_3 As DataDynamics.ActiveReports.Label

		Private lblSPM As DataDynamics.ActiveReports.Label

		Private lblPlungerLength As DataDynamics.ActiveReports.Label

		Private lblPumpLength As DataDynamics.ActiveReports.Label

		Private lblPumpSpacing As DataDynamics.ActiveReports.Label

		Private lblGrossPumpStroke As DataDynamics.ActiveReports.Label

		Private lblProductionLoss As DataDynamics.ActiveReports.Label

		Private lblTubingStretch As DataDynamics.ActiveReports.Label

		Private lblPumpFriction As DataDynamics.ActiveReports.Label

		Private lblPumpEfficiency As DataDynamics.ActiveReports.Label

		Private lblPumpLoadAdj As DataDynamics.ActiveReports.Label

		Private lblTubingAnchorDepth As DataDynamics.ActiveReports.Label

		Private lblDownstrokeFriction As DataDynamics.ActiveReports.Label

		Private lblPumpType As DataDynamics.ActiveReports.Label

		Private lblPumpCondition As DataDynamics.ActiveReports.Label

		Private lblPumpDepth As DataDynamics.ActiveReports.Label

		Private lblDollarsPerBblOil As DataDynamics.ActiveReports.Label

		Private lblDollarsPerBblFluid As DataDynamics.ActiveReports.Label

		Private lblElectricBillPerMonth As DataDynamics.ActiveReports.Label

		Private lblGearboxLoading As DataDynamics.ActiveReports.Label

		Private lblTorqueAnalysis As DataDynamics.ActiveReports.Label

		Private lblSingleCyl As DataDynamics.ActiveReports.Label

		Private lblPeakTorque As DataDynamics.ActiveReports.Label

		Private lblMotorKWH As DataDynamics.ActiveReports.Label

		Private lblTubingPressure As DataDynamics.ActiveReports.Label

		Private lblReqPrimeMoverSize As DataDynamics.ActiveReports.Label

		Private lblRodGradeHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStressHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStressHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodStressMethodHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStressHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodStressHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrengthHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodLengthHdrTop As DataDynamics.ActiveReports.Label

		Private lblPmBalancedT As DataDynamics.ActiveReports.Label

		Private lblTqBalancedT As DataDynamics.ActiveReports.Label

		Private lblTqBalancedE As DataDynamics.ActiveReports.Label

		Private txtPlungerLength As DataDynamics.ActiveReports.Label

		Private txtPumpLength As DataDynamics.ActiveReports.Label

		Private txtPumpSpacing As DataDynamics.ActiveReports.Label

		Private txtGrossPumpStroke As DataDynamics.ActiveReports.Label

		Private txtProductionLoss As DataDynamics.ActiveReports.Label

		Private txtTubingStretch As DataDynamics.ActiveReports.Label

		Private txtTubingOD As DataDynamics.ActiveReports.Label

		Private txtTubingID As DataDynamics.ActiveReports.Label

		Private txtPlungerSize As DataDynamics.ActiveReports.Label

		Private txtPumpType As DataDynamics.ActiveReports.Label

		Private txtPumpCondition As DataDynamics.ActiveReports.Label

		Private txtPumpDepth As DataDynamics.ActiveReports.Label

		Private txtUpstrokeFriction As DataDynamics.ActiveReports.Label

		Private txtDownstrokeFriction As DataDynamics.ActiveReports.Label

		Private txtPumpFriction As DataDynamics.ActiveReports.Label

		Private txtPumpLoadAdj As DataDynamics.ActiveReports.Label

		Private txtTubingAnchorDepth As DataDynamics.ActiveReports.Label

		Private txtPumpEfficiency As DataDynamics.ActiveReports.Label

		Private txtPowerMeter As DataDynamics.ActiveReports.Label

		Private txtElectricityCost As DataDynamics.ActiveReports.Label

		Private txtMotorType As DataDynamics.ActiveReports.Label

		Private txtMotorSize As DataDynamics.ActiveReports.Label

		Private txtMotorSetting As DataDynamics.ActiveReports.Label

		Private txtWaterCut As DataDynamics.ActiveReports.Label

		Private txtWaterSPGR As DataDynamics.ActiveReports.Label

		Private txtOilSPGR As DataDynamics.ActiveReports.Label

		Private txtFluidSPGR As DataDynamics.ActiveReports.Label

		Private txtCompressibilityIndex As DataDynamics.ActiveReports.Label

		Private txtSPM As DataDynamics.ActiveReports.Label

		Private txtRuntime As DataDynamics.ActiveReports.Label

		Private txtTubingPressure As DataDynamics.ActiveReports.Label

		Private txtCasingPressure As DataDynamics.ActiveReports.Label

		Private txtFLPIP_1 As DataDynamics.ActiveReports.Label

		Private txtFLPIP_2 As DataDynamics.ActiveReports.Label

		Private txtFLPIP_3 As DataDynamics.ActiveReports.Label

		Private txtStuffingBoxFriction As DataDynamics.ActiveReports.Label

		Private lnPMSV As Line

		Private txtCrankHole As DataDynamics.ActiveReports.Label

		Private txtStrokeLength As DataDynamics.ActiveReports.Label

		Private txtCrankRotation As DataDynamics.ActiveReports.Label

		Private txtCwtInfo_1 As DataDynamics.ActiveReports.Label

		Private txtCwtInfo_2 As DataDynamics.ActiveReports.Label

		Private txtCwtInfo_3 As DataDynamics.ActiveReports.Label

		Private txtCwtInfo_4 As DataDynamics.ActiveReports.Label

		Private txtCwtInfo_5 As DataDynamics.ActiveReports.Label

		Private linRSCalcSep3 As Line

		Private linRSCalcSep1 As Line

		Private linRSCalcSep2 As Line

		Private linRSCalcSep4 As Line

		Private lblUpstrokeFriction As DataDynamics.ActiveReports.Label

		Private lblFricCoef1 As DataDynamics.ActiveReports.Label

		Private lblFricCoef2 As DataDynamics.ActiveReports.Label

		Private lblFricCoef3 As DataDynamics.ActiveReports.Label

		Private lblFricCoef4 As DataDynamics.ActiveReports.Label

		Private lblFricCoef5 As DataDynamics.ActiveReports.Label

		Private lblFricCoef6 As DataDynamics.ActiveReports.Label

		Private lblFricCoef7 As DataDynamics.ActiveReports.Label

		Private lblFricCoef8 As DataDynamics.ActiveReports.Label

		Private lblFric As DataDynamics.ActiveReports.Label

		Private lblCoeff As DataDynamics.ActiveReports.Label

		Private lblPmBalancedE As DataDynamics.ActiveReports.Label

		Private lblRodDiam9 As DataDynamics.ActiveReports.Label

		Private lblRodGrade9 As DataDynamics.ActiveReports.Label

		Private lblRodLength9 As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrength9 As DataDynamics.ActiveReports.Label

		Private lblFricCoef9 As DataDynamics.ActiveReports.Label

		Private lblRodStress9 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStress9 As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStress9 As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStress9 As DataDynamics.ActiveReports.Label

		Private lblRodStressMethod9 As DataDynamics.ActiveReports.Label

		Private lblRodDiam10 As DataDynamics.ActiveReports.Label

		Private lblRodGrade10 As DataDynamics.ActiveReports.Label

		Private lblRodLength10 As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrength10 As DataDynamics.ActiveReports.Label

		Private lblFricCoef10 As DataDynamics.ActiveReports.Label

		Private lblRodStress10 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStress10 As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStress10 As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStress10 As DataDynamics.ActiveReports.Label

		Private lblRodStressMethod10 As DataDynamics.ActiveReports.Label

		Private picDyno As Picture

		Private picTorquePlot As Picture

		Private Line15 As Line

		Private Line16 As Line

		Private lblNoResults As DataDynamics.ActiveReports.Label

		Private lblSystemEff As DataDynamics.ActiveReports.Label

		Private txtStructLoading As DataDynamics.ActiveReports.Label

		Private txtBPDSurface As DataDynamics.ActiveReports.Label

		Private txtPermLoadHP As DataDynamics.ActiveReports.Label

		Private txtSystemEff As DataDynamics.ActiveReports.Label

		Private txtFluidLoad As DataDynamics.ActiveReports.Label

		Private txtCalcSPM As DataDynamics.ActiveReports.Label

		Private txtOilProduction As DataDynamics.ActiveReports.Label

		Private lblFluidLoad As DataDynamics.ActiveReports.Label

		Private lblPermLoadHP As DataDynamics.ActiveReports.Label

		Private lblCalcSPM As DataDynamics.ActiveReports.Label

		Private lblOilProduction As DataDynamics.ActiveReports.Label

		Private lblBPDSurface As DataDynamics.ActiveReports.Label

		Private lblPrhpPlhp As DataDynamics.ActiveReports.Label

		Private lblStructLoading As DataDynamics.ActiveReports.Label

		Private lblPRHP As DataDynamics.ActiveReports.Label

		Private lblMPRL As DataDynamics.ActiveReports.Label

		Private lblPPRL As DataDynamics.ActiveReports.Label

		Private lblNoverNo As DataDynamics.ActiveReports.Label

		Private txtRodWeight As DataDynamics.ActiveReports.Label

		Private txtPrhpPlhp As DataDynamics.ActiveReports.Label

		Private txtMPRL As DataDynamics.ActiveReports.Label

		Private txtPPRL As DataDynamics.ActiveReports.Label

		Private linRSInputSep2 As Line

		Private lblRodWeight As DataDynamics.ActiveReports.Label

		Private lblCBE As DataDynamics.ActiveReports.Label

		Private lblMCM As DataDynamics.ActiveReports.Label

		Private lblCLF As DataDynamics.ActiveReports.Label

		Private lblFluidLevelTVD As DataDynamics.ActiveReports.Label

		Private txtPRHP As DataDynamics.ActiveReports.Label

		Private txtFluidLevelTVD As DataDynamics.ActiveReports.Label

		Private lblPolRodDiam As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblParaffinDepth")>
		Private _lblParaffinDepth As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("txtParaffinDepth")>
		Private _txtParaffinDepth As DataDynamics.ActiveReports.Label

		Private txtPolRodDiam As DataDynamics.ActiveReports.Label

		Private Const LD_VBAR As Integer = 1

		Private Const LD_TEEDOWN As Integer = 2

		Private Const LD_HBAR As Integer = 3

		Private Const LD_CROSS As Integer = 4

		Private Const MARGIN As Integer = 700

		Private Const HDRSIZE As Integer = 12

		Private Const TXTSIZE As Integer = 11

		Private printFont As Font

		Private sNull As String

		Private m_LastTop As Single

		Private m_LastHeight As Single

		Private sThetaEnterprises As String

		Private sElevatorNeck As String

		Private sAsterickMsg As String

		Private sPlusMsg As String

		Private sAtSignMsg As String

		Private sAtSignMsg_M As String

		Private sPoundSignMsg As String

		Private sNOTE1 As String

		Private sNOTE2 As String

		Public sNumGuides1 As String

		Public sNumGuides2 As String

		Public sStressCalc As String

		Public sMethod As String

		Private sUNKNOWN As String

		Private c_UNKNOWN As String

		Private sFull As String

		Private sFlpound As String

		Private sGasIntf As String

		Private sPumpCondition As String

		Private sPlungerSize As String

		Private sPumpDepth As String

		Private sParaffinDepth As String

		Private sPumpFriction As String

		Private sPumpLoadAdj As String

		Private sPumpType As String

		Private sTubAnchDepth As String

		Private sTubingNotAnchored As String

		Private sTubingID As String

		Private sTubingOD As String

		Private sCalcPumpFillage As String

		Private sPumpEfficiencyFillage As String

		Private sPumpVolEff As String

		Private fEffFill As String

		Private sInsert As String

		Private sTubing As String

		Private sLargeBore As String

		Private sBottomOfStroke As String

		Private sMaxCBweightl As String

		Private sPeakGboxTorq As String

		Private sPeakGearboxTorque As String

		Private sGearboxLoading As String

		Private sCyclicLoadFactor As String

		Private sMaxAirTankPres As String

		Private sCounterbalanceWeight As String

		Private sMaxCBMoment As String

		Private sReqUnbalance As String

		Private sCounterbalanceEffect As String

		Private sDailyElectrUse As String

		Private sMonthlyElectricBill As String

		Private sElectrCostPer As String

		Private sElectrCostPerFluid As String

		Private sElectrCcostPerOil As String

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

		Private sDownstrokeFriction As String

		Private sUpstrokeFriction As String

		Private sBalanced As String

		Private sExisting As String

		Private sCalculatedResults As String

		Private sProductionRate As String

		Private sStrokesPerMinute As String

		Private sFluidLoadOnPump As String

		Private sFluidLevelTVD As String

		Private sRequiredMotorHP As String

		Private sMinPolRodLoad As String

		Private sOilProduction As String

		Private aPeakPolRodLoad As String

		Private sPolRodPowerKW As String

		Private sPolishedRodHP As String

		Private sPermissibleLoadPowerKW As String

		Private sPermissibleLoadHP As String

		Private sBuoyantRodWeight As String

		Private sUnitStructLoading As String

		Private sSystemEffMotorPump As String

		Private sCompressIndex As String

		Private sFluidSpGravity As String

		Private sUCSIZE As String

		Private sSize As String

		Private sMediumLow As String

		Private sMLow As String

		Private sMode As String

		Private sOilDensityGCM As String

		Private sOilAPIGravity As String

		Private sType As String

		Private sDetent As String

		Private sNonDetent As String

		Private sWaterCut As String

		Private sWaterSpGravity As String

		Private sCasingPres As String

		Private sFluidLevel As String

		Private sPumpIntPr As String

		Private sRunTime As String

		Private sTargetProd As String

		Private sStufBoxFr As String

		Private sTubingPres As String

		Private sPrimeMoverSpeedVariation As String

		Private sCalculatedSpeedVariation As String

		Private sEnteredSpeedVariation As String

		Private sSpeedVariationNotConsidered As String

		Private sPowerMeter As String

		Private sElectricityCost As String

		Private sUnit As String

		Private sAPISize As String

		Private sUnitSize As String

		Private sUnitID As String

		Private sXBALFile As String

		Private sCBALANCEFile As String

		Private sRotation As String

		Private sRotationWithWellToRight As String

		Private sCW As String

		Private sCCW As String

		Private sCalculatedStrokeLength As String

		Private sAdjustedStrokeLength As String

		Private sSprocketRadius As String

		Private sClineSprocketDistance As String

		Private sDrumDiameterRatio As String

		Private sPitmanArmLength As String

		Private sStructuralUnbalance As String

		Private sArtInertia As String

		Private sBalRotInertia As String

		Private sEnteredRotInertia As String

		Private sCrankOffsetAngle As String

		Private sNA As String

		Private sSpeedVarNotIncluded As String

		Private sNEMADMotor As String

		Private sMarathonMotor As String

		Private sTatungMotor As String

		Private sSingleDoubleCylEngine As String

		Private sMulticylinderEngine As String

		Private sGrossPumpStroke As String

		Private sRecommendedPlungerLength As String

		Private sProdLossDueToTubingStretch As String

		Private sMinimumPumpLength As String

		Private sPumpSpacing As String

		Private sTubingStretch As String

		Private slbl As String

		Private sAPIDesignation As String

		Private sUnitDesignation As String

		Private mbCorodSEString As Boolean

		Private mbMsgElevatorNeck1_0Needed As Boolean

		Private mbMsgFullOKNeeded As Boolean

		Private mbMsgNoNeckNeeded As Boolean

		Private mbMsgSlimNeededNeeded As Boolean

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer

		Private m_bPrint As Boolean

		Private Const mc_ANNOTATION As String = "AnnotationX.AnnList"
	End Class
End Namespace
