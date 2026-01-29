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
	Public Class rptResultsInputs
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.rptResultsInputs_ReportStart
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
			Me.lblRodDiam10 = Nothing
			Me.linRSInputSep4 = Nothing
			Me.linRSInputSep1 = Nothing
			Me.linRSInputSep2 = Nothing
			Me.linRSInputSep3 = Nothing
			Me.Line1 = Nothing
			Me.lblInputData = Nothing
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
			Me.Line11 = Nothing
			Me.lblRodDiamHdrTop = Nothing
			Me.lblRodDiamHdrBot = Nothing
			Me.lblRodDiam1 = Nothing
			Me.lblRodGradeHdrBot = Nothing
			Me.lblRodLengthHdrBot = Nothing
			Me.lblRodTensileStrengthHdrBot = Nothing
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
			Me.lblFLPIP_3 = Nothing
			Me.lblSPM = Nothing
			Me.lblPumpFriction = Nothing
			Me.lblPumpEfficiency = Nothing
			Me.lblPumpLoadAdj = Nothing
			Me.lblTubingAnchorDepth = Nothing
			Me.lblDownstrokeFriction = Nothing
			Me.lblPumpType = Nothing
			Me.lblPumpCondition = Nothing
			Me.lblPumpDepth = Nothing
			Me.lblTubingPressure = Nothing
			Me.lblRodGradeHdrTop = Nothing
			Me.lblRodTensileStrengthHdrTop = Nothing
			Me.lblRodLengthHdrTop = Nothing
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
			Me.txtCrankHole = Nothing
			Me.txtStrokeLength = Nothing
			Me.txtCrankRotation = Nothing
			Me.txtCwtInfo_1 = Nothing
			Me.txtCwtInfo_2 = Nothing
			Me.txtCwtInfo_3 = Nothing
			Me.txtCwtInfo_4 = Nothing
			Me.txtCwtInfo_5 = Nothing
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
			Me.lblRodDiam9 = Nothing
			Me.lblRodGrade9 = Nothing
			Me.lblRodLength9 = Nothing
			Me.lblRodTensileStrength9 = Nothing
			Me.lblFricCoef9 = Nothing
			Me.lblRodGrade10 = Nothing
			Me.lblRodLength10 = Nothing
			Me.lblRodTensileStrength10 = Nothing
			Me.lblFricCoef10 = Nothing
			Me.Line12 = Nothing
			Me.lblRSFootnote2 = Nothing
			Me.lblRSFootnote5 = Nothing
			Me.lblRSFootnote4 = Nothing
			Me.lblRSFootnote3 = Nothing
			Me.lblRSFootnote1 = Nothing
			Me.lblPolRodDiam = Nothing
			Me.txtPolRodDiam = Nothing
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
			Me.sUnit = Util.AssignValueToConstant("rptCalcResults", "sUnit", "Pumping Unit: ")
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
			Me.sMarathonMotor = "Marathon NEMA B motor:"
			Me.sTatungMotor = "Tatung NEMA B motor:"
			Me.sSingleDoubleCylEngine = Util.AssignValueToConstant("rptCalcResults", "sSingleDoubleCylEngine", "Single/double cyl. engine:")
			Me.sMulticylinderEngine = Util.AssignValueToConstant("rptCalcResults", "sMulticylinderEngine", "Multicylinder engine:")
			Me.sGrossPumpStroke = Util.AssignValueToConstant("rptCalcResults", "sGrossPumpStroke", "Gross pump stroke")
			Me.sRecommendedPlungerLength = Util.AssignValueToConstant("rptCalcResults", "sRecommendedPlungerLength", "Recommended plunger length")
			Me.sProdLossDueToTubingStretch = Util.AssignValueToConstant("rptCalcResults", "sProdLossDueToTubingStretch", "Prod. loss due to tubing stretch")
			Me.sMinimumPumpLength = Util.AssignValueToConstant("rptCalcResults", "sMinimumPumpLength", "Minimum pump length")
			Me.sPumpSpacing = Util.AssignValueToConstant("rptCalcResults", "sPumpSpacing", "Pump spacing")
			Me.sTubingStretch = Util.AssignValueToConstant("rptCalcResults", "sTubingStretch", "Tubing stretch")
			Me.slbl = "lbl"
			Me.sAdjustedStrokeLength = "Adjusted stroke length"
			Me.sAtSignMsg_M = Util.AssignValueToConstant("rptCalcResults", "sAtSignMsg_M", "@ Stress calculations based on elevator neck of 22.2mm (for 31.8mm sinker bars) or 25.4mm (for other sinker bars).")
			Me.sPumpEfficiencyFillage = Util.AssignValueToConstant("rptCalcResults", "sPumpEfficiencyFillage", "Pump efficiency/fillage :")
			Me.sReqUnbalance = Util.AssignValueToConstant("rptCalcResults", "sReqUnbalance", "Str. Unbalance")
			Me.sCalculatedResults = Util.AssignValueToConstant("rptCalcResults", "sCalculatedResults", "CALCULATED RESULTS")
			Me.sRotation = Util.AssignValueToConstant("rptCalcResults", "sRotation", "Crank Rotation:")
			Me.sBalRotInertia = Util.AssignValueToConstant("rptCalcResults", "sBalRotInertia", "Bal. Rot. Moment of Inertia")
			Me.sEnteredRotInertia = Util.AssignValueToConstant("rptCalcResults", "sEnteredRotInertia", "Entered Rot. Moment of Inertia")
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

		Private Overridable Property lblRSFootnote6 As DataDynamics.ActiveReports.Label
			Get
				Return Me._lblRSFootnote6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataDynamics.ActiveReports.Label)
				Me._lblRSFootnote6 = value
			End Set
		End Property

		Private Sub InitializeComponent()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptResultsInputs))
			Me.Detail = New Detail()
			Me.lblRodDiam10 = New DataDynamics.ActiveReports.Label()
			Me.linRSInputSep4 = New Line()
			Me.linRSInputSep1 = New Line()
			Me.linRSInputSep2 = New Line()
			Me.linRSInputSep3 = New Line()
			Me.Line1 = New Line()
			Me.lblInputData = New DataDynamics.ActiveReports.Label()
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
			Me.Line11 = New Line()
			Me.lblRodDiamHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiamHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodDiam1 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGradeHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodLengthHdrBot = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrengthHdrBot = New DataDynamics.ActiveReports.Label()
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
			Me.lblFLPIP_3 = New DataDynamics.ActiveReports.Label()
			Me.lblSPM = New DataDynamics.ActiveReports.Label()
			Me.lblPumpFriction = New DataDynamics.ActiveReports.Label()
			Me.lblPumpEfficiency = New DataDynamics.ActiveReports.Label()
			Me.lblPumpLoadAdj = New DataDynamics.ActiveReports.Label()
			Me.lblTubingAnchorDepth = New DataDynamics.ActiveReports.Label()
			Me.lblDownstrokeFriction = New DataDynamics.ActiveReports.Label()
			Me.lblPumpType = New DataDynamics.ActiveReports.Label()
			Me.lblPumpCondition = New DataDynamics.ActiveReports.Label()
			Me.lblPumpDepth = New DataDynamics.ActiveReports.Label()
			Me.lblTubingPressure = New DataDynamics.ActiveReports.Label()
			Me.lblRodGradeHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrengthHdrTop = New DataDynamics.ActiveReports.Label()
			Me.lblRodLengthHdrTop = New DataDynamics.ActiveReports.Label()
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
			Me.txtCrankHole = New DataDynamics.ActiveReports.Label()
			Me.txtStrokeLength = New DataDynamics.ActiveReports.Label()
			Me.txtCrankRotation = New DataDynamics.ActiveReports.Label()
			Me.txtCwtInfo_1 = New DataDynamics.ActiveReports.Label()
			Me.txtCwtInfo_2 = New DataDynamics.ActiveReports.Label()
			Me.txtCwtInfo_3 = New DataDynamics.ActiveReports.Label()
			Me.txtCwtInfo_4 = New DataDynamics.ActiveReports.Label()
			Me.txtCwtInfo_5 = New DataDynamics.ActiveReports.Label()
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
			Me.lblRodDiam9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGrade9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodLength9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrength9 = New DataDynamics.ActiveReports.Label()
			Me.lblFricCoef9 = New DataDynamics.ActiveReports.Label()
			Me.lblRodGrade10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodLength10 = New DataDynamics.ActiveReports.Label()
			Me.lblRodTensileStrength10 = New DataDynamics.ActiveReports.Label()
			Me.lblFricCoef10 = New DataDynamics.ActiveReports.Label()
			Me.Line12 = New Line()
			Me.lblRSFootnote2 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote5 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote4 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote3 = New DataDynamics.ActiveReports.Label()
			Me.lblRSFootnote1 = New DataDynamics.ActiveReports.Label()
			Me.lblPolRodDiam = New DataDynamics.ActiveReports.Label()
			Me.txtPolRodDiam = New DataDynamics.ActiveReports.Label()
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
			Me.lblRSFootnote6 = New DataDynamics.ActiveReports.Label()
			CType(Me.lblRodDiam10, ISupportInitialize).BeginInit()
			CType(Me.lblInputData, ISupportInitialize).BeginInit()
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
			CType(Me.lblFLPIP_3, ISupportInitialize).BeginInit()
			CType(Me.lblSPM, ISupportInitialize).BeginInit()
			CType(Me.lblPumpFriction, ISupportInitialize).BeginInit()
			CType(Me.lblPumpEfficiency, ISupportInitialize).BeginInit()
			CType(Me.lblPumpLoadAdj, ISupportInitialize).BeginInit()
			CType(Me.lblTubingAnchorDepth, ISupportInitialize).BeginInit()
			CType(Me.lblDownstrokeFriction, ISupportInitialize).BeginInit()
			CType(Me.lblPumpType, ISupportInitialize).BeginInit()
			CType(Me.lblPumpCondition, ISupportInitialize).BeginInit()
			CType(Me.lblPumpDepth, ISupportInitialize).BeginInit()
			CType(Me.lblTubingPressure, ISupportInitialize).BeginInit()
			CType(Me.lblRodGradeHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrengthHdrTop, ISupportInitialize).BeginInit()
			CType(Me.lblRodLengthHdrTop, ISupportInitialize).BeginInit()
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
			CType(Me.lblRodDiam9, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade9, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength9, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength9, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef9, ISupportInitialize).BeginInit()
			CType(Me.lblRodGrade10, ISupportInitialize).BeginInit()
			CType(Me.lblRodLength10, ISupportInitialize).BeginInit()
			CType(Me.lblRodTensileStrength10, ISupportInitialize).BeginInit()
			CType(Me.lblFricCoef10, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote2, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote5, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote4, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote3, ISupportInitialize).BeginInit()
			CType(Me.lblRSFootnote1, ISupportInitialize).BeginInit()
			CType(Me.lblPolRodDiam, ISupportInitialize).BeginInit()
			CType(Me.txtPolRodDiam, ISupportInitialize).BeginInit()
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
			CType(Me.lblRSFootnote6, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.CanShrink = True
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Controls.AddRange(New ARControl() { Me.lblRodDiam10, Me.linRSInputSep4, Me.linRSInputSep1, Me.linRSInputSep2, Me.linRSInputSep3, Me.Line1, Me.lblInputData, Me.Line3, Me.lblRuntime, Me.lblFLPIP_2, Me.lblFLPIP_1, Me.lblCasingPressure, Me.lblStuffingBoxFriction, Me.lblFluidPropertiesHeader, Me.Line4, Me.lblMotorHeader, Me.Line5, Me.lblPowerMeter, Me.lblWaterCut, Me.lblWaterSPGR, Me.lblElectricityCost, Me.lblMotorType, Me.lblMotorSize, Me.lblMotorSetting, Me.lblOilSPGR, Me.lblFluidSPGR, Me.lblCompressibilityIndex, Me.lblPumpingUnitHeader, Me.Line6, Me.lblAPIDesignation, Me.lblCrankHole, Me.lblPUDimR, Me.lblPUDimA, Me.lblPUDimC, Me.lblPUDimI, Me.lblPUDimK, Me.lblPUDimP, Me.lblPUDimM, Me.lblPUDimV0, Me.lblPUDimS, Me.lblStrokeLength, Me.lblCrankRotation, Me.lblCwtInfo_1, Me.lblCwtInfo_2, Me.lblCwtInfo_3, Me.lblCwtInfo_4, Me.lblCwtInfo_5, Me.lblCBDataFile, Me.lblPumpTubingHeader, Me.Line7, Me.lblTubingOD, Me.lblTubingID, Me.lblPlungerSize, Me.lblRodStringDesign, Me.Line11, Me.lblRodDiamHdrTop, Me.lblRodDiamHdrBot, Me.lblRodDiam1, Me.lblRodGradeHdrBot, Me.lblRodLengthHdrBot, Me.lblRodTensileStrengthHdrBot, Me.lblRodDiam2, Me.lblRodDiam3, Me.lblRodDiam4, Me.lblRodDiam5, Me.lblRodDiam6, Me.lblRodDiam7, Me.lblRodDiam8, Me.lblRodGrade1, Me.lblRodGrade2, Me.lblRodGrade3, Me.lblRodGrade4, Me.lblRodGrade5, Me.lblRodGrade6, Me.lblRodGrade7, Me.lblRodGrade8, Me.lblRodLength1, Me.lblRodLength2, Me.lblRodLength3, Me.lblRodLength4, Me.lblRodLength5, Me.lblRodLength6, Me.lblRodLength7, Me.lblRodLength8, Me.lblRodTensileStrength1, Me.lblRodTensileStrength2, Me.lblRodTensileStrength3, Me.lblRodTensileStrength4, Me.lblRodTensileStrength5, Me.lblRodTensileStrength6, Me.lblRodTensileStrength7, Me.lblRodTensileStrength8, Me.lblFLPIP_3, Me.lblSPM, Me.lblPumpFriction, Me.lblPumpEfficiency, Me.lblPumpLoadAdj, Me.lblTubingAnchorDepth, Me.lblDownstrokeFriction, Me.lblPumpType, Me.lblPumpCondition, Me.lblPumpDepth, Me.lblTubingPressure, Me.lblRodGradeHdrTop, Me.lblRodTensileStrengthHdrTop, Me.lblRodLengthHdrTop, Me.txtTubingOD, Me.txtTubingID, Me.txtPlungerSize, Me.txtPumpType, Me.txtPumpCondition, Me.txtPumpDepth, Me.txtUpstrokeFriction, Me.txtDownstrokeFriction, Me.txtPumpFriction, Me.txtPumpLoadAdj, Me.txtTubingAnchorDepth, Me.txtPumpEfficiency, Me.txtPowerMeter, Me.txtElectricityCost, Me.txtMotorType, Me.txtMotorSize, Me.txtMotorSetting, Me.txtWaterCut, Me.txtWaterSPGR, Me.txtOilSPGR, Me.txtFluidSPGR, Me.txtCompressibilityIndex, Me.txtSPM, Me.txtRuntime, Me.txtTubingPressure, Me.txtCasingPressure, Me.txtFLPIP_1, Me.txtFLPIP_2, Me.txtFLPIP_3, Me.txtStuffingBoxFriction, Me.txtCrankHole, Me.txtStrokeLength, Me.txtCrankRotation, Me.txtCwtInfo_1, Me.txtCwtInfo_2, Me.txtCwtInfo_3, Me.txtCwtInfo_4, Me.txtCwtInfo_5, Me.lblUpstrokeFriction, Me.lblFricCoef1, Me.lblFricCoef2, Me.lblFricCoef3, Me.lblFricCoef4, Me.lblFricCoef5, Me.lblFricCoef6, Me.lblFricCoef7, Me.lblFricCoef8, Me.lblFric, Me.lblCoeff, Me.lblRodDiam9, Me.lblRodGrade9, Me.lblRodLength9, Me.lblRodTensileStrength9, Me.lblFricCoef9, Me.lblRodGrade10, Me.lblRodLength10, Me.lblRodTensileStrength10, Me.lblFricCoef10, Me.Line12, Me.lblRSFootnote2, Me.lblRSFootnote5, Me.lblRSFootnote4, Me.lblRSFootnote3, Me.lblRSFootnote1, Me.lblPolRodDiam, Me.txtPolRodDiam, Me.lblRSFootnote6 })
			Me.Detail.Height = 8.072916F
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.lblRodDiam10.Height = 0.125F
			Me.lblRodDiam10.HyperLink = Nothing
			Me.lblRodDiam10.Left = 0.625F
			Me.lblRodDiam10.Name = "lblRodDiam10"
			Me.lblRodDiam10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam10.Text = "Diam"
			Me.lblRodDiam10.Top = 6.8125F
			Me.lblRodDiam10.Width = 0.8125F
			Me.linRSInputSep4.Height = 1.7F
			Me.linRSInputSep4.Left = 5.875F
			Me.linRSInputSep4.LineWeight = 1F
			Me.linRSInputSep4.Name = "linRSInputSep4"
			Me.linRSInputSep4.Top = 5.3125F
			Me.linRSInputSep4.Width = 0F
			Me.linRSInputSep4.X1 = 5.875F
			Me.linRSInputSep4.X2 = 5.875F
			Me.linRSInputSep4.Y1 = 5.3125F
			Me.linRSInputSep4.Y2 = 7.0125F
			Me.linRSInputSep1.Height = 1.7F
			Me.linRSInputSep1.Left = 1.75F
			Me.linRSInputSep1.LineWeight = 1F
			Me.linRSInputSep1.Name = "linRSInputSep1"
			Me.linRSInputSep1.Top = 5.3125F
			Me.linRSInputSep1.Width = 0F
			Me.linRSInputSep1.X1 = 1.75F
			Me.linRSInputSep1.X2 = 1.75F
			Me.linRSInputSep1.Y1 = 5.3125F
			Me.linRSInputSep1.Y2 = 7.0125F
			Me.linRSInputSep2.Height = 1.699999F
			Me.linRSInputSep2.Left = 3.131944F
			Me.linRSInputSep2.LineWeight = 1F
			Me.linRSInputSep2.Name = "linRSInputSep2"
			Me.linRSInputSep2.Top = 5.319445F
			Me.linRSInputSep2.Width = 0F
			Me.linRSInputSep2.X1 = 3.131944F
			Me.linRSInputSep2.X2 = 3.131944F
			Me.linRSInputSep2.Y1 = 5.319445F
			Me.linRSInputSep2.Y2 = 7.019444F
			Me.linRSInputSep3.Height = 1.7F
			Me.linRSInputSep3.Left = 4.5F
			Me.linRSInputSep3.LineWeight = 1F
			Me.linRSInputSep3.Name = "linRSInputSep3"
			Me.linRSInputSep3.Top = 5.3125F
			Me.linRSInputSep3.Width = 0F
			Me.linRSInputSep3.X1 = 4.5F
			Me.linRSInputSep3.X2 = 4.5F
			Me.linRSInputSep3.Y1 = 5.3125F
			Me.linRSInputSep3.Y2 = 7.0125F
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
			Me.lblInputData.Height = 0.125F
			Me.lblInputData.HyperLink = Nothing
			Me.lblInputData.Left = 0.0625F
			Me.lblInputData.Name = "lblInputData"
			Me.lblInputData.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblInputData.Text = "INPUT DATA"
			Me.lblInputData.Top = 0.125F
			Me.lblInputData.Width = 7.938F
			Me.Line3.Height = 0F
			Me.Line3.Left = 0.0625F
			Me.Line3.LineWeight = 1F
			Me.Line3.Name = "Line3"
			Me.Line3.Top = 0.3F
			Me.Line3.Width = 7.938F
			Me.Line3.X1 = 0.0625F
			Me.Line3.X2 = 8.0005F
			Me.Line3.Y1 = 0.3F
			Me.Line3.Y2 = 0.3F
			Me.lblRuntime.Height = 0.145F
			Me.lblRuntime.HyperLink = Nothing
			Me.lblRuntime.Left = 0.0625F
			Me.lblRuntime.Name = "lblRuntime"
			Me.lblRuntime.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblRuntime.Text = "Run time"
			Me.lblRuntime.Top = 0.4375F
			Me.lblRuntime.Width = 2.4375F
			Me.lblFLPIP_2.Height = 0.145F
			Me.lblFLPIP_2.HyperLink = Nothing
			Me.lblFLPIP_2.Left = 3.5625F
			Me.lblFLPIP_2.Name = "lblFLPIP_2"
			Me.lblFLPIP_2.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblFLPIP_2.Text = "  ft from surface"
			Me.lblFLPIP_2.Top = 0.4375F
			Me.lblFLPIP_2.Width = 2.5625F
			Me.lblFLPIP_1.Height = 0.145F
			Me.lblFLPIP_1.HyperLink = Nothing
			Me.lblFLPIP_1.Left = 3.5625F
			Me.lblFLPIP_1.Name = "lblFLPIP_1"
			Me.lblFLPIP_1.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblFLPIP_1.Text = "Fluid level"
			Me.lblFLPIP_1.Top = 0.3125F
			Me.lblFLPIP_1.Width = 2.5625F
			Me.lblCasingPressure.Height = 0.1875F
			Me.lblCasingPressure.HyperLink = Nothing
			Me.lblCasingPressure.Left = 0.0625F
			Me.lblCasingPressure.Name = "lblCasingPressure"
			Me.lblCasingPressure.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblCasingPressure.Text = "Casing pressure"
			Me.lblCasingPressure.Top = 0.6875F
			Me.lblCasingPressure.Width = 2.4375F
			Me.lblStuffingBoxFriction.Height = 0.1875F
			Me.lblStuffingBoxFriction.HyperLink = Nothing
			Me.lblStuffingBoxFriction.Left = 3.5625F
			Me.lblStuffingBoxFriction.Name = "lblStuffingBoxFriction"
			Me.lblStuffingBoxFriction.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblStuffingBoxFriction.Text = "Stuffing box friction"
			Me.lblStuffingBoxFriction.Top = 0.6875F
			Me.lblStuffingBoxFriction.Width = 2.5625F
			Me.lblFluidPropertiesHeader.Height = 0.15F
			Me.lblFluidPropertiesHeader.HyperLink = Nothing
			Me.lblFluidPropertiesHeader.Left = 0.0625F
			Me.lblFluidPropertiesHeader.Name = "lblFluidPropertiesHeader"
			Me.lblFluidPropertiesHeader.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblFluidPropertiesHeader.Text = "Fluid properties"
			Me.lblFluidPropertiesHeader.Top = 1.0625F
			Me.lblFluidPropertiesHeader.Width = 3.375F
			Me.Line4.Height = 0F
			Me.Line4.Left = 0.0625F
			Me.Line4.LineWeight = 1F
			Me.Line4.Name = "Line4"
			Me.Line4.Top = 1.25F
			Me.Line4.Width = 3.375F
			Me.Line4.X1 = 0.0625F
			Me.Line4.X2 = 3.4375F
			Me.Line4.Y1 = 1.25F
			Me.Line4.Y2 = 1.25F
			Me.lblMotorHeader.Height = 0.15F
			Me.lblMotorHeader.HyperLink = Nothing
			Me.lblMotorHeader.Left = 3.5625F
			Me.lblMotorHeader.Name = "lblMotorHeader"
			Me.lblMotorHeader.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblMotorHeader.Text = "Motor & power meter"
			Me.lblMotorHeader.Top = 1.0625F
			Me.lblMotorHeader.Width = 3.375F
			Me.Line5.Height = 0F
			Me.Line5.Left = 3.5625F
			Me.Line5.LineWeight = 1F
			Me.Line5.Name = "Line5"
			Me.Line5.Top = 1.25F
			Me.Line5.Width = 3.375F
			Me.Line5.X1 = 3.5625F
			Me.Line5.X2 = 6.9375F
			Me.Line5.Y1 = 1.25F
			Me.Line5.Y2 = 1.25F
			Me.lblPowerMeter.Height = 0.145F
			Me.lblPowerMeter.HyperLink = Nothing
			Me.lblPowerMeter.Left = 3.5625F
			Me.lblPowerMeter.Name = "lblPowerMeter"
			Me.lblPowerMeter.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblPowerMeter.Text = "Power meter:"
			Me.lblPowerMeter.Top = 1.3125F
			Me.lblPowerMeter.Width = 2.5625F
			Me.lblWaterCut.Height = 0.145F
			Me.lblWaterCut.HyperLink = Nothing
			Me.lblWaterCut.Left = 0.0625F
			Me.lblWaterCut.Name = "lblWaterCut"
			Me.lblWaterCut.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblWaterCut.Text = "Water cut"
			Me.lblWaterCut.Top = 1.3125F
			Me.lblWaterCut.Width = 2.4375F
			Me.lblWaterSPGR.Height = 0.145F
			Me.lblWaterSPGR.HyperLink = Nothing
			Me.lblWaterSPGR.Left = 0.0625F
			Me.lblWaterSPGR.Name = "lblWaterSPGR"
			Me.lblWaterSPGR.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblWaterSPGR.Text = "Water sp.gr."
			Me.lblWaterSPGR.Top = 1.4375F
			Me.lblWaterSPGR.Width = 2.4375F
			Me.lblElectricityCost.Height = 0.145F
			Me.lblElectricityCost.HyperLink = Nothing
			Me.lblElectricityCost.Left = 3.5625F
			Me.lblElectricityCost.Name = "lblElectricityCost"
			Me.lblElectricityCost.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblElectricityCost.Text = "Electricity cost:"
			Me.lblElectricityCost.Top = 1.4375F
			Me.lblElectricityCost.Width = 2.5625F
			Me.lblMotorType.Height = 0.145F
			Me.lblMotorType.HyperLink = Nothing
			Me.lblMotorType.Left = 3.5625F
			Me.lblMotorType.Name = "lblMotorType"
			Me.lblMotorType.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMotorType.Text = "Motor type"
			Me.lblMotorType.Top = 1.5625F
			Me.lblMotorType.Width = 2.5625F
			Me.lblMotorSize.Height = 0.145F
			Me.lblMotorSize.HyperLink = Nothing
			Me.lblMotorSize.Left = 3.5625F
			Me.lblMotorSize.Name = "lblMotorSize"
			Me.lblMotorSize.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMotorSize.Text = "Motor size"
			Me.lblMotorSize.Top = 1.6875F
			Me.lblMotorSize.Width = 2.5625F
			Me.lblMotorSetting.Height = 0.145F
			Me.lblMotorSetting.HyperLink = Nothing
			Me.lblMotorSetting.Left = 3.5625F
			Me.lblMotorSetting.Name = "lblMotorSetting"
			Me.lblMotorSetting.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblMotorSetting.Text = "Motor setting"
			Me.lblMotorSetting.Top = 1.8125F
			Me.lblMotorSetting.Width = 2.5625F
			Me.lblOilSPGR.Height = 0.145F
			Me.lblOilSPGR.HyperLink = Nothing
			Me.lblOilSPGR.Left = 0.0625F
			Me.lblOilSPGR.Name = "lblOilSPGR"
			Me.lblOilSPGR.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblOilSPGR.Text = "Oil gravity"
			Me.lblOilSPGR.Top = 1.5625F
			Me.lblOilSPGR.Width = 2.4375F
			Me.lblFluidSPGR.Height = 0.145F
			Me.lblFluidSPGR.HyperLink = Nothing
			Me.lblFluidSPGR.Left = 0.0625F
			Me.lblFluidSPGR.Name = "lblFluidSPGR"
			Me.lblFluidSPGR.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblFluidSPGR.Text = "Fluid sp.gr."
			Me.lblFluidSPGR.Top = 1.6875F
			Me.lblFluidSPGR.Width = 2.4375F
			Me.lblCompressibilityIndex.Height = 0.145F
			Me.lblCompressibilityIndex.HyperLink = Nothing
			Me.lblCompressibilityIndex.Left = 0.0625F
			Me.lblCompressibilityIndex.Name = "lblCompressibilityIndex"
			Me.lblCompressibilityIndex.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblCompressibilityIndex.Text = "Compressibility index"
			Me.lblCompressibilityIndex.Top = 1.8125F
			Me.lblCompressibilityIndex.Width = 2.4375F
			Me.lblPumpingUnitHeader.Height = 0.15F
			Me.lblPumpingUnitHeader.HyperLink = Nothing
			Me.lblPumpingUnitHeader.Left = 0.0625F
			Me.lblPumpingUnitHeader.Name = "lblPumpingUnitHeader"
			Me.lblPumpingUnitHeader.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPumpingUnitHeader.Text = "Pumping unit"
			Me.lblPumpingUnitHeader.Top = 2.125F
			Me.lblPumpingUnitHeader.Width = 4.9375F
			Me.Line6.Height = 0F
			Me.Line6.Left = 0.0625F
			Me.Line6.LineWeight = 1F
			Me.Line6.Name = "Line6"
			Me.Line6.Top = 2.3125F
			Me.Line6.Width = 4.9375F
			Me.Line6.X1 = 0.0625F
			Me.Line6.X2 = 5F
			Me.Line6.Y1 = 2.3125F
			Me.Line6.Y2 = 2.3125F
			Me.lblAPIDesignation.Height = 0.145F
			Me.lblAPIDesignation.HyperLink = Nothing
			Me.lblAPIDesignation.Left = 0.0625F
			Me.lblAPIDesignation.Name = "lblAPIDesignation"
			Me.lblAPIDesignation.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblAPIDesignation.Text = "API designation"
			Me.lblAPIDesignation.Top = 2.375F
			Me.lblAPIDesignation.Visible = False
			Me.lblAPIDesignation.Width = 4.25F
			Me.lblCrankHole.Height = 0.145F
			Me.lblCrankHole.HyperLink = Nothing
			Me.lblCrankHole.Left = 0.0625F
			Me.lblCrankHole.Name = "lblCrankHole"
			Me.lblCrankHole.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCrankHole.Text = "Crank hole number"
			Me.lblCrankHole.Top = 2.5F
			Me.lblCrankHole.Visible = False
			Me.lblCrankHole.Width = 2.4375F
			Me.lblPUDimR.Height = 0.145F
			Me.lblPUDimR.HyperLink = Nothing
			Me.lblPUDimR.Left = 3.4375F
			Me.lblPUDimR.Name = "lblPUDimR"
			Me.lblPUDimR.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPUDimR.Text = "R"
			Me.lblPUDimR.Top = 2.5F
			Me.lblPUDimR.Visible = False
			Me.lblPUDimR.Width = 0.75F
			Me.lblPUDimA.Height = 0.145F
			Me.lblPUDimA.HyperLink = Nothing
			Me.lblPUDimA.Left = 3.4375F
			Me.lblPUDimA.Name = "lblPUDimA"
			Me.lblPUDimA.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPUDimA.Text = "A"
			Me.lblPUDimA.Top = 2.625F
			Me.lblPUDimA.Visible = False
			Me.lblPUDimA.Width = 0.75F
			Me.lblPUDimC.Height = 0.145F
			Me.lblPUDimC.HyperLink = Nothing
			Me.lblPUDimC.Left = 3.4375F
			Me.lblPUDimC.Name = "lblPUDimC"
			Me.lblPUDimC.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPUDimC.Text = "C"
			Me.lblPUDimC.Top = 2.75F
			Me.lblPUDimC.Visible = False
			Me.lblPUDimC.Width = 0.75F
			Me.lblPUDimI.Height = 0.145F
			Me.lblPUDimI.HyperLink = Nothing
			Me.lblPUDimI.Left = 3.4375F
			Me.lblPUDimI.Name = "lblPUDimI"
			Me.lblPUDimI.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPUDimI.Text = "I"
			Me.lblPUDimI.Top = 2.875F
			Me.lblPUDimI.Visible = False
			Me.lblPUDimI.Width = 0.75F
			Me.lblPUDimK.Height = 0.145F
			Me.lblPUDimK.HyperLink = Nothing
			Me.lblPUDimK.Left = 3.4375F
			Me.lblPUDimK.Name = "lblPUDimK"
			Me.lblPUDimK.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPUDimK.Text = "K"
			Me.lblPUDimK.Top = 3F
			Me.lblPUDimK.Visible = False
			Me.lblPUDimK.Width = 0.75F
			Me.lblPUDimP.Height = 0.145F
			Me.lblPUDimP.HyperLink = Nothing
			Me.lblPUDimP.Left = 3.4375F
			Me.lblPUDimP.Name = "lblPUDimP"
			Me.lblPUDimP.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPUDimP.Text = "P"
			Me.lblPUDimP.Top = 3.125F
			Me.lblPUDimP.Visible = False
			Me.lblPUDimP.Width = 0.75F
			Me.lblPUDimM.Height = 0.145F
			Me.lblPUDimM.HyperLink = Nothing
			Me.lblPUDimM.Left = 3.4375F
			Me.lblPUDimM.Name = "lblPUDimM"
			Me.lblPUDimM.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPUDimM.Text = "M"
			Me.lblPUDimM.Top = 3.25F
			Me.lblPUDimM.Visible = False
			Me.lblPUDimM.Width = 0.75F
			Me.lblPUDimV0.Height = 0.145F
			Me.lblPUDimV0.HyperLink = Nothing
			Me.lblPUDimV0.Left = 3.4375F
			Me.lblPUDimV0.Name = "lblPUDimV0"
			Me.lblPUDimV0.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPUDimV0.Text = "V0"
			Me.lblPUDimV0.Top = 3.5F
			Me.lblPUDimV0.Visible = False
			Me.lblPUDimV0.Width = 0.75F
			Me.lblPUDimS.Height = 0.145F
			Me.lblPUDimS.HyperLink = Nothing
			Me.lblPUDimS.Left = 3.4375F
			Me.lblPUDimS.Name = "lblPUDimS"
			Me.lblPUDimS.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPUDimS.Text = "S"
			Me.lblPUDimS.Top = 3.375F
			Me.lblPUDimS.Visible = False
			Me.lblPUDimS.Width = 0.75F
			Me.lblStrokeLength.Height = 0.145F
			Me.lblStrokeLength.HyperLink = Nothing
			Me.lblStrokeLength.Left = 0.0625F
			Me.lblStrokeLength.Name = "lblStrokeLength"
			Me.lblStrokeLength.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblStrokeLength.Text = "Calculated stroke length"
			Me.lblStrokeLength.Top = 2.625F
			Me.lblStrokeLength.Visible = False
			Me.lblStrokeLength.Width = 2.4375F
			Me.lblCrankRotation.Height = 0.145F
			Me.lblCrankRotation.HyperLink = Nothing
			Me.lblCrankRotation.Left = 0.0625F
			Me.lblCrankRotation.Name = "lblCrankRotation"
			Me.lblCrankRotation.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCrankRotation.Text = "Crank rotation"
			Me.lblCrankRotation.Top = 2.75F
			Me.lblCrankRotation.Visible = False
			Me.lblCrankRotation.Width = 2.4375F
			Me.lblCwtInfo_1.Height = 0.145F
			Me.lblCwtInfo_1.HyperLink = Nothing
			Me.lblCwtInfo_1.Left = 0.0625F
			Me.lblCwtInfo_1.Name = "lblCwtInfo_1"
			Me.lblCwtInfo_1.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCwtInfo_1.Text = "Counterweight info #1"
			Me.lblCwtInfo_1.Top = 2.875F
			Me.lblCwtInfo_1.Visible = False
			Me.lblCwtInfo_1.Width = 2.4375F
			Me.lblCwtInfo_2.Height = 0.145F
			Me.lblCwtInfo_2.HyperLink = Nothing
			Me.lblCwtInfo_2.Left = 0.0625F
			Me.lblCwtInfo_2.Name = "lblCwtInfo_2"
			Me.lblCwtInfo_2.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCwtInfo_2.Text = "Counterweight info #2"
			Me.lblCwtInfo_2.Top = 3F
			Me.lblCwtInfo_2.Visible = False
			Me.lblCwtInfo_2.Width = 2.4375F
			Me.lblCwtInfo_3.Height = 0.145F
			Me.lblCwtInfo_3.HyperLink = Nothing
			Me.lblCwtInfo_3.Left = 0.0625F
			Me.lblCwtInfo_3.Name = "lblCwtInfo_3"
			Me.lblCwtInfo_3.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCwtInfo_3.Text = "Counterweight info #3"
			Me.lblCwtInfo_3.Top = 3.125F
			Me.lblCwtInfo_3.Visible = False
			Me.lblCwtInfo_3.Width = 2.4375F
			Me.lblCwtInfo_4.Height = 0.145F
			Me.lblCwtInfo_4.HyperLink = Nothing
			Me.lblCwtInfo_4.Left = 0.0625F
			Me.lblCwtInfo_4.Name = "lblCwtInfo_4"
			Me.lblCwtInfo_4.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCwtInfo_4.Text = "Counterweight info #4"
			Me.lblCwtInfo_4.Top = 3.25F
			Me.lblCwtInfo_4.Visible = False
			Me.lblCwtInfo_4.Width = 2.4375F
			Me.lblCwtInfo_5.Height = 0.145F
			Me.lblCwtInfo_5.HyperLink = Nothing
			Me.lblCwtInfo_5.Left = 0.0625F
			Me.lblCwtInfo_5.Name = "lblCwtInfo_5"
			Me.lblCwtInfo_5.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCwtInfo_5.Text = "Counterweight info #5"
			Me.lblCwtInfo_5.Top = 3.375F
			Me.lblCwtInfo_5.Visible = False
			Me.lblCwtInfo_5.Width = 2.4375F
			Me.lblCBDataFile.Height = 0.145F
			Me.lblCBDataFile.HyperLink = Nothing
			Me.lblCBDataFile.Left = 0.0625F
			Me.lblCBDataFile.Name = "lblCBDataFile"
			Me.lblCBDataFile.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblCBDataFile.Text = "CBALANCE file"
			Me.lblCBDataFile.Top = 3.5F
			Me.lblCBDataFile.Visible = False
			Me.lblCBDataFile.Width = 2.4375F
			Me.lblPumpTubingHeader.Height = 0.15F
			Me.lblPumpTubingHeader.HyperLink = Nothing
			Me.lblPumpTubingHeader.Left = 0.0625F
			Me.lblPumpTubingHeader.Name = "lblPumpTubingHeader"
			Me.lblPumpTubingHeader.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPumpTubingHeader.Text = "Tubing and pump information"
			Me.lblPumpTubingHeader.Top = 3.75F
			Me.lblPumpTubingHeader.Width = 6.9375F
			Me.Line7.Height = 0F
			Me.Line7.Left = 0.0625F
			Me.Line7.LineWeight = 1F
			Me.Line7.Name = "Line7"
			Me.Line7.Top = 3.9375F
			Me.Line7.Width = 6.9375F
			Me.Line7.X1 = 0.0625F
			Me.Line7.X2 = 7F
			Me.Line7.Y1 = 3.9375F
			Me.Line7.Y2 = 3.9375F
			Me.lblTubingOD.Height = 0.145F
			Me.lblTubingOD.HyperLink = Nothing
			Me.lblTubingOD.Left = 0.0625F
			Me.lblTubingOD.Name = "lblTubingOD"
			Me.lblTubingOD.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblTubingOD.Text = "Tubing O.D."
			Me.lblTubingOD.Top = 4F
			Me.lblTubingOD.Width = 2.4375F
			Me.lblTubingID.Height = 0.145F
			Me.lblTubingID.HyperLink = Nothing
			Me.lblTubingID.Left = 0.0625F
			Me.lblTubingID.Name = "lblTubingID"
			Me.lblTubingID.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblTubingID.Text = "Tubing I.D."
			Me.lblTubingID.Top = 4.125F
			Me.lblTubingID.Width = 2.4375F
			Me.lblPlungerSize.Height = 0.145F
			Me.lblPlungerSize.HyperLink = Nothing
			Me.lblPlungerSize.Left = 0.0625F
			Me.lblPlungerSize.Name = "lblPlungerSize"
			Me.lblPlungerSize.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPlungerSize.Text = "Plunger size"
			Me.lblPlungerSize.Top = 4.75F
			Me.lblPlungerSize.Width = 2.4375F
			Me.lblRodStringDesign.Height = 0.15F
			Me.lblRodStringDesign.HyperLink = Nothing
			Me.lblRodStringDesign.Left = 0.06944445F
			Me.lblRodStringDesign.Name = "lblRodStringDesign"
			Me.lblRodStringDesign.Style = "background-color: rgb(224,224,224); font-family: Microsoft Sans Serif; font-size: 8pt; text-align: left; white-space: nowrap"
			Me.lblRodStringDesign.Text = "Rod string design"
			Me.lblRodStringDesign.Top = 5.0625F
			Me.lblRodStringDesign.Width = 7.5F
			Me.Line11.Height = 0F
			Me.Line11.Left = 0.06944445F
			Me.Line11.LineWeight = 1F
			Me.Line11.Name = "Line11"
			Me.Line11.Top = 5.25F
			Me.Line11.Width = 7.5F
			Me.Line11.X1 = 0.06944445F
			Me.Line11.X2 = 7.569445F
			Me.Line11.Y1 = 5.25F
			Me.Line11.Y2 = 5.25F
			Me.lblRodDiamHdrTop.Height = 0.145F
			Me.lblRodDiamHdrTop.HyperLink = Nothing
			Me.lblRodDiamHdrTop.Left = 0.4375F
			Me.lblRodDiamHdrTop.Name = "lblRodDiamHdrTop"
			Me.lblRodDiamHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiamHdrTop.Text = "Diameter"
			Me.lblRodDiamHdrTop.Top = 5.3125F
			Me.lblRodDiamHdrTop.Width = 1.25F
			Me.lblRodDiamHdrBot.Height = 0.145F
			Me.lblRodDiamHdrBot.HyperLink = Nothing
			Me.lblRodDiamHdrBot.Left = 0.4375F
			Me.lblRodDiamHdrBot.Name = "lblRodDiamHdrBot"
			Me.lblRodDiamHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodDiamHdrBot.Text = "(inches)"
			Me.lblRodDiamHdrBot.Top = 5.4375F
			Me.lblRodDiamHdrBot.Width = 1.25F
			Me.lblRodDiam1.Height = 0.125F
			Me.lblRodDiam1.HyperLink = Nothing
			Me.lblRodDiam1.Left = 0.625F
			Me.lblRodDiam1.Name = "lblRodDiam1"
			Me.lblRodDiam1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam1.Text = "Diam"
			Me.lblRodDiam1.Top = 5.6875F
			Me.lblRodDiam1.Width = 0.8125F
			Me.lblRodGradeHdrBot.Height = 0.145F
			Me.lblRodGradeHdrBot.HyperLink = Nothing
			Me.lblRodGradeHdrBot.Left = 1.8125F
			Me.lblRodGradeHdrBot.Name = "lblRodGradeHdrBot"
			Me.lblRodGradeHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGradeHdrBot.Text = "Grade"
			Me.lblRodGradeHdrBot.Top = 5.4375F
			Me.lblRodGradeHdrBot.Width = 1.25F
			Me.lblRodLengthHdrBot.Height = 0.145F
			Me.lblRodLengthHdrBot.HyperLink = Nothing
			Me.lblRodLengthHdrBot.Left = 3.1875F
			Me.lblRodLengthHdrBot.Name = "lblRodLengthHdrBot"
			Me.lblRodLengthHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodLengthHdrBot.Text = "(ft)"
			Me.lblRodLengthHdrBot.Top = 5.4375F
			Me.lblRodLengthHdrBot.Width = 1.25F
			Me.lblRodTensileStrengthHdrBot.Height = 0.145F
			Me.lblRodTensileStrengthHdrBot.HyperLink = Nothing
			Me.lblRodTensileStrengthHdrBot.Left = 4.5625F
			Me.lblRodTensileStrengthHdrBot.Name = "lblRodTensileStrengthHdrBot"
			Me.lblRodTensileStrengthHdrBot.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrengthHdrBot.Text = "Strength (psi)"
			Me.lblRodTensileStrengthHdrBot.Top = 5.4375F
			Me.lblRodTensileStrengthHdrBot.Width = 1.25F
			Me.lblRodDiam2.Height = 0.125F
			Me.lblRodDiam2.HyperLink = Nothing
			Me.lblRodDiam2.Left = 0.625F
			Me.lblRodDiam2.Name = "lblRodDiam2"
			Me.lblRodDiam2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam2.Text = "Diam"
			Me.lblRodDiam2.Top = 5.8125F
			Me.lblRodDiam2.Width = 0.8125F
			Me.lblRodDiam3.Height = 0.125F
			Me.lblRodDiam3.HyperLink = Nothing
			Me.lblRodDiam3.Left = 0.625F
			Me.lblRodDiam3.Name = "lblRodDiam3"
			Me.lblRodDiam3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam3.Text = "Diam"
			Me.lblRodDiam3.Top = 5.9375F
			Me.lblRodDiam3.Width = 0.8125F
			Me.lblRodDiam4.Height = 0.125F
			Me.lblRodDiam4.HyperLink = Nothing
			Me.lblRodDiam4.Left = 0.625F
			Me.lblRodDiam4.Name = "lblRodDiam4"
			Me.lblRodDiam4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam4.Text = "Diam"
			Me.lblRodDiam4.Top = 6.0625F
			Me.lblRodDiam4.Width = 0.8125F
			Me.lblRodDiam5.Height = 0.125F
			Me.lblRodDiam5.HyperLink = Nothing
			Me.lblRodDiam5.Left = 0.625F
			Me.lblRodDiam5.Name = "lblRodDiam5"
			Me.lblRodDiam5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam5.Text = "Diam"
			Me.lblRodDiam5.Top = 6.1875F
			Me.lblRodDiam5.Width = 0.8125F
			Me.lblRodDiam6.Height = 0.125F
			Me.lblRodDiam6.HyperLink = Nothing
			Me.lblRodDiam6.Left = 0.625F
			Me.lblRodDiam6.Name = "lblRodDiam6"
			Me.lblRodDiam6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam6.Text = "Diam"
			Me.lblRodDiam6.Top = 6.3125F
			Me.lblRodDiam6.Width = 0.8125F
			Me.lblRodDiam7.Height = 0.125F
			Me.lblRodDiam7.HyperLink = Nothing
			Me.lblRodDiam7.Left = 0.625F
			Me.lblRodDiam7.Name = "lblRodDiam7"
			Me.lblRodDiam7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam7.Text = "Diam"
			Me.lblRodDiam7.Top = 6.4375F
			Me.lblRodDiam7.Width = 0.8125F
			Me.lblRodDiam8.Height = 0.125F
			Me.lblRodDiam8.HyperLink = Nothing
			Me.lblRodDiam8.Left = 0.625F
			Me.lblRodDiam8.Name = "lblRodDiam8"
			Me.lblRodDiam8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam8.Text = "Diam"
			Me.lblRodDiam8.Top = 6.5625F
			Me.lblRodDiam8.Width = 0.8125F
			Me.lblRodGrade1.Height = 0.125F
			Me.lblRodGrade1.HyperLink = Nothing
			Me.lblRodGrade1.Left = 1.8125F
			Me.lblRodGrade1.Name = "lblRodGrade1"
			Me.lblRodGrade1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade1.Text = "Grade"
			Me.lblRodGrade1.Top = 5.6875F
			Me.lblRodGrade1.Width = 1.25F
			Me.lblRodGrade2.Height = 0.125F
			Me.lblRodGrade2.HyperLink = Nothing
			Me.lblRodGrade2.Left = 1.8125F
			Me.lblRodGrade2.Name = "lblRodGrade2"
			Me.lblRodGrade2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade2.Text = "Grade"
			Me.lblRodGrade2.Top = 5.8125F
			Me.lblRodGrade2.Width = 1.25F
			Me.lblRodGrade3.Height = 0.125F
			Me.lblRodGrade3.HyperLink = Nothing
			Me.lblRodGrade3.Left = 1.8125F
			Me.lblRodGrade3.Name = "lblRodGrade3"
			Me.lblRodGrade3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade3.Text = "Grade"
			Me.lblRodGrade3.Top = 5.9375F
			Me.lblRodGrade3.Width = 1.25F
			Me.lblRodGrade4.Height = 0.125F
			Me.lblRodGrade4.HyperLink = Nothing
			Me.lblRodGrade4.Left = 1.8125F
			Me.lblRodGrade4.Name = "lblRodGrade4"
			Me.lblRodGrade4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade4.Text = "Grade"
			Me.lblRodGrade4.Top = 6.0625F
			Me.lblRodGrade4.Width = 1.25F
			Me.lblRodGrade5.Height = 0.125F
			Me.lblRodGrade5.HyperLink = Nothing
			Me.lblRodGrade5.Left = 1.8125F
			Me.lblRodGrade5.Name = "lblRodGrade5"
			Me.lblRodGrade5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade5.Text = "Grade"
			Me.lblRodGrade5.Top = 6.1875F
			Me.lblRodGrade5.Width = 1.25F
			Me.lblRodGrade6.Height = 0.125F
			Me.lblRodGrade6.HyperLink = Nothing
			Me.lblRodGrade6.Left = 1.8125F
			Me.lblRodGrade6.Name = "lblRodGrade6"
			Me.lblRodGrade6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade6.Text = "Grade"
			Me.lblRodGrade6.Top = 6.3125F
			Me.lblRodGrade6.Width = 1.25F
			Me.lblRodGrade7.Height = 0.125F
			Me.lblRodGrade7.HyperLink = Nothing
			Me.lblRodGrade7.Left = 1.8125F
			Me.lblRodGrade7.Name = "lblRodGrade7"
			Me.lblRodGrade7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade7.Text = "Grade"
			Me.lblRodGrade7.Top = 6.4375F
			Me.lblRodGrade7.Width = 1.25F
			Me.lblRodGrade8.Height = 0.125F
			Me.lblRodGrade8.HyperLink = Nothing
			Me.lblRodGrade8.Left = 1.8125F
			Me.lblRodGrade8.Name = "lblRodGrade8"
			Me.lblRodGrade8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade8.Text = "Grade"
			Me.lblRodGrade8.Top = 6.5625F
			Me.lblRodGrade8.Width = 1.25F
			Me.lblRodLength1.Height = 0.125F
			Me.lblRodLength1.HyperLink = Nothing
			Me.lblRodLength1.Left = 3.4375F
			Me.lblRodLength1.Name = "lblRodLength1"
			Me.lblRodLength1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength1.Text = "Len"
			Me.lblRodLength1.Top = 5.6875F
			Me.lblRodLength1.Width = 0.8125F
			Me.lblRodLength2.Height = 0.125F
			Me.lblRodLength2.HyperLink = Nothing
			Me.lblRodLength2.Left = 3.4375F
			Me.lblRodLength2.Name = "lblRodLength2"
			Me.lblRodLength2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength2.Text = "Len"
			Me.lblRodLength2.Top = 5.8125F
			Me.lblRodLength2.Width = 0.8125F
			Me.lblRodLength3.Height = 0.125F
			Me.lblRodLength3.HyperLink = Nothing
			Me.lblRodLength3.Left = 3.4375F
			Me.lblRodLength3.Name = "lblRodLength3"
			Me.lblRodLength3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength3.Text = "Len"
			Me.lblRodLength3.Top = 5.9375F
			Me.lblRodLength3.Width = 0.8125F
			Me.lblRodLength4.Height = 0.125F
			Me.lblRodLength4.HyperLink = Nothing
			Me.lblRodLength4.Left = 3.4375F
			Me.lblRodLength4.Name = "lblRodLength4"
			Me.lblRodLength4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength4.Text = "Len"
			Me.lblRodLength4.Top = 6.0625F
			Me.lblRodLength4.Width = 0.8125F
			Me.lblRodLength5.Height = 0.125F
			Me.lblRodLength5.HyperLink = Nothing
			Me.lblRodLength5.Left = 3.4375F
			Me.lblRodLength5.Name = "lblRodLength5"
			Me.lblRodLength5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength5.Text = "Len"
			Me.lblRodLength5.Top = 6.1875F
			Me.lblRodLength5.Width = 0.8125F
			Me.lblRodLength6.Height = 0.125F
			Me.lblRodLength6.HyperLink = Nothing
			Me.lblRodLength6.Left = 3.4375F
			Me.lblRodLength6.Name = "lblRodLength6"
			Me.lblRodLength6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength6.Text = "Len"
			Me.lblRodLength6.Top = 6.3125F
			Me.lblRodLength6.Width = 0.8125F
			Me.lblRodLength7.Height = 0.125F
			Me.lblRodLength7.HyperLink = Nothing
			Me.lblRodLength7.Left = 3.4375F
			Me.lblRodLength7.Name = "lblRodLength7"
			Me.lblRodLength7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength7.Text = "Len"
			Me.lblRodLength7.Top = 6.4375F
			Me.lblRodLength7.Width = 0.8125F
			Me.lblRodLength8.Height = 0.125F
			Me.lblRodLength8.HyperLink = Nothing
			Me.lblRodLength8.Left = 3.4375F
			Me.lblRodLength8.Name = "lblRodLength8"
			Me.lblRodLength8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength8.Text = "Len"
			Me.lblRodLength8.Top = 6.5625F
			Me.lblRodLength8.Width = 0.8125F
			Me.lblRodTensileStrength1.Height = 0.125F
			Me.lblRodTensileStrength1.HyperLink = Nothing
			Me.lblRodTensileStrength1.Left = 4.75F
			Me.lblRodTensileStrength1.Name = "lblRodTensileStrength1"
			Me.lblRodTensileStrength1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength1.Text = "TS"
			Me.lblRodTensileStrength1.Top = 5.6875F
			Me.lblRodTensileStrength1.Width = 0.8125F
			Me.lblRodTensileStrength2.Height = 0.125F
			Me.lblRodTensileStrength2.HyperLink = Nothing
			Me.lblRodTensileStrength2.Left = 4.75F
			Me.lblRodTensileStrength2.Name = "lblRodTensileStrength2"
			Me.lblRodTensileStrength2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength2.Text = "TS"
			Me.lblRodTensileStrength2.Top = 5.8125F
			Me.lblRodTensileStrength2.Width = 0.8125F
			Me.lblRodTensileStrength3.Height = 0.125F
			Me.lblRodTensileStrength3.HyperLink = Nothing
			Me.lblRodTensileStrength3.Left = 4.75F
			Me.lblRodTensileStrength3.Name = "lblRodTensileStrength3"
			Me.lblRodTensileStrength3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength3.Text = "TS"
			Me.lblRodTensileStrength3.Top = 5.9375F
			Me.lblRodTensileStrength3.Width = 0.8125F
			Me.lblRodTensileStrength4.Height = 0.125F
			Me.lblRodTensileStrength4.HyperLink = Nothing
			Me.lblRodTensileStrength4.Left = 4.75F
			Me.lblRodTensileStrength4.Name = "lblRodTensileStrength4"
			Me.lblRodTensileStrength4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength4.Text = "TS"
			Me.lblRodTensileStrength4.Top = 6.0625F
			Me.lblRodTensileStrength4.Width = 0.8125F
			Me.lblRodTensileStrength5.Height = 0.125F
			Me.lblRodTensileStrength5.HyperLink = Nothing
			Me.lblRodTensileStrength5.Left = 4.75F
			Me.lblRodTensileStrength5.Name = "lblRodTensileStrength5"
			Me.lblRodTensileStrength5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength5.Text = "TS"
			Me.lblRodTensileStrength5.Top = 6.1875F
			Me.lblRodTensileStrength5.Width = 0.8125F
			Me.lblRodTensileStrength6.Height = 0.125F
			Me.lblRodTensileStrength6.HyperLink = Nothing
			Me.lblRodTensileStrength6.Left = 4.75F
			Me.lblRodTensileStrength6.Name = "lblRodTensileStrength6"
			Me.lblRodTensileStrength6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength6.Text = "TS"
			Me.lblRodTensileStrength6.Top = 6.3125F
			Me.lblRodTensileStrength6.Width = 0.8125F
			Me.lblRodTensileStrength7.Height = 0.125F
			Me.lblRodTensileStrength7.HyperLink = Nothing
			Me.lblRodTensileStrength7.Left = 4.75F
			Me.lblRodTensileStrength7.Name = "lblRodTensileStrength7"
			Me.lblRodTensileStrength7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength7.Text = "TS"
			Me.lblRodTensileStrength7.Top = 6.4375F
			Me.lblRodTensileStrength7.Width = 0.8125F
			Me.lblRodTensileStrength8.Height = 0.125F
			Me.lblRodTensileStrength8.HyperLink = Nothing
			Me.lblRodTensileStrength8.Left = 4.75F
			Me.lblRodTensileStrength8.Name = "lblRodTensileStrength8"
			Me.lblRodTensileStrength8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength8.Text = "TS"
			Me.lblRodTensileStrength8.Top = 6.5625F
			Me.lblRodTensileStrength8.Width = 0.8125F
			Me.lblFLPIP_3.Height = 0.145F
			Me.lblFLPIP_3.HyperLink = Nothing
			Me.lblFLPIP_3.Left = 3.5625F
			Me.lblFLPIP_3.Name = "lblFLPIP_3"
			Me.lblFLPIP_3.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblFLPIP_3.Text = "  ft over pump"
			Me.lblFLPIP_3.Top = 0.5625F
			Me.lblFLPIP_3.Width = 2.5625F
			Me.lblSPM.Height = 0.145F
			Me.lblSPM.HyperLink = Nothing
			Me.lblSPM.Left = 0.0625F
			Me.lblSPM.Name = "lblSPM"
			Me.lblSPM.Style = "background-color: rgb(255,255,255); font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblSPM.Text = "Pumping speed"
			Me.lblSPM.Top = 0.3125F
			Me.lblSPM.Width = 2.4375F
			Me.lblPumpFriction.Height = 0.145F
			Me.lblPumpFriction.HyperLink = Nothing
			Me.lblPumpFriction.Left = 3.5625F
			Me.lblPumpFriction.Name = "lblPumpFriction"
			Me.lblPumpFriction.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPumpFriction.Text = "Pump friction"
			Me.lblPumpFriction.Top = 4.75F
			Me.lblPumpFriction.Width = 2.5625F
			Me.lblPumpEfficiency.Height = 0.145F
			Me.lblPumpEfficiency.HyperLink = Nothing
			Me.lblPumpEfficiency.Left = 3.5625F
			Me.lblPumpEfficiency.Name = "lblPumpEfficiency"
			Me.lblPumpEfficiency.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPumpEfficiency.Text = "Pump vol. efficiency "
			Me.lblPumpEfficiency.Top = 4.625F
			Me.lblPumpEfficiency.Width = 2.5625F
			Me.lblPumpLoadAdj.Height = 0.145F
			Me.lblPumpLoadAdj.HyperLink = Nothing
			Me.lblPumpLoadAdj.Left = 3.5625F
			Me.lblPumpLoadAdj.Name = "lblPumpLoadAdj"
			Me.lblPumpLoadAdj.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPumpLoadAdj.Text = "Pump load adjustment"
			Me.lblPumpLoadAdj.Top = 4.5F
			Me.lblPumpLoadAdj.Width = 2.5625F
			Me.lblTubingAnchorDepth.Height = 0.145F
			Me.lblTubingAnchorDepth.HyperLink = Nothing
			Me.lblTubingAnchorDepth.Left = 3.5625F
			Me.lblTubingAnchorDepth.Name = "lblTubingAnchorDepth"
			Me.lblTubingAnchorDepth.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblTubingAnchorDepth.Text = "Tubing anchor depth"
			Me.lblTubingAnchorDepth.Top = 4.375F
			Me.lblTubingAnchorDepth.Width = 2.5625F
			Me.lblDownstrokeFriction.Height = 0.145F
			Me.lblDownstrokeFriction.HyperLink = Nothing
			Me.lblDownstrokeFriction.Left = 3.5625F
			Me.lblDownstrokeFriction.Name = "lblDownstrokeFriction"
			Me.lblDownstrokeFriction.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblDownstrokeFriction.Text = "Downstroke rod-fluid damp"
			Me.lblDownstrokeFriction.Top = 4.125F
			Me.lblDownstrokeFriction.Width = 2.5625F
			Me.lblPumpType.Height = 0.145F
			Me.lblPumpType.HyperLink = Nothing
			Me.lblPumpType.Left = 0.0625F
			Me.lblPumpType.Name = "lblPumpType"
			Me.lblPumpType.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPumpType.Text = "Pump type"
			Me.lblPumpType.Top = 4.625F
			Me.lblPumpType.Width = 2.4375F
			Me.lblPumpCondition.Height = 0.145F
			Me.lblPumpCondition.HyperLink = Nothing
			Me.lblPumpCondition.Left = 0.0625F
			Me.lblPumpCondition.Name = "lblPumpCondition"
			Me.lblPumpCondition.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPumpCondition.Text = "Pump condition"
			Me.lblPumpCondition.Top = 4.5F
			Me.lblPumpCondition.Width = 2.4375F
			Me.lblPumpDepth.Height = 0.145F
			Me.lblPumpDepth.HyperLink = Nothing
			Me.lblPumpDepth.Left = 0.0625F
			Me.lblPumpDepth.Name = "lblPumpDepth"
			Me.lblPumpDepth.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblPumpDepth.Text = "Pump depth"
			Me.lblPumpDepth.Top = 4.375F
			Me.lblPumpDepth.Width = 2.4375F
			Me.lblTubingPressure.Height = 0.145F
			Me.lblTubingPressure.HyperLink = Nothing
			Me.lblTubingPressure.Left = 0.0625F
			Me.lblTubingPressure.Name = "lblTubingPressure"
			Me.lblTubingPressure.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblTubingPressure.Text = "Tubing pressure"
			Me.lblTubingPressure.Top = 0.5625F
			Me.lblTubingPressure.Width = 2.4375F
			Me.lblRodGradeHdrTop.Height = 0.145F
			Me.lblRodGradeHdrTop.HyperLink = Nothing
			Me.lblRodGradeHdrTop.Left = 1.8125F
			Me.lblRodGradeHdrTop.Name = "lblRodGradeHdrTop"
			Me.lblRodGradeHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodGradeHdrTop.Text = "Rod"
			Me.lblRodGradeHdrTop.Top = 5.3125F
			Me.lblRodGradeHdrTop.Width = 1.25F
			Me.lblRodTensileStrengthHdrTop.Height = 0.145F
			Me.lblRodTensileStrengthHdrTop.HyperLink = Nothing
			Me.lblRodTensileStrengthHdrTop.Left = 4.5625F
			Me.lblRodTensileStrengthHdrTop.Name = "lblRodTensileStrengthHdrTop"
			Me.lblRodTensileStrengthHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrengthHdrTop.Text = "Tensile"
			Me.lblRodTensileStrengthHdrTop.Top = 5.3125F
			Me.lblRodTensileStrengthHdrTop.Width = 1.25F
			Me.lblRodLengthHdrTop.Height = 0.145F
			Me.lblRodLengthHdrTop.HyperLink = Nothing
			Me.lblRodLengthHdrTop.Left = 3.1875F
			Me.lblRodLengthHdrTop.Name = "lblRodLengthHdrTop"
			Me.lblRodLengthHdrTop.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblRodLengthHdrTop.Text = "Length"
			Me.lblRodLengthHdrTop.Top = 5.3125F
			Me.lblRodLengthHdrTop.Width = 1.25F
			Me.txtTubingOD.Height = 0.145F
			Me.txtTubingOD.HyperLink = Nothing
			Me.txtTubingOD.Left = 2.5625F
			Me.txtTubingOD.Name = "txtTubingOD"
			Me.txtTubingOD.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtTubingOD.Text = ""
			Me.txtTubingOD.Top = 4F
			Me.txtTubingOD.Width = 0.75F
			Me.txtTubingID.Height = 0.145F
			Me.txtTubingID.HyperLink = Nothing
			Me.txtTubingID.Left = 2.5625F
			Me.txtTubingID.Name = "txtTubingID"
			Me.txtTubingID.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtTubingID.Text = ""
			Me.txtTubingID.Top = 4.125F
			Me.txtTubingID.Width = 0.75F
			Me.txtPlungerSize.Height = 0.145F
			Me.txtPlungerSize.HyperLink = Nothing
			Me.txtPlungerSize.Left = 2.5625F
			Me.txtPlungerSize.Name = "txtPlungerSize"
			Me.txtPlungerSize.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtPlungerSize.Text = ""
			Me.txtPlungerSize.Top = 4.75F
			Me.txtPlungerSize.Width = 0.75F
			Me.txtPumpType.Height = 0.145F
			Me.txtPumpType.HyperLink = Nothing
			Me.txtPumpType.Left = 2.5625F
			Me.txtPumpType.Name = "txtPumpType"
			Me.txtPumpType.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtPumpType.Text = ""
			Me.txtPumpType.Top = 4.625F
			Me.txtPumpType.Width = 0.75F
			Me.txtPumpCondition.Height = 0.145F
			Me.txtPumpCondition.HyperLink = Nothing
			Me.txtPumpCondition.Left = 2.5625F
			Me.txtPumpCondition.Name = "txtPumpCondition"
			Me.txtPumpCondition.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtPumpCondition.Text = ""
			Me.txtPumpCondition.Top = 4.5F
			Me.txtPumpCondition.Width = 0.75F
			Me.txtPumpDepth.Height = 0.145F
			Me.txtPumpDepth.HyperLink = Nothing
			Me.txtPumpDepth.Left = 2.5625F
			Me.txtPumpDepth.Name = "txtPumpDepth"
			Me.txtPumpDepth.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtPumpDepth.Text = ""
			Me.txtPumpDepth.Top = 4.375F
			Me.txtPumpDepth.Width = 0.75F
			Me.txtUpstrokeFriction.Height = 0.145F
			Me.txtUpstrokeFriction.HyperLink = Nothing
			Me.txtUpstrokeFriction.Left = 6.1875F
			Me.txtUpstrokeFriction.Name = "txtUpstrokeFriction"
			Me.txtUpstrokeFriction.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtUpstrokeFriction.Text = ""
			Me.txtUpstrokeFriction.Top = 4F
			Me.txtUpstrokeFriction.Width = 0.75F
			Me.txtDownstrokeFriction.Height = 0.145F
			Me.txtDownstrokeFriction.HyperLink = Nothing
			Me.txtDownstrokeFriction.Left = 6.1875F
			Me.txtDownstrokeFriction.Name = "txtDownstrokeFriction"
			Me.txtDownstrokeFriction.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtDownstrokeFriction.Text = ""
			Me.txtDownstrokeFriction.Top = 4.125F
			Me.txtDownstrokeFriction.Width = 0.75F
			Me.txtPumpFriction.Height = 0.145F
			Me.txtPumpFriction.HyperLink = Nothing
			Me.txtPumpFriction.Left = 6.1875F
			Me.txtPumpFriction.Name = "txtPumpFriction"
			Me.txtPumpFriction.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtPumpFriction.Text = ""
			Me.txtPumpFriction.Top = 4.75F
			Me.txtPumpFriction.Width = 0.75F
			Me.txtPumpLoadAdj.Height = 0.145F
			Me.txtPumpLoadAdj.HyperLink = Nothing
			Me.txtPumpLoadAdj.Left = 6.1875F
			Me.txtPumpLoadAdj.Name = "txtPumpLoadAdj"
			Me.txtPumpLoadAdj.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtPumpLoadAdj.Text = ""
			Me.txtPumpLoadAdj.Top = 4.5F
			Me.txtPumpLoadAdj.Width = 0.75F
			Me.txtTubingAnchorDepth.Height = 0.145F
			Me.txtTubingAnchorDepth.HyperLink = Nothing
			Me.txtTubingAnchorDepth.Left = 6.1875F
			Me.txtTubingAnchorDepth.Name = "txtTubingAnchorDepth"
			Me.txtTubingAnchorDepth.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtTubingAnchorDepth.Text = ""
			Me.txtTubingAnchorDepth.Top = 4.375F
			Me.txtTubingAnchorDepth.Width = 0.75F
			Me.txtPumpEfficiency.Height = 0.145F
			Me.txtPumpEfficiency.HyperLink = Nothing
			Me.txtPumpEfficiency.Left = 6.1875F
			Me.txtPumpEfficiency.Name = "txtPumpEfficiency"
			Me.txtPumpEfficiency.Style = "background-color: rgb(255,255,255); font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtPumpEfficiency.Text = ""
			Me.txtPumpEfficiency.Top = 4.625F
			Me.txtPumpEfficiency.Width = 0.75F
			Me.txtPowerMeter.Height = 0.145F
			Me.txtPowerMeter.HyperLink = Nothing
			Me.txtPowerMeter.Left = 6.1875F
			Me.txtPowerMeter.Name = "txtPowerMeter"
			Me.txtPowerMeter.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtPowerMeter.Text = ""
			Me.txtPowerMeter.Top = 1.3125F
			Me.txtPowerMeter.Width = 0.75F
			Me.txtElectricityCost.Height = 0.145F
			Me.txtElectricityCost.HyperLink = Nothing
			Me.txtElectricityCost.Left = 6.1875F
			Me.txtElectricityCost.Name = "txtElectricityCost"
			Me.txtElectricityCost.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtElectricityCost.Text = ""
			Me.txtElectricityCost.Top = 1.4375F
			Me.txtElectricityCost.Width = 0.75F
			Me.txtMotorType.Height = 0.145F
			Me.txtMotorType.HyperLink = Nothing
			Me.txtMotorType.Left = 6.1875F
			Me.txtMotorType.Name = "txtMotorType"
			Me.txtMotorType.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtMotorType.Text = ""
			Me.txtMotorType.Top = 1.5625F
			Me.txtMotorType.Width = 0.75F
			Me.txtMotorSize.Height = 0.145F
			Me.txtMotorSize.HyperLink = Nothing
			Me.txtMotorSize.Left = 6.1875F
			Me.txtMotorSize.Name = "txtMotorSize"
			Me.txtMotorSize.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtMotorSize.Text = ""
			Me.txtMotorSize.Top = 1.6875F
			Me.txtMotorSize.Width = 0.75F
			Me.txtMotorSetting.Height = 0.145F
			Me.txtMotorSetting.HyperLink = Nothing
			Me.txtMotorSetting.Left = 6.1875F
			Me.txtMotorSetting.Name = "txtMotorSetting"
			Me.txtMotorSetting.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtMotorSetting.Text = ""
			Me.txtMotorSetting.Top = 1.8125F
			Me.txtMotorSetting.Width = 0.75F
			Me.txtWaterCut.Height = 0.145F
			Me.txtWaterCut.HyperLink = Nothing
			Me.txtWaterCut.Left = 2.5625F
			Me.txtWaterCut.Name = "txtWaterCut"
			Me.txtWaterCut.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtWaterCut.Text = ""
			Me.txtWaterCut.Top = 1.3125F
			Me.txtWaterCut.Width = 0.75F
			Me.txtWaterSPGR.Height = 0.145F
			Me.txtWaterSPGR.HyperLink = Nothing
			Me.txtWaterSPGR.Left = 2.5625F
			Me.txtWaterSPGR.Name = "txtWaterSPGR"
			Me.txtWaterSPGR.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtWaterSPGR.Text = ""
			Me.txtWaterSPGR.Top = 1.4375F
			Me.txtWaterSPGR.Width = 0.75F
			Me.txtOilSPGR.Height = 0.145F
			Me.txtOilSPGR.HyperLink = Nothing
			Me.txtOilSPGR.Left = 2.5625F
			Me.txtOilSPGR.Name = "txtOilSPGR"
			Me.txtOilSPGR.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtOilSPGR.Text = ""
			Me.txtOilSPGR.Top = 1.5625F
			Me.txtOilSPGR.Width = 0.75F
			Me.txtFluidSPGR.Height = 0.145F
			Me.txtFluidSPGR.HyperLink = Nothing
			Me.txtFluidSPGR.Left = 2.5625F
			Me.txtFluidSPGR.Name = "txtFluidSPGR"
			Me.txtFluidSPGR.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtFluidSPGR.Text = ""
			Me.txtFluidSPGR.Top = 1.6875F
			Me.txtFluidSPGR.Width = 0.75F
			Me.txtCompressibilityIndex.Height = 0.145F
			Me.txtCompressibilityIndex.HyperLink = Nothing
			Me.txtCompressibilityIndex.Left = 2.5625F
			Me.txtCompressibilityIndex.Name = "txtCompressibilityIndex"
			Me.txtCompressibilityIndex.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtCompressibilityIndex.Text = ""
			Me.txtCompressibilityIndex.Top = 1.8125F
			Me.txtCompressibilityIndex.Width = 0.75F
			Me.txtSPM.Height = 0.145F
			Me.txtSPM.HyperLink = Nothing
			Me.txtSPM.Left = 2.5625F
			Me.txtSPM.Name = "txtSPM"
			Me.txtSPM.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtSPM.Text = ""
			Me.txtSPM.Top = 0.3125F
			Me.txtSPM.Width = 0.75F
			Me.txtRuntime.Height = 0.145F
			Me.txtRuntime.HyperLink = Nothing
			Me.txtRuntime.Left = 2.5625F
			Me.txtRuntime.Name = "txtRuntime"
			Me.txtRuntime.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtRuntime.Text = ""
			Me.txtRuntime.Top = 0.4375F
			Me.txtRuntime.Width = 0.75F
			Me.txtTubingPressure.Height = 0.145F
			Me.txtTubingPressure.HyperLink = Nothing
			Me.txtTubingPressure.Left = 2.5625F
			Me.txtTubingPressure.Name = "txtTubingPressure"
			Me.txtTubingPressure.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtTubingPressure.Text = ""
			Me.txtTubingPressure.Top = 0.5625F
			Me.txtTubingPressure.Width = 0.75F
			Me.txtCasingPressure.Height = 0.145F
			Me.txtCasingPressure.HyperLink = Nothing
			Me.txtCasingPressure.Left = 2.5625F
			Me.txtCasingPressure.Name = "txtCasingPressure"
			Me.txtCasingPressure.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtCasingPressure.Text = ""
			Me.txtCasingPressure.Top = 0.6875F
			Me.txtCasingPressure.Width = 0.75F
			Me.txtFLPIP_1.Height = 0.145F
			Me.txtFLPIP_1.HyperLink = Nothing
			Me.txtFLPIP_1.Left = 6.1875F
			Me.txtFLPIP_1.Name = "txtFLPIP_1"
			Me.txtFLPIP_1.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtFLPIP_1.Text = ""
			Me.txtFLPIP_1.Top = 0.3125F
			Me.txtFLPIP_1.Width = 0.75F
			Me.txtFLPIP_2.Height = 0.145F
			Me.txtFLPIP_2.HyperLink = Nothing
			Me.txtFLPIP_2.Left = 6.1875F
			Me.txtFLPIP_2.Name = "txtFLPIP_2"
			Me.txtFLPIP_2.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtFLPIP_2.Text = ""
			Me.txtFLPIP_2.Top = 0.4375F
			Me.txtFLPIP_2.Width = 0.75F
			Me.txtFLPIP_3.Height = 0.145F
			Me.txtFLPIP_3.HyperLink = Nothing
			Me.txtFLPIP_3.Left = 6.1875F
			Me.txtFLPIP_3.Name = "txtFLPIP_3"
			Me.txtFLPIP_3.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtFLPIP_3.Text = ""
			Me.txtFLPIP_3.Top = 0.5625F
			Me.txtFLPIP_3.Width = 0.75F
			Me.txtStuffingBoxFriction.Height = 0.145F
			Me.txtStuffingBoxFriction.HyperLink = Nothing
			Me.txtStuffingBoxFriction.Left = 6.1875F
			Me.txtStuffingBoxFriction.Name = "txtStuffingBoxFriction"
			Me.txtStuffingBoxFriction.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtStuffingBoxFriction.Text = ""
			Me.txtStuffingBoxFriction.Top = 0.6875F
			Me.txtStuffingBoxFriction.Width = 0.75F
			Me.txtCrankHole.Height = 0.145F
			Me.txtCrankHole.HyperLink = Nothing
			Me.txtCrankHole.Left = 2.5625F
			Me.txtCrankHole.Name = "txtCrankHole"
			Me.txtCrankHole.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtCrankHole.Text = ""
			Me.txtCrankHole.Top = 2.5F
			Me.txtCrankHole.Visible = False
			Me.txtCrankHole.Width = 0.75F
			Me.txtStrokeLength.Height = 0.145F
			Me.txtStrokeLength.HyperLink = Nothing
			Me.txtStrokeLength.Left = 2.5625F
			Me.txtStrokeLength.Name = "txtStrokeLength"
			Me.txtStrokeLength.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtStrokeLength.Text = ""
			Me.txtStrokeLength.Top = 2.625F
			Me.txtStrokeLength.Visible = False
			Me.txtStrokeLength.Width = 0.75F
			Me.txtCrankRotation.Height = 0.145F
			Me.txtCrankRotation.HyperLink = Nothing
			Me.txtCrankRotation.Left = 2.5625F
			Me.txtCrankRotation.Name = "txtCrankRotation"
			Me.txtCrankRotation.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtCrankRotation.Text = ""
			Me.txtCrankRotation.Top = 2.75F
			Me.txtCrankRotation.Visible = False
			Me.txtCrankRotation.Width = 0.75F
			Me.txtCwtInfo_1.Height = 0.145F
			Me.txtCwtInfo_1.HyperLink = Nothing
			Me.txtCwtInfo_1.Left = 2.5625F
			Me.txtCwtInfo_1.Name = "txtCwtInfo_1"
			Me.txtCwtInfo_1.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtCwtInfo_1.Text = ""
			Me.txtCwtInfo_1.Top = 2.875F
			Me.txtCwtInfo_1.Visible = False
			Me.txtCwtInfo_1.Width = 0.75F
			Me.txtCwtInfo_2.Height = 0.145F
			Me.txtCwtInfo_2.HyperLink = Nothing
			Me.txtCwtInfo_2.Left = 2.5625F
			Me.txtCwtInfo_2.Name = "txtCwtInfo_2"
			Me.txtCwtInfo_2.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtCwtInfo_2.Text = ""
			Me.txtCwtInfo_2.Top = 3F
			Me.txtCwtInfo_2.Visible = False
			Me.txtCwtInfo_2.Width = 0.75F
			Me.txtCwtInfo_3.Height = 0.145F
			Me.txtCwtInfo_3.HyperLink = Nothing
			Me.txtCwtInfo_3.Left = 2.5625F
			Me.txtCwtInfo_3.Name = "txtCwtInfo_3"
			Me.txtCwtInfo_3.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtCwtInfo_3.Text = ""
			Me.txtCwtInfo_3.Top = 3.125F
			Me.txtCwtInfo_3.Visible = False
			Me.txtCwtInfo_3.Width = 0.75F
			Me.txtCwtInfo_4.Height = 0.145F
			Me.txtCwtInfo_4.HyperLink = Nothing
			Me.txtCwtInfo_4.Left = 2.5625F
			Me.txtCwtInfo_4.Name = "txtCwtInfo_4"
			Me.txtCwtInfo_4.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtCwtInfo_4.Text = ""
			Me.txtCwtInfo_4.Top = 3.25F
			Me.txtCwtInfo_4.Visible = False
			Me.txtCwtInfo_4.Width = 0.75F
			Me.txtCwtInfo_5.Height = 0.145F
			Me.txtCwtInfo_5.HyperLink = Nothing
			Me.txtCwtInfo_5.Left = 2.5625F
			Me.txtCwtInfo_5.Name = "txtCwtInfo_5"
			Me.txtCwtInfo_5.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.txtCwtInfo_5.Text = ""
			Me.txtCwtInfo_5.Top = 3.375F
			Me.txtCwtInfo_5.Visible = False
			Me.txtCwtInfo_5.Width = 0.75F
			Me.lblUpstrokeFriction.Height = 0.145F
			Me.lblUpstrokeFriction.HyperLink = Nothing
			Me.lblUpstrokeFriction.Left = 3.5625F
			Me.lblUpstrokeFriction.Name = "lblUpstrokeFriction"
			Me.lblUpstrokeFriction.Style = "font-family: Microsoft Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblUpstrokeFriction.Text = "Upstroke rod-fluid damp"
			Me.lblUpstrokeFriction.Top = 4F
			Me.lblUpstrokeFriction.Width = 2.5625F
			Me.lblFricCoef1.Height = 0.125F
			Me.lblFricCoef1.HyperLink = Nothing
			Me.lblFricCoef1.Left = 6.1875F
			Me.lblFricCoef1.Name = "lblFricCoef1"
			Me.lblFricCoef1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef1.Text = ""
			Me.lblFricCoef1.Top = 5.6875F
			Me.lblFricCoef1.Width = 0.8125F
			Me.lblFricCoef2.Height = 0.125F
			Me.lblFricCoef2.HyperLink = Nothing
			Me.lblFricCoef2.Left = 6.1875F
			Me.lblFricCoef2.Name = "lblFricCoef2"
			Me.lblFricCoef2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef2.Text = ""
			Me.lblFricCoef2.Top = 5.8125F
			Me.lblFricCoef2.Width = 0.8125F
			Me.lblFricCoef3.Height = 0.125F
			Me.lblFricCoef3.HyperLink = Nothing
			Me.lblFricCoef3.Left = 6.1875F
			Me.lblFricCoef3.Name = "lblFricCoef3"
			Me.lblFricCoef3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef3.Text = ""
			Me.lblFricCoef3.Top = 5.9375F
			Me.lblFricCoef3.Width = 0.8125F
			Me.lblFricCoef4.Height = 0.125F
			Me.lblFricCoef4.HyperLink = Nothing
			Me.lblFricCoef4.Left = 6.1875F
			Me.lblFricCoef4.Name = "lblFricCoef4"
			Me.lblFricCoef4.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef4.Text = ""
			Me.lblFricCoef4.Top = 6.0625F
			Me.lblFricCoef4.Width = 0.8125F
			Me.lblFricCoef5.Height = 0.125F
			Me.lblFricCoef5.HyperLink = Nothing
			Me.lblFricCoef5.Left = 6.1875F
			Me.lblFricCoef5.Name = "lblFricCoef5"
			Me.lblFricCoef5.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef5.Text = ""
			Me.lblFricCoef5.Top = 6.1875F
			Me.lblFricCoef5.Width = 0.8125F
			Me.lblFricCoef6.Height = 0.125F
			Me.lblFricCoef6.HyperLink = Nothing
			Me.lblFricCoef6.Left = 6.1875F
			Me.lblFricCoef6.Name = "lblFricCoef6"
			Me.lblFricCoef6.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef6.Text = ""
			Me.lblFricCoef6.Top = 6.3125F
			Me.lblFricCoef6.Width = 0.8125F
			Me.lblFricCoef7.Height = 0.125F
			Me.lblFricCoef7.HyperLink = Nothing
			Me.lblFricCoef7.Left = 6.1875F
			Me.lblFricCoef7.Name = "lblFricCoef7"
			Me.lblFricCoef7.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef7.Text = ""
			Me.lblFricCoef7.Top = 6.4375F
			Me.lblFricCoef7.Width = 0.8125F
			Me.lblFricCoef8.Height = 0.125F
			Me.lblFricCoef8.HyperLink = Nothing
			Me.lblFricCoef8.Left = 6.1875F
			Me.lblFricCoef8.Name = "lblFricCoef8"
			Me.lblFricCoef8.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef8.Text = ""
			Me.lblFricCoef8.Top = 6.5625F
			Me.lblFricCoef8.Width = 0.8125F
			Me.lblFric.Height = 0.145F
			Me.lblFric.HyperLink = Nothing
			Me.lblFric.Left = 5.9375F
			Me.lblFric.Name = "lblFric"
			Me.lblFric.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblFric.Text = " Friction"
			Me.lblFric.Top = 5.3125F
			Me.lblFric.Width = 1.25F
			Me.lblCoeff.Height = 0.145F
			Me.lblCoeff.HyperLink = Nothing
			Me.lblCoeff.Left = 5.9375F
			Me.lblCoeff.Name = "lblCoeff"
			Me.lblCoeff.Style = "background-color: rgb(224,224,224); font-family: MS Sans Serif; font-size: 8pt; text-align: center; white-space: nowrap"
			Me.lblCoeff.Text = "Coefficient"
			Me.lblCoeff.Top = 5.4375F
			Me.lblCoeff.Width = 1.25F
			Me.lblRodDiam9.Height = 0.125F
			Me.lblRodDiam9.HyperLink = Nothing
			Me.lblRodDiam9.Left = 0.625F
			Me.lblRodDiam9.Name = "lblRodDiam9"
			Me.lblRodDiam9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRodDiam9.Text = "Diam"
			Me.lblRodDiam9.Top = 6.6875F
			Me.lblRodDiam9.Width = 0.8125F
			Me.lblRodGrade9.Height = 0.125F
			Me.lblRodGrade9.HyperLink = Nothing
			Me.lblRodGrade9.Left = 1.8125F
			Me.lblRodGrade9.Name = "lblRodGrade9"
			Me.lblRodGrade9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade9.Text = "Grade"
			Me.lblRodGrade9.Top = 6.6875F
			Me.lblRodGrade9.Width = 1.25F
			Me.lblRodLength9.Height = 0.125F
			Me.lblRodLength9.HyperLink = Nothing
			Me.lblRodLength9.Left = 3.4375F
			Me.lblRodLength9.Name = "lblRodLength9"
			Me.lblRodLength9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength9.Text = "Len"
			Me.lblRodLength9.Top = 6.6875F
			Me.lblRodLength9.Width = 0.8125F
			Me.lblRodTensileStrength9.Height = 0.125F
			Me.lblRodTensileStrength9.HyperLink = Nothing
			Me.lblRodTensileStrength9.Left = 4.75F
			Me.lblRodTensileStrength9.Name = "lblRodTensileStrength9"
			Me.lblRodTensileStrength9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength9.Text = "TS"
			Me.lblRodTensileStrength9.Top = 6.6875F
			Me.lblRodTensileStrength9.Width = 0.8125F
			Me.lblFricCoef9.Height = 0.125F
			Me.lblFricCoef9.HyperLink = Nothing
			Me.lblFricCoef9.Left = 6.1875F
			Me.lblFricCoef9.Name = "lblFricCoef9"
			Me.lblFricCoef9.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef9.Text = ""
			Me.lblFricCoef9.Top = 6.6875F
			Me.lblFricCoef9.Width = 0.8125F
			Me.lblRodGrade10.Height = 0.125F
			Me.lblRodGrade10.HyperLink = Nothing
			Me.lblRodGrade10.Left = 1.8125F
			Me.lblRodGrade10.Name = "lblRodGrade10"
			Me.lblRodGrade10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodGrade10.Text = "Grade"
			Me.lblRodGrade10.Top = 6.8125F
			Me.lblRodGrade10.Width = 1.25F
			Me.lblRodLength10.Height = 0.125F
			Me.lblRodLength10.HyperLink = Nothing
			Me.lblRodLength10.Left = 3.4375F
			Me.lblRodLength10.Name = "lblRodLength10"
			Me.lblRodLength10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: right; white-space: nowrap"
			Me.lblRodLength10.Text = "Len"
			Me.lblRodLength10.Top = 6.8125F
			Me.lblRodLength10.Width = 0.8125F
			Me.lblRodTensileStrength10.Height = 0.125F
			Me.lblRodTensileStrength10.HyperLink = Nothing
			Me.lblRodTensileStrength10.Left = 4.75F
			Me.lblRodTensileStrength10.Name = "lblRodTensileStrength10"
			Me.lblRodTensileStrength10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblRodTensileStrength10.Text = "TS"
			Me.lblRodTensileStrength10.Top = 6.8125F
			Me.lblRodTensileStrength10.Width = 0.8125F
			Me.lblFricCoef10.Height = 0.125F
			Me.lblFricCoef10.HyperLink = Nothing
			Me.lblFricCoef10.Left = 6.1875F
			Me.lblFricCoef10.Name = "lblFricCoef10"
			Me.lblFricCoef10.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: center; white-space: nowrap"
			Me.lblFricCoef10.Text = ""
			Me.lblFricCoef10.Top = 6.8125F
			Me.lblFricCoef10.Width = 0.8125F
			Me.Line12.Height = 0F
			Me.Line12.Left = 0.3755F
			Me.Line12.LineWeight = 1F
			Me.Line12.Name = "Line12"
			Me.Line12.Top = 5.625F
			Me.Line12.Width = 7.15F
			Me.Line12.X1 = 0.3755F
			Me.Line12.X2 = 7.5255F
			Me.Line12.Y1 = 5.625F
			Me.Line12.Y2 = 5.625F
			Me.lblRSFootnote2.Height = 0.15F
			Me.lblRSFootnote2.HyperLink = Nothing
			Me.lblRSFootnote2.Left = 0.063F
			Me.lblRSFootnote2.Name = "lblRSFootnote2"
			Me.lblRSFootnote2.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRSFootnote2.Text = "Rod string trailer"
			Me.lblRSFootnote2.Top = 7.1875F
			Me.lblRSFootnote2.Visible = False
			Me.lblRSFootnote2.Width = 7.75F
			Me.lblRSFootnote5.Height = 0.15F
			Me.lblRSFootnote5.HyperLink = Nothing
			Me.lblRSFootnote5.Left = 0.063F
			Me.lblRSFootnote5.Name = "lblRSFootnote5"
			Me.lblRSFootnote5.Style = "font-family: Arial; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRSFootnote5.Text = "Rod string trailer"
			Me.lblRSFootnote5.Top = 7.5625F
			Me.lblRSFootnote5.Visible = False
			Me.lblRSFootnote5.Width = 7.75F
			Me.lblRSFootnote4.Height = 0.15F
			Me.lblRSFootnote4.HyperLink = Nothing
			Me.lblRSFootnote4.Left = 0.063F
			Me.lblRSFootnote4.Name = "lblRSFootnote4"
			Me.lblRSFootnote4.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblRSFootnote4.Text = "Rod string trailer"
			Me.lblRSFootnote4.Top = 7.4375F
			Me.lblRSFootnote4.Visible = False
			Me.lblRSFootnote4.Width = 7.75F
			Me.lblRSFootnote3.Height = 0.15F
			Me.lblRSFootnote3.HyperLink = Nothing
			Me.lblRSFootnote3.Left = 0.063F
			Me.lblRSFootnote3.Name = "lblRSFootnote3"
			Me.lblRSFootnote3.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRSFootnote3.Text = "Rod string trailer"
			Me.lblRSFootnote3.Top = 7.3125F
			Me.lblRSFootnote3.Visible = False
			Me.lblRSFootnote3.Width = 7.75F
			Me.lblRSFootnote1.Height = 0.15F
			Me.lblRSFootnote1.HyperLink = Nothing
			Me.lblRSFootnote1.Left = 0.063F
			Me.lblRSFootnote1.Name = "lblRSFootnote1"
			Me.lblRSFootnote1.Style = "font-family: MS Sans Serif; font-size: 8.5pt; text-align: left; white-space: nowrap"
			Me.lblRSFootnote1.Text = "Rod string trailer"
			Me.lblRSFootnote1.Top = 7.0625F
			Me.lblRSFootnote1.Visible = False
			Me.lblRSFootnote1.Width = 7.75F
			Me.lblPolRodDiam.Height = 0.145F
			Me.lblPolRodDiam.HyperLink = Nothing
			Me.lblPolRodDiam.Left = 3.5625F
			Me.lblPolRodDiam.Name = "lblPolRodDiam"
			Me.lblPolRodDiam.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.lblPolRodDiam.Text = "Polished Rod Diam."
			Me.lblPolRodDiam.Top = 0.875F
			Me.lblPolRodDiam.Width = 2.5625F
			Me.txtPolRodDiam.Height = 0.145F
			Me.txtPolRodDiam.HyperLink = Nothing
			Me.txtPolRodDiam.Left = 6.1875F
			Me.txtPolRodDiam.Name = "txtPolRodDiam"
			Me.txtPolRodDiam.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; white-space: nowrap"
			Me.txtPolRodDiam.Text = ""
			Me.txtPolRodDiam.Top = 0.875F
			Me.txtPolRodDiam.Width = 0.75F
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
			Me.lblRSFootnote6.Height = 0.15F
			Me.lblRSFootnote6.HyperLink = Nothing
			Me.lblRSFootnote6.Left = 0.063F
			Me.lblRSFootnote6.Name = "lblRSFootnote6"
			Me.lblRSFootnote6.Style = "font-size: 6pt"
			Me.lblRSFootnote6.Text = ""
			Me.lblRSFootnote6.Top = 7.73F
			Me.lblRSFootnote6.Width = 7.75F
			Me.MasterReport = False
			Me.PageSettings.Margins.Bottom = 0F
			Me.PageSettings.Margins.Left = 0F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0F
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
			CType(Me.lblRodDiam10, ISupportInitialize).EndInit()
			CType(Me.lblInputData, ISupportInitialize).EndInit()
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
			CType(Me.lblFLPIP_3, ISupportInitialize).EndInit()
			CType(Me.lblSPM, ISupportInitialize).EndInit()
			CType(Me.lblPumpFriction, ISupportInitialize).EndInit()
			CType(Me.lblPumpEfficiency, ISupportInitialize).EndInit()
			CType(Me.lblPumpLoadAdj, ISupportInitialize).EndInit()
			CType(Me.lblTubingAnchorDepth, ISupportInitialize).EndInit()
			CType(Me.lblDownstrokeFriction, ISupportInitialize).EndInit()
			CType(Me.lblPumpType, ISupportInitialize).EndInit()
			CType(Me.lblPumpCondition, ISupportInitialize).EndInit()
			CType(Me.lblPumpDepth, ISupportInitialize).EndInit()
			CType(Me.lblTubingPressure, ISupportInitialize).EndInit()
			CType(Me.lblRodGradeHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrengthHdrTop, ISupportInitialize).EndInit()
			CType(Me.lblRodLengthHdrTop, ISupportInitialize).EndInit()
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
			CType(Me.lblRodDiam9, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade9, ISupportInitialize).EndInit()
			CType(Me.lblRodLength9, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength9, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef9, ISupportInitialize).EndInit()
			CType(Me.lblRodGrade10, ISupportInitialize).EndInit()
			CType(Me.lblRodLength10, ISupportInitialize).EndInit()
			CType(Me.lblRodTensileStrength10, ISupportInitialize).EndInit()
			CType(Me.lblFricCoef10, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote2, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote5, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote4, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote3, ISupportInitialize).EndInit()
			CType(Me.lblRSFootnote1, ISupportInitialize).EndInit()
			CType(Me.lblPolRodDiam, ISupportInitialize).EndInit()
			CType(Me.txtPolRodDiam, ISupportInitialize).EndInit()
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
			CType(Me.lblRSFootnote6, ISupportInitialize).EndInit()
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		Private Sub Detail_Format(sender As Object, e As EventArgs)
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

		Public Sub rptResultsInputs_ReportStart(sender As Object, e As EventArgs)
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
			Me.ShowMiscInput()
			Me.ShowFluidAndMotor()
			Me.ShowPumpingUnit()
			Me.ShowTubingAndPump()
			Me.ShowRSInput()
			Me.ShowPumpingUnit()
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
			If RSWIN_DESC.bIntVersion Then
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter("rptResultsInputs")
					Me.WriteControlStrings()
					Util.CloseResourceWriter()
				End If
				If RSWIN_DESC.bReadResXFile Then
					Me.ReadReportControlStrings()
				End If
				Return
			End If
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
						Else
							Dim label3 As DataDynamics.ActiveReports.Label = label
							Dim num5 As Single = afValues(CInt(num4)) * fEFactor
							label3.Text = Util.Format(num5, sFormat)
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
			If(Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And RSWIN_DESC.rst.UnknownM) Or ((RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And RSWIN_DESC.rst.bUnknownUnbalance) Then
				NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet(arFrames, New Object() { 2 }, Nothing), Nothing, "Visible", New Object() { False }, Nothing, Nothing, False, True)
				Return
			End If
			NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet(arFrames, New Object() { 2 }, Nothing), Nothing, "Left", New Object() { Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(arFrames, New Object() { 1 }, Nothing), Nothing, "Left", New Object(-1) {}, Nothing, Nothing, Nothing), NewLateBinding.LateGet(NewLateBinding.LateIndexGet(arFrames, New Object() { 1 }, Nothing), Nothing, "Width", New Object(-1) {}, Nothing, Nothing, Nothing)) }, Nothing, Nothing, False, True)
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
			text2 = "#.###"
			label4.Text = RESULTS1.MkSumm(w3, Me.sFluidSpGravity, fluidSPGR, text2, True, False)
			Dim label5 As DataDynamics.ActiveReports.Label = Me.txtFluidSPGR
			Dim w4 As Object = 0
			text2 = ""
			Dim fluidSPGR2 As Single = RSWIN_DESC.rst.FluidSPGR
			text = "#.###"
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
			text2 = "0.0#"
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
			text = "0.0#"
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
			Dim text As String = "#.#"
			Dim text2 As String = "#.#"
			label.Text = RESULTS1.MkSummEM(w, Me.sCasingPres, casingPressure, psi__KPA, RSWIN_DESC.psi, text, RSWIN_DESC.kPa, text2, 3, True, False)
			Dim label2 As DataDynamics.ActiveReports.Label = Me.txtCasingPressure
			Dim w2 As Object = 0
			text2 = ""
			Dim casingPressure2 As Single = RSWIN_DESC.rst.CasingPressure
			Dim psi__KPA2 As Single = RSWIN_DESC.PSI__KPA
			text = "#.#"
			Dim text3 As String = "#.#"
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
				text5 = "#.#"
				label3.Text = RESULTS1.MkSummEM(w3, text3, fluidLevel, ft__M, text2, text, text4, text5, 3, True, False)
				Dim label4 As DataDynamics.ActiveReports.Label = Me.txtFLPIP_2
				Dim w4 As Object = 0
				text5 = ""
				Dim fluidLevel2 As Single = RSWIN_DESC.rst.FluidLevel
				Dim ft__M2 As Single = RSWIN_DESC.FT__M
				text4 = RSWIN_DESC.ft + " from surface"
				text3 = "0"
				text2 = "m from surface"
				text = "#.#"
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
			text = "#.#"
			label7.Text = RESULTS1.MkSummEM(w7, text5, v, ft__M3, text4, text3, text2, text, 3, True, False)
			Dim label8 As DataDynamics.ActiveReports.Label = Me.txtFLPIP_3
			Dim w8 As Object = 0
			text5 = ""
			Dim v2 As Single = RSWIN_DESC.rst.PumpDepth - RSWIN_DESC.rst.FluidLevel
			Dim ft__M4 As Single = RSWIN_DESC.FT__M
			text4 = RSWIN_DESC.ft + " over pump"
			text3 = "0"
			text2 = "m over pump"
			text = "#.#"
			label8.Text = RESULTS1.MkSummEM(w8, text5, v2, ft__M4, text4, text3, text2, text, 3, False, True)
			Dim label9 As DataDynamics.ActiveReports.Label = Me.lblRuntime
			Dim w9 As Object = 24
			Dim runtime As Single = RSWIN_DESC.rst.Runtime
			text5 = "0.0"
			label9.Text = RESULTS1.MkSumm(w9, Me.sRunTime, runtime, text5, True, False)
			Dim label10 As DataDynamics.ActiveReports.Label = Me.txtRuntime
			Dim w10 As Object = 0
			text5 = ""
			Dim runtime2 As Single = RSWIN_DESC.rst.Runtime
			text4 = "0.0"
			label10.Text = RESULTS1.MkSumm(w10, text5, runtime2, text4, False, True)
			If RSWIN_DESC.rst.SPMEntered <> 0S Then
				Dim label11 As DataDynamics.ActiveReports.Label = Me.lblSPM
				Dim w11 As Object = 24
				Dim spm As Single = RSWIN_DESC.rst.SPM
				text5 = "0.0#"
				label11.Text = RESULTS1.MkSumm(w11, Me.sStrokesPerMinute, spm, text5, True, False)
				Dim label12 As DataDynamics.ActiveReports.Label = Me.txtSPM
				Dim w12 As Object = 0
				text5 = ""
				Dim spm2 As Single = RSWIN_DESC.rst.SPM
				text4 = "0.0#"
				label12.Text = RESULTS1.MkSumm(w12, text5, spm2, text4, False, True)
			Else
				Dim label13 As DataDynamics.ActiveReports.Label = Me.lblSPM
				Dim w13 As Object = 24
				Dim targetBFPD As Single = RSWIN_DESC.rst.TargetBFPD
				Dim bpd__M3D As Single = RSWIN_DESC.BPD__M3D
				text5 = "0"
				text4 = "#.#"
				label13.Text = RESULTS1.MkSummEM(w13, Me.sTargetProd, targetBFPD, bpd__M3D, RSWIN_DESC.bfpd, text5, RSWIN_DESC.m3D, text4, 3, True, False)
				Dim label14 As DataDynamics.ActiveReports.Label = Me.txtSPM
				Dim w14 As Object = 0
				Dim targetBFPD2 As Single = RSWIN_DESC.rst.TargetBFPD
				Dim bpd__M3D2 As Single = RSWIN_DESC.BPD__M3D
				text5 = "0"
				text4 = "#.#"
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
			Dim casingPressure3 As Single = RSWIN_DESC.rst.CasingPressure
			Dim psi__KPA5 As Single = RSWIN_DESC.PSI__KPA
			text5 = "#.#"
			text4 = "#.#"
			label16.Text = RESULTS1.MkSummEM(w16, Me.sTubingPres, casingPressure3, psi__KPA5, RSWIN_DESC.psi, text5, RSWIN_DESC.kPa, text4, 3, True, False)
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
			Dim casingPressure4 As Single = RSWIN_DESC.rst.CasingPressure
			Dim psi__KPA6 As Single = RSWIN_DESC.PSI__KPA
			text4 = "#.#"
			text3 = "#.#"
			label18.Text = RESULTS1.MkSummEM(w18, text5, casingPressure4, psi__KPA6, RSWIN_DESC.psi, text4, RSWIN_DESC.kPa, text3, 3, False, True)
		End Sub

		Private Sub ShowPumpingUnit()
			Try
				Dim rptResultsInputs As rptResultsInputs = Me
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					rptResultsInputs.lblAPIDesignation.Text = Me.sUnitDesignation
				Else
					rptResultsInputs.lblAPIDesignation.Text = Me.sAPIDesignation
				End If
				rptResultsInputs.lblAPIDesignation.Visible = True
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
						rptResultsInputs.lblPumpingUnitHeader.Text = text4
					Catch ex2 As Exception
						Dim text4 As String = text.Trim()
						If text4.Length >= 60 Then
							rptResultsInputs.lblPumpingUnitHeader.Text = text4.Substring(0, 60)
						Else
							rptResultsInputs.lblPumpingUnitHeader.Text = text4
						End If
					End Try
					rptResultsInputs.lblPumpingUnitHeader.Visible = True
				ElseIf text3.Length > 0 Then
					Try
						Dim text4 As String = text.Trim()
						rptResultsInputs.lblPumpingUnitHeader.Text = text4
					Catch ex3 As Exception
						Dim text4 As String = text.Trim()
						If text4.Length >= 60 Then
							rptResultsInputs.lblPumpingUnitHeader.Text = text4.Substring(0, 60)
						Else
							rptResultsInputs.lblPumpingUnitHeader.Text = text4
						End If
					End Try
					rptResultsInputs.lblPumpingUnitHeader.Visible = True
				Else
					rptResultsInputs.lblPumpingUnitHeader.Text = text
					rptResultsInputs.lblPumpingUnitHeader.Visible = True
				End If
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					Me.sAPISize = Me.sUnitSize
				End If
				If Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 Then
					rptResultsInputs.lblAPIDesignation.Text = Util.FormatMessage(Me.sAPISize + "{0}{1}", New Object() { RESULTS1.VTrim(RSWIN_DESC.rst.PU.APIDesignation), RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.rst.IDEntered <> 0S, Util.FormatMessage(" (" + Me.sUnitID + "{0})", New Object() { "CUSTOM" }), Nothing)) })
				Else
					rptResultsInputs.lblAPIDesignation.Text = Util.FormatMessage(Me.sAPISize + "{0}{1}", New Object() { RESULTS1.VTrim(RSWIN_DESC.rst.PU.APIDesignation), RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.rst.IDEntered <> 0S, Util.FormatMessage(" (" + Me.sUnitID + "{0})", New Object() { Strings.Trim(RSWIN_DESC.rst.UnitID) }), Nothing)) })
				End If
				rptResultsInputs.lblAPIDesignation.Visible = True
				If RSWIN_DESC.rst.CBDataFile IsNot Nothing Then
					If RSWIN_DESC.rst.CBDataFile.Length > 0 Then
						If Strings.InStr(RSWIN_DESC.rst.CBDataFile.ToLower(), ".xblx", CompareMethod.Binary) > 0 Then
							rptResultsInputs.lblCBDataFile.Text = Util.FormatMessage(Me.sXBALFile + """{0}""", New Object() { Util.FileName(RSWIN_DESC.rst.CBDataFile) })
						Else
							rptResultsInputs.lblCBDataFile.Text = Util.FormatMessage(Me.sCBALANCEFile + """{0}""", New Object() { Util.FileName(RSWIN_DESC.rst.CBDataFile) })
						End If
						rptResultsInputs.lblCBDataFile.Visible = True
					Else
						rptResultsInputs.lblCBDataFile.Visible = False
					End If
				Else
					rptResultsInputs.lblCBDataFile.Visible = False
				End If
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					rptResultsInputs.txtCrankHole.Text = Me.sNA
					rptResultsInputs.txtCrankHole.Visible = True
				ElseIf RSWIN_DESC.rst.IDEntered <> 0S Then
					rptResultsInputs.txtCrankHole.Text = Util.FormatMessage("#{0} (out of {1})", New Object() { RSWIN_DESC.rst.PU.CrankHole, RSWIN_DESC.rst.PU.CrankHoles })
					rptResultsInputs.txtCrankHole.Visible = True
				Else
					rptResultsInputs.lblCrankHole.Visible = False
				End If
				Dim text5 As String
				Dim text6 As String
				If RSWIN_DESC.rst.PU.UnitType <> 10S Then
					Dim label As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCrankRotation
					Dim w As Object = 36
					Dim value As Single = 0F
					text5 = Conversions.ToString(Interaction.IIf(RSWIN_DESC.rst.PU.CrankRotation = 1S, "#" + Me.sCW, "#" + Me.sCCW))
					label.Text = RESULTS1.MkSumm(w, Me.sRotationWithWellToRight, value, text5, True, False)
					Dim label2 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCrankRotation
					Dim w2 As Object = 4
					text5 = ""
					Dim value2 As Single = 0F
					text6 = Conversions.ToString(Interaction.IIf(RSWIN_DESC.rst.PU.CrankRotation = 1S, "#""CW""", "#""CCW"))
					label2.Text = RESULTS1.MkSumm(w2, text5, value2, text6, False, True)
					rptResultsInputs.lblCrankRotation.Visible = True
					rptResultsInputs.txtCrankHole.Visible = True
				Else
					rptResultsInputs.lblCrankRotation.Text = Me.sRotation
					rptResultsInputs.txtCrankRotation.Text = Me.sNA
					rptResultsInputs.lblCrankRotation.Visible = True
					rptResultsInputs.txtCrankHole.Visible = True
				End If
				Dim label3 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblStrokeLength
				Dim w3 As Object = 36
				Dim kinematicStroke As Single = RSWIN_DESC.rst.PU.KinematicStroke
				Dim in__CM As Single = RSWIN_DESC.IN__CM
				text6 = "#.#"
				text5 = "#.#"
				label3.Text = RESULTS1.MkSummEM(w3, Me.sCalculatedStrokeLength, kinematicStroke, in__CM, RSWIN_DESC.inch, text6, RSWIN_DESC.cm, text5, 1, True, False)
				Dim label4 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtStrokeLength
				Dim w4 As Object = 0
				text6 = ""
				Dim kinematicStroke2 As Single = RSWIN_DESC.rst.PU.KinematicStroke
				Dim in__CM2 As Single = RSWIN_DESC.IN__CM
				text5 = "#.#"
				Dim text7 As String = "#.#"
				label4.Text = RESULTS1.MkSummEM(w4, text6, kinematicStroke2, in__CM2, RSWIN_DESC.inch, text5, RSWIN_DESC.cm, text7, 1, False, True)
				rptResultsInputs.lblStrokeLength.Visible = True
				rptResultsInputs.txtStrokeLength.Visible = True
				Select Case RSWIN_DESC.rst.PU.UnitType
					Case 6S
						rptResultsInputs.lblCwtInfo_1.Text = Me.sAirAtTankAt
						Dim text8 As String = Me.sBottomOfStroke
						If RSWIN_DESC.rst.UnknownM Then
							Dim label5 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_2
							Dim w5 As Object = 36
							Dim v As Single = 0F
							Dim etoM As Single = 1F
							text7 = "psig"
							label5.Text = RESULTS1.MkSummEM(w5, text8, v, etoM, text7, Me.c_UNKNOWN, RSWIN_DESC.kPa, Me.c_UNKNOWN, 1, True, False)
							Dim label6 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
							Dim w6 As Object = Me.c_UNKNOWN.Length
							Dim v2 As Single = 0F
							Dim etoM2 As Single = 1F
							text7 = "psig"
							label6.Text = RESULTS1.MkSummEM(w6, text8, v2, etoM2, text7, Me.c_UNKNOWN, RSWIN_DESC.kPa, Me.c_UNKNOWN, 1, False, True)
						Else
							Dim label7 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_2
							Dim w7 As Object = 36
							Dim v3 As Single = RSWIN_DESC.rst.get_M(2)
							Dim psi__KPA As Single = RSWIN_DESC.PSI__KPA
							text7 = "psig"
							text6 = "0"
							text5 = "0"
							label7.Text = RESULTS1.MkSummEM(w7, text8, v3, psi__KPA, text7, text6, RSWIN_DESC.kPa, text5, 1, True, False)
							Dim label8 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
							Dim w8 As Object = 0
							text7 = ""
							Dim v4 As Single = RSWIN_DESC.rst.get_M(2)
							Dim psi__KPA2 As Single = RSWIN_DESC.PSI__KPA
							text6 = "psig"
							text5 = "0"
							Dim text9 As String = "0"
							label8.Text = RESULTS1.MkSummEM(w8, text7, v4, psi__KPA2, text6, text5, RSWIN_DESC.kPa, text9, 1, False, True)
						End If
						rptResultsInputs.lblCwtInfo_1.Visible = True
						rptResultsInputs.lblCwtInfo_2.Visible = True
						rptResultsInputs.lblCwtInfo_3.Visible = False
						rptResultsInputs.lblCwtInfo_4.Visible = False
						rptResultsInputs.lblCwtInfo_5.Visible = False
						rptResultsInputs.txtCwtInfo_3.Visible = False
						rptResultsInputs.txtCwtInfo_4.Visible = False
						rptResultsInputs.txtCwtInfo_5.Visible = False
						GoTo IL_1831
					Case 7S, 10S
						Dim text8 As String = Me.sMaxCBweightl
						If RSWIN_DESC.rst.PU.UnitType = 7S Then
							If RSWIN_DESC.rst.UnknownM Then
								Dim label9 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_1
								Dim w9 As Object = 36
								Dim v5 As Single = 0F
								Dim etoM3 As Single = 1F
								Dim text9 As String = "M lbs"
								label9.Text = RESULTS1.MkSummEM(w9, text8, v5, etoM3, text9, Me.c_UNKNOWN, RSWIN_DESC.N, Me.c_UNKNOWN, 1, True, False)
								Dim label10 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_1
								Dim w10 As Object = Me.c_UNKNOWN.Length
								text9 = ""
								Dim v6 As Single = 0F
								Dim etoM4 As Single = 1F
								text7 = "M lbs"
								label10.Text = RESULTS1.MkSummEM(w10, text9, v6, etoM4, text7, Me.c_UNKNOWN, RSWIN_DESC.N, Me.c_UNKNOWN, 1, False, True)
							Else
								Dim label11 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_1
								Dim w11 As Object = 36
								Dim v7 As Single = RSWIN_DESC.rst.get_M(2) / 1000F
								Dim etoM5 As Single = RSWIN_DESC.LB__N * 1000F
								Dim text9 As String = "M lbs"
								text7 = "#.#"
								text6 = "#.#"
								label11.Text = RESULTS1.MkSummEM(w11, text8, v7, etoM5, text9, text7, RSWIN_DESC.N, text6, 1, True, False)
								Dim label12 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_1
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
							rptResultsInputs.lblCwtInfo_1.Text = text8
							rptResultsInputs.txtCwtInfo_1.Text = Me.sNA
						End If
						rptResultsInputs.lblCwtInfo_1.Visible = True
						rptResultsInputs.txtCwtInfo_1.Visible = True
						If(Not RSWIN_DESC.rst.IDEntered And If((-If(((RSWIN_DESC.rst.PU.UnitType = 7S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							Dim label13 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_2
							Dim w13 As Object = 36
							Dim sprocketRadius As Single = RSWIN_DESC.rst.PU.SprocketRadius
							Dim in__CM3 As Single = RSWIN_DESC.IN__CM
							Dim text9 As String = "#.#"
							text7 = "#.#"
							label13.Text = RESULTS1.MkSummEM(w13, Me.sSprocketRadius, sprocketRadius, in__CM3, RSWIN_DESC.ins, text9, RSWIN_DESC.cm, text7, 1, True, False)
							Dim label14 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_3
							Dim w14 As Object = 36
							Dim sprocketDistance As Single = RSWIN_DESC.rst.PU.SprocketDistance
							Dim in__CM4 As Single = RSWIN_DESC.IN__CM
							text9 = "#.#"
							text7 = "#.#"
							label14.Text = RESULTS1.MkSummEM(w14, Me.sClineSprocketDistance, sprocketDistance, in__CM4, RSWIN_DESC.ins, text9, RSWIN_DESC.cm, text7, 1, True, False)
							Dim label15 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_4
							Dim w15 As Object = 36
							Dim drumDiamRatio As Single = RSWIN_DESC.rst.PU.DrumDiamRatio
							text9 = "0.0#"
							label15.Text = RESULTS1.MkSumm(w15, Me.sDrumDiameterRatio, drumDiamRatio, text9, True, False)
							Dim label16 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
							Dim w16 As Object = 0
							text9 = ""
							Dim sprocketRadius2 As Single = RSWIN_DESC.rst.PU.SprocketRadius
							Dim in__CM5 As Single = RSWIN_DESC.IN__CM
							text7 = "#.#"
							text6 = "#.#"
							label16.Text = RESULTS1.MkSummEM(w16, text9, sprocketRadius2, in__CM5, RSWIN_DESC.ins, text7, RSWIN_DESC.cm, text6, 1, False, True)
							Dim label17 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_3
							Dim w17 As Object = 0
							text9 = ""
							Dim sprocketDistance2 As Single = RSWIN_DESC.rst.PU.SprocketDistance
							Dim in__CM6 As Single = RSWIN_DESC.IN__CM
							text7 = "#.#"
							text6 = "#.#"
							label17.Text = RESULTS1.MkSummEM(w17, text9, sprocketDistance2, in__CM6, RSWIN_DESC.ins, text7, RSWIN_DESC.cm, text6, 1, False, True)
							Dim label18 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_4
							Dim w18 As Object = 0
							text9 = ""
							Dim drumDiamRatio2 As Single = RSWIN_DESC.rst.PU.DrumDiamRatio
							text7 = "0.0#"
							label18.Text = RESULTS1.MkSumm(w18, text9, drumDiamRatio2, text7, False, True)
							rptResultsInputs.lblCwtInfo_2.Visible = True
							rptResultsInputs.lblCwtInfo_3.Visible = True
							rptResultsInputs.lblCwtInfo_4.Visible = True
							rptResultsInputs.txtCwtInfo_2.Visible = True
							rptResultsInputs.txtCwtInfo_3.Visible = True
							rptResultsInputs.txtCwtInfo_4.Visible = True
							If RSWIN_DESC.rst.PU.P > 0F Then
								Dim label19 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_5
								Dim w19 As Object = 36
								Dim p As Single = RSWIN_DESC.rst.PU.P
								Dim in__CM7 As Single = RSWIN_DESC.IN__CM
								text9 = "#.#"
								text7 = "#.#"
								label19.Text = RESULTS1.MkSummEM(w19, Me.sPitmanArmLength, p, in__CM7, RSWIN_DESC.ins, text9, RSWIN_DESC.cm, text7, 1, True, False)
								Dim label20 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_5
								Dim w20 As Object = 0
								text9 = ""
								Dim p2 As Single = RSWIN_DESC.rst.PU.P
								Dim in__CM8 As Single = RSWIN_DESC.IN__CM
								text7 = "#.#"
								text6 = "#.#"
								label20.Text = RESULTS1.MkSummEM(w20, text9, p2, in__CM8, RSWIN_DESC.ins, text7, RSWIN_DESC.cm, text6, 1, False, True)
								rptResultsInputs.lblCwtInfo_5.Visible = True
								rptResultsInputs.txtCwtInfo_5.Visible = True
								GoTo IL_1831
							End If
							rptResultsInputs.lblCwtInfo_5.Visible = False
							rptResultsInputs.txtCwtInfo_5.Visible = False
							GoTo IL_1831
						Else
							If RSWIN_DESC.rst.PU.UnitType = 10S Then
								Dim label21 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_2
								Dim w21 As Object = 36
								Dim adjustedStrokeLength As Single = RSWIN_DESC.rst.AdjustedStrokeLength
								Dim in__CM9 As Single = RSWIN_DESC.IN__CM
								Dim text9 As String = "#.#"
								text7 = "#.#"
								label21.Text = RESULTS1.MkSummEM(w21, Me.sAdjustedStrokeLength, adjustedStrokeLength, in__CM9, RSWIN_DESC.inch, text9, RSWIN_DESC.cm, text7, 1, True, False)
								Dim label22 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
								Dim w22 As Object = 0
								text9 = ""
								Dim adjustedStrokeLength2 As Single = RSWIN_DESC.rst.AdjustedStrokeLength
								Dim in__CM10 As Single = RSWIN_DESC.IN__CM
								text7 = "#.#"
								text6 = "#.#"
								label22.Text = RESULTS1.MkSummEM(w22, text9, adjustedStrokeLength2, in__CM10, RSWIN_DESC.inch, text7, RSWIN_DESC.cm, text6, 1, False, True)
								rptResultsInputs.lblCwtInfo_2.Visible = True
								rptResultsInputs.txtCwtInfo_2.Visible = True
								rptResultsInputs.lblCwtInfo_3.Visible = False
								rptResultsInputs.txtCwtInfo_3.Visible = False
								rptResultsInputs.lblCwtInfo_4.Visible = False
								rptResultsInputs.lblCwtInfo_5.Visible = False
								rptResultsInputs.txtCwtInfo_4.Visible = False
								rptResultsInputs.txtCwtInfo_5.Visible = False
								GoTo IL_1831
							End If
							rptResultsInputs.lblCwtInfo_2.Visible = False
							rptResultsInputs.lblCwtInfo_3.Visible = False
							rptResultsInputs.lblCwtInfo_4.Visible = False
							rptResultsInputs.lblCwtInfo_5.Visible = False
							rptResultsInputs.txtCwtInfo_2.Visible = False
							rptResultsInputs.txtCwtInfo_3.Visible = False
							rptResultsInputs.txtCwtInfo_4.Visible = False
							rptResultsInputs.txtCwtInfo_5.Visible = False
							GoTo IL_1831
						End If
				End Select
				If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
					If RSWIN_DESC.rst.bUnknownUnbalance Then
						rptResultsInputs.lblCwtInfo_1.Text = RESULTS1.MkSummEM(36, Me.sStructuralUnbalance, 0F, 1F, RSWIN_DESC.Minlbs, Me.c_UNKNOWN, RSWIN_DESC.Nm, Me.c_UNKNOWN, 1, True, False)
						Dim label23 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_1
						Dim w23 As Object = Me.c_UNKNOWN.Length
						Dim text9 As String = ""
						label23.Text = RESULTS1.MkSummEM(w23, text9, 0F, 1F, RSWIN_DESC.Minlbs, Me.c_UNKNOWN, RSWIN_DESC.Nm, Me.c_UNKNOWN, 1, False, True)
					Else
						Dim label24 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_1
						Dim w24 As Object = 36
						Dim unbalance As Single = RSWIN_DESC.rst.PU.Unbalance
						Dim lb__N As Single = RSWIN_DESC.LB__N
						Dim text9 As String = "0"
						text7 = "0"
						label24.Text = RESULTS1.MkSummEM(w24, Me.sStructuralUnbalance, unbalance, lb__N, RSWIN_DESC.lbs, text9, RSWIN_DESC.N, text7, 1, True, False)
						Dim label25 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_1
						Dim w25 As Object = 0
						Dim unbalance2 As Single = RSWIN_DESC.rst.PU.Unbalance
						Dim lb__N2 As Single = RSWIN_DESC.LB__N
						text9 = "0"
						text7 = "0"
						label25.Text = RESULTS1.MkSummEM(w25, Me.sStructuralUnbalance, unbalance2, lb__N2, RSWIN_DESC.lbs, text9, RSWIN_DESC.N, text7, 1, False, True)
					End If
					rptResultsInputs.lblCwtInfo_1.Visible = True
					rptResultsInputs.txtCwtInfo_1.Visible = True
					rptResultsInputs.lblCwtInfo_2.Text = " "
					rptResultsInputs.txtCwtInfo_2.Text = " "
					rptResultsInputs.lblCwtInfo_3.Text = " "
					rptResultsInputs.txtCwtInfo_3.Text = " "
				Else
					Dim text8 As String = Me.sMaxCBMoment
					If RSWIN_DESC.rst.UnknownM Then
						rptResultsInputs.lblCwtInfo_1.Text = RESULTS1.MkSummEM(36, text8, 0F, 1F, RSWIN_DESC.Minlbs, Me.c_UNKNOWN, RSWIN_DESC.Nm, Me.c_UNKNOWN, 1, True, False)
						Dim label26 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_1
						Dim w26 As Object = Me.c_UNKNOWN.Length
						Dim text9 As String = ""
						label26.Text = RESULTS1.MkSummEM(w26, text9, 0F, 1F, RSWIN_DESC.Minlbs, Me.c_UNKNOWN, RSWIN_DESC.Nm, Me.c_UNKNOWN, 1, False, True)
					Else
						Dim label27 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_1
						Dim w27 As Object = 36
						Dim v9 As Single = RSWIN_DESC.rst.get_M(2) / 1000F
						Dim minlb__NM As Single = RSWIN_DESC.MINLB__NM
						Dim text9 As String = "0"
						text7 = "0"
						label27.Text = RESULTS1.MkSummEM(w27, text8, v9, minlb__NM, RSWIN_DESC.Minlbs, text9, RSWIN_DESC.Nm, text7, 1, True, False)
						Dim label28 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_1
						Dim w28 As Object = 0
						text9 = ""
						Dim v10 As Single = RSWIN_DESC.rst.get_M(2) / 1000F
						Dim minlb__NM2 As Single = RSWIN_DESC.MINLB__NM
						text7 = "0"
						text6 = "0"
						label28.Text = RESULTS1.MkSummEM(w28, text9, v10, minlb__NM2, RSWIN_DESC.Minlbs, text7, RSWIN_DESC.Nm, text6, 1, False, True)
					End If
					rptResultsInputs.lblCwtInfo_1.Visible = True
					rptResultsInputs.txtCwtInfo_1.Visible = True
					If RSWIN_DESC.rst.PU.UnitType = 9S Then
						rptResultsInputs.lblCwtInfo_2.Text = ""
						rptResultsInputs.txtCwtInfo_2.Text = ""
						Dim label29 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_2
						Dim w29 As Object = 36
						Dim value3 As Single = CSng((CDbl((RSWIN_DESC.rst.PU.CrankOffset * 180F)) / 3.141592653589793))
						Dim text9 As String = "0.0"
						label29.Text = RESULTS1.MkSumm(w29, Me.sCrankOffsetAngle, value3, text9, True, False)
						Dim label30 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
						Dim w30 As Object = 0
						Dim value4 As Single = CSng((CDbl((RSWIN_DESC.rst.PU.CrankOffset * 180F)) / 3.141592653589793))
						text9 = "0.0"
						label30.Text = RESULTS1.MkSumm(w30, Me.sCrankOffsetAngle, value4, text9, False, True)
						rptResultsInputs.lblCwtInfo_3.Text = ""
						rptResultsInputs.txtCwtInfo_3.Text = ""
					Else
						Dim label31 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_2
						Dim w31 As Object = 36
						Dim unbalance3 As Single = RSWIN_DESC.rst.PU.Unbalance
						Dim lb__N3 As Single = RSWIN_DESC.LB__N
						Dim text9 As String = "0"
						text7 = "0"
						label31.Text = RESULTS1.MkSummEM(w31, Me.sStructuralUnbalance, unbalance3, lb__N3, RSWIN_DESC.lbs, text9, RSWIN_DESC.N, text7, 1, True, False)
						Dim label32 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
						Dim w32 As Object = 0
						Dim unbalance4 As Single = RSWIN_DESC.rst.PU.Unbalance
						Dim lb__N4 As Single = RSWIN_DESC.LB__N
						text9 = "0"
						text7 = "0"
						label32.Text = RESULTS1.MkSummEM(w32, Me.sStructuralUnbalance, unbalance4, lb__N4, RSWIN_DESC.lbs, text9, RSWIN_DESC.N, text7, 1, False, True)
						Dim label33 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_3
						Dim w33 As Object = 36
						Dim value5 As Single = CSng((CDbl((RSWIN_DESC.rst.PU.CrankOffset * 180F)) / 3.141592653589793))
						text9 = "0.0"
						label33.Text = RESULTS1.MkSumm(w33, Me.sCrankOffsetAngle, value5, text9, True, False)
						Dim label34 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_3
						Dim w34 As Object = 0
						Dim value6 As Single = CSng((CDbl((RSWIN_DESC.rst.PU.CrankOffset * 180F)) / 3.141592653589793))
						text9 = "0.0"
						label34.Text = RESULTS1.MkSumm(w34, Me.sCrankOffsetAngle, value6, text9, False, True)
						rptResultsInputs.lblCwtInfo_2.Visible = True
						rptResultsInputs.txtCwtInfo_2.Visible = True
						rptResultsInputs.lblCwtInfo_3.Visible = True
						rptResultsInputs.txtCwtInfo_3.Visible = True
					End If
				End If
				If((If((-If((CDbl(RSWIN_DESC.rst.MotorSPV) > 0.0 > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV) And If((-If((Not Me.SpdVarIncludedNotWritten() > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Dim text9 As String
					If RSWIN_DESC.rst.IrotEntered <> 0S Then
						Dim label35 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_4
						Dim w35 As Object = 36
						Dim irot As Single = RSWIN_DESC.rst.Irot
						Dim lbft2__KGM As Single = RSWIN_DESC.LBFT2__KGM2
						text9 = "lb-ft²"
						text7 = "0"
						text6 = "kg-m²"
						text5 = "0"
						label35.Text = RESULTS1.MkSummEM(w35, Me.sEnteredRotInertia, irot, lbft2__KGM, text9, text7, text6, text5, 1, True, False)
					Else
						Dim label36 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_4
						Dim w36 As Object = 36
						Dim irot2 As Single = RSWIN_DESC.rst.Irot
						Dim lbft2__KGM2 As Single = RSWIN_DESC.LBFT2__KGM2
						text9 = "lb-ft²"
						text7 = "0"
						text6 = "kg-m²"
						text5 = "0"
						label36.Text = RESULTS1.MkSummEM(w36, Me.sBalRotInertia, irot2, lbft2__KGM2, text9, text7, text6, text5, 1, True, False)
					End If
					Dim label37 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_4
					Dim w37 As Object = 0
					text9 = ""
					Dim irot3 As Single = RSWIN_DESC.rst.Irot
					Dim lbft2__KGM3 As Single = RSWIN_DESC.LBFT2__KGM2
					text7 = "lb-ft²"
					text6 = "0"
					text5 = "kg-m²"
					Dim text10 As String = "0"
					label37.Text = RESULTS1.MkSummEM(w37, text9, irot3, lbft2__KGM3, text7, text6, text5, text10, 1, False, True)
					Dim label38 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_5
					Dim w38 As Object = 36
					Dim iart As Single = RSWIN_DESC.rst.Iart
					Dim lbft2__KGM4 As Single = RSWIN_DESC.LBFT2__KGM2
					text10 = "lb-ft²"
					text9 = "0"
					text7 = "kg-m²"
					text6 = "0"
					label38.Text = RESULTS1.MkSummEM(w38, Me.sArtInertia, iart, lbft2__KGM4, text10, text9, text7, text6, 1, True, False)
					Dim label39 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_5
					Dim w39 As Object = 0
					text10 = ""
					Dim iart2 As Single = RSWIN_DESC.rst.Iart
					Dim lbft2__KGM5 As Single = RSWIN_DESC.LBFT2__KGM2
					text9 = "lb-ft²"
					text7 = "0"
					text6 = "kg-m²"
					text5 = "0"
					label39.Text = RESULTS1.MkSummEM(w39, text10, iart2, lbft2__KGM5, text9, text7, text6, text5, 1, False, True)
					rptResultsInputs.lblCwtInfo_4.Visible = True
					rptResultsInputs.txtCwtInfo_4.Visible = True
					rptResultsInputs.lblCwtInfo_5.Visible = True
					rptResultsInputs.txtCwtInfo_5.Visible = True
				Else
					rptResultsInputs.lblCwtInfo_4.Visible = False
					rptResultsInputs.lblCwtInfo_5.Visible = False
					rptResultsInputs.txtCwtInfo_4.Visible = False
					rptResultsInputs.txtCwtInfo_5.Visible = False
				End If
				IL_1831:
				If(Not RSWIN_DESC.rst.IDEntered And If((-If((Not(RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Dim label40 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimR
					Dim w40 As Object = 10
					Dim text10 As String = "R"
					Dim r As Single = RSWIN_DESC.rst.PU.R
					Dim in__CM11 As Single = RSWIN_DESC.IN__CM
					Dim text9 As String = "#.###"
					text7 = "#.###"
					label40.Text = RESULTS1.MkSummEM(w40, text10, r, in__CM11, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label41 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimA
					Dim w41 As Object = 10
					text10 = "A"
					Dim a As Single = RSWIN_DESC.rst.PU.A
					Dim in__CM12 As Single = RSWIN_DESC.IN__CM
					text9 = "#.###"
					text7 = "#.###"
					label41.Text = RESULTS1.MkSummEM(w41, text10, a, in__CM12, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label42 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimC
					Dim w42 As Object = 10
					text10 = "C"
					Dim c As Single = RSWIN_DESC.rst.PU.C
					Dim in__CM13 As Single = RSWIN_DESC.IN__CM
					text9 = "#.###"
					text7 = "#.###"
					label42.Text = RESULTS1.MkSummEM(w42, text10, c, in__CM13, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label43 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimI
					Dim w43 As Object = 10
					text10 = "I"
					Dim i As Single = RSWIN_DESC.rst.PU.I
					Dim in__CM14 As Single = RSWIN_DESC.IN__CM
					text9 = "#.###"
					text7 = "#.###"
					label43.Text = RESULTS1.MkSummEM(w43, text10, i, in__CM14, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label44 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimK
					Dim w44 As Object = 10
					text10 = "K"
					Dim k As Single = RSWIN_DESC.rst.PU.K
					Dim in__CM15 As Single = RSWIN_DESC.IN__CM
					text9 = "#.###"
					text7 = "#.###"
					label44.Text = RESULTS1.MkSummEM(w44, text10, k, in__CM15, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label45 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimP
					Dim w45 As Object = 10
					text10 = "P"
					Dim p3 As Single = RSWIN_DESC.rst.PU.P
					Dim in__CM16 As Single = RSWIN_DESC.IN__CM
					text9 = "#.###"
					text7 = "#.###"
					label45.Text = RESULTS1.MkSummEM(w45, text10, p3, in__CM16, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					rptResultsInputs.lblPUDimR.Visible = True
					rptResultsInputs.lblPUDimA.Visible = True
					rptResultsInputs.lblPUDimC.Visible = True
					rptResultsInputs.lblPUDimI.Visible = True
					rptResultsInputs.lblPUDimK.Visible = True
					rptResultsInputs.lblPUDimP.Visible = True
				Else
					rptResultsInputs.lblPUDimR.Visible = False
					rptResultsInputs.lblPUDimA.Visible = False
					rptResultsInputs.lblPUDimC.Visible = False
					rptResultsInputs.lblPUDimI.Visible = False
					rptResultsInputs.lblPUDimK.Visible = False
					rptResultsInputs.lblPUDimP.Visible = False
				End If
				If(Not RSWIN_DESC.rst.IDEntered And If((-If(((RSWIN_DESC.rst.PU.UnitType = 6S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Dim label46 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimM
					Dim w46 As Object = 10
					Dim text10 As String = "M"
					Dim m As Single = RSWIN_DESC.rst.PU.M
					Dim etoM7 As Single = 6.4516F
					Dim text9 As String = "#.###"
					text7 = "#.###"
					label46.Text = RESULTS1.MkSummEM(w46, text10, m, etoM7, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label47 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimS
					Dim w47 As Object = 10
					text10 = "S"
					Dim s As Single = RSWIN_DESC.rst.PU.S
					Dim etoM8 As Single = 6.894757F
					text9 = "#.###"
					text7 = "#.###"
					label47.Text = RESULTS1.MkSummEM(w47, text10, s, etoM8, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					Dim label48 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimV0
					Dim w48 As Object = 10
					text10 = "V0"
					Dim v11 As Single = RSWIN_DESC.rst.PU.V0
					Dim etoM9 As Single = 16.38706F
					text9 = "#.###"
					text7 = "#.###"
					label48.Text = RESULTS1.MkSummEM(w48, text10, v11, etoM9, Me.sNull, text9, Me.sNull, text7, 1, False, False)
					rptResultsInputs.lblPUDimM.Visible = True
					rptResultsInputs.lblPUDimS.Visible = True
					rptResultsInputs.lblPUDimV0.Visible = True
				Else
					rptResultsInputs.lblPUDimM.Visible = False
					rptResultsInputs.lblPUDimS.Visible = False
					rptResultsInputs.lblPUDimV0.Visible = False
				End If
				rptResultsInputs = Nothing
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub ShowPumpingUnit_old()
			Try
				Dim rptResultsInputs As rptResultsInputs = Me
				Dim text As String = Me.sUnit + Strings.Trim(RSWIN_DESC.rst.PU.Manuf)
				Dim text2 As String = RESULTS1.VTrim(RSWIN_DESC.rst.PU.UnitName)
				Dim text3 As String = RESULTS1.VTrim(RSWIN_DESC.rst.PU.OtherInfo)
				Try
					text2 = text2.Replace(vbNullChar, " ")
				Catch ex As Exception
				End Try
				rptResultsInputs.lblPumpingUnitHeader.Text = text
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					Me.sAPISize = Me.sUnitSize
				End If
				If Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 Then
					rptResultsInputs.lblAPIDesignation.Text = Util.FormatMessage(Me.sAPISize + "{0}{1}", New Object() { RESULTS1.VTrim(RSWIN_DESC.rst.PU.APIDesignation), RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.rst.IDEntered <> 0S, Util.FormatMessage(" (" + Me.sUnitID + "{0})", New Object() { "CUSTOM" }), Nothing)) })
				Else
					rptResultsInputs.lblAPIDesignation.Text = Util.FormatMessage(Me.sAPISize + "{0}{1}", New Object() { RESULTS1.VTrim(RSWIN_DESC.rst.PU.APIDesignation), RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.rst.IDEntered <> 0S, Util.FormatMessage(" (" + Me.sUnitID + "{0})", New Object() { Strings.Trim(RSWIN_DESC.rst.UnitID) }), Nothing)) })
				End If
				If RSWIN_DESC.rst.CBDataFile IsNot Nothing Then
					If RSWIN_DESC.rst.CBDataFile.Length > 0 Then
						If Strings.InStr(RSWIN_DESC.rst.CBDataFile.ToLower(), ".xblx", CompareMethod.Binary) > 0 Then
							rptResultsInputs.lblCBDataFile.Text = Util.FormatMessage(Me.sXBALFile + """{0}""", New Object() { Util.FileName(RSWIN_DESC.rst.CBDataFile) })
						Else
							rptResultsInputs.lblCBDataFile.Text = Util.FormatMessage(Me.sCBALANCEFile + """{0}""", New Object() { Util.FileName(RSWIN_DESC.rst.CBDataFile) })
						End If
					Else
						rptResultsInputs.lblCBDataFile.Visible = False
					End If
				Else
					rptResultsInputs.lblCBDataFile.Visible = False
				End If
				If RSWIN_DESC.rst.IDEntered <> 0S Then
					rptResultsInputs.txtCrankHole.Text = Util.FormatMessage("#{0} (out of {1})", New Object() { RSWIN_DESC.rst.PU.CrankHole, RSWIN_DESC.rst.PU.CrankHoles })
				Else
					rptResultsInputs.lblCrankHole.Visible = False
				End If
				Dim label As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCrankRotation
				Dim w As Object = 36
				Dim value As Single = 0F
				Dim text4 As String = Conversions.ToString(Interaction.IIf(RSWIN_DESC.rst.PU.CrankRotation = 1S, "#" + Me.sCW, "#" + Me.sCCW))
				label.Text = RESULTS1.MkSumm(w, Me.sRotationWithWellToRight, value, text4, True, False)
				Dim label2 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCrankRotation
				Dim w2 As Object = 4
				text4 = ""
				Dim value2 As Single = 0F
				Dim text5 As String = Conversions.ToString(Interaction.IIf(RSWIN_DESC.rst.PU.CrankRotation = 1S, "#""CW""", "#""CCW"))
				label2.Text = RESULTS1.MkSumm(w2, text4, value2, text5, False, True)
				Dim label3 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblStrokeLength
				Dim w3 As Object = 36
				Dim kinematicStroke As Single = RSWIN_DESC.rst.PU.KinematicStroke
				Dim in__CM As Single = RSWIN_DESC.IN__CM
				text5 = "#.#"
				text4 = "#.#"
				label3.Text = RESULTS1.MkSummEM(w3, Me.sCalculatedStrokeLength, kinematicStroke, in__CM, RSWIN_DESC.ins, text5, RSWIN_DESC.cm, text4, 1, True, False)
				Dim label4 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtStrokeLength
				Dim w4 As Object = 0
				text5 = ""
				Dim kinematicStroke2 As Single = RSWIN_DESC.rst.PU.KinematicStroke
				Dim in__CM2 As Single = RSWIN_DESC.IN__CM
				text4 = "#.#"
				Dim text6 As String = "#.#"
				label4.Text = RESULTS1.MkSummEM(w4, text5, kinematicStroke2, in__CM2, RSWIN_DESC.ins, text4, RSWIN_DESC.cm, text6, 1, False, True)
				Select Case RSWIN_DESC.rst.PU.UnitType
					Case 6S
						rptResultsInputs.lblCwtInfo_1.Text = Me.sAirAtTankAt
						Dim text7 As String = Me.sBottomOfStroke
						If RSWIN_DESC.rst.UnknownM Then
							Dim label5 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_2
							Dim w5 As Object = 36
							Dim v As Single = 0F
							Dim etoM As Single = 1F
							text6 = "psig"
							label5.Text = RESULTS1.MkSummEM(w5, text7, v, etoM, text6, Me.c_UNKNOWN, RSWIN_DESC.kPa, Me.c_UNKNOWN, 1, True, False)
							Dim label6 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
							Dim w6 As Object = Me.c_UNKNOWN.Length
							Dim v2 As Single = 0F
							Dim etoM2 As Single = 1F
							text6 = "psig"
							label6.Text = RESULTS1.MkSummEM(w6, text7, v2, etoM2, text6, Me.c_UNKNOWN, RSWIN_DESC.kPa, Me.c_UNKNOWN, 1, False, True)
							GoTo IL_12F5
						End If
						Dim label7 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_2
						Dim w7 As Object = 36
						Dim v3 As Single = RSWIN_DESC.rst.get_M(2)
						Dim psi__KPA As Single = RSWIN_DESC.PSI__KPA
						text6 = "psig"
						text5 = "0"
						text4 = "0"
						label7.Text = RESULTS1.MkSummEM(w7, text7, v3, psi__KPA, text6, text5, RSWIN_DESC.kPa, text4, 1, True, False)
						Dim label8 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
						Dim w8 As Object = 0
						text6 = ""
						Dim v4 As Single = RSWIN_DESC.rst.get_M(2)
						Dim psi__KPA2 As Single = RSWIN_DESC.PSI__KPA
						text5 = "psig"
						text4 = "0"
						Dim text8 As String = "0"
						label8.Text = RESULTS1.MkSummEM(w8, text6, v4, psi__KPA2, text5, text4, RSWIN_DESC.kPa, text8, 1, False, True)
						GoTo IL_12F5
					Case 7S, 10S
						Dim text7 As String = Me.sMaxCBweightl
						If RSWIN_DESC.rst.UnknownM Then
							Dim label9 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_1
							Dim w9 As Object = 36
							Dim v5 As Single = 0F
							Dim etoM3 As Single = 1F
							Dim text8 As String = "M lbs"
							label9.Text = RESULTS1.MkSummEM(w9, text7, v5, etoM3, text8, Me.c_UNKNOWN, RSWIN_DESC.N, Me.c_UNKNOWN, 1, True, False)
							Dim label10 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_1
							Dim w10 As Object = Me.c_UNKNOWN.Length
							text8 = ""
							Dim v6 As Single = 0F
							Dim etoM4 As Single = 1F
							text6 = "M lbs"
							label10.Text = RESULTS1.MkSummEM(w10, text8, v6, etoM4, text6, Me.c_UNKNOWN, RSWIN_DESC.N, Me.c_UNKNOWN, 1, False, True)
						Else
							Dim label11 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_1
							Dim w11 As Object = 36
							Dim v7 As Single = RSWIN_DESC.rst.get_M(2) / 1000F
							Dim etoM5 As Single = RSWIN_DESC.LB__N * 1000F
							Dim text8 As String = "M lbs"
							text6 = "#.#"
							text5 = "#.#"
							label11.Text = RESULTS1.MkSummEM(w11, text7, v7, etoM5, text8, text6, RSWIN_DESC.N, text5, 1, True, False)
							Dim label12 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_1
							Dim w12 As Object = 0
							text8 = ""
							Dim v8 As Single = RSWIN_DESC.rst.get_M(2) / 1000F
							Dim etoM6 As Single = RSWIN_DESC.LB__N * 1000F
							text6 = "M lbs"
							text5 = "#.#"
							text4 = "#.#"
							label12.Text = RESULTS1.MkSummEM(w12, text8, v8, etoM6, text6, text5, RSWIN_DESC.N, text4, 1, False, True)
						End If
						If(Not RSWIN_DESC.rst.IDEntered And If((-If(((RSWIN_DESC.rst.PU.UnitType = 7S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							Dim label13 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_2
							Dim w13 As Object = 36
							Dim sprocketRadius As Single = RSWIN_DESC.rst.PU.SprocketRadius
							Dim in__CM3 As Single = RSWIN_DESC.IN__CM
							Dim text8 As String = "#.#"
							text6 = "#.#"
							label13.Text = RESULTS1.MkSummEM(w13, Me.sSprocketRadius, sprocketRadius, in__CM3, RSWIN_DESC.ins, text8, RSWIN_DESC.cm, text6, 1, True, False)
							Dim label14 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_3
							Dim w14 As Object = 36
							Dim sprocketDistance As Single = RSWIN_DESC.rst.PU.SprocketDistance
							Dim in__CM4 As Single = RSWIN_DESC.IN__CM
							text8 = "#.#"
							text6 = "#.#"
							label14.Text = RESULTS1.MkSummEM(w14, Me.sClineSprocketDistance, sprocketDistance, in__CM4, RSWIN_DESC.ins, text8, RSWIN_DESC.cm, text6, 1, True, False)
							Dim label15 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_4
							Dim w15 As Object = 36
							Dim drumDiamRatio As Single = RSWIN_DESC.rst.PU.DrumDiamRatio
							text8 = "0.0#"
							label15.Text = RESULTS1.MkSumm(w15, Me.sDrumDiameterRatio, drumDiamRatio, text8, True, False)
							Dim label16 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
							Dim w16 As Object = 0
							text8 = ""
							Dim sprocketRadius2 As Single = RSWIN_DESC.rst.PU.SprocketRadius
							Dim in__CM5 As Single = RSWIN_DESC.IN__CM
							text6 = "#.#"
							text5 = "#.#"
							label16.Text = RESULTS1.MkSummEM(w16, text8, sprocketRadius2, in__CM5, RSWIN_DESC.ins, text6, RSWIN_DESC.cm, text5, 1, False, True)
							Dim label17 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_3
							Dim w17 As Object = 0
							text8 = ""
							Dim sprocketDistance2 As Single = RSWIN_DESC.rst.PU.SprocketDistance
							Dim in__CM6 As Single = RSWIN_DESC.IN__CM
							text6 = "#.#"
							text5 = "#.#"
							label17.Text = RESULTS1.MkSummEM(w17, text8, sprocketDistance2, in__CM6, RSWIN_DESC.ins, text6, RSWIN_DESC.cm, text5, 1, False, True)
							Dim label18 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_4
							Dim w18 As Object = 0
							text8 = ""
							Dim drumDiamRatio2 As Single = RSWIN_DESC.rst.PU.DrumDiamRatio
							text6 = "0.0#"
							label18.Text = RESULTS1.MkSumm(w18, text8, drumDiamRatio2, text6, False, True)
							If RSWIN_DESC.rst.PU.P > 0F Then
								Dim label19 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_5
								Dim w19 As Object = 36
								Dim p As Single = RSWIN_DESC.rst.PU.P
								Dim in__CM7 As Single = RSWIN_DESC.IN__CM
								text8 = "#.#"
								text6 = "#.#"
								label19.Text = RESULTS1.MkSummEM(w19, Me.sPitmanArmLength, p, in__CM7, RSWIN_DESC.ins, text8, RSWIN_DESC.cm, text6, 1, True, False)
								Dim label20 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_5
								Dim w20 As Object = 0
								text8 = ""
								Dim p2 As Single = RSWIN_DESC.rst.PU.P
								Dim in__CM8 As Single = RSWIN_DESC.IN__CM
								text6 = "#.#"
								text5 = "#.#"
								label20.Text = RESULTS1.MkSummEM(w20, text8, p2, in__CM8, RSWIN_DESC.ins, text6, RSWIN_DESC.cm, text5, 1, False, True)
								GoTo IL_12F5
							End If
							rptResultsInputs.lblCwtInfo_5.Visible = False
							rptResultsInputs.txtCwtInfo_5.Visible = False
							GoTo IL_12F5
						Else
							If RSWIN_DESC.rst.PU.UnitType = 10S Then
								Dim label21 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_2
								Dim w21 As Object = 36
								Dim adjustedStrokeLength As Single = RSWIN_DESC.rst.AdjustedStrokeLength
								Dim in__CM9 As Single = RSWIN_DESC.IN__CM
								Dim text8 As String = "#.#"
								text6 = "#.#"
								label21.Text = RESULTS1.MkSummEM(w21, Me.sAdjustedStrokeLength, adjustedStrokeLength, in__CM9, RSWIN_DESC.inch, text8, RSWIN_DESC.cm, text6, 1, True, False)
								Dim label22 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
								Dim w22 As Object = 0
								text8 = ""
								Dim adjustedStrokeLength2 As Single = RSWIN_DESC.rst.AdjustedStrokeLength
								Dim in__CM10 As Single = RSWIN_DESC.IN__CM
								text6 = "#.#"
								text5 = "#.#"
								label22.Text = RESULTS1.MkSummEM(w22, text8, adjustedStrokeLength2, in__CM10, RSWIN_DESC.inch, text6, RSWIN_DESC.cm, text5, 1, False, True)
								rptResultsInputs.lblCwtInfo_3.Visible = False
								rptResultsInputs.txtCwtInfo_3.Visible = False
								rptResultsInputs.lblCwtInfo_4.Visible = False
								rptResultsInputs.lblCwtInfo_5.Visible = False
								rptResultsInputs.txtCwtInfo_4.Visible = False
								rptResultsInputs.txtCwtInfo_5.Visible = False
								GoTo IL_12F5
							End If
							rptResultsInputs.lblCwtInfo_2.Visible = False
							rptResultsInputs.lblCwtInfo_3.Visible = False
							rptResultsInputs.lblCwtInfo_4.Visible = False
							rptResultsInputs.lblCwtInfo_5.Visible = False
							rptResultsInputs.txtCwtInfo_2.Visible = False
							rptResultsInputs.txtCwtInfo_3.Visible = False
							rptResultsInputs.txtCwtInfo_4.Visible = False
							rptResultsInputs.txtCwtInfo_5.Visible = False
							GoTo IL_12F5
						End If
				End Select
				If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
					Dim text7 As String = Me.sCrankCBMoment
					Dim label23 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_1
					Dim w23 As Object = 36
					Dim m As Single = RSWIN_DESC.rst.PU.M
					Dim minlb__NM As Single = RSWIN_DESC.MINLB__NM
					Dim text8 As String = "0.00"
					text6 = "0.00"
					label23.Text = RESULTS1.MkSummEM(w23, text7, m, minlb__NM, RSWIN_DESC.Minlbs, text8, RSWIN_DESC.Nm, text6, 1, True, False)
					Dim label24 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_1
					Dim w24 As Object = 0
					text8 = ""
					Dim m2 As Single = RSWIN_DESC.rst.PU.M
					Dim minlb__NM2 As Single = RSWIN_DESC.MINLB__NM
					text6 = "0.00"
					text5 = "0.00"
					label24.Text = RESULTS1.MkSummEM(w24, text8, m2, minlb__NM2, RSWIN_DESC.Minlbs, text6, RSWIN_DESC.Nm, text5, 1, False, True)
					If RSWIN_DESC.rst.bUnknownUnbalance Then
						Dim label25 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_2
						Dim w25 As Object = 36
						Dim unbalance As Single = RSWIN_DESC.rst.PU.Unbalance
						Dim lb__N As Single = RSWIN_DESC.LB__N
						text8 = "0"
						text6 = "0"
						label25.Text = RESULTS1.MkSummEM(w25, Me.sStructuralUnbalance, unbalance, lb__N, RSWIN_DESC.lbs, text8, RSWIN_DESC.N, text6, 1, True, False)
						Dim label26 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
						Dim w26 As Object = 0
						Dim unbalance2 As Single = RSWIN_DESC.rst.PU.Unbalance
						Dim lb__N2 As Single = RSWIN_DESC.LB__N
						text8 = "0"
						text6 = "0"
						label26.Text = RESULTS1.MkSummEM(w26, Me.sStructuralUnbalance, unbalance2, lb__N2, RSWIN_DESC.lbs, text8, RSWIN_DESC.N, text6, 1, False, True)
					Else
						Dim label27 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_2
						Dim w27 As Object = 36
						Dim unbalance3 As Single = RSWIN_DESC.rst.PU.Unbalance
						Dim lb__N3 As Single = RSWIN_DESC.LB__N
						text8 = "0"
						text6 = "0"
						label27.Text = RESULTS1.MkSummEM(w27, Me.sStructuralUnbalance, unbalance3, lb__N3, RSWIN_DESC.lbs, text8, RSWIN_DESC.N, text6, 1, True, False)
						Dim label28 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
						Dim w28 As Object = 0
						Dim unbalance4 As Single = RSWIN_DESC.rst.PU.Unbalance
						Dim lb__N4 As Single = RSWIN_DESC.LB__N
						text8 = "0"
						text6 = "0"
						label28.Text = RESULTS1.MkSummEM(w28, Me.sStructuralUnbalance, unbalance4, lb__N4, RSWIN_DESC.lbs, text8, RSWIN_DESC.N, text6, 1, False, True)
					End If
					rptResultsInputs.lblCwtInfo_3.Text = " "
					rptResultsInputs.txtCwtInfo_3.Text = " "
				Else
					Dim text7 As String = Me.sMaxCBMoment
					Dim text8 As String
					If RSWIN_DESC.rst.UnknownM Then
						rptResultsInputs.lblCwtInfo_1.Text = RESULTS1.MkSummEM(36, text7, 0F, 1F, RSWIN_DESC.Minlbs, Me.c_UNKNOWN, RSWIN_DESC.Nm, Me.c_UNKNOWN, 1, True, False)
						Dim label29 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_1
						Dim w29 As Object = Me.c_UNKNOWN.Length
						text8 = ""
						label29.Text = RESULTS1.MkSummEM(w29, text8, 0F, 1F, RSWIN_DESC.Minlbs, Me.c_UNKNOWN, RSWIN_DESC.Nm, Me.c_UNKNOWN, 1, False, True)
					Else
						Dim label30 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_1
						Dim w30 As Object = 36
						Dim v9 As Single = RSWIN_DESC.rst.get_M(2) / 1000F
						Dim minlb__NM3 As Single = RSWIN_DESC.MINLB__NM
						text8 = "0"
						text6 = "0"
						label30.Text = RESULTS1.MkSummEM(w30, text7, v9, minlb__NM3, RSWIN_DESC.Minlbs, text8, RSWIN_DESC.Nm, text6, 1, True, False)
						Dim label31 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_1
						Dim w31 As Object = 0
						text8 = ""
						Dim v10 As Single = RSWIN_DESC.rst.get_M(2) / 1000F
						Dim minlb__NM4 As Single = RSWIN_DESC.MINLB__NM
						text6 = "0"
						text5 = "0"
						label31.Text = RESULTS1.MkSummEM(w31, text8, v10, minlb__NM4, RSWIN_DESC.Minlbs, text6, RSWIN_DESC.Nm, text5, 1, False, True)
					End If
					Dim label32 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_3
					Dim w32 As Object = 36
					Dim value3 As Single = CSng((CDbl((RSWIN_DESC.rst.PU.CrankOffset * 180F)) / 3.141592653589793))
					text8 = "0.0"
					label32.Text = RESULTS1.MkSumm(w32, Me.sCrankOffsetAngle, value3, text8, True, False)
					Dim label33 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_2
					Dim w33 As Object = 0
					Dim unbalance5 As Single = RSWIN_DESC.rst.PU.Unbalance
					Dim lb__N5 As Single = RSWIN_DESC.LB__N
					text8 = "0"
					text6 = "0"
					label33.Text = RESULTS1.MkSummEM(w33, Me.sStructuralUnbalance, unbalance5, lb__N5, RSWIN_DESC.lbs, text8, RSWIN_DESC.N, text6, 1, False, True)
					Dim label34 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_3
					Dim w34 As Object = 0
					Dim value4 As Single = CSng((CDbl((RSWIN_DESC.rst.PU.CrankOffset * 180F)) / 3.141592653589793))
					text8 = "0.0"
					label34.Text = RESULTS1.MkSumm(w34, Me.sCrankOffsetAngle, value4, text8, False, True)
				End If
				If CDbl(RSWIN_DESC.rst.MotorSPV) > 0.0 Then
					Dim label35 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_4
					Dim w35 As Object = 36
					Dim irot As Single = RSWIN_DESC.rst.Irot
					Dim lbft2__KGM As Single = RSWIN_DESC.LBFT2__KGM2
					Dim text8 As String = "lb-ft²"
					text6 = "0"
					text5 = "kg-m²"
					text4 = "0"
					label35.Text = RESULTS1.MkSummEM(w35, Me.sRotInertia, irot, lbft2__KGM, text8, text6, text5, text4, 1, True, False)
					Dim label36 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_4
					Dim w36 As Object = 0
					text8 = ""
					Dim irot2 As Single = RSWIN_DESC.rst.Irot
					Dim lbft2__KGM2 As Single = RSWIN_DESC.LBFT2__KGM2
					text6 = "lb-ft²"
					text5 = "0"
					text4 = "kg-m²"
					Dim text9 As String = "0"
					label36.Text = RESULTS1.MkSummEM(w36, text8, irot2, lbft2__KGM2, text6, text5, text4, text9, 1, False, True)
					Dim flag As Boolean = Not RSWIN_DESC.rst.IrotEntered <> 0S
					Dim label37 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblCwtInfo_5
					Dim w37 As Object = 36
					Dim iart As Single = RSWIN_DESC.rst.Iart
					Dim lbft2__KGM3 As Single = RSWIN_DESC.LBFT2__KGM2
					text9 = "lb-ft²"
					text8 = "0"
					text6 = "kg-m²"
					text5 = "0"
					label37.Text = RESULTS1.MkSummEM(w37, Me.sArtInertia, iart, lbft2__KGM3, text9, text8, text6, text5, 1, True, False)
					Dim label38 As DataDynamics.ActiveReports.Label = rptResultsInputs.txtCwtInfo_5
					Dim w38 As Object = 0
					text9 = ""
					Dim iart2 As Single = RSWIN_DESC.rst.Iart
					Dim lbft2__KGM4 As Single = RSWIN_DESC.LBFT2__KGM2
					text8 = "lb-ft²"
					text6 = "0"
					text5 = "kg-m²"
					text4 = "0"
					label38.Text = RESULTS1.MkSummEM(w38, text9, iart2, lbft2__KGM4, text8, text6, text5, text4, 1, False, True)
				Else
					rptResultsInputs.lblCwtInfo_4.Visible = False
					rptResultsInputs.lblCwtInfo_5.Visible = False
					rptResultsInputs.txtCwtInfo_4.Visible = False
					rptResultsInputs.txtCwtInfo_5.Visible = False
				End If
				IL_12F5:
				If(Not RSWIN_DESC.rst.IDEntered And If((-If(((RSWIN_DESC.rst.PU.UnitType <> 7S) > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.PU.UnitType <> 10S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Dim label39 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimR
					Dim w39 As Object = 10
					Dim text9 As String = "R"
					Dim r As Single = RSWIN_DESC.rst.PU.R
					Dim in__CM11 As Single = RSWIN_DESC.IN__CM
					Dim text8 As String = "#.###"
					text6 = "#.###"
					label39.Text = RESULTS1.MkSummEM(w39, text9, r, in__CM11, Me.sNull, text8, Me.sNull, text6, 1, False, False)
					Dim label40 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimA
					Dim w40 As Object = 10
					text9 = "A"
					Dim a As Single = RSWIN_DESC.rst.PU.A
					Dim in__CM12 As Single = RSWIN_DESC.IN__CM
					text8 = "#.###"
					text6 = "#.###"
					label40.Text = RESULTS1.MkSummEM(w40, text9, a, in__CM12, Me.sNull, text8, Me.sNull, text6, 1, False, False)
					Dim label41 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimC
					Dim w41 As Object = 10
					text9 = "C"
					Dim c As Single = RSWIN_DESC.rst.PU.C
					Dim in__CM13 As Single = RSWIN_DESC.IN__CM
					text8 = "#.###"
					text6 = "#.###"
					label41.Text = RESULTS1.MkSummEM(w41, text9, c, in__CM13, Me.sNull, text8, Me.sNull, text6, 1, False, False)
					Dim label42 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimI
					Dim w42 As Object = 10
					text9 = "I"
					Dim i As Single = RSWIN_DESC.rst.PU.I
					Dim in__CM14 As Single = RSWIN_DESC.IN__CM
					text8 = "#.###"
					text6 = "#.###"
					label42.Text = RESULTS1.MkSummEM(w42, text9, i, in__CM14, Me.sNull, text8, Me.sNull, text6, 1, False, False)
					Dim label43 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimK
					Dim w43 As Object = 10
					text9 = "K"
					Dim k As Single = RSWIN_DESC.rst.PU.K
					Dim in__CM15 As Single = RSWIN_DESC.IN__CM
					text8 = "#.###"
					text6 = "#.###"
					label43.Text = RESULTS1.MkSummEM(w43, text9, k, in__CM15, Me.sNull, text8, Me.sNull, text6, 1, False, False)
					Dim label44 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimP
					Dim w44 As Object = 10
					text9 = "P"
					Dim p3 As Single = RSWIN_DESC.rst.PU.P
					Dim in__CM16 As Single = RSWIN_DESC.IN__CM
					text8 = "#.###"
					text6 = "#.###"
					label44.Text = RESULTS1.MkSummEM(w44, text9, p3, in__CM16, Me.sNull, text8, Me.sNull, text6, 1, False, False)
				Else
					rptResultsInputs.lblPUDimR.Visible = False
					rptResultsInputs.lblPUDimA.Visible = False
					rptResultsInputs.lblPUDimC.Visible = False
					rptResultsInputs.lblPUDimI.Visible = False
					rptResultsInputs.lblPUDimK.Visible = False
					rptResultsInputs.lblPUDimP.Visible = False
				End If
				If(Not RSWIN_DESC.rst.IDEntered And If((-If(((RSWIN_DESC.rst.PU.UnitType = 6S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Dim label45 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimM
					Dim w45 As Object = 10
					Dim text9 As String = "M"
					Dim m3 As Single = RSWIN_DESC.rst.PU.M
					Dim etoM7 As Single = 6.4516F
					Dim text8 As String = "#.###"
					text6 = "#.###"
					label45.Text = RESULTS1.MkSummEM(w45, text9, m3, etoM7, Me.sNull, text8, Me.sNull, text6, 1, False, False)
					Dim label46 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimS
					Dim w46 As Object = 10
					text9 = "S"
					Dim s As Single = RSWIN_DESC.rst.PU.S
					Dim etoM8 As Single = 6.894757F
					text8 = "#.###"
					text6 = "#.###"
					label46.Text = RESULTS1.MkSummEM(w46, text9, s, etoM8, Me.sNull, text8, Me.sNull, text6, 1, False, False)
					Dim label47 As DataDynamics.ActiveReports.Label = rptResultsInputs.lblPUDimV0
					Dim w47 As Object = 10
					text9 = "V0"
					Dim v11 As Single = RSWIN_DESC.rst.PU.V0
					Dim etoM9 As Single = 16.38706F
					text8 = "#.###"
					text6 = "#.###"
					label47.Text = RESULTS1.MkSummEM(w47, text9, v11, etoM9, Me.sNull, text8, Me.sNull, text6, 1, False, False)
				Else
					rptResultsInputs.lblPUDimM.Visible = False
					rptResultsInputs.lblPUDimS.Visible = False
					rptResultsInputs.lblPUDimV0.Visible = False
				End If
				rptResultsInputs = Nothing
			Catch ex2 As Exception
			End Try
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
			Loop While num <= 40L
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
								Me.m_LastHeight = avLabels2.Height
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels3.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels3.Top
								Me.m_LastHeight = avLabels3.Height
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels4.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels4.Top
								Me.m_LastHeight = avLabels4.Height
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels5.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels5.Top
								Me.m_LastHeight = avLabels5.Height
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels6.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels6.Top
								Me.m_LastHeight = avLabels6.Height
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels7.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels7.Top
								Me.m_LastHeight = avLabels7.Height
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels8.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels8.Top
								Me.m_LastHeight = avLabels8.Height
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels9.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels9.Top
								Me.m_LastHeight = avLabels9.Height
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								' The following expression was wrapped in a checked-expression
								avLabels10.Text = Conversions.ToString(RODUTIL.GetRodGradeName(CInt(num)))
								Me.m_LastTop = avLabels10.Top
								Me.m_LastHeight = avLabels10.Height
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 40L
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
			Loop While num <= 40L
		End Sub

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
								' The following expression was wrapped in a checked-statement
								If RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength = 0F Then
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(CInt(num)))
								End If
								Dim text2 As String
								If RODUTIL.IsAPI(CInt(RSWIN_DESC.rst.Sections(CInt(num)).Grade), RSWIN_DESC.rst.Sections(CInt(num)).RodType) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										' The following expression was wrapped in a unchecked-expression
										' The following expression was wrapped in a checked-expression
										Dim num3 As Single = RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength * RSWIN_DESC.PSI__KPA
										Dim text As String = "0"
										text2 = Util.Format(num3, text)
									Else
										Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
										Dim num4 As Integer = CInt(num)
										Dim text As String = "0"
										text2 = Util.Format(sections(num4).TensileStrength, text)
									End If
								Else
									text2 = Me.sNA
								End If
								If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num)).Grade) Or RSWIN_DESC.rst.Sections(CInt(num)).Grade = 4100S Then
									text2 = Me.sNA
								End If
								avLabels1.Text = text2
							End If
						Case 1
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels2.Visible = False
							Else
								' The following expression was wrapped in a checked-statement
								If RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength = 0F Then
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(CInt(num)))
								End If
								Dim text2 As String
								If RODUTIL.IsAPI(CInt(RSWIN_DESC.rst.Sections(CInt(num)).Grade), RSWIN_DESC.rst.Sections(CInt(num)).RodType) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										' The following expression was wrapped in a unchecked-expression
										' The following expression was wrapped in a checked-expression
										Dim num3 As Single = RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength * RSWIN_DESC.PSI__KPA
										Dim text As String = "0"
										text2 = Util.Format(num3, text)
									Else
										Dim sections2 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
										Dim num5 As Integer = CInt(num)
										Dim text As String = "0"
										text2 = Util.Format(sections2(num5).TensileStrength, text)
									End If
								Else
									text2 = Me.sNA
								End If
								If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num)).Grade) Or RSWIN_DESC.rst.Sections(CInt(num)).Grade = 4100S Then
									text2 = Me.sNA
								End If
								avLabels2.Text = text2
							End If
						Case 2
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels3.Visible = False
							Else
								' The following expression was wrapped in a checked-statement
								If RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength = 0F Then
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(CInt(num)))
								End If
								Dim text2 As String
								If RODUTIL.IsAPI(CInt(RSWIN_DESC.rst.Sections(CInt(num)).Grade), RSWIN_DESC.rst.Sections(CInt(num)).RodType) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										' The following expression was wrapped in a unchecked-expression
										' The following expression was wrapped in a checked-expression
										Dim num3 As Single = RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength * RSWIN_DESC.PSI__KPA
										Dim text As String = "0"
										text2 = Util.Format(num3, text)
									Else
										Dim sections3 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
										Dim num6 As Integer = CInt(num)
										Dim text As String = "0"
										text2 = Util.Format(sections3(num6).TensileStrength, text)
									End If
								Else
									text2 = Me.sNA
								End If
								If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num)).Grade) Or RSWIN_DESC.rst.Sections(CInt(num)).Grade = 4100S Then
									text2 = Me.sNA
								End If
								avLabels3.Text = text2
							End If
						Case 3
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels4.Visible = False
							Else
								' The following expression was wrapped in a checked-statement
								If RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength = 0F Then
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(CInt(num)))
								End If
								Dim text2 As String
								If RODUTIL.IsAPI(CInt(RSWIN_DESC.rst.Sections(CInt(num)).Grade), RSWIN_DESC.rst.Sections(CInt(num)).RodType) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										' The following expression was wrapped in a unchecked-expression
										' The following expression was wrapped in a checked-expression
										Dim num3 As Single = RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength * RSWIN_DESC.PSI__KPA
										Dim text As String = "0"
										text2 = Util.Format(num3, text)
									Else
										Dim sections4 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
										Dim num7 As Integer = CInt(num)
										Dim text As String = "0"
										text2 = Util.Format(sections4(num7).TensileStrength, text)
									End If
								Else
									text2 = Me.sNA
								End If
								If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num)).Grade) Or RSWIN_DESC.rst.Sections(CInt(num)).Grade = 4100S Then
									text2 = Me.sNA
								End If
								avLabels4.Text = text2
							End If
						Case 4
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels5.Visible = False
							Else
								' The following expression was wrapped in a checked-statement
								If RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength = 0F Then
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(CInt(num)))
								End If
								Dim text2 As String
								If RODUTIL.IsAPI(CInt(RSWIN_DESC.rst.Sections(CInt(num)).Grade), RSWIN_DESC.rst.Sections(CInt(num)).RodType) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										' The following expression was wrapped in a unchecked-expression
										' The following expression was wrapped in a checked-expression
										Dim num3 As Single = RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength * RSWIN_DESC.PSI__KPA
										Dim text As String = "0"
										text2 = Util.Format(num3, text)
									Else
										Dim sections5 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
										Dim num8 As Integer = CInt(num)
										Dim text As String = "0"
										text2 = Util.Format(sections5(num8).TensileStrength, text)
									End If
								Else
									text2 = Me.sNA
								End If
								If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num)).Grade) Or RSWIN_DESC.rst.Sections(CInt(num)).Grade = 4100S Then
									text2 = Me.sNA
								End If
								avLabels5.Text = text2
							End If
						Case 5
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels6.Visible = False
							Else
								' The following expression was wrapped in a checked-statement
								If RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength = 0F Then
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(CInt(num)))
								End If
								Dim text2 As String
								If RODUTIL.IsAPI(CInt(RSWIN_DESC.rst.Sections(CInt(num)).Grade), RSWIN_DESC.rst.Sections(CInt(num)).RodType) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										' The following expression was wrapped in a unchecked-expression
										' The following expression was wrapped in a checked-expression
										Dim num3 As Single = RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength * RSWIN_DESC.PSI__KPA
										Dim text As String = "0"
										text2 = Util.Format(num3, text)
									Else
										Dim sections6 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
										Dim num9 As Integer = CInt(num)
										Dim text As String = "0"
										text2 = Util.Format(sections6(num9).TensileStrength, text)
									End If
								Else
									text2 = Me.sNA
								End If
								If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num)).Grade) Or RSWIN_DESC.rst.Sections(CInt(num)).Grade = 4100S Then
									text2 = Me.sNA
								End If
								avLabels6.Text = text2
							End If
						Case 6
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels7.Visible = False
							Else
								' The following expression was wrapped in a checked-statement
								If RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength = 0F Then
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(CInt(num)))
								End If
								Dim text2 As String
								If RODUTIL.IsAPI(CInt(RSWIN_DESC.rst.Sections(CInt(num)).Grade), RSWIN_DESC.rst.Sections(CInt(num)).RodType) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										' The following expression was wrapped in a unchecked-expression
										' The following expression was wrapped in a checked-expression
										Dim num3 As Single = RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength * RSWIN_DESC.PSI__KPA
										Dim text As String = "0"
										text2 = Util.Format(num3, text)
									Else
										Dim sections7 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
										Dim num10 As Integer = CInt(num)
										Dim text As String = "0"
										text2 = Util.Format(sections7(num10).TensileStrength, text)
									End If
								Else
									text2 = Me.sNA
								End If
								If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num)).Grade) Or RSWIN_DESC.rst.Sections(CInt(num)).Grade = 4100S Then
									text2 = Me.sNA
								End If
								avLabels7.Text = text2
							End If
						Case 7
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels8.Visible = False
							Else
								' The following expression was wrapped in a checked-statement
								If RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength = 0F Then
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(CInt(num)))
								End If
								Dim text2 As String
								If RODUTIL.IsAPI(CInt(RSWIN_DESC.rst.Sections(CInt(num)).Grade), RSWIN_DESC.rst.Sections(CInt(num)).RodType) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										' The following expression was wrapped in a unchecked-expression
										' The following expression was wrapped in a checked-expression
										Dim num3 As Single = RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength * RSWIN_DESC.PSI__KPA
										Dim text As String = "0"
										text2 = Util.Format(num3, text)
									Else
										Dim sections8 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
										Dim num11 As Integer = CInt(num)
										Dim text As String = "0"
										text2 = Util.Format(sections8(num11).TensileStrength, text)
									End If
								Else
									text2 = Me.sNA
								End If
								If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num)).Grade) Or RSWIN_DESC.rst.Sections(CInt(num)).Grade = 4100S Then
									text2 = Me.sNA
								End If
								avLabels8.Text = text2
							End If
						Case 8
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels9.Visible = False
							Else
								' The following expression was wrapped in a checked-statement
								If RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength = 0F Then
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(CInt(num)))
								End If
								Dim text2 As String
								If RODUTIL.IsAPI(CInt(RSWIN_DESC.rst.Sections(CInt(num)).Grade), RSWIN_DESC.rst.Sections(CInt(num)).RodType) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										' The following expression was wrapped in a unchecked-expression
										' The following expression was wrapped in a checked-expression
										Dim num3 As Single = RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength * RSWIN_DESC.PSI__KPA
										Dim text As String = "0"
										text2 = Util.Format(num3, text)
									Else
										Dim sections9 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
										Dim num12 As Integer = CInt(num)
										Dim text As String = "0"
										text2 = Util.Format(sections9(num12).TensileStrength, text)
									End If
								Else
									text2 = Me.sNA
								End If
								If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num)).Grade) Or RSWIN_DESC.rst.Sections(CInt(num)).Grade = 4100S Then
									text2 = Me.sNA
								End If
								avLabels9.Text = text2
							End If
						Case 9
							If num > CLng(RSWIN_DESC.rst.NumRods) Then
								avLabels10.Visible = False
							Else
								' The following expression was wrapped in a checked-statement
								If RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength = 0F Then
									RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(CInt(num)))
								End If
								Dim text2 As String
								If RODUTIL.IsAPI(CInt(RSWIN_DESC.rst.Sections(CInt(num)).Grade), RSWIN_DESC.rst.Sections(CInt(num)).RodType) Then
									If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										' The following expression was wrapped in a unchecked-expression
										' The following expression was wrapped in a checked-expression
										Dim num3 As Single = RSWIN_DESC.rst.Sections(CInt(num)).TensileStrength * RSWIN_DESC.PSI__KPA
										Dim text As String = "0"
										text2 = Util.Format(num3, text)
									Else
										Dim sections10 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
										Dim num13 As Integer = CInt(num)
										Dim text As String = "0"
										text2 = Util.Format(sections10(num13).TensileStrength, text)
									End If
								Else
									text2 = Me.sNA
								End If
								If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num)).Grade) Or RSWIN_DESC.rst.Sections(CInt(num)).Grade = 4100S Then
									text2 = Me.sNA
								End If
								avLabels10.Text = text2
							End If
					End Select
				End If
				num += 1L
			Loop While num <= 40L
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
			Loop While num <= 40L
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
			Dim lastTop As Single = CSng((CDbl(Me.m_LastTop) + 1.5 * CDbl(Me.lblRSFootnote1.Height)))
			Dim lblRSFootnote As DataDynamics.ActiveReports.Label = Me.lblRSFootnote6
			Me.ShowTrailer(lastTop, Me.lblRSFootnote1, Me.lblRSFootnote2, Me.lblRSFootnote3, Me.lblRSFootnote4, Me.lblRSFootnote5, lblRSFootnote)
			Me.lblRSFootnote6 = lblRSFootnote
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
					If CUSTOMRG.IsOtherSteel(CInt(cRODSTAR.Sections(Conversions.ToInteger(obj)).Grade)) Then
						text2 = Strings.Trim(cRODSTAR.Sections(Conversions.ToInteger(obj)).RodType)
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
					End If
					text4 = String.Concat(New String() { text6, " ", text, Strings.Space(7 - Strings.Len(text)), "|", text2, Strings.Space(13 - Strings.Len(text2)), "|  ", text3, Strings.Space(6 - Strings.Len(text3)), "|     ", text5 })
					RESULTS1.Trx(text4, "|", ChrW(1))
				Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj3, obj)
			End If
			cRODSTAR = Nothing
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

		Private Sub ShowTrailer(ByRef cyTop As Single, ByRef avLabels1 As DataDynamics.ActiveReports.Label, ByRef avLabels2 As DataDynamics.ActiveReports.Label, ByRef avLabels3 As DataDynamics.ActiveReports.Label, ByRef avLabels4 As DataDynamics.ActiveReports.Label, ByRef avLabels5 As DataDynamics.ActiveReports.Label, ByRef avLabels6 As DataDynamics.ActiveReports.Label)
			Dim num As Long = 0L
			Dim array As String() = New String(4) {}
			Try
				If Me.mbMsgFullOKNeeded Then
					array(CInt(num)) = Me.sAsterickMsg
					num += 1L
				End If
				If Me.mbMsgSlimNeededNeeded Then
					array(CInt(num)) = Me.sPlusMsg
					num += 1L
				End If
				If Me.mbMsgNoNeckNeeded Then
					array(CInt(num)) = Me.sPoundSignMsg
					num += 1L
				End If
				If Me.mbMsgElevatorNeck1_0Needed Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						array(CInt(num)) = "@ Stress calculations based on elevator neck of 22.2mm (for 31.8mm sinker bars) or 25.4mm (for other sinker bars)."
					Else
						array(CInt(num)) = Me.sAtSignMsg
					End If
					num += 1L
				End If
				Try
					Dim num2 As Integer
					If RSWIN.bHasRelocatedSB(num2) Then
						array(CInt(num)) = RSWIN_DESC.sSBRelocateFootnote
						num += 1L
					End If
				Catch ex As Exception
				End Try
				Dim num3 As Long = 1L
				Dim num4 As Long = num
				For num5 As Long = num3 To num4
					Dim num6 As Long = num5
					Dim label As DataDynamics.ActiveReports.Label
					If num6 <= 6L AndAlso num6 >= 1L Then
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
							Case 5
								label = avLabels6
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
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub ShowTubingAndPump()
			Dim label As DataDynamics.ActiveReports.Label = Me.txtDownstrokeFriction
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Single = rst.DownstrokeFriction
			Dim text As String = "0.0#"
			Dim text2 As String = Util.Format(num, text)
			rst.DownstrokeFriction = num
			label.Text = text2
			Dim flag As Boolean = RSWIN_DESC.rst.CalcFriction <> 0S
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
			Dim flag2 As Boolean = RSWIN_DESC.rst.CalcPlungerSize <> 0S
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
			If RSWIN_DESC.rst.gbCalcPumpCondition And RSWIN_DESC.rst.PumpCondition = 2S Then
				text3 = Me.sCalcPumpFillage
			Else
				text3 = Me.sPumpVolEff
			End If
			Dim label8 As DataDynamics.ActiveReports.Label = Me.lblPumpEfficiency
			Dim w7 As Object = 25
			Dim pfill As Single = RSWIN_DESC.rst.Pfill
			text6 = "0.0#"
			label8.Text = RESULTS1.MkSumm(w7, text3, pfill, text6, True, False)
			Dim label9 As DataDynamics.ActiveReports.Label = Me.txtPumpEfficiency
			Dim w8 As Object = 0
			text6 = ""
			Dim pfill2 As Single = RSWIN_DESC.rst.Pfill
			text5 = "###%"
			label9.Text = RESULTS1.MkSumm(w8, text6, pfill2, text5, False, True)
			Dim label10 As DataDynamics.ActiveReports.Label = Me.lblPumpFriction
			Dim w9 As Object = 25
			Dim pumpFriction As Single = RSWIN_DESC.rst.PumpFriction
			Dim lb__N As Single = RSWIN_DESC.LB__N
			text6 = "0.0#"
			text5 = "0"
			label10.Text = RESULTS1.MkSummEM(w9, Me.sPumpFriction, pumpFriction, lb__N, RSWIN_DESC.lbs, text6, RSWIN_DESC.N, text5, 1, True, False)
			Dim label11 As DataDynamics.ActiveReports.Label = Me.txtPumpFriction
			Dim w10 As Object = 0
			text6 = ""
			Dim pumpFriction2 As Single = RSWIN_DESC.rst.PumpFriction
			Dim lb__N2 As Single = RSWIN_DESC.LB__N
			text5 = "0.0#"
			text4 = "0"
			label11.Text = RESULTS1.MkSummEM(w10, text6, pumpFriction2, lb__N2, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text4, 1, False, True)
			Dim label12 As DataDynamics.ActiveReports.Label = Me.lblPumpLoadAdj
			Dim w11 As Object = 25
			Dim pumpLoadAdj As Single = RSWIN_DESC.rst.PumpLoadAdj
			Dim lb__N3 As Single = RSWIN_DESC.LB__N
			text6 = "0.0#"
			text5 = "0"
			label12.Text = RESULTS1.MkSummEM(w11, Me.sPumpLoadAdj, pumpLoadAdj, lb__N3, RSWIN_DESC.lbs, text6, RSWIN_DESC.N, text5, 1, True, False)
			Dim label13 As DataDynamics.ActiveReports.Label = Me.txtPumpLoadAdj
			Dim w12 As Object = 0
			text6 = ""
			Dim pumpLoadAdj2 As Single = RSWIN_DESC.rst.PumpLoadAdj
			Dim lb__N4 As Single = RSWIN_DESC.LB__N
			text5 = "0.0#"
			text4 = "0"
			label13.Text = RESULTS1.MkSummEM(w12, text6, pumpLoadAdj2, lb__N4, RSWIN_DESC.lbs, text5, RSWIN_DESC.N, text4, 1, False, True)
			Select Case RSWIN_DESC.rst.PumpType
				Case 1S
					text3 = Me.sInsert
				Case 2S
					text3 = Me.sTubing
				Case 3S
					text3 = Me.sLargeBore
			End Select
			Dim label14 As DataDynamics.ActiveReports.Label = Me.lblPumpType
			Dim w13 As Object = 23
			Dim value3 As Single = 0F
			text6 = "#""" + text3 + """"
			label14.Text = RESULTS1.MkSumm(w13, Me.sPumpType, value3, text6, True, False)
			Dim label15 As DataDynamics.ActiveReports.Label = Me.txtPumpType
			Dim w14 As Object = 0
			text6 = ""
			Dim value4 As Single = 0F
			text5 = "#""" + text3 + """"
			label15.Text = RESULTS1.MkSumm(w14, text6, value4, text5, False, True)
			If RSWIN_DESC.rst.TubingAnchored <> 0S Then
				Dim label16 As DataDynamics.ActiveReports.Label = Me.lblTubingAnchorDepth
				Dim w15 As Object = 25
				Dim tubingAnchorDepth As Single = RSWIN_DESC.rst.TubingAnchorDepth
				Dim ft__M3 As Single = RSWIN_DESC.FT__M
				text6 = "0"
				text5 = "m"
				text4 = "0"
				label16.Text = RESULTS1.MkSummEM(w15, Me.sTubAnchDepth, tubingAnchorDepth, ft__M3, RSWIN_DESC.ft, text6, text5, text4, 3, True, False)
				Dim label17 As DataDynamics.ActiveReports.Label = Me.txtTubingAnchorDepth
				Dim w16 As Object = 0
				text6 = ""
				Dim tubingAnchorDepth2 As Single = RSWIN_DESC.rst.TubingAnchorDepth
				Dim ft__M4 As Single = RSWIN_DESC.FT__M
				text5 = "0"
				text4 = "m"
				text = "0"
				label17.Text = RESULTS1.MkSummEM(w16, text6, tubingAnchorDepth2, ft__M4, RSWIN_DESC.ft, text5, text4, text, 3, False, True)
			Else
				Me.lblTubingAnchorDepth.Text = Me.sTubingNotAnchored
				Me.txtTubingAnchorDepth.Text = ""
			End If
			Me.lblUpstrokeFriction.Text = Me.sUpstrokeFriction
			Me.lblDownstrokeFriction.Text = Me.sDownstrokeFriction
			Dim label18 As DataDynamics.ActiveReports.Label = Me.lblTubingID
			Dim w17 As Object = 23
			Dim tubingID As Single = RSWIN_DESC.rst.TubingID
			Dim in__MM3 As Single = RSWIN_DESC.IN__MM
			text6 = "0.000"
			text5 = "0.000"
			label18.Text = RESULTS1.MkSummEM(w17, Me.sTubingID, tubingID, in__MM3, RSWIN_DESC.ins, text6, RSWIN_DESC.mm, text5, 3, True, False)
			Dim label19 As DataDynamics.ActiveReports.Label = Me.lblTubingOD
			Dim w18 As Object = 23
			Dim tubingOD As Single = RSWIN_DESC.rst.TubingOD
			Dim in__MM4 As Single = RSWIN_DESC.IN__MM
			text6 = "0.000"
			text5 = "0.000"
			label19.Text = RESULTS1.MkSummEM(w18, Me.sTubingOD, tubingOD, in__MM4, RSWIN_DESC.ins, text6, RSWIN_DESC.mm, text5, 3, True, False)
			Dim label20 As DataDynamics.ActiveReports.Label = Me.txtTubingID
			Dim w19 As Object = 0
			text6 = ""
			Dim tubingID2 As Single = RSWIN_DESC.rst.TubingID
			Dim in__MM5 As Single = RSWIN_DESC.IN__MM
			text5 = "0.000"
			text4 = "0.000"
			label20.Text = RESULTS1.MkSummEM(w19, text6, tubingID2, in__MM5, RSWIN_DESC.ins, text5, RSWIN_DESC.mm, text4, 3, False, True)
			Dim label21 As DataDynamics.ActiveReports.Label = Me.txtTubingOD
			Dim w20 As Object = 0
			text6 = ""
			Dim tubingOD2 As Single = RSWIN_DESC.rst.TubingOD
			Dim in__MM6 As Single = RSWIN_DESC.IN__MM
			text5 = "0.000"
			text4 = "0.000"
			label21.Text = RESULTS1.MkSummEM(w20, text6, tubingOD2, in__MM6, RSWIN_DESC.ins, text5, RSWIN_DESC.mm, text4, 3, False, True)
			Dim label22 As DataDynamics.ActiveReports.Label = Me.txtUpstrokeFriction
			rst = RSWIN_DESC.rst
			num = rst.UpstrokeFriction
			text6 = "0.000#"
			Dim text7 As String = Util.Format(num, text6)
			rst.UpstrokeFriction = num
			label22.Text = text7
			Dim label23 As DataDynamics.ActiveReports.Label = Me.txtDownstrokeFriction
			rst = RSWIN_DESC.rst
			num = rst.DownstrokeFriction
			text6 = "0.000#"
			Dim text8 As String = Util.Format(num, text6)
			rst.DownstrokeFriction = num
			label23.Text = text8
			Dim flag3 As Boolean = RSWIN_DESC.rst.CalcFriction <> 0S
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

		Private Sub AddRexResource(sKey As String, sVal As String)
			RSWIN_DESC.RwX.AddResource(sKey, sVal)
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
			sPrefix = "rptResultsInputs-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
			Try
				Dim num7 As Integer = 0
				Dim num8 As Integer = Me.PageHeader.Controls.Count - 1
				For i As Integer = num7 To num8
					Try
						If Me.PageHeader.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.PageHeader.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex5 As Exception
					End Try
				Next
				Dim num9 As Integer = 0
				Dim num10 As Integer = Me.PageFooter.Controls.Count - 1
				For i As Integer = num9 To num10
					Try
						If Me.PageFooter.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.PageFooter.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex6 As Exception
					End Try
				Next
				Dim num11 As Integer = 0
				Dim num12 As Integer = Me.Detail.Controls.Count - 1
				For i As Integer = num11 To num12
					Try
						If Me.Detail.Controls(i).[GetType]() Is GetType(DataDynamics.ActiveReports.Label) Then
							Dim label As DataDynamics.ActiveReports.Label = CType(Me.Detail.Controls(i), DataDynamics.ActiveReports.Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex7 As Exception
					End Try
				Next
			Catch ex8 As Exception
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

		Public Function SpdVarIncludedNotWritten() As Boolean
			Dim result As Boolean = False
			If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), RSWIN_DESC.rst.CalcMotorSize)) AndAlso RSWIN_DESC.rst.MotorSPV = 0F Then
				result = True
			End If
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

		Private lblRodDiam10 As DataDynamics.ActiveReports.Label

		Private linRSInputSep4 As Line

		Private linRSInputSep1 As Line

		Private linRSInputSep2 As Line

		Private linRSInputSep3 As Line

		Private Line1 As Line

		Private lblInputData As DataDynamics.ActiveReports.Label

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

		Private Line11 As Line

		Private lblRodDiamHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodDiamHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodDiam1 As DataDynamics.ActiveReports.Label

		Private lblRodGradeHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodLengthHdrBot As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrengthHdrBot As DataDynamics.ActiveReports.Label

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

		Private lblFLPIP_3 As DataDynamics.ActiveReports.Label

		Private lblSPM As DataDynamics.ActiveReports.Label

		Private lblPumpFriction As DataDynamics.ActiveReports.Label

		Private lblPumpEfficiency As DataDynamics.ActiveReports.Label

		Private lblPumpLoadAdj As DataDynamics.ActiveReports.Label

		Private lblTubingAnchorDepth As DataDynamics.ActiveReports.Label

		Private lblDownstrokeFriction As DataDynamics.ActiveReports.Label

		Private lblPumpType As DataDynamics.ActiveReports.Label

		Private lblPumpCondition As DataDynamics.ActiveReports.Label

		Private lblPumpDepth As DataDynamics.ActiveReports.Label

		Private lblTubingPressure As DataDynamics.ActiveReports.Label

		Private lblRodGradeHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrengthHdrTop As DataDynamics.ActiveReports.Label

		Private lblRodLengthHdrTop As DataDynamics.ActiveReports.Label

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

		Private txtCrankHole As DataDynamics.ActiveReports.Label

		Private txtStrokeLength As DataDynamics.ActiveReports.Label

		Private txtCrankRotation As DataDynamics.ActiveReports.Label

		Private txtCwtInfo_1 As DataDynamics.ActiveReports.Label

		Private txtCwtInfo_2 As DataDynamics.ActiveReports.Label

		Private txtCwtInfo_3 As DataDynamics.ActiveReports.Label

		Private txtCwtInfo_4 As DataDynamics.ActiveReports.Label

		Private txtCwtInfo_5 As DataDynamics.ActiveReports.Label

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

		Private lblRodDiam9 As DataDynamics.ActiveReports.Label

		Private lblRodGrade9 As DataDynamics.ActiveReports.Label

		Private lblRodLength9 As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrength9 As DataDynamics.ActiveReports.Label

		Private lblFricCoef9 As DataDynamics.ActiveReports.Label

		Private lblRodGrade10 As DataDynamics.ActiveReports.Label

		Private lblRodLength10 As DataDynamics.ActiveReports.Label

		Private lblRodTensileStrength10 As DataDynamics.ActiveReports.Label

		Private lblFricCoef10 As DataDynamics.ActiveReports.Label

		Private Line12 As Line

		Private lblRSFootnote2 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote5 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote4 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote3 As DataDynamics.ActiveReports.Label

		Private lblRSFootnote1 As DataDynamics.ActiveReports.Label

		Private lblPolRodDiam As DataDynamics.ActiveReports.Label

		<AccessedThroughProperty("lblRSFootnote6")>
		Private _lblRSFootnote6 As DataDynamics.ActiveReports.Label

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

		Private sAdjustedStrokeLength As String

		Private sAtSignMsg_M As String

		Private sPumpEfficiencyFillage As String

		Private fEffFill As String

		Private sReqUnbalance As String

		Private sCalculatedResults As String

		Private sRotation As String

		Private sBalRotInertia As String

		Private sEnteredRotInertia As String

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
