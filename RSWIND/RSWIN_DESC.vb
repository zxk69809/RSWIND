Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Reflection
Imports System.Resources
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports ThetaStdInfo

Namespace RSWINV3
	Public NotInheritable Module RSWIN_DESC
		Public Property bUseCurrentUser As Boolean
			Get
				Return RSWIN_DESC.m_bUseCurrentUser
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bUseCurrentUser = value
			End Set
		End Property

		Public Property bRegistryMoveChecked As Boolean
			Get
				Return RSWIN_DESC.m_bRegistryMoveChecked
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bRegistryMoveChecked = value
			End Set
		End Property

		Public Property bUseLatestXRODCode As Boolean
			Get
				Return RSWIN_DESC.m_bUseLatestXRODCode
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bUseLatestXRODCode = value
			End Set
		End Property

		Public Property bRunStarRunning As Boolean
			Get
				Return RSWIN_DESC.m_bRunStarRunning
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bRunStarRunning = value
			End Set
		End Property

		Public Property bAIScoreImproved As Boolean
			Get
				Return RSWIN_DESC.m_bAIScoreImproved
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bAIScoreImproved = value
			End Set
		End Property

		Public Property bImprovingScore As Boolean
			Get
				Return RSWIN_DESC.m_bImprovingScore
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bImprovingScore = value
			End Set
		End Property

		Public Property bAbortRun As Boolean
			Get
				Return RSWIN_DESC.m_bAbortRun
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bAbortRun = value
			End Set
		End Property

		Public Property bGuruFileDataLoaded As Boolean
			Get
				Return RSWIN_DESC.m_bGuruFileDataLoaded
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bGuruFileDataLoaded = value
			End Set
		End Property

		Public Property SETUP_bGuru As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_bGuru
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_bGuru = value
				If RSWIN_DESC.bExpert Then
					If value Then
						RSWIN_DESC.sFILETYPE = "xrvx"
						RSWIN_DESC.sDOTFILETYPE = ".xrvx"
						RSWIN_DESC.sOTHERFILETYPE = "rsvx"
						RSWIN_DESC.sAllTypes = "XROD-V files (*.xrvx)|*.xrvx|RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR deviated file type (*.rsdx)|*.rsdx|RODSTAR old file type (*.rst)|*.rst|ALL RODSTAR Files (*.xrvx,*.rsvx,*.rsdx, *.rst)|*.xrvx;*.rsvx;*.rsdx;*.rst|XDIAG files (*.xdg,*.xddx)|*.xdg;*.xddx|RODDIAG files (*.rdg)|*.rdg|All Files|*.*"
						RSWIN_DESC.sRODSTARFiles = "XROD-V files (*.xrvx)|*.xrvx|RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR old file type (*.rst)|*.rst|XDIAG files (*.XDG,*.XDDX)|*.XDG;*.XDDX|Adobe Acrobat Document (*.PDF)|*.PDF"
						RSWIN_DESC.sImportRSTXFiles = "XROD-V files (*.xrvx)|*.xrvx|RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR deviated file type (*.rsdx)|*.rsdx"
						RSWIN_DESC.sSelectOutputFileType = "XROD-V files (*.xrvx)|*.xrvx"
						RSWIN_DESC.RECENTFILES = "AI Recent Files"
					Else
						RSWIN_DESC.sFILETYPE = "rsvx"
						RSWIN_DESC.sDOTFILETYPE = ".rsvx"
						RSWIN_DESC.sOTHERFILETYPE = "rsdx"
						RSWIN_DESC.sAllTypes = "ALL RODSTAR files (*.rst,*.rsvx,*.rsdx,*.xrvx)|*.rst;*.rsvx;*.rsdx;*.xrvx|RODSTAR old file type (*.rst)|*.rst|RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR deviated file type (*.rsdx)|*.rsdx|XROD-V files (*.xrvx)|*.xrvx|XDIAG files (*.xdg,*.xddx)|*.xdg;*.xddx|RODDIAG files (*.rdg)|*.rdg|All Files|*.*"
						RSWIN_DESC.sRODSTARFiles = "RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR old file type (*.rst)|*.rst|XDIAG files (*.XDG,*.XDDX)|*.XDG;*.XDDX|Adobe Acrobat Document (*.PDF)|*.PDF"
						RSWIN_DESC.sImportRSTXFiles = "RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR deviated file type (*.rsdx)|*.rsdx"
						RSWIN_DESC.sSelectOutputFileType = "RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR old file type (*.rst)|*.rst"
						RSWIN_DESC.RECENTFILES = "XRODV Recent Files"
					End If
				End If
			End Set
		End Property

		Public Property SETUP_bGuruUseTemplateDatabase As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_bGuruUseTemplateDatabase
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_bGuruUseTemplateDatabase = value
			End Set
		End Property

		Public Property bRunGuru As Boolean
			Get
				Return RSWIN_DESC.m_bRunGuru
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bRunGuru = value
			End Set
		End Property

		Public Property bOneGuruFile As Boolean
			Get
				Return RSWIN_DESC.m_bOneGuruFile
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bOneGuruFile = value
			End Set
		End Property

		Public Property sAIFilename As String
			Get
				Return RSWIN_DESC.m_sAIFilename
			End Get
			Set(value As String)
				RSWIN_DESC.m_sAIFilename = value
			End Set
		End Property

		Public Property bSuppressWarningMessages As Boolean
			Get
				Return RSWIN_DESC.m_bSuppressWarningMessages
			End Get
			Set(value As Boolean)
				If RSWIN_DESC.bExpert And RSWIN_DESC.bRunAllTemplates Then
					RSWIN_DESC.m_bSuppressWarningMessages = True
				ElseIf RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					RSWIN_DESC.m_bSuppressWarningMessages = value
				Else
					RSWIN_DESC.m_bSuppressWarningMessages = False
				End If
			End Set
		End Property

		Public Property bSuppressWarningMessages_Override As Boolean
			Get
				Return RSWIN_DESC.m_bSuppressWarningMessages_Override
			End Get
			Set(value As Boolean)
				If RSWIN_DESC.bExpert And RSWIN_DESC.bRunAllTemplates Then
					RSWIN_DESC.m_bSuppressWarningMessages = True
				Else
					RSWIN_DESC.m_bSuppressWarningMessages = value
					RSWIN_DESC.m_bSuppressWarningMessages_Override = value
				End If
			End Set
		End Property

		Public Property iErrorOccurred As Integer
			Get
				Return RSWIN_DESC.m_iErrorOccurred
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_iErrorOccurred = value
			End Set
		End Property

		Public Property sGuruFilenameKey As String
			Get
				Return RSWIN_DESC.m_sGuruFilenameKey
			End Get
			Set(value As String)
				RSWIN_DESC.m_sGuruFilenameKey = value
			End Set
		End Property

		Public Property sCurrentFormName As String
			Get
				Return RSWIN_DESC.m_sCurrentFormName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sCurrentFormName = value
			End Set
		End Property

		Public Property bRunIconEnabled As Boolean
			Get
				Return RSWIN_DESC.m_bRunIconEnabled
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bRunIconEnabled = value
			End Set
		End Property

		Public Property EXCELBATCHFILENAME As String
			Get
				Return RSWIN_DESC.m_EXCELBATCHFILENAME
			End Get
			Set(value As String)
				RSWIN_DESC.m_EXCELBATCHFILENAME = value
			End Set
		End Property

		Public Property SECT_PROGWIN32 As String
			Get
				Return RSWIN_DESC.m_SECT_PROGWIN32
			End Get
			Set(value As String)
				RSWIN_DESC.m_SECT_PROGWIN32 = value
			End Set
		End Property

		Public Property bQuickFix As Boolean
			Get
				Return RSWIN_DESC.m_bQuickFix
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bQuickFix = False
			End Set
		End Property

		Public Property bProcessFinished As Boolean
			Get
				Return RSWIN_DESC.m_bProcessFinished
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bProcessFinished = value
			End Set
		End Property

		Public Property sProgramName As String
			Get
				Return RSWIN_DESC.m_sProgramName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sProgramName = value
			End Set
		End Property

		Public Property sProgramLongName As String
			Get
				Return RSWIN_DESC.m_sProgramLongName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sProgramLongName = value
			End Set
		End Property

		Public Property sProgramNameV As String
			Get
				Return RSWIN_DESC.m_sProgramNameV
			End Get
			Set(value As String)
				RSWIN_DESC.m_sProgramNameV = value
			End Set
		End Property

		Public Property sProgramLongNameV As String
			Get
				Return RSWIN_DESC.m_sProgramLongNameV
			End Get
			Set(value As String)
				RSWIN_DESC.m_sProgramLongNameV = value
			End Set
		End Property

		Public Property sProgramNameD As String
			Get
				Return RSWIN_DESC.m_sProgramNameD
			End Get
			Set(value As String)
				RSWIN_DESC.m_sProgramNameD = value
			End Set
		End Property

		Public Property sProgramLongNameD As String
			Get
				Return RSWIN_DESC.m_sProgramLongNameD
			End Get
			Set(value As String)
				RSWIN_DESC.m_sProgramLongNameD = value
			End Set
		End Property

		Public Property bRodStarD As Boolean
			Get
				Return RSWIN_DESC.m_bRodStarD
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bRodStarD = value
			End Set
		End Property

		Public Property rst_save As cRODSTAR
			Get
				Return RSWIN_DESC.m_rst_save
			End Get
			Set(value As cRODSTAR)
				RSWIN_DESC.m_rst_save = value
			End Set
		End Property

		Public Property MOLDED As Short
			Get
				Return RSWIN_DESC.m_MOLDED
			End Get
			Set(value As Short)
				RSWIN_DESC.m_MOLDED = value
			End Set
		End Property

		Public Property NorrisSidewinderGuide As Short
			Get
				Return RSWIN_DESC.m_NorrisSidewinderGuide
			End Get
			Set(value As Short)
				RSWIN_DESC.m_NorrisSidewinderGuide = value
			End Set
		End Property

		Public Property SETUP_GuideToUse As Integer
			Get
				Return RSWIN_DESC.m_SETUP_GuideToUse
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_SETUP_GuideToUse = value
			End Set
		End Property

		Public Property SETUP_ParaffinRodGuide As Integer
			Get
				Return RSWIN_DESC.m_SETUP_ParaffinRodGuide
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_SETUP_ParaffinRodGuide = value
			End Set
		End Property

		Public Property SETUP_BatchPrintouts As Integer
			Get
				Return RSWIN_DESC.m_SETUP_BatchPrintouts
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_SETUP_BatchPrintouts = value
			End Set
		End Property

		Public Property SETUP_BatchViewWorksheet As Integer
			Get
				Return RSWIN_DESC.m_SETUP_BatchViewWorksheet
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_SETUP_BatchViewWorksheet = value
			End Set
		End Property

		Public Property SETUP_MeasurementSystem As Integer
			Get
				Return RSWIN_DESC.m_SETUP_MeasurementSystem
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_SETUP_MeasurementSystem = value
			End Set
		End Property

		Public Property SETUP_Language As String
			Get
				Return RSWIN_DESC.m_SETUP_Language
			End Get
			Set(value As String)
				RSWIN_DESC.m_SETUP_Language = value
			End Set
		End Property

		Public Property SETUP_MaxFGLoading As Single
			Get
				Return RSWIN_DESC.m_SETUP_MaxFGLoading
			End Get
			Set(value As Single)
				RSWIN_DESC.m_SETUP_MaxFGLoading = value
			End Set
		End Property

		Public Property SETUP_MaxSteelLoading As Single
			Get
				Return RSWIN_DESC.m_SETUP_MaxSteelLoading
			End Get
			Set(value As Single)
				RSWIN_DESC.m_SETUP_MaxSteelLoading = value
			End Set
		End Property

		Public Property SETUP_ReportDevSurvey As Short
			Get
				Return RSWIN_DESC.m_SETUP_ReportDevSurvey
			End Get
			Set(value As Short)
				RSWIN_DESC.m_SETUP_ReportDevSurvey = value
			End Set
		End Property

		Public Property SETUP_OrderPage As Short
			Get
				Return RSWIN_DESC.m_SETUP_OrderPage
			End Get
			Set(value As Short)
				RSWIN_DESC.m_SETUP_OrderPage = value
			End Set
		End Property

		Public Property SETUP_SteelSuckerRodLength As Single
			Get
				Return RSWIN_DESC.m_SETUP_SteelSuckerRodLength
			End Get
			Set(value As Single)
				RSWIN_DESC.m_SETUP_SteelSuckerRodLength = value
			End Set
		End Property

		Public Property SETUP_UseImpred As Short
			Get
				Return RSWIN_DESC.m_SETUP_UseImpred
			End Get
			Set(value As Short)
				RSWIN_DESC.m_SETUP_UseImpred = value
			End Set
		End Property

		Public Property SETUP_DisplaySBinFeet As Short
			Get
				Return RSWIN_DESC.m_SETUP_DisplaySBinFeet
			End Get
			Set(value As Short)
				RSWIN_DESC.m_SETUP_DisplaySBinFeet = value
			End Set
		End Property

		Public Property SETUP_SummaryPage As Short
			Get
				Return RSWIN_DESC.m_SETUP_SummaryPage
			End Get
			Set(value As Short)
				RSWIN_DESC.m_SETUP_SummaryPage = value
			End Set
		End Property

		Public Property SETUP_ScoringPage As Short
			Get
				Return RSWIN_DESC.m_SETUP_ScoringPage
			End Get
			Set(value As Short)
				RSWIN_DESC.m_SETUP_ScoringPage = value
			End Set
		End Property

		Public Property SETUP_WK1Format As String
			Get
				Return RSWIN_DESC.m_SETUP_WK1Format
			End Get
			Set(value As String)
				RSWIN_DESC.m_SETUP_WK1Format = value
			End Set
		End Property

		Public Property SETUP_RSWINDIR As String
			Get
				Return RSWIN_DESC.m_SETUP_RSWINDIR
			End Get
			Set(value As String)
				RSWIN_DESC.m_SETUP_RSWINDIR = value
			End Set
		End Property

		Public Property SETUP_GURUTEMPDIR As String
			Get
				Return RSWIN_DESC.m_SETUP_GURUTEMPDIR
			End Get
			Set(value As String)
				RSWIN_DESC.m_SETUP_GURUTEMPDIR = value
			End Set
		End Property

		Public Property SETUP_GURUSAVEDIR As String
			Get
				Return RSWIN_DESC.m_SETUP_GURUSAVEDIR
			End Get
			Set(value As String)
				RSWIN_DESC.m_SETUP_GURUSAVEDIR = value
			End Set
		End Property

		Public Property SETUP_DISPLAYAZDIRTOOLBAR As Short
			Get
				Return RSWIN_DESC.m_SETUP_DISPLAYAZDIRTOOLBAR
			End Get
			Set(value As Short)
				RSWIN_DESC.m_SETUP_DISPLAYAZDIRTOOLBAR = value
			End Set
		End Property

		Public Property SETUP_OPTIMIZESURVEY As Short
			Get
				Return RSWIN_DESC.m_SETUP_OPTIMIZESURVEY
			End Get
			Set(value As Short)
				RSWIN_DESC.m_SETUP_OPTIMIZESURVEY = 0S
			End Set
		End Property

		Public Property SETUP_RunForSpeed As Short
			Get
				Return RSWIN_DESC.m_SETUP_RunForSpeed
			End Get
			Set(value As Short)
				RSWIN_DESC.m_SETUP_RunForSpeed = 0S
			End Set
		End Property

		Public Property SETUP_ALLOWSLIDEFRIC As Short
			Get
				Return RSWIN_DESC.m_SETUP_ALLOWSLIDEFRIC
			End Get
			Set(value As Short)
				RSWIN_DESC.m_SETUP_ALLOWSLIDEFRIC = value
			End Set
		End Property

		Public Property SETUP_MaxSideLoadLimit As Single
			Get
				Return RSWIN_DESC.m_SETUP_MaxSideLoadLimit
			End Get
			Set(value As Single)
				RSWIN_DESC.m_SETUP_MaxSideLoadLimit = value
			End Set
		End Property

		Public Property SETUP_NorrisSidewinderGuide_FRICCOEFF As Single
			Get
				Return RSWIN_DESC.m_SETUP_NorrisSidewinderGuide_FRICCOEFF
			End Get
			Set(value As Single)
				RSWIN_DESC.m_SETUP_NorrisSidewinderGuide_FRICCOEFF = value
			End Set
		End Property

		Public Property SETUP_NumCycles As Integer
			Get
				Return RSWIN_DESC.m_SETUP_NumCycles
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_SETUP_NumCycles = 4
			End Set
		End Property

		Public Property sNull As String
			Get
				Return RSWIN_DESC.m_sNull
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", False) <> 0 Then
					RSWIN_DESC.m_sNull = ""
				End If
			End Set
		End Property

		Public Property iAddedTemplates As Integer
			Get
				Return RSWIN_DESC.m_iAddedTemplates
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_iAddedTemplates = value
			End Set
		End Property

		Public Property iGuruFileCount As Integer
			Get
				Return RSWIN_DESC.m_iGuruFileCount
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_iGuruFileCount = value
			End Set
		End Property

		Public Property GuruDataBaseFileName As String
			Get
				Return RSWIN_DESC.m_GuruDataBaseFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_GuruDataBaseFileName = value
			End Set
		End Property

		Public Property BlankGuruDataBaseFileName As String
			Get
				Return RSWIN_DESC.m_BlankGuruDataBaseFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_BlankGuruDataBaseFileName = value
			End Set
		End Property

		Public Property BlankGuruDataBaseFileNameEn As String
			Get
				Return RSWIN_DESC.m_BlankGuruDataBaseFileNameEn
			End Get
			Set(value As String)
				RSWIN_DESC.m_BlankGuruDataBaseFileNameEn = value
			End Set
		End Property

		Public Property SmallestUnitID As String
			Get
				Return RSWIN_DESC.m_SmallestUnitID
			End Get
			Set(value As String)
				RSWIN_DESC.m_SmallestUnitID = value
			End Set
		End Property

		Public Property bSmallestUnitGearbox As Boolean
			Get
				Return RSWIN_DESC.m_bSmallestUnitGearbox
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bSmallestUnitGearbox = value
			End Set
		End Property

		Public Property bSmallestUnitStructL As Boolean
			Get
				Return RSWIN_DESC.m_bSmallestUnitStructL
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bSmallestUnitStructL = value
			End Set
		End Property

		Public Property bUseLandscape As Boolean
			Get
				Return RSWIN_DESC.m_bUseLandscape
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bUseLandscape = value
			End Set
		End Property

		Public Property SETUP_bSinkerBar As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_bSinkerBar
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_bSinkerBar = value
			End Set
		End Property

		Public Property SETUP_IncludeMotorSPV As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_IncludeMotorSPV
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_IncludeMotorSPV = value
			End Set
		End Property

		Public Property SETUP_PowerMeterType As Short
			Get
				Return RSWIN_DESC.m_SETUP_PowerMeterType
			End Get
			Set(value As Short)
				RSWIN_DESC.m_SETUP_PowerMeterType = value
			End Set
		End Property

		Public Property SETUP_bAdminDebug As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_bAdminDebug
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_bAdminDebug = value
			End Set
		End Property

		Public Property SETUP_bUseSteelRodsOnly As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_bUseSteelRodsOnly
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_bUseSteelRodsOnly = value
			End Set
		End Property

		Public Property SETUP_bUseFGlassWithSteelOnBottom As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_bUseFGlassWithSteelOnBottom
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_bUseFGlassWithSteelOnBottom = value
			End Set
		End Property

		Public Property SETUP_ElectricityCostPreference As Single
			Get
				Return RSWIN_DESC.m_SETUP_ElectricityCostPreference
			End Get
			Set(value As Single)
				RSWIN_DESC.m_SETUP_ElectricityCostPreference = value
			End Set
		End Property

		Public Property SETUP_bRodstarPumpType As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_bRodstarPumpType
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_bRodstarPumpType = value
			End Set
		End Property

		Public Property SETUP_UseXRODVTubingSizes As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_UseXRODVTubingSizes
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_UseXRODVTubingSizes = value
			End Set
		End Property

		Public Property SETUP_FixTubingSize As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_FixTubingSize
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_FixTubingSize = value
			End Set
		End Property

		Public Property SETUP_bRodstarTubingAnchored As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_bRodstarTubingAnchored
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_bRodstarTubingAnchored = value
			End Set
		End Property

		Public Property SETUP_bTubingAnchored As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_bTubingAnchored
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_bTubingAnchored = value
			End Set
		End Property

		Public Property SETUP_bUseAvgRodTBGFricCoeff As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_bUseAvgRodTBGFricCoeff
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_bUseAvgRodTBGFricCoeff = value
			End Set
		End Property

		Public Property SETUP_TimesAvgRodTBGFricCoeff As Single
			Get
				Return RSWIN_DESC.m_SETUP_TimesAvgRodTBGFricCoeff
			End Get
			Set(value As Single)
				RSWIN_DESC.m_SETUP_TimesAvgRodTBGFricCoeff = value
			End Set
		End Property

		Public Property SETUP_ServiceFactorPreference As Single
			Get
				Return RSWIN_DESC.m_SETUP_ServiceFactorPreference
			End Get
			Set(value As Single)
				RSWIN_DESC.m_SETUP_ServiceFactorPreference = value
			End Set
		End Property

		Public Property FGGradeRod As Short
			Get
				Return RSWIN_DESC.m_FGGradeRod
			End Get
			Set(value As Short)
				RSWIN_DESC.m_FGGradeRod = value
			End Set
		End Property

		Public Property HSGradeRod As Short
			Get
				Return RSWIN_DESC.m_HSGradeRod
			End Get
			Set(value As Short)
				RSWIN_DESC.m_HSGradeRod = value
			End Set
		End Property

		Public Property SBGradeRod As Short
			Get
				Return RSWIN_DESC.m_SBGradeRod
			End Get
			Set(value As Short)
				RSWIN_DESC.m_SBGradeRod = value
			End Set
		End Property

		Public Property HSRodType As String
			Get
				Return RSWIN_DESC.m_HSRodType
			End Get
			Set(value As String)
				RSWIN_DESC.m_HSRodType = value
			End Set
		End Property

		Public Property FGRodType As String
			Get
				Return RSWIN_DESC.m_FGRodType
			End Get
			Set(value As String)
				RSWIN_DESC.m_FGRodType = value
			End Set
		End Property

		Public Property SBRodType As String
			Get
				Return RSWIN_DESC.m_SBRodType
			End Get
			Set(value As String)
				RSWIN_DESC.m_SBRodType = value
			End Set
		End Property

		Public Property MaxTubingSizeOD As Single
			Get
				Return RSWIN_DESC.m_MaxTubingSizeOD
			End Get
			Set(value As Single)
				RSWIN_DESC.m_MaxTubingSizeOD = value
			End Set
		End Property

		Public Property MinTubingSizeOD As Single
			Get
				Return RSWIN_DESC.m_MinTubingSizeOD
			End Get
			Set(value As Single)
				RSWIN_DESC.m_MinTubingSizeOD = value
			End Set
		End Property

		Public Property MaxTubingSizeID As Single
			Get
				Return RSWIN_DESC.m_MaxTubingSizeID
			End Get
			Set(value As Single)
				RSWIN_DESC.m_MaxTubingSizeID = value
			End Set
		End Property

		Public Property MinTubingSizeID As Single
			Get
				Return RSWIN_DESC.m_MinTubingSizeID
			End Get
			Set(value As Single)
				RSWIN_DESC.m_MinTubingSizeID = value
			End Set
		End Property

		Public Property MaxCasingSize As Single
			Get
				Return RSWIN_DESC.m_MaxCasingSize
			End Get
			Set(value As Single)
				RSWIN_DESC.m_MaxCasingSize = value
			End Set
		End Property

		Public Property bUsePUManuf(index As Integer) As Boolean
			Get
				Return RSWIN_DESC.m_bUsePUManuf(index)
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bUsePUManuf(index) = value
			End Set
		End Property

		Public Property PUManuf(index As Integer) As String
			Get
				Return RSWIN_DESC.m_PUManuf(index)
			End Get
			Set(value As String)
				RSWIN_DESC.m_PUManuf(index) = value
			End Set
		End Property

		Public Property bXRODUseCustomizedLists As Boolean
			Get
				Return RSWIN_DESC.m_bXRODUseCustomizedLists
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bXRODUseCustomizedLists = value
			End Set
		End Property

		Public Property bXRODUseGeneralList As Boolean
			Get
				Return RSWIN_DESC.m_bXRODUseGeneralList
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bXRODUseGeneralList = value
			End Set
		End Property

		Public Property bXRODUseClosestUnit As Boolean
			Get
				Return RSWIN_DESC.m_bXRODUseClosestUnit
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bXRODUseClosestUnit = value
			End Set
		End Property

		Public Property bUsingGeneralList As Boolean
			Get
				Return RSWIN_DESC.m_bUsingGeneralList
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bUsingGeneralList = value
			End Set
		End Property

		Public Property bUsingClosestUnit As Boolean
			Get
				Return RSWIN_DESC.m_bUsingClosestUnit
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bUsingClosestUnit = value
			End Set
		End Property

		Public Property bUsingMatchedUnit As Boolean
			Get
				Return RSWIN_DESC.m_bUsingMatchedUnit
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bUsingMatchedUnit = value
			End Set
		End Property

		Public Property sRecommendedUnit As String
			Get
				Return RSWIN_DESC.m_sRecommendedUnit
			End Get
			Set(value As String)
				RSWIN_DESC.m_sRecommendedUnit = value
			End Set
		End Property

		Public Property bInsertPump As Boolean
			Get
				Return RSWIN_DESC.m_bInsertPump
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bInsertPump = value
			End Set
		End Property

		Public Property bTubingPump As Boolean
			Get
				Return RSWIN_DESC.m_bTubingPump
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bTubingPump = value
			End Set
		End Property

		Public Property bLargeBorePump As Boolean
			Get
				Return RSWIN_DESC.m_bLargeBorePump
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bLargeBorePump = value
			End Set
		End Property

		Public Property bDesignSinkerbar As Boolean
			Get
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					RSWIN_DESC.m_bDesignSinkerbar = True
				ElseIf Not RSWIN_DESC.bExpert Then
					RSWIN_DESC.m_bDesignSinkerbar = False
				End If
				Return RSWIN_DESC.m_bDesignSinkerbar
			End Get
			Set(value As Boolean)
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					RSWIN_DESC.m_bDesignSinkerbar = True
				ElseIf RSWIN_DESC.bExpert Then
					RSWIN_DESC.m_bDesignSinkerbar = value
				Else
					RSWIN_DESC.m_bDesignSinkerbar = False
				End If
			End Set
		End Property

		Public Property bUseNNSinkerbar As Object
			Get
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					RSWIN_DESC.m_bUseNNSinkerbar = True
				End If
				Return RSWIN_DESC.m_bUseNNSinkerbar
			End Get
			Set(value As Object)
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					RSWIN_DESC.m_bUseNNSinkerbar = True
				Else
					RSWIN_DESC.m_bUseNNSinkerbar = Conversions.ToBoolean(value)
				End If
			End Set
		End Property

		Public Property i2Score As Integer
			Get
				Return RSWIN_DESC.m_i2Score
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_i2Score = 1
			End Set
		End Property

		Public Property bShowScoringPage As Boolean
			Get
				Return RSWIN_DESC.m_bShowScoringPage
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bShowScoringPage = value
			End Set
		End Property

		Public Property bBalancedEVarsOverwritten As Boolean
			Get
				Return RSWIN_DESC.m_bBalancedEVarsOverwritten
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bBalancedEVarsOverwritten = value
			End Set
		End Property

		Public Property bMainClosed As Boolean
			Get
				Return RSWIN_DESC.m_bMainClosed
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bMainClosed = value
			End Set
		End Property

		Public Property SavedDownstrokeFriction As Single
			Get
				Return RSWIN_DESC.m_SavedDownstrokeFriction
			End Get
			Set(value As Single)
				RSWIN_DESC.m_SavedDownstrokeFriction = value
			End Set
		End Property

		Public Property SavedUpstrokeFriction As Single
			Get
				Return RSWIN_DESC.m_SavedUpstrokeFriction
			End Get
			Set(value As Single)
				RSWIN_DESC.m_SavedUpstrokeFriction = value
			End Set
		End Property

		Public Property bBeamBalanced As Boolean
			Get
				Return RSWIN_DESC.m_bBeamBalanced
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bBeamBalanced = value
			End Set
		End Property

		Public Property SETUP_UseAllDiameters As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_UseAllDiameters
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_UseAllDiameters = value
			End Set
		End Property

		Public Property Setup_RodGuideOverlap As Integer
			Get
				Return RSWIN_DESC.m_Setup_RodGuideOverlap
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_Setup_RodGuideOverlap = value
			End Set
		End Property

		Public Property Setup_NumRodsPerBundle As Integer
			Get
				Return RSWIN_DESC.m_Setup_NumRodsPerBundle
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_Setup_NumRodsPerBundle = value
			End Set
		End Property

		Public Property SETUP_UseJohnsFix As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_UseJohnsFix
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_UseJohnsFix = True
			End Set
		End Property

		Public Property SETUP_UseJeffsFix As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_UseJeffsFix
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_UseJeffsFix = True
			End Set
		End Property

		Public Property bSBDiameterChanged As Boolean
			Get
				Return RSWIN_DESC.m_bSBDiameterChanged
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bSBDiameterChanged = value
			End Set
		End Property

		Public Property bSteelAboveFGDiameterChanged As Boolean
			Get
				Return RSWIN_DESC.m_bSteelAboveFGDiameterChanged
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bSteelAboveFGDiameterChanged = value
			End Set
		End Property

		Public Property SETUP_UseBucklingTendencyStresses As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_UseBucklingTendencyStresses
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_UseBucklingTendencyStresses = True
			End Set
		End Property

		Public Property bRodsInTubingMsgShown As Boolean
			Get
				Return RSWIN_DESC.m_bRodsInTubingMsgShown
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bRodsInTubingMsgShown = value
			End Set
		End Property

		Public Property bDoExpertBuoyancyChange As Boolean
			Get
				Return RSWIN_DESC.m_bDoExpertBuoyancyChange
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bDoExpertBuoyancyChange = value
			End Set
		End Property

		Public Property bFGUnderTravel As Boolean
			Get
				Return RSWIN_DESC.m_bFGUnderTravel
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bFGUnderTravel = value
			End Set
		End Property

		Public Property bHaltBatchLoop As Boolean
			Get
				Return RSWIN_DESC.m_bHaltBatchLoop
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bHaltBatchLoop = value
			End Set
		End Property

		Public Property sTemplateTotalAIScore As String
			Get
				Return RSWIN_DESC.m_sTemplateTotalAIScore
			End Get
			Set(value As String)
				RSWIN_DESC.m_sTemplateTotalAIScore = value
			End Set
		End Property

		Public Property fTemplateTotalAIScore As Single
			Get
				Return RSWIN_DESC.m_fTemplateTotalAIScore
			End Get
			Set(value As Single)
				RSWIN_DESC.m_fTemplateTotalAIScore = value
			End Set
		End Property

		Public Property bRunAllTemplates As Boolean
			Get
				Return RSWIN_DESC.m_bRunAllTemplates
			End Get
			Set(value As Boolean)
				If RSWIN_DESC.bXRODAdmin Then
					RSWIN_DESC.m_bRunAllTemplates = value
				Else
					RSWIN_DESC.m_bRunAllTemplates = False
				End If
			End Set
		End Property

		Public Property bNewCaseAsked As Boolean
			Get
				Return RSWIN_DESC.m_bNewCaseAsked
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bNewCaseAsked = value
			End Set
		End Property

		Public Property bHasGuides As Boolean
			Get
				Return RSWIN_DESC.m_bHasGuides
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bHasGuides = value
			End Set
		End Property

		Public Property rod_numrods As Integer
			Get
				Return RSWIN_DESC.m_rod_numrods
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_rod_numrods = value
			End Set
		End Property

		Public Property SETUP_UseDefaultRodElementLimit As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_UseDefaultRodElementLimit
			End Get
			Set(value As Boolean)
				If RSWIN_DESC.bAllowRodLimitEntry Then
					RSWIN_DESC.m_SETUP_UseDefaultRodElementLimit = value
				Else
					RSWIN_DESC.m_SETUP_UseDefaultRodElementLimit = True
				End If
			End Set
		End Property

		Public Property SETUP_RodElementLimit As Integer
			Get
				Return RSWIN_DESC.m_SETUP_RodElementLimit
			End Get
			Set(value As Integer)
				If RSWIN_DESC.bAllowRodLimitEntry Then
					RSWIN_DESC.m_SETUP_RodElementLimit = value
				Else
					RSWIN_DESC.m_SETUP_RodElementLimit = 200
				End If
			End Set
		End Property

		Public Property SETUP_MDInt As Single
			Get
				Return RSWIN_DESC.m_SETUP_MDInt
			End Get
			Set(value As Single)
				RSWIN_DESC.m_SETUP_MDInt = value
			End Set
		End Property

		Public Property SETUP_DoglegLimit As Single
			Get
				Return RSWIN_DESC.m_SETUP_DoglegLimit
			End Get
			Set(value As Single)
				RSWIN_DESC.m_SETUP_DoglegLimit = value
			End Set
		End Property

		Public Property num_rod_elements As Integer
			Get
				Return RSWIN_DESC.m_num_rod_elements
			End Get
			Set(value As Integer)
				RSWIN_DESC.m_num_rod_elements = value
			End Set
		End Property

		Public Property sDevPlotFileName As String
			Get
				Return RSWIN_DESC.m_sDevPlotFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sDevPlotFileName = value
			End Set
		End Property

		Public Property sAxialPlotFileName As String
			Get
				Return RSWIN_DESC.m_sAxialPlotFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sAxialPlotFileName = value
			End Set
		End Property

		Public Property sBucklingTendencyFileName As String
			Get
				Return RSWIN_DESC.m_sBucklingTendencyFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sBucklingTendencyFileName = value
			End Set
		End Property

		Public Property sDoglegsFileName As String
			Get
				Return RSWIN_DESC.m_sDoglegsFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sDoglegsFileName = value
			End Set
		End Property

		Public Property sSideForcesFileName As String
			Get
				Return RSWIN_DESC.m_sSideForcesFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sSideForcesFileName = value
			End Set
		End Property

		Public Property sSurveyEWFileName As String
			Get
				Return RSWIN_DESC.m_sSurveyEWFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sSurveyEWFileName = value
			End Set
		End Property

		Public Property sSurveyNSFileName As String
			Get
				Return RSWIN_DESC.m_sSurveyNSFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sSurveyNSFileName = value
			End Set
		End Property

		Public Property sSurveyPlanFileName As String
			Get
				Return RSWIN_DESC.m_sSurveyPlanFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sSurveyPlanFileName = value
			End Set
		End Property

		Public Property sTempDynoPlotFileName As String
			Get
				Return RSWIN_DESC.m_sTempDynoPlotFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sTempDynoPlotFileName = value
			End Set
		End Property

		Public Property sTempTorquePlotFileName As String
			Get
				Return RSWIN_DESC.m_sTempTorquePlotFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sTempTorquePlotFileName = value
			End Set
		End Property

		Public Property sTempDynoPlotLFileName As String
			Get
				Return RSWIN_DESC.m_sTempDynoPlotLFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sTempDynoPlotLFileName = value
			End Set
		End Property

		Public Property sTempTorquePlotLFileName As String
			Get
				Return RSWIN_DESC.m_sTempTorquePlotLFileName
			End Get
			Set(value As String)
				RSWIN_DESC.m_sTempTorquePlotLFileName = value
			End Set
		End Property

		Public Property SETUP_RECOMMEND_GUIDES As Boolean
			Get
				Return RSWIN_DESC.bRodStarD AndAlso RSWIN_DESC.m_SETUP_RECOMMEND_GUIDES
			End Get
			Set(value As Boolean)
				If RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.m_SETUP_RECOMMEND_GUIDES = False
				End If
			End Set
		End Property

		Public Property bAllZeroNumGuides As Boolean
			Get
				Return RSWIN_DESC.m_bAllZeroNumGuides
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bAllZeroNumGuides = value
			End Set
		End Property

		Public Property SETUP_ExcelInstalled As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_ExcelInstalled
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_ExcelInstalled = value
			End Set
		End Property

		Public Property rst_NOFI As cRODSTAR
			Get
				Return RSWIN_DESC.m_rst_NOFI
			End Get
			Set(value As cRODSTAR)
				RSWIN_DESC.m_rst_NOFI = value
			End Set
		End Property

		Public Property Impred_NOFI As TEImpred
			Get
				Return RSWIN_DESC.m_Impred_NOFI
			End Get
			Set(value As TEImpred)
				RSWIN_DESC.m_Impred_NOFI = value
			End Set
		End Property

		Public Property SETUP_UseDefaultDBLocation As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_UseDefaultDBLocation
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_UseDefaultDBLocation = value
			End Set
		End Property

		Public Property SETUP_UseServerDBLocation As Boolean
			Get
				Return RSWIN_DESC.m_SETUP_UseServerDBLocation
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_SETUP_UseServerDBLocation = value
			End Set
		End Property

		Public Property SETUP_ServerDBLocation As String
			Get
				Return RSWIN_DESC.m_SETUP_ServerDBLocation
			End Get
			Set(value As String)
				RSWIN_DESC.m_SETUP_ServerDBLocation = value
			End Set
		End Property

		Public Property bPredictiveRunning As Boolean
			Get
				Return RSWIN_DESC.m_bPredictiveRunning
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bPredictiveRunning = value
			End Set
		End Property

		Public Property bImplementingRodGuides As Boolean
			Get
				Return RSWIN_DESC.m_bImplementingRodGuides
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bImplementingRodGuides = value
			End Set
		End Property

		Public Property bSinkerBarDepthChanged As Boolean
			Get
				Return RSWIN_DESC.m_bSinkerBarDepthChanged
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bSinkerBarDepthChanged = value
			End Set
		End Property

		Public Property Setup_bAlterSBPumpDepth As Short
			Get
				Return RSWIN_DESC.m_Setup_bAlterSBPumpDepth
			End Get
			Set(value As Short)
				RSWIN_DESC.m_Setup_bAlterSBPumpDepth = value
			End Set
		End Property

		Public Property Setup_fInclinationLimit As Single
			Get
				Return RSWIN_DESC.m_Setup_fInclinationLimit
			End Get
			Set(value As Single)
				RSWIN_DESC.m_Setup_fInclinationLimit = value
			End Set
		End Property

		Public Property fNewSinkerbarDepth As Single
			Get
				Return RSWIN_DESC.m_fNewSinkerbarDepth
			End Get
			Set(value As Single)
				RSWIN_DESC.m_fNewSinkerbarDepth = value
			End Set
		End Property

		Public Property fNewTaperLength As Single
			Get
				Return RSWIN_DESC.m_fNewTaperLength
			End Get
			Set(value As Single)
				RSWIN_DESC.m_fNewTaperLength = value
			End Set
		End Property

		Public Property fSBMaxLength As Single
			Get
				Return RSWIN_DESC.m_fSBMaxLength
			End Get
			Set(value As Single)
				RSWIN_DESC.m_fSBMaxLength = value
			End Set
		End Property

		Public Property bDisplayingBatchOutput As Boolean
			Get
				Return RSWIN_DESC.m_bDisplayingBatchOutput
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bDisplayingBatchOutput = value
			End Set
		End Property

		Public Property bReduceFricCoeff As Boolean
			Get
				Return RSWIN_DESC.m_bReduceFricCoeff
			End Get
			Set(value As Boolean)
				RSWIN_DESC.m_bReduceFricCoeff = value
			End Set
		End Property

		Private m_bUseCurrentUser As Boolean = True

		Private m_bRegistryMoveChecked As Boolean = False

		Private m_bUseLatestXRODCode As Boolean = True

		Public RodstarD_Icon As Icon

		Public RodstarV_Icon As Icon

		Public XRODV_Icon As Icon

		Public myCurrentRegion As RegionInfo

		Public myCurrentCulture As CultureInfo

		Public NumFormatInfo As NumberFormatInfo = New NumberFormatInfo()

		Public sExpertFileFolders As String() = New String(12) {}

		Public sExpertFilePrefixes As String() = New String(12) {}

		Public bExtraBeta As Boolean = False

		Public sXRODV_AI_mode_running As String = "AI-mode-running.avi"

		Public sXRODV_Gif_Corner_Filename As String = "AI-mode-animation-100.gif"

		Public sXRODV_Gif_Welcome_bg As String = "AI mode welcome_bg.gif"

		Public sXRODV_Gif_Welcome_head As String = "AI-mode-welcome_head.gif"

		Public sDblQuote As String = """"

		Public GuruDatabasePassword As Object = RSWIN_DESC.sDblQuote + "Feb22**xrod**" + RSWIN_DESC.sDblQuote

		Public sOldThetaName As Object = "Theta Enterprises"

		Public sThetaName As Object = "Theta"

		Public bDoNegativeStressCheck As Boolean = False

		Private m_bRunStarRunning As Boolean = True

		Private m_bAIScoreImproved As Boolean = False

		Private m_bImprovingScore As Boolean = False

		Private m_bAbortRun As Boolean = False

		Private m_bGuruFileDataLoaded As Boolean = False

		Private m_SETUP_bGuru As Boolean = False

		Private m_SETUP_bGuruUseTemplateDatabase As Boolean = False

		Private m_bRunGuru As Boolean = False

		Private m_bOneGuruFile As Boolean = False

		Private m_sAIFilename As String

		Private m_bSuppressWarningMessages As Boolean = False

		Private m_bSuppressWarningMessages_Override As Boolean = False

		Private m_iErrorOccurred As Integer

		Private m_sGuruFilenameKey As String

		Private m_sCurrentFormName As String = ""

		Private m_bRunIconEnabled As Boolean = False

		Public bDoReadsurveyEqualCheck As Boolean = True

		Public bCheckPlunger As Boolean = True

		Public bAddPumpPRWeight As Boolean = True

		Public SECT_DEFAULTS As String = "Defaults"

		Public SECT_FOLDER_DEFAULTS As String = "FolderDefaults"

		Public SECT_SENTINEL As String = "Sentinel"

		Public SECT_GENERAL As String = "General"

		Public SECT_RSWIN As String = "RSWIN"

		Public sProgDirectory As String = "RSWINDirectory"

		Public FileMapping As String = "RSWIN File Mapping"

		Public BATCHLOGNAME As String = "RSTBATCH.LOG"

		Public EXCELBATCH As String = "RSTBATCH"

		Public SECT_WK1FORMATS As String = "RSWK1Formats"

		Public WK1ITEMS_LIST As String = "SPREADSHEET-ITEMS"

		Public SECT_DATAENTRY As String = "RSW Data"

		Public SECT_DEBUGGING As String = "RSWINDebug"

		Public SECT_PREFERENCES As String = "PREFERENCES"

		Private m_EXCELBATCHFILENAME As String = "rstbatch.xls"

		Public sRSVX As String = "rsvx"

		Public sXRVX As String = "xrvx"

		Public sRSDX As String = "rsdx"

		Public sRSVXFileType As String = "RODSTAR vertical file type (*.rsvx)|*.rsvx"

		Public sXRVXFileType As String = "XROD-V files (*.xrvx)|*.xrvx"

		Public sRSDXFileType As String = "RODSTAR deviated file type (*.rsdx)|*.rsdx"

		Public sRSTFileType As String = "RODSTAR old file type (*.rst)|*.rst"

		Public sPDFFileType As String = "RODSTAR files (*.pdf)|*.pdf"

		Public sXLSFileType As String = "Microsoft Office Excel 97-2003 Worksheet (*.XLS)|*.XLS|Microsoft Office Excel Worksheet (*.XLSX)|*.XLSX"

		Public sSelectOutputFileType_wo_RSDX As String = "RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR old file type (*.rst)|*.rst"

		Public sSelectOutputFileType_XRVX As String = "XROD-V files (*.xrvx)"

		Public bRunningPred As Boolean = False

		Public myALLKeyValueHT As Hashtable = New Hashtable()

		Public sEnglish As String = "en-US"

		Public sSpanish As String = "es-ES"

		Public sChinese As String = "zh-Hans"

		Public bCalcNetTorque As Boolean = True

		Public bChangeSPM As Boolean = False

		Public sCustomDBFileName As Object = "CustomRGPU.mdb"

		Public bIntVersion As Boolean = False

		Public bChangeCultures As Boolean = False

		Public bWriteResXFile As Boolean = False

		Public bReadResXFile As Boolean = False

		Public bRunningChineseVersion As Boolean = False

		Public bResxReader As Boolean = True

		Public sHelpFile As String = "rswind.chm"

		Public sRodstarVorD As String = "RODSTARD"

		Private m_SECT_PROGWIN32 As String = "RODSTAR-D"

		Public RECENTFILES As String = "RSW Recent Files"

		Public sRunAVIFileName As Object = "Hourglass.avi"

		Public sHowToFileName As Object = "RODSTARD-HowTo.jpg"

		Public sForWindows As String = " "

		Private m_bRodStarD As Boolean = True

		Public sFILETYPE As String = "rsdx"

		Public sDOTFILETYPE As String = ".rsdx"

		Public sOTHERFILETYPE As String = "rsvx"

		Public sRODSTARFiles As String = "RODSTAR deviated file type (*.rsdx)|*.rsdx|RODSTAR old file type (*.rst)|*.rst|XDIAG files (*.XDG,*.XDDX)|*.XDG;*.XDDX|Adobe Acrobat Document (*.PDF)|*.PDF"

		Public sAllTypes As Object = "RODSTAR deviated file type (*.rsdx)|*.rsdx|RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR old file type (*.rst)|*.rst|ALL RODSTAR files (*.rsdx,*.rsvx,*.rst)|*.rsdx;*.rsvx;*.rst|XDIAG files (*.xdg,*.xddx)|*.xdg;*.xddx|RODDIAG files (*.rdg)|*.rdg|All Files|*.*"

		Public sImportRSTXFiles As String = "Files with deviation (*.rsdx,*.xddx,*.deviationprofile)|*.rsdx;*.xddx;*.deviationprofile|RODSTAR-D files (*.rsdx)|*.rsdx|XDIAG-D files (*.xddx)|*.xddx|RODSTAR files (*.deviationprofile)|*.deviationprofile"

		Public sSelectOutputFileType As String = "RODSTAR deviated file type (*.rsdx)|*.rsdx|RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR old file type (*.rst)|*.rst"

		Public sSelectOutputFileTypePDF As String = "Adobe Acrobat Document (*.PDF)|*.PDF"

		Public bBETA As Boolean = True

		Public bWriteCSVFIles As Boolean = False

		Public bChangeMotorSize As Boolean = False

		Public m_sProgramName As String = Conversions.ToString(Operators.ConcatenateObject("RODSTAR-D ", Interaction.IIf(RSWIN_DESC.bExtraBeta, " Beta ", "")))

		Public m_sProgramLongName As String = Conversions.ToString(Operators.ConcatenateObject("RODSTAR-D ", Interaction.IIf(RSWIN_DESC.bExtraBeta, " Beta ", "")))

		Public m_sProgramNameD As String = RSWIN_DESC.m_sProgramName

		Public m_sProgramLongNameD As String = RSWIN_DESC.m_sProgramLongName

		Public m_sProgramNameV As String = "RODSTAR-V "

		Public m_sProgramLongNameV As String = "RODSTAR-V "

		Private m_bQuickFix As Boolean = False

		Public bQuickFixUsed As Boolean = False

		Public bQuickFixLoop As Boolean = False

		Public bExpert As Boolean = False

		Public bXRODAdmin As Boolean = False

		Public bCheckSmallestUnit As Boolean = False

		Public sTemplateDBFileName As String = "xr.mdb"

		Public sTemplateDBFileName_En As String = "xre.mdb"

		Public sRunForSpeedFootnote As Object = "Calculations, especially for Side Loads and Rod Guide Recommendations, may be less accurate when using 'Run for Speed' option."

		Private m_bProcessFinished As Boolean = False

		Public OriginalConst As Short = 1S

		Public bUseFluidInertiaPumpLoadAdj As Boolean = True

		Public bCombinedTapers As Boolean = True

		Public Default_File_Folder As Object = "c:\Theta\"

		Public Const fPlotRatio1 As Double = 1.4252

		Public fDynoLegendFactor As Single = 0F

		Public fTorqueLegendFactor As Single = 0F

		Public gbDemoMode As Boolean = False

		Public gsDemoFile As String

		Public gbDemoShowWellInfo As Boolean

		Public gbTrialLicenseExpired As Boolean

		Public gsTrialType As String

		Public gbRetry As Boolean = False

		Public bCheck4Sentinel As Boolean = False

		Public myCulture As CultureInfo

		Public RwX As ResXResourceWriter

		Public RzX As ResXResourceReader

		Public RzxEn As IDictionaryEnumerator

		Public bRSWINEXE As Boolean = False

		Public bLog As Boolean = False

		Public frmMain As RODSTAR

		Public rst As cRODSTAR

		Private m_rst_save As cRODSTAR

		Public rst_save_xrvx As cRODSTAR

		Public ThetaStdInfoGThetaStdInfo_definst As GThetaStdInfo = New GThetaStdInfo(VERSION1.ProgramName())

		Public ps As PrinterSettings = New PrinterSettings()

		Public pd As PrintDialog = New PrintDialog()

		Public objExcel As Object

		Public iNeg As Integer

		Public iPos As Integer

		Public fSumNeg As Single

		Public fSumPos As Single

		Public nDefaultListSize As Integer

		Public sDefaultListNames As String()

		Public sDefaultListValues As String()

		Public adiDefaults As RSWIN_DESC.DEFAULTITEM()

		Public nItems As Short

		Public nNewRGTypes As Short

		Public NewRGTypes As RSWIN_DESC.CustomRodGrade()

		Public Inputfile As String

		Public HelpNameSpace As String

		Public objLog As EventLog = New EventLog()

		Public objDebugLog As EventLog = New EventLog()

		Public sLastMDIFormName As String = ""

		Public sINIFile As String

		Public nMaxRodSections As Integer

		Public mcBatchFiles As Integer

		Public mhBatchLog As Integer

		Public miBatchCurFile As Integer

		Public mrgBatchFileList As String()

		Public sAI_DBKeys As String()

		Public sAI_DBPrefixes As String()

		Public iCurrentBatchFile As Integer

		Public msBatchLogFile As String

		Public msClockCaption As String

		Public sBatchGuruPUManufPreferences As String()

		Public bBatchGuruPUManufFound As Boolean() = New Boolean(8) {}

		Public CancelBatch As Boolean = True

		Public bMotorDBOpen As Boolean = False

		Public mbStartAutoBatch As Boolean = False

		Public mbStartAutoBatchHide As Boolean = False

		Public msArgRSTFilePath As String = ""

		Public DEBUG_AllowDebugging As Boolean = False

		Public DEBUG_CreateDYN As Short

		Public DEBUG_DebugMessages As Short

		Public DEBUG_DisableOnError As Short

		Public DEBUG_SetNcycles As Short

		Public DEBUG_ShowAllBalanced As Short

		Public DEBUG_ShowPredictInfo As Short

		Public DEBUG_PlotAllDownholeCards As Boolean = False

		Public Const ENGLISH As Integer = 1

		Public Const CANADIAN As Integer = 2

		Public Const METRIC As Integer = 3

		Public Const CHART_HIDDEN As Single = Single.PositiveInfinity

		Public sARS As String = "Are you sure?"

		Public sDYWXDIAGCorrectCard As String = "XDIAG corrected a load shift in the actual surface card.  Do you want to have the corrected card displayed instead of the measured card?"

		Public lmx As Object

		Public lmn As Object

		Public pmx As Object

		Public pmn As Object

		Public EDataSet As DataSet

		Public VDataSet As DataSet

		Friend SaveWidth As Object = 0

		Friend SaveHeight As Object = 0

		Public bAnimating As Boolean

		Public rgbEditComplete As Color = SystemColors.Window

		Public rgbEditFocus As Color = Color.Cyan

		Public rgbEditFocusOtherUnits As Color = Color.Green

		Public rgbEditRequired As Color = Color.Yellow

		Public Chr9 As String = "    "

		Public bPDFFileSaved As Boolean

		Private htDataEntryErrors As Hashtable = New Hashtable()

		Public VersionMajor As Object = Assembly.GetExecutingAssembly().GetName().Version.Major

		Public VersionMinor As Object = Assembly.GetExecutingAssembly().GetName().Version.Minor

		Public VersionBuild As Object = Assembly.GetExecutingAssembly().GetName().Version.Build

		Public VersionRevision As Object = Assembly.GetExecutingAssembly().GetName().Version.Revision

		Public FullName As Object = Assembly.GetExecutingAssembly().FullName

		Public Const CL_FULLPUMP As Integer = 1

		Public Const CLMASK_INCOMPLETE As Integer = 6

		Public Const CL_INCOMPLETE As Integer = 0

		Public Const CL_FLUIDPOUND As Integer = 2

		Public Const CL_GASINTERFERENCE As Integer = 4

		Public Const CLMASK_FILLAGE As Integer = 1016

		Public Const CLSHIFT_FILLAGE As Integer = 3

		Public Const CL_SHALLOW_FRICTION As Integer = 1024

		Public Const CL_ROD_TUBING_FRICTION As Integer = 2048

		Public Const CL_BENT_PUMP_BARREL As Integer = 4096

		Public Const CL_MALFUNCTIONING_TUBING_ANCHOR As Integer = 8192

		Public Const CL_WORN_PUMP_BARREL As Integer = 16384

		Public Const CL_ADJUST_SURFPOSPHASE As Integer = 65536

		Public Const CLMASK_TRAVELING_VALVE_LEAK As Integer = -1073741824

		Public Const CLTVLEAK_NONE As Integer = 0

		Public Const CLTVLEAK_SLIGHT As Integer = -1073741824

		Public Const CLTVLEAK_MODERATE As Integer = -2147483648

		Public Const CLTVLEAK_SEVERE As Integer = 1073741824

		Public Const CL_HITTING_UP As Integer = 536870912

		Public Const CL_GAS_EXPANSION As Integer = 268435456

		Public Const CLMASK_STANDING_VALVE_LEAK As Integer = -1073741824

		Public Const CLSVLEAK_NONE As Integer = 0

		Public Const CLSVLEAK_SLIGHT As Integer = -1073741824

		Public Const CLSVLEAK_MODERATE As Integer = -2147483648

		Public Const CLSVLEAK_SEVERE As Integer = 1073741824

		Public Const CL_HITTING_DOWN As Integer = 536870912

		Public Const CL_SINKER_BAR_WAVE_REFLECTION As Integer = 268435456

		Public Const CL_PFR_S_SUCCESS As Integer = 0

		Public Const CL_PFR_E_FRICTION As Integer = 1

		Public Const CL_PFR_E_NOBUOYANCY As Integer = 2

		Public Const CL_PFR_E_INCORRECTSPM As Integer = 3

		Public Const CL_PFR_E_PUMPCONDITION As Integer = 4

		Public Const CL_RP_S_SUCCESS As Integer = 0

		Public Const CL_RP_E_RODPART As Integer = 1

		Public Const CL_RP_E_WORNPUMP As Integer = 2

		Public Const CL_RTF_S_SUCCESS As Integer = 0

		Public Const CL_RTF_E_PUMPCONDITION As Integer = 1

		Public Const CL_RTF_E_FRICTION As Integer = 2

		Public Const CL_RTF_E_HITTING_DOWN As Integer = 3

		Public Const CDX_FILEOPEN As Integer = 10

		Public Const CDX_SETUPGENERAL As Integer = 200

		Public Const CDX_SETUPDEFAULTS As Integer = 201

		Public Const CDX_SETUPOUTPUT As Integer = 202

		Public Const CDX_SETUPRGEQUIP As Integer = 203

		Public Const CDX_SETUPPUEQUIP As Integer = 204

		Public Const CDX_SETUPDIAGOPTS As Integer = 205

		Public Const CDX_SETUPBATCHSPR As Integer = 206

		Public Const CDX_SETUPBATCHAUT As Integer = 207

		Public Const CB_NONE As Integer = 0

		Public Const CB_MCM As Integer = 1

		Public Const CB_CBE As Integer = 2

		Public Const CB_DIGITIZED As Integer = 3

		Public Const CB_DYNA As Integer = 4

		Public Const CB_CBLFILE As Integer = 5

		Public Const CR_CLOCKWISE As Integer = 1

		Public Const CR_COUNTERCLOCKWISE As Integer = -1

		Public Const UNLOAD_JUSTDOIT As Integer = 0

		Public Const UNLOAD_NEXTSCREEN As Integer = 1

		Public Const UNLOAD_RUN As Integer = 2

		Public Const SCR_RESULTS As Integer = -2

		Public Const SCR_PREVSCREEN As Integer = -1

		Public Const SCR_NEXTSCREEN As Integer = 0

		Public Const SCR_WELLINFO As Integer = 1

		Public Const SCR_PRODINFO As Integer = 2

		Public Const SCR_PTINFO As Integer = 3

		Public Const SCR_RSINPUT As Integer = 4

		Public Const SCR_DEVIATIONPROFILE As Integer = 5

		Public Const SCR_PUDATA As Integer = 6

		Public Const SCR_MOTORDATA As Integer = 7

		Public Const SCR_MAX As Integer = 7

		Public Const DF_COMPANYNAME As Integer = 0

		Public Const DF_WELLNAME As Integer = 1

		Public Const DF_USERNAME As Integer = 2

		Public Const DF_COMMENT As Integer = 3

		Public Const DF_DATE As Integer = 4

		Public Const DF_DYNAMOMETER As Integer = 5

		Public Const DF_RUNTIME As Integer = 6

		Public Const DF_PUMPDEPTH As Integer = 7

		Public Const DF_TUBINGPRESSURE As Integer = 8

		Public Const DF_CASINGPRESSURE As Integer = 9

		Public Const DF_WATERCUT As Integer = 10

		Public Const DF_WATERSPGR As Integer = 11

		Public Const DF_OILAPI As Integer = 12

		Public Const DF_FLUIDSPGR As Integer = 13

		Public Const DF_FLPIP As Integer = 0

		Public Const DF_SPM As Integer = 1

		Public Const DF_PRODUCTION As Integer = 2

		Public Const DF_MIDPERFDEPTH As Integer = 3

		Public Const DF_STATICBHPRESSURE As Integer = 4

		Public Const DF_BUBBLEPOINT As Integer = 5

		Public Const DF_TUBINGSIZE As Integer = 0

		Public Const DF_FRICTION As Integer = 1

		Public Const DF_TUBINGANCHORDEPTH As Integer = 2

		Public Const DF_PLUNGERSIZE As Integer = 3

		Public Const DF_PUMPTYPE As Integer = 4

		Public Const DF_P_FLUIDINERTIA As Integer = 0

		Public Const DF_P_COMPRESSINDEX As Integer = 1

		Public Const DF_P_PLUNGERSIZE As Integer = 2

		Public Const DF_P_PUMPCONDITION As Integer = 3

		Public Const DF_P_PUMPDEPTH As Integer = 4

		Public Const DF_P_PUMPEFFICIENCY As Integer = 5

		Public Const DF_P_PUMPFILLAGE As Integer = 6

		Public Const DF_P_PUMPTYPE As Integer = 7

		Public Const DF_ADDCOST As Integer = 0

		Public Const DF_COSTDESC As Integer = 1

		Public Const DF_SERVICEFACTOR As Integer = 2

		Public Const DF_RODSTRING As Integer = 3

		Public Const DF_UNITMANUFACTURER As Integer = 0

		Public Const DF_PUMPINGUNIT As Integer = 1

		Public Const DF_UNITID As Integer = 2

		Public Const DF_CRANKROTATION As Integer = 3

		Public Const DF_CRANKHOLE As Integer = 4

		Public Const DF_UNBALANCE As Integer = 5

		Public Const DF_MAXCBM As Integer = 6

		Public Const DF_CBEFFECT As Integer = 7

		Public Const DF_COUNTERBALANCE As Integer = 8

		Public Const DF_ELECTRICITYCOST As Integer = 0

		Public Const DF_MOTORSIZE As Integer = 1

		Public Const DF_MOTORSPDVAR As Integer = 2

		Public Const DF_MOTORTYPE As Integer = 3

		Public Const DF_POWERMETERTYPE As Integer = 4

		Public Const DF_TORQUEMODE As Integer = 5

		Public Const DF_DevSurvey As Integer = 0

		Public Const DF_DevPlot As Integer = 1

		Public Const cNULL_EVENT As Integer = 61440

		Public Const cCHECK_LOADED_FORMS As Integer = 61441

		Public Const cOPEN_CMDLINE_FILE As Integer = 61442

		Public Const cASK_AUTOMATIC As Integer = 61443

		Public Const cMEASUREMENT_UNITS_CHANGED As Integer = 61444

		Public Const cRELOAD_MEASURED_UNITS As Integer = 61445

		Public Const cCHECK_IPR As Integer = 61446

		Public Const MASK_NONE As Integer = 0

		Public Const MASK_AVAILABLE As Integer = 1

		Public Const MASK_SELECTED As Integer = 2

		Public Const DYN_NONE As Integer = 0

		Public Const DYN_POINTPLOT As Integer = 1

		Public Const DYN_SOLIDLINE As Integer = 2

		Public Const DYN_DISKFILE As Integer = 3

		Public Const DYN_AUTOBATCH As Integer = 6

		Public Const DYS_NONE As Integer = -1

		Public Const DYS_THETAFILE As Integer = 0

		Public Const DYS_DELTAXFILE As Integer = 1

		Public Const DYS_NABLAFILE As Integer = 2

		Public Const DYS_POINTPLOT As Integer = 3

		Public Const DYS_SOLIDLINE As Integer = 4

		Public Const DYS_LEUTERT As Integer = 5

		Public Const DYS_AUTOBATCH As Integer = 6

		Public Const DYS_UNKNOWN As Integer = 7

		Public Const ERR_ABORT_QUIET As Integer = 253

		Public Const ERR_ABORT As Integer = 254

		Public Const FL_NONE As Integer = 0

		Public Const FL_ENTERED As Integer = 1

		Public Const FL_PIP As Integer = 2

		Public Const IPR_FETKOVICH As Integer = 0

		Public Const IPR_VOGEL As Integer = 1

		Public Const IPR_NONE As Integer = -1

		Public Const LINE_NONE As Integer = 0

		Public Const LINE_LEFT As Integer = 1

		Public Const LINE_RIGHT As Integer = 2

		Public Const LINE_TOP As Integer = 3

		Public Const LINE_BOTTOM As Integer = 4

		Public Const UNITS_BPD As Integer = 0

		Public Const UNITS_DEPTH As Integer = 1

		Public Const UNITS_DIAMETER As Integer = 2

		Public Const UNITS_LENGTH As Integer = 3

		Public Const UNITS_OILGRAVITY As Integer = 4

		Public Const UNITS_PLUNGERSIZE As Integer = 5

		Public Const UNITS_PRODCOST As Integer = 6

		Public Const UNITS_PRESSURE As Integer = 7

		Public Const UNITS_STROKELENGTH As Integer = 8

		Public Const UNITS_TENSILESTRENGTH As Integer = 9

		Public Const UNITS_TORQUE As Integer = 10

		Public Const UNITS_TUBING As Integer = 11

		Public Const UNITS_WEIGHT As Integer = 12

		Public Const DPLOT_SURF As Integer = 1

		Public Const DPLOT_SURFPRED As Integer = 2

		Public Const DPLOT_PUMP As Integer = 4

		Public Const DPLOT_PUMPNOFI As Integer = 8

		Public Const DPLOT_PERMLOAD As Integer = 16

		Public Const DPLOT_LINES As Integer = 32

		Public Const DPLOT_PUMPNOTUB As Integer = 64

		Public Const Detent As Integer = 1

		Public Const NonDetent As Integer = 2

		Public Const PC_FULLPUMP As Integer = 1

		Public Const PC_FLUIDPOUND As Integer = 2

		Public Const PC_GASINTERFERENCE As Integer = 3

		Public Const PT_INSERT As Integer = 1

		Public Const PT_TUBING As Integer = 2

		Public Const PT_LARGEBORE As Integer = 3

		Public Const PUSORT_BYNAME As Integer = 0

		Public Const PUSORT_BYSTROKE As Integer = 1

		Public Const PUSORT_BYGEARBOX As Integer = 2

		Public Const PUSORT_MEASUREDPU As Integer = 3

		Public Const PUSORT_BYGEARBOX_2 As Integer = 4

		Public Const PUSORT_BYSTRUCTURE As Integer = 5

		Public Const PUSORT_BYSTRUCTURE_2 As Integer = 6

		Public Const PUTYPE_NONE As Integer = -1

		Public Const conventional As Integer = 1

		Public Const Enhanced As Integer = 2

		Public Const Grooves As Integer = 3

		Public Const LowProfile As Integer = 4

		Public Const MarkII As Integer = 5

		Public Const AirBalanced As Integer = 6

		Public Const LongStroke As Integer = 7

		Public Const BeamBalanced As Integer = 8

		Public Const BeltLowProfile As Integer = 9

		Public Const Hydraulic As Short = 10S

		Public Const CombinationBeamCrank As Short = 11S

		Public Const RPT_DYNOPLOT As Integer = 0

		Public Const RPT_TORQUEPLOT As Integer = 1

		Public Const RPT_IPRPLOT As Integer = 2

		Public Const RPT_MATCHINFO As Integer = 3

		Public Const RPT_SUMMARY As Integer = 4

		Public Const RPT_TUBING As Integer = 5

		Public Const RPT_DOWNHOLE As Integer = 6

		Public Const RPT_RODSTRING As Integer = 7

		Public Const RPT_PUTORQUE As Integer = 8

		Public Const RPT_ENERGY As Integer = 9

		Public Const RPT_IPRDATA As Integer = 10

		Public Const RP_DIAG As Integer = 32768

		Public Const RPD_DOWNHOLE As Integer = 16

		Public Const RPD_RODSTRING As Integer = 32

		Public Const RPD_SURFACE As Integer = 64

		Public Const RPD_INPUT As Integer = 128

		Public Const RPT_NONE As Integer = -1

		Public Const RPT_DIAGNOSIS As Integer = 0

		Public Const RPT_REPORT As Integer = 1

		Public Const RPT_REPORT_GRAPH As Integer = 2

		Public Const MATL_STEEL As Integer = 0

		Public Const MATL_APISTEEL As Integer = 1

		Public Const MATL_SINKERBAR As Integer = 2

		Public Const MATL_COROD As Integer = 3

		Public Const MATL_FG As Integer = 4

		Public Const MATL_RR As Integer = 5

		Public Const MATL_PROROD As Integer = 6

		Public Const API_K As Integer = 4097

		Public Const API_C As Integer = 4098

		Public Const API_D As Integer = 4099

		Public Const Electra As Integer = 4100

		Public Const Norris97 As Integer = 4101

		Public Const LTV_HS As Integer = 4102

		Public Const UPCO50K As Integer = 4103

		Public Const Trico66 As Integer = 4104

		Public Const AxelsonS88 As Integer = 4105

		Public Const HighlandXD As Integer = 4106

		Public Const AxelsonS87 As Integer = 4107

		Public Const AxelsonS67 As Integer = 4108

		Public Const AxelsonS60 As Integer = 4109

		Public Const UPCO_C_GRADE As Integer = 4110

		Public Const UPCO_CD_GRADE As Integer = 4111

		Public Const UPCO_AD_GRADE As Integer = 4112

		Public Const UPCO_KD_GRADE As Integer = 4113

		Public Const UPCO_K_GRADE As Integer = 4114

		Public Const UPCO_HS_GRADE As Integer = 4115

		Public Const Norris96 As Integer = 4116

		Public Const TenarisUHS As Integer = 4117

		Public Const TenarisMMS As Integer = 4118

		Public Const TenarisPLUS As Integer = 4119

		Public Const WeatherFordMD56 As Integer = 4120

		Public Const WeatherFordKD63 As Integer = 4121

		Public Const GlobalAD79 As Integer = 4122

		Public Const GlobalS99 As Integer = 4123

		Public Const NorrisC30 As Integer = 4124

		Public Const NorrisK40 As Integer = 4125

		Public Const NorrisD54 As Integer = 4126

		Public Const NorrisD75 As Integer = 4127

		Public Const NorrisD78 As Integer = 4128

		Public Const NorrisD90 As Integer = 4129

		Public Const UPCO_SD_GRADE As Integer = 4130

		Public Const WeatherFordHD As Integer = 4131

		Public Const CAMC As Integer = 4132

		Public Const CAMK As Integer = 4133

		Public Const CAMDC As Integer = 4134

		Public Const CAMDA As Integer = 4135

		Public Const CAMDS As Integer = 4136

		Public Const CAMHS As Integer = 4137

		Public Const TenarisD As Integer = 4138

		Public Const TenarisDAlloy As Integer = 4139

		Public Const TenarisKD As Integer = 4140

		Public Const UPCO_HX_GRADE As Integer = 4141

		Public Const TenarisBRKD As Integer = 4142

		Public Const NewCustomSteel As Integer = 4143

		Public Const NewOtherSteel As Integer = 4143

		Public Const CustomSteel As Integer = 4096

		Public Const OtherSteel As Integer = 4096

		Public Const OrigCustomSteel As Integer = 4096

		Public Const OrigOtherSteel As Integer = 4096

		Public Const UPCO_C_NAME As String = "UPCO C"

		Public Const UPCO_CD_NAME As String = "UPCO CD"

		Public Const UPCO_AD_NAME As String = "UPCO AD"

		Public Const UPCO_KD_NAME As String = "UPCO KD"

		Public Const UPCO_K_NAME As String = "UPCO K"

		Public Const UPCO_HS_NAME As String = "UPCO HS"

		Public Const UPCO_HX_NAME As String = "UPCO HX"

		Public Const UPCO_C_TENSILE As Integer = 90000

		Public Const UPCO_CD_TENSILE As Integer = 115000

		Public Const UPCO_AD_TENSILE As Integer = 115000

		Public Const UPCO_KD_TENSILE As Integer = 115000

		Public Const UPCO_K_TENSILE As Integer = 90000

		Public Const UPCO_HS_TENSILE As Integer = 140000

		Public Const UPCO_HX_TENSILE As Integer = 140000

		Public Const APISB_C As Integer = 8193

		Public Const APISB_K As Integer = 8194

		Public Const FlexbarC As Integer = 8195

		Public Const FlexbarK As Integer = 8196

		Public Const APISB_C_NN As Integer = 8197

		Public Const APISB_K_NN As Integer = 8198

		Public Const FlexbarC_NN As Integer = 8199

		Public Const FlexbarK_NN As Integer = 8200

		Public Const NPRSB_CARBON As Integer = 8301

		Public Const NPRSB_ALLOY As Integer = 8302

		Public Const NPRSB_NORLOY As Integer = 8303

		Public Const NPRSB_PISTON As Integer = 8304

		Public Const Norris_C_sb As Integer = 8305

		Public Const Norris_C_nn As Integer = 8306

		Public Const Norris_K_sb As Integer = 8307

		Public Const Norris_K_nn As Integer = 8308

		Public Const Norris_D_sb As Integer = 8309

		Public Const Norris_D_nn As Integer = 8310

		Public Const sNPRSBCARBON As String = "Norris PR Steel"

		Public Const sNPRSBALLOY As String = "Norris PR Alloy"

		Public Const sNPRSBNORLOY As String = "Norris PR Norloy"

		Public Const sNPRSBPiston As String = "Norris PR Piston"

		Public Const sNPRSBCARBON_Abbrv As String = "NRS PR Steel"

		Public Const sNPRSBALLOY_Abbrv As String = "NRS PR Alloy"

		Public Const sNPRSBNORLOY_Abbrv As String = "NRS PR Norloy"

		Public Const sNPRSBPISTON_Abbrv As String = "NRS PR Piston "

		Public Const NewCustomSinkerBar As Integer = 8311

		Public Const NewOtherSinkerBar As Integer = 8311

		Public Const ESTEEL As Integer = 30500000

		Public Const corod_SE_C As Integer = 12545

		Public Const corod_SE_D As Integer = 12546

		Public Const corod_SE_HS41 As Integer = 12547

		Public Const corod_SE_Endura As Integer = 12548

		Public Const corod_SE_DE As Integer = 12549

		Public Const corod_SE_SE As Integer = 12550

		Public Const corod_R_D As Integer = 12801

		Public Const corod_R_HS41 As Integer = 12802

		Public Const corod_R_Endura As Integer = 12803

		Public Const corod_R_C As Integer = 12804

		Public Const corod_R_DE As Integer = 12805

		Public Const corod_R_SE As Integer = 12806

		Public Const corod_R_DW As Integer = 12807

		Public Const corod_R_SW As Integer = 12808

		Public Const corod_H_D As Integer = 13057

		Public Const OrigCustomFG As Integer = 16384

		Public Const OrigOtherFG As Integer = 16384

		Public Const NewCustomFG As Integer = 16397

		Public Const NewOtherFG As Integer = 16397

		Public Const CustomFG As Integer = 16384

		Public Const OtherFG As Integer = 16384

		Public Const Fiberflex37 As Integer = 16385

		Public Const PetroRod As Integer = 16386

		Public Const NorrisFG As Integer = 16387

		Public Const Durarod As Integer = 16388

		Public Const Fiberflex30 As Integer = 16389

		Public Const Fiberflex25 As Integer = 16390

		Public Const FIBEROD As Integer = 16391

		Public Const FIBEROD_CCR As Integer = 16393

		Public Const FlexRod As Integer = 16394

		Public Const FinalRod As Integer = 16395

		Public Const Fiberco As Integer = 16396

		Public Const RibbonRod As Integer = 20481

		Public Const PROROD_620 As Integer = 24577

		Public Const PROROD_790 As Integer = 24578

		Public Const PROROD_780 As Integer = 24579

		Public Const PROROD_750 As Integer = 24580

		Public Const PROROD_960 As Integer = 24581

		Public Const PROROD_970 As Integer = 24582

		Public sPROROD620 As String = "Pro Rod 620 Carbon"

		Public sPROROD790 As String = "Pro Rod 790 Nickel"

		Public sPROROD780 As String = "Pro Rod 780 Alloy"

		Public sPROROD750 As String = "Pro Rod 750 Alloy"

		Public sPROROD960 As String = "Pro Rod 960 Alloy"

		Public sPROROD970 As String = "Pro Rod 970 Alloy"

		Public Const STRESS_API As Integer = 0

		Public Const STRESS_HIGH_STRENGTH As Integer = 1

		Public Const STRESS_COROD_ENDURA As Integer = 2

		Public Const STRESS_ELECTRA As Integer = 3

		Public Const STRESS_MGS As Integer = 4

		Public Const STRESS_FIBERFLEX As Integer = 5

		Public Const STRESS_NORRISFG As Integer = 6

		Public Const STRESS_DURAROD As Integer = 7

		Public Const STRESS_RibbonRod As Integer = 8

		Public Const STRESS_FIBEROD As Integer = 9

		Public Const STRESS_Tenaris As Integer = 10

		Public Const STRESS_FIBEROD_CCR As Integer = 11

		Public Const STRESS_TENARIS_PC As Integer = 12

		Public Const STRESS_FlexRod As Integer = 13

		Public Const STRESS_FinalRod As Integer = 14

		Public Const STRESS_Fiberco As Integer = 15

		Public Const STRESS_TENARIS_BRKD As Integer = 16

		Public Const TB_MOST As Integer = -2

		Public Const TB_ALL As Integer = -1

		Public Const TB_FILENEW As Integer = 0

		Public Const TB_FILEOPEN As Integer = 1

		Public Const TB_FILESAVE As Integer = 2

		Public Const TB_SEPARATOR_1 As Integer = 3

		Public Const TB_SEPARATOR_2 As Integer = 4

		Public Const TB_SETUP As Integer = 5

		Public Const TB_SEPARATOR_3 As Integer = 6

		Public Const TB_SEPARATOR_4 As Integer = 7

		Public Const TB_WELLINFO As Integer = 8

		Public Const TB_PRODINFO As Integer = 9

		Public Const TB_PTINFO As Integer = 10

		Public Const TB_RSINPUT As Integer = 11

		Public Const TB_DeviationProfile As Integer = 12

		Public Const TB_PUDATA As Integer = 13

		Public Const TB_MOTORDATA As Integer = 14

		Public Const TB_PREVIOUS_SCREEN As Integer = 15

		Public Const TB_NEXTSCREEN As Integer = 16

		Public Const TB_RUN As Integer = 0

		Public Const TB_RUN_SPEED As Integer = 1

		Public Const TB_REPORT As Integer = 2

		Public Const TB_EMAIL As Integer = 3

		Public Const TB_FILEPRINT As Integer = 4

		Public Const TB_EXPORTMCM As Integer = 5

		Public Const TB_SEPARATOR_5 As Integer = 6

		Public Const TB_SEPARATOR_6 As Integer = 7

		Public Const TB_AUTOMATIC As Integer = 8

		Public Const TB_HELP As Integer = 0

		Public Const TB_MAX As Integer = 0

		Public Const BalancedE As Integer = 0

		Public Const BalancedT As Integer = 1

		Public Const Existing As Integer = 2

		Public Const cBVERSION As Integer = 5

		Public Const RDVERSION As Integer = 29

		Public Const XDVERSION As Integer = 24

		Public Const V2XDOVERSION As Integer = 21

		Public Const XDOVERSION As Integer = 27

		Public Const RDCALCVERSION As Integer = 1

		Public Const cALCVERSION As Integer = 1

		Public Const RSVERSION As Short = 29S

		Public Const RS_DEVIATED_VERSION As Short = 30S

		Public Const RS_NEW_DEVIATED_VERSION As Short = 31S

		Public Const MOTOR_VERSION As Integer = 1

		Public Const PM_NONE As Integer = 0

		Public Const PM_NEMA_D As Integer = 1

		Public Const PM_SARGENT_EP2_ODP As Integer = 2

		Public Const PM_RELIANCE As Integer = 3

		Public Const PM_SARGENT_EP2_TEFC As Integer = 4

		Public Const PM_ROTAFLEX_NEMA_C As Integer = 5

		Public Const PM_SARGENT_EP3_ODP As Integer = 6

		Public Const PM_Marathon As Integer = 7

		Public Const PM_Tatung As Integer = 8

		Public Const PM_Baranchi As Integer = 9

		Public Const PM_JSC As Integer = 10

		Public Const PM_Vladimir As Integer = 11

		Public Const PM_JSC_Eldin As Integer = 12

		Public Const PM_Bulgaria As Integer = 13

		Public Const TM_LOW As Integer = 1

		Public Const TM_MEDIUM_LOW As Integer = 2

		Public Const TM_MEDIUM As Integer = 3

		Public Const TM_HIGH As Integer = 4

		Public Const GML_MOTORKINDS As Integer = 0

		Public Const GML_MOTORSIZES As Integer = 1

		Public Const GML_MOTORSETTINGS As Integer = 2

		Public Const GMI_RATEDHP As Integer = 0

		Public Const GMI_MOTORKINDNAME As Integer = 1

		Public Const GMI_MOTORSETTINGNAME As Integer = 2

		Public Const GMI_MOTORSIZENAME As Integer = 3

		Public Const GMI_MOTORTYPE As Integer = 4

		Public Const GMI_ISUHSMOTOR As Integer = 5

		Public Const GMI_MOTORSETTINGCOUNT As Integer = 6

		Public Const oldAPI_K As Integer = 1

		Public Const oldAPI_C As Integer = 2

		Public Const oldAPI_D As Integer = 3

		Public Const oldElectra As Integer = 4

		Public Const oldNorris97 As Integer = 5

		Public Const oldLTV_HS As Integer = 6

		Public Const oldUPCO50K As Integer = 7

		Public Const oldTrico66 As Integer = 8

		Public Const oldAxelsonS88 As Integer = 9

		Public Const oldFlexbarC As Integer = 10

		Public Const oldFlexbarK As Integer = 11

		Public Const oldRibbonRod As Integer = 12

		Public Const oldMaxSteel As Integer = 12

		Public Const oldCorod_SE_C As Integer = 100

		Public Const oldCorod_SE_D As Integer = 101

		Public Const oldCorod_SE_HS41 As Integer = 102

		Public Const oldCorod_SE_Ultra As Integer = 106

		Public Const oldMaxCorodSE As Integer = 4

		Public Const oldCorod_R_D As Integer = 103

		Public Const oldCorod_R_HS41 As Integer = 104

		Public Const oldCorod_R_Ultra As Integer = 107

		Public Const oldMaxCorodR As Integer = 4

		Public Const oldCorod_H_D As Integer = 105

		Public Const oldMaxCorodH As Integer = 1

		Public Const oldOtherSteel As Integer = 32767

		Public Const oldOtherFG As Integer = 0

		Public Const oldFiberflex As Integer = -1

		Public Const oldPetroRod As Integer = -2

		Public Const oldNorrisFG As Integer = -3

		Public Const oldDurarod As Integer = -4

		Public Const oldMaxFG As Integer = 4

		Public Const oldFiberflex30 As Integer = 16389

		Public Const oldFiberflex25 As Integer = 16390

		Public Const con As Double = 4633.056

		Public Const GravCon As Double = 32.174

		Public Const WaterSpWt As Double = 62.4

		Public Const R As Double = 0.61803399

		Public Const c As Double = 0.38196600999999997

		Public Const GOLD As Double = 1.61803399

		Public Const TOL As Double = 1E-05

		Public Const cRODSTAR As Integer = 1

		Public Const cRODDIAG As Integer = 2

		Public Const cXDIAG As Integer = 3

		Public DEFAULT_FOLDER_RST As String

		Public DEFAULT_FOLDER_XRVX As String

		Public DEFAULT_FOLDER_IMP As String

		Public DEFAULT_FOLDER_XLS As String

		Public DEFAULT_FOLDER_CBL As String

		Public DEFAULT_FOLDER_DYN As String

		Public DEFAULT_FOLDER_RSTX As String

		Public DEFAULT_FOLDER_RSVX As String

		Public DEFAULT_FOLDER_RSDX As String

		Public DEFAULT_FOLDER_CBLX As String

		Public DEFAULT_FOLDER_DNS As String

		Public DEFAULT_FOLDER_UPS As String

		Public DEFAULT_FOLDER_PDF As String

		Public DEFAULT_FOLDER_XDG As String

		Public DEFAULT_FOLDER_RDG As String

		Public Const dcFluidInertia As Integer = 1

		Public Const dcFluidInertia2 As Integer = 2

		Public Const dcHighUDFriction As Integer = 3

		Public Const dcIncorrectFluidLevel As Integer = 4

		Public Const dcIncorrectPlungerSize As Integer = 5

		Public Const dcLineSettings As Integer = 6

		Public Const dcLoadShift As Integer = 7

		Public Const dcNoReportLineSettings As Integer = 8

		Public Const dcPhaseAdjustment As Integer = 9

		Public Const dcPRHPMatch As Integer = 10

		Public Const dcPumpCardShape As Integer = 11

		Public Const dcPumpCardTilt As Integer = 12

		Public Const dcRodPart As Integer = 13

		Public Const dcRodTubingFriction As Integer = 14

		Public Const dcTubingMovement As Integer = 15

		Public Const RS_NONE As Integer = 0

		Public Const RS_API As Integer = 1

		Public Const RS_USER As Integer = 2

		Public Const RS_RODSTAR As Integer = 3

		Public Const RS_USER_DEVIATED As Integer = 4

		Public Const DES_STEEL As Integer = 0

		Public Const DES_FGSTEEL As Integer = 1

		Public Const DES_RIBBONROD As Integer = 2

		Public Const cMSG_NO_MANUF_INFO As Integer = 175

		Public Const cMSG_NO_MEASURED_UNITS As Integer = 176

		Public Const cMSG_NO_HORIZONTAL_LINES As Integer = 177

		Public Const cMSG_NO_HORIZONTAL_LINES_LSHIFT As Integer = 178

		Public Const cMSG_NO_VERTICAL_LINES As Integer = 179

		Public Const cMSG_NO_VERTICAL_LINES_LSHIFT As Integer = 180

		Public sRSWINNAME As String = "RODSTAR"

		Public sSelectedFolder As String

		Public DEFAULT_WK1ORDER As String = "11,14,7,47,46,9,15,12,19,0,18,49,58"

		Public BPD__M3D As Single = 0.1589873F

		Public FT__M As Single = 0.3048F

		Public IN__CM As Single = 2.54F

		Public IN__MM As Single = 25.4F

		Public LB__N As Single = 4.448222F

		Public LBFT__KGM As Single = 1.488164F

		Public LBFT2__KGM2 As Single = 0.04214011F

		Public MINLB__NM As Single = 112.9848F

		Public PSI__KPA As Single = 6.894757F

		Public Const SzAPI_GMCM3 As String = "A"

		Public Const SzAPI_GMCM3_WELLINFO As String = "a"

		Public Const SzBFPD_M3D As String = "b"

		Public Const SzDPFT_DPM As String = "d"

		Public Const SzFT_M As String = "f"

		Public Const SzIN_CM As String = "c"

		Public Const SzIN2_CM2 As String = "i"

		Public Const SzIN3_CM3 As String = "I"

		Public Const SzIN_MM As String = "m"

		Public Const SzLB_N As String = "l"

		Public Const SzLBFT_KGM As String = "k"

		Public Const SzLBFT2_NM2 As String = "N"

		Public Const SzMINLB_NM As String = "L"

		Public Const SzMLB_N As String = "k"

		Public Const SzMPSI_GPA As String = "P"

		Public Const SzPSI_KPA As String = "p"

		Public Const SzPSIG_KPA As String = "g"

		Public Const Sz100LB_N As String = "h"

		Public Const NoGuide As Integer = 0

		Private m_MOLDED As Short = 1S

		Public Const WHEELED As Integer = 2

		Public Const OtherGuided As Integer = 3

		Public Const NorrisStandardGuide As Short = 4S

		Private m_NorrisSidewinderGuide As Short = 5S

		Public Const RGIJakeCouplingGuide As Short = 6S

		Public Const RGISVTGuide As Short = 7S

		Public Const RGITomahawkGuide As Short = 8S

		Public Const RGITornadoGuide As Short = 9S

		Public Const RGITwisterGuide As Short = 10S

		Public Const RGIWVTGuide As Short = 11S

		Public Const SidewinderGuide As Short = 5S

		Public SETUP_NorrisStandardGuide_Load As Single = 30F

		Public SETUP_NorrisSidewinderGuide_Load As Single = 50F

		Public SETUP_RGIJakeCouplingGuide_Load As Single = 50F

		Public SETUP_RGISVTGuide_LOAD As Single = 30F

		Public SETUP_RGITomahawkGuide_LOAD As Single = 70F

		Public SETUP_RGITornadoGuide_LOAD As Single = 100F

		Public SETUP_RGITwisterGuide_LOAD As Single = 60F

		Public SETUP_RGIWVTGuide_LOAD As Single = 50F

		Public Const sNoGuide As String = "Bare Rod (no rod guides)"

		Public Const sMolded As String = "Molded"

		Public Const sWheeled As String = "Wheeled"

		Public sOtherGuided As String = "Other"

		Public Const sNorrisStandardGuide As String = "Norris Standard"

		Public Const sNorrisSidewinderGuide As String = "Norris Sidewinder"

		Public Const sRGIJakeCouplingGuide As String = "RGI Jake Coupling"

		Public Const sRGISVTGuide As String = "RGI SVT"

		Public Const sRGITomahawkGuide As String = "RGI Tomahawk"

		Public Const sRGITornadoGuide As String = "RGI Tornado"

		Public Const sRGITwisterGuide As String = "RGI Twister"

		Public Const sRGIWVTGuide As String = "RGI WVT"

		Public LF As Char

		Public NewData As Short() = New Short(7) {}

		Public XDUnloadMode As Short

		Public nCmdShow As Short

		Public RSUnloadMode As Short

		Public bUseTLM32 As Boolean

		Public bCheckUSB As Boolean = True

		Public Const MB_OK As Integer = 0

		Public Const MB_OKCANCEL As Integer = 1

		Public Const MB_YESNOCANCEL As Integer = 3

		Public Const MB_ICONSTOP As Integer = 16

		Public Const MB_ICONQUESTION As Integer = 32

		Public Const MB_ICONEXCLAMATION As Integer = 48

		Public Const MB_ICONINFORMATION As Integer = 64

		Public Const MB_DEFBUTTON1 As Integer = 0

		Public Const MB_DEFBUTTON2 As Integer = 256

		Public mbMaxMinNotYetSet As Boolean

		Public DEBUG_DisableAutomatic As Short

		Public DEBUG_DynoPlotStyle As Short

		Public DEBUG_FixSinusoidalDyno As Short

		Public DEBUG_MatchInfoAvailable As Short

		Public DEBUG_NoFIReplaceGoodMatch As Short

		Public DEBUG_RDGFilesFirst As Short

		Public DEBUG_SaveCards As Short

		Public DEBUG_TreatAsSolidLine As Short

		Public gbUseDeviation As Boolean

		Public mdsDeviationProfile As DataSet

		Public mdsDeviationProfile_Edit As DataSet

		Public sSummaryDataSetXML As String

		Public sDeviationProfileXML As String

		Public sTempXMLFile As String

		Public sBatchLogXML As String

		Public pNtsteps As Short

		Public PermLoad As Single()

		Public StatusControl As Control

		Public bBackFromSetLines As Boolean

		Public sysNull As DBNull

		Public bNoLoad As Boolean = False

		Public ThisMagic As String = New String(" "c, 10)

		Public RSMagic As String = New String(" "c, 10)

		Public RDMagic As String = New String(" "c, 10)

		Public CBMagic As String = New String(" "c, 11)

		Public XDMagic As String = New String(" "c, 8)

		Public Const MAXRODSECTIONS As Integer = 40

		Public Const MAXRODSECTIONS_for_input As Integer = 20

		Public gb_HittingUp_Set As Boolean

		Public gf_HittingUp_Max_After As Single

		Public gf_HittingUp_Max_Before As Single

		Public gf_HittingUp_Diff As Single

		Public gf_HittingUp_Percent As Single

		Public gb_HittingDown_Set As Boolean

		Public gf_HittingDown_Min_After As Single

		Public gf_HittingDown_Min_Before As Single

		Public gf_HittingDown_Diff As Single

		Public gf_HittingDown_Percent As Single

		Public CustomRodGradeList As RSWIN_DESC.CustomRodGrade()

		Private Const cCALCULATIONS As Integer = 0

		Private Const cCOSTANALYSIS As Integer = 1

		Private Const cIPRDATA As Integer = 2

		Private Const cDYNO_PRED As Integer = 3

		Private Const cDevChart As Integer = 4

		Private Const cGuideReport As Integer = 5

		Private Const cDYNO_ACTUAL As Integer = 6

		Private Const cSummary As Integer = 7

		Public THETA_INI As String = "THETA32.INI"

		Private m_SETUP_GuideToUse As Integer

		Private m_SETUP_ParaffinRodGuide As Integer

		Private m_SETUP_BatchPrintouts As Integer

		Public SETUP_BatchSaveWorksheet As Integer

		Private m_SETUP_BatchViewWorksheet As Integer

		Public SETUP_BatchSkipProcessedFiles As Integer

		Public SETUP_BatchUpdateCustomRodGrades As Integer

		Public SETUP_BeginTime As DateTime

		Public SETUP_IntervalTime As DateTime

		Public SETUP_CreatePDFs As Integer

		Private m_SETUP_MeasurementSystem As Integer

		Private m_SETUP_Language As String

		Private m_SETUP_MaxFGLoading As Single

		Private m_SETUP_MaxSteelLoading As Single

		Public SETUP_GearboxRatio As Single

		Public SETUP_VBeltRatio As Single

		Public SETUP_PlaySounds As Short

		Public SETUP_PrintCostAnalysis As Short

		Public SETUP_CoverPage As Short

		Public SETUP_PrintData As Short

		Public SETUP_PrintDynoActual As Short

		Public SETUP_PrintDynoPred As Short

		Public SETUP_PrintIPR As Short

		Public SETUP_PrintSinglePageDynoTorque As Short

		Public SETUP_PrintDevChart As Short

		Public SETUP_PrintGuide As Short

		Private m_SETUP_ReportDevSurvey As Short

		Private m_SETUP_OrderPage As Short

		Public SETUP_PrintTorque As Short

		Public SETUP_ShowVisualInput As Short

		Public SETUP_ExitIfIdle As Short

		Public SETUP_SaveOpenFileOnExit As Short

		Private m_SETUP_SteelSuckerRodLength As Single

		Public SETUP_SaveXDIAGMeasuredCard As Short

		Public m_SETUP_UseImpred As Short

		Private m_SETUP_DisplaySBinFeet As Short

		Private m_SETUP_SummaryPage As Short

		Private m_SETUP_ScoringPage As Short

		Private m_SETUP_WK1Format As String

		Public SETUP_PrintDiagnosis As Integer

		Public SETUP_TabletPort As Integer

		Private m_SETUP_RSWINDIR As String

		Private m_SETUP_GURUTEMPDIR As String

		Private m_SETUP_GURUSAVEDIR As String

		Public SETUP_WK1Dir As String

		Public SETUP_BatchPrintResults As Short

		Private m_SETUP_DISPLAYAZDIRTOOLBAR As Short = 0S

		Private m_SETUP_OPTIMIZESURVEY As Short = 0S

		Private m_SETUP_RunForSpeed As Short = 0S

		Private m_SETUP_ALLOWSLIDEFRIC As Short

		Public SETUP_CalcVBeltRatio As Short

		Public SETUP_DisplayRuntimeWarning As Short

		Public SETUP_DisplayTargetBFPDWarning As Short

		Public SETUP_BAREROD_LOAD As Single

		Public SETUP_MOLDEDGUIDE_LOAD As Single

		Public SETUP_WHEELGUIDE_LOAD As Single

		Public SETUP_OTHERGUIDE_LOAD As Single

		Private m_SETUP_MaxSideLoadLimit As Single = 30F

		Public SETUP_BAREROD_FRICCOEFF As Single

		Public SETUP_MOLDEDGUIDE_FRICCOEFF As Single

		Public SETUP_WHEELGUIDE_FRICCOEFF As Single

		Public SETUP_OTHERGUIDE_FRICCOEFF As Single

		Public SETUP_NorrisStandardGuide_FRICCOEFF As Single

		Private m_SETUP_NorrisSidewinderGuide_FRICCOEFF As Single

		Public SETUP_RGIJakeCouplingGuide_FRICCOEFF As Single

		Public SETUP_RGISVTGuide_FRICCOEFF As Single

		Public SETUP_RGITomahawkGuide_FRICCOEFF As Single

		Public SETUP_RGITornadoGuide_FRICCOEFF As Single

		Public SETUP_RGITwisterGuide_FRICCOEFF As Single

		Public SETUP_RGIWVTGuide_FRICCOEFF As Single

		Public SETUP_MinNumGuidesPerRod As Integer = 3

		Public SETUP_MaxNumGuidesPerRod As Integer = 10

		Public m_SETUP_NumCycles As Integer = 4

		Public SETUP_WeightAdjFactor As Single = 2.5F

		Public fPumpPRWeignt As Single = 1F

		Public Const cERR_INVALID_ERROR As Short = 0S

		Public Const cERR_UNEXPECTED_ERROR As Short = 1S

		Public Const cERR_ANCHOR_TOO_LARGE As Short = 2S

		Public Const cERR_ANCHOR_TOO_LARGE_M As Short = 3S

		Public Const cERR_ANCHOR_TOO_SMALL As Short = 4S

		Public Const cERR_CP_TOO_LARGE As Short = 89S

		Public Const cERR_CP_TOO_LARGE_M As Short = 90S

		Public Const cERR_CP_TOO_SMALL As Short = 91S

		Public Const cERR_CP_TOO_SMALL_M As Short = 92S

		Public Const cERR_DISK_BAD As Short = 93S

		Public Const cERR_DISK_FULL As Short = 94S

		Public Const cERR_DISK_NOT_READY As Short = 95S

		Public Const cERR_DUPLICATE_UNIT_NAME As Short = 96S

		Public Const cERR_ELEC_COST_TOO_LARGE As Short = 97S

		Public Const cERR_ELEC_COST_TOO_SMALL As Short = 98S

		Public Const cERR_EMPTY_IMPORT As Short = 99S

		Public Const cERR_ENHANCED_OFFSET As Short = 100S

		Public Const cERR_FGSTRING_NO_STEEL As Short = 101S

		Public Const cERR_FILE_WRITE_PROTECTED As Short = 102S

		Public Const cERR_FLUID_LEVEL_TOO_LARGE As Short = 103S

		Public Const cERR_FLUID_LEVEL_TOO_LARGE_IPR As Short = 104S

		Public Const cERR_FLUID_LEVEL_TOO_SMALL As Short = 105S

		Public Const cERR_IPRPIP_TOO_SMALL As Short = 106S

		Public Const cERR_IPRPIP_TOO_LARGE As Short = 107S

		Public Const cERR_IPRPROD_TOO_SMALL As Short = 108S

		Public Const cERR_IPRPWF_TOO_SMALL As Short = 109S

		Public Const cERR_IPRPWF_TOO_LARGE As Short = 110S

		Public Const cERR_MARKII_OFFSET As Short = 111S

		Public Const cERR_MAX_LOAD_TOO_LARGE As Short = 112S

		Public Const cERR_MAX_LOAD_TOO_SMALL As Short = 113S

		Public Const cERR_NEW_RODSTAR_NEEDED As Short = 114S

		Public Const cERR_NO_FILE_LOADED As Short = 115S

		Public Const cERR_NO_PROGRAM_FOUND As Short = 116S

		Public Const cERR_NO_SENTINEL_FOUND As Short = 117S

		Public Const cERR_NOT_CBALANCE_FILE As Short = 118S

		Public Const cERR_NOT_RODDIAG_FILE As Short = 119S

		Public Const cERR_NOT_RODSTAR_FILE As Short = 120S

		Public Const cERR_NOT_XDIAG_FILE As Short = 121S

		Public Const cERR_OLD_CBALANCE_FILE As Short = 122S

		Public Const cERR_PIP_TOO_LARGE As Short = 123S

		Public Const cERR_PIP_TOO_LARGE_IPR As Short = 124S

		Public Const cERR_PIP_TOO_SMALL As Short = 125S

		Public Const cERR_PUMP_FRIC_TOO_LARGE As Short = 126S

		Public Const cERR_PUMP_FRIC_TOO_LARGE_M As Short = 127S

		Public Const cERR_PUMP_FRIC_TOO_SMALL As Short = 128S

		Public Const cERR_ROD_STRING_TOO_LONG As Short = 129S

		Public Const cERR_ROD_STRING_TOO_LONG_M As Short = 130S

		Public Const cERR_ROD_STRING_TOO_SHORT As Short = 131S

		Public Const cERR_ROD_STRING_TOO_SHORT_M As Short = 132S

		Public Const cERR_RUNTIME_TOO_LARGE As Short = 133S

		Public Const cERR_RUNTIME_TOO_SMALL As Short = 134S

		Public Const cERR_SBLENGTH_TOO_LARGE As Short = 135S

		Public Const cERR_SBLENGTH_TOO_LARGE_M As Short = 136S

		Public Const cERR_SBLENGTH_TOO_SMALL As Short = 137S

		Public Const cERR_SENTINEL_EXPIRED As Short = 138S

		Public Const cERR_STROKE_TOO_SMALL As Short = 139S

		Public Const cERR_SUCKER_ROD_TOO_LONG As Short = 140S

		Public Const cERR_SUCKER_ROD_TOO_LONG_M As Short = 141S

		Public Const cERR_SUCKER_ROD_TOO_SHORT As Short = 142S

		Public Const cERR_SUCKER_ROD_TOO_SHORT_M As Short = 143S

		Public Const cERR_TARGET_PROD_TOO_LARGE As Short = 144S

		Public Const cERR_TARGET_PROD_TOO_LARGE_M As Short = 145S

		Public Const cERR_TARGET_PROD_TOO_LARGE_IPR As Short = 146S

		Public Const cERR_TARGET_PROD_TOO_SMALL As Short = 147S

		Public Const cERR_TARGET_PROD_TOO_SMALL_MEM As Short = 148S

		Public Const cERR_TARGET_PROD_TOO_SMALL_WMEM As Short = 149S

		Public Const cERR_TOO_MANY_PROGRAMS As Short = 150S

		Public Const cERR_TP_TOO_LARGE As Short = 151S

		Public Const cERR_TP_TOO_LARGE_M As Short = 152S

		Public Const cERR_TP_TOO_SMALL As Short = 153S

		Public Const cERR_WATERCUT_TOO_LARGE As Short = 154S

		Public Const cERR_WATERCUT_TOO_SMALL As Short = 155S

		Public Const cERR_DATA_NOT_STORED As Integer = 83

		Public Const cERR_DISK_WRITE_PROTECTED As Integer = 87

		Public Const cERR_EMPTY_IMPORT_RDW As Integer = 91

		Public Const cERR_EMPTY_IMPORT_XDW As Integer = 92

		Public Const cERR_INSUFFICIENT_MEMORY As Integer = 97

		Public Const cERR_IPR_DATA_DUPLICATED As Integer = 98

		Public Const cERR_IPR_DATA_INCONSISTENT As Integer = 99

		Public Const cERR_KNOWN_LOAD_TOO_SMALL As Integer = 105

		Public Const cERR_NEED_ONE_TEST_POINT As Integer = 107

		Public Const cERR_NEGATIVE_CBANGLE As Integer = 108

		Public Const cERR_NETWORK_SENTINEL_NEEDED As Integer = 109

		Public Const cERR_NEW_XDIAG_NEEDED As Integer = 110

		Public Const cERR_NO_CBE_INFORMATION As Integer = 111

		Public Const cERR_NON_NETWORK_SENTINEL_NEEDED As Integer = 115

		Public Const cERR_NOT_DELTAX_FILE As Integer = 117

		Public Const cERR_NOT_DYNA_FILE As Integer = 118

		Public Const cERR_NOT_NABLA_FILE As Integer = 119

		Public Const cERR_PATH_NOT_FOUND As Integer = 123

		Public Const cERR_PRODUCTION_TOO_LARGE As Integer = 127

		Public Const cERR_PRODUCTION_TOO_LARGE_M As Integer = 128

		Public Const cERR_PRODUCTION_TOO_SMALL As Integer = 129

		Public Const cERR_SYSTEM_CRASHED As Integer = 137

		Public Const cERR_TABLET_NOT_RESPONDING As Integer = 138

		Public Const cERR_TOO_FEW_POINTS As Integer = 139

		Public Const cERR_TOO_MANY_BATCH_FILES As Integer = 140

		Public Const cERR_TOO_MANY_POINTS As Integer = 141

		Public Const cERR_BAD_AIR_TANK_PRESS As Integer = 5

		Public Const cERR_BAD_AIR_TANK_PRESS_M As Integer = 6

		Public Const cERR_BAD_ARTINERT As Integer = 7

		Public Const cERR_BAD_ARTINERT_M As Integer = 8

		Public Const cERR_BAD_BUBBLE_POINT As Integer = 9

		Public Const cERR_BAD_BUBBLE_POINT_M As Integer = 10

		Public Const cERR_BAD_CBMOMENT As Integer = 11

		Public Const cERR_BAD_CBMOMENT_M As Integer = 12

		Public Const cERR_BAD_CBWEIGHT As Integer = 13

		Public Const cERR_BAD_CBWEIGHT_M As Integer = 14

		Public Const cERR_BAD_CBWEIGHT_ROTA As Integer = 15

		Public Const cERR_BAD_CBWEIGHT_ROTA_M As Integer = 16

		Public Const cERR_BAD_CRANK_OFFSET As Integer = 17

		Public Const cERR_BAD_DDRATIO As Integer = 18

		Public Const cERR_BAD_ELASTICITY As Integer = 19

		Public Const cERR_BAD_ELASTICITY_M As Integer = 20

		Public Const cERR_BAD_FC_INDEX As Integer = 21

		Public Const cERR_BAD_FETKOVICH_N As Integer = 22

		Public Const cERR_BAD_FRICTION As Integer = 23

		Public Const cERR_BAD_GEARBOX_RATING As Integer = 24

		Public Const cERR_BAD_GEARBOX_RATING_M As Integer = 25

		Public Const cERR_BAD_IPR_PRESSURE As Integer = 26

		Public Const cERR_BAD_MARKII_UNBALANCE As Integer = 27

		Public Const cERR_BAD_MAX_STROKE As Integer = 28

		Public Const cERR_BAD_MAX_STROKE_M As Integer = 29

		Public Const cERR_BAD_MID_PERF_DEPTH As Integer = 30

		Public Const cERR_BAD_MID_PERF_DEPTH_M As Integer = 31

		Public Const cERR_BAD_MOTOR_SPV As Integer = 32

		Public Const cERR_BAD_OD_ID As Integer = 33

		Public Const cERR_BAD_OD_ID_M As Integer = 34

		Public Const cERR_BAD_OIL_GRAVITY As Integer = 35

		Public Const cERR_BAD_OIL_GRAVITY_M As Integer = 36

		Public Const cERR_BAD_PITMAN_LENGTH As Integer = 37

		Public Const cERR_BAD_PITMAN_LENGTH_M As Integer = 38

		Public Const cERR_BAD_PLUNGER_SIZE As Integer = 39

		Public Const cERR_BAD_PLUNGER_SIZE_M As Integer = 40

		Public Const cERR_BAD_PUMP_DEPTH As Integer = 41

		Public Const cERR_BAD_PUMP_DEPTH_M As Integer = 42

		Public Const cERR_BAD_PUMP_EFFICIENCY As Integer = 43

		Public Const cERR_BAD_PUMP_FILLAGE As Integer = 44

		Public Const cERR_BAD_PUMP_LOAD_ADJUSTMENT As Integer = 45

		Public Const cERR_BAD_PUMP_LOAD_ADJUSTMENT_M As Integer = 46

		Public Const cERR_BAD_ROD_DIAMETER As Integer = 47

		Public Const cERR_BAD_ROD_DIAMETER_M As Integer = 48

		Public Const cERR_BAD_ROD_LENGTH As Integer = 49

		Public Const cERR_BAD_ROD_LENGTH_M As Integer = 50

		Public Const cERR_BAD_ROD_TYPE As Integer = 51

		Public Const cERR_BAD_ROD_WEIGHT As Integer = 52

		Public Const cERR_BAD_ROD_WEIGHT_M As Integer = 53

		Public Const cERR_BAD_ROTINERT As Integer = 54

		Public Const cERR_BAD_ROTINERT_M As Integer = 55

		Public Const cERR_BAD_RSEXTRACOST As Integer = 56

		Public Const cERR_BAD_SBDIAM As Integer = 57

		Public Const cERR_BAD_SBDIAM_M As Integer = 58

		Public Const cERR_BAD_SBLENGTH As Integer = 59

		Public Const cERR_BAD_SBLENGTH_M As Integer = 60

		Public Const cERR_BAD_SERVICE_FACTOR As Integer = 61

		Public Const cERR_BAD_SINKERBAR_GRADE As Integer = 62

		Public Const cERR_BAD_SPDIAMETER As Integer = 63

		Public Const cERR_BAD_SPDIAMETER_M As Integer = 64

		Public Const cERR_BAD_SPDISTANCE As Integer = 65

		Public Const cERR_BAD_SPDISTANCE_M As Integer = 66

		Public Const cERR_BAD_SPGR As Integer = 67

		Public Const cERR_BAD_SPM As Integer = 68

		Public Const cERR_BAD_SPM_MEM As Integer = 69

		Public Const cERR_BAD_SPM_WMEM As Integer = 70

		Public Const cERR_BAD_STATIC_BH_PRESSURE As Integer = 71

		Public Const cERR_BAD_STATIC_BH_PRESSURE_M As Integer = 72

		Public Const cERR_BAD_STRUCT_RATING As Integer = 73

		Public Const cERR_BAD_STRUCT_RATING_M As Integer = 74

		Public Const cERR_BAD_STUFFING_BOX_FRICTION As Integer = 75

		Public Const cERR_BAD_STUFFING_BOX_FRICTION_M As Integer = 76

		Public Const cERR_BAD_TARGET_PROD As Integer = 77

		Public Const cERR_BAD_TENSILESTRENGTH As Integer = 78

		Public Const cERR_BAD_TENSILESTRENGTH_M As Integer = 79

		Public Const cERR_BAD_TUBING_ID As Integer = 80

		Public Const cERR_BAD_TUBING_ID_M As Integer = 81

		Public Const cERR_BAD_TUBING_OD As Integer = 82

		Public Const cERR_BAD_TUBING_OD_M As Integer = 83

		Public Const cERR_BAD_UNBALANCE As Integer = 84

		Public Const cERR_BAD_UNBALANCE_M As Integer = 85

		Public Const cERR_BAD_UNIT_DIMENSION As Integer = 86

		Public Const cERR_BAD_UNIT_ID As Integer = 87

		Public Const cERR_BAD_WATERSPGR As Integer = 88

		Public Const cMSG_BAD_F0SKR_FG As Short = 156S

		Public Const cMSG_BAD_F0SKR_STEEL As Short = 157S

		Public Const cMSG_BAD_F0SKR_STEEL_BATCH As Short = 158S

		Public Const cMSG_BAD_FGSTRING As Short = 159S

		Public Const cMSG_FG_ALMOST_IN_COMPRESSION As Short = 160S

		Public Const cMSG_FG_ALMOST_IN_COMPRESSION_M As Short = 161S

		Public Const cMSG_FG_IN_COMPRESSION As Short = 162S

		Public Const cMSG_FG_IN_COMPRESSION_M As Short = 163S

		Public Const cMSG_FLUID_VELOCITY_1 As Short = 164S

		Public Const cMSG_FLUID_VELOCITY_2 As Short = 165S

		Public Const cMSG_FOURTH_CRANK_HOLE As Short = 166S

		Public Const cMSG_HIGH_F0SKR As Short = 167S

		Public Const cMSG_HIGH_PUMP_INTAKE_PRESSURE As Short = 168S

		Public Const cMSG_HIGH_SPM_BATCH As Short = 169S

		Public Const cMSG_HIGH_SPM_ROTA As Short = 170S

		Public Const cMSG_HIGH_SPM_RSWIN As Short = 171S

		Public Const cMSG_HIGH_TARGET_BFPD As Short = 172S

		Public Const cMSG_HIGH_TARGET_BFPD_M As Short = 173S

		Public Const cMSG_HIGH_TARGET_BFPD_BATCH As Short = 174S

		Public Const cMSG_HIGH_TARGET_BFPD_BATCH_M As Short = 175S

		Public Const cMSG_LOW_F0SKR_FG As Short = 176S

		Public Const cMSG_LOW_PUMP_EFFICIENCY As Short = 177S

		Public Const cMSG_LOW_PUMP_FILLAGE_1 As Short = 178S

		Public Const cMSG_LOW_PUMP_FILLAGE_2 As Short = 179S

		Public Const cMSG_LOW_PUMP_FILLAGE_3 As Short = 180S

		Public Const cMSG_LOW_PUMP_INTAKE_PRESSURE As Short = 181S

		Public Const cMSG_LOW_PUMP_INTAKE_PRESSURE_M As Short = 182S

		Public Const cMSG_LOW_SPM As Short = 183S

		Public Const cMSG_LOW_TARGET_BFPD As Short = 184S

		Public Const cMSG_LOW_TARGET_BFPD_BATCH As Short = 185S

		Public Const cMSG_MPRL_LOW As Short = 186S

		Public Const cMSG_MPRL_NEGATIVE As Short = 187S

		Public Const cMSG_NEED_FLUID_INERTIA As Short = 188S

		Public Const cMSG_NEED_UHS_MOTOR As Short = 189S

		Public Const cMSG_NEMA_D_TOO_SMALL_B As Short = 190S

		Public Const cMSG_NEMA_D_TOO_SMALL_B_BATCH As Short = 191S

		Public Const cMSG_NEMA_D_TOO_SMALL_E As Short = 192S

		Public Const cMSG_NEMA_D_TOO_SMALL_E_BATCH As Short = 193S

		Public Const cMSG_NEMA_D_VERY_SMALL As Short = 194S

		Public Const cMSG_NEMA_D_VERY_SMALL_BATCH As Short = 195S

		Public Const cMSG_OVERLOADED_FGROD_1 As Short = 196S

		Public Const cMSG_OVERLOADED_FGROD_2 As Short = 197S

		Public Const cMSG_OVERLOADED_FGROD_3 As Short = 198S

		Public Const cMSG_PUFILE_NOT_FOUND As Short = 199S

		Public Const cMSG_RR_ALMOST_IN_COMPRESSION As Short = 200S

		Public Const cMSG_RR_ALMOST_IN_COMPRESSION_M As Short = 201S

		Public Const cMSG_RR_IN_COMPRESSION As Short = 202S

		Public Const cMSG_RR_IN_COMPRESSION_M As Short = 203S

		Public Const cMSG_RSMINSIZE_TOO_SMALL As Short = 204S

		Public Const cMSG_UNDERSIZED_NEMA_C As Short = 205S

		Public Const cMSG_UNDERSIZED_UHS_MOTOR As Short = 206S

		Public Const cMSG_UNDERSIZED_UHS_MOTOR_B As Short = 207S

		Public Const cMSG_VERY_HIGH_SPM As Short = 208S

		Public Const cMSG_VERY_HIGH_SPM_BATCH As Short = 209S

		Public Const cMSG_VERY_HIGH_SPM_ROTA As Short = 210S

		Public Const cMSG_VERY_HIGH_SPM_ROTA_BATCH As Short = 211S

		Public Const cWARN_FETKOVICH_N As Short = 212S

		Public Const cWARN_ROD_AVAILABILITY As Short = 213S

		Public Const cWARN_UHS_AIRBALANCED As Short = 214S

		Public Const cWARN_UHS_LONGSTROKE As Short = 215S

		Public Const cINFO_ANCHOR_DEPTH As Short = 216S

		Public Const cINFO_CALC_FETKOVICH_N As Short = 217S

		Public Const cINFO_CALC_IROT As Short = 218S

		Public Const cINFO_CALC_MOTOR_SPV As Short = 219S

		Public Const cINFO_CALC_PLUNGER_SIZE As Short = 220S

		Public Const cINFO_CALCBFPD_PCCALC As Short = 221S

		Public Const cINFO_CALCBFPD_PCFL As Short = 222S

		Public Const cINFO_CALCBFPD_PICALC As Short = 223S

		Public Const cINFO_CUSTOM_PUDB As Short = 224S

		Public Const cINFO_FETKOVICH_N As Short = 225S

		Public Const cINFO_FG_LENGTH As Short = 226S

		Public Const cINFO_FG_MAXSTEEL As Short = 227S

		Public Const cINFO_FG_MINSTEEL As Short = 228S

		Public Const cINFO_FG_STEEL As Short = 229S

		Public Const cINFO_FG_SB As Short = 230S

		Public Const cINFO_FG_SBDIAM As Short = 231S

		Public Const cINFO_FG_SBDIAM_OTHER As Short = 232S

		Public Const cINFO_FG_SBLEN As Short = 233S

		Public Const cINFO_FLPIP As Short = 234S

		Public Const cINFO_FLUID_COMPRESSIBILITY As Short = 235S

		Public Const cINFO_FLUID_INERTIA_GAS_INTERF As Short = 236S

		Public Const cINFO_FLUID_INERTIA As Short = 237S

		Public Const cINFO_FLUID_INERTIA_M As Short = 238S

		Public Const cINFO_FLUID_LEVEL_PCCALC As Short = 239S

		Public Const cINFO_FLUID_LEVEL_PCFL As Short = 240S

		Public Const cINFO_FRICTION As Short = 241S

		Public Const cINFO_IART As Short = 242S

		Public Const cINFO_INCLUDE_SPV_AIRBALANCED As Short = 243S

		Public Const cINFO_INCLUDE_SPV_LONGSTROKE As Short = 244S

		Public Const cINFO_IPRPLOT As Short = 245S

		Public Const cINFO_IROT As Short = 246S

		Public Const cINFO_MOTOR_SIZE As Short = 247S

		Public Const cINFO_MOTOR_SPV As Short = 248S

		Public Const cINFO_MCM As Short = 249S

		Public Const cINFO_PEFF As Short = 250S

		Public Const cINFO_PFILL As Short = 251S

		Public Const cINFO_PICALC As Short = 252S

		Public Const cINFO_PINTAKE_PCCALC As Short = 253S

		Public Const cINFO_PINTAKE_PCFL As Short = 254S

		Public Const cINFO_PLUNGER_SIZE As Short = 255S

		Public Const cINFO_PLUNGER_SIZE_LIST As Short = 256S

		Public Const cINFO_ROTATION_FIXED_CW As Short = 257S

		Public Const cINFO_ROTATION_FIXED_CCW As Short = 258S

		Public Const cINFO_ROTATION_SELECT_UNIT As Short = 259S

		Public Const cINFO_SIZE_RECOMMENDATION As Short = 260S

		Public Const cINFO_SPM_PCCALC As Short = 261S

		Public Const cINFO_SPM_PCFL As Short = 262S

		Public Const cINFO_SPM_PICALC As Short = 263S

		Public Const cINFO_SPMBFPD As Short = 264S

		Public Const cINFO_STEEL_SB As Short = 265S

		Public Const cINFO_STEEL_SBDIAM As Short = 266S

		Public Const cINFO_STEEL_SBDIAM_OTHER As Short = 267S

		Public Const cINFO_STEEL_SBLEN As Short = 268S

		Public Const cINFO_TARGETBFPD_PCCALC As Short = 269S

		Public Const cINFO_TARGETBFPD_PCFL As Short = 270S

		Public Const cINFO_TARGETBFPD_PICALC As Short = 271S

		Public Const cINFO_TORQUE_MODE As Short = 272S

		Public Const cINFO_TUBING_ID As Short = 273S

		Public Const cINFO_TUBING_OD As Short = 274S

		Public Const cINFO_UNBALANCE As Short = 275S

		Public Const cINFO_TARGET_PROD_TOO_SMALL As Short = 276S

		Public Const cERR_BAD_STRUCT_RATING_LONGSTROKE As Short = 277S

		Public Const cERR_BAD_PR_DIAMETER_FRICTION As Integer = 278

		Public Const cERR_BAD_PR_DIAMETER_FRICTION_M As Integer = 279

		Public Const cMSG_BAD_DIG_CBANGLE_CR As Integer = 148

		Public Const cMSG_BAD_DYNA_CBANGLE As Integer = 149

		Public Const cMSG_BAD_DYNA_CBANGLE_CR As Integer = 150

		Public Const cMSG_CUSTPUDB_IN_USE As Integer = 151

		Public Const cMSG_CUSTPUDB_INVALID As Integer = 152

		Public Const cMSG_CUSTPUDB_NOT_CREATED As Integer = 153

		Public Const cMSG_DATA_FILE_NOT_CREATED As Integer = 154

		Public Const cMSG_DATA_IN_PROGRESS As Integer = 155

		Public Const cMSG_DATA_IN_PROGRESS_DONE As Integer = 156

		Public Const cMSG_DYNA_STROKE_BAD As Integer = 157

		Public Const cMSG_DYNA_STROKE_BAD_BATCH As Integer = 158

		Public Const cMSG_DYNA_STROKE_BAD_NOFIX As Integer = 159

		Public Const cMSG_DYNA_STROKE_NOCR As Integer = 160

		Public Const cMSG_DYNA_STROKE_NOCR_BATCH As Integer = 161

		Public Const cMSG_DYNA_STROKE_NOCR_NOFIX As Integer = 162

		Public Const cMSG_FG_NO_STEEL As Integer = 163

		Public Const cMSG_FG_NO_STEEL_WIN As Integer = 164

		Public Const cMSG_IF_NO_PITMAN_ARM As Integer = 167

		Public Const cMSG_INPUT_FILE_INVALID As Integer = 168

		Public Const cMSG_OUT_OF_MEMORY As Integer = 181

		Public Const cMSG_SETUP_NOT_SAVED As Integer = 183

		Public Const cMSG_UNDERSIZED_MOTOR As Integer = 184

		Public Const cMSG_UNDERSIZED_NEMA_D As Integer = 186

		Public Const cMSG_UNDERSIZED_NEMA_D_BATCH As Integer = 187

		Public Const cMSG_UNFINISHED_DATA As Integer = 190

		Public Const cWARN_PRINT_FILE As Integer = 192

		Public Const cINFO_CBE_NOT_DIGITIZED As Integer = 195

		Public Const cINFO_CBE_NOT_IN_FILE As Integer = 196

		Public Const cINFO_CUSTOM_PUDB_NO_IDS As Integer = 198

		Public sDefaultBatchFolder As String

		Public gSysDiag As RSWIN_DESC.SYSTEMDIAGNOSIS

		Public IsRodStar As Boolean = True

		Private m_sNull As String = ""

		Public FormFieldIndex As Integer

		Public WarnedAboutBFPD As Short

		Public WarnedAboutFluidInertia As Short

		Public WarnedAboutFoSkr As Short

		Public WarnedAboutLowSPM As Short

		Public WarnedAboutHighSPM As Short

		Public WarnedAboutLowPumpEfficiency As Short

		Public WarnedAboutLowPumpFillage As Short

		Public WarnedAboutPlungerSize As Short

		Public WarnedAboutLargeNtsteps As Short

		Public WarnedAboutUHSMotor As Short

		Public Const MAXIPRTESTPOINTS As Integer = 10

		Public ScrnNum As Integer

		Public FldNum As Integer

		Public iEntryNum As Short

		Public iEntryInterval As Short

		Public AllGuruFiles As RSWIN_DESC.GuruFileDataStructure() = New RSWIN_DESC.GuruFileDataStructure(7500) {}

		Public AIFilePreferences As RSWIN_DESC.AIFilePreferencesStructure

		Private m_iAddedTemplates As Integer

		Private m_iGuruFileCount As Integer

		Private m_GuruDataBaseFileName As String = RSWIN_DESC.sTemplateDBFileName

		Private m_BlankGuruDataBaseFileName As String = "blank_db_templates.mdb"

		Private m_BlankGuruDataBaseFileNameEn As String = "blank_db_templates_en.mdb"

		Public Impred_r_e As RSWIN_DESC.r_e_structure()

		Public num_survey_points As Integer

		Public Impred_s_p As RSWIN_DESC.s_p_structure()

		Public Const NAfmt As String = "#""N/A"""

		Public SzENGLISH As String = "e"

		Public SzMETRIC As String = "m"

		Public sNA As String = Util.AssignValueToConstant("RSWIN_DESC", "NA", "")

		Public bfpd As String = Util.AssignValueToConstant("RSWIN_DESC", "bfpd", "")

		Public bopd As String = Util.AssignValueToConstant("RSWIN_DESC", "bopd", "")

		Public bpd As String = Util.AssignValueToConstant("RSWIN_DESC", "BPD", "")

		Public cm As String = Util.AssignValueToConstant("RSWIN_DESC", "cm", "")

		Public cm2 As String = Util.AssignValueToConstant("RSWIN_DESC", "cm²", "")

		Public cm3 As String = Util.AssignValueToConstant("RSWIN_DESC", "cm³", "")

		Public feet As String = Util.AssignValueToConstant("RSWIN_DESC", "feet", "")

		Public ft As String = Util.AssignValueToConstant("RSWIN_DESC", "ft", "")

		Public kgm As String = Util.AssignValueToConstant("RSWIN_DESC", "kgm", "kg/m")

		Public inch As String = Util.AssignValueToConstant("RSWIN_DESC", "inch", "in")

		Public inch2 As String = Util.AssignValueToConstant("RSWIN_DESC", "inch2", "in²")

		Public inch3 As String = Util.AssignValueToConstant("RSWIN_DESC", "inch3", "in³")

		Public ins As String = Util.AssignValueToConstant("RSWIN_DESC", "ins", "")

		Public inches As String = Util.AssignValueToConstant("RSWIN_DESC", "inches", "")

		Public m As String = Util.AssignValueToConstant("RSWIN_DESC", "m", "")

		Public kPa As String = Util.AssignValueToConstant("RSWIN_DESC", "kPa", "")

		Public lbft As String = Util.AssignValueToConstant("RSWIN_DESC", "lbft", "lb/ft")

		Public lbs As String = Util.AssignValueToConstant("RSWIN_DESC", "lbs", "")

		Public m3D As String = Util.AssignValueToConstant("RSWIN_DESC", "m3D", "m³/D")

		Public meters As String = Util.AssignValueToConstant("RSWIN_DESC", "meters", "")

		Public Minlbs As String = Util.AssignValueToConstant("RSWIN_DESC", "Minlbs", "M in-lbs")

		Public Mlbs As String = Util.AssignValueToConstant("RSWIN_DESC", "Mlbs", "M lbs")

		Public mm As String = Util.AssignValueToConstant("RSWIN_DESC", "mm", "")

		Public N As String = Util.AssignValueToConstant("RSWIN_DESC", "N", "")

		Public x100lbs As String = Util.AssignValueToConstant("RSWIN_DESC", "x100lbs", "x100 lbs")

		Public Nm As String = Util.AssignValueToConstant("RSWIN_DESC", "Nm", "N-m")

		Public psi As String = Util.AssignValueToConstant("RSWIN_DESC", "psi", "")

		Public psig As String = Util.AssignValueToConstant("RSWIN_DESC", "psig", "")

		Public bbl As String = Util.AssignValueToConstant("RSWIN_DESC", "bbl", "bbl.")

		Public m3 As String = Util.AssignValueToConstant("RSWIN_DESC", "m³", "")

		Public MMpsi As String = Util.AssignValueToConstant("RSWIN_DESC", "MMpsi", "")

		Public GPa As String = Util.AssignValueToConstant("RSWIN_DESC", "GPa", "")

		Public sAPI As String = Util.AssignValueToConstant("RSWIN_DESC", "sAPI", "API °")

		Public gcm3 As String = Util.AssignValueToConstant("RSWIN_DESC", "gcm3", "g/cm³")

		Public gravityAPI As String = Util.AssignValueToConstant("RSWIN_DESC", RSWIN_DESC.gravityAPI, "")

		Public densitygcm3 As String = Util.AssignValueToConstant("RSWIN_DESC", RSWIN_DESC.densitygcm3, "")

		Public dollarperft As String = Util.AssignValueToConstant("RSWIN_DESC", "dollarperft", "$/ft")

		Public dollarperM As String = Util.AssignValueToConstant("RSWIN_DESC", "dollarperM", "$/m")

		Public sPleaseWait As String = Util.AssignValueToConstant("RSWIN_DESC", "sPleaseWait", " Please Wait!")

		Public sSnglQuote As String = "'"

		Public sSpecialChars As String = "*?<>|/\:'"""

		Public sSpecialCharsMessages As String = "Please reframe from using special characters (*, ?, <, >, |, /, \, :, ', " + RSWIN_DESC.sDblQuote + ") in the well name. For new cases it is used as default file name."

		Public s_Steel As String = "----------------------Steel--------------------------"

		Public s_SinkerBars As String = "--------------------Sinker bars----------------------"

		Public s_Corod As String = "------------Weatherford Corod-------------------"

		Public s_Fiberglass As String = "--------------------Fiberglass-----------------------"

		Public s_RibbonRod As String = "--------------------Ribbon Rod-----------------------"

		Public s_Prorod As String = "----------------------Prorod-------------------------"

		Private m_SmallestUnitID As String = ""

		Private m_bSmallestUnitGearbox As Boolean = False

		Private m_bSmallestUnitStructL As Boolean = False

		Private m_bUseLandscape As Boolean = False

		Private m_SETUP_bSinkerBar As Boolean = True

		Private m_SETUP_IncludeMotorSPV As Boolean

		Private m_SETUP_PowerMeterType As Short

		Private m_SETUP_bAdminDebug As Boolean = False

		Private m_SETUP_bUseSteelRodsOnly As Boolean

		Private m_SETUP_bUseFGlassWithSteelOnBottom As Boolean

		Private m_SETUP_ElectricityCostPreference As Single

		Private m_SETUP_bRodstarPumpType As Boolean

		Private m_SETUP_UseXRODVTubingSizes As Boolean

		Private m_SETUP_FixTubingSize As Boolean = False

		Private m_SETUP_bRodstarTubingAnchored As Boolean

		Private m_SETUP_bTubingAnchored As Boolean

		Private m_SETUP_bUseAvgRodTBGFricCoeff As Boolean

		Private m_SETUP_TimesAvgRodTBGFricCoeff As Single

		Private m_SETUP_ServiceFactorPreference As Single

		Private m_FGGradeRod As Short

		Private m_HSGradeRod As Short

		Private m_SBGradeRod As Short

		Private m_HSRodType As String

		Private m_FGRodType As String

		Private m_SBRodType As String

		Private m_MaxTubingSizeOD As Single

		Private m_MinTubingSizeOD As Single

		Private m_MaxTubingSizeID As Single

		Private m_MinTubingSizeID As Single

		Private m_MaxCasingSize As Single

		Private m_bUsePUManuf As Boolean() = New Boolean(8) {}

		Private m_PUManuf As String() = New String(8) {}

		Private m_bXRODUseCustomizedLists As Boolean = False

		Private m_bXRODUseGeneralList As Boolean = False

		Private m_bXRODUseClosestUnit As Boolean = False

		Private m_bUsingGeneralList As Boolean = False

		Private m_bUsingClosestUnit As Boolean = False

		Private m_bUsingMatchedUnit As Boolean = False

		Private m_sRecommendedUnit As String = ""

		Private m_bInsertPump As Boolean

		Private m_bTubingPump As Boolean

		Private m_bLargeBorePump As Boolean

		Private m_bDesignSinkerbar As Boolean

		Private m_bUseNNSinkerbar As Boolean

		Private m_i2Score As Integer = 1

		Private m_bShowScoringPage As Boolean = False

		Public bUseLatestGradeChanges As Boolean = True

		Public fDefaultTargetProduction As Single = 0F

		Public bReadingFile As Boolean = False

		Public m_bBalancedEVarsOverwritten As Boolean = False

		Public iOverWriteIndex As Integer

		Private m_bMainClosed As Boolean = False

		Private m_SavedDownstrokeFriction As Single

		Private m_SavedUpstrokeFriction As Single

		Private m_bBeamBalanced As Boolean = False

		Public BeltLowProfileBOS As Single = 1.1868238F

		Public BeltLowProfile180 As Single = 3.1415927F

		Public BeltLowProfileTOS As Single = 4.3284163F

		Public bDoDeviatedInfiniteLoopCheck As Boolean = True

		Public bAllowFG As Boolean = True

		Private m_SETUP_UseAllDiameters As Boolean = False

		Private m_Setup_RodGuideOverlap As Integer

		Private m_Setup_NumRodsPerBundle As Integer

		Public sNoGuidesInFile As String = "There are no rod guides in this file.  If this isn't correct, please add rod guides in the Rod String Information Window."

		Public sMaxFiberodStressWarning_English As String = "When the Fiberod peak rod stress exceeds 27,500 psi, please contact the manufacturer for assistance at 432-267-9800."

		Public sMaxFiberodStressWarning_Meter As String = "When the Fiberod peak rod stress exceeds 189,585 kPa, please contact the manufacturer for assistance at 432-267-9800."

		Public sMinFiberodStressWarning_English As String = "When the Fiberod minimum rod stress is less than 1,250 PSI, please contact the manufacturer for assistance at 432-267-9800."

		Public sMinFiberodStressWarning_Meter As String = "When the Fiberod minimum rod stress is less than 8,618 kPa, please contact the manufacturer for assistance at 432-267-9800."

		Public sMinFibercoStressWarning_English As String = "The minimum stress on the Fiberco rods is less than 1000 psi. This may cause premature failure of the fiberglass rods. To increase the minimum stress, add sinker bars to the rod string or slow down the unit."

		Public sMinFibercoStressWarning_Meter As String = "The minimum stress on the Fiberco rods is less than 6894 kPa. This may cause premature failure of the fiberglass rods. To increase the minimum stress, add sinker bars to the rod string or slow down the unit."

		Public sMaxFibercoStressWarning_English As String = "The maximum stress on the Fiberco rods is greater than or equal to 35,000 psi. This may cause premature failure of the fiberglass rods. Please contact the manufacturer for assistance."

		Public sMaxFibercoStressWarning_Meter As String = "The maximum stress on the Fiberco rods is greater than  or equal to 241,290 kPa. This may cause premature failure of the fiberglass rods. Please contact the manufacturer for assistance."

		Public m_SETUP_UseJohnsFix As Boolean = True

		Private m_SETUP_UseJeffsFix As Boolean = True

		Public m_bSBDiameterChanged As Boolean = False

		Public m_bSteelAboveFGDiameterChanged As Boolean = False

		Public m_SETUP_UseBucklingTendencyStresses As Boolean = True

		Public frn_AI_Admin_log As Short

		Public frn_AI_Run_All_log As Short

		Public sAIAdminLog As String = Application.StartupPath + "\AI-Admin-Log.txt"

		Public sAIRunAllLog As String = Application.StartupPath + "\AI-Run-All-Templates-Log.txt"

		Private m_bRodsInTubingMsgShown As Boolean = False

		Private m_bDoExpertBuoyancyChange As Boolean = True

		Public RLoad_Save As Single(,)

		Private m_bFGUnderTravel As Boolean = False

		Private m_bHaltBatchLoop As Boolean = False

		Private m_sTemplateTotalAIScore As String = ""

		Private m_fTemplateTotalAIScore As Single = 0F

		Private m_bRunAllTemplates As Boolean = False

		Private m_bNewCaseAsked As Boolean = False

		Private m_bHasGuides As Boolean = False

		Public rod_num_guides As Integer() = New Integer(0) {}

		Public rod_num_depths As Single() = New Single(0) {}

		Public rod_sideloads As Single() = New Single(0) {}

		Public rod_suckerrodlength As Single() = New Single(0) {}

		Public Guide_XYZ_indexes As Integer() = New Integer(0) {}

		Private m_rod_numrods As Integer = 0

		Public sCasingSizes As String() = New String(9) {}

		Public gbMaxTrial As Integer = 1

		Public sBitMapAB As String = "air balanced 2.png"

		Public sBitMapBB As String = "beam balanced 2.png"

		Public sBitMapRotoflex As String = "rotoflex 2.png"

		Public sBitMapRM As String = "reverse mark 2.png"

		Public sBitMapMarkII As String = "mark ii 2.png"

		Public sBitMapConv As String = "conv 2.png"

		Public sBitMapBLP As String = "belted low profile 2.png"

		Private m_SETUP_UseDefaultRodElementLimit As Boolean = True

		Private m_SETUP_RodElementLimit As Integer = 200

		Private m_SETUP_MDInt As Single

		Private m_SETUP_DoglegLimit As Single

		Private m_num_rod_elements As Integer

		Private m_sDevPlotFileName As String

		Private m_sAxialPlotFileName As String = ""

		Private m_sBucklingTendencyFileName As String

		Private m_sDoglegsFileName As String

		Private m_sSideForcesFileName As String

		Private m_sSurveyEWFileName As String

		Private m_sSurveyNSFileName As String

		Private m_sSurveyPlanFileName As String

		Private m_sTempDynoPlotFileName As String

		Private m_sTempTorquePlotFileName As String

		Private m_sTempDynoPlotLFileName As String

		Private m_sTempTorquePlotLFileName As String

		Public sPathThetaData As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData"

		Public bAllowRodLimitEntry As Boolean = False

		Public Reliance_Table As String(,) = New String(7, 5) {}

		Public bDoAutoSentinelChecks As Boolean = False

		Private m_SETUP_RECOMMEND_GUIDES As Boolean = False

		Private m_bAllZeroNumGuides As Boolean = False

		Private m_SETUP_ExcelInstalled As Boolean = True

		Public iSumMOLDED As Integer

		Public iSumWHEELED As Integer

		Public iSumOther As Integer

		Public iSumNorrisStandard As Integer

		Public iSumNorrisSidewinder As Integer

		Public iSumRGIJakeCoupling As Integer

		Public iSumRGISVT As Integer

		Public iSumRGITomahawk As Integer

		Public iSumRGITornado As Integer

		Public iSumRGITwister As Integer

		Public iSumRGIWVT As Integer

		Public bGuideSums As Boolean() = New Boolean(11) {}

		Public iGuides As Integer() = New Integer(11) {}

		Public bOverwriteDownstrokeValues As Boolean = True

		Private m_rst_NOFI As cRODSTAR

		Private m_Impred_NOFI As TEImpred

		Public bAllowPumpEffEntry As Boolean = True

		Public fDefaultFricCoeff As Single = 0.22F

		Public fNorrisDefaultFricCoeff As Single = 0.3F

		Public taper_lens As Single() = New Single(40) {}

		Public MaxRecNumGuides As Integer() = New Integer(40) {}

		Public MaxRecNumGuides_2 As Integer() = New Integer(80) {}

		Public GuideFrequencyArray As RSWIN_DESC.GuideFrequencyStructure() = New RSWIN_DESC.GuideFrequencyStructure(40) {}

		Private m_SETUP_UseDefaultDBLocation As Boolean = True

		Private m_SETUP_UseServerDBLocation As Boolean = False

		Private m_SETUP_ServerDBLocation As String = ""

		Public bCheckRodGuideFrequency As Boolean = True

		Public clsGlobal As cGlobal

		Public bParentFormClosing As Boolean = False

		Private m_bPredictiveRunning As Boolean = False

		Public Setup_NumImplIters As Integer = 16

		Private m_bImplementingRodGuides As Boolean = False

		Private m_bSinkerBarDepthChanged As Boolean = False

		Private m_Setup_bAlterSBPumpDepth As Short = -1S

		Private m_Setup_fInclinationLimit As Single = 4F

		Private m_fNewSinkerbarDepth As Single = 0F

		Private m_fNewTaperLength As Single = 0F

		Private m_fSBMaxLength As Single = 0F

		Public Const iOriginal As Integer = 0

		Public Const iPrevious As Integer = 1

		Public Const iCurrent As Integer = 2

		Public saved_rst As cRODSTAR() = New cRODSTAR(2) {}

		Public saved_Impred As TEImpred() = New TEImpred(2) {}

		Public saved_rod_designs As RSWIN_DESC.previous_rod_design_type() = New RSWIN_DESC.previous_rod_design_type(2) {}

		Public saved_num_rods As Integer() = New Integer(2) {}

		Public SaveSections As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(40) {}

		Public SaveRodStringType As Short

		Public bConsiderSideLoadPerGuide As Boolean = True

		Public iCurrentRodNum As Integer

		Public iBundleIncr As Integer

		Public Const iRGIMinGuide As Integer = 3

		Public Const iNorrisMinGuide As Integer = 4

		Public iMinGuide As Integer = 3

		Public iMaxGuide As Integer = 6

		Public iAbsoluteMinGuide As Integer = 3

		Public iAbsoluteMaxGuide As Integer = 12

		Private m_bDisplayingBatchOutput As Boolean = False

		Private m_bReduceFricCoeff As Boolean = False

		Public sReduceMsg As String = "It is recommended that rod and tubing friction coefficients are reduced by half when using Polylined tubing. Would you like RODSTAR to do this for you?"

		Public sReduceMsg2 As String = "The Rod-tubing coefficients have been reduced by half due to the use of Polylined tubing."

		Public sSBRelocateFootnote As String = "NOTE: Sinker bars should not be placed where the inclination is more than 4 degrees."

		Public bRestartImplementation As Boolean = False

		Public sAreYouSure As String = " Are you sure?"

		Public sFlexMsg As String = " Using more may cause rods to not be able to flex."

		Public sZeroMinGuidesNotAllowed As Object = " The minimum number of guides per rod must be greater than zero."

		Public sGenericGuideMaxWarning As String = "It is recommended that a maximum number of guides per rod is {0}. "

		Public sManufacturerGuideMaxWarning As String = "The rod guide manufacturer recommends a maximum of {0} guides per rod. "

		Public sGenericGuideMinWarning As String = "It is recommended that a minimum number of guides per rod is {0}. "

		Public sManufacturerGuideMinWarning As String = "The rod guide manufacturer recommends a minimum of {0} guides per rod. "

		Public sOneMinusRecommended As String = "The manufacturer recommends a minimum of {0} guides per rod. RODSTAR allows you to select a minimum of {1}. A lower number is not allowed"

		Public sGenericGuideMinMaxWarning As String = "It is recommended that a minimum number of guides per rod is {0} and a maximum number of guides per rod is {1}. "

		Public sManufacturerGuideMinMaxWarning As String = "The rod guide manufacturer recommends a minimum of {0} guides per rod and a maximum of {1} guides per rod. "

		Public sMaxMustBeGreaterThanMin As String = "The maximum number of rod guides must be greater than the minimum number of rod guides."

		Public sMinMustBeLessThanMax As String = "The minimum number of rod guides must be less than the maximum number of rod guides."

		Public sInclinationLimit As String = "Inclination for sinkerbar relocation must be between 4° and 50°."

		Public sIncorrectFluidLevel As String = "The fluid level entered corresponds to a pump intake pressure that is too high for the pump depth you specified. Please check the fluid level entered."

		Public sRunDidNotComplete As String = "Run did not complete successfully. "

		Public Structure GuruFileDataStructure
			Public Sub Initialize()
				Me.WellName = New String(" "c, 40)
			End Sub

			Public FileName As String

			Public WellName As String

			Public gbCalcPumpCondition As Boolean

			Public PumpCondition As Short

			Public IrotEntered As Boolean

			Public CalcPlungerSize As Boolean

			Public gbCalcPumpIntakePressure As Boolean

			Public CasingPressure As Single

			Public CompressibilityIndex As Single

			Public ElectricityCost As Single

			Public FluidDamping As Single

			Public FluidLevel As Single

			Public gbIncludeBuoyancy As Boolean

			Public IncludeFluidInertia As Short

			Public Iart As Single

			Public Irot As Single

			Public UnknownM As Boolean

			Public M_Existing As Single

			Public CBEffect As Single

			Public CBAngle As Single

			Public CBDataType As Short

			Public CalcMotorSize As Boolean

			Public IncludeMotorSPV As Boolean

			Public MotorSPV As Single

			Public OilAPI As Single

			Public PlungerSize As Single

			Public PowerMeterType As Short

			Public PumpDepth As Single

			Public PumpEfficiency As Single

			Public PumpFillage As Single

			Public PumpFriction As Single

			Public PumpIntakePressure As Single

			Public PumpLoadAdj As Single

			Public PumpType As Short

			Public SPM As Single

			Public CalcFriction As Boolean

			Public DownstrokeFriction As Single

			Public UpstrokeFriction As Single

			Public XTimes As Single

			Public Runtime As Single

			Public StuffingBoxFriction As Single

			Public TargetBFPD As Single

			Public TubingAnchorDepth As Single

			Public TubingAnchored As Short

			Public TubingID As Single

			Public TubingOD As Single

			Public TubingPressure As Single

			Public WaterCut As Single

			Public WaterSPGR As Single

			Public RodStringType As Short

			Public giRodDesignStyle As Short

			Public RSFGIncludeSteel As Short

			Public RSGrade As Short

			Public RSMaxSize As Single

			Public RSMinSize As Single

			Public RSFricCoef As Single

			Public RSIncludeSB As Short

			Public SinkerBar_Grade As Short

			Public SinkerBar_length As Single

			Public SinkerBar_Diameter As Single

			Public RSFGGrade As Short

			Public RSExtraCost As Single

			Public RSExtraCostLabel As String

			Public SlideFricCoeff As Single

			Public ServiceFactor As Single

			Public PU_CrankRotation As Short

			Public PU_CrankHole As Short

			Public Unbalance As Single

			Public Unit As String

			Public ID As String

			Public DateAdded As DateTime

			Public Original As Short
		End Structure

		Public Structure AIFilePreferencesStructure
			Public Sub Initialize()
				Me.bUsePUManuf = New Boolean(8) {}
				Me.PUManuf = New String(8) {}
				Dim num As Integer = 1
				Do
					Me.bUsePUManuf(num) = False
					Me.PUManuf(num) = ""
					num += 1
				Loop While num <= 8
				Me.bUseXRODVTubingSizes = True
				Me.bFixTubingSize = False
				Me.fTubingSizeOD = 0F
				Me.fCasingSize = 0F
			End Sub

			Public FGGradeRod As Short

			Public FGRodType As String

			Public HSGradeRod As Short

			Public HSRodType As String

			Public SBGradeRod As Short

			Public SBRodType As String

			Public bXRODUseCustomizedLists As Boolean

			Public bXRODUseGeneralList As Boolean

			Public bXRODUseClosestUnit As Boolean

			Public bUseXRODVTubingSizes As Boolean

			Public fTubingSizeOD As Single

			Public fCasingSize As Single

			Public bFixTubingSize As Boolean

			Public bUseSteelRodsOnly As Boolean

			Public bUseFGlassWithSteelOnBottom As Boolean

			Public bUseAvgRodTBGFricCoeff As Boolean

			Public TimesAvgRodTBGFricCoeff As Single

			Public ServiceFactorPreference As Single

			Public PowerMeterType As Short

			Public IncludeMotorSPV As Boolean

			Public bUsePUManuf As Boolean()

			Public PUManuf As String()

			Public ElectricityCostPreference As Single
		End Structure

		Public Structure CustomRodGrade
			Public RodType As String

			Public Steel As Short

			Public TensileStrength As Single

			Public Elasticity As Single

			Public RodWeight As Single

			Public StressMethod As Short

			Public SinkerBar As Short
		End Structure

		Public Structure CustomPumpUnitList
			Public Manufacturer As String

			Public Data As String
		End Structure

		Public Structure DEFAULTITEM
			Public Name As String

			Public Title As String

			Public Type As Char

			Public HelpContextID As Short

			Public DefaultValue As Object

			Public Units As String

			Public items As String
		End Structure

		Public Structure IPRTESTPOINT
			Public bPIEntered As Short

			Public Pintake As Single

			Public Pwf As Single

			Public Production As Single
		End Structure

		Public Structure LineType
			Public LSet As Short

			Public Value As Single
		End Structure

		Public Structure PUMPDIAGNOSIS
			Public Score As Single

			Public Index As Short

			Public Pattern As String

			Public Diagnosis As Long

			Public PumpFillage As Single

			Public TubingMovement As Single

			Public LineSetting As Single

			Public File As String
		End Structure

		Public Structure PUDataRec
			Public Sub Initialize()
				Me.CrankRadii = New Single(4) {}
				Me.Strokes = New Single(4) {}
				Me.Manuf = New String(" "c, 40)
				Me.APIDesignation = New String(" "c, 40)
				Me.UnitName = New String(" "c, 40)
				Me.OtherInfo = New String(" "c, 40)
			End Sub

			<VBFixedString(40)>
			Public Manuf As String

			<VBFixedString(40)>
			Public APIDesignation As String

			<VBFixedString(40)>
			Public UnitName As String

			<VBFixedString(40)>
			Public OtherInfo As String

			Public UnitType As Short

			Public RequiredRotation As Short

			Public CrankRotation As Short

			Public CrankHole As Short

			Public CrankHoles As Short

			<VBFixedArray(4)>
			Public CrankRadii As Single()

			<VBFixedArray(4)>
			Public Strokes As Single()

			Public KinematicStroke As Single

			Public FileRecord As Short

			Public iUnused0 As Short

			Public R As Single

			Public A As Single

			Public C As Single

			Public I As Single

			Public K As Single

			Public P As Single

			Public M As Single

			Public S As Single

			Public V0 As Single

			Public DrumDiamRatio As Single

			Public SprocketRadius As Single

			Public SprocketDistance As Single

			Public Unbalance As Single

			Public CrankOffset As Single

			Public StructRating As Single

			Public GearboxRating As Single

			Public MaxStroke As Single

			Public ArtInertia As Single
		End Structure

		Public Structure PUDataRec2
			Public Manuf As String

			Public APIDesignation As String

			Public UnitName As String

			Public OtherInfo As String

			Public UnitType As Short

			Public RequiredRotation As Short

			Public CrankRotation As Short

			Public CrankHole As Short

			Public CrankHoles As Short

			Public CrankRadii As Single()

			Public Strokes As Single()

			Public KinematicStroke As Single

			Public FileRecord As Short

			Public iUnused0 As Short

			Public r As Single

			Public A As Single

			Public c As Single

			Public I As Single

			Public K As Single

			Public P As Single

			Public M As Single

			Public S As Single

			Public V0 As Single

			Public DrumDiamRatio As Single

			Public SprocketRadius As Single

			Public SprocketDistance As Single

			Public Unbalance As Single

			Public CrankOffset As Single

			Public StructRating As Single

			Public GearboxRating As Single

			Public MaxStroke As Single

			Public ArtInertia As Single
		End Structure

		Public Structure UnitTypeInfo
			Public Sub Initialize()
				Me.Manuf = New String(" "c, 40)
				Me.Abbrev = New String(" "c, 8)
			End Sub

			<VBFixedString(40)>
			Public Manuf As String

			<VBFixedString(8)>
			Public Abbrev As String

			Public UnitType As Short

			Public RequiredRotation As Short

			Public ShowNames As Short

			Public SortByNames As Short
		End Structure

		Public Structure RodSection
			Public Sub Initialize()
				Me.RodType = New String(" "c, 20)
			End Sub

			Public Grade As Short

			Public RodType As String

			Public Diameter As Single

			Public Area As Single

			Public length As Single

			Public SuckerRodLength As Single

			Public RodDensity As Single

			Public RodWeight As Single

			Public Elasticity As Single

			Public TensileStrength As Single

			Public StressMethod As Short

			Public Guide As Short

			Public NumGuides As Short

			Public friction_coef As Single
		End Structure

		Public Structure SYSTEMDIAGNOSIS
			Public bBentPumpBarrel As Short

			Public bClamponInelegantHackHackPC As Short

			Public bClamponLoadCell As Short

			Public bCrankHoleCorrected As Short

			Public bExtremeRodTubingFriction As Short

			Public bExcessiveRodTubingFriction As Short

			Public bFluidInertia As Short

			Public bFluidLevelCorrected As Short

			Public bFluidPound As Short

			Public bFullPump As Short

			Public bGasInterference As Short

			Public bGasLock As Short

			Public bHittingDown As Short

			Public bHittingUp As Short

			Public bIncompleteFillage As Short

			Public bIncorrectFluidSPGR As Short

			Public bIncorrectPlungerSize As Short

			Public bIncorrectProductionRate As Short

			Public bIncorrectSPM As Short

			Public bLoadShiftCorrected As Short

			Public bMalfunctioningTubingAnchor As Short

			Public bMeasuredStrokeCorrected As Short

			Public bPlungerTooLarge As Short

			Public bPlungerTooSmall As Short

			Public bPumpConditionGood As Short

			Public bPumpFriction As Short

			Public bRodPart As Short

			Public bRodTubingFriction As Short

			Public bSevereDownholeProblem As Short

			Public bShallowFriction As Short

			Public bSinkerBarWaveReflection As Short

			Public bSPMHigh As Short

			Public bSPMLow As Short

			Public bStuckPump As Short

			Public bSurfaceMatchPoor As Short

			Public bSurfPosKinematicCorrected As Short

			Public bSurfPosKinematicRequired As Short

			Public bTubingAnchored As Short

			Public bTubingAnchorLoose As Short

			Public bTubingLeak As Short

			Public bTubingMovement As Short

			Public bUnknownPumpCondition As Short

			Public bUpperRingValvePump As Short

			Public iAdjustPhase As Short

			Public iCalcFrictionStatus As Short

			Public iDiagRodPart As Short

			Public iOrigCrankHole As Short

			Public iPumpFriction As Short

			Public iSectFluidVelocity As Short

			Public iSVLeak As Integer

			Public iTVLeak As Integer

			Public iWornPump As Short

			Public iWornPumpBarrel As Short

			Public FeetFromSurface As Single

			Public FluidSPGR As Single

			Public FluidVelocity As Single

			Public LoadShift As Single

			Public LoadShiftPct As Single

			Public MeasuredStroke As Single

			Public OrigStrokeLength As Single

			Public PhaseAdjustment As Single

			Public PlungerSize As Single

			Public PumpFillage As Single

			Public PumpIntakePressure As Single

			Public TubingMovement As Single
		End Structure

		Public Structure kdata
			Public PU_A As Single

			Public PU_C As Single

			Public PU_CrankOffset As Single

			Public PU_CrankRotation As Short

			Public PU_DrumDiamRatio As Single

			Public PU_I As Single

			Public PU_K As Single

			Public PU_P As Single

			Public PU_R As Single

			Public PU_SprocketDistance As Single

			Public PU_SprocketRadius As Single

			Public PU_UnitType As Short

			Public TotalTheta As Single
		End Structure

		Public Structure PDATA
			Public Sub Initialize()
				Me.Sections = New RSWIN_DESC.RodSection(8) {}
			End Sub

			Public Apump As Single

			Public CalcFriction As Short

			Public CasingPressure As Single

			Public CompressibilityIndex As Single

			Public dflnu As Single

			Public DownstrokeFriction As Single

			Public DownstrokeFrictionFactor As Single

			Public Dt As Single

			Public Dx As Single

			Public FluidDens As Single

			Public FluidLevel As Single

			Public FluidLoad As Single

			Public FluidSPGR As Single

			Public IncludeFluidInertia As Short

			Public IndPumpOp As Short

			Public Iart As Single

			Public Irot As Single

			Public M_BalancedT As Single

			Public M_Existing As Single

			Public MotorSPV As Single

			Public Nelem As Short

			Public Ntsteps As Short

			Public NumRods As Short

			Public Peff As Single

			Public Pintake As Single

			Public PlungerSize As Single

			Public PU_A As Single

			Public PU_CrankOffset As Single

			Public PU_DrumDiamRatio As Single

			Public PU_KinematicStroke As Single

			Public PU_M As Single

			Public PU_S As Single

			Public PU_Unbalance As Single

			Public PU_UnitType As Short

			Public PU_V0 As Single

			Public PumpCondition As Short

			Public PumpDepth As Single

			Public Pumpfill As Single

			Public PumpFriction As Single

			Public PumpLoadAdj As Single

			Public Sections As RSWIN_DESC.RodSection()

			Public Speemax As Single

			Public SPM As Single

			Public SteelRodString As Short

			Public StuffingBoxFriction As Single

			Public TotalTheta As Single

			Public TubingID As Single

			Public TubingPressure As Single

			Public TubStretch As Single

			Public UpstrokeFriction As Single

			Public UpstrokeFrictionFactor As Single

			Public WrodsInFluid As Single
		End Structure

		Public Structure r_e_structure
			Public dog As Single

			Public Tan_z As Single

			Public nor_x As Single

			Public nor_y As Single

			Public nor_z As Single

			Public gravity_force As Single

			Public sfg_x As Single

			Public sfg_y As Single

			Public sfg_z As Single

			Public friction_coef As Single
		End Structure

		Public Structure s_p_structure
			Public m_d As Single

			Public azi As Single

			Public Inc As Single
		End Structure

		Public Structure SubSectionType
			Public Length As Single

			Public Depth As Single

			Public Start As Single

			Public MaxNumberOfGuides As Single

			Public MostFrequentNumberOfGuides As Single

			Public NumberOfSuckerRodsInSection As Integer

			Public SuckerRodDepths As Single()

			Public SuckerRodNumGuides As Single()

			Public Added As Boolean

			Public Grade As Short

			Public RodType As String

			Public Diameter As Single

			Public Area As Single

			Public SuckerRodLength As Single

			Public RodDensity As Single

			Public RodWeight As Single

			Public Elasticity As Single

			Public TensileStrength As Single

			Public StressMethod As Short

			Public Guide As Short

			Public friction_coef As Single
		End Structure

		Public Structure GuideFrequencyStructure
			Public SectionLength As Single

			Public SectionDepth As Single

			Public SuckerRodLength As Single

			Public NumberOfSubSections As Integer

			Public SubSections As RSWIN_DESC.SubSectionType()
		End Structure

		Public Structure previous_rod_design_type
			Public Sub Initialize()
				Me.Sections = New RSWIN_DESC.RodSection(40) {}
			End Sub

			Public Sections As RSWIN_DESC.RodSection()
		End Structure
	End Module
End Namespace
