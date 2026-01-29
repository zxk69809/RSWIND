Namespace RSWINV3
	Public Partial Class RswinSetup
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.RswinSetup))
			Me.pnlGeneral = New Global.System.Windows.Forms.Panel()
			Me.grpPredictMode = New Global.System.Windows.Forms.GroupBox()
			Me.optDeviated = New Global.System.Windows.Forms.RadioButton()
			Me.optVertical = New Global.System.Windows.Forms.RadioButton()
			Me.grpLanguages = New Global.System.Windows.Forms.GroupBox()
			Me.rbtChinese = New Global.System.Windows.Forms.RadioButton()
			Me.rbtSpan = New Global.System.Windows.Forms.RadioButton()
			Me.rbtEng = New Global.System.Windows.Forms.RadioButton()
			Me.grpSystemOfUnits = New Global.System.Windows.Forms.GroupBox()
			Me.rbtMetric = New Global.System.Windows.Forms.RadioButton()
			Me.rbtCanadian = New Global.System.Windows.Forms.RadioButton()
			Me.rbtEnglish = New Global.System.Windows.Forms.RadioButton()
			Me.grpPreferences = New Global.System.Windows.Forms.GroupBox()
			Me.chkAlwaysSaveXDIAGMeasuredCard = New Global.System.Windows.Forms.CheckBox()
			Me.chkDisplaySBinFeet = New Global.System.Windows.Forms.CheckBox()
			Me.chkShowVisualInputWindow = New Global.System.Windows.Forms.CheckBox()
			Me.cboDigitizerComPort = New Global.System.Windows.Forms.ComboBox()
			Me.lblDigitizerComPort = New Global.System.Windows.Forms.Label()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.udMin = New Global.System.Windows.Forms.NumericUpDown()
			Me.udHour = New Global.System.Windows.Forms.NumericUpDown()
			Me.lblMIN = New Global.System.Windows.Forms.Label()
			Me.lblHRS = New Global.System.Windows.Forms.Label()
			Me.chkSaveOpenFileOnExit = New Global.System.Windows.Forms.CheckBox()
			Me.udSec_notused = New Global.System.Windows.Forms.NumericUpDown()
			Me.chkExitIfIdle = New Global.System.Windows.Forms.CheckBox()
			Me.lblExitIfIdle = New Global.System.Windows.Forms.Label()
			Me.grpUseServerDatabase = New Global.System.Windows.Forms.GroupBox()
			Me.btnSynch = New Global.System.Windows.Forms.Button()
			Me.btnVerifyData = New Global.System.Windows.Forms.Button()
			Me.btnVerifyFiles = New Global.System.Windows.Forms.Button()
			Me.txtDBServerFolder = New Global.System.Windows.Forms.TextBox()
			Me.btnBrowseForServerFolder = New Global.System.Windows.Forms.Button()
			Me.lblDBServerFolder = New Global.System.Windows.Forms.Label()
			Me.rbtUseServerLocation = New Global.System.Windows.Forms.RadioButton()
			Me.rptUseLocalDatabase = New Global.System.Windows.Forms.RadioButton()
			Me.grpRodElement = New Global.System.Windows.Forms.GroupBox()
			Me.txtRodElementLimit = New Global.System.Windows.Forms.TextBox()
			Me.lblRodElementLimit = New Global.System.Windows.Forms.Label()
			Me.chkUseDefaultRodElementLimit = New Global.System.Windows.Forms.CheckBox()
			Me.pnlDefaults = New Global.System.Windows.Forms.Panel()
			Me.chkRelocateSB = New Global.System.Windows.Forms.CheckBox()
			Me.lblInclinationLimit = New Global.System.Windows.Forms.Label()
			Me.txtInclinationLimit = New Global.System.Windows.Forms.TextBox()
			Me._SSFrame_8 = New Global.System.Windows.Forms.GroupBox()
			Me.cboParaffinRodGuide = New Global.System.Windows.Forms.ComboBox()
			Me.lblParaffinGuides = New Global.System.Windows.Forms.Label()
			Me.txtNumRodsPerBundle = New Global.System.Windows.Forms.TextBox()
			Me.lblNumRodsPerBundle = New Global.System.Windows.Forms.Label()
			Me.txtRodGuideOverlap = New Global.System.Windows.Forms.TextBox()
			Me.lblRodGuideOverlap = New Global.System.Windows.Forms.Label()
			Me.lblIterations = New Global.System.Windows.Forms.Label()
			Me.lblMaxSideLoadLimit = New Global.System.Windows.Forms.Label()
			Me.cmdResetFrictions = New Global.System.Windows.Forms.Button()
			Me.lblSideLoadperRodGuide = New Global.System.Windows.Forms.Label()
			Me.cboSidewinder = New Global.System.Windows.Forms.ComboBox()
			Me.txtMinNumGuides = New Global.System.Windows.Forms.TextBox()
			Me.lblMaxNumGuides = New Global.System.Windows.Forms.Label()
			Me.lblGuides = New Global.System.Windows.Forms.Label()
			Me.txtOther = New Global.System.Windows.Forms.TextBox()
			Me.txtNorrisFricCoeff = New Global.System.Windows.Forms.TextBox()
			Me.optSideWinder = New Global.System.Windows.Forms.RadioButton()
			Me.chkUseFluidInertiaPumpLoadAdj = New Global.System.Windows.Forms.CheckBox()
			Me.txtWeightAdjustFactor = New Global.System.Windows.Forms.TextBox()
			Me.lblWeightAdjustFactor = New Global.System.Windows.Forms.Label()
			Me.txtOtherFricCoeff = New Global.System.Windows.Forms.TextBox()
			Me.txtWheelFricCoeff = New Global.System.Windows.Forms.TextBox()
			Me.txtMoldedFricCoeff = New Global.System.Windows.Forms.TextBox()
			Me.lblNumCycles = New Global.System.Windows.Forms.Label()
			Me.txtNumCycles = New Global.System.Windows.Forms.TextBox()
			Me.optOther = New Global.System.Windows.Forms.RadioButton()
			Me.txtMaxNumGuides = New Global.System.Windows.Forms.TextBox()
			Me.lblMinNumGuides = New Global.System.Windows.Forms.Label()
			Me.optMolded = New Global.System.Windows.Forms.RadioButton()
			Me.optWheel = New Global.System.Windows.Forms.RadioButton()
			Me.txtMoldedLoad = New Global.System.Windows.Forms.TextBox()
			Me.txtOtherLoad = New Global.System.Windows.Forms.TextBox()
			Me.txtWheelLoad = New Global.System.Windows.Forms.TextBox()
			Me.txtSidewinderLoad = New Global.System.Windows.Forms.TextBox()
			Me.lblFricCoeff = New Global.System.Windows.Forms.Label()
			Me.txtNumImplIters = New Global.System.Windows.Forms.TextBox()
			Me.rbtBareRod = New Global.System.Windows.Forms.RadioButton()
			Me.txtBareRodFricCoeff = New Global.System.Windows.Forms.TextBox()
			Me.txtMaxSideLoadLimit = New Global.System.Windows.Forms.TextBox()
			Me.txtMDInt = New Global.System.Windows.Forms.TextBox()
			Me.lblDoglegLimit = New Global.System.Windows.Forms.Label()
			Me.txtDoglegLimit = New Global.System.Windows.Forms.TextBox()
			Me.lblMDInt = New Global.System.Windows.Forms.Label()
			Me.chkUseJeffsFix = New Global.System.Windows.Forms.CheckBox()
			Me.chkUseJohnsFix = New Global.System.Windows.Forms.CheckBox()
			Me.chkUseBucklingTendencyStresses = New Global.System.Windows.Forms.CheckBox()
			Me.chkUseAllDiameters = New Global.System.Windows.Forms.CheckBox()
			Me.grpWarnings = New Global.System.Windows.Forms.GroupBox()
			Me.chkTargetBFPDWarning = New Global.System.Windows.Forms.CheckBox()
			Me.chkRunTimeWarning = New Global.System.Windows.Forms.CheckBox()
			Me.chkOptimizeSurvey = New Global.System.Windows.Forms.CheckBox()
			Me.btnDefault = New Global.System.Windows.Forms.Button()
			Me.grpRatio = New Global.System.Windows.Forms.GroupBox()
			Me.chkCalcVBelt = New Global.System.Windows.Forms.CheckBox()
			Me.txtGearBoxRatio = New Global.System.Windows.Forms.TextBox()
			Me.txtVBeltRatio = New Global.System.Windows.Forms.TextBox()
			Me.lblVBeltRatio = New Global.System.Windows.Forms.Label()
			Me.lblGearBoxRatio = New Global.System.Windows.Forms.Label()
			Me.chkAllowSlideFric = New Global.System.Windows.Forms.CheckBox()
			Me._SSFrame_3 = New Global.System.Windows.Forms.GroupBox()
			Me.txtMaxSteelLoading = New Global.System.Windows.Forms.TextBox()
			Me.txtMaxFGLoading = New Global.System.Windows.Forms.TextBox()
			Me.lblMaxFGLoading = New Global.System.Windows.Forms.Label()
			Me.lblMaxSteelLoading = New Global.System.Windows.Forms.Label()
			Me.chkAzDirToolbar = New Global.System.Windows.Forms.CheckBox()
			Me.lblDefaultType = New Global.System.Windows.Forms.Label()
			Me.lstDefaultItems = New Global.System.Windows.Forms.ListBox()
			Me.lblDefault = New Global.System.Windows.Forms.Label()
			Me.lblItem = New Global.System.Windows.Forms.Label()
			Me.txtDefault = New Global.System.Windows.Forms.TextBox()
			Me.cboDefault = New Global.System.Windows.Forms.ComboBox()
			Me.rtbDefault = New Global.System.Windows.Forms.RichTextBox()
			Me.pnlBatchMode = New Global.System.Windows.Forms.Panel()
			Me.chkCreatePDFs = New Global.System.Windows.Forms.CheckBox()
			Me.btnVerify = New Global.System.Windows.Forms.Button()
			Me.chkExcelInstalled = New Global.System.Windows.Forms.CheckBox()
			Me.optCRGMismatch_0 = New Global.System.Windows.Forms.RadioButton()
			Me.chkViewWK1 = New Global.System.Windows.Forms.CheckBox()
			Me.lblBatchMode = New Global.System.Windows.Forms.Label()
			Me.chkSkipProcessedFiles = New Global.System.Windows.Forms.CheckBox()
			Me.chkCreateWK1 = New Global.System.Windows.Forms.CheckBox()
			Me.chkPrintResults = New Global.System.Windows.Forms.CheckBox()
			Me.optCRGMismatch_1 = New Global.System.Windows.Forms.RadioButton()
			Me.grpAutomaticBatchMode = New Global.System.Windows.Forms.GroupBox()
			Me.cboAMPM = New Global.System.Windows.Forms.ComboBox()
			Me.nmUDMinute = New Global.System.Windows.Forms.NumericUpDown()
			Me.nmUDHour = New Global.System.Windows.Forms.NumericUpDown()
			Me.txtWK1Dir = New Global.System.Windows.Forms.TextBox()
			Me.txtRODSTARDir = New Global.System.Windows.Forms.TextBox()
			Me.cmdBrowse_2 = New Global.System.Windows.Forms.Button()
			Me.cmdBrowse_0 = New Global.System.Windows.Forms.Button()
			Me.lblSSDir = New Global.System.Windows.Forms.Label()
			Me.lblRODSTARDataDict = New Global.System.Windows.Forms.Label()
			Me.lblTimeToBeginRuns = New Global.System.Windows.Forms.Label()
			Me.grpSpreadSheetSetup = New Global.System.Windows.Forms.GroupBox()
			Me.btnModifySS = New Global.System.Windows.Forms.Button()
			Me.btnNewSS = New Global.System.Windows.Forms.Button()
			Me.btnDeleteSS = New Global.System.Windows.Forms.Button()
			Me.lstSorted = New Global.System.Windows.Forms.ListBox()
			Me.lstWK1Formats = New Global.System.Windows.Forms.ListBox()
			Me.lblSelect = New Global.System.Windows.Forms.Label()
			Me.pnlCustomizeRGList = New Global.System.Windows.Forms.Panel()
			Me.cmdModifyCustomRG = New Global.System.Windows.Forms.Button()
			Me.cmdNewCustomRG = New Global.System.Windows.Forms.Button()
			Me.cmdDeleteCustomRG = New Global.System.Windows.Forms.Button()
			Me.lvwCustomRG = New Global.System.Windows.Forms.ListView()
			Me.RodType = New Global.System.Windows.Forms.ColumnHeader()
			Me.TensileStrength = New Global.System.Windows.Forms.ColumnHeader()
			Me.StressMethod = New Global.System.Windows.Forms.ColumnHeader()
			Me.SinkerBar = New Global.System.Windows.Forms.ColumnHeader()
			Me.pnlOutputOptions = New Global.System.Windows.Forms.Panel()
			Me.cmdCheckData = New Global.System.Windows.Forms.Button()
			Me.grpOutputOptions = New Global.System.Windows.Forms.GroupBox()
			Me.chkReportOpt_6 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_7 = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.SSPanel = New Global.System.Windows.Forms.Panel()
			Me.imgPreview_10 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_9 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_ = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_6 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_3 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_4 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_5 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_2 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_0 = New Global.System.Windows.Forms.PictureBox()
			Me.imgPreview_1 = New Global.System.Windows.Forms.PictureBox()
			Me.grpOutputPages = New Global.System.Windows.Forms.GroupBox()
			Me.chkReportOpt_10 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_9 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_ = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_8 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_5 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_4 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_3 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_2 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_0 = New Global.System.Windows.Forms.CheckBox()
			Me.chkReportOpt_1 = New Global.System.Windows.Forms.CheckBox()
			Me.btnOK = New Global.System.Windows.Forms.Button()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.pnlDebug = New Global.System.Windows.Forms.Panel()
			Me.chkPlotAllDownholeCards = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugShowMessages = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugDisableOnError = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugShowPredictInfo = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugSetNcycles = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugCreateDYN = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugShowAllBalanced = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugCreateTF = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugCreateTQ = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugCreateDPC = New Global.System.Windows.Forms.CheckBox()
			Me._Label_16 = New Global.System.Windows.Forms.Label()
			Me._Label_15 = New Global.System.Windows.Forms.Label()
			Me._Label_14 = New Global.System.Windows.Forms.Label()
			Me._Label_13 = New Global.System.Windows.Forms.Label()
			Me.pnlCustomPUList = New Global.System.Windows.Forms.Panel()
			Me.cboManufMenuCustomDB = New Global.System.Windows.Forms.ComboBox()
			Me.lvwCustomPUDB = New Global.System.Windows.Forms.ListView()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.pnlCustomMeasuredPUList = New Global.System.Windows.Forms.Panel()
			Me.lvwCustomPU = New Global.System.Windows.Forms.ListView()
			Me.Manufacturer = New Global.System.Windows.Forms.ColumnHeader()
			Me.APIDesignation = New Global.System.Windows.Forms.ColumnHeader()
			Me.UnitName = New Global.System.Windows.Forms.ColumnHeader()
			Me.OtherInfo = New Global.System.Windows.Forms.ColumnHeader()
			Me.cmdDeleteCustomPU = New Global.System.Windows.Forms.Button()
			Me.cmdModifyCustomPU = New Global.System.Windows.Forms.Button()
			Me.cmdNewCustomPU = New Global.System.Windows.Forms.Button()
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.pnlDebugOptions = New Global.System.Windows.Forms.Panel()
			Me.grpDebugOpt = New Global.System.Windows.Forms.GroupBox()
			Me.CheckBox4 = New Global.System.Windows.Forms.CheckBox()
			Me.optNcycles_0 = New Global.System.Windows.Forms.RadioButton()
			Me.optNcycles_1 = New Global.System.Windows.Forms.RadioButton()
			Me.optNcycles_2 = New Global.System.Windows.Forms.RadioButton()
			Me.optNcycles_3 = New Global.System.Windows.Forms.RadioButton()
			Me.CheckBox5 = New Global.System.Windows.Forms.CheckBox()
			Me.CheckBox6 = New Global.System.Windows.Forms.CheckBox()
			Me.CheckBox7 = New Global.System.Windows.Forms.CheckBox()
			Me.CheckBox8 = New Global.System.Windows.Forms.CheckBox()
			Me.CheckBox9 = New Global.System.Windows.Forms.CheckBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.chkDebugFixSinusoidalDyno = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugTreatAsSolidLine = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugNoFIReplaceGoodMatch = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugShowMatchInfo = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugMessages = New Global.System.Windows.Forms.CheckBox()
			Me.chkDebugShowPredictInfo2 = New Global.System.Windows.Forms.CheckBox()
			Me.pnlSetupCostDB = New Global.System.Windows.Forms.Panel()
			Me.panContainer = New Global.System.Windows.Forms.Panel()
			Me._optCostCategory_2 = New Global.System.Windows.Forms.RadioButton()
			Me._optCostCategory_0 = New Global.System.Windows.Forms.RadioButton()
			Me._optCostCategory_1 = New Global.System.Windows.Forms.RadioButton()
			Me._Line_0 = New Global.System.Windows.Forms.Label()
			Me._Line_1 = New Global.System.Windows.Forms.Label()
			Me._panCostCategory_1 = New Global.System.Windows.Forms.Panel()
			Me.cboRodGrade = New Global.System.Windows.Forms.ComboBox()
			Me.cboRodType = New Global.System.Windows.Forms.ComboBox()
			Me.cmdRSLoadCostDB = New Global.System.Windows.Forms.Button()
			Me._Label_3 = New Global.System.Windows.Forms.Label()
			Me._Label_4 = New Global.System.Windows.Forms.Label()
			Me._panCostCategory_0 = New Global.System.Windows.Forms.Panel()
			Me.lblAPIDesignation = New Global.System.Windows.Forms.Label()
			Me.lblUnitName = New Global.System.Windows.Forms.Label()
			Me.lblOtherInfo = New Global.System.Windows.Forms.Label()
			Me.cboPUManuf = New Global.System.Windows.Forms.ComboBox()
			Me.cmdPULoadCostDB = New Global.System.Windows.Forms.Button()
			Me._Label_6 = New Global.System.Windows.Forms.Label()
			Me._Label_7 = New Global.System.Windows.Forms.Label()
			Me._Label_8 = New Global.System.Windows.Forms.Label()
			Me._Label_9 = New Global.System.Windows.Forms.Label()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.pnlPUCostDB = New Global.System.Windows.Forms.Panel()
			Me.ulgPUCostDB = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me.pnlGuideCostDB = New Global.System.Windows.Forms.Panel()
			Me.ulgGuideCostDB = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me.pnlRSCostDB = New Global.System.Windows.Forms.Panel()
			Me.ulgRSCostDB = New Global.Infragistics.Win.UltraWinGrid.UltraGrid()
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.pnlExpert = New Global.System.Windows.Forms.Panel()
			Me.grpTubingSizePreferences = New Global.System.Windows.Forms.GroupBox()
			Me.chkFixTubingSize = New Global.System.Windows.Forms.CheckBox()
			Me.lblCasingSize = New Global.System.Windows.Forms.Label()
			Me.txtCasingSize = New Global.System.Windows.Forms.TextBox()
			Me._Label_CasingSizeOD = New Global.System.Windows.Forms.Label()
			Me.chkRodstarTubingSizeRec = New Global.System.Windows.Forms.CheckBox()
			Me._Label_MaxTubingSizeID = New Global.System.Windows.Forms.Label()
			Me._Label_MinTubingSizeID = New Global.System.Windows.Forms.Label()
			Me.txtMaxTubingSizeID = New Global.System.Windows.Forms.TextBox()
			Me.txtMinTubingSizeID = New Global.System.Windows.Forms.TextBox()
			Me.txtMinTubingSizeOD = New Global.System.Windows.Forms.TextBox()
			Me.txtMaxTubingSizeOD = New Global.System.Windows.Forms.TextBox()
			Me._Label_MinTubingSizeOD = New Global.System.Windows.Forms.Label()
			Me.cboMinTubingSizeOD = New Global.System.Windows.Forms.ComboBox()
			Me.lblcboMinTubingSizeOD_Disabled = New Global.System.Windows.Forms.Label()
			Me._Label_MaxTubingSizeOD = New Global.System.Windows.Forms.Label()
			Me.cboCasingSize = New Global.System.Windows.Forms.ComboBox()
			Me.cboMaxTubingSizeOD = New Global.System.Windows.Forms.ComboBox()
			Me.lblcboMaxTubingSizeOD_Disabled = New Global.System.Windows.Forms.Label()
			Me.lblcboCasingSize_Disabled = New Global.System.Windows.Forms.Label()
			Me.grpRodPreferences = New Global.System.Windows.Forms.GroupBox()
			Me._Label_ElectricityCost = New Global.System.Windows.Forms.Label()
			Me.txtElectricityCostPreference = New Global.System.Windows.Forms.TextBox()
			Me.pnlUseRodOnly = New Global.System.Windows.Forms.Panel()
			Me.rbtUseBoth = New Global.System.Windows.Forms.RadioButton()
			Me.optUseSteelRodsOnly = New Global.System.Windows.Forms.RadioButton()
			Me.optUseFGlassWithSteelOnBottom = New Global.System.Windows.Forms.RadioButton()
			Me.txtServiceFactorPreference = New Global.System.Windows.Forms.TextBox()
			Me.lblServiceFactor = New Global.System.Windows.Forms.Label()
			Me.cboHighStrengthRods = New Global.System.Windows.Forms.ComboBox()
			Me.optSinkerRods = New Global.System.Windows.Forms.RadioButton()
			Me.optSinkerBars = New Global.System.Windows.Forms.RadioButton()
			Me.lblRSFGGrade = New Global.System.Windows.Forms.Label()
			Me.lblSinkerBars = New Global.System.Windows.Forms.Label()
			Me.cboSinkerBarsGrade = New Global.System.Windows.Forms.ComboBox()
			Me.lblRSGrade = New Global.System.Windows.Forms.Label()
			Me.cboFGlassRods = New Global.System.Windows.Forms.ComboBox()
			Me.lblSinkerRods = New Global.System.Windows.Forms.Label()
			Me.cboSinkerRodsGrade = New Global.System.Windows.Forms.ComboBox()
			Me.cboUHSProrod = New Global.System.Windows.Forms.ComboBox()
			Me.lblStatus = New Global.System.Windows.Forms.Label()
			Me.grpMotorPreferences = New Global.System.Windows.Forms.GroupBox()
			Me.pnlMotorData = New Global.System.Windows.Forms.Panel()
			Me.chkIncludeMotorSPV = New Global.System.Windows.Forms.CheckBox()
			Me.optPowerMeterType_2 = New Global.System.Windows.Forms.RadioButton()
			Me.optPowerMeterType_1 = New Global.System.Windows.Forms.RadioButton()
			Me._Label_MeterType = New Global.System.Windows.Forms.Label()
			Me.grpRodTubingFricCoeffPref = New Global.System.Windows.Forms.GroupBox()
			Me.NumericUpDown1_XTimes = New Global.System.Windows.Forms.NumericUpDown()
			Me.lblUseXTimes = New Global.System.Windows.Forms.Label()
			Me.lblUseAvgFric = New Global.System.Windows.Forms.Label()
			Me.grpPumpTypePreference = New Global.System.Windows.Forms.GroupBox()
			Me.chkInsertPump = New Global.System.Windows.Forms.CheckBox()
			Me.chkRodstarPumpTypeRec = New Global.System.Windows.Forms.CheckBox()
			Me.chkTubingPump = New Global.System.Windows.Forms.CheckBox()
			Me.chkLargeBorePump = New Global.System.Windows.Forms.CheckBox()
			Me.lblchkTubingPump_Disabled = New Global.System.Windows.Forms.Label()
			Me.lblchkLargeBorePump_Disabled = New Global.System.Windows.Forms.Label()
			Me.lblchkInsertPump_Disabled = New Global.System.Windows.Forms.Label()
			Me.grpTubingAnchoredPreference = New Global.System.Windows.Forms.GroupBox()
			Me.chkRodstarTubingAnchoredRec = New Global.System.Windows.Forms.CheckBox()
			Me.chkTubingAnchored = New Global.System.Windows.Forms.CheckBox()
			Me.lblchkTubingAnchored_Disabled = New Global.System.Windows.Forms.Label()
			Me.grpPumpUnitManufacturer_Preferences = New Global.System.Windows.Forms.GroupBox()
			Me.pnlUseGeneral = New Global.System.Windows.Forms.Panel()
			Me.chkUseGeneral = New Global.System.Windows.Forms.CheckBox()
			Me.chkUseClosestUnit = New Global.System.Windows.Forms.CheckBox()
			Me.chkAIUseCustomizedLists = New Global.System.Windows.Forms.CheckBox()
			Me.chkManufacturer8 = New Global.System.Windows.Forms.CheckBox()
			Me.chkManufacturer7 = New Global.System.Windows.Forms.CheckBox()
			Me.chkManufacturer6 = New Global.System.Windows.Forms.CheckBox()
			Me.chkManufacturer5 = New Global.System.Windows.Forms.CheckBox()
			Me.chkManufacturer4 = New Global.System.Windows.Forms.CheckBox()
			Me.chkManufacturer3 = New Global.System.Windows.Forms.CheckBox()
			Me.chkManufacturer2 = New Global.System.Windows.Forms.CheckBox()
			Me.lblManufacturer8 = New Global.System.Windows.Forms.Label()
			Me.lblManufacturer7 = New Global.System.Windows.Forms.Label()
			Me.lblManufacturer6 = New Global.System.Windows.Forms.Label()
			Me.lblManufacturer5 = New Global.System.Windows.Forms.Label()
			Me.cboManufMenu8 = New Global.System.Windows.Forms.ComboBox()
			Me.cboManufMenu7 = New Global.System.Windows.Forms.ComboBox()
			Me.cboManufMenu6 = New Global.System.Windows.Forms.ComboBox()
			Me.cboManufMenu5 = New Global.System.Windows.Forms.ComboBox()
			Me.lblManufacturer4 = New Global.System.Windows.Forms.Label()
			Me.lblManufacturer3 = New Global.System.Windows.Forms.Label()
			Me.lblManufacturer2 = New Global.System.Windows.Forms.Label()
			Me.cboManufMenu4 = New Global.System.Windows.Forms.ComboBox()
			Me.cboManufMenu3 = New Global.System.Windows.Forms.ComboBox()
			Me.cboManufMenu2 = New Global.System.Windows.Forms.ComboBox()
			Me.cboManufMenu1 = New Global.System.Windows.Forms.ComboBox()
			Me.chkManufacturer1 = New Global.System.Windows.Forms.CheckBox()
			Me.rbtUseTemplateFiles = New Global.System.Windows.Forms.RadioButton()
			Me.rbtUseTemplateDatabase = New Global.System.Windows.Forms.RadioButton()
			Me.TreeView2 = New Global.System.Windows.Forms.TreeView()
			Me.pnlAdmin = New Global.System.Windows.Forms.Panel()
			Me.lblStatus2 = New Global.System.Windows.Forms.Label()
			Me.grpGuruAdmin = New Global.System.Windows.Forms.GroupBox()
			Me.chkDebug = New Global.System.Windows.Forms.CheckBox()
			Me.btnDiplayAllTemplates = New Global.System.Windows.Forms.Button()
			Me.tmrClock = New Global.System.Windows.Forms.Timer(Me.components)
			Me.pnlGeneral.SuspendLayout()
			Me.grpPredictMode.SuspendLayout()
			Me.grpLanguages.SuspendLayout()
			Me.grpSystemOfUnits.SuspendLayout()
			Me.grpPreferences.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			CType(Me.udMin, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.udHour, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.udSec_notused, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grpUseServerDatabase.SuspendLayout()
			Me.grpRodElement.SuspendLayout()
			Me.pnlDefaults.SuspendLayout()
			Me._SSFrame_8.SuspendLayout()
			Me.grpWarnings.SuspendLayout()
			Me.grpRatio.SuspendLayout()
			Me._SSFrame_3.SuspendLayout()
			Me.pnlBatchMode.SuspendLayout()
			Me.grpAutomaticBatchMode.SuspendLayout()
			CType(Me.nmUDMinute, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nmUDHour, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grpSpreadSheetSetup.SuspendLayout()
			Me.pnlCustomizeRGList.SuspendLayout()
			Me.pnlOutputOptions.SuspendLayout()
			Me.grpOutputOptions.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.SSPanel.SuspendLayout()
			CType(Me.imgPreview_10, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_9, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_6, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_3, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_5, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_0, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgPreview_1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grpOutputPages.SuspendLayout()
			Me.pnlDebug.SuspendLayout()
			Me.pnlCustomPUList.SuspendLayout()
			Me.pnlCustomMeasuredPUList.SuspendLayout()
			Me.pnlDebugOptions.SuspendLayout()
			Me.grpDebugOpt.SuspendLayout()
			Me.pnlSetupCostDB.SuspendLayout()
			Me.panContainer.SuspendLayout()
			Me._panCostCategory_1.SuspendLayout()
			Me._panCostCategory_0.SuspendLayout()
			Me.pnlPUCostDB.SuspendLayout()
			CType(Me.ulgPUCostDB, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlGuideCostDB.SuspendLayout()
			CType(Me.ulgGuideCostDB, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlRSCostDB.SuspendLayout()
			CType(Me.ulgRSCostDB, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlExpert.SuspendLayout()
			Me.grpTubingSizePreferences.SuspendLayout()
			Me.grpRodPreferences.SuspendLayout()
			Me.pnlUseRodOnly.SuspendLayout()
			Me.grpMotorPreferences.SuspendLayout()
			Me.pnlMotorData.SuspendLayout()
			Me.grpRodTubingFricCoeffPref.SuspendLayout()
			CType(Me.NumericUpDown1_XTimes, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grpPumpTypePreference.SuspendLayout()
			Me.grpTubingAnchoredPreference.SuspendLayout()
			Me.grpPumpUnitManufacturer_Preferences.SuspendLayout()
			Me.pnlUseGeneral.SuspendLayout()
			Me.pnlAdmin.SuspendLayout()
			Me.grpGuruAdmin.SuspendLayout()
			Me.SuspendLayout()
			Me.pnlGeneral.Controls.Add(Me.grpPredictMode)
			Me.pnlGeneral.Controls.Add(Me.grpLanguages)
			Me.pnlGeneral.Controls.Add(Me.grpSystemOfUnits)
			Me.pnlGeneral.Controls.Add(Me.grpPreferences)
			Me.pnlGeneral.Controls.Add(Me.GroupBox1)
			Me.pnlGeneral.Controls.Add(Me.grpUseServerDatabase)
			Me.pnlGeneral.Controls.Add(Me.grpRodElement)
			Dim pnlGeneral As Global.System.Windows.Forms.Control = Me.pnlGeneral
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(-1333, 16)
			pnlGeneral.Location = location
			Me.pnlGeneral.Name = "pnlGeneral"
			Me.HelpProvider1.SetShowHelp(Me.pnlGeneral, False)
			Dim pnlGeneral2 As Global.System.Windows.Forms.Control = Me.pnlGeneral
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(477, 445)
			pnlGeneral2.Size = size
			Me.pnlGeneral.TabIndex = 1
			Me.grpPredictMode.Controls.Add(Me.optDeviated)
			Me.grpPredictMode.Controls.Add(Me.optVertical)
			Dim grpPredictMode As Global.System.Windows.Forms.Control = Me.grpPredictMode
			location = New Global.System.Drawing.Point(16, 493)
			grpPredictMode.Location = location
			Me.grpPredictMode.Name = "grpPredictMode"
			Me.HelpProvider1.SetShowHelp(Me.grpPredictMode, False)
			Dim grpPredictMode2 As Global.System.Windows.Forms.Control = Me.grpPredictMode
			size = New Global.System.Drawing.Size(432, 56)
			grpPredictMode2.Size = size
			Me.grpPredictMode.TabIndex = 4
			Me.grpPredictMode.TabStop = False
			Me.grpPredictMode.Text = "RODSTAR Mode"
			Me.grpPredictMode.Visible = False
			Me.optDeviated.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optDeviated As Global.System.Windows.Forms.Control = Me.optDeviated
			location = New Global.System.Drawing.Point(136, 24)
			optDeviated.Location = location
			Me.optDeviated.Name = "optDeviated"
			Me.HelpProvider1.SetShowHelp(Me.optDeviated, False)
			Dim optDeviated2 As Global.System.Windows.Forms.Control = Me.optDeviated
			size = New Global.System.Drawing.Size(88, 16)
			optDeviated2.Size = size
			Me.optDeviated.TabIndex = 1
			Me.optDeviated.Text = "Deviated"
			Me.optVertical.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optVertical As Global.System.Windows.Forms.Control = Me.optVertical
			location = New Global.System.Drawing.Point(32, 24)
			optVertical.Location = location
			Me.optVertical.Name = "optVertical"
			Me.HelpProvider1.SetShowHelp(Me.optVertical, False)
			Dim optVertical2 As Global.System.Windows.Forms.Control = Me.optVertical
			size = New Global.System.Drawing.Size(88, 16)
			optVertical2.Size = size
			Me.optVertical.TabIndex = 0
			Me.optVertical.Text = "Vertical"
			Me.grpLanguages.Controls.Add(Me.rbtChinese)
			Me.grpLanguages.Controls.Add(Me.rbtSpan)
			Me.grpLanguages.Controls.Add(Me.rbtEng)
			Dim grpLanguages As Global.System.Windows.Forms.Control = Me.grpLanguages
			location = New Global.System.Drawing.Point(256, 8)
			grpLanguages.Location = location
			Me.grpLanguages.Name = "grpLanguages"
			Me.HelpProvider1.SetShowHelp(Me.grpLanguages, False)
			Dim grpLanguages2 As Global.System.Windows.Forms.Control = Me.grpLanguages
			size = New Global.System.Drawing.Size(205, 104)
			grpLanguages2.Size = size
			Me.grpLanguages.TabIndex = 5
			Me.grpLanguages.TabStop = False
			Me.grpLanguages.Text = "Languages"
			Me.HelpProvider1.SetHelpKeyword(Me.rbtChinese, "Setup General: Metric")
			Me.HelpProvider1.SetHelpNavigator(Me.rbtChinese, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.rbtChinese.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtChinese As Global.System.Windows.Forms.Control = Me.rbtChinese
			location = New Global.System.Drawing.Point(32, 69)
			rbtChinese.Location = location
			Me.rbtChinese.Name = "rbtChinese"
			Me.HelpProvider1.SetShowHelp(Me.rbtChinese, True)
			Dim rbtChinese2 As Global.System.Windows.Forms.Control = Me.rbtChinese
			size = New Global.System.Drawing.Size(128, 26)
			rbtChinese2.Size = size
			Me.rbtChinese.TabIndex = 2
			Me.rbtChinese.Text = "Chinese Simplified "
			Me.HelpProvider1.SetHelpKeyword(Me.rbtSpan, "Setup General: Canadian")
			Me.HelpProvider1.SetHelpNavigator(Me.rbtSpan, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.rbtSpan.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtSpan As Global.System.Windows.Forms.Control = Me.rbtSpan
			location = New Global.System.Drawing.Point(32, 48)
			rbtSpan.Location = location
			Me.rbtSpan.Name = "rbtSpan"
			Me.HelpProvider1.SetShowHelp(Me.rbtSpan, True)
			Dim rbtSpan2 As Global.System.Windows.Forms.Control = Me.rbtSpan
			size = New Global.System.Drawing.Size(128, 21)
			rbtSpan2.Size = size
			Me.rbtSpan.TabIndex = 1
			Me.rbtSpan.Text = "Spanish"
			Me.HelpProvider1.SetHelpKeyword(Me.rbtEng, "Setup General: English")
			Me.HelpProvider1.SetHelpNavigator(Me.rbtEng, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.rbtEng.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtEng As Global.System.Windows.Forms.Control = Me.rbtEng
			location = New Global.System.Drawing.Point(32, 24)
			rbtEng.Location = location
			Me.rbtEng.Name = "rbtEng"
			Me.HelpProvider1.SetShowHelp(Me.rbtEng, True)
			Dim rbtEng2 As Global.System.Windows.Forms.Control = Me.rbtEng
			size = New Global.System.Drawing.Size(128, 23)
			rbtEng2.Size = size
			Me.rbtEng.TabIndex = 0
			Me.rbtEng.Text = "English "
			Me.grpSystemOfUnits.Controls.Add(Me.rbtMetric)
			Me.grpSystemOfUnits.Controls.Add(Me.rbtCanadian)
			Me.grpSystemOfUnits.Controls.Add(Me.rbtEnglish)
			Dim grpSystemOfUnits As Global.System.Windows.Forms.Control = Me.grpSystemOfUnits
			location = New Global.System.Drawing.Point(16, 5)
			grpSystemOfUnits.Location = location
			Me.grpSystemOfUnits.Name = "grpSystemOfUnits"
			Me.HelpProvider1.SetShowHelp(Me.grpSystemOfUnits, False)
			Dim grpSystemOfUnits2 As Global.System.Windows.Forms.Control = Me.grpSystemOfUnits
			size = New Global.System.Drawing.Size(445, 114)
			grpSystemOfUnits2.Size = size
			Me.grpSystemOfUnits.TabIndex = 0
			Me.grpSystemOfUnits.TabStop = False
			Me.grpSystemOfUnits.Text = "System of units"
			Me.HelpProvider1.SetHelpKeyword(Me.rbtMetric, "Setup General: Metric")
			Me.HelpProvider1.SetHelpNavigator(Me.rbtMetric, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.rbtMetric.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtMetric As Global.System.Windows.Forms.Control = Me.rbtMetric
			location = New Global.System.Drawing.Point(24, 72)
			rbtMetric.Location = location
			Me.rbtMetric.Name = "rbtMetric"
			Me.HelpProvider1.SetShowHelp(Me.rbtMetric, True)
			Dim rbtMetric2 As Global.System.Windows.Forms.Control = Me.rbtMetric
			size = New Global.System.Drawing.Size(200, 16)
			rbtMetric2.Size = size
			Me.rbtMetric.TabIndex = 2
			Me.rbtMetric.Text = "Metric/SI (meters, newtons, etc.)"
			Me.HelpProvider1.SetHelpKeyword(Me.rbtCanadian, "Setup General: Canadian")
			Me.HelpProvider1.SetHelpNavigator(Me.rbtCanadian, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.rbtCanadian.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtCanadian As Global.System.Windows.Forms.Control = Me.rbtCanadian
			location = New Global.System.Drawing.Point(24, 48)
			rbtCanadian.Location = location
			Me.rbtCanadian.Name = "rbtCanadian"
			Me.HelpProvider1.SetShowHelp(Me.rbtCanadian, True)
			Dim rbtCanadian2 As Global.System.Windows.Forms.Control = Me.rbtCanadian
			size = New Global.System.Drawing.Size(200, 21)
			rbtCanadian2.Size = size
			Me.rbtCanadian.TabIndex = 1
			Me.rbtCanadian.Text = "Canadian (meters, lbs, etc.)"
			Me.HelpProvider1.SetHelpKeyword(Me.rbtEnglish, "Setup General: English")
			Me.HelpProvider1.SetHelpNavigator(Me.rbtEnglish, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.rbtEnglish.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtEnglish As Global.System.Windows.Forms.Control = Me.rbtEnglish
			location = New Global.System.Drawing.Point(24, 24)
			rbtEnglish.Location = location
			Me.rbtEnglish.Name = "rbtEnglish"
			Me.HelpProvider1.SetShowHelp(Me.rbtEnglish, True)
			Dim rbtEnglish2 As Global.System.Windows.Forms.Control = Me.rbtEnglish
			size = New Global.System.Drawing.Size(200, 23)
			rbtEnglish2.Size = size
			Me.rbtEnglish.TabIndex = 0
			Me.rbtEnglish.Text = "English (feet, lbs, etc.)"
			Me.grpPreferences.Controls.Add(Me.chkAlwaysSaveXDIAGMeasuredCard)
			Me.grpPreferences.Controls.Add(Me.chkDisplaySBinFeet)
			Me.grpPreferences.Controls.Add(Me.chkShowVisualInputWindow)
			Me.grpPreferences.Controls.Add(Me.cboDigitizerComPort)
			Me.grpPreferences.Controls.Add(Me.lblDigitizerComPort)
			Dim grpPreferences As Global.System.Windows.Forms.Control = Me.grpPreferences
			location = New Global.System.Drawing.Point(16, 123)
			grpPreferences.Location = location
			Me.grpPreferences.Name = "grpPreferences"
			Me.HelpProvider1.SetShowHelp(Me.grpPreferences, False)
			Dim grpPreferences2 As Global.System.Windows.Forms.Control = Me.grpPreferences
			size = New Global.System.Drawing.Size(445, 104)
			grpPreferences2.Size = size
			Me.grpPreferences.TabIndex = 1
			Me.grpPreferences.TabStop = False
			Me.grpPreferences.Text = "Preferences"
			Me.HelpProvider1.SetHelpKeyword(Me.chkAlwaysSaveXDIAGMeasuredCard, "Save XDIAG imported dyno card to RODSTAR file")
			Me.HelpProvider1.SetHelpNavigator(Me.chkAlwaysSaveXDIAGMeasuredCard, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkAlwaysSaveXDIAGMeasuredCard.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkAlwaysSaveXDIAGMeasuredCard As Global.System.Windows.Forms.Control = Me.chkAlwaysSaveXDIAGMeasuredCard
			location = New Global.System.Drawing.Point(32, 72)
			chkAlwaysSaveXDIAGMeasuredCard.Location = location
			Me.chkAlwaysSaveXDIAGMeasuredCard.Name = "chkAlwaysSaveXDIAGMeasuredCard"
			Me.HelpProvider1.SetShowHelp(Me.chkAlwaysSaveXDIAGMeasuredCard, True)
			Dim chkAlwaysSaveXDIAGMeasuredCard2 As Global.System.Windows.Forms.Control = Me.chkAlwaysSaveXDIAGMeasuredCard
			size = New Global.System.Drawing.Size(360, 16)
			chkAlwaysSaveXDIAGMeasuredCard2.Size = size
			Me.chkAlwaysSaveXDIAGMeasuredCard.TabIndex = 4
			Me.chkAlwaysSaveXDIAGMeasuredCard.Text = "Save XDIAG imported dyno card to RODSTAR file"
			Me.HelpProvider1.SetHelpKeyword(Me.chkDisplaySBinFeet, "Display Sinker Bars in Feet")
			Me.HelpProvider1.SetHelpNavigator(Me.chkDisplaySBinFeet, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkDisplaySBinFeet.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDisplaySBinFeet As Global.System.Windows.Forms.Control = Me.chkDisplaySBinFeet
			location = New Global.System.Drawing.Point(32, 48)
			chkDisplaySBinFeet.Location = location
			Me.chkDisplaySBinFeet.Name = "chkDisplaySBinFeet"
			Me.HelpProvider1.SetShowHelp(Me.chkDisplaySBinFeet, True)
			Dim chkDisplaySBinFeet2 As Global.System.Windows.Forms.Control = Me.chkDisplaySBinFeet
			size = New Global.System.Drawing.Size(312, 18)
			chkDisplaySBinFeet2.Size = size
			Me.chkDisplaySBinFeet.TabIndex = 3
			Me.chkDisplaySBinFeet.Text = "Display Sinker Bars in Feet"
			Me.chkDisplaySBinFeet.Visible = False
			Me.chkShowVisualInputWindow.Checked = True
			Me.chkShowVisualInputWindow.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.HelpProvider1.SetHelpKeyword(Me.chkShowVisualInputWindow, "Setup General: Show Visual Input")
			Me.HelpProvider1.SetHelpNavigator(Me.chkShowVisualInputWindow, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkShowVisualInputWindow.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkShowVisualInputWindow As Global.System.Windows.Forms.Control = Me.chkShowVisualInputWindow
			location = New Global.System.Drawing.Point(32, 24)
			chkShowVisualInputWindow.Location = location
			Me.chkShowVisualInputWindow.Name = "chkShowVisualInputWindow"
			Me.HelpProvider1.SetShowHelp(Me.chkShowVisualInputWindow, True)
			Dim chkShowVisualInputWindow2 As Global.System.Windows.Forms.Control = Me.chkShowVisualInputWindow
			size = New Global.System.Drawing.Size(312, 18)
			chkShowVisualInputWindow2.Size = size
			Me.chkShowVisualInputWindow.TabIndex = 0
			Me.chkShowVisualInputWindow.Text = "Show Visual Input Window"
			Me.cboDigitizerComPort.ItemHeight = 13
			Dim cboDigitizerComPort As Global.System.Windows.Forms.Control = Me.cboDigitizerComPort
			location = New Global.System.Drawing.Point(176, 128)
			cboDigitizerComPort.Location = location
			Me.cboDigitizerComPort.Name = "cboDigitizerComPort"
			Me.HelpProvider1.SetShowHelp(Me.cboDigitizerComPort, False)
			Dim cboDigitizerComPort2 As Global.System.Windows.Forms.Control = Me.cboDigitizerComPort
			size = New Global.System.Drawing.Size(72, 21)
			cboDigitizerComPort2.Size = size
			Me.cboDigitizerComPort.TabIndex = 1
			Me.cboDigitizerComPort.Visible = False
			Me.lblDigitizerComPort.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblDigitizerComPort As Global.System.Windows.Forms.Control = Me.lblDigitizerComPort
			location = New Global.System.Drawing.Point(24, 128)
			lblDigitizerComPort.Location = location
			Me.lblDigitizerComPort.Name = "lblDigitizerComPort"
			Me.HelpProvider1.SetShowHelp(Me.lblDigitizerComPort, False)
			Dim lblDigitizerComPort2 As Global.System.Windows.Forms.Control = Me.lblDigitizerComPort
			size = New Global.System.Drawing.Size(160, 16)
			lblDigitizerComPort2.Size = size
			Me.lblDigitizerComPort.TabIndex = 2
			Me.lblDigitizerComPort.Text = "Digitizer COM port connection: "
			Me.lblDigitizerComPort.Visible = False
			Me.GroupBox1.Controls.Add(Me.udMin)
			Me.GroupBox1.Controls.Add(Me.udHour)
			Me.GroupBox1.Controls.Add(Me.lblMIN)
			Me.GroupBox1.Controls.Add(Me.lblHRS)
			Me.GroupBox1.Controls.Add(Me.chkSaveOpenFileOnExit)
			Me.GroupBox1.Controls.Add(Me.udSec_notused)
			Me.GroupBox1.Controls.Add(Me.chkExitIfIdle)
			Me.GroupBox1.Controls.Add(Me.lblExitIfIdle)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(16, 229)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Me.HelpProvider1.SetShowHelp(Me.GroupBox1, False)
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(445, 91)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 6
			Me.GroupBox1.TabStop = False
			Me.HelpProvider1.SetHelpKeyword(Me.udMin, "Exit program if idle")
			Me.HelpProvider1.SetHelpNavigator(Me.udMin, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim udMin As Global.System.Windows.Forms.Control = Me.udMin
			location = New Global.System.Drawing.Point(213, 38)
			udMin.Location = location
			Me.udMin.Name = "udMin"
			Me.HelpProvider1.SetShowHelp(Me.udMin, True)
			Dim udMin2 As Global.System.Windows.Forms.Control = Me.udMin
			size = New Global.System.Drawing.Size(40, 20)
			udMin2.Size = size
			Me.udMin.TabIndex = 12
			Me.HelpProvider1.SetHelpKeyword(Me.udHour, "Exit program if idle")
			Me.HelpProvider1.SetHelpNavigator(Me.udHour, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim udHour As Global.System.Windows.Forms.Control = Me.udHour
			location = New Global.System.Drawing.Point(141, 38)
			udHour.Location = location
			Me.udHour.Name = "udHour"
			Me.HelpProvider1.SetShowHelp(Me.udHour, True)
			Dim udHour2 As Global.System.Windows.Forms.Control = Me.udHour
			size = New Global.System.Drawing.Size(40, 20)
			udHour2.Size = size
			Me.udHour.TabIndex = 11
			Dim lblMIN As Global.System.Windows.Forms.Control = Me.lblMIN
			location = New Global.System.Drawing.Point(184, 40)
			lblMIN.Location = location
			Me.lblMIN.Name = "lblMIN"
			Dim lblMIN2 As Global.System.Windows.Forms.Control = Me.lblMIN
			size = New Global.System.Drawing.Size(40, 19)
			lblMIN2.Size = size
			Me.lblMIN.TabIndex = 17
			Me.lblMIN.Text = "MIN"
			Dim lblHRS As Global.System.Windows.Forms.Control = Me.lblHRS
			location = New Global.System.Drawing.Point(115, 40)
			lblHRS.Location = location
			Me.lblHRS.Name = "lblHRS"
			Dim lblHRS2 As Global.System.Windows.Forms.Control = Me.lblHRS
			size = New Global.System.Drawing.Size(25, 19)
			lblHRS2.Size = size
			Me.lblHRS.TabIndex = 16
			Me.lblHRS.Text = "HR"
			Me.HelpProvider1.SetHelpKeyword(Me.chkSaveOpenFileOnExit, "Exit program if idle")
			Me.HelpProvider1.SetHelpNavigator(Me.chkSaveOpenFileOnExit, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkSaveOpenFileOnExit.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkSaveOpenFileOnExit As Global.System.Windows.Forms.Control = Me.chkSaveOpenFileOnExit
			location = New Global.System.Drawing.Point(49, 61)
			chkSaveOpenFileOnExit.Location = location
			Me.chkSaveOpenFileOnExit.Name = "chkSaveOpenFileOnExit"
			Me.HelpProvider1.SetShowHelp(Me.chkSaveOpenFileOnExit, True)
			Dim chkSaveOpenFileOnExit2 As Global.System.Windows.Forms.Control = Me.chkSaveOpenFileOnExit
			size = New Global.System.Drawing.Size(199, 24)
			chkSaveOpenFileOnExit2.Size = size
			Me.chkSaveOpenFileOnExit.TabIndex = 15
			Me.chkSaveOpenFileOnExit.Text = "Save Open File on Exit"
			Me.HelpProvider1.SetHelpKeyword(Me.udSec_notused, "Exit program if idle")
			Me.HelpProvider1.SetHelpNavigator(Me.udSec_notused, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim udSec_notused As Global.System.Windows.Forms.Control = Me.udSec_notused
			location = New Global.System.Drawing.Point(264, 38)
			udSec_notused.Location = location
			Me.udSec_notused.Name = "udSec_notused"
			Me.HelpProvider1.SetShowHelp(Me.udSec_notused, True)
			Dim udSec_notused2 As Global.System.Windows.Forms.Control = Me.udSec_notused
			size = New Global.System.Drawing.Size(40, 20)
			udSec_notused2.Size = size
			Me.udSec_notused.TabIndex = 14
			Me.udSec_notused.Visible = False
			Me.HelpProvider1.SetHelpKeyword(Me.chkExitIfIdle, "Exit program if idle")
			Me.HelpProvider1.SetHelpNavigator(Me.chkExitIfIdle, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkExitIfIdle.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkExitIfIdle As Global.System.Windows.Forms.Control = Me.chkExitIfIdle
			location = New Global.System.Drawing.Point(32, 11)
			chkExitIfIdle.Location = location
			Me.chkExitIfIdle.Name = "chkExitIfIdle"
			Me.HelpProvider1.SetShowHelp(Me.chkExitIfIdle, True)
			Dim chkExitIfIdle2 As Global.System.Windows.Forms.Control = Me.chkExitIfIdle
			size = New Global.System.Drawing.Size(152, 25)
			chkExitIfIdle2.Size = size
			Me.chkExitIfIdle.TabIndex = 13
			Me.chkExitIfIdle.Text = "Exit program if idle"
			Me.lblExitIfIdle.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblExitIfIdle As Global.System.Windows.Forms.Control = Me.lblExitIfIdle
			location = New Global.System.Drawing.Point(49, 39)
			lblExitIfIdle.Location = location
			Me.lblExitIfIdle.Name = "lblExitIfIdle"
			Me.HelpProvider1.SetShowHelp(Me.lblExitIfIdle, False)
			Dim lblExitIfIdle2 As Global.System.Windows.Forms.Control = Me.lblExitIfIdle
			size = New Global.System.Drawing.Size(71, 22)
			lblExitIfIdle2.Size = size
			Me.lblExitIfIdle.TabIndex = 0
			Me.lblExitIfIdle.Text = "Idle Interval:"
			Me.grpUseServerDatabase.Controls.Add(Me.btnSynch)
			Me.grpUseServerDatabase.Controls.Add(Me.btnVerifyData)
			Me.grpUseServerDatabase.Controls.Add(Me.btnVerifyFiles)
			Me.grpUseServerDatabase.Controls.Add(Me.txtDBServerFolder)
			Me.grpUseServerDatabase.Controls.Add(Me.btnBrowseForServerFolder)
			Me.grpUseServerDatabase.Controls.Add(Me.lblDBServerFolder)
			Me.grpUseServerDatabase.Controls.Add(Me.rbtUseServerLocation)
			Me.grpUseServerDatabase.Controls.Add(Me.rptUseLocalDatabase)
			Dim grpUseServerDatabase As Global.System.Windows.Forms.Control = Me.grpUseServerDatabase
			location = New Global.System.Drawing.Point(16, 324)
			grpUseServerDatabase.Location = location
			Me.grpUseServerDatabase.Name = "grpUseServerDatabase"
			Dim grpUseServerDatabase2 As Global.System.Windows.Forms.Control = Me.grpUseServerDatabase
			size = New Global.System.Drawing.Size(445, 105)
			grpUseServerDatabase2.Size = size
			Me.grpUseServerDatabase.TabIndex = 8
			Me.grpUseServerDatabase.TabStop = False
			Me.grpUseServerDatabase.Text = "Location of User Entered Database Files"
			Me.HelpProvider1.SetHelpKeyword(Me.btnSynch, "Setup Batch: RODSTAR Folder")
			Me.HelpProvider1.SetHelpNavigator(Me.btnSynch, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.btnSynch.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnSynch As Global.System.Windows.Forms.Control = Me.btnSynch
			location = New Global.System.Drawing.Point(291, 77)
			btnSynch.Location = location
			Me.btnSynch.Name = "btnSynch"
			Me.HelpProvider1.SetShowHelp(Me.btnSynch, True)
			Dim btnSynch2 As Global.System.Windows.Forms.Control = Me.btnSynch
			size = New Global.System.Drawing.Size(140, 22)
			btnSynch2.Size = size
			Me.btnSynch.TabIndex = 21
			Me.btnSynch.Text = " Synchronize Databases"
			Dim btnVerifyData As Global.System.Windows.Forms.Control = Me.btnVerifyData
			location = New Global.System.Drawing.Point(351, 76)
			btnVerifyData.Location = location
			Me.btnVerifyData.Name = "btnVerifyData"
			Dim btnVerifyData2 As Global.System.Windows.Forms.Control = Me.btnVerifyData
			size = New Global.System.Drawing.Size(80, 22)
			btnVerifyData2.Size = size
			Me.btnVerifyData.TabIndex = 20
			Me.btnVerifyData.Text = "Verify Data"
			Me.btnVerifyData.UseVisualStyleBackColor = True
			Me.HelpProvider1.SetHelpKeyword(Me.btnVerifyFiles, "Setup Batch: RODSTAR Folder")
			Me.HelpProvider1.SetHelpNavigator(Me.btnVerifyFiles, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.btnVerifyFiles.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnVerifyFiles As Global.System.Windows.Forms.Control = Me.btnVerifyFiles
			location = New Global.System.Drawing.Point(351, 76)
			btnVerifyFiles.Location = location
			Me.btnVerifyFiles.Name = "btnVerifyFiles"
			Me.HelpProvider1.SetShowHelp(Me.btnVerifyFiles, True)
			Dim btnVerifyFiles2 As Global.System.Windows.Forms.Control = Me.btnVerifyFiles
			size = New Global.System.Drawing.Size(80, 22)
			btnVerifyFiles2.Size = size
			Me.btnVerifyFiles.TabIndex = 19
			Me.btnVerifyFiles.Text = " Verify Files"
			Me.HelpProvider1.SetHelpKeyword(Me.txtDBServerFolder, "Setup Batch: RODSTAR Folder")
			Me.HelpProvider1.SetHelpNavigator(Me.txtDBServerFolder, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtDBServerFolder As Global.System.Windows.Forms.Control = Me.txtDBServerFolder
			location = New Global.System.Drawing.Point(174, 50)
			txtDBServerFolder.Location = location
			Me.txtDBServerFolder.Name = "txtDBServerFolder"
			Me.HelpProvider1.SetShowHelp(Me.txtDBServerFolder, True)
			Dim txtDBServerFolder2 As Global.System.Windows.Forms.Control = Me.txtDBServerFolder
			size = New Global.System.Drawing.Size(173, 20)
			txtDBServerFolder2.Size = size
			Me.txtDBServerFolder.TabIndex = 17
			Me.HelpProvider1.SetHelpKeyword(Me.btnBrowseForServerFolder, "Setup Batch: RODSTAR Folder")
			Me.HelpProvider1.SetHelpNavigator(Me.btnBrowseForServerFolder, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.btnBrowseForServerFolder.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnBrowseForServerFolder As Global.System.Windows.Forms.Control = Me.btnBrowseForServerFolder
			location = New Global.System.Drawing.Point(351, 49)
			btnBrowseForServerFolder.Location = location
			Me.btnBrowseForServerFolder.Name = "btnBrowseForServerFolder"
			Me.HelpProvider1.SetShowHelp(Me.btnBrowseForServerFolder, True)
			Dim btnBrowseForServerFolder2 As Global.System.Windows.Forms.Control = Me.btnBrowseForServerFolder
			size = New Global.System.Drawing.Size(80, 22)
			btnBrowseForServerFolder2.Size = size
			Me.btnBrowseForServerFolder.TabIndex = 18
			Me.btnBrowseForServerFolder.Text = "Browse.."
			Me.lblDBServerFolder.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblDBServerFolder As Global.System.Windows.Forms.Control = Me.lblDBServerFolder
			location = New Global.System.Drawing.Point(32, 50)
			lblDBServerFolder.Location = location
			Me.lblDBServerFolder.Name = "lblDBServerFolder"
			Me.HelpProvider1.SetShowHelp(Me.lblDBServerFolder, False)
			Dim lblDBServerFolder2 As Global.System.Windows.Forms.Control = Me.lblDBServerFolder
			size = New Global.System.Drawing.Size(140, 20)
			lblDBServerFolder2.Size = size
			Me.lblDBServerFolder.TabIndex = 16
			Me.lblDBServerFolder.Text = "Server Database Folder:"
			Me.rbtUseServerLocation.AutoSize = True
			Dim rbtUseServerLocation As Global.System.Windows.Forms.Control = Me.rbtUseServerLocation
			location = New Global.System.Drawing.Point(225, 19)
			rbtUseServerLocation.Location = location
			Me.rbtUseServerLocation.Name = "rbtUseServerLocation"
			Dim rbtUseServerLocation2 As Global.System.Windows.Forms.Control = Me.rbtUseServerLocation
			size = New Global.System.Drawing.Size(122, 17)
			rbtUseServerLocation2.Size = size
			Me.rbtUseServerLocation.TabIndex = 1
			Me.rbtUseServerLocation.TabStop = True
			Me.rbtUseServerLocation.Text = "Use Server Location"
			Me.rbtUseServerLocation.UseVisualStyleBackColor = True
			Me.rptUseLocalDatabase.AutoSize = True
			Dim rptUseLocalDatabase As Global.System.Windows.Forms.Control = Me.rptUseLocalDatabase
			location = New Global.System.Drawing.Point(32, 19)
			rptUseLocalDatabase.Location = location
			Me.rptUseLocalDatabase.Name = "rptUseLocalDatabase"
			Dim rptUseLocalDatabase2 As Global.System.Windows.Forms.Control = Me.rptUseLocalDatabase
			size = New Global.System.Drawing.Size(166, 17)
			rptUseLocalDatabase2.Size = size
			Me.rptUseLocalDatabase.TabIndex = 0
			Me.rptUseLocalDatabase.TabStop = True
			Me.rptUseLocalDatabase.Text = "Use default computer location"
			Me.rptUseLocalDatabase.UseVisualStyleBackColor = True
			Me.grpRodElement.Controls.Add(Me.txtRodElementLimit)
			Me.grpRodElement.Controls.Add(Me.lblRodElementLimit)
			Me.grpRodElement.Controls.Add(Me.chkUseDefaultRodElementLimit)
			Dim grpRodElement As Global.System.Windows.Forms.Control = Me.grpRodElement
			location = New Global.System.Drawing.Point(256, 16)
			grpRodElement.Location = location
			Me.grpRodElement.Name = "grpRodElement"
			Dim grpRodElement2 As Global.System.Windows.Forms.Control = Me.grpRodElement
			size = New Global.System.Drawing.Size(205, 104)
			grpRodElement2.Size = size
			Me.grpRodElement.TabIndex = 7
			Me.grpRodElement.TabStop = False
			Me.txtRodElementLimit.AcceptsReturn = True
			Me.txtRodElementLimit.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtRodElementLimit.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtRodElementLimit.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Me.txtRodElementLimit.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtRodElementLimit, "")
			Me.HelpProvider1.SetHelpNavigator(Me.txtRodElementLimit, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtRodElementLimit As Global.System.Windows.Forms.Control = Me.txtRodElementLimit
			location = New Global.System.Drawing.Point(105, 41)
			txtRodElementLimit.Location = location
			Me.txtRodElementLimit.MaxLength = 10
			Me.txtRodElementLimit.Name = "txtRodElementLimit"
			Me.txtRodElementLimit.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtRodElementLimit, True)
			Dim txtRodElementLimit2 As Global.System.Windows.Forms.Control = Me.txtRodElementLimit
			size = New Global.System.Drawing.Size(55, 23)
			txtRodElementLimit2.Size = size
			Me.txtRodElementLimit.TabIndex = 176
			Me.txtRodElementLimit.Tag = ""
			Me.lblRodElementLimit.AutoSize = True
			Me.lblRodElementLimit.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblRodElementLimit As Global.System.Windows.Forms.Control = Me.lblRodElementLimit
			location = New Global.System.Drawing.Point(6, 41)
			lblRodElementLimit.Location = location
			Me.lblRodElementLimit.Name = "lblRodElementLimit"
			Me.HelpProvider1.SetShowHelp(Me.lblRodElementLimit, False)
			Dim lblRodElementLimit2 As Global.System.Windows.Forms.Control = Me.lblRodElementLimit
			size = New Global.System.Drawing.Size(95, 13)
			lblRodElementLimit2.Size = size
			Me.lblRodElementLimit.TabIndex = 15
			Me.lblRodElementLimit.Text = "Rod Element Limit:"
			Me.HelpProvider1.SetHelpKeyword(Me.chkUseDefaultRodElementLimit, "Display Sinker Bars in Feet")
			Me.HelpProvider1.SetHelpNavigator(Me.chkUseDefaultRodElementLimit, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkUseDefaultRodElementLimit.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkUseDefaultRodElementLimit As Global.System.Windows.Forms.Control = Me.chkUseDefaultRodElementLimit
			location = New Global.System.Drawing.Point(8, 16)
			chkUseDefaultRodElementLimit.Location = location
			Me.chkUseDefaultRodElementLimit.Name = "chkUseDefaultRodElementLimit"
			Me.HelpProvider1.SetShowHelp(Me.chkUseDefaultRodElementLimit, True)
			Dim chkUseDefaultRodElementLimit2 As Global.System.Windows.Forms.Control = Me.chkUseDefaultRodElementLimit
			size = New Global.System.Drawing.Size(178, 20)
			chkUseDefaultRodElementLimit2.Size = size
			Me.chkUseDefaultRodElementLimit.TabIndex = 14
			Me.chkUseDefaultRodElementLimit.Text = "Use Default Rod Element Limit"
			Me.pnlDefaults.Controls.Add(Me.chkRelocateSB)
			Me.pnlDefaults.Controls.Add(Me.lblInclinationLimit)
			Me.pnlDefaults.Controls.Add(Me.txtInclinationLimit)
			Me.pnlDefaults.Controls.Add(Me._SSFrame_8)
			Me.pnlDefaults.Controls.Add(Me.txtMDInt)
			Me.pnlDefaults.Controls.Add(Me.lblDoglegLimit)
			Me.pnlDefaults.Controls.Add(Me.txtDoglegLimit)
			Me.pnlDefaults.Controls.Add(Me.lblMDInt)
			Me.pnlDefaults.Controls.Add(Me.chkUseJeffsFix)
			Me.pnlDefaults.Controls.Add(Me.chkUseJohnsFix)
			Me.pnlDefaults.Controls.Add(Me.chkUseBucklingTendencyStresses)
			Me.pnlDefaults.Controls.Add(Me.chkUseAllDiameters)
			Me.pnlDefaults.Controls.Add(Me.grpWarnings)
			Me.pnlDefaults.Controls.Add(Me.chkOptimizeSurvey)
			Me.pnlDefaults.Controls.Add(Me.btnDefault)
			Me.pnlDefaults.Controls.Add(Me.grpRatio)
			Me.pnlDefaults.Controls.Add(Me.chkAllowSlideFric)
			Me.pnlDefaults.Controls.Add(Me._SSFrame_3)
			Me.pnlDefaults.Controls.Add(Me.chkAzDirToolbar)
			Me.pnlDefaults.Controls.Add(Me.lblDefaultType)
			Me.pnlDefaults.Controls.Add(Me.lstDefaultItems)
			Me.pnlDefaults.Controls.Add(Me.lblDefault)
			Me.pnlDefaults.Controls.Add(Me.lblItem)
			Me.pnlDefaults.Controls.Add(Me.txtDefault)
			Me.pnlDefaults.Controls.Add(Me.cboDefault)
			Me.pnlDefaults.Controls.Add(Me.rtbDefault)
			Dim pnlDefaults As Global.System.Windows.Forms.Control = Me.pnlDefaults
			location = New Global.System.Drawing.Point(-1333, 7)
			pnlDefaults.Location = location
			Me.pnlDefaults.Name = "pnlDefaults"
			Me.HelpProvider1.SetShowHelp(Me.pnlDefaults, False)
			Dim pnlDefaults2 As Global.System.Windows.Forms.Control = Me.pnlDefaults
			size = New Global.System.Drawing.Size(674, 523)
			pnlDefaults2.Size = size
			Me.pnlDefaults.TabIndex = 2
			Me.chkRelocateSB.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkRelocateSB.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkRelocateSB.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.chkRelocateSB.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.chkRelocateSB, "Fluid inertia effects popup")
			Me.HelpProvider1.SetHelpNavigator(Me.chkRelocateSB, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkRelocateSB.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkRelocateSB As Global.System.Windows.Forms.Control = Me.chkRelocateSB
			location = New Global.System.Drawing.Point(321, 479)
			chkRelocateSB.Location = location
			Me.chkRelocateSB.Name = "chkRelocateSB"
			Me.chkRelocateSB.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkRelocateSB, True)
			Dim chkRelocateSB2 As Global.System.Windows.Forms.Control = Me.chkRelocateSB
			size = New Global.System.Drawing.Size(264, 19)
			chkRelocateSB2.Size = size
			Me.chkRelocateSB.TabIndex = 238
			Me.chkRelocateSB.Text = "Relocate Sinker bars based on inclinations"
			Me.chkRelocateSB.UseVisualStyleBackColor = False
			Me.lblInclinationLimit.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblInclinationLimit.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblInclinationLimit.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblInclinationLimit.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblInclinationLimit.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblInclinationLimit As Global.System.Windows.Forms.Control = Me.lblInclinationLimit
			location = New Global.System.Drawing.Point(348, 498)
			lblInclinationLimit.Location = location
			Me.lblInclinationLimit.Name = "lblInclinationLimit"
			Me.lblInclinationLimit.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblInclinationLimit, False)
			Dim lblInclinationLimit2 As Global.System.Windows.Forms.Control = Me.lblInclinationLimit
			size = New Global.System.Drawing.Size(201, 19)
			lblInclinationLimit2.Size = size
			Me.lblInclinationLimit.TabIndex = 240
			Me.lblInclinationLimit.Text = "Inclination Limit (4° to 50°):"
			Me.lblInclinationLimit.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.txtInclinationLimit.AcceptsReturn = True
			Me.txtInclinationLimit.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtInclinationLimit.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtInclinationLimit.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtInclinationLimit.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtInclinationLimit, "Fluid Compressibility Index")
			Me.HelpProvider1.SetHelpNavigator(Me.txtInclinationLimit, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtInclinationLimit As Global.System.Windows.Forms.Control = Me.txtInclinationLimit
			location = New Global.System.Drawing.Point(553, 498)
			txtInclinationLimit.Location = location
			Me.txtInclinationLimit.MaxLength = 10
			Me.txtInclinationLimit.Name = "txtInclinationLimit"
			Me.txtInclinationLimit.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtInclinationLimit, True)
			Dim txtInclinationLimit2 As Global.System.Windows.Forms.Control = Me.txtInclinationLimit
			size = New Global.System.Drawing.Size(61, 20)
			txtInclinationLimit2.Size = size
			Me.txtInclinationLimit.TabIndex = 239
			Me._SSFrame_8.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSFrame_8.Controls.Add(Me.cboParaffinRodGuide)
			Me._SSFrame_8.Controls.Add(Me.lblParaffinGuides)
			Me._SSFrame_8.Controls.Add(Me.txtNumRodsPerBundle)
			Me._SSFrame_8.Controls.Add(Me.lblNumRodsPerBundle)
			Me._SSFrame_8.Controls.Add(Me.txtRodGuideOverlap)
			Me._SSFrame_8.Controls.Add(Me.lblRodGuideOverlap)
			Me._SSFrame_8.Controls.Add(Me.lblIterations)
			Me._SSFrame_8.Controls.Add(Me.lblMaxSideLoadLimit)
			Me._SSFrame_8.Controls.Add(Me.cmdResetFrictions)
			Me._SSFrame_8.Controls.Add(Me.lblSideLoadperRodGuide)
			Me._SSFrame_8.Controls.Add(Me.cboSidewinder)
			Me._SSFrame_8.Controls.Add(Me.txtMinNumGuides)
			Me._SSFrame_8.Controls.Add(Me.lblMaxNumGuides)
			Me._SSFrame_8.Controls.Add(Me.lblGuides)
			Me._SSFrame_8.Controls.Add(Me.txtOther)
			Me._SSFrame_8.Controls.Add(Me.txtNorrisFricCoeff)
			Me._SSFrame_8.Controls.Add(Me.optSideWinder)
			Me._SSFrame_8.Controls.Add(Me.chkUseFluidInertiaPumpLoadAdj)
			Me._SSFrame_8.Controls.Add(Me.txtWeightAdjustFactor)
			Me._SSFrame_8.Controls.Add(Me.lblWeightAdjustFactor)
			Me._SSFrame_8.Controls.Add(Me.txtOtherFricCoeff)
			Me._SSFrame_8.Controls.Add(Me.txtWheelFricCoeff)
			Me._SSFrame_8.Controls.Add(Me.txtMoldedFricCoeff)
			Me._SSFrame_8.Controls.Add(Me.lblNumCycles)
			Me._SSFrame_8.Controls.Add(Me.txtNumCycles)
			Me._SSFrame_8.Controls.Add(Me.optOther)
			Me._SSFrame_8.Controls.Add(Me.txtMaxNumGuides)
			Me._SSFrame_8.Controls.Add(Me.lblMinNumGuides)
			Me._SSFrame_8.Controls.Add(Me.optMolded)
			Me._SSFrame_8.Controls.Add(Me.optWheel)
			Me._SSFrame_8.Controls.Add(Me.txtMoldedLoad)
			Me._SSFrame_8.Controls.Add(Me.txtOtherLoad)
			Me._SSFrame_8.Controls.Add(Me.txtWheelLoad)
			Me._SSFrame_8.Controls.Add(Me.txtSidewinderLoad)
			Me._SSFrame_8.Controls.Add(Me.lblFricCoeff)
			Me._SSFrame_8.Controls.Add(Me.txtNumImplIters)
			Me._SSFrame_8.Controls.Add(Me.rbtBareRod)
			Me._SSFrame_8.Controls.Add(Me.txtBareRodFricCoeff)
			Me._SSFrame_8.Controls.Add(Me.txtMaxSideLoadLimit)
			Me._SSFrame_8.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me._SSFrame_8.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._SSFrame_8, "Rod Guides")
			Dim ssframe_ As Global.System.Windows.Forms.Control = Me._SSFrame_8
			location = New Global.System.Drawing.Point(8, 280)
			ssframe_.Location = location
			Me._SSFrame_8.Name = "_SSFrame_8"
			Me._SSFrame_8.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._SSFrame_8, True)
			Dim ssframe_2 As Global.System.Windows.Forms.Control = Me._SSFrame_8
			size = New Global.System.Drawing.Size(658, 197)
			ssframe_2.Size = size
			Me._SSFrame_8.TabIndex = 103
			Me._SSFrame_8.TabStop = False
			Me._SSFrame_8.Text = "Rod Guide Defaults"
			Me.cboParaffinRodGuide.AllowDrop = True
			Me.cboParaffinRodGuide.BackColor = Global.System.Drawing.Color.White
			Me.cboParaffinRodGuide.DropDownWidth = 200
			Me.cboParaffinRodGuide.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.HelpProvider1.SetHelpKeyword(Me.cboParaffinRodGuide, "rod section grade")
			Me.HelpProvider1.SetHelpNavigator(Me.cboParaffinRodGuide, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboParaffinRodGuide.ItemHeight = 14
			Dim cboParaffinRodGuide As Global.System.Windows.Forms.Control = Me.cboParaffinRodGuide
			location = New Global.System.Drawing.Point(478, 171)
			cboParaffinRodGuide.Location = location
			Me.cboParaffinRodGuide.MaxDropDownItems = 12
			Me.cboParaffinRodGuide.MaxLength = 100
			Me.cboParaffinRodGuide.Name = "cboParaffinRodGuide"
			Me.HelpProvider1.SetShowHelp(Me.cboParaffinRodGuide, True)
			Dim cboParaffinRodGuide2 As Global.System.Windows.Forms.Control = Me.cboParaffinRodGuide
			size = New Global.System.Drawing.Size(176, 22)
			cboParaffinRodGuide2.Size = size
			Me.cboParaffinRodGuide.TabIndex = 250
			Me.lblParaffinGuides.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblParaffinGuides.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblParaffinGuides.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8F)
			Me.lblParaffinGuides.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblParaffinGuides.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblParaffinGuides As Global.System.Windows.Forms.Control = Me.lblParaffinGuides
			location = New Global.System.Drawing.Point(368, 173)
			lblParaffinGuides.Location = location
			Me.lblParaffinGuides.Name = "lblParaffinGuides"
			Me.lblParaffinGuides.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblParaffinGuides, False)
			Dim lblParaffinGuides2 As Global.System.Windows.Forms.Control = Me.lblParaffinGuides
			size = New Global.System.Drawing.Size(106, 19)
			lblParaffinGuides2.Size = size
			Me.lblParaffinGuides.TabIndex = 251
			Me.lblParaffinGuides.Text = "Paraffin Rod Guide:"
			Me.lblParaffinGuides.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.HelpProvider1.SetHelpKeyword(Me.txtNumRodsPerBundle, "Number of rods per segment")
			Me.HelpProvider1.SetHelpNavigator(Me.txtNumRodsPerBundle, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtNumRodsPerBundle As Global.System.Windows.Forms.Control = Me.txtNumRodsPerBundle
			location = New Global.System.Drawing.Point(585, 149)
			txtNumRodsPerBundle.Location = location
			Me.txtNumRodsPerBundle.Name = "txtNumRodsPerBundle"
			Me.HelpProvider1.SetShowHelp(Me.txtNumRodsPerBundle, True)
			Dim txtNumRodsPerBundle2 As Global.System.Windows.Forms.Control = Me.txtNumRodsPerBundle
			size = New Global.System.Drawing.Size(55, 20)
			txtNumRodsPerBundle2.Size = size
			Me.txtNumRodsPerBundle.TabIndex = 249
			Me.txtNumRodsPerBundle.Tag = ""
			Me.lblNumRodsPerBundle.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblNumRodsPerBundle.ImageAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim lblNumRodsPerBundle As Global.System.Windows.Forms.Control = Me.lblNumRodsPerBundle
			location = New Global.System.Drawing.Point(282, 149)
			lblNumRodsPerBundle.Location = location
			Me.lblNumRodsPerBundle.Name = "lblNumRodsPerBundle"
			Dim lblNumRodsPerBundle2 As Global.System.Windows.Forms.Control = Me.lblNumRodsPerBundle
			size = New Global.System.Drawing.Size(307, 20)
			lblNumRodsPerBundle2.Size = size
			Me.lblNumRodsPerBundle.TabIndex = 248
			Me.lblNumRodsPerBundle.Tag = ""
			Me.lblNumRodsPerBundle.Text = "Number of Rods per Segment with same number of guides :"
			Me.lblNumRodsPerBundle.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim txtRodGuideOverlap As Global.System.Windows.Forms.Control = Me.txtRodGuideOverlap
			location = New Global.System.Drawing.Point(550, 127)
			txtRodGuideOverlap.Location = location
			Me.txtRodGuideOverlap.Name = "txtRodGuideOverlap"
			Dim txtRodGuideOverlap2 As Global.System.Windows.Forms.Control = Me.txtRodGuideOverlap
			size = New Global.System.Drawing.Size(58, 20)
			txtRodGuideOverlap2.Size = size
			Me.txtRodGuideOverlap.TabIndex = 247
			Me.txtRodGuideOverlap.Tag = "fem"
			Me.txtRodGuideOverlap.Visible = False
			Me.lblRodGuideOverlap.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblRodGuideOverlap.ImageAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim lblRodGuideOverlap As Global.System.Windows.Forms.Control = Me.lblRodGuideOverlap
			location = New Global.System.Drawing.Point(388, 127)
			lblRodGuideOverlap.Location = location
			Me.lblRodGuideOverlap.Name = "lblRodGuideOverlap"
			Dim lblRodGuideOverlap2 As Global.System.Windows.Forms.Control = Me.lblRodGuideOverlap
			size = New Global.System.Drawing.Size(164, 21)
			lblRodGuideOverlap2.Size = size
			Me.lblRodGuideOverlap.TabIndex = 246
			Me.lblRodGuideOverlap.Tag = "Rod Guide Overlap (^): "
			Me.lblRodGuideOverlap.Text = "Rod Guide Overlap (ft): "
			Me.lblRodGuideOverlap.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblRodGuideOverlap.Visible = False
			Me.lblIterations.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblIterations.ImageAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim lblIterations As Global.System.Windows.Forms.Control = Me.lblIterations
			location = New Global.System.Drawing.Point(388, 172)
			lblIterations.Location = location
			Me.lblIterations.Name = "lblIterations"
			Dim lblIterations2 As Global.System.Windows.Forms.Control = Me.lblIterations
			size = New Global.System.Drawing.Size(168, 21)
			lblIterations2.Size = size
			Me.lblIterations.TabIndex = 244
			Me.lblIterations.Text = "Rod Guide Implementation Iterations: "
			Me.lblIterations.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblIterations.Visible = False
			Me.lblMaxSideLoadLimit.Font = New Global.System.Drawing.Font("Arial", 8F)
			Dim lblMaxSideLoadLimit As Global.System.Windows.Forms.Control = Me.lblMaxSideLoadLimit
			location = New Global.System.Drawing.Point(5, 124)
			lblMaxSideLoadLimit.Location = location
			Me.lblMaxSideLoadLimit.Name = "lblMaxSideLoadLimit"
			Dim lblMaxSideLoadLimit2 As Global.System.Windows.Forms.Control = Me.lblMaxSideLoadLimit
			size = New Global.System.Drawing.Size(289, 21)
			lblMaxSideLoadLimit2.Size = size
			Me.lblMaxSideLoadLimit.TabIndex = 241
			Me.lblMaxSideLoadLimit.Tag = "Do not recommend rod guides if side loads less than  (^):"
			Me.lblMaxSideLoadLimit.Text = "Do not recommend rod guides if side loads less than (lbs):"
			Me.cmdResetFrictions.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim cmdResetFrictions As Global.System.Windows.Forms.Control = Me.cmdResetFrictions
			location = New Global.System.Drawing.Point(484, 7)
			cmdResetFrictions.Location = location
			Me.cmdResetFrictions.Name = "cmdResetFrictions"
			Dim cmdResetFrictions2 As Global.System.Windows.Forms.Control = Me.cmdResetFrictions
			size = New Global.System.Drawing.Size(63, 20)
			cmdResetFrictions2.Size = size
			Me.cmdResetFrictions.TabIndex = 240
			Me.cmdResetFrictions.Text = "Reset"
			Me.cmdResetFrictions.UseVisualStyleBackColor = True
			Me.lblSideLoadperRodGuide.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblSideLoadperRodGuide As Global.System.Windows.Forms.Control = Me.lblSideLoadperRodGuide
			location = New Global.System.Drawing.Point(212, 8)
			lblSideLoadperRodGuide.Location = location
			Me.lblSideLoadperRodGuide.Name = "lblSideLoadperRodGuide"
			Me.HelpProvider1.SetShowHelp(Me.lblSideLoadperRodGuide, False)
			Dim lblSideLoadperRodGuide2 As Global.System.Windows.Forms.Control = Me.lblSideLoadperRodGuide
			size = New Global.System.Drawing.Size(132, 15)
			lblSideLoadperRodGuide2.Size = size
			Me.lblSideLoadperRodGuide.TabIndex = 239
			Me.lblSideLoadperRodGuide.Tag = "Side load per guide (^)"
			Me.lblSideLoadperRodGuide.Text = "Side load per guide (lbs)"
			Me.lblSideLoadperRodGuide.Visible = False
			Me.HelpProvider1.SetHelpKeyword(Me.cboSidewinder, "Rod Guides")
			Me.HelpProvider1.SetHelpNavigator(Me.cboSidewinder, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim cboSidewinder As Global.System.Windows.Forms.Control = Me.cboSidewinder
			location = New Global.System.Drawing.Point(48, 74)
			cboSidewinder.Location = location
			Me.cboSidewinder.Name = "cboSidewinder"
			Me.HelpProvider1.SetShowHelp(Me.cboSidewinder, True)
			Dim cboSidewinder2 As Global.System.Windows.Forms.Control = Me.cboSidewinder
			size = New Global.System.Drawing.Size(136, 22)
			cboSidewinder2.Size = size
			Me.cboSidewinder.TabIndex = 236
			Me.txtMinNumGuides.AcceptsReturn = True
			Me.txtMinNumGuides.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMinNumGuides.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMinNumGuides.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtMinNumGuides.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMinNumGuides, "Minimum Number of Guides Per Rod")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMinNumGuides, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMinNumGuides As Global.System.Windows.Forms.Control = Me.txtMinNumGuides
			location = New Global.System.Drawing.Point(212, 146)
			txtMinNumGuides.Location = location
			Me.txtMinNumGuides.MaxLength = 0
			Me.txtMinNumGuides.Name = "txtMinNumGuides"
			Me.txtMinNumGuides.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMinNumGuides, True)
			Dim txtMinNumGuides2 As Global.System.Windows.Forms.Control = Me.txtMinNumGuides
			size = New Global.System.Drawing.Size(65, 20)
			txtMinNumGuides2.Size = size
			Me.txtMinNumGuides.TabIndex = 233
			Me.txtMinNumGuides.Tag = ""
			Me.lblMaxNumGuides.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblMaxNumGuides.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblMaxNumGuides.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblMaxNumGuides.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblMaxNumGuides.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblMaxNumGuides As Global.System.Windows.Forms.Control = Me.lblMaxNumGuides
			location = New Global.System.Drawing.Point(5, 169)
			lblMaxNumGuides.Location = location
			Me.lblMaxNumGuides.Name = "lblMaxNumGuides"
			Me.lblMaxNumGuides.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblMaxNumGuides, False)
			Dim lblMaxNumGuides2 As Global.System.Windows.Forms.Control = Me.lblMaxNumGuides
			size = New Global.System.Drawing.Size(201, 20)
			lblMaxNumGuides2.Size = size
			Me.lblMaxNumGuides.TabIndex = 234
			Me.lblMaxNumGuides.Tag = "Maximum number of guides per rod:"
			Me.lblMaxNumGuides.Text = "Maximum number of guides per rod:"
			Me.lblGuides.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblGuides.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblGuides.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblGuides.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lblGuides.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblGuides As Global.System.Windows.Forms.Control = Me.lblGuides
			location = New Global.System.Drawing.Point(132, 103)
			lblGuides.Location = location
			Me.lblGuides.Name = "lblGuides"
			Me.lblGuides.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblGuides, False)
			Dim lblGuides2 As Global.System.Windows.Forms.Control = Me.lblGuides
			size = New Global.System.Drawing.Size(75, 14)
			lblGuides2.Size = size
			Me.lblGuides.TabIndex = 232
			Me.lblGuides.Tag = "Guides"
			Me.lblGuides.Text = "Guides"
			Me.txtOther.AcceptsReturn = True
			Me.txtOther.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtOther.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtOther.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtOther.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtOther, "Rod Guides")
			Me.HelpProvider1.SetHelpNavigator(Me.txtOther, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtOther As Global.System.Windows.Forms.Control = Me.txtOther
			location = New Global.System.Drawing.Point(48, 99)
			txtOther.Location = location
			Me.txtOther.MaxLength = 0
			Me.txtOther.Name = "txtOther"
			Me.txtOther.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtOther, True)
			Dim txtOther2 As Global.System.Windows.Forms.Control = Me.txtOther
			size = New Global.System.Drawing.Size(80, 20)
			txtOther2.Size = size
			Me.txtOther.TabIndex = 231
			Me.txtOther.Tag = ""
			Me.txtOther.Text = "Other"
			Me.txtNorrisFricCoeff.AcceptsReturn = True
			Me.txtNorrisFricCoeff.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtNorrisFricCoeff.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtNorrisFricCoeff.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtNorrisFricCoeff.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtNorrisFricCoeff, "Drag Friction Coefficient")
			Me.HelpProvider1.SetHelpNavigator(Me.txtNorrisFricCoeff, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtNorrisFricCoeff As Global.System.Windows.Forms.Control = Me.txtNorrisFricCoeff
			location = New Global.System.Drawing.Point(350, 75)
			txtNorrisFricCoeff.Location = location
			Me.txtNorrisFricCoeff.MaxLength = 40
			Me.txtNorrisFricCoeff.Name = "txtNorrisFricCoeff"
			Me.txtNorrisFricCoeff.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtNorrisFricCoeff, True)
			Dim txtNorrisFricCoeff2 As Global.System.Windows.Forms.Control = Me.txtNorrisFricCoeff
			size = New Global.System.Drawing.Size(65, 20)
			txtNorrisFricCoeff2.Size = size
			Me.txtNorrisFricCoeff.TabIndex = 230
			Me.txtNorrisFricCoeff.Tag = ""
			Me.txtNorrisFricCoeff.Text = "0.2"
			Me.txtNorrisFricCoeff.Visible = False
			Me.HelpProvider1.SetHelpKeyword(Me.optSideWinder, "Rod Guides")
			Me.HelpProvider1.SetHelpNavigator(Me.optSideWinder, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optSideWinder.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optSideWinder As Global.System.Windows.Forms.Control = Me.optSideWinder
			location = New Global.System.Drawing.Point(8, 75)
			optSideWinder.Location = location
			Me.optSideWinder.Name = "optSideWinder"
			Me.HelpProvider1.SetShowHelp(Me.optSideWinder, True)
			Dim optSideWinder2 As Global.System.Windows.Forms.Control = Me.optSideWinder
			size = New Global.System.Drawing.Size(136, 16)
			optSideWinder2.Size = size
			Me.optSideWinder.TabIndex = 228
			Me.optSideWinder.Text = "Use "
			Me.chkUseFluidInertiaPumpLoadAdj.Enabled = False
			Me.chkUseFluidInertiaPumpLoadAdj.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkUseFluidInertiaPumpLoadAdj As Global.System.Windows.Forms.Control = Me.chkUseFluidInertiaPumpLoadAdj
			location = New Global.System.Drawing.Point(8, 286)
			chkUseFluidInertiaPumpLoadAdj.Location = location
			Me.chkUseFluidInertiaPumpLoadAdj.Name = "chkUseFluidInertiaPumpLoadAdj"
			Me.HelpProvider1.SetShowHelp(Me.chkUseFluidInertiaPumpLoadAdj, False)
			Dim chkUseFluidInertiaPumpLoadAdj2 As Global.System.Windows.Forms.Control = Me.chkUseFluidInertiaPumpLoadAdj
			size = New Global.System.Drawing.Size(264, 16)
			chkUseFluidInertiaPumpLoadAdj2.Size = size
			Me.chkUseFluidInertiaPumpLoadAdj.TabIndex = 226
			Me.chkUseFluidInertiaPumpLoadAdj.Text = "Use Fluid Inertia Pump Load Adjustment"
			Me.chkUseFluidInertiaPumpLoadAdj.Visible = False
			Me.txtWeightAdjustFactor.Enabled = False
			Dim txtWeightAdjustFactor As Global.System.Windows.Forms.Control = Me.txtWeightAdjustFactor
			location = New Global.System.Drawing.Point(229, 272)
			txtWeightAdjustFactor.Location = location
			Me.txtWeightAdjustFactor.Name = "txtWeightAdjustFactor"
			Dim txtWeightAdjustFactor2 As Global.System.Windows.Forms.Control = Me.txtWeightAdjustFactor
			size = New Global.System.Drawing.Size(65, 20)
			txtWeightAdjustFactor2.Size = size
			Me.txtWeightAdjustFactor.TabIndex = 225
			Me.txtWeightAdjustFactor.Visible = False
			Me.lblWeightAdjustFactor.Enabled = False
			Dim lblWeightAdjustFactor As Global.System.Windows.Forms.Control = Me.lblWeightAdjustFactor
			location = New Global.System.Drawing.Point(16, 272)
			lblWeightAdjustFactor.Location = location
			Me.lblWeightAdjustFactor.Name = "lblWeightAdjustFactor"
			Dim lblWeightAdjustFactor2 As Global.System.Windows.Forms.Control = Me.lblWeightAdjustFactor
			size = New Global.System.Drawing.Size(240, 16)
			lblWeightAdjustFactor2.Size = size
			Me.lblWeightAdjustFactor.TabIndex = 224
			Me.lblWeightAdjustFactor.Text = "Weight Adjustment Factor"
			Me.lblWeightAdjustFactor.Visible = False
			Me.txtOtherFricCoeff.AcceptsReturn = True
			Me.txtOtherFricCoeff.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtOtherFricCoeff.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtOtherFricCoeff.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtOtherFricCoeff.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtOtherFricCoeff, "Drag Friction Coefficient")
			Me.HelpProvider1.SetHelpNavigator(Me.txtOtherFricCoeff, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtOtherFricCoeff As Global.System.Windows.Forms.Control = Me.txtOtherFricCoeff
			location = New Global.System.Drawing.Point(350, 99)
			txtOtherFricCoeff.Location = location
			Me.txtOtherFricCoeff.MaxLength = 0
			Me.txtOtherFricCoeff.Name = "txtOtherFricCoeff"
			Me.txtOtherFricCoeff.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtOtherFricCoeff, True)
			Dim txtOtherFricCoeff2 As Global.System.Windows.Forms.Control = Me.txtOtherFricCoeff
			size = New Global.System.Drawing.Size(65, 20)
			txtOtherFricCoeff2.Size = size
			Me.txtOtherFricCoeff.TabIndex = 216
			Me.txtOtherFricCoeff.Tag = ""
			Me.txtOtherFricCoeff.Text = "0.2"
			Me.txtOtherFricCoeff.Visible = False
			Me.txtWheelFricCoeff.AcceptsReturn = True
			Me.txtWheelFricCoeff.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtWheelFricCoeff.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtWheelFricCoeff.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtWheelFricCoeff.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtWheelFricCoeff, "Drag Friction Coefficient")
			Me.HelpProvider1.SetHelpNavigator(Me.txtWheelFricCoeff, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtWheelFricCoeff As Global.System.Windows.Forms.Control = Me.txtWheelFricCoeff
			location = New Global.System.Drawing.Point(350, 51)
			txtWheelFricCoeff.Location = location
			Me.txtWheelFricCoeff.MaxLength = 40
			Me.txtWheelFricCoeff.Name = "txtWheelFricCoeff"
			Me.txtWheelFricCoeff.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtWheelFricCoeff, True)
			Dim txtWheelFricCoeff2 As Global.System.Windows.Forms.Control = Me.txtWheelFricCoeff
			size = New Global.System.Drawing.Size(65, 20)
			txtWheelFricCoeff2.Size = size
			Me.txtWheelFricCoeff.TabIndex = 215
			Me.txtWheelFricCoeff.Tag = ""
			Me.txtWheelFricCoeff.Text = "0.2"
			Me.txtWheelFricCoeff.Visible = False
			Me.txtMoldedFricCoeff.AcceptsReturn = True
			Me.txtMoldedFricCoeff.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMoldedFricCoeff.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMoldedFricCoeff.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtMoldedFricCoeff.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMoldedFricCoeff, "Drag Friction Coefficient")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMoldedFricCoeff, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMoldedFricCoeff As Global.System.Windows.Forms.Control = Me.txtMoldedFricCoeff
			location = New Global.System.Drawing.Point(350, 27)
			txtMoldedFricCoeff.Location = location
			Me.txtMoldedFricCoeff.MaxLength = 40
			Me.txtMoldedFricCoeff.Name = "txtMoldedFricCoeff"
			Me.txtMoldedFricCoeff.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMoldedFricCoeff, True)
			Dim txtMoldedFricCoeff2 As Global.System.Windows.Forms.Control = Me.txtMoldedFricCoeff
			size = New Global.System.Drawing.Size(65, 20)
			txtMoldedFricCoeff2.Size = size
			Me.txtMoldedFricCoeff.TabIndex = 214
			Me.txtMoldedFricCoeff.Tag = ""
			Me.txtMoldedFricCoeff.Text = "0.2"
			Me.txtMoldedFricCoeff.Visible = False
			Me.lblNumCycles.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblNumCycles.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblNumCycles.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblNumCycles.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblNumCycles.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblNumCycles As Global.System.Windows.Forms.Control = Me.lblNumCycles
			location = New Global.System.Drawing.Point(492, 101)
			lblNumCycles.Location = location
			Me.lblNumCycles.Name = "lblNumCycles"
			Me.lblNumCycles.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblNumCycles, False)
			Dim lblNumCycles2 As Global.System.Windows.Forms.Control = Me.lblNumCycles
			size = New Global.System.Drawing.Size(72, 17)
			lblNumCycles2.Size = size
			Me.lblNumCycles.TabIndex = 185
			Me.lblNumCycles.Tag = ""
			Me.lblNumCycles.Text = "Num Cycles:"
			Me.txtNumCycles.AcceptsReturn = True
			Me.txtNumCycles.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtNumCycles.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtNumCycles.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtNumCycles.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtNumCycles As Global.System.Windows.Forms.Control = Me.txtNumCycles
			location = New Global.System.Drawing.Point(564, 101)
			txtNumCycles.Location = location
			Me.txtNumCycles.MaxLength = 0
			Me.txtNumCycles.Name = "txtNumCycles"
			Me.txtNumCycles.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtNumCycles, False)
			Dim txtNumCycles2 As Global.System.Windows.Forms.Control = Me.txtNumCycles
			size = New Global.System.Drawing.Size(65, 20)
			txtNumCycles2.Size = size
			Me.txtNumCycles.TabIndex = 13
			Me.txtNumCycles.Tag = ""
			Me.HelpProvider1.SetHelpKeyword(Me.optOther, "Rod Guides")
			Me.HelpProvider1.SetHelpNavigator(Me.optOther, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optOther.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optOther As Global.System.Windows.Forms.Control = Me.optOther
			location = New Global.System.Drawing.Point(8, 99)
			optOther.Location = location
			Me.optOther.Name = "optOther"
			Me.HelpProvider1.SetShowHelp(Me.optOther, True)
			Dim optOther2 As Global.System.Windows.Forms.Control = Me.optOther
			size = New Global.System.Drawing.Size(48, 16)
			optOther2.Size = size
			Me.optOther.TabIndex = 18
			Me.optOther.Text = "Use"
			Me.txtMaxNumGuides.AcceptsReturn = True
			Me.txtMaxNumGuides.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMaxNumGuides.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMaxNumGuides.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtMaxNumGuides.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMaxNumGuides, "Minimum Number of Guides Per Rod")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMaxNumGuides, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMaxNumGuides As Global.System.Windows.Forms.Control = Me.txtMaxNumGuides
			location = New Global.System.Drawing.Point(212, 169)
			txtMaxNumGuides.Location = location
			Me.txtMaxNumGuides.MaxLength = 0
			Me.txtMaxNumGuides.Name = "txtMaxNumGuides"
			Me.txtMaxNumGuides.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMaxNumGuides, True)
			Dim txtMaxNumGuides2 As Global.System.Windows.Forms.Control = Me.txtMaxNumGuides
			size = New Global.System.Drawing.Size(65, 20)
			txtMaxNumGuides2.Size = size
			Me.txtMaxNumGuides.TabIndex = 12
			Me.txtMaxNumGuides.Tag = ""
			Me.lblMinNumGuides.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblMinNumGuides.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblMinNumGuides.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblMinNumGuides.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblMinNumGuides.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblMinNumGuides As Global.System.Windows.Forms.Control = Me.lblMinNumGuides
			location = New Global.System.Drawing.Point(5, 146)
			lblMinNumGuides.Location = location
			Me.lblMinNumGuides.Name = "lblMinNumGuides"
			Me.lblMinNumGuides.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblMinNumGuides, False)
			Dim lblMinNumGuides2 As Global.System.Windows.Forms.Control = Me.lblMinNumGuides
			size = New Global.System.Drawing.Size(201, 15)
			lblMinNumGuides2.Size = size
			Me.lblMinNumGuides.TabIndex = 100
			Me.lblMinNumGuides.Tag = "Minimum number of guides per rod:"
			Me.lblMinNumGuides.Text = "Minimum number of guides per rod:"
			Me.HelpProvider1.SetHelpKeyword(Me.optMolded, "Rod Guides")
			Me.HelpProvider1.SetHelpNavigator(Me.optMolded, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optMolded.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optMolded As Global.System.Windows.Forms.Control = Me.optMolded
			location = New Global.System.Drawing.Point(8, 27)
			optMolded.Location = location
			Me.optMolded.Name = "optMolded"
			Me.HelpProvider1.SetShowHelp(Me.optMolded, True)
			Dim optMolded2 As Global.System.Windows.Forms.Control = Me.optMolded
			size = New Global.System.Drawing.Size(201, 16)
			optMolded2.Size = size
			Me.optMolded.TabIndex = 16
			Me.optMolded.Text = "Use Molded Guides"
			Me.HelpProvider1.SetHelpKeyword(Me.optWheel, "Rod Guides")
			Me.HelpProvider1.SetHelpNavigator(Me.optWheel, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optWheel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optWheel As Global.System.Windows.Forms.Control = Me.optWheel
			location = New Global.System.Drawing.Point(8, 51)
			optWheel.Location = location
			Me.optWheel.Name = "optWheel"
			Me.HelpProvider1.SetShowHelp(Me.optWheel, True)
			Dim optWheel2 As Global.System.Windows.Forms.Control = Me.optWheel
			size = New Global.System.Drawing.Size(201, 16)
			optWheel2.Size = size
			Me.optWheel.TabIndex = 17
			Me.optWheel.Text = "Use Wheel Guides"
			Me.txtMoldedLoad.AcceptsReturn = True
			Me.txtMoldedLoad.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMoldedLoad.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMoldedLoad.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtMoldedLoad.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMoldedLoad, "Rod Guide Rating")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMoldedLoad, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMoldedLoad As Global.System.Windows.Forms.Control = Me.txtMoldedLoad
			location = New Global.System.Drawing.Point(212, 27)
			txtMoldedLoad.Location = location
			Me.txtMoldedLoad.MaxLength = 40
			Me.txtMoldedLoad.Name = "txtMoldedLoad"
			Me.txtMoldedLoad.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMoldedLoad, True)
			Dim txtMoldedLoad2 As Global.System.Windows.Forms.Control = Me.txtMoldedLoad
			size = New Global.System.Drawing.Size(65, 20)
			txtMoldedLoad2.Size = size
			Me.txtMoldedLoad.TabIndex = 7
			Me.txtMoldedLoad.Tag = "lee"
			Me.txtMoldedLoad.Visible = False
			Me.txtOtherLoad.AcceptsReturn = True
			Me.txtOtherLoad.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtOtherLoad.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtOtherLoad.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtOtherLoad.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtOtherLoad, "Rod Guide Rating")
			Me.HelpProvider1.SetHelpNavigator(Me.txtOtherLoad, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtOtherLoad As Global.System.Windows.Forms.Control = Me.txtOtherLoad
			location = New Global.System.Drawing.Point(212, 99)
			txtOtherLoad.Location = location
			Me.txtOtherLoad.MaxLength = 0
			Me.txtOtherLoad.Name = "txtOtherLoad"
			Me.txtOtherLoad.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtOtherLoad, True)
			Dim txtOtherLoad2 As Global.System.Windows.Forms.Control = Me.txtOtherLoad
			size = New Global.System.Drawing.Size(65, 20)
			txtOtherLoad2.Size = size
			Me.txtOtherLoad.TabIndex = 10
			Me.txtOtherLoad.Tag = "lee"
			Me.txtOtherLoad.Visible = False
			Me.txtWheelLoad.AcceptsReturn = True
			Me.txtWheelLoad.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtWheelLoad.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtWheelLoad.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtWheelLoad.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtWheelLoad, "Rod Guide Rating")
			Me.HelpProvider1.SetHelpNavigator(Me.txtWheelLoad, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtWheelLoad As Global.System.Windows.Forms.Control = Me.txtWheelLoad
			location = New Global.System.Drawing.Point(212, 51)
			txtWheelLoad.Location = location
			Me.txtWheelLoad.MaxLength = 40
			Me.txtWheelLoad.Name = "txtWheelLoad"
			Me.txtWheelLoad.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtWheelLoad, True)
			Dim txtWheelLoad2 As Global.System.Windows.Forms.Control = Me.txtWheelLoad
			size = New Global.System.Drawing.Size(65, 20)
			txtWheelLoad2.Size = size
			Me.txtWheelLoad.TabIndex = 8
			Me.txtWheelLoad.Tag = "lee"
			Me.txtWheelLoad.Visible = False
			Me.txtSidewinderLoad.AcceptsReturn = True
			Me.txtSidewinderLoad.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtSidewinderLoad.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtSidewinderLoad.Enabled = False
			Me.txtSidewinderLoad.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtSidewinderLoad.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtSidewinderLoad, "Rod Guide Rating")
			Me.HelpProvider1.SetHelpNavigator(Me.txtSidewinderLoad, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtSidewinderLoad As Global.System.Windows.Forms.Control = Me.txtSidewinderLoad
			location = New Global.System.Drawing.Point(212, 75)
			txtSidewinderLoad.Location = location
			Me.txtSidewinderLoad.MaxLength = 40
			Me.txtSidewinderLoad.Name = "txtSidewinderLoad"
			Me.txtSidewinderLoad.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtSidewinderLoad, True)
			Dim txtSidewinderLoad2 As Global.System.Windows.Forms.Control = Me.txtSidewinderLoad
			size = New Global.System.Drawing.Size(65, 20)
			txtSidewinderLoad2.Size = size
			Me.txtSidewinderLoad.TabIndex = 227
			Me.txtSidewinderLoad.Tag = "lee"
			Me.txtSidewinderLoad.Visible = False
			Me.lblFricCoeff.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblFricCoeff As Global.System.Windows.Forms.Control = Me.lblFricCoeff
			location = New Global.System.Drawing.Point(348, 8)
			lblFricCoeff.Location = location
			Me.lblFricCoeff.Name = "lblFricCoeff"
			Me.HelpProvider1.SetShowHelp(Me.lblFricCoeff, False)
			Dim lblFricCoeff2 As Global.System.Windows.Forms.Control = Me.lblFricCoeff
			size = New Global.System.Drawing.Size(128, 16)
			lblFricCoeff2.Size = size
			Me.lblFricCoeff.TabIndex = 223
			Me.lblFricCoeff.Text = "Drag friction coefficient"
			Dim txtNumImplIters As Global.System.Windows.Forms.Control = Me.txtNumImplIters
			location = New Global.System.Drawing.Point(515, 172)
			txtNumImplIters.Location = location
			Me.txtNumImplIters.Name = "txtNumImplIters"
			Dim txtNumImplIters2 As Global.System.Windows.Forms.Control = Me.txtNumImplIters
			size = New Global.System.Drawing.Size(58, 20)
			txtNumImplIters2.Size = size
			Me.txtNumImplIters.TabIndex = 245
			Me.txtNumImplIters.Visible = False
			Me.HelpProvider1.SetHelpKeyword(Me.rbtBareRod, "Rod Guides")
			Me.HelpProvider1.SetHelpNavigator(Me.rbtBareRod, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.rbtBareRod.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtBareRod As Global.System.Windows.Forms.Control = Me.rbtBareRod
			location = New Global.System.Drawing.Point(8, 23)
			rbtBareRod.Location = location
			Me.rbtBareRod.Name = "rbtBareRod"
			Me.HelpProvider1.SetShowHelp(Me.rbtBareRod, True)
			Dim rbtBareRod2 As Global.System.Windows.Forms.Control = Me.rbtBareRod
			size = New Global.System.Drawing.Size(201, 21)
			rbtBareRod2.Size = size
			Me.rbtBareRod.TabIndex = 238
			Me.rbtBareRod.Text = "Use Bare Rod (no rod guides)"
			Me.rbtBareRod.Visible = False
			Me.txtBareRodFricCoeff.AcceptsReturn = True
			Me.txtBareRodFricCoeff.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtBareRodFricCoeff.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtBareRodFricCoeff.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtBareRodFricCoeff.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtBareRodFricCoeff As Global.System.Windows.Forms.Control = Me.txtBareRodFricCoeff
			location = New Global.System.Drawing.Point(212, 24)
			txtBareRodFricCoeff.Location = location
			Me.txtBareRodFricCoeff.MaxLength = 40
			Me.txtBareRodFricCoeff.Name = "txtBareRodFricCoeff"
			Me.txtBareRodFricCoeff.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtBareRodFricCoeff, False)
			Dim txtBareRodFricCoeff2 As Global.System.Windows.Forms.Control = Me.txtBareRodFricCoeff
			size = New Global.System.Drawing.Size(65, 20)
			txtBareRodFricCoeff2.Size = size
			Me.txtBareRodFricCoeff.TabIndex = 237
			Me.txtBareRodFricCoeff.Tag = ""
			Me.txtBareRodFricCoeff.Text = "0.2"
			Me.txtBareRodFricCoeff.Visible = False
			Me.HelpProvider1.SetHelpKeyword(Me.txtMaxSideLoadLimit, "Recommend rod guides if side load greater than")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMaxSideLoadLimit, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMaxSideLoadLimit As Global.System.Windows.Forms.Control = Me.txtMaxSideLoadLimit
			location = New Global.System.Drawing.Point(299, 123)
			txtMaxSideLoadLimit.Location = location
			Me.txtMaxSideLoadLimit.Name = "txtMaxSideLoadLimit"
			Me.HelpProvider1.SetShowHelp(Me.txtMaxSideLoadLimit, True)
			Dim txtMaxSideLoadLimit2 As Global.System.Windows.Forms.Control = Me.txtMaxSideLoadLimit
			size = New Global.System.Drawing.Size(65, 20)
			txtMaxSideLoadLimit2.Size = size
			Me.txtMaxSideLoadLimit.TabIndex = 242
			Me.txtMDInt.AcceptsReturn = True
			Me.txtMDInt.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMDInt.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMDInt.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtMDInt.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtMDInt As Global.System.Windows.Forms.Control = Me.txtMDInt
			location = New Global.System.Drawing.Point(467, 575)
			txtMDInt.Location = location
			Me.txtMDInt.MaxLength = 0
			Me.txtMDInt.Name = "txtMDInt"
			Me.txtMDInt.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMDInt, False)
			Dim txtMDInt2 As Global.System.Windows.Forms.Control = Me.txtMDInt
			size = New Global.System.Drawing.Size(47, 20)
			txtMDInt2.Size = size
			Me.txtMDInt.TabIndex = 237
			Me.txtMDInt.Tag = "fem"
			Me.txtMDInt.Visible = False
			Me.lblDoglegLimit.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblDoglegLimit.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblDoglegLimit.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblDoglegLimit.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblDoglegLimit.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblDoglegLimit As Global.System.Windows.Forms.Control = Me.lblDoglegLimit
			location = New Global.System.Drawing.Point(521, 575)
			lblDoglegLimit.Location = location
			Me.lblDoglegLimit.Name = "lblDoglegLimit"
			Me.lblDoglegLimit.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblDoglegLimit, False)
			Dim lblDoglegLimit2 As Global.System.Windows.Forms.Control = Me.lblDoglegLimit
			size = New Global.System.Drawing.Size(69, 21)
			lblDoglegLimit2.Size = size
			Me.lblDoglegLimit.TabIndex = 236
			Me.lblDoglegLimit.Tag = ""
			Me.lblDoglegLimit.Text = "Dogleg Diff: "
			Me.lblDoglegLimit.Visible = False
			Me.txtDoglegLimit.AcceptsReturn = True
			Me.txtDoglegLimit.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtDoglegLimit.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtDoglegLimit.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtDoglegLimit.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtDoglegLimit As Global.System.Windows.Forms.Control = Me.txtDoglegLimit
			location = New Global.System.Drawing.Point(593, 575)
			txtDoglegLimit.Location = location
			Me.txtDoglegLimit.MaxLength = 0
			Me.txtDoglegLimit.Name = "txtDoglegLimit"
			Me.txtDoglegLimit.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtDoglegLimit, False)
			Dim txtDoglegLimit2 As Global.System.Windows.Forms.Control = Me.txtDoglegLimit
			size = New Global.System.Drawing.Size(56, 20)
			txtDoglegLimit2.Size = size
			Me.txtDoglegLimit.TabIndex = 234
			Me.txtDoglegLimit.Tag = ""
			Me.txtDoglegLimit.Visible = False
			Me.lblMDInt.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lblMDInt.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblMDInt.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblMDInt.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblMDInt.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblMDInt As Global.System.Windows.Forms.Control = Me.lblMDInt
			location = New Global.System.Drawing.Point(380, 575)
			lblMDInt.Location = location
			Me.lblMDInt.Name = "lblMDInt"
			Me.lblMDInt.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblMDInt, False)
			Dim lblMDInt2 As Global.System.Windows.Forms.Control = Me.lblMDInt
			size = New Global.System.Drawing.Size(83, 20)
			lblMDInt2.Size = size
			Me.lblMDInt.TabIndex = 235
			Me.lblMDInt.Tag = "(^)"
			Me.lblMDInt.Text = "MD interval (ft):"
			Me.lblMDInt.Visible = False
			Dim chkUseJeffsFix As Global.System.Windows.Forms.Control = Me.chkUseJeffsFix
			location = New Global.System.Drawing.Point(973, 263)
			chkUseJeffsFix.Location = location
			Me.chkUseJeffsFix.Name = "chkUseJeffsFix"
			Dim chkUseJeffsFix2 As Global.System.Windows.Forms.Control = Me.chkUseJeffsFix
			size = New Global.System.Drawing.Size(87, 20)
			chkUseJeffsFix2.Size = size
			Me.chkUseJeffsFix.TabIndex = 116
			Me.chkUseJeffsFix.Text = "Use Jeffs Fix"
			Me.chkUseJeffsFix.Visible = False
			Dim chkUseJohnsFix As Global.System.Windows.Forms.Control = Me.chkUseJohnsFix
			location = New Global.System.Drawing.Point(869, 263)
			chkUseJohnsFix.Location = location
			Me.chkUseJohnsFix.Name = "chkUseJohnsFix"
			Dim chkUseJohnsFix2 As Global.System.Windows.Forms.Control = Me.chkUseJohnsFix
			size = New Global.System.Drawing.Size(96, 16)
			chkUseJohnsFix2.Size = size
			Me.chkUseJohnsFix.TabIndex = 115
			Me.chkUseJohnsFix.Text = "Use Johns Fix"
			Me.chkUseJohnsFix.Visible = False
			Dim chkUseBucklingTendencyStresses As Global.System.Windows.Forms.Control = Me.chkUseBucklingTendencyStresses
			location = New Global.System.Drawing.Point(682, 263)
			chkUseBucklingTendencyStresses.Location = location
			Me.chkUseBucklingTendencyStresses.Name = "chkUseBucklingTendencyStresses"
			Dim chkUseBucklingTendencyStresses2 As Global.System.Windows.Forms.Control = Me.chkUseBucklingTendencyStresses
			size = New Global.System.Drawing.Size(192, 20)
			chkUseBucklingTendencyStresses2.Size = size
			Me.chkUseBucklingTendencyStresses.TabIndex = 114
			Me.chkUseBucklingTendencyStresses.Text = "Use Buckling Tendency Stresses"
			Me.chkUseBucklingTendencyStresses.Visible = False
			Me.HelpProvider1.SetHelpKeyword(Me.chkUseAllDiameters, "Use all diameters when designing Rod String")
			Me.HelpProvider1.SetHelpNavigator(Me.chkUseAllDiameters, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim chkUseAllDiameters As Global.System.Windows.Forms.Control = Me.chkUseAllDiameters
			location = New Global.System.Drawing.Point(10, 254)
			chkUseAllDiameters.Location = location
			Me.chkUseAllDiameters.Name = "chkUseAllDiameters"
			Me.HelpProvider1.SetShowHelp(Me.chkUseAllDiameters, True)
			Dim chkUseAllDiameters2 As Global.System.Windows.Forms.Control = Me.chkUseAllDiameters
			size = New Global.System.Drawing.Size(254, 20)
			chkUseAllDiameters2.Size = size
			Me.chkUseAllDiameters.TabIndex = 113
			Me.chkUseAllDiameters.Text = "Use all diameters when designing Rod String"
			Me.grpWarnings.Controls.Add(Me.chkTargetBFPDWarning)
			Me.grpWarnings.Controls.Add(Me.chkRunTimeWarning)
			Dim grpWarnings As Global.System.Windows.Forms.Control = Me.grpWarnings
			location = New Global.System.Drawing.Point(360, 177)
			grpWarnings.Location = location
			Me.grpWarnings.Name = "grpWarnings"
			Dim grpWarnings2 As Global.System.Windows.Forms.Control = Me.grpWarnings
			size = New Global.System.Drawing.Size(304, 72)
			grpWarnings2.Size = size
			Me.grpWarnings.TabIndex = 112
			Me.grpWarnings.TabStop = False
			Me.grpWarnings.Text = "Warnings"
			Me.chkTargetBFPDWarning.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkTargetBFPDWarning.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkTargetBFPDWarning.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.chkTargetBFPDWarning.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkTargetBFPDWarning.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkTargetBFPDWarning As Global.System.Windows.Forms.Control = Me.chkTargetBFPDWarning
			location = New Global.System.Drawing.Point(9, 42)
			chkTargetBFPDWarning.Location = location
			Me.chkTargetBFPDWarning.Name = "chkTargetBFPDWarning"
			Me.chkTargetBFPDWarning.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkTargetBFPDWarning, False)
			Dim chkTargetBFPDWarning2 As Global.System.Windows.Forms.Control = Me.chkTargetBFPDWarning
			size = New Global.System.Drawing.Size(248, 17)
			chkTargetBFPDWarning2.Size = size
			Me.chkTargetBFPDWarning.TabIndex = 113
			Me.chkTargetBFPDWarning.Text = "Display target production warning message"
			Me.chkTargetBFPDWarning.UseVisualStyleBackColor = False
			Me.chkRunTimeWarning.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkRunTimeWarning.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkRunTimeWarning.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.chkRunTimeWarning.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkRunTimeWarning.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkRunTimeWarning As Global.System.Windows.Forms.Control = Me.chkRunTimeWarning
			location = New Global.System.Drawing.Point(9, 19)
			chkRunTimeWarning.Location = location
			Me.chkRunTimeWarning.Name = "chkRunTimeWarning"
			Me.chkRunTimeWarning.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkRunTimeWarning, False)
			Dim chkRunTimeWarning2 As Global.System.Windows.Forms.Control = Me.chkRunTimeWarning
			size = New Global.System.Drawing.Size(248, 17)
			chkRunTimeWarning2.Size = size
			Me.chkRunTimeWarning.TabIndex = 112
			Me.chkRunTimeWarning.Text = "Display run time warning message"
			Me.chkRunTimeWarning.UseVisualStyleBackColor = False
			Me.chkOptimizeSurvey.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkOptimizeSurvey.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkOptimizeSurvey.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.chkOptimizeSurvey.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkOptimizeSurvey.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkOptimizeSurvey As Global.System.Windows.Forms.Control = Me.chkOptimizeSurvey
			location = New Global.System.Drawing.Point(16, 572)
			chkOptimizeSurvey.Location = location
			Me.chkOptimizeSurvey.Name = "chkOptimizeSurvey"
			Me.chkOptimizeSurvey.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkOptimizeSurvey, False)
			Dim chkOptimizeSurvey2 As Global.System.Windows.Forms.Control = Me.chkOptimizeSurvey
			size = New Global.System.Drawing.Size(363, 24)
			chkOptimizeSurvey2.Size = size
			Me.chkOptimizeSurvey.TabIndex = 108
			Me.chkOptimizeSurvey.Text = "Smooth Deviation Survey if abrupt changes effect results."
			Me.chkOptimizeSurvey.UseVisualStyleBackColor = False
			Me.chkOptimizeSurvey.Visible = False
			Dim btnDefault As Global.System.Windows.Forms.Control = Me.btnDefault
			location = New Global.System.Drawing.Point(568, 16)
			btnDefault.Location = location
			Me.btnDefault.Name = "btnDefault"
			Dim btnDefault2 As Global.System.Windows.Forms.Control = Me.btnDefault
			size = New Global.System.Drawing.Size(80, 24)
			btnDefault2.Size = size
			Me.btnDefault.TabIndex = 107
			Me.btnDefault.Text = "Browse"
			Me.btnDefault.Visible = False
			Me.grpRatio.Controls.Add(Me.chkCalcVBelt)
			Me.grpRatio.Controls.Add(Me.txtGearBoxRatio)
			Me.grpRatio.Controls.Add(Me.txtVBeltRatio)
			Me.grpRatio.Controls.Add(Me.lblVBeltRatio)
			Me.grpRatio.Controls.Add(Me.lblGearBoxRatio)
			Dim grpRatio As Global.System.Windows.Forms.Control = Me.grpRatio
			location = New Global.System.Drawing.Point(360, 622)
			grpRatio.Location = location
			Me.grpRatio.Name = "grpRatio"
			Me.HelpProvider1.SetShowHelp(Me.grpRatio, False)
			Dim grpRatio2 As Global.System.Windows.Forms.Control = Me.grpRatio
			size = New Global.System.Drawing.Size(296, 60)
			grpRatio2.Size = size
			Me.grpRatio.TabIndex = 106
			Me.grpRatio.TabStop = False
			Me.grpRatio.Text = "Ratios"
			Me.chkCalcVBelt.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkCalcVBelt As Global.System.Windows.Forms.Control = Me.chkCalcVBelt
			location = New Global.System.Drawing.Point(160, 35)
			chkCalcVBelt.Location = location
			Me.chkCalcVBelt.Name = "chkCalcVBelt"
			Me.HelpProvider1.SetShowHelp(Me.chkCalcVBelt, False)
			Dim chkCalcVBelt2 As Global.System.Windows.Forms.Control = Me.chkCalcVBelt
			size = New Global.System.Drawing.Size(120, 16)
			chkCalcVBelt2.Size = size
			Me.chkCalcVBelt.TabIndex = 41
			Me.chkCalcVBelt.Text = "Calc VBelt"
			Me.txtGearBoxRatio.AcceptsReturn = True
			Me.txtGearBoxRatio.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtGearBoxRatio.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtGearBoxRatio.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtGearBoxRatio.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtGearBoxRatio As Global.System.Windows.Forms.Control = Me.txtGearBoxRatio
			location = New Global.System.Drawing.Point(80, 10)
			txtGearBoxRatio.Location = location
			Me.txtGearBoxRatio.MaxLength = 40
			Me.txtGearBoxRatio.Name = "txtGearBoxRatio"
			Me.txtGearBoxRatio.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtGearBoxRatio, False)
			Dim txtGearBoxRatio2 As Global.System.Windows.Forms.Control = Me.txtGearBoxRatio
			size = New Global.System.Drawing.Size(65, 20)
			txtGearBoxRatio2.Size = size
			Me.txtGearBoxRatio.TabIndex = 38
			Me.txtVBeltRatio.AcceptsReturn = True
			Me.txtVBeltRatio.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtVBeltRatio.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtVBeltRatio.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtVBeltRatio.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtVBeltRatio As Global.System.Windows.Forms.Control = Me.txtVBeltRatio
			location = New Global.System.Drawing.Point(208, 10)
			txtVBeltRatio.Location = location
			Me.txtVBeltRatio.MaxLength = 40
			Me.txtVBeltRatio.Name = "txtVBeltRatio"
			Me.txtVBeltRatio.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtVBeltRatio, False)
			Dim txtVBeltRatio2 As Global.System.Windows.Forms.Control = Me.txtVBeltRatio
			size = New Global.System.Drawing.Size(65, 20)
			txtVBeltRatio2.Size = size
			Me.txtVBeltRatio.TabIndex = 39
			Me.lblVBeltRatio.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblVBeltRatio.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblVBeltRatio.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblVBeltRatio.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lblVBeltRatio.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblVBeltRatio As Global.System.Windows.Forms.Control = Me.lblVBeltRatio
			location = New Global.System.Drawing.Point(160, 13)
			lblVBeltRatio.Location = location
			Me.lblVBeltRatio.Name = "lblVBeltRatio"
			Me.lblVBeltRatio.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblVBeltRatio, False)
			Dim lblVBeltRatio2 As Global.System.Windows.Forms.Control = Me.lblVBeltRatio
			size = New Global.System.Drawing.Size(40, 13)
			lblVBeltRatio2.Size = size
			Me.lblVBeltRatio.TabIndex = 37
			Me.lblVBeltRatio.Tag = "Standard steel sucker rod length (^):"
			Me.lblVBeltRatio.Text = "VBelt:"
			Me.lblGearBoxRatio.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblGearBoxRatio.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblGearBoxRatio.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblGearBoxRatio.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lblGearBoxRatio.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblGearBoxRatio As Global.System.Windows.Forms.Control = Me.lblGearBoxRatio
			location = New Global.System.Drawing.Point(16, 13)
			lblGearBoxRatio.Location = location
			Me.lblGearBoxRatio.Name = "lblGearBoxRatio"
			Me.lblGearBoxRatio.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblGearBoxRatio, False)
			Dim lblGearBoxRatio2 As Global.System.Windows.Forms.Control = Me.lblGearBoxRatio
			size = New Global.System.Drawing.Size(80, 13)
			lblGearBoxRatio2.Size = size
			Me.lblGearBoxRatio.TabIndex = 36
			Me.lblGearBoxRatio.Text = "Gearbox:"
			Me.chkAllowSlideFric.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkAllowSlideFric.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkAllowSlideFric.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.chkAllowSlideFric.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkAllowSlideFric.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkAllowSlideFric As Global.System.Windows.Forms.Control = Me.chkAllowSlideFric
			location = New Global.System.Drawing.Point(288, 622)
			chkAllowSlideFric.Location = location
			Me.chkAllowSlideFric.Name = "chkAllowSlideFric"
			Me.chkAllowSlideFric.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkAllowSlideFric, False)
			Dim chkAllowSlideFric2 As Global.System.Windows.Forms.Control = Me.chkAllowSlideFric
			size = New Global.System.Drawing.Size(248, 17)
			chkAllowSlideFric2.Size = size
			Me.chkAllowSlideFric.TabIndex = 15
			Me.chkAllowSlideFric.Text = "Allow Sliding Friction Coeff at Taper Level"
			Me.chkAllowSlideFric.UseVisualStyleBackColor = False
			Me.chkAllowSlideFric.Visible = False
			Me._SSFrame_3.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSFrame_3.Controls.Add(Me.txtMaxSteelLoading)
			Me._SSFrame_3.Controls.Add(Me.txtMaxFGLoading)
			Me._SSFrame_3.Controls.Add(Me.lblMaxFGLoading)
			Me._SSFrame_3.Controls.Add(Me.lblMaxSteelLoading)
			Me._SSFrame_3.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me._SSFrame_3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim ssframe_3 As Global.System.Windows.Forms.Control = Me._SSFrame_3
			location = New Global.System.Drawing.Point(8, 178)
			ssframe_3.Location = location
			Me._SSFrame_3.Name = "_SSFrame_3"
			Me._SSFrame_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._SSFrame_3, False)
			Dim ssframe_4 As Global.System.Windows.Forms.Control = Me._SSFrame_3
			size = New Global.System.Drawing.Size(324, 72)
			ssframe_4.Size = size
			Me._SSFrame_3.TabIndex = 105
			Me._SSFrame_3.TabStop = False
			Me._SSFrame_3.Text = "Limits"
			Me.txtMaxSteelLoading.AcceptsReturn = True
			Me.txtMaxSteelLoading.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMaxSteelLoading.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMaxSteelLoading.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtMaxSteelLoading.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMaxSteelLoading, "Maximum Desirable Steel Rod Loading")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMaxSteelLoading, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMaxSteelLoading As Global.System.Windows.Forms.Control = Me.txtMaxSteelLoading
			location = New Global.System.Drawing.Point(250, 15)
			txtMaxSteelLoading.Location = location
			Me.txtMaxSteelLoading.MaxLength = 40
			Me.txtMaxSteelLoading.Name = "txtMaxSteelLoading"
			Me.txtMaxSteelLoading.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMaxSteelLoading, True)
			Dim txtMaxSteelLoading2 As Global.System.Windows.Forms.Control = Me.txtMaxSteelLoading
			size = New Global.System.Drawing.Size(65, 20)
			txtMaxSteelLoading2.Size = size
			Me.txtMaxSteelLoading.TabIndex = 4
			Me.txtMaxFGLoading.AcceptsReturn = True
			Me.txtMaxFGLoading.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMaxFGLoading.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMaxFGLoading.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.txtMaxFGLoading.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMaxFGLoading, "Maximum Desirable Fiberglass Rod Loading")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMaxFGLoading, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMaxFGLoading As Global.System.Windows.Forms.Control = Me.txtMaxFGLoading
			location = New Global.System.Drawing.Point(250, 38)
			txtMaxFGLoading.Location = location
			Me.txtMaxFGLoading.MaxLength = 40
			Me.txtMaxFGLoading.Name = "txtMaxFGLoading"
			Me.txtMaxFGLoading.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMaxFGLoading, True)
			Dim txtMaxFGLoading2 As Global.System.Windows.Forms.Control = Me.txtMaxFGLoading
			size = New Global.System.Drawing.Size(65, 20)
			txtMaxFGLoading2.Size = size
			Me.txtMaxFGLoading.TabIndex = 5
			Me.lblMaxFGLoading.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblMaxFGLoading.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblMaxFGLoading.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblMaxFGLoading.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lblMaxFGLoading.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblMaxFGLoading As Global.System.Windows.Forms.Control = Me.lblMaxFGLoading
			location = New Global.System.Drawing.Point(8, 42)
			lblMaxFGLoading.Location = location
			Me.lblMaxFGLoading.Name = "lblMaxFGLoading"
			Me.lblMaxFGLoading.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblMaxFGLoading, False)
			Dim lblMaxFGLoading2 As Global.System.Windows.Forms.Control = Me.lblMaxFGLoading
			size = New Global.System.Drawing.Size(295, 13)
			lblMaxFGLoading2.Size = size
			Me.lblMaxFGLoading.TabIndex = 35
			Me.lblMaxFGLoading.Tag = "Standard steel sucker rod length (^):"
			Me.lblMaxFGLoading.Text = "Maximum desirable fiberglass rod loading (%):"
			Me.lblMaxSteelLoading.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblMaxSteelLoading.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblMaxSteelLoading.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.lblMaxSteelLoading.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lblMaxSteelLoading.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblMaxSteelLoading As Global.System.Windows.Forms.Control = Me.lblMaxSteelLoading
			location = New Global.System.Drawing.Point(9, 19)
			lblMaxSteelLoading.Location = location
			Me.lblMaxSteelLoading.Name = "lblMaxSteelLoading"
			Me.lblMaxSteelLoading.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblMaxSteelLoading, False)
			Dim lblMaxSteelLoading2 As Global.System.Windows.Forms.Control = Me.lblMaxSteelLoading
			size = New Global.System.Drawing.Size(263, 13)
			lblMaxSteelLoading2.Size = size
			Me.lblMaxSteelLoading.TabIndex = 33
			Me.lblMaxSteelLoading.Text = "Maximum desirable steel rod loading (%):"
			Me.chkAzDirToolbar.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkAzDirToolbar.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkAzDirToolbar.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.chkAzDirToolbar.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkAzDirToolbar.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkAzDirToolbar As Global.System.Windows.Forms.Control = Me.chkAzDirToolbar
			location = New Global.System.Drawing.Point(8, 479)
			chkAzDirToolbar.Location = location
			Me.chkAzDirToolbar.Name = "chkAzDirToolbar"
			Me.chkAzDirToolbar.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkAzDirToolbar, False)
			Dim chkAzDirToolbar2 As Global.System.Windows.Forms.Control = Me.chkAzDirToolbar
			size = New Global.System.Drawing.Size(257, 21)
			chkAzDirToolbar2.Size = size
			Me.chkAzDirToolbar.TabIndex = 14
			Me.chkAzDirToolbar.Text = "Show Deviation Survey Direction Toolbar "
			Me.chkAzDirToolbar.UseVisualStyleBackColor = False
			Me.chkAzDirToolbar.Visible = False
			Me.lblDefaultType.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblDefaultType As Global.System.Windows.Forms.Control = Me.lblDefaultType
			location = New Global.System.Drawing.Point(464, 24)
			lblDefaultType.Location = location
			Me.lblDefaultType.Name = "lblDefaultType"
			Me.HelpProvider1.SetShowHelp(Me.lblDefaultType, False)
			Dim lblDefaultType2 As Global.System.Windows.Forms.Control = Me.lblDefaultType
			size = New Global.System.Drawing.Size(96, 16)
			lblDefaultType2.Size = size
			Me.lblDefaultType.TabIndex = 4
			Me.lblDefaultType.Tag = "^"
			Me.lstDefaultItems.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.HelpProvider1.SetHelpKeyword(Me.lstDefaultItems, "Setup Defaults: Item List")
			Me.HelpProvider1.SetHelpNavigator(Me.lstDefaultItems, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.lstDefaultItems.ItemHeight = 14
			Dim lstDefaultItems As Global.System.Windows.Forms.Control = Me.lstDefaultItems
			location = New Global.System.Drawing.Point(8, 24)
			lstDefaultItems.Location = location
			Me.lstDefaultItems.Name = "lstDefaultItems"
			Me.HelpProvider1.SetShowHelp(Me.lstDefaultItems, True)
			Dim lstDefaultItems2 As Global.System.Windows.Forms.Control = Me.lstDefaultItems
			size = New Global.System.Drawing.Size(224, 144)
			lstDefaultItems2.Size = size
			Me.lstDefaultItems.TabIndex = 1
			Me.lblDefault.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblDefault As Global.System.Windows.Forms.Control = Me.lblDefault
			location = New Global.System.Drawing.Point(248, 8)
			lblDefault.Location = location
			Me.lblDefault.Name = "lblDefault"
			Me.HelpProvider1.SetShowHelp(Me.lblDefault, False)
			Dim lblDefault2 As Global.System.Windows.Forms.Control = Me.lblDefault
			size = New Global.System.Drawing.Size(192, 16)
			lblDefault2.Size = size
			Me.lblDefault.TabIndex = 1
			Me.lblDefault.Text = "Default value:"
			Me.lblItem.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblItem As Global.System.Windows.Forms.Control = Me.lblItem
			location = New Global.System.Drawing.Point(8, 8)
			lblItem.Location = location
			Me.lblItem.Name = "lblItem"
			Me.HelpProvider1.SetShowHelp(Me.lblItem, False)
			Dim lblItem2 As Global.System.Windows.Forms.Control = Me.lblItem
			size = New Global.System.Drawing.Size(88, 16)
			lblItem2.Size = size
			Me.lblItem.TabIndex = 0
			Me.lblItem.Text = "Item:"
			Me.txtDefault.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.txtDefault, "Setup Defaults: Item Value")
			Me.HelpProvider1.SetHelpNavigator(Me.txtDefault, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtDefault As Global.System.Windows.Forms.Control = Me.txtDefault
			location = New Global.System.Drawing.Point(240, 24)
			txtDefault.Location = location
			Me.txtDefault.Name = "txtDefault"
			Me.HelpProvider1.SetShowHelp(Me.txtDefault, True)
			Dim txtDefault2 As Global.System.Windows.Forms.Control = Me.txtDefault
			size = New Global.System.Drawing.Size(200, 22)
			txtDefault2.Size = size
			Me.txtDefault.TabIndex = 2
			Me.cboDefault.AllowDrop = True
			Me.cboDefault.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.HelpProvider1.SetHelpKeyword(Me.cboDefault, "Setup Defaults: Item Value")
			Me.HelpProvider1.SetHelpNavigator(Me.cboDefault, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboDefault.ItemHeight = 14
			Dim cboDefault As Global.System.Windows.Forms.Control = Me.cboDefault
			location = New Global.System.Drawing.Point(240, 24)
			cboDefault.Location = location
			Me.cboDefault.Name = "cboDefault"
			Me.HelpProvider1.SetShowHelp(Me.cboDefault, True)
			Dim cboDefault2 As Global.System.Windows.Forms.Control = Me.cboDefault
			size = New Global.System.Drawing.Size(216, 22)
			cboDefault2.Size = size
			Me.cboDefault.TabIndex = 3
			Me.cboDefault.Visible = False
			Dim rtbDefault As Global.System.Windows.Forms.Control = Me.rtbDefault
			location = New Global.System.Drawing.Point(240, 24)
			rtbDefault.Location = location
			Me.rtbDefault.Name = "rtbDefault"
			Dim rtbDefault2 As Global.System.Windows.Forms.Control = Me.rtbDefault
			size = New Global.System.Drawing.Size(416, 144)
			rtbDefault2.Size = size
			Me.rtbDefault.TabIndex = 109
			Me.rtbDefault.Text = ""
			Me.rtbDefault.Visible = False
			Me.pnlBatchMode.Controls.Add(Me.chkCreatePDFs)
			Me.pnlBatchMode.Controls.Add(Me.btnVerify)
			Me.pnlBatchMode.Controls.Add(Me.chkExcelInstalled)
			Me.pnlBatchMode.Controls.Add(Me.optCRGMismatch_0)
			Me.pnlBatchMode.Controls.Add(Me.chkViewWK1)
			Me.pnlBatchMode.Controls.Add(Me.lblBatchMode)
			Me.pnlBatchMode.Controls.Add(Me.chkSkipProcessedFiles)
			Me.pnlBatchMode.Controls.Add(Me.chkCreateWK1)
			Me.pnlBatchMode.Controls.Add(Me.chkPrintResults)
			Me.pnlBatchMode.Controls.Add(Me.optCRGMismatch_1)
			Me.pnlBatchMode.Controls.Add(Me.grpAutomaticBatchMode)
			Me.pnlBatchMode.Controls.Add(Me.grpSpreadSheetSetup)
			Dim pnlBatchMode As Global.System.Windows.Forms.Control = Me.pnlBatchMode
			location = New Global.System.Drawing.Point(-1333, 15)
			pnlBatchMode.Location = location
			Me.pnlBatchMode.Name = "pnlBatchMode"
			Me.HelpProvider1.SetShowHelp(Me.pnlBatchMode, False)
			Dim pnlBatchMode2 As Global.System.Windows.Forms.Control = Me.pnlBatchMode
			size = New Global.System.Drawing.Size(549, 374)
			pnlBatchMode2.Size = size
			Me.pnlBatchMode.TabIndex = 4
			Me.HelpProvider1.SetHelpKeyword(Me.chkCreatePDFs, "Create Spreadsheet File")
			Me.HelpProvider1.SetHelpNavigator(Me.chkCreatePDFs, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkCreatePDFs.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkCreatePDFs As Global.System.Windows.Forms.Control = Me.chkCreatePDFs
			location = New Global.System.Drawing.Point(16, 72)
			chkCreatePDFs.Location = location
			Me.chkCreatePDFs.Name = "chkCreatePDFs"
			Me.HelpProvider1.SetShowHelp(Me.chkCreatePDFs, True)
			Dim chkCreatePDFs2 As Global.System.Windows.Forms.Control = Me.chkCreatePDFs
			size = New Global.System.Drawing.Size(208, 16)
			chkCreatePDFs2.Size = size
			Me.chkCreatePDFs.TabIndex = 11
			Me.chkCreatePDFs.Text = "Create PDF files"
			Dim btnVerify As Global.System.Windows.Forms.Control = Me.btnVerify
			location = New Global.System.Drawing.Point(119, 6)
			btnVerify.Location = location
			Me.btnVerify.Name = "btnVerify"
			Dim btnVerify2 As Global.System.Windows.Forms.Control = Me.btnVerify
			size = New Global.System.Drawing.Size(55, 20)
			btnVerify2.Size = size
			Me.btnVerify.TabIndex = 10
			Me.btnVerify.Text = "&Verify"
			Me.btnVerify.UseVisualStyleBackColor = True
			Me.HelpProvider1.SetHelpKeyword(Me.chkExcelInstalled, "Setup Batch: Print Results")
			Me.HelpProvider1.SetHelpNavigator(Me.chkExcelInstalled, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkExcelInstalled.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkExcelInstalled As Global.System.Windows.Forms.Control = Me.chkExcelInstalled
			location = New Global.System.Drawing.Point(16, 8)
			chkExcelInstalled.Location = location
			Me.chkExcelInstalled.Name = "chkExcelInstalled"
			Me.HelpProvider1.SetShowHelp(Me.chkExcelInstalled, True)
			Dim chkExcelInstalled2 As Global.System.Windows.Forms.Control = Me.chkExcelInstalled
			size = New Global.System.Drawing.Size(100, 16)
			chkExcelInstalled2.Size = size
			Me.chkExcelInstalled.TabIndex = 1
			Me.chkExcelInstalled.Text = "Excel Installed"
			Me.HelpProvider1.SetHelpKeyword(Me.optCRGMismatch_0, "Update File or Setup Information")
			Me.HelpProvider1.SetHelpNavigator(Me.optCRGMismatch_0, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optCRGMismatch_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCRGMismatch_ As Global.System.Windows.Forms.Control = Me.optCRGMismatch_0
			location = New Global.System.Drawing.Point(237, 26)
			optCRGMismatch_.Location = location
			Me.optCRGMismatch_0.Name = "optCRGMismatch_0"
			Me.HelpProvider1.SetShowHelp(Me.optCRGMismatch_0, True)
			Dim optCRGMismatch_2 As Global.System.Windows.Forms.Control = Me.optCRGMismatch_0
			size = New Global.System.Drawing.Size(296, 23)
			optCRGMismatch_2.Size = size
			Me.optCRGMismatch_0.TabIndex = 5
			Me.optCRGMismatch_0.Text = "Update file with Setup's information"
			Me.HelpProvider1.SetHelpKeyword(Me.chkViewWK1, "View Spreadsheet File")
			Me.HelpProvider1.SetHelpNavigator(Me.chkViewWK1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkViewWK1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkViewWK As Global.System.Windows.Forms.Control = Me.chkViewWK1
			location = New Global.System.Drawing.Point(16, 56)
			chkViewWK.Location = location
			Me.chkViewWK1.Name = "chkViewWK1"
			Me.HelpProvider1.SetShowHelp(Me.chkViewWK1, True)
			Dim chkViewWK2 As Global.System.Windows.Forms.Control = Me.chkViewWK1
			size = New Global.System.Drawing.Size(208, 16)
			chkViewWK2.Size = size
			Me.chkViewWK1.TabIndex = 3
			Me.chkViewWK1.Text = "View spreadsheet in Excel"
			Me.lblBatchMode.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblBatchMode As Global.System.Windows.Forms.Control = Me.lblBatchMode
			location = New Global.System.Drawing.Point(237, 9)
			lblBatchMode.Location = location
			Me.lblBatchMode.Name = "lblBatchMode"
			Me.HelpProvider1.SetShowHelp(Me.lblBatchMode, False)
			Dim lblBatchMode2 As Global.System.Windows.Forms.Control = Me.lblBatchMode
			size = New Global.System.Drawing.Size(309, 14)
			lblBatchMode2.Size = size
			Me.lblBatchMode.TabIndex = 7
			Me.lblBatchMode.Text = "If a file's custom rod grades don't match those in Setup:"
			Me.HelpProvider1.SetHelpKeyword(Me.chkSkipProcessedFiles, "Setup Batch: Skip Processed")
			Me.HelpProvider1.SetHelpNavigator(Me.chkSkipProcessedFiles, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkSkipProcessedFiles.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkSkipProcessedFiles As Global.System.Windows.Forms.Control = Me.chkSkipProcessedFiles
			location = New Global.System.Drawing.Point(16, 89)
			chkSkipProcessedFiles.Location = location
			Me.chkSkipProcessedFiles.Name = "chkSkipProcessedFiles"
			Me.HelpProvider1.SetShowHelp(Me.chkSkipProcessedFiles, True)
			Dim chkSkipProcessedFiles2 As Global.System.Windows.Forms.Control = Me.chkSkipProcessedFiles
			size = New Global.System.Drawing.Size(216, 18)
			chkSkipProcessedFiles2.Size = size
			Me.chkSkipProcessedFiles.TabIndex = 4
			Me.chkSkipProcessedFiles.Text = "Don't re-run cases with saved output"
			Me.HelpProvider1.SetHelpKeyword(Me.chkCreateWK1, "Create Spreadsheet File")
			Me.HelpProvider1.SetHelpNavigator(Me.chkCreateWK1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkCreateWK1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkCreateWK As Global.System.Windows.Forms.Control = Me.chkCreateWK1
			location = New Global.System.Drawing.Point(16, 40)
			chkCreateWK.Location = location
			Me.chkCreateWK1.Name = "chkCreateWK1"
			Me.HelpProvider1.SetShowHelp(Me.chkCreateWK1, True)
			Dim chkCreateWK2 As Global.System.Windows.Forms.Control = Me.chkCreateWK1
			size = New Global.System.Drawing.Size(208, 16)
			chkCreateWK2.Size = size
			Me.chkCreateWK1.TabIndex = 2
			Me.chkCreateWK1.Text = "Create spreadsheet file"
			Me.HelpProvider1.SetHelpKeyword(Me.chkPrintResults, "Setup Batch: Print Results")
			Me.HelpProvider1.SetHelpNavigator(Me.chkPrintResults, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkPrintResults.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkPrintResults As Global.System.Windows.Forms.Control = Me.chkPrintResults
			location = New Global.System.Drawing.Point(16, 24)
			chkPrintResults.Location = location
			Me.chkPrintResults.Name = "chkPrintResults"
			Me.HelpProvider1.SetShowHelp(Me.chkPrintResults, True)
			Dim chkPrintResults2 As Global.System.Windows.Forms.Control = Me.chkPrintResults
			size = New Global.System.Drawing.Size(100, 16)
			chkPrintResults2.Size = size
			Me.chkPrintResults.TabIndex = 1
			Me.chkPrintResults.Text = "Make printouts"
			Me.HelpProvider1.SetHelpKeyword(Me.optCRGMismatch_1, "Update File or Setup Information")
			Me.HelpProvider1.SetHelpNavigator(Me.optCRGMismatch_1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optCRGMismatch_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCRGMismatch_3 As Global.System.Windows.Forms.Control = Me.optCRGMismatch_1
			location = New Global.System.Drawing.Point(237, 48)
			optCRGMismatch_3.Location = location
			Me.optCRGMismatch_1.Name = "optCRGMismatch_1"
			Me.HelpProvider1.SetShowHelp(Me.optCRGMismatch_1, True)
			Dim optCRGMismatch_4 As Global.System.Windows.Forms.Control = Me.optCRGMismatch_1
			size = New Global.System.Drawing.Size(296, 23)
			optCRGMismatch_4.Size = size
			Me.optCRGMismatch_1.TabIndex = 6
			Me.optCRGMismatch_1.Text = "Update Setup with file's information"
			Me.grpAutomaticBatchMode.Controls.Add(Me.cboAMPM)
			Me.grpAutomaticBatchMode.Controls.Add(Me.nmUDMinute)
			Me.grpAutomaticBatchMode.Controls.Add(Me.nmUDHour)
			Me.grpAutomaticBatchMode.Controls.Add(Me.txtWK1Dir)
			Me.grpAutomaticBatchMode.Controls.Add(Me.txtRODSTARDir)
			Me.grpAutomaticBatchMode.Controls.Add(Me.cmdBrowse_2)
			Me.grpAutomaticBatchMode.Controls.Add(Me.cmdBrowse_0)
			Me.grpAutomaticBatchMode.Controls.Add(Me.lblSSDir)
			Me.grpAutomaticBatchMode.Controls.Add(Me.lblRODSTARDataDict)
			Me.grpAutomaticBatchMode.Controls.Add(Me.lblTimeToBeginRuns)
			Dim grpAutomaticBatchMode As Global.System.Windows.Forms.Control = Me.grpAutomaticBatchMode
			location = New Global.System.Drawing.Point(14, 248)
			grpAutomaticBatchMode.Location = location
			Me.grpAutomaticBatchMode.Name = "grpAutomaticBatchMode"
			Me.HelpProvider1.SetShowHelp(Me.grpAutomaticBatchMode, False)
			Dim grpAutomaticBatchMode2 As Global.System.Windows.Forms.Control = Me.grpAutomaticBatchMode
			size = New Global.System.Drawing.Size(520, 110)
			grpAutomaticBatchMode2.Size = size
			Me.grpAutomaticBatchMode.TabIndex = 1
			Me.grpAutomaticBatchMode.TabStop = False
			Me.grpAutomaticBatchMode.Text = "Automatic Batch Mode"
			Me.HelpProvider1.SetHelpKeyword(Me.cboAMPM, "Setup Batch: StartTime")
			Me.HelpProvider1.SetHelpNavigator(Me.cboAMPM, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboAMPM.ItemHeight = 13
			Dim cboAMPM As Global.System.Windows.Forms.Control = Me.cboAMPM
			location = New Global.System.Drawing.Point(264, 16)
			cboAMPM.Location = location
			Me.cboAMPM.Name = "cboAMPM"
			Me.HelpProvider1.SetShowHelp(Me.cboAMPM, True)
			Dim cboAMPM2 As Global.System.Windows.Forms.Control = Me.cboAMPM
			size = New Global.System.Drawing.Size(48, 21)
			cboAMPM2.Size = size
			Me.cboAMPM.TabIndex = 13
			Me.HelpProvider1.SetHelpKeyword(Me.nmUDMinute, "Setup Batch: StartTime")
			Me.HelpProvider1.SetHelpNavigator(Me.nmUDMinute, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim nmUDMinute As Global.System.Windows.Forms.Control = Me.nmUDMinute
			location = New Global.System.Drawing.Point(216, 16)
			nmUDMinute.Location = location
			Me.nmUDMinute.Name = "nmUDMinute"
			Me.HelpProvider1.SetShowHelp(Me.nmUDMinute, True)
			Dim nmUDMinute2 As Global.System.Windows.Forms.Control = Me.nmUDMinute
			size = New Global.System.Drawing.Size(40, 20)
			nmUDMinute2.Size = size
			Me.nmUDMinute.TabIndex = 12
			Me.HelpProvider1.SetHelpKeyword(Me.nmUDHour, "Setup Batch: StartTime")
			Me.HelpProvider1.SetHelpNavigator(Me.nmUDHour, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim nmUDHour As Global.System.Windows.Forms.Control = Me.nmUDHour
			location = New Global.System.Drawing.Point(176, 16)
			nmUDHour.Location = location
			Me.nmUDHour.Name = "nmUDHour"
			Me.HelpProvider1.SetShowHelp(Me.nmUDHour, True)
			Dim nmUDHour2 As Global.System.Windows.Forms.Control = Me.nmUDHour
			size = New Global.System.Drawing.Size(40, 20)
			nmUDHour2.Size = size
			Me.nmUDHour.TabIndex = 11
			Me.HelpProvider1.SetHelpKeyword(Me.txtWK1Dir, "Setup Batch: SpreadSheet folder")
			Me.HelpProvider1.SetHelpNavigator(Me.txtWK1Dir, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtWK1Dir As Global.System.Windows.Forms.Control = Me.txtWK1Dir
			location = New Global.System.Drawing.Point(176, 65)
			txtWK1Dir.Location = location
			Me.txtWK1Dir.Name = "txtWK1Dir"
			Me.HelpProvider1.SetShowHelp(Me.txtWK1Dir, True)
			Dim txtWK1Dir2 As Global.System.Windows.Forms.Control = Me.txtWK1Dir
			size = New Global.System.Drawing.Size(160, 20)
			txtWK1Dir2.Size = size
			Me.txtWK1Dir.TabIndex = 16
			Me.HelpProvider1.SetHelpKeyword(Me.txtRODSTARDir, "Setup Batch: RODSTAR Folder")
			Me.HelpProvider1.SetHelpNavigator(Me.txtRODSTARDir, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtRODSTARDir As Global.System.Windows.Forms.Control = Me.txtRODSTARDir
			location = New Global.System.Drawing.Point(176, 40)
			txtRODSTARDir.Location = location
			Me.txtRODSTARDir.Name = "txtRODSTARDir"
			Me.HelpProvider1.SetShowHelp(Me.txtRODSTARDir, True)
			Dim txtRODSTARDir2 As Global.System.Windows.Forms.Control = Me.txtRODSTARDir
			size = New Global.System.Drawing.Size(160, 20)
			txtRODSTARDir2.Size = size
			Me.txtRODSTARDir.TabIndex = 14
			Me.HelpProvider1.SetHelpKeyword(Me.cmdBrowse_2, "Setup Batch: Browse SpreadSheet Directory")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdBrowse_2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdBrowse_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdBrowse_ As Global.System.Windows.Forms.Control = Me.cmdBrowse_2
			location = New Global.System.Drawing.Point(344, 65)
			cmdBrowse_.Location = location
			Me.cmdBrowse_2.Name = "cmdBrowse_2"
			Me.HelpProvider1.SetShowHelp(Me.cmdBrowse_2, True)
			Dim cmdBrowse_2 As Global.System.Windows.Forms.Control = Me.cmdBrowse_2
			size = New Global.System.Drawing.Size(80, 22)
			cmdBrowse_2.Size = size
			Me.cmdBrowse_2.TabIndex = 17
			Me.cmdBrowse_2.Text = "Browse.."
			Me.HelpProvider1.SetHelpKeyword(Me.cmdBrowse_0, "Setup Batch: RODSTAR Folder")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdBrowse_0, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdBrowse_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdBrowse_3 As Global.System.Windows.Forms.Control = Me.cmdBrowse_0
			location = New Global.System.Drawing.Point(344, 40)
			cmdBrowse_3.Location = location
			Me.cmdBrowse_0.Name = "cmdBrowse_0"
			Me.HelpProvider1.SetShowHelp(Me.cmdBrowse_0, True)
			Dim cmdBrowse_4 As Global.System.Windows.Forms.Control = Me.cmdBrowse_0
			size = New Global.System.Drawing.Size(80, 22)
			cmdBrowse_4.Size = size
			Me.cmdBrowse_0.TabIndex = 15
			Me.cmdBrowse_0.Text = "Browse.."
			Me.lblSSDir.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblSSDir As Global.System.Windows.Forms.Control = Me.lblSSDir
			location = New Global.System.Drawing.Point(16, 65)
			lblSSDir.Location = location
			Me.lblSSDir.Name = "lblSSDir"
			Me.HelpProvider1.SetShowHelp(Me.lblSSDir, False)
			Dim lblSSDir2 As Global.System.Windows.Forms.Control = Me.lblSSDir
			size = New Global.System.Drawing.Size(136, 16)
			lblSSDir2.Size = size
			Me.lblSSDir.TabIndex = 3
			Me.lblSSDir.Text = "Spreadsheet folder:"
			Me.lblRODSTARDataDict.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblRODSTARDataDict As Global.System.Windows.Forms.Control = Me.lblRODSTARDataDict
			location = New Global.System.Drawing.Point(16, 40)
			lblRODSTARDataDict.Location = location
			Me.lblRODSTARDataDict.Name = "lblRODSTARDataDict"
			Me.HelpProvider1.SetShowHelp(Me.lblRODSTARDataDict, False)
			Dim lblRODSTARDataDict2 As Global.System.Windows.Forms.Control = Me.lblRODSTARDataDict
			size = New Global.System.Drawing.Size(160, 16)
			lblRODSTARDataDict2.Size = size
			Me.lblRODSTARDataDict.TabIndex = 1
			Me.lblRODSTARDataDict.Text = "RODSTAR Batch Files Folder:"
			Me.lblTimeToBeginRuns.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblTimeToBeginRuns As Global.System.Windows.Forms.Control = Me.lblTimeToBeginRuns
			location = New Global.System.Drawing.Point(16, 16)
			lblTimeToBeginRuns.Location = location
			Me.lblTimeToBeginRuns.Name = "lblTimeToBeginRuns"
			Me.HelpProvider1.SetShowHelp(Me.lblTimeToBeginRuns, False)
			Dim lblTimeToBeginRuns2 As Global.System.Windows.Forms.Control = Me.lblTimeToBeginRuns
			size = New Global.System.Drawing.Size(144, 16)
			lblTimeToBeginRuns2.Size = size
			Me.lblTimeToBeginRuns.TabIndex = 0
			Me.lblTimeToBeginRuns.Text = "Time to begin runs:"
			Me.grpSpreadSheetSetup.Controls.Add(Me.btnModifySS)
			Me.grpSpreadSheetSetup.Controls.Add(Me.btnNewSS)
			Me.grpSpreadSheetSetup.Controls.Add(Me.btnDeleteSS)
			Me.grpSpreadSheetSetup.Controls.Add(Me.lstSorted)
			Me.grpSpreadSheetSetup.Controls.Add(Me.lstWK1Formats)
			Me.grpSpreadSheetSetup.Controls.Add(Me.lblSelect)
			Dim grpSpreadSheetSetup As Global.System.Windows.Forms.Control = Me.grpSpreadSheetSetup
			location = New Global.System.Drawing.Point(14, 109)
			grpSpreadSheetSetup.Location = location
			Me.grpSpreadSheetSetup.Name = "grpSpreadSheetSetup"
			Me.HelpProvider1.SetShowHelp(Me.grpSpreadSheetSetup, False)
			Dim grpSpreadSheetSetup2 As Global.System.Windows.Forms.Control = Me.grpSpreadSheetSetup
			size = New Global.System.Drawing.Size(520, 136)
			grpSpreadSheetSetup2.Size = size
			Me.grpSpreadSheetSetup.TabIndex = 0
			Me.grpSpreadSheetSetup.TabStop = False
			Me.grpSpreadSheetSetup.Text = "Spreadsheet setup"
			Me.btnModifySS.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnModifySS.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnModifySS.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnModifySS.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.btnModifySS, "Setup Batch: Modify SpeadSheet")
			Me.HelpProvider1.SetHelpNavigator(Me.btnModifySS, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.btnModifySS.Image = CType(componentResourceManager.GetObject("btnModifySS.Image"), Global.System.Drawing.Image)
			Me.btnModifySS.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnModifySS As Global.System.Windows.Forms.Control = Me.btnModifySS
			location = New Global.System.Drawing.Point(375, 23)
			btnModifySS.Location = location
			Me.btnModifySS.Name = "btnModifySS"
			Me.btnModifySS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.btnModifySS, True)
			Dim btnModifySS2 As Global.System.Windows.Forms.Control = Me.btnModifySS
			size = New Global.System.Drawing.Size(24, 22)
			btnModifySS2.Size = size
			Me.btnModifySS.TabIndex = 9
			Me.btnModifySS.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.btnModifySS.UseVisualStyleBackColor = False
			Me.btnNewSS.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnNewSS.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnNewSS.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnNewSS.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.btnNewSS, "Setup Batch: Add SpeadSheet")
			Me.HelpProvider1.SetHelpNavigator(Me.btnNewSS, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.btnNewSS.Image = CType(componentResourceManager.GetObject("btnNewSS.Image"), Global.System.Drawing.Image)
			Me.btnNewSS.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnNewSS As Global.System.Windows.Forms.Control = Me.btnNewSS
			location = New Global.System.Drawing.Point(350, 23)
			btnNewSS.Location = location
			Me.btnNewSS.Name = "btnNewSS"
			Me.btnNewSS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.btnNewSS, True)
			Dim btnNewSS2 As Global.System.Windows.Forms.Control = Me.btnNewSS
			size = New Global.System.Drawing.Size(24, 22)
			btnNewSS2.Size = size
			Me.btnNewSS.TabIndex = 8
			Me.btnNewSS.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.btnNewSS.UseVisualStyleBackColor = False
			Me.btnDeleteSS.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnDeleteSS.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnDeleteSS.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.btnDeleteSS.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.btnDeleteSS, "Setup Batch: Delete SpreadSheet")
			Me.HelpProvider1.SetHelpNavigator(Me.btnDeleteSS, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.btnDeleteSS.Image = CType(componentResourceManager.GetObject("btnDeleteSS.Image"), Global.System.Drawing.Image)
			Me.btnDeleteSS.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnDeleteSS As Global.System.Windows.Forms.Control = Me.btnDeleteSS
			location = New Global.System.Drawing.Point(400, 23)
			btnDeleteSS.Location = location
			Me.btnDeleteSS.Name = "btnDeleteSS"
			Me.btnDeleteSS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.btnDeleteSS, True)
			Dim btnDeleteSS2 As Global.System.Windows.Forms.Control = Me.btnDeleteSS
			size = New Global.System.Drawing.Size(24, 22)
			btnDeleteSS2.Size = size
			Me.btnDeleteSS.TabIndex = 10
			Me.btnDeleteSS.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.btnDeleteSS.UseVisualStyleBackColor = False
			Dim lstSorted As Global.System.Windows.Forms.Control = Me.lstSorted
			location = New Global.System.Drawing.Point(176, 72)
			lstSorted.Location = location
			Me.lstSorted.Name = "lstSorted"
			Me.HelpProvider1.SetShowHelp(Me.lstSorted, False)
			Dim lstSorted2 As Global.System.Windows.Forms.Control = Me.lstSorted
			size = New Global.System.Drawing.Size(24, 4)
			lstSorted2.Size = size
			Me.lstSorted.TabIndex = 5
			Me.lstSorted.Visible = False
			Me.HelpProvider1.SetHelpKeyword(Me.lstWK1Formats, "Spreadsheet Format Types")
			Me.HelpProvider1.SetHelpNavigator(Me.lstWK1Formats, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim lstWK1Formats As Global.System.Windows.Forms.Control = Me.lstWK1Formats
			location = New Global.System.Drawing.Point(208, 19)
			lstWK1Formats.Location = location
			Me.lstWK1Formats.Name = "lstWK1Formats"
			Me.HelpProvider1.SetShowHelp(Me.lstWK1Formats, True)
			Dim lstWK1Formats2 As Global.System.Windows.Forms.Control = Me.lstWK1Formats
			size = New Global.System.Drawing.Size(128, 108)
			lstWK1Formats2.Size = size
			Me.lstWK1Formats.TabIndex = 7
			Me.lblSelect.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblSelect As Global.System.Windows.Forms.Control = Me.lblSelect
			location = New Global.System.Drawing.Point(8, 24)
			lblSelect.Location = location
			Me.lblSelect.Name = "lblSelect"
			Me.HelpProvider1.SetShowHelp(Me.lblSelect, False)
			Dim lblSelect2 As Global.System.Windows.Forms.Control = Me.lblSelect
			size = New Global.System.Drawing.Size(184, 40)
			lblSelect2.Size = size
			Me.lblSelect.TabIndex = 0
			Me.lblSelect.Text = "Select the speadsheet format to use in batch mode:"
			Me.pnlCustomizeRGList.Controls.Add(Me.cmdModifyCustomRG)
			Me.pnlCustomizeRGList.Controls.Add(Me.cmdNewCustomRG)
			Me.pnlCustomizeRGList.Controls.Add(Me.cmdDeleteCustomRG)
			Me.pnlCustomizeRGList.Controls.Add(Me.lvwCustomRG)
			Dim pnlCustomizeRGList As Global.System.Windows.Forms.Control = Me.pnlCustomizeRGList
			location = New Global.System.Drawing.Point(-1333, 16)
			pnlCustomizeRGList.Location = location
			Me.pnlCustomizeRGList.Name = "pnlCustomizeRGList"
			Me.HelpProvider1.SetShowHelp(Me.pnlCustomizeRGList, False)
			Dim pnlCustomizeRGList2 As Global.System.Windows.Forms.Control = Me.pnlCustomizeRGList
			size = New Global.System.Drawing.Size(707, 304)
			pnlCustomizeRGList2.Size = size
			Me.pnlCustomizeRGList.TabIndex = 5
			Me.cmdModifyCustomRG.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdModifyCustomRG.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdModifyCustomRG.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdModifyCustomRG.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdModifyCustomRG, "Setup Rod Grade : Modify")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdModifyCustomRG, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdModifyCustomRG.Image = CType(componentResourceManager.GetObject("cmdModifyCustomRG.Image"), Global.System.Drawing.Image)
			Me.cmdModifyCustomRG.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdModifyCustomRG As Global.System.Windows.Forms.Control = Me.cmdModifyCustomRG
			location = New Global.System.Drawing.Point(40, 272)
			cmdModifyCustomRG.Location = location
			Me.cmdModifyCustomRG.Name = "cmdModifyCustomRG"
			Me.cmdModifyCustomRG.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdModifyCustomRG, True)
			Dim cmdModifyCustomRG2 As Global.System.Windows.Forms.Control = Me.cmdModifyCustomRG
			size = New Global.System.Drawing.Size(24, 22)
			cmdModifyCustomRG2.Size = size
			Me.cmdModifyCustomRG.TabIndex = 92
			Me.cmdModifyCustomRG.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.cmdModifyCustomRG.UseVisualStyleBackColor = False
			Me.cmdNewCustomRG.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdNewCustomRG.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdNewCustomRG.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdNewCustomRG.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdNewCustomRG, "Setup Rod Grade : Add")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdNewCustomRG, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdNewCustomRG.Image = CType(componentResourceManager.GetObject("cmdNewCustomRG.Image"), Global.System.Drawing.Image)
			Me.cmdNewCustomRG.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdNewCustomRG As Global.System.Windows.Forms.Control = Me.cmdNewCustomRG
			location = New Global.System.Drawing.Point(8, 272)
			cmdNewCustomRG.Location = location
			Me.cmdNewCustomRG.Name = "cmdNewCustomRG"
			Me.cmdNewCustomRG.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdNewCustomRG, True)
			Dim cmdNewCustomRG2 As Global.System.Windows.Forms.Control = Me.cmdNewCustomRG
			size = New Global.System.Drawing.Size(24, 22)
			cmdNewCustomRG2.Size = size
			Me.cmdNewCustomRG.TabIndex = 91
			Me.cmdNewCustomRG.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.cmdNewCustomRG.UseVisualStyleBackColor = False
			Me.cmdDeleteCustomRG.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdDeleteCustomRG.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdDeleteCustomRG.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdDeleteCustomRG.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdDeleteCustomRG, "Setup Rod Grade : Delete")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdDeleteCustomRG, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdDeleteCustomRG.Image = CType(componentResourceManager.GetObject("cmdDeleteCustomRG.Image"), Global.System.Drawing.Image)
			Me.cmdDeleteCustomRG.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdDeleteCustomRG As Global.System.Windows.Forms.Control = Me.cmdDeleteCustomRG
			location = New Global.System.Drawing.Point(72, 272)
			cmdDeleteCustomRG.Location = location
			Me.cmdDeleteCustomRG.Name = "cmdDeleteCustomRG"
			Me.cmdDeleteCustomRG.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdDeleteCustomRG, True)
			Dim cmdDeleteCustomRG2 As Global.System.Windows.Forms.Control = Me.cmdDeleteCustomRG
			size = New Global.System.Drawing.Size(24, 22)
			cmdDeleteCustomRG2.Size = size
			Me.cmdDeleteCustomRG.TabIndex = 93
			Me.cmdDeleteCustomRG.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.cmdDeleteCustomRG.UseVisualStyleBackColor = False
			Me.lvwCustomRG.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.RodType, Me.TensileStrength, Me.StressMethod, Me.SinkerBar })
			Me.lvwCustomRG.FullRowSelect = True
			Me.lvwCustomRG.GridLines = True
			Me.HelpProvider1.SetHelpKeyword(Me.lvwCustomRG, "Setup Custom Rod Grades Window")
			Me.HelpProvider1.SetHelpNavigator(Me.lvwCustomRG, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim lvwCustomRG As Global.System.Windows.Forms.Control = Me.lvwCustomRG
			location = New Global.System.Drawing.Point(8, 8)
			lvwCustomRG.Location = location
			Me.lvwCustomRG.MultiSelect = False
			Me.lvwCustomRG.Name = "lvwCustomRG"
			Me.HelpProvider1.SetShowHelp(Me.lvwCustomRG, True)
			Dim lvwCustomRG2 As Global.System.Windows.Forms.Control = Me.lvwCustomRG
			size = New Global.System.Drawing.Size(555, 256)
			lvwCustomRG2.Size = size
			Me.lvwCustomRG.TabIndex = 7
			Me.lvwCustomRG.UseCompatibleStateImageBehavior = False
			Me.RodType.Text = "Rod Type"
			Me.RodType.Width = 100
			Me.TensileStrength.Text = "Tensile Strength"
			Me.TensileStrength.Width = 100
			Me.StressMethod.Text = "Stress Method"
			Me.StressMethod.Width = 180
			Me.SinkerBar.Text = "Sinker Bar"
			Me.SinkerBar.Width = 75
			Me.pnlOutputOptions.Controls.Add(Me.cmdCheckData)
			Me.pnlOutputOptions.Controls.Add(Me.grpOutputOptions)
			Me.pnlOutputOptions.Controls.Add(Me.GroupBox2)
			Me.pnlOutputOptions.Controls.Add(Me.grpOutputPages)
			Dim pnlOutputOptions As Global.System.Windows.Forms.Control = Me.pnlOutputOptions
			location = New Global.System.Drawing.Point(-1333, 15)
			pnlOutputOptions.Location = location
			Me.pnlOutputOptions.Name = "pnlOutputOptions"
			Me.HelpProvider1.SetShowHelp(Me.pnlOutputOptions, False)
			Dim pnlOutputOptions2 As Global.System.Windows.Forms.Control = Me.pnlOutputOptions
			size = New Global.System.Drawing.Size(573, 311)
			pnlOutputOptions2.Size = size
			Me.pnlOutputOptions.TabIndex = 6
			Me.cmdCheckData.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCheckData As Global.System.Windows.Forms.Control = Me.cmdCheckData
			location = New Global.System.Drawing.Point(256, 280)
			cmdCheckData.Location = location
			Me.cmdCheckData.Name = "cmdCheckData"
			Me.HelpProvider1.SetShowHelp(Me.cmdCheckData, False)
			Dim cmdCheckData2 As Global.System.Windows.Forms.Control = Me.cmdCheckData
			size = New Global.System.Drawing.Size(120, 24)
			cmdCheckData2.Size = size
			Me.cmdCheckData.TabIndex = 3
			Me.cmdCheckData.Text = "Check data (hidden)"
			Me.cmdCheckData.Visible = False
			Me.grpOutputOptions.Controls.Add(Me.chkReportOpt_6)
			Me.grpOutputOptions.Controls.Add(Me.chkReportOpt_7)
			Dim grpOutputOptions As Global.System.Windows.Forms.Control = Me.grpOutputOptions
			location = New Global.System.Drawing.Point(16, 215)
			grpOutputOptions.Location = location
			Me.grpOutputOptions.Name = "grpOutputOptions"
			Me.HelpProvider1.SetShowHelp(Me.grpOutputOptions, False)
			Dim grpOutputOptions2 As Global.System.Windows.Forms.Control = Me.grpOutputOptions
			size = New Global.System.Drawing.Size(424, 64)
			grpOutputOptions2.Size = size
			Me.grpOutputOptions.TabIndex = 2
			Me.grpOutputOptions.TabStop = False
			Me.grpOutputOptions.Text = "Output options"
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_6, "Overlay Measured Surface Card")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_6, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_ As Global.System.Windows.Forms.Control = Me.chkReportOpt_6
			location = New Global.System.Drawing.Point(8, 24)
			chkReportOpt_.Location = location
			Me.chkReportOpt_6.Name = "chkReportOpt_6"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_6, True)
			Dim chkReportOpt_2 As Global.System.Windows.Forms.Control = Me.chkReportOpt_6
			size = New Global.System.Drawing.Size(408, 18)
			chkReportOpt_2.Size = size
			Me.chkReportOpt_6.TabIndex = 7
			Me.chkReportOpt_6.Text = "Overlay actual (measured) surface card"
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_7, "Omit Dynamometer Card and Torque Plot")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_7, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_3 As Global.System.Windows.Forms.Control = Me.chkReportOpt_7
			location = New Global.System.Drawing.Point(8, 42)
			chkReportOpt_3.Location = location
			Me.chkReportOpt_7.Name = "chkReportOpt_7"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_7, True)
			Dim chkReportOpt_4 As Global.System.Windows.Forms.Control = Me.chkReportOpt_7
			size = New Global.System.Drawing.Size(408, 18)
			chkReportOpt_4.Size = size
			Me.chkReportOpt_7.TabIndex = 8
			Me.chkReportOpt_7.Text = "Omit Dyno cards and Torque Plot from calculate results page when viewing."
			Me.GroupBox2.Controls.Add(Me.SSPanel)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(448, 8)
			groupBox3.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Me.HelpProvider1.SetShowHelp(Me.GroupBox2, False)
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(96, 267)
			groupBox4.Size = size
			Me.GroupBox2.TabIndex = 1
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Output Sample"
			Me.SSPanel.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.SSPanel.Controls.Add(Me.imgPreview_10)
			Me.SSPanel.Controls.Add(Me.imgPreview_9)
			Me.SSPanel.Controls.Add(Me.imgPreview_)
			Me.SSPanel.Controls.Add(Me.imgPreview_6)
			Me.SSPanel.Controls.Add(Me.imgPreview_3)
			Me.SSPanel.Controls.Add(Me.imgPreview_4)
			Me.SSPanel.Controls.Add(Me.imgPreview_5)
			Me.SSPanel.Controls.Add(Me.imgPreview_2)
			Me.SSPanel.Controls.Add(Me.imgPreview_0)
			Me.SSPanel.Controls.Add(Me.imgPreview_1)
			Dim sspanel As Global.System.Windows.Forms.Control = Me.SSPanel
			location = New Global.System.Drawing.Point(8, 16)
			sspanel.Location = location
			Me.SSPanel.Name = "SSPanel"
			Me.HelpProvider1.SetShowHelp(Me.SSPanel, False)
			Dim sspanel2 As Global.System.Windows.Forms.Control = Me.SSPanel
			size = New Global.System.Drawing.Size(80, 245)
			sspanel2.Size = size
			Me.SSPanel.TabIndex = 0
			Me.imgPreview_10.Image = CType(componentResourceManager.GetObject("imgPreview_10.Image"), Global.System.Drawing.Image)
			Me.imgPreview_10.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_ As Global.System.Windows.Forms.Control = Me.imgPreview_10
			location = New Global.System.Drawing.Point(40, 160)
			imgPreview_.Location = location
			Me.imgPreview_10.Name = "imgPreview_10"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_10, False)
			Dim imgPreview_2 As Global.System.Windows.Forms.Control = Me.imgPreview_10
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_2.Size = size
			Me.imgPreview_10.TabIndex = 11
			Me.imgPreview_10.TabStop = False
			Me.imgPreview_10.Visible = False
			Me.imgPreview_9.Image = CType(componentResourceManager.GetObject("imgPreview_9.Image"), Global.System.Drawing.Image)
			Dim imgPreview_3 As Global.System.Windows.Forms.Control = Me.imgPreview_9
			location = New Global.System.Drawing.Point(0, 160)
			imgPreview_3.Location = location
			Me.imgPreview_9.Name = "imgPreview_9"
			Dim imgPreview_4 As Global.System.Windows.Forms.Control = Me.imgPreview_9
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_4.Size = size
			Me.imgPreview_9.TabIndex = 10
			Me.imgPreview_9.TabStop = False
			Me.imgPreview_9.Visible = False
			Me.imgPreview_.Image = CType(componentResourceManager.GetObject("imgPreview_.Image"), Global.System.Drawing.Image)
			Me.imgPreview_.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_5 As Global.System.Windows.Forms.Control = Me.imgPreview_
			location = New Global.System.Drawing.Point(40, 120)
			imgPreview_5.Location = location
			Me.imgPreview_.Name = "imgPreview_"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_, False)
			Dim imgPreview_6 As Global.System.Windows.Forms.Control = Me.imgPreview_
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_6.Size = size
			Me.imgPreview_.TabIndex = 9
			Me.imgPreview_.TabStop = False
			Me.imgPreview_.Visible = False
			Me.imgPreview_6.Image = CType(componentResourceManager.GetObject("imgPreview_6.Image"), Global.System.Drawing.Image)
			Me.imgPreview_6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_7 As Global.System.Windows.Forms.Control = Me.imgPreview_6
			location = New Global.System.Drawing.Point(0, 120)
			imgPreview_7.Location = location
			Me.imgPreview_6.Name = "imgPreview_6"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_6, False)
			Dim imgPreview_8 As Global.System.Windows.Forms.Control = Me.imgPreview_6
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_8.Size = size
			Me.imgPreview_6.TabIndex = 6
			Me.imgPreview_6.TabStop = False
			Me.imgPreview_6.Visible = False
			Me.imgPreview_3.Image = CType(componentResourceManager.GetObject("imgPreview_3.Image"), Global.System.Drawing.Image)
			Me.imgPreview_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_9 As Global.System.Windows.Forms.Control = Me.imgPreview_3
			location = New Global.System.Drawing.Point(40, 80)
			imgPreview_9.Location = location
			Me.imgPreview_3.Name = "imgPreview_3"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_3, False)
			Dim imgPreview_10 As Global.System.Windows.Forms.Control = Me.imgPreview_3
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_10.Size = size
			Me.imgPreview_3.TabIndex = 5
			Me.imgPreview_3.TabStop = False
			Me.imgPreview_3.Visible = False
			Me.imgPreview_4.Image = CType(componentResourceManager.GetObject("imgPreview_4.Image"), Global.System.Drawing.Image)
			Me.imgPreview_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_11 As Global.System.Windows.Forms.Control = Me.imgPreview_4
			location = New Global.System.Drawing.Point(0, 80)
			imgPreview_11.Location = location
			Me.imgPreview_4.Name = "imgPreview_4"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_4, False)
			Dim imgPreview_12 As Global.System.Windows.Forms.Control = Me.imgPreview_4
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_12.Size = size
			Me.imgPreview_4.TabIndex = 4
			Me.imgPreview_4.TabStop = False
			Me.imgPreview_4.Visible = False
			Me.imgPreview_5.Image = CType(componentResourceManager.GetObject("imgPreview_5.Image"), Global.System.Drawing.Image)
			Me.imgPreview_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_13 As Global.System.Windows.Forms.Control = Me.imgPreview_5
			location = New Global.System.Drawing.Point(40, 40)
			imgPreview_13.Location = location
			Me.imgPreview_5.Name = "imgPreview_5"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_5, False)
			Dim imgPreview_14 As Global.System.Windows.Forms.Control = Me.imgPreview_5
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_14.Size = size
			Me.imgPreview_5.TabIndex = 3
			Me.imgPreview_5.TabStop = False
			Me.imgPreview_5.Visible = False
			Me.imgPreview_2.Image = CType(componentResourceManager.GetObject("imgPreview_2.Image"), Global.System.Drawing.Image)
			Me.imgPreview_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_15 As Global.System.Windows.Forms.Control = Me.imgPreview_2
			location = New Global.System.Drawing.Point(0, 40)
			imgPreview_15.Location = location
			Me.imgPreview_2.Name = "imgPreview_2"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_2, False)
			Dim imgPreview_16 As Global.System.Windows.Forms.Control = Me.imgPreview_2
			size = New Global.System.Drawing.Size(32, 32)
			imgPreview_16.Size = size
			Me.imgPreview_2.TabIndex = 2
			Me.imgPreview_2.TabStop = False
			Me.imgPreview_2.Visible = False
			Me.imgPreview_0.Image = CType(componentResourceManager.GetObject("imgPreview_0.Image"), Global.System.Drawing.Image)
			Me.imgPreview_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_17 As Global.System.Windows.Forms.Control = Me.imgPreview_0
			location = New Global.System.Drawing.Point(0, 0)
			imgPreview_17.Location = location
			Me.imgPreview_0.Name = "imgPreview_0"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_0, False)
			Dim imgPreview_18 As Global.System.Windows.Forms.Control = Me.imgPreview_0
			size = New Global.System.Drawing.Size(32, 38)
			imgPreview_18.Size = size
			Me.imgPreview_0.TabIndex = 1
			Me.imgPreview_0.TabStop = False
			Me.imgPreview_0.Visible = False
			Me.imgPreview_1.Image = CType(componentResourceManager.GetObject("imgPreview_1.Image"), Global.System.Drawing.Image)
			Me.imgPreview_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgPreview_19 As Global.System.Windows.Forms.Control = Me.imgPreview_1
			location = New Global.System.Drawing.Point(40, 0)
			imgPreview_19.Location = location
			Me.imgPreview_1.Name = "imgPreview_1"
			Me.HelpProvider1.SetShowHelp(Me.imgPreview_1, False)
			Dim imgPreview_20 As Global.System.Windows.Forms.Control = Me.imgPreview_1
			size = New Global.System.Drawing.Size(32, 40)
			imgPreview_20.Size = size
			Me.imgPreview_1.TabIndex = 0
			Me.imgPreview_1.TabStop = False
			Me.imgPreview_1.Visible = False
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_10)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_9)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_8)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_5)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_4)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_3)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_2)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_0)
			Me.grpOutputPages.Controls.Add(Me.chkReportOpt_1)
			Dim grpOutputPages As Global.System.Windows.Forms.Control = Me.grpOutputPages
			location = New Global.System.Drawing.Point(16, 8)
			grpOutputPages.Location = location
			Me.grpOutputPages.Name = "grpOutputPages"
			Me.HelpProvider1.SetShowHelp(Me.grpOutputPages, False)
			Dim grpOutputPages2 As Global.System.Windows.Forms.Control = Me.grpOutputPages
			size = New Global.System.Drawing.Size(424, 204)
			grpOutputPages2.Size = size
			Me.grpOutputPages.TabIndex = 0
			Me.grpOutputPages.TabStop = False
			Me.grpOutputPages.Text = "Select output pages:"
			Me.chkReportOpt_10.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_10, "Rod String Order Summary")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_10, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_10.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_5 As Global.System.Windows.Forms.Control = Me.chkReportOpt_10
			location = New Global.System.Drawing.Point(8, 96)
			chkReportOpt_5.Location = location
			Me.chkReportOpt_10.Name = "chkReportOpt_10"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_10, True)
			Dim chkReportOpt_6 As Global.System.Windows.Forms.Control = Me.chkReportOpt_10
			size = New Global.System.Drawing.Size(376, 17)
			chkReportOpt_6.Size = size
			Me.chkReportOpt_10.TabIndex = 12
			Me.chkReportOpt_10.Text = "Rod String Order Summary"
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_9, "Setup Output: Scoring")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_9, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim chkReportOpt_7 As Global.System.Windows.Forms.Control = Me.chkReportOpt_9
			location = New Global.System.Drawing.Point(8, 42)
			chkReportOpt_7.Location = location
			Me.chkReportOpt_9.Name = "chkReportOpt_9"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_9, True)
			Dim chkReportOpt_8 As Global.System.Windows.Forms.Control = Me.chkReportOpt_9
			size = New Global.System.Drawing.Size(400, 18)
			chkReportOpt_8.Size = size
			Me.chkReportOpt_9.TabIndex = 9
			Me.chkReportOpt_9.Text = "System Design Scoring page"
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_, "Setup Output: Cover Page")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_9 As Global.System.Windows.Forms.Control = Me.chkReportOpt_
			location = New Global.System.Drawing.Point(8, 24)
			chkReportOpt_9.Location = location
			Me.chkReportOpt_.Name = "chkReportOpt_"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_, True)
			Dim chkReportOpt_10 As Global.System.Windows.Forms.Control = Me.chkReportOpt_
			size = New Global.System.Drawing.Size(376, 18)
			chkReportOpt_10.Size = size
			Me.chkReportOpt_.TabIndex = 8
			Me.chkReportOpt_.Text = "Cover Page"
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_8, "Measured Deviation Survey")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_8, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_8.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_11 As Global.System.Windows.Forms.Control = Me.chkReportOpt_8
			location = New Global.System.Drawing.Point(8, 186)
			chkReportOpt_11.Location = location
			Me.chkReportOpt_8.Name = "chkReportOpt_8"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_8, True)
			Dim chkReportOpt_12 As Global.System.Windows.Forms.Control = Me.chkReportOpt_8
			size = New Global.System.Drawing.Size(376, 18)
			chkReportOpt_12.Size = size
			Me.chkReportOpt_8.TabIndex = 7
			Me.chkReportOpt_8.Text = "Measured Deviation Survey"
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_5, "Recommended Guide Report")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_5, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_13 As Global.System.Windows.Forms.Control = Me.chkReportOpt_5
			location = New Global.System.Drawing.Point(8, 168)
			chkReportOpt_13.Location = location
			Me.chkReportOpt_5.Name = "chkReportOpt_5"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_5, True)
			Dim chkReportOpt_14 As Global.System.Windows.Forms.Control = Me.chkReportOpt_5
			size = New Global.System.Drawing.Size(376, 18)
			chkReportOpt_14.Size = size
			Me.chkReportOpt_5.TabIndex = 6
			Me.chkReportOpt_5.Text = "Recommended Guide Report"
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_4, "Deviation Charts")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_4, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_15 As Global.System.Windows.Forms.Control = Me.chkReportOpt_4
			location = New Global.System.Drawing.Point(8, 150)
			chkReportOpt_15.Location = location
			Me.chkReportOpt_4.Name = "chkReportOpt_4"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_4, True)
			Dim chkReportOpt_16 As Global.System.Windows.Forms.Control = Me.chkReportOpt_4
			size = New Global.System.Drawing.Size(376, 18)
			chkReportOpt_16.Size = size
			Me.chkReportOpt_4.TabIndex = 5
			Me.chkReportOpt_4.Text = "Deviation Charts"
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_3, "Setup Output: Dynamometer Card and Torque Plot")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_3, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_17 As Global.System.Windows.Forms.Control = Me.chkReportOpt_3
			location = New Global.System.Drawing.Point(8, 132)
			chkReportOpt_17.Location = location
			Me.chkReportOpt_3.Name = "chkReportOpt_3"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_3, True)
			Dim chkReportOpt_18 As Global.System.Windows.Forms.Control = Me.chkReportOpt_3
			size = New Global.System.Drawing.Size(376, 18)
			chkReportOpt_18.Size = size
			Me.chkReportOpt_3.TabIndex = 4
			Me.chkReportOpt_3.Text = "Dynamometer cards and Torque Plots"
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_2, "Setup Output: IPR")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_19 As Global.System.Windows.Forms.Control = Me.chkReportOpt_2
			location = New Global.System.Drawing.Point(8, 114)
			chkReportOpt_19.Location = location
			Me.chkReportOpt_2.Name = "chkReportOpt_2"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_2, True)
			Dim chkReportOpt_20 As Global.System.Windows.Forms.Control = Me.chkReportOpt_2
			size = New Global.System.Drawing.Size(376, 18)
			chkReportOpt_20.Size = size
			Me.chkReportOpt_2.TabIndex = 3
			Me.chkReportOpt_2.Text = "Inflow performances (IPR) chart"
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_0, "Setup Output: Input Data")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_0, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_21 As Global.System.Windows.Forms.Control = Me.chkReportOpt_0
			location = New Global.System.Drawing.Point(8, 60)
			chkReportOpt_21.Location = location
			Me.chkReportOpt_0.Name = "chkReportOpt_0"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_0, True)
			Dim chkReportOpt_22 As Global.System.Windows.Forms.Control = Me.chkReportOpt_0
			size = New Global.System.Drawing.Size(376, 18)
			chkReportOpt_22.Size = size
			Me.chkReportOpt_0.TabIndex = 1
			Me.chkReportOpt_0.Text = "Input data and calculated results"
			Me.HelpProvider1.SetHelpKeyword(Me.chkReportOpt_1, "Setup Output: Cost Analysis")
			Me.HelpProvider1.SetHelpNavigator(Me.chkReportOpt_1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkReportOpt_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkReportOpt_23 As Global.System.Windows.Forms.Control = Me.chkReportOpt_1
			location = New Global.System.Drawing.Point(8, 78)
			chkReportOpt_23.Location = location
			Me.chkReportOpt_1.Name = "chkReportOpt_1"
			Me.HelpProvider1.SetShowHelp(Me.chkReportOpt_1, True)
			Dim chkReportOpt_24 As Global.System.Windows.Forms.Control = Me.chkReportOpt_1
			size = New Global.System.Drawing.Size(376, 18)
			chkReportOpt_24.Size = size
			Me.chkReportOpt_1.TabIndex = 2
			Me.chkReportOpt_1.Text = "Cost analysis"
			Me.btnOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
			location = New Global.System.Drawing.Point(701, 558)
			btnOK.Location = location
			Me.btnOK.Name = "btnOK"
			Me.HelpProvider1.SetShowHelp(Me.btnOK, False)
			Dim btnOK2 As Global.System.Windows.Forms.Control = Me.btnOK
			size = New Global.System.Drawing.Size(70, 24)
			btnOK2.Size = size
			Me.btnOK.TabIndex = 7
			Me.btnOK.Text = "OK"
			Me.btnCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
			location = New Global.System.Drawing.Point(773, 558)
			btnCancel.Location = location
			Me.btnCancel.Name = "btnCancel"
			Me.HelpProvider1.SetShowHelp(Me.btnCancel, False)
			Dim btnCancel2 As Global.System.Windows.Forms.Control = Me.btnCancel
			size = New Global.System.Drawing.Size(70, 24)
			btnCancel2.Size = size
			Me.btnCancel.TabIndex = 8
			Me.btnCancel.Text = "Cancel"
			Me.pnlDebug.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlDebug.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.pnlDebug.Controls.Add(Me.chkPlotAllDownholeCards)
			Me.pnlDebug.Controls.Add(Me.chkDebugShowMessages)
			Me.pnlDebug.Controls.Add(Me.chkDebugDisableOnError)
			Me.pnlDebug.Controls.Add(Me.chkDebugShowPredictInfo)
			Me.pnlDebug.Controls.Add(Me.chkDebugSetNcycles)
			Me.pnlDebug.Controls.Add(Me.chkDebugCreateDYN)
			Me.pnlDebug.Controls.Add(Me.chkDebugShowAllBalanced)
			Me.pnlDebug.Controls.Add(Me.chkDebugCreateTF)
			Me.pnlDebug.Controls.Add(Me.chkDebugCreateTQ)
			Me.pnlDebug.Controls.Add(Me.chkDebugCreateDPC)
			Me.pnlDebug.Controls.Add(Me._Label_16)
			Me.pnlDebug.Controls.Add(Me._Label_15)
			Me.pnlDebug.Controls.Add(Me._Label_14)
			Me.pnlDebug.Controls.Add(Me._Label_13)
			Me.pnlDebug.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlDebug.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlDebug.ForeColor = Global.System.Drawing.Color.Black
			Dim pnlDebug As Global.System.Windows.Forms.Control = Me.pnlDebug
			location = New Global.System.Drawing.Point(-1333, 15)
			pnlDebug.Location = location
			Me.pnlDebug.Name = "pnlDebug"
			Me.pnlDebug.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.pnlDebug, False)
			Dim pnlDebug2 As Global.System.Windows.Forms.Control = Me.pnlDebug
			size = New Global.System.Drawing.Size(571, 217)
			pnlDebug2.Size = size
			Me.pnlDebug.TabIndex = 88
			Me.pnlDebug.Visible = False
			Me.chkPlotAllDownholeCards.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkPlotAllDownholeCards.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkPlotAllDownholeCards.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.chkPlotAllDownholeCards.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkPlotAllDownholeCards.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkPlotAllDownholeCards As Global.System.Windows.Forms.Control = Me.chkPlotAllDownholeCards
			location = New Global.System.Drawing.Point(32, 32)
			chkPlotAllDownholeCards.Location = location
			Me.chkPlotAllDownholeCards.Name = "chkPlotAllDownholeCards"
			Me.chkPlotAllDownholeCards.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkPlotAllDownholeCards, False)
			Dim chkPlotAllDownholeCards2 As Global.System.Windows.Forms.Control = Me.chkPlotAllDownholeCards
			size = New Global.System.Drawing.Size(256, 17)
			chkPlotAllDownholeCards2.Size = size
			Me.chkPlotAllDownholeCards.TabIndex = 82
			Me.chkPlotAllDownholeCards.Text = "Plot all calculated dynohole cards"
			Me.chkPlotAllDownholeCards.UseVisualStyleBackColor = False
			Me.chkDebugShowMessages.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkDebugShowMessages.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkDebugShowMessages.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.chkDebugShowMessages.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkDebugShowMessages.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugShowMessages As Global.System.Windows.Forms.Control = Me.chkDebugShowMessages
			location = New Global.System.Drawing.Point(32, 104)
			chkDebugShowMessages.Location = location
			Me.chkDebugShowMessages.Name = "chkDebugShowMessages"
			Me.chkDebugShowMessages.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkDebugShowMessages, False)
			Dim chkDebugShowMessages2 As Global.System.Windows.Forms.Control = Me.chkDebugShowMessages
			size = New Global.System.Drawing.Size(147, 17)
			chkDebugShowMessages2.Size = size
			Me.chkDebugShowMessages.TabIndex = 72
			Me.chkDebugShowMessages.Text = "Show &debug messages"
			Me.chkDebugShowMessages.UseVisualStyleBackColor = False
			Me.chkDebugShowMessages.Visible = False
			Me.chkDebugDisableOnError.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkDebugDisableOnError.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkDebugDisableOnError.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.chkDebugDisableOnError.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkDebugDisableOnError.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugDisableOnError As Global.System.Windows.Forms.Control = Me.chkDebugDisableOnError
			location = New Global.System.Drawing.Point(32, 56)
			chkDebugDisableOnError.Location = location
			Me.chkDebugDisableOnError.Name = "chkDebugDisableOnError"
			Me.chkDebugDisableOnError.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkDebugDisableOnError, False)
			Dim chkDebugDisableOnError2 As Global.System.Windows.Forms.Control = Me.chkDebugDisableOnError
			size = New Global.System.Drawing.Size(130, 17)
			chkDebugDisableOnError2.Size = size
			Me.chkDebugDisableOnError.TabIndex = 66
			Me.chkDebugDisableOnError.Text = "Disable &ON ERROR"
			Me.chkDebugDisableOnError.UseVisualStyleBackColor = False
			Me.chkDebugDisableOnError.Visible = False
			Me.chkDebugShowPredictInfo.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkDebugShowPredictInfo.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkDebugShowPredictInfo.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.chkDebugShowPredictInfo.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkDebugShowPredictInfo.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugShowPredictInfo As Global.System.Windows.Forms.Control = Me.chkDebugShowPredictInfo
			location = New Global.System.Drawing.Point(32, 120)
			chkDebugShowPredictInfo.Location = location
			Me.chkDebugShowPredictInfo.Name = "chkDebugShowPredictInfo"
			Me.chkDebugShowPredictInfo.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkDebugShowPredictInfo, False)
			Dim chkDebugShowPredictInfo2 As Global.System.Windows.Forms.Control = Me.chkDebugShowPredictInfo
			size = New Global.System.Drawing.Size(133, 17)
			chkDebugShowPredictInfo2.Size = size
			Me.chkDebugShowPredictInfo.TabIndex = 73
			Me.chkDebugShowPredictInfo.Text = "Show &PREDICT info"
			Me.chkDebugShowPredictInfo.UseVisualStyleBackColor = False
			Me.chkDebugShowPredictInfo.Visible = False
			Me.chkDebugSetNcycles.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkDebugSetNcycles.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkDebugSetNcycles.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.chkDebugSetNcycles.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkDebugSetNcycles.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugSetNcycles As Global.System.Windows.Forms.Control = Me.chkDebugSetNcycles
			location = New Global.System.Drawing.Point(32, 80)
			chkDebugSetNcycles.Location = location
			Me.chkDebugSetNcycles.Name = "chkDebugSetNcycles"
			Me.chkDebugSetNcycles.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkDebugSetNcycles, False)
			Dim chkDebugSetNcycles2 As Global.System.Windows.Forms.Control = Me.chkDebugSetNcycles
			size = New Global.System.Drawing.Size(87, 17)
			chkDebugSetNcycles2.Size = size
			Me.chkDebugSetNcycles.TabIndex = 67
			Me.chkDebugSetNcycles.Text = "Set &Ncycles"
			Me.chkDebugSetNcycles.UseVisualStyleBackColor = False
			Me.chkDebugSetNcycles.Visible = False
			Me.chkDebugCreateDYN.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkDebugCreateDYN.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkDebugCreateDYN.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.chkDebugCreateDYN.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkDebugCreateDYN.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugCreateDYN As Global.System.Windows.Forms.Control = Me.chkDebugCreateDYN
			location = New Global.System.Drawing.Point(72, 176)
			chkDebugCreateDYN.Location = location
			Me.chkDebugCreateDYN.Name = "chkDebugCreateDYN"
			Me.chkDebugCreateDYN.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkDebugCreateDYN, False)
			Dim chkDebugCreateDYN2 As Global.System.Windows.Forms.Control = Me.chkDebugCreateDYN
			size = New Global.System.Drawing.Size(42, 17)
			chkDebugCreateDYN2.Size = size
			Me.chkDebugCreateDYN.TabIndex = 77
			Me.chkDebugCreateDYN.Text = "DYN"
			Me.chkDebugCreateDYN.UseVisualStyleBackColor = False
			Me.chkDebugCreateDYN.Visible = False
			Me.chkDebugShowAllBalanced.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkDebugShowAllBalanced.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkDebugShowAllBalanced.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.chkDebugShowAllBalanced.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkDebugShowAllBalanced.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugShowAllBalanced As Global.System.Windows.Forms.Control = Me.chkDebugShowAllBalanced
			location = New Global.System.Drawing.Point(32, 144)
			chkDebugShowAllBalanced.Location = location
			Me.chkDebugShowAllBalanced.Name = "chkDebugShowAllBalanced"
			Me.chkDebugShowAllBalanced.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkDebugShowAllBalanced, False)
			Dim chkDebugShowAllBalanced2 As Global.System.Windows.Forms.Control = Me.chkDebugShowAllBalanced
			size = New Global.System.Drawing.Size(233, 17)
			chkDebugShowAllBalanced2.Size = size
			Me.chkDebugShowAllBalanced.TabIndex = 74
			Me.chkDebugShowAllBalanced.Text = "Show bal. min. torque and min. energy"
			Me.chkDebugShowAllBalanced.UseVisualStyleBackColor = False
			Me.chkDebugShowAllBalanced.Visible = False
			Me.chkDebugCreateTF.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkDebugCreateTF.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkDebugCreateTF.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.chkDebugCreateTF.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkDebugCreateTF.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugCreateTF As Global.System.Windows.Forms.Control = Me.chkDebugCreateTF
			location = New Global.System.Drawing.Point(120, 176)
			chkDebugCreateTF.Location = location
			Me.chkDebugCreateTF.Name = "chkDebugCreateTF"
			Me.chkDebugCreateTF.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkDebugCreateTF, False)
			Dim chkDebugCreateTF2 As Global.System.Windows.Forms.Control = Me.chkDebugCreateTF
			size = New Global.System.Drawing.Size(32, 17)
			chkDebugCreateTF2.Size = size
			Me.chkDebugCreateTF.TabIndex = 78
			Me.chkDebugCreateTF.Text = "TF"
			Me.chkDebugCreateTF.UseVisualStyleBackColor = False
			Me.chkDebugCreateTF.Visible = False
			Me.chkDebugCreateTQ.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkDebugCreateTQ.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkDebugCreateTQ.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.chkDebugCreateTQ.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkDebugCreateTQ.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugCreateTQ As Global.System.Windows.Forms.Control = Me.chkDebugCreateTQ
			location = New Global.System.Drawing.Point(152, 176)
			chkDebugCreateTQ.Location = location
			Me.chkDebugCreateTQ.Name = "chkDebugCreateTQ"
			Me.chkDebugCreateTQ.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkDebugCreateTQ, False)
			Dim chkDebugCreateTQ2 As Global.System.Windows.Forms.Control = Me.chkDebugCreateTQ
			size = New Global.System.Drawing.Size(34, 17)
			chkDebugCreateTQ2.Size = size
			Me.chkDebugCreateTQ.TabIndex = 79
			Me.chkDebugCreateTQ.Text = "TQ"
			Me.chkDebugCreateTQ.UseVisualStyleBackColor = False
			Me.chkDebugCreateTQ.Visible = False
			Me.chkDebugCreateDPC.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkDebugCreateDPC.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkDebugCreateDPC.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.chkDebugCreateDPC.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.chkDebugCreateDPC.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugCreateDPC As Global.System.Windows.Forms.Control = Me.chkDebugCreateDPC
			location = New Global.System.Drawing.Point(184, 176)
			chkDebugCreateDPC.Location = location
			Me.chkDebugCreateDPC.Name = "chkDebugCreateDPC"
			Me.chkDebugCreateDPC.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkDebugCreateDPC, False)
			Dim chkDebugCreateDPC2 As Global.System.Windows.Forms.Control = Me.chkDebugCreateDPC
			size = New Global.System.Drawing.Size(40, 17)
			chkDebugCreateDPC2.Size = size
			Me.chkDebugCreateDPC.TabIndex = 80
			Me.chkDebugCreateDPC.Text = "DPC"
			Me.chkDebugCreateDPC.UseVisualStyleBackColor = False
			Me.chkDebugCreateDPC.Visible = False
			Me._Label_16.AutoSize = True
			Me._Label_16.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_16.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_16.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_16.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_16.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_16
			location = New Global.System.Drawing.Point(3, 2)
			label_.Location = location
			Me._Label_16.Name = "_Label_16"
			Me._Label_16.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_16, False)
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_16
			size = New Global.System.Drawing.Size(221, 14)
			label_2.Size = size
			Me._Label_16.TabIndex = 65
			Me._Label_16.Text = "Select from the following debugging options:"
			Me._Label_15.AutoSize = True
			Me._Label_15.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_15.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_15.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_15.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_15.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_3 As Global.System.Windows.Forms.Control = Me._Label_15
			location = New Global.System.Drawing.Point(32, 168)
			label_3.Location = location
			Me._Label_15.Name = "_Label_15"
			Me._Label_15.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_15, False)
			Dim label_4 As Global.System.Windows.Forms.Control = Me._Label_15
			size = New Global.System.Drawing.Size(46, 14)
			label_4.Size = size
			Me._Label_15.TabIndex = 75
			Me._Label_15.Text = "IMPRED:"
			Me._Label_15.Visible = False
			Me._Label_14.AutoSize = True
			Me._Label_14.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_14.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_14.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_14.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_14.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_5 As Global.System.Windows.Forms.Control = Me._Label_14
			location = New Global.System.Drawing.Point(40, 184)
			label_5.Location = location
			Me._Label_14.Name = "_Label_14"
			Me._Label_14.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_14, False)
			Dim label_6 As Global.System.Windows.Forms.Control = Me._Label_14
			size = New Global.System.Drawing.Size(39, 14)
			label_6.Size = size
			Me._Label_14.TabIndex = 76
			Me._Label_14.Text = "Create"
			Me._Label_14.Visible = False
			Me._Label_13.AutoSize = True
			Me._Label_13.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_13.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_13.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_13.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_13.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_7 As Global.System.Windows.Forms.Control = Me._Label_13
			location = New Global.System.Drawing.Point(224, 184)
			label_7.Location = location
			Me._Label_13.Name = "_Label_13"
			Me._Label_13.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_13, False)
			Dim label_8 As Global.System.Windows.Forms.Control = Me._Label_13
			size = New Global.System.Drawing.Size(27, 14)
			label_8.Size = size
			Me._Label_13.TabIndex = 81
			Me._Label_13.Text = "files"
			Me._Label_13.Visible = False
			Me.pnlCustomPUList.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlCustomPUList.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.pnlCustomPUList.Controls.Add(Me.cboManufMenuCustomDB)
			Me.pnlCustomPUList.Controls.Add(Me.lvwCustomPUDB)
			Me.pnlCustomPUList.Controls.Add(Me.Label1)
			Me.pnlCustomPUList.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlCustomPUList.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlCustomPUList.ForeColor = Global.System.Drawing.Color.Black
			Dim pnlCustomPUList As Global.System.Windows.Forms.Control = Me.pnlCustomPUList
			location = New Global.System.Drawing.Point(-1333, 16)
			pnlCustomPUList.Location = location
			Me.pnlCustomPUList.Name = "pnlCustomPUList"
			Me.pnlCustomPUList.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.pnlCustomPUList, False)
			Dim pnlCustomPUList2 As Global.System.Windows.Forms.Control = Me.pnlCustomPUList
			size = New Global.System.Drawing.Size(773, 304)
			pnlCustomPUList2.Size = size
			Me.pnlCustomPUList.TabIndex = 91
			Me.cboManufMenuCustomDB.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboManufMenuCustomDB.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboManufMenuCustomDB.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboManufMenuCustomDB.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboManufMenuCustomDB.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.cboManufMenuCustomDB.ItemHeight = 14
			Dim cboManufMenuCustomDB As Global.System.Windows.Forms.Control = Me.cboManufMenuCustomDB
			location = New Global.System.Drawing.Point(177, 0)
			cboManufMenuCustomDB.Location = location
			Me.cboManufMenuCustomDB.Name = "cboManufMenuCustomDB"
			Me.cboManufMenuCustomDB.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboManufMenuCustomDB, False)
			Dim cboManufMenuCustomDB2 As Global.System.Windows.Forms.Control = Me.cboManufMenuCustomDB
			size = New Global.System.Drawing.Size(195, 22)
			cboManufMenuCustomDB2.Size = size
			Me.cboManufMenuCustomDB.TabIndex = 22
			Dim lvwCustomPUDB As Global.System.Windows.Forms.Control = Me.lvwCustomPUDB
			location = New Global.System.Drawing.Point(0, 22)
			lvwCustomPUDB.Location = location
			Me.lvwCustomPUDB.Name = "lvwCustomPUDB"
			Me.HelpProvider1.SetShowHelp(Me.lvwCustomPUDB, False)
			Dim lvwCustomPUDB2 As Global.System.Windows.Forms.Control = Me.lvwCustomPUDB
			size = New Global.System.Drawing.Size(373, 242)
			lvwCustomPUDB2.Size = size
			Me.lvwCustomPUDB.TabIndex = 23
			Me.lvwCustomPUDB.UseCompatibleStateImageBehavior = False
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.Label1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(44, 4)
			label.Location = location
			Me.Label1.Name = "Label1"
			Me.Label1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label1, False)
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(138, 14)
			label2.Size = size
			Me.Label1.TabIndex = 21
			Me.Label1.Text = "Pumping unit manufacturer:"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.pnlCustomMeasuredPUList.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlCustomMeasuredPUList.Controls.Add(Me.lvwCustomPU)
			Me.pnlCustomMeasuredPUList.Controls.Add(Me.cmdDeleteCustomPU)
			Me.pnlCustomMeasuredPUList.Controls.Add(Me.cmdModifyCustomPU)
			Me.pnlCustomMeasuredPUList.Controls.Add(Me.cmdNewCustomPU)
			Me.pnlCustomMeasuredPUList.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlCustomMeasuredPUList.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlCustomMeasuredPUList.ForeColor = Global.System.Drawing.Color.Black
			Dim pnlCustomMeasuredPUList As Global.System.Windows.Forms.Control = Me.pnlCustomMeasuredPUList
			location = New Global.System.Drawing.Point(-1333, 16)
			pnlCustomMeasuredPUList.Location = location
			Me.pnlCustomMeasuredPUList.Name = "pnlCustomMeasuredPUList"
			Me.pnlCustomMeasuredPUList.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.pnlCustomMeasuredPUList, False)
			Dim pnlCustomMeasuredPUList2 As Global.System.Windows.Forms.Control = Me.pnlCustomMeasuredPUList
			size = New Global.System.Drawing.Size(708, 304)
			pnlCustomMeasuredPUList2.Size = size
			Me.pnlCustomMeasuredPUList.TabIndex = 93
			Me.lvwCustomPU.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.Manufacturer, Me.APIDesignation, Me.UnitName, Me.OtherInfo })
			Me.lvwCustomPU.FullRowSelect = True
			Me.lvwCustomPU.GridLines = True
			Me.HelpProvider1.SetHelpKeyword(Me.lvwCustomPU, "Measured Pumping Unit List")
			Me.HelpProvider1.SetHelpNavigator(Me.lvwCustomPU, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim lvwCustomPU As Global.System.Windows.Forms.Control = Me.lvwCustomPU
			location = New Global.System.Drawing.Point(16, 16)
			lvwCustomPU.Location = location
			Me.lvwCustomPU.MultiSelect = False
			Me.lvwCustomPU.Name = "lvwCustomPU"
			Me.HelpProvider1.SetShowHelp(Me.lvwCustomPU, True)
			Dim lvwCustomPU2 As Global.System.Windows.Forms.Control = Me.lvwCustomPU
			size = New Global.System.Drawing.Size(565, 240)
			lvwCustomPU2.Size = size
			Me.lvwCustomPU.TabIndex = 90
			Me.lvwCustomPU.UseCompatibleStateImageBehavior = False
			Me.Manufacturer.Text = "Manufacturer"
			Me.Manufacturer.Width = 100
			Me.APIDesignation.Text = "API Designation"
			Me.APIDesignation.Width = 100
			Me.UnitName.Text = "Unit Name"
			Me.UnitName.Width = 100
			Me.OtherInfo.Text = "Other Info"
			Me.OtherInfo.Width = 100
			Me.cmdDeleteCustomPU.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdDeleteCustomPU.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdDeleteCustomPU.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdDeleteCustomPU.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdDeleteCustomPU, "Setup Pumping Unit Equipment: Delete Command Button")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdDeleteCustomPU, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdDeleteCustomPU.Image = CType(componentResourceManager.GetObject("cmdDeleteCustomPU.Image"), Global.System.Drawing.Image)
			Me.cmdDeleteCustomPU.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdDeleteCustomPU As Global.System.Windows.Forms.Control = Me.cmdDeleteCustomPU
			location = New Global.System.Drawing.Point(80, 272)
			cmdDeleteCustomPU.Location = location
			Me.cmdDeleteCustomPU.Name = "cmdDeleteCustomPU"
			Me.cmdDeleteCustomPU.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdDeleteCustomPU, True)
			Dim cmdDeleteCustomPU2 As Global.System.Windows.Forms.Control = Me.cmdDeleteCustomPU
			size = New Global.System.Drawing.Size(24, 22)
			cmdDeleteCustomPU2.Size = size
			Me.cmdDeleteCustomPU.TabIndex = 87
			Me.cmdDeleteCustomPU.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.cmdDeleteCustomPU.UseVisualStyleBackColor = False
			Me.cmdModifyCustomPU.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdModifyCustomPU.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdModifyCustomPU.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdModifyCustomPU.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdModifyCustomPU, "Setup Pumping Unit Equipment: Modify Button")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdModifyCustomPU, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdModifyCustomPU.Image = CType(componentResourceManager.GetObject("cmdModifyCustomPU.Image"), Global.System.Drawing.Image)
			Me.cmdModifyCustomPU.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdModifyCustomPU As Global.System.Windows.Forms.Control = Me.cmdModifyCustomPU
			location = New Global.System.Drawing.Point(48, 272)
			cmdModifyCustomPU.Location = location
			Me.cmdModifyCustomPU.Name = "cmdModifyCustomPU"
			Me.cmdModifyCustomPU.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdModifyCustomPU, True)
			Dim cmdModifyCustomPU2 As Global.System.Windows.Forms.Control = Me.cmdModifyCustomPU
			size = New Global.System.Drawing.Size(24, 22)
			cmdModifyCustomPU2.Size = size
			Me.cmdModifyCustomPU.TabIndex = 86
			Me.cmdModifyCustomPU.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.cmdModifyCustomPU.UseVisualStyleBackColor = False
			Me.cmdNewCustomPU.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdNewCustomPU.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdNewCustomPU.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdNewCustomPU.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdNewCustomPU, "Setup Pumping Unit Equipment: Add button")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdNewCustomPU, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdNewCustomPU.Image = CType(componentResourceManager.GetObject("cmdNewCustomPU.Image"), Global.System.Drawing.Image)
			Me.cmdNewCustomPU.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdNewCustomPU As Global.System.Windows.Forms.Control = Me.cmdNewCustomPU
			location = New Global.System.Drawing.Point(16, 272)
			cmdNewCustomPU.Location = location
			Me.cmdNewCustomPU.Name = "cmdNewCustomPU"
			Me.cmdNewCustomPU.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdNewCustomPU, True)
			Dim cmdNewCustomPU2 As Global.System.Windows.Forms.Control = Me.cmdNewCustomPU
			size = New Global.System.Drawing.Size(24, 22)
			cmdNewCustomPU2.Size = size
			Me.cmdNewCustomPU.TabIndex = 85
			Me.cmdNewCustomPU.TextAlign = Global.System.Drawing.ContentAlignment.BottomCenter
			Me.cmdNewCustomPU.UseVisualStyleBackColor = False
			Me.ToolTip1.ShowAlways = True
			Me.pnlDebugOptions.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlDebugOptions.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.pnlDebugOptions.Controls.Add(Me.grpDebugOpt)
			Me.pnlDebugOptions.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlDebugOptions.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlDebugOptions.ForeColor = Global.System.Drawing.Color.Black
			Dim pnlDebugOptions As Global.System.Windows.Forms.Control = Me.pnlDebugOptions
			location = New Global.System.Drawing.Point(-1111, 15)
			pnlDebugOptions.Location = location
			Me.pnlDebugOptions.Name = "pnlDebugOptions"
			Me.pnlDebugOptions.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.pnlDebugOptions, False)
			Dim pnlDebugOptions2 As Global.System.Windows.Forms.Control = Me.pnlDebugOptions
			size = New Global.System.Drawing.Size(893, 313)
			pnlDebugOptions2.Size = size
			Me.pnlDebugOptions.TabIndex = 94
			Me.grpDebugOpt.Controls.Add(Me.CheckBox4)
			Me.grpDebugOpt.Controls.Add(Me.optNcycles_0)
			Me.grpDebugOpt.Controls.Add(Me.optNcycles_1)
			Me.grpDebugOpt.Controls.Add(Me.optNcycles_2)
			Me.grpDebugOpt.Controls.Add(Me.optNcycles_3)
			Me.grpDebugOpt.Controls.Add(Me.CheckBox5)
			Me.grpDebugOpt.Controls.Add(Me.CheckBox6)
			Me.grpDebugOpt.Controls.Add(Me.CheckBox7)
			Me.grpDebugOpt.Controls.Add(Me.CheckBox8)
			Me.grpDebugOpt.Controls.Add(Me.CheckBox9)
			Me.grpDebugOpt.Controls.Add(Me.Label2)
			Me.grpDebugOpt.Controls.Add(Me.Label3)
			Me.grpDebugOpt.Controls.Add(Me.Label4)
			Me.grpDebugOpt.Controls.Add(Me.chkDebugFixSinusoidalDyno)
			Me.grpDebugOpt.Controls.Add(Me.chkDebugTreatAsSolidLine)
			Me.grpDebugOpt.Controls.Add(Me.chkDebugNoFIReplaceGoodMatch)
			Me.grpDebugOpt.Controls.Add(Me.chkDebugShowMatchInfo)
			Me.grpDebugOpt.Controls.Add(Me.chkDebugMessages)
			Me.grpDebugOpt.Controls.Add(Me.chkDebugShowPredictInfo2)
			Dim grpDebugOpt As Global.System.Windows.Forms.Control = Me.grpDebugOpt
			location = New Global.System.Drawing.Point(16, 16)
			grpDebugOpt.Location = location
			Me.grpDebugOpt.Name = "grpDebugOpt"
			Me.HelpProvider1.SetShowHelp(Me.grpDebugOpt, False)
			Dim grpDebugOpt2 As Global.System.Windows.Forms.Control = Me.grpDebugOpt
			size = New Global.System.Drawing.Size(552, 280)
			grpDebugOpt2.Size = size
			Me.grpDebugOpt.TabIndex = 10
			Me.grpDebugOpt.TabStop = False
			Me.grpDebugOpt.Text = "Select from the following debugging options:"
			Me.CheckBox4.BackColor = Global.System.Drawing.SystemColors.Control
			Me.CheckBox4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.CheckBox4.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.CheckBox4.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.CheckBox4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim checkBox As Global.System.Windows.Forms.Control = Me.CheckBox4
			location = New Global.System.Drawing.Point(40, 32)
			checkBox.Location = location
			Me.CheckBox4.Name = "CheckBox4"
			Me.CheckBox4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.CheckBox4, False)
			Dim checkBox2 As Global.System.Windows.Forms.Control = Me.CheckBox4
			size = New Global.System.Drawing.Size(87, 17)
			checkBox2.Size = size
			Me.CheckBox4.TabIndex = 83
			Me.CheckBox4.Text = "Set &Ncycles"
			Me.CheckBox4.UseVisualStyleBackColor = False
			Me.optNcycles_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optNcycles_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optNcycles_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.optNcycles_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.optNcycles_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optNcycles_ As Global.System.Windows.Forms.Control = Me.optNcycles_0
			location = New Global.System.Drawing.Point(136, 32)
			optNcycles_.Location = location
			Me.optNcycles_0.Name = "optNcycles_0"
			Me.optNcycles_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optNcycles_0, False)
			Dim optNcycles_2 As Global.System.Windows.Forms.Control = Me.optNcycles_0
			size = New Global.System.Drawing.Size(26, 17)
			optNcycles_2.Size = size
			Me.optNcycles_0.TabIndex = 84
			Me.optNcycles_0.TabStop = True
			Me.optNcycles_0.Text = "3"
			Me.optNcycles_0.UseVisualStyleBackColor = False
			Me.optNcycles_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optNcycles_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optNcycles_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.optNcycles_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.optNcycles_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optNcycles_3 As Global.System.Windows.Forms.Control = Me.optNcycles_1
			location = New Global.System.Drawing.Point(168, 32)
			optNcycles_3.Location = location
			Me.optNcycles_1.Name = "optNcycles_1"
			Me.optNcycles_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optNcycles_1, False)
			Dim optNcycles_4 As Global.System.Windows.Forms.Control = Me.optNcycles_1
			size = New Global.System.Drawing.Size(26, 17)
			optNcycles_4.Size = size
			Me.optNcycles_1.TabIndex = 85
			Me.optNcycles_1.TabStop = True
			Me.optNcycles_1.Text = "4"
			Me.optNcycles_1.UseVisualStyleBackColor = False
			Me.optNcycles_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optNcycles_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optNcycles_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.optNcycles_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.optNcycles_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optNcycles_5 As Global.System.Windows.Forms.Control = Me.optNcycles_2
			location = New Global.System.Drawing.Point(208, 32)
			optNcycles_5.Location = location
			Me.optNcycles_2.Name = "optNcycles_2"
			Me.optNcycles_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optNcycles_2, False)
			Dim optNcycles_6 As Global.System.Windows.Forms.Control = Me.optNcycles_2
			size = New Global.System.Drawing.Size(26, 17)
			optNcycles_6.Size = size
			Me.optNcycles_2.TabIndex = 86
			Me.optNcycles_2.TabStop = True
			Me.optNcycles_2.Text = "5"
			Me.optNcycles_2.UseVisualStyleBackColor = False
			Me.optNcycles_3.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optNcycles_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optNcycles_3.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.optNcycles_3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.optNcycles_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optNcycles_7 As Global.System.Windows.Forms.Control = Me.optNcycles_3
			location = New Global.System.Drawing.Point(240, 32)
			optNcycles_7.Location = location
			Me.optNcycles_3.Name = "optNcycles_3"
			Me.optNcycles_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optNcycles_3, False)
			Dim optNcycles_8 As Global.System.Windows.Forms.Control = Me.optNcycles_3
			size = New Global.System.Drawing.Size(26, 17)
			optNcycles_8.Size = size
			Me.optNcycles_3.TabIndex = 87
			Me.optNcycles_3.TabStop = True
			Me.optNcycles_3.Text = "6"
			Me.optNcycles_3.UseVisualStyleBackColor = False
			Me.CheckBox5.BackColor = Global.System.Drawing.SystemColors.Control
			Me.CheckBox5.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.CheckBox5.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.CheckBox5.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.CheckBox5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim checkBox3 As Global.System.Windows.Forms.Control = Me.CheckBox5
			location = New Global.System.Drawing.Point(80, 144)
			checkBox3.Location = location
			Me.CheckBox5.Name = "CheckBox5"
			Me.CheckBox5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.CheckBox5, False)
			Dim checkBox4 As Global.System.Windows.Forms.Control = Me.CheckBox5
			size = New Global.System.Drawing.Size(42, 17)
			checkBox4.Size = size
			Me.CheckBox5.TabIndex = 93
			Me.CheckBox5.Text = "DYN"
			Me.CheckBox5.UseVisualStyleBackColor = False
			Me.CheckBox6.BackColor = Global.System.Drawing.SystemColors.Control
			Me.CheckBox6.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.CheckBox6.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.CheckBox6.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.CheckBox6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim checkBox5 As Global.System.Windows.Forms.Control = Me.CheckBox6
			location = New Global.System.Drawing.Point(40, 104)
			checkBox5.Location = location
			Me.CheckBox6.Name = "CheckBox6"
			Me.CheckBox6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.CheckBox6, False)
			Dim checkBox6 As Global.System.Windows.Forms.Control = Me.CheckBox6
			size = New Global.System.Drawing.Size(233, 17)
			checkBox6.Size = size
			Me.CheckBox6.TabIndex = 90
			Me.CheckBox6.Text = "Show bal. min. torque and min. energy"
			Me.CheckBox6.UseVisualStyleBackColor = False
			Me.CheckBox7.BackColor = Global.System.Drawing.SystemColors.Control
			Me.CheckBox7.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.CheckBox7.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.CheckBox7.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.CheckBox7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim checkBox7 As Global.System.Windows.Forms.Control = Me.CheckBox7
			location = New Global.System.Drawing.Point(120, 144)
			checkBox7.Location = location
			Me.CheckBox7.Name = "CheckBox7"
			Me.CheckBox7.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.CheckBox7, False)
			Dim checkBox8 As Global.System.Windows.Forms.Control = Me.CheckBox7
			size = New Global.System.Drawing.Size(32, 17)
			checkBox8.Size = size
			Me.CheckBox7.TabIndex = 94
			Me.CheckBox7.Text = "TF"
			Me.CheckBox7.UseVisualStyleBackColor = False
			Me.CheckBox8.BackColor = Global.System.Drawing.SystemColors.Control
			Me.CheckBox8.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.CheckBox8.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.CheckBox8.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.CheckBox8.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim checkBox9 As Global.System.Windows.Forms.Control = Me.CheckBox8
			location = New Global.System.Drawing.Point(152, 144)
			checkBox9.Location = location
			Me.CheckBox8.Name = "CheckBox8"
			Me.CheckBox8.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.CheckBox8, False)
			Dim checkBox10 As Global.System.Windows.Forms.Control = Me.CheckBox8
			size = New Global.System.Drawing.Size(34, 17)
			checkBox10.Size = size
			Me.CheckBox8.TabIndex = 95
			Me.CheckBox8.Text = "TQ"
			Me.CheckBox8.UseVisualStyleBackColor = False
			Me.CheckBox9.BackColor = Global.System.Drawing.SystemColors.Control
			Me.CheckBox9.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.CheckBox9.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.CheckBox9.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.CheckBox9.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim checkBox11 As Global.System.Windows.Forms.Control = Me.CheckBox9
			location = New Global.System.Drawing.Point(192, 144)
			checkBox11.Location = location
			Me.CheckBox9.Name = "CheckBox9"
			Me.CheckBox9.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.CheckBox9, False)
			Dim checkBox12 As Global.System.Windows.Forms.Control = Me.CheckBox9
			size = New Global.System.Drawing.Size(40, 17)
			checkBox12.Size = size
			Me.CheckBox9.TabIndex = 96
			Me.CheckBox9.Text = "DPC"
			Me.CheckBox9.UseVisualStyleBackColor = False
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.Label2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(40, 128)
			label3.Location = location
			Me.Label2.Name = "Label2"
			Me.Label2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label2, False)
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(46, 14)
			label4.Size = size
			Me.Label2.TabIndex = 91
			Me.Label2.Text = "IMPRED:"
			Me.Label3.AutoSize = True
			Me.Label3.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label3.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.Label3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(40, 144)
			label5.Location = location
			Me.Label3.Name = "Label3"
			Me.Label3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label3, False)
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(39, 14)
			label6.Size = size
			Me.Label3.TabIndex = 92
			Me.Label3.Text = "Create"
			Me.Label4.AutoSize = True
			Me.Label4.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label4.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.Label4.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Label4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
			location = New Global.System.Drawing.Point(232, 144)
			label7.Location = location
			Me.Label4.Name = "Label4"
			Me.Label4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Label4, False)
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(27, 14)
			label8.Size = size
			Me.Label4.TabIndex = 97
			Me.Label4.Text = "files"
			Me.chkDebugFixSinusoidalDyno.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugFixSinusoidalDyno As Global.System.Windows.Forms.Control = Me.chkDebugFixSinusoidalDyno
			location = New Global.System.Drawing.Point(40, 240)
			chkDebugFixSinusoidalDyno.Location = location
			Me.chkDebugFixSinusoidalDyno.Name = "chkDebugFixSinusoidalDyno"
			Me.HelpProvider1.SetShowHelp(Me.chkDebugFixSinusoidalDyno, False)
			Dim chkDebugFixSinusoidalDyno2 As Global.System.Windows.Forms.Control = Me.chkDebugFixSinusoidalDyno
			size = New Global.System.Drawing.Size(184, 16)
			chkDebugFixSinusoidalDyno2.Size = size
			Me.chkDebugFixSinusoidalDyno.TabIndex = 19
			Me.chkDebugFixSinusoidalDyno.Text = "Replace sinusoidal surface dyno"
			Me.chkDebugFixSinusoidalDyno.Visible = False
			Me.chkDebugTreatAsSolidLine.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugTreatAsSolidLine As Global.System.Windows.Forms.Control = Me.chkDebugTreatAsSolidLine
			location = New Global.System.Drawing.Point(40, 216)
			chkDebugTreatAsSolidLine.Location = location
			Me.chkDebugTreatAsSolidLine.Name = "chkDebugTreatAsSolidLine"
			Me.HelpProvider1.SetShowHelp(Me.chkDebugTreatAsSolidLine, False)
			Dim chkDebugTreatAsSolidLine2 As Global.System.Windows.Forms.Control = Me.chkDebugTreatAsSolidLine
			size = New Global.System.Drawing.Size(184, 16)
			chkDebugTreatAsSolidLine2.Size = size
			Me.chkDebugTreatAsSolidLine.TabIndex = 18
			Me.chkDebugTreatAsSolidLine.Text = "Treat surface dyno as solid line"
			Me.chkDebugTreatAsSolidLine.Visible = False
			Me.chkDebugNoFIReplaceGoodMatch.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugNoFIReplaceGoodMatch As Global.System.Windows.Forms.Control = Me.chkDebugNoFIReplaceGoodMatch
			location = New Global.System.Drawing.Point(40, 192)
			chkDebugNoFIReplaceGoodMatch.Location = location
			Me.chkDebugNoFIReplaceGoodMatch.Name = "chkDebugNoFIReplaceGoodMatch"
			Me.HelpProvider1.SetShowHelp(Me.chkDebugNoFIReplaceGoodMatch, False)
			Dim chkDebugNoFIReplaceGoodMatch2 As Global.System.Windows.Forms.Control = Me.chkDebugNoFIReplaceGoodMatch
			size = New Global.System.Drawing.Size(192, 16)
			chkDebugNoFIReplaceGoodMatch2.Size = size
			Me.chkDebugNoFIReplaceGoodMatch.TabIndex = 17
			Me.chkDebugNoFIReplaceGoodMatch.Text = "FI < 90% doesn't replace score > 95%"
			Me.chkDebugNoFIReplaceGoodMatch.Visible = False
			Me.chkDebugShowMatchInfo.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugShowMatchInfo As Global.System.Windows.Forms.Control = Me.chkDebugShowMatchInfo
			location = New Global.System.Drawing.Point(40, 168)
			chkDebugShowMatchInfo.Location = location
			Me.chkDebugShowMatchInfo.Name = "chkDebugShowMatchInfo"
			Me.HelpProvider1.SetShowHelp(Me.chkDebugShowMatchInfo, False)
			Dim chkDebugShowMatchInfo2 As Global.System.Windows.Forms.Control = Me.chkDebugShowMatchInfo
			size = New Global.System.Drawing.Size(184, 16)
			chkDebugShowMatchInfo2.Size = size
			Me.chkDebugShowMatchInfo.TabIndex = 16
			Me.chkDebugShowMatchInfo.Text = "Show match information"
			Me.chkDebugShowMatchInfo.Visible = False
			Me.chkDebugMessages.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugMessages As Global.System.Windows.Forms.Control = Me.chkDebugMessages
			location = New Global.System.Drawing.Point(40, 56)
			chkDebugMessages.Location = location
			Me.chkDebugMessages.Name = "chkDebugMessages"
			Me.HelpProvider1.SetShowHelp(Me.chkDebugMessages, False)
			Dim chkDebugMessages2 As Global.System.Windows.Forms.Control = Me.chkDebugMessages
			size = New Global.System.Drawing.Size(184, 16)
			chkDebugMessages2.Size = size
			Me.chkDebugMessages.TabIndex = 15
			Me.chkDebugMessages.Text = "Show debug messages"
			Me.chkDebugShowPredictInfo2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDebugShowPredictInfo3 As Global.System.Windows.Forms.Control = Me.chkDebugShowPredictInfo2
			location = New Global.System.Drawing.Point(40, 80)
			chkDebugShowPredictInfo3.Location = location
			Me.chkDebugShowPredictInfo2.Name = "chkDebugShowPredictInfo2"
			Me.HelpProvider1.SetShowHelp(Me.chkDebugShowPredictInfo2, False)
			Dim chkDebugShowPredictInfo4 As Global.System.Windows.Forms.Control = Me.chkDebugShowPredictInfo2
			size = New Global.System.Drawing.Size(184, 16)
			chkDebugShowPredictInfo4.Size = size
			Me.chkDebugShowPredictInfo2.TabIndex = 14
			Me.chkDebugShowPredictInfo2.Text = "Save PREDICT information"
			Me.pnlSetupCostDB.BackColor = Global.System.Drawing.SystemColors.Control
			Me.pnlSetupCostDB.Controls.Add(Me.panContainer)
			Me.pnlSetupCostDB.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.pnlSetupCostDB.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.pnlSetupCostDB.ForeColor = Global.System.Drawing.Color.Black
			Dim pnlSetupCostDB As Global.System.Windows.Forms.Control = Me.pnlSetupCostDB
			location = New Global.System.Drawing.Point(-1333, 16)
			pnlSetupCostDB.Location = location
			Me.pnlSetupCostDB.Name = "pnlSetupCostDB"
			Me.pnlSetupCostDB.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.pnlSetupCostDB, False)
			Dim pnlSetupCostDB2 As Global.System.Windows.Forms.Control = Me.pnlSetupCostDB
			size = New Global.System.Drawing.Size(641, 389)
			pnlSetupCostDB2.Size = size
			Me.pnlSetupCostDB.TabIndex = 95
			Me.pnlSetupCostDB.TabStop = True
			Me.panContainer.BackColor = Global.System.Drawing.SystemColors.Control
			Me.panContainer.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panContainer.Controls.Add(Me._optCostCategory_2)
			Me.panContainer.Controls.Add(Me._optCostCategory_0)
			Me.panContainer.Controls.Add(Me._optCostCategory_1)
			Me.panContainer.Controls.Add(Me._Line_0)
			Me.panContainer.Controls.Add(Me._Line_1)
			Me.panContainer.Controls.Add(Me._panCostCategory_1)
			Me.panContainer.Controls.Add(Me._panCostCategory_0)
			Me.panContainer.Controls.Add(Me.pnlPUCostDB)
			Me.panContainer.Controls.Add(Me.pnlGuideCostDB)
			Me.panContainer.Controls.Add(Me.pnlRSCostDB)
			Me.panContainer.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.panContainer.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.panContainer.ForeColor = Global.System.Drawing.Color.Black
			Dim panContainer As Global.System.Windows.Forms.Control = Me.panContainer
			location = New Global.System.Drawing.Point(8, 8)
			panContainer.Location = location
			Me.panContainer.Name = "panContainer"
			Me.panContainer.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.panContainer, False)
			Dim panContainer2 As Global.System.Windows.Forms.Control = Me.panContainer
			size = New Global.System.Drawing.Size(589, 376)
			panContainer2.Size = size
			Me.panContainer.TabIndex = 13
			Me.panContainer.TabStop = True
			Me._optCostCategory_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optCostCategory_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optCostCategory_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optCostCategory_2.ForeColor = Global.System.Drawing.Color.Black
			Me.HelpProvider1.SetHelpKeyword(Me._optCostCategory_2, "Setup Cost Database Window Rods")
			Me.HelpProvider1.SetHelpNavigator(Me._optCostCategory_2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optCostCategory_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCostCategory_ As Global.System.Windows.Forms.Control = Me._optCostCategory_2
			location = New Global.System.Drawing.Point(8, 49)
			optCostCategory_.Location = location
			Me._optCostCategory_2.Name = "_optCostCategory_2"
			Me._optCostCategory_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optCostCategory_2, True)
			Dim optCostCategory_2 As Global.System.Windows.Forms.Control = Me._optCostCategory_2
			size = New Global.System.Drawing.Size(216, 17)
			optCostCategory_2.Size = size
			Me._optCostCategory_2.TabIndex = 32
			Me._optCostCategory_2.TabStop = True
			Me._optCostCategory_2.Tag = ""
			Me._optCostCategory_2.Text = "Guide costs"
			Me._optCostCategory_2.UseVisualStyleBackColor = False
			Me._optCostCategory_2.Visible = False
			Me._optCostCategory_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optCostCategory_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optCostCategory_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optCostCategory_0.ForeColor = Global.System.Drawing.Color.Black
			Me.HelpProvider1.SetHelpKeyword(Me._optCostCategory_0, "Setup Cost Database Window")
			Me.HelpProvider1.SetHelpNavigator(Me._optCostCategory_0, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optCostCategory_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCostCategory_3 As Global.System.Windows.Forms.Control = Me._optCostCategory_0
			location = New Global.System.Drawing.Point(8, 9)
			optCostCategory_3.Location = location
			Me._optCostCategory_0.Name = "_optCostCategory_0"
			Me._optCostCategory_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optCostCategory_0, True)
			Dim optCostCategory_4 As Global.System.Windows.Forms.Control = Me._optCostCategory_0
			size = New Global.System.Drawing.Size(216, 19)
			optCostCategory_4.Size = size
			Me._optCostCategory_0.TabIndex = 0
			Me._optCostCategory_0.TabStop = True
			Me._optCostCategory_0.Text = "Pumping unit costs"
			Me._optCostCategory_0.UseVisualStyleBackColor = False
			Me._optCostCategory_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optCostCategory_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optCostCategory_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optCostCategory_1.ForeColor = Global.System.Drawing.Color.Black
			Me.HelpProvider1.SetHelpKeyword(Me._optCostCategory_1, "Setup Cost Database Window Rods")
			Me.HelpProvider1.SetHelpNavigator(Me._optCostCategory_1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me._optCostCategory_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optCostCategory_5 As Global.System.Windows.Forms.Control = Me._optCostCategory_1
			location = New Global.System.Drawing.Point(8, 29)
			optCostCategory_5.Location = location
			Me._optCostCategory_1.Name = "_optCostCategory_1"
			Me._optCostCategory_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._optCostCategory_1, True)
			Dim optCostCategory_6 As Global.System.Windows.Forms.Control = Me._optCostCategory_1
			size = New Global.System.Drawing.Size(216, 17)
			optCostCategory_6.Size = size
			Me._optCostCategory_1.TabIndex = 1
			Me._optCostCategory_1.TabStop = True
			Me._optCostCategory_1.Tag = "d"
			Me._optCostCategory_1.Text = "Rod string costs"
			Me._optCostCategory_1.UseVisualStyleBackColor = False
			Me._Line_0.BackColor = Global.System.Drawing.SystemColors.ControlDark
			Me._Line_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim line_ As Global.System.Windows.Forms.Control = Me._Line_0
			location = New Global.System.Drawing.Point(329, 17)
			line_.Location = location
			Me._Line_0.Name = "_Line_0"
			Me.HelpProvider1.SetShowHelp(Me._Line_0, False)
			Dim line_2 As Global.System.Windows.Forms.Control = Me._Line_0
			size = New Global.System.Drawing.Size(1, 298)
			line_2.Size = size
			Me._Line_0.TabIndex = 25
			Me._Line_1.BackColor = Global.System.Drawing.Color.White
			Me._Line_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim line_3 As Global.System.Windows.Forms.Control = Me._Line_1
			location = New Global.System.Drawing.Point(330, 17)
			line_3.Location = location
			Me._Line_1.Name = "_Line_1"
			Me.HelpProvider1.SetShowHelp(Me._Line_1, False)
			Dim line_4 As Global.System.Windows.Forms.Control = Me._Line_1
			size = New Global.System.Drawing.Size(1, 298)
			line_4.Size = size
			Me._Line_1.TabIndex = 26
			Me._panCostCategory_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me._panCostCategory_1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._panCostCategory_1.Controls.Add(Me.cboRodGrade)
			Me._panCostCategory_1.Controls.Add(Me.cboRodType)
			Me._panCostCategory_1.Controls.Add(Me.cmdRSLoadCostDB)
			Me._panCostCategory_1.Controls.Add(Me._Label_3)
			Me._panCostCategory_1.Controls.Add(Me._Label_4)
			Me._panCostCategory_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panCostCategory_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panCostCategory_1.ForeColor = Global.System.Drawing.Color.Black
			Dim panCostCategory_ As Global.System.Windows.Forms.Control = Me._panCostCategory_1
			location = New Global.System.Drawing.Point(344, 8)
			panCostCategory_.Location = location
			Me._panCostCategory_1.Name = "_panCostCategory_1"
			Me._panCostCategory_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panCostCategory_1, False)
			Dim panCostCategory_2 As Global.System.Windows.Forms.Control = Me._panCostCategory_1
			size = New Global.System.Drawing.Size(200, 147)
			panCostCategory_2.Size = size
			Me._panCostCategory_1.TabIndex = 17
			Me._panCostCategory_1.TabStop = True
			Me._panCostCategory_1.Visible = False
			Me.cboRodGrade.AllowDrop = True
			Me.cboRodGrade.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboRodGrade.DropDownWidth = 200
			Me.cboRodGrade.Enabled = False
			Me.cboRodGrade.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.HelpProvider1.SetHelpKeyword(Me.cboRodGrade, "Cost Database Rod Grade or Manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRodGrade, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRodGrade.ItemHeight = 14
			Dim cboRodGrade As Global.System.Windows.Forms.Control = Me.cboRodGrade
			location = New Global.System.Drawing.Point(7, 80)
			cboRodGrade.Location = location
			Me.cboRodGrade.MaxDropDownItems = 30
			Me.cboRodGrade.MaxLength = 100
			Me.cboRodGrade.Name = "cboRodGrade"
			Me.HelpProvider1.SetShowHelp(Me.cboRodGrade, True)
			Dim cboRodGrade2 As Global.System.Windows.Forms.Control = Me.cboRodGrade
			size = New Global.System.Drawing.Size(185, 22)
			cboRodGrade2.Size = size
			Me.cboRodGrade.TabIndex = 188
			Me.cboRodType.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboRodType.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboRodType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboRodType.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboRodType.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboRodType, "Cost Database Rod Type or Material")
			Me.HelpProvider1.SetHelpNavigator(Me.cboRodType, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboRodType.ItemHeight = 14
			Dim cboRodType As Global.System.Windows.Forms.Control = Me.cboRodType
			location = New Global.System.Drawing.Point(7, 32)
			cboRodType.Location = location
			Me.cboRodType.Name = "cboRodType"
			Me.cboRodType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboRodType, True)
			Dim cboRodType2 As Global.System.Windows.Forms.Control = Me.cboRodType
			size = New Global.System.Drawing.Size(185, 22)
			cboRodType2.Size = size
			Me.cboRodType.TabIndex = 25
			Me.cmdRSLoadCostDB.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdRSLoadCostDB.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdRSLoadCostDB.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdRSLoadCostDB.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdRSLoadCostDB.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdRSLoadCostDB As Global.System.Windows.Forms.Control = Me.cmdRSLoadCostDB
			location = New Global.System.Drawing.Point(173, 5)
			cmdRSLoadCostDB.Location = location
			Me.cmdRSLoadCostDB.Name = "cmdRSLoadCostDB"
			Me.cmdRSLoadCostDB.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdRSLoadCostDB, False)
			Dim cmdRSLoadCostDB2 As Global.System.Windows.Forms.Control = Me.cmdRSLoadCostDB
			size = New Global.System.Drawing.Size(19, 13)
			cmdRSLoadCostDB2.Size = size
			Me.cmdRSLoadCostDB.TabIndex = 20
			Me.cmdRSLoadCostDB.TabStop = False
			Me.cmdRSLoadCostDB.UseVisualStyleBackColor = False
			Me.cmdRSLoadCostDB.Visible = False
			Me._Label_3.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_3.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_3.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_9 As Global.System.Windows.Forms.Control = Me._Label_3
			location = New Global.System.Drawing.Point(4, 16)
			label_9.Location = location
			Me._Label_3.Name = "_Label_3"
			Me._Label_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_3, False)
			Dim label_10 As Global.System.Windows.Forms.Control = Me._Label_3
			size = New Global.System.Drawing.Size(119, 13)
			label_10.Size = size
			Me._Label_3.TabIndex = 23
			Me._Label_3.Text = "Rod type or material:"
			Me._Label_4.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_4.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_4.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_11 As Global.System.Windows.Forms.Control = Me._Label_4
			location = New Global.System.Drawing.Point(4, 64)
			label_11.Location = location
			Me._Label_4.Name = "_Label_4"
			Me._Label_4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_4, False)
			Dim label_12 As Global.System.Windows.Forms.Control = Me._Label_4
			size = New Global.System.Drawing.Size(159, 15)
			label_12.Size = size
			Me._Label_4.TabIndex = 22
			Me._Label_4.Text = "Rod grade or manufacturer:"
			Me._panCostCategory_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._panCostCategory_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._panCostCategory_0.Controls.Add(Me.lblAPIDesignation)
			Me._panCostCategory_0.Controls.Add(Me.lblUnitName)
			Me._panCostCategory_0.Controls.Add(Me.lblOtherInfo)
			Me._panCostCategory_0.Controls.Add(Me.cboPUManuf)
			Me._panCostCategory_0.Controls.Add(Me.cmdPULoadCostDB)
			Me._panCostCategory_0.Controls.Add(Me._Label_6)
			Me._panCostCategory_0.Controls.Add(Me._Label_7)
			Me._panCostCategory_0.Controls.Add(Me._Label_8)
			Me._panCostCategory_0.Controls.Add(Me._Label_9)
			Me._panCostCategory_0.Controls.Add(Me.Button1)
			Me._panCostCategory_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panCostCategory_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panCostCategory_0.ForeColor = Global.System.Drawing.Color.Black
			Dim panCostCategory_3 As Global.System.Windows.Forms.Control = Me._panCostCategory_0
			location = New Global.System.Drawing.Point(344, 8)
			panCostCategory_3.Location = location
			Me._panCostCategory_0.Name = "_panCostCategory_0"
			Me._panCostCategory_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panCostCategory_0, False)
			Dim panCostCategory_4 As Global.System.Windows.Forms.Control = Me._panCostCategory_0
			size = New Global.System.Drawing.Size(224, 224)
			panCostCategory_4.Size = size
			Me._panCostCategory_0.TabIndex = 24
			Me._panCostCategory_0.TabStop = True
			Me._panCostCategory_0.Visible = False
			Me.lblAPIDesignation.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.HelpProvider1.SetHelpKeyword(Me.lblAPIDesignation, "Cost Database API Designation")
			Me.HelpProvider1.SetHelpNavigator(Me.lblAPIDesignation, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.lblAPIDesignation.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblAPIDesignation As Global.System.Windows.Forms.Control = Me.lblAPIDesignation
			location = New Global.System.Drawing.Point(4, 72)
			lblAPIDesignation.Location = location
			Me.lblAPIDesignation.Name = "lblAPIDesignation"
			Me.HelpProvider1.SetShowHelp(Me.lblAPIDesignation, True)
			Dim lblAPIDesignation2 As Global.System.Windows.Forms.Control = Me.lblAPIDesignation
			size = New Global.System.Drawing.Size(212, 24)
			lblAPIDesignation2.Size = size
			Me.lblAPIDesignation.TabIndex = 29
			Me.lblUnitName.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.HelpProvider1.SetHelpKeyword(Me.lblUnitName, "Cost Database Unit Name")
			Me.HelpProvider1.SetHelpNavigator(Me.lblUnitName, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.lblUnitName.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblUnitName As Global.System.Windows.Forms.Control = Me.lblUnitName
			location = New Global.System.Drawing.Point(4, 112)
			lblUnitName.Location = location
			Me.lblUnitName.Name = "lblUnitName"
			Me.HelpProvider1.SetShowHelp(Me.lblUnitName, True)
			Dim lblUnitName2 As Global.System.Windows.Forms.Control = Me.lblUnitName
			size = New Global.System.Drawing.Size(212, 24)
			lblUnitName2.Size = size
			Me.lblUnitName.TabIndex = 28
			Me.lblOtherInfo.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.HelpProvider1.SetHelpKeyword(Me.lblOtherInfo, "Cost Database Other Information")
			Me.HelpProvider1.SetHelpNavigator(Me.lblOtherInfo, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.lblOtherInfo.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblOtherInfo As Global.System.Windows.Forms.Control = Me.lblOtherInfo
			location = New Global.System.Drawing.Point(4, 160)
			lblOtherInfo.Location = location
			Me.lblOtherInfo.Name = "lblOtherInfo"
			Me.HelpProvider1.SetShowHelp(Me.lblOtherInfo, True)
			Dim lblOtherInfo2 As Global.System.Windows.Forms.Control = Me.lblOtherInfo
			size = New Global.System.Drawing.Size(212, 24)
			lblOtherInfo2.Size = size
			Me.lblOtherInfo.TabIndex = 27
			Me.cboPUManuf.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboPUManuf.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboPUManuf.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboPUManuf.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboPUManuf.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboPUManuf, "Cost Database Pumping Unit Manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboPUManuf, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboPUManuf.ItemHeight = 14
			Dim cboPUManuf As Global.System.Windows.Forms.Control = Me.cboPUManuf
			location = New Global.System.Drawing.Point(6, 32)
			cboPUManuf.Location = location
			Me.cboPUManuf.Name = "cboPUManuf"
			Me.cboPUManuf.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboPUManuf, True)
			Dim cboPUManuf2 As Global.System.Windows.Forms.Control = Me.cboPUManuf
			size = New Global.System.Drawing.Size(212, 22)
			cboPUManuf2.Size = size
			Me.cboPUManuf.TabIndex = 26
			Me.cmdPULoadCostDB.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdPULoadCostDB.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdPULoadCostDB.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdPULoadCostDB.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdPULoadCostDB.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdPULoadCostDB As Global.System.Windows.Forms.Control = Me.cmdPULoadCostDB
			location = New Global.System.Drawing.Point(200, 6)
			cmdPULoadCostDB.Location = location
			Me.cmdPULoadCostDB.Name = "cmdPULoadCostDB"
			Me.cmdPULoadCostDB.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdPULoadCostDB, False)
			Dim cmdPULoadCostDB2 As Global.System.Windows.Forms.Control = Me.cmdPULoadCostDB
			size = New Global.System.Drawing.Size(19, 13)
			cmdPULoadCostDB2.Size = size
			Me.cmdPULoadCostDB.TabIndex = 6
			Me.cmdPULoadCostDB.TabStop = False
			Me.cmdPULoadCostDB.UseVisualStyleBackColor = False
			Me.cmdPULoadCostDB.Visible = False
			Me._Label_6.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_6.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_6.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_6.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_13 As Global.System.Windows.Forms.Control = Me._Label_6
			location = New Global.System.Drawing.Point(4, 16)
			label_13.Location = location
			Me._Label_6.Name = "_Label_6"
			Me._Label_6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_6, False)
			Dim label_14 As Global.System.Windows.Forms.Control = Me._Label_6
			size = New Global.System.Drawing.Size(156, 13)
			label_14.Size = size
			Me._Label_6.TabIndex = 10
			Me._Label_6.Text = "Pumping unit manufacturer:"
			Me._Label_7.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_7.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_7.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_7.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_15 As Global.System.Windows.Forms.Control = Me._Label_7
			location = New Global.System.Drawing.Point(4, 58)
			label_15.Location = location
			Me._Label_7.Name = "_Label_7"
			Me._Label_7.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_7, False)
			Dim label_16 As Global.System.Windows.Forms.Control = Me._Label_7
			size = New Global.System.Drawing.Size(94, 13)
			label_16.Size = size
			Me._Label_7.TabIndex = 11
			Me._Label_7.Text = "API designation:"
			Me._Label_8.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_8.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_8.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_8.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_8.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_17 As Global.System.Windows.Forms.Control = Me._Label_8
			location = New Global.System.Drawing.Point(5, 100)
			label_17.Location = location
			Me._Label_8.Name = "_Label_8"
			Me._Label_8.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_8, False)
			Dim label_18 As Global.System.Windows.Forms.Control = Me._Label_8
			size = New Global.System.Drawing.Size(62, 13)
			label_18.Size = size
			Me._Label_8.TabIndex = 14
			Me._Label_8.Text = "Unit name:"
			Me._Label_9.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_9.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_9.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_9.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_9.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_19 As Global.System.Windows.Forms.Control = Me._Label_9
			location = New Global.System.Drawing.Point(4, 142)
			label_19.Location = location
			Me._Label_9.Name = "_Label_9"
			Me._Label_9.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_9, False)
			Dim label_20 As Global.System.Windows.Forms.Control = Me._Label_9
			size = New Global.System.Drawing.Size(102, 13)
			label_20.Size = size
			Me._Label_9.TabIndex = 15
			Me._Label_9.Text = "Other information:"
			Me.Button1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Button1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.Button1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.Button1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(104, 192)
			button.Location = location
			Me.Button1.Name = "Button1"
			Me.Button1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.Button1, False)
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(109, 20)
			button2.Size = size
			Me.Button1.TabIndex = 21
			Me.Button1.Text = "Check data (hidden)"
			Me.Button1.UseVisualStyleBackColor = False
			Me.Button1.Visible = False
			Me.pnlPUCostDB.Controls.Add(Me.ulgPUCostDB)
			Dim pnlPUCostDB As Global.System.Windows.Forms.Control = Me.pnlPUCostDB
			location = New Global.System.Drawing.Point(8, 72)
			pnlPUCostDB.Location = location
			Me.pnlPUCostDB.Name = "pnlPUCostDB"
			Me.HelpProvider1.SetShowHelp(Me.pnlPUCostDB, False)
			Dim pnlPUCostDB2 As Global.System.Windows.Forms.Control = Me.pnlPUCostDB
			size = New Global.System.Drawing.Size(308, 292)
			pnlPUCostDB2.Size = size
			Me.pnlPUCostDB.TabIndex = 28
			Me.ulgPUCostDB.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.ulgPUCostDB, "Cost Database Pumping Unit List")
			Me.HelpProvider1.SetHelpNavigator(Me.ulgPUCostDB, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim ulgPUCostDB As Global.System.Windows.Forms.Control = Me.ulgPUCostDB
			location = New Global.System.Drawing.Point(4, 8)
			ulgPUCostDB.Location = location
			Me.ulgPUCostDB.Name = "ulgPUCostDB"
			Me.HelpProvider1.SetShowHelp(Me.ulgPUCostDB, True)
			Dim ulgPUCostDB2 As Global.System.Windows.Forms.Control = Me.ulgPUCostDB
			size = New Global.System.Drawing.Size(296, 273)
			ulgPUCostDB2.Size = size
			Me.ulgPUCostDB.TabIndex = 28
			Me.pnlGuideCostDB.Controls.Add(Me.ulgGuideCostDB)
			Dim pnlGuideCostDB As Global.System.Windows.Forms.Control = Me.pnlGuideCostDB
			location = New Global.System.Drawing.Point(8, 72)
			pnlGuideCostDB.Location = location
			Me.pnlGuideCostDB.Name = "pnlGuideCostDB"
			Me.HelpProvider1.SetShowHelp(Me.pnlGuideCostDB, False)
			Dim pnlGuideCostDB2 As Global.System.Windows.Forms.Control = Me.pnlGuideCostDB
			size = New Global.System.Drawing.Size(308, 292)
			pnlGuideCostDB2.Size = size
			Me.pnlGuideCostDB.TabIndex = 31
			Me.pnlGuideCostDB.Visible = False
			Me.ulgGuideCostDB.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.ulgGuideCostDB, "Cost Database Diameter List")
			Me.HelpProvider1.SetHelpNavigator(Me.ulgGuideCostDB, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim ulgGuideCostDB As Global.System.Windows.Forms.Control = Me.ulgGuideCostDB
			location = New Global.System.Drawing.Point(8, 8)
			ulgGuideCostDB.Location = location
			Me.ulgGuideCostDB.Name = "ulgGuideCostDB"
			Me.HelpProvider1.SetShowHelp(Me.ulgGuideCostDB, True)
			Dim ulgGuideCostDB2 As Global.System.Windows.Forms.Control = Me.ulgGuideCostDB
			size = New Global.System.Drawing.Size(292, 275)
			ulgGuideCostDB2.Size = size
			Me.ulgGuideCostDB.TabIndex = 28
			Me.pnlRSCostDB.Controls.Add(Me.ulgRSCostDB)
			Dim pnlRSCostDB As Global.System.Windows.Forms.Control = Me.pnlRSCostDB
			location = New Global.System.Drawing.Point(8, 72)
			pnlRSCostDB.Location = location
			Me.pnlRSCostDB.Name = "pnlRSCostDB"
			Me.HelpProvider1.SetShowHelp(Me.pnlRSCostDB, False)
			Dim pnlRSCostDB2 As Global.System.Windows.Forms.Control = Me.pnlRSCostDB
			size = New Global.System.Drawing.Size(308, 292)
			pnlRSCostDB2.Size = size
			Me.pnlRSCostDB.TabIndex = 29
			Me.ulgRSCostDB.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.HelpProvider1.SetHelpKeyword(Me.ulgRSCostDB, "Cost Database Diameter List")
			Me.HelpProvider1.SetHelpNavigator(Me.ulgRSCostDB, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim ulgRSCostDB As Global.System.Windows.Forms.Control = Me.ulgRSCostDB
			location = New Global.System.Drawing.Point(8, 8)
			ulgRSCostDB.Location = location
			Me.ulgRSCostDB.Name = "ulgRSCostDB"
			Me.HelpProvider1.SetShowHelp(Me.ulgRSCostDB, True)
			Dim ulgRSCostDB2 As Global.System.Windows.Forms.Control = Me.ulgRSCostDB
			size = New Global.System.Drawing.Size(292, 275)
			ulgRSCostDB2.Size = size
			Me.ulgRSCostDB.TabIndex = 28
			Me.pnlExpert.Controls.Add(Me.grpTubingSizePreferences)
			Me.pnlExpert.Controls.Add(Me.grpRodPreferences)
			Me.pnlExpert.Controls.Add(Me.lblStatus)
			Me.pnlExpert.Controls.Add(Me.grpMotorPreferences)
			Me.pnlExpert.Controls.Add(Me.grpRodTubingFricCoeffPref)
			Me.pnlExpert.Controls.Add(Me.grpPumpTypePreference)
			Me.pnlExpert.Controls.Add(Me.grpTubingAnchoredPreference)
			Me.pnlExpert.Controls.Add(Me.grpPumpUnitManufacturer_Preferences)
			Dim pnlExpert As Global.System.Windows.Forms.Control = Me.pnlExpert
			location = New Global.System.Drawing.Point(222, 2)
			pnlExpert.Location = location
			Me.pnlExpert.Name = "pnlExpert"
			Me.HelpProvider1.SetShowHelp(Me.pnlExpert, False)
			Dim pnlExpert2 As Global.System.Windows.Forms.Control = Me.pnlExpert
			size = New Global.System.Drawing.Size(705, 634)
			pnlExpert2.Size = size
			Me.pnlExpert.TabIndex = 96
			Me.grpTubingSizePreferences.Controls.Add(Me.chkFixTubingSize)
			Me.grpTubingSizePreferences.Controls.Add(Me.lblCasingSize)
			Me.grpTubingSizePreferences.Controls.Add(Me.txtCasingSize)
			Me.grpTubingSizePreferences.Controls.Add(Me._Label_CasingSizeOD)
			Me.grpTubingSizePreferences.Controls.Add(Me.chkRodstarTubingSizeRec)
			Me.grpTubingSizePreferences.Controls.Add(Me._Label_MaxTubingSizeID)
			Me.grpTubingSizePreferences.Controls.Add(Me._Label_MinTubingSizeID)
			Me.grpTubingSizePreferences.Controls.Add(Me.txtMaxTubingSizeID)
			Me.grpTubingSizePreferences.Controls.Add(Me.txtMinTubingSizeID)
			Me.grpTubingSizePreferences.Controls.Add(Me.txtMinTubingSizeOD)
			Me.grpTubingSizePreferences.Controls.Add(Me.txtMaxTubingSizeOD)
			Me.grpTubingSizePreferences.Controls.Add(Me._Label_MinTubingSizeOD)
			Me.grpTubingSizePreferences.Controls.Add(Me.cboMinTubingSizeOD)
			Me.grpTubingSizePreferences.Controls.Add(Me.lblcboMinTubingSizeOD_Disabled)
			Me.grpTubingSizePreferences.Controls.Add(Me._Label_MaxTubingSizeOD)
			Me.grpTubingSizePreferences.Controls.Add(Me.cboCasingSize)
			Me.grpTubingSizePreferences.Controls.Add(Me.cboMaxTubingSizeOD)
			Me.grpTubingSizePreferences.Controls.Add(Me.lblcboMaxTubingSizeOD_Disabled)
			Me.grpTubingSizePreferences.Controls.Add(Me.lblcboCasingSize_Disabled)
			Me.grpTubingSizePreferences.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim grpTubingSizePreferences As Global.System.Windows.Forms.Control = Me.grpTubingSizePreferences
			location = New Global.System.Drawing.Point(2, 150)
			grpTubingSizePreferences.Location = location
			Me.grpTubingSizePreferences.Name = "grpTubingSizePreferences"
			Dim grpTubingSizePreferences2 As Global.System.Windows.Forms.Control = Me.grpTubingSizePreferences
			size = New Global.System.Drawing.Size(698, 72)
			grpTubingSizePreferences2.Size = size
			Me.grpTubingSizePreferences.TabIndex = 202
			Me.grpTubingSizePreferences.TabStop = False
			Me.grpTubingSizePreferences.Text = "Casing/Tubing Size Preference"
			Me.chkFixTubingSize.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkFixTubingSize.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkFixTubingSize As Global.System.Windows.Forms.Control = Me.chkFixTubingSize
			location = New Global.System.Drawing.Point(486, 22)
			chkFixTubingSize.Location = location
			Me.chkFixTubingSize.Name = "chkFixTubingSize"
			Me.HelpProvider1.SetShowHelp(Me.chkFixTubingSize, False)
			Dim chkFixTubingSize2 As Global.System.Windows.Forms.Control = Me.chkFixTubingSize
			size = New Global.System.Drawing.Size(178, 21)
			chkFixTubingSize2.Size = size
			Me.chkFixTubingSize.TabIndex = 225
			Me.chkFixTubingSize.Text = "Fix Tubing Size"
			Me.lblCasingSize.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblCasingSize.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblCasingSize.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblCasingSize.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblCasingSize.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCasingSize As Global.System.Windows.Forms.Control = Me.lblCasingSize
			location = New Global.System.Drawing.Point(8, 163)
			lblCasingSize.Location = location
			Me.lblCasingSize.Name = "lblCasingSize"
			Me.lblCasingSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblCasingSize, False)
			Dim lblCasingSize2 As Global.System.Windows.Forms.Control = Me.lblCasingSize
			size = New Global.System.Drawing.Size(168, 19)
			lblCasingSize2.Size = size
			Me.lblCasingSize.TabIndex = 224
			Me.lblCasingSize.Tag = "(^)"
			Me.lblCasingSize.Text = "Casing size (in):"
			Me.lblCasingSize.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.txtCasingSize.AcceptsReturn = True
			Me.txtCasingSize.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtCasingSize.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtCasingSize.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtCasingSize.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtCasingSize, "Tubing size")
			Me.HelpProvider1.SetHelpNavigator(Me.txtCasingSize, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtCasingSize As Global.System.Windows.Forms.Control = Me.txtCasingSize
			location = New Global.System.Drawing.Point(176, 163)
			txtCasingSize.Location = location
			Me.txtCasingSize.MaxLength = 10
			Me.txtCasingSize.Name = "txtCasingSize"
			Me.txtCasingSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtCasingSize, True)
			Dim txtCasingSize2 As Global.System.Windows.Forms.Control = Me.txtCasingSize
			size = New Global.System.Drawing.Size(61, 22)
			txtCasingSize2.Size = size
			Me.txtCasingSize.TabIndex = 223
			Me.txtCasingSize.Tag = "mem"
			Me.txtCasingSize.Visible = False
			Me._Label_CasingSizeOD.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_CasingSizeOD.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_CasingSizeOD.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_CasingSizeOD.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me._Label_CasingSizeOD, "")
			Me._Label_CasingSizeOD.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_CasingSizeOD As Global.System.Windows.Forms.Control = Me._Label_CasingSizeOD
			location = New Global.System.Drawing.Point(19, 46)
			label_CasingSizeOD.Location = location
			Me._Label_CasingSizeOD.Name = "_Label_CasingSizeOD"
			Me._Label_CasingSizeOD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_CasingSizeOD, True)
			Dim label_CasingSizeOD2 As Global.System.Windows.Forms.Control = Me._Label_CasingSizeOD
			size = New Global.System.Drawing.Size(135, 19)
			label_CasingSizeOD2.Size = size
			Me._Label_CasingSizeOD.TabIndex = 219
			Me._Label_CasingSizeOD.Text = "Casing size (in):"
			Me._Label_CasingSizeOD.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkRodstarTubingSizeRec.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkRodstarTubingSizeRec.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkRodstarTubingSizeRec As Global.System.Windows.Forms.Control = Me.chkRodstarTubingSizeRec
			location = New Global.System.Drawing.Point(56, 22)
			chkRodstarTubingSizeRec.Location = location
			Me.chkRodstarTubingSizeRec.Name = "chkRodstarTubingSizeRec"
			Me.HelpProvider1.SetShowHelp(Me.chkRodstarTubingSizeRec, False)
			Dim chkRodstarTubingSizeRec2 As Global.System.Windows.Forms.Control = Me.chkRodstarTubingSizeRec
			size = New Global.System.Drawing.Size(248, 19)
			chkRodstarTubingSizeRec2.Size = size
			Me.chkRodstarTubingSizeRec.TabIndex = 101
			Me.chkRodstarTubingSizeRec.Text = "Use XROD-V Recommendations"
			Me._Label_MaxTubingSizeID.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_MaxTubingSizeID.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_MaxTubingSizeID.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_MaxTubingSizeID.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_MaxTubingSizeID.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_MaxTubingSizeID As Global.System.Windows.Forms.Control = Me._Label_MaxTubingSizeID
			location = New Global.System.Drawing.Point(8, 112)
			label_MaxTubingSizeID.Location = location
			Me._Label_MaxTubingSizeID.Name = "_Label_MaxTubingSizeID"
			Me._Label_MaxTubingSizeID.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_MaxTubingSizeID, False)
			Dim label_MaxTubingSizeID2 As Global.System.Windows.Forms.Control = Me._Label_MaxTubingSizeID
			size = New Global.System.Drawing.Size(168, 19)
			label_MaxTubingSizeID2.Size = size
			Me._Label_MaxTubingSizeID.TabIndex = 80
			Me._Label_MaxTubingSizeID.Tag = "(^)"
			Me._Label_MaxTubingSizeID.Text = "Max. Tubing size (in):"
			Me._Label_MaxTubingSizeID.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me._Label_MinTubingSizeID.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_MinTubingSizeID.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_MinTubingSizeID.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_MinTubingSizeID.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_MinTubingSizeID.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_MinTubingSizeID As Global.System.Windows.Forms.Control = Me._Label_MinTubingSizeID
			location = New Global.System.Drawing.Point(8, 136)
			label_MinTubingSizeID.Location = location
			Me._Label_MinTubingSizeID.Name = "_Label_MinTubingSizeID"
			Me._Label_MinTubingSizeID.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_MinTubingSizeID, False)
			Dim label_MinTubingSizeID2 As Global.System.Windows.Forms.Control = Me._Label_MinTubingSizeID
			size = New Global.System.Drawing.Size(168, 19)
			label_MinTubingSizeID2.Size = size
			Me._Label_MinTubingSizeID.TabIndex = 79
			Me._Label_MinTubingSizeID.Tag = "(^)"
			Me._Label_MinTubingSizeID.Text = "Min. Tubing size (in):"
			Me._Label_MinTubingSizeID.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.txtMaxTubingSizeID.AcceptsReturn = True
			Me.txtMaxTubingSizeID.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMaxTubingSizeID.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMaxTubingSizeID.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtMaxTubingSizeID.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMaxTubingSizeID, "Tubing size")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMaxTubingSizeID, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMaxTubingSizeID As Global.System.Windows.Forms.Control = Me.txtMaxTubingSizeID
			location = New Global.System.Drawing.Point(176, 112)
			txtMaxTubingSizeID.Location = location
			Me.txtMaxTubingSizeID.MaxLength = 10
			Me.txtMaxTubingSizeID.Name = "txtMaxTubingSizeID"
			Me.txtMaxTubingSizeID.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMaxTubingSizeID, True)
			Dim txtMaxTubingSizeID2 As Global.System.Windows.Forms.Control = Me.txtMaxTubingSizeID
			size = New Global.System.Drawing.Size(61, 22)
			txtMaxTubingSizeID2.Size = size
			Me.txtMaxTubingSizeID.TabIndex = 78
			Me.txtMaxTubingSizeID.Tag = "mem"
			Me.txtMaxTubingSizeID.Visible = False
			Me.txtMinTubingSizeID.AcceptsReturn = True
			Me.txtMinTubingSizeID.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMinTubingSizeID.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMinTubingSizeID.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtMinTubingSizeID.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMinTubingSizeID, "Tubing size")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMinTubingSizeID, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMinTubingSizeID As Global.System.Windows.Forms.Control = Me.txtMinTubingSizeID
			location = New Global.System.Drawing.Point(176, 136)
			txtMinTubingSizeID.Location = location
			Me.txtMinTubingSizeID.MaxLength = 10
			Me.txtMinTubingSizeID.Name = "txtMinTubingSizeID"
			Me.txtMinTubingSizeID.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMinTubingSizeID, True)
			Dim txtMinTubingSizeID2 As Global.System.Windows.Forms.Control = Me.txtMinTubingSizeID
			size = New Global.System.Drawing.Size(61, 22)
			txtMinTubingSizeID2.Size = size
			Me.txtMinTubingSizeID.TabIndex = 77
			Me.txtMinTubingSizeID.Tag = "mem"
			Me.txtMinTubingSizeID.Visible = False
			Me.txtMinTubingSizeOD.AcceptsReturn = True
			Me.txtMinTubingSizeOD.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMinTubingSizeOD.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMinTubingSizeOD.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtMinTubingSizeOD.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMinTubingSizeOD, "Tubing size")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMinTubingSizeOD, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMinTubingSizeOD As Global.System.Windows.Forms.Control = Me.txtMinTubingSizeOD
			location = New Global.System.Drawing.Point(240, 136)
			txtMinTubingSizeOD.Location = location
			Me.txtMinTubingSizeOD.MaxLength = 10
			Me.txtMinTubingSizeOD.Name = "txtMinTubingSizeOD"
			Me.txtMinTubingSizeOD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMinTubingSizeOD, True)
			Dim txtMinTubingSizeOD2 As Global.System.Windows.Forms.Control = Me.txtMinTubingSizeOD
			size = New Global.System.Drawing.Size(61, 22)
			txtMinTubingSizeOD2.Size = size
			Me.txtMinTubingSizeOD.TabIndex = 76
			Me.txtMinTubingSizeOD.Tag = "mem"
			Me.txtMinTubingSizeOD.Visible = False
			Me.txtMaxTubingSizeOD.AcceptsReturn = True
			Me.txtMaxTubingSizeOD.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtMaxTubingSizeOD.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtMaxTubingSizeOD.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtMaxTubingSizeOD.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtMaxTubingSizeOD, "Tubing size")
			Me.HelpProvider1.SetHelpNavigator(Me.txtMaxTubingSizeOD, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim txtMaxTubingSizeOD As Global.System.Windows.Forms.Control = Me.txtMaxTubingSizeOD
			location = New Global.System.Drawing.Point(240, 112)
			txtMaxTubingSizeOD.Location = location
			Me.txtMaxTubingSizeOD.MaxLength = 10
			Me.txtMaxTubingSizeOD.Name = "txtMaxTubingSizeOD"
			Me.txtMaxTubingSizeOD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtMaxTubingSizeOD, True)
			Dim txtMaxTubingSizeOD2 As Global.System.Windows.Forms.Control = Me.txtMaxTubingSizeOD
			size = New Global.System.Drawing.Size(61, 22)
			txtMaxTubingSizeOD2.Size = size
			Me.txtMaxTubingSizeOD.TabIndex = 75
			Me.txtMaxTubingSizeOD.Tag = "mem"
			Me.txtMaxTubingSizeOD.Visible = False
			Me._Label_MinTubingSizeOD.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_MinTubingSizeOD.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_MinTubingSizeOD.Enabled = False
			Me._Label_MinTubingSizeOD.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_MinTubingSizeOD.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_MinTubingSizeOD.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_MinTubingSizeOD As Global.System.Windows.Forms.Control = Me._Label_MinTubingSizeOD
			location = New Global.System.Drawing.Point(348, 110)
			label_MinTubingSizeOD.Location = location
			Me._Label_MinTubingSizeOD.Name = "_Label_MinTubingSizeOD"
			Me._Label_MinTubingSizeOD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_MinTubingSizeOD, False)
			Dim label_MinTubingSizeOD2 As Global.System.Windows.Forms.Control = Me._Label_MinTubingSizeOD
			size = New Global.System.Drawing.Size(144, 19)
			label_MinTubingSizeOD2.Size = size
			Me._Label_MinTubingSizeOD.TabIndex = 69
			Me._Label_MinTubingSizeOD.Text = "Min. Tubing size (in):"
			Me._Label_MinTubingSizeOD.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me._Label_MinTubingSizeOD.Visible = False
			Me.cboMinTubingSizeOD.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboMinTubingSizeOD.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboMinTubingSizeOD.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboMinTubingSizeOD.Enabled = False
			Me.cboMinTubingSizeOD.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboMinTubingSizeOD.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboMinTubingSizeOD, "tubing size")
			Me.HelpProvider1.SetHelpNavigator(Me.cboMinTubingSizeOD, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboMinTubingSizeOD.ItemHeight = 16
			Dim cboMinTubingSizeOD As Global.System.Windows.Forms.Control = Me.cboMinTubingSizeOD
			location = New Global.System.Drawing.Point(497, 110)
			cboMinTubingSizeOD.Location = location
			Me.cboMinTubingSizeOD.MaxDropDownItems = 100
			Me.cboMinTubingSizeOD.Name = "cboMinTubingSizeOD"
			Me.cboMinTubingSizeOD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboMinTubingSizeOD, True)
			Dim cboMinTubingSizeOD2 As Global.System.Windows.Forms.Control = Me.cboMinTubingSizeOD
			size = New Global.System.Drawing.Size(192, 24)
			cboMinTubingSizeOD2.Size = size
			Me.cboMinTubingSizeOD.TabIndex = 70
			Me.cboMinTubingSizeOD.Visible = False
			Me.lblcboMinTubingSizeOD_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblcboMinTubingSizeOD_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblcboMinTubingSizeOD_Disabled.Enabled = False
			Dim lblcboMinTubingSizeOD_Disabled As Global.System.Windows.Forms.Control = Me.lblcboMinTubingSizeOD_Disabled
			location = New Global.System.Drawing.Point(497, 110)
			lblcboMinTubingSizeOD_Disabled.Location = location
			Me.lblcboMinTubingSizeOD_Disabled.Name = "lblcboMinTubingSizeOD_Disabled"
			Dim lblcboMinTubingSizeOD_Disabled2 As Global.System.Windows.Forms.Control = Me.lblcboMinTubingSizeOD_Disabled
			size = New Global.System.Drawing.Size(192, 24)
			lblcboMinTubingSizeOD_Disabled2.Size = size
			Me.lblcboMinTubingSizeOD_Disabled.TabIndex = 218
			Me.lblcboMinTubingSizeOD_Disabled.Visible = False
			Me._Label_MaxTubingSizeOD.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_MaxTubingSizeOD.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_MaxTubingSizeOD.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_MaxTubingSizeOD.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_MaxTubingSizeOD.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_MaxTubingSizeOD As Global.System.Windows.Forms.Control = Me._Label_MaxTubingSizeOD
			location = New Global.System.Drawing.Point(349, 46)
			label_MaxTubingSizeOD.Location = location
			Me._Label_MaxTubingSizeOD.Name = "_Label_MaxTubingSizeOD"
			Me._Label_MaxTubingSizeOD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_MaxTubingSizeOD, False)
			Dim label_MaxTubingSizeOD2 As Global.System.Windows.Forms.Control = Me._Label_MaxTubingSizeOD
			size = New Global.System.Drawing.Size(137, 19)
			label_MaxTubingSizeOD2.Size = size
			Me._Label_MaxTubingSizeOD.TabIndex = 71
			Me._Label_MaxTubingSizeOD.Text = "Max. Tubing size (in):"
			Me._Label_MaxTubingSizeOD.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.cboCasingSize.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboCasingSize.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboCasingSize.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboCasingSize.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboCasingSize.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboCasingSize, "AI Preferences: Optional Casing Size")
			Me.HelpProvider1.SetHelpNavigator(Me.cboCasingSize, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboCasingSize.ItemHeight = 16
			Dim cboCasingSize As Global.System.Windows.Forms.Control = Me.cboCasingSize
			location = New Global.System.Drawing.Point(156, 46)
			cboCasingSize.Location = location
			Me.cboCasingSize.MaxDropDownItems = 100
			Me.cboCasingSize.Name = "cboCasingSize"
			Me.cboCasingSize.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboCasingSize, True)
			Dim cboCasingSize2 As Global.System.Windows.Forms.Control = Me.cboCasingSize
			size = New Global.System.Drawing.Size(178, 24)
			cboCasingSize2.Size = size
			Me.cboCasingSize.TabIndex = 220
			Me.cboMaxTubingSizeOD.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboMaxTubingSizeOD.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboMaxTubingSizeOD.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboMaxTubingSizeOD.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboMaxTubingSizeOD.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboMaxTubingSizeOD, "AI Preferences: Max Tubing Size")
			Me.HelpProvider1.SetHelpNavigator(Me.cboMaxTubingSizeOD, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboMaxTubingSizeOD.ItemHeight = 16
			Dim cboMaxTubingSizeOD As Global.System.Windows.Forms.Control = Me.cboMaxTubingSizeOD
			location = New Global.System.Drawing.Point(486, 46)
			cboMaxTubingSizeOD.Location = location
			Me.cboMaxTubingSizeOD.MaxDropDownItems = 100
			Me.cboMaxTubingSizeOD.Name = "cboMaxTubingSizeOD"
			Me.cboMaxTubingSizeOD.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboMaxTubingSizeOD, True)
			Dim cboMaxTubingSizeOD2 As Global.System.Windows.Forms.Control = Me.cboMaxTubingSizeOD
			size = New Global.System.Drawing.Size(178, 24)
			cboMaxTubingSizeOD2.Size = size
			Me.cboMaxTubingSizeOD.TabIndex = 72
			Me.lblcboMaxTubingSizeOD_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblcboMaxTubingSizeOD_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblcboMaxTubingSizeOD_Disabled As Global.System.Windows.Forms.Control = Me.lblcboMaxTubingSizeOD_Disabled
			location = New Global.System.Drawing.Point(486, 46)
			lblcboMaxTubingSizeOD_Disabled.Location = location
			Me.lblcboMaxTubingSizeOD_Disabled.Name = "lblcboMaxTubingSizeOD_Disabled"
			Dim lblcboMaxTubingSizeOD_Disabled2 As Global.System.Windows.Forms.Control = Me.lblcboMaxTubingSizeOD_Disabled
			size = New Global.System.Drawing.Size(180, 24)
			lblcboMaxTubingSizeOD_Disabled2.Size = size
			Me.lblcboMaxTubingSizeOD_Disabled.TabIndex = 217
			Me.lblcboCasingSize_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblcboCasingSize_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Dim lblcboCasingSize_Disabled As Global.System.Windows.Forms.Control = Me.lblcboCasingSize_Disabled
			location = New Global.System.Drawing.Point(156, 46)
			lblcboCasingSize_Disabled.Location = location
			Me.lblcboCasingSize_Disabled.Name = "lblcboCasingSize_Disabled"
			Dim lblcboCasingSize_Disabled2 As Global.System.Windows.Forms.Control = Me.lblcboCasingSize_Disabled
			size = New Global.System.Drawing.Size(180, 24)
			lblcboCasingSize_Disabled2.Size = size
			Me.lblcboCasingSize_Disabled.TabIndex = 221
			Me.grpRodPreferences.Controls.Add(Me._Label_ElectricityCost)
			Me.grpRodPreferences.Controls.Add(Me.txtElectricityCostPreference)
			Me.grpRodPreferences.Controls.Add(Me.pnlUseRodOnly)
			Me.grpRodPreferences.Controls.Add(Me.txtServiceFactorPreference)
			Me.grpRodPreferences.Controls.Add(Me.lblServiceFactor)
			Me.grpRodPreferences.Controls.Add(Me.cboHighStrengthRods)
			Me.grpRodPreferences.Controls.Add(Me.optSinkerRods)
			Me.grpRodPreferences.Controls.Add(Me.optSinkerBars)
			Me.grpRodPreferences.Controls.Add(Me.lblRSFGGrade)
			Me.grpRodPreferences.Controls.Add(Me.lblSinkerBars)
			Me.grpRodPreferences.Controls.Add(Me.cboSinkerBarsGrade)
			Me.grpRodPreferences.Controls.Add(Me.lblRSGrade)
			Me.grpRodPreferences.Controls.Add(Me.cboFGlassRods)
			Me.grpRodPreferences.Controls.Add(Me.lblSinkerRods)
			Me.grpRodPreferences.Controls.Add(Me.cboSinkerRodsGrade)
			Me.grpRodPreferences.Controls.Add(Me.cboUHSProrod)
			Me.grpRodPreferences.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim grpRodPreferences As Global.System.Windows.Forms.Control = Me.grpRodPreferences
			location = New Global.System.Drawing.Point(2, 0)
			grpRodPreferences.Location = location
			Me.grpRodPreferences.Name = "grpRodPreferences"
			Dim grpRodPreferences2 As Global.System.Windows.Forms.Control = Me.grpRodPreferences
			size = New Global.System.Drawing.Size(698, 149)
			grpRodPreferences2.Size = size
			Me.grpRodPreferences.TabIndex = 200
			Me.grpRodPreferences.TabStop = False
			Me.grpRodPreferences.Text = "Rod Preferences"
			Me._Label_ElectricityCost.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_ElectricityCost.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_ElectricityCost.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_ElectricityCost.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_ElectricityCost.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_ElectricityCost As Global.System.Windows.Forms.Control = Me._Label_ElectricityCost
			location = New Global.System.Drawing.Point(376, 122)
			label_ElectricityCost.Location = location
			Me._Label_ElectricityCost.Name = "_Label_ElectricityCost"
			Me._Label_ElectricityCost.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_ElectricityCost, False)
			Dim label_ElectricityCost2 As Global.System.Windows.Forms.Control = Me._Label_ElectricityCost
			size = New Global.System.Drawing.Size(144, 19)
			label_ElectricityCost2.Size = size
			Me._Label_ElectricityCost.TabIndex = 233
			Me._Label_ElectricityCost.Text = "Electricity cost ($/kwh):"
			Me._Label_ElectricityCost.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.txtElectricityCostPreference.AcceptsReturn = True
			Me.txtElectricityCostPreference.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtElectricityCostPreference.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtElectricityCostPreference.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtElectricityCostPreference.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtElectricityCostPreference, "AI Preferences:  Electric Cost")
			Me.HelpProvider1.SetHelpNavigator(Me.txtElectricityCostPreference, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.txtElectricityCostPreference.HideSelection = False
			Dim txtElectricityCostPreference As Global.System.Windows.Forms.Control = Me.txtElectricityCostPreference
			location = New Global.System.Drawing.Point(528, 122)
			txtElectricityCostPreference.Location = location
			Me.txtElectricityCostPreference.MaxLength = 40
			Me.txtElectricityCostPreference.Name = "txtElectricityCostPreference"
			Me.txtElectricityCostPreference.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtElectricityCostPreference, True)
			Dim txtElectricityCostPreference2 As Global.System.Windows.Forms.Control = Me.txtElectricityCostPreference
			size = New Global.System.Drawing.Size(61, 22)
			txtElectricityCostPreference2.Size = size
			Me.txtElectricityCostPreference.TabIndex = 232
			Me.txtElectricityCostPreference.TabStop = False
			Me.pnlUseRodOnly.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.pnlUseRodOnly.Controls.Add(Me.rbtUseBoth)
			Me.pnlUseRodOnly.Controls.Add(Me.optUseSteelRodsOnly)
			Me.pnlUseRodOnly.Controls.Add(Me.optUseFGlassWithSteelOnBottom)
			Dim pnlUseRodOnly As Global.System.Windows.Forms.Control = Me.pnlUseRodOnly
			location = New Global.System.Drawing.Point(131, 10)
			pnlUseRodOnly.Location = location
			Me.pnlUseRodOnly.Name = "pnlUseRodOnly"
			Dim pnlUseRodOnly2 As Global.System.Windows.Forms.Control = Me.pnlUseRodOnly
			size = New Global.System.Drawing.Size(542, 32)
			pnlUseRodOnly2.Size = size
			Me.pnlUseRodOnly.TabIndex = 218
			Me.rbtUseBoth.AutoSize = True
			Me.HelpProvider1.SetHelpKeyword(Me.rbtUseBoth, "AI Preferences: Use Both")
			Me.HelpProvider1.SetHelpNavigator(Me.rbtUseBoth, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim rbtUseBoth As Global.System.Windows.Forms.Control = Me.rbtUseBoth
			location = New Global.System.Drawing.Point(440, 5)
			rbtUseBoth.Location = location
			Me.rbtUseBoth.Name = "rbtUseBoth"
			Me.HelpProvider1.SetShowHelp(Me.rbtUseBoth, True)
			Dim rbtUseBoth2 As Global.System.Windows.Forms.Control = Me.rbtUseBoth
			size = New Global.System.Drawing.Size(80, 20)
			rbtUseBoth2.Size = size
			Me.rbtUseBoth.TabIndex = 224
			Me.rbtUseBoth.Text = "Use Both"
			Me.optUseSteelRodsOnly.AutoSize = True
			Me.HelpProvider1.SetHelpKeyword(Me.optUseSteelRodsOnly, "AI Preferences: Use Steel Rods Only")
			Me.HelpProvider1.SetHelpNavigator(Me.optUseSteelRodsOnly, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim optUseSteelRodsOnly As Global.System.Windows.Forms.Control = Me.optUseSteelRodsOnly
			location = New Global.System.Drawing.Point(11, 5)
			optUseSteelRodsOnly.Location = location
			Me.optUseSteelRodsOnly.Name = "optUseSteelRodsOnly"
			Me.HelpProvider1.SetShowHelp(Me.optUseSteelRodsOnly, True)
			Dim optUseSteelRodsOnly2 As Global.System.Windows.Forms.Control = Me.optUseSteelRodsOnly
			size = New Global.System.Drawing.Size(140, 20)
			optUseSteelRodsOnly2.Size = size
			Me.optUseSteelRodsOnly.TabIndex = 222
			Me.optUseSteelRodsOnly.Text = "Use Steel rods only"
			Me.optUseFGlassWithSteelOnBottom.AutoSize = True
			Me.HelpProvider1.SetHelpKeyword(Me.optUseFGlassWithSteelOnBottom, "AI Preferences: Use Fiberglass with Steel on Bottom")
			Me.HelpProvider1.SetHelpNavigator(Me.optUseFGlassWithSteelOnBottom, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim optUseFGlassWithSteelOnBottom As Global.System.Windows.Forms.Control = Me.optUseFGlassWithSteelOnBottom
			location = New Global.System.Drawing.Point(163, 5)
			optUseFGlassWithSteelOnBottom.Location = location
			Me.optUseFGlassWithSteelOnBottom.Name = "optUseFGlassWithSteelOnBottom"
			Me.HelpProvider1.SetShowHelp(Me.optUseFGlassWithSteelOnBottom, True)
			Dim optUseFGlassWithSteelOnBottom2 As Global.System.Windows.Forms.Control = Me.optUseFGlassWithSteelOnBottom
			size = New Global.System.Drawing.Size(265, 20)
			optUseFGlassWithSteelOnBottom2.Size = size
			Me.optUseFGlassWithSteelOnBottom.TabIndex = 223
			Me.optUseFGlassWithSteelOnBottom.Text = "Use Fiberglass with Steel rods on bottom"
			Me.txtServiceFactorPreference.AcceptsReturn = True
			Me.txtServiceFactorPreference.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtServiceFactorPreference.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtServiceFactorPreference.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.txtServiceFactorPreference.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtServiceFactorPreference, "AI Preferences: Steel Rod Service Factor")
			Me.HelpProvider1.SetHelpNavigator(Me.txtServiceFactorPreference, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.txtServiceFactorPreference.HideSelection = False
			Dim txtServiceFactorPreference As Global.System.Windows.Forms.Control = Me.txtServiceFactorPreference
			location = New Global.System.Drawing.Point(304, 122)
			txtServiceFactorPreference.Location = location
			Me.txtServiceFactorPreference.MaxLength = 40
			Me.txtServiceFactorPreference.Name = "txtServiceFactorPreference"
			Me.txtServiceFactorPreference.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.txtServiceFactorPreference, True)
			Dim txtServiceFactorPreference2 As Global.System.Windows.Forms.Control = Me.txtServiceFactorPreference
			size = New Global.System.Drawing.Size(61, 22)
			txtServiceFactorPreference2.Size = size
			Me.txtServiceFactorPreference.TabIndex = 228
			Me.txtServiceFactorPreference.TabStop = False
			Me.lblServiceFactor.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblServiceFactor.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblServiceFactor.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblServiceFactor.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblServiceFactor.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblServiceFactor As Global.System.Windows.Forms.Control = Me.lblServiceFactor
			location = New Global.System.Drawing.Point(128, 122)
			lblServiceFactor.Location = location
			Me.lblServiceFactor.Name = "lblServiceFactor"
			Me.lblServiceFactor.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblServiceFactor, False)
			Dim lblServiceFactor2 As Global.System.Windows.Forms.Control = Me.lblServiceFactor
			size = New Global.System.Drawing.Size(168, 19)
			lblServiceFactor2.Size = size
			Me.lblServiceFactor.TabIndex = 229
			Me.lblServiceFactor.Text = "Steel rod service factor:"
			Me.lblServiceFactor.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.cboHighStrengthRods.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboHighStrengthRods.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboHighStrengthRods.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboHighStrengthRods.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboHighStrengthRods.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboHighStrengthRods, "AI Preferences: High Strength Rods")
			Me.HelpProvider1.SetHelpNavigator(Me.cboHighStrengthRods, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboHighStrengthRods.ItemHeight = 14
			Dim cboHighStrengthRods As Global.System.Windows.Forms.Control = Me.cboHighStrengthRods
			location = New Global.System.Drawing.Point(304, 48)
			cboHighStrengthRods.Location = location
			Me.cboHighStrengthRods.Name = "cboHighStrengthRods"
			Me.cboHighStrengthRods.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboHighStrengthRods, True)
			Dim cboHighStrengthRods2 As Global.System.Windows.Forms.Control = Me.cboHighStrengthRods
			size = New Global.System.Drawing.Size(248, 22)
			cboHighStrengthRods2.Size = size
			Me.cboHighStrengthRods.TabIndex = 200
			Me.cboHighStrengthRods.TabStop = False
			Me.optSinkerRods.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optSinkerRods.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optSinkerRods.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.optSinkerRods.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.optSinkerRods.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optSinkerRods As Global.System.Windows.Forms.Control = Me.optSinkerRods
			location = New Global.System.Drawing.Point(561, 96)
			optSinkerRods.Location = location
			Me.optSinkerRods.Name = "optSinkerRods"
			Me.optSinkerRods.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optSinkerRods, False)
			Dim optSinkerRods2 As Global.System.Windows.Forms.Control = Me.optSinkerRods
			size = New Global.System.Drawing.Size(104, 19)
			optSinkerRods2.Size = size
			Me.optSinkerRods.TabIndex = 215
			Me.optSinkerRods.Text = "Sinker rods"
			Me.optSinkerRods.UseVisualStyleBackColor = False
			Me.optSinkerRods.Visible = False
			Me.optSinkerBars.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optSinkerBars.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optSinkerBars.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.optSinkerBars.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.optSinkerBars.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optSinkerBars As Global.System.Windows.Forms.Control = Me.optSinkerBars
			location = New Global.System.Drawing.Point(561, 75)
			optSinkerBars.Location = location
			Me.optSinkerBars.Name = "optSinkerBars"
			Me.optSinkerBars.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optSinkerBars, False)
			Dim optSinkerBars2 As Global.System.Windows.Forms.Control = Me.optSinkerBars
			size = New Global.System.Drawing.Size(104, 19)
			optSinkerBars2.Size = size
			Me.optSinkerBars.TabIndex = 214
			Me.optSinkerBars.Text = "Sinker bars"
			Me.optSinkerBars.UseVisualStyleBackColor = False
			Me.optSinkerBars.Visible = False
			Me.lblRSFGGrade.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRSFGGrade.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRSFGGrade.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblRSFGGrade.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRSFGGrade.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblRSFGGrade As Global.System.Windows.Forms.Control = Me.lblRSFGGrade
			location = New Global.System.Drawing.Point(0, 72)
			lblRSFGGrade.Location = location
			Me.lblRSFGGrade.Name = "lblRSFGGrade"
			Me.lblRSFGGrade.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRSFGGrade, False)
			Dim lblRSFGGrade2 As Global.System.Windows.Forms.Control = Me.lblRSFGGrade
			size = New Global.System.Drawing.Size(296, 19)
			lblRSFGGrade2.Size = size
			Me.lblRSFGGrade.TabIndex = 209
			Me.lblRSFGGrade.Text = "Fiberglass Rods:"
			Me.lblRSFGGrade.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.lblSinkerBars.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblSinkerBars.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblSinkerBars.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblSinkerBars.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblSinkerBars.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblSinkerBars As Global.System.Windows.Forms.Control = Me.lblSinkerBars
			location = New Global.System.Drawing.Point(0, 96)
			lblSinkerBars.Location = location
			Me.lblSinkerBars.Name = "lblSinkerBars"
			Me.lblSinkerBars.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblSinkerBars, False)
			Dim lblSinkerBars2 As Global.System.Windows.Forms.Control = Me.lblSinkerBars
			size = New Global.System.Drawing.Size(296, 19)
			lblSinkerBars2.Size = size
			Me.lblSinkerBars.TabIndex = 206
			Me.lblSinkerBars.Text = "Sinker Bars:"
			Me.lblSinkerBars.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.cboSinkerBarsGrade.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboSinkerBarsGrade.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboSinkerBarsGrade.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboSinkerBarsGrade.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboSinkerBarsGrade.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboSinkerBarsGrade, "AI Preferences: Sinker Bars")
			Me.HelpProvider1.SetHelpNavigator(Me.cboSinkerBarsGrade, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboSinkerBarsGrade.ItemHeight = 14
			Dim cboSinkerBarsGrade As Global.System.Windows.Forms.Control = Me.cboSinkerBarsGrade
			location = New Global.System.Drawing.Point(304, 96)
			cboSinkerBarsGrade.Location = location
			Me.cboSinkerBarsGrade.Name = "cboSinkerBarsGrade"
			Me.cboSinkerBarsGrade.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboSinkerBarsGrade, True)
			Dim cboSinkerBarsGrade2 As Global.System.Windows.Forms.Control = Me.cboSinkerBarsGrade
			size = New Global.System.Drawing.Size(248, 22)
			cboSinkerBarsGrade2.Size = size
			Me.cboSinkerBarsGrade.TabIndex = 205
			Me.cboSinkerBarsGrade.TabStop = False
			Me.lblRSGrade.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRSGrade.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblRSGrade.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblRSGrade.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblRSGrade.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblRSGrade As Global.System.Windows.Forms.Control = Me.lblRSGrade
			location = New Global.System.Drawing.Point(0, 48)
			lblRSGrade.Location = location
			Me.lblRSGrade.Name = "lblRSGrade"
			Me.lblRSGrade.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblRSGrade, False)
			Dim lblRSGrade2 As Global.System.Windows.Forms.Control = Me.lblRSGrade
			size = New Global.System.Drawing.Size(296, 19)
			lblRSGrade2.Size = size
			Me.lblRSGrade.TabIndex = 201
			Me.lblRSGrade.Text = "Preferred rod type stronger than API grade D:"
			Me.lblRSGrade.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.cboFGlassRods.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboFGlassRods.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboFGlassRods.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboFGlassRods.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboFGlassRods.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboFGlassRods, "AI Preferences: Fiberglass Rods")
			Me.HelpProvider1.SetHelpNavigator(Me.cboFGlassRods, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboFGlassRods.ItemHeight = 14
			Dim cboFGlassRods As Global.System.Windows.Forms.Control = Me.cboFGlassRods
			location = New Global.System.Drawing.Point(304, 72)
			cboFGlassRods.Location = location
			Me.cboFGlassRods.Name = "cboFGlassRods"
			Me.cboFGlassRods.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboFGlassRods, True)
			Dim cboFGlassRods2 As Global.System.Windows.Forms.Control = Me.cboFGlassRods
			size = New Global.System.Drawing.Size(248, 22)
			cboFGlassRods2.Size = size
			Me.cboFGlassRods.TabIndex = 208
			Me.cboFGlassRods.TabStop = False
			Me.lblSinkerRods.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblSinkerRods.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblSinkerRods.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.lblSinkerRods.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblSinkerRods.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblSinkerRods As Global.System.Windows.Forms.Control = Me.lblSinkerRods
			location = New Global.System.Drawing.Point(24, 96)
			lblSinkerRods.Location = location
			Me.lblSinkerRods.Name = "lblSinkerRods"
			Me.lblSinkerRods.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblSinkerRods, False)
			Dim lblSinkerRods2 As Global.System.Windows.Forms.Control = Me.lblSinkerRods
			size = New Global.System.Drawing.Size(168, 19)
			lblSinkerRods2.Size = size
			Me.lblSinkerRods.TabIndex = 213
			Me.lblSinkerRods.Text = "Sinker Rods:"
			Me.lblSinkerRods.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.cboSinkerRodsGrade.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboSinkerRodsGrade.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboSinkerRodsGrade.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboSinkerRodsGrade.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboSinkerRodsGrade.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboSinkerRodsGrade, "sinker bar grade or manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboSinkerRodsGrade, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboSinkerRodsGrade.ItemHeight = 14
			Dim cboSinkerRodsGrade As Global.System.Windows.Forms.Control = Me.cboSinkerRodsGrade
			location = New Global.System.Drawing.Point(304, 96)
			cboSinkerRodsGrade.Location = location
			Me.cboSinkerRodsGrade.Name = "cboSinkerRodsGrade"
			Me.cboSinkerRodsGrade.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboSinkerRodsGrade, True)
			Dim cboSinkerRodsGrade2 As Global.System.Windows.Forms.Control = Me.cboSinkerRodsGrade
			size = New Global.System.Drawing.Size(248, 22)
			cboSinkerRodsGrade2.Size = size
			Me.cboSinkerRodsGrade.TabIndex = 212
			Me.cboSinkerRodsGrade.TabStop = False
			Me.cboUHSProrod.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboUHSProrod.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboUHSProrod.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboUHSProrod.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboUHSProrod.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboUHSProrod, "steel grade or manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboUHSProrod, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboUHSProrod.ItemHeight = 14
			Dim cboUHSProrod As Global.System.Windows.Forms.Control = Me.cboUHSProrod
			location = New Global.System.Drawing.Point(304, 48)
			cboUHSProrod.Location = location
			Me.cboUHSProrod.Name = "cboUHSProrod"
			Me.cboUHSProrod.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboUHSProrod, True)
			Dim cboUHSProrod2 As Global.System.Windows.Forms.Control = Me.cboUHSProrod
			size = New Global.System.Drawing.Size(248, 22)
			cboUHSProrod2.Size = size
			Me.cboUHSProrod.TabIndex = 226
			Me.cboUHSProrod.TabStop = False
			Me.lblStatus.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.lblStatus.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblStatus.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim lblStatus As Global.System.Windows.Forms.Control = Me.lblStatus
			location = New Global.System.Drawing.Point(0, 618)
			lblStatus.Location = location
			Me.lblStatus.Name = "lblStatus"
			Dim lblStatus2 As Global.System.Windows.Forms.Control = Me.lblStatus
			size = New Global.System.Drawing.Size(705, 16)
			lblStatus2.Size = size
			Me.lblStatus.TabIndex = 209
			Me.grpMotorPreferences.Controls.Add(Me.pnlMotorData)
			Me.grpMotorPreferences.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim grpMotorPreferences As Global.System.Windows.Forms.Control = Me.grpMotorPreferences
			location = New Global.System.Drawing.Point(2, 527)
			grpMotorPreferences.Location = location
			Me.grpMotorPreferences.Name = "grpMotorPreferences"
			Dim grpMotorPreferences2 As Global.System.Windows.Forms.Control = Me.grpMotorPreferences
			size = New Global.System.Drawing.Size(698, 85)
			grpMotorPreferences2.Size = size
			Me.grpMotorPreferences.TabIndex = 208
			Me.grpMotorPreferences.TabStop = False
			Me.grpMotorPreferences.Text = "Motor Preferences"
			Me.pnlMotorData.Controls.Add(Me.chkIncludeMotorSPV)
			Me.pnlMotorData.Controls.Add(Me.optPowerMeterType_2)
			Me.pnlMotorData.Controls.Add(Me.optPowerMeterType_1)
			Me.pnlMotorData.Controls.Add(Me._Label_MeterType)
			Dim pnlMotorData As Global.System.Windows.Forms.Control = Me.pnlMotorData
			location = New Global.System.Drawing.Point(32, 16)
			pnlMotorData.Location = location
			Me.pnlMotorData.Name = "pnlMotorData"
			Me.HelpProvider1.SetShowHelp(Me.pnlMotorData, False)
			Dim pnlMotorData2 As Global.System.Windows.Forms.Control = Me.pnlMotorData
			size = New Global.System.Drawing.Size(654, 67)
			pnlMotorData2.Size = size
			Me.pnlMotorData.TabIndex = 208
			Me.chkIncludeMotorSPV.BackColor = Global.System.Drawing.SystemColors.Control
			Me.chkIncludeMotorSPV.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.chkIncludeMotorSPV.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkIncludeMotorSPV.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.chkIncludeMotorSPV, "AI Preferences: Include Motor Speed Variation")
			Me.HelpProvider1.SetHelpNavigator(Me.chkIncludeMotorSPV, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.chkIncludeMotorSPV.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkIncludeMotorSPV As Global.System.Windows.Forms.Control = Me.chkIncludeMotorSPV
			location = New Global.System.Drawing.Point(352, 19)
			chkIncludeMotorSPV.Location = location
			Me.chkIncludeMotorSPV.Name = "chkIncludeMotorSPV"
			Me.chkIncludeMotorSPV.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.chkIncludeMotorSPV, True)
			Dim chkIncludeMotorSPV2 As Global.System.Windows.Forms.Control = Me.chkIncludeMotorSPV
			size = New Global.System.Drawing.Size(272, 24)
			chkIncludeMotorSPV2.Size = size
			Me.chkIncludeMotorSPV.TabIndex = 41
			Me.chkIncludeMotorSPV.Text = "Include motor speed variation"
			Me.chkIncludeMotorSPV.UseVisualStyleBackColor = False
			Me.optPowerMeterType_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optPowerMeterType_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optPowerMeterType_2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.optPowerMeterType_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optPowerMeterType_2, "AI Preferences: Power Meter Type - Non-Detent")
			Me.HelpProvider1.SetHelpNavigator(Me.optPowerMeterType_2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optPowerMeterType_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPowerMeterType_ As Global.System.Windows.Forms.Control = Me.optPowerMeterType_2
			location = New Global.System.Drawing.Point(24, 46)
			optPowerMeterType_.Location = location
			Me.optPowerMeterType_2.Name = "optPowerMeterType_2"
			Me.optPowerMeterType_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optPowerMeterType_2, True)
			Dim optPowerMeterType_2 As Global.System.Windows.Forms.Control = Me.optPowerMeterType_2
			size = New Global.System.Drawing.Size(320, 19)
			optPowerMeterType_2.Size = size
			Me.optPowerMeterType_2.TabIndex = 32
			Me.optPowerMeterType_2.TabStop = True
			Me.optPowerMeterType_2.Text = "Non-detent (credit for generated power)"
			Me.optPowerMeterType_2.UseVisualStyleBackColor = False
			Me.optPowerMeterType_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me.optPowerMeterType_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.optPowerMeterType_1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.optPowerMeterType_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.optPowerMeterType_1, "AI Preferences: Power Meter Type - Detent")
			Me.HelpProvider1.SetHelpNavigator(Me.optPowerMeterType_1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.optPowerMeterType_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPowerMeterType_3 As Global.System.Windows.Forms.Control = Me.optPowerMeterType_1
			location = New Global.System.Drawing.Point(24, 22)
			optPowerMeterType_3.Location = location
			Me.optPowerMeterType_1.Name = "optPowerMeterType_1"
			Me.optPowerMeterType_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.optPowerMeterType_1, True)
			Dim optPowerMeterType_4 As Global.System.Windows.Forms.Control = Me.optPowerMeterType_1
			size = New Global.System.Drawing.Size(320, 19)
			optPowerMeterType_4.Size = size
			Me.optPowerMeterType_1.TabIndex = 31
			Me.optPowerMeterType_1.TabStop = True
			Me.optPowerMeterType_1.Text = "Detent (no credit for generated power)"
			Me.optPowerMeterType_1.UseVisualStyleBackColor = False
			Me._Label_MeterType.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_MeterType.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_MeterType.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_MeterType.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_MeterType.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_MeterType As Global.System.Windows.Forms.Control = Me._Label_MeterType
			location = New Global.System.Drawing.Point(16, 4)
			label_MeterType.Location = location
			Me._Label_MeterType.Name = "_Label_MeterType"
			Me._Label_MeterType.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_MeterType, False)
			Dim label_MeterType2 As Global.System.Windows.Forms.Control = Me._Label_MeterType
			size = New Global.System.Drawing.Size(328, 17)
			label_MeterType2.Size = size
			Me._Label_MeterType.TabIndex = 30
			Me._Label_MeterType.Text = "Power meter type:"
			Me.grpRodTubingFricCoeffPref.Controls.Add(Me.NumericUpDown1_XTimes)
			Me.grpRodTubingFricCoeffPref.Controls.Add(Me.lblUseXTimes)
			Me.grpRodTubingFricCoeffPref.Controls.Add(Me.lblUseAvgFric)
			Me.grpRodTubingFricCoeffPref.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim grpRodTubingFricCoeffPref As Global.System.Windows.Forms.Control = Me.grpRodTubingFricCoeffPref
			location = New Global.System.Drawing.Point(2, 471)
			grpRodTubingFricCoeffPref.Location = location
			Me.grpRodTubingFricCoeffPref.Name = "grpRodTubingFricCoeffPref"
			Dim grpRodTubingFricCoeffPref2 As Global.System.Windows.Forms.Control = Me.grpRodTubingFricCoeffPref
			size = New Global.System.Drawing.Size(698, 57)
			grpRodTubingFricCoeffPref2.Size = size
			Me.grpRodTubingFricCoeffPref.TabIndex = 204
			Me.grpRodTubingFricCoeffPref.TabStop = False
			Me.grpRodTubingFricCoeffPref.Text = "Rod-Tubing Friction Coefficient Preference"
			Me.NumericUpDown1_XTimes.DecimalPlaces = 2
			Me.HelpProvider1.SetHelpKeyword(Me.NumericUpDown1_XTimes, "Rod-Tubing Friction Coefficient Preference")
			Me.HelpProvider1.SetHelpNavigator(Me.NumericUpDown1_XTimes, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim numericUpDown1_XTimes As Global.System.Windows.Forms.NumericUpDown = Me.NumericUpDown1_XTimes
			Dim num As Decimal = New Decimal(New Integer() { 25, 0, 0, 131072 })
			numericUpDown1_XTimes.Increment = num
			Dim numericUpDown1_XTimes2 As Global.System.Windows.Forms.Control = Me.NumericUpDown1_XTimes
			location = New Global.System.Drawing.Point(106, 24)
			numericUpDown1_XTimes2.Location = location
			Dim numericUpDown1_XTimes3 As Global.System.Windows.Forms.NumericUpDown = Me.NumericUpDown1_XTimes
			num = New Decimal(New Integer() { 10, 0, 0, 0 })
			numericUpDown1_XTimes3.Maximum = num
			Dim numericUpDown1_XTimes4 As Global.System.Windows.Forms.NumericUpDown = Me.NumericUpDown1_XTimes
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			numericUpDown1_XTimes4.Minimum = num
			Me.NumericUpDown1_XTimes.Name = "NumericUpDown1_XTimes"
			Me.HelpProvider1.SetShowHelp(Me.NumericUpDown1_XTimes, True)
			Dim numericUpDown1_XTimes5 As Global.System.Windows.Forms.Control = Me.NumericUpDown1_XTimes
			size = New Global.System.Drawing.Size(62, 22)
			numericUpDown1_XTimes5.Size = size
			Me.NumericUpDown1_XTimes.TabIndex = 220
			Me.NumericUpDown1_XTimes.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Dim numericUpDown1_XTimes6 As Global.System.Windows.Forms.NumericUpDown = Me.NumericUpDown1_XTimes
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			numericUpDown1_XTimes6.Value = num
			Dim lblUseXTimes As Global.System.Windows.Forms.Control = Me.lblUseXTimes
			location = New Global.System.Drawing.Point(168, 24)
			lblUseXTimes.Location = location
			Me.lblUseXTimes.Name = "lblUseXTimes"
			Dim lblUseXTimes2 As Global.System.Windows.Forms.Control = Me.lblUseXTimes
			size = New Global.System.Drawing.Size(480, 19)
			lblUseXTimes2.Size = size
			Me.lblUseXTimes.TabIndex = 219
			Me.lblUseXTimes.Text = "] times the average rod-tubing friction coefficients calculated by XROD-V"
			Me.lblUseXTimes.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Dim lblUseAvgFric As Global.System.Windows.Forms.Control = Me.lblUseAvgFric
			location = New Global.System.Drawing.Point(70, 24)
			lblUseAvgFric.Location = location
			Me.lblUseAvgFric.Name = "lblUseAvgFric"
			Dim lblUseAvgFric2 As Global.System.Windows.Forms.Control = Me.lblUseAvgFric
			size = New Global.System.Drawing.Size(40, 19)
			lblUseAvgFric2.Size = size
			Me.lblUseAvgFric.TabIndex = 221
			Me.lblUseAvgFric.Text = "Use ["
			Me.grpPumpTypePreference.Controls.Add(Me.chkInsertPump)
			Me.grpPumpTypePreference.Controls.Add(Me.chkRodstarPumpTypeRec)
			Me.grpPumpTypePreference.Controls.Add(Me.chkTubingPump)
			Me.grpPumpTypePreference.Controls.Add(Me.chkLargeBorePump)
			Me.grpPumpTypePreference.Controls.Add(Me.lblchkTubingPump_Disabled)
			Me.grpPumpTypePreference.Controls.Add(Me.lblchkLargeBorePump_Disabled)
			Me.grpPumpTypePreference.Controls.Add(Me.lblchkInsertPump_Disabled)
			Me.grpPumpTypePreference.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim grpPumpTypePreference As Global.System.Windows.Forms.Control = Me.grpPumpTypePreference
			location = New Global.System.Drawing.Point(384, 783)
			grpPumpTypePreference.Location = location
			Me.grpPumpTypePreference.Name = "grpPumpTypePreference"
			Dim grpPumpTypePreference2 As Global.System.Windows.Forms.Control = Me.grpPumpTypePreference
			size = New Global.System.Drawing.Size(296, 111)
			grpPumpTypePreference2.Size = size
			Me.grpPumpTypePreference.TabIndex = 201
			Me.grpPumpTypePreference.TabStop = False
			Me.grpPumpTypePreference.Text = "Pump Type Preferences"
			Me.grpPumpTypePreference.Visible = False
			Me.chkInsertPump.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim chkInsertPump As Global.System.Windows.Forms.Control = Me.chkInsertPump
			location = New Global.System.Drawing.Point(72, 48)
			chkInsertPump.Location = location
			Me.chkInsertPump.Name = "chkInsertPump"
			Dim chkInsertPump2 As Global.System.Windows.Forms.Control = Me.chkInsertPump
			size = New Global.System.Drawing.Size(144, 20)
			chkInsertPump2.Size = size
			Me.chkInsertPump.TabIndex = 207
			Me.chkInsertPump.Text = " Insert pump"
			Me.chkRodstarPumpTypeRec.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkRodstarPumpTypeRec.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkRodstarPumpTypeRec As Global.System.Windows.Forms.Control = Me.chkRodstarPumpTypeRec
			location = New Global.System.Drawing.Point(16, 24)
			chkRodstarPumpTypeRec.Location = location
			Me.chkRodstarPumpTypeRec.Name = "chkRodstarPumpTypeRec"
			Me.HelpProvider1.SetShowHelp(Me.chkRodstarPumpTypeRec, False)
			Dim chkRodstarPumpTypeRec2 As Global.System.Windows.Forms.Control = Me.chkRodstarPumpTypeRec
			size = New Global.System.Drawing.Size(248, 19)
			chkRodstarPumpTypeRec2.Size = size
			Me.chkRodstarPumpTypeRec.TabIndex = 210
			Me.chkRodstarPumpTypeRec.Text = "Use XROD-V Recommendation"
			Dim chkTubingPump As Global.System.Windows.Forms.Control = Me.chkTubingPump
			location = New Global.System.Drawing.Point(72, 64)
			chkTubingPump.Location = location
			Me.chkTubingPump.Name = "chkTubingPump"
			Dim chkTubingPump2 As Global.System.Windows.Forms.Control = Me.chkTubingPump
			size = New Global.System.Drawing.Size(144, 20)
			chkTubingPump2.Size = size
			Me.chkTubingPump.TabIndex = 208
			Me.chkTubingPump.Text = " Tubing pump"
			Dim chkLargeBorePump As Global.System.Windows.Forms.Control = Me.chkLargeBorePump
			location = New Global.System.Drawing.Point(72, 80)
			chkLargeBorePump.Location = location
			Me.chkLargeBorePump.Name = "chkLargeBorePump"
			Dim chkLargeBorePump2 As Global.System.Windows.Forms.Control = Me.chkLargeBorePump
			size = New Global.System.Drawing.Size(144, 20)
			chkLargeBorePump2.Size = size
			Me.chkLargeBorePump.TabIndex = 209
			Me.chkLargeBorePump.Text = " Large bore pump"
			Me.lblchkTubingPump_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblchkTubingPump_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblchkTubingPump_Disabled.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim lblchkTubingPump_Disabled As Global.System.Windows.Forms.Control = Me.lblchkTubingPump_Disabled
			location = New Global.System.Drawing.Point(72, 64)
			lblchkTubingPump_Disabled.Location = location
			Me.lblchkTubingPump_Disabled.Name = "lblchkTubingPump_Disabled"
			Dim lblchkTubingPump_Disabled2 As Global.System.Windows.Forms.Control = Me.lblchkTubingPump_Disabled
			size = New Global.System.Drawing.Size(144, 20)
			lblchkTubingPump_Disabled2.Size = size
			Me.lblchkTubingPump_Disabled.TabIndex = 222
			Me.lblchkLargeBorePump_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblchkLargeBorePump_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblchkLargeBorePump_Disabled.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim lblchkLargeBorePump_Disabled As Global.System.Windows.Forms.Control = Me.lblchkLargeBorePump_Disabled
			location = New Global.System.Drawing.Point(72, 80)
			lblchkLargeBorePump_Disabled.Location = location
			Me.lblchkLargeBorePump_Disabled.Name = "lblchkLargeBorePump_Disabled"
			Dim lblchkLargeBorePump_Disabled2 As Global.System.Windows.Forms.Control = Me.lblchkLargeBorePump_Disabled
			size = New Global.System.Drawing.Size(144, 20)
			lblchkLargeBorePump_Disabled2.Size = size
			Me.lblchkLargeBorePump_Disabled.TabIndex = 223
			Me.lblchkInsertPump_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblchkInsertPump_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblchkInsertPump_Disabled.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim lblchkInsertPump_Disabled As Global.System.Windows.Forms.Control = Me.lblchkInsertPump_Disabled
			location = New Global.System.Drawing.Point(72, 48)
			lblchkInsertPump_Disabled.Location = location
			Me.lblchkInsertPump_Disabled.Name = "lblchkInsertPump_Disabled"
			Dim lblchkInsertPump_Disabled2 As Global.System.Windows.Forms.Control = Me.lblchkInsertPump_Disabled
			size = New Global.System.Drawing.Size(144, 20)
			lblchkInsertPump_Disabled2.Size = size
			Me.lblchkInsertPump_Disabled.TabIndex = 221
			Me.grpTubingAnchoredPreference.Controls.Add(Me.chkRodstarTubingAnchoredRec)
			Me.grpTubingAnchoredPreference.Controls.Add(Me.chkTubingAnchored)
			Me.grpTubingAnchoredPreference.Controls.Add(Me.lblchkTubingAnchored_Disabled)
			Me.grpTubingAnchoredPreference.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim grpTubingAnchoredPreference As Global.System.Windows.Forms.Control = Me.grpTubingAnchoredPreference
			location = New Global.System.Drawing.Point(384, 757)
			grpTubingAnchoredPreference.Location = location
			Me.grpTubingAnchoredPreference.Name = "grpTubingAnchoredPreference"
			Dim grpTubingAnchoredPreference2 As Global.System.Windows.Forms.Control = Me.grpTubingAnchoredPreference
			size = New Global.System.Drawing.Size(272, 79)
			grpTubingAnchoredPreference2.Size = size
			Me.grpTubingAnchoredPreference.TabIndex = 205
			Me.grpTubingAnchoredPreference.TabStop = False
			Me.grpTubingAnchoredPreference.Text = "Tubing Anchored Preference"
			Me.grpTubingAnchoredPreference.Visible = False
			Me.chkRodstarTubingAnchoredRec.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkRodstarTubingAnchoredRec.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkRodstarTubingAnchoredRec As Global.System.Windows.Forms.Control = Me.chkRodstarTubingAnchoredRec
			location = New Global.System.Drawing.Point(16, 24)
			chkRodstarTubingAnchoredRec.Location = location
			Me.chkRodstarTubingAnchoredRec.Name = "chkRodstarTubingAnchoredRec"
			Me.HelpProvider1.SetShowHelp(Me.chkRodstarTubingAnchoredRec, False)
			Dim chkRodstarTubingAnchoredRec2 As Global.System.Windows.Forms.Control = Me.chkRodstarTubingAnchoredRec
			size = New Global.System.Drawing.Size(248, 19)
			chkRodstarTubingAnchoredRec2.Size = size
			Me.chkRodstarTubingAnchoredRec.TabIndex = 210
			Me.chkRodstarTubingAnchoredRec.Text = "Use XROD-V Recommendation"
			Me.chkTubingAnchored.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim chkTubingAnchored As Global.System.Windows.Forms.Control = Me.chkTubingAnchored
			location = New Global.System.Drawing.Point(62, 48)
			chkTubingAnchored.Location = location
			Me.chkTubingAnchored.Name = "chkTubingAnchored"
			Dim chkTubingAnchored2 As Global.System.Windows.Forms.Control = Me.chkTubingAnchored
			size = New Global.System.Drawing.Size(144, 20)
			chkTubingAnchored2.Size = size
			Me.chkTubingAnchored.TabIndex = 207
			Me.chkTubingAnchored.Text = "Tubing Anchored"
			Me.lblchkTubingAnchored_Disabled.BackColor = Global.System.Drawing.Color.LightGray
			Me.lblchkTubingAnchored_Disabled.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblchkTubingAnchored_Disabled.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim lblchkTubingAnchored_Disabled As Global.System.Windows.Forms.Control = Me.lblchkTubingAnchored_Disabled
			location = New Global.System.Drawing.Point(62, 48)
			lblchkTubingAnchored_Disabled.Location = location
			Me.lblchkTubingAnchored_Disabled.Name = "lblchkTubingAnchored_Disabled"
			Dim lblchkTubingAnchored_Disabled2 As Global.System.Windows.Forms.Control = Me.lblchkTubingAnchored_Disabled
			size = New Global.System.Drawing.Size(144, 20)
			lblchkTubingAnchored_Disabled2.Size = size
			Me.lblchkTubingAnchored_Disabled.TabIndex = 221
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.pnlUseGeneral)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.chkAIUseCustomizedLists)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.chkManufacturer8)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.chkManufacturer7)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.chkManufacturer6)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.chkManufacturer5)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.chkManufacturer4)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.chkManufacturer3)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.chkManufacturer2)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.lblManufacturer8)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.lblManufacturer7)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.lblManufacturer6)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.lblManufacturer5)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.cboManufMenu8)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.cboManufMenu7)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.cboManufMenu6)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.cboManufMenu5)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.lblManufacturer4)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.lblManufacturer3)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.lblManufacturer2)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.cboManufMenu4)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.cboManufMenu3)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.cboManufMenu2)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.cboManufMenu1)
			Me.grpPumpUnitManufacturer_Preferences.Controls.Add(Me.chkManufacturer1)
			Me.grpPumpUnitManufacturer_Preferences.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Dim grpPumpUnitManufacturer_Preferences As Global.System.Windows.Forms.Control = Me.grpPumpUnitManufacturer_Preferences
			location = New Global.System.Drawing.Point(2, 224)
			grpPumpUnitManufacturer_Preferences.Location = location
			Me.grpPumpUnitManufacturer_Preferences.Name = "grpPumpUnitManufacturer_Preferences"
			Dim grpPumpUnitManufacturer_Preferences2 As Global.System.Windows.Forms.Control = Me.grpPumpUnitManufacturer_Preferences
			size = New Global.System.Drawing.Size(698, 248)
			grpPumpUnitManufacturer_Preferences2.Size = size
			Me.grpPumpUnitManufacturer_Preferences.TabIndex = 203
			Me.grpPumpUnitManufacturer_Preferences.TabStop = False
			Me.grpPumpUnitManufacturer_Preferences.Text = "Pumping Unit Manufacturer Preferences"
			Me.pnlUseGeneral.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.pnlUseGeneral.Controls.Add(Me.chkUseGeneral)
			Me.pnlUseGeneral.Controls.Add(Me.chkUseClosestUnit)
			Dim pnlUseGeneral As Global.System.Windows.Forms.Control = Me.pnlUseGeneral
			location = New Global.System.Drawing.Point(236, 15)
			pnlUseGeneral.Location = location
			Me.pnlUseGeneral.Name = "pnlUseGeneral"
			Dim pnlUseGeneral2 As Global.System.Windows.Forms.Control = Me.pnlUseGeneral
			size = New Global.System.Drawing.Size(437, 29)
			pnlUseGeneral2.Size = size
			Me.pnlUseGeneral.TabIndex = 231
			Me.pnlUseGeneral.Visible = False
			Me.HelpProvider1.SetHelpKeyword(Me.chkUseGeneral, "AI Preferences: Use Customized Pumping Units Lists")
			Me.HelpProvider1.SetHelpNavigator(Me.chkUseGeneral, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim chkUseGeneral As Global.System.Windows.Forms.Control = Me.chkUseGeneral
			location = New Global.System.Drawing.Point(3, 3)
			chkUseGeneral.Location = location
			Me.chkUseGeneral.Name = "chkUseGeneral"
			Me.HelpProvider1.SetShowHelp(Me.chkUseGeneral, True)
			Dim chkUseGeneral2 As Global.System.Windows.Forms.Control = Me.chkUseGeneral
			size = New Global.System.Drawing.Size(175, 23)
			chkUseGeneral2.Size = size
			Me.chkUseGeneral.TabIndex = 230
			Me.chkUseGeneral.Text = "Use general list if needed"
			Me.HelpProvider1.SetHelpKeyword(Me.chkUseClosestUnit, "AI Preferences: Use Customized Pumping Units Lists")
			Me.HelpProvider1.SetHelpNavigator(Me.chkUseClosestUnit, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim chkUseClosestUnit As Global.System.Windows.Forms.Control = Me.chkUseClosestUnit
			location = New Global.System.Drawing.Point(186, 3)
			chkUseClosestUnit.Location = location
			Me.chkUseClosestUnit.Name = "chkUseClosestUnit"
			Me.HelpProvider1.SetShowHelp(Me.chkUseClosestUnit, True)
			Dim chkUseClosestUnit2 As Global.System.Windows.Forms.Control = Me.chkUseClosestUnit
			size = New Global.System.Drawing.Size(253, 23)
			chkUseClosestUnit2.Size = size
			Me.chkUseClosestUnit.TabIndex = 231
			Me.chkUseClosestUnit.Text = "Use unit closest to recommended size"
			Me.HelpProvider1.SetHelpKeyword(Me.chkAIUseCustomizedLists, "AI Preferences: Use Customized Pumping Units Lists")
			Me.HelpProvider1.SetHelpNavigator(Me.chkAIUseCustomizedLists, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Dim chkAIUseCustomizedLists As Global.System.Windows.Forms.Control = Me.chkAIUseCustomizedLists
			location = New Global.System.Drawing.Point(10, 19)
			chkAIUseCustomizedLists.Location = location
			Me.chkAIUseCustomizedLists.Name = "chkAIUseCustomizedLists"
			Me.HelpProvider1.SetShowHelp(Me.chkAIUseCustomizedLists, True)
			Dim chkAIUseCustomizedLists2 As Global.System.Windows.Forms.Control = Me.chkAIUseCustomizedLists
			size = New Global.System.Drawing.Size(227, 25)
			chkAIUseCustomizedLists2.Size = size
			Me.chkAIUseCustomizedLists.TabIndex = 229
			Me.chkAIUseCustomizedLists.Text = "Use customized pumping unit lists"
			Me.chkManufacturer8.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkManufacturer8.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkManufacturer As Global.System.Windows.Forms.Control = Me.chkManufacturer8
			location = New Global.System.Drawing.Point(56, 216)
			chkManufacturer.Location = location
			Me.chkManufacturer8.Name = "chkManufacturer8"
			Me.HelpProvider1.SetShowHelp(Me.chkManufacturer8, False)
			Dim chkManufacturer2 As Global.System.Windows.Forms.Control = Me.chkManufacturer8
			size = New Global.System.Drawing.Size(136, 19)
			chkManufacturer2.Size = size
			Me.chkManufacturer8.TabIndex = 228
			Me.chkManufacturer8.Text = "Manufacturer #8:"
			Me.chkManufacturer8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkManufacturer7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkManufacturer7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkManufacturer3 As Global.System.Windows.Forms.Control = Me.chkManufacturer7
			location = New Global.System.Drawing.Point(56, 192)
			chkManufacturer3.Location = location
			Me.chkManufacturer7.Name = "chkManufacturer7"
			Me.HelpProvider1.SetShowHelp(Me.chkManufacturer7, False)
			Dim chkManufacturer4 As Global.System.Windows.Forms.Control = Me.chkManufacturer7
			size = New Global.System.Drawing.Size(136, 19)
			chkManufacturer4.Size = size
			Me.chkManufacturer7.TabIndex = 227
			Me.chkManufacturer7.Text = "Manufacturer #7:"
			Me.chkManufacturer7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkManufacturer6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkManufacturer6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkManufacturer5 As Global.System.Windows.Forms.Control = Me.chkManufacturer6
			location = New Global.System.Drawing.Point(56, 168)
			chkManufacturer5.Location = location
			Me.chkManufacturer6.Name = "chkManufacturer6"
			Me.HelpProvider1.SetShowHelp(Me.chkManufacturer6, False)
			Dim chkManufacturer6 As Global.System.Windows.Forms.Control = Me.chkManufacturer6
			size = New Global.System.Drawing.Size(136, 19)
			chkManufacturer6.Size = size
			Me.chkManufacturer6.TabIndex = 226
			Me.chkManufacturer6.Text = "Manufacturer #6:"
			Me.chkManufacturer6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkManufacturer5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkManufacturer5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkManufacturer7 As Global.System.Windows.Forms.Control = Me.chkManufacturer5
			location = New Global.System.Drawing.Point(56, 144)
			chkManufacturer7.Location = location
			Me.chkManufacturer5.Name = "chkManufacturer5"
			Me.HelpProvider1.SetShowHelp(Me.chkManufacturer5, False)
			Dim chkManufacturer8 As Global.System.Windows.Forms.Control = Me.chkManufacturer5
			size = New Global.System.Drawing.Size(136, 19)
			chkManufacturer8.Size = size
			Me.chkManufacturer5.TabIndex = 225
			Me.chkManufacturer5.Text = "Manufacturer #5:"
			Me.chkManufacturer5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkManufacturer4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkManufacturer4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkManufacturer9 As Global.System.Windows.Forms.Control = Me.chkManufacturer4
			location = New Global.System.Drawing.Point(56, 120)
			chkManufacturer9.Location = location
			Me.chkManufacturer4.Name = "chkManufacturer4"
			Me.HelpProvider1.SetShowHelp(Me.chkManufacturer4, False)
			Dim chkManufacturer10 As Global.System.Windows.Forms.Control = Me.chkManufacturer4
			size = New Global.System.Drawing.Size(136, 19)
			chkManufacturer10.Size = size
			Me.chkManufacturer4.TabIndex = 224
			Me.chkManufacturer4.Text = "Manufacturer #4:"
			Me.chkManufacturer4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkManufacturer3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkManufacturer3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkManufacturer11 As Global.System.Windows.Forms.Control = Me.chkManufacturer3
			location = New Global.System.Drawing.Point(56, 96)
			chkManufacturer11.Location = location
			Me.chkManufacturer3.Name = "chkManufacturer3"
			Me.HelpProvider1.SetShowHelp(Me.chkManufacturer3, False)
			Dim chkManufacturer12 As Global.System.Windows.Forms.Control = Me.chkManufacturer3
			size = New Global.System.Drawing.Size(136, 19)
			chkManufacturer12.Size = size
			Me.chkManufacturer3.TabIndex = 223
			Me.chkManufacturer3.Text = "Manufacturer #3:"
			Me.chkManufacturer3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.chkManufacturer2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkManufacturer2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkManufacturer13 As Global.System.Windows.Forms.Control = Me.chkManufacturer2
			location = New Global.System.Drawing.Point(56, 72)
			chkManufacturer13.Location = location
			Me.chkManufacturer2.Name = "chkManufacturer2"
			Me.HelpProvider1.SetShowHelp(Me.chkManufacturer2, False)
			Dim chkManufacturer14 As Global.System.Windows.Forms.Control = Me.chkManufacturer2
			size = New Global.System.Drawing.Size(136, 19)
			chkManufacturer14.Size = size
			Me.chkManufacturer2.TabIndex = 222
			Me.chkManufacturer2.Text = "Manufacturer #2:"
			Me.chkManufacturer2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.lblManufacturer8.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblManufacturer8.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblManufacturer8.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblManufacturer8.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblManufacturer8.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblManufacturer As Global.System.Windows.Forms.Control = Me.lblManufacturer8
			location = New Global.System.Drawing.Point(56, 216)
			lblManufacturer.Location = location
			Me.lblManufacturer8.Name = "lblManufacturer8"
			Me.lblManufacturer8.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblManufacturer8, False)
			Dim lblManufacturer2 As Global.System.Windows.Forms.Control = Me.lblManufacturer8
			size = New Global.System.Drawing.Size(136, 19)
			lblManufacturer2.Size = size
			Me.lblManufacturer8.TabIndex = 56
			Me.lblManufacturer8.Text = "Manufacturer #8:"
			Me.lblManufacturer8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.lblManufacturer7.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblManufacturer7.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblManufacturer7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblManufacturer7.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblManufacturer7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblManufacturer3 As Global.System.Windows.Forms.Control = Me.lblManufacturer7
			location = New Global.System.Drawing.Point(56, 192)
			lblManufacturer3.Location = location
			Me.lblManufacturer7.Name = "lblManufacturer7"
			Me.lblManufacturer7.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblManufacturer7, False)
			Dim lblManufacturer4 As Global.System.Windows.Forms.Control = Me.lblManufacturer7
			size = New Global.System.Drawing.Size(136, 19)
			lblManufacturer4.Size = size
			Me.lblManufacturer7.TabIndex = 54
			Me.lblManufacturer7.Text = "Manufacturer #7:"
			Me.lblManufacturer7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.lblManufacturer6.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblManufacturer6.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblManufacturer6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblManufacturer6.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblManufacturer6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblManufacturer5 As Global.System.Windows.Forms.Control = Me.lblManufacturer6
			location = New Global.System.Drawing.Point(56, 168)
			lblManufacturer5.Location = location
			Me.lblManufacturer6.Name = "lblManufacturer6"
			Me.lblManufacturer6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblManufacturer6, False)
			Dim lblManufacturer6 As Global.System.Windows.Forms.Control = Me.lblManufacturer6
			size = New Global.System.Drawing.Size(136, 19)
			lblManufacturer6.Size = size
			Me.lblManufacturer6.TabIndex = 52
			Me.lblManufacturer6.Text = "Manufacturer #6:"
			Me.lblManufacturer6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.lblManufacturer5.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblManufacturer5.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblManufacturer5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblManufacturer5.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblManufacturer5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblManufacturer7 As Global.System.Windows.Forms.Control = Me.lblManufacturer5
			location = New Global.System.Drawing.Point(56, 144)
			lblManufacturer7.Location = location
			Me.lblManufacturer5.Name = "lblManufacturer5"
			Me.lblManufacturer5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblManufacturer5, False)
			Dim lblManufacturer8 As Global.System.Windows.Forms.Control = Me.lblManufacturer5
			size = New Global.System.Drawing.Size(136, 19)
			lblManufacturer8.Size = size
			Me.lblManufacturer5.TabIndex = 50
			Me.lblManufacturer5.Text = "Manufacturer #5:"
			Me.lblManufacturer5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.cboManufMenu8.BackColor = Global.System.Drawing.Color.White
			Me.cboManufMenu8.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboManufMenu8.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboManufMenu8.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboManufMenu8.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboManufMenu8, "pumping unit manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboManufMenu8, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboManufMenu8.ItemHeight = 16
			Dim cboManufMenu As Global.System.Windows.Forms.Control = Me.cboManufMenu8
			location = New Global.System.Drawing.Point(200, 216)
			cboManufMenu.Location = location
			Me.cboManufMenu8.Name = "cboManufMenu8"
			Me.cboManufMenu8.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboManufMenu8, True)
			Dim cboManufMenu2 As Global.System.Windows.Forms.Control = Me.cboManufMenu8
			size = New Global.System.Drawing.Size(384, 24)
			cboManufMenu2.Size = size
			Me.cboManufMenu8.TabIndex = 55
			Me.cboManufMenu7.BackColor = Global.System.Drawing.Color.White
			Me.cboManufMenu7.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboManufMenu7.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboManufMenu7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboManufMenu7.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboManufMenu7, "pumping unit manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboManufMenu7, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboManufMenu7.ItemHeight = 16
			Dim cboManufMenu3 As Global.System.Windows.Forms.Control = Me.cboManufMenu7
			location = New Global.System.Drawing.Point(200, 192)
			cboManufMenu3.Location = location
			Me.cboManufMenu7.Name = "cboManufMenu7"
			Me.cboManufMenu7.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboManufMenu7, True)
			Dim cboManufMenu4 As Global.System.Windows.Forms.Control = Me.cboManufMenu7
			size = New Global.System.Drawing.Size(384, 24)
			cboManufMenu4.Size = size
			Me.cboManufMenu7.TabIndex = 53
			Me.cboManufMenu6.BackColor = Global.System.Drawing.Color.White
			Me.cboManufMenu6.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboManufMenu6.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboManufMenu6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboManufMenu6.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboManufMenu6, "pumping unit manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboManufMenu6, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboManufMenu6.ItemHeight = 16
			Dim cboManufMenu5 As Global.System.Windows.Forms.Control = Me.cboManufMenu6
			location = New Global.System.Drawing.Point(200, 168)
			cboManufMenu5.Location = location
			Me.cboManufMenu6.Name = "cboManufMenu6"
			Me.cboManufMenu6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboManufMenu6, True)
			Dim cboManufMenu6 As Global.System.Windows.Forms.Control = Me.cboManufMenu6
			size = New Global.System.Drawing.Size(384, 24)
			cboManufMenu6.Size = size
			Me.cboManufMenu6.TabIndex = 51
			Me.cboManufMenu5.BackColor = Global.System.Drawing.Color.White
			Me.cboManufMenu5.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboManufMenu5.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboManufMenu5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboManufMenu5.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboManufMenu5, "pumping unit manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboManufMenu5, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboManufMenu5.ItemHeight = 16
			Dim cboManufMenu7 As Global.System.Windows.Forms.Control = Me.cboManufMenu5
			location = New Global.System.Drawing.Point(200, 144)
			cboManufMenu7.Location = location
			Me.cboManufMenu5.Name = "cboManufMenu5"
			Me.cboManufMenu5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboManufMenu5, True)
			Dim cboManufMenu8 As Global.System.Windows.Forms.Control = Me.cboManufMenu5
			size = New Global.System.Drawing.Size(384, 24)
			cboManufMenu8.Size = size
			Me.cboManufMenu5.TabIndex = 49
			Me.lblManufacturer4.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblManufacturer4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblManufacturer4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblManufacturer4.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblManufacturer4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblManufacturer9 As Global.System.Windows.Forms.Control = Me.lblManufacturer4
			location = New Global.System.Drawing.Point(56, 120)
			lblManufacturer9.Location = location
			Me.lblManufacturer4.Name = "lblManufacturer4"
			Me.lblManufacturer4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblManufacturer4, False)
			Dim lblManufacturer10 As Global.System.Windows.Forms.Control = Me.lblManufacturer4
			size = New Global.System.Drawing.Size(136, 19)
			lblManufacturer10.Size = size
			Me.lblManufacturer4.TabIndex = 48
			Me.lblManufacturer4.Text = "Manufacturer #4:"
			Me.lblManufacturer4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.lblManufacturer3.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblManufacturer3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblManufacturer3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblManufacturer3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblManufacturer3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblManufacturer11 As Global.System.Windows.Forms.Control = Me.lblManufacturer3
			location = New Global.System.Drawing.Point(56, 96)
			lblManufacturer11.Location = location
			Me.lblManufacturer3.Name = "lblManufacturer3"
			Me.lblManufacturer3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblManufacturer3, False)
			Dim lblManufacturer12 As Global.System.Windows.Forms.Control = Me.lblManufacturer3
			size = New Global.System.Drawing.Size(136, 19)
			lblManufacturer12.Size = size
			Me.lblManufacturer3.TabIndex = 46
			Me.lblManufacturer3.Text = "Manufacturer #3:"
			Me.lblManufacturer3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.lblManufacturer2.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblManufacturer2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblManufacturer2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblManufacturer2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblManufacturer2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblManufacturer13 As Global.System.Windows.Forms.Control = Me.lblManufacturer2
			location = New Global.System.Drawing.Point(56, 72)
			lblManufacturer13.Location = location
			Me.lblManufacturer2.Name = "lblManufacturer2"
			Me.lblManufacturer2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lblManufacturer2, False)
			Dim lblManufacturer14 As Global.System.Windows.Forms.Control = Me.lblManufacturer2
			size = New Global.System.Drawing.Size(136, 19)
			lblManufacturer14.Size = size
			Me.lblManufacturer2.TabIndex = 44
			Me.lblManufacturer2.Text = "Manufacturer #2:"
			Me.lblManufacturer2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.cboManufMenu4.BackColor = Global.System.Drawing.Color.White
			Me.cboManufMenu4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboManufMenu4.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboManufMenu4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboManufMenu4.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboManufMenu4, "pumping unit manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboManufMenu4, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboManufMenu4.ItemHeight = 16
			Dim cboManufMenu9 As Global.System.Windows.Forms.Control = Me.cboManufMenu4
			location = New Global.System.Drawing.Point(200, 120)
			cboManufMenu9.Location = location
			Me.cboManufMenu4.Name = "cboManufMenu4"
			Me.cboManufMenu4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboManufMenu4, True)
			Dim cboManufMenu10 As Global.System.Windows.Forms.Control = Me.cboManufMenu4
			size = New Global.System.Drawing.Size(384, 24)
			cboManufMenu10.Size = size
			Me.cboManufMenu4.TabIndex = 47
			Me.cboManufMenu3.BackColor = Global.System.Drawing.Color.White
			Me.cboManufMenu3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboManufMenu3.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboManufMenu3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboManufMenu3.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboManufMenu3, "pumping unit manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboManufMenu3, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboManufMenu3.ItemHeight = 16
			Dim cboManufMenu11 As Global.System.Windows.Forms.Control = Me.cboManufMenu3
			location = New Global.System.Drawing.Point(200, 96)
			cboManufMenu11.Location = location
			Me.cboManufMenu3.Name = "cboManufMenu3"
			Me.cboManufMenu3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboManufMenu3, True)
			Dim cboManufMenu12 As Global.System.Windows.Forms.Control = Me.cboManufMenu3
			size = New Global.System.Drawing.Size(384, 24)
			cboManufMenu12.Size = size
			Me.cboManufMenu3.TabIndex = 45
			Me.cboManufMenu2.BackColor = Global.System.Drawing.Color.White
			Me.cboManufMenu2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboManufMenu2.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboManufMenu2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboManufMenu2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboManufMenu2, "pumping unit manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboManufMenu2, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboManufMenu2.ItemHeight = 16
			Dim cboManufMenu13 As Global.System.Windows.Forms.Control = Me.cboManufMenu2
			location = New Global.System.Drawing.Point(200, 72)
			cboManufMenu13.Location = location
			Me.cboManufMenu2.Name = "cboManufMenu2"
			Me.cboManufMenu2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboManufMenu2, True)
			Dim cboManufMenu14 As Global.System.Windows.Forms.Control = Me.cboManufMenu2
			size = New Global.System.Drawing.Size(384, 24)
			cboManufMenu14.Size = size
			Me.cboManufMenu2.TabIndex = 43
			Me.cboManufMenu1.BackColor = Global.System.Drawing.Color.White
			Me.cboManufMenu1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboManufMenu1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboManufMenu1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.cboManufMenu1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboManufMenu1, "pumping unit manufacturer")
			Me.HelpProvider1.SetHelpNavigator(Me.cboManufMenu1, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboManufMenu1.ItemHeight = 16
			Dim cboManufMenu15 As Global.System.Windows.Forms.Control = Me.cboManufMenu1
			location = New Global.System.Drawing.Point(200, 48)
			cboManufMenu15.Location = location
			Me.cboManufMenu1.Name = "cboManufMenu1"
			Me.cboManufMenu1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboManufMenu1, True)
			Dim cboManufMenu16 As Global.System.Windows.Forms.Control = Me.cboManufMenu1
			size = New Global.System.Drawing.Size(384, 24)
			cboManufMenu16.Size = size
			Me.cboManufMenu1.TabIndex = 41
			Me.chkManufacturer1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.chkManufacturer1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkManufacturer15 As Global.System.Windows.Forms.Control = Me.chkManufacturer1
			location = New Global.System.Drawing.Point(56, 48)
			chkManufacturer15.Location = location
			Me.chkManufacturer1.Name = "chkManufacturer1"
			Me.HelpProvider1.SetShowHelp(Me.chkManufacturer1, False)
			Dim chkManufacturer16 As Global.System.Windows.Forms.Control = Me.chkManufacturer1
			size = New Global.System.Drawing.Size(136, 19)
			chkManufacturer16.Size = size
			Me.chkManufacturer1.TabIndex = 221
			Me.chkManufacturer1.Text = "Manufacturer #1:"
			Me.chkManufacturer1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.rbtUseTemplateFiles.BackColor = Global.System.Drawing.SystemColors.Control
			Me.rbtUseTemplateFiles.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.rbtUseTemplateFiles.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.rbtUseTemplateFiles.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.rbtUseTemplateFiles.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtUseTemplateFiles As Global.System.Windows.Forms.Control = Me.rbtUseTemplateFiles
			location = New Global.System.Drawing.Point(56, 47)
			rbtUseTemplateFiles.Location = location
			Me.rbtUseTemplateFiles.Name = "rbtUseTemplateFiles"
			Me.rbtUseTemplateFiles.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.rbtUseTemplateFiles, False)
			Dim rbtUseTemplateFiles2 As Global.System.Windows.Forms.Control = Me.rbtUseTemplateFiles
			size = New Global.System.Drawing.Size(312, 19)
			rbtUseTemplateFiles2.Size = size
			Me.rbtUseTemplateFiles.TabIndex = 217
			Me.rbtUseTemplateFiles.Text = "Use Template RSVX Files"
			Me.rbtUseTemplateFiles.UseVisualStyleBackColor = False
			Me.rbtUseTemplateDatabase.BackColor = Global.System.Drawing.SystemColors.Control
			Me.rbtUseTemplateDatabase.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.rbtUseTemplateDatabase.Font = New Global.System.Drawing.Font("Arial", 9.75F)
			Me.rbtUseTemplateDatabase.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.rbtUseTemplateDatabase.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rbtUseTemplateDatabase As Global.System.Windows.Forms.Control = Me.rbtUseTemplateDatabase
			location = New Global.System.Drawing.Point(56, 23)
			rbtUseTemplateDatabase.Location = location
			Me.rbtUseTemplateDatabase.Name = "rbtUseTemplateDatabase"
			Me.rbtUseTemplateDatabase.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.rbtUseTemplateDatabase, False)
			Dim rbtUseTemplateDatabase2 As Global.System.Windows.Forms.Control = Me.rbtUseTemplateDatabase
			size = New Global.System.Drawing.Size(312, 19)
			rbtUseTemplateDatabase2.Size = size
			Me.rbtUseTemplateDatabase.TabIndex = 216
			Me.rbtUseTemplateDatabase.Text = "Use Template Database"
			Me.rbtUseTemplateDatabase.UseVisualStyleBackColor = False
			Me.TreeView2.Indent = 19
			Me.TreeView2.ItemHeight = 16
			Dim treeView As Global.System.Windows.Forms.Control = Me.TreeView2
			location = New Global.System.Drawing.Point(8, 16)
			treeView.Location = location
			Me.TreeView2.Name = "TreeView2"
			Me.HelpProvider1.SetShowHelp(Me.TreeView2, False)
			Dim treeView2 As Global.System.Windows.Forms.Control = Me.TreeView2
			size = New Global.System.Drawing.Size(170, 304)
			treeView2.Size = size
			Me.TreeView2.TabIndex = 98
			Me.pnlAdmin.Controls.Add(Me.lblStatus2)
			Me.pnlAdmin.Controls.Add(Me.grpGuruAdmin)
			Dim pnlAdmin As Global.System.Windows.Forms.Control = Me.pnlAdmin
			location = New Global.System.Drawing.Point(-1333, 2)
			pnlAdmin.Location = location
			Me.pnlAdmin.Name = "pnlAdmin"
			Dim pnlAdmin2 As Global.System.Windows.Forms.Control = Me.pnlAdmin
			size = New Global.System.Drawing.Size(690, 261)
			pnlAdmin2.Size = size
			Me.pnlAdmin.TabIndex = 97
			Me.lblStatus2.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.lblStatus2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblStatus2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim lblStatus3 As Global.System.Windows.Forms.Control = Me.lblStatus2
			location = New Global.System.Drawing.Point(0, 245)
			lblStatus3.Location = location
			Me.lblStatus2.Name = "lblStatus2"
			Dim lblStatus4 As Global.System.Windows.Forms.Control = Me.lblStatus2
			size = New Global.System.Drawing.Size(690, 16)
			lblStatus4.Size = size
			Me.lblStatus2.TabIndex = 210
			Me.grpGuruAdmin.Controls.Add(Me.chkDebug)
			Me.grpGuruAdmin.Controls.Add(Me.btnDiplayAllTemplates)
			Me.grpGuruAdmin.Controls.Add(Me.rbtUseTemplateFiles)
			Me.grpGuruAdmin.Controls.Add(Me.rbtUseTemplateDatabase)
			Me.grpGuruAdmin.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim grpGuruAdmin As Global.System.Windows.Forms.Control = Me.grpGuruAdmin
			location = New Global.System.Drawing.Point(11, 10)
			grpGuruAdmin.Location = location
			Me.grpGuruAdmin.Name = "grpGuruAdmin"
			Dim grpGuruAdmin2 As Global.System.Windows.Forms.Control = Me.grpGuruAdmin
			size = New Global.System.Drawing.Size(666, 183)
			grpGuruAdmin2.Size = size
			Me.grpGuruAdmin.TabIndex = 207
			Me.grpGuruAdmin.TabStop = False
			Me.grpGuruAdmin.Text = "Guru Admin"
			Dim chkDebug As Global.System.Windows.Forms.Control = Me.chkDebug
			location = New Global.System.Drawing.Point(56, 132)
			chkDebug.Location = location
			Me.chkDebug.Name = "chkDebug"
			Dim chkDebug2 As Global.System.Windows.Forms.Control = Me.chkDebug
			size = New Global.System.Drawing.Size(335, 23)
			chkDebug2.Size = size
			Me.chkDebug.TabIndex = 219
			Me.chkDebug.Text = "Write Debug Entries to Batch Log"
			Dim btnDiplayAllTemplates As Global.System.Windows.Forms.Control = Me.btnDiplayAllTemplates
			location = New Global.System.Drawing.Point(56, 83)
			btnDiplayAllTemplates.Location = location
			Me.btnDiplayAllTemplates.Name = "btnDiplayAllTemplates"
			Dim btnDiplayAllTemplates2 As Global.System.Windows.Forms.Control = Me.btnDiplayAllTemplates
			size = New Global.System.Drawing.Size(191, 32)
			btnDiplayAllTemplates2.Size = size
			Me.btnDiplayAllTemplates.TabIndex = 218
			Me.btnDiplayAllTemplates.Text = "Display database templates"
			Me.tmrClock.Interval = 30000
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			Me.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			size = New Global.System.Drawing.Size(926, 584)
			Me.ClientSize = size
			Me.Controls.Add(Me.TreeView2)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnOK)
			Me.Controls.Add(Me.pnlAdmin)
			Me.Controls.Add(Me.pnlExpert)
			Me.Controls.Add(Me.pnlCustomMeasuredPUList)
			Me.Controls.Add(Me.pnlDebugOptions)
			Me.Controls.Add(Me.pnlDebug)
			Me.Controls.Add(Me.pnlSetupCostDB)
			Me.Controls.Add(Me.pnlOutputOptions)
			Me.Controls.Add(Me.pnlCustomizeRGList)
			Me.Controls.Add(Me.pnlBatchMode)
			Me.Controls.Add(Me.pnlDefaults)
			Me.Controls.Add(Me.pnlCustomPUList)
			Me.Controls.Add(Me.pnlGeneral)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "RswinSetup"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "RODSTAR-D v1.0 Setup"
			Me.pnlGeneral.ResumeLayout(False)
			Me.grpPredictMode.ResumeLayout(False)
			Me.grpLanguages.ResumeLayout(False)
			Me.grpSystemOfUnits.ResumeLayout(False)
			Me.grpPreferences.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			CType(Me.udMin, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.udHour, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.udSec_notused, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.grpUseServerDatabase.ResumeLayout(False)
			Me.grpUseServerDatabase.PerformLayout()
			Me.grpRodElement.ResumeLayout(False)
			Me.grpRodElement.PerformLayout()
			Me.pnlDefaults.ResumeLayout(False)
			Me.pnlDefaults.PerformLayout()
			Me._SSFrame_8.ResumeLayout(False)
			Me._SSFrame_8.PerformLayout()
			Me.grpWarnings.ResumeLayout(False)
			Me.grpRatio.ResumeLayout(False)
			Me.grpRatio.PerformLayout()
			Me._SSFrame_3.ResumeLayout(False)
			Me._SSFrame_3.PerformLayout()
			Me.pnlBatchMode.ResumeLayout(False)
			Me.grpAutomaticBatchMode.ResumeLayout(False)
			Me.grpAutomaticBatchMode.PerformLayout()
			CType(Me.nmUDMinute, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nmUDHour, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.grpSpreadSheetSetup.ResumeLayout(False)
			Me.pnlCustomizeRGList.ResumeLayout(False)
			Me.pnlOutputOptions.ResumeLayout(False)
			Me.grpOutputOptions.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me.SSPanel.ResumeLayout(False)
			CType(Me.imgPreview_10, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_9, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_6, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_3, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_5, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_0, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgPreview_1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.grpOutputPages.ResumeLayout(False)
			Me.pnlDebug.ResumeLayout(False)
			Me.pnlDebug.PerformLayout()
			Me.pnlCustomPUList.ResumeLayout(False)
			Me.pnlCustomPUList.PerformLayout()
			Me.pnlCustomMeasuredPUList.ResumeLayout(False)
			Me.pnlDebugOptions.ResumeLayout(False)
			Me.grpDebugOpt.ResumeLayout(False)
			Me.grpDebugOpt.PerformLayout()
			Me.pnlSetupCostDB.ResumeLayout(False)
			Me.panContainer.ResumeLayout(False)
			Me._panCostCategory_1.ResumeLayout(False)
			Me._panCostCategory_0.ResumeLayout(False)
			Me.pnlPUCostDB.ResumeLayout(False)
			CType(Me.ulgPUCostDB, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlGuideCostDB.ResumeLayout(False)
			CType(Me.ulgGuideCostDB, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlRSCostDB.ResumeLayout(False)
			CType(Me.ulgRSCostDB, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlExpert.ResumeLayout(False)
			Me.grpTubingSizePreferences.ResumeLayout(False)
			Me.grpTubingSizePreferences.PerformLayout()
			Me.grpRodPreferences.ResumeLayout(False)
			Me.grpRodPreferences.PerformLayout()
			Me.pnlUseRodOnly.ResumeLayout(False)
			Me.pnlUseRodOnly.PerformLayout()
			Me.grpMotorPreferences.ResumeLayout(False)
			Me.pnlMotorData.ResumeLayout(False)
			Me.grpRodTubingFricCoeffPref.ResumeLayout(False)
			CType(Me.NumericUpDown1_XTimes, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.grpPumpTypePreference.ResumeLayout(False)
			Me.grpTubingAnchoredPreference.ResumeLayout(False)
			Me.grpPumpUnitManufacturer_Preferences.ResumeLayout(False)
			Me.pnlUseGeneral.ResumeLayout(False)
			Me.pnlAdmin.ResumeLayout(False)
			Me.grpGuruAdmin.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
