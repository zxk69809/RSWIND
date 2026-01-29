Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports DataDynamics.ActiveReports
Imports DDCssLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class rptResultsOutputs
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.rptResultsOutputs_ReportStart
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
			Me.lblMotorSPVHdr = Nothing
			Me.lblMotorSPV = Nothing
			Me.lblNEMAD = Nothing
			Me.lblCBE = Nothing
			Me.lblCalculatedResults = Nothing
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
			Me.lblRodStringResults = Nothing
			Me.lblRodStressHdrBot = Nothing
			Me.lblRodStress1 = Nothing
			Me.lblRodTopMaxStressHdrBot = Nothing
			Me.lblRodTopMinStressHdrBot = Nothing
			Me.lblRodBotMinStressHdrBot = Nothing
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
			Me.lblPlungerLength = Nothing
			Me.lblPumpLength = Nothing
			Me.lblPumpSpacing = Nothing
			Me.lblGrossPumpStroke = Nothing
			Me.lblProductionLoss = Nothing
			Me.lblTubingStretch = Nothing
			Me.lblDollarsPerBblOil = Nothing
			Me.lblDollarsPerBblFluid = Nothing
			Me.lblElectricBillPerMonth = Nothing
			Me.lblGearboxLoading = Nothing
			Me.lblTorqueAnalysis = Nothing
			Me.lblSingleCyl = Nothing
			Me.lblPeakTorque = Nothing
			Me.lblMotorKWH = Nothing
			Me.lblReqPrimeMoverSize = Nothing
			Me.lblRodTopMinStressHdrTop = Nothing
			Me.lblRodBotMinStressHdrTop = Nothing
			Me.lblRodStressMethodHdrTop = Nothing
			Me.lblRodTopMaxStressHdrTop = Nothing
			Me.lblRodStressHdrTop = Nothing
			Me.lblPmBalancedT = Nothing
			Me.lblTqBalancedT = Nothing
			Me.lblTqBalancedE = Nothing
			Me.txtPlungerLength = Nothing
			Me.txtPumpLength = Nothing
			Me.txtPumpSpacing = Nothing
			Me.txtGrossPumpStroke = Nothing
			Me.txtProductionLoss = Nothing
			Me.txtTubingStretch = Nothing
			Me.lnPMSV = Nothing
			Me.linRSCalcSep3 = Nothing
			Me.linRSCalcSep1 = Nothing
			Me.linRSCalcSep2 = Nothing
			Me.linRSCalcSep4 = Nothing
			Me.lblPmBalancedE = Nothing
			Me.lblRodStress9 = Nothing
			Me.lblRodTopMaxStress9 = Nothing
			Me.lblRodTopMinStress9 = Nothing
			Me.lblRodBotMinStress9 = Nothing
			Me.lblRodStressMethod9 = Nothing
			Me.lblRodStress10 = Nothing
			Me.lblRodTopMaxStress10 = Nothing
			Me.lblRodTopMinStress10 = Nothing
			Me.lblRodBotMinStress10 = Nothing
			Me.lblRodStressMethod10 = Nothing
			Me.lblRSFootnote2 = Nothing
			Me.lblRSFootnote5 = Nothing
			Me.lblRSFootnote4 = Nothing
			Me.lblRSFootnote3 = Nothing
			Me.lblRSFootnote1 = Nothing
			Me.Line13 = Nothing
			Me.Line14 = Nothing
			Me.Line3 = Nothing
			Me.Line1 = Nothing
			Me.picTorquePlot = Nothing
			Me.picDyno = Nothing
			Me.lblNoResults = Nothing
			Me.lblBPDSurface = Nothing
			Me.lblPRHP = Nothing
			Me.lblNoverNo = Nothing
			Me.txtPRHP = Nothing
			Me.txtStructLoading = Nothing
			Me.txtRodWeight = Nothing
			Me.txtPPRL = Nothing
			Me.txtMPRL = Nothing
			Me.lblFluidLevelTVD = Nothing
			Me.txtPrhpPlhp = Nothing
			Me.lblPrhpPlhp = Nothing
			Me.lblPermLoadHP = Nothing
			Me.txtBPDSurface = Nothing
			Me.txtPermLoadHP = Nothing
			Me.txtFluidLevelTVD = Nothing
			Me.txtSystemEff = Nothing
			Me.txtFluidLoad = Nothing
			Me.txtCalcSPM = Nothing
			Me.txtOilProduction = Nothing
			Me.lblRodWeight = Nothing
			Me.lblStructLoading = Nothing
			Me.lblMPRL = Nothing
			Me.lblPPRL = Nothing
			Me.lblFluidLoad = Nothing
			Me.lblSystemEff = Nothing
			Me.lblCalcSPM = Nothing
			Me.lblOilProduction = Nothing
			Me.lblMCM = Nothing
			Me.lblCLF = Nothing
			Me.lblMPRLPPRL = Nothing
			Me.txtMPRLPPRL = Nothing
			Me.sNull = ""
			Me.sThetaEnterprises = Util.AssignValueToConstant("rptCalcResults", "sThetaEnterprises", "(c) Theta Oilfield Services, Inc.")
			Me.sElevatorNeck = Util.AssignValueToConstant("rptCalcResults", "sElevatorNeck", "elevator neck diameter of ")
			Me.sAsterickMsg = Util.AssignValueToConstant("rptCalcResults", "sAsterickMsg", "* May be too big for tubing.")
			Me.sPlusMsg = Util.AssignValueToConstant("rptCalcResults", "sPlusMsg", "+ Requires slimhole couplings.")
			Me.sAtSignMsg = Util.AssignValueToConstant("rptCalcResults", "sAtSignMsg", "@ Stress calculations based on elevator neck of 7/8"" (for 1.25"" sinker bars) or 1"" (for other sinker bars).")
			Me.sPoundSignMsg = Util.AssignValueToConstant("rptCalcResults", "sPoundSignMsg", "# Sinker bar has no elevator neck.")
			Me.sNOTE1 = Util.AssignValueToConstant("rptCalcResults", "sNOTE1", "NOTE Stress calculations include buoyancy effects.")
			Me.sNOTE2 = Util.AssignValueToConstant("rptCalcResults", "sNOTE2", "NOTE Stress calculations do not include buoyancy effects.")
			Me.sUNKNOWN = Util.AssignValueToConstant("rptCalcResults", "sUNKNOWN", "Unknown")
			Me.c_UNKNOWN = Util.AssignValueToConstant("rptCalcResults", "c_UNKNOWN", "#""Unknown""")
			Me.sFull = Util.AssignValueToConstant("rptCalcResults", "sFull", "Full")
			Me.sFlpound = Util.AssignValueToConstant("rptCalcResults", "sFlpound", "Fl pound")
			Me.sGasIntf = Util.AssignValueToConstant("rptCalcResults", "sGasIntf", "Gas intf")
			Me.sPumpCondition = Util.AssignValueToConstant("rptCalcResults", "sPumpCondition", "Pump condition:")
			Me.sPlungerSize = Util.AssignValueToConstant("rptCalcResults", "sPlungerSize", "Plunger size")
			Me.sPumpDepth = Util.AssignValueToConstant("rptCalcResults", "sPumpDepth", "Pump depth")
			Me.sPumpFriction = Util.AssignValueToConstant("rptCalcResults", "sPumpFriction", "Pump friction")
			Me.sPumpLoadAdj = Util.AssignValueToConstant("rptCalcResults", "sPumpLoadAdj", "Pump load adj.")
			Me.sPumpType = Util.AssignValueToConstant("rptCalcResults", "sPumpType", "Pump type:")
			Me.sTubAnchDepth = Util.AssignValueToConstant("rptCalcResults", "sTubAnchDepth", "Tub.anch.depth")
			Me.sTubingNotAnchored = Util.AssignValueToConstant("rptCalcResults", "sTubingNotAnchored", "Tubing is not anchored")
			Me.sTubingID = Util.AssignValueToConstant("rptCalcResults", "sTubingID", "Tubing I.D.")
			Me.sTubingOD = Util.AssignValueToConstant("rptCalcResults", "sTubingOD", "Tubing O.D.")
			Me.sCalcPumpFillage = Util.AssignValueToConstant("rptCalcResults", "sCalcPumpFillage", "Calc. pump fillage :")
			Me.sPumpVolEff = Util.AssignValueToConstant("rptCalcResults", "sPumpVolEff", "Pump vol. efficiency :")
			Me.sInsert = Util.AssignValueToConstant("rptCalcResults", "sInsert", "Insert")
			Me.sTubing = Util.AssignValueToConstant("rptCalcResults", "sTubing", "Tubing")
			Me.sLargeBore = Util.AssignValueToConstant("rptCalcResults", "sLargeBore", "Large bore")
			Me.sBottomOfStroke = Util.AssignValueToConstant("rptCalcResults", "sBottomOfStroke", "  bottom-of-stroke")
			Me.sMaxCBweightl = Util.AssignValueToConstant("rptCalcResults", "sMaxCBweightl", "Max. CB weight")
			Me.sPeakGboxTorq = Util.AssignValueToConstant("rptCalcResults", "sPeakGboxTorq", "Peak g'box torq.")
			Me.sPeakGearboxTorque = Util.AssignValueToConstant("rptCalcResults", "sPeakGearboxTorque", "Peak Gearbox Torque")
			Me.sGearboxLoading = Util.AssignValueToConstant("rptCalcResults", "sGearboxLoading", "Gearbox loading:")
			Me.sCyclicLoadFactor = Util.AssignValueToConstant("rptCalcResults", "sCyclicLoadFactor", "Cyclic load factor:")
			Me.sMaxAirTankPres = Util.AssignValueToConstant("rptCalcResults", "sMaxAirTankPres", "Max. air tank pres. ")
			Me.sCounterbalanceWeight = Util.AssignValueToConstant("rptCalcResults", "sCounterbalanceWeight", "Counterbalance weight ")
			Me.sMaxCBMoment = Util.AssignValueToConstant("rptCalcResults", "sMaxCBMoment", "Max. CB moment")
			Me.sCrankCBMoment = "Max CB moment"
			Me.sReqUnbalance = "Str. Unbalance"
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
			Me.sDownstrokeFriction = Util.AssignValueToConstant("rptCalcResults", "sDownstrokeFriction", "Downstroke rod-tbg friction: ")
			Me.sUpstrokeFriction = Util.AssignValueToConstant("rptCalcResults", "sUpstrokeFriction", "Upstroke rod-tbg friction: ")
			Me.sBalanced = Util.AssignValueToConstant("rptCalcResults", "sBalanced", "Balanced")
			Me.sExisting = Util.AssignValueToConstant("rptCalcResults", "sExisting", "Existing")
			Me.sProductionRate = Util.AssignValueToConstant("rptCalcResults", "sProductionRate", "Production rate")
			Me.sStrokesPerMinute = Util.AssignValueToConstant("rptCalcResults", "sStrokesPerMinute", "Strokes per minute:")
			Me.sFluidLoadOnPump = Util.AssignValueToConstant("rptCalcResults", "sFluidLoadOnPump", "Fluid load on pump")
			Me.sFluidLevelTVD = Util.AssignValueToConstant("rptCalcResults", "sFluidLevelTVD", "Fluid level TVD ")
			Me.sRequiredMotorHP = Util.AssignValueToConstant("rptCalcResults", "sRequiredMotorHP", " required motor HP:")
			Me.sMinPolRodLoad = Util.AssignValueToConstant("rptCalcResults", "", "Min. pol. rod load")
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
			Me.sElectricityCost = Util.AssignValueToConstant("rptCalcResults", "sElectricityCost", "Electricity cost: ")
			Me.sUnit = Util.AssignValueToConstant("rptCalcResults", "sUnit", "Unit: ")
			Me.sAPISize = Util.AssignValueToConstant("rptCalcResults", "sAPISize", "API size: ")
			Me.sUnitSize = Util.AssignValueToConstant("rptCalcResults", "sUnitSize", "unit size: ")
			Me.sUnitID = Util.AssignValueToConstant("rptCalcResults", "sUnitID", "unit ID: ")
			Me.sXBALFile = Util.AssignValueToConstant("rptCalcResults", "sXBALFile", "XBAL file: ")
			Me.sCBALANCEFile = Util.AssignValueToConstant("rptCalcResults", "sCBALANCEFile", "CBALANCE file: ")
			Me.sRotationWithWellToRight = Util.AssignValueToConstant("rptCalcResults", "sRotationWithWellToRight", "Rotation with well to right:")
			Me.sCW = Util.AssignValueToConstant("rptCalcResults", "sCW", "CW")
			Me.sCCW = Util.AssignValueToConstant("rptCalcResults", "sCCW", "CCW")
			Me.sCalculatedStrokeLength = Util.AssignValueToConstant("rptCalcResults", "sSprocketRadius_StrokeLength", "Calculated stroke length")
			Me.sSprocketRadius = Util.AssignValueToConstant("rptCalcResults", "sSprocketRadius", "Sprocket radius")
			Me.sClineSprocketDistance = Util.AssignValueToConstant("rptCalcResults", "sClineSprocketDistance", "C'line sprocket distance")
			Me.sDrumDiameterRatio = Util.AssignValueToConstant("rptCalcResults", "sDrumDiameterRatio", "Drum diameter ratio:")
			Me.sPitmanArmLength = Util.AssignValueToConstant("rptCalcResults", "sPitmanArmLength", "Pitman arm length")
			Me.sStructuralUnbalance = Util.AssignValueToConstant("rptCalcResults", "sStructuralUnbalance", "Structural unbalance")
			Me.sRotInertia = Util.AssignValueToConstant("rptCalcResults", "sRotInertia", "Rot. inertia")
			Me.sArtInertia = Util.AssignValueToConstant("rptCalcResults", "sArtInertia", "Art. inertia")
			Me.sCrankOffsetAngle = Util.AssignValueToConstant("rptCalcResults", "sCrankOffsetAngle", "Crank offset angle (deg):")
			Me.sNA = Util.AssignValueToConstant("rptCalcResults", "sNA", "N/A")
			Me.sSpeedVarNotIncluded = Util.AssignValueToConstant("rptCalcResults", "sSpeedVarNotIncluded", "(speed var. not included)")
			Me.sNEMADMotor = Util.AssignValueToConstant("rptCalcResults", "sNEMADMotor", "NEMA D motor:")
			Me.sMarathonMotor = "Marathon NEMA B Motor:"
			Me.sTatungMotor = "Tatung NEMA B Motor:"
			Me.sSingleDoubleCylEngine = Util.AssignValueToConstant("rptCalcResults", "sSingleDoubleCylEngine", "Single/double cyl. engine:")
			Me.sMulticylinderEngine = Util.AssignValueToConstant("rptCalcResults", "sMulticylinderEngine", "Multicylinder engine:")
			Me.sGrossPumpStroke = Util.AssignValueToConstant("rptCalcResults", "sGrossPumpStroke", "Gross pump stroke")
			Me.sRecommendedPlungerLength = Util.AssignValueToConstant("rptCalcResults", "sRecommendedPlungerLength", "Recommended plunger length")
			Me.sProdLossDueToTubingStretch = Util.AssignValueToConstant("rptCalcResults", "sProdLossDueToTubingStretch", "Prod. loss due to tubing stretch")
			Me.sMinimumPumpLength = Util.AssignValueToConstant("rptCalcResults", "sMinimumPumpLength", "Minimum pump length")
			Me.sPumpSpacing = Util.AssignValueToConstant("rptCalcResults", "sPumpSpacing", "Pump spacing")
			Me.sTubingStretch = Util.AssignValueToConstant("rptCalcResults", "sTubingStretch", "Tubing stretch")
			Me.slbl = "lbl"
			Me.sAtSignMsg_M = Util.AssignValueToConstant("rptCalcResults", "sAtSignMsg_M", "@ Stress calculations based on elevator neck of 22.2mm (for 31.8mm sinker bars) or 25.4mm (for other sinker bars).")
			Me.sPumpEfficiencyFillage = Util.AssignValueToConstant("rptCalcResults", "sPumpEfficiencyFillage", "Pump efficiency/fillage :")
			Me.sCalculatedResults = Util.AssignValueToConstant("rptCalcResults", "sCalculatedResults", "CALCULATED RESULTS")
			Me.sRotation = Util.AssignValueToConstant("rptCalcResults", "sRotation", "Crank Rotation:")
			Me.sAdjustedStrokeLength = Util.AssignValueToConstant("rptCalcResults", "sAdjustedStrokeLength", "Adjusted stroke length")
			Me.sBalRotInertia = Util.AssignValueToConstant("rptCalcResults", "sBalRotInertia", "Bal. Rot. Moment of Inertia")
			Me.sEnteredRotInertia = Util.AssignValueToConstant("rptCalcResults", "sEnteredRotInertia", "Entered Rot. Moment of Inertia")
			Me.sNumGuides = Util.AssignValueToConstant("RSInput", "sNumGuides", "# Guides/Rod")
			Me.sStressCalc = Util.AssignValueToConstant("RSInput", "sStressCalc", "   Stress Calc.")
			Me.sMethod = Util.AssignValueToConstant("RSInput", "sMethod", "Method")
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
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptResultsOutputs))
			Me.Detail = New Detail()
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
			Me.GroupHeader1 = New GroupHeader()
			Me.lblMotorSPVHdr = New DataDynamics.ActiveReports.Label()
			Me.lblMotorSPV = New DataDynamics.ActiveReports.Label()
			Me.lblNEMAD = New DataDynamics.ActiveReports.Label()
			Me.lblCBE = New DataDynamics.ActiveReports.Label()
			Me.lblCalculatedResults = New DataDynamics.ActiveReports.Label()
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
			Me.lblRodStringResults = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodStress1 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStressHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStressHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStressHdrBot = New DataDynamics.ActiveReports.Label()
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
			Me.lblPlungerLength = New DataDynamics.ActiveReports.Label()
			Me.lblPumpLength = New DataDynamics.ActiveReports.Label()
			Me.lblPumpSpacing = New DataDynamics.ActiveReports.Label()
			Me.lblGrossPumpStroke = New DataDynamics.ActiveReports.Label()
			Me.lblProductionLoss = New DataDynamics.ActiveReports.Label()
			Me.lblTubingStretch = New DataDynamics.ActiveReports.Label()
			Me.lblDollarsPerBblOil = New DataDynamics.ActiveReports.Label()
			Me.lblDollarsPerBblFluid = New DataDynamics.ActiveReports.Label()
			Me.lblElectricBillPerMonth = New DataDynamics.ActiveReports.Label()
			Me.lblGearboxLoading = New DataDynamics.ActiveReports.Label()
			Me.lblTorqueAnalysis = New DataDynamics.ActiveReports.Label()
			Me.lblSingleCyl = New DataDynamics.ActiveReports.Label()
			Me.lblPeakTorque = New DataDynamics.ActiveReports.Label()
			Me.lblMotorKWH = New DataDynamics.ActiveReports.Label()
			Me.lblReqPrimeMoverSize = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStressHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStressHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethodHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStressHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblPmBalancedT = New DataDynamics.ActiveReports.Label()
			Me.lblTqBalancedT = New DataDynamics.ActiveReports.Label()
			Me.lblTqBalancedE = New DataDynamics.ActiveReports.Label()
			Me.txtPlungerLength = New DataDynamics.ActiveReports.Label()
			Me.txtPumpLength = New DataDynamics.ActiveReports.Label()
			Me.txtPumpSpacing = New DataDynamics.ActiveReports.Label()
			Me.txtGrossPumpStroke = New DataDynamics.ActiveReports.Label()
			Me.txtProductionLoss = New DataDynamics.ActiveReports.Label()
			Me.txtTubingStretch = New DataDynamics.ActiveReports.Label()
			Me.lnPMSV = New Line()
			Me.linRSCalcSep3 = New Line()
			Me.linRSCalcSep1 = New Line()
			Me.linRSCalcSep2 = New Line()
			Me.linRSCalcSep4 = New Line()
			Me.lblPmBalancedE = New DataDynamics.ActiveReports.Label()
			Me.lblRodStress9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStress9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStress9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStress9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethod9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStress10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMaxStress10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTopMinStress10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodBotMinStress10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodStressMethod10 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote2 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote5 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote4 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote3 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote1 = New DataDynamics.ActiveReports.Label()
			Me.Line13 = New Line()
			Me.Line14 = New Line()
			Me.Line3 = New Line()
			Me.Line1 = New Line()
			Me.picTorquePlot = New Picture()
			Me.picDyno = New Picture()
			Me.lblNoResults = New DataDynamics.ActiveReports.Label()
			Me.lblBPDSurface = New DataDynamics.ActiveReports.Label()
			Me.lblPRHP = New DataDynamics.ActiveReports.Label()
			Me.lblNoverNo = New DataDynamics.ActiveReports.Label()
			Me.txtPRHP = New DataDynamics.ActiveReports.Label()
			Me.txtStructLoading = New DataDynamics.ActiveReports.Label()
			Me.txtRodWeight = New DataDynamics.ActiveReports.Label()
			Me.txtPPRL = New DataDynamics.ActiveReports.Label()
			Me.txtMPRL = New DataDynamics.ActiveReports.Label()
			Me.lblFluidLevelTVD = New DataDynamics.ActiveReports.Label()
			Me.txtPrhpPlhp = New DataDynamics.ActiveReports.Label()
			Me.lblPrhpPlhp = New DataDynamics.ActiveReports.Label()
			Me.lblPermLoadHP = New DataDynamics.ActiveReports.Label()
			Me.txtBPDSurface = New DataDynamics.ActiveReports.Label()
			Me.txtPermLoadHP = New DataDynamics.ActiveReports.Label()
			Me.txtFluidLevelTVD = New DataDynamics.ActiveReports.Label()
			Me.txtSystemEff = New DataDynamics.ActiveReports.Label()
			Me.txtFluidLoad = New DataDynamics.ActiveReports.Label()
			Me.txtCalcSPM = New DataDynamics.ActiveReports.Label()
			Me.txtOilProduction = New DataDynamics.ActiveReports.Label()
			Me.lblRodWeight = New DataDynamics.ActiveReports.Label()
			Me.lblStructLoading = New DataDynamics.ActiveReports.Label()
			Me.lblMPRL = New DataDynamics.ActiveReports.Label()
			Me.lblPPRL = New DataDynamics.ActiveReports.Label()
			Me.lblFluidLoad = New DataDynamics.ActiveReports.Label()
			Me.lblSystemEff = New DataDynamics.ActiveReports.Label()
			Me.lblCalcSPM = New DataDynamics.ActiveReports.Label()
			Me.lblOilProduction = New DataDynamics.ActiveReports.Label()
			Me.lblMCM = New DataDynamics.ActiveReports.Label()
			Me.lblCLF = New DataDynamics.ActiveReports.Label()
			Me.lblMPRLPPRL = New DataDynamics.ActiveReports.Label()
			Me.txtMPRLPPRL = New DataDynamics.ActiveReports.Label()
			Me.GroupFooter1 = New GroupFooter()
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
			CType(Me.lblMotorSPVHdr, ISupportInitialize).BeginInit()
			CType(Me.lblMotorSPV, ISupportInitialize).BeginInit()
			CType(Me.lblNEMAD, ISupportInitialize).BeginInit()
			CType(Me.lblCBE, ISupportInitialize).BeginInit()
			CType(Me.lblCalculatedResults, ISupportInitialize).BeginInit()
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
			CType(Me.lblPlungerLength, ISupportInitialize).BeginInit()
			CType(Me.lblPumpLength, ISupportInitialize).BeginInit()
			CType(Me.lblPumpSpacing, ISupportInitialize).BeginInit()
			CType(Me.lblGrossPumpStroke, ISupportInitialize).BeginInit()
			CType(Me.lblProductionLoss, ISupportInitialize).BeginInit()
			CType(Me.lblTubingStretch, ISupportInitialize).BeginInit()
			CType(Me.lblDollarsPerBblOil, ISupportInitialize).BeginInit()
			CType(Me.lblDollarsPerBblFluid, ISupportInitialize).BeginInit()
			CType(Me.lblElectricBillPerMonth, ISupportInitialize).BeginInit()
			CType(Me.lblGearboxLoading, ISupportInitialize).BeginInit()
			CType(Me.lblTorqueAnalysis, ISupportInitialize).BeginInit()
			CType(Me.lblSingleCyl, ISupportInitialize).BeginInit()
			CType(Me.lblPeakTorque, ISupportInitialize).BeginInit()
			CType(Me.lblMotorKWH, ISupportInitialize).BeginInit()
			CType(Me.lblReqPrimeMoverSize, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStressHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStressHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethodHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStressHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblPmBalancedT, ISupportInitialize).BeginInit()
			CType(Me.lblTqBalancedT, ISupportInitialize).BeginInit()
			CType(Me.lblTqBalancedE, ISupportInitialize).BeginInit()
			CType(Me.txtPlungerLength, ISupportInitialize).BeginInit()
			CType(Me.txtPumpLength, ISupportInitialize).BeginInit()
			CType(Me.txtPumpSpacing, ISupportInitialize).BeginInit()
			CType(Me.txtGrossPumpStroke, ISupportInitialize).BeginInit()
			CType(Me.txtProductionLoss, ISupportInitialize).BeginInit()
			CType(Me.txtTubingStretch, ISupportInitialize).BeginInit()
			CType(Me.lblPmBalancedE, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress9, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress9, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress9, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress9, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod9, ISupportInitialize).BeginInit()
			CType(Me.lblRodStress10, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMaxStress10, ISupportInitialize).BeginInit()
			CType(Me.lblRodTopMinStress10, ISupportInitialize).BeginInit()
			CType(Me.lblRodBotMinStress10, ISupportInitialize).BeginInit()
			CType(Me.lblRodStressMethod10, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote2, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote5, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote4, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote3, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote1, ISupportInitialize).BeginInit()
			CType(Me.picTorquePlot, ISupportInitialize).BeginInit()
			CType(Me.picDyno, ISupportInitialize).BeginInit()
			CType(Me.lblNoResults, ISupportInitialize).BeginInit()
			CType(Me.lblBPDSurface, ISupportInitialize).BeginInit()
			CType(Me.lblPRHP, ISupportInitialize).BeginInit()
			CType(Me.lblNoverNo, ISupportInitialize).BeginInit()
			CType(Me.txtPRHP, ISupportInitialize).BeginInit()
			CType(Me.txtStructLoading, ISupportInitialize).BeginInit()
			CType(Me.txtRodWeight, ISupportInitialize).BeginInit()
			CType(Me.txtPPRL, ISupportInitialize).BeginInit()
			CType(Me.txtMPRL, ISupportInitialize).BeginInit()
			CType(Me.lblFluidLevelTVD, ISupportInitialize).BeginInit()
			CType(Me.txtPrhpPlhp, ISupportInitialize).BeginInit()
			CType(Me.lblPrhpPlhp, ISupportInitialize).BeginInit()
			CType(Me.lblPermLoadHP, ISupportInitialize).BeginInit()
			CType(Me.txtBPDSurface, ISupportInitialize).BeginInit()
			CType(Me.txtPermLoadHP, ISupportInitialize).BeginInit()
			CType(Me.txtFluidLevelTVD, ISupportInitialize).BeginInit()
			CType(Me.txtSystemEff, ISupportInitialize).BeginInit()
			CType(Me.txtFluidLoad, ISupportInitialize).BeginInit()
			CType(Me.txtCalcSPM, ISupportInitialize).BeginInit()
			CType(Me.txtOilProduction, ISupportInitialize).BeginInit()
			CType(Me.lblRodWeight, ISupportInitialize).BeginInit()
			CType(Me.lblStructLoading, ISupportInitialize).BeginInit()
			CType(Me.lblMPRL, ISupportInitialize).BeginInit()
			CType(Me.lblPPRL, ISupportInitialize).BeginInit()
			CType(Me.lblFluidLoad, ISupportInitialize).BeginInit()
			CType(Me.lblSystemEff, ISupportInitialize).BeginInit()
			CType(Me.lblCalcSPM, ISupportInitialize).BeginInit()
			CType(Me.lblOilProduction, ISupportInitialize).BeginInit()
			CType(Me.lblMCM, ISupportInitialize).BeginInit()
			CType(Me.lblCLF, ISupportInitialize).BeginInit()
			CType(Me.lblMPRLPPRL, ISupportInitialize).BeginInit()
			CType(Me.txtMPRLPPRL, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Height = 0F
			Me.Detail.Name = "Detail"
			Me.PageHeader.Controls.AddRange(New ARControl() { Me.lblComment, Me.lblTitle1, Me.lblPage, Me.txtPage1, Me.lblOf, Me.txtPage2, Me.lblUserName, Me.lblUserDate, Me.lblLabel2, Me.lblCompany, Me.lblWellName, Me.lblDiskFile, Me.lblSecondCompanyName, Me.lblSecondCompanyPhonenumber, Me.lblGoTheta })
			Me.PageHeader.Height = 0.9395834F
			Me.PageHeader.Name = "PageHeader"
			Me.lblComment.Height = 0.25F
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
			Me.GroupHeader1.Controls.AddRange(New ARControl() { Me.lblMotorSPVHdr, Me.lblMotorSPV, Me.lblNEMAD, Me.lblCBE, Me.lblCalculatedResults, Me.lblTqMinEner, Me.lblPeakTorque_BE, Me.lblGearboxLoading_BE, Me.lblCLF_BE, Me.lblMCM_BE, Me.lblCBE_BE, Me.lblMotorKWH_BE, Me.lblElectricBillPerMonth_BE, Me.lblDollarsPerBblFluid_BE, Me.lblDollarsPerBblOil_BE, Me.lblTqMinTorq, Me.lblPeakTorque_BT, Me.lblGearboxLoading_BT, Me.lblCLF_BT, Me.lblMCM_BT, Me.lblCBE_BT, Me.lblMotorKWH_BT, Me.lblElectricBillPerMonth_BT, Me.lblDollarsPerBblFluid_BT, Me.lblDollarsPerBblOil_BT, Me.lblTqExisting, Me.lblPeakTorque_E, Me.lblGearboxLoading_E, Me.lblCLF_E, Me.lblMCM_E, Me.lblCBE_E, Me.lblMotorKWH_E, Me.lblElectricBillPerMonth_E, Me.lblDollarsPerBblFluid_E, Me.lblDollarsPerBblOil_E, Me.Line8, Me.lblPmMinEner, Me.lblNEMAD_BE, Me.lblSingleCyl_BE, Me.lblMultiCyl_BE, Me.lblPmMinTorq, Me.lblNEMAD_BT, Me.lblSingleCyl_BT, Me.lblMultiCyl_BT, Me.lblPmExisting, Me.lblNEMAD_E, Me.lblSingleCyl_E, Me.lblMultiCyl_E, Me.lblMultiCyl, Me.lblElectricityConsumption, Me.Line9, Me.lblTubingCalculations, Me.Line10, Me.lblRodStringResults, Me.lblRodStressHdrBot, Me.lblRodStress1, Me.lblRodTopMaxStressHdrBot, Me.lblRodTopMinStressHdrBot, Me.lblRodBotMinStressHdrBot, Me.lblRodStress2, Me.lblRodStress3, Me.lblRodStress4, Me.lblRodStress5, Me.lblRodStress6, Me.lblRodStress7, Me.lblRodStress8, Me.lblRodTopMaxStress1, Me.lblRodTopMaxStress2, Me.lblRodTopMaxStress3, Me.lblRodTopMaxStress4, Me.lblRodTopMaxStress5, Me.lblRodTopMaxStress6, Me.lblRodTopMaxStress7, Me.lblRodTopMaxStress8, Me.lblRodTopMinStress1, Me.lblRodTopMinStress2, Me.lblRodTopMinStress3, Me.lblRodTopMinStress4, Me.lblRodTopMinStress5, Me.lblRodTopMinStress6, Me.lblRodTopMinStress7, Me.lblRodTopMinStress8, Me.lblRodBotMinStress1, Me.lblRodBotMinStress2, Me.lblRodBotMinStress3, Me.lblRodBotMinStress4, Me.lblRodBotMinStress5, Me.lblRodBotMinStress6, Me.lblRodBotMinStress7, Me.lblRodBotMinStress8, Me.lblRodStressMethodHdrBot, Me.lblRodStressMethod1, Me.lblRodStressMethod2, Me.lblRodStressMethod3, Me.lblRodStressMethod4, Me.lblRodStressMethod5, Me.lblRodStressMethod6, Me.lblRodStressMethod7, Me.lblRodStressMethod8, Me.lblPlungerLength, Me.lblPumpLength, Me.lblPumpSpacing, Me.lblGrossPumpStroke, Me.lblProductionLoss, Me.lblTubingStretch, Me.lblDollarsPerBblOil, Me.lblDollarsPerBblFluid, Me.lblElectricBillPerMonth, Me.lblGearboxLoading, Me.lblTorqueAnalysis, Me.lblSingleCyl, Me.lblPeakTorque, Me.lblMotorKWH, Me.lblReqPrimeMoverSize, Me.lblRodTopMinStressHdrTop, Me.lblRodBotMinStressHdrTop, Me.lblRodStressMethodHdrTop, Me.lblRodTopMaxStressHdrTop, Me.lblRodStressHdrTop, Me.lblPmBalancedT, Me.lblTqBalancedT, Me.lblTqBalancedE, Me.txtPlungerLength, Me.txtPumpLength, Me.txtPumpSpacing, Me.txtGrossPumpStroke, Me.txtProductionLoss, Me.txtTubingStretch, Me.lnPMSV, Me.linRSCalcSep3, Me.linRSCalcSep1, Me.linRSCalcSep2, Me.linRSCalcSep4, Me.lblPmBalancedE, Me.lblRodStress9, Me.lblRodTopMaxStress9, Me.lblRodTopMinStress9, Me.lblRodBotMinStress9, Me.lblRodStressMethod9, Me.lblRodStress10, Me.lblRodTopMaxStress10, Me.lblRodTopMinStress10, Me.lblRodBotMinStress10, Me.lblRodStressMethod10, Me.lblRSFootnote2, Me.lblRSFootnote5, Me.lblRSFootnote4, Me.lblRSFootnote3, Me.lblRSFootnote1, Me.Line13, Me.Line14, Me.Line3, Me.Line1, Me.picTorquePlot, Me.picDyno, Me.lblNoResults, Me.lblBPDSurface, Me.lblPRHP, Me.lblNoverNo, Me.txtPRHP, Me.txtStructLoading, Me.txtRodWeight, Me.txtPPRL, Me.txtMPRL, Me.lblFluidLevelTVD, Me.txtPrhpPlhp, Me.lblPrhpPlhp, Me.lblPermLoadHP, Me.txtBPDSurface, Me.txtPermLoadHP, Me.txtFluidLevelTVD, Me.txtSystemEff, Me.txtFluidLoad, Me.txtCalcSPM, Me.txtOilProduction, Me.lblRodWeight, Me.lblStructLoading, Me.lblMPRL, Me.lblPPRL, Me.lblFluidLoad, Me.lblSystemEff, Me.lblCalcSPM, Me.lblOilProduction, Me.lblMCM, Me.lblCLF, Me.lblMPRLPPRL, Me.txtMPRLPPRL })
			Me.GroupHeader1.Height = 9.800694F
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.lblMotorSPVHdr.Height = 0.145F
			Me.lblMotorSPVHdr.HyperLink = Nothing
			Me.lblMotorSPVHdr.Left = 0.25F
			Me.lblMotorSPVHdr.Name = "lblMotorSPVHdr"
			Me.lblMotorSPVHdr.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblMotorSPVHdr.Text = "(speed var. not included)"
			Me.lblMotorSPVHdr.Top = 1.475F
			Me.lblMotorSPVHdr.Width = 4.9375F
			Me.lblMotorSPV.Height = 0.145F
			Me.lblMotorSPV.HyperLink = Nothing
			Me.lblMotorSPV.Left = 0.125F
			Me.lblMotorSPV.Name = "lblMotorSPV"
			Me.lblMotorSPV.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMotorSPV.Text = "(speed var. not included)"
			Me.lblMotorSPV.Top = 1.625F
			Me.lblMotorSPV.Width = 2.625F
			Me.lblNEMAD.Height = 0.145F
			Me.lblNEMAD.HyperLink = Nothing
			Me.lblNEMAD.Left = 0.125F
			Me.lblNEMAD.Name = "lblNEMAD"
			Me.lblNEMAD.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblNEMAD.Text = "NEMA D motor:"
			Me.lblNEMAD.Top = 1.675F
			Me.lblNEMAD.Width = 2.625F
			Me.lblCBE.Height = 0.145F
			Me.lblCBE.HyperLink = Nothing
			Me.lblCBE.Left = 0.125F
			Me.lblCBE.Name = "lblCBE"
			Me.lblCBE.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCBE.Text = "Counterbalance effect"
			Me.lblCBE.Top = 3F
			Me.lblCBE.Width = 2.625F
			Me.lblCalculatedResults.Height = 0.125F
			Me.lblCalculatedResults.HyperLink = Nothing
			Me.lblCalculatedResults.Left = 0.0625F
			Me.lblCalculatedResults.Name = "lblCalculatedResults"
			Me.lblCalculatedResults.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center"
			Me.lblCalculatedResults.Text = "CALCULATED RESULTS"
			Me.lblCalculatedResults.Top = 0.0625F
			Me.lblCalculatedResults.Width = 7.938F
			Me.lblTqMinEner.Height = 0.15F
			Me.lblTqMinEner.HyperLink = Nothing
			Me.lblTqMinEner.Left = 2.8125F
			Me.lblTqMinEner.Name = "lblTqMinEner"
			Me.lblTqMinEner.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblTqMinEner.Text = "(Min Ener)"
			Me.lblTqMinEner.Top = 2.25F
			Me.lblTqMinEner.Width = 1.25F
			Me.lblPeakTorque_BE.Height = 0.145F
			Me.lblPeakTorque_BE.HyperLink = Nothing
			Me.lblPeakTorque_BE.Left = 3.125F
			Me.lblPeakTorque_BE.Name = "lblPeakTorque_BE"
			Me.lblPeakTorque_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPeakTorque_BE.Text = "Pk torque"
			Me.lblPeakTorque_BE.Top = 2.5F
			Me.lblPeakTorque_BE.Width = 0.625F
			Me.lblGearboxLoading_BE.Height = 0.145F
			Me.lblGearboxLoading_BE.HyperLink = Nothing
			Me.lblGearboxLoading_BE.Left = 3.125F
			Me.lblGearboxLoading_BE.Name = "lblGearboxLoading_BE"
			Me.lblGearboxLoading_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblGearboxLoading_BE.Text = "Gbx load"
			Me.lblGearboxLoading_BE.Top = 2.625F
			Me.lblGearboxLoading_BE.Width = 0.625F
			Me.lblCLF_BE.Height = 0.145F
			Me.lblCLF_BE.HyperLink = Nothing
			Me.lblCLF_BE.Left = 3.125F
			Me.lblCLF_BE.Name = "lblCLF_BE"
			Me.lblCLF_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCLF_BE.Text = "CLF"
			Me.lblCLF_BE.Top = 2.75F
			Me.lblCLF_BE.Width = 0.625F
			Me.lblMCM_BE.Height = 0.145F
			Me.lblMCM_BE.HyperLink = Nothing
			Me.lblMCM_BE.Left = 3.125F
			Me.lblMCM_BE.Name = "lblMCM_BE"
			Me.lblMCM_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblMCM_BE.Text = "MCM"
			Me.lblMCM_BE.Top = 2.875F
			Me.lblMCM_BE.Width = 0.625F
			Me.lblCBE_BE.Height = 0.145F
			Me.lblCBE_BE.HyperLink = Nothing
			Me.lblCBE_BE.Left = 3.125F
			Me.lblCBE_BE.Name = "lblCBE_BE"
			Me.lblCBE_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCBE_BE.Text = "CBE"
			Me.lblCBE_BE.Top = 3F
			Me.lblCBE_BE.Width = 0.625F
			Me.lblMotorKWH_BE.Height = 0.145F
			Me.lblMotorKWH_BE.HyperLink = Nothing
			Me.lblMotorKWH_BE.Left = 3.125F
			Me.lblMotorKWH_BE.Name = "lblMotorKWH_BE"
			Me.lblMotorKWH_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblMotorKWH_BE.Text = "Daily elec."
			Me.lblMotorKWH_BE.Top = 3.125F
			Me.lblMotorKWH_BE.Width = 0.625F
			Me.lblElectricBillPerMonth_BE.Height = 0.145F
			Me.lblElectricBillPerMonth_BE.HyperLink = Nothing
			Me.lblElectricBillPerMonth_BE.Left = 3.125F
			Me.lblElectricBillPerMonth_BE.Name = "lblElectricBillPerMonth_BE"
			Me.lblElectricBillPerMonth_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblElectricBillPerMonth_BE.Text = "Month elec."
			Me.lblElectricBillPerMonth_BE.Top = 3.25F
			Me.lblElectricBillPerMonth_BE.Width = 0.625F
			Me.lblDollarsPerBblFluid_BE.Height = 0.145F
			Me.lblDollarsPerBblFluid_BE.HyperLink = Nothing
			Me.lblDollarsPerBblFluid_BE.Left = 3.125F
			Me.lblDollarsPerBblFluid_BE.Name = "lblDollarsPerBblFluid_BE"
			Me.lblDollarsPerBblFluid_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblFluid_BE.Text = "$/bbl fluid"
			Me.lblDollarsPerBblFluid_BE.Top = 3.375F
			Me.lblDollarsPerBblFluid_BE.Width = 0.625F
			Me.lblDollarsPerBblOil_BE.Height = 0.145F
			Me.lblDollarsPerBblOil_BE.HyperLink = Nothing
			Me.lblDollarsPerBblOil_BE.Left = 3.125F
			Me.lblDollarsPerBblOil_BE.Name = "lblDollarsPerBblOil_BE"
			Me.lblDollarsPerBblOil_BE.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblOil_BE.Text = "$/bbl oil"
			Me.lblDollarsPerBblOil_BE.Top = 3.5F
			Me.lblDollarsPerBblOil_BE.Width = 0.625F
			Me.lblTqMinTorq.Height = 0.15F
			Me.lblTqMinTorq.HyperLink = Nothing
			Me.lblTqMinTorq.Left = 4.125F
			Me.lblTqMinTorq.Name = "lblTqMinTorq"
			Me.lblTqMinTorq.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblTqMinTorq.Text = "(Min Torq)"
			Me.lblTqMinTorq.Top = 2.25F
			Me.lblTqMinTorq.Width = 1.25F
			Me.lblPeakTorque_BT.Height = 0.145F
			Me.lblPeakTorque_BT.HyperLink = Nothing
			Me.lblPeakTorque_BT.Left = 4.4375F
			Me.lblPeakTorque_BT.Name = "lblPeakTorque_BT"
			Me.lblPeakTorque_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPeakTorque_BT.Text = "Pk torque"
			Me.lblPeakTorque_BT.Top = 2.5F
			Me.lblPeakTorque_BT.Width = 0.625F
			Me.lblGearboxLoading_BT.Height = 0.145F
			Me.lblGearboxLoading_BT.HyperLink = Nothing
			Me.lblGearboxLoading_BT.Left = 4.4375F
			Me.lblGearboxLoading_BT.Name = "lblGearboxLoading_BT"
			Me.lblGearboxLoading_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblGearboxLoading_BT.Text = "Gbx load"
			Me.lblGearboxLoading_BT.Top = 2.625F
			Me.lblGearboxLoading_BT.Width = 0.625F
			Me.lblCLF_BT.Height = 0.145F
			Me.lblCLF_BT.HyperLink = Nothing
			Me.lblCLF_BT.Left = 4.4375F
			Me.lblCLF_BT.Name = "lblCLF_BT"
			Me.lblCLF_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCLF_BT.Text = "CLF"
			Me.lblCLF_BT.Top = 2.75F
			Me.lblCLF_BT.Width = 0.625F
			Me.lblMCM_BT.Height = 0.145F
			Me.lblMCM_BT.HyperLink = Nothing
			Me.lblMCM_BT.Left = 4.4375F
			Me.lblMCM_BT.Name = "lblMCM_BT"
			Me.lblMCM_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblMCM_BT.Text = "MCM"
			Me.lblMCM_BT.Top = 2.875F
			Me.lblMCM_BT.Width = 0.625F
			Me.lblCBE_BT.Height = 0.145F
			Me.lblCBE_BT.HyperLink = Nothing
			Me.lblCBE_BT.Left = 4.4375F
			Me.lblCBE_BT.Name = "lblCBE_BT"
			Me.lblCBE_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCBE_BT.Text = "CBE"
			Me.lblCBE_BT.Top = 3F
			Me.lblCBE_BT.Width = 0.625F
			Me.lblMotorKWH_BT.Height = 0.145F
			Me.lblMotorKWH_BT.HyperLink = Nothing
			Me.lblMotorKWH_BT.Left = 4.4375F
			Me.lblMotorKWH_BT.Name = "lblMotorKWH_BT"
			Me.lblMotorKWH_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblMotorKWH_BT.Text = "Daily elec."
			Me.lblMotorKWH_BT.Top = 3.125F
			Me.lblMotorKWH_BT.Width = 0.625F
			Me.lblElectricBillPerMonth_BT.Height = 0.145F
			Me.lblElectricBillPerMonth_BT.HyperLink = Nothing
			Me.lblElectricBillPerMonth_BT.Left = 4.4375F
			Me.lblElectricBillPerMonth_BT.Name = "lblElectricBillPerMonth_BT"
			Me.lblElectricBillPerMonth_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblElectricBillPerMonth_BT.Text = "Month elec."
			Me.lblElectricBillPerMonth_BT.Top = 3.25F
			Me.lblElectricBillPerMonth_BT.Width = 0.625F
			Me.lblDollarsPerBblFluid_BT.Height = 0.145F
			Me.lblDollarsPerBblFluid_BT.HyperLink = Nothing
			Me.lblDollarsPerBblFluid_BT.Left = 4.4375F
			Me.lblDollarsPerBblFluid_BT.Name = "lblDollarsPerBblFluid_BT"
			Me.lblDollarsPerBblFluid_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblFluid_BT.Text = "$/bbl fluid"
			Me.lblDollarsPerBblFluid_BT.Top = 3.375F
			Me.lblDollarsPerBblFluid_BT.Width = 0.625F
			Me.lblDollarsPerBblOil_BT.Height = 0.145F
			Me.lblDollarsPerBblOil_BT.HyperLink = Nothing
			Me.lblDollarsPerBblOil_BT.Left = 4.4375F
			Me.lblDollarsPerBblOil_BT.Name = "lblDollarsPerBblOil_BT"
			Me.lblDollarsPerBblOil_BT.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblOil_BT.Text = "$/bbl oil"
			Me.lblDollarsPerBblOil_BT.Top = 3.5F
			Me.lblDollarsPerBblOil_BT.Width = 0.625F
			Me.lblTqExisting.Height = 0.125F
			Me.lblTqExisting.HyperLink = Nothing
			Me.lblTqExisting.Left = 5.4375F
			Me.lblTqExisting.Name = "lblTqExisting"
			Me.lblTqExisting.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblTqExisting.Text = "EXISTING"
			Me.lblTqExisting.Top = 2.125F
			Me.lblTqExisting.Width = 1.25F
			Me.lblPeakTorque_E.Height = 0.145F
			Me.lblPeakTorque_E.HyperLink = Nothing
			Me.lblPeakTorque_E.Left = 5.6875F
			Me.lblPeakTorque_E.Name = "lblPeakTorque_E"
			Me.lblPeakTorque_E.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPeakTorque_E.Text = "Pk torque"
			Me.lblPeakTorque_E.Top = 2.5F
			Me.lblPeakTorque_E.Width = 0.625F
			Me.lblGearboxLoading_E.Height = 0.145F
			Me.lblGearboxLoading_E.HyperLink = Nothing
			Me.lblGearboxLoading_E.Left = 5.6875F
			Me.lblGearboxLoading_E.Name = "lblGearboxLoading_E"
			Me.lblGearboxLoading_E.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblGearboxLoading_E.Text = "Gbx load"
			Me.lblGearboxLoading_E.Top = 2.625F
			Me.lblGearboxLoading_E.Width = 0.625F
			Me.lblCLF_E.Height = 0.145F
			Me.lblCLF_E.HyperLink = Nothing
			Me.lblCLF_E.Left = 5.6875F
			Me.lblCLF_E.Name = "lblCLF_E"
			Me.lblCLF_E.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCLF_E.Text = "CLF"
			Me.lblCLF_E.Top = 2.75F
			Me.lblCLF_E.Width = 0.625F
			Me.lblMCM_E.Height = 0.145F
			Me.lblMCM_E.HyperLink = Nothing
			Me.lblMCM_E.Left = 5.6875F
			Me.lblMCM_E.Name = "lblMCM_E"
			Me.lblMCM_E.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblMCM_E.Text = "MCM"
			Me.lblMCM_E.Top = 2.875F
			Me.lblMCM_E.Width = 0.625F
			Me.lblCBE_E.Height = 0.145F
			Me.lblCBE_E.HyperLink = Nothing
			Me.lblCBE_E.Left = 5.6875F
			Me.lblCBE_E.Name = "lblCBE_E"
			Me.lblCBE_E.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCBE_E.Text = "CBE"
			Me.lblCBE_E.Top = 3F
			Me.lblCBE_E.Width = 0.625F
			Me.lblMotorKWH_E.Height = 0.145F
			Me.lblMotorKWH_E.HyperLink = Nothing
			Me.lblMotorKWH_E.Left = 5.6875F
			Me.lblMotorKWH_E.Name = "lblMotorKWH_E"
			Me.lblMotorKWH_E.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblMotorKWH_E.Text = "Daily elec."
			Me.lblMotorKWH_E.Top = 3.125F
			Me.lblMotorKWH_E.Width = 0.625F
			Me.lblElectricBillPerMonth_E.Height = 0.145F
			Me.lblElectricBillPerMonth_E.HyperLink = Nothing
			Me.lblElectricBillPerMonth_E.Left = 5.6875F
			Me.lblElectricBillPerMonth_E.Name = "lblElectricBillPerMonth_E"
			Me.lblElectricBillPerMonth_E.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblElectricBillPerMonth_E.Text = "Month elec."
			Me.lblElectricBillPerMonth_E.Top = 3.25F
			Me.lblElectricBillPerMonth_E.Width = 0.625F
			Me.lblDollarsPerBblFluid_E.Height = 0.145F
			Me.lblDollarsPerBblFluid_E.HyperLink = Nothing
			Me.lblDollarsPerBblFluid_E.Left = 5.6875F
			Me.lblDollarsPerBblFluid_E.Name = "lblDollarsPerBblFluid_E"
			Me.lblDollarsPerBblFluid_E.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblFluid_E.Text = "$/bbl fluid"
			Me.lblDollarsPerBblFluid_E.Top = 3.375F
			Me.lblDollarsPerBblFluid_E.Width = 0.625F
			Me.lblDollarsPerBblOil_E.Height = 0.145F
			Me.lblDollarsPerBblOil_E.HyperLink = Nothing
			Me.lblDollarsPerBblOil_E.Left = 5.6875F
			Me.lblDollarsPerBblOil_E.Name = "lblDollarsPerBblOil_E"
			Me.lblDollarsPerBblOil_E.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblOil_E.Text = "$/bbl oil"
			Me.lblDollarsPerBblOil_E.Top = 3.5F
			Me.lblDollarsPerBblOil_E.Width = 0.625F
			Me.Line8.Height = 0F
			Me.Line8.Left = 0.1319444F
			Me.Line8.LineWeight = 1F
			Me.Line8.Name = "Line8"
			Me.Line8.Top = 1.6425F
			Me.Line8.Width = 6.600001F
			Me.Line8.X1 = 0.1319444F
			Me.Line8.X2 = 6.731945F
			Me.Line8.Y1 = 1.6425F
			Me.Line8.Y2 = 1.6425F
			Me.lblPmMinEner.Height = 0.125F
			Me.lblPmMinEner.HyperLink = Nothing
			Me.lblPmMinEner.Left = 2.8125F
			Me.lblPmMinEner.Name = "lblPmMinEner"
			Me.lblPmMinEner.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblPmMinEner.Text = "(Min Ener)"
			Me.lblPmMinEner.Top = 1.475F
			Me.lblPmMinEner.Width = 1.25F
			Me.lblNEMAD_BE.Height = 0.145F
			Me.lblNEMAD_BE.HyperLink = Nothing
			Me.lblNEMAD_BE.Left = 3F
			Me.lblNEMAD_BE.Name = "lblNEMAD_BE"
			Me.lblNEMAD_BE.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblNEMAD_BE.Text = "NEMA D"
			Me.lblNEMAD_BE.Top = 1.675F
			Me.lblNEMAD_BE.Width = 0.75F
			Me.lblSingleCyl_BE.Height = 0.145F
			Me.lblSingleCyl_BE.HyperLink = Nothing
			Me.lblSingleCyl_BE.Left = 3F
			Me.lblSingleCyl_BE.Name = "lblSingleCyl_BE"
			Me.lblSingleCyl_BE.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblSingleCyl_BE.Text = "Single cyl."
			Me.lblSingleCyl_BE.Top = 1.8F
			Me.lblSingleCyl_BE.Width = 0.75F
			Me.lblMultiCyl_BE.Height = 0.145F
			Me.lblMultiCyl_BE.HyperLink = Nothing
			Me.lblMultiCyl_BE.Left = 3F
			Me.lblMultiCyl_BE.Name = "lblMultiCyl_BE"
			Me.lblMultiCyl_BE.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblMultiCyl_BE.Text = "Multicyl."
			Me.lblMultiCyl_BE.Top = 1.925F
			Me.lblMultiCyl_BE.Width = 0.75F
			Me.lblPmMinTorq.Height = 0.15F
			Me.lblPmMinTorq.HyperLink = Nothing
			Me.lblPmMinTorq.Left = 4.125F
			Me.lblPmMinTorq.Name = "lblPmMinTorq"
			Me.lblPmMinTorq.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblPmMinTorq.Text = "(Min Torq)"
			Me.lblPmMinTorq.Top = 1.475F
			Me.lblPmMinTorq.Width = 1.25F
			Me.lblNEMAD_BT.Height = 0.145F
			Me.lblNEMAD_BT.HyperLink = Nothing
			Me.lblNEMAD_BT.Left = 4.3125F
			Me.lblNEMAD_BT.Name = "lblNEMAD_BT"
			Me.lblNEMAD_BT.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblNEMAD_BT.Text = "NEMA D"
			Me.lblNEMAD_BT.Top = 1.675F
			Me.lblNEMAD_BT.Width = 0.75F
			Me.lblSingleCyl_BT.Height = 0.145F
			Me.lblSingleCyl_BT.HyperLink = Nothing
			Me.lblSingleCyl_BT.Left = 4.3125F
			Me.lblSingleCyl_BT.Name = "lblSingleCyl_BT"
			Me.lblSingleCyl_BT.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblSingleCyl_BT.Text = "Single cyl."
			Me.lblSingleCyl_BT.Top = 1.8F
			Me.lblSingleCyl_BT.Width = 0.75F
			Me.lblMultiCyl_BT.Height = 0.145F
			Me.lblMultiCyl_BT.HyperLink = Nothing
			Me.lblMultiCyl_BT.Left = 4.3125F
			Me.lblMultiCyl_BT.Name = "lblMultiCyl_BT"
			Me.lblMultiCyl_BT.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblMultiCyl_BT.Text = "Multicyl."
			Me.lblMultiCyl_BT.Top = 1.925F
			Me.lblMultiCyl_BT.Width = 0.75F
			Me.lblPmExisting.Height = 0.125F
			Me.lblPmExisting.HyperLink = Nothing
			Me.lblPmExisting.Left = 5.4375F
			Me.lblPmExisting.Name = "lblPmExisting"
			Me.lblPmExisting.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblPmExisting.Text = "EXISTING"
			Me.lblPmExisting.Top = 1.35F
			Me.lblPmExisting.Width = 1.25F
			Me.lblNEMAD_E.Height = 0.145F
			Me.lblNEMAD_E.HyperLink = Nothing
			Me.lblNEMAD_E.Left = 5.625F
			Me.lblNEMAD_E.Name = "lblNEMAD_E"
			Me.lblNEMAD_E.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblNEMAD_E.Text = "NEMA D"
			Me.lblNEMAD_E.Top = 1.675F
			Me.lblNEMAD_E.Width = 0.75F
			Me.lblSingleCyl_E.Height = 0.145F
			Me.lblSingleCyl_E.HyperLink = Nothing
			Me.lblSingleCyl_E.Left = 5.625F
			Me.lblSingleCyl_E.Name = "lblSingleCyl_E"
			Me.lblSingleCyl_E.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblSingleCyl_E.Text = "Single cyl."
			Me.lblSingleCyl_E.Top = 1.8F
			Me.lblSingleCyl_E.Width = 0.75F
			Me.lblMultiCyl_E.Height = 0.145F
			Me.lblMultiCyl_E.HyperLink = Nothing
			Me.lblMultiCyl_E.Left = 5.625F
			Me.lblMultiCyl_E.Name = "lblMultiCyl_E"
			Me.lblMultiCyl_E.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; white-space: nowrap"
			Me.lblMultiCyl_E.Text = "Multicyl."
			Me.lblMultiCyl_E.Top = 1.925F
			Me.lblMultiCyl_E.Width = 0.75F
			Me.lblMultiCyl.Height = 0.1875F
			Me.lblMultiCyl.HyperLink = Nothing
			Me.lblMultiCyl.Left = 0.125F
			Me.lblMultiCyl.Name = "lblMultiCyl"
			Me.lblMultiCyl.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMultiCyl.Text = "Multicylinder engine:"
			Me.lblMultiCyl.Top = 1.925F
			Me.lblMultiCyl.Width = 2.625F
			Me.lblElectricityConsumption.Height = 0.15F
			Me.lblElectricityConsumption.HyperLink = Nothing
			Me.lblElectricityConsumption.Left = 0.125F
			Me.lblElectricityConsumption.Name = "lblElectricityConsumption"
			Me.lblElectricityConsumption.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblElectricityConsumption.Text = "  electricity consumption"
			Me.lblElectricityConsumption.Top = 2.25F
			Me.lblElectricityConsumption.Width = 2.625F
			Me.Line9.Height = 0F
			Me.Line9.Left = 0.1319444F
			Me.Line9.LineWeight = 1F
			Me.Line9.Name = "Line9"
			Me.Line9.Top = 2.444444F
			Me.Line9.Width = 6.600001F
			Me.Line9.X1 = 0.1319444F
			Me.Line9.X2 = 6.731945F
			Me.Line9.Y1 = 2.444444F
			Me.Line9.Y2 = 2.444444F
			Me.lblTubingCalculations.Height = 0.15F
			Me.lblTubingCalculations.HyperLink = Nothing
			Me.lblTubingCalculations.Left = 0.125F
			Me.lblTubingCalculations.Name = "lblTubingCalculations"
			Me.lblTubingCalculations.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblTubingCalculations.Text = "Tubing, pump and plunger calculations"
			Me.lblTubingCalculations.Top = 3.6875F
			Me.lblTubingCalculations.Width = 4.1875F
			Me.Line10.Height = 0F
			Me.Line10.Left = 0.125F
			Me.Line10.LineWeight = 1F
			Me.Line10.Name = "Line10"
			Me.Line10.Top = 3.875F
			Me.Line10.Width = 4.1875F
			Me.Line10.X1 = 0.125F
			Me.Line10.X2 = 4.3125F
			Me.Line10.Y1 = 3.875F
			Me.Line10.Y2 = 3.875F
			Me.lblRodStringResults.Height = 0.15F
			Me.lblRodStringResults.HyperLink = Nothing
			Me.lblRodStringResults.Left = 0.125F
			Me.lblRodStringResults.Name = "lblRodStringResults"
			Me.lblRodStringResults.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodStringResults.Text = "Rod string design"
			Me.lblRodStringResults.Top = 4.75F
			Me.lblRodStringResults.Width = 7.25F
			Me.lblRodStressHdrBot.Height = 0.145F
			Me.lblRodStressHdrBot.HyperLink = Nothing
			Me.lblRodStressHdrBot.Left = 0.375F
			Me.lblRodStressHdrBot.Name = "lblRodStressHdrBot"
			Me.lblRodStressHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressHdrBot.Text = " Load %"
			Me.lblRodStressHdrBot.Top = 5.125F
			Me.lblRodStressHdrBot.Width = 1.25F
			Me.lblRodStress1.Height = 0.125F
			Me.lblRodStress1.HyperLink = Nothing
			Me.lblRodStress1.Left = 0.625F
			Me.lblRodStress1.Name = "lblRodStress1"
			Me.lblRodStress1.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress1.Text = "Stress"
			Me.lblRodStress1.Top = 5.375F
			Me.lblRodStress1.Width = 0.75F
			Me.lblRodTopMaxStressHdrBot.Height = 0.145F
			Me.lblRodTopMaxStressHdrBot.HyperLink = Nothing
			Me.lblRodTopMaxStressHdrBot.Left = 1.75F
			Me.lblRodTopMaxStressHdrBot.Name = "lblRodTopMaxStressHdrBot"
			Me.lblRodTopMaxStressHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStressHdrBot.Text = "Stress (psi)"
			Me.lblRodTopMaxStressHdrBot.Top = 5.125F
			Me.lblRodTopMaxStressHdrBot.Width = 1.25F
			Me.lblRodTopMinStressHdrBot.Height = 0.145F
			Me.lblRodTopMinStressHdrBot.HyperLink = Nothing
			Me.lblRodTopMinStressHdrBot.Left = 3.125F
			Me.lblRodTopMinStressHdrBot.Name = "lblRodTopMinStressHdrBot"
			Me.lblRodTopMinStressHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStressHdrBot.Text = "  Stress (psi)"
			Me.lblRodTopMinStressHdrBot.Top = 5.125F
			Me.lblRodTopMinStressHdrBot.Width = 1.25F
			Me.lblRodBotMinStressHdrBot.Height = 0.145F
			Me.lblRodBotMinStressHdrBot.HyperLink = Nothing
			Me.lblRodBotMinStressHdrBot.Left = 4.5F
			Me.lblRodBotMinStressHdrBot.Name = "lblRodBotMinStressHdrBot"
			Me.lblRodBotMinStressHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStressHdrBot.Text = " Stress (psi)"
			Me.lblRodBotMinStressHdrBot.Top = 5.125F
			Me.lblRodBotMinStressHdrBot.Width = 1.25F
			Me.lblRodStress2.Height = 0.125F
			Me.lblRodStress2.HyperLink = Nothing
			Me.lblRodStress2.Left = 0.625F
			Me.lblRodStress2.Name = "lblRodStress2"
			Me.lblRodStress2.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress2.Text = "Stress"
			Me.lblRodStress2.Top = 5.5F
			Me.lblRodStress2.Width = 0.75F
			Me.lblRodStress3.Height = 0.125F
			Me.lblRodStress3.HyperLink = Nothing
			Me.lblRodStress3.Left = 0.625F
			Me.lblRodStress3.Name = "lblRodStress3"
			Me.lblRodStress3.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress3.Text = "Stress"
			Me.lblRodStress3.Top = 5.625F
			Me.lblRodStress3.Width = 0.75F
			Me.lblRodStress4.Height = 0.125F
			Me.lblRodStress4.HyperLink = Nothing
			Me.lblRodStress4.Left = 0.625F
			Me.lblRodStress4.Name = "lblRodStress4"
			Me.lblRodStress4.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress4.Text = "Stress"
			Me.lblRodStress4.Top = 5.75F
			Me.lblRodStress4.Width = 0.75F
			Me.lblRodStress5.Height = 0.125F
			Me.lblRodStress5.HyperLink = Nothing
			Me.lblRodStress5.Left = 0.625F
			Me.lblRodStress5.Name = "lblRodStress5"
			Me.lblRodStress5.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress5.Text = "Stress"
			Me.lblRodStress5.Top = 5.875F
			Me.lblRodStress5.Width = 0.75F
			Me.lblRodStress6.Height = 0.125F
			Me.lblRodStress6.HyperLink = Nothing
			Me.lblRodStress6.Left = 0.625F
			Me.lblRodStress6.Name = "lblRodStress6"
			Me.lblRodStress6.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress6.Text = "Stress"
			Me.lblRodStress6.Top = 6F
			Me.lblRodStress6.Width = 0.75F
			Me.lblRodStress7.Height = 0.125F
			Me.lblRodStress7.HyperLink = Nothing
			Me.lblRodStress7.Left = 0.625F
			Me.lblRodStress7.Name = "lblRodStress7"
			Me.lblRodStress7.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress7.Text = "Stress"
			Me.lblRodStress7.Top = 6.125F
			Me.lblRodStress7.Width = 0.75F
			Me.lblRodStress8.Height = 0.125F
			Me.lblRodStress8.HyperLink = Nothing
			Me.lblRodStress8.Left = 0.625F
			Me.lblRodStress8.Name = "lblRodStress8"
			Me.lblRodStress8.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress8.Text = "Stress"
			Me.lblRodStress8.Top = 6.25F
			Me.lblRodStress8.Width = 0.75F
			Me.lblRodTopMaxStress1.Height = 0.125F
			Me.lblRodTopMaxStress1.HyperLink = Nothing
			Me.lblRodTopMaxStress1.Left = 1.9375F
			Me.lblRodTopMaxStress1.Name = "lblRodTopMaxStress1"
			Me.lblRodTopMaxStress1.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress1.Text = "Top Max"
			Me.lblRodTopMaxStress1.Top = 5.375F
			Me.lblRodTopMaxStress1.Width = 0.75F
			Me.lblRodTopMaxStress2.Height = 0.125F
			Me.lblRodTopMaxStress2.HyperLink = Nothing
			Me.lblRodTopMaxStress2.Left = 1.9375F
			Me.lblRodTopMaxStress2.Name = "lblRodTopMaxStress2"
			Me.lblRodTopMaxStress2.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress2.Text = "Top Max"
			Me.lblRodTopMaxStress2.Top = 5.5F
			Me.lblRodTopMaxStress2.Width = 0.75F
			Me.lblRodTopMaxStress3.Height = 0.125F
			Me.lblRodTopMaxStress3.HyperLink = Nothing
			Me.lblRodTopMaxStress3.Left = 1.9375F
			Me.lblRodTopMaxStress3.Name = "lblRodTopMaxStress3"
			Me.lblRodTopMaxStress3.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress3.Text = "Top Max"
			Me.lblRodTopMaxStress3.Top = 5.625F
			Me.lblRodTopMaxStress3.Width = 0.75F
			Me.lblRodTopMaxStress4.Height = 0.125F
			Me.lblRodTopMaxStress4.HyperLink = Nothing
			Me.lblRodTopMaxStress4.Left = 1.9375F
			Me.lblRodTopMaxStress4.Name = "lblRodTopMaxStress4"
			Me.lblRodTopMaxStress4.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress4.Text = "Top Max"
			Me.lblRodTopMaxStress4.Top = 5.75F
			Me.lblRodTopMaxStress4.Width = 0.75F
			Me.lblRodTopMaxStress5.Height = 0.125F
			Me.lblRodTopMaxStress5.HyperLink = Nothing
			Me.lblRodTopMaxStress5.Left = 1.9375F
			Me.lblRodTopMaxStress5.Name = "lblRodTopMaxStress5"
			Me.lblRodTopMaxStress5.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress5.Text = "Top Max"
			Me.lblRodTopMaxStress5.Top = 5.875F
			Me.lblRodTopMaxStress5.Width = 0.75F
			Me.lblRodTopMaxStress6.Height = 0.125F
			Me.lblRodTopMaxStress6.HyperLink = Nothing
			Me.lblRodTopMaxStress6.Left = 1.9375F
			Me.lblRodTopMaxStress6.Name = "lblRodTopMaxStress6"
			Me.lblRodTopMaxStress6.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress6.Text = "Top Max"
			Me.lblRodTopMaxStress6.Top = 6F
			Me.lblRodTopMaxStress6.Width = 0.75F
			Me.lblRodTopMaxStress7.Height = 0.125F
			Me.lblRodTopMaxStress7.HyperLink = Nothing
			Me.lblRodTopMaxStress7.Left = 1.9375F
			Me.lblRodTopMaxStress7.Name = "lblRodTopMaxStress7"
			Me.lblRodTopMaxStress7.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress7.Text = "Top Max"
			Me.lblRodTopMaxStress7.Top = 6.125F
			Me.lblRodTopMaxStress7.Width = 0.75F
			Me.lblRodTopMaxStress8.Height = 0.125F
			Me.lblRodTopMaxStress8.HyperLink = Nothing
			Me.lblRodTopMaxStress8.Left = 1.9375F
			Me.lblRodTopMaxStress8.Name = "lblRodTopMaxStress8"
			Me.lblRodTopMaxStress8.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress8.Text = "Top Max"
			Me.lblRodTopMaxStress8.Top = 6.25F
			Me.lblRodTopMaxStress8.Width = 0.75F
			Me.lblRodTopMinStress1.Height = 0.125F
			Me.lblRodTopMinStress1.HyperLink = Nothing
			Me.lblRodTopMinStress1.Left = 3.375F
			Me.lblRodTopMinStress1.Name = "lblRodTopMinStress1"
			Me.lblRodTopMinStress1.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress1.Text = "Top Min"
			Me.lblRodTopMinStress1.Top = 5.375F
			Me.lblRodTopMinStress1.Width = 0.75F
			Me.lblRodTopMinStress2.Height = 0.125F
			Me.lblRodTopMinStress2.HyperLink = Nothing
			Me.lblRodTopMinStress2.Left = 3.375F
			Me.lblRodTopMinStress2.Name = "lblRodTopMinStress2"
			Me.lblRodTopMinStress2.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress2.Text = "Top Min"
			Me.lblRodTopMinStress2.Top = 5.5F
			Me.lblRodTopMinStress2.Width = 0.75F
			Me.lblRodTopMinStress3.Height = 0.125F
			Me.lblRodTopMinStress3.HyperLink = Nothing
			Me.lblRodTopMinStress3.Left = 3.375F
			Me.lblRodTopMinStress3.Name = "lblRodTopMinStress3"
			Me.lblRodTopMinStress3.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress3.Text = "Top Min"
			Me.lblRodTopMinStress3.Top = 5.625F
			Me.lblRodTopMinStress3.Width = 0.75F
			Me.lblRodTopMinStress4.Height = 0.125F
			Me.lblRodTopMinStress4.HyperLink = Nothing
			Me.lblRodTopMinStress4.Left = 3.375F
			Me.lblRodTopMinStress4.Name = "lblRodTopMinStress4"
			Me.lblRodTopMinStress4.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress4.Text = "Top Min"
			Me.lblRodTopMinStress4.Top = 5.75F
			Me.lblRodTopMinStress4.Width = 0.75F
			Me.lblRodTopMinStress5.Height = 0.125F
			Me.lblRodTopMinStress5.HyperLink = Nothing
			Me.lblRodTopMinStress5.Left = 3.375F
			Me.lblRodTopMinStress5.Name = "lblRodTopMinStress5"
			Me.lblRodTopMinStress5.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress5.Text = "Top Min"
			Me.lblRodTopMinStress5.Top = 5.875F
			Me.lblRodTopMinStress5.Width = 0.75F
			Me.lblRodTopMinStress6.Height = 0.125F
			Me.lblRodTopMinStress6.HyperLink = Nothing
			Me.lblRodTopMinStress6.Left = 3.375F
			Me.lblRodTopMinStress6.Name = "lblRodTopMinStress6"
			Me.lblRodTopMinStress6.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress6.Text = "Top Min"
			Me.lblRodTopMinStress6.Top = 6F
			Me.lblRodTopMinStress6.Width = 0.75F
			Me.lblRodTopMinStress7.Height = 0.125F
			Me.lblRodTopMinStress7.HyperLink = Nothing
			Me.lblRodTopMinStress7.Left = 3.375F
			Me.lblRodTopMinStress7.Name = "lblRodTopMinStress7"
			Me.lblRodTopMinStress7.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress7.Text = "Top Min"
			Me.lblRodTopMinStress7.Top = 6.125F
			Me.lblRodTopMinStress7.Width = 0.75F
			Me.lblRodTopMinStress8.Height = 0.125F
			Me.lblRodTopMinStress8.HyperLink = Nothing
			Me.lblRodTopMinStress8.Left = 3.375F
			Me.lblRodTopMinStress8.Name = "lblRodTopMinStress8"
			Me.lblRodTopMinStress8.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress8.Text = "Top Min"
			Me.lblRodTopMinStress8.Top = 6.25F
			Me.lblRodTopMinStress8.Width = 0.75F
			Me.lblRodBotMinStress1.Height = 0.125F
			Me.lblRodBotMinStress1.HyperLink = Nothing
			Me.lblRodBotMinStress1.Left = 4.75F
			Me.lblRodBotMinStress1.Name = "lblRodBotMinStress1"
			Me.lblRodBotMinStress1.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress1.Text = "Bot Min"
			Me.lblRodBotMinStress1.Top = 5.375F
			Me.lblRodBotMinStress1.Width = 0.8125F
			Me.lblRodBotMinStress2.Height = 0.125F
			Me.lblRodBotMinStress2.HyperLink = Nothing
			Me.lblRodBotMinStress2.Left = 4.75F
			Me.lblRodBotMinStress2.Name = "lblRodBotMinStress2"
			Me.lblRodBotMinStress2.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress2.Text = "Bot Min"
			Me.lblRodBotMinStress2.Top = 5.5F
			Me.lblRodBotMinStress2.Width = 0.8125F
			Me.lblRodBotMinStress3.Height = 0.125F
			Me.lblRodBotMinStress3.HyperLink = Nothing
			Me.lblRodBotMinStress3.Left = 4.75F
			Me.lblRodBotMinStress3.Name = "lblRodBotMinStress3"
			Me.lblRodBotMinStress3.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress3.Text = "Bot Min"
			Me.lblRodBotMinStress3.Top = 5.625F
			Me.lblRodBotMinStress3.Width = 0.8125F
			Me.lblRodBotMinStress4.Height = 0.125F
			Me.lblRodBotMinStress4.HyperLink = Nothing
			Me.lblRodBotMinStress4.Left = 4.75F
			Me.lblRodBotMinStress4.Name = "lblRodBotMinStress4"
			Me.lblRodBotMinStress4.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress4.Text = "Bot Min"
			Me.lblRodBotMinStress4.Top = 5.75F
			Me.lblRodBotMinStress4.Width = 0.8125F
			Me.lblRodBotMinStress5.Height = 0.125F
			Me.lblRodBotMinStress5.HyperLink = Nothing
			Me.lblRodBotMinStress5.Left = 4.75F
			Me.lblRodBotMinStress5.Name = "lblRodBotMinStress5"
			Me.lblRodBotMinStress5.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress5.Text = "Bot Min"
			Me.lblRodBotMinStress5.Top = 5.875F
			Me.lblRodBotMinStress5.Width = 0.8125F
			Me.lblRodBotMinStress6.Height = 0.125F
			Me.lblRodBotMinStress6.HyperLink = Nothing
			Me.lblRodBotMinStress6.Left = 4.75F
			Me.lblRodBotMinStress6.Name = "lblRodBotMinStress6"
			Me.lblRodBotMinStress6.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress6.Text = "Bot Min"
			Me.lblRodBotMinStress6.Top = 6F
			Me.lblRodBotMinStress6.Width = 0.8125F
			Me.lblRodBotMinStress7.Height = 0.125F
			Me.lblRodBotMinStress7.HyperLink = Nothing
			Me.lblRodBotMinStress7.Left = 4.75F
			Me.lblRodBotMinStress7.Name = "lblRodBotMinStress7"
			Me.lblRodBotMinStress7.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress7.Text = "Bot Min"
			Me.lblRodBotMinStress7.Top = 6.125F
			Me.lblRodBotMinStress7.Width = 0.8125F
			Me.lblRodBotMinStress8.Height = 0.125F
			Me.lblRodBotMinStress8.HyperLink = Nothing
			Me.lblRodBotMinStress8.Left = 4.75F
			Me.lblRodBotMinStress8.Name = "lblRodBotMinStress8"
			Me.lblRodBotMinStress8.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress8.Text = "Bot Min"
			Me.lblRodBotMinStress8.Top = 6.25F
			Me.lblRodBotMinStress8.Width = 0.8125F
			Me.lblRodStressMethodHdrBot.Height = 0.145F
			Me.lblRodStressMethodHdrBot.HyperLink = Nothing
			Me.lblRodStressMethodHdrBot.Left = 5.875F
			Me.lblRodStressMethodHdrBot.Name = "lblRodStressMethodHdrBot"
			Me.lblRodStressMethodHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethodHdrBot.Text = "Method"
			Me.lblRodStressMethodHdrBot.Top = 5.125F
			Me.lblRodStressMethodHdrBot.Width = 1.25F
			Me.lblRodStressMethod1.Height = 0.125F
			Me.lblRodStressMethod1.HyperLink = Nothing
			Me.lblRodStressMethod1.Left = 6F
			Me.lblRodStressMethod1.Name = "lblRodStressMethod1"
			Me.lblRodStressMethod1.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod1.Text = "Stress Meth"
			Me.lblRodStressMethod1.Top = 5.375F
			Me.lblRodStressMethod1.Width = 1.0625F
			Me.lblRodStressMethod2.Height = 0.125F
			Me.lblRodStressMethod2.HyperLink = Nothing
			Me.lblRodStressMethod2.Left = 6F
			Me.lblRodStressMethod2.Name = "lblRodStressMethod2"
			Me.lblRodStressMethod2.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod2.Text = "Stress Meth"
			Me.lblRodStressMethod2.Top = 5.5F
			Me.lblRodStressMethod2.Width = 1.0625F
			Me.lblRodStressMethod3.Height = 0.125F
			Me.lblRodStressMethod3.HyperLink = Nothing
			Me.lblRodStressMethod3.Left = 6F
			Me.lblRodStressMethod3.Name = "lblRodStressMethod3"
			Me.lblRodStressMethod3.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod3.Text = "Stress Meth"
			Me.lblRodStressMethod3.Top = 5.625F
			Me.lblRodStressMethod3.Width = 1.0625F
			Me.lblRodStressMethod4.Height = 0.125F
			Me.lblRodStressMethod4.HyperLink = Nothing
			Me.lblRodStressMethod4.Left = 6F
			Me.lblRodStressMethod4.Name = "lblRodStressMethod4"
			Me.lblRodStressMethod4.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod4.Text = "Stress Meth"
			Me.lblRodStressMethod4.Top = 5.75F
			Me.lblRodStressMethod4.Width = 1.0625F
			Me.lblRodStressMethod5.Height = 0.125F
			Me.lblRodStressMethod5.HyperLink = Nothing
			Me.lblRodStressMethod5.Left = 6F
			Me.lblRodStressMethod5.Name = "lblRodStressMethod5"
			Me.lblRodStressMethod5.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod5.Text = "Stress Meth"
			Me.lblRodStressMethod5.Top = 5.875F
			Me.lblRodStressMethod5.Width = 1.0625F
			Me.lblRodStressMethod6.Height = 0.125F
			Me.lblRodStressMethod6.HyperLink = Nothing
			Me.lblRodStressMethod6.Left = 6F
			Me.lblRodStressMethod6.Name = "lblRodStressMethod6"
			Me.lblRodStressMethod6.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod6.Text = "Stress Meth"
			Me.lblRodStressMethod6.Top = 6F
			Me.lblRodStressMethod6.Width = 1.0625F
			Me.lblRodStressMethod7.Height = 0.125F
			Me.lblRodStressMethod7.HyperLink = Nothing
			Me.lblRodStressMethod7.Left = 6F
			Me.lblRodStressMethod7.Name = "lblRodStressMethod7"
			Me.lblRodStressMethod7.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod7.Text = "Stress Meth"
			Me.lblRodStressMethod7.Top = 6.125F
			Me.lblRodStressMethod7.Width = 1.0625F
			Me.lblRodStressMethod8.Height = 0.125F
			Me.lblRodStressMethod8.HyperLink = Nothing
			Me.lblRodStressMethod8.Left = 6F
			Me.lblRodStressMethod8.Name = "lblRodStressMethod8"
			Me.lblRodStressMethod8.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod8.Text = "Stress Meth"
			Me.lblRodStressMethod8.Top = 6.25F
			Me.lblRodStressMethod8.Width = 1.0625F
			Me.lblPlungerLength.Height = 0.145F
			Me.lblPlungerLength.HyperLink = Nothing
			Me.lblPlungerLength.Left = 0.125F
			Me.lblPlungerLength.Name = "lblPlungerLength"
			Me.lblPlungerLength.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPlungerLength.Text = "Recommended plunger length"
			Me.lblPlungerLength.Top = 4.5625F
			Me.lblPlungerLength.Width = 2.625F
			Me.lblPumpLength.Height = 0.145F
			Me.lblPumpLength.HyperLink = Nothing
			Me.lblPumpLength.Left = 0.125F
			Me.lblPumpLength.Name = "lblPumpLength"
			Me.lblPumpLength.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPumpLength.Text = "Minimum pump length"
			Me.lblPumpLength.Top = 4.4375F
			Me.lblPumpLength.Width = 2.625F
			Me.lblPumpSpacing.Height = 0.145F
			Me.lblPumpSpacing.HyperLink = Nothing
			Me.lblPumpSpacing.Left = 0.125F
			Me.lblPumpSpacing.Name = "lblPumpSpacing"
			Me.lblPumpSpacing.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPumpSpacing.Text = "Pump spacing"
			Me.lblPumpSpacing.Top = 4.3125F
			Me.lblPumpSpacing.Width = 2.625F
			Me.lblGrossPumpStroke.Height = 0.145F
			Me.lblGrossPumpStroke.HyperLink = Nothing
			Me.lblGrossPumpStroke.Left = 0.125F
			Me.lblGrossPumpStroke.Name = "lblGrossPumpStroke"
			Me.lblGrossPumpStroke.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblGrossPumpStroke.Text = "Gross pump stroke"
			Me.lblGrossPumpStroke.Top = 4.1875F
			Me.lblGrossPumpStroke.Width = 2.625F
			Me.lblProductionLoss.Height = 0.145F
			Me.lblProductionLoss.HyperLink = Nothing
			Me.lblProductionLoss.Left = 0.125F
			Me.lblProductionLoss.Name = "lblProductionLoss"
			Me.lblProductionLoss.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblProductionLoss.Text = "Production loss"
			Me.lblProductionLoss.Top = 4.0625F
			Me.lblProductionLoss.Width = 2.625F
			Me.lblTubingStretch.Height = 0.145F
			Me.lblTubingStretch.HyperLink = Nothing
			Me.lblTubingStretch.Left = 0.125F
			Me.lblTubingStretch.Name = "lblTubingStretch"
			Me.lblTubingStretch.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblTubingStretch.Text = "Tubing stretch"
			Me.lblTubingStretch.Top = 3.9375F
			Me.lblTubingStretch.Width = 2.625F
			Me.lblDollarsPerBblOil.Height = 0.145F
			Me.lblDollarsPerBblOil.HyperLink = Nothing
			Me.lblDollarsPerBblOil.Left = 0.125F
			Me.lblDollarsPerBblOil.Name = "lblDollarsPerBblOil"
			Me.lblDollarsPerBblOil.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblOil.Text = "Electr.cost per bbl. oil:"
			Me.lblDollarsPerBblOil.Top = 3.5F
			Me.lblDollarsPerBblOil.Width = 2.625F
			Me.lblDollarsPerBblFluid.Height = 0.145F
			Me.lblDollarsPerBblFluid.HyperLink = Nothing
			Me.lblDollarsPerBblFluid.Left = 0.125F
			Me.lblDollarsPerBblFluid.Name = "lblDollarsPerBblFluid"
			Me.lblDollarsPerBblFluid.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblDollarsPerBblFluid.Text = "Electr.cost per bbl. fluid:"
			Me.lblDollarsPerBblFluid.Top = 3.375F
			Me.lblDollarsPerBblFluid.Width = 2.625F
			Me.lblElectricBillPerMonth.Height = 0.145F
			Me.lblElectricBillPerMonth.HyperLink = Nothing
			Me.lblElectricBillPerMonth.Left = 0.125F
			Me.lblElectricBillPerMonth.Name = "lblElectricBillPerMonth"
			Me.lblElectricBillPerMonth.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblElectricBillPerMonth.Text = "Monthly electric bill:"
			Me.lblElectricBillPerMonth.Top = 3.25F
			Me.lblElectricBillPerMonth.Width = 2.625F
			Me.lblGearboxLoading.Height = 0.145F
			Me.lblGearboxLoading.HyperLink = Nothing
			Me.lblGearboxLoading.Left = 0.125F
			Me.lblGearboxLoading.Name = "lblGearboxLoading"
			Me.lblGearboxLoading.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblGearboxLoading.Text = "Gearbox loading:"
			Me.lblGearboxLoading.Top = 2.625F
			Me.lblGearboxLoading.Width = 2.625F
			Me.lblTorqueAnalysis.Height = 0.15F
			Me.lblTorqueAnalysis.HyperLink = Nothing
			Me.lblTorqueAnalysis.Left = 0.125F
			Me.lblTorqueAnalysis.Name = "lblTorqueAnalysis"
			Me.lblTorqueAnalysis.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblTorqueAnalysis.Text = "Torque analysis and"
			Me.lblTorqueAnalysis.Top = 2.125F
			Me.lblTorqueAnalysis.Width = 2.625F
			Me.lblSingleCyl.Height = 0.145F
			Me.lblSingleCyl.HyperLink = Nothing
			Me.lblSingleCyl.Left = 0.125F
			Me.lblSingleCyl.Name = "lblSingleCyl"
			Me.lblSingleCyl.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblSingleCyl.Text = "Single/double cyl. engine:"
			Me.lblSingleCyl.Top = 1.8F
			Me.lblSingleCyl.Width = 2.625F
			Me.lblPeakTorque.Height = 0.145F
			Me.lblPeakTorque.HyperLink = Nothing
			Me.lblPeakTorque.Left = 0.125F
			Me.lblPeakTorque.Name = "lblPeakTorque"
			Me.lblPeakTorque.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPeakTorque.Text = "Peak torque"
			Me.lblPeakTorque.Top = 2.5F
			Me.lblPeakTorque.Width = 2.625F
			Me.lblMotorKWH.Height = 0.145F
			Me.lblMotorKWH.HyperLink = Nothing
			Me.lblMotorKWH.Left = 0.125F
			Me.lblMotorKWH.Name = "lblMotorKWH"
			Me.lblMotorKWH.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblMotorKWH.Text = "Daily electr.use (KWH/day):"
			Me.lblMotorKWH.Top = 3.125F
			Me.lblMotorKWH.Width = 2.625F
			Me.lblReqPrimeMoverSize.Height = 0.145F
			Me.lblReqPrimeMoverSize.HyperLink = Nothing
			Me.lblReqPrimeMoverSize.Left = 0.125F
			Me.lblReqPrimeMoverSize.Name = "lblReqPrimeMoverSize"
			Me.lblReqPrimeMoverSize.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblReqPrimeMoverSize.Text = "Required prime mover size"
			Me.lblReqPrimeMoverSize.Top = 1.325F
			Me.lblReqPrimeMoverSize.Width = 2.625F
			Me.lblRodTopMinStressHdrTop.Height = 0.145F
			Me.lblRodTopMinStressHdrTop.HyperLink = Nothing
			Me.lblRodTopMinStressHdrTop.Left = 3.125F
			Me.lblRodTopMinStressHdrTop.Name = "lblRodTopMinStressHdrTop"
			Me.lblRodTopMinStressHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStressHdrTop.Text = "Top Minimum"
			Me.lblRodTopMinStressHdrTop.Top = 5F
			Me.lblRodTopMinStressHdrTop.Width = 1.25F
			Me.lblRodBotMinStressHdrTop.Height = 0.145F
			Me.lblRodBotMinStressHdrTop.HyperLink = Nothing
			Me.lblRodBotMinStressHdrTop.Left = 4.5F
			Me.lblRodBotMinStressHdrTop.Name = "lblRodBotMinStressHdrTop"
			Me.lblRodBotMinStressHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStressHdrTop.Text = "  Bot. Minimum"
			Me.lblRodBotMinStressHdrTop.Top = 5F
			Me.lblRodBotMinStressHdrTop.Width = 1.25F
			Me.lblRodStressMethodHdrTop.Height = 0.145F
			Me.lblRodStressMethodHdrTop.HyperLink = Nothing
			Me.lblRodStressMethodHdrTop.Left = 5.875F
			Me.lblRodStressMethodHdrTop.Name = "lblRodStressMethodHdrTop"
			Me.lblRodStressMethodHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethodHdrTop.Text = "   Stress Calc."
			Me.lblRodStressMethodHdrTop.Top = 5F
			Me.lblRodStressMethodHdrTop.Width = 1.25F
			Me.lblRodTopMaxStressHdrTop.Height = 0.145F
			Me.lblRodTopMaxStressHdrTop.HyperLink = Nothing
			Me.lblRodTopMaxStressHdrTop.Left = 1.75F
			Me.lblRodTopMaxStressHdrTop.Name = "lblRodTopMaxStressHdrTop"
			Me.lblRodTopMaxStressHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStressHdrTop.Text = "Top Maximum"
			Me.lblRodTopMaxStressHdrTop.Top = 5F
			Me.lblRodTopMaxStressHdrTop.Width = 1.25F
			Me.lblRodStressHdrTop.Height = 0.145F
			Me.lblRodStressHdrTop.HyperLink = Nothing
			Me.lblRodStressHdrTop.Left = 0.375F
			Me.lblRodStressHdrTop.Name = "lblRodStressHdrTop"
			Me.lblRodStressHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodStressHdrTop.Text = "Stress"
			Me.lblRodStressHdrTop.Top = 5F
			Me.lblRodStressHdrTop.Width = 1.25F
			Me.lblPmBalancedT.Height = 0.125F
			Me.lblPmBalancedT.HyperLink = Nothing
			Me.lblPmBalancedT.Left = 4.125F
			Me.lblPmBalancedT.Name = "lblPmBalancedT"
			Me.lblPmBalancedT.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblPmBalancedT.Text = "BALANCED"
			Me.lblPmBalancedT.Top = 1.35F
			Me.lblPmBalancedT.Width = 1.25F
			Me.lblTqBalancedT.Height = 0.125F
			Me.lblTqBalancedT.HyperLink = Nothing
			Me.lblTqBalancedT.Left = 4.125F
			Me.lblTqBalancedT.Name = "lblTqBalancedT"
			Me.lblTqBalancedT.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblTqBalancedT.Text = "BALANCED"
			Me.lblTqBalancedT.Top = 2.125F
			Me.lblTqBalancedT.Width = 1.25F
			Me.lblTqBalancedE.Height = 0.125F
			Me.lblTqBalancedE.HyperLink = Nothing
			Me.lblTqBalancedE.Left = 2.8125F
			Me.lblTqBalancedE.Name = "lblTqBalancedE"
			Me.lblTqBalancedE.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblTqBalancedE.Text = "BALANCED"
			Me.lblTqBalancedE.Top = 2.125F
			Me.lblTqBalancedE.Width = 1.25F
			Me.txtPlungerLength.Height = 0.145F
			Me.txtPlungerLength.HyperLink = Nothing
			Me.txtPlungerLength.Left = 2.8125F
			Me.txtPlungerLength.Name = "txtPlungerLength"
			Me.txtPlungerLength.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtPlungerLength.Text = " "
			Me.txtPlungerLength.Top = 4.5625F
			Me.txtPlungerLength.Width = 0.625F
			Me.txtPumpLength.Height = 0.145F
			Me.txtPumpLength.HyperLink = Nothing
			Me.txtPumpLength.Left = 2.8125F
			Me.txtPumpLength.Name = "txtPumpLength"
			Me.txtPumpLength.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtPumpLength.Text = " "
			Me.txtPumpLength.Top = 4.4375F
			Me.txtPumpLength.Width = 0.625F
			Me.txtPumpSpacing.Height = 0.145F
			Me.txtPumpSpacing.HyperLink = Nothing
			Me.txtPumpSpacing.Left = 2.8125F
			Me.txtPumpSpacing.Name = "txtPumpSpacing"
			Me.txtPumpSpacing.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtPumpSpacing.Text = " "
			Me.txtPumpSpacing.Top = 4.3125F
			Me.txtPumpSpacing.Width = 0.625F
			Me.txtGrossPumpStroke.Height = 0.145F
			Me.txtGrossPumpStroke.HyperLink = Nothing
			Me.txtGrossPumpStroke.Left = 2.8125F
			Me.txtGrossPumpStroke.Name = "txtGrossPumpStroke"
			Me.txtGrossPumpStroke.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtGrossPumpStroke.Text = " "
			Me.txtGrossPumpStroke.Top = 4.1875F
			Me.txtGrossPumpStroke.Width = 0.625F
			Me.txtProductionLoss.Height = 0.145F
			Me.txtProductionLoss.HyperLink = Nothing
			Me.txtProductionLoss.Left = 2.8125F
			Me.txtProductionLoss.Name = "txtProductionLoss"
			Me.txtProductionLoss.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtProductionLoss.Text = " "
			Me.txtProductionLoss.Top = 4.0625F
			Me.txtProductionLoss.Width = 0.625F
			Me.txtTubingStretch.Height = 0.145F
			Me.txtTubingStretch.HyperLink = Nothing
			Me.txtTubingStretch.Left = 2.8125F
			Me.txtTubingStretch.Name = "txtTubingStretch"
			Me.txtTubingStretch.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtTubingStretch.Text = " "
			Me.txtTubingStretch.Top = 3.9375F
			Me.txtTubingStretch.Width = 0.625F
			Me.lnPMSV.Height = 0F
			Me.lnPMSV.Left = 0.125F
			Me.lnPMSV.LineWeight = 1F
			Me.lnPMSV.Name = "lnPMSV"
			Me.lnPMSV.Top = 1.475F
			Me.lnPMSV.Visible = False
			Me.lnPMSV.Width = 2.625F
			Me.lnPMSV.X1 = 0.125F
			Me.lnPMSV.X2 = 2.75F
			Me.lnPMSV.Y1 = 1.475F
			Me.lnPMSV.Y2 = 1.475F
			Me.linRSCalcSep3.Height = 1.6F
			Me.linRSCalcSep3.Left = 4.4375F
			Me.linRSCalcSep3.LineWeight = 1F
			Me.linRSCalcSep3.Name = "linRSCalcSep3"
			Me.linRSCalcSep3.Top = 5F
			Me.linRSCalcSep3.Width = 0F
			Me.linRSCalcSep3.X1 = 4.4375F
			Me.linRSCalcSep3.X2 = 4.4375F
			Me.linRSCalcSep3.Y1 = 5F
			Me.linRSCalcSep3.Y2 = 6.6F
			Me.linRSCalcSep1.Height = 1.6F
			Me.linRSCalcSep1.Left = 1.6875F
			Me.linRSCalcSep1.LineWeight = 1F
			Me.linRSCalcSep1.Name = "linRSCalcSep1"
			Me.linRSCalcSep1.Top = 5F
			Me.linRSCalcSep1.Width = 0F
			Me.linRSCalcSep1.X1 = 1.6875F
			Me.linRSCalcSep1.X2 = 1.6875F
			Me.linRSCalcSep1.Y1 = 5F
			Me.linRSCalcSep1.Y2 = 6.6F
			Me.linRSCalcSep2.Height = 1.6F
			Me.linRSCalcSep2.Left = 3.0625F
			Me.linRSCalcSep2.LineWeight = 1F
			Me.linRSCalcSep2.Name = "linRSCalcSep2"
			Me.linRSCalcSep2.Top = 5F
			Me.linRSCalcSep2.Width = 0F
			Me.linRSCalcSep2.X1 = 3.0625F
			Me.linRSCalcSep2.X2 = 3.0625F
			Me.linRSCalcSep2.Y1 = 5F
			Me.linRSCalcSep2.Y2 = 6.6F
			Me.linRSCalcSep4.Height = 1.6F
			Me.linRSCalcSep4.Left = 5.819445F
			Me.linRSCalcSep4.LineWeight = 1F
			Me.linRSCalcSep4.Name = "linRSCalcSep4"
			Me.linRSCalcSep4.Top = 5.006945F
			Me.linRSCalcSep4.Width = 0F
			Me.linRSCalcSep4.X1 = 5.819445F
			Me.linRSCalcSep4.X2 = 5.819445F
			Me.linRSCalcSep4.Y1 = 5.006945F
			Me.linRSCalcSep4.Y2 = 6.606945F
			Me.lblPmBalancedE.Height = 0.125F
			Me.lblPmBalancedE.HyperLink = Nothing
			Me.lblPmBalancedE.Left = 2.8125F
			Me.lblPmBalancedE.Name = "lblPmBalancedE"
			Me.lblPmBalancedE.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblPmBalancedE.Text = "BALANCED"
			Me.lblPmBalancedE.Top = 1.35F
			Me.lblPmBalancedE.Width = 1.25F
			Me.lblRodStress9.Height = 0.125F
			Me.lblRodStress9.HyperLink = Nothing
			Me.lblRodStress9.Left = 0.625F
			Me.lblRodStress9.Name = "lblRodStress9"
			Me.lblRodStress9.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress9.Text = "Stress"
			Me.lblRodStress9.Top = 6.375F
			Me.lblRodStress9.Width = 0.75F
			Me.lblRodTopMaxStress9.Height = 0.125F
			Me.lblRodTopMaxStress9.HyperLink = Nothing
			Me.lblRodTopMaxStress9.Left = 1.9375F
			Me.lblRodTopMaxStress9.Name = "lblRodTopMaxStress9"
			Me.lblRodTopMaxStress9.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress9.Text = "Top Max"
			Me.lblRodTopMaxStress9.Top = 6.375F
			Me.lblRodTopMaxStress9.Width = 0.75F
			Me.lblRodTopMinStress9.Height = 0.125F
			Me.lblRodTopMinStress9.HyperLink = Nothing
			Me.lblRodTopMinStress9.Left = 3.375F
			Me.lblRodTopMinStress9.Name = "lblRodTopMinStress9"
			Me.lblRodTopMinStress9.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress9.Text = "Top Min"
			Me.lblRodTopMinStress9.Top = 6.375F
			Me.lblRodTopMinStress9.Width = 0.75F
			Me.lblRodBotMinStress9.Height = 0.125F
			Me.lblRodBotMinStress9.HyperLink = Nothing
			Me.lblRodBotMinStress9.Left = 4.75F
			Me.lblRodBotMinStress9.Name = "lblRodBotMinStress9"
			Me.lblRodBotMinStress9.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress9.Text = "Bot Min"
			Me.lblRodBotMinStress9.Top = 6.375F
			Me.lblRodBotMinStress9.Width = 0.8125F
			Me.lblRodStressMethod9.Height = 0.125F
			Me.lblRodStressMethod9.HyperLink = Nothing
			Me.lblRodStressMethod9.Left = 6F
			Me.lblRodStressMethod9.Name = "lblRodStressMethod9"
			Me.lblRodStressMethod9.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod9.Text = "Stress Meth"
			Me.lblRodStressMethod9.Top = 6.375F
			Me.lblRodStressMethod9.Width = 1.0625F
			Me.lblRodStress10.Height = 0.125F
			Me.lblRodStress10.HyperLink = Nothing
			Me.lblRodStress10.Left = 0.625F
			Me.lblRodStress10.Name = "lblRodStress10"
			Me.lblRodStress10.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStress10.Text = "Stress"
			Me.lblRodStress10.Top = 6.5F
			Me.lblRodStress10.Width = 0.75F
			Me.lblRodTopMaxStress10.Height = 0.125F
			Me.lblRodTopMaxStress10.HyperLink = Nothing
			Me.lblRodTopMaxStress10.Left = 1.9375F
			Me.lblRodTopMaxStress10.Name = "lblRodTopMaxStress10"
			Me.lblRodTopMaxStress10.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMaxStress10.Text = "Top Max"
			Me.lblRodTopMaxStress10.Top = 6.5F
			Me.lblRodTopMaxStress10.Width = 0.75F
			Me.lblRodTopMinStress10.Height = 0.125F
			Me.lblRodTopMinStress10.HyperLink = Nothing
			Me.lblRodTopMinStress10.Left = 3.375F
			Me.lblRodTopMinStress10.Name = "lblRodTopMinStress10"
			Me.lblRodTopMinStress10.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTopMinStress10.Text = "Top Min"
			Me.lblRodTopMinStress10.Top = 6.5F
			Me.lblRodTopMinStress10.Width = 0.75F
			Me.lblRodBotMinStress10.Height = 0.125F
			Me.lblRodBotMinStress10.HyperLink = Nothing
			Me.lblRodBotMinStress10.Left = 4.75F
			Me.lblRodBotMinStress10.Name = "lblRodBotMinStress10"
			Me.lblRodBotMinStress10.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodBotMinStress10.Text = "Bot Min"
			Me.lblRodBotMinStress10.Top = 6.5F
			Me.lblRodBotMinStress10.Width = 0.8125F
			Me.lblRodStressMethod10.Height = 0.125F
			Me.lblRodStressMethod10.HyperLink = Nothing
			Me.lblRodStressMethod10.Left = 6F
			Me.lblRodStressMethod10.Name = "lblRodStressMethod10"
			Me.lblRodStressMethod10.Style = "font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodStressMethod10.Text = "Stress Meth"
			Me.lblRodStressMethod10.Top = 6.5F
			Me.lblRodStressMethod10.Width = 1.0625F
			Me.lblRSFootnote2.Height = 0.15F
			Me.lblRSFootnote2.HyperLink = Nothing
			Me.lblRSFootnote2.Left = 0.0625F
			Me.lblRSFootnote2.Name = "lblRSFootnote2"
			Me.lblRSFootnote2.Style = "font-family: MS Sans Serif; font-size: 7.8pt; text-align: left; white-space: nowrap"
			Me.lblRSFootnote2.Text = "Rod string trailer"
			Me.lblRSFootnote2.Top = 6.8125F
			Me.lblRSFootnote2.Visible = False
			Me.lblRSFootnote2.Width = 7.75F
			Me.lblRSFootnote5.Height = 0.15F
			Me.lblRSFootnote5.HyperLink = Nothing
			Me.lblRSFootnote5.Left = 0.0625F
			Me.lblRSFootnote5.Name = "lblRSFootnote5"
			Me.lblRSFootnote5.Style = "font-family: Microsoft Sans Serif; font-size: 7.8pt; text-align: left; white-space: nowrap"
			Me.lblRSFootnote5.Text = "Rod string trailer"
			Me.lblRSFootnote5.Top = 7.1875F
			Me.lblRSFootnote5.Visible = False
			Me.lblRSFootnote5.Width = 7.75F
			Me.lblRSFootnote4.Height = 0.15F
			Me.lblRSFootnote4.HyperLink = Nothing
			Me.lblRSFootnote4.Left = 0.0625F
			Me.lblRSFootnote4.Name = "lblRSFootnote4"
			Me.lblRSFootnote4.Style = "font-family: Microsoft Sans Serif; font-size: 7.8pt; text-align: left; white-space: nowrap"
			Me.lblRSFootnote4.Text = "Rod string trailer"
			Me.lblRSFootnote4.Top = 7.0625F
			Me.lblRSFootnote4.Visible = False
			Me.lblRSFootnote4.Width = 7.75F
			Me.lblRSFootnote3.Height = 0.15F
			Me.lblRSFootnote3.HyperLink = Nothing
			Me.lblRSFootnote3.Left = 0.0625F
			Me.lblRSFootnote3.Name = "lblRSFootnote3"
			Me.lblRSFootnote3.Style = "font-family: MS Sans Serif; font-size: 7.8pt; text-align: left; white-space: nowrap"
			Me.lblRSFootnote3.Text = "Rod string trailer"
			Me.lblRSFootnote3.Top = 6.9375F
			Me.lblRSFootnote3.Visible = False
			Me.lblRSFootnote3.Width = 7.75F
			Me.lblRSFootnote1.Height = 0.15F
			Me.lblRSFootnote1.HyperLink = Nothing
			Me.lblRSFootnote1.Left = 0.0625F
			Me.lblRSFootnote1.Name = "lblRSFootnote1"
			Me.lblRSFootnote1.Style = "font-family: MS Sans Serif; font-size: 7.8pt; text-align: left; white-space: nowrap"
			Me.lblRSFootnote1.Text = "Rod string trailer"
			Me.lblRSFootnote1.Top = 6.6875F
			Me.lblRSFootnote1.Visible = False
			Me.lblRSFootnote1.Width = 7.75F
			Me.Line13.Height = 0F
			Me.Line13.Left = 0.125F
			Me.Line13.LineWeight = 1F
			Me.Line13.Name = "Line13"
			Me.Line13.Top = 4.9375F
			Me.Line13.Width = 7.25F
			Me.Line13.X1 = 0.125F
			Me.Line13.X2 = 7.375F
			Me.Line13.Y1 = 4.9375F
			Me.Line13.Y2 = 4.9375F
			Me.Line14.Height = 0F
			Me.Line14.Left = 0.3125F
			Me.Line14.LineWeight = 1F
			Me.Line14.Name = "Line14"
			Me.Line14.Top = 5.3125F
			Me.Line14.Width = 6.8125F
			Me.Line14.X1 = 0.3125F
			Me.Line14.X2 = 7.125F
			Me.Line14.Y1 = 5.3125F
			Me.Line14.Y2 = 5.3125F
			Me.Line3.Height = 0F
			Me.Line3.Left = 0.0625F
			Me.Line3.LineWeight = 1F
			Me.Line3.Name = "Line3"
			Me.Line3.Top = 0.2325001F
			Me.Line3.Width = 7.938F
			Me.Line3.X1 = 0.0625F
			Me.Line3.X2 = 8.0005F
			Me.Line3.Y1 = 0.2325001F
			Me.Line3.Y2 = 0.2325001F
			Me.Line1.Height = 0F
			Me.Line1.Left = 0.0625F
			Me.Line1.LineWeight = 3F
			Me.Line1.Name = "Line1"
			Me.Line1.Top = 0.03F
			Me.Line1.Width = 7.938F
			Me.Line1.X1 = 0.0625F
			Me.Line1.X2 = 8.0005F
			Me.Line1.Y1 = 0.03F
			Me.Line1.Y2 = 0.03F
			Me.picTorquePlot.BackColor = Color.FromArgb(255, 255, 255)
			Me.picTorquePlot.Height = 2.3125F
			Me.picTorquePlot.ImageData = Nothing
			Me.picTorquePlot.Left = 4.125F
			Me.picTorquePlot.LineColor = Color.FromArgb(255, 255, 255)
			Me.picTorquePlot.Name = "picTorquePlot"
			Me.picTorquePlot.SizeMode = SizeModes.Stretch
			Me.picTorquePlot.Top = 7.4375F
			Me.picTorquePlot.Width = 3.625F
			Me.picDyno.BackColor = Color.FromArgb(255, 255, 255)
			Me.picDyno.Height = 2.3125F
			Me.picDyno.ImageData = Nothing
			Me.picDyno.Left = 0.3125F
			Me.picDyno.LineColor = Color.FromArgb(255, 255, 255)
			Me.picDyno.Name = "picDyno"
			Me.picDyno.SizeMode = SizeModes.Stretch
			Me.picDyno.Top = 7.4375F
			Me.picDyno.Width = 3.625F
			Me.lblNoResults.Height = 0.145F
			Me.lblNoResults.HyperLink = Nothing
			Me.lblNoResults.Left = 2.125F
			Me.lblNoResults.Name = "lblNoResults"
			Me.lblNoResults.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblNoResults.Text = "The calculations have not been run for this case."
			Me.lblNoResults.Top = 0.25F
			Me.lblNoResults.Width = 3.625F
			Me.lblBPDSurface.Height = 0.145F
			Me.lblBPDSurface.HyperLink = Nothing
			Me.lblBPDSurface.Left = 0.125F
			Me.lblBPDSurface.Name = "lblBPDSurface"
			Me.lblBPDSurface.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblBPDSurface.Text = "Production rate"
			Me.lblBPDSurface.Top = 0.25F
			Me.lblBPDSurface.Width = 2.625F
			Me.lblPRHP.Height = 0.145F
			Me.lblPRHP.HyperLink = Nothing
			Me.lblPRHP.Left = 0.1255002F
			Me.lblPRHP.Name = "lblPRHP"
			Me.lblPRHP.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblPRHP.Text = "Polished rod HP"
			Me.lblPRHP.Top = 1.125F
			Me.lblPRHP.Width = 2.6245F
			Me.lblNoverNo.Height = 0.145F
			Me.lblNoverNo.HyperLink = Nothing
			Me.lblNoverNo.Left = 3.688F
			Me.lblNoverNo.Name = "lblNoverNo"
			Me.lblNoverNo.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblNoverNo.Text = "N/No', Fo/SKr"
			Me.lblNoverNo.Top = 1F
			Me.lblNoverNo.Width = 2.6245F
			Me.txtPRHP.Height = 0.145F
			Me.txtPRHP.HyperLink = Nothing
			Me.txtPRHP.Left = 2.8125F
			Me.txtPRHP.Name = "txtPRHP"
			Me.txtPRHP.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtPRHP.Text = ""
			Me.txtPRHP.Top = 1.125F
			Me.txtPRHP.Width = 0.5625F
			Me.txtStructLoading.Height = 0.145F
			Me.txtStructLoading.HyperLink = Nothing
			Me.txtStructLoading.Left = 6.375F
			Me.txtStructLoading.Name = "txtStructLoading"
			Me.txtStructLoading.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtStructLoading.Text = ""
			Me.txtStructLoading.Top = 0.625F
			Me.txtStructLoading.Width = 0.5625F
			Me.txtRodWeight.Height = 0.145F
			Me.txtRodWeight.HyperLink = Nothing
			Me.txtRodWeight.Left = 6.375F
			Me.txtRodWeight.Name = "txtRodWeight"
			Me.txtRodWeight.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtRodWeight.Text = " "
			Me.txtRodWeight.Top = 0.875F
			Me.txtRodWeight.Width = 0.5625F
			Me.txtPPRL.Height = 0.145F
			Me.txtPPRL.HyperLink = Nothing
			Me.txtPPRL.Left = 6.375F
			Me.txtPPRL.Name = "txtPPRL"
			Me.txtPPRL.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtPPRL.Text = " "
			Me.txtPPRL.Top = 0.25F
			Me.txtPPRL.Width = 0.5625F
			Me.txtMPRL.Height = 0.145F
			Me.txtMPRL.HyperLink = Nothing
			Me.txtMPRL.Left = 6.375F
			Me.txtMPRL.Name = "txtMPRL"
			Me.txtMPRL.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtMPRL.Text = " "
			Me.txtMPRL.Top = 0.375F
			Me.txtMPRL.Width = 0.5625F
			Me.lblFluidLevelTVD.Height = 0.145F
			Me.lblFluidLevelTVD.HyperLink = Nothing
			Me.lblFluidLevelTVD.Left = 0.125F
			Me.lblFluidLevelTVD.Name = "lblFluidLevelTVD"
			Me.lblFluidLevelTVD.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblFluidLevelTVD.Text = "TVD Fluid level"
			Me.lblFluidLevelTVD.Top = 1F
			Me.lblFluidLevelTVD.Width = 2.625F
			Me.txtPrhpPlhp.Height = 0.145F
			Me.txtPrhpPlhp.HyperLink = Nothing
			Me.txtPrhpPlhp.Left = 6.375F
			Me.txtPrhpPlhp.Name = "txtPrhpPlhp"
			Me.txtPrhpPlhp.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtPrhpPlhp.Text = ""
			Me.txtPrhpPlhp.Top = 0.75F
			Me.txtPrhpPlhp.Width = 0.5625F
			Me.lblPrhpPlhp.Height = 0.145F
			Me.lblPrhpPlhp.HyperLink = Nothing
			Me.lblPrhpPlhp.Left = 3.688F
			Me.lblPrhpPlhp.Name = "lblPrhpPlhp"
			Me.lblPrhpPlhp.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblPrhpPlhp.Text = "PRHP / PLHP"
			Me.lblPrhpPlhp.Top = 0.75F
			Me.lblPrhpPlhp.Width = 2.6245F
			Me.lblPermLoadHP.Height = 0.145F
			Me.lblPermLoadHP.HyperLink = Nothing
			Me.lblPermLoadHP.Left = 0.125F
			Me.lblPermLoadHP.Name = "lblPermLoadHP"
			Me.lblPermLoadHP.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblPermLoadHP.Text = "Permissible Load HP"
			Me.lblPermLoadHP.Top = 0.75F
			Me.lblPermLoadHP.Width = 2.625F
			Me.txtBPDSurface.Height = 0.145F
			Me.txtBPDSurface.HyperLink = Nothing
			Me.txtBPDSurface.Left = 2.813F
			Me.txtBPDSurface.Name = "txtBPDSurface"
			Me.txtBPDSurface.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtBPDSurface.Text = " "
			Me.txtBPDSurface.Top = 0.25F
			Me.txtBPDSurface.Width = 0.5625F
			Me.txtPermLoadHP.Height = 0.145F
			Me.txtPermLoadHP.HyperLink = Nothing
			Me.txtPermLoadHP.Left = 2.813F
			Me.txtPermLoadHP.Name = "txtPermLoadHP"
			Me.txtPermLoadHP.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtPermLoadHP.Text = " "
			Me.txtPermLoadHP.Top = 0.75F
			Me.txtPermLoadHP.Width = 0.5625F
			Me.txtFluidLevelTVD.Height = 0.145F
			Me.txtFluidLevelTVD.HyperLink = Nothing
			Me.txtFluidLevelTVD.Left = 2.813F
			Me.txtFluidLevelTVD.Name = "txtFluidLevelTVD"
			Me.txtFluidLevelTVD.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtFluidLevelTVD.Text = " "
			Me.txtFluidLevelTVD.Top = 1F
			Me.txtFluidLevelTVD.Width = 0.5625F
			Me.txtSystemEff.Height = 0.145F
			Me.txtSystemEff.HyperLink = Nothing
			Me.txtSystemEff.Left = 2.813F
			Me.txtSystemEff.Name = "txtSystemEff"
			Me.txtSystemEff.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtSystemEff.Text = " "
			Me.txtSystemEff.Top = 0.625F
			Me.txtSystemEff.Width = 0.5625F
			Me.txtFluidLoad.Height = 0.145F
			Me.txtFluidLoad.HyperLink = Nothing
			Me.txtFluidLoad.Left = 2.813F
			Me.txtFluidLoad.Name = "txtFluidLoad"
			Me.txtFluidLoad.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtFluidLoad.Text = " "
			Me.txtFluidLoad.Top = 0.875F
			Me.txtFluidLoad.Width = 0.5625F
			Me.txtCalcSPM.Height = 0.145F
			Me.txtCalcSPM.HyperLink = Nothing
			Me.txtCalcSPM.Left = 2.813F
			Me.txtCalcSPM.Name = "txtCalcSPM"
			Me.txtCalcSPM.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtCalcSPM.Text = ""
			Me.txtCalcSPM.Top = 0.5F
			Me.txtCalcSPM.Width = 0.5625F
			Me.txtOilProduction.Height = 0.145F
			Me.txtOilProduction.HyperLink = Nothing
			Me.txtOilProduction.Left = 2.813F
			Me.txtOilProduction.Name = "txtOilProduction"
			Me.txtOilProduction.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtOilProduction.Text = ""
			Me.txtOilProduction.Top = 0.375F
			Me.txtOilProduction.Width = 0.5625F
			Me.lblRodWeight.Height = 0.145F
			Me.lblRodWeight.HyperLink = Nothing
			Me.lblRodWeight.Left = 3.688F
			Me.lblRodWeight.Name = "lblRodWeight"
			Me.lblRodWeight.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblRodWeight.Text = "Buoyant rod weight"
			Me.lblRodWeight.Top = 0.875F
			Me.lblRodWeight.Width = 2.6245F
			Me.lblStructLoading.Height = 0.145F
			Me.lblStructLoading.HyperLink = Nothing
			Me.lblStructLoading.Left = 3.688F
			Me.lblStructLoading.Name = "lblStructLoading"
			Me.lblStructLoading.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblStructLoading.Text = "Structural loading"
			Me.lblStructLoading.Top = 0.625F
			Me.lblStructLoading.Width = 2.6245F
			Me.lblMPRL.Height = 0.145F
			Me.lblMPRL.HyperLink = Nothing
			Me.lblMPRL.Left = 3.688F
			Me.lblMPRL.Name = "lblMPRL"
			Me.lblMPRL.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMPRL.Text = "Min. polished rod load"
			Me.lblMPRL.Top = 0.375F
			Me.lblMPRL.Width = 2.6245F
			Me.lblPPRL.Height = 0.145F
			Me.lblPPRL.HyperLink = Nothing
			Me.lblPPRL.Left = 3.688F
			Me.lblPPRL.Name = "lblPPRL"
			Me.lblPPRL.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblPPRL.Text = "Peak polished rod load"
			Me.lblPPRL.Top = 0.25F
			Me.lblPPRL.Width = 2.6245F
			Me.lblFluidLoad.Height = 0.145F
			Me.lblFluidLoad.HyperLink = Nothing
			Me.lblFluidLoad.Left = 0.125F
			Me.lblFluidLoad.Name = "lblFluidLoad"
			Me.lblFluidLoad.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblFluidLoad.Text = "Fluid load"
			Me.lblFluidLoad.Top = 0.875F
			Me.lblFluidLoad.Width = 2.625F
			Me.lblSystemEff.Height = 0.145F
			Me.lblSystemEff.HyperLink = Nothing
			Me.lblSystemEff.Left = 0.125F
			Me.lblSystemEff.Name = "lblSystemEff"
			Me.lblSystemEff.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblSystemEff.Text = "System efficiency"
			Me.lblSystemEff.Top = 0.625F
			Me.lblSystemEff.Width = 2.625F
			Me.lblCalcSPM.Height = 0.145F
			Me.lblCalcSPM.HyperLink = Nothing
			Me.lblCalcSPM.Left = 0.125F
			Me.lblCalcSPM.Name = "lblCalcSPM"
			Me.lblCalcSPM.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblCalcSPM.Text = "Pumping speed"
			Me.lblCalcSPM.Top = 0.5F
			Me.lblCalcSPM.Width = 2.625F
			Me.lblOilProduction.Height = 0.145F
			Me.lblOilProduction.HyperLink = Nothing
			Me.lblOilProduction.Left = 0.125F
			Me.lblOilProduction.Name = "lblOilProduction"
			Me.lblOilProduction.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblOilProduction.Text = "Oil production"
			Me.lblOilProduction.Top = 0.375F
			Me.lblOilProduction.Width = 2.625F
			Me.lblMCM.Height = 0.145F
			Me.lblMCM.HyperLink = Nothing
			Me.lblMCM.Left = 0.125F
			Me.lblMCM.Name = "lblMCM"
			Me.lblMCM.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblMCM.Text = "Max CB moment"
			Me.lblMCM.Top = 2.875F
			Me.lblMCM.Width = 2.625F
			Me.lblCLF.Height = 0.145F
			Me.lblCLF.HyperLink = Nothing
			Me.lblCLF.Left = 0.125F
			Me.lblCLF.Name = "lblCLF"
			Me.lblCLF.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCLF.Text = "Cyclic load factor:"
			Me.lblCLF.Top = 2.75F
			Me.lblCLF.Width = 2.625F
			Me.lblMPRLPPRL.Height = 0.145F
			Me.lblMPRLPPRL.HyperLink = Nothing
			Me.lblMPRLPPRL.Left = 3.688F
			Me.lblMPRLPPRL.Name = "lblMPRLPPRL"
			Me.lblMPRLPPRL.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMPRLPPRL.Text = "MPRL/PPRL"
			Me.lblMPRLPPRL.Top = 0.5F
			Me.lblMPRLPPRL.Width = 2.6245F
			Me.txtMPRLPPRL.Height = 0.145F
			Me.txtMPRLPPRL.HyperLink = Nothing
			Me.txtMPRLPPRL.Left = 6.375F
			Me.txtMPRLPPRL.Name = "txtMPRLPPRL"
			Me.txtMPRLPPRL.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtMPRLPPRL.Text = ""
			Me.txtMPRLPPRL.Top = 0.5F
			Me.txtMPRLPPRL.Width = 0.5625F
			Me.GroupFooter1.Height = 0F
			Me.GroupFooter1.Name = "GroupFooter1"
			Me.MasterReport = False
			Me.PageSettings.Margins.Bottom = 0F
			Me.PageSettings.Margins.Left = 0F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0F
			Me.PageSettings.PaperHeight = 11F
			Me.PageSettings.PaperWidth = 8.5F
			Me.PrintWidth = 8.03125F
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
			CType(Me.lblMotorSPVHdr, ISupportInitialize).EndInit()
			CType(Me.lblMotorSPV, ISupportInitialize).EndInit()
			CType(Me.lblNEMAD, ISupportInitialize).EndInit()
			CType(Me.lblCBE, ISupportInitialize).EndInit()
			CType(Me.lblCalculatedResults, ISupportInitialize).EndInit()
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
			CType(Me.lblPlungerLength, ISupportInitialize).EndInit()
			CType(Me.lblPumpLength, ISupportInitialize).EndInit()
			CType(Me.lblPumpSpacing, ISupportInitialize).EndInit()
			CType(Me.lblGrossPumpStroke, ISupportInitialize).EndInit()
			CType(Me.lblProductionLoss, ISupportInitialize).EndInit()
			CType(Me.lblTubingStretch, ISupportInitialize).EndInit()
			CType(Me.lblDollarsPerBblOil, ISupportInitialize).EndInit()
			CType(Me.lblDollarsPerBblFluid, ISupportInitialize).EndInit()
			CType(Me.lblElectricBillPerMonth, ISupportInitialize).EndInit()
			CType(Me.lblGearboxLoading, ISupportInitialize).EndInit()
			CType(Me.lblTorqueAnalysis, ISupportInitialize).EndInit()
			CType(Me.lblSingleCyl, ISupportInitialize).EndInit()
			CType(Me.lblPeakTorque, ISupportInitialize).EndInit()
			CType(Me.lblMotorKWH, ISupportInitialize).EndInit()
			CType(Me.lblReqPrimeMoverSize, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStressHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStressHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethodHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStressHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodStressHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblPmBalancedT, ISupportInitialize).EndInit()
			CType(Me.lblTqBalancedT, ISupportInitialize).EndInit()
			CType(Me.lblTqBalancedE, ISupportInitialize).EndInit()
			CType(Me.txtPlungerLength, ISupportInitialize).EndInit()
			CType(Me.txtPumpLength, ISupportInitialize).EndInit()
			CType(Me.txtPumpSpacing, ISupportInitialize).EndInit()
			CType(Me.txtGrossPumpStroke, ISupportInitialize).EndInit()
			CType(Me.txtProductionLoss, ISupportInitialize).EndInit()
			CType(Me.txtTubingStretch, ISupportInitialize).EndInit()
			CType(Me.lblPmBalancedE, ISupportInitialize).EndInit()
			CType(Me.lblRodStress9, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress9, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress9, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress9, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod9, ISupportInitialize).EndInit()
			CType(Me.lblRodStress10, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMaxStress10, ISupportInitialize).EndInit()
			CType(Me.lblRodTopMinStress10, ISupportInitialize).EndInit()
			CType(Me.lblRodBotMinStress10, ISupportInitialize).EndInit()
			CType(Me.lblRodStressMethod10, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote2, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote5, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote4, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote3, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote1, ISupportInitialize).EndInit()
			CType(Me.picTorquePlot, ISupportInitialize).EndInit()
			CType(Me.picDyno, ISupportInitialize).EndInit()
			CType(Me.lblNoResults, ISupportInitialize).EndInit()
			CType(Me.lblBPDSurface, ISupportInitialize).EndInit()
			CType(Me.lblPRHP, ISupportInitialize).EndInit()
			CType(Me.lblNoverNo, ISupportInitialize).EndInit()
			CType(Me.txtPRHP, ISupportInitialize).EndInit()
			CType(Me.txtStructLoading, ISupportInitialize).EndInit()
			CType(Me.txtRodWeight, ISupportInitialize).EndInit()
			CType(Me.txtPPRL, ISupportInitialize).EndInit()
			CType(Me.txtMPRL, ISupportInitialize).EndInit()
			CType(Me.lblFluidLevelTVD, ISupportInitialize).EndInit()
			CType(Me.txtPrhpPlhp, ISupportInitialize).EndInit()
			CType(Me.lblPrhpPlhp, ISupportInitialize).EndInit()
			CType(Me.lblPermLoadHP, ISupportInitialize).EndInit()
			CType(Me.txtBPDSurface, ISupportInitialize).EndInit()
			CType(Me.txtPermLoadHP, ISupportInitialize).EndInit()
			CType(Me.txtFluidLevelTVD, ISupportInitialize).EndInit()
			CType(Me.txtSystemEff, ISupportInitialize).EndInit()
			CType(Me.txtFluidLoad, ISupportInitialize).EndInit()
			CType(Me.txtCalcSPM, ISupportInitialize).EndInit()
			CType(Me.txtOilProduction, ISupportInitialize).EndInit()
			CType(Me.lblRodWeight, ISupportInitialize).EndInit()
			CType(Me.lblStructLoading, ISupportInitialize).EndInit()
			CType(Me.lblMPRL, ISupportInitialize).EndInit()
			CType(Me.lblPPRL, ISupportInitialize).EndInit()
			CType(Me.lblFluidLoad, ISupportInitialize).EndInit()
			CType(Me.lblSystemEff, ISupportInitialize).EndInit()
			CType(Me.lblCalcSPM, ISupportInitialize).EndInit()
			CType(Me.lblOilProduction, ISupportInitialize).EndInit()
			CType(Me.lblMCM, ISupportInitialize).EndInit()
			CType(Me.lblCLF, ISupportInitialize).EndInit()
			CType(Me.lblMPRLPPRL, ISupportInitialize).EndInit()
			CType(Me.txtMPRLPPRL, ISupportInitialize).EndInit()
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

		Public Property bPrint As Boolean
			Get
				Return Me.m_bPrint
			End Get
			Set(value As Boolean)
				Me.m_bPrint = value
			End Set
		End Property

		Public Sub rptResultsOutputs_ReportStart(sender As Object, e As EventArgs)
			Me.printFont = New Font("Arial", 10F)
			If Not Me.m_bPrint Then
				Me.PageSettings.Margins.Left = 0.25F
				Me.PageSettings.Margins.Right = 0F
				If RSWIN_DESC.rst.NumRods < 40S Then
					Me.PageSettings.Margins.Top = 0.25F
				Else
					Me.PageSettings.Margins.Top = 0.05F
				End If
				Me.PageSettings.Margins.Bottom = 0F
			Else
				Me.PageSettings.Margins.Left = 0.25F
				Me.PageSettings.Margins.Right = 0F
				If RSWIN_DESC.rst.NumRods < 40S Then
					Me.PageSettings.Margins.Top = 0.25F
				Else
					Me.PageSettings.Margins.Top = 0.05F
				End If
				Me.PageSettings.Margins.Bottom = 0F
			End If
			Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
			Me.ShowCalculations()
			Me.ShowPrimeMoverSize()
			Me.ShowTorqueAnalysis()
			Me.ShowTubingCalc()
			Me.ShowRSCalc()
			Me.showRSTrailer()
			If Not Me.picDyno.Visible Then
				Me.picDyno.Visible = True
			End If
			If RSWIN_DESC.rst.PU.UnitType <> 10S Then
				Me.picTorquePlot.Visible = True
			Else
				Me.picTorquePlot.Visible = False
			End If
			Me.picDyno.Top = Me.m_LastTop + Me.m_LastHeight * 2F
			Me.picTorquePlot.Top = Me.picDyno.Top
			If RSWIN_DESC.bIntVersion Then
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter("rptResultsOutputs")
					Me.WriteControlStrings()
					Util.CloseResourceWriter()
				End If
				If RSWIN_DESC.bReadResXFile Then
					Me.ReadReportControlStrings()
				End If
				Return
			End If
		End Sub

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
			sPrefix = "rptResultsOutputs-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
			Try
				Dim num11 As Integer = 0
				Dim num12 As Integer = Me.PageHeader.Controls.Count - 1
				For i As Integer = num11 To num12
					Try
						If Me.PageHeader.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.PageHeader.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex7 As Exception
					End Try
				Next
				Dim num13 As Integer = 0
				Dim num14 As Integer = Me.PageFooter.Controls.Count - 1
				For i As Integer = num13 To num14
					Try
						If Me.PageFooter.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.PageFooter.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex8 As Exception
					End Try
				Next
				Dim num15 As Integer = 0
				Dim num16 As Integer = Me.GroupHeader1.Controls.Count - 1
				For i As Integer = num15 To num16
					Try
						If Me.GroupHeader1.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.GroupHeader1.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex9 As Exception
					End Try
				Next
				Dim num17 As Integer = 0
				Dim num18 As Integer = Me.GroupFooter1.Controls.Count - 1
				For i As Integer = num17 To num18
					Try
						If Me.GroupFooter1.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.GroupFooter1.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex10 As Exception
					End Try
				Next
				Dim num19 As Integer = 0
				Dim num20 As Integer = Me.Detail.Controls.Count - 1
				For i As Integer = num19 To num20
					Try
						If Me.Detail.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.Detail.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex11 As Exception
					End Try
				Next
			Catch ex12 As Exception
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
			Me.lblLabel2.Text = Me.sThetaEnterprises
			Me.lblPage.Text = Me.sPage
			Me.lblOf.Text = Me.sOf
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

		Private Sub Detail_Format(sender As Object, e As EventArgs)
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
				label.Text = Me.MkSummEM(w, Me.sProductionRate, bpdsurface, bpd__M3D, RSWIN_DESC.bfpd, text2, RSWIN_DESC.m3D, text3, 3, True, False)
				Dim label2 As DataDynamics.ActiveReports.Label = Me.txtBPDSurface
				Dim w2 As Object = 0
				text3 = ""
				Dim bpdsurface2 As Single = RSWIN_DESC.rst.BPDsurface
				Dim bpd__M3D2 As Single = RSWIN_DESC.BPD__M3D
				text2 = "0"
				Dim text4 As String = "#.#"
				label2.Text = Me.MkSummEM(w2, text3, bpdsurface2, bpd__M3D2, RSWIN_DESC.bfpd, text2, RSWIN_DESC.m3D, text4, 3, False, True)
				Dim label3 As DataDynamics.ActiveReports.Label = Me.lblCalcSPM
				Dim w3 As Object = 25
				Dim spm As Single = RSWIN_DESC.rst.SPM
				text4 = "#.#"
				label3.Text = Me.MkSumm(w3, Me.sStrokesPerMinute, spm, text4, True, False)
				Dim label4 As DataDynamics.ActiveReports.Label = Me.txtCalcSPM
				Dim w4 As Object = 0
				text4 = ""
				Dim spm2 As Single = RSWIN_DESC.rst.SPM
				text3 = "#.#"
				label4.Text = Me.MkSumm(w4, text4, spm2, text3, False, True)
				Dim label5 As DataDynamics.ActiveReports.Label = Me.lblFluidLoad
				Dim w5 As Object = 31
				Dim fluidLoad As Single = RSWIN_DESC.rst.FluidLoad
				Dim lb__N As Single = RSWIN_DESC.LB__N
				text4 = "0"
				text3 = "0"
				label5.Text = Me.MkSummEM(w5, Me.sFluidLoadOnPump, fluidLoad, lb__N, RSWIN_DESC.lbs, text4, RSWIN_DESC.N, text3, 1, True, False)
				Dim label6 As DataDynamics.ActiveReports.Label = Me.txtFluidLoad
				Dim w6 As Object = 0
				text4 = ""
				Dim fluidLoad2 As Single = RSWIN_DESC.rst.FluidLoad
				Dim lb__N2 As Single = RSWIN_DESC.LB__N
				text3 = "0"
				text2 = "0"
				label6.Text = Me.MkSummEM(w6, text4, fluidLoad2, lb__N2, RSWIN_DESC.lbs, text3, RSWIN_DESC.N, text2, 1, False, True)
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
						label7.Text = Me.MkSummEM(w7, Me.sFluidLevelTVD, fluidLevelTVD, ft__M, text4, text3, text2, text5, 3, True, False)
						Dim label8 As DataDynamics.ActiveReports.Label = Me.txtFluidLevelTVD
						Dim w8 As Object = 0
						text5 = ""
						Dim fluidLevelTVD2 As Single = RSWIN_DESC.rst.FluidLevelTVD
						Dim ft__M2 As Single = RSWIN_DESC.FT__M
						text4 = RSWIN_DESC.ft + " from surface"
						text3 = "0"
						text2 = "m from surface"
						text6 = "#.#"
						label8.Text = Me.MkSummEM(w8, text5, fluidLevelTVD2, ft__M2, text4, text3, text2, text6, 3, False, True)
					Else
						Dim label9 As DataDynamics.ActiveReports.Label = Me.lblFluidLevelTVD
						Dim w9 As Object = 37
						Dim fluidLevel As Single = RSWIN_DESC.rst.FluidLevel
						Dim ft__M3 As Single = RSWIN_DESC.FT__M
						text6 = RSWIN_DESC.ft + " from surface"
						text5 = "0"
						text4 = "m from surface"
						text3 = "#.#"
						label9.Text = Me.MkSummEM(w9, Me.sFluidLevelTVD, fluidLevel, ft__M3, text6, text5, text4, text3, 3, True, False)
						Dim label10 As DataDynamics.ActiveReports.Label = Me.txtFluidLevelTVD
						Dim w10 As Object = 0
						text6 = ""
						Dim fluidLevel2 As Single = RSWIN_DESC.rst.FluidLevel
						Dim ft__M4 As Single = RSWIN_DESC.FT__M
						text5 = RSWIN_DESC.ft + " from surface"
						text4 = "0"
						text3 = "m from surface"
						text2 = "#.#"
						label10.Text = Me.MkSummEM(w10, text6, fluidLevel2, ft__M4, text5, text4, text3, text2, 3, False, True)
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
				label11.Text = Me.MkSummEM(w11, Me.sMinPolRodLoad, mprload, lb__N3, RSWIN_DESC.lbs, text6, RSWIN_DESC.N, text5, 1, True, False)
				Dim label12 As DataDynamics.ActiveReports.Label = Me.lblNoverNo
				Dim str As String = "N/No:   "
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim noverNoP As Single = rst.NoverNoP
				text5 = "##.###"
				Dim str2 As String = Util.Format(noverNoP, text5)
				rst.NoverNoP = noverNoP
				Dim str3 As String = "   ,   Fo/SKr:   "
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
				label13.Text = Me.MkSummEM(w12, Me.sOilProduction, v, bpd__M3D3, text6, text5, RSWIN_DESC.m3D, text4, 3, True, False)
				Dim label14 As DataDynamics.ActiveReports.Label = Me.lblPPRL
				Dim w13 As Object = 31
				Dim pprload As Single = RSWIN_DESC.rst.Pprload
				Dim lb__N4 As Single = RSWIN_DESC.LB__N
				text6 = "0"
				text5 = "0"
				label14.Text = Me.MkSummEM(w13, Me.aPeakPolRodLoad, pprload, lb__N4, RSWIN_DESC.lbs, text6, RSWIN_DESC.N, text5, 1, True, False)
				Dim label15 As DataDynamics.ActiveReports.Label = Me.txtMPRL
				Dim w14 As Object = 0
				text6 = ""
				Dim mprload2 As Single = RSWIN_DESC.rst.Mprload
				Dim lb__N5 As Single = RSWIN_DESC.LB__N
				text5 = "0"
				text4 = "0"
				label15.Text = Me.MkSummEM(w14, text6, mprload2, lb__N5, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text4, 1, False, True)
				Dim label16 As DataDynamics.ActiveReports.Label = Me.txtOilProduction
				Dim w15 As Object = 0
				text6 = ""
				Dim v2 As Single = RSWIN_DESC.rst.BPDsurface * (1F - RSWIN_DESC.rst.WaterCut / 100F)
				Dim bpd__M3D4 As Single = RSWIN_DESC.BPD__M3D
				text5 = "BOPD"
				text4 = "0"
				text3 = "#.#"
				label16.Text = Me.MkSummEM(w15, text6, v2, bpd__M3D4, text5, text4, RSWIN_DESC.m3D, text3, 3, False, True)
				Dim label17 As DataDynamics.ActiveReports.Label = Me.txtPPRL
				Dim w16 As Object = 0
				text6 = ""
				Dim pprload2 As Single = RSWIN_DESC.rst.Pprload
				Dim lb__N6 As Single = RSWIN_DESC.LB__N
				text5 = "0"
				text4 = "0"
				label17.Text = Me.MkSummEM(w16, text6, pprload2, lb__N6, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text4, 1, False, True)
				If RSWIN_DESC.rst.Pprload <> 0F Then
					Dim label18 As DataDynamics.ActiveReports.Label = Me.txtMPRLPPRL
					Dim w17 As Object = 0
					text6 = ""
					Dim value As Single = RSWIN_DESC.rst.Mprload / RSWIN_DESC.rst.Pprload
					text5 = "#0.###"
					label18.Text = Me.MkSumm(w17, text6, value, text5, False, True)
				Else
					Dim label19 As DataDynamics.ActiveReports.Label = Me.txtMPRLPPRL
					Dim w18 As Object = 0
					text6 = ""
					Dim value2 As Single = 0F
					text5 = "0.0"
					label19.Text = Me.MkSumm(w18, text6, value2, text5, False, True)
				End If
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					Dim label20 As DataDynamics.ActiveReports.Label = Me.lblPRHP
					Dim w19 As Object = 25
					Dim value3 As Single = CSng((CDbl(RSWIN_DESC.rst.Prhp) * 0.746))
					text6 = "#.#"
					label20.Text = Me.MkSumm(w19, Me.sPolRodPowerKW, value3, text6, True, False)
					Dim label21 As DataDynamics.ActiveReports.Label = Me.txtPRHP
					Dim w20 As Object = 0
					text6 = ""
					Dim value4 As Single = CSng((CDbl(RSWIN_DESC.rst.Prhp) * 0.746))
					text5 = "#.#"
					label21.Text = Me.MkSumm(w20, text6, value4, text5, False, True)
				Else
					Dim label22 As DataDynamics.ActiveReports.Label = Me.lblPRHP
					Dim w21 As Object = 25
					Dim prhp As Single = RSWIN_DESC.rst.Prhp
					text6 = "#.#"
					label22.Text = Me.MkSumm(w21, Me.sPolishedRodHP, prhp, text6, True, False)
					Dim label23 As DataDynamics.ActiveReports.Label = Me.txtPRHP
					Dim w22 As Object = 0
					text6 = ""
					Dim prhp2 As Single = RSWIN_DESC.rst.Prhp
					text5 = "#.#"
					label23.Text = Me.MkSumm(w22, text6, prhp2, text5, False, True)
				End If
				If RSWIN_DESC.rst.Plhp <> 0F Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						Dim label24 As DataDynamics.ActiveReports.Label = Me.lblPermLoadHP
						Dim w23 As Object = 25
						Dim value5 As Single = CSng((CDbl(RSWIN_DESC.rst.Plhp) * 0.746))
						text6 = "#.#"
						label24.Text = Me.MkSumm(w23, Me.sPermissibleLoadPowerKW, value5, text6, True, False)
						Dim label25 As DataDynamics.ActiveReports.Label = Me.txtPermLoadHP
						Dim w24 As Object = 0
						text6 = ""
						Dim value6 As Single = CSng((CDbl(RSWIN_DESC.rst.Plhp) * 0.746))
						text5 = "#.#"
						label25.Text = Me.MkSumm(w24, text6, value6, text5, False, True)
					Else
						Dim label26 As DataDynamics.ActiveReports.Label = Me.lblPermLoadHP
						Dim w25 As Object = 25
						Dim plhp As Single = RSWIN_DESC.rst.Plhp
						text6 = "#.#"
						label26.Text = Me.MkSumm(w25, Me.sPermissibleLoadHP, plhp, text6, True, False)
						Dim label27 As DataDynamics.ActiveReports.Label = Me.txtPermLoadHP
						Dim w26 As Object = 0
						text6 = ""
						Dim plhp2 As Single = RSWIN_DESC.rst.Plhp
						text5 = "#.#"
						label27.Text = Me.MkSumm(w26, text6, plhp2, text5, False, True)
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
				label28.Text = Me.MkSummEM(w27, Me.sBuoyantRodWeight, wrodsInFluid, lb__N7, RSWIN_DESC.lbs, text6, RSWIN_DESC.N, text5, 1, True, False)
				Dim label29 As DataDynamics.ActiveReports.Label = Me.lblStructLoading
				Dim w28 As Object = 31
				Dim structL As Single = RSWIN_DESC.rst.StructL
				text6 = "###%"
				label29.Text = Me.MkSumm(w28, Me.sUnitStructLoading, structL, text6, True, False)
				Dim label30 As DataDynamics.ActiveReports.Label = Me.lblSystemEff
				Dim w29 As Object = 31
				Dim systemEff As Single = RSWIN_DESC.rst.SystemEff
				text6 = "###%"
				label30.Text = Me.MkSumm(w29, Me.sSystemEffMotorPump, systemEff, text6, True, False)
				Dim label31 As DataDynamics.ActiveReports.Label = Me.txtRodWeight
				Dim w30 As Object = 0
				text6 = ""
				Dim wrodsInFluid2 As Single = RSWIN_DESC.rst.WrodsInFluid
				Dim lb__N8 As Single = RSWIN_DESC.LB__N
				text5 = "0"
				text4 = "0"
				label31.Text = Me.MkSummEM(w30, text6, wrodsInFluid2, lb__N8, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text4, 1, False, True)
				Dim label32 As DataDynamics.ActiveReports.Label = Me.txtStructLoading
				Dim w31 As Object = 0
				text6 = ""
				Dim structL2 As Single = RSWIN_DESC.rst.StructL
				text5 = "###%"
				label32.Text = Me.MkSumm(w31, text6, structL2, text5, False, True)
				Util.SetLabelColor(RSWIN_DESC.rst.StructL, Me.txtStructLoading, "###%")
				Dim label33 As DataDynamics.ActiveReports.Label = Me.txtSystemEff
				Dim w32 As Object = 0
				text6 = ""
				Dim systemEff2 As Single = RSWIN_DESC.rst.SystemEff
				text5 = "###%"
				label33.Text = Me.MkSumm(w32, text6, systemEff2, text5, False, True)
				Util.SetLabelColor(RSWIN_DESC.rst.SystemEff, Me.txtSystemEff, "###%")
			End If
		End Sub

		Private Sub SETTORQUELABELS()
			If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
				If RSWIN_DESC.rst.get_RequiredUnbalance(0) = RSWIN_DESC.rst.get_RequiredUnbalance(1) Or RSWIN_DESC.bBalancedEVarsOverwritten Then
					Me.SetfraTqBalancedEVisible(False)
					Me.SetfraTqBalancedTVisible(True, True)
				End If
			ElseIf RSWIN_DESC.rst.get_M(0) = RSWIN_DESC.rst.get_M(1) Or RSWIN_DESC.bBalancedEVarsOverwritten Then
				Me.SetfraTqBalancedEVisible(False)
				Me.SetfraTqBalancedTVisible(True, True)
			End If
			If(Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And RSWIN_DESC.rst.UnknownM) Or ((RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And RSWIN_DESC.rst.bUnknownUnbalance) Then
				Me.SetfraTqExistingVisible(False, False)
				If(RSWIN_DESC.rst.PU.UnitType <> 8S And RSWIN_DESC.rst.get_M(0) <> RSWIN_DESC.rst.get_M(1)) Or (RSWIN_DESC.rst.PU.UnitType = 8S And RSWIN_DESC.rst.get_RequiredUnbalance(0) <> RSWIN_DESC.rst.get_RequiredUnbalance(1)) Then
					Me.SetfraTqBalancedEVisible(True)
					Me.SetfraTqBalancedTVisible(True, False)
					Return
				End If
			Else
				Me.SetfraTqExistingVisible(True, True)
				Me.SetfraTqBalancedTVisible(False, False)
			End If
		End Sub

		Private Sub SetfraTqBalancedEVisible(bVal As Boolean)
			Me.lblTqBalancedE.Visible = bVal
			Me.lblTqMinEner.Visible = bVal
			Me.lblPeakTorque_BE.Visible = bVal
			Me.lblGearboxLoading_BE.Visible = bVal
			Me.lblCLF_BE.Visible = bVal
			Me.lblMCM_BE.Visible = bVal
			Me.lblCBE_BE.Visible = bVal
			Me.lblMotorKWH_BE.Visible = bVal
			Me.lblElectricBillPerMonth_BE.Visible = bVal
			Me.lblDollarsPerBblFluid_BE.Visible = bVal
			Me.lblDollarsPerBblOil_BE.Visible = bVal
		End Sub

		Private Sub SetfraTqBalancedTVisible(bVal As Boolean, Optional bLeft As Boolean = False)
			Me.lblTqBalancedT.Visible = bVal
			Me.lblTqMinTorq.Visible = bVal
			Me.lblPeakTorque_BT.Visible = bVal
			Me.lblGearboxLoading_BT.Visible = bVal
			Me.lblCLF_BT.Visible = bVal
			Me.lblMCM_BT.Visible = bVal
			Me.lblCBE_BT.Visible = bVal
			Me.lblMotorKWH_BT.Visible = bVal
			Me.lblElectricBillPerMonth_BT.Visible = bVal
			Me.lblDollarsPerBblFluid_BT.Visible = bVal
			Me.lblDollarsPerBblOil_BT.Visible = bVal
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

		Private Sub SetfraTqExistingVisible(bVal As Boolean, Optional bLeft As Boolean = False)
			Me.lblTqExisting.Visible = bVal
			Me.lblPeakTorque_E.Visible = bVal
			Me.lblGearboxLoading_E.Visible = bVal
			Me.lblCLF_E.Visible = bVal
			Me.lblMCM_E.Visible = bVal
			Me.lblCBE_E.Visible = bVal
			Me.lblMotorKWH_E.Visible = bVal
			Me.lblElectricBillPerMonth_E.Visible = bVal
			Me.lblDollarsPerBblFluid_E.Visible = bVal
			Me.lblDollarsPerBblOil_E.Visible = bVal
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

		Private Sub ShowPrimeMoverSize()
			If Not RSWIN_DESC.rst.gbOutputLoaded Then
				Me.lblReqPrimeMoverSize.Text = Me.sPrimeMoverSpeedVariation
				Me.lnPMSV.Visible = True
				Me.lblMotorSPVHdr.Visible = False
				Me.lblMotorSPV.Visible = False
				Me.SetfraPmBalancedEVisible(False)
				Me.SetfraPmBalancedTVisible(False, False)
				Me.SetfraPmExistingVisible(False, False)
				Me.lblNEMAD.Visible = False
				Me.lblMultiCyl.Visible = False
				Me.lblSingleCyl.Visible = False
				Me.Line8.Visible = False
			ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), RSWIN_DESC.rst.CalcMotorSize)) Then
				If RSWIN_DESC.rst.MotorSPV = 0F Then
					Me.lblMotorSPVHdr.Text = Me.sSpeedVarNotIncluded
				Else
					Me.lblMotorSPVHdr.Text = Util.FormatMessage("({0}speed var.: {10.0})", New Object() { RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.rst.CalcMotorSPV <> 0S, "calc. ", Nothing)), RSWIN_DESC.rst.MotorSPV })
				End If
				Me.lblMotorSPV.Visible = False
				Me.SETPMLABELS()
				Dim array As DataDynamics.ActiveReports.Label()
				Me.MakeArray(4, array, Me.lblNEMAD, Me.lblNEMAD_BE, Me.lblNEMAD_BT, Me.lblNEMAD_E, Nothing, Nothing)
				Dim rst As cRODSTAR
				Dim array2 As Single()
				Dim text2 As String
				If Operators.ConditionalCompareObjectEqual(Motor.GetMotorInfo(4), 7, False) Then
					rst = RSWIN_DESC.rst
					array2 = rst.HpNemaD
					Dim fEFactor As Single = 1F
					Dim fMFactor As Single = 1F
					Dim fEtoM As Single = 1F
					Dim text As String = "##0 \HP"
					Me.ShowBE(Me.sMarathonMotor, array2, fEFactor, fMFactor, fEtoM, text, True, array)
					rst.HpNemaD = array2
				ElseIf Operators.ConditionalCompareObjectEqual(Motor.GetMotorInfo(4), 8, False) Then
					rst = RSWIN_DESC.rst
					array2 = rst.HpNemaD
					Dim fEFactor2 As Single = 1F
					Dim fMFactor2 As Single = 1F
					Dim fEtoM2 As Single = 1F
					Dim text As String = "##0 \HP"
					Me.ShowBE(Me.sTatungMotor, array2, fEFactor2, fMFactor2, fEtoM2, text, True, array)
					rst.HpNemaD = array2
				ElseIf Operators.ConditionalCompareObjectGreater(Motor.GetMotorInfo(4), 8, False) Then
					Dim text As String = Me.GetMotorName(Conversions.ToInteger(Motor.GetMotorInfo(4)))
					rst = RSWIN_DESC.rst
					array2 = rst.HpNemaD
					Dim fEFactor3 As Single = 1F
					Dim fMFactor3 As Single = 1F
					Dim fEtoM3 As Single = 1F
					text2 = "##0 \HP"
					Me.ShowBE(text, array2, fEFactor3, fMFactor3, fEtoM3, text2, True, array)
					rst.HpNemaD = array2
				Else
					rst = RSWIN_DESC.rst
					array2 = rst.HpNemaD
					Dim fEFactor4 As Single = 1F
					Dim fMFactor4 As Single = 1F
					Dim fEtoM4 As Single = 1F
					text2 = "##0 \HP"
					Me.ShowBE(Me.sNEMADMotor, array2, fEFactor4, fMFactor4, fEtoM4, text2, True, array)
					rst.HpNemaD = array2
				End If
				Me.MakeArray(4, array, Me.lblSingleCyl, Me.lblSingleCyl_BE, Me.lblSingleCyl_BT, Me.lblSingleCyl_E, Nothing, Nothing)
				rst = RSWIN_DESC.rst
				array2 = rst.HpUhs
				Dim fEFactor5 As Single = 1F
				Dim fMFactor5 As Single = 1F
				Dim fEtoM5 As Single = 1F
				text2 = "##0 \HP"
				Me.ShowBE(Me.sSingleDoubleCylEngine, array2, fEFactor5, fMFactor5, fEtoM5, text2, True, array)
				rst.HpUhs = array2
				Me.MakeArray(4, array, Me.lblMultiCyl, Me.lblMultiCyl_BE, Me.lblMultiCyl_BT, Me.lblMultiCyl_E, Nothing, Nothing)
				rst = RSWIN_DESC.rst
				array2 = rst.HpNemaD
				Dim fEFactor6 As Single = 1F
				Dim fMFactor6 As Single = 1F
				Dim fEtoM6 As Single = 1F
				text2 = "##0 \HP"
				Me.ShowBE(Me.sMulticylinderEngine, array2, fEFactor6, fMFactor6, fEtoM6, text2, True, array)
				rst.HpNemaD = array2
			Else
				Me.lblReqPrimeMoverSize.Text = Me.sPrimeMoverSpeedVariation
				Me.lnPMSV.Visible = True
				Me.lblMotorSPVHdr.Visible = False
				If RSWIN_DESC.rst.CalcMotorSPV <> 0S Then
					Dim label As DataDynamics.ActiveReports.Label = Me.lblMotorSPVHdr
					Dim w As Object = 38
					Dim motorSPV As Single = RSWIN_DESC.rst.MotorSPV
					Dim text2 As String = "###.##%"
					label.Text = Me.MkSumm(w, Me.sCalculatedSpeedVariation, motorSPV, text2, False, False)
					Me.lblMotorSPVHdr.Visible = True
					Me.lblMotorSPV.Visible = False
				ElseIf RSWIN_DESC.rst.MotorSPV > 0F Then
					Dim label2 As DataDynamics.ActiveReports.Label = Me.lblMotorSPVHdr
					Dim w2 As Object = 38
					Dim motorSPV2 As Single = RSWIN_DESC.rst.MotorSPV
					Dim text2 As String = "###.##%"
					label2.Text = Me.MkSumm(w2, Me.sEnteredSpeedVariation, motorSPV2, text2, False, False)
					Me.lblMotorSPVHdr.Visible = True
					Me.lblMotorSPV.Visible = False
				Else
					Me.lblMotorSPVHdr.Text = Me.sSpeedVariationNotConsidered
					Me.lblMotorSPVHdr.Visible = True
					Me.lblMotorSPV.Visible = False
				End If
				Me.SetfraPmBalancedEVisible(False)
				Me.SetfraPmBalancedTVisible(False, False)
				Me.SetfraPmExistingVisible(False, False)
				Me.lblNEMAD.Visible = False
				Me.lblMultiCyl.Visible = False
				Me.lblSingleCyl.Visible = False
				Me.Line8.Visible = False
			End If
		End Sub

		Private Sub SETPMLABELS()
			If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
				If RSWIN_DESC.rst.get_RequiredUnbalance(0) = RSWIN_DESC.rst.get_RequiredUnbalance(1) Or RSWIN_DESC.bBalancedEVarsOverwritten Then
					Me.SetfraPmBalancedEVisible(False)
					Me.SetfraPmBalancedTVisible(True, True)
				End If
			ElseIf RSWIN_DESC.rst.get_M(0) = RSWIN_DESC.rst.get_M(1) Or RSWIN_DESC.bBalancedEVarsOverwritten Then
				Me.SetfraPmBalancedEVisible(False)
				Me.SetfraPmBalancedTVisible(True, True)
			End If
			If(Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And RSWIN_DESC.rst.UnknownM) Or ((RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And RSWIN_DESC.rst.bUnknownUnbalance) Then
				Me.SetfraPmExistingVisible(False, False)
				Return
			End If
			Me.SetfraPmExistingVisible(True, True)
			Me.SetfraPmBalancedTVisible(False, False)
		End Sub

		Private Sub SetfraPmBalancedEVisible(bVal As Boolean)
			Me.lblNEMAD_BE.Visible = bVal
			Me.lblMultiCyl_BE.Visible = bVal
			Me.lblSingleCyl_BE.Visible = bVal
			Me.lblPmMinEner.Visible = bVal
			Me.lblPmBalancedE.Visible = bVal
		End Sub

		Private Sub SetfraPmBalancedTVisible(bVal As Boolean, Optional bLeft As Boolean = False)
			Me.lblNEMAD_BT.Visible = bVal
			Me.lblMultiCyl_BT.Visible = bVal
			Me.lblSingleCyl_BT.Visible = bVal
			Me.lblPmMinTorq.Visible = bVal
			Me.lblPmBalancedT.Visible = bVal
			If bLeft Then
				Me.lblNEMAD_BT.Left = Me.lblNEMAD_BE.Left
				Me.lblMultiCyl_BT.Left = Me.lblMultiCyl_BE.Left
				Me.lblSingleCyl_BT.Left = Me.lblSingleCyl_BE.Left
				Me.lblPmMinTorq.Left = Me.lblPmMinEner.Left
				Me.lblPmBalancedT.Left = Me.lblPmBalancedE.Left
			End If
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
				Me.lblRodStressMethodHdrTop.Text = Me.sNumGuides
				Me.lblRodStressMethodHdrBot.Text = ""
				Me.ShowNumberRodGuides(Me.lblRodStressMethod1, Me.lblRodStressMethod2, Me.lblRodStressMethod3, Me.lblRodStressMethod4, Me.lblRodStressMethod5, Me.lblRodStressMethod6, Me.lblRodStressMethod7, Me.lblRodStressMethod8, Me.lblRodStressMethod9, Me.lblRodStressMethod10)
			End If
			Dim y As Single = Me.m_LastTop + Me.m_LastHeight
			Me.linRSCalcSep1.Y2 = y
			Me.linRSCalcSep2.Y2 = y
			Me.linRSCalcSep3.Y2 = y
			Me.linRSCalcSep4.Y2 = y
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
								avLabels1.Text = num.ToString()
								Me.m_LastTop = avLabels1.Top
								Me.m_LastHeight = avLabels1.Height
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								avLabels2.Text = num.ToString()
								Me.m_LastTop = avLabels2.Top
								Me.m_LastHeight = avLabels2.Height
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								avLabels3.Text = num.ToString()
								Me.m_LastTop = avLabels3.Top
								Me.m_LastHeight = avLabels3.Height
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								avLabels4.Text = num.ToString()
								Me.m_LastTop = avLabels4.Top
								Me.m_LastHeight = avLabels4.Height
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								avLabels5.Text = num.ToString()
								Me.m_LastTop = avLabels5.Top
								Me.m_LastHeight = avLabels5.Height
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								avLabels6.Text = num.ToString()
								Me.m_LastTop = avLabels6.Top
								Me.m_LastHeight = avLabels6.Height
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								avLabels7.Text = num.ToString()
								Me.m_LastTop = avLabels7.Top
								Me.m_LastHeight = avLabels7.Height
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								avLabels8.Text = num.ToString()
								Me.m_LastTop = avLabels8.Top
								Me.m_LastHeight = avLabels8.Height
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								avLabels9.Text = num.ToString()
								Me.m_LastTop = avLabels9.Top
								Me.m_LastHeight = avLabels9.Height
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								avLabels10.Text = num.ToString()
								Me.m_LastTop = avLabels10.Top
								Me.m_LastHeight = avLabels10.Height
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 40L
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
			Loop While num <= 40L
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

		Private Sub ShowRodBotMinStressList_old(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
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
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 40L
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
			Loop While num <= 40L
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
			Loop While num <= 40L
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
			Loop While num <= 40L
		End Sub

		Private Sub ShowRodStressList_Save(ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label, ByRef avLabels7 As DataDynamics.ActiveReports.Label, ByRef avLabels8 As DataDynamics.ActiveReports.Label, ByRef avLabels9 As DataDynamics.ActiveReports.Label, ByRef avLabels10 As DataDynamics.ActiveReports.Label)
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
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 40L
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
					Me.ShowBE(text, array, fEFactor, fMFactor, fEtoM, text2, True, array2)
					Me.MakeArray(4, array2, Me.lblGearboxLoading, Me.lblGearboxLoading_BE, Me.lblGearboxLoading_BT, Me.lblGearboxLoading_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor2 As Single = 0F
					Dim fMFactor2 As Single = 0F
					Dim fEtoM2 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor2, fMFactor2, fEtoM2, text, True, array2)
					Me.MakeArray(4, array2, Me.lblCLF, Me.lblCLF_BE, Me.lblCLF_BT, Me.lblCLF_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor3 As Single = 0F
					Dim fMFactor3 As Single = 0F
					Dim fEtoM3 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor3, fMFactor3, fEtoM3, text, True, array2)
					Me.MakeArray(4, array2, Me.lblMCM, Me.lblMCM_BE, Me.lblMCM_BT, Me.lblMCM_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor4 As Single = 0F
					Dim fMFactor4 As Single = 0F
					Dim fEtoM4 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor4, fMFactor4, fEtoM4, text, True, array2)
					Me.MakeArray(4, array2, Me.lblCBE, Me.lblCBE_BE, Me.lblCBE_BT, Me.lblCBE_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor5 As Single = 0F
					Dim fMFactor5 As Single = 0F
					Dim fEtoM5 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor5, fMFactor5, fEtoM5, text, True, array2)
					Me.MakeArray(4, array2, Me.lblMotorKWH, Me.lblMotorKWH_BE, Me.lblMotorKWH_BT, Me.lblMotorKWH_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor6 As Single = 0F
					Dim fMFactor6 As Single = 0F
					Dim fEtoM6 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor6, fMFactor6, fEtoM6, text, True, array2)
					Me.MakeArray(4, array2, Me.lblElectricBillPerMonth, Me.lblElectricBillPerMonth_BE, Me.lblElectricBillPerMonth_BT, Me.lblElectricBillPerMonth_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor7 As Single = 0F
					Dim fMFactor7 As Single = 0F
					Dim fEtoM7 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor7, fMFactor7, fEtoM7, text, True, array2)
					Me.MakeArray(4, array2, Me.lblDollarsPerBblFluid, Me.lblDollarsPerBblFluid_BE, Me.lblDollarsPerBblFluid_BT, Me.lblDollarsPerBblFluid_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor8 As Single = 0F
					Dim fMFactor8 As Single = 0F
					Dim fEtoM8 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor8, fMFactor8, fEtoM8, text, True, array2)
					Me.MakeArray(4, array2, Me.lblDollarsPerBblOil, Me.lblDollarsPerBblOil_BE, Me.lblDollarsPerBblOil_BT, Me.lblDollarsPerBblOil_E, Nothing, Nothing)
					text2 = Nothing
					Dim fEFactor9 As Single = 0F
					Dim fMFactor9 As Single = 0F
					Dim fEtoM9 As Single = 0F
					text = "#"
					Me.ShowBE(text2, array, fEFactor9, fMFactor9, fEtoM9, text, True, array2)
				Else
					Dim array2 As DataDynamics.ActiveReports.Label()
					Me.MakeArray(4, array2, Me.lblPeakTorque, Me.lblPeakTorque_BE, Me.lblPeakTorque_BT, Me.lblPeakTorque_E, Nothing, Nothing)
					Dim text2 As String = Me.sPeakGboxTorq + str
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim array3 As Single() = rst.PeakTorque
					Dim fEFactor10 As Single = 0.001F
					Dim fMFactor10 As Single = 0.001F
					Dim minlb__NM As Single = RSWIN_DESC.MINLB__NM
					Dim text As String = "0"
					Me.ShowBE(text2, array3, fEFactor10, fMFactor10, minlb__NM, text, True, array2)
					rst.PeakTorque = array3
					Me.MakeArray(4, array2, Me.lblGearboxLoading, Me.lblGearboxLoading_BE, Me.lblGearboxLoading_BT, Me.lblGearboxLoading_E, Nothing, Nothing)
					rst = RSWIN_DESC.rst
					array3 = rst.GearboxLoading
					Dim fEFactor11 As Single = 1F
					Dim fMFactor11 As Single = 1F
					Dim fEtoM10 As Single = 1F
					text2 = "###%"
					Me.ShowBE(Me.sGearboxLoading, array3, fEFactor11, fMFactor11, fEtoM10, text2, True, array2)
					rst.GearboxLoading = array3
					Me.MakeArray(4, array2, Me.lblCLF, Me.lblCLF_BE, Me.lblCLF_BT, Me.lblCLF_E, Nothing, Nothing)
					rst = RSWIN_DESC.rst
					array3 = rst.Clf
					Dim fEFactor12 As Single = 1F
					Dim fMFactor12 As Single = 1F
					Dim fEtoM11 As Single = 1F
					text2 = "#.###"
					Me.ShowBE(Me.sCyclicLoadFactor, array3, fEFactor12, fMFactor12, fEtoM11, text2, True, array2)
					rst.Clf = array3
					If RSWIN_DESC.rst.PU.UnitType = 6S Then
						Me.MakeArray(4, array2, Me.lblMCM, Me.lblMCM_BE, Me.lblMCM_BT, Me.lblMCM_E, Nothing, Nothing)
						text2 = Me.sMaxAirTankPres + str2
						rst = RSWIN_DESC.rst
						array3 = rst.M
						Dim fEFactor13 As Single = 1F
						Dim fMFactor13 As Single = 1F
						Dim psi__KPA As Single = RSWIN_DESC.PSI__KPA
						text = "0"
						Me.ShowBE(text2, array3, fEFactor13, fMFactor13, psi__KPA, text, True, array2)
						rst.M = array3
						Me.MakeArray(4, array2, Me.lblCBE, Me.lblCBE_BE, Me.lblCBE_BT, Me.lblCBE_E, Nothing, Nothing)
						rst = RSWIN_DESC.rst
						array3 = rst.CBE90
						Dim fEFactor14 As Single = 1F
						Dim fMFactor14 As Single = 1F
						Dim lb__N As Single = RSWIN_DESC.LB__N
						text2 = "#"
						Me.ShowBE(Me.sNull, array3, fEFactor14, fMFactor14, lb__N, text2, True, array2)
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
						Me.ShowBE(text2, array3, fEFactor15, fMFactor15, lb__N2, text, True, array2)
						rst.M = array3
						Me.MakeArray(4, array2, Me.lblCBE, Me.lblCBE_BE, Me.lblCBE_BT, Me.lblCBE_E, Nothing, Nothing)
						rst = RSWIN_DESC.rst
						array3 = rst.CBE90
						Dim fEFactor16 As Single = 1F
						Dim fMFactor16 As Single = 1F
						Dim lb__N3 As Single = RSWIN_DESC.LB__N
						text2 = "#"
						Me.ShowBE(Me.sNull, array3, fEFactor16, fMFactor16, lb__N3, text2, True, array2)
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
						Me.ShowBE(text2, array3, fEFactor17, fMFactor17, lb__N4, text, True, array2)
						rst.RequiredUnbalance = array3
						Me.MakeArray(4, array2, Me.lblCBE, Me.lblCBE_BE, Me.lblCBE_BT, Me.lblCBE_E, Nothing, Nothing)
						text2 = Me.sCounterbalanceEffect + str5
						rst = RSWIN_DESC.rst
						array3 = rst.CBE90
						Dim fEFactor18 As Single = 1F
						Dim fMFactor18 As Single = 1F
						Dim lb__N5 As Single = RSWIN_DESC.LB__N
						text = "0"
						Me.ShowBE(text2, array3, fEFactor18, fMFactor18, lb__N5, text, True, array2)
						rst.CBE90 = array3
					Else
						Me.MakeArray(4, array2, Me.lblMCM, Me.lblMCM_BE, Me.lblMCM_BT, Me.lblMCM_E, Nothing, Nothing)
						text2 = Me.sMaxCBMoment + " " + str4
						rst = RSWIN_DESC.rst
						array3 = rst.M
						Dim fEFactor19 As Single = 0.001F
						Dim fMFactor19 As Single = 0.001F
						Dim minlb__NM2 As Single = RSWIN_DESC.MINLB__NM
						text = "0.0#"
						Me.ShowBE(text2, array3, fEFactor19, fMFactor19, minlb__NM2, text, True, array2)
						rst.M = array3
						Me.MakeArray(4, array2, Me.lblCBE, Me.lblCBE_BE, Me.lblCBE_BT, Me.lblCBE_E, Nothing, Nothing)
						text2 = Me.sCounterbalanceEffect + str5
						rst = RSWIN_DESC.rst
						array3 = rst.CBE90
						Dim fEFactor20 As Single = 1F
						Dim fMFactor20 As Single = 1F
						Dim lb__N6 As Single = RSWIN_DESC.LB__N
						text = "0"
						Me.ShowBE(text2, array3, fEFactor20, fMFactor20, lb__N6, text, True, array2)
						rst.CBE90 = array3
					End If
					Me.MakeArray(4, array2, Me.lblMotorKWH, Me.lblMotorKWH_BE, Me.lblMotorKWH_BT, Me.lblMotorKWH_E, Nothing, Nothing)
					rst = RSWIN_DESC.rst
					array3 = rst.MotorKWH
					Dim fEFactor21 As Single = 1F
					Dim fMFactor21 As Single = 1F
					Dim fEtoM12 As Single = 1F
					text2 = "###0"
					Me.ShowBE(Me.sDailyElectrUse, array3, fEFactor21, fMFactor21, fEtoM12, text2, True, array2)
					rst.MotorKWH = array3
					Me.MakeArray(4, array2, Me.lblElectricBillPerMonth, Me.lblElectricBillPerMonth_BE, Me.lblElectricBillPerMonth_BT, Me.lblElectricBillPerMonth_E, Nothing, Nothing)
					rst = RSWIN_DESC.rst
					array3 = rst.ElectricBillperMonth
					Dim fEFactor22 As Single = 1F
					Dim fMFactor22 As Single = 1F
					Dim fEtoM13 As Single = 1F
					text2 = "$0"
					Me.ShowBE(Me.sMonthlyElectricBill, array3, fEFactor22, fMFactor22, fEtoM13, text2, True, array2)
					rst.ElectricBillperMonth = array3
					Me.MakeArray(4, array2, Me.lblDollarsPerBblFluid, Me.lblDollarsPerBblFluid_BE, Me.lblDollarsPerBblFluid_BT, Me.lblDollarsPerBblFluid_E, Nothing, Nothing)
					text2 = Me.sElectrCostPer + str7 + " fluid:"
					rst = RSWIN_DESC.rst
					array3 = rst.DollarsPerBblFluid
					Dim fEFactor23 As Single = 1F
					Dim fMFactor23 As Single = 1F
					Dim fEtoM14 As Single = 1F / RSWIN_DESC.BPD__M3D
					text = "$0.000"
					Me.ShowBE(text2, array3, fEFactor23, fMFactor23, fEtoM14, text, False, array2)
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
						Me.ShowBE(text2, array3, fEFactor24, fMFactor24, fEtoM15, text, False, array2)
						rst.DollarsPerBblOil = array3
					Else
						Me.MakeArray(4, array2, Me.lblDollarsPerBblOil, Me.lblDollarsPerBblOil_BE, Me.lblDollarsPerBblOil_BT, Me.lblDollarsPerBblOil_E, Nothing, Nothing)
						text2 = Nothing
						Dim fEFactor25 As Single = 0F
						Dim fMFactor25 As Single = 0F
						Dim fEtoM16 As Single = 0F
						text = "#"
						Dim array As Single()
						Me.ShowBE(text2, array, fEFactor25, fMFactor25, fEtoM16, text, True, array2)
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

		Private Sub ShowBE(ByRef sLabel As String, ByRef afValues As Single(), fEFactor As Single, fMFactor As Single, fEtoM As Single, ByRef sFormat As String, bCanadianUsesEnglish As Boolean, ByRef arLabels As DataDynamics.ActiveReports.Label())
			Try
				Dim label As DataDynamics.ActiveReports.Label = arLabels(0)
				label.Text = sLabel
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
				Next
			Catch ex As Exception
				Dim sMsg As String = "Error In ShowBE: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
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
				Dim text2 As String = "#.#"
				label.Text = Me.MkSummEM(w, Me.sGrossPumpStroke, grossPumpStroke, in__CM, RSWIN_DESC.ins, text, RSWIN_DESC.cm, text2, 1, True, False)
				Dim label2 As DataDynamics.ActiveReports.Label = Me.lblPlungerLength
				Dim w2 As Object = 47
				Dim plungerLength As Single = RSWIN_DESC.rst.PlungerLength
				Dim ft__M As Single = RSWIN_DESC.FT__M
				text2 = "#.#"
				text = "m"
				Dim text3 As String = "#.#"
				label2.Text = Me.MkSummEM(w2, Me.sRecommendedPlungerLength, plungerLength, ft__M, RSWIN_DESC.ft, text2, text, text3, 1, True, False)
				Dim label3 As DataDynamics.ActiveReports.Label = Me.lblProductionLoss
				Dim w3 As Object = 47
				Dim productionLoss As Single = RSWIN_DESC.rst.ProductionLoss
				Dim bpd__M3D As Single = RSWIN_DESC.BPD__M3D
				text3 = "0"
				text2 = "#.#"
				label3.Text = Me.MkSummEM(w3, Me.sProdLossDueToTubingStretch, productionLoss, bpd__M3D, RSWIN_DESC.bfpd, text3, RSWIN_DESC.m3D, text2, 3, True, False)
				Dim label4 As DataDynamics.ActiveReports.Label = Me.lblPumpLength
				Dim w4 As Object = 47
				Dim pumpLength As Single = RSWIN_DESC.rst.PumpLength
				Dim ft__M2 As Single = RSWIN_DESC.FT__M
				text3 = "#.#"
				text2 = "m"
				text = "#.#"
				label4.Text = Me.MkSummEM(w4, Me.sMinimumPumpLength, pumpLength, ft__M2, RSWIN_DESC.ft, text3, text2, text, 1, True, False)
				Dim label5 As DataDynamics.ActiveReports.Label = Me.lblPumpSpacing
				Dim w5 As Object = 47
				Dim pumpSpacing As Single = RSWIN_DESC.rst.PumpSpacing
				Dim in__CM2 As Single = RSWIN_DESC.IN__CM
				text3 = "in. from bottom"
				text2 = "#.#"
				text = "cm from bottom"
				Dim text4 As String = "0"
				label5.Text = Me.MkSummEM(w5, Me.sPumpSpacing, pumpSpacing, in__CM2, text3, text2, text, text4, 1, True, False)
				Dim label6 As DataDynamics.ActiveReports.Label = Me.lblTubingStretch
				Dim w6 As Object = 47
				Dim tubStretch As Single = RSWIN_DESC.rst.TubStretch
				Dim in__CM3 As Single = RSWIN_DESC.IN__CM
				text4 = "#.#"
				text3 = "#.#"
				label6.Text = Me.MkSummEM(w6, Me.sTubingStretch, tubStretch, in__CM3, RSWIN_DESC.ins, text4, RSWIN_DESC.cm, text3, 1, True, False)
				Dim label7 As DataDynamics.ActiveReports.Label = Me.txtGrossPumpStroke
				Dim w7 As Object = 0
				text4 = ""
				Dim grossPumpStroke2 As Single = RSWIN_DESC.rst.GrossPumpStroke
				Dim in__CM4 As Single = RSWIN_DESC.IN__CM
				text3 = "0"
				text2 = "#.#"
				label7.Text = Me.MkSummEM(w7, text4, grossPumpStroke2, in__CM4, RSWIN_DESC.ins, text3, RSWIN_DESC.cm, text2, 1, False, True)
				Dim label8 As DataDynamics.ActiveReports.Label = Me.txtPlungerLength
				Dim w8 As Object = 0
				text4 = ""
				Dim plungerLength2 As Single = RSWIN_DESC.rst.PlungerLength
				Dim ft__M3 As Single = RSWIN_DESC.FT__M
				text3 = "#.#"
				text2 = "m"
				text = "#.#"
				label8.Text = Me.MkSummEM(w8, text4, plungerLength2, ft__M3, RSWIN_DESC.ft, text3, text2, text, 1, False, True)
				Dim label9 As DataDynamics.ActiveReports.Label = Me.txtProductionLoss
				Dim w9 As Object = 0
				text4 = ""
				Dim productionLoss2 As Single = RSWIN_DESC.rst.ProductionLoss
				Dim bpd__M3D2 As Single = RSWIN_DESC.BPD__M3D
				text3 = "0"
				text2 = "#.#"
				label9.Text = Me.MkSummEM(w9, text4, productionLoss2, bpd__M3D2, RSWIN_DESC.bfpd, text3, RSWIN_DESC.m3D, text2, 3, False, True)
				Dim label10 As DataDynamics.ActiveReports.Label = Me.txtPumpLength
				Dim w10 As Object = 0
				text4 = ""
				Dim pumpLength2 As Single = RSWIN_DESC.rst.PumpLength
				Dim ft__M4 As Single = RSWIN_DESC.FT__M
				text3 = "#.#"
				text2 = "m"
				text = "#.#"
				label10.Text = Me.MkSummEM(w10, text4, pumpLength2, ft__M4, RSWIN_DESC.ft, text3, text2, text, 1, False, True)
				Dim label11 As DataDynamics.ActiveReports.Label = Me.txtPumpSpacing
				Dim w11 As Object = 0
				text4 = ""
				Dim pumpSpacing2 As Single = RSWIN_DESC.rst.PumpSpacing
				Dim in__CM5 As Single = RSWIN_DESC.IN__CM
				text3 = "in. from bottom"
				text2 = "#.#"
				text = "cm from bottom"
				Dim text5 As String = "0"
				label11.Text = Me.MkSummEM(w11, text4, pumpSpacing2, in__CM5, text3, text2, text, text5, 1, False, True)
				Dim label12 As DataDynamics.ActiveReports.Label = Me.txtTubingStretch
				Dim w12 As Object = 0
				text5 = ""
				Dim tubStretch2 As Single = RSWIN_DESC.rst.TubStretch
				Dim in__CM6 As Single = RSWIN_DESC.IN__CM
				text4 = "#.#"
				text3 = "#.#"
				label12.Text = Me.MkSummEM(w12, text5, tubStretch2, in__CM6, RSWIN_DESC.ins, text4, RSWIN_DESC.cm, text3, 1, False, True)
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

		Private Sub SummTrailer(ByRef LastTop As Single, LastHeight As Single)
			Dim array As String() = New String(10) {}
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				Dim text As String = Me.sElevatorNeck + "25.4 mm"
			Else
				Dim text As String = Me.sElevatorNeck + "1"""
			End If
			Dim obj As Object = 0
			If Me.mbMsgFullOKNeeded Then
				obj = Operators.AddObject(obj, 1)
				array(Conversions.ToInteger(obj)) = Me.sAsterickMsg
			End If
			If Me.mbMsgSlimNeededNeeded Then
				obj = Operators.AddObject(obj, 1)
				array(Conversions.ToInteger(obj)) = Me.sPlusMsg
			End If
			If Me.mbMsgElevatorNeck1_0Needed Then
				obj = Operators.AddObject(obj, 1)
				array(Conversions.ToInteger(obj)) = Me.sAtSignMsg
			End If
			If Me.mbMsgNoNeckNeeded Then
				obj = Operators.AddObject(obj, 1)
				array(Conversions.ToInteger(obj)) = Me.sPoundSignMsg
			End If
			obj = Operators.AddObject(obj, 1)
			If rst.gbIncludeBuoyancy Then
				array(Conversions.ToInteger(obj)) = Me.sNOTE1
			Else
				array(Conversions.ToInteger(obj)) = Me.sNOTE2
			End If
			If Conversions.ToBoolean(Operators.AndObject(Me.FiberodOverloaded(), Operators.CompareObjectLess(obj, 5, False))) Then
				obj = Operators.AddObject(obj, 1)
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					array(Conversions.ToInteger(obj)) = RSWIN_DESC.sMaxFiberodStressWarning_Meter
				Else
					array(Conversions.ToInteger(obj)) = RSWIN_DESC.sMaxFiberodStressWarning_English
				End If
			ElseIf Conversions.ToBoolean(Operators.AndObject(Me.FibercoOverloaded(), Operators.CompareObjectLess(obj, 5, False))) Then
				obj = Operators.AddObject(obj, 1)
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					array(Conversions.ToInteger(obj)) = RSWIN_DESC.sMaxFibercoStressWarning_Meter
				Else
					array(Conversions.ToInteger(obj)) = RSWIN_DESC.sMaxFibercoStressWarning_English
				End If
			End If
			If Conversions.ToBoolean(Operators.AndObject(Me.FiberodUnderloaded(), Operators.CompareObjectLess(obj, 5, False))) Then
				obj = Operators.AddObject(obj, 1)
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					array(Conversions.ToInteger(obj)) = RSWIN_DESC.sMinFiberodStressWarning_Meter
				Else
					array(Conversions.ToInteger(obj)) = RSWIN_DESC.sMinFiberodStressWarning_English
				End If
			ElseIf Conversions.ToBoolean(Operators.AndObject(Me.FibercoUnderloaded(), Operators.CompareObjectLess(obj, 5, False))) Then
				obj = Operators.AddObject(obj, 1)
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					array(Conversions.ToInteger(obj)) = RSWIN_DESC.sMinFibercoStressWarning_Meter
				Else
					array(Conversions.ToInteger(obj)) = RSWIN_DESC.sMinFibercoStressWarning_English
				End If
			End If
			Dim obj2 As Object
			Dim obj3 As Object
			If Operators.ConditionalCompareObjectGreaterEqual(obj, 1, False) AndAlso ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj2, 1, obj, 1, obj3, obj2) Then
				Do
					Me.SendLine(Conversions.ToInteger(obj2), array(Conversions.ToInteger(obj2)), LastTop, LastHeight)
				Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj2, obj3, obj2)
			End If
		End Sub

		Private Sub showRSTrailer()
			Dim num As Long = 1L
			Do
				Me.SetRodGradeList(CInt(num))
				num += 1L
			Loop While num <= 40L
			Dim lastTop As Single = CSng((CDbl(Me.m_LastTop) + 1.5 * CDbl(Me.lblRSFootnote1.Height)))
			Me.ShowTrailer(lastTop, Me.lblRSFootnote1, Me.lblRSFootnote2, Me.lblRSFootnote3, Me.lblRSFootnote4, Me.lblRSFootnote5)
			Me.m_LastTop = lastTop
		End Sub

		Private Sub ShowRSInput()
			Dim lastTop As Single = CSng((CDbl(Me.m_LastTop) + 1.5 * CDbl(Me.lblRSFootnote1.Height)))
			Me.ShowTrailer(lastTop, Me.lblRSFootnote1, Me.lblRSFootnote2, Me.lblRSFootnote3, Me.lblRSFootnote4, Me.lblRSFootnote5)
			Me.m_LastTop = lastTop
		End Sub

		Private Sub ShowTrailer(ByRef cyTop As Single, ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label)
			Dim num As Long = 0L
			Dim array As String() = New String(4) {}
			Try
				If RSWIN_DESC.rst.gbIncludeBuoyancy Then
					array(CInt(num)) = Me.sNOTE1
					num += 1L
				Else
					array(CInt(num)) = Me.sNOTE2
					num += 1L
				End If
				Dim num2 As Long = 1L
				Dim num3 As Long = num
				For num4 As Long = num2 To num3
					Dim num5 As Long = num4
					Dim label As DataDynamics.ActiveReports.Label
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
					Dim label2 As DataDynamics.ActiveReports.Label = label
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

		Private Sub SetfraPmExistingVisible(bVal As Boolean, Optional bLeft As Boolean = False)
			Me.lblNEMAD_E.Visible = bVal
			Me.lblMultiCyl_E.Visible = bVal
			Me.lblSingleCyl_E.Visible = bVal
			Me.lblPmExisting.Visible = bVal
			If bLeft Then
				Me.lblNEMAD_E.Left = Me.lblNEMAD_BT.Left
				Me.lblMultiCyl_E.Left = Me.lblMultiCyl_BT.Left
				Me.lblSingleCyl_E.Left = Me.lblSingleCyl_BT.Left
				Me.lblPmExisting.Left = Me.lblPmBalancedT.Left
			End If
		End Sub

		Public Function MkSummEM(W As Object, ByRef Label As String, v As Single, EtoM As Single, ByRef EU As String, ByRef EFmt As String, ByRef MU As String, ByRef MFmt As String, cUnits As Object, Optional bShowLabelOnly As Boolean = False, Optional bShowValueOnly As Boolean = False) As String
			Dim num As Short
			Select Case RSWIN_DESC.SETUP_MeasurementSystem
				Case 1
					num = 0S
				Case 2
					num = Conversions.ToShort(Operators.CompareObjectEqual(cUnits, 3, False))
				Case 3
					num = -1S
			End Select
			Dim str As String = ""
			Dim text As String
			If num <> 0S Then
				If Strings.Len(MU) > 0 Then
					str = " (" + MU + ")"
				End If
				v *= EtoM
				text = MFmt
			Else
				If Strings.Len(EU) > 0 Then
					str = " (" + EU + ")"
				End If
				text = EFmt
			End If
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(W)
			Dim text2 As String = Label + str + ":"
			Return Me.MkSumm(objectValue, text2, v, text, bShowLabelOnly, bShowValueOnly)
		End Function

		Public Function MkSumm(W As Object, ByRef L As String, Value As Single, ByRef Fmt As String, Optional bShowLabelOnly As Boolean = False, Optional bShowValueOnly As Boolean = False) As String
			Dim result As String
			Try
				Dim text As String = Util.Format(Value, Fmt)
				If text Is Nothing Then
					text = "0"
				End If
				Dim text2 As String = Strings.Space(Conversions.ToInteger(W))
				If bShowLabelOnly Then
					StringType.MidStmtStr(text2, 1, Strings.Len(L), L)
				ElseIf bShowValueOnly Then
					If Operators.ConditionalCompareObjectGreater(W, 0, False) Then
						StringType.MidStmtStr(text2, Conversions.ToInteger(Operators.AddObject(Operators.SubtractObject(W, Strings.Len(text)), 1)), Strings.Len(text), text)
					Else
						text2 = text
					End If
				Else
					StringType.MidStmtStr(text2, 1, Strings.Len(L), L)
					StringType.MidStmtStr(text2, Conversions.ToInteger(Operators.AddObject(Operators.SubtractObject(W, Strings.Len(text)), 1)), Strings.Len(text), text)
				End If
				result = text2
			Catch ex As Exception
			End Try
			Return result
		End Function

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
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub AddRexResource(sKey As String, sVal As String)
			RSWIN_DESC.RwX.AddResource(sKey, sVal)
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

		Private Sub SetRodGradeList(I As Integer)
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
			If RODUTIL.IsCorodH(RSWIN_DESC.rst.Sections(I).Grade) Then
				Dim str2 As String = Me.sNA
				Return
			End If
			If RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(I).Grade) Then
				Dim num As Single = RSWIN_DESC.rst.Sections(I).Diameter * 16F
				Dim text As String = "0"
				Dim str2 As String = Util.Format(num, text) + "/16"
				If Not Me.mbCorodSEString And RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					str2 += """"
					Return
				End If
			Else
				Dim str2 As String
				Dim text As String
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					Dim num As Single = RSWIN_DESC.rst.Sections(I).Diameter * RSWIN_DESC.IN__MM
					text = "0.0"
					str2 = Util.Format(num, text)
					Return
				End If
				Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
				text = "0.####"
				str2 = Util.Format(sections(I).Diameter, text)
			End If
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

		<AccessedThroughProperty("GroupHeader1")>
		Private _GroupHeader1 As GroupHeader

		<AccessedThroughProperty("Detail")>
		Private _Detail As Detail

		<AccessedThroughProperty("GroupFooter1")>
		Private _GroupFooter1 As GroupFooter

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

		Private lblMotorSPVHdr As DataDynamics.ActiveReports.Label

		Private lblMotorSPV As DataDynamics.ActiveReports.Label

		Private lblNEMAD As DataDynamics.ActiveReports.Label

		Private lblCBE As DataDynamics.ActiveReports.Label

		Private lblCalculatedResults As DataDynamics.ActiveReports.Label

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

		Private lblRodStringResults As DataDynamics.ActiveReports.Label

		Private lblRodStressHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodStress1 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStressHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStressHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStressHdrBot As DataDynamics.ActiveReports.Label

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

		Private lblPlungerLength As DataDynamics.ActiveReports.Label

		Private lblPumpLength As DataDynamics.ActiveReports.Label

		Private lblPumpSpacing As DataDynamics.ActiveReports.Label

		Private lblGrossPumpStroke As DataDynamics.ActiveReports.Label

		Private lblProductionLoss As DataDynamics.ActiveReports.Label

		Private lblTubingStretch As DataDynamics.ActiveReports.Label

		Private lblDollarsPerBblOil As DataDynamics.ActiveReports.Label

		Private lblDollarsPerBblFluid As DataDynamics.ActiveReports.Label

		Private lblElectricBillPerMonth As DataDynamics.ActiveReports.Label

		Private lblGearboxLoading As DataDynamics.ActiveReports.Label

		Private lblTorqueAnalysis As DataDynamics.ActiveReports.Label

		Private lblSingleCyl As DataDynamics.ActiveReports.Label

		Private lblPeakTorque As DataDynamics.ActiveReports.Label

		Private lblMotorKWH As DataDynamics.ActiveReports.Label

		Private lblReqPrimeMoverSize As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStressHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStressHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodStressMethodHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStressHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodStressHdrTop As DataDynamics.ActiveReports.Label

		Private lblPmBalancedT As DataDynamics.ActiveReports.Label

		Private lblTqBalancedT As DataDynamics.ActiveReports.Label

		Private lblTqBalancedE As DataDynamics.ActiveReports.Label

		Private txtPlungerLength As DataDynamics.ActiveReports.Label

		Private txtPumpLength As DataDynamics.ActiveReports.Label

		Private txtPumpSpacing As DataDynamics.ActiveReports.Label

		Private txtGrossPumpStroke As DataDynamics.ActiveReports.Label

		Private txtProductionLoss As DataDynamics.ActiveReports.Label

		Private txtTubingStretch As DataDynamics.ActiveReports.Label

		Private lnPMSV As Line

		Private linRSCalcSep3 As Line

		Private linRSCalcSep1 As Line

		Private linRSCalcSep2 As Line

		Private linRSCalcSep4 As Line

		Private lblPmBalancedE As DataDynamics.ActiveReports.Label

		Private lblRodStress9 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStress9 As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStress9 As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStress9 As DataDynamics.ActiveReports.Label

		Private lblRodStressMethod9 As DataDynamics.ActiveReports.Label

		Private lblRodStress10 As DataDynamics.ActiveReports.Label

		Private lblRodTopMaxStress10 As DataDynamics.ActiveReports.Label

		Private lblRodTopMinStress10 As DataDynamics.ActiveReports.Label

		Private lblRodBotMinStress10 As DataDynamics.ActiveReports.Label

		Private lblRodStressMethod10 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote2 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote5 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote4 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote3 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote1 As DataDynamics.ActiveReports.Label

		Private Line13 As Line

		Private Line14 As Line

		Private Line3 As Line

		Private Line1 As Line

		Private picTorquePlot As Picture

		Private picDyno As Picture

		Private lblNoResults As DataDynamics.ActiveReports.Label

		Private lblBPDSurface As DataDynamics.ActiveReports.Label

		Private lblPRHP As DataDynamics.ActiveReports.Label

		Private lblNoverNo As DataDynamics.ActiveReports.Label

		Private txtPRHP As DataDynamics.ActiveReports.Label

		Private txtStructLoading As DataDynamics.ActiveReports.Label

		Private txtRodWeight As DataDynamics.ActiveReports.Label

		Private txtPPRL As DataDynamics.ActiveReports.Label

		Private txtMPRL As DataDynamics.ActiveReports.Label

		Private lblFluidLevelTVD As DataDynamics.ActiveReports.Label

		Private txtPrhpPlhp As DataDynamics.ActiveReports.Label

		Private lblPrhpPlhp As DataDynamics.ActiveReports.Label

		Private lblPermLoadHP As DataDynamics.ActiveReports.Label

		Private txtBPDSurface As DataDynamics.ActiveReports.Label

		Private txtPermLoadHP As DataDynamics.ActiveReports.Label

		Private txtFluidLevelTVD As DataDynamics.ActiveReports.Label

		Private txtSystemEff As DataDynamics.ActiveReports.Label

		Private txtFluidLoad As DataDynamics.ActiveReports.Label

		Private txtCalcSPM As DataDynamics.ActiveReports.Label

		Private txtOilProduction As DataDynamics.ActiveReports.Label

		Private lblRodWeight As DataDynamics.ActiveReports.Label

		Private lblStructLoading As DataDynamics.ActiveReports.Label

		Private lblMPRL As DataDynamics.ActiveReports.Label

		Private lblPPRL As DataDynamics.ActiveReports.Label

		Private lblFluidLoad As DataDynamics.ActiveReports.Label

		Private lblSystemEff As DataDynamics.ActiveReports.Label

		Private lblCalcSPM As DataDynamics.ActiveReports.Label

		Private lblOilProduction As DataDynamics.ActiveReports.Label

		Private lblMCM As DataDynamics.ActiveReports.Label

		Private lblCLF As DataDynamics.ActiveReports.Label

		Private lblMPRLPPRL As DataDynamics.ActiveReports.Label

		Private txtMPRLPPRL As DataDynamics.ActiveReports.Label

		Private printFont As Font

		Private sNull As String

		Private m_LastTop As Single

		Private m_LastHeight As Single

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

		Private sPoundSignMsg As String

		Private sNOTE1 As String

		Private sNOTE2 As String

		Private sUNKNOWN As String

		Private c_UNKNOWN As String

		Private sFull As String

		Private sFlpound As String

		Private sGasIntf As String

		Private sPumpCondition As String

		Private sPlungerSize As String

		Private sPumpDepth As String

		Private sPumpFriction As String

		Private sPumpLoadAdj As String

		Private sPumpType As String

		Private sTubAnchDepth As String

		Private sTubingNotAnchored As String

		Private sTubingID As String

		Private sTubingOD As String

		Private sCalcPumpFillage As String

		Private sPumpVolEff As String

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

		Private sCrankCBMoment As String

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

		Private sRotationWithWellToRight As String

		Private sCW As String

		Private sCCW As String

		Private sCalculatedStrokeLength As String

		Private sSprocketRadius As String

		Private sClineSprocketDistance As String

		Private sDrumDiameterRatio As String

		Private sPitmanArmLength As String

		Private sStructuralUnbalance As String

		Private sRotInertia As String

		Private sArtInertia As String

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

		Private sAtSignMsg_M As String

		Private sPumpEfficiencyFillage As String

		Private fEffFill As String

		Private sCalculatedResults As String

		Private sRotation As String

		Private sAdjustedStrokeLength As String

		Private sBalRotInertia As String

		Private sEnteredRotInertia As String

		Public sNumGuides As String

		Public sStressCalc As String

		Public sMethod As String

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer

		Private m_bPrint As Boolean
	End Class
End Namespace
