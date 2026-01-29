Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class cRODSTAR
		Public Sub New()
			Me.m_M = New Single(3) {}
			Me.m_RequiredUnbalance = New Single(3) {}
			Me.m_DynaFile = New String(" "c, 128)
			Me.m_gbParaffin = False
			Me.m_ParaffinDepth = 0F
			Me.m_LineSettings = New RSWIN_DESC.LineType(4) {}
			Me.m_XDLineSettings = New RSWIN_DESC.LineType(4) {}
			Me.m_ThisMagic = New String(" "c, 10)
			Me.m_DollarsPerBblFluid = New Single(3) {}
			Me.m_DollarsPerBblOil = New Single(3) {}
			Me.m_ElectricBillperMonth = New Single(3) {}
			Me.m_HpNemaD = New Single(3) {}
			Me.m_HpUhs = New Single(3) {}
			Me.m_MotorKWH = New Single(3) {}
			Me.m_gclsUpstroke = New RSWIN_DESC.PUMPDIAGNOSIS(3) {}
			Me.m_gclsDownstroke = New RSWIN_DESC.PUMPDIAGNOSIS(4) {}
			Me.m_PU = Nothing
			Me.m_UnitID = New String(" "c, 10)
			Me.m_UnitName = New String(" "c, 40)
			Me.m_Sections = New RSWIN_DESC.RodSection(40) {}
			Me.m_minStressBot = New Single(40) {}
			Me.m_maxStressBot = New Single(40) {}
			Me.m_minStressTop = New Single(40) {}
			Me.m_maxStressTop = New Single(40) {}
			Me.m_StressL = New Single(40) {}
			Me.m_CBE90 = New Single(3) {}
			Me.m_Clf = New Single(3) {}
			Me.m_GearboxLoading = New Single(3) {}
			Me.m_PeakTorque = New Single(3) {}
			Me.m_ACompanyName = New String(" "c, 40)
			Me.m_WellName = New String(" "c, 40)
			Me.m_UserName = New String(" "c, 40)
			Me.m_UserDate = New String(" "c, 40)
			Me.m_APITable = New Single(0, 0) {}
			Me.m_bUnknownUnbalance = True
			Me.m_VSP = False
			Me.m_PercentUpstrokeSPM = 50F
			Me.m_PercentDownstrokeSPM = 50F
			Me.m_AdjustedStrokeLength = -1F
			Me.m_bImplementedDesign = False
		End Sub

		Public Property bUnknownUnbalance As Boolean
			Get
				Return Me.m_bUnknownUnbalance
			End Get
			Set(value As Boolean)
				Me.m_bUnknownUnbalance = value
				Me.m_UnknownM = value
				If value Then
					Me.m_iUnknownM = 1
				Else
					Me.m_iUnknownM = 2
				End If
			End Set
		End Property

		Public Property FluidDamping As Single
			Get
				Return Me.m_FluidDamping
			End Get
			Set(value As Single)
				Me.m_FluidDamping = value
			End Set
		End Property

		Public Property PumpDragDownstrokeMax As Single
			Get
				Return Me.m_PumpDragDownstrokeMax
			End Get
			Set(value As Single)
				Me.m_PumpDragDownstrokeMax = value
			End Set
		End Property

		Public Property PumpDragUpstrokeMax As Single
			Get
				Return Me.m_PumpDragUpstrokeMax
			End Get
			Set(value As Single)
				Me.m_PumpDragUpstrokeMax = value
			End Set
		End Property

		Public Property DragSettings As Short
			Get
				Return Me.m_DragSettings
			End Get
			Set(value As Short)
				Me.m_DragSettings = value
			End Set
		End Property

		Public Property gbLite As Short
			Get
				Return Me.m_gbLite
			End Get
			Set(value As Short)
				Me.m_gbLite = value
			End Set
		End Property

		Public Property giThisVersion As Short
			Get
				Return Me.m_giThisVersion
			End Get
			Set(value As Short)
				Me.m_giThisVersion = value
			End Set
		End Property

		Public Property bDeviated As Boolean
			Get
				Return Me.m_bDeviated
			End Get
			Set(value As Boolean)
				Me.m_bDeviated = value
			End Set
		End Property

		Public Property bSaveFlag As Boolean
			Get
				Return Me.m_bSaveFlag
			End Get
			Set(value As Boolean)
				Me.m_bSaveFlag = value
			End Set
		End Property

		Public Property bCardIsReversed As Boolean
			Get
				Return Me.m_bCardIsReversed
			End Get
			Set(value As Boolean)
				Me.m_bCardIsReversed = value
			End Set
		End Property

		Public Property gbAutomaticEnabled As Boolean
			Get
				Return Me.m_gbAutomaticEnabled
			End Get
			Set(value As Boolean)
				Me.m_gbAutomaticEnabled = value
			End Set
		End Property

		Public Property gbRoddiagFile As Boolean
			Get
				Return Me.m_gbRoddiagFile
			End Get
			Set(value As Boolean)
				Me.m_gbRoddiagFile = value
			End Set
		End Property

		Public Property giCommonDialogHelpContext As Short
			Get
				Return Me.m_giCommonDialogHelpContext
			End Get
			Set(value As Short)
				Me.m_giCommonDialogHelpContext = value
			End Set
		End Property

		Public Property bCBEDigitized As Short
			Get
				Return Me.m_bCBEDigitized
			End Get
			Set(value As Short)
				Me.m_bCBEDigitized = value
			End Set
		End Property

		Public Property bCBEFromDisk As Short
			Get
				Return Me.m_bCBEFromDisk
			End Get
			Set(value As Short)
				Me.m_bCBEFromDisk = value
			End Set
		End Property

		Public Property CBDataType As Short
			Get
				Return Me.m_CBDataType
			End Get
			Set(value As Short)
				Me.m_CBDataType = value
			End Set
		End Property

		Public Property UnknownM As Boolean
			Get
				Return Me.m_UnknownM
			End Get
			Set(value As Boolean)
				Me.m_UnknownM = value
				If value Then
					Me.m_iUnknownM = 1
				Else
					Me.m_iUnknownM = 2
				End If
			End Set
		End Property

		Public Property iUnknownM As Integer
			Get
				Return Me.m_iUnknownM
			End Get
			Set(value As Integer)
				Me.m_iUnknownM = value
			End Set
		End Property

		Public Property CBEffect As Single
			Get
				Return Me.m_CBEffect
			End Get
			Set(value As Single)
				Me.m_CBEffect = value
			End Set
		End Property

		Public Property CBAngle As Single
			Get
				Return Me.m_CBAngle
			End Get
			Set(value As Single)
				Me.m_CBAngle = value
			End Set
		End Property

		Public Property M As Single()
			Get
				Return Me.m_M
			End Get
			Set(value As Single())
				Me.m_M = value
			End Set
		End Property

		Public Property M(index As Integer) As Single
			Get
				Return Me.m_M(index)
			End Get
			Set(value As Single)
				Me.m_M(index) = value
			End Set
		End Property

		Public Property RequiredUnbalance As Single()
			Get
				Return Me.m_RequiredUnbalance
			End Get
			Set(value As Single())
				Me.m_RequiredUnbalance = value
			End Set
		End Property

		Public Property RequiredUnbalance(index As Integer) As Single
			Get
				Return Me.m_RequiredUnbalance(index)
			End Get
			Set(value As Single)
				Me.m_RequiredUnbalance(index) = value
			End Set
		End Property

		Public Property CBDataFile As String
			Get
				Return Me.m_CBDataFile
			End Get
			Set(value As String)
				Me.m_CBDataFile = value
			End Set
		End Property

		Public Property DynaFile As String
			Get
				Return Me.m_DynaFile
			End Get
			Set(value As String)
				Me.m_DynaFile = value
			End Set
		End Property

		Public Property Inputfile As String
			Get
				Return Me.m_Inputfile
			End Get
			Set(value As String)
				Me.m_Inputfile = value
			End Set
		End Property

		Public Property MotorDataFile As String
			Get
				Return Me.m_MotorDataFile
			End Get
			Set(value As String)
				Me.m_MotorDataFile = value
			End Set
		End Property

		Public Property gbInputDataChanged As Boolean
			Get
				Return Me.m_gbInputDataChanged
			End Get
			Set(value As Boolean)
				Me.m_gbInputDataChanged = value
			End Set
		End Property

		Public Property gbOutputLoaded As Boolean
			Get
				Return Me.m_gbOutputLoaded
			End Get
			Set(value As Boolean)
				Me.m_gbOutputLoaded = value
			End Set
		End Property

		Public Property gbOutputOld As Boolean
			Get
				Return Me.m_gbOutputOld
			End Get
			Set(value As Boolean)
				Me.m_gbOutputOld = value
			End Set
		End Property

		Public Property CBLDir As String
			Get
				Return Me.m_CBLDir
			End Get
			Set(value As String)
				Me.m_CBLDir = value
			End Set
		End Property

		Public Property RSTDir As String
			Get
				Return Me.m_RSTDir
			End Get
			Set(value As String)
				Me.m_RSTDir = value
			End Set
		End Property

		Public Property DYNDir As String
			Get
				Return Me.m_DYNDir
			End Get
			Set(value As String)
				Me.m_DYNDir = value
			End Set
		End Property

		Public Property XDGDir As String
			Get
				Return Me.m_XDGDir
			End Get
			Set(value As String)
				Me.m_XDGDir = value
			End Set
		End Property

		Public Property SurfPos As Single()
			Get
				Return Me.m_SurfPos
			End Get
			Set(value As Single())
				Me.m_SurfPos = value
			End Set
		End Property

		Public Property SurfLoad As Single()
			Get
				Return Me.m_SurfLoad
			End Get
			Set(value As Single())
				Me.m_SurfLoad = value
			End Set
		End Property

		Public Property RDSurfPos As Single()
			Get
				Return Me.m_RDSurfPos
			End Get
			Set(value As Single())
				Me.m_RDSurfPos = value
			End Set
		End Property

		Public Property RDSurfLoad As Single()
			Get
				Return Me.m_RDSurfLoad
			End Get
			Set(value As Single())
				Me.m_RDSurfLoad = value
			End Set
		End Property

		Public Property PumpPos As Single()
			Get
				Return Me.m_PumpPos
			End Get
			Set(value As Single())
				Me.m_PumpPos = value
			End Set
		End Property

		Public Property PumpLoad As Single()
			Get
				Return Me.m_PumpLoad
			End Get
			Set(value As Single())
				Me.m_PumpLoad = value
			End Set
		End Property

		Public Property Ntsteps As Short
			Get
				Return Me.m_Ntsteps
			End Get
			Set(value As Short)
				Me.m_Ntsteps = value
			End Set
		End Property

		Public Property RDNtsteps As Short
			Get
				Return Me.m_RDNtsteps
			End Get
			Set(value As Short)
				Me.m_RDNtsteps = value
			End Set
		End Property

		Public Property dSurfPos As Single()
			Get
				Return Me.m_dSurfPos
			End Get
			Set(value As Single())
				Me.m_dSurfPos = value
			End Set
		End Property

		Public Property dSurfLoad As Single()
			Get
				Return Me.m_dSurfLoad
			End Get
			Set(value As Single())
				Me.m_dSurfLoad = value
			End Set
		End Property

		Public Property dNtsteps As Short
			Get
				Return Me.m_dNtsteps
			End Get
			Set(value As Short)
				Me.m_dNtsteps = value
			End Set
		End Property

		Public Property xSurfPos As Single()
			Get
				Return Me.m_xSurfPos
			End Get
			Set(value As Single())
				Me.m_xSurfPos = value
			End Set
		End Property

		Public Property xSurfLoad As Single()
			Get
				Return Me.m_xSurfLoad
			End Get
			Set(value As Single())
				Me.m_xSurfLoad = value
			End Set
		End Property

		Public Property xNtsteps As Short
			Get
				Return Me.m_xNtsteps
			End Get
			Set(value As Short)
				Me.m_xNtsteps = value
			End Set
		End Property

		Public Property pSurfPos As Single()
			Get
				Return Me.m_pSurfPos
			End Get
			Set(value As Single())
				Me.m_pSurfPos = value
			End Set
		End Property

		Public Property pSurfLoad As Single()
			Get
				Return Me.m_pSurfLoad
			End Get
			Set(value As Single())
				Me.m_pSurfLoad = value
			End Set
		End Property

		Public Property pPumpPos As Single()
			Get
				Return Me.m_pPumpPos
			End Get
			Set(value As Single())
				Me.m_pPumpPos = value
			End Set
		End Property

		Public Property pPumpLoad As Single()
			Get
				Return Me.m_pPumpLoad
			End Get
			Set(value As Single())
				Me.m_pPumpLoad = value
			End Set
		End Property

		Public Property pNtsteps As Short
			Get
				Return Me.m_pNtsteps
			End Get
			Set(value As Short)
				Me.m_pNtsteps = value
			End Set
		End Property

		Public Property NoFIPumpLoad As Single()
			Get
				Return Me.m_NoFIPumpLoad
			End Get
			Set(value As Single())
				Me.m_NoFIPumpLoad = value
			End Set
		End Property

		Public Property zNtsteps As Short
			Get
				Return Me.m_zNtsteps
			End Get
			Set(value As Short)
				Me.m_zNtsteps = value
			End Set
		End Property

		Public Property g_PumpPosNoTubing As Single()
			Get
				Return Me.m_g_PumpPosNoTubing
			End Get
			Set(value As Single())
				Me.m_g_PumpPosNoTubing = value
			End Set
		End Property

		Public Property g_NtstepsNoTubing As Short
			Get
				Return Me.m_g_NtstepsNoTubing
			End Get
			Set(value As Short)
				Me.m_g_NtstepsNoTubing = value
			End Set
		End Property

		Public Property PermLoad As Single()
			Get
				Return Me.m_PermLoad
			End Get
			Set(value As Single())
				Me.m_PermLoad = value
			End Set
		End Property

		Public Property DynaSource As Short
			Get
				Return Me.m_DynaSource
			End Get
			Set(value As Short)
				Me.m_DynaSource = value
			End Set
		End Property

		Public Property DynoCard As Integer
			Get
				Return Me.m_DynoCard
			End Get
			Set(value As Integer)
				Me.m_DynoCard = value
			End Set
		End Property

		Public Property sDynoCard As String
			Get
				Return Me.m_sDynoCard
			End Get
			Set(value As String)
				Me.m_sDynoCard = value
			End Set
		End Property

		Public Property DynoDate As String
			Get
				Return Me.m_DynoDate
			End Get
			Set(value As String)
				Me.m_DynoDate = value
			End Set
		End Property

		Public Property NtstepsUpstroke As Short
			Get
				Return Me.m_NtstepsUpstroke
			End Get
			Set(value As Short)
				Me.m_NtstepsUpstroke = value
			End Set
		End Property

		Public Property gbClampOn As Short
			Get
				Return Me.m_gbClampOn
			End Get
			Set(value As Short)
				Me.m_gbClampOn = value
			End Set
		End Property

		Public Property giDynoCorrectKinematic As Short
			Get
				Return Me.m_giDynoCorrectKinematic
			End Get
			Set(value As Short)
				Me.m_giDynoCorrectKinematic = value
			End Set
		End Property

		Public Property giDynoCorrectPhase As Short
			Get
				Return Me.m_giDynoCorrectPhase
			End Get
			Set(value As Short)
				Me.m_giDynoCorrectPhase = value
			End Set
		End Property

		Public Property giDynoDetectKinematic As Short
			Get
				Return Me.m_giDynoDetectKinematic
			End Get
			Set(value As Short)
				Me.m_giDynoDetectKinematic = value
			End Set
		End Property

		Public Property giDynoDetectPhase As Short
			Get
				Return Me.m_giDynoDetectPhase
			End Get
			Set(value As Short)
				Me.m_giDynoDetectPhase = value
			End Set
		End Property

		Public Property gfDynoLoadAdjustment As Single
			Get
				Return Me.m_gfDynoLoadAdjustment
			End Get
			Set(value As Single)
				Me.m_gfDynoLoadAdjustment = value
			End Set
		End Property

		Public Property gfDynoPhaseAdjustment As Single
			Get
				Return Me.m_gfDynoPhaseAdjustment
			End Get
			Set(value As Single)
				Me.m_gfDynoPhaseAdjustment = value
			End Set
		End Property

		Public Property gfDynoTOSAdjustment As Single
			Get
				Return Me.m_gfDynoTOSAdjustment
			End Get
			Set(value As Single)
				Me.m_gfDynoTOSAdjustment = value
			End Set
		End Property

		Public Property gbDynoCardReversed As Boolean
			Get
				Me.m_gbDynoCardReversed = Me.m_gbDynoCardReversed
				Dim result As Boolean
				Return result
			End Get
			Set(value As Boolean)
				Me.m_gbDynoCardReversed = value
			End Set
		End Property

		Public Property BaselineLoad As Single
			Get
				Return Me.m_BaselineLoad
			End Get
			Set(value As Single)
				Me.m_BaselineLoad = value
			End Set
		End Property

		Public Property LoadScale As Single
			Get
				Return Me.m_LoadScale
			End Get
			Set(value As Single)
				Me.m_LoadScale = value
			End Set
		End Property

		Public Property CbeX As Single
			Get
				Return Me.m_CbeX
			End Get
			Set(value As Single)
				Me.m_CbeX = value
			End Set
		End Property

		Public Property CbeY As Single
			Get
				Return Me.m_CbeY
			End Get
			Set(value As Single)
				Me.m_CbeY = value
			End Set
		End Property

		Public Property bCBEUpstroke As Short
			Get
				Return Me.m_bCBEUpstroke
			End Get
			Set(value As Short)
				Me.m_bCBEUpstroke = value
			End Set
		End Property

		Public Property Npoints As Short
			Get
				Return Me.m_Npoints
			End Get
			Set(value As Short)
			End Set
		End Property

		Public Property gbDesignSinkerbar As Boolean
			Get
				Return Me.m_gbDesignSinkerbar
			End Get
			Set(value As Boolean)
				Me.m_gbDesignSinkerbar = value
			End Set
		End Property

		Public Property DigPoints As Single(,)
			Get
				Return Me.m_DigPoints
			End Get
			Set(value As Single(,))
				Me.m_DigPoints = value
			End Set
		End Property

		Public Property LeutertDynamometer As Short
			Get
				Return Me.m_LeutertDynamometer
			End Get
			Set(value As Short)
				Me.m_LeutertDynamometer = value
			End Set
		End Property

		Public Property LeutertModel As String
			Get
				Return Me.m_LeutertModel
			End Get
			Set(value As String)
				Me.m_LeutertModel = value
			End Set
		End Property

		Public Property LeutertScale As Single
			Get
				Return Me.m_LeutertScale
			End Get
			Set(value As Single)
				Me.m_LeutertScale = value
			End Set
		End Property

		Public Property LeutertSpring As Short
			Get
				Return Me.m_LeutertSpring
			End Get
			Set(value As Short)
				Me.m_LeutertSpring = value
			End Set
		End Property

		Public Property MeasuredRuntime As Single
			Get
				Return Me.m_MeasuredRuntime
			End Get
			Set(value As Single)
				Me.m_MeasuredRuntime = value
			End Set
		End Property

		Public Property MeasuredSPM As Single
			Get
				Return Me.m_MeasuredSPM
			End Get
			Set(value As Single)
				Me.m_MeasuredSPM = value
			End Set
		End Property

		Public Property MeasuredStroke As Single
			Get
				Return Me.m_MeasuredStroke
			End Get
			Set(value As Single)
				Me.m_MeasuredStroke = value
			End Set
		End Property

		Public Property MeasuredCBEffect As Single
			Get
				Return Me.m_MeasuredCBEffect
			End Get
			Set(value As Single)
				Me.m_MeasuredCBEffect = value
			End Set
		End Property

		Public Property MeasuredCBEpos As Single
			Get
				Return Me.m_MeasuredCBEpos
			End Get
			Set(value As Single)
				Me.m_MeasuredCBEpos = value
			End Set
		End Property

		Public Property MeasuredCBEupstroke As Short
			Get
				Return Me.m_MeasuredCBEupstroke
			End Get
			Set(value As Short)
				Me.m_MeasuredCBEupstroke = value
			End Set
		End Property

		Public Property MeasuredTVLoad As Single
			Get
				Return Me.m_MeasuredTVLoad
			End Get
			Set(value As Single)
				Me.m_MeasuredTVLoad = value
			End Set
		End Property

		Public Property MeasuredSVLoad As Single
			Get
				Return Me.m_MeasuredSVLoad
			End Get
			Set(value As Single)
				If value < 100F Then
					value = 0F
				End If
				Me.m_MeasuredSVLoad = value
			End Set
		End Property

		Public Property CompressibilityIndex As Single
			Get
				Return Me.m_CompressibilityIndex
			End Get
			Set(value As Single)
				Me.m_CompressibilityIndex = value
			End Set
		End Property

		Public Property PumpEfficiency As Single
			Get
				Return Me.m_PumpEfficiency
			End Get
			Set(value As Single)
				Me.m_PumpEfficiency = value
			End Set
		End Property

		Public Property UFeetFromSurface As Single
			Get
				Return Me.m_UFeetFromSurface
			End Get
			Set(value As Single)
				Me.m_UFeetFromSurface = value
			End Set
		End Property

		Public Property UFeetOverPump As Single
			Get
				Return Me.m_UFeetOverPump
			End Get
			Set(value As Single)
				Me.m_UFeetOverPump = value
			End Set
		End Property

		Public Property FluidLevel As Single
			Get
				Return Me.m_FluidLevel
			End Get
			Set(value As Single)
				Me.m_FluidLevel = value
			End Set
		End Property

		Public Property FluidLevelTVD As Single
			Get
				Return Me.m_FluidLevelTVD
			End Get
			Set(value As Single)
				Me.m_FluidLevelTVD = value
			End Set
		End Property

		Public Property PumpDepthTVD As Single
			Get
				Return Me.m_PumpDepthTVD
			End Get
			Set(value As Single)
				Me.m_PumpDepthTVD = value
			End Set
		End Property

		Public Property UPumpIntakePressure As Single
			Get
				Return Me.m_UPumpIntakePressure
			End Get
			Set(value As Single)
				Me.m_UPumpIntakePressure = value
			End Set
		End Property

		Public Property UPintakeFromLines As Single
			Get
				Return Me.m_UPintakeFromLines
			End Get
			Set(value As Single)
				Me.m_UPintakeFromLines = value
			End Set
		End Property

		Public Property giFluidLevelSource As Short
			Get
				Return Me.m_giFluidLevelSource
			End Get
			Set(value As Short)
				Me.m_giFluidLevelSource = value
			End Set
		End Property

		Public Property XDFeetFromSurface As Single
			Get
				Return Me.m_XDFeetFromSurface
			End Get
			Set(value As Single)
				Me.m_XDFeetFromSurface = value
			End Set
		End Property

		Public Property XDFeetOverPump As Single
			Get
				Return Me.m_XDFeetOverPump
			End Get
			Set(value As Single)
				Me.m_XDFeetOverPump = value
			End Set
		End Property

		Public Property XDFluidLoad As Single
			Get
				Return Me.m_XDFluidLoad
			End Get
			Set(value As Single)
				Me.m_XDFluidLoad = value
			End Set
		End Property

		Public Property XDPintakeFromLines As Single
			Get
				Return Me.m_XDPintakeFromLines
			End Get
			Set(value As Single)
				Me.m_XDPintakeFromLines = value
			End Set
		End Property

		Public Property g_FluidPoundFluidLoad As Single
			Get
				Return Me.m_g_FluidPoundFluidLoad
			End Get
			Set(value As Single)
				Me.m_g_FluidPoundFluidLoad = value
			End Set
		End Property

		Public Property g_fPredFeetFromSurface As Single
			Get
				Return Me.m_g_fPredFeetFromSurface
			End Get
			Set(value As Single)
				Me.m_g_fPredFeetFromSurface = value
			End Set
		End Property

		Public Property g_bUsingXDFluidLevel As Short
			Get
				Return Me.m_g_bUsingXDFluidLevel
			End Get
			Set(value As Short)
				Me.m_g_bUsingXDFluidLevel = value
			End Set
		End Property

		Public Property gbParaffin As Boolean
			Get
				Return Me.m_gbParaffin
			End Get
			Set(value As Boolean)
				Me.m_gbParaffin = value
			End Set
		End Property

		Public Property ParaffinDepth As Single
			Get
				Return Me.m_ParaffinDepth
			End Get
			Set(value As Single)
				Me.m_ParaffinDepth = value
			End Set
		End Property

		Public Property gbCalcFluidSPGR As Boolean
			Get
				Return Me.m_gbCalcFluidSPGR
			End Get
			Set(value As Boolean)
				Me.m_gbCalcFluidSPGR = value
			End Set
		End Property

		Public Property gfMaxFluidSPGR As Single
			Get
				Return Me.m_gfMaxFluidSPGR
			End Get
			Set(value As Single)
				Me.m_gfMaxFluidSPGR = value
			End Set
		End Property

		Public Property FluidSPGR As Single
			Get
				Return Me.m_FluidSPGR
			End Get
			Set(value As Single)
				Me.m_FluidSPGR = value
			End Set
		End Property

		Public Property OilAPI As Single
			Get
				Return Me.m_OilAPI
			End Get
			Set(value As Single)
				Me.m_OilAPI = value
			End Set
		End Property

		Public Property OilSPGR As Single
			Get
				Return Me.m_OilSPGR
			End Get
			Set(value As Single)
				Me.m_OilSPGR = value
			End Set
		End Property

		Public Property WaterCut As Single
			Get
				Return Me.m_WaterCut
			End Get
			Set(value As Single)
				Me.m_WaterCut = value
			End Set
		End Property

		Public Property WaterSPGR As Single
			Get
				Return Me.m_WaterSPGR
			End Get
			Set(value As Single)
				Me.m_WaterSPGR = value
			End Set
		End Property

		Public Property gbCalcFetkovichN As Boolean
			Get
				Return Me.m_gbCalcFetkovichN
			End Get
			Set(value As Boolean)
				Me.m_gbCalcFetkovichN = value
			End Set
		End Property

		Public Property gbProducingBelowBPP As Boolean
			Get
				Return Me.m_gbProducingBelowBPP
			End Get
			Set(value As Boolean)
				Me.m_gbProducingBelowBPP = value
			End Set
		End Property

		Public Property gbUseIPR As Boolean
			Get
				Return Me.m_gbUseIPR
			End Get
			Set(value As Boolean)
				Me.m_gbUseIPR = value
			End Set
		End Property

		Public Property giIPRMethod As Short
			Get
				Return Me.m_giIPRMethod
			End Get
			Set(value As Short)
				Me.m_giIPRMethod = value
			End Set
		End Property

		Public Property BubblePoint As Single
			Get
				Return Me.m_BubblePoint
			End Get
			Set(value As Single)
				Me.m_BubblePoint = value
			End Set
		End Property

		Public Property bHasFGlass As Boolean
			Get
				Return Me.m_bHasFGlass
			End Get
			Set(value As Boolean)
				Me.m_bHasFGlass = value
			End Set
		End Property

		Public Property bHasRR As Boolean
			Get
				Return Me.m_bHasRR
			End Get
			Set(value As Boolean)
				Me.m_bHasRR = value
			End Set
		End Property

		Public Property FetkovichN As Single
			Get
				Return Me.m_FetkovichN
			End Get
			Set(value As Single)
				Me.m_FetkovichN = value
			End Set
		End Property

		Public Property MidPerfDepth As Single
			Get
				Return Me.m_MidPerfDepth
			End Get
			Set(value As Single)
				Me.m_MidPerfDepth = value
			End Set
		End Property

		Public Property CasingPressure As Single
			Get
				Return Me.m_CasingPressure
			End Get
			Set(value As Single)
				Me.m_CasingPressure = value
			End Set
		End Property

		Public Property PumpIntakePressure As Single
			Get
				Return Me.m_PumpIntakePressure
			End Get
			Set(value As Single)
				Me.m_PumpIntakePressure = value
				Me.m_UPumpIntakePressure = value
			End Set
		End Property

		Public Property StaticBHPressure As Single
			Get
				Return Me.m_StaticBHPressure
			End Get
			Set(value As Single)
				Me.m_StaticBHPressure = value
			End Set
		End Property

		Public Property TubingPressure As Single
			Get
				Return Me.m_TubingPressure
			End Get
			Set(value As Single)
				Me.m_TubingPressure = value
			End Set
		End Property

		Public Property gnTestPoints As Short
			Get
				Return Me.m_gnTestPoints
			End Get
			Set(value As Short)
				Me.m_gnTestPoints = value
			End Set
		End Property

		Public Property TestPoints As RSWIN_DESC.IPRTESTPOINT()
			Get
				Return Me.m_TestPoints
			End Get
			Set(value As RSWIN_DESC.IPRTESTPOINT())
				Me.m_TestPoints = value
			End Set
		End Property

		Public Property WaterPI As Single
			Get
				Return Me.m_WaterPI
			End Get
			Set(value As Single)
				Me.m_WaterPI = value
			End Set
		End Property

		Public Property LineSettings As RSWIN_DESC.LineType()
			Get
				Return Me.m_LineSettings
			End Get
			Set(value As RSWIN_DESC.LineType())
				Me.m_LineSettings = value
			End Set
		End Property

		Public Property ULinesSetH As Short
			Get
				Return Me.m_ULinesSetH
			End Get
			Set(value As Short)
				Me.m_ULinesSetH = value
			End Set
		End Property

		Public Property ULinesSetV As Short
			Get
				Return Me.m_ULinesSetV
			End Get
			Set(value As Short)
				Me.m_ULinesSetV = value
			End Set
		End Property

		Public Property ULineSettingsChanged As Short
			Get
				Return Me.m_ULineSettingsChanged
			End Get
			Set(value As Short)
				Me.m_ULineSettingsChanged = value
			End Set
		End Property

		Public Property XDLineSettings As RSWIN_DESC.LineType()
			Get
				Return Me.m_XDLineSettings
			End Get
			Set(value As RSWIN_DESC.LineType())
				Me.m_XDLineSettings = value
			End Set
		End Property

		Public Property XDLinesSetH As Short
			Get
				Return Me.m_XDLinesSetH
			End Get
			Set(value As Short)
				Me.m_XDLinesSetH = value
			End Set
		End Property

		Public Property XDLinesSetV As Short
			Get
				Return Me.m_XDLinesSetV
			End Get
			Set(value As Short)
				Me.m_XDLinesSetV = value
			End Set
		End Property

		Public Property ThisVersion As Short
			Get
				Return Me.m_ThisVersion
			End Get
			Set(value As Short)
				Me.m_ThisVersion = value
			End Set
		End Property

		Public Property ThisMagic As String
			Get
				Return Me.m_ThisMagic
			End Get
			Set(value As String)
				Me.m_ThisMagic = value
			End Set
		End Property

		Public Property CalcMotorSize As Short
			Get
				Return Me.m_CalcMotorSize
			End Get
			Set(value As Short)
				Me.m_CalcMotorSize = value
				If value <> -1S And value <> 0S Then
					Me.m_CalcMotorSize = 0S
				End If
			End Set
		End Property

		Public Property Iart As Single
			Get
				Return Me.m_Iart
			End Get
			Set(value As Single)
				Me.m_Iart = value
			End Set
		End Property

		Public Property Irot As Single
			Get
				Return Me.m_Irot
			End Get
			Set(value As Single)
				Me.m_Irot = value
			End Set
		End Property

		Public Property MotorSPV As Single
			Get
				Return Me.m_MotorSPV
			End Get
			Set(value As Single)
				Me.m_MotorSPV = value
			End Set
		End Property

		Public Property Apump As Single
			Get
				Return Me.m_Apump
			End Get
			Set(value As Single)
				Me.m_Apump = value
			End Set
		End Property

		Public Property PlungerSize As Single
			Get
				Return Me.m_PlungerSize
			End Get
			Set(value As Single)
				Me.m_PlungerSize = value
			End Set
		End Property

		Public Property PumpType As Short
			Get
				Return Me.m_PumpType
			End Get
			Set(value As Short)
				Me.m_PumpType = value
			End Set
		End Property

		Public Property VSP As Boolean
			Get
				Return Me.m_VSP
			End Get
			Set(value As Boolean)
				Me.m_VSP = False
			End Set
		End Property

		Public Property ElectricityCost As Single
			Get
				Return Me.m_ElectricityCost
			End Get
			Set(value As Single)
				Me.m_ElectricityCost = value
			End Set
		End Property

		Public Property PowerMeterType As Short
			Get
				Return Me.m_PowerMeterType
			End Get
			Set(value As Short)
				Me.m_PowerMeterType = value
			End Set
		End Property

		Public Property Prhp As Single
			Get
				Return Me.m_Prhp
			End Get
			Set(value As Single)
				Me.m_Prhp = value
			End Set
		End Property

		Public Property Plhp As Single
			Get
				Return Me.m_Plhp
			End Get
			Set(value As Single)
				Me.m_Plhp = value
			End Set
		End Property

		Public Property MinMotorHP As Single
			Get
				Return Me.m_MinMotorHP
			End Get
			Set(value As Single)
				Me.m_MinMotorHP = value
			End Set
		End Property

		Public Property MotorHP As Single
			Get
				Return Me.m_MotorHP
			End Get
			Set(value As Single)
				Me.m_MotorHP = value
			End Set
		End Property

		Public Property USystemEff As Single
			Get
				Return Me.m_USystemEff
			End Get
			Set(value As Single)
				Me.m_USystemEff = value
			End Set
		End Property

		Public Property XDSystemEff As Single
			Get
				Return Me.m_XDSystemEff
			End Get
			Set(value As Single)
				Me.m_XDSystemEff = value
			End Set
		End Property

		Public Property DollarsPerBblFluid As Single()
			Get
				Return Me.m_DollarsPerBblFluid
			End Get
			Set(value As Single())
				Me.m_DollarsPerBblFluid = value
			End Set
		End Property

		Public Property DollarsPerBblOil As Single()
			Get
				Return Me.m_DollarsPerBblOil
			End Get
			Set(value As Single())
				Me.m_DollarsPerBblOil = value
			End Set
		End Property

		Public Property ElectricBillperMonth(Index As Integer) As Single
			Get
				Return Me.m_ElectricBillperMonth(Index)
			End Get
			Set(value As Single)
				Me.m_ElectricBillperMonth(Index) = value
			End Set
		End Property

		Public Property ElectricBillperMonth As Single()
			Get
				Return Me.m_ElectricBillperMonth
			End Get
			Set(value As Single())
				Me.m_ElectricBillperMonth = value
			End Set
		End Property

		Public Property HpNemaD As Single()
			Get
				Return Me.m_HpNemaD
			End Get
			Set(value As Single())
				Me.m_HpNemaD = value
			End Set
		End Property

		Public Property HpUhs As Single()
			Get
				Return Me.m_HpUhs
			End Get
			Set(value As Single())
				Me.m_HpUhs = value
			End Set
		End Property

		Public Property MotorKWH As Single()
			Get
				Return Me.m_MotorKWH
			End Get
			Set(value As Single())
				Me.m_MotorKWH = value
			End Set
		End Property

		Public Property PumpLoadAdj As Single
			Get
				Return Me.m_PumpLoadAdj
			End Get
			Set(value As Single)
				Me.m_PumpLoadAdj = value
			End Set
		End Property

		Public Property BPDsurface As Single
			Get
				Return Me.m_BPDsurface
			End Get
			Set(value As Single)
				Me.m_BPDsurface = value
			End Set
		End Property

		Public Property UFluidLoad As Single
			Get
				Return Me.m_UFluidLoad
			End Get
			Set(value As Single)
				Me.m_UFluidLoad = value
			End Set
		End Property

		Public Property GrossPumpStroke As Single
			Get
				Return Me.m_GrossPumpStroke
			End Get
			Set(value As Single)
				Me.m_GrossPumpStroke = value
			End Set
		End Property

		Public Property Runtime As Single
			Get
				Return Me.m_Runtime
			End Get
			Set(value As Single)
				Me.m_Runtime = value
			End Set
		End Property

		Public Property SPM As Single
			Get
				Return Me.m_SPM
			End Get
			Set(value As Single)
				Me.m_SPM = value
			End Set
		End Property

		Public Property UNetProduction As Single
			Get
				Return Me.m_UNetProduction
			End Get
			Set(value As Single)
				Me.m_UNetProduction = value
			End Set
		End Property

		Public Property UNetStrokeApparent As Single
			Get
				Return Me.m_UNetStrokeApparent
			End Get
			Set(value As Single)
				Me.m_UNetStrokeApparent = value
			End Set
		End Property

		Public Property UNetStroke As Single
			Get
				Return Me.m_UNetStroke
			End Get
			Set(value As Single)
				Me.m_UNetStroke = value
			End Set
		End Property

		Public Property XDNetProduction As Single
			Get
				Return Me.m_XDNetProduction
			End Get
			Set(value As Single)
				Me.m_XDNetProduction = value
			End Set
		End Property

		Public Property XDNetStrokeApparent As Single
			Get
				Return Me.m_XDNetStrokeApparent
			End Get
			Set(value As Single)
				Me.m_XDNetStrokeApparent = value
			End Set
		End Property

		Public Property XDNetStroke As Single
			Get
				Return Me.m_XDNetStroke
			End Get
			Set(value As Single)
				Me.m_XDNetStroke = value
			End Set
		End Property

		Public Property gclsUpstroke As RSWIN_DESC.PUMPDIAGNOSIS()
			Get
				Return Me.m_gclsUpstroke
			End Get
			Set(value As RSWIN_DESC.PUMPDIAGNOSIS())
				Me.m_gclsUpstroke = value
			End Set
		End Property

		Public Property gclsDownstroke As RSWIN_DESC.PUMPDIAGNOSIS()
			Get
				Return Me.m_gclsDownstroke
			End Get
			Set(value As RSWIN_DESC.PUMPDIAGNOSIS())
				Me.m_gclsDownstroke = value
			End Set
		End Property

		Public Property DownstrokeTilt As Single
			Get
				Return Me.m_DownstrokeTilt
			End Get
			Set(value As Single)
				Me.m_DownstrokeTilt = value
			End Set
		End Property

		Public Property pGrossPumpStroke As Single
			Get
				Return Me.m_pGrossPumpStroke
			End Get
			Set(value As Single)
				Me.m_pGrossPumpStroke = value
			End Set
		End Property

		Public Property PlungerMinLoad As Single
			Get
				Return Me.m_PlungerMinLoad
			End Get
			Set(value As Single)
				Me.m_PlungerMinLoad = value
			End Set
		End Property

		Public Property PlungerMaxLoad As Single
			Get
				Return Me.m_PlungerMaxLoad
			End Get
			Set(value As Single)
				Me.m_PlungerMaxLoad = value
			End Set
		End Property

		Public Property PumpFillagePat As Single
			Get
				Return Me.m_PumpFillagePat
			End Get
			Set(value As Single)
				Me.m_PumpFillagePat = value
			End Set
		End Property

		Public Property PumpLoadShift As Single
			Get
				Return Me.m_PumpLoadShift
			End Get
			Set(value As Single)
				Me.m_PumpLoadShift = value
			End Set
		End Property

		Public Property TubingMovement As Single
			Get
				Return Me.m_TubingMovement
			End Get
			Set(value As Single)
				Me.m_TubingMovement = value
			End Set
		End Property

		Public Property TubingMovementPat As Short
			Get
				Return Me.m_TubingMovementPat
			End Get
			Set(value As Short)
				Me.m_TubingMovementPat = value
			End Set
		End Property

		Public Property UpstrokeTilt As Single
			Get
				Return Me.m_UpstrokeTilt
			End Get
			Set(value As Single)
				Me.m_UpstrokeTilt = value
			End Set
		End Property

		Public Property ZeroPosition As Single
			Get
				Return Me.m_ZeroPosition
			End Get
			Set(value As Single)
				Me.m_ZeroPosition = value
			End Set
		End Property

		Public Property PumpDepth As Single
			Get
				Return Me.m_PumpDepth
			End Get
			Set(value As Single)
				Me.m_PumpDepth = value
			End Set
		End Property

		Public Property IntermediateDepth As Single
			Get
				Return Me.m_IntermediateDepth
			End Get
			Set(value As Single)
				Me.m_IntermediateDepth = value
			End Set
		End Property

		Public Property UPumpFillage As Single
			Get
				Return Me.m_UPumpFillage
			End Get
			Set(value As Single)
				Me.m_UPumpFillage = value
			End Set
		End Property

		Public Property XDPumpFillage As Single
			Get
				Return Me.m_XDPumpFillage
			End Get
			Set(value As Single)
				Me.m_XDPumpFillage = value
			End Set
		End Property

		Public Property PU As RSWIN_DESC.PUDataRec
			Get
				Return Me.m_PU
			End Get
			Set(value As RSWIN_DESC.PUDataRec)
				Me.m_PU = value
			End Set
		End Property

		Public Property IDEntered As Short
			Get
				Return Me.m_IDEntered
			End Get
			Set(value As Short)
				Me.m_IDEntered = value
			End Set
		End Property

		Public Property CrankSpeed As Single
			Get
				Return Me.m_CrankSpeed
			End Get
			Set(value As Single)
				Me.m_CrankSpeed = value
			End Set
		End Property

		Public Property TotalTheta As Single
			Get
				Return Me.m_TotalTheta
			End Get
			Set(value As Single)
				Me.m_TotalTheta = value
			End Set
		End Property

		Public Property UnitID As String
			Get
				Return Me.m_UnitID
			End Get
			Set(value As String)
				Me.m_UnitID = value
			End Set
		End Property

		Public Property UnitName As String
			Get
				Return Me.m_UnitName
			End Get
			Set(value As String)
				Me.m_UnitName = value
			End Set
		End Property

		Public Property gbSummaryPage As Boolean
			Get
				Return Me.m_gbSummaryPage
			End Get
			Set(value As Boolean)
				Me.m_gbSummaryPage = value
			End Set
		End Property

		Public Property gbScoringPage As Boolean
			Get
				Return Me.m_gbScoringPage
			End Get
			Set(value As Boolean)
				Me.m_gbScoringPage = value
			End Set
		End Property

		Public Property gbCoverPage As Boolean
			Get
				Return Me.m_gbCoverPage
			End Get
			Set(value As Boolean)
				Me.m_gbCoverPage = value
			End Set
		End Property

		Public Property gbOrderPage As Boolean
			Get
				Return Me.m_gbOrderPage
			End Get
			Set(value As Boolean)
				Me.m_gbOrderPage = value
			End Set
		End Property

		Public Property gbReportData As Boolean
			Get
				Return Me.m_gbReportData
			End Get
			Set(value As Boolean)
				Me.m_gbReportData = value
			End Set
		End Property

		Public Property gbReportDiagnosis As Boolean
			Get
				Return Me.m_gbReportDiagnosis
			End Get
			Set(value As Boolean)
				Me.m_gbReportDiagnosis = value
			End Set
		End Property

		Public Property gbReportDynoPred As Boolean
			Get
				Return Me.m_gbReportDynoPred
			End Get
			Set(value As Boolean)
				Me.m_gbReportDynoPred = value
			End Set
		End Property

		Public Property gbReportDynoActual As Boolean
			Get
				Return Me.m_gbReportDynoActual
			End Get
			Set(value As Boolean)
				Me.m_gbReportDynoActual = value
			End Set
		End Property

		Public Property gbReportIPR As Boolean
			Get
				Return Me.m_gbReportIPR
			End Get
			Set(value As Boolean)
				Me.m_gbReportIPR = value
			End Set
		End Property

		Public Property gbReportSinglePageDynoTorque As Boolean
			Get
				Return Me.m_gbReportSinglePageDynoTorque
			End Get
			Set(value As Boolean)
				Me.m_gbReportSinglePageDynoTorque = value
			End Set
		End Property

		Public Property gbReportTorque As Boolean
			Get
				Return Me.m_gbReportTorque
			End Get
			Set(value As Boolean)
				Me.m_gbReportTorque = value
			End Set
		End Property

		Public Property gbReportDevChart As Boolean
			Get
				Return Me.m_gbReportDevChart
			End Get
			Set(value As Boolean)
				Me.m_gbReportDevChart = value
			End Set
		End Property

		Public Property gbReportGuide As Boolean
			Get
				Return Me.m_gbReportGuide
			End Get
			Set(value As Boolean)
				Me.m_gbReportGuide = value
			End Set
		End Property

		Public Property gbReportDevSurvey As Boolean
			Get
				Return Me.m_gbReportDevSurvey
			End Get
			Set(value As Boolean)
				Me.m_gbReportDevSurvey = value
			End Set
		End Property

		Public Property NumRods As Short
			Get
				Return Me.m_NumRods
			End Get
			Set(value As Short)
				Me.m_NumRods = value
			End Set
		End Property

		Public Property Sections As RSWIN_DESC.RodSection()
			Get
				Return Me.m_Sections
			End Get
			Set(value As RSWIN_DESC.RodSection())
				Me.m_Sections = value
			End Set
		End Property

		Public Property ServiceFactor As Single
			Get
				Return Me.m_ServiceFactor
			End Get
			Set(value As Single)
				Me.m_ServiceFactor = value
			End Set
		End Property

		Public Property minStressBot As Single()
			Get
				Return Me.m_minStressBot
			End Get
			Set(value As Single())
				Me.m_minStressBot = value
			End Set
		End Property

		Public Property maxStressBot As Single()
			Get
				Return Me.m_maxStressBot
			End Get
			Set(value As Single())
				Me.m_maxStressBot = value
			End Set
		End Property

		Public Property minStressTop As Single()
			Get
				Return Me.m_minStressTop
			End Get
			Set(value As Single())
				Me.m_minStressTop = value
			End Set
		End Property

		Public Property maxStressTop As Single()
			Get
				Return Me.m_maxStressTop
			End Get
			Set(value As Single())
				Me.m_maxStressTop = value
			End Set
		End Property

		Public Property StressL As Single()
			Get
				Return Me.m_StressL
			End Get
			Set(value As Single())
				Me.m_StressL = value
			End Set
		End Property

		Public Property MaxRodStressL As Single
			Get
				Return Me.m_MaxRodStressL
			End Get
			Set(value As Single)
				Me.m_MaxRodStressL = value
			End Set
		End Property

		Public Property WrodsInAir As Single
			Get
				Return Me.m_WrodsInAir
			End Get
			Set(value As Single)
				Me.m_WrodsInAir = value
			End Set
		End Property

		Public Property WrodsInFluid As Single
			Get
				Return Me.m_WrodsInFluid
			End Get
			Set(value As Single)
				Me.m_WrodsInFluid = value
			End Set
		End Property

		Public Property gbSteelRodString As Boolean
			Get
				Return Me.m_gbSteelRodString
			End Get
			Set(value As Boolean)
				Me.m_gbSteelRodString = value
			End Set
		End Property

		Public Property CalcUDFriction As Boolean
			Get
				Return Me.m_CalcUDFriction
			End Get
			Set(value As Boolean)
				Me.m_CalcUDFriction = value
			End Set
		End Property

		Public Property DownstrokeFriction As Single
			Get
				Return Me.m_DownstrokeFriction
			End Get
			Set(value As Single)
				Me.m_DownstrokeFriction = value
			End Set
		End Property

		Public Property DownstrokeFrictionAverage As Single
			Get
				Return Me.m_DownstrokeFrictionAverage
			End Get
			Set(value As Single)
				Me.m_DownstrokeFrictionAverage = value
			End Set
		End Property

		Public Property DownstrokeFrictionFactor As Single
			Get
				Return Me.m_DownstrokeFrictionFactor
			End Get
			Set(value As Single)
				Me.m_DownstrokeFrictionFactor = value
			End Set
		End Property

		Public Property DownstrokeFrictionRemoved As Single
			Get
				Return Me.m_DownstrokeFrictionRemoved
			End Get
			Set(value As Single)
				Me.m_DownstrokeFrictionRemoved = value
			End Set
		End Property

		Public Property FluidVelocity As Single
			Get
				Return Me.m_FluidVelocity
			End Get
			Set(value As Single)
				Me.m_FluidVelocity = value
			End Set
		End Property

		Public Property Friction As Single
			Get
				Return Me.m_Friction
			End Get
			Set(value As Single)
				Me.m_Friction = value
			End Set
		End Property

		Public Property Counterbalance As Single
			Get
				Return Me.m_Counterbalance
			End Get
			Set(value As Single)
				Me.m_Counterbalance = value
			End Set
		End Property

		Public Property CrankHole As Short
			Get
				Return Me.m_CrankHole
			End Get
			Set(value As Short)
				Me.m_CrankHole = value
			End Set
		End Property

		Public Property Rotation As Short
			Get
				Return Me.m_Rotation
			End Get
			Set(value As Short)
				Me.m_Rotation = value
			End Set
		End Property

		Public Property Unbalance As Single
			Get
				Return Me.m_Unbalance
			End Get
			Set(value As Single)
				Me.m_Unbalance = value
			End Set
		End Property

		Public Property MaxPinSizeSect As Short
			Get
				Return Me.m_MaxPinSizeSect
			End Get
			Set(value As Short)
				Me.m_MaxPinSizeSect = value
			End Set
		End Property

		Public Property UpstrokeFriction As Single
			Get
				Return Me.m_UpstrokeFriction
			End Get
			Set(value As Single)
				Me.m_UpstrokeFriction = value
			End Set
		End Property

		Public Property SlideFricCoeff As Single
			Get
				Return Me.m_SlideFricCoeff
			End Get
			Set(value As Single)
				Me.m_SlideFricCoeff = value
			End Set
		End Property

		Public Property UpstrokeFrictionAverage As Single
			Get
				Return Me.m_UpstrokeFrictionAverage
			End Get
			Set(value As Single)
				Me.m_UpstrokeFrictionAverage = value
			End Set
		End Property

		Public Property UpstrokeFrictionRemoved As Single
			Get
				Return Me.m_UpstrokeFrictionRemoved
			End Get
			Set(value As Single)
				Me.m_UpstrokeFrictionRemoved = value
			End Set
		End Property

		Public Property UpstrokeFrictionFactor As Single
			Get
				Return Me.m_UpstrokeFrictionFactor
			End Get
			Set(value As Single)
				Me.m_UpstrokeFrictionFactor = value
			End Set
		End Property

		Public Property gbCalcFriction As Boolean
			Get
				Return Me.m_gbCalcFriction
			End Get
			Set(value As Boolean)
				Me.m_gbCalcFriction = value
				Me.m_CalcFriction = If((-If((value > False), 1S, 0S)), 1S, 0S)
			End Set
		End Property

		Public Property gbCalcSlideFricCoeff As Boolean
			Get
				Return Me.m_gbCalcSlideFricCoeff
			End Get
			Set(value As Boolean)
				Me.m_gbCalcSlideFricCoeff = value
			End Set
		End Property

		Public Property gbIncludeBuoyancy As Boolean
			Get
				Return Me.m_gbIncludeBuoyancy
			End Get
			Set(value As Boolean)
				Me.m_gbIncludeBuoyancy = value
			End Set
		End Property

		Public Property PumpFriction As Single
			Get
				Return Me.m_PumpFriction
			End Get
			Set(value As Single)
				Me.m_PumpFriction = value
			End Set
		End Property

		Public Property Mprload As Single
			Get
				Return Me.m_Mprload
			End Get
			Set(value As Single)
				Me.m_Mprload = value
			End Set
		End Property

		Public Property Pprload As Single
			Get
				Return Me.m_Pprload
			End Get
			Set(value As Single)
				Me.m_Pprload = value
			End Set
		End Property

		Public Property StructL As Single
			Get
				Return Me.m_StructL
			End Get
			Set(value As Single)
				Me.m_StructL = value
			End Set
		End Property

		Public Property FluidInertiaScore As Single
			Get
				Return Me.m_FluidInertiaScore
			End Get
			Set(value As Single)
				Me.m_FluidInertiaScore = value
			End Set
		End Property

		Public Property pPRHP As Single
			Get
				Return Me.m_pPRHP
			End Get
			Set(value As Single)
				Me.m_pPRHP = value
			End Set
		End Property

		Public Property SurfLoadShift As Single
			Get
				Return Me.m_SurfLoadShift
			End Get
			Set(value As Single)
				Me.m_SurfLoadShift = value
			End Set
		End Property

		Public Property SurfLoadShiftPct As Single
			Get
				Return Me.m_SurfLoadShiftPct
			End Get
			Set(value As Single)
				Me.m_SurfLoadShiftPct = value
			End Set
		End Property

		Public Property SurfScore As Single
			Get
				Return Me.m_SurfScore
			End Get
			Set(value As Single)
				Me.m_SurfScore = value
			End Set
		End Property

		Public Property CBE90 As Single()
			Get
				Return Me.m_CBE90
			End Get
			Set(value As Single())
				Me.m_CBE90 = value
			End Set
		End Property

		Public Property Clf As Single()
			Get
				Return Me.m_Clf
			End Get
			Set(value As Single())
				Me.m_Clf = value
			End Set
		End Property

		Public Property GearboxLoading As Single()
			Get
				Return Me.m_GearboxLoading
			End Get
			Set(value As Single())
				Me.m_GearboxLoading = value
			End Set
		End Property

		Public Property PeakTorque As Single()
			Get
				Return Me.m_PeakTorque
			End Get
			Set(value As Single())
				Me.m_PeakTorque = value
			End Set
		End Property

		Public Property fTf(index As Integer) As Single
			Get
				Return Me.m_Tf(index)
			End Get
			Set(value As Single)
				Me.m_Tf(index) = value
			End Set
		End Property

		Public Property Tf As Single()
			Get
				Return Me.m_Tf
			End Get
			Set(value As Single())
				Me.m_Tf = value
			End Set
		End Property

		Public Property fThetac(index As Integer) As Single
			Get
				Return Me.m_Thetac(index)
			End Get
			Set(value As Single)
				Me.m_Thetac(index) = value
			End Set
		End Property

		Public Property Thetac As Single()
			Get
				Return Me.m_Thetac
			End Get
			Set(value As Single())
				Me.m_Thetac = value
			End Set
		End Property

		Public Property fTnet(index1 As Integer, index2 As Integer) As Single
			Get
				Return Me.m_Tnet(index1, index2)
			End Get
			Set(value As Single)
				Me.m_Tnet(index1, index2) = value
			End Set
		End Property

		Public Property Tnet As Single(,)
			Get
				Return Me.m_Tnet
			End Get
			Set(value As Single(,))
				Me.m_Tnet = value
			End Set
		End Property

		Public Property TubingAnchored As Short
			Get
				Return Me.m_TubingAnchored
			End Get
			Set(value As Short)
				Me.m_TubingAnchored = value
			End Set
		End Property

		Public Property TubingAnchorDepth As Single
			Get
				Return Me.m_TubingAnchorDepth
			End Get
			Set(value As Single)
				Me.m_TubingAnchorDepth = value
			End Set
		End Property

		Public Property TubingID As Single
			Get
				Return Me.m_TubingID
			End Get
			Set(value As Single)
				Me.m_TubingID = value
			End Set
		End Property

		Public Property TubingOD As Single
			Get
				Return Me.m_TubingOD
			End Get
			Set(value As Single)
				Me.m_TubingOD = value
			End Set
		End Property

		Public Property ACompanyName As String
			Get
				Return Me.m_ACompanyName
			End Get
			Set(value As String)
				Me.m_ACompanyName = value
			End Set
		End Property

		Public Property WellName As String
			Get
				Return Me.m_WellName
			End Get
			Set(value As String)
				Me.m_WellName = value
			End Set
		End Property

		Public Property UserName As String
			Get
				Return Me.m_UserName
			End Get
			Set(value As String)
				Me.m_UserName = value
			End Set
		End Property

		Public Property UserDate As String
			Get
				Return Me.m_UserDate
			End Get
			Set(value As String)
				Me.m_UserDate = value
			End Set
		End Property

		Public Property FileComment As String
			Get
				Return Me.m_FileComment
			End Get
			Set(value As String)
				Me.m_FileComment = value
			End Set
		End Property

		Public Property IncludeFluidInertia As Short
			Get
				Return Conversions.ToShort(Me.m_IncludeFluidInertia)
			End Get
			Set(value As Short)
				Me.m_IncludeFluidInertia = value
			End Set
		End Property

		Public Property mhMotorDB As Short
			Get
				Return Me.m_mhMotorDB
			End Get
			Set(value As Short)
				Me.m_mhMotorDB = value
			End Set
		End Property

		Public Property mlMotorKindOffset As Integer
			Get
				Return Me.m_mlMotorKindOffset
			End Get
			Set(value As Integer)
				Me.m_mlMotorKindOffset = value
			End Set
		End Property

		Public Property mlMotorSizeOffset As Integer
			Get
				Return Me.m_mlMotorSizeOffset
			End Get
			Set(value As Integer)
				Me.m_mlMotorSizeOffset = value
			End Set
		End Property

		Public Property mlMotorSettingOffset As Integer
			Get
				Return Me.m_mlMotorSettingOffset
			End Get
			Set(value As Integer)
				Me.m_mlMotorSettingOffset = value
			End Set
		End Property

		Public Property mlMotorCurveOffset As Integer
			Get
				Return Me.m_mlMotorCurveOffset
			End Get
			Set(value As Integer)
				Me.m_mlMotorCurveOffset = value
			End Set
		End Property

		Public Property alMotorKindTable As Integer()
			Get
				Return Me.m_alMotorKindTable
			End Get
			Set(value As Integer())
				Me.m_alMotorKindTable = value
			End Set
		End Property

		Public Property alMotorSizeTable As Integer()
			Get
				Return Me.m_alMotorSizeTable
			End Get
			Set(value As Integer())
				Me.m_alMotorSizeTable = value
			End Set
		End Property

		Public Property alMotorSettingTable As Integer()
			Get
				Return Me.m_alMotorSettingTable
			End Get
			Set(value As Integer())
				Me.m_alMotorSettingTable = value
			End Set
		End Property

		Public Property asMotorKindList As String()
			Get
				Return Me.m_asMotorKindList
			End Get
			Set(value As String())
				Me.m_asMotorKindList = value
			End Set
		End Property

		Public Property mfFullLoadSpeed As Single
			Get
				Return Me.m_mfFullLoadSpeed
			End Get
			Set(value As Single)
				Me.m_mfFullLoadSpeed = value
			End Set
		End Property

		Public Property mfMaxLoad As Single
			Get
				Return Me.m_mfMaxLoad
			End Get
			Set(value As Single)
				Me.m_mfMaxLoad = value
			End Set
		End Property

		Public Property mfMaxSPV As Single
			Get
				Return Me.m_mfMaxSPV
			End Get
			Set(value As Single)
				Me.m_mfMaxSPV = value
			End Set
		End Property

		Public Property mfRatedHP As Single
			Get
				Return Me.m_mfRatedHP
			End Get
			Set(value As Single)
				Me.m_mfRatedHP = value
			End Set
		End Property

		Public Property miFirstSetting As Short
			Get
				Return Me.m_miFirstSetting
			End Get
			Set(value As Short)
				Me.m_miFirstSetting = value
			End Set
		End Property

		Public Property miFirstSize As Short
			Get
				Return Me.m_miFirstSize
			End Get
			Set(value As Short)
				Me.m_miFirstSize = value
			End Set
		End Property

		Public Property miMotorKind As Short
			Get
				Return Me.m_miMotorKind
			End Get
			Set(value As Short)
				Me.m_miMotorKind = value
			End Set
		End Property

		Public Property miMotorSetting As Short
			Get
				Return Me.m_miMotorSetting
			End Get
			Set(value As Short)
				Me.m_miMotorSetting = value
			End Set
		End Property

		Public Property miMotorSize As Short
			Get
				Return Me.m_miMotorSize
			End Get
			Set(value As Short)
				Me.m_miMotorSize = value
			End Set
		End Property

		Public Property mnMotorSettings As Short
			Get
				Return Me.m_mnMotorSettings
			End Get
			Set(value As Short)
				Me.m_mnMotorSettings = value
			End Set
		End Property

		Public Property MotorSize As Short
			Get
				Return Me.m_MotorSize
			End Get
			Set(value As Short)
				Me.m_MotorSize = value
			End Set
		End Property

		Public Property MotorType As Short
			Get
				Return Me.m_MotorType
			End Get
			Set(value As Short)
				Me.m_MotorType = value
			End Set
		End Property

		Public Property MotorSetting As Short
			Get
				Return Me.m_MotorSetting
			End Get
			Set(value As Short)
				Me.m_MotorSetting = value
			End Set
		End Property

		Public Property mnMotorSizes As Short
			Get
				Return Me.m_mnMotorSizes
			End Get
			Set(value As Short)
				Me.m_mnMotorSizes = value
			End Set
		End Property

		Public Property msMotorKindName As String
			Get
				Return Me.m_msMotorKindName
			End Get
			Set(value As String)
				Me.m_msMotorKindName = value
			End Set
		End Property

		Public Property msMotorSettingName As String
			Get
				Return Me.m_msMotorSettingName
			End Get
			Set(value As String)
				Me.m_msMotorSettingName = value
			End Set
		End Property

		Public Property msMotorSizeName As String
			Get
				Return Me.m_msMotorSizeName
			End Get
			Set(value As String)
				Me.m_msMotorSizeName = value
			End Set
		End Property

		Public Property mnMotorCurvePoints As Short
			Get
				Return Me.m_mnMotorCurvePoints
			End Get
			Set(value As Short)
				Me.m_mnMotorCurvePoints = value
			End Set
		End Property

		Public Property mfTorque As Single()
			Get
				Return Me.m_mfTorque
			End Get
			Set(value As Single())
				Me.m_mfTorque = value
			End Set
		End Property

		Public Property mfEfficiency As Single()
			Get
				Return Me.m_mfEfficiency
			End Get
			Set(value As Single())
				Me.m_mfEfficiency = value
			End Set
		End Property

		Public Property CalcMotorSPV As Short
			Get
				Return Me.m_CalcMotorSPV
			End Get
			Set(value As Short)
				Me.m_CalcMotorSPV = value
				If value <> -1S And value <> 0S Then
					Me.m_CalcMotorSPV = 0S
				End If
			End Set
		End Property

		Public Property IrotEntered As Short
			Get
				Return Me.m_IrotEntered
			End Get
			Set(value As Short)
				Me.m_IrotEntered = value
			End Set
		End Property

		Public Property CalcPlungerSize As Short
			Get
				Return Me.m_CalcPlungerSize
			End Get
			Set(value As Short)
				Me.m_CalcPlungerSize = value
				If value <> -1S And value <> 0S Then
					Me.m_CalcPlungerSize = 0S
				End If
			End Set
		End Property

		Public Property SystemEff As Single
			Get
				Return Me.m_SystemEff
			End Get
			Set(value As Single)
				Me.m_SystemEff = value
			End Set
		End Property

		Public Property FluidLoad As Single
			Get
				Return Me.m_FluidLoad
			End Get
			Set(value As Single)
				Me.m_FluidLoad = value
			End Set
		End Property

		Public Property Pfill As Single
			Get
				Return Me.m_Pfill
			End Get
			Set(value As Single)
				Me.m_Pfill = value
			End Set
		End Property

		Public Property MaxSPM As Single
			Get
				Return Me.m_MaxSPM
			End Get
			Set(value As Single)
				Me.m_MaxSPM = value
			End Set
		End Property

		Public Property StuffingBoxFriction As Single
			Get
				Return Me.m_StuffingBoxFriction
			End Get
			Set(value As Single)
				Me.m_StuffingBoxFriction = value
			End Set
		End Property

		Public Property SPMEntered As Short
			Get
				Return Me.m_SPMEntered
			End Get
			Set(value As Short)
				Me.m_SPMEntered = value
			End Set
		End Property

		Public Property TargetBFPD As Single
			Get
				Return Me.m_TargetBFPD
			End Get
			Set(value As Single)
				Me.m_TargetBFPD = value
			End Set
		End Property

		Public Property PlungerLength As Single
			Get
				Return Me.m_PlungerLength
			End Get
			Set(value As Single)
				Me.m_PlungerLength = value
			End Set
		End Property

		Public Property ProductionLoss As Single
			Get
				Return Me.m_ProductionLoss
			End Get
			Set(value As Single)
				Me.m_ProductionLoss = value
			End Set
		End Property

		Public Property PumpLength As Single
			Get
				Return Me.m_PumpLength
			End Get
			Set(value As Single)
				Me.m_PumpLength = value
			End Set
		End Property

		Public Property PumpSpacing As Single
			Get
				Return Me.m_PumpSpacing
			End Get
			Set(value As Single)
				Me.m_PumpSpacing = value
			End Set
		End Property

		Public Property TubStretch As Single
			Get
				Return Me.m_TubStretch
			End Get
			Set(value As Single)
				Me.m_TubStretch = value
			End Set
		End Property

		Public Property gbCalcPumpCondition As Boolean
			Get
				Return Me.m_gbCalcPumpCondition
			End Get
			Set(value As Boolean)
				Me.m_gbCalcPumpCondition = value
			End Set
		End Property

		Public Property PumpCondition As Short
			Get
				Return Me.m_PumpCondition
			End Get
			Set(value As Short)
				Me.m_PumpCondition = value
			End Set
		End Property

		Public Property PumpFillage As Single
			Get
				Return Me.m_PumpFillage
			End Get
			Set(value As Single)
				Me.m_PumpFillage = value
			End Set
		End Property

		Public Property Srad As Single
			Get
				Return Me.m_Srad
			End Get
			Set(value As Single)
				Me.m_Srad = value
			End Set
		End Property

		Public Property StrokeFeet As Single
			Get
				Return Me.m_StrokeFeet
			End Get
			Set(value As Single)
				Me.m_StrokeFeet = value
			End Set
		End Property

		Public Property gbReportCostAnalysis As Short
			Get
				Return Me.m_gbReportCostAnalysis
			End Get
			Set(value As Short)
				Me.m_gbReportCostAnalysis = value
			End Set
		End Property

		Public Property giRodDesignStyle As Short
			Get
				Return Me.m_giRodDesignStyle
			End Get
			Set(value As Short)
				Me.m_giRodDesignStyle = value
			End Set
		End Property

		Public Property RodStringType As Short
			Get
				Return Me.m_RodStringType
			End Get
			Set(value As Short)
				Me.m_RodStringType = value
			End Set
		End Property

		Public Property RSExtraCost As Single
			Get
				Return Me.m_RSExtraCost
			End Get
			Set(value As Single)
				Me.m_RSExtraCost = value
			End Set
		End Property

		Public Property RSExtraCostLabel As String
			Get
				Return Me.m_RSExtraCostLabel
			End Get
			Set(value As String)
				Me.m_RSExtraCostLabel = value
			End Set
		End Property

		Public Property APIRod As Short
			Get
				Return Me.m_APIRod
			End Get
			Set(value As Short)
				Me.m_APIRod = value
			End Set
		End Property

		Public Property APIGrade As Short
			Get
				Return Me.m_APIGrade
			End Get
			Set(value As Short)
				Me.m_APIGrade = value
			End Set
		End Property

		Public Property APIRodType As String
			Get
				Return Me.m_APIRodType
			End Get
			Set(value As String)
				Me.m_APIRodType = value
			End Set
		End Property

		Public Property APITensileStrength As Single
			Get
				Return Me.m_APITensileStrength
			End Get
			Set(value As Single)
				Me.m_APITensileStrength = value
			End Set
		End Property

		Public Property FoSkr As Single
			Get
				Return Me.m_FoSkr
			End Get
			Set(value As Single)
				Me.m_FoSkr = value
			End Set
		End Property

		Public Property Fc As Single
			Get
				Return Me.m_Fc
			End Get
			Set(value As Single)
				Me.m_Fc = value
			End Set
		End Property

		Public Property No As Single
			Get
				Return Me.m_No
			End Get
			Set(value As Single)
				Me.m_No = value
			End Set
		End Property

		Public Property NoverNoP As Single
			Get
				Return Me.m_NoverNoP
			End Get
			Set(value As Single)
				Me.m_NoverNoP = value
			End Set
		End Property

		Public Property RodstringL As Single
			Get
				Return Me.m_RodstringL
			End Get
			Set(value As Single)
				Me.m_RodstringL = value
			End Set
		End Property

		Public Property RSFGIncludeSteel As Short
			Get
				Return Me.m_RSFGIncludeSteel
			End Get
			Set(value As Short)
				Me.m_RSFGIncludeSteel = value
			End Set
		End Property

		Public Property RSIncludeSB As Short
			Get
				Return Me.m_RSIncludeSB
			End Get
			Set(value As Short)
				Me.m_RSIncludeSB = value
			End Set
		End Property

		Public Property RSFGGrade As Short
			Get
				Return Me.m_RSFGGrade
			End Get
			Set(value As Short)
				Me.m_RSFGGrade = value
			End Set
		End Property

		Public Property RSGrade As Short
			Get
				Return Me.m_RSGrade
			End Get
			Set(value As Short)
				Me.m_RSGrade = value
			End Set
		End Property

		Public Property RSRodType As String
			Get
				Return Me.m_RSRodType
			End Get
			Set(value As String)
				Me.m_RSRodType = value
			End Set
		End Property

		Public Property RSTensileStrength As Single
			Get
				Return Me.m_RSTensileStrength
			End Get
			Set(value As Single)
				Me.m_RSTensileStrength = value
			End Set
		End Property

		Public Property RSSuckerRodLength As Single
			Get
				Return Me.m_RSSuckerRodLength
			End Get
			Set(value As Single)
				Me.m_RSSuckerRodLength = value
			End Set
		End Property

		Public Property RSMaxSize As Single
			Get
				Return Me.m_RSMaxSize
			End Get
			Set(value As Single)
				Me.m_RSMaxSize = value
			End Set
		End Property

		Public Property RSSRSize As Single
			Get
				Return Me.m_RSSRSize
			End Get
			Set(value As Single)
				Me.m_RSSRSize = value
			End Set
		End Property

		Public Property RSMinSize As Single
			Get
				Return Me.m_RSMinSize
			End Get
			Set(value As Single)
				Me.m_RSMinSize = value
			End Set
		End Property

		Public Property RSFricCoef As Single
			Get
				Return Me.m_RSFricCoef
			End Get
			Set(value As Single)
				Me.m_RSFricCoef = value
			End Set
		End Property

		Public Property RSRodGuide As Integer
			Get
				Return Me.m_RSRodGuide
			End Get
			Set(value As Integer)
				Me.m_RSRodGuide = value
			End Set
		End Property

		Public Property RSSBGrade As Short
			Get
				Return Me.m_RSSBGrade
			End Get
			Set(value As Short)
				Me.m_RSSBGrade = value
			End Set
		End Property

		Public Property RSSBDiameter As Single
			Get
				Return Me.m_RSSBDiameter
			End Get
			Set(value As Single)
				Me.m_RSSBDiameter = value
			End Set
		End Property

		Public Property RSSBLength As Single
			Get
				Return Me.m_RSSBLength
			End Get
			Set(value As Single)
				Me.m_RSSBLength = value
			End Set
		End Property

		Public Property SinkerRods As Boolean
			Get
				Return Me.m_SinkerRods
			End Get
			Set(value As Boolean)
				Me.m_SinkerRods = value
			End Set
		End Property

		Public Property FGPercent As Single
			Get
				Return Me.m_FGPercent
			End Get
			Set(value As Single)
				Me.m_FGPercent = value
			End Set
		End Property

		Public Property LargestFG As Single
			Get
				Return Me.m_LargestFG
			End Get
			Set(value As Single)
				Me.m_LargestFG = value
			End Set
		End Property

		Public Property SinkerBar As RSWIN_DESC.RodSection
			Get
				Return Me.m_SinkerBar
			End Get
			Set(value As RSWIN_DESC.RodSection)
				Me.m_SinkerBar = value
			End Set
		End Property

		Public Property CalcFriction As Short
			Get
				Return Me.m_CalcFriction
			End Get
			Set(value As Short)
				Me.m_CalcFriction = value
				If value <> -1S And value <> 0S Then
					Me.m_CalcFriction = 0S
				End If
				Me.m_gbCalcFriction = (Me.m_CalcFriction <> 0S)
			End Set
		End Property

		Public Property prvel As Single()
			Get
				Return Me.m_prvel
			End Get
			Set(value As Single())
				Me.m_prvel = value
			End Set
		End Property

		Public Property APITable As Single(,)
			Get
				Return Me.m_APITable
			End Get
			Set(value As Single(,))
				Me.m_APITable = value
			End Set
		End Property

		Public Property WarnedAboutBFPD As Boolean
			Get
				Return Me.m_WarnedAboutBFPD
			End Get
			Set(value As Boolean)
				Me.m_WarnedAboutBFPD = value
			End Set
		End Property

		Public Property WarnedAboutFluidInertia As Boolean
			Get
				Return Me.m_WarnedAboutFluidInertia
			End Get
			Set(value As Boolean)
				Me.m_WarnedAboutFluidInertia = value
			End Set
		End Property

		Public Property WarnedAboutFoSkr As Boolean
			Get
				Return Me.m_WarnedAboutFoSkr
			End Get
			Set(value As Boolean)
				Me.m_WarnedAboutFoSkr = value
			End Set
		End Property

		Public Property WarnedAboutLowSPM As Boolean
			Get
				Return Me.m_WarnedAboutLowSPM
			End Get
			Set(value As Boolean)
				Me.m_WarnedAboutLowSPM = value
			End Set
		End Property

		Public Property WarnedAboutHighSPM As Boolean
			Get
				Return Me.m_WarnedAboutHighSPM
			End Get
			Set(value As Boolean)
				Me.m_WarnedAboutHighSPM = value
			End Set
		End Property

		Public Property WarnedAboutLowPumpEfficiency As Boolean
			Get
				Return Me.m_WarnedAboutLowPumpEfficiency
			End Get
			Set(value As Boolean)
				Me.m_WarnedAboutLowPumpEfficiency = value
			End Set
		End Property

		Public Property WarnedAboutLowPumpFillage As Boolean
			Get
				Return Me.m_WarnedAboutLowPumpFillage
			End Get
			Set(value As Boolean)
				Me.m_WarnedAboutLowPumpFillage = value
			End Set
		End Property

		Public Property WarnedAboutPlungerSize As Boolean
			Get
				Return Me.m_WarnedAboutPlungerSize
			End Get
			Set(value As Boolean)
				Me.m_WarnedAboutPlungerSize = value
			End Set
		End Property

		Public Property WarnedAboutLargeNtsteps As Boolean
			Get
				Return Me.m_WarnedAboutLargeNtsteps
			End Get
			Set(value As Boolean)
				Me.m_WarnedAboutLargeNtsteps = value
			End Set
		End Property

		Public Property WarnedAboutUHSMotor As Boolean
			Get
				Return Me.m_WarnedAboutUHSMotor
			End Get
			Set(value As Boolean)
				Me.m_WarnedAboutUHSMotor = value
			End Set
		End Property

		Public Property FluidLevelEntered As Boolean
			Get
				Return Me.m_FluidLevelEntered
			End Get
			Set(value As Boolean)
				Me.m_FluidLevelEntered = value
			End Set
		End Property

		Public Property gbCalcPumpIntakePressure As Boolean
			Get
				Return Me.m_gbCalcPumpIntakePressure
			End Get
			Set(value As Boolean)
				Me.m_gbCalcPumpIntakePressure = value
			End Set
		End Property

		Public Property gbCalcTargetBFPD As Boolean
			Get
				Return Me.m_gbCalcTargetBFPD
			End Get
			Set(value As Boolean)
				Me.m_gbCalcTargetBFPD = value
			End Set
		End Property

		Public Property gbPrintBatchLog As Boolean
			Get
				Return Me.m_gbPrintBatchLog
			End Get
			Set(value As Boolean)
				Me.m_gbPrintBatchLog = value
			End Set
		End Property

		Public Property gbBatch As Boolean
			Get
				Return Me.m_gbBatch
			End Get
			Set(value As Boolean)
				Me.m_gbBatch = value
			End Set
		End Property

		Public Property gbAutomatic As Boolean
			Get
				Return Me.m_gbAutomatic
			End Get
			Set(value As Boolean)
				Me.m_gbAutomatic = value
			End Set
		End Property

		Public Sub SetClassDefaults(Optional bNew As Boolean = False)
			Try
				RSWIN_DESC.sNull = ""
				RSWIN_DESC.RSMagic = "RODSTAR" & vbCrLf & ChrW(26)
				RSWIN_DESC.XDMagic = "XDIAG" & vbCrLf & ChrW(26)
				RSWIN_DESC.RDMagic = "RODDIAG" & vbCrLf & ChrW(26)
				RSWIN_DESC.CBMagic = "CBALANCE" & vbCrLf & ChrW(26)
				Try
					Me.m_CBLDir = FileSystem.CurDir()
					Me.m_DYNDir = FileSystem.CurDir()
					Me.m_XDGDir = FileSystem.CurDir()
					Me.m_RSTDir = FileSystem.CurDir()
					If RSWIN_DESC.bExpert Then
						If RSWIN_DESC.SETUP_bGuru Then
							Me.m_RSTDir = Conversions.ToString(RSWIN.GetInitialDir(".XRVX", ""))
						Else
							Me.m_RSTDir = Conversions.ToString(RSWIN.GetInitialDir(".RSVX", ""))
						End If
					End If
				Catch ex As Exception
					Dim sMsg As String = "Error setting directories: " + ex.Message
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				End Try
				Try
					Dim sDefaultName As String = "CompanyName"
					Dim vNotPresentDefault As Object = VariantType.[String]
					Dim flag As Boolean = False
					Me.m_ACompanyName = Conversions.ToString(ini.GetDefault(sDefaultName, vNotPresentDefault, flag))
					If Information.IsDBNull(Me.m_ACompanyName) Then
						Me.m_ACompanyName = ""
					End If
					Me.m_ACompanyName = Me.m_ACompanyName.PadRight(40, " "c)
				Catch ex2 As Exception
				End Try
				Try
					Me.m_WellName = ""
					Me.m_WellName = Me.m_WellName.PadRight(40, " "c)
				Catch ex3 As Exception
				End Try
				Try
					Dim sDefaultName2 As String = "UserName"
					Dim vNotPresentDefault2 As Object = VariantType.[String]
					Dim flag As Boolean = False
					Me.m_UserName = Conversions.ToString(ini.GetDefault(sDefaultName2, vNotPresentDefault2, flag))
					If Information.IsDBNull(Me.m_UserName) Then
						Me.m_UserName = ""
					End If
					Me.m_UserName = Me.m_UserName.PadRight(40, " "c)
				Catch ex4 As Exception
				End Try
				Try
					Me.m_UserDate = DateAndTime.Now.[Date].ToShortDateString()
					Me.m_UserDate = Me.m_UserDate.PadRight(40, " "c)
				Catch ex5 As Exception
				End Try
				Try
					Me.m_FileComment = ""
					Me.m_CoverPageComment = ""
					Me.m_PumpDepth = 0F
					Me.m_Runtime = ini.GetSingleDefault("RunTime", VariantType.[Single])
					Me.m_TubingPressure = ini.GetSingleDefault("TubingPressure", VariantType.[Single])
					Me.m_CasingPressure = ini.GetSingleDefault("CasingPressure", VariantType.[Single])
					If Me.m_CasingPressure = 0F Then
						Me.m_CasingPressure = Me.m_TubingPressure
					End If
					Me.m_WaterCut = ini.GetSingleDefault("WaterCut", VariantType.[Single])
					Me.m_WaterSPGR = ini.GetSingleDefault("WaterSPGR", VariantType.[Single])
					Me.m_OilAPI = ini.GetSingleDefault("OilGravity", VariantType.[Single])
					Me.m_OilSPGR = CSng((141.5 / (CDbl(Me.m_OilAPI) + 131.5)))
					Me.m_gbCalcFluidSPGR = False
					Me.m_FluidSPGR = 0F
					Me.m_DynaSource = 3S
					Me.m_PumpLoadAdj = 0F
					Me.m_gbInputDataChanged = False
					Me.m_gbDesignSinkerbar = False
				Catch ex6 As Exception
					Dim sMsg2 As String = "Error setting class defaults(1): " + ex6.Message
					Dim sMsgType2 As String = ""
					Dim bClosing2 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg2, sMsgType2, bClosing2, dialogResult)
				End Try
				Try
					Select Case Me.m_DynaSource
						Case 0S
							Me.m_dNtsteps = 0S
							Me.m_Npoints = 0S
						Case 1S, 2S
							Me.m_LeutertDynamometer = Conversions.ToShort(ini.GetDataValue("LeutertDynamometer", 11, False, False))
							If Me.m_LeutertDynamometer <> 0S Then
								Me.m_LeutertModel = ""
								Me.m_LeutertScale = 0F
								Me.m_LeutertSpring = 0S
							End If
							Me.m_Npoints = 0S
							Me.m_sDynoCard = ""
							Me.m_bCBEDigitized = 0S
							Me.m_BaselineLoad = 0F
							Me.m_CbeX = 0F
							Me.m_CbeY = 0F
							Me.m_LoadScale = 0F
							Me.m_bCBEFromDisk = 0S
							Me.m_dNtsteps = 0S
							Me.m_MeasuredRuntime = 0F
							Me.m_MeasuredSPM = 0F
							Me.m_MeasuredStroke = 0F
							Me.m_MeasuredCBEffect = 0F
							Me.m_MeasuredCBEpos = 0F
							Me.m_MeasuredCBEupstroke = 0S
							Me.m_MeasuredTVLoad = 0F
							Me.m_MeasuredSVLoad = 0F
						Case 3S
							Me.m_DynoCard = 0
							Me.m_DynaFile = ""
							Me.m_DynaFile = Me.m_DynaFile.PadLeft(128, " "c)
							Me.m_dNtsteps = 0S
							Me.m_sDynoCard = ""
							Me.m_bCBEFromDisk = 0S
							Me.m_MeasuredRuntime = 0F
							Me.m_MeasuredSPM = ini.GetSingleDefault("MeasuredSPM", VariantType.[Single])
							Me.m_MeasuredStroke = 0F
							Me.m_MeasuredCBEffect = 0F
							Me.m_MeasuredCBEpos = 0F
							Me.m_MeasuredCBEupstroke = 0S
							Me.m_MeasuredTVLoad = 0F
							Me.m_MeasuredSVLoad = 0F
							Me.m_Npoints = 0S
							If Me.m_MeasuredSPM > 0F Then
								Me.m_SPM = Me.m_MeasuredSPM
							End If
							If Me.m_MeasuredRuntime > 0F Then
								Me.m_Runtime = 24F * Me.m_MeasuredRuntime
							End If
						Case 6S
							Me.m_dNtsteps = 0S
					End Select
				Catch ex7 As Exception
					Dim sMsg3 As String = "Error setting class defaults(2)): " + ex7.Message
					Dim sMsgType3 As String = ""
					Dim bClosing3 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg3, sMsgType3, bClosing3, dialogResult)
				End Try
				Try
					If Me.m_DynaSource <> 0S Then
						Me.m_DynoDate = ""
					End If
					Me.m_gbClampOn = 0S
					Me.m_giDynoCorrectKinematic = 0S
					Me.m_giDynoCorrectPhase = 0S
					Me.m_gfDynoPhaseAdjustment = 0F
					Me.m_gfDynoTOSAdjustment = 0F
					Me.m_giDynoDetectKinematic = -1S
					Me.m_giDynoDetectPhase = -1S
					If RSWIN_DESC.bRodStarD Then
						Me.m_RodStringType = 2S
						Me.m_giRodDesignStyle = 0S
					Else
						Me.m_RodStringType = 3S
						Me.m_giRodDesignStyle = 0S
					End If
					Me.m_RSMaxSize = 1F
					Me.m_RSMinSize = 0.75F
					Me.m_RSSRSize = 1F
					Me.m_RSFricCoef = 0F
					Dim text As String = "GuideToUse"
					Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
					Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
					RSWIN_DESC.MOLDED = CShort(molded)
					RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
					Me.m_RSRodGuide = RSWIN_DESC.SETUP_GuideToUse
					RSWIN_DESC.mbMaxMinNotYetSet = Information.IsDBNull(RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 3, False, DBNull.Value)))
					If bNew Then
						Try
							Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("RSGrade", 3, False, DBNull.Value))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
								Me.m_RSGrade = Conversions.ToShort(obj)
								Me.m_RSRodType = Conversions.ToString(ini.GetDataValue("RSRodType", 8, False, ""))
							End If
						Catch ex8 As Exception
							Me.m_RSGrade = 0S
							Me.m_RSRodType = ""
						End Try
					End If
					Me.m_RSGrade = 0S
					Me.m_RSFGGrade = 0S
					Me.m_RSFGIncludeSteel = -1S
					If Me.m_RSFGIncludeSteel <> 0S Then
						Me.m_RSGrade = 0S
						Me.m_RSRodType = Conversions.ToString(0)
						Me.m_RSMaxSize = 0F
						Me.m_RSMinSize = 0F
						Me.m_RSSRSize = 0F
						Me.m_RSFricCoef = 0F
						Dim obj As Object = False
						If Operators.ConditionalCompareObjectEqual(obj, VariantType.Null, False) Then
							Me.m_RSIncludeSB = Not Me.RSFGIncludeSteel
						Else
							Me.m_RSIncludeSB = Conversions.ToShort(obj)
							If(Not Me.m_RSIncludeSB And Not Me.m_RSFGIncludeSteel) <> 0S Then
								Me.m_RSIncludeSB = -1S
							End If
						End If
						Me.m_RSSBGrade = 0S
						If Me.m_RSSBGrade = 0S Then
							Me.m_SinkerRods = False
						Else
							Me.m_SinkerBar.Grade = Me.m_RSSBGrade
							Me.m_SinkerBar.RodType = ""
							Me.m_RSSBDiameter = 0F
							If Me.m_RSSBDiameter <> 0F Then
								Me.m_SinkerBar.Diameter = Me.m_RSSBDiameter
							End If
						End If
						If Me.m_RSFGIncludeSteel <> 0S Then
							Me.m_RSSBLength = 0F
							If Me.m_RSSBLength <> 0F Then
								Me.m_SinkerBar.length = Me.m_RSSBLength
							End If
						End If
					End If
				Catch ex9 As Exception
					Dim sMsg4 As String = "Error setting class defaults(3): " + ex9.Message
					Dim sMsgType4 As String = ""
					Dim bClosing4 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg4, sMsgType4, bClosing4, dialogResult)
				End Try
				Me.m_RDNtsteps = 0S
				Me.m_RDSurfPos = New Single(0) {}
				Me.m_RDSurfLoad = New Single(0) {}
				Me.m_gbRoddiagFile = False
				Me.m_Ntsteps = 0S
				Me.m_dNtsteps = 0S
				Me.m_xNtsteps = 0S
				Me.m_RDNtsteps = 0S
				Me.m_pNtsteps = 0S
				Me.m_SurfPos = New Single(0) {}
				Me.m_SurfLoad = New Single(0) {}
				Me.m_PumpPos = New Single(0) {}
				Me.m_PumpLoad = New Single(0) {}
				Me.m_RDSurfPos = New Single(0) {}
				Me.m_RDSurfLoad = New Single(0) {}
				Me.m_dSurfPos = New Single(0) {}
				Me.m_dSurfLoad = New Single(0) {}
				Me.m_xSurfPos = New Single(0) {}
				Me.m_xSurfLoad = New Single(0) {}
				Me.m_pSurfPos = New Single(0) {}
				Me.m_pSurfLoad = New Single(0) {}
				Me.m_pPumpPos = New Single(0) {}
				Me.m_pPumpLoad = New Single(0) {}
				Me.m_Tf = New Single(0) {}
				Me.m_Thetac = New Single(0) {}
				Me.m_Tnet = New Single(0, 0) {}
				Try
					Me.m_NumRods = 0S
					Me.NumRods = Me.m_NumRods
					Me.m_Sections = New RSWIN_DESC.RodSection(40) {}
					Dim i As Integer = 1
					Do
						Me.m_Sections(i).Grade = 0S
						Me.m_Sections(i).RodType = ""
						Me.m_Sections(i).Diameter = 0F
						Me.m_Sections(i).length = 0F
						Me.m_Sections(i).Guide = 0S
						i += 1
					Loop While i <= 40
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(Me.NumRods)
					i = num
					While i <= numRods
						Dim num2 As Short = 0S
						If num2 <> 0S Then
							Me.m_Sections(i).Grade = num2
							Me.m_Sections(i).RodType = ""
							Me.m_Sections(i).Diameter = 0F
							Me.m_Sections(i).length = 0F
							Me.m_Sections(i).Guide = 0S
						End If
						i += 1
					End While
					Me.m_ServiceFactor = ini.GetSingleDefault("ServiceFactor", VariantType.[Single])
					Me.m_RSExtraCost = 0F
					Me.m_RSExtraCostLabel = ""
				Catch ex10 As Exception
					Dim sMsg5 As String = "Error setting class defaults(3): " + ex10.Message
					Dim sMsgType5 As String = ""
					Dim bClosing5 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg5, sMsgType5, bClosing5, dialogResult)
				End Try
				Try
					Me.m_CalcMotorSize = -1S
					Me.m_CalcMotorSPV = 0S
					Me.m_MotorSPV = 0F
					Me.m_Iart = Me.PU.ArtInertia
					Me.m_IrotEntered = -1S
					Me.m_MotorSetting = 0S
					Me.m_MotorSize = 0S
					Me.m_ElectricityCost = ini.GetSingleDefault("ElectricityCost", VariantType.[Single])
					Me.m_PowerMeterType = 1S
					Me.m_MotorType = CShort(ini.GetIntegerDefault("MotorType", VariantType.[Integer]))
					Me.m_MotorSize = 0S
					Me.m_MotorSetting = 0S
					Me.m_giFluidLevelSource = 0S
					If Me.m_giFluidLevelSource = 0S Then
						Me.m_giFluidLevelSource = 0S
					Else
						Select Case Me.m_giFluidLevelSource
							Case 1S
								Me.m_FluidLevel = 0F
							Case 2S
								Me.m_PumpIntakePressure = 0F
						End Select
					End If
					Me.m_SPM = ini.GetSingleDefault("PumpingSpeed", VariantType.[Single])
					Me.m_TargetBFPD = 0F
					Me.m_gbUseIPR = False
					Me.m_gbCalcFetkovichN = True
					Me.m_FetkovichN = -1F
					Me.m_giIPRMethod = 1S
					Try
						Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetListDefault("IPRMethod", 0, 1))
						If Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							obj = 1
						End If
						Me.m_giIPRMethod = Conversions.ToShort(obj)
					Catch ex11 As Exception
					End Try
					Me.m_MidPerfDepth = 0F
					Me.m_StaticBHPressure = 0F
					Me.m_BubblePoint = 0F
					Me.m_gbProducingBelowBPP = False
					Me.m_gnTestPoints = 0S
					If Me.m_gnTestPoints = 0S Then
						Me.m_TestPoints = New RSWIN_DESC.IPRTESTPOINT(0) {}
					Else
						Me.m_TestPoints = New RSWIN_DESC.IPRTESTPOINT(CInt((Me.m_gnTestPoints + 1S)) - 1) {}
					End If
					Dim num3 As Integer = 1
					Dim gnTestPoints As Integer = CInt(Me.m_gnTestPoints)
					For i As Integer = num3 To gnTestPoints
						Me.m_TestPoints(i).bPIEntered = Conversions.ToShort(ini.GetDataValue("PiEntered" + Conversions.ToString(i), 11, False, True))
						Me.m_TestPoints(i).Pintake = -1F
						Me.m_TestPoints(i).Pwf = -1F
						Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TestPointPressure" + Conversions.ToString(i), 4, False, 0))
						If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, 0, False))) Then
							If Me.m_TestPoints(i).bPIEntered <> 0S Then
								Me.m_TestPoints(i).Pintake = Conversions.ToSingle(obj)
							Else
								Me.m_TestPoints(i).Pwf = Conversions.ToSingle(obj)
							End If
						End If
						Me.m_TestPoints(i).Production = -1F
						obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TestPointProduction" + Conversions.ToString(i), 4, False, 0))
						If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, 0, False))) Then
							Me.m_TestPoints(i).Production = Conversions.ToSingle(obj)
						End If
					Next
				Catch ex12 As Exception
					Dim sMsg6 As String = "Error setting class defaults(4): " + ex12.Message
					Dim sMsgType6 As String = ""
					Dim bClosing6 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg6, sMsgType6, bClosing6, dialogResult)
				End Try
				Try
					If bNew Then
						Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TubingOD", 4, False, DBNull.Value))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							Me.m_TubingOD = Conversions.ToSingle(obj)
							obj = RuntimeHelpers.GetObjectValue(ini.GetDataValue("TubingID", 4, False, DBNull.Value))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
								Me.m_TubingID = Conversions.ToSingle(obj)
							Else
								Me.m_TubingID = 0F
							End If
						Else
							Me.m_TubingOD = 0F
							Me.m_TubingID = 0F
						End If
					Else
						Me.m_TubingOD = 0F
						Me.m_TubingID = 0F
					End If
					Me.m_PumpType = CShort(ini.GetIntegerDefault("PumpType", VariantType.[Integer]))
					Me.m_PlungerSize = ini.GetSingleDefault("PlungerSize", VariantType.[Single])
					Me.m_TubingAnchored = 0S
					Me.m_TubingAnchorDepth = Me.m_PumpDepth
					Dim sDefaultName3 As String = "IncludeBuoyancy"
					Dim vNotPresentDefault3 As Object = VariantType.[Boolean]
					Dim flag As Boolean = False
					Me.m_gbIncludeBuoyancy = Conversions.ToBoolean(ini.GetDefault(sDefaultName3, vNotPresentDefault3, flag))
					If RSWIN_DESC.bRodStarD Then
						Me.m_gbCalcFriction = False
						Me.m_CalcFriction = 0S
						Me.m_gbParaffin = False
						Me.m_ParaffinDepth = 0F
					Else
						Me.m_gbCalcFriction = True
						Me.m_CalcFriction = -1S
					End If
					Me.m_Friction = Conversions.ToSingle(ini.GetDataValue("Friction", 4, True, 0.5))
					Me.m_Counterbalance = 0F
					Me.m_CrankHole = 0S
					Me.m_Rotation = 0S
					Me.m_Unbalance = 0F
					Me.m_UnknownM = False
					Me.m_bUnknownUnbalance = True
					Me.m_PU.Manuf = ""
					Me.m_PU.UnitType = -1S
					Me.m_UnitID = Conversions.ToString(ini.GetDataValue("UnitID", 8, False, ""))
					Me.m_UnitName = Conversions.ToString(ini.GetDataValue("UnitName", 8, False, ""))
					Me.m_UnitID = Me.m_UnitID.PadRight(10, " "c)
					Me.m_UnitName = Me.m_UnitName.PadRight(40, " "c)
					If bNew Then
						Try
							Dim sDefaultName4 As String = "PolishedRodDiameter"
							Dim vNotPresentDefault4 As Object = 3
							flag = False
							Dim prdiameter As Integer = Conversions.ToInteger(ini.GetDefault(sDefaultName4, vNotPresentDefault4, flag))
							Me.m_PR_Diameter = RSWIN.SetPRDiameter(prdiameter)
						Catch ex13 As Exception
							Me.m_PR_Diameter = 1.5F
						End Try
					End If
					RSWIN_DESC.sCurrentFormName = ""
					RSWIN_DESC.bRunIconEnabled = False
					If RSWIN_DESC.bRodStarD Then
						RSWIN_DESC.SavedUpstrokeFriction = 0.1F
						RSWIN_DESC.SavedDownstrokeFriction = 0.1F
					End If
					RSWIN_DESC.bRodsInTubingMsgShown = False
					If bNew Then
						Me.m_gbOutputLoaded = False
					End If
					RSWIN_DESC.bReduceFricCoeff = False
					Try
						If RSWIN_DESC.bRodStarD Then
							RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
							MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile_Edit, Nothing)
							RSWIN_DESC.mdsDeviationProfile = Nothing
							MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
							RSWIN_DESC.bNewCaseAsked = False
							MImpred.bSurveyLimitWarningMsgShown = False
							MImpred.bSurveyLimitErrorMsgShown = False
							MImpred.bSurveyWarningMsgAnswer = False
							Me.bImplementedDesign = False
							Me.m_gbParaffin = False
						End If
					Catch ex14 As Exception
					End Try
				Catch ex15 As Exception
					Dim sMsg7 As String = "Error setting class defaults(6): " + ex15.Message
					Dim sMsgType7 As String = ""
					Dim bClosing7 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg7, sMsgType7, bClosing7, dialogResult)
				End Try
			Catch ex16 As Exception
				Dim sMsg8 As String = "Error in Set Class Defaults: " + ex16.Message
				Dim sMsgType8 As String = ""
				Dim bClosing8 As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg8, sMsgType8, bClosing8, dialogResult)
			End Try
		End Sub

		Public Property FeetOverPump As Single
			Get
				Return Me.m_FeetOverPump
			End Get
			Set(value As Single)
				Me.m_FeetOverPump = value
			End Set
		End Property

		Public Property FluidDens As Single
			Get
				Return Me.m_FluidDens
			End Get
			Set(value As Single)
				Me.m_FluidDens = value
			End Set
		End Property

		Public Property StartUpstroke As Integer
			Get
				Return Me.m_StartUpstroke
			End Get
			Set(value As Integer)
				Me.m_StartUpstroke = value
			End Set
		End Property

		Public Property StartDownstroke As Integer
			Get
				Return Me.m_StartDownstroke
			End Get
			Set(value As Integer)
				Me.m_StartDownstroke = value
			End Set
		End Property

		Public Property Number_Of_Guide_report_Pages As Integer
			Get
				Return Me.m_Number_Of_Guide_report_Pages
			End Get
			Set(value As Integer)
				Me.m_Number_Of_Guide_report_Pages = value
			End Set
		End Property

		Public Property NumDevSurveyPages As Integer
			Get
				Return Me.m_NumDevSurveyPages
			End Get
			Set(value As Integer)
				Me.m_NumDevSurveyPages = value
			End Set
		End Property

		Public Property CoverPageComment As String
			Get
				Return Me.m_CoverPageComment
			End Get
			Set(value As String)
				Me.m_CoverPageComment = value
			End Set
		End Property

		Public Property iFirstSizeID As Integer
			Get
				Return Me.m_iFirstSizeID
			End Get
			Set(value As Integer)
				Me.m_iFirstSizeID = value
			End Set
		End Property

		Public Property iFirstSettingID As Integer
			Get
				Return Me.m_iFirstSettingID
			End Get
			Set(value As Integer)
				Me.m_iFirstSettingID = value
			End Set
		End Property

		Public Property iFirstCurvePointID As Integer
			Get
				Return Me.m_iFirstCurvePointID
			End Get
			Set(value As Integer)
				Me.m_iFirstCurvePointID = value
			End Set
		End Property

		Public Property bUseCrankBalancedCalcs As Boolean
			Get
				Return Me.m_bUseCrankBalancedCalcs
			End Get
			Set(value As Boolean)
				Me.m_bUseCrankBalancedCalcs = value
			End Set
		End Property

		Public Property PercentUpstrokeSPM As Single
			Get
				Return Me.m_PercentUpstrokeSPM
			End Get
			Set(value As Single)
				Me.m_PercentUpstrokeSPM = 50F
			End Set
		End Property

		Public Property PercentDownstrokeSPM As Single
			Get
				Return Me.m_PercentDownstrokeSPM
			End Get
			Set(value As Single)
				Me.m_PercentDownstrokeSPM = 50F
			End Set
		End Property

		Public Property AdjustedStrokeLength As Single
			Get
				Return Me.m_AdjustedStrokeLength
			End Get
			Set(value As Single)
				Me.m_AdjustedStrokeLength = value
			End Set
		End Property

		Public Property PR_Diameter As Single
			Get
				Return Me.m_PR_Diameter
			End Get
			Set(value As Single)
				Me.m_PR_Diameter = value
			End Set
		End Property

		Public Property bImplementedDesign As Boolean
			Get
				Return Me.m_bImplementedDesign
			End Get
			Set(value As Boolean)
				Me.m_bImplementedDesign = value
			End Set
		End Property

		Private m_gbRoddiagFile As Boolean

		Private m_bOutputStored As Boolean

		Private m_giCommonDialogHelpContext As Short

		Private m_bCBEDigitized As Short

		Private m_bCBEFromDisk As Short

		Private m_CBDataType As Short

		Private m_UnknownM As Boolean

		Private m_iUnknownM As Integer

		Private m_CBEffect As Single

		Private m_CBAngle As Single

		Private m_M As Single()

		Private m_RequiredUnbalance As Single()

		Private m_CBDataFile As String

		Private m_DynaFile As String

		Private m_Inputfile As String

		Private m_MotorDataFile As String

		Private m_gbInputDataChanged As Boolean

		Private m_gbOutputLoaded As Boolean

		Private m_gbOutputOld As Boolean

		Private m_CBLDir As String

		Private m_DYNDir As String

		Private m_XDGDir As String

		Private m_SurfPos As Single()

		Private m_SurfLoad As Single()

		Private m_PumpPos As Single()

		Private m_PumpLoad As Single()

		Private m_Ntsteps As Short

		Private m_RDNtsteps As Short

		Private m_RDSurfPos As Single()

		Private m_RDSurfLoad As Single()

		Private m_dSurfPos As Single()

		Private m_dSurfLoad As Single()

		Private m_dNtsteps As Short

		Private m_xSurfPos As Single()

		Private m_xSurfLoad As Single()

		Private m_xNtsteps As Short

		Private m_pSurfPos As Single()

		Private m_pSurfLoad As Single()

		Private m_pPumpPos As Single()

		Private m_pPumpLoad As Single()

		Private m_pNtsteps As Short

		Private m_NoFIPumpLoad As Single()

		Private m_zNtsteps As Short

		Private m_g_PumpPosNoTubing As Single()

		Private m_g_NtstepsNoTubing As Short

		Private m_PermLoad As Single()

		Private m_DynoCard As Integer

		Private m_sDynoCard As String

		Private m_DynaSource As Short

		Private m_DynoDate As String

		Private m_NtstepsUpstroke As Short

		Private m_gbClampOn As Short

		Private m_giDynoCorrectKinematic As Short

		Private m_giDynoCorrectPhase As Short

		Private m_gfDynoLoadAdjustment As Single

		Private m_gfDynoPhaseAdjustment As Single

		Private m_gfDynoTOSAdjustment As Single

		Private m_gbDynoCardReversed As Boolean

		Private m_BaselineLoad As Single

		Private m_LoadScale As Single

		Private m_CbeX As Single

		Private m_CbeY As Single

		Private m_bCBEUpstroke As Short

		Private m_Npoints As Short

		Private m_DigPoints As Single(,)

		Private m_LeutertDynamometer As Short

		Private m_LeutertModel As String

		Private m_LeutertScale As Single

		Private m_LeutertSpring As Short

		Private m_MeasuredRuntime As Single

		Private m_MeasuredSPM As Single

		Private m_MeasuredStroke As Single

		Private m_MeasuredCBEffect As Single

		Private m_MeasuredCBEpos As Single

		Private m_MeasuredCBEupstroke As Short

		Private m_MeasuredTVLoad As Single

		Private m_MeasuredSVLoad As Single

		Private m_CompressibilityIndex As Single

		Private m_PumpEfficiency As Single

		Private m_UFeetFromSurface As Single

		Private m_UFeetOverPump As Single

		Private m_FluidLevel As Single

		Private m_FluidLevelTVD As Single

		Private m_PumpDepthTVD As Single

		Private m_UPumpIntakePressure As Single

		Private m_UPintakeFromLines As Single

		Private m_giFluidLevelSource As Short

		Private m_XDFeetFromSurface As Single

		Private m_XDFeetOverPump As Single

		Private m_XDFluidLoad As Single

		Private m_XDPintakeFromLines As Single

		Private m_g_FluidPoundFluidLoad As Single

		Private m_g_fPredFeetFromSurface As Single

		Private m_g_bUsingXDFluidLevel As Short

		Private m_gbParaffin As Boolean

		Private m_ParaffinDepth As Single

		Private m_gbCalcFluidSPGR As Boolean

		Private m_gfMaxFluidSPGR As Single

		Private m_FluidSPGR As Single

		Private m_OilAPI As Single

		Private m_OilSPGR As Single

		Private m_WaterCut As Single

		Private m_WaterSPGR As Single

		Private m_gbCalcFetkovichN As Boolean

		Private m_gbProducingBelowBPP As Boolean

		Private m_gbUseIPR As Boolean

		Private m_giIPRMethod As Short

		Private m_BubblePoint As Single

		Private m_FetkovichN As Single

		Private m_MidPerfDepth As Single

		Private m_CasingPressure As Single

		Private m_PumpIntakePressure As Single

		Private m_StaticBHPressure As Single

		Private m_TubingPressure As Single

		Private m_gnTestPoints As Short

		Private m_TestPoints As RSWIN_DESC.IPRTESTPOINT()

		Private m_WaterPI As Single

		Private m_LineSettings As RSWIN_DESC.LineType()

		Private m_ULinesSetH As Short

		Private m_ULinesSetV As Short

		Private m_ULineSettingsChanged As Short

		Private m_XDLineSettings As RSWIN_DESC.LineType()

		Private m_XDLinesSetH As Short

		Private m_XDLinesSetV As Short

		Private m_ThisVersion As Short

		Private m_ThisMagic As String

		Private m_CalcMotorSize As Short

		Private m_Iart As Single

		Private m_Irot As Single

		Private m_MotorSPV As Single

		Private m_Apump As Single

		Private m_PlungerSize As Single

		Private m_PumpType As Short

		Private m_ElectricityCost As Single

		Private m_PowerMeterType As Short

		Private m_Prhp As Single

		Private m_Plhp As Single

		Private m_MinMotorHP As Single

		Private m_MotorHP As Single

		Private m_USystemEff As Single

		Private m_XDSystemEff As Single

		Private m_DollarsPerBblFluid As Single()

		Private m_DollarsPerBblOil As Single()

		Private m_ElectricBillperMonth As Single()

		Private m_HpNemaD As Single()

		Private m_HpUhs As Single()

		Private m_MotorKWH As Single()

		Private m_PumpLoadAdj As Single

		Private m_gbPrintCalculations As Short

		Private m_gbPrintGraphs As Short

		Private m_gbPrintIPR As Short

		Private m_BPDsurface As Single

		Private m_UFluidLoad As Single

		Private m_GrossPumpStroke As Single

		Private m_Runtime As Single

		Private m_SPM As Single

		Private m_UNetProduction As Single

		Private m_UNetStrokeApparent As Single

		Private m_UNetStroke As Single

		Private m_XDNetProduction As Single

		Private m_XDNetStrokeApparent As Single

		Private m_XDNetStroke As Single

		Private m_gclsUpstroke As RSWIN_DESC.PUMPDIAGNOSIS()

		Private m_gclsDownstroke As RSWIN_DESC.PUMPDIAGNOSIS()

		Private m_DownstrokeTilt As Single

		Private m_pGrossPumpStroke As Single

		Private m_PlungerMinLoad As Single

		Private m_PlungerMaxLoad As Single

		Private m_PumpFillagePat As Single

		Private m_PumpLoadShift As Single

		Private m_TubingMovement As Single

		Private m_TubingMovementPat As Short

		Private m_UpstrokeTilt As Single

		Private m_ZeroPosition As Single

		Private m_PumpDepth As Single

		Private m_IntermediateDepth As Single

		Private m_UPumpFillage As Single

		Private m_XDPumpFillage As Single

		Private m_PU As RSWIN_DESC.PUDataRec

		Private m_IDEntered As Short

		Private m_CrankSpeed As Single

		Private m_TotalTheta As Single

		Private m_UnitID As String

		Private m_UnitName As String

		Private m_gbSummaryPage As Boolean

		Private m_gbScoringPage As Boolean

		Private m_gbOrderPage As Boolean

		Private m_gbCoverPage As Boolean

		Private m_gbReportData As Boolean

		Private m_gbReportDiagnosis As Boolean

		Private m_gbReportDynoPred As Boolean

		Private m_gbReportDynoActual As Boolean

		Private m_gbReportIPR As Boolean

		Private m_gbReportSinglePageDynoTorque As Boolean

		Private m_gbReportTorque As Boolean

		Private m_gbReportDevChart As Boolean

		Private m_gbReportGuide As Boolean

		Private m_gbReportDevSurvey As Boolean

		Private m_NumRods As Short

		Private m_Sections As RSWIN_DESC.RodSection()

		Private m_Section As RSWIN_DESC.RodSection

		Private m_ServiceFactor As Single

		Private m_minStressBot As Single()

		Private m_maxStressBot As Single()

		Private m_minStressTop As Single()

		Private m_maxStressTop As Single()

		Private m_StressL As Single()

		Private m_MaxRodStressL As Single

		Private m_WrodsInAir As Single

		Private m_WrodsInFluid As Single

		Private m_gbSteelRodString As Boolean

		Private m_CalcUDFriction As Boolean

		Private m_DownstrokeFriction As Single

		Private m_DownstrokeFrictionAverage As Single

		Private m_DownstrokeFrictionFactor As Single

		Private m_DownstrokeFrictionRemoved As Single

		Private m_FluidVelocity As Single

		Private m_Friction As Single

		Private m_Counterbalance As Single

		Private m_CrankHole As Short

		Private m_Rotation As Short

		Private m_Unbalance As Single

		Private m_MaxPinSizeSect As Short

		Private m_UpstrokeFriction As Single

		Private m_UpstrokeFrictionAverage As Single

		Private m_UpstrokeFrictionRemoved As Single

		Private m_UpstrokeFrictionFactor As Single

		Private m_SlideFricCoeff As Single

		Private m_gbCalcFriction As Boolean

		Private m_gbCalcSlideFricCoeff As Boolean

		Private m_gbIncludeBuoyancy As Boolean

		Private m_PumpFriction As Single

		Private m_Mprload As Single

		Private m_Pprload As Single

		Private m_StructL As Single

		Private m_FluidInertiaScore As Single

		Private m_pPRHP As Single

		Private m_SurfLoadShift As Single

		Private m_SurfLoadShiftPct As Single

		Private m_SurfScore As Single

		Private m_CBE90 As Single()

		Private m_Clf As Single()

		Private m_GearboxLoading As Single()

		Private m_PeakTorque As Single()

		Private m_Tf As Single()

		Private m_Thetac As Single()

		Private m_Tnet As Single(,)

		Private m_TubingAnchored As Short

		Private m_TubingAnchorDepth As Single

		Private m_TubingID As Single

		Private m_TubingOD As Single

		Private m_ACompanyName As String

		Private m_WellName As String

		Private m_UserName As String

		Private m_UserDate As String

		Private m_FileComment As String

		Private m_IncludeFluidInertia As Object

		Private m_mhMotorDB As Short

		Private m_mlMotorKindOffset As Integer

		Private m_mlMotorSizeOffset As Integer

		Private m_mlMotorSettingOffset As Integer

		Private m_mlMotorCurveOffset As Integer

		Private m_alMotorKindTable As Integer()

		Private m_alMotorSizeTable As Integer()

		Private m_alMotorSettingTable As Integer()

		Private m_asMotorKindList As String()

		Private m_mfFullLoadSpeed As Single

		Private m_mfMaxLoad As Single

		Private m_mfMaxSPV As Single

		Private m_mfRatedHP As Single

		Private m_miFirstSetting As Short

		Private m_miFirstSize As Short

		Private m_miMotorKind As Short

		Private m_miMotorSetting As Short

		Private m_miMotorSize As Short

		Private m_mnMotorSettings As Short

		Private m_mnMotorSizes As Short

		Private m_msMotorKindName As String

		Private m_msMotorSettingName As String

		Private m_msMotorSizeName As String

		Private m_mnMotorCurvePoints As Short

		Private m_MotorSetting As Short

		Private m_MotorSize As Short

		Private m_MotorType As Short

		Private m_mfTorque As Single()

		Private m_mfEfficiency As Single()

		Private m_CalcMotorSPV As Short

		Private m_IrotEntered As Short

		Private m_CalcPlungerSize As Short

		Private m_SystemEff As Single

		Private m_FluidLoad As Single

		Private m_Pfill As Single

		Private m_MaxSPM As Single

		Private m_StuffingBoxFriction As Single

		Private m_SPMEntered As Short

		Private m_TargetBFPD As Single

		Private m_PlungerLength As Single

		Private m_ProductionLoss As Single

		Private m_PumpLength As Single

		Private m_PumpSpacing As Single

		Private m_TubStretch As Single

		Private m_gbCalcPumpCondition As Boolean

		Private m_PumpCondition As Short

		Private m_PumpFillage As Single

		Private m_Srad As Single

		Private m_StrokeFeet As Single

		Private m_gbReportCostAnalysis As Short

		Private m_giRodDesignStyle As Short

		Private m_RodStringType As Short

		Private m_RSExtraCost As Single

		Private m_RSExtraCostLabel As String

		Private m_APIRod As Short

		Private m_APIGrade As Short

		Private m_APIRodType As String

		Private m_APITensileStrength As Single

		Private m_FoSkr As Single

		Private m_Fc As Single

		Private m_No As Single

		Private m_NoverNoP As Single

		Private m_RodstringL As Single

		Private m_RSFGIncludeSteel As Short

		Private m_RSIncludeSB As Short

		Private m_RSFGGrade As Short

		Private m_RSGrade As Short

		Private m_RSRodType As String

		Private m_RSTensileStrength As Single

		Private m_RSSuckerRodLength As Single

		Private m_RSMaxSize As Single

		Private m_RSMinSize As Single

		Private m_RSSRSize As Single

		Private m_RSSBGrade As Short

		Private m_RSSBDiameter As Single

		Private m_RSSBLength As Single

		Private m_SinkerRods As Boolean

		Private m_FGPercent As Single

		Private m_LargestFG As Single

		Private m_SinkerBar As RSWIN_DESC.RodSection

		Private m_CalcFriction As Short

		Private m_prvel As Single()

		Private m_APITable As Single(,)

		Private m_WarnedAboutBFPD As Boolean

		Private m_WarnedAboutFluidInertia As Boolean

		Private m_WarnedAboutFoSkr As Boolean

		Private m_WarnedAboutLowSPM As Boolean

		Private m_WarnedAboutHighSPM As Boolean

		Private m_WarnedAboutLowPumpEfficiency As Boolean

		Private m_WarnedAboutLowPumpFillage As Boolean

		Private m_WarnedAboutPlungerSize As Boolean

		Private m_WarnedAboutLargeNtsteps As Boolean

		Private m_WarnedAboutUHSMotor As Boolean

		Private m_FluidLevelEntered As Boolean

		Private m_gbCalcPumpIntakePressure As Boolean

		Private m_gbCalcTargetBFPD As Boolean

		Private m_bCardIsReversed As Boolean

		Private m_gbAutomatic As Boolean

		Private m_gbAutomaticEnabled As Boolean

		Private m_gbBatch As Boolean

		Private m_gbPrintBatchLog As Boolean

		Private m_bUnknownUnbalance As Boolean

		Private m_FluidDamping As Single

		Private m_PumpDragDownstrokeMax As Single

		Private m_PumpDragUpstrokeMax As Single

		Private m_DragSettings As Short

		Private m_gbLite As Short

		Private m_giThisVersion As Short

		Private m_bDeviated As Boolean

		Private m_bSaveFlag As Boolean

		Private m_RSTDir As String

		Private m_giDynoDetectKinematic As Short

		Private m_giDynoDetectPhase As Short

		Private m_gbDesignSinkerbar As Boolean

		Private m_bHasFGlass As Boolean

		Private m_bHasRR As Boolean

		Private m_VSP As Boolean

		Private m_RSFricCoef As Single

		Private m_RSRodGuide As Integer

		Private m_FeetOverPump As Single

		Private m_FluidDens As Single

		Private m_StartUpstroke As Integer

		Private m_StartDownstroke As Integer

		Private m_Number_Of_Guide_report_Pages As Integer

		Private m_NumDevSurveyPages As Integer

		Private m_CoverPageComment As String

		Private m_iFirstSizeID As Integer

		Private m_iFirstSettingID As Integer

		Private m_iFirstCurvePointID As Integer

		Private m_bUseCrankBalancedCalcs As Boolean

		Private m_PercentUpstrokeSPM As Single

		Private m_PercentDownstrokeSPM As Single

		Private m_AdjustedStrokeLength As Single

		Private m_PR_Diameter As Single

		Private m_bImplementedDesign As Boolean
	End Class
End Namespace
