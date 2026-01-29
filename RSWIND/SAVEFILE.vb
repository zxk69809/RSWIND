Imports System
Imports System.Collections
Imports System.Data
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module SAVEFILE
		Public Sub StoreAscii(rfn As String)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(FileSystem.FreeFile())
			FileSystem.FileOpen(CInt(num), rfn, OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
			FileSystem.PrintLine(CInt(num), New Object() { "RSMagic=" + RSWIN_DESC.RSMagic })
			FileSystem.PrintLine(CInt(num), New Object() { "RSVersion=" + Conversions.ToString(29) })
			FileSystem.PrintLine(CInt(num), New Object() { "CompanyName=" + RSWIN_DESC.rst.ACompanyName })
			FileSystem.PrintLine(CInt(num), New Object() { "WellName=" + RSWIN_DESC.rst.WellName })
			FileSystem.PrintLine(CInt(num), New Object() { "UserName=" + RSWIN_DESC.rst.UserName })
			FileSystem.PrintLine(CInt(num), New Object() { "UserDate=" + RSWIN_DESC.rst.UserDate })
			FileSystem.PrintLine(CInt(num), New Object() { "PumpCondition=" + Conversions.ToString(CInt(RSWIN_DESC.rst.PumpCondition)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PumpEfficiency!=" + Conversions.ToString(RSWIN_DESC.rst.PumpEfficiency) })
			FileSystem.PrintLine(CInt(num), New Object() { "PumpFillage!=" + Conversions.ToString(RSWIN_DESC.rst.PumpFillage) })
			FileSystem.PrintLine(CInt(num), New Object() { "PumpDepth!=" + Conversions.ToString(RSWIN_DESC.rst.PumpDepth) })
			FileSystem.PrintLine(CInt(num), New Object() { "FluidLevel!=" + Conversions.ToString(RSWIN_DESC.rst.FluidLevel) })
			FileSystem.PrintLine(CInt(num), New Object() { "SPMEntered=" + Conversions.ToString(CInt(RSWIN_DESC.rst.SPMEntered)) })
			FileSystem.PrintLine(CInt(num), New Object() { "SPM!=" + Conversions.ToString(RSWIN_DESC.rst.SPM) })
			FileSystem.PrintLine(CInt(num), New Object() { "TargetBFPD!=" + Conversions.ToString(RSWIN_DESC.rst.TargetBFPD) })
			FileSystem.PrintLine(CInt(num), New Object() { "PumpType=" + Conversions.ToString(CInt(RSWIN_DESC.rst.PumpType)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PlungerSize!=" + Conversions.ToString(RSWIN_DESC.rst.PlungerSize) })
			FileSystem.PrintLine(CInt(num), New Object() { "CalcPlungerSize=" + Conversions.ToString(CInt(RSWIN_DESC.rst.CalcPlungerSize)) })
			FileSystem.PrintLine(CInt(num), New Object() { "FluidSPGR!=" + Conversions.ToString(RSWIN_DESC.rst.FluidSPGR) })
			FileSystem.PrintLine(CInt(num), New Object() { "CalcFriction=" + Conversions.ToString(CInt(RSWIN_DESC.rst.CalcFriction)) })
			FileSystem.PrintLine(CInt(num), New Object() { "IncludeFluidInertia=" + Conversions.ToString(CInt(RSWIN_DESC.rst.IncludeFluidInertia)) })
			FileSystem.PrintLine(CInt(num), New Object() { "CompressibilityIndex!=" + Conversions.ToString(RSWIN_DESC.rst.CompressibilityIndex) })
			FileSystem.PrintLine(CInt(num), New Object() { "TubingOD!=" + Conversions.ToString(RSWIN_DESC.rst.TubingOD) })
			FileSystem.PrintLine(CInt(num), New Object() { "TubingID!=" + Conversions.ToString(RSWIN_DESC.rst.TubingID) })
			FileSystem.PrintLine(CInt(num), New Object() { "TubingAnchored=" + Conversions.ToString(CInt(RSWIN_DESC.rst.TubingAnchored)) })
			FileSystem.PrintLine(CInt(num), New Object() { "TubingAnchorDepth!=" + Conversions.ToString(RSWIN_DESC.rst.TubingAnchorDepth) })
			FileSystem.PrintLine(CInt(num), New Object() { "TubingPressure!=" + Conversions.ToString(RSWIN_DESC.rst.TubingPressure) })
			FileSystem.PrintLine(CInt(num), New Object() { "CasingPressure!=" + Conversions.ToString(RSWIN_DESC.rst.CasingPressure) })
			FileSystem.PrintLine(CInt(num), New Object() { "RodStringType=" + Conversions.ToString(CInt(RSWIN_DESC.rst.RodStringType)) })
			FileSystem.PrintLine(CInt(num), New Object() { "APIRod=" + Conversions.ToString(CInt(RSWIN_DESC.rst.APIRod)) })
			FileSystem.PrintLine(CInt(num), New Object() { "APIGrade=" + Conversions.ToString(CInt(RSWIN_DESC.rst.APIGrade)) })
			FileSystem.PrintLine(CInt(num), New Object() { "NumRods=" + Conversions.ToString(CInt(RSWIN_DESC.rst.NumRods)) })
			Dim num2 As Short = 1S
			Dim numRods As Short = RSWIN_DESC.rst.NumRods
			For num3 As Short = num2 To numRods
				FileSystem.PrintLine(CInt(num), New Object() { "Sections(" + Conversions.ToString(CInt(num3)) + ").Grade=" + Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(CInt(num3)).Grade)) })
				FileSystem.PrintLine(CInt(num), New Object() { "Sections(" + Conversions.ToString(CInt(num3)) + ").Diameter=" + Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num3)).Diameter) })
				FileSystem.PrintLine(CInt(num), New Object() { "Sections(" + Conversions.ToString(CInt(num3)) + ").Length=" + Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num3)).length) })
				FileSystem.PrintLine(CInt(num), New Object() { "Sections(" + Conversions.ToString(CInt(num3)) + ").SuckerRodLength=" + Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num3)).SuckerRodLength) })
				FileSystem.PrintLine(CInt(num), New Object() { "Sections(" + Conversions.ToString(CInt(num3)) + ").RodDensity=" + Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num3)).RodDensity) })
				FileSystem.PrintLine(CInt(num), New Object() { "Sections(" + Conversions.ToString(CInt(num3)) + ").RodWeight=" + Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num3)).RodWeight) })
				FileSystem.PrintLine(CInt(num), New Object() { "Sections(" + Conversions.ToString(CInt(num3)) + ").Elasticity=" + Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num3)).Elasticity) })
				FileSystem.PrintLine(CInt(num), New Object() { "Sections(" + Conversions.ToString(CInt(num3)) + ").Area=" + Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num3)).Area) })
				FileSystem.PrintLine(CInt(num), New Object() { "Sections(" + Conversions.ToString(CInt(num3)) + ").RodType=" + RSWIN_DESC.rst.Sections(CInt(num3)).RodType })
				FileSystem.PrintLine(CInt(num), New Object() { "Sections(" + Conversions.ToString(CInt(num3)) + ").TensileStrength=" + Conversions.ToString(RSWIN_DESC.rst.Sections(CInt(num3)).TensileStrength) })
			Next
			FileSystem.PrintLine(CInt(num), New Object() { "RSGrade=" + Conversions.ToString(CInt(RSWIN_DESC.rst.RSGrade)) })
			FileSystem.PrintLine(CInt(num), New Object() { "RSSuckerRodLength!=" + Conversions.ToString(RSWIN_DESC.rst.RSSuckerRodLength) })
			FileSystem.PrintLine(CInt(num), New Object() { "RSMaxSize!=" + Conversions.ToString(RSWIN_DESC.rst.RSMaxSize) })
			FileSystem.PrintLine(CInt(num), New Object() { "RSMinSize!=" + Conversions.ToString(RSWIN_DESC.rst.RSMinSize) })
			FileSystem.PrintLine(CInt(num), New Object() { "ServiceFactor!=" + Conversions.ToString(RSWIN_DESC.rst.ServiceFactor) })
			FileSystem.PrintLine(CInt(num), New Object() { "UnitID=" + RSWIN_DESC.rst.UnitID })
			FileSystem.PrintLine(CInt(num), New Object() { "IDEntered=" + Conversions.ToString(CInt(RSWIN_DESC.rst.IDEntered)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.Manuf=" + RSWIN_DESC.rst.PU.Manuf })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.UnitName=" + RSWIN_DESC.rst.PU.UnitName })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.APIDesignation=" + RSWIN_DESC.rst.PU.APIDesignation })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.UnitType=" + Conversions.ToString(CInt(RSWIN_DESC.rst.PU.UnitType)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.RequiredRotation=" + Conversions.ToString(CInt(RSWIN_DESC.rst.PU.RequiredRotation)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.CrankRotation=" + Conversions.ToString(CInt(RSWIN_DESC.rst.PU.CrankRotation)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.CrankHole=" + Conversions.ToString(CInt(RSWIN_DESC.rst.PU.CrankHole)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.CrankHoles=" + Conversions.ToString(CInt(RSWIN_DESC.rst.PU.CrankHoles)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.CrankRadii(1)=" + Conversions.ToString(RSWIN_DESC.rst.PU.CrankRadii(1)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.CrankRadii(2)=" + Conversions.ToString(RSWIN_DESC.rst.PU.CrankRadii(2)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.CrankRadii(3)=" + Conversions.ToString(RSWIN_DESC.rst.PU.CrankRadii(3)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.CrankRadii(4)=" + Conversions.ToString(RSWIN_DESC.rst.PU.CrankRadii(4)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.CrankRadii(5)=" + Conversions.ToString(RSWIN_DESC.rst.PU.CrankRadii(5)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.Strokes(1)=" + Conversions.ToString(RSWIN_DESC.rst.PU.Strokes(1)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.Strokes(2)=" + Conversions.ToString(RSWIN_DESC.rst.PU.Strokes(2)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.Strokes(3)=" + Conversions.ToString(RSWIN_DESC.rst.PU.Strokes(3)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.Strokes(4)=" + Conversions.ToString(RSWIN_DESC.rst.PU.Strokes(4)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.Strokes(5)=" + Conversions.ToString(RSWIN_DESC.rst.PU.Strokes(5)) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.KinematicStroke=" + Conversions.ToString(RSWIN_DESC.rst.PU.KinematicStroke) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.R=" + Conversions.ToString(RSWIN_DESC.rst.PU.R) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.A=" + Conversions.ToString(RSWIN_DESC.rst.PU.A) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.C=" + Conversions.ToString(RSWIN_DESC.rst.PU.C) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.I=" + Conversions.ToString(RSWIN_DESC.rst.PU.I) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.K=" + Conversions.ToString(RSWIN_DESC.rst.PU.K) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.P=" + Conversions.ToString(RSWIN_DESC.rst.PU.P) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.M=" + Conversions.ToString(RSWIN_DESC.rst.PU.M) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.S=" + Conversions.ToString(RSWIN_DESC.rst.PU.S) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.V0=" + Conversions.ToString(RSWIN_DESC.rst.PU.V0) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.DrumDiamRatio=" + Conversions.ToString(RSWIN_DESC.rst.PU.DrumDiamRatio) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.SprocketRadius=" + Conversions.ToString(RSWIN_DESC.rst.PU.SprocketRadius) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.SprocketDistance=" + Conversions.ToString(RSWIN_DESC.rst.PU.SprocketDistance) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.Unbalance=" + Conversions.ToString(RSWIN_DESC.rst.PU.Unbalance) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.CrankOffset=" + Conversions.ToString(RSWIN_DESC.rst.PU.CrankOffset) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.StructRating=" + Conversions.ToString(RSWIN_DESC.rst.PU.StructRating) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.GearboxRating=" + Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.MaxStroke=" + Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.ArtInertia=" + Conversions.ToString(RSWIN_DESC.rst.PU.ArtInertia) })
			FileSystem.PrintLine(CInt(num), New Object() { "ElectricityCost!=" + Conversions.ToString(RSWIN_DESC.rst.ElectricityCost) })
			FileSystem.PrintLine(CInt(num), New Object() { "PowerMeterType=" + Conversions.ToString(CInt(RSWIN_DESC.rst.PowerMeterType)) })
			FileSystem.PrintLine(CInt(num), New Object() { "M!(Existing)=" + Conversions.ToString(RSWIN_DESC.rst.get_M(2)) })
			FileSystem.PrintLine(CInt(num), New Object() { "MotorSPV!=" + Conversions.ToString(RSWIN_DESC.rst.MotorSPV) })
			FileSystem.PrintLine(CInt(num), New Object() { "Iart!=" + Conversions.ToString(RSWIN_DESC.rst.Iart) })
			FileSystem.PrintLine(CInt(num), New Object() { "Irot!=" + Conversions.ToString(RSWIN_DESC.rst.Irot) })
			FileSystem.PrintLine(CInt(num), New Object() { "IrotEntered=" + Conversions.ToString(CInt(RSWIN_DESC.rst.IrotEntered)) })
			FileSystem.PrintLine(CInt(num), New Object() { "FluidLevelEntered=" + Conversions.ToString(RSWIN_DESC.rst.FluidLevelEntered) })
			FileSystem.PrintLine(CInt(num), New Object() { "PumpIntakePressure!=" + Conversions.ToString(RSWIN_DESC.rst.PumpIntakePressure) })
			FileSystem.PrintLine(CInt(num), New Object() { "Runtime!=" + Conversions.ToString(RSWIN_DESC.rst.Runtime) })
			FileSystem.PrintLine(CInt(num), New Object() { "WaterCut!=" + Conversions.ToString(RSWIN_DESC.rst.WaterCut) })
			FileSystem.PrintLine(CInt(num), New Object() { "OilAPI!=" + Conversions.ToString(RSWIN_DESC.rst.OilAPI) })
			FileSystem.PrintLine(CInt(num), New Object() { "RSIncludeSB=" + Conversions.ToString(CInt(RSWIN_DESC.rst.RSIncludeSB)) })
			FileSystem.PrintLine(CInt(num), New Object() { "SinkerBar.Grade=" + Conversions.ToString(CInt(RSWIN_DESC.rst.SinkerBar.Grade)) })
			FileSystem.PrintLine(CInt(num), New Object() { "SinkerBar.Diameter=" + Conversions.ToString(RSWIN_DESC.rst.SinkerBar.Diameter) })
			FileSystem.PrintLine(CInt(num), New Object() { "SinkerBar.Length=" + Conversions.ToString(RSWIN_DESC.rst.SinkerBar.length) })
			FileSystem.PrintLine(CInt(num), New Object() { "SinkerBar.SuckerRodLength=" + Conversions.ToString(RSWIN_DESC.rst.SinkerBar.SuckerRodLength) })
			FileSystem.PrintLine(CInt(num), New Object() { "SinkerBar.RodDensity=" + Conversions.ToString(RSWIN_DESC.rst.SinkerBar.RodDensity) })
			FileSystem.PrintLine(CInt(num), New Object() { "SinkerBar.RodWeight=" + Conversions.ToString(RSWIN_DESC.rst.SinkerBar.RodWeight) })
			FileSystem.PrintLine(CInt(num), New Object() { "SinkerBar.Elasticity=" + Conversions.ToString(RSWIN_DESC.rst.SinkerBar.Elasticity) })
			FileSystem.PrintLine(CInt(num), New Object() { "SinkerBar.Area=" + Conversions.ToString(RSWIN_DESC.rst.SinkerBar.Area) })
			FileSystem.PrintLine(CInt(num), New Object() { "SinkerBar.RodType=" + RSWIN_DESC.rst.SinkerBar.RodType })
			FileSystem.PrintLine(CInt(num), New Object() { "SinkerBar.TensileStrength=" + Conversions.ToString(RSWIN_DESC.rst.SinkerBar.TensileStrength) })
			FileSystem.PrintLine(CInt(num), New Object() { "UpstrokeFriction!=" + Conversions.ToString(RSWIN_DESC.rst.UpstrokeFriction) })
			FileSystem.PrintLine(CInt(num), New Object() { "DownstrokeFriction!=" + Conversions.ToString(RSWIN_DESC.rst.DownstrokeFriction) })
			FileSystem.PrintLine(CInt(num), New Object() { "StuffingBoxFriction!=" + Conversions.ToString(RSWIN_DESC.rst.StuffingBoxFriction) })
			FileSystem.PrintLine(CInt(num), New Object() { "PumpLoadAdj!=" + Conversions.ToString(RSWIN_DESC.rst.PumpLoadAdj) })
			FileSystem.PrintLine(CInt(num), New Object() { "APIRodType$=""" + RSWIN_DESC.rst.APIRodType + """" })
			FileSystem.PrintLine(CInt(num), New Object() { "APITensileStrength!=" + Conversions.ToString(RSWIN_DESC.rst.APITensileStrength) })
			FileSystem.PrintLine(CInt(num), New Object() { "RSRodType$=""" + RSWIN_DESC.rst.RSRodType + """" })
			FileSystem.PrintLine(CInt(num), New Object() { "RSTensileStrength!=" + Conversions.ToString(RSWIN_DESC.rst.RSTensileStrength) })
			FileSystem.PrintLine(CInt(num), New Object() { "PU.OtherInfo=" + RSWIN_DESC.rst.PU.OtherInfo })
			FileSystem.PrintLine(CInt(num), New Object() { "CBDataFile$=""" + RSWIN_DESC.rst.CBDataFile + """" })
			FileSystem.PrintLine(CInt(num), New Object() { "CalcMotorSPV=" + Conversions.ToString(CInt(RSWIN_DESC.rst.CalcMotorSPV)) })
			FileSystem.PrintLine(CInt(num), New Object() { "CalcMotorSize=" + Conversions.ToString(CInt(RSWIN_DESC.rst.CalcMotorSize)) })
			FileSystem.PrintLine(CInt(num), New Object() { "MotorType=" + Conversions.ToString(CInt(RSWIN_DESC.rst.MotorType)) })
			FileSystem.PrintLine(CInt(num), New Object() { "MotorSize!=" + Conversions.ToString(CInt(RSWIN_DESC.rst.MotorSize)) })
			Dim num4 As Short
			FileSystem.PrintLine(CInt(num), New Object() { "TorqueMode=" + Conversions.ToString(CInt(num4)) })
			Dim str As String
			FileSystem.PrintLine(CInt(num), New Object() { "gsMotorSizeName=""" + str + """" })
			FileSystem.PrintLine(CInt(num), New Object() { "WaterSPGR!=" + Conversions.ToString(RSWIN_DESC.rst.WaterSPGR) })
			FileSystem.PrintLine(CInt(num), New Object() { "gbRoddiagFile=" + Conversions.ToString(RSWIN_DESC.rst.gbRoddiagFile) })
			If RSWIN_DESC.rst.gbRoddiagFile Then
				FileSystem.PrintLine(CInt(num), New Object() { "RDNtsteps=" + Conversions.ToString(CInt(RSWIN_DESC.rst.RDNtsteps)) })
				Dim num5 As Short = 0S
				Dim num6 As Short = RSWIN_DESC.rst.RDNtsteps - 1S
				For num3 As Short = num5 To num6
					FileSystem.PrintLine(CInt(num), New Object() { "RDSurfPos!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.RDSurfPos(CInt(num3))) })
					FileSystem.PrintLine(CInt(num), New Object() { "RDSurfLoad!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.RDSurfLoad(CInt(num3))) })
				Next
			End If
			FileSystem.PrintLine(CInt(num), New Object() { "RSExtraCost!=" + Conversions.ToString(RSWIN_DESC.rst.RSExtraCost) })
			FileSystem.PrintLine(CInt(num), New Object() { "RSExtraCostLabel$=""" + RSWIN_DESC.rst.RSExtraCostLabel + """" })
			FileSystem.PrintLine(CInt(num), New Object() { "BPDSurface!=" + Conversions.ToString(RSWIN_DESC.rst.BPDsurface) })
			FileSystem.PrintLine(CInt(num), New Object() { "FluidLoad!=" + Conversions.ToString(RSWIN_DESC.rst.FluidLoad) })
			FileSystem.PrintLine(CInt(num), New Object() { "FoSkr!=" + Conversions.ToString(RSWIN_DESC.rst.FoSkr) })
			FileSystem.PrintLine(CInt(num), New Object() { "GrossPumpStroke!=" + Conversions.ToString(RSWIN_DESC.rst.GrossPumpStroke) })
			FileSystem.PrintLine(CInt(num), New Object() { "MaxRodStressL!=" + Conversions.ToString(RSWIN_DESC.rst.MaxRodStressL) })
			FileSystem.PrintLine(CInt(num), New Object() { "MinMotorHP!=" + Conversions.ToString(RSWIN_DESC.rst.MinMotorHP) })
			FileSystem.PrintLine(CInt(num), New Object() { "Mprload!=" + Conversions.ToString(RSWIN_DESC.rst.Mprload) })
			FileSystem.PrintLine(CInt(num), New Object() { "NoverNoP!=" + Conversions.ToString(RSWIN_DESC.rst.NoverNoP) })
			FileSystem.PrintLine(CInt(num), New Object() { "Ntsteps=" + Conversions.ToString(CInt(RSWIN_DESC.rst.Ntsteps)) })
			FileSystem.PrintLine(CInt(num), New Object() { "Pfill!=" + Conversions.ToString(RSWIN_DESC.rst.Pfill) })
			FileSystem.PrintLine(CInt(num), New Object() { "PlungerLength!=" + Conversions.ToString(RSWIN_DESC.rst.PlungerLength) })
			FileSystem.PrintLine(CInt(num), New Object() { "Pprload!=" + Conversions.ToString(RSWIN_DESC.rst.Pprload) })
			FileSystem.PrintLine(CInt(num), New Object() { "Prhp!=" + Conversions.ToString(RSWIN_DESC.rst.Prhp) })
			FileSystem.PrintLine(CInt(num), New Object() { "ProductionLoss!=" + Conversions.ToString(RSWIN_DESC.rst.ProductionLoss) })
			FileSystem.PrintLine(CInt(num), New Object() { "PumpLength!=" + Conversions.ToString(RSWIN_DESC.rst.PumpLength) })
			FileSystem.PrintLine(CInt(num), New Object() { "PumpSpacing!=" + Conversions.ToString(RSWIN_DESC.rst.PumpSpacing) })
			FileSystem.PrintLine(CInt(num), New Object() { "StartDownstroke=" + Conversions.ToString(RSWIN_DESC.rst.StartDownstroke) })
			FileSystem.PrintLine(CInt(num), New Object() { "StartUpstroke=" + Conversions.ToString(RSWIN_DESC.rst.StartUpstroke) })
			FileSystem.PrintLine(CInt(num), New Object() { "StructL!=" + Conversions.ToString(RSWIN_DESC.rst.StructL) })
			FileSystem.PrintLine(CInt(num), New Object() { "SystemEff!=" + Conversions.ToString(RSWIN_DESC.rst.SystemEff) })
			FileSystem.PrintLine(CInt(num), New Object() { "TotalTheta!=" + Conversions.ToString(RSWIN_DESC.rst.TotalTheta) })
			FileSystem.PrintLine(CInt(num), New Object() { "TubStretch!=" + Conversions.ToString(RSWIN_DESC.rst.TubStretch) })
			FileSystem.PrintLine(CInt(num), New Object() { "WrodsInfluid!=" + Conversions.ToString(RSWIN_DESC.rst.WrodsInFluid) })
			Dim num7 As Short = 0S
			Dim num8 As Short = CShort(RSWIN_DESC.rst.iUnknownM)
			For num3 As Short = num7 To num8
				FileSystem.PrintLine(CInt(num), New Object() { "CBE90!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.CBE90(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "Clf!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.Clf(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "DollarsPerBblFluid!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.DollarsPerBblFluid(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "DollarsPerBblOil!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.DollarsPerBblOil(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "ElectricBillPerMonth!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.get_ElectricBillperMonth(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "GearboxLoading!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.GearboxLoading(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "HpNemaD!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.HpNemaD(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "HpUhs!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.HpUhs(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "M!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.get_M(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "MotorKWH!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.MotorKWH(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "PeakTorque!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.PeakTorque(CInt(num3))) })
				Dim num9 As Short = 1S
				Dim ntsteps As Short = RSWIN_DESC.rst.Ntsteps
				For num10 As Short = num9 To ntsteps
					FileSystem.PrintLine(CInt(num), New Object() { String.Concat(New String() { "Tnet!(", Conversions.ToString(CInt(num3)), ", ", Conversions.ToString(CInt(num10)), ")=", Conversions.ToString(RSWIN_DESC.rst.Tnet(CInt(num3), CInt(num10))) }) })
				Next
			Next
			Dim num11 As Short = 1S
			Dim numRods2 As Short = RSWIN_DESC.rst.NumRods
			For num3 As Short = num11 To numRods2
				FileSystem.PrintLine(CInt(num), New Object() { "StressL!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.StressL(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "maxStressTop!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.maxStressTop(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "minStressTop!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.minStressTop(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "minStressBot!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.minStressBot(CInt(num3))) })
			Next
			Dim num12 As Short = 1S
			Dim ntsteps2 As Short = RSWIN_DESC.rst.Ntsteps
			For num3 As Short = num12 To ntsteps2
				FileSystem.PrintLine(CInt(num), New Object() { "SurfPos!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.SurfPos(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "SurfLoad!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.SurfLoad(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "PumpPos!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.PumpPos(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "PumpLoad!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.PumpLoad(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "PermLoad!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.PermLoad(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "Thetac!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.Thetac(CInt(num3))) })
				FileSystem.PrintLine(CInt(num), New Object() { "Tf!(" + Conversions.ToString(CInt(num3)) + ")=" + Conversions.ToString(RSWIN_DESC.rst.Tf(CInt(num3))) })
			Next
			FileSystem.FileClose(New Integer() { CInt(num) })
		End Sub

		Public Sub StoreFile(rfn As String, bStoreOutput As Boolean, ByRef DataStored As Boolean)
			Dim num2 As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				DataStored = False
				IL_06:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_0E:
				num = 3
				If Not FILEUTIL.FileExists(rfn) Then
					GoTo IL_23
				End If
				IL_1A:
				num = 4
				FileSystem.Kill(rfn)
				IL_23:
				num = 6
				If Information.Err().Number = 0 Then
					GoTo IL_45
				End If
				IL_33:
				num = 7
				Util.Errmsg("The data file could not be created.  Please make sure the file is writeable, or choose a different file name.")
				IL_40:
				GoTo IL_2BA
				IL_45:
				num = 9
				IL_49:
				num = 10
				Dim num3 As Short = CShort(FileSystem.FreeFile())
				IL_54:
				num = 11
				FileSystem.FileOpen(CInt(num3), rfn, OpenMode.Binary, OpenAccess.Write, OpenShare.LockWrite, -1)
				IL_64:
				num = 12
				Dim flag As Boolean = SAVEFILE.StoreInputData(num3)
				IL_6F:
				num = 13
				If Not flag Then
					GoTo IL_CF
				End If
				IL_76:
				num = 14
				Dim flag2 As Boolean = SAVEFILE.StoreOutputData(num3, bStoreOutput)
				IL_82:
				num = 15
				If flag2 Then
					GoTo IL_CF
				End If
				IL_89:
				num = 16
				FileSystem.FileClose(New Integer() { CInt(num3) })
				IL_9E:
				num = 17
				FileSystem.Kill(rfn)
				IL_A8:
				num = 18
				FileSystem.FileOpen(CInt(num3), rfn, OpenMode.Binary, OpenAccess.Write, OpenShare.LockWrite, -1)
				IL_B8:
				num = 19
				flag = SAVEFILE.StoreInputData(num3)
				IL_C3:
				num = 20
				flag2 = SAVEFILE.StoreOutputData(num3, False)
				IL_CF:
				num = 23
				FileSystem.FileClose(New Integer() { CInt(num3) })
				IL_E4:
				num = 24
				DataStored = (flag AndAlso flag2)
				IL_ED:
				num = 25
				If Not DataStored Then
					GoTo IL_102
				End If
				IL_F5:
				num = 26
				SAVEFILE.StoreDeviationProfile(rfn)
				IL_100:
				GoTo IL_110
				IL_102:
				num = 28
				IL_106:
				num = 29
				FileSystem.Kill(rfn)
				IL_110:
				GoTo IL_2BA
				IL_115:
				num = 33
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], Information.Err().Number - 61)
				GoTo IL_18D
				IL_15D:
				num = 37
				Util.cErrmsg(94)
				IL_168:
				GoTo IL_2BA
				IL_16D:
				num = 40
				Util.cErrmsg(95)
				IL_178:
				GoTo IL_2BA
				IL_17D:
				num = 43
				Util.cErrmsg(93)
				IL_188:
				GoTo IL_2BA
				IL_18D:
				num = 46
				Throw ProjectData.CreateProjectError(Information.Err().Number)
				IL_1A1:
				GoTo IL_2BA
				IL_1A6:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_276:
				GoTo IL_2AF
				IL_278:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_28B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_278
			End Try
			IL_2AF:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2BA:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Function StoreDeviationProfile(sRodstarFile As String) As Boolean
			Dim flag As Boolean = False
			Dim result As Boolean
			Try
				Dim num2 As Integer
				If RSWIN_DESC.mdsDeviationProfile IsNot Nothing AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 2 Then
					Dim flag2 As Boolean = False
					If flag2 <> (Strings.Len(sRodstarFile) <> 0) Then
						Dim flag3 As Boolean = flag2
						Dim text As String = Nothing
						Dim text2 As String
						Dim text3 As String
						Dim text4 As String
						If flag3 <> FILEIO.SplitPath(sRodstarFile, text2, text3, text4, text) Then
							Dim flag4 As Boolean = flag2
							text = "deviationprofile"
							Dim fileName As String
							If flag4 <> FILEIO.MakePath(fileName, text2, text3, text4, text) Then
								Dim num As Integer = 1
								num2 = FileSystem.FreeFile()
								FileSystem.FileOpen(num2, fileName, OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite, -1)
								FileSystem.PrintLine(num2, New Object() { num })
								Dim mdsDeviationProfile As DataSet = RSWIN_DESC.mdsDeviationProfile
								FileSystem.PrintLine(num2, New Object() { mdsDeviationProfile.Tables(0).Rows.Count })
								Try
									For Each obj As Object In mdsDeviationProfile.Tables(0).Rows
										Dim dataRow As DataRow = CType(obj, DataRow)
										Dim num3 As Single
										If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow(1))) Then
											num3 = Conversions.ToSingle(dataRow(1))
										Else
											num3 = 0F
										End If
										Dim flag5 As Boolean
										If flag5 Then
											CtrlUI.ConvertValue(num3, "f", True)
											num3 = CSng(Math.Round(CDbl(num3), 2))
										End If
										FileSystem.PrintLine(num2, New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Conversions.ToString(num3) + ",", dataRow(2)), ","), dataRow(3)) })
									Next
								Finally
									Dim enumerator As IEnumerator
									If TypeOf enumerator Is IDisposable Then
										TryCast(enumerator, IDisposable).Dispose()
									End If
								End Try
								flag = True
							End If
						End If
					End If
				End If
				LOADRST.DeleteTempDeviationFile()
				FileSystem.FileClose(New Integer() { num2 })
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function StoreTempDeviationProfile(ByRef mdsDeviationProfile As DataSet, bConvert As Boolean) As Boolean
			Dim dataSet As DataSet = New DataSet()
			Dim result As Boolean
			Try
				If mdsDeviationProfile Is Nothing Then
					result = False
				Else
					Dim flag As Boolean = False
					Dim str As String = "temp.deviationprofile"
					dataSet = mdsDeviationProfile.Copy()
					Dim str2 As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\" + VERSION1.ProgramName()
					Dim fileName As String = str2 + "\" + str
					Dim num As Integer = 1
					Dim num2 As Integer = FileSystem.FreeFile()
					FileSystem.FileOpen(num2, fileName, OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
					FileSystem.PrintLine(num2, New Object() { num })
					Dim dataSet2 As DataSet = dataSet
					FileSystem.PrintLine(num2, New Object() { dataSet2.Tables(0).Rows.Count })
					Try
						For Each obj As Object In dataSet2.Tables(0).Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							Dim num3 As Single
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow(1))) Then
								num3 = Conversions.ToSingle(dataRow(1))
							Else
								num3 = 0F
							End If
							If bConvert Then
								CtrlUI.ConvertValue(num3, "f", True)
								num3 = CSng(Math.Round(CDbl(num3), 2))
							End If
							FileSystem.PrintLine(num2, New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Conversions.ToString(num3) + ",", dataRow(2)), ","), dataRow(3)) })
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					FileSystem.PrintLine(num2, New Object() { RSWIN_DESC.rst.WellName })
					flag = True
					FileSystem.FileClose(New Integer() { num2 })
					result = flag
				End If
			Catch ex As Exception
				Dim num2 As Integer
				FileSystem.FileClose(New Integer() { num2 })
				Dim flag As Boolean
				result = flag
			End Try
			Return result
		End Function

		Private Function StoreInputData(hfOutput As Short) As Boolean
			Dim text As String = New String(" "c, 40)
			Dim text2 As String = New String(" "c, 20)
			Dim value As String = New String(" "c, 10)
			Dim result As Boolean
			Try
				result = False
				If RSWIN_DESC.rst.RodStringType = 3S And RSWIN_DESC.rst.RSGrade = 4096S Then
					Dim rodSection As RSWIN_DESC.RodSection
					rodSection.Grade = RSWIN_DESC.rst.RSGrade
					If RSWIN_DESC.rst.RSRodType Is Nothing Then
						RSWIN_DESC.rst.RSRodType = ""
					End If
					rodSection.RodType = RSWIN_DESC.rst.RSRodType.PadRight(20, " "c)
					RODUTIL.LookupTensileStrength(rodSection)
					RSWIN_DESC.rst.RSTensileStrength = rodSection.TensileStrength
				End If
				Dim value2 As Short = 1S
				Dim value3 As Short = 0S
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.ThisVersion = 29S
				FileSystem.FilePut(CInt(hfOutput), RSWIN_DESC.RSMagic, -1L, False)
				FileSystem.FilePut(CInt(hfOutput), rst.ThisVersion, -1L)
				FileSystem.FilePut(CInt(hfOutput), value3, -1L)
				FileSystem.FilePut(CInt(hfOutput), value2, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.ACompanyName.PadRight(40, " "c), -1L, False)
				FileSystem.FilePut(CInt(hfOutput), rst.WellName.PadRight(40, " "c), -1L, False)
				FileSystem.FilePut(CInt(hfOutput), rst.UserName.PadRight(40, " "c), -1L, False)
				FileSystem.FilePut(CInt(hfOutput), rst.UserDate.PadRight(40, " "c), -1L, False)
				FileSystem.FilePut(CInt(hfOutput), rst.PumpCondition, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.PumpEfficiency, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.PumpFillage, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.PumpDepth, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.FluidLevel, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.SPMEntered, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.SPM, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.TargetBFPD, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.PumpType, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.PlungerSize, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.CalcPlungerSize, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.FluidSPGR, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.CalcFriction, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.IncludeFluidInertia, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.CompressibilityIndex, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.TubingOD, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.TubingID, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.TubingAnchored, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.TubingAnchorDepth, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.TubingPressure, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.CasingPressure, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.RodStringType, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.APIRod, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.APIGrade, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.NumRods, -1L)
				Dim num As Short = 1S
				Dim numRods As Short = rst.NumRods
				For num2 As Short = num To numRods
					FileSystem.FilePut(CInt(hfOutput), rst.Sections(CInt(num2)).Grade, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.Sections(CInt(num2)).Diameter, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.Sections(CInt(num2)).length, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.Sections(CInt(num2)).SuckerRodLength, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.Sections(CInt(num2)).RodDensity, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.Sections(CInt(num2)).RodWeight, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.Sections(CInt(num2)).Elasticity, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.Sections(CInt(num2)).Area, -1L)
					RODUTIL.LookupTensileStrength(rst.Sections(CInt(num2)))
					If rst.Sections(CInt(num2)).RodType Is Nothing Then
						rst.Sections(CInt(num2)).RodType = ""
					End If
					FileSystem.FilePut(CInt(hfOutput), rst.Sections(CInt(num2)).RodType.PadRight(20, " "c), -1L, False)
					FileSystem.FilePut(CInt(hfOutput), rst.Sections(CInt(num2)).TensileStrength, -1L)
					If CUSTOMRG.IsOtherSteel(CInt(rst.Sections(CInt(num2)).Grade)) Then
						' The following expression was wrapped in a checked-expression
						Dim value4 As Short = CShort(RODUTIL.LookupStressMethod(rst.Sections(CInt(num2))))
						FileSystem.FilePut(CInt(hfOutput), value4, -1L)
					End If
				Next
				FileSystem.FilePut(CInt(hfOutput), rst.RSGrade, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.RSSuckerRodLength, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.RSMaxSize, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.RSMinSize, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.ServiceFactor, -1L)
				If rst.UnitID IsNot Nothing Then
					FileSystem.FilePut(CInt(hfOutput), rst.UnitID.PadRight(10, " "c), -1L, False)
				Else
					FileSystem.FilePut(CInt(hfOutput), value, -1L, False)
				End If
				FileSystem.FilePut(CInt(hfOutput), rst.IDEntered, -1L)
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				pu = RSWIN_DESC.rst.PU
				FileSystem.FilePut(CInt(hfOutput), pu.Manuf, -1L, False)
				FileSystem.FilePut(CInt(hfOutput), pu.UnitName, -1L, False)
				FileSystem.FilePut(CInt(hfOutput), pu.APIDesignation, -1L, False)
				FileSystem.FilePut(CInt(hfOutput), pu.UnitType, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.RequiredRotation, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.CrankRotation, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.CrankHole, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.CrankHoles, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.CrankRadii(0), -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.CrankRadii(1), -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.CrankRadii(2), -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.CrankRadii(3), -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.CrankRadii(4), -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.Strokes(0), -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.Strokes(1), -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.Strokes(2), -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.Strokes(3), -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.Strokes(4), -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.KinematicStroke, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.R, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.A, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.C, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.I, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.K, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.P, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.M, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.S, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.V0, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.DrumDiamRatio, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.SprocketRadius, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.SprocketDistance, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.Unbalance, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.CrankOffset, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.StructRating, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.GearboxRating, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.MaxStroke, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.ArtInertia, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.ElectricityCost, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.PowerMeterType, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.get_M(2), -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.MotorSPV, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.Iart, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.Irot, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.IrotEntered, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.FluidLevelEntered, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.PumpIntakePressure, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.Runtime, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.WaterCut, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.OilAPI, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.RSIncludeSB, -1L)
				Dim sinkerBar As RSWIN_DESC.RodSection
				sinkerBar.Initialize()
				sinkerBar = rst.SinkerBar
				FileSystem.FilePut(CInt(hfOutput), sinkerBar.Grade, -1L)
				FileSystem.FilePut(CInt(hfOutput), sinkerBar.Diameter, -1L)
				FileSystem.FilePut(CInt(hfOutput), sinkerBar.length, -1L)
				FileSystem.FilePut(CInt(hfOutput), sinkerBar.SuckerRodLength, -1L)
				FileSystem.FilePut(CInt(hfOutput), sinkerBar.RodDensity, -1L)
				FileSystem.FilePut(CInt(hfOutput), sinkerBar.RodWeight, -1L)
				FileSystem.FilePut(CInt(hfOutput), sinkerBar.Elasticity, -1L)
				FileSystem.FilePut(CInt(hfOutput), sinkerBar.Area, -1L)
				RODUTIL.LookupTensileStrength(sinkerBar)
				Dim sinkerBar2 As RSWIN_DESC.RodSection = rst.SinkerBar
				If sinkerBar2.RodType IsNot Nothing Then
					FileSystem.FilePut(CInt(hfOutput), sinkerBar.RodType.PadRight(20, " "c), -1L, False)
				Else
					sinkerBar.RodType = ""
					FileSystem.FilePut(CInt(hfOutput), sinkerBar.RodType.PadRight(20, " "c), -1L, False)
				End If
				FileSystem.FilePut(CInt(hfOutput), sinkerBar.TensileStrength, -1L)
				If sinkerBar.Grade = 4096S Then
					Dim cRODSTAR As cRODSTAR = rst
					sinkerBar2 = cRODSTAR.SinkerBar
					Dim num3 As Short = CShort(RODUTIL.LookupStressMethod(sinkerBar2))
					cRODSTAR.SinkerBar = sinkerBar2
					Dim value4 As Short = num3
					FileSystem.FilePut(CInt(hfOutput), value4, -1L)
				End If
				FileSystem.FilePut(CInt(hfOutput), rst.UpstrokeFriction, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.DownstrokeFriction, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.StuffingBoxFriction, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.PumpLoadAdj, -1L)
				FILEIO.PutString(hfOutput, rst.APIRodType)
				FileSystem.FilePut(CInt(hfOutput), rst.APITensileStrength, -1L)
				FILEIO.PutString(hfOutput, rst.RSRodType)
				FileSystem.FilePut(CInt(hfOutput), rst.RSTensileStrength, -1L)
				FileSystem.FilePut(CInt(hfOutput), pu.OtherInfo, -1L, False)
				FILEIO.PutString(hfOutput, rst.CBDataFile)
				FileSystem.FilePut(CInt(hfOutput), rst.CalcMotorSPV, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.CalcMotorSize, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.WaterSPGR, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.gbRoddiagFile, -1L)
				If rst.gbRoddiagFile Then
					FileSystem.FilePut(CInt(hfOutput), rst.RDNtsteps, -1L)
					Dim num4 As Short = 0S
					Dim num5 As Short = rst.RDNtsteps - 1S
					For num2 As Short = num4 To num5
						FileSystem.FilePut(CInt(hfOutput), rst.RDSurfPos(CInt(num2)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.RDSurfLoad(CInt(num2)), -1L)
					Next
				End If
				FileSystem.FilePut(CInt(hfOutput), rst.RSExtraCost, -1L)
				FILEIO.PutString(hfOutput, rst.RSExtraCostLabel)
				FileSystem.FilePut(CInt(hfOutput), rst.gbSteelRodString, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.RSFGGrade, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.RSFGIncludeSteel, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.gbUseIPR, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.gbCalcTargetBFPD, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.gbCalcPumpCondition, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.giIPRMethod, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.MidPerfDepth, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.StaticBHPressure, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.BubblePoint, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.gnTestPoints, -1L)
				Dim num6 As Short = 1S
				Dim gnTestPoints As Short = rst.gnTestPoints
				For num2 As Short = num6 To gnTestPoints
					FileSystem.FilePut(CInt(hfOutput), rst.TestPoints(CInt(num2)).bPIEntered, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.TestPoints(CInt(num2)).Pintake, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.TestPoints(CInt(num2)).Pwf, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.TestPoints(CInt(num2)).Production, -1L)
				Next
				FileSystem.FilePut(CInt(hfOutput), rst.gbProducingBelowBPP, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.giRodDesignStyle, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.gbCalcFetkovichN, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.FetkovichN, -1L)
				FILEIO.PutString(hfOutput, rst.FileComment)
				FileSystem.FilePut(CInt(hfOutput), rst.gbCalcPumpIntakePressure, -1L)
				Motor.WriteMotorData(hfOutput)
				FileSystem.FilePut(CInt(hfOutput), rst.PumpFriction, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.gbIncludeBuoyancy, -1L)
				If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
					FileSystem.FilePut(CInt(hfOutput), rst.bUnknownUnbalance, -1L)
				End If
				result = True
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function StoreOutputData(hfOutput As Short, bStoreOutput As Boolean) As Boolean
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Dim result As Boolean = False
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If bStoreOutput Then
					FileSystem.FilePut(CInt(hfOutput), rst.BPDsurface, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.FluidLoad, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.FoSkr, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.GrossPumpStroke, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.MaxRodStressL, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.MinMotorHP, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.Mprload, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.NoverNoP, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.Ntsteps, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.Pfill, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.PlungerLength, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.Pprload, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.Prhp, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.ProductionLoss, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.PumpLength, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.PumpSpacing, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.StartDownstroke, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.StartUpstroke, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.StructL, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.SystemEff, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.TotalTheta, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.TubStretch, -1L)
					FileSystem.FilePut(CInt(hfOutput), rst.WrodsInFluid, -1L)
					Dim num As Short = 0S
					Do
						FileSystem.FilePut(CInt(hfOutput), rst.CBE90(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.Clf(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.DollarsPerBblFluid(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.DollarsPerBblOil(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.get_ElectricBillperMonth(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.GearboxLoading(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.HpNemaD(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.HpUhs(CInt(num)), -1L)
						If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
							FileSystem.FilePut(CInt(hfOutput), rst.get_RequiredUnbalance(CInt(num)), -1L)
						Else
							FileSystem.FilePut(CInt(hfOutput), rst.get_M(CInt(num)), -1L)
						End If
						FileSystem.FilePut(CInt(hfOutput), rst.MotorKWH(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.PeakTorque(CInt(num)), -1L)
						Dim num2 As Short = 0S
						Dim num3 As Short = rst.Ntsteps - 1S
						For num4 As Short = num2 To num3
							FileSystem.FilePut(CInt(hfOutput), rst.Tnet(CInt(num), CInt(num4)), -1L)
						Next
						num += 1S
					Loop While num <= 2S
					Dim num5 As Short = 1S
					Dim numRods As Short = rst.NumRods
					num = num5
					While num <= numRods
						FileSystem.FilePut(CInt(hfOutput), rst.StressL(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.maxStressTop(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.minStressTop(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.minStressBot(CInt(num)), -1L)
						num += 1S
					End While
					Dim num6 As Short = 0S
					Dim num7 As Short = rst.Ntsteps - 1S
					num = num6
					While num <= num7
						FileSystem.FilePut(CInt(hfOutput), rst.SurfPos(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.SurfLoad(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.PumpPos(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.PumpLoad(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.PermLoad(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.Thetac(CInt(num)), -1L)
						FileSystem.FilePut(CInt(hfOutput), rst.Tf(CInt(num)), -1L)
						num += 1S
					End While
				End If
				FileSystem.FilePut(CInt(hfOutput), bStoreOutput, -1L)
				FileSystem.FilePut(CInt(hfOutput), rst.NtstepsUpstroke, -1L)
				If RSWIN_DESC.mdsDeviationProfile Is Nothing Then
					FileSystem.FilePut(CInt(hfOutput), 0, -1L)
				ElseIf impredObj IsNot Nothing Then
					FileSystem.FilePut(CInt(hfOutput), impredObj.num_rod_elements, -1L)
					Dim num8 As Short = 1S
					Dim num9 As Short = CShort(impredObj.num_rod_elements)
					For num As Short = num8 To num9
						Dim rod_element_data_type As TEImpred.rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.m_d, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.dog, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.rad, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.ea, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.friction_coef, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.mass, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.buoy_weight, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.old_force, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.old_velocity, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.friction_force, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.gravity_force, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.pos.x, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.pos.y, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.pos.z, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.tan.x, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.tan.y, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.tan.z, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.nor.x, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.nor.y, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.nor.z, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.sfg.x, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.sfg.y, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.sfg.z, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.max_sf_total, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.inc, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.azi, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.max_force, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.min_force, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.damp_coef_dn, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.damp_coef_up, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.hydrostat_psia_tbg, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.hydrostat_psia_csg, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.dynamic_psia_tbg, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.dynamic_psia_csg, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.buckle_tendency, -1L)
						rod_element_data_type = impredObj.get_r_e(CInt(num))
						FileSystem.FilePut(CInt(hfOutput), rod_element_data_type.rod_area, -1L)
					Next
				End If
				result = True
			Catch ex As Exception
				bStoreOutput = True
				result = False
			End Try
			Return result
		End Function
	End Module
End Namespace
