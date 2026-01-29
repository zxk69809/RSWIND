Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports ThetaStdInfo

Namespace RSWINV3
	Public Partial Class RswinSetup
		Inherits Form

		Private Overridable Property dlgPUList As dlgPUList
			Get
				Return Me._dlgPUList
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dlgPUList)
				Me._dlgPUList = value
			End Set
		End Property

		Private Overridable Property dlgCustomRG As dlgCustomRG
			Get
				Return Me._dlgCustomRG
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dlgCustomRG)
				Me._dlgCustomRG = value
			End Set
		End Property

		Private Overridable Property dlgCustomPU As dlgCustomPU
			Get
				Return Me._dlgCustomPU
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dlgCustomPU)
				Me._dlgCustomPU = value
			End Set
		End Property

		Private Overridable Property dlgWK1Setup As dlgWK1Setup
			Get
				Return Me._dlgWK1Setup
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dlgWK1Setup)
				Me._dlgWK1Setup = value
			End Set
		End Property

		Private Overridable Property dlgSelectDir As dlgSelectDir
			Get
				Return Me._dlgSelectDir
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dlgSelectDir)
				Me._dlgSelectDir = value
			End Set
		End Property

		Private Overridable Property frmDisplayAllDatabaseTemplates As db_guru_admin_form
			Get
				Return Me._frmDisplayAllDatabaseTemplates
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As db_guru_admin_form)
				Me._frmDisplayAllDatabaseTemplates = value
			End Set
		End Property

		Public Property NowTime As DateTime
			Get
				Return Me.m_NowTime
			End Get
			Set(value As DateTime)
				Me.m_NowTime = value
			End Set
		End Property

		Public Property bEnd As Boolean
			Get
				Return Me.m_bEnd
			End Get
			Set(value As Boolean)
				Me.m_bEnd = value
			End Set
		End Property

		Public Overridable Property _Label_CasingSizeOD As Label
			Get
				Return Me.__Label_CasingSizeOD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_CasingSizeOD = value
			End Set
		End Property

		Public Overridable Property cboCasingSize As ComboBox
			Get
				Return Me._cboCasingSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboCasingSize_SelectedIndexChanged
				If Me._cboCasingSize IsNot Nothing Then
					RemoveHandler Me._cboCasingSize.SelectedIndexChanged, value2
				End If
				Me._cboCasingSize = value
				If Me._cboCasingSize IsNot Nothing Then
					AddHandler Me._cboCasingSize.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblcboCasingSize_Disabled As Label
			Get
				Return Me._lblcboCasingSize_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblcboCasingSize_Disabled = value
			End Set
		End Property

		Friend Overridable Property pnlAdmin As Panel
			Get
				Return Me._pnlAdmin
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlAdmin = value
			End Set
		End Property

		Friend Overridable Property grpGuruAdmin As GroupBox
			Get
				Return Me._grpGuruAdmin
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpGuruAdmin = value
			End Set
		End Property

		Friend Overridable Property chkDebug As CheckBox
			Get
				Return Me._chkDebug
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkDebug_CheckedChanged
				If Me._chkDebug IsNot Nothing Then
					RemoveHandler Me._chkDebug.CheckedChanged, value2
				End If
				Me._chkDebug = value
				If Me._chkDebug IsNot Nothing Then
					AddHandler Me._chkDebug.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnDiplayAllTemplates As Button
			Get
				Return Me._btnDiplayAllTemplates
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button2_Click
				If Me._btnDiplayAllTemplates IsNot Nothing Then
					RemoveHandler Me._btnDiplayAllTemplates.Click, value2
				End If
				Me._btnDiplayAllTemplates = value
				If Me._btnDiplayAllTemplates IsNot Nothing Then
					AddHandler Me._btnDiplayAllTemplates.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property rbtUseTemplateFiles As RadioButton
			Get
				Return Me._rbtUseTemplateFiles
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtUseTemplateFiles_CheckedChanged
				If Me._rbtUseTemplateFiles IsNot Nothing Then
					RemoveHandler Me._rbtUseTemplateFiles.CheckedChanged, value2
				End If
				Me._rbtUseTemplateFiles = value
				If Me._rbtUseTemplateFiles IsNot Nothing Then
					AddHandler Me._rbtUseTemplateFiles.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property rbtUseTemplateDatabase As RadioButton
			Get
				Return Me._rbtUseTemplateDatabase
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtUseTemplateDatabase_CheckedChanged
				If Me._rbtUseTemplateDatabase IsNot Nothing Then
					RemoveHandler Me._rbtUseTemplateDatabase.CheckedChanged, value2
				End If
				Me._rbtUseTemplateDatabase = value
				If Me._rbtUseTemplateDatabase IsNot Nothing Then
					AddHandler Me._rbtUseTemplateDatabase.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblStatus2 As Label
			Get
				Return Me._lblStatus2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblStatus2 = value
			End Set
		End Property

		Public Overridable Property lblCasingSize As Label
			Get
				Return Me._lblCasingSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCasingSize = value
			End Set
		End Property

		Public Overridable Property txtCasingSize As TextBox
			Get
				Return Me._txtCasingSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtCasingSize = value
			End Set
		End Property

		Friend Overridable Property TreeView2 As TreeView
			Get
				Return Me._TreeView2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TreeView)
				Dim value2 As TreeViewEventHandler = AddressOf Me.TreeView2_AfterSelect
				Dim value3 As TreeViewEventHandler = AddressOf Me.TreeView2_AfterExpand
				If Me._TreeView2 IsNot Nothing Then
					RemoveHandler Me._TreeView2.AfterSelect, value2
					RemoveHandler Me._TreeView2.AfterExpand, value3
				End If
				Me._TreeView2 = value
				If Me._TreeView2 IsNot Nothing Then
					AddHandler Me._TreeView2.AfterSelect, value2
					AddHandler Me._TreeView2.AfterExpand, value3
				End If
			End Set
		End Property

		Friend Overridable Property GroupBox1 As GroupBox
			Get
				Return Me._GroupBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		Friend Overridable Property udMin As NumericUpDown
			Get
				Return Me._udMin
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Dim value2 As EventHandler = AddressOf Me.UDMin_ValueChanged
				If Me._udMin IsNot Nothing Then
					RemoveHandler Me._udMin.ValueChanged, value2
				End If
				Me._udMin = value
				If Me._udMin IsNot Nothing Then
					AddHandler Me._udMin.ValueChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property udHour As NumericUpDown
			Get
				Return Me._udHour
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Dim value2 As EventHandler = AddressOf Me.udHour_ValueChanged
				If Me._udHour IsNot Nothing Then
					RemoveHandler Me._udHour.ValueChanged, value2
				End If
				Me._udHour = value
				If Me._udHour IsNot Nothing Then
					AddHandler Me._udHour.ValueChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblExitIfIdle As Label
			Get
				Return Me._lblExitIfIdle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblExitIfIdle = value
			End Set
		End Property

		Friend Overridable Property chkExitIfIdle As CheckBox
			Get
				Return Me._chkExitIfIdle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkExitIfIdle_CheckedChanged
				If Me._chkExitIfIdle IsNot Nothing Then
					RemoveHandler Me._chkExitIfIdle.CheckedChanged, value2
				End If
				Me._chkExitIfIdle = value
				If Me._chkExitIfIdle IsNot Nothing Then
					AddHandler Me._chkExitIfIdle.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property udSec_notused As NumericUpDown
			Get
				Return Me._udSec_notused
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._udSec_notused = value
			End Set
		End Property

		Public Overridable Property tmrClock As System.Windows.Forms.Timer
			Get
				Return Me._tmrClock
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Me._tmrClock = value
			End Set
		End Property

		Friend Overridable Property chkSaveOpenFileOnExit As CheckBox
			Get
				Return Me._chkSaveOpenFileOnExit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkSaveOpenFileOnExit_CheckedChanged
				If Me._chkSaveOpenFileOnExit IsNot Nothing Then
					RemoveHandler Me._chkSaveOpenFileOnExit.CheckedChanged, value2
				End If
				Me._chkSaveOpenFileOnExit = value
				If Me._chkSaveOpenFileOnExit IsNot Nothing Then
					AddHandler Me._chkSaveOpenFileOnExit.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblHRS As Label
			Get
				Return Me._lblHRS
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblHRS = value
			End Set
		End Property

		Friend Overridable Property lblMIN As Label
			Get
				Return Me._lblMIN
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMIN = value
			End Set
		End Property

		Friend Overridable Property grpRodElement As GroupBox
			Get
				Return Me._grpRodElement
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpRodElement = value
			End Set
		End Property

		Friend Overridable Property lblRodElementLimit As Label
			Get
				Return Me._lblRodElementLimit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodElementLimit = value
			End Set
		End Property

		Friend Overridable Property chkUseDefaultRodElementLimit As CheckBox
			Get
				Return Me._chkUseDefaultRodElementLimit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkUseDefaultRodElementLimit_CheckedChanged
				If Me._chkUseDefaultRodElementLimit IsNot Nothing Then
					RemoveHandler Me._chkUseDefaultRodElementLimit.CheckedChanged, value2
				End If
				Me._chkUseDefaultRodElementLimit = value
				If Me._chkUseDefaultRodElementLimit IsNot Nothing Then
					AddHandler Me._chkUseDefaultRodElementLimit.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtRodElementLimit As TextBox
			Get
				Return Me._txtRodElementLimit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtRodElementLimit_TextChanged
				If Me._txtRodElementLimit IsNot Nothing Then
					RemoveHandler Me._txtRodElementLimit.TextChanged, value2
				End If
				Me._txtRodElementLimit = value
				If Me._txtRodElementLimit IsNot Nothing Then
					AddHandler Me._txtRodElementLimit.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtMDInt As TextBox
			Get
				Return Me._txtMDInt
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMDInt_TextChanged
				If Me._txtMDInt IsNot Nothing Then
					RemoveHandler Me._txtMDInt.TextChanged, value2
				End If
				Me._txtMDInt = value
				If Me._txtMDInt IsNot Nothing Then
					AddHandler Me._txtMDInt.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lblDoglegLimit As Label
			Get
				Return Me._lblDoglegLimit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDoglegLimit = value
			End Set
		End Property

		Public Overridable Property txtDoglegLimit As TextBox
			Get
				Return Me._txtDoglegLimit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtDoglegLimit_TextChanged
				If Me._txtDoglegLimit IsNot Nothing Then
					RemoveHandler Me._txtDoglegLimit.TextChanged, value2
				End If
				Me._txtDoglegLimit = value
				If Me._txtDoglegLimit IsNot Nothing Then
					AddHandler Me._txtDoglegLimit.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lblMDInt As Label
			Get
				Return Me._lblMDInt
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMDInt = value
			End Set
		End Property

		Friend Overridable Property chkExcelInstalled As CheckBox
			Get
				Return Me._chkExcelInstalled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkExcelInstalled_CheckedChanged
				If Me._chkExcelInstalled IsNot Nothing Then
					RemoveHandler Me._chkExcelInstalled.CheckedChanged, value2
				End If
				Me._chkExcelInstalled = value
				If Me._chkExcelInstalled IsNot Nothing Then
					AddHandler Me._chkExcelInstalled.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlGuideCostDB As Panel
			Get
				Return Me._pnlGuideCostDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlGuideCostDB = value
			End Set
		End Property

		Public Overridable Property ulgGuideCostDB As UltraGrid
			Get
				Return Me._ulgGuideCostDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As CancelEventHandler = AddressOf Me.ulgGuideCostDB_BeforeEnterEditMode
				Dim value3 As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventHandler = AddressOf Me.ulgGuideCostDB_BeforeExitEditMode
				Dim value4 As EventHandler = AddressOf Me.ulgGuideCostDB_AfterEnterEditMode
				Dim value5 As CellEventHandler = AddressOf Me.ulgGuideCostDB_AfterCellUpdate
				Dim value6 As InitializeLayoutEventHandler = AddressOf Me.ulgGuideCostDB_InitializeLayout
				If Me._ulgGuideCostDB IsNot Nothing Then
					RemoveHandler Me._ulgGuideCostDB.BeforeEnterEditMode, value2
					RemoveHandler Me._ulgGuideCostDB.BeforeExitEditMode, value3
					RemoveHandler Me._ulgGuideCostDB.AfterEnterEditMode, value4
					RemoveHandler Me._ulgGuideCostDB.AfterCellUpdate, value5
					RemoveHandler Me._ulgGuideCostDB.InitializeLayout, value6
				End If
				Me._ulgGuideCostDB = value
				If Me._ulgGuideCostDB IsNot Nothing Then
					AddHandler Me._ulgGuideCostDB.BeforeEnterEditMode, value2
					AddHandler Me._ulgGuideCostDB.BeforeExitEditMode, value3
					AddHandler Me._ulgGuideCostDB.AfterEnterEditMode, value4
					AddHandler Me._ulgGuideCostDB.AfterCellUpdate, value5
					AddHandler Me._ulgGuideCostDB.InitializeLayout, value6
				End If
			End Set
		End Property

		Public Overridable Property _optCostCategory_2 As RadioButton
			Get
				Return Me.__optCostCategory_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optCostCategory_2_VisibleChanged
				Dim value3 As EventHandler = AddressOf Me._optCostCategory_2_CheckedChanged
				If Me.__optCostCategory_2 IsNot Nothing Then
					RemoveHandler Me.__optCostCategory_2.VisibleChanged, value2
					RemoveHandler Me.__optCostCategory_2.CheckedChanged, value3
				End If
				Me.__optCostCategory_2 = value
				If Me.__optCostCategory_2 IsNot Nothing Then
					AddHandler Me.__optCostCategory_2.VisibleChanged, value2
					AddHandler Me.__optCostCategory_2.CheckedChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property btnVerify As Button
			Get
				Return Me._btnVerify
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnVerify_Click
				If Me._btnVerify IsNot Nothing Then
					RemoveHandler Me._btnVerify.Click, value2
				End If
				Me._btnVerify = value
				If Me._btnVerify IsNot Nothing Then
					AddHandler Me._btnVerify.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property rbtUseBoth As RadioButton
			Get
				Return Me._rbtUseBoth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtUseBoth_CheckedChanged
				If Me._rbtUseBoth IsNot Nothing Then
					RemoveHandler Me._rbtUseBoth.CheckedChanged, value2
				End If
				Me._rbtUseBoth = value
				If Me._rbtUseBoth IsNot Nothing Then
					AddHandler Me._rbtUseBoth.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkFixTubingSize As CheckBox
			Get
				Return Me._chkFixTubingSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkFixTubingSize_CheckedChanged
				If Me._chkFixTubingSize IsNot Nothing Then
					RemoveHandler Me._chkFixTubingSize.CheckedChanged, value2
				End If
				Me._chkFixTubingSize = value
				If Me._chkFixTubingSize IsNot Nothing Then
					AddHandler Me._chkFixTubingSize.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtBareRodFricCoeff As TextBox
			Get
				Return Me._txtBareRodFricCoeff
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtBareRodFricCoeff_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtBareRodFricCoeff_Leave
				Dim value4 As EventHandler = AddressOf Me.txtBareRodFricCoeff_Enter
				If Me._txtBareRodFricCoeff IsNot Nothing Then
					RemoveHandler Me._txtBareRodFricCoeff.TextChanged, value2
					RemoveHandler Me._txtBareRodFricCoeff.Leave, value3
					RemoveHandler Me._txtBareRodFricCoeff.Enter, value4
				End If
				Me._txtBareRodFricCoeff = value
				If Me._txtBareRodFricCoeff IsNot Nothing Then
					AddHandler Me._txtBareRodFricCoeff.TextChanged, value2
					AddHandler Me._txtBareRodFricCoeff.Leave, value3
					AddHandler Me._txtBareRodFricCoeff.Enter, value4
				End If
			End Set
		End Property

		Friend Overridable Property rbtBareRod As RadioButton
			Get
				Return Me._rbtBareRod
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbtBareRod = value
			End Set
		End Property

		Friend Overridable Property lblSideLoadperRodGuide As Label
			Get
				Return Me._lblSideLoadperRodGuide
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSideLoadperRodGuide = value
			End Set
		End Property

		Friend Overridable Property cmdResetFrictions As Button
			Get
				Return Me._cmdResetFrictions
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdResetFrictions_Click
				If Me._cmdResetFrictions IsNot Nothing Then
					RemoveHandler Me._cmdResetFrictions.Click, value2
				End If
				Me._cmdResetFrictions = value
				If Me._cmdResetFrictions IsNot Nothing Then
					AddHandler Me._cmdResetFrictions.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlUseGeneral As Panel
			Get
				Return Me._pnlUseGeneral
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlUseGeneral = value
			End Set
		End Property

		Friend Overridable Property chkUseClosestUnit As CheckBox
			Get
				Return Me._chkUseClosestUnit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkUseClosestUnit_CheckedChanged
				If Me._chkUseClosestUnit IsNot Nothing Then
					RemoveHandler Me._chkUseClosestUnit.CheckedChanged, value2
				End If
				Me._chkUseClosestUnit = value
				If Me._chkUseClosestUnit IsNot Nothing Then
					AddHandler Me._chkUseClosestUnit.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkUseGeneral As CheckBox
			Get
				Return Me._chkUseGeneral
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkUseGeneral_CheckedChanged
				If Me._chkUseGeneral IsNot Nothing Then
					RemoveHandler Me._chkUseGeneral.CheckedChanged, value2
				End If
				Me._chkUseGeneral = value
				If Me._chkUseGeneral IsNot Nothing Then
					AddHandler Me._chkUseGeneral.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkCreatePDFs As CheckBox
			Get
				Return Me._chkCreatePDFs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkCreatePDFs = value
			End Set
		End Property

		Friend Overridable Property grpUseServerDatabase As GroupBox
			Get
				Return Me._grpUseServerDatabase
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpUseServerDatabase = value
			End Set
		End Property

		Friend Overridable Property rbtUseServerLocation As RadioButton
			Get
				Return Me._rbtUseServerLocation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtUseServerLocation_CheckedChanged
				If Me._rbtUseServerLocation IsNot Nothing Then
					RemoveHandler Me._rbtUseServerLocation.CheckedChanged, value2
				End If
				Me._rbtUseServerLocation = value
				If Me._rbtUseServerLocation IsNot Nothing Then
					AddHandler Me._rbtUseServerLocation.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property rptUseLocalDatabase As RadioButton
			Get
				Return Me._rptUseLocalDatabase
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rptUseLocalDatabase_CheckedChanged
				If Me._rptUseLocalDatabase IsNot Nothing Then
					RemoveHandler Me._rptUseLocalDatabase.CheckedChanged, value2
				End If
				Me._rptUseLocalDatabase = value
				If Me._rptUseLocalDatabase IsNot Nothing Then
					AddHandler Me._rptUseLocalDatabase.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtDBServerFolder As TextBox
			Get
				Return Me._txtDBServerFolder
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtDBServerFolder_TextChanged
				If Me._txtDBServerFolder IsNot Nothing Then
					RemoveHandler Me._txtDBServerFolder.TextChanged, value2
				End If
				Me._txtDBServerFolder = value
				If Me._txtDBServerFolder IsNot Nothing Then
					AddHandler Me._txtDBServerFolder.TextChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnBrowseForServerFolder As Button
			Get
				Return Me._btnBrowseForServerFolder
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnBrowseForServerFolder_Click
				If Me._btnBrowseForServerFolder IsNot Nothing Then
					RemoveHandler Me._btnBrowseForServerFolder.Click, value2
				End If
				Me._btnBrowseForServerFolder = value
				If Me._btnBrowseForServerFolder IsNot Nothing Then
					AddHandler Me._btnBrowseForServerFolder.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblDBServerFolder As Label
			Get
				Return Me._lblDBServerFolder
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDBServerFolder = value
			End Set
		End Property

		Friend Overridable Property btnVerifyFiles As Button
			Get
				Return Me._btnVerifyFiles
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnVerifyFiles_Click
				If Me._btnVerifyFiles IsNot Nothing Then
					RemoveHandler Me._btnVerifyFiles.Click, value2
				End If
				Me._btnVerifyFiles = value
				If Me._btnVerifyFiles IsNot Nothing Then
					AddHandler Me._btnVerifyFiles.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnVerifyData As Button
			Get
				Return Me._btnVerifyData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnVerifyData_Click
				If Me._btnVerifyData IsNot Nothing Then
					RemoveHandler Me._btnVerifyData.Click, value2
				End If
				Me._btnVerifyData = value
				If Me._btnVerifyData IsNot Nothing Then
					AddHandler Me._btnVerifyData.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnSynch As Button
			Get
				Return Me._btnSynch
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnSynch_Click
				If Me._btnSynch IsNot Nothing Then
					RemoveHandler Me._btnSynch.Click, value2
				End If
				Me._btnSynch = value
				If Me._btnSynch IsNot Nothing Then
					AddHandler Me._btnSynch.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtMaxSideLoadLimit As TextBox
			Get
				Return Me._txtMaxSideLoadLimit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMaxSideLoadLimit_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtMaxSideLoadLimit_Leave
				Dim value4 As EventHandler = AddressOf Me.txtMaxSideLoadLimit_Enter
				If Me._txtMaxSideLoadLimit IsNot Nothing Then
					RemoveHandler Me._txtMaxSideLoadLimit.TextChanged, value2
					RemoveHandler Me._txtMaxSideLoadLimit.Leave, value3
					RemoveHandler Me._txtMaxSideLoadLimit.Enter, value4
				End If
				Me._txtMaxSideLoadLimit = value
				If Me._txtMaxSideLoadLimit IsNot Nothing Then
					AddHandler Me._txtMaxSideLoadLimit.TextChanged, value2
					AddHandler Me._txtMaxSideLoadLimit.Leave, value3
					AddHandler Me._txtMaxSideLoadLimit.Enter, value4
				End If
			End Set
		End Property

		Friend Overridable Property lblMaxSideLoadLimit As Label
			Get
				Return Me._lblMaxSideLoadLimit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMaxSideLoadLimit = value
			End Set
		End Property

		Friend Overridable Property txtNumImplIters As TextBox
			Get
				Return Me._txtNumImplIters
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtNumImplIters_Leave
				Dim value3 As EventHandler = AddressOf Me.txtNumImplIters_Enter
				If Me._txtNumImplIters IsNot Nothing Then
					RemoveHandler Me._txtNumImplIters.Leave, value2
					RemoveHandler Me._txtNumImplIters.Enter, value3
				End If
				Me._txtNumImplIters = value
				If Me._txtNumImplIters IsNot Nothing Then
					AddHandler Me._txtNumImplIters.Leave, value2
					AddHandler Me._txtNumImplIters.Enter, value3
				End If
			End Set
		End Property

		Friend Overridable Property lblIterations As Label
			Get
				Return Me._lblIterations
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblIterations = value
			End Set
		End Property

		Friend Overridable Property txtRodGuideOverlap As TextBox
			Get
				Return Me._txtRodGuideOverlap
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtRodGuideOverlap_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtRodGuideOverlap_Leave
				Dim value4 As KeyEventHandler = AddressOf Me.txtRodGuideOverlap_KeyDown
				Dim value5 As EventHandler = AddressOf Me.txtRodGuideOverlap_Enter
				If Me._txtRodGuideOverlap IsNot Nothing Then
					RemoveHandler Me._txtRodGuideOverlap.TextChanged, value2
					RemoveHandler Me._txtRodGuideOverlap.Leave, value3
					RemoveHandler Me._txtRodGuideOverlap.KeyDown, value4
					RemoveHandler Me._txtRodGuideOverlap.Enter, value5
				End If
				Me._txtRodGuideOverlap = value
				If Me._txtRodGuideOverlap IsNot Nothing Then
					AddHandler Me._txtRodGuideOverlap.TextChanged, value2
					AddHandler Me._txtRodGuideOverlap.Leave, value3
					AddHandler Me._txtRodGuideOverlap.KeyDown, value4
					AddHandler Me._txtRodGuideOverlap.Enter, value5
				End If
			End Set
		End Property

		Friend Overridable Property lblRodGuideOverlap As Label
			Get
				Return Me._lblRodGuideOverlap
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRodGuideOverlap = value
			End Set
		End Property

		Friend Overridable Property txtNumRodsPerBundle As TextBox
			Get
				Return Me._txtNumRodsPerBundle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtNumRodsPerBundle_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtNumRodsPerBundle_SizeChanged
				Dim value4 As EventHandler = AddressOf Me.txtNumRodsPerBundle_Leave
				Dim value5 As EventHandler = AddressOf Me.txtNumRodsPerBundle_Enter
				If Me._txtNumRodsPerBundle IsNot Nothing Then
					RemoveHandler Me._txtNumRodsPerBundle.TextChanged, value2
					RemoveHandler Me._txtNumRodsPerBundle.SizeChanged, value3
					RemoveHandler Me._txtNumRodsPerBundle.Leave, value4
					RemoveHandler Me._txtNumRodsPerBundle.Enter, value5
				End If
				Me._txtNumRodsPerBundle = value
				If Me._txtNumRodsPerBundle IsNot Nothing Then
					AddHandler Me._txtNumRodsPerBundle.TextChanged, value2
					AddHandler Me._txtNumRodsPerBundle.SizeChanged, value3
					AddHandler Me._txtNumRodsPerBundle.Leave, value4
					AddHandler Me._txtNumRodsPerBundle.Enter, value5
				End If
			End Set
		End Property

		Friend Overridable Property lblNumRodsPerBundle As Label
			Get
				Return Me._lblNumRodsPerBundle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumRodsPerBundle = value
			End Set
		End Property

		Public Overridable Property lblParaffinGuides As Label
			Get
				Return Me._lblParaffinGuides
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblParaffinGuides = value
			End Set
		End Property

		Friend Overridable Property cboParaffinRodGuide As ComboBox
			Get
				Return Me._cboParaffinRodGuide
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboParaffinRodGuide_Leave
				Dim value3 As EventHandler = AddressOf Me.cboParaffinRodGuide_SelectedIndexChanged
				If Me._cboParaffinRodGuide IsNot Nothing Then
					RemoveHandler Me._cboParaffinRodGuide.Leave, value2
					RemoveHandler Me._cboParaffinRodGuide.SelectedIndexChanged, value3
				End If
				Me._cboParaffinRodGuide = value
				If Me._cboParaffinRodGuide IsNot Nothing Then
					AddHandler Me._cboParaffinRodGuide.Leave, value2
					AddHandler Me._cboParaffinRodGuide.SelectedIndexChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_10 As CheckBox
			Get
				Return Me._chkReportOpt_10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_10_Click
				If Me._chkReportOpt_10 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_10.Click, value2
				End If
				Me._chkReportOpt_10 = value
				If Me._chkReportOpt_10 IsNot Nothing Then
					AddHandler Me._chkReportOpt_10.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property imgPreview_10 As PictureBox
			Get
				Return Me._imgPreview_10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_10 = value
			End Set
		End Property

		Public Overridable Property chkRelocateSB As CheckBox
			Get
				Return Me._chkRelocateSB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkRelocateSB_CheckedChanged
				If Me._chkRelocateSB IsNot Nothing Then
					RemoveHandler Me._chkRelocateSB.CheckedChanged, value2
				End If
				Me._chkRelocateSB = value
				If Me._chkRelocateSB IsNot Nothing Then
					AddHandler Me._chkRelocateSB.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lblInclinationLimit As Label
			Get
				Return Me._lblInclinationLimit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblInclinationLimit = value
			End Set
		End Property

		Public Overridable Property txtInclinationLimit As TextBox
			Get
				Return Me._txtInclinationLimit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtInclinationLimit_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtInclinationLimit_Leave
				If Me._txtInclinationLimit IsNot Nothing Then
					RemoveHandler Me._txtInclinationLimit.TextChanged, value2
					RemoveHandler Me._txtInclinationLimit.Leave, value3
				End If
				Me._txtInclinationLimit = value
				If Me._txtInclinationLimit IsNot Nothing Then
					AddHandler Me._txtInclinationLimit.TextChanged, value2
					AddHandler Me._txtInclinationLimit.Leave, value3
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Closing, AddressOf Me.FSetup_Closing
			AddHandler MyBase.Load, AddressOf Me.RswinSetup_Load
			AddHandler MyBase.Validating, AddressOf Me.RswinSetup_Validating
			AddHandler MyBase.Enter, AddressOf Me.RswinSetup_Enter
			AddHandler MyBase.Activated, AddressOf Me.RswinSetup_Activated
			AddHandler MyBase.Resize, AddressOf Me.RswinSetup_Resize
			AddHandler MyBase.SizeChanged, AddressOf Me.RswinSetup_SizeChanged
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.Me_MouseDoubleClick
			AddHandler MyBase.MouseDown, AddressOf Me.Me_MouseDown
			AddHandler MyBase.MouseEnter, AddressOf Me.Me_MouseEnter
			AddHandler MyBase.MouseMove, AddressOf Me.Me_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.Me_MouseUp
			AddHandler MyBase.MouseWheel, AddressOf Me.Me_MouseWheel
			AddHandler MyBase.Move, AddressOf Me.Me_Move
			AddHandler MyBase.Scroll, AddressOf Me.Me_Scroll
			AddHandler MyBase.KeyPress, AddressOf Me.Me_KeyPress
			AddHandler MyBase.KeyUp, AddressOf Me.Me_KeyUp
			AddHandler MyBase.DragDrop, AddressOf Me.Me_DragDrop
			AddHandler MyBase.DragEnter, AddressOf Me.Me_DragEnter
			AddHandler MyBase.FormClosed, AddressOf Me.Me_FormClosed
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.LostFocus, AddressOf Me.Me_LostFocus
			AddHandler MyBase.GotFocus, AddressOf Me.Me_GotFocus
			Me.dlgPUList = New dlgPUList()
			Me.dlgCustomRG = New dlgCustomRG()
			Me.dlgCustomPU = New dlgCustomPU()
			Me.dlgWK1Setup = New dlgWK1Setup()
			Me.dlgSelectDir = New dlgSelectDir()
			Me.frmDisplayAllDatabaseTemplates = New db_guru_admin_form()
			Me.m_bSuppressMinMsg = False
			Me.RodGrade_AL = New ArrayList()
			Me.sARSCustomPU = Util.AssignValueToConstant("RswinSetup", "sARSCustomPU", "Are you sure you want to delete this custom pumping unit?")
			Me.sARSFormat = Util.AssignValueToConstant("RswinSetup", "sARSFormat", "Are you sure you want to delete this format")
			Me.sSelectSSFolder = Util.AssignValueToConstant("RswinSetup", "sSelectSSFolder", "Select the folder for creating batch mode spreadsheet files:")
			Me.sSelectRSFolder = Util.AssignValueToConstant("RswinSetup", "sSelectRSFolder", "Select the folder which contains the RODSTAR files to process:")
			Me.sSelectServerDBFolder = Util.AssignValueToConstant("RswinSetup", "sSelectDBFolder", "Select the folder on server which contains program databases:")
			Me.sGeneral = Util.AssignValueToConstant("RswinSetup", "sGeneral", "General")
			Me.sBatchMode = Util.AssignValueToConstant("RswinSetup", "sBatchMode", "Batch Mode")
			Me.sCostDatabase = Util.AssignValueToConstant("RswinSetup", "sCostDatabase", "Cost Database")
			Me.sDefaults = Util.AssignValueToConstant("RswinSetup", "sDefaults", "Defaults")
			Me.sExpert = Util.AssignValueToConstant("RswinSetup", "sExpert", "AI Mode Preferences")
			Me.sAdmin = Util.AssignValueToConstant("RswinSetup", "sAdmin", "Admin Preferences")
			Me.sOutputOptions = Util.AssignValueToConstant("RswinSetup", "sOutputOptions", "Output Options")
			Me.sPumpingUnitOptions = Util.AssignValueToConstant("RswinSetup", "sPumpingUnitOptions", "Pumping Unit Options")
			Me.sCustomizePumpingUnitList = Util.AssignValueToConstant("RswinSetup", "sCustomizePumpingUnitList", "Customize Pumping Unit List")
			Me.sMeasuredPumpingUnitList = Util.AssignValueToConstant("RswinSetup", "sMeasuredPumpingUnitList", "Measured Pumping Unit List")
			Me.sPumpingUnitCostDatabase = Util.AssignValueToConstant("RswinSetup", "sPumpingUnitCostDatabase", "Pumping Unit Cost Database")
			Me.sRodGradeOptions = Util.AssignValueToConstant("RswinSetup", "sRodGradeOptions", "Rod Grade Options")
			Me.sCustomizeRodGrades = Util.AssignValueToConstant("RswinSetup", "sCustomizeRodGrades", "Custom Rod Grades")
			Me.sNone = Util.AssignValueToConstant("RswinSetup", "sNone", "(none)")
			Me.sAM = Util.AssignValueToConstant("RswinSetup", "sAM", "AM")
			Me.sPM = Util.AssignValueToConstant("RswinSetup", "sPM", "PM")
			Me.csHDR_APIDES = Util.AssignValueToConstant("RswinSetup", "csHDR_APIDES", "API designation")
			Me.csHDR_MANUF = Util.AssignValueToConstant("RswinSetup", "csHDR_MANUF", "Manufacturer")
			Me.csHDR_OTHER = Util.AssignValueToConstant("RswinSetup", "csHDR_OTHER", "Other info")
			Me.csHDR_SINKERBAR = Util.AssignValueToConstant("RswinSetup", "csHDR_SINKERBAR", "Sinker bar")
			Me.csHDR_STRESS = Util.AssignValueToConstant("RswinSetup", "csHDR_STRESS", "Stress method")
			Me.csHDR_TENSILE = Util.AssignValueToConstant("RswinSetup", "csHDR_TENSILE", "Tensile strength")
			Me.csHDR_UNAME = Util.AssignValueToConstant("RswinSetup", "csHDR_UNAME", "Unit name")
			Me.csHDR_RodType = Util.AssignValueToConstant("RswinSetup", "csHDR_RODTYPE", "Rod type")
			Me.sARSCustomRG = Util.AssignValueToConstant("RswinSetup", "sARSCustomRG", "Are you sure you want to delete this custom rod grade?")
			Me.sPleaseSelectSSFormat = Util.AssignValueToConstant("RswinSetup", "sPleaseSelectSSFormat", "Please select a spreadsheet format.")
			Me.sNonStandardSuckerRodLengthMsg = Util.AssignValueToConstant("RswinSetup", "sNonStandardSuckerRodLengthMsg", "Typical standard steel sucker rod lengths are 25ft and 30 ft. Would you like to continue using your entered value?")
			Me.m_bInAfterEnterEdit = False
			Me.m_bInAfterCellUpdate = False
			Me.iPanelLeft = 218
			Me.APIRods_AL = New ArrayList()
			Me.HighStrengthRods_AL = New ArrayList()
			Me.HighStrengthProrods_AL = New ArrayList()
			Me.FGlassRods_AL = New ArrayList()
			Me.SinkerBarsGrade_AL = New ArrayList()
			Me.SinkerRodsGrade_AL = New ArrayList()
			Me.bExpertLoaded = False
			Me.bCancel = False
			Me.m_bEnd = False
			Me.myRodGuideAL = New ArrayList()
			Me.bViewingAIPreferences = False
			Me.myKeyValueHT = New Hashtable()
			Dim point As Point = New Point(0, 0)
			Me.StartPoint = point
			Me.m_DefaultNode = ""
			If RswinSetup.m_vb6FormDefInstance Is Nothing Then
				If RswinSetup.m_InitializingDefInstance Then
					RswinSetup.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							RswinSetup.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Friend Overridable Property pnlGeneral As Panel
			Get
				Return Me._pnlGeneral
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlGeneral = value
			End Set
		End Property

		Friend Overridable Property grpSystemOfUnits As GroupBox
			Get
				Return Me._grpSystemOfUnits
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpSystemOfUnits = value
			End Set
		End Property

		Friend Overridable Property chkShowVisualInputWindow As CheckBox
			Get
				Return Me._chkShowVisualInputWindow
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkShowVisualInputWindow = value
			End Set
		End Property

		Friend Overridable Property cboDigitizerComPort As ComboBox
			Get
				Return Me._cboDigitizerComPort
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._cboDigitizerComPort = value
			End Set
		End Property

		Friend Overridable Property lblDigitizerComPort As Label
			Get
				Return Me._lblDigitizerComPort
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDigitizerComPort = value
			End Set
		End Property

		Friend Overridable Property grpPreferences As GroupBox
			Get
				Return Me._grpPreferences
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpPreferences = value
			End Set
		End Property

		Friend Overridable Property rbtEnglish As RadioButton
			Get
				Return Me._rbtEnglish
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtEnglish_CheckedChanged
				If Me._rbtEnglish IsNot Nothing Then
					RemoveHandler Me._rbtEnglish.CheckedChanged, value2
				End If
				Me._rbtEnglish = value
				If Me._rbtEnglish IsNot Nothing Then
					AddHandler Me._rbtEnglish.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property rbtCanadian As RadioButton
			Get
				Return Me._rbtCanadian
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtCanadian_CheckedChanged
				If Me._rbtCanadian IsNot Nothing Then
					RemoveHandler Me._rbtCanadian.CheckedChanged, value2
				End If
				Me._rbtCanadian = value
				If Me._rbtCanadian IsNot Nothing Then
					AddHandler Me._rbtCanadian.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property rbtMetric As RadioButton
			Get
				Return Me._rbtMetric
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtMetric_CheckedChanged
				If Me._rbtMetric IsNot Nothing Then
					RemoveHandler Me._rbtMetric.CheckedChanged, value2
				End If
				Me._rbtMetric = value
				If Me._rbtMetric IsNot Nothing Then
					AddHandler Me._rbtMetric.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlDefaults As Panel
			Get
				Return Me._pnlDefaults
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As PaintEventHandler = AddressOf Me.pnlDefaults_Paint
				If Me._pnlDefaults IsNot Nothing Then
					RemoveHandler Me._pnlDefaults.Paint, value2
				End If
				Me._pnlDefaults = value
				If Me._pnlDefaults IsNot Nothing Then
					AddHandler Me._pnlDefaults.Paint, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblItem As Label
			Get
				Return Me._lblItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblItem = value
			End Set
		End Property

		Friend Overridable Property lblDefault As Label
			Get
				Return Me._lblDefault
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDefault = value
			End Set
		End Property

		Friend Overridable Property lblDefaultType As Label
			Get
				Return Me._lblDefaultType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDefaultType = value
			End Set
		End Property

		Friend Overridable Property pnlBatchMode As Panel
			Get
				Return Me._pnlBatchMode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlBatchMode = value
			End Set
		End Property

		Friend Overridable Property grpAutomaticBatchMode As GroupBox
			Get
				Return Me._grpAutomaticBatchMode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpAutomaticBatchMode = value
			End Set
		End Property

		Friend Overridable Property grpSpreadSheetSetup As GroupBox
			Get
				Return Me._grpSpreadSheetSetup
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Dim value2 As EventHandler = AddressOf Me.grpSpreadSheetSetup_Enter
				If Me._grpSpreadSheetSetup IsNot Nothing Then
					RemoveHandler Me._grpSpreadSheetSetup.Enter, value2
				End If
				Me._grpSpreadSheetSetup = value
				If Me._grpSpreadSheetSetup IsNot Nothing Then
					AddHandler Me._grpSpreadSheetSetup.Enter, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblBatchMode As Label
			Get
				Return Me._lblBatchMode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblBatchMode = value
			End Set
		End Property

		Friend Overridable Property lblSelect As Label
			Get
				Return Me._lblSelect
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSelect = value
			End Set
		End Property

		Friend Overridable Property lblTimeToBeginRuns As Label
			Get
				Return Me._lblTimeToBeginRuns
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTimeToBeginRuns = value
			End Set
		End Property

		Friend Overridable Property lblSSDir As Label
			Get
				Return Me._lblSSDir
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSSDir = value
			End Set
		End Property

		Friend Overridable Property nmUDHour As NumericUpDown
			Get
				Return Me._nmUDHour
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Dim value2 As EventHandler = AddressOf Me.nmUDHour_ValueChanged
				If Me._nmUDHour IsNot Nothing Then
					RemoveHandler Me._nmUDHour.ValueChanged, value2
				End If
				Me._nmUDHour = value
				If Me._nmUDHour IsNot Nothing Then
					AddHandler Me._nmUDHour.ValueChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property nmUDMinute As NumericUpDown
			Get
				Return Me._nmUDMinute
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Dim value2 As EventHandler = AddressOf Me.nmUDMinute_ValueChanged
				If Me._nmUDMinute IsNot Nothing Then
					RemoveHandler Me._nmUDMinute.ValueChanged, value2
				End If
				Me._nmUDMinute = value
				If Me._nmUDMinute IsNot Nothing Then
					AddHandler Me._nmUDMinute.ValueChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property cboAMPM As ComboBox
			Get
				Return Me._cboAMPM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._cboAMPM = value
			End Set
		End Property

		Friend Overridable Property pnlOutputOptions As Panel
			Get
				Return Me._pnlOutputOptions
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlOutputOptions = value
			End Set
		End Property

		Friend Overridable Property grpOutputOptions As GroupBox
			Get
				Return Me._grpOutputOptions
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpOutputOptions = value
			End Set
		End Property

		Friend Overridable Property GroupBox2 As GroupBox
			Get
				Return Me._GroupBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox2 = value
			End Set
		End Property

		Friend Overridable Property grpOutputPages As GroupBox
			Get
				Return Me._grpOutputPages
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpOutputPages = value
			End Set
		End Property

		Friend Overridable Property btnOK As Button
			Get
				Return Me._btnOK
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnOK_LocationChanged
				Dim value3 As EventHandler = AddressOf Me.btnOK_Click
				If Me._btnOK IsNot Nothing Then
					RemoveHandler Me._btnOK.LocationChanged, value2
					RemoveHandler Me._btnOK.Click, value3
				End If
				Me._btnOK = value
				If Me._btnOK IsNot Nothing Then
					AddHandler Me._btnOK.LocationChanged, value2
					AddHandler Me._btnOK.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property btnCancel As Button
			Get
				Return Me._btnCancel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnCancel_Click
				If Me._btnCancel IsNot Nothing Then
					RemoveHandler Me._btnCancel.Click, value2
				End If
				Me._btnCancel = value
				If Me._btnCancel IsNot Nothing Then
					AddHandler Me._btnCancel.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lstWK1Formats As ListBox
			Get
				Return Me._lstWK1Formats
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lstWK1Formats_SelectedIndexChanged
				If Me._lstWK1Formats IsNot Nothing Then
					RemoveHandler Me._lstWK1Formats.SelectedIndexChanged, value2
				End If
				Me._lstWK1Formats = value
				If Me._lstWK1Formats IsNot Nothing Then
					AddHandler Me._lstWK1Formats.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lstSorted As ListBox
			Get
				Return Me._lstSorted
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Me._lstSorted = value
			End Set
		End Property

		Friend Overridable Property lstDefaultItems As ListBox
			Get
				Return Me._lstDefaultItems
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lstDefaultItems_SelectedIndexChanged
				If Me._lstDefaultItems IsNot Nothing Then
					RemoveHandler Me._lstDefaultItems.SelectedIndexChanged, value2
				End If
				Me._lstDefaultItems = value
				If Me._lstDefaultItems IsNot Nothing Then
					AddHandler Me._lstDefaultItems.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property cboDefault As ComboBox
			Get
				Return Me._cboDefault
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboDefault_Leave
				If Me._cboDefault IsNot Nothing Then
					RemoveHandler Me._cboDefault.Leave, value2
				End If
				Me._cboDefault = value
				If Me._cboDefault IsNot Nothing Then
					AddHandler Me._cboDefault.Leave, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtDefault As TextBox
			Get
				Return Me._txtDefault
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.txtDefault_KeyDown
				Dim value3 As EventHandler = AddressOf Me.txtDefault_Enter
				Dim value4 As EventHandler = AddressOf Me.txtDefault_TextChanged
				Dim value5 As EventHandler = AddressOf Me.txtDefault_Leave
				Dim value6 As CancelEventHandler = AddressOf Me.txtDefault_Validating
				Dim value7 As EventHandler = AddressOf Me.txtDefault_LocationChanged
				If Me._txtDefault IsNot Nothing Then
					RemoveHandler Me._txtDefault.KeyDown, value2
					RemoveHandler Me._txtDefault.Enter, value3
					RemoveHandler Me._txtDefault.TextChanged, value4
					RemoveHandler Me._txtDefault.Leave, value5
					RemoveHandler Me._txtDefault.Validating, value6
					RemoveHandler Me._txtDefault.LocationChanged, value7
				End If
				Me._txtDefault = value
				If Me._txtDefault IsNot Nothing Then
					AddHandler Me._txtDefault.KeyDown, value2
					AddHandler Me._txtDefault.Enter, value3
					AddHandler Me._txtDefault.TextChanged, value4
					AddHandler Me._txtDefault.Leave, value5
					AddHandler Me._txtDefault.Validating, value6
					AddHandler Me._txtDefault.LocationChanged, value7
				End If
			End Set
		End Property

		Friend Overridable Property SSPanel As Panel
			Get
				Return Me._SSPanel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._SSPanel = value
			End Set
		End Property

		Friend Overridable Property imgPreview_4 As PictureBox
			Get
				Return Me._imgPreview_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_4 = value
			End Set
		End Property

		Friend Overridable Property imgPreview_2 As PictureBox
			Get
				Return Me._imgPreview_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_2 = value
			End Set
		End Property

		Friend Overridable Property chkReportOpt_3 As CheckBox
			Get
				Return Me._chkReportOpt_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_3_CheckedChanged
				If Me._chkReportOpt_3 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_3.Click, value2
				End If
				Me._chkReportOpt_3 = value
				If Me._chkReportOpt_3 IsNot Nothing Then
					AddHandler Me._chkReportOpt_3.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_2 As CheckBox
			Get
				Return Me._chkReportOpt_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_2_CheckedChanged
				If Me._chkReportOpt_2 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_2.Click, value2
				End If
				Me._chkReportOpt_2 = value
				If Me._chkReportOpt_2 IsNot Nothing Then
					AddHandler Me._chkReportOpt_2.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkSkipProcessedFiles As CheckBox
			Get
				Return Me._chkSkipProcessedFiles
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkSkipProcessedFiles = value
			End Set
		End Property

		Friend Overridable Property chkPrintResults As CheckBox
			Get
				Return Me._chkPrintResults
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkPrintResults_CheckedChanged
				If Me._chkPrintResults IsNot Nothing Then
					RemoveHandler Me._chkPrintResults.CheckedChanged, value2
				End If
				Me._chkPrintResults = value
				If Me._chkPrintResults IsNot Nothing Then
					AddHandler Me._chkPrintResults.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtWK1Dir As TextBox
			Get
				Return Me._txtWK1Dir
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtWK1Dir = value
			End Set
		End Property

		Public Overridable Property pnlDebug As Panel
			Get
				Return Me._pnlDebug
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlDebug = value
			End Set
		End Property

		Public Overridable Property chkDebugShowMessages As CheckBox
			Get
				Return Me._chkDebugShowMessages
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugShowMessages = value
			End Set
		End Property

		Public Overridable Property chkDebugDisableOnError As CheckBox
			Get
				Return Me._chkDebugDisableOnError
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugDisableOnError = value
			End Set
		End Property

		Public Overridable Property chkDebugShowPredictInfo As CheckBox
			Get
				Return Me._chkDebugShowPredictInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugShowPredictInfo = value
			End Set
		End Property

		Public Overridable Property chkDebugSetNcycles As CheckBox
			Get
				Return Me._chkDebugSetNcycles
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugSetNcycles = value
			End Set
		End Property

		Public Overridable Property chkDebugCreateDYN As CheckBox
			Get
				Return Me._chkDebugCreateDYN
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugCreateDYN = value
			End Set
		End Property

		Public Overridable Property chkDebugShowAllBalanced As CheckBox
			Get
				Return Me._chkDebugShowAllBalanced
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugShowAllBalanced = value
			End Set
		End Property

		Public Overridable Property chkDebugCreateTF As CheckBox
			Get
				Return Me._chkDebugCreateTF
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugCreateTF = value
			End Set
		End Property

		Public Overridable Property chkDebugCreateTQ As CheckBox
			Get
				Return Me._chkDebugCreateTQ
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugCreateTQ = value
			End Set
		End Property

		Public Overridable Property chkDebugCreateDPC As CheckBox
			Get
				Return Me._chkDebugCreateDPC
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugCreateDPC = value
			End Set
		End Property

		Public Overridable Property _Label_16 As Label
			Get
				Return Me.__Label_16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_16 = value
			End Set
		End Property

		Public Overridable Property _Label_15 As Label
			Get
				Return Me.__Label_15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_15 = value
			End Set
		End Property

		Public Overridable Property _Label_14 As Label
			Get
				Return Me.__Label_14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_14 = value
			End Set
		End Property

		Public Overridable Property _Label_13 As Label
			Get
				Return Me.__Label_13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_13 = value
			End Set
		End Property

		Public Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Public Overridable Property cboManufMenuCustomDB As ComboBox
			Get
				Return Me._cboManufMenuCustomDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboManufMenuCustomDB_SelectedIndexChanged
				If Me._cboManufMenuCustomDB IsNot Nothing Then
					RemoveHandler Me._cboManufMenuCustomDB.SelectedIndexChanged, value2
				End If
				Me._cboManufMenuCustomDB = value
				If Me._cboManufMenuCustomDB IsNot Nothing Then
					AddHandler Me._cboManufMenuCustomDB.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlCustomizeRGList As Panel
			Get
				Return Me._pnlCustomizeRGList
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlCustomizeRGList = value
			End Set
		End Property

		Public Overridable Property pnlCustomPUList As Panel
			Get
				Return Me._pnlCustomPUList
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlCustomPUList = value
			End Set
		End Property

		Public Overridable Property pnlCustomMeasuredPUList As Panel
			Get
				Return Me._pnlCustomMeasuredPUList
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlCustomMeasuredPUList = value
			End Set
		End Property

		Friend Overridable Property cmdDeleteCustomPU As Button
			Get
				Return Me._cmdDeleteCustomPU
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdDeleteCustomPU_MouseHover
				Dim value3 As EventHandler = AddressOf Me.cmdDeleteCustomPU_Click
				If Me._cmdDeleteCustomPU IsNot Nothing Then
					RemoveHandler Me._cmdDeleteCustomPU.MouseHover, value2
					RemoveHandler Me._cmdDeleteCustomPU.Click, value3
				End If
				Me._cmdDeleteCustomPU = value
				If Me._cmdDeleteCustomPU IsNot Nothing Then
					AddHandler Me._cmdDeleteCustomPU.MouseHover, value2
					AddHandler Me._cmdDeleteCustomPU.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property cmdModifyCustomPU As Button
			Get
				Return Me._cmdModifyCustomPU
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdModifyCustomPU_MouseHover
				Dim value3 As EventHandler = AddressOf Me.cmdModifyCustomPU_Click
				If Me._cmdModifyCustomPU IsNot Nothing Then
					RemoveHandler Me._cmdModifyCustomPU.MouseHover, value2
					RemoveHandler Me._cmdModifyCustomPU.Click, value3
				End If
				Me._cmdModifyCustomPU = value
				If Me._cmdModifyCustomPU IsNot Nothing Then
					AddHandler Me._cmdModifyCustomPU.MouseHover, value2
					AddHandler Me._cmdModifyCustomPU.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property cmdNewCustomPU As Button
			Get
				Return Me._cmdNewCustomPU
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdNewCustomPU_MouseHover
				Dim value3 As EventHandler = AddressOf Me.cmdNewCustomPU_Click
				If Me._cmdNewCustomPU IsNot Nothing Then
					RemoveHandler Me._cmdNewCustomPU.MouseHover, value2
					RemoveHandler Me._cmdNewCustomPU.Click, value3
				End If
				Me._cmdNewCustomPU = value
				If Me._cmdNewCustomPU IsNot Nothing Then
					AddHandler Me._cmdNewCustomPU.MouseHover, value2
					AddHandler Me._cmdNewCustomPU.Click, value3
				End If
			End Set
		End Property

		Public Overridable Property lvwCustomPU As ListView
			Get
				Return Me._lvwCustomPU
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Me._lvwCustomPU = value
			End Set
		End Property

		Friend Overridable Property Manufacturer As System.Windows.Forms.ColumnHeader
			Get
				Return Me._Manufacturer
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.ColumnHeader)
				Me._Manufacturer = value
			End Set
		End Property

		Friend Overridable Property APIDesignation As System.Windows.Forms.ColumnHeader
			Get
				Return Me._APIDesignation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.ColumnHeader)
				Me._APIDesignation = value
			End Set
		End Property

		Friend Overridable Property UnitName As System.Windows.Forms.ColumnHeader
			Get
				Return Me._UnitName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.ColumnHeader)
				Me._UnitName = value
			End Set
		End Property

		Friend Overridable Property OtherInfo As System.Windows.Forms.ColumnHeader
			Get
				Return Me._OtherInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.ColumnHeader)
				Me._OtherInfo = value
			End Set
		End Property

		Friend Overridable Property cmdBrowse_2 As Button
			Get
				Return Me._cmdBrowse_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdBrowse_2_Click
				If Me._cmdBrowse_2 IsNot Nothing Then
					RemoveHandler Me._cmdBrowse_2.Click, value2
				End If
				Me._cmdBrowse_2 = value
				If Me._cmdBrowse_2 IsNot Nothing Then
					AddHandler Me._cmdBrowse_2.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property cmdBrowse_0 As Button
			Get
				Return Me._cmdBrowse_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnRODSTARDataDict_Click
				If Me._cmdBrowse_0 IsNot Nothing Then
					RemoveHandler Me._cmdBrowse_0.Click, value2
				End If
				Me._cmdBrowse_0 = value
				If Me._cmdBrowse_0 IsNot Nothing Then
					AddHandler Me._cmdBrowse_0.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkCreateWK1 As CheckBox
			Get
				Return Me._chkCreateWK1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkCreateWK1_CheckedChanged
				If Me._chkCreateWK1 IsNot Nothing Then
					RemoveHandler Me._chkCreateWK1.CheckedChanged, value2
				End If
				Me._chkCreateWK1 = value
				If Me._chkCreateWK1 IsNot Nothing Then
					AddHandler Me._chkCreateWK1.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property optCRGMismatch_1 As RadioButton
			Get
				Return Me._optCRGMismatch_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optCRGMismatch_1_CheckedChanged
				If Me._optCRGMismatch_1 IsNot Nothing Then
					RemoveHandler Me._optCRGMismatch_1.CheckedChanged, value2
				End If
				Me._optCRGMismatch_1 = value
				If Me._optCRGMismatch_1 IsNot Nothing Then
					AddHandler Me._optCRGMismatch_1.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property optCRGMismatch_0 As RadioButton
			Get
				Return Me._optCRGMismatch_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optCRGMismatch_0_CheckedChanged
				If Me._optCRGMismatch_0 IsNot Nothing Then
					RemoveHandler Me._optCRGMismatch_0.CheckedChanged, value2
				End If
				Me._optCRGMismatch_0 = value
				If Me._optCRGMismatch_0 IsNot Nothing Then
					AddHandler Me._optCRGMismatch_0.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdModifyCustomRG As Button
			Get
				Return Me._cmdModifyCustomRG
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdModifyCustomRG_MouseHover
				Dim value3 As EventHandler = AddressOf Me.cmdModifyCustomRG_Click
				If Me._cmdModifyCustomRG IsNot Nothing Then
					RemoveHandler Me._cmdModifyCustomRG.MouseHover, value2
					RemoveHandler Me._cmdModifyCustomRG.Click, value3
				End If
				Me._cmdModifyCustomRG = value
				If Me._cmdModifyCustomRG IsNot Nothing Then
					AddHandler Me._cmdModifyCustomRG.MouseHover, value2
					AddHandler Me._cmdModifyCustomRG.Click, value3
				End If
			End Set
		End Property

		Public Overridable Property cmdNewCustomRG As Button
			Get
				Return Me._cmdNewCustomRG
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdNewCustomRG_MouseHover
				Dim value3 As EventHandler = AddressOf Me.cmdNewCustomRG_Click
				If Me._cmdNewCustomRG IsNot Nothing Then
					RemoveHandler Me._cmdNewCustomRG.MouseHover, value2
					RemoveHandler Me._cmdNewCustomRG.Click, value3
				End If
				Me._cmdNewCustomRG = value
				If Me._cmdNewCustomRG IsNot Nothing Then
					AddHandler Me._cmdNewCustomRG.MouseHover, value2
					AddHandler Me._cmdNewCustomRG.Click, value3
				End If
			End Set
		End Property

		Public Overridable Property cmdDeleteCustomRG As Button
			Get
				Return Me._cmdDeleteCustomRG
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdDeleteCustomRG_MouseHover
				Dim value3 As EventHandler = AddressOf Me.cmdDeleteCustomRG_Click
				If Me._cmdDeleteCustomRG IsNot Nothing Then
					RemoveHandler Me._cmdDeleteCustomRG.MouseHover, value2
					RemoveHandler Me._cmdDeleteCustomRG.Click, value3
				End If
				Me._cmdDeleteCustomRG = value
				If Me._cmdDeleteCustomRG IsNot Nothing Then
					AddHandler Me._cmdDeleteCustomRG.MouseHover, value2
					AddHandler Me._cmdDeleteCustomRG.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property ToolTip1 As System.Windows.Forms.ToolTip
			Get
				Return Me._ToolTip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.ToolTip)
				Me._ToolTip1 = value
			End Set
		End Property

		Public Overridable Property pnlDebugOptions As Panel
			Get
				Return Me._pnlDebugOptions
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlDebugOptions = value
			End Set
		End Property

		Friend Overridable Property grpDebugOpt As GroupBox
			Get
				Return Me._grpDebugOpt
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpDebugOpt = value
			End Set
		End Property

		Friend Overridable Property chkDebugFixSinusoidalDyno As CheckBox
			Get
				Return Me._chkDebugFixSinusoidalDyno
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugFixSinusoidalDyno = value
			End Set
		End Property

		Friend Overridable Property chkDebugTreatAsSolidLine As CheckBox
			Get
				Return Me._chkDebugTreatAsSolidLine
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugTreatAsSolidLine = value
			End Set
		End Property

		Friend Overridable Property chkDebugNoFIReplaceGoodMatch As CheckBox
			Get
				Return Me._chkDebugNoFIReplaceGoodMatch
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugNoFIReplaceGoodMatch = value
			End Set
		End Property

		Friend Overridable Property chkDebugShowMatchInfo As CheckBox
			Get
				Return Me._chkDebugShowMatchInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugShowMatchInfo = value
			End Set
		End Property

		Friend Overridable Property chkDebugMessages As CheckBox
			Get
				Return Me._chkDebugMessages
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugMessages = value
			End Set
		End Property

		Friend Overridable Property chkDebugShowPredictInfo2 As CheckBox
			Get
				Return Me._chkDebugShowPredictInfo2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkDebugShowPredictInfo2 = value
			End Set
		End Property

		Friend Overridable Property RodType As System.Windows.Forms.ColumnHeader
			Get
				Return Me._RodType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.ColumnHeader)
				Me._RodType = value
			End Set
		End Property

		Friend Overridable Property StressMethod As System.Windows.Forms.ColumnHeader
			Get
				Return Me._StressMethod
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.ColumnHeader)
				Me._StressMethod = value
			End Set
		End Property

		Friend Overridable Property SinkerBar As System.Windows.Forms.ColumnHeader
			Get
				Return Me._SinkerBar
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.ColumnHeader)
				Me._SinkerBar = value
			End Set
		End Property

		Friend Overridable Property TensileStrength As System.Windows.Forms.ColumnHeader
			Get
				Return Me._TensileStrength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.ColumnHeader)
				Me._TensileStrength = value
			End Set
		End Property

		Friend Overridable Property HelpProvider1 As HelpProvider
			Get
				Return Me._HelpProvider1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As HelpProvider)
				Me._HelpProvider1 = value
			End Set
		End Property

		Friend Overridable Property chkViewWK1 As CheckBox
			Get
				Return Me._chkViewWK1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkViewWK1 = value
			End Set
		End Property

		Public Overridable Property chkAzDirToolbar As CheckBox
			Get
				Return Me._chkAzDirToolbar
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkAzDirToolbar_CheckedChanged
				If Me._chkAzDirToolbar IsNot Nothing Then
					RemoveHandler Me._chkAzDirToolbar.CheckedChanged, value2
				End If
				Me._chkAzDirToolbar = value
				If Me._chkAzDirToolbar IsNot Nothing Then
					AddHandler Me._chkAzDirToolbar.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _SSFrame_8 As GroupBox
			Get
				Return Me.__SSFrame_8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me.__SSFrame_8 = value
			End Set
		End Property

		Public Overridable Property txtWheelLoad As TextBox
			Get
				Return Me._txtWheelLoad
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtWheelLoad_Leave
				Dim value3 As EventHandler = AddressOf Me.txtWheelLoad_Enter
				Dim value4 As EventHandler = AddressOf Me.txtWheelLoad_TextChanged
				If Me._txtWheelLoad IsNot Nothing Then
					RemoveHandler Me._txtWheelLoad.Leave, value2
					RemoveHandler Me._txtWheelLoad.Enter, value3
					RemoveHandler Me._txtWheelLoad.TextChanged, value4
				End If
				Me._txtWheelLoad = value
				If Me._txtWheelLoad IsNot Nothing Then
					AddHandler Me._txtWheelLoad.Leave, value2
					AddHandler Me._txtWheelLoad.Enter, value3
					AddHandler Me._txtWheelLoad.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property txtMoldedLoad As TextBox
			Get
				Return Me._txtMoldedLoad
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMoldedLoad_Leave
				Dim value3 As EventHandler = AddressOf Me.txtMoldedLoad_Enter
				Dim value4 As EventHandler = AddressOf Me.txtMoldedLoad_TextChanged
				If Me._txtMoldedLoad IsNot Nothing Then
					RemoveHandler Me._txtMoldedLoad.Leave, value2
					RemoveHandler Me._txtMoldedLoad.Enter, value3
					RemoveHandler Me._txtMoldedLoad.TextChanged, value4
				End If
				Me._txtMoldedLoad = value
				If Me._txtMoldedLoad IsNot Nothing Then
					AddHandler Me._txtMoldedLoad.Leave, value2
					AddHandler Me._txtMoldedLoad.Enter, value3
					AddHandler Me._txtMoldedLoad.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property _SSFrame_3 As GroupBox
			Get
				Return Me.__SSFrame_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me.__SSFrame_3 = value
			End Set
		End Property

		Public Overridable Property txtMaxSteelLoading As TextBox
			Get
				Return Me._txtMaxSteelLoading
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMaxSteelLoading_Leave
				Dim value3 As EventHandler = AddressOf Me.txtMaxSteelLoading_Enter
				Dim value4 As EventHandler = AddressOf Me.txtMaxSteelLoading_TextChanged
				If Me._txtMaxSteelLoading IsNot Nothing Then
					RemoveHandler Me._txtMaxSteelLoading.Leave, value2
					RemoveHandler Me._txtMaxSteelLoading.Enter, value3
					RemoveHandler Me._txtMaxSteelLoading.TextChanged, value4
				End If
				Me._txtMaxSteelLoading = value
				If Me._txtMaxSteelLoading IsNot Nothing Then
					AddHandler Me._txtMaxSteelLoading.Leave, value2
					AddHandler Me._txtMaxSteelLoading.Enter, value3
					AddHandler Me._txtMaxSteelLoading.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property txtMaxFGLoading As TextBox
			Get
				Return Me._txtMaxFGLoading
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMaxFGLoading_Leave
				Dim value3 As EventHandler = AddressOf Me.txtMaxFGLoading_Enter
				If Me._txtMaxFGLoading IsNot Nothing Then
					RemoveHandler Me._txtMaxFGLoading.Leave, value2
					RemoveHandler Me._txtMaxFGLoading.Enter, value3
				End If
				Me._txtMaxFGLoading = value
				If Me._txtMaxFGLoading IsNot Nothing Then
					AddHandler Me._txtMaxFGLoading.Leave, value2
					AddHandler Me._txtMaxFGLoading.Enter, value3
				End If
			End Set
		End Property

		Public Overridable Property CheckBox4 As CheckBox
			Get
				Return Me._CheckBox4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox4_CheckedChanged
				If Me._CheckBox4 IsNot Nothing Then
					RemoveHandler Me._CheckBox4.CheckedChanged, value2
				End If
				Me._CheckBox4 = value
				If Me._CheckBox4 IsNot Nothing Then
					AddHandler Me._CheckBox4.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property CheckBox5 As CheckBox
			Get
				Return Me._CheckBox5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox5 = value
			End Set
		End Property

		Public Overridable Property CheckBox6 As CheckBox
			Get
				Return Me._CheckBox6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox6 = value
			End Set
		End Property

		Public Overridable Property CheckBox7 As CheckBox
			Get
				Return Me._CheckBox7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox7 = value
			End Set
		End Property

		Public Overridable Property CheckBox8 As CheckBox
			Get
				Return Me._CheckBox8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox8 = value
			End Set
		End Property

		Public Overridable Property CheckBox9 As CheckBox
			Get
				Return Me._CheckBox9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox9 = value
			End Set
		End Property

		Public Overridable Property Label2 As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Public Overridable Property Label3 As Label
			Get
				Return Me._Label3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		Public Overridable Property Label4 As Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		Public Overridable Property optNcycles_0 As RadioButton
			Get
				Return Me._optNcycles_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._optNcycles_0 = value
			End Set
		End Property

		Public Overridable Property optNcycles_1 As RadioButton
			Get
				Return Me._optNcycles_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._optNcycles_1 = value
			End Set
		End Property

		Public Overridable Property optNcycles_2 As RadioButton
			Get
				Return Me._optNcycles_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._optNcycles_2 = value
			End Set
		End Property

		Public Overridable Property optNcycles_3 As RadioButton
			Get
				Return Me._optNcycles_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._optNcycles_3 = value
			End Set
		End Property

		Public Overridable Property lblMaxFGLoading As Label
			Get
				Return Me._lblMaxFGLoading
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMaxFGLoading = value
			End Set
		End Property

		Public Overridable Property lblMaxSteelLoading As Label
			Get
				Return Me._lblMaxSteelLoading
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMaxSteelLoading = value
			End Set
		End Property

		Public Overridable Property pnlSetupCostDB As Panel
			Get
				Return Me._pnlSetupCostDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlSetupCostDB = value
			End Set
		End Property

		Public Overridable Property panContainer As Panel
			Get
				Return Me._panContainer
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._panContainer = value
			End Set
		End Property

		Public Overridable Property _optCostCategory_0 As RadioButton
			Get
				Return Me.__optCostCategory_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optCostCategory_0_CheckedChanged
				If Me.__optCostCategory_0 IsNot Nothing Then
					RemoveHandler Me.__optCostCategory_0.CheckedChanged, value2
				End If
				Me.__optCostCategory_0 = value
				If Me.__optCostCategory_0 IsNot Nothing Then
					AddHandler Me.__optCostCategory_0.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _optCostCategory_1 As RadioButton
			Get
				Return Me.__optCostCategory_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optCostCategory_1_CheckedChanged
				If Me.__optCostCategory_1 IsNot Nothing Then
					RemoveHandler Me.__optCostCategory_1.CheckedChanged, value2
				End If
				Me.__optCostCategory_1 = value
				If Me.__optCostCategory_1 IsNot Nothing Then
					AddHandler Me.__optCostCategory_1.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _panCostCategory_1 As Panel
			Get
				Return Me.__panCostCategory_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__panCostCategory_1 = value
			End Set
		End Property

		Public Overridable Property cboRodType As ComboBox
			Get
				Return Me._cboRodType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRodType_SelectedIndexChanged
				If Me._cboRodType IsNot Nothing Then
					RemoveHandler Me._cboRodType.SelectedIndexChanged, value2
				End If
				Me._cboRodType = value
				If Me._cboRodType IsNot Nothing Then
					AddHandler Me._cboRodType.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdRSLoadCostDB As Button
			Get
				Return Me._cmdRSLoadCostDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdRSLoadCostDB_Click
				If Me._cmdRSLoadCostDB IsNot Nothing Then
					RemoveHandler Me._cmdRSLoadCostDB.Click, value2
				End If
				Me._cmdRSLoadCostDB = value
				If Me._cmdRSLoadCostDB IsNot Nothing Then
					AddHandler Me._cmdRSLoadCostDB.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _Label_3 As Label
			Get
				Return Me.__Label_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_3 = value
			End Set
		End Property

		Public Overridable Property _Label_4 As Label
			Get
				Return Me.__Label_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_4 = value
			End Set
		End Property

		Public Overridable Property _panCostCategory_0 As Panel
			Get
				Return Me.__panCostCategory_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__panCostCategory_0 = value
			End Set
		End Property

		Public Overridable Property cboPUManuf As ComboBox
			Get
				Return Me._cboPUManuf
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboPUManuf_SelectedIndexChanged
				If Me._cboPUManuf IsNot Nothing Then
					RemoveHandler Me._cboPUManuf.SelectedIndexChanged, value2
				End If
				Me._cboPUManuf = value
				If Me._cboPUManuf IsNot Nothing Then
					AddHandler Me._cboPUManuf.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdPULoadCostDB As Button
			Get
				Return Me._cmdPULoadCostDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdPULoadCostDB_Click
				If Me._cmdPULoadCostDB IsNot Nothing Then
					RemoveHandler Me._cmdPULoadCostDB.Click, value2
				End If
				Me._cmdPULoadCostDB = value
				If Me._cmdPULoadCostDB IsNot Nothing Then
					AddHandler Me._cmdPULoadCostDB.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _Label_6 As Label
			Get
				Return Me.__Label_6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_6 = value
			End Set
		End Property

		Public Overridable Property _Label_7 As Label
			Get
				Return Me.__Label_7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_7 = value
			End Set
		End Property

		Public Overridable Property _Label_8 As Label
			Get
				Return Me.__Label_8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_8 = value
			End Set
		End Property

		Public Overridable Property _Label_9 As Label
			Get
				Return Me.__Label_9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_9 = value
			End Set
		End Property

		Public Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button1 = value
			End Set
		End Property

		Public Overridable Property _Line_0 As Label
			Get
				Return Me.__Line_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Line_0 = value
			End Set
		End Property

		Public Overridable Property _Line_1 As Label
			Get
				Return Me.__Line_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Line_1 = value
			End Set
		End Property

		Public Overridable Property cmdCheckData As Button
			Get
				Return Me._cmdCheckData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._cmdCheckData = value
			End Set
		End Property

		Friend Overridable Property pnlPUCostDB As Panel
			Get
				Return Me._pnlPUCostDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlPUCostDB = value
			End Set
		End Property

		Friend Overridable Property pnlRSCostDB As Panel
			Get
				Return Me._pnlRSCostDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlRSCostDB = value
			End Set
		End Property

		Public Overridable Property ulgPUCostDB As UltraGrid
			Get
				Return Me._ulgPUCostDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As CancelEventHandler = AddressOf Me.ulgPUCostDB_BeforeEnterEditMode
				Dim value3 As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventHandler = AddressOf Me.ulgPUCostDB_BeforeExitEditMode
				Dim value4 As EventHandler = AddressOf Me.ulgPUCostDB_AfterEnterEditMode
				Dim value5 As CellEventHandler = AddressOf Me.ulgPUCostDB_AfterCellUpdate
				Dim value6 As EventHandler = AddressOf Me.ulgPUCostDB_AfterCellActivate
				Dim value7 As EventHandler = AddressOf Me.ulgPUCostDB_AfterRowActivate
				Dim value8 As InitializeLayoutEventHandler = AddressOf Me.ulgPUCostDB_InitializeLayout
				If Me._ulgPUCostDB IsNot Nothing Then
					RemoveHandler Me._ulgPUCostDB.BeforeEnterEditMode, value2
					RemoveHandler Me._ulgPUCostDB.BeforeExitEditMode, value3
					RemoveHandler Me._ulgPUCostDB.AfterEnterEditMode, value4
					RemoveHandler Me._ulgPUCostDB.AfterCellUpdate, value5
					RemoveHandler Me._ulgPUCostDB.AfterCellActivate, value6
					RemoveHandler Me._ulgPUCostDB.AfterRowActivate, value7
					RemoveHandler Me._ulgPUCostDB.InitializeLayout, value8
				End If
				Me._ulgPUCostDB = value
				If Me._ulgPUCostDB IsNot Nothing Then
					AddHandler Me._ulgPUCostDB.BeforeEnterEditMode, value2
					AddHandler Me._ulgPUCostDB.BeforeExitEditMode, value3
					AddHandler Me._ulgPUCostDB.AfterEnterEditMode, value4
					AddHandler Me._ulgPUCostDB.AfterCellUpdate, value5
					AddHandler Me._ulgPUCostDB.AfterCellActivate, value6
					AddHandler Me._ulgPUCostDB.AfterRowActivate, value7
					AddHandler Me._ulgPUCostDB.InitializeLayout, value8
				End If
			End Set
		End Property

		Public Overridable Property ulgRSCostDB As UltraGrid
			Get
				Return Me._ulgRSCostDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As CancelEventHandler = AddressOf Me.ulgRSCostDB_BeforeEnterEditMode
				Dim value3 As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventHandler = AddressOf Me.ulgRSCostDB_BeforeExitEditMode
				Dim value4 As EventHandler = AddressOf Me.ulgRSCostDB_AfterEnterEditMode
				Dim value5 As CellEventHandler = AddressOf Me.ulgRSCostDB_AfterCellUpdate
				Dim value6 As InitializeLayoutEventHandler = AddressOf Me.ulgRSCostDB_InitializeLayout
				If Me._ulgRSCostDB IsNot Nothing Then
					RemoveHandler Me._ulgRSCostDB.BeforeEnterEditMode, value2
					RemoveHandler Me._ulgRSCostDB.BeforeExitEditMode, value3
					RemoveHandler Me._ulgRSCostDB.AfterEnterEditMode, value4
					RemoveHandler Me._ulgRSCostDB.AfterCellUpdate, value5
					RemoveHandler Me._ulgRSCostDB.InitializeLayout, value6
				End If
				Me._ulgRSCostDB = value
				If Me._ulgRSCostDB IsNot Nothing Then
					AddHandler Me._ulgRSCostDB.BeforeEnterEditMode, value2
					AddHandler Me._ulgRSCostDB.BeforeExitEditMode, value3
					AddHandler Me._ulgRSCostDB.AfterEnterEditMode, value4
					AddHandler Me._ulgRSCostDB.AfterCellUpdate, value5
					AddHandler Me._ulgRSCostDB.InitializeLayout, value6
				End If
			End Set
		End Property

		Friend Overridable Property lblOtherInfo As Label
			Get
				Return Me._lblOtherInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblOtherInfo = value
			End Set
		End Property

		Friend Overridable Property lblUnitName As Label
			Get
				Return Me._lblUnitName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblUnitName = value
			End Set
		End Property

		Friend Overridable Property lblAPIDesignation As Label
			Get
				Return Me._lblAPIDesignation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblAPIDesignation = value
			End Set
		End Property

		Friend Overridable Property chkReportOpt_0 As CheckBox
			Get
				Return Me._chkReportOpt_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_0_CheckedChanged
				If Me._chkReportOpt_0 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_0.Click, value2
				End If
				Me._chkReportOpt_0 = value
				If Me._chkReportOpt_0 IsNot Nothing Then
					AddHandler Me._chkReportOpt_0.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_7 As CheckBox
			Get
				Return Me._chkReportOpt_7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_7_CheckedChanged_1
				Dim value3 As EventHandler = AddressOf Me.chkReportOpt_7_CheckedChanged
				If Me._chkReportOpt_7 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_7.CheckedChanged, value2
					RemoveHandler Me._chkReportOpt_7.Click, value3
				End If
				Me._chkReportOpt_7 = value
				If Me._chkReportOpt_7 IsNot Nothing Then
					AddHandler Me._chkReportOpt_7.CheckedChanged, value2
					AddHandler Me._chkReportOpt_7.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_1 As CheckBox
			Get
				Return Me._chkReportOpt_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_1_CheckedChanged
				If Me._chkReportOpt_1 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_1.Click, value2
				End If
				Me._chkReportOpt_1 = value
				If Me._chkReportOpt_1 IsNot Nothing Then
					AddHandler Me._chkReportOpt_1.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property imgPreview_0 As PictureBox
			Get
				Return Me._imgPreview_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_0 = value
			End Set
		End Property

		Friend Overridable Property imgPreview_1 As PictureBox
			Get
				Return Me._imgPreview_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_1 = value
			End Set
		End Property

		Friend Overridable Property chkReportOpt_6 As CheckBox
			Get
				Return Me._chkReportOpt_6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_6_CheckedChanged
				If Me._chkReportOpt_6 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_6.Click, value2
				End If
				Me._chkReportOpt_6 = value
				If Me._chkReportOpt_6 IsNot Nothing Then
					AddHandler Me._chkReportOpt_6.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_4 As CheckBox
			Get
				Return Me._chkReportOpt_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_4_CheckedChanged
				If Me._chkReportOpt_4 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_4.CheckedChanged, value2
				End If
				Me._chkReportOpt_4 = value
				If Me._chkReportOpt_4 IsNot Nothing Then
					AddHandler Me._chkReportOpt_4.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_5 As CheckBox
			Get
				Return Me._chkReportOpt_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_5_CheckedChanged
				If Me._chkReportOpt_5 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_5.CheckedChanged, value2
				End If
				Me._chkReportOpt_5 = value
				If Me._chkReportOpt_5 IsNot Nothing Then
					AddHandler Me._chkReportOpt_5.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property imgPreview_3 As PictureBox
			Get
				Return Me._imgPreview_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_3 = value
			End Set
		End Property

		Friend Overridable Property imgPreview_5 As PictureBox
			Get
				Return Me._imgPreview_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_5 = value
			End Set
		End Property

		Public Overridable Property chkAllowSlideFric As CheckBox
			Get
				Return Me._chkAllowSlideFric
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkAllowSlideFric = value
			End Set
		End Property

		Friend Overridable Property optMolded As RadioButton
			Get
				Return Me._optMolded
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optMolded_CheckedChanged
				If Me._optMolded IsNot Nothing Then
					RemoveHandler Me._optMolded.CheckedChanged, value2
				End If
				Me._optMolded = value
				If Me._optMolded IsNot Nothing Then
					AddHandler Me._optMolded.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property optWheel As RadioButton
			Get
				Return Me._optWheel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optWheel_CheckedChanged
				If Me._optWheel IsNot Nothing Then
					RemoveHandler Me._optWheel.CheckedChanged, value2
				End If
				Me._optWheel = value
				If Me._optWheel IsNot Nothing Then
					AddHandler Me._optWheel.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property optOther As RadioButton
			Get
				Return Me._optOther
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optOther_CheckedChanged
				If Me._optOther IsNot Nothing Then
					RemoveHandler Me._optOther.CheckedChanged, value2
				End If
				Me._optOther = value
				If Me._optOther IsNot Nothing Then
					AddHandler Me._optOther.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtMaxNumGuides As TextBox
			Get
				Return Me._txtMaxNumGuides
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMaxNumGuides_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtMaxNumGuides_Leave
				Dim value4 As EventHandler = AddressOf Me.txtMaxNumGuides_FontChanged
				Dim value5 As EventHandler = AddressOf Me.txtMaxNumGuides_Enter
				If Me._txtMaxNumGuides IsNot Nothing Then
					RemoveHandler Me._txtMaxNumGuides.TextChanged, value2
					RemoveHandler Me._txtMaxNumGuides.Leave, value3
					RemoveHandler Me._txtMaxNumGuides.FontChanged, value4
					RemoveHandler Me._txtMaxNumGuides.Enter, value5
				End If
				Me._txtMaxNumGuides = value
				If Me._txtMaxNumGuides IsNot Nothing Then
					AddHandler Me._txtMaxNumGuides.TextChanged, value2
					AddHandler Me._txtMaxNumGuides.Leave, value3
					AddHandler Me._txtMaxNumGuides.FontChanged, value4
					AddHandler Me._txtMaxNumGuides.Enter, value5
				End If
			End Set
		End Property

		Public Overridable Property txtOtherLoad As TextBox
			Get
				Return Me._txtOtherLoad
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtOtherLoad_Leave
				Dim value3 As EventHandler = AddressOf Me.txtOtherLoad_Enter
				Dim value4 As EventHandler = AddressOf Me.txtOtherLoad_TextChanged
				If Me._txtOtherLoad IsNot Nothing Then
					RemoveHandler Me._txtOtherLoad.Leave, value2
					RemoveHandler Me._txtOtherLoad.Enter, value3
					RemoveHandler Me._txtOtherLoad.TextChanged, value4
				End If
				Me._txtOtherLoad = value
				If Me._txtOtherLoad IsNot Nothing Then
					AddHandler Me._txtOtherLoad.Leave, value2
					AddHandler Me._txtOtherLoad.Enter, value3
					AddHandler Me._txtOtherLoad.TextChanged, value4
				End If
			End Set
		End Property

		Friend Overridable Property grpRatio As GroupBox
			Get
				Return Me._grpRatio
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpRatio = value
			End Set
		End Property

		Public Overridable Property lblGearBoxRatio As Label
			Get
				Return Me._lblGearBoxRatio
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGearBoxRatio = value
			End Set
		End Property

		Public Overridable Property txtGearBoxRatio As TextBox
			Get
				Return Me._txtGearBoxRatio
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtGearBoxRatio_TextChanged
				If Me._txtGearBoxRatio IsNot Nothing Then
					RemoveHandler Me._txtGearBoxRatio.TextChanged, value2
				End If
				Me._txtGearBoxRatio = value
				If Me._txtGearBoxRatio IsNot Nothing Then
					AddHandler Me._txtGearBoxRatio.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtVBeltRatio As TextBox
			Get
				Return Me._txtVBeltRatio
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtVBeltRatio_TextChanged
				If Me._txtVBeltRatio IsNot Nothing Then
					RemoveHandler Me._txtVBeltRatio.TextChanged, value2
				End If
				Me._txtVBeltRatio = value
				If Me._txtVBeltRatio IsNot Nothing Then
					AddHandler Me._txtVBeltRatio.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lblVBeltRatio As Label
			Get
				Return Me._lblVBeltRatio
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblVBeltRatio = value
			End Set
		End Property

		Friend Overridable Property chkCalcVBelt As CheckBox
			Get
				Return Me._chkCalcVBelt
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkCalcVBelt_CheckedChanged
				If Me._chkCalcVBelt IsNot Nothing Then
					RemoveHandler Me._chkCalcVBelt.CheckedChanged, value2
				End If
				Me._chkCalcVBelt = value
				If Me._chkCalcVBelt IsNot Nothing Then
					AddHandler Me._chkCalcVBelt.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtNumCycles As TextBox
			Get
				Return Me._txtNumCycles
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtNumCycles_TextChanged
				If Me._txtNumCycles IsNot Nothing Then
					RemoveHandler Me._txtNumCycles.TextChanged, value2
				End If
				Me._txtNumCycles = value
				If Me._txtNumCycles IsNot Nothing Then
					AddHandler Me._txtNumCycles.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lblNumCycles As Label
			Get
				Return Me._lblNumCycles
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNumCycles = value
			End Set
		End Property

		Friend Overridable Property grpPredictMode As GroupBox
			Get
				Return Me._grpPredictMode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpPredictMode = value
			End Set
		End Property

		Friend Overridable Property optDeviated As RadioButton
			Get
				Return Me._optDeviated
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optDeviated_CheckedChanged
				If Me._optDeviated IsNot Nothing Then
					RemoveHandler Me._optDeviated.CheckedChanged, value2
				End If
				Me._optDeviated = value
				If Me._optDeviated IsNot Nothing Then
					AddHandler Me._optDeviated.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property optVertical As RadioButton
			Get
				Return Me._optVertical
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optVertical_CheckedChanged
				If Me._optVertical IsNot Nothing Then
					RemoveHandler Me._optVertical.CheckedChanged, value2
				End If
				Me._optVertical = value
				If Me._optVertical IsNot Nothing Then
					AddHandler Me._optVertical.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property grpLanguages As GroupBox
			Get
				Return Me._grpLanguages
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpLanguages = value
			End Set
		End Property

		Friend Overridable Property rbtChinese As RadioButton
			Get
				Return Me._rbtChinese
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtChinese_CheckedChanged
				If Me._rbtChinese IsNot Nothing Then
					RemoveHandler Me._rbtChinese.CheckedChanged, value2
				End If
				Me._rbtChinese = value
				If Me._rbtChinese IsNot Nothing Then
					AddHandler Me._rbtChinese.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property rbtSpan As RadioButton
			Get
				Return Me._rbtSpan
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtSpan_CheckedChanged
				If Me._rbtSpan IsNot Nothing Then
					RemoveHandler Me._rbtSpan.CheckedChanged, value2
				End If
				Me._rbtSpan = value
				If Me._rbtSpan IsNot Nothing Then
					AddHandler Me._rbtSpan.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property rbtEng As RadioButton
			Get
				Return Me._rbtEng
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbtEng_CheckedChanged
				If Me._rbtEng IsNot Nothing Then
					RemoveHandler Me._rbtEng.CheckedChanged, value2
				End If
				Me._rbtEng = value
				If Me._rbtEng IsNot Nothing Then
					AddHandler Me._rbtEng.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblRODSTARDataDict As Label
			Get
				Return Me._lblRODSTARDataDict
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRODSTARDataDict = value
			End Set
		End Property

		Friend Overridable Property txtRODSTARDir As TextBox
			Get
				Return Me._txtRODSTARDir
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtRODSTARDir = value
			End Set
		End Property

		Friend Overridable Property btnDefault As Button
			Get
				Return Me._btnDefault
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnDefault_Click
				If Me._btnDefault IsNot Nothing Then
					RemoveHandler Me._btnDefault.Click, value2
				End If
				Me._btnDefault = value
				If Me._btnDefault IsNot Nothing Then
					AddHandler Me._btnDefault.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property txtWheelFricCoeff As TextBox
			Get
				Return Me._txtWheelFricCoeff
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtWheelFricCoeff_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtWheelFricCoeff_Leave
				Dim value4 As EventHandler = AddressOf Me.txtWheelFricCoeff_Enter
				If Me._txtWheelFricCoeff IsNot Nothing Then
					RemoveHandler Me._txtWheelFricCoeff.TextChanged, value2
					RemoveHandler Me._txtWheelFricCoeff.Leave, value3
					RemoveHandler Me._txtWheelFricCoeff.Enter, value4
				End If
				Me._txtWheelFricCoeff = value
				If Me._txtWheelFricCoeff IsNot Nothing Then
					AddHandler Me._txtWheelFricCoeff.TextChanged, value2
					AddHandler Me._txtWheelFricCoeff.Leave, value3
					AddHandler Me._txtWheelFricCoeff.Enter, value4
				End If
			End Set
		End Property

		Public Overridable Property txtMoldedFricCoeff As TextBox
			Get
				Return Me._txtMoldedFricCoeff
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMoldedFricCoeff_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtMoldedFricCoeff_Leave
				Dim value4 As EventHandler = AddressOf Me.txtMoldedFricCoeff_Enter
				If Me._txtMoldedFricCoeff IsNot Nothing Then
					RemoveHandler Me._txtMoldedFricCoeff.TextChanged, value2
					RemoveHandler Me._txtMoldedFricCoeff.Leave, value3
					RemoveHandler Me._txtMoldedFricCoeff.Enter, value4
				End If
				Me._txtMoldedFricCoeff = value
				If Me._txtMoldedFricCoeff IsNot Nothing Then
					AddHandler Me._txtMoldedFricCoeff.TextChanged, value2
					AddHandler Me._txtMoldedFricCoeff.Leave, value3
					AddHandler Me._txtMoldedFricCoeff.Enter, value4
				End If
			End Set
		End Property

		Friend Overridable Property lblFricCoeff As Label
			Get
				Return Me._lblFricCoeff
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFricCoeff = value
			End Set
		End Property

		Public Overridable Property txtOtherFricCoeff As TextBox
			Get
				Return Me._txtOtherFricCoeff
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtOtherFricCoeff_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtOtherFricCoeff_Leave
				Dim value4 As EventHandler = AddressOf Me.txtOtherFricCoeff_Enter
				If Me._txtOtherFricCoeff IsNot Nothing Then
					RemoveHandler Me._txtOtherFricCoeff.TextChanged, value2
					RemoveHandler Me._txtOtherFricCoeff.Leave, value3
					RemoveHandler Me._txtOtherFricCoeff.Enter, value4
				End If
				Me._txtOtherFricCoeff = value
				If Me._txtOtherFricCoeff IsNot Nothing Then
					AddHandler Me._txtOtherFricCoeff.TextChanged, value2
					AddHandler Me._txtOtherFricCoeff.Leave, value3
					AddHandler Me._txtOtherFricCoeff.Enter, value4
				End If
			End Set
		End Property

		Friend Overridable Property lblWeightAdjustFactor As Label
			Get
				Return Me._lblWeightAdjustFactor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblWeightAdjustFactor = value
			End Set
		End Property

		Friend Overridable Property txtWeightAdjustFactor As TextBox
			Get
				Return Me._txtWeightAdjustFactor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtWeightAdjustFactor = value
			End Set
		End Property

		Friend Overridable Property chkUseFluidInertiaPumpLoadAdj As CheckBox
			Get
				Return Me._chkUseFluidInertiaPumpLoadAdj
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkUseFluidInertiaPumpLoadAdj = value
			End Set
		End Property

		Friend Overridable Property cboRodGrade As ComboBox
			Get
				Return Me._cboRodGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRodGrade_SelectedIndexChanged
				If Me._cboRodGrade IsNot Nothing Then
					RemoveHandler Me._cboRodGrade.SelectedIndexChanged, value2
				End If
				Me._cboRodGrade = value
				If Me._cboRodGrade IsNot Nothing Then
					AddHandler Me._cboRodGrade.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlExpert As Panel
			Get
				Return Me._pnlExpert
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlExpert = value
			End Set
		End Property

		Friend Overridable Property grpPumpUnitManufacturer_Preferences As GroupBox
			Get
				Return Me._grpPumpUnitManufacturer_Preferences
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpPumpUnitManufacturer_Preferences = value
			End Set
		End Property

		Friend Overridable Property grpTubingSizePreferences As GroupBox
			Get
				Return Me._grpTubingSizePreferences
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpTubingSizePreferences = value
			End Set
		End Property

		Friend Overridable Property grpPumpTypePreference As GroupBox
			Get
				Return Me._grpPumpTypePreference
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpPumpTypePreference = value
			End Set
		End Property

		Friend Overridable Property grpRodPreferences As GroupBox
			Get
				Return Me._grpRodPreferences
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpRodPreferences = value
			End Set
		End Property

		Public Overridable Property lblRSFGGrade As Label
			Get
				Return Me._lblRSFGGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSFGGrade = value
			End Set
		End Property

		Public Overridable Property lblRSGrade As Label
			Get
				Return Me._lblRSGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRSGrade = value
			End Set
		End Property

		Public Overridable Property cboHighStrengthRods As ComboBox
			Get
				Return Me._cboHighStrengthRods
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboHighStrengthRods_SelectedIndexChanged
				If Me._cboHighStrengthRods IsNot Nothing Then
					RemoveHandler Me._cboHighStrengthRods.SelectedIndexChanged, value2
				End If
				Me._cboHighStrengthRods = value
				If Me._cboHighStrengthRods IsNot Nothing Then
					AddHandler Me._cboHighStrengthRods.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cboFGlassRods As ComboBox
			Get
				Return Me._cboFGlassRods
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboFGlassRods_SelectedIndexChanged
				If Me._cboFGlassRods IsNot Nothing Then
					RemoveHandler Me._cboFGlassRods.SelectedIndexChanged, value2
				End If
				Me._cboFGlassRods = value
				If Me._cboFGlassRods IsNot Nothing Then
					AddHandler Me._cboFGlassRods.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cboManufMenu4 As ComboBox
			Get
				Return Me._cboManufMenu4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboManufMenu4_SelectedIndexChanged
				If Me._cboManufMenu4 IsNot Nothing Then
					RemoveHandler Me._cboManufMenu4.SelectedIndexChanged, value2
				End If
				Me._cboManufMenu4 = value
				If Me._cboManufMenu4 IsNot Nothing Then
					AddHandler Me._cboManufMenu4.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cboManufMenu3 As ComboBox
			Get
				Return Me._cboManufMenu3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboManufMenu3_SelectedIndexChanged
				If Me._cboManufMenu3 IsNot Nothing Then
					RemoveHandler Me._cboManufMenu3.SelectedIndexChanged, value2
				End If
				Me._cboManufMenu3 = value
				If Me._cboManufMenu3 IsNot Nothing Then
					AddHandler Me._cboManufMenu3.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cboManufMenu2 As ComboBox
			Get
				Return Me._cboManufMenu2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboManufMenu2_SelectedIndexChanged
				If Me._cboManufMenu2 IsNot Nothing Then
					RemoveHandler Me._cboManufMenu2.SelectedIndexChanged, value2
				End If
				Me._cboManufMenu2 = value
				If Me._cboManufMenu2 IsNot Nothing Then
					AddHandler Me._cboManufMenu2.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cboManufMenu1 As ComboBox
			Get
				Return Me._cboManufMenu1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboManufMenu1_SelectedIndexChanged
				If Me._cboManufMenu1 IsNot Nothing Then
					RemoveHandler Me._cboManufMenu1.SelectedIndexChanged, value2
				End If
				Me._cboManufMenu1 = value
				If Me._cboManufMenu1 IsNot Nothing Then
					AddHandler Me._cboManufMenu1.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lblSinkerBars As Label
			Get
				Return Me._lblSinkerBars
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSinkerBars = value
			End Set
		End Property

		Public Overridable Property lblSinkerRods As Label
			Get
				Return Me._lblSinkerRods
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSinkerRods = value
			End Set
		End Property

		Public Overridable Property cboSinkerRodsGrade As ComboBox
			Get
				Return Me._cboSinkerRodsGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboSinkerRodsGrade_SelectedIndexChanged
				If Me._cboSinkerRodsGrade IsNot Nothing Then
					RemoveHandler Me._cboSinkerRodsGrade.SelectedIndexChanged, value2
				End If
				Me._cboSinkerRodsGrade = value
				If Me._cboSinkerRodsGrade IsNot Nothing Then
					AddHandler Me._cboSinkerRodsGrade.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cboSinkerBarsGrade As ComboBox
			Get
				Return Me._cboSinkerBarsGrade
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboSinkerBarsGrade_SelectedIndexChanged
				If Me._cboSinkerBarsGrade IsNot Nothing Then
					RemoveHandler Me._cboSinkerBarsGrade.SelectedIndexChanged, value2
				End If
				Me._cboSinkerBarsGrade = value
				If Me._cboSinkerBarsGrade IsNot Nothing Then
					AddHandler Me._cboSinkerBarsGrade.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property optSinkerRods As RadioButton
			Get
				Return Me._optSinkerRods
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optSinkerRods_CheckedChanged
				If Me._optSinkerRods IsNot Nothing Then
					RemoveHandler Me._optSinkerRods.CheckedChanged, value2
				End If
				Me._optSinkerRods = value
				If Me._optSinkerRods IsNot Nothing Then
					AddHandler Me._optSinkerRods.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property optSinkerBars As RadioButton
			Get
				Return Me._optSinkerBars
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optSinkerBars_CheckedChanged
				If Me._optSinkerBars IsNot Nothing Then
					RemoveHandler Me._optSinkerBars.CheckedChanged, value2
				End If
				Me._optSinkerBars = value
				If Me._optSinkerBars IsNot Nothing Then
					AddHandler Me._optSinkerBars.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtMinTubingSizeOD As TextBox
			Get
				Return Me._txtMinTubingSizeOD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMinTubingSizeOD = value
			End Set
		End Property

		Public Overridable Property txtMaxTubingSizeOD As TextBox
			Get
				Return Me._txtMaxTubingSizeOD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMaxTubingSizeOD_TextChanged
				If Me._txtMaxTubingSizeOD IsNot Nothing Then
					RemoveHandler Me._txtMaxTubingSizeOD.TextChanged, value2
				End If
				Me._txtMaxTubingSizeOD = value
				If Me._txtMaxTubingSizeOD IsNot Nothing Then
					AddHandler Me._txtMaxTubingSizeOD.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cboMaxTubingSizeOD As ComboBox
			Get
				Return Me._cboMaxTubingSizeOD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboMaxTubingSizeOD_SelectedIndexChanged
				If Me._cboMaxTubingSizeOD IsNot Nothing Then
					RemoveHandler Me._cboMaxTubingSizeOD.SelectedIndexChanged, value2
				End If
				Me._cboMaxTubingSizeOD = value
				If Me._cboMaxTubingSizeOD IsNot Nothing Then
					AddHandler Me._cboMaxTubingSizeOD.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cboMinTubingSizeOD As ComboBox
			Get
				Return Me._cboMinTubingSizeOD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._cboMinTubingSizeOD = value
			End Set
		End Property

		Public Overridable Property txtMinTubingSizeID As TextBox
			Get
				Return Me._txtMinTubingSizeID
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMinTubingSizeID = value
			End Set
		End Property

		Public Overridable Property txtMaxTubingSizeID As TextBox
			Get
				Return Me._txtMaxTubingSizeID
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMaxTubingSizeID = value
			End Set
		End Property

		Public Overridable Property _Label_MaxTubingSizeOD As Label
			Get
				Return Me.__Label_MaxTubingSizeOD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_MaxTubingSizeOD = value
			End Set
		End Property

		Public Overridable Property _Label_MinTubingSizeOD As Label
			Get
				Return Me.__Label_MinTubingSizeOD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_MinTubingSizeOD = value
			End Set
		End Property

		Public Overridable Property _Label_MinTubingSizeID As Label
			Get
				Return Me.__Label_MinTubingSizeID
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_MinTubingSizeID = value
			End Set
		End Property

		Public Overridable Property _Label_MaxTubingSizeID As Label
			Get
				Return Me.__Label_MaxTubingSizeID
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_MaxTubingSizeID = value
			End Set
		End Property

		Friend Overridable Property chkTubingPump As CheckBox
			Get
				Return Me._chkTubingPump
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkTubingPump_CheckedChanged
				If Me._chkTubingPump IsNot Nothing Then
					RemoveHandler Me._chkTubingPump.CheckedChanged, value2
				End If
				Me._chkTubingPump = value
				If Me._chkTubingPump IsNot Nothing Then
					AddHandler Me._chkTubingPump.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkLargeBorePump As CheckBox
			Get
				Return Me._chkLargeBorePump
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkLargeBorePump_CheckedChanged
				If Me._chkLargeBorePump IsNot Nothing Then
					RemoveHandler Me._chkLargeBorePump.CheckedChanged, value2
				End If
				Me._chkLargeBorePump = value
				If Me._chkLargeBorePump IsNot Nothing Then
					AddHandler Me._chkLargeBorePump.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkRodstarTubingSizeRec As CheckBox
			Get
				Return Me._chkRodstarTubingSizeRec
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkRodstarTubingSizeRec_CheckedChanged
				If Me._chkRodstarTubingSizeRec IsNot Nothing Then
					RemoveHandler Me._chkRodstarTubingSizeRec.CheckedChanged, value2
				End If
				Me._chkRodstarTubingSizeRec = value
				If Me._chkRodstarTubingSizeRec IsNot Nothing Then
					AddHandler Me._chkRodstarTubingSizeRec.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property grpRodTubingFricCoeffPref As GroupBox
			Get
				Return Me._grpRodTubingFricCoeffPref
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpRodTubingFricCoeffPref = value
			End Set
		End Property

		Friend Overridable Property lblUseXTimes As Label
			Get
				Return Me._lblUseXTimes
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblUseXTimes = value
			End Set
		End Property

		Friend Overridable Property lblcboMaxTubingSizeOD_Disabled As Label
			Get
				Return Me._lblcboMaxTubingSizeOD_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblcboMaxTubingSizeOD_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblcboMinTubingSizeOD_Disabled As Label
			Get
				Return Me._lblcboMinTubingSizeOD_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblcboMinTubingSizeOD_Disabled = value
			End Set
		End Property

		Friend Overridable Property NumericUpDown1_XTimes As NumericUpDown
			Get
				Return Me._NumericUpDown1_XTimes
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Dim value2 As EventHandler = AddressOf Me.NumericUpDown1_XTimes_ValueChanged
				If Me._NumericUpDown1_XTimes IsNot Nothing Then
					RemoveHandler Me._NumericUpDown1_XTimes.ValueChanged, value2
				End If
				Me._NumericUpDown1_XTimes = value
				If Me._NumericUpDown1_XTimes IsNot Nothing Then
					AddHandler Me._NumericUpDown1_XTimes.ValueChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkInsertPump As CheckBox
			Get
				Return Me._chkInsertPump
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkInsertPump_CheckedChanged
				If Me._chkInsertPump IsNot Nothing Then
					RemoveHandler Me._chkInsertPump.CheckedChanged, value2
				End If
				Me._chkInsertPump = value
				If Me._chkInsertPump IsNot Nothing Then
					AddHandler Me._chkInsertPump.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkRodstarPumpTypeRec As CheckBox
			Get
				Return Me._chkRodstarPumpTypeRec
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkRodstarPumpTypeRec_CheckedChanged
				If Me._chkRodstarPumpTypeRec IsNot Nothing Then
					RemoveHandler Me._chkRodstarPumpTypeRec.CheckedChanged, value2
				End If
				Me._chkRodstarPumpTypeRec = value
				If Me._chkRodstarPumpTypeRec IsNot Nothing Then
					AddHandler Me._chkRodstarPumpTypeRec.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblchkInsertPump_Disabled As Label
			Get
				Return Me._lblchkInsertPump_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblchkInsertPump_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblchkTubingPump_Disabled As Label
			Get
				Return Me._lblchkTubingPump_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblchkTubingPump_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblchkLargeBorePump_Disabled As Label
			Get
				Return Me._lblchkLargeBorePump_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblchkLargeBorePump_Disabled = value
			End Set
		End Property

		Friend Overridable Property chkTubingAnchored As CheckBox
			Get
				Return Me._chkTubingAnchored
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkTubingAnchored_CheckedChanged
				If Me._chkTubingAnchored IsNot Nothing Then
					RemoveHandler Me._chkTubingAnchored.CheckedChanged, value2
				End If
				Me._chkTubingAnchored = value
				If Me._chkTubingAnchored IsNot Nothing Then
					AddHandler Me._chkTubingAnchored.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblchkTubingAnchored_Disabled As Label
			Get
				Return Me._lblchkTubingAnchored_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblchkTubingAnchored_Disabled = value
			End Set
		End Property

		Friend Overridable Property chkRodstarTubingAnchoredRec As CheckBox
			Get
				Return Me._chkRodstarTubingAnchoredRec
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkRodstarTubingAnchoredRec_CheckedChanged
				If Me._chkRodstarTubingAnchoredRec IsNot Nothing Then
					RemoveHandler Me._chkRodstarTubingAnchoredRec.CheckedChanged, value2
				End If
				Me._chkRodstarTubingAnchoredRec = value
				If Me._chkRodstarTubingAnchoredRec IsNot Nothing Then
					AddHandler Me._chkRodstarTubingAnchoredRec.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property grpTubingAnchoredPreference As GroupBox
			Get
				Return Me._grpTubingAnchoredPreference
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpTubingAnchoredPreference = value
			End Set
		End Property

		Friend Overridable Property pnlUseRodOnly As Panel
			Get
				Return Me._pnlUseRodOnly
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlUseRodOnly = value
			End Set
		End Property

		Friend Overridable Property imgPreview_6 As PictureBox
			Get
				Return Me._imgPreview_6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_6 = value
			End Set
		End Property

		Friend Overridable Property chkReportOpt_8 As CheckBox
			Get
				Return Me._chkReportOpt_8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_8_CheckedChanged
				If Me._chkReportOpt_8 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_8.CheckedChanged, value2
				End If
				Me._chkReportOpt_8 = value
				If Me._chkReportOpt_8 IsNot Nothing Then
					AddHandler Me._chkReportOpt_8.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property chkOptimizeSurvey As CheckBox
			Get
				Return Me._chkOptimizeSurvey
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkOptimizeSurvey_CheckedChanged
				If Me._chkOptimizeSurvey IsNot Nothing Then
					RemoveHandler Me._chkOptimizeSurvey.CheckedChanged, value2
				End If
				Me._chkOptimizeSurvey = value
				If Me._chkOptimizeSurvey IsNot Nothing Then
					AddHandler Me._chkOptimizeSurvey.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lblManufacturer4 As Label
			Get
				Return Me._lblManufacturer4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblManufacturer4 = value
			End Set
		End Property

		Public Overridable Property lblManufacturer3 As Label
			Get
				Return Me._lblManufacturer3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblManufacturer3 = value
			End Set
		End Property

		Public Overridable Property lblManufacturer2 As Label
			Get
				Return Me._lblManufacturer2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblManufacturer2 = value
			End Set
		End Property

		Public Overridable Property lblManufacturer8 As Label
			Get
				Return Me._lblManufacturer8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblManufacturer8 = value
			End Set
		End Property

		Public Overridable Property lblManufacturer7 As Label
			Get
				Return Me._lblManufacturer7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblManufacturer7 = value
			End Set
		End Property

		Public Overridable Property lblManufacturer6 As Label
			Get
				Return Me._lblManufacturer6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblManufacturer6 = value
			End Set
		End Property

		Public Overridable Property lblManufacturer5 As Label
			Get
				Return Me._lblManufacturer5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblManufacturer5 = value
			End Set
		End Property

		Public Overridable Property cboManufMenu8 As ComboBox
			Get
				Return Me._cboManufMenu8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboManufMenu8_SelectedIndexChanged
				If Me._cboManufMenu8 IsNot Nothing Then
					RemoveHandler Me._cboManufMenu8.SelectedIndexChanged, value2
				End If
				Me._cboManufMenu8 = value
				If Me._cboManufMenu8 IsNot Nothing Then
					AddHandler Me._cboManufMenu8.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cboManufMenu7 As ComboBox
			Get
				Return Me._cboManufMenu7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboManufMenu7_SelectedIndexChanged
				If Me._cboManufMenu7 IsNot Nothing Then
					RemoveHandler Me._cboManufMenu7.SelectedIndexChanged, value2
				End If
				Me._cboManufMenu7 = value
				If Me._cboManufMenu7 IsNot Nothing Then
					AddHandler Me._cboManufMenu7.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cboManufMenu6 As ComboBox
			Get
				Return Me._cboManufMenu6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboManufMenu6_SelectedIndexChanged
				If Me._cboManufMenu6 IsNot Nothing Then
					RemoveHandler Me._cboManufMenu6.SelectedIndexChanged, value2
				End If
				Me._cboManufMenu6 = value
				If Me._cboManufMenu6 IsNot Nothing Then
					AddHandler Me._cboManufMenu6.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property cboManufMenu5 As ComboBox
			Get
				Return Me._cboManufMenu5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboManufMenu5_SelectedIndexChanged
				If Me._cboManufMenu5 IsNot Nothing Then
					RemoveHandler Me._cboManufMenu5.SelectedIndexChanged, value2
				End If
				Me._cboManufMenu5 = value
				If Me._cboManufMenu5 IsNot Nothing Then
					AddHandler Me._cboManufMenu5.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkManufacturer1 As CheckBox
			Get
				Return Me._chkManufacturer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkManufacturer1_CheckedChanged
				If Me._chkManufacturer1 IsNot Nothing Then
					RemoveHandler Me._chkManufacturer1.CheckedChanged, value2
				End If
				Me._chkManufacturer1 = value
				If Me._chkManufacturer1 IsNot Nothing Then
					AddHandler Me._chkManufacturer1.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkManufacturer2 As CheckBox
			Get
				Return Me._chkManufacturer2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkManufacturer2_CheckedChanged
				If Me._chkManufacturer2 IsNot Nothing Then
					RemoveHandler Me._chkManufacturer2.CheckedChanged, value2
				End If
				Me._chkManufacturer2 = value
				If Me._chkManufacturer2 IsNot Nothing Then
					AddHandler Me._chkManufacturer2.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkManufacturer3 As CheckBox
			Get
				Return Me._chkManufacturer3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkManufacturer3_CheckedChanged
				If Me._chkManufacturer3 IsNot Nothing Then
					RemoveHandler Me._chkManufacturer3.CheckedChanged, value2
				End If
				Me._chkManufacturer3 = value
				If Me._chkManufacturer3 IsNot Nothing Then
					AddHandler Me._chkManufacturer3.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkManufacturer4 As CheckBox
			Get
				Return Me._chkManufacturer4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkManufacturer4_CheckedChanged
				If Me._chkManufacturer4 IsNot Nothing Then
					RemoveHandler Me._chkManufacturer4.CheckedChanged, value2
				End If
				Me._chkManufacturer4 = value
				If Me._chkManufacturer4 IsNot Nothing Then
					AddHandler Me._chkManufacturer4.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkManufacturer5 As CheckBox
			Get
				Return Me._chkManufacturer5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkManufacturer5_CheckedChanged
				If Me._chkManufacturer5 IsNot Nothing Then
					RemoveHandler Me._chkManufacturer5.CheckedChanged, value2
				End If
				Me._chkManufacturer5 = value
				If Me._chkManufacturer5 IsNot Nothing Then
					AddHandler Me._chkManufacturer5.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkManufacturer6 As CheckBox
			Get
				Return Me._chkManufacturer6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkManufacturer6_CheckedChanged
				If Me._chkManufacturer6 IsNot Nothing Then
					RemoveHandler Me._chkManufacturer6.CheckedChanged, value2
				End If
				Me._chkManufacturer6 = value
				If Me._chkManufacturer6 IsNot Nothing Then
					AddHandler Me._chkManufacturer6.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkManufacturer7 As CheckBox
			Get
				Return Me._chkManufacturer7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkManufacturer7_CheckedChanged
				If Me._chkManufacturer7 IsNot Nothing Then
					RemoveHandler Me._chkManufacturer7.CheckedChanged, value2
				End If
				Me._chkManufacturer7 = value
				If Me._chkManufacturer7 IsNot Nothing Then
					AddHandler Me._chkManufacturer7.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkManufacturer8 As CheckBox
			Get
				Return Me._chkManufacturer8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkManufacturer8_CheckedChanged
				If Me._chkManufacturer8 IsNot Nothing Then
					RemoveHandler Me._chkManufacturer8.CheckedChanged, value2
				End If
				Me._chkManufacturer8 = value
				If Me._chkManufacturer8 IsNot Nothing Then
					AddHandler Me._chkManufacturer8.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtNorrisFricCoeff As TextBox
			Get
				Return Me._txtNorrisFricCoeff
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtNorrisFricCoeff_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtNorrisFricCoeff_Leave
				Dim value4 As EventHandler = AddressOf Me.txtNorrisFricCoeff_Enter
				If Me._txtNorrisFricCoeff IsNot Nothing Then
					RemoveHandler Me._txtNorrisFricCoeff.TextChanged, value2
					RemoveHandler Me._txtNorrisFricCoeff.Leave, value3
					RemoveHandler Me._txtNorrisFricCoeff.Enter, value4
				End If
				Me._txtNorrisFricCoeff = value
				If Me._txtNorrisFricCoeff IsNot Nothing Then
					AddHandler Me._txtNorrisFricCoeff.TextChanged, value2
					AddHandler Me._txtNorrisFricCoeff.Leave, value3
					AddHandler Me._txtNorrisFricCoeff.Enter, value4
				End If
			End Set
		End Property

		Friend Overridable Property optSideWinder As RadioButton
			Get
				Return Me._optSideWinder
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optSideWinder_CheckedChanged
				If Me._optSideWinder IsNot Nothing Then
					RemoveHandler Me._optSideWinder.CheckedChanged, value2
				End If
				Me._optSideWinder = value
				If Me._optSideWinder IsNot Nothing Then
					AddHandler Me._optSideWinder.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property txtSidewinderLoad As TextBox
			Get
				Return Me._txtSidewinderLoad
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtSidewinderLoad_VisibleChanged
				Dim value3 As EventHandler = AddressOf Me.txtSidewinderLoad_TextChanged
				Dim value4 As EventHandler = AddressOf Me.txtSidewinderLoad_Leave
				Dim value5 As EventHandler = AddressOf Me.txtSidewinderLoad_Enter
				If Me._txtSidewinderLoad IsNot Nothing Then
					RemoveHandler Me._txtSidewinderLoad.VisibleChanged, value2
					RemoveHandler Me._txtSidewinderLoad.TextChanged, value3
					RemoveHandler Me._txtSidewinderLoad.Leave, value4
					RemoveHandler Me._txtSidewinderLoad.Enter, value5
				End If
				Me._txtSidewinderLoad = value
				If Me._txtSidewinderLoad IsNot Nothing Then
					AddHandler Me._txtSidewinderLoad.VisibleChanged, value2
					AddHandler Me._txtSidewinderLoad.TextChanged, value3
					AddHandler Me._txtSidewinderLoad.Leave, value4
					AddHandler Me._txtSidewinderLoad.Enter, value5
				End If
			End Set
		End Property

		Public Overridable Property txtOther As TextBox
			Get
				Return Me._txtOther
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtOther_TextChanged
				If Me._txtOther IsNot Nothing Then
					RemoveHandler Me._txtOther.TextChanged, value2
				End If
				Me._txtOther = value
				If Me._txtOther IsNot Nothing Then
					AddHandler Me._txtOther.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lblGuides As Label
			Get
				Return Me._lblGuides
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGuides = value
			End Set
		End Property

		Public Overridable Property lblMinNumGuides As Label
			Get
				Return Me._lblMinNumGuides
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMinNumGuides = value
			End Set
		End Property

		Public Overridable Property txtMinNumGuides As TextBox
			Get
				Return Me._txtMinNumGuides
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMinNumGuides_TextChanged
				Dim value3 As EventHandler = AddressOf Me.txtMinNumGuides_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtMinNumGuides_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtMinNumGuides_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtMinNumGuides_Enter
				If Me._txtMinNumGuides IsNot Nothing Then
					RemoveHandler Me._txtMinNumGuides.TextChanged, value2
					RemoveHandler Me._txtMinNumGuides.Leave, value3
					RemoveHandler Me._txtMinNumGuides.KeyPress, value4
					RemoveHandler Me._txtMinNumGuides.KeyDown, value5
					RemoveHandler Me._txtMinNumGuides.Enter, value6
				End If
				Me._txtMinNumGuides = value
				If Me._txtMinNumGuides IsNot Nothing Then
					AddHandler Me._txtMinNumGuides.TextChanged, value2
					AddHandler Me._txtMinNumGuides.Leave, value3
					AddHandler Me._txtMinNumGuides.KeyPress, value4
					AddHandler Me._txtMinNumGuides.KeyDown, value5
					AddHandler Me._txtMinNumGuides.Enter, value6
				End If
			End Set
		End Property

		Public Overridable Property lblMaxNumGuides As Label
			Get
				Return Me._lblMaxNumGuides
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMaxNumGuides = value
			End Set
		End Property

		Friend Overridable Property rtbDefault As RichTextBox
			Get
				Return Me._rtbDefault
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Dim value2 As EventHandler = AddressOf Me.rtbDefault_Leave
				If Me._rtbDefault IsNot Nothing Then
					RemoveHandler Me._rtbDefault.Leave, value2
				End If
				Me._rtbDefault = value
				If Me._rtbDefault IsNot Nothing Then
					AddHandler Me._rtbDefault.Leave, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_ As CheckBox
			Get
				Return Me._chkReportOpt_
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt__CheckedChanged
				If Me._chkReportOpt_ IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_.Click, value2
				End If
				Me._chkReportOpt_ = value
				If Me._chkReportOpt_ IsNot Nothing Then
					AddHandler Me._chkReportOpt_.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property imgPreview_ As PictureBox
			Get
				Return Me._imgPreview_
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_ = value
			End Set
		End Property

		Friend Overridable Property grpMotorPreferences As GroupBox
			Get
				Return Me._grpMotorPreferences
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpMotorPreferences = value
			End Set
		End Property

		Friend Overridable Property pnlMotorData As Panel
			Get
				Return Me._pnlMotorData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlMotorData = value
			End Set
		End Property

		Public Overridable Property chkIncludeMotorSPV As CheckBox
			Get
				Return Me._chkIncludeMotorSPV
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkIncludeMotorSPV_CheckedChanged
				If Me._chkIncludeMotorSPV IsNot Nothing Then
					RemoveHandler Me._chkIncludeMotorSPV.CheckedChanged, value2
				End If
				Me._chkIncludeMotorSPV = value
				If Me._chkIncludeMotorSPV IsNot Nothing Then
					AddHandler Me._chkIncludeMotorSPV.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property optPowerMeterType_2 As RadioButton
			Get
				Return Me._optPowerMeterType_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._optPowerMeterType_2 = value
			End Set
		End Property

		Public Overridable Property optPowerMeterType_1 As RadioButton
			Get
				Return Me._optPowerMeterType_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optPowerMeterType_1_CheckedChanged
				If Me._optPowerMeterType_1 IsNot Nothing Then
					RemoveHandler Me._optPowerMeterType_1.CheckedChanged, value2
				End If
				Me._optPowerMeterType_1 = value
				If Me._optPowerMeterType_1 IsNot Nothing Then
					AddHandler Me._optPowerMeterType_1.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _Label_MeterType As Label
			Get
				Return Me.__Label_MeterType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_MeterType = value
			End Set
		End Property

		Public Overridable Property cboUHSProrod As ComboBox
			Get
				Return Me._cboUHSProrod
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboUHSProrod_SelectedIndexChanged
				If Me._cboUHSProrod IsNot Nothing Then
					RemoveHandler Me._cboUHSProrod.SelectedIndexChanged, value2
				End If
				Me._cboUHSProrod = value
				If Me._cboUHSProrod IsNot Nothing Then
					AddHandler Me._cboUHSProrod.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkAIUseCustomizedLists As CheckBox
			Get
				Return Me._chkAIUseCustomizedLists
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkAIUseCustomizedLists_CheckedChanged
				If Me._chkAIUseCustomizedLists IsNot Nothing Then
					RemoveHandler Me._chkAIUseCustomizedLists.CheckedChanged, value2
				End If
				Me._chkAIUseCustomizedLists = value
				If Me._chkAIUseCustomizedLists IsNot Nothing Then
					AddHandler Me._chkAIUseCustomizedLists.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lblServiceFactor As Label
			Get
				Return Me._lblServiceFactor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblServiceFactor = value
			End Set
		End Property

		Public Overridable Property txtServiceFactorPreference As TextBox
			Get
				Return Me._txtServiceFactorPreference
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtServiceFactorPreference_Leave
				Dim value3 As EventHandler = AddressOf Me.txtServiceFactorPreference_TextChanged
				If Me._txtServiceFactorPreference IsNot Nothing Then
					RemoveHandler Me._txtServiceFactorPreference.Leave, value2
					RemoveHandler Me._txtServiceFactorPreference.TextChanged, value3
				End If
				Me._txtServiceFactorPreference = value
				If Me._txtServiceFactorPreference IsNot Nothing Then
					AddHandler Me._txtServiceFactorPreference.Leave, value2
					AddHandler Me._txtServiceFactorPreference.TextChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property lblUseAvgFric As Label
			Get
				Return Me._lblUseAvgFric
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblUseAvgFric = value
			End Set
		End Property

		Friend Overridable Property chkDisplaySBinFeet As CheckBox
			Get
				Return Me._chkDisplaySBinFeet
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkDisplaySBinFeet_CheckedChanged
				If Me._chkDisplaySBinFeet IsNot Nothing Then
					RemoveHandler Me._chkDisplaySBinFeet.CheckedChanged, value2
				End If
				Me._chkDisplaySBinFeet = value
				If Me._chkDisplaySBinFeet IsNot Nothing Then
					AddHandler Me._chkDisplaySBinFeet.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property optUseSteelRodsOnly As RadioButton
			Get
				Return Me._optUseSteelRodsOnly
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optUseSteelRodsOnly_CheckedChanged
				If Me._optUseSteelRodsOnly IsNot Nothing Then
					RemoveHandler Me._optUseSteelRodsOnly.CheckedChanged, value2
				End If
				Me._optUseSteelRodsOnly = value
				If Me._optUseSteelRodsOnly IsNot Nothing Then
					AddHandler Me._optUseSteelRodsOnly.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property optUseFGlassWithSteelOnBottom As RadioButton
			Get
				Return Me._optUseFGlassWithSteelOnBottom
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.optUseFGlassWithSteelOnBottom_CheckedChanged
				If Me._optUseFGlassWithSteelOnBottom IsNot Nothing Then
					RemoveHandler Me._optUseFGlassWithSteelOnBottom.CheckedChanged, value2
				End If
				Me._optUseFGlassWithSteelOnBottom = value
				If Me._optUseFGlassWithSteelOnBottom IsNot Nothing Then
					AddHandler Me._optUseFGlassWithSteelOnBottom.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkReportOpt_9 As CheckBox
			Get
				Return Me._chkReportOpt_9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkReportOpt_9_CheckedChanged
				Dim value3 As EventHandler = AddressOf Me.chkReportOpt_9_CheckedChanged
				If Me._chkReportOpt_9 IsNot Nothing Then
					RemoveHandler Me._chkReportOpt_9.Click, value2
					RemoveHandler Me._chkReportOpt_9.CheckedChanged, value3
				End If
				Me._chkReportOpt_9 = value
				If Me._chkReportOpt_9 IsNot Nothing Then
					AddHandler Me._chkReportOpt_9.Click, value2
					AddHandler Me._chkReportOpt_9.CheckedChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property imgPreview_9 As PictureBox
			Get
				Return Me._imgPreview_9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgPreview_9 = value
			End Set
		End Property

		Friend Overridable Property cboSidewinder As ComboBox
			Get
				Return Me._cboSidewinder
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboSidewinder_SelectedIndexChanged
				If Me._cboSidewinder IsNot Nothing Then
					RemoveHandler Me._cboSidewinder.SelectedIndexChanged, value2
				End If
				Me._cboSidewinder = value
				If Me._cboSidewinder IsNot Nothing Then
					AddHandler Me._cboSidewinder.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property grpWarnings As GroupBox
			Get
				Return Me._grpWarnings
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpWarnings = value
			End Set
		End Property

		Public Overridable Property chkTargetBFPDWarning As CheckBox
			Get
				Return Me._chkTargetBFPDWarning
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkTargetBFPDWarning_CheckedChanged
				If Me._chkTargetBFPDWarning IsNot Nothing Then
					RemoveHandler Me._chkTargetBFPDWarning.CheckedChanged, value2
				End If
				Me._chkTargetBFPDWarning = value
				If Me._chkTargetBFPDWarning IsNot Nothing Then
					AddHandler Me._chkTargetBFPDWarning.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property chkRunTimeWarning As CheckBox
			Get
				Return Me._chkRunTimeWarning
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkRunTimeWarning_CheckedChanged
				If Me._chkRunTimeWarning IsNot Nothing Then
					RemoveHandler Me._chkRunTimeWarning.CheckedChanged, value2
				End If
				Me._chkRunTimeWarning = value
				If Me._chkRunTimeWarning IsNot Nothing Then
					AddHandler Me._chkRunTimeWarning.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkUseAllDiameters As CheckBox
			Get
				Return Me._chkUseAllDiameters
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkUseAllDiameters_CheckedChanged
				If Me._chkUseAllDiameters IsNot Nothing Then
					RemoveHandler Me._chkUseAllDiameters.CheckedChanged, value2
				End If
				Me._chkUseAllDiameters = value
				If Me._chkUseAllDiameters IsNot Nothing Then
					AddHandler Me._chkUseAllDiameters.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property chkPlotAllDownholeCards As CheckBox
			Get
				Return Me._chkPlotAllDownholeCards
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkPlotAllDownholeCards_CheckedChanged
				If Me._chkPlotAllDownholeCards IsNot Nothing Then
					RemoveHandler Me._chkPlotAllDownholeCards.CheckedChanged, value2
				End If
				Me._chkPlotAllDownholeCards = value
				If Me._chkPlotAllDownholeCards IsNot Nothing Then
					AddHandler Me._chkPlotAllDownholeCards.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblStatus As Label
			Get
				Return Me._lblStatus
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblStatus = value
			End Set
		End Property

		Friend Overridable Property chkUseBucklingTendencyStresses As CheckBox
			Get
				Return Me._chkUseBucklingTendencyStresses
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkUseBucklingTendencyStresses = value
			End Set
		End Property

		Friend Overridable Property chkUseJohnsFix As CheckBox
			Get
				Return Me._chkUseJohnsFix
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkUseJohnsFix = value
			End Set
		End Property

		Friend Overridable Property chkUseJeffsFix As CheckBox
			Get
				Return Me._chkUseJeffsFix
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkUseJeffsFix = value
			End Set
		End Property

		Public Overridable Property txtElectricityCostPreference As TextBox
			Get
				Return Me._txtElectricityCostPreference
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtElectricityCostPreference_Leave
				Dim value3 As EventHandler = AddressOf Me.txtElectricityCostPreference_TextChanged
				If Me._txtElectricityCostPreference IsNot Nothing Then
					RemoveHandler Me._txtElectricityCostPreference.Leave, value2
					RemoveHandler Me._txtElectricityCostPreference.TextChanged, value3
				End If
				Me._txtElectricityCostPreference = value
				If Me._txtElectricityCostPreference IsNot Nothing Then
					AddHandler Me._txtElectricityCostPreference.Leave, value2
					AddHandler Me._txtElectricityCostPreference.TextChanged, value3
				End If
			End Set
		End Property

		Public Overridable Property _Label_ElectricityCost As Label
			Get
				Return Me.__Label_ElectricityCost
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_ElectricityCost = value
			End Set
		End Property

		Friend Overridable Property chkAlwaysSaveXDIAGMeasuredCard As CheckBox
			Get
				Return Me._chkAlwaysSaveXDIAGMeasuredCard
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkAlwaysSaveXDIAGMeasuredCard_CheckedChanged
				If Me._chkAlwaysSaveXDIAGMeasuredCard IsNot Nothing Then
					RemoveHandler Me._chkAlwaysSaveXDIAGMeasuredCard.CheckedChanged, value2
				End If
				Me._chkAlwaysSaveXDIAGMeasuredCard = value
				If Me._chkAlwaysSaveXDIAGMeasuredCard IsNot Nothing Then
					AddHandler Me._chkAlwaysSaveXDIAGMeasuredCard.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Shared Property DefInstance As RswinSetup
			Get
				If RswinSetup.m_vb6FormDefInstance Is Nothing OrElse RswinSetup.m_vb6FormDefInstance.IsDisposed Then
					RswinSetup.m_InitializingDefInstance = True
					RswinSetup.m_vb6FormDefInstance = New RswinSetup()
					RswinSetup.m_InitializingDefInstance = False
				End If
				Return RswinSetup.m_vb6FormDefInstance
			End Get
			Set(value As RswinSetup)
				RswinSetup.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub LoadOptions()
			' The following expression was wrapped in a checked-expression
			Me.miOldMeasurementSystem = CShort(RSWIN_DESC.SETUP_MeasurementSystem)
			Me.chkPrintResults.CheckState = If((-If((Util.CheckBoxValue(RSWIN_DESC.SETUP_BatchPrintResults <> 0S) > False), CheckState.Checked, CheckState.Unchecked)), CheckState.Checked, CheckState.Unchecked)
			Me.chkCreateWK1.CheckState = If((-If((Util.CheckBoxValue(RSWIN_DESC.SETUP_BatchSaveWorksheet <> 0) > False), CheckState.Checked, CheckState.Unchecked)), CheckState.Checked, CheckState.Unchecked)
			Me.chkViewWK1.CheckState = If((-If((Util.CheckBoxValue(RSWIN_DESC.SETUP_BatchViewWorksheet <> 0) > False), CheckState.Checked, CheckState.Unchecked)), CheckState.Checked, CheckState.Unchecked)
			Me.chkSkipProcessedFiles.CheckState = If((-If((Util.CheckBoxValue(RSWIN_DESC.SETUP_BatchSkipProcessedFiles <> 0) > False), CheckState.Checked, CheckState.Unchecked)), CheckState.Checked, CheckState.Unchecked)
			Me.chkExcelInstalled.CheckState = If((-If((Util.CheckBoxValue(RSWIN_DESC.SETUP_ExcelInstalled) > False), CheckState.Checked, CheckState.Unchecked)), CheckState.Checked, CheckState.Unchecked)
			Me.chkCreatePDFs.CheckState = If((-If((Util.CheckBoxValue(RSWIN_DESC.SETUP_CreatePDFs <> 0) > False), CheckState.Checked, CheckState.Unchecked)), CheckState.Checked, CheckState.Unchecked)
			Me.chkReportOpt_Click_1(1, RSWIN_DESC.SETUP_PrintCostAnalysis <> 0S, True)
			Me.chkReportOpt_Click_1(2, RSWIN_DESC.SETUP_PrintIPR <> 0S, True)
			Me.chkReportOpt_Click_1(3, RSWIN_DESC.SETUP_PrintDynoPred <> 0S, True)
			Me.chkReportOpt_Click_1(0, RSWIN_DESC.SETUP_PrintData <> 0S, True)
			Me.chkReportOpt_Click_1(6, RSWIN_DESC.SETUP_PrintDynoActual <> 0S, True)
			Me.chkReportOpt_Click_1(7, RSWIN_DESC.SETUP_SummaryPage <> 0S, True)
			Me.chkReportOpt_Click_1(9, RSWIN_DESC.SETUP_ScoringPage <> 0S, True)
			Me.chkReportOpt_Click_1(4, RSWIN_DESC.SETUP_PrintDevChart <> 0S, True)
			Me.chkReportOpt_Click_1(5, RSWIN_DESC.SETUP_PrintGuide <> 0S, True)
			Me.chkReportOpt_Click_1(8, RSWIN_DESC.SETUP_ReportDevSurvey <> 0S, True)
			Dim text As String
			Dim text2 As String
			If(CInt((Not CInt(RSWIN_DESC.SETUP_PrintData))) And Not RSWIN_DESC.SETUP_PrintDiagnosis And CInt((Not CInt(RSWIN_DESC.SETUP_PrintIPR))) And CInt((Not CInt(RSWIN_DESC.SETUP_PrintSinglePageDynoTorque))) And CInt((Not CInt(RSWIN_DESC.SETUP_PrintTorque)))) <> 0 Then
				RSWIN_DESC.SETUP_PrintData = -1S
				RSWIN_DESC.SETUP_PrintDiagnosis = -1
				RSWIN_DESC.SETUP_PrintIPR = -1S
				RSWIN_DESC.SETUP_PrintSinglePageDynoTorque = 0S
				RSWIN_DESC.SETUP_PrintTorque = 0S
				RSWIN_DESC.SETUP_PrintDynoPred = 0S
				RSWIN_DESC.SETUP_PrintDynoActual = 0S
				RSWIN_DESC.SETUP_PrintDevChart = 0S
				RSWIN_DESC.SETUP_PrintGuide = 0S
				RSWIN_DESC.SETUP_ReportDevSurvey = 0S
				RSWIN_DESC.rst.gbCoverPage = (RSWIN_DESC.SETUP_CoverPage <> 0S)
				RSWIN_DESC.rst.gbOrderPage = (RSWIN_DESC.SETUP_OrderPage <> 0S)
				RSWIN_DESC.rst.gbReportData = (RSWIN_DESC.SETUP_PrintData <> 0S)
				RSWIN_DESC.rst.gbReportIPR = (RSWIN_DESC.SETUP_PrintIPR <> 0S)
				RSWIN_DESC.rst.gbReportSinglePageDynoTorque = (RSWIN_DESC.SETUP_PrintSinglePageDynoTorque <> 0S)
				RSWIN_DESC.rst.gbReportTorque = (RSWIN_DESC.SETUP_PrintTorque <> 0S)
				RSWIN_DESC.rst.gbReportDynoPred = (RSWIN_DESC.SETUP_PrintDynoPred <> 0S)
				RSWIN_DESC.rst.gbReportDynoActual = (RSWIN_DESC.SETUP_PrintDynoActual <> 0S)
				RSWIN_DESC.rst.gbReportDevChart = (RSWIN_DESC.SETUP_PrintDevChart <> 0S)
				RSWIN_DESC.rst.gbReportGuide = (RSWIN_DESC.SETUP_PrintGuide <> 0S)
				RSWIN_DESC.rst.gbReportDevSurvey = (RSWIN_DESC.SETUP_ReportDevSurvey <> 0S)
				text = "CoverPage"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_CoverPage)
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				text2 = "OrderPage"
				text = Convert.ToString(RSWIN_DESC.SETUP_OrderPage)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "OrderPage"
				text = Convert.ToString(RSWIN_DESC.SETUP_OrderPage)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintData"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintData)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintDiagnosis"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDiagnosis)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintDynoPred"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintDynoActual"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoActual)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintIPR"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintIPR)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintSinglePageDynoTorque"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintTorque"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintDevChart"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDevChart)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintGuide"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintGuide)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "ReportDevSurvey"
				text = Convert.ToString(RSWIN_DESC.SETUP_ReportDevSurvey)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
			End If
			Me.txtMaxFGLoading.Text = Convert.ToString(RSWIN_DESC.SETUP_MaxFGLoading * 100F)
			Me.txtMaxSteelLoading.Text = Convert.ToString(RSWIN_DESC.SETUP_MaxSteelLoading * 100F)
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bRodStarD Then
				Me.grpRatio.Visible = True
				Me.txtGearBoxRatio.Text = RSWIN_DESC.SETUP_GearboxRatio.ToString()
				Me.txtVBeltRatio.Text = RSWIN_DESC.SETUP_VBeltRatio.ToString()
			Else
				Me.grpRatio.Visible = False
				RSWIN_DESC.SETUP_GearboxRatio = 28.45F
				RSWIN_DESC.SETUP_VBeltRatio = 3.2961F
			End If
			Select Case RSWIN_DESC.DEBUG_SetNcycles
				Case 3S
					Me.optNcycles_0.Checked = True
				Case 4S
					Me.optNcycles_1.Checked = True
				Case 5S
					Me.optNcycles_2.Checked = True
				Case 6S
					Me.optNcycles_3.Checked = True
			End Select
			Dim lvwCustomRG As ListView = Me.lvwCustomRG
			lvwCustomRG.View = View.Details
			lvwCustomRG.MultiSelect = False
			lvwCustomRG.FullRowSelect = True
			lvwCustomRG.Items.Clear()
			Dim text3 As String
			FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), text3, 2S, False, False, False, False)
			If Operators.CompareString(text3.Trim(), "", False) <> 0 Then
				Custom.LoadCustomRodGradeList(RSWIN_DESC.CustomRodGradeList, False, "")
			Else
				CUSTOMRG.LoadCustomRodGradeList(RSWIN_DESC.CustomRodGradeList, False)
			End If
			lvwCustomRG.Columns.Clear()
			lvwCustomRG.Columns.Add(Me.csHDR_RodType, 150, HorizontalAlignment.Center)
			lvwCustomRG.Columns.Add(Me.csHDR_TENSILE, 100, HorizontalAlignment.Center)
			lvwCustomRG.Columns.Add(Me.csHDR_STRESS, 220, HorizontalAlignment.Center)
			lvwCustomRG.Columns.Add(Me.csHDR_SINKERBAR, 80, HorizontalAlignment.Center)
			Me.mcCustomRodGrades = 0
			Dim num2 As Integer = 1
			Dim num3 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
			For i As Integer = num2 To num3
				Me.mcCustomRodGrades += 1
				Dim listViewItem As ListViewItem = lvwCustomRG.Items.Add("RodType")
				listViewItem.Text = RSWIN_DESC.CustomRodGradeList(i).RodType.Trim()
				listViewItem.SubItems.Add("TensileStrength").Text = Conversions.ToString(RSWIN_DESC.CustomRodGradeList(i).TensileStrength)
				listViewItem.SubItems.Add("StressMethod").Text = RODUTIL.StressMethodName(RSWIN_DESC.CustomRodGradeList(i).StressMethod)
				If RSWIN_DESC.CustomRodGradeList(i).SinkerBar <> 0S Then
					listViewItem.SubItems.Add("SinkerBar").Text = "Yes"
				Else
					listViewItem.SubItems.Add("SinkerBar").Text = "No"
				End If
			Next
			Me.txtMaxFGLoading.Text = Convert.ToString(RSWIN_DESC.SETUP_MaxFGLoading * 100F)
			Me.txtMaxSteelLoading.Text = Convert.ToString(RSWIN_DESC.SETUP_MaxSteelLoading * 100F)
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bRodStarD Then
				Me.grpRatio.Visible = True
				Me.txtGearBoxRatio.Text = RSWIN_DESC.SETUP_GearboxRatio.ToString()
				Me.txtVBeltRatio.Text = RSWIN_DESC.SETUP_VBeltRatio.ToString()
			Else
				Me.grpRatio.Visible = False
				RSWIN_DESC.SETUP_GearboxRatio = 28.45F
				RSWIN_DESC.SETUP_VBeltRatio = 3.2961F
			End If
			text2 = "BareRodLoad"
			Dim num4 As Single = 50F
			RSWIN_DESC.SETUP_BAREROD_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num4))
			text2 = "MoldedLoad"
			num4 = 40F
			RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num4))
			text2 = "WheelLoad"
			num4 = 25F
			RSWIN_DESC.SETUP_WHEELGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num4))
			text2 = "OtherLoad"
			num4 = 32.5F
			RSWIN_DESC.SETUP_OTHERGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num4))
			text2 = "MaxSideLoadLimit"
			num4 = 30F
			RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num4))
			text2 = "RodGuideOverlap"
			num4 = 150F
			RSWIN_DESC.Setup_RodGuideOverlap = Conversions.ToInteger(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num4))
			text2 = "NumRodsPerBundle"
			num4 = 30F
			RSWIN_DESC.Setup_NumRodsPerBundle = Conversions.ToInteger(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num4))
			Dim text4 As String = New String(" "c, 8192)
			text2 = "OtherGuide"
			text = "Other"
			Dim length As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, text4, True))
			Me.txtOther.Text = text4.Substring(0, CInt(length))
			Dim sDefaultName As String = "SteelSuckerRodLength"
			Dim value As Object = DBNull.Value
			Dim flag As Boolean = False
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag))
			RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
			text2 = "BareRodFricCoeff"
			num4 = 0.2F
			RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num4))
			text2 = "MoldedFricCoeff"
			RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fDefaultFricCoeff))
			text2 = "WheelFricCoeff"
			RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fDefaultFricCoeff))
			text2 = "OtherFricCoeff"
			RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fDefaultFricCoeff))
			text2 = "NorrisStandardGuideFricCoeff"
			RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "NorrisSidewinderGuideFricCoeff"
			RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "RGIJakeCouplingGuideFricCoeff"
			RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "RGISVTGuideFricCoeff"
			RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "RGITomahawkGuideFricCoeff"
			RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "RGITornadoGuideFricCoeff"
			RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "RGITwisterGuideFricCoeff"
			RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "RGIWVTSETGuideFricCoeff"
			RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fDefaultFricCoeff))
			Me.txtMoldedFricCoeff.Text = Conversions.ToString(RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF)
			Me.txtWheelFricCoeff.Text = Conversions.ToString(RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF)
			Me.txtOtherFricCoeff.Text = Conversions.ToString(RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF)
			Me.txtBareRodFricCoeff.Text = Conversions.ToString(RSWIN_DESC.SETUP_BAREROD_FRICCOEFF)
			text2 = "MaxNumGuidesPerRod"
			Dim num5 As Integer = 6
			RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num5))
			text2 = "MinNumGuidesPerRod"
			num5 = 3
			RSWIN_DESC.SETUP_MinNumGuidesPerRod = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num5))
			Me.txtMoldedLoad.Text = RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD.ToString()
			Me.txtWheelLoad.Text = RSWIN_DESC.SETUP_WHEELGUIDE_LOAD.ToString()
			Dim txtMaxSideLoadLimit As TextBox = Me.txtMaxSideLoadLimit
			num4 = RSWIN_DESC.SETUP_MaxSideLoadLimit
			txtMaxSideLoadLimit.Text = num4.ToString()
			Me.txtNumImplIters.Text = RSWIN_DESC.Setup_NumImplIters.ToString()
			Me.txtNumRodsPerBundle.Text = Conversions.ToString(RSWIN_DESC.Setup_NumRodsPerBundle)
			If RSWIN_DESC.bRodStarD Then
				text2 = "AlterSBPumpDepth"
				flag = True
				RSWIN_DESC.Setup_bAlterSBPumpDepth = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
				Me.chkRelocateSB.Checked = (RSWIN_DESC.Setup_bAlterSBPumpDepth <> 0S)
				text2 = "InclinationLimit"
				num4 = 4F
				RSWIN_DESC.Setup_fInclinationLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num4))
				Me.txtInclinationLimit.Text = Convert.ToString(RSWIN_DESC.Setup_fInclinationLimit)
			End If
			text2 = "MDInt"
			num5 = 25
			RSWIN_DESC.SETUP_MDInt = Conversions.ToSingle(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num5))
			text2 = "DoglegLimit"
			num5 = 5
			RSWIN_DESC.SETUP_DoglegLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num5))
			Dim txtMDInt As TextBox = Me.txtMDInt
			num4 = RSWIN_DESC.SETUP_MDInt
			txtMDInt.Text = num4.ToString()
			Dim txtDoglegLimit As TextBox = Me.txtDoglegLimit
			num4 = RSWIN_DESC.SETUP_DoglegLimit
			txtDoglegLimit.Text = num4.ToString()
			text2 = "GuideToUse"
			num5 = CInt(RSWIN_DESC.MOLDED)
			Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num5)
			RSWIN_DESC.MOLDED = CShort(num5)
			RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
			If RSWIN_DESC.SETUP_GuideToUse = 0 Then
				RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.MOLDED)
				text2 = "GuideToUse"
				text = Conversions.ToString(CInt(RSWIN_DESC.MOLDED))
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.MOLDED = Conversions.ToShort(text)
			End If
			Dim setup_GuideToUse As Integer = RSWIN_DESC.SETUP_GuideToUse
			If setup_GuideToUse = 0 Then
				Me.rbtBareRod.Checked = True
			ElseIf setup_GuideToUse = CInt(RSWIN_DESC.MOLDED) Then
				Me.optMolded.Checked = True
			ElseIf setup_GuideToUse = 2 Then
				Me.optWheel.Checked = True
			ElseIf setup_GuideToUse = 3 Then
				Me.optOther.Checked = True
			ElseIf setup_GuideToUse = 4 Then
				Me.optSideWinder.Checked = True
				Me.cboSidewinder.SelectedIndex = 0
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_NorrisStandardGuide_Load)
			ElseIf setup_GuideToUse = CInt(RSWIN_DESC.NorrisSidewinderGuide) Then
				Me.optSideWinder.Checked = True
				Me.cboSidewinder.SelectedIndex = 1
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_NorrisSidewinderGuide_Load)
			ElseIf setup_GuideToUse = 6 Then
				Me.optSideWinder.Checked = True
				Me.cboSidewinder.SelectedIndex = 2
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_RGIJakeCouplingGuide_Load)
			ElseIf setup_GuideToUse = 7 Then
				Me.optSideWinder.Checked = True
				Me.cboSidewinder.SelectedIndex = 3
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_RGISVTGuide_LOAD)
			ElseIf setup_GuideToUse = 8 Then
				Me.optSideWinder.Checked = True
				Me.cboSidewinder.SelectedIndex = 4
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_RGITomahawkGuide_LOAD)
			ElseIf setup_GuideToUse = 9 Then
				Me.optSideWinder.Checked = True
				Me.cboSidewinder.SelectedIndex = 5
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_RGITornadoGuide_LOAD)
			ElseIf setup_GuideToUse = 10 Then
				Me.optSideWinder.Checked = True
				Me.cboSidewinder.SelectedIndex = 6
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_RGITwisterGuide_LOAD)
			ElseIf setup_GuideToUse = 11 Then
				Me.optSideWinder.Checked = True
				Me.cboSidewinder.SelectedIndex = 7
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_RGIWVTGuide_LOAD)
			Else
				Me.optMolded.Checked = True
			End If
			text2 = "ParaffinRodGuide"
			num5 = RSWIN_DESC.SETUP_GuideToUse
			Dim regProfileStringByInt2 As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num5)
			RSWIN_DESC.SETUP_GuideToUse = num5
			RSWIN_DESC.SETUP_ParaffinRodGuide = Conversions.ToInteger(regProfileStringByInt2)
			Try
				If Me.cboParaffinRodGuide.Items.Count > 0 Then
					Me.cboParaffinRodGuide.SelectedValue = RSWIN_DESC.SETUP_ParaffinRodGuide
				End If
			Catch ex As Exception
			End Try
			Me.txtMaxNumGuides.Text = Convert.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod)
			Me.txtMinNumGuides.Text = Convert.ToString(RSWIN_DESC.SETUP_MinNumGuidesPerRod)
			Me.chkAzDirToolbar.Checked = (RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR <> 0S)
			text2 = "OptimizeSurvey"
			flag = False
			RSWIN_DESC.SETUP_OPTIMIZESURVEY = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_OPTIMIZESURVEY = 0S
			Me.chkOptimizeSurvey.Checked = (RSWIN_DESC.SETUP_OPTIMIZESURVEY <> 0S)
			RSWIN_DESC.SETUP_WeightAdjFactor = 2.5F
			If RSWIN_DESC.bExpert And Not Me.bExpertLoaded Then
				Me.LoadExpertPanel()
				Me.bExpertLoaded = True
			End If
			text2 = "NumCycles"
			num5 = 4
			RSWIN_DESC.SETUP_NumCycles = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num5))
			Dim txtNumCycles As TextBox = Me.txtNumCycles
			num5 = RSWIN_DESC.SETUP_NumCycles
			txtNumCycles.Text = num5.ToString()
		End Sub

		Private Sub FSetup_Closing(eventSender As Object, eventArgs As CancelEventArgs)
			Dim num As Short = If((-If((eventArgs.Cancel > False), 1S, 0S)), 1S, 0S)
			num = 0S
			Dim num2 As Short = num
			Dim txtMaxFGLoading As TextBox = Me.txtMaxFGLoading
			Dim bValidIfEmpty As Boolean = True
			Dim bShowMessage As Boolean = True
			Dim obj As Object = Me.mvRodLoadingFG
			Dim num3 As Integer = If(CtrlUI.CheckValid(txtMaxFGLoading, bValidIfEmpty, bShowMessage, obj), 1, 0)
			Me.mvRodLoadingFG = Conversions.ToSingle(obj)
			num = (num2 Or If((-If(((num3 = 0) > False), 1S, 0S)), 1S, 0S))
			Dim num4 As Short = num
			Dim txtMaxSteelLoading As TextBox = Me.txtMaxSteelLoading
			Dim bValidIfEmpty2 As Boolean = True
			Dim bShowMessage2 As Boolean = True
			obj = Me.mvRodLoadingSteel
			Dim num5 As Integer = If(CtrlUI.CheckValid(txtMaxSteelLoading, bValidIfEmpty2, bShowMessage2, obj), 1, 0)
			Me.mvRodLoadingSteel = Conversions.ToSingle(obj)
			num = (num4 Or If((-If(((num5 = 0) > False), 1S, 0S)), 1S, 0S))
			If num <> 0S Then
				Return
			End If
			If Information.IsDBNull(Me.mvRodLoadingFG) Then
				Me.mvRodLoadingFG = 95F
			End If
			Dim num6 As Single = Me.mvRodLoadingFG
			If num6 < 75F OrElse num6 > 100F Then
				Me.mvRodLoadingFG = 100F
			End If
			If Information.IsDBNull(Me.mvRodLoadingSteel) Then
				Me.mvRodLoadingSteel = 95F
			End If
			Dim num7 As Single = Me.mvRodLoadingSteel
			If num7 < 75F OrElse num7 > 100F Then
				Me.mvRodLoadingSteel = 100F
			End If
			Dim flag As Boolean = num <> 0S
			Me.StoreOptions(flag)
			num = If((-If((flag > False), 1S, 0S)), 1S, 0S)
			Try
				If Me.SAVE_SETUP_GuideToUse <> RSWIN_DESC.SETUP_GuideToUse AndAlso RSWIN_DESC.rst IsNot Nothing Then
					Dim num8 As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num8 To numRods
						If CInt(RSWIN_DESC.rst.Sections(i).Guide) <> RSWIN_DESC.SETUP_GuideToUse Then
							RSWIN_DESC.rst.Sections(i).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
						End If
					Next
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub StoreOptions(ByRef bCancel As Boolean)
			bCancel = False
			Try
				If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bChangeCultures Then
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
				End If
				RSWIN_DESC.SETUP_BatchPrintResults = If((-If((Me.chkPrintResults.Checked > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_BatchSaveWorksheet = If((-If((Me.chkCreateWK1.Checked > False), 1, 0)), 1, 0)
				RSWIN_DESC.SETUP_BatchViewWorksheet = If((-If((Me.chkViewWK1.Checked > False), 1, 0)), 1, 0)
				RSWIN_DESC.SETUP_BatchSkipProcessedFiles = If((-If((Me.chkSkipProcessedFiles.Checked > False), 1, 0)), 1, 0)
				RSWIN_DESC.SETUP_ExcelInstalled = Me.chkExcelInstalled.Checked
				RSWIN_DESC.SETUP_CreatePDFs = If((-If((Me.chkCreatePDFs.Checked > False), 1, 0)), 1, 0)
				If Not Information.IsDBNull(Me.mvRodLoadingFG) Then
					RSWIN_DESC.SETUP_MaxFGLoading = Me.mvRodLoadingFG / 100F
				Else
					RSWIN_DESC.SETUP_MaxFGLoading = 0.95F
				End If
				If Not Information.IsDBNull(Me.mvRodLoadingSteel) Then
					RSWIN_DESC.SETUP_MaxSteelLoading = Me.mvRodLoadingSteel / 100F
				Else
					RSWIN_DESC.SETUP_MaxSteelLoading = 0.95F
				End If
				RSWIN_DESC.rst.gbCoverPage = Me.GetChkReportOpt(-1)
				RSWIN_DESC.rst.gbOrderPage = Me.GetChkReportOpt(10)
				RSWIN_DESC.rst.gbSummaryPage = Me.GetChkReportOpt(7)
				RSWIN_DESC.rst.gbScoringPage = Me.GetChkReportOpt(9)
				RSWIN_DESC.rst.gbReportCostAnalysis = If((-If((Me.GetChkReportOpt(1) > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.rst.gbReportData = Me.GetChkReportOpt(0)
				RSWIN_DESC.rst.gbReportIPR = Conversions.ToBoolean(Interaction.IIf(Me.GetChkReportOptEnabled(2), Me.GetChkReportOpt(2), False))
				RSWIN_DESC.rst.gbReportDynoActual = Conversions.ToBoolean(Interaction.IIf(Me.GetChkReportOptEnabled(6), Me.GetChkReportOpt(6), False))
				RSWIN_DESC.rst.gbReportDynoPred = Me.GetChkReportOpt(3)
				RSWIN_DESC.rst.gbReportSinglePageDynoTorque = RSWIN_DESC.rst.gbReportDynoPred
				RSWIN_DESC.rst.gbReportTorque = RSWIN_DESC.rst.gbReportDynoPred
				RSWIN_DESC.rst.gbReportDevChart = Me.GetChkReportOpt(4)
				RSWIN_DESC.rst.gbReportGuide = Me.GetChkReportOpt(5)
				RSWIN_DESC.rst.gbReportDevSurvey = Me.GetChkReportOpt(8)
				RSWIN_DESC.SETUP_CoverPage = If((-If((RSWIN_DESC.rst.gbCoverPage > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_OrderPage = If((-If((RSWIN_DESC.rst.gbOrderPage > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_PrintData = If((-If((RSWIN_DESC.rst.gbReportData > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_PrintCostAnalysis = RSWIN_DESC.rst.gbReportCostAnalysis
				RSWIN_DESC.SETUP_PrintIPR = If((-If((RSWIN_DESC.rst.gbReportIPR > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_PrintDynoPred = If((-If((RSWIN_DESC.rst.gbReportDynoPred > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_PrintDynoActual = If((-If((RSWIN_DESC.rst.gbReportDynoActual > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_PrintTorque = If((-If((RSWIN_DESC.rst.gbReportTorque > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_PrintSinglePageDynoTorque = If((-If((RSWIN_DESC.rst.gbReportSinglePageDynoTorque > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_PrintDevChart = If((-If((RSWIN_DESC.rst.gbReportDevChart > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_PrintGuide = If((-If((RSWIN_DESC.rst.gbReportGuide > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_ReportDevSurvey = If((-If((RSWIN_DESC.rst.gbReportDevSurvey > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_SummaryPage = If((-If((RSWIN_DESC.rst.gbSummaryPage > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_ScoringPage = If((-If((RSWIN_DESC.rst.gbScoringPage > False), 1S, 0S)), 1S, 0S)
				If(CInt((Not CInt(RSWIN_DESC.SETUP_PrintData))) And Not RSWIN_DESC.SETUP_PrintDiagnosis And CInt((Not CInt(RSWIN_DESC.SETUP_PrintIPR))) And CInt((Not CInt(RSWIN_DESC.SETUP_PrintSinglePageDynoTorque))) And CInt((Not CInt(RSWIN_DESC.SETUP_PrintTorque)))) <> 0 Then
					RSWIN_DESC.SETUP_PrintData = -1S
					RSWIN_DESC.SETUP_PrintDiagnosis = -1
					RSWIN_DESC.SETUP_PrintIPR = -1S
					RSWIN_DESC.SETUP_PrintDynoPred = 0S
					RSWIN_DESC.SETUP_PrintSinglePageDynoTorque = 0S
					RSWIN_DESC.SETUP_PrintTorque = 0S
					RSWIN_DESC.SETUP_CoverPage = -1S
					RSWIN_DESC.SETUP_ScoringPage = -1S
					RSWIN_DESC.rst.gbReportData = (RSWIN_DESC.SETUP_PrintData <> 0S)
					RSWIN_DESC.rst.gbReportIPR = (RSWIN_DESC.SETUP_PrintIPR <> 0S)
					RSWIN_DESC.rst.gbReportSinglePageDynoTorque = (RSWIN_DESC.SETUP_PrintSinglePageDynoTorque <> 0S)
					RSWIN_DESC.rst.gbReportTorque = (RSWIN_DESC.SETUP_PrintTorque <> 0S)
					RSWIN_DESC.rst.gbReportDevChart = (RSWIN_DESC.SETUP_PrintDevChart <> 0S)
					RSWIN_DESC.rst.gbReportGuide = (RSWIN_DESC.SETUP_PrintGuide <> 0S)
					RSWIN_DESC.rst.gbReportDevSurvey = (RSWIN_DESC.SETUP_ReportDevSurvey <> 0S)
					RSWIN_DESC.rst.gbCoverPage = (RSWIN_DESC.SETUP_CoverPage <> 0S)
				End If
				Dim text As String = "CoverPage"
				Dim text2 As String = Convert.ToString(RSWIN_DESC.SETUP_CoverPage)
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				text2 = "OrderPage"
				text = Convert.ToString(RSWIN_DESC.SETUP_OrderPage)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintData"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintData)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintDiagnosis"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDiagnosis)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintDynoPred"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintDynoActual"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoActual)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintIPR"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintIPR)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintSinglePageDynoTorque"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintTorque"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintCostAnalysis"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintCostAnalysis)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintDevChart"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintDevChart)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "PrintGuide"
				text = Convert.ToString(RSWIN_DESC.SETUP_PrintGuide)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "ReportDevSurvey"
				text = Convert.ToString(RSWIN_DESC.SETUP_ReportDevSurvey)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "SummaryPage"
				text = Convert.ToString(RSWIN_DESC.SETUP_SummaryPage)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "ScoringPage"
				text = Convert.ToString(RSWIN_DESC.SETUP_ScoringPage)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				text2 = "NumCycles"
				text = Conversions.ToString(RSWIN_DESC.SETUP_NumCycles)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_NumCycles = Conversions.ToInteger(text)
				If Versioned.IsNumeric(Me.txtMaxSteelLoading.Text) Then
					RSWIN_DESC.SETUP_MaxSteelLoading = CSng((CDbl(Convert.ToInt32(Me.txtMaxSteelLoading.Text)) / 100.0))
					text2 = "MaxSteelLoading"
					Dim obj As Object = RSWIN_DESC.SETUP_MaxSteelLoading
					Dim text3 As String = Util.Format(obj)
					RSWIN_DESC.SETUP_MaxSteelLoading = Conversions.ToSingle(obj)
					text = text3
					num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				End If
				If Versioned.IsNumeric(Me.txtMaxFGLoading.Text) Then
					RSWIN_DESC.SETUP_MaxFGLoading = CSng((CDbl(Convert.ToInt32(Me.txtMaxFGLoading.Text)) / 100.0))
					text2 = "MaxFGLoading"
					Dim obj As Object = RSWIN_DESC.SETUP_MaxFGLoading
					Dim text4 As String = Util.Format(obj)
					RSWIN_DESC.SETUP_MaxFGLoading = Conversions.ToSingle(obj)
					text = text4
					num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				End If
				Dim sDefaultName As String = "SteelSuckerRodLength"
				Dim value As Object = DBNull.Value
				Dim flag As Boolean = False
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag))
				RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
				If Me.lstWK1Formats.SelectedIndex < 1 Then
					RSWIN_DESC.SETUP_WK1Format = Nothing
				Else
					RSWIN_DESC.SETUP_WK1Format = Support.GetItemString(Me.lstWK1Formats, Me.lstWK1Formats.SelectedIndex)
					RSWIN_DESC.SETUP_WK1Format = RSWIN_DESC.SETUP_WK1Format.Substring(0, Strings.InStr(RSWIN_DESC.SETUP_WK1Format, Me.sFortySpaces, CompareMethod.Binary) - 1)
				End If
				If RSWIN_DESC.DEBUG_AllowDebugging Then
					RSWIN_DESC.DEBUG_PlotAllDownholeCards = Me.chkPlotAllDownholeCards.Checked
				End If
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.gbCoverPage = (RSWIN_DESC.SETUP_CoverPage <> 0S)
				rst.gbOrderPage = (RSWIN_DESC.SETUP_OrderPage <> 0S)
				rst.gbSummaryPage = (RSWIN_DESC.SETUP_SummaryPage <> 0S)
				rst.gbScoringPage = (RSWIN_DESC.SETUP_ScoringPage <> 0S)
				rst.gbReportData = (RSWIN_DESC.SETUP_PrintData <> 0S)
				rst.gbReportCostAnalysis = RSWIN_DESC.SETUP_PrintCostAnalysis
				rst.gbReportIPR = (RSWIN_DESC.SETUP_PrintIPR <> 0S)
				rst.gbReportDynoPred = (RSWIN_DESC.SETUP_PrintDynoPred <> 0S)
				rst.gbReportDynoActual = (RSWIN_DESC.SETUP_PrintDynoActual <> 0S)
				rst.gbReportTorque = (RSWIN_DESC.SETUP_PrintTorque <> 0S)
				rst.gbReportSinglePageDynoTorque = (RSWIN_DESC.SETUP_PrintSinglePageDynoTorque <> 0S)
				rst.gbReportDevChart = (RSWIN_DESC.SETUP_PrintDevChart <> 0S)
				rst.gbReportGuide = (RSWIN_DESC.SETUP_PrintGuide <> 0S)
				rst.gbReportDevSurvey = (RSWIN_DESC.SETUP_ReportDevSurvey <> 0S)
				RSWIN_DESC.SETUP_ShowVisualInput = If((-If((Me.chkShowVisualInputWindow.Checked > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_ExitIfIdle = If((-If((Me.chkExitIfIdle.Checked > False), 1S, 0S)), 1S, 0S)
				RSWIN_DESC.SETUP_SaveOpenFileOnExit = If((-If((Me.chkSaveOpenFileOnExit.Checked > False), 1S, 0S)), 1S, 0S)
				If RSWIN_DESC.bRodStarD And RSWIN_DESC.bAllowRodLimitEntry Then
					RSWIN_DESC.SETUP_UseDefaultRodElementLimit = Me.chkUseDefaultRodElementLimit.Checked
					If Not RSWIN_DESC.SETUP_UseDefaultRodElementLimit Then
						If Versioned.IsNumeric(Me.txtRodElementLimit.Text) Then
							RSWIN_DESC.SETUP_RodElementLimit = Convert.ToInt32(Me.txtRodElementLimit.Text)
						Else
							RSWIN_DESC.SETUP_RodElementLimit = 200
						End If
					End If
				End If
				Me.lblExitIfIdle.Enabled = Me.chkExitIfIdle.Checked
				Me.chkSaveOpenFileOnExit.Enabled = Me.chkExitIfIdle.Checked
				If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					RSWIN_DESC.SETUP_DisplaySBinFeet = If((-If((Me.chkDisplaySBinFeet.Checked > False), 1S, 0S)), 1S, 0S)
				End If
				RSWIN_DESC.SETUP_SaveXDIAGMeasuredCard = If((-If((Me.chkAlwaysSaveXDIAGMeasuredCard.Checked > False), 1S, 0S)), 1S, 0S)
				If Me.cboDigitizerComPort.SelectedIndex < 0 Then
					RSWIN_DESC.SETUP_TabletPort = 1
				ElseIf Operators.ConditionalCompareObjectEqual(Me.cboDigitizerComPort.SelectedItem, Me.sNone, False) Then
					RSWIN_DESC.SETUP_TabletPort = 0
				Else
					RSWIN_DESC.SETUP_TabletPort = Conversions.ToInteger(Me.cboDigitizerComPort.SelectedItem)
				End If
				If Not bCancel Then
					Dim obj2 As Object = RSWIN_DESC.SETUP_MeasurementSystem
					If Me.rbtEnglish.Checked Then
						RSWIN_DESC.SETUP_MeasurementSystem = 1
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "E"
						End If
					ElseIf Me.rbtMetric.Checked Then
						RSWIN_DESC.SETUP_MeasurementSystem = 3
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "M"
						End If
					ElseIf Me.rbtCanadian.Checked Then
						RSWIN_DESC.SETUP_MeasurementSystem = 2
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "C"
						End If
					End If
					If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj2, RSWIN_DESC.SETUP_MeasurementSystem, False))) Then
						RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
					End If
				End If
				If Me.rbtEng.Checked Then
					RSWIN_DESC.SETUP_Language = RSWIN_DESC.sEnglish
				ElseIf Me.rbtSpan.Checked Then
					RSWIN_DESC.SETUP_Language = RSWIN_DESC.sSpanish
				ElseIf Me.rbtChinese.Checked Then
					RSWIN_DESC.SETUP_Language = RSWIN_DESC.sChinese
				Else
					RSWIN_DESC.SETUP_Language = RSWIN_DESC.sEnglish
				End If
				text2 = "Language"
				text = RSWIN_DESC.SETUP_Language
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_Language = text
				RSWIN_DESC.SETUP_BatchPrintouts = If((-If((Me.chkPrintResults.Checked > False), 1, 0)), 1, 0)
				RSWIN_DESC.SETUP_BatchSaveWorksheet = If((-If((Me.chkCreateWK1.Checked > False), 1, 0)), 1, 0)
				RSWIN_DESC.SETUP_BatchViewWorksheet = If((-If((Me.chkViewWK1.Checked > False), 1, 0)), 1, 0)
				RSWIN_DESC.SETUP_BatchSkipProcessedFiles = If((-If((Me.chkSkipProcessedFiles.Checked > False), 1, 0)), 1, 0)
				RSWIN_DESC.SETUP_BatchUpdateCustomRodGrades = If((-If((Me.optCRGMismatch_1.Checked > False), 1, 0)), 1, 0)
				RSWIN_DESC.SETUP_ExcelInstalled = Me.chkExcelInstalled.Checked
				RSWIN_DESC.SETUP_CreatePDFs = If((-If((Me.chkCreatePDFs.Checked > False), 1, 0)), 1, 0)
				If Information.IsDate(Strings.Trim(String.Concat(New String() { Me.nmUDHour.Text, ":", Strings.Trim(Me.nmUDMinute.Text), " ", Me.cboAMPM.Text }))) Then
					RSWIN_DESC.SETUP_BeginTime = Convert.ToDateTime(String.Concat(New String() { Strings.Trim(Me.nmUDHour.Text), ":", Strings.Trim(Me.nmUDMinute.Text), " ", Me.cboAMPM.Text }))
				End If
				If Information.IsDate(Strings.Trim(Me.udHour.Text + ":" + Strings.Trim(Me.udMin.Text) + ":00")) Then
					RSWIN_DESC.SETUP_IntervalTime = Convert.ToDateTime(Strings.Trim(Me.udHour.Text) + ":" + Strings.Trim(Me.udMin.Text) + ":00")
				Else
					RSWIN_DESC.SETUP_IntervalTime = Convert.ToDateTime("00:20:00")
				End If
				RSWIN_DESC.SETUP_WK1Dir = Strings.Trim(Me.txtWK1Dir.Text)
				RSWIN_DESC.SETUP_RSWINDIR = Strings.Trim(Me.txtRODSTARDir.Text)
				If Me.lstWK1Formats.SelectedIndex < 1 Then
					RSWIN_DESC.SETUP_WK1Format = RSWIN_DESC.sNull
				Else
					RSWIN_DESC.SETUP_WK1Format = Conversions.ToString(Me.lstWK1Formats.Items(Me.lstWK1Formats.SelectedIndex))
					RSWIN_DESC.SETUP_WK1Format = RSWIN_DESC.SETUP_WK1Format.Substring(0, Strings.InStr(RSWIN_DESC.SETUP_WK1Format, Me.sFortySpaces, CompareMethod.Binary) - 1)
				End If
				Me.ChangesDebugOptions()
				RSWIN.SaveDefaults()
				If RSWIN_DESC.bRodStarD And RSWIN_DESC.SETUP_GuideToUse <> Me.SAVE_SETUP_GuideToUse Then
					Try
						RSWIN_DESC.rst.bImplementedDesign = False
					Catch ex As Exception
					End Try
				End If
				Dim setup_GuideToUse As Integer = RSWIN_DESC.SETUP_GuideToUse
				If setup_GuideToUse = 0 Then
					RSWIN_DESC.SETUP_GuideToUse = 0
				ElseIf setup_GuideToUse = CInt(RSWIN_DESC.MOLDED) Then
					RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.MOLDED)
				ElseIf setup_GuideToUse = 2 Then
					RSWIN_DESC.SETUP_GuideToUse = 2
				ElseIf setup_GuideToUse = 5 Then
					RSWIN_DESC.SETUP_GuideToUse = 5
				ElseIf setup_GuideToUse = 4 Then
					RSWIN_DESC.SETUP_GuideToUse = 4
				ElseIf setup_GuideToUse = CInt(RSWIN_DESC.NorrisSidewinderGuide) Then
					RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.NorrisSidewinderGuide)
				ElseIf setup_GuideToUse = 6 Then
					RSWIN_DESC.SETUP_GuideToUse = 6
				ElseIf setup_GuideToUse = 7 Then
					RSWIN_DESC.SETUP_GuideToUse = 7
				ElseIf setup_GuideToUse = 8 Then
					RSWIN_DESC.SETUP_GuideToUse = 8
				ElseIf setup_GuideToUse = 9 Then
					RSWIN_DESC.SETUP_GuideToUse = 9
				ElseIf setup_GuideToUse = 10 Then
					RSWIN_DESC.SETUP_GuideToUse = 10
				ElseIf setup_GuideToUse = 11 Then
					RSWIN_DESC.SETUP_GuideToUse = 11
				ElseIf setup_GuideToUse = 3 Then
					RSWIN_DESC.SETUP_GuideToUse = 3
				Else
					RSWIN_DESC.SETUP_GuideToUse = 0
				End If
				text2 = "GuideToUse"
				text = Conversions.ToString(RSWIN_DESC.SETUP_GuideToUse)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(text)
				text2 = "ParaffinRodGuide"
				text = Conversions.ToString(RSWIN_DESC.SETUP_ParaffinRodGuide)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_ParaffinRodGuide = Conversions.ToInteger(text)
				If RSWIN_DESC.SETUP_UseDefaultDBLocation Then
					text2 = "UseDefaultDBLocation"
					text = Conversions.ToString(RSWIN_DESC.SETUP_UseDefaultDBLocation)
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text2, text, RSWIN_DESC.sINIFile)
					RSWIN_DESC.SETUP_UseDefaultDBLocation = Conversions.ToBoolean(text)
				ElseIf RSWIN_DESC.SETUP_UseServerDBLocation And Operators.CompareString(Me.txtDBServerFolder.Text.Trim(), "", False) <> 0 Then
					If Operators.CompareString(Me.txtDBServerFolder.Text.Trim(), "", False) = 0 Then
						RSWIN_DESC.SETUP_UseDefaultDBLocation = True
						RSWIN_DESC.SETUP_UseServerDBLocation = False
						text2 = "UseDefaultDBLocation"
						text = Conversions.ToString(RSWIN_DESC.SETUP_UseDefaultDBLocation)
						RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text2, text, RSWIN_DESC.sINIFile)
						RSWIN_DESC.SETUP_UseDefaultDBLocation = Conversions.ToBoolean(text)
					Else
						text2 = "UseServerDBLocation"
						text = Conversions.ToString(RSWIN_DESC.SETUP_UseServerDBLocation)
						RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text2, text, RSWIN_DESC.sINIFile)
						RSWIN_DESC.SETUP_UseServerDBLocation = Conversions.ToBoolean(text)
						RSWIN_DESC.SETUP_ServerDBLocation = Me.txtDBServerFolder.Text
						text2 = "ServerDBLocation"
						text = RSWIN_DESC.SETUP_ServerDBLocation
						RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text2, text, RSWIN_DESC.sINIFile)
						RSWIN_DESC.SETUP_ServerDBLocation = text
					End If
				End If
				If Me.bRSCostDB_Changed Or Me.bPUCostDB_Changed Or (RSWIN_DESC.bRodStarD And Me.bGuideCostDB_Changed) Then
					COSTDB.DBClose()
				End If
				If RSWIN_DESC.bExpert Then
					bCancel = (Not RSWIN_DESC.get_bUsePUManuf(1) And Not RSWIN_DESC.get_bUsePUManuf(2) And Not RSWIN_DESC.get_bUsePUManuf(3) And Not RSWIN_DESC.get_bUsePUManuf(4) And Not RSWIN_DESC.get_bUsePUManuf(5) And Not RSWIN_DESC.get_bUsePUManuf(6) And Not RSWIN_DESC.get_bUsePUManuf(7) And Not RSWIN_DESC.get_bUsePUManuf(8))
					If bCancel Then
						MessageBox.Show("Please select at least one pumping unit manufacturer from the AI Mode Preferences.")
					End If
					ini.SavePreferenceDataValue("XRODUseCustomizedLists", Convert.ToString(RSWIN_DESC.bXRODUseCustomizedLists))
					ini.SavePreferenceDataValue("Use_PUManuf_Preference_1", Convert.ToString(RSWIN_DESC.get_bUsePUManuf(1)))
					ini.SavePreferenceDataValue("Use_PUManuf_Preference_2", Convert.ToString(RSWIN_DESC.get_bUsePUManuf(2)))
					ini.SavePreferenceDataValue("Use_PUManuf_Preference_3", Convert.ToString(RSWIN_DESC.get_bUsePUManuf(3)))
					ini.SavePreferenceDataValue("Use_PUManuf_Preference_4", Convert.ToString(RSWIN_DESC.get_bUsePUManuf(4)))
					ini.SavePreferenceDataValue("Use_PUManuf_Preference_5", Convert.ToString(RSWIN_DESC.get_bUsePUManuf(5)))
					ini.SavePreferenceDataValue("Use_PUManuf_Preference_6", Convert.ToString(RSWIN_DESC.get_bUsePUManuf(6)))
					ini.SavePreferenceDataValue("Use_PUManuf_Preference_7", Convert.ToString(RSWIN_DESC.get_bUsePUManuf(7)))
					ini.SavePreferenceDataValue("Use_PUManuf_Preference_8", Convert.ToString(RSWIN_DESC.get_bUsePUManuf(8)))
					ini.SavePreferenceDataValue("PUManuf_Preference_1", RSWIN_DESC.get_PUManuf(1))
					ini.SavePreferenceDataValue("PUManuf_Preference_2", RSWIN_DESC.get_PUManuf(2))
					ini.SavePreferenceDataValue("PUManuf_Preference_3", RSWIN_DESC.get_PUManuf(3))
					ini.SavePreferenceDataValue("PUManuf_Preference_4", RSWIN_DESC.get_PUManuf(4))
					ini.SavePreferenceDataValue("PUManuf_Preference_5", RSWIN_DESC.get_PUManuf(5))
					ini.SavePreferenceDataValue("PUManuf_Preference_6", RSWIN_DESC.get_PUManuf(6))
					ini.SavePreferenceDataValue("PUManuf_Preference_7", RSWIN_DESC.get_PUManuf(7))
					ini.SavePreferenceDataValue("PUManuf_Preference_8", RSWIN_DESC.get_PUManuf(8))
					ini.SavePreferenceDataValue("IncludeMotorSPV", Convert.ToString(RSWIN_DESC.SETUP_IncludeMotorSPV))
				End If
				If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bChangeCultures Then
					Dim setup_Language As String = RSWIN_DESC.SETUP_Language
					If Operators.CompareString(setup_Language, RSWIN_DESC.sEnglish, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sSpanish, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
					ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sChinese, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
					Else
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					End If
					Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub RswinSetup_Load(sender As Object, e As EventArgs)
			If RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
				Me.tmrClock.Enabled = True
			Else
				Me.tmrClock.Enabled = False
			End If
			RSWIN.GetMeasurementUnit()
			Me.ResetClock()
			If RSWIN_DESC.bRodStarD Then
				Me.SAVE_SETUP_GuideToUse = RSWIN_DESC.SETUP_GuideToUse
				If RSWIN_DESC.bAllowRodLimitEntry Then
					Me.grpRodElement.Visible = True
				Else
					Me.grpRodElement.Visible = False
				End If
				If RSWIN_DESC.SETUP_GuideToUse >= 6 Or RSWIN_DESC.SETUP_GuideToUse < 4 Then
					RSWIN_DESC.iMinGuide = 3
				ElseIf RSWIN_DESC.SETUP_GuideToUse >= 4 Then
					RSWIN_DESC.iMinGuide = 4
				Else
					RSWIN_DESC.iMinGuide = 3
				End If
			Else
				Me.grpRodElement.Visible = False
			End If
			Me.SAVE_SETUP_MeasurementSystem = RSWIN_DESC.SETUP_MeasurementSystem
			Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			Me.sFortySpaces = "                                        "
			Me.bRSCostDB_Changed = False
			Me.bPUCostDB_Changed = False
			Me.bGuideCostDB_Changed = False
			Me.Text = RSWIN_DESC.sProgramName + " Setup"
			Me.chkAIUseCustomizedLists.Visible = True
			Dim text As String = "XRODUseCustomizedLists"
			Dim flag As Boolean = False
			RSWIN_DESC.bXRODUseCustomizedLists = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, text, flag)
			text = "XRODUseGeneralList"
			flag = False
			RSWIN_DESC.bXRODUseGeneralList = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, text, flag)
			text = "XRODUseClosestUnit"
			flag = False
			RSWIN_DESC.bXRODUseClosestUnit = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, text, flag)
			Dim num As Single
			If RSWIN_DESC.bExpert Then
				text = "UseXRODVTubingSizes"
				flag = True
				RSWIN_DESC.SETUP_UseXRODVTubingSizes = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, text, flag)
				text = "FixTubingSize"
				flag = False
				RSWIN_DESC.SETUP_FixTubingSize = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, text, flag)
				text = "MaxCasingSize"
				num = 5.5F
				RSWIN_DESC.MaxCasingSize = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_PREFERENCES, text, num))
				text = "MaxTubingSizeOD"
				num = 2.875F
				RSWIN_DESC.MaxTubingSizeOD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_PREFERENCES, text, num))
				Me.lblDefault.Text = "Non-AI Default Value:"
			Else
				RSWIN_DESC.SETUP_UseXRODVTubingSizes = True
				RSWIN_DESC.SETUP_FixTubingSize = False
				RSWIN_DESC.MaxCasingSize = 5.5F
				RSWIN_DESC.MaxTubingSizeOD = 2.875F
				ini.SavePreferenceDataValue("MaxCasingSize", RSWIN_DESC.MaxCasingSize)
				ini.SavePreferenceDataValue("MaxTubingSizeOD", RSWIN_DESC.MaxTubingSizeOD)
			End If
			If RSWIN_DESC.bIntVersion Then
				Dim setup_Language As String = RSWIN_DESC.SETUP_Language
				If Operators.CompareString(setup_Language, RSWIN_DESC.sEnglish, False) = 0 Then
					Me.rbtEng.Checked = True
				ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sSpanish, False) = 0 Then
					Me.rbtSpan.Checked = True
				ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sChinese, False) = 0 Then
					Me.rbtChinese.Checked = True
				Else
					Me.rbtEng.Checked = True
				End If
				If RSWIN_DESC.bChangeCultures Then
					Dim setup_Language2 As String = RSWIN_DESC.SETUP_Language
					If Operators.CompareString(setup_Language2, RSWIN_DESC.sEnglish, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					ElseIf Operators.CompareString(setup_Language2, RSWIN_DESC.sSpanish, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
					ElseIf Operators.CompareString(setup_Language2, RSWIN_DESC.sChinese, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
					Else
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					End If
					Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
				End If
				If RSWIN_DESC.bReadResXFile Then
					Util.AssignValuesToControls(Me)
				End If
			End If
			Me.TreeView2.Nodes.Clear()
			Dim selectedNode As TreeNode = Me.TreeView2.Nodes.Add(Me.sGeneral)
			Me.BatchNode = Me.TreeView2.Nodes.Add(Me.sBatchMode)
			Me.TreeView2.Nodes.Add(Me.sCostDatabase)
			Me.TreeView2.Nodes.Add(Me.sDefaults)
			Me.TreeView2.Nodes.Add(Me.sOutputOptions)
			Me.grpPredictMode.Visible = False
			text = "UseDefaultDBLocation"
			flag = True
			RSWIN_DESC.SETUP_UseDefaultDBLocation = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_GENERAL, text, flag)
			text = "UseServerDBLocation"
			flag = False
			RSWIN_DESC.SETUP_UseServerDBLocation = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_GENERAL, text, flag)
			text = "ServerDBLocation"
			Dim text2 As String = ""
			Dim num2 As Integer
			Dim text3 As String
			Dim length As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text2, text3, False))
			RSWIN_DESC.SETUP_ServerDBLocation = text3.Substring(0, CInt(length))
			Me.rptUseLocalDatabase.Checked = RSWIN_DESC.SETUP_UseDefaultDBLocation
			Me.rbtUseServerLocation.Checked = RSWIN_DESC.SETUP_UseServerDBLocation
			Me.txtDBServerFolder.Text = RSWIN_DESC.SETUP_ServerDBLocation
			Me.lblDBServerFolder.Enabled = Me.rbtUseServerLocation.Checked
			Me.txtDBServerFolder.Enabled = Me.lblDBServerFolder.Enabled
			Me.btnBrowseForServerFolder.Enabled = Me.lblDBServerFolder.Enabled
			Me.btnVerifyFiles.Enabled = (Me.lblDBServerFolder.Enabled And Operators.CompareString(RSWIN_DESC.SETUP_ServerDBLocation.Trim(), "", False) <> 0)
			Me.btnVerifyData.Enabled = Me.btnVerifyFiles.Enabled
			Me.btnSynch.Enabled = Me.btnVerifyFiles.Enabled
			If RSWIN_DESC.bRodStarD Then
				Try
					Me.txtInclinationLimit.Visible = True
					Me.lblInclinationLimit.Visible = True
					Me.chkRelocateSB.Visible = True
					text2 = "BareRodFricCoeff"
					num = 0.2F
					RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num))
					text2 = "MoldedFricCoeff"
					RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fDefaultFricCoeff))
					text2 = "WheelFricCoeff"
					RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fDefaultFricCoeff))
					text2 = "OtherFricCoeff"
					RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fDefaultFricCoeff))
					text2 = "NorrisStandardGuideFricCoeff"
					RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text2 = "NorrisSidewinderGuideFricCoeff"
					RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text2 = "RGIJakeCouplingGuideFricCoeff"
					RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text2 = "RGISVTGuideFricCoeff"
					RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text2 = "RGITomahawkGuideFricCoeff"
					RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text2 = "RGITornadoGuideFricCoeff"
					RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text2 = "RGITwisterGuideFricCoeff"
					RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
					text2 = "RGIWVTGuideFricCoeff"
					RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
					Me.txtMoldedFricCoeff.Text = RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF.ToString()
					Me.txtWheelFricCoeff.Text = RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF.ToString()
					Me.txtOtherFricCoeff.Text = RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF.ToString()
					Me.txtBareRodFricCoeff.Text = RSWIN_DESC.SETUP_BAREROD_FRICCOEFF.ToString()
					text2 = "GuideToUse"
					num2 = CInt(RSWIN_DESC.MOLDED)
					Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num2)
					RSWIN_DESC.MOLDED = CShort(num2)
					RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
					If RSWIN_DESC.SETUP_GuideToUse = 0 Then
						RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.MOLDED)
						text2 = "GuideToUse"
						text = Conversions.ToString(CInt(RSWIN_DESC.MOLDED))
						RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
						RSWIN_DESC.MOLDED = Conversions.ToShort(text)
					End If
					Me.txtNorrisFricCoeff.Text = Conversions.ToString(RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True))
					text2 = "ParaffinRodGuide"
					num2 = RSWIN_DESC.SETUP_GuideToUse
					Dim regProfileStringByInt2 As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num2)
					RSWIN_DESC.SETUP_GuideToUse = num2
					RSWIN_DESC.SETUP_ParaffinRodGuide = Conversions.ToInteger(regProfileStringByInt2)
					Try
						If Me.cboParaffinRodGuide.Items.Count > 0 Then
							Me.cboParaffinRodGuide.SelectedValue = RSWIN_DESC.SETUP_ParaffinRodGuide
						Else
							Me.PopulateParaffinRodGuideCombo()
							Me.cboParaffinRodGuide.SelectedValue = RSWIN_DESC.SETUP_ParaffinRodGuide
						End If
					Catch ex As Exception
					End Try
				Catch ex2 As Exception
				End Try
				Me.txtBareRodFricCoeff.Visible = False
				Me.txtMoldedLoad.Visible = False
				Me.txtMoldedFricCoeff.Visible = False
				Me.txtWheelLoad.Visible = False
				Me.txtWheelFricCoeff.Visible = False
				Me.txtOtherLoad.Visible = False
				Me.txtOtherFricCoeff.Visible = False
				Me.txtSidewinderLoad.Visible = False
				Me.txtNorrisFricCoeff.Visible = False
				Me._SSFrame_8.Visible = True
				Me.chkAzDirToolbar.Visible = True
				Me.chkOptimizeSurvey.Visible = False
				Me.txtMDInt.Visible = False
				Me.txtDoglegLimit.Visible = False
				Me.lblMDInt.Visible = False
				Me.lblDoglegLimit.Visible = False
				Me.cboSidewinder.Items.Clear()
				Me.cboSidewinder.Items.Add("Norris Standard")
				Me.cboSidewinder.Items.Add("Norris Sidewinder")
				Me.cboSidewinder.Items.Add("RGI Jake Coupling")
				Me.cboSidewinder.Items.Add("RGI SVT")
				Me.cboSidewinder.Items.Add("RGI Tomahawk")
				Me.cboSidewinder.Items.Add("RGI Tornado")
				Me.cboSidewinder.Items.Add("RGI Twister")
				Me.cboSidewinder.Items.Add("RGI WVT")
				If Not RSWIN_DESC.bBETA And RSWIN_DESC.bRodStarD Then
					Me.grpRatio.Visible = True
				Else
					Me.grpRatio.Visible = False
				End If
				Me.chkReportOpt_5.Visible = True
				Me.chkReportOpt_4.Visible = True
				Me.chkReportOpt_8.Visible = True
				Me.optDeviated.Checked = True
				Me.optVertical.Checked = False
			Else
				Me.txtInclinationLimit.Visible = False
				Me.lblInclinationLimit.Visible = False
				Me.chkRelocateSB.Visible = False
				Me._SSFrame_8.Visible = False
				Me.chkAzDirToolbar.Visible = False
				Me.chkReportOpt_5.Visible = False
				Me.chkReportOpt_4.Visible = False
				Me.chkReportOpt_8.Visible = False
				Me.optVertical.Checked = True
				Me.optDeviated.Checked = False
			End If
			Me.chkReportOpt_9.Visible = True
			Dim treeNode As TreeNode = Me.TreeView2.Nodes.Add(Me.sPumpingUnitOptions)
			treeNode.Expand()
			treeNode.Nodes.Add(Me.sCustomizePumpingUnitList)
			treeNode.Nodes.Add(Me.sMeasuredPumpingUnitList)
			Dim treeNode2 As TreeNode = Me.TreeView2.Nodes.Add(Me.sCustomizeRodGrades)
			If RSWIN_DESC.bExpert Then
				Dim treeNode3 As TreeNode = Me.TreeView2.Nodes.Add(Me.sExpert)
				If RSWIN_DESC.bXRODAdmin Then
					Dim treeNode4 As TreeNode = Me.TreeView2.Nodes.Add(Me.sAdmin)
				End If
			End If
			If RSWIN_DESC.DEBUG_AllowDebugging Then
				Dim treeNode5 As TreeNode = Me.TreeView2.Nodes.Add("Debug")
			End If
			Try
				Me.TreeView2.SelectedNode = selectedNode
			Catch ex3 As Exception
			End Try
			Select Case RSWIN_DESC.SETUP_MeasurementSystem
				Case 1
					Me.rbtEnglish.Checked = True
				Case 2
					Me.rbtCanadian.Checked = True
				Case 3
					Me.rbtMetric.Checked = True
			End Select
			If RSWIN_DESC.SETUP_ShowVisualInput <> 0S Then
				Me.chkShowVisualInputWindow.Checked = True
			End If
			Me.chkExitIfIdle.Checked = (RSWIN_DESC.SETUP_ExitIfIdle <> 0S)
			Me.chkSaveOpenFileOnExit.Checked = (RSWIN_DESC.SETUP_SaveOpenFileOnExit <> 0S)
			If RSWIN_DESC.bRodStarD And RSWIN_DESC.bAllowRodLimitEntry Then
				Me.chkUseDefaultRodElementLimit.Checked = RSWIN_DESC.SETUP_UseDefaultRodElementLimit
				Me.txtRodElementLimit.Text = Conversions.ToString(RSWIN_DESC.SETUP_RodElementLimit)
				If RSWIN_DESC.SETUP_UseDefaultRodElementLimit Then
					Me.lblRodElementLimit.Enabled = False
					Me.txtRodElementLimit.Enabled = False
				Else
					Me.lblRodElementLimit.Enabled = True
					Me.txtRodElementLimit.Enabled = True
				End If
			End If
			Me.udHour.Enabled = Me.chkExitIfIdle.Checked
			Me.udMin.Enabled = Me.chkExitIfIdle.Checked
			Me.chkSaveOpenFileOnExit.Enabled = Me.chkExitIfIdle.Checked
			Me.chkAlwaysSaveXDIAGMeasuredCard.Checked = (RSWIN_DESC.SETUP_SaveXDIAGMeasuredCard <> 0S)
			If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				text2 = "DisplaySBinFeet"
				flag = True
				RSWIN_DESC.SETUP_DisplaySBinFeet = If(-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_GENERAL, text2, flag) > False), 1S, 0S), 1S, 0S)
				Me.chkDisplaySBinFeet.Checked = (RSWIN_DESC.SETUP_DisplaySBinFeet <> 0S)
			End If
			Me.cboDigitizerComPort.Items.Clear()
			Me.cboDigitizerComPort.Items.Add(Me.sNone)
			Me.cboDigitizerComPort.Items.Add("1")
			Me.cboDigitizerComPort.Items.Add("2")
			Me.cboDigitizerComPort.Items.Add("3")
			Me.cboDigitizerComPort.Items.Add("4")
			Me.cboAMPM.Items.Clear()
			Me.cboAMPM.Items.Add(Me.sAM)
			Me.cboAMPM.Items.Add(Me.sPM)
			If RSWIN_DESC.SETUP_TabletPort <> 0 Then
				Me.cboDigitizerComPort.SelectedIndex = RSWIN_DESC.SETUP_TabletPort - 1
			Else
				Me.cboDigitizerComPort.SelectedIndex = 0
			End If
			If RSWIN_DESC.SETUP_BatchPrintouts <> 0 Then
				Me.chkPrintResults.Checked = True
			Else
				Me.chkPrintResults.Checked = False
			End If
			Me.chkExcelInstalled.Checked = RSWIN_DESC.SETUP_ExcelInstalled
			Me.chkViewWK1.Enabled = Me.chkExcelInstalled.Checked
			If Not Me.chkViewWK1.Enabled Then
				Me.chkViewWK1.Checked = False
			End If
			If RSWIN_DESC.SETUP_BatchSaveWorksheet <> 0 Then
				Me.chkCreateWK1.Checked = True
			Else
				Me.chkCreateWK1.Checked = False
			End If
			Me.chkViewWK1.Enabled = (Me.chkCreateWK1.Checked And RSWIN_DESC.SETUP_ExcelInstalled)
			If RSWIN_DESC.SETUP_BatchViewWorksheet <> 0 Then
				Me.chkViewWK1.Checked = True
			Else
				Me.chkViewWK1.Checked = False
			End If
			If RSWIN_DESC.SETUP_BatchSkipProcessedFiles <> 0 Then
				Me.chkSkipProcessedFiles.Checked = True
			Else
				Me.chkSkipProcessedFiles.Checked = False
			End If
			Me.chkCreatePDFs.Checked = (RSWIN_DESC.SETUP_CreatePDFs <> 0)
			If RSWIN_DESC.SETUP_BatchUpdateCustomRodGrades <> 0 Then
				Me.optCRGMismatch_1.Checked = True
			Else
				Me.optCRGMismatch_0.Checked = True
			End If
			Me.txtWK1Dir.Text = RSWIN_DESC.SETUP_WK1Dir
			Me.txtWK1Dir.Text = RSWIN_DESC.SETUP_WK1Dir
			Me.txtRODSTARDir.Text = RSWIN_DESC.SETUP_RSWINDIR
			Me.SetupWK1FormatList()
			If RSWIN_DESC.bBETA And RSWIN_DESC.bRodStarD Then
				Me.lblNumCycles.Visible = False
				Me.txtNumCycles.Visible = False
				Me.grpRatio.Visible = False
			End If
			If Not Information.IsDBNull(RSWIN_DESC.SETUP_BeginTime) Then
				Dim hour As Integer = RSWIN_DESC.SETUP_BeginTime.Hour
				Me.nmUDHour.Text = Conversions.ToString(Interaction.IIf(hour Mod 12 = 0, "12", Convert.ToString(hour Mod 12)))
				Me.nmUDMinute.Text = Conversions.ToString(RSWIN_DESC.SETUP_BeginTime.Minute)
				Me.cboAMPM.SelectedIndex = Conversions.ToInteger(Interaction.IIf(hour < 12, 0, 1))
			End If
			If Not Information.IsDBNull(RSWIN_DESC.SETUP_IntervalTime) Then
				Me.udHour.Text = Conversions.ToString(RSWIN_DESC.SETUP_IntervalTime.Hour)
				Me.udMin.Text = Conversions.ToString(RSWIN_DESC.SETUP_IntervalTime.Minute)
			End If
			Me.Manufacturer.Text = Me.csHDR_MANUF
			Me.APIDesignation.Text = Me.csHDR_APIDES
			Me.UnitName.Text = Me.csHDR_UNAME
			Me.OtherInfo.Text = Me.csHDR_OTHER
			Dim cboManufMenuCustomDB As ComboBox = Me.cboManufMenuCustomDB
			Me.LoadManufMenu(cboManufMenuCustomDB, False)
			Me.cboManufMenuCustomDB = cboManufMenuCustomDB
			Me.InitDefaults()
			Dim columns As ListView.ColumnHeaderCollection = Me.lvwCustomPU.Columns
			columns.Clear()
			columns.Add(Me.csHDR_MANUF, 140, HorizontalAlignment.Center)
			columns.Add(Me.csHDR_APIDES, 140, HorizontalAlignment.Center)
			columns.Add(Me.csHDR_UNAME, 140, HorizontalAlignment.Center)
			columns.Add(Me.csHDR_OTHER, 140, HorizontalAlignment.Center)
			Dim columnHeader As System.Windows.Forms.ColumnHeader = columns.Add("UnitLocation", 0, HorizontalAlignment.Center)
			columnHeader.Width = 0
			Dim lvwCustomPU As ListView = Me.lvwCustomPU
			CUSTOMPU.GetCustomUnitNames(lvwCustomPU)
			Me.lvwCustomPU = lvwCustomPU
			text2 = "CoverPage"
			flag = False
			RSWIN_DESC.SETUP_CoverPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			text2 = "OrderPage"
			flag = False
			RSWIN_DESC.SETUP_OrderPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			text2 = "PrintData"
			flag = True
			RSWIN_DESC.SETUP_PrintData = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			text2 = "PrintCostAnalysis"
			flag = False
			RSWIN_DESC.SETUP_PrintCostAnalysis = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			text2 = "PrintDiagnosis"
			flag = True
			RSWIN_DESC.SETUP_PrintDiagnosis = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1, 0)), 1, 0)
			text2 = "PrintDynoActual"
			flag = False
			RSWIN_DESC.SETUP_PrintDynoActual = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			text2 = "PrintDynoPred"
			flag = False
			RSWIN_DESC.SETUP_PrintDynoPred = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			text2 = "PrintIPR"
			flag = True
			RSWIN_DESC.SETUP_PrintIPR = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintSinglePageDynoTorque = RSWIN_DESC.SETUP_PrintDynoPred
			RSWIN_DESC.SETUP_PrintTorque = RSWIN_DESC.SETUP_PrintDynoPred
			text2 = "PrintDevChart"
			flag = False
			RSWIN_DESC.SETUP_PrintDevChart = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			text2 = "PrintGuide"
			flag = False
			RSWIN_DESC.SETUP_PrintGuide = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			text2 = "ReportDevSurvey"
			flag = False
			RSWIN_DESC.SETUP_ReportDevSurvey = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			text2 = "SummaryPage"
			flag = False
			RSWIN_DESC.SETUP_SummaryPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			text2 = "ScoringPage"
			flag = True
			RSWIN_DESC.SETUP_ScoringPage = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			Me.chkReportOpt_Click_1(-1, RSWIN_DESC.SETUP_CoverPage <> 0S, True)
			Me.chkReportOpt_Click_1(10, RSWIN_DESC.SETUP_OrderPage <> 0S, True)
			Me.chkReportOpt_Click_1(1, RSWIN_DESC.SETUP_PrintCostAnalysis <> 0S, True)
			Me.chkReportOpt_Click_1(2, RSWIN_DESC.SETUP_PrintIPR <> 0S, True)
			Me.chkReportOpt_Click_1(3, RSWIN_DESC.SETUP_PrintDynoPred <> 0S, True)
			Me.chkReportOpt_Click_1(4, RSWIN_DESC.SETUP_PrintTorque <> 0S, True)
			Me.chkReportOpt_Click_1(0, RSWIN_DESC.SETUP_PrintData <> 0S, True)
			Me.chkReportOpt_Click_1(6, RSWIN_DESC.SETUP_PrintDynoActual <> 0S, True)
			Me.chkReportOpt_Click_1(4, RSWIN_DESC.SETUP_PrintDevChart <> 0S, True)
			Me.chkReportOpt_Click_1(5, RSWIN_DESC.SETUP_PrintGuide <> 0S, True)
			Me.chkReportOpt_Click_1(8, RSWIN_DESC.SETUP_ReportDevSurvey <> 0S, True)
			Me.chkReportOpt_Click_1(7, RSWIN_DESC.SETUP_SummaryPage <> 0S, True)
			Me.chkReportOpt_Click_1(9, RSWIN_DESC.SETUP_ScoringPage <> 0S, True)
			Me.iOldMeasurementSystem = RSWIN_DESC.SETUP_MeasurementSystem
			Me.chkAzDirToolbar.Checked = (RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR <> 0S)
			Me.chkOptimizeSurvey.Checked = (RSWIN_DESC.SETUP_OPTIMIZESURVEY <> 0S)
			Me.chkCalcVBelt.Checked = (RSWIN_DESC.SETUP_CalcVBeltRatio <> 0S)
			text2 = "UseImpred"
			flag = False
			RSWIN_DESC.SETUP_UseImpred = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			If RSWIN_DESC.bBETA And RSWIN_DESC.bRodStarD Then
				RSWIN_DESC.SETUP_UseImpred = -1S
			End If
			text2 = "AlterSBPumpDepth"
			flag = True
			RSWIN_DESC.Setup_bAlterSBPumpDepth = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
			Me.chkRelocateSB.Checked = (RSWIN_DESC.Setup_bAlterSBPumpDepth <> 0S)
			text2 = "InclinationLimit"
			num = 4F
			RSWIN_DESC.Setup_fInclinationLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num))
			Me.txtInclinationLimit.Text = Convert.ToString(RSWIN_DESC.Setup_fInclinationLimit)
			text2 = "MDInt"
			num2 = 25
			RSWIN_DESC.SETUP_MDInt = Conversions.ToSingle(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num2))
			text2 = "DoglegLimit"
			num2 = 5
			RSWIN_DESC.SETUP_DoglegLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num2))
			Dim txtMDInt As TextBox = Me.txtMDInt
			num = RSWIN_DESC.SETUP_MDInt
			txtMDInt.Text = num.ToString()
			Dim txtDoglegLimit As TextBox = Me.txtDoglegLimit
			num = RSWIN_DESC.SETUP_DoglegLimit
			txtDoglegLimit.Text = num.ToString()
			Me.CreateMyToolTip()
			Me.txtMaxFGLoading.Text = Convert.ToString(RSWIN_DESC.SETUP_MaxFGLoading * 100F)
			Me.txtMaxSteelLoading.Text = Convert.ToString(RSWIN_DESC.SETUP_MaxSteelLoading * 100F)
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bRodStarD Then
				Me.grpRatio.Visible = True
				Me.txtGearBoxRatio.Text = RSWIN_DESC.SETUP_GearboxRatio.ToString()
				Me.txtVBeltRatio.Text = RSWIN_DESC.SETUP_VBeltRatio.ToString()
			Else
				Me.grpRatio.Visible = False
				RSWIN_DESC.SETUP_GearboxRatio = 28.45F
				RSWIN_DESC.SETUP_VBeltRatio = 3.2961F
			End If
			If RSWIN_DESC.bExpert Then
				Me.grpWarnings.Visible = True
				text2 = "DisplayRuntimeWarning"
				flag = True
				RSWIN_DESC.SETUP_DisplayRuntimeWarning = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
				text2 = "DisplayTargetBFPDWarning"
				flag = True
				RSWIN_DESC.SETUP_DisplayTargetBFPDWarning = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag) > False), 1S, 0S)), 1S, 0S)
				Me.chkRunTimeWarning.Checked = (RSWIN_DESC.SETUP_DisplayRuntimeWarning <> 0S)
				Me.chkTargetBFPDWarning.Checked = (RSWIN_DESC.SETUP_DisplayTargetBFPDWarning <> 0S)
			Else
				Me.grpWarnings.Visible = False
				If RSWIN_DESC.bRodStarD Then
					Me._SSFrame_8.Top = Me.chkUseAllDiameters.Top
					Me.chkUseAllDiameters.Left = Me.grpWarnings.Left
					Me.chkUseAllDiameters.Top = Me.grpWarnings.Top + Me.grpWarnings.Height - 20
					Me.chkAzDirToolbar.Top = Me.chkAzDirToolbar.Top - 26
					Me.chkRelocateSB.Top = Me.chkRelocateSB.Top - 26
					Me.lblInclinationLimit.Top = Me.lblInclinationLimit.Top - 26
					Me.txtInclinationLimit.Top = Me.txtInclinationLimit.Top - 26
				End If
			End If
			text2 = "BareRodLoad"
			num = 50F
			RSWIN_DESC.SETUP_BAREROD_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num))
			text2 = "MoldedLoad"
			num = 40F
			RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num))
			text2 = "WheelLoad"
			num = 25F
			RSWIN_DESC.SETUP_WHEELGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num))
			text2 = "OtherLoad"
			num = 32.5F
			RSWIN_DESC.SETUP_OTHERGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num))
			text2 = "MaxSideLoadLimit"
			num = 30F
			RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num))
			text2 = "RodGuideOverlap"
			num = 150F
			RSWIN_DESC.Setup_RodGuideOverlap = Conversions.ToInteger(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num))
			text2 = "NumRodsPerBundle"
			num = 30F
			RSWIN_DESC.Setup_NumRodsPerBundle = Conversions.ToInteger(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num))
			Dim text4 As String = New String(" "c, 8192)
			text2 = "OtherGuide"
			text = "Other"
			Dim length2 As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, text4, True))
			Me.txtOther.Text = text4.Substring(0, CInt(length2))
			text2 = "MaxNumGuidesPerRod"
			num2 = 6
			RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num2))
			text2 = "MinNumGuidesPerRod"
			num2 = 3
			RSWIN_DESC.SETUP_MinNumGuidesPerRod = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num2))
			Dim sDefaultName As String = "SteelSuckerRodLength"
			Dim value As Object = DBNull.Value
			flag = False
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag))
			RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
			RSWIN_DESC.SETUP_WeightAdjFactor = 2.5F
			text2 = "BareRodFricCoeff"
			num = 0.2F
			RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num))
			text2 = "MoldedFricCoeff"
			RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fDefaultFricCoeff))
			text2 = "WheelFricCoeff"
			RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fDefaultFricCoeff))
			text2 = "OtherFricCoeff"
			RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fDefaultFricCoeff))
			text2 = "NorrisStandardGuideFricCoeff"
			RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "NorrisSidewinderGuideFricCoeff"
			RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "RGIJakeCouplingGuideFricCoeff"
			RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "RGISVTGuideFricCoeff"
			RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "RGITomahawkGuideFricCoeff"
			RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "RGITornadoGuideFricCoeff"
			RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "RGITwisterGuideFricCoeff"
			RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			text2 = "RGIWVTGuideFricCoeff"
			RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, RSWIN_DESC.fNorrisDefaultFricCoeff))
			Me.txtMoldedFricCoeff.Text = Conversions.ToString(RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF)
			Me.txtWheelFricCoeff.Text = Conversions.ToString(RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF)
			Me.txtOtherFricCoeff.Text = Conversions.ToString(RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF)
			Me.txtBareRodFricCoeff.Text = Conversions.ToString(RSWIN_DESC.SETUP_BAREROD_FRICCOEFF)
			Me.txtMoldedLoad.Text = RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD.ToString()
			Me.txtWheelLoad.Text = RSWIN_DESC.SETUP_WHEELGUIDE_LOAD.ToString()
			Me.txtOtherLoad.Text = RSWIN_DESC.SETUP_OTHERGUIDE_LOAD.ToString()
			Me.txtMaxNumGuides.Text = RSWIN_DESC.SETUP_MaxNumGuidesPerRod.ToString()
			Me.txtMinNumGuides.Text = RSWIN_DESC.SETUP_MinNumGuidesPerRod.ToString()
			Dim txtMaxSideLoadLimit As TextBox = Me.txtMaxSideLoadLimit
			num = RSWIN_DESC.SETUP_MaxSideLoadLimit
			txtMaxSideLoadLimit.Text = num.ToString()
			Me.txtNumImplIters.Text = RSWIN_DESC.Setup_NumImplIters.ToString()
			Me.txtNumRodsPerBundle.Text = Conversions.ToString(RSWIN_DESC.Setup_NumRodsPerBundle)
			Me.chkAzDirToolbar.Checked = (RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR <> 0S)
			Me.chkOptimizeSurvey.Checked = (RSWIN_DESC.SETUP_OPTIMIZESURVEY <> 0S)
			text2 = "UseAllDiameters"
			flag = False
			RSWIN_DESC.SETUP_UseAllDiameters = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text2, flag)
			Me.chkUseAllDiameters.Checked = RSWIN_DESC.SETUP_UseAllDiameters
			RSWIN_DESC.SETUP_UseBucklingTendencyStresses = True
			Me.chkUseBucklingTendencyStresses.Checked = RSWIN_DESC.SETUP_UseBucklingTendencyStresses
			RSWIN_DESC.SETUP_UseJohnsFix = True
			Me.chkUseJohnsFix.Checked = RSWIN_DESC.SETUP_UseJohnsFix
			RSWIN_DESC.SETUP_UseJeffsFix = True
			Me.chkUseJeffsFix.Checked = RSWIN_DESC.SETUP_UseJeffsFix
			text2 = "PlotAllDownholeCards"
			flag = False
			RSWIN_DESC.DEBUG_PlotAllDownholeCards = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_DEBUGGING, text2, flag)
			Me.chkPlotAllDownholeCards.Checked = RSWIN_DESC.DEBUG_PlotAllDownholeCards
			If Operators.CompareString(Me.txtMaxFGLoading.Text.Trim(), "", False) = 0 Then
				Me.txtMaxFGLoading.Text = "95"
			End If
			If Operators.CompareString(Me.txtMaxSteelLoading.Text.Trim(), "", False) = 0 Then
				Me.txtMaxSteelLoading.Text = "95"
			End If
			text2 = "GuideToUse"
			num2 = CInt(RSWIN_DESC.MOLDED)
			Dim regProfileStringByInt3 As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num2)
			RSWIN_DESC.MOLDED = CShort(num2)
			RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt3)
			If RSWIN_DESC.SETUP_GuideToUse = 0 Then
				RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.MOLDED)
				text2 = "GuideToUse"
				text = Conversions.ToString(CInt(RSWIN_DESC.MOLDED))
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.MOLDED = Conversions.ToShort(text)
			End If
			Dim setup_GuideToUse As Integer = RSWIN_DESC.SETUP_GuideToUse
			If setup_GuideToUse = 0 Then
				Me.rbtBareRod.Checked = True
			ElseIf setup_GuideToUse = CInt(RSWIN_DESC.MOLDED) Then
				Me.optMolded.Checked = True
			ElseIf setup_GuideToUse = 2 Then
				Me.optWheel.Checked = True
			ElseIf setup_GuideToUse = 3 Then
				Me.optOther.Checked = True
				Me.txtOtherLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_OTHERGUIDE_LOAD)
			ElseIf setup_GuideToUse = 5 Then
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_NorrisSidewinderGuide_Load)
				Me.optSideWinder.Checked = True
				Me.cboSidewinder.SelectedIndex = 1
			ElseIf setup_GuideToUse = 4 Then
				Me.optSideWinder.Checked = True
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_NorrisStandardGuide_Load)
				Me.cboSidewinder.SelectedIndex = 0
			ElseIf setup_GuideToUse = CInt(RSWIN_DESC.NorrisSidewinderGuide) Then
				Me.optSideWinder.Checked = True
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_NorrisSidewinderGuide_Load)
				Me.cboSidewinder.SelectedIndex = 1
			ElseIf setup_GuideToUse = 6 Then
				Me.optSideWinder.Checked = True
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_RGIJakeCouplingGuide_Load)
				Me.cboSidewinder.SelectedIndex = 2
			ElseIf setup_GuideToUse = 7 Then
				Me.optSideWinder.Checked = True
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_RGISVTGuide_LOAD)
				Me.cboSidewinder.SelectedIndex = 3
			ElseIf setup_GuideToUse = 8 Then
				Me.optSideWinder.Checked = True
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_RGITomahawkGuide_LOAD)
				Me.cboSidewinder.SelectedIndex = 4
			ElseIf setup_GuideToUse = 9 Then
				Me.optSideWinder.Checked = True
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_RGITornadoGuide_LOAD)
				Me.cboSidewinder.SelectedIndex = 5
			ElseIf setup_GuideToUse = 10 Then
				Me.optSideWinder.Checked = True
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_RGITwisterGuide_LOAD)
				Me.cboSidewinder.SelectedIndex = 6
			ElseIf setup_GuideToUse = 11 Then
				Me.optSideWinder.Checked = True
				Me.txtSidewinderLoad.Text = Convert.ToString(RSWIN_DESC.SETUP_RGIWVTGuide_LOAD)
				Me.cboSidewinder.SelectedIndex = 7
			Else
				Me.optMolded.Checked = True
			End If
			text2 = "ParaffinRodGuide"
			num2 = RSWIN_DESC.SETUP_GuideToUse
			Dim regProfileStringByInt4 As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num2)
			RSWIN_DESC.SETUP_GuideToUse = num2
			RSWIN_DESC.SETUP_ParaffinRodGuide = Conversions.ToInteger(regProfileStringByInt4)
			Try
				If Me.cboParaffinRodGuide.Items.Count > 0 Then
					Me.cboParaffinRodGuide.SelectedValue = RSWIN_DESC.SETUP_ParaffinRodGuide
				End If
			Catch ex4 As Exception
			End Try
			If RSWIN_DESC.bRodStarD AndAlso Not Me.optSideWinder.Checked Then
				Me.cboSidewinder.SelectedIndex = 0
				Me.txtSidewinderLoad.Text = RSWIN_DESC.SETUP_NorrisStandardGuide_Load.ToString()
			End If
			text2 = "NumCycles"
			num2 = 4
			RSWIN_DESC.SETUP_NumCycles = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num2))
			Dim txtNumCycles As TextBox = Me.txtNumCycles
			num2 = RSWIN_DESC.SETUP_NumCycles
			txtNumCycles.Text = num2.ToString()
			Me.ulgRSCostDB.DataSource = Nothing
			Me.ulgPUCostDB.DataSource = Nothing
			Me.ulgGuideCostDB.DataSource = Nothing
			Me.mdsPUCostDB = Nothing
			Me.mdsRSCostDB = Nothing
			Me.mdsGuideCostDB = Nothing
			COSTDB.DBClose()
			COSTDB.nDBfrn = 0S
			If RSWIN_DESC.bIntVersion Then
				Me.grpLanguages.Visible = Not RSWIN_DESC.bRunningChineseVersion
			Else
				Me.grpLanguages.Visible = False
			End If
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
			End If
			If RSWIN_DESC.bExpert And RSWIN_DESC.bXRODAdmin Then
				Me.lblStatus.Text = "Total templates: " + Conversions.ToString(RSWIN_DESC.iGuruFileCount) + " , Number Added: " + Conversions.ToString(RSWIN_DESC.iAddedTemplates)
				Return
			End If
			Me.lblStatus.Text = ""
		End Sub

		Private Sub SetupWK1FormatList()
			Me.LoadWK1FormatList()
			Me.lstWK1Formats.SelectedIndex = 0
			If Strings.Len(RSWIN_DESC.SETUP_WK1Format) > 0 Then
				Dim num As Short = 1S
				Dim num2 As Short = CShort((Me.lstWK1Formats.Items.Count - 1))
				For num3 As Short = num To num2
					Dim text As String = Support.GetItemString(Me.lstWK1Formats, CInt(num3))
					text = text.Substring(0, Strings.InStr(text, Me.sFortySpaces, CompareMethod.Binary) - 1)
					If Strings.StrComp(text, RSWIN_DESC.SETUP_WK1Format, CompareMethod.Text) = 0 Then
						Me.lstWK1Formats.SelectedIndex = CInt(num3)
						Exit For
					End If
				Next
				Return
			End If
		End Sub

		Public Sub OldLoadWK1FormatList()
			Dim text As String = New String(" "c, 8192)
			Dim text2 As String = Conversions.ToString(0)
			Dim sNull As String = RSWIN_DESC.sNull
			Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_WK1FORMATS, text2, sNull, text, True)
			RSWIN_DESC.sNull = sNull
			Dim obj As Object = regProfileString
			Me.lstSorted.Items.Clear()
			If Operators.ConditionalCompareObjectGreater(obj, 0, False) Then
				Dim obj2 As Object = 1
				Dim text3 As String
				Do
					Dim obj3 As Object = Strings.InStr(Conversions.ToInteger(obj2), text, vbNullChar, CompareMethod.Binary)
					text3 = Strings.Mid(text, Conversions.ToInteger(obj2), Conversions.ToInteger(Operators.SubtractObject(obj3, obj2)))
					If Strings.Len(text3) > 0 Then
						Me.lstSorted.Items.Add(Strings.LCase(text3) + Me.sFortySpaces + text3)
					End If
					obj2 = Operators.AddObject(obj3, 1)
				Loop While Strings.Len(text3) <> 0
			End If
			Me.lstWK1Formats.Items.Add("(Default)")
			Dim obj4 As Object
			Dim obj5 As Object
			If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj4, 0, Me.lstSorted.Items.Count - 1, 1, obj5, obj4) Then
				Do
					Dim text3 As String = Conversions.ToString(Me.lstSorted.Items(Conversions.ToInteger(obj4)))
					text3 = Strings.Mid(text3, Strings.InStr(text3, Me.sFortySpaces, CompareMethod.Binary) + 1)
					sNull = RSWIN_DESC.sNull
					Dim regProfileString2 As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_WK1FORMATS, text3, sNull, text, True)
					RSWIN_DESC.sNull = sNull
					obj = regProfileString2
					Me.lstWK1Formats.Items.Add(text3 + Me.sFortySpaces + text.Substring(0, Conversions.ToInteger(obj)))
				Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj4, obj5, obj4)
			End If
			Me.lstSorted.Items.Clear()
		End Sub

		Private Sub LoadWK1FormatList()
			Dim text As String = New String(" "c, 8192)
			Dim sect_WK1FORMATS As String = RSWIN_DESC.SECT_WK1FORMATS
			Dim num2 As Short
			Dim num As Integer = CInt(num2)
			Dim array As String()
			Dim array2 As String()
			ini.GetPrivateProfileKeyList(sect_WK1FORMATS, array, array2, num, True)
			Dim num6 As Short
			Dim num7 As Short
			num2 = CShort(num)
			Me.lstSorted.Items.Clear()
			If num2 > 0S Then
				Dim num3 As Short = 0S
				Dim num4 As Short = num2 - 1S

					For num5 As Short = num3 To num4
						If(Not Strings.InStr(array2(CInt(num5)).ToLower(), "warning:", CompareMethod.Binary) And If((-If(((Operators.CompareString(array2(CInt(num5)).Trim(), "", False) <> 0) > False), 1, 0)), 1, 0)) <> 0 Then
							Me.lstSorted.Items.Add(array2(CInt(num5)).ToLower() + vbTab + array2(CInt(num5)))
						End If
					Next

			End If
			Me.lstWK1Formats.Items.Clear()
			Me.lstWK1Formats.Items.Insert(0, "(Default)")
			num6 = 0S
			num7 = CShort((Me.lstSorted.Items.Count - 1))
			For num5 As Short = num6 To num7
				Dim text2 As String = Support.GetItemString(Me.lstSorted, CInt(num5))
				text2 = Strings.Mid(text2, Strings.InStr(text2, vbTab, CompareMethod.Binary) + 1)
				Dim sNull As String = RSWIN_DESC.sNull
				Dim regProfileString As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_WK1FORMATS, text2, sNull, text, True))
				RSWIN_DESC.sNull = sNull
				Dim length As Short = regProfileString
				Me.lstWK1Formats.Items.Add(text2 + Me.sFortySpaces + text.Substring(0, CInt(length)))
			Next
			Me.lstSorted.Items.Clear()
		End Sub

		Private Sub TreeView2_AfterExpand(sender As Object, e As TreeViewEventArgs)
			Dim node As TreeNode = e.Node
			Me.CheckTreeSize()
			Me.SetNodeSettings(node)
		End Sub

		Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs)
			Dim node As TreeNode = e.Node
			Me.CheckTreeSize()
			Me.SetNodeSettings(node)
		End Sub

		Public Property DefaultNode As String
			Get
				Return Me.m_DefaultNode
			End Get
			Set(value As String)
				Me.m_DefaultNode = value
				If Operators.CompareString(value, Me.sBatchMode, False) = 0 Then
					Me.SetNodeSettings(Me.BatchNode)
				End If
			End Set
		End Property

		Public Sub SetNodeSettings(ByRef nodeExpanding As TreeNode)
			Me.pnlBatchMode.Left = -1333
			Me.pnlCustomMeasuredPUList.Left = -1333
			Me.pnlCustomPUList.Left = -1333
			Me.pnlCustomizeRGList.Left = -1333
			Me.pnlDefaults.Left = -1333
			Me.pnlGeneral.Left = -1333
			Me.pnlOutputOptions.Left = -1333
			Me.pnlDebugOptions.Left = -1333
			Me.pnlSetupCostDB.Left = -1333
			Me.pnlExpert.Left = -1333
			Me.pnlAdmin.Left = -1333
			If nodeExpanding Is Nothing Then
				Return
			End If
			Me.CurrentNodeName = nodeExpanding.Text
			Dim point As Point
			If Me.AutoScroll Then
				Dim startPoint As Object = Me.StartPoint
				Me.AutoScrollPosition = If((startPoint IsNot Nothing), CType(startPoint, Point), point)
			End If
			If RSWIN_DESC.bExpert Then
				If Operators.CompareString(Me.CurrentNodeName, Me.sExpert, False) = 0 Then
					If Me.btnOK.Top <> Me.pnlExpert.Height - 20 Then
						Me.btnOK.Top = Me.pnlExpert.Height - 20
					End If
				ElseIf Screen.PrimaryScreen.Bounds.Height < 700 Then
					Me.btnOK.Top = Me.Height - 80
				ElseIf Screen.PrimaryScreen.Bounds.Height < 800 Then
					Me.btnOK.Top = Me.Height - 70
				Else
					Me.btnOK.Top = Me.Height - 73
				End If
				Me.btnCancel.Top = Me.btnOK.Top
			End If
			If Operators.CompareString(Me.CurrentNodeName, Me.sGeneral, False) = 0 Then
				Me.pnlGeneral.Left = Me.iPanelLeft
				Me.pnlGeneral.Focus()
			ElseIf Operators.CompareString(Me.CurrentNodeName, Me.sBatchMode, False) = 0 Then
				Me.pnlBatchMode.Left = Me.iPanelLeft
				Me.pnlBatchMode.Focus()
			ElseIf Operators.CompareString(Me.CurrentNodeName, Me.sDefaults, False) = 0 Then
				Me.pnlDefaults.Left = Me.iPanelLeft
				Me.lstDefaultItems.SelectedIndex = -1
				Me.lstDefaultItems.Tag = Nothing
				Me.txtDefault.Text = ""
				Me.cboDefault.SelectedIndex = -1
				Try
					If RSWIN_DESC.bRodStarD Then
						If Me.rbtBareRod.Checked Then
							Me.lblFricCoeff.Left = Me.lblSideLoadperRodGuide.Left
							Me.lblSideLoadperRodGuide.Top = 6
							Me.lblFricCoeff.Top = Me.lblSideLoadperRodGuide.Top
							Me.cmdResetFrictions.Top = Me.lblFricCoeff.Top
							Me.lblSideLoadperRodGuide.Visible = False
							Me.lblFricCoeff.Visible = True
						ElseIf Me.optMolded.Checked Then
							Me.lblFricCoeff.Left = 350
							Me.lblSideLoadperRodGuide.Top = Me.optMolded.Top - Me.lblSideLoadperRodGuide.Height
							Me.lblFricCoeff.Top = Me.lblSideLoadperRodGuide.Top
							Me.cmdResetFrictions.Top = Me.lblFricCoeff.Top
							Me.lblSideLoadperRodGuide.Visible = True
							Me.lblFricCoeff.Visible = True
						ElseIf Me.optWheel.Checked Then
							Me.lblFricCoeff.Left = 350
							Me.lblSideLoadperRodGuide.Top = Me.optWheel.Top - Me.lblSideLoadperRodGuide.Height
							Me.lblFricCoeff.Top = Me.lblSideLoadperRodGuide.Top
							Me.cmdResetFrictions.Top = Me.lblFricCoeff.Top
							Me.lblSideLoadperRodGuide.Visible = True
							Me.lblFricCoeff.Visible = True
						ElseIf Me.optSideWinder.Checked Then
							Me.lblFricCoeff.Left = 350
							Me.lblSideLoadperRodGuide.Top = Me.cboSidewinder.Top - Me.lblSideLoadperRodGuide.Height
							Me.lblFricCoeff.Top = Me.lblSideLoadperRodGuide.Top
							Me.cmdResetFrictions.Top = Me.lblFricCoeff.Top
							Me.lblSideLoadperRodGuide.Visible = True
							Me.lblFricCoeff.Visible = True
						ElseIf Me.optOther.Checked Then
							Me.lblSideLoadperRodGuide.Left = Me.txtOtherLoad.Left
							Me.lblSideLoadperRodGuide.Top = Me.optOther.Top - Me.lblSideLoadperRodGuide.Height
							Me.lblFricCoeff.Top = Me.lblSideLoadperRodGuide.Top
							Me.cmdResetFrictions.Top = Me.lblFricCoeff.Top
							Me.lblSideLoadperRodGuide.Visible = True
							Me.lblFricCoeff.Visible = True
						End If
					End If
				Catch ex As Exception
				End Try
				Me.pnlDefaults.Focus()
			ElseIf Operators.CompareString(Me.CurrentNodeName, Me.sOutputOptions, False) = 0 Then
				Me.pnlOutputOptions.Left = Me.iPanelLeft
				Me.pnlOutputOptions.Focus()
			ElseIf Operators.CompareString(Me.CurrentNodeName, Me.sCustomizeRodGrades, False) = 0 Then
				Me.LoadRodGrades()
				Me.cmdNewCustomRG.Enabled = True
				Me.cmdModifyCustomRG.Enabled = True
				Me.cmdDeleteCustomRG.Enabled = True
				Me.pnlCustomizeRGList.Left = Me.iPanelLeft
				Me.pnlCustomizeRGList.Focus()
			ElseIf Operators.CompareString(Me.CurrentNodeName, Me.sMeasuredPumpingUnitList, False) = 0 Then
				Me.cmdNewCustomPU.Enabled = True
				Me.cmdModifyCustomPU.Enabled = True
				Me.cmdDeleteCustomPU.Enabled = True
				Me.pnlCustomMeasuredPUList.Left = Me.iPanelLeft
				Me.pnlCustomMeasuredPUList.Focus()
				Dim lvwCustomPU As ListView = Me.lvwCustomPU
				CUSTOMPU.GetCustomUnitNames(lvwCustomPU)
				Me.lvwCustomPU = lvwCustomPU
			Else
				If Operators.CompareString(Me.CurrentNodeName, Me.sCustomizePumpingUnitList, False) = 0 Then
					Try
						Me.ResetClock()
					Catch ex2 As Exception
					End Try
					Me.dlgPUList.ShowDialog()
					Try
						Me.TreeView2.SelectedNode = Nothing
						GoTo IL_83E
					Catch ex3 As Exception
						GoTo IL_83E
					End Try
				End If
				If RSWIN_DESC.DEBUG_AllowDebugging And Operators.CompareString(Me.CurrentNodeName, "Debug", False) = 0 Then
					Me.pnlDebugOptions.Left = Me.iPanelLeft
					Me.pnlDebugOptions.Focus()
				ElseIf Operators.CompareString(Me.CurrentNodeName, Me.sCostDatabase, False) = 0 Then
					Dim cboRodType As ComboBox = Me.cboRodType
					COSTDB.CostDBFillListBoxes(cboRodType, Me.cboPUManuf)
					Me.cboRodType = cboRodType
					If RSWIN_DESC.bRodStarD Then
						Me._optCostCategory_2.Visible = True
						Me._optCostCategory_2.Enabled = True
					Else
						Me._optCostCategory_2.Visible = False
						Me._optCostCategory_2.Enabled = False
					End If
					Me.pnlSetupCostDB.Left = Me.iPanelLeft
					Me.pnlSetupCostDB.Focus()
				ElseIf RSWIN_DESC.bExpert And Operators.CompareString(Me.CurrentNodeName, Me.sExpert, False) = 0 Then
					Me.pnlExpert.Left = Me.iPanelLeft
					If Not Me.bExpertLoaded Then
						Me.LoadExpertPanel()
						Me.bExpertLoaded = True
					End If
					Me.bViewingAIPreferences = True
					Me.pnlExpert.Focus()
				ElseIf RSWIN_DESC.bExpert And RSWIN_DESC.bXRODAdmin And Operators.CompareString(Me.CurrentNodeName, Me.sAdmin, False) = 0 Then
					Me.pnlAdmin.Left = Me.iPanelLeft
					If Not Me.bExpertLoaded Then
						Me.LoadExpertPanel()
						Me.bExpertLoaded = True
					End If
					Me.bViewingAIPreferences = True
					Me.pnlAdmin.Focus()
				End If
			End If
			IL_83E:
			If Me.AutoScroll Then
				Dim startPoint2 As Object = Me.StartPoint
				Me.AutoScrollPosition = If((startPoint2 IsNot Nothing), CType(startPoint2, Point), point)
			End If
		End Sub

		Private Sub cboManufMenuCustomDB_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim text As String
			Dim text2 As String
			If Strings.Len(RuntimeHelpers.GetObjectValue(Me.cboManufMenuCustomDB.Tag)) > 0 Then
				text = Conversions.ToString(Me.cboManufMenuCustomDB.Tag)
				Dim lvwCustomPUDB As ListView = Me.lvwCustomPUDB
				Dim array As String() = New String(lvwCustomPUDB.Items.Count + 1 - 1) {}
				Dim num As Short = 0S
				Dim num2 As Short = 1S
				Dim num3 As Short = CShort(lvwCustomPUDB.Items.Count)
				For num4 As Short = num2 To num3
					If lvwCustomPUDB.Items(CInt(num4)).Checked Then
						num += 1S
						array(CInt(num)) = Convert.ToString(num4)
					End If
				Next
				If num = 0S Then
					text2 = "*"
				Else
					array = CType(Utils.CopyArray(CType(array, Array), New String(CInt((num + 1S)) - 1) {}), String())
					text2 = Strings.Join(array, ",")
				End If
			End If
			Me.LoadUnitMenu(False)
			Dim num5 As Short = CShort(Me.cboManufMenuCustomDB.SelectedIndex)
			text = Strings.Trim(Me.UnitTypeInfoList(CInt(num5)).Abbrev)
			Dim cboManufMenuCustomDB As ComboBox = Me.cboManufMenuCustomDB
			Support.SetItemData(Me.cboManufMenuCustomDB, cboManufMenuCustomDB.SelectedIndex, 1)
			If Operators.ConditionalCompareObjectEqual(cboManufMenuCustomDB.Tag, text, False) Then
				text = Nothing
			Else
				cboManufMenuCustomDB.Tag = text
			End If
			If Strings.Len(text) <> 0 Then
				If Operators.CompareString(text2, "*", False) = 0 Then
					text2 = Nothing
				ElseIf Operators.CompareString(text2, "?", False) = 0 Then
					text2 = Strings.Space(8192)
					Dim num6 As Integer = Custom.CustomPumpingUnitLists_SelectRow(text.Trim(), text2, False, "")
					Dim num7 As Short = CShort(text2.Trim().Length)
				End If
				If Strings.Len(text2) > 0 Then
					Dim array As String() = Strings.Split(Strings.Trim(text2), ",", -1, CompareMethod.Binary)
					Dim lvwCustomPUDB2 As ListView = Me.lvwCustomPUDB
					Dim num8 As Short = CShort(Information.LBound(array, 1))
					Dim num9 As Short = CShort(Information.UBound(array, 1))

						For num4 As Short = num8 To num9
							If Versioned.IsNumeric(array(CInt(num4))) Then
								Dim num As Short = Conversions.ToShort(array(CInt(num4)))
								If num > 0S And CInt(num) <= lvwCustomPUDB2.Items.Count Then
									lvwCustomPUDB2.Items(CInt(num)).Checked = True
								End If
							End If
						Next

				End If
			End If
		End Sub

		Private Sub btnOK_Click(sender As Object, e As EventArgs)
			Me.bCancel = False
			Me.ResetClock()
			Me.StoreOptions(Me.bCancel)
			If Not Me.bCancel Then
				Me.Hide()
				Return
			End If
		End Sub

		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			Me.bCancel = True
			Me.ResetClock()
			If RSWIN_DESC.SETUP_MeasurementSystem <> Me.SAVE_SETUP_MeasurementSystem Then
				RSWIN_DESC.SETUP_MeasurementSystem = Me.SAVE_SETUP_MeasurementSystem
				Dim text As String = "MeasurementSystem"
				Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text2 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				Dim text3 As String = text2
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
				Select Case RSWIN_DESC.SETUP_MeasurementSystem
					Case 1
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "E"
						End If
					Case 2
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "C"
						End If
					Case 3
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "M"
						End If
					Case Else
						RSWIN_DESC.SETUP_MeasurementSystem = 1
						If RSWIN_DESC.frmMain IsNot Nothing Then
							RSWIN_DESC.frmMain.btnMeasUnit.Text = "E"
						End If
				End Select
			End If
			Me.Hide()
		End Sub

		Private Sub InitDefaults()
			Try
				ini.GetPrivateProfileKeyList(RSWIN_DESC.SECT_DEFAULTS, RSWIN_DESC.sDefaultListNames, RSWIN_DESC.sDefaultListValues, RSWIN_DESC.nDefaultListSize, False)
				Dim array As String()
				Util.LoadMenu("SETUP-DEFAULTLIST", RSWIN_DESC.nItems, array)
				Dim num As Short
				Dim nItems As Short
				Me.adiDefaults = New RSWIN_DESC.DEFAULTITEM(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}
				If RSWIN_DESC.nDefaultListSize = 0 Then
					RSWIN_DESC.sDefaultListValues = New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}
					RSWIN_DESC.sDefaultListNames = New String(CInt((RSWIN_DESC.nItems + 1S)) - 1) {}
				End If
				Me.lstDefaultItems.Items.Clear()
				num = 0S
				nItems = RSWIN_DESC.nItems
				For num2 As Short = num To nItems
					Debug.WriteLine(Me.adiDefaults(CInt(num2)).Name + " , " + array(CInt(num2)))
					Dim num3 As Short = CShort(Strings.InStr(array(CInt(num2)), "|", CompareMethod.Binary))
					Me.adiDefaults(CInt(num2)).Title = array(CInt(num2)).Substring(0, CInt((num3 - 1S)))
					array(CInt(num2)) = Strings.Mid(array(CInt(num2)), CInt((num3 + 1S)))
					num3 = CShort(Strings.InStr(array(CInt(num2)), "|", CompareMethod.Binary))
					Me.adiDefaults(CInt(num2)).Name = array(CInt(num2)).Substring(0, CInt((num3 - 1S)))
					array(CInt(num2)) = Strings.Mid(array(CInt(num2)), CInt((num3 + 1S)))
					num3 = CShort(Strings.InStr(array(CInt(num2)), "|", CompareMethod.Binary))
					Me.adiDefaults(CInt(num2)).HelpContextID = Conversions.ToShort(array(CInt(num2)).Substring(0, CInt((num3 - 1S))))
					Me.adiDefaults(CInt(num2)).Type = Conversions.ToChar(Strings.Mid(array(CInt(num2)), CInt((num3 + 1S)), 1))
					array(CInt(num2)) = Strings.Mid(array(CInt(num2)), CInt((num3 + 3S)))
					If Operators.CompareString(Me.adiDefaults(CInt(num2)).Title, "Most Common Pumping Unit Type", False) = 0 Then
						Me.LoadPumpingUnitManufacturers(CInt(num2))
						Me.adiDefaults(CInt(num2)).DefaultValue = Nothing
					Else
						Dim type As Char = Me.adiDefaults(CInt(num2)).Type
						If type = "f"c Then
							num3 = CShort(Strings.InStr(array(CInt(num2)), "|", CompareMethod.Binary))
							Dim text As String = array(CInt(num2)).Substring(0, CInt((num3 - 1S)))
							array(CInt(num2)) = Strings.Mid(array(CInt(num2)), CInt((num3 + 1S)))
							Util.CheckDecimal(text)
							If Versioned.IsNumeric(text) Then
								Me.adiDefaults(CInt(num2)).DefaultValue = Convert.ToSingle(text)
							Else
								Me.adiDefaults(CInt(num2)).DefaultValue = DBNull.Value
							End If
							num3 = CShort(Strings.InStr(array(CInt(num2)), "|", CompareMethod.Binary))
							Me.adiDefaults(CInt(num2)).Units = array(CInt(num2)).Substring(0, CInt((num3 - 1S)))
							array(CInt(num2)) = Strings.Mid(array(CInt(num2)), CInt((num3 + 1S)))
						ElseIf type = "l"c OrElse type = "L"c Then
							num3 = CShort(Strings.InStr(array(CInt(num2)), "|", CompareMethod.Binary))
							Me.adiDefaults(CInt(num2)).DefaultValue = Conversion.Val(array(CInt(num2)).Substring(0, CInt((num3 - 1S))))
							array(CInt(num2)) = Strings.Mid(array(CInt(num2)), CInt((num3 + 1S)))
							num3 = CShort(Strings.InStr(array(CInt(num2)), "|", CompareMethod.Binary))
							Me.adiDefaults(CInt(num2)).items = array(CInt(num2)).Substring(0, CInt((num3 - 1S)))
							array(CInt(num2)) = Strings.Mid(array(CInt(num2)), CInt((num3 + 1S)))
						End If
					End If
					Dim item As String = Convert.ToString(RuntimeHelpers.GetObjectValue(Me.adiDefaults(CInt(num2)).DefaultValue))
					Dim flag As Boolean = ini.CheckForSectionKey(RSWIN_DESC.SECT_DEFAULTS, Me.adiDefaults(CInt(num2)).Name, item)
					Me.lstDefaultItems.Items.Add(Me.adiDefaults(CInt(num2)).Title)
					If Not flag Then
						RSWIN_DESC.sDefaultListNames(CInt(num2)) = Me.adiDefaults(CInt(num2)).Name
						Me.cboDefault.Items.Add(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.adiDefaults(CInt(num2)).DefaultValue)))
					Else
						Me.cboDefault.Items.Add(item)
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtDefault_LocationChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtDefault_Validating(sender As Object, e As CancelEventArgs)
			If Not Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.lstDefaultItems.Tag)) Then
				Return
			End If
			Dim num As Integer = Conversions.ToInteger(Me.lstDefaultItems.Tag)
			Dim flag As Boolean = False
			Dim type As Char = Me.adiDefaults(num).Type
			Dim obj As Object
			If type = "s"c Then
				flag = True
			ElseIf type = "f"c AndAlso CtrlUI.CheckValid(Me.txtDefault, True, True, obj) Then
				Dim name As String = Me.adiDefaults(num).Name
				If Operators.CompareString(name, "CasingPressure", False) = 0 Then
					Dim flag2 As Boolean = False
					Dim obj2 As Object = flag2
					Dim upperBound As Single = 1000F
					Dim inclusive As Integer = -1
					Dim errnum As Integer = 89
					Dim useMetric As Integer = -1
					Dim canadianIsMetric As Integer = -1
					Dim bQuiet As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj2, Util.CheckUpper(obj, upperBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
						flag = True
					End If
				ElseIf Operators.CompareString(name, "ElectricityCost", False) = 0 Then
					Dim flag3 As Boolean = False
					Dim obj3 As Object = flag3
					Dim lowerBound As Single = 0F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 98
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj3, Util.CheckLower(obj, lowerBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Dim obj4 As Object = flag3
						Dim upperBound2 As Single = 10F
						Dim inclusive3 As Integer = -1
						Dim errnum3 As Integer = 97
						Dim useMetric3 As Integer = 0
						Dim canadianIsMetric3 As Integer = 0
						Dim bQuiet3 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj4, Util.CheckUpper(obj, upperBound2, inclusive3, errnum3, useMetric3, canadianIsMetric3, bQuiet3, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "OilGravity", False) = 0 Then
					Dim flag4 As Boolean = False
					Dim obj5 As Object = flag4
					Dim lowerBound2 As Single = 5F
					Dim inclusive4 As Integer = -1
					Dim errnum4 As Integer = 35
					Dim useMetric4 As Integer = -1
					Dim canadianIsMetric4 As Integer = 0
					Dim bQuiet4 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj5, Util.CheckLower(obj, lowerBound2, inclusive4, errnum4, useMetric4, canadianIsMetric4, bQuiet4, text), False) Then
						Dim obj6 As Object = flag4
						Dim upperBound3 As Single = 70F
						Dim inclusive5 As Integer = -1
						Dim errnum5 As Integer = 35
						Dim useMetric5 As Integer = -1
						Dim canadianIsMetric5 As Integer = 0
						Dim bQuiet5 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj6, Util.CheckUpper(obj, upperBound3, inclusive5, errnum5, useMetric5, canadianIsMetric5, bQuiet5, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "PumpLoadAdjustment", False) = 0 Then
					Dim num2 As Single = CSng(((Conversion.Int(0.15 * CDbl(RSWIN_DESC.rst.PumpDepth) / 100.0) + 1.0) * 100.0))
					Dim msgtxt As String = Util.FormatMessage("The pump load adjustment must be between 0 and {0!0} lbs.", New Object() { num2 })
					Dim flag5 As Boolean = False
					Dim obj7 As Object = flag5
					Dim lowerBound3 As Single = 0F
					Dim inclusive6 As Integer = -1
					Dim errnum6 As Integer = -1
					Dim useMetric6 As Integer = 0
					Dim canadianIsMetric6 As Integer = 0
					Dim bQuiet6 As Boolean = False
					Dim text As String = ""
					If Operators.ConditionalCompareObjectEqual(obj7, Util.CheckLower(obj, lowerBound3, inclusive6, errnum6, useMetric6, canadianIsMetric6, bQuiet6, text), False) Then
						Util.Errmsg(msgtxt)
					Else
						Dim obj8 As Object = flag5
						Dim upperBound4 As Single = num2
						Dim inclusive7 As Integer = -1
						Dim errnum7 As Integer = -1
						Dim useMetric7 As Integer = 0
						Dim canadianIsMetric7 As Integer = 0
						Dim bQuiet7 As Boolean = False
						text = ""
						If Operators.ConditionalCompareObjectEqual(obj8, Util.CheckUpper(obj, upperBound4, inclusive7, errnum7, useMetric7, canadianIsMetric7, bQuiet7, text), False) Then
							Util.Errmsg(msgtxt)
						Else
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "PumpingSpeed", False) = 0 Then
					Dim flag6 As Boolean = False
					Dim obj9 As Object = flag6
					Dim lowerBound4 As Single = 0.7F
					Dim inclusive8 As Integer = -1
					Dim errnum8 As Integer = 68
					Dim useMetric8 As Integer = 0
					Dim canadianIsMetric8 As Integer = 0
					Dim bQuiet8 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj9, Util.CheckLower(obj, lowerBound4, inclusive8, errnum8, useMetric8, canadianIsMetric8, bQuiet8, text), False) Then
						Dim obj10 As Object = flag6
						Dim upperBound5 As Single = 50F
						Dim inclusive9 As Integer = -1
						Dim errnum9 As Integer = 68
						Dim useMetric9 As Integer = 0
						Dim canadianIsMetric9 As Integer = 0
						Dim bQuiet9 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj10, Util.CheckUpper(obj, upperBound5, inclusive9, errnum9, useMetric9, canadianIsMetric9, bQuiet9, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "RunTime", False) = 0 Then
					Dim flag7 As Boolean = False
					Dim obj11 As Object = flag7
					Dim lowerBound5 As Single = 0F
					Dim inclusive10 As Integer = 0
					Dim errnum10 As Integer = 134
					Dim useMetric10 As Integer = 0
					Dim canadianIsMetric10 As Integer = 0
					Dim bQuiet10 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj11, Util.CheckLower(obj, lowerBound5, inclusive10, errnum10, useMetric10, canadianIsMetric10, bQuiet10, text), False) Then
						Dim obj12 As Object = flag7
						Dim upperBound6 As Single = 24F
						Dim inclusive11 As Integer = -1
						Dim errnum11 As Integer = 133
						Dim useMetric11 As Integer = 0
						Dim canadianIsMetric11 As Integer = 0
						Dim bQuiet11 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj12, Util.CheckUpper(obj, upperBound6, inclusive11, errnum11, useMetric11, canadianIsMetric11, bQuiet11, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "ServiceFactor", False) = 0 Then
					Dim flag8 As Boolean = False
					Dim obj13 As Object = flag8
					Dim lowerBound6 As Single = 0.5F
					Dim inclusive12 As Integer = -1
					Dim errnum12 As Integer = 61
					Dim useMetric12 As Integer = 0
					Dim canadianIsMetric12 As Integer = 0
					Dim bQuiet12 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj13, Util.CheckLower(obj, lowerBound6, inclusive12, errnum12, useMetric12, canadianIsMetric12, bQuiet12, text), False) Then
						Dim obj14 As Object = flag8
						Dim upperBound7 As Single = 1F
						Dim inclusive13 As Integer = -1
						Dim errnum13 As Integer = 61
						Dim useMetric13 As Integer = 0
						Dim canadianIsMetric13 As Integer = 0
						Dim bQuiet13 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj14, Util.CheckUpper(obj, upperBound7, inclusive13, errnum13, useMetric13, canadianIsMetric13, bQuiet13, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "StuffingBoxFriction", False) = 0 Then
					Dim flag9 As Boolean = False
					Dim obj15 As Object = flag9
					Dim lowerBound7 As Single = 0F
					Dim inclusive14 As Integer = -1
					Dim errnum14 As Integer = 75
					Dim useMetric14 As Integer = -1
					Dim canadianIsMetric14 As Integer = 0
					Dim bQuiet14 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj15, Util.CheckLower(obj, lowerBound7, inclusive14, errnum14, useMetric14, canadianIsMetric14, bQuiet14, text), False) Then
						Dim obj16 As Object = flag9
						Dim upperBound8 As Single = 2000F
						Dim inclusive15 As Integer = -1
						Dim errnum15 As Integer = 75
						Dim useMetric15 As Integer = -1
						Dim canadianIsMetric15 As Integer = 0
						Dim bQuiet15 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj16, Util.CheckUpper(obj, upperBound8, inclusive15, errnum15, useMetric15, canadianIsMetric15, bQuiet15, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "TubingPressure", False) = 0 Then
					Dim flag10 As Boolean = False
					Dim obj17 As Object = flag10
					Dim lowerBound8 As Single = 0F
					Dim inclusive16 As Integer = -1
					Dim errnum16 As Integer = 153
					Dim useMetric16 As Integer = 0
					Dim canadianIsMetric16 As Integer = 0
					Dim bQuiet16 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj17, Util.CheckLower(obj, lowerBound8, inclusive16, errnum16, useMetric16, canadianIsMetric16, bQuiet16, text), False) Then
						Dim obj18 As Object = flag10
						Dim upperBound9 As Single = 1000F
						Dim inclusive17 As Integer = -1
						Dim errnum17 As Integer = 151
						Dim useMetric17 As Integer = -1
						Dim canadianIsMetric17 As Integer = -1
						Dim bQuiet17 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj18, Util.CheckUpper(obj, upperBound9, inclusive17, errnum17, useMetric17, canadianIsMetric17, bQuiet17, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "WaterCut", False) = 0 Then
					Dim flag11 As Boolean = False
					Dim obj19 As Object = flag11
					Dim lowerBound9 As Single = 0F
					Dim inclusive18 As Integer = -1
					Dim errnum18 As Integer = 155
					Dim useMetric18 As Integer = 0
					Dim canadianIsMetric18 As Integer = 0
					Dim bQuiet18 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj19, Util.CheckLower(obj, lowerBound9, inclusive18, errnum18, useMetric18, canadianIsMetric18, bQuiet18, text), False) Then
						Dim obj20 As Object = flag11
						Dim upperBound10 As Single = 100F
						Dim inclusive19 As Integer = 0
						Dim errnum19 As Integer = 154
						Dim useMetric19 As Integer = 0
						Dim canadianIsMetric19 As Integer = 0
						Dim bQuiet19 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj20, Util.CheckUpper(obj, upperBound10, inclusive19, errnum19, useMetric19, canadianIsMetric19, bQuiet19, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "WaterSPGR", False) = 0 Then
					Dim flag12 As Boolean = False
					Dim obj21 As Object = flag12
					Dim lowerBound10 As Single = 0.1F
					Dim inclusive20 As Integer = -1
					Dim errnum20 As Integer = 88
					Dim useMetric20 As Integer = 0
					Dim canadianIsMetric20 As Integer = 0
					Dim bQuiet20 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj21, Util.CheckLower(obj, lowerBound10, inclusive20, errnum20, useMetric20, canadianIsMetric20, bQuiet20, text), False) Then
						Dim obj22 As Object = flag12
						Dim upperBound11 As Single = 1.5F
						Dim inclusive21 As Integer = -1
						Dim errnum21 As Integer = 88
						Dim useMetric21 As Integer = 0
						Dim canadianIsMetric21 As Integer = 0
						Dim bQuiet21 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj22, Util.CheckUpper(obj, upperBound11, inclusive21, errnum21, useMetric21, canadianIsMetric21, bQuiet21, text), False) Then
							flag = True
						End If
					End If
				Else
					flag = True
				End If
			End If
			If flag Then
				If Operators.CompareString(Conversions.ToString(Me.adiDefaults(num).Type), "f", False) = 0 Then
					Dim array As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
					Dim num3 As Integer = num
					Dim text As String = Conversions.ToString(obj)
					Dim num4 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, array(num3).Name, text, RSWIN_DESC.sINIFile))
					obj = text
					Dim num5 As Long = num4
				ElseIf Operators.CompareString(Me.adiDefaults(num).Name.Trim(), "SecondCompanyComments", False) = 0 Then
					Dim array2 As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
					Dim num6 As Integer = num
					Dim rtbDefault As RichTextBox = Me.rtbDefault
					Dim text As String = rtbDefault.Text
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, array2(num6).Name, text, RSWIN_DESC.sINIFile)
					rtbDefault.Text = text
				Else
					Dim array3 As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
					Dim num7 As Integer = num
					Dim txtDefault As TextBox = Me.txtDefault
					Dim text As String = txtDefault.Text
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, array3(num7).Name, text, RSWIN_DESC.sINIFile)
					txtDefault.Text = text
				End If
			End If
		End Sub

		Private Function GetAdiDefaultIndex(sTest As String) As Integer
			Dim num As Integer = 0
			Dim num2 As Integer = Information.UBound(Me.adiDefaults, 1)
			Dim i As Integer
			i = num
			While i <= num2
				If Operators.CompareString(Me.adiDefaults(i).Title.Trim(), sTest.Trim(), False) = 0 Then
					Exit While
				End If
				i += 1
			End While
			Return i
		End Function

		Private Sub lstDefaultItems_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim text As String = ""
			If Me.lstDefaultItems.SelectedIndex <> -1 Then
				Dim obj As Object = 155
				Dim obj2 As Object = Me.lstDefaultItems.Width + Me.lstDefaultItems.Left + 5
				Dim num As Short = CShort(Me.lstDefaultItems.SelectedIndex)
				Me.lstDefaultItems.Tag = num.ToString()
				Dim num2 As Short = CShort(Me.GetAdiDefaultIndex(Conversions.ToString(Me.lstDefaultItems.SelectedItem)))
				If num <> num2 Then
					num = num2
				End If
				Me.cboDefault.Visible = False
				Me.txtDefault.Visible = False
				Me.rtbDefault.Visible = False
				text = Strings.Space(255)
				Me.iSaveIndex = CInt(num)
				Dim length As Short
				Dim text3 As String
				If Strings.InStr(Me.adiDefaults(CInt(num)).Name, "DefaultFolder", CompareMethod.Binary) > 0 Then
					Me.txtDefault.Width = Conversions.ToInteger(Operators.AddObject(obj, 110))
					Me.lblDefaultType.Left = Me.txtDefault.Width + Me.txtDefault.Left + 5
					Me.btnDefault.Top = Me.txtDefault.Top - 3
					Me.btnDefault.Left = Me.txtDefault.Left + Me.txtDefault.Width + 5
					Me.btnDefault.Visible = True
					Dim array As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
					Dim num3 As Integer = CInt(num)
					Dim text2 As String = ""
					length = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_FOLDER_DEFAULTS, array(num3).Name, text2, text, False))
				ElseIf Strings.InStr(Me.adiDefaults(CInt(num)).Name, "SecondCompanyComments", CompareMethod.Binary) > 0 Then
					Me.rtbDefault.BringToFront()
					Me.rtbDefault.Visible = True
					Dim array2 As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
					Dim num4 As Integer = CInt(num)
					Dim text2 As String = ""
					length = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_DEFAULTS, array2(num4).Name, text2, text, False))
					text3 = text.Substring(0, CInt(length))
					Me.rtbDefault.Text = text3
				ElseIf Strings.InStr(Me.adiDefaults(CInt(num)).Name, "SecondCompanyIconFilename", CompareMethod.Binary) > 0 Then
					Me.txtDefault.Width = Conversions.ToInteger(Operators.AddObject(obj, 110))
					Me.lblDefaultType.Left = Me.txtDefault.Width + Me.txtDefault.Left + 5
					Me.btnDefault.Top = Me.txtDefault.Top - 3
					Me.btnDefault.Left = Me.txtDefault.Left + Me.txtDefault.Width + 5
					Me.btnDefault.Visible = True
					Me.txtDefault.BringToFront()
					Me.txtDefault.Visible = True
					Dim array3 As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
					Dim num5 As Integer = CInt(num)
					Dim text2 As String = ""
					length = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_DEFAULTS, array3(num5).Name, text2, text, False))
					text3 = text.Substring(0, CInt(length))
					Me.txtDefault.Text = text3
				Else
					Me.txtDefault.Width = Conversions.ToInteger(obj)
					Me.lblDefaultType.Left = Me.txtDefault.Width + Me.txtDefault.Left + 5
					Me.btnDefault.Visible = False
					Dim array4 As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
					Dim num6 As Integer = CInt(num)
					Dim text2 As String = ""
					length = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_DEFAULTS, array4(num6).Name, text2, text, False))
				End If
				text3 = text.Substring(0, CInt(length))
				Me.lblDefaultType.Text = ""
				Dim type As Char = Me.adiDefaults(CInt(num)).Type
				If type = "f"c Then
					If Operators.CompareString(Me.adiDefaults(CInt(num)).Units.Substring(0, 1), "\", False) = 0 Then
						Me.txtDefault.Tag = RSWIN_DESC.sNull
						Me.lblDefaultType.Text = Strings.Mid(Me.adiDefaults(CInt(num)).Units, 2)
					Else
						Me.txtDefault.Tag = Me.adiDefaults(CInt(num)).Units
						Dim lblDefaultType As Control = Me.lblDefaultType
						Dim txtDefault As Control = Me.txtDefault
						Dim units As String = CtrlUI.TextBox_GetUnitType(txtDefault)
						Me.txtDefault = CType(txtDefault, TextBox)
						CtrlUI.TextBox_SetLabel(lblDefaultType, units, CtrlUI.TextBox_GetUnitSystem(Me.txtDefault) = 1)
						Me.lblDefaultType = CType(lblDefaultType, Label)
					End If
					Me.lblDefaultType.Visible = True
					If Operators.CompareString(Me.adiDefaults(CInt(num)).Units.Substring(0, 1), "\", False) = 0 Then
						Me.txtDefault.Tag = ""
					Else
						Me.txtDefault.Tag = Me.adiDefaults(CInt(num)).Units
						If Strings.Len(RuntimeHelpers.GetObjectValue(Me.txtDefault.Tag)) > 0 Then
							Dim text4 As String = Conversions.ToString(Me.txtDefault.Tag)
						Else
							Dim text4 As String = Me.txtDefault.Text
						End If
						If Operators.CompareString(Me.lblDefaultType.Text, "", False) = 0 Then
							Dim lblDefaultType2 As Label = Me.lblDefaultType
							Dim text2 As String = ""
							lblDefaultType2.Text = CtrlUI.MakeUnitsLabel(text2, Conversions.ToString(NewLateBinding.LateGet(Me.txtDefault.Tag, Nothing, "SubString", New Object() { 0, 1 }, Nothing, Nothing, Nothing)), True)
						End If
					End If
					Me.lblDefaultType.Visible = True
					If Versioned.IsNumeric(text3) Then
						Me.txtDefault.Text = Util.CheckDec(text3)
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.adiDefaults(CInt(num)).DefaultValue)) Then
						Me.txtDefault.Text = Conversions.ToString(Me.adiDefaults(CInt(num)).DefaultValue)
					Else
						Me.txtDefault.Text = RSWIN_DESC.sNull
					End If
					Me.txtDefault.Visible = True
					Me.cboDefault.Visible = False
				ElseIf type = "l"c OrElse type = "L"c Then
					If RSWIN_DESC.SETUP_MeasurementSystem <> 1 And Operators.CompareString(Conversions.ToString(Me.adiDefaults(Me.lstDefaultItems.SelectedIndex).Type), "l", False) = 0 Then
						Dim num7 As Short = CShort(Math.Round(CDbl(Me.cboDefault.Width) / 3.0))
					Else
						Dim num7 As Short = CShort(Me.cboDefault.Width)
					End If
					Me.lblDefaultType.Left = Me.cboDefault.Width + Me.cboDefault.Left + 5
					Me.cboDefault.Items.Clear()
					Dim num8 As Short = 1S
					Dim num9 As Short
					Do
						num9 = CShort(Strings.InStr(CInt(num8), Me.adiDefaults(CInt(num)).items, ";", CompareMethod.Binary))
						Dim text5 As String
						If num9 = 0S Then
							text5 = Strings.Mid(Me.adiDefaults(CInt(num)).items, CInt(num8))
						Else
							' The following expression was wrapped in a unchecked-expression
							text5 = Strings.Mid(Me.adiDefaults(CInt(num)).items, CInt(num8), CInt((num9 - num8)))
							num8 = num9 + 1S
						End If
						Dim num10 As Short = CShort(Strings.InStr(text5, "!", CompareMethod.Binary))
						If num10 > 0S Then
							text5 = text5.Substring(0, CInt((num10 - 1S))) + "     " + Strings.Mid(text5, CInt((num10 + 1S)))
						End If
						Me.cboDefault.Items.Add(text5)
					Loop While num9 <> 0S
					Me.cboDefault.SelectedIndex = -1
					Dim flag As Boolean = True
					If flag <> Not Versioned.IsNumeric(text3) Then
						If flag <> Conversion.Val(text3) < 0.0 Then
							If flag <> Conversion.Val(text3) >= CDbl(Me.cboDefault.Items.Count) Then
								Me.cboDefault.SelectedIndex = CInt(Math.Round(Conversion.Val(text3)))
							End If
						End If
					End If
					Me.txtDefault.Visible = False
					Me.cboDefault.Visible = True
					Me.cboDefault.Enabled = True
				ElseIf type = "s"c Then
					Dim txtDefault2 As TextBox = Me.txtDefault
					txtDefault2.Tag = ""
					txtDefault2.Text = text3
					txtDefault2.Visible = True
					Me.cboDefault.Visible = False
				End If
				Me.lstDefaultItems.Tag = Convert.ToString(num)
				If Me.txtDefault.Visible Then
					Me.txtDefault.BackColor = Color.White
				End If
				Return
			End If
		End Sub

		Private Sub cboDefault_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.lstDefaultItems.Tag)) Then
				Dim num As Integer = Conversions.ToInteger(Me.lstDefaultItems.Tag)
				Dim array As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
				Dim num2 As Integer = num
				Dim text As String = Me.cboDefault.SelectedIndex.ToString()
				Dim obj As Object = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, array(num2).Name, text, RSWIN_DESC.sINIFile)
			End If
		End Sub

		Private Sub RswinSetup_Validating(sender As Object, e As CancelEventArgs)
			RSWIN_DESC.SETUP_TabletPort = Conversions.ToInteger(Me.cboDigitizerComPort.SelectedItem)
			RSWIN_DESC.SETUP_BatchPrintouts = If((-If((Me.chkPrintResults.Checked > False), 1, 0)), 1, 0)
			RSWIN_DESC.SETUP_BatchSaveWorksheet = If((-If((Me.chkCreateWK1.Checked > False), 1, 0)), 1, 0)
			RSWIN_DESC.SETUP_BatchViewWorksheet = If((-If((Me.chkViewWK1.Checked > False), 1, 0)), 1, 0)
			RSWIN_DESC.SETUP_BatchSkipProcessedFiles = If((-If((Me.chkSkipProcessedFiles.Checked > False), 1, 0)), 1, 0)
			RSWIN_DESC.SETUP_BatchUpdateCustomRodGrades = If((-If((Me.optCRGMismatch_1.Checked > False), 1, 0)), 1, 0)
			RSWIN_DESC.SETUP_ExcelInstalled = Me.chkExcelInstalled.Checked
			RSWIN_DESC.SETUP_CreatePDFs = If((-If((Me.chkCreatePDFs.Checked > False), 1, 0)), 1, 0)
			RSWIN_DESC.SETUP_WK1Dir = Me.txtWK1Dir.Text
			RSWIN_DESC.SETUP_RSWINDIR = Me.txtRODSTARDir.Text
			If Information.IsDate(Operators.AddObject(Strings.Trim(Conversions.ToString(Me.nmUDHour.Value)) + ":" + Strings.Trim(Me.nmUDMinute.Text) + " ", Me.cboAMPM.SelectedItem)) Then
				RSWIN_DESC.SETUP_BeginTime = Convert.ToDateTime(Operators.AddObject(Strings.Trim(Me.nmUDHour.Text) + ":" + Strings.Trim(Me.nmUDMinute.Text) + " ", Me.cboAMPM.SelectedItem))
			End If
			If Information.IsDate(Strings.Trim(Conversions.ToString(Me.udHour.Value)) + ":" + Strings.Trim(Me.udMin.Text) + ":00") Then
				RSWIN_DESC.SETUP_IntervalTime = Convert.ToDateTime(Strings.Trim(Me.udHour.Text) + ":" + Strings.Trim(Me.udMin.Text) + ":00")
			Else
				RSWIN_DESC.SETUP_IntervalTime = Convert.ToDateTime("00:20:00")
			End If
			RSWIN_DESC.SETUP_WK1Dir = Strings.Trim(Me.txtWK1Dir.Text)
			RSWIN_DESC.SETUP_RSWINDIR = Strings.Trim(Me.txtRODSTARDir.Text)
			If Me.lstWK1Formats.SelectedIndex < 1 Then
				RSWIN_DESC.SETUP_WK1Format = RSWIN_DESC.sNull
			Else
				RSWIN_DESC.SETUP_WK1Format = Conversions.ToString(Me.lstWK1Formats.Items(Me.lstWK1Formats.SelectedIndex))
				RSWIN_DESC.SETUP_WK1Format = RSWIN_DESC.SETUP_WK1Format.Substring(0, Strings.InStr(RSWIN_DESC.SETUP_WK1Format, Me.sFortySpaces, CompareMethod.Binary) - 1)
			End If
			RSWIN_DESC.SETUP_CoverPage = If((-If((Me.chkReportOpt_.Checked > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_OrderPage = If((-If((Me.chkReportOpt_10.Checked > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintData = If((-If((Me.chkReportOpt_0.Checked > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintCostAnalysis = If((-If((Me.chkReportOpt_1.Checked > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintIPR = If((-If((Me.chkReportOpt_2.Checked > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintDynoPred = If((-If((Me.chkReportOpt_3.Checked > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintTorque = If((-If((Me.chkReportOpt_3.Checked > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintDynoActual = If((-If((Me.chkReportOpt_6.Checked > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_PrintSinglePageDynoTorque = If((-If((Me.chkReportOpt_3.Checked > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_SummaryPage = If((-If((Me.chkReportOpt_7.Checked > False), 1S, 0S)), 1S, 0S)
			RSWIN_DESC.SETUP_ScoringPage = If((-If((Me.chkReportOpt_9.Checked > False), 1S, 0S)), 1S, 0S)
		End Sub

		Private Sub CheckBox_Enable(Index As Integer, ByRef chk As CheckBox, bEnable As Short)
			If(bEnable And If((-If((Not chk.Enabled > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				chk.Enabled = True
				Me.chkReportOpt_Click_1(Index, chk.Checked, True)
			ElseIf(Not bEnable And If((-If((chk.Enabled > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				' The following expression was wrapped in a checked-expression
				Dim num As Short = CShort(chk.CheckState)
				Me.chkReportOpt_Click_1(Index, False, False)
				chk.Enabled = False
				Me.chkReportOpt_Click_1(Index, num <> 0S, True)
			End If
		End Sub

		Private Sub chkReportOpt_Click_1(Index As Integer, Value As Boolean, bClicked As Boolean)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.SetChkReportOpt(Index, Value)
			Me.ShowOutputPages()
		End Sub

		Private Sub LoadManufMenu(ByRef cboManufMenuCustomDB As ComboBox, UseCustomPUDB As Boolean)
			Dim num As Short = 0S
			cboManufMenuCustomDB.Items.Clear()
			Dim tePumpingUnitLists As tePumpingUnitLists = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.PumpingUnitDB().PumpingUnitLists()
			Try
				For Each obj As Object In tePumpingUnitLists
					Dim dictionaryEntry As DictionaryEntry
					Dim tePumpingUnitList As tePumpingUnitList = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, tePumpingUnitList)
					cboManufMenuCustomDB.Items.Add(tePumpingUnitList.Manufacturer)
					num += 1S
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.UnitTypeInfoList = CType(Utils.CopyArray(CType(Me.UnitTypeInfoList, Array), New RSWIN_DESC.UnitTypeInfo(CInt((num - 1S + 1S)) - 1) {}), RSWIN_DESC.UnitTypeInfo())
		End Sub

		Public Sub DeleteCustomPU(ByRef lst As ListView)
			Me.ResetClock()
			Dim msg As String = Me.sARSCustomPU
			Dim bDefaultYes As Boolean = False
			Dim flag As Boolean = False
			If Not Util.YesNo(msg, bDefaultYes, flag) Then
				Return
			End If
			Dim num As Short = CUSTOMPU.OpenCustomPUDB(False, True)
			If num < 0S Then
				Return
			End If
			Dim listViewItem As ListViewItem = lst.SelectedItems(0)
			Dim num2 As Short = Conversions.ToShort(listViewItem.SubItems(4).Text)
			Dim fileNumber As Integer = CInt(num)
			Dim pudataRec As RSWIN_DESC.PUDataRec
			Dim valueType As ValueType = pudataRec
			FileSystem.FileGet(fileNumber, valueType, CLng(num2))
			Dim valueType2 As ValueType = valueType
			Dim pudataRec2 As RSWIN_DESC.PUDataRec
			pudataRec = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec2)
			pudataRec.Manuf = ""
			FileSystem.FilePut(CInt(num), pudataRec, CLng(num2))
			FileSystem.FileClose(New Integer() { CInt(num) })
			lst.Items.RemoveAt(lst.SelectedIndices(0))
		End Sub

		Private Sub cmdDeleteCustomPU_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			If Me.lvwCustomPU.Items.Count > 0 And Me.lvwCustomPU.SelectedItems.Count > 0 Then
				Dim lvwCustomPU As ListView = Me.lvwCustomPU
				Me.DeleteCustomPU(lvwCustomPU)
				Me.lvwCustomPU = lvwCustomPU
				Return
			End If
		End Sub

		Private Sub cmdDeleteCustomPU_MouseHover(sender As Object, e As EventArgs)
			Me.cmdDeleteCustomPU.Show()
		End Sub

		Private Sub cmdDeleteCustomRG_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			If Me.lvwCustomRG.Items.Count > 0 And Me.lvwCustomRG.SelectedItems.Count > 0 Then
				Dim lvwCustomRG As ListView = Me.lvwCustomRG
				Me.DeleteCustomRG(lvwCustomRG)
				Me.lvwCustomRG = lvwCustomRG
				Me.ReLoadRodGrades()
				Return
			End If
		End Sub

		Private Sub cmdDeleteCustomRG_MouseHover(sender As Object, e As EventArgs)
			Me.cmdDeleteCustomRG.Show()
		End Sub

		Private Sub cmdModifyCustomRG_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			If Me.lvwCustomRG.Items.Count > 0 And Me.lvwCustomRG.SelectedItems.Count > 0 Then
				Dim dlgCustomRG As dlgCustomRG = Me.dlgCustomRG
				Dim lvwCustomRG As ListView = Me.lvwCustomRG
				dlgCustomRG.ModifyCustomRG(lvwCustomRG, Me.lvwCustomRG.SelectedIndices(0) + 1)
				Me.lvwCustomRG = lvwCustomRG
				Me.ReLoadRodGrades()
				Return
			End If
			MessageBox.Show("Please select a Rod Grade to modify")
		End Sub

		Private Sub cmdModifyCustomRG_MouseHover(sender As Object, e As EventArgs)
			Me.cmdModifyCustomRG.Show()
		End Sub

		Private Sub ReLoadRodGrades()
			Dim num As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
			Dim lvwCustomRG As ListView = Me.lvwCustomRG
			lvwCustomRG.View = View.Details
			lvwCustomRG.MultiSelect = False
			lvwCustomRG.FullRowSelect = True
			lvwCustomRG.Items.Clear()
			lvwCustomRG.Columns.Clear()
			lvwCustomRG.Columns.Add(Me.csHDR_RodType, 150, HorizontalAlignment.Center)
			lvwCustomRG.Columns.Add(Me.csHDR_TENSILE, 100, HorizontalAlignment.Center)
			lvwCustomRG.Columns.Add(Me.csHDR_STRESS, 220, HorizontalAlignment.Center)
			lvwCustomRG.Columns.Add(Me.csHDR_SINKERBAR, 80, HorizontalAlignment.Center)
			Dim num2 As Integer = 1
			Dim num3 As Integer = num
			For i As Integer = num2 To num3
				Dim listViewItem As ListViewItem = lvwCustomRG.Items.Add("RodType")
				listViewItem.Text = RSWIN_DESC.CustomRodGradeList(i).RodType.Trim()
				listViewItem.SubItems.Add("TensileStrength").Text = Conversions.ToString(RSWIN_DESC.CustomRodGradeList(i).TensileStrength)
				listViewItem.SubItems.Add("StressMethod").Text = RODUTIL.StressMethodName(RSWIN_DESC.CustomRodGradeList(i).StressMethod)
				If RSWIN_DESC.CustomRodGradeList(i).SinkerBar <> 0S Then
					listViewItem.SubItems.Add("SinkerBar").Text = "Yes"
				Else
					listViewItem.SubItems.Add("SinkerBar").Text = "No"
				End If
			Next
		End Sub

		Private Sub cmdModifyCustomPU_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			Dim dlgCustomPU As dlgCustomPU = Me.dlgCustomPU
			Dim lvwCustomPU As ListView = Me.lvwCustomPU
			dlgCustomPU.ModifyCustomPU(lvwCustomPU)
			Me.lvwCustomPU = lvwCustomPU
			lvwCustomPU = Me.lvwCustomPU
			CUSTOMPU.GetCustomUnitNames(lvwCustomPU)
			Me.lvwCustomPU = lvwCustomPU
		End Sub

		Private Sub cmdModifyCustomPU_MouseHover(sender As Object, e As EventArgs)
			Me.cmdModifyCustomPU.Show()
		End Sub

		Private Sub cmdNewCustomRG_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			Dim dlgCustomRG As dlgCustomRG = Me.dlgCustomRG
			Dim lvwCustomRG As ListView = Me.lvwCustomRG
			dlgCustomRG.NewCustomRG(lvwCustomRG)
			Me.lvwCustomRG = lvwCustomRG
			Me.ReLoadRodGrades()
		End Sub

		Private Sub cmdNewCustomRG_MouseHover(sender As Object, e As EventArgs)
			Me.cmdNewCustomRG.Show()
		End Sub

		Private Sub cmdNewCustomPU_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			Dim dlgCustomPU As dlgCustomPU = Me.dlgCustomPU
			Dim lvwCustomPU As ListView = Me.lvwCustomPU
			dlgCustomPU.NewCustomPU(lvwCustomPU)
			Me.lvwCustomPU = lvwCustomPU
			lvwCustomPU = Me.lvwCustomPU
			CUSTOMPU.GetCustomUnitNames(lvwCustomPU)
			Me.lvwCustomPU = lvwCustomPU
		End Sub

		Private Sub cmdNewCustomPU_MouseHover(sender As Object, e As EventArgs)
			Me.cmdNewCustomPU.Show()
		End Sub

		Private Sub cmdPUList_Click(eventSender As Object, eventArgs As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.dlgPUList.ShowDialog()
		End Sub

		Private Sub InitListView(ByRef lvw As ListView)
			lvw.Items.Clear()
			lvw.View = View.Details
			lvw.FullRowSelect = True
			lvw.GridLines = True
		End Sub

		Private Sub LoadRodGrades()
			Try
				Dim text As String
				FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), text, 2S, False, False, False, False)
				If Operators.CompareString(text.Trim(), "", False) <> 0 Then
					Custom.LoadCustomRodGradeList(RSWIN_DESC.CustomRodGradeList, False, "")
				Else
					CUSTOMRG.LoadCustomRodGradeList(RSWIN_DESC.CustomRodGradeList, False)
				End If
			Catch ex As Exception
			End Try
			Dim num As Short = CShort(Information.UBound(RSWIN_DESC.CustomRodGradeList, 1))
			Dim lvwCustomRG As ListView = Me.lvwCustomRG
			lvwCustomRG.View = View.Details
			lvwCustomRG.MultiSelect = False
			lvwCustomRG.FullRowSelect = True
			lvwCustomRG.Items.Clear()
			lvwCustomRG.Columns.Clear()
			lvwCustomRG.Columns.Add(Me.csHDR_RodType, 150, HorizontalAlignment.Center)
			lvwCustomRG.Columns.Add(Me.csHDR_TENSILE, 100, HorizontalAlignment.Center)
			lvwCustomRG.Columns.Add(Me.csHDR_STRESS, 220, HorizontalAlignment.Center)
			lvwCustomRG.Columns.Add(Me.csHDR_SINKERBAR, 80, HorizontalAlignment.Center)
			Dim num2 As Short = 1S
			Dim num3 As Short = num
			For num4 As Short = num2 To num3
				Dim listViewItem As ListViewItem = lvwCustomRG.Items.Add("RodType")
				listViewItem.Text = RSWIN_DESC.CustomRodGradeList(CInt(num4)).RodType.Trim()
				listViewItem.SubItems.Add("TensileStrength").Text = Conversions.ToString(RSWIN_DESC.CustomRodGradeList(CInt(num4)).TensileStrength)
				listViewItem.SubItems.Add("StressMethod").Text = RODUTIL.StressMethodName(RSWIN_DESC.CustomRodGradeList(CInt(num4)).StressMethod)
				If RSWIN_DESC.CustomRodGradeList(CInt(num4)).SinkerBar <> 0S Then
					listViewItem.SubItems.Add("SinkerBar").Text = "Yes"
				Else
					listViewItem.SubItems.Add("SinkerBar").Text = "No"
				End If
			Next
		End Sub

		Private Sub UpdateCustomRodGradeList(ByRef newGrade As RSWIN_DESC.CustomRodGrade)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Me.lvwCustomRG.Items.Count)
			If num = 0S Then
				RSWIN_DESC.CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(0) {}
			Else
				Dim num2 As Short
				Dim array As RSWIN_DESC.CustomRodGrade()
				Dim num3 As Short
				Dim num4 As Short
				num2 = CShort(Information.UBound(RSWIN_DESC.CustomRodGradeList, 1))
				array = New RSWIN_DESC.CustomRodGrade(CInt((num + 1S)) - 1) {}
				num3 = 1S
				num4 = num
				For num5 As Short = num3 To num4
					' The following expression was wrapped in a checked-expression
					Dim text As String = Strings.Trim(Support.GetItemString(Me.lvwCustomRG, CInt((num5 - 1S))))
					Dim num6 As Short = 0S
					Dim num7 As Short = 1S
					Dim num8 As Short = num2
					For num9 As Short = num7 To num8
						If Operators.CompareString(text, Strings.Trim(RSWIN_DESC.CustomRodGradeList(CInt(num9)).RodType), False) = 0 Then
							num6 = -1S
							array(CInt(num5)) = RSWIN_DESC.CustomRodGradeList(CInt(num9))
							Exit For
						End If
					Next
					If Not num6 <> 0S Then
						array(CInt(num5)) = newGrade
					End If
				Next
				RSWIN_DESC.CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(CInt((num + 1S)) - 1) {}
				Dim num10 As Short = 1S
				Dim num11 As Short = num
				For num5 As Short = num10 To num11
					RSWIN_DESC.CustomRodGradeList(CInt(num5)) = array(CInt(num5))
				Next
			End If
		End Sub

		Public Sub DeleteCustomRG(ByRef lst As ListView)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Short = CShort(lst.SelectedIndices(0))
			If num >= 0S Then
				Dim msg As String = Me.sARSCustomRG
				Dim bDefaultYes As Boolean = False
				Dim flag As Boolean = False
				If Util.YesNo(msg, bDefaultYes, flag) Then
					Custom.CustomRodGrades_DeleteDBRow(lst.SelectedItems(0).Text.Trim())
					lst.Items.RemoveAt(CInt(num))
					lst.SelectedItems.Clear()
					Dim num2 As Short = CShort(Information.UBound(RSWIN_DESC.CustomRodGradeList, 1))
					Dim num3 As Short = num + 1S
					Dim num4 As Short = num2 - 1S

						For num5 As Short = num3 To num4
							' The following expression was wrapped in a checked-expression
							RSWIN_DESC.CustomRodGradeList(CInt(num5)) = RSWIN_DESC.CustomRodGradeList(CInt((num5 + 1S)))
						Next

					num2 -= 1S
					If num2 = 0S Then
						RSWIN_DESC.CustomRodGradeList = New RSWIN_DESC.CustomRodGrade(0) {}
					Else
						RSWIN_DESC.CustomRodGradeList = CType(Utils.CopyArray(CType(RSWIN_DESC.CustomRodGradeList, Array), New RSWIN_DESC.CustomRodGrade(CInt((num2 + 1S)) - 1) {}), RSWIN_DESC.CustomRodGrade())
					End If
				End If
			End If
		End Sub

		Private Sub GetUnitList(ByRef iFirstUnit As Short, ByRef nUnits As Short)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(Me.cboManufMenuCustomDB.SelectedIndex)
			If num >= 0S Then
				Dim str As String = Strings.Trim(Me.UnitTypeInfoList(CInt(num)).Abbrev)
				Dim text As String
				FILEUTIL.LocateFile(str + "32.PUD", text, 0S, False, False, False, False)
				If Strings.Len(text) = 0 Then
					If Me.Visible Then
						If num = 0S Then
							Util.Errmsg("You have not entered data for any measured pumping units. You can enter pumping unit dimensions in Setup.")
						Else
							Util.Errmsg("There is no information available for this pumping unit manufacturer.")
						End If
					End If
					Me.UnitData = New RSWIN_DESC.PUDataRec(0) {}
				Else
					Dim num2 As Short = CShort(FileSystem.FreeFile())
					Dim pudataRec As RSWIN_DESC.PUDataRec
					FileSystem.FileOpen(CInt(num2), text, OpenMode.Random, OpenAccess.Read, OpenShare.[Shared], Strings.Len(pudataRec))
					nUnits = CShort((FileSystem.LOF(CInt(num2)) / CLng(Strings.Len(pudataRec))))
					If Me.UnitTypeInfoList(CInt(num)).UnitType = -1S Then
						iFirstUnit = 2S
					Else
						iFirstUnit = 1S
					End If
					If nUnits < iFirstUnit Then
						Me.UnitData = Nothing
					Else
						Me.UnitData = New RSWIN_DESC.PUDataRec(CInt((nUnits + 1S)) - 1) {}
						Dim num3 As Short = 1S
						Dim num4 As Short = CShort(Information.UBound(Me.UnitData, 1))

							For num5 As Short = num3 To num4
								Dim fileNumber As Integer = CInt(num2)
								Dim unitData As RSWIN_DESC.PUDataRec() = Me.UnitData
								Dim num6 As Integer = CInt(num5)
								Dim valueType As ValueType = unitData(num6)
								FileSystem.FileGet(fileNumber, valueType, CLng(num5))
								Dim unitData2 As RSWIN_DESC.PUDataRec() = Me.UnitData
								Dim num7 As Integer = num6
								Dim valueType2 As ValueType = valueType
								Dim pudataRec2 As RSWIN_DESC.PUDataRec
								unitData2(num7) = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec2)
							Next

					End If
					FileSystem.FileClose(New Integer() { CInt(num2) })
				End If
			End If
		End Sub

		Private Sub LoadUnitMenu(Clicked As Boolean)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(Me.cboManufMenuCustomDB.SelectedIndex)
			Dim flag As Boolean = Me.UnitTypeInfoList(CInt(num)).ShowNames <> 0S
			Dim expression As Boolean = Me.UnitTypeInfoList(CInt(num)).SortByNames <> 0S
			Dim lvwCustomPUDB As ListView = Me.lvwCustomPUDB
			lvwCustomPUDB.Items.Clear()
			lvwCustomPUDB.View = View.Details
			lvwCustomPUDB.FullRowSelect = True
			lvwCustomPUDB.GridLines = True
			Dim columns As ListView.ColumnHeaderCollection = lvwCustomPUDB.Columns
			columns.Clear()
			Dim columnHeader As System.Windows.Forms.ColumnHeader = columns.Add("display name column", 0, HorizontalAlignment.Left)
			columnHeader.Width = 0
			columns.Add(Me.csHDR_APIDES, 100, HorizontalAlignment.Left)
			columns.Add(Me.csHDR_UNAME, 100, HorizontalAlignment.Left)
			columns.Add(Me.csHDR_OTHER, 100, HorizontalAlignment.Left)
			Dim num3 As Integer
			Dim num2 As Short = CShort(num3)
			Dim num5 As Integer
			Dim num4 As Short = CShort(num5)
			Me.GetUnitList(num2, num4)
			num5 = CInt(num4)
			num3 = CInt(num2)
			If Information.UBound(Me.UnitData, 1) > 0 Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.IIf(expression, 0, 1))
				Dim array As Integer()
				PUDATA1.SortPUnits(Me.UnitData, array, objectValue, num3, num5)
				Dim str As String = Strings.Trim(Me.UnitTypeInfoList(CInt(num)).Abbrev)
				Dim num6 As Short = CShort(Information.LBound(Me.UnitData, 1))
				Dim num7 As Short = CShort(Information.UBound(Me.UnitData, 1))

					For num8 As Short = num6 To num7
						Dim text As String = Strings.Trim(Me.UnitData(array(CInt(num8))).APIDesignation)
						Dim text2 As String = Strings.Trim(Me.UnitData(array(CInt(num8))).OtherInfo)
						Dim text3 As String = Strings.Trim(Me.UnitData(array(CInt(num8))).UnitName)
						Dim text4 As String = Conversions.ToString(Interaction.IIf(flag, text3, text))
						Dim listViewItem As ListViewItem = Me.lvwCustomPUDB.Items.Add(str + Conversions.ToString(array(CInt(num8))), text4)
						listViewItem.Tag = text4
						Dim subItems As ListViewItem.ListViewSubItemCollection = listViewItem.SubItems
						subItems.Add(Me.csHDR_APIDES).Text = text
						subItems.Add(Me.csHDR_UNAME).Text = text3
						subItems.Add(Me.csHDR_OTHER).Text = text2
					Next
					Dim columns2 As ListView.ColumnHeaderCollection = Me.lvwCustomPUDB.Columns
					If flag Then
						columns2(1).Text = Me.csHDR_UNAME
						columns2(1).Width = columns2("UnitName").Width
						columns2("UnitName").Width = 0
					Else
						columns2(1).Text = Me.csHDR_APIDES
						columns2(1).Width = columns2("APIDesignation").Width
						columns2("APIDesignation").Width = 0
					End If

			End If
		End Sub

		Private Sub ShowOutputPages()
			Dim num As Integer = If((-If((Me.GetChkReportOpt(6) > False), 1, 0)), 1, 0)
			Dim num2 As Integer = If((-If((Me.GetChkReportOpt(7) > False), 1, 0)), 1, 0)
			Dim array As Integer() = New Integer(9) {}
			Dim array2 As Integer() = New Integer(9) {}
			array(0) = 0
			array2(0) = 0
			array(1) = 40
			array2(1) = 0
			array(2) = 0
			array2(2) = 40
			array(3) = 40
			array2(3) = 40
			array(4) = 0
			array2(4) = 80
			array(5) = 40
			array2(5) = 80
			array(6) = 0
			array2(6) = 120
			array(7) = 40
			array2(7) = 120
			array(8) = 0
			array2(8) = 160
			array(9) = 40
			array2(9) = 160
			Dim num3 As Integer = -1
			If Me.GetChkReportOpt(-1) Then
				num3 += 1
				Dim control As Control = Me.imgPreview_
				Me.MoveImage(control, array(num3), array2(num3))
				Me.imgPreview_ = CType(control, PictureBox)
			Else
				Me.imgPreview_.Visible = False
			End If
			If Me.GetChkReportOpt(0) Then
				num3 += 1
				Dim control As Control = Me.imgPreview_0
				Me.MoveImage(control, array(num3), array2(num3))
				Me.imgPreview_0 = CType(control, PictureBox)
			Else
				Me.imgPreview_0.Visible = False
			End If
			If Me.GetChkReportOpt(1) Then
				num3 += 1
				Dim control As Control = Me.imgPreview_1
				Me.MoveImage(control, array(num3), array2(num3))
				Me.imgPreview_1 = CType(control, PictureBox)
			Else
				Me.imgPreview_1.Visible = False
			End If
			If Me.GetChkReportOpt(2) Then
				num3 += 1
				Dim control As Control = Me.imgPreview_2
				Me.MoveImage(control, array(num3), array2(num3))
				Me.imgPreview_2 = CType(control, PictureBox)
			Else
				Me.imgPreview_2.Visible = False
			End If
			Me.imgPreview_3.Visible = False
			If Me.GetChkReportOpt(3) Then
				num3 += 1
				Dim control As Control = Me.imgPreview_3
				Me.MoveImage(control, array(num3), array2(num3))
				Me.imgPreview_3 = CType(control, PictureBox)
			Else
				Me.imgPreview_3.Visible = False
			End If
			If Me.GetChkReportOpt(4) And RSWIN_DESC.bRodStarD Then
				num3 += 1
				Dim control As Control = Me.imgPreview_4
				Me.MoveImage(control, array(num3), array2(num3))
				Me.imgPreview_4 = CType(control, PictureBox)
			Else
				Me.imgPreview_4.Visible = False
			End If
			If Me.GetChkReportOpt(5) And RSWIN_DESC.bRodStarD Then
				num3 += 1
				Dim control As Control = Me.imgPreview_5
				Me.MoveImage(control, array(num3) + 3, array2(num3))
				Me.imgPreview_5 = CType(control, PictureBox)
			Else
				Me.imgPreview_5.Visible = False
			End If
			If Me.GetChkReportOpt(8) And RSWIN_DESC.bRodStarD Then
				num3 += 1
				Dim control As Control = Me.imgPreview_6
				Me.MoveImage(control, array(num3) + 3, array2(num3))
				Me.imgPreview_6 = CType(control, PictureBox)
			Else
				Me.imgPreview_6.Visible = False
			End If
			If Me.GetChkReportOpt(9) Then
				num3 += 1
				Dim control As Control = Me.imgPreview_9
				Me.MoveImage(control, array(num3), array2(num3))
				Me.imgPreview_9 = CType(control, PictureBox)
			Else
				Me.imgPreview_9.Visible = False
			End If
			If Me.GetChkReportOpt(10) Then
				num3 += 1
				Dim control As Control = Me.imgPreview_10
				Me.MoveImage(control, array(num3), array2(num3))
				Me.imgPreview_10 = CType(control, PictureBox)
				Return
			End If
			Me.imgPreview_10.Visible = False
		End Sub

		Private Sub MoveImage(ByRef img As Control, x As Integer, y As Integer)
			img.Left = x
			img.Top = y
			img.Visible = True
		End Sub

		Private Sub chkReportOpt__CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(-1, Me.chkReportOpt_.Checked, True)
		End Sub

		Private Sub chkReportOpt_0_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(0, Me.chkReportOpt_0.Checked, True)
		End Sub

		Private Sub chkReportOpt_1_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(1, Me.chkReportOpt_1.Checked, True)
		End Sub

		Private Sub chkReportOpt_2_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(2, Me.chkReportOpt_2.Checked, True)
		End Sub

		Private Sub chkReportOpt_3_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(3, Me.chkReportOpt_3.Checked, True)
		End Sub

		Private Sub chkReportOpt_6_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(6, Me.chkReportOpt_6.Checked, True)
		End Sub

		Private Sub chkReportOpt_7_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(7, Me.chkReportOpt_7.Checked, True)
		End Sub

		Friend Overridable Property lvwCustomRG As ListView
			Get
				Return Me._lvwCustomRG
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Me._lvwCustomRG = value
			End Set
		End Property

		Private Sub btnNewSS_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			Me.WK1New()
		End Sub

		Private Sub btnNewSS_MouseHover(sender As Object, e As EventArgs)
			Me.btnNewSS.Show()
		End Sub

		Private Sub btnDeleteSS_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			If Me.lstWK1Formats.Items.Count > 0 And Me.lstWK1Formats.SelectedIndex > 0 Then
				Me.WK1Delete()
				Return
			End If
		End Sub

		Private Sub btnDeleteSS_MouseHover(sender As Object, e As EventArgs)
			Me.btnDeleteSS.Show()
		End Sub

		Private Sub btnModifySS_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			If Me.lstWK1Formats.Items.Count > 0 And Me.lstWK1Formats.SelectedIndex > 0 Then
				Me.WK1Modify()
				Return
			End If
		End Sub

		Private Sub btnModifySS_MouseHover(sender As Object, e As EventArgs)
			Me.btnModifySS.Show()
		End Sub

		Private Sub WK1Delete()
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Short = CShort(Me.lstWK1Formats.SelectedIndex)
				If num = -1S Then
					MessageBox.Show("Please select a spreadsheet format.", "", MessageBoxButtons.OK)
				ElseIf num > 0S Then
					Dim itemString As String = Support.GetItemString(Me.lstWK1Formats, CInt(num))
					Dim str As String = itemString.Substring(0, Strings.InStr(itemString, Me.sFortySpaces, CompareMethod.Binary) - 1)
					Dim msg As String = Me.sARSFormat + "(" + str + ")?"
					Dim bDefaultYes As Boolean = False
					Dim flag As Boolean = False
					If Util.YesNo(msg, bDefaultYes, flag) Then
						Dim text As String = Nothing
						RSWIN.DeleteRegProfileStringFromKeyList(RSWIN_DESC.SECT_WK1FORMATS, str, text, RSWIN_DESC.sINIFile)
						Me.lstWK1Formats.Items.RemoveAt(CInt(num))
						Me.lstWK1Formats.SelectedIndex = 0
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub WK1Modify()
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Short = CShort(Me.lstWK1Formats.SelectedIndex)
				If num = -1S Then
					MessageBox.Show("Please select a spreadsheet format.", "", MessageBoxButtons.OK)
				ElseIf num > 0S Then
					Dim text As String = Support.GetItemString(Me.lstWK1Formats, CInt(num))
					Dim text2 As String = text.Substring(0, Strings.InStr(text, Me.sFortySpaces, CompareMethod.Binary) - 1)
					Me.dlgWK1Setup.cmdLoadTag = text
					Me.dlgWK1Setup.WK1List = Me.lstWK1Formats
					Try
						Me.ResetClock()
					Catch ex As Exception
					End Try
					Me.dlgWK1Setup.ShowDialog()
					Dim defInstance As Form = dlgWK1Setup.DefInstance
					Dim flag As Boolean = RSWIN.IsFormLoaded(defInstance)
					dlgWK1Setup.DefInstance = CType(defInstance, dlgWK1Setup)
					If flag AndAlso Not Me.dlgWK1Setup.bCancel Then
						Dim selectList As ListBox = Me.dlgWK1Setup.SelectList
						Me.lstWK1Formats = Me.dlgWK1Setup.WK1List
						Dim num2 As Short = CShort(selectList.Items.Count)
						text = RSWIN_DESC.sNull
						Dim num3 As Short = 0S
						Dim num4 As Short = num2 - 1S

							For num5 As Short = num3 To num4
								text = text + "," + Convert.ToString(Support.GetItemData(selectList, CInt(num5)))
							Next
							text = Strings.Mid(text, 2)
							If Me.dlgWK1Setup.IncludeRodString Then
								text += ",-1"
							End If
							Dim text3 As String = Me.dlgWK1Setup.FormatName.Trim()
							If Operators.CompareString(text3, text2, False) = 0 Then
								Support.SetItemString(Me.lstWK1Formats, CInt(num), text3 + Me.sFortySpaces + text)
							Else
								Dim text4 As String = Nothing
								RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_WK1FORMATS, text2, text4, RSWIN_DESC.sINIFile)
								Me.lstWK1Formats.Items.RemoveAt(CInt(num))
								Dim num6 As Short = 1S
								Dim num7 As Short = CShort((Me.lstWK1Formats.Items.Count - 1))
								Dim num5 As Short
								num5 = num6
								While num5 <= num7
									Dim itemString As String = Support.GetItemString(Me.lstWK1Formats, CInt(num5))
									If Strings.StrComp(text3, itemString.Trim(), CompareMethod.Text) < 0 Then
										Exit While
									End If
									num5 += 1S
								End While
								Me.lstWK1Formats.Items.Insert(CInt(num5), text3 + Me.sFortySpaces + text)
								Me.lstWK1Formats.SelectedIndex = CInt(num5)
							End If
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_WK1FORMATS, text3, text, RSWIN_DESC.sINIFile)

					End If
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub WK1New()
			Try
				Me.dlgWK1Setup.cmdLoadTag = ""
				Me.dlgWK1Setup.WK1List = Me.lstWK1Formats
				Me.dlgWK1Setup.ShowDialog()
				Me.ResetClock()
				Me.lstWK1Formats = Me.dlgWK1Setup.WK1List
				Dim flag As Boolean = Not Me.dlgWK1Setup.bCancel
				Dim defInstance As Form = dlgWK1Setup.DefInstance
				Dim flag2 As Boolean = RSWIN.IsFormLoaded(defInstance)
				dlgWK1Setup.DefInstance = CType(defInstance, dlgWK1Setup)
				If flag2 AndAlso flag Then
					Dim selectList As ListBox = Me.dlgWK1Setup.SelectList
					Dim text As String
					Dim num2 As Short
					Dim num3 As Short
					Dim num As Short = CShort(selectList.Items.Count)
					text = ""
					num2 = 0S
					num3 = num - 1S
					Dim num4 As Short
					num4 = num2
					While num4 <= num3
						text = text + "," + Convert.ToString(Support.GetItemData(selectList, CInt(num4)))
						num4 += 1S
					End While
					text = Strings.Mid(text, 2)
					If Me.dlgWK1Setup.IncludeRodString Then
						text += ",-1"
					End If
					Dim text2 As String = Me.dlgWK1Setup.FormatName.Trim()
					Dim num5 As Short = 1S
					Dim num6 As Short = CShort((Me.lstWK1Formats.Items.Count - 1))
					num4 = num5
					While num4 <= num6
						Dim itemString As String = Support.GetItemString(Me.lstWK1Formats, CInt(num4))
						If Strings.StrComp(text2, itemString.Trim(), CompareMethod.Text) < 0 Then
							Exit While
						End If
						num4 += 1S
					End While
					Me.lstWK1Formats.Items.Insert(CInt(num4), text2 + Me.sFortySpaces + text)
					Me.lstWK1Formats.SelectedIndex = CInt(num4)
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_WK1FORMATS, text2, text, RSWIN_DESC.sINIFile)
					dlgWK1Setup.DefInstance.Close()
					dlgWK1Setup.DefInstance = Nothing
				End If
			Catch ex As Exception
			End Try
		End Sub

		Friend Overridable Property btnDeleteSS As Button
			Get
				Return Me._btnDeleteSS
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnDeleteSS_MouseHover
				Dim value3 As EventHandler = AddressOf Me.btnDeleteSS_Click
				If Me._btnDeleteSS IsNot Nothing Then
					RemoveHandler Me._btnDeleteSS.MouseHover, value2
					RemoveHandler Me._btnDeleteSS.Click, value3
				End If
				Me._btnDeleteSS = value
				If Me._btnDeleteSS IsNot Nothing Then
					AddHandler Me._btnDeleteSS.MouseHover, value2
					AddHandler Me._btnDeleteSS.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property btnNewSS As Button
			Get
				Return Me._btnNewSS
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnNewSS_MouseHover
				Dim value3 As EventHandler = AddressOf Me.btnNewSS_Click
				If Me._btnNewSS IsNot Nothing Then
					RemoveHandler Me._btnNewSS.MouseHover, value2
					RemoveHandler Me._btnNewSS.Click, value3
				End If
				Me._btnNewSS = value
				If Me._btnNewSS IsNot Nothing Then
					AddHandler Me._btnNewSS.MouseHover, value2
					AddHandler Me._btnNewSS.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property btnModifySS As Button
			Get
				Return Me._btnModifySS
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnModifySS_MouseHover
				Dim value3 As EventHandler = AddressOf Me.btnModifySS_Click
				If Me._btnModifySS IsNot Nothing Then
					RemoveHandler Me._btnModifySS.MouseHover, value2
					RemoveHandler Me._btnModifySS.Click, value3
				End If
				Me._btnModifySS = value
				If Me._btnModifySS IsNot Nothing Then
					AddHandler Me._btnModifySS.MouseHover, value2
					AddHandler Me._btnModifySS.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property lvwCustomPUDB As ListView
			Get
				Return Me._lvwCustomPUDB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Me._lvwCustomPUDB = value
			End Set
		End Property

		Private Sub nmUDHour_ValueChanged(sender As Object, e As EventArgs)
			If Decimal.Compare(Me.nmUDHour.Value, 12D) > 0 Then
				Me.nmUDHour.Value = 1D
				Return
			End If
			If Decimal.Compare(Me.nmUDHour.Value, 1D) < 0 Then
				Me.nmUDHour.Value = 12D
				Return
			End If
		End Sub

		Private Sub nmUDMinute_ValueChanged(sender As Object, e As EventArgs)
			If Decimal.Compare(Me.nmUDMinute.Value, 60D) = 0 Then
				Me.nmUDMinute.Value = 0D
				Return
			End If
			If Decimal.Compare(Me.nmUDMinute.Value, 0D) < 0 Then
				Me.nmUDMinute.Value = 59D
				Return
			End If
		End Sub

		Private Sub udHour_ValueChanged(sender As Object, e As EventArgs)
			If Decimal.Compare(Me.udHour.Value, 12D) > 0 Then
				Me.udHour.Value = 0D
				Return
			End If
			If Decimal.Compare(Me.udHour.Value, 0D) < 0 Then
				Me.udHour.Value = 12D
				Return
			End If
		End Sub

		Private Sub UDMin_ValueChanged(sender As Object, e As EventArgs)
			If Decimal.Compare(Me.udMin.Value, 60D) = 0 Then
				Me.udMin.Value = 0D
				Return
			End If
			If Decimal.Compare(Me.udMin.Value, 0D) < 0 Then
				Me.udMin.Value = 59D
				Return
			End If
		End Sub

		Public Function BrowseForFolder(sCaption As String, ByRef sInitialDir As String) As String
			Me.dlgSelectDir.Caption = sCaption
			Me.dlgSelectDir.Path = sInitialDir
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.dlgSelectDir.ShowDialog()
			Return Me.dlgSelectDir.Path
		End Function

		Private Sub btnRODSTARDataDict_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			Dim text As String = ""
			Dim sCaption As String = Me.sSelectRSFolder
			Me.ResetClock()
			Dim text2 As String = Me.BrowseForFolder(sCaption, text)
			If Operators.CompareString(text2, "", False) <> 0 Then
				Me.txtRODSTARDir.Text = text2
			End If
		End Sub

		Private Sub cmdBrowse_2_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			Dim text As String = ""
			Dim sCaption As String = Me.sSelectSSFolder
			Dim text2 As String = Me.BrowseForFolder(sCaption, text)
			If Operators.CompareString(text2, "", False) <> 0 Then
				Me.txtWK1Dir.Text = text2
			End If
		End Sub

		Private Sub txtDefault_Leave(sender As Object, e As EventArgs)
			If Not Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.lstDefaultItems.Tag)) Then
				Return
			End If
			Dim num As Integer = Conversions.ToInteger(Me.lstDefaultItems.Tag)
			Dim flag As Boolean = False
			Dim type As Char = Me.adiDefaults(num).Type
			Dim obj As Object
			If type = "s"c Then
				obj = Me.txtDefault.Text
				If Conversions.ToBoolean(Operators.AndObject(Strings.InStr(Me.adiDefaults(num).Name, "DefaultFolder", CompareMethod.Binary) > 0, Operators.CompareObjectNotEqual(obj, "", False))) Then
					If Not Directory.Exists(Conversions.ToString(obj)) Then
						flag = False
						Util.Errmsg("Folder entered does not exist. You must delete this entry or create the folder.")
					Else
						flag = True
					End If
				Else
					flag = True
				End If
			ElseIf type = "f"c AndAlso CtrlUI.CheckValid(Me.txtDefault, True, True, obj) Then
				Dim name As String = Me.adiDefaults(num).Name
				If Operators.CompareString(name, "CasingPressure", False) = 0 Then
					Dim flag2 As Boolean = False
					Dim obj2 As Object = flag2
					Dim upperBound As Single = 1000F
					Dim inclusive As Integer = -1
					Dim errnum As Integer = 89
					Dim useMetric As Integer = -1
					Dim canadianIsMetric As Integer = -1
					Dim bQuiet As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj2, Util.CheckUpper(obj, upperBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
						flag = True
					End If
				ElseIf Operators.CompareString(name, "ElectricityCost", False) = 0 Then
					Dim flag3 As Boolean = False
					Dim obj3 As Object = flag3
					Dim lowerBound As Single = 0F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 98
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj3, Util.CheckLower(obj, lowerBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Dim obj4 As Object = flag3
						Dim upperBound2 As Single = 10F
						Dim inclusive3 As Integer = -1
						Dim errnum3 As Integer = 97
						Dim useMetric3 As Integer = 0
						Dim canadianIsMetric3 As Integer = 0
						Dim bQuiet3 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj4, Util.CheckUpper(obj, upperBound2, inclusive3, errnum3, useMetric3, canadianIsMetric3, bQuiet3, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "OilGravity", False) = 0 Then
					Dim flag4 As Boolean = False
					Dim obj5 As Object = flag4
					Dim lowerBound2 As Single = 5F
					Dim inclusive4 As Integer = -1
					Dim errnum4 As Integer = 35
					Dim useMetric4 As Integer = -1
					Dim canadianIsMetric4 As Integer = 0
					Dim bQuiet4 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj5, Util.CheckLower(obj, lowerBound2, inclusive4, errnum4, useMetric4, canadianIsMetric4, bQuiet4, text), False) Then
						Dim obj6 As Object = flag4
						Dim upperBound3 As Single = 70F
						Dim inclusive5 As Integer = -1
						Dim errnum5 As Integer = 35
						Dim useMetric5 As Integer = -1
						Dim canadianIsMetric5 As Integer = 0
						Dim bQuiet5 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj6, Util.CheckUpper(obj, upperBound3, inclusive5, errnum5, useMetric5, canadianIsMetric5, bQuiet5, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "PumpEfficiency", False) = 0 Then
					Dim flag5 As Boolean = False
					Dim obj7 As Object = flag5
					Dim lowerBound3 As Single = 50F
					Dim inclusive6 As Integer = -1
					Dim errnum6 As Integer = 0
					Dim useMetric6 As Integer = 0
					Dim canadianIsMetric6 As Integer = 0
					Dim bQuiet6 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj7, Util.CheckLower(obj, lowerBound3, inclusive6, errnum6, useMetric6, canadianIsMetric6, bQuiet6, text), False) Then
						Dim obj8 As Object = flag5
						Dim upperBound4 As Single = 100F
						Dim inclusive7 As Integer = -1
						Dim errnum7 As Integer = 0
						Dim useMetric7 As Integer = 0
						Dim canadianIsMetric7 As Integer = 0
						Dim bQuiet7 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj8, Util.CheckUpper(obj, upperBound4, inclusive7, errnum7, useMetric7, canadianIsMetric7, bQuiet7, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "PumpFillage", False) = 0 Then
					Dim flag6 As Boolean = False
					Dim obj9 As Object = flag6
					Dim lowerBound4 As Single = 10F
					Dim inclusive8 As Integer = -1
					Dim errnum8 As Integer = 0
					Dim useMetric8 As Integer = 0
					Dim canadianIsMetric8 As Integer = 0
					Dim bQuiet8 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj9, Util.CheckLower(obj, lowerBound4, inclusive8, errnum8, useMetric8, canadianIsMetric8, bQuiet8, text), False) Then
						Dim obj10 As Object = flag6
						Dim upperBound5 As Single = 95F
						Dim inclusive9 As Integer = -1
						Dim errnum9 As Integer = 0
						Dim useMetric9 As Integer = 0
						Dim canadianIsMetric9 As Integer = 0
						Dim bQuiet9 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj10, Util.CheckUpper(obj, upperBound5, inclusive9, errnum9, useMetric9, canadianIsMetric9, bQuiet9, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "PumpLoadAdjustment", False) = 0 Then
					Dim num2 As Single = CSng(((Conversion.Int(0.15 * CDbl(RSWIN_DESC.rst.PumpDepth) / 100.0) + 1.0) * 100.0))
					Dim msgtxt As String
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						msgtxt = Util.FormatMessage("The pump load adjustment must be between 0 and {0!0} N.", New Object() { CtrlUI.ConvertUnits(num2, 12) })
					Else
						msgtxt = Util.FormatMessage("The pump load adjustment must be between 0 and {0!0} lbs.", New Object() { num2 })
					End If
					Dim flag7 As Boolean = False
					Dim obj11 As Object = flag7
					Dim lowerBound5 As Single = 0F
					Dim inclusive10 As Integer = -1
					Dim errnum10 As Integer = -1
					Dim useMetric10 As Integer = 0
					Dim canadianIsMetric10 As Integer = 0
					Dim bQuiet10 As Boolean = False
					Dim text As String = ""
					If Operators.ConditionalCompareObjectEqual(obj11, Util.CheckLower(obj, lowerBound5, inclusive10, errnum10, useMetric10, canadianIsMetric10, bQuiet10, text), False) Then
						Util.Errmsg(msgtxt)
					Else
						Dim obj12 As Object = flag7
						Dim upperBound6 As Single = num2
						Dim inclusive11 As Integer = -1
						Dim errnum11 As Integer = -1
						Dim useMetric11 As Integer = 0
						Dim canadianIsMetric11 As Integer = 0
						Dim bQuiet11 As Boolean = False
						text = ""
						If Operators.ConditionalCompareObjectEqual(obj12, Util.CheckUpper(obj, upperBound6, inclusive11, errnum11, useMetric11, canadianIsMetric11, bQuiet11, text), False) Then
							Util.Errmsg(msgtxt)
						Else
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "PumpingSpeed", False) = 0 Then
					Dim flag8 As Boolean = False
					Dim obj13 As Object = flag8
					Dim lowerBound6 As Single = 0.7F
					Dim inclusive12 As Integer = -1
					Dim errnum12 As Integer = 68
					Dim useMetric12 As Integer = 0
					Dim canadianIsMetric12 As Integer = 0
					Dim bQuiet12 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj13, Util.CheckLower(obj, lowerBound6, inclusive12, errnum12, useMetric12, canadianIsMetric12, bQuiet12, text), False) Then
						Dim obj14 As Object = flag8
						Dim upperBound7 As Single = 50F
						Dim inclusive13 As Integer = -1
						Dim errnum13 As Integer = 68
						Dim useMetric13 As Integer = 0
						Dim canadianIsMetric13 As Integer = 0
						Dim bQuiet13 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj14, Util.CheckUpper(obj, upperBound7, inclusive13, errnum13, useMetric13, canadianIsMetric13, bQuiet13, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "RunTime", False) = 0 Then
					Dim flag9 As Boolean = False
					Dim obj15 As Object = flag9
					Dim lowerBound7 As Single = 0F
					Dim inclusive14 As Integer = 0
					Dim errnum14 As Integer = 134
					Dim useMetric14 As Integer = 0
					Dim canadianIsMetric14 As Integer = 0
					Dim bQuiet14 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj15, Util.CheckLower(obj, lowerBound7, inclusive14, errnum14, useMetric14, canadianIsMetric14, bQuiet14, text), False) Then
						Dim obj16 As Object = flag9
						Dim upperBound8 As Single = 24F
						Dim inclusive15 As Integer = -1
						Dim errnum15 As Integer = 133
						Dim useMetric15 As Integer = 0
						Dim canadianIsMetric15 As Integer = 0
						Dim bQuiet15 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj16, Util.CheckUpper(obj, upperBound8, inclusive15, errnum15, useMetric15, canadianIsMetric15, bQuiet15, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "ServiceFactor", False) = 0 Then
					Dim flag10 As Boolean = False
					Dim obj17 As Object = flag10
					Dim lowerBound8 As Single = 0.5F
					Dim inclusive16 As Integer = -1
					Dim errnum16 As Integer = 61
					Dim useMetric16 As Integer = 0
					Dim canadianIsMetric16 As Integer = 0
					Dim bQuiet16 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj17, Util.CheckLower(obj, lowerBound8, inclusive16, errnum16, useMetric16, canadianIsMetric16, bQuiet16, text), False) Then
						Dim obj18 As Object = flag10
						Dim upperBound9 As Single = 1F
						Dim inclusive17 As Integer = -1
						Dim errnum17 As Integer = 61
						Dim useMetric17 As Integer = 0
						Dim canadianIsMetric17 As Integer = 0
						Dim bQuiet17 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj18, Util.CheckUpper(obj, upperBound9, inclusive17, errnum17, useMetric17, canadianIsMetric17, bQuiet17, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "SteelSuckerRodLength", False) = 0 Then
					If Conversions.ToBoolean(Operators.NotObject(Operators.OrObject(Operators.CompareObjectEqual(obj, 25, False), Operators.CompareObjectEqual(obj, 30, False)))) Then
						Dim msg As String = Me.sNonStandardSuckerRodLengthMsg
						Dim bDefaultYes As Boolean = False
						Dim flag11 As Boolean = False
						flag = Util.YesNo(msg, bDefaultYes, flag11)
					Else
						flag = True
					End If
				ElseIf Operators.CompareString(name, "StuffingBoxFriction", False) = 0 Then
					Dim flag12 As Boolean = False
					Dim obj19 As Object = flag12
					Dim lowerBound9 As Single = 0F
					Dim inclusive18 As Integer = -1
					Dim errnum18 As Integer = 75
					Dim useMetric18 As Integer = -1
					Dim canadianIsMetric18 As Integer = 0
					Dim bQuiet18 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj19, Util.CheckLower(obj, lowerBound9, inclusive18, errnum18, useMetric18, canadianIsMetric18, bQuiet18, text), False) Then
						Dim obj20 As Object = flag12
						Dim upperBound10 As Single = 2000F
						Dim inclusive19 As Integer = -1
						Dim errnum19 As Integer = 75
						Dim useMetric19 As Integer = -1
						Dim canadianIsMetric19 As Integer = 0
						Dim bQuiet19 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj20, Util.CheckUpper(obj, upperBound10, inclusive19, errnum19, useMetric19, canadianIsMetric19, bQuiet19, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "TubingPressure", False) = 0 Then
					Dim flag13 As Boolean = False
					Dim obj21 As Object = flag13
					Dim lowerBound10 As Single = 0F
					Dim inclusive20 As Integer = -1
					Dim errnum20 As Integer = 153
					Dim useMetric20 As Integer = 0
					Dim canadianIsMetric20 As Integer = 0
					Dim bQuiet20 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj21, Util.CheckLower(obj, lowerBound10, inclusive20, errnum20, useMetric20, canadianIsMetric20, bQuiet20, text), False) Then
						Dim obj22 As Object = flag13
						Dim upperBound11 As Single = 1000F
						Dim inclusive21 As Integer = -1
						Dim errnum21 As Integer = 151
						Dim useMetric21 As Integer = -1
						Dim canadianIsMetric21 As Integer = -1
						Dim bQuiet21 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj22, Util.CheckUpper(obj, upperBound11, inclusive21, errnum21, useMetric21, canadianIsMetric21, bQuiet21, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "WaterCut", False) = 0 Then
					Dim flag14 As Boolean = False
					Dim obj23 As Object = flag14
					Dim lowerBound11 As Single = 0F
					Dim inclusive22 As Integer = -1
					Dim errnum22 As Integer = 155
					Dim useMetric22 As Integer = 0
					Dim canadianIsMetric22 As Integer = 0
					Dim bQuiet22 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj23, Util.CheckLower(obj, lowerBound11, inclusive22, errnum22, useMetric22, canadianIsMetric22, bQuiet22, text), False) Then
						Dim obj24 As Object = flag14
						Dim upperBound12 As Single = 100F
						Dim inclusive23 As Integer = 0
						Dim errnum23 As Integer = 154
						Dim useMetric23 As Integer = 0
						Dim canadianIsMetric23 As Integer = 0
						Dim bQuiet23 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj24, Util.CheckUpper(obj, upperBound12, inclusive23, errnum23, useMetric23, canadianIsMetric23, bQuiet23, text), False) Then
							flag = True
						End If
					End If
				ElseIf Operators.CompareString(name, "WaterSPGR", False) = 0 Then
					Dim flag15 As Boolean = False
					Dim obj25 As Object = flag15
					Dim lowerBound12 As Single = 0.1F
					Dim inclusive24 As Integer = -1
					Dim errnum24 As Integer = 88
					Dim useMetric24 As Integer = 0
					Dim canadianIsMetric24 As Integer = 0
					Dim bQuiet24 As Boolean = False
					Dim text As String = ""
					If Not Operators.ConditionalCompareObjectEqual(obj25, Util.CheckLower(obj, lowerBound12, inclusive24, errnum24, useMetric24, canadianIsMetric24, bQuiet24, text), False) Then
						Dim obj26 As Object = flag15
						Dim upperBound13 As Single = 1.5F
						Dim inclusive25 As Integer = -1
						Dim errnum25 As Integer = 88
						Dim useMetric25 As Integer = 0
						Dim canadianIsMetric25 As Integer = 0
						Dim bQuiet25 As Boolean = False
						text = ""
						If Not Operators.ConditionalCompareObjectEqual(obj26, Util.CheckUpper(obj, upperBound13, inclusive25, errnum25, useMetric25, canadianIsMetric25, bQuiet25, text), False) Then
							flag = True
						End If
					End If
				Else
					flag = True
				End If
			End If
			If Not flag Then
				Me.txtDefault.Focus()
				Return
			End If
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.lstDefaultItems.Tag)) Then
				num = Conversions.ToInteger(Me.lstDefaultItems.Tag)
				Dim txtDefault As TextBox
				If Strings.InStr(Me.adiDefaults(num).Name, "DefaultFolder", CompareMethod.Binary) > 0 Then
					Dim array As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
					Dim num3 As Integer = num
					txtDefault = Me.txtDefault
					Dim text As String = txtDefault.Text
					Dim num4 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_FOLDER_DEFAULTS, array(num3).Name, text, RSWIN_DESC.sINIFile))
					txtDefault.Text = text
					Dim num5 As Long = num4
				ElseIf Operators.CompareString(Conversions.ToString(Me.adiDefaults(num).Type), "f", False) = 0 Then
					Dim array2 As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
					Dim num6 As Integer = num
					Dim text As String = Conversions.ToString(obj)
					Dim num7 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, array2(num6).Name, text, RSWIN_DESC.sINIFile))
					obj = text
					Dim num5 As Long = num7
					Me.adiDefaults(num).DefaultValue = RuntimeHelpers.GetObjectValue(obj)
				Else
					Dim array3 As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
					Dim num8 As Integer = num
					txtDefault = Me.txtDefault
					Dim text As String = txtDefault.Text
					Dim num9 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, array3(num8).Name, text, RSWIN_DESC.sINIFile))
					txtDefault.Text = text
					Dim num5 As Long = num9
				End If
				txtDefault = Me.txtDefault
				Dim lblDefaultType As Label = Me.lblDefaultType
				CtrlUI.TextBox_LostFocus(txtDefault, lblDefaultType, True)
				Me.lblDefaultType = lblDefaultType
				Me.txtDefault = txtDefault
			End If
		End Sub

		Private Sub CreateMyToolTip()
			Try
				Me.ToolTip1.AutoPopDelay = 2500
				Me.ToolTip1.InitialDelay = 500
				Me.ToolTip1.ReshowDelay = 250
				Me.ToolTip1.ShowAlways = True
				Me.ToolTip1.SetToolTip(Me.cmdNewCustomRG, "Add")
				Me.ToolTip1.SetToolTip(Me.cmdModifyCustomRG, "Modify")
				Me.ToolTip1.SetToolTip(Me.cmdDeleteCustomRG, "Delete")
				Me.ToolTip1.SetToolTip(Me.cmdNewCustomPU, "Add")
				Me.ToolTip1.SetToolTip(Me.cmdModifyCustomPU, "Modify")
				Me.ToolTip1.SetToolTip(Me.cmdDeleteCustomPU, "Delete")
				Me.ToolTip1.SetToolTip(Me.btnNewSS, "Add")
				Me.ToolTip1.SetToolTip(Me.btnModifySS, "Modify")
				Me.ToolTip1.SetToolTip(Me.btnDeleteSS, "Delete")
				Me.ToolTip1.SetToolTip(Me.cmdResetFrictions, "Reset Drag Friction Coeffiecients and Side Loads per Guide to Manufacturer Recommended Defaults")
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ChangesDebugOptions()
			RSWIN_DESC.DEBUG_PlotAllDownholeCards = Conversions.ToBoolean(Interaction.IIf(RSWIN_DESC.DEBUG_AllowDebugging, Me.chkPlotAllDownholeCards.Checked, False))
		End Sub

		Private Sub lstWK1Formats_SelectedIndexChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub TextBox_Change(ByRef txt As TextBox, ByRef lbl As Label)
			If Me.ActiveControl IsNot txt Then
				CtrlUI.TextBox_LostFocus(txt, lbl, True)
				Return
			End If
		End Sub

		Private Sub txtDefault_TextChanged(sender As Object, e As EventArgs)
			Dim txtDefault As TextBox = Me.txtDefault
			Dim lblDefaultType As Label = Me.lblDefaultType
			Me.TextBox_Change(txtDefault, lblDefaultType)
			Me.lblDefaultType = lblDefaultType
			Me.txtDefault = txtDefault
		End Sub

		Private Sub txtDefault_Enter(sender As Object, e As EventArgs)
			Dim txtDefault As TextBox = Me.txtDefault
			CtrlUI.TextBox_GotFocus(txtDefault)
			Me.txtDefault = txtDefault
		End Sub

		Private Sub chkCreateWK1_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.chkViewWK1.Enabled = (Me.chkCreateWK1.Checked And RSWIN_DESC.SETUP_ExcelInstalled)
		End Sub

		Private Sub chkAzDirToolbar_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR = If((-If((Me.chkAzDirToolbar.Checked > False), 1S, 0S)), 1S, 0S)
		End Sub

		Private Sub chkOptimizeSurvey_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			RSWIN_DESC.SETUP_OPTIMIZESURVEY = If((-If((Me.chkOptimizeSurvey.Checked > False), 1S, 0S)), 1S, 0S)
			Dim text As String = "OptimizeSurvey"
			Dim text2 As String = Convert.ToString(RSWIN_DESC.SETUP_OPTIMIZESURVEY)
			Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
		End Sub

		Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Dim flag As Boolean = False
			Dim num As Integer = 0
			Do
				Select Case num
					Case 0
						Me.optNcycles_0.Enabled = Me.chkDebugSetNcycles.Checked
						If Me.optNcycles_0.Checked Then
							flag = True
						End If
					Case 1
						Me.optNcycles_1.Enabled = Me.chkDebugSetNcycles.Checked
						If Me.optNcycles_1.Checked Then
							flag = True
						End If
					Case 2
						Me.optNcycles_2.Enabled = Me.chkDebugSetNcycles.Checked
						If Me.optNcycles_2.Checked Then
							flag = True
						End If
					Case 3
						Me.optNcycles_3.Enabled = Me.chkDebugSetNcycles.Checked
						If Me.optNcycles_3.Checked Then
							flag = True
						End If
				End Select
				num += 1
			Loop While num <= 3
			If Me.chkDebugSetNcycles.Checked And Not flag Then
				Me.optNcycles_2.Checked = True
			End If
		End Sub

		Private Sub txtMaxSteelLoading_TextChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtMaxFGLoading_Enter(sender As Object, e As EventArgs)
			Dim txtMaxFGLoading As TextBox = Me.txtMaxFGLoading
			CtrlUI.TextBox_GotFocus(txtMaxFGLoading)
			Me.txtMaxFGLoading = txtMaxFGLoading
		End Sub

		Private Sub txtMaxFGLoading_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtMaxFGLoading, True, False, obj) Then
				Return
			End If
			Dim obj2 As Object = flag
			Dim lowerBound As Single = 50F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 113
			Dim useMetric As Integer = 0
			Dim canadianIsMetric As Integer = 0
			Dim bQuiet As Boolean = False
			Dim text As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Me.txtMaxFGLoading.Focus()
				Return
			End If
			Dim obj3 As Object = flag
			Dim upperBound As Single = 100F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = 112
			Dim useMetric2 As Integer = 0
			Dim canadianIsMetric2 As Integer = 0
			Dim bQuiet2 As Boolean = False
			text = ""
			If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
				Me.txtMaxFGLoading.Focus()
				Return
			End If
			Dim txtMaxFGLoading As TextBox = Me.txtMaxFGLoading
			Dim lblMaxFGLoading As Label = Me.lblMaxFGLoading
			CtrlUI.TextBox_LostFocus(txtMaxFGLoading, lblMaxFGLoading, True)
			Me.lblMaxFGLoading = lblMaxFGLoading
			Me.txtMaxFGLoading = txtMaxFGLoading
		End Sub

		Private Sub txtMaxSteelLoading_Enter(sender As Object, e As EventArgs)
			Dim txtMaxSteelLoading As TextBox = Me.txtMaxSteelLoading
			CtrlUI.TextBox_GotFocus(txtMaxSteelLoading)
			Me.txtMaxSteelLoading = txtMaxSteelLoading
		End Sub

		Private Sub txtMaxSteelLoading_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtMaxSteelLoading, True, False, obj) Then
				Return
			End If
			Dim obj2 As Object = flag
			Dim lowerBound As Single = 50F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 113
			Dim useMetric As Integer = 0
			Dim canadianIsMetric As Integer = 0
			Dim bQuiet As Boolean = False
			Dim text As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Me.txtMaxSteelLoading.Focus()
				Return
			End If
			Dim obj3 As Object = flag
			Dim upperBound As Single = 100F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = 112
			Dim useMetric2 As Integer = 0
			Dim canadianIsMetric2 As Integer = 0
			Dim bQuiet2 As Boolean = False
			text = ""
			If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
				Me.txtMaxSteelLoading.Focus()
				Return
			End If
			Dim txtMaxSteelLoading As TextBox = Me.txtMaxSteelLoading
			Dim lblMaxSteelLoading As Label = Me.lblMaxSteelLoading
			CtrlUI.TextBox_LostFocus(txtMaxSteelLoading, lblMaxSteelLoading, True)
			Me.lblMaxSteelLoading = lblMaxSteelLoading
			Me.txtMaxSteelLoading = txtMaxSteelLoading
		End Sub

		Private Sub _optCostCategory_0_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me._optCostCategory_0.Checked Then
				Me._panCostCategory_0.Visible = True
				Me._panCostCategory_1.Visible = False
				Me.pnlRSCostDB.Visible = False
				Me.pnlGuideCostDB.Visible = False
				Me.pnlPUCostDB.Visible = True
			End If
		End Sub

		Private Sub _optCostCategory_1_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me._optCostCategory_1.Checked Then
				Me._panCostCategory_1.Visible = True
				Me._panCostCategory_0.Visible = False
				Me.pnlRSCostDB.Visible = True
				Me.pnlPUCostDB.Visible = False
				Me.pnlGuideCostDB.Visible = False
			End If
		End Sub

		Private Sub _optCostCategory_2_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me._optCostCategory_2.Checked Then
				Me._panCostCategory_1.Visible = False
				Me._panCostCategory_0.Visible = False
				Me.pnlRSCostDB.Visible = False
				Me.pnlPUCostDB.Visible = False
				Me.pnlGuideCostDB.Visible = True
				Me.CostDBMakeGuideGrid()
				Return
			End If
		End Sub

		Private Sub ulgPUCostDB_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs)
			Try
				Dim layout As UltraGridLayout = e.Layout
				layout.TabNavigation = TabNavigation.NextCell
				Dim ultraGridBand As UltraGridBand = layout.Bands(0)
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns("DBKey")
				ultraGridColumn.Header.Caption = ""
				ultraGridColumn.Width = 1
				ultraGridColumn.Hidden = True
				Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns("Label")
				ultraGridColumn2.Header.Caption = "Pumping Unit"
				ultraGridColumn2.Width = 135
				ultraGridColumn2.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn2.CellAppearance.BackColor = Color.LightGray
				Dim ultraGridColumn3 As UltraGridColumn = ultraGridBand.Columns("Value")
				ultraGridColumn3.Header.Caption = "$"
				ultraGridColumn3.Width = 90
				ultraGridColumn3.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn4 As UltraGridColumn = ultraGridBand.Columns("APIDesc")
				ultraGridColumn4.Header.Caption = ""
				ultraGridColumn4.Width = 1
				ultraGridColumn4.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn4.Hidden = True
				Dim ultraGridColumn5 As UltraGridColumn = ultraGridBand.Columns("ExtraInfo")
				ultraGridColumn5.Header.Caption = ""
				ultraGridColumn5.Width = 1
				ultraGridColumn5.Hidden = True
				Dim ulgPUCostDB As UltraGrid = Me.ulgPUCostDB
				ulgPUCostDB.ActiveRow = ulgPUCostDB.GetRow(ChildRow.First)
				ulgPUCostDB.DisplayLayout.TabNavigation = TabNavigation.NextCell
				Dim override As UltraGridOverride = ulgPUCostDB.DisplayLayout.Override
				override.AllowColMoving = AllowColMoving.NotAllowed
				override.AllowColSizing = AllowColSizing.None
				override.AllowColSwapping = AllowColSwapping.NotAllowed
				override.BorderStyleCell = UIElementBorderStyle.InsetSoft
				override.BorderStyleRow = UIElementBorderStyle.RaisedSoft
				override.RowSelectors = DefaultableBoolean.[False]
				override.RowSizing = RowSizing.Fixed
				override.SelectTypeCell = SelectType.[Single]
				override.SelectTypeCol = SelectType.None
				override.SelectTypeRow = SelectType.[Single]
				override.ActiveRowAppearance.BorderColor = SystemColors.Highlight
				override.ActiveRowAppearance.BorderColor3DBase = SystemColors.Highlight
			Catch ex As Exception
				MessageBox.Show("Error in ultPUCostDB InitLayout: " + ex.Message)
			End Try
		End Sub

		Private Sub ulgRSCostDB_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs)
			Try
				Dim layout As UltraGridLayout = e.Layout
				layout.TabNavigation = TabNavigation.NextCell
				Dim ultraGridBand As UltraGridBand = layout.Bands(0)
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns("DBKey")
				ultraGridColumn.Header.Caption = ""
				ultraGridColumn.Width = 1
				ultraGridColumn.Hidden = True
				Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns("Label")
				ultraGridColumn2.Header.Caption = "Diameter"
				ultraGridColumn2.Width = 125
				ultraGridColumn2.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn2.CellAppearance.BackColor = Color.LightGray
				Dim ultraGridColumn3 As UltraGridColumn = ultraGridBand.Columns("Value")
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					ultraGridColumn3.Header.Caption = "$/ft"
				Else
					ultraGridColumn3.Header.Caption = "$/m"
				End If
				ultraGridColumn3.Width = 80
				ultraGridColumn3.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn4 As UltraGridColumn = ultraGridBand.Columns("ExtraInfo")
				ultraGridColumn4.Header.Caption = ""
				ultraGridColumn4.Width = 1
				ultraGridColumn4.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn4.Hidden = True
				Dim ulgRSCostDB As UltraGrid = Me.ulgRSCostDB
				ulgRSCostDB.ActiveRow = ulgRSCostDB.GetRow(ChildRow.First)
				ulgRSCostDB.DisplayLayout.TabNavigation = TabNavigation.NextCell
				Dim override As UltraGridOverride = ulgRSCostDB.DisplayLayout.Override
				override.AllowColMoving = AllowColMoving.NotAllowed
				override.AllowColSizing = AllowColSizing.None
				override.AllowColSwapping = AllowColSwapping.NotAllowed
				override.BorderStyleCell = UIElementBorderStyle.InsetSoft
				override.BorderStyleRow = UIElementBorderStyle.RaisedSoft
				override.RowSelectors = DefaultableBoolean.[False]
				override.RowSizing = RowSizing.Fixed
				override.SelectTypeCell = SelectType.[Single]
				override.SelectTypeCol = SelectType.None
				override.SelectTypeRow = SelectType.[Single]
				override.ActiveRowAppearance.BorderColor = Color.DarkGray
				override.ActiveRowAppearance.BorderColor3DBase = Color.DarkGray
			Catch ex As Exception
				MessageBox.Show("Error in ulgRSCostDB InitLayout: " + ex.Message)
			End Try
		End Sub

		Private Sub ulgGuideCostDB_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs)
			Try
				Dim layout As UltraGridLayout = e.Layout
				layout.TabNavigation = TabNavigation.NextCell
				Dim ultraGridBand As UltraGridBand = layout.Bands(0)
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns("DBKey")
				ultraGridColumn.Header.Caption = ""
				ultraGridColumn.Width = 1
				ultraGridColumn.Hidden = True
				Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns("Label")
				ultraGridColumn2.Header.Caption = "Guide"
				ultraGridColumn2.Width = 165
				ultraGridColumn2.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn2.CellAppearance.BackColor = Color.LightGray
				Dim ultraGridColumn3 As UltraGridColumn = ultraGridBand.Columns("Value")
				ultraGridColumn3.Header.Caption = "$/guide"
				ultraGridColumn3.Width = 80
				ultraGridColumn3.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn4 As UltraGridColumn = ultraGridBand.Columns("ExtraInfo")
				ultraGridColumn4.Header.Caption = ""
				ultraGridColumn4.Width = 1
				ultraGridColumn4.Hidden = True
				Dim ulgGuideCostDB As UltraGrid = Me.ulgGuideCostDB
				ulgGuideCostDB.ActiveRow = ulgGuideCostDB.GetRow(ChildRow.First)
				ulgGuideCostDB.DisplayLayout.TabNavigation = TabNavigation.NextCell
				Dim override As UltraGridOverride = ulgGuideCostDB.DisplayLayout.Override
				override.AllowColMoving = AllowColMoving.NotAllowed
				override.AllowColSizing = AllowColSizing.None
				override.AllowColSwapping = AllowColSwapping.NotAllowed
				override.BorderStyleCell = UIElementBorderStyle.InsetSoft
				override.BorderStyleRow = UIElementBorderStyle.RaisedSoft
				override.RowSelectors = DefaultableBoolean.[False]
				override.RowSizing = RowSizing.Fixed
				override.SelectTypeCell = SelectType.[Single]
				override.SelectTypeCol = SelectType.None
				override.SelectTypeRow = SelectType.[Single]
				override.ActiveRowAppearance.BorderColor = Color.DarkGray
				override.ActiveRowAppearance.BorderColor3DBase = Color.DarkGray
			Catch ex As Exception
				MessageBox.Show("Error in ulgGuideCostDB InitLayout: " + ex.Message)
			End Try
		End Sub

		Private Sub cmdRSLoadCostDB_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			Application.DoEvents()
			Application.DoEvents()
			If Me.cboRodGrade.SelectedIndex < 0 Then
				Me.pnlRSCostDB.Visible = False
			Else
				Dim obj As Object = Me.cboRodGrade.SelectedIndex
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboRodGrade.Items(Conversions.ToInteger(obj)), Nothing, "RodGradeId", New Object(-1) {}, Nothing, Nothing, Nothing))
				Dim listBoxItem As ListBoxItem = CType(Me.cboRodGrade.SelectedItem, ListBoxItem)
				Dim itemString As String = listBoxItem.ItemString
				Dim iGrade As Short = Conversions.ToShort(objectValue)
				Dim sRodType As String = itemString
				Dim obj2 As Object
				Dim num As Short = Conversions.ToShort(obj2)
				Dim array As String()
				Dim array2 As String()
				COSTDB.CostDBGetDiameterList(iGrade, sRodType, array, array2, num)
				obj2 = num
				Dim array3 As String() = New String(Conversions.ToInteger(obj2) + 1 - 1) {}
				Me.pnlRSCostDB.Visible = False
				Me.InitRSDataset(Me.mdsRSCostDB)
				Dim iType As Integer = 1
				Dim ulgRSCostDB As UltraGrid = Me.ulgRSCostDB
				Dim nItems As Short = Conversions.ToShort(obj2)
				Dim array5 As Object()
				Dim array4 As String() = CType(array5, String())
				COSTDB.CostDBLoadGrid(iType, Me.mdsRSCostDB, ulgRSCostDB, nItems, array, array2, array4, array3)
				array5 = array4
				Me.ulgRSCostDB = ulgRSCostDB
				ulgRSCostDB = Me.ulgRSCostDB
				COSTDB.CostDBShowGrid(ulgRSCostDB)
				Me.ulgRSCostDB = ulgRSCostDB
				Me.pnlRSCostDB.Visible = True
				Me.pnlRSCostDB.Enabled = True
				Me.ulgRSCostDB.Visible = True
				Me.ulgRSCostDB.Enabled = True
			End If
			Application.DoEvents()
			Application.DoEvents()
		End Sub

		Private Sub cmdPULoadCostDB_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			If Me.cboPUManuf.SelectedIndex < 0 Then
				Me.pnlPUCostDB.Visible = False
			Else
				Util.BusyCursor()
				Dim listBoxItem As ListBoxItem = CType(Me.cboPUManuf.SelectedItem, ListBoxItem)
				Dim array As String()
				Dim array2 As String()
				Dim array3 As String()
				Dim array4 As String()
				Dim array5 As String()
				Dim nItems As Short
				COSTDB.CostDBGetPUList(CShort(listBoxItem.ItemData), array, array2, array3, array4, array5, nItems)
				Me.InitPUDataset(Me.mdsPUCostDB)
				Dim iType As Integer = 0
				Dim ulgPUCostDB As UltraGrid = Me.ulgPUCostDB
				Dim array6 As String()
				COSTDB.CostDBLoadGrid(iType, Me.mdsPUCostDB, ulgPUCostDB, nItems, array, array2, array6, array3)
				Me.ulgPUCostDB = ulgPUCostDB
				Me.pnlPUCostDB.Visible = False
				ulgPUCostDB = Me.ulgPUCostDB
				COSTDB.CostDBShowGrid(ulgPUCostDB)
				Me.ulgPUCostDB = ulgPUCostDB
				Me.pnlPUCostDB.Visible = True
				Me.pnlPUCostDB.Enabled = True
				Me.ulgPUCostDB.Visible = True
				Me.ulgPUCostDB.Enabled = True
				Util.UnbusyCursor()
			End If
		End Sub

		Public Sub CostDBMakeRSGrid()
			Me.cmdRSLoadCostDB.Enabled = True
			If Me.cboRodGrade.SelectedIndex < 0 Then
				Me.pnlRSCostDB.Visible = False
				Return
			End If
			Dim obj As Object = Me.cboRodGrade.SelectedIndex
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboRodGrade.Items(Conversions.ToInteger(obj)), Nothing, "RodGradeId", New Object(-1) {}, Nothing, Nothing, Nothing))
			Dim text As String = Conversions.ToString(NewLateBinding.LateGet(Me.cboRodGrade.Items(Conversions.ToInteger(obj)), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing))
			Dim iGrade As Short = Conversions.ToShort(objectValue)
			Dim sRodType As String = text
			Dim obj2 As Object
			Dim num As Short = Conversions.ToShort(obj2)
			Dim array As String()
			Dim array2 As String()
			COSTDB.CostDBGetDiameterList(iGrade, sRodType, array, array2, num)
			obj2 = num
			Dim array3 As String() = New String(Conversions.ToInteger(obj2) + 1 - 1) {}
			Me.pnlRSCostDB.Visible = False
			Me.InitRSDataset(Me.mdsRSCostDB)
			Dim iType As Integer = 1
			Dim ulgRSCostDB As UltraGrid = Me.ulgRSCostDB
			Dim array4 As String()
			COSTDB.CostDBLoadGrid(iType, Me.mdsRSCostDB, ulgRSCostDB, Conversions.ToShort(obj2), array, array2, array4, array3)
			Me.ulgRSCostDB = ulgRSCostDB
			ulgRSCostDB = Me.ulgRSCostDB
			COSTDB.CostDBShowGrid(ulgRSCostDB)
			Me.ulgRSCostDB = ulgRSCostDB
			Me.pnlRSCostDB.Visible = True
		End Sub

		Public Sub CostDBMakeGuideGrid()
			Try
				Dim array As String() = New String(12) {}
				Dim array2 As String() = New String(12) {}
				Dim array3 As String() = New String(12) {}
				Dim array4 As String() = New String(12) {}
				COSTDB.CostDBGetGuideList(array, array2, RSWIN_DESC.nItems)
				Me.InitGuideDataset(Me.mdsGuideCostDB)
				Dim iType As Integer = 1
				Dim ulgGuideCostDB As UltraGrid = Me.ulgGuideCostDB
				COSTDB.CostDBLoadGrid(iType, Me.mdsGuideCostDB, ulgGuideCostDB, RSWIN_DESC.nItems, array, array2, array4, array3)
				Me.ulgGuideCostDB = ulgGuideCostDB
				ulgGuideCostDB = Me.ulgGuideCostDB
				COSTDB.CostDBShowGrid(ulgGuideCostDB)
				Me.ulgGuideCostDB = ulgGuideCostDB
				Me.pnlGuideCostDB.Visible = True
				Me.pnlGuideCostDB.Enabled = True
				Me.ulgGuideCostDB.Visible = True
				Me.ulgGuideCostDB.Enabled = True
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboPUManuf_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.cmdPULoadCostDB.Enabled = True
			Application.DoEvents()
			Application.DoEvents()
			If Me.cboPUManuf.SelectedIndex < 0 Then
				Me.pnlPUCostDB.Visible = False
			Else
				Util.BusyCursor()
				Dim listBoxItem As ListBoxItem = CType(Me.cboPUManuf.SelectedItem, ListBoxItem)
				Dim array As String()
				Dim array2 As String()
				Dim array3 As String()
				Dim array4 As String()
				Dim array5 As String()
				Dim nItems As Short
				COSTDB.CostDBGetPUList(CShort(listBoxItem.ItemData), array, array2, array3, array4, array5, nItems)
				Me.InitPUDataset(Me.mdsPUCostDB)
				Dim iType As Integer = 0
				Dim ulgPUCostDB As UltraGrid = Me.ulgPUCostDB
				COSTDB.CostDBLoadGrid(iType, Me.mdsPUCostDB, ulgPUCostDB, nItems, array, array2, array3, array5)
				Me.ulgPUCostDB = ulgPUCostDB
				Me.pnlPUCostDB.Visible = False
				ulgPUCostDB = Me.ulgPUCostDB
				COSTDB.CostDBShowGrid(ulgPUCostDB)
				Me.ulgPUCostDB = ulgPUCostDB
				Me.pnlPUCostDB.Visible = True
				Util.UnbusyCursor()
			End If
			Application.DoEvents()
			Application.DoEvents()
		End Sub

		Private Sub cboRodGrade_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.cboRodGrade.SelectedIndex < 0 Then
				Me.cboRodGrade.Visible = False
				Me.pnlRSCostDB.Visible = False
				Return
			End If
			Me.CostDBMakeRSGrid()
			Application.DoEvents()
		End Sub

		Private Sub cboRodType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try
				If Me.cboRodType.SelectedIndex >= 0 Then
					Me.cboRodGrade.SelectedIndex = -1
					Dim num As Integer = -1
					Select Case Me.cboRodType.SelectedIndex
						Case 0
							num = 1
						Case 1
							num = 2
						Case 2
							num = 3
						Case 3
							num = 6
						Case 4
							num = 4
						Case 5
							num = 5
					End Select
					If num <> -1 Then
						Dim cboRodGrade As ComboBox = Me.cboRodGrade
						RODUTIL.LoadRodGradeList(cboRodGrade, num, Me.RodGrade_AL, True, False, False, False, False, False, False)
						Me.cboRodGrade = cboRodGrade
						Try
							cboRodGrade = Me.cboRodGrade
							Me.LoadCustomToRodGradeListToCombo(cboRodGrade, num, Me.RodGrade_AL, False, True)
							Me.cboRodGrade = cboRodGrade
						Catch ex As Exception
							cboRodGrade = Me.cboRodGrade
							Me.LoadCustomToRodGradeListToCombo(cboRodGrade, num, Me.RodGrade_AL, False, True)
							Me.cboRodGrade = cboRodGrade
						End Try
						Me.cboRodGrade.Enabled = True
						Me.cboRodGrade.Visible = True
					End If
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub InitPUDataset(ByRef mdsPU As DataSet)
			mdsPU = New DataSet("PUCostDataset")
			Dim dataTable As DataTable = New DataTable("PumpingUnit")
			Dim dataColumn As DataColumn = New DataColumn("DBKey", GetType(String))
			dataColumn.Unique = False
			dataColumn.AllowDBNull = False
			dataTable.Columns.Add(dataColumn)
			Dim dataColumn2 As DataColumn = New DataColumn("Label", GetType(String))
			dataColumn2.Unique = False
			dataColumn2.AllowDBNull = True
			dataTable.Columns.Add(dataColumn2)
			Dim dataColumn3 As DataColumn = New DataColumn("Value", GetType(String))
			dataColumn3.AllowDBNull = True
			dataTable.Columns.Add(dataColumn3)
			Dim dataColumn4 As DataColumn = New DataColumn("APIDesc", GetType(String))
			dataColumn4.Unique = False
			dataColumn4.AllowDBNull = True
			dataTable.Columns.Add(dataColumn4)
			Dim dataColumn5 As DataColumn = New DataColumn("ExtraInfo", GetType(String))
			dataColumn5.Unique = False
			dataColumn5.AllowDBNull = True
			dataTable.Columns.Add(dataColumn5)
			mdsPU.Tables.Add(dataTable)
			mdsPU.Tables(0).Clear()
		End Sub

		Public Sub InitRSDataset(ByRef mdsRS As DataSet)
			mdsRS = New DataSet("RSCostDataset")
			Dim dataTable As DataTable = New DataTable("RodString")
			Dim dataColumn As DataColumn = New DataColumn("DBKey", GetType(String))
			dataColumn.Unique = False
			dataColumn.AllowDBNull = False
			dataTable.Columns.Add(dataColumn)
			Dim dataColumn2 As DataColumn = New DataColumn("Label", GetType(String))
			dataColumn2.Unique = False
			dataColumn2.AllowDBNull = True
			dataTable.Columns.Add(dataColumn2)
			Dim dataColumn3 As DataColumn = New DataColumn("Value", GetType(String))
			dataColumn3.AllowDBNull = True
			dataTable.Columns.Add(dataColumn3)
			Dim dataColumn4 As DataColumn = New DataColumn("ExtraInfo", GetType(String))
			dataColumn4.Unique = False
			dataColumn4.AllowDBNull = True
			dataTable.Columns.Add(dataColumn4)
			mdsRS.Tables.Add(dataTable)
			mdsRS.Tables(0).Clear()
		End Sub

		Public Sub InitGuideDataset(ByRef mdsGuide As DataSet)
			mdsGuide = New DataSet("GuideCostDataset")
			Dim dataTable As DataTable = New DataTable("Guide")
			Dim dataColumn As DataColumn = New DataColumn("DBKey", GetType(String))
			dataColumn.Unique = False
			dataColumn.AllowDBNull = False
			dataTable.Columns.Add(dataColumn)
			Dim dataColumn2 As DataColumn = New DataColumn("Label", GetType(String))
			dataColumn2.Unique = False
			dataColumn2.AllowDBNull = True
			dataTable.Columns.Add(dataColumn2)
			Dim dataColumn3 As DataColumn = New DataColumn("Value", GetType(String))
			dataColumn3.AllowDBNull = True
			dataTable.Columns.Add(dataColumn3)
			Dim dataColumn4 As DataColumn = New DataColumn("ExtraInfo", GetType(String))
			dataColumn4.Unique = False
			dataColumn4.AllowDBNull = True
			dataTable.Columns.Add(dataColumn4)
			mdsGuide.Tables.Add(dataTable)
			mdsGuide.Tables(0).Clear()
		End Sub

		Private Sub ulgPUCostDB_AfterRowActivate(sender As Object, e As EventArgs)
			Dim activeRow As UltraGridRow = Me.ulgPUCostDB.ActiveRow
			If activeRow IsNot Nothing Then
				Me.lblUnitName.Text = Conversions.ToString(activeRow.Cells("Label").Value)
				Me.lblAPIDesignation.Text = Conversions.ToString(activeRow.Cells("APIDesc").Value)
				Me.lblOtherInfo.Text = Conversions.ToString(activeRow.Cells("ExtraInfo").Value)
			End If
		End Sub

		Private Sub ulgPUCostDB_AfterCellActivate(sender As Object, e As EventArgs)
			Dim activeRow As UltraGridRow = Me.ulgPUCostDB.ActiveRow
			If activeRow IsNot Nothing Then
				Me.lblUnitName.Text = Conversions.ToString(activeRow.Cells("Label").Value)
				Me.lblAPIDesignation.Text = Conversions.ToString(activeRow.Cells("APIDesc").Value)
				Me.lblOtherInfo.Text = Conversions.ToString(activeRow.Cells("ExtraInfo").Value)
			End If
		End Sub

		Public Function SetChkReportOpt(Index As Integer, bVal As Boolean) As Boolean
			Select Case Index
				Case -1
					Me.chkReportOpt_.Checked = bVal
				Case 0
					Me.chkReportOpt_0.Checked = bVal
				Case 1
					Me.chkReportOpt_1.Checked = bVal
				Case 2
					Me.chkReportOpt_2.Checked = bVal
				Case 3
					Me.chkReportOpt_3.Checked = bVal
				Case 4
					Me.chkReportOpt_4.Checked = bVal
				Case 5
					Me.chkReportOpt_5.Checked = bVal
				Case 6
					Me.chkReportOpt_6.Checked = bVal
				Case 7
					Me.chkReportOpt_7.Checked = bVal
				Case 8
					Me.chkReportOpt_8.Checked = bVal
				Case 9
					Me.chkReportOpt_9.Checked = bVal
				Case 10
					Me.chkReportOpt_10.Checked = bVal
			End Select
			Dim result As Boolean
			Return result
		End Function

		Public Function GetChkReportOpt(Index As Integer) As Boolean
			Select Case Index
				Case -1
					Return Me.chkReportOpt_.Checked
				Case 0
					Return Me.chkReportOpt_0.Checked
				Case 1
					Return Me.chkReportOpt_1.Checked
				Case 2
					Return Me.chkReportOpt_2.Checked
				Case 3
					Return Me.chkReportOpt_3.Checked
				Case 4
					Return Me.chkReportOpt_4.Checked
				Case 5
					Return Me.chkReportOpt_5.Checked
				Case 6
					Return Me.chkReportOpt_6.Checked
				Case 7
					Return Me.chkReportOpt_7.Checked
				Case 8
					Return Me.chkReportOpt_8.Checked
				Case 9
					Return Me.chkReportOpt_9.Checked
				Case 10
					Return Me.chkReportOpt_10.Checked
				Case Else
					Dim result As Boolean
					Return result
			End Select
		End Function

		Public Sub SetChkReportOptEnabled(Index As Integer, Value As Boolean)
			Select Case Index
				Case -1
					Me.chkReportOpt_.Enabled = Value
					Return
				Case 0
					Me.chkReportOpt_0.Enabled = Value
					Return
				Case 1
					Me.chkReportOpt_1.Enabled = Value
					Return
				Case 2
					Me.chkReportOpt_2.Enabled = Value
					Return
				Case 3
					Me.chkReportOpt_3.Enabled = Value
					Return
				Case 4
					Me.chkReportOpt_4.Enabled = Value
					Return
				Case 5
					Me.chkReportOpt_5.Enabled = Value
					Return
				Case 6
					Me.chkReportOpt_6.Enabled = Value
					Return
				Case 7
					Me.chkReportOpt_7.Enabled = Value
					Return
				Case 8
					Me.chkReportOpt_8.Enabled = Value
					Return
				Case 9
					Me.chkReportOpt_9.Enabled = Value
					Return
				Case 10
					Me.chkReportOpt_10.Enabled = Value
					Return
				Case Else
					Return
			End Select
		End Sub

		Public Function GetChkReportOptEnabled(Index As Integer) As Boolean
			Select Case Index
				Case -1
					Return Me.chkReportOpt_.Enabled
				Case 0
					Return Me.chkReportOpt_0.Enabled
				Case 1
					Return Me.chkReportOpt_1.Enabled
				Case 2
					Return Me.chkReportOpt_2.Enabled
				Case 3
					Return Me.chkReportOpt_3.Enabled
				Case 4
					Return Me.chkReportOpt_4.Enabled
				Case 5
					Return Me.chkReportOpt_5.Enabled
				Case 6
					Return Me.chkReportOpt_6.Enabled
				Case 7
					Return Me.chkReportOpt_7.Enabled
				Case 8
					Return Me.chkReportOpt_8.Enabled
				Case 9
					Return Me.chkReportOpt_9.Enabled
				Case 10
					Return Me.chkReportOpt_10.Enabled
				Case Else
					Dim result As Boolean
					Return result
			End Select
		End Function

		Public Function GetChkReportOptVisible(Index As Integer) As Boolean
			Select Case Index
				Case -1
					Return Me.chkReportOpt_.Visible
				Case 0
					Return Me.chkReportOpt_0.Visible
				Case 1
					Return Me.chkReportOpt_1.Visible
				Case 2
					Return Me.chkReportOpt_2.Visible
				Case 3
					Return Me.chkReportOpt_3.Visible
				Case 4
					Return Me.chkReportOpt_4.Visible
				Case 5
					Return Me.chkReportOpt_5.Visible
				Case 6
					Return Me.chkReportOpt_6.Visible
				Case 7
					Return Me.chkReportOpt_7.Visible
				Case 8
					Return Me.chkReportOpt_8.Visible
				Case 9
					Return Me.chkReportOpt_9.Visible
				Case 10
					Return Me.chkReportOpt_10.Visible
				Case Else
					Dim result As Boolean
					Return result
			End Select
		End Function

		Private Sub ulgRSCostDB_AfterCellUpdate(sender As Object, e As CellEventArgs)
			Try
				Me.m_bInAfterCellUpdate = True
				If Not Me.m_bInAfterEnterEdit Then
					Me.bPUCostDB_Changed = True
					COSTDB.DBInsert(Conversions.ToString(e.Cell.Row.Cells("DBKey").Value), Conversions.ToString(e.Cell.Row.Cells("Value").Value))
				End If
			Catch ex As Exception
			End Try
			Me.m_bInAfterCellUpdate = False
		End Sub

		Private Sub ulgGuideCostDB_AfterCellUpdate(sender As Object, e As CellEventArgs)
			Try
				Me.m_bInAfterCellUpdate = True
				If Not Me.m_bInAfterEnterEdit Then
					Me.bGuideCostDB_Changed = True
					COSTDB.DBInsert(Conversions.ToString(e.Cell.Row.Cells("DBKey").Value), Conversions.ToString(e.Cell.Row.Cells("Value").Value))
				End If
			Catch ex As Exception
			End Try
			Me.m_bInAfterCellUpdate = False
		End Sub

		Private Sub ulgPUCostDB_AfterCellUpdate(sender As Object, e As CellEventArgs)
			Try
				Me.m_bInAfterCellUpdate = True
				If Not Me.m_bInAfterEnterEdit Then
					Me.bPUCostDB_Changed = True
					COSTDB.DBInsert(Conversions.ToString(e.Cell.Row.Cells("DBKey").Value), Conversions.ToString(e.Cell.Row.Cells("Value").Value))
				End If
			Catch ex As Exception
			End Try
			Me.m_bInAfterCellUpdate = False
		End Sub

		Private Sub chkReportOpt_4_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(4, Me.chkReportOpt_4.Checked, True)
		End Sub

		Private Sub chkReportOpt_5_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(5, Me.chkReportOpt_5.Checked, True)
		End Sub

		Private Sub chkReportOpt_8_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(8, Me.chkReportOpt_8.Checked, True)
		End Sub

		Private Sub chkReportOpt_9_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(9, Me.chkReportOpt_9.Checked, True)
		End Sub

		Private Sub RswinSetup_Enter(sender As Object, e As EventArgs)
			Try
				RSWIN_DESC.frmMain.RemoveChildForm("Results", False)
				RSWIN_DESC.frmMain.ToolbarButtonSetState2(2, False)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub optMolded_CheckedChanged(sender As Object, e As EventArgs)
			If Me.optMolded.Checked Then
				RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.MOLDED)
				Dim text As String = "GuideToUse"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_GuideToUse)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(text2)
				Me.SetDefaultSideloadLimit()
				Me.cboSidewinder.Enabled = False
				If Me.ActiveControl Is Me.optMolded Then
					Me.CheckMinMaxNumberOfGuides()
				End If
			End If
			Me.txtMoldedLoad.Visible = Me.optMolded.Checked
			Me.txtMoldedLoad.Enabled = Me.optMolded.Checked
			Me.txtMoldedFricCoeff.Visible = Me.optMolded.Checked
			If Me.optMolded.Checked Then
				Me.lblFricCoeff.Left = 350
				Me.lblSideLoadperRodGuide.Top = Me.optMolded.Top - Me.lblSideLoadperRodGuide.Height
				Me.lblFricCoeff.Top = Me.lblSideLoadperRodGuide.Top
				Me.cmdResetFrictions.Top = Me.lblFricCoeff.Top
				Me.lblSideLoadperRodGuide.Visible = True
				Me.lblFricCoeff.Visible = True
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub optWheel_CheckedChanged(sender As Object, e As EventArgs)
			If Me.optWheel.Checked Then
				RSWIN_DESC.SETUP_GuideToUse = 2
				Dim text As String = "GuideToUse"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_GuideToUse)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(text2)
				Me.SetDefaultSideloadLimit()
				Me.cboSidewinder.Enabled = False
				If Me.ActiveControl Is Me.optWheel Then
					Me.CheckMinMaxNumberOfGuides()
				End If
			End If
			Me.txtWheelLoad.Visible = Me.optWheel.Checked
			Me.txtWheelLoad.Enabled = Me.optWheel.Checked
			Me.txtWheelFricCoeff.Visible = Me.optWheel.Checked
			If Me.optWheel.Checked Then
				Me.lblFricCoeff.Left = 350
				Me.lblSideLoadperRodGuide.Top = Me.optWheel.Top - Me.lblSideLoadperRodGuide.Height
				Me.lblFricCoeff.Top = Me.lblSideLoadperRodGuide.Top
				Me.cmdResetFrictions.Top = Me.lblFricCoeff.Top
				Me.lblSideLoadperRodGuide.Visible = True
				Me.lblFricCoeff.Visible = True
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtOtherLoad_TextChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.txtOtherLoad And Versioned.IsNumeric(Me.txtOtherLoad.Text) Then
				If Me.optOther.Checked Then
					RSWIN_DESC.SETUP_OTHERGUIDE_LOAD = Conversions.ToSingle(Me.txtOtherLoad.Text)
					Dim text As String = "OtherLoad"
					Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_OTHERGUIDE_LOAD)
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
					RSWIN_DESC.SETUP_OTHERGUIDE_LOAD = Conversions.ToSingle(text2)
					Me.SetDefaultSideloadLimit()
					If Me.ActiveControl Is Me.optOther Then
						Me.CheckMinMaxNumberOfGuides()
					End If
				End If
				Return
			End If
		End Sub

		Private Sub txtMoldedLoad_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.txtMoldedLoad.Text) And Me.ActiveControl Is Me.txtMoldedLoad Then
				RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD = Conversions.ToSingle(Me.txtMoldedLoad.Text)
				Dim text As String = "MoldedLoad"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD = Conversions.ToSingle(text2)
				Me.SetDefaultSideloadLimit()
				Return
			End If
		End Sub

		Private Sub txtWheelLoad_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.txtWheelLoad.Text) And Me.ActiveControl Is Me.txtWheelLoad Then
				RSWIN_DESC.SETUP_WHEELGUIDE_LOAD = Conversions.ToSingle(Me.txtWheelLoad.Text)
				Dim text As String = "WheelLoad"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_WHEELGUIDE_LOAD)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_WHEELGUIDE_LOAD = Conversions.ToSingle(text2)
				Me.SetDefaultSideloadLimit()
				Return
			End If
		End Sub

		Private Sub txtWheelLoad_Enter(sender As Object, e As EventArgs)
			Me.txtWheelLoad.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtMoldedLoad_Enter(sender As Object, e As EventArgs)
			Me.txtMoldedLoad.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtMaxNumGuides_Enter(sender As Object, e As EventArgs)
			Me.txtMaxNumGuides.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtMaxNumGuides_FontChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtMaxNumGuides_Leave(sender As Object, e As EventArgs)
			Try
				If RSWIN_DESC.SETUP_GuideToUse >= 6 Or RSWIN_DESC.SETUP_GuideToUse < 4 Then
					RSWIN_DESC.iMinGuide = 3
				ElseIf RSWIN_DESC.SETUP_GuideToUse >= 4 Then
					RSWIN_DESC.iMinGuide = 4
				Else
					RSWIN_DESC.iMinGuide = 3
				End If
				If Convert.ToInt32(Me.txtMaxNumGuides.Text) <= Convert.ToInt32(Me.txtMinNumGuides.Text) Then
					MessageBox.Show(RSWIN_DESC.sMaxMustBeGreaterThanMin)
					Me.txtMaxNumGuides.Text = Conversions.ToString(RSWIN_DESC.iMaxGuide)
				ElseIf Convert.ToInt32(Me.txtMaxNumGuides.Text) > RSWIN_DESC.iMaxGuide Then
					Dim str As String
					If RSWIN_DESC.SETUP_GuideToUse < 4 Then
						str = String.Format(RSWIN_DESC.sGenericGuideMaxWarning, RSWIN_DESC.iMaxGuide)
					Else
						str = String.Format(RSWIN_DESC.sManufacturerGuideMaxWarning, RSWIN_DESC.iMaxGuide)
					End If
					If Convert.ToInt32(Me.txtMaxNumGuides.Text) > 12 Then
						MessageBox.Show(str + RSWIN_DESC.sFlexMsg)
						Me.txtMaxNumGuides.Text = "12"
					Else
						Dim msg As String = str + RSWIN_DESC.sFlexMsg + RSWIN_DESC.sAreYouSure
						Dim bDefaultYes As Boolean = False
						Dim flag As Boolean = False
						If Not Util.YesNo(msg, bDefaultYes, flag) Then
							Me.txtMaxNumGuides.Text = "6"
						End If
					End If
				End If
				Me.txtMaxNumGuides.BackColor = RSWIN_DESC.rgbEditComplete
				RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(Me.txtMaxNumGuides.Text)
				Dim text As String = "MaxNumGuidesPerRod"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(text2)
				Dim txtMaxNumGuides As Control = Me.txtMaxNumGuides
				Me.Control__LostFocus(txtMaxNumGuides)
				Me.txtMaxNumGuides = CType(txtMaxNumGuides, TextBox)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtMoldedLoad_Leave(sender As Object, e As EventArgs)
			Dim txtMoldedLoad As Control = Me.txtMoldedLoad
			Me.Control__LostFocus(txtMoldedLoad)
			Me.txtMoldedLoad = CType(txtMoldedLoad, TextBox)
		End Sub

		Private Sub txtWheelLoad_Leave(sender As Object, e As EventArgs)
			Dim txtWheelLoad As Control = Me.txtWheelLoad
			Me.Control__LostFocus(txtWheelLoad)
			Me.txtWheelLoad = CType(txtWheelLoad, TextBox)
		End Sub

		Private Sub txtOtherLoad_Enter(sender As Object, e As EventArgs)
			Me.txtOtherLoad.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtOtherLoad_Leave(sender As Object, e As EventArgs)
			Dim txtOtherLoad As Control = Me.txtOtherLoad
			Me.Control__LostFocus(txtOtherLoad)
			Me.txtOtherLoad = CType(txtOtherLoad, TextBox)
		End Sub

		Private Sub txtGearBoxRatio_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.txtGearBoxRatio.Text) Then
				RSWIN_DESC.SETUP_GearboxRatio = Convert.ToSingle(Me.txtGearBoxRatio.Text)
				Return
			End If
		End Sub

		Private Sub txtVBeltRatio_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.txtVBeltRatio.Text) Then
				RSWIN_DESC.SETUP_VBeltRatio = Convert.ToSingle(Me.txtVBeltRatio.Text)
				Return
			End If
		End Sub

		Private Sub chkCalcVBelt_CheckedChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.SETUP_CalcVBeltRatio = If((-If((Me.chkCalcVBelt.Checked > False), 1S, 0S)), 1S, 0S)
			If Not Me.chkCalcVBelt.Checked Then
				Me.txtVBeltRatio.Enabled = True
				Me.txtVBeltRatio.BackColor = Color.White
			Else
				Me.txtVBeltRatio.Enabled = False
				Me.txtVBeltRatio.BackColor = Color.LightGray
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtNumCycles_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.txtNumCycles.Text) Then
				RSWIN_DESC.SETUP_NumCycles = Convert.ToInt32(Me.txtNumCycles.Text)
				Return
			End If
		End Sub

		Private Sub optCRGMismatch_0_CheckedChanged(sender As Object, e As EventArgs)
			If Me.optCRGMismatch_0.Checked Then
				RSWIN_DESC.SETUP_BatchUpdateCustomRodGrades = 0
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub optCRGMismatch_1_CheckedChanged(sender As Object, e As EventArgs)
			If Me.optCRGMismatch_1.Checked Then
				RSWIN_DESC.SETUP_BatchUpdateCustomRodGrades = -1
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub optVertical_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub optDeviated_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub rbtEng_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbtEng.Checked Then
				RSWIN_DESC.SETUP_Language = RSWIN_DESC.sEnglish
				If RSWIN_DESC.bChangeCultures Then
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
				End If
			End If
			If Me.ActiveControl Is Me.rbtEng Then
				Dim text As String = "Language"
				Dim setup_Language As String = RSWIN_DESC.SETUP_Language
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, setup_Language, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_Language = setup_Language
				If RSWIN_DESC.bIntVersion Then
					If RSWIN_DESC.bChangeCultures Then
						Dim setup_Language2 As String = RSWIN_DESC.SETUP_Language
						If Operators.CompareString(setup_Language2, RSWIN_DESC.sEnglish, False) = 0 Then
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
						ElseIf Operators.CompareString(setup_Language2, RSWIN_DESC.sSpanish, False) = 0 Then
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
						ElseIf Operators.CompareString(setup_Language2, RSWIN_DESC.sChinese, False) = 0 Then
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
						Else
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
						End If
						Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
					End If
					Util.AssignValuesToControls(Me)
					Me.ReassignVariables()
					Me.TreeView2.Nodes.Clear()
					Dim treeNode As TreeNode = Me.TreeView2.Nodes.Add(Me.sGeneral)
					Me.BatchNode = Me.TreeView2.Nodes.Add(Me.sBatchMode)
					Me.TreeView2.Nodes.Add(Me.sCostDatabase)
					Me.TreeView2.Nodes.Add(Me.sDefaults)
					Me.TreeView2.Nodes.Add(Me.sOutputOptions)
					Dim treeNode2 As TreeNode = Me.TreeView2.Nodes.Add(Me.sPumpingUnitOptions)
					treeNode2.Expand()
					treeNode2.Nodes.Add(Me.sCustomizePumpingUnitList)
					treeNode2.Nodes.Add(Me.sMeasuredPumpingUnitList)
					Dim treeNode3 As TreeNode = Me.TreeView2.Nodes.Add(Me.sCustomizeRodGrades)
					If RSWIN_DESC.bExpert Then
						Dim treeNode4 As TreeNode = Me.TreeView2.Nodes.Add(Me.sExpert)
						If RSWIN_DESC.bXRODAdmin Then
							Dim treeNode5 As TreeNode = Me.TreeView2.Nodes.Add(Me.sAdmin)
						End If
					End If
					If RSWIN_DESC.DEBUG_AllowDebugging Then
						Dim treeNode6 As TreeNode = Me.TreeView2.Nodes.Add("Debug")
					End If
				End If
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub rbtSpan_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbtSpan.Checked Then
				RSWIN_DESC.SETUP_Language = RSWIN_DESC.sSpanish
				If RSWIN_DESC.bChangeCultures Then
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
				End If
			End If
			If Me.ActiveControl Is Me.rbtSpan Then
				Dim text As String = "Language"
				Dim setup_Language As String = RSWIN_DESC.SETUP_Language
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, setup_Language, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_Language = setup_Language
				If RSWIN_DESC.bIntVersion Then
					If RSWIN_DESC.bChangeCultures Then
						Dim setup_Language2 As String = RSWIN_DESC.SETUP_Language
						If Operators.CompareString(setup_Language2, RSWIN_DESC.sEnglish, False) = 0 Then
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
						ElseIf Operators.CompareString(setup_Language2, RSWIN_DESC.sSpanish, False) = 0 Then
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
						ElseIf Operators.CompareString(setup_Language2, RSWIN_DESC.sChinese, False) = 0 Then
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
						Else
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
						End If
						Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
					End If
					Util.AssignValuesToControls(Me)
					Me.ReassignVariables()
					Me.TreeView2.Nodes.Clear()
					Dim treeNode As TreeNode = Me.TreeView2.Nodes.Add(Me.sGeneral)
					Me.BatchNode = Me.TreeView2.Nodes.Add(Me.sBatchMode)
					Me.TreeView2.Nodes.Add(Me.sCostDatabase)
					Me.TreeView2.Nodes.Add(Me.sDefaults)
					Me.TreeView2.Nodes.Add(Me.sOutputOptions)
					Dim treeNode2 As TreeNode = Me.TreeView2.Nodes.Add(Me.sPumpingUnitOptions)
					treeNode2.Expand()
					treeNode2.Nodes.Add(Me.sCustomizePumpingUnitList)
					treeNode2.Nodes.Add(Me.sMeasuredPumpingUnitList)
					Dim treeNode3 As TreeNode = Me.TreeView2.Nodes.Add(Me.sCustomizeRodGrades)
					If RSWIN_DESC.bExpert Then
						Dim treeNode4 As TreeNode = Me.TreeView2.Nodes.Add(Me.sExpert)
						If RSWIN_DESC.bXRODAdmin Then
							Dim treeNode5 As TreeNode = Me.TreeView2.Nodes.Add(Me.sAdmin)
						End If
					End If
					If RSWIN_DESC.DEBUG_AllowDebugging Then
						Dim treeNode6 As TreeNode = Me.TreeView2.Nodes.Add("Debug")
					End If
				End If
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub rbtChinese_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbtChinese.Checked Then
				RSWIN_DESC.SETUP_Language = RSWIN_DESC.sChinese
				If RSWIN_DESC.bChangeCultures Then
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
				End If
			End If
			If Me.ActiveControl Is Me.rbtChinese Then
				Dim text As String = "Language"
				Dim setup_Language As String = RSWIN_DESC.SETUP_Language
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, setup_Language, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_Language = setup_Language
				If RSWIN_DESC.bIntVersion Then
					If RSWIN_DESC.bChangeCultures Then
						Dim setup_Language2 As String = RSWIN_DESC.SETUP_Language
						If Operators.CompareString(setup_Language2, RSWIN_DESC.sEnglish, False) = 0 Then
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
						ElseIf Operators.CompareString(setup_Language2, RSWIN_DESC.sSpanish, False) = 0 Then
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
						ElseIf Operators.CompareString(setup_Language2, RSWIN_DESC.sChinese, False) = 0 Then
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
						Else
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
						End If
						Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
					End If
					Util.AssignValuesToControls(Me)
					Me.ReassignVariables()
					Me.TreeView2.Nodes.Clear()
					Dim treeNode As TreeNode = Me.TreeView2.Nodes.Add(Me.sGeneral)
					Me.BatchNode = Me.TreeView2.Nodes.Add(Me.sBatchMode)
					Me.TreeView2.Nodes.Add(Me.sCostDatabase)
					Me.TreeView2.Nodes.Add(Me.sDefaults)
					Me.TreeView2.Nodes.Add(Me.sOutputOptions)
					Dim treeNode2 As TreeNode = Me.TreeView2.Nodes.Add(Me.sPumpingUnitOptions)
					treeNode2.Expand()
					treeNode2.Nodes.Add(Me.sCustomizePumpingUnitList)
					treeNode2.Nodes.Add(Me.sMeasuredPumpingUnitList)
					Dim treeNode3 As TreeNode = Me.TreeView2.Nodes.Add(Me.sCustomizeRodGrades)
					If RSWIN_DESC.bExpert Then
						Dim treeNode4 As TreeNode = Me.TreeView2.Nodes.Add(Me.sExpert)
						If RSWIN_DESC.bXRODAdmin Then
							Dim treeNode5 As TreeNode = Me.TreeView2.Nodes.Add(Me.sAdmin)
						End If
					End If
					If RSWIN_DESC.DEBUG_AllowDebugging Then
						Dim treeNode6 As TreeNode = Me.TreeView2.Nodes.Add("Debug")
					End If
				End If
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgPUCostDB_AfterEnterEditMode(sender As Object, e As EventArgs)
			Try
				Me.m_bInAfterEnterEdit = True
				Dim activeCell As UltraGridCell = Me.ulgPUCostDB.ActiveCell
				Me.objActiveCell = activeCell
				If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.objActiveCell.Row.Cells("Value").Value, "$0.00", False))) Then
					If Me.objActiveCell.Row.Cells("Value").Value Is Nothing Then
						Me.objActiveCell.Row.Cells("Value").Value = "$0.00"
					ElseIf Operators.ConditionalCompareObjectEqual(Me.objActiveCell.Row.Cells("Value").Value, "", False) Then
						Me.objActiveCell.Row.Cells("Value").Value = "$0.00"
					ElseIf Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.objActiveCell.Row.Cells("Value").Value)) Then
						Dim text As String = Conversions.ToString(Me.objActiveCell.Row.Cells("Value").Value)
						text = text.Replace("$", "")
						If Convert.ToSingle(text) = 0F Then
							Me.objActiveCell.Row.Cells("Value").Value = "$0.00"
						End If
					End If
				End If
				If Me.objPreviousCell IsNot Nothing Then
					If Me.objPreviousCell.Row.Cells("Value").Value Is Nothing Then
						Me.objPreviousCell.Row.Cells("Value").Value = ""
					ElseIf Operators.ConditionalCompareObjectEqual(Me.objPreviousCell.Row.Cells("Value").Value, "$0.00", False) Then
						Me.objPreviousCell.Row.Cells("Value").Value = ""
					ElseIf Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.objPreviousCell.Row.Cells("Value").Value)) Then
						Dim text2 As String = Conversions.ToString(Me.objPreviousCell.Row.Cells("Value").Value)
						text2 = text2.Replace("$", "")
						If Convert.ToSingle(text2.Trim()) = 0F Then
							Me.objPreviousCell.Row.Cells("Value").Value = ""
						End If
					End If
					Me.objPreviousCell = Nothing
				End If
			Catch ex As Exception
			End Try
			Me.m_bInAfterEnterEdit = False
		End Sub

		Private Sub ulgRSCostDB_AfterEnterEditMode(sender As Object, e As EventArgs)
			Try
				Me.m_bInAfterEnterEdit = True
				Dim activeCell As UltraGridCell = Me.ulgRSCostDB.ActiveCell
				Me.objActiveCell = activeCell
				If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.objActiveCell.Row.Cells("Value").Value, "$0.00", False))) Then
					If Me.objActiveCell.Row.Cells("Value").Value Is Nothing Then
						Me.objActiveCell.Row.Cells("Value").Value = "$0.00"
					ElseIf Operators.ConditionalCompareObjectEqual(Me.objActiveCell.Row.Cells("Value").Value, "", False) Then
						Me.objActiveCell.Row.Cells("Value").Value = "$0.00"
					ElseIf Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.objActiveCell.Row.Cells("Value").Value)) Then
						Dim text As String = Conversions.ToString(Me.objActiveCell.Row.Cells("Value").Value)
						text = text.Replace("$", "")
						If Convert.ToSingle(text) = 0F Then
							Me.objActiveCell.Row.Cells("Value").Value = "$0.00"
						End If
					End If
				End If
				If Me.objPreviousCell IsNot Nothing Then
					If Me.objPreviousCell.Row.Cells("Value").Value Is Nothing Then
						Me.objPreviousCell.Row.Cells("Value").Value = ""
					ElseIf Operators.ConditionalCompareObjectEqual(Me.objPreviousCell.Row.Cells("Value").Value, "$0.00", False) Then
						Me.objPreviousCell.Row.Cells("Value").Value = ""
					ElseIf Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.objPreviousCell.Row.Cells("Value").Value)) Then
						Dim text2 As String = Conversions.ToString(Me.objPreviousCell.Row.Cells("Value").Value)
						text2 = text2.Replace("$", "")
						If Convert.ToSingle(text2.Trim()) = 0F Then
							Me.objPreviousCell.Row.Cells("Value").Value = ""
						End If
					End If
					Me.objPreviousCell = Nothing
				End If
			Catch ex As Exception
			End Try
			Me.m_bInAfterEnterEdit = False
		End Sub

		Private Sub ulgGuideCostDB_AfterEnterEditMode(sender As Object, e As EventArgs)
			Try
				Me.m_bInAfterEnterEdit = True
				Dim activeCell As UltraGridCell = Me.ulgGuideCostDB.ActiveCell
				Me.objActiveCell = activeCell
				If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.objActiveCell.Row.Cells("Value").Value, "$0.00", False))) Then
					If Me.objActiveCell.Row.Cells("Value").Value Is Nothing Then
						Me.objActiveCell.Row.Cells("Value").Value = "$0.00"
					ElseIf Operators.ConditionalCompareObjectEqual(Me.objActiveCell.Row.Cells("Value").Value, "", False) Then
						Me.objActiveCell.Row.Cells("Value").Value = "$0.00"
					ElseIf Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.objActiveCell.Row.Cells("Value").Value)) Then
						Dim text As String = Conversions.ToString(Me.objActiveCell.Row.Cells("Value").Value)
						text = text.Replace("$", "")
						If Convert.ToSingle(text) = 0F Then
							Me.objActiveCell.Row.Cells("Value").Value = "$0.00"
						End If
					End If
				End If
				If Me.objPreviousCell IsNot Nothing Then
					If Me.objPreviousCell.Row.Cells("Value").Value Is Nothing Then
						Me.objPreviousCell.Row.Cells("Value").Value = ""
					ElseIf Operators.ConditionalCompareObjectEqual(Me.objPreviousCell.Row.Cells("Value").Value, "$0.00", False) Then
						Me.objPreviousCell.Row.Cells("Value").Value = ""
					ElseIf Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Me.objPreviousCell.Row.Cells("Value").Value)) Then
						Dim text2 As String = Conversions.ToString(Me.objPreviousCell.Row.Cells("Value").Value)
						text2 = text2.Replace("$", "")
						If Convert.ToSingle(text2.Trim()) = 0F Then
							Me.objPreviousCell.Row.Cells("Value").Value = ""
						End If
					End If
					Me.objPreviousCell = Nothing
				End If
			Catch ex As Exception
			End Try
			Me.m_bInAfterEnterEdit = False
		End Sub

		Private Sub ulgPUCostDB_BeforeExitEditMode(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs)
			Try
				Dim activeCell As UltraGridCell = Me.ulgPUCostDB.ActiveCell
				Me.objPreviousCell = activeCell
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgGuideCostDB_BeforeExitEditMode(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs)
			Try
				Dim activeCell As UltraGridCell = Me.ulgGuideCostDB.ActiveCell
				Me.objPreviousCell = activeCell
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgRSCostDB_BeforeExitEditMode(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs)
			Try
				Dim activeCell As UltraGridCell = Me.ulgRSCostDB.ActiveCell
				Me.objPreviousCell = activeCell
			Catch ex As Exception
			End Try
		End Sub

		Private Sub RswinSetup_Activated(sender As Object, e As EventArgs)
			Me.ResetClock()
			If Not RSWIN_DESC.bRodStarD Then
				Me._SSFrame_3.Top = 235
				If RSWIN_DESC.bExpert Then
					Me.grpWarnings.Top = Me._SSFrame_3.Top
				End If
				Me.lstDefaultItems.Height = 200
				Me.chkUseAllDiameters.Top = Me._SSFrame_3.Top + Me._SSFrame_3.Height + 5
				Return
			End If
		End Sub

		Private Sub ulgRSCostDB_BeforeEnterEditMode(sender As Object, e As CancelEventArgs)
			Try
				Dim activeCell As UltraGridCell = Me.ulgRSCostDB.ActiveCell
				Dim key As String = activeCell.Column.Key
				If Operators.CompareString(key, "Label", False) = 0 Then
					e.Cancel = True
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgPUCostDB_BeforeEnterEditMode(sender As Object, e As CancelEventArgs)
			Try
				Dim activeCell As UltraGridCell = Me.ulgPUCostDB.ActiveCell
				Dim key As String = activeCell.Column.Key
				If Operators.CompareString(key, "Label", False) = 0 Then
					e.Cancel = True
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgGuideCostDB_BeforeEnterEditMode(sender As Object, e As CancelEventArgs)
			Try
				Dim activeCell As UltraGridCell = Me.ulgGuideCostDB.ActiveCell
				Dim key As String = activeCell.Column.Key
				If Operators.CompareString(key, "Label", False) = 0 Then
					e.Cancel = True
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnDefault_Click(sender As Object, e As EventArgs)
			Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
			Me.ResetClock()
			If Operators.CompareString(Me.adiDefaults(Me.iSaveIndex).Name.Trim(), "SecondCompanyIconFilename", False) = 0 Then
				Dim obj As Object = "Imape Files (*.bmp,*.gif,*.jpg)|*.bmp;*.gif;*.jpg"
				Dim startupPath As String = Application.StartupPath
				Dim text As String
				FILEIO.SelectInputFile(text, startupPath, Conversions.ToString(obj), 1, "", "Company Icon Image File")
				Me.txtDefault.Text = text
				If text IsNot Nothing Then
					Dim array As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
					Dim num As Integer = Me.iSaveIndex
					Dim txtDefault As TextBox = Me.txtDefault
					Dim text2 As String = txtDefault.Text
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, array(num).Name, text2, RSWIN_DESC.sINIFile)
					txtDefault.Text = text2
				End If
				Me.txtDefault.Focus()
			Else
				folderBrowserDialog.SelectedPath = Me.txtDefault.Text
				folderBrowserDialog.ShowNewFolderButton = True
				Try
					Me.ResetClock()
				Catch ex As Exception
				End Try
				folderBrowserDialog.ShowDialog()
				Me.txtDefault.Text = folderBrowserDialog.SelectedPath
				Me.txtDefault.Focus()
			End If
		End Sub

		Private Sub txtDefault_KeyDown(sender As Object, e As KeyEventArgs)
			Try
				Dim txtDefault As TextBox = Me.txtDefault
				Dim lblDefaultType As Label = Me.lblDefaultType
				CtrlUI.TextBox_KeyDown(txtDefault, lblDefaultType, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
				Me.lblDefaultType = lblDefaultType
				Me.txtDefault = txtDefault
			Catch ex As Exception
			End Try
		End Sub

		Private Sub CheckTreeSize()
			Dim treeView As TreeView = Me.TreeView2
			If treeView.Left <> 8 Then
				treeView.Left = 8
			End If
			If treeView.Width <> 208 Then
				treeView.Width = 208
			End If
			If treeView.Height <> 304 Then
				treeView.Height = 304
			End If
			If treeView.Top <> 16 Then
				treeView.Top = 16
			End If
			Me.iPanelLeft = treeView.Left + treeView.Width + 5
		End Sub

		Public Sub LoadDiameterListFromMenu(cbo As ComboBox, sMenu As String, sMenuMetric As String)
			Dim array As String() = New String(0) {}
			Dim num2 As Integer
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				Dim num As Short = CShort(num2)
				Util.LoadMenu(sMenu, num, array)
				num2 = CInt(num)
			Else
				Dim num As Short = CShort(num2)
				Util.LoadMenu(sMenuMetric, num, array)
				num2 = CInt(num)
				Dim num3 As Integer = 1
				Dim num4 As Integer = num2
				For i As Integer = num3 To num4
					Dim num5 As Integer = Strings.InStr(array(i), "(", CompareMethod.Binary)
					If num5 > 0 Then
						Dim num6 As Integer
						num6 = num5
						While num6 <> 1
							If Operators.CompareString(array(i).Substring(num6, 1), " ", False) <> 0 Then
								Exit While
							End If
							num6 -= 1
						End While
						If Operators.CompareString(array(i).Substring(num5 + 1, 1), " ", False) = 0 Then
							num5 += 1
							StringType.MidStmtStr(array(i), num5, 1, "(")
						End If
						array(i) = array(i).Substring(0, num6 - 1) + RSWIN_DESC.Chr9 + Strings.Mid(array(i), num5)
					End If
				Next
			End If
			Try
				cbo.Items.Clear()
				Dim num7 As Integer = 1
				Dim num8 As Integer = num2
				For i As Integer = num7 To num8
					If Operators.CompareString(array(i).Trim(), "Other", False) <> 0 And Operators.CompareString(array(i).Trim(), "", False) <> 0 Then
						cbo.Items.Add(array(i))
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Private Sub LoadExpertPanel()
			' The following expression was wrapped in a checked-statement
			Try
				Dim comboBox As ComboBox = Me.cboFGlassRods
				RODUTIL.LoadRodGradeList(comboBox, 4, Me.FGlassRods_AL, True, True, False, False, False, False, True)
				Me.cboFGlassRods = comboBox
				Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("FGGradeRod", 3, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.FGGradeRod = Conversions.ToShort(obj)
					RSWIN_DESC.FGRodType = RODUTIL.RodGrade(RSWIN_DESC.FGGradeRod)
					Dim cboFGlassRods As ComboBox = Me.cboFGlassRods
					comboBox = Me.cboFGlassRods
					Dim selectedIndex As Integer = CInt(RODUTIL.FindRodGrade(comboBox, RSWIN_DESC.FGGradeRod, RSWIN_DESC.FGRodType))
					Me.cboFGlassRods = comboBox
					cboFGlassRods.SelectedIndex = selectedIndex
				Else
					Me.cboFGlassRods.SelectedIndex = 1
					Me.cboFGGlassRodsSelectedIndexChanged(True)
				End If
				comboBox = Me.cboHighStrengthRods
				RODUTIL.LoadRodGradeList(comboBox, 0, Me.HighStrengthRods_AL, True, False, False, True, False, True, False)
				Me.cboHighStrengthRods = comboBox
				comboBox = Me.cboHighStrengthRods
				RODUTIL.LoadRodGradeList(comboBox, 3, Me.HighStrengthRods_AL, False, False, False, True, False, True, False)
				Me.cboHighStrengthRods = comboBox
				comboBox = Me.cboHighStrengthRods
				RODUTIL.LoadRodGradeList(comboBox, 6, Me.HighStrengthRods_AL, False, True, False, True, False, True, False)
				Me.cboHighStrengthRods = comboBox
				comboBox = Me.cboUHSProrod
				RODUTIL.LoadRodGradeList(comboBox, 6, Me.HighStrengthProrods_AL, True, True, False, True, True, False, False)
				Me.cboUHSProrod = comboBox
				obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("HSGradeRod", 3, 4101))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.HSGradeRod = Conversions.ToShort(obj)
					RSWIN_DESC.HSRodType = RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod)
					Dim cboHighStrengthRods As ComboBox = Me.cboHighStrengthRods
					comboBox = Me.cboHighStrengthRods
					Dim selectedIndex2 As Integer = CInt(RODUTIL.FindRodGrade(comboBox, RSWIN_DESC.HSGradeRod, RSWIN_DESC.HSRodType))
					Me.cboHighStrengthRods = comboBox
					cboHighStrengthRods.SelectedIndex = selectedIndex2
				Else
					Dim cboHighStrengthRods2 As ComboBox = Me.cboHighStrengthRods
					comboBox = Me.cboHighStrengthRods
					Dim selectedIndex3 As Integer = CInt(RODUTIL.FindRodGrade(comboBox, 4101S, RODUTIL.RodGrade(4101)))
					Me.cboHighStrengthRods = comboBox
					cboHighStrengthRods2.SelectedIndex = selectedIndex3
					Me.cboHighStrengthRodsSelectedIndexChanged(True)
				End If
				Me.cboHighStrengthRods.BringToFront()
				Me.cboHighStrengthRods.Enabled = True
				comboBox = Me.cboSinkerBarsGrade
				RODUTIL.LoadRodGradeList(comboBox, 2, Me.SinkerBarsGrade_AL, True, True, False, False, False, False, False)
				Me.cboSinkerBarsGrade = comboBox
				comboBox = Me.cboSinkerRodsGrade
				RODUTIL.LoadRodGradeList(comboBox, 0, Me.SinkerRodsGrade_AL, True, False, False, False, False, False, False)
				Me.cboSinkerRodsGrade = comboBox
				comboBox = Me.cboSinkerRodsGrade
				RODUTIL.LoadRodGradeList(comboBox, 3, Me.SinkerRodsGrade_AL, False, False, False, False, False, False, False)
				Me.cboSinkerRodsGrade = comboBox
				comboBox = Me.cboSinkerRodsGrade
				RODUTIL.LoadRodGradeList(comboBox, 6, Me.SinkerRodsGrade_AL, False, True, False, False, False, False, False)
				Me.cboSinkerRodsGrade = comboBox
				Dim guruDataBaseFileName As String = "UseXRODVTubingSizes"
				Dim flag As Boolean = True
				RSWIN_DESC.SETUP_UseXRODVTubingSizes = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				guruDataBaseFileName = "MaxCasingSize"
				Dim num As Single = 5.5F
				RSWIN_DESC.MaxCasingSize = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, num))
				guruDataBaseFileName = "MaxTubingSizeOD"
				num = 2.875F
				RSWIN_DESC.MaxTubingSizeOD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, num))
				guruDataBaseFileName = "FixTubingSize"
				flag = False
				RSWIN_DESC.SETUP_FixTubingSize = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				Me.chkFixTubingSize.Checked = RSWIN_DESC.SETUP_FixTubingSize
				guruDataBaseFileName = "bUseSteelRodsOnly"
				flag = True
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				guruDataBaseFileName = "bUseFGlassWithSteelOnBottom"
				flag = False
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				If RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					Me.rbtUseBoth.Checked = True
				ElseIf RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					Me.optUseFGlassWithSteelOnBottom.Checked = RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom
				ElseIf RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					Me.optUseSteelRodsOnly.Checked = RSWIN_DESC.SETUP_bUseSteelRodsOnly
				Else
					Me.optUseFGlassWithSteelOnBottom.Checked = False
				End If
				RSWIN_DESC.SETUP_bSinkerBar = True
				If RSWIN_DESC.SETUP_bSinkerBar Then
					Me.optSinkerBars.Checked = True
					obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("SBGradeRod", 3, 8195))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						RSWIN_DESC.SBGradeRod = Conversions.ToShort(obj)
						RSWIN_DESC.SBRodType = RODUTIL.RodGrade(RSWIN_DESC.SBGradeRod)
						Dim cboSinkerBarsGrade As ComboBox = Me.cboSinkerBarsGrade
						comboBox = Me.cboSinkerBarsGrade
						Dim selectedIndex4 As Integer = CInt(RODUTIL.FindRodGrade(comboBox, RSWIN_DESC.SBGradeRod, RSWIN_DESC.SBRodType))
						Me.cboSinkerBarsGrade = comboBox
						cboSinkerBarsGrade.SelectedIndex = selectedIndex4
					Else
						Me.cboSinkerBarsGrade.SelectedIndex = 0
						Me.cboSinkerBarsGradeSelectedIndexChanged(True)
					End If
				Else
					Me.optSinkerRods.Checked = True
					obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("SBGradeRod", 3, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						RSWIN_DESC.SBGradeRod = Conversions.ToShort(obj)
						RSWIN_DESC.SBRodType = RODUTIL.RodGrade(RSWIN_DESC.SBGradeRod)
						Dim cboSinkerRodsGrade As ComboBox = Me.cboSinkerRodsGrade
						comboBox = Me.cboSinkerRodsGrade
						Dim selectedIndex5 As Integer = CInt(RODUTIL.FindRodGrade(comboBox, RSWIN_DESC.SBGradeRod, RSWIN_DESC.SBRodType))
						Me.cboSinkerRodsGrade = comboBox
						cboSinkerRodsGrade.SelectedIndex = selectedIndex5
					Else
						Me.cboSinkerRodsGrade.SelectedIndex = 2
						Me.cboSinkerRodsGradeSelectedIndexChanged(True)
					End If
				End If
				ini.SavePreferenceDataValue("bSinkerBarPreference", Convert.ToString(RSWIN_DESC.SETUP_bSinkerBar))
				If Me.optSinkerBars.Checked Then
					Me.lblSinkerBars.Visible = True
					Me.cboSinkerBarsGrade.Visible = True
					Me.lblSinkerRods.Visible = False
					Me.cboSinkerRodsGrade.Visible = False
				ElseIf Me.optSinkerRods.Checked Then
					Me.lblSinkerBars.Visible = False
					Me.cboSinkerBarsGrade.Visible = False
					Me.lblSinkerRods.Visible = True
					Me.cboSinkerRodsGrade.Visible = True
				End If
				Me.cboCasingSize.Items.Clear()
				Me.cboCasingSize.Items.Add("2 7/8" + RSWIN_DESC.sDblQuote + " (73.0 mm)")
				Me.cboCasingSize.Items.Add("3 1/2" + RSWIN_DESC.sDblQuote + " (88.9 mm)")
				Me.cboCasingSize.Items.Add("4" + RSWIN_DESC.sDblQuote + " (101.6 mm)")
				Me.cboCasingSize.Items.Add("4 1/2" + RSWIN_DESC.sDblQuote + " (114.3 mm)")
				Me.cboCasingSize.Items.Add("5" + RSWIN_DESC.sDblQuote + " (127 mm)")
				Me.cboCasingSize.Items.Add("5 1/2" + RSWIN_DESC.sDblQuote + " (139.7 mm)")
				Me.cboCasingSize.Items.Add("6 5/8" + RSWIN_DESC.sDblQuote + " (154 mm)")
				Me.cboCasingSize.Items.Add("7" + RSWIN_DESC.sDblQuote + " (177.8 mm)")
				Me.cboCasingSize.Items.Add("7 5/8" + RSWIN_DESC.sDblQuote + " (179.4 mm)")
				guruDataBaseFileName = "MaxCasingSize"
				num = 5.5F
				RSWIN_DESC.MaxCasingSize = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, num))
				If RSWIN_DESC.MaxCasingSize <> 0F Then
					Dim flag2 As Boolean = False
					Dim i As Integer = 0
					While Math.Abs(CDbl(RSWIN_DESC.MaxCasingSize) - Conversion.Val(RSWIN_DESC.sCasingSizes(i))) >= 0.0001
						i += 1
						If i > 8 Then
							IL_782:
							If Not flag2 Then
								RSWIN_DESC.MaxCasingSize = 5.5F
								Me.cboCasingSize.SelectedIndex = 5
								ini.SavePreferenceDataValue("MaxCasingSize", RSWIN_DESC.MaxCasingSize)
								GoTo IL_7AF
							End If
							GoTo IL_7AF
						End If
					End While
					Me.cboCasingSize.SelectedIndex = i
					flag2 = True
					GoTo IL_782
				End If
				RSWIN_DESC.MaxCasingSize = 5.5F
				Me.cboCasingSize.SelectedIndex = 5
				ini.SavePreferenceDataValue("MaxCasingSize", RSWIN_DESC.MaxCasingSize)
				IL_7AF:
				Dim fMaxTubingSize As Single
				Dim num2 As Single
				Dim num3 As Single
				Dim num4 As Single
				RODUTIL.GetSizeFromCasingSize(RSWIN_DESC.MaxCasingSize, fMaxTubingSize, num2, num3, num4, True)
				Util.LoadMenu("TUBING-OD", RSWIN_DESC.nItems, Me.OD)
				Me.LoadTubingSizeList(Me.OD, fMaxTubingSize, False)
				guruDataBaseFileName = "MaxTubingSizeOD"
				num = 2.875F
				RSWIN_DESC.MaxTubingSizeOD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, num))
				If Information.IsDBNull(RSWIN_DESC.MaxTubingSizeOD) Then
					RSWIN_DESC.MaxTubingSizeOD = 2.875F
					ini.SavePreferenceDataValue("MaxTubingSizeOD", RSWIN_DESC.MaxTubingSizeOD)
				Else
					Me.txtMaxTubingSizeOD.Tag = "mem"
					Dim txtMaxTubingSizeOD As TextBox = Me.txtMaxTubingSizeOD
					num = RSWIN_DESC.MaxTubingSizeOD
					txtMaxTubingSizeOD.Text = num.ToString()
				End If
				Me.cboMaxTubingSizeOD.SelectedIndex = Me.cboMaxTubingSizeOD.Items.Count - 1
				Dim num5 As Integer = 1
				Dim nItems As Integer = CInt(RSWIN_DESC.nItems)
				For i As Integer = num5 To nItems
					' The following expression was wrapped in a unchecked-expression
					If Math.Abs(CDbl(RSWIN_DESC.MaxTubingSizeOD) - Conversion.Val(Me.OD(i))) < 0.0001 Then
						Me.cboMaxTubingSizeOD.SelectedIndex = i - 1
						Exit For
					End If
				Next
				RSWIN_DESC.SETUP_bRodstarTubingAnchored = True
				Me.chkRodstarTubingAnchoredRec.Checked = RSWIN_DESC.SETUP_bRodstarTubingAnchored
				guruDataBaseFileName = "UseXRODVTubingSizes"
				flag = True
				RSWIN_DESC.SETUP_UseXRODVTubingSizes = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				Me.chkRodstarTubingSizeRec.Checked = RSWIN_DESC.SETUP_UseXRODVTubingSizes
				guruDataBaseFileName = "FixTubingSize"
				flag = False
				RSWIN_DESC.SETUP_FixTubingSize = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				Me.chkFixTubingSize.Checked = RSWIN_DESC.SETUP_FixTubingSize
				guruDataBaseFileName = "XRODUseCustomizedLists"
				flag = False
				RSWIN_DESC.bXRODUseCustomizedLists = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				Dim num6 As Integer
				If RSWIN_DESC.bXRODUseCustomizedLists AndAlso Not Me.LoadCustomizedUnitListManufacturerLists(num6) Then
					RSWIN_DESC.bXRODUseCustomizedLists = False
					Me.chkAIUseCustomizedLists.Checked = RSWIN_DESC.bXRODUseCustomizedLists
					ini.SavePreferenceDataValue("XRODUseCustomizedLists", Convert.ToString(RSWIN_DESC.bXRODUseCustomizedLists))
				End If
				Me.chkAIUseCustomizedLists.Checked = RSWIN_DESC.bXRODUseCustomizedLists
				Me.pnlUseGeneral.Visible = Me.chkAIUseCustomizedLists.Checked
				guruDataBaseFileName = "XRODUseGeneralList"
				flag = False
				RSWIN_DESC.bXRODUseGeneralList = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				Me.chkUseGeneral.Checked = RSWIN_DESC.bXRODUseGeneralList
				guruDataBaseFileName = "XRODUseClosestUnit"
				flag = False
				RSWIN_DESC.bXRODUseClosestUnit = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				Me.chkUseClosestUnit.Checked = RSWIN_DESC.bXRODUseClosestUnit
				If Not RSWIN_DESC.bXRODUseCustomizedLists Then
					comboBox = Me.cboManufMenu1
					Me.LoadManufMenuCombo(comboBox, False)
					Me.cboManufMenu1 = comboBox
					comboBox = Me.cboManufMenu2
					Me.LoadManufMenuCombo(comboBox, False)
					Me.cboManufMenu2 = comboBox
					comboBox = Me.cboManufMenu3
					Me.LoadManufMenuCombo(comboBox, False)
					Me.cboManufMenu3 = comboBox
					comboBox = Me.cboManufMenu4
					Me.LoadManufMenuCombo(comboBox, False)
					Me.cboManufMenu4 = comboBox
					comboBox = Me.cboManufMenu5
					Me.LoadManufMenuCombo(comboBox, False)
					Me.cboManufMenu5 = comboBox
					comboBox = Me.cboManufMenu6
					Me.LoadManufMenuCombo(comboBox, False)
					Me.cboManufMenu6 = comboBox
					comboBox = Me.cboManufMenu7
					Me.LoadManufMenuCombo(comboBox, False)
					Me.cboManufMenu7 = comboBox
					comboBox = Me.cboManufMenu8
					Me.LoadManufMenuCombo(comboBox, False)
					Me.cboManufMenu8 = comboBox
				Else
					comboBox = Me.cboManufMenu1
					Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
					Me.cboManufMenu1 = comboBox
					comboBox = Me.cboManufMenu2
					Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
					Me.cboManufMenu2 = comboBox
					comboBox = Me.cboManufMenu3
					Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
					Me.cboManufMenu3 = comboBox
					comboBox = Me.cboManufMenu4
					Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
					Me.cboManufMenu4 = comboBox
					comboBox = Me.cboManufMenu5
					Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
					Me.cboManufMenu5 = comboBox
					comboBox = Me.cboManufMenu6
					Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
					Me.cboManufMenu6 = comboBox
					comboBox = Me.cboManufMenu7
					Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
					Me.cboManufMenu7 = comboBox
					comboBox = Me.cboManufMenu8
					Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
					Me.cboManufMenu8 = comboBox
				End If
				Dim num7 As Integer = 1
				Do
					Dim index As Integer = num7
					guruDataBaseFileName = "Use_PUManuf_Preference_" + num7.ToString().Trim()
					flag = False
					RSWIN_DESC.set_bUsePUManuf(index, RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag))
					obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("PUManuf_Preference_" + num7.ToString().Trim(), 8, DBNull.Value))
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						If Strings.InStr(Conversions.ToString(obj), "American Conv. (100", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(obj), "American Conv. (less than 100", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(obj), "American (100", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(obj), "American (less than 100", CompareMethod.Binary) > 0 Then
							Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject("*", obj), "*"))
							obj = "American Conventional                   "
							ini.SavePreferenceDataValue("PUManuf_Preference_" + num7.ToString().Trim(), RuntimeHelpers.GetObjectValue(obj))
						End If
						RSWIN_DESC.set_PUManuf(num7, Conversions.ToString(obj))
						Dim flag3 As Boolean
						Me.SetManufMenuCbo(num7, RSWIN_DESC.get_PUManuf(num7), flag3)
					ElseIf Not RSWIN_DESC.bXRODUseCustomizedLists Then
						RSWIN_DESC.set_PUManuf(num7, Me.SetManufMenuSelectIndex(num7, Me.GetManufMenuCboIndex(num7, "Lufkin Conventional - New               ")))
						ini.SavePreferenceDataValue("PUManuf_Preference_" + num7.ToString().Trim(), RSWIN_DESC.get_PUManuf(num7))
					ElseIf Information.UBound(Me.CustomizedUnitTypeInfoList, 1) > 0 Then
						RSWIN_DESC.set_PUManuf(num7, Me.SetManufMenuSelectIndex(num7, 0))
						ini.SavePreferenceDataValue("PUManuf_Preference_" + num7.ToString().Trim(), RSWIN_DESC.get_PUManuf(num7))
						RSWIN_DESC.set_bUsePUManuf(num7, False)
					End If
					If RSWIN_DESC.get_bUsePUManuf(num7) Then
					End If
					num7 += 1
				Loop While num7 <= 8
				Me.chkManufacturer1.Checked = RSWIN_DESC.get_bUsePUManuf(1)
				Me.chkManufacturer2.Checked = RSWIN_DESC.get_bUsePUManuf(2)
				Me.chkManufacturer3.Checked = RSWIN_DESC.get_bUsePUManuf(3)
				Me.chkManufacturer4.Checked = RSWIN_DESC.get_bUsePUManuf(4)
				Me.chkManufacturer5.Checked = RSWIN_DESC.get_bUsePUManuf(5)
				Me.chkManufacturer6.Checked = RSWIN_DESC.get_bUsePUManuf(6)
				Me.chkManufacturer7.Checked = RSWIN_DESC.get_bUsePUManuf(7)
				Me.chkManufacturer8.Checked = RSWIN_DESC.get_bUsePUManuf(8)
				Me.cboManufMenu1.Enabled = Me.chkManufacturer1.Checked
				Me.cboManufMenu2.Enabled = Me.chkManufacturer2.Checked
				Me.cboManufMenu3.Enabled = Me.chkManufacturer3.Checked
				Me.cboManufMenu4.Enabled = Me.chkManufacturer4.Checked
				Me.cboManufMenu5.Enabled = Me.chkManufacturer5.Checked
				Me.cboManufMenu6.Enabled = Me.chkManufacturer6.Checked
				Me.cboManufMenu7.Enabled = Me.chkManufacturer7.Checked
				Me.cboManufMenu8.Enabled = Me.chkManufacturer8.Checked
				Me.chkAIUseCustomizedLists.Checked = RSWIN_DESC.bXRODUseCustomizedLists
				guruDataBaseFileName = "bUseAvgRodTBGFricCoeff"
				flag = True
				RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = Conversions.ToSingle(ini.GetPreferenceDataValue("TimesAvgRodTBGFricCoeff", 4, 1.0))
				If RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Then
					RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F
				ElseIf RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F Then
					RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff = True
				Else
					RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff = False
				End If
				Me.NumericUpDown1_XTimes.Value = New Decimal(RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff)
				RSWIN_DESC.SETUP_ServiceFactorPreference = Conversions.ToSingle(ini.GetPreferenceDataValue("ServiceFactorPreference", 4, 0.9))
				Me.txtServiceFactorPreference.Text = Conversions.ToString(RSWIN_DESC.SETUP_ServiceFactorPreference)
				Dim num8 As Single = Conversions.ToSingle(ini.GetDataValue("ElectricityCost", 4, True, 0.06))
				RSWIN_DESC.SETUP_ElectricityCostPreference = Conversions.ToSingle(ini.GetPreferenceDataValue("ElectricityCostPreference", 4, num8))
				Me.txtElectricityCostPreference.Text = Conversions.ToString(RSWIN_DESC.SETUP_ElectricityCostPreference)
				guruDataBaseFileName = "bInsertPump"
				flag = True
				RSWIN_DESC.bInsertPump = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				guruDataBaseFileName = "bTubingPump"
				flag = False
				RSWIN_DESC.bTubingPump = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				guruDataBaseFileName = "bLargeBorePump"
				flag = False
				RSWIN_DESC.bLargeBorePump = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				Me.chkInsertPump.Checked = RSWIN_DESC.bInsertPump
				Me.chkTubingPump.Checked = RSWIN_DESC.bTubingPump
				Me.chkLargeBorePump.Checked = RSWIN_DESC.bLargeBorePump
				RSWIN_DESC.SETUP_bRodstarPumpType = True
				Me.chkRodstarPumpTypeRec.Checked = RSWIN_DESC.SETUP_bRodstarPumpType
				Dim bExpert As Boolean = RSWIN_DESC.bExpert
				guruDataBaseFileName = "bGuru"
				flag = False
				RSWIN_DESC.SETUP_bGuru = (bExpert And RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag))
				If RSWIN_DESC.SETUP_bGuru Then
					Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
					guruDataBaseFileName = RSWIN_DESC.GuruDataBaseFileName
					FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, False, False, False, False)
					RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
				End If
				If RSWIN_DESC.bExpert Then
					If Not RSWIN_DESC.bXRODAdmin Then
						RSWIN_DESC.SETUP_bGuruUseTemplateDatabase = True
					Else
						guruDataBaseFileName = "bXRODUseTemplateDatabase"
						flag = True
						RSWIN_DESC.SETUP_bGuruUseTemplateDatabase = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
					End If
					If RSWIN_DESC.SETUP_bGuruUseTemplateDatabase Then
						Me.rbtUseTemplateDatabase.Checked = True
					Else
						Me.rbtUseTemplateFiles.Checked = True
					End If
					If RSWIN_DESC.bXRODAdmin Then
						guruDataBaseFileName = "bXRODAdminDebug"
						flag = True
						RSWIN_DESC.SETUP_bAdminDebug = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
						Me.chkDebug.Checked = RSWIN_DESC.SETUP_bAdminDebug
						Me.chkDebug.Visible = True
					Else
						RSWIN_DESC.SETUP_bAdminDebug = False
						Me.chkDebug.Visible = False
					End If
				End If
				obj = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("PowerMeterType", 3, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.SETUP_PowerMeterType = Conversions.ToShort(obj)
				Else
					RSWIN_DESC.SETUP_PowerMeterType = 1S
				End If
				If RSWIN_DESC.SETUP_PowerMeterType = 1S Then
					Me.optPowerMeterType_1.Checked = True
				ElseIf RSWIN_DESC.SETUP_PowerMeterType = 2S Then
					Me.optPowerMeterType_2.Checked = True
				End If
				guruDataBaseFileName = "IncludeMotorSPV"
				flag = False
				RSWIN_DESC.SETUP_IncludeMotorSPV = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
				Me.chkIncludeMotorSPV.Checked = RSWIN_DESC.SETUP_IncludeMotorSPV
				MRodstarXML.SetAIFilePreferencesFromSetup(False)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SetManufCheckbox(Index As Integer, bVal As Boolean)
			Try
				Select Case Index
					Case 1
						Me.chkManufacturer1.Checked = bVal
					Case 2
						Me.chkManufacturer2.Checked = bVal
					Case 3
						Me.chkManufacturer3.Checked = bVal
					Case 4
						Me.chkManufacturer4.Checked = bVal
					Case 5
						Me.chkManufacturer5.Checked = bVal
					Case 6
						Me.chkManufacturer6.Checked = bVal
					Case 7
						Me.chkManufacturer7.Checked = bVal
					Case 8
						Me.chkManufacturer8.Checked = bVal
				End Select
				RSWIN_DESC.set_bUsePUManuf(Index, bVal)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SetManufCheckboxEnabled(Index As Integer, bVal As Boolean)
			Try
				Select Case Index
					Case 1
						Me.chkManufacturer1.Enabled = bVal
					Case 2
						Me.chkManufacturer2.Enabled = bVal
					Case 3
						Me.chkManufacturer3.Enabled = bVal
					Case 4
						Me.chkManufacturer4.Enabled = bVal
					Case 5
						Me.chkManufacturer5.Enabled = bVal
					Case 6
						Me.chkManufacturer6.Enabled = bVal
					Case 7
						Me.chkManufacturer7.Enabled = bVal
					Case 8
						Me.chkManufacturer8.Enabled = bVal
				End Select
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SetManufMenuCboEnabled(Indx As Integer, bVal As Boolean)
			Try
				Select Case Indx
					Case 1
						Me.cboManufMenu1.Enabled = bVal
					Case 2
						Me.cboManufMenu2.Enabled = bVal
					Case 3
						Me.cboManufMenu3.Enabled = bVal
					Case 4
						Me.cboManufMenu4.Enabled = bVal
					Case 5
						Me.cboManufMenu5.Enabled = bVal
					Case 6
						Me.cboManufMenu6.Enabled = bVal
					Case 7
						Me.cboManufMenu7.Enabled = bVal
					Case 8
						Me.cboManufMenu8.Enabled = bVal
				End Select
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SetManufMenuCbo(Indx As Integer, PUManuf_Preference As String, ByRef bSet As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				Dim comboBox As ComboBox
				Select Case Indx
					Case 1
						comboBox = Me.cboManufMenu1
					Case 2
						comboBox = Me.cboManufMenu2
					Case 3
						comboBox = Me.cboManufMenu3
					Case 4
						comboBox = Me.cboManufMenu4
					Case 5
						comboBox = Me.cboManufMenu5
					Case 6
						comboBox = Me.cboManufMenu6
					Case 7
						comboBox = Me.cboManufMenu7
					Case 8
						comboBox = Me.cboManufMenu8
				End Select
				bSet = False
				Dim num As Integer = 0
				Dim num2 As Integer = comboBox.Items.Count - 1
				For i As Integer = num To num2
					If Operators.CompareString(comboBox.Items(i).ToString().Trim(), PUManuf_Preference.Trim(), False) = 0 Then
						If Not RSWIN_DESC.bXRODUseCustomizedLists Then
							comboBox.SelectedIndex = i
							bSet = True
							Exit For
						End If
						If RSWIN_DESC.bXRODUseCustomizedLists And i <= Information.UBound(Me.CustomizedUnitTypeInfoList, 1) Then
							comboBox.SelectedIndex = i
							bSet = True
							Exit For
						End If
					End If
				Next
				If RSWIN_DESC.bXRODUseCustomizedLists AndAlso (comboBox.SelectedIndex = -1 Or Indx > Information.UBound(Me.CustomizedUnitTypeInfoList, 1) + 1) Then
					bSet = False
					comboBox.SelectedIndex = 0
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Function GetManufMenuCboIndex(Indx As Integer, PUManuf_Preference As String) As Integer
			Dim num As Integer = -1
			Dim result As Integer
			Try
				Select Case Indx
					Case 1
						num = Me.cboManufMenu1.Items.IndexOf(PUManuf_Preference)
					Case 2
						num = Me.cboManufMenu2.Items.IndexOf(PUManuf_Preference)
					Case 3
						num = Me.cboManufMenu3.Items.IndexOf(PUManuf_Preference)
					Case 4
						num = Me.cboManufMenu4.Items.IndexOf(PUManuf_Preference)
					Case 5
						num = Me.cboManufMenu5.Items.IndexOf(PUManuf_Preference)
					Case 6
						num = Me.cboManufMenu6.Items.IndexOf(PUManuf_Preference)
					Case 7
						num = Me.cboManufMenu7.Items.IndexOf(PUManuf_Preference)
					Case 8
						num = Me.cboManufMenu8.Items.IndexOf(PUManuf_Preference)
				End Select
				result = num
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub LoadManufMenuCombo(ByRef cboManufMenu As ComboBox, bUseCustomPUDB As Boolean)
			Dim text As String = New String(" "c, 2)
			Dim fileName As String
			FILEUTIL.LocateFile("UNITINFO32.PUD", fileName, 2S, False, False, False, False)
			Dim comboBox As ComboBox
			Dim num11 As Short
			Dim num12 As Short
			Dim num As Short = CShort(FileSystem.FreeFile())
			FileSystem.FileOpen(CInt(num), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
			Dim unitTypeInfo As RSWIN_DESC.UnitTypeInfo
			Dim num2 As Short = CShort((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(unitTypeInfo))))
			Me.UnitTypeInfoList = New RSWIN_DESC.UnitTypeInfo(CInt((num2 + 1S)) - 1) {}
			Dim num3 As Integer
			Dim num4 As Integer
			If bUseCustomPUDB Then
				num3 = 0
				num4 = 0
				Dim num5 As Integer = 0
				Me.UnitTypeInfoList(num5).Manuf = "(Measured pumping units)"
				Me.UnitTypeInfoList(num5).Abbrev = "CUSTOM"
				Me.UnitTypeInfoList(num5).ShowNames = -1S
				Me.UnitTypeInfoList(num5).SortByNames = -1S
				Me.UnitTypeInfoList(num5).UnitType = -1S
				Me.UnitTypeInfoList = CType(Utils.CopyArray(CType(Me.UnitTypeInfoList, Array), New RSWIN_DESC.UnitTypeInfo(num4 + 1 - 1) {}), RSWIN_DESC.UnitTypeInfo())
			Else
				num3 = 1
				num4 = 0
			End If
			Dim num6 As Short = 1S
			Dim num7 As Short = num2
			For num8 As Short = num6 To num7
				Dim fileNumber As Integer = CInt(num)
				Dim valueType As ValueType = unitTypeInfo
				FileSystem.FileGet(fileNumber, valueType, -1L)
				Dim valueType2 As ValueType = valueType
				Dim unitTypeInfo2 As RSWIN_DESC.UnitTypeInfo
				unitTypeInfo = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.UnitTypeInfo), unitTypeInfo2)
				Dim text2 As String = Strings.Trim(unitTypeInfo.Abbrev)
				If bUseCustomPUDB Then
					Dim num9 As Integer = Custom.CustomPumpingUnitLists_SelectRow(text2.Trim(), text, False, "")
					Dim num10 As Short = CShort(text.Trim().Length)
					If num9 = 0 Then
						text2 = ""
					End If
				End If
				If Strings.Len(text2) > 0 Then
					num4 += 1
					Me.UnitTypeInfoList(num4) = unitTypeInfo
				End If
			Next
			FileSystem.FileClose(New Integer() { CInt(num) })
			comboBox = cboManufMenu
			comboBox.Items.Clear()
			num11 = CShort(num3)
			num12 = CShort(num4)
			For num8 As Short = num11 To num12
				comboBox.Items.Add(Me.UnitTypeInfoList(CInt(num8)).Manuf)
			Next
		End Sub

		Private Sub LoadManufMenuComboFromCustomizedLists(ByRef cboManufMenu As ComboBox, bUseCustomPUDB As Boolean)
			Dim text As String = New String(" "c, 2)
			If Information.UBound(Me.CustomizedUnitTypeInfoList, 1) > -1 Then
				Dim comboBox As ComboBox = cboManufMenu
				comboBox.Items.Clear()
				Dim num As Short
				Dim num2 As Short
				num = CShort(Information.LBound(Me.CustomizedUnitTypeInfoList, 1))
				num2 = CShort(Information.UBound(Me.CustomizedUnitTypeInfoList, 1))
				For num3 As Short = num To num2
					comboBox.Items.Add(Me.CustomizedUnitTypeInfoList(CInt(num3)).Manuf)
				Next
				Return
			End If
		End Sub

		Private Sub optSinkerBars_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Dim flag As Boolean = Me.optSinkerRods Is Me.ActiveControl
			If Me.optSinkerBars.Checked Then
				Me.lblSinkerBars.Visible = True
				Me.cboSinkerBarsGrade.Visible = True
				Me.lblSinkerRods.Visible = False
				Me.cboSinkerRodsGrade.Visible = False
				RSWIN_DESC.SETUP_bSinkerBar = True
			ElseIf Me.optSinkerRods.Checked Then
				Me.lblSinkerBars.Visible = False
				Me.cboSinkerBarsGrade.Visible = False
				Me.lblSinkerRods.Visible = True
				Me.cboSinkerRodsGrade.Visible = True
				RSWIN_DESC.SETUP_bSinkerBar = False
			End If
			ini.SavePreferenceDataValue("bSinkerBarPreference", Convert.ToString(RSWIN_DESC.SETUP_bSinkerBar))
		End Sub

		Private Sub optSinkerRods_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.optSinkerBars.Checked Then
				Me.lblSinkerBars.Visible = True
				Me.cboSinkerBarsGrade.Visible = True
				Me.lblSinkerRods.Visible = False
				Me.cboSinkerRodsGrade.Visible = False
				RSWIN_DESC.SETUP_bSinkerBar = True
			ElseIf Me.optSinkerRods.Checked Then
				Me.lblSinkerBars.Visible = False
				Me.cboSinkerBarsGrade.Visible = False
				Me.lblSinkerRods.Visible = True
				Me.cboSinkerRodsGrade.Visible = True
				RSWIN_DESC.SETUP_bSinkerBar = False
			End If
			ini.SavePreferenceDataValue("bSinkerBarPreference", Convert.ToString(RSWIN_DESC.SETUP_bSinkerBar))
		End Sub

		Private Sub cboFGlassRods_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.cboFGGlassRodsSelectedIndexChanged(Me.cboFGlassRods Is Me.ActiveControl)
		End Sub

		Private Sub cboFGGlassRodsSelectedIndexChanged(bClicked As Boolean)
			If bClicked Then
				Dim cboFGlassRods As ComboBox = Me.cboFGlassRods
				Dim num As Short = CShort(RODUTIL.ConvertListIndexToRodGrade(cboFGlassRods, Me.cboFGlassRods.SelectedIndex))
				Me.cboFGlassRods = cboFGlassRods
				RSWIN_DESC.FGGradeRod = num
				ini.SavePreferenceDataValue("FGGradeRod", RSWIN_DESC.FGGradeRod)
				RSWIN_DESC.FGRodType = Convert.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboFGlassRods.Items(Me.cboFGlassRods.SelectedIndex), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
				ini.SavePreferenceDataValue("FGRodType", RSWIN_DESC.FGRodType)
				Return
			End If
		End Sub

		Private Sub cboHighStrengthRods_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.cboHighStrengthRodsSelectedIndexChanged(Me.cboHighStrengthRods Is Me.ActiveControl)
		End Sub

		Private Sub cboHighStrengthRodsSelectedIndexChanged(bClicked As Boolean)
			If bClicked Then
				Dim cboHighStrengthRods As ComboBox = Me.cboHighStrengthRods
				Dim num As Short = CShort(RODUTIL.ConvertListIndexToRodGrade(cboHighStrengthRods, Me.cboHighStrengthRods.SelectedIndex))
				Me.cboHighStrengthRods = cboHighStrengthRods
				RSWIN_DESC.HSGradeRod = num
				ini.SavePreferenceDataValue("HSGradeRod", RSWIN_DESC.HSGradeRod)
				RSWIN_DESC.HSRodType = Convert.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboHighStrengthRods.Items(Me.cboHighStrengthRods.SelectedIndex), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
				ini.SavePreferenceDataValue("HSRodType", RSWIN_DESC.HSRodType)
				Return
			End If
		End Sub

		Private Sub cboSinkerBarsGrade_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.cboSinkerBarsGradeSelectedIndexChanged(Me.cboSinkerBarsGrade Is Me.ActiveControl)
		End Sub

		Private Sub cboSinkerBarsGradeSelectedIndexChanged(bClicked As Boolean)
			If bClicked Then
				Dim cboSinkerBarsGrade As ComboBox = Me.cboSinkerBarsGrade
				Dim num As Short = CShort(RODUTIL.ConvertListIndexToRodGrade(cboSinkerBarsGrade, Me.cboSinkerBarsGrade.SelectedIndex))
				Me.cboSinkerBarsGrade = cboSinkerBarsGrade
				RSWIN_DESC.SBGradeRod = num
				ini.SavePreferenceDataValue("SBGradeRod", RSWIN_DESC.SBGradeRod)
				RSWIN_DESC.SBRodType = Convert.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboSinkerBarsGrade.Items(Me.cboSinkerBarsGrade.SelectedIndex), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
				ini.SavePreferenceDataValue("SBRodType", RSWIN_DESC.SBRodType)
				Return
			End If
		End Sub

		Private Sub cboSinkerRodsGrade_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.cboSinkerRodsGradeSelectedIndexChanged(Me.cboSinkerRodsGrade Is Me.ActiveControl)
		End Sub

		Private Sub cboSinkerRodsGradeSelectedIndexChanged(bClicked As Boolean)
			If bClicked Then
				Dim cboSinkerRodsGrade As ComboBox = Me.cboSinkerRodsGrade
				Dim num As Short = CShort(RODUTIL.ConvertListIndexToRodGrade(cboSinkerRodsGrade, Me.cboSinkerRodsGrade.SelectedIndex))
				Me.cboSinkerRodsGrade = cboSinkerRodsGrade
				RSWIN_DESC.SBGradeRod = num
				ini.SavePreferenceDataValue("SBGradeRod", RSWIN_DESC.SBGradeRod)
				RSWIN_DESC.SBRodType = Convert.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboSinkerRodsGrade.Items(Me.cboSinkerRodsGrade.SelectedIndex), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
				ini.SavePreferenceDataValue("SBRodType", RSWIN_DESC.SBRodType)
				Return
			End If
		End Sub

		Private Sub txtMaxTubingSizeOD_TextChanged(sender As Object, e As EventArgs)
			Try
				If Me.ActiveControl IsNot Me.txtMaxTubingSizeOD AndAlso Versioned.IsNumeric(Me.txtMaxTubingSizeOD.Text) Then
					Dim txtMaxTubingSizeOD As TextBox = Me.txtMaxTubingSizeOD
					Dim num As Single = Convert.ToSingle(Me.txtMaxTubingSizeOD.Text)
					txtMaxTubingSizeOD.Text = Util.Format(num, Me.sFmt)
				End If
				Dim txtMaxTubingSizeOD2 As TextBox = Me.txtMaxTubingSizeOD
				Dim label_MaxTubingSizeOD As Label = Me._Label_MaxTubingSizeOD
				Me.TextBox_Change(txtMaxTubingSizeOD2, label_MaxTubingSizeOD)
				Me._Label_MaxTubingSizeOD = label_MaxTubingSizeOD
				Me.txtMaxTubingSizeOD = txtMaxTubingSizeOD2
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboMaxTubingSizeOD_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			Dim num As Single = Conversions.ToSingle(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 1, RSWIN_DESC.IN__MM))
			Me.sFmt = Conversions.ToString(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, "0.0##", "###.##"))
			Dim num2 As Short = CShort(Me.cboMaxTubingSizeOD.SelectedIndex)
			If num2 >= 0S And Me.cboMaxTubingSizeOD Is Me.ActiveControl Then
				If Me.nOD = 0S Then
					Me.OD = New String(0) {}
					Util.LoadMenu("TUBING-OD", Me.nOD, Me.OD)
				End If
				RSWIN_DESC.MaxTubingSizeOD = CSng(Conversion.Val(Me.OD(CInt((num2 + 1S)))))
				ini.SavePreferenceDataValue("MaxTubingSizeOD", RSWIN_DESC.MaxTubingSizeOD)
				Me.txtMaxTubingSizeOD.Tag = "mem"
				Me.txtMaxTubingSizeOD.Text = Conversions.ToString(RSWIN_DESC.MaxTubingSizeOD)
				Return
			End If
		End Sub

		Private Sub cboManufMenu1_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.cboManufMenu1 Is Me.ActiveControl Then
				RSWIN_DESC.set_PUManuf(1, Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu1.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing)))
				ini.SavePreferenceDataValue("PUManuf_Preference_1", RSWIN_DESC.get_PUManuf(1))
				Return
			End If
		End Sub

		Private Sub cboManufMenu2_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.cboManufMenu2 Is Me.ActiveControl Then
				RSWIN_DESC.set_PUManuf(2, Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu2.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing)))
				ini.SavePreferenceDataValue("PUManuf_Preference_2", RSWIN_DESC.get_PUManuf(2))
				Return
			End If
		End Sub

		Private Sub cboManufMenu3_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.cboManufMenu3 Is Me.ActiveControl Then
				RSWIN_DESC.set_PUManuf(3, Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu3.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing)))
				ini.SavePreferenceDataValue("PUManuf_Preference_3", RSWIN_DESC.get_PUManuf(3))
				Return
			End If
		End Sub

		Private Sub cboManufMenu4_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.cboManufMenu4 Is Me.ActiveControl Then
				RSWIN_DESC.set_PUManuf(4, Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu4.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing)))
				ini.SavePreferenceDataValue("PUManuf_Preference_4", RSWIN_DESC.get_PUManuf(4))
				Return
			End If
		End Sub

		Private Sub cboManufMenu5_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.cboManufMenu5 Is Me.ActiveControl Then
				RSWIN_DESC.set_PUManuf(5, Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu5.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing)))
				ini.SavePreferenceDataValue("PUManuf_Preference_5", RSWIN_DESC.get_PUManuf(5))
				Return
			End If
		End Sub

		Private Sub cboManufMenu6_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.cboManufMenu6 Is Me.ActiveControl Then
				RSWIN_DESC.set_PUManuf(6, Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu6.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing)))
				ini.SavePreferenceDataValue("PUManuf_Preference_6", RSWIN_DESC.get_PUManuf(6))
				Return
			End If
		End Sub

		Private Sub cboManufMenu7_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.cboManufMenu7 Is Me.ActiveControl Then
				RSWIN_DESC.set_PUManuf(7, Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu7.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing)))
				ini.SavePreferenceDataValue("PUManuf_Preference_7", RSWIN_DESC.get_PUManuf(7))
				Return
			End If
		End Sub

		Private Sub cboManufMenu8_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.cboManufMenu8 Is Me.ActiveControl Then
				RSWIN_DESC.set_PUManuf(8, Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu8.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing)))
				ini.SavePreferenceDataValue("PUManuf_Preference_8", RSWIN_DESC.get_PUManuf(8))
				Return
			End If
		End Sub

		Private Sub chkInsertPump_CheckedChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.bInsertPump = Me.chkInsertPump.Checked
			ini.SavePreferenceDataValue("bInsertPump", Convert.ToString(RSWIN_DESC.bInsertPump))
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkLargeBorePump_CheckedChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.bLargeBorePump = Me.chkLargeBorePump.Checked
			ini.SavePreferenceDataValue("bLargeBorePump", Convert.ToString(RSWIN_DESC.bLargeBorePump))
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkTubingPump_CheckedChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.bTubingPump = Me.chkTubingPump.Checked
			ini.SavePreferenceDataValue("bTubingPump", Convert.ToString(RSWIN_DESC.bTubingPump))
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkRodstarPumpTypeRec_CheckedChanged(sender As Object, e As EventArgs)
			If Me.chkRodstarPumpTypeRec.Checked Then
				Me.lblchkInsertPump_Disabled.BringToFront()
				Me.lblchkTubingPump_Disabled.BringToFront()
				Me.lblchkLargeBorePump_Disabled.BringToFront()
				RSWIN_DESC.SETUP_bRodstarPumpType = True
			Else
				Me.lblchkInsertPump_Disabled.SendToBack()
				Me.lblchkTubingPump_Disabled.SendToBack()
				Me.lblchkLargeBorePump_Disabled.SendToBack()
				RSWIN_DESC.SETUP_bRodstarPumpType = False
			End If
			ini.SavePreferenceDataValue("bRodstarPumpType", Convert.ToString(RSWIN_DESC.SETUP_bRodstarPumpType))
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkRodstarTubingSizeRec_CheckedChanged(sender As Object, e As EventArgs)
			If Me.chkRodstarTubingSizeRec.Checked Then
				Me.lblcboMaxTubingSizeOD_Disabled.BringToFront()
				Me.lblcboMinTubingSizeOD_Disabled.BringToFront()
				Me.lblcboCasingSize_Disabled.BringToFront()
				Me.chkFixTubingSize.Visible = False
				RSWIN_DESC.SETUP_UseXRODVTubingSizes = True
			Else
				Me.lblcboMaxTubingSizeOD_Disabled.SendToBack()
				Me.lblcboMinTubingSizeOD_Disabled.SendToBack()
				Me.lblcboCasingSize_Disabled.SendToBack()
				Me.chkFixTubingSize.Visible = True
				RSWIN_DESC.SETUP_UseXRODVTubingSizes = False
			End If
			ini.SavePreferenceDataValue("UseXRODVTubingSizes", Convert.ToString(RSWIN_DESC.SETUP_UseXRODVTubingSizes))
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkFixTubingSize_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkFixTubingSize Then
				RSWIN_DESC.SETUP_FixTubingSize = Me.chkFixTubingSize.Checked
				ini.SavePreferenceDataValue("FixTubingSize", Convert.ToString(RSWIN_DESC.SETUP_FixTubingSize))
				Try
					Me.ResetClock()
				Catch ex As Exception
				End Try
				Return
			End If
		End Sub

		Private Sub NumericUpDown1_XTimes_ValueChanged(sender As Object, e As EventArgs)
			If Me.NumericUpDown1_XTimes Is Me.ActiveControl Then
				RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = Convert.ToSingle(Me.NumericUpDown1_XTimes.Value)
				ini.SavePreferenceDataValue("TimesAvgRodTBGFricCoeff", RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff)
				If RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F Then
					RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff = True
				Else
					RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff = False
				End If
				ini.SavePreferenceDataValue("bUseAvgRodTBGFricCoeff", Convert.ToString(RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff))
				Try
					Me.ResetClock()
				Catch ex As Exception
				End Try
				Return
			End If
		End Sub

		Private Sub chkRodstarTubingAnchoredRec_CheckedChanged(sender As Object, e As EventArgs)
			If Me.chkRodstarTubingAnchoredRec.Checked Then
				Me.lblchkTubingAnchored_Disabled.BringToFront()
				RSWIN_DESC.SETUP_bRodstarTubingAnchored = True
			Else
				Me.lblchkTubingAnchored_Disabled.SendToBack()
				RSWIN_DESC.SETUP_bRodstarTubingAnchored = False
			End If
			ini.SavePreferenceDataValue("bRodstarTubingAnchored", Convert.ToString(RSWIN_DESC.SETUP_bRodstarTubingAnchored))
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkTubingAnchored_CheckedChanged(sender As Object, e As EventArgs)
			If Me.chkTubingAnchored.Enabled And Me.chkTubingAnchored.Visible Then
				If Me.chkTubingAnchored.Checked Then
					RSWIN_DESC.SETUP_bTubingAnchored = True
				Else
					RSWIN_DESC.SETUP_bTubingAnchored = False
				End If
				ini.SavePreferenceDataValue("bTubingAnchored", Convert.ToString(RSWIN_DESC.SETUP_bTubingAnchored))
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub rbtUseTemplateDatabase_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbtUseTemplateDatabase.Checked Then
				RSWIN_DESC.SETUP_bGuruUseTemplateDatabase = True
			Else
				RSWIN_DESC.SETUP_bGuruUseTemplateDatabase = False
			End If
			If Not RSWIN_DESC.bXRODAdmin Then
				RSWIN_DESC.SETUP_bGuruUseTemplateDatabase = True
			End If
			ini.SavePreferenceDataValue("bXRODUseTemplateDatabase", Convert.ToString(RSWIN_DESC.SETUP_bGuruUseTemplateDatabase))
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub rbtUseTemplateFiles_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbtUseTemplateFiles.Checked Then
				RSWIN_DESC.SETUP_bGuruUseTemplateDatabase = False
			Else
				RSWIN_DESC.SETUP_bGuruUseTemplateDatabase = True
			End If
			If Not RSWIN_DESC.bXRODAdmin Then
				RSWIN_DESC.SETUP_bGuruUseTemplateDatabase = True
			End If
			ini.SavePreferenceDataValue("bXRODUseTemplateDatabase", Convert.ToString(RSWIN_DESC.SETUP_bGuruUseTemplateDatabase))
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Util.BusyCursor()
			Me.ResetClock()
			Me.frmDisplayAllDatabaseTemplates.ShowDialog()
			Me.ResetClock()
			Util.UnbusyCursor()
		End Sub

		Private Sub LoadPumpingUnitManufacturers(index As Integer)
			Dim text As String = New String(" "c, 2)
			Try
				Dim fileName As String
				FILEUTIL.LocateFile("UNITINFO32.PUD", fileName, 2S, False, False, False, False)
				Dim num As Short
				Dim unitTypeInfo As RSWIN_DESC.UnitTypeInfo
				Dim num3 As Short
				Dim num4 As Short
				num = CShort(FileSystem.FreeFile())
				FileSystem.FileOpen(CInt(num), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
				Dim num2 As Short = CShort((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(unitTypeInfo))))
				Me.adiDefaults(index).items = ""
				num3 = 1S
				num4 = num2
				For num5 As Short = num3 To num4
					Dim fileNumber As Integer = CInt(num)
					Dim valueType As ValueType = unitTypeInfo
					FileSystem.FileGet(fileNumber, valueType, -1L)
					Dim valueType2 As ValueType = valueType
					Dim unitTypeInfo2 As RSWIN_DESC.UnitTypeInfo
					unitTypeInfo = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.UnitTypeInfo), unitTypeInfo2)
					Me.adiDefaults(index).items = Me.adiDefaults(index).items + unitTypeInfo.Manuf + ";"
				Next
				FileSystem.FileClose(New Integer() { CInt(num) })
			Catch ex As Exception
			End Try
		End Sub

		Public Sub LoadCustomToRodGradeListToCombo(ByRef cboRGList As ComboBox, iRodMatl As Integer, ByRef myAL As ArrayList, Optional bClearList As Boolean = True, Optional bAssignList As Boolean = True)
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Try
				If iRodMatl = 2 Then
				End If
				If bClearList Then
					myAL.Clear()
				End If
				Try
					Dim num4 As Integer = 1
					Dim num5 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
					For i As Integer = num4 To num5
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a unchecked-expression
						If(If(-If(((iRodMatl = 4) > False), 1S, 0S), 1S, 0S) And Not RSWIN_DESC.CustomRodGradeList(i).Steel) <> 0S Then
							num += 1
							RODUTIL.AddToArrayList(True, myAL, 16397 + num, RSWIN_DESC.CustomRodGradeList(i).RodType, 405 + num, "", "")
						ElseIf(If(-If(((iRodMatl = 0 Or iRodMatl = 1) > False), 1S, 0S), 1S, 0S) And RSWIN_DESC.CustomRodGradeList(i).Steel And Not RSWIN_DESC.CustomRodGradeList(i).SinkerBar) <> 0S Then
							num2 += 1
							RODUTIL.AddToArrayList(True, myAL, 4143 + num2, RSWIN_DESC.CustomRodGradeList(i).RodType, 25 + num2, "", "")
						ElseIf(RSWIN_DESC.CustomRodGradeList(i).Steel And If(-If(((iRodMatl = 1 Or iRodMatl = 0 Or iRodMatl = 2) > False), 1S, 0S), 1S, 0S)) <> 0S Then
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a unchecked-expression
							If(Not RSWIN_DESC.CustomRodGradeList(i).SinkerBar And If(-If(((iRodMatl = 1 Or iRodMatl = 0) > False), 1S, 0S), 1S, 0S)) <> 0S Then
								num2 += 1
								RODUTIL.AddToArrayList(True, myAL, 4143 + num2, RSWIN_DESC.CustomRodGradeList(i).RodType, 25 + num2, "", "")
							ElseIf(RSWIN_DESC.CustomRodGradeList(i).SinkerBar And If(-If(((iRodMatl = 2) > False), 1S, 0S), 1S, 0S)) <> 0S Then
								num3 += 1
								RODUTIL.AddToArrayList(True, myAL, 8311 + num3, RSWIN_DESC.CustomRodGradeList(i).RodType, 110 + num3, "", "")
							End If
						End If
					Next
				Catch ex As Exception
				End Try
				Dim comparer As RODUTIL.rgaComparer = New RODUTIL.rgaComparer()
				myAL.Sort(comparer)
				If bAssignList Then
					Util.DebugRodGradeArrayList(myAL)
					Try
						cboRGList.Items.Clear()
					Catch ex2 As Exception
					End Try
					Try
						cboRGList.DataSource = Nothing
					Catch ex3 As Exception
					End Try
					cboRGList.DataSource = myAL
					cboRGList.DisplayMember = "DisplayName"
					cboRGList.ValueMember = "RodGradeID"
				End If
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub rbtEnglish_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbtEnglish.Checked Then
				RSWIN_DESC.SETUP_MeasurementSystem = 1
				Dim text As String = "MeasurementSystem"
				Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text2 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				Dim text3 As String = text2
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
				Me.chkDisplaySBinFeet.Visible = False
				Me.chkAlwaysSaveXDIAGMeasuredCard.Top = Me.chkDisplaySBinFeet.Top
				If RSWIN_DESC.frmMain IsNot Nothing Then
					RSWIN_DESC.frmMain.btnMeasUnit.Text = "E"
				End If
				Try
					Me.ResetClock()
				Catch ex As Exception
				End Try
				Return
			End If
		End Sub

		Private Sub rbtCanadian_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbtCanadian.Checked Then
				RSWIN_DESC.SETUP_MeasurementSystem = 2
				Dim text As String = "MeasurementSystem"
				Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text2 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				Dim text3 As String = text2
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
				text3 = "DisplaySBinFeet"
				Dim flag As Boolean = True
				RSWIN_DESC.SETUP_DisplaySBinFeet = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_GENERAL, text3, flag) > False), 1S, 0S)), 1S, 0S)
				Me.chkDisplaySBinFeet.Checked = (RSWIN_DESC.SETUP_DisplaySBinFeet <> 0S)
				Me.chkDisplaySBinFeet.Visible = True
				Me.chkAlwaysSaveXDIAGMeasuredCard.Top = 72
				If RSWIN_DESC.frmMain IsNot Nothing Then
					RSWIN_DESC.frmMain.btnMeasUnit.Text = "C"
				End If
				Try
					Me.ResetClock()
				Catch ex As Exception
				End Try
			End If
		End Sub

		Private Sub rbtMetric_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbtMetric.Checked Then
				RSWIN_DESC.SETUP_MeasurementSystem = 3
				Dim text As String = "MeasurementSystem"
				Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text2 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				Dim text3 As String = text2
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
				Me.chkDisplaySBinFeet.Visible = False
				Me.chkAlwaysSaveXDIAGMeasuredCard.Top = Me.chkDisplaySBinFeet.Top
				If RSWIN_DESC.frmMain IsNot Nothing Then
					RSWIN_DESC.frmMain.btnMeasUnit.Text = "M"
				End If
				Try
					Me.ResetClock()
				Catch ex As Exception
				End Try
			End If
		End Sub

		Public Function SetManufMenuSelectIndex(Indx As Integer, iSelectedIndex As Integer) As String
			Dim result As String = ""
			Select Case Indx
				Case 1
					Me.cboManufMenu1.SelectedIndex = iSelectedIndex
					result = Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu1.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing))
				Case 2
					Me.cboManufMenu2.SelectedIndex = iSelectedIndex
					result = Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu2.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing))
				Case 3
					Me.cboManufMenu3.SelectedIndex = iSelectedIndex
					result = Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu3.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing))
				Case 4
					Me.cboManufMenu4.SelectedIndex = iSelectedIndex
					result = Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu4.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing))
				Case 5
					Me.cboManufMenu5.SelectedIndex = iSelectedIndex
					result = Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu5.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing))
				Case 6
					Me.cboManufMenu6.SelectedIndex = iSelectedIndex
					result = Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu6.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing))
				Case 7
					Me.cboManufMenu7.SelectedIndex = iSelectedIndex
					result = Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu7.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing))
				Case 8
					Me.cboManufMenu8.SelectedIndex = iSelectedIndex
					result = Conversions.ToString(NewLateBinding.LateGet(Me.cboManufMenu8.SelectedItem, Nothing, "Trim", New Object(-1) {}, Nothing, Nothing, Nothing))
			End Select
			Return result
		End Function

		Private Sub chkManufacturer1_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkManufacturer1 Then
				ini.SavePreferenceDataValue("Use_PUManuf_Preference_1", Convert.ToString(Me.chkManufacturer1.Checked))
				RSWIN_DESC.set_bUsePUManuf(1, Me.chkManufacturer1.Checked)
				Me.cboManufMenu1.Enabled = Me.chkManufacturer1.Checked
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkManufacturer2_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkManufacturer2 Then
				ini.SavePreferenceDataValue("Use_PUManuf_Preference_2", Convert.ToString(Me.chkManufacturer2.Checked))
				RSWIN_DESC.set_bUsePUManuf(2, Me.chkManufacturer2.Checked)
				Me.cboManufMenu2.Enabled = Me.chkManufacturer2.Checked
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkManufacturer3_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkManufacturer3 Then
				ini.SavePreferenceDataValue("Use_PUManuf_Preference_3", Convert.ToString(Me.chkManufacturer3.Checked))
				RSWIN_DESC.set_bUsePUManuf(3, Me.chkManufacturer3.Checked)
				Me.cboManufMenu3.Enabled = Me.chkManufacturer3.Checked
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkManufacturer4_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkManufacturer4 Then
				ini.SavePreferenceDataValue("Use_PUManuf_Preference_4", Convert.ToString(Me.chkManufacturer4.Checked))
				RSWIN_DESC.set_bUsePUManuf(4, Me.chkManufacturer4.Checked)
				Me.cboManufMenu4.Enabled = Me.chkManufacturer4.Checked
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkManufacturer5_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkManufacturer5 Then
				ini.SavePreferenceDataValue("Use_PUManuf_Preference_5", Convert.ToString(Me.chkManufacturer5.Checked))
				RSWIN_DESC.set_bUsePUManuf(5, Me.chkManufacturer5.Checked)
				Me.cboManufMenu5.Enabled = Me.chkManufacturer5.Checked
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkManufacturer6_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkManufacturer6 Then
				ini.SavePreferenceDataValue("Use_PUManuf_Preference_6", Convert.ToString(Me.chkManufacturer6.Checked))
				RSWIN_DESC.set_bUsePUManuf(6, Me.chkManufacturer6.Checked)
				Me.cboManufMenu6.Enabled = Me.chkManufacturer6.Checked
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkManufacturer7_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkManufacturer7 Then
				ini.SavePreferenceDataValue("Use_PUManuf_Preference_7", Convert.ToString(Me.chkManufacturer7.Checked))
				RSWIN_DESC.set_bUsePUManuf(7, Me.chkManufacturer7.Checked)
				Me.cboManufMenu7.Enabled = Me.chkManufacturer7.Checked
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkManufacturer8_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkManufacturer8 Then
				ini.SavePreferenceDataValue("Use_PUManuf_Preference_8", Convert.ToString(Me.chkManufacturer8.Checked))
				RSWIN_DESC.set_bUsePUManuf(8, Me.chkManufacturer8.Checked)
				Me.cboManufMenu8.Enabled = Me.chkManufacturer8.Checked
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkAIUseCustomizedLists_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.ActiveControl Is Me.chkAIUseCustomizedLists Then
				Dim bXRODUseCustomizedLists As Boolean = RSWIN_DESC.bXRODUseCustomizedLists
				RSWIN_DESC.bXRODUseCustomizedLists = Me.chkAIUseCustomizedLists.Checked
				ini.SavePreferenceDataValue("XRODUseCustomizedLists", Convert.ToString(RSWIN_DESC.bXRODUseCustomizedLists))
				If RSWIN_DESC.bXRODUseCustomizedLists Then
					Me.LoadCustomizedUnitListManufacturer()
					ini.SavePreferenceDataValue("XRODUseCustomizedLists", Convert.ToString(RSWIN_DESC.bXRODUseCustomizedLists))
				End If
				Me.pnlUseGeneral.Visible = Me.chkAIUseCustomizedLists.Checked
				If bXRODUseCustomizedLists <> RSWIN_DESC.bXRODUseCustomizedLists Then
					If RSWIN_DESC.bXRODUseCustomizedLists Then
						Dim num As Integer
						If Not Me.LoadCustomizedUnitListManufacturerLists(num) Then
							MessageBox.Show("No customized pumping unit lists found.")
							RSWIN_DESC.bXRODUseCustomizedLists = False
							Me.chkAIUseCustomizedLists.Checked = RSWIN_DESC.bXRODUseCustomizedLists
							ini.SavePreferenceDataValue("XRODUseCustomizedLists", Convert.ToString(RSWIN_DESC.bXRODUseCustomizedLists))
						ElseIf num > 0 Then
							Dim comboBox As ComboBox = Me.cboManufMenu1
							Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
							Me.cboManufMenu1 = comboBox
							comboBox = Me.cboManufMenu2
							Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
							Me.cboManufMenu2 = comboBox
							comboBox = Me.cboManufMenu3
							Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
							Me.cboManufMenu3 = comboBox
							comboBox = Me.cboManufMenu4
							Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
							Me.cboManufMenu4 = comboBox
							comboBox = Me.cboManufMenu5
							Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
							Me.cboManufMenu5 = comboBox
							comboBox = Me.cboManufMenu6
							Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
							Me.cboManufMenu6 = comboBox
							comboBox = Me.cboManufMenu7
							Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
							Me.cboManufMenu7 = comboBox
							comboBox = Me.cboManufMenu8
							Me.LoadManufMenuComboFromCustomizedLists(comboBox, False)
							Me.cboManufMenu8 = comboBox
						End If
					Else
						Me.CustomizedUnitTypeInfoList = New RSWIN_DESC.UnitTypeInfo(0) {}
						Dim comboBox As ComboBox = Me.cboManufMenu1
						Me.LoadManufMenuCombo(comboBox, False)
						Me.cboManufMenu1 = comboBox
						comboBox = Me.cboManufMenu2
						Me.LoadManufMenuCombo(comboBox, False)
						Me.cboManufMenu2 = comboBox
						comboBox = Me.cboManufMenu3
						Me.LoadManufMenuCombo(comboBox, False)
						Me.cboManufMenu3 = comboBox
						comboBox = Me.cboManufMenu4
						Me.LoadManufMenuCombo(comboBox, False)
						Me.cboManufMenu4 = comboBox
						comboBox = Me.cboManufMenu5
						Me.LoadManufMenuCombo(comboBox, False)
						Me.cboManufMenu5 = comboBox
						comboBox = Me.cboManufMenu6
						Me.LoadManufMenuCombo(comboBox, False)
						Me.cboManufMenu6 = comboBox
						comboBox = Me.cboManufMenu7
						Me.LoadManufMenuCombo(comboBox, False)
						Me.cboManufMenu7 = comboBox
						comboBox = Me.cboManufMenu8
						Me.LoadManufMenuCombo(comboBox, False)
						Me.cboManufMenu8 = comboBox
					End If
					Dim num2 As Integer = 1
					Do
						Dim index As Integer = num2
						Dim text As String = "Use_PUManuf_Preference_" + num2.ToString().Trim()
						Dim flag As Boolean = True
						RSWIN_DESC.set_bUsePUManuf(index, RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, text, flag))
						Dim obj As Object = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("PUManuf_Preference_" + num2.ToString().Trim(), 8, DBNull.Value))
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							If Strings.InStr(Conversions.ToString(obj), "American Conv. (100", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(obj), "American Conv. (less than 100", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(obj), "American (100", CompareMethod.Binary) > 0 Or Strings.InStr(Conversions.ToString(obj), "American (less than 100", CompareMethod.Binary) > 0 Then
								Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject("*", obj), "*"))
								obj = "American Conventional                   "
								ini.SavePreferenceDataValue("PUManuf_Preference_" + num2.ToString().Trim(), RuntimeHelpers.GetObjectValue(obj))
							End If
							RSWIN_DESC.set_PUManuf(num2, Conversions.ToString(obj))
							Dim flag2 As Boolean
							Me.SetManufMenuCbo(num2, RSWIN_DESC.get_PUManuf(num2), flag2)
							If Not flag2 Then
								RSWIN_DESC.set_bUsePUManuf(num2, False)
							End If
						ElseIf Not RSWIN_DESC.bXRODUseCustomizedLists Then
							RSWIN_DESC.set_PUManuf(num2, Me.SetManufMenuSelectIndex(num2, Me.GetManufMenuCboIndex(num2, "Lufkin Conventional - New               ")))
							ini.SavePreferenceDataValue("PUManuf_Preference_" + num2.ToString().Trim(), RSWIN_DESC.get_PUManuf(num2))
						ElseIf Information.UBound(Me.CustomizedUnitTypeInfoList, 1) > 0 Then
							RSWIN_DESC.set_PUManuf(num2, Me.SetManufMenuSelectIndex(num2, 0))
							ini.SavePreferenceDataValue("PUManuf_Preference_" + num2.ToString().Trim(), RSWIN_DESC.get_PUManuf(num2))
							RSWIN_DESC.set_bUsePUManuf(num2, False)
						End If
						Me.SetManufCheckboxEnabled(num2, True)
						Me.SetManufMenuCboEnabled(num2, RSWIN_DESC.get_bUsePUManuf(num2))
						num2 += 1
					Loop While num2 <= 8
					Me.chkManufacturer1.Checked = RSWIN_DESC.get_bUsePUManuf(1)
					Me.chkManufacturer2.Checked = RSWIN_DESC.get_bUsePUManuf(2)
					Me.chkManufacturer3.Checked = RSWIN_DESC.get_bUsePUManuf(3)
					Me.chkManufacturer4.Checked = RSWIN_DESC.get_bUsePUManuf(4)
					Me.chkManufacturer5.Checked = RSWIN_DESC.get_bUsePUManuf(5)
					Me.chkManufacturer6.Checked = RSWIN_DESC.get_bUsePUManuf(6)
					Me.chkManufacturer7.Checked = RSWIN_DESC.get_bUsePUManuf(7)
					Me.chkManufacturer8.Checked = RSWIN_DESC.get_bUsePUManuf(8)
					Me.cboManufMenu1.Enabled = Me.chkManufacturer1.Checked
					Me.cboManufMenu2.Enabled = Me.chkManufacturer2.Checked
					Me.cboManufMenu3.Enabled = Me.chkManufacturer3.Checked
					Me.cboManufMenu4.Enabled = Me.chkManufacturer4.Checked
					Me.cboManufMenu5.Enabled = Me.chkManufacturer5.Checked
					Me.cboManufMenu6.Enabled = Me.chkManufacturer6.Checked
					Me.cboManufMenu7.Enabled = Me.chkManufacturer7.Checked
					Me.cboManufMenu8.Enabled = Me.chkManufacturer8.Checked
				End If
				Return
			End If
		End Sub

		Public Sub LoadCustomizedUnitListManufacturer()
			Try
				Try
					Dim fileName As String
					FILEUTIL.LocateFile("UNITINFO32.PUD", fileName, 2S, False, False, False, False)
					Dim num As Short
					Dim unitTypeInfo As RSWIN_DESC.UnitTypeInfo
					Dim array As RSWIN_DESC.UnitTypeInfo()
					Dim num3 As Integer
					Dim text As String
					Dim num4 As Integer
					Dim num5 As Short
					Dim num6 As Short
					num = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
					Dim num2 As Short = CShort((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(unitTypeInfo))))
					array = New RSWIN_DESC.UnitTypeInfo(0) {}
					num3 = 0
					text = Strings.Space(16384)
					num4 = 0
					num5 = 1S
					num6 = num2
					For num7 As Short = num5 To num6
						Dim fileNumber As Integer = CInt(num)
						Dim valueType As ValueType = unitTypeInfo
						FileSystem.FileGet(fileNumber, valueType, -1L)
						Dim valueType2 As ValueType = valueType
						Dim unitTypeInfo2 As RSWIN_DESC.UnitTypeInfo
						unitTypeInfo = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.UnitTypeInfo), unitTypeInfo2)
						Dim expression As String
						FILEUTIL.LocateFile(Strings.RTrim(unitTypeInfo.Abbrev) + "32.PUD", expression, 0S, False, False, False, False)
						If Strings.Len(expression) > 0 Then
							If num3 = 0 Then
								array = New RSWIN_DESC.UnitTypeInfo(1) {}
							Else
								array = CType(Utils.CopyArray(CType(array, Array), New RSWIN_DESC.UnitTypeInfo(1 + num3 + 1 - 1) {}), RSWIN_DESC.UnitTypeInfo())
							End If
							num3 += 1
							array(num3) = unitTypeInfo
							Dim num8 As Integer = Custom.CustomPumpingUnitLists_SelectRow(unitTypeInfo.Abbrev.Trim(), text, False, "")
							Dim num9 As Short = CShort(text.Trim().Length)
							If num8 > 0 And num4 < 8 Then
								num4 += 1
								RSWIN_DESC.set_PUManuf(num4, array(num3).Manuf)
								ini.SavePreferenceDataValue("PUManuf_Preference_" + num4.ToString().Trim(), RSWIN_DESC.get_PUManuf(num4))
								Dim bVal As Boolean
								Me.SetManufMenuCbo(num4, RSWIN_DESC.get_PUManuf(num4), bVal)
								Me.SetManufCheckbox(num4, bVal)
								Me.SetManufCheckboxEnabled(num4, True)
								Me.SetManufMenuCboEnabled(num4, True)
							End If
						End If
					Next
					FileSystem.FileClose(New Integer() { CInt(num) })
					If num4 > 0 And num4 < 8 Then
						' The following expression was wrapped in a checked-expression
						For num7 As Short = CShort((num4 + 1))To 8S
							Me.SetManufCheckbox(CInt(num7), False)
						Next
					End If
				Catch ex As Exception
					Dim sMsg As String = "Error in LoadCustomizedUnitListManufacturer: " + ex.Message
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub optSideWinder_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.txtSidewinderLoad.Visible = Me.optSideWinder.Checked
			Me.txtNorrisFricCoeff.Visible = Me.optSideWinder.Checked
			If Me.optSideWinder.Checked Then
				Me.cboSidewinder.Enabled = True
			End If
			If Me.optSideWinder.Checked And Me.cboSidewinder.SelectedIndex <> -1 Then
				Dim flag As Boolean = True
				If flag = (Me.cboSidewinder.SelectedIndex = 0) Then
					RSWIN_DESC.SETUP_GuideToUse = 4
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 1) Then
					RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.NorrisSidewinderGuide)
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 2) Then
					RSWIN_DESC.SETUP_GuideToUse = 6
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 3) Then
					RSWIN_DESC.SETUP_GuideToUse = 7
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 4) Then
					RSWIN_DESC.SETUP_GuideToUse = 8
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 5) Then
					RSWIN_DESC.SETUP_GuideToUse = 9
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 6) Then
					RSWIN_DESC.SETUP_GuideToUse = 10
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 7) Then
					RSWIN_DESC.SETUP_GuideToUse = 11
				Else
					RSWIN_DESC.SETUP_GuideToUse = 5
				End If
				Dim text As String = "GuideToUse"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_GuideToUse)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(text2)
				If Me.optSideWinder.Checked Then
					Me.lblFricCoeff.Left = 350
					Me.lblSideLoadperRodGuide.Top = Me.cboSidewinder.Top - Me.lblSideLoadperRodGuide.Height
					Me.lblFricCoeff.Top = Me.lblSideLoadperRodGuide.Top
					Me.cmdResetFrictions.Top = Me.lblFricCoeff.Top
					Me.lblSideLoadperRodGuide.Visible = True
					Me.lblFricCoeff.Visible = True
				End If
				Me.txtNorrisFricCoeff.Text = Conversions.ToString(RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True))
				Me.SetDefaultSideloadLimit()
				If Me.ActiveControl Is Me.optSideWinder Then
					Me.CheckMinMaxNumberOfGuides()
				End If
				Return
			End If
		End Sub

		Private Sub optOther_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.ActiveControl Is Me.optOther Then
				RSWIN_DESC.SETUP_GuideToUse = 3
				Dim text As String = "GuideToUse"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_GuideToUse)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(text2)
				Me.SetDefaultSideloadLimit()
				Me.cboSidewinder.Enabled = False
			End If
			Me.txtOtherLoad.Visible = Me.optOther.Checked
			Me.txtOtherFricCoeff.Visible = Me.optOther.Checked
			If Me.optOther.Checked Then
				Me.lblSideLoadperRodGuide.Left = Me.txtOtherLoad.Left
				Me.lblSideLoadperRodGuide.Top = Me.optOther.Top - Me.lblSideLoadperRodGuide.Height
				Me.lblFricCoeff.Top = Me.lblSideLoadperRodGuide.Top
				Me.cmdResetFrictions.Top = Me.lblFricCoeff.Top
				Me.lblSideLoadperRodGuide.Visible = True
				Me.lblFricCoeff.Visible = True
				Me.lblFricCoeff.Left = 350
				Return
			End If
		End Sub

		Private Sub txtOther_TextChanged(sender As Object, e As EventArgs)
			Try
				If Me.ActiveControl Is Me.txtOther And Operators.CompareString(Me.txtOther.Text.Trim(), "", False) <> 0 Then
					Dim text As String = "OtherGuide"
					Dim text2 As String = Me.txtOther.Text.Trim()
					Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtMaxNumGuides_TextChanged(sender As Object, e As EventArgs)
			Try
				If Me.ActiveControl Is Me.txtMaxNumGuides AndAlso Versioned.IsNumeric(Me.txtMaxNumGuides.Text) Then
					RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(Me.txtMaxNumGuides.Text)
					Dim text As String = "MaxNumGuidesPerRod"
					Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod)
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
					RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(text2)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtMinNumGuides_Enter(sender As Object, e As EventArgs)
			Me.txtMinNumGuides.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtMinNumGuides_KeyDown(sender As Object, e As KeyEventArgs)
		End Sub

		Private Sub txtMinNumGuides_KeyPress(sender As Object, e As KeyPressEventArgs)
			Me.m_bSuppressMinMsg = False
		End Sub

		Private Sub txtMinNumGuides_Leave(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				If Versioned.IsNumeric(Me.txtMinNumGuides.Text) Then
					If RSWIN_DESC.SETUP_GuideToUse >= 6 Or RSWIN_DESC.SETUP_GuideToUse < 4 Then
						RSWIN_DESC.iMinGuide = 3
					ElseIf RSWIN_DESC.SETUP_GuideToUse >= 4 Then
						RSWIN_DESC.iMinGuide = 4
					Else
						RSWIN_DESC.iMinGuide = 3
					End If
					If Convert.ToInt32(Me.txtMinNumGuides.Text) >= Convert.ToInt32(Me.txtMaxNumGuides.Text) Then
						MessageBox.Show(RSWIN_DESC.sMinMustBeLessThanMax)
						Me.m_bSuppressMinMsg = True
						Me.txtMinNumGuides.Text = Conversions.ToString(Convert.ToInt32(Me.txtMaxNumGuides.Text) - 1)
					ElseIf Convert.ToInt32(Me.txtMinNumGuides.Text) <> RSWIN_DESC.iMinGuide Then
						Dim str As String
						If RSWIN_DESC.SETUP_GuideToUse < 4 Then
							str = String.Format(RSWIN_DESC.sGenericGuideMinWarning, 3)
						Else
							str = String.Format(RSWIN_DESC.sManufacturerGuideMinWarning, RSWIN_DESC.iMinGuide)
						End If
						If RSWIN_DESC.SETUP_GuideToUse < 4 Then
							If Convert.ToInt32(Me.txtMinNumGuides.Text) <= 0 And Not Me.m_bSuppressMinMsg Then
								MessageBox.Show(Conversions.ToString(RSWIN_DESC.sZeroMinGuidesNotAllowed))
								Me.m_bSuppressMinMsg = True
								Me.txtMinNumGuides.Text = "1"
							ElseIf Not Me.m_bSuppressMinMsg Then
								Dim msg As String = str + RSWIN_DESC.sAreYouSure
								Dim bDefaultYes As Boolean = False
								Dim flag As Boolean = False
								If Not Util.YesNo(msg, bDefaultYes, flag) Then
									Me.txtMinNumGuides.Text = RSWIN_DESC.iMinGuide.ToString()
								End If
							End If
						ElseIf Convert.ToInt32(Me.txtMinNumGuides.Text) < RSWIN_DESC.iMinGuide - 1 And Not Me.m_bSuppressMinMsg Then
							MessageBox.Show(String.Format(RSWIN_DESC.sOneMinusRecommended, RSWIN_DESC.iMinGuide, RSWIN_DESC.iMinGuide - 1))
							Me.m_bSuppressMinMsg = True
							Me.txtMinNumGuides.Text = Convert.ToString(RSWIN_DESC.iMinGuide - 1)
						ElseIf Not Me.m_bSuppressMinMsg Then
							Dim msg2 As String = str + RSWIN_DESC.sAreYouSure
							Dim bDefaultYes2 As Boolean = False
							Dim flag As Boolean = False
							If Not Util.YesNo(msg2, bDefaultYes2, flag) Then
								Me.txtMinNumGuides.Text = RSWIN_DESC.iMinGuide.ToString()
							End If
						End If
						RSWIN_DESC.SETUP_MinNumGuidesPerRod = Conversions.ToInteger(Me.txtMinNumGuides.Text)
						Dim text As String = "MinNumGuidesPerRod"
						Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_MinNumGuidesPerRod)
						RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
						RSWIN_DESC.SETUP_MinNumGuidesPerRod = Conversions.ToInteger(text2)
					End If
				End If
				Dim txtMinNumGuides As TextBox = Me.txtMinNumGuides
				Dim lblMinNumGuides As Label = Me.lblMinNumGuides
				CtrlUI.TextBox_LostFocus(txtMinNumGuides, lblMinNumGuides, True)
				Me.lblMinNumGuides = lblMinNumGuides
				Me.txtMinNumGuides = txtMinNumGuides
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtMinNumGuides_TextChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.txtMinNumGuides Then
				If Versioned.IsNumeric(Me.txtMinNumGuides.Text) Then
					RSWIN_DESC.SETUP_MinNumGuidesPerRod = Conversions.ToInteger(Me.txtMinNumGuides.Text)
					Dim text As String = "MinNumGuidesPerRod"
					Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_MinNumGuidesPerRod)
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
					RSWIN_DESC.SETUP_MinNumGuidesPerRod = Conversions.ToInteger(text2)
				End If
				Return
			End If
		End Sub

		Private Sub rtbDefault_Leave(sender As Object, e As EventArgs)
			If Me.iSaveIndex > 0 Then
				Dim array As RSWIN_DESC.DEFAULTITEM() = Me.adiDefaults
				Dim num As Integer = Me.iSaveIndex
				Dim rtbDefault As RichTextBox = Me.rtbDefault
				Dim text As String = rtbDefault.Text
				Dim num2 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, array(num).Name, text, RSWIN_DESC.sINIFile)
				rtbDefault.Text = text
				Dim obj As Object = num2
			End If
		End Sub

		Private Sub optPowerMeterType_1_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.optPowerMeterType_1.Checked Then
				RSWIN_DESC.SETUP_PowerMeterType = 1S
			ElseIf Me.optPowerMeterType_2.Checked Then
				RSWIN_DESC.SETUP_PowerMeterType = 2S
			End If
			ini.SavePreferenceDataValue("PowerMeterType", Convert.ToString(RSWIN_DESC.SETUP_PowerMeterType))
		End Sub

		Private Sub chkIncludeMotorSPV_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.ActiveControl Is Me.chkIncludeMotorSPV Then
				RSWIN_DESC.SETUP_IncludeMotorSPV = Me.chkIncludeMotorSPV.Checked
				ini.SavePreferenceDataValue("IncludeMotorSPV", Convert.ToString(RSWIN_DESC.SETUP_IncludeMotorSPV))
				Return
			End If
		End Sub

		Private Sub cboUHSProrod_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.cboUHSProrod Is Me.ActiveControl Then
				Dim comboBox As ComboBox = Me.cboUHSProrod
				Dim num As Short = CShort(RODUTIL.ConvertListIndexToRodGrade(comboBox, Me.cboUHSProrod.SelectedIndex))
				Me.cboUHSProrod = comboBox
				RSWIN_DESC.HSGradeRod = num
				If RSWIN_DESC.HSGradeRod = 24581S Or RSWIN_DESC.HSGradeRod = 24582S Then
					RSWIN_DESC.HSRodType = Convert.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.cboUHSProrod.Items(Me.cboUHSProrod.SelectedIndex), Nothing, "DisplayName", New Object(-1) {}, Nothing, Nothing, Nothing)))
					Dim cboHighStrengthRods As ComboBox = Me.cboHighStrengthRods
					comboBox = Me.cboHighStrengthRods
					Dim selectedIndex As Integer = CInt(RODUTIL.FindRodGrade(comboBox, RSWIN_DESC.HSGradeRod, RSWIN_DESC.HSRodType))
					Me.cboHighStrengthRods = comboBox
					cboHighStrengthRods.SelectedIndex = selectedIndex
					ini.SavePreferenceDataValue("HSGradeRod", RSWIN_DESC.HSGradeRod)
					ini.SavePreferenceDataValue("HSRodType", RSWIN_DESC.HSRodType)
				End If
				Return
			End If
		End Sub

		Private Sub chkDebug_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.chkDebug.Checked Then
				RSWIN_DESC.SETUP_bAdminDebug = True
			Else
				RSWIN_DESC.SETUP_bAdminDebug = False
			End If
			If RSWIN_DESC.bXRODAdmin Then
				ini.SavePreferenceDataValue("bXRODAdminDebug", Convert.ToString(RSWIN_DESC.SETUP_bAdminDebug))
				Return
			End If
			RSWIN_DESC.SETUP_bAdminDebug = False
		End Sub

		Private Sub txtServiceFactorPreference_TextChanged(sender As Object, e As EventArgs)
			Dim text As String = ""
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtServiceFactorPreference, True, False, obj) Then
				Dim txtServiceFactorPreference As TextBox = Me.txtServiceFactorPreference
				Dim lblServiceFactor As Label = Me.lblServiceFactor
				Me.TextBox_Change(txtServiceFactorPreference, lblServiceFactor)
				Me.lblServiceFactor = lblServiceFactor
				Me.txtServiceFactorPreference = txtServiceFactorPreference
				If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.SETUP_ServiceFactorPreference = Conversions.ToSingle(obj)
					ini.SavePreferenceDataValue("ServiceFactorPreference", RSWIN_DESC.SETUP_ServiceFactorPreference)
				End If
			End If
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				Dim flag2 As Boolean = False
				If Not Operators.ConditionalCompareObjectEqual(flag2, Util.CheckLower(obj, 0.5F, -1, 61, 0, 0, True, text), False) Then
					If Operators.ConditionalCompareObjectEqual(flag2, Util.CheckUpper(obj, 1F, -1, 61, 0, 0, True, text), False) Then
					End If
				End If
			End If
		End Sub

		Private Sub txtServiceFactorPreference_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtServiceFactorPreference, True, False, obj) Then
				Return
			End If
			Dim obj2 As Object = flag
			Dim lowerBound As Single = 0.5F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 61
			Dim useMetric As Integer = 0
			Dim canadianIsMetric As Integer = 0
			Dim bQuiet As Boolean = False
			Dim text As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Me.txtServiceFactorPreference.Focus()
				Return
			End If
			Dim obj3 As Object = flag
			Dim upperBound As Single = 1F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = 61
			Dim useMetric2 As Integer = 0
			Dim canadianIsMetric2 As Integer = 0
			Dim bQuiet2 As Boolean = False
			text = ""
			If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
				Me.txtServiceFactorPreference.Focus()
				Return
			End If
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.SETUP_ServiceFactorPreference = Conversions.ToSingle(obj)
				ini.SavePreferenceDataValue("ServiceFactorPreference", RSWIN_DESC.SETUP_ServiceFactorPreference)
			End If
		End Sub

		Private Sub cboSidewinder_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.cboSidewinder Then
				Dim flag As Boolean = True
				If flag = (Me.cboSidewinder.SelectedIndex = 0) Then
					RSWIN_DESC.SETUP_GuideToUse = 4
					Me.txtSidewinderLoad.Text = RSWIN_DESC.SETUP_NorrisStandardGuide_Load.ToString()
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 1) Then
					RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.NorrisSidewinderGuide)
					Me.txtSidewinderLoad.Text = RSWIN_DESC.SETUP_NorrisSidewinderGuide_Load.ToString()
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 2) Then
					RSWIN_DESC.SETUP_GuideToUse = 6
					Me.txtSidewinderLoad.Text = RSWIN_DESC.SETUP_RGIJakeCouplingGuide_Load.ToString()
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 3) Then
					RSWIN_DESC.SETUP_GuideToUse = 7
					Me.txtSidewinderLoad.Text = RSWIN_DESC.SETUP_RGISVTGuide_LOAD.ToString()
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 4) Then
					RSWIN_DESC.SETUP_GuideToUse = 8
					Me.txtSidewinderLoad.Text = RSWIN_DESC.SETUP_RGITomahawkGuide_LOAD.ToString()
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 5) Then
					RSWIN_DESC.SETUP_GuideToUse = 9
					Me.txtSidewinderLoad.Text = RSWIN_DESC.SETUP_RGITornadoGuide_LOAD.ToString()
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 6) Then
					RSWIN_DESC.SETUP_GuideToUse = 10
					Me.txtSidewinderLoad.Text = RSWIN_DESC.SETUP_RGITwisterGuide_LOAD.ToString()
				ElseIf flag = (Me.cboSidewinder.SelectedIndex = 7) Then
					RSWIN_DESC.SETUP_GuideToUse = 11
					Me.txtSidewinderLoad.Text = RSWIN_DESC.SETUP_RGIWVTGuide_LOAD.ToString()
				End If
				Me.txtNorrisFricCoeff.Text = Conversions.ToString(RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True))
				Dim text As String = "GuideToUse"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_GuideToUse)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(text2)
				If RSWIN_DESC.SETUP_GuideToUse >= 4 Then
					Me.SetDefaultSideloadLimit()
					If Me.ActiveControl Is Me.cboSidewinder Then
						Me.CheckMinMaxNumberOfGuides()
					End If
				End If
				Return
			End If
		End Sub

		Private Sub RswinSetup_Resize(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Screen.PrimaryScreen.Bounds.Width < 1100 Or Screen.PrimaryScreen.Bounds.Height < 800 Then
				If RSWIN_DESC.bExpert Then
					Me.StartPosition = FormStartPosition.Manual
					If Me.Height <> RSWIN_DESC.frmMain.Height And Me.Height <> RSWIN_DESC.frmMain.Height - 5 Then
						Me.Height = RSWIN_DESC.frmMain.Height - 5
					End If
				ElseIf Me.Height <> Me.pnlDefaults.Height + 40 Then
					Me.Height = Me.pnlDefaults.Height + 40
				End If
				If RSWIN_DESC.bExpert Then
					If Me.Width < 948 Then
						Me.Width = 948
					ElseIf Me.Width > RSWIN_DESC.frmMain.Width Then
						Me.Width = RSWIN_DESC.frmMain.Width
					End If
					If CDbl(Me.Left) <> CDbl(RSWIN_DESC.frmMain.Left) + CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0 Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						Me.Left = CInt(Math.Round(CDbl(RSWIN_DESC.frmMain.Left) + CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0))
					End If
					If Me.Top <> RSWIN_DESC.frmMain.Top Then
						Me.Top = RSWIN_DESC.frmMain.Top
					End If
				Else
					Me.StartPosition = FormStartPosition.CenterParent
					If Me.pnlExpert.Height <> Me.pnlDefaults.Height Then
						Me.pnlExpert.Height = Me.pnlDefaults.Height
					End If
				End If
				If Screen.PrimaryScreen.Bounds.Width < 1100 Then
					Me.btnOK.Left = 648
					Me.btnCancel.Left = 736
				End If
				If Not RSWIN_DESC.bExpert Then
					If Screen.PrimaryScreen.Bounds.Height < 700 Then
						Me.btnOK.Top = Me.Height - 70
					ElseIf Screen.PrimaryScreen.Bounds.Height < 800 Then
						Me.btnOK.Top = Me.Height - 70
					Else
						Me.btnOK.Top = Me.Height - 73
					End If
				End If
				Me.AutoScroll = True
				Dim startPoint As Object = Me.StartPoint
				Dim point As Point
				Me.AutoScrollPosition = If((startPoint IsNot Nothing), CType(startPoint, Point), point)
				If Screen.PrimaryScreen.Bounds.Height < 800 Then
					Me.pnlExpert.AutoScroll = True
					Dim pnlExpert As ScrollableControl = Me.pnlExpert
					Dim startPoint2 As Object = Me.StartPoint
					pnlExpert.AutoScrollPosition = If((startPoint2 IsNot Nothing), CType(startPoint2, Point), point)
				End If
				Me.btnCancel.Top = Me.btnOK.Top
				Me.btnOK.BringToFront()
				Me.btnCancel.BringToFront()
			Else
				If RSWIN_DESC.bRodStarD Then
					Try
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						If RSWIN_DESC.frmMain.Height - 240 > 600 Then
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							If CDbl(Me.Left) <> CDbl(RSWIN_DESC.frmMain.Left) + CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0 Or Me.Top <> RSWIN_DESC.frmMain.Top + 10 Or Me.Height <> 620 Then
								Me.StartPosition = FormStartPosition.Manual
								Me.Left = CInt(Math.Round(CDbl(RSWIN_DESC.frmMain.Left) + CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0))
								Me.Top = RSWIN_DESC.frmMain.Top + 80
								Me.Height = 620
								Me.btnOK.Top = Me.Height - 75
								Me.btnCancel.Top = Me.btnOK.Top
								Me.btnOK.BringToFront()
								Me.btnCancel.BringToFront()
								Me.AutoScroll = True
							End If
						ElseIf CDbl(Me.Left) <> CDbl(RSWIN_DESC.frmMain.Left) + CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0 Or Me.Top <> RSWIN_DESC.frmMain.Top + 10 Or Me.Height <> RSWIN_DESC.frmMain.Height - 230 Then
							Me.StartPosition = FormStartPosition.Manual
							Me.Left = CInt(Math.Round(CDbl(RSWIN_DESC.frmMain.Left) + CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0))
							Me.Top = RSWIN_DESC.frmMain.Top + 80
							Me.Height = RSWIN_DESC.frmMain.Height - 230
							Me.btnOK.Top = Me.Height - 75
							Me.btnCancel.Top = Me.btnOK.Top
							Me.btnOK.BringToFront()
							Me.btnCancel.BringToFront()
						End If
						GoTo IL_7B5
					Catch ex As Exception
						GoTo IL_7B5
					End Try
				End If
				If RSWIN_DESC.bExpert Then
					Try
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						If CDbl(Me.Left) <> CDbl(RSWIN_DESC.frmMain.Left) + CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0 Or Me.Top <> RSWIN_DESC.frmMain.Top + 100 Or Me.Height <> 752 Then
							Me.StartPosition = FormStartPosition.Manual
							Me.Left = CInt(Math.Round(CDbl(RSWIN_DESC.frmMain.Left) + CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0))
							Me.Top = RSWIN_DESC.frmMain.Top + 25
							Me.Height = Me.pnlExpert.Top + Me.pnlExpert.Height + 50
							Me.btnOK.BringToFront()
							Me.btnCancel.BringToFront()
						End If
						GoTo IL_7B5
					Catch ex2 As Exception
						GoTo IL_7B5
					End Try
				End If
				If Not(RSWIN_DESC.bExpert And RSWIN_DESC.bXRODAdmin) Then
					Try
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						If CDbl(Me.Left) <> CDbl(RSWIN_DESC.frmMain.Left) + CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0 Or Me.Top <> RSWIN_DESC.frmMain.Top + 100 Or Me.Height <> 522 Then
							Me.StartPosition = FormStartPosition.Manual
							Me.Left = CInt(Math.Round(CDbl(RSWIN_DESC.frmMain.Left) + CDbl((RSWIN_DESC.frmMain.Width - Me.Width)) / 2.0))
							Me.Top = RSWIN_DESC.frmMain.Top + 80
							Me.Height = 522
							Me.btnOK.Top = Me.Height - 85
							Me.btnCancel.Top = Me.btnOK.Top
							Me.btnOK.BringToFront()
							Me.btnCancel.BringToFront()
						End If
						If Me.Width < 948 And RSWIN_DESC.frmMain.Width >= 954 Then
							Me.Width = 948
						End If
					Catch ex3 As Exception
					End Try
				End If
			End If
			IL_7B5:
			If Me.btnCancel.Left <> Me.Width - Me.btnCancel.Width - 40 Then
				Me.btnCancel.Left = Me.Width - Me.btnCancel.Width - 50
			End If
			If Me.btnOK.Left <> Me.btnCancel.Left - Me.btnCancel.Width - 5 Then
				Me.btnOK.Left = Me.btnCancel.Left - Me.btnCancel.Width - 5
			End If
			If Me.Width > Screen.PrimaryScreen.Bounds.Width Then
				Me.Width = Screen.PrimaryScreen.Bounds.Width
			End If
		End Sub

		Private Sub chkDisplaySBinFeet_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				RSWIN_DESC.SETUP_DisplaySBinFeet = If((-If((Me.chkDisplaySBinFeet.Checked > False), 1S, 0S)), 1S, 0S)
				Dim text As String = "DisplaySBinFeet"
				Dim text2 As String = Convert.ToString(RSWIN_DESC.SETUP_DisplaySBinFeet)
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text2, RSWIN_DESC.sINIFile)
				Return
			End If
		End Sub

		Private Sub optUseSteelRodsOnly_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.optUseSteelRodsOnly.Checked Then
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = True
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = False
			ElseIf Me.optUseFGlassWithSteelOnBottom.Checked Then
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = True
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = False
			ElseIf Me.rbtUseBoth.Checked Then
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = True
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = True
			End If
			ini.SavePreferenceDataValue("bUseFGlassWithSteelOnBottom", Convert.ToString(RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom))
			ini.SavePreferenceDataValue("bUseSteelRodsOnly", Convert.ToString(RSWIN_DESC.SETUP_bUseSteelRodsOnly))
		End Sub

		Private Sub optUseFGlassWithSteelOnBottom_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.optUseSteelRodsOnly.Checked Then
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = True
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = False
			ElseIf Me.optUseFGlassWithSteelOnBottom.Checked Then
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = True
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = False
			ElseIf Me.rbtUseBoth.Checked Then
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = True
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = True
			End If
			ini.SavePreferenceDataValue("bUseFGlassWithSteelOnBottom", Convert.ToString(RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom))
			ini.SavePreferenceDataValue("bUseSteelRodsOnly", Convert.ToString(RSWIN_DESC.SETUP_bUseSteelRodsOnly))
		End Sub

		Private Sub chkRunTimeWarning_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.ActiveControl Is Me.chkRunTimeWarning Then
				RSWIN_DESC.SETUP_DisplayRuntimeWarning = If((-If((Me.chkRunTimeWarning.Checked > False), 1S, 0S)), 1S, 0S)
				Dim text As String = "DisplayRuntimeWarning"
				Dim text2 As String = Conversions.ToString(CInt(RSWIN_DESC.SETUP_DisplayRuntimeWarning))
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_DisplayRuntimeWarning = Conversions.ToShort(text2)
				Return
			End If
		End Sub

		Private Sub chkTargetBFPDWarning_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.ActiveControl Is Me.chkTargetBFPDWarning Then
				RSWIN_DESC.SETUP_DisplayTargetBFPDWarning = If((-If((Me.chkTargetBFPDWarning.Checked > False), 1S, 0S)), 1S, 0S)
				Dim text As String = "DisplayTargetBFPDWarning"
				Dim text2 As String = Conversions.ToString(CInt(RSWIN_DESC.SETUP_DisplayTargetBFPDWarning))
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_DisplayTargetBFPDWarning = Conversions.ToShort(text2)
				Return
			End If
		End Sub

		Private Sub btnOK_LocationChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub chkUseAllDiameters_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.ActiveControl Is Me.chkUseAllDiameters Then
				RSWIN_DESC.SETUP_UseAllDiameters = Me.chkUseAllDiameters.Checked
				Dim text As String = "UseAllDiameters"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_UseAllDiameters)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_UseAllDiameters = Conversions.ToBoolean(text2)
				Return
			End If
		End Sub

		Private Sub chkPlotAllDownholeCards_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.ActiveControl Is Me.chkPlotAllDownholeCards Then
				RSWIN_DESC.DEBUG_PlotAllDownholeCards = Me.chkPlotAllDownholeCards.Checked
				Dim text As String = "PlotAllDownholeCards"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.DEBUG_PlotAllDownholeCards)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEBUGGING, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.DEBUG_PlotAllDownholeCards = Conversions.ToBoolean(text2)
				Return
			End If
		End Sub

		Private Sub txtElectricityCostPreference_TextChanged(sender As Object, e As EventArgs)
			Dim text As String = ""
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtElectricityCostPreference, True, False, obj) Then
				Dim txtElectricityCostPreference As TextBox = Me.txtElectricityCostPreference
				Dim label_ElectricityCost As Label = Me._Label_ElectricityCost
				Me.TextBox_Change(txtElectricityCostPreference, label_ElectricityCost)
				Me._Label_ElectricityCost = label_ElectricityCost
				Me.txtElectricityCostPreference = txtElectricityCostPreference
				If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.SETUP_ElectricityCostPreference = Conversions.ToSingle(obj)
					ini.SavePreferenceDataValue("ElectricityCostPreference", RSWIN_DESC.SETUP_ElectricityCostPreference)
				End If
			End If
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				Dim flag2 As Boolean = False
				If Not Operators.ConditionalCompareObjectEqual(flag2, Util.CheckLower(obj, 0F, -1, 98, -1, -1, True, text), False) Then
					If Operators.ConditionalCompareObjectEqual(flag2, Util.CheckUpper(obj, 10F, -1, 97, -1, -1, True, text), False) Then
					End If
				End If
			End If
		End Sub

		Private Sub txtElectricityCostPreference_Leave(sender As Object, e As EventArgs)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtElectricityCostPreference, True, False, obj) Then
				Return
			End If
			Dim obj2 As Object = flag
			Dim lowerBound As Single = 0F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 98
			Dim useMetric As Integer = 0
			Dim canadianIsMetric As Integer = 0
			Dim bQuiet As Boolean = False
			Dim text As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Me.txtElectricityCostPreference.Focus()
				Return
			End If
			Dim obj3 As Object = flag
			Dim upperBound As Single = 10F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = 97
			Dim useMetric2 As Integer = 0
			Dim canadianIsMetric2 As Integer = 0
			Dim bQuiet2 As Boolean = False
			text = ""
			If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
				Me.txtElectricityCostPreference.Focus()
				Return
			End If
			If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj)) Then
				RSWIN_DESC.SETUP_ElectricityCostPreference = Conversions.ToSingle(obj)
				ini.SavePreferenceDataValue("ElectricityCostPreference", RSWIN_DESC.SETUP_ElectricityCostPreference)
			End If
		End Sub

		Private Sub chkAlwaysSaveXDIAGMeasuredCard_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.ActiveControl Is Me.chkAlwaysSaveXDIAGMeasuredCard Then
				RSWIN_DESC.SETUP_SaveXDIAGMeasuredCard = If((-If((Me.chkAlwaysSaveXDIAGMeasuredCard.Checked > False), 1S, 0S)), 1S, 0S)
				Dim text As String = "SaveXDIAGMeasuredCard"
				Dim text2 As String = Conversions.ToString(CInt(RSWIN_DESC.SETUP_SaveXDIAGMeasuredCard))
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_SaveXDIAGMeasuredCard = Conversions.ToShort(text2)
				Return
			End If
		End Sub

		Private Sub LoadTubingSizeList(OD As String(), fMaxTubingSize As Single, bSetIndex As Boolean)
			Me.LoadDiameterListFromMenu(Me.cboMaxTubingSizeOD, "TUBING-SIZE", "TUBING-SIZE-METRIC")
			For i As Integer = Me.cboMaxTubingSizeOD.Items.Count - 1 To 0 Step -1
				If OD <> Nothing And fMaxTubingSize <> 0F Then
					' The following expression was wrapped in a unchecked-expression
					If Strings.Len(RuntimeHelpers.GetObjectValue(Me.cboMaxTubingSizeOD.Items(i))) = 0 Or Conversion.Val(OD(i + 1)) > CDbl(fMaxTubingSize) + 1E-07 Then
						Me.cboMaxTubingSizeOD.Items.Remove(RuntimeHelpers.GetObjectValue(Me.cboMaxTubingSizeOD.Items(i)))
					End If
					If bSetIndex Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						If Math.Abs(CDbl(fMaxTubingSize) - Conversion.Val(OD(i + 1))) < 0.0001 Then
							Me.cboMaxTubingSizeOD.SelectedIndex = i
							RSWIN_DESC.MaxTubingSizeOD = CSng(Conversion.Val(OD(i + 1)))
							ini.SavePreferenceDataValue("MaxTubingSizeOD", RSWIN_DESC.MaxTubingSizeOD)
						End If
					End If
				ElseIf Strings.Len(RuntimeHelpers.GetObjectValue(Me.cboMaxTubingSizeOD.Items(i))) = 0 Then
					Me.cboMaxTubingSizeOD.Items.Remove(RuntimeHelpers.GetObjectValue(Me.cboMaxTubingSizeOD.Items(i)))
				End If
			Next
		End Sub

		Private Sub cboCasingSize_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.ActiveControl Is Me.cboCasingSize
			Dim num As Single = Conversions.ToSingle(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, 1, RSWIN_DESC.IN__MM))
			Me.sFmt = Conversions.ToString(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, "0.0##", "###.##"))
			Dim num2 As Short = CShort(Me.cboCasingSize.SelectedIndex)
			If num2 >= 0S And Me.cboCasingSize Is Me.ActiveControl Then
				RSWIN_DESC.MaxCasingSize = CSng(Conversion.Val(RSWIN_DESC.sCasingSizes(CInt(num2))))
				ini.SavePreferenceDataValue("MaxCasingSize", RSWIN_DESC.MaxCasingSize)
				Me.txtCasingSize.Tag = "mem"
				Me.txtCasingSize.Text = Conversions.ToString(RSWIN_DESC.MaxCasingSize)
			End If
			Dim fMaxTubingSize As Single
			Dim num3 As Single
			Dim num4 As Single
			Dim num5 As Single
			RODUTIL.GetSizeFromCasingSize(RSWIN_DESC.MaxCasingSize, fMaxTubingSize, num3, num4, num5, True)
			If Me.OD IsNot Nothing Then
				Me.LoadTubingSizeList(Me.OD, fMaxTubingSize, flag And num2 <> -1S)
				Return
			End If
		End Sub

		Private Sub chkExitIfIdle_CheckedChanged(sender As Object, e As EventArgs)
			If Me.chkExitIfIdle Is Me.ActiveControl Then
				RSWIN_DESC.SETUP_ExitIfIdle = If((-If((Me.chkExitIfIdle.Checked > False), 1S, 0S)), 1S, 0S)
				Me.udHour.Enabled = Me.chkExitIfIdle.Checked
				Me.udMin.Enabled = Me.chkExitIfIdle.Checked
				Me.lblExitIfIdle.Enabled = Me.chkExitIfIdle.Checked
				Me.chkSaveOpenFileOnExit.Enabled = Me.chkExitIfIdle.Checked
				RSWIN_DESC.SETUP_ExitIfIdle = If((-If((Me.chkExitIfIdle.Checked > False), 1S, 0S)), 1S, 0S)
				If Not RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
					Me.bEnd = False
					Me.tmrClock.Enabled = False
				End If
				Dim text As String = "ExitIfIdle"
				Dim text2 As String = Convert.ToString(RSWIN_DESC.SETUP_ExitIfIdle)
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text2, RSWIN_DESC.sINIFile)
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ResetClock()
			Try
				If RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
					Me.bEnd = False
					Me.tmrClock.Enabled = False
					Me.NowTime = DateAndTime.Now
					Me.tmrClock.Enabled = True
					Try
						If Me.MyParentFrm Is Nothing Then
							Try
								Me.MyParentFrm = RSWIN_DESC.frmMain
							Catch ex As Exception
							End Try
						End If
						Me.MyParentFrm.bEnd = False
						Me.MyParentFrm.tmrClock.Enabled = False
						Me.MyParentFrm.NowTime = DateAndTime.Now
						Me.MyParentFrm.tmrClock.Enabled = True
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub DisableTimeClock()
			Try
				Me.tmrClock.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		Private Sub Me_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_MouseDown(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_MouseEnter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_MouseMove(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_MouseUp(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_MouseWheel(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_Move(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_Scroll(sender As Object, e As ScrollEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_KeyUp(sender As Object, e As KeyEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_DragDrop(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_DragEnter(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub Me_LostFocus(sender As Object, e As EventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub Me_GotFocus(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Public Sub Control__LostFocus(ByRef cntrl As Control)
			CtrlUI.Control_LostFocus(cntrl)
			Me.ResetClock()
		End Sub

		Public Sub TextBox__LostFocus(ByRef txt As TextBox, Optional ByRef lbl As Label = Nothing, Optional bRequiredColor As Boolean = True)
			CtrlUI.TextBox_LostFocus(txt, lbl, bRequiredColor)
			Me.ResetClock()
		End Sub

		Public Sub TextBox__KeyDown(ByRef txt As TextBox, ByRef lbl As Label, KeyCode As Integer, Shift As Integer)
			CtrlUI.TextBox_KeyDown(txt, lbl, KeyCode, Shift)
			Me.ResetClock()
		End Sub

		Private Sub chkSaveOpenFileOnExit_CheckedChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.SETUP_SaveOpenFileOnExit = If((-If((Me.chkSaveOpenFileOnExit.Checked > False), 1S, 0S)), 1S, 0S)
		End Sub

		Private Sub chkUseDefaultRodElementLimit_CheckedChanged(sender As Object, e As EventArgs)
			If Me.chkUseDefaultRodElementLimit Is Me.ActiveControl Then
				RSWIN_DESC.SETUP_UseDefaultRodElementLimit = Me.chkUseDefaultRodElementLimit.Checked
				Me.lblRodElementLimit.Enabled = Not Me.chkUseDefaultRodElementLimit.Checked
				Me.txtRodElementLimit.Enabled = Not Me.chkUseDefaultRodElementLimit.Checked
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtRodElementLimit_TextChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.txtRodElementLimit AndAlso Versioned.IsNumeric(Me.txtRodElementLimit.Text) AndAlso Versioned.IsNumeric(Me.txtRodElementLimit.Text) Then
				RSWIN_DESC.SETUP_RodElementLimit = Convert.ToInt32(Me.txtRodElementLimit.Text)
			End If
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtMDInt_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.txtMDInt.Text) And Me.ActiveControl Is Me.txtMDInt Then
				RSWIN_DESC.SETUP_MDInt = Conversions.ToSingle(Me.txtMDInt.Text)
				Dim text As String = "MDInt"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_MDInt)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_MDInt = Conversions.ToSingle(text2)
				Return
			End If
		End Sub

		Private Sub txtDoglegLimit_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.txtDoglegLimit.Text) And Me.ActiveControl Is Me.txtDoglegLimit Then
				RSWIN_DESC.SETUP_DoglegLimit = Conversions.ToSingle(Me.txtDoglegLimit.Text)
				Dim text As String = "DoglegLimit"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_DoglegLimit)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_DoglegLimit = Conversions.ToSingle(text2)
				Return
			End If
		End Sub

		Private Sub pnlDefaults_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Private Sub grpSpreadSheetSetup_Enter(sender As Object, e As EventArgs)
		End Sub

		Private Sub chkExcelInstalled_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkExcelInstalled Then
				RSWIN_DESC.SETUP_ExcelInstalled = Me.chkExcelInstalled.Checked
				Dim text As String = "ExcelInstalled"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_ExcelInstalled)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_ExcelInstalled = Conversions.ToBoolean(text2)
				RSWIN_DESC.objExcel = Nothing
				If RSWIN_DESC.SETUP_ExcelInstalled Then
					RSWIN_DESC.objExcel = New ExcelXLS()
				Else
					RSWIN_DESC.objExcel = New ExcelXLS_Infragistics()
				End If
			End If
			Me.chkViewWK1.Enabled = Me.chkExcelInstalled.Checked
		End Sub

		Private Sub chkPrintResults_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkPrintResults Then
				RSWIN_DESC.SETUP_BatchPrintouts = If((-If((Me.chkPrintResults.Checked > False), 1, 0)), 1, 0)
				Dim text As String = "BatchPrintouts"
				Dim obj As Object = RSWIN_DESC.SETUP_BatchPrintouts
				Dim text2 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_BatchPrintouts = Conversions.ToInteger(obj)
				Dim text3 As String = text2
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text3, RSWIN_DESC.sINIFile)
				Return
			End If
		End Sub

		Private Sub _optCostCategory_2_VisibleChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub RswinSetup_SizeChanged(sender As Object, e As EventArgs)
			Debug.WriteLine(Me.Width)
		End Sub

		Public Function IsExcelInstalled() As Boolean
			Dim classesRoot As RegistryKey = Registry.ClassesRoot
			Dim result As Boolean
			Try
				Dim registryKey As RegistryKey = classesRoot.OpenSubKey("Excel.Application")
				result = (registryKey IsNot Nothing)
				registryKey.Close()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function IsExcelInstalled_2() As Boolean
			Dim num2 As Integer
			Dim flag2 As Boolean
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim flag As Boolean = False
				IL_05:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_0C:
				num = 3
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application", ""))
				IL_24:
				num = 4
				If Information.Err().Number = 0 Then
					GoTo IL_48
				End If
				IL_34:
				num = 5
				Information.Err().Clear()
				IL_41:
				num = 6
				flag = False
				IL_46:
				GoTo IL_6C
				IL_48:
				num = 8
				IL_4B:
				num = 9
				flag = True
				IL_51:
				num = 10
				NewLateBinding.LateCall(objectValue, Nothing, "Close", New Object(-1) {}, Nothing, Nothing, Nothing, True)
				IL_6C:
				ProjectData.ClearProjectError()
				num2 = 0
				IL_73:
				num = 13
				flag2 = flag
				IL_7E:
				IL_83:
				GoTo IL_116
				IL_88:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_D4:
				GoTo IL_10B
				IL_D6:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_E8:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_D6
			End Try
			IL_10B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_116:
			Dim result As Boolean = flag2
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Sub btnVerify_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.IsExcelInstalled()
			If Not flag Then
				flag = Me.IsExcelInstalled_2()
			End If
			If flag Then
				MessageBox.Show("Excel is installed.")
			Else
				MessageBox.Show("Excel is not installed")
			End If
		End Sub

		Private Sub rbtUseBoth_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.optUseSteelRodsOnly.Checked Then
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = True
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = False
			ElseIf Me.optUseFGlassWithSteelOnBottom.Checked Then
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = True
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = False
			ElseIf Me.rbtUseBoth.Checked Then
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = True
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = True
			End If
			ini.SavePreferenceDataValue("bUseFGlassWithSteelOnBottom", Convert.ToString(RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom))
			ini.SavePreferenceDataValue("bUseSteelRodsOnly", Convert.ToString(RSWIN_DESC.SETUP_bUseSteelRodsOnly))
		End Sub

		Private Sub txtNorrisFricCoeff_Enter(sender As Object, e As EventArgs)
			Me.txtNorrisFricCoeff.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtNorrisFricCoeff_Leave(sender As Object, e As EventArgs)
			Me.txtNorrisFricCoeff.BackColor = RSWIN_DESC.rgbEditComplete
		End Sub

		Private Sub txtNorrisFricCoeff_TextChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.txtNorrisFricCoeff Then
				If Versioned.IsNumeric(Me.txtNorrisFricCoeff.Text) Then
					Select Case Me.cboSidewinder.SelectedIndex
						Case 0
							RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = Conversions.ToSingle(Me.txtNorrisFricCoeff.Text)
							Dim text As String = "NorrisStandardGuideFricCoeff"
							Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = Conversions.ToSingle(text2)
						Case 1
							RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = Conversions.ToSingle(Me.txtNorrisFricCoeff.Text)
							Dim text2 As String = "NorrisSidewinderGuideFricCoeff"
							Dim text As String = Conversions.ToString(RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = Conversions.ToSingle(text)
						Case 2
							RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = Conversions.ToSingle(Me.txtNorrisFricCoeff.Text)
							Dim text2 As String = "RGIJakeCouplingGuideFricCoeff"
							Dim text As String = Conversions.ToString(RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = Conversions.ToSingle(text)
						Case 3
							RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = Conversions.ToSingle(Me.txtNorrisFricCoeff.Text)
							Dim text2 As String = "RGISVTGuideFricCoeff"
							Dim text As String = Conversions.ToString(RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = Conversions.ToSingle(text)
						Case 4
							RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = Conversions.ToSingle(Me.txtNorrisFricCoeff.Text)
							Dim text2 As String = "RGITomahawkGuideFricCoeff"
							Dim text As String = Conversions.ToString(RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = Conversions.ToSingle(text)
						Case 5
							RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = Conversions.ToSingle(Me.txtNorrisFricCoeff.Text)
							Dim text2 As String = "RGITornadoGuideFricCoeff"
							Dim text As String = Conversions.ToString(RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = Conversions.ToSingle(text)
						Case 6
							RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = Conversions.ToSingle(Me.txtNorrisFricCoeff.Text)
							Dim text2 As String = "RGITwisterGuideFricCoeff"
							Dim text As String = Conversions.ToString(RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = Conversions.ToSingle(text)
						Case 7
							RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = Conversions.ToSingle(Me.txtNorrisFricCoeff.Text)
							Dim text2 As String = "RGIWVTGuideFricCoeff"
							Dim text As String = Conversions.ToString(RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = Conversions.ToSingle(text)
					End Select
				End If
				Return
			End If
		End Sub

		Private Sub txtMoldedFricCoeff_Enter(sender As Object, e As EventArgs)
			Me.txtMoldedFricCoeff.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtMoldedFricCoeff_Leave(sender As Object, e As EventArgs)
			Me.txtMoldedFricCoeff.BackColor = RSWIN_DESC.rgbEditComplete
		End Sub

		Private Sub txtMoldedFricCoeff_TextChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.txtMoldedFricCoeff Then
				RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = Conversions.ToSingle(Me.txtMoldedFricCoeff.Text)
				Dim text As String = "MoldedFricCoeff"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = Conversions.ToSingle(text2)
			End If
		End Sub

		Private Sub txtWheelFricCoeff_Enter(sender As Object, e As EventArgs)
			Me.txtWheelFricCoeff.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtWheelFricCoeff_Leave(sender As Object, e As EventArgs)
			Me.txtWheelFricCoeff.BackColor = RSWIN_DESC.rgbEditComplete
		End Sub

		Private Sub txtWheelFricCoeff_TextChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.txtWheelFricCoeff Then
				RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = Conversions.ToSingle(Me.txtWheelFricCoeff.Text)
				Dim text As String = "WheelFricCoeff"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = Conversions.ToSingle(text2)
			End If
		End Sub

		Private Sub txtOtherFricCoeff_Enter(sender As Object, e As EventArgs)
			Me.txtOtherFricCoeff.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtOtherFricCoeff_Leave(sender As Object, e As EventArgs)
			Me.txtOtherFricCoeff.BackColor = RSWIN_DESC.rgbEditComplete
		End Sub

		Private Sub txtOtherFricCoeff_TextChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.txtOtherFricCoeff Then
				RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = Conversions.ToSingle(Me.txtOtherFricCoeff.Text)
				Dim text As String = "OtherFricCoeff"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = Conversions.ToSingle(text2)
			End If
		End Sub

		Private Sub txtSidewinderLoad_Enter(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtSidewinderLoad_Leave(sender As Object, e As EventArgs)
			Me.SetDefaultSideloadLimit()
		End Sub

		Private Sub txtSidewinderLoad_TextChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtSidewinderLoad_VisibleChanged(sender As Object, e As EventArgs)
			Me.txtNorrisFricCoeff.Visible = Me.txtSidewinderLoad.Visible
		End Sub

		Private Sub txtBareRodFricCoeff_Enter(sender As Object, e As EventArgs)
			Me.txtBareRodFricCoeff.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtBareRodFricCoeff_Leave(sender As Object, e As EventArgs)
			Me.txtBareRodFricCoeff.BackColor = RSWIN_DESC.rgbEditComplete
		End Sub

		Private Sub txtBareRodFricCoeff_TextChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.txtBareRodFricCoeff Then
				If Versioned.IsNumeric(Me.txtBareRodFricCoeff.Text) Then
					RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = Conversions.ToSingle(Me.txtBareRodFricCoeff.Text)
					Dim text As String = "BareRodFricCoeff"
					Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_BAREROD_FRICCOEFF)
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
					RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = Conversions.ToSingle(text2)
				End If
				Return
			End If
		End Sub

		Private Sub cmdResetFrictions_Click(sender As Object, e As EventArgs)
			Try
				RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = 0.2F
				Dim text As String = "BareRodFricCoeff"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_BAREROD_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = Conversions.ToSingle(text2)
				RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = RSWIN_DESC.fDefaultFricCoeff
				text2 = "MoldedFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = RSWIN_DESC.fDefaultFricCoeff
				text2 = "WheelFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = RSWIN_DESC.fDefaultFricCoeff
				text2 = "OtherFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "NorrisStandardGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "NorrisSidewinderGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "RGIJakeCouplingGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "RGISVTGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "RGITomahawkGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "RGITornadoGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "RGITwisterGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "RGIWVTGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = Conversions.ToSingle(text)
				Me.txtMoldedFricCoeff.Text = Conversions.ToString(RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF)
				Me.txtWheelFricCoeff.Text = Conversions.ToString(RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF)
				Me.txtOtherFricCoeff.Text = Conversions.ToString(RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF)
				Me.txtBareRodFricCoeff.Text = Conversions.ToString(RSWIN_DESC.SETUP_BAREROD_FRICCOEFF)
				Me.txtNorrisFricCoeff.Text = Conversions.ToString(RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True))
				RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD = 40F
				text2 = "MoldedLoad"
				text = Conversions.ToString(RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD = Conversions.ToSingle(text)
				Me.txtMoldedLoad.Text = RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD.ToString()
				RSWIN_DESC.SETUP_WHEELGUIDE_LOAD = 25F
				text2 = "WheelLoad"
				text = Conversions.ToString(RSWIN_DESC.SETUP_WHEELGUIDE_LOAD)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_WHEELGUIDE_LOAD = Conversions.ToSingle(text)
				Me.txtWheelLoad.Text = RSWIN_DESC.SETUP_WHEELGUIDE_LOAD.ToString()
				If Me.optMolded.Checked Or Me.optWheel.Checked Then
					Me.SetDefaultSideloadLimit()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub chkUseGeneral_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.ActiveControl Is Me.chkUseGeneral Then
				RSWIN_DESC.bXRODUseGeneralList = Me.chkUseGeneral.Checked
				ini.SavePreferenceDataValue("XRODUseGeneralList", Convert.ToString(RSWIN_DESC.bXRODUseGeneralList))
				If RSWIN_DESC.bXRODUseGeneralList Then
					Me.chkUseClosestUnit.Checked = False
					RSWIN_DESC.bXRODUseClosestUnit = False
					ini.SavePreferenceDataValue("XRODUseClosestUnit", Convert.ToString(RSWIN_DESC.bXRODUseClosestUnit))
				End If
				Return
			End If
		End Sub

		Private Sub chkUseClosestUnit_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If Me.ActiveControl Is Me.chkUseClosestUnit Then
				RSWIN_DESC.bXRODUseClosestUnit = Me.chkUseClosestUnit.Checked
				ini.SavePreferenceDataValue("XRODUseClosestUnit", Convert.ToString(RSWIN_DESC.bXRODUseClosestUnit))
				If RSWIN_DESC.bXRODUseClosestUnit Then
					Me.chkUseGeneral.Checked = False
					RSWIN_DESC.bXRODUseGeneralList = False
					ini.SavePreferenceDataValue("XRODUseGeneralList", Convert.ToString(RSWIN_DESC.bXRODUseGeneralList))
				End If
				Return
			End If
		End Sub

		Private Sub btnBrowseForServerFolder_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			Dim text As String = ""
			Dim sCaption As String = Me.sSelectServerDBFolder
			Me.ResetClock()
			Dim text2 As String = Me.BrowseForFolder(sCaption, text)
			If Operators.CompareString(text2, "", False) <> 0 Then
				Me.txtDBServerFolder.Text = text2
				Return
			End If
		End Sub

		Private Sub rptUseLocalDatabase_CheckedChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.SETUP_UseDefaultDBLocation = Me.rptUseLocalDatabase.Checked
			Dim text As String = "UseDefaultDBLocation"
			Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_UseDefaultDBLocation)
			RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text2, RSWIN_DESC.sINIFile)
			RSWIN_DESC.SETUP_UseDefaultDBLocation = Conversions.ToBoolean(text2)
		End Sub

		Private Sub rbtUseServerLocation_CheckedChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.SETUP_UseServerDBLocation = Me.rbtUseServerLocation.Checked
			Dim text As String = "UseServerDBLocation"
			Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_UseServerDBLocation)
			RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text2, RSWIN_DESC.sINIFile)
			RSWIN_DESC.SETUP_UseServerDBLocation = Conversions.ToBoolean(text2)
			Me.lblDBServerFolder.Enabled = Me.rbtUseServerLocation.Checked
			Me.txtDBServerFolder.Enabled = Me.lblDBServerFolder.Enabled
			Me.btnBrowseForServerFolder.Enabled = Me.lblDBServerFolder.Enabled
			Me.btnVerifyFiles.Enabled = (Me.lblDBServerFolder.Enabled And Operators.CompareString(RSWIN_DESC.SETUP_ServerDBLocation.Trim(), "", False) <> 0)
			Me.btnVerifyData.Enabled = Me.btnVerifyFiles.Enabled
			Me.btnSynch.Enabled = Me.btnVerifyFiles.Enabled
		End Sub

		Private Sub txtDBServerFolder_TextChanged(sender As Object, e As EventArgs)
			RSWIN_DESC.SETUP_ServerDBLocation = Me.txtDBServerFolder.Text
			Dim text As String = "ServerDBLocation"
			Dim setup_ServerDBLocation As String = RSWIN_DESC.SETUP_ServerDBLocation
			RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, setup_ServerDBLocation, RSWIN_DESC.sINIFile)
			RSWIN_DESC.SETUP_ServerDBLocation = setup_ServerDBLocation
		End Sub

		Private Sub btnVerifyFiles_Click(sender As Object, e As EventArgs)
			Try
				Dim str As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\" + VERSION1.ProgramName() + "\"
				Dim array As String() = New String(4) {}
				Dim array2 As String() = New String(4) {}
				Dim num As Integer = 4
				array(1) = "RODSTAR.CDB"
				array(2) = "CUSTOM32.PUD"
				array(3) = "xre.mdb"
				array(4) = Conversions.ToString(RSWIN_DESC.sCustomDBFileName)
				array2(1) = ""
				array2(2) = ""
				array2(3) = ""
				array2(4) = ""
				Dim flag As Boolean = True
				Dim num2 As Integer = 0
				Dim num3 As Short = 1S
				Dim num4 As Short = CShort(num)
				For num5 As Short = num3 To num4
					Dim text As String = array(CInt(num5))
					If num5 = 3S And Not RSWIN_DESC.bExpert Then
						Debug.WriteLine("skip XROD-V database is not XROD-V")
					Else
						Dim fileInfo As FileInfo = New FileInfo(RSWIN_DESC.SETUP_ServerDBLocation.Trim() + "\" + text)
						If fileInfo.Exists Then
							Dim text2 As String = RSWIN_DESC.SETUP_ServerDBLocation.Trim() + "\" + text
						Else
							flag = False
							num2 += 1
							array2(num2) = array(CInt(num5))
						End If
					End If
				Next
				If Not flag Then
					Dim msg As String = "Not all user databases are in server location " + RSWIN_DESC.SETUP_ServerDBLocation + ". Do you want the program to locate and copy files to server location?"
					Dim bDefaultYes As Boolean = False
					Dim flag2 As Boolean = False
					If Util.YesNo(msg, bDefaultYes, flag2) Then
						Dim num6 As Short = 1S
						Dim num7 As Short = CShort(num2)
						Dim num5 As Short = num6
						While num5 <= num7
							Dim text As String = array2(CInt(num5))
							Dim fileInfo As FileInfo = New FileInfo(str + text)
							If fileInfo.Exists Then
								Try
									File.Copy(str + text, RSWIN_DESC.SETUP_ServerDBLocation + "\" + text)
									GoTo IL_214
								Catch ex As Exception
									MessageBox.Show(ex.Message)
									GoTo IL_214
								End Try
								GoTo IL_1AE
							End If
							GoTo IL_1AE
							IL_214:
							num5 += 1S
							Continue While
							IL_1AE:
							Dim fileInfo2 As FileInfo = New FileInfo(Application.StartupPath + "\" + text)
							If fileInfo2.Exists Then
								Try
									File.Copy(Application.StartupPath + "\" + text, RSWIN_DESC.SETUP_ServerDBLocation + "\" + text)
								Catch ex2 As Exception
									MessageBox.Show(ex2.Message)
								End Try
								GoTo IL_214
							End If
							GoTo IL_214
						End While
					End If
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub btnVerifyData_Click(sender As Object, e As EventArgs)
			Dim num As Integer = 0
			Dim text As String = ""
			Dim text2 As String = ""
			Dim text3 As String = ""
			Dim text4 As String = ""
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim text5 As String = ""
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = False
			Dim flag5 As Boolean = False
			Dim flag6 As Boolean = False
			Dim flag7 As Boolean = False
			Dim flag8 As Boolean = False
			Dim flag9 As Boolean = False
			Dim flag10 As Boolean = False
			Dim flag11 As Boolean = False
			Dim text6 As String = ""
			Try
				FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), text2, 2S, False, False, False, True)
				FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sCustomDBFileName), text, 2S, False, False, True, False)
				If Operators.CompareString(text2.Trim(), "", False) <> 0 Then
					flag8 = True
				End If
				If Operators.CompareString(text.Trim(), "", False) <> 0 Then
					flag10 = True
				End If
				FILEUTIL.LocateFile("CUSTOM32.PUD", text3, 2S, False, False, False, True)
				FILEUTIL.LocateFile("CUSTOM32.PUD", text4, 2S, False, False, True, False)
				If Operators.CompareString(text3.Trim(), "", False) <> 0 Then
					flag9 = True
				End If
				If Operators.CompareString(text4.Trim(), "", False) <> 0 Then
					flag11 = True
				End If
				Dim array As RSWIN_DESC.CustomPumpUnitList()
				Dim array2 As RSWIN_DESC.CustomRodGrade()
				Dim array3 As RSWIN_DESC.CustomPumpUnitList()
				Try
					If flag8 Then
						Custom.LoadCustomRodGradeList(RSWIN_DESC.CustomRodGradeList, True, text2)
						Custom.LoadCustomizedPumpingUnitLists(array, True, text2)
						If flag10 Then
							Custom.LoadCustomRodGradeList(array2, True, text)
							Custom.LoadCustomizedPumpingUnitLists(array3, True, text)
							flag = True
						Else
							MessageBox.Show("Local database (CustomRGPU.mdb) not found !")
						End If
					Else
						MessageBox.Show("You're not connected to server or database (CustomRGPU.mdb) not found in server location!")
					End If
				Catch ex As Exception
				End Try
				If flag Then
					Try
						Dim num2 As Integer = 0
						Dim num3 As Integer = Information.UBound(array2, 1)
						Dim num4 As Integer = 1
						Dim num5 As Integer = num3
						For i As Integer = num4 To num5
							If array2(i).RodType IsNot Nothing AndAlso Operators.CompareString(array2(i).RodType.Trim(), "", False) <> 0 AndAlso Conversions.ToBoolean(Operators.NotObject(Me.IsInCustomRodGradeDB(array2(i), RSWIN_DESC.CustomRodGradeList))) Then
								Custom.CustomRodGrades_DBAddRow(array2(i), True, text2)
								num2 += 1
								flag3 = True
							End If
						Next
					Catch ex2 As Exception
					End Try
					Try
						Dim num2 As Integer = 0
						Dim num3 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
						Dim num6 As Integer = 1
						Dim num7 As Integer = num3
						For i As Integer = num6 To num7
							If RSWIN_DESC.CustomRodGradeList(i).RodType IsNot Nothing AndAlso Operators.CompareString(RSWIN_DESC.CustomRodGradeList(i).RodType.Trim(), "", False) <> 0 AndAlso Conversions.ToBoolean(Operators.NotObject(Me.IsInCustomRodGradeDB(RSWIN_DESC.CustomRodGradeList(i), array2))) Then
								num2 += 1
								flag4 = True
							End If
						Next
					Catch ex3 As Exception
					End Try
					Try
						Dim num2 As Integer = 0
						Dim num3 As Integer = Information.UBound(array3, 1)
						Dim num8 As Integer = 1
						Dim num9 As Integer = num3
						For i As Integer = num8 To num9
							If array3(i).Manufacturer IsNot Nothing AndAlso Operators.CompareString(array3(i).Manufacturer.Trim(), "", False) <> 0 Then
								If Conversions.ToBoolean(Operators.NotObject(Me.IsInCustomPumpingUnitList(array, array3(i), num))) Then
									Custom.CustomPumpingUnitLists_DBAddRow(array3(i).Manufacturer.Trim(), array3(i).Data.Trim(), True, text2)
									num2 += 1
									flag5 = True
								ElseIf num > 0 AndAlso Operators.CompareString(array(num).Data.Trim(), array3(i).Data.Trim(), False) <> 0 Then
									Dim text7 As String = Custom.MergeUnitLists(array(num).Data.Trim(), array3(i).Data.Trim())
									Custom.CustomPumpingUnitLists_DBUpdateRow(array(num).Manufacturer.Trim(), text7.Trim(), False, "")
									flag6 = True
								End If
							End If
						Next
					Catch ex4 As Exception
					End Try
				End If
				Dim array4 As RSWIN_DESC.PUDataRec()
				Dim array6 As RSWIN_DESC.PUDataRec()
				Try
					If flag9 Then
						Dim array5 As Integer()
						CUSTOMPU.GetCustomUnitNames(array4, array5, text3)
						If flag11 Then
							Dim array7 As Integer()
							CUSTOMPU.GetCustomUnitNames(array6, array7, text4)
							flag2 = True
						Else
							MessageBox.Show("Local database (CUSTOM32.PUD) not found !")
						End If
					Else
						MessageBox.Show("You're not connected to server or database (CUSTOM32.PUD) not found in server location!")
					End If
				Catch ex5 As Exception
				End Try
				If flag2 Then
					Try
						Dim num2 As Integer = 0
						Dim num3 As Integer = Information.UBound(array6, 1)
						Dim num10 As Integer = 1
						Dim num11 As Integer = num3
						For i As Integer = num10 To num11
							If array6(i).Manuf IsNot Nothing AndAlso Operators.CompareString(array6(i).Manuf.Trim(), "", False) <> 0 Then
								If Conversions.ToBoolean(Operators.NotObject(Me.IsInCustomUnits(array4, array6(i), num))) Then
									CUSTOMPU.AddCustomPU(array6(i), text5, True)
									num2 += 1
									flag7 = True
								ElseIf num > 0 AndAlso Not Me.AreUnitsEqual(array6(i), array4(num)) Then
									Dim dlgCustomUnitComparison As dlgCustomUnitComparison = New dlgCustomUnitComparison()
									Dim dlgCustomUnitComparison2 As dlgCustomUnitComparison = dlgCustomUnitComparison
									dlgCustomUnitComparison2.StartPosition = FormStartPosition.CenterParent
									dlgCustomUnitComparison2.LocalUnit = array6(i)
									dlgCustomUnitComparison2.ServerUnit = array4(num)
									dlgCustomUnitComparison2.ShowDialog()
									If dlgCustomUnitComparison2.bUseServerUnit Then
										flag7 = True
									ElseIf dlgCustomUnitComparison2.bUseLocalUnit Then
										CUSTOMPU.UpdateCustomPU(array6(i), num)
										flag7 = True
									ElseIf dlgCustomUnitComparison2.bUseBothUnits Then
										array6(i).UnitName = array6(i).UnitName.Trim() + "_local"
										CUSTOMPU.AddCustomPU(array6(i), text5, True)
										flag7 = True
									End If
								End If
							End If
						Next
					Catch ex6 As Exception
					End Try
				End If
				If flag OrElse flag2 Then
					If flag3 OrElse flag4 OrElse flag5 OrElse flag6 OrElse flag7 Then
						If flag3 OrElse flag4 OrElse flag5 OrElse flag6 Then
							Dim fileInfo As FileInfo = New FileInfo(text)
							If fileInfo.Exists Then
								Try
									text6 = text.ToUpper().Replace(".MDB", ".BKP")
									Try
										If FILEUTIL.FileExists(text6) Then
											FileSystem.Kill(text6)
										End If
									Catch ex7 As Exception
									End Try
									File.Copy(text, text6)
									Try
										Application.DoEvents()
										fileInfo.Delete()
									Catch ex8 As Exception
									End Try
								Catch ex9 As Exception
								End Try
							End If
							fileInfo = New FileInfo(text2)
							If fileInfo.Exists Then
								Try
									File.Copy(text2, text)
								Catch ex10 As Exception
								End Try
							End If
						ElseIf flag7 Then
							Dim fileInfo As FileInfo = New FileInfo(text4)
							If fileInfo.Exists Then
								Try
									text6 = text4.ToUpper().Replace(".MDB", ".BKP")
									Try
										If FILEUTIL.FileExists(text6) Then
											FileSystem.Kill(text6)
										End If
									Catch ex11 As Exception
									End Try
									File.Copy(text4, text6)
									Try
										Application.DoEvents()
										fileInfo.Delete()
									Catch ex12 As Exception
									End Try
								Catch ex13 As Exception
								End Try
							End If
							fileInfo = New FileInfo(text3)
							If fileInfo.Exists Then
								Try
									File.Copy(text3, text4)
								Catch ex14 As Exception
								End Try
							End If
						End If
						MessageBox.Show("Databases synchonized!")
					Else
						MessageBox.Show("Databases synchonized!")
					End If
				End If
			Catch ex15 As Exception
			End Try
		End Sub

		Public Function LoadCustomizedUnitListManufacturerLists(ByRef iRet As Integer) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Me.CustomizedUnitTypeInfoList = New RSWIN_DESC.UnitTypeInfo(0) {}
				Try
					Dim num As Integer = -1
					Dim fileName As String
					FILEUTIL.LocateFile("UNITINFO32.PUD", fileName, 2S, False, False, False, False)
					Dim num2 As Short = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num2), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
					Dim unitTypeInfo As RSWIN_DESC.UnitTypeInfo
					Dim num3 As Short = CShort((FileSystem.LOF(CInt(num2)) / CLng(Strings.Len(unitTypeInfo))))
					Dim array As RSWIN_DESC.UnitTypeInfo() = New RSWIN_DESC.UnitTypeInfo(0) {}
					Dim num4 As Integer = 0
					Dim text As String = Strings.Space(16384)
					Dim num5 As Short = 1S
					Dim num6 As Short = num3
					For num7 As Short = num5 To num6
						Dim fileNumber As Integer = CInt(num2)
						Dim valueType As ValueType = unitTypeInfo
						FileSystem.FileGet(fileNumber, valueType, -1L)
						Dim valueType2 As ValueType = valueType
						Dim unitTypeInfo2 As RSWIN_DESC.UnitTypeInfo
						unitTypeInfo = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.UnitTypeInfo), unitTypeInfo2)
						Dim expression As String
						FILEUTIL.LocateFile(Strings.RTrim(unitTypeInfo.Abbrev) + "32.PUD", expression, 0S, False, False, False, False)
						If Strings.Len(expression) > 0 Then
							If num4 = 0 Then
								array = New RSWIN_DESC.UnitTypeInfo(1) {}
							Else
								array = CType(Utils.CopyArray(CType(array, Array), New RSWIN_DESC.UnitTypeInfo(1 + num4 + 1 - 1) {}), RSWIN_DESC.UnitTypeInfo())
							End If
							num4 += 1
							array(num4) = unitTypeInfo
							iRet = Custom.CustomPumpingUnitLists_SelectRow(unitTypeInfo.Abbrev.Trim(), text, False, "")
							Dim num8 As Short = CShort(text.Trim().Length)
							If iRet > 0 Then
								num += 1
								Me.CustomizedUnitTypeInfoList = CType(Utils.CopyArray(CType(Me.CustomizedUnitTypeInfoList, Array), New RSWIN_DESC.UnitTypeInfo(num + 1 - 1) {}), RSWIN_DESC.UnitTypeInfo())
								Me.CustomizedUnitTypeInfoList(num) = array(num4)
							End If
						End If
					Next
					FileSystem.FileClose(New Integer() { CInt(num2) })
					If num <> -1 Then
						iRet = num + 1
						result = True
					Else
						iRet = -1
						result = False
					End If
				Catch ex As Exception
					Dim sMsg As String = "Error in LoadCustomizedUnitListManufacturerLists: " + ex.Message
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
					result = False
				End Try
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Public Function IsInCustomUnits(CustomPumpUnits As RSWIN_DESC.PUDataRec(), CustomPumpingUnit As RSWIN_DESC.PUDataRec, ByRef iFound As Integer) As Object
			' The following expression was wrapped in a checked-statement
			Dim result As Object
			Try
				Dim flag As Boolean = False
				Dim obj As Object = Information.UBound(CustomPumpUnits, 1)
				iFound = 0
				Dim num As Integer = 1
				Dim num2 As Integer = Conversions.ToInteger(obj)
				For i As Integer = num To num2
					If Operators.CompareString(CustomPumpUnits(i).Manuf.Trim(), CustomPumpingUnit.Manuf.Trim(), False) = 0 And Operators.CompareString(CustomPumpUnits(i).UnitName.Trim(), CustomPumpingUnit.UnitName.Trim(), False) = 0 Then
						flag = True
						iFound = i
						Exit For
					End If
				Next
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsInCustomPumpingUnitList(CustomPumpUnitList As RSWIN_DESC.CustomPumpUnitList(), CustomPumpingUnitListItem As RSWIN_DESC.CustomPumpUnitList, ByRef iFound As Integer) As Object
			' The following expression was wrapped in a checked-statement
			Dim result As Object
			Try
				Dim flag As Boolean = False
				Dim obj As Object = Information.UBound(CustomPumpUnitList, 1)
				iFound = 0
				Dim num As Integer = 1
				Dim num2 As Integer = Conversions.ToInteger(obj)
				For i As Integer = num To num2
					If Operators.CompareString(CustomPumpUnitList(i).Manufacturer, CustomPumpingUnitListItem.Manufacturer, False) = 0 Then
						flag = True
						iFound = i
						Exit For
					End If
				Next
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsInCustomRodGradeDB(CustomRodGradeItem As RSWIN_DESC.CustomRodGrade, CustomRodGradeList As RSWIN_DESC.CustomRodGrade()) As Object
			' The following expression was wrapped in a checked-statement
			Dim result As Object
			Try
				Dim flag As Boolean = False
				Dim num As Integer = 1
				Dim num2 As Integer = Information.UBound(CustomRodGradeList, 1)
				For i As Integer = num To num2
					If Operators.CompareString(CustomRodGradeList(i).RodType, CustomRodGradeItem.RodType, False) = 0 Then
						flag = True
						Exit For
					End If
				Next
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub ReassignVariables()
			Try
				Me.sARSCustomPU = Util.AssignValueToConstant("RswinSetup", "sARSCustomPU", "Are you sure you want to delete this custom pumping unit?")
				Me.sARSFormat = Util.AssignValueToConstant("RswinSetup", "sARSFormat", "Are you sure you want to delete this format")
				Me.sSelectSSFolder = Util.AssignValueToConstant("RswinSetup", "sSelectSSFolder", "Select the folder for creating batch mode spreadsheet files:")
				Me.sSelectRSFolder = Util.AssignValueToConstant("RswinSetup", "sSelectRSFolder", "Select the folder which contains the RODSTAR files to process:")
				Me.sSelectServerDBFolder = Util.AssignValueToConstant("RswinSetup", "sSelectDBFolder", "Select the folder on server which contains program databases:")
				Me.sGeneral = Util.AssignValueToConstant("RswinSetup", "sGeneral", "General")
				Me.sBatchMode = Util.AssignValueToConstant("RswinSetup", "sBatchMode", "Batch Mode")
				Me.sCostDatabase = Util.AssignValueToConstant("RswinSetup", "sCostDatabase", "Cost Database")
				Me.sDefaults = Util.AssignValueToConstant("RswinSetup", "sDefaults", "Defaults")
				Me.sExpert = Util.AssignValueToConstant("RswinSetup", "sExpert", "AI Mode Preferences")
				Me.sAdmin = Util.AssignValueToConstant("RswinSetup", "sAdmin", "Admin Preferences")
				Me.sOutputOptions = Util.AssignValueToConstant("RswinSetup", "sOutputOptions", "Output Options")
				Me.sPumpingUnitOptions = Util.AssignValueToConstant("RswinSetup", "sPumpingUnitOptions", "Pumping Unit Options")
				Me.sCustomizePumpingUnitList = Util.AssignValueToConstant("RswinSetup", "sCustomizePumpingUnitList", "Customize Pumping Unit List")
				Me.sMeasuredPumpingUnitList = Util.AssignValueToConstant("RswinSetup", "sMeasuredPumpingUnitList", "Measured Pumping Unit List")
				Me.sPumpingUnitCostDatabase = Util.AssignValueToConstant("RswinSetup", "sPumpingUnitCostDatabase", "Pumping Unit Cost Database")
				Me.sRodGradeOptions = Util.AssignValueToConstant("RswinSetup", "sRodGradeOptions", "Rod Grade Options")
				Me.sCustomizeRodGrades = Util.AssignValueToConstant("RswinSetup", "sCustomizeRodGrades", "Custom Rod Grades")
				Me.sNone = Util.AssignValueToConstant("RswinSetup", "sNone", "(none)")
				Me.sAM = Util.AssignValueToConstant("RswinSetup", "sAM", "AM")
				Me.sPM = Util.AssignValueToConstant("RswinSetup", "sPM", "PM")
				Me.csHDR_APIDES = Util.AssignValueToConstant("RswinSetup", "csHDR_APIDES", "API designation")
				Me.csHDR_MANUF = Util.AssignValueToConstant("RswinSetup", "csHDR_MANUF", "Manufacturer")
				Me.csHDR_OTHER = Util.AssignValueToConstant("RswinSetup", "csHDR_OTHER", "Other info")
				Me.csHDR_SINKERBAR = Util.AssignValueToConstant("RswinSetup", "csHDR_SINKERBAR", "Sinker bar")
				Me.csHDR_STRESS = Util.AssignValueToConstant("RswinSetup", "csHDR_STRESS", "Stress method")
				Me.csHDR_TENSILE = Util.AssignValueToConstant("RswinSetup", "csHDR_TENSILE", "Tensile strength")
				Me.csHDR_UNAME = Util.AssignValueToConstant("RswinSetup", "csHDR_UNAME", "Unit name")
				Me.csHDR_RodType = Util.AssignValueToConstant("RswinSetup", "csHDR_RODTYPE", "Rod type")
				Me.sARSCustomRG = Util.AssignValueToConstant("RswinSetup", "sARSCustomRG", "Are you sure you want to delete this custom rod grade?")
				Me.sPleaseSelectSSFormat = Util.AssignValueToConstant("RswinSetup", "sPleaseSelectSSFormat", "Please select a spreadsheet format.")
			Catch ex As Exception
			End Try
		End Sub

		Public Function AreUnitsEqual(Unit1 As RSWIN_DESC.PUDataRec, Unit2 As RSWIN_DESC.PUDataRec) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				Try
					If Operators.CompareString(Unit1.Manuf, Unit2.Manuf, False) <> 0 Or Operators.CompareString(Unit1.APIDesignation, Unit2.APIDesignation, False) <> 0 Or Operators.CompareString(Unit1.UnitName, Unit2.UnitName, False) <> 0 Or Operators.CompareString(Unit1.OtherInfo, Unit2.OtherInfo, False) <> 0 Or Unit1.UnitType <> Unit2.UnitType Then
						flag = False
					End If
					If flag Then
						Dim unitType As Integer = CInt(Unit1.UnitType)
						If unitType <> 10 AndAlso (Unit1.RequiredRotation <> Unit2.RequiredRotation Or Unit1.CrankRotation <> Unit2.CrankRotation) Then
							flag = False
						End If
						If Unit1.CrankHoles <> Unit2.CrankHoles Then
							flag = False
						End If
						Dim crankHoles As Integer
						If Unit1.CrankHoles > Unit2.CrankHoles Then
							crankHoles = CInt(Unit1.CrankHoles)
						Else
							crankHoles = CInt(Unit2.CrankHoles)
						End If
						Dim num As Integer = 0
						Dim num2 As Integer = crankHoles - 1
						For i As Integer = num To num2
							If Unit1.CrankRadii(i) <> Unit2.CrankRadii(i) Then
								flag = False
								Exit For
							End If
						Next
						Dim num3 As Integer = 0
						Dim num4 As Integer = crankHoles - 1
						For i As Integer = num3 To num4
							If Unit1.Strokes(i) <> Unit2.Strokes(i) Then
								flag = False
								Exit For
							End If
						Next
						If Unit1.KinematicStroke <> Unit2.KinematicStroke Or Unit1.R <> Unit2.R Then
							flag = False
						End If
						If unitType <> 7 And unitType <> 10 And unitType <> 5 And unitType <> 6 And unitType <> 9 Then
							If Unit1.A <> Unit2.A Or Unit1.C <> Unit2.C Or Unit1.I <> Unit2.I Or Unit1.K <> Unit2.K Then
								flag = False
							End If
							If unitType <> 9 AndAlso Unit1.P <> Unit2.P Then
								flag = False
							End If
						End If
						If unitType = 6 AndAlso (Unit1.M <> Unit2.M Or Unit1.S <> Unit2.S Or Unit1.V0 <> Unit2.V0) Then
							flag = False
						End If
						If(unitType = 7 Or unitType = 10) AndAlso (Unit1.DrumDiamRatio <> Unit2.DrumDiamRatio Or Unit1.SprocketRadius <> Unit2.SprocketRadius Or Unit1.SprocketDistance <> Unit2.SprocketDistance) Then
							flag = False
						End If
						If(unitType <> 6 And unitType <> 7 And unitType <> 10 And unitType <> 9) AndAlso (Unit1.Unbalance <> Unit2.Unbalance Or Unit1.CrankOffset <> Unit2.CrankOffset) Then
							flag = False
						End If
						If Unit1.StructRating <> Unit2.StructRating Or Unit1.GearboxRating <> Unit2.GearboxRating Or Unit1.MaxStroke <> Unit2.MaxStroke Or Unit1.ArtInertia <> Unit2.ArtInertia Then
							flag = False
						End If
					End If
					result = flag
				Catch ex As Exception
					result = False
				End Try
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		Private Sub btnSynch_Click(sender As Object, e As EventArgs)
			Try
				Me.btnVerifyFiles.PerformClick()
			Catch ex As Exception
			End Try
			Try
				Me.btnVerifyData.PerformClick()
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub chkReportOpt_7_CheckedChanged_1(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkReportOpt_7 AndAlso Me.chkReportOpt_7.Checked Then
				MessageBox.Show("Selecting this option will only omit the header and plots from this page on the computer display. The printout will not be affected.")
			End If
		End Sub

		Private Sub txtMaxSideLoadLimit_Enter(sender As Object, e As EventArgs)
			Me.txtMaxSideLoadLimit.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtMaxSideLoadLimit_Leave(sender As Object, e As EventArgs)
			Dim num As Single = Conversions.ToSingle(Me.txtMaxSideLoadLimit.Text)
			Dim text As String = "GuideToUse"
			Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
			Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
			RSWIN_DESC.MOLDED = CShort(molded)
			RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
			Dim sideLoadPerGuide As Single = Me.GetSideLoadPerGuide(RSWIN_DESC.SETUP_GuideToUse)
			Dim num2 As Single = CSng((0.4 * CDbl(sideLoadPerGuide)))
			Dim num3 As Single = CSng((0.8 * CDbl(sideLoadPerGuide)))
			text = "##"
			Dim str As String = Util.Format(num2, text)
			text = "##"
			Dim str2 As String = Util.Format(num3, text)
			RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(Me.txtMaxSideLoadLimit.Text)
			text = "MaxSideLoadLimit"
			Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_MaxSideLoadLimit)
			RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
			RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(text2)
			If Not(RSWIN_DESC.SETUP_MaxSideLoadLimit < num2 Or RSWIN_DESC.SETUP_MaxSideLoadLimit > num3) Then
				Dim txtMaxSideLoadLimit As TextBox = Me.txtMaxSideLoadLimit
				Dim lblMaxSideLoadLimit As Label = Me.lblMaxSideLoadLimit
				CtrlUI.TextBox_LostFocus(txtMaxSideLoadLimit, lblMaxSideLoadLimit, True)
				Me.lblMaxSideLoadLimit = lblMaxSideLoadLimit
				Me.txtMaxSideLoadLimit = txtMaxSideLoadLimit
				Return
			End If
			MessageBox.Show("The minimum side load for recommending rod guides should be between " + str + " and " + str2)
			If RSWIN_DESC.SETUP_MaxSideLoadLimit < 0F Or RSWIN_DESC.SETUP_MaxSideLoadLimit > sideLoadPerGuide Then
				Me.txtMaxSideLoadLimit.Focus()
				Return
			End If
			Me.txtMaxSideLoadLimit.BackColor = RSWIN_DESC.rgbEditComplete
		End Sub

		Private Sub txtMaxSideLoadLimit_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.txtMaxSideLoadLimit.Text) And Me.ActiveControl Is Me.txtMaxSideLoadLimit Then
				Dim text As String = "GuideToUse"
				Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
				Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
				RSWIN_DESC.MOLDED = CShort(molded)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
				Dim sideLoadPerGuide As Single = Me.GetSideLoadPerGuide(RSWIN_DESC.SETUP_GuideToUse)
				Dim num As Single = CSng((0.4 * CDbl(sideLoadPerGuide)))
				Dim num2 As Single = CSng((0.8 * CDbl(sideLoadPerGuide)))
				text = "##"
				Dim str As String = Util.Format(num, text)
				text = "##"
				Dim str2 As String = Util.Format(num2, text)
				RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(Me.txtMaxSideLoadLimit.Text)
				text = "MaxSideLoadLimit"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_MaxSideLoadLimit)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(text2)
				If RSWIN_DESC.SETUP_MaxSideLoadLimit > num2 Then
					MessageBox.Show("The minimum side load for recommending rod guides should be between " + str + " and " + str2)
				End If
				Return
			End If
		End Sub

		Private Function GetSideLoadPerGuide(iGuideType As Integer) As Single
			Dim result As Single
			If iGuideType = CInt(RSWIN_DESC.MOLDED) Then
				result = RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD
			ElseIf iGuideType = 2 Then
				result = RSWIN_DESC.SETUP_WHEELGUIDE_LOAD
			ElseIf iGuideType = 3 Then
				result = RSWIN_DESC.SETUP_OTHERGUIDE_LOAD
			ElseIf iGuideType = 4 OrElse iGuideType = CInt(RSWIN_DESC.NorrisSidewinderGuide) OrElse iGuideType = 6 OrElse iGuideType = 7 OrElse iGuideType = 8 OrElse iGuideType = 9 OrElse iGuideType = 10 OrElse iGuideType = 11 Then
				Dim num As Single
				If num = 0F Then
					Try
						' The following expression was wrapped in a checked-expression
						MImpred.GetSidewinderNameAndLoad(CShort(iGuideType), num)
					Catch ex As Exception
					End Try
				End If
				result = num
			Else
				result = RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD
			End If
			Return result
		End Function

		Private Sub txtNumImplIters_Enter(sender As Object, e As EventArgs)
			Me.txtNumImplIters.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtNumImplIters_Leave(sender As Object, e As EventArgs)
			Dim txtNumImplIters As TextBox = Me.txtNumImplIters
			Dim lblIterations As Label = Me.lblIterations
			CtrlUI.TextBox_LostFocus(txtNumImplIters, lblIterations, True)
			Me.lblIterations = lblIterations
			Me.txtNumImplIters = txtNumImplIters
		End Sub

		Private Sub txtRodGuideOverlap_Enter(sender As Object, e As EventArgs)
			Me.txtRodGuideOverlap.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtRodGuideOverlap_KeyDown(sender As Object, e As KeyEventArgs)
			Dim txtRodGuideOverlap As TextBox = Me.txtRodGuideOverlap
			Dim lblRodGuideOverlap As Label = Me.lblRodGuideOverlap
			CtrlUI.TextBox_KeyDown(txtRodGuideOverlap, lblRodGuideOverlap, CInt(e.KeyCode), If((-If((e.Shift > False), 1, 0)), 1, 0))
			Me.lblRodGuideOverlap = lblRodGuideOverlap
			Me.txtRodGuideOverlap = txtRodGuideOverlap
		End Sub

		Private Sub txtRodGuideOverlap_Leave(sender As Object, e As EventArgs)
			Dim txtRodGuideOverlap As Control = Me.txtRodGuideOverlap
			Me.Control__LostFocus(txtRodGuideOverlap)
			Me.txtRodGuideOverlap = CType(txtRodGuideOverlap, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtRodGuideOverlap, True, False, obj) Then
				Return
			End If
			If Conversion.Val(Me.txtRodGuideOverlap.Text) <= 400.0 And Conversion.Val(Me.txtRodGuideOverlap.Text) >= 300.0 Then
				MessageBox.Show("Using a rod guide overlap greater than 300 feet (91.44 m) may cause problems in Rod Guide Implementation results.")
			ElseIf(Conversion.Val(Me.txtRodGuideOverlap.Text) < 150.0 Or Conversion.Val(Me.txtRodGuideOverlap.Text) > 400.0) And Conversion.Val(Me.txtRodGuideOverlap.Text) <> 0.0 Then
				MessageBox.Show("Rod Guide Overlap must be between 150 feet (45.72 m) and 400 feet (121.92 m). Enter zero for no overlap.")
				Me.txtRodGuideOverlap.Focus()
			Else
				Dim txtRodGuideOverlap2 As TextBox = Me.txtRodGuideOverlap
				Dim lblRodGuideOverlap As Label = Me.lblRodGuideOverlap
				Me.TextBox__LostFocus(txtRodGuideOverlap2, lblRodGuideOverlap, True)
				Me.lblRodGuideOverlap = lblRodGuideOverlap
				Me.txtRodGuideOverlap = txtRodGuideOverlap2
				ini.SaveDataValue("RodGuideOverlap", RuntimeHelpers.GetObjectValue(obj))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.Setup_RodGuideOverlap = Conversions.ToInteger(obj)
				End If
			End If
		End Sub

		Private Sub txtRodGuideOverlap_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.txtRodGuideOverlap.Text) And Me.ActiveControl Is Me.txtRodGuideOverlap Then
				RSWIN_DESC.Setup_RodGuideOverlap = Conversions.ToInteger(Me.txtRodGuideOverlap.Text)
				Dim text As String = "RodGuideOverlap"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.Setup_RodGuideOverlap)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.Setup_RodGuideOverlap = Conversions.ToInteger(text2)
				If RSWIN_DESC.Setup_RodGuideOverlap = 0 Then
					MessageBox.Show("It is recommended to use a rod guide overlap of at least 150 feet (45.72 m).")
				End If
				Return
			End If
		End Sub

		Private Sub txtNumRodsPerBundle_Enter(sender As Object, e As EventArgs)
			Me.txtNumRodsPerBundle.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtNumRodsPerBundle_Leave(sender As Object, e As EventArgs)
			Dim txtNumRodsPerBundle As Control = Me.txtNumRodsPerBundle
			Me.Control__LostFocus(txtNumRodsPerBundle)
			Me.txtNumRodsPerBundle = CType(txtNumRodsPerBundle, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtNumRodsPerBundle, True, False, obj) Then
				Return
			End If
			If Conversion.Val(Me.txtNumRodsPerBundle.Text) < 10.0 Or Conversion.Val(Me.txtNumRodsPerBundle.Text) > 60.0 Then
				MessageBox.Show("The number of rods per segment should be between 10 and 60. ")
				Me.txtNumRodsPerBundle.Focus()
			Else
				If Conversion.Val(Me.txtNumRodsPerBundle.Text) < 30.0 Then
					MessageBox.Show("If the number of rods per segment is less than 30 it may result in too many rod sections. If that happens the program will use the default value of 30.")
				End If
				Dim txtNumRodsPerBundle2 As TextBox = Me.txtNumRodsPerBundle
				Dim lblNumRodsPerBundle As Label = Me.lblNumRodsPerBundle
				Me.TextBox__LostFocus(txtNumRodsPerBundle2, lblNumRodsPerBundle, True)
				Me.lblNumRodsPerBundle = lblNumRodsPerBundle
				Me.txtNumRodsPerBundle = txtNumRodsPerBundle2
				RSWIN_DESC.Setup_NumRodsPerBundle = CInt(Math.Round(Conversion.Val(Me.txtNumRodsPerBundle.Text)))
				Dim text As String = "NumRodsPerBundle"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.Setup_NumRodsPerBundle)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.Setup_NumRodsPerBundle = Conversions.ToInteger(text2)
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					RSWIN_DESC.Setup_RodGuideOverlap = Conversions.ToInteger(obj)
				End If
			End If
		End Sub

		Private Sub txtNumRodsPerBundle_SizeChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtNumRodsPerBundle_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.txtNumRodsPerBundle.Text) And Me.ActiveControl Is Me.txtNumRodsPerBundle Then
				' The following expression was wrapped in a checked-expression
				RSWIN_DESC.Setup_NumRodsPerBundle = CInt(Math.Round(Conversion.Val(Me.txtNumRodsPerBundle.Text)))
				Dim text As String = "NumRodsPerBundle"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.Setup_NumRodsPerBundle)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.Setup_NumRodsPerBundle = Conversions.ToInteger(text2)
				If RSWIN_DESC.Setup_NumRodsPerBundle > 60 Then
					MessageBox.Show("The number of rods per segment should be between 10 and 60. ")
				End If
				Return
			End If
		End Sub

		Private Sub cboParaffinRodGuide_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.cboParaffinRodGuide AndAlso Me.cboParaffinRodGuide.Items.Count > 0 AndAlso Strings.Len(Me.cboParaffinRodGuide.Text) > 0 Then
				Dim setup_ParaffinRodGuide As Integer = Conversions.ToInteger(Me.cboParaffinRodGuide.SelectedValue)
				RSWIN_DESC.SETUP_ParaffinRodGuide = setup_ParaffinRodGuide
			End If
		End Sub

		Private Sub cboParaffinRodGuide_Leave(sender As Object, e As EventArgs)
			Me.cboParaffinRodGuide.BackColor = Color.White
		End Sub

		Private Sub AddToGuideArrayList(bAdd As Boolean, ByRef myAL As ArrayList, iValue As Integer, sDisplayValue As String, iOrder As Integer, sAbbrName As String, sXMLstring As String)
			If Operators.CompareString(sAbbrName, "", False) = 0 Then
				sAbbrName = sDisplayValue
			End If
			If Operators.CompareString(sXMLstring, "", False) = 0 Then
				sXMLstring = sDisplayValue
			End If
			If bAdd Then
				myAL.Add(New cRodGuide(iValue, sDisplayValue, iOrder, sAbbrName, sXMLstring))
				Me.$STATIC$AddToGuideArrayList$20712101281458E8EE$iCount = myAL.Count
				Return
			End If
			myAL.Insert(Me.$STATIC$AddToGuideArrayList$20712101281458E8EE$iCount, New cRodGuide(iValue, sDisplayValue, iOrder, sAbbrName, sXMLstring))
		End Sub

		Private Sub PopulateParaffinRodGuideCombo()
			Try
				Me.myRodGuideAL.Clear()
				Me.AddToGuideArrayList(True, Me.myRodGuideAL, 0, "Bare Rod (no rod guides)", 1, "", "")
				Me.AddToGuideArrayList(True, Me.myRodGuideAL, CInt(RSWIN_DESC.MOLDED), "Molded", 2, "", "")
				Me.AddToGuideArrayList(True, Me.myRodGuideAL, 2, "Wheeled", 3, "", "")
				Me.AddToGuideArrayList(True, Me.myRodGuideAL, 3, RSWIN_DESC.sOtherGuided, 4, "", "")
				Me.AddToGuideArrayList(True, Me.myRodGuideAL, 4, "Norris Standard", 5, "", "")
				Me.AddToGuideArrayList(True, Me.myRodGuideAL, CInt(RSWIN_DESC.NorrisSidewinderGuide), "Norris Sidewinder", 6, "", "")
				Me.AddToGuideArrayList(True, Me.myRodGuideAL, 6, "RGI Jake Coupling", 7, "", "")
				Me.AddToGuideArrayList(True, Me.myRodGuideAL, 7, "RGI SVT", 8, "", "")
				Me.AddToGuideArrayList(True, Me.myRodGuideAL, 8, "RGI Tomahawk", 9, "", "")
				Me.AddToGuideArrayList(True, Me.myRodGuideAL, 9, "RGI Tornado", 10, "", "")
				Me.AddToGuideArrayList(True, Me.myRodGuideAL, 10, "RGI Twister", 11, "", "")
				Me.AddToGuideArrayList(True, Me.myRodGuideAL, 11, "RGI WVT", 12, "", "")
				Me.cboParaffinRodGuide.Items.Clear()
				Me.cboParaffinRodGuide.DataSource = Nothing
				Me.cboParaffinRodGuide.DataSource = Me.myRodGuideAL
				Me.cboParaffinRodGuide.DisplayMember = "DisplayName"
				Me.cboParaffinRodGuide.ValueMember = "RodGuideID"
			Catch ex As Exception
				Dim sMsg As String = "Error in PopulateParaffinRodGuideCombo: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub chkReportOpt_10_Click(sender As Object, e As EventArgs)
			Me.chkReportOpt_Click_1(10, Me.chkReportOpt_10.Checked, True)
		End Sub

		Private Sub chkRelocateSB_CheckedChanged(sender As Object, e As EventArgs)
			If Me.chkRelocateSB.Checked Then
				Me.txtInclinationLimit.Enabled = True
				Me.lblInclinationLimit.Enabled = True
				RSWIN_DESC.Setup_bAlterSBPumpDepth = -1S
			Else
				Me.txtInclinationLimit.Enabled = False
				Me.lblInclinationLimit.Enabled = False
				RSWIN_DESC.Setup_bAlterSBPumpDepth = 0S
			End If
			If Me.chkRelocateSB Is Me.ActiveControl Then
				Dim text As String = "AlterSBPumpDepth"
				Dim text2 As String = Convert.ToString(RSWIN_DESC.Setup_bAlterSBPumpDepth)
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.frmMain.ToolbarButtonSetState2(2, False)
				Return
			End If
		End Sub

		Private Sub txtInclinationLimit_Leave(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-expression
			If(If((-If((Conversion.Val(Me.txtInclinationLimit.Text) >= 4.0 > False), 1L, 0L)), 1L, 0L) And CLng(Math.Round(Conversion.Val(Conversions.ToDouble(Me.txtInclinationLimit.Text) <= 50.0)))) <> 0L Then
				RSWIN_DESC.Setup_fInclinationLimit = Conversions.ToSingle(Me.txtInclinationLimit.Text)
				Dim text As String = "InclinationLimit"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.Setup_fInclinationLimit)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.Setup_fInclinationLimit = Conversions.ToSingle(text2)
				RSWIN_DESC.frmMain.ToolbarButtonSetState2(2, False)
				Return
			End If
			MessageBox.Show(RSWIN_DESC.sInclinationLimit)
			Me.txtInclinationLimit.Focus()
		End Sub

		Private Sub txtInclinationLimit_TextChanged(sender As Object, e As EventArgs)
			If Me.txtInclinationLimit Is Me.ActiveControl Then
				' The following expression was wrapped in a checked-expression
				If(If((-If((Conversion.Val(Me.txtInclinationLimit.Text) >= 4.0 > False), 1L, 0L)), 1L, 0L) And CLng(Math.Round(Conversion.Val(Conversions.ToDouble(Me.txtInclinationLimit.Text) <= 50.0)))) <> 0L Then
					RSWIN_DESC.Setup_fInclinationLimit = Conversions.ToSingle(Me.txtInclinationLimit.Text)
					Dim text As String = "InclinationLimit"
					Dim text2 As String = Conversions.ToString(RSWIN_DESC.Setup_fInclinationLimit)
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
					RSWIN_DESC.Setup_fInclinationLimit = Conversions.ToSingle(text2)
					RSWIN_DESC.frmMain.ToolbarButtonSetState2(2, False)
				End If
				Return
			End If
		End Sub

		Public Sub SetDefaultSideloadLimit()
			Try
				Dim sideLoadPerGuide As Single = Me.GetSideLoadPerGuide(RSWIN_DESC.SETUP_GuideToUse)
				Dim num As Single = CSng((0.6 * CDbl(sideLoadPerGuide)))
				Me.txtMaxSideLoadLimit.Text = Conversions.ToString(num)
				RSWIN_DESC.SETUP_MaxSideLoadLimit = num
			Catch ex As Exception
			End Try
		End Sub

		Public Sub CheckMinMaxNumberOfGuides()
			Dim text As String = ""
			Dim flag As Boolean = False
			Dim num As Integer
			If Versioned.IsNumeric(Me.txtMinNumGuides.Text) Then
				If RSWIN_DESC.SETUP_GuideToUse >= 6 Or RSWIN_DESC.SETUP_GuideToUse < 4 Then
					num = 3
				ElseIf RSWIN_DESC.SETUP_GuideToUse >= 4 Then
					num = 4
				Else
					num = 3
				End If
				If Convert.ToInt32(Me.txtMinNumGuides.Text) <> num Then
					If RSWIN_DESC.SETUP_GuideToUse < 4 Then
						text = String.Format(RSWIN_DESC.sGenericGuideMinMaxWarning, num, RSWIN_DESC.iMaxGuide)
					Else
						text = String.Format(RSWIN_DESC.sManufacturerGuideMinMaxWarning, num, RSWIN_DESC.iMaxGuide)
					End If
					Me.txtMinNumGuides.Text = num.ToString()
					RSWIN_DESC.SETUP_MinNumGuidesPerRod = Conversions.ToInteger(Me.txtMinNumGuides.Text)
					Dim text2 As String = "MinNumGuidesPerRod"
					Dim text3 As String = Conversions.ToString(RSWIN_DESC.SETUP_MinNumGuidesPerRod)
					Dim num2 As Short = CShort(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, RSWIN_DESC.sINIFile))
					RSWIN_DESC.SETUP_MinNumGuidesPerRod = Conversions.ToInteger(text3)
					Dim num3 As Short = num2
					flag = True
				End If
			End If
			If Convert.ToInt32(Me.txtMaxNumGuides.Text) <> RSWIN_DESC.iMaxGuide Then
				If RSWIN_DESC.SETUP_GuideToUse < 4 Then
					text = String.Format(RSWIN_DESC.sGenericGuideMinMaxWarning, num, RSWIN_DESC.iMaxGuide)
				Else
					text = String.Format(RSWIN_DESC.sManufacturerGuideMinMaxWarning, num, RSWIN_DESC.iMaxGuide)
				End If
				Me.txtMaxNumGuides.Text = RSWIN_DESC.iMaxGuide.ToString()
				RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(Me.txtMaxNumGuides.Text)
				Dim text3 As String = "MaxNumGuidesPerRod"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod)
				Dim num4 As Short = CShort(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile))
				RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(text2)
				Dim num3 As Short = num4
				flag = True
			End If
			If flag Then
				MessageBox.Show(text)
				Return
			End If
		End Sub

		Private CurrentNodeName As String

		<AccessedThroughProperty("dlgPUList")>
		Private _dlgPUList As dlgPUList

		<AccessedThroughProperty("dlgCustomRG")>
		Private _dlgCustomRG As dlgCustomRG

		<AccessedThroughProperty("dlgCustomPU")>
		Private _dlgCustomPU As dlgCustomPU

		<AccessedThroughProperty("dlgWK1Setup")>
		Private _dlgWK1Setup As dlgWK1Setup

		<AccessedThroughProperty("dlgSelectDir")>
		Private _dlgSelectDir As dlgSelectDir

		<AccessedThroughProperty("frmDisplayAllDatabaseTemplates")>
		Private _frmDisplayAllDatabaseTemplates As db_guru_admin_form

		Private adiDefaults As RSWIN_DESC.DEFAULTITEM()

		Private colContainers As Collection

		Private mcCustomRodGrades As Integer

		Private miOldMeasurementSystem As Short

		Private msCaption As String

		Private UnitTypeInfoList As RSWIN_DESC.UnitTypeInfo()

		Private UnitData As RSWIN_DESC.PUDataRec()

		Private mvRodLoadingFG As Single

		Private mvRodLoadingSteel As Single

		Private m_bSuppressMinMsg As Boolean

		Private Const cCoverPage As Integer = -1

		Private Const cCALCULATIONS As Integer = 0

		Private Const cCOSTANALYSIS As Integer = 1

		Private Const cIPRDATA As Integer = 2

		Private Const cDYNO_PRED As Integer = 3

		Private Const cDevChart As Integer = 4

		Private Const cGuideReport As Integer = 5

		Private Const cDYNO_ACTUAL As Integer = 6

		Private Const cSummary As Integer = 7

		Private Const cReportDevSurvey As Integer = 8

		Private Const cScoring As Integer = 9

		Private Const cOrderPage As Integer = 10

		Private RodGrade_AL As ArrayList

		Private sARSCustomPU As String

		Private sARSFormat As String

		Private sSelectSSFolder As String

		Private sSelectRSFolder As String

		Private sSelectServerDBFolder As String

		Private sGeneral As String

		Private sBatchMode As String

		Private sCostDatabase As String

		Private sDefaults As String

		Private sExpert As String

		Private sAdmin As String

		Private sOutputOptions As String

		Private sPumpingUnitOptions As String

		Private sCustomizePumpingUnitList As String

		Private sMeasuredPumpingUnitList As String

		Private sPumpingUnitCostDatabase As String

		Private sRodGradeOptions As String

		Private sCustomizeRodGrades As String

		Private sNone As String

		Private sAM As String

		Private sPM As String

		Private csHDR_APIDES As String

		Private csHDR_MANUF As String

		Private csHDR_OTHER As String

		Private csHDR_SINKERBAR As String

		Private csHDR_STRESS As String

		Private csHDR_TENSILE As String

		Private csHDR_UNAME As String

		Private csHDR_RodType As String

		Private sARSCustomRG As String

		Private sPleaseSelectSSFormat As String

		Private sNonStandardSuckerRodLengthMsg As String

		Private Const csKEY_APIDES As String = "APIDesignation"

		Private Const csKEY_COST As String = "Cost"

		Private Const csKEY_DBKEY As String = "DBKey"

		Private Const csKEY_LABEL As String = "Label"

		Private Const csKEY_MANUF As String = "Manufacturer"

		Private Const csKEY_OTHER As String = "OtherInfo"

		Private Const czKey_LOCATION As String = "UnitLocation"

		Private Const csKEY_SINKERBAR As String = "SinkerBar"

		Private Const csKEY_STRESS As String = "StressMethod"

		Private Const csKEY_TENSILE As String = "TensileStrength"

		Private Const csKEY_UNAME As String = "UnitName"

		Private Const csKEY_BATCH As String = "Batch"

		Private Const csKEY_COSTSPU As String = "CostsPU"

		Private Const csKEY_COSTSRG As String = "CostsRG"

		Private Const csKEY_CUSTOMPUDB As String = "CustomPUDB"

		Private Const csKEY_CUSTOMRG As String = "CustomRG"

		Private Const csKEY_DEBUG As String = "Debug"

		Private Const csKEY_DEFAULTS As String = "Defaults"

		Private Const csKEY_GENERAL As String = "General"

		Private Const csKEY_MEASPU As String = "MeasPU"

		Private Const csKEY_OUTPUT As String = "Output"

		Private Const csKEY_PUINFO As String = "PUInfo"

		Private Const csKEY_RGINFO As String = "RGInfo"

		Public mdsRSCostDB As DataSet

		Public mdsPUCostDB As DataSet

		Public mdsGuideCostDB As DataSet

		Public bRSCostDB_Changed As Boolean

		Public bPUCostDB_Changed As Boolean

		Public bGuideCostDB_Changed As Boolean

		Private iOldMeasurementSystem As Integer

		Private Const KEY_MANUF As Integer = 1

		Private Const KEY_APIDES As Integer = 2

		Private Const KEY_UNAME As Integer = 3

		Private Const KEY_OTHER As Integer = 4

		Private iKEY_APIDES As Integer

		Private iKEY_MANUF As Integer

		Private iKEY_OTHER As Integer

		Private iKEY_UNAME As Integer

		Private sFortySpaces As String

		Private m_bInAfterEnterEdit As Boolean

		Private m_bInAfterCellUpdate As Boolean

		Private objActiveCell As UltraGridCell

		Private objPreviousCell As UltraGridCell

		Private BatchNode As TreeNode

		Private iPanelLeft As Integer

		Private APIRods_AL As ArrayList

		Private HighStrengthRods_AL As ArrayList

		Private HighStrengthProrods_AL As ArrayList

		Private FGlassRods_AL As ArrayList

		Private SinkerBarsGrade_AL As ArrayList

		Private SinkerRodsGrade_AL As ArrayList

		Private bExpertLoaded As Boolean

		Private sFmt As String

		Private SAVE_SETUP_MeasurementSystem As Integer

		Private bCancel As Boolean

		Private SAVE_SETUP_GuideToUse As Integer

		Private m_NowTime As DateTime

		Private m_bEnd As Boolean

		Private myRodGuideAL As ArrayList

		Private bViewingAIPreferences As Boolean

		Private myKeyValueHT As Hashtable

		Private iSaveIndex As Integer

		Private StartPoint As Object

		<AccessedThroughProperty("_Label_CasingSizeOD")>
		Private __Label_CasingSizeOD As Label

		<AccessedThroughProperty("cboCasingSize")>
		Private _cboCasingSize As ComboBox

		<AccessedThroughProperty("lblcboCasingSize_Disabled")>
		Private _lblcboCasingSize_Disabled As Label

		<AccessedThroughProperty("pnlAdmin")>
		Private _pnlAdmin As Panel

		<AccessedThroughProperty("grpGuruAdmin")>
		Private _grpGuruAdmin As GroupBox

		<AccessedThroughProperty("chkDebug")>
		Private _chkDebug As CheckBox

		<AccessedThroughProperty("btnDiplayAllTemplates")>
		Private _btnDiplayAllTemplates As Button

		<AccessedThroughProperty("rbtUseTemplateFiles")>
		Private _rbtUseTemplateFiles As RadioButton

		<AccessedThroughProperty("rbtUseTemplateDatabase")>
		Private _rbtUseTemplateDatabase As RadioButton

		<AccessedThroughProperty("lblStatus2")>
		Private _lblStatus2 As Label

		<AccessedThroughProperty("lblCasingSize")>
		Private _lblCasingSize As Label

		<AccessedThroughProperty("txtCasingSize")>
		Private _txtCasingSize As TextBox

		<AccessedThroughProperty("TreeView2")>
		Private _TreeView2 As TreeView

		Private CustomizedUnitTypeInfoList As RSWIN_DESC.UnitTypeInfo()

		Private OD As String()

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("udMin")>
		Private _udMin As NumericUpDown

		<AccessedThroughProperty("udHour")>
		Private _udHour As NumericUpDown

		<AccessedThroughProperty("lblExitIfIdle")>
		Private _lblExitIfIdle As Label

		<AccessedThroughProperty("chkExitIfIdle")>
		Private _chkExitIfIdle As CheckBox

		<AccessedThroughProperty("udSec_notused")>
		Private _udSec_notused As NumericUpDown

		<AccessedThroughProperty("tmrClock")>
		Private _tmrClock As System.Windows.Forms.Timer

		<AccessedThroughProperty("chkSaveOpenFileOnExit")>
		Private _chkSaveOpenFileOnExit As CheckBox

		<AccessedThroughProperty("lblHRS")>
		Private _lblHRS As Label

		<AccessedThroughProperty("lblMIN")>
		Private _lblMIN As Label

		<AccessedThroughProperty("grpRodElement")>
		Private _grpRodElement As GroupBox

		<AccessedThroughProperty("lblRodElementLimit")>
		Private _lblRodElementLimit As Label

		<AccessedThroughProperty("chkUseDefaultRodElementLimit")>
		Private _chkUseDefaultRodElementLimit As CheckBox

		<AccessedThroughProperty("txtRodElementLimit")>
		Private _txtRodElementLimit As TextBox

		<AccessedThroughProperty("txtMDInt")>
		Private _txtMDInt As TextBox

		<AccessedThroughProperty("lblDoglegLimit")>
		Private _lblDoglegLimit As Label

		<AccessedThroughProperty("txtDoglegLimit")>
		Private _txtDoglegLimit As TextBox

		<AccessedThroughProperty("lblMDInt")>
		Private _lblMDInt As Label

		<AccessedThroughProperty("chkExcelInstalled")>
		Private _chkExcelInstalled As CheckBox

		<AccessedThroughProperty("pnlGuideCostDB")>
		Private _pnlGuideCostDB As Panel

		<AccessedThroughProperty("ulgGuideCostDB")>
		Private _ulgGuideCostDB As UltraGrid

		<AccessedThroughProperty("_optCostCategory_2")>
		Private __optCostCategory_2 As RadioButton

		<AccessedThroughProperty("btnVerify")>
		Private _btnVerify As Button

		<AccessedThroughProperty("rbtUseBoth")>
		Private _rbtUseBoth As RadioButton

		<AccessedThroughProperty("chkFixTubingSize")>
		Private _chkFixTubingSize As CheckBox

		<AccessedThroughProperty("txtBareRodFricCoeff")>
		Private _txtBareRodFricCoeff As TextBox

		<AccessedThroughProperty("rbtBareRod")>
		Private _rbtBareRod As RadioButton

		<AccessedThroughProperty("lblSideLoadperRodGuide")>
		Private _lblSideLoadperRodGuide As Label

		<AccessedThroughProperty("cmdResetFrictions")>
		Private _cmdResetFrictions As Button

		<AccessedThroughProperty("pnlUseGeneral")>
		Private _pnlUseGeneral As Panel

		<AccessedThroughProperty("chkUseClosestUnit")>
		Private _chkUseClosestUnit As CheckBox

		<AccessedThroughProperty("chkUseGeneral")>
		Private _chkUseGeneral As CheckBox

		<AccessedThroughProperty("chkCreatePDFs")>
		Private _chkCreatePDFs As CheckBox

		<AccessedThroughProperty("grpUseServerDatabase")>
		Private _grpUseServerDatabase As GroupBox

		<AccessedThroughProperty("rbtUseServerLocation")>
		Private _rbtUseServerLocation As RadioButton

		<AccessedThroughProperty("rptUseLocalDatabase")>
		Private _rptUseLocalDatabase As RadioButton

		<AccessedThroughProperty("txtDBServerFolder")>
		Private _txtDBServerFolder As TextBox

		<AccessedThroughProperty("btnBrowseForServerFolder")>
		Private _btnBrowseForServerFolder As Button

		<AccessedThroughProperty("lblDBServerFolder")>
		Private _lblDBServerFolder As Label

		<AccessedThroughProperty("btnVerifyFiles")>
		Private _btnVerifyFiles As Button

		<AccessedThroughProperty("btnVerifyData")>
		Private _btnVerifyData As Button

		<AccessedThroughProperty("btnSynch")>
		Private _btnSynch As Button

		<AccessedThroughProperty("txtMaxSideLoadLimit")>
		Private _txtMaxSideLoadLimit As TextBox

		<AccessedThroughProperty("lblMaxSideLoadLimit")>
		Private _lblMaxSideLoadLimit As Label

		<AccessedThroughProperty("txtNumImplIters")>
		Private _txtNumImplIters As TextBox

		<AccessedThroughProperty("lblIterations")>
		Private _lblIterations As Label

		<AccessedThroughProperty("txtRodGuideOverlap")>
		Private _txtRodGuideOverlap As TextBox

		<AccessedThroughProperty("lblRodGuideOverlap")>
		Private _lblRodGuideOverlap As Label

		<AccessedThroughProperty("txtNumRodsPerBundle")>
		Private _txtNumRodsPerBundle As TextBox

		<AccessedThroughProperty("lblNumRodsPerBundle")>
		Private _lblNumRodsPerBundle As Label

		<AccessedThroughProperty("lblParaffinGuides")>
		Private _lblParaffinGuides As Label

		<AccessedThroughProperty("cboParaffinRodGuide")>
		Private _cboParaffinRodGuide As ComboBox

		<AccessedThroughProperty("chkReportOpt_10")>
		Private _chkReportOpt_10 As CheckBox

		<AccessedThroughProperty("imgPreview_10")>
		Private _imgPreview_10 As PictureBox

		<AccessedThroughProperty("chkRelocateSB")>
		Private _chkRelocateSB As CheckBox

		<AccessedThroughProperty("lblInclinationLimit")>
		Private _lblInclinationLimit As Label

		<AccessedThroughProperty("txtInclinationLimit")>
		Private _txtInclinationLimit As TextBox

		Private nOD As Short

		<AccessedThroughProperty("pnlGeneral")>
		Private _pnlGeneral As Panel

		<AccessedThroughProperty("grpSystemOfUnits")>
		Private _grpSystemOfUnits As GroupBox

		<AccessedThroughProperty("chkShowVisualInputWindow")>
		Private _chkShowVisualInputWindow As CheckBox

		<AccessedThroughProperty("cboDigitizerComPort")>
		Private _cboDigitizerComPort As ComboBox

		<AccessedThroughProperty("lblDigitizerComPort")>
		Private _lblDigitizerComPort As Label

		<AccessedThroughProperty("grpPreferences")>
		Private _grpPreferences As GroupBox

		<AccessedThroughProperty("rbtEnglish")>
		Private _rbtEnglish As RadioButton

		<AccessedThroughProperty("rbtCanadian")>
		Private _rbtCanadian As RadioButton

		<AccessedThroughProperty("rbtMetric")>
		Private _rbtMetric As RadioButton

		<AccessedThroughProperty("pnlDefaults")>
		Private _pnlDefaults As Panel

		<AccessedThroughProperty("lblItem")>
		Private _lblItem As Label

		<AccessedThroughProperty("lblDefault")>
		Private _lblDefault As Label

		<AccessedThroughProperty("lblDefaultType")>
		Private _lblDefaultType As Label

		<AccessedThroughProperty("pnlBatchMode")>
		Private _pnlBatchMode As Panel

		<AccessedThroughProperty("grpAutomaticBatchMode")>
		Private _grpAutomaticBatchMode As GroupBox

		<AccessedThroughProperty("grpSpreadSheetSetup")>
		Private _grpSpreadSheetSetup As GroupBox

		<AccessedThroughProperty("lblBatchMode")>
		Private _lblBatchMode As Label

		<AccessedThroughProperty("lblSelect")>
		Private _lblSelect As Label

		<AccessedThroughProperty("lblTimeToBeginRuns")>
		Private _lblTimeToBeginRuns As Label

		<AccessedThroughProperty("lblSSDir")>
		Private _lblSSDir As Label

		<AccessedThroughProperty("nmUDHour")>
		Private _nmUDHour As NumericUpDown

		<AccessedThroughProperty("nmUDMinute")>
		Private _nmUDMinute As NumericUpDown

		<AccessedThroughProperty("cboAMPM")>
		Private _cboAMPM As ComboBox

		<AccessedThroughProperty("pnlOutputOptions")>
		Private _pnlOutputOptions As Panel

		<AccessedThroughProperty("grpOutputOptions")>
		Private _grpOutputOptions As GroupBox

		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		<AccessedThroughProperty("grpOutputPages")>
		Private _grpOutputPages As GroupBox

		<AccessedThroughProperty("btnOK")>
		Private _btnOK As Button

		<AccessedThroughProperty("btnCancel")>
		Private _btnCancel As Button

		<AccessedThroughProperty("lstWK1Formats")>
		Private _lstWK1Formats As ListBox

		<AccessedThroughProperty("lstSorted")>
		Private _lstSorted As ListBox

		<AccessedThroughProperty("lstDefaultItems")>
		Private _lstDefaultItems As ListBox

		<AccessedThroughProperty("cboDefault")>
		Private _cboDefault As ComboBox

		<AccessedThroughProperty("txtDefault")>
		Private _txtDefault As TextBox

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As Panel

		<AccessedThroughProperty("imgPreview_4")>
		Private _imgPreview_4 As PictureBox

		<AccessedThroughProperty("imgPreview_2")>
		Private _imgPreview_2 As PictureBox

		<AccessedThroughProperty("chkReportOpt_3")>
		Private _chkReportOpt_3 As CheckBox

		<AccessedThroughProperty("chkReportOpt_2")>
		Private _chkReportOpt_2 As CheckBox

		<AccessedThroughProperty("chkSkipProcessedFiles")>
		Private _chkSkipProcessedFiles As CheckBox

		<AccessedThroughProperty("chkPrintResults")>
		Private _chkPrintResults As CheckBox

		<AccessedThroughProperty("txtWK1Dir")>
		Private _txtWK1Dir As TextBox

		<AccessedThroughProperty("pnlDebug")>
		Private _pnlDebug As Panel

		<AccessedThroughProperty("chkDebugShowMessages")>
		Private _chkDebugShowMessages As CheckBox

		<AccessedThroughProperty("chkDebugDisableOnError")>
		Private _chkDebugDisableOnError As CheckBox

		<AccessedThroughProperty("chkDebugShowPredictInfo")>
		Private _chkDebugShowPredictInfo As CheckBox

		<AccessedThroughProperty("chkDebugSetNcycles")>
		Private _chkDebugSetNcycles As CheckBox

		<AccessedThroughProperty("chkDebugCreateDYN")>
		Private _chkDebugCreateDYN As CheckBox

		<AccessedThroughProperty("chkDebugShowAllBalanced")>
		Private _chkDebugShowAllBalanced As CheckBox

		<AccessedThroughProperty("chkDebugCreateTF")>
		Private _chkDebugCreateTF As CheckBox

		<AccessedThroughProperty("chkDebugCreateTQ")>
		Private _chkDebugCreateTQ As CheckBox

		<AccessedThroughProperty("chkDebugCreateDPC")>
		Private _chkDebugCreateDPC As CheckBox

		<AccessedThroughProperty("_Label_16")>
		Private __Label_16 As Label

		<AccessedThroughProperty("_Label_15")>
		Private __Label_15 As Label

		<AccessedThroughProperty("_Label_14")>
		Private __Label_14 As Label

		<AccessedThroughProperty("_Label_13")>
		Private __Label_13 As Label

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("cboManufMenuCustomDB")>
		Private _cboManufMenuCustomDB As ComboBox

		<AccessedThroughProperty("pnlCustomizeRGList")>
		Private _pnlCustomizeRGList As Panel

		<AccessedThroughProperty("pnlCustomPUList")>
		Private _pnlCustomPUList As Panel

		<AccessedThroughProperty("pnlCustomMeasuredPUList")>
		Private _pnlCustomMeasuredPUList As Panel

		<AccessedThroughProperty("cmdDeleteCustomPU")>
		Private _cmdDeleteCustomPU As Button

		<AccessedThroughProperty("cmdModifyCustomPU")>
		Private _cmdModifyCustomPU As Button

		<AccessedThroughProperty("cmdNewCustomPU")>
		Private _cmdNewCustomPU As Button

		<AccessedThroughProperty("lvwCustomPU")>
		Private _lvwCustomPU As ListView

		<AccessedThroughProperty("Manufacturer")>
		Private _Manufacturer As System.Windows.Forms.ColumnHeader

		<AccessedThroughProperty("APIDesignation")>
		Private _APIDesignation As System.Windows.Forms.ColumnHeader

		<AccessedThroughProperty("UnitName")>
		Private _UnitName As System.Windows.Forms.ColumnHeader

		<AccessedThroughProperty("OtherInfo")>
		Private _OtherInfo As System.Windows.Forms.ColumnHeader

		<AccessedThroughProperty("cmdBrowse_2")>
		Private _cmdBrowse_2 As Button

		<AccessedThroughProperty("cmdBrowse_0")>
		Private _cmdBrowse_0 As Button

		<AccessedThroughProperty("chkCreateWK1")>
		Private _chkCreateWK1 As CheckBox

		<AccessedThroughProperty("optCRGMismatch_1")>
		Private _optCRGMismatch_1 As RadioButton

		<AccessedThroughProperty("optCRGMismatch_0")>
		Private _optCRGMismatch_0 As RadioButton

		<AccessedThroughProperty("cmdModifyCustomRG")>
		Private _cmdModifyCustomRG As Button

		<AccessedThroughProperty("cmdNewCustomRG")>
		Private _cmdNewCustomRG As Button

		<AccessedThroughProperty("cmdDeleteCustomRG")>
		Private _cmdDeleteCustomRG As Button

		<AccessedThroughProperty("ToolTip1")>
		Private _ToolTip1 As System.Windows.Forms.ToolTip

		<AccessedThroughProperty("pnlDebugOptions")>
		Private _pnlDebugOptions As Panel

		<AccessedThroughProperty("grpDebugOpt")>
		Private _grpDebugOpt As GroupBox

		<AccessedThroughProperty("chkDebugFixSinusoidalDyno")>
		Private _chkDebugFixSinusoidalDyno As CheckBox

		<AccessedThroughProperty("chkDebugTreatAsSolidLine")>
		Private _chkDebugTreatAsSolidLine As CheckBox

		<AccessedThroughProperty("chkDebugNoFIReplaceGoodMatch")>
		Private _chkDebugNoFIReplaceGoodMatch As CheckBox

		<AccessedThroughProperty("chkDebugShowMatchInfo")>
		Private _chkDebugShowMatchInfo As CheckBox

		<AccessedThroughProperty("chkDebugMessages")>
		Private _chkDebugMessages As CheckBox

		<AccessedThroughProperty("chkDebugShowPredictInfo2")>
		Private _chkDebugShowPredictInfo2 As CheckBox

		<AccessedThroughProperty("RodType")>
		Private _RodType As System.Windows.Forms.ColumnHeader

		<AccessedThroughProperty("StressMethod")>
		Private _StressMethod As System.Windows.Forms.ColumnHeader

		<AccessedThroughProperty("SinkerBar")>
		Private _SinkerBar As System.Windows.Forms.ColumnHeader

		<AccessedThroughProperty("TensileStrength")>
		Private _TensileStrength As System.Windows.Forms.ColumnHeader

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		<AccessedThroughProperty("chkViewWK1")>
		Private _chkViewWK1 As CheckBox

		<AccessedThroughProperty("chkAzDirToolbar")>
		Private _chkAzDirToolbar As CheckBox

		<AccessedThroughProperty("_SSFrame_8")>
		Private __SSFrame_8 As GroupBox

		<AccessedThroughProperty("txtWheelLoad")>
		Private _txtWheelLoad As TextBox

		<AccessedThroughProperty("txtMoldedLoad")>
		Private _txtMoldedLoad As TextBox

		<AccessedThroughProperty("_SSFrame_3")>
		Private __SSFrame_3 As GroupBox

		<AccessedThroughProperty("txtMaxSteelLoading")>
		Private _txtMaxSteelLoading As TextBox

		<AccessedThroughProperty("txtMaxFGLoading")>
		Private _txtMaxFGLoading As TextBox

		<AccessedThroughProperty("CheckBox4")>
		Private _CheckBox4 As CheckBox

		<AccessedThroughProperty("CheckBox5")>
		Private _CheckBox5 As CheckBox

		<AccessedThroughProperty("CheckBox6")>
		Private _CheckBox6 As CheckBox

		<AccessedThroughProperty("CheckBox7")>
		Private _CheckBox7 As CheckBox

		<AccessedThroughProperty("CheckBox8")>
		Private _CheckBox8 As CheckBox

		<AccessedThroughProperty("CheckBox9")>
		Private _CheckBox9 As CheckBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("optNcycles_0")>
		Private _optNcycles_0 As RadioButton

		<AccessedThroughProperty("optNcycles_1")>
		Private _optNcycles_1 As RadioButton

		<AccessedThroughProperty("optNcycles_2")>
		Private _optNcycles_2 As RadioButton

		<AccessedThroughProperty("optNcycles_3")>
		Private _optNcycles_3 As RadioButton

		<AccessedThroughProperty("lblMaxFGLoading")>
		Private _lblMaxFGLoading As Label

		<AccessedThroughProperty("lblMaxSteelLoading")>
		Private _lblMaxSteelLoading As Label

		<AccessedThroughProperty("pnlSetupCostDB")>
		Private _pnlSetupCostDB As Panel

		<AccessedThroughProperty("panContainer")>
		Private _panContainer As Panel

		<AccessedThroughProperty("_optCostCategory_0")>
		Private __optCostCategory_0 As RadioButton

		<AccessedThroughProperty("_optCostCategory_1")>
		Private __optCostCategory_1 As RadioButton

		<AccessedThroughProperty("_panCostCategory_1")>
		Private __panCostCategory_1 As Panel

		<AccessedThroughProperty("cboRodType")>
		Private _cboRodType As ComboBox

		<AccessedThroughProperty("cmdRSLoadCostDB")>
		Private _cmdRSLoadCostDB As Button

		<AccessedThroughProperty("_Label_3")>
		Private __Label_3 As Label

		<AccessedThroughProperty("_Label_4")>
		Private __Label_4 As Label

		<AccessedThroughProperty("_panCostCategory_0")>
		Private __panCostCategory_0 As Panel

		<AccessedThroughProperty("cboPUManuf")>
		Private _cboPUManuf As ComboBox

		<AccessedThroughProperty("cmdPULoadCostDB")>
		Private _cmdPULoadCostDB As Button

		<AccessedThroughProperty("_Label_6")>
		Private __Label_6 As Label

		<AccessedThroughProperty("_Label_7")>
		Private __Label_7 As Label

		<AccessedThroughProperty("_Label_8")>
		Private __Label_8 As Label

		<AccessedThroughProperty("_Label_9")>
		Private __Label_9 As Label

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("_Line_0")>
		Private __Line_0 As Label

		<AccessedThroughProperty("_Line_1")>
		Private __Line_1 As Label

		<AccessedThroughProperty("cmdCheckData")>
		Private _cmdCheckData As Button

		<AccessedThroughProperty("pnlPUCostDB")>
		Private _pnlPUCostDB As Panel

		<AccessedThroughProperty("pnlRSCostDB")>
		Private _pnlRSCostDB As Panel

		<AccessedThroughProperty("ulgPUCostDB")>
		Private _ulgPUCostDB As UltraGrid

		<AccessedThroughProperty("ulgRSCostDB")>
		Private _ulgRSCostDB As UltraGrid

		<AccessedThroughProperty("lblOtherInfo")>
		Private _lblOtherInfo As Label

		<AccessedThroughProperty("lblUnitName")>
		Private _lblUnitName As Label

		<AccessedThroughProperty("lblAPIDesignation")>
		Private _lblAPIDesignation As Label

		<AccessedThroughProperty("chkReportOpt_0")>
		Private _chkReportOpt_0 As CheckBox

		<AccessedThroughProperty("chkReportOpt_7")>
		Private _chkReportOpt_7 As CheckBox

		<AccessedThroughProperty("chkReportOpt_1")>
		Private _chkReportOpt_1 As CheckBox

		<AccessedThroughProperty("imgPreview_0")>
		Private _imgPreview_0 As PictureBox

		<AccessedThroughProperty("imgPreview_1")>
		Private _imgPreview_1 As PictureBox

		<AccessedThroughProperty("chkReportOpt_6")>
		Private _chkReportOpt_6 As CheckBox

		<AccessedThroughProperty("chkReportOpt_4")>
		Private _chkReportOpt_4 As CheckBox

		<AccessedThroughProperty("chkReportOpt_5")>
		Private _chkReportOpt_5 As CheckBox

		<AccessedThroughProperty("imgPreview_3")>
		Private _imgPreview_3 As PictureBox

		<AccessedThroughProperty("imgPreview_5")>
		Private _imgPreview_5 As PictureBox

		<AccessedThroughProperty("chkAllowSlideFric")>
		Private _chkAllowSlideFric As CheckBox

		<AccessedThroughProperty("optMolded")>
		Private _optMolded As RadioButton

		<AccessedThroughProperty("optWheel")>
		Private _optWheel As RadioButton

		<AccessedThroughProperty("optOther")>
		Private _optOther As RadioButton

		<AccessedThroughProperty("txtMaxNumGuides")>
		Private _txtMaxNumGuides As TextBox

		<AccessedThroughProperty("txtOtherLoad")>
		Private _txtOtherLoad As TextBox

		<AccessedThroughProperty("grpRatio")>
		Private _grpRatio As GroupBox

		<AccessedThroughProperty("lblGearBoxRatio")>
		Private _lblGearBoxRatio As Label

		<AccessedThroughProperty("txtGearBoxRatio")>
		Private _txtGearBoxRatio As TextBox

		<AccessedThroughProperty("txtVBeltRatio")>
		Private _txtVBeltRatio As TextBox

		<AccessedThroughProperty("lblVBeltRatio")>
		Private _lblVBeltRatio As Label

		<AccessedThroughProperty("chkCalcVBelt")>
		Private _chkCalcVBelt As CheckBox

		<AccessedThroughProperty("txtNumCycles")>
		Private _txtNumCycles As TextBox

		<AccessedThroughProperty("lblNumCycles")>
		Private _lblNumCycles As Label

		<AccessedThroughProperty("grpPredictMode")>
		Private _grpPredictMode As GroupBox

		<AccessedThroughProperty("optDeviated")>
		Private _optDeviated As RadioButton

		<AccessedThroughProperty("optVertical")>
		Private _optVertical As RadioButton

		<AccessedThroughProperty("grpLanguages")>
		Private _grpLanguages As GroupBox

		<AccessedThroughProperty("rbtChinese")>
		Private _rbtChinese As RadioButton

		<AccessedThroughProperty("rbtSpan")>
		Private _rbtSpan As RadioButton

		<AccessedThroughProperty("rbtEng")>
		Private _rbtEng As RadioButton

		<AccessedThroughProperty("lblRODSTARDataDict")>
		Private _lblRODSTARDataDict As Label

		<AccessedThroughProperty("txtRODSTARDir")>
		Private _txtRODSTARDir As TextBox

		<AccessedThroughProperty("btnDefault")>
		Private _btnDefault As Button

		<AccessedThroughProperty("txtWheelFricCoeff")>
		Private _txtWheelFricCoeff As TextBox

		<AccessedThroughProperty("txtMoldedFricCoeff")>
		Private _txtMoldedFricCoeff As TextBox

		<AccessedThroughProperty("lblFricCoeff")>
		Private _lblFricCoeff As Label

		<AccessedThroughProperty("txtOtherFricCoeff")>
		Private _txtOtherFricCoeff As TextBox

		<AccessedThroughProperty("lblWeightAdjustFactor")>
		Private _lblWeightAdjustFactor As Label

		<AccessedThroughProperty("txtWeightAdjustFactor")>
		Private _txtWeightAdjustFactor As TextBox

		<AccessedThroughProperty("chkUseFluidInertiaPumpLoadAdj")>
		Private _chkUseFluidInertiaPumpLoadAdj As CheckBox

		<AccessedThroughProperty("cboRodGrade")>
		Private _cboRodGrade As ComboBox

		<AccessedThroughProperty("pnlExpert")>
		Private _pnlExpert As Panel

		<AccessedThroughProperty("grpPumpUnitManufacturer_Preferences")>
		Private _grpPumpUnitManufacturer_Preferences As GroupBox

		<AccessedThroughProperty("grpTubingSizePreferences")>
		Private _grpTubingSizePreferences As GroupBox

		<AccessedThroughProperty("grpPumpTypePreference")>
		Private _grpPumpTypePreference As GroupBox

		<AccessedThroughProperty("grpRodPreferences")>
		Private _grpRodPreferences As GroupBox

		<AccessedThroughProperty("lblRSFGGrade")>
		Private _lblRSFGGrade As Label

		<AccessedThroughProperty("lblRSGrade")>
		Private _lblRSGrade As Label

		<AccessedThroughProperty("cboHighStrengthRods")>
		Private _cboHighStrengthRods As ComboBox

		<AccessedThroughProperty("cboFGlassRods")>
		Private _cboFGlassRods As ComboBox

		<AccessedThroughProperty("cboManufMenu4")>
		Private _cboManufMenu4 As ComboBox

		<AccessedThroughProperty("cboManufMenu3")>
		Private _cboManufMenu3 As ComboBox

		<AccessedThroughProperty("cboManufMenu2")>
		Private _cboManufMenu2 As ComboBox

		<AccessedThroughProperty("cboManufMenu1")>
		Private _cboManufMenu1 As ComboBox

		<AccessedThroughProperty("lblSinkerBars")>
		Private _lblSinkerBars As Label

		<AccessedThroughProperty("lblSinkerRods")>
		Private _lblSinkerRods As Label

		<AccessedThroughProperty("cboSinkerRodsGrade")>
		Private _cboSinkerRodsGrade As ComboBox

		<AccessedThroughProperty("cboSinkerBarsGrade")>
		Private _cboSinkerBarsGrade As ComboBox

		<AccessedThroughProperty("optSinkerRods")>
		Private _optSinkerRods As RadioButton

		<AccessedThroughProperty("optSinkerBars")>
		Private _optSinkerBars As RadioButton

		<AccessedThroughProperty("txtMinTubingSizeOD")>
		Private _txtMinTubingSizeOD As TextBox

		<AccessedThroughProperty("txtMaxTubingSizeOD")>
		Private _txtMaxTubingSizeOD As TextBox

		<AccessedThroughProperty("cboMaxTubingSizeOD")>
		Private _cboMaxTubingSizeOD As ComboBox

		<AccessedThroughProperty("cboMinTubingSizeOD")>
		Private _cboMinTubingSizeOD As ComboBox

		<AccessedThroughProperty("txtMinTubingSizeID")>
		Private _txtMinTubingSizeID As TextBox

		<AccessedThroughProperty("txtMaxTubingSizeID")>
		Private _txtMaxTubingSizeID As TextBox

		<AccessedThroughProperty("_Label_MaxTubingSizeOD")>
		Private __Label_MaxTubingSizeOD As Label

		<AccessedThroughProperty("_Label_MinTubingSizeOD")>
		Private __Label_MinTubingSizeOD As Label

		<AccessedThroughProperty("_Label_MinTubingSizeID")>
		Private __Label_MinTubingSizeID As Label

		<AccessedThroughProperty("_Label_MaxTubingSizeID")>
		Private __Label_MaxTubingSizeID As Label

		<AccessedThroughProperty("chkTubingPump")>
		Private _chkTubingPump As CheckBox

		<AccessedThroughProperty("chkLargeBorePump")>
		Private _chkLargeBorePump As CheckBox

		<AccessedThroughProperty("chkRodstarTubingSizeRec")>
		Private _chkRodstarTubingSizeRec As CheckBox

		<AccessedThroughProperty("grpRodTubingFricCoeffPref")>
		Private _grpRodTubingFricCoeffPref As GroupBox

		<AccessedThroughProperty("lblUseXTimes")>
		Private _lblUseXTimes As Label

		<AccessedThroughProperty("lblcboMaxTubingSizeOD_Disabled")>
		Private _lblcboMaxTubingSizeOD_Disabled As Label

		<AccessedThroughProperty("lblcboMinTubingSizeOD_Disabled")>
		Private _lblcboMinTubingSizeOD_Disabled As Label

		<AccessedThroughProperty("NumericUpDown1_XTimes")>
		Private _NumericUpDown1_XTimes As NumericUpDown

		<AccessedThroughProperty("chkInsertPump")>
		Private _chkInsertPump As CheckBox

		<AccessedThroughProperty("chkRodstarPumpTypeRec")>
		Private _chkRodstarPumpTypeRec As CheckBox

		<AccessedThroughProperty("lblchkInsertPump_Disabled")>
		Private _lblchkInsertPump_Disabled As Label

		<AccessedThroughProperty("lblchkTubingPump_Disabled")>
		Private _lblchkTubingPump_Disabled As Label

		<AccessedThroughProperty("lblchkLargeBorePump_Disabled")>
		Private _lblchkLargeBorePump_Disabled As Label

		<AccessedThroughProperty("chkTubingAnchored")>
		Private _chkTubingAnchored As CheckBox

		<AccessedThroughProperty("lblchkTubingAnchored_Disabled")>
		Private _lblchkTubingAnchored_Disabled As Label

		<AccessedThroughProperty("chkRodstarTubingAnchoredRec")>
		Private _chkRodstarTubingAnchoredRec As CheckBox

		<AccessedThroughProperty("grpTubingAnchoredPreference")>
		Private _grpTubingAnchoredPreference As GroupBox

		<AccessedThroughProperty("pnlUseRodOnly")>
		Private _pnlUseRodOnly As Panel

		<AccessedThroughProperty("imgPreview_6")>
		Private _imgPreview_6 As PictureBox

		<AccessedThroughProperty("chkReportOpt_8")>
		Private _chkReportOpt_8 As CheckBox

		<AccessedThroughProperty("chkOptimizeSurvey")>
		Private _chkOptimizeSurvey As CheckBox

		<AccessedThroughProperty("lblManufacturer4")>
		Private _lblManufacturer4 As Label

		<AccessedThroughProperty("lblManufacturer3")>
		Private _lblManufacturer3 As Label

		<AccessedThroughProperty("lblManufacturer2")>
		Private _lblManufacturer2 As Label

		<AccessedThroughProperty("lblManufacturer8")>
		Private _lblManufacturer8 As Label

		<AccessedThroughProperty("lblManufacturer7")>
		Private _lblManufacturer7 As Label

		<AccessedThroughProperty("lblManufacturer6")>
		Private _lblManufacturer6 As Label

		<AccessedThroughProperty("lblManufacturer5")>
		Private _lblManufacturer5 As Label

		<AccessedThroughProperty("cboManufMenu8")>
		Private _cboManufMenu8 As ComboBox

		<AccessedThroughProperty("cboManufMenu7")>
		Private _cboManufMenu7 As ComboBox

		<AccessedThroughProperty("cboManufMenu6")>
		Private _cboManufMenu6 As ComboBox

		<AccessedThroughProperty("cboManufMenu5")>
		Private _cboManufMenu5 As ComboBox

		<AccessedThroughProperty("chkManufacturer1")>
		Private _chkManufacturer1 As CheckBox

		<AccessedThroughProperty("chkManufacturer2")>
		Private _chkManufacturer2 As CheckBox

		<AccessedThroughProperty("chkManufacturer3")>
		Private _chkManufacturer3 As CheckBox

		<AccessedThroughProperty("chkManufacturer4")>
		Private _chkManufacturer4 As CheckBox

		<AccessedThroughProperty("chkManufacturer5")>
		Private _chkManufacturer5 As CheckBox

		<AccessedThroughProperty("chkManufacturer6")>
		Private _chkManufacturer6 As CheckBox

		<AccessedThroughProperty("chkManufacturer7")>
		Private _chkManufacturer7 As CheckBox

		<AccessedThroughProperty("chkManufacturer8")>
		Private _chkManufacturer8 As CheckBox

		<AccessedThroughProperty("txtNorrisFricCoeff")>
		Private _txtNorrisFricCoeff As TextBox

		<AccessedThroughProperty("optSideWinder")>
		Private _optSideWinder As RadioButton

		<AccessedThroughProperty("txtSidewinderLoad")>
		Private _txtSidewinderLoad As TextBox

		<AccessedThroughProperty("txtOther")>
		Private _txtOther As TextBox

		<AccessedThroughProperty("lblGuides")>
		Private _lblGuides As Label

		<AccessedThroughProperty("lblMinNumGuides")>
		Private _lblMinNumGuides As Label

		<AccessedThroughProperty("txtMinNumGuides")>
		Private _txtMinNumGuides As TextBox

		<AccessedThroughProperty("lblMaxNumGuides")>
		Private _lblMaxNumGuides As Label

		<AccessedThroughProperty("rtbDefault")>
		Private _rtbDefault As RichTextBox

		<AccessedThroughProperty("chkReportOpt_")>
		Private _chkReportOpt_ As CheckBox

		<AccessedThroughProperty("imgPreview_")>
		Private _imgPreview_ As PictureBox

		<AccessedThroughProperty("grpMotorPreferences")>
		Private _grpMotorPreferences As GroupBox

		<AccessedThroughProperty("pnlMotorData")>
		Private _pnlMotorData As Panel

		<AccessedThroughProperty("chkIncludeMotorSPV")>
		Private _chkIncludeMotorSPV As CheckBox

		<AccessedThroughProperty("optPowerMeterType_2")>
		Private _optPowerMeterType_2 As RadioButton

		<AccessedThroughProperty("optPowerMeterType_1")>
		Private _optPowerMeterType_1 As RadioButton

		<AccessedThroughProperty("_Label_MeterType")>
		Private __Label_MeterType As Label

		<AccessedThroughProperty("cboUHSProrod")>
		Private _cboUHSProrod As ComboBox

		<AccessedThroughProperty("chkAIUseCustomizedLists")>
		Private _chkAIUseCustomizedLists As CheckBox

		<AccessedThroughProperty("lblServiceFactor")>
		Private _lblServiceFactor As Label

		<AccessedThroughProperty("txtServiceFactorPreference")>
		Private _txtServiceFactorPreference As TextBox

		<AccessedThroughProperty("lblUseAvgFric")>
		Private _lblUseAvgFric As Label

		<AccessedThroughProperty("chkDisplaySBinFeet")>
		Private _chkDisplaySBinFeet As CheckBox

		<AccessedThroughProperty("optUseSteelRodsOnly")>
		Private _optUseSteelRodsOnly As RadioButton

		<AccessedThroughProperty("optUseFGlassWithSteelOnBottom")>
		Private _optUseFGlassWithSteelOnBottom As RadioButton

		<AccessedThroughProperty("chkReportOpt_9")>
		Private _chkReportOpt_9 As CheckBox

		<AccessedThroughProperty("imgPreview_9")>
		Private _imgPreview_9 As PictureBox

		<AccessedThroughProperty("cboSidewinder")>
		Private _cboSidewinder As ComboBox

		<AccessedThroughProperty("grpWarnings")>
		Private _grpWarnings As GroupBox

		<AccessedThroughProperty("chkTargetBFPDWarning")>
		Private _chkTargetBFPDWarning As CheckBox

		<AccessedThroughProperty("chkRunTimeWarning")>
		Private _chkRunTimeWarning As CheckBox

		<AccessedThroughProperty("chkUseAllDiameters")>
		Private _chkUseAllDiameters As CheckBox

		<AccessedThroughProperty("chkPlotAllDownholeCards")>
		Private _chkPlotAllDownholeCards As CheckBox

		<AccessedThroughProperty("lblStatus")>
		Private _lblStatus As Label

		<AccessedThroughProperty("chkUseBucklingTendencyStresses")>
		Private _chkUseBucklingTendencyStresses As CheckBox

		<AccessedThroughProperty("chkUseJohnsFix")>
		Private _chkUseJohnsFix As CheckBox

		<AccessedThroughProperty("chkUseJeffsFix")>
		Private _chkUseJeffsFix As CheckBox

		<AccessedThroughProperty("txtElectricityCostPreference")>
		Private _txtElectricityCostPreference As TextBox

		<AccessedThroughProperty("_Label_ElectricityCost")>
		Private __Label_ElectricityCost As Label

		<AccessedThroughProperty("chkAlwaysSaveXDIAGMeasuredCard")>
		Private _chkAlwaysSaveXDIAGMeasuredCard As CheckBox

		Private Shared m_vb6FormDefInstance As RswinSetup

		Private Shared m_InitializingDefInstance As Boolean

		Private m_DefaultNode As String

		<AccessedThroughProperty("lvwCustomRG")>
		Private _lvwCustomRG As ListView

		<AccessedThroughProperty("btnDeleteSS")>
		Private _btnDeleteSS As Button

		<AccessedThroughProperty("btnNewSS")>
		Private _btnNewSS As Button

		<AccessedThroughProperty("btnModifySS")>
		Private _btnModifySS As Button

		<AccessedThroughProperty("lvwCustomPUDB")>
		Private _lvwCustomPUDB As ListView

		Private MyParentFrm As RODSTAR

		Private $STATIC$btnVerifyFiles_Click$20211C1241$sWin As String

		Private $STATIC$btnVerifyFiles_Click$20211C1241$sWinSys As String

		Private $STATIC$btnVerifyFiles_Click$20211C1241$sAppData As String

		Private $STATIC$AddToGuideArrayList$20712101281458E8EE$iCount As Integer

		Private $STATIC$btnVerifyFiles_Click$20211C1241$sUserProfile As String

		Private $STATIC$btnVerifyFiles_Click$20211C1241$sUserProfileAppData As String

		Private $STATIC$txtElectricityCostPreference_TextChanged$20211C1241$bMsgShown As Boolean

		Private Enum EPUCostColumns
			ecPUCAllColumns
			ecPUCName
			ecPUCCost
			ecPUCDBKey
			ecPUCValue
		End Enum

		Private Enum ERGCostColumns
			ecRGCAllColumns
			ecRGCName
			ecRGCCost
			ecRGCDBKey
			ecRGCValue
		End Enum
	End Class
End Namespace
